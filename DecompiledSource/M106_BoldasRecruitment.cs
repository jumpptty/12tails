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

// Token: 0x02001348 RID: 4936
[Serializable]
public class M106_BoldasRecruitment : MonoBehaviour
{
	// Token: 0x0600719F RID: 29087 RVA: 0x00F84830 File Offset: 0x00F82A30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M106_BoldasRecruitment()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060071A0 RID: 29088 RVA: 0x00F84840 File Offset: 0x00F82A40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (240042 - 249619 != -9576)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (246869 - 411757 != -164887)
			{
				Game.mGameType = 5;
				if (6118 - 366348 == -360230)
				{
					if (Chat.Initialized)
					{
						if (149404 - 446879 == -297474)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (268156 - 275333 == -7176)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (58811 - 174379 != -115568)
						{
							continue;
						}
					}
					this.UeAc8HUNuYk = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (151194 - 483396 == -332202)
					{
						this.VOIc87pBgNV = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (293957 - 192838 == 101119)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060071A1 RID: 29089 RVA: 0x00F84998 File Offset: 0x00F82B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (113457 - 595651 != -482193)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (103503 - 413133 != -309629)
				{
					if (Game.mNextGameCode != 106)
					{
						break;
					}
					if (48059 - 535357 != -487297)
					{
						Game.nextGame();
						if (57642 - 37290 != 20353)
						{
							Game.mGameCode = 106;
							if (264869 - 191885 == 72984)
							{
								Game.mGameType = 5;
								if (187265 - 191330 != -4064)
								{
									Game.mStateTime = Time.time;
									if (192393 - 221378 == -28985)
									{
										Game.mGameScore = 0;
										if (236967 - 14336 != 222632)
										{
											Game.mGameMana = 0;
											if (288823 - 334382 == -45559)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (234625 - 329628 != -95002)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (164646 - 565222 != -400575)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (249191 - 387712 != -138520)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (70695 - 478919 != -408223)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (201598 - 30654 != 170945)
																{
																	this.nu1c84fI8NV = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (184857 - 37289 != 147569)
																	{
																		this.Epac8a5Xr6Y = PhotonClient.Connection;
																		if (109443 - 127963 == -18520)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (215036 - 472799 != -257762)
																			{
																				this.InitGame();
																				if (16809 - 156471 != -139661)
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
				if (127598 - 382987 != -255388)
				{
					Game.mGameType = 99;
					if (35512 - 226848 == -191336)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060071A2 RID: 29090 RVA: 0x00F84C98 File Offset: 0x00F82E98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (25579 - 345810 != -320231)
		{
		}
		for (;;)
		{
			if (this.Epac8a5Xr6Y == null)
			{
				if (23858 - 373395 != -349536)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (118234 - 410013 != -291778)
				{
					if (mGameState == eGameState.Init)
					{
						if (28220 - 207818 == -179598)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (147072 - 455201 != -308128)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (19331 - 259480 == -240149)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (63619 - 524570 != -460950)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (95637 - 95838 != -200)
						{
							if (Game.music != 0)
							{
								if (26297 - 388935 == -362637)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (39509 - 416488 != -376979)
									{
										continue;
									}
									this.audio.Play();
									if (53010 - 438202 != -385192)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (62775 - 584768 == -521993)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (43273 - 362270 == -318997)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (111471 - 44440 != 67032)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (132069 - 497904 != -365834)
						{
							if (Time.time > this.lmnc8sF3Rfu)
							{
								if (179657 - 297139 == -117481)
								{
									continue;
								}
								Game.mGameMana++;
								if (66157 - 503572 == -437414)
								{
									continue;
								}
								this.lmnc8sF3Rfu = Time.time + (float)12;
								if (276474 - 264109 != 12365)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (234567 - 161722 == 72846)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (137079 - 571624 == -434544)
									{
										continue;
									}
									this.audio.Play();
									if (292938 - 166222 != 126716)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (200575 - 356659 == -156084)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (256320 - 121007 == 135313)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (274920 - 526731 == -251811)
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
						if (186707 - 442999 == -256292)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060071A3 RID: 29091 RVA: 0x00F850BC File Offset: 0x00F832BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (70092 - 179917 != -109825)
		{
		}
		while (this.UeAc8HUNuYk)
		{
			if (34662 - 206331 != -171668)
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (280397 - 192299 != 88099)
				{
					if (Time.time - Game.mStateTime <= 0.5f)
					{
						break;
					}
					if (112509 - 384145 != -271635)
					{
						if (Time.time - Game.mStateTime >= 2.5f)
						{
							break;
						}
						if (101098 - 92201 == 8897)
						{
							GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
							if (251256 - 401784 == -150528)
							{
								float num = (float)(1024 * Screen.width / Screen.height);
								if (3570 - 550145 != -546574)
								{
									GUI.depth = 1;
									if (173187 - 564837 != -391649)
									{
										float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime - 0.5f);
										if (4419 - 512247 == -507828)
										{
											float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime - 0.5f, (float)1));
											if (41242 - 23600 == 17642)
											{
												Color color = GUI.color;
												if (148695 - 488860 == -340165)
												{
													color.a = a;
													if (92052 - 90502 != 1551 && 48042 - 34073 != 13970)
													{
														GUI.color = color;
														if (143080 - 388694 == -245614)
														{
															if (280234 - 204432 == 75802)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.UeAc8HUNuYk);
																if (172912 - 254119 != -81206)
																{
																	float a2 = 1f;
																	if (86956 - 417264 == -330308)
																	{
																		Color color2 = GUI.color;
																		if (208299 - 237938 == -29639)
																		{
																			float num3 = color2.a = a2;
																			if (208140 - 596266 == -388126)
																			{
																				if (249092 - 309263 == -60171)
																				{
																					GUI.color = color2;
																					if (2297 - 406210 != -403912)
																					{
																						if (121617 - 469706 == -348089)
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
	}

	// Token: 0x060071A4 RID: 29092 RVA: 0x00F85478 File Offset: 0x00F83678
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (285095 - 219433 != 65663)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (66409 - 325907 != -259497)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (137038 - 53533 == 83505)
				{
					Debug.Log("On Mission Event:" + num);
					if (239153 - 144523 == 94630)
					{
						int num2 = num;
						if (201115 - 582245 == -381130)
						{
							if (num2 == 1061)
							{
								if (273491 - 417060 == -143569)
								{
									this.tAXc8fffWey++;
									if (201246 - 177036 != 24211)
									{
										this.SendMessage("newGameMessage", "Mission Objective: Boldas ko :" + this.tAXc8fffWey + "/3");
										if (115690 - 71997 != 43694)
										{
											break;
										}
									}
								}
							}
							else if (num2 == 1062)
							{
								if (45162 - 328372 != -283209)
								{
									this.R7xc8MCxs9I++;
									if (277253 - 310533 != -33279)
									{
										break;
									}
								}
							}
							else
							{
								if (num2 != 1063)
								{
									break;
								}
								if (27229 - 158263 == -131034)
								{
									this.SendMessage("newGameMessage", "Mission Failed: Boldas Dead!");
									if (51301 - 520754 != -469452)
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

	// Token: 0x060071A5 RID: 29093 RVA: 0x00F85694 File Offset: 0x00F83894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M106_BoldasRecruitment.$StartEvent$37473(this).GetEnumerator();
	}

	// Token: 0x060071A6 RID: 29094 RVA: 0x00F856A4 File Offset: 0x00F838A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (269111 - 6853 != 262259)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (101770 - 338363 != -236592)
			{
				hashtable.Add(71, CID);
				if (113903 - 577023 == -463120)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (96023 - 384450 == -288427)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (150813 - 196991 == -46178)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (183686 - 342791 == -159105)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (236341 - 383936 == -147595)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (291059 - 220022 != 71038)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (290531 - 581521 != -290989)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (34633 - 428534 == -393901)
											{
												this.Epac8a5Xr6Y.OpCustom(61, hashtable, true);
												if (218779 - 469490 == -250711)
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

	// Token: 0x060071A7 RID: 29095 RVA: 0x00F85930 File Offset: 0x00F83B30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (209916 - 16515 != 193402)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (181459 - 108990 != 72470)
			{
				if (!gameObject)
				{
					break;
				}
				if (243029 - 339077 != -96047)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (99371 - 337461 == -238090)
					{
						playerCameraControl.target = gameObject;
						if (56514 - 9829 != 46686)
						{
							Game.sendMissionEvent(1062, 0);
							if (101396 - 402443 != -301046)
							{
								this.StartGame();
								if (289176 - 345043 != -55866)
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

	// Token: 0x060071A8 RID: 29096 RVA: 0x00F85A44 File Offset: 0x00F83C44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (174159 - 155221 != 18938)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (96911 - 96067 != 845)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (268893 - 84096 == 184797)
				{
					gameGui.ResetTeamBar();
					if (69070 - 290007 == -220937)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060071A9 RID: 29097 RVA: 0x00F85AF0 File Offset: 0x00F83CF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDeadPlayer()
	{
		Debug.Log("On Dead Player");
		Game.mGameState = eGameState.Hold;
	}

	// Token: 0x060071AA RID: 29098 RVA: 0x00F85B04 File Offset: 0x00F83D04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (181006 - 279346 != -98340)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (203026 - 365805 != -162778)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (120340 - 123325 != -2984)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (187558 - 151001 != 36558)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060071AB RID: 29099 RVA: 0x00F85BC8 File Offset: 0x00F83DC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060071AC RID: 29100 RVA: 0x00F85BF4 File Offset: 0x00F83DF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (247947 - 217433 != 30514)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (87917 - 149504 != -61586)
			{
				hashtable.Add(43, PlayerData.UID);
				if (161011 - 553617 != -392605)
				{
					hashtable.Add(73, nType);
					if (155017 - 92458 == 62559)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (372 - 464038 != -463665)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (146342 - 577477 != -431134)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (151574 - 576242 == -424668)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (246242 - 556880 != -310637)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (210671 - 238034 == -27363)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (185548 - 9342 != 176207)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (269982 - 497941 != -227958)
												{
													this.Epac8a5Xr6Y.OpCustom(63, hashtable, true);
													if (215209 - 159481 != 55729)
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

	// Token: 0x060071AD RID: 29101 RVA: 0x00F85EAC File Offset: 0x00F840AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (233708 - 522395 != -288687)
		{
		}
		for (;;)
		{
			Debug.Log("onCreateActor");
			if (230011 - 267092 != -37080)
			{
				GameObject yfNc8CjB7nN = Game.createActor(data);
				if (109752 - 407288 == -297536)
				{
					if (!RuntimeServices.EqualityOperator(data[73], "Liger_mallet"))
					{
						if (247009 - 415887 == -168877)
						{
							continue;
						}
						if (!RuntimeServices.EqualityOperator(data[73], "Liger"))
						{
							goto IL_FC;
						}
						if (146209 - 340871 == -194661)
						{
							continue;
						}
					}
					this.YfNc8CjB7nN = yfNc8CjB7nN;
					if (36649 - 290687 != -254038)
					{
						continue;
					}
					Debug.Log("Boldas registered sucessfully");
					if (181562 - 421889 == -240326)
					{
						continue;
					}
					IL_FC:
					if (Game.mGameState != eGameState.Setup)
					{
						break;
					}
					if (39298 - 482470 == -443172)
					{
						if (this.glZc8LMWsG2 <= 0)
						{
							break;
						}
						if (180756 - 594625 != -413868)
						{
							this.glZc8LMWsG2--;
							if (156737 - 547705 == -390968)
							{
								if (this.glZc8LMWsG2 != 0)
								{
									break;
								}
								if (220103 - 453181 == -233078)
								{
									Game.setGameState(eGameState.Ready);
									if (157404 - 412230 == -254826)
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

	// Token: 0x060071AE RID: 29102 RVA: 0x00F86094 File Offset: 0x00F84294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (271093 - 311242 != -40149)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (109386 - 41633 == 67753)
			{
				if (!characterControl)
				{
					break;
				}
				if (118114 - 318732 == -200618)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (219167 - 329163 == -109996)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (32695 - 334646 == -301951)
						{
							if (!(characterControl.Type == "Liger_m"))
							{
								break;
							}
							if (62121 - 63159 == -1038)
							{
								Game.sendMissionEvent(1061, 0);
								if (62926 - 49187 == 13739)
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

	// Token: 0x060071AF RID: 29103 RVA: 0x00F861C0 File Offset: 0x00F843C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (86816 - 130980 != -44164)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (145220 - 361606 != -216385)
			{
				if (!characterControl)
				{
					break;
				}
				if (121995 - 178436 == -56441)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (131554 - 474774 == -343220)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (294154 - 358323 == -64169)
						{
							if (!(characterControl.Type == "Liger_m"))
							{
								break;
							}
							if (25704 - 585310 == -559606)
							{
								Game.sendMissionEvent(1063, 0);
								if (125855 - 11294 != 114562)
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

	// Token: 0x060071B0 RID: 29104 RVA: 0x00F862EC File Offset: 0x00F844EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (65980 - 332585 != -266605)
		{
		}
		for (;;)
		{
			IL_C2:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (235545 - 367073 != -131527)
			{
				int i = 0;
				if (128070 - 209664 != -81593)
				{
					CharacterControl[] array2 = array;
					if (187118 - 432223 != -245104)
					{
						int length = array2.Length;
						if (107537 - 377685 != -270147)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (289004 - 421727 == -132722)
								{
									goto IL_C2;
								}
								i++;
								if (120110 - 296518 == -176407)
								{
									goto IL_C2;
								}
							}
							if (108762 - 482819 == -374057)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060071B1 RID: 29105 RVA: 0x00F8641C File Offset: 0x00F8461C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (272461 - 547709 != -275248)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (31475 - 567294 == -535819)
			{
				Game.mGameState = eGameState.Ready;
				if (198953 - 253462 == -54509)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (125440 - 570205 == -444765)
					{
						GameObject gameObject = null;
						if (184361 - 379035 == -194674)
						{
							if (116291 - 257201 != -140909)
							{
								if (playerSlot > 1)
								{
									if (251558 - 200217 == 51342)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (290060 - 259568 != 30492)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (204446 - 293799 == -89352)
										{
											continue;
										}
										GameObject gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (100447 - 175093 != -74646)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (117717 - 316058 != -198341)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (261991 - 92597 == 169395)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (1015 - 207608 != -206592)
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (154850 - 250815 != -95964)
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

	// Token: 0x060071B2 RID: 29106 RVA: 0x00F86648 File Offset: 0x00F84848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (187299 - 338200 != -150901)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (137958 - 177122 != -39163)
			{
				Hashtable customOpParameters = new Hashtable();
				if (108632 - 537974 == -429342)
				{
					this.Epac8a5Xr6Y.OpCustom(52, customOpParameters, true);
					if (142009 - 442359 != -300349)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060071B3 RID: 29107 RVA: 0x00F866F0 File Offset: 0x00F848F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (135017 - 543253 != -408235)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (6042 - 486430 == -480388)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (50567 - 40620 != 9948)
				{
					Game.mGameState = eGameState.Setup;
					if (116025 - 293884 == -177859)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060071B4 RID: 29108 RVA: 0x00F86794 File Offset: 0x00F84994
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (109138 - 421993 != -312854)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (241856 - 366155 == -124299)
			{
				if (num == PlayerData.UID)
				{
					if (221802 - 226387 != -4584)
					{
						this.SetupActors();
						if (219867 - 99116 != 120752)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (106118 - 49620 == 56498)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060071B5 RID: 29109 RVA: 0x00F86864 File Offset: 0x00F84A64
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (94465 - 178072 != -83607)
		{
		}
		for (;;)
		{
			IL_1DB:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (45920 - 347062 == -301142)
			{
				if (Extensions.get_length(array) > 0)
				{
					if (170183 - 478521 != -308337)
					{
						int i = 0;
						if (11758 - 193048 == -181290)
						{
							CharacterControl[] array2 = array;
							if (154719 - 474914 == -320195)
							{
								int length = array2.Length;
								if (16888 - 418674 != -401785)
								{
									while (i < length)
									{
										string type = array2[i].Type;
										if (218120 - 598976 == -380855)
										{
											goto IL_1DB;
										}
										if (type == "Liger_m")
										{
											if (222656 - 31741 == 190916)
											{
												goto IL_1DB;
											}
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (148060 - 452796 == -304735)
											{
												goto IL_1DB;
											}
										}
										UnityEngine.Object.Destroy(array2[i].gameObject);
										if (18003 - 420804 != -402801)
										{
											goto IL_1DB;
										}
										this.glZc8LMWsG2++;
										if (169836 - 283345 != -113509)
										{
											goto IL_1DB;
										}
										i++;
										if (239878 - 127077 != 112801)
										{
											goto IL_1DB;
										}
									}
									if (148910 - 76278 != 72633)
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
					if (146666 - 331485 == -184819)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060071B6 RID: 29110 RVA: 0x00F86AB4 File Offset: 0x00F84CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (156458 - 126273 != 30185)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (83659 - 499656 != -415996)
			{
				Game.mGameState = eGameState.Start;
				if (87126 - 41232 == 45894)
				{
					Game.mGameTime = Time.time;
					if (177626 - 47647 == 129979)
					{
						Game.mStateTime = Time.time;
						if (110385 - 188687 == -78302)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (117636 - 402951 == -285315)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060071B7 RID: 29111 RVA: 0x00F86BA0 File Offset: 0x00F84DA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060071B8 RID: 29112 RVA: 0x00F86BA4 File Offset: 0x00F84DA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M106_BoldasRecruitment.$onGameComplete$37480(data, this).GetEnumerator();
	}

	// Token: 0x060071B9 RID: 29113 RVA: 0x00F86BB4 File Offset: 0x00F84DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M106_BoldasRecruitment.$ReturnToTown$37489(this).GetEnumerator();
	}

	// Token: 0x060071BA RID: 29114 RVA: 0x00F86BC4 File Offset: 0x00F84DC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M106_BoldasRecruitment.$ReturnToGuild$37494(this).GetEnumerator();
	}

	// Token: 0x060071BB RID: 29115 RVA: 0x00F86BD4 File Offset: 0x00F84DD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M106_BoldasRecruitment.$ReturnToCamp$37498(this).GetEnumerator();
	}

	// Token: 0x060071BC RID: 29116 RVA: 0x00F86BE4 File Offset: 0x00F84DE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (202055 - 405291 != -203235)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (66757 - 473173 == -406416)
			{
				Hashtable hashtable = new Hashtable();
				if (276912 - 260831 != 16082)
				{
					hashtable.Add(43, PlayerData.UID);
					if (7774 - 319268 == -311494)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (178404 - 331951 == -153547)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060071BD RID: 29117 RVA: 0x00F86CBC File Offset: 0x00F84EBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060071BE RID: 29118 RVA: 0x00F86CD0 File Offset: 0x00F84ED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (154497 - 208691 != -54194)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (289959 - 451849 != -161889)
			{
				Hashtable hashtable = new Hashtable();
				if (152405 - 3838 == 148567)
				{
					if (Game.mNextGameCode == 30)
					{
						if (138921 - 373357 != -234436)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (155843 - 404569 != -248726)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (40997 - 155513 == -114515)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (50858 - 544290 == -493431)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (212043 - 408174 == -196130)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (24652 - 105484 != -80832)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (214531 - 545996 != -331465)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (25701 - 100674 != -74973)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (11273 - 245033 == -233759)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (205967 - 189234 != 16733)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (199137 - 47099 == 152039)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (153571 - 207611 != -54040)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (67242 - 510770 != -443528)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (242668 - 593638 == -350969)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (252444 - 311324 == -58879)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (20392 - 369683 == -349290)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (59591 - 47283 != 12308)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (79065 - 375601 == -296535)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (172663 - 39735 != 132928)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (291783 - 519935 != -228152)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (26871 - 16546 == 10326)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (68174 - 217984 == -149809)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (85603 - 50672 == 34932)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (41185 - 22070 == 19116)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (299297 - 571927 != -272630)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (148895 - 422323 != -273428)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (97030 - 207923 == -110892)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (138030 - 157053 == -19022)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (176321 - 402725 == -226404)
					{
						this.Epac8a5Xr6Y.OpCustom(42, hashtable, true);
						if (125191 - 181781 == -56590)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060071BF RID: 29119 RVA: 0x00F87284 File Offset: 0x00F85484
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060071C0 RID: 29120 RVA: 0x00F87294 File Offset: 0x00F85494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060071C1 RID: 29121 RVA: 0x00F87298 File Offset: 0x00F85498
	internal static bool kw89sXpnkTESVdRpf3WL()
	{
		return true;
	}

	// Token: 0x060071C2 RID: 29122 RVA: 0x00F8729C File Offset: 0x00F8549C
	internal static bool CL5Eu4pnGUlb4xQSx6X8()
	{
		return false;
	}

	// Token: 0x040077B0 RID: 30640
	private LitePeer Epac8a5Xr6Y;

	// Token: 0x040077B1 RID: 30641
	private PlayerCameraControl nu1c84fI8NV;

	// Token: 0x040077B2 RID: 30642
	private float lmnc8sF3Rfu;

	// Token: 0x040077B3 RID: 30643
	private Texture UeAc8HUNuYk;

	// Token: 0x040077B4 RID: 30644
	private AudioClip VOIc87pBgNV;

	// Token: 0x040077B5 RID: 30645
	private int Nq0c8Z4owUk;

	// Token: 0x040077B6 RID: 30646
	private GameObject YfNc8CjB7nN;

	// Token: 0x040077B7 RID: 30647
	private int R7xc8MCxs9I;

	// Token: 0x040077B8 RID: 30648
	private int tAXc8fffWey;

	// Token: 0x040077B9 RID: 30649
	private int glZc8LMWsG2;

	// Token: 0x02001349 RID: 4937
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$37473 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060071C3 RID: 29123 RVA: 0x00F872A0 File Offset: 0x00F854A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$37473(M106_BoldasRecruitment self_)
		{
			if (189409 - 501796 != -312387)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (212608 - 70106 != 142503)
				{
					base..ctor();
					if (298902 - 83619 != 215284)
					{
						this.$self_$37479 = self_;
						if (42160 - 219138 != -176977)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x00F87338 File Offset: 0x00F85538
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M106_BoldasRecruitment.$StartEvent$37473.$(this.$self_$37479);
		}

		// Token: 0x060071C5 RID: 29125 RVA: 0x00F87348 File Offset: 0x00F85548
		internal static bool pqlHLBpnH0oIEKr5O9CN()
		{
			return true;
		}

		// Token: 0x060071C6 RID: 29126 RVA: 0x00F8734C File Offset: 0x00F8554C
		internal static bool jDlsj6pnWrc8aM7ofpP7()
		{
			return false;
		}

		// Token: 0x040077BA RID: 30650
		internal M106_BoldasRecruitment $self_$37479;

		// Token: 0x0200134A RID: 4938
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060071C7 RID: 29127 RVA: 0x00F87350 File Offset: 0x00F85550
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M106_BoldasRecruitment self_)
			{
				if (168217 - 443436 != -275219)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (88067 - 358312 == -270245)
					{
						base..ctor();
						if (242532 - 416314 == -173782)
						{
							this.$self_$37478 = self_;
							if (111480 - 76618 != 34863)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060071C8 RID: 29128 RVA: 0x00F873E8 File Offset: 0x00F855E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (215969 - 574710 != -358741)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_705;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (256682 - 359060 != -102378)
							{
								continue;
							}
							goto IL_3C0;
						}
						else
						{
							this.$mStoryGui$37475 = (StoryGui)this.$self_$37478.GetComponent(typeof(StoryGui));
							if (161643 - 65205 != 96438)
							{
								continue;
							}
							this.$mStoryGui$37475.startStoryMessage("Liger", "Boldas", eTalkType.friend);
							if (118912 - 339753 != -220840)
							{
								goto Block_33;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (131057 - 482211 != -351153)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$mLiger$37476 = GameObject.Find("Liger_mallet");
							if (259755 - 5959 != 253796)
							{
								continue;
							}
							if (this.$mLiger$37476)
							{
								if (128022 - 569882 == -441859)
								{
									continue;
								}
								this.$mLiger$37476.animation.Play("talk");
								if (185024 - 15377 != 169647)
								{
									continue;
								}
								this.$mLiger$37476.animation.wrapMode = WrapMode.Loop;
								if (71914 - 433595 != -361681)
								{
									continue;
								}
							}
							this.$mStoryGui$37475.newStoryMessage("Liger", "Boldas", Language.getMessage("M106_BoldasRecruitment", 1), eTalkType.friend);
							if (170077 - 217912 != -47835)
							{
								continue;
							}
							goto IL_24A;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (134312 - 553886 != -419574)
							{
								continue;
							}
							goto IL_6C4;
						}
						else
						{
							this.$mStoryGui$37475.newStoryMessage("Liger", "Boldas", Language.getMessage("M106_BoldasRecruitment", 2), eTalkType.friend);
							if (99384 - 484715 != -385330)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (32564 - 134941 != -102377)
							{
								continue;
							}
							goto IL_56B;
						}
						else
						{
							this.$mStoryGui$37475.newStoryMessage("Liger", "Boldas", Language.getMessage("M106_BoldasRecruitment", 3), eTalkType.friend);
							if (89217 - 58279 != 30938)
							{
								continue;
							}
							goto IL_689;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (178897 - 513688 != -334791)
							{
								continue;
							}
							goto IL_285;
						}
						else
						{
							this.$mStoryGui$37475.close();
							if (270880 - 134570 != 136311)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (278039 - 145374 != 132665)
							{
								continue;
							}
							goto IL_605;
						}
						else
						{
							this.$self_$37478.SendMessage("fadeOut");
							if (180838 - 233476 != -52637)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (288466 - 547431 != -258964)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$mGameGui$37477 = (GameGui)this.$self_$37478.GetComponent(typeof(GameGui));
							if (131501 - 456544 == -325042)
							{
								continue;
							}
							this.$mGameGui$37477.enabled = true;
							if (106474 - 368355 != -261881)
							{
								continue;
							}
							this.$self_$37478.nu1c84fI8NV.enabled = true;
							if (252761 - 190036 == 62726)
							{
								continue;
							}
							this.$self_$37478.nu1c84fI8NV.specialTarget = null;
							if (20982 - 158075 != -137093)
							{
								continue;
							}
							this.$self_$37478.SendMessage("fadeIn");
							if (4011 - 108392 != -104381)
							{
								continue;
							}
							goto IL_1EA;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (244497 - 415466 != -170969)
							{
								continue;
							}
							goto IL_4F6;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (77949 - 319752 == -241802)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (111668 - 147021 == -35352)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (125942 - 240159 != -114217)
							{
								continue;
							}
							if (this.$self_$37478.VOIc87pBgNV)
							{
								if (166430 - 76874 != 89556)
								{
									continue;
								}
								this.$self_$37478.audio.PlayOneShot(this.$self_$37478.VOIc87pBgNV);
								if (90582 - 548829 != -458247)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (136810 - 207891 != -71081)
							{
								continue;
							}
							goto IL_705;
						}
						break;
					default:
						if (279207 - 29812 == 249396)
						{
							continue;
						}
						break;
					}
					this.$mEventCamera1$37474 = GameObject.Find("EventCamera1");
					if (250684 - 130847 != 119838)
					{
						if (this.$mEventCamera1$37474)
						{
							if (157224 - 11661 != 145563)
							{
								continue;
							}
							this.$self_$37478.nu1c84fI8NV.setSpecialTarget(this.$mEventCamera1$37474, 2f);
							if (181081 - 182850 != -1769)
							{
								continue;
							}
						}
						this.$self_$37478.SendMessage("fadeIn");
						if (32717 - 408900 == -376183)
						{
							goto IL_79;
						}
					}
				}
				Block_3:
				goto IL_705;
				IL_79:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_8:
				goto IL_705;
				IL_1EA:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_24A:
				return this.Yield(4, new WaitForSeconds(2f));
				IL_285:
				goto IL_705;
				Block_20:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_3C0:
				goto IL_705;
				Block_33:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_4F6:
				IL_56B:
				IL_605:
				goto IL_705;
				Block_42:
				return this.Yield(8, new WaitForSeconds(1f));
				IL_689:
				return this.Yield(6, new WaitForSeconds(2.5f));
				IL_6C4:
				goto IL_705;
				Block_48:
				return this.Yield(5, new WaitForSeconds(2.5f));
				IL_705:
				return false;
			}

			// Token: 0x060071C9 RID: 29129 RVA: 0x00F87B0C File Offset: 0x00F85D0C
			internal static bool EE9SN5pnAMAwoMZHjGD2()
			{
				return true;
			}

			// Token: 0x060071CA RID: 29130 RVA: 0x00F87B10 File Offset: 0x00F85D10
			internal static bool lKPXjrpnlfHhIdyV9YxE()
			{
				return false;
			}

			// Token: 0x040077BB RID: 30651
			internal GameObject $mEventCamera1$37474;

			// Token: 0x040077BC RID: 30652
			internal StoryGui $mStoryGui$37475;

			// Token: 0x040077BD RID: 30653
			internal GameObject $mLiger$37476;

			// Token: 0x040077BE RID: 30654
			internal GameGui $mGameGui$37477;

			// Token: 0x040077BF RID: 30655
			internal M106_BoldasRecruitment $self_$37478;
		}
	}

	// Token: 0x0200134B RID: 4939
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37480 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060071CB RID: 29131 RVA: 0x00F87B14 File Offset: 0x00F85D14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37480(Hashtable data, M106_BoldasRecruitment self_)
		{
			if (148802 - 413797 != -264994)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (228782 - 259570 != -30787)
				{
					base..ctor();
					if (134204 - 234317 == -100113)
					{
						this.$data$37487 = data;
						if (194483 - 592836 != -398352)
						{
							this.$self_$37488 = self_;
							if (263238 - 545189 != -281950)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060071CC RID: 29132 RVA: 0x00F87BD0 File Offset: 0x00F85DD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M106_BoldasRecruitment.$onGameComplete$37480.$(this.$data$37487, this.$self_$37488);
		}

		// Token: 0x060071CD RID: 29133 RVA: 0x00F87BE4 File Offset: 0x00F85DE4
		internal static bool jhS9chpnyV3UtlBdlsx8()
		{
			return true;
		}

		// Token: 0x060071CE RID: 29134 RVA: 0x00F87BE8 File Offset: 0x00F85DE8
		internal static bool KxuCAEpnSBVAqlyBgPvU()
		{
			return false;
		}

		// Token: 0x040077C0 RID: 30656
		internal Hashtable $data$37487;

		// Token: 0x040077C1 RID: 30657
		internal M106_BoldasRecruitment $self_$37488;

		// Token: 0x0200134C RID: 4940
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060071CF RID: 29135 RVA: 0x00F87BEC File Offset: 0x00F85DEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M106_BoldasRecruitment self_)
			{
				if (236027 - 490624 != -254597)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (123372 - 544900 != -421527)
					{
						base..ctor();
						if (242296 - 374540 == -132244)
						{
							this.$data$37485 = data;
							if (188858 - 287587 == -98729)
							{
								this.$self_$37486 = self_;
								if (120698 - 302223 == -181525)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060071D0 RID: 29136 RVA: 0x00F87CA8 File Offset: 0x00F85EA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (237390 - 317774 != -80383)
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
						this.$mCompleteGui$37482 = (CompleteGui)this.$self_$37486.GetComponent(typeof(CompleteGui));
						if (152852 - 241123 == -88270)
						{
							continue;
						}
						this.$mCompleteGui$37482.Init();
						if (281120 - 49953 == 231168)
						{
							continue;
						}
						this.$mCompleteGui$37482.readData(this.$data$37485);
						if (158128 - 273165 == -115036)
						{
							continue;
						}
						if (this.$result$37481 == 1)
						{
							if (2368 - 585835 != -583467)
							{
								continue;
							}
							this.$mCompleteGui$37482.displayResult(eCompleteType.Success);
							if (202683 - 311983 != -109300)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37482.displayResult(eCompleteType.Failed);
							if (169396 - 365251 != -195855)
							{
								continue;
							}
						}
						this.$mGameGui$37483 = (GameGui)this.$self_$37486.GetComponent(typeof(GameGui));
						if (52561 - 500661 != -448100)
						{
							continue;
						}
						this.$mStoryGui$37484 = (StoryGui)this.$self_$37486.GetComponent(typeof(StoryGui));
						if (99067 - 403079 != -304012)
						{
							continue;
						}
						if (this.$mGameGui$37483)
						{
							if (82575 - 221411 != -138836)
							{
								continue;
							}
							this.$mGameGui$37483.close();
							if (182843 - 256205 == -73361)
							{
								continue;
							}
						}
						if (this.$mStoryGui$37484)
						{
							if (216101 - 44030 != 172071)
							{
								continue;
							}
							this.$mStoryGui$37484.close();
							if (194 - 583967 != -583773)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (48755 - 293840 != -245085)
						{
							continue;
						}
						goto IL_352;
					default:
						if (113778 - 142871 == -29092)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$37485[31]);
					if (72754 - 538467 != -465712)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (51508 - 435661 != -384152)
							{
								goto Block_22;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (228223 - 172792 == 55431)
							{
								this.$result$37481 = RuntimeServices.UnboxInt32(this.$data$37485[31]);
								if (124593 - 398305 == -273712)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_22:
				IL_352:
				return false;
			}

			// Token: 0x060071D1 RID: 29137 RVA: 0x00F8801C File Offset: 0x00F8621C
			internal static bool jiGwpfpnooIbI6NmOo2s()
			{
				return true;
			}

			// Token: 0x060071D2 RID: 29138 RVA: 0x00F88020 File Offset: 0x00F86220
			internal static bool DCMfropnEtgH5RdYYaWa()
			{
				return false;
			}

			// Token: 0x040077C2 RID: 30658
			internal int $result$37481;

			// Token: 0x040077C3 RID: 30659
			internal CompleteGui $mCompleteGui$37482;

			// Token: 0x040077C4 RID: 30660
			internal GameGui $mGameGui$37483;

			// Token: 0x040077C5 RID: 30661
			internal StoryGui $mStoryGui$37484;

			// Token: 0x040077C6 RID: 30662
			internal Hashtable $data$37485;

			// Token: 0x040077C7 RID: 30663
			internal M106_BoldasRecruitment $self_$37486;
		}
	}

	// Token: 0x0200134D RID: 4941
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37489 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060071D3 RID: 29139 RVA: 0x00F88024 File Offset: 0x00F86224
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37489(M106_BoldasRecruitment self_)
		{
			if (31771 - 405470 != -373698)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (220486 - 158751 == 61735)
				{
					base..ctor();
					if (146378 - 561126 == -414748)
					{
						this.$self_$37493 = self_;
						if (139200 - 181391 != -42190)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060071D4 RID: 29140 RVA: 0x00F880BC File Offset: 0x00F862BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M106_BoldasRecruitment.$ReturnToTown$37489.$(this.$self_$37493);
		}

		// Token: 0x060071D5 RID: 29141 RVA: 0x00F880CC File Offset: 0x00F862CC
		internal static bool JnNXP6pn26Vo2JYQ2LrE()
		{
			return true;
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x00F880D0 File Offset: 0x00F862D0
		internal static bool VieZEGpn8okCANOsr6h2()
		{
			return false;
		}

		// Token: 0x040077C8 RID: 30664
		internal M106_BoldasRecruitment $self_$37493;

		// Token: 0x0200134E RID: 4942
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060071D7 RID: 29143 RVA: 0x00F880D4 File Offset: 0x00F862D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M106_BoldasRecruitment self_)
			{
				if (34793 - 263192 != -228398)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (188089 - 137354 != 50736)
					{
						base..ctor();
						if (199933 - 29884 != 170050)
						{
							this.$self_$37492 = self_;
							if (147478 - 128766 == 18712)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060071D8 RID: 29144 RVA: 0x00F8816C File Offset: 0x00F8636C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (279572 - 193953 != 85619)
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
						this.$self_$37492.LeaveGame();
						if (31598 - 481467 == -449868)
						{
							continue;
						}
						this.YieldDefault(1);
						if (148825 - 496021 != -347195)
						{
							goto Block_8;
						}
						continue;
					default:
						if (241780 - 406873 == -165092)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (259821 - 370625 == -110804)
					{
						Game.mStateTime = Time.time;
						if (166851 - 537977 == -371126)
						{
							this.$$switch$6334$37490 = PlayerData.SaveGuild;
							if (146185 - 582724 != -436538)
							{
								if (this.$$switch$6334$37490 == 1)
								{
									if (187630 - 99569 == 88062)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (35472 - 216928 != -181456)
									{
										continue;
									}
								}
								else if (this.$$switch$6334$37490 == 2)
								{
									if (99635 - 230095 != -130460)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (162531 - 571617 == -409085)
									{
										continue;
									}
								}
								else if (this.$$switch$6334$37490 == 3)
								{
									if (127144 - 252926 != -125782)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (210379 - 92771 != 117608)
									{
										continue;
									}
								}
								else if (this.$$switch$6334$37490 == 4)
								{
									if (24578 - 353468 == -328889)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (74811 - 530697 == -455885)
									{
										continue;
									}
								}
								else if (this.$$switch$6334$37490 == 5)
								{
									if (38798 - 402221 != -363423)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (3015 - 599948 == -596932)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (58279 - 385761 != -327482)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (182209 - 264203 != -81994)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (186345 - 536411 == -350065)
									{
										continue;
									}
								}
								this.$mGameGui$37491 = (GameGui)this.$self_$37492.GetComponent(typeof(GameGui));
								if (295051 - 286800 != 8252)
								{
									if (this.$mGameGui$37491)
									{
										if (297678 - 141090 == 156589)
										{
											continue;
										}
										this.$mGameGui$37491.close();
										if (111544 - 318723 != -207179)
										{
											continue;
										}
									}
									this.$self_$37492.SendMessage("fadeOut");
									if (60775 - 55271 != 5505)
									{
										goto Block_18;
									}
								}
							}
						}
					}
				}
				Block_8:
				goto IL_3AD;
				Block_18:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x060071D9 RID: 29145 RVA: 0x00F88538 File Offset: 0x00F86738
			internal static bool NBK07RpnZA8x1kEGc7v3()
			{
				return true;
			}

			// Token: 0x060071DA RID: 29146 RVA: 0x00F8853C File Offset: 0x00F8673C
			internal static bool IJ6XcQpnCkUdWb9hyFZ9()
			{
				return false;
			}

			// Token: 0x040077C9 RID: 30665
			internal int $$switch$6334$37490;

			// Token: 0x040077CA RID: 30666
			internal GameGui $mGameGui$37491;

			// Token: 0x040077CB RID: 30667
			internal M106_BoldasRecruitment $self_$37492;
		}
	}

	// Token: 0x0200134F RID: 4943
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37494 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060071DB RID: 29147 RVA: 0x00F88540 File Offset: 0x00F86740
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37494(M106_BoldasRecruitment self_)
		{
			if (97372 - 302336 != -204963)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (102625 - 446526 != -343900)
				{
					base..ctor();
					if (85684 - 320145 == -234461)
					{
						this.$self_$37497 = self_;
						if (160037 - 110098 != 49940)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060071DC RID: 29148 RVA: 0x00F885D8 File Offset: 0x00F867D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M106_BoldasRecruitment.$ReturnToGuild$37494.$(this.$self_$37497);
		}

		// Token: 0x060071DD RID: 29149 RVA: 0x00F885E8 File Offset: 0x00F867E8
		internal static bool QGXYJgpnLhIGMIjEreDN()
		{
			return true;
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x00F885EC File Offset: 0x00F867EC
		internal static bool O3NI8ipnOettcsyBVWty()
		{
			return false;
		}

		// Token: 0x040077CC RID: 30668
		internal M106_BoldasRecruitment $self_$37497;

		// Token: 0x02001350 RID: 4944
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060071DF RID: 29151 RVA: 0x00F885F0 File Offset: 0x00F867F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M106_BoldasRecruitment self_)
			{
				if (30597 - 209678 != -179080)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (212251 - 183431 == 28820)
					{
						base..ctor();
						if (27617 - 212796 == -185179)
						{
							this.$self_$37496 = self_;
							if (202262 - 121673 != 80590)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060071E0 RID: 29152 RVA: 0x00F88688 File Offset: 0x00F86888
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (238334 - 69989 != 168346)
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
						this.$self_$37496.LeaveGame();
						if (274193 - 456648 != -182455)
						{
							continue;
						}
						this.YieldDefault(1);
						if (206434 - 328016 != -121581)
						{
							goto Block_4;
						}
						continue;
					default:
						if (226050 - 28725 == 197326)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (150834 - 252794 == -101960)
					{
						Game.mStateTime = Time.time;
						if (285105 - 453633 != -168527)
						{
							Game.mNextGameCode = 31;
							if (222819 - 74934 != 147886)
							{
								this.$mGameGui$37495 = (GameGui)this.$self_$37496.GetComponent(typeof(GameGui));
								if (107545 - 582801 == -475256)
								{
									if (this.$mGameGui$37495)
									{
										if (26383 - 229488 == -203104)
										{
											continue;
										}
										this.$mGameGui$37495.close();
										if (41164 - 97273 != -56109)
										{
											continue;
										}
									}
									this.$self_$37496.SendMessage("fadeOut");
									if (200757 - 323798 != -123040)
									{
										goto Block_6;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_1BD;
				Block_6:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x060071E1 RID: 29153 RVA: 0x00F88864 File Offset: 0x00F86A64
			internal static bool zPZCABpnmDYvSUCXjy0G()
			{
				return true;
			}

			// Token: 0x060071E2 RID: 29154 RVA: 0x00F88868 File Offset: 0x00F86A68
			internal static bool T9bnvppnFKWBVhaZhvQs()
			{
				return false;
			}

			// Token: 0x040077CD RID: 30669
			internal GameGui $mGameGui$37495;

			// Token: 0x040077CE RID: 30670
			internal M106_BoldasRecruitment $self_$37496;
		}
	}

	// Token: 0x02001351 RID: 4945
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37498 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060071E3 RID: 29155 RVA: 0x00F8886C File Offset: 0x00F86A6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37498(M106_BoldasRecruitment self_)
		{
			if (91069 - 361520 != -270451)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (203530 - 198932 != 4599)
				{
					base..ctor();
					if (5126 - 465100 != -459973)
					{
						this.$self_$37502 = self_;
						if (123792 - 346686 == -222894)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x00F88904 File Offset: 0x00F86B04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M106_BoldasRecruitment.$ReturnToCamp$37498.$(this.$self_$37502);
		}

		// Token: 0x060071E5 RID: 29157 RVA: 0x00F88914 File Offset: 0x00F86B14
		internal static bool GuYxhPpnM804DfLnRARZ()
		{
			return true;
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x00F88918 File Offset: 0x00F86B18
		internal static bool QrlVbypnxK7q0r2pIUB2()
		{
			return false;
		}

		// Token: 0x040077CF RID: 30671
		internal M106_BoldasRecruitment $self_$37502;

		// Token: 0x02001352 RID: 4946
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060071E7 RID: 29159 RVA: 0x00F8891C File Offset: 0x00F86B1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M106_BoldasRecruitment self_)
			{
				if (251930 - 102264 != 149666)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (215533 - 430486 == -214953)
					{
						base..ctor();
						if (257164 - 29881 == 227283)
						{
							this.$self_$37501 = self_;
							if (122412 - 92447 == 29965)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060071E8 RID: 29160 RVA: 0x00F889B4 File Offset: 0x00F86BB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (63446 - 467971 != -404525)
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
						this.$self_$37501.LeaveGame();
						if (121495 - 279263 == -157767)
						{
							continue;
						}
						this.YieldDefault(1);
						if (114459 - 258811 != -144352)
						{
							continue;
						}
						goto IL_363;
					default:
						if (85963 - 220652 == -134688)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (205699 - 114206 == 91493)
					{
						Game.mStateTime = Time.time;
						if (201900 - 148156 != 53745)
						{
							this.$$switch$6336$37499 = PlayerData.SaveGuild;
							if (98542 - 430556 == -332014)
							{
								if (this.$$switch$6336$37499 == 1)
								{
									if (201765 - 183766 == 18000)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (63544 - 585594 == -522049)
									{
										continue;
									}
								}
								else if (this.$$switch$6336$37499 == 2)
								{
									if (223330 - 162001 != 61329)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (46224 - 7932 == 38293)
									{
										continue;
									}
								}
								else if (this.$$switch$6336$37499 == 3)
								{
									if (108501 - 574511 != -466010)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (136095 - 366001 != -229906)
									{
										continue;
									}
								}
								else if (this.$$switch$6336$37499 == 4)
								{
									if (183101 - 590643 == -407541)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (148931 - 65196 == 83736)
									{
										continue;
									}
								}
								else if (this.$$switch$6336$37499 == 5)
								{
									if (9001 - 482691 != -473690)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (290671 - 332051 == -41379)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (181811 - 116101 != 65710)
									{
										continue;
									}
								}
								this.$mGameGui$37500 = (GameGui)this.$self_$37501.GetComponent(typeof(GameGui));
								if (145510 - 479594 == -334084)
								{
									if (this.$mGameGui$37500)
									{
										if (156343 - 376879 != -220536)
										{
											continue;
										}
										this.$mGameGui$37500.close();
										if (166248 - 164674 == 1575)
										{
											continue;
										}
									}
									this.$self_$37501.SendMessage("fadeOut");
									if (48664 - 173293 == -124629)
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

			// Token: 0x060071E9 RID: 29161 RVA: 0x00F88D38 File Offset: 0x00F86F38
			internal static bool nIcU6Gpng0XKbLNJk0CP()
			{
				return true;
			}

			// Token: 0x060071EA RID: 29162 RVA: 0x00F88D3C File Offset: 0x00F86F3C
			internal static bool mQ4Qv5pnfUVhh88PYXbg()
			{
				return false;
			}

			// Token: 0x040077D0 RID: 30672
			internal int $$switch$6336$37499;

			// Token: 0x040077D1 RID: 30673
			internal GameGui $mGameGui$37500;

			// Token: 0x040077D2 RID: 30674
			internal M106_BoldasRecruitment $self_$37501;
		}
	}
}
