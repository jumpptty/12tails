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

// Token: 0x02001CA5 RID: 7333
[Serializable]
public class M968_RoadToWorldCup : MonoBehaviour
{
	// Token: 0x0600AB72 RID: 43890 RVA: 0x01314CA8 File Offset: 0x01312EA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M968_RoadToWorldCup()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600AB73 RID: 43891 RVA: 0x01314CB8 File Offset: 0x01312EB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (25359 - 510187 != -484828)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (85649 - 158350 != -72700)
			{
				Game.mGameType = 5;
				if (77683 - 433934 == -356251)
				{
					if (Chat.Initialized)
					{
						if (137136 - 240583 == -103446)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (112621 - 87846 != 24775)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (290189 - 156050 == 134140)
						{
							continue;
						}
					}
					this.jJAnvZdsf7o = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (17758 - 595787 == -578029)
					{
						this.v6wnvCNZqd7 = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
						if (247169 - 541250 != -294080)
						{
							this.itRnvMI2iUM = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
							if (277335 - 244892 == 32443)
							{
								this.JbZnvfgJvp1 = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
								if (39474 - 324030 == -284556)
								{
									this.eegnvLf0544 = (Texture)Resources.Load("GameGui/Title/goal", typeof(Texture));
									if (34909 - 165171 != -130261)
									{
										this.L8QnvwTyjcP = (AudioClip)Resources.Load("Sound/GUI/missionBattle", typeof(AudioClip));
										if (254850 - 347299 == -92449)
										{
											this.zcNnvUUvme9 = (AudioClip)Resources.Load("Sound/GUI/missionCount", typeof(AudioClip));
											if (102296 - 170608 != -68311)
											{
												this.dNsnvNIcfsf = (AudioClip)Resources.Load("Sound/GUI/whistle", typeof(AudioClip));
												if (101801 - 208300 == -106499)
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

	// Token: 0x0600AB74 RID: 43892 RVA: 0x01314F64 File Offset: 0x01313164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (163301 - 411125 != -247823)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (140416 - 118778 == 21638)
				{
					if (Game.mNextGameCode != 968)
					{
						break;
					}
					if (251469 - 121603 == 129866)
					{
						Game.nextGame();
						if (122119 - 32744 != 89376)
						{
							Game.mGameCode = 968;
							if (233219 - 13128 != 220092)
							{
								Game.mGameType = 5;
								if (84943 - 345040 == -260097)
								{
									Game.mGameTime = Time.time;
									if (104915 - 563490 != -458574)
									{
										Game.mGameScore = 0;
										if (51223 - 177109 == -125886)
										{
											Game.mGameMana = 0;
											if (162495 - 35652 == 126843)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (236863 - 30000 == 206863)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (5039 - 119969 == -114930)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (190884 - 452569 != -261684)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (40108 - 365169 == -325061)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (88777 - 392931 == -304154)
																{
																	this.iD0nvH0gkS8 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (156451 - 455254 != -298802)
																	{
																		this.VZ3nvsDAHbh = PhotonClient.Connection;
																		if (81464 - 475420 != -393955)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (3701 - 240823 == -237122)
																			{
																				this.InitGame();
																				if (73674 - 285456 != -211781)
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
				if (276596 - 89903 != 186694)
				{
					Game.mGameType = 99;
					if (293851 - 104714 != 189138)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AB75 RID: 43893 RVA: 0x0131526C File Offset: 0x0131346C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (30145 - 327413 != -297267)
		{
		}
		for (;;)
		{
			if (this.VZ3nvsDAHbh == null)
			{
				if (38970 - 571372 != -532401)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (21797 - 135003 == -113206)
				{
					if (mGameState == eGameState.Init)
					{
						if (14170 - 494032 == -479862)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (128761 - 518405 != -389643)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (180078 - 579099 != -399020)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (136473 - 432051 != -295577)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (53949 - 567633 == -513684)
						{
							if (Game.music != 0)
							{
								if (155726 - 527973 != -372247)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (266315 - 266731 != -416)
									{
										continue;
									}
									this.audio.Play();
									if (170075 - 296216 != -126141)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (185650 - 10280 != 175371)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (172052 - 257456 != -85403)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (23885 - 31738 != -7852)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (121 - 63425 == -63304)
						{
							if (Time.time > Game.mGameTime + (float)540)
							{
								if (193289 - 280716 != -87426)
								{
									this.StartCoroutine_Auto(this.TimeUpEvent());
									if (252060 - 576152 != -324091)
									{
										break;
									}
								}
							}
							else
							{
								if (Time.time <= this.OcAnv7hK1tL)
								{
									break;
								}
								if (223242 - 495976 == -272734)
								{
									Game.mGameMana++;
									if (203287 - 43018 == 160269)
									{
										this.OcAnv7hK1tL = Time.time + (float)12;
										if (28970 - 268773 != -239802)
										{
											break;
										}
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (2673 - 516316 == -513643)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (60074 - 265681 == -205607)
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
						if (264782 - 471236 == -206454)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB76 RID: 43894 RVA: 0x01315644 File Offset: 0x01313844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (179217 - 519215 != -339998)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (225801 - 107471 == 118330)
			{
				float num = (float)1;
				if (5689 - 417468 == -411779)
				{
					float num2 = (float)(1024 * Screen.width / Screen.height);
					if (138117 - 389443 != -251325)
					{
						GUI.depth = 1;
						if (39861 - 426094 == -386233)
						{
							eGameState mGameState = Game.mGameState;
							if (248769 - 546943 != -298173)
							{
								if (mGameState == eGameState.Start)
								{
									if (157142 - 54508 == 102635)
									{
										continue;
									}
									if (this.dINnvEOgCDs == 1)
									{
										if (84363 - 660 == 83704)
										{
											continue;
										}
										if (Time.time - Game.mStateTime < (float)1)
										{
											if (67954 - 351205 != -283250)
											{
												break;
											}
											continue;
										}
										else if (Time.time - Game.mStateTime < (float)2)
										{
											if (122270 - 430375 != -308105)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)1);
											if (259539 - 15173 != 244366)
											{
												continue;
											}
											float a = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)1);
											if (278937 - 582725 != -303788)
											{
												continue;
											}
											Color color = GUI.color;
											if (54658 - 579941 == -525282)
											{
												continue;
											}
											float num3 = color.a = a;
											if (264936 - 560062 == -295125)
											{
												continue;
											}
											if (276780 - 405528 != -128748)
											{
												continue;
											}
											Color color2 = GUI.color = color;
											if (256527 - 176894 != 79633)
											{
												continue;
											}
											if (16675 - 557009 != -540334)
											{
												continue;
											}
											if (this.JbZnvfgJvp1)
											{
												if (109788 - 311660 == -201871)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.JbZnvfgJvp1);
												if (136901 - 197095 == -60193)
												{
													continue;
												}
											}
										}
										else if (Time.time - Game.mStateTime < (float)3)
										{
											if (254653 - 134566 == 120088)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)2);
											if (65655 - 337483 != -271828)
											{
												continue;
											}
											float a2 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)2);
											if (243739 - 455776 != -212037)
											{
												continue;
											}
											Color color3 = GUI.color;
											if (75985 - 230954 != -154969)
											{
												continue;
											}
											float num4 = color3.a = a2;
											if (139169 - 332023 == -192853)
											{
												continue;
											}
											if (62186 - 192909 != -130723)
											{
												continue;
											}
											GUI.color = color3;
											if (78859 - 565729 != -486870)
											{
												continue;
											}
											if (129499 - 276363 != -146864)
											{
												continue;
											}
											if (this.itRnvMI2iUM)
											{
												if (69136 - 206677 != -137541)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.itRnvMI2iUM);
												if (167000 - 182361 == -15360)
												{
													continue;
												}
											}
										}
										else if (Time.time - Game.mStateTime < (float)4)
										{
											if (111752 - 516927 == -405174)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)3);
											if (298860 - 159739 != 139121)
											{
												continue;
											}
											float a3 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)3);
											if (241296 - 26472 != 214824)
											{
												continue;
											}
											Color color4 = GUI.color;
											if (157578 - 25724 == 131855)
											{
												continue;
											}
											color4.a = a3;
											if (172856 - 397379 == -224522 || 80606 - 520403 == -439796)
											{
												continue;
											}
											GUI.color = color4;
											if (79686 - 155539 == -75852)
											{
												continue;
											}
											if (41448 - 367392 != -325944)
											{
												continue;
											}
											if (this.v6wnvCNZqd7)
											{
												if (280087 - 132316 == 147772)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.v6wnvCNZqd7);
												if (111794 - 378998 != -267204)
												{
													continue;
												}
											}
										}
									}
								}
								else if (mGameState == eGameState.Normal)
								{
									if (265352 - 342242 == -76889)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)2)
									{
										if (273279 - 267623 != 5656)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
										if (5474 - 289919 != -284445)
										{
											continue;
										}
										if (Time.time - Game.mStateTime < 0.2f)
										{
											if (31242 - 153878 == -122635)
											{
												continue;
											}
											float a4 = Mathf.SmoothStep((float)0, (float)1, (float)5 * Time.time - Game.mStateTime);
											if (107856 - 3201 != 104655)
											{
												continue;
											}
											Color color5 = GUI.color;
											if (299771 - 560691 == -260919)
											{
												continue;
											}
											float num5 = color5.a = a4;
											if (55058 - 375799 == -320740)
											{
												continue;
											}
											if (12894 - 582562 != -569668)
											{
												continue;
											}
											GUI.color = color5;
											if (46228 - 101719 != -55491)
											{
												continue;
											}
											if (157160 - 128587 != 28573)
											{
												continue;
											}
										}
										else
										{
											float a5 = Mathf.SmoothStep((float)1, (float)0, 1.25f * (Time.time - Game.mStateTime - 0.2f));
											if (80783 - 82280 == -1496)
											{
												continue;
											}
											Color color6 = GUI.color;
											if (84421 - 277709 != -193288)
											{
												continue;
											}
											color6.a = a5;
											if (207977 - 395892 != -187915)
											{
												continue;
											}
											if (237118 - 416868 == -179749)
											{
												continue;
											}
											GUI.color = color6;
											if (79019 - 118392 == -39372 || 134634 - 153185 == -18550)
											{
												continue;
											}
										}
										if (this.jJAnvZdsf7o)
										{
											if (100152 - 142915 == -42762)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.jJAnvZdsf7o);
											if (95259 - 416625 != -321366)
											{
												continue;
											}
										}
									}
								}
								else if (mGameState == eGameState.Hold)
								{
									if (81818 - 209654 == -127835)
									{
										continue;
									}
									if (this.lkknv8HG4gs > Time.time)
									{
										if (53102 - 538114 != -485012)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, 1.5f, Time.time - this.lkknv8HG4gs);
										if (134377 - 514367 == -379989)
										{
											continue;
										}
										float a6 = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - this.lkknv8HG4gs, (float)1));
										if (33832 - 122552 != -88720)
										{
											continue;
										}
										Color color7 = GUI.color;
										if (98710 - 447545 == -348834)
										{
											continue;
										}
										color7.a = a6;
										if (63052 - 445169 != -382117)
										{
											continue;
										}
										if (9552 - 194646 != -185094)
										{
											continue;
										}
										GUI.color = color7;
										if (81212 - 282688 == -201475 || 14381 - 78302 == -63920)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(0.5f * num2 - 252f * num, (float)450 - 75f * num, (float)504 * num, (float)150 * num), this.eegnvLf0544);
										if (46469 - 17555 != 28914)
										{
											continue;
										}
									}
								}
								float a7 = 1f;
								if (179007 - 312479 != -133471)
								{
									Color color8 = GUI.color;
									if (146032 - 531723 != -385690)
									{
										float num6 = color8.a = a7;
										if (217378 - 104798 == 112580)
										{
											if (282929 - 415584 != -132654)
											{
												Color color9 = GUI.color = color8;
												if (286738 - 271856 != 14883 && 117983 - 540872 != -422888)
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

	// Token: 0x0600AB77 RID: 43895 RVA: 0x01316278 File Offset: 0x01314478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (243957 - 443089 != -199132)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (216674 - 7690 != 208985)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (139155 - 539468 == -400313)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (8208 - 315418 == -307210)
					{
						int uid = RuntimeServices.UnboxInt32(data[43]);
						if (81235 - 171696 != -90460)
						{
							int num3 = num;
							if (221793 - 246408 != -24614)
							{
								if (num3 == 9681)
								{
									if (102842 - 563746 != -460903)
									{
										if (this.dINnvEOgCDs >= 1)
										{
											break;
										}
										if (256167 - 372680 == -116513)
										{
											this.dINnvEOgCDs = 1;
											if (190444 - 444996 != -254551)
											{
												this.StartCoroutine_Auto(this.StartEvent());
												if (240555 - 276435 != -35879)
												{
													break;
												}
											}
										}
									}
								}
								else if (num3 == 9682)
								{
									if (208732 - 187122 != 21611)
									{
										if (num2 == 1)
										{
											if (288040 - 425483 != -137443)
											{
												continue;
											}
											this.sosnvPxXK0R++;
											if (130748 - 453611 == -322862)
											{
												continue;
											}
										}
										else
										{
											this.Cb8nvSM0iZp++;
											if (186591 - 231228 == -44636)
											{
												continue;
											}
										}
										Chat.SubmitChat("none", Game.getPlayerName(uid) + " has joined team" + num2, eChatType.system, eChatMode.system);
										if (102279 - 8802 == 93477)
										{
											break;
										}
									}
								}
								else if (num3 == 9683)
								{
									if (183664 - 567374 != -383709)
									{
										if (num2 == 1)
										{
											if (175454 - 510439 == -334985)
											{
												this.StartCoroutine_Auto(this.GoalEvent(1));
												if (263693 - 412507 == -148814)
												{
													this.jPlnvBBRrRh++;
													if (12604 - 487387 != -474782)
													{
														this.mSmashScore1.animation.Play("score" + this.jPlnvBBRrRh);
														if (4897 - 9079 != -4181)
														{
															Chat.SubmitChat("none", "Team1 Score!:" + this.jPlnvBBRrRh + "/" + this.YGknv0MUvsa, eChatType.system, eChatMode.system);
															if (216977 - 494177 != -277199)
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
											if (num2 != 2)
											{
												break;
											}
											if (21956 - 340666 != -318709)
											{
												this.StartCoroutine_Auto(this.GoalEvent(2));
												if (8968 - 578126 == -569158)
												{
													this.YGknv0MUvsa++;
													if (242150 - 562855 == -320705)
													{
														this.mSmashScore2.animation.Play("score" + this.YGknv0MUvsa);
														if (284745 - 98309 != 186437)
														{
															Chat.SubmitChat("none", "Team2 Score!:" + this.jPlnvBBRrRh + "/" + this.YGknv0MUvsa, eChatType.system, eChatMode.system);
															if (5470 - 98815 == -93345)
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
									if (num3 != 9684)
									{
										break;
									}
									if (96185 - 2454 == 93731)
									{
										int num4 = num2;
										if (240120 - 147791 != 92330)
										{
											if (1 > num2)
											{
												break;
											}
											if (165400 - 282737 != -117336)
											{
												if (num2 > 10)
												{
													break;
												}
												if (79246 - 559560 != -480313)
												{
													GameObject gameObject = GameObject.Find("StartPoint" + num4);
													if (180477 - 89017 == 91460)
													{
														GameObject gameObject2 = GameObject.Find("Player" + num4);
														if (90618 - 507852 != -417233)
														{
															if (gameObject2)
															{
																if (8180 - 498700 == -490519)
																{
																	continue;
																}
																if (gameObject)
																{
																	if (59244 - 553540 == -494295)
																	{
																		continue;
																	}
																	gameObject2.transform.position = gameObject.transform.position;
																	if (176153 - 500818 == -324664)
																	{
																		continue;
																	}
																	CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
																	if (70865 - 81592 == -10726)
																	{
																		continue;
																	}
																	if (characterControl)
																	{
																		if (167717 - 274485 != -106768)
																		{
																			continue;
																		}
																		characterControl.reset();
																		if (209829 - 471340 != -261511)
																		{
																			continue;
																		}
																	}
																	GameObject gameObject3 = (GameObject)Resources.Load("GameAssets/Effects/Special/createTail", typeof(GameObject));
																	if (283225 - 104665 == 178561)
																	{
																		continue;
																	}
																	if (gameObject3)
																	{
																		if (4234 - 336681 == -332446)
																		{
																			continue;
																		}
																		UnityEngine.Object.Instantiate(gameObject3, gameObject2.transform.position, Quaternion.identity);
																		if (25650 - 597906 != -572256)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		Debug.Log("Cannot find respawnPlayer effect");
																		if (248250 - 511343 == -263092)
																		{
																			continue;
																		}
																	}
																	if (Game.mPlayer == gameObject2)
																	{
																		if (270272 - 330382 != -60110)
																		{
																			continue;
																		}
																		GameObject gameObject4 = GameObject.Find("StartCamera" + num4);
																		if (288384 - 70966 == 217419)
																		{
																			continue;
																		}
																		if (gameObject4)
																		{
																			if (276719 - 398037 == -121317)
																			{
																				continue;
																			}
																			this.transform.position = gameObject4.transform.position;
																			if (102528 - 395182 != -292654)
																			{
																				continue;
																			}
																			this.transform.rotation = gameObject4.transform.rotation;
																			if (268770 - 222741 != 46029)
																			{
																				continue;
																			}
																		}
																		Game.mGameState = eGameState.Normal;
																		if (270304 - 480391 == -210086)
																		{
																			continue;
																		}
																		GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
																		if (56034 - 336291 != -280257)
																		{
																			continue;
																		}
																		if (gameGui)
																		{
																			if (36417 - 430178 != -393761)
																			{
																				continue;
																			}
																			gameGui.enabled = true;
																			if (288828 - 272008 != 16820)
																			{
																				continue;
																			}
																			gameGui.closeDeadMenu();
																			if (251680 - 369441 != -117761)
																			{
																				continue;
																			}
																		}
																	}
																}
															}
															Debug.Log("Reviving Player" + num4);
															if (164221 - 283291 == -119070)
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

	// Token: 0x0600AB78 RID: 43896 RVA: 0x01316BAC File Offset: 0x01314DAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createTeamRing(GameObject nObject)
	{
		if (174525 - 415106 != -240580)
		{
		}
		for (;;)
		{
			GameObject gameObject = null;
			if (240608 - 125638 == 114970)
			{
				int layer = nObject.layer;
				if (134723 - 117562 != 17162)
				{
					if (layer == 8)
					{
						if (291978 - 143817 != 148161)
						{
							continue;
						}
						if (this.ring_team1)
						{
							if (115574 - 391216 == -275641)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team1, nObject.transform.position, Quaternion.identity);
							if (74212 - 375461 == -301248)
							{
								continue;
							}
						}
					}
					else if (layer == 9)
					{
						if (168224 - 108485 == 59740)
						{
							continue;
						}
						if (this.ring_team2)
						{
							if (177396 - 269865 == -92468)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team2, nObject.transform.position, Quaternion.identity);
							if (173607 - 10052 == 163556)
							{
								continue;
							}
						}
					}
					if (!gameObject)
					{
						break;
					}
					if (224255 - 7684 != 216572)
					{
						gameObject.transform.parent = nObject.transform;
						if (159244 - 495894 != -336649)
						{
							gameObject.transform.localPosition = Vector3.zero;
							if (170522 - 28666 == 141856)
							{
								if (!nObject.collider)
								{
									break;
								}
								if (134063 - 583358 != -449294)
								{
									gameObject.transform.localScale = Vector3.one * nObject.collider.bounds.size.z;
									if (173874 - 495133 != -321258)
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

	// Token: 0x0600AB79 RID: 43897 RVA: 0x01316E28 File Offset: 0x01315028
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setSoccerCollision(GameObject nObject)
	{
		if (124055 - 577736 != -453680)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SoccerCollision1");
			if (183718 - 53487 == 130231)
			{
				GameObject gameObject2 = GameObject.Find("SoccerCollision2");
				if (203016 - 72672 == 130344)
				{
					GameObject gameObject3 = GameObject.Find("SoccerCollision3");
					if (133829 - 119634 == 14195)
					{
						int layer = nObject.layer;
						if (212108 - 212147 != -38)
						{
							if (layer == 8)
							{
								if (48326 - 229695 != -181368)
								{
									Physics.IgnoreCollision(nObject.collider, gameObject2.collider, true);
									if (297778 - 148679 != 149100)
									{
										break;
									}
								}
							}
							else if (layer == 9)
							{
								if (63653 - 69150 != -5496)
								{
									Physics.IgnoreCollision(nObject.collider, gameObject.collider, true);
									if (283719 - 184999 != 98721)
									{
										break;
									}
								}
							}
							else
							{
								Physics.IgnoreCollision(nObject.collider, gameObject.collider, true);
								if (216313 - 338255 != -121941)
								{
									Physics.IgnoreCollision(nObject.collider, gameObject2.collider, true);
									if (291457 - 570840 == -279383)
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

	// Token: 0x0600AB7A RID: 43898 RVA: 0x01316FF4 File Offset: 0x013151F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M968_RoadToWorldCup.$StartEvent$44786(this).GetEnumerator();
	}

	// Token: 0x0600AB7B RID: 43899 RVA: 0x01317004 File Offset: 0x01315204
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator GoalEvent(object nTeamGoal)
	{
		return new M968_RoadToWorldCup.$GoalEvent$44789(nTeamGoal, this).GetEnumerator();
	}

	// Token: 0x0600AB7C RID: 43900 RVA: 0x01317014 File Offset: 0x01315214
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TimeUpEvent()
	{
		return new M968_RoadToWorldCup.$TimeUpEvent$44794(this).GetEnumerator();
	}

	// Token: 0x0600AB7D RID: 43901 RVA: 0x01317024 File Offset: 0x01315224
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSoccerGoal(int team)
	{
		if (255284 - 123933 != 131351)
		{
		}
		for (;;)
		{
			if (team == 1)
			{
				if (24429 - 264053 != -239623)
				{
					Game.sendMissionEvent(9683, 1);
					if (254796 - 26521 != 228276)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(9683, 2);
				if (63713 - 314200 != -250486)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600AB7E RID: 43902 RVA: 0x013170CC File Offset: 0x013152CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onOutOfBound()
	{
		this.SendMessage("newGameMessage", "Out of bound!");
		this.audio.PlayOneShot(this.mSmashWhistle);
	}

	// Token: 0x0600AB7F RID: 43903 RVA: 0x013170F0 File Offset: 0x013152F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (235481 - 224417 != 11064)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (182605 - 521811 != -339205)
			{
				Hashtable customOpParameters = new Hashtable();
				if (269146 - 553077 == -283931)
				{
					this.VZ3nvsDAHbh.OpCustom(52, customOpParameters, true);
					if (14652 - 430008 != -415355)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AB80 RID: 43904 RVA: 0x01317198 File Offset: 0x01315398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (241572 - 144474 != 97099)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (47701 - 460507 != -412805)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (187483 - 44100 == 143383)
				{
					Game.mGameState = eGameState.Setup;
					if (77667 - 146869 != -69201)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AB81 RID: 43905 RVA: 0x0131723C File Offset: 0x0131543C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (185029 - 65128 != 119902)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (290786 - 167370 != 123417)
			{
				if (num == PlayerData.UID)
				{
					if (218568 - 209517 != 9052)
					{
						this.SetupActors();
						if (44274 - 321477 != -277202)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (198582 - 417373 == -218791)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AB82 RID: 43906 RVA: 0x0131730C File Offset: 0x0131550C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (293926 - 412491 != -118565)
		{
		}
		for (;;)
		{
			IL_70:
			Debug.Log("Creating Actors");
			if (206872 - 458357 == -251485)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (35867 - 338523 == -302656)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (90735 - 319629 == -228894)
						{
							int i = 0;
							if (207761 - 341231 != -133469)
							{
								CharacterControl[] array2 = array;
								if (9503 - 543996 != -534492)
								{
									int length = array2.Length;
									if (86915 - 382854 == -295939)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (43128 - 131089 != -87961)
											{
												goto IL_70;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (282029 - 447151 == -165121)
											{
												goto IL_70;
											}
											this.qfBnviLkKR7++;
											if (94653 - 569231 != -474578)
											{
												goto IL_70;
											}
											i++;
											if (94535 - 99526 == -4990)
											{
												goto IL_70;
											}
										}
										if (37563 - 104717 != -67153)
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
						if (207428 - 599773 == -392345)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB83 RID: 43907 RVA: 0x01317524 File Offset: 0x01315724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (246401 - 589380 != -342978)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (68833 - 566215 != -497381)
			{
				Game.mGameState = eGameState.Ready;
				if (163399 - 203746 == -40347)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (231128 - 131061 != 100068 && 111143 - 186355 != -75211)
					{
						GameObject gameObject = null;
						if (3878 - 526008 != -522129)
						{
							if (playerSlot <= 1)
							{
								goto IL_69;
							}
							if (282050 - 327958 != -45908)
							{
								continue;
							}
							if (playerSlot > 10)
							{
								goto IL_69;
							}
							if (278552 - 251989 == 26564)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (219603 - 458965 != -239362)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (267757 - 280828 != -13071)
							{
								continue;
							}
							IL_3F:
							if (gameObject2)
							{
								if (135241 - 52858 != 82383)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, (playerSlot - 1) % 2 + 1, gameObject2.transform.position, gameObject2.transform.forward);
								if (4303 - 184215 == -179911)
								{
									continue;
								}
							}
							if (gameObject)
							{
								if (258745 - 448528 == -189782)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (163824 - 20358 == 143467)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (25421 - 452792 == -427370)
								{
									continue;
								}
							}
							if (playerSlot % 2 == 1)
							{
								if (254044 - 164439 != 89605)
								{
									continue;
								}
								Game.sendMissionEvent(9682, 1);
								if (236642 - 203347 != 33296)
								{
									break;
								}
								continue;
							}
							else
							{
								Game.sendMissionEvent(9682, 2);
								if (283001 - 155018 != 127984)
								{
									break;
								}
								continue;
							}
							IL_69:
							gameObject2 = GameObject.Find("StartPoint1");
							if (60108 - 125533 != -65424)
							{
								goto IL_3F;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB84 RID: 43908 RVA: 0x01317830 File Offset: 0x01315A30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M968_RoadToWorldCup.$StartGame$44797(this).GetEnumerator();
	}

	// Token: 0x0600AB85 RID: 43909 RVA: 0x01317840 File Offset: 0x01315A40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600AB86 RID: 43910 RVA: 0x01317844 File Offset: 0x01315A44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (22157 - 232793 != -210636)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (116887 - 117954 == -1067)
			{
				hashtable.Add(71, CID);
				if (41880 - 420479 == -378599)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (40221 - 541210 != -500988)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (189150 - 55107 != 134044)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (273019 - 31139 == 241880)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (82209 - 299381 != -217171)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (272776 - 358557 != -85780)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (111237 - 337835 != -226597)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (10413 - 130057 == -119644)
											{
												this.VZ3nvsDAHbh.OpCustom(61, hashtable, true);
												if (53720 - 117920 == -64200)
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

	// Token: 0x0600AB87 RID: 43911 RVA: 0x01317AD0 File Offset: 0x01315CD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (143037 - 448092 != -305055)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (226607 - 480683 != -254075)
			{
				if (!gameObject)
				{
					break;
				}
				if (100146 - 258081 != -157934)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (53830 - 493071 != -439240)
					{
						playerCameraControl.target = gameObject;
						if (232233 - 341897 != -109663)
						{
							this.createTeamRing(gameObject);
							if (268399 - 154726 != 113674)
							{
								this.setSoccerCollision(gameObject);
								if (272781 - 174478 == 98303)
								{
									this.StartCoroutine_Auto(this.StartGame());
									if (102297 - 341355 != -239057)
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

	// Token: 0x0600AB88 RID: 43912 RVA: 0x01317C08 File Offset: 0x01315E08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (293487 - 61512 != 231975)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPeer(data);
			if (131678 - 3928 != 127751)
			{
				if (gameObject)
				{
					if (192354 - 132599 != 59755)
					{
						continue;
					}
					this.createTeamRing(gameObject);
					if (2120 - 317887 == -315766)
					{
						continue;
					}
					this.setSoccerCollision(gameObject);
					if (138842 - 29863 == 108980)
					{
						continue;
					}
				}
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (37187 - 442890 == -405703)
				{
					gameGui.ResetTeamBar();
					if (261371 - 69843 != 191529)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AB89 RID: 43913 RVA: 0x01317D18 File Offset: 0x01315F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M968_RoadToWorldCup.$onDeadPlayer$44802(this).GetEnumerator();
	}

	// Token: 0x0600AB8A RID: 43914 RVA: 0x01317D28 File Offset: 0x01315F28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (254282 - 96146 != 158136)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (70024 - 13182 == 56842)
			{
				this.iD0nvH0gkS8.target = Game.mPlayer;
				if (85250 - 288341 != -203090)
				{
					this.iD0nvH0gkS8.enabled = true;
					if (146754 - 482228 == -335474)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (106585 - 566817 != -460232)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (230128 - 3388 == 226741)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (190593 - 234406 != -43812)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (36619 - 383758 == -347139)
							{
								if (!gameGui)
								{
									break;
								}
								if (288455 - 49674 == 238781)
								{
									gameGui.enabled = true;
									if (289951 - 116665 != 173287)
									{
										gameGui.closeDeadMenu();
										if (45531 - 430210 == -384679)
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

	// Token: 0x0600AB8B RID: 43915 RVA: 0x01317ED4 File Offset: 0x013160D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
		Game.sendMissionEvent(9684, Game.getPlayerSlot(PlayerData.UID));
	}

	// Token: 0x0600AB8C RID: 43916 RVA: 0x01317EF4 File Offset: 0x013160F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (175803 - 249689 != -73885)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
			{
				if (232625 - 278992 == -46367)
				{
					Game.mGameState = eGameState.Ended;
					if (64360 - 591419 != -527058)
					{
						break;
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.AllHold;
				if (147425 - 47295 == 100130)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600AB8D RID: 43917 RVA: 0x01317FAC File Offset: 0x013161AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (168818 - 90742 != 78077)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (24088 - 593059 == -568971)
			{
				hashtable.Add(43, PlayerData.UID);
				if (30209 - 292720 != -262510)
				{
					hashtable.Add(73, nType);
					if (3249 - 75697 == -72448)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (83983 - 249631 != -165647)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (172965 - 303495 != -130529)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (377 - 201335 == -200958)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (100389 - 452910 != -352520)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (69059 - 142203 == -73144)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (97163 - 57817 != 39347)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (32631 - 13605 != 19027)
												{
													this.VZ3nvsDAHbh.OpCustom(63, hashtable, true);
													if (20540 - 473037 != -452496)
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

	// Token: 0x0600AB8E RID: 43918 RVA: 0x01318264 File Offset: 0x01316464
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (141849 - 124973 != 16877)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (295550 - 524203 == -228653)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (86626 - 101073 != -14446)
				{
					if (gameObject)
					{
						if (125567 - 292497 != -166930)
						{
							continue;
						}
						this.createTeamRing(gameObject);
						if (94277 - 33896 != 60381)
						{
							continue;
						}
						this.setSoccerCollision(gameObject);
						if (214097 - 296841 == -82743)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (289016 - 492029 == -203013)
						{
							if (this.qfBnviLkKR7 <= 0)
							{
								break;
							}
							if (267253 - 51644 == 215609)
							{
								this.qfBnviLkKR7--;
								if (145071 - 551394 == -406323)
								{
									if (this.qfBnviLkKR7 != 0)
									{
										break;
									}
									if (150020 - 376981 == -226961)
									{
										Game.setGameState(eGameState.Ready);
										if (49565 - 321281 != -271715)
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
						if (64529 - 154653 == -90124)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (286752 - 168313 != 118440)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB8F RID: 43919 RVA: 0x0131845C File Offset: 0x0131665C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x0600AB90 RID: 43920 RVA: 0x01318460 File Offset: 0x01316660
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x0600AB91 RID: 43921 RVA: 0x01318464 File Offset: 0x01316664
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (199225 - 207998 != -8773)
		{
		}
		for (;;)
		{
			IL_36:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (297304 - 215831 == 81473)
			{
				int i = 0;
				if (96708 - 128461 == -31753)
				{
					CharacterControl[] array2 = array;
					if (121096 - 17922 == 103174)
					{
						int length = array2.Length;
						if (12632 - 457173 != -444540)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (4293 - 122080 != -117787)
								{
									goto IL_36;
								}
								i++;
								if (59364 - 298979 != -239615)
								{
									goto IL_36;
								}
							}
							if (238877 - 436461 == -197584)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB92 RID: 43922 RVA: 0x01318594 File Offset: 0x01316794
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSummon(GameObject nSummon)
	{
		this.createTeamRing(nSummon);
		this.setSoccerCollision(nSummon);
	}

	// Token: 0x0600AB93 RID: 43923 RVA: 0x013185A4 File Offset: 0x013167A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onTransform(GameObject nTransform)
	{
		this.createTeamRing(nTransform);
		this.setSoccerCollision(nTransform);
	}

	// Token: 0x0600AB94 RID: 43924 RVA: 0x013185B4 File Offset: 0x013167B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M968_RoadToWorldCup.$onGameComplete$44808(data, this).GetEnumerator();
	}

	// Token: 0x0600AB95 RID: 43925 RVA: 0x013185C4 File Offset: 0x013167C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M968_RoadToWorldCup.$ReturnToTown$44816(this).GetEnumerator();
	}

	// Token: 0x0600AB96 RID: 43926 RVA: 0x013185D4 File Offset: 0x013167D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M968_RoadToWorldCup.$ReturnToGuild$44821(this).GetEnumerator();
	}

	// Token: 0x0600AB97 RID: 43927 RVA: 0x013185E4 File Offset: 0x013167E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M968_RoadToWorldCup.$ReturnToCamp$44825(this).GetEnumerator();
	}

	// Token: 0x0600AB98 RID: 43928 RVA: 0x013185F4 File Offset: 0x013167F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (120811 - 486941 != -366130)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (273119 - 119562 != 153558)
			{
				Hashtable hashtable = new Hashtable();
				if (9951 - 372304 == -362353)
				{
					hashtable.Add(43, PlayerData.UID);
					if (60833 - 498339 == -437506)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (176672 - 555765 == -379093)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB99 RID: 43929 RVA: 0x013186CC File Offset: 0x013168CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600AB9A RID: 43930 RVA: 0x013186E0 File Offset: 0x013168E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (199097 - 145835 != 53262)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (35253 - 368230 != -332976)
			{
				Hashtable hashtable = new Hashtable();
				if (173420 - 93559 != 79862)
				{
					if (Game.mNextGameCode == 30)
					{
						if (196259 - 497262 == -301002)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (114094 - 26910 != 87184)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (289693 - 275254 != 14439)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (176256 - 460429 != -284173)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (52143 - 311620 == -259476)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (149578 - 398778 != -249200)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (128596 - 29444 != 99152)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (16092 - 306103 != -290011)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (149043 - 408525 == -259481)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (78211 - 176836 != -98625)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (44498 - 330804 != -286306)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (131440 - 344007 == -212566)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (292020 - 459860 == -167839)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (153250 - 592606 == -439355)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (292375 - 178099 != 114276)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (37114 - 50865 == -13750)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (74852 - 293787 != -218935)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (123215 - 396470 != -273255)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (259862 - 344957 == -85094)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (106563 - 283308 == -176744)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (172653 - 414806 != -242153)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (29380 - 112185 != -82805)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (239049 - 152188 == 86862)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (100508 - 279486 != -178978)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (289136 - 302347 == -13210)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (76021 - 225109 == -149087)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (228317 - 287027 != -58710)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (139476 - 44008 == 95469)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (174372 - 477828 == -303456)
					{
						this.VZ3nvsDAHbh.OpCustom(42, hashtable, true);
						if (287316 - 7189 == 280127)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AB9B RID: 43931 RVA: 0x01318C94 File Offset: 0x01316E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600AB9C RID: 43932 RVA: 0x01318CA4 File Offset: 0x01316EA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600AB9D RID: 43933 RVA: 0x01318CA8 File Offset: 0x01316EA8
	internal static bool Y8auAuVugnrC0uw3Kyhg()
	{
		return true;
	}

	// Token: 0x0600AB9E RID: 43934 RVA: 0x01318CAC File Offset: 0x01316EAC
	internal static bool RexrmxVufqrMF1ip9n0u()
	{
		return false;
	}

	// Token: 0x0400981E RID: 38942
	private LitePeer VZ3nvsDAHbh;

	// Token: 0x0400981F RID: 38943
	private PlayerCameraControl iD0nvH0gkS8;

	// Token: 0x04009820 RID: 38944
	private float OcAnv7hK1tL;

	// Token: 0x04009821 RID: 38945
	private Texture jJAnvZdsf7o;

	// Token: 0x04009822 RID: 38946
	private Texture v6wnvCNZqd7;

	// Token: 0x04009823 RID: 38947
	private Texture itRnvMI2iUM;

	// Token: 0x04009824 RID: 38948
	private Texture JbZnvfgJvp1;

	// Token: 0x04009825 RID: 38949
	private Texture eegnvLf0544;

	// Token: 0x04009826 RID: 38950
	private AudioClip L8QnvwTyjcP;

	// Token: 0x04009827 RID: 38951
	private AudioClip zcNnvUUvme9;

	// Token: 0x04009828 RID: 38952
	private AudioClip dNsnvNIcfsf;

	// Token: 0x04009829 RID: 38953
	private int dINnvEOgCDs;

	// Token: 0x0400982A RID: 38954
	private int sosnvPxXK0R;

	// Token: 0x0400982B RID: 38955
	private int Cb8nvSM0iZp;

	// Token: 0x0400982C RID: 38956
	private int jPlnvBBRrRh;

	// Token: 0x0400982D RID: 38957
	private int YGknv0MUvsa;

	// Token: 0x0400982E RID: 38958
	private float lkknv8HG4gs;

	// Token: 0x0400982F RID: 38959
	public GameObject mSmashScore1;

	// Token: 0x04009830 RID: 38960
	public GameObject mSmashScore2;

	// Token: 0x04009831 RID: 38961
	public AudioClip mSmashWhistle;

	// Token: 0x04009832 RID: 38962
	public GameObject ring_team1;

	// Token: 0x04009833 RID: 38963
	public GameObject ring_team2;

	// Token: 0x04009834 RID: 38964
	private int qfBnviLkKR7;

	// Token: 0x02001CA6 RID: 7334
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$44786 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AB9F RID: 43935 RVA: 0x01318CB0 File Offset: 0x01316EB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$44786(M968_RoadToWorldCup self_)
		{
			if (39802 - 23823 != 15980)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (60807 - 384741 != -323933)
				{
					base..ctor();
					if (259372 - 570696 == -311324)
					{
						this.$self_$44788 = self_;
						if (10734 - 269597 != -258862)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ABA0 RID: 43936 RVA: 0x01318D48 File Offset: 0x01316F48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M968_RoadToWorldCup.$StartEvent$44786.$(this.$self_$44788);
		}

		// Token: 0x0600ABA1 RID: 43937 RVA: 0x01318D58 File Offset: 0x01316F58
		internal static bool i6leFdVunHV2jRmc2rsW()
		{
			return true;
		}

		// Token: 0x0600ABA2 RID: 43938 RVA: 0x01318D5C File Offset: 0x01316F5C
		internal static bool Y3WAQNVu6DoPIigWE7Je()
		{
			return false;
		}

		// Token: 0x04009835 RID: 38965
		internal M968_RoadToWorldCup $self_$44788;

		// Token: 0x02001CA7 RID: 7335
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ABA3 RID: 43939 RVA: 0x01318D60 File Offset: 0x01316F60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M968_RoadToWorldCup self_)
			{
				if (220380 - 233618 != -13238)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (65546 - 593786 != -528239)
					{
						base..ctor();
						if (92603 - 28956 == 63647)
						{
							this.$self_$44787 = self_;
							if (256941 - 435915 != -178973)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ABA4 RID: 43940 RVA: 0x01318DF8 File Offset: 0x01316FF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227311 - 482351 != -255039)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_26C;
					case 1:
						goto IL_5B4;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (166997 - 236899 != -69901)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							if (!this.$self_$44787.zcNnvUUvme9)
							{
								goto IL_456;
							}
							if (141565 - 594860 != -453295)
							{
								continue;
							}
							this.$self_$44787.audio.PlayOneShot(this.$self_$44787.zcNnvUUvme9);
							if (154765 - 354831 != -200065)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (187854 - 381764 != -193909)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							if (!this.$self_$44787.zcNnvUUvme9)
							{
								goto IL_9A;
							}
							if (120694 - 404699 == -284004)
							{
								continue;
							}
							this.$self_$44787.audio.PlayOneShot(this.$self_$44787.zcNnvUUvme9);
							if (281351 - 243442 != 37910)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (27239 - 203093 != -175854)
							{
								continue;
							}
							goto IL_3DB;
						}
						else
						{
							if (!this.$self_$44787.zcNnvUUvme9)
							{
								goto IL_519;
							}
							if (96024 - 426225 != -330201)
							{
								continue;
							}
							this.$self_$44787.audio.PlayOneShot(this.$self_$44787.zcNnvUUvme9);
							if (8159 - 491695 != -483536)
							{
								continue;
							}
							goto IL_519;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (173612 - 91451 != 82161)
							{
								continue;
							}
							goto IL_290;
						}
						else if (Game.mGameState != eGameState.Start)
						{
							if (271781 - 157954 != 113827)
							{
								continue;
							}
							goto IL_58F;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (246781 - 260306 == -13524)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (200190 - 470675 == -270484)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (246046 - 510044 == -263997)
							{
								continue;
							}
							if (this.$self_$44787.L8QnvwTyjcP)
							{
								if (233360 - 435169 != -201809)
								{
									continue;
								}
								this.$self_$44787.audio.PlayOneShot(this.$self_$44787.L8QnvwTyjcP);
								if (166931 - 213968 != -47037)
								{
									continue;
								}
							}
							this.$self_$44787.SendMessage("newGameMessage", "Match has started!");
							if (57707 - 95167 != -37460)
							{
								continue;
							}
							Chat.SubmitChat("none", "Match has started!", eChatType.system, eChatMode.system);
							if (103314 - 362767 != -259452)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$44787.sosnvPxXK0R != 0)
						{
							if (276819 - 598035 == -321215)
							{
								continue;
							}
							if (this.$self_$44787.Cb8nvSM0iZp != 0)
							{
								break;
							}
							if (81246 - 245712 == -164465)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.AllHold;
						if (284477 - 44644 != 239833)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (100682 - 375453 != -274771)
						{
							continue;
						}
						this.$self_$44787.SendMessage("newGameMessage", "Match cancelled: opponent not found!");
						if (183567 - 364177 != -180610)
						{
							continue;
						}
						Chat.SubmitChat("none", "Match cancelled: opponent not found!", eChatType.system, eChatMode.system);
						if (87017 - 567046 != -480029)
						{
							continue;
						}
						goto IL_40F;
					case 7:
						this.$self_$44787.StartCoroutine_Auto(this.$self_$44787.ReturnToTown());
						if (25216 - 199637 == -174420)
						{
							continue;
						}
						break;
					default:
						if (57823 - 127649 != -69825)
						{
							goto IL_26C;
						}
						continue;
					}
					this.YieldDefault(1);
					if (80986 - 276019 != -195032)
					{
						break;
					}
					continue;
					IL_26C:
					Debug.Log("Starting Match");
					if (222169 - 115137 == 107032)
					{
						Game.mGameState = eGameState.Start;
						if (41449 - 119559 == -78110)
						{
							Game.mStateTime = Time.time;
							if (247005 - 17838 != 229168)
							{
								goto Block_38;
							}
						}
					}
				}
				goto IL_5B4;
				IL_9A:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_11:
				goto IL_456;
				Block_12:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_290:
				IL_3DB:
				goto IL_5B4;
				IL_40F:
				return this.Yield(7, new WaitForSeconds(2f));
				IL_456:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_35:
				goto IL_5B4;
				Block_37:
				goto IL_9A;
				Block_38:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_519:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_42:
				IL_58F:
				IL_5B4:
				return false;
			}

			// Token: 0x0600ABA5 RID: 43941 RVA: 0x013193CC File Offset: 0x013175CC
			internal static bool v7DMx5VuiT0wIBvPJxGh()
			{
				return true;
			}

			// Token: 0x0600ABA6 RID: 43942 RVA: 0x013193D0 File Offset: 0x013175D0
			internal static bool xRnioRVuKnqWrm5t9w26()
			{
				return false;
			}

			// Token: 0x04009836 RID: 38966
			internal M968_RoadToWorldCup $self_$44787;
		}
	}

	// Token: 0x02001CA8 RID: 7336
	[CompilerGenerated]
	[Serializable]
	internal sealed class $GoalEvent$44789 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ABA7 RID: 43943 RVA: 0x013193D4 File Offset: 0x013175D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $GoalEvent$44789(object nTeamGoal, M968_RoadToWorldCup self_)
		{
			if (10433 - 583572 != -573139)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (156874 - 429765 != -272890)
				{
					base..ctor();
					if (101758 - 148860 == -47102)
					{
						this.$nTeamGoal$44792 = nTeamGoal;
						if (225451 - 143530 != 81922)
						{
							this.$self_$44793 = self_;
							if (120248 - 417972 != -297723)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600ABA8 RID: 43944 RVA: 0x01319490 File Offset: 0x01317690
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M968_RoadToWorldCup.$GoalEvent$44789.$(this.$nTeamGoal$44792, this.$self_$44793);
		}

		// Token: 0x0600ABA9 RID: 43945 RVA: 0x013194A4 File Offset: 0x013176A4
		internal static bool DBPVDmVudB1ktr6AQO2O()
		{
			return true;
		}

		// Token: 0x0600ABAA RID: 43946 RVA: 0x013194A8 File Offset: 0x013176A8
		internal static bool sGnlM1VuJ67GKbtq5wd4()
		{
			return false;
		}

		// Token: 0x04009837 RID: 38967
		internal object $nTeamGoal$44792;

		// Token: 0x04009838 RID: 38968
		internal M968_RoadToWorldCup $self_$44793;

		// Token: 0x02001CA9 RID: 7337
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ABAB RID: 43947 RVA: 0x013194AC File Offset: 0x013176AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(object nTeamGoal, M968_RoadToWorldCup self_)
			{
				if (251337 - 127999 != 123338)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240731 - 506096 == -265365)
					{
						base..ctor();
						if (18652 - 392921 != -374268)
						{
							this.$nTeamGoal$44790 = nTeamGoal;
							if (221924 - 542750 != -320825)
							{
								this.$self_$44791 = self_;
								if (66428 - 310697 != -244268)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600ABAC RID: 43948 RVA: 0x01319568 File Offset: 0x01317768
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (98224 - 87945 != 10280)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_318;
					case 2:
						if (this.$self_$44791.jPlnvBBRrRh >= 6)
						{
							if (87997 - 32571 == 55427)
							{
								continue;
							}
							Game.sendMissionEvent(9685, 1);
							if (24567 - 535934 != -511367)
							{
								continue;
							}
						}
						else if (this.$self_$44791.YGknv0MUvsa >= 6)
						{
							if (252308 - 280977 != -28669)
							{
								continue;
							}
							Game.sendMissionEvent(9685, 2);
							if (271757 - 217223 != 54534)
							{
								continue;
							}
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (280386 - 138714 == 141673)
							{
								continue;
							}
							this.$self_$44791.iD0nvH0gkS8.enabled = true;
							if (100345 - 378265 == -277919)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (6137 - 206055 != -199918)
						{
							continue;
						}
						goto IL_318;
					default:
						if (226712 - 57586 != 169126)
						{
							continue;
						}
						break;
					}
					if (this.$self_$44791.dNsnvNIcfsf)
					{
						if (298590 - 336420 == -37829)
						{
							continue;
						}
						this.$self_$44791.audio.PlayOneShot(this.$self_$44791.dNsnvNIcfsf);
						if (33667 - 443316 == -409648)
						{
							continue;
						}
					}
					this.$self_$44791.lkknv8HG4gs = Time.time + (float)2;
					if (191032 - 252900 != -61867)
					{
						Game.mGameState = eGameState.Hold;
						if (10744 - 428092 == -417348)
						{
							if (RuntimeServices.EqualityOperator(this.$nTeamGoal$44790, 1))
							{
								if (284754 - 379031 == -94277)
								{
									this.$self_$44791.iD0nvH0gkS8.StartCoroutine_Auto(this.$self_$44791.iD0nvH0gkS8.slerpToObject("GoalCamera1", 1f));
									if (26258 - 21351 != 4908)
									{
										break;
									}
								}
							}
							else
							{
								if (!RuntimeServices.EqualityOperator(this.$nTeamGoal$44790, 2))
								{
									break;
								}
								if (137009 - 83788 != 53222)
								{
									this.$self_$44791.iD0nvH0gkS8.StartCoroutine_Auto(this.$self_$44791.iD0nvH0gkS8.slerpToObject("GoalCamera2", 1f));
									if (278418 - 470884 == -192466)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				IL_318:
				return false;
			}

			// Token: 0x0600ABAD RID: 43949 RVA: 0x013198A0 File Offset: 0x01317AA0
			internal static bool yvZrfKVuDSuLO5gyR31k()
			{
				return true;
			}

			// Token: 0x0600ABAE RID: 43950 RVA: 0x013198A4 File Offset: 0x01317AA4
			internal static bool wByYVUVuvUi6pLTRpa51()
			{
				return false;
			}

			// Token: 0x04009839 RID: 38969
			internal object $nTeamGoal$44790;

			// Token: 0x0400983A RID: 38970
			internal M968_RoadToWorldCup $self_$44791;
		}
	}

	// Token: 0x02001CAA RID: 7338
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TimeUpEvent$44794 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ABAF RID: 43951 RVA: 0x013198A8 File Offset: 0x01317AA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TimeUpEvent$44794(M968_RoadToWorldCup self_)
		{
			if (213776 - 108577 != 105199)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (282383 - 90025 != 192359)
				{
					base..ctor();
					if (260780 - 345866 == -85086)
					{
						this.$self_$44796 = self_;
						if (138214 - 546157 == -407943)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ABB0 RID: 43952 RVA: 0x01319940 File Offset: 0x01317B40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M968_RoadToWorldCup.$TimeUpEvent$44794.$(this.$self_$44796);
		}

		// Token: 0x0600ABB1 RID: 43953 RVA: 0x01319950 File Offset: 0x01317B50
		internal static bool ogEfMvVuROsGXW9K0i9D()
		{
			return true;
		}

		// Token: 0x0600ABB2 RID: 43954 RVA: 0x01319954 File Offset: 0x01317B54
		internal static bool JCVf9tVuwrb6YmBRAiA3()
		{
			return false;
		}

		// Token: 0x0400983B RID: 38971
		internal M968_RoadToWorldCup $self_$44796;

		// Token: 0x02001CAB RID: 7339
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ABB3 RID: 43955 RVA: 0x01319958 File Offset: 0x01317B58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M968_RoadToWorldCup self_)
			{
				if (8365 - 587300 != -578934)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (233284 - 514847 == -281563)
					{
						base..ctor();
						if (60011 - 282956 == -222945)
						{
							this.$self_$44795 = self_;
							if (275512 - 275964 == -452)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ABB4 RID: 43956 RVA: 0x013199F0 File Offset: 0x01317BF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (254592 - 71915 != 182678)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_22F;
					case 2:
						if (this.$self_$44795.jPlnvBBRrRh > this.$self_$44795.YGknv0MUvsa)
						{
							if (88142 - 175135 != -86993)
							{
								continue;
							}
							Game.sendMissionEvent(9685, 1);
							if (80201 - 426615 != -346414)
							{
								continue;
							}
						}
						else if (this.$self_$44795.YGknv0MUvsa > this.$self_$44795.jPlnvBBRrRh)
						{
							if (11799 - 486080 == -474280)
							{
								continue;
							}
							Game.sendMissionEvent(9685, 2);
							if (216658 - 149311 == 67348)
							{
								continue;
							}
						}
						else
						{
							Game.sendMissionEvent(9685, 3);
							if (147340 - 472050 != -324710)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (63322 - 346102 != -282779)
						{
							goto Block_8;
						}
						continue;
					default:
						if (39890 - 582164 != -542274)
						{
							continue;
						}
						break;
					}
					this.$self_$44795.iD0nvH0gkS8.StartCoroutine_Auto(this.$self_$44795.iD0nvH0gkS8.slerpToObject("ScoreCamera", 1f));
					if (108108 - 104264 == 3844)
					{
						if (this.$self_$44795.dNsnvNIcfsf)
						{
							if (255582 - 309271 != -53689)
							{
								continue;
							}
							this.$self_$44795.audio.PlayOneShot(this.$self_$44795.dNsnvNIcfsf);
							if (72077 - 77277 == -5199)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (48363 - 58220 != -9856)
						{
							break;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				Block_8:
				IL_22F:
				return false;
			}

			// Token: 0x0600ABB5 RID: 43957 RVA: 0x01319C40 File Offset: 0x01317E40
			internal static bool ubX0VVVuqfyU8xqEMiFJ()
			{
				return true;
			}

			// Token: 0x0600ABB6 RID: 43958 RVA: 0x01319C44 File Offset: 0x01317E44
			internal static bool RqnWpeVu7elbihtkNwFH()
			{
				return false;
			}

			// Token: 0x0400983C RID: 38972
			internal M968_RoadToWorldCup $self_$44795;
		}
	}

	// Token: 0x02001CAC RID: 7340
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$44797 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ABB7 RID: 43959 RVA: 0x01319C48 File Offset: 0x01317E48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$44797(M968_RoadToWorldCup self_)
		{
			if (86717 - 390101 != -303383)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (116826 - 501409 != -384582)
				{
					base..ctor();
					if (188870 - 176584 == 12286)
					{
						this.$self_$44801 = self_;
						if (233341 - 141158 == 92183)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ABB8 RID: 43960 RVA: 0x01319CE0 File Offset: 0x01317EE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M968_RoadToWorldCup.$StartGame$44797.$(this.$self_$44801);
		}

		// Token: 0x0600ABB9 RID: 43961 RVA: 0x01319CF0 File Offset: 0x01317EF0
		internal static bool KTnkd4VuPVJJ0QAwj80x()
		{
			return true;
		}

		// Token: 0x0600ABBA RID: 43962 RVA: 0x01319CF4 File Offset: 0x01317EF4
		internal static bool toeRsNVu0mpBYKbg2pjb()
		{
			return false;
		}

		// Token: 0x0400983D RID: 38973
		internal M968_RoadToWorldCup $self_$44801;

		// Token: 0x02001CAD RID: 7341
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ABBB RID: 43963 RVA: 0x01319CF8 File Offset: 0x01317EF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M968_RoadToWorldCup self_)
			{
				if (291909 - 36447 != 255462)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (43721 - 57533 == -13812)
					{
						base..ctor();
						if (285370 - 412260 != -126889)
						{
							this.$self_$44800 = self_;
							if (118138 - 427573 == -309435)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ABBC RID: 43964 RVA: 0x01319D90 File Offset: 0x01317F90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (118291 - 159296 != -41004)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_311;
					case 2:
						this.$self_$44800.iD0nvH0gkS8.StartCoroutine_Auto(this.$self_$44800.iD0nvH0gkS8.slerpToObject("StartCamera" + this.$slot$44798, (float)3));
						if (148155 - 14914 != 133242)
						{
							goto Block_11;
						}
						continue;
					case 3:
						this.$mGameGui$44799 = (GameGui)this.$self_$44800.GetComponent(typeof(GameGui));
						if (22322 - 13969 == 8354)
						{
							continue;
						}
						this.$mGameGui$44799.enabled = true;
						if (33134 - 251184 != -218050)
						{
							continue;
						}
						this.$self_$44800.iD0nvH0gkS8.enabled = true;
						if (160566 - 391808 != -231242)
						{
							continue;
						}
						if (this.$self_$44800.dINnvEOgCDs < 1)
						{
							if (23935 - 445884 != -421949)
							{
								continue;
							}
							Game.sendMissionEvent(9681, 0);
							if (162806 - 588781 == -425974)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (116471 - 310895 != -194424)
						{
							continue;
						}
						goto IL_311;
					default:
						if (194236 - 171519 != 22717)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (172172 - 476222 == -304050)
					{
						Game.mGameState = eGameState.Start;
						if (238232 - 10953 == 227279)
						{
							Game.mStateTime = Time.time;
							if (21231 - 335066 != -313834)
							{
								this.$slot$44798 = Game.getPlayerSlot(PlayerData.UID);
								if (212772 - 204443 == 8329)
								{
									if (this.$slot$44798 % 2 == 1)
									{
										if (295510 - 483985 == -188474)
										{
											continue;
										}
										this.$self_$44800.iD0nvH0gkS8.alignToObject("TeamCamera1");
										if (71321 - 358856 == -287534)
										{
											continue;
										}
									}
									else
									{
										this.$self_$44800.iD0nvH0gkS8.alignToObject("TeamCamera2");
										if (234343 - 58072 == 176272)
										{
											continue;
										}
									}
									this.$self_$44800.SendMessage("fadeIn");
									if (35948 - 38808 != -2859)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_11:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_311:
				return false;
			}

			// Token: 0x0600ABBD RID: 43965 RVA: 0x0131A0C0 File Offset: 0x013182C0
			internal static bool GVNk3bVub1v1sIHPc8Z4()
			{
				return true;
			}

			// Token: 0x0600ABBE RID: 43966 RVA: 0x0131A0C4 File Offset: 0x013182C4
			internal static bool ix4w15VuuHEsFoULTOll()
			{
				return false;
			}

			// Token: 0x0400983E RID: 38974
			internal int $slot$44798;

			// Token: 0x0400983F RID: 38975
			internal GameGui $mGameGui$44799;

			// Token: 0x04009840 RID: 38976
			internal M968_RoadToWorldCup $self_$44800;
		}
	}

	// Token: 0x02001CAE RID: 7342
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44802 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ABBF RID: 43967 RVA: 0x0131A0C8 File Offset: 0x013182C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44802(M968_RoadToWorldCup self_)
		{
			if (131148 - 338070 != -206921)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (178449 - 433042 != -254592)
				{
					base..ctor();
					if (118422 - 476623 == -358201)
					{
						this.$self_$44807 = self_;
						if (297409 - 578420 != -281010)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ABC0 RID: 43968 RVA: 0x0131A160 File Offset: 0x01318360
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M968_RoadToWorldCup.$onDeadPlayer$44802.$(this.$self_$44807);
		}

		// Token: 0x0600ABC1 RID: 43969 RVA: 0x0131A170 File Offset: 0x01318370
		internal static bool KZ4AfIVuI2rbighMiuVS()
		{
			return true;
		}

		// Token: 0x0600ABC2 RID: 43970 RVA: 0x0131A174 File Offset: 0x01318374
		internal static bool MT4NQtVuBcrpGZejpaLk()
		{
			return false;
		}

		// Token: 0x04009841 RID: 38977
		internal M968_RoadToWorldCup $self_$44807;

		// Token: 0x02001CAF RID: 7343
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ABC3 RID: 43971 RVA: 0x0131A178 File Offset: 0x01318378
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M968_RoadToWorldCup self_)
			{
				if (158648 - 557421 != -398773)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (241985 - 150961 == 91024)
					{
						base..ctor();
						if (110799 - 234915 != -124115)
						{
							this.$self_$44806 = self_;
							if (142476 - 157409 != -14932)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ABC4 RID: 43972 RVA: 0x0131A210 File Offset: 0x01318410
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (135086 - 460018 != -324932)
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
						if (Game.mGameState != eGameState.Normal)
						{
							if (297841 - 455641 == -157799)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_214;
							}
							if (58433 - 325994 != -267561)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (25242 - 457985 == -432742)
						{
							continue;
						}
						this.$mStoryGui$44803 = (StoryGui)this.$self_$44806.GetComponent(typeof(StoryGui));
						if (41113 - 241862 != -200749)
						{
							continue;
						}
						if (this.$mStoryGui$44803)
						{
							if (25680 - 369841 != -344161)
							{
								continue;
							}
							this.$mStoryGui$44803.close();
							if (293942 - 375706 == -81763)
							{
								continue;
							}
						}
						this.$mChangeGui$44804 = (ChangeGui)this.$self_$44806.GetComponent(typeof(ChangeGui));
						if (58206 - 258855 == -200648)
						{
							continue;
						}
						if (this.$mChangeGui$44804)
						{
							if (142754 - 43542 != 99212)
							{
								continue;
							}
							this.$mChangeGui$44804.close();
							if (41595 - 489898 != -448303)
							{
								continue;
							}
						}
						this.$mGameGui$44805 = (GameGui)this.$self_$44806.GetComponent(typeof(GameGui));
						if (279980 - 133321 == 146660)
						{
							continue;
						}
						if (this.$mGameGui$44805)
						{
							if (131590 - 473548 != -341958)
							{
								continue;
							}
							if (!this.$mGameGui$44805.enabled)
							{
								if (16722 - 104045 != -87323)
								{
									continue;
								}
								this.$mGameGui$44805.enabled = true;
								if (86257 - 261542 != -175285)
								{
									continue;
								}
							}
							this.$mGameGui$44805.openDeadMenu();
							if (281111 - 299690 == -18578)
							{
								continue;
							}
						}
						IL_214:
						this.YieldDefault(1);
						if (220398 - 219023 != 1375)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (249032 - 354671 != -105639)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (266729 - 135456 == 131274);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600ABC5 RID: 43973 RVA: 0x0131A528 File Offset: 0x01318728
			internal static bool wM4x35Vue3VdXCTkxto8()
			{
				return true;
			}

			// Token: 0x0600ABC6 RID: 43974 RVA: 0x0131A52C File Offset: 0x0131872C
			internal static bool xlATvuVur1smVhC9qHZ6()
			{
				return false;
			}

			// Token: 0x04009842 RID: 38978
			internal StoryGui $mStoryGui$44803;

			// Token: 0x04009843 RID: 38979
			internal ChangeGui $mChangeGui$44804;

			// Token: 0x04009844 RID: 38980
			internal GameGui $mGameGui$44805;

			// Token: 0x04009845 RID: 38981
			internal M968_RoadToWorldCup $self_$44806;
		}
	}

	// Token: 0x02001CB0 RID: 7344
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44808 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ABC7 RID: 43975 RVA: 0x0131A530 File Offset: 0x01318730
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44808(Hashtable data, M968_RoadToWorldCup self_)
		{
			if (236296 - 129517 != 106779)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (45644 - 567909 == -522265)
				{
					base..ctor();
					if (289066 - 173313 == 115753)
					{
						this.$data$44814 = data;
						if (73578 - 348463 == -274885)
						{
							this.$self_$44815 = self_;
							if (264265 - 348944 != -84678)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600ABC8 RID: 43976 RVA: 0x0131A5EC File Offset: 0x013187EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M968_RoadToWorldCup.$onGameComplete$44808.$(this.$data$44814, this.$self_$44815);
		}

		// Token: 0x0600ABC9 RID: 43977 RVA: 0x0131A600 File Offset: 0x01318800
		internal static bool aR12pBVuj6nLKH4bN5Eg()
		{
			return true;
		}

		// Token: 0x0600ABCA RID: 43978 RVA: 0x0131A604 File Offset: 0x01318804
		internal static bool x02SOxVuhVKbo2Y8EMPd()
		{
			return false;
		}

		// Token: 0x04009846 RID: 38982
		internal Hashtable $data$44814;

		// Token: 0x04009847 RID: 38983
		internal M968_RoadToWorldCup $self_$44815;

		// Token: 0x02001CB1 RID: 7345
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ABCB RID: 43979 RVA: 0x0131A608 File Offset: 0x01318808
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M968_RoadToWorldCup self_)
			{
				if (9436 - 391872 != -382435)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (175288 - 580923 != -405634)
					{
						base..ctor();
						if (92120 - 284579 == -192459)
						{
							this.$data$44812 = data;
							if (8979 - 355806 != -346826)
							{
								this.$self_$44813 = self_;
								if (13778 - 153245 == -139467)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600ABCC RID: 43980 RVA: 0x0131A6C4 File Offset: 0x013188C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (293347 - 92074 != 201273)
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
						this.$mCompleteGui$44810 = (CompleteGui)this.$self_$44813.GetComponent(typeof(CompleteGui));
						if (244547 - 243248 == 1300)
						{
							continue;
						}
						this.$mCompleteGui$44810.Init();
						if (80798 - 536929 == -456130)
						{
							continue;
						}
						this.$mCompleteGui$44810.readData(this.$data$44812);
						if (248696 - 12619 != 236077)
						{
							continue;
						}
						if (this.$result$44809 == 1)
						{
							if (123202 - 284927 == -161724)
							{
								continue;
							}
							this.$mCompleteGui$44810.displayResult(eCompleteType.Success);
							if (287205 - 344497 == -57291)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44810.displayResult(eCompleteType.Failed);
							if (104130 - 13280 == 90851)
							{
								continue;
							}
						}
						this.$mGameGui$44811 = (GameGui)this.$self_$44813.GetComponent(typeof(GameGui));
						if (34052 - 356599 == -322546)
						{
							continue;
						}
						if (this.$mGameGui$44811)
						{
							if (122889 - 7781 != 115108)
							{
								continue;
							}
							this.$mGameGui$44811.close();
							if (66688 - 444797 != -378109)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (118548 - 73302 != 45247)
						{
							goto Block_14;
						}
						continue;
					default:
						if (96709 - 145561 == -48851)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (187676 - 451235 != -263558)
						{
							goto Block_17;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (273680 - 293312 != -19631)
						{
							this.$result$44809 = RuntimeServices.UnboxInt32(this.$data$44812[31]);
							if (205970 - 44337 == 161633)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_14:
				Block_17:
				IL_28E:
				return false;
			}

			// Token: 0x0600ABCD RID: 43981 RVA: 0x0131A974 File Offset: 0x01318B74
			internal static bool LN3uXlVus4sNoospo1Y0()
			{
				return true;
			}

			// Token: 0x0600ABCE RID: 43982 RVA: 0x0131A978 File Offset: 0x01318B78
			internal static bool DtaeyqVu9JLxXQZQsu7J()
			{
				return false;
			}

			// Token: 0x04009848 RID: 38984
			internal int $result$44809;

			// Token: 0x04009849 RID: 38985
			internal CompleteGui $mCompleteGui$44810;

			// Token: 0x0400984A RID: 38986
			internal GameGui $mGameGui$44811;

			// Token: 0x0400984B RID: 38987
			internal Hashtable $data$44812;

			// Token: 0x0400984C RID: 38988
			internal M968_RoadToWorldCup $self_$44813;
		}
	}

	// Token: 0x02001CB2 RID: 7346
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44816 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ABCF RID: 43983 RVA: 0x0131A97C File Offset: 0x01318B7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44816(M968_RoadToWorldCup self_)
		{
			if (9731 - 76895 != -67164)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (81533 - 80664 == 869)
				{
					base..ctor();
					if (135006 - 405020 != -270013)
					{
						this.$self_$44820 = self_;
						if (124665 - 440738 == -316073)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ABD0 RID: 43984 RVA: 0x0131AA14 File Offset: 0x01318C14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M968_RoadToWorldCup.$ReturnToTown$44816.$(this.$self_$44820);
		}

		// Token: 0x0600ABD1 RID: 43985 RVA: 0x0131AA24 File Offset: 0x01318C24
		internal static bool LkvDPkVu14PoE1tDod8X()
		{
			return true;
		}

		// Token: 0x0600ABD2 RID: 43986 RVA: 0x0131AA28 File Offset: 0x01318C28
		internal static bool PVvYd9Vu4YMyqjmNY5jF()
		{
			return false;
		}

		// Token: 0x0400984D RID: 38989
		internal M968_RoadToWorldCup $self_$44820;

		// Token: 0x02001CB3 RID: 7347
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ABD3 RID: 43987 RVA: 0x0131AA2C File Offset: 0x01318C2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M968_RoadToWorldCup self_)
			{
				if (144565 - 591526 != -446960)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (178238 - 13349 == 164889)
					{
						base..ctor();
						if (70187 - 235674 == -165487)
						{
							this.$self_$44819 = self_;
							if (275491 - 576355 == -300864)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ABD4 RID: 43988 RVA: 0x0131AAC4 File Offset: 0x01318CC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79092 - 586511 != -507419)
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
						this.$self_$44819.LeaveGame();
						if (179427 - 402150 != -222723)
						{
							continue;
						}
						this.YieldDefault(1);
						if (218705 - 464894 != -246189)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (172902 - 77215 != 95687)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (129337 - 387106 != -257768)
					{
						Game.mStateTime = Time.time;
						if (188435 - 146451 != 41985)
						{
							this.$$switch$8344$44817 = PlayerData.SaveGuild;
							if (218183 - 281772 == -63589)
							{
								if (this.$$switch$8344$44817 == 1)
								{
									if (167081 - 158974 != 8107)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (34272 - 21007 != 13265)
									{
										continue;
									}
								}
								else if (this.$$switch$8344$44817 == 2)
								{
									if (240295 - 89911 != 150384)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (203973 - 20073 != 183900)
									{
										continue;
									}
								}
								else if (this.$$switch$8344$44817 == 3)
								{
									if (72252 - 535266 != -463014)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (271537 - 541288 == -269750)
									{
										continue;
									}
								}
								else if (this.$$switch$8344$44817 == 4)
								{
									if (159815 - 524894 == -365078)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (161755 - 7279 != 154476)
									{
										continue;
									}
								}
								else if (this.$$switch$8344$44817 == 5)
								{
									if (225321 - 26227 == 199095)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (199973 - 211542 != -11569)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (10618 - 311031 != -300413)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (246331 - 390589 != -144258)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (25420 - 243471 != -218051)
									{
										continue;
									}
								}
								this.$mGameGui$44818 = (GameGui)this.$self_$44819.GetComponent(typeof(GameGui));
								if (295810 - 228948 == 66862)
								{
									if (this.$mGameGui$44818)
									{
										if (268864 - 296506 == -27641)
										{
											continue;
										}
										this.$mGameGui$44818.close();
										if (165081 - 64378 == 100704)
										{
											continue;
										}
									}
									this.$self_$44819.SendMessage("fadeOut");
									if (25071 - 255260 != -230188)
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

			// Token: 0x0600ABD5 RID: 43989 RVA: 0x0131AE90 File Offset: 0x01319090
			internal static bool wncIILVuzQkrjUJ09NKG()
			{
				return true;
			}

			// Token: 0x0600ABD6 RID: 43990 RVA: 0x0131AE94 File Offset: 0x01319094
			internal static bool jONZbuVIa0Xf3GudKKq8()
			{
				return false;
			}

			// Token: 0x0400984E RID: 38990
			internal int $$switch$8344$44817;

			// Token: 0x0400984F RID: 38991
			internal GameGui $mGameGui$44818;

			// Token: 0x04009850 RID: 38992
			internal M968_RoadToWorldCup $self_$44819;
		}
	}

	// Token: 0x02001CB4 RID: 7348
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44821 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ABD7 RID: 43991 RVA: 0x0131AE98 File Offset: 0x01319098
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44821(M968_RoadToWorldCup self_)
		{
			if (91308 - 143072 != -51764)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (271307 - 596671 == -325364)
				{
					base..ctor();
					if (59000 - 475071 == -416071)
					{
						this.$self_$44824 = self_;
						if (257201 - 110956 == 146245)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ABD8 RID: 43992 RVA: 0x0131AF30 File Offset: 0x01319130
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M968_RoadToWorldCup.$ReturnToGuild$44821.$(this.$self_$44824);
		}

		// Token: 0x0600ABD9 RID: 43993 RVA: 0x0131AF40 File Offset: 0x01319140
		internal static bool sycoORVI52f6Ev7SvvZn()
		{
			return true;
		}

		// Token: 0x0600ABDA RID: 43994 RVA: 0x0131AF44 File Offset: 0x01319144
		internal static bool cTnqSFVIpumJvw3YPGZ5()
		{
			return false;
		}

		// Token: 0x04009851 RID: 38993
		internal M968_RoadToWorldCup $self_$44824;

		// Token: 0x02001CB5 RID: 7349
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ABDB RID: 43995 RVA: 0x0131AF48 File Offset: 0x01319148
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M968_RoadToWorldCup self_)
			{
				if (239186 - 203996 != 35191)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221290 - 396917 == -175627)
					{
						base..ctor();
						if (182862 - 329833 == -146971)
						{
							this.$self_$44823 = self_;
							if (193727 - 257858 == -64131)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ABDC RID: 43996 RVA: 0x0131AFE0 File Offset: 0x013191E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (141118 - 409449 != -268331)
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
						this.$self_$44823.LeaveGame();
						if (207711 - 167926 != 39785)
						{
							continue;
						}
						this.YieldDefault(1);
						if (76846 - 25865 != 50981)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (61921 - 45465 == 16457)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (203101 - 112374 != 90728)
					{
						Game.mStateTime = Time.time;
						if (209278 - 371671 != -162392)
						{
							Game.mNextGameCode = 31;
							if (295032 - 536880 != -241847)
							{
								this.$mGameGui$44822 = (GameGui)this.$self_$44823.GetComponent(typeof(GameGui));
								if (3601 - 560432 == -556831)
								{
									if (this.$mGameGui$44822)
									{
										if (97269 - 466312 != -369043)
										{
											continue;
										}
										this.$mGameGui$44822.close();
										if (16718 - 211628 != -194910)
										{
											continue;
										}
									}
									this.$self_$44823.SendMessage("fadeOut");
									if (261205 - 569035 != -307829)
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

			// Token: 0x0600ABDD RID: 43997 RVA: 0x0131B1BC File Offset: 0x013193BC
			internal static bool QwjoerVIVyDCl1g20whR()
			{
				return true;
			}

			// Token: 0x0600ABDE RID: 43998 RVA: 0x0131B1C0 File Offset: 0x013193C0
			internal static bool NTcPLkVItLLkccb5LR9y()
			{
				return false;
			}

			// Token: 0x04009852 RID: 38994
			internal GameGui $mGameGui$44822;

			// Token: 0x04009853 RID: 38995
			internal M968_RoadToWorldCup $self_$44823;
		}
	}

	// Token: 0x02001CB6 RID: 7350
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44825 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ABDF RID: 43999 RVA: 0x0131B1C4 File Offset: 0x013193C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44825(M968_RoadToWorldCup self_)
		{
			if (192870 - 509469 != -316598)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131391 - 293815 == -162424)
				{
					base..ctor();
					if (265019 - 234515 != 30505)
					{
						this.$self_$44829 = self_;
						if (119539 - 427800 == -308261)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ABE0 RID: 44000 RVA: 0x0131B25C File Offset: 0x0131945C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M968_RoadToWorldCup.$ReturnToCamp$44825.$(this.$self_$44829);
		}

		// Token: 0x0600ABE1 RID: 44001 RVA: 0x0131B26C File Offset: 0x0131946C
		internal static bool tXKYZiVIN56QB6V6MpJX()
		{
			return true;
		}

		// Token: 0x0600ABE2 RID: 44002 RVA: 0x0131B270 File Offset: 0x01319470
		internal static bool IgEZoUVIYEE8Qdf8v4EO()
		{
			return false;
		}

		// Token: 0x04009854 RID: 38996
		internal M968_RoadToWorldCup $self_$44829;

		// Token: 0x02001CB7 RID: 7351
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ABE3 RID: 44003 RVA: 0x0131B274 File Offset: 0x01319474
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M968_RoadToWorldCup self_)
			{
				if (178771 - 263241 != -84470)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (143966 - 324912 != -180945)
					{
						base..ctor();
						if (47031 - 369506 != -322474)
						{
							this.$self_$44828 = self_;
							if (145595 - 161963 != -16367)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ABE4 RID: 44004 RVA: 0x0131B30C File Offset: 0x0131950C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (251828 - 350049 != -98220)
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
						this.$self_$44828.LeaveGame();
						if (153711 - 458349 != -304638)
						{
							continue;
						}
						this.YieldDefault(1);
						if (227916 - 48021 != 179895)
						{
							continue;
						}
						goto IL_363;
					default:
						if (117467 - 347210 != -229743)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (180241 - 48311 == 131930)
					{
						Game.mStateTime = Time.time;
						if (284515 - 63441 == 221074)
						{
							this.$$switch$8346$44826 = PlayerData.SaveGuild;
							if (79864 - 590749 == -510885)
							{
								if (this.$$switch$8346$44826 == 1)
								{
									if (175880 - 539344 == -363463)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (240183 - 579927 == -339743)
									{
										continue;
									}
								}
								else if (this.$$switch$8346$44826 == 2)
								{
									if (135950 - 74365 != 61585)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (11509 - 250005 != -238496)
									{
										continue;
									}
								}
								else if (this.$$switch$8346$44826 == 3)
								{
									if (83822 - 519596 != -435774)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (54740 - 192226 != -137486)
									{
										continue;
									}
								}
								else if (this.$$switch$8346$44826 == 4)
								{
									if (75489 - 521739 == -446249)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (112359 - 169292 != -56933)
									{
										continue;
									}
								}
								else if (this.$$switch$8346$44826 == 5)
								{
									if (156442 - 489106 == -332663)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (120700 - 59685 == 61016)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (21165 - 334471 != -313306)
									{
										continue;
									}
								}
								this.$mGameGui$44827 = (GameGui)this.$self_$44828.GetComponent(typeof(GameGui));
								if (40841 - 186692 != -145850)
								{
									if (this.$mGameGui$44827)
									{
										if (88795 - 389597 == -300801)
										{
											continue;
										}
										this.$mGameGui$44827.close();
										if (36323 - 284958 != -248635)
										{
											continue;
										}
									}
									this.$self_$44828.SendMessage("fadeOut");
									if (169455 - 278342 != -108886)
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

			// Token: 0x0600ABE5 RID: 44005 RVA: 0x0131B690 File Offset: 0x01319890
			internal static bool dfVlaOVIcXw0g4bqfgII()
			{
				return true;
			}

			// Token: 0x0600ABE6 RID: 44006 RVA: 0x0131B694 File Offset: 0x01319894
			internal static bool E2oVLwVIU1stqRcf4OeP()
			{
				return false;
			}

			// Token: 0x04009855 RID: 38997
			internal int $$switch$8346$44826;

			// Token: 0x04009856 RID: 38998
			internal GameGui $mGameGui$44827;

			// Token: 0x04009857 RID: 38999
			internal M968_RoadToWorldCup $self_$44828;
		}
	}
}
