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

// Token: 0x02001C98 RID: 7320
[Serializable]
public class M967_SplashWar : MonoBehaviour
{
	// Token: 0x0600AB1C RID: 43804 RVA: 0x013100BC File Offset: 0x0130E2BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M967_SplashWar()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600AB1D RID: 43805 RVA: 0x013100CC File Offset: 0x0130E2CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (14554 - 555396 != -540842)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (16264 - 219375 != -203110)
			{
				Game.mGameType = 5;
				if (222749 - 437217 != -214467)
				{
					if (Chat.Initialized)
					{
						if (143324 - 240927 != -97602)
						{
							Chat.ChatDisplay.Clear();
							if (56702 - 90186 == -33484)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (113322 - 167602 != -54279)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB1E RID: 43806 RVA: 0x013101B0 File Offset: 0x0130E3B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (39819 - 377645 != -337825)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (199139 - 222039 != -22899)
				{
					if (Game.mNextGameCode != 967)
					{
						break;
					}
					if (127105 - 417103 == -289998)
					{
						Game.nextGame();
						if (280360 - 129769 != 150592)
						{
							Game.mGameCode = 967;
							if (285995 - 578611 != -292615)
							{
								Game.mGameType = 5;
								if (191775 - 119131 != 72645)
								{
									Game.mGameTime = Time.time;
									if (166784 - 65786 != 100999)
									{
										Game.mGameScore = 0;
										if (65885 - 80163 == -14278)
										{
											Game.mGameMana = 0;
											if (266006 - 69951 == 196055)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (108264 - 186454 == -78190)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (122704 - 81449 == 41255)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (192313 - 237077 != -44763)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (76200 - 149345 != -73144)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (48154 - 208514 != -160359)
																{
																	this.GkGnvrAECTS = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (15859 - 356865 == -341006)
																	{
																		this.ey3nvRV9Zir = PhotonClient.Connection;
																		if (84366 - 23191 != 61176)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (271427 - 190739 == 80688)
																			{
																				this.InitGame();
																				if (162468 - 373805 != -211336)
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
				if (191961 - 128629 == 63332)
				{
					Game.mGameType = 99;
					if (232483 - 38807 != 193677)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AB1F RID: 43807 RVA: 0x013104B8 File Offset: 0x0130E6B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (141561 - 373707 != -232146)
		{
		}
		for (;;)
		{
			if (this.ey3nvRV9Zir == null)
			{
				if (83123 - 214122 != -130998)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (258423 - 559636 != -301212)
				{
					if (mGameState == eGameState.Init)
					{
						if (256805 - 104565 != 152241)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (227972 - 15698 == 212274)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (52143 - 385909 == -333766)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (175256 - 184243 != -8986)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (40517 - 518345 == -477828)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (287176 - 186087 != 101090)
						{
							if (Time.time > this.L8KnvxW4IGA)
							{
								if (255184 - 209593 != 45591)
								{
									continue;
								}
								Game.mGameMana++;
								if (145507 - 399882 == -254374)
								{
									continue;
								}
								this.L8KnvxW4IGA = Time.time + (float)12;
								if (113340 - 169120 != -55780)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (142867 - 386740 == -243872)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (52667 - 64960 != -12293)
									{
										continue;
									}
									this.audio.Play();
									if (59055 - 348894 != -289839)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (49197 - 142107 == -92909)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (199828 - 206262 == -6433)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (54361 - 407844 == -353482)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (241869 - 591624 == -349755)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (283398 - 55674 != 227725)
						{
							this.GameEventUpdate();
							if (166496 - 499883 == -333387)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (6001 - 48236 == -42235)
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
						if (152888 - 297189 == -144301)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB20 RID: 43808 RVA: 0x01310874 File Offset: 0x0130EA74
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (290347 - 487932 != -197585)
		{
		}
		while (this.Ftonvd0eGFB < 1)
		{
			if (95202 - 442954 == -347752)
			{
				if (Time.time - Game.mGameTime <= (float)180)
				{
					break;
				}
				if (46992 - 345452 != -298459)
				{
					this.Ftonvd0eGFB = 1;
					if (136208 - 341406 == -205198)
					{
						if (this.M8SnvgoaDRk > this.ghAnvasCxnY)
						{
							if (265690 - 180690 != 85001)
							{
								Game.sendMissionEvent(9672, 1);
								if (51413 - 168 == 51245)
								{
									break;
								}
							}
						}
						else
						{
							Game.sendMissionEvent(9672, 2);
							if (291010 - 97447 == 193563)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB21 RID: 43809 RVA: 0x013109A0 File Offset: 0x0130EBA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (93811 - 293150 != -199339)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (117255 - 207261 != -90005)
			{
				float num = (float)1;
				if (75995 - 196658 == -120663)
				{
					float num2 = (float)(1024 * Screen.width / Screen.height);
					if (207099 - 138098 != 69002)
					{
						GUI.depth = 1;
						if (234417 - 417674 != -183256)
						{
							eGameState mGameState = Game.mGameState;
							if (284103 - 264462 == 19641)
							{
								if (mGameState == eGameState.Start)
								{
									if (141042 - 565001 == -423958)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)1)
									{
										if (137736 - 498025 != -360288)
										{
											break;
										}
										continue;
									}
									else if (Time.time - Game.mStateTime < (float)2)
									{
										if (22012 - 77606 != -55594)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)1);
										if (137839 - 77455 == 60385)
										{
											continue;
										}
										float a = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)1);
										if (173583 - 66164 != 107419)
										{
											continue;
										}
										Color color = GUI.color;
										if (42340 - 184129 == -141788)
										{
											continue;
										}
										color.a = a;
										if (286635 - 513046 != -226411)
										{
											continue;
										}
										if (106986 - 254237 != -147251)
										{
											continue;
										}
										Color color2 = GUI.color = color;
										if (225148 - 468501 != -243353)
										{
											continue;
										}
										if (238631 - 19952 == 218680)
										{
											continue;
										}
										if (this.a3unvYE1Hvp)
										{
											if (101645 - 343263 != -241618)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.a3unvYE1Hvp);
											if (239147 - 298935 != -59788)
											{
												continue;
											}
										}
									}
									else if (Time.time - Game.mStateTime < (float)3)
									{
										if (237333 - 346254 == -108920)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)2);
										if (180202 - 232477 != -52275)
										{
											continue;
										}
										float a2 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)2);
										if (251068 - 226013 == 25056)
										{
											continue;
										}
										Color color3 = GUI.color;
										if (118048 - 159783 != -41735)
										{
											continue;
										}
										color3.a = a2;
										if (34379 - 356903 == -322523)
										{
											continue;
										}
										if (128054 - 450675 != -322621)
										{
											continue;
										}
										Color color4 = GUI.color = color3;
										if (176916 - 498748 == -321831 || 70749 - 47837 == 22913)
										{
											continue;
										}
										if (this.RjInv3Jwx7Z)
										{
											if (220908 - 291065 != -70157)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.RjInv3Jwx7Z);
											if (141684 - 497467 == -355782)
											{
												continue;
											}
										}
									}
									else if (Time.time - Game.mStateTime < (float)4)
									{
										if (13182 - 173416 == -160233)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)3);
										if (155846 - 263855 != -108009)
										{
											continue;
										}
										float a3 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)3);
										if (48129 - 162751 != -114622)
										{
											continue;
										}
										Color color5 = GUI.color;
										if (38510 - 317806 != -279296)
										{
											continue;
										}
										float num3 = color5.a = a3;
										if (266350 - 86407 == 179944 || 129146 - 461103 == -331956)
										{
											continue;
										}
										Color color6 = GUI.color = color5;
										if (10556 - 459177 == -448620)
										{
											continue;
										}
										if (71294 - 87734 != -16440)
										{
											continue;
										}
										if (this.YqLnvbndUJW)
										{
											if (209205 - 144216 != 64989)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.YqLnvbndUJW);
											if (13205 - 350523 == -337317)
											{
												continue;
											}
										}
									}
								}
								else if (mGameState == eGameState.Normal)
								{
									if (64196 - 62438 != 1758)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)2)
									{
										if (299137 - 320541 != -21404)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
										if (186788 - 295034 != -108246)
										{
											continue;
										}
										float a4 = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
										if (281724 - 181166 != 100558)
										{
											continue;
										}
										Color color7 = GUI.color;
										if (296315 - 116784 == 179532)
										{
											continue;
										}
										color7.a = a4;
										if (114805 - 160506 == -45700 || 189700 - 293807 != -104107)
										{
											continue;
										}
										GUI.color = color7;
										if (95205 - 577586 != -482381)
										{
											continue;
										}
										if (3705 - 381506 == -377800)
										{
											continue;
										}
										if (this.amtnvT0wrB1)
										{
											if (53215 - 234677 == -181461)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.amtnvT0wrB1);
											if (279669 - 327663 != -47994)
											{
												continue;
											}
										}
									}
								}
								float a5 = 1f;
								if (278126 - 130857 == 147269)
								{
									Color color8 = GUI.color;
									if (46736 - 243495 == -196759)
									{
										color8.a = a5;
										if (214638 - 367945 == -153307)
										{
											if (205329 - 219526 == -14197)
											{
												GUI.color = color8;
												if (60796 - 98952 != -38155 && 219280 - 304672 != -85391)
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

	// Token: 0x0600AB22 RID: 43810 RVA: 0x013112DC File Offset: 0x0130F4DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (247757 - 118654 != 129103)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (86677 - 454258 != -367580)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (31688 - 537916 == -506228)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (253103 - 371843 == -118740)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (192014 - 409887 != -217872)
						{
							int num4 = num;
							if (78965 - 115284 != -36318)
							{
								if (num4 == 9671)
								{
									if (223245 - 554051 == -330806)
									{
										if (num2 == 1)
										{
											if (88352 - 568198 != -479845)
											{
												this.M8SnvgoaDRk++;
												if (44758 - 174880 != -130121)
												{
													this.SendMessage("newGameMessage", "Team1 score!: " + this.M8SnvgoaDRk + "/" + this.ghAnvasCxnY);
													if (182971 - 128943 == 54028)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.ghAnvasCxnY++;
											if (188274 - 99267 == 89007)
											{
												this.SendMessage("newGameMessage", "Team2 score!: " + this.M8SnvgoaDRk + "/" + this.ghAnvasCxnY);
												if (176722 - 299879 != -123156)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									if (num4 != 9672)
									{
										break;
									}
									if (135205 - 320982 == -185777)
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

	// Token: 0x0600AB23 RID: 43811 RVA: 0x0131155C File Offset: 0x0130F75C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onWaterBallHit(int nLayer)
	{
		if (151023 - 25511 != 125512)
		{
		}
		for (;;)
		{
			if (nLayer == 8)
			{
				if (258008 - 377280 == -119272)
				{
					Game.sendMissionEvent(9671, 2);
					if (132376 - 589175 == -456799)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(9671, 1);
				if (128691 - 405171 == -276480)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600AB24 RID: 43812 RVA: 0x01311604 File Offset: 0x0130F804
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x0600AB25 RID: 43813 RVA: 0x01311608 File Offset: 0x0130F808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x0600AB26 RID: 43814 RVA: 0x0131160C File Offset: 0x0130F80C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M967_SplashWar.$onGameComplete$44753(data, this).GetEnumerator();
	}

	// Token: 0x0600AB27 RID: 43815 RVA: 0x0131161C File Offset: 0x0130F81C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (191192 - 8980 != 182212)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (91960 - 507569 != -415608)
			{
				Time.timeScale = 1f;
				if (267896 - 229765 != 38132)
				{
					Hashtable customOpParameters = new Hashtable();
					if (221076 - 336415 != -115338)
					{
						this.ey3nvRV9Zir.OpCustom(52, customOpParameters, true);
						if (246932 - 207365 == 39567)
						{
							this.amtnvT0wrB1 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
							if (46651 - 184519 == -137868)
							{
								this.a3unvYE1Hvp = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
								if (548 - 220563 == -220015)
								{
									this.RjInv3Jwx7Z = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
									if (96221 - 558290 == -462069)
									{
										this.YqLnvbndUJW = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
										if (174872 - 58655 != 116218)
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

	// Token: 0x0600AB28 RID: 43816 RVA: 0x013117CC File Offset: 0x0130F9CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (10081 - 423967 != -413885)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (264198 - 136326 != 127873)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (83910 - 148991 == -65081)
				{
					Game.mGameState = eGameState.Setup;
					if (248199 - 154154 != 94046)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AB29 RID: 43817 RVA: 0x01311870 File Offset: 0x0130FA70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (26699 - 15488 != 11212)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (70261 - 245202 != -174940)
			{
				if (num == PlayerData.UID)
				{
					if (154572 - 74996 == 79576)
					{
						this.SetupActors();
						if (205465 - 63516 == 141949)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (106614 - 191786 == -85172)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AB2A RID: 43818 RVA: 0x01311940 File Offset: 0x0130FB40
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (101460 - 117863 != -16403)
		{
		}
		for (;;)
		{
			IL_14E:
			Debug.Log("Creating Actors");
			if (287870 - 3211 != 284660)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (154345 - 161697 != -7351)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (241197 - 535892 == -294695)
						{
							int i = 0;
							if (28736 - 165955 != -137218)
							{
								CharacterControl[] array2 = array;
								if (176479 - 381289 == -204810)
								{
									int length = array2.Length;
									if (203340 - 596879 == -393539)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (277452 - 236554 == 40899)
											{
												goto IL_14E;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (18847 - 559842 != -540995)
											{
												goto IL_14E;
											}
											this.Xkqnv4Eb5k9++;
											if (31858 - 379371 != -347513)
											{
												goto IL_14E;
											}
											i++;
											if (244914 - 430231 != -185317)
											{
												goto IL_14E;
											}
										}
										if (74906 - 68474 == 6432)
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
						if (237539 - 395983 != -158443)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB2B RID: 43819 RVA: 0x01311B58 File Offset: 0x0130FD58
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (115618 - 301538 != -185920)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (186405 - 431194 != -244788)
			{
				int i = 0;
				if (58729 - 99979 != -41249)
				{
					CharacterControl[] array2 = array;
					if (168400 - 191754 != -23353)
					{
						int length = array2.Length;
						if (890 - 44514 != -43623)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (101700 - 161028 != -59328)
								{
									goto IL_1A;
								}
								i++;
								if (16804 - 74946 != -58142)
								{
									goto IL_1A;
								}
							}
							if (8028 - 412780 == -404752)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB2C RID: 43820 RVA: 0x01311C88 File Offset: 0x0130FE88
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (270963 - 434986 != -164023)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (279059 - 485770 != -206710)
			{
				hashtable.Add(43, PlayerData.UID);
				if (7229 - 537804 == -530575)
				{
					hashtable.Add(73, nType);
					if (28611 - 162183 != -133571)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (184763 - 499886 != -315122)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (251328 - 62957 != 188372)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (6008 - 257963 == -251955)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (147469 - 286272 == -138803)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (216688 - 294833 == -78145)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (87232 - 415846 != -328613)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (190142 - 245335 == -55193)
												{
													this.ey3nvRV9Zir.OpCustom(63, hashtable, true);
													if (262888 - 172815 == 90073)
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

	// Token: 0x0600AB2D RID: 43821 RVA: 0x01311F40 File Offset: 0x01310140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (258243 - 569690 != -311447)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (114578 - 178371 == -63793)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (293922 - 425981 != -132058)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (248849 - 404347 != -155497)
						{
							if (this.Xkqnv4Eb5k9 <= 0)
							{
								break;
							}
							if (139966 - 255761 != -115794)
							{
								this.Xkqnv4Eb5k9--;
								if (97568 - 387340 == -289772)
								{
									if (this.Xkqnv4Eb5k9 != 0)
									{
										break;
									}
									if (26585 - 200909 != -174323)
									{
										Game.setGameState(eGameState.Ready);
										if (126068 - 1689 == 124379)
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
						if (263084 - 102341 == 160743)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (277240 - 565481 == -288241)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB2E RID: 43822 RVA: 0x013120D0 File Offset: 0x013102D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (122179 - 102828 != 19351)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (117242 - 72110 != 45133)
			{
				Game.mGameState = eGameState.Ready;
				if (74697 - 136692 == -61995)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (147263 - 406128 != -258864 && 63094 - 60600 != 2495)
					{
						GameObject gameObject = null;
						if (985 - 334875 == -333890)
						{
							if (playerSlot < 1)
							{
								goto IL_1D7;
							}
							if (3357 - 438997 == -435639)
							{
								continue;
							}
							if (playerSlot > 8)
							{
								goto IL_1D7;
							}
							if (65166 - 522101 == -456934)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (186606 - 279769 == -93162)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (178252 - 533580 != -355328)
							{
								continue;
							}
							IL_133:
							if (gameObject2)
							{
								if (36499 - 351924 != -315425)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, (playerSlot - 1) % 2 + 1, gameObject2.transform.position, gameObject2.transform.forward);
								if (170648 - 384434 == -213785)
								{
									continue;
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (55321 - 169821 == -114499)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (62808 - 420917 != -358109)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (191434 - 190685 != 750)
							{
								break;
							}
							continue;
							IL_1D7:
							gameObject2 = GameObject.Find("StartPoint1");
							if (5500 - 158699 != -153198)
							{
								goto IL_133;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB2F RID: 43823 RVA: 0x01312368 File Offset: 0x01310568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M967_SplashWar.$StartGame$44761(this).GetEnumerator();
	}

	// Token: 0x0600AB30 RID: 43824 RVA: 0x01312378 File Offset: 0x01310578
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600AB31 RID: 43825 RVA: 0x0131237C File Offset: 0x0131057C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (27991 - 402601 != -374610)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (132441 - 264784 != -132342)
			{
				hashtable.Add(71, CID);
				if (200873 - 587358 == -386485)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (54201 - 469964 != -415762)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (12160 - 90768 == -78608)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (148765 - 278925 == -130160)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (220086 - 202378 == 17708)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (16080 - 458844 != -442763)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (169497 - 214608 != -45110)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (115356 - 546661 == -431305)
											{
												this.ey3nvRV9Zir.OpCustom(61, hashtable, true);
												if (137966 - 353689 != -215722)
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

	// Token: 0x0600AB32 RID: 43826 RVA: 0x01312608 File Offset: 0x01310808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (47904 - 286716 != -238811)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (296400 - 494157 == -197757)
			{
				if (!gameObject)
				{
					break;
				}
				if (223730 - 111351 != 112380)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (294217 - 39734 != 254484)
					{
						playerCameraControl.target = gameObject;
						if (94732 - 106417 != -11684)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (249815 - 115805 == 134010)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB33 RID: 43827 RVA: 0x01312700 File Offset: 0x01310900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (278889 - 362151 != -83261)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (197239 - 392590 == -195351)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (121602 - 418963 != -297360)
				{
					gameGui.ResetTeamBar();
					if (20594 - 193215 != -172620)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AB34 RID: 43828 RVA: 0x013127AC File Offset: 0x013109AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M967_SplashWar.$onDeadPlayer$44765(this).GetEnumerator();
	}

	// Token: 0x0600AB35 RID: 43829 RVA: 0x013127BC File Offset: 0x013109BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (237527 - 79458 != 158070)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (7173 - 175700 == -168527)
			{
				PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
				if (164476 - 271090 != -106613)
				{
					playerCameraControl.target = Game.mPlayer;
					if (80603 - 64262 == 16341)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (288210 - 565113 == -276902)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (173030 - 531693 != -358663)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (240636 - 240643 == -7)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (18188 - 292958 != -274769)
							{
								if (!gameGui)
								{
									break;
								}
								if (235044 - 556195 != -321150)
								{
									gameGui.enabled = true;
									if (224414 - 537095 != -312680)
									{
										gameGui.closeDeadMenu();
										if (239548 - 269433 != -29884)
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

	// Token: 0x0600AB36 RID: 43830 RVA: 0x01312970 File Offset: 0x01310B70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (205 - 586997 != -586792)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (298426 - 357416 != -58989)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (144725 - 461287 == -316562)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (58722 - 423448 == -364726)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AB37 RID: 43831 RVA: 0x01312A34 File Offset: 0x01310C34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (214640 - 224618 != -9978)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
			{
				if (196317 - 205585 != -9267)
				{
					Game.mGameState = eGameState.Ended;
					if (234546 - 224457 == 10089)
					{
						break;
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.AllHold;
				if (269744 - 9189 == 260555)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600AB38 RID: 43832 RVA: 0x01312AEC File Offset: 0x01310CEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M967_SplashWar.$ReturnToTown$44772(this).GetEnumerator();
	}

	// Token: 0x0600AB39 RID: 43833 RVA: 0x01312AFC File Offset: 0x01310CFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M967_SplashWar.$ReturnToGuild$44777(this).GetEnumerator();
	}

	// Token: 0x0600AB3A RID: 43834 RVA: 0x01312B0C File Offset: 0x01310D0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M967_SplashWar.$ReturnToCamp$44781(this).GetEnumerator();
	}

	// Token: 0x0600AB3B RID: 43835 RVA: 0x01312B1C File Offset: 0x01310D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (281733 - 332095 != -50362)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (58720 - 333929 != -275208)
			{
				Hashtable hashtable = new Hashtable();
				if (114983 - 330877 == -215894)
				{
					hashtable.Add(43, PlayerData.UID);
					if (246759 - 160764 == 85995)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (117863 - 136750 == -18887)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB3C RID: 43836 RVA: 0x01312BF4 File Offset: 0x01310DF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600AB3D RID: 43837 RVA: 0x01312C08 File Offset: 0x01310E08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (27090 - 512292 != -485201)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (60784 - 477360 != -416575)
			{
				Hashtable hashtable = new Hashtable();
				if (271742 - 91890 == 179852)
				{
					if (Game.mNextGameCode == 30)
					{
						if (2084 - 597391 != -595307)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (220501 - 314501 == -93999)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (278779 - 61810 == 216970)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (130121 - 377918 != -247797)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (179615 - 436658 == -257042)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (111574 - 551816 != -440242)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (91759 - 445783 == -354023)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (25153 - 117585 != -92432)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (5259 - 389484 == -384224)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (259584 - 149838 != 109746)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (258587 - 59157 != 199430)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (225728 - 199927 == 25802)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (109352 - 235414 != -126062)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (191246 - 291258 == -100011)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (107348 - 249055 != -141707)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (45184 - 395926 == -350741)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (76080 - 37899 != 38181)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (5631 - 62441 != -56810)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (152867 - 578227 == -425359)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (221991 - 407087 != -185096)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (15987 - 467279 != -451292)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (119557 - 186772 != -67215)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (287833 - 444233 == -156399)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (293513 - 595812 == -302298)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (267647 - 392422 == -124774)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (251926 - 40093 != 211833)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (68404 - 144148 != -75744)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (274779 - 100502 != 174277)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (86271 - 266979 != -180707)
					{
						this.ey3nvRV9Zir.OpCustom(42, hashtable, true);
						if (112617 - 511291 != -398673)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB3E RID: 43838 RVA: 0x013131BC File Offset: 0x013113BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600AB3F RID: 43839 RVA: 0x013131CC File Offset: 0x013113CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600AB40 RID: 43840 RVA: 0x013131D0 File Offset: 0x013113D0
	internal static bool UZIUxxVuc5XNxrpwJK1k()
	{
		return true;
	}

	// Token: 0x0600AB41 RID: 43841 RVA: 0x013131D4 File Offset: 0x013113D4
	internal static bool zB62P2VuUXHxs2MGPVWx()
	{
		return false;
	}

	// Token: 0x040097F8 RID: 38904
	private LitePeer ey3nvRV9Zir;

	// Token: 0x040097F9 RID: 38905
	private PlayerCameraControl GkGnvrAECTS;

	// Token: 0x040097FA RID: 38906
	private float L8KnvxW4IGA;

	// Token: 0x040097FB RID: 38907
	private Texture amtnvT0wrB1;

	// Token: 0x040097FC RID: 38908
	private Texture a3unvYE1Hvp;

	// Token: 0x040097FD RID: 38909
	private Texture RjInv3Jwx7Z;

	// Token: 0x040097FE RID: 38910
	private Texture YqLnvbndUJW;

	// Token: 0x040097FF RID: 38911
	private int Ftonvd0eGFB;

	// Token: 0x04009800 RID: 38912
	private int M8SnvgoaDRk;

	// Token: 0x04009801 RID: 38913
	private int ghAnvasCxnY;

	// Token: 0x04009802 RID: 38914
	private int Xkqnv4Eb5k9;

	// Token: 0x02001C99 RID: 7321
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44753 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AB42 RID: 43842 RVA: 0x013131D8 File Offset: 0x013113D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44753(Hashtable data, M967_SplashWar self_)
		{
			if (268271 - 10388 != 257883)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (20439 - 342752 != -322312)
				{
					base..ctor();
					if (59193 - 401988 == -342795)
					{
						this.$data$44759 = data;
						if (64364 - 44948 == 19416)
						{
							this.$self_$44760 = self_;
							if (138609 - 85668 == 52941)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AB43 RID: 43843 RVA: 0x01313294 File Offset: 0x01311494
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M967_SplashWar.$onGameComplete$44753.$(this.$data$44759, this.$self_$44760);
		}

		// Token: 0x0600AB44 RID: 43844 RVA: 0x013132A8 File Offset: 0x013114A8
		internal static bool TKLf0IVuTb281T61OkwB()
		{
			return true;
		}

		// Token: 0x0600AB45 RID: 43845 RVA: 0x013132AC File Offset: 0x013114AC
		internal static bool if50hUVu3WSifjh3LZJK()
		{
			return false;
		}

		// Token: 0x04009803 RID: 38915
		internal Hashtable $data$44759;

		// Token: 0x04009804 RID: 38916
		internal M967_SplashWar $self_$44760;

		// Token: 0x02001C9A RID: 7322
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AB46 RID: 43846 RVA: 0x013132B0 File Offset: 0x013114B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M967_SplashWar self_)
			{
				if (216863 - 378697 != -161833)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (104591 - 342507 == -237916)
					{
						base..ctor();
						if (118284 - 149450 == -31166)
						{
							this.$data$44757 = data;
							if (265065 - 588688 == -323623)
							{
								this.$self_$44758 = self_;
								if (60796 - 195601 == -134805)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AB47 RID: 43847 RVA: 0x0131336C File Offset: 0x0131156C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (13707 - 423947 != -410240)
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
						this.$mCompleteGui$44755 = (CompleteGui)this.$self_$44758.GetComponent(typeof(CompleteGui));
						if (110663 - 22494 == 88170)
						{
							continue;
						}
						this.$mCompleteGui$44755.Init();
						if (65613 - 71832 == -6218)
						{
							continue;
						}
						this.$mCompleteGui$44755.readData(this.$data$44757);
						if (198032 - 269286 != -71254)
						{
							continue;
						}
						if (this.$result$44754 == 1)
						{
							if (4604 - 179365 == -174760)
							{
								continue;
							}
							this.$mCompleteGui$44755.displayResult(eCompleteType.Success);
							if (132602 - 66687 == 65916)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44755.displayResult(eCompleteType.Failed);
							if (77363 - 33802 == 43562)
							{
								continue;
							}
						}
						this.$mGameGui$44756 = (GameGui)this.$self_$44758.GetComponent(typeof(GameGui));
						if (176725 - 578291 != -401566)
						{
							continue;
						}
						if (this.$mGameGui$44756)
						{
							if (188828 - 165201 != 23627)
							{
								continue;
							}
							this.$mGameGui$44756.close();
							if (256195 - 251056 == 5140)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (102403 - 290019 != -187616)
						{
							continue;
						}
						goto IL_28E;
					default:
						if (230470 - 213178 != 17292)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (120772 - 588654 == -467882)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (220459 - 382677 != -162217)
						{
							this.$result$44754 = RuntimeServices.UnboxInt32(this.$data$44757[31]);
							if (39471 - 368139 != -328667)
							{
								goto Block_12;
							}
						}
					}
				}
				goto IL_28E;
				Block_12:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_28E:
				return false;
			}

			// Token: 0x0600AB48 RID: 43848 RVA: 0x0131361C File Offset: 0x0131181C
			internal static bool kUrqYuVuX8GyZQHs5UH4()
			{
				return true;
			}

			// Token: 0x0600AB49 RID: 43849 RVA: 0x01313620 File Offset: 0x01311820
			internal static bool W0K2lbVuQ87y0b1Rc9yI()
			{
				return false;
			}

			// Token: 0x04009805 RID: 38917
			internal int $result$44754;

			// Token: 0x04009806 RID: 38918
			internal CompleteGui $mCompleteGui$44755;

			// Token: 0x04009807 RID: 38919
			internal GameGui $mGameGui$44756;

			// Token: 0x04009808 RID: 38920
			internal Hashtable $data$44757;

			// Token: 0x04009809 RID: 38921
			internal M967_SplashWar $self_$44758;
		}
	}

	// Token: 0x02001C9B RID: 7323
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$44761 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AB4A RID: 43850 RVA: 0x01313624 File Offset: 0x01311824
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$44761(M967_SplashWar self_)
		{
			if (56025 - 164374 != -108348)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (240049 - 348168 != -108118)
				{
					base..ctor();
					if (285686 - 305871 == -20185)
					{
						this.$self_$44764 = self_;
						if (33409 - 390882 != -357472)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AB4B RID: 43851 RVA: 0x013136BC File Offset: 0x013118BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M967_SplashWar.$StartGame$44761.$(this.$self_$44764);
		}

		// Token: 0x0600AB4C RID: 43852 RVA: 0x013136CC File Offset: 0x013118CC
		internal static bool QihG5hVukGbQEBGjXwEl()
		{
			return true;
		}

		// Token: 0x0600AB4D RID: 43853 RVA: 0x013136D0 File Offset: 0x013118D0
		internal static bool gkf7B4VuG1YYZPIGXY0f()
		{
			return false;
		}

		// Token: 0x0400980A RID: 38922
		internal M967_SplashWar $self_$44764;

		// Token: 0x02001C9C RID: 7324
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AB4E RID: 43854 RVA: 0x013136D4 File Offset: 0x013118D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M967_SplashWar self_)
			{
				if (84265 - 130051 != -45785)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (174707 - 346557 != -171849)
					{
						base..ctor();
						if (281129 - 490190 != -209060)
						{
							this.$self_$44763 = self_;
							if (180121 - 210944 == -30823)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AB4F RID: 43855 RVA: 0x0131376C File Offset: 0x0131196C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (273790 - 481800 != -208009)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_289;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (53049 - 6810 != 46239)
							{
								continue;
							}
							goto IL_107;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (113518 - 252464 == -138945)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (84104 - 499732 == -415627)
							{
								continue;
							}
							this.$self_$44763.SendMessage("newGameMessage", "SplashWar started!");
							if (43771 - 177834 == -134062)
							{
								continue;
							}
							Chat.SubmitChat("none", "SplashWar started!", eChatType.system, eChatMode.system);
							if (239837 - 131402 == 108436)
							{
								continue;
							}
							this.YieldDefault(1);
							if (279855 - 247851 != 32005)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					default:
						if (109463 - 377779 != -268316)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (68948 - 83018 == -14070)
					{
						Game.mGameState = eGameState.Start;
						if (110061 - 469045 == -358984)
						{
							Game.mStateTime = Time.time;
							if (141517 - 297618 == -156101)
							{
								this.$mGameGui$44762 = (GameGui)this.$self_$44763.GetComponent(typeof(GameGui));
								if (272688 - 315097 == -42409)
								{
									this.$mGameGui$44762.enableChargeAttack(false);
									if (175180 - 566521 != -391340)
									{
										this.$mGameGui$44762.enableSkill(false);
										if (6192 - 274214 == -268022)
										{
											this.$mGameGui$44762.enabled = true;
											if (169988 - 488573 != -318584)
											{
												this.$self_$44763.SendMessage("fadeIn");
												if (121770 - 306041 != -184270)
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
				return this.Yield(2, new WaitForSeconds(4f));
				Block_8:
				IL_107:
				IL_289:
				return false;
			}

			// Token: 0x0600AB50 RID: 43856 RVA: 0x01313A14 File Offset: 0x01311C14
			internal static bool K06hqqVuHPtrL685FnNF()
			{
				return true;
			}

			// Token: 0x0600AB51 RID: 43857 RVA: 0x01313A18 File Offset: 0x01311C18
			internal static bool FnEHpeVuWEKBPT5epsUZ()
			{
				return false;
			}

			// Token: 0x0400980B RID: 38923
			internal GameGui $mGameGui$44762;

			// Token: 0x0400980C RID: 38924
			internal M967_SplashWar $self_$44763;
		}
	}

	// Token: 0x02001C9D RID: 7325
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44765 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AB52 RID: 43858 RVA: 0x01313A1C File Offset: 0x01311C1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44765(M967_SplashWar self_)
		{
			if (34843 - 516593 != -481750)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (184943 - 220107 != -35163)
				{
					base..ctor();
					if (298934 - 545417 == -246483)
					{
						this.$self_$44771 = self_;
						if (293055 - 447518 == -154463)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AB53 RID: 43859 RVA: 0x01313AB4 File Offset: 0x01311CB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M967_SplashWar.$onDeadPlayer$44765.$(this.$self_$44771);
		}

		// Token: 0x0600AB54 RID: 43860 RVA: 0x01313AC4 File Offset: 0x01311CC4
		internal static bool mtSpKFVuA299DL7NjAXk()
		{
			return true;
		}

		// Token: 0x0600AB55 RID: 43861 RVA: 0x01313AC8 File Offset: 0x01311CC8
		internal static bool xta0yJVulfA48L0Y7VHm()
		{
			return false;
		}

		// Token: 0x0400980D RID: 38925
		internal M967_SplashWar $self_$44771;

		// Token: 0x02001C9E RID: 7326
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AB56 RID: 43862 RVA: 0x01313ACC File Offset: 0x01311CCC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M967_SplashWar self_)
			{
				if (296952 - 426629 != -129676)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (6751 - 475333 != -468581)
					{
						base..ctor();
						if (221863 - 412002 != -190138)
						{
							this.$self_$44770 = self_;
							if (50249 - 2394 != 47856)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AB57 RID: 43863 RVA: 0x01313B64 File Offset: 0x01311D64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (201792 - 336800 != -135008)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3FF;
					case 2:
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_334;
						}
						if (180290 - 16059 == 164232)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (173057 - 455248 != -282191)
							{
								continue;
							}
							goto IL_334;
						}
						IL_13E:
						this.YieldDefault(1);
						if (164628 - 209676 != -45048)
						{
							continue;
						}
						goto IL_3FF;
						IL_334:
						Game.mGameState = eGameState.Hold;
						if (3736 - 585773 == -582036)
						{
							continue;
						}
						this.$mStoryGui$44767 = (StoryGui)this.$self_$44770.GetComponent(typeof(StoryGui));
						if (95269 - 492524 != -397255)
						{
							continue;
						}
						if (this.$mStoryGui$44767)
						{
							if (48802 - 91574 == -42771)
							{
								continue;
							}
							this.$mStoryGui$44767.close();
							if (114128 - 229419 != -115291)
							{
								continue;
							}
						}
						this.$mChangeGui$44768 = (ChangeGui)this.$self_$44770.GetComponent(typeof(ChangeGui));
						if (169063 - 556770 != -387707)
						{
							continue;
						}
						if (this.$mChangeGui$44768)
						{
							if (279333 - 217098 != 62235)
							{
								continue;
							}
							this.$mChangeGui$44768.close();
							if (56325 - 121911 != -65586)
							{
								continue;
							}
						}
						this.$mGameGui$44769 = (GameGui)this.$self_$44770.GetComponent(typeof(GameGui));
						if (282645 - 161539 == 121107)
						{
							continue;
						}
						if (!this.$mGameGui$44769)
						{
							goto IL_13E;
						}
						if (59335 - 159707 == -100371)
						{
							continue;
						}
						if (!this.$mGameGui$44769.enabled)
						{
							if (246995 - 564917 == -317921)
							{
								continue;
							}
							this.$mGameGui$44769.enabled = true;
							if (291348 - 31383 != 259965)
							{
								continue;
							}
						}
						this.$mGameGui$44769.openDeadMenu();
						if (273081 - 527226 != -254145)
						{
							continue;
						}
						goto IL_13E;
					default:
						if (119880 - 214316 != -94436)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (96513 - 201779 != -105265)
					{
						if (!Game.mPlayer)
						{
							break;
						}
						if (54981 - 379403 == -324422)
						{
							this.$mPlayerChar$44766 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (285179 - 327821 != -42641)
							{
								if (!this.$mPlayerChar$44766)
								{
									break;
								}
								if (255130 - 581823 != -326692)
								{
									if (this.$mPlayerChar$44766.mOriginalLayer == 8)
									{
										if (147530 - 49753 == 97777)
										{
											Game.sendMissionEvent(9673, 0);
											if (181000 - 458190 != -277189)
											{
												break;
											}
										}
									}
									else
									{
										Game.sendMissionEvent(9674, 0);
										if (3165 - 132599 != -129433)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				IL_DD:
				return this.Yield(2, new WaitForSeconds((float)2));
				goto IL_DD;
				IL_3FF:
				return false;
			}

			// Token: 0x0600AB58 RID: 43864 RVA: 0x01313F84 File Offset: 0x01312184
			internal static bool vfEA4sVuyUHmddQF2fCY()
			{
				return true;
			}

			// Token: 0x0600AB59 RID: 43865 RVA: 0x01313F88 File Offset: 0x01312188
			internal static bool BQ2twMVuSFkxvmin8FK2()
			{
				return false;
			}

			// Token: 0x0400980E RID: 38926
			internal CharacterControl $mPlayerChar$44766;

			// Token: 0x0400980F RID: 38927
			internal StoryGui $mStoryGui$44767;

			// Token: 0x04009810 RID: 38928
			internal ChangeGui $mChangeGui$44768;

			// Token: 0x04009811 RID: 38929
			internal GameGui $mGameGui$44769;

			// Token: 0x04009812 RID: 38930
			internal M967_SplashWar $self_$44770;
		}
	}

	// Token: 0x02001C9F RID: 7327
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44772 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AB5A RID: 43866 RVA: 0x01313F8C File Offset: 0x0131218C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44772(M967_SplashWar self_)
		{
			if (261400 - 92115 != 169285)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (27431 - 428024 != -400592)
				{
					base..ctor();
					if (38368 - 268861 == -230493)
					{
						this.$self_$44776 = self_;
						if (83985 - 325757 != -241771)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AB5B RID: 43867 RVA: 0x01314024 File Offset: 0x01312224
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M967_SplashWar.$ReturnToTown$44772.$(this.$self_$44776);
		}

		// Token: 0x0600AB5C RID: 43868 RVA: 0x01314034 File Offset: 0x01312234
		internal static bool MtjevHVuonLXeWCnjFhV()
		{
			return true;
		}

		// Token: 0x0600AB5D RID: 43869 RVA: 0x01314038 File Offset: 0x01312238
		internal static bool i81Zh5VuEIZ5m2rNJXa1()
		{
			return false;
		}

		// Token: 0x04009813 RID: 38931
		internal M967_SplashWar $self_$44776;

		// Token: 0x02001CA0 RID: 7328
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AB5E RID: 43870 RVA: 0x0131403C File Offset: 0x0131223C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M967_SplashWar self_)
			{
				if (275920 - 476559 != -200639)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (160308 - 597400 == -437092)
					{
						base..ctor();
						if (242628 - 57503 == 185125)
						{
							this.$self_$44775 = self_;
							if (276295 - 268964 == 7331)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AB5F RID: 43871 RVA: 0x013140D4 File Offset: 0x013122D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (111761 - 332859 != -221097)
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
						this.$self_$44775.LeaveGame();
						if (121363 - 186229 == -64865)
						{
							continue;
						}
						this.YieldDefault(1);
						if (232676 - 82209 != 150467)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (163943 - 80008 != 83935)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (96701 - 579373 == -482672)
					{
						Game.mStateTime = Time.time;
						if (27703 - 226016 == -198313)
						{
							this.$$switch$8330$44773 = PlayerData.SaveGuild;
							if (23946 - 67717 != -43770)
							{
								if (this.$$switch$8330$44773 == 1)
								{
									if (193136 - 474739 == -281602)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (282701 - 110231 != 172470)
									{
										continue;
									}
								}
								else if (this.$$switch$8330$44773 == 2)
								{
									if (161588 - 340174 != -178586)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (105890 - 483769 != -377879)
									{
										continue;
									}
								}
								else if (this.$$switch$8330$44773 == 3)
								{
									if (182821 - 90170 == 92652)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (279042 - 231712 != 47330)
									{
										continue;
									}
								}
								else if (this.$$switch$8330$44773 == 4)
								{
									if (179610 - 359938 != -180328)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (227313 - 286991 == -59677)
									{
										continue;
									}
								}
								else if (this.$$switch$8330$44773 == 5)
								{
									if (63190 - 146344 == -83153)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (149324 - 98560 != 50764)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (158026 - 363957 != -205931)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (273989 - 380777 != -106788)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (224902 - 134697 == 90206)
									{
										continue;
									}
								}
								this.$mGameGui$44774 = (GameGui)this.$self_$44775.GetComponent(typeof(GameGui));
								if (1396 - 549240 != -547843)
								{
									if (this.$mGameGui$44774)
									{
										if (107568 - 493394 == -385825)
										{
											continue;
										}
										this.$mGameGui$44774.close();
										if (83768 - 171205 != -87437)
										{
											continue;
										}
									}
									this.$self_$44775.SendMessage("fadeOut");
									if (203542 - 127111 == 76431)
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

			// Token: 0x0600AB60 RID: 43872 RVA: 0x013144A0 File Offset: 0x013126A0
			internal static bool gKOPdkVu2mOk1vaLPXnU()
			{
				return true;
			}

			// Token: 0x0600AB61 RID: 43873 RVA: 0x013144A4 File Offset: 0x013126A4
			internal static bool hVcdCkVu8Z6iSbqCkebB()
			{
				return false;
			}

			// Token: 0x04009814 RID: 38932
			internal int $$switch$8330$44773;

			// Token: 0x04009815 RID: 38933
			internal GameGui $mGameGui$44774;

			// Token: 0x04009816 RID: 38934
			internal M967_SplashWar $self_$44775;
		}
	}

	// Token: 0x02001CA1 RID: 7329
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44777 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AB62 RID: 43874 RVA: 0x013144A8 File Offset: 0x013126A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44777(M967_SplashWar self_)
		{
			if (51692 - 375430 != -323738)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (86928 - 312737 != -225808)
				{
					base..ctor();
					if (229062 - 543428 != -314365)
					{
						this.$self_$44780 = self_;
						if (36074 - 239226 != -203151)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AB63 RID: 43875 RVA: 0x01314540 File Offset: 0x01312740
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M967_SplashWar.$ReturnToGuild$44777.$(this.$self_$44780);
		}

		// Token: 0x0600AB64 RID: 43876 RVA: 0x01314550 File Offset: 0x01312750
		internal static bool x2N2X7VuZLk1KQfBA6ND()
		{
			return true;
		}

		// Token: 0x0600AB65 RID: 43877 RVA: 0x01314554 File Offset: 0x01312754
		internal static bool uM379ZVuCk7kHp9RhXgM()
		{
			return false;
		}

		// Token: 0x04009817 RID: 38935
		internal M967_SplashWar $self_$44780;

		// Token: 0x02001CA2 RID: 7330
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AB66 RID: 43878 RVA: 0x01314558 File Offset: 0x01312758
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M967_SplashWar self_)
			{
				if (94903 - 360854 != -265951)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (202854 - 84187 != 118668)
					{
						base..ctor();
						if (22081 - 254328 != -232246)
						{
							this.$self_$44779 = self_;
							if (260303 - 269948 != -9644)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AB67 RID: 43879 RVA: 0x013145F0 File Offset: 0x013127F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (36841 - 528853 != -492012)
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
						this.$self_$44779.LeaveGame();
						if (167145 - 341359 == -174213)
						{
							continue;
						}
						this.YieldDefault(1);
						if (203360 - 110054 != 93307)
						{
							goto Block_7;
						}
						continue;
					default:
						if (18351 - 339753 != -321402)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (125271 - 105772 != 19500)
					{
						Game.mStateTime = Time.time;
						if (95090 - 48636 != 46455)
						{
							Game.mNextGameCode = 31;
							if (105561 - 103586 != 1976)
							{
								this.$mGameGui$44778 = (GameGui)this.$self_$44779.GetComponent(typeof(GameGui));
								if (255644 - 76296 != 179349)
								{
									if (this.$mGameGui$44778)
									{
										if (237729 - 80943 != 156786)
										{
											continue;
										}
										this.$mGameGui$44778.close();
										if (263589 - 487360 == -223770)
										{
											continue;
										}
									}
									this.$self_$44779.SendMessage("fadeOut");
									if (153165 - 32166 == 120999)
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

			// Token: 0x0600AB68 RID: 43880 RVA: 0x013147CC File Offset: 0x013129CC
			internal static bool yNcsoHVuLFKNNCtW5LBO()
			{
				return true;
			}

			// Token: 0x0600AB69 RID: 43881 RVA: 0x013147D0 File Offset: 0x013129D0
			internal static bool jXFhTEVuODT2AYLnNc3L()
			{
				return false;
			}

			// Token: 0x04009818 RID: 38936
			internal GameGui $mGameGui$44778;

			// Token: 0x04009819 RID: 38937
			internal M967_SplashWar $self_$44779;
		}
	}

	// Token: 0x02001CA3 RID: 7331
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44781 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AB6A RID: 43882 RVA: 0x013147D4 File Offset: 0x013129D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44781(M967_SplashWar self_)
		{
			if (142267 - 481623 != -339355)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121886 - 90118 == 31768)
				{
					base..ctor();
					if (294723 - 317061 != -22337)
					{
						this.$self_$44785 = self_;
						if (192129 - 382025 != -189895)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AB6B RID: 43883 RVA: 0x0131486C File Offset: 0x01312A6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M967_SplashWar.$ReturnToCamp$44781.$(this.$self_$44785);
		}

		// Token: 0x0600AB6C RID: 43884 RVA: 0x0131487C File Offset: 0x01312A7C
		internal static bool qNjTfcVum6ImJbhJCsub()
		{
			return true;
		}

		// Token: 0x0600AB6D RID: 43885 RVA: 0x01314880 File Offset: 0x01312A80
		internal static bool aBMWB5VuFsEaC9Kbjnmp()
		{
			return false;
		}

		// Token: 0x0400981A RID: 38938
		internal M967_SplashWar $self_$44785;

		// Token: 0x02001CA4 RID: 7332
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AB6E RID: 43886 RVA: 0x01314884 File Offset: 0x01312A84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M967_SplashWar self_)
			{
				if (216575 - 518610 != -302034)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (13397 - 485573 == -472176)
					{
						base..ctor();
						if (224125 - 450193 != -226067)
						{
							this.$self_$44784 = self_;
							if (523 - 428947 != -428423)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AB6F RID: 43887 RVA: 0x0131491C File Offset: 0x01312B1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (251964 - 519279 != -267315)
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
						this.$self_$44784.LeaveGame();
						if (196201 - 122748 == 73454)
						{
							continue;
						}
						this.YieldDefault(1);
						if (180771 - 211364 != -30593)
						{
							continue;
						}
						goto IL_363;
					default:
						if (198570 - 251277 == -52706)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (196453 - 367200 == -170747)
					{
						Game.mStateTime = Time.time;
						if (236637 - 266825 != -30187)
						{
							this.$$switch$8332$44782 = PlayerData.SaveGuild;
							if (113825 - 507711 == -393886)
							{
								if (this.$$switch$8332$44782 == 1)
								{
									if (207594 - 516781 == -309186)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (280004 - 268850 != 11154)
									{
										continue;
									}
								}
								else if (this.$$switch$8332$44782 == 2)
								{
									if (289869 - 241041 == 48829)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (98587 - 286144 != -187557)
									{
										continue;
									}
								}
								else if (this.$$switch$8332$44782 == 3)
								{
									if (183648 - 487381 != -303733)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (29208 - 114596 == -85387)
									{
										continue;
									}
								}
								else if (this.$$switch$8332$44782 == 4)
								{
									if (121043 - 64968 == 56076)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (120416 - 193496 == -73079)
									{
										continue;
									}
								}
								else if (this.$$switch$8332$44782 == 5)
								{
									if (271040 - 327417 != -56377)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (22954 - 432540 != -409586)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (147230 - 517340 != -370110)
									{
										continue;
									}
								}
								this.$mGameGui$44783 = (GameGui)this.$self_$44784.GetComponent(typeof(GameGui));
								if (91729 - 86987 != 4743)
								{
									if (this.$mGameGui$44783)
									{
										if (9023 - 290868 == -281844)
										{
											continue;
										}
										this.$mGameGui$44783.close();
										if (257489 - 162090 != 95399)
										{
											continue;
										}
									}
									this.$self_$44784.SendMessage("fadeOut");
									if (54161 - 146445 == -92284)
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

			// Token: 0x0600AB70 RID: 43888 RVA: 0x01314CA0 File Offset: 0x01312EA0
			internal static bool gHGlVuVuMEcupqsqv2xj()
			{
				return true;
			}

			// Token: 0x0600AB71 RID: 43889 RVA: 0x01314CA4 File Offset: 0x01312EA4
			internal static bool wsqT7NVuxVClBxgqTZFR()
			{
				return false;
			}

			// Token: 0x0400981B RID: 38939
			internal int $$switch$8332$44782;

			// Token: 0x0400981C RID: 38940
			internal GameGui $mGameGui$44783;

			// Token: 0x0400981D RID: 38941
			internal M967_SplashWar $self_$44784;
		}
	}
}
