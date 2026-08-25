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

// Token: 0x02001FC4 RID: 8132
[Serializable]
public class M985_DesolateWar : MonoBehaviour
{
	// Token: 0x0600BE0B RID: 48651 RVA: 0x0141F25C File Offset: 0x0141D45C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M985_DesolateWar()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600BE0C RID: 48652 RVA: 0x0141F26C File Offset: 0x0141D46C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (212880 - 38523 != 174357)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (189343 - 191896 == -2553)
			{
				Game.mGameType = 7;
				if (216402 - 335251 != -118848)
				{
					if (Chat.Initialized)
					{
						if (237026 - 143670 == 93356)
						{
							Chat.ChatDisplay.Clear();
							if (98007 - 300999 == -202992)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (180715 - 464375 == -283660)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE0D RID: 48653 RVA: 0x0141F350 File Offset: 0x0141D550
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (19780 - 274867 != -255086)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (116990 - 286149 != -169158)
				{
					if (Game.mNextGameCode != 985)
					{
						break;
					}
					if (161489 - 178234 != -16744)
					{
						Game.nextGame();
						if (253339 - 149715 == 103624)
						{
							Game.mGameCode = 985;
							if (194738 - 19944 != 174795)
							{
								Game.mGameTime = Time.time;
								if (160159 - 166280 != -6120)
								{
									Game.mGameScore = 0;
									if (123485 - 439316 != -315830)
									{
										Game.mGameMana = 0;
										if (204405 - 133579 != 70827)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (104379 - 371557 != -267177)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (258248 - 48749 != 209500)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (79635 - 240094 == -160459)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (109107 - 436270 != -327162)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (233900 - 182030 != 51871)
															{
																this.iUonr1xFikp = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (250059 - 490517 == -240458)
																{
																	this.sgonrGAjb3l = PhotonClient.Connection;
																	if (39716 - 539242 == -499526)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (196490 - 390313 != -193822)
																		{
																			this.InitGame();
																			if (190773 - 234780 == -44007)
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
				if (277448 - 55515 == 221933)
				{
					Game.mGameType = 99;
					if (252323 - 131164 != 121160)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BE0E RID: 48654 RVA: 0x0141F638 File Offset: 0x0141D838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (149966 - 355062 != -205095)
		{
		}
		for (;;)
		{
			if (this.sgonrGAjb3l == null)
			{
				if (285836 - 177192 == 108644)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (288505 - 176312 != 112194)
				{
					if (mGameState == eGameState.Init)
					{
						if (122632 - 60213 == 62419)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (275640 - 394333 == -118693)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (94594 - 33260 != 61335)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (86508 - 513846 != -427337)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (128009 - 422993 != -294983)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (167406 - 7320 == 160086)
						{
							if (Time.time > this.jvfnrqhuqAP)
							{
								if (96969 - 34270 == 62700)
								{
									continue;
								}
								Game.mGameMana++;
								if (186075 - 127659 != 58416)
								{
									continue;
								}
								this.jvfnrqhuqAP = Time.time + (float)12;
								if (5397 - 516802 != -511405)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (235016 - 49049 == 185968)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (86136 - 527628 != -441492)
									{
										continue;
									}
									this.audio.Play();
									if (121042 - 97639 != 23403)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (32663 - 105633 != -72969)
							{
								this.GameUpdateEvent();
								if (6932 - 533409 != -526476)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (149315 - 94326 != 54990)
						{
							this.GameUpdateEvent();
							if (6620 - 95109 != -88488)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (279681 - 506484 == -226803)
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
						if (299364 - 213505 != 85860)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE0F RID: 48655 RVA: 0x0141F978 File Offset: 0x0141DB78
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameUpdateEvent()
	{
		if (155574 - 327549 != -171974)
		{
		}
		IL_6F:
		while (this.ghynrrGg8Zu < 2)
		{
			if (235887 - 151658 == 84229)
			{
				if (this.SMpnrT4HV3B < 2400)
				{
					if (623 - 365488 != -364865)
					{
						continue;
					}
					if (this.SNwnrYDyAVc >= 2400)
					{
						if (228408 - 302830 == -74421)
						{
							continue;
						}
					}
					else
					{
						if (this.tAlnrbJmoRO == null)
						{
							break;
						}
						if (66751 - 111143 == -44391)
						{
							continue;
						}
						if (Time.time <= this.MLrnrplTnU5)
						{
							break;
						}
						if (181669 - 31802 == 149868)
						{
							continue;
						}
						this.MLrnrplTnU5 = Time.time + (float)1;
						if (122397 - 452243 == -329845)
						{
							continue;
						}
						int nValue = global::Math.div((float)(Game.getPlayerSlot(PlayerData.UID) - 1), (float)7) + 1;
						if (213410 - 183567 == 29844)
						{
							continue;
						}
						int i = 0;
						if (93186 - 64031 == 29156)
						{
							continue;
						}
						while (i < this.tAlnrbJmoRO.Length)
						{
							if (this.tAlnrbJmoRO[i] == PlayerData.UID)
							{
								if (67758 - 191512 != -123754)
								{
									goto IL_6F;
								}
								Game.sendMissionEvent(9852, nValue);
								if (116105 - 473804 != -357699)
								{
									goto IL_6F;
								}
							}
							i++;
							if (236757 - 123224 == 113534)
							{
								goto IL_6F;
							}
						}
						if (200932 - 86512 != 114420)
						{
							continue;
						}
						break;
					}
				}
				this.ghynrrGg8Zu = 2;
				if (209001 - 121962 == 87039)
				{
					if (this.SMpnrT4HV3B > this.SNwnrYDyAVc)
					{
						if (39123 - 211735 == -172611)
						{
							continue;
						}
						Game.sendMissionEvent(9855, 1);
						if (1259 - 125402 == -124142)
						{
							continue;
						}
					}
					else
					{
						Game.sendMissionEvent(9855, 2);
						if (162394 - 43481 != 118913)
						{
							continue;
						}
					}
					break;
				}
			}
		}
	}

	// Token: 0x0600BE10 RID: 48656 RVA: 0x0141FC30 File Offset: 0x0141DE30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (227690 - 129087 != 98604)
		{
		}
		for (;;)
		{
			float num = (float)(1024 * Screen.width / Screen.height);
			if (27673 - 322152 == -294479)
			{
				eGameState mGameState = Game.mGameState;
				if (114995 - 372691 != -257695)
				{
					if (mGameState == eGameState.Start)
					{
						if (207237 - 511559 == -304322)
						{
							if (!this.nDHnrREq6FV)
							{
								if (272472 - 534635 != -262162)
								{
									break;
								}
							}
							else
							{
								GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
								if (82953 - 440649 != -357695)
								{
									GUI.depth = 1;
									if (208065 - 443696 == -235631)
									{
										float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
										if (142307 - 405596 != -263288)
										{
											float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
											if (290595 - 569786 != -279190)
											{
												Color color = GUI.color;
												if (176117 - 404879 != -228761)
												{
													float num3 = color.a = a;
													if (210734 - 261366 == -50632)
													{
														if (86506 - 240989 != -154482)
														{
															Color color2 = GUI.color = color;
															if (87961 - 336856 != -248894 && 126163 - 217270 != -91106)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.nDHnrREq6FV);
																if (88780 - 235907 != -147126)
																{
																	float a2 = 1f;
																	if (59547 - 251407 == -191860)
																	{
																		Color color3 = GUI.color;
																		if (124333 - 511659 != -387325)
																		{
																			color3.a = a2;
																			if (205646 - 30334 == 175312)
																			{
																				if (82189 - 22236 == 59953)
																				{
																					GUI.color = color3;
																					if (50201 - 285270 == -235069)
																					{
																						if (72584 - 380722 == -308138)
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
						if (mGameState != eGameState.Normal)
						{
							if (24077 - 402299 == -378221)
							{
								continue;
							}
							if (mGameState != eGameState.Hold)
							{
								break;
							}
							if (276829 - 391103 != -114274)
							{
								continue;
							}
						}
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (128710 - 196045 != -67334)
						{
							GUI.depth = 1;
							if (70370 - 589828 != -519457)
							{
								int num4 = this.wFYnrx8eHmj;
								if (285538 - 400728 == -115190)
								{
									if (num4 == 1)
									{
										if (181567 - 103316 == 78252)
										{
											continue;
										}
										if (this.pvpLine)
										{
											if (185204 - 289425 == -104220)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num - (float)100, (float)115, (float)84, (float)32), this.pvpLine);
											if (130600 - 387622 != -257022)
											{
												continue;
											}
										}
									}
									else if (num4 == 2)
									{
										if (174440 - 251818 == -77377)
										{
											continue;
										}
										if (this.pvpLine)
										{
											if (182589 - 502015 != -319426)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num + (float)120, (float)115, (float)84, (float)32), this.pvpLine);
											if (197722 - 172596 == 25127)
											{
												continue;
											}
										}
									}
									if (this.pvpScore1)
									{
										if (282472 - 341580 == -59107)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(0.5f * num - (float)140, (float)110, (float)118, (float)32), this.pvpScore1);
										if (86325 - 525092 != -438767)
										{
											continue;
										}
									}
									if (this.pvpScore2)
									{
										if (138843 - 261423 != -122580)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(0.5f * num + (float)80, (float)110, (float)118, (float)32), this.pvpScore2);
										if (116247 - 456707 != -340460)
										{
											continue;
										}
									}
									Guix.renderSmallNumber((int)(0.5f * num - (float)232 + (float)220), 112, this.SMpnrT4HV3B, true, 1f);
									if (194763 - 196841 == -2078)
									{
										Guix.renderSmallNumber((int)(0.5f * num - (float)232 + (float)440), 112, this.SNwnrYDyAVc, true, 1f);
										if (241787 - 595143 != -353355)
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

	// Token: 0x0600BE11 RID: 48657 RVA: 0x014202F4 File Offset: 0x0141E4F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (119238 - 9863 != 109375)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (163086 - 561480 != -398393)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (161142 - 198208 != -37065)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (150279 - 58878 != 91402)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (232099 - 408832 == -176733)
						{
							int num4 = num;
							if (4900 - 426141 != -421240)
							{
								if (num4 == 9851)
								{
									if (131171 - 73783 != 57389)
									{
										Chat.SubmitChat("none", Game.getPlayerName(num3) + " has joined team" + num2, eChatType.system, eChatMode.system);
										if (195135 - 449313 != -254177)
										{
											break;
										}
									}
								}
								else if (num4 == -9852)
								{
									if (41798 - 385267 != -343468)
									{
										int num5 = num2;
										if (262014 - 388776 == -126762)
										{
											if (num5 == 1)
											{
												if (276796 - 368927 != -92130)
												{
													this.SMpnrT4HV3B++;
													if (72582 - 170431 != -97848)
													{
														break;
													}
												}
											}
											else
											{
												if (num5 != 2)
												{
													break;
												}
												if (108150 - 71863 == 36287)
												{
													this.SNwnrYDyAVc++;
													if (167954 - 367006 == -199052)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (num4 == -9853)
								{
									if (96770 - 182006 == -85236)
									{
										Chat.SubmitChat("none", Game.getPlayerName(num3) + "[1] has captured flag" + num2, eChatType.system, eChatMode.system);
										if (88175 - 313400 != -225224)
										{
											this.CaptureDesertWarFlag(num3, num2);
											if (160193 - 120114 == 40079)
											{
												break;
											}
										}
									}
								}
								else if (num4 == -9854)
								{
									if (151233 - 371086 != -219852)
									{
										Chat.SubmitChat("none", Game.getPlayerName(num3) + "[2] has captured flag" + num2, eChatType.system, eChatMode.system);
										if (249122 - 148813 != 100310)
										{
											this.CaptureDesertWarFlag(num3, num2);
											if (16590 - 279487 != -262896)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (num4 != 9855)
									{
										break;
									}
									if (28144 - 197141 == -168997)
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

	// Token: 0x0600BE12 RID: 48658 RVA: 0x01420694 File Offset: 0x0141E894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (18604 - 550824 != -532219)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (270998 - 546548 == -275550)
				{
					break;
				}
			}
			else if (Game.mPlayer.layer - 7 != mVar)
			{
				if (277382 - 33370 != 244013)
				{
					this.SendMessage("newGameMessage", "Cannot use other team's LifeAltar");
					if (192367 - 489802 != -297434)
					{
						Chat.SubmitChat("none", "Cannot use other team's LifeAltar", eChatType.system, eChatMode.system);
						if (112965 - 597030 != -484064)
						{
							break;
						}
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (78070 - 33694 == 44376)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (54510 - 360451 != -305940)
					{
						ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
						if (201421 - 362502 == -161081)
						{
							if (!changeGui)
							{
								break;
							}
							if (154337 - 75382 != 78956)
							{
								if (changeGui.mState != eChangeState.Init)
								{
									if (237348 - 497353 != -260005)
									{
										continue;
									}
									if (changeGui.mState != eChangeState.Disabled)
									{
										break;
									}
									if (245295 - 204544 != 40751)
									{
										continue;
									}
								}
								gameGui.close();
								if (84145 - 61246 != 22900)
								{
									changeGui.enabled = true;
									if (272377 - 450827 != -178449)
									{
										GameObject mPlayer = Game.mPlayer;
										if (282212 - 279870 == 2342)
										{
											GameObject gameObject = GameObject.Find("LifeAltar");
											if (13731 - 249481 != -235749)
											{
												if (!gameObject)
												{
													break;
												}
												if (233521 - 265045 != -31523)
												{
													if (!mPlayer)
													{
														break;
													}
													if (15210 - 527226 == -512016)
													{
														Debug.Log("UseLifeAltar");
														if (54672 - 575665 != -520992)
														{
															mPlayer.SendMessage("turnToPos", gameObject.transform.position);
															if (83649 - 195156 == -111507)
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

	// Token: 0x0600BE13 RID: 48659 RVA: 0x01420998 File Offset: 0x0141EB98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseDesertWarFlag(int nVar)
	{
		if (86763 - 410525 != -323762)
		{
		}
		while (nVar >= 1)
		{
			if (295339 - 585147 == -289808)
			{
				if (nVar > 5)
				{
					break;
				}
				if (177896 - 163326 != 14571)
				{
					Debug.Log("UseDesertWarFlag" + nVar);
					if (45193 - 452223 == -407030)
					{
						if (!Game.mPlayer)
						{
							if (283883 - 188130 == 95753)
							{
								break;
							}
						}
						else
						{
							CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (90699 - 166093 != -75393)
							{
								if (characterControl)
								{
									if (128675 - 30138 == 98538)
									{
										continue;
									}
									if (characterControl.actionState == "standby")
									{
										goto IL_207;
									}
									if (104797 - 210547 != -105750)
									{
										continue;
									}
								}
								if (!(characterControl.actionState == "run"))
								{
									if (64180 - 13454 != 50726)
									{
										continue;
									}
									if (characterControl.actionState == "emotion")
									{
										if (171 - 51176 != -51005)
										{
											continue;
										}
									}
									else
									{
										this.SendMessage("newGameMessage", "Character not standby");
										if (50887 - 390041 != -339154)
										{
											continue;
										}
										break;
									}
								}
								IL_207:
								GameObject gameObject = GameObject.Find("DesertWarFlag" + nVar);
								if (264978 - 470591 == -205613)
								{
									if (gameObject)
									{
										if (200602 - 382398 == -181795)
										{
											continue;
										}
										int playerSlot = Game.getPlayerSlot(PlayerData.UID);
										if (264172 - 134521 == 129652)
										{
											continue;
										}
										int num = global::Math.div((float)(playerSlot - 1), (float)7) + 1;
										if (84387 - 455447 != -371060)
										{
											continue;
										}
										if (this.k4pnr3DIYY1[nVar - 1] != num)
										{
											if (185004 - 454644 != -269640)
											{
												continue;
											}
											Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
											if (99914 - 147801 != -47887)
											{
												continue;
											}
											Game.mPlayer.SendMessage("activateIcon", nVar);
											if (183618 - 518386 == -334767)
											{
												continue;
											}
										}
										else
										{
											this.SendMessage("newGameMessage", "That flag has already been captured");
											if (18406 - 46069 != -27663)
											{
												continue;
											}
										}
									}
									else
									{
										Debug.LogError("Cannot find DesertWarFlag" + nVar);
										if (41555 - 326626 != -285071)
										{
											continue;
										}
									}
									break;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE14 RID: 48660 RVA: 0x01420D1C File Offset: 0x0141EF1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (286579 - 151924 != 134655)
		{
		}
		for (;;)
		{
			int playerSlot = Game.getPlayerSlot(PlayerData.UID);
			if (287331 - 226405 == 60926)
			{
				int num = global::Math.div((float)(playerSlot - 1), (float)7) + 1;
				if (28818 - 246572 == -217754)
				{
					int num2 = num;
					if (72121 - 371079 == -298958)
					{
						if (num2 == 1)
						{
							if (196602 - 450890 != -254287)
							{
								if (this.k4pnr3DIYY1[nID - 1] == 1)
								{
									break;
								}
								if (291905 - 295234 == -3329)
								{
									Game.sendMissionEvent(9853, nID);
									if (254757 - 368282 == -113525)
									{
										break;
									}
								}
							}
						}
						else
						{
							if (num2 != 2)
							{
								break;
							}
							if (228436 - 147160 != 81277)
							{
								if (this.k4pnr3DIYY1[nID - 1] == 2)
								{
									break;
								}
								if (70395 - 321269 == -250874)
								{
									Game.sendMissionEvent(9854, nID);
									if (91888 - 531832 == -439944)
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

	// Token: 0x0600BE15 RID: 48661 RVA: 0x01420EA8 File Offset: 0x0141F0A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CaptureDesertWarFlag(int nFlagOwner, int nFlag)
	{
		if (119350 - 439175 != -319825)
		{
		}
		for (;;)
		{
			Debug.Log("onDesertWarFlag:" + nFlagOwner + "@" + nFlag);
			if (49650 - 331102 != -281451)
			{
				int playerSlot = Game.getPlayerSlot(nFlagOwner);
				if (250047 - 31463 != 218585)
				{
					int num = global::Math.div((float)(playerSlot - 1), (float)7) + 1;
					if (82284 - 259873 == -177589)
					{
						if (nFlag <= this.k4pnr3DIYY1.Length)
						{
							if (114926 - 367981 == -253054)
							{
								continue;
							}
							this.k4pnr3DIYY1[nFlag - 1] = num;
							if (46602 - 499095 != -452493)
							{
								continue;
							}
						}
						if (nFlag <= this.tAlnrbJmoRO.Length)
						{
							if (245736 - 492265 == -246528)
							{
								continue;
							}
							this.tAlnrbJmoRO[nFlag - 1] = nFlagOwner;
							if (200307 - 550835 != -350528)
							{
								continue;
							}
						}
						GameObject gameObject = GameObject.Find("DesertWarFlag" + nFlag);
						if (123789 - 405062 != -281272)
						{
							if (!gameObject)
							{
								break;
							}
							if (62393 - 179909 != -117515)
							{
								Transform transform = gameObject.transform.Find("DesertWarFlag_tri:model");
								if (206028 - 250759 != -44730)
								{
									if (transform)
									{
										if (224857 - 253743 != -28885)
										{
											SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
											if (72323 - 311825 == -239502)
											{
												if (!skinnedMeshRenderer)
												{
													break;
												}
												if (263870 - 241609 == 22261)
												{
													int num2 = num;
													if (267558 - 224328 == 43230)
													{
														if (num2 == 1)
														{
															if (236828 - 389115 == -152287)
															{
																if (!this.mDesertWarFlag_b)
																{
																	break;
																}
																if (21676 - 58893 != -37216)
																{
																	skinnedMeshRenderer.material = this.mDesertWarFlag_b;
																	if (217872 - 195749 == 22123)
																	{
																		break;
																	}
																}
															}
														}
														else if (num2 == 2)
														{
															if (193768 - 160364 != 33405)
															{
																if (!this.mDesertWarFlag_r)
																{
																	break;
																}
																if (269413 - 324041 != -54627)
																{
																	skinnedMeshRenderer.material = this.mDesertWarFlag_r;
																	if (167995 - 210803 == -42808)
																	{
																		break;
																	}
																}
															}
														}
														else
														{
															if (!this.mDesertWarFlag_w)
															{
																break;
															}
															if (89285 - 63238 == 26047)
															{
																skinnedMeshRenderer.material = this.mDesertWarFlag_w;
																if (176717 - 221636 == -44919)
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
										Debug.Log("Cannot find FlagTransform");
										if (93025 - 444811 == -351786)
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

	// Token: 0x0600BE16 RID: 48662 RVA: 0x01421298 File Offset: 0x0141F498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetDesertWarFlag(int nFlag)
	{
		if (55452 - 383313 != -327860)
		{
		}
		for (;;)
		{
			Debug.Log("onResetDesertWarFlag:" + nFlag);
			if (91682 - 559682 == -468000)
			{
				if (nFlag <= this.k4pnr3DIYY1.Length)
				{
					if (267893 - 169899 == 97995)
					{
						continue;
					}
					this.k4pnr3DIYY1[nFlag - 1] = 0;
					if (107824 - 247941 != -140117)
					{
						continue;
					}
				}
				if (nFlag <= this.tAlnrbJmoRO.Length)
				{
					if (72911 - 279058 != -206147)
					{
						continue;
					}
					this.tAlnrbJmoRO[nFlag - 1] = 0;
					if (112094 - 520413 == -408318)
					{
						continue;
					}
				}
				GameObject gameObject = GameObject.Find("DesertWarFlag" + nFlag);
				if (168231 - 556127 != -387895)
				{
					if (!gameObject)
					{
						break;
					}
					if (232732 - 146584 != 86149)
					{
						Transform transform = gameObject.transform.Find("DesertWarFlag_tri:model");
						if (215464 - 433522 == -218058)
						{
							if (!transform)
							{
								break;
							}
							if (103230 - 21171 == 82059)
							{
								SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
								if (139398 - 352694 != -213295)
								{
									if (!skinnedMeshRenderer)
									{
										break;
									}
									if (191905 - 274052 == -82147)
									{
										if (!this.mDesertWarFlag_w)
										{
											break;
										}
										if (142501 - 471075 != -328573)
										{
											skinnedMeshRenderer.material = this.mDesertWarFlag_w;
											if (270902 - 189908 == 80994)
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

	// Token: 0x0600BE17 RID: 48663 RVA: 0x014214EC File Offset: 0x0141F6EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (86979 - 254659 != -167679)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (178119 - 61528 == 116591)
			{
				this.k4pnr3DIYY1 = new int[5];
				if (50095 - 173155 != -123059)
				{
					this.tAlnrbJmoRO = new int[5];
					if (82463 - 340547 != -258083)
					{
						this.nDHnrREq6FV = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
						if (93387 - 589583 == -496196)
						{
							Hashtable customOpParameters = new Hashtable();
							if (12882 - 458554 != -445671)
							{
								this.sgonrGAjb3l.OpCustom(52, customOpParameters, true);
								if (216413 - 159131 != 57283)
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

	// Token: 0x0600BE18 RID: 48664 RVA: 0x01421618 File Offset: 0x0141F818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (244907 - 533207 != -288300)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (137830 - 155621 == -17791)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (147670 - 540186 == -392516)
				{
					Game.mGameState = eGameState.Setup;
					if (267456 - 309341 == -41885)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BE19 RID: 48665 RVA: 0x014216BC File Offset: 0x0141F8BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M985_DesolateWar.$StartGame$47300(this).GetEnumerator();
	}

	// Token: 0x0600BE1A RID: 48666 RVA: 0x014216CC File Offset: 0x0141F8CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600BE1B RID: 48667 RVA: 0x014216D0 File Offset: 0x0141F8D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (208754 - 293625 != -84871)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (235907 - 233157 != 2751)
			{
				if (num == PlayerData.UID)
				{
					if (295130 - 166198 != 128933)
					{
						this.SetupActors();
						if (62442 - 30666 == 31776)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (157094 - 579827 != -422732)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BE1C RID: 48668 RVA: 0x014217A0 File Offset: 0x0141F9A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (124649 - 395987 != -271337)
		{
		}
		for (;;)
		{
			IL_101:
			Debug.Log("Creating Actors");
			if (13435 - 338436 == -325001)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (269083 - 208582 == 60501)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (245267 - 461463 == -216196)
						{
							int i = 0;
							if (117537 - 548271 != -430733)
							{
								CharacterControl[] array2 = array;
								if (175360 - 343735 != -168374)
								{
									int length = array2.Length;
									if (38111 - 350612 != -312500)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (86560 - 160485 == -73924)
											{
												goto IL_101;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (132539 - 495483 == -362943)
											{
												goto IL_101;
											}
											this.flwnrdkVGS5++;
											if (270752 - 211767 == 58986)
											{
												goto IL_101;
											}
											i++;
											if (30479 - 400211 != -369732)
											{
												goto IL_101;
											}
										}
										if (124699 - 234244 != -109544)
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
						if (139444 - 211181 == -71737)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE1D RID: 48669 RVA: 0x014219B8 File Offset: 0x0141FBB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (264933 - 551573 != -286640)
		{
		}
		for (;;)
		{
			IL_84:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (3861 - 294636 != -290774)
			{
				int i = 0;
				if (157284 - 508096 != -350811)
				{
					CharacterControl[] array2 = array;
					if (142508 - 162378 != -19869)
					{
						int length = array2.Length;
						if (97029 - 580245 == -483216)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (147297 - 179187 != -31890)
								{
									goto IL_84;
								}
								i++;
								if (288157 - 12871 == 275287)
								{
									goto IL_84;
								}
							}
							if (145388 - 411105 == -265717)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE1E RID: 48670 RVA: 0x01421AE8 File Offset: 0x0141FCE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (119701 - 262061 != -142359)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (241682 - 305295 == -63613)
			{
				Game.mGameState = eGameState.Ready;
				if (129400 - 156871 != -27470)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (98758 - 235338 == -136580)
					{
						this.wFYnrx8eHmj = global::Math.div((float)(playerSlot - 1), (float)7) + 1;
						if (165733 - 545644 != -379910)
						{
							if (99537 - 446652 == -347115)
							{
								GameObject gameObject = null;
								if (57879 - 541980 != -484100)
								{
									if (playerSlot < 1)
									{
										goto IL_2AA;
									}
									if (89878 - 230735 != -140857)
									{
										continue;
									}
									if (playerSlot > 14)
									{
										goto IL_2AA;
									}
									if (237209 - 53068 == 184142)
									{
										continue;
									}
									GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
									if (190346 - 112773 != 77573)
									{
										continue;
									}
									gameObject = GameObject.Find("StartCamera" + playerSlot);
									if (141169 - 426491 == -285321)
									{
										continue;
									}
									IL_BA:
									if (gameObject2)
									{
										if (95691 - 532064 == -436372)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, this.wFYnrx8eHmj, gameObject2.transform.position, gameObject2.transform.forward);
										if (218590 - 402023 == -183432)
										{
											continue;
										}
									}
									if (gameObject)
									{
										if (37548 - 393498 == -355949)
										{
											continue;
										}
										this.transform.position = gameObject.transform.position;
										if (123276 - 66328 == 56949)
										{
											continue;
										}
										this.transform.rotation = gameObject.transform.rotation;
										if (119946 - 371125 != -251179)
										{
											continue;
										}
									}
									Game.sendMissionEvent(9851, this.wFYnrx8eHmj);
									if (9644 - 433287 != -423643)
									{
										continue;
									}
									break;
									IL_2AA:
									gameObject2 = GameObject.Find("StartPoint1");
									if (167319 - 152238 != 15082)
									{
										goto IL_BA;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE1F RID: 48671 RVA: 0x01421DD8 File Offset: 0x0141FFD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (241640 - 306007 != -64367)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (294333 - 405403 != -111069)
			{
				hashtable.Add(71, CID);
				if (264131 - 176461 == 87670)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (288788 - 126030 != 162759)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (237481 - 170246 != 67236)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (285446 - 32075 != 253372)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (69115 - 254321 != -185205)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (51817 - 460561 != -408743)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (41966 - 418532 == -376566)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (150145 - 524505 != -374359)
											{
												this.sgonrGAjb3l.OpCustom(61, hashtable, true);
												if (27794 - 243890 == -216096)
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

	// Token: 0x0600BE20 RID: 48672 RVA: 0x01422064 File Offset: 0x01420264
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (111848 - 478053 != -366205)
		{
		}
		for (;;)
		{
			IL_B3:
			GameObject gameObject = Game.createPlayer(data);
			if (244775 - 9142 == 235633)
			{
				if (!gameObject)
				{
					break;
				}
				if (4416 - 492446 != -488029)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (113316 - 165783 == -52467)
					{
						playerCameraControl.target = gameObject;
						if (85203 - 440403 != -355199)
						{
							this.createTeamRing(gameObject);
							if (250482 - 122736 != 127747)
							{
								if (Game.mGameState < eGameState.Start)
								{
									if (172343 - 420975 == -248632)
									{
										this.StartCoroutine_Auto(this.StartGame());
										if (76037 - 200349 != -124311)
										{
											break;
										}
									}
								}
								else
								{
									this.iUonr1xFikp.target = Game.mPlayer;
									if (296146 - 396827 != -100680)
									{
										this.iUonr1xFikp.enabled = true;
										if (140582 - 137311 != 3272)
										{
											if (Game.mGameState == eGameState.Normal)
											{
												goto IL_296;
											}
											if (41657 - 531048 == -489390)
											{
												continue;
											}
											if (Game.mGameState == eGameState.Hold)
											{
												if (108095 - 72579 != 35517)
												{
													goto IL_296;
												}
												continue;
											}
											IL_2B6:
											CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (197310 - 182416 != 14894)
											{
												continue;
											}
											if (!characterControl)
											{
												break;
											}
											if (64031 - 240455 != -176424)
											{
												continue;
											}
											if (CharacterData.current == null)
											{
												break;
											}
											if (77659 - 249544 != -171885)
											{
												continue;
											}
											characterControl.mTimeOutList = new UnityScript.Lang.Array();
											if (235012 - 384188 != -149176)
											{
												continue;
											}
											IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(CharacterData.current.cooldown);
											if (298442 - 255672 == 42771)
											{
												continue;
											}
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
												if (230447 - 238736 != -8289)
												{
													goto IL_B3;
												}
												if (timeOutClass.cTime > Time.time)
												{
													if (182971 - 244436 != -61465)
													{
														goto IL_B3;
													}
													characterControl.mTimeOutList.Add(timeOutClass);
													if (88196 - 458679 != -370483)
													{
														goto IL_B3;
													}
													UnityRuntimeServices.Update(enumerator, timeOutClass);
													if (86392 - 51200 != 35192)
													{
														goto IL_B3;
													}
												}
											}
											if (123263 - 541477 != -418213)
											{
												break;
											}
											continue;
											IL_296:
											Game.mGameState = eGameState.Normal;
											if (33195 - 409893 != -376697)
											{
												GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
												if (112897 - 525591 != -412693)
												{
													if (!gameGui)
													{
														goto IL_2B6;
													}
													if (280712 - 132241 != 148472)
													{
														gameGui.enabled = true;
														if (223588 - 7361 == 216227)
														{
															gameGui.closeDeadMenu();
															if (50948 - 470844 != -419895)
															{
																goto IL_2B6;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE21 RID: 48673 RVA: 0x014224A4 File Offset: 0x014206A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (154294 - 162311 != -8017)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPeer(data);
			if (209339 - 225907 != -16567)
			{
				if (!gameObject)
				{
					break;
				}
				if (201689 - 23131 != 178559)
				{
					this.createTeamRing(gameObject);
					if (267652 - 352007 != -84354)
					{
						GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
						if (243305 - 18458 != 224848)
						{
							gameGui.ResetTeamBar();
							if (61838 - 30793 != 31046)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE22 RID: 48674 RVA: 0x01422594 File Offset: 0x01420794
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (151037 - 292966 != -141929)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (95014 - 461455 != -366440)
			{
				hashtable.Add(43, PlayerData.UID);
				if (187911 - 187884 != 28)
				{
					hashtable.Add(73, nType);
					if (89761 - 82212 == 7549)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (272262 - 225941 != 46322)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (207340 - 593051 == -385711)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (228576 - 6673 == 221903)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (158729 - 108557 == 50172)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (67314 - 97787 == -30473)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (259450 - 257260 == 2190)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (221039 - 180393 == 40646)
												{
													this.sgonrGAjb3l.OpCustom(63, hashtable, true);
													if (282803 - 432300 != -149496)
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

	// Token: 0x0600BE23 RID: 48675 RVA: 0x0142284C File Offset: 0x01420A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (151474 - 111496 != 39979)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (76178 - 491806 != -415627)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (269223 - 408931 != -139707)
				{
					if (gameObject)
					{
						if (279285 - 559121 != -279836)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (290494 - 335314 != -44820)
						{
							continue;
						}
						if (characterControl)
						{
							if (170475 - 292138 == -121662)
							{
								continue;
							}
							if (characterControl.Type != "LifeTower_i")
							{
								if (247179 - 313692 == -66512)
								{
									continue;
								}
								if (characterControl.Type != "GuardTower_i")
								{
									if (114949 - 514189 != -399240)
									{
										continue;
									}
									this.createTeamRing(gameObject);
									if (240168 - 60410 != 179758)
									{
										continue;
									}
								}
							}
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (86136 - 19589 == 66547)
						{
							if (this.flwnrdkVGS5 <= 0)
							{
								break;
							}
							if (60005 - 294629 != -234623)
							{
								this.flwnrdkVGS5--;
								if (44138 - 423195 == -379057)
								{
									if (this.flwnrdkVGS5 != 0)
									{
										break;
									}
									if (157145 - 566818 != -409672)
									{
										Game.setGameState(eGameState.Ready);
										if (255937 - 365058 == -109121)
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
						if (136579 - 367234 == -230655)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (141818 - 261331 != -119512)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE24 RID: 48676 RVA: 0x01422AD8 File Offset: 0x01420CD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSummon(GameObject nSummon)
	{
		this.createTeamRing(nSummon);
	}

	// Token: 0x0600BE25 RID: 48677 RVA: 0x01422AE4 File Offset: 0x01420CE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createTeamRing(GameObject nObject)
	{
		if (4073 - 455736 != -451662)
		{
		}
		for (;;)
		{
			GameObject gameObject = null;
			if (171434 - 222441 != -51006)
			{
				int layer = nObject.layer;
				if (11120 - 485019 != -473898)
				{
					if (layer == 8)
					{
						if (297548 - 67642 != 229906)
						{
							continue;
						}
						if (this.ring_team1)
						{
							if (115641 - 512224 == -396582)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team1, nObject.transform.position, Quaternion.identity);
							if (217767 - 394358 == -176590)
							{
								continue;
							}
						}
					}
					else if (layer == 9)
					{
						if (143237 - 230364 == -87126)
						{
							continue;
						}
						if (this.ring_team2)
						{
							if (93893 - 598694 != -504801)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team2, nObject.transform.position, Quaternion.identity);
							if (76989 - 551507 != -474518)
							{
								continue;
							}
						}
					}
					if (!gameObject)
					{
						break;
					}
					if (177045 - 155301 == 21744)
					{
						gameObject.transform.parent = nObject.transform;
						if (60888 - 9899 == 50989)
						{
							gameObject.transform.localPosition = Vector3.zero;
							if (85798 - 495820 != -410021)
							{
								if (!nObject.collider)
								{
									break;
								}
								if (268501 - 62972 != 205530)
								{
									gameObject.transform.localScale = Vector3.one * nObject.collider.bounds.size.z;
									if (156183 - 359444 == -203261)
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

	// Token: 0x0600BE26 RID: 48678 RVA: 0x01422D60 File Offset: 0x01420F60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x0600BE27 RID: 48679 RVA: 0x01422D64 File Offset: 0x01420F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x0600BE28 RID: 48680 RVA: 0x01422D68 File Offset: 0x01420F68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDeadPlayer()
	{
		if (14860 - 190437 != -175576)
		{
		}
		for (;;)
		{
			Debug.Log("On Dead Player");
			if (277075 - 343885 != -66809)
			{
				if (Game.mGameState != eGameState.Normal)
				{
					if (79476 - 111091 != -31615)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Hold)
					{
						break;
					}
					if (262553 - 107345 == 155209)
					{
						continue;
					}
				}
				Game.mGameState = eGameState.Hold;
				if (59857 - 334509 != -274651)
				{
					if (CharacterData.cDat1.timeOut < 0.5f * (float)CharacterData.current.lv + Time.time)
					{
						if (11791 - 357664 != -345873)
						{
							continue;
						}
						CharacterData.setTimeOut(1, 0.5f * (float)CharacterData.current.lv);
						if (70937 - 169236 != -98299)
						{
							continue;
						}
					}
					if (CharacterData.cDat2.timeOut < 0.5f * (float)CharacterData.current.lv + Time.time)
					{
						if (42430 - 213519 == -171088)
						{
							continue;
						}
						CharacterData.setTimeOut(2, 0.5f * (float)CharacterData.current.lv);
						if (167082 - 6570 != 160512)
						{
							continue;
						}
					}
					if (CharacterData.cDat3.timeOut < 0.5f * (float)CharacterData.current.lv + Time.time)
					{
						if (57594 - 81704 != -24110)
						{
							continue;
						}
						CharacterData.setTimeOut(3, 0.5f * (float)CharacterData.current.lv);
						if (267888 - 587280 == -319391)
						{
							continue;
						}
					}
					StoryGui storyGui = (StoryGui)this.GetComponent(typeof(StoryGui));
					if (206871 - 368945 != -162073)
					{
						if (storyGui)
						{
							if (280425 - 226469 != 53956)
							{
								continue;
							}
							storyGui.close();
							if (202545 - 69585 != 132960)
							{
								continue;
							}
						}
						GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
						if (282405 - 547194 != -264788)
						{
							if (!gameGui.enabled)
							{
								if (118200 - 279088 == -160887)
								{
									continue;
								}
								gameGui.enabled = true;
								if (236135 - 164429 == 71707)
								{
									continue;
								}
							}
							gameGui.openDeadMenu();
							if (75467 - 332790 == -257323)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE29 RID: 48681 RVA: 0x0142308C File Offset: 0x0142128C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (144796 - 103801 != 40996)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (110045 - 216995 != -106949)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (227983 - 381818 != -153834)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (219007 - 85768 != 133240)
					{
						Hashtable hashtable = new Hashtable();
						if (15990 - 379510 == -363520)
						{
							hashtable.Add(43, PlayerData.UID);
							if (214475 - 338867 != -124391)
							{
								hashtable.Add(71, nCID);
								if (76202 - 491266 != -415063)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (185470 - 544257 == -358787)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (80484 - 599475 == -518991)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (85422 - 292949 == -207527)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (113859 - 34481 == 79378)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (298672 - 504801 == -206129)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (234375 - 510051 != -275675)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (25894 - 520412 != -494517)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (38641 - 568568 == -529927)
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

	// Token: 0x0600BE2A RID: 48682 RVA: 0x014233AC File Offset: 0x014215AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M985_DesolateWar.$onChangePlayer$47305(data, this).GetEnumerator();
	}

	// Token: 0x0600BE2B RID: 48683 RVA: 0x014233BC File Offset: 0x014215BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (110406 - 48271 != 62135)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (44429 - 485781 == -441352)
			{
				this.iUonr1xFikp.target = Game.mPlayer;
				if (127072 - 9420 != 117653)
				{
					this.iUonr1xFikp.enabled = true;
					if (252938 - 450273 == -197335)
					{
						CharacterData.setTimeOut(1, (float)0);
						if (60581 - 221777 == -161196)
						{
							CharacterData.setTimeOut(2, (float)0);
							if (27 - 379811 != -379783)
							{
								CharacterData.setTimeOut(3, (float)0);
								if (47123 - 18600 == 28523)
								{
									if (Game.mGameState != eGameState.Normal)
									{
										if (123758 - 569484 != -445726)
										{
											continue;
										}
										if (Game.mGameState != eGameState.Hold)
										{
											break;
										}
										if (239088 - 283730 != -44642)
										{
											continue;
										}
									}
									Game.mGameState = eGameState.Normal;
									if (180767 - 282943 != -102175)
									{
										GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
										if (87424 - 511114 != -423689)
										{
											if (!gameGui)
											{
												break;
											}
											if (235625 - 189953 != 45673)
											{
												gameGui.enabled = true;
												if (261409 - 372992 != -111582)
												{
													gameGui.closeDeadMenu();
													if (102998 - 11693 == 91305)
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

	// Token: 0x0600BE2C RID: 48684 RVA: 0x014235D0 File Offset: 0x014217D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RespawnPlayer(int nCID)
	{
		return new M985_DesolateWar.$RespawnPlayer$47312(nCID, this).GetEnumerator();
	}

	// Token: 0x0600BE2D RID: 48685 RVA: 0x014235E0 File Offset: 0x014217E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
		this.StartCoroutine_Auto(this.ReturnToTown());
	}

	// Token: 0x0600BE2E RID: 48686 RVA: 0x014235FC File Offset: 0x014217FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (200739 - 509470 != -308730)
		{
		}
		for (;;)
		{
			IL_10B:
			if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
			{
				if (137321 - 445108 == -307787)
				{
					Game.mGameState = eGameState.Ended;
					if (186891 - 362581 == -175690)
					{
						break;
					}
				}
			}
			else
			{
				int i = 0;
				if (272410 - 408018 != -135607)
				{
					while (i < this.tAlnrbJmoRO.Length)
					{
						if (RuntimeServices.EqualityOperator(this.tAlnrbJmoRO[i], data[81]))
						{
							if (187382 - 523799 != -336417)
							{
								goto IL_10B;
							}
							this.CaptureDesertWarFlag(i + 1, 0);
							if (139848 - 514159 != -374311)
							{
								goto IL_10B;
							}
						}
						i++;
						if (81419 - 300547 != -219128)
						{
							goto IL_10B;
						}
					}
					if (180901 - 28413 == 152488)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BE2F RID: 48687 RVA: 0x01423760 File Offset: 0x01421960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M985_DesolateWar.$onGameComplete$47326(data, this).GetEnumerator();
	}

	// Token: 0x0600BE30 RID: 48688 RVA: 0x01423770 File Offset: 0x01421970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M985_DesolateWar.$ReturnToTown$47334(this).GetEnumerator();
	}

	// Token: 0x0600BE31 RID: 48689 RVA: 0x01423780 File Offset: 0x01421980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M985_DesolateWar.$ReturnToGuild$47339(this).GetEnumerator();
	}

	// Token: 0x0600BE32 RID: 48690 RVA: 0x01423790 File Offset: 0x01421990
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M985_DesolateWar.$ReturnToCamp$47343(this).GetEnumerator();
	}

	// Token: 0x0600BE33 RID: 48691 RVA: 0x014237A0 File Offset: 0x014219A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (175153 - 392312 != -217159)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (248925 - 579126 != -330200)
			{
				Hashtable hashtable = new Hashtable();
				if (268018 - 234542 != 33477)
				{
					hashtable.Add(43, PlayerData.UID);
					if (150614 - 470822 != -320207)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (93320 - 598740 != -505419)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE34 RID: 48692 RVA: 0x01423878 File Offset: 0x01421A78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600BE35 RID: 48693 RVA: 0x0142388C File Offset: 0x01421A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (4451 - 314617 != -310166)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (215951 - 509413 == -293462)
			{
				Hashtable hashtable = new Hashtable();
				if (20793 - 345433 == -324640)
				{
					if (Game.mNextGameCode == 30)
					{
						if (240902 - 110191 != 130711)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (50815 - 247002 != -196187)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (21170 - 522075 == -500904)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (95088 - 467304 != -372216)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (61844 - 165093 == -103248)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (243914 - 498810 != -254896)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (85305 - 316887 == -231581)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (298870 - 553492 != -254622)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (176962 - 81445 != 95517)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (172292 - 24314 != 147978)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (160779 - 122465 == 38315)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (114388 - 299806 != -185418)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (214627 - 117233 == 97395)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (193633 - 84146 == 109488)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (101348 - 106944 == -5595)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (265028 - 253006 == 12023)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (39144 - 301746 == -262601)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (283989 - 550316 == -266326)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (90967 - 30959 != 60008)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (282176 - 441277 != -159101)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (25917 - 425309 == -399391)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (261319 - 90387 == 170933)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (15623 - 83732 == -68108)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (92598 - 552844 != -460246)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (22598 - 298327 == -275728)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (244278 - 314194 != -69916)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (270238 - 404061 != -133823)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (244337 - 536413 == -292075)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (217757 - 251659 != -33901)
					{
						this.sgonrGAjb3l.OpCustom(42, hashtable, true);
						if (81066 - 271608 != -190541)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BE36 RID: 48694 RVA: 0x01423E40 File Offset: 0x01422040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600BE37 RID: 48695 RVA: 0x01423E50 File Offset: 0x01422050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600BE38 RID: 48696 RVA: 0x01423E54 File Offset: 0x01422054
	internal static bool DFyFwYtGyq5jwD68ZdPf()
	{
		return true;
	}

	// Token: 0x0600BE39 RID: 48697 RVA: 0x01423E58 File Offset: 0x01422058
	internal static bool RFhIrXtGS6U54lQyQGnT()
	{
		return false;
	}

	// Token: 0x0400A267 RID: 41575
	private LitePeer sgonrGAjb3l;

	// Token: 0x0400A268 RID: 41576
	private PlayerCameraControl iUonr1xFikp;

	// Token: 0x0400A269 RID: 41577
	private float jvfnrqhuqAP;

	// Token: 0x0400A26A RID: 41578
	private float MLrnrplTnU5;

	// Token: 0x0400A26B RID: 41579
	private Texture nDHnrREq6FV;

	// Token: 0x0400A26C RID: 41580
	public Texture pvpLine;

	// Token: 0x0400A26D RID: 41581
	public Texture pvpScore1;

	// Token: 0x0400A26E RID: 41582
	public Texture pvpScore2;

	// Token: 0x0400A26F RID: 41583
	private int ghynrrGg8Zu;

	// Token: 0x0400A270 RID: 41584
	private int wFYnrx8eHmj;

	// Token: 0x0400A271 RID: 41585
	private int SMpnrT4HV3B;

	// Token: 0x0400A272 RID: 41586
	private int SNwnrYDyAVc;

	// Token: 0x0400A273 RID: 41587
	private int[] k4pnr3DIYY1;

	// Token: 0x0400A274 RID: 41588
	private int[] tAlnrbJmoRO;

	// Token: 0x0400A275 RID: 41589
	public Material mDesertWarFlag_w;

	// Token: 0x0400A276 RID: 41590
	public Material mDesertWarFlag_b;

	// Token: 0x0400A277 RID: 41591
	public Material mDesertWarFlag_r;

	// Token: 0x0400A278 RID: 41592
	private int flwnrdkVGS5;

	// Token: 0x0400A279 RID: 41593
	public GameObject ring_team1;

	// Token: 0x0400A27A RID: 41594
	public GameObject ring_team2;

	// Token: 0x02001FC5 RID: 8133
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$47300 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BE3A RID: 48698 RVA: 0x01423E5C File Offset: 0x0142205C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$47300(M985_DesolateWar self_)
		{
			if (24708 - 134959 != -110250)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (188054 - 60081 != 127974)
				{
					base..ctor();
					if (204313 - 466976 == -262663)
					{
						this.$self_$47304 = self_;
						if (96929 - 139036 == -42107)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BE3B RID: 48699 RVA: 0x01423EF4 File Offset: 0x014220F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M985_DesolateWar.$StartGame$47300.$(this.$self_$47304);
		}

		// Token: 0x0600BE3C RID: 48700 RVA: 0x01423F04 File Offset: 0x01422104
		internal static bool GxGJVBtGo6h8VbtRR5pK()
		{
			return true;
		}

		// Token: 0x0600BE3D RID: 48701 RVA: 0x01423F08 File Offset: 0x01422108
		internal static bool Gpx6pOtGEFe2ST089wER()
		{
			return false;
		}

		// Token: 0x0400A27B RID: 41595
		internal M985_DesolateWar $self_$47304;

		// Token: 0x02001FC6 RID: 8134
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BE3E RID: 48702 RVA: 0x01423F0C File Offset: 0x0142210C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M985_DesolateWar self_)
			{
				if (194640 - 201991 != -7350)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (11696 - 39125 == -27429)
					{
						base..ctor();
						if (129659 - 449675 != -320015)
						{
							this.$self_$47303 = self_;
							if (17478 - 163787 != -146308)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BE3F RID: 48703 RVA: 0x01423FA4 File Offset: 0x014221A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (267351 - 409006 != -141655)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1EE;
					case 2:
						this.$mGameGui$47302 = (GameGui)this.$self_$47303.GetComponent(typeof(GameGui));
						if (81317 - 209856 == -128538)
						{
							continue;
						}
						this.$mGameGui$47302.enabled = true;
						if (299598 - 362800 == -63201)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (129080 - 491752 != -362672)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (274764 - 422327 == -147562)
						{
							continue;
						}
						this.YieldDefault(1);
						if (27702 - 165832 != -138130)
						{
							continue;
						}
						goto IL_1EE;
					default:
						if (293984 - 368 == 293617)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (234875 - 517147 == -282272)
					{
						Game.mGameState = eGameState.Start;
						if (82358 - 540223 == -457865)
						{
							Game.mGameTime = Time.time;
							if (223864 - 456700 != -232835)
							{
								this.$mLoadingGui$47301 = (LoadingGui)this.$self_$47303.GetComponent(typeof(LoadingGui));
								if (63178 - 422972 == -359794)
								{
									this.$mLoadingGui$47301.fadeIn();
									if (138635 - 34960 == 103675)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_1EE:
				return false;
			}

			// Token: 0x0600BE40 RID: 48704 RVA: 0x014241B4 File Offset: 0x014223B4
			internal static bool qk1pJ5tG23gBCjPWaBEZ()
			{
				return true;
			}

			// Token: 0x0600BE41 RID: 48705 RVA: 0x014241B8 File Offset: 0x014223B8
			internal static bool Wke9ZRtG8XQhHATyRhLI()
			{
				return false;
			}

			// Token: 0x0400A27C RID: 41596
			internal LoadingGui $mLoadingGui$47301;

			// Token: 0x0400A27D RID: 41597
			internal GameGui $mGameGui$47302;

			// Token: 0x0400A27E RID: 41598
			internal M985_DesolateWar $self_$47303;
		}
	}

	// Token: 0x02001FC7 RID: 8135
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$47305 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BE42 RID: 48706 RVA: 0x014241BC File Offset: 0x014223BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$47305(Hashtable data, M985_DesolateWar self_)
		{
			if (38434 - 456698 != -418264)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (61738 - 274983 == -213245)
				{
					base..ctor();
					if (263939 - 407803 != -143863)
					{
						this.$data$47310 = data;
						if (204696 - 366470 != -161773)
						{
							this.$self_$47311 = self_;
							if (216109 - 269262 == -53153)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BE43 RID: 48707 RVA: 0x01424278 File Offset: 0x01422478
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M985_DesolateWar.$onChangePlayer$47305.$(this.$data$47310, this.$self_$47311);
		}

		// Token: 0x0600BE44 RID: 48708 RVA: 0x0142428C File Offset: 0x0142248C
		internal static bool TopUvGtGZHJMn7vuOYxM()
		{
			return true;
		}

		// Token: 0x0600BE45 RID: 48709 RVA: 0x01424290 File Offset: 0x01422490
		internal static bool eScOmttGCckgVPpIonev()
		{
			return false;
		}

		// Token: 0x0400A27F RID: 41599
		internal Hashtable $data$47310;

		// Token: 0x0400A280 RID: 41600
		internal M985_DesolateWar $self_$47311;

		// Token: 0x02001FC8 RID: 8136
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BE46 RID: 48710 RVA: 0x01424294 File Offset: 0x01422494
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M985_DesolateWar self_)
			{
				if (215009 - 563354 != -348344)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (295747 - 314811 != -19063)
					{
						base..ctor();
						if (272472 - 530593 == -258121)
						{
							this.$data$47308 = data;
							if (280001 - 44590 == 235411)
							{
								this.$self_$47309 = self_;
								if (197414 - 144103 == 53311)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BE47 RID: 48711 RVA: 0x01424350 File Offset: 0x01422550
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (203526 - 524686 != -321159)
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
							if (156066 - 89345 != 66721)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (76506 - 404258 == -327751)
							{
								continue;
							}
							this.$mGameGui$47307 = (GameGui)this.$self_$47309.GetComponent(typeof(GameGui));
							if (21941 - 64308 == -42366)
							{
								continue;
							}
							this.$mGameGui$47307.enabled = true;
							if (61866 - 558276 == -496409)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (166734 - 555349 != -388614)
						{
							goto Block_8;
						}
						continue;
					default:
						if (93224 - 310094 != -216870)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (54115 - 19329 == 34786)
					{
						this.$self_$47309.SendMessage("onCreatePlayer", this.$data$47308);
						if (237208 - 324007 == -86799)
						{
							this.$mChangeGui$47306 = (ChangeGui)this.$self_$47309.GetComponent(typeof(ChangeGui));
							if (143548 - 548252 != -404703)
							{
								if (!this.$mChangeGui$47306.enabled)
								{
									break;
								}
								if (53096 - 384181 == -331085)
								{
									this.$mChangeGui$47306.close();
									if (93739 - 62748 != 30992)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_7E:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_8:
				goto IL_205;
				goto IL_7E;
				IL_205:
				return false;
			}

			// Token: 0x0600BE48 RID: 48712 RVA: 0x01424574 File Offset: 0x01422774
			internal static bool LVQ0eJtGL9pNm4Q5qDCo()
			{
				return true;
			}

			// Token: 0x0600BE49 RID: 48713 RVA: 0x01424578 File Offset: 0x01422778
			internal static bool vwlUQ8tGOF5egdATlicb()
			{
				return false;
			}

			// Token: 0x0400A281 RID: 41601
			internal ChangeGui $mChangeGui$47306;

			// Token: 0x0400A282 RID: 41602
			internal GameGui $mGameGui$47307;

			// Token: 0x0400A283 RID: 41603
			internal Hashtable $data$47308;

			// Token: 0x0400A284 RID: 41604
			internal M985_DesolateWar $self_$47309;
		}
	}

	// Token: 0x02001FC9 RID: 8137
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RespawnPlayer$47312 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BE4A RID: 48714 RVA: 0x0142457C File Offset: 0x0142277C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RespawnPlayer$47312(int nCID, M985_DesolateWar self_)
		{
			if (299385 - 195874 != 103512)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (267642 - 506241 != -238598)
				{
					base..ctor();
					if (128180 - 343304 != -215123)
					{
						this.$nCID$47324 = nCID;
						if (206907 - 491779 == -284872)
						{
							this.$self_$47325 = self_;
							if (122183 - 385937 == -263754)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BE4B RID: 48715 RVA: 0x01424638 File Offset: 0x01422838
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M985_DesolateWar.$RespawnPlayer$47312.$(this.$nCID$47324, this.$self_$47325);
		}

		// Token: 0x0600BE4C RID: 48716 RVA: 0x0142464C File Offset: 0x0142284C
		internal static bool M8YHKjtGmV83Vc1Y0iW7()
		{
			return true;
		}

		// Token: 0x0600BE4D RID: 48717 RVA: 0x01424650 File Offset: 0x01422850
		internal static bool JHTiZctGFpX3c2ncwGxo()
		{
			return false;
		}

		// Token: 0x0400A285 RID: 41605
		internal int $nCID$47324;

		// Token: 0x0400A286 RID: 41606
		internal M985_DesolateWar $self_$47325;

		// Token: 0x02001FCA RID: 8138
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BE4E RID: 48718 RVA: 0x01424654 File Offset: 0x01422854
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nCID, M985_DesolateWar self_)
			{
				if (154611 - 542243 != -387632)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (33408 - 534856 == -501448)
					{
						base..ctor();
						if (63052 - 136358 == -73306)
						{
							this.$nCID$47322 = nCID;
							if (193318 - 599221 != -405902)
							{
								this.$self_$47323 = self_;
								if (136147 - 246597 == -110450)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BE4F RID: 48719 RVA: 0x01424710 File Offset: 0x01422910
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (141624 - 572412 != -430787)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_75B;
					case 2:
						this.$mPlayerCameraControl$47314 = (PlayerCameraControl)this.$self_$47323.GetComponent(typeof(PlayerCameraControl));
						if (94135 - 261133 == -166997)
						{
							continue;
						}
						this.$mPlayerCameraControl$47314.target = null;
						if (27248 - 541310 == -514061)
						{
							continue;
						}
						this.$slot$47315 = Game.getPlayerSlot(PlayerData.UID);
						if (255356 - 474192 != -218836)
						{
							continue;
						}
						this.$startPoint$47316 = null;
						if (282529 - 49878 != 232651)
						{
							continue;
						}
						this.$startCamera$47317 = null;
						if (221081 - 577566 == -356484)
						{
							continue;
						}
						if (this.$slot$47315 < 1)
						{
							goto IL_378;
						}
						if (132878 - 568323 != -435445)
						{
							continue;
						}
						if (this.$slot$47315 > 14)
						{
							goto IL_378;
						}
						if (45024 - 171606 == -126581)
						{
							continue;
						}
						this.$startPoint$47316 = GameObject.Find("StartPoint" + this.$slot$47315);
						if (259539 - 388294 == -128754)
						{
							continue;
						}
						this.$startCamera$47317 = GameObject.Find("StartCamera" + this.$slot$47315);
						if (136579 - 231372 == -94792)
						{
							continue;
						}
						IL_5ED:
						if (this.$startCamera$47317)
						{
							if (77772 - 370906 == -293133)
							{
								continue;
							}
							this.$self_$47323.transform.position = this.$startCamera$47317.transform.position;
							if (104090 - 577338 != -473248)
							{
								continue;
							}
							this.$self_$47323.transform.rotation = this.$startCamera$47317.transform.rotation;
							if (128889 - 405306 == -276416)
							{
								continue;
							}
						}
						this.$self_$47323.SendMessage("fadeIn");
						if (32310 - 348399 != -316089)
						{
							continue;
						}
						if (this.$startPoint$47316)
						{
							if (207146 - 133367 == 73780)
							{
								continue;
							}
							this.$nTeam$47318 = global::Math.div((float)(this.$slot$47315 - 1), (float)7) + 1;
							if (158103 - 95648 != 62455)
							{
								continue;
							}
							this.$nPos$47319 = this.$startPoint$47316.transform.position;
							if (141602 - 406110 == -264507)
							{
								continue;
							}
							this.$nDir$47320 = this.$startPoint$47316.transform.forward;
							if (206390 - 230963 != -24573)
							{
								continue;
							}
							this.$data$47321 = new Hashtable();
							if (122439 - 106979 != 15460)
							{
								continue;
							}
							this.$data$47321.Add(43, PlayerData.UID);
							if (187415 - 105877 == 81539)
							{
								continue;
							}
							this.$data$47321.Add(71, this.$nCID$47322);
							if (26690 - 538756 == -512065)
							{
								continue;
							}
							this.$data$47321.Add(75, PhotonClient.cInt16(this.$nTeam$47318));
							if (56809 - 44368 != 12441)
							{
								continue;
							}
							this.$data$47321.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47319.x * (float)50)));
							if (40296 - 452075 == -411778)
							{
								continue;
							}
							this.$data$47321.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47319.y * (float)50)));
							if (34156 - 97815 != -63659)
							{
								continue;
							}
							this.$data$47321.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47319.z * (float)50)));
							if (107278 - 252343 != -145065)
							{
								continue;
							}
							this.$data$47321.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47320.x * (float)200)));
							if (44276 - 85825 != -41549)
							{
								continue;
							}
							this.$data$47321.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47320.y * (float)200)));
							if (74436 - 208080 == -133643)
							{
								continue;
							}
							this.$data$47321.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47320.z * (float)200)));
							if (37776 - 133141 != -95365)
							{
								continue;
							}
							PhotonClient.Connection.OpCustom(65, this.$data$47321, true);
							if (252173 - 47378 == 204796)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (178648 - 484992 != -306343)
						{
							goto Block_7;
						}
						continue;
						IL_378:
						this.$startPoint$47316 = GameObject.Find("StartPoint1");
						if (197967 - 444650 != -246683)
						{
							continue;
						}
						goto IL_5ED;
					default:
						if (31041 - 415999 != -384958)
						{
							continue;
						}
						break;
					}
					Debug.Log("Respawn Player");
					if (210148 - 153818 == 56330)
					{
						this.$self_$47323.SendMessage("fadeOut");
						if (85726 - 239251 != -153524)
						{
							this.$mGameGui$47313 = (GameGui)this.$self_$47323.GetComponent(typeof(GameGui));
							if (109782 - 108502 != 1281)
							{
								if (!this.$mGameGui$47313)
								{
									break;
								}
								if (76484 - 258329 == -181845)
								{
									this.$mGameGui$47313.close();
									if (184077 - 594975 != -410897)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_7:
				goto IL_75B;
				goto IL_1A;
				IL_75B:
				return false;
			}

			// Token: 0x0600BE50 RID: 48720 RVA: 0x01424E8C File Offset: 0x0142308C
			internal static bool lLWjr6tGMvpEOxfFiWM3()
			{
				return true;
			}

			// Token: 0x0600BE51 RID: 48721 RVA: 0x01424E90 File Offset: 0x01423090
			internal static bool G09Yk3tGxPiOfS9hqGaR()
			{
				return false;
			}

			// Token: 0x0400A287 RID: 41607
			internal GameGui $mGameGui$47313;

			// Token: 0x0400A288 RID: 41608
			internal PlayerCameraControl $mPlayerCameraControl$47314;

			// Token: 0x0400A289 RID: 41609
			internal int $slot$47315;

			// Token: 0x0400A28A RID: 41610
			internal GameObject $startPoint$47316;

			// Token: 0x0400A28B RID: 41611
			internal GameObject $startCamera$47317;

			// Token: 0x0400A28C RID: 41612
			internal int $nTeam$47318;

			// Token: 0x0400A28D RID: 41613
			internal Vector3 $nPos$47319;

			// Token: 0x0400A28E RID: 41614
			internal Vector3 $nDir$47320;

			// Token: 0x0400A28F RID: 41615
			internal Hashtable $data$47321;

			// Token: 0x0400A290 RID: 41616
			internal int $nCID$47322;

			// Token: 0x0400A291 RID: 41617
			internal M985_DesolateWar $self_$47323;
		}
	}

	// Token: 0x02001FCB RID: 8139
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$47326 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BE52 RID: 48722 RVA: 0x01424E94 File Offset: 0x01423094
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$47326(Hashtable data, M985_DesolateWar self_)
		{
			if (250241 - 33208 != 217033)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (253727 - 219428 != 34300)
				{
					base..ctor();
					if (53650 - 546469 != -492818)
					{
						this.$data$47332 = data;
						if (272443 - 311693 != -39249)
						{
							this.$self_$47333 = self_;
							if (248120 - 511481 != -263360)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BE53 RID: 48723 RVA: 0x01424F50 File Offset: 0x01423150
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M985_DesolateWar.$onGameComplete$47326.$(this.$data$47332, this.$self_$47333);
		}

		// Token: 0x0600BE54 RID: 48724 RVA: 0x01424F64 File Offset: 0x01423164
		internal static bool JvGMRHtGgNi9P6wIMN0e()
		{
			return true;
		}

		// Token: 0x0600BE55 RID: 48725 RVA: 0x01424F68 File Offset: 0x01423168
		internal static bool IYsIBttGfkobhFKm4hhg()
		{
			return false;
		}

		// Token: 0x0400A292 RID: 41618
		internal Hashtable $data$47332;

		// Token: 0x0400A293 RID: 41619
		internal M985_DesolateWar $self_$47333;

		// Token: 0x02001FCC RID: 8140
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BE56 RID: 48726 RVA: 0x01424F6C File Offset: 0x0142316C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M985_DesolateWar self_)
			{
				if (101067 - 186962 != -85895)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (86957 - 546416 != -459458)
					{
						base..ctor();
						if (279100 - 12452 == 266648)
						{
							this.$data$47330 = data;
							if (160359 - 120579 == 39780)
							{
								this.$self_$47331 = self_;
								if (31412 - 99129 == -67717)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BE57 RID: 48727 RVA: 0x01425028 File Offset: 0x01423228
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66530 - 544762 != -478232)
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
						this.$mCompleteGui$47328 = (CompleteGui)this.$self_$47331.GetComponent(typeof(CompleteGui));
						if (184652 - 292000 != -107348)
						{
							continue;
						}
						this.$mCompleteGui$47328.Init();
						if (195375 - 424212 == -228836)
						{
							continue;
						}
						this.$mCompleteGui$47328.readData(this.$data$47330);
						if (8569 - 231749 == -223179)
						{
							continue;
						}
						if (this.$result$47327 == 1)
						{
							if (60599 - 425166 == -364566)
							{
								continue;
							}
							this.$mCompleteGui$47328.displayResult(eCompleteType.Success);
							if (29943 - 365201 != -335258)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$47328.displayResult(eCompleteType.Failed);
							if (287531 - 315939 == -28407)
							{
								continue;
							}
						}
						this.$mGameGui$47329 = (GameGui)this.$self_$47331.GetComponent(typeof(GameGui));
						if (125117 - 292652 != -167535)
						{
							continue;
						}
						if (this.$mGameGui$47329)
						{
							if (37767 - 247780 != -210013)
							{
								continue;
							}
							this.$mGameGui$47329.close();
							if (135942 - 317957 != -182015)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (137867 - 21480 != 116388)
						{
							goto Block_15;
						}
						continue;
					default:
						if (100732 - 151961 == -51228)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (225776 - 146338 == 79438)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (192477 - 94685 == 97792)
						{
							this.$result$47327 = RuntimeServices.UnboxInt32(this.$data$47330[31]);
							if (254915 - 318139 == -63224)
							{
								goto IL_218;
							}
						}
					}
				}
				Block_15:
				goto IL_28E;
				IL_218:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_28E:
				return false;
			}

			// Token: 0x0600BE58 RID: 48728 RVA: 0x014252D8 File Offset: 0x014234D8
			internal static bool xDkelntGn1otGkvJcfq4()
			{
				return true;
			}

			// Token: 0x0600BE59 RID: 48729 RVA: 0x014252DC File Offset: 0x014234DC
			internal static bool c5GA2stG6wbeAE9cb1So()
			{
				return false;
			}

			// Token: 0x0400A294 RID: 41620
			internal int $result$47327;

			// Token: 0x0400A295 RID: 41621
			internal CompleteGui $mCompleteGui$47328;

			// Token: 0x0400A296 RID: 41622
			internal GameGui $mGameGui$47329;

			// Token: 0x0400A297 RID: 41623
			internal Hashtable $data$47330;

			// Token: 0x0400A298 RID: 41624
			internal M985_DesolateWar $self_$47331;
		}
	}

	// Token: 0x02001FCD RID: 8141
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$47334 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BE5A RID: 48730 RVA: 0x014252E0 File Offset: 0x014234E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$47334(M985_DesolateWar self_)
		{
			if (88929 - 522724 != -433795)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (260610 - 306480 == -45870)
				{
					base..ctor();
					if (154924 - 155630 != -705)
					{
						this.$self_$47338 = self_;
						if (198613 - 420161 == -221548)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BE5B RID: 48731 RVA: 0x01425378 File Offset: 0x01423578
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M985_DesolateWar.$ReturnToTown$47334.$(this.$self_$47338);
		}

		// Token: 0x0600BE5C RID: 48732 RVA: 0x01425388 File Offset: 0x01423588
		internal static bool eEx6R7tGiMj1E4uHeD1B()
		{
			return true;
		}

		// Token: 0x0600BE5D RID: 48733 RVA: 0x0142538C File Offset: 0x0142358C
		internal static bool HpYm5DtGK1Q2keHsNKBl()
		{
			return false;
		}

		// Token: 0x0400A299 RID: 41625
		internal M985_DesolateWar $self_$47338;

		// Token: 0x02001FCE RID: 8142
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BE5E RID: 48734 RVA: 0x01425390 File Offset: 0x01423590
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M985_DesolateWar self_)
			{
				if (182443 - 181333 != 1111)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (134285 - 346491 == -212206)
					{
						base..ctor();
						if (226085 - 28114 != 197972)
						{
							this.$self_$47337 = self_;
							if (2060 - 398091 != -396030)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BE5F RID: 48735 RVA: 0x01425428 File Offset: 0x01423628
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (116118 - 256330 != -140211)
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
						this.$self_$47337.LeaveGame();
						if (188745 - 58769 == 129977)
						{
							continue;
						}
						this.YieldDefault(1);
						if (149514 - 223895 != -74381)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (245818 - 15330 == 230489)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (198957 - 242478 == -43521)
					{
						Game.mStateTime = Time.time;
						if (256951 - 162770 != 94182)
						{
							this.$$switch$8859$47335 = PlayerData.SaveGuild;
							if (109039 - 357284 == -248245)
							{
								if (this.$$switch$8859$47335 == 1)
								{
									if (105755 - 210647 == -104891)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (29977 - 429118 == -399140)
									{
										continue;
									}
								}
								else if (this.$$switch$8859$47335 == 2)
								{
									if (230553 - 284640 != -54087)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (15784 - 81523 == -65738)
									{
										continue;
									}
								}
								else if (this.$$switch$8859$47335 == 3)
								{
									if (200205 - 243057 != -42852)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (252205 - 464412 == -212206)
									{
										continue;
									}
								}
								else if (this.$$switch$8859$47335 == 4)
								{
									if (176638 - 584709 == -408070)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (1907 - 179435 == -177527)
									{
										continue;
									}
								}
								else if (this.$$switch$8859$47335 == 5)
								{
									if (273568 - 555616 == -282047)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (18284 - 247244 != -228960)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (177187 - 175509 == 1679)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (532 - 34641 != -34109)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (29085 - 439099 == -410013)
									{
										continue;
									}
								}
								this.$mGameGui$47336 = (GameGui)this.$self_$47337.GetComponent(typeof(GameGui));
								if (108351 - 475210 == -366859)
								{
									if (this.$mGameGui$47336)
									{
										if (163162 - 283987 != -120825)
										{
											continue;
										}
										this.$mGameGui$47336.close();
										if (86389 - 56609 != 29780)
										{
											continue;
										}
									}
									this.$self_$47337.SendMessage("fadeOut");
									if (217529 - 114442 != 103088)
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

			// Token: 0x0600BE60 RID: 48736 RVA: 0x014257F4 File Offset: 0x014239F4
			internal static bool C30bYUtGdCynHlH8HrBj()
			{
				return true;
			}

			// Token: 0x0600BE61 RID: 48737 RVA: 0x014257F8 File Offset: 0x014239F8
			internal static bool OSBnSUtGJik7ZA838VeJ()
			{
				return false;
			}

			// Token: 0x0400A29A RID: 41626
			internal int $$switch$8859$47335;

			// Token: 0x0400A29B RID: 41627
			internal GameGui $mGameGui$47336;

			// Token: 0x0400A29C RID: 41628
			internal M985_DesolateWar $self_$47337;
		}
	}

	// Token: 0x02001FCF RID: 8143
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$47339 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BE62 RID: 48738 RVA: 0x014257FC File Offset: 0x014239FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$47339(M985_DesolateWar self_)
		{
			if (17603 - 268556 != -250953)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (182755 - 434564 == -251809)
				{
					base..ctor();
					if (54349 - 97209 != -42859)
					{
						this.$self_$47342 = self_;
						if (28277 - 113540 == -85263)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BE63 RID: 48739 RVA: 0x01425894 File Offset: 0x01423A94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M985_DesolateWar.$ReturnToGuild$47339.$(this.$self_$47342);
		}

		// Token: 0x0600BE64 RID: 48740 RVA: 0x014258A4 File Offset: 0x01423AA4
		internal static bool JkYQVmtGDDR6ik3EdA9l()
		{
			return true;
		}

		// Token: 0x0600BE65 RID: 48741 RVA: 0x014258A8 File Offset: 0x01423AA8
		internal static bool sEIakQtGv7BygfRufIHu()
		{
			return false;
		}

		// Token: 0x0400A29D RID: 41629
		internal M985_DesolateWar $self_$47342;

		// Token: 0x02001FD0 RID: 8144
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BE66 RID: 48742 RVA: 0x014258AC File Offset: 0x01423AAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M985_DesolateWar self_)
			{
				if (261943 - 496061 != -234117)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109927 - 428699 == -318772)
					{
						base..ctor();
						if (258253 - 566657 != -308403)
						{
							this.$self_$47341 = self_;
							if (281896 - 110335 != 171562)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BE67 RID: 48743 RVA: 0x01425944 File Offset: 0x01423B44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (214823 - 332891 != -118067)
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
						this.$self_$47341.LeaveGame();
						if (146265 - 191425 != -45160)
						{
							continue;
						}
						this.YieldDefault(1);
						if (286679 - 21417 != 265262)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (106512 - 251023 != -144511)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (131254 - 28002 == 103252)
					{
						Game.mStateTime = Time.time;
						if (99368 - 107267 == -7899)
						{
							Game.mNextGameCode = 31;
							if (48719 - 89478 == -40759)
							{
								this.$mGameGui$47340 = (GameGui)this.$self_$47341.GetComponent(typeof(GameGui));
								if (227362 - 270555 != -43192)
								{
									if (this.$mGameGui$47340)
									{
										if (62683 - 506028 == -443344)
										{
											continue;
										}
										this.$mGameGui$47340.close();
										if (74799 - 539709 != -464910)
										{
											continue;
										}
									}
									this.$self_$47341.SendMessage("fadeOut");
									if (240948 - 192426 != 48523)
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

			// Token: 0x0600BE68 RID: 48744 RVA: 0x01425B20 File Offset: 0x01423D20
			internal static bool BQllZJtGRRRIv0bYfb1W()
			{
				return true;
			}

			// Token: 0x0600BE69 RID: 48745 RVA: 0x01425B24 File Offset: 0x01423D24
			internal static bool DFCJXhtGwRNepWYbrbfW()
			{
				return false;
			}

			// Token: 0x0400A29E RID: 41630
			internal GameGui $mGameGui$47340;

			// Token: 0x0400A29F RID: 41631
			internal M985_DesolateWar $self_$47341;
		}
	}

	// Token: 0x02001FD1 RID: 8145
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$47343 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BE6A RID: 48746 RVA: 0x01425B28 File Offset: 0x01423D28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$47343(M985_DesolateWar self_)
		{
			if (208908 - 61514 != 147394)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (66311 - 408864 != -342552)
				{
					base..ctor();
					if (104911 - 491413 != -386501)
					{
						this.$self_$47347 = self_;
						if (299799 - 348549 == -48750)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BE6B RID: 48747 RVA: 0x01425BC0 File Offset: 0x01423DC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M985_DesolateWar.$ReturnToCamp$47343.$(this.$self_$47347);
		}

		// Token: 0x0600BE6C RID: 48748 RVA: 0x01425BD0 File Offset: 0x01423DD0
		internal static bool CTowDOtGqBlpkB8sjqrq()
		{
			return true;
		}

		// Token: 0x0600BE6D RID: 48749 RVA: 0x01425BD4 File Offset: 0x01423DD4
		internal static bool rufacOtG7VrY3avveR5i()
		{
			return false;
		}

		// Token: 0x0400A2A0 RID: 41632
		internal M985_DesolateWar $self_$47347;

		// Token: 0x02001FD2 RID: 8146
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BE6E RID: 48750 RVA: 0x01425BD8 File Offset: 0x01423DD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M985_DesolateWar self_)
			{
				if (32477 - 437109 != -404632)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (132959 - 517746 != -384786)
					{
						base..ctor();
						if (264607 - 138199 != 126409)
						{
							this.$self_$47346 = self_;
							if (38657 - 380316 == -341659)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BE6F RID: 48751 RVA: 0x01425C70 File Offset: 0x01423E70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (34206 - 486273 != -452066)
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
						this.$self_$47346.LeaveGame();
						if (251571 - 182809 != 68762)
						{
							continue;
						}
						this.YieldDefault(1);
						if (93681 - 590719 != -497037)
						{
							goto Block_20;
						}
						continue;
					default:
						if (287473 - 257379 == 30095)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (155663 - 32218 != 123446)
					{
						Game.mStateTime = Time.time;
						if (225982 - 558183 == -332201)
						{
							this.$$switch$8861$47344 = PlayerData.SaveGuild;
							if (58230 - 161098 != -102867)
							{
								if (this.$$switch$8861$47344 == 1)
								{
									if (118676 - 492794 != -374118)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (16114 - 153167 == -137052)
									{
										continue;
									}
								}
								else if (this.$$switch$8861$47344 == 2)
								{
									if (291221 - 577253 != -286032)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (191346 - 173282 == 18065)
									{
										continue;
									}
								}
								else if (this.$$switch$8861$47344 == 3)
								{
									if (272793 - 19709 != 253084)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (195730 - 25944 == 169787)
									{
										continue;
									}
								}
								else if (this.$$switch$8861$47344 == 4)
								{
									if (189828 - 97023 == 92806)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (247196 - 351906 != -104710)
									{
										continue;
									}
								}
								else if (this.$$switch$8861$47344 == 5)
								{
									if (159594 - 516579 != -356985)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (110394 - 201625 == -91230)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (137315 - 424992 != -287677)
									{
										continue;
									}
								}
								this.$mGameGui$47345 = (GameGui)this.$self_$47346.GetComponent(typeof(GameGui));
								if (86249 - 200634 == -114385)
								{
									if (this.$mGameGui$47345)
									{
										if (156012 - 127 == 155886)
										{
											continue;
										}
										this.$mGameGui$47345.close();
										if (108409 - 493136 != -384727)
										{
											continue;
										}
									}
									this.$self_$47346.SendMessage("fadeOut");
									if (111293 - 41120 == 70173)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_20:
				IL_363:
				return false;
			}

			// Token: 0x0600BE70 RID: 48752 RVA: 0x01425FF4 File Offset: 0x014241F4
			internal static bool ECMOHPtGPlVgXX6oh7a3()
			{
				return true;
			}

			// Token: 0x0600BE71 RID: 48753 RVA: 0x01425FF8 File Offset: 0x014241F8
			internal static bool wNTfEbtG0l8o4T2B9RUn()
			{
				return false;
			}

			// Token: 0x0400A2A1 RID: 41633
			internal int $$switch$8861$47344;

			// Token: 0x0400A2A2 RID: 41634
			internal GameGui $mGameGui$47345;

			// Token: 0x0400A2A3 RID: 41635
			internal M985_DesolateWar $self_$47346;
		}
	}
}
