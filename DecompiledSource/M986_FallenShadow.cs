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

// Token: 0x02001FD3 RID: 8147
[Serializable]
public class M986_FallenShadow : MonoBehaviour
{
	// Token: 0x0600BE72 RID: 48754 RVA: 0x01425FFC File Offset: 0x014241FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M986_FallenShadow()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600BE73 RID: 48755 RVA: 0x0142600C File Offset: 0x0142420C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (90452 - 468411 != -377959)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (68986 - 24506 != 44481)
			{
				Game.mGameType = 7;
				if (117308 - 409741 != -292432)
				{
					if (Chat.Initialized)
					{
						if (21087 - 390807 == -369719)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (150601 - 237425 != -86824)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (77784 - 506920 == -429135)
						{
							continue;
						}
					}
					this.G6wnrLOC0h7 = new int[9];
					if (108410 - 69700 == 38710)
					{
						this.FfanrwtQnlO = new int[9];
						if (191355 - 550166 == -358811)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE74 RID: 48756 RVA: 0x01426140 File Offset: 0x01424340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (197295 - 175557 != 21738)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (34746 - 251351 != -216604)
				{
					if (Game.mNextGameCode != 986)
					{
						break;
					}
					if (279946 - 465937 != -185990)
					{
						Game.nextGame();
						if (231402 - 113163 != 118240)
						{
							Game.mGameCode = 986;
							if (108279 - 105111 == 3168)
							{
								Game.mGameTime = Time.time + (float)1080;
								if (131405 - 68065 != 63341)
								{
									Game.mGameScore = 0;
									if (182578 - 536540 == -353962)
									{
										Game.mGameMana = 0;
										if (140104 - 323898 == -183794)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (112574 - 241968 != -129393)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (5090 - 542938 != -537847)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (20752 - 500187 != -479434)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (107620 - 526759 != -419138)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (282816 - 63613 != 219204)
															{
																this.Rf3nrsPqsHM = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (147592 - 142859 == 4733)
																{
																	this.GU9nrgryh1J = PhotonClient.Connection;
																	if (186486 - 268341 != -81854)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (280293 - 234911 == 45382)
																		{
																			this.InitGame();
																			if (90652 - 513872 == -423220)
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
				if (268019 - 270981 != -2961)
				{
					Game.mGameType = 99;
					if (173978 - 522303 == -348325)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BE75 RID: 48757 RVA: 0x01426430 File Offset: 0x01424630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (235913 - 380188 != -144274)
		{
		}
		for (;;)
		{
			if (this.GU9nrgryh1J == null)
			{
				if (266074 - 401436 == -135362)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (240224 - 171565 == 68659)
				{
					if (mGameState == eGameState.Init)
					{
						if (271960 - 477037 != -205077)
						{
							continue;
						}
						AudioListener.volume = 0.1f * (float)Game.volume;
						if (294407 - 312728 == -18320)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (251657 - 598886 == -347228)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (182340 - 427423 == -245082)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (86647 - 48218 == 38430)
						{
							continue;
						}
						if (Game.music != 0)
						{
							if (162066 - 154582 == 7485)
							{
								continue;
							}
							if (!this.audio.isPlaying)
							{
								if (84419 - 367617 != -283198)
								{
									continue;
								}
								this.audio.Play();
								if (45126 - 78716 == -33589)
								{
									continue;
								}
							}
						}
						if (Time.time - Game.mStateTime < (float)2)
						{
							if (16904 - 132153 == -115248)
							{
								continue;
							}
							this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
							if (164175 - 537590 != -373415)
							{
								continue;
							}
						}
						else
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (279504 - 393498 != -113994)
							{
								continue;
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (94963 - 402357 != -307394)
						{
							continue;
						}
						this.audio.volume = 0.1f * (float)Game.music;
						if (242210 - 504871 == -262660)
						{
							continue;
						}
						if (Time.time > this.svRnrHpdIRY)
						{
							if (161991 - 132586 == 29406)
							{
								continue;
							}
							Game.mGameMana++;
							if (153206 - 498376 != -345170)
							{
								continue;
							}
							this.svRnrHpdIRY = Time.time + (float)12;
							if (75099 - 75582 == -482)
							{
								continue;
							}
						}
						this.GameEventUpdate();
						if (272741 - 12276 != 260465)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (286077 - 581207 != -295130)
						{
							continue;
						}
						this.GameEventUpdate();
						if (250950 - 504326 == -253375)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (197989 - 204416 != -6427)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Ended)
					{
						if (236063 - 589148 != -353085)
						{
							continue;
						}
					}
					if (Game.mGameState > eGameState.Start)
					{
						if (56108 - 232350 == -176241)
						{
							continue;
						}
						if (Game.mGameState < eGameState.Ended)
						{
							if (28892 - 147733 == -118840)
							{
								continue;
							}
							if (Time.time >= Game.mGameTime)
							{
								if (138585 - 195383 == -56797)
								{
									continue;
								}
								if (this.JQInrZy8GI8 < 1)
								{
									if (162815 - 545805 == -382989)
									{
										continue;
									}
									this.JQInrZy8GI8 = 1;
									if (83622 - 414914 == -331291)
									{
										continue;
									}
									Game.sendMissionEvent(9865, 1);
									if (292293 - 231915 == 60379)
									{
										continue;
									}
								}
							}
						}
					}
					if (Game.mGameState <= eGameState.Start)
					{
						break;
					}
					if (220023 - 77496 == 142527)
					{
						if (Game.mGameState >= eGameState.AllHold)
						{
							break;
						}
						if (213922 - 27912 == 186010)
						{
							if (Time.time <= this.OkPnrS1ocGl)
							{
								break;
							}
							if (268329 - 119110 == 149219)
							{
								this.OkPnrS1ocGl = Time.time + (float)6;
								if (185645 - 426867 != -241221)
								{
									if (this.VLCnrPdNVcO)
									{
										if (124899 - 382742 != -257842)
										{
											Game.sendMissionEvent(9864, 0);
											if (269225 - 97809 != 171417)
											{
												break;
											}
										}
									}
									else
									{
										Game.sendMissionEvent(9864, 1);
										if (136941 - 285937 == -148996)
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

	// Token: 0x0600BE76 RID: 48758 RVA: 0x01426A04 File Offset: 0x01424C04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (86917 - 44997 != 41920)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (41453 - 122575 == -81122)
			{
				GUI.depth = 1;
				if (203127 - 268320 == -65193)
				{
					float num = (float)(1024 * Screen.width / Screen.height);
					if (203749 - 412040 != -208290)
					{
						eGameState mGameState = Game.mGameState;
						if (87840 - 23149 != 64692)
						{
							if (mGameState == eGameState.Normal)
							{
								if (16740 - 553515 == -536775)
								{
									if (Time.time - Game.mStateTime < (float)2)
									{
										if (161590 - 484973 == -323383)
										{
											float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
											if (218625 - 106011 != 112615)
											{
												if (!this.Uu5nr7VsJNP)
												{
													break;
												}
												if (175894 - 203108 == -27214)
												{
													float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
													if (161862 - 510550 == -348688)
													{
														Color color = GUI.color;
														if (280690 - 372798 == -92108)
														{
															color.a = a;
															if (82013 - 314163 == -232150 && 251816 - 269814 != -17997)
															{
																Color color2 = GUI.color = color;
																if (172911 - 201003 == -28092)
																{
																	if (273286 - 44824 == 228462)
																	{
																		GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.Uu5nr7VsJNP);
																		if (276332 - 375796 != -99463)
																		{
																			float a2 = 1f;
																			if (52824 - 403114 == -350290)
																			{
																				Color color3 = GUI.color;
																				if (216680 - 22691 == 193989)
																				{
																					color3.a = a2;
																					if (142292 - 572682 != -430389)
																					{
																						if (138025 - 257558 == -119533)
																						{
																							Color color4 = GUI.color = color3;
																							if (173348 - 389895 != -216546)
																							{
																								if (46020 - 488539 == -442519)
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
									else
									{
										this.RenderScoreList(num);
										if (268722 - 547416 == -278694)
										{
											break;
										}
									}
								}
							}
							else
							{
								if (mGameState != eGameState.Hold)
								{
									break;
								}
								if (239164 - 195805 == 43359)
								{
									this.RenderScoreList(num);
									if (29230 - 242729 != -213498)
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

	// Token: 0x0600BE77 RID: 48759 RVA: 0x01426E10 File Offset: 0x01425010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderScoreList(float screenWidth)
	{
		if (177979 - 557313 != -379334)
		{
		}
		for (;;)
		{
			IL_EF:
			int i = 0;
			if (269194 - 263810 != 5385)
			{
				while (i < 9)
				{
					Guix.renderSmallNumber((int)(0.5f * screenWidth - (float)220 + (float)(50 * i)), 112, this.G6wnrLOC0h7[i], false, 1f);
					if (75178 - 53168 != 22010)
					{
						goto IL_EF;
					}
					i++;
					if (18278 - 283989 == -265710)
					{
						goto IL_EF;
					}
				}
				if (135931 - 425560 != -289628)
				{
					if (!this.m)
					{
						break;
					}
					if (89250 - 469422 == -380172)
					{
						GUI.DrawTexture(new Rect(0.5f * screenWidth - (float)261 + (float)(50 * this.ED0nrChb4po), (float)126, (float)16, (float)16), this.m);
						if (59552 - 127729 == -68177)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE78 RID: 48760 RVA: 0x01426F64 File Offset: 0x01425164
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (130276 - 163527 != -33250)
		{
		}
		for (;;)
		{
			if (this.y1bnravPsae)
			{
				if (121975 - 219478 == -97502)
				{
					continue;
				}
				Vector3 position = this.y1bnravPsae.transform.position;
				if (203687 - 274843 == -71155)
				{
					continue;
				}
				if (position.y <= (float)20)
				{
					if (203405 - 305246 == -101840)
					{
						continue;
					}
					GameObject gameObject = GameObject.Find("StartPoint" + Game.getPlayerSlot(PlayerData.UID));
					if (38349 - 56935 != -18586)
					{
						continue;
					}
					if (gameObject)
					{
						if (296728 - 38633 == 258096)
						{
							continue;
						}
						this.y1bnravPsae.transform.position = gameObject.transform.position;
						if (264908 - 422284 == -157375)
						{
							continue;
						}
						this.y1bnravPsae.transform.rotation = gameObject.transform.rotation;
						if (127741 - 598045 == -470303)
						{
							continue;
						}
						this.transform.position = gameObject.transform.position;
						if (121976 - 20907 == 101070)
						{
							continue;
						}
						this.transform.rotation = gameObject.transform.rotation;
						if (266260 - 136745 != 129515)
						{
							continue;
						}
						if (this.F2Inr4UefZp)
						{
							if (164808 - 458408 == -293599)
							{
								continue;
							}
							this.F2Inr4UefZp.hp = 0;
							if (248328 - 169937 == 78392)
							{
								continue;
							}
							this.F2Inr4UefZp.mLastDamageID = 0;
							if (169155 - 5939 == 163217)
							{
								continue;
							}
							this.F2Inr4UefZp.removeAllStatus();
							if (44923 - 269823 == -224899)
							{
								continue;
							}
						}
					}
					CameraEffect cameraEffect = (CameraEffect)this.GetComponent(typeof(CameraEffect));
					if (225825 - 174216 == 51610)
					{
						continue;
					}
					if (cameraEffect)
					{
						if (80373 - 92679 != -12306)
						{
							continue;
						}
						cameraEffect.AddColorRamp("shadowRamp", "none", (float)10, new Vector4((float)0, (float)0, 0.1f, 0.1f));
						if (32499 - 566542 != -534043)
						{
							continue;
						}
					}
					if (this.shadowMirrorFx)
					{
						if (185006 - 211035 != -26029)
						{
							continue;
						}
						this.audio.PlayOneShot(this.shadowMirrorFx);
						if (53363 - 175301 == -121937)
						{
							continue;
						}
					}
				}
			}
			if (Time.time > this.fLNnrUdFu0a)
			{
				if (110451 - 134756 == -24304)
				{
					continue;
				}
				if (this.fLNnrUdFu0a > (float)0)
				{
					if (183109 - 465480 == -282370)
					{
						continue;
					}
					this.fLNnrUdFu0a = (float)0;
					if (133406 - 550847 == -417440)
					{
						continue;
					}
					this.UpdateScore();
					if (174852 - 216642 != -41790)
					{
						continue;
					}
				}
			}
			if (Time.time <= this.IMQnrNNRFLu)
			{
				break;
			}
			if (156574 - 433533 == -276959)
			{
				if (this.IMQnrNNRFLu <= (float)0)
				{
					break;
				}
				if (279151 - 322449 == -43298)
				{
					this.IMQnrNNRFLu = (float)0;
					if (294035 - 435234 == -141199)
					{
						this.OnShadowTowerReady();
						if (19768 - 380281 == -360513)
						{
							this.SendMessage("newGameMessage", "ShadowTower is ready!");
							if (72235 - 521424 == -449189)
							{
								Chat.SubmitChat("none", "ShadowTower is ready!", eChatType.system, eChatMode.system);
								if (285857 - 561534 != -275676)
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

	// Token: 0x0600BE79 RID: 48761 RVA: 0x01427444 File Offset: 0x01425644
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (287712 - 124701 != 163011)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (214937 - 223561 != -8623)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (109674 - 388824 == -279150)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (268993 - 33472 == 235521)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (79401 - 569607 == -490206)
						{
							int num4 = num;
							if (189495 - 560713 == -371218)
							{
								if (num4 == 9861)
								{
									if (215561 - 319536 != -103974)
									{
										if (!RuntimeServices.EqualityOperator(this.G6wnrLOC0h7, null))
										{
											if (106329 - 293215 != -186886)
											{
												continue;
											}
											this.G6wnrLOC0h7[num2 - 1] = Mathf.Clamp(this.G6wnrLOC0h7[num2 - 1] + 1, 0, 99);
											if (295821 - 168502 == 127320)
											{
												continue;
											}
											this.SendMessage("newGameMessage", "Team" + num2 + " score!: " + this.G6wnrLOC0h7[num2 - 1]);
											if (258928 - 208559 != 50369)
											{
												continue;
											}
											this.fLNnrUdFu0a = Time.time + 0.2f;
											if (79051 - 2963 == 76089)
											{
												continue;
											}
										}
										this.IMQnrNNRFLu -= (float)1;
										if (171662 - 283593 == -111931)
										{
											break;
										}
									}
								}
								else if (num4 == 9862)
								{
									if (228858 - 421525 != -192666)
									{
										if (!RuntimeServices.EqualityOperator(this.G6wnrLOC0h7, null))
										{
											if (199233 - 148258 != 50976)
											{
												this.G6wnrLOC0h7[num2 - 1] = Mathf.Clamp(this.G6wnrLOC0h7[num2 - 1] - 3, 0, 99);
												if (229342 - 264105 != -34762)
												{
													this.SendMessage("newGameMessage", "Team" + num2 + " killed themselves! (-3 penalty)");
													if (250935 - 416745 != -165809)
													{
														Chat.SubmitChat("none", "Team" + num2 + " killed themselves! (-3 penalty)", eChatType.system, eChatMode.system);
														if (118898 - 445866 == -326968)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.IMQnrNNRFLu -= (float)1;
											if (175883 - 93667 == 82216)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 9863)
								{
									if (272392 - 480881 != -208488)
									{
										break;
									}
								}
								else if (num4 == -9863)
								{
									if (98149 - 121441 != -23291)
									{
										if (this.IMQnrNNRFLu > Time.time)
										{
											break;
										}
										if (70797 - 239594 == -168797)
										{
											this.OnShadowTower(num2);
											if (194599 - 476050 == -281451)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 9864)
								{
									if (299529 - 78181 != 221349)
									{
										break;
									}
								}
								else if (num4 == -9864)
								{
									if (44677 - 39990 != 4688)
									{
										if (num2 == 1)
										{
											if (98649 - 331691 == -233042)
											{
												this.OnShadowBridge(true);
												if (6611 - 83735 != -77123)
												{
													break;
												}
											}
										}
										else
										{
											this.OnShadowBridge(false);
											if (171304 - 426295 == -254991)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 9865)
								{
									if (273397 - 24817 != 248581)
									{
										break;
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (93202 - 458953 == -365751)
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

	// Token: 0x0600BE7A RID: 48762 RVA: 0x014279A4 File Offset: 0x01425BA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M986_FallenShadow.$StartEvent$47348(this).GetEnumerator();
	}

	// Token: 0x0600BE7B RID: 48763 RVA: 0x014279B4 File Offset: 0x01425BB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (9860 - 577588 != -567728)
		{
		}
		while (this.IMQnrNNRFLu <= Time.time)
		{
			if (14815 - 176415 != -161599)
			{
				CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
				if (53786 - 7361 != 46426)
				{
					if (!characterControl)
					{
						break;
					}
					if (274416 - 543790 != -269373)
					{
						this.OnShadowTower(characterControl.ActorNr);
						if (83535 - 578357 == -494822)
						{
							Game.sendMissionEvent(9863, characterControl.ActorNr);
							if (21762 - 39375 != -17612)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE7C RID: 48764 RVA: 0x01427AC0 File Offset: 0x01425CC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseShadowTower()
	{
		if (18252 - 490176 != -471924)
		{
		}
		for (;;)
		{
			if (this.IMQnrNNRFLu > Time.time)
			{
				if (227537 - 204754 != 22784)
				{
					this.SendMessage("newGameMessage", "ShadowTower Time out");
					if (231711 - 199387 == 32324)
					{
						break;
					}
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
				if (249005 - 453002 == -203997)
				{
					if (!characterControl)
					{
						goto IL_133;
					}
					if (235389 - 592564 == -357174)
					{
						continue;
					}
					if (!(characterControl.actionState == "standby"))
					{
						if (185986 - 439825 != -253838)
						{
							goto IL_133;
						}
						continue;
					}
					IL_77:
					GameObject gameObject = GameObject.Find("ShadowTower");
					if (20725 - 210217 != -189492)
					{
						continue;
					}
					if (!gameObject)
					{
						break;
					}
					if (124459 - 14410 == 110050)
					{
						continue;
					}
					Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
					if (21324 - 519515 != -498191)
					{
						continue;
					}
					Game.mPlayer.SendMessage("activateIcon", 2401);
					if (110191 - 507724 != -397533)
					{
						continue;
					}
					characterControl.RPC_AddStatus("dissolute", 6, 12, 0, characterControl.ActorNr);
					if (84276 - 87495 == -3218)
					{
						continue;
					}
					Chat.SubmitChat(characterControl.Name, characterControl.Name + " is activating ShadowTower", eChatType.system, eChatMode.area);
					if (52696 - 135472 != -82776)
					{
						continue;
					}
					break;
					IL_133:
					if (characterControl.actionState == "run")
					{
						goto IL_77;
					}
					if (11600 - 143751 == -132151)
					{
						if (!(characterControl.actionState == "emotion"))
						{
							break;
						}
						if (112073 - 239783 == -127710)
						{
							goto IL_77;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE7D RID: 48765 RVA: 0x01427D54 File Offset: 0x01425F54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnShadowTower(int nActorID)
	{
		if (254123 - 531781 != -277657)
		{
		}
		for (;;)
		{
			IL_30F:
			this.IMQnrNNRFLu = Time.time + (float)60;
			if (242328 - 468201 == -225873)
			{
				if (this.v0knrEshrKw)
				{
					if (80905 - 452425 == -371519)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.v0knrEshrKw);
					if (23522 - 3349 == 20174)
					{
						continue;
					}
				}
				CameraEffect cameraEffect = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
				if (95313 - 491096 == -395783)
				{
					cameraEffect.AddColorRamp("blackRamp", "burstMask", (float)1, new Vector4((float)0, 0.1f, 0.1f, 0.2f));
					if (197713 - 193403 == 4310)
					{
						if (this.shadowTower_deathFx)
						{
							if (68867 - 101416 != -32549)
							{
								continue;
							}
							this.audio.PlayOneShot(this.shadowTower_deathFx);
							if (117354 - 293498 == -176143)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing shadowTower_deathFx Audio");
							if (101004 - 53567 == 47438)
							{
								continue;
							}
						}
						this.Rf3nrsPqsHM.AddCamereShake(0.6f);
						if (299867 - 108067 == 191800)
						{
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[nActorID];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (227511 - 100213 == 127298)
							{
								if (!gameObject)
								{
									break;
								}
								if (173153 - 276008 == -102855)
								{
									int layerMask = 130816 - (1 << gameObject.layer);
									if (229639 - 221824 != 7816)
									{
										UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(new Vector3((float)0, (float)0, (float)0), (float)120, (float)100, layerMask);
										if (145625 - 50927 != 94699)
										{
											IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
											if (283386 - 412087 != -128700)
											{
												while (enumerator.MoveNext())
												{
													object obj4 = enumerator.Current;
													object obj6;
													object obj5 = obj6 = obj4;
													if (!(obj5 is GameObject))
													{
														obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
													}
													GameObject gameObject2 = (GameObject)obj6;
													if (9216 - 231112 == -221895)
													{
														goto IL_30F;
													}
													CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
													if (240270 - 75160 == 165111)
													{
														goto IL_30F;
													}
													UnityRuntimeServices.Update(enumerator, gameObject2);
													if (94213 - 379715 != -285502)
													{
														goto IL_30F;
													}
													if (characterControl)
													{
														if (9117 - 299789 == -290671)
														{
															goto IL_30F;
														}
														if (characterControl.isMine)
														{
															if (37201 - 89558 != -52357)
															{
																goto IL_30F;
															}
															characterControl.RPC_AddEffectDamage(9863, 999, 0, 0, Vector3.zero, nActorID);
															if (292517 - 38954 == 253564)
															{
																goto IL_30F;
															}
														}
														if (this.shadowTower_death)
														{
															if (46370 - 117485 != -71115)
															{
																goto IL_30F;
															}
															characterControl.createEffect(this.shadowTower_death, gameObject2.transform.position, gameObject2.transform.rotation);
															if (30169 - 416032 != -385863)
															{
																goto IL_30F;
															}
															UnityRuntimeServices.Update(enumerator, gameObject2);
															if (184652 - 266222 != -81570)
															{
																goto IL_30F;
															}
														}
														else
														{
															Debug.LogError("Missing shadowTower_death Effect");
															if (15490 - 3667 != 11823)
															{
																goto IL_30F;
															}
														}
													}
												}
												if (216352 - 25832 == 190520)
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

	// Token: 0x0600BE7E RID: 48766 RVA: 0x0142820C File Offset: 0x0142640C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnShadowTowerReady()
	{
		if (5427 - 142833 != -137405)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("ShadowTower");
			if (103707 - 188115 == -84408)
			{
				if (!gameObject)
				{
					break;
				}
				if (166242 - 110946 == 55296)
				{
					if (!this.shadowTower_ready)
					{
						break;
					}
					if (278619 - 301201 != -22581)
					{
						if (this.v0knrEshrKw != null)
						{
							if (32380 - 593236 != -560855)
							{
								break;
							}
						}
						else
						{
							this.v0knrEshrKw = (GameObject)UnityEngine.Object.Instantiate(this.shadowTower_ready, gameObject.transform.position, gameObject.transform.rotation);
							if (117361 - 271217 != -153855)
							{
								if (this.shadowTower_readyFX)
								{
									if (158829 - 492286 != -333456)
									{
										this.audio.PlayOneShot(this.shadowTower_readyFX);
										if (131552 - 413516 != -281963)
										{
											break;
										}
									}
								}
								else
								{
									Debug.LogError("Missing shadowTower_readyFX Audio");
									if (177627 - 578643 != -401015)
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

	// Token: 0x0600BE7F RID: 48767 RVA: 0x014283AC File Offset: 0x014265AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnShadowBridge(bool isBridge)
	{
		if (193316 - 326314 != -132998)
		{
		}
		while (isBridge != this.VLCnrPdNVcO)
		{
			if (124547 - 288375 == -163828)
			{
				GameObject gameObject = GameObject.Find("ShadowBridge");
				if (59959 - 242983 != -183023)
				{
					if (!gameObject)
					{
						break;
					}
					if (24777 - 275737 != -250959)
					{
						if (this.shadowBridgeFx)
						{
							if (176370 - 385622 == -209251)
							{
								continue;
							}
							this.audio.PlayOneShot(this.shadowBridgeFx);
							if (66207 - 395633 != -329426)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing shadowBridgeFx Audio");
							if (70413 - 591614 == -521200)
							{
								continue;
							}
						}
						if (isBridge)
						{
							if (258280 - 191768 != 66513)
							{
								this.VLCnrPdNVcO = true;
								if (165581 - 234122 == -68541)
								{
									int num = 50;
									if (53609 - 595368 == -541759)
									{
										Vector3 position = gameObject.transform.position;
										if (34814 - 477828 == -443014)
										{
											float num2 = position.y = (float)num;
											if (162026 - 141895 != 20132 && 86996 - 514548 != -427551)
											{
												gameObject.transform.position = position;
												if (99405 - 590546 == -491141)
												{
													if (2843 - 481730 != -478886)
													{
														this.OkPnrS1ocGl = Time.time + (float)30;
														if (48327 - 157584 == -109257)
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
						else
						{
							this.VLCnrPdNVcO = false;
							if (236754 - 26677 == 210077)
							{
								int num3 = -500;
								if (232286 - 118224 == 114062)
								{
									Vector3 position2 = gameObject.transform.position;
									if (98169 - 96354 != 1816)
									{
										position2.y = (float)num3;
										if (151091 - 585139 == -434048)
										{
											if (197082 - 213573 != -16490)
											{
												gameObject.transform.position = position2;
												if (130881 - 404009 == -273128)
												{
													if (190919 - 416162 != -225242)
													{
														this.OkPnrS1ocGl = Time.time + (float)30;
														if (201590 - 206911 != -5320)
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

	// Token: 0x0600BE80 RID: 48768 RVA: 0x01428730 File Offset: 0x01426930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseShadowMirror(int mVar)
	{
		return new M986_FallenShadow.$UseShadowMirror$47352(mVar, this).GetEnumerator();
	}

	// Token: 0x0600BE81 RID: 48769 RVA: 0x01428740 File Offset: 0x01426940
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateScore()
	{
		if (103048 - 58868 != 44181)
		{
		}
		for (;;)
		{
			IL_4D2:
			int num = 0;
			if (181309 - 429492 != -248182)
			{
				int vbZnrMENVqF = 0;
				if (97165 - 273694 != -176528)
				{
					int i = 0;
					if (127551 - 260551 == -133000)
					{
						while (i < 9)
						{
							if (this.G6wnrLOC0h7[i] - this.FfanrwtQnlO[i] > 0)
							{
								if (122054 - 463281 == -341226)
								{
									goto IL_4D2;
								}
								int num2 = this.G6wnrLOC0h7[i] - this.FfanrwtQnlO[i];
								if (223865 - 559741 != -335876)
								{
									goto IL_4D2;
								}
								if (num2 == 0)
								{
									if (136568 - 327592 == -191023)
									{
										goto IL_4D2;
									}
								}
								else if (num2 == 1)
								{
									if (75000 - 289560 != -214560)
									{
										goto IL_4D2;
									}
									Chat.SubmitChat("none", "Team " + (i + 1) + " scored one kill! : " + this.G6wnrLOC0h7[i], eChatType.system, eChatMode.system);
									if (230910 - 310848 != -79938)
									{
										goto IL_4D2;
									}
								}
								else if (num2 == 2)
								{
									if (131479 - 556645 != -425166)
									{
										goto IL_4D2;
									}
									Chat.SubmitChat("none", "Team " + (i + 1) + " scored double kill! : " + this.G6wnrLOC0h7[i], eChatType.system, eChatMode.system);
									if (70599 - 518566 == -447966)
									{
										goto IL_4D2;
									}
								}
								else if (num2 == 3)
								{
									if (259679 - 54545 == 205135)
									{
										goto IL_4D2;
									}
									Chat.SubmitChat("none", "Team " + (i + 1) + " scored triple kill! : " + this.G6wnrLOC0h7[i], eChatType.system, eChatMode.system);
									if (261114 - 443176 != -182062)
									{
										goto IL_4D2;
									}
								}
								else if (num2 == 4)
								{
									if (201526 - 599903 != -398377)
									{
										goto IL_4D2;
									}
									Chat.SubmitChat("none", "Team " + (i + 1) + " scored quadruple kill! : " + this.G6wnrLOC0h7[i], eChatType.system, eChatMode.system);
									if (118081 - 34686 != 83395)
									{
										goto IL_4D2;
									}
								}
								else if (num2 == 5)
								{
									if (236607 - 426783 == -190175)
									{
										goto IL_4D2;
									}
									Chat.SubmitChat("none", "Team " + (i + 1) + " scored monster kill! : " + this.G6wnrLOC0h7[i], eChatType.system, eChatMode.system);
									if (103430 - 406136 != -302706)
									{
										goto IL_4D2;
									}
								}
								else
								{
									Chat.SubmitChat("none", "Team " + (i + 1) + " scored god-like " + (this.G6wnrLOC0h7[i] - this.FfanrwtQnlO[i]).ToString() + " kill! : " + this.G6wnrLOC0h7[i].ToString(), eChatType.system, eChatMode.system);
									if (5168 - 175455 != -170287)
									{
										goto IL_4D2;
									}
								}
							}
							this.FfanrwtQnlO[i] = this.G6wnrLOC0h7[i];
							if (173811 - 510861 != -337050)
							{
								goto IL_4D2;
							}
							if (this.G6wnrLOC0h7[i] > num)
							{
								if (99197 - 184829 == -85631)
								{
									goto IL_4D2;
								}
								num = this.G6wnrLOC0h7[i];
								if (108496 - 132713 == -24216)
								{
									goto IL_4D2;
								}
								vbZnrMENVqF = i + 1;
								if (95523 - 391984 != -296461)
								{
									goto IL_4D2;
								}
							}
							i++;
							if (270963 - 400375 == -129411)
							{
								goto IL_4D2;
							}
						}
						if (91800 - 259745 == -167945)
						{
							this.wuHnrfINNmm = this.VbZnrMENVqF;
							if (171351 - 255872 != -84520)
							{
								this.VbZnrMENVqF = vbZnrMENVqF;
								if (68764 - 248445 == -179681)
								{
									if (this.VbZnrMENVqF == this.wuHnrfINNmm)
									{
										break;
									}
									if (273644 - 443709 != -170064)
									{
										this.replaceWinnerRing();
										if (10507 - 572712 == -562205)
										{
											this.SendMessage("newGameMessage", "Team" + this.VbZnrMENVqF + " is winning: " + this.G6wnrLOC0h7[this.VbZnrMENVqF - 1] + "/39");
											if (47533 - 363429 == -315896)
											{
												Chat.SubmitChat("none", "Team" + this.VbZnrMENVqF + " is winning: " + this.G6wnrLOC0h7[this.VbZnrMENVqF - 1] + "/39", eChatType.system, eChatMode.system);
												if (243049 - 356514 == -113465)
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

	// Token: 0x0600BE82 RID: 48770 RVA: 0x01428D70 File Offset: 0x01426F70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void replaceWinnerRing()
	{
		if (73188 - 157785 != -84597)
		{
		}
		for (;;)
		{
			IL_1C0:
			if (this.wuHnrfINNmm >= 1)
			{
				if (53388 - 414843 == -361454)
				{
					continue;
				}
				if (this.wuHnrfINNmm <= 9)
				{
					if (53070 - 279941 == -226870)
					{
						continue;
					}
					int i = 1;
					if (223908 - 506438 != -282530)
					{
						continue;
					}
					while (i <= 2)
					{
						object obj2;
						object obj = obj2 = Game.getPlayerBySlot(this.wuHnrfINNmm * i);
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (118851 - 203631 == -84779)
						{
							goto IL_1C0;
						}
						if (gameObject)
						{
							if (17218 - 129925 == -112706)
							{
								goto IL_1C0;
							}
							this.removeTeamRing(gameObject);
							if (72403 - 447064 == -374660)
							{
								goto IL_1C0;
							}
							this.createTeamRing(gameObject);
							if (96839 - 102438 != -5599)
							{
								goto IL_1C0;
							}
						}
						i++;
						if (160584 - 478275 == -317690)
						{
							goto IL_1C0;
						}
					}
					if (265610 - 95857 == 169754)
					{
						continue;
					}
				}
			}
			if (this.VbZnrMENVqF < 1)
			{
				break;
			}
			if (205064 - 266615 != -61550)
			{
				if (this.VbZnrMENVqF > 9)
				{
					break;
				}
				if (62722 - 294692 != -231969)
				{
					int j = 1;
					if (62577 - 108556 != -45978)
					{
						while (j <= 2)
						{
							object obj4;
							object obj3 = obj4 = Game.getPlayerBySlot(this.VbZnrMENVqF * j);
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							GameObject gameObject2 = (GameObject)obj4;
							if (113948 - 239612 != -125664)
							{
								goto IL_1C0;
							}
							if (gameObject2)
							{
								if (108796 - 521700 != -412904)
								{
									goto IL_1C0;
								}
								this.removeTeamRing(gameObject2);
								if (73843 - 499679 == -425835)
								{
									goto IL_1C0;
								}
								this.createTeamRing(gameObject2);
								if (189140 - 313588 != -124448)
								{
									goto IL_1C0;
								}
							}
							j++;
							if (183537 - 35740 != 147797)
							{
								goto IL_1C0;
							}
						}
						if (201797 - 455486 == -253689)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE83 RID: 48771 RVA: 0x01429060 File Offset: 0x01427260
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createTeamRing(GameObject nPlayer)
	{
		if (34549 - 88865 != -54315)
		{
		}
		for (;;)
		{
			int num = nPlayer.layer - 7;
			if (193052 - 233921 == -40869)
			{
				if (97954 - 71009 != 26946)
				{
					if (num == this.VbZnrMENVqF)
					{
						if (212453 - 195562 != 16892)
						{
							GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.winnerRing, Vector3.zero, Quaternion.identity);
							if (158358 - 250341 != -91982)
							{
								if (!gameObject)
								{
									break;
								}
								if (178907 - 37972 == 140935)
								{
									gameObject.transform.parent = nPlayer.transform;
									if (109668 - 345364 != -235695)
									{
										gameObject.transform.localPosition = Vector3.zero;
										if (55851 - 508810 != -452958)
										{
											gameObject.name = "WinnerRing";
											if (264054 - 320438 == -56384)
											{
												if (!nPlayer.collider)
												{
													break;
												}
												if (17438 - 268916 == -251478)
												{
													gameObject.transform.localScale = Vector3.one * nPlayer.collider.bounds.size.z;
													if (78549 - 165799 != -87249)
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
					else
					{
						if (num != this.ED0nrChb4po)
						{
							break;
						}
						if (151953 - 581250 == -429297)
						{
							GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.teamRing, Vector3.zero, Quaternion.identity);
							if (97096 - 314104 != -217007)
							{
								if (!gameObject)
								{
									break;
								}
								if (17693 - 314005 != -296311)
								{
									gameObject.transform.parent = nPlayer.transform;
									if (154964 - 157304 != -2339)
									{
										gameObject.transform.localPosition = Vector3.zero;
										if (41040 - 157186 != -116145)
										{
											gameObject.name = "TeamRing";
											if (62060 - 143441 == -81381)
											{
												if (!nPlayer.collider)
												{
													break;
												}
												if (129548 - 565812 == -436264)
												{
													gameObject.transform.localScale = Vector3.one * nPlayer.collider.bounds.size.z;
													if (274073 - 540511 != -266437)
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

	// Token: 0x0600BE84 RID: 48772 RVA: 0x014293BC File Offset: 0x014275BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void removeTeamRing(GameObject nPlayer)
	{
		if (165873 - 259909 != -94036)
		{
		}
		for (;;)
		{
			Transform transform = nPlayer.transform.Find("WinnerRing");
			if (296470 - 104845 == 191625)
			{
				Transform transform2 = nPlayer.transform.Find("TeamRing");
				if (152585 - 357123 != -204537)
				{
					if (transform)
					{
						if (252702 - 571079 == -318376)
						{
							continue;
						}
						UnityEngine.Object.Destroy(transform.gameObject);
						if (227419 - 19568 != 207851)
						{
							continue;
						}
					}
					if (!transform2)
					{
						break;
					}
					if (20994 - 203015 == -182021)
					{
						UnityEngine.Object.Destroy(transform2.gameObject);
						if (220801 - 597602 == -376801)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE85 RID: 48773 RVA: 0x014294E0 File Offset: 0x014276E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (146717 - 180761 != -34043)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (18906 - 588900 == -569994)
			{
				Time.timeScale = 1f;
				if (256875 - 514005 != -257129)
				{
					this.IMQnrNNRFLu = Time.time + (float)60;
					if (153792 - 455454 != -301661)
					{
						this.OkPnrS1ocGl = Time.time + (float)30;
						if (63245 - 196283 != -133037)
						{
							this.Uu5nr7VsJNP = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
							if (31254 - 560871 != -529616)
							{
								Hashtable customOpParameters = new Hashtable();
								if (84000 - 2207 != 81794)
								{
									this.GU9nrgryh1J.OpCustom(52, customOpParameters, true);
									if (15703 - 133362 == -117659)
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

	// Token: 0x0600BE86 RID: 48774 RVA: 0x01429638 File Offset: 0x01427838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (277407 - 119759 != 157649)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (183347 - 423354 != -240006)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (213161 - 334947 != -121785)
				{
					Game.mGameState = eGameState.Setup;
					if (219000 - 78509 != 140492)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BE87 RID: 48775 RVA: 0x014296DC File Offset: 0x014278DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (299495 - 590821 != -291325)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (11840 - 290392 == -278552)
			{
				if (num == PlayerData.UID)
				{
					if (131611 - 411418 != -279806)
					{
						this.SetupActors();
						if (193197 - 383902 == -190705)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (40416 - 232627 != -192210)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BE88 RID: 48776 RVA: 0x014297AC File Offset: 0x014279AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (175718 - 103261 != 72457)
		{
		}
		for (;;)
		{
			IL_132:
			Debug.Log("Creating Actors");
			if (266905 - 540734 == -273829)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (72976 - 482836 == -409860)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (44756 - 130613 == -85857)
						{
							int i = 0;
							if (228948 - 254723 == -25775)
							{
								CharacterControl[] array2 = array;
								if (56026 - 71189 == -15163)
								{
									int length = array2.Length;
									if (81638 - 46263 != 35376)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (229403 - 505006 != -275603)
												{
													goto IL_132;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (51217 - 539660 == -488442)
												{
													goto IL_132;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (102509 - 507876 != -405367)
												{
													goto IL_132;
												}
												this.pW0nr0GOrOG++;
												if (4221 - 359271 == -355049)
												{
													goto IL_132;
												}
											}
											i++;
											if (45940 - 577590 != -531650)
											{
												goto IL_132;
											}
										}
										if (272976 - 188544 != 84433)
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
						if (161746 - 539722 != -377975)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE89 RID: 48777 RVA: 0x014299E8 File Offset: 0x01427BE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (110421 - 23206 != 87215)
		{
		}
		for (;;)
		{
			IL_A8:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (137909 - 589369 != -451459)
			{
				int i = 0;
				if (30698 - 63081 == -32383)
				{
					CharacterControl[] array2 = array;
					if (246723 - 209891 != 36833)
					{
						int length = array2.Length;
						if (59828 - 402951 != -343122)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (108424 - 5061 != 103363)
								{
									goto IL_A8;
								}
								i++;
								if (243958 - 377991 != -134033)
								{
									goto IL_A8;
								}
							}
							if (157362 - 143067 == 14295)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE8A RID: 48778 RVA: 0x01429B18 File Offset: 0x01427D18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (45574 - 59404 != -13829)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (86506 - 264150 == -177644)
			{
				Game.mGameState = eGameState.Ready;
				if (194478 - 227276 == -32798)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (74686 - 147409 == -72723)
					{
						this.ED0nrChb4po = global::Math.div((float)(playerSlot - 1), (float)2) + 1;
						if (151926 - 236011 == -84085)
						{
							if (this.ED0nrChb4po >= 1)
							{
								if (187903 - 16862 == 171042)
								{
									continue;
								}
								if (this.ED0nrChb4po <= 9)
								{
									if (201595 - 481070 != -279475)
									{
										continue;
									}
									GameObject gameObject = null;
									if (182797 - 33860 == 148938)
									{
										continue;
									}
									if (playerSlot >= 1)
									{
										if (128613 - 38527 != 90086)
										{
											continue;
										}
										if (playerSlot <= 18)
										{
											if (3802 - 257970 != -254168)
											{
												continue;
											}
											gameObject = GameObject.Find("StartPoint" + playerSlot);
											if (253249 - 110651 != 142598)
											{
												continue;
											}
										}
									}
									if (!gameObject)
									{
										break;
									}
									if (67656 - 132692 != -65036)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
									if (297660 - 65618 != 232042)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (72721 - 470968 != -398247)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, this.ED0nrChb4po, spawnPos, gameObject.transform.forward);
										if (210139 - 591336 != -381196)
										{
											break;
										}
										continue;
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, this.ED0nrChb4po, gameObject.transform.position, gameObject.transform.forward);
										if (259505 - 525073 != -265568)
										{
											continue;
										}
										break;
									}
								}
							}
							Debug.LogError("Warning Team Number Error:" + this.ED0nrChb4po);
							if (43734 - 279246 != -235511)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE8B RID: 48779 RVA: 0x01429DFC File Offset: 0x01427FFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (251427 - 218867 != 32560)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (32652 - 385543 != -352890)
			{
				Game.mGameState = eGameState.Start;
				if (78450 - 416740 == -338290)
				{
					Game.mStateTime = Time.time;
					if (110638 - 344214 == -233576)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (75986 - 200591 != -124604)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE8C RID: 48780 RVA: 0x01429EC4 File Offset: 0x014280C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600BE8D RID: 48781 RVA: 0x01429EC8 File Offset: 0x014280C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (194966 - 388958 != -193992)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (124757 - 139600 == -14843)
			{
				if (gameObject)
				{
					if (200861 - 253143 != -52281)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (296235 - 228579 == 67656)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (62279 - 312107 != -249827)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BE8E RID: 48782 RVA: 0x01429FC4 File Offset: 0x014281C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (68808 - 407828 != -339020)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (270455 - 241699 != 28757)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (39056 - 320899 == -281843)
				{
					hashtable.Add(43, PlayerData.UID);
					if (90911 - 479561 == -388650)
					{
						hashtable.Add(73, nType);
						if (226796 - 44607 != 182190)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (208435 - 123299 != 85137)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (216548 - 535120 != -318571)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (238948 - 147101 != 91848)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (192167 - 189326 != 2842)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (86532 - 129514 != -42981)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (173951 - 240137 != -66185)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (61380 - 76762 != -15381)
													{
														this.GU9nrgryh1J.OpCustom(63, hashtable, true);
														if (7927 - 128378 == -120451)
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

	// Token: 0x0600BE8F RID: 48783 RVA: 0x0142A2A8 File Offset: 0x014284A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (9072 - 94173 != -85100)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (26845 - 596137 == -569292)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (209522 - 528366 == -318844)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (145241 - 372582 == -227341)
						{
							if (this.pW0nr0GOrOG <= 0)
							{
								break;
							}
							if (181306 - 231108 != -49801)
							{
								this.pW0nr0GOrOG--;
								if (190493 - 304219 != -113725)
								{
									if (this.pW0nr0GOrOG != 0)
									{
										break;
									}
									if (71874 - 563271 != -491396)
									{
										Game.setGameState(eGameState.Ready);
										if (41680 - 424143 != -382462)
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
						if (114246 - 473139 == -358893)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (108623 - 505511 == -396888)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE90 RID: 48784 RVA: 0x0142A438 File Offset: 0x01428638
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x0600BE91 RID: 48785 RVA: 0x0142A43C File Offset: 0x0142863C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x0600BE92 RID: 48786 RVA: 0x0142A440 File Offset: 0x01428640
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (10795 - 133476 != -122680)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (113495 - 514038 == -400543)
			{
				hashtable.Add(71, CID);
				if (288274 - 223164 != 65111)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (242080 - 485037 != -242956)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (216865 - 554235 != -337369)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (209359 - 268324 == -58965)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (83988 - 484582 != -400593)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (129463 - 274022 != -144558)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (19643 - 418913 == -399270)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (260935 - 500295 == -239360)
											{
												this.GU9nrgryh1J.OpCustom(61, hashtable, true);
												if (241035 - 159240 == 81795)
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

	// Token: 0x0600BE93 RID: 48787 RVA: 0x0142A6CC File Offset: 0x014288CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (41745 - 59230 != -17484)
		{
		}
		for (;;)
		{
			IL_F5:
			GameObject gameObject = Game.createPlayer(data);
			if (46562 - 585522 != -538959)
			{
				if (!gameObject)
				{
					break;
				}
				if (95301 - 396213 == -300912)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (228627 - 12054 == 216573)
					{
						playerCameraControl.target = gameObject;
						if (212390 - 423300 == -210910)
						{
							this.y1bnravPsae = gameObject;
							if (201094 - 574871 == -373777)
							{
								this.F2Inr4UefZp = (CharacterControl)this.y1bnravPsae.GetComponent(typeof(CharacterControl));
								if (173234 - 575154 == -401920)
								{
									this.createTeamRing(this.y1bnravPsae);
									if (53030 - 81520 != -28489)
									{
										if (Game.mGameState < eGameState.Start)
										{
											if (95525 - 285364 == -189839)
											{
												this.StartGame();
												if (19500 - 222366 != -202865)
												{
													break;
												}
											}
										}
										else
										{
											this.Rf3nrsPqsHM.target = Game.mPlayer;
											if (139805 - 284283 != -144477)
											{
												this.Rf3nrsPqsHM.enabled = true;
												if (166716 - 372223 != -205506)
												{
													if (Game.mGameState != eGameState.Normal)
													{
														if (202922 - 143969 != 58953)
														{
															continue;
														}
														if (Game.mGameState != eGameState.Hold)
														{
															goto IL_3B5;
														}
														if (272614 - 31590 == 241025)
														{
															continue;
														}
													}
													Game.mGameState = eGameState.Normal;
													if (6218 - 528380 == -522161)
													{
														continue;
													}
													GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
													if (40646 - 201389 == -160742)
													{
														continue;
													}
													if (gameGui)
													{
														if (68570 - 233788 == -165217)
														{
															continue;
														}
														gameGui.enabled = true;
														if (8639 - 93686 == -85046)
														{
															continue;
														}
														gameGui.closeDeadMenu();
														if (35820 - 530207 != -494387)
														{
															continue;
														}
													}
													IL_3B5:
													CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
													if (290950 - 258620 != 32331)
													{
														if (!characterControl)
														{
															break;
														}
														if (158465 - 165906 != -7440)
														{
															if (CharacterData.current == null)
															{
																break;
															}
															if (157298 - 477747 == -320449)
															{
																characterControl.mTimeOutList = new UnityScript.Lang.Array();
																if (16652 - 210973 == -194321)
																{
																	IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(CharacterData.current.cooldown);
																	if (136381 - 500435 != -364053)
																	{
																		while (enumerator.MoveNext())
																		{
																			object obj = enumerator.Current;
																			object obj3;
																			object obj2 = obj3 = obj;
																			if (!(obj2 is timeOutClass))
																			{
																				obj3 = RuntimeServices.Coerce(obj2, typeof(timeOutClass));
																			}
																			timeOutClass timeOutClass = (timeOutClass)obj3;
																			if (155740 - 577123 != -421383)
																			{
																				goto IL_F5;
																			}
																			if (timeOutClass.cTime > Time.time)
																			{
																				if (51283 - 301031 == -249747)
																				{
																					goto IL_F5;
																				}
																				characterControl.mTimeOutList.Add(timeOutClass);
																				if (194056 - 354369 != -160313)
																				{
																					goto IL_F5;
																				}
																				UnityRuntimeServices.Update(enumerator, timeOutClass);
																				if (256556 - 447525 != -190969)
																				{
																					goto IL_F5;
																				}
																			}
																		}
																		if (99308 - 530744 == -431436)
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

	// Token: 0x0600BE94 RID: 48788 RVA: 0x0142AB64 File Offset: 0x01428D64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (74726 - 546605 != -471879)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPeer(data);
			if (65155 - 97758 != -32602)
			{
				if (!gameObject)
				{
					break;
				}
				if (10975 - 573712 != -562736)
				{
					this.createTeamRing(gameObject);
					if (75484 - 387498 != -312013)
					{
						GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
						if (181850 - 351496 != -169645)
						{
							gameGui.ResetTeamBar();
							if (35282 - 548748 == -513466)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE95 RID: 48789 RVA: 0x0142AC54 File Offset: 0x01428E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M986_FallenShadow.$onDeadPlayer$47365(this).GetEnumerator();
	}

	// Token: 0x0600BE96 RID: 48790 RVA: 0x0142AC64 File Offset: 0x01428E64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (97320 - 463811 != -366490)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (214013 - 440308 != -226294)
			{
				this.Rf3nrsPqsHM.target = Game.mPlayer;
				if (182211 - 105570 != 76642)
				{
					this.Rf3nrsPqsHM.enabled = true;
					if (44380 - 211277 != -166896)
					{
						CharacterData.setTimeOut(1, (float)0);
						if (80671 - 353932 != -273260)
						{
							CharacterData.setTimeOut(2, (float)0);
							if (102537 - 385883 == -283346)
							{
								CharacterData.setTimeOut(3, (float)0);
								if (35171 - 430910 != -395738)
								{
									if (Game.mGameState != eGameState.Normal)
									{
										if (220304 - 446767 == -226462)
										{
											continue;
										}
										if (Game.mGameState != eGameState.Hold)
										{
											break;
										}
										if (135473 - 132153 != 3320)
										{
											continue;
										}
									}
									Game.mGameState = eGameState.Normal;
									if (11147 - 410509 != -399361)
									{
										GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
										if (224163 - 404819 == -180656)
										{
											if (!gameGui)
											{
												break;
											}
											if (129632 - 363361 != -233728)
											{
												gameGui.enabled = true;
												if (252378 - 178352 == 74026)
												{
													gameGui.closeDeadMenu();
													if (158924 - 430181 == -271257)
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

	// Token: 0x0600BE97 RID: 48791 RVA: 0x0142AE78 File Offset: 0x01429078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (112659 - 109700 != 2960)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (110932 - 95403 == 15529)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (40978 - 114679 != -73700)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (193889 - 132090 == 61799)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BE98 RID: 48792 RVA: 0x0142AF3C File Offset: 0x0142913C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600BE99 RID: 48793 RVA: 0x0142AF68 File Offset: 0x01429168
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (97057 - 80455 != 16603)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (55753 - 544235 != -488481)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (18717 - 440642 != -421924)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (135135 - 437615 == -302480)
					{
						Hashtable hashtable = new Hashtable();
						if (89341 - 434895 != -345553)
						{
							hashtable.Add(43, PlayerData.UID);
							if (2558 - 393539 == -390981)
							{
								hashtable.Add(71, nCID);
								if (117630 - 38980 != 78651)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (99966 - 123513 == -23547)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (63537 - 29562 != 33976)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (177980 - 70735 == 107245)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (52683 - 432339 == -379656)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (108182 - 502306 == -394124)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (299687 - 89058 == 210629)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (91833 - 257262 != -165428)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (219475 - 72076 == 147399)
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

	// Token: 0x0600BE9A RID: 48794 RVA: 0x0142B288 File Offset: 0x01429488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M986_FallenShadow.$onChangePlayer$47374(data, this).GetEnumerator();
	}

	// Token: 0x0600BE9B RID: 48795 RVA: 0x0142B298 File Offset: 0x01429498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RespawnPlayer(int nCID)
	{
		return new M986_FallenShadow.$RespawnPlayer$47381(nCID, this).GetEnumerator();
	}

	// Token: 0x0600BE9C RID: 48796 RVA: 0x0142B2A8 File Offset: 0x014294A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M986_FallenShadow.$onGameComplete$47394(data, this).GetEnumerator();
	}

	// Token: 0x0600BE9D RID: 48797 RVA: 0x0142B2B8 File Offset: 0x014294B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M986_FallenShadow.$ReturnToTown$47404(this).GetEnumerator();
	}

	// Token: 0x0600BE9E RID: 48798 RVA: 0x0142B2C8 File Offset: 0x014294C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M986_FallenShadow.$ReturnToGuild$47409(this).GetEnumerator();
	}

	// Token: 0x0600BE9F RID: 48799 RVA: 0x0142B2D8 File Offset: 0x014294D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M986_FallenShadow.$ReturnToCamp$47413(this).GetEnumerator();
	}

	// Token: 0x0600BEA0 RID: 48800 RVA: 0x0142B2E8 File Offset: 0x014294E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (257605 - 573139 != -315533)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (297936 - 421317 != -123380)
			{
				Hashtable hashtable = new Hashtable();
				if (171260 - 312860 != -141599)
				{
					hashtable.Add(43, PlayerData.UID);
					if (183872 - 106387 != 77486)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (80271 - 536359 != -456087)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BEA1 RID: 48801 RVA: 0x0142B3C0 File Offset: 0x014295C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600BEA2 RID: 48802 RVA: 0x0142B3D4 File Offset: 0x014295D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (161839 - 420364 != -258525)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (165927 - 499638 != -333710)
			{
				Hashtable hashtable = new Hashtable();
				if (33264 - 99726 == -66462)
				{
					if (Game.mNextGameCode == 30)
					{
						if (185332 - 354177 != -168845)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (261063 - 271001 != -9938)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (9218 - 550065 == -540846)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (4168 - 548741 != -544573)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (75965 - 127104 != -51139)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (15559 - 513266 != -497707)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (248389 - 542632 == -294242)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (35271 - 242277 != -207006)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (200444 - 297239 != -96795)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (145847 - 326357 != -180510)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (165712 - 204513 == -38800)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (141155 - 414249 == -273093)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (158437 - 226213 != -67776)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (142212 - 240648 == -98435)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (94040 - 596295 == -502254)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (145525 - 489405 != -343880)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (256022 - 492944 == -236921)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (52446 - 113260 != -60814)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (71333 - 60499 == 10835)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (44590 - 529933 != -485343)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (216893 - 585187 == -368293)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (61371 - 87436 != -26065)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (134226 - 415339 != -281113)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (115968 - 153966 != -37998)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (212094 - 285737 == -73642)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (205801 - 596000 != -390199)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (36635 - 152926 != -116291)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (296986 - 587236 != -290250)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (91636 - 517033 != -425396)
					{
						this.GU9nrgryh1J.OpCustom(42, hashtable, true);
						if (188953 - 295610 != -106656)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BEA3 RID: 48803 RVA: 0x0142B988 File Offset: 0x01429B88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600BEA4 RID: 48804 RVA: 0x0142B998 File Offset: 0x01429B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600BEA5 RID: 48805 RVA: 0x0142B99C File Offset: 0x01429B9C
	internal static bool EPy4nvtGbtRpS1CRF0kE()
	{
		return true;
	}

	// Token: 0x0600BEA6 RID: 48806 RVA: 0x0142B9A0 File Offset: 0x01429BA0
	internal static bool a8Q1XqtGu3fhZwstMx0T()
	{
		return false;
	}

	// Token: 0x0400A2A4 RID: 41636
	private LitePeer GU9nrgryh1J;

	// Token: 0x0400A2A5 RID: 41637
	private GameObject y1bnravPsae;

	// Token: 0x0400A2A6 RID: 41638
	private CharacterControl F2Inr4UefZp;

	// Token: 0x0400A2A7 RID: 41639
	private PlayerCameraControl Rf3nrsPqsHM;

	// Token: 0x0400A2A8 RID: 41640
	private float svRnrHpdIRY;

	// Token: 0x0400A2A9 RID: 41641
	private Texture Uu5nr7VsJNP;

	// Token: 0x0400A2AA RID: 41642
	public Texture m;

	// Token: 0x0400A2AB RID: 41643
	private int JQInrZy8GI8;

	// Token: 0x0400A2AC RID: 41644
	private int ED0nrChb4po;

	// Token: 0x0400A2AD RID: 41645
	private int VbZnrMENVqF;

	// Token: 0x0400A2AE RID: 41646
	private int wuHnrfINNmm;

	// Token: 0x0400A2AF RID: 41647
	private int[] G6wnrLOC0h7;

	// Token: 0x0400A2B0 RID: 41648
	private int[] FfanrwtQnlO;

	// Token: 0x0400A2B1 RID: 41649
	private float fLNnrUdFu0a;

	// Token: 0x0400A2B2 RID: 41650
	public GameObject shadowTower_death;

	// Token: 0x0400A2B3 RID: 41651
	public AudioClip shadowTower_deathFx;

	// Token: 0x0400A2B4 RID: 41652
	private float IMQnrNNRFLu;

	// Token: 0x0400A2B5 RID: 41653
	public GameObject shadowTower_ready;

	// Token: 0x0400A2B6 RID: 41654
	public AudioClip shadowTower_readyFX;

	// Token: 0x0400A2B7 RID: 41655
	private GameObject v0knrEshrKw;

	// Token: 0x0400A2B8 RID: 41656
	public AudioClip shadowBridgeFx;

	// Token: 0x0400A2B9 RID: 41657
	private bool VLCnrPdNVcO;

	// Token: 0x0400A2BA RID: 41658
	private float OkPnrS1ocGl;

	// Token: 0x0400A2BB RID: 41659
	public AudioClip shadowMirrorFx;

	// Token: 0x0400A2BC RID: 41660
	private float lG1nrBYOFxN;

	// Token: 0x0400A2BD RID: 41661
	public GameObject winnerRing;

	// Token: 0x0400A2BE RID: 41662
	public GameObject teamRing;

	// Token: 0x0400A2BF RID: 41663
	private int pW0nr0GOrOG;

	// Token: 0x02001FD4 RID: 8148
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$47348 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BEA7 RID: 48807 RVA: 0x0142B9A4 File Offset: 0x01429BA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$47348(M986_FallenShadow self_)
		{
			if (137491 - 178923 != -41431)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (279941 - 16068 != 263874)
				{
					base..ctor();
					if (208537 - 184640 == 23897)
					{
						this.$self_$47351 = self_;
						if (117475 - 172937 == -55462)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BEA8 RID: 48808 RVA: 0x0142BA3C File Offset: 0x01429C3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M986_FallenShadow.$StartEvent$47348.$(this.$self_$47351);
		}

		// Token: 0x0600BEA9 RID: 48809 RVA: 0x0142BA4C File Offset: 0x01429C4C
		internal static bool dG0CFBtGIQLdLIkLJqkM()
		{
			return true;
		}

		// Token: 0x0600BEAA RID: 48810 RVA: 0x0142BA50 File Offset: 0x01429C50
		internal static bool QGqxpLtGBwLJ69HS8tKP()
		{
			return false;
		}

		// Token: 0x0400A2C0 RID: 41664
		internal M986_FallenShadow $self_$47351;

		// Token: 0x02001FD5 RID: 8149
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BEAB RID: 48811 RVA: 0x0142BA54 File Offset: 0x01429C54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M986_FallenShadow self_)
			{
				if (95939 - 293826 != -197887)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (7216 - 387003 == -379787)
					{
						base..ctor();
						if (151432 - 460903 != -309470)
						{
							this.$self_$47350 = self_;
							if (257640 - 367387 == -109747)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BEAC RID: 48812 RVA: 0x0142BAEC File Offset: 0x01429CEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (61560 - 21908 != 39653)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_394;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (280197 - 552523 != -272325)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$self_$47350.Rf3nrsPqsHM.StartCoroutine_Auto(this.$self_$47350.Rf3nrsPqsHM.slerpToObject("EventCamera2", (float)3));
							if (296775 - 457174 != -160398)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (14297 - 28572 != -14275)
							{
								continue;
							}
							goto IL_45;
						}
						else
						{
							this.$self_$47350.SendMessage("fadeOut");
							if (212119 - 81726 != 130393)
							{
								continue;
							}
							goto IL_D5;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (71689 - 358044 != -286355)
							{
								continue;
							}
							goto IL_19B;
						}
						else
						{
							if (Game.mPlayer)
							{
								if (50984 - 266507 == -215522)
								{
									continue;
								}
								this.$self_$47350.Rf3nrsPqsHM.alignToObject(Game.mPlayer.name);
								if (10906 - 103790 != -92884)
								{
									continue;
								}
							}
							this.$mGameGui$47349 = (GameGui)this.$self_$47350.GetComponent(typeof(GameGui));
							if (253388 - 385061 != -131673)
							{
								continue;
							}
							this.$mGameGui$47349.enabled = true;
							if (274449 - 582942 != -308493)
							{
								continue;
							}
							this.$self_$47350.Rf3nrsPqsHM.enabled = true;
							if (8318 - 299265 == -290946)
							{
								continue;
							}
							this.$self_$47350.SendMessage("fadeIn");
							if (53888 - 534021 != -480132)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (30384 - 499012 != -468628)
							{
								continue;
							}
							goto IL_305;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (52343 - 224513 != -172170)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (78578 - 136722 != -58144)
							{
								continue;
							}
							this.YieldDefault(1);
							if (294308 - 501830 != -207521)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					default:
						if (46522 - 193238 != -146716)
						{
							continue;
						}
						break;
					}
					this.$self_$47350.Rf3nrsPqsHM.alignToObject("EventCamera1");
					if (179765 - 90192 == 89573)
					{
						this.$self_$47350.SendMessage("fadeIn");
						if (68590 - 342012 == -273422)
						{
							goto IL_210;
						}
					}
				}
				IL_45:
				goto IL_394;
				IL_D5:
				return this.Yield(4, new WaitForSeconds(0.6f));
				Block_10:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_19B:
				goto IL_394;
				Block_15:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_210:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_17:
				Block_18:
				IL_305:
				IL_394:
				return false;
			}

			// Token: 0x0600BEAD RID: 48813 RVA: 0x0142BEA0 File Offset: 0x0142A0A0
			internal static bool orZStVtGeiAINq2wTl8A()
			{
				return true;
			}

			// Token: 0x0600BEAE RID: 48814 RVA: 0x0142BEA4 File Offset: 0x0142A0A4
			internal static bool gS1n0CtGrlmXT0hgo08y()
			{
				return false;
			}

			// Token: 0x0400A2C1 RID: 41665
			internal GameGui $mGameGui$47349;

			// Token: 0x0400A2C2 RID: 41666
			internal M986_FallenShadow $self_$47350;
		}
	}

	// Token: 0x02001FD6 RID: 8150
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseShadowMirror$47352 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BEAF RID: 48815 RVA: 0x0142BEA8 File Offset: 0x0142A0A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseShadowMirror$47352(int mVar, M986_FallenShadow self_)
		{
			if (78682 - 227317 != -148635)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (128142 - 32776 == 95366)
				{
					base..ctor();
					if (240510 - 245116 == -4606)
					{
						this.$mVar$47363 = mVar;
						if (156644 - 400518 == -243874)
						{
							this.$self_$47364 = self_;
							if (146608 - 383216 != -236607)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BEB0 RID: 48816 RVA: 0x0142BF64 File Offset: 0x0142A164
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M986_FallenShadow.$UseShadowMirror$47352.$(this.$mVar$47363, this.$self_$47364);
		}

		// Token: 0x0600BEB1 RID: 48817 RVA: 0x0142BF78 File Offset: 0x0142A178
		internal static bool Pc4AsftGjqlXQRLdvJrp()
		{
			return true;
		}

		// Token: 0x0600BEB2 RID: 48818 RVA: 0x0142BF7C File Offset: 0x0142A17C
		internal static bool iLkvyvtGhoKuuVi6BXci()
		{
			return false;
		}

		// Token: 0x0400A2C3 RID: 41667
		internal int $mVar$47363;

		// Token: 0x0400A2C4 RID: 41668
		internal M986_FallenShadow $self_$47364;

		// Token: 0x02001FD7 RID: 8151
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BEB3 RID: 48819 RVA: 0x0142BF80 File Offset: 0x0142A180
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int mVar, M986_FallenShadow self_)
			{
				if (62652 - 459688 != -397035)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (275961 - 251607 != 24355)
					{
						base..ctor();
						if (211928 - 436454 == -224526)
						{
							this.$mVar$47361 = mVar;
							if (32519 - 248673 != -216153)
							{
								this.$self_$47362 = self_;
								if (96893 - 171668 != -74774)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BEB4 RID: 48820 RVA: 0x0142C03C File Offset: 0x0142A23C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (295271 - 43497 != 251775)
				{
				}
				for (;;)
				{
					IL_3EA:
					switch (this._state)
					{
					case 0:
						goto IL_31C;
					case 1:
						goto IL_88B;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (967 - 168287 != -167319)
							{
								goto Block_62;
							}
							continue;
						}
						else
						{
							this.$mCameraEffect$47355 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
							if (167488 - 51396 == 116093)
							{
								continue;
							}
							if (this.$mCameraEffect$47355)
							{
								if (267139 - 34650 == 232490)
								{
									continue;
								}
								this.$mCameraEffect$47355.AddColorRamp("shadowRamp", "none", (float)10, new Vector4(0.1f, 0.1f, 0.1f, (float)0));
								if (144659 - 124006 == 20654)
								{
									continue;
								}
							}
							if (!this.$self_$47362.shadowMirrorFx)
							{
								goto IL_4E0;
							}
							if (279280 - 71101 == 208180)
							{
								continue;
							}
							this.$self_$47362.audio.PlayOneShot(this.$self_$47362.shadowMirrorFx);
							if (182152 - 586433 != -404280)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (70687 - 510272 != -439584)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							this.$warpList$47356 = Damage.FindAreaTarget(Game.mPlayer.transform.position, (float)20, (float)12, 1 << Game.mPlayer.layer);
							if (137573 - 467998 != -330425)
							{
								continue;
							}
							this.$$iterator$10998$47360 = UnityRuntimeServices.GetEnumerator(this.$warpList$47356);
							if (268495 - 439003 != -170508)
							{
								continue;
							}
							while (this.$$iterator$10998$47360.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10998$47360.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$warpObject$47357 = (GameObject)obj2;
								if (92747 - 161886 == -69138)
								{
									goto IL_3EA;
								}
								this.$warpChar$47358 = (CharacterControl)this.$warpObject$47357.GetComponent(typeof(CharacterControl));
								if (152119 - 539571 != -387452)
								{
									goto IL_3EA;
								}
								UnityRuntimeServices.Update(this.$$iterator$10998$47360, this.$warpObject$47357);
								if (99448 - 382383 == -282934)
								{
									goto IL_3EA;
								}
								if (!(this.$warpObject$47357 == Game.mPlayer))
								{
									if (268863 - 203973 != 64890)
									{
										goto IL_3EA;
									}
									if (!this.$warpChar$47358.isMine)
									{
										continue;
									}
									if (26106 - 304877 != -278771)
									{
										goto IL_3EA;
									}
									if (!this.$warpChar$47358.recieveMovement)
									{
										continue;
									}
									if (16859 - 109911 != -93052)
									{
										goto IL_3EA;
									}
								}
								this.$mWarpPos$47359 = global::Math.getRandomSpawnPos(this.$mWarpPoint$47354.transform.position, 2);
								if (274279 - 567381 == -293101)
								{
									goto IL_3EA;
								}
								if (this.$mWarpPos$47359 == Vector3.zero)
								{
									if (25840 - 353117 != -327277)
									{
										goto IL_3EA;
									}
									this.$mWarpPos$47359 = this.$mWarpPoint$47354.transform.position;
									if (140065 - 16557 != 123508)
									{
										goto IL_3EA;
									}
								}
								this.$warpObject$47357.transform.position = this.$mWarpPos$47359;
								if (146846 - 86219 != 60627)
								{
									goto IL_3EA;
								}
								UnityRuntimeServices.Update(this.$$iterator$10998$47360, this.$warpObject$47357);
								if (151340 - 309849 != -158509)
								{
									goto IL_3EA;
								}
								this.$warpObject$47357.transform.rotation = Quaternion.LookRotation(this.$mWarpPoint$47354.transform.forward);
								if (251499 - 265014 != -13515)
								{
									goto IL_3EA;
								}
								UnityRuntimeServices.Update(this.$$iterator$10998$47360, this.$warpObject$47357);
								if (24775 - 85023 == -60247)
								{
									goto IL_3EA;
								}
								if (this.$warpChar$47358)
								{
									if (138079 - 156833 != -18754)
									{
										goto IL_3EA;
									}
									this.$warpChar$47358.PositionEvent();
									if (273043 - 5407 == 267637)
									{
										goto IL_3EA;
									}
								}
							}
							if (243011 - 521206 != -278194)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (17009 - 125542 != -108533)
							{
								continue;
							}
							goto IL_64A;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (296749 - 557126 != -260377)
							{
								continue;
							}
						}
						break;
					default:
						if (94608 - 42720 != 51889)
						{
							goto IL_31C;
						}
						continue;
					}
					IL_102:
					this.$self_$47362.lG1nrBYOFxN = Time.time + 0.5f;
					if (155037 - 147815 != 7223)
					{
						goto IL_723;
					}
					continue;
					IL_31C:
					if (Game.mGameState != eGameState.Normal)
					{
						if (60413 - 449115 != -388701)
						{
							goto Block_26;
						}
						continue;
					}
					else if (!Game.mPlayer)
					{
						if (247061 - 328626 != -81564)
						{
							goto Block_58;
						}
						continue;
					}
					else if (this.$self_$47362.lG1nrBYOFxN > Time.time)
					{
						if (99817 - 67736 != 32081)
						{
							continue;
						}
						this.$self_$47362.SendMessage("newGameMessage", "ShadowMirror Timeout!");
						if (98868 - 249885 == -151016)
						{
							continue;
						}
					}
					else
					{
						this.$mChar$47353 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
						if (24005 - 414982 == -390976)
						{
							continue;
						}
						if (!this.$mChar$47353)
						{
							goto IL_102;
						}
						if (227707 - 18831 == 208877)
						{
							continue;
						}
						if (this.$mChar$47353.actionState != "standby")
						{
							if (86686 - 564508 != -477822)
							{
								continue;
							}
							if (this.$mChar$47353.actionState != "run")
							{
								if (130218 - 525936 != -395718)
								{
									continue;
								}
								this.$self_$47362.SendMessage("newGameMessage", "Cannot use ShadowMirror during action!");
								if (183288 - 18194 != 165094)
								{
									continue;
								}
								goto IL_102;
							}
						}
						this.$mWarpPoint$47354 = GameObject.Find("WarpPoint" + this.$mVar$47361);
						if (287297 - 205983 != 81314)
						{
							continue;
						}
						if (this.$mWarpPoint$47354)
						{
							if (194601 - 65442 == 129160)
							{
								continue;
							}
							Game.mGameState = eGameState.Hold;
							if (234456 - 49542 != 184915)
							{
								break;
							}
							continue;
						}
						else
						{
							Debug.LogError("Error: Missing WarpPoint" + this.$mVar$47361);
							if (117164 - 190374 != -73209)
							{
								goto IL_102;
							}
							continue;
						}
					}
					IL_723:
					this.YieldDefault(1);
					if (218974 - 219570 == -596)
					{
						goto IL_88B;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_14:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_26:
				goto IL_88B;
				IL_4E0:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_37:
				goto IL_88B;
				Block_42:
				goto IL_4E0;
				IL_64A:
				Block_58:
				Block_62:
				IL_88B:
				return false;
			}

			// Token: 0x0600BEB5 RID: 48821 RVA: 0x0142C8E8 File Offset: 0x0142AAE8
			internal static bool YK8HRUtGsT7A8is2ZZT2()
			{
				return true;
			}

			// Token: 0x0600BEB6 RID: 48822 RVA: 0x0142C8EC File Offset: 0x0142AAEC
			internal static bool af7kTZtG9vv5Z4454o3g()
			{
				return false;
			}

			// Token: 0x0400A2C5 RID: 41669
			internal CharacterControl $mChar$47353;

			// Token: 0x0400A2C6 RID: 41670
			internal GameObject $mWarpPoint$47354;

			// Token: 0x0400A2C7 RID: 41671
			internal CameraEffect $mCameraEffect$47355;

			// Token: 0x0400A2C8 RID: 41672
			internal UnityScript.Lang.Array $warpList$47356;

			// Token: 0x0400A2C9 RID: 41673
			internal GameObject $warpObject$47357;

			// Token: 0x0400A2CA RID: 41674
			internal CharacterControl $warpChar$47358;

			// Token: 0x0400A2CB RID: 41675
			internal Vector3 $mWarpPos$47359;

			// Token: 0x0400A2CC RID: 41676
			internal IEnumerator $$iterator$10998$47360;

			// Token: 0x0400A2CD RID: 41677
			internal int $mVar$47361;

			// Token: 0x0400A2CE RID: 41678
			internal M986_FallenShadow $self_$47362;
		}
	}

	// Token: 0x02001FD8 RID: 8152
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$47365 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BEB7 RID: 48823 RVA: 0x0142C8F0 File Offset: 0x0142AAF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$47365(M986_FallenShadow self_)
		{
			if (200602 - 99435 != 101167)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (159438 - 190412 != -30973)
				{
					base..ctor();
					if (262242 - 135763 != 126480)
					{
						this.$self_$47373 = self_;
						if (253994 - 133834 == 120160)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BEB8 RID: 48824 RVA: 0x0142C988 File Offset: 0x0142AB88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M986_FallenShadow.$onDeadPlayer$47365.$(this.$self_$47373);
		}

		// Token: 0x0600BEB9 RID: 48825 RVA: 0x0142C998 File Offset: 0x0142AB98
		internal static bool wt2S82tG1qwwDC6Y98AA()
		{
			return true;
		}

		// Token: 0x0600BEBA RID: 48826 RVA: 0x0142C99C File Offset: 0x0142AB9C
		internal static bool jXdCBUtG4WZEd6UhQcTm()
		{
			return false;
		}

		// Token: 0x0400A2CF RID: 41679
		internal M986_FallenShadow $self_$47373;

		// Token: 0x02001FD9 RID: 8153
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BEBB RID: 48827 RVA: 0x0142C9A0 File Offset: 0x0142ABA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M986_FallenShadow self_)
			{
				if (120835 - 415953 != -295118)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (107826 - 518245 != -410418)
					{
						base..ctor();
						if (103812 - 66442 == 37370)
						{
							this.$self_$47372 = self_;
							if (197730 - 153546 != 44185)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BEBC RID: 48828 RVA: 0x0142CA38 File Offset: 0x0142AC38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (131043 - 431354 != -300310)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5CE;
					case 2:
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_395;
						}
						if (274512 - 123109 != 151403)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (177714 - 291226 != -113511)
							{
								goto IL_395;
							}
							continue;
						}
						IL_17B:
						this.YieldDefault(1);
						if (267678 - 36324 != 231354)
						{
							continue;
						}
						goto IL_5CE;
						IL_395:
						Game.mGameState = eGameState.Hold;
						if (62726 - 345645 == -282918)
						{
							continue;
						}
						CharacterData.setTimeOut(1, (float)6);
						if (290113 - 573345 != -283232)
						{
							continue;
						}
						CharacterData.setTimeOut(2, (float)6);
						if (12303 - 292598 != -280295)
						{
							continue;
						}
						CharacterData.setTimeOut(3, (float)6);
						if (198840 - 224300 != -25460)
						{
							continue;
						}
						this.$mStoryGui$47369 = (StoryGui)this.$self_$47372.GetComponent(typeof(StoryGui));
						if (204949 - 253322 != -48373)
						{
							continue;
						}
						if (this.$mStoryGui$47369)
						{
							if (72210 - 328174 != -255964)
							{
								continue;
							}
							this.$mStoryGui$47369.close();
							if (212405 - 292373 == -79967)
							{
								continue;
							}
						}
						this.$mChangeGui$47370 = (ChangeGui)this.$self_$47372.GetComponent(typeof(ChangeGui));
						if (291377 - 172415 != 118962)
						{
							continue;
						}
						if (this.$mChangeGui$47370)
						{
							if (188452 - 285991 != -97539)
							{
								continue;
							}
							this.$mChangeGui$47370.close();
							if (84565 - 244107 != -159542)
							{
								continue;
							}
						}
						this.$mGameGui$47371 = (GameGui)this.$self_$47372.GetComponent(typeof(GameGui));
						if (271384 - 531546 == -260161)
						{
							continue;
						}
						if (!this.$mGameGui$47371)
						{
							goto IL_17B;
						}
						if (55714 - 257897 != -202183)
						{
							continue;
						}
						if (!this.$mGameGui$47371.enabled)
						{
							if (1508 - 285434 != -283926)
							{
								continue;
							}
							this.$mGameGui$47371.enabled = true;
							if (290324 - 439509 == -149184)
							{
								continue;
							}
						}
						this.$mGameGui$47371.openDeadMenu();
						if (143930 - 291965 != -148035)
						{
							continue;
						}
						goto IL_17B;
					default:
						if (20756 - 545712 == -524955)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (79342 - 530331 != -450988)
					{
						if (!Game.mPlayer)
						{
							break;
						}
						if (154968 - 232479 == -77511)
						{
							this.$mPlayerChar$47366 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (249415 - 436193 == -186778)
							{
								if (!this.$mPlayerChar$47366)
								{
									break;
								}
								if (222915 - 465024 != -242108)
								{
									if (this.$mPlayerChar$47366.mLastDamageID != 0)
									{
										if (99876 - 108531 == -8655)
										{
											object obj2;
											object obj = obj2 = PhotonClient.ActorNrList[this.$mPlayerChar$47366.mLastDamageID];
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											this.$mKiller$47367 = (GameObject)obj2;
											if (94062 - 502888 == -408826)
											{
												if (!this.$mKiller$47367)
												{
													break;
												}
												if (188235 - 493215 == -304980)
												{
													this.$mKillerChar$47368 = (CharacterControl)this.$mKiller$47367.GetComponent(typeof(CharacterControl));
													if (165256 - 96648 == 68608)
													{
														if (!this.$mKillerChar$47368)
														{
															break;
														}
														if (72053 - 352699 != -280645)
														{
															if (this.$mKillerChar$47368.mOriginalLayer != this.$mPlayerChar$47366.mOriginalLayer)
															{
																if (164235 - 195409 != -31173)
																{
																	Game.sendMissionEvent(9861, this.$mKillerChar$47368.mOriginalLayer - 7);
																	if (185293 - 145005 != 40289)
																	{
																		break;
																	}
																}
															}
															else
															{
																Game.sendMissionEvent(9862, this.$mKillerChar$47368.mOriginalLayer - 7);
																if (207781 - 524052 == -316271)
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
									else
									{
										Game.sendMissionEvent(9862, this.$mPlayerChar$47366.mOriginalLayer - 7);
										if (29410 - 511416 != -482005)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_5CE:
				return false;
			}

			// Token: 0x0600BEBD RID: 48829 RVA: 0x0142D028 File Offset: 0x0142B228
			internal static bool qRnoF7tGzmWEeXExSt2u()
			{
				return true;
			}

			// Token: 0x0600BEBE RID: 48830 RVA: 0x0142D02C File Offset: 0x0142B22C
			internal static bool sjib8ctHaH1F7RicN8do()
			{
				return false;
			}

			// Token: 0x0400A2D0 RID: 41680
			internal CharacterControl $mPlayerChar$47366;

			// Token: 0x0400A2D1 RID: 41681
			internal GameObject $mKiller$47367;

			// Token: 0x0400A2D2 RID: 41682
			internal CharacterControl $mKillerChar$47368;

			// Token: 0x0400A2D3 RID: 41683
			internal StoryGui $mStoryGui$47369;

			// Token: 0x0400A2D4 RID: 41684
			internal ChangeGui $mChangeGui$47370;

			// Token: 0x0400A2D5 RID: 41685
			internal GameGui $mGameGui$47371;

			// Token: 0x0400A2D6 RID: 41686
			internal M986_FallenShadow $self_$47372;
		}
	}

	// Token: 0x02001FDA RID: 8154
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$47374 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BEBF RID: 48831 RVA: 0x0142D030 File Offset: 0x0142B230
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$47374(Hashtable data, M986_FallenShadow self_)
		{
			if (21680 - 554899 != -533218)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (82683 - 198055 == -115372)
				{
					base..ctor();
					if (184077 - 411962 == -227885)
					{
						this.$data$47379 = data;
						if (47780 - 54125 == -6345)
						{
							this.$self_$47380 = self_;
							if (61119 - 121537 == -60418)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BEC0 RID: 48832 RVA: 0x0142D0EC File Offset: 0x0142B2EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M986_FallenShadow.$onChangePlayer$47374.$(this.$data$47379, this.$self_$47380);
		}

		// Token: 0x0600BEC1 RID: 48833 RVA: 0x0142D100 File Offset: 0x0142B300
		internal static bool B7KtGItH5rmVvtGuaoX5()
		{
			return true;
		}

		// Token: 0x0600BEC2 RID: 48834 RVA: 0x0142D104 File Offset: 0x0142B304
		internal static bool ndGLqktHpLFuXf8q2N3Z()
		{
			return false;
		}

		// Token: 0x0400A2D7 RID: 41687
		internal Hashtable $data$47379;

		// Token: 0x0400A2D8 RID: 41688
		internal M986_FallenShadow $self_$47380;

		// Token: 0x02001FDB RID: 8155
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BEC3 RID: 48835 RVA: 0x0142D108 File Offset: 0x0142B308
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M986_FallenShadow self_)
			{
				if (297997 - 89394 != 208604)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (120973 - 473597 != -352623)
					{
						base..ctor();
						if (40406 - 366248 == -325842)
						{
							this.$data$47377 = data;
							if (251422 - 80932 == 170490)
							{
								this.$self_$47378 = self_;
								if (179914 - 38626 == 141288)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BEC4 RID: 48836 RVA: 0x0142D1C4 File Offset: 0x0142B3C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (5274 - 83755 != -78480)
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
							if (242677 - 352383 == -109705)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (124335 - 23149 != 101186)
							{
								continue;
							}
							this.$mGameGui$47376 = (GameGui)this.$self_$47378.GetComponent(typeof(GameGui));
							if (119629 - 464506 == -344876)
							{
								continue;
							}
							this.$mGameGui$47376.enabled = true;
							if (86404 - 312767 != -226363)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (294414 - 244696 != 49718)
						{
							continue;
						}
						goto IL_205;
					default:
						if (236630 - 483851 != -247221)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (78471 - 558793 != -480321)
					{
						this.$self_$47378.SendMessage("onCreatePlayer", this.$data$47377);
						if (56909 - 451464 == -394555)
						{
							this.$mChangeGui$47375 = (ChangeGui)this.$self_$47378.GetComponent(typeof(ChangeGui));
							if (154767 - 124596 != 30172)
							{
								if (!this.$mChangeGui$47375.enabled)
								{
									break;
								}
								if (164910 - 309829 != -144918)
								{
									this.$mChangeGui$47375.close();
									if (135229 - 130686 == 4543)
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

			// Token: 0x0600BEC5 RID: 48837 RVA: 0x0142D3E8 File Offset: 0x0142B5E8
			internal static bool AfJnRstHVoXtAdCFRuIE()
			{
				return true;
			}

			// Token: 0x0600BEC6 RID: 48838 RVA: 0x0142D3EC File Offset: 0x0142B5EC
			internal static bool YFoJHXtHtaVFGPVK8lI9()
			{
				return false;
			}

			// Token: 0x0400A2D9 RID: 41689
			internal ChangeGui $mChangeGui$47375;

			// Token: 0x0400A2DA RID: 41690
			internal GameGui $mGameGui$47376;

			// Token: 0x0400A2DB RID: 41691
			internal Hashtable $data$47377;

			// Token: 0x0400A2DC RID: 41692
			internal M986_FallenShadow $self_$47378;
		}
	}

	// Token: 0x02001FDC RID: 8156
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RespawnPlayer$47381 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BEC7 RID: 48839 RVA: 0x0142D3F0 File Offset: 0x0142B5F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RespawnPlayer$47381(int nCID, M986_FallenShadow self_)
		{
			if (62185 - 306880 != -244695)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (160696 - 131371 != 29326)
				{
					base..ctor();
					if (188381 - 104942 == 83439)
					{
						this.$nCID$47392 = nCID;
						if (46155 - 304802 != -258646)
						{
							this.$self_$47393 = self_;
							if (10708 - 135014 == -124306)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BEC8 RID: 48840 RVA: 0x0142D4AC File Offset: 0x0142B6AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M986_FallenShadow.$RespawnPlayer$47381.$(this.$nCID$47392, this.$self_$47393);
		}

		// Token: 0x0600BEC9 RID: 48841 RVA: 0x0142D4C0 File Offset: 0x0142B6C0
		internal static bool keap8HtHN1ovwSeA7Wow()
		{
			return true;
		}

		// Token: 0x0600BECA RID: 48842 RVA: 0x0142D4C4 File Offset: 0x0142B6C4
		internal static bool NLSFMqtHYtrjuBWsSFdC()
		{
			return false;
		}

		// Token: 0x0400A2DD RID: 41693
		internal int $nCID$47392;

		// Token: 0x0400A2DE RID: 41694
		internal M986_FallenShadow $self_$47393;

		// Token: 0x02001FDD RID: 8157
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BECB RID: 48843 RVA: 0x0142D4C8 File Offset: 0x0142B6C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nCID, M986_FallenShadow self_)
			{
				if (227887 - 450565 != -222678)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (34321 - 252539 != -218217)
					{
						base..ctor();
						if (34492 - 178146 != -143653)
						{
							this.$nCID$47390 = nCID;
							if (250377 - 416802 != -166424)
							{
								this.$self_$47391 = self_;
								if (21122 - 585832 == -564710)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BECC RID: 48844 RVA: 0x0142D584 File Offset: 0x0142B784
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (220706 - 96464 != 124243)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5C5;
					case 2:
						this.$mPlayerCameraControl$47383 = (PlayerCameraControl)this.$self_$47391.GetComponent(typeof(PlayerCameraControl));
						if (82404 - 165368 == -82963)
						{
							continue;
						}
						this.$mPlayerCameraControl$47383.target = null;
						if (28395 - 497630 != -469235)
						{
							continue;
						}
						this.$slot$47384 = Game.getPlayerSlot(PlayerData.UID);
						if (96915 - 342720 != -245805)
						{
							continue;
						}
						this.$startPoint$47385 = GameObject.Find("StartPoint" + this.$slot$47384);
						if (227870 - 32388 != 195482)
						{
							continue;
						}
						this.$self_$47391.SendMessage("fadeIn");
						if (44030 - 263370 == -219339)
						{
							continue;
						}
						if (this.$startPoint$47385)
						{
							if (135305 - 457305 != -322000)
							{
								continue;
							}
							this.$nTeam$47386 = Mathf.CeilToInt((float)this.$slot$47384 * 0.5f);
							if (68831 - 542479 == -473647)
							{
								continue;
							}
							this.$nPos$47387 = this.$startPoint$47385.transform.position;
							if (270308 - 147685 != 122623)
							{
								continue;
							}
							this.$nDir$47388 = this.$startPoint$47385.transform.forward;
							if (59047 - 361552 == -302504)
							{
								continue;
							}
							this.$data$47389 = new Hashtable();
							if (292837 - 496461 != -203624)
							{
								continue;
							}
							this.$data$47389.Add(43, PlayerData.UID);
							if (140037 - 350724 == -210686)
							{
								continue;
							}
							this.$data$47389.Add(71, this.$nCID$47390);
							if (122674 - 531265 != -408591)
							{
								continue;
							}
							this.$data$47389.Add(75, PhotonClient.cInt16(this.$nTeam$47386));
							if (56013 - 117247 == -61233)
							{
								continue;
							}
							this.$data$47389.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47387.x * (float)50)));
							if (283529 - 441157 != -157628)
							{
								continue;
							}
							this.$data$47389.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47387.y * (float)50)));
							if (64625 - 168953 != -104328)
							{
								continue;
							}
							this.$data$47389.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47387.z * (float)50)));
							if (129021 - 279283 == -150261)
							{
								continue;
							}
							this.$data$47389.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47388.x * (float)200)));
							if (14292 - 401438 != -387146)
							{
								continue;
							}
							this.$data$47389.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47388.y * (float)200)));
							if (138192 - 551605 != -413413)
							{
								continue;
							}
							this.$data$47389.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47388.z * (float)200)));
							if (121502 - 279954 == -158451)
							{
								continue;
							}
							PhotonClient.Connection.OpCustom(65, this.$data$47389, true);
							if (93120 - 218163 == -125042)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (57306 - 474459 != -417153)
						{
							continue;
						}
						goto IL_5C5;
					default:
						if (14563 - 249 == 14315)
						{
							continue;
						}
						break;
					}
					Debug.Log("Respawn Player");
					if (144353 - 63992 != 80362)
					{
						this.$self_$47391.SendMessage("fadeOut");
						if (62332 - 142671 == -80339)
						{
							this.$mGameGui$47382 = (GameGui)this.$self_$47391.GetComponent(typeof(GameGui));
							if (73911 - 335167 != -261255)
							{
								if (!this.$mGameGui$47382)
								{
									break;
								}
								if (63008 - 361391 != -298382)
								{
									this.$mGameGui$47382.close();
									if (39130 - 131190 != -92059)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_2BE:
				return this.Yield(2, new WaitForSeconds((float)1));
				goto IL_2BE;
				IL_5C5:
				return false;
			}

			// Token: 0x0600BECD RID: 48845 RVA: 0x0142DB68 File Offset: 0x0142BD68
			internal static bool ocmlrYtHcOwB0rcl01FQ()
			{
				return true;
			}

			// Token: 0x0600BECE RID: 48846 RVA: 0x0142DB6C File Offset: 0x0142BD6C
			internal static bool wi9JHLtHU3my5WXlRaqm()
			{
				return false;
			}

			// Token: 0x0400A2DF RID: 41695
			internal GameGui $mGameGui$47382;

			// Token: 0x0400A2E0 RID: 41696
			internal PlayerCameraControl $mPlayerCameraControl$47383;

			// Token: 0x0400A2E1 RID: 41697
			internal int $slot$47384;

			// Token: 0x0400A2E2 RID: 41698
			internal GameObject $startPoint$47385;

			// Token: 0x0400A2E3 RID: 41699
			internal int $nTeam$47386;

			// Token: 0x0400A2E4 RID: 41700
			internal Vector3 $nPos$47387;

			// Token: 0x0400A2E5 RID: 41701
			internal Vector3 $nDir$47388;

			// Token: 0x0400A2E6 RID: 41702
			internal Hashtable $data$47389;

			// Token: 0x0400A2E7 RID: 41703
			internal int $nCID$47390;

			// Token: 0x0400A2E8 RID: 41704
			internal M986_FallenShadow $self_$47391;
		}
	}

	// Token: 0x02001FDE RID: 8158
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$47394 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BECF RID: 48847 RVA: 0x0142DB70 File Offset: 0x0142BD70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$47394(Hashtable data, M986_FallenShadow self_)
		{
			if (226101 - 322134 != -96032)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (254821 - 369627 != -114805)
				{
					base..ctor();
					if (181867 - 503344 == -321477)
					{
						this.$data$47402 = data;
						if (63926 - 79567 == -15641)
						{
							this.$self_$47403 = self_;
							if (279746 - 448918 == -169172)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BED0 RID: 48848 RVA: 0x0142DC2C File Offset: 0x0142BE2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M986_FallenShadow.$onGameComplete$47394.$(this.$data$47402, this.$self_$47403);
		}

		// Token: 0x0600BED1 RID: 48849 RVA: 0x0142DC40 File Offset: 0x0142BE40
		internal static bool KKXUKctHTY4f05tjWW63()
		{
			return true;
		}

		// Token: 0x0600BED2 RID: 48850 RVA: 0x0142DC44 File Offset: 0x0142BE44
		internal static bool oeZpXRtH3luU3H2qSN9e()
		{
			return false;
		}

		// Token: 0x0400A2E9 RID: 41705
		internal Hashtable $data$47402;

		// Token: 0x0400A2EA RID: 41706
		internal M986_FallenShadow $self_$47403;

		// Token: 0x02001FDF RID: 8159
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BED3 RID: 48851 RVA: 0x0142DC48 File Offset: 0x0142BE48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M986_FallenShadow self_)
			{
				if (111105 - 478664 != -367558)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (110787 - 289983 != -179195)
					{
						base..ctor();
						if (16542 - 71336 != -54793)
						{
							this.$data$47400 = data;
							if (216150 - 206399 == 9751)
							{
								this.$self_$47401 = self_;
								if (286014 - 510442 != -224427)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BED4 RID: 48852 RVA: 0x0142DD04 File Offset: 0x0142BF04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (273901 - 83652 != 190250)
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
						this.$mCompleteGui$47396 = (CompleteGui)this.$self_$47401.GetComponent(typeof(CompleteGui));
						if (56340 - 357762 != -301422)
						{
							continue;
						}
						this.$mCompleteGui$47396.Init();
						if (201298 - 18040 != 183258)
						{
							continue;
						}
						this.$mCompleteGui$47396.readData(this.$data$47400);
						if (37115 - 317506 != -280391)
						{
							continue;
						}
						if (this.$result$47395 == 1)
						{
							if (155067 - 460050 == -304982)
							{
								continue;
							}
							this.$mCompleteGui$47396.displayResult(eCompleteType.Success);
							if (145154 - 243307 != -98153)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$47396.displayResult(eCompleteType.Failed);
							if (130389 - 595972 != -465583)
							{
								continue;
							}
						}
						this.$mGameGui$47397 = (GameGui)this.$self_$47401.GetComponent(typeof(GameGui));
						if (167240 - 451734 != -284494)
						{
							continue;
						}
						this.$mStoryGui$47398 = (StoryGui)this.$self_$47401.GetComponent(typeof(StoryGui));
						if (287523 - 469465 == -181941)
						{
							continue;
						}
						this.$mChangeGui$47399 = (ChangeGui)this.$self_$47401.GetComponent(typeof(ChangeGui));
						if (177190 - 430699 != -253509)
						{
							continue;
						}
						if (this.$mGameGui$47397)
						{
							if (294045 - 567986 == -273940)
							{
								continue;
							}
							this.$mGameGui$47397.close();
							if (261789 - 291547 == -29757)
							{
								continue;
							}
						}
						if (this.$mStoryGui$47398)
						{
							if (39984 - 514544 == -474559)
							{
								continue;
							}
							this.$mStoryGui$47398.close();
							if (207296 - 241676 != -34380)
							{
								continue;
							}
						}
						if (this.$mChangeGui$47399)
						{
							if (242529 - 213418 != 29111)
							{
								continue;
							}
							this.$mChangeGui$47399.disable();
							if (43669 - 150722 != -107053)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (194327 - 366442 != -172114)
						{
							goto Block_23;
						}
						continue;
					default:
						if (295448 - 452656 == -157207)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$47400[31]);
					if (251148 - 461922 != -210773)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (298474 - 402033 != -103558)
							{
								goto Block_5;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (56735 - 209981 == -153246)
							{
								this.$result$47395 = RuntimeServices.UnboxInt32(this.$data$47400[31]);
								if (56923 - 189099 == -132176)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_5:
				Block_23:
				IL_3DB:
				return false;
			}

			// Token: 0x0600BED5 RID: 48853 RVA: 0x0142E100 File Offset: 0x0142C300
			internal static bool ps7bnwtHX22iqUlpWY9U()
			{
				return true;
			}

			// Token: 0x0600BED6 RID: 48854 RVA: 0x0142E104 File Offset: 0x0142C304
			internal static bool YeUDoLtHQTq6Uos3kq3r()
			{
				return false;
			}

			// Token: 0x0400A2EB RID: 41707
			internal int $result$47395;

			// Token: 0x0400A2EC RID: 41708
			internal CompleteGui $mCompleteGui$47396;

			// Token: 0x0400A2ED RID: 41709
			internal GameGui $mGameGui$47397;

			// Token: 0x0400A2EE RID: 41710
			internal StoryGui $mStoryGui$47398;

			// Token: 0x0400A2EF RID: 41711
			internal ChangeGui $mChangeGui$47399;

			// Token: 0x0400A2F0 RID: 41712
			internal Hashtable $data$47400;

			// Token: 0x0400A2F1 RID: 41713
			internal M986_FallenShadow $self_$47401;
		}
	}

	// Token: 0x02001FE0 RID: 8160
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$47404 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BED7 RID: 48855 RVA: 0x0142E108 File Offset: 0x0142C308
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$47404(M986_FallenShadow self_)
		{
			if (161978 - 563854 != -401875)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (287744 - 440090 != -152345)
				{
					base..ctor();
					if (4423 - 378478 == -374055)
					{
						this.$self_$47408 = self_;
						if (38290 - 39930 != -1639)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BED8 RID: 48856 RVA: 0x0142E1A0 File Offset: 0x0142C3A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M986_FallenShadow.$ReturnToTown$47404.$(this.$self_$47408);
		}

		// Token: 0x0600BED9 RID: 48857 RVA: 0x0142E1B0 File Offset: 0x0142C3B0
		internal static bool DidIbftHkvpoBBtLwjMq()
		{
			return true;
		}

		// Token: 0x0600BEDA RID: 48858 RVA: 0x0142E1B4 File Offset: 0x0142C3B4
		internal static bool VBFd7EtHGBbGfUOG47fY()
		{
			return false;
		}

		// Token: 0x0400A2F2 RID: 41714
		internal M986_FallenShadow $self_$47408;

		// Token: 0x02001FE1 RID: 8161
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BEDB RID: 48859 RVA: 0x0142E1B8 File Offset: 0x0142C3B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M986_FallenShadow self_)
			{
				if (227485 - 210920 != 16565)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (107312 - 226449 != -119136)
					{
						base..ctor();
						if (122726 - 389808 == -267082)
						{
							this.$self_$47407 = self_;
							if (167610 - 129962 != 37649)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BEDC RID: 48860 RVA: 0x0142E250 File Offset: 0x0142C450
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (83114 - 481977 != -398862)
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
						this.$self_$47407.LeaveGame();
						if (243040 - 403860 != -160820)
						{
							continue;
						}
						this.YieldDefault(1);
						if (149327 - 352286 != -202959)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (251523 - 575483 == -323959)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (222786 - 281680 != -58893)
					{
						Game.mStateTime = Time.time;
						if (6013 - 207652 == -201639)
						{
							this.$$switch$8871$47405 = PlayerData.SaveGuild;
							if (135069 - 289793 != -154723)
							{
								if (this.$$switch$8871$47405 == 1)
								{
									if (189634 - 452381 != -262747)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (171601 - 384247 != -212646)
									{
										continue;
									}
								}
								else if (this.$$switch$8871$47405 == 2)
								{
									if (203921 - 160938 == 42984)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (69148 - 336633 == -267484)
									{
										continue;
									}
								}
								else if (this.$$switch$8871$47405 == 3)
								{
									if (259631 - 545002 != -285371)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (126823 - 515046 == -388222)
									{
										continue;
									}
								}
								else if (this.$$switch$8871$47405 == 4)
								{
									if (291416 - 218549 == 72868)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (183531 - 5830 != 177701)
									{
										continue;
									}
								}
								else if (this.$$switch$8871$47405 == 5)
								{
									if (249061 - 378184 != -129123)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (13857 - 368236 == -354378)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (281735 - 228417 != 53318)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (7913 - 392376 == -384462)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (193575 - 390856 == -197280)
									{
										continue;
									}
								}
								this.$mGameGui$47406 = (GameGui)this.$self_$47407.GetComponent(typeof(GameGui));
								if (112261 - 305171 != -192909)
								{
									if (this.$mGameGui$47406)
									{
										if (118637 - 234534 == -115896)
										{
											continue;
										}
										this.$mGameGui$47406.close();
										if (288396 - 272193 == 16204)
										{
											continue;
										}
									}
									this.$self_$47407.SendMessage("fadeOut");
									if (214282 - 328087 == -113805)
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

			// Token: 0x0600BEDD RID: 48861 RVA: 0x0142E61C File Offset: 0x0142C81C
			internal static bool W0syb0tHHD6lrtVZxbLg()
			{
				return true;
			}

			// Token: 0x0600BEDE RID: 48862 RVA: 0x0142E620 File Offset: 0x0142C820
			internal static bool N4CSRstHW90Qf8julpNS()
			{
				return false;
			}

			// Token: 0x0400A2F3 RID: 41715
			internal int $$switch$8871$47405;

			// Token: 0x0400A2F4 RID: 41716
			internal GameGui $mGameGui$47406;

			// Token: 0x0400A2F5 RID: 41717
			internal M986_FallenShadow $self_$47407;
		}
	}

	// Token: 0x02001FE2 RID: 8162
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$47409 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BEDF RID: 48863 RVA: 0x0142E624 File Offset: 0x0142C824
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$47409(M986_FallenShadow self_)
		{
			if (138701 - 290672 != -151970)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (213577 - 73191 != 140387)
				{
					base..ctor();
					if (115549 - 492858 != -377308)
					{
						this.$self_$47412 = self_;
						if (210331 - 205 != 210127)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BEE0 RID: 48864 RVA: 0x0142E6BC File Offset: 0x0142C8BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M986_FallenShadow.$ReturnToGuild$47409.$(this.$self_$47412);
		}

		// Token: 0x0600BEE1 RID: 48865 RVA: 0x0142E6CC File Offset: 0x0142C8CC
		internal static bool FXqtvrtHAxRLFF1bEKyy()
		{
			return true;
		}

		// Token: 0x0600BEE2 RID: 48866 RVA: 0x0142E6D0 File Offset: 0x0142C8D0
		internal static bool aLTOHvtHl9QJVhC9n0MD()
		{
			return false;
		}

		// Token: 0x0400A2F6 RID: 41718
		internal M986_FallenShadow $self_$47412;

		// Token: 0x02001FE3 RID: 8163
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BEE3 RID: 48867 RVA: 0x0142E6D4 File Offset: 0x0142C8D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M986_FallenShadow self_)
			{
				if (259249 - 336845 != -77595)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265020 - 566023 != -301002)
					{
						base..ctor();
						if (82083 - 341261 == -259178)
						{
							this.$self_$47411 = self_;
							if (154748 - 370333 != -215584)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BEE4 RID: 48868 RVA: 0x0142E76C File Offset: 0x0142C96C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (89429 - 432945 != -343515)
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
						this.$self_$47411.LeaveGame();
						if (283675 - 547057 != -263382)
						{
							continue;
						}
						this.YieldDefault(1);
						if (99419 - 93755 != 5665)
						{
							goto Block_7;
						}
						continue;
					default:
						if (78734 - 331853 != -253119)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (102565 - 250894 == -148329)
					{
						Game.mStateTime = Time.time;
						if (50059 - 191693 != -141633)
						{
							Game.mNextGameCode = 31;
							if (51017 - 444127 != -393109)
							{
								this.$mGameGui$47410 = (GameGui)this.$self_$47411.GetComponent(typeof(GameGui));
								if (286437 - 357106 == -70669)
								{
									if (this.$mGameGui$47410)
									{
										if (253281 - 167859 != 85422)
										{
											continue;
										}
										this.$mGameGui$47410.close();
										if (220541 - 276213 == -55671)
										{
											continue;
										}
									}
									this.$self_$47411.SendMessage("fadeOut");
									if (20953 - 145228 == -124275)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_7:
				IL_1BD:
				return false;
			}

			// Token: 0x0600BEE5 RID: 48869 RVA: 0x0142E948 File Offset: 0x0142CB48
			internal static bool a9UlCXtHyc7FHQQKgJA7()
			{
				return true;
			}

			// Token: 0x0600BEE6 RID: 48870 RVA: 0x0142E94C File Offset: 0x0142CB4C
			internal static bool Jyk1ShtHSuOg4KgFmhEt()
			{
				return false;
			}

			// Token: 0x0400A2F7 RID: 41719
			internal GameGui $mGameGui$47410;

			// Token: 0x0400A2F8 RID: 41720
			internal M986_FallenShadow $self_$47411;
		}
	}

	// Token: 0x02001FE4 RID: 8164
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$47413 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BEE7 RID: 48871 RVA: 0x0142E950 File Offset: 0x0142CB50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$47413(M986_FallenShadow self_)
		{
			if (243276 - 343191 != -99914)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (170374 - 363780 == -193406)
				{
					base..ctor();
					if (244387 - 202053 != 42335)
					{
						this.$self_$47417 = self_;
						if (81703 - 483591 != -401887)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BEE8 RID: 48872 RVA: 0x0142E9E8 File Offset: 0x0142CBE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M986_FallenShadow.$ReturnToCamp$47413.$(this.$self_$47417);
		}

		// Token: 0x0600BEE9 RID: 48873 RVA: 0x0142E9F8 File Offset: 0x0142CBF8
		internal static bool IZdATAtHoNrHOUC14idA()
		{
			return true;
		}

		// Token: 0x0600BEEA RID: 48874 RVA: 0x0142E9FC File Offset: 0x0142CBFC
		internal static bool SfrDXUtHEPWkItVSuHjc()
		{
			return false;
		}

		// Token: 0x0400A2F9 RID: 41721
		internal M986_FallenShadow $self_$47417;

		// Token: 0x02001FE5 RID: 8165
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BEEB RID: 48875 RVA: 0x0142EA00 File Offset: 0x0142CC00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M986_FallenShadow self_)
			{
				if (39611 - 279853 != -240241)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (200940 - 529708 != -328767)
					{
						base..ctor();
						if (219210 - 488944 == -269734)
						{
							this.$self_$47416 = self_;
							if (220309 - 290162 != -69852)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BEEC RID: 48876 RVA: 0x0142EA98 File Offset: 0x0142CC98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (189803 - 264758 != -74954)
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
						this.$self_$47416.LeaveGame();
						if (72421 - 179418 == -106996)
						{
							continue;
						}
						this.YieldDefault(1);
						if (250919 - 337179 != -86260)
						{
							continue;
						}
						goto IL_363;
					default:
						if (257621 - 452830 == -195208)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (100565 - 141918 != -41352)
					{
						Game.mStateTime = Time.time;
						if (218648 - 247898 != -29249)
						{
							this.$$switch$8873$47414 = PlayerData.SaveGuild;
							if (142455 - 242066 != -99610)
							{
								if (this.$$switch$8873$47414 == 1)
								{
									if (267310 - 531592 == -264281)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (118893 - 206037 != -87144)
									{
										continue;
									}
								}
								else if (this.$$switch$8873$47414 == 2)
								{
									if (294654 - 136150 == 158505)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (105472 - 78141 == 27332)
									{
										continue;
									}
								}
								else if (this.$$switch$8873$47414 == 3)
								{
									if (33490 - 154923 != -121433)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (122670 - 500904 != -378234)
									{
										continue;
									}
								}
								else if (this.$$switch$8873$47414 == 4)
								{
									if (292302 - 596488 == -304185)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (237518 - 165933 != 71585)
									{
										continue;
									}
								}
								else if (this.$$switch$8873$47414 == 5)
								{
									if (268506 - 214265 != 54241)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (188390 - 163725 == 24666)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (125305 - 521979 == -396673)
									{
										continue;
									}
								}
								this.$mGameGui$47415 = (GameGui)this.$self_$47416.GetComponent(typeof(GameGui));
								if (216341 - 431411 != -215069)
								{
									if (this.$mGameGui$47415)
									{
										if (239585 - 342147 != -102562)
										{
											continue;
										}
										this.$mGameGui$47415.close();
										if (273665 - 428652 != -154987)
										{
											continue;
										}
									}
									this.$self_$47416.SendMessage("fadeOut");
									if (6805 - 498971 == -492166)
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

			// Token: 0x0600BEED RID: 48877 RVA: 0x0142EE1C File Offset: 0x0142D01C
			internal static bool FAqLmDtH2uq8iiu9u5ux()
			{
				return true;
			}

			// Token: 0x0600BEEE RID: 48878 RVA: 0x0142EE20 File Offset: 0x0142D020
			internal static bool aPrJwNtH8T4Isp492IPT()
			{
				return false;
			}

			// Token: 0x0400A2FA RID: 41722
			internal int $$switch$8873$47414;

			// Token: 0x0400A2FB RID: 41723
			internal GameGui $mGameGui$47415;

			// Token: 0x0400A2FC RID: 41724
			internal M986_FallenShadow $self_$47416;
		}
	}
}
