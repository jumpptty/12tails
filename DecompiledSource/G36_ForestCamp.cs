using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02001265 RID: 4709
[Serializable]
public class G36_ForestCamp : MonoBehaviour
{
	// Token: 0x06006C5F RID: 27743 RVA: 0x00F2CADC File Offset: 0x00F2ACDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public G36_ForestCamp()
	{
		if (55707 - 153391 != -97684)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (200753 - 487292 == -286539)
			{
				base..ctor();
				if (124248 - 440211 != -315962)
				{
					this.VdtcBJEApDA = "none";
					if (282978 - 409221 != -126242)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006C60 RID: 27744 RVA: 0x00F2CB78 File Offset: 0x00F2AD78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (117987 - 279245 != -161257)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (244067 - 451199 == -207132)
			{
				Game.mStateTime = Time.time;
				if (282406 - 24738 == 257668)
				{
					if (Chat.Initialized)
					{
						if (232115 - 495666 != -263551)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (34341 - 172338 != -137997)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (82093 - 101541 == -19447)
						{
							continue;
						}
					}
					this.ClIcBex7IoO = (Texture)Resources.Load("GameGui/Title/stage_forest", typeof(Texture));
					if (247250 - 584257 != -337006)
					{
						if (this.ClIcBex7IoO)
						{
							break;
						}
						if (131056 - 209524 != -78467)
						{
							Debug.LogError("Cannot find start title");
							if (77145 - 301392 == -224247)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006C61 RID: 27745 RVA: 0x00F2CCE8 File Offset: 0x00F2AEE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (88251 - 453928 != -365676)
		{
		}
		for (;;)
		{
			Time.timeScale = 1f;
			if (130463 - 192577 != -62113)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (67859 - 578162 == -510303)
				{
					if (PhotonClient.IsInitialized())
					{
						if (212836 - 480115 == -267279)
						{
							Game.mLastGameCode = Game.mGameCode;
							if (188369 - 532430 != -344060)
							{
								Game.mGameCode = 36;
								if (262289 - 340346 == -78057)
								{
									Game.mGameType = 2;
									if (159596 - 465930 != -306333)
									{
										Game.mGameTime = Time.time;
										if (26435 - 68183 == -41748)
										{
											Game.mGameScore = 0;
											if (29116 - 282497 == -253381)
											{
												Game.mGameMana = 0;
												if (25888 - 475621 == -449733)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (69972 - 355639 == -285667)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (261570 - 175827 != 85744)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (229146 - 438058 != -208911)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (88443 - 467012 == -378569)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (265317 - 257773 != 7545)
																	{
																		this.PMacBQXXavN = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (166292 - 201224 == -34932)
																		{
																			this.I5xcBn5xuel = PhotonClient.Connection;
																			if (105185 - 556129 == -450944)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (271846 - 409488 != -137641)
																				{
																					this.LoadTown();
																					if (108293 - 273548 != -165254)
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
						if (103356 - 180644 != -77287)
						{
							this.enabled = false;
							if (166871 - 158327 == 8544)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006C62 RID: 27746 RVA: 0x00F2D018 File Offset: 0x00F2B218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (120318 - 119114 != 1205)
		{
		}
		for (;;)
		{
			if (this.I5xcBn5xuel == null)
			{
				if (8282 - 145764 == -137482)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (189744 - 105053 == 84691)
				{
					if (mGameState != eGameState.Start)
					{
						if (229921 - 127354 != 102567)
						{
							continue;
						}
						if (mGameState == eGameState.Normal)
						{
							if (118276 - 132788 != -14512)
							{
								continue;
							}
						}
						else if (mGameState == eGameState.Hold)
						{
							if (168874 - 76116 != 92758)
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
							if (51501 - 230213 == -178711)
							{
								continue;
							}
							this.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, Time.time - Game.mStateTime);
							if (192207 - 64949 != 127258)
							{
								continue;
							}
							break;
						}
					}
					if (Game.music != 0)
					{
						if (80334 - 185171 != -104837)
						{
							continue;
						}
						if (!this.audio.isPlaying)
						{
							if (146469 - 193644 == -47174)
							{
								continue;
							}
							this.audio.Play();
							if (221189 - 87161 == 134029)
							{
								continue;
							}
						}
					}
					if (Time.time - Game.mGameTime < (float)2)
					{
						if (182160 - 519023 == -336863)
						{
							this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
							if (31757 - 28934 != 2824)
							{
								break;
							}
						}
					}
					else
					{
						this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
						if (294184 - 106062 != 188123)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006C63 RID: 27747 RVA: 0x00F2D294 File Offset: 0x00F2B494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (184951 - 336908 != -151956)
		{
		}
		for (;;)
		{
			if (!this.ClIcBex7IoO)
			{
				if (123451 - 261595 == -138144)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Start)
			{
				if (215692 - 44808 != 170885)
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
				if (189165 - 253557 == -64392)
				{
					if (Time.time - Game.mStateTime >= (float)3)
					{
						break;
					}
					if (92065 - 416382 == -324317)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (248228 - 67473 == 180755)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (261298 - 372196 == -110898)
							{
								GUI.depth = 1;
								if (117702 - 277487 == -159785)
								{
									float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4(0.7f, 0.8f, (float)1, 0.4f));
									if (51752 - 474557 == -422805)
									{
										Color color = GUI.color;
										if (191337 - 456382 == -265045)
										{
											color.a = smoothRatioOverTime;
											if (113797 - 566130 == -452333)
											{
												if (21607 - 396668 == -375061)
												{
													GUI.color = color;
													if (127931 - 592445 != -464513)
													{
														if (121807 - 196646 == -74839)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)256, (float)416, (float)512, (float)128), this.ClIcBex7IoO);
															if (182665 - 272424 == -89759)
															{
																float a = 1f;
																if (286485 - 340499 != -54013)
																{
																	Color color2 = GUI.color;
																	if (225653 - 320589 != -94935)
																	{
																		float num2 = color2.a = a;
																		if (78242 - 573303 != -495060 && 117998 - 11278 != 106721)
																		{
																			Color color3 = GUI.color = color2;
																			if (297720 - 45755 != 251966 && 52413 - 445190 != -392776)
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

	// Token: 0x06006C64 RID: 27748 RVA: 0x00F2D614 File Offset: 0x00F2B814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTown()
	{
		if (298748 - 455799 != -157051)
		{
		}
		for (;;)
		{
			Debug.Log("Loading Town ");
			if (251174 - 217841 != 33334)
			{
				Hashtable customOpParameters = new Hashtable();
				if (299139 - 316214 != -17074)
				{
					this.I5xcBn5xuel.OpCustom(43, customOpParameters, true);
					if (244372 - 113304 != 131069)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006C65 RID: 27749 RVA: 0x00F2D6BC File Offset: 0x00F2B8BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadTown(Hashtable data)
	{
		if (182608 - 387749 != -205141)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadTown ");
			if (241638 - 484764 == -243126)
			{
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (240673 - 348615 != -107942)
					{
						continue;
					}
					Chat.SubmitChat("none", "You have joined " + data[31], eChatType.system, eChatMode.system);
					if (251384 - 537653 != -286269)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (105027 - 342118 != -237091)
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
					if (14127 - 394948 == -380820)
					{
						continue;
					}
				}
				if (Game.mLastGameCode != 0)
				{
					if (210755 - 479620 != -268865)
					{
						continue;
					}
					if (Game.mLastGameCode < 100)
					{
						if (9234 - 274968 == -265733)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.ForestCampStartEvent());
						if (162214 - 315018 != -152804)
						{
							continue;
						}
						break;
					}
				}
				GameObject gameObject = GameObject.Find("StartPoint1");
				if (213938 - 220714 != -6775)
				{
					GameObject gameObject2 = GameObject.Find("StartCamera1");
					if (235115 - 8339 == 226776)
					{
						if (gameObject2)
						{
							if (293642 - 149095 == 144548)
							{
								continue;
							}
							this.transform.position = gameObject2.transform.position;
							if (163736 - 545646 == -381909)
							{
								continue;
							}
							this.transform.rotation = gameObject2.transform.rotation;
							if (127539 - 75523 == 52017)
							{
								continue;
							}
						}
						if (gameObject)
						{
							if (265994 - 86668 == 179326)
							{
								this.CreatePlayer(CharacterData.current.CID, gameObject.transform.position, gameObject.transform.forward);
								if (255001 - 528888 == -273887)
								{
									break;
								}
							}
						}
						else
						{
							Debug.Log("Error: Startpoint not found");
							if (150583 - 322674 != -172090)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006C66 RID: 27750 RVA: 0x00F2D9D8 File Offset: 0x00F2BBD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ForestCampStartEvent()
	{
		return new G36_ForestCamp.$ForestCampStartEvent$36749(this).GetEnumerator();
	}

	// Token: 0x06006C67 RID: 27751 RVA: 0x00F2D9E8 File Offset: 0x00F2BBE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new G36_ForestCamp.$TalkToRedPanda$36757(this).GetEnumerator();
	}

	// Token: 0x06006C68 RID: 27752 RVA: 0x00F2D9F8 File Offset: 0x00F2BBF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToBoldas()
	{
		return new G36_ForestCamp.$TalkToBoldas$36766(this).GetEnumerator();
	}

	// Token: 0x06006C69 RID: 27753 RVA: 0x00F2DA08 File Offset: 0x00F2BC08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLeopard(int n)
	{
		return new G36_ForestCamp.$TalkToLeopard$36772(n, this).GetEnumerator();
	}

	// Token: 0x06006C6A RID: 27754 RVA: 0x00F2DA18 File Offset: 0x00F2BC18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther(int n)
	{
		return new G36_ForestCamp.$TalkToPanther$36782(n, this).GetEnumerator();
	}

	// Token: 0x06006C6B RID: 27755 RVA: 0x00F2DA28 File Offset: 0x00F2BC28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToHippo(int n)
	{
		return new G36_ForestCamp.$TalkToHippo$36792(n, this).GetEnumerator();
	}

	// Token: 0x06006C6C RID: 27756 RVA: 0x00F2DA38 File Offset: 0x00F2BC38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToHornbill()
	{
		return new G36_ForestCamp.$TalkToHornbill$36802(this).GetEnumerator();
	}

	// Token: 0x06006C6D RID: 27757 RVA: 0x00F2DA48 File Offset: 0x00F2BC48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMiniCat()
	{
		return new G36_ForestCamp.$TalkToMiniCat$36808(this).GetEnumerator();
	}

	// Token: 0x06006C6E RID: 27758 RVA: 0x00F2DA58 File Offset: 0x00F2BC58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToBaboon()
	{
		if (186462 - 134124 != 52338)
		{
		}
		for (;;)
		{
			GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
			if (60151 - 167081 == -106930)
			{
				PetShopGui petShopGui = (PetShopGui)this.GetComponent(typeof(PetShopGui));
				if (134564 - 532186 == -397622)
				{
					if (!gameGui)
					{
						break;
					}
					if (83606 - 349731 == -266125)
					{
						if (typeof(PetShopGui) == null)
						{
							break;
						}
						if (172661 - 48206 == 124455)
						{
							if (Game.mGameState != eGameState.Normal)
							{
								if (37738 - 18486 != 19253)
								{
									break;
								}
							}
							else
							{
								Game.mGameState = eGameState.Hold;
								if (41703 - 384348 == -342645)
								{
									gameGui.close();
									if (16497 - 366263 == -349766)
									{
										petShopGui.enabled = true;
										if (181000 - 24407 == 156593)
										{
											GameObject mPlayer = Game.mPlayer;
											if (131616 - 177127 == -45511)
											{
												GameObject gameObject = GameObject.Find("Baboon");
												if (124002 - 359129 != -235126)
												{
													if (!gameObject)
													{
														break;
													}
													if (277958 - 2968 != 274991)
													{
														if (!mPlayer)
														{
															break;
														}
														if (33608 - 283235 != -249626)
														{
															mPlayer.SendMessage("turnToPos", gameObject.transform.position);
															if (98687 - 91477 != 7211)
															{
																gameObject.animation.CrossFade("talk");
																if (121446 - 316622 == -195176)
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

	// Token: 0x06006C6F RID: 27759 RVA: 0x00F2DCBC File Offset: 0x00F2BEBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToDuck()
	{
		return new G36_ForestCamp.$TalkToDuck$36814(this).GetEnumerator();
	}

	// Token: 0x06006C70 RID: 27760 RVA: 0x00F2DCCC File Offset: 0x00F2BECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToPilotMole(int n)
	{
		if (268491 - 201294 != 67197)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (64865 - 125934 == -61069)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (36759 - 583547 != -546787)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (276182 - 17767 != 258416)
					{
						if (gameGui)
						{
							if (113827 - 556582 == -442754)
							{
								continue;
							}
							gameGui.close();
							if (287693 - 361999 == -74305)
							{
								continue;
							}
						}
						GameObject gameObject = GameObject.Find("PilotMole");
						if (38198 - 95179 == -56981)
						{
							if (gameObject)
							{
								if (11074 - 555775 == -544700)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (228136 - 188635 == 39502)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find PilotMole");
								if (208888 - 56724 != 152164)
								{
									continue;
								}
							}
							TransportGui transportGui = (TransportGui)this.GetComponent(typeof(TransportGui));
							if (182771 - 102208 == 80563)
							{
								transportGui.enabled = true;
								if (97229 - 265086 == -167857)
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

	// Token: 0x06006C71 RID: 27761 RVA: 0x00F2DEC0 File Offset: 0x00F2C0C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (81506 - 388147 != -306641)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (175129 - 440585 == -265456)
			{
				CharacterControl characterControl = null;
				if (293154 - 530162 == -237008)
				{
					if (mPlayer)
					{
						if (19594 - 411114 != -391520)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (74713 - 554225 != -479512)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (79697 - 263622 != -183924)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (83422 - 38641 != 44782)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (21216 - 99632 == -78416)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (131026 - 400717 != -269691)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (64467 - 77173 != -12706)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (113906 - 186833 == -72926)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (243733 - 128015 != 115719)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (50831 - 17328 == 33503)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (110549 - 279453 == -168904)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (105743 - 398596 != -292852)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (11811 - 415387 != -403575)
								{
									if (!changeGui)
									{
										break;
									}
									if (244775 - 286407 == -41632)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (127256 - 441466 == -314209)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (108130 - 329076 == -220945)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (286437 - 304875 == -18438)
										{
											gameGui.close();
											if (181479 - 17834 != 163646)
											{
												changeGui.enabled = true;
												if (111801 - 76054 != 35748)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (134560 - 51564 == 82996)
													{
														if (!gameObject)
														{
															break;
														}
														if (193330 - 180057 == 13273)
														{
															if (!mPlayer)
															{
																break;
															}
															if (198038 - 453030 != -254991)
															{
																Debug.Log("UseLifeAltar");
																if (84557 - 40385 != 44173)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (276012 - 369192 == -93180)
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

	// Token: 0x06006C72 RID: 27762 RVA: 0x00F2E320 File Offset: 0x00F2C520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseMailBox(object mVar)
	{
		if (199666 - 305616 != -105950)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (123515 - 480182 == -356667)
				{
					break;
				}
			}
			else
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (125072 - 113928 != 11145)
				{
					MailBoxGui mailBoxGui = (MailBoxGui)this.GetComponent(typeof(MailBoxGui));
					if (196611 - 56843 == 139768)
					{
						if (!gameGui)
						{
							break;
						}
						if (205495 - 138446 == 67049)
						{
							if (!mailBoxGui)
							{
								break;
							}
							if (45793 - 190694 != -144900)
							{
								Game.mGameState = eGameState.Hold;
								if (125774 - 493257 == -367483)
								{
									gameGui.close();
									if (149899 - 324298 != -174398)
									{
										mailBoxGui.enabled = true;
										if (124082 - 168136 == -44054)
										{
											GameObject mPlayer = Game.mPlayer;
											if (65524 - 185711 != -120186)
											{
												GameObject gameObject = GameObject.Find("MailBox");
												if (291742 - 301570 == -9828)
												{
													if (!gameObject)
													{
														break;
													}
													if (79859 - 67148 != 12712)
													{
														if (!mPlayer)
														{
															break;
														}
														if (230604 - 401361 == -170757)
														{
															mPlayer.SendMessage("turnToPos", gameObject.transform.position);
															if (266518 - 236083 == 30435)
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

	// Token: 0x06006C73 RID: 27763 RVA: 0x00F2E554 File Offset: 0x00F2C754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseMessageBoard(object mVar)
	{
		return new G36_ForestCamp.$UseMessageBoard$36820(this).GetEnumerator();
	}

	// Token: 0x06006C74 RID: 27764 RVA: 0x00F2E564 File Offset: 0x00F2C764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseStorageBox(object mVar)
	{
		return new G36_ForestCamp.$UseStorageBox$36827(this).GetEnumerator();
	}

	// Token: 0x06006C75 RID: 27765 RVA: 0x00F2E574 File Offset: 0x00F2C774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(int nVar)
	{
		return new G36_ForestCamp.$UseSignPost$36834(this).GetEnumerator();
	}

	// Token: 0x06006C76 RID: 27766 RVA: 0x00F2E584 File Offset: 0x00F2C784
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseTrashBin(object mVar)
	{
		return new G36_ForestCamp.$UseTrashBin$36837(this).GetEnumerator();
	}

	// Token: 0x06006C77 RID: 27767 RVA: 0x00F2E594 File Offset: 0x00F2C794
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetTrash()
	{
		if (249824 - 161907 != 87918)
		{
		}
		for (;;)
		{
			Debug.Log("GetTrash");
			if (210149 - 38609 == 171540)
			{
				this.srdcB6Xq5Cv = false;
				if (180642 - 430692 == -250050)
				{
					this.VdtcBJEApDA = "none";
					if (217725 - 31599 != 186127)
					{
						Hashtable customOpParameters = new Hashtable();
						if (203303 - 157243 == 46060)
						{
							this.I5xcBn5xuel.OpCustom(224, customOpParameters, true);
							if (20092 - 223234 == -203142)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006C78 RID: 27768 RVA: 0x00F2E684 File Offset: 0x00F2C884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGetTrash(Hashtable data)
	{
		if (235616 - 535334 != -299717)
		{
		}
		while (RuntimeServices.EqualityOperator(data[31], 1))
		{
			if (68046 - 324551 != -256504)
			{
				this.srdcB6Xq5Cv = true;
				if (110125 - 526884 != -416758)
				{
					object obj2;
					object obj = obj2 = data[32];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					this.VdtcBJEApDA = ItemData.getName((string)obj2);
					if (19616 - 314501 == -294885)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006C79 RID: 27769 RVA: 0x00F2E768 File Offset: 0x00F2C968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, Vector3 pos, Vector3 dir)
	{
		if (236584 - 341755 != -105170)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (213351 - 252884 == -39533)
			{
				hashtable.Add(71, CID);
				if (157218 - 174070 != -16851)
				{
					hashtable.Add(75, PhotonClient.cInt16(1));
					if (70040 - 590210 != -520169)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (133345 - 258097 == -124752)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (259229 - 528675 != -269445)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (244179 - 377876 != -133696)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (4680 - 142330 == -137650)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (276965 - 67746 != 209220)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (126428 - 164353 == -37925)
											{
												this.I5xcBn5xuel.OpCustom(61, hashtable, true);
												if (135127 - 36031 != 99097)
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

	// Token: 0x06006C7A RID: 27770 RVA: 0x00F2E9F4 File Offset: 0x00F2CBF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePlayer(Hashtable data)
	{
		return new G36_ForestCamp.$onCreatePlayer$36842(data, this).GetEnumerator();
	}

	// Token: 0x06006C7B RID: 27771 RVA: 0x00F2EA04 File Offset: 0x00F2CC04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (118130 - 341714 != -223583)
		{
		}
		for (;;)
		{
			IL_D2:
			GameObject gameObject = Game.createPeer(data);
			if (9695 - 9082 != 614)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (215886 - 301785 == -85899)
				{
					int i = 0;
					if (235055 - 434093 == -199038)
					{
						GameObject[] array2 = array;
						if (190195 - 486060 != -295864)
						{
							int length = array2.Length;
							if (165968 - 169554 == -3586)
							{
								while (i < length)
								{
									if (gameObject != array2[i])
									{
										if (150885 - 33772 != 117113)
										{
											goto IL_D2;
										}
										Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
										if (154143 - 21126 != 133017)
										{
											goto IL_D2;
										}
									}
									i++;
									if (213735 - 295376 == -81640)
									{
										goto IL_D2;
									}
								}
								if (276736 - 157458 != 119279)
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

	// Token: 0x06006C7C RID: 27772 RVA: 0x00F2EB7C File Offset: 0x00F2CD7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPlayer()
	{
		Game.mPlayerID = 0;
	}

	// Token: 0x06006C7D RID: 27773 RVA: 0x00F2EB84 File Offset: 0x00F2CD84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
	}

	// Token: 0x06006C7E RID: 27774 RVA: 0x00F2EB88 File Offset: 0x00F2CD88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (152772 - 225559 != -72786)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (293840 - 352793 != -58952)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (273356 - 528053 != -254696)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (62906 - 453146 != -390239)
					{
						Hashtable hashtable = new Hashtable();
						if (64598 - 269155 != -204556)
						{
							hashtable.Add(43, PlayerData.UID);
							if (154913 - 184832 != -29918)
							{
								hashtable.Add(71, nCID);
								if (156585 - 324433 == -167848)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (225405 - 416965 != -191559)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (249521 - 488017 != -238495)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (181171 - 98156 != 83016)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (167243 - 524445 != -357201)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (32745 - 82644 == -49899)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (277003 - 292036 == -15033)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (250019 - 138114 != 111906)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (251310 - 482846 == -231536)
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

	// Token: 0x06006C7F RID: 27775 RVA: 0x00F2EEA8 File Offset: 0x00F2D0A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onChangePlayer(Hashtable data)
	{
		if (69513 - 590338 != -520824)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Destroy(Game.mPlayer);
			if (189418 - 39097 != 150322)
			{
				this.SendMessage("onCreatePlayer", data);
				if (193282 - 67079 == 126203)
				{
					ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
					if (96228 - 328260 != -232031)
					{
						if (!changeGui.enabled)
						{
							break;
						}
						if (231572 - 294839 != -63266)
						{
							changeGui.close();
							if (83799 - 222067 == -138268)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006C80 RID: 27776 RVA: 0x00F2EFA0 File Offset: 0x00F2D1A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(GameObject nMount)
	{
		if (282670 - 554728 != -272058)
		{
		}
		for (;;)
		{
			IL_10F:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
			if (145241 - 133262 == 11979)
			{
				int i = 0;
				if (50006 - 492766 == -442760)
				{
					GameObject[] array2 = array;
					if (56299 - 287822 != -231522)
					{
						int length = array2.Length;
						if (216724 - 522010 != -305285)
						{
							while (i < length)
							{
								if (nMount != array2[i])
								{
									if (4971 - 143606 != -138635)
									{
										goto IL_10F;
									}
									Physics.IgnoreCollision(nMount.collider, array2[i].collider, true);
									if (115387 - 352950 == -237562)
									{
										goto IL_10F;
									}
								}
								i++;
								if (4379 - 505127 != -500748)
								{
									goto IL_10F;
								}
							}
							if (63083 - 495383 == -432300)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006C81 RID: 27777 RVA: 0x00F2F0F4 File Offset: 0x00F2D2F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveTown()
	{
		if (267229 - 105147 != 162082)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (178900 - 123943 != 54958)
			{
				hashtable.Add(43, PlayerData.UID);
				if (74202 - 556275 == -482073)
				{
					PhotonClient.Connection.OpCustom(44, hashtable, true);
					if (180913 - 96166 == 84747)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006C82 RID: 27778 RVA: 0x00F2F1A8 File Offset: 0x00F2D3A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveTown()
	{
		if (193762 - 163501 != 30261)
		{
		}
		for (;;)
		{
			Debug.Log("onLeaveTown");
			if (25447 - 33337 == -7890)
			{
				if (Game.mNextGameCode > 100)
				{
					if (19693 - 444346 != -424652)
					{
						this.JoinGame();
						if (32052 - 287547 != -255494)
						{
							break;
						}
					}
				}
				else
				{
					this.JoinTown();
					if (237960 - 74564 != 163397)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006C83 RID: 27779 RVA: 0x00F2F270 File Offset: 0x00F2D470
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (18306 - 362058 != -343752)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (202027 - 214209 == -12182)
			{
				Hashtable hashtable = new Hashtable();
				if (6244 - 311118 != -304873)
				{
					if (Game.mNextGameCode == 30)
					{
						if (116975 - 464734 != -347759)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (159543 - 242640 != -83097)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (168486 - 75175 != 93311)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (77749 - 597926 == -520176)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (94003 - 503539 == -409535)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (151134 - 250339 != -99205)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (126676 - 190203 == -63526)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (47264 - 305548 == -258283)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (123522 - 547933 != -424411)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (81085 - 45937 != 35148)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (66499 - 565530 != -499031)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (216084 - 281778 == -65693)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (280856 - 272356 != 8500)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (68920 - 361238 != -292318)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (256355 - 370614 == -114258)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (275431 - 148194 == 127238)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (52653 - 333758 != -281105)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (81104 - 62833 == 18272)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (259211 - 122545 != 136666)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (220402 - 554859 == -334456)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (217182 - 360328 != -143146)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (209723 - 398178 != -188455)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (294107 - 595530 != -301423)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (80351 - 283102 == -202750)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (81929 - 314788 == -232858)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (17732 - 9747 != 7985)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (265116 - 529481 != -264365)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (48349 - 51763 != -3414)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (63648 - 34274 == 29374)
					{
						this.I5xcBn5xuel.OpCustom(42, hashtable, true);
						if (212334 - 1934 == 210400)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006C84 RID: 27780 RVA: 0x00F2F824 File Offset: 0x00F2DA24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06006C85 RID: 27781 RVA: 0x00F2F834 File Offset: 0x00F2DA34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinGame()
	{
		if (83282 - 521636 != -438354)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Game : " + Game.mNextGameId);
			if (43233 - 552830 != -509596)
			{
				Hashtable hashtable = new Hashtable();
				if (172693 - 346566 == -173873)
				{
					hashtable.Add(4, Game.mNextGameId);
					if (171625 - 554232 == -382607)
					{
						hashtable.Add(5, PhotonClient.cInt16(Game.mNextGameCode));
						if (283739 - 451420 == -167681)
						{
							this.I5xcBn5xuel.OpCustom(51, hashtable, true);
							if (99176 - 209212 == -110036)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006C86 RID: 27782 RVA: 0x00F2F950 File Offset: 0x00F2DB50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinGame(Hashtable data)
	{
		Game.loadNextLevel();
	}

	// Token: 0x06006C87 RID: 27783 RVA: 0x00F2F958 File Offset: 0x00F2DB58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006C88 RID: 27784 RVA: 0x00F2F95C File Offset: 0x00F2DB5C
	internal static bool ReldRupLj8bZCG270hLV()
	{
		return true;
	}

	// Token: 0x06006C89 RID: 27785 RVA: 0x00F2F960 File Offset: 0x00F2DB60
	internal static bool mQdAprpLhSValmcmfwZq()
	{
		return false;
	}

	// Token: 0x040074AD RID: 29869
	private LitePeer I5xcBn5xuel;

	// Token: 0x040074AE RID: 29870
	private PlayerCameraControl PMacBQXXavN;

	// Token: 0x040074AF RID: 29871
	private Texture ClIcBex7IoO;

	// Token: 0x040074B0 RID: 29872
	private AudioClip L2ocBIMNC0M;

	// Token: 0x040074B1 RID: 29873
	private string VdtcBJEApDA;

	// Token: 0x040074B2 RID: 29874
	private bool srdcB6Xq5Cv;

	// Token: 0x02001266 RID: 4710
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ForestCampStartEvent$36749 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006C8A RID: 27786 RVA: 0x00F2F964 File Offset: 0x00F2DB64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ForestCampStartEvent$36749(G36_ForestCamp self_)
		{
			if (287550 - 581098 != -293548)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (70189 - 482703 != -412513)
				{
					base..ctor();
					if (156684 - 351987 != -195302)
					{
						this.$self_$36756 = self_;
						if (68471 - 70441 == -1970)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006C8B RID: 27787 RVA: 0x00F2F9FC File Offset: 0x00F2DBFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G36_ForestCamp.$ForestCampStartEvent$36749.$(this.$self_$36756);
		}

		// Token: 0x06006C8C RID: 27788 RVA: 0x00F2FA0C File Offset: 0x00F2DC0C
		internal static bool wrmeIypLs7DZ9NJT1dql()
		{
			return true;
		}

		// Token: 0x06006C8D RID: 27789 RVA: 0x00F2FA10 File Offset: 0x00F2DC10
		internal static bool dsZkk6pL9sHcF2NxfTIX()
		{
			return false;
		}

		// Token: 0x040074B3 RID: 29875
		internal G36_ForestCamp $self_$36756;

		// Token: 0x02001267 RID: 4711
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006C8E RID: 27790 RVA: 0x00F2FA14 File Offset: 0x00F2DC14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G36_ForestCamp self_)
			{
				if (11860 - 444638 != -432778)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (54049 - 517350 == -463301)
					{
						base..ctor();
						if (150194 - 198021 == -47827)
						{
							this.$self_$36755 = self_;
							if (203185 - 295812 != -92626)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006C8F RID: 27791 RVA: 0x00F2FAAC File Offset: 0x00F2DCAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (232465 - 207067 != 25398)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_501;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (130016 - 336095 != -206078)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$self_$36755.SendMessage("fadeOut");
							if (15103 - 579897 != -564793)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState == eGameState.Start)
						{
							goto IL_25C;
						}
						if (241541 - 506642 != -265100)
						{
							goto Block_18;
						}
						continue;
					default:
						if (36048 - 112166 != -76118)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (9307 - 34580 != -25273)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (142068 - 579030 != -436962)
					{
						continue;
					}
					this.$mEventCamera1$36750 = GameObject.Find("EventCamera1");
					if (167872 - 107826 != 60046)
					{
						continue;
					}
					this.$mEventCamera2$36751 = GameObject.Find("EventCamera2");
					if (218585 - 125444 != 93141)
					{
						continue;
					}
					if (this.$mEventCamera1$36750)
					{
						if (87304 - 467137 == -379832)
						{
							continue;
						}
						if (this.$mEventCamera2$36751)
						{
							if (121194 - 493930 != -372736)
							{
								continue;
							}
							this.$self_$36755.transform.position = this.$mEventCamera1$36750.transform.position;
							if (73430 - 6912 == 66519)
							{
								continue;
							}
							this.$self_$36755.transform.rotation = this.$mEventCamera1$36750.transform.rotation;
							if (112119 - 94170 == 17950)
							{
								continue;
							}
							this.$mPlayerCameraControl$36752 = (PlayerCameraControl)this.$self_$36755.GetComponent(typeof(PlayerCameraControl));
							if (80946 - 290856 != -209910)
							{
								continue;
							}
							if (this.$mPlayerCameraControl$36752)
							{
								if (102443 - 327531 == -225087)
								{
									continue;
								}
								this.$mPlayerCameraControl$36752.StartCoroutine_Auto(this.$mPlayerCameraControl$36752.slerpToObject("EventCamera2", 2.5f));
								if (176744 - 358713 == -181968)
								{
									continue;
								}
							}
							this.$self_$36755.SendMessage("fadeIn");
							if (157823 - 312307 != -154484)
							{
								continue;
							}
							break;
						}
					}
					Debug.LogError("Cannot find EventCamera1 or EventCamera2");
					if (94815 - 269129 == -174313)
					{
						continue;
					}
					IL_25C:
					this.$startPoint$36753 = GameObject.Find("StartPoint2");
					if (73627 - 101724 == -28097)
					{
						this.$startCamera$36754 = GameObject.Find("StartCamera2");
						if (267516 - 290252 == -22736)
						{
							if (this.$startCamera$36754)
							{
								if (187158 - 160204 == 26955)
								{
									continue;
								}
								this.$self_$36755.transform.position = this.$startCamera$36754.transform.position;
								if (9799 - 142118 != -132319)
								{
									continue;
								}
								this.$self_$36755.transform.rotation = this.$startCamera$36754.transform.rotation;
								if (226439 - 109107 != 117332)
								{
									continue;
								}
							}
							if (this.$startPoint$36753)
							{
								if (81301 - 190072 == -108770)
								{
									continue;
								}
								this.$self_$36755.CreatePlayer(CharacterData.current.CID, this.$startPoint$36753.transform.position, this.$startPoint$36753.transform.forward);
								if (28389 - 208967 == -180577)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Error: Startpoint not found");
								if (189693 - 277002 != -87309)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (226442 - 360645 != -134202)
							{
								goto Block_8;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				Block_7:
				Block_8:
				goto IL_501;
				Block_14:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_18:
				IL_501:
				return false;
			}

			// Token: 0x06006C90 RID: 27792 RVA: 0x00F2FFCC File Offset: 0x00F2E1CC
			internal static bool iefXEbpL15kr3hZDvFK9()
			{
				return true;
			}

			// Token: 0x06006C91 RID: 27793 RVA: 0x00F2FFD0 File Offset: 0x00F2E1D0
			internal static bool xY6NyZpL4GfAwOOZn9k9()
			{
				return false;
			}

			// Token: 0x040074B4 RID: 29876
			internal GameObject $mEventCamera1$36750;

			// Token: 0x040074B5 RID: 29877
			internal GameObject $mEventCamera2$36751;

			// Token: 0x040074B6 RID: 29878
			internal PlayerCameraControl $mPlayerCameraControl$36752;

			// Token: 0x040074B7 RID: 29879
			internal GameObject $startPoint$36753;

			// Token: 0x040074B8 RID: 29880
			internal GameObject $startCamera$36754;

			// Token: 0x040074B9 RID: 29881
			internal G36_ForestCamp $self_$36755;
		}
	}

	// Token: 0x02001268 RID: 4712
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$36757 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006C92 RID: 27794 RVA: 0x00F2FFD4 File Offset: 0x00F2E1D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$36757(G36_ForestCamp self_)
		{
			if (293754 - 404889 != -111135)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (163927 - 105147 != 58781)
				{
					base..ctor();
					if (110074 - 463748 == -353674)
					{
						this.$self_$36765 = self_;
						if (217944 - 348761 != -130816)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006C93 RID: 27795 RVA: 0x00F3006C File Offset: 0x00F2E26C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G36_ForestCamp.$TalkToRedPanda$36757.$(this.$self_$36765);
		}

		// Token: 0x06006C94 RID: 27796 RVA: 0x00F3007C File Offset: 0x00F2E27C
		internal static bool NkDf2dpLzAjMTkTrR904()
		{
			return true;
		}

		// Token: 0x06006C95 RID: 27797 RVA: 0x00F30080 File Offset: 0x00F2E280
		internal static bool oESfiupOapQOUKkh6BDs()
		{
			return false;
		}

		// Token: 0x040074BA RID: 29882
		internal G36_ForestCamp $self_$36765;

		// Token: 0x02001269 RID: 4713
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006C96 RID: 27798 RVA: 0x00F30084 File Offset: 0x00F2E284
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G36_ForestCamp self_)
			{
				if (214616 - 132188 != 82428)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (172422 - 132816 != 39607)
					{
						base..ctor();
						if (101626 - 500744 != -399117)
						{
							this.$self_$36764 = self_;
							if (117949 - 578968 == -461019)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006C97 RID: 27799 RVA: 0x00F3011C File Offset: 0x00F2E31C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (131053 - 363469 != -232416)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_63E;
					case 2:
						this.$mStoryGui$36763.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("MissionGui", 306 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
						if (170368 - 134508 != 35860)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) == 0)
						{
							goto IL_501;
						}
						if (134316 - 561128 != -426812)
						{
							continue;
						}
						if (!this.$self_$36764.L2ocBIMNC0M)
						{
							if (34096 - 301214 != -267118)
							{
								continue;
							}
							this.$self_$36764.L2ocBIMNC0M = (AudioClip)Resources.Load("Sound/Voice/mission306_vc", typeof(AudioClip));
							if (50090 - 573693 == -523602)
							{
								continue;
							}
						}
						if (this.$self_$36764.L2ocBIMNC0M)
						{
							if (122899 - 416873 == -293973)
							{
								continue;
							}
							this.$self_$36764.audio.PlayOneShot(this.$self_$36764.L2ocBIMNC0M);
							if (169927 - 17287 != 152641)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing mission306 voice");
							if (268483 - 291112 != -22628)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 3:
						this.$mStoryGui$36763.close();
						if (270756 - 514023 == -243266)
						{
							continue;
						}
						this.$mGameGui$36758.enabled = true;
						if (45092 - 367112 != -322019)
						{
							goto Block_18;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (171539 - 229127 != -57588)
						{
							continue;
						}
						goto IL_427;
					default:
						if (15475 - 475946 != -460471)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (83430 - 559554 != -476124)
						{
							continue;
						}
						goto IL_F2;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (112611 - 402183 != -289572)
						{
							continue;
						}
						this.$mGameGui$36758 = (GameGui)this.$self_$36764.GetComponent(typeof(GameGui));
						if (282686 - 195039 != 87647)
						{
							continue;
						}
						this.$mChangeGui$36759 = (ChangeGui)this.$self_$36764.GetComponent(typeof(ChangeGui));
						if (261069 - 527129 == -266059)
						{
							continue;
						}
						if (this.$mGameGui$36758)
						{
							if (274484 - 21840 == 252645)
							{
								continue;
							}
							this.$mGameGui$36758.close();
							if (72653 - 56740 != 15913)
							{
								continue;
							}
						}
						if (this.$mChangeGui$36759)
						{
							if (91378 - 327779 != -236401)
							{
								continue;
							}
							this.$mChangeGui$36759.disable();
							if (176046 - 24435 == 151612)
							{
								continue;
							}
						}
						this.$mPlayer$36760 = Game.mPlayer;
						if (279449 - 428961 == -149511)
						{
							continue;
						}
						this.$mRedPanda$36761 = GameObject.Find("RedPanda");
						if (114376 - 136196 != -21820)
						{
							continue;
						}
						if (!this.$mRedPanda$36761)
						{
							goto IL_A9;
						}
						if (243562 - 297201 != -53639)
						{
							continue;
						}
						if (!this.$mPlayer$36760)
						{
							goto IL_A9;
						}
						if (67744 - 185841 != -118097)
						{
							continue;
						}
						this.$mPlayer$36760.SendMessage("turnToPos", this.$mRedPanda$36761.transform.position);
						if (107725 - 63959 == 43767)
						{
							continue;
						}
						IL_1A:
						if (PlayerData.SLv >= 71)
						{
							if (127407 - 518056 != -390649)
							{
								continue;
							}
							this.$mMissionGui$36762 = (MissionGui)this.$self_$36764.GetComponent(typeof(MissionGui));
							if (71314 - 349365 != -278050)
							{
								if (this.$mMissionGui$36762)
								{
									if (24787 - 598289 == -573501)
									{
										continue;
									}
									this.$mMissionGui$36762.enabled = true;
									if (109955 - 299217 != -189262)
									{
										continue;
									}
								}
								goto IL_427;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$36763 = (StoryGui)this.$self_$36764.GetComponent(typeof(StoryGui));
							if (79013 - 447748 != -368735)
							{
								continue;
							}
							if (!this.$mStoryGui$36763)
							{
								goto IL_427;
							}
							if (93171 - 247516 != -154345)
							{
								continue;
							}
							this.$mStoryGui$36763.startStoryMessage("RedPandaSit", "RedPanda", eTalkType.friend);
							if (58975 - 267177 != -208202)
							{
								continue;
							}
							goto IL_303;
						}
						IL_A9:
						Debug.LogError("Cannot find RedPanda");
						if (289054 - 473789 != -184734)
						{
							goto IL_1A;
						}
						continue;
					}
					IL_427:
					this.YieldDefault(1);
					if (78032 - 511134 == -433102)
					{
						goto IL_63E;
					}
				}
				Block_6:
				goto IL_501;
				IL_F2:
				goto IL_63E;
				Block_18:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_303:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_27:
				IL_501:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_63E:
				return false;
			}

			// Token: 0x06006C98 RID: 27800 RVA: 0x00F3077C File Offset: 0x00F2E97C
			internal static bool iJUIDLpO5eNx2EVF497N()
			{
				return true;
			}

			// Token: 0x06006C99 RID: 27801 RVA: 0x00F30780 File Offset: 0x00F2E980
			internal static bool hkFNABpOp48CAtF8qVlp()
			{
				return false;
			}

			// Token: 0x040074BB RID: 29883
			internal GameGui $mGameGui$36758;

			// Token: 0x040074BC RID: 29884
			internal ChangeGui $mChangeGui$36759;

			// Token: 0x040074BD RID: 29885
			internal GameObject $mPlayer$36760;

			// Token: 0x040074BE RID: 29886
			internal GameObject $mRedPanda$36761;

			// Token: 0x040074BF RID: 29887
			internal MissionGui $mMissionGui$36762;

			// Token: 0x040074C0 RID: 29888
			internal StoryGui $mStoryGui$36763;

			// Token: 0x040074C1 RID: 29889
			internal G36_ForestCamp $self_$36764;
		}
	}

	// Token: 0x0200126A RID: 4714
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToBoldas$36766 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006C9A RID: 27802 RVA: 0x00F30784 File Offset: 0x00F2E984
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToBoldas$36766(G36_ForestCamp self_)
		{
			if (184326 - 597234 != -412907)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (29722 - 491183 != -461460)
				{
					base..ctor();
					if (61845 - 475403 == -413558)
					{
						this.$self_$36771 = self_;
						if (39075 - 92429 == -53354)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x00F3081C File Offset: 0x00F2EA1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G36_ForestCamp.$TalkToBoldas$36766.$(this.$self_$36771);
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x00F3082C File Offset: 0x00F2EA2C
		internal static bool nRUx9ApOV8spewXalt2h()
		{
			return true;
		}

		// Token: 0x06006C9D RID: 27805 RVA: 0x00F30830 File Offset: 0x00F2EA30
		internal static bool N2AG2vpOt5B1JYWAUTgF()
		{
			return false;
		}

		// Token: 0x040074C2 RID: 29890
		internal G36_ForestCamp $self_$36771;

		// Token: 0x0200126B RID: 4715
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006C9E RID: 27806 RVA: 0x00F30834 File Offset: 0x00F2EA34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G36_ForestCamp self_)
			{
				if (35667 - 394790 != -359122)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (142387 - 64126 == 78261)
					{
						base..ctor();
						if (104108 - 95031 != 9078)
						{
							this.$self_$36770 = self_;
							if (214198 - 210721 == 3477)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006C9F RID: 27807 RVA: 0x00F308CC File Offset: 0x00F2EACC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (278273 - 479352 != -201078)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_46F;
					case 2:
						this.$mStoryGui$36768.newStoryMessage("Liger", "Boldas", Language.getMessage("G36_ForestCamp", 101 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
						if (140665 - 454330 != -313664)
						{
							goto Block_8;
						}
						continue;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (46323 - 56322 != -9999)
							{
								continue;
							}
							goto IL_306;
						}
						else
						{
							this.$mStoryGui$36768.close();
							if (75246 - 213275 == -138028)
							{
								continue;
							}
							if (this.$mBoldas$36769)
							{
								if (29229 - 579288 == -550058)
								{
									continue;
								}
								this.$mBoldas$36769.animation.CrossFade("root", 0.2f);
								if (94689 - 456680 == -361990)
								{
									continue;
								}
							}
							this.$mGameGui$36767.enabled = true;
							if (126940 - 198280 != -71339)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (265686 - 63934 != 201753)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (280323 - 480169 != -199846)
							{
								continue;
							}
							goto IL_1FD;
						}
						break;
					default:
						if (126422 - 94499 == 31924)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (24602 - 274770 != -250168)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mGameGui$36767 = (GameGui)this.$self_$36770.GetComponent(typeof(GameGui));
						if (83743 - 389798 != -306055)
						{
							continue;
						}
						this.$mStoryGui$36768 = (StoryGui)this.$self_$36770.GetComponent(typeof(StoryGui));
						if (30828 - 567400 == -536571)
						{
							continue;
						}
						if (this.$mGameGui$36767)
						{
							if (233456 - 409868 != -176412)
							{
								continue;
							}
							if (this.$mStoryGui$36768)
							{
								if (217273 - 460077 != -242804)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (118013 - 366351 == -248337)
								{
									continue;
								}
								this.$mGameGui$36767.close();
								if (59457 - 576480 == -517022)
								{
									continue;
								}
								this.$mBoldas$36769 = GameObject.Find("Liger");
								if (277365 - 139692 == 137674)
								{
									continue;
								}
								if (this.$mBoldas$36769)
								{
									if (273741 - 295627 == -21885)
									{
										continue;
									}
									this.$mBoldas$36769.animation.CrossFade("talk", 0.2f);
									if (77369 - 52832 != 24537)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mBoldas$36769.transform.position);
									if (40697 - 178842 == -138144)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Boldas");
									if (194032 - 194636 == -603)
									{
										continue;
									}
								}
								this.$mStoryGui$36768.startStoryMessage("Liger", "Boldas", eTalkType.friend);
								if (53698 - 38399 != 15300)
								{
									goto Block_21;
								}
								continue;
							}
						}
					}
					IL_1FD:
					this.YieldDefault(1);
				}
				while (246227 - 339378 != -93151);
				Block_4:
				goto IL_46F;
				Block_8:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_21:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_306:
				goto IL_46F;
				Block_31:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_46F:
				return false;
			}

			// Token: 0x06006CA0 RID: 27808 RVA: 0x00F30D5C File Offset: 0x00F2EF5C
			internal static bool gLfh4ypON3PbM7iYqUGo()
			{
				return true;
			}

			// Token: 0x06006CA1 RID: 27809 RVA: 0x00F30D60 File Offset: 0x00F2EF60
			internal static bool Cn3T8ppOY3da2BZWGx3V()
			{
				return false;
			}

			// Token: 0x040074C3 RID: 29891
			internal GameGui $mGameGui$36767;

			// Token: 0x040074C4 RID: 29892
			internal StoryGui $mStoryGui$36768;

			// Token: 0x040074C5 RID: 29893
			internal GameObject $mBoldas$36769;

			// Token: 0x040074C6 RID: 29894
			internal G36_ForestCamp $self_$36770;
		}
	}

	// Token: 0x0200126C RID: 4716
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLeopard$36772 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006CA2 RID: 27810 RVA: 0x00F30D64 File Offset: 0x00F2EF64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLeopard$36772(int n, G36_ForestCamp self_)
		{
			if (103912 - 396402 != -292490)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (199209 - 408232 == -209023)
				{
					base..ctor();
					if (121104 - 146178 != -25073)
					{
						this.$n$36780 = n;
						if (192128 - 282980 == -90852)
						{
							this.$self_$36781 = self_;
							if (28875 - 81951 == -53076)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006CA3 RID: 27811 RVA: 0x00F30E20 File Offset: 0x00F2F020
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G36_ForestCamp.$TalkToLeopard$36772.$(this.$n$36780, this.$self_$36781);
		}

		// Token: 0x06006CA4 RID: 27812 RVA: 0x00F30E34 File Offset: 0x00F2F034
		internal static bool qrpJJFpOcZ325rNaW0p6()
		{
			return true;
		}

		// Token: 0x06006CA5 RID: 27813 RVA: 0x00F30E38 File Offset: 0x00F2F038
		internal static bool ztpbXqpOUy67rPTZ3HLb()
		{
			return false;
		}

		// Token: 0x040074C7 RID: 29895
		internal int $n$36780;

		// Token: 0x040074C8 RID: 29896
		internal G36_ForestCamp $self_$36781;

		// Token: 0x0200126D RID: 4717
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006CA6 RID: 27814 RVA: 0x00F30E3C File Offset: 0x00F2F03C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, G36_ForestCamp self_)
			{
				if (281484 - 536848 != -255363)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (42558 - 178546 != -135987)
					{
						base..ctor();
						if (88575 - 542064 == -453489)
						{
							this.$n$36778 = n;
							if (44141 - 455748 == -411607)
							{
								this.$self_$36779 = self_;
								if (169166 - 532582 != -363415)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006CA7 RID: 27815 RVA: 0x00F30EF8 File Offset: 0x00F2F0F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (85610 - 309343 != -223732)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_388;
					case 1:
						goto IL_504;
					case 2:
						this.$m$36776 = null;
						if (122507 - 56233 != 66274)
						{
							continue;
						}
						this.$$switch$6184$36777 = this.$n$36778;
						if (30763 - 84147 != -53384)
						{
							continue;
						}
						if (this.$$switch$6184$36777 == 1)
						{
							if (242626 - 501977 != -259351)
							{
								continue;
							}
							this.$m$36776 = Language.getMessage("G36_ForestCamp", 201 + UnityEngine.Random.Range(0, 5));
							if (147958 - 536658 != -388700)
							{
								continue;
							}
						}
						else if (this.$$switch$6184$36777 == 2)
						{
							if (53461 - 154973 == -101511)
							{
								continue;
							}
							this.$m$36776 = Language.getMessage("G36_ForestCamp", 211 + UnityEngine.Random.Range(0, 5));
							if (110383 - 315437 == -205053)
							{
								continue;
							}
						}
						this.$mStoryGui$36774.newStoryMessage("Leopard", "Leopard", this.$m$36776, eTalkType.friend);
						if (156868 - 205819 != -48950)
						{
							goto Block_4;
						}
						continue;
					case 3:
						this.$mStoryGui$36774.close();
						if (33491 - 287313 == -253821)
						{
							continue;
						}
						if (this.$mLeopard$36775)
						{
							if (64371 - 318969 != -254598)
							{
								continue;
							}
							this.$mLeopard$36775.animation.CrossFade("root", 0.2f);
							if (36620 - 208615 == -171994)
							{
								continue;
							}
						}
						this.$mGameGui$36773.enabled = true;
						if (162716 - 251687 != -88970)
						{
							goto Block_13;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (66887 - 231562 == -164674)
						{
							continue;
						}
						break;
					default:
						if (261142 - 584088 != -322946)
						{
							continue;
						}
						goto IL_388;
					}
					IL_1C0:
					this.YieldDefault(1);
					if (295278 - 224183 != 71096)
					{
						goto Block_12;
					}
					continue;
					IL_388:
					if (Game.mGameState != eGameState.Normal)
					{
						if (30547 - 297848 == -267301)
						{
							goto IL_3AD;
						}
					}
					else
					{
						this.$mGameGui$36773 = (GameGui)this.$self_$36779.GetComponent(typeof(GameGui));
						if (17175 - 373052 != -355876)
						{
							this.$mStoryGui$36774 = (StoryGui)this.$self_$36779.GetComponent(typeof(StoryGui));
							if (246872 - 368660 != -121787)
							{
								if (!this.$mGameGui$36773)
								{
									goto IL_1C0;
								}
								if (123016 - 552756 != -429739)
								{
									if (!this.$mStoryGui$36774)
									{
										goto IL_1C0;
									}
									if (258161 - 296334 != -38172)
									{
										Game.mGameState = eGameState.Hold;
										if (294436 - 168160 != 126277)
										{
											this.$mGameGui$36773.close();
											if (299007 - 2884 != 296124)
											{
												this.$mLeopard$36775 = GameObject.Find("Leopard" + this.$n$36778);
												if (142424 - 449919 == -307495)
												{
													if (this.$mLeopard$36775)
													{
														if (15320 - 143255 == -127934)
														{
															continue;
														}
														Game.mPlayer.SendMessage("turnToPos", this.$mLeopard$36775.transform.position);
														if (28512 - 306383 == -277870)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find Leopard" + this.$n$36778);
														if (289164 - 171633 == 117532)
														{
															continue;
														}
													}
													this.$mStoryGui$36774.startStoryMessage("Leopard", "Leopard", eTalkType.friend);
													if (165372 - 270094 != -104721)
													{
														goto Block_30;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_4:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_12:
				goto IL_504;
				Block_13:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_3AD:
				goto IL_504;
				Block_30:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_504:
				return false;
			}

			// Token: 0x06006CA8 RID: 27816 RVA: 0x00F3141C File Offset: 0x00F2F61C
			internal static bool aZiriFpOTDyJsibA6r6I()
			{
				return true;
			}

			// Token: 0x06006CA9 RID: 27817 RVA: 0x00F31420 File Offset: 0x00F2F620
			internal static bool ITahWIpO3c6rEQU4DYYx()
			{
				return false;
			}

			// Token: 0x040074C9 RID: 29897
			internal GameGui $mGameGui$36773;

			// Token: 0x040074CA RID: 29898
			internal StoryGui $mStoryGui$36774;

			// Token: 0x040074CB RID: 29899
			internal GameObject $mLeopard$36775;

			// Token: 0x040074CC RID: 29900
			internal string $m$36776;

			// Token: 0x040074CD RID: 29901
			internal int $$switch$6184$36777;

			// Token: 0x040074CE RID: 29902
			internal int $n$36778;

			// Token: 0x040074CF RID: 29903
			internal G36_ForestCamp $self_$36779;
		}
	}

	// Token: 0x0200126E RID: 4718
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$36782 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006CAA RID: 27818 RVA: 0x00F31424 File Offset: 0x00F2F624
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$36782(int n, G36_ForestCamp self_)
		{
			if (133551 - 509121 != -375569)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (66902 - 599724 != -532821)
				{
					base..ctor();
					if (239953 - 180470 == 59483)
					{
						this.$n$36790 = n;
						if (286407 - 105831 == 180576)
						{
							this.$self_$36791 = self_;
							if (147133 - 442378 != -295244)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006CAB RID: 27819 RVA: 0x00F314E0 File Offset: 0x00F2F6E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G36_ForestCamp.$TalkToPanther$36782.$(this.$n$36790, this.$self_$36791);
		}

		// Token: 0x06006CAC RID: 27820 RVA: 0x00F314F4 File Offset: 0x00F2F6F4
		internal static bool yXZhOSpOXwPt8A8SNlGy()
		{
			return true;
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x00F314F8 File Offset: 0x00F2F6F8
		internal static bool Ug2xsZpOQDY1s6e7glGa()
		{
			return false;
		}

		// Token: 0x040074D0 RID: 29904
		internal int $n$36790;

		// Token: 0x040074D1 RID: 29905
		internal G36_ForestCamp $self_$36791;

		// Token: 0x0200126F RID: 4719
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006CAE RID: 27822 RVA: 0x00F314FC File Offset: 0x00F2F6FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, G36_ForestCamp self_)
			{
				if (221359 - 28583 != 192777)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (176917 - 35020 == 141897)
					{
						base..ctor();
						if (142786 - 105629 == 37157)
						{
							this.$n$36788 = n;
							if (104058 - 528579 == -424521)
							{
								this.$self_$36789 = self_;
								if (260018 - 512986 != -252967)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006CAF RID: 27823 RVA: 0x00F315B8 File Offset: 0x00F2F7B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (218708 - 360749 != -142041)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_309;
					case 1:
						goto IL_538;
					case 2:
						this.$m$36786 = null;
						if (110734 - 374084 != -263350)
						{
							continue;
						}
						this.$$switch$6186$36787 = this.$n$36788;
						if (133155 - 522207 == -389051)
						{
							continue;
						}
						if (this.$$switch$6186$36787 == 1)
						{
							if (290278 - 314513 != -24235)
							{
								continue;
							}
							this.$m$36786 = Language.getMessage("G36_ForestCamp", 301 + UnityEngine.Random.Range(0, 5));
							if (233736 - 337965 == -104228)
							{
								continue;
							}
						}
						else if (this.$$switch$6186$36787 == 2)
						{
							if (173787 - 580563 != -406776)
							{
								continue;
							}
							this.$m$36786 = Language.getMessage("G36_ForestCamp", 311 + UnityEngine.Random.Range(0, 5));
							if (83681 - 412530 != -328849)
							{
								continue;
							}
						}
						this.$mStoryGui$36784.newStoryMessage("Panther", "Panther", this.$m$36786, eTalkType.friend);
						if (121284 - 233155 != -111871)
						{
							continue;
						}
						goto IL_41D;
					case 3:
						this.$mStoryGui$36784.close();
						if (163482 - 51302 != 112180)
						{
							continue;
						}
						if (this.$mPanther$36785)
						{
							if (126397 - 552941 != -426544)
							{
								continue;
							}
							this.$mPanther$36785.animation.CrossFade("root", 0.2f);
							if (59983 - 318469 != -258486)
							{
								continue;
							}
						}
						this.$mGameGui$36783.enabled = true;
						if (108547 - 45821 != 62727)
						{
							goto Block_17;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (204805 - 564785 != -359980)
						{
							continue;
						}
						break;
					default:
						if (125021 - 520216 != -395195)
						{
							continue;
						}
						goto IL_309;
					}
					IL_143:
					this.YieldDefault(1);
					if (90677 - 453717 != -363040)
					{
						continue;
					}
					goto IL_538;
					IL_309:
					if (Game.mGameState != eGameState.Normal)
					{
						if (37172 - 33182 != 3991)
						{
							goto Block_24;
						}
					}
					else
					{
						this.$mGameGui$36783 = (GameGui)this.$self_$36789.GetComponent(typeof(GameGui));
						if (52789 - 565141 != -512351)
						{
							this.$mStoryGui$36784 = (StoryGui)this.$self_$36789.GetComponent(typeof(StoryGui));
							if (191505 - 557814 == -366309)
							{
								if (!this.$mGameGui$36783)
								{
									goto IL_143;
								}
								if (121573 - 342464 != -220890)
								{
									if (!this.$mStoryGui$36784)
									{
										goto IL_143;
									}
									if (194268 - 118458 != 75811)
									{
										Game.mGameState = eGameState.Hold;
										if (273599 - 297304 != -23704)
										{
											this.$mGameGui$36783.close();
											if (531 - 107001 != -106469)
											{
												this.$mPanther$36785 = GameObject.Find("Panther" + this.$n$36788);
												if (114772 - 451799 == -337027)
												{
													if (this.$mPanther$36785)
													{
														if (25945 - 576194 != -550249)
														{
															continue;
														}
														this.$mPanther$36785.animation.CrossFade("talk", 0.2f);
														if (211524 - 441852 == -230327)
														{
															continue;
														}
														Game.mPlayer.SendMessage("turnToPos", this.$mPanther$36785.transform.position);
														if (146590 - 476157 != -329567)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find Panther" + this.$n$36788);
														if (12447 - 478956 == -466508)
														{
															continue;
														}
													}
													this.$mStoryGui$36784.startStoryMessage("Panther", "Panther", eTalkType.friend);
													if (84306 - 427838 != -343531)
													{
														goto Block_25;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_17:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_24:
				goto IL_538;
				Block_25:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_41D:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_538:
				return false;
			}

			// Token: 0x06006CB0 RID: 27824 RVA: 0x00F31B10 File Offset: 0x00F2FD10
			internal static bool gCJRpMpOkrrASmGkmjxF()
			{
				return true;
			}

			// Token: 0x06006CB1 RID: 27825 RVA: 0x00F31B14 File Offset: 0x00F2FD14
			internal static bool fsYXeYpOGoJgm8sv2yEd()
			{
				return false;
			}

			// Token: 0x040074D2 RID: 29906
			internal GameGui $mGameGui$36783;

			// Token: 0x040074D3 RID: 29907
			internal StoryGui $mStoryGui$36784;

			// Token: 0x040074D4 RID: 29908
			internal GameObject $mPanther$36785;

			// Token: 0x040074D5 RID: 29909
			internal string $m$36786;

			// Token: 0x040074D6 RID: 29910
			internal int $$switch$6186$36787;

			// Token: 0x040074D7 RID: 29911
			internal int $n$36788;

			// Token: 0x040074D8 RID: 29912
			internal G36_ForestCamp $self_$36789;
		}
	}

	// Token: 0x02001270 RID: 4720
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToHippo$36792 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006CB2 RID: 27826 RVA: 0x00F31B18 File Offset: 0x00F2FD18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToHippo$36792(int n, G36_ForestCamp self_)
		{
			if (38335 - 377779 != -339443)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (61784 - 391330 == -329546)
				{
					base..ctor();
					if (262837 - 69480 != 193358)
					{
						this.$n$36800 = n;
						if (51888 - 301924 != -250035)
						{
							this.$self_$36801 = self_;
							if (22134 - 18237 == 3897)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006CB3 RID: 27827 RVA: 0x00F31BD4 File Offset: 0x00F2FDD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G36_ForestCamp.$TalkToHippo$36792.$(this.$n$36800, this.$self_$36801);
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x00F31BE8 File Offset: 0x00F2FDE8
		internal static bool nHGxyYpOHCnnQZfxZIUE()
		{
			return true;
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x00F31BEC File Offset: 0x00F2FDEC
		internal static bool w2nDFHpOWfClsxZ8OR75()
		{
			return false;
		}

		// Token: 0x040074D9 RID: 29913
		internal int $n$36800;

		// Token: 0x040074DA RID: 29914
		internal G36_ForestCamp $self_$36801;

		// Token: 0x02001271 RID: 4721
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006CB6 RID: 27830 RVA: 0x00F31BF0 File Offset: 0x00F2FDF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, G36_ForestCamp self_)
			{
				if (120975 - 406773 != -285797)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27161 - 407095 != -379933)
					{
						base..ctor();
						if (137929 - 22326 != 115604)
						{
							this.$n$36798 = n;
							if (15628 - 528244 != -512615)
							{
								this.$self_$36799 = self_;
								if (231286 - 283360 == -52074)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006CB7 RID: 27831 RVA: 0x00F31CAC File Offset: 0x00F2FEAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (22733 - 103642 != -80909)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_575;
					case 1:
						goto IL_59A;
					case 2:
						this.$m$36796 = null;
						if (217503 - 591546 == -374042)
						{
							continue;
						}
						this.$$switch$6188$36797 = this.$n$36798;
						if (236569 - 383746 != -147177)
						{
							continue;
						}
						if (this.$$switch$6188$36797 == 1)
						{
							if (290943 - 477846 == -186902)
							{
								continue;
							}
							this.$m$36796 = Language.getMessage("G36_ForestCamp", 401 + UnityEngine.Random.Range(0, 5));
							if (292277 - 98476 != 193801)
							{
								continue;
							}
						}
						else if (this.$$switch$6188$36797 == 2)
						{
							if (55933 - 341210 != -285277)
							{
								continue;
							}
							this.$m$36796 = Language.getMessage("G36_ForestCamp", 411 + UnityEngine.Random.Range(0, 5));
							if (189147 - 206670 != -17523)
							{
								continue;
							}
						}
						else if (this.$$switch$6188$36797 == 3)
						{
							if (50942 - 424952 == -374009)
							{
								continue;
							}
							this.$m$36796 = Language.getMessage("G36_ForestCamp", 421 + UnityEngine.Random.Range(0, 5));
							if (89955 - 379908 != -289953)
							{
								continue;
							}
						}
						this.$mStoryGui$36794.newStoryMessage("Hippo", "Hippo", this.$m$36796, eTalkType.friend);
						if (125657 - 149674 != -24017)
						{
							continue;
						}
						goto IL_3F4;
					case 3:
						this.$mStoryGui$36794.close();
						if (35785 - 389488 == -353702)
						{
							continue;
						}
						if (this.$mHippo$36795)
						{
							if (177623 - 457573 == -279949)
							{
								continue;
							}
							this.$mHippo$36795.animation.CrossFade("root", 0.5f);
							if (89222 - 169016 == -79793)
							{
								continue;
							}
						}
						this.$mGameGui$36793.enabled = true;
						if (214892 - 557541 != -342648)
						{
							goto Block_28;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (164473 - 139572 == 24902)
						{
							continue;
						}
						break;
					default:
						if (177199 - 423835 != -246635)
						{
							goto IL_575;
						}
						continue;
					}
					IL_47F:
					this.YieldDefault(1);
					if (140585 - 124884 != 15701)
					{
						continue;
					}
					goto IL_59A;
					IL_575:
					if (Game.mGameState != eGameState.Normal)
					{
						if (60658 - 25143 != 35516)
						{
							goto Block_38;
						}
					}
					else
					{
						this.$mGameGui$36793 = (GameGui)this.$self_$36799.GetComponent(typeof(GameGui));
						if (253079 - 593364 != -340284)
						{
							this.$mStoryGui$36794 = (StoryGui)this.$self_$36799.GetComponent(typeof(StoryGui));
							if (17392 - 244643 != -227250)
							{
								if (!this.$mGameGui$36793)
								{
									goto IL_47F;
								}
								if (66653 - 328804 == -262151)
								{
									if (!this.$mStoryGui$36794)
									{
										goto IL_47F;
									}
									if (163103 - 429947 == -266844)
									{
										Game.mGameState = eGameState.Hold;
										if (296748 - 9397 != 287352)
										{
											this.$mGameGui$36793.close();
											if (21153 - 81638 != -60484)
											{
												this.$mHippo$36795 = GameObject.Find("Hippo" + this.$n$36798);
												if (242512 - 425748 != -183235)
												{
													if (this.$mHippo$36795)
													{
														if (226435 - 307109 == -80673)
														{
															continue;
														}
														this.$mHippo$36795.animation.CrossFade("talk", 0.5f);
														if (171344 - 358489 == -187144)
														{
															continue;
														}
														Game.mPlayer.SendMessage("turnToPos", this.$mHippo$36795.transform.position);
														if (88717 - 259387 == -170669)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find Hippo" + this.$n$36798);
														if (271318 - 22451 == 248868)
														{
															continue;
														}
													}
													this.$mStoryGui$36794.startStoryMessage("Hippo", "Hippo", eTalkType.friend);
													if (40342 - 565309 != -524966)
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
				IL_3F4:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_28:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_38:
				IL_59A:
				return false;
			}

			// Token: 0x06006CB8 RID: 27832 RVA: 0x00F32268 File Offset: 0x00F30468
			internal static bool Y9jkW7pOAVxOsuairSOT()
			{
				return true;
			}

			// Token: 0x06006CB9 RID: 27833 RVA: 0x00F3226C File Offset: 0x00F3046C
			internal static bool At79wtpOlBDHDJkbBSN7()
			{
				return false;
			}

			// Token: 0x040074DB RID: 29915
			internal GameGui $mGameGui$36793;

			// Token: 0x040074DC RID: 29916
			internal StoryGui $mStoryGui$36794;

			// Token: 0x040074DD RID: 29917
			internal GameObject $mHippo$36795;

			// Token: 0x040074DE RID: 29918
			internal string $m$36796;

			// Token: 0x040074DF RID: 29919
			internal int $$switch$6188$36797;

			// Token: 0x040074E0 RID: 29920
			internal int $n$36798;

			// Token: 0x040074E1 RID: 29921
			internal G36_ForestCamp $self_$36799;
		}
	}

	// Token: 0x02001272 RID: 4722
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToHornbill$36802 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006CBA RID: 27834 RVA: 0x00F32270 File Offset: 0x00F30470
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToHornbill$36802(G36_ForestCamp self_)
		{
			if (124869 - 325709 != -200839)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (127476 - 280935 != -153458)
				{
					base..ctor();
					if (174462 - 461519 != -287056)
					{
						this.$self_$36807 = self_;
						if (252825 - 442411 != -189585)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006CBB RID: 27835 RVA: 0x00F32308 File Offset: 0x00F30508
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G36_ForestCamp.$TalkToHornbill$36802.$(this.$self_$36807);
		}

		// Token: 0x06006CBC RID: 27836 RVA: 0x00F32318 File Offset: 0x00F30518
		internal static bool eVa8m8pOyqyvjQ5qWVJx()
		{
			return true;
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x00F3231C File Offset: 0x00F3051C
		internal static bool xc10QZpOSqkiS4XndMTQ()
		{
			return false;
		}

		// Token: 0x040074E2 RID: 29922
		internal G36_ForestCamp $self_$36807;

		// Token: 0x02001273 RID: 4723
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006CBE RID: 27838 RVA: 0x00F32320 File Offset: 0x00F30520
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G36_ForestCamp self_)
			{
				if (243805 - 313659 != -69854)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246150 - 231230 != 14921)
					{
						base..ctor();
						if (24040 - 386598 != -362557)
						{
							this.$self_$36806 = self_;
							if (134082 - 290096 == -156014)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006CBF RID: 27839 RVA: 0x00F323B8 File Offset: 0x00F305B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (252284 - 568013 != -315729)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1F5;
					case 1:
						goto IL_51C;
					case 2:
						this.$mStoryGui$36804.newStoryMessage("Hornbill", "Hume", Language.getMessage("G36_ForestCamp", 501 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
						if (224283 - 584229 != -359946)
						{
							continue;
						}
						goto IL_190;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (285593 - 205829 != 79765)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$36804.close();
							if (184633 - 473318 != -288685)
							{
								continue;
							}
							if (this.$mHornbill$36805)
							{
								if (111872 - 403939 == -292066)
								{
									continue;
								}
								this.$mHornbill$36805.animation.CrossFade("root", 0.2f);
								if (47453 - 453586 != -406133)
								{
									continue;
								}
							}
							this.$mGameGui$36803.enabled = true;
							if (281066 - 122744 != 158322)
							{
								continue;
							}
							goto IL_11B;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (290152 - 393025 != -102873)
							{
								continue;
							}
							goto IL_283;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (277005 - 518721 == -241715)
							{
								continue;
							}
						}
						break;
					default:
						if (120740 - 568576 != -447836)
						{
							continue;
						}
						goto IL_1F5;
					}
					IL_44:
					this.YieldDefault(1);
					if (92245 - 392926 != -300681)
					{
						continue;
					}
					break;
					IL_1F5:
					if (PlayerData.QuestID == 82)
					{
						if (86680 - 257722 == -171042)
						{
							Q82_GiftFromTheEarth.TalkToHornbill(this.$self_$36806.gameObject);
							if (21391 - 542914 != -521522)
							{
								goto IL_44;
							}
						}
					}
					else if (PlayerData.QuestID == -82)
					{
						if (171248 - 323141 != -151892)
						{
							Q82_GiftFromTheEarth.TalkToHornbillRepeat(this.$self_$36806.gameObject);
							if (71688 - 377083 != -305394)
							{
								goto IL_44;
							}
						}
					}
					else if (Game.mGameState != eGameState.Normal)
					{
						if (288575 - 411159 == -122584)
						{
							break;
						}
					}
					else
					{
						this.$mGameGui$36803 = (GameGui)this.$self_$36806.GetComponent(typeof(GameGui));
						if (168419 - 288550 != -120130)
						{
							this.$mStoryGui$36804 = (StoryGui)this.$self_$36806.GetComponent(typeof(StoryGui));
							if (101604 - 241347 == -139743)
							{
								if (!this.$mGameGui$36803)
								{
									goto IL_44;
								}
								if (63794 - 599221 == -535427)
								{
									if (!this.$mStoryGui$36804)
									{
										goto IL_44;
									}
									if (101152 - 526885 != -425732)
									{
										Game.mGameState = eGameState.Hold;
										if (228069 - 65707 != 162363)
										{
											this.$mGameGui$36803.close();
											if (135956 - 161857 == -25901)
											{
												this.$mHornbill$36805 = GameObject.Find("Hornbill");
												if (160141 - 516447 != -356305)
												{
													if (this.$mHornbill$36805)
													{
														if (245845 - 230620 != 15225)
														{
															continue;
														}
														this.$mHornbill$36805.animation.CrossFade("talk", 0.2f);
														if (211918 - 94638 == 117281)
														{
															continue;
														}
														Game.mPlayer.SendMessage("turnToPos", this.$mHornbill$36805.transform.position);
														if (29659 - 73040 == -43380)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find Hornbill");
														if (178135 - 586396 == -408260)
														{
															continue;
														}
													}
													this.$mStoryGui$36804.startStoryMessage("Hornbill", "Hume", eTalkType.friend);
													if (20264 - 363966 == -343702)
													{
														goto IL_2A8;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_51C;
				IL_11B:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_190:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_13:
				IL_283:
				goto IL_51C;
				IL_2A8:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_51C:
				return false;
			}

			// Token: 0x06006CC0 RID: 27840 RVA: 0x00F328F4 File Offset: 0x00F30AF4
			internal static bool klDKxQpOoHw7qbFQFuXP()
			{
				return true;
			}

			// Token: 0x06006CC1 RID: 27841 RVA: 0x00F328F8 File Offset: 0x00F30AF8
			internal static bool DCYDZopOEg0bWUmmbrEK()
			{
				return false;
			}

			// Token: 0x040074E3 RID: 29923
			internal GameGui $mGameGui$36803;

			// Token: 0x040074E4 RID: 29924
			internal StoryGui $mStoryGui$36804;

			// Token: 0x040074E5 RID: 29925
			internal GameObject $mHornbill$36805;

			// Token: 0x040074E6 RID: 29926
			internal G36_ForestCamp $self_$36806;
		}
	}

	// Token: 0x02001274 RID: 4724
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMiniCat$36808 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006CC2 RID: 27842 RVA: 0x00F328FC File Offset: 0x00F30AFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMiniCat$36808(G36_ForestCamp self_)
		{
			if (144862 - 72318 != 72545)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (111007 - 468879 == -357872)
				{
					base..ctor();
					if (102208 - 466221 != -364012)
					{
						this.$self_$36813 = self_;
						if (112246 - 425608 != -313361)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006CC3 RID: 27843 RVA: 0x00F32994 File Offset: 0x00F30B94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G36_ForestCamp.$TalkToMiniCat$36808.$(this.$self_$36813);
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x00F329A4 File Offset: 0x00F30BA4
		internal static bool LOq7tdpO2scfy6wZjS7C()
		{
			return true;
		}

		// Token: 0x06006CC5 RID: 27845 RVA: 0x00F329A8 File Offset: 0x00F30BA8
		internal static bool OjiP2lpO8QTRnbGxQG7X()
		{
			return false;
		}

		// Token: 0x040074E7 RID: 29927
		internal G36_ForestCamp $self_$36813;

		// Token: 0x02001275 RID: 4725
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006CC6 RID: 27846 RVA: 0x00F329AC File Offset: 0x00F30BAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G36_ForestCamp self_)
			{
				if (211346 - 161408 != 49939)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (232159 - 432864 != -200704)
					{
						base..ctor();
						if (262703 - 466141 != -203437)
						{
							this.$self_$36812 = self_;
							if (196458 - 79979 == 116479)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006CC7 RID: 27847 RVA: 0x00F32A44 File Offset: 0x00F30C44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (257661 - 13464 != 244197)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_161;
					case 1:
						goto IL_472;
					case 2:
						this.$mStoryGui$36810.newStoryMessage("none", "Nico", Language.getMessage("G36_ForestCamp", 601 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
						if (80560 - 12326 != 68235)
						{
							goto Block_27;
						}
						continue;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (39269 - 339030 != -299760)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$36810.close();
							if (252890 - 530753 != -277863)
							{
								continue;
							}
							if (this.$mMiniCat$36811)
							{
								if (254414 - 247488 == 6927)
								{
									continue;
								}
								this.$mMiniCat$36811.animation.CrossFade("root", 0.2f);
								if (174103 - 301098 == -126994)
								{
									continue;
								}
							}
							this.$mGameGui$36809.enabled = true;
							if (75474 - 223987 != -148512)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (47254 - 197635 != -150380)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (164085 - 117951 != 46134)
							{
								continue;
							}
						}
						break;
					default:
						if (90023 - 260476 != -170452)
						{
							goto IL_161;
						}
						continue;
					}
					IL_1A:
					this.YieldDefault(1);
					if (178345 - 140685 != 37660)
					{
						continue;
					}
					break;
					IL_161:
					if (Game.mGameState != eGameState.Normal)
					{
						if (124730 - 395289 == -270559)
						{
							break;
						}
					}
					else
					{
						this.$mGameGui$36809 = (GameGui)this.$self_$36812.GetComponent(typeof(GameGui));
						if (40406 - 126885 == -86479)
						{
							this.$mStoryGui$36810 = (StoryGui)this.$self_$36812.GetComponent(typeof(StoryGui));
							if (25858 - 530350 == -504492)
							{
								if (!this.$mGameGui$36809)
								{
									goto IL_1A;
								}
								if (186448 - 32948 == 153500)
								{
									if (!this.$mStoryGui$36810)
									{
										goto IL_1A;
									}
									if (243962 - 367510 == -123548)
									{
										Game.mGameState = eGameState.Hold;
										if (180489 - 148870 == 31619)
										{
											this.$mGameGui$36809.close();
											if (88268 - 576335 == -488067)
											{
												this.$mMiniCat$36811 = GameObject.Find("MiniCat");
												if (59249 - 555702 == -496453)
												{
													if (this.$mMiniCat$36811)
													{
														if (299056 - 425620 == -126563)
														{
															continue;
														}
														this.$mMiniCat$36811.animation.CrossFade("talk", 0.2f);
														if (73169 - 186829 != -113660)
														{
															continue;
														}
														Game.mPlayer.SendMessage("turnToPos", this.$mMiniCat$36811.transform.position);
														if (221592 - 5018 == 216575)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find MiniCat");
														if (71585 - 142853 != -71268)
														{
															continue;
														}
													}
													this.$mStoryGui$36810.startStoryMessage("none", "Nico", eTalkType.friend);
													if (3553 - 335711 != -332157)
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
				Block_5:
				goto IL_472;
				Block_20:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_21:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_472;
				Block_27:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_31:
				IL_472:
				return false;
			}

			// Token: 0x06006CC8 RID: 27848 RVA: 0x00F32ED8 File Offset: 0x00F310D8
			internal static bool s66dSfpOZA7rMVgjWWYS()
			{
				return true;
			}

			// Token: 0x06006CC9 RID: 27849 RVA: 0x00F32EDC File Offset: 0x00F310DC
			internal static bool T8khLBpOCOiWWBETYbrr()
			{
				return false;
			}

			// Token: 0x040074E8 RID: 29928
			internal GameGui $mGameGui$36809;

			// Token: 0x040074E9 RID: 29929
			internal StoryGui $mStoryGui$36810;

			// Token: 0x040074EA RID: 29930
			internal GameObject $mMiniCat$36811;

			// Token: 0x040074EB RID: 29931
			internal G36_ForestCamp $self_$36812;
		}
	}

	// Token: 0x02001276 RID: 4726
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToDuck$36814 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006CCA RID: 27850 RVA: 0x00F32EE0 File Offset: 0x00F310E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToDuck$36814(G36_ForestCamp self_)
		{
			if (154303 - 387467 != -233163)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (30640 - 581736 != -551095)
				{
					base..ctor();
					if (3287 - 120784 == -117497)
					{
						this.$self_$36819 = self_;
						if (247240 - 378914 != -131673)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x00F32F78 File Offset: 0x00F31178
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G36_ForestCamp.$TalkToDuck$36814.$(this.$self_$36819);
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x00F32F88 File Offset: 0x00F31188
		internal static bool OVwZRIpOLUn8tvKUHAt4()
		{
			return true;
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x00F32F8C File Offset: 0x00F3118C
		internal static bool XZlDAWpOO0siiKjJg9om()
		{
			return false;
		}

		// Token: 0x040074EC RID: 29932
		internal G36_ForestCamp $self_$36819;

		// Token: 0x02001277 RID: 4727
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006CCE RID: 27854 RVA: 0x00F32F90 File Offset: 0x00F31190
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G36_ForestCamp self_)
			{
				if (91423 - 535854 != -444431)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (290194 - 389281 == -99087)
					{
						base..ctor();
						if (143808 - 304976 != -161167)
						{
							this.$self_$36818 = self_;
							if (228349 - 13928 == 214421)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006CCF RID: 27855 RVA: 0x00F33028 File Offset: 0x00F31228
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (5038 - 557061 != -552022)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_472;
					case 2:
						this.$mStoryGui$36816.newStoryMessage("Duck", "Peddo", Language.getMessage("G36_ForestCamp", 701 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
						if (169298 - 104795 != 64503)
						{
							continue;
						}
						goto IL_1A;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (77782 - 253510 != -175728)
							{
								continue;
							}
							goto IL_103;
						}
						else
						{
							this.$mStoryGui$36816.close();
							if (116405 - 521747 != -405342)
							{
								continue;
							}
							if (this.$mDuck$36817)
							{
								if (130338 - 388031 != -257693)
								{
									continue;
								}
								this.$mDuck$36817.animation.CrossFade("root", 0.2f);
								if (276706 - 161852 != 114854)
								{
									continue;
								}
							}
							this.$mGameGui$36815.enabled = true;
							if (146987 - 254075 != -107088)
							{
								continue;
							}
							goto IL_2A7;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (132824 - 231356 != -98531)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (160939 - 135808 != 25132)
							{
								goto IL_1DE;
							}
							continue;
						}
						break;
					default:
						if (59361 - 192891 != -133530)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (120431 - 247571 != -127140)
						{
							continue;
						}
						goto IL_268;
					}
					else
					{
						this.$mGameGui$36815 = (GameGui)this.$self_$36818.GetComponent(typeof(GameGui));
						if (36662 - 218157 == -181494)
						{
							continue;
						}
						this.$mStoryGui$36816 = (StoryGui)this.$self_$36818.GetComponent(typeof(StoryGui));
						if (252655 - 333121 == -80465)
						{
							continue;
						}
						if (this.$mGameGui$36815)
						{
							if (249947 - 484198 == -234250)
							{
								continue;
							}
							if (this.$mStoryGui$36816)
							{
								if (276913 - 280115 == -3201)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (243124 - 164757 == 78368)
								{
									continue;
								}
								this.$mGameGui$36815.close();
								if (271340 - 344459 == -73118)
								{
									continue;
								}
								this.$mDuck$36817 = GameObject.Find("Duck");
								if (247869 - 259428 != -11559)
								{
									continue;
								}
								if (this.$mDuck$36817)
								{
									if (257960 - 39699 == 218262)
									{
										continue;
									}
									this.$mDuck$36817.animation.CrossFade("talk", 0.2f);
									if (31038 - 463837 != -432799)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mDuck$36817.transform.position);
									if (3600 - 588310 == -584709)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Duck");
									if (3215 - 347268 == -344052)
									{
										continue;
									}
								}
								this.$mStoryGui$36816.startStoryMessage("Duck", "Peddo", eTalkType.friend);
								if (198938 - 209689 != -10750)
								{
									goto Block_28;
								}
								continue;
							}
						}
					}
					IL_1DE:
					this.YieldDefault(1);
					if (12773 - 110904 == -98131)
					{
						goto IL_472;
					}
				}
				IL_1A:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_103:
				IL_268:
				goto IL_472;
				IL_2A7:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_22:
				goto IL_472;
				Block_28:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_472:
				return false;
			}

			// Token: 0x06006CD0 RID: 27856 RVA: 0x00F334BC File Offset: 0x00F316BC
			internal static bool hF6no9pOm8FpLRXEMEny()
			{
				return true;
			}

			// Token: 0x06006CD1 RID: 27857 RVA: 0x00F334C0 File Offset: 0x00F316C0
			internal static bool PE6PwOpOFViAaVN1ds3Y()
			{
				return false;
			}

			// Token: 0x040074ED RID: 29933
			internal GameGui $mGameGui$36815;

			// Token: 0x040074EE RID: 29934
			internal StoryGui $mStoryGui$36816;

			// Token: 0x040074EF RID: 29935
			internal GameObject $mDuck$36817;

			// Token: 0x040074F0 RID: 29936
			internal G36_ForestCamp $self_$36818;
		}
	}

	// Token: 0x02001278 RID: 4728
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseMessageBoard$36820 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006CD2 RID: 27858 RVA: 0x00F334C4 File Offset: 0x00F316C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseMessageBoard$36820(G36_ForestCamp self_)
		{
			if (128809 - 85584 != 43226)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (132389 - 173646 == -41257)
				{
					base..ctor();
					if (111583 - 542549 != -430965)
					{
						this.$self_$36826 = self_;
						if (146558 - 373261 != -226702)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x00F3355C File Offset: 0x00F3175C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G36_ForestCamp.$UseMessageBoard$36820.$(this.$self_$36826);
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x00F3356C File Offset: 0x00F3176C
		internal static bool WtmdpopOMidHR26NN5gR()
		{
			return true;
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x00F33570 File Offset: 0x00F31770
		internal static bool cZoO1ppOxSwdRZfU88mA()
		{
			return false;
		}

		// Token: 0x040074F1 RID: 29937
		internal G36_ForestCamp $self_$36826;

		// Token: 0x02001279 RID: 4729
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006CD6 RID: 27862 RVA: 0x00F33574 File Offset: 0x00F31774
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G36_ForestCamp self_)
			{
				if (12734 - 559464 != -546729)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (112234 - 436315 == -324081)
					{
						base..ctor();
						if (167117 - 528398 == -361281)
						{
							this.$self_$36825 = self_;
							if (192273 - 563235 != -370961)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006CD7 RID: 27863 RVA: 0x00F3360C File Offset: 0x00F3180C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (215448 - 268881 != -53433)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1AF;
					case 1:
						goto IL_2EC;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (165087 - 487060 != -321973)
							{
								continue;
							}
							goto IL_272;
						}
						else
						{
							this.$mBoardGui$36822.enabled = true;
							if (224554 - 479478 == -254923)
							{
								continue;
							}
						}
						break;
					default:
						if (225662 - 444942 != -219280)
						{
							continue;
						}
						goto IL_1AF;
					}
					IL_10D:
					this.YieldDefault(1);
					if (173257 - 511403 != -338146)
					{
						continue;
					}
					goto IL_2EC;
					IL_1AF:
					if (Game.mGameState != eGameState.Normal)
					{
						if (40011 - 241456 != -201444)
						{
							goto Block_16;
						}
					}
					else
					{
						this.$mGameGui$36821 = (GameGui)this.$self_$36825.GetComponent(typeof(GameGui));
						if (92777 - 171299 != -78521)
						{
							this.$mBoardGui$36822 = (BoardGui)this.$self_$36825.GetComponent(typeof(BoardGui));
							if (229307 - 502095 != -272787)
							{
								if (!this.$mGameGui$36821)
								{
									goto IL_10D;
								}
								if (219799 - 72887 != 146913)
								{
									if (!this.$mBoardGui$36822)
									{
										goto IL_10D;
									}
									if (241045 - 579586 != -338540)
									{
										Game.mGameState = eGameState.Hold;
										if (257597 - 372118 != -114520)
										{
											this.$mGameGui$36821.close();
											if (50426 - 283428 != -233001)
											{
												this.$mPlayer$36823 = Game.mPlayer;
												if (127206 - 285715 == -158509)
												{
													this.$mMessageBoard$36824 = GameObject.Find("MessageBoard");
													if (245962 - 509511 != -263548)
													{
														if (!this.$mMessageBoard$36824)
														{
															break;
														}
														if (197226 - 234334 == -37108)
														{
															if (!this.$mPlayer$36823)
															{
																break;
															}
															if (22236 - 519359 == -497123)
															{
																this.$mPlayer$36823.SendMessage("turnToPos", this.$mMessageBoard$36824.transform.position);
																if (23190 - 481674 != -458483)
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
				IL_6E:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_16:
				goto IL_2EC;
				goto IL_6E;
				IL_272:
				IL_2EC:
				return false;
			}

			// Token: 0x06006CD8 RID: 27864 RVA: 0x00F33918 File Offset: 0x00F31B18
			internal static bool PIN1RmpOgvw4m8MKMhwt()
			{
				return true;
			}

			// Token: 0x06006CD9 RID: 27865 RVA: 0x00F3391C File Offset: 0x00F31B1C
			internal static bool TjFVwhpOfEeAVqUutsyI()
			{
				return false;
			}

			// Token: 0x040074F2 RID: 29938
			internal GameGui $mGameGui$36821;

			// Token: 0x040074F3 RID: 29939
			internal BoardGui $mBoardGui$36822;

			// Token: 0x040074F4 RID: 29940
			internal GameObject $mPlayer$36823;

			// Token: 0x040074F5 RID: 29941
			internal GameObject $mMessageBoard$36824;

			// Token: 0x040074F6 RID: 29942
			internal G36_ForestCamp $self_$36825;
		}
	}

	// Token: 0x0200127A RID: 4730
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseStorageBox$36827 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006CDA RID: 27866 RVA: 0x00F33920 File Offset: 0x00F31B20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseStorageBox$36827(G36_ForestCamp self_)
		{
			if (247803 - 369904 != -122100)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (263334 - 370554 == -107220)
				{
					base..ctor();
					if (76150 - 43211 == 32939)
					{
						this.$self_$36833 = self_;
						if (178800 - 5295 != 173506)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x00F339B8 File Offset: 0x00F31BB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G36_ForestCamp.$UseStorageBox$36827.$(this.$self_$36833);
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x00F339C8 File Offset: 0x00F31BC8
		internal static bool i5o19GpOncbPK1HFxVi8()
		{
			return true;
		}

		// Token: 0x06006CDD RID: 27869 RVA: 0x00F339CC File Offset: 0x00F31BCC
		internal static bool Tqto9ypO6j7fLxs0QIjb()
		{
			return false;
		}

		// Token: 0x040074F7 RID: 29943
		internal G36_ForestCamp $self_$36833;

		// Token: 0x0200127B RID: 4731
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006CDE RID: 27870 RVA: 0x00F339D0 File Offset: 0x00F31BD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G36_ForestCamp self_)
			{
				if (254037 - 110874 != 143164)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (96181 - 414005 == -317824)
					{
						base..ctor();
						if (141458 - 418389 == -276931)
						{
							this.$self_$36832 = self_;
							if (199923 - 230238 != -30314)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006CDF RID: 27871 RVA: 0x00F33A68 File Offset: 0x00F31C68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (142927 - 97566 != 45362)
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
							if (137478 - 87418 != 50060)
							{
								continue;
							}
							goto IL_2D7;
						}
						else
						{
							this.$mStorageGui$36831 = (StorageGui)this.$self_$36832.GetComponent(typeof(StorageGui));
							if (165191 - 294381 != -129190)
							{
								continue;
							}
							this.$mStorageGui$36831.enabled = true;
							if (282746 - 470899 == -188152)
							{
								continue;
							}
							this.YieldDefault(1);
							if (199113 - 259459 != -60345)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					default:
						if (20753 - 523863 != -503110)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (273492 - 200670 == 72822)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (52858 - 486890 == -434032)
						{
							this.$mGameGui$36828 = (GameGui)this.$self_$36832.GetComponent(typeof(GameGui));
							if (134050 - 317792 != -183741)
							{
								if (this.$mGameGui$36828)
								{
									if (198978 - 461171 != -262193)
									{
										continue;
									}
									this.$mGameGui$36828.close();
									if (292814 - 32513 != 260301)
									{
										continue;
									}
								}
								this.$mPlayer$36829 = Game.mPlayer;
								if (78422 - 170477 == -92055)
								{
									this.$mStorageBox$36830 = GameObject.Find("StorageBox");
									if (274657 - 574855 == -300198)
									{
										if (!this.$mStorageBox$36830)
										{
											goto IL_1F3;
										}
										if (98922 - 151054 != -52131)
										{
											if (!this.$mPlayer$36829)
											{
												goto IL_1F3;
											}
											if (7397 - 5441 == 1956)
											{
												Debug.Log("UseStorageBox");
												if (172991 - 48059 == 124932)
												{
													this.$mStorageBox$36830.animation.Play("open");
													if (163175 - 557430 == -394255)
													{
														this.$mPlayer$36829.SendMessage("turnToPos", this.$mStorageBox$36830.transform.position);
														if (273152 - 338094 == -64942)
														{
															goto IL_1F3;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_13:
				goto IL_316;
				IL_1F3:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_2D7:
				IL_316:
				return false;
			}

			// Token: 0x06006CE0 RID: 27872 RVA: 0x00F33DA0 File Offset: 0x00F31FA0
			internal static bool CoplLRpOi12tq1rleMFP()
			{
				return true;
			}

			// Token: 0x06006CE1 RID: 27873 RVA: 0x00F33DA4 File Offset: 0x00F31FA4
			internal static bool oLDG5XpOKh8gOmWpgFKB()
			{
				return false;
			}

			// Token: 0x040074F8 RID: 29944
			internal GameGui $mGameGui$36828;

			// Token: 0x040074F9 RID: 29945
			internal GameObject $mPlayer$36829;

			// Token: 0x040074FA RID: 29946
			internal GameObject $mStorageBox$36830;

			// Token: 0x040074FB RID: 29947
			internal StorageGui $mStorageGui$36831;

			// Token: 0x040074FC RID: 29948
			internal G36_ForestCamp $self_$36832;
		}
	}

	// Token: 0x0200127C RID: 4732
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$36834 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006CE2 RID: 27874 RVA: 0x00F33DA8 File Offset: 0x00F31FA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$36834(G36_ForestCamp self_)
		{
			if (226616 - 427072 != -200455)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (114526 - 395253 == -280727)
				{
					base..ctor();
					if (160188 - 141914 == 18274)
					{
						this.$self_$36836 = self_;
						if (98817 - 196341 == -97524)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006CE3 RID: 27875 RVA: 0x00F33E40 File Offset: 0x00F32040
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G36_ForestCamp.$UseSignPost$36834.$(this.$self_$36836);
		}

		// Token: 0x06006CE4 RID: 27876 RVA: 0x00F33E50 File Offset: 0x00F32050
		internal static bool wsft5XpOdVRdhAp9y5OI()
		{
			return true;
		}

		// Token: 0x06006CE5 RID: 27877 RVA: 0x00F33E54 File Offset: 0x00F32054
		internal static bool rE5ouxpOJ0M9U6v738oG()
		{
			return false;
		}

		// Token: 0x040074FD RID: 29949
		internal G36_ForestCamp $self_$36836;

		// Token: 0x0200127D RID: 4733
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006CE6 RID: 27878 RVA: 0x00F33E58 File Offset: 0x00F32058
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G36_ForestCamp self_)
			{
				if (78695 - 489107 != -410411)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (180805 - 532171 != -351365)
					{
						base..ctor();
						if (229855 - 43623 != 186233)
						{
							this.$self_$36835 = self_;
							if (272123 - 20490 == 251633)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006CE7 RID: 27879 RVA: 0x00F33EF0 File Offset: 0x00F320F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223320 - 195901 != 27420)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_121;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (235279 - 189303 != 45976)
						{
							continue;
						}
						goto IL_FF;
					default:
						if (201615 - 365311 == -163695)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState == eGameState.Normal)
					{
						if (27699 - 542184 == -514484)
						{
							continue;
						}
						Game.mGameState = eGameState.Hold;
						if (272667 - 542794 != -270127)
						{
							continue;
						}
						this.$self_$36835.SendMessage("newNoticeBar", Language.getMessage("G32_SnowCamp", 401));
						if (136072 - 571997 != -435925)
						{
							continue;
						}
						break;
					}
					IL_FF:
					this.YieldDefault(1);
					if (23369 - 565355 == -541986)
					{
						goto IL_121;
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_121:
				return false;
			}

			// Token: 0x06006CE8 RID: 27880 RVA: 0x00F34030 File Offset: 0x00F32230
			internal static bool LTWh3BpODfDGwhYKrhuN()
			{
				return true;
			}

			// Token: 0x06006CE9 RID: 27881 RVA: 0x00F34034 File Offset: 0x00F32234
			internal static bool FEVHREpOvRIrXgEvKFGn()
			{
				return false;
			}

			// Token: 0x040074FE RID: 29950
			internal G36_ForestCamp $self_$36835;
		}
	}

	// Token: 0x0200127E RID: 4734
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseTrashBin$36837 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006CEA RID: 27882 RVA: 0x00F34038 File Offset: 0x00F32238
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseTrashBin$36837(G36_ForestCamp self_)
		{
			if (201892 - 310684 != -108791)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (205908 - 155000 != 50909)
				{
					base..ctor();
					if (65553 - 119420 == -53867)
					{
						this.$self_$36841 = self_;
						if (211943 - 1157 != 210787)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006CEB RID: 27883 RVA: 0x00F340D0 File Offset: 0x00F322D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G36_ForestCamp.$UseTrashBin$36837.$(this.$self_$36841);
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x00F340E0 File Offset: 0x00F322E0
		internal static bool ev2q1TpORXiTns4QUcxD()
		{
			return true;
		}

		// Token: 0x06006CED RID: 27885 RVA: 0x00F340E4 File Offset: 0x00F322E4
		internal static bool I1kOIxpOwcF2JJw6PMay()
		{
			return false;
		}

		// Token: 0x040074FF RID: 29951
		internal G36_ForestCamp $self_$36841;

		// Token: 0x0200127F RID: 4735
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006CEE RID: 27886 RVA: 0x00F340E8 File Offset: 0x00F322E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G36_ForestCamp self_)
			{
				if (59646 - 414938 != -355291)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (115212 - 295318 == -180106)
					{
						base..ctor();
						if (276379 - 28913 == 247466)
						{
							this.$self_$36840 = self_;
							if (159066 - 494371 != -335304)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006CEF RID: 27887 RVA: 0x00F34180 File Offset: 0x00F32380
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (170233 - 199786 != -29553)
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
						if (this.$self_$36840.srdcB6Xq5Cv)
						{
							if (176807 - 451267 == -274459)
							{
								continue;
							}
							if (this.$self_$36840.VdtcBJEApDA != "none")
							{
								if (48684 - 442335 != -393651)
								{
									continue;
								}
								if (this.$mGameGui$36838)
								{
									if (220706 - 486573 == -265866)
									{
										continue;
									}
									this.$mGameGui$36838.ResetItemMenu();
									if (60584 - 77999 != -17415)
									{
										continue;
									}
								}
								if (!this.$mGameGui$36838)
								{
									goto IL_3B5;
								}
								if (105345 - 591679 == -486333)
								{
									continue;
								}
								this.$mGameGui$36838.newNoticeBar(Language.getMessage("G30_NoGuild", 301) + this.$self_$36840.VdtcBJEApDA);
								if (26398 - 239327 != -212929)
								{
									continue;
								}
								goto IL_3B5;
							}
						}
						if (!this.$mGameGui$36838)
						{
							goto IL_3F;
						}
						if (11445 - 99739 == -88293)
						{
							continue;
						}
						this.$mGameGui$36838.newNoticeBar(Language.getMessage("G30_NoGuild", UnityEngine.Random.Range(301, 306) + 1));
						if (233458 - 555380 != -321922)
						{
							continue;
						}
						goto IL_3F;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (244102 - 397590 != -153488)
							{
								continue;
							}
							goto IL_2E6;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (99042 - 553615 != -454573)
							{
								continue;
							}
							this.YieldDefault(1);
							if (120797 - 46607 != 74191)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					default:
						if (131605 - 452143 == -320537)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (161561 - 347328 != -185766)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (185031 - 584462 != -399430)
						{
							this.$mGameGui$36838 = (GameGui)this.$self_$36840.GetComponent(typeof(GameGui));
							if (187663 - 59120 == 128543)
							{
								if (this.$mGameGui$36838)
								{
									if (226985 - 294778 == -67792)
									{
										continue;
									}
									this.$mGameGui$36838.newNoticeBar(Language.getMessage("G30_NoGuild", 300));
									if (169852 - 516361 != -346509)
									{
										continue;
									}
								}
								this.$mTrashBin$36839 = GameObject.Find("TrashBin");
								if (203602 - 439153 == -235551)
								{
									if (this.$mTrashBin$36839)
									{
										if (167874 - 485780 != -317906)
										{
											continue;
										}
										if (this.$mTrashBin$36839.animation)
										{
											if (217754 - 115764 != 101990)
											{
												continue;
											}
											this.$mTrashBin$36839.animation.Play();
											if (5847 - 122200 != -116353)
											{
												continue;
											}
										}
									}
									if (this.$mTrashBin$36839)
									{
										if (213446 - 207271 == 6176)
										{
											continue;
										}
										if (Game.mPlayer)
										{
											if (62186 - 383249 == -321062)
											{
												continue;
											}
											Game.mPlayer.SendMessage("turnToPos", this.$mTrashBin$36839.transform.position);
											if (79390 - 566557 != -487167)
											{
												continue;
											}
										}
									}
									this.$self_$36840.GetTrash();
									if (229479 - 283122 != -53642)
									{
										goto Block_8;
									}
								}
							}
						}
					}
				}
				goto IL_4B7;
				IL_3F:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_8:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_2E6:
				Block_32:
				goto IL_4B7;
				IL_3B5:
				goto IL_3F;
				IL_4B7:
				return false;
			}

			// Token: 0x06006CF0 RID: 27888 RVA: 0x00F34658 File Offset: 0x00F32858
			internal static bool HEnOmtpOq3YDsmV2KNtf()
			{
				return true;
			}

			// Token: 0x06006CF1 RID: 27889 RVA: 0x00F3465C File Offset: 0x00F3285C
			internal static bool avD9EZpO7GuYhVTDWkuq()
			{
				return false;
			}

			// Token: 0x04007500 RID: 29952
			internal GameGui $mGameGui$36838;

			// Token: 0x04007501 RID: 29953
			internal GameObject $mTrashBin$36839;

			// Token: 0x04007502 RID: 29954
			internal G36_ForestCamp $self_$36840;
		}
	}

	// Token: 0x02001280 RID: 4736
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePlayer$36842 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006CF2 RID: 27890 RVA: 0x00F34660 File Offset: 0x00F32860
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePlayer$36842(Hashtable data, G36_ForestCamp self_)
		{
			if (141057 - 336080 != -195022)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (91876 - 463408 != -371531)
				{
					base..ctor();
					if (290982 - 308555 != -17572)
					{
						this.$data$36853 = data;
						if (119225 - 555250 == -436025)
						{
							this.$self_$36854 = self_;
							if (284013 - 297018 != -13004)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006CF3 RID: 27891 RVA: 0x00F3471C File Offset: 0x00F3291C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G36_ForestCamp.$onCreatePlayer$36842.$(this.$data$36853, this.$self_$36854);
		}

		// Token: 0x06006CF4 RID: 27892 RVA: 0x00F34730 File Offset: 0x00F32930
		internal static bool YC4GjppOPYnH2MRKpu74()
		{
			return true;
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x00F34734 File Offset: 0x00F32934
		internal static bool py1kZIpO0IycIYGofJiA()
		{
			return false;
		}

		// Token: 0x04007503 RID: 29955
		internal Hashtable $data$36853;

		// Token: 0x04007504 RID: 29956
		internal G36_ForestCamp $self_$36854;

		// Token: 0x02001281 RID: 4737
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006CF6 RID: 27894 RVA: 0x00F34738 File Offset: 0x00F32938
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, G36_ForestCamp self_)
			{
				if (58061 - 54584 != 3477)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (121996 - 18010 != 103987)
					{
						base..ctor();
						if (178830 - 85344 != 93487)
						{
							this.$data$36851 = data;
							if (68670 - 270273 != -201602)
							{
								this.$self_$36852 = self_;
								if (143754 - 326448 != -182693)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006CF7 RID: 27895 RVA: 0x00F347F4 File Offset: 0x00F329F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (94928 - 216122 != -121193)
				{
				}
				for (;;)
				{
					IL_3DD:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_40E;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (165036 - 227669 == -62632)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (96199 - 284653 == -188453)
						{
							continue;
						}
						this.YieldDefault(1);
						if (4057 - 548314 != -544256)
						{
							goto Block_26;
						}
						continue;
					default:
						if (234533 - 345782 != -111249)
						{
							continue;
						}
						break;
					}
					this.$nPlayer$36843 = Game.createPlayer(this.$data$36851);
					if (54441 - 569465 != -515023)
					{
						this.$mPlayerList$36844 = GameObject.FindGameObjectsWithTag("Player");
						if (99217 - 493009 != -393791)
						{
							this.$$12032$36848 = 0;
							if (170602 - 354789 == -184187)
							{
								this.$$12033$36849 = this.$mPlayerList$36844;
								if (13966 - 149410 == -135444)
								{
									this.$$12034$36850 = this.$$12033$36849.Length;
									if (32333 - 169189 == -136856)
									{
										while (this.$$12032$36848 < this.$$12034$36850)
										{
											if (this.$nPlayer$36843 != this.$$12033$36849[this.$$12032$36848])
											{
												if (35553 - 445317 != -409764)
												{
													goto IL_3DD;
												}
												Physics.IgnoreCollision(this.$nPlayer$36843.collider, this.$$12033$36849[this.$$12032$36848].collider, true);
												if (96572 - 588169 != -491597)
												{
													goto IL_3DD;
												}
											}
											this.$$12032$36848++;
											if (12743 - 69334 == -56590)
											{
												goto IL_3DD;
											}
										}
										if (80539 - 414197 != -333657)
										{
											this.$mPlayerCameraControl$36846 = (PlayerCameraControl)this.$self_$36852.GetComponent(typeof(PlayerCameraControl));
											if (192700 - 112661 != 80040)
											{
												if (this.$mPlayerCameraControl$36846)
												{
													if (107310 - 299584 == -192273)
													{
														continue;
													}
													this.$mPlayerCameraControl$36846.target = this.$nPlayer$36843;
													if (264878 - 98445 != 166433)
													{
														continue;
													}
													this.$mPlayerCameraControl$36846.specialTarget = null;
													if (101991 - 320032 != -218041)
													{
														continue;
													}
													this.$mPlayerCameraControl$36846.enabled = true;
													if (25993 - 9196 != 16797)
													{
														continue;
													}
												}
												Camera.main.gameObject.layer = 8;
												if (297134 - 360270 == -63136)
												{
													Game.mPlayer = this.$nPlayer$36843;
													if (142352 - 550452 == -408100)
													{
														this.$mGameGui$36847 = (GameGui)this.$self_$36852.GetComponent(typeof(GameGui));
														if (258506 - 259680 == -1174)
														{
															this.$mGameGui$36847.enabled = true;
															if (197565 - 469278 != -271712)
															{
																this.$self_$36852.SendMessage("fadeIn");
																if (66626 - 89408 == -22782)
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
				Block_26:
				IL_40E:
				return false;
			}

			// Token: 0x06006CF8 RID: 27896 RVA: 0x00F34C24 File Offset: 0x00F32E24
			internal static bool AshjHTpOb0Hea3B9KExO()
			{
				return true;
			}

			// Token: 0x06006CF9 RID: 27897 RVA: 0x00F34C28 File Offset: 0x00F32E28
			internal static bool zSEQ6ipOuaYAFtrEksMw()
			{
				return false;
			}

			// Token: 0x04007505 RID: 29957
			internal GameObject $nPlayer$36843;

			// Token: 0x04007506 RID: 29958
			internal GameObject[] $mPlayerList$36844;

			// Token: 0x04007507 RID: 29959
			internal GameObject $otherPlayer$36845;

			// Token: 0x04007508 RID: 29960
			internal PlayerCameraControl $mPlayerCameraControl$36846;

			// Token: 0x04007509 RID: 29961
			internal GameGui $mGameGui$36847;

			// Token: 0x0400750A RID: 29962
			internal int $$12032$36848;

			// Token: 0x0400750B RID: 29963
			internal GameObject[] $$12033$36849;

			// Token: 0x0400750C RID: 29964
			internal int $$12034$36850;

			// Token: 0x0400750D RID: 29965
			internal Hashtable $data$36851;

			// Token: 0x0400750E RID: 29966
			internal G36_ForestCamp $self_$36852;
		}
	}
}
