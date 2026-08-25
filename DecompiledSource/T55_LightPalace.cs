using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02002075 RID: 8309
[Serializable]
public class T55_LightPalace : MonoBehaviour
{
	// Token: 0x0600C277 RID: 49783 RVA: 0x01469DDC File Offset: 0x01467FDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T55_LightPalace()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600C278 RID: 49784 RVA: 0x01469DEC File Offset: 0x01467FEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (283556 - 257952 != 25604)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (243370 - 303864 != -60493)
			{
				Game.mStateTime = Time.time;
				if (168694 - 96414 == 72280)
				{
					if (Chat.Initialized)
					{
						if (184635 - 331792 != -147157)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (192897 - 174256 != 18641)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (93159 - 117637 == -24477)
						{
							continue;
						}
					}
					this.WSNnTdDZLK1 = (Texture)Resources.Load("GameGui/Title/stage_palace", typeof(Texture));
					if (34148 - 386941 == -352793)
					{
						if (this.WSNnTdDZLK1)
						{
							break;
						}
						if (241403 - 486745 != -245341)
						{
							Debug.LogError("Cannot find start title");
							if (93623 - 282370 == -188747)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C279 RID: 49785 RVA: 0x01469F5C File Offset: 0x0146815C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (38368 - 321861 != -283493)
		{
		}
		for (;;)
		{
			Time.timeScale = 1f;
			if (271481 - 100518 != 170964)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (209650 - 10586 != 199065)
				{
					if (PhotonClient.IsInitialized())
					{
						if (130374 - 549676 != -419301)
						{
							Game.mLastGameCode = Game.mGameCode;
							if (149870 - 51350 == 98520)
							{
								Game.mGameCode = 55;
								if (64090 - 198683 == -134593)
								{
									Game.mGameType = 3;
									if (165625 - 142742 != 22884)
									{
										Game.mGameTime = Time.time;
										if (196642 - 302440 != -105797)
										{
											Game.mGameScore = 0;
											if (17828 - 452281 == -434453)
											{
												Game.mGameMana = 0;
												if (27727 - 404651 != -376923)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (128060 - 118146 == 9914)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (253656 - 336745 == -83089)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (235486 - 414697 == -179211)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (287350 - 399815 != -112464)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (213379 - 543467 != -330087)
																	{
																		this.K3VnTb722bJ = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (228939 - 522109 == -293170)
																		{
																			this.I0wnT3yrBPR = PhotonClient.Connection;
																			if (279790 - 470376 != -190585)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (246652 - 122608 != 124045)
																				{
																					this.LoadTown();
																					if (181312 - 316736 != -135423)
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
						if (154755 - 518578 != -363822)
						{
							this.enabled = false;
							if (266828 - 42169 != 224660)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C27A RID: 49786 RVA: 0x0146A28C File Offset: 0x0146848C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (223911 - 117839 != 106072)
		{
		}
		for (;;)
		{
			if (this.I0wnT3yrBPR == null)
			{
				if (224271 - 342042 != -117770)
				{
					break;
				}
			}
			else
			{
				float t = Time.time - Game.mStateTime;
				if (69246 - 308277 == -239031)
				{
					eGameState mGameState = Game.mGameState;
					if (246808 - 189191 == 57617)
					{
						if (mGameState != eGameState.Start)
						{
							if (133361 - 156255 != -22894)
							{
								continue;
							}
							if (mGameState == eGameState.Normal)
							{
								if (136421 - 259730 != -123309)
								{
									continue;
								}
							}
							else
							{
								if (mGameState != eGameState.Ended)
								{
									break;
								}
								if (30533 - 545750 == -515216)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, t);
								if (174937 - 597183 != -422245)
								{
									break;
								}
								continue;
							}
						}
						if (Game.music != 0)
						{
							if (83341 - 296040 == -212698)
							{
								continue;
							}
							if (!this.audio.isPlaying)
							{
								if (110511 - 543909 != -433398)
								{
									continue;
								}
								this.audio.Play();
								if (192378 - 352113 != -159735)
								{
									continue;
								}
							}
						}
						if (this.audio.volume < 0.1f * (float)Game.music)
						{
							if (101415 - 449384 == -347969)
							{
								this.audio.volume = this.audio.volume + Time.deltaTime;
								if (158377 - 313337 == -154960)
								{
									break;
								}
							}
						}
						else
						{
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (151237 - 128844 == 22393)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C27B RID: 49787 RVA: 0x0146A4F4 File Offset: 0x014686F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (28391 - 81340 != -52948)
		{
		}
		for (;;)
		{
			if (!this.WSNnTdDZLK1)
			{
				if (262645 - 96992 != 165654)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Start)
			{
				if (154565 - 371558 == -216993)
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
				if (10717 - 378442 == -367725)
				{
					if (Time.time - Game.mStateTime >= (float)3)
					{
						break;
					}
					if (92349 - 256445 != -164095)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (173676 - 422820 != -249143)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (225622 - 578560 == -352938)
							{
								GUI.depth = 1;
								if (263986 - 229299 != 34688)
								{
									float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4(0.7f, 0.8f, (float)1, 0.4f));
									if (276219 - 106621 != 169599)
									{
										Color color = GUI.color;
										if (219582 - 584127 == -364545)
										{
											color.a = smoothRatioOverTime;
											if (64055 - 321771 != -257715)
											{
												if (51940 - 195101 == -143161)
												{
													Color color2 = GUI.color = color;
													if (246489 - 249282 == -2793)
													{
														if (212164 - 499961 == -287797)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)256, (float)416, (float)512, (float)128), this.WSNnTdDZLK1);
															if (153599 - 204107 != -50507)
															{
																float a = 1f;
																if (26189 - 15189 != 11001)
																{
																	Color color3 = GUI.color;
																	if (62185 - 552749 == -490564)
																	{
																		float num2 = color3.a = a;
																		if (14091 - 441320 != -427228)
																		{
																			if (72265 - 4903 == 67362)
																			{
																				GUI.color = color3;
																				if (171811 - 588633 == -416822)
																				{
																					if (120044 - 46209 != 73836)
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

	// Token: 0x0600C27C RID: 49788 RVA: 0x0146A874 File Offset: 0x01468A74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator LightPalaceStartEvent()
	{
		return new T55_LightPalace.$LightPalaceStartEvent$47879(this).GetEnumerator();
	}

	// Token: 0x0600C27D RID: 49789 RVA: 0x0146A884 File Offset: 0x01468A84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTown()
	{
		if (66121 - 592647 != -526526)
		{
		}
		for (;;)
		{
			Debug.Log("Loading Town ");
			if (11000 - 196092 == -185092)
			{
				Hashtable customOpParameters = new Hashtable();
				if (286283 - 534512 != -248228)
				{
					this.I0wnT3yrBPR.OpCustom(43, customOpParameters, true);
					if (204333 - 18066 == 186267)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C27E RID: 49790 RVA: 0x0146A92C File Offset: 0x01468B2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadTown(Hashtable data)
	{
		if (67658 - 92227 != -24568)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadTown ");
			if (23977 - 481459 != -457481)
			{
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (117746 - 522277 == -404530)
					{
						continue;
					}
					Chat.SubmitChat("none", "You have joined " + data[31], eChatType.system, eChatMode.system);
					if (96763 - 541826 == -445062)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (97229 - 342265 != -245036)
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
					if (88940 - 506460 == -417519)
					{
						continue;
					}
				}
				this.StartCoroutine_Auto(this.LightPalaceStartEvent());
				if (250688 - 422824 != -172135)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600C27F RID: 49791 RVA: 0x0146AA9C File Offset: 0x01468C9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, Vector3 pos, Vector3 dir)
	{
		if (82965 - 517036 != -434070)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (10036 - 112142 != -102105)
			{
				hashtable.Add(71, CID);
				if (58663 - 433547 != -374883)
				{
					hashtable.Add(75, PhotonClient.cInt16(1));
					if (154868 - 480071 != -325202)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (65582 - 320984 == -255402)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (217642 - 138926 == 78716)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (71337 - 150341 != -79003)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (291407 - 139139 != 152269)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (9521 - 393338 != -383816)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (139012 - 304056 != -165043)
											{
												this.I0wnT3yrBPR.OpCustom(61, hashtable, true);
												if (232566 - 182273 == 50293)
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

	// Token: 0x0600C280 RID: 49792 RVA: 0x0146AD28 File Offset: 0x01468F28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePlayer(Hashtable data)
	{
		return new T55_LightPalace.$onCreatePlayer$47887(data, this).GetEnumerator();
	}

	// Token: 0x0600C281 RID: 49793 RVA: 0x0146AD38 File Offset: 0x01468F38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (224250 - 501882 != -277631)
		{
		}
		for (;;)
		{
			IL_1A:
			GameObject gameObject = Game.createPeer(data);
			if (222115 - 526018 != -303902)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (78193 - 416363 != -338169)
				{
					int i = 0;
					if (290551 - 285386 != 5166)
					{
						GameObject[] array2 = array;
						if (129841 - 542121 == -412280)
						{
							int length = array2.Length;
							if (286965 - 582201 == -295236)
							{
								while (i < length)
								{
									if (gameObject != array2[i])
									{
										if (33949 - 554852 == -520902)
										{
											goto IL_1A;
										}
										Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
										if (90491 - 343780 == -253288)
										{
											goto IL_1A;
										}
									}
									i++;
									if (246794 - 224976 != 21818)
									{
										goto IL_1A;
									}
								}
								if (58121 - 102331 == -44210)
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

	// Token: 0x0600C282 RID: 49794 RVA: 0x0146AEB0 File Offset: 0x014690B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPlayer()
	{
		Game.mPlayerID = 0;
	}

	// Token: 0x0600C283 RID: 49795 RVA: 0x0146AEB8 File Offset: 0x014690B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
	}

	// Token: 0x0600C284 RID: 49796 RVA: 0x0146AEBC File Offset: 0x014690BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLightGod()
	{
		return new T55_LightPalace.$TalkToLightGod$47900(this).GetEnumerator();
	}

	// Token: 0x0600C285 RID: 49797 RVA: 0x0146AECC File Offset: 0x014690CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWalrus()
	{
		return new T55_LightPalace.$TalkToWalrus$47909(this).GetEnumerator();
	}

	// Token: 0x0600C286 RID: 49798 RVA: 0x0146AEDC File Offset: 0x014690DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMiniSheep()
	{
		return new T55_LightPalace.$TalkToMiniSheep$47916(this).GetEnumerator();
	}

	// Token: 0x0600C287 RID: 49799 RVA: 0x0146AEEC File Offset: 0x014690EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseBookShelf(int n)
	{
		return new T55_LightPalace.$UseBookShelf$47923(n, this).GetEnumerator();
	}

	// Token: 0x0600C288 RID: 49800 RVA: 0x0146AEFC File Offset: 0x014690FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (224218 - 515798 != -291579)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (187859 - 425042 == -237183)
			{
				CharacterControl characterControl = null;
				if (208138 - 236111 == -27973)
				{
					if (mPlayer)
					{
						if (184890 - 487176 == -302285)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (112142 - 568900 == -456757)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (113119 - 417016 == -303897)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (98538 - 33877 == 64661)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (251530 - 119664 == 131866)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (96364 - 359990 != -263626)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (75285 - 477892 != -402607)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (167932 - 140898 != 27034)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (221077 - 207243 != 13834)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (114623 - 535900 == -421277)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (98393 - 180774 == -82381)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (212446 - 198273 == 14173)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (139973 - 335004 != -195030)
								{
									if (!changeGui)
									{
										break;
									}
									if (21845 - 547554 != -525708)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (180610 - 399817 == -219206)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (116883 - 34480 != 82403)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (287323 - 285970 != 1354)
										{
											gameGui.close();
											if (266009 - 227839 == 38170)
											{
												changeGui.enabled = true;
												if (7049 - 37973 != -30923)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (259463 - 463853 == -204390)
													{
														if (!gameObject)
														{
															break;
														}
														if (55441 - 430723 != -375281)
														{
															if (!mPlayer)
															{
																break;
															}
															if (135202 - 90132 != 45071)
															{
																Debug.Log("UseLifeAltar");
																if (149723 - 576569 == -426846)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (104595 - 140088 != -35492)
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

	// Token: 0x0600C289 RID: 49801 RVA: 0x0146B35C File Offset: 0x0146955C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseWarpAltar(object mVar)
	{
		this.StartCoroutine_Auto(this.ExitToTown());
	}

	// Token: 0x0600C28A RID: 49802 RVA: 0x0146B36C File Offset: 0x0146956C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToTown()
	{
		return new T55_LightPalace.$ExitToTown$47932(this).GetEnumerator();
	}

	// Token: 0x0600C28B RID: 49803 RVA: 0x0146B37C File Offset: 0x0146957C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveTown()
	{
		if (30469 - 342428 != -311959)
		{
		}
		for (;;)
		{
			Debug.Log("leaving LightPalace");
			if (172113 - 325456 == -153343)
			{
				Hashtable hashtable = new Hashtable();
				if (285852 - 351607 == -65755)
				{
					hashtable.Add(43, PlayerData.UID);
					if (254377 - 151204 == 103173)
					{
						PhotonClient.Connection.OpCustom(44, hashtable, true);
						if (296755 - 395988 == -99233)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C28C RID: 49804 RVA: 0x0146B454 File Offset: 0x01469654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveTown()
	{
		Debug.Log("onLeaveTown");
		this.JoinTown();
	}

	// Token: 0x0600C28D RID: 49805 RVA: 0x0146B468 File Offset: 0x01469668
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (34221 - 582354 != -548133)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (219118 - 132334 != 86785)
			{
				Hashtable hashtable = new Hashtable();
				if (156894 - 537856 != -380961)
				{
					if (Game.mNextGameCode == 30)
					{
						if (170888 - 11238 == 159651)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (224417 - 430189 == -205771)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (217156 - 8898 != 208258)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (154642 - 186557 != -31915)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (181794 - 394182 == -212387)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (230019 - 192715 == 37305)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (188900 - 77019 != 111881)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (256267 - 575245 != -318978)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (248518 - 286834 == -38315)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (33880 - 160458 == -126577)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (6873 - 194987 == -188113)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (198364 - 152067 != 46297)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (230858 - 168115 != 62743)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (74594 - 10578 == 64017)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (187305 - 362325 != -175020)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (187175 - 405083 != -217908)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (54725 - 285428 != -230703)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (262793 - 208608 == 54186)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (15456 - 555283 == -539826)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (280262 - 241008 != 39254)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (681 - 411409 != -410728)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (245001 - 277411 == -32409)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (290279 - 403420 != -113141)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (242086 - 366946 == -124859)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (148824 - 50084 == 98741)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (108489 - 514597 == -406107)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (236701 - 25070 == 211632)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (276257 - 456731 != -180474)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (272410 - 546844 != -274433)
					{
						this.I0wnT3yrBPR.OpCustom(42, hashtable, true);
						if (97769 - 42191 == 55578)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C28E RID: 49806 RVA: 0x0146BA1C File Offset: 0x01469C1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600C28F RID: 49807 RVA: 0x0146BA2C File Offset: 0x01469C2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C290 RID: 49808 RVA: 0x0146BA30 File Offset: 0x01469C30
	internal static bool M7XtyFtS56mWRoy6EtyG()
	{
		return true;
	}

	// Token: 0x0600C291 RID: 49809 RVA: 0x0146BA34 File Offset: 0x01469C34
	internal static bool K02W0ktSpTw8iAPbHKbL()
	{
		return false;
	}

	// Token: 0x0400A513 RID: 42259
	private LitePeer I0wnT3yrBPR;

	// Token: 0x0400A514 RID: 42260
	private PlayerCameraControl K3VnTb722bJ;

	// Token: 0x0400A515 RID: 42261
	private Texture WSNnTdDZLK1;

	// Token: 0x0400A516 RID: 42262
	public AudioClip chat1_vc;

	// Token: 0x02002076 RID: 8310
	[CompilerGenerated]
	[Serializable]
	internal sealed class $LightPalaceStartEvent$47879 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C292 RID: 49810 RVA: 0x0146BA38 File Offset: 0x01469C38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $LightPalaceStartEvent$47879(T55_LightPalace self_)
		{
			if (89267 - 391581 != -302314)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (24894 - 145150 == -120256)
				{
					base..ctor();
					if (42761 - 453427 != -410665)
					{
						this.$self_$47886 = self_;
						if (258597 - 46312 == 212285)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C293 RID: 49811 RVA: 0x0146BAD0 File Offset: 0x01469CD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T55_LightPalace.$LightPalaceStartEvent$47879.$(this.$self_$47886);
		}

		// Token: 0x0600C294 RID: 49812 RVA: 0x0146BAE0 File Offset: 0x01469CE0
		internal static bool ViKRSHtSVIYX48qLB180()
		{
			return true;
		}

		// Token: 0x0600C295 RID: 49813 RVA: 0x0146BAE4 File Offset: 0x01469CE4
		internal static bool Df1BKBtStOhXYjSRhg7q()
		{
			return false;
		}

		// Token: 0x0400A517 RID: 42263
		internal T55_LightPalace $self_$47886;

		// Token: 0x02002077 RID: 8311
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C296 RID: 49814 RVA: 0x0146BAE8 File Offset: 0x01469CE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T55_LightPalace self_)
			{
				if (270998 - 99261 != 171737)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (77138 - 389012 != -311873)
					{
						base..ctor();
						if (74319 - 543135 != -468815)
						{
							this.$self_$47885 = self_;
							if (121366 - 6620 == 114746)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C297 RID: 49815 RVA: 0x0146BB80 File Offset: 0x01469D80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (179583 - 337548 != -157965)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_20F;
					case 1:
						goto IL_501;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (166926 - 374732 != -207806)
							{
								continue;
							}
							goto IL_46E;
						}
						else
						{
							this.$self_$47885.SendMessage("fadeOut");
							if (245902 - 492414 != -246511)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (59699 - 190712 != -131012)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					default:
						if (92964 - 82110 != 10855)
						{
							goto IL_20F;
						}
						continue;
					}
					IL_44:
					this.$startPoint$47883 = GameObject.Find("StartPoint1");
					if (287254 - 36010 != 251244)
					{
						continue;
					}
					this.$startCamera$47884 = GameObject.Find("StartCamera1");
					if (269327 - 559471 != -290144)
					{
						continue;
					}
					if (this.$startCamera$47884)
					{
						if (153442 - 594535 == -441092)
						{
							continue;
						}
						this.$self_$47885.transform.position = this.$startCamera$47884.transform.position;
						if (91647 - 417870 != -326223)
						{
							continue;
						}
						this.$self_$47885.transform.rotation = this.$startCamera$47884.transform.rotation;
						if (248615 - 148378 == 100238)
						{
							continue;
						}
					}
					if (this.$startPoint$47883)
					{
						if (120687 - 310850 != -190163)
						{
							continue;
						}
						this.$self_$47885.CreatePlayer(CharacterData.current.CID, this.$startPoint$47883.transform.position, this.$startPoint$47883.transform.forward);
						if (86055 - 480396 != -394341)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Error: Startpoint not found");
						if (154631 - 421253 == -266621)
						{
							continue;
						}
					}
					this.YieldDefault(1);
					if (42480 - 133539 != -91059)
					{
						continue;
					}
					break;
					IL_20F:
					Game.mGameState = eGameState.Start;
					if (41835 - 486101 == -444266)
					{
						Game.mStateTime = Time.time;
						if (70395 - 316020 == -245625)
						{
							this.$mEventCamera1$47880 = GameObject.Find("EventCamera1");
							if (160706 - 86217 != 74490)
							{
								this.$mEventCamera2$47881 = GameObject.Find("EventCamera2");
								if (103715 - 467446 != -363730)
								{
									if (this.$mEventCamera1$47880)
									{
										if (21972 - 178945 != -156973)
										{
											continue;
										}
										if (this.$mEventCamera2$47881)
										{
											if (116882 - 265613 == -148730)
											{
												continue;
											}
											this.$self_$47885.transform.position = this.$mEventCamera1$47880.transform.position;
											if (282103 - 282441 != -338)
											{
												continue;
											}
											this.$self_$47885.transform.rotation = this.$mEventCamera1$47880.transform.rotation;
											if (254508 - 587561 != -333053)
											{
												continue;
											}
											this.$mPlayerCameraControl$47882 = (PlayerCameraControl)this.$self_$47885.GetComponent(typeof(PlayerCameraControl));
											if (75089 - 548014 != -472925)
											{
												continue;
											}
											if (this.$mPlayerCameraControl$47882)
											{
												if (60823 - 558753 != -497930)
												{
													continue;
												}
												this.$mPlayerCameraControl$47882.StartCoroutine_Auto(this.$mPlayerCameraControl$47882.slerpToObject("EventCamera2", 2f));
												if (148524 - 275768 != -127244)
												{
													continue;
												}
											}
											this.$self_$47885.SendMessage("fadeIn");
											if (133209 - 533524 != -400315)
											{
												continue;
											}
											goto IL_347;
										}
									}
									Debug.LogError("Cannot find EventCamera1 or EventCamera2");
									if (247435 - 256559 != -9123)
									{
										goto IL_44;
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_501;
				IL_347:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_46E:
				goto IL_501;
				Block_31:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_501:
				return false;
			}

			// Token: 0x0600C298 RID: 49816 RVA: 0x0146C0A0 File Offset: 0x0146A2A0
			internal static bool EANmsbtSNTgtkb0s1UGM()
			{
				return true;
			}

			// Token: 0x0600C299 RID: 49817 RVA: 0x0146C0A4 File Offset: 0x0146A2A4
			internal static bool fJWaTjtSY0ieuQjAG9IU()
			{
				return false;
			}

			// Token: 0x0400A518 RID: 42264
			internal GameObject $mEventCamera1$47880;

			// Token: 0x0400A519 RID: 42265
			internal GameObject $mEventCamera2$47881;

			// Token: 0x0400A51A RID: 42266
			internal PlayerCameraControl $mPlayerCameraControl$47882;

			// Token: 0x0400A51B RID: 42267
			internal GameObject $startPoint$47883;

			// Token: 0x0400A51C RID: 42268
			internal GameObject $startCamera$47884;

			// Token: 0x0400A51D RID: 42269
			internal T55_LightPalace $self_$47885;
		}
	}

	// Token: 0x02002078 RID: 8312
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePlayer$47887 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C29A RID: 49818 RVA: 0x0146C0A8 File Offset: 0x0146A2A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePlayer$47887(Hashtable data, T55_LightPalace self_)
		{
			if (110017 - 105108 != 4910)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (104407 - 27235 == 77172)
				{
					base..ctor();
					if (200842 - 118811 == 82031)
					{
						this.$data$47898 = data;
						if (269736 - 214337 == 55399)
						{
							this.$self_$47899 = self_;
							if (10216 - 322046 == -311830)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C29B RID: 49819 RVA: 0x0146C164 File Offset: 0x0146A364
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T55_LightPalace.$onCreatePlayer$47887.$(this.$data$47898, this.$self_$47899);
		}

		// Token: 0x0600C29C RID: 49820 RVA: 0x0146C178 File Offset: 0x0146A378
		internal static bool oUbrrJtScCRXYdW6fuQD()
		{
			return true;
		}

		// Token: 0x0600C29D RID: 49821 RVA: 0x0146C17C File Offset: 0x0146A37C
		internal static bool GFVRubtSUkpUQ2QlgUNo()
		{
			return false;
		}

		// Token: 0x0400A51E RID: 42270
		internal Hashtable $data$47898;

		// Token: 0x0400A51F RID: 42271
		internal T55_LightPalace $self_$47899;

		// Token: 0x02002079 RID: 8313
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C29E RID: 49822 RVA: 0x0146C180 File Offset: 0x0146A380
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, T55_LightPalace self_)
			{
				if (12869 - 578515 != -565646)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (270531 - 129266 == 141265)
					{
						base..ctor();
						if (23961 - 77318 != -53356)
						{
							this.$data$47896 = data;
							if (145884 - 594466 != -448581)
							{
								this.$self_$47897 = self_;
								if (125724 - 566229 != -440504)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C29F RID: 49823 RVA: 0x0146C23C File Offset: 0x0146A43C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (233250 - 309594 != -76344)
				{
				}
				for (;;)
				{
					IL_1A:
					switch (this._state)
					{
					case 0:
						goto IL_196;
					case 1:
						goto IL_438;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (149502 - 12659 == 136844)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (223743 - 206586 == 17158)
						{
							continue;
						}
						break;
					default:
						if (84954 - 515909 != -430955)
						{
							continue;
						}
						goto IL_196;
					}
					IL_137:
					this.YieldDefault(1);
					if (168603 - 217792 != -49188)
					{
						break;
					}
					continue;
					IL_196:
					this.$nPlayer$47888 = Game.createPlayer(this.$data$47896);
					if (157075 - 137617 == 19458)
					{
						if (!this.$nPlayer$47888)
						{
							goto IL_137;
						}
						if (180844 - 188374 != -7529)
						{
							this.$mPlayerList$47889 = GameObject.FindGameObjectsWithTag("Player");
							if (262926 - 548687 == -285761)
							{
								this.$$13708$47893 = 0;
								if (165771 - 316775 != -151003)
								{
									this.$$13709$47894 = this.$mPlayerList$47889;
									if (67676 - 71444 == -3768)
									{
										this.$$13710$47895 = this.$$13709$47894.Length;
										if (159829 - 413844 == -254015)
										{
											while (this.$$13708$47893 < this.$$13710$47895)
											{
												if (this.$nPlayer$47888 != this.$$13709$47894[this.$$13708$47893])
												{
													if (206890 - 83934 == 122957)
													{
														goto IL_1A;
													}
													Physics.IgnoreCollision(this.$nPlayer$47888.collider, this.$$13709$47894[this.$$13708$47893].collider, true);
													if (279582 - 1561 == 278022)
													{
														goto IL_1A;
													}
												}
												this.$$13708$47893++;
												if (134971 - 3688 == 131284)
												{
													goto IL_1A;
												}
											}
											if (222898 - 401013 != -178114)
											{
												Game.mPlayer = this.$nPlayer$47888;
												if (245606 - 469025 != -223418)
												{
													Camera.main.gameObject.layer = 1;
													if (240956 - 415445 == -174489)
													{
														this.$mPlayerCameraControl$47891 = (PlayerCameraControl)this.$self_$47897.GetComponent(typeof(PlayerCameraControl));
														if (29441 - 140519 == -111078)
														{
															if (this.$mPlayerCameraControl$47891)
															{
																if (273749 - 28140 != 245609)
																{
																	continue;
																}
																this.$mPlayerCameraControl$47891.target = this.$nPlayer$47888;
																if (78063 - 242024 != -163961)
																{
																	continue;
																}
																this.$mPlayerCameraControl$47891.specialTarget = null;
																if (267184 - 176481 == 90704)
																{
																	continue;
																}
																this.$mPlayerCameraControl$47891.enabled = true;
																if (99197 - 179902 == -80704)
																{
																	continue;
																}
															}
															this.$mGameGui$47892 = (GameGui)this.$self_$47897.GetComponent(typeof(GameGui));
															if (13110 - 260056 != -246945)
															{
																this.$mGameGui$47892.enabled = true;
																if (168821 - 536435 != -367613)
																{
																	this.$self_$47897.SendMessage("fadeIn");
																	if (117352 - 319215 != -201862)
																	{
																		goto Block_18;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_438;
				Block_18:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_438:
				return false;
			}

			// Token: 0x0600C2A0 RID: 49824 RVA: 0x0146C694 File Offset: 0x0146A894
			internal static bool ufkgretSTrujDKdh7jjw()
			{
				return true;
			}

			// Token: 0x0600C2A1 RID: 49825 RVA: 0x0146C698 File Offset: 0x0146A898
			internal static bool HWWh0otS3KmQ3mXTHmRP()
			{
				return false;
			}

			// Token: 0x0400A520 RID: 42272
			internal GameObject $nPlayer$47888;

			// Token: 0x0400A521 RID: 42273
			internal GameObject[] $mPlayerList$47889;

			// Token: 0x0400A522 RID: 42274
			internal GameObject $otherPlayer$47890;

			// Token: 0x0400A523 RID: 42275
			internal PlayerCameraControl $mPlayerCameraControl$47891;

			// Token: 0x0400A524 RID: 42276
			internal GameGui $mGameGui$47892;

			// Token: 0x0400A525 RID: 42277
			internal int $$13708$47893;

			// Token: 0x0400A526 RID: 42278
			internal GameObject[] $$13709$47894;

			// Token: 0x0400A527 RID: 42279
			internal int $$13710$47895;

			// Token: 0x0400A528 RID: 42280
			internal Hashtable $data$47896;

			// Token: 0x0400A529 RID: 42281
			internal T55_LightPalace $self_$47897;
		}
	}

	// Token: 0x0200207A RID: 8314
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLightGod$47900 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C2A2 RID: 49826 RVA: 0x0146C69C File Offset: 0x0146A89C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLightGod$47900(T55_LightPalace self_)
		{
			if (153277 - 26247 != 127031)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (212854 - 205399 == 7455)
				{
					base..ctor();
					if (41325 - 301966 == -260641)
					{
						this.$self_$47908 = self_;
						if (280460 - 495182 == -214722)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C2A3 RID: 49827 RVA: 0x0146C734 File Offset: 0x0146A934
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T55_LightPalace.$TalkToLightGod$47900.$(this.$self_$47908);
		}

		// Token: 0x0600C2A4 RID: 49828 RVA: 0x0146C744 File Offset: 0x0146A944
		internal static bool Ra1WOTtSXHVViE2bOjcJ()
		{
			return true;
		}

		// Token: 0x0600C2A5 RID: 49829 RVA: 0x0146C748 File Offset: 0x0146A948
		internal static bool f3RNH9tSQKKNGGCTxHhk()
		{
			return false;
		}

		// Token: 0x0400A52A RID: 42282
		internal T55_LightPalace $self_$47908;

		// Token: 0x0200207B RID: 8315
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C2A6 RID: 49830 RVA: 0x0146C74C File Offset: 0x0146A94C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T55_LightPalace self_)
			{
				if (200202 - 344954 != -144751)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (88028 - 205535 == -117507)
					{
						base..ctor();
						if (34737 - 389914 == -355177)
						{
							this.$self_$47907 = self_;
							if (187724 - 359273 != -171548)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C2A7 RID: 49831 RVA: 0x0146C7E4 File Offset: 0x0146A9E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56652 - 485332 != -428679)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_65B;
					case 2:
						this.$m$47906 = Language.getMessage("T55_LightPalace", 101 + UnityEngine.Random.Range(0, 9));
						if (68985 - 519405 != -450420)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (161284 - 158305 != 2979)
							{
								continue;
							}
							if (this.$self_$47907.chat1_vc)
							{
								if (44029 - 385889 == -341859)
								{
									continue;
								}
								this.$self_$47907.audio.PlayOneShot(this.$self_$47907.chat1_vc);
								if (111545 - 548035 != -436490)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find chat1 voice");
								if (90446 - 243873 == -153426)
								{
									continue;
								}
							}
						}
						this.$mStoryGui$47902.newStoryMessage("LightGod", "Alcacia", this.$m$47906, eTalkType.friend);
						if (56534 - 36261 != 20274)
						{
							goto Block_27;
						}
						continue;
					case 3:
						this.$mStoryGui$47902.close();
						if (272517 - 96031 == 176487)
						{
							continue;
						}
						if (this.$mLightGod$47903)
						{
							if (9256 - 331878 != -322622)
							{
								continue;
							}
							this.$mLightGod$47903.animation.CrossFade("root", 0.2f);
							if (150146 - 429033 == -278886)
							{
								continue;
							}
						}
						this.$mGameGui$47901.enabled = true;
						if (67906 - 164438 != -96532)
						{
							continue;
						}
						goto IL_61B;
					case 4:
						if (this.$mLightCam$47904)
						{
							if (66902 - 342326 != -275424)
							{
								continue;
							}
							if (this.$mCameraControl$47905)
							{
								if (43999 - 384719 != -340720)
								{
									continue;
								}
								this.$mCameraControl$47905.specialTarget = null;
								if (206750 - 474452 == -267701)
								{
									continue;
								}
							}
						}
						Game.mGameState = eGameState.Normal;
						if (188796 - 287483 != -98686)
						{
							goto IL_3D4;
						}
						continue;
					default:
						if (69061 - 426416 == -357354)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (138356 - 134854 != 3502)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mGameGui$47901 = (GameGui)this.$self_$47907.GetComponent(typeof(GameGui));
						if (250217 - 77733 == 172485)
						{
							continue;
						}
						this.$mStoryGui$47902 = (StoryGui)this.$self_$47907.GetComponent(typeof(StoryGui));
						if (105834 - 394371 == -288536)
						{
							continue;
						}
						if (this.$mGameGui$47901)
						{
							if (177886 - 417311 != -239425)
							{
								continue;
							}
							if (this.$mStoryGui$47902)
							{
								if (260903 - 53739 == 207165)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (173605 - 193794 != -20189)
								{
									continue;
								}
								this.$mGameGui$47901.close();
								if (82357 - 580942 == -498584)
								{
									continue;
								}
								this.$mLightGod$47903 = GameObject.Find("LightGod");
								if (108568 - 80551 != 28017)
								{
									continue;
								}
								if (this.$mLightGod$47903)
								{
									if (205019 - 515056 == -310036)
									{
										continue;
									}
									this.$mLightGod$47903.animation.CrossFade("talk", 0.2f);
									if (101482 - 225488 == -124005)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mLightGod$47903.transform.position);
									if (21354 - 333067 != -311713)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find LightGod");
									if (143097 - 409543 == -266445)
									{
										continue;
									}
								}
								this.$mLightCam$47904 = GameObject.Find("LightCam");
								if (221327 - 91292 != 130035)
								{
									continue;
								}
								this.$mCameraControl$47905 = (PlayerCameraControl)this.$self_$47907.gameObject.GetComponent(typeof(PlayerCameraControl));
								if (18525 - 223770 == -205244)
								{
									continue;
								}
								if (this.$mLightCam$47904)
								{
									if (46101 - 223499 != -177398)
									{
										continue;
									}
									if (this.$mCameraControl$47905)
									{
										if (211100 - 102564 != 108536)
										{
											continue;
										}
										this.$mCameraControl$47905.specialTarget = this.$mLightCam$47904;
										if (543 - 394196 != -393653)
										{
											continue;
										}
									}
								}
								this.$mStoryGui$47902.startStoryMessage("LightGod", "Alcacia", eTalkType.friend);
								if (93406 - 585638 != -492232)
								{
									continue;
								}
								goto IL_3F6;
							}
						}
					}
					IL_3D4:
					this.YieldDefault(1);
				}
				while (135954 - 33340 != 102614);
				goto IL_65B;
				Block_27:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_3F6:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_61B:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_65B:
				return false;
			}

			// Token: 0x0600C2A8 RID: 49832 RVA: 0x0146CE60 File Offset: 0x0146B060
			internal static bool hmeRmAtSkR9adEcgQaQH()
			{
				return true;
			}

			// Token: 0x0600C2A9 RID: 49833 RVA: 0x0146CE64 File Offset: 0x0146B064
			internal static bool sWJ4tYtSGl1PHo2sEL7t()
			{
				return false;
			}

			// Token: 0x0400A52B RID: 42283
			internal GameGui $mGameGui$47901;

			// Token: 0x0400A52C RID: 42284
			internal StoryGui $mStoryGui$47902;

			// Token: 0x0400A52D RID: 42285
			internal GameObject $mLightGod$47903;

			// Token: 0x0400A52E RID: 42286
			internal GameObject $mLightCam$47904;

			// Token: 0x0400A52F RID: 42287
			internal PlayerCameraControl $mCameraControl$47905;

			// Token: 0x0400A530 RID: 42288
			internal string $m$47906;

			// Token: 0x0400A531 RID: 42289
			internal T55_LightPalace $self_$47907;
		}
	}

	// Token: 0x0200207C RID: 8316
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWalrus$47909 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C2AA RID: 49834 RVA: 0x0146CE68 File Offset: 0x0146B068
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWalrus$47909(T55_LightPalace self_)
		{
			if (299657 - 473783 != -174126)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (67648 - 259946 == -192298)
				{
					base..ctor();
					if (63048 - 519292 == -456244)
					{
						this.$self_$47915 = self_;
						if (126560 - 129603 == -3043)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C2AB RID: 49835 RVA: 0x0146CF00 File Offset: 0x0146B100
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T55_LightPalace.$TalkToWalrus$47909.$(this.$self_$47915);
		}

		// Token: 0x0600C2AC RID: 49836 RVA: 0x0146CF10 File Offset: 0x0146B110
		internal static bool nrCm3otSHIAlDq1LivrN()
		{
			return true;
		}

		// Token: 0x0600C2AD RID: 49837 RVA: 0x0146CF14 File Offset: 0x0146B114
		internal static bool c3EaoBtSWZZNo7gYmTjx()
		{
			return false;
		}

		// Token: 0x0400A532 RID: 42290
		internal T55_LightPalace $self_$47915;

		// Token: 0x0200207D RID: 8317
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C2AE RID: 49838 RVA: 0x0146CF18 File Offset: 0x0146B118
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T55_LightPalace self_)
			{
				if (262052 - 129995 != 132058)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (106389 - 277038 == -170649)
					{
						base..ctor();
						if (45370 - 125047 == -79677)
						{
							this.$self_$47914 = self_;
							if (262648 - 291117 == -28469)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C2AF RID: 49839 RVA: 0x0146CFB0 File Offset: 0x0146B1B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (2560 - 188860 != -186300)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5F1;
					case 2:
						this.$m$47913 = Language.getMessage("T55_LightPalace", 201 + UnityEngine.Random.Range(0, 9));
						if (121523 - 59384 != 62139)
						{
							continue;
						}
						this.$mStoryGui$47911.newStoryMessage("Walrus", "Reggu", this.$m$47913, eTalkType.friend);
						if (65135 - 472987 != -407851)
						{
							goto Block_3;
						}
						continue;
					case 3:
						this.$mStoryGui$47911.close();
						if (77400 - 496221 == -418820)
						{
							continue;
						}
						if (this.$mWalrus$47912)
						{
							if (80242 - 237569 == -157326)
							{
								continue;
							}
							this.$mWalrus$47912.animation.CrossFade("root", 0.2f);
							if (297921 - 269926 == 27996)
							{
								continue;
							}
						}
						this.$mGameGui$47910.enabled = true;
						if (293850 - 500582 != -206732)
						{
							continue;
						}
						goto IL_57D;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (249794 - 99945 != 149849)
						{
							continue;
						}
						goto IL_37A;
					default:
						if (48829 - 187906 != -139077)
						{
							continue;
						}
						break;
					}
					if (PlayerData.QuestID == 53)
					{
						if (145740 - 28414 != 117326)
						{
							continue;
						}
						Q53_RegguAlchemy.TalkToReggu(this.$self_$47914.gameObject);
						if (81421 - 500970 == -419548)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == -53)
					{
						if (287125 - 234647 == 52479)
						{
							continue;
						}
						Q53_RegguAlchemy.TalkToRegguRepeat(this.$self_$47914.gameObject);
						if (81234 - 403446 == -322211)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == 66)
					{
						if (196295 - 255015 == -58719)
						{
							continue;
						}
						Q66_LittleBigVeggie.TalkToReggu(this.$self_$47914.gameObject);
						if (46515 - 326201 != -279686)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == -66)
					{
						if (23169 - 449776 != -426607)
						{
							continue;
						}
						Q66_LittleBigVeggie.TalkToRegguRepeat(this.$self_$47914.gameObject);
						if (34397 - 84737 == -50339)
						{
							continue;
						}
					}
					else if (Game.mGameState != eGameState.Normal)
					{
						if (197541 - 237671 != -40130)
						{
							continue;
						}
						goto IL_2B2;
					}
					else
					{
						this.$mGameGui$47910 = (GameGui)this.$self_$47914.GetComponent(typeof(GameGui));
						if (57673 - 48875 == 8799)
						{
							continue;
						}
						this.$mStoryGui$47911 = (StoryGui)this.$self_$47914.GetComponent(typeof(StoryGui));
						if (20928 - 353159 == -332230)
						{
							continue;
						}
						if (this.$mGameGui$47910)
						{
							if (77912 - 329090 == -251177)
							{
								continue;
							}
							if (this.$mStoryGui$47911)
							{
								if (176522 - 130541 == 45982)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (283885 - 250802 != 33083)
								{
									continue;
								}
								this.$mGameGui$47910.close();
								if (86593 - 160252 != -73659)
								{
									continue;
								}
								this.$mWalrus$47912 = GameObject.Find("Walrus");
								if (131965 - 66651 == 65315)
								{
									continue;
								}
								if (this.$mWalrus$47912)
								{
									if (87294 - 514508 != -427214)
									{
										continue;
									}
									this.$mWalrus$47912.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mWalrus$47912.transform.position));
									if (177095 - 118879 == 58217)
									{
										continue;
									}
									this.$mWalrus$47912.animation.CrossFade("talk", 0.2f);
									if (216174 - 502819 != -286645)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mWalrus$47912.transform.position);
									if (277022 - 551756 == -274733)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Walrus");
									if (211687 - 294567 == -82879)
									{
										continue;
									}
								}
								this.$mStoryGui$47911.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
								if (804 - 402808 != -402004)
								{
									continue;
								}
								goto IL_F9;
							}
						}
					}
					IL_37A:
					this.YieldDefault(1);
					if (298879 - 246704 != 52176)
					{
						goto Block_25;
					}
				}
				Block_3:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_F9:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_2B2:
				Block_25:
				goto IL_5F1;
				IL_57D:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_5F1:
				return false;
			}

			// Token: 0x0600C2B0 RID: 49840 RVA: 0x0146D5C0 File Offset: 0x0146B7C0
			internal static bool LlAMOxtSAGUghyTSxXfW()
			{
				return true;
			}

			// Token: 0x0600C2B1 RID: 49841 RVA: 0x0146D5C4 File Offset: 0x0146B7C4
			internal static bool hZ8XPetSlhQFSBrG5tLl()
			{
				return false;
			}

			// Token: 0x0400A533 RID: 42291
			internal GameGui $mGameGui$47910;

			// Token: 0x0400A534 RID: 42292
			internal StoryGui $mStoryGui$47911;

			// Token: 0x0400A535 RID: 42293
			internal GameObject $mWalrus$47912;

			// Token: 0x0400A536 RID: 42294
			internal string $m$47913;

			// Token: 0x0400A537 RID: 42295
			internal T55_LightPalace $self_$47914;
		}
	}

	// Token: 0x0200207E RID: 8318
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMiniSheep$47916 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C2B2 RID: 49842 RVA: 0x0146D5C8 File Offset: 0x0146B7C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMiniSheep$47916(T55_LightPalace self_)
		{
			if (241188 - 118318 != 122871)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (185975 - 491744 == -305769)
				{
					base..ctor();
					if (270404 - 560514 != -290109)
					{
						this.$self_$47922 = self_;
						if (283007 - 525793 != -242785)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C2B3 RID: 49843 RVA: 0x0146D660 File Offset: 0x0146B860
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T55_LightPalace.$TalkToMiniSheep$47916.$(this.$self_$47922);
		}

		// Token: 0x0600C2B4 RID: 49844 RVA: 0x0146D670 File Offset: 0x0146B870
		internal static bool uMW59WtSyMPohUa6E37f()
		{
			return true;
		}

		// Token: 0x0600C2B5 RID: 49845 RVA: 0x0146D674 File Offset: 0x0146B874
		internal static bool Aq7TlUtSSGsphp95Qnp1()
		{
			return false;
		}

		// Token: 0x0400A538 RID: 42296
		internal T55_LightPalace $self_$47922;

		// Token: 0x0200207F RID: 8319
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C2B6 RID: 49846 RVA: 0x0146D678 File Offset: 0x0146B878
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T55_LightPalace self_)
			{
				if (237134 - 360289 != -123154)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (22674 - 35626 != -12951)
					{
						base..ctor();
						if (149609 - 389517 != -239907)
						{
							this.$self_$47921 = self_;
							if (209300 - 359286 != -149985)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C2B7 RID: 49847 RVA: 0x0146D710 File Offset: 0x0146B910
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (11573 - 261612 != -250038)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_46E;
					case 2:
						this.$m$47920 = Language.getMessage("T55_LightPalace", 301 + UnityEngine.Random.Range(0, 9));
						if (258358 - 592337 == -333978)
						{
							continue;
						}
						this.$mStoryGui$47918.newStoryMessage("none", "MiniSheep", this.$m$47920, eTalkType.friend);
						if (234186 - 375924 != -141738)
						{
							continue;
						}
						goto IL_20E;
					case 3:
						this.$mStoryGui$47918.close();
						if (72190 - 187373 != -115183)
						{
							continue;
						}
						if (this.$mMiniSheep$47919)
						{
							if (176706 - 289042 != -112336)
							{
								continue;
							}
							this.$mMiniSheep$47919.transform.rotation = Quaternion.Euler((float)0, (float)180, (float)0);
							if (152080 - 165779 != -13699)
							{
								continue;
							}
						}
						this.$mGameGui$47917.enabled = true;
						if (155011 - 116583 != 38428)
						{
							continue;
						}
						goto IL_101;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (86982 - 586364 != -499382)
						{
							continue;
						}
						goto IL_1C2;
					default:
						if (94913 - 211886 != -116973)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (427 - 378954 != -378527)
						{
							continue;
						}
						goto IL_31F;
					}
					else
					{
						this.$mGameGui$47917 = (GameGui)this.$self_$47921.GetComponent(typeof(GameGui));
						if (274612 - 2311 != 272301)
						{
							continue;
						}
						this.$mStoryGui$47918 = (StoryGui)this.$self_$47921.GetComponent(typeof(StoryGui));
						if (179906 - 456700 != -276794)
						{
							continue;
						}
						if (this.$mGameGui$47917)
						{
							if (201568 - 73206 == 128363)
							{
								continue;
							}
							if (this.$mStoryGui$47918)
							{
								if (112609 - 468628 == -356018)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (227739 - 231701 == -3961)
								{
									continue;
								}
								this.$mGameGui$47917.close();
								if (114678 - 56204 == 58475)
								{
									continue;
								}
								this.$mMiniSheep$47919 = GameObject.Find("MiniSheep");
								if (243742 - 263909 != -20167)
								{
									continue;
								}
								if (this.$mMiniSheep$47919)
								{
									if (55391 - 46247 != 9144)
									{
										continue;
									}
									this.$mMiniSheep$47919.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mMiniSheep$47919.transform.position));
									if (233555 - 477116 != -243561)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mMiniSheep$47919.transform.position);
									if (178006 - 128770 == 49237)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find MiniSheep");
									if (264827 - 166898 == 97930)
									{
										continue;
									}
								}
								this.$mStoryGui$47918.startStoryMessage("none", "MiniSheep", eTalkType.friend);
								if (170755 - 346221 != -175466)
								{
									continue;
								}
								goto IL_35E;
							}
						}
					}
					IL_1C2:
					this.YieldDefault(1);
					if (26315 - 341800 != -315484)
					{
						goto Block_13;
					}
				}
				IL_101:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_13:
				goto IL_46E;
				IL_20E:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_31F:
				goto IL_46E;
				IL_35E:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_46E:
				return false;
			}

			// Token: 0x0600C2B8 RID: 49848 RVA: 0x0146DBA0 File Offset: 0x0146BDA0
			internal static bool TrHhhYtSo7HVi3pf4RuL()
			{
				return true;
			}

			// Token: 0x0600C2B9 RID: 49849 RVA: 0x0146DBA4 File Offset: 0x0146BDA4
			internal static bool rWXoYTtSE41T2MugqYsL()
			{
				return false;
			}

			// Token: 0x0400A539 RID: 42297
			internal GameGui $mGameGui$47917;

			// Token: 0x0400A53A RID: 42298
			internal StoryGui $mStoryGui$47918;

			// Token: 0x0400A53B RID: 42299
			internal GameObject $mMiniSheep$47919;

			// Token: 0x0400A53C RID: 42300
			internal string $m$47920;

			// Token: 0x0400A53D RID: 42301
			internal T55_LightPalace $self_$47921;
		}
	}

	// Token: 0x02002080 RID: 8320
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseBookShelf$47923 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C2BA RID: 49850 RVA: 0x0146DBA8 File Offset: 0x0146BDA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseBookShelf$47923(int n, T55_LightPalace self_)
		{
			if (255671 - 385879 != -130207)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (22211 - 397857 != -375645)
				{
					base..ctor();
					if (51709 - 371981 != -320271)
					{
						this.$n$47930 = n;
						if (119007 - 173019 != -54011)
						{
							this.$self_$47931 = self_;
							if (91899 - 167370 != -75470)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C2BB RID: 49851 RVA: 0x0146DC64 File Offset: 0x0146BE64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T55_LightPalace.$UseBookShelf$47923.$(this.$n$47930, this.$self_$47931);
		}

		// Token: 0x0600C2BC RID: 49852 RVA: 0x0146DC78 File Offset: 0x0146BE78
		internal static bool BPZGZgtS2abG2OEHBDUq()
		{
			return true;
		}

		// Token: 0x0600C2BD RID: 49853 RVA: 0x0146DC7C File Offset: 0x0146BE7C
		internal static bool hcX5UbtS8C3Z6S8Fa3ME()
		{
			return false;
		}

		// Token: 0x0400A53E RID: 42302
		internal int $n$47930;

		// Token: 0x0400A53F RID: 42303
		internal T55_LightPalace $self_$47931;

		// Token: 0x02002081 RID: 8321
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C2BE RID: 49854 RVA: 0x0146DC80 File Offset: 0x0146BE80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, T55_LightPalace self_)
			{
				if (13597 - 85078 != -71480)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (158485 - 221896 != -63410)
					{
						base..ctor();
						if (281893 - 361422 != -79528)
						{
							this.$n$47928 = n;
							if (35963 - 327236 == -291273)
							{
								this.$self_$47929 = self_;
								if (240960 - 191433 == 49527)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C2BF RID: 49855 RVA: 0x0146DD3C File Offset: 0x0146BF3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (43980 - 244266 != -200286)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_37B;
					case 1:
						goto IL_3DF;
					case 2:
						this.$m$47927 = Language.getMessage("T55_LightPalace", 401 + (this.$n$47928 - 1) * 10 + UnityEngine.Random.Range(0, 9));
						if (154202 - 305449 != -151247)
						{
							continue;
						}
						this.$mStoryGui$47925.newStoryMessage("none", "BookShelf", this.$m$47927, eTalkType.friend);
						if (292072 - 474800 != -182727)
						{
							goto Block_11;
						}
						continue;
					case 3:
						this.$mStoryGui$47925.close();
						if (252946 - 485309 != -232363)
						{
							continue;
						}
						this.$mGameGui$47924.enabled = true;
						if (143924 - 249715 != -105791)
						{
							continue;
						}
						goto IL_245;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (183627 - 230265 == -46637)
						{
							continue;
						}
						break;
					default:
						if (120813 - 296626 != -175813)
						{
							continue;
						}
						goto IL_37B;
					}
					IL_305:
					this.YieldDefault(1);
					if (184652 - 339803 != -155150)
					{
						goto Block_18;
					}
					continue;
					IL_37B:
					if (Game.mGameState != eGameState.Normal)
					{
						if (203142 - 24401 == 178741)
						{
							goto IL_3A0;
						}
					}
					else
					{
						this.$mGameGui$47924 = (GameGui)this.$self_$47929.GetComponent(typeof(GameGui));
						if (139402 - 39508 != 99895)
						{
							this.$mStoryGui$47925 = (StoryGui)this.$self_$47929.GetComponent(typeof(StoryGui));
							if (224167 - 260992 != -36824)
							{
								if (!this.$mGameGui$47924)
								{
									goto IL_305;
								}
								if (25362 - 587146 == -561784)
								{
									if (!this.$mStoryGui$47925)
									{
										goto IL_305;
									}
									if (33320 - 103668 != -70347)
									{
										Game.mGameState = eGameState.Hold;
										if (219403 - 488136 == -268733)
										{
											this.$mGameGui$47924.close();
											if (204767 - 523693 != -318925)
											{
												this.$mBookShelf$47926 = GameObject.Find("BookShelf" + this.$n$47928);
												if (94549 - 71642 != 22908)
												{
													if (this.$mBookShelf$47926)
													{
														if (268259 - 452412 == -184152)
														{
															continue;
														}
														Game.mPlayer.SendMessage("turnToPos", this.$mBookShelf$47926.transform.position);
														if (299153 - 175685 == 123469)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find BookShelf" + this.$n$47928);
														if (82172 - 303518 != -221346)
														{
															continue;
														}
													}
													this.$mStoryGui$47925.startStoryMessage("BookShelf", "BookShelf", eTalkType.friend);
													if (226868 - 263272 != -36403)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_11:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_245:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_18:
				IL_3A0:
				IL_3DF:
				return false;
			}

			// Token: 0x0600C2C0 RID: 49856 RVA: 0x0146E13C File Offset: 0x0146C33C
			internal static bool Se9bUktSZ9PCb81mVKKO()
			{
				return true;
			}

			// Token: 0x0600C2C1 RID: 49857 RVA: 0x0146E140 File Offset: 0x0146C340
			internal static bool ErrCfDtSCpjwKPog4eMZ()
			{
				return false;
			}

			// Token: 0x0400A540 RID: 42304
			internal GameGui $mGameGui$47924;

			// Token: 0x0400A541 RID: 42305
			internal StoryGui $mStoryGui$47925;

			// Token: 0x0400A542 RID: 42306
			internal GameObject $mBookShelf$47926;

			// Token: 0x0400A543 RID: 42307
			internal string $m$47927;

			// Token: 0x0400A544 RID: 42308
			internal int $n$47928;

			// Token: 0x0400A545 RID: 42309
			internal T55_LightPalace $self_$47929;
		}
	}

	// Token: 0x02002082 RID: 8322
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToTown$47932 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C2C2 RID: 49858 RVA: 0x0146E144 File Offset: 0x0146C344
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToTown$47932(T55_LightPalace self_)
		{
			if (63905 - 551358 != -487452)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (82303 - 119420 != -37116)
				{
					base..ctor();
					if (132215 - 548755 != -416539)
					{
						this.$self_$47935 = self_;
						if (61752 - 493565 != -431812)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C2C3 RID: 49859 RVA: 0x0146E1DC File Offset: 0x0146C3DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T55_LightPalace.$ExitToTown$47932.$(this.$self_$47935);
		}

		// Token: 0x0600C2C4 RID: 49860 RVA: 0x0146E1EC File Offset: 0x0146C3EC
		internal static bool zECGTxtSLQpZVyu1BbSp()
		{
			return true;
		}

		// Token: 0x0600C2C5 RID: 49861 RVA: 0x0146E1F0 File Offset: 0x0146C3F0
		internal static bool ElMIhEtSOCbS1ZDk0Q9M()
		{
			return false;
		}

		// Token: 0x0400A546 RID: 42310
		internal T55_LightPalace $self_$47935;

		// Token: 0x02002083 RID: 8323
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C2C6 RID: 49862 RVA: 0x0146E1F4 File Offset: 0x0146C3F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T55_LightPalace self_)
			{
				if (150837 - 84036 != 66801)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (201746 - 360977 == -159231)
					{
						base..ctor();
						if (98243 - 440706 != -342462)
						{
							this.$self_$47934 = self_;
							if (184466 - 230386 != -45919)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C2C7 RID: 49863 RVA: 0x0146E28C File Offset: 0x0146C48C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (86010 - 364187 != -278177)
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
						this.$self_$47934.LeaveTown();
						if (233649 - 472812 != -239163)
						{
							continue;
						}
						this.YieldDefault(1);
						if (64046 - 589651 != -525605)
						{
							continue;
						}
						goto IL_1E1;
					default:
						if (222891 - 516251 != -293360)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (210408 - 354573 != -144164)
					{
						Game.mStateTime = Time.time;
						if (123720 - 433043 != -309322)
						{
							Game.mNextGameId = 504;
							if (144060 - 326234 != -182173)
							{
								Game.mNextGameCode = 54;
								if (280375 - 539641 != -259265)
								{
									this.$mGameGui$47933 = (GameGui)this.$self_$47934.GetComponent(typeof(GameGui));
									if (221829 - 197204 == 24625)
									{
										if (this.$mGameGui$47933)
										{
											if (196044 - 153652 == 42393)
											{
												continue;
											}
											this.$mGameGui$47933.close();
											if (147096 - 336100 == -189003)
											{
												continue;
											}
										}
										this.$self_$47934.SendMessage("fadeOut");
										if (29456 - 175021 == -145565)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1E1:
				return false;
			}

			// Token: 0x0600C2C8 RID: 49864 RVA: 0x0146E48C File Offset: 0x0146C68C
			internal static bool E3GFZAtSmtk5iNbFfADL()
			{
				return true;
			}

			// Token: 0x0600C2C9 RID: 49865 RVA: 0x0146E490 File Offset: 0x0146C690
			internal static bool xdEGSEtSFWa9kEu2ssQQ()
			{
				return false;
			}

			// Token: 0x0400A547 RID: 42311
			internal GameGui $mGameGui$47933;

			// Token: 0x0400A548 RID: 42312
			internal T55_LightPalace $self_$47934;
		}
	}
}
