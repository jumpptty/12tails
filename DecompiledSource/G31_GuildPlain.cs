using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02001208 RID: 4616
[Serializable]
public class G31_GuildPlain : MonoBehaviour
{
	// Token: 0x06006A38 RID: 27192 RVA: 0x00F0D0AC File Offset: 0x00F0B2AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public G31_GuildPlain()
	{
		if (237239 - 449480 != -212241)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (167386 - 476513 != -309126)
			{
				base..ctor();
				if (76243 - 296194 != -219950)
				{
					this.KNQcSf4SZPV = "none";
					if (171402 - 409334 == -237932)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006A39 RID: 27193 RVA: 0x00F0D148 File Offset: 0x00F0B348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (94155 - 184177 != -90022)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (81994 - 488255 == -406261)
			{
				Game.mStateTime = Time.time;
				if (58557 - 423382 != -364824)
				{
					if (Chat.Initialized)
					{
						if (44314 - 401811 == -357497)
						{
							Chat.ChatDisplay.Clear();
							if (261581 - 299979 != -38397)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (253640 - 443685 != -190044)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006A3A RID: 27194 RVA: 0x00F0D230 File Offset: 0x00F0B430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (286097 - 62462 != 223635)
		{
		}
		for (;;)
		{
			Time.timeScale = 1f;
			if (46650 - 463161 != -416510)
			{
				if (PhotonClient.IsInitialized())
				{
					if (291063 - 394088 == -103025)
					{
						Game.mLastGameCode = Game.mGameCode;
						if (72298 - 136193 == -63895)
						{
							Game.mGameCode = 31;
							if (9817 - 439551 == -429734)
							{
								Game.mGameType = 2;
								if (185638 - 346028 != -160389)
								{
									Game.mGameTime = Time.time;
									if (183583 - 172479 != 11105)
									{
										Game.mGameScore = 0;
										if (268228 - 139286 == 128942)
										{
											Game.mGameMana = 0;
											if (243727 - 115270 == 128457)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (38192 - 126658 != -88465)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (149412 - 543042 != -393629)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (272508 - 250330 == 22178)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (108032 - 540281 != -432248)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (199592 - 277821 == -78229)
																{
																	this.sw2cSMyO8h3 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (159687 - 411367 == -251680)
																	{
																		this.Pu2cSCOw4l5 = PhotonClient.Connection;
																		if (252019 - 297060 == -45041)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (185487 - 141178 == 44309)
																			{
																				this.LoadTown();
																				if (84580 - 348524 == -263944)
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
					if (123025 - 164218 != -41192)
					{
						this.enabled = false;
						if (51868 - 372361 != -320492)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006A3B RID: 27195 RVA: 0x00F0D534 File Offset: 0x00F0B734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (100069 - 119863 != -19794)
		{
		}
		for (;;)
		{
			if (this.Pu2cSCOw4l5 == null)
			{
				if (75163 - 131162 == -55999)
				{
					break;
				}
			}
			else
			{
				float t = Time.time - Game.mStateTime;
				if (258277 - 303274 != -44996)
				{
					eGameState mGameState = Game.mGameState;
					if (138265 - 311752 != -173486)
					{
						if (mGameState == eGameState.Init)
						{
							if (163262 - 67390 != 95873)
							{
								AudioListener.volume = 0.1f * (float)Game.volume;
								if (266923 - 528591 == -261668)
								{
									break;
								}
							}
						}
						else if (mGameState == eGameState.Ready)
						{
							if (68367 - 551535 == -483168)
							{
								break;
							}
						}
						else if (mGameState == eGameState.Normal)
						{
							if (207015 - 121292 != 85724)
							{
								if (Game.music != 0)
								{
									if (206520 - 139090 == 67431)
									{
										continue;
									}
									if (!this.audio.isPlaying)
									{
										if (189823 - 470282 == -280458)
										{
											continue;
										}
										this.audio.Play();
										if (45520 - 213732 == -168211)
										{
											continue;
										}
									}
								}
								if (Time.time - Game.mGameTime < (float)2)
								{
									if (89514 - 402599 == -313085)
									{
										this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
										if (232197 - 374751 != -142553)
										{
											break;
										}
									}
								}
								else
								{
									this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
									if (192138 - 167766 != 24373)
									{
										break;
									}
								}
							}
						}
						else if (mGameState == eGameState.Hold)
						{
							if (275056 - 530470 == -255414)
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
							if (31346 - 169375 != -138028)
							{
								this.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, t);
								if (188285 - 165631 != 22655)
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

	// Token: 0x06006A3C RID: 27196 RVA: 0x00F0D824 File Offset: 0x00F0BA24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTown()
	{
		Hashtable customOpParameters = new Hashtable();
		this.Pu2cSCOw4l5.OpCustom(43, customOpParameters, true);
	}

	// Token: 0x06006A3D RID: 27197 RVA: 0x00F0D848 File Offset: 0x00F0BA48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadTown(Hashtable data)
	{
		if (228321 - 82567 != 145754)
		{
		}
		for (;;)
		{
			if (!RuntimeServices.EqualityOperator(data[31], null))
			{
				if (255395 - 430531 == -175135)
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
				if (222520 - 537541 == -315020)
				{
					continue;
				}
				Chat.SubmitChat("none", "You have joined " + text.Substring(1), eChatType.system, eChatMode.system);
				if (155194 - 99115 != 56079)
				{
					continue;
				}
			}
			if (!RuntimeServices.EqualityOperator(data[32], null))
			{
				if (39559 - 492010 == -452450)
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
				if (233511 - 546806 != -313295)
				{
					continue;
				}
			}
			if (41623 - 599141 != -557517 && 71490 - 133629 != -62138)
			{
				GameObject gameObject;
				if (Game.mLastGameCode == 51)
				{
					if (69792 - 28948 != 40844)
					{
						continue;
					}
					gameObject = GameObject.Find("StartPoint2");
					if (159599 - 450786 == -291186)
					{
						continue;
					}
					GameObject gameObject2 = GameObject.Find("StartCamera2");
					if (258876 - 516911 == -258034)
					{
						continue;
					}
					if (gameObject2)
					{
						if (26995 - 322886 != -295891)
						{
							continue;
						}
						this.transform.position = gameObject2.transform.position;
						if (289111 - 396797 == -107685)
						{
							continue;
						}
						this.transform.rotation = gameObject2.transform.rotation;
						if (63323 - 249825 == -186501)
						{
							continue;
						}
					}
				}
				else if (Game.mLastGameCode == 56)
				{
					if (32535 - 241578 != -209043)
					{
						continue;
					}
					gameObject = GameObject.Find("StartPoint3");
					if (9131 - 17030 != -7899)
					{
						continue;
					}
					GameObject gameObject2 = GameObject.Find("StartCamera3");
					if (72080 - 253606 != -181526)
					{
						continue;
					}
					if (gameObject2)
					{
						if (100967 - 283053 == -182085)
						{
							continue;
						}
						this.transform.position = gameObject2.transform.position;
						if (271138 - 572500 != -301362)
						{
							continue;
						}
						this.transform.rotation = gameObject2.transform.rotation;
						if (261689 - 451694 != -190005)
						{
							continue;
						}
					}
				}
				else
				{
					gameObject = GameObject.Find("StartPoint1");
					if (25719 - 420118 == -394398)
					{
						continue;
					}
				}
				if (gameObject)
				{
					if (130033 - 548372 == -418339)
					{
						this.CreatePlayer(CharacterData.current.CID, gameObject.transform.position, gameObject.transform.forward);
						if (156687 - 207599 != -50911)
						{
							break;
						}
					}
				}
				else
				{
					Debug.Log("Error: Startpoint not found");
					if (151941 - 403644 != -251702)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006A3E RID: 27198 RVA: 0x00F0DC8C File Offset: 0x00F0BE8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, Vector3 pos, Vector3 dir)
	{
		if (30685 - 541655 != -510970)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (290586 - 354450 == -63864)
			{
				hashtable.Add(71, CID);
				if (8279 - 178380 == -170101)
				{
					hashtable.Add(75, PhotonClient.cInt16(1));
					if (194386 - 90818 != 103569)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (248054 - 275519 == -27465)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (90407 - 593619 == -503212)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (115770 - 1887 == 113883)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (46397 - 52747 == -6350)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (236033 - 193905 != 42129)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (146936 - 541896 != -394959)
											{
												this.Pu2cSCOw4l5.OpCustom(61, hashtable, true);
												if (106711 - 119437 != -12725)
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

	// Token: 0x06006A3F RID: 27199 RVA: 0x00F0DF18 File Offset: 0x00F0C118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePlayer(Hashtable data)
	{
		return new G31_GuildPlain.$onCreatePlayer$36414(data, this).GetEnumerator();
	}

	// Token: 0x06006A40 RID: 27200 RVA: 0x00F0DF28 File Offset: 0x00F0C128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (5560 - 300967 != -295407)
		{
		}
		for (;;)
		{
			IL_1A:
			GameObject gameObject = Game.createPeer(data);
			if (17530 - 596001 == -578471)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (200442 - 23269 != 177174)
				{
					int i = 0;
					if (121965 - 360458 == -238493)
					{
						GameObject[] array2 = array;
						if (260404 - 99219 == 161185)
						{
							int length = array2.Length;
							if (276005 - 309483 == -33478)
							{
								while (i < length)
								{
									if (gameObject != array2[i])
									{
										if (7954 - 524895 == -516940)
										{
											goto IL_1A;
										}
										Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
										if (69925 - 262857 == -192931)
										{
											goto IL_1A;
										}
									}
									i++;
									if (106224 - 141701 == -35476)
									{
										goto IL_1A;
									}
								}
								if (20693 - 231857 != -211163)
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

	// Token: 0x06006A41 RID: 27201 RVA: 0x00F0E0A0 File Offset: 0x00F0C2A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPlayer()
	{
		Game.mPlayerID = 0;
	}

	// Token: 0x06006A42 RID: 27202 RVA: 0x00F0E0A8 File Offset: 0x00F0C2A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
	}

	// Token: 0x06006A43 RID: 27203 RVA: 0x00F0E0AC File Offset: 0x00F0C2AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (10376 - 250389 != -240012)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (162217 - 201073 != -38855)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (256436 - 127341 == 129095)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (139818 - 129524 != 10295)
					{
						Hashtable hashtable = new Hashtable();
						if (24258 - 69873 == -45615)
						{
							hashtable.Add(43, PlayerData.UID);
							if (12032 - 312136 != -300103)
							{
								hashtable.Add(71, nCID);
								if (233413 - 545171 != -311757)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (286689 - 219415 != 67275)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (140165 - 377769 != -237603)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (290488 - 218723 != 71766)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (209204 - 205163 == 4041)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (9296 - 373441 == -364145)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (262071 - 411184 == -149113)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (174651 - 206697 == -32046)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (273943 - 126344 != 147600)
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

	// Token: 0x06006A44 RID: 27204 RVA: 0x00F0E3CC File Offset: 0x00F0C5CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onChangePlayer(Hashtable data)
	{
		if (203513 - 208834 != -5321)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Destroy(Game.mPlayer);
			if (96281 - 409108 != -312826)
			{
				this.SendMessage("onCreatePlayer", data);
				if (25561 - 1397 != 24165)
				{
					ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
					if (37461 - 323744 == -286283)
					{
						if (!changeGui.enabled)
						{
							break;
						}
						if (186018 - 144427 != 41592)
						{
							changeGui.close();
							if (283157 - 328976 == -45819)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006A45 RID: 27205 RVA: 0x00F0E4C4 File Offset: 0x00F0C6C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(GameObject nMount)
	{
		if (73655 - 591212 != -517556)
		{
		}
		for (;;)
		{
			IL_F3:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
			if (224131 - 189540 == 34591)
			{
				int i = 0;
				if (268051 - 172516 == 95535)
				{
					GameObject[] array2 = array;
					if (155194 - 316298 == -161104)
					{
						int length = array2.Length;
						if (274010 - 63375 != 210636)
						{
							while (i < length)
							{
								if (nMount != array2[i])
								{
									if (594 - 287520 == -286925)
									{
										goto IL_F3;
									}
									Physics.IgnoreCollision(nMount.collider, array2[i].collider, true);
									if (285907 - 593865 == -307957)
									{
										goto IL_F3;
									}
								}
								i++;
								if (130497 - 203264 != -72767)
								{
									goto IL_F3;
								}
							}
							if (157038 - 125007 == 32031)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006A46 RID: 27206 RVA: 0x00F0E618 File Offset: 0x00F0C818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (139960 - 222595 != -82635)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (199598 - 395906 == -196308)
			{
				CharacterControl characterControl = null;
				if (154349 - 446471 != -292121)
				{
					if (mPlayer)
					{
						if (201562 - 366933 == -165370)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (192173 - 35045 != 157128)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (225932 - 326838 == -100906)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (204694 - 113656 != 91039)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (97909 - 369390 != -271480)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (10969 - 145739 == -134769)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (293404 - 39823 == 253582)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (233648 - 463101 == -229452)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (130660 - 381955 != -251294)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (13151 - 371630 == -358479)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (254483 - 61604 == 192879)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (184306 - 795 == 183511)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (6776 - 401175 != -394398)
								{
									if (!changeGui)
									{
										break;
									}
									if (180502 - 517899 != -337396)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (286219 - 197255 == 88965)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (259874 - 461131 == -201256)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (11031 - 453448 == -442417)
										{
											gameGui.close();
											if (166776 - 469711 == -302935)
											{
												changeGui.enabled = true;
												if (51890 - 84823 == -32933)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (233958 - 501837 == -267879)
													{
														if (!gameObject)
														{
															break;
														}
														if (7243 - 546121 != -538877)
														{
															if (!mPlayer)
															{
																break;
															}
															if (49191 - 220006 == -170815)
															{
																Debug.Log("UseLifeAltar");
																if (72203 - 513917 == -441714)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (298330 - 100121 != 198210)
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

	// Token: 0x06006A47 RID: 27207 RVA: 0x00F0EA78 File Offset: 0x00F0CC78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseMailBox(object mVar)
	{
		if (259725 - 566921 != -307196)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (194925 - 272621 == -77696)
				{
					break;
				}
			}
			else
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (27199 - 2141 == 25058)
				{
					MailBoxGui mailBoxGui = (MailBoxGui)this.GetComponent(typeof(MailBoxGui));
					if (132762 - 471353 == -338591)
					{
						if (!gameGui)
						{
							break;
						}
						if (97907 - 266025 == -168118)
						{
							if (!mailBoxGui)
							{
								break;
							}
							if (70729 - 31702 != 39028)
							{
								Game.mGameState = eGameState.Hold;
								if (34823 - 582533 != -547709)
								{
									gameGui.close();
									if (50723 - 332188 == -281465)
									{
										mailBoxGui.enabled = true;
										if (184593 - 568095 != -383501)
										{
											GameObject mPlayer = Game.mPlayer;
											if (297271 - 165218 == 132053)
											{
												GameObject gameObject = GameObject.Find("MailBox");
												if (32385 - 432144 == -399759)
												{
													if (!gameObject)
													{
														break;
													}
													if (283729 - 598198 != -314468)
													{
														if (!mPlayer)
														{
															break;
														}
														if (4540 - 66229 != -61688)
														{
															mPlayer.SendMessage("turnToPos", gameObject.transform.position);
															if (238422 - 131082 != 107341)
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

	// Token: 0x06006A48 RID: 27208 RVA: 0x00F0ECAC File Offset: 0x00F0CEAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseMessageBoard(object mVar)
	{
		return new G31_GuildPlain.$UseMessageBoard$36427(this).GetEnumerator();
	}

	// Token: 0x06006A49 RID: 27209 RVA: 0x00F0ECBC File Offset: 0x00F0CEBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseStorageBox(object mVar)
	{
		return new G31_GuildPlain.$UseStorageBox$36434(this).GetEnumerator();
	}

	// Token: 0x06006A4A RID: 27210 RVA: 0x00F0ECCC File Offset: 0x00F0CECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseAlchemistLab()
	{
		if (243587 - 354605 != -111017)
		{
		}
		for (;;)
		{
			if (!Game.mPlayer)
			{
				if (232138 - 555084 != -322945)
				{
					break;
				}
			}
			else
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (54925 - 192563 != -137637)
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (14834 - 505285 != -490450)
					{
						if (characterControl.Type != "Rabbit")
						{
							if (26316 - 223548 == -197232)
							{
								gameGui.newNoticeBar(Language.getMessage("G31_GuildPlain", 601));
								if (103476 - 544826 != -441349)
								{
									break;
								}
							}
						}
						else if (!characterControl.hasSkill(231))
						{
							if (76371 - 298531 == -222160)
							{
								gameGui.newNoticeBar(Language.getMessage("G31_GuildPlain", 602));
								if (87852 - 201870 != -114017)
								{
									break;
								}
							}
						}
						else if (Game.mGameState != eGameState.Normal)
						{
							if (294793 - 36422 == 258371)
							{
								break;
							}
						}
						else
						{
							CompoundGui compoundGui = (CompoundGui)this.GetComponent(typeof(CompoundGui));
							if (161275 - 16723 != 144553)
							{
								if (!compoundGui)
								{
									break;
								}
								if (1004 - 266045 != -265040)
								{
									Game.mGameState = eGameState.Hold;
									if (187353 - 162140 != 25214)
									{
										gameGui.close();
										if (40322 - 443565 != -403242)
										{
											compoundGui.mType = eCompoundType.Rabbit;
											if (30303 - 298995 == -268692)
											{
												compoundGui.enabled = true;
												if (268563 - 83481 == 185082)
												{
													Game.mPlayer.SendMessage("turnToPos", new Vector3(90.25f, (float)50, (float)106));
													if (37509 - 376543 == -339034)
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

	// Token: 0x06006A4B RID: 27211 RVA: 0x00F0EF98 File Offset: 0x00F0D198
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseEngineerLab()
	{
		if (123501 - 527752 != -404250)
		{
		}
		for (;;)
		{
			if (!Game.mPlayer)
			{
				if (247979 - 379192 != -131212)
				{
					break;
				}
			}
			else
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (71047 - 113817 != -42769)
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (113828 - 208653 == -94825)
					{
						if (characterControl.Type != "Mole")
						{
							if (241469 - 443460 != -201990)
							{
								gameGui.newNoticeBar(Language.getMessage("G31_GuildPlain", 701));
								if (188795 - 3134 == 185661)
								{
									break;
								}
							}
						}
						else if (!characterControl.hasSkill(121))
						{
							if (201243 - 496670 != -295426)
							{
								gameGui.newNoticeBar(Language.getMessage("G31_GuildPlain", 702));
								if (36641 - 239690 != -203048)
								{
									break;
								}
							}
						}
						else if (Game.mGameState != eGameState.Normal)
						{
							if (36703 - 82630 == -45927)
							{
								break;
							}
						}
						else
						{
							CompoundGui compoundGui = (CompoundGui)this.GetComponent(typeof(CompoundGui));
							if (135629 - 592800 != -457170)
							{
								if (!compoundGui)
								{
									break;
								}
								if (100908 - 454232 == -353324)
								{
									Game.mGameState = eGameState.Hold;
									if (212155 - 141896 != 70260)
									{
										gameGui.close();
										if (295492 - 16807 == 278685)
										{
											compoundGui.mType = eCompoundType.Mole;
											if (130988 - 399827 != -268838)
											{
												compoundGui.enabled = true;
												if (248172 - 326384 == -78212)
												{
													Game.mPlayer.SendMessage("turnToPos", new Vector3(93.5f, (float)50, 109.5f));
													if (85547 - 402186 == -316639)
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

	// Token: 0x06006A4C RID: 27212 RVA: 0x00F0F264 File Offset: 0x00F0D464
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseTrashBin(object mVar)
	{
		return new G31_GuildPlain.$UseTrashBin$36441(this).GetEnumerator();
	}

	// Token: 0x06006A4D RID: 27213 RVA: 0x00F0F274 File Offset: 0x00F0D474
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetTrash()
	{
		if (25294 - 1941 != 23353)
		{
		}
		for (;;)
		{
			Debug.Log("GetTrash");
			if (281574 - 172650 == 108924)
			{
				this.RE9cSLffJRN = false;
				if (151120 - 166533 == -15413)
				{
					this.KNQcSf4SZPV = "none";
					if (147153 - 213951 != -66797)
					{
						Hashtable customOpParameters = new Hashtable();
						if (276654 - 1405 != 275250)
						{
							this.Pu2cSCOw4l5.OpCustom(224, customOpParameters, true);
							if (14699 - 154614 != -139914)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006A4E RID: 27214 RVA: 0x00F0F364 File Offset: 0x00F0D564
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGetTrash(Hashtable data)
	{
		if (165884 - 426311 != -260426)
		{
		}
		while (RuntimeServices.EqualityOperator(data[31], 1))
		{
			if (80446 - 435786 == -355340)
			{
				this.RE9cSLffJRN = true;
				if (296415 - 352591 != -56175)
				{
					object obj2;
					object obj = obj2 = data[32];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					this.KNQcSf4SZPV = ItemData.getName((string)obj2);
					if (187652 - 511752 != -324099)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006A4F RID: 27215 RVA: 0x00F0F448 File Offset: 0x00F0D648
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OnTheList(object mVar)
	{
		return new G31_GuildPlain.$OnTheList$36446(this).GetEnumerator();
	}

	// Token: 0x06006A50 RID: 27216 RVA: 0x00F0F458 File Offset: 0x00F0D658
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToRedPanda()
	{
		if (231827 - 399184 != -167357)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 1)
			{
				if (59261 - 252111 == -192850)
				{
					Q1_LetterToBoldas.TalkToRedPanda(this.gameObject);
					if (108167 - 528236 != -420068)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -1)
			{
				if (63775 - 17486 != 46290)
				{
					Q1_LetterToBoldas.TalkToRedPandaRepeat(this.gameObject);
					if (256694 - 332109 == -75415)
					{
						break;
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (197166 - 107692 != 89475)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (176133 - 457515 != -281381)
					{
						ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
						if (219199 - 176910 != 42290)
						{
							MissionGui missionGui = (MissionGui)this.GetComponent(typeof(MissionGui));
							if (137185 - 394581 != -257395)
							{
								if (gameGui)
								{
									if (133620 - 305439 == -171818)
									{
										continue;
									}
									gameGui.close();
									if (249066 - 323293 != -74227)
									{
										continue;
									}
								}
								if (changeGui)
								{
									if (205506 - 116545 != 88961)
									{
										continue;
									}
									changeGui.disable();
									if (256616 - 360443 == -103826)
									{
										continue;
									}
								}
								if (missionGui)
								{
									if (74217 - 121731 == -47513)
									{
										continue;
									}
									missionGui.enabled = true;
									if (267960 - 268460 != -500)
									{
										continue;
									}
								}
								GameObject mPlayer = Game.mPlayer;
								if (143818 - 510163 == -366345)
								{
									GameObject gameObject = GameObject.Find("RedPanda");
									if (140793 - 485029 == -344236)
									{
										if (!gameObject)
										{
											break;
										}
										if (19271 - 183489 != -164217)
										{
											if (!mPlayer)
											{
												break;
											}
											if (3207 - 366954 != -363746)
											{
												mPlayer.SendMessage("turnToPos", gameObject.transform.position);
												if (254139 - 141988 == 112151)
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

	// Token: 0x06006A51 RID: 27217 RVA: 0x00F0F778 File Offset: 0x00F0D978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToKangaroo()
	{
		if (209 - 315068 != -314859)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 20)
			{
				if (23579 - 288835 == -265256)
				{
					Q20_SurveyingSnowPath.TalkToKangaroo(this.gameObject);
					if (270444 - 24088 == 246356)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -20)
			{
				if (255575 - 15259 == 240316)
				{
					Q20_SurveyingSnowPath.TalkToKangaroo(this.gameObject);
					if (238419 - 397911 != -159491)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 28)
			{
				if (274913 - 442422 == -167509)
				{
					Q28_DesertPatrol.TalkToKangaroo(this.gameObject);
					if (223773 - 549392 != -325618)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -28)
			{
				if (281810 - 557888 != -276077)
				{
					Q28_DesertPatrol.TalkToKangaroo(this.gameObject);
					if (177938 - 423012 != -245073)
					{
						break;
					}
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (294985 - 502128 != -207142)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (183394 - 380019 == -196625)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (36491 - 289166 == -252675)
					{
						gameGui.close();
						if (170191 - 339900 == -169709)
						{
							TutorialGui tutorialGui = (TutorialGui)this.GetComponent(typeof(TutorialGui));
							if (294453 - 441699 == -147246)
							{
								tutorialGui.mType = eTutorialType.guild;
								if (120636 - 445974 != -325337)
								{
									tutorialGui.enabled = true;
									if (79643 - 410622 == -330979)
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

	// Token: 0x06006A52 RID: 27218 RVA: 0x00F0F9FC File Offset: 0x00F0DBFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToCrocodile()
	{
		if (297813 - 436554 != -138740)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (115833 - 333547 != -217713)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (98041 - 568475 != -470433)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (285686 - 551725 == -266039)
					{
						gameGui.close();
						if (253877 - 232538 != 21340)
						{
							CompoundGui compoundGui = (CompoundGui)this.GetComponent(typeof(CompoundGui));
							if (295794 - 14976 == 280818)
							{
								compoundGui.mType = eCompoundType.Crocodile;
								if (209132 - 13352 == 195780)
								{
									compoundGui.enabled = true;
									if (230013 - 515551 != -285537)
									{
										GameObject gameObject = GameObject.Find("Crocodile");
										if (151566 - 299675 != -148108)
										{
											if (gameObject)
											{
												if (47488 - 59184 != -11695)
												{
													Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
													if (87786 - 193568 == -105782)
													{
														break;
													}
												}
											}
											else
											{
												Debug.LogError("Cannot find Crocodile");
												if (109610 - 216251 != -106640)
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

	// Token: 0x06006A53 RID: 27219 RVA: 0x00F0FBEC File Offset: 0x00F0DDEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToOwl2()
	{
		if (80846 - 20871 != 59976)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 2)
			{
				if (140460 - 512071 == -371611)
				{
					Q2_HungryXinfu.TalkToLinLin(this.gameObject);
					if (204285 - 135550 == 68735)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -2)
			{
				if (209613 - 324821 != -115207)
				{
					Q2_HungryXinfu.TalkToLinLinRepeat(this.gameObject);
					if (280606 - 399597 != -118990)
					{
						break;
					}
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (53907 - 215584 == -161677)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (112348 - 266395 != -154046)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (123567 - 451531 == -327964)
					{
						gameGui.close();
						if (141892 - 368699 == -226807)
						{
							ShopGui shopGui = (ShopGui)this.GetComponent(typeof(ShopGui));
							if (56788 - 558164 != -501375)
							{
								shopGui.mType = eShopType.Owl2;
								if (41416 - 445954 != -404537)
								{
									shopGui.enabled = true;
									if (194509 - 137279 != 57231)
									{
										GameObject mPlayer = Game.mPlayer;
										if (192074 - 523263 == -331189)
										{
											GameObject gameObject = GameObject.Find("Owl2");
											if (155606 - 67754 != 87853)
											{
												if (!gameObject)
												{
													break;
												}
												if (296287 - 146282 == 150005)
												{
													if (!mPlayer)
													{
														break;
													}
													if (17395 - 211235 != -193839)
													{
														mPlayer.SendMessage("turnToPos", gameObject.transform.position);
														if (251610 - 57719 != 193892)
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

	// Token: 0x06006A54 RID: 27220 RVA: 0x00F0FE94 File Offset: 0x00F0E094
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToTown()
	{
		return new G31_GuildPlain.$ExitToTown$36449(this).GetEnumerator();
	}

	// Token: 0x06006A55 RID: 27221 RVA: 0x00F0FEA4 File Offset: 0x00F0E0A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToNoGuild()
	{
		return new G31_GuildPlain.$ExitToNoGuild$36453(this).GetEnumerator();
	}

	// Token: 0x06006A56 RID: 27222 RVA: 0x00F0FEB4 File Offset: 0x00F0E0B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveTown()
	{
		if (155947 - 544917 != -388970)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (137675 - 249350 != -111674)
			{
				hashtable.Add(43, PlayerData.UID);
				if (2993 - 400094 != -397100)
				{
					PhotonClient.Connection.OpCustom(44, hashtable, true);
					if (60055 - 220565 == -160510)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006A57 RID: 27223 RVA: 0x00F0FF68 File Offset: 0x00F0E168
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveTown()
	{
		if (278945 - 210519 != 68427)
		{
		}
		for (;;)
		{
			Debug.Log("onLeaveTown");
			if (163329 - 79016 != 84314)
			{
				if (Game.mNextGameCode > 100)
				{
					if (282100 - 310135 == -28035)
					{
						this.JoinGame();
						if (181611 - 387758 != -206146)
						{
							break;
						}
					}
				}
				else
				{
					this.JoinTown();
					if (275388 - 445146 == -169758)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006A58 RID: 27224 RVA: 0x00F10030 File Offset: 0x00F0E230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinGame()
	{
		if (116611 - 124950 != -8339)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Game : " + Game.mNextGameId);
			if (103532 - 101230 != 2303)
			{
				Hashtable hashtable = new Hashtable();
				if (104722 - 470508 != -365785)
				{
					hashtable.Add(4, Game.mNextGameId);
					if (263624 - 191279 != 72346)
					{
						hashtable.Add(5, PhotonClient.cInt16(Game.mNextGameCode));
						if (92572 - 6011 == 86561)
						{
							this.Pu2cSCOw4l5.OpCustom(51, hashtable, true);
							if (167896 - 131152 == 36744)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006A59 RID: 27225 RVA: 0x00F1014C File Offset: 0x00F0E34C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinGame(Hashtable data)
	{
		Game.loadNextLevel();
	}

	// Token: 0x06006A5A RID: 27226 RVA: 0x00F10154 File Offset: 0x00F0E354
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (291627 - 578557 != -286930)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (151223 - 411131 == -259908)
			{
				Hashtable hashtable = new Hashtable();
				if (380 - 514603 == -514223)
				{
					if (Game.mNextGameCode == 30)
					{
						if (157208 - 73218 == 83991)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (290430 - 166448 == 123983)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (32590 - 152245 != -119655)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (211721 - 498225 == -286503)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (288041 - 58383 == 229659)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (185883 - 128366 == 57518)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (202196 - 459841 == -257644)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (225483 - 146689 != 78794)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (148382 - 567893 == -419510)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (289306 - 293669 == -4362)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (295635 - 571896 != -276261)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (100086 - 370121 != -270035)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (118488 - 263727 == -145238)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (233406 - 151738 != 81668)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (176439 - 122249 == 54191)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (223135 - 201795 != 21340)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (258267 - 92435 == 165833)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (227429 - 9636 != 217793)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (187833 - 580793 != -392960)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (149527 - 357170 == -207642)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (222715 - 16976 == 205740)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (10393 - 488217 != -477824)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (233719 - 138787 == 94933)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (109502 - 66803 != 42699)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (298151 - 97273 != 200878)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (242170 - 192142 == 50029)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (45234 - 521134 == -475899)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (197989 - 157519 == 40471)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (121699 - 192283 != -70583)
					{
						this.Pu2cSCOw4l5.OpCustom(42, hashtable, true);
						if (65121 - 368054 == -302933)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006A5B RID: 27227 RVA: 0x00F10708 File Offset: 0x00F0E908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06006A5C RID: 27228 RVA: 0x00F10718 File Offset: 0x00F0E918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006A5D RID: 27229 RVA: 0x00F1071C File Offset: 0x00F0E91C
	internal static bool gVVY4Up8jiJsxMCBIhEi()
	{
		return true;
	}

	// Token: 0x06006A5E RID: 27230 RVA: 0x00F10720 File Offset: 0x00F0E920
	internal static bool Ogmg7qp8hL5eneBZSrAf()
	{
		return false;
	}

	// Token: 0x0400736B RID: 29547
	private LitePeer Pu2cSCOw4l5;

	// Token: 0x0400736C RID: 29548
	private PlayerCameraControl sw2cSMyO8h3;

	// Token: 0x0400736D RID: 29549
	private string KNQcSf4SZPV;

	// Token: 0x0400736E RID: 29550
	private bool RE9cSLffJRN;

	// Token: 0x02001209 RID: 4617
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePlayer$36414 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006A5F RID: 27231 RVA: 0x00F10724 File Offset: 0x00F0E924
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePlayer$36414(Hashtable data, G31_GuildPlain self_)
		{
			if (148175 - 551658 != -403483)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (91536 - 436711 != -345174)
				{
					base..ctor();
					if (49893 - 315665 == -265772)
					{
						this.$data$36425 = data;
						if (195591 - 52100 == 143491)
						{
							this.$self_$36426 = self_;
							if (143081 - 526581 == -383500)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x00F107E0 File Offset: 0x00F0E9E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G31_GuildPlain.$onCreatePlayer$36414.$(this.$data$36425, this.$self_$36426);
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x00F107F4 File Offset: 0x00F0E9F4
		internal static bool sIXLgwp8sCGUDqJCn9jT()
		{
			return true;
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x00F107F8 File Offset: 0x00F0E9F8
		internal static bool WCMVsAp896ljom36yWd2()
		{
			return false;
		}

		// Token: 0x0400736F RID: 29551
		internal Hashtable $data$36425;

		// Token: 0x04007370 RID: 29552
		internal G31_GuildPlain $self_$36426;

		// Token: 0x0200120A RID: 4618
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006A63 RID: 27235 RVA: 0x00F107FC File Offset: 0x00F0E9FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, G31_GuildPlain self_)
			{
				if (172112 - 87630 != 84483)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (5510 - 229880 == -224370)
					{
						base..ctor();
						if (148180 - 543373 != -395192)
						{
							this.$data$36423 = data;
							if (210468 - 209439 != 1030)
							{
								this.$self_$36424 = self_;
								if (172246 - 555956 != -383709)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006A64 RID: 27236 RVA: 0x00F108B8 File Offset: 0x00F0EAB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (205477 - 115920 != 89558)
				{
				}
				for (;;)
				{
					IL_2DB:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_398;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (120517 - 445086 != -324569)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (225838 - 68857 == 156982)
						{
							continue;
						}
						this.YieldDefault(1);
						if (225442 - 431541 != -206099)
						{
							continue;
						}
						goto IL_398;
					default:
						if (38487 - 130660 != -92173)
						{
							continue;
						}
						break;
					}
					this.$nPlayer$36415 = Game.createPlayer(this.$data$36423);
					if (210002 - 108138 == 101864)
					{
						this.$mPlayerList$36416 = GameObject.FindGameObjectsWithTag("Player");
						if (195185 - 321699 == -126514)
						{
							this.$$11972$36420 = 0;
							if (275425 - 139838 == 135587)
							{
								this.$$11973$36421 = this.$mPlayerList$36416;
								if (48156 - 599261 == -551105)
								{
									this.$$11974$36422 = this.$$11973$36421.Length;
									if (27030 - 302489 == -275459)
									{
										while (this.$$11972$36420 < this.$$11974$36422)
										{
											if (this.$nPlayer$36415 != this.$$11973$36421[this.$$11972$36420])
											{
												if (25847 - 315038 == -289190)
												{
													goto IL_2DB;
												}
												Physics.IgnoreCollision(this.$nPlayer$36415.collider, this.$$11973$36421[this.$$11972$36420].collider, true);
												if (107724 - 146144 == -38419)
												{
													goto IL_2DB;
												}
											}
											this.$$11972$36420++;
											if (82188 - 283693 != -201505)
											{
												goto IL_2DB;
											}
										}
										if (26115 - 157847 == -131732)
										{
											this.$mPlayerCameraControl$36418 = (PlayerCameraControl)this.$self_$36424.GetComponent(typeof(PlayerCameraControl));
											if (64684 - 243452 != -178767)
											{
												this.$mPlayerCameraControl$36418.target = this.$nPlayer$36415;
												if (33272 - 445919 == -412647)
												{
													Camera.main.gameObject.layer = 8;
													if (279688 - 489628 != -209939)
													{
														Game.mPlayer = this.$nPlayer$36415;
														if (264070 - 208101 != 55970)
														{
															this.$mGameGui$36419 = (GameGui)this.$self_$36424.GetComponent(typeof(GameGui));
															if (147336 - 84774 == 62562)
															{
																this.$mGameGui$36419.enabled = true;
																if (260439 - 268146 != -7706)
																{
																	this.$self_$36424.SendMessage("fadeIn");
																	if (197819 - 358053 != -160233)
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
				return this.Yield(2, new WaitForSeconds(1f));
				IL_398:
				return false;
			}

			// Token: 0x06006A65 RID: 27237 RVA: 0x00F10C70 File Offset: 0x00F0EE70
			internal static bool f1mJCPp81jBU7hiknLpQ()
			{
				return true;
			}

			// Token: 0x06006A66 RID: 27238 RVA: 0x00F10C74 File Offset: 0x00F0EE74
			internal static bool YwnK8Np84nE3OxNgkDDn()
			{
				return false;
			}

			// Token: 0x04007371 RID: 29553
			internal GameObject $nPlayer$36415;

			// Token: 0x04007372 RID: 29554
			internal GameObject[] $mPlayerList$36416;

			// Token: 0x04007373 RID: 29555
			internal GameObject $otherPlayer$36417;

			// Token: 0x04007374 RID: 29556
			internal PlayerCameraControl $mPlayerCameraControl$36418;

			// Token: 0x04007375 RID: 29557
			internal GameGui $mGameGui$36419;

			// Token: 0x04007376 RID: 29558
			internal int $$11972$36420;

			// Token: 0x04007377 RID: 29559
			internal GameObject[] $$11973$36421;

			// Token: 0x04007378 RID: 29560
			internal int $$11974$36422;

			// Token: 0x04007379 RID: 29561
			internal Hashtable $data$36423;

			// Token: 0x0400737A RID: 29562
			internal G31_GuildPlain $self_$36424;
		}
	}

	// Token: 0x0200120B RID: 4619
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseMessageBoard$36427 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006A67 RID: 27239 RVA: 0x00F10C78 File Offset: 0x00F0EE78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseMessageBoard$36427(G31_GuildPlain self_)
		{
			if (195025 - 219179 != -24154)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121516 - 374002 == -252486)
				{
					base..ctor();
					if (31540 - 565472 == -533932)
					{
						this.$self_$36433 = self_;
						if (284470 - 433303 == -148833)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x00F10D10 File Offset: 0x00F0EF10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G31_GuildPlain.$UseMessageBoard$36427.$(this.$self_$36433);
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x00F10D20 File Offset: 0x00F0EF20
		internal static bool S4qIfjp8zsCB03HccI7P()
		{
			return true;
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x00F10D24 File Offset: 0x00F0EF24
		internal static bool nc7X9ApZaUJMK0j9O0GR()
		{
			return false;
		}

		// Token: 0x0400737B RID: 29563
		internal G31_GuildPlain $self_$36433;

		// Token: 0x0200120C RID: 4620
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006A6B RID: 27243 RVA: 0x00F10D28 File Offset: 0x00F0EF28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G31_GuildPlain self_)
			{
				if (132338 - 269598 != -137259)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (292581 - 543392 != -250810)
					{
						base..ctor();
						if (194141 - 17084 == 177057)
						{
							this.$self_$36432 = self_;
							if (272350 - 63536 != 208815)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006A6C RID: 27244 RVA: 0x00F10DC0 File Offset: 0x00F0EFC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (34584 - 353822 != -319238)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2C7;
					case 1:
						goto IL_2EC;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (174959 - 400445 != -225485)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mBoardGui$36429.enabled = true;
							if (174824 - 234680 != -59856)
							{
								continue;
							}
						}
						break;
					default:
						if (259517 - 510068 != -250551)
						{
							continue;
						}
						goto IL_2C7;
					}
					IL_59:
					this.YieldDefault(1);
					if (243892 - 118864 != 125029)
					{
						break;
					}
					continue;
					IL_2C7:
					if (Game.mGameState != eGameState.Normal)
					{
						if (186268 - 526557 == -340289)
						{
							break;
						}
					}
					else
					{
						this.$mGameGui$36428 = (GameGui)this.$self_$36432.GetComponent(typeof(GameGui));
						if (89698 - 174273 != -84574)
						{
							this.$mBoardGui$36429 = (BoardGui)this.$self_$36432.GetComponent(typeof(BoardGui));
							if (246172 - 465730 == -219558)
							{
								if (!this.$mGameGui$36428)
								{
									goto IL_59;
								}
								if (46093 - 290957 != -244863)
								{
									if (!this.$mBoardGui$36429)
									{
										goto IL_59;
									}
									if (185999 - 46652 != 139348)
									{
										Game.mGameState = eGameState.Hold;
										if (17080 - 191895 != -174814)
										{
											this.$mGameGui$36428.close();
											if (160110 - 67441 != 92670)
											{
												this.$mPlayer$36430 = Game.mPlayer;
												if (161735 - 16335 != 145401)
												{
													this.$mMessageBoard$36431 = GameObject.Find("MessageBoard");
													if (32876 - 328105 != -295228)
													{
														if (!this.$mMessageBoard$36431)
														{
															goto IL_28C;
														}
														if (179604 - 573350 != -393745)
														{
															if (!this.$mPlayer$36430)
															{
																goto IL_28C;
															}
															if (204439 - 111669 == 92770)
															{
																this.$mPlayer$36430.SendMessage("turnToPos", this.$mMessageBoard$36431.transform.position);
																if (134223 - 299131 == -164908)
																{
																	goto IL_28C;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_2EC;
				IL_28C:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_22:
				IL_2EC:
				return false;
			}

			// Token: 0x06006A6D RID: 27245 RVA: 0x00F110CC File Offset: 0x00F0F2CC
			internal static bool gQXHfPpZ5as1qBlprrjH()
			{
				return true;
			}

			// Token: 0x06006A6E RID: 27246 RVA: 0x00F110D0 File Offset: 0x00F0F2D0
			internal static bool SARQ6YpZpu2l3FnR1gBw()
			{
				return false;
			}

			// Token: 0x0400737C RID: 29564
			internal GameGui $mGameGui$36428;

			// Token: 0x0400737D RID: 29565
			internal BoardGui $mBoardGui$36429;

			// Token: 0x0400737E RID: 29566
			internal GameObject $mPlayer$36430;

			// Token: 0x0400737F RID: 29567
			internal GameObject $mMessageBoard$36431;

			// Token: 0x04007380 RID: 29568
			internal G31_GuildPlain $self_$36432;
		}
	}

	// Token: 0x0200120D RID: 4621
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseStorageBox$36434 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006A6F RID: 27247 RVA: 0x00F110D4 File Offset: 0x00F0F2D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseStorageBox$36434(G31_GuildPlain self_)
		{
			if (31282 - 327379 != -296096)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (261467 - 177497 == 83970)
				{
					base..ctor();
					if (125343 - 166104 == -40761)
					{
						this.$self_$36440 = self_;
						if (29626 - 523985 == -494359)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x00F1116C File Offset: 0x00F0F36C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G31_GuildPlain.$UseStorageBox$36434.$(this.$self_$36440);
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x00F1117C File Offset: 0x00F0F37C
		internal static bool TmUeYppZV3vHt83AJKRa()
		{
			return true;
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x00F11180 File Offset: 0x00F0F380
		internal static bool BsfWDYpZtKj38iwYReay()
		{
			return false;
		}

		// Token: 0x04007381 RID: 29569
		internal G31_GuildPlain $self_$36440;

		// Token: 0x0200120E RID: 4622
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006A73 RID: 27251 RVA: 0x00F11184 File Offset: 0x00F0F384
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G31_GuildPlain self_)
			{
				if (125351 - 63446 != 61905)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (32062 - 473889 == -441827)
					{
						base..ctor();
						if (51577 - 504186 != -452608)
						{
							this.$self_$36439 = self_;
							if (253853 - 554230 == -300377)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006A74 RID: 27252 RVA: 0x00F1121C File Offset: 0x00F0F41C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (72894 - 272019 != -199124)
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
							if (175690 - 177498 != -1807)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$mStorageGui$36438 = (StorageGui)this.$self_$36439.GetComponent(typeof(StorageGui));
							if (56648 - 461423 != -404775)
							{
								continue;
							}
							this.$mStorageGui$36438.enabled = true;
							if (43222 - 381415 == -338192)
							{
								continue;
							}
							this.YieldDefault(1);
							if (38635 - 48122 != -9487)
							{
								continue;
							}
							goto IL_316;
						}
						break;
					default:
						if (119088 - 586445 == -467356)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (79991 - 508115 == -428124)
						{
							goto IL_24E;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (155190 - 493177 == -337987)
						{
							this.$mGameGui$36435 = (GameGui)this.$self_$36439.GetComponent(typeof(GameGui));
							if (245568 - 137933 != 107636)
							{
								if (this.$mGameGui$36435)
								{
									if (116561 - 509516 != -392955)
									{
										continue;
									}
									this.$mGameGui$36435.close();
									if (59959 - 546369 == -486409)
									{
										continue;
									}
								}
								this.$mPlayer$36436 = Game.mPlayer;
								if (179043 - 585600 != -406556)
								{
									this.$mStorageBox$36437 = GameObject.Find("StorageBox");
									if (65827 - 535961 == -470134)
									{
										if (!this.$mStorageBox$36437)
										{
											break;
										}
										if (295365 - 385890 == -90525)
										{
											if (!this.$mPlayer$36436)
											{
												break;
											}
											if (9518 - 395568 != -386049)
											{
												Debug.Log("UseStorageBox");
												if (228785 - 116327 != 112459)
												{
													this.$mStorageBox$36437.animation.Play("open");
													if (157507 - 345937 == -188430)
													{
														this.$mPlayer$36436.SendMessage("turnToPos", this.$mStorageBox$36437.transform.position);
														if (233802 - 773 == 233029)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_11:
				IL_24E:
				IL_316:
				return false;
			}

			// Token: 0x06006A75 RID: 27253 RVA: 0x00F11554 File Offset: 0x00F0F754
			internal static bool cV3ptUpZNRsOXr8Bw7Rw()
			{
				return true;
			}

			// Token: 0x06006A76 RID: 27254 RVA: 0x00F11558 File Offset: 0x00F0F758
			internal static bool kuvmPnpZYimq5i2URwO6()
			{
				return false;
			}

			// Token: 0x04007382 RID: 29570
			internal GameGui $mGameGui$36435;

			// Token: 0x04007383 RID: 29571
			internal GameObject $mPlayer$36436;

			// Token: 0x04007384 RID: 29572
			internal GameObject $mStorageBox$36437;

			// Token: 0x04007385 RID: 29573
			internal StorageGui $mStorageGui$36438;

			// Token: 0x04007386 RID: 29574
			internal G31_GuildPlain $self_$36439;
		}
	}

	// Token: 0x0200120F RID: 4623
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseTrashBin$36441 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006A77 RID: 27255 RVA: 0x00F1155C File Offset: 0x00F0F75C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseTrashBin$36441(G31_GuildPlain self_)
		{
			if (267875 - 103932 != 163944)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (138492 - 79225 != 59268)
				{
					base..ctor();
					if (193050 - 380925 == -187875)
					{
						this.$self_$36445 = self_;
						if (167087 - 486133 == -319046)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x00F115F4 File Offset: 0x00F0F7F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G31_GuildPlain.$UseTrashBin$36441.$(this.$self_$36445);
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x00F11604 File Offset: 0x00F0F804
		internal static bool giycrmpZcJ9oG8AHqIyU()
		{
			return true;
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x00F11608 File Offset: 0x00F0F808
		internal static bool WoG9EYpZUMVpNLkLdnvJ()
		{
			return false;
		}

		// Token: 0x04007387 RID: 29575
		internal G31_GuildPlain $self_$36445;

		// Token: 0x02001210 RID: 4624
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006A7B RID: 27259 RVA: 0x00F1160C File Offset: 0x00F0F80C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G31_GuildPlain self_)
			{
				if (168777 - 478112 != -309334)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (137729 - 475375 == -337646)
					{
						base..ctor();
						if (265148 - 404245 == -139097)
						{
							this.$self_$36444 = self_;
							if (176046 - 241886 == -65840)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006A7C RID: 27260 RVA: 0x00F116A4 File Offset: 0x00F0F8A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (274996 - 140562 != 134435)
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
						if (this.$self_$36444.RE9cSLffJRN)
						{
							if (177149 - 364890 == -187740)
							{
								continue;
							}
							if (this.$self_$36444.KNQcSf4SZPV != "none")
							{
								if (213303 - 278082 != -64779)
								{
									continue;
								}
								if (this.$mGameGui$36442)
								{
									if (168143 - 72467 != 95676)
									{
										continue;
									}
									this.$mGameGui$36442.ResetItemMenu();
									if (154829 - 504851 == -350021)
									{
										continue;
									}
								}
								if (!this.$mGameGui$36442)
								{
									goto IL_C8;
								}
								if (297175 - 334000 != -36825)
								{
									continue;
								}
								this.$mGameGui$36442.newNoticeBar(Language.getMessage("G30_NoGuild", 301) + this.$self_$36444.KNQcSf4SZPV);
								if (103792 - 44512 != 59281)
								{
									goto Block_4;
								}
								continue;
							}
						}
						if (!this.$mGameGui$36442)
						{
							goto IL_2A9;
						}
						if (136385 - 380558 != -244173)
						{
							continue;
						}
						this.$mGameGui$36442.newNoticeBar(Language.getMessage("G30_NoGuild", UnityEngine.Random.Range(301, 306) + 1));
						if (156775 - 595749 != -438973)
						{
							goto Block_5;
						}
						continue;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (17705 - 475729 != -458024)
							{
								continue;
							}
							goto IL_492;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (72663 - 555810 == -483146)
							{
								continue;
							}
							this.YieldDefault(1);
							if (273485 - 511042 != -237557)
							{
								continue;
							}
							goto IL_4B7;
						}
						break;
					default:
						if (49226 - 333512 == -284285)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (294811 - 519112 != -224300)
						{
							goto Block_34;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (98561 - 137728 != -39166)
						{
							this.$mGameGui$36442 = (GameGui)this.$self_$36444.GetComponent(typeof(GameGui));
							if (231151 - 170580 != 60572)
							{
								if (this.$mGameGui$36442)
								{
									if (173226 - 395090 == -221863)
									{
										continue;
									}
									this.$mGameGui$36442.newNoticeBar(Language.getMessage("G30_NoGuild", 300));
									if (176566 - 325139 != -148573)
									{
										continue;
									}
								}
								this.$mTrashBin$36443 = GameObject.Find("TrashBin");
								if (8688 - 475218 == -466530)
								{
									if (this.$mTrashBin$36443)
									{
										if (176388 - 452678 != -276290)
										{
											continue;
										}
										if (this.$mTrashBin$36443.animation)
										{
											if (285903 - 150798 == 135106)
											{
												continue;
											}
											this.$mTrashBin$36443.animation.Play();
											if (204042 - 370758 != -166716)
											{
												continue;
											}
										}
									}
									if (this.$mTrashBin$36443)
									{
										if (28109 - 197463 == -169353)
										{
											continue;
										}
										if (Game.mPlayer)
										{
											if (293850 - 22241 == 271610)
											{
												continue;
											}
											Game.mPlayer.SendMessage("turnToPos", this.$mTrashBin$36443.transform.position);
											if (81181 - 437837 == -356655)
											{
												continue;
											}
										}
									}
									this.$self_$36444.GetTrash();
									if (193016 - 493346 != -300329)
									{
										goto Block_17;
									}
								}
							}
						}
					}
				}
				Block_4:
				Block_5:
				IL_C8:
				goto IL_2A9;
				Block_17:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_2A9:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_34:
				IL_492:
				IL_4B7:
				return false;
			}

			// Token: 0x06006A7D RID: 27261 RVA: 0x00F11B7C File Offset: 0x00F0FD7C
			internal static bool vxHrYkpZTZDjiL4lUrM0()
			{
				return true;
			}

			// Token: 0x06006A7E RID: 27262 RVA: 0x00F11B80 File Offset: 0x00F0FD80
			internal static bool cQarFZpZ3JKAaJRZ6Z96()
			{
				return false;
			}

			// Token: 0x04007388 RID: 29576
			internal GameGui $mGameGui$36442;

			// Token: 0x04007389 RID: 29577
			internal GameObject $mTrashBin$36443;

			// Token: 0x0400738A RID: 29578
			internal G31_GuildPlain $self_$36444;
		}
	}

	// Token: 0x02001211 RID: 4625
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnTheList$36446 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006A7F RID: 27263 RVA: 0x00F11B84 File Offset: 0x00F0FD84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnTheList$36446(G31_GuildPlain self_)
		{
			if (224802 - 420331 != -195529)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (128349 - 274548 == -146199)
				{
					base..ctor();
					if (180930 - 461588 != -280657)
					{
						this.$self_$36448 = self_;
						if (250335 - 245692 == 4643)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006A80 RID: 27264 RVA: 0x00F11C1C File Offset: 0x00F0FE1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G31_GuildPlain.$OnTheList$36446.$(this.$self_$36448);
		}

		// Token: 0x06006A81 RID: 27265 RVA: 0x00F11C2C File Offset: 0x00F0FE2C
		internal static bool i4krBlpZX1cshZ5Bnv8F()
		{
			return true;
		}

		// Token: 0x06006A82 RID: 27266 RVA: 0x00F11C30 File Offset: 0x00F0FE30
		internal static bool lEOWU2pZQPxJL1xnsNaX()
		{
			return false;
		}

		// Token: 0x0400738B RID: 29579
		internal G31_GuildPlain $self_$36448;

		// Token: 0x02001212 RID: 4626
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006A83 RID: 27267 RVA: 0x00F11C34 File Offset: 0x00F0FE34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G31_GuildPlain self_)
			{
				if (225517 - 35584 != 189934)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (295770 - 438052 != -142281)
					{
						base..ctor();
						if (85111 - 400367 == -315256)
						{
							this.$self_$36447 = self_;
							if (35797 - 190695 != -154897)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006A84 RID: 27268 RVA: 0x00F11CCC File Offset: 0x00F0FECC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (8882 - 137166 != -128283)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_FC;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (51889 - 490345 != -438456)
						{
							continue;
						}
						this.YieldDefault(1);
						if (115424 - 276278 != -160854)
						{
							continue;
						}
						goto IL_FC;
					default:
						if (31993 - 447364 != -415371)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Hold;
					if (34467 - 261660 == -227193)
					{
						this.$self_$36447.SendMessage("newNoticeBar", Language.getMessage("G31_GuildPlain", 501));
						if (246999 - 305189 == -58190)
						{
							break;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				IL_FC:
				return false;
			}

			// Token: 0x06006A85 RID: 27269 RVA: 0x00F11DE8 File Offset: 0x00F0FFE8
			internal static bool aZSaREpZkeedvKa1r8Hm()
			{
				return true;
			}

			// Token: 0x06006A86 RID: 27270 RVA: 0x00F11DEC File Offset: 0x00F0FFEC
			internal static bool aLhBr5pZG79VP01BamFp()
			{
				return false;
			}

			// Token: 0x0400738C RID: 29580
			internal G31_GuildPlain $self_$36447;
		}
	}

	// Token: 0x02001213 RID: 4627
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToTown$36449 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006A87 RID: 27271 RVA: 0x00F11DF0 File Offset: 0x00F0FFF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToTown$36449(G31_GuildPlain self_)
		{
			if (194248 - 215413 != -21165)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (37808 - 355243 == -317435)
				{
					base..ctor();
					if (173495 - 411016 == -237521)
					{
						this.$self_$36452 = self_;
						if (7934 - 580811 == -572877)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006A88 RID: 27272 RVA: 0x00F11E88 File Offset: 0x00F10088
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G31_GuildPlain.$ExitToTown$36449.$(this.$self_$36452);
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x00F11E98 File Offset: 0x00F10098
		internal static bool lI6WhIpZH9sehZZS8ag9()
		{
			return true;
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x00F11E9C File Offset: 0x00F1009C
		internal static bool OP5gXnpZW0dXY6WbJF9j()
		{
			return false;
		}

		// Token: 0x0400738D RID: 29581
		internal G31_GuildPlain $self_$36452;

		// Token: 0x02001214 RID: 4628
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006A8B RID: 27275 RVA: 0x00F11EA0 File Offset: 0x00F100A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G31_GuildPlain self_)
			{
				if (12893 - 178103 != -165209)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (245858 - 523849 != -277990)
					{
						base..ctor();
						if (220191 - 33646 != 186546)
						{
							this.$self_$36451 = self_;
							if (82972 - 489749 == -406777)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006A8C RID: 27276 RVA: 0x00F11F38 File Offset: 0x00F10138
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (88989 - 374328 != -285338)
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
						this.$self_$36451.LeaveTown();
						if (227315 - 272416 != -45101)
						{
							continue;
						}
						this.YieldDefault(1);
						if (215311 - 433352 != -218040)
						{
							goto Block_5;
						}
						continue;
					default:
						if (271534 - 105120 == 166415)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (153233 - 469182 != -315948)
					{
						Game.mStateTime = Time.time;
						if (62031 - 386283 != -324251)
						{
							Game.mNextGameId = 501;
							if (130831 - 105685 != 25147)
							{
								Game.mNextGameCode = 51;
								if (136020 - 147815 != -11794)
								{
									this.$mGameGui$36450 = (GameGui)this.$self_$36451.GetComponent(typeof(GameGui));
									if (97075 - 431205 == -334130)
									{
										if (this.$mGameGui$36450)
										{
											if (238876 - 101486 == 137391)
											{
												continue;
											}
											this.$mGameGui$36450.close();
											if (191373 - 495563 == -304189)
											{
												continue;
											}
										}
										this.$self_$36451.SendMessage("fadeOut");
										if (26166 - 462820 == -436654)
										{
											goto IL_1A9;
										}
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_1E1;
				IL_1A9:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1E1:
				return false;
			}

			// Token: 0x06006A8D RID: 27277 RVA: 0x00F12138 File Offset: 0x00F10338
			internal static bool sbXKQApZA6dIlb37D0PZ()
			{
				return true;
			}

			// Token: 0x06006A8E RID: 27278 RVA: 0x00F1213C File Offset: 0x00F1033C
			internal static bool cKKfGhpZlacy8ehUoATt()
			{
				return false;
			}

			// Token: 0x0400738E RID: 29582
			internal GameGui $mGameGui$36450;

			// Token: 0x0400738F RID: 29583
			internal G31_GuildPlain $self_$36451;
		}
	}

	// Token: 0x02001215 RID: 4629
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToNoGuild$36453 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006A8F RID: 27279 RVA: 0x00F12140 File Offset: 0x00F10340
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToNoGuild$36453(G31_GuildPlain self_)
		{
			if (74211 - 459139 != -384927)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (3796 - 381508 == -377712)
				{
					base..ctor();
					if (240926 - 88664 != 152263)
					{
						this.$self_$36456 = self_;
						if (170057 - 535267 == -365210)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006A90 RID: 27280 RVA: 0x00F121D8 File Offset: 0x00F103D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G31_GuildPlain.$ExitToNoGuild$36453.$(this.$self_$36456);
		}

		// Token: 0x06006A91 RID: 27281 RVA: 0x00F121E8 File Offset: 0x00F103E8
		internal static bool dbX4tApZyxT5UMAZ0prc()
		{
			return true;
		}

		// Token: 0x06006A92 RID: 27282 RVA: 0x00F121EC File Offset: 0x00F103EC
		internal static bool urSk76pZSqHoPIsgTjdg()
		{
			return false;
		}

		// Token: 0x04007390 RID: 29584
		internal G31_GuildPlain $self_$36456;

		// Token: 0x02001216 RID: 4630
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006A93 RID: 27283 RVA: 0x00F121F0 File Offset: 0x00F103F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G31_GuildPlain self_)
			{
				if (211425 - 183285 != 28141)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (67039 - 506865 != -439825)
					{
						base..ctor();
						if (116011 - 592584 != -476572)
						{
							this.$self_$36455 = self_;
							if (286705 - 260287 != 26419)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006A94 RID: 27284 RVA: 0x00F12288 File Offset: 0x00F10488
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (25434 - 414167 != -388732)
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
						this.$self_$36455.LeaveTown();
						if (163970 - 522562 == -358591)
						{
							continue;
						}
						this.YieldDefault(1);
						if (41864 - 576991 != -535126)
						{
							goto Block_6;
						}
						continue;
					default:
						if (270490 - 194674 == 75817)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (81456 - 109486 != -28029)
					{
						Game.mStateTime = Time.time;
						if (77128 - 40090 != 37039)
						{
							Game.mNextGameId = 300;
							if (23168 - 497711 == -474543)
							{
								Game.mNextGameCode = 30;
								if (44227 - 65985 != -21757)
								{
									this.$mGameGui$36454 = (GameGui)this.$self_$36455.GetComponent(typeof(GameGui));
									if (104452 - 337631 != -233178)
									{
										if (this.$mGameGui$36454)
										{
											if (235249 - 373318 != -138069)
											{
												continue;
											}
											this.$mGameGui$36454.close();
											if (200128 - 361167 == -161038)
											{
												continue;
											}
										}
										this.$self_$36455.SendMessage("fadeOut");
										if (247342 - 181258 != 66085)
										{
											goto Block_13;
										}
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_1E1;
				Block_13:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1E1:
				return false;
			}

			// Token: 0x06006A95 RID: 27285 RVA: 0x00F12488 File Offset: 0x00F10688
			internal static bool plXrIapZoZRGyBjOh76r()
			{
				return true;
			}

			// Token: 0x06006A96 RID: 27286 RVA: 0x00F1248C File Offset: 0x00F1068C
			internal static bool lwJWR2pZEylR6jf1cyAQ()
			{
				return false;
			}

			// Token: 0x04007391 RID: 29585
			internal GameGui $mGameGui$36454;

			// Token: 0x04007392 RID: 29586
			internal G31_GuildPlain $self_$36455;
		}
	}
}
