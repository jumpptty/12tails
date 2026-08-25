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

// Token: 0x02001324 RID: 4900
[Serializable]
public class M104_StingBugNest : MonoBehaviour
{
	// Token: 0x060070C4 RID: 28868 RVA: 0x00F78150 File Offset: 0x00F76350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M104_StingBugNest()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060070C5 RID: 28869 RVA: 0x00F78160 File Offset: 0x00F76360
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (198212 - 207664 != -9452)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (5254 - 336478 == -331224)
			{
				Game.mGameType = 5;
				if (72944 - 536158 != -463213)
				{
					if (Chat.Initialized)
					{
						if (281479 - 128863 != 152616)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (491 - 228952 != -228461)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (131607 - 101342 != 30265)
						{
							continue;
						}
					}
					this.JyEc8v8bALS = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (22584 - 42767 != -20182)
					{
						this.SMDc8llLCUO = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (128724 - 193406 == -64682)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060070C6 RID: 28870 RVA: 0x00F782B8 File Offset: 0x00F764B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (118961 - 485657 != -366695)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (32194 - 229948 == -197754)
				{
					if (Game.mNextGameCode != 104)
					{
						break;
					}
					if (288580 - 99286 != 189295)
					{
						Game.nextGame();
						if (209601 - 183360 == 26241)
						{
							Game.mGameCode = 104;
							if (201855 - 596885 == -395030)
							{
								Game.mGameType = 5;
								if (77668 - 40616 != 37053)
								{
									Game.mGameTime = Time.time;
									if (291891 - 331907 == -40016)
									{
										Game.mGameScore = 0;
										if (243318 - 344948 != -101629)
										{
											Game.mGameMana = 0;
											if (103576 - 358908 == -255332)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (21127 - 223070 != -201942)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (83646 - 259062 == -175416)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (27152 - 202482 != -175329)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (296563 - 429997 != -133433)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (185737 - 544642 == -358905)
																{
																	this.o2Mc8O9sMj4 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (110303 - 130772 == -20469)
																	{
																		this.lZec8XptbRy = PhotonClient.Connection;
																		if (289608 - 394617 == -105009)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (217480 - 152246 == 65234)
																			{
																				this.InitGame();
																				if (286952 - 535936 != -248983)
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
				if (243573 - 504069 != -260495)
				{
					Game.mGameType = 99;
					if (125826 - 257917 != -132090)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060070C7 RID: 28871 RVA: 0x00F785B8 File Offset: 0x00F767B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (96921 - 370301 != -273379)
		{
		}
		for (;;)
		{
			if (this.lZec8XptbRy == null)
			{
				if (229148 - 122437 != 106712)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (198646 - 131476 != 67171)
				{
					if (mGameState == eGameState.Init)
					{
						if (97908 - 533693 == -435785)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (161463 - 435521 != -274057)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (261066 - 51449 == 209617)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (118374 - 330141 != -211766)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (49176 - 204049 != -154872)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (118011 - 588755 != -470743)
						{
							if (Time.time > this.y3pc82VZ29k)
							{
								if (84736 - 331601 != -246865)
								{
									continue;
								}
								Game.mGameMana++;
								if (55446 - 72953 != -17507)
								{
									continue;
								}
								this.y3pc82VZ29k = Time.time + (float)12;
								if (167815 - 82560 == 85256)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (40171 - 118786 == -78614)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (119290 - 288624 != -169334)
									{
										continue;
									}
									this.audio.Play();
									if (81162 - 286003 == -204840)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (214357 - 528701 != -314343)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (64801 - 508737 == -443936)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (240778 - 362290 == -121512)
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
						if (193658 - 521263 != -327604)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060070C8 RID: 28872 RVA: 0x00F788B8 File Offset: 0x00F76AB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (70137 - 437431 != -367293)
		{
		}
		for (;;)
		{
			if (!this.JyEc8v8bALS)
			{
				if (13993 - 596078 != -582084)
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
				if (206620 - 144329 != 62292)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (244711 - 541834 != -297122)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (118209 - 138694 != -20484)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (82131 - 511944 == -429813)
							{
								GUI.depth = 1;
								if (53823 - 463937 == -410114)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (3055 - 153211 != -150155)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (198813 - 278184 != -79370)
										{
											Color color = GUI.color;
											if (283265 - 233526 == 49739)
											{
												float num3 = color.a = a;
												if (224657 - 331302 == -106645)
												{
													if (163427 - 365959 == -202532)
													{
														GUI.color = color;
														if (153230 - 375217 == -221987)
														{
															if (213253 - 132752 != 80502)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.JyEc8v8bALS);
																if (37366 - 236732 != -199365)
																{
																	float a2 = 1f;
																	if (181485 - 344182 != -162696)
																	{
																		Color color2 = GUI.color;
																		if (4517 - 246551 == -242034)
																		{
																			color2.a = a2;
																			if (202544 - 283853 != -81308)
																			{
																				if (278671 - 576044 == -297373)
																				{
																					GUI.color = color2;
																					if (36054 - 352915 != -316860 && 280852 - 488693 != -207840)
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

	// Token: 0x060070C9 RID: 28873 RVA: 0x00F78C38 File Offset: 0x00F76E38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (267178 - 358142 != -90963)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (93452 - 216997 != -123544)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (185179 - 95303 == 89876)
				{
					int num2 = num;
					if (158015 - 149135 == 8880)
					{
						if (num2 != 1041)
						{
							break;
						}
						if (270770 - 508646 != -237875)
						{
							this.mVRc81g0Jmj++;
							if (242284 - 216461 == 25823)
							{
								this.SendMessage("newGameMessage", "Mission Objective: Nest Eliminate:" + this.mVRc81g0Jmj + "/7");
								if (102803 - 240135 == -137332)
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

	// Token: 0x060070CA RID: 28874 RVA: 0x00F78D7C File Offset: 0x00F76F7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (196506 - 354860 != -158354)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (232329 - 64242 == 168087)
			{
				CharacterControl characterControl = null;
				if (178413 - 202324 == -23911)
				{
					if (mPlayer)
					{
						if (107274 - 139665 == -32390)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (144495 - 274195 != -129700)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (72561 - 103394 == -30833)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (23354 - 281092 == -257738)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (63834 - 175171 == -111337)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (48554 - 508110 == -459555)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (47913 - 276716 == -228802)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (86703 - 277482 != -190779)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (207211 - 68255 != 138956)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (209159 - 330474 != -121314)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (111724 - 114872 != -3147)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (61147 - 523926 == -462779)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (70261 - 227291 == -157030)
								{
									if (!changeGui)
									{
										break;
									}
									if (253585 - 161962 == 91623)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (144422 - 314541 != -170119)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (264275 - 279407 == -15131)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (222828 - 154593 != 68236)
										{
											gameGui.close();
											if (86232 - 512196 == -425964)
											{
												changeGui.enabled = true;
												if (220265 - 218880 != 1386)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (140260 - 227387 == -87127)
													{
														if (!gameObject)
														{
															break;
														}
														if (153401 - 279701 != -126299)
														{
															if (!mPlayer)
															{
																break;
															}
															if (71902 - 314962 != -243059)
															{
																Debug.Log("UseLifeAltar");
																if (296680 - 65034 != 231647)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (248884 - 298657 == -49773)
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

	// Token: 0x060070CB RID: 28875 RVA: 0x00F791DC File Offset: 0x00F773DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (44538 - 529357 != -484818)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (57001 - 61692 == -4691)
			{
				hashtable.Add(71, CID);
				if (192186 - 421058 != -228871)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (130761 - 119587 != 11175)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (89846 - 321234 == -231388)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (289690 - 525338 == -235648)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (68813 - 196165 != -127351)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (163185 - 273820 == -110635)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (167721 - 16799 == 150922)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (73616 - 175396 == -101780)
											{
												this.lZec8XptbRy.OpCustom(61, hashtable, true);
												if (66222 - 320629 != -254406)
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

	// Token: 0x060070CC RID: 28876 RVA: 0x00F79468 File Offset: 0x00F77668
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (275936 - 197040 != 78897)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (128557 - 144667 == -16110)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (285416 - 4409 == 281007)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (39748 - 382355 == -342607)
					{
						Hashtable hashtable = new Hashtable();
						if (205749 - 505183 == -299434)
						{
							hashtable.Add(43, PlayerData.UID);
							if (71050 - 17755 != 53296)
							{
								hashtable.Add(71, nCID);
								if (177127 - 382921 == -205794)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (160181 - 108233 != 51949)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (132985 - 289582 == -156597)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (228611 - 248696 != -20084)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (45378 - 157570 != -112191)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (217433 - 206206 == 11227)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (42075 - 458934 == -416859)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (62698 - 106839 != -44140)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (90545 - 299243 == -208698)
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

	// Token: 0x060070CD RID: 28877 RVA: 0x00F79788 File Offset: 0x00F77988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (50021 - 348454 != -298433)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (36878 - 187255 != -150376)
			{
				if (!gameObject)
				{
					break;
				}
				if (296625 - 80468 == 216157)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (130327 - 234720 != -104392)
					{
						playerCameraControl.target = gameObject;
						if (194304 - 298753 == -104449)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (265430 - 122801 != 142630)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060070CE RID: 28878 RVA: 0x00F79880 File Offset: 0x00F77A80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (121260 - 563612 != -442351)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (155423 - 106180 == 49243)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (203549 - 108438 != 95112)
				{
					gameGui.ResetTeamBar();
					if (10488 - 100106 != -89617)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060070CF RID: 28879 RVA: 0x00F7992C File Offset: 0x00F77B2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M104_StingBugNest.$onChangePlayer$37360(data, this).GetEnumerator();
	}

	// Token: 0x060070D0 RID: 28880 RVA: 0x00F7993C File Offset: 0x00F77B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M104_StingBugNest.$onDeadPlayer$37367(this).GetEnumerator();
	}

	// Token: 0x060070D1 RID: 28881 RVA: 0x00F7994C File Offset: 0x00F77B4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (260991 - 311107 != -50115)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (1750 - 253805 != -252054)
			{
				this.o2Mc8O9sMj4.target = Game.mPlayer;
				if (169823 - 231170 != -61346)
				{
					this.o2Mc8O9sMj4.enabled = true;
					if (73952 - 586064 != -512111)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (126952 - 325045 != -198093)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (260607 - 62655 == 197953)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (240326 - 18377 == 221949)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (11503 - 239037 == -227534)
							{
								if (!gameGui)
								{
									break;
								}
								if (202705 - 83302 == 119403)
								{
									gameGui.enabled = true;
									if (84172 - 93213 == -9041)
									{
										gameGui.closeDeadMenu();
										if (230833 - 71721 != 159113)
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

	// Token: 0x060070D2 RID: 28882 RVA: 0x00F79AF8 File Offset: 0x00F77CF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (210427 - 265455 != -55028)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (65117 - 1892 == 63225)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (246347 - 253945 != -7597)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (185908 - 578941 != -393032)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060070D3 RID: 28883 RVA: 0x00F79BBC File Offset: 0x00F77DBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060070D4 RID: 28884 RVA: 0x00F79BE8 File Offset: 0x00F77DE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (54575 - 422064 != -367488)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (199766 - 49903 != 149864)
			{
				hashtable.Add(43, PlayerData.UID);
				if (206593 - 392769 != -186175)
				{
					hashtable.Add(73, nType);
					if (273173 - 35677 == 237496)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (186692 - 394660 != -207967)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (66792 - 511690 != -444897)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (171680 - 193454 != -21773)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (121499 - 574287 != -452787)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (154519 - 349032 == -194513)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (164754 - 498070 != -333315)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (129330 - 211202 != -81871)
												{
													this.lZec8XptbRy.OpCustom(63, hashtable, true);
													if (173934 - 72404 == 101530)
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

	// Token: 0x060070D5 RID: 28885 RVA: 0x00F79EA0 File Offset: 0x00F780A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (174044 - 91350 != 82695)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (78639 - 570465 != -491825)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (211275 - 109322 != 101954)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (54940 - 498014 == -443074)
						{
							if (this.LNac8q1SGKf <= 0)
							{
								break;
							}
							if (149040 - 224297 == -75257)
							{
								this.LNac8q1SGKf--;
								if (24646 - 60534 != -35887)
								{
									if (this.LNac8q1SGKf != 0)
									{
										break;
									}
									if (114008 - 121881 == -7873)
									{
										Game.setGameState(eGameState.Ready);
										if (212725 - 360281 == -147556)
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
						if (207341 - 113294 == 94047)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (219458 - 297797 != -78338)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060070D6 RID: 28886 RVA: 0x00F7A030 File Offset: 0x00F78230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x060070D7 RID: 28887 RVA: 0x00F7A034 File Offset: 0x00F78234
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (167386 - 23417 != 143970)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (154049 - 442668 == -288619)
			{
				if (!characterControl)
				{
					break;
				}
				if (127379 - 174041 != -46661)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (37779 - 522099 != -484319)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (90214 - 310314 == -220100)
						{
							string type = characterControl.Type;
							if (17947 - 374243 != -356295)
							{
								if (type == "StingNest")
								{
									if (269347 - 256235 != 13113)
									{
										Game.sendMissionEvent(1041, 0);
										if (205867 - 574887 == -369020)
										{
											break;
										}
									}
								}
								else
								{
									if (type == "StingBug_g")
									{
										if (257431 - 54111 == 203321)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "StingBug_r"))
										{
											break;
										}
										if (43029 - 358207 != -315178)
										{
											continue;
										}
									}
									Game.sendMissionEvent(1042, 0);
									if (255919 - 153935 != 101985)
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

	// Token: 0x060070D8 RID: 28888 RVA: 0x00F7A204 File Offset: 0x00F78404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (58273 - 369325 != -311052)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (291676 - 60492 != 231185)
			{
				Hashtable customOpParameters = new Hashtable();
				if (272770 - 143410 != 129361)
				{
					this.lZec8XptbRy.OpCustom(52, customOpParameters, true);
					if (9796 - 594673 != -584876)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060070D9 RID: 28889 RVA: 0x00F7A2AC File Offset: 0x00F784AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (287873 - 568057 != -280184)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (229253 - 3558 != 225696)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (97737 - 358019 != -260281)
				{
					Game.mGameState = eGameState.Setup;
					if (17354 - 235763 == -218409)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060070DA RID: 28890 RVA: 0x00F7A350 File Offset: 0x00F78550
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (50018 - 219831 != -169812)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (277000 - 418231 != -141230)
			{
				Game.mGameState = eGameState.Ready;
				if (232853 - 503899 == -271046)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (43597 - 296020 == -252423)
					{
						if (288262 - 263280 != 24983)
						{
							GameObject gameObject = null;
							if (9018 - 107480 != -98461)
							{
								GameObject gameObject2;
								if (playerSlot > 1)
								{
									if (135064 - 536812 != -401748)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (64602 - 186345 == -121742)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (249769 - 540384 != -290615)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (276503 - 98372 != 178131)
										{
											continue;
										}
										goto IL_1ED;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (68062 - 172301 == -104238)
								{
									continue;
								}
								IL_1ED:
								if (gameObject2)
								{
									if (58095 - 395319 != -337224)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (2214 - 395610 != -393396)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (234178 - 512805 != -278626)
								{
									this.transform.position = gameObject.transform.position;
									if (46103 - 171009 != -124905)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (237817 - 203484 == 34333)
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

	// Token: 0x060070DB RID: 28891 RVA: 0x00F7A5E0 File Offset: 0x00F787E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (166778 - 2449 != 164330)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (232461 - 452291 != -219829)
			{
				if (num == PlayerData.UID)
				{
					if (173979 - 444177 == -270198)
					{
						this.SetupActors();
						if (49388 - 29932 == 19456)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (244429 - 516216 == -271787)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060070DC RID: 28892 RVA: 0x00F7A6B0 File Offset: 0x00F788B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (154649 - 424188 != -269539)
		{
		}
		for (;;)
		{
			IL_238:
			Debug.Log("Creating Actors");
			if (15155 - 118717 != -103561)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (206058 - 501303 != -295244)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (67533 - 93267 == -25734)
						{
							int i = 0;
							if (242453 - 563721 == -321268)
							{
								CharacterControl[] array2 = array;
								if (290650 - 39366 == 251284)
								{
									int length = array2.Length;
									if (150698 - 195734 == -45036)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (109927 - 56552 == 53376)
											{
												goto IL_238;
											}
											if (type == "StingNest")
											{
												goto IL_90;
											}
											if (119861 - 175444 == -55582)
											{
												goto IL_238;
											}
											if (type == "StingBug_g")
											{
												goto IL_90;
											}
											if (201564 - 323556 == -121991)
											{
												goto IL_238;
											}
											if (type == "StingBug_r")
											{
												if (2222 - 394851 != -392628)
												{
													goto IL_90;
												}
												goto IL_238;
											}
											IL_1A6:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (286429 - 585096 == -298666)
											{
												goto IL_238;
											}
											this.LNac8q1SGKf++;
											if (29078 - 416280 == -387201)
											{
												goto IL_238;
											}
											i++;
											if (202725 - 127902 != 74824)
											{
												continue;
											}
											goto IL_238;
											IL_90:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (134984 - 222352 != -87367)
											{
												goto IL_1A6;
											}
											goto IL_238;
										}
										if (38976 - 294424 != -255447)
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
						if (270119 - 496652 == -226533)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060070DD RID: 28893 RVA: 0x00F7A978 File Offset: 0x00F78B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (93395 - 458354 != -364959)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (167554 - 199479 != -31924)
			{
				int i = 0;
				if (17774 - 205189 != -187414)
				{
					CharacterControl[] array2 = array;
					if (169096 - 472565 == -303469)
					{
						int length = array2.Length;
						if (131087 - 377818 == -246731)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (98733 - 509939 == -411205)
								{
									goto IL_E0;
								}
								i++;
								if (248932 - 314877 != -65945)
								{
									goto IL_E0;
								}
							}
							if (153823 - 127420 == 26403)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060070DE RID: 28894 RVA: 0x00F7AAA8 File Offset: 0x00F78CA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M104_StingBugNest.$StartGame$37373(this).GetEnumerator();
	}

	// Token: 0x060070DF RID: 28895 RVA: 0x00F7AAB8 File Offset: 0x00F78CB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060070E0 RID: 28896 RVA: 0x00F7AABC File Offset: 0x00F78CBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M104_StingBugNest.$onGameComplete$37377(data, this).GetEnumerator();
	}

	// Token: 0x060070E1 RID: 28897 RVA: 0x00F7AACC File Offset: 0x00F78CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M104_StingBugNest.$ReturnToTown$37385(this).GetEnumerator();
	}

	// Token: 0x060070E2 RID: 28898 RVA: 0x00F7AADC File Offset: 0x00F78CDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M104_StingBugNest.$ReturnToGuild$37390(this).GetEnumerator();
	}

	// Token: 0x060070E3 RID: 28899 RVA: 0x00F7AAEC File Offset: 0x00F78CEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M104_StingBugNest.$ReturnToCamp$37394(this).GetEnumerator();
	}

	// Token: 0x060070E4 RID: 28900 RVA: 0x00F7AAFC File Offset: 0x00F78CFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (34769 - 8163 != 26607)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (227541 - 310125 == -82584)
			{
				Hashtable hashtable = new Hashtable();
				if (68026 - 381147 != -313120)
				{
					hashtable.Add(43, PlayerData.UID);
					if (193464 - 588844 == -395380)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (216715 - 400916 == -184201)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060070E5 RID: 28901 RVA: 0x00F7ABD4 File Offset: 0x00F78DD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060070E6 RID: 28902 RVA: 0x00F7ABE8 File Offset: 0x00F78DE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (129321 - 471662 != -342341)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (6479 - 446684 == -440205)
			{
				Hashtable hashtable = new Hashtable();
				if (131904 - 184224 == -52320)
				{
					if (Game.mNextGameCode == 30)
					{
						if (118770 - 229865 == -111094)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (228828 - 245256 != -16428)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (174787 - 274381 != -99594)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (8372 - 386846 == -378473)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (100453 - 274517 == -174063)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (143298 - 549351 != -406053)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (10880 - 117931 != -107051)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (218093 - 575533 != -357440)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (206812 - 493598 == -286785)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (93032 - 97982 == -4949)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (150990 - 505412 == -354421)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (2396 - 151972 != -149576)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (265517 - 442893 != -177376)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (69785 - 154080 == -84294)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (191663 - 599771 == -408107)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (211250 - 286840 == -75589)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (111041 - 471054 != -360013)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (10965 - 219917 != -208952)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (256089 - 21405 == 234685)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (20112 - 578221 != -558109)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (24269 - 172636 != -148367)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (46533 - 367386 == -320852)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (6769 - 319480 != -312711)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (177646 - 387048 == -209401)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (100860 - 287685 == -186824)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (272921 - 122275 != 150646)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (259742 - 37555 != 222187)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (239536 - 143994 == 95543)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (159394 - 298010 != -138615)
					{
						this.lZec8XptbRy.OpCustom(42, hashtable, true);
						if (147797 - 497823 == -350026)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060070E7 RID: 28903 RVA: 0x00F7B19C File Offset: 0x00F7939C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060070E8 RID: 28904 RVA: 0x00F7B1AC File Offset: 0x00F793AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060070E9 RID: 28905 RVA: 0x00F7B1B0 File Offset: 0x00F793B0
	internal static bool KLRPRUpfVJpdUCjcGnpc()
	{
		return true;
	}

	// Token: 0x060070EA RID: 28906 RVA: 0x00F7B1B4 File Offset: 0x00F793B4
	internal static bool WrHEqgpft2nQ62sUBuJG()
	{
		return false;
	}

	// Token: 0x0400773E RID: 30526
	private LitePeer lZec8XptbRy;

	// Token: 0x0400773F RID: 30527
	private PlayerCameraControl o2Mc8O9sMj4;

	// Token: 0x04007740 RID: 30528
	private float y3pc82VZ29k;

	// Token: 0x04007741 RID: 30529
	private Texture JyEc8v8bALS;

	// Token: 0x04007742 RID: 30530
	private AudioClip SMDc8llLCUO;

	// Token: 0x04007743 RID: 30531
	private int MLYc8G91wAs;

	// Token: 0x04007744 RID: 30532
	private int mVRc81g0Jmj;

	// Token: 0x04007745 RID: 30533
	private int LNac8q1SGKf;

	// Token: 0x02001325 RID: 4901
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$37360 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060070EB RID: 28907 RVA: 0x00F7B1B8 File Offset: 0x00F793B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$37360(Hashtable data, M104_StingBugNest self_)
		{
			if (202618 - 451887 != -249269)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (105840 - 455761 == -349921)
				{
					base..ctor();
					if (134449 - 382361 != -247911)
					{
						this.$data$37365 = data;
						if (88082 - 560797 == -472715)
						{
							this.$self_$37366 = self_;
							if (299783 - 589999 != -290215)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060070EC RID: 28908 RVA: 0x00F7B274 File Offset: 0x00F79474
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M104_StingBugNest.$onChangePlayer$37360.$(this.$data$37365, this.$self_$37366);
		}

		// Token: 0x060070ED RID: 28909 RVA: 0x00F7B288 File Offset: 0x00F79488
		internal static bool O5vSGhpfNXBOxqAlcGff()
		{
			return true;
		}

		// Token: 0x060070EE RID: 28910 RVA: 0x00F7B28C File Offset: 0x00F7948C
		internal static bool Xb0MpipfYvRVcDruMt44()
		{
			return false;
		}

		// Token: 0x04007746 RID: 30534
		internal Hashtable $data$37365;

		// Token: 0x04007747 RID: 30535
		internal M104_StingBugNest $self_$37366;

		// Token: 0x02001326 RID: 4902
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060070EF RID: 28911 RVA: 0x00F7B290 File Offset: 0x00F79490
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M104_StingBugNest self_)
			{
				if (249361 - 594679 != -345318)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (230324 - 224914 == 5410)
					{
						base..ctor();
						if (200577 - 131184 != 69394)
						{
							this.$data$37363 = data;
							if (108140 - 416231 == -308091)
							{
								this.$self_$37364 = self_;
								if (88482 - 100259 != -11776)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060070F0 RID: 28912 RVA: 0x00F7B34C File Offset: 0x00F7954C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (251876 - 191133 != 60743)
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
							if (2011 - 39095 == -37083)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (99352 - 558812 != -459460)
							{
								continue;
							}
							this.$mGameGui$37362 = (GameGui)this.$self_$37364.GetComponent(typeof(GameGui));
							if (232920 - 405860 != -172940)
							{
								continue;
							}
							this.$mGameGui$37362.enabled = true;
							if (51424 - 596581 == -545156)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (265380 - 464960 != -199579)
						{
							goto Block_13;
						}
						continue;
					default:
						if (287197 - 213512 != 73685)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (232263 - 403039 != -170775)
					{
						this.$self_$37364.SendMessage("onCreatePlayer", this.$data$37363);
						if (111439 - 34697 != 76743)
						{
							this.$mChangeGui$37361 = (ChangeGui)this.$self_$37364.GetComponent(typeof(ChangeGui));
							if (155180 - 60105 != 95076)
							{
								if (!this.$mChangeGui$37361.enabled)
								{
									break;
								}
								if (42382 - 593929 != -551546)
								{
									this.$mChangeGui$37361.close();
									if (194782 - 502547 == -307765)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_13:
				IL_205:
				return false;
			}

			// Token: 0x060070F1 RID: 28913 RVA: 0x00F7B570 File Offset: 0x00F79770
			internal static bool rUaFFrpfcIXwN40AAJ5H()
			{
				return true;
			}

			// Token: 0x060070F2 RID: 28914 RVA: 0x00F7B574 File Offset: 0x00F79774
			internal static bool H2IETVpfUIXe7pPKgkxS()
			{
				return false;
			}

			// Token: 0x04007748 RID: 30536
			internal ChangeGui $mChangeGui$37361;

			// Token: 0x04007749 RID: 30537
			internal GameGui $mGameGui$37362;

			// Token: 0x0400774A RID: 30538
			internal Hashtable $data$37363;

			// Token: 0x0400774B RID: 30539
			internal M104_StingBugNest $self_$37364;
		}
	}

	// Token: 0x02001327 RID: 4903
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37367 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060070F3 RID: 28915 RVA: 0x00F7B578 File Offset: 0x00F79778
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37367(M104_StingBugNest self_)
		{
			if (16062 - 216054 != -199992)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (101479 - 591614 != -490134)
				{
					base..ctor();
					if (110799 - 482221 == -371422)
					{
						this.$self_$37372 = self_;
						if (152591 - 433286 != -280694)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x00F7B610 File Offset: 0x00F79810
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M104_StingBugNest.$onDeadPlayer$37367.$(this.$self_$37372);
		}

		// Token: 0x060070F5 RID: 28917 RVA: 0x00F7B620 File Offset: 0x00F79820
		internal static bool aKMhslpfTq2lQJGQWZW0()
		{
			return true;
		}

		// Token: 0x060070F6 RID: 28918 RVA: 0x00F7B624 File Offset: 0x00F79824
		internal static bool XZ73g5pf34i8mDuMVAms()
		{
			return false;
		}

		// Token: 0x0400774C RID: 30540
		internal M104_StingBugNest $self_$37372;

		// Token: 0x02001328 RID: 4904
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060070F7 RID: 28919 RVA: 0x00F7B628 File Offset: 0x00F79828
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M104_StingBugNest self_)
			{
				if (158595 - 265156 != -106561)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (93585 - 235793 == -142208)
					{
						base..ctor();
						if (102019 - 465645 != -363625)
						{
							this.$self_$37371 = self_;
							if (135271 - 188477 != -53205)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060070F8 RID: 28920 RVA: 0x00F7B6C0 File Offset: 0x00F798C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (144975 - 560949 != -415974)
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
							goto IL_254;
						}
						if (208154 - 115813 != 92341)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (160165 - 133816 != 26349)
							{
								continue;
							}
							goto IL_254;
						}
						IL_188:
						this.YieldDefault(1);
						if (226773 - 547729 != -320955)
						{
							goto Block_14;
						}
						continue;
						IL_254:
						Game.mGameState = eGameState.Hold;
						if (246290 - 146929 == 99362)
						{
							continue;
						}
						this.$mStoryGui$37368 = (StoryGui)this.$self_$37371.GetComponent(typeof(StoryGui));
						if (232119 - 155103 != 77016)
						{
							continue;
						}
						if (this.$mStoryGui$37368)
						{
							if (131032 - 119419 != 11613)
							{
								continue;
							}
							this.$mStoryGui$37368.close();
							if (254668 - 122649 == 132020)
							{
								continue;
							}
						}
						this.$mChangeGui$37369 = (ChangeGui)this.$self_$37371.GetComponent(typeof(ChangeGui));
						if (11720 - 213961 != -202241)
						{
							continue;
						}
						if (this.$mChangeGui$37369)
						{
							if (38570 - 97123 != -58553)
							{
								continue;
							}
							this.$mChangeGui$37369.close();
							if (182204 - 575145 == -392940)
							{
								continue;
							}
						}
						this.$mGameGui$37370 = (GameGui)this.$self_$37371.GetComponent(typeof(GameGui));
						if (265179 - 376268 == -111088)
						{
							continue;
						}
						if (!this.$mGameGui$37370)
						{
							goto IL_188;
						}
						if (183860 - 126420 == 57441)
						{
							continue;
						}
						if (!this.$mGameGui$37370.enabled)
						{
							if (217758 - 5908 != 211850)
							{
								continue;
							}
							this.$mGameGui$37370.enabled = true;
							if (59896 - 9469 != 50427)
							{
								continue;
							}
						}
						this.$mGameGui$37370.openDeadMenu();
						if (172811 - 161279 != 11533)
						{
							goto IL_188;
						}
						continue;
					default:
						if (26081 - 520640 != -494559)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (147948 - 235449 != -87501);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_14:
				IL_2F9:
				return false;
			}

			// Token: 0x060070F9 RID: 28921 RVA: 0x00F7B9D8 File Offset: 0x00F79BD8
			internal static bool aC4YglpfXYjKu8HCLhjU()
			{
				return true;
			}

			// Token: 0x060070FA RID: 28922 RVA: 0x00F7B9DC File Offset: 0x00F79BDC
			internal static bool v86qogpfQdJjFVRjnOEL()
			{
				return false;
			}

			// Token: 0x0400774D RID: 30541
			internal StoryGui $mStoryGui$37368;

			// Token: 0x0400774E RID: 30542
			internal ChangeGui $mChangeGui$37369;

			// Token: 0x0400774F RID: 30543
			internal GameGui $mGameGui$37370;

			// Token: 0x04007750 RID: 30544
			internal M104_StingBugNest $self_$37371;
		}
	}

	// Token: 0x02001329 RID: 4905
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$37373 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060070FB RID: 28923 RVA: 0x00F7B9E0 File Offset: 0x00F79BE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$37373(M104_StingBugNest self_)
		{
			if (115103 - 276690 != -161586)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (2422 - 387188 != -384765)
				{
					base..ctor();
					if (194221 - 109305 == 84916)
					{
						this.$self_$37376 = self_;
						if (14907 - 174957 != -160049)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060070FC RID: 28924 RVA: 0x00F7BA78 File Offset: 0x00F79C78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M104_StingBugNest.$StartGame$37373.$(this.$self_$37376);
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x00F7BA88 File Offset: 0x00F79C88
		internal static bool inDrCYpfk3VKdUL93ZDe()
		{
			return true;
		}

		// Token: 0x060070FE RID: 28926 RVA: 0x00F7BA8C File Offset: 0x00F79C8C
		internal static bool QS5QYWpfGqtigU7HR1Iy()
		{
			return false;
		}

		// Token: 0x04007751 RID: 30545
		internal M104_StingBugNest $self_$37376;

		// Token: 0x0200132A RID: 4906
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060070FF RID: 28927 RVA: 0x00F7BA90 File Offset: 0x00F79C90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M104_StingBugNest self_)
			{
				if (130976 - 597926 != -466949)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (8952 - 172349 == -163397)
					{
						base..ctor();
						if (9549 - 41591 != -32041)
						{
							this.$self_$37375 = self_;
							if (24379 - 105380 != -81000)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007100 RID: 28928 RVA: 0x00F7BB28 File Offset: 0x00F79D28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (90327 - 435631 != -345304)
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
						this.$mGameGui$37374 = (GameGui)this.$self_$37375.GetComponent(typeof(GameGui));
						if (298620 - 43246 == 255375)
						{
							continue;
						}
						this.$mGameGui$37374.enabled = true;
						if (241909 - 387297 != -145388)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (80314 - 588443 == -508128)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (60635 - 146267 != -85632)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (163228 - 170748 == -7519)
						{
							continue;
						}
						if (this.$self_$37375.SMDc8llLCUO)
						{
							if (101688 - 342257 == -240568)
							{
								continue;
							}
							this.$self_$37375.audio.PlayOneShot(this.$self_$37375.SMDc8llLCUO);
							if (170227 - 580483 == -410255)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (25446 - 337879 != -312432)
						{
							goto Block_4;
						}
						continue;
					default:
						if (294480 - 49215 != 245265)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (150265 - 100770 != 49496)
					{
						Game.mGameState = eGameState.Start;
						if (61930 - 290222 == -228292)
						{
							Game.mStateTime = Time.time;
							if (89416 - 449144 == -359728)
							{
								this.$self_$37375.SendMessage("fadeIn");
								if (234106 - 530633 != -296526)
								{
									goto Block_13;
								}
							}
						}
					}
				}
				Block_4:
				goto IL_241;
				Block_13:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_241:
				return false;
			}

			// Token: 0x06007101 RID: 28929 RVA: 0x00F7BD88 File Offset: 0x00F79F88
			internal static bool fapyI7pfHMsjB2VBARsp()
			{
				return true;
			}

			// Token: 0x06007102 RID: 28930 RVA: 0x00F7BD8C File Offset: 0x00F79F8C
			internal static bool aO9Y3qpfWtaspq3elBCV()
			{
				return false;
			}

			// Token: 0x04007752 RID: 30546
			internal GameGui $mGameGui$37374;

			// Token: 0x04007753 RID: 30547
			internal M104_StingBugNest $self_$37375;
		}
	}

	// Token: 0x0200132B RID: 4907
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37377 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007103 RID: 28931 RVA: 0x00F7BD90 File Offset: 0x00F79F90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37377(Hashtable data, M104_StingBugNest self_)
		{
			if (182919 - 69569 != 113350)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (156622 - 383964 == -227342)
				{
					base..ctor();
					if (64465 - 310312 == -245847)
					{
						this.$data$37383 = data;
						if (183621 - 448104 == -264483)
						{
							this.$self_$37384 = self_;
							if (201804 - 425107 != -223302)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x00F7BE4C File Offset: 0x00F7A04C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M104_StingBugNest.$onGameComplete$37377.$(this.$data$37383, this.$self_$37384);
		}

		// Token: 0x06007105 RID: 28933 RVA: 0x00F7BE60 File Offset: 0x00F7A060
		internal static bool V4w3JCpfAe1lSpbTAypv()
		{
			return true;
		}

		// Token: 0x06007106 RID: 28934 RVA: 0x00F7BE64 File Offset: 0x00F7A064
		internal static bool QxmQeHpflZdTrEVL09kt()
		{
			return false;
		}

		// Token: 0x04007754 RID: 30548
		internal Hashtable $data$37383;

		// Token: 0x04007755 RID: 30549
		internal M104_StingBugNest $self_$37384;

		// Token: 0x0200132C RID: 4908
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007107 RID: 28935 RVA: 0x00F7BE68 File Offset: 0x00F7A068
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M104_StingBugNest self_)
			{
				if (116013 - 341708 != -225695)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (101268 - 472086 == -370818)
					{
						base..ctor();
						if (235967 - 482122 != -246154)
						{
							this.$data$37381 = data;
							if (244733 - 468490 != -223756)
							{
								this.$self_$37382 = self_;
								if (281926 - 353263 == -71337)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007108 RID: 28936 RVA: 0x00F7BF24 File Offset: 0x00F7A124
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (203508 - 157676 != 45833)
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
						this.$mCompleteGui$37379 = (CompleteGui)this.$self_$37382.GetComponent(typeof(CompleteGui));
						if (92797 - 296595 == -203797)
						{
							continue;
						}
						this.$mCompleteGui$37379.Init();
						if (17322 - 146014 == -128691)
						{
							continue;
						}
						this.$mCompleteGui$37379.readData(this.$data$37381);
						if (270031 - 397444 == -127412)
						{
							continue;
						}
						if (this.$result$37378 == 1)
						{
							if (194367 - 99045 != 95322)
							{
								continue;
							}
							this.$mCompleteGui$37379.displayResult(eCompleteType.Success);
							if (199212 - 555476 == -356263)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37379.displayResult(eCompleteType.Failed);
							if (282525 - 406990 != -124465)
							{
								continue;
							}
						}
						this.$mGameGui$37380 = (GameGui)this.$self_$37382.GetComponent(typeof(GameGui));
						if (267513 - 379055 == -111541)
						{
							continue;
						}
						if (this.$mGameGui$37380)
						{
							if (75327 - 367328 == -292000)
							{
								continue;
							}
							this.$mGameGui$37380.close();
							if (194374 - 509789 != -315415)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (298346 - 423178 != -124832)
						{
							continue;
						}
						goto IL_28E;
					default:
						if (7930 - 532852 == -524921)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (85340 - 253656 == -168316)
						{
							goto IL_6A;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (225713 - 72801 != 152913)
						{
							this.$result$37378 = RuntimeServices.UnboxInt32(this.$data$37381[31]);
							if (104650 - 166242 == -61592)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_6A:
				IL_28E:
				return false;
			}

			// Token: 0x06007109 RID: 28937 RVA: 0x00F7C1D4 File Offset: 0x00F7A3D4
			internal static bool gOhFhCpfy1M7NGNyfQDP()
			{
				return true;
			}

			// Token: 0x0600710A RID: 28938 RVA: 0x00F7C1D8 File Offset: 0x00F7A3D8
			internal static bool VokEEWpfSQFe0aHfFsaU()
			{
				return false;
			}

			// Token: 0x04007756 RID: 30550
			internal int $result$37378;

			// Token: 0x04007757 RID: 30551
			internal CompleteGui $mCompleteGui$37379;

			// Token: 0x04007758 RID: 30552
			internal GameGui $mGameGui$37380;

			// Token: 0x04007759 RID: 30553
			internal Hashtable $data$37381;

			// Token: 0x0400775A RID: 30554
			internal M104_StingBugNest $self_$37382;
		}
	}

	// Token: 0x0200132D RID: 4909
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37385 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600710B RID: 28939 RVA: 0x00F7C1DC File Offset: 0x00F7A3DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37385(M104_StingBugNest self_)
		{
			if (17224 - 186873 != -169649)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (214973 - 111525 == 103448)
				{
					base..ctor();
					if (219556 - 307521 == -87965)
					{
						this.$self_$37389 = self_;
						if (76464 - 106649 != -30184)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600710C RID: 28940 RVA: 0x00F7C274 File Offset: 0x00F7A474
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M104_StingBugNest.$ReturnToTown$37385.$(this.$self_$37389);
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x00F7C284 File Offset: 0x00F7A484
		internal static bool CPxP8IpfoSQjSppNZrDO()
		{
			return true;
		}

		// Token: 0x0600710E RID: 28942 RVA: 0x00F7C288 File Offset: 0x00F7A488
		internal static bool cTgHOFpfEWuk17QE9lUs()
		{
			return false;
		}

		// Token: 0x0400775B RID: 30555
		internal M104_StingBugNest $self_$37389;

		// Token: 0x0200132E RID: 4910
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600710F RID: 28943 RVA: 0x00F7C28C File Offset: 0x00F7A48C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M104_StingBugNest self_)
			{
				if (169744 - 315224 != -145479)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (259924 - 317014 != -57089)
					{
						base..ctor();
						if (287495 - 155558 == 131937)
						{
							this.$self_$37388 = self_;
							if (16007 - 211021 == -195014)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007110 RID: 28944 RVA: 0x00F7C324 File Offset: 0x00F7A524
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211269 - 473404 != -262135)
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
						this.$self_$37388.LeaveGame();
						if (20088 - 56239 == -36150)
						{
							continue;
						}
						this.YieldDefault(1);
						if (31167 - 96235 != -65067)
						{
							goto Block_22;
						}
						continue;
					default:
						if (226282 - 116179 != 110103)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (151910 - 301134 != -149223)
					{
						Game.mStateTime = Time.time;
						if (18621 - 312646 != -294024)
						{
							this.$$switch$6301$37386 = PlayerData.SaveGuild;
							if (210949 - 386432 == -175483)
							{
								if (this.$$switch$6301$37386 == 1)
								{
									if (58469 - 339739 == -281269)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (249941 - 457285 == -207343)
									{
										continue;
									}
								}
								else if (this.$$switch$6301$37386 == 2)
								{
									if (121730 - 580362 != -458632)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (191068 - 453899 != -262831)
									{
										continue;
									}
								}
								else if (this.$$switch$6301$37386 == 3)
								{
									if (60563 - 481529 != -420966)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (260530 - 374314 == -113783)
									{
										continue;
									}
								}
								else if (this.$$switch$6301$37386 == 4)
								{
									if (35324 - 183006 != -147682)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (147557 - 167558 == -20000)
									{
										continue;
									}
								}
								else if (this.$$switch$6301$37386 == 5)
								{
									if (19557 - 147425 != -127868)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (1821 - 343959 != -342138)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (203622 - 454801 != -251179)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (273337 - 178037 == 95301)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (239091 - 509999 != -270908)
									{
										continue;
									}
								}
								this.$mGameGui$37387 = (GameGui)this.$self_$37388.GetComponent(typeof(GameGui));
								if (169734 - 261429 != -91694)
								{
									if (this.$mGameGui$37387)
									{
										if (224300 - 353330 == -129029)
										{
											continue;
										}
										this.$mGameGui$37387.close();
										if (171221 - 51339 != 119882)
										{
											continue;
										}
									}
									this.$self_$37388.SendMessage("fadeOut");
									if (4982 - 172285 == -167303)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_22:
				IL_3AD:
				return false;
			}

			// Token: 0x06007111 RID: 28945 RVA: 0x00F7C6F0 File Offset: 0x00F7A8F0
			internal static bool mB0gXlpf2lq5FgwmKSiq()
			{
				return true;
			}

			// Token: 0x06007112 RID: 28946 RVA: 0x00F7C6F4 File Offset: 0x00F7A8F4
			internal static bool f2ShHYpf8s6YSHP4oq95()
			{
				return false;
			}

			// Token: 0x0400775C RID: 30556
			internal int $$switch$6301$37386;

			// Token: 0x0400775D RID: 30557
			internal GameGui $mGameGui$37387;

			// Token: 0x0400775E RID: 30558
			internal M104_StingBugNest $self_$37388;
		}
	}

	// Token: 0x0200132F RID: 4911
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37390 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007113 RID: 28947 RVA: 0x00F7C6F8 File Offset: 0x00F7A8F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37390(M104_StingBugNest self_)
		{
			if (103950 - 428791 != -324841)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (101653 - 404048 != -302394)
				{
					base..ctor();
					if (38685 - 308693 == -270008)
					{
						this.$self_$37393 = self_;
						if (109601 - 236446 != -126844)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007114 RID: 28948 RVA: 0x00F7C790 File Offset: 0x00F7A990
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M104_StingBugNest.$ReturnToGuild$37390.$(this.$self_$37393);
		}

		// Token: 0x06007115 RID: 28949 RVA: 0x00F7C7A0 File Offset: 0x00F7A9A0
		internal static bool fnk6wFpfZYmlSbtssmiA()
		{
			return true;
		}

		// Token: 0x06007116 RID: 28950 RVA: 0x00F7C7A4 File Offset: 0x00F7A9A4
		internal static bool NjhyxxpfCAegKR4eaIto()
		{
			return false;
		}

		// Token: 0x0400775F RID: 30559
		internal M104_StingBugNest $self_$37393;

		// Token: 0x02001330 RID: 4912
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007117 RID: 28951 RVA: 0x00F7C7A8 File Offset: 0x00F7A9A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M104_StingBugNest self_)
			{
				if (61429 - 247510 != -186080)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (211690 - 515575 == -303885)
					{
						base..ctor();
						if (145459 - 557426 != -411966)
						{
							this.$self_$37392 = self_;
							if (13432 - 277830 == -264398)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007118 RID: 28952 RVA: 0x00F7C840 File Offset: 0x00F7AA40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (52760 - 466486 != -413726)
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
						this.$self_$37392.LeaveGame();
						if (53755 - 460575 != -406820)
						{
							continue;
						}
						this.YieldDefault(1);
						if (187119 - 174972 != 12148)
						{
							goto Block_4;
						}
						continue;
					default:
						if (50778 - 99147 == -48368)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (86255 - 468485 == -382230)
					{
						Game.mStateTime = Time.time;
						if (219537 - 88578 == 130959)
						{
							Game.mNextGameCode = 31;
							if (250128 - 511746 == -261618)
							{
								this.$mGameGui$37391 = (GameGui)this.$self_$37392.GetComponent(typeof(GameGui));
								if (210237 - 554497 == -344260)
								{
									if (this.$mGameGui$37391)
									{
										if (24519 - 372990 != -348471)
										{
											continue;
										}
										this.$mGameGui$37391.close();
										if (151580 - 579009 != -427429)
										{
											continue;
										}
									}
									this.$self_$37392.SendMessage("fadeOut");
									if (7167 - 182436 != -175268)
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

			// Token: 0x06007119 RID: 28953 RVA: 0x00F7CA1C File Offset: 0x00F7AC1C
			internal static bool frhGQOpfLaqRYRnkQeys()
			{
				return true;
			}

			// Token: 0x0600711A RID: 28954 RVA: 0x00F7CA20 File Offset: 0x00F7AC20
			internal static bool yo4GZTpfO8kmPf2O5qa0()
			{
				return false;
			}

			// Token: 0x04007760 RID: 30560
			internal GameGui $mGameGui$37391;

			// Token: 0x04007761 RID: 30561
			internal M104_StingBugNest $self_$37392;
		}
	}

	// Token: 0x02001331 RID: 4913
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37394 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600711B RID: 28955 RVA: 0x00F7CA24 File Offset: 0x00F7AC24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37394(M104_StingBugNest self_)
		{
			if (277876 - 187768 != 90109)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (7466 - 42944 == -35478)
				{
					base..ctor();
					if (73101 - 450968 == -377867)
					{
						this.$self_$37398 = self_;
						if (154931 - 414873 != -259941)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600711C RID: 28956 RVA: 0x00F7CABC File Offset: 0x00F7ACBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M104_StingBugNest.$ReturnToCamp$37394.$(this.$self_$37398);
		}

		// Token: 0x0600711D RID: 28957 RVA: 0x00F7CACC File Offset: 0x00F7ACCC
		internal static bool d5XitBpfmvTqOetqxLmw()
		{
			return true;
		}

		// Token: 0x0600711E RID: 28958 RVA: 0x00F7CAD0 File Offset: 0x00F7ACD0
		internal static bool K33DDqpfFDbdLVUXhfsV()
		{
			return false;
		}

		// Token: 0x04007762 RID: 30562
		internal M104_StingBugNest $self_$37398;

		// Token: 0x02001332 RID: 4914
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600711F RID: 28959 RVA: 0x00F7CAD4 File Offset: 0x00F7ACD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M104_StingBugNest self_)
			{
				if (283405 - 531559 != -248153)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (127883 - 102979 != 24905)
					{
						base..ctor();
						if (187267 - 578849 == -391582)
						{
							this.$self_$37397 = self_;
							if (1271 - 573448 != -572176)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007120 RID: 28960 RVA: 0x00F7CB6C File Offset: 0x00F7AD6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (129665 - 124731 != 4935)
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
						this.$self_$37397.LeaveGame();
						if (160403 - 320195 != -159792)
						{
							continue;
						}
						this.YieldDefault(1);
						if (135950 - 581736 != -445785)
						{
							goto Block_23;
						}
						continue;
					default:
						if (59488 - 271640 == -212151)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (150530 - 397501 == -246971)
					{
						Game.mStateTime = Time.time;
						if (243803 - 487109 == -243306)
						{
							this.$$switch$6303$37395 = PlayerData.SaveGuild;
							if (72160 - 415007 == -342847)
							{
								if (this.$$switch$6303$37395 == 1)
								{
									if (82008 - 542874 != -460866)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (134070 - 526048 != -391978)
									{
										continue;
									}
								}
								else if (this.$$switch$6303$37395 == 2)
								{
									if (296438 - 483737 == -187298)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (213925 - 537935 != -324010)
									{
										continue;
									}
								}
								else if (this.$$switch$6303$37395 == 3)
								{
									if (298380 - 107781 == 190600)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (161495 - 312372 != -150877)
									{
										continue;
									}
								}
								else if (this.$$switch$6303$37395 == 4)
								{
									if (182196 - 245949 == -63752)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (183167 - 479852 != -296685)
									{
										continue;
									}
								}
								else if (this.$$switch$6303$37395 == 5)
								{
									if (191477 - 192486 == -1008)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (81206 - 450095 == -368888)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (230483 - 522967 != -292484)
									{
										continue;
									}
								}
								this.$mGameGui$37396 = (GameGui)this.$self_$37397.GetComponent(typeof(GameGui));
								if (248972 - 297968 != -48995)
								{
									if (this.$mGameGui$37396)
									{
										if (188593 - 495706 != -307113)
										{
											continue;
										}
										this.$mGameGui$37396.close();
										if (60528 - 537466 != -476938)
										{
											continue;
										}
									}
									this.$self_$37397.SendMessage("fadeOut");
									if (168538 - 320066 != -151527)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_23:
				IL_363:
				return false;
			}

			// Token: 0x06007121 RID: 28961 RVA: 0x00F7CEF0 File Offset: 0x00F7B0F0
			internal static bool nYrX1XpfMU2i0192hlZC()
			{
				return true;
			}

			// Token: 0x06007122 RID: 28962 RVA: 0x00F7CEF4 File Offset: 0x00F7B0F4
			internal static bool cGint2pfxbglXMhenS7n()
			{
				return false;
			}

			// Token: 0x04007763 RID: 30563
			internal int $$switch$6303$37395;

			// Token: 0x04007764 RID: 30564
			internal GameGui $mGameGui$37396;

			// Token: 0x04007765 RID: 30565
			internal M104_StingBugNest $self_$37397;
		}
	}
}
