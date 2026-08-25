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

// Token: 0x020019A2 RID: 6562
[Serializable]
public class M918_Decathlon : MonoBehaviour
{
	// Token: 0x060098B0 RID: 39088 RVA: 0x011ED3E0 File Offset: 0x011EB5E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M918_Decathlon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060098B1 RID: 39089 RVA: 0x011ED3F0 File Offset: 0x011EB5F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (106976 - 194907 != -87931)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (80944 - 201312 != -120367)
			{
				Game.mGameType = 5;
				if (224540 - 259337 != -34796)
				{
					if (Chat.Initialized)
					{
						if (12893 - 247018 != -234124)
						{
							Chat.ChatDisplay.Clear();
							if (197960 - 392819 != -194858)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (234966 - 21321 == 213645)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098B2 RID: 39090 RVA: 0x011ED4D4 File Offset: 0x011EB6D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (195488 - 38327 != 157161)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (262366 - 564987 != -302620)
				{
					Game.nextGame();
					if (137058 - 441677 != -304618)
					{
						Game.mGameCode = 918;
						if (234726 - 62827 != 171900)
						{
							Game.mGameType = 5;
							if (37621 - 334461 != -296839)
							{
								Game.mGameTime = Time.time;
								if (96089 - 384262 == -288173)
								{
									Game.mGameScore = 0;
									if (152328 - 95284 == 57044)
									{
										Game.mGameMana = 0;
										if (160314 - 554262 != -393947)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (203700 - 181589 == 22111)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (94468 - 250737 != -156268)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (217056 - 35929 == 181127)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (282685 - 336195 == -53510)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (252063 - 548455 != -296391)
															{
																this.W05nQY6e2E4 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (252814 - 451870 == -199056)
																{
																	this.d5wnQTTaa73 = PhotonClient.Connection;
																	if (163835 - 444254 != -280418)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (273495 - 39332 != 234164)
																		{
																			this.InitGame();
																			if (86334 - 408912 == -322578)
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
				if (104967 - 263764 == -158797)
				{
					Game.mGameType = 99;
					if (193225 - 245274 != -52048)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060098B3 RID: 39091 RVA: 0x011ED7B4 File Offset: 0x011EB9B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (100795 - 358880 != -258084)
		{
		}
		for (;;)
		{
			if (this.d5wnQTTaa73 == null)
			{
				if (166586 - 451080 == -284494)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (85726 - 594275 == -508549)
				{
					if (mGameState == eGameState.Init)
					{
						if (43138 - 203455 == -160317)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (186602 - 465821 == -279219)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (148071 - 149165 == -1094)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (13088 - 381794 == -368706)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (148426 - 106973 == 41453)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (111228 - 234101 == -122873)
						{
							if (Game.music != 0)
							{
								if (13148 - 15176 == -2027)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (142114 - 416667 == -274552)
									{
										continue;
									}
									this.audio.Play();
									if (149075 - 105336 == 43740)
									{
										continue;
									}
								}
							}
							this.audio.volume = 0.1f * (float)Game.music;
							if (278186 - 83893 == 194293)
							{
								if (Time.time > this.fhHnQ3MVW9o)
								{
									if (161583 - 268133 != -106550)
									{
										continue;
									}
									Game.mGameMana++;
									if (198274 - 121040 == 77235)
									{
										continue;
									}
									this.fhHnQ3MVW9o = Time.time + (float)12;
									if (114089 - 166082 == -51992)
									{
										continue;
									}
								}
								this.GameEventUpdate();
								if (41319 - 362464 != -321144)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (49661 - 63193 != -13531)
						{
							this.GameEventUpdate();
							if (294928 - 498612 == -203684)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (36769 - 312203 != -275433)
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
						if (163881 - 355538 == -191657)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098B4 RID: 39092 RVA: 0x011EDAF0 File Offset: 0x011EBCF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (144397 - 156280 != -11882)
		{
		}
		for (;;)
		{
			eDecathonType eDecathonType = this.rJynQwqUgee;
			if (49670 - 342004 == -292334)
			{
				if (eDecathonType == eDecathonType.selectType)
				{
					if (136616 - 173509 == -36893)
					{
						this.SelectFieldUpdate();
						if (91031 - 363911 == -272880)
						{
							break;
						}
					}
				}
				else if (eDecathonType == eDecathonType.shortRun)
				{
					if (277653 - 491940 == -214287)
					{
						this.ShortRunUpdate();
						if (275822 - 273475 != 2348)
						{
							break;
						}
					}
				}
				else if (eDecathonType == eDecathonType.longRun)
				{
					if (245912 - 473170 == -227258)
					{
						this.LongRunUpdate();
						if (271011 - 573540 == -302529)
						{
							break;
						}
					}
				}
				else if (eDecathonType == eDecathonType.mediumTarget)
				{
					if (180767 - 239911 != -59143)
					{
						this.MediumTargetUpdate();
						if (138559 - 543596 != -405036)
						{
							break;
						}
					}
				}
				else if (eDecathonType == eDecathonType.quickTarget)
				{
					if (35022 - 329066 != -294043)
					{
						this.QuickTargetUpdate();
						if (126281 - 228767 != -102485)
						{
							break;
						}
					}
				}
				else if (eDecathonType == eDecathonType.largeTarget)
				{
					if (144765 - 11075 == 133690)
					{
						this.LargeTargetUpdate();
						if (139930 - 171917 == -31987)
						{
							break;
						}
					}
				}
				else if (eDecathonType == eDecathonType.ironBall)
				{
					if (262686 - 500416 == -237730)
					{
						this.IronBallUpdate();
						if (236308 - 255217 != -18908)
						{
							break;
						}
					}
				}
				else if (eDecathonType == eDecathonType.survivalField)
				{
					if (158628 - 292152 == -133524)
					{
						this.SurvivalFieldUpdate();
						if (154474 - 532854 != -378379)
						{
							break;
						}
					}
				}
				else if (eDecathonType == eDecathonType.mineField)
				{
					if (1785 - 22595 == -20810)
					{
						this.MineFieldUpdate();
						if (239931 - 593276 != -353344)
						{
							break;
						}
					}
				}
				else
				{
					if (eDecathonType != eDecathonType.balanceTrack)
					{
						break;
					}
					if (5962 - 93545 == -87583)
					{
						this.BalanceTrackUpdate();
						if (123602 - 521096 == -397494)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098B5 RID: 39093 RVA: 0x011EDE08 File Offset: 0x011EC008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (75074 - 353472 != -278397)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (292735 - 136707 != 156029)
			{
				float num = (float)1;
				if (238487 - 200350 != 38138)
				{
					float num2 = (float)(1024 * Screen.width / Screen.height);
					if (151768 - 208226 == -56458)
					{
						GUI.depth = 1;
						if (260754 - 185756 == 74998)
						{
							if (this.EvlnQHJjZxe > Time.time)
							{
								if (226974 - 26061 != 200913)
								{
									continue;
								}
								num = Mathf.SmoothStep(0.5f, (float)1, (float)2 - (this.EvlnQHJjZxe - Time.time));
								if (238154 - 264656 == -26501)
								{
									continue;
								}
								float a = Mathf.SmoothStep((float)0, (float)1, (float)2 - (this.EvlnQHJjZxe - Time.time));
								if (92267 - 171591 != -79324)
								{
									continue;
								}
								Color color = GUI.color;
								if (264446 - 183908 == 80539)
								{
									continue;
								}
								color.a = a;
								if (237528 - 233299 != 4229)
								{
									continue;
								}
								if (139017 - 136687 != 2330)
								{
									continue;
								}
								GUI.color = color;
								if (53642 - 217642 == -163999)
								{
									continue;
								}
								if (252462 - 469394 != -216932)
								{
									continue;
								}
								if (this.XdunQ4kgwFH)
								{
									if (292252 - 200314 == 91939)
									{
										continue;
									}
									GUI.DrawTexture(new Rect(0.5f * num2 - 205.5f * num, (float)350 - 50f * num, (float)411 * num, (float)100 * num), this.XdunQ4kgwFH);
									if (256723 - 149783 != 106940)
									{
										continue;
									}
								}
							}
							else if (this.N08nQ7EudNY > Time.time)
							{
								if (46448 - 255550 != -209102)
								{
									continue;
								}
								num = Mathf.SmoothStep(0.5f, (float)1, (float)2 - (this.EvlnQHJjZxe - Time.time));
								if (154133 - 420432 == -266298)
								{
									continue;
								}
								float a2 = Mathf.SmoothStep((float)0, (float)1, (float)2 - (this.EvlnQHJjZxe - Time.time));
								if (34625 - 390361 != -355736)
								{
									continue;
								}
								Color color2 = GUI.color;
								if (282310 - 330795 == -48484)
								{
									continue;
								}
								color2.a = a2;
								if (30333 - 503900 == -473566 || 2625 - 23419 == -20793)
								{
									continue;
								}
								GUI.color = color2;
								if (297108 - 43238 == 253871)
								{
									continue;
								}
								if (139944 - 475005 != -335061)
								{
									continue;
								}
								if (this.YOxnQs1ek3o)
								{
									if (87840 - 240310 == -152469)
									{
										continue;
									}
									GUI.DrawTexture(new Rect(0.5f * num2 - 205.5f * num, (float)350 - 50f * num, (float)411 * num, (float)100 * num), this.YOxnQs1ek3o);
									if (52824 - 483301 != -430477)
									{
										continue;
									}
								}
							}
							if (Game.mGameState == eGameState.Start)
							{
								if (100065 - 537254 != -437189)
								{
									continue;
								}
								eDecathonType eDecathonType = this.rJynQwqUgee;
								if (268211 - 406306 != -138095)
								{
									continue;
								}
								if (eDecathonType == eDecathonType.selectType)
								{
									if (56988 - 99412 != -42424)
									{
										continue;
									}
									if (this.lTHnQZFQGUu == 0)
									{
										if (60691 - 18846 == 41846)
										{
											continue;
										}
										if (!this.GfnnQbq6SYp)
										{
											if (40782 - 155309 != -114526)
											{
												break;
											}
											continue;
										}
										else if (Time.time - Game.mGameTime < (float)2)
										{
											if (285850 - 432524 == -146673)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
											if (216976 - 103223 != 113753)
											{
												continue;
											}
											float a3 = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
											if (133715 - 566626 != -432911)
											{
												continue;
											}
											Color color3 = GUI.color;
											if (15148 - 401570 != -386422)
											{
												continue;
											}
											color3.a = a3;
											if (169918 - 578519 == -408600)
											{
												continue;
											}
											if (210486 - 514468 != -303982)
											{
												continue;
											}
											Color color4 = GUI.color = color3;
											if (277662 - 418179 != -140517)
											{
												continue;
											}
											if (131518 - 72187 == 59332)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.GfnnQbq6SYp);
											if (26720 - 417532 != -390812)
											{
												continue;
											}
											float a4 = 1f;
											if (205460 - 488129 != -282669)
											{
												continue;
											}
											Color color5 = GUI.color;
											if (85531 - 289508 == -203976)
											{
												continue;
											}
											color5.a = a4;
											if (114325 - 480896 != -366571)
											{
												continue;
											}
											if (49496 - 144434 != -94938)
											{
												continue;
											}
											Color color6 = GUI.color = color5;
											if (73482 - 563117 != -489635)
											{
												continue;
											}
											if (76845 - 514422 != -437577)
											{
												continue;
											}
										}
									}
								}
								else if (Time.time - Game.mStateTime < (float)1)
								{
									if (184880 - 159377 == 25504)
									{
										continue;
									}
									num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime);
									if (12047 - 324765 == -312717)
									{
										continue;
									}
									float a5 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime);
									if (179708 - 409132 != -229424)
									{
										continue;
									}
									Color color7 = GUI.color;
									if (130849 - 90421 != 40428)
									{
										continue;
									}
									color7.a = a5;
									if (50680 - 3510 == 47171)
									{
										continue;
									}
									if (230522 - 47564 != 182958)
									{
										continue;
									}
									Color color8 = GUI.color = color7;
									if (114798 - 55389 != 59409)
									{
										continue;
									}
									if (236843 - 61805 == 175039)
									{
										continue;
									}
									if (this.Fo3nQdijhbt)
									{
										if (114771 - 268012 == -153240)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.Fo3nQdijhbt);
										if (121725 - 314604 != -192879)
										{
											continue;
										}
									}
								}
								else if (Time.time - Game.mStateTime < (float)2)
								{
									if (298195 - 229947 == 68249)
									{
										continue;
									}
									num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)1);
									if (244136 - 304279 == -60142)
									{
										continue;
									}
									float a6 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)1);
									if (122415 - 62001 == 60415)
									{
										continue;
									}
									Color color9 = GUI.color;
									if (175706 - 181518 == -5811)
									{
										continue;
									}
									float num3 = color9.a = a6;
									if (107736 - 420626 != -312890)
									{
										continue;
									}
									if (249125 - 575396 == -326270)
									{
										continue;
									}
									GUI.color = color9;
									if (196299 - 456336 != -260037)
									{
										continue;
									}
									if (237623 - 298650 == -61026)
									{
										continue;
									}
									if (this.AK3nQgYwLUT)
									{
										if (197630 - 183513 == 14118)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.AK3nQgYwLUT);
										if (219237 - 138898 == 80340)
										{
											continue;
										}
									}
								}
								else if (Time.time - Game.mStateTime < (float)3)
								{
									if (117450 - 274786 == -157335)
									{
										continue;
									}
									num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)2);
									if (83901 - 545769 == -461867)
									{
										continue;
									}
									float a7 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)2);
									if (65512 - 424043 == -358530)
									{
										continue;
									}
									Color color10 = GUI.color;
									if (257920 - 489713 != -231793)
									{
										continue;
									}
									float num4 = color10.a = a7;
									if (227899 - 380501 == -152601)
									{
										continue;
									}
									if (251320 - 524465 != -273145)
									{
										continue;
									}
									GUI.color = color10;
									if (115296 - 61267 != 54029)
									{
										continue;
									}
									if (17041 - 289143 != -272102)
									{
										continue;
									}
									if (this.ibZnQaUkusn)
									{
										if (279028 - 429214 == -150185)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.ibZnQaUkusn);
										if (170115 - 399318 == -229202)
										{
											continue;
										}
									}
								}
							}
							float a8 = 1f;
							if (291039 - 139583 != 151457)
							{
								Color color11 = GUI.color;
								if (264085 - 480583 == -216498)
								{
									color11.a = a8;
									if (91460 - 293047 == -201587)
									{
										if (259687 - 478352 == -218665)
										{
											Color color12 = GUI.color = color11;
											if (281407 - 527523 == -246116)
											{
												if (214574 - 197996 == 16578)
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

	// Token: 0x060098B6 RID: 39094 RVA: 0x011EEB80 File Offset: 0x011ECD80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (88422 - 139852 != -51429)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (175828 - 293304 != -117475)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (67991 - 591088 != -523096)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (288662 - 534485 == -245823)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (275498 - 317075 == -41577)
						{
							object obj2;
							object obj = obj2 = Game.getPlayerName(num3);
							if (!(obj is string))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(string));
							}
							string lhs = (string)obj2;
							if (120514 - 115895 != 4620)
							{
								int num4 = Game.getPlayerSlot(num3) % 2 + 1;
								if (91810 - 373784 == -281974)
								{
									int num5 = num;
									if (219113 - 129089 != 90025)
									{
										if (num5 == 9181)
										{
											if (297399 - 353336 != -55936)
											{
												break;
											}
										}
										else if (num5 == 9182)
										{
											if (24286 - 505709 != -481422)
											{
												break;
											}
										}
										else if (num5 == -9182)
										{
											if (136503 - 402277 != -265773)
											{
												if (num3 == PlayerData.UID)
												{
													if (149343 - 503626 != -354282)
													{
														this.StartCoroutine_Auto(this.StartNextRound(num2, true));
														if (246149 - 98084 != 148066)
														{
															break;
														}
													}
												}
												else
												{
													this.StartCoroutine_Auto(this.StartNextRound(num2, false));
													if (210534 - 528 == 210006)
													{
														break;
													}
												}
											}
										}
										else if (num5 == 9183)
										{
											if (28251 - 549302 == -521051)
											{
												break;
											}
										}
										else if (num5 == -9183)
										{
											if (18836 - 498662 != -479825)
											{
												eDecathonType eDecathonType = this.rJynQwqUgee;
												if (1027 - 318494 == -317467)
												{
													if (eDecathonType == eDecathonType.shortRun)
													{
														if (141358 - 291465 != -150106)
														{
															if (num4 == 1)
															{
																if (152235 - 587058 != -434823)
																{
																	continue;
																}
																this.eONnQfDYQaS += 6 - num2;
																if (295721 - 146771 == 148951)
																{
																	continue;
																}
															}
															else
															{
																this.FZQnQL2vNcs += 6 - num2;
																if (282036 - 464916 == -182879)
																{
																	continue;
																}
															}
															this.SendMessage("newGameMessage", lhs + " has finished " + this.getPlaceString(num2));
															if (121662 - 471839 != -350176)
															{
																Chat.SubmitChat("none", lhs + " has finished " + this.getPlaceString(num2), eChatType.system, eChatMode.system);
																if (255055 - 122524 == 132531)
																{
																	break;
																}
															}
														}
													}
													else if (eDecathonType == eDecathonType.longRun)
													{
														if (189490 - 197366 != -7875)
														{
															if (num4 == 1)
															{
																if (273926 - 521049 == -247122)
																{
																	continue;
																}
																this.eONnQfDYQaS += 6 - num2;
																if (199643 - 156637 == 43007)
																{
																	continue;
																}
															}
															else
															{
																this.FZQnQL2vNcs += 6 - num2;
																if (8154 - 169179 == -161024)
																{
																	continue;
																}
															}
															this.SendMessage("newGameMessage", lhs + " has finished " + this.getPlaceString(num2));
															if (124002 - 461453 == -337451)
															{
																Chat.SubmitChat("none", lhs + " has finished " + this.getPlaceString(num2), eChatType.system, eChatMode.system);
																if (287506 - 63927 == 223579)
																{
																	break;
																}
															}
														}
													}
													else if (eDecathonType == eDecathonType.mediumTarget)
													{
														if (157988 - 468691 == -310703)
														{
															if (num2 == 2)
															{
																if (112379 - 189179 != -76800)
																{
																	continue;
																}
																this.eONnQfDYQaS++;
																if (273949 - 363933 == -89983)
																{
																	continue;
																}
															}
															else
															{
																this.FZQnQL2vNcs++;
																if (170156 - 189797 == -19640)
																{
																	continue;
																}
															}
															this.SendMessage("newGameMessage", "Medium Target Score: " + this.eONnQfDYQaS + "/" + this.FZQnQL2vNcs);
															if (2994 - 20841 == -17847)
															{
																break;
															}
														}
													}
													else if (eDecathonType == eDecathonType.quickTarget)
													{
														if (74966 - 182818 == -107852)
														{
															if (num2 == 2)
															{
																if (142742 - 307472 == -164729)
																{
																	continue;
																}
																this.eONnQfDYQaS++;
																if (74723 - 121098 != -46375)
																{
																	continue;
																}
															}
															else
															{
																this.FZQnQL2vNcs++;
																if (50341 - 21008 == 29334)
																{
																	continue;
																}
															}
															this.SendMessage("newGameMessage", "Quick Target Score: " + this.eONnQfDYQaS + "/" + this.FZQnQL2vNcs);
															if (152919 - 6848 != 146072)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (194060 - 470980 == -276920)
																{
																	this.QuickTargetCreate(num2);
																	if (141707 - 47775 == 93932)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (eDecathonType == eDecathonType.survivalField)
													{
														if (186716 - 306780 != -120063)
														{
															if (num4 == 1)
															{
																if (119147 - 215763 != -96616)
																{
																	continue;
																}
																this.eONnQfDYQaS -= 6 - num2;
																if (196124 - 384106 != -187982)
																{
																	continue;
																}
															}
															else
															{
																this.FZQnQL2vNcs -= 6 - num2;
																if (193850 - 520055 != -326205)
																{
																	continue;
																}
															}
															this.SendMessage("newGameMessage", lhs + " is dead: " + this.eONnQfDYQaS + "/" + this.FZQnQL2vNcs);
															if (249488 - 102971 != 146518)
															{
																Chat.SubmitChat("none", lhs + "  is dead: -" + this.eONnQfDYQaS + "/" + this.FZQnQL2vNcs, eChatType.system, eChatMode.system);
																if (197335 - 191937 == 5398)
																{
																	break;
																}
															}
														}
													}
													else if (eDecathonType == eDecathonType.mineField)
													{
														if (878 - 328160 != -327281)
														{
															if (num4 == 1)
															{
																if (260932 - 77299 != 183633)
																{
																	continue;
																}
																this.eONnQfDYQaS += 6 - num2;
																if (242799 - 217421 != 25378)
																{
																	continue;
																}
															}
															else
															{
																this.FZQnQL2vNcs += 6 - num2;
																if (68544 - 279532 != -210988)
																{
																	continue;
																}
															}
															this.SendMessage("newGameMessage", lhs + " has finished " + this.getPlaceString(num2));
															if (231017 - 38588 != 192430)
															{
																Chat.SubmitChat("none", lhs + " has finished " + this.getPlaceString(num2), eChatType.system, eChatMode.system);
																if (8973 - 505364 != -496390)
																{
																	break;
																}
															}
														}
													}
													else if (eDecathonType == eDecathonType.balanceTrack)
													{
														if (121767 - 77166 != 44602)
														{
															if (num4 == 1)
															{
																if (247232 - 577251 == -330018)
																{
																	continue;
																}
																this.eONnQfDYQaS -= 6 - num2;
																if (190548 - 428451 != -237903)
																{
																	continue;
																}
															}
															else
															{
																this.FZQnQL2vNcs -= 6 - num2;
																if (150532 - 556525 == -405992)
																{
																	continue;
																}
															}
															this.SendMessage("newGameMessage", lhs + " has fallen into the pit: " + this.eONnQfDYQaS + "/" + this.FZQnQL2vNcs);
															if (2846 - 75698 != -72851)
															{
																Chat.SubmitChat("none", lhs + " has fallen into the pit: " + this.eONnQfDYQaS + "/" + this.FZQnQL2vNcs, eChatType.system, eChatMode.system);
																if (21453 - 299835 != -278381)
																{
																	break;
																}
															}
														}
													}
													else
													{
														Debug.LogError("Warning unknown mDecathonType:" + this.rJynQwqUgee);
														if (258458 - 437950 != -179491)
														{
															break;
														}
													}
												}
											}
										}
										else if (num5 == 9184)
										{
											if (156999 - 116457 == 40542)
											{
												break;
											}
										}
										else if (num5 == -9184)
										{
											if (79825 - 20619 != 59207)
											{
												this.StartCoroutine_Auto(this.EndDecathon(num2));
												if (139487 - 459291 == -319804)
												{
													break;
												}
											}
										}
										else if (num5 == 9185)
										{
											if (180842 - 503582 == -322740)
											{
												break;
											}
										}
										else if (num5 == -9185)
										{
											if (224436 - 393924 == -169488)
											{
												this.StartCoroutine_Auto(this.SurvivalBombCreate(num2));
												if (189969 - 139194 == 50775)
												{
													break;
												}
											}
										}
										else if (num5 == 9186)
										{
											if (113145 - 56273 != 56873)
											{
												this.MineFieldCreate(num3, num2);
												if (58220 - 133093 != -74872)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Warning unknown returnCode:" + num);
											if (45816 - 236732 != -190915)
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

	// Token: 0x060098B7 RID: 39095 RVA: 0x011EF848 File Offset: 0x011EDA48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getPlaceString(int nPlace)
	{
		if (150909 - 206382 != -55472)
		{
		}
		string result;
		for (;;)
		{
			result = string.Empty;
			if (70198 - 336889 != -266690)
			{
				if (128799 - 258115 == -129316)
				{
					if (nPlace == 1)
					{
						if (131232 - 167642 == -36409 || 284759 - 291710 == -6950)
						{
							continue;
						}
					}
					else
					{
						if (nPlace != 2)
						{
							goto IL_3F;
						}
						if (52314 - 98913 == -46598)
						{
							continue;
						}
					}
					if (141455 - 276050 != -134595)
					{
						continue;
					}
					IL_3F:
					result = nPlace + "th place";
					if (289839 - 87568 == 202271)
					{
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x060098B8 RID: 39096 RVA: 0x011EF974 File Offset: 0x011EDB74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitDecathon()
	{
		if (175073 - 50422 != 124651)
		{
		}
		for (;;)
		{
			Debug.Log("Init Decathon");
			if (89587 - 568583 == -478996)
			{
				this.xeZnQUt2UwR = new UnityScript.Lang.Array();
				if (281110 - 127885 == 153225)
				{
					this.rJynQwqUgee = eDecathonType.selectType;
					if (280284 - 30993 != 249292)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060098B9 RID: 39097 RVA: 0x011EFA18 File Offset: 0x011EDC18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isPool(int nNum)
	{
		if (160132 - 37499 != 122633)
		{
		}
		for (;;)
		{
			IL_1A:
			IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.xeZnQUt2UwR);
			if (96795 - 566211 != -469415)
			{
				while (enumerator.MoveNext())
				{
					object value = enumerator.Current;
					int num = RuntimeServices.UnboxInt32(value);
					if (297514 - 238423 == 59092)
					{
						goto IL_1A;
					}
					if (num == nNum)
					{
						if (281491 - 10195 != 271297)
						{
							goto Block_4;
						}
						goto IL_1A;
					}
				}
				if (249545 - 302447 == -52902)
				{
					goto IL_B7;
				}
			}
		}
		Block_4:
		return false;
		IL_B7:
		return true;
	}

	// Token: 0x060098BA RID: 39098 RVA: 0x011EFAF0 File Offset: 0x011EDCF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartNextRound(int nType, bool isHost)
	{
		return new M918_Decathlon.$StartNextRound$42461(nType, isHost, this).GetEnumerator();
	}

	// Token: 0x060098BB RID: 39099 RVA: 0x011EFB00 File Offset: 0x011EDD00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator SetupDecathon(int nType, bool isHost)
	{
		return new M918_Decathlon.$SetupDecathon$42469(nType, isHost, this).GetEnumerator();
	}

	// Token: 0x060098BC RID: 39100 RVA: 0x011EFB10 File Offset: 0x011EDD10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndDecathon(int nWinnerTeam)
	{
		return new M918_Decathlon.$EndDecathon$42495(nWinnerTeam, this).GetEnumerator();
	}

	// Token: 0x060098BD RID: 39101 RVA: 0x011EFB20 File Offset: 0x011EDD20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SelectFieldUpdate()
	{
	}

	// Token: 0x060098BE RID: 39102 RVA: 0x011EFB24 File Offset: 0x011EDD24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SelectFieldEnter1(GameObject enterObject)
	{
		if (132952 - 280845 != -147893)
		{
		}
		for (;;)
		{
			if (!enterObject)
			{
				if (261332 - 34367 != 226966)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (130603 - 427736 == -297133)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (40515 - 513054 == -472539)
				{
					break;
				}
			}
			else if ((enterObject.layer + this.lTHnQZFQGUu) % 2 == 1)
			{
				if (4071 - 422477 != -418405)
				{
					this.SendMessage("newGameMessage", "Only the other team can choose");
					if (251514 - 71885 != 179630)
					{
						break;
					}
				}
			}
			else if (this.isPool(1))
			{
				if (250779 - 8197 == 242582)
				{
					this.SendMessage("newGameMessage", "You have selected Short Running");
					if (157550 - 409735 != -252184)
					{
						Chat.SubmitChat("none", "You have selected Short Running", eChatType.system, eChatMode.system);
						if (196850 - 399294 != -202443)
						{
							Game.sendMissionEvent(9182, 1);
							if (58895 - 150021 == -91126)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				this.SendMessage("newGameMessage", "This game has already been played");
				if (204559 - 343152 != -138592)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060098BF RID: 39103 RVA: 0x011EFD14 File Offset: 0x011EDF14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SelectFieldEnter2(GameObject enterObject)
	{
		if (48354 - 418751 != -370396)
		{
		}
		for (;;)
		{
			if (!enterObject)
			{
				if (297161 - 479573 == -182412)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (204185 - 480866 != -276680)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (217285 - 599656 == -382371)
				{
					break;
				}
			}
			else if ((enterObject.layer + this.lTHnQZFQGUu) % 2 == 1)
			{
				if (158777 - 250620 != -91842)
				{
					this.SendMessage("newGameMessage", "Only the other team can choose");
					if (83856 - 99227 != -15370)
					{
						break;
					}
				}
			}
			else if (this.isPool(2))
			{
				if (8824 - 121886 != -113061)
				{
					this.SendMessage("newGameMessage", "You have selected Long Running");
					if (169991 - 396179 == -226188)
					{
						Chat.SubmitChat("none", "You have selected Long Running", eChatType.system, eChatMode.system);
						if (298433 - 53478 == 244955)
						{
							Game.sendMissionEvent(9182, 2);
							if (298286 - 181567 == 116719)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				this.SendMessage("newGameMessage", "This game has already been played");
				if (183941 - 108989 == 74952)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060098C0 RID: 39104 RVA: 0x011EFF04 File Offset: 0x011EE104
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SelectFieldEnter3(GameObject enterObject)
	{
		if (16264 - 405867 != -389602)
		{
		}
		for (;;)
		{
			if (!enterObject)
			{
				if (90978 - 170999 == -80021)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (247626 - 328071 == -80445)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (224513 - 64054 != 160460)
				{
					break;
				}
			}
			else if ((enterObject.layer + this.lTHnQZFQGUu) % 2 == 1)
			{
				if (124222 - 282203 != -157980)
				{
					this.SendMessage("newGameMessage", "Only the other team can choose");
					if (250562 - 433687 == -183125)
					{
						break;
					}
				}
			}
			else if (this.isPool(3))
			{
				if (249475 - 303401 == -53926)
				{
					this.SendMessage("newGameMessage", "You have selected Medium Target Range");
					if (13945 - 477257 != -463311)
					{
						Chat.SubmitChat("none", "You have selected Medium Target Range", eChatType.system, eChatMode.system);
						if (38012 - 57654 == -19642)
						{
							Game.sendMissionEvent(9182, 3);
							if (42528 - 313209 == -270681)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				this.SendMessage("newGameMessage", "This game has already been played");
				if (38126 - 203108 != -164981)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060098C1 RID: 39105 RVA: 0x011F00F4 File Offset: 0x011EE2F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SelectFieldEnter4(GameObject enterObject)
	{
		if (17629 - 347435 != -329805)
		{
		}
		for (;;)
		{
			if (!enterObject)
			{
				if (11879 - 220428 != -208548)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (280956 - 593524 != -312567)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (58827 - 80364 == -21537)
				{
					break;
				}
			}
			else if ((enterObject.layer + this.lTHnQZFQGUu) % 2 == 1)
			{
				if (100048 - 565579 != -465530)
				{
					this.SendMessage("newGameMessage", "Only the other team can choose");
					if (290090 - 383771 == -93681)
					{
						break;
					}
				}
			}
			else if (this.isPool(4))
			{
				if (131730 - 516647 == -384917)
				{
					this.SendMessage("newGameMessage", "You have selected Quick Target Range");
					if (97274 - 238824 == -141550)
					{
						Chat.SubmitChat("none", "You have selected Quick Target Range", eChatType.system, eChatMode.system);
						if (277274 - 413014 == -135740)
						{
							Game.sendMissionEvent(9182, 4);
							if (171954 - 380411 == -208457)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				this.SendMessage("newGameMessage", "This game has already been played");
				if (228765 - 413671 == -184906)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060098C2 RID: 39106 RVA: 0x011F02E4 File Offset: 0x011EE4E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SelectFieldEnter5(GameObject enterObject)
	{
		if (120072 - 185471 != -65399)
		{
		}
		for (;;)
		{
			if (!enterObject)
			{
				if (186424 - 171462 != 14963)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (161767 - 421860 != -260092)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (10487 - 502753 == -492266)
				{
					break;
				}
			}
			else if ((enterObject.layer + this.lTHnQZFQGUu) % 2 == 1)
			{
				if (237013 - 211255 == 25758)
				{
					this.SendMessage("newGameMessage", "Only the other team can choose");
					if (106112 - 343618 == -237506)
					{
						break;
					}
				}
			}
			else if (this.isPool(5))
			{
				if (287632 - 477535 == -189903)
				{
					this.SendMessage("newGameMessage", "You have selected Large Target Range");
					if (299347 - 358665 == -59318)
					{
						Chat.SubmitChat("none", "You have selected Large Target Range", eChatType.system, eChatMode.system);
						if (50202 - 221186 == -170984)
						{
							Game.sendMissionEvent(9182, 5);
							if (198352 - 124833 == 73519)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				this.SendMessage("newGameMessage", "This game has already been played");
				if (132017 - 483355 == -351338)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060098C3 RID: 39107 RVA: 0x011F04D4 File Offset: 0x011EE6D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SelectFieldEnter6(GameObject enterObject)
	{
		if (197652 - 219456 != -21803)
		{
		}
		for (;;)
		{
			if (!enterObject)
			{
				if (23325 - 575928 != -552602)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (227211 - 558214 == -331003)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (71545 - 537719 == -466174)
				{
					break;
				}
			}
			else if ((enterObject.layer + this.lTHnQZFQGUu) % 2 == 1)
			{
				if (208865 - 535029 != -326163)
				{
					this.SendMessage("newGameMessage", "Only the other team can choose");
					if (244928 - 431626 != -186697)
					{
						break;
					}
				}
			}
			else if (this.isPool(6))
			{
				if (92410 - 345494 != -253083)
				{
					this.SendMessage("newGameMessage", "You have selected Iron Ball");
					if (64351 - 380731 != -316379)
					{
						Chat.SubmitChat("none", "You have selected Iron Ball", eChatType.system, eChatMode.system);
						if (164421 - 571930 != -407508)
						{
							Game.sendMissionEvent(9182, 6);
							if (261356 - 76697 == 184659)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				this.SendMessage("newGameMessage", "This game has already been played");
				if (143771 - 352520 == -208749)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060098C4 RID: 39108 RVA: 0x011F06C4 File Offset: 0x011EE8C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SelectFieldEnter7(GameObject enterObject)
	{
		if (272243 - 63524 != 208719)
		{
		}
		for (;;)
		{
			if (!enterObject)
			{
				if (225040 - 406198 != -181157)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (266751 - 240978 != 25774)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (165933 - 248836 == -82903)
				{
					break;
				}
			}
			else if ((enterObject.layer + this.lTHnQZFQGUu) % 2 == 1)
			{
				if (213893 - 598411 == -384518)
				{
					this.SendMessage("newGameMessage", "Only the other team can choose");
					if (202210 - 125997 == 76213)
					{
						break;
					}
				}
			}
			else if (this.isPool(7))
			{
				if (82199 - 318363 != -236163)
				{
					this.SendMessage("newGameMessage", "You have selected Survival Field");
					if (227823 - 379102 == -151279)
					{
						Chat.SubmitChat("none", "You have selected Survival Field", eChatType.system, eChatMode.system);
						if (135612 - 574201 == -438589)
						{
							Game.sendMissionEvent(9182, 7);
							if (240535 - 285612 != -45076)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				this.SendMessage("newGameMessage", "This game has already been played");
				if (44970 - 537592 != -492621)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060098C5 RID: 39109 RVA: 0x011F08B4 File Offset: 0x011EEAB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SelectFieldEnter8(GameObject enterObject)
	{
		if (96840 - 141864 != -45023)
		{
		}
		for (;;)
		{
			if (!enterObject)
			{
				if (108646 - 52453 != 56194)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (142040 - 349607 != -207566)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (35778 - 480257 == -444479)
				{
					break;
				}
			}
			else if ((enterObject.layer + this.lTHnQZFQGUu) % 2 == 1)
			{
				if (135321 - 195446 != -60124)
				{
					this.SendMessage("newGameMessage", "Only the other team can choose");
					if (267998 - 218174 == 49824)
					{
						break;
					}
				}
			}
			else if (this.isPool(8))
			{
				if (211469 - 508171 != -296701)
				{
					this.SendMessage("newGameMessage", "You have selected Mine Field");
					if (92044 - 212982 != -120937)
					{
						Chat.SubmitChat("none", "You have selected Mine Field", eChatType.system, eChatMode.system);
						if (131714 - 231604 != -99889)
						{
							Game.sendMissionEvent(9182, 8);
							if (165126 - 504482 == -339356)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				this.SendMessage("newGameMessage", "This game has already been played");
				if (104364 - 352436 != -248071)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060098C6 RID: 39110 RVA: 0x011F0AA4 File Offset: 0x011EECA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SelectFieldEnter9(GameObject enterObject)
	{
		if (278849 - 59507 != 219342)
		{
		}
		for (;;)
		{
			if (!enterObject)
			{
				if (243840 - 379657 == -135817)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (261565 - 339288 == -77723)
				{
					break;
				}
			}
			else if (enterObject != Game.mPlayer)
			{
				if (154366 - 457696 == -303330)
				{
					break;
				}
			}
			else if ((enterObject.layer + this.lTHnQZFQGUu) % 2 == 1)
			{
				if (135959 - 133820 != 2140)
				{
					this.SendMessage("newGameMessage", "Only the other team can choose");
					if (286869 - 390314 == -103445)
					{
						break;
					}
				}
			}
			else if (this.isPool(9))
			{
				if (113399 - 472329 != -358929)
				{
					this.SendMessage("newGameMessage", "You have selected Balance Track");
					if (36040 - 212191 != -176150)
					{
						Chat.SubmitChat("none", "You have selected Balance Track", eChatType.system, eChatMode.system);
						if (272236 - 596074 == -323838)
						{
							Game.sendMissionEvent(9182, 9);
							if (39245 - 448440 == -409195)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				this.SendMessage("newGameMessage", "This game has already been played");
				if (173785 - 224290 == -50505)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060098C7 RID: 39111 RVA: 0x011F0C94 File Offset: 0x011EEE94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SelectFieldEnter10(GameObject enterObject)
	{
		if (155568 - 267670 != -112101)
		{
		}
		for (;;)
		{
			if (this.isPool(9))
			{
				if (89737 - 476183 == -386446)
				{
					this.SendMessage("newGameMessage", "This game is not available");
					if (13303 - 516830 != -503526)
					{
						Chat.SubmitChat("none", "This game is not available", eChatType.system, eChatMode.system);
						if (11566 - 494295 != -482728)
						{
							break;
						}
					}
				}
			}
			else
			{
				this.SendMessage("newGameMessage", "This game has already been played");
				if (42423 - 514923 != -472499)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060098C8 RID: 39112 RVA: 0x011F0D78 File Offset: 0x011EEF78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ShortRunUpdate()
	{
		if (194214 - 255366 != -61151)
		{
		}
		while (Time.time - Game.mGameTime >= (float)0)
		{
			if (108033 - 110369 == -2336)
			{
				Game.sendMissionEvent(9184, 0);
				if (111995 - 307181 == -195186)
				{
					Game.mGameState = eGameState.AllHold;
					if (244475 - 7195 != 237281)
					{
						Game.mStateTime = Time.time;
						if (144355 - 221097 != -76741)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098C9 RID: 39113 RVA: 0x011F0E48 File Offset: 0x011EF048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterShortRunningGoal(GameObject enterObject)
	{
		if (179521 - 115714 != 63807)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (44032 - 125599 == -81567)
				{
					break;
				}
			}
			else
			{
				if (!(enterObject == Game.mPlayer))
				{
					break;
				}
				if (71155 - 332848 == -261693)
				{
					CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
					if (245101 - 104564 != 140538)
					{
						if (!characterControl)
						{
							break;
						}
						if (178238 - 268056 == -89818)
						{
							Game.mGameState = eGameState.Hold;
							if (241372 - 344928 == -103556)
							{
								Game.mStateTime = Time.time;
								if (148744 - 278729 != -129984)
								{
									Game.mPlayer.SendMessage("PositionEvent");
									if (140084 - 236725 == -96641)
									{
										Game.sendMissionEvent(9183, characterControl.mOriginalLayer - 7);
										if (201118 - 342581 != -141462)
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

	// Token: 0x060098CA RID: 39114 RVA: 0x011F0FC4 File Offset: 0x011EF1C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LongRunUpdate()
	{
		if (202174 - 213611 != -11437)
		{
		}
		while (Time.time - Game.mGameTime >= (float)0)
		{
			if (55081 - 412021 == -356940)
			{
				Game.sendMissionEvent(9184, 0);
				if (275906 - 455768 == -179862)
				{
					Game.mGameState = eGameState.AllHold;
					if (223978 - 491154 != -267175)
					{
						Game.mStateTime = Time.time;
						if (99119 - 556370 == -457251)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098CB RID: 39115 RVA: 0x011F1094 File Offset: 0x011EF294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetupLongRunning()
	{
		if (68369 - 167628 != -99258)
		{
		}
		for (;;)
		{
			IL_EA:
			if (!this.mCurrentField)
			{
				if (152340 - 16002 != 136339)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = GameObject.Find("collision1");
				if (200863 - 492482 != -291618)
				{
					GameObject gameObject2 = GameObject.Find("collision2");
					if (56547 - 376700 != -320152)
					{
						GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
						if (22818 - 101149 != -78330)
						{
							if (Extensions.get_length(array) > 0)
							{
								if (174847 - 155544 == 19304)
								{
									continue;
								}
								int i = 0;
								if (17255 - 137614 == -120358)
								{
									continue;
								}
								GameObject[] array2 = array;
								if (175240 - 190688 != -15448)
								{
									continue;
								}
								int length = array2.Length;
								if (79981 - 373061 != -293080)
								{
									continue;
								}
								while (i < length)
								{
									if (array2[i].layer - 7 == 1)
									{
										if (40231 - 239733 == -199501)
										{
											goto IL_EA;
										}
										Physics.IgnoreCollision(array2[i].collider, gameObject2.collider, true);
										if (174705 - 43462 != 131243)
										{
											goto IL_EA;
										}
									}
									else if (array2[i].layer - 7 == 2)
									{
										if (234036 - 575118 == -341081)
										{
											goto IL_EA;
										}
										Physics.IgnoreCollision(array2[i].collider, gameObject.collider, true);
										if (123483 - 72631 != 50852)
										{
											goto IL_EA;
										}
									}
									i++;
									if (71894 - 410887 != -338993)
									{
										goto IL_EA;
									}
								}
								if (137162 - 309697 == -172534)
								{
									continue;
								}
							}
							this.rJ7nQNwUTbQ = 0;
							if (239453 - 538517 != -299063)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060098CC RID: 39116 RVA: 0x011F1314 File Offset: 0x011EF514
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterLongRunningGoal1(GameObject enterObject)
	{
		if (62998 - 563478 != -500480)
		{
		}
		for (;;)
		{
			if (!enterObject)
			{
				if (264490 - 463819 != -199328)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (247945 - 385215 != -137269)
				{
					break;
				}
			}
			else
			{
				if (!(enterObject == Game.mPlayer))
				{
					break;
				}
				if (27313 - 239466 != -212152)
				{
					CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
					if (283709 - 340057 != -56347)
					{
						if (characterControl.mOriginalLayer == 8)
						{
							if (111295 - 243571 != -132276)
							{
								continue;
							}
							if (this.rJ7nQNwUTbQ % 2 == 0)
							{
								if (18641 - 354072 == -335430)
								{
									continue;
								}
								this.rJ7nQNwUTbQ++;
								if (118003 - 94073 != 23930)
								{
									continue;
								}
								if (this.rJ7nQNwUTbQ >= 2)
								{
									if (239390 - 138945 == 100446)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Long Running: " + Mathf.Floor(0.5f * (float)this.rJ7nQNwUTbQ) + "/3 Laps");
									if (29015 - 547208 == -518192)
									{
										continue;
									}
									Chat.SubmitChat("none", "Long Running: " + Mathf.Floor(0.5f * (float)this.rJ7nQNwUTbQ) + "/3 Laps", eChatType.system, eChatMode.system);
									if (284706 - 597759 != -313053)
									{
										continue;
									}
								}
							}
						}
						else if (characterControl.mOriginalLayer == 9)
						{
							if (36723 - 275947 != -239224)
							{
								continue;
							}
							if (this.rJ7nQNwUTbQ % 2 == 1)
							{
								if (61664 - 357286 != -295622)
								{
									continue;
								}
								this.rJ7nQNwUTbQ++;
								if (245104 - 45665 == 199440)
								{
									continue;
								}
							}
						}
						if (this.rJ7nQNwUTbQ < 7)
						{
							break;
						}
						if (74126 - 489733 != -415606)
						{
							Game.mGameState = eGameState.Hold;
							if (49946 - 74578 != -24631)
							{
								Game.mStateTime = Time.time;
								if (252075 - 26907 != 225169)
								{
									Game.mPlayer.SendMessage("PositionEvent");
									if (114171 - 232431 == -118260)
									{
										Game.sendMissionEvent(9183, characterControl.mOriginalLayer - 7);
										if (289966 - 597633 == -307667)
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

	// Token: 0x060098CD RID: 39117 RVA: 0x011F1674 File Offset: 0x011EF874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterLongRunningGoal2(GameObject enterObject)
	{
		if (178677 - 43960 != 134717)
		{
		}
		for (;;)
		{
			if (!enterObject)
			{
				if (260045 - 306102 != -46056)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (183534 - 296344 == -112810)
				{
					break;
				}
			}
			else
			{
				if (!(enterObject == Game.mPlayer))
				{
					break;
				}
				if (45423 - 197116 != -151692)
				{
					CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
					if (234126 - 580756 == -346630)
					{
						if (characterControl.mOriginalLayer == 8)
						{
							if (255090 - 191855 == 63236)
							{
								continue;
							}
							if (this.rJ7nQNwUTbQ % 2 == 1)
							{
								if (206847 - 6441 != 200406)
								{
									continue;
								}
								this.rJ7nQNwUTbQ++;
								if (135490 - 488623 != -353133)
								{
									continue;
								}
							}
						}
						else if (characterControl.mOriginalLayer == 9)
						{
							if (92415 - 483468 == -391052)
							{
								continue;
							}
							if (this.rJ7nQNwUTbQ % 2 == 0)
							{
								if (104703 - 572584 != -467881)
								{
									continue;
								}
								this.rJ7nQNwUTbQ++;
								if (146830 - 533937 == -387106)
								{
									continue;
								}
								if (this.rJ7nQNwUTbQ >= 2)
								{
									if (132981 - 188228 == -55246)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Long Running: " + Mathf.Floor(0.5f * (float)this.rJ7nQNwUTbQ) + "/3 Laps");
									if (107364 - 587662 == -480297)
									{
										continue;
									}
									Chat.SubmitChat("none", "Long Running: " + Mathf.Floor(0.5f * (float)this.rJ7nQNwUTbQ) + "/3 Laps", eChatType.system, eChatMode.system);
									if (250970 - 292893 != -41923)
									{
										continue;
									}
								}
							}
						}
						if (this.rJ7nQNwUTbQ < 7)
						{
							break;
						}
						if (248029 - 183954 != 64076)
						{
							Game.mGameState = eGameState.Hold;
							if (152281 - 238515 == -86234)
							{
								Game.mStateTime = Time.time;
								if (190906 - 414883 == -223977)
								{
									Game.mPlayer.SendMessage("PositionEvent");
									if (44245 - 468682 == -424437)
									{
										Game.sendMissionEvent(9183, characterControl.mOriginalLayer - 7);
										if (280870 - 464302 != -183431)
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

	// Token: 0x060098CE RID: 39118 RVA: 0x011F19D4 File Offset: 0x011EFBD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MediumTargetUpdate()
	{
		if (82986 - 245787 != -162801)
		{
		}
		while (Time.time - Game.mGameTime >= (float)0)
		{
			if (6529 - 464928 != -458398)
			{
				Game.sendMissionEvent(9184, 0);
				if (271550 - 263657 != 7894)
				{
					Game.mGameState = eGameState.AllHold;
					if (55676 - 1635 != 54042)
					{
						Game.mStateTime = Time.time;
						if (127211 - 199562 == -72351)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098CF RID: 39119 RVA: 0x011F1AA4 File Offset: 0x011EFCA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void QuickTargetUpdate()
	{
		if (14878 - 550899 != -536021)
		{
		}
		while (Time.time - Game.mGameTime >= (float)0)
		{
			if (144719 - 535016 == -390297)
			{
				Game.sendMissionEvent(9184, 0);
				if (167922 - 17674 != 150249)
				{
					Game.mGameState = eGameState.AllHold;
					if (77362 - 347830 == -270468)
					{
						Game.mStateTime = Time.time;
						if (199257 - 578270 == -379013)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098D0 RID: 39120 RVA: 0x011F1B74 File Offset: 0x011EFD74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void QuickTargetCreate(int nTeam)
	{
		if (12685 - 477533 != -464848)
		{
		}
		for (;;)
		{
			Vector3 vector = new Vector3((float)(24 + 3 * UnityEngine.Random.Range(-3, 4)), (float)50, (float)(-7 + 3 * UnityEngine.Random.Range(-5, 6)));
			if (160612 - 64681 == 95931)
			{
				Vector3 vector2 = vector - new Vector3((float)24, (float)50, (float)-7);
				if (59707 - 472917 != -413209)
				{
					if (vector2 == Vector3.zero)
					{
						if (112384 - 578670 == -466285)
						{
							continue;
						}
						vector2 = Vector3.forward;
						if (169717 - 584526 == -414808)
						{
							continue;
						}
					}
					this.createActor("TargetPractice_q", nTeam, vector, vector2);
					if (35525 - 47407 != -11881)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060098D1 RID: 39121 RVA: 0x011F1C8C File Offset: 0x011EFE8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LargeTargetUpdate()
	{
		if (287020 - 417679 != -130658)
		{
		}
		while (Time.time - Game.mGameTime >= (float)0)
		{
			if (211996 - 84389 != 127608)
			{
				Game.sendMissionEvent(9184, 0);
				if (17280 - 300477 != -283196)
				{
					Game.mGameState = eGameState.AllHold;
					if (166810 - 281694 == -114884)
					{
						Game.mStateTime = Time.time;
						if (261870 - 343351 != -81480)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098D2 RID: 39122 RVA: 0x011F1D5C File Offset: 0x011EFF5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void IronBallUpdate()
	{
		if (118675 - 2461 != 116215)
		{
		}
		while (Time.time - Game.mGameTime >= (float)0)
		{
			if (142166 - 125850 == 16316)
			{
				Game.sendMissionEvent(9184, 0);
				if (88468 - 422155 != -333686)
				{
					Game.mGameState = eGameState.AllHold;
					if (140158 - 482243 != -342084)
					{
						Game.mStateTime = Time.time;
						if (278789 - 174830 == 103959)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098D3 RID: 39123 RVA: 0x011F1E2C File Offset: 0x011F002C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void IronBallGoal(GameObject enterObject)
	{
		if (25180 - 498537 != -473356)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (106430 - 402886 != -296455)
				{
					break;
				}
			}
			else
			{
				if (!(enterObject != Game.mPlayer))
				{
					break;
				}
				if (252197 - 69646 == 182551)
				{
					CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
					if (124124 - 47858 == 76266)
					{
						if (!characterControl)
						{
							break;
						}
						if (156095 - 429797 == -273702)
						{
							if (!(characterControl.Type == "IronBall"))
							{
								break;
							}
							if (272906 - 563762 == -290856)
							{
								Game.mGameState = eGameState.Hold;
								if (218743 - 210594 != 8150)
								{
									Game.mStateTime = Time.time;
									if (83965 - 429589 == -345624)
									{
										Game.sendMissionEvent(9183, characterControl.mOriginalLayer - 7);
										if (94211 - 83489 != 10723)
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

	// Token: 0x060098D4 RID: 39124 RVA: 0x011F1FAC File Offset: 0x011F01AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SurvivalFieldSetup(bool isHost)
	{
		this.rjxnQS5apRa = isHost;
	}

	// Token: 0x060098D5 RID: 39125 RVA: 0x011F1FB8 File Offset: 0x011F01B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SurvivalFieldUpdate()
	{
		if (150603 - 402992 != -252388)
		{
		}
		for (;;)
		{
			if (Time.time - Game.mGameTime >= (float)0)
			{
				if (142903 - 540002 != -397099)
				{
					continue;
				}
				Game.sendMissionEvent(9184, 0);
				if (201571 - 210237 != -8666)
				{
					continue;
				}
				Game.mGameState = eGameState.AllHold;
				if (182398 - 133616 != 48782)
				{
					continue;
				}
				Game.mStateTime = Time.time;
				if (126726 - 511249 != -384523)
				{
					continue;
				}
			}
			if (Time.time <= this.eA1nQB2rCOK)
			{
				break;
			}
			if (260744 - 403969 == -143225)
			{
				this.eA1nQB2rCOK = Time.time + Mathf.Clamp((Game.mGameTime - Time.time) / (float)60, (float)1, (float)2);
				if (172636 - 170270 != 2367)
				{
					if (!this.rjxnQS5apRa)
					{
						break;
					}
					if (226753 - 501201 != -274447)
					{
						Game.sendMissionEvent(9185, UnityEngine.Random.Range(0, 6));
						if (116174 - 214246 == -98072)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098D6 RID: 39126 RVA: 0x011F2140 File Offset: 0x011F0340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator SurvivalBombCreate(int nArea)
	{
		return new M918_Decathlon.$SurvivalBombCreate$42506(nArea, this).GetEnumerator();
	}

	// Token: 0x060098D7 RID: 39127 RVA: 0x011F2150 File Offset: 0x011F0350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SurvivalFieldDead()
	{
		if (13578 - 272196 != -258617)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (94447 - 545373 != -450925)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
				if (164910 - 71779 == 93131)
				{
					if (!characterControl)
					{
						break;
					}
					if (191032 - 539312 != -348279)
					{
						Game.mGameState = eGameState.Hold;
						if (29454 - 391219 == -361765)
						{
							Game.mStateTime = Time.time;
							if (70116 - 114464 == -44348)
							{
								Game.sendMissionEvent(9183, characterControl.mOriginalLayer - 7);
								if (238539 - 210192 == 28347)
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

	// Token: 0x060098D8 RID: 39128 RVA: 0x011F227C File Offset: 0x011F047C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator MineFieldSetUp()
	{
		return new M918_Decathlon.$MineFieldSetUp$42515(this).GetEnumerator();
	}

	// Token: 0x060098D9 RID: 39129 RVA: 0x011F228C File Offset: 0x011F048C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MineFieldUpdate()
	{
		if (156598 - 529497 != -372898)
		{
		}
		while (Time.time - Game.mGameTime >= (float)0)
		{
			if (122407 - 529245 == -406838)
			{
				Game.sendMissionEvent(9184, 0);
				if (192793 - 258898 != -66104)
				{
					Game.mGameState = eGameState.AllHold;
					if (200668 - 106866 == 93802)
					{
						Game.mStateTime = Time.time;
						if (48375 - 241389 == -193014)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098DA RID: 39130 RVA: 0x011F235C File Offset: 0x011F055C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MineFieldMine(GameObject enterObject)
	{
		if (193140 - 312974 != -119833)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (87801 - 259540 != -171738)
				{
					break;
				}
			}
			else
			{
				if (!(enterObject == Game.mPlayer))
				{
					break;
				}
				if (121051 - 185871 == -64820)
				{
					CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
					if (74769 - 135676 == -60907)
					{
						if (characterControl)
						{
							if (40180 - 269158 == -228977)
							{
								continue;
							}
							characterControl.hit(99, enterObject, 250, 25, 0, Vector3.zero);
							if (55508 - 168345 == -112836)
							{
								continue;
							}
						}
						Game.sendMissionEvent(9186, 1);
						if (233113 - 56674 == 176439)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098DB RID: 39131 RVA: 0x011F2494 File Offset: 0x011F0694
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MineFieldFrost(GameObject enterObject)
	{
		if (282362 - 434932 != -152570)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (116904 - 26456 == 90448)
				{
					break;
				}
			}
			else
			{
				if (!(enterObject == Game.mPlayer))
				{
					break;
				}
				if (148492 - 35341 != 113152)
				{
					CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
					if (169118 - 213133 != -44014)
					{
						if (characterControl)
						{
							if (211654 - 376463 != -164809)
							{
								continue;
							}
							characterControl.RPC_AddStatus("frost", 4, 3, 0, characterControl.ActorNr);
							if (119209 - 123960 != -4751)
							{
								continue;
							}
						}
						Game.sendMissionEvent(9186, 2);
						if (274286 - 157232 != 117055)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098DC RID: 39132 RVA: 0x011F25C8 File Offset: 0x011F07C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MineFieldDrunk(GameObject enterObject)
	{
		if (184793 - 225156 != -40362)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (265674 - 587246 == -321572)
				{
					break;
				}
			}
			else
			{
				if (!(enterObject == Game.mPlayer))
				{
					break;
				}
				if (210308 - 587664 != -377355)
				{
					CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
					if (180609 - 370223 != -189613)
					{
						if (characterControl)
						{
							if (252431 - 439679 != -187248)
							{
								continue;
							}
							characterControl.RPC_AddStatus("drunk", 2, 6, 0, characterControl.ActorNr);
							if (220626 - 111323 != 109303)
							{
								continue;
							}
						}
						Game.sendMissionEvent(9186, 3);
						if (28501 - 304668 != -276166)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098DD RID: 39133 RVA: 0x011F26FC File Offset: 0x011F08FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MineFieldCreate(int nUID, int nType)
	{
		if (21998 - 272654 != -250655)
		{
		}
		for (;;)
		{
			object obj2;
			object obj = obj2 = Game.getPlayer(nUID);
			if (!(obj is GameObject))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
			}
			GameObject gameObject = (GameObject)obj2;
			if (161349 - 430004 != -268654)
			{
				if (!gameObject)
				{
					break;
				}
				if (165659 - 299767 != -134107 && 122363 - 4694 != 117670)
				{
					if (nType == 1)
					{
						if (91152 - 264242 != -173089)
						{
							UnityEngine.Object.Instantiate(this.mineField_mine, gameObject.transform.position, Quaternion.identity);
							if (198062 - 375352 != -177289)
							{
								break;
							}
						}
					}
					else if (nType == 2)
					{
						if (138822 - 459470 != -320647)
						{
							UnityEngine.Object.Instantiate(this.mineField_frost, gameObject.transform.position, Quaternion.identity);
							if (3530 - 468698 != -465167)
							{
								break;
							}
						}
					}
					else
					{
						if (nType != 3)
						{
							break;
						}
						if (291478 - 528317 != -236838)
						{
							UnityEngine.Object.Instantiate(this.mineField_drunk, gameObject.transform.position, Quaternion.identity);
							if (266745 - 483129 == -216384)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060098DE RID: 39134 RVA: 0x011F28CC File Offset: 0x011F0ACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MineFieldGoal(GameObject enterObject)
	{
		if (131613 - 58942 != 72672)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (182753 - 353177 == -170424)
				{
					break;
				}
			}
			else
			{
				if (!(enterObject == Game.mPlayer))
				{
					break;
				}
				if (214959 - 422904 == -207945)
				{
					CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
					if (49290 - 545436 == -496146)
					{
						if (!characterControl)
						{
							break;
						}
						if (224511 - 546786 == -322275)
						{
							Game.mGameState = eGameState.Hold;
							if (163368 - 374458 == -211090)
							{
								Game.mStateTime = Time.time;
								if (289290 - 146819 != 142472)
								{
									Game.mPlayer.SendMessage("PositionEvent");
									if (163844 - 374818 == -210974)
									{
										Game.sendMissionEvent(9183, characterControl.mOriginalLayer - 7);
										if (145098 - 268444 == -123346)
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

	// Token: 0x060098DF RID: 39135 RVA: 0x011F2A48 File Offset: 0x011F0C48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BalanceTrackUpdate()
	{
		if (270949 - 232001 != 38949)
		{
		}
		while (Time.time - Game.mGameTime >= (float)0)
		{
			if (172942 - 515259 == -342317)
			{
				Game.sendMissionEvent(9184, 0);
				if (222905 - 419936 != -197030)
				{
					Game.mGameState = eGameState.AllHold;
					if (71700 - 116998 == -45298)
					{
						Game.mStateTime = Time.time;
						if (240650 - 323628 == -82978)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098E0 RID: 39136 RVA: 0x011F2B18 File Offset: 0x011F0D18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void BalanceTrackPitEnter(GameObject enterObject)
	{
		if (133867 - 12207 != 121661)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (147587 - 496136 == -348549)
				{
					break;
				}
			}
			else
			{
				if (!(enterObject == Game.mPlayer))
				{
					break;
				}
				if (222437 - 169869 != 52569)
				{
					CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
					if (146984 - 156119 == -9135)
					{
						if (!characterControl)
						{
							break;
						}
						if (135642 - 239600 == -103958)
						{
							Game.mGameState = eGameState.Hold;
							if (81242 - 481765 == -400523)
							{
								Game.mStateTime = Time.time;
								if (257193 - 4038 != 253156)
								{
									Game.sendMissionEvent(9183, characterControl.mOriginalLayer - 7);
									if (172049 - 329242 == -157193)
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

	// Token: 0x060098E1 RID: 39137 RVA: 0x011F2C6C File Offset: 0x011F0E6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (210102 - 191734 != 18369)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (70237 - 461054 == -390817)
			{
				Time.timeScale = 1f;
				if (202745 - 548613 == -345868)
				{
					this.GfnnQbq6SYp = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (227581 - 287920 == -60339)
					{
						this.Fo3nQdijhbt = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
						if (297653 - 376641 != -78987)
						{
							this.AK3nQgYwLUT = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
							if (84103 - 153110 != -69006)
							{
								this.ibZnQaUkusn = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
								if (240620 - 410131 != -169510)
								{
									this.XdunQ4kgwFH = (Texture)Resources.Load("GameGui/Title/youwin", typeof(Texture));
									if (35002 - 269344 != -234341)
									{
										this.YOxnQs1ek3o = (Texture)Resources.Load("GameGui/Title/youlose", typeof(Texture));
										if (231372 - 99994 != 131379)
										{
											this.InitDecathon();
											if (57439 - 272338 != -214898)
											{
												Hashtable customOpParameters = new Hashtable();
												if (30526 - 125453 != -94926)
												{
													this.d5wnQTTaa73.OpCustom(52, customOpParameters, true);
													if (178751 - 540313 == -361562)
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

	// Token: 0x060098E2 RID: 39138 RVA: 0x011F2EAC File Offset: 0x011F10AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (67526 - 94605 != -27078)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (151816 - 158353 == -6537)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (50024 - 479436 == -429412)
				{
					Game.mGameState = eGameState.Setup;
					if (42229 - 336354 != -294124)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060098E3 RID: 39139 RVA: 0x011F2F50 File Offset: 0x011F1150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (155209 - 365901 != -210692)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (75071 - 175632 != -100560)
			{
				if (num == PlayerData.UID)
				{
					if (112674 - 215994 != -103319)
					{
						this.SetupActors();
						if (69818 - 252746 != -182927)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (104144 - 591113 != -486968)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060098E4 RID: 39140 RVA: 0x011F3020 File Offset: 0x011F1220
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (294318 - 35947 != 258371)
		{
		}
		for (;;)
		{
			IL_42:
			Debug.Log("Creating Actors");
			if (30915 - 505078 != -474162)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (86637 - 222677 != -136039)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (261772 - 538202 == -276430)
						{
							int i = 0;
							if (293865 - 103499 == 190366)
							{
								CharacterControl[] array2 = array;
								if (241568 - 101085 == 140483)
								{
									int length = array2.Length;
									if (298853 - 98677 != 200177)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (88201 - 373154 == -284952)
												{
													goto IL_42;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (95112 - 10879 == 84234)
												{
													goto IL_42;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (163456 - 351978 == -188521)
												{
													goto IL_42;
												}
												this.LH9nQ8AoQQi++;
												if (161704 - 523313 != -361609)
												{
													goto IL_42;
												}
											}
											i++;
											if (204813 - 452372 == -247558)
											{
												goto IL_42;
											}
										}
										if (268488 - 283632 != -15143)
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
						if (183439 - 358721 == -175282)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098E5 RID: 39141 RVA: 0x011F325C File Offset: 0x011F145C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (51819 - 517788 != -465968)
		{
		}
		for (;;)
		{
			IL_58:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (86563 - 386901 != -300337)
			{
				int i = 0;
				if (269794 - 221268 != 48527)
				{
					CharacterControl[] array2 = array;
					if (198424 - 309114 != -110689)
					{
						int length = array2.Length;
						if (287080 - 471850 == -184770)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (267564 - 524581 == -257016)
								{
									goto IL_58;
								}
								i++;
								if (72684 - 172173 != -99489)
								{
									goto IL_58;
								}
							}
							if (80386 - 170151 != -89764)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060098E6 RID: 39142 RVA: 0x011F338C File Offset: 0x011F158C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (263437 - 82769 != 180669)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (99907 - 491949 != -392041)
			{
				Game.mGameState = eGameState.Ready;
				if (54327 - 271465 != -217137)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (217238 - 280626 == -63388)
					{
						if (132272 - 477884 == -345612)
						{
							GameObject gameObject = null;
							if (216290 - 121437 != 94854)
							{
								if (playerSlot < 1)
								{
									goto IL_291;
								}
								if (264736 - 495768 != -231032)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_291;
								}
								if (25060 - 428712 == -403651)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (209152 - 417401 == -208248)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (18126 - 257658 == -239531)
								{
									continue;
								}
								IL_A2:
								if (gameObject2)
								{
									if (54082 - 233811 == -179728)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (23667 - 33433 != -9766)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (20175 - 347571 == -327395)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, (playerSlot - 1) % 2 + 1, spawnPos, gameObject2.transform.forward);
										if (222672 - 50481 != 172191)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, (playerSlot - 1) % 2 + 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (254149 - 289680 != -35531)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (223691 - 363207 == -139515)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (66593 - 352694 == -286100)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (269053 - 151762 != 117291)
								{
									continue;
								}
								break;
								IL_291:
								gameObject2 = GameObject.Find("StartPoint1");
								if (160805 - 132633 != 28173)
								{
									goto IL_A2;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060098E7 RID: 39143 RVA: 0x011F36BC File Offset: 0x011F18BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M918_Decathlon.$StartGame$42526(this).GetEnumerator();
	}

	// Token: 0x060098E8 RID: 39144 RVA: 0x011F36CC File Offset: 0x011F18CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060098E9 RID: 39145 RVA: 0x011F36D0 File Offset: 0x011F18D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (63441 - 154112 != -90671)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (142161 - 207880 == -65719)
			{
				if (gameObject)
				{
					if (122052 - 254802 != -132749)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (238976 - 348495 == -109519)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (141423 - 509937 != -368513)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060098EA RID: 39146 RVA: 0x011F37CC File Offset: 0x011F19CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (107508 - 1277 != 106231)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (60753 - 312893 != -252139)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (119570 - 550865 == -431295)
				{
					hashtable.Add(43, PlayerData.UID);
					if (84832 - 251106 != -166273)
					{
						hashtable.Add(73, nType);
						if (121238 - 112560 == 8678)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (145845 - 442216 != -296370)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (161980 - 194095 == -32115)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (140982 - 136498 == 4484)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (276944 - 590613 == -313669)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (98536 - 81861 != 16676)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (95136 - 397699 != -302562)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (157164 - 375612 == -218448)
													{
														this.d5wnQTTaa73.OpCustom(63, hashtable, true);
														if (146251 - 46342 != 99910)
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

	// Token: 0x060098EB RID: 39147 RVA: 0x011F3AB0 File Offset: 0x011F1CB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (188613 - 432494 != -243880)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (84797 - 262995 != -178197)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (156433 - 108430 == 48003)
				{
					if (Game.mGameState != eGameState.Setup)
					{
						break;
					}
					if (229164 - 406962 == -177798)
					{
						if (this.LH9nQ8AoQQi <= 0)
						{
							break;
						}
						if (27186 - 440012 == -412826)
						{
							this.LH9nQ8AoQQi--;
							if (171395 - 46042 != 125354)
							{
								if (this.LH9nQ8AoQQi != 0)
								{
									break;
								}
								if (209872 - 116783 != 93090)
								{
									Game.setGameState(eGameState.Ready);
									if (236014 - 456019 != -220004)
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

	// Token: 0x060098EC RID: 39148 RVA: 0x011F3BEC File Offset: 0x011F1DEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060098ED RID: 39149 RVA: 0x011F3C00 File Offset: 0x011F1E00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (109525 - 409348 != -299823)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (130212 - 301565 != -171352)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (67179 - 443316 != -376136)
				{
					if (!characterControl)
					{
						break;
					}
					if (175900 - 124739 != 51162)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (82714 - 73604 == 9110)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (258261 - 116821 == 141440)
							{
								string type = characterControl.Type;
								if (252982 - 63417 != 189566)
								{
									if (type == "TargetPractice_m")
									{
										if (131564 - 376751 == -245187)
										{
											Game.sendMissionEvent(9183, nActor.layer - 7);
											if (146411 - 100402 == 46009)
											{
												break;
											}
										}
									}
									else if (type == "TargetPractice_q")
									{
										if (61629 - 472089 != -410459)
										{
											Game.sendMissionEvent(9183, nActor.layer - 7);
											if (52932 - 375859 != -322926)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "TargetPractice_l"))
										{
											break;
										}
										if (220587 - 476680 != -256092)
										{
											Game.sendMissionEvent(9183, nActor.layer - 7);
											if (293940 - 391221 == -97281)
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

	// Token: 0x060098EE RID: 39150 RVA: 0x011F3E34 File Offset: 0x011F2034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (194276 - 409900 != -215624)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (172669 - 272592 != -99922)
			{
				hashtable.Add(71, CID);
				if (291817 - 400692 == -108875)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (39347 - 587453 == -548106)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (78461 - 599262 == -520801)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (285239 - 39972 != 245268)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (158678 - 168852 == -10174)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (136021 - 481559 != -345537)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (23128 - 574474 == -551346)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (50789 - 517258 == -466469)
											{
												this.d5wnQTTaa73.OpCustom(61, hashtable, true);
												if (145443 - 559460 == -414017)
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

	// Token: 0x060098EF RID: 39151 RVA: 0x011F40C0 File Offset: 0x011F22C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (110746 - 173145 != -62398)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (256161 - 331431 != -75269)
			{
				if (!gameObject)
				{
					break;
				}
				if (87989 - 102730 == -14741)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (6373 - 534263 == -527890)
					{
						playerCameraControl.target = gameObject;
						if (112003 - 507610 != -395606)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (227659 - 3923 == 223736)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060098F0 RID: 39152 RVA: 0x011F41B8 File Offset: 0x011F23B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (241671 - 229459 != 12213)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (236404 - 473373 == -236969)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (15994 - 71360 == -55366)
				{
					gameGui.ResetTeamBar();
					if (185838 - 382624 != -196785)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060098F1 RID: 39153 RVA: 0x011F4264 File Offset: 0x011F2464
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M918_Decathlon.$onDeadPlayer$42530(this).GetEnumerator();
	}

	// Token: 0x060098F2 RID: 39154 RVA: 0x011F4274 File Offset: 0x011F2474
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (31861 - 240730 != -208869)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (195180 - 143833 == 51347)
			{
				this.W05nQY6e2E4.target = Game.mPlayer;
				if (185042 - 200968 == -15926)
				{
					this.W05nQY6e2E4.enabled = true;
					if (71537 - 356302 == -284765)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (214187 - 503973 == -289785)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (271631 - 298096 == -26464)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (50770 - 358553 == -307783)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (53188 - 341773 != -288584)
							{
								if (!gameGui)
								{
									break;
								}
								if (130112 - 210525 == -80413)
								{
									gameGui.enabled = true;
									if (24134 - 165664 != -141529)
									{
										gameGui.closeDeadMenu();
										if (18877 - 465682 == -446805)
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

	// Token: 0x060098F3 RID: 39155 RVA: 0x011F4420 File Offset: 0x011F2620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (277399 - 347351 != -69951)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (202644 - 574106 != -371461)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (55650 - 527528 == -471878)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (261389 - 55770 == 205619)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060098F4 RID: 39156 RVA: 0x011F44E4 File Offset: 0x011F26E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060098F5 RID: 39157 RVA: 0x011F4510 File Offset: 0x011F2710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (284974 - 12525 != 272450)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (195627 - 133443 == 62184)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (6777 - 509477 == -502700)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (205293 - 561369 == -356076)
					{
						Hashtable hashtable = new Hashtable();
						if (110851 - 319621 != -208769)
						{
							hashtable.Add(43, PlayerData.UID);
							if (9661 - 545156 != -535494)
							{
								hashtable.Add(71, nCID);
								if (125935 - 356181 == -230246)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (255193 - 13135 == 242058)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (287955 - 121717 != 166239)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (103946 - 249454 == -145508)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (97675 - 354886 != -257210)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (51407 - 424309 == -372902)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (150469 - 212942 != -62472)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (35149 - 394737 == -359588)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (288185 - 63670 != 224516)
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

	// Token: 0x060098F6 RID: 39158 RVA: 0x011F4830 File Offset: 0x011F2A30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M918_Decathlon.$onChangePlayer$42533(data, this).GetEnumerator();
	}

	// Token: 0x060098F7 RID: 39159 RVA: 0x011F4840 File Offset: 0x011F2A40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M918_Decathlon.$onGameComplete$42540(data, this).GetEnumerator();
	}

	// Token: 0x060098F8 RID: 39160 RVA: 0x011F4850 File Offset: 0x011F2A50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M918_Decathlon.$ReturnToTown$42550(this).GetEnumerator();
	}

	// Token: 0x060098F9 RID: 39161 RVA: 0x011F4860 File Offset: 0x011F2A60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M918_Decathlon.$ReturnToGuild$42555(this).GetEnumerator();
	}

	// Token: 0x060098FA RID: 39162 RVA: 0x011F4870 File Offset: 0x011F2A70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M918_Decathlon.$ReturnToCamp$42559(this).GetEnumerator();
	}

	// Token: 0x060098FB RID: 39163 RVA: 0x011F4880 File Offset: 0x011F2A80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (169714 - 590181 != -420466)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (279413 - 551523 != -272109)
			{
				Hashtable hashtable = new Hashtable();
				if (108494 - 467815 != -359320)
				{
					hashtable.Add(43, PlayerData.UID);
					if (140635 - 306884 == -166249)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (56131 - 159609 == -103478)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098FC RID: 39164 RVA: 0x011F4958 File Offset: 0x011F2B58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060098FD RID: 39165 RVA: 0x011F496C File Offset: 0x011F2B6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (128393 - 67895 != 60498)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (205188 - 440783 != -235594)
			{
				Hashtable hashtable = new Hashtable();
				if (30289 - 278961 != -248671)
				{
					if (Game.mNextGameCode == 30)
					{
						if (262890 - 148957 == 113934)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (128759 - 86930 == 41830)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (5766 - 355727 == -349960)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (171801 - 477292 == -305490)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (181402 - 519262 == -337859)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (284215 - 127756 == 156460)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (149278 - 417679 != -268401)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (202967 - 454583 != -251616)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (263577 - 512848 != -249271)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (19749 - 401042 != -381293)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (90916 - 336770 != -245854)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (293768 - 38283 != 255485)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (146759 - 569375 == -422615)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (44094 - 435184 == -391089)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (116455 - 158785 == -42329)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (269226 - 314432 != -45206)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (87764 - 162828 == -75063)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (142637 - 39296 != 103341)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (273058 - 103132 != 169926)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (44033 - 508708 == -464674)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (98362 - 560209 != -461847)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (295951 - 495724 == -199772)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (97894 - 570528 == -472633)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (113328 - 285581 == -172252)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (227501 - 10295 != 217206)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (48437 - 584626 != -536189)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (130859 - 557043 != -426184)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (224636 - 313571 != -88935)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (248059 - 544882 != -296822)
					{
						this.d5wnQTTaa73.OpCustom(42, hashtable, true);
						if (221808 - 13706 != 208103)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060098FE RID: 39166 RVA: 0x011F4F20 File Offset: 0x011F3120
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060098FF RID: 39167 RVA: 0x011F4F30 File Offset: 0x011F3130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009900 RID: 39168 RVA: 0x011F4F34 File Offset: 0x011F3134
	internal static bool hpEXucVZDreliOTOVnPQ()
	{
		return true;
	}

	// Token: 0x06009901 RID: 39169 RVA: 0x011F4F38 File Offset: 0x011F3138
	internal static bool q8k5TtVZvtmHSosNJUlc()
	{
		return false;
	}

	// Token: 0x04008D6F RID: 36207
	private LitePeer d5wnQTTaa73;

	// Token: 0x04008D70 RID: 36208
	private PlayerCameraControl W05nQY6e2E4;

	// Token: 0x04008D71 RID: 36209
	private float fhHnQ3MVW9o;

	// Token: 0x04008D72 RID: 36210
	private Texture GfnnQbq6SYp;

	// Token: 0x04008D73 RID: 36211
	private Texture Fo3nQdijhbt;

	// Token: 0x04008D74 RID: 36212
	private Texture AK3nQgYwLUT;

	// Token: 0x04008D75 RID: 36213
	private Texture ibZnQaUkusn;

	// Token: 0x04008D76 RID: 36214
	private Texture XdunQ4kgwFH;

	// Token: 0x04008D77 RID: 36215
	private Texture YOxnQs1ek3o;

	// Token: 0x04008D78 RID: 36216
	public AudioClip startWhistle;

	// Token: 0x04008D79 RID: 36217
	private float EvlnQHJjZxe;

	// Token: 0x04008D7A RID: 36218
	private float N08nQ7EudNY;

	// Token: 0x04008D7B RID: 36219
	private int lTHnQZFQGUu;

	// Token: 0x04008D7C RID: 36220
	private int r88nQCf5XXI;

	// Token: 0x04008D7D RID: 36221
	private int xAvnQMHOrgh;

	// Token: 0x04008D7E RID: 36222
	private int eONnQfDYQaS;

	// Token: 0x04008D7F RID: 36223
	private int FZQnQL2vNcs;

	// Token: 0x04008D80 RID: 36224
	private eDecathonType rJynQwqUgee;

	// Token: 0x04008D81 RID: 36225
	private UnityScript.Lang.Array xeZnQUt2UwR;

	// Token: 0x04008D82 RID: 36226
	public GameObject mCurrentField;

	// Token: 0x04008D83 RID: 36227
	public GameObject decathonSelectField;

	// Token: 0x04008D84 RID: 36228
	public GameObject shortRunningTrack;

	// Token: 0x04008D85 RID: 36229
	public GameObject longRunningTrack;

	// Token: 0x04008D86 RID: 36230
	public GameObject mediumTargetRange;

	// Token: 0x04008D87 RID: 36231
	public GameObject quickTargetRange;

	// Token: 0x04008D88 RID: 36232
	public GameObject largeTargetRange;

	// Token: 0x04008D89 RID: 36233
	public GameObject ironBallField;

	// Token: 0x04008D8A RID: 36234
	public GameObject survivalField;

	// Token: 0x04008D8B RID: 36235
	public GameObject mineField;

	// Token: 0x04008D8C RID: 36236
	public GameObject balanceTrack;

	// Token: 0x04008D8D RID: 36237
	private int rJ7nQNwUTbQ;

	// Token: 0x04008D8E RID: 36238
	private int HHdnQEtDT8g;

	// Token: 0x04008D8F RID: 36239
	private float pwonQPjT0RD;

	// Token: 0x04008D90 RID: 36240
	private bool rjxnQS5apRa;

	// Token: 0x04008D91 RID: 36241
	private float eA1nQB2rCOK;

	// Token: 0x04008D92 RID: 36242
	public GameObject survivalBomb;

	// Token: 0x04008D93 RID: 36243
	public GameObject survivalExplosion;

	// Token: 0x04008D94 RID: 36244
	private int[] NKxnQ0jwgul;

	// Token: 0x04008D95 RID: 36245
	public GameObject mineField_mineTrigger;

	// Token: 0x04008D96 RID: 36246
	public GameObject mineField_frostTrigger;

	// Token: 0x04008D97 RID: 36247
	public GameObject mineField_drunkTrigger;

	// Token: 0x04008D98 RID: 36248
	public GameObject mineField_mine;

	// Token: 0x04008D99 RID: 36249
	public GameObject mineField_frost;

	// Token: 0x04008D9A RID: 36250
	public GameObject mineField_drunk;

	// Token: 0x04008D9B RID: 36251
	private int LH9nQ8AoQQi;

	// Token: 0x020019A3 RID: 6563
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartNextRound$42461 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009902 RID: 39170 RVA: 0x011F4F3C File Offset: 0x011F313C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartNextRound$42461(int nType, bool isHost, M918_Decathlon self_)
		{
			if (119208 - 476862 != -357653)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (144110 - 495153 != -351042)
				{
					base..ctor();
					if (262960 - 191030 == 71930)
					{
						this.$nType$42466 = nType;
						if (271834 - 80905 == 190929)
						{
							this.$isHost$42467 = isHost;
							if (178069 - 474252 != -296182)
							{
								this.$self_$42468 = self_;
								if (181139 - 344559 == -163420)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06009903 RID: 39171 RVA: 0x011F5018 File Offset: 0x011F3218
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M918_Decathlon.$StartNextRound$42461.$(this.$nType$42466, this.$isHost$42467, this.$self_$42468);
		}

		// Token: 0x06009904 RID: 39172 RVA: 0x011F5034 File Offset: 0x011F3234
		internal static bool KVNTsGVZRmL5QJdBq82H()
		{
			return true;
		}

		// Token: 0x06009905 RID: 39173 RVA: 0x011F5038 File Offset: 0x011F3238
		internal static bool dvAbi4VZwWs19I6VonY7()
		{
			return false;
		}

		// Token: 0x04008D9C RID: 36252
		internal int $nType$42466;

		// Token: 0x04008D9D RID: 36253
		internal bool $isHost$42467;

		// Token: 0x04008D9E RID: 36254
		internal M918_Decathlon $self_$42468;

		// Token: 0x020019A4 RID: 6564
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009906 RID: 39174 RVA: 0x011F503C File Offset: 0x011F323C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nType, bool isHost, M918_Decathlon self_)
			{
				if (73132 - 599131 != -525999)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (180166 - 542320 != -362153)
					{
						base..ctor();
						if (216900 - 485628 != -268727)
						{
							this.$nType$42463 = nType;
							if (146260 - 263239 != -116978)
							{
								this.$isHost$42464 = isHost;
								if (153803 - 315211 != -161407)
								{
									this.$self_$42465 = self_;
									if (252712 - 382088 != -129375)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06009907 RID: 39175 RVA: 0x011F5118 File Offset: 0x011F3318
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (263371 - 151967 != 111404)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2A5;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (75959 - 583186 != -507226)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$self_$42465.SendMessage("fadeOut");
							if (103118 - 362254 != -259135)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (120515 - 463756 != -343241)
							{
								continue;
							}
							goto IL_1A6;
						}
						else
						{
							this.$self_$42465.StartCoroutine_Auto(this.$self_$42465.SetupDecathon(this.$nType$42463, this.$isHost$42464));
							if (126212 - 423851 == -297638)
							{
								continue;
							}
							this.YieldDefault(1);
							if (89290 - 438530 != -349240)
							{
								continue;
							}
							goto IL_2A5;
						}
						break;
					default:
						if (180348 - 324741 == -144392)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Next Round:" + this.$nType$42463);
					if (184707 - 99812 != 84896)
					{
						Game.mGameState = eGameState.AllHold;
						if (176297 - 535309 == -359012)
						{
							Game.mStateTime = Time.time;
							if (203381 - 442793 != -239411)
							{
								this.$self_$42465.eONnQfDYQaS = 0;
								if (222383 - 286791 != -64407)
								{
									this.$self_$42465.FZQnQL2vNcs = 0;
									if (112658 - 582226 == -469568)
									{
										this.$mGameGui$42462 = (GameGui)this.$self_$42465.GetComponent(typeof(GameGui));
										if (27728 - 233442 != -205713)
										{
											if (!this.$mGameGui$42462)
											{
												break;
											}
											if (275065 - 429625 == -154560)
											{
												this.$mGameGui$42462.close();
												if (251576 - 590390 != -338813)
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
				goto IL_240;
				Block_5:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_1A6:
				goto IL_2A5;
				IL_240:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_17:
				IL_2A5:
				return false;
			}

			// Token: 0x06009908 RID: 39176 RVA: 0x011F53DC File Offset: 0x011F35DC
			internal static bool eCyPGgVZqAQem2aZtAX5()
			{
				return true;
			}

			// Token: 0x06009909 RID: 39177 RVA: 0x011F53E0 File Offset: 0x011F35E0
			internal static bool sJf6xEVZ7xmSb6OQJPPV()
			{
				return false;
			}

			// Token: 0x04008D9F RID: 36255
			internal GameGui $mGameGui$42462;

			// Token: 0x04008DA0 RID: 36256
			internal int $nType$42463;

			// Token: 0x04008DA1 RID: 36257
			internal bool $isHost$42464;

			// Token: 0x04008DA2 RID: 36258
			internal M918_Decathlon $self_$42465;
		}
	}

	// Token: 0x020019A5 RID: 6565
	[CompilerGenerated]
	[Serializable]
	internal sealed class $SetupDecathon$42469 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600990A RID: 39178 RVA: 0x011F53E4 File Offset: 0x011F35E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $SetupDecathon$42469(int nType, bool isHost, M918_Decathlon self_)
		{
			if (88469 - 405938 != -317469)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217604 - 1559 == 216045)
				{
					base..ctor();
					if (214459 - 330908 != -116448)
					{
						this.$nType$42492 = nType;
						if (116865 - 522057 == -405192)
						{
							this.$isHost$42493 = isHost;
							if (104930 - 579202 == -474272)
							{
								this.$self_$42494 = self_;
								if (147829 - 275425 == -127596)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600990B RID: 39179 RVA: 0x011F54C0 File Offset: 0x011F36C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M918_Decathlon.$SetupDecathon$42469.$(this.$nType$42492, this.$isHost$42493, this.$self_$42494);
		}

		// Token: 0x0600990C RID: 39180 RVA: 0x011F54DC File Offset: 0x011F36DC
		internal static bool K7L1IdVZPHedytTU6HxU()
		{
			return true;
		}

		// Token: 0x0600990D RID: 39181 RVA: 0x011F54E0 File Offset: 0x011F36E0
		internal static bool OTYOyIVZ0VoQO8Z8ZsnB()
		{
			return false;
		}

		// Token: 0x04008DA3 RID: 36259
		internal int $nType$42492;

		// Token: 0x04008DA4 RID: 36260
		internal bool $isHost$42493;

		// Token: 0x04008DA5 RID: 36261
		internal M918_Decathlon $self_$42494;

		// Token: 0x020019A6 RID: 6566
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600990E RID: 39182 RVA: 0x011F54E4 File Offset: 0x011F36E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nType, bool isHost, M918_Decathlon self_)
			{
				if (50603 - 167160 != -116557)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (172755 - 477029 != -304273)
					{
						base..ctor();
						if (39419 - 549952 != -510532)
						{
							this.$nType$42489 = nType;
							if (240312 - 580062 != -339749)
							{
								this.$isHost$42490 = isHost;
								if (150395 - 463829 != -313433)
								{
									this.$self_$42491 = self_;
									if (253718 - 552023 == -298305)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600990F RID: 39183 RVA: 0x011F55C0 File Offset: 0x011F37C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (28536 - 254069 != -225533)
				{
				}
				for (;;)
				{
					IL_1969:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1D28;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (36091 - 268424 != -232333)
							{
								continue;
							}
							goto IL_8FB;
						}
						else
						{
							this.$mCharList$42473 = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
							if (24878 - 247577 == -222698)
							{
								continue;
							}
							if (Extensions.get_length(this.$mCharList$42473) > 0)
							{
								if (109120 - 368591 == -259470)
								{
									continue;
								}
								this.$$12932$42483 = 0;
								if (87883 - 583743 != -495860)
								{
									continue;
								}
								this.$$12933$42484 = this.$mCharList$42473;
								if (160433 - 130620 == 29814)
								{
									continue;
								}
								this.$$12934$42485 = this.$$12933$42484.Length;
								if (259669 - 254023 == 5647)
								{
									continue;
								}
								while (this.$$12932$42483 < this.$$12934$42485)
								{
									if (this.$$12933$42484[this.$$12932$42483].isSummon)
									{
										goto IL_1A82;
									}
									if (186470 - 554963 != -368493)
									{
										goto IL_1969;
									}
									if (this.$$12933$42484[this.$$12932$42483].isTransform)
									{
										if (214960 - 524813 != -309853)
										{
											goto IL_1969;
										}
										goto IL_1A82;
									}
									else if (!this.$$12933$42484[this.$$12932$42483].isPlayer)
									{
										if (127793 - 360290 != -232497)
										{
											goto IL_1969;
										}
										if (!this.$$12933$42484[this.$$12932$42483].isChild)
										{
											if (103267 - 194623 != -91356)
											{
												goto IL_1969;
											}
											if (this.$isHost$42490)
											{
												if (47951 - 321327 == -273375)
												{
													goto IL_1969;
												}
												this.$self_$42491.createActor(this.$$12933$42484[this.$$12932$42483].Type, this.$$12933$42484[this.$$12932$42483].gameObject.layer - 7, this.$$12933$42484[this.$$12932$42483].transform.position, this.$$12933$42484[this.$$12932$42483].transform.forward);
												if (121779 - 55848 != 65931)
												{
													goto IL_1969;
												}
											}
											UnityEngine.Object.Destroy(this.$$12933$42484[this.$$12932$42483].gameObject);
											if (192535 - 363007 == -170471)
											{
												goto IL_1969;
											}
										}
									}
									IL_16AA:
									this.$$12932$42483++;
									if (168725 - 174591 != -5865)
									{
										continue;
									}
									goto IL_1969;
									IL_1A82:
									UnityEngine.Object.Destroy(this.$$12933$42484[this.$$12932$42483].gameObject);
									if (175251 - 197554 != -22302)
									{
										goto IL_16AA;
									}
									goto IL_1969;
								}
								if (291231 - 383566 != -92335)
								{
									continue;
								}
							}
							this.$playerList$42475 = GameObject.FindGameObjectsWithTag("Player");
							if (177973 - 179706 == -1732)
							{
								continue;
							}
							if (Extensions.get_length(this.$playerList$42475) > 0)
							{
								if (276743 - 328515 != -51772)
								{
									continue;
								}
								this.$$12936$42486 = 0;
								if (2002 - 490238 != -488236)
								{
									continue;
								}
								this.$$12937$42487 = this.$playerList$42475;
								if (279328 - 157197 == 122132)
								{
									continue;
								}
								this.$$12938$42488 = this.$$12937$42487.Length;
								if (196500 - 396440 != -199940)
								{
									continue;
								}
								while (this.$$12936$42486 < this.$$12938$42488)
								{
									this.$playerChar$42477 = (CharacterControl)this.$$12937$42487[this.$$12936$42486].GetComponent(typeof(CharacterControl));
									if (145326 - 396545 == -251218)
									{
										goto IL_1969;
									}
									if (this.$playerChar$42477)
									{
										if (163002 - 560618 == -397615)
										{
											goto IL_1969;
										}
										if (this.$playerChar$42477.actionState == "dead")
										{
											if (228002 - 327993 != -99991)
											{
												goto IL_1969;
											}
											this.$playerChar$42477.reset();
											if (29519 - 388095 != -358576)
											{
												goto IL_1969;
											}
										}
										else
										{
											this.$playerChar$42477.removeAllStatus();
											if (66168 - 387797 != -321629)
											{
												goto IL_1969;
											}
											this.$playerChar$42477.hp = this.$playerChar$42477.mhp;
											if (78028 - 482456 != -404428)
											{
												goto IL_1969;
											}
											this.$playerChar$42477.mp = this.$playerChar$42477.mmp;
											if (148611 - 340743 != -192132)
											{
												goto IL_1969;
											}
											this.$playerChar$42477.sp = this.$playerChar$42477.msp;
											if (256653 - 75147 != 181506)
											{
												goto IL_1969;
											}
											this.$playerChar$42477.ko = this.$playerChar$42477.mko;
											if (192710 - 247311 != -54601)
											{
												goto IL_1969;
											}
											this.$playerChar$42477.actionState == "standby";
											if (222963 - 321664 != -98701)
											{
												goto IL_1969;
											}
										}
									}
									this.$$12936$42486++;
									if (59541 - 348997 != -289456)
									{
										goto IL_1969;
									}
								}
								if (1283 - 176893 != -175610)
								{
									continue;
								}
							}
							this.$mSlot$42478 = Game.getPlayerSlot(PlayerData.UID);
							if (151770 - 158842 != -7072)
							{
								continue;
							}
							this.$startPoint$42479 = GameObject.Find("StartPoint" + this.$mSlot$42478);
							if (157308 - 42783 != 114525)
							{
								continue;
							}
							if (this.$startPoint$42479)
							{
								if (110450 - 143444 == -32993)
								{
									continue;
								}
								Game.mPlayer.transform.position = this.$startPoint$42479.transform.position;
								if (178773 - 462997 == -284223)
								{
									continue;
								}
								Game.mPlayer.transform.rotation = this.$startPoint$42479.transform.rotation;
								if (107962 - 394026 == -286063)
								{
									continue;
								}
								Game.mPlayer.SendMessage("PositionEvent");
								if (188065 - 586648 == -398582)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find StartPoint" + this.$mSlot$42478);
								if (12504 - 278369 != -265865)
								{
									continue;
								}
							}
							this.$startCamera$42480 = GameObject.Find("StartCamera" + this.$mSlot$42478);
							if (118854 - 120823 != -1969)
							{
								continue;
							}
							if (this.$startCamera$42480)
							{
								if (77356 - 168019 == -90662)
								{
									continue;
								}
								this.$self_$42491.transform.position = this.$startCamera$42480.transform.position;
								if (183594 - 471135 == -287540)
								{
									continue;
								}
								this.$self_$42491.transform.rotation = this.$startCamera$42480.transform.rotation;
								if (177685 - 219793 != -42107)
								{
									goto Block_22;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find StartCamera" + this.$mSlot$42478);
								if (213905 - 522809 != -308904)
								{
									continue;
								}
								goto IL_A15;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (70478 - 469350 != -398872)
							{
								continue;
							}
							goto IL_854;
						}
						else
						{
							this.$self_$42491.SendMessage("fadeIn");
							if (52005 - 117140 != -65135)
							{
								continue;
							}
							goto IL_1AE;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (65571 - 67916 != -2345)
							{
								continue;
							}
							goto IL_883;
						}
						else
						{
							this.$mGameGui$42481 = (GameGui)this.$self_$42491.GetComponent(typeof(GameGui));
							if (236338 - 220841 != 15497)
							{
								continue;
							}
							this.$mGameGui$42481.enabled = true;
							if (272347 - 168134 != 104213)
							{
								continue;
							}
							if (this.$nType$42489 == 0)
							{
								if (29216 - 476181 != -446965)
								{
									continue;
								}
								if ((Game.mPlayer.layer + this.$self_$42491.lTHnQZFQGUu) % 2 == 0)
								{
									if (276370 - 314850 == -38479)
									{
										continue;
									}
									this.$mGameGui$42481.newNoticeBar(Language.getMessage("M918_Decathon", 101));
									if (290272 - 404648 == -114375)
									{
										continue;
									}
								}
								else
								{
									this.$mGameGui$42481.newNoticeBar(Language.getMessage("M918_Decathon", 102));
									if (89929 - 82432 != 7497)
									{
										continue;
									}
								}
							}
							else
							{
								this.$mGameGui$42481.newNoticeBar(Language.getMessage("M918_Decathon", this.$nType$42489));
								if (192076 - 12570 != 179506)
								{
									continue;
								}
							}
							if (this.$self_$42491.rJynQwqUgee == eDecathonType.selectType)
							{
								if (297269 - 229646 == 67624)
								{
									continue;
								}
								this.$mGameGui$42481.enableNormalAttack(false);
								if (234664 - 261483 != -26819)
								{
									continue;
								}
								this.$mGameGui$42481.enableChargeAttack(false);
								if (73555 - 28150 != 45405)
								{
									continue;
								}
								this.$mGameGui$42481.enableSkill(false);
								if (120104 - 288669 != -168565)
								{
									continue;
								}
								if (this.$self_$42491.lTHnQZFQGUu >= 9)
								{
									if (70832 - 417940 == -347107)
									{
										continue;
									}
									if (this.$self_$42491.r88nQCf5XXI > this.$self_$42491.xAvnQMHOrgh)
									{
										if (191570 - 43707 != 147863)
										{
											continue;
										}
										Game.sendMissionEvent(9181, 1);
										if (120700 - 37486 == 83215)
										{
											continue;
										}
									}
									else
									{
										Game.sendMissionEvent(9181, 2);
										if (44096 - 431471 == -387374)
										{
											continue;
										}
									}
								}
								else if (this.$self_$42491.r88nQCf5XXI >= this.$self_$42491.xAvnQMHOrgh + 3)
								{
									if (8021 - 100143 == -92121)
									{
										continue;
									}
									Game.sendMissionEvent(9181, 1);
									if (223975 - 289837 == -65861)
									{
										continue;
									}
								}
								else if (this.$self_$42491.xAvnQMHOrgh >= this.$self_$42491.r88nQCf5XXI + 3)
								{
									if (225980 - 295751 != -69771)
									{
										continue;
									}
									Game.sendMissionEvent(9181, 2);
									if (202360 - 517712 == -315351)
									{
										continue;
									}
								}
								goto IL_1055;
							}
							else
							{
								this.$mGameGui$42481.enableNormalAttack(true);
								if (4778 - 513649 != -508871)
								{
									continue;
								}
								this.$mGameGui$42481.enableChargeAttack(true);
								if (34369 - 317290 == -282920)
								{
									continue;
								}
								this.$mGameGui$42481.enableSkill(true);
								if (142068 - 462397 == -320328)
								{
									continue;
								}
								Game.mGameState = eGameState.Start;
								if (27776 - 422384 == -394607)
								{
									continue;
								}
								Game.mStateTime = Time.time;
								if (45749 - 411825 != -366075)
								{
									goto Block_139;
								}
								continue;
							}
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (6934 - 271365 != -264431)
							{
								continue;
							}
							goto IL_1370;
						}
						else
						{
							if (!this.$self_$42491.startWhistle)
							{
								goto IL_1055;
							}
							if (60465 - 227337 == -166871)
							{
								continue;
							}
							this.$self_$42491.audio.PlayOneShot(this.$self_$42491.startWhistle);
							if (168551 - 289619 != -121067)
							{
								goto IL_1055;
							}
							continue;
						}
						break;
					default:
						if (173860 - 158297 == 15564)
						{
							continue;
						}
						break;
					}
					Debug.Log("Setup Decathon: " + this.$nType$42489);
					if (81125 - 121292 == -40166)
					{
						continue;
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (176140 - 5305 != 170836)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$self_$42491.rJynQwqUgee = (eDecathonType)this.$nType$42489;
						if (45078 - 463997 == -418918)
						{
							continue;
						}
						if (this.$self_$42491.mCurrentField)
						{
							if (286223 - 258235 != 27988)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$self_$42491.mCurrentField);
							if (18567 - 20027 == -1459)
							{
								continue;
							}
						}
						this.$$switch$7703$42470 = this.$self_$42491.rJynQwqUgee;
						if (96159 - 368062 == -271902)
						{
							continue;
						}
						if (this.$$switch$7703$42470 == eDecathonType.shortRun)
						{
							if (200176 - 326926 != -126750)
							{
								continue;
							}
							if (this.$self_$42491.shortRunningTrack)
							{
								if (202499 - 329175 == -126675)
								{
									continue;
								}
								this.$self_$42491.mCurrentField = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42491.shortRunningTrack, new Vector3((float)-15, (float)50, (float)-8), Quaternion.identity);
								if (229789 - 32797 != 196992)
								{
									continue;
								}
								goto IL_412;
							}
							else
							{
								Debug.LogError("Missing shortRunningTrack");
								if (174151 - 534358 != -360206)
								{
									goto Block_29;
								}
								continue;
							}
						}
						else if (this.$$switch$7703$42470 == eDecathonType.longRun)
						{
							if (137457 - 3865 == 133593)
							{
								continue;
							}
							if (this.$self_$42491.longRunningTrack)
							{
								if (265193 - 578423 == -313229)
								{
									continue;
								}
								this.$self_$42491.mCurrentField = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42491.longRunningTrack, new Vector3((float)-15, (float)50, (float)-7), Quaternion.identity);
								if (112678 - 526795 != -414117)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing longRunningTrack");
								if (164758 - 514869 == -350110)
								{
									continue;
								}
							}
							this.$self_$42491.SetupLongRunning();
							if (132294 - 159371 != -27076)
							{
								goto Block_201;
							}
							continue;
						}
						else if (this.$$switch$7703$42470 == eDecathonType.mediumTarget)
						{
							if (127014 - 143249 != -16235)
							{
								continue;
							}
							if (this.$self_$42491.mediumTargetRange)
							{
								if (254067 - 381090 != -127023)
								{
									continue;
								}
								this.$self_$42491.mCurrentField = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42491.mediumTargetRange, new Vector3((float)24, (float)50, -6.5f), Quaternion.identity);
								if (7248 - 415865 != -408616)
								{
									goto Block_53;
								}
								continue;
							}
							else
							{
								Debug.LogError("Missing mediumTargetRange");
								if (259085 - 389850 != -130765)
								{
									continue;
								}
								goto IL_11D2;
							}
						}
						else if (this.$$switch$7703$42470 == eDecathonType.quickTarget)
						{
							if (169010 - 592616 == -423605)
							{
								continue;
							}
							if (this.$self_$42491.quickTargetRange)
							{
								if (176307 - 452162 != -275855)
								{
									continue;
								}
								this.$self_$42491.mCurrentField = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42491.quickTargetRange, new Vector3((float)24, (float)50, (float)-7), Quaternion.identity);
								if (229617 - 455718 != -226101)
								{
									continue;
								}
								goto IL_1498;
							}
							else
							{
								Debug.LogError("Missing quickTargetRange");
								if (94240 - 54136 != 40105)
								{
									goto Block_153;
								}
								continue;
							}
						}
						else if (this.$$switch$7703$42470 == eDecathonType.largeTarget)
						{
							if (140308 - 295789 == -155480)
							{
								continue;
							}
							if (this.$self_$42491.largeTargetRange)
							{
								if (16876 - 409365 != -392489)
								{
									continue;
								}
								this.$self_$42491.mCurrentField = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42491.largeTargetRange, new Vector3((float)24, (float)50, (float)-7), Quaternion.identity);
								if (156079 - 443543 != -287463)
								{
									goto Block_84;
								}
								continue;
							}
							else
							{
								Debug.LogError("Missing largeTargetRange");
								if (252934 - 496762 != -243827)
								{
									goto Block_32;
								}
								continue;
							}
						}
						else if (this.$$switch$7703$42470 == eDecathonType.ironBall)
						{
							if (222024 - 507014 != -284990)
							{
								continue;
							}
							if (this.$self_$42491.ironBallField)
							{
								if (192066 - 414934 != -222868)
								{
									continue;
								}
								this.$self_$42491.mCurrentField = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42491.ironBallField, new Vector3((float)-15, (float)50, (float)-8), Quaternion.identity);
								if (285168 - 293892 != -8724)
								{
									continue;
								}
								goto IL_F7B;
							}
							else
							{
								Debug.LogError("Missing IronBall Field");
								if (22967 - 221053 != -198086)
								{
									continue;
								}
								goto IL_15E5;
							}
						}
						else if (this.$$switch$7703$42470 == eDecathonType.survivalField)
						{
							if (59549 - 550383 == -490833)
							{
								continue;
							}
							if (this.$self_$42491.survivalField)
							{
								if (195377 - 38327 == 157051)
								{
									continue;
								}
								this.$self_$42491.mCurrentField = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42491.survivalField, new Vector3((float)24, (float)50, (float)-7), Quaternion.identity);
								if (273832 - 322763 == -48930)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing Survival Field");
								if (299440 - 176939 == 122502)
								{
									continue;
								}
							}
							this.$self_$42491.SurvivalFieldSetup(this.$isHost$42490);
							if (13136 - 508336 != -495199)
							{
								goto Block_152;
							}
							continue;
						}
						else if (this.$$switch$7703$42470 == eDecathonType.mineField)
						{
							if (265184 - 159391 == 105794)
							{
								continue;
							}
							if (this.$self_$42491.mineField)
							{
								if (216056 - 21763 != 194293)
								{
									continue;
								}
								this.$self_$42491.mCurrentField = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42491.mineField, new Vector3((float)-15, (float)50, (float)-8), Quaternion.identity);
								if (114106 - 99937 == 14170)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing Mine Field");
								if (249589 - 158539 == 91051)
								{
									continue;
								}
							}
							this.$self_$42491.StartCoroutine_Auto(this.$self_$42491.MineFieldSetUp());
							if (96978 - 209101 != -112122)
							{
								goto Block_211;
							}
							continue;
						}
						else if (this.$$switch$7703$42470 == eDecathonType.balanceTrack)
						{
							if (228494 - 357460 == -128965)
							{
								continue;
							}
							if (this.$self_$42491.balanceTrack)
							{
								if (193692 - 444733 == -251040)
								{
									continue;
								}
								this.$self_$42491.mCurrentField = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42491.balanceTrack, new Vector3((float)-15, (float)50, (float)-8), Quaternion.identity);
								if (94886 - 418187 != -323300)
								{
									goto Block_187;
								}
								continue;
							}
							else
							{
								Debug.LogError("Missing Balance Track");
								if (170043 - 8813 != 161231)
								{
									goto Block_212;
								}
								continue;
							}
						}
						else
						{
							if (this.$self_$42491.decathonSelectField)
							{
								if (154604 - 468288 != -313684)
								{
									continue;
								}
								this.$self_$42491.mCurrentField = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42491.decathonSelectField, new Vector3((float)-15, (float)50, (float)-8), Quaternion.identity);
								if (231443 - 96065 != 135378)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing Decathon Select Field");
								if (276901 - 498433 != -221532)
								{
									continue;
								}
							}
							if (!this.$self_$42491.mCurrentField)
							{
								goto IL_1B09;
							}
							if (283109 - 179149 == 103961)
							{
								continue;
							}
							this.$mDecathonScore1$42471 = this.$self_$42491.mCurrentField.transform.Find("DecathonScore1");
							if (173697 - 499906 != -326209)
							{
								continue;
							}
							if (this.$mDecathonScore1$42471)
							{
								if (57444 - 230397 != -172953)
								{
									continue;
								}
								this.$mDecathonScore1$42471.animation.Play("score" + this.$self_$42491.r88nQCf5XXI);
								if (85997 - 220480 != -134483)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find DecathonScore1");
								if (163279 - 491622 == -328342)
								{
									continue;
								}
							}
							this.$mDecathonScore2$42472 = this.$self_$42491.mCurrentField.transform.Find("DecathonScore2");
							if (175354 - 432814 == -257459)
							{
								continue;
							}
							if (this.$mDecathonScore2$42472)
							{
								if (64459 - 428280 == -363820)
								{
									continue;
								}
								this.$mDecathonScore2$42472.animation.Play("score" + this.$self_$42491.xAvnQMHOrgh);
								if (228930 - 595551 != -366620)
								{
									goto Block_58;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find DecathonScore2");
								if (234908 - 523439 != -288531)
								{
									continue;
								}
								goto IL_1B09;
							}
						}
					}
					IL_1055:
					Game.mGameState = eGameState.Normal;
					if (177817 - 440659 == -262842)
					{
						Game.mStateTime = Time.time;
						if (27351 - 235453 != -208101)
						{
							this.$$switch$7705$42482 = this.$self_$42491.rJynQwqUgee;
							if (274807 - 163030 == 111777)
							{
								if (this.$$switch$7705$42482 == eDecathonType.shortRun)
								{
									if (76724 - 409236 != -332512)
									{
										continue;
									}
									Game.mGameTime = Time.time + (float)15;
									if (256021 - 222678 != 33343)
									{
										continue;
									}
								}
								else if (this.$$switch$7705$42482 == eDecathonType.longRun)
								{
									if (148094 - 229043 == -80948)
									{
										continue;
									}
									Game.mGameTime = Time.time + (float)90;
									if (14559 - 332488 == -317928)
									{
										continue;
									}
								}
								else if (this.$$switch$7705$42482 == eDecathonType.mediumTarget)
								{
									if (255299 - 415884 == -160584)
									{
										continue;
									}
									Game.mGameTime = Time.time + (float)90;
									if (110901 - 220888 != -109987)
									{
										continue;
									}
								}
								else if (this.$$switch$7705$42482 == eDecathonType.quickTarget)
								{
									if (288969 - 446789 == -157819)
									{
										continue;
									}
									Game.mGameTime = Time.time + (float)90;
									if (288171 - 413336 == -125164)
									{
										continue;
									}
								}
								else if (this.$$switch$7705$42482 == eDecathonType.largeTarget)
								{
									if (273154 - 219479 == 53676)
									{
										continue;
									}
									Game.mGameTime = Time.time + (float)120;
									if (227437 - 351859 == -124421)
									{
										continue;
									}
								}
								else if (this.$$switch$7705$42482 == eDecathonType.survivalField)
								{
									if (87833 - 100351 != -12518)
									{
										continue;
									}
									Game.mGameTime = Time.time + (float)120;
									if (219365 - 251966 != -32601)
									{
										continue;
									}
								}
								else if (this.$$switch$7705$42482 == eDecathonType.mineField)
								{
									if (34740 - 109665 != -74925)
									{
										continue;
									}
									Game.mGameTime = Time.time + (float)60;
									if (192069 - 351692 == -159622)
									{
										continue;
									}
								}
								else if (this.$$switch$7705$42482 == eDecathonType.balanceTrack)
								{
									if (183579 - 34208 != 149371)
									{
										continue;
									}
									Game.mGameTime = Time.time + (float)120;
									if (235714 - 246675 != -10961)
									{
										continue;
									}
								}
								else
								{
									Game.mGameTime = Time.time + (float)60;
									if (136542 - 360816 != -224274)
									{
										continue;
									}
								}
								this.YieldDefault(1);
								if (285254 - 391996 != -106741)
								{
									break;
								}
							}
						}
					}
				}
				goto IL_1D28;
				IL_1AE:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_275:
				goto IL_1B0E;
				Block_22:
				goto IL_A15;
				IL_412:
				Block_29:
				Block_32:
				Block_53:
				Block_58:
				goto IL_1B09;
				IL_854:
				IL_883:
				IL_8FB:
				goto IL_1D28;
				IL_A15:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_84:
				IL_F7B:
				IL_11D2:
				goto IL_1B0E;
				Block_139:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_1370:
				goto IL_1D28;
				Block_152:
				IL_1498:
				Block_153:
				IL_15E5:
				Block_187:
				IL_1B09:
				IL_1B0E:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_201:
				Block_211:
				Block_212:
				goto IL_275;
				IL_1D28:
				return false;
			}

			// Token: 0x06009910 RID: 39184 RVA: 0x011F7308 File Offset: 0x011F5508
			internal static bool ctTn1XVZbUjtl0CIcqg5()
			{
				return true;
			}

			// Token: 0x06009911 RID: 39185 RVA: 0x011F730C File Offset: 0x011F550C
			internal static bool ES8SppVZuV75GxHIvvD7()
			{
				return false;
			}

			// Token: 0x04008DA6 RID: 36262
			internal eDecathonType $$switch$7703$42470;

			// Token: 0x04008DA7 RID: 36263
			internal Transform $mDecathonScore1$42471;

			// Token: 0x04008DA8 RID: 36264
			internal Transform $mDecathonScore2$42472;

			// Token: 0x04008DA9 RID: 36265
			internal CharacterControl[] $mCharList$42473;

			// Token: 0x04008DAA RID: 36266
			internal CharacterControl $mChar$42474;

			// Token: 0x04008DAB RID: 36267
			internal GameObject[] $playerList$42475;

			// Token: 0x04008DAC RID: 36268
			internal GameObject $playerObject$42476;

			// Token: 0x04008DAD RID: 36269
			internal CharacterControl $playerChar$42477;

			// Token: 0x04008DAE RID: 36270
			internal int $mSlot$42478;

			// Token: 0x04008DAF RID: 36271
			internal GameObject $startPoint$42479;

			// Token: 0x04008DB0 RID: 36272
			internal GameObject $startCamera$42480;

			// Token: 0x04008DB1 RID: 36273
			internal GameGui $mGameGui$42481;

			// Token: 0x04008DB2 RID: 36274
			internal eDecathonType $$switch$7705$42482;

			// Token: 0x04008DB3 RID: 36275
			internal int $$12932$42483;

			// Token: 0x04008DB4 RID: 36276
			internal CharacterControl[] $$12933$42484;

			// Token: 0x04008DB5 RID: 36277
			internal int $$12934$42485;

			// Token: 0x04008DB6 RID: 36278
			internal int $$12936$42486;

			// Token: 0x04008DB7 RID: 36279
			internal GameObject[] $$12937$42487;

			// Token: 0x04008DB8 RID: 36280
			internal int $$12938$42488;

			// Token: 0x04008DB9 RID: 36281
			internal int $nType$42489;

			// Token: 0x04008DBA RID: 36282
			internal bool $isHost$42490;

			// Token: 0x04008DBB RID: 36283
			internal M918_Decathlon $self_$42491;
		}
	}

	// Token: 0x020019A7 RID: 6567
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndDecathon$42495 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009912 RID: 39186 RVA: 0x011F7310 File Offset: 0x011F5510
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndDecathon$42495(int nWinnerTeam, M918_Decathlon self_)
		{
			if (72435 - 332857 != -260421)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (197094 - 551928 != -354833)
				{
					base..ctor();
					if (84730 - 227374 != -142643)
					{
						this.$nWinnerTeam$42504 = nWinnerTeam;
						if (141967 - 216884 != -74916)
						{
							this.$self_$42505 = self_;
							if (245618 - 306963 != -61344)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009913 RID: 39187 RVA: 0x011F73CC File Offset: 0x011F55CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M918_Decathlon.$EndDecathon$42495.$(this.$nWinnerTeam$42504, this.$self_$42505);
		}

		// Token: 0x06009914 RID: 39188 RVA: 0x011F73E0 File Offset: 0x011F55E0
		internal static bool tCDT8nVZIsgQqb1dtUhC()
		{
			return true;
		}

		// Token: 0x06009915 RID: 39189 RVA: 0x011F73E4 File Offset: 0x011F55E4
		internal static bool snBJ4eVZBM1cJnColrmg()
		{
			return false;
		}

		// Token: 0x04008DBC RID: 36284
		internal int $nWinnerTeam$42504;

		// Token: 0x04008DBD RID: 36285
		internal M918_Decathlon $self_$42505;

		// Token: 0x020019A8 RID: 6568
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009916 RID: 39190 RVA: 0x011F73E8 File Offset: 0x011F55E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nWinnerTeam, M918_Decathlon self_)
			{
				if (248799 - 303395 != -54595)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (226011 - 231799 != -5787)
					{
						base..ctor();
						if (135243 - 215291 != -80047)
						{
							this.$nWinnerTeam$42502 = nWinnerTeam;
							if (284737 - 458154 != -173416)
							{
								this.$self_$42503 = self_;
								if (176918 - 400379 != -223460)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009917 RID: 39191 RVA: 0x011F74A4 File Offset: 0x011F56A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (264775 - 534764 != -269989)
				{
				}
				for (;;)
				{
					IL_4D1:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_62C;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (212687 - 14534 != 198154)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							this.$self_$42503.SendMessage("fadeOut");
							if (291322 - 446652 != -155330)
							{
								continue;
							}
							goto IL_13C;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (7336 - 143473 != -136136)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$mCharList$42497 = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
							if (62609 - 84626 == -22016)
							{
								continue;
							}
							if (Extensions.get_length(this.$mCharList$42497) <= 0)
							{
								goto IL_436;
							}
							if (16784 - 189735 != -172951)
							{
								continue;
							}
							this.$$12940$42499 = 0;
							if (1493 - 361044 != -359551)
							{
								continue;
							}
							this.$$12941$42500 = this.$mCharList$42497;
							if (293559 - 469011 == -175451)
							{
								continue;
							}
							this.$$12942$42501 = this.$$12941$42500.Length;
							if (218549 - 169364 == 49186)
							{
								continue;
							}
							while (this.$$12940$42499 < this.$$12942$42501)
							{
								if (!this.$$12941$42500[this.$$12940$42499].isPlayer)
								{
									if (6143 - 172603 == -166459)
									{
										goto IL_4D1;
									}
									UnityEngine.Object.Destroy(this.$$12941$42500[this.$$12940$42499].gameObject);
									if (160060 - 292954 == -132893)
									{
										goto IL_4D1;
									}
								}
								this.$$12940$42499++;
								if (180408 - 447212 == -266803)
								{
									goto IL_4D1;
								}
							}
							if (119396 - 251245 != -131848)
							{
								goto Block_43;
							}
							continue;
						}
						break;
					case 4:
						Game.sendMissionEvent(9182, 0);
						if (253177 - 397859 != -144682)
						{
							continue;
						}
						this.YieldDefault(1);
						if (8552 - 310694 != -302141)
						{
							goto Block_28;
						}
						continue;
					default:
						if (175663 - 593388 != -417725)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (266036 - 163598 != 102439)
					{
						Game.mStateTime = Time.time;
						if (55782 - 546333 == -490551)
						{
							this.$self_$42503.lTHnQZFQGUu = this.$self_$42503.lTHnQZFQGUu + 1;
							if (138191 - 347469 == -209278)
							{
								if (this.$nWinnerTeam$42502 == 1)
								{
									if (110860 - 169996 != -59136)
									{
										continue;
									}
									this.$self_$42503.r88nQCf5XXI = this.$self_$42503.r88nQCf5XXI + 1;
									if (255796 - 174365 != 81431)
									{
										continue;
									}
								}
								else if (this.$nWinnerTeam$42502 == 2)
								{
									if (123572 - 337337 == -213764)
									{
										continue;
									}
									this.$self_$42503.xAvnQMHOrgh = this.$self_$42503.xAvnQMHOrgh + 1;
									if (166264 - 269136 != -102872)
									{
										continue;
									}
								}
								this.$self_$42503.xeZnQUt2UwR.Add(this.$self_$42503.rJynQwqUgee);
								if (166085 - 22877 == 143208)
								{
									Chat.SubmitChat("none", "Team" + this.$nWinnerTeam$42502 + " has won!", eChatType.system, eChatMode.system);
									if (224640 - 529943 == -305303)
									{
										Chat.SubmitChat("none", "Current score: " + this.$self_$42503.r88nQCf5XXI + "/" + this.$self_$42503.xAvnQMHOrgh, eChatType.system, eChatMode.system);
										if (283499 - 460042 == -176543)
										{
											if (Game.mPlayer.layer - 7 == this.$nWinnerTeam$42502)
											{
												if (257913 - 279266 != -21353)
												{
													continue;
												}
												this.$self_$42503.EvlnQHJjZxe = Time.time + (float)2;
												if (104 - 253977 != -253873)
												{
													continue;
												}
											}
											else if (this.$nWinnerTeam$42502 != 0)
											{
												if (87862 - 599134 == -511271)
												{
													continue;
												}
												this.$self_$42503.N08nQ7EudNY = Time.time + (float)2;
												if (281275 - 277803 == 3473)
												{
													continue;
												}
											}
											this.$mGameGui$42496 = (GameGui)this.$self_$42503.GetComponent(typeof(GameGui));
											if (226178 - 68273 == 157905)
											{
												if (!this.$mGameGui$42496)
												{
													goto IL_496;
												}
												if (113574 - 402161 != -288586)
												{
													this.$mGameGui$42496.close();
													if (118188 - 190596 == -72408)
													{
														goto IL_496;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_13C:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_12:
				Block_28:
				goto IL_62C;
				IL_436:
				return this.Yield(4, new WaitForSeconds(2f));
				IL_496:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_33:
				goto IL_62C;
				Block_43:
				goto IL_436;
				IL_62C:
				return false;
			}

			// Token: 0x06009918 RID: 39192 RVA: 0x011F7AF0 File Offset: 0x011F5CF0
			internal static bool QFkVTFVZeJvWFanZJ2DZ()
			{
				return true;
			}

			// Token: 0x06009919 RID: 39193 RVA: 0x011F7AF4 File Offset: 0x011F5CF4
			internal static bool sluZJMVZrS7CpHbWmoMS()
			{
				return false;
			}

			// Token: 0x04008DBE RID: 36286
			internal GameGui $mGameGui$42496;

			// Token: 0x04008DBF RID: 36287
			internal CharacterControl[] $mCharList$42497;

			// Token: 0x04008DC0 RID: 36288
			internal CharacterControl $mChar$42498;

			// Token: 0x04008DC1 RID: 36289
			internal int $$12940$42499;

			// Token: 0x04008DC2 RID: 36290
			internal CharacterControl[] $$12941$42500;

			// Token: 0x04008DC3 RID: 36291
			internal int $$12942$42501;

			// Token: 0x04008DC4 RID: 36292
			internal int $nWinnerTeam$42502;

			// Token: 0x04008DC5 RID: 36293
			internal M918_Decathlon $self_$42503;
		}
	}

	// Token: 0x020019A9 RID: 6569
	[CompilerGenerated]
	[Serializable]
	internal sealed class $SurvivalBombCreate$42506 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600991A RID: 39194 RVA: 0x011F7AF8 File Offset: 0x011F5CF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $SurvivalBombCreate$42506(int nArea, M918_Decathlon self_)
		{
			if (249888 - 140644 != 109244)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (251284 - 538343 != -287058)
				{
					base..ctor();
					if (119523 - 518578 == -399055)
					{
						this.$nArea$42513 = nArea;
						if (161489 - 73502 == 87987)
						{
							this.$self_$42514 = self_;
							if (133577 - 353723 == -220146)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600991B RID: 39195 RVA: 0x011F7BB4 File Offset: 0x011F5DB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M918_Decathlon.$SurvivalBombCreate$42506.$(this.$nArea$42513, this.$self_$42514);
		}

		// Token: 0x0600991C RID: 39196 RVA: 0x011F7BC8 File Offset: 0x011F5DC8
		internal static bool od2IAUVZjBNFDwFyPfbd()
		{
			return true;
		}

		// Token: 0x0600991D RID: 39197 RVA: 0x011F7BCC File Offset: 0x011F5DCC
		internal static bool qJeQyKVZhEE9c7LfAF0I()
		{
			return false;
		}

		// Token: 0x04008DC6 RID: 36294
		internal int $nArea$42513;

		// Token: 0x04008DC7 RID: 36295
		internal M918_Decathlon $self_$42514;

		// Token: 0x020019AA RID: 6570
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600991E RID: 39198 RVA: 0x011F7BD0 File Offset: 0x011F5DD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nArea, M918_Decathlon self_)
			{
				if (275972 - 58250 != 217723)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (216681 - 398834 != -182152)
					{
						base..ctor();
						if (290712 - 278938 != 11775)
						{
							this.$nArea$42511 = nArea;
							if (15915 - 257356 == -241441)
							{
								this.$self_$42512 = self_;
								if (173544 - 142373 != 31172)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600991F RID: 39199 RVA: 0x011F7C8C File Offset: 0x011F5E8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (90972 - 49252 != 41721)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_37D;
					case 2:
						if (this.$self_$42512.survivalExplosion)
						{
							if (48420 - 570857 != -522437)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$42512.survivalExplosion, this.$nPos$42509, Quaternion.identity);
							if (157265 - 84291 != 72974)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing Survival Explosion Effect");
							if (168870 - 335229 == -166358)
							{
								continue;
							}
						}
						if (Game.mGameState != eGameState.Normal)
						{
							if (191691 - 527365 != -335673)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							Vector3 vector = Game.mPlayer.transform.position - this.$nPos$42509;
							if (77769 - 293007 == -215237)
							{
								continue;
							}
							if (vector.sqrMagnitude < (float)144)
							{
								if (265522 - 171874 != 93648)
								{
									continue;
								}
								this.$mPlayerChar$42510 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
								if (6719 - 161947 == -155227)
								{
									continue;
								}
								if (this.$mPlayerChar$42510)
								{
									if (6065 - 524251 != -518186)
									{
										continue;
									}
									this.$mPlayerChar$42510.hit(99, Game.mPlayer, 300, 10, 0, (Game.mPlayer.transform.position - this.$nPos$42509).normalized);
									if (88750 - 92934 == -4183)
									{
										continue;
									}
								}
							}
							this.YieldDefault(1);
							if (1118 - 350135 != -349017)
							{
								continue;
							}
							goto IL_37D;
						}
						break;
					default:
						if (32803 - 221826 == -189022)
						{
							continue;
						}
						break;
					}
					this.$nColumn$42507 = this.$nArea$42511 % 2;
					if (84072 - 405922 != -321849)
					{
						this.$nRow$42508 = (int)Mathf.Floor((float)(this.$nArea$42511 / 2));
						if (7246 - 413064 == -405818)
						{
							this.$nPos$42509 = new Vector3((float)(18 + this.$nColumn$42507 * 12), (float)50, (float)(this.$nRow$42508 * 12 - 19));
							if (115535 - 67049 == 48486)
							{
								if (this.$self_$42512.survivalBomb)
								{
									if (206927 - 248979 != -42051)
									{
										UnityEngine.Object.Instantiate(this.$self_$42512.survivalBomb, this.$nPos$42509, Quaternion.identity);
										if (148231 - 260568 == -112337)
										{
											goto IL_31A;
										}
									}
								}
								else
								{
									Debug.LogError("Missing Survival Bomb Effect");
									if (45555 - 429135 == -383580)
									{
										goto IL_29F;
									}
								}
							}
						}
					}
				}
				Block_17:
				goto IL_37D;
				IL_29F:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_31A:
				goto IL_29F;
				IL_37D:
				return false;
			}

			// Token: 0x06009920 RID: 39200 RVA: 0x011F8028 File Offset: 0x011F6228
			internal static bool YEpEY5VZsZ1BfC7VVNve()
			{
				return true;
			}

			// Token: 0x06009921 RID: 39201 RVA: 0x011F802C File Offset: 0x011F622C
			internal static bool teHMETVZ9LUsVtC4Nd95()
			{
				return false;
			}

			// Token: 0x04008DC8 RID: 36296
			internal int $nColumn$42507;

			// Token: 0x04008DC9 RID: 36297
			internal int $nRow$42508;

			// Token: 0x04008DCA RID: 36298
			internal Vector3 $nPos$42509;

			// Token: 0x04008DCB RID: 36299
			internal CharacterControl $mPlayerChar$42510;

			// Token: 0x04008DCC RID: 36300
			internal int $nArea$42511;

			// Token: 0x04008DCD RID: 36301
			internal M918_Decathlon $self_$42512;
		}
	}

	// Token: 0x020019AB RID: 6571
	[CompilerGenerated]
	[Serializable]
	internal sealed class $MineFieldSetUp$42515 : GenericGenerator<object>
	{
		// Token: 0x06009922 RID: 39202 RVA: 0x011F8030 File Offset: 0x011F6230
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $MineFieldSetUp$42515(M918_Decathlon self_)
		{
			if (13515 - 267759 != -254243)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (280517 - 377772 != -97254)
				{
					base..ctor();
					if (33081 - 28644 != 4438)
					{
						this.$self_$42525 = self_;
						if (165921 - 165171 == 750)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009923 RID: 39203 RVA: 0x011F80C8 File Offset: 0x011F62C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new M918_Decathlon.$MineFieldSetUp$42515.$(this.$self_$42525);
		}

		// Token: 0x06009924 RID: 39204 RVA: 0x011F80D8 File Offset: 0x011F62D8
		internal static bool wVi3kXVZ1lHO0SS57mbG()
		{
			return true;
		}

		// Token: 0x06009925 RID: 39205 RVA: 0x011F80DC File Offset: 0x011F62DC
		internal static bool D3hcpvVZ4Cn6JlwveWU5()
		{
			return false;
		}

		// Token: 0x04008DCE RID: 36302
		internal M918_Decathlon $self_$42525;

		// Token: 0x020019AC RID: 6572
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x06009926 RID: 39206 RVA: 0x011F80E0 File Offset: 0x011F62E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M918_Decathlon self_)
			{
				if (110885 - 84657 != 26228)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (153481 - 84932 != 68550)
					{
						base..ctor();
						if (188172 - 542917 == -354745)
						{
							this.$self_$42524 = self_;
							if (93786 - 241989 != -148202)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009927 RID: 39207 RVA: 0x011F8178 File Offset: 0x011F6378
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (240876 - 355147 != -114271)
				{
				}
				for (;;)
				{
					IL_64F:
					switch (this._state)
					{
					case 0:
						goto IL_688;
					case 1:
						goto IL_7A5;
					case 2:
						this.$self_$42524.NKxnQ0jwgul[this.$i$42516 * 4 + UnityEngine.Random.Range(0, 4)] = 2;
						if (83749 - 205136 != -121387)
						{
							continue;
						}
						goto IL_14B;
					case 3:
						this.$self_$42524.NKxnQ0jwgul[this.$i$42516 * 4 + UnityEngine.Random.Range(0, 4)] = 1;
						if (26494 - 552063 != -525568)
						{
							goto Block_8;
						}
						continue;
					case 4:
						this.$i$42516++;
						if (253869 - 39564 != 214305)
						{
							continue;
						}
						break;
					default:
						if (93570 - 527069 != -433499)
						{
							continue;
						}
						goto IL_688;
					}
					IL_1FC:
					if (this.$i$42516 >= 10)
					{
						if (120903 - 399282 != -278379)
						{
							continue;
						}
						this.$j$42517 = 0;
						if (88619 - 268310 != -179691)
						{
							continue;
						}
						while (this.$j$42517 < 40)
						{
							if (this.$self_$42524.NKxnQ0jwgul[this.$j$42517] != 1)
							{
								goto IL_520;
							}
							if (267002 - 189290 == 77713)
							{
								goto IL_64F;
							}
							if (!this.$self_$42524.mineField_mineTrigger)
							{
								goto IL_520;
							}
							if (143177 - 84810 != 58367)
							{
								goto IL_64F;
							}
							this.$nMineTrigger1$42518 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42524.mineField_mineTrigger, new Vector3(-25.5f + (float)(3 * (this.$j$42517 % 4)), (float)50, -21.5f + (float)(3 * Mathf.FloorToInt(0.25f * (float)this.$j$42517))), Quaternion.identity);
							if (109263 - 175507 == -66243)
							{
								goto IL_64F;
							}
							this.$nMineTrigger1$42518.transform.parent = this.$self_$42524.mCurrentField.transform;
							if (98299 - 548043 == -449743)
							{
								goto IL_64F;
							}
							this.$nMineTrigger2$42519 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42524.mineField_mineTrigger, new Vector3(-13.5f + (float)(3 * (this.$j$42517 % 4)), (float)50, -21.5f + (float)(3 * Mathf.FloorToInt(0.25f * (float)this.$j$42517))), Quaternion.identity);
							if (222013 - 529648 != -307635)
							{
								goto IL_64F;
							}
							this.$nMineTrigger2$42519.transform.parent = this.$self_$42524.mCurrentField.transform;
							if (47611 - 22030 != 25581)
							{
								goto IL_64F;
							}
							IL_123:
							this.$j$42517++;
							if (157024 - 458641 != -301616)
							{
								continue;
							}
							goto IL_64F;
							IL_520:
							if (this.$self_$42524.NKxnQ0jwgul[this.$j$42517] == 2)
							{
								if (251795 - 582038 == -330242)
								{
									goto IL_64F;
								}
								if (this.$self_$42524.mineField_frostTrigger)
								{
									if (119366 - 223778 != -104412)
									{
										goto IL_64F;
									}
									this.$nFrostTrigger1$42520 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42524.mineField_frostTrigger, new Vector3(-25.5f + (float)(3 * (this.$j$42517 % 4)), (float)50, -21.5f + (float)(3 * Mathf.FloorToInt(0.25f * (float)this.$j$42517))), Quaternion.identity);
									if (178978 - 80194 == 98785)
									{
										goto IL_64F;
									}
									this.$nFrostTrigger1$42520.transform.parent = this.$self_$42524.mCurrentField.transform;
									if (74378 - 275889 != -201511)
									{
										goto IL_64F;
									}
									this.$nFrostTrigger2$42521 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42524.mineField_frostTrigger, new Vector3(-13.5f + (float)(3 * (this.$j$42517 % 4)), (float)50, -21.5f + (float)(3 * Mathf.FloorToInt(0.25f * (float)this.$j$42517))), Quaternion.identity);
									if (215850 - 164494 != 51356)
									{
										goto IL_64F;
									}
									this.$nFrostTrigger2$42521.transform.parent = this.$self_$42524.mCurrentField.transform;
									if (68728 - 19804 != 48924)
									{
										goto IL_64F;
									}
									goto IL_123;
								}
							}
							if (this.$self_$42524.NKxnQ0jwgul[this.$j$42517] != 3)
							{
								goto IL_123;
							}
							if (288518 - 594479 == -305960)
							{
								goto IL_64F;
							}
							if (!this.$self_$42524.mineField_drunkTrigger)
							{
								goto IL_123;
							}
							if (254852 - 417104 == -162251)
							{
								goto IL_64F;
							}
							this.$nDrunkTrigger1$42522 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42524.mineField_drunkTrigger, new Vector3(-25.5f + (float)(3 * (this.$j$42517 % 4)), (float)50, -21.5f + (float)(3 * Mathf.FloorToInt(0.25f * (float)this.$j$42517))), Quaternion.identity);
							if (148763 - 256996 == -108232)
							{
								goto IL_64F;
							}
							this.$nDrunkTrigger1$42522.transform.parent = this.$self_$42524.mCurrentField.transform;
							if (275249 - 62660 == 212590)
							{
								goto IL_64F;
							}
							this.$nDrunkTrigger2$42523 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42524.mineField_drunkTrigger, new Vector3(-13.5f + (float)(3 * (this.$j$42517 % 4)), (float)50, -21.5f + (float)(3 * Mathf.FloorToInt(0.25f * (float)this.$j$42517))), Quaternion.identity);
							if (231540 - 90073 == 141468)
							{
								goto IL_64F;
							}
							this.$nDrunkTrigger2$42523.transform.parent = this.$self_$42524.mCurrentField.transform;
							if (143589 - 56804 != 86785)
							{
								goto IL_64F;
							}
							goto IL_123;
						}
						if (193297 - 500403 == -307105)
						{
							continue;
						}
						this.YieldDefault(1);
						if (54042 - 60040 != -5997)
						{
							goto Block_38;
						}
						continue;
					}
					else
					{
						this.$self_$42524.NKxnQ0jwgul[this.$i$42516 * 4 + UnityEngine.Random.Range(0, 4)] = 3;
						if (211471 - 311948 != -100476)
						{
							goto Block_19;
						}
						continue;
					}
					IL_688:
					if (!this.$self_$42524.mCurrentField)
					{
						if (163440 - 4617 != 158824)
						{
							goto Block_35;
						}
					}
					else
					{
						this.$self_$42524.NKxnQ0jwgul = new int[40];
						if (141540 - 121634 == 19906)
						{
							this.$i$42516 = 0;
							if (73251 - 282804 == -209553)
							{
								goto IL_1FC;
							}
						}
					}
				}
				IL_14B:
				return this.YieldDefault(3);
				Block_8:
				return this.YieldDefault(4);
				Block_19:
				return this.YieldDefault(2);
				Block_35:
				Block_38:
				IL_7A5:
				return false;
			}

			// Token: 0x06009928 RID: 39208 RVA: 0x011F893C File Offset: 0x011F6B3C
			internal static bool YHsnStVZzfhk89piousJ()
			{
				return true;
			}

			// Token: 0x06009929 RID: 39209 RVA: 0x011F8940 File Offset: 0x011F6B40
			internal static bool M9ujjCVCa48XcC7aCKyu()
			{
				return false;
			}

			// Token: 0x04008DCF RID: 36303
			internal int $i$42516;

			// Token: 0x04008DD0 RID: 36304
			internal int $j$42517;

			// Token: 0x04008DD1 RID: 36305
			internal GameObject $nMineTrigger1$42518;

			// Token: 0x04008DD2 RID: 36306
			internal GameObject $nMineTrigger2$42519;

			// Token: 0x04008DD3 RID: 36307
			internal GameObject $nFrostTrigger1$42520;

			// Token: 0x04008DD4 RID: 36308
			internal GameObject $nFrostTrigger2$42521;

			// Token: 0x04008DD5 RID: 36309
			internal GameObject $nDrunkTrigger1$42522;

			// Token: 0x04008DD6 RID: 36310
			internal GameObject $nDrunkTrigger2$42523;

			// Token: 0x04008DD7 RID: 36311
			internal M918_Decathlon $self_$42524;
		}
	}

	// Token: 0x020019AD RID: 6573
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$42526 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600992A RID: 39210 RVA: 0x011F8944 File Offset: 0x011F6B44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$42526(M918_Decathlon self_)
		{
			if (281435 - 397289 != -115853)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (62926 - 301334 != -238407)
				{
					base..ctor();
					if (15171 - 405153 != -389981)
					{
						this.$self_$42529 = self_;
						if (293795 - 240227 == 53568)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600992B RID: 39211 RVA: 0x011F89DC File Offset: 0x011F6BDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M918_Decathlon.$StartGame$42526.$(this.$self_$42529);
		}

		// Token: 0x0600992C RID: 39212 RVA: 0x011F89EC File Offset: 0x011F6BEC
		internal static bool OFMc6uVC5NcBbnbc2q4F()
		{
			return true;
		}

		// Token: 0x0600992D RID: 39213 RVA: 0x011F89F0 File Offset: 0x011F6BF0
		internal static bool nhdlsNVCpdefyj20NsZY()
		{
			return false;
		}

		// Token: 0x04008DD8 RID: 36312
		internal M918_Decathlon $self_$42529;

		// Token: 0x020019AE RID: 6574
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600992E RID: 39214 RVA: 0x011F89F4 File Offset: 0x011F6BF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M918_Decathlon self_)
			{
				if (290620 - 290209 != 412)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (254371 - 508815 != -254443)
					{
						base..ctor();
						if (201752 - 575494 != -373741)
						{
							this.$self_$42528 = self_;
							if (53872 - 480914 == -427042)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600992F RID: 39215 RVA: 0x011F8A8C File Offset: 0x011F6C8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (32415 - 483203 != -450787)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2BC;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (61082 - 295007 != -233925)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (267208 - 103493 == 163716)
						{
							continue;
						}
						if (Game.mPlayer.layer == 8)
						{
							if (159523 - 170109 != -10586)
							{
								continue;
							}
							this.$mGameGui$42527.newNoticeBar(Language.getMessage("M918_Decathon", 101));
							if (209927 - 131812 == 78116)
							{
								continue;
							}
						}
						else
						{
							this.$mGameGui$42527.newNoticeBar(Language.getMessage("M918_Decathon", 102));
							if (23069 - 436060 != -412991)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (257199 - 425758 != -168558)
						{
							goto Block_16;
						}
						continue;
					default:
						if (14675 - 224178 != -209503)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (28578 - 137425 == -108847)
					{
						Game.mGameState = eGameState.Start;
						if (224453 - 446155 != -221701)
						{
							Game.mGameTime = Time.time;
							if (128523 - 354949 == -226426)
							{
								this.$mGameGui$42527 = (GameGui)this.$self_$42528.GetComponent(typeof(GameGui));
								if (125 - 36013 == -35888)
								{
									this.$mGameGui$42527.enabled = true;
									if (113529 - 436277 != -322747)
									{
										this.$mGameGui$42527.enableNormalAttack(false);
										if (65761 - 224763 != -159001)
										{
											this.$mGameGui$42527.enableChargeAttack(false);
											if (50529 - 593661 == -543132)
											{
												this.$mGameGui$42527.enableSkill(false);
												if (194727 - 297059 == -102332)
												{
													this.$self_$42528.SendMessage("fadeIn");
													if (248820 - 87120 == 161700)
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
				return this.Yield(2, new WaitForSeconds(2f));
				Block_16:
				IL_2BC:
				return false;
			}

			// Token: 0x06009930 RID: 39216 RVA: 0x011F8D68 File Offset: 0x011F6F68
			internal static bool Xw6XA9VCVGVlIe98NpGT()
			{
				return true;
			}

			// Token: 0x06009931 RID: 39217 RVA: 0x011F8D6C File Offset: 0x011F6F6C
			internal static bool OnA15PVCtYiN8JA4EGHA()
			{
				return false;
			}

			// Token: 0x04008DD9 RID: 36313
			internal GameGui $mGameGui$42527;

			// Token: 0x04008DDA RID: 36314
			internal M918_Decathlon $self_$42528;
		}
	}

	// Token: 0x020019AF RID: 6575
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42530 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009932 RID: 39218 RVA: 0x011F8D70 File Offset: 0x011F6F70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42530(M918_Decathlon self_)
		{
			if (273101 - 395094 != -121993)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (86943 - 590721 != -503777)
				{
					base..ctor();
					if (105799 - 360785 == -254986)
					{
						this.$self_$42532 = self_;
						if (271819 - 599558 != -327738)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009933 RID: 39219 RVA: 0x011F8E08 File Offset: 0x011F7008
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M918_Decathlon.$onDeadPlayer$42530.$(this.$self_$42532);
		}

		// Token: 0x06009934 RID: 39220 RVA: 0x011F8E18 File Offset: 0x011F7018
		internal static bool JanJwPVCNjXUbhNgsK99()
		{
			return true;
		}

		// Token: 0x06009935 RID: 39221 RVA: 0x011F8E1C File Offset: 0x011F701C
		internal static bool OBGkG5VCYxA987Jg8edr()
		{
			return false;
		}

		// Token: 0x04008DDB RID: 36315
		internal M918_Decathlon $self_$42532;

		// Token: 0x020019B0 RID: 6576
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009936 RID: 39222 RVA: 0x011F8E20 File Offset: 0x011F7020
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M918_Decathlon self_)
			{
				if (139656 - 8562 != 131095)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162154 - 370580 != -208425)
					{
						base..ctor();
						if (129224 - 67384 == 61840)
						{
							this.$self_$42531 = self_;
							if (283249 - 425368 != -142118)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009937 RID: 39223 RVA: 0x011F8EB8 File Offset: 0x011F70B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (53923 - 60838 != -6914)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_119;
					case 2:
						if (Game.mGameState == eGameState.Normal)
						{
							if (189394 - 455795 == -266400)
							{
								continue;
							}
							if (this.$self_$42531.rJynQwqUgee == eDecathonType.survivalField)
							{
								if (7656 - 169624 != -161968)
								{
									continue;
								}
								this.$self_$42531.SurvivalFieldDead();
								if (59204 - 265135 == -205930)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (275988 - 567583 != -291595)
						{
							continue;
						}
						goto IL_119;
					default:
						if (36733 - 103259 == -66525)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (279865 - 126029 != 153836);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_119:
				return false;
			}

			// Token: 0x06009938 RID: 39224 RVA: 0x011F8FF0 File Offset: 0x011F71F0
			internal static bool hO53tAVCcIOmXRFf1XPd()
			{
				return true;
			}

			// Token: 0x06009939 RID: 39225 RVA: 0x011F8FF4 File Offset: 0x011F71F4
			internal static bool wYUtuiVCUvqaIa9lyBNl()
			{
				return false;
			}

			// Token: 0x04008DDC RID: 36316
			internal M918_Decathlon $self_$42531;
		}
	}

	// Token: 0x020019B1 RID: 6577
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$42533 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600993A RID: 39226 RVA: 0x011F8FF8 File Offset: 0x011F71F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$42533(Hashtable data, M918_Decathlon self_)
		{
			if (84088 - 383532 != -299444)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (3613 - 183267 != -179653)
				{
					base..ctor();
					if (191541 - 24314 == 167227)
					{
						this.$data$42538 = data;
						if (219915 - 333757 == -113842)
						{
							this.$self_$42539 = self_;
							if (46611 - 499702 != -453090)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600993B RID: 39227 RVA: 0x011F90B4 File Offset: 0x011F72B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M918_Decathlon.$onChangePlayer$42533.$(this.$data$42538, this.$self_$42539);
		}

		// Token: 0x0600993C RID: 39228 RVA: 0x011F90C8 File Offset: 0x011F72C8
		internal static bool ai2B8GVCThVYuhmLQP9U()
		{
			return true;
		}

		// Token: 0x0600993D RID: 39229 RVA: 0x011F90CC File Offset: 0x011F72CC
		internal static bool ImnoB8VC3akPHpDi7ZXR()
		{
			return false;
		}

		// Token: 0x04008DDD RID: 36317
		internal Hashtable $data$42538;

		// Token: 0x04008DDE RID: 36318
		internal M918_Decathlon $self_$42539;

		// Token: 0x020019B2 RID: 6578
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600993E RID: 39230 RVA: 0x011F90D0 File Offset: 0x011F72D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M918_Decathlon self_)
			{
				if (17645 - 179168 != -161522)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (248233 - 395350 != -147116)
					{
						base..ctor();
						if (134542 - 140733 != -6190)
						{
							this.$data$42536 = data;
							if (148005 - 280179 == -132174)
							{
								this.$self_$42537 = self_;
								if (265908 - 595427 != -329518)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600993F RID: 39231 RVA: 0x011F918C File Offset: 0x011F738C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (28157 - 15161 != 12997)
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
							if (60263 - 102987 == -42723)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (282615 - 385196 == -102580)
							{
								continue;
							}
							this.$mGameGui$42535 = (GameGui)this.$self_$42537.GetComponent(typeof(GameGui));
							if (108624 - 592399 == -483774)
							{
								continue;
							}
							this.$mGameGui$42535.enabled = true;
							if (96638 - 311550 != -214912)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (228538 - 96312 != 132227)
						{
							goto IL_205;
						}
						continue;
					default:
						if (48936 - 23403 == 25534)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (251605 - 556995 == -305390)
					{
						this.$self_$42537.SendMessage("onCreatePlayer", this.$data$42536);
						if (298128 - 323425 != -25296)
						{
							this.$mChangeGui$42534 = (ChangeGui)this.$self_$42537.GetComponent(typeof(ChangeGui));
							if (154911 - 156845 != -1933)
							{
								if (!this.$mChangeGui$42534.enabled)
								{
									break;
								}
								if (72770 - 142293 != -69522)
								{
									this.$mChangeGui$42534.close();
									if (145810 - 311397 != -165586)
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

			// Token: 0x06009940 RID: 39232 RVA: 0x011F93B0 File Offset: 0x011F75B0
			internal static bool UGm8lGVCXdqKvUXRcPQE()
			{
				return true;
			}

			// Token: 0x06009941 RID: 39233 RVA: 0x011F93B4 File Offset: 0x011F75B4
			internal static bool UbUIyKVCQUr604oJSumo()
			{
				return false;
			}

			// Token: 0x04008DDF RID: 36319
			internal ChangeGui $mChangeGui$42534;

			// Token: 0x04008DE0 RID: 36320
			internal GameGui $mGameGui$42535;

			// Token: 0x04008DE1 RID: 36321
			internal Hashtable $data$42536;

			// Token: 0x04008DE2 RID: 36322
			internal M918_Decathlon $self_$42537;
		}
	}

	// Token: 0x020019B3 RID: 6579
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42540 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009942 RID: 39234 RVA: 0x011F93B8 File Offset: 0x011F75B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42540(Hashtable data, M918_Decathlon self_)
		{
			if (20925 - 137540 != -116614)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179382 - 187809 == -8427)
				{
					base..ctor();
					if (230362 - 470126 != -239763)
					{
						this.$data$42548 = data;
						if (258348 - 305532 == -47184)
						{
							this.$self_$42549 = self_;
							if (245248 - 385278 == -140030)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009943 RID: 39235 RVA: 0x011F9474 File Offset: 0x011F7674
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M918_Decathlon.$onGameComplete$42540.$(this.$data$42548, this.$self_$42549);
		}

		// Token: 0x06009944 RID: 39236 RVA: 0x011F9488 File Offset: 0x011F7688
		internal static bool QGpaNHVCkUJXulcI00a4()
		{
			return true;
		}

		// Token: 0x06009945 RID: 39237 RVA: 0x011F948C File Offset: 0x011F768C
		internal static bool zT6BCYVCGZb1MwFqI6it()
		{
			return false;
		}

		// Token: 0x04008DE3 RID: 36323
		internal Hashtable $data$42548;

		// Token: 0x04008DE4 RID: 36324
		internal M918_Decathlon $self_$42549;

		// Token: 0x020019B4 RID: 6580
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009946 RID: 39238 RVA: 0x011F9490 File Offset: 0x011F7690
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M918_Decathlon self_)
			{
				if (67369 - 301876 != -234507)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (156351 - 201357 == -45006)
					{
						base..ctor();
						if (40879 - 592904 == -552025)
						{
							this.$data$42546 = data;
							if (2761 - 112550 == -109789)
							{
								this.$self_$42547 = self_;
								if (41436 - 589033 != -547596)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009947 RID: 39239 RVA: 0x011F954C File Offset: 0x011F774C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (33715 - 408461 != -374746)
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
						this.$mCompleteGui$42542 = (CompleteGui)this.$self_$42547.GetComponent(typeof(CompleteGui));
						if (73834 - 580814 == -506979)
						{
							continue;
						}
						this.$mCompleteGui$42542.Init();
						if (133103 - 159719 == -26615)
						{
							continue;
						}
						this.$mCompleteGui$42542.readData(this.$data$42546);
						if (164091 - 214286 == -50194)
						{
							continue;
						}
						if (this.$result$42541 == 1)
						{
							if (252964 - 245477 == 7488)
							{
								continue;
							}
							this.$mCompleteGui$42542.displayResult(eCompleteType.Success);
							if (206271 - 300495 == -94223)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42542.displayResult(eCompleteType.Failed);
							if (258535 - 170520 == 88016)
							{
								continue;
							}
						}
						this.$mGameGui$42543 = (GameGui)this.$self_$42547.GetComponent(typeof(GameGui));
						if (123120 - 214512 == -91391)
						{
							continue;
						}
						this.$mStoryGui$42544 = (StoryGui)this.$self_$42547.GetComponent(typeof(StoryGui));
						if (203253 - 163366 == 39888)
						{
							continue;
						}
						this.$mChangeGui$42545 = (ChangeGui)this.$self_$42547.GetComponent(typeof(ChangeGui));
						if (3167 - 85149 == -81981)
						{
							continue;
						}
						if (this.$mGameGui$42543)
						{
							if (23330 - 414269 != -390939)
							{
								continue;
							}
							this.$mGameGui$42543.close();
							if (230279 - 343660 == -113380)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42544)
						{
							if (70036 - 576313 == -506276)
							{
								continue;
							}
							this.$mStoryGui$42544.close();
							if (247135 - 572483 == -325347)
							{
								continue;
							}
						}
						if (this.$mChangeGui$42545)
						{
							if (265109 - 100571 == 164539)
							{
								continue;
							}
							this.$mChangeGui$42545.disable();
							if (244775 - 533849 != -289074)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (206943 - 227684 != -20741)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (157717 - 412885 == -255167)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42546[31]);
					if (284134 - 511114 != -226979)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (27099 - 198653 != -171553)
							{
								goto Block_26;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (46536 - 117187 != -70650)
							{
								this.$result$42541 = RuntimeServices.UnboxInt32(this.$data$42546[31]);
								if (79327 - 476414 != -397086)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_26:
				IL_3DB:
				return false;
			}

			// Token: 0x06009948 RID: 39240 RVA: 0x011F9948 File Offset: 0x011F7B48
			internal static bool NYe3S6VCHrZKyoNC7lp2()
			{
				return true;
			}

			// Token: 0x06009949 RID: 39241 RVA: 0x011F994C File Offset: 0x011F7B4C
			internal static bool x64aHTVCWsVOA6yG7OQo()
			{
				return false;
			}

			// Token: 0x04008DE5 RID: 36325
			internal int $result$42541;

			// Token: 0x04008DE6 RID: 36326
			internal CompleteGui $mCompleteGui$42542;

			// Token: 0x04008DE7 RID: 36327
			internal GameGui $mGameGui$42543;

			// Token: 0x04008DE8 RID: 36328
			internal StoryGui $mStoryGui$42544;

			// Token: 0x04008DE9 RID: 36329
			internal ChangeGui $mChangeGui$42545;

			// Token: 0x04008DEA RID: 36330
			internal Hashtable $data$42546;

			// Token: 0x04008DEB RID: 36331
			internal M918_Decathlon $self_$42547;
		}
	}

	// Token: 0x020019B5 RID: 6581
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42550 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600994A RID: 39242 RVA: 0x011F9950 File Offset: 0x011F7B50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42550(M918_Decathlon self_)
		{
			if (267218 - 497160 != -229941)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (155435 - 197249 != -41813)
				{
					base..ctor();
					if (105572 - 462890 != -357317)
					{
						this.$self_$42554 = self_;
						if (237456 - 88750 == 148706)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600994B RID: 39243 RVA: 0x011F99E8 File Offset: 0x011F7BE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M918_Decathlon.$ReturnToTown$42550.$(this.$self_$42554);
		}

		// Token: 0x0600994C RID: 39244 RVA: 0x011F99F8 File Offset: 0x011F7BF8
		internal static bool FdHnNmVCA5aMRJTAhXWn()
		{
			return true;
		}

		// Token: 0x0600994D RID: 39245 RVA: 0x011F99FC File Offset: 0x011F7BFC
		internal static bool dN0iTFVClXdJcos9jDbo()
		{
			return false;
		}

		// Token: 0x04008DEC RID: 36332
		internal M918_Decathlon $self_$42554;

		// Token: 0x020019B6 RID: 6582
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600994E RID: 39246 RVA: 0x011F9A00 File Offset: 0x011F7C00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M918_Decathlon self_)
			{
				if (130770 - 34859 != 95912)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (151688 - 206025 == -54337)
					{
						base..ctor();
						if (250641 - 494221 == -243580)
						{
							this.$self_$42553 = self_;
							if (72973 - 539257 == -466284)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600994F RID: 39247 RVA: 0x011F9A98 File Offset: 0x011F7C98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (245449 - 85541 != 159909)
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
						this.$self_$42553.LeaveGame();
						if (17976 - 39266 != -21290)
						{
							continue;
						}
						this.YieldDefault(1);
						if (224743 - 22841 != 201902)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (296842 - 424889 == -128046)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (48104 - 393104 != -344999)
					{
						Game.mStateTime = Time.time;
						if (79134 - 36572 != 42563)
						{
							this.$$switch$7711$42551 = PlayerData.SaveGuild;
							if (65118 - 179352 != -114233)
							{
								if (this.$$switch$7711$42551 == 1)
								{
									if (68473 - 314192 != -245719)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (237372 - 300958 != -63586)
									{
										continue;
									}
								}
								else if (this.$$switch$7711$42551 == 2)
								{
									if (271924 - 200391 == 71534)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (293210 - 165196 != 128014)
									{
										continue;
									}
								}
								else if (this.$$switch$7711$42551 == 3)
								{
									if (33905 - 150527 == -116621)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (100026 - 146212 != -46186)
									{
										continue;
									}
								}
								else if (this.$$switch$7711$42551 == 4)
								{
									if (269672 - 248592 != 21080)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (91389 - 218150 == -126760)
									{
										continue;
									}
								}
								else if (this.$$switch$7711$42551 == 5)
								{
									if (75574 - 560564 != -484990)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (211592 - 58335 == 153258)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (288871 - 139502 != 149369)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (167491 - 266565 == -99073)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (43144 - 478282 == -435137)
									{
										continue;
									}
								}
								this.$mGameGui$42552 = (GameGui)this.$self_$42553.GetComponent(typeof(GameGui));
								if (194450 - 22980 != 171471)
								{
									if (this.$mGameGui$42552)
									{
										if (82864 - 337536 == -254671)
										{
											continue;
										}
										this.$mGameGui$42552.close();
										if (246329 - 87002 != 159327)
										{
											continue;
										}
									}
									this.$self_$42553.SendMessage("fadeOut");
									if (75054 - 37424 == 37630)
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

			// Token: 0x06009950 RID: 39248 RVA: 0x011F9E64 File Offset: 0x011F8064
			internal static bool LPC3YAVCys4Ymwd4liXQ()
			{
				return true;
			}

			// Token: 0x06009951 RID: 39249 RVA: 0x011F9E68 File Offset: 0x011F8068
			internal static bool BHy4KKVCSUEV6YeyWYqm()
			{
				return false;
			}

			// Token: 0x04008DED RID: 36333
			internal int $$switch$7711$42551;

			// Token: 0x04008DEE RID: 36334
			internal GameGui $mGameGui$42552;

			// Token: 0x04008DEF RID: 36335
			internal M918_Decathlon $self_$42553;
		}
	}

	// Token: 0x020019B7 RID: 6583
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42555 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009952 RID: 39250 RVA: 0x011F9E6C File Offset: 0x011F806C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42555(M918_Decathlon self_)
		{
			if (1145 - 101829 != -100684)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (170095 - 153058 == 17037)
				{
					base..ctor();
					if (83726 - 585127 == -501401)
					{
						this.$self_$42558 = self_;
						if (26285 - 456170 == -429885)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009953 RID: 39251 RVA: 0x011F9F04 File Offset: 0x011F8104
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M918_Decathlon.$ReturnToGuild$42555.$(this.$self_$42558);
		}

		// Token: 0x06009954 RID: 39252 RVA: 0x011F9F14 File Offset: 0x011F8114
		internal static bool sFEhBdVCo2JLYcZcmuJD()
		{
			return true;
		}

		// Token: 0x06009955 RID: 39253 RVA: 0x011F9F18 File Offset: 0x011F8118
		internal static bool inKOr1VCEhDTJATDvvpZ()
		{
			return false;
		}

		// Token: 0x04008DF0 RID: 36336
		internal M918_Decathlon $self_$42558;

		// Token: 0x020019B8 RID: 6584
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009956 RID: 39254 RVA: 0x011F9F1C File Offset: 0x011F811C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M918_Decathlon self_)
			{
				if (261261 - 198282 != 62980)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (290553 - 381278 != -90724)
					{
						base..ctor();
						if (64659 - 157227 != -92567)
						{
							this.$self_$42557 = self_;
							if (76146 - 72117 == 4029)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009957 RID: 39255 RVA: 0x011F9FB4 File Offset: 0x011F81B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (221014 - 204807 != 16207)
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
						this.$self_$42557.LeaveGame();
						if (208658 - 138195 == 70464)
						{
							continue;
						}
						this.YieldDefault(1);
						if (205368 - 253529 != -48161)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (21296 - 238166 == -216869)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (129024 - 73368 != 55657)
					{
						Game.mStateTime = Time.time;
						if (279989 - 185445 == 94544)
						{
							Game.mNextGameCode = 31;
							if (172529 - 57512 != 115018)
							{
								this.$mGameGui$42556 = (GameGui)this.$self_$42557.GetComponent(typeof(GameGui));
								if (199829 - 575959 == -376130)
								{
									if (this.$mGameGui$42556)
									{
										if (51133 - 401074 != -349941)
										{
											continue;
										}
										this.$mGameGui$42556.close();
										if (98949 - 257604 != -158655)
										{
											continue;
										}
									}
									this.$self_$42557.SendMessage("fadeOut");
									if (62510 - 72897 == -10387)
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

			// Token: 0x06009958 RID: 39256 RVA: 0x011FA190 File Offset: 0x011F8390
			internal static bool ly8qi3VC2w7L3jwgwdJ6()
			{
				return true;
			}

			// Token: 0x06009959 RID: 39257 RVA: 0x011FA194 File Offset: 0x011F8394
			internal static bool qs3ob4VC8tG1pIwm9Ofa()
			{
				return false;
			}

			// Token: 0x04008DF1 RID: 36337
			internal GameGui $mGameGui$42556;

			// Token: 0x04008DF2 RID: 36338
			internal M918_Decathlon $self_$42557;
		}
	}

	// Token: 0x020019B9 RID: 6585
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42559 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600995A RID: 39258 RVA: 0x011FA198 File Offset: 0x011F8398
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42559(M918_Decathlon self_)
		{
			if (66984 - 18815 != 48170)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (59499 - 181932 == -122433)
				{
					base..ctor();
					if (204497 - 418597 != -214099)
					{
						this.$self_$42563 = self_;
						if (160947 - 108465 != 52483)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600995B RID: 39259 RVA: 0x011FA230 File Offset: 0x011F8430
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M918_Decathlon.$ReturnToCamp$42559.$(this.$self_$42563);
		}

		// Token: 0x0600995C RID: 39260 RVA: 0x011FA240 File Offset: 0x011F8440
		internal static bool fyZBVBVCZTlRPEewj70P()
		{
			return true;
		}

		// Token: 0x0600995D RID: 39261 RVA: 0x011FA244 File Offset: 0x011F8444
		internal static bool ApkrDgVCCO4iKoZaJfeQ()
		{
			return false;
		}

		// Token: 0x04008DF3 RID: 36339
		internal M918_Decathlon $self_$42563;

		// Token: 0x020019BA RID: 6586
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600995E RID: 39262 RVA: 0x011FA248 File Offset: 0x011F8448
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M918_Decathlon self_)
			{
				if (178081 - 357653 != -179572)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (9817 - 98870 == -89053)
					{
						base..ctor();
						if (273198 - 537768 != -264569)
						{
							this.$self_$42562 = self_;
							if (271089 - 15682 == 255407)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600995F RID: 39263 RVA: 0x011FA2E0 File Offset: 0x011F84E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (191061 - 444279 != -253217)
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
						this.$self_$42562.LeaveGame();
						if (160288 - 304647 == -144358)
						{
							continue;
						}
						this.YieldDefault(1);
						if (219158 - 20347 != 198811)
						{
							continue;
						}
						goto IL_363;
					default:
						if (108415 - 414772 != -306357)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (219004 - 581292 != -362287)
					{
						Game.mStateTime = Time.time;
						if (86857 - 529270 == -442413)
						{
							this.$$switch$7713$42560 = PlayerData.SaveGuild;
							if (54345 - 352127 != -297781)
							{
								if (this.$$switch$7713$42560 == 1)
								{
									if (79962 - 348826 != -268864)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (125407 - 484206 != -358799)
									{
										continue;
									}
								}
								else if (this.$$switch$7713$42560 == 2)
								{
									if (82519 - 117049 != -34530)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (80905 - 202874 == -121968)
									{
										continue;
									}
								}
								else if (this.$$switch$7713$42560 == 3)
								{
									if (145156 - 261332 != -116176)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (46365 - 417838 == -371472)
									{
										continue;
									}
								}
								else if (this.$$switch$7713$42560 == 4)
								{
									if (189555 - 8983 != 180572)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (90236 - 552705 != -462469)
									{
										continue;
									}
								}
								else if (this.$$switch$7713$42560 == 5)
								{
									if (85895 - 602 == 85294)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (28333 - 114557 == -86223)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (245382 - 387707 == -142324)
									{
										continue;
									}
								}
								this.$mGameGui$42561 = (GameGui)this.$self_$42562.GetComponent(typeof(GameGui));
								if (261228 - 100339 == 160889)
								{
									if (this.$mGameGui$42561)
									{
										if (235838 - 167306 != 68532)
										{
											continue;
										}
										this.$mGameGui$42561.close();
										if (94397 - 234396 == -139998)
										{
											continue;
										}
									}
									this.$self_$42562.SendMessage("fadeOut");
									if (131465 - 180287 != -48821)
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

			// Token: 0x06009960 RID: 39264 RVA: 0x011FA664 File Offset: 0x011F8864
			internal static bool rkfHuCVCLFGKcdZTQvkM()
			{
				return true;
			}

			// Token: 0x06009961 RID: 39265 RVA: 0x011FA668 File Offset: 0x011F8868
			internal static bool H5s7YIVCO8NYhXBbZ8rL()
			{
				return false;
			}

			// Token: 0x04008DF4 RID: 36340
			internal int $$switch$7713$42560;

			// Token: 0x04008DF5 RID: 36341
			internal GameGui $mGameGui$42561;

			// Token: 0x04008DF6 RID: 36342
			internal M918_Decathlon $self_$42562;
		}
	}
}
