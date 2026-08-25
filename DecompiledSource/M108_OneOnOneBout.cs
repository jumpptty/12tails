using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x0200136E RID: 4974
[Serializable]
public class M108_OneOnOneBout : MonoBehaviour
{
	// Token: 0x0600727E RID: 29310 RVA: 0x00F92E10 File Offset: 0x00F91010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M108_OneOnOneBout()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600727F RID: 29311 RVA: 0x00F92E20 File Offset: 0x00F91020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (212786 - 282148 != -69361)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (97972 - 283380 == -185408)
			{
				Game.mGameType = 5;
				if (89703 - 474967 != -385263)
				{
					if (Chat.Initialized)
					{
						if (57386 - 83426 == -26040)
						{
							Chat.ChatDisplay.Clear();
							if (194933 - 203741 == -8808)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (284718 - 550890 == -266172)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007280 RID: 29312 RVA: 0x00F92F04 File Offset: 0x00F91104
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (165437 - 281061 != -115624)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (36313 - 562559 != -526245)
				{
					Game.nextGame();
					if (237532 - 120447 == 117085)
					{
						Game.mGameCode = 108;
						if (263796 - 386021 == -122225)
						{
							Game.mGameType = 5;
							if (177653 - 408247 == -230594)
							{
								Game.mGameTime = Time.time;
								if (87239 - 63698 == 23541)
								{
									Game.mGameScore = 0;
									if (40878 - 541915 == -501037)
									{
										Game.mGameMana = 0;
										if (173519 - 393192 == -219673)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (265684 - 585709 == -320025)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (196478 - 585763 != -389284)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (232250 - 101122 != 131129)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (166638 - 128527 == 38111)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (282567 - 552354 != -269786)
															{
																this.mWfc8icJxPe = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (153727 - 330769 != -177041)
																{
																	this.kHfc88DVEed = PhotonClient.Connection;
																	if (298253 - 36790 != 261464)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (73464 - 492421 == -418957)
																		{
																			this.InitGame();
																			if (294620 - 150052 != 144569)
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
				if (126012 - 498542 != -372529)
				{
					Game.mGameType = 99;
					if (32349 - 184087 == -151738)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007281 RID: 29313 RVA: 0x00F931E0 File Offset: 0x00F913E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (134575 - 95794 != 38781)
		{
		}
		for (;;)
		{
			if (this.kHfc88DVEed == null)
			{
				if (251830 - 41499 != 210332)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (224207 - 151781 == 72426)
				{
					if (mGameState == eGameState.Init)
					{
						if (293099 - 496650 == -203551)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (75182 - 208193 == -133011)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (245969 - 409160 == -163191)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (197255 - 223305 != -26049)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (162197 - 438593 != -276395)
						{
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (35500 - 488720 == -453220)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (68823 - 297603 != -228779)
						{
							if (Game.music != 0)
							{
								if (71875 - 495396 != -423521)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (34517 - 327740 == -293222)
									{
										continue;
									}
									this.audio.Play();
									if (281271 - 172862 != 108409)
									{
										continue;
									}
								}
							}
							if (Time.time <= this.KDec8Dgwxmf)
							{
								break;
							}
							if (212200 - 226173 != -13972)
							{
								Game.mGameMana++;
								if (213586 - 369350 != -155763)
								{
									this.KDec8Dgwxmf = Time.time + (float)12;
									if (68218 - 356742 == -288524)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (164799 - 7802 == 156997)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (192817 - 109722 != 83096)
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
						if (186703 - 277062 == -90359)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007282 RID: 29314 RVA: 0x00F934E0 File Offset: 0x00F916E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (21988 - 118432 != -96444)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (99794 - 212341 == -112547)
			{
				float num = (float)1;
				if (15350 - 65692 != -50341)
				{
					float num2 = (float)(1024 * Screen.width / Screen.height);
					if (238713 - 30279 == 208434)
					{
						GUI.depth = 1;
						if (137608 - 78528 != 59081)
						{
							eGameState mGameState = Game.mGameState;
							if (194221 - 426962 != -232740)
							{
								if (mGameState == eGameState.Start)
								{
									if (211335 - 571110 != -359775)
									{
										continue;
									}
									if (this.ABIc893riMf == 1)
									{
										if (61288 - 129719 == -68430)
										{
											continue;
										}
										if (Time.time - Game.mStateTime < (float)1)
										{
											if (264695 - 421445 != -156750)
											{
												continue;
											}
											break;
										}
										else if (Time.time - Game.mStateTime < (float)2)
										{
											if (53863 - 112502 == -58638)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)1);
											if (118813 - 597798 == -478984)
											{
												continue;
											}
											float a = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)1);
											if (160789 - 578135 != -417346)
											{
												continue;
											}
											Color color = GUI.color;
											if (85959 - 246702 == -160742)
											{
												continue;
											}
											float num3 = color.a = a;
											if (143122 - 533615 != -390493)
											{
												continue;
											}
											if (42404 - 195041 != -152637)
											{
												continue;
											}
											GUI.color = color;
											if (266325 - 445301 != -178976)
											{
												continue;
											}
											if (293987 - 16782 == 277206)
											{
												continue;
											}
											if (this.JmKc8k9iTBQ)
											{
												if (221288 - 417673 == -196384)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.JmKc8k9iTBQ);
												if (245585 - 463422 != -217837)
												{
													continue;
												}
											}
										}
										else if (Time.time - Game.mStateTime < (float)3)
										{
											if (1020 - 206147 != -205127)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)2);
											if (214876 - 185936 == 28941)
											{
												continue;
											}
											float a2 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)2);
											if (48710 - 287361 != -238651)
											{
												continue;
											}
											Color color2 = GUI.color;
											if (180080 - 135473 != 44607)
											{
												continue;
											}
											color2.a = a2;
											if (287443 - 124444 != 162999)
											{
												continue;
											}
											if (250241 - 247756 == 2486)
											{
												continue;
											}
											Color color3 = GUI.color = color2;
											if (154470 - 16167 != 138303)
											{
												continue;
											}
											if (249686 - 494892 != -245206)
											{
												continue;
											}
											if (this.v2Rc8o9RmrX)
											{
												if (59462 - 228731 != -169269)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.v2Rc8o9RmrX);
												if (260652 - 4952 != 255700)
												{
													continue;
												}
											}
										}
										else if (Time.time - Game.mStateTime < (float)4)
										{
											if (112048 - 534061 != -422013)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)3);
											if (71636 - 319364 == -247727)
											{
												continue;
											}
											float a3 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)3);
											if (34663 - 97248 != -62585)
											{
												continue;
											}
											Color color4 = GUI.color;
											if (178539 - 92258 != 86281)
											{
												continue;
											}
											color4.a = a3;
											if (260381 - 343503 != -83122)
											{
												continue;
											}
											if (267280 - 418754 == -151473)
											{
												continue;
											}
											GUI.color = color4;
											if (90933 - 19056 == 71878)
											{
												continue;
											}
											if (10514 - 303505 != -292991)
											{
												continue;
											}
											if (this.Ohlc8jJCcf6)
											{
												if (210373 - 294841 != -84468)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.Ohlc8jJCcf6);
												if (287634 - 233610 == 54025)
												{
													continue;
												}
											}
										}
									}
								}
								else if (mGameState == eGameState.Normal)
								{
									if (253261 - 435304 == -182042)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)1)
									{
										if (264107 - 505993 != -241886)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
										if (290374 - 558863 != -268489)
										{
											continue;
										}
										if (Time.time - Game.mStateTime < 0.2f)
										{
											if (16871 - 418623 == -401751)
											{
												continue;
											}
											float a4 = Mathf.SmoothStep((float)0, (float)1, (float)5 * Time.time - Game.mStateTime);
											if (280447 - 479538 != -199091)
											{
												continue;
											}
											Color color5 = GUI.color;
											if (25898 - 294295 != -268397)
											{
												continue;
											}
											float num4 = color5.a = a4;
											if (32672 - 454539 == -421866 || 139384 - 225431 == -86046)
											{
												continue;
											}
											Color color6 = GUI.color = color5;
											if (45288 - 507330 != -462042)
											{
												continue;
											}
											if (63877 - 140379 != -76502)
											{
												continue;
											}
										}
										else
										{
											float a5 = Mathf.SmoothStep((float)1, (float)0, 1.25f * (Time.time - Game.mStateTime - 0.2f));
											if (277536 - 473421 == -195884)
											{
												continue;
											}
											Color color7 = GUI.color;
											if (210996 - 593914 != -382918)
											{
												continue;
											}
											color7.a = a5;
											if (73668 - 557365 != -483697)
											{
												continue;
											}
											if (281892 - 90885 == 191008)
											{
												continue;
											}
											Color color8 = GUI.color = color7;
											if (69078 - 397451 != -328373)
											{
												continue;
											}
											if (9808 - 379454 != -369646)
											{
												continue;
											}
										}
										if (this.ziTc8mDiBG1)
										{
											if (15782 - 562699 != -546917)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.ziTc8mDiBG1);
											if (148810 - 482095 == -333284)
											{
												continue;
											}
										}
									}
								}
								float a6 = 1f;
								if (243793 - 185274 == 58519)
								{
									Color color9 = GUI.color;
									if (228076 - 206983 != 21094)
									{
										color9.a = a6;
										if (165422 - 183568 != -18145)
										{
											if (124539 - 409528 == -284989)
											{
												Color color10 = GUI.color = color9;
												if (44390 - 299965 != -255574 && 162107 - 392041 != -229933)
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

	// Token: 0x06007283 RID: 29315 RVA: 0x00F93F58 File Offset: 0x00F92158
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (155958 - 366110 != -210152)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (103295 - 265092 == -161797)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (163815 - 586899 != -423083)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (6505 - 521765 != -515259)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (6146 - 247090 != -240943)
						{
							int num4 = num;
							if (87076 - 440135 != -353058)
							{
								if (num4 == 1081)
								{
									if (229555 - 581312 == -351757)
									{
										break;
									}
								}
								else if (num4 == -1081)
								{
									if (185904 - 161120 != 24785)
									{
										if (this.ABIc893riMf >= 1)
										{
											break;
										}
										if (70257 - 445325 == -375068)
										{
											this.ABIc893riMf = 1;
											if (75255 - 537412 != -462156)
											{
												this.StartCoroutine_Auto(this.StartMatch());
												if (186072 - 225131 != -39058)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == 1082)
								{
									if (262850 - 149159 == 113691)
									{
										if (num2 == 1)
										{
											if (28516 - 366998 != -338481)
											{
												this.UL1c8WDsncD = 1;
												if (9022 - 426185 == -417163)
												{
													break;
												}
											}
										}
										else
										{
											this.p5xc8ubMMVv = 1;
											if (138994 - 541355 == -402361)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (num4 != 1083)
									{
										break;
									}
									if (94619 - 582963 == -488344)
									{
										if (this.ABIc893riMf >= 2)
										{
											break;
										}
										if (168853 - 110135 == 58718)
										{
											this.ABIc893riMf = 2;
											if (61322 - 41964 != 19359)
											{
												if (num2 == 1)
												{
													if (27522 - 306225 == -278703)
													{
														this.SendMessage("newGameMessage", "Team1 defeated!");
														if (46718 - 493623 == -446905)
														{
															Chat.SubmitChat("none", "Team1 defeated!", eChatType.system, eChatMode.system);
															if (45831 - 562102 != -516270)
															{
																break;
															}
														}
													}
												}
												else
												{
													this.SendMessage("newGameMessage", "Team2 defeated!");
													if (40105 - 511470 == -471365)
													{
														Chat.SubmitChat("none", "Team2 defeated!", eChatType.system, eChatMode.system);
														if (115909 - 322684 == -206775)
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

	// Token: 0x06007284 RID: 29316 RVA: 0x00F942F8 File Offset: 0x00F924F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (100159 - 204933 != -104773)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (210719 - 90983 != 119737)
			{
				Time.timeScale = 1f;
				if (68245 - 27501 == 40744)
				{
					this.ziTc8mDiBG1 = (Texture)Resources.Load("GameGui/Title/battle", typeof(Texture));
					if (1586 - 509302 == -507716)
					{
						this.Ohlc8jJCcf6 = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
						if (149216 - 400271 != -251054)
						{
							this.v2Rc8o9RmrX = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
							if (222722 - 242372 != -19649)
							{
								this.JmKc8k9iTBQ = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
								if (277865 - 92802 == 185063)
								{
									this.kE8c8FggtlY = (AudioClip)Resources.Load("Sound/GUI/missionBattle", typeof(AudioClip));
									if (168108 - 317593 != -149484)
									{
										this.SRhc8AmWfVo = (AudioClip)Resources.Load("Sound/GUI/missionCount", typeof(AudioClip));
										if (206945 - 378202 != -171256)
										{
											Hashtable customOpParameters = new Hashtable();
											if (95377 - 223924 != -128546)
											{
												this.kHfc88DVEed.OpCustom(52, customOpParameters, true);
												if (122457 - 81050 != 41408)
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

	// Token: 0x06007285 RID: 29317 RVA: 0x00F94518 File Offset: 0x00F92718
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (228358 - 389254 != -160895)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (25540 - 140295 == -114755)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (71382 - 271476 != -200093)
				{
					Game.mGameState = eGameState.Setup;
					if (201613 - 519079 == -317466)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007286 RID: 29318 RVA: 0x00F945BC File Offset: 0x00F927BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (195014 - 210300 != -15286)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (208037 - 212321 != -4283)
			{
				if (num != PlayerData.UID)
				{
					break;
				}
				if (285980 - 277481 == 8499)
				{
					Game.setGameState(eGameState.Ready);
					if (152720 - 145177 == 7543)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007287 RID: 29319 RVA: 0x00F94668 File Offset: 0x00F92868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		GameObject gameObject = Game.createActor(data);
	}

	// Token: 0x06007288 RID: 29320 RVA: 0x00F9467C File Offset: 0x00F9287C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06007289 RID: 29321 RVA: 0x00F94680 File Offset: 0x00F92880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x0600728A RID: 29322 RVA: 0x00F94684 File Offset: 0x00F92884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (273874 - 494763 != -220888)
		{
		}
		while (Game.mGameState < eGameState.Ready)
		{
			if (295752 - 417700 == -121948)
			{
				Debug.Log("Game Ready");
				if (33809 - 528589 == -494780)
				{
					Game.mGameState = eGameState.Ready;
					if (157486 - 200271 == -42785)
					{
						int playerSlot = Game.getPlayerSlot(PlayerData.UID);
						if (51830 - 416852 == -365022)
						{
							if (18817 - 547700 != -528882)
							{
								GameObject gameObject = null;
								if (117223 - 8909 == 108314)
								{
									if (playerSlot <= 1)
									{
										goto IL_27C;
									}
									if (81061 - 70658 != 10403)
									{
										continue;
									}
									if (playerSlot > 6)
									{
										goto IL_27C;
									}
									if (185266 - 436942 == -251675)
									{
										continue;
									}
									GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
									if (123538 - 128415 != -4877)
									{
										continue;
									}
									gameObject = GameObject.Find("StartCamera" + playerSlot);
									if (114600 - 192272 != -77672)
									{
										continue;
									}
									IL_34D:
									if (gameObject2)
									{
										if (137159 - 579273 == -442113)
										{
											continue;
										}
										if (playerSlot % 2 == 1)
										{
											if (137489 - 202712 == -65222)
											{
												continue;
											}
											this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
											if (106423 - 428685 != -322262)
											{
												continue;
											}
										}
										else
										{
											this.CreatePlayer(CharacterData.current.CID, 2, gameObject2.transform.position, gameObject2.transform.forward);
											if (214637 - 244800 == -30162)
											{
												continue;
											}
										}
									}
									if (gameObject)
									{
										if (25652 - 529370 != -503718)
										{
											continue;
										}
										this.transform.position = gameObject.transform.position;
										if (153019 - 318832 == -165812)
										{
											continue;
										}
										this.transform.rotation = gameObject.transform.rotation;
										if (26321 - 22603 != 3718)
										{
											continue;
										}
									}
									if (playerSlot % 2 == 1)
									{
										if (83972 - 595584 != -511612)
										{
											continue;
										}
										Game.sendMissionEvent(1082, 1);
										if (109115 - 215417 != -106302)
										{
											continue;
										}
										break;
									}
									else
									{
										Game.sendMissionEvent(1082, 2);
										if (79999 - 593225 != -513225)
										{
											break;
										}
										continue;
									}
									IL_27C:
									gameObject2 = GameObject.Find("StartPoint1");
									if (9304 - 115427 != -106122)
									{
										goto IL_34D;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600728B RID: 29323 RVA: 0x00F94A14 File Offset: 0x00F92C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M108_OneOnOneBout.$StartGame$37590(this).GetEnumerator();
	}

	// Token: 0x0600728C RID: 29324 RVA: 0x00F94A24 File Offset: 0x00F92C24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600728D RID: 29325 RVA: 0x00F94A28 File Offset: 0x00F92C28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartMatch()
	{
		return new M108_OneOnOneBout.$StartMatch$37594(this).GetEnumerator();
	}

	// Token: 0x0600728E RID: 29326 RVA: 0x00F94A38 File Offset: 0x00F92C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (92640 - 125134 != -32494)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (211028 - 353268 == -142240)
			{
				hashtable.Add(71, CID);
				if (39455 - 24369 == 15086)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (51847 - 206200 != -154352)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (89550 - 342660 != -253109)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (218124 - 382476 != -164351)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (65355 - 306299 == -240944)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (68379 - 86973 == -18594)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (114377 - 347049 != -232671)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (87387 - 586712 != -499324)
											{
												this.kHfc88DVEed.OpCustom(61, hashtable, true);
												if (42776 - 525342 == -482566)
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

	// Token: 0x0600728F RID: 29327 RVA: 0x00F94CC4 File Offset: 0x00F92EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (101136 - 178189 != -77052)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (109353 - 241272 != -131918)
			{
				if (!gameObject)
				{
					break;
				}
				if (100839 - 333408 != -232568)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (87917 - 284423 != -196505)
					{
						playerCameraControl.target = gameObject;
						if (246440 - 429576 == -183136)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (251684 - 213951 != 37734)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007290 RID: 29328 RVA: 0x00F94DBC File Offset: 0x00F92FBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (85246 - 123043 != -37797)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (120672 - 518996 != -398323)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (291773 - 200634 != 91140)
				{
					gameGui.ResetTeamBar();
					if (117759 - 173918 != -56158)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007291 RID: 29329 RVA: 0x00F94E68 File Offset: 0x00F93068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onAddEXP(Hashtable data)
	{
	}

	// Token: 0x06007292 RID: 29330 RVA: 0x00F94E6C File Offset: 0x00F9306C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLevelUp(Hashtable data)
	{
	}

	// Token: 0x06007293 RID: 29331 RVA: 0x00F94E70 File Offset: 0x00F93070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDeadPlayer()
	{
		if (71108 - 233056 != -161947)
		{
		}
		for (;;)
		{
			Debug.Log("On Dead Player");
			if (127785 - 147622 == -19837)
			{
				if (!Game.mPlayer)
				{
					break;
				}
				if (124491 - 220328 != -95836)
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (158452 - 116271 == 42181)
					{
						if (!characterControl)
						{
							break;
						}
						if (247695 - 528460 != -280764)
						{
							if (characterControl.mOriginalLayer == 8)
							{
								if (244146 - 556216 != -312069)
								{
									Game.sendMissionEvent(1083, 1);
									if (27357 - 269835 == -242478)
									{
										break;
									}
								}
							}
							else
							{
								Game.sendMissionEvent(1083, 2);
								if (177236 - 159196 != 18041)
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

	// Token: 0x06007294 RID: 29332 RVA: 0x00F94FC4 File Offset: 0x00F931C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (256894 - 252069 != 4826)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (149744 - 74868 == 74876)
			{
				if (Game.mPlayer)
				{
					if (272868 - 497960 == -225091)
					{
						continue;
					}
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (257311 - 587172 == -329860)
					{
						continue;
					}
					if (characterControl)
					{
						if (92233 - 4118 != 88115)
						{
							continue;
						}
						if (characterControl.mOriginalLayer == 8)
						{
							if (194278 - 179503 != 14775)
							{
								continue;
							}
							Game.sendMissionEvent(1081, 0);
							if (73176 - 523115 == -449938)
							{
								continue;
							}
						}
						else
						{
							Game.sendMissionEvent(1082, 0);
							if (18496 - 442255 == -423758)
							{
								continue;
							}
						}
					}
				}
				PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
				if (297920 - 423580 == -125660)
				{
					playerCameraControl.target = Game.mPlayer;
					if (222982 - 334882 == -111900)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (283626 - 273486 != 10140)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (57643 - 588032 != -530389)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (236146 - 289888 != -53741)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (80571 - 362858 == -282287)
							{
								if (!gameGui)
								{
									break;
								}
								if (99219 - 60132 == 39087)
								{
									gameGui.enabled = true;
									if (285530 - 562842 != -277311)
									{
										gameGui.closeDeadMenu();
										if (137457 - 447802 == -310345)
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

	// Token: 0x06007295 RID: 29333 RVA: 0x00F9526C File Offset: 0x00F9346C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
	}

	// Token: 0x06007296 RID: 29334 RVA: 0x00F95278 File Offset: 0x00F93478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (54070 - 61777 != -7706)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
			{
				if (245818 - 527829 == -282011)
				{
					Game.mGameState = eGameState.Ended;
					if (32610 - 497668 != -465057)
					{
						break;
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.AllHold;
				if (43730 - 375822 == -332092)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06007297 RID: 29335 RVA: 0x00F95330 File Offset: 0x00F93530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameComplete(Hashtable data)
	{
		if (107626 - 267589 != -159963)
		{
		}
		for (;;)
		{
			Debug.Log("On Mission Complete:" + data[31]);
			if (263186 - 1443 != 261744)
			{
				if (Game.mGameState > eGameState.AllHold)
				{
					if (284759 - 382615 != -97855)
					{
						break;
					}
				}
				else
				{
					Game.mGameState = eGameState.Complete;
					if (287079 - 571100 != -284020)
					{
						int num = RuntimeServices.UnboxInt32(data[31]);
						if (178699 - 379046 == -200347)
						{
							int nWinner = RuntimeServices.UnboxInt32(data[36]);
							if (118503 - 52906 != 65598)
							{
								CompleteGui completeGui = (CompleteGui)this.GetComponent(typeof(CompleteGui));
								if (97698 - 478752 != -381053)
								{
									GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
									if (293690 - 219646 != 74045)
									{
										if (gameGui)
										{
											if (67279 - 111092 != -43813)
											{
												continue;
											}
											gameGui.close();
											if (111018 - 106516 != 4502)
											{
												continue;
											}
										}
										completeGui.Init();
										if (142182 - 461644 != -319461)
										{
											completeGui.readData(data);
											if (79448 - 361819 != -282370)
											{
												if (num == 1)
												{
													if (41781 - 146425 == -104644)
													{
														completeGui.StartCoroutine_Auto(completeGui.displayPvpResult(eCompleteType.Success, nWinner));
														if (57181 - 94776 == -37595)
														{
															break;
														}
													}
												}
												else
												{
													completeGui.StartCoroutine_Auto(completeGui.displayPvpResult(eCompleteType.Failed, nWinner));
													if (272383 - 308728 == -36345)
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

	// Token: 0x06007298 RID: 29336 RVA: 0x00F955A0 File Offset: 0x00F937A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M108_OneOnOneBout.$ReturnToTown$37597(this).GetEnumerator();
	}

	// Token: 0x06007299 RID: 29337 RVA: 0x00F955B0 File Offset: 0x00F937B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M108_OneOnOneBout.$ReturnToGuild$37602(this).GetEnumerator();
	}

	// Token: 0x0600729A RID: 29338 RVA: 0x00F955C0 File Offset: 0x00F937C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M108_OneOnOneBout.$ReturnToCamp$37606(this).GetEnumerator();
	}

	// Token: 0x0600729B RID: 29339 RVA: 0x00F955D0 File Offset: 0x00F937D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (248394 - 299604 != -51210)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (207078 - 502029 == -294951)
			{
				Hashtable hashtable = new Hashtable();
				if (30447 - 33481 != -3033)
				{
					hashtable.Add(43, PlayerData.UID);
					if (104304 - 364884 != -260579)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (227212 - 347337 == -120125)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600729C RID: 29340 RVA: 0x00F956A8 File Offset: 0x00F938A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600729D RID: 29341 RVA: 0x00F956BC File Offset: 0x00F938BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (180133 - 585200 != -405067)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (285764 - 522610 == -236846)
			{
				Hashtable hashtable = new Hashtable();
				if (270329 - 466889 != -196559)
				{
					if (Game.mNextGameCode == 30)
					{
						if (39657 - 424522 != -384865)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (75188 - 513834 != -438646)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (168385 - 315095 == -146709)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (281756 - 593483 != -311727)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (176670 - 46432 != 130238)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (279210 - 251240 == 27971)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (117042 - 370677 == -253634)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (256590 - 436519 == -179928)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (50694 - 206796 == -156101)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (274435 - 494561 == -220125)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (272829 - 282227 == -9397)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (279091 - 305711 != -26620)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (256460 - 278360 != -21900)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (97560 - 179840 != -82280)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (203645 - 595274 == -391628)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (153312 - 52820 == 100493)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (229620 - 517499 == -287878)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (94011 - 58894 != 35117)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (287812 - 257555 != 30257)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (25642 - 107809 == -82166)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (214176 - 410115 == -195938)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (143132 - 490726 == -347593)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (265082 - 316531 != -51449)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (37146 - 216731 == -179584)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (69209 - 413397 != -344188)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (33868 - 190316 == -156447)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (82769 - 258911 != -176142)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (161378 - 462390 != -301012)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (148806 - 212387 != -63580)
					{
						this.kHfc88DVEed.OpCustom(42, hashtable, true);
						if (128112 - 477340 == -349228)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600729E RID: 29342 RVA: 0x00F95C70 File Offset: 0x00F93E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600729F RID: 29343 RVA: 0x00F95C80 File Offset: 0x00F93E80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060072A0 RID: 29344 RVA: 0x00F95C84 File Offset: 0x00F93E84
	internal static bool a8PxjQp6L3R22F3iO9Me()
	{
		return true;
	}

	// Token: 0x060072A1 RID: 29345 RVA: 0x00F95C88 File Offset: 0x00F93E88
	internal static bool FwIPnxp6OGq23Eu62ref()
	{
		return false;
	}

	// Token: 0x04007828 RID: 30760
	private LitePeer kHfc88DVEed;

	// Token: 0x04007829 RID: 30761
	private PlayerCameraControl mWfc8icJxPe;

	// Token: 0x0400782A RID: 30762
	private float KDec8Dgwxmf;

	// Token: 0x0400782B RID: 30763
	private Texture ziTc8mDiBG1;

	// Token: 0x0400782C RID: 30764
	private Texture Ohlc8jJCcf6;

	// Token: 0x0400782D RID: 30765
	private Texture v2Rc8o9RmrX;

	// Token: 0x0400782E RID: 30766
	private Texture JmKc8k9iTBQ;

	// Token: 0x0400782F RID: 30767
	private AudioClip kE8c8FggtlY;

	// Token: 0x04007830 RID: 30768
	private AudioClip SRhc8AmWfVo;

	// Token: 0x04007831 RID: 30769
	private int ABIc893riMf;

	// Token: 0x04007832 RID: 30770
	private int UL1c8WDsncD;

	// Token: 0x04007833 RID: 30771
	private int p5xc8ubMMVv;

	// Token: 0x04007834 RID: 30772
	private int Qrmc8y06QAg;

	// Token: 0x0200136F RID: 4975
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$37590 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060072A2 RID: 29346 RVA: 0x00F95C8C File Offset: 0x00F93E8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$37590(M108_OneOnOneBout self_)
		{
			if (66925 - 41112 != 25813)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (101382 - 336688 == -235306)
				{
					base..ctor();
					if (227409 - 337305 == -109896)
					{
						this.$self_$37593 = self_;
						if (7941 - 430267 != -422325)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x00F95D24 File Offset: 0x00F93F24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M108_OneOnOneBout.$StartGame$37590.$(this.$self_$37593);
		}

		// Token: 0x060072A4 RID: 29348 RVA: 0x00F95D34 File Offset: 0x00F93F34
		internal static bool N4KNtrp6m3s7LUNOguFf()
		{
			return true;
		}

		// Token: 0x060072A5 RID: 29349 RVA: 0x00F95D38 File Offset: 0x00F93F38
		internal static bool rbGBcUp6FMnDGmADn2jm()
		{
			return false;
		}

		// Token: 0x04007835 RID: 30773
		internal M108_OneOnOneBout $self_$37593;

		// Token: 0x02001370 RID: 4976
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060072A6 RID: 29350 RVA: 0x00F95D3C File Offset: 0x00F93F3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M108_OneOnOneBout self_)
			{
				if (192789 - 131474 != 61316)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (110866 - 541043 == -430177)
					{
						base..ctor();
						if (291587 - 297362 != -5774)
						{
							this.$self_$37592 = self_;
							if (251092 - 443890 != -192797)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060072A7 RID: 29351 RVA: 0x00F95DD4 File Offset: 0x00F93FD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (175000 - 329519 != -154519)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_220;
					case 1:
						goto IL_2D4;
					case 2:
						this.$mGameGui$37591 = (GameGui)this.$self_$37592.GetComponent(typeof(GameGui));
						if (48551 - 180115 != -131564)
						{
							continue;
						}
						this.$mGameGui$37591.enabled = true;
						if (133219 - 103075 == 30145)
						{
							continue;
						}
						Game.sendMissionEvent(1081, 0);
						if (26815 - 51254 != -24439)
						{
							continue;
						}
						goto IL_244;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (49881 - 121427 != -71546)
							{
								continue;
							}
							goto IL_62;
						}
						else if (this.$self_$37592.ABIc893riMf < 1)
						{
							if (15662 - 378956 != -363294)
							{
								continue;
							}
							this.$self_$37592.ABIc893riMf = 1;
							if (209054 - 194341 != 14713)
							{
								continue;
							}
							this.$self_$37592.SendMessage("newGameMessage", "Match cancelled: opponent not found!");
							if (64875 - 378653 == -313777)
							{
								continue;
							}
							Chat.SubmitChat("none", "Match cancelled: opponent not found!", eChatType.system, eChatMode.system);
							if (16305 - 512614 != -496309)
							{
								continue;
							}
							goto IL_189;
						}
						break;
					case 4:
						this.$self_$37592.StartCoroutine_Auto(this.$self_$37592.ReturnToTown());
						if (119699 - 139506 == -19806)
						{
							continue;
						}
						break;
					default:
						if (163897 - 426429 != -262532)
						{
							continue;
						}
						goto IL_220;
					}
					this.YieldDefault(1);
					if (76296 - 4321 != 71976)
					{
						break;
					}
					continue;
					IL_220:
					Debug.Log("Start Game");
					if (113936 - 125114 == -11178)
					{
						Game.mGameState = eGameState.Start;
						if (133300 - 519292 != -385991)
						{
							Game.mStateTime = Time.time;
							if (98615 - 512407 == -413792)
							{
								this.$self_$37592.SendMessage("fadeIn");
								if (84101 - 87692 == -3591)
								{
									goto IL_100;
								}
							}
						}
					}
				}
				IL_62:
				goto IL_2D4;
				IL_100:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_189:
				return this.Yield(4, new WaitForSeconds(2f));
				IL_244:
				return this.Yield(3, new WaitForSeconds(6f));
				IL_2D4:
				return false;
			}

			// Token: 0x060072A8 RID: 29352 RVA: 0x00F960C8 File Offset: 0x00F942C8
			internal static bool o0aJeap6MAwK1yQLYt82()
			{
				return true;
			}

			// Token: 0x060072A9 RID: 29353 RVA: 0x00F960CC File Offset: 0x00F942CC
			internal static bool U0xdsgp6xiebZTJYXLbc()
			{
				return false;
			}

			// Token: 0x04007836 RID: 30774
			internal GameGui $mGameGui$37591;

			// Token: 0x04007837 RID: 30775
			internal M108_OneOnOneBout $self_$37592;
		}
	}

	// Token: 0x02001371 RID: 4977
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartMatch$37594 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060072AA RID: 29354 RVA: 0x00F960D0 File Offset: 0x00F942D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartMatch$37594(M108_OneOnOneBout self_)
		{
			if (11322 - 132580 != -121258)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (99971 - 55729 != 44243)
				{
					base..ctor();
					if (172631 - 446033 == -273402)
					{
						this.$self_$37596 = self_;
						if (115832 - 334796 == -218964)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060072AB RID: 29355 RVA: 0x00F96168 File Offset: 0x00F94368
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M108_OneOnOneBout.$StartMatch$37594.$(this.$self_$37596);
		}

		// Token: 0x060072AC RID: 29356 RVA: 0x00F96178 File Offset: 0x00F94378
		internal static bool ofUsfGp6gC4b4CVGqwmg()
		{
			return true;
		}

		// Token: 0x060072AD RID: 29357 RVA: 0x00F9617C File Offset: 0x00F9437C
		internal static bool pTQUiqp6fqeNVlodoa2J()
		{
			return false;
		}

		// Token: 0x04007838 RID: 30776
		internal M108_OneOnOneBout $self_$37596;

		// Token: 0x02001372 RID: 4978
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060072AE RID: 29358 RVA: 0x00F96180 File Offset: 0x00F94380
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M108_OneOnOneBout self_)
			{
				if (238514 - 370653 != -132138)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (26 - 327663 == -327637)
					{
						base..ctor();
						if (259280 - 566187 != -306906)
						{
							this.$self_$37595 = self_;
							if (250338 - 35415 != 214924)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060072AF RID: 29359 RVA: 0x00F96218 File Offset: 0x00F94418
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (172341 - 552947 != -380605)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_45D;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (64979 - 254515 != -189535)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							if (!this.$self_$37595.SRhc8AmWfVo)
							{
								goto IL_175;
							}
							if (29519 - 431733 == -402213)
							{
								continue;
							}
							this.$self_$37595.audio.PlayOneShot(this.$self_$37595.SRhc8AmWfVo);
							if (216928 - 85320 != 131609)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (47275 - 273564 != -226288)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							if (!this.$self_$37595.SRhc8AmWfVo)
							{
								goto IL_1E4;
							}
							if (242401 - 213847 == 28555)
							{
								continue;
							}
							this.$self_$37595.audio.PlayOneShot(this.$self_$37595.SRhc8AmWfVo);
							if (75437 - 161057 != -85620)
							{
								continue;
							}
							goto IL_1E4;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (94704 - 554091 != -459387)
							{
								continue;
							}
							goto IL_21F;
						}
						else
						{
							if (!this.$self_$37595.SRhc8AmWfVo)
							{
								goto IL_65;
							}
							if (243452 - 64698 == 178755)
							{
								continue;
							}
							this.$self_$37595.audio.PlayOneShot(this.$self_$37595.SRhc8AmWfVo);
							if (170612 - 389960 != -219348)
							{
								continue;
							}
							goto IL_65;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (99132 - 271003 != -171870)
							{
								goto Block_5;
							}
							continue;
						}
						else if (Game.mGameState != eGameState.Start)
						{
							if (250708 - 147145 != 103563)
							{
								continue;
							}
							goto IL_150;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (217295 - 554028 == -336732)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (231248 - 64786 != 166462)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (284746 - 372930 != -88184)
							{
								continue;
							}
							if (this.$self_$37595.kE8c8FggtlY)
							{
								if (215232 - 363744 != -148512)
								{
									continue;
								}
								this.$self_$37595.audio.PlayOneShot(this.$self_$37595.kE8c8FggtlY);
								if (99373 - 418217 != -318844)
								{
									continue;
								}
							}
							this.$self_$37595.SendMessage("newGameMessage", "Match has started!");
							if (112442 - 244565 != -132123)
							{
								continue;
							}
							Chat.SubmitChat("none", "Match has started!", eChatType.system, eChatMode.system);
							if (162473 - 170995 == -8521)
							{
								continue;
							}
							this.YieldDefault(1);
							if (93595 - 531024 != -437429)
							{
								continue;
							}
							goto IL_45D;
						}
						break;
					default:
						if (35018 - 25730 != 9288)
						{
							continue;
						}
						break;
					}
					Debug.Log("Starting Match");
					if (162461 - 358095 == -195634)
					{
						Game.mGameState = eGameState.Start;
						if (82440 - 517635 != -435194)
						{
							Game.mStateTime = Time.time;
							if (283544 - 292452 != -8907)
							{
								goto Block_27;
							}
						}
					}
				}
				IL_65:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_5:
				IL_150:
				goto IL_45D;
				IL_175:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_12:
				goto IL_45D;
				IL_1E4:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_21F:
				Block_22:
				goto IL_45D;
				Block_23:
				goto IL_175;
				Block_27:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_45D:
				return false;
			}

			// Token: 0x060072B0 RID: 29360 RVA: 0x00F96694 File Offset: 0x00F94894
			internal static bool cZJhpEp6n5kw0luDeQCg()
			{
				return true;
			}

			// Token: 0x060072B1 RID: 29361 RVA: 0x00F96698 File Offset: 0x00F94898
			internal static bool Yf9VQHp668rKrGMLIgPN()
			{
				return false;
			}

			// Token: 0x04007839 RID: 30777
			internal M108_OneOnOneBout $self_$37595;
		}
	}

	// Token: 0x02001373 RID: 4979
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37597 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060072B2 RID: 29362 RVA: 0x00F9669C File Offset: 0x00F9489C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37597(M108_OneOnOneBout self_)
		{
			if (107859 - 172459 != -64599)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (137614 - 287636 == -150022)
				{
					base..ctor();
					if (8207 - 3113 == 5094)
					{
						this.$self_$37601 = self_;
						if (278591 - 533692 == -255101)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x00F96734 File Offset: 0x00F94934
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M108_OneOnOneBout.$ReturnToTown$37597.$(this.$self_$37601);
		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x00F96744 File Offset: 0x00F94944
		internal static bool pvhfTNp6iZ0p76G4thWS()
		{
			return true;
		}

		// Token: 0x060072B5 RID: 29365 RVA: 0x00F96748 File Offset: 0x00F94948
		internal static bool sK490Rp6Kew2RJl3nCWQ()
		{
			return false;
		}

		// Token: 0x0400783A RID: 30778
		internal M108_OneOnOneBout $self_$37601;

		// Token: 0x02001374 RID: 4980
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060072B6 RID: 29366 RVA: 0x00F9674C File Offset: 0x00F9494C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M108_OneOnOneBout self_)
			{
				if (242689 - 383132 != -140442)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60024 - 149204 == -89180)
					{
						base..ctor();
						if (127392 - 361760 != -234367)
						{
							this.$self_$37600 = self_;
							if (211615 - 270768 == -59153)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060072B7 RID: 29367 RVA: 0x00F967E4 File Offset: 0x00F949E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (112988 - 18580 != 94408)
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
						this.$self_$37600.LeaveGame();
						if (117736 - 188840 == -71103)
						{
							continue;
						}
						this.YieldDefault(1);
						if (210223 - 246864 != -36640)
						{
							goto Block_16;
						}
						continue;
					default:
						if (208149 - 311154 != -103005)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (127763 - 98451 == 29312)
					{
						Game.mStateTime = Time.time;
						if (268414 - 438169 == -169755)
						{
							this.$$switch$6352$37598 = PlayerData.SaveGuild;
							if (175360 - 41074 == 134286)
							{
								if (this.$$switch$6352$37598 == 1)
								{
									if (158826 - 119740 == 39087)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (293341 - 142583 == 150759)
									{
										continue;
									}
								}
								else if (this.$$switch$6352$37598 == 2)
								{
									if (81375 - 122219 != -40844)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (236876 - 20719 != 216157)
									{
										continue;
									}
								}
								else if (this.$$switch$6352$37598 == 3)
								{
									if (58787 - 548737 == -489949)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (206576 - 491498 == -284921)
									{
										continue;
									}
								}
								else if (this.$$switch$6352$37598 == 4)
								{
									if (53929 - 391780 == -337850)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (120977 - 227923 != -106946)
									{
										continue;
									}
								}
								else if (this.$$switch$6352$37598 == 5)
								{
									if (151236 - 134707 != 16529)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (253362 - 96785 != 156577)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (184707 - 511290 != -326583)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (84748 - 140148 != -55400)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (16951 - 478299 != -461348)
									{
										continue;
									}
								}
								this.$mGameGui$37599 = (GameGui)this.$self_$37600.GetComponent(typeof(GameGui));
								if (72624 - 326848 == -254224)
								{
									if (this.$mGameGui$37599)
									{
										if (254667 - 81974 != 172693)
										{
											continue;
										}
										this.$mGameGui$37599.close();
										if (12622 - 199132 == -186509)
										{
											continue;
										}
									}
									this.$self_$37600.SendMessage("fadeOut");
									if (194908 - 301714 == -106806)
									{
										goto IL_305;
									}
								}
							}
						}
					}
				}
				Block_16:
				goto IL_3AD;
				IL_305:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x060072B8 RID: 29368 RVA: 0x00F96BB0 File Offset: 0x00F94DB0
			internal static bool yaRrcsp6dIFb7uXpTaCH()
			{
				return true;
			}

			// Token: 0x060072B9 RID: 29369 RVA: 0x00F96BB4 File Offset: 0x00F94DB4
			internal static bool F6qW00p6JrnYEAnLGCm0()
			{
				return false;
			}

			// Token: 0x0400783B RID: 30779
			internal int $$switch$6352$37598;

			// Token: 0x0400783C RID: 30780
			internal GameGui $mGameGui$37599;

			// Token: 0x0400783D RID: 30781
			internal M108_OneOnOneBout $self_$37600;
		}
	}

	// Token: 0x02001375 RID: 4981
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37602 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060072BA RID: 29370 RVA: 0x00F96BB8 File Offset: 0x00F94DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37602(M108_OneOnOneBout self_)
		{
			if (259623 - 251623 != 8001)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (258804 - 219704 != 39101)
				{
					base..ctor();
					if (268659 - 590883 == -322224)
					{
						this.$self_$37605 = self_;
						if (89936 - 387883 != -297946)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x00F96C50 File Offset: 0x00F94E50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M108_OneOnOneBout.$ReturnToGuild$37602.$(this.$self_$37605);
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x00F96C60 File Offset: 0x00F94E60
		internal static bool iZ493Yp6D6t86ApwUhj2()
		{
			return true;
		}

		// Token: 0x060072BD RID: 29373 RVA: 0x00F96C64 File Offset: 0x00F94E64
		internal static bool tEyTmDp6vFLoGhV9cBrd()
		{
			return false;
		}

		// Token: 0x0400783E RID: 30782
		internal M108_OneOnOneBout $self_$37605;

		// Token: 0x02001376 RID: 4982
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060072BE RID: 29374 RVA: 0x00F96C68 File Offset: 0x00F94E68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M108_OneOnOneBout self_)
			{
				if (106921 - 112612 != -5691)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (13639 - 437845 == -424206)
					{
						base..ctor();
						if (87602 - 217896 == -130294)
						{
							this.$self_$37604 = self_;
							if (180296 - 511869 != -331572)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060072BF RID: 29375 RVA: 0x00F96D00 File Offset: 0x00F94F00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (187137 - 180424 != 6714)
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
						this.$self_$37604.LeaveGame();
						if (91100 - 78220 == 12881)
						{
							continue;
						}
						this.YieldDefault(1);
						if (10908 - 404457 != -393549)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (192268 - 440709 != -248441)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (133543 - 212441 != -78897)
					{
						Game.mStateTime = Time.time;
						if (253484 - 4668 == 248816)
						{
							Game.mNextGameCode = 31;
							if (185766 - 120488 != 65279)
							{
								this.$mGameGui$37603 = (GameGui)this.$self_$37604.GetComponent(typeof(GameGui));
								if (93268 - 583794 == -490526)
								{
									if (this.$mGameGui$37603)
									{
										if (77530 - 436177 != -358647)
										{
											continue;
										}
										this.$mGameGui$37603.close();
										if (79927 - 156634 != -76707)
										{
											continue;
										}
									}
									this.$self_$37604.SendMessage("fadeOut");
									if (33755 - 588610 != -554854)
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

			// Token: 0x060072C0 RID: 29376 RVA: 0x00F96EDC File Offset: 0x00F950DC
			internal static bool H5ybW0p6RMVj3cmjfbGq()
			{
				return true;
			}

			// Token: 0x060072C1 RID: 29377 RVA: 0x00F96EE0 File Offset: 0x00F950E0
			internal static bool o8PcrRp6ww4HUGLroFCS()
			{
				return false;
			}

			// Token: 0x0400783F RID: 30783
			internal GameGui $mGameGui$37603;

			// Token: 0x04007840 RID: 30784
			internal M108_OneOnOneBout $self_$37604;
		}
	}

	// Token: 0x02001377 RID: 4983
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37606 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060072C2 RID: 29378 RVA: 0x00F96EE4 File Offset: 0x00F950E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37606(M108_OneOnOneBout self_)
		{
			if (232768 - 340734 != -107965)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (19579 - 523964 == -504385)
				{
					base..ctor();
					if (264761 - 212533 != 52229)
					{
						this.$self_$37610 = self_;
						if (27309 - 316416 == -289107)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060072C3 RID: 29379 RVA: 0x00F96F7C File Offset: 0x00F9517C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M108_OneOnOneBout.$ReturnToCamp$37606.$(this.$self_$37610);
		}

		// Token: 0x060072C4 RID: 29380 RVA: 0x00F96F8C File Offset: 0x00F9518C
		internal static bool viUUYjp6qfiEx3QEWRDV()
		{
			return true;
		}

		// Token: 0x060072C5 RID: 29381 RVA: 0x00F96F90 File Offset: 0x00F95190
		internal static bool tSqYDPp67XRElr0bWdsx()
		{
			return false;
		}

		// Token: 0x04007841 RID: 30785
		internal M108_OneOnOneBout $self_$37610;

		// Token: 0x02001378 RID: 4984
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060072C6 RID: 29382 RVA: 0x00F96F94 File Offset: 0x00F95194
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M108_OneOnOneBout self_)
			{
				if (217782 - 101237 != 116546)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (86280 - 175077 != -88796)
					{
						base..ctor();
						if (66229 - 267595 == -201366)
						{
							this.$self_$37609 = self_;
							if (70870 - 85006 == -14136)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060072C7 RID: 29383 RVA: 0x00F9702C File Offset: 0x00F9522C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (89822 - 113849 != -24026)
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
						this.$self_$37609.LeaveGame();
						if (196086 - 23271 == 172816)
						{
							continue;
						}
						this.YieldDefault(1);
						if (127597 - 202514 != -74916)
						{
							goto Block_23;
						}
						continue;
					default:
						if (27136 - 272078 == -244941)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (5001 - 192669 == -187668)
					{
						Game.mStateTime = Time.time;
						if (264900 - 457509 == -192609)
						{
							this.$$switch$6354$37607 = PlayerData.SaveGuild;
							if (230701 - 160136 != 70566)
							{
								if (this.$$switch$6354$37607 == 1)
								{
									if (243838 - 595637 == -351798)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (171410 - 510535 == -339124)
									{
										continue;
									}
								}
								else if (this.$$switch$6354$37607 == 2)
								{
									if (150660 - 138006 == 12655)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (296733 - 597111 == -300377)
									{
										continue;
									}
								}
								else if (this.$$switch$6354$37607 == 3)
								{
									if (209088 - 594444 != -385356)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (158295 - 201267 == -42971)
									{
										continue;
									}
								}
								else if (this.$$switch$6354$37607 == 4)
								{
									if (66271 - 73443 != -7172)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (66246 - 247338 != -181092)
									{
										continue;
									}
								}
								else if (this.$$switch$6354$37607 == 5)
								{
									if (182257 - 369654 != -187397)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (297678 - 191017 != 106661)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (10753 - 491885 == -481131)
									{
										continue;
									}
								}
								this.$mGameGui$37608 = (GameGui)this.$self_$37609.GetComponent(typeof(GameGui));
								if (238851 - 402397 == -163546)
								{
									if (this.$mGameGui$37608)
									{
										if (39112 - 237723 != -198611)
										{
											continue;
										}
										this.$mGameGui$37608.close();
										if (42377 - 15945 == 26433)
										{
											continue;
										}
									}
									this.$self_$37609.SendMessage("fadeOut");
									if (132842 - 73547 != 59296)
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

			// Token: 0x060072C8 RID: 29384 RVA: 0x00F973B0 File Offset: 0x00F955B0
			internal static bool darbRUp6PIHIteB986OQ()
			{
				return true;
			}

			// Token: 0x060072C9 RID: 29385 RVA: 0x00F973B4 File Offset: 0x00F955B4
			internal static bool iHbBSap60M5O7Fr3w6gx()
			{
				return false;
			}

			// Token: 0x04007842 RID: 30786
			internal int $$switch$6354$37607;

			// Token: 0x04007843 RID: 30787
			internal GameGui $mGameGui$37608;

			// Token: 0x04007844 RID: 30788
			internal M108_OneOnOneBout $self_$37609;
		}
	}
}
