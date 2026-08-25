using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02001004 RID: 4100
[Serializable]
public class Chat : MonoBehaviour
{
	// Token: 0x06005DF6 RID: 24054 RVA: 0x00C8DF28 File Offset: 0x00C8C128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chat()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005DF7 RID: 24055 RVA: 0x00C8DF38 File Offset: 0x00C8C138
	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Chat()
	{
		if (237161 - 584247 != -347086)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (44839 - 547713 == -502874)
			{
				Chat.showAreaChat = true;
				if (299463 - 458157 != -158693)
				{
					Chat.showGuildChat = true;
					if (17890 - 385783 == -367893)
					{
						Chat.showPrivateChat = true;
						if (214598 - 356995 == -142397)
						{
							Chat.showSystemChat = true;
							if (215822 - 563653 == -347831)
							{
								Chat.TextColor = new Color((float)1, (float)1, (float)1, (float)1);
								if (103322 - 431432 == -328110)
								{
									Chat.SelfColor = new Color(0.2f, 0.6f, (float)1, (float)1);
									if (28312 - 57893 == -29581)
									{
										Chat.AllyColor = new Color((float)0, (float)0, (float)0, (float)1);
										if (213319 - 541722 != -328402)
										{
											Chat.GuildColor = new Color(0.65f, 0.98f, 0.99f, (float)1);
											if (291301 - 30612 != 260690)
											{
												Chat.NPCColor = new Color((float)1, (float)1, 0.2f, (float)1);
												if (121011 - 3097 == 117914)
												{
													Chat.EnemyColor = new Color((float)1, 0.2f, 0.2f, (float)1);
													if (291681 - 309613 != -17931)
													{
														Chat.ShadowColor = new Color((float)0, (float)0, (float)0, 0.5f);
														if (189332 - 253287 != -63954)
														{
															Chat.SystemColor = new Color(0.95f, 0.95f, 0.45f, (float)1);
															if (50224 - 23374 != 26851)
															{
																Chat.WolrdColor = new Color(0.95f, 0.25f, 0.25f, (float)1);
																if (275020 - 69086 == 205934)
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

	// Token: 0x06005DF8 RID: 24056 RVA: 0x00C8E1C8 File Offset: 0x00C8C3C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Init()
	{
		if (167686 - 194377 != -26691)
		{
		}
		for (;;)
		{
			Chat.Initialized = true;
			if (244351 - 532855 == -288504)
			{
				Chat.ChatMode = 1;
				if (227371 - 19399 == 207972)
				{
					Chat.ChatTimeOut = Time.time;
					if (246784 - 77257 != 169528)
					{
						Chat.ChatEntries = new UnityScript.Lang.Array();
						if (167889 - 549212 != -381322)
						{
							Chat.ChatDisplay = new UnityScript.Lang.Array();
							if (64222 - 389767 != -325544)
							{
								Chat.MissionEntries = new UnityScript.Lang.Array();
								if (161657 - 496381 == -334724)
								{
									Chat.announcement = "0";
									if (18475 - 46617 != -28141)
									{
										Chat.announcementTimer = (float)0;
										if (206891 - 376552 == -169661)
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

	// Token: 0x06005DF9 RID: 24057 RVA: 0x00C8E318 File Offset: 0x00C8C518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SubmitChat(string nChatName, string nChatText, eChatType nChatType, eChatMode nChatMode)
	{
		if (33921 - 33085 != 836)
		{
		}
		for (;;)
		{
			IL_97D:
			if (179104 - 51816 != 127289)
			{
				if (nChatText == "/ping")
				{
					if (198664 - 372207 == -173543)
					{
						if (PhotonClient.IsInitialized())
						{
							if (147377 - 532189 != -384811)
							{
								ChatEntry chatEntry = new ChatEntry();
								if (189064 - 461044 != -271979)
								{
									chatEntry.name = "none";
									if (151963 - 334946 == -182983)
									{
										chatEntry.text = "Ping : " + PhotonClient.Connection.RoundTripTime + " ms";
										if (290557 - 37913 == 252644)
										{
											chatEntry.time = Time.time;
											if (136719 - 23583 == 113136)
											{
												chatEntry.type = eChatType.system;
												if (104601 - 288124 != -183522)
												{
													chatEntry.mode = eChatMode.system;
													if (146508 - 113173 != 33336)
													{
														Chat.ChatEntries.Add(chatEntry);
														if (220390 - 544252 != -323861)
														{
															Chat.ChatDisplay.Add(chatEntry);
															if (211565 - 335868 == -124303)
															{
																Debug.Log("Ping : " + PhotonClient.Connection.RoundTripTime + " ms");
																if (148281 - 304529 == -156248)
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
						else
						{
							Debug.Log("Not connected");
							if (48797 - 43511 != 5287)
							{
								break;
							}
						}
					}
				}
				else if (nChatText == "/fps")
				{
					if (23232 - 85723 == -62491)
					{
						ChatEntry chatEntry2 = new ChatEntry();
						if (112269 - 497166 == -384897)
						{
							chatEntry2.name = "none";
							if (162406 - 435222 != -272815)
							{
								chatEntry2.text = "Frame rate : " + (float)1 / Time.deltaTime + " fps";
								if (160554 - 420708 == -260154)
								{
									chatEntry2.time = Time.time;
									if (95456 - 500073 == -404617)
									{
										chatEntry2.type = eChatType.system;
										if (97745 - 387496 != -289750)
										{
											chatEntry2.mode = eChatMode.system;
											if (81128 - 196131 == -115003)
											{
												Chat.ChatEntries.Add(chatEntry2);
												if (42379 - 426464 != -384084)
												{
													Chat.ChatDisplay.Add(chatEntry2);
													if (261795 - 426188 == -164393)
													{
														Debug.Log("Frame rate : " + (float)1 / Time.deltaTime + " fps");
														if (219011 - 199664 == 19347)
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
				else if (nChatText == "/recipe")
				{
					if (48674 - 333621 != -284946)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(PlayerData.RecipeList);
						if (109261 - 141855 != -32593)
						{
							while (enumerator.MoveNext())
							{
								object value = enumerator.Current;
								int num = RuntimeServices.UnboxInt32(value);
								if (79952 - 593680 == -513727)
								{
									goto IL_97D;
								}
								Debug.Log(num);
								if (279840 - 234571 != 45269)
								{
									goto IL_97D;
								}
								UnityRuntimeServices.Update(enumerator, num);
								if (27643 - 357728 != -330085)
								{
									goto IL_97D;
								}
							}
							if (135416 - 487694 != -352277)
							{
								break;
							}
						}
					}
				}
				else if (nChatText == "/autoAim")
				{
					if (226644 - 457439 != -230794)
					{
						if (PlayerPrefs.GetInt("autoAim", 1) != 0)
						{
							if (209147 - 173177 == 35970)
							{
								Camera.main.SendMessage("newGameMessage", "Auto-aim off");
								if (231918 - 446261 == -214343)
								{
									PlayerPrefs.SetInt("autoAim", 0);
									if (49498 - 497593 == -448095)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "Auto-aim on");
							if (287958 - 126761 != 161198)
							{
								PlayerPrefs.SetInt("autoAim", 1);
								if (144959 - 155023 == -10064)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/autoAimSkill")
				{
					if (13936 - 543620 == -529684)
					{
						if (PlayerPrefs.GetInt("autoAimSkill", 1) != 0)
						{
							if (104848 - 278111 == -173263)
							{
								Camera.main.SendMessage("newGameMessage", "Auto-aim skill off");
								if (238843 - 188724 != 50120)
								{
									PlayerPrefs.SetInt("autoAimSkill", 0);
									if (87038 - 724 != 86315)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "Auto-aim skill off");
							if (152121 - 537362 != -385240)
							{
								PlayerPrefs.SetInt("autoAimSkill", 1);
								if (275003 - 55083 == 219920)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/trade")
				{
					if (125315 - 511589 == -386274)
					{
						Camera.main.SendMessage("OpenTradeMenu");
						if (7830 - 41553 == -33723)
						{
							break;
						}
					}
				}
				else if (nChatText == "/display")
				{
					if (23411 - 227543 == -204132)
					{
						if (PlayerPrefs.GetInt("display", 1) != 0)
						{
							if (51993 - 555423 == -503430)
							{
								Camera.main.SendMessage("newGameMessage", "Display off");
								if (185883 - 159158 != 26726)
								{
									PlayerPrefs.SetInt("display", 0);
									if (275877 - 308578 != -32700)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "Display on");
							if (268012 - 219452 == 48560)
							{
								PlayerPrefs.SetInt("display", 1);
								if (41959 - 237817 == -195858)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/snap")
				{
					if (260537 - 331585 != -71047)
					{
						if (PlayerPrefs.GetInt("menuSlide", (QualitySettings.GetQualityLevel() <= 3) ? 0 : 1) == 0)
						{
							if (119900 - 79453 != 40448)
							{
								Camera.main.SendMessage("newGameMessage", "menuSlide off");
								if (241678 - 104301 != 137378)
								{
									PlayerPrefs.SetInt("menuSlide", 1);
									if (185962 - 323770 != -137807)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "menuSlide on");
							if (29290 - 18354 == 10936)
							{
								PlayerPrefs.SetInt("menuSlide", 0);
								if (195822 - 175144 == 20678)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/mbar")
				{
					if (293926 - 329477 == -35551)
					{
						if (PlayerPrefs.GetInt("mbar", 1) != 0)
						{
							if (202161 - 523746 != -321584)
							{
								Camera.main.SendMessage("newGameMessage", "MapBar off");
								if (239116 - 279560 == -40444)
								{
									PlayerPrefs.SetInt("mbar", 0);
									if (80999 - 497566 != -416566)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "MapBar on");
							if (261275 - 258774 == 2501)
							{
								PlayerPrefs.SetInt("mbar", 1);
								if (4247 - 285860 == -281613)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/tbar")
				{
					if (27617 - 552108 != -524490)
					{
						if (PlayerPrefs.GetInt("tbar", 1) != 0)
						{
							if (231085 - 214641 != 16445)
							{
								Camera.main.SendMessage("newGameMessage", "TeamBar off");
								if (205241 - 527272 != -322030)
								{
									PlayerPrefs.SetInt("tbar", 0);
									if (245889 - 231569 != 14321)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "TeamBar on");
							if (52448 - 239136 != -186687)
							{
								PlayerPrefs.SetInt("tbar", 1);
								if (187616 - 303767 != -116150)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/sbar")
				{
					if (291528 - 344826 == -53298)
					{
						if (PlayerPrefs.GetInt("sbar", 1) != 0)
						{
							if (221559 - 258636 == -37077)
							{
								Camera.main.SendMessage("newGameMessage", "SummonBar off");
								if (58879 - 32368 == 26511)
								{
									PlayerPrefs.SetInt("sbar", 0);
									if (69773 - 588059 == -518286)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "SummonBar on");
							if (295012 - 346588 == -51576)
							{
								PlayerPrefs.SetInt("sbar", 1);
								if (43186 - 101683 != -58496)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/mute")
				{
					if (36545 - 550599 == -514054)
					{
						AudioListener.volume = (float)0;
						if (141901 - 62842 == 79059)
						{
							Camera.main.SendMessage("newGameMessage", "Game Mute");
							if (1889 - 485429 == -483540)
							{
								break;
							}
						}
					}
				}
				else if (nChatText == "/music")
				{
					if (29565 - 593011 != -563445)
					{
						if (Camera.main.audio.isPlaying)
						{
							if (56567 - 593120 == -536553)
							{
								Game.volume = 0;
								if (4679 - 57554 != -52874)
								{
									Camera.main.SendMessage("newGameMessage", "Music Off");
									if (144371 - 324227 != -179855)
									{
										Camera.main.audio.Stop();
										if (86793 - 384243 == -297450)
										{
											break;
										}
									}
								}
							}
						}
						else
						{
							Game.volume = 1;
							if (76251 - 318892 == -242641)
							{
								Camera.main.SendMessage("newGameMessage", "Music On");
								if (286798 - 147167 == 139631)
								{
									Camera.main.audio.Play();
									if (40186 - 127767 == -87581)
									{
										break;
									}
								}
							}
						}
					}
				}
				else if (nChatText == "/team")
				{
					if (240906 - 434375 != -193468)
					{
						if (PlayerPrefs.GetInt("team", 1) == 0)
						{
							if (104836 - 789 == 104047)
							{
								Camera.main.SendMessage("newGameMessage", "Team on");
								if (245799 - 92391 != 153409)
								{
									PlayerPrefs.SetInt("team", 1);
									if (59391 - 72934 == -13543)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "Team off");
							if (81429 - 17044 != 64386)
							{
								PlayerPrefs.SetInt("team", 0);
								if (33906 - 441223 == -407317)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/pname")
				{
					if (262176 - 426452 == -164276)
					{
						if (PlayerPrefs.GetInt("pname", 1) == 0)
						{
							if (129332 - 287262 != -157929)
							{
								Camera.main.SendMessage("newGameMessage", "Player name on");
								if (250619 - 192806 != 57814)
								{
									PlayerPrefs.SetInt("pname", 1);
									if (106786 - 248569 == -141783)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "Player name off");
							if (197703 - 31759 != 165945)
							{
								PlayerPrefs.SetInt("pname", 0);
								if (80649 - 176583 != -95933)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/cname")
				{
					if (202851 - 285863 != -83011)
					{
						if (PlayerPrefs.GetInt("cname", 1) == 0)
						{
							if (274675 - 332523 == -57848)
							{
								Camera.main.SendMessage("newGameMessage", "Character name on");
								if (121871 - 346460 != -224588)
								{
									PlayerPrefs.SetInt("cname", 1);
									if (295446 - 233259 != 62188)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "Character name off");
							if (192222 - 419691 != -227468)
							{
								PlayerPrefs.SetInt("cname", 0);
								if (146562 - 535854 == -389292)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/clv")
				{
					if (184007 - 247633 == -63626)
					{
						if (PlayerPrefs.GetInt("clv", 1) == 0)
						{
							if (174777 - 108168 == 66609)
							{
								Camera.main.SendMessage("newGameMessage", "Character level on");
								if (65834 - 327422 != -261587)
								{
									PlayerPrefs.SetInt("clv", 1);
									if (243096 - 358935 == -115839)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "Character level off");
							if (102844 - 37605 == 65239)
							{
								PlayerPrefs.SetInt("clv", 0);
								if (150823 - 458424 == -307601)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/gname")
				{
					if (204719 - 416993 == -212274)
					{
						if (PlayerPrefs.GetInt("gname", 1) == 0)
						{
							if (57404 - 46330 == 11074)
							{
								Camera.main.SendMessage("newGameMessage", "Guild name on");
								if (92548 - 370470 == -277922)
								{
									PlayerPrefs.SetInt("gname", 1);
									if (237086 - 172622 == 64464)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "Guild name off");
							if (222961 - 580808 != -357846)
							{
								PlayerPrefs.SetInt("gname", 0);
								if (150773 - 102705 == 48068)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/achat")
				{
					if (73777 - 582760 == -508983)
					{
						if (Chat.showAreaChat)
						{
							if (273680 - 297174 != -23493)
							{
								Camera.main.SendMessage("newGameMessage", "Area chat off");
								if (187734 - 61383 == 126351)
								{
									Chat.showAreaChat = false;
									if (179221 - 378902 != -199680)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "Area chat on");
							if (225398 - 81375 != 144024)
							{
								Chat.showAreaChat = true;
								if (113415 - 58592 == 54823)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/gchat")
				{
					if (177485 - 429260 == -251775)
					{
						if (Chat.showGuildChat)
						{
							if (106081 - 261884 != -155802)
							{
								Camera.main.SendMessage("newGameMessage", "Guild chat off");
								if (209501 - 466840 == -257339)
								{
									Chat.showGuildChat = false;
									if (117721 - 540993 != -423271)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "Guild chat on");
							if (30442 - 509100 != -478657)
							{
								Chat.showGuildChat = true;
								if (241534 - 15896 == 225638)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/pchat")
				{
					if (225357 - 488784 != -263426)
					{
						if (Chat.showPrivateChat)
						{
							if (84532 - 585307 == -500775)
							{
								Camera.main.SendMessage("newGameMessage", "Private chat off");
								if (4 - 215609 != -215604)
								{
									Chat.showPrivateChat = false;
									if (155993 - 306184 != -150190)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "Private chat on");
							if (50123 - 164285 != -114161)
							{
								Chat.showPrivateChat = true;
								if (200590 - 406208 == -205618)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/schat")
				{
					if (29605 - 558566 != -528960)
					{
						if (Chat.showSystemChat)
						{
							if (38974 - 81542 == -42568)
							{
								Camera.main.SendMessage("newGameMessage", "System chat off");
								if (130859 - 222251 != -91391)
								{
									Chat.showSystemChat = false;
									if (82349 - 296739 != -214389)
									{
										break;
									}
								}
							}
						}
						else
						{
							Camera.main.SendMessage("newGameMessage", "System chat on");
							if (58814 - 209763 == -150949)
							{
								Chat.showSystemChat = true;
								if (102941 - 536968 == -434027)
								{
									break;
								}
							}
						}
					}
				}
				else if (nChatText == "/wave")
				{
					if (43169 - 478354 != -435184)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_wave"));
						if (56510 - 393168 == -336658)
						{
							break;
						}
					}
				}
				else if (nChatText == "/ty")
				{
					if (16325 - 587398 == -571073)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_ty"));
						if (201006 - 498716 != -297709)
						{
							break;
						}
					}
				}
				else if (nChatText == "/bow")
				{
					if (35078 - 308892 == -273814)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_bow"));
						if (224664 - 511624 != -286959)
						{
							break;
						}
					}
				}
				else if (nChatText == "/talk")
				{
					if (161630 - 300649 != -139018)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_talk"));
						if (158921 - 247532 != -88610)
						{
							break;
						}
					}
				}
				else if (nChatText == "/sit")
				{
					if (101668 - 127930 == -26262)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_sit"));
						if (31081 - 156651 == -125570)
						{
							break;
						}
					}
				}
				else if (nChatText == "/sleep")
				{
					if (241380 - 585873 == -344493)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_sleep"));
						if (193685 - 438190 != -244504)
						{
							break;
						}
					}
				}
				else if (nChatText == "/cry")
				{
					if (152723 - 66923 == 85800)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_cry"));
						if (193073 - 414415 != -221341)
						{
							break;
						}
					}
				}
				else if (nChatText == "/cheer")
				{
					if (25677 - 443797 == -418120)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_cheer"));
						if (206784 - 553595 == -346811)
						{
							break;
						}
					}
				}
				else if (nChatText == "/laugh")
				{
					if (215082 - 382457 == -167375)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_laugh"));
						if (108180 - 375188 == -267008)
						{
							break;
						}
					}
				}
				else if (nChatText == "/beg")
				{
					if (41836 - 593640 != -551803)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_beg"));
						if (138246 - 480283 == -342037)
						{
							break;
						}
					}
				}
				else if (nChatText == "/talk")
				{
					if (180622 - 105091 != 75532)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_talk"));
						if (37422 - 319575 == -282153)
						{
							break;
						}
					}
				}
				else if (nChatText == "/chat")
				{
					if (292432 - 374904 != -82471)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_chat"));
						if (121859 - 472035 == -350176)
						{
							break;
						}
					}
				}
				else if (nChatText == "/pose")
				{
					if (33872 - 372956 == -339084)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_pose"));
						if (9982 - 94319 != -84336)
						{
							break;
						}
					}
				}
				else if (nChatText == "/battle")
				{
					if (81129 - 244927 == -163798)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_battle"));
						if (207271 - 82445 == 124826)
						{
							break;
						}
					}
				}
				else if (nChatText == "/dance")
				{
					if (140288 - 149314 != -9025)
					{
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_dance"));
						if (198611 - 257686 != -59074)
						{
							break;
						}
					}
				}
				else
				{
					if (nChatText == "/:)")
					{
						if (287363 - 318705 != -31342)
						{
							continue;
						}
					}
					else if (nChatText == "/smile")
					{
						if (90920 - 7354 == 83567)
						{
							continue;
						}
					}
					else
					{
						if (nChatText == "/:D")
						{
							if (267621 - 105879 != 161742)
							{
								continue;
							}
						}
						else if (nChatText == "/happy")
						{
							if (115228 - 264755 == -149526)
							{
								continue;
							}
						}
						else
						{
							if (nChatText == "/:(")
							{
								if (20636 - 50025 == -29388)
								{
									continue;
								}
							}
							else
							{
								if (!(nChatText == "/sad"))
								{
									if (nChatText == "/TT")
									{
										if (32629 - 262509 == -229879)
										{
											continue;
										}
									}
									else if (nChatText == "/T_T")
									{
										if (238947 - 41442 == 197506)
										{
											continue;
										}
									}
									else
									{
										if (!(nChatText == "/tear"))
										{
											if (nChatText == "/rolf")
											{
												if (250822 - 316109 == -65286)
												{
													continue;
												}
											}
											else if (nChatText == "/lol")
											{
												if (146813 - 531409 != -384596)
												{
													continue;
												}
											}
											else if (nChatText == "/555")
											{
												if (98910 - 52964 != 45946)
												{
													continue;
												}
											}
											else
											{
												if (!(nChatText == "/haha"))
												{
													if (nChatText == "/--lll")
													{
														if (153991 - 138723 != 15268)
														{
															continue;
														}
													}
													else if (nChatText == "/- -lll")
													{
														if (134734 - 486543 != -351809)
														{
															continue;
														}
													}
													else if (nChatText == "/puke")
													{
														if (207802 - 26798 == 181005)
														{
															continue;
														}
													}
													else
													{
														if (nChatText == "/#")
														{
															if (197484 - 474361 != -276877)
															{
																continue;
															}
														}
														else
														{
															if (!(nChatText == "/angry"))
															{
																if (nChatText == "/:<")
																{
																	if (252977 - 489050 != -236073)
																	{
																		continue;
																	}
																}
																else if (nChatText == "/D:<")
																{
																	if (222448 - 353193 != -130745)
																	{
																		continue;
																	}
																}
																else if (nChatText == "/>:<")
																{
																	if (72132 - 48837 == 23296)
																	{
																		continue;
																	}
																}
																else if (nChatText == "/-_-#")
																{
																	if (170184 - 451802 == -281617)
																	{
																		continue;
																	}
																}
																else if (nChatText == "/mad")
																{
																	if (174451 - 482837 == -308385)
																	{
																		continue;
																	}
																}
																else
																{
																	if (nChatText == "/!")
																	{
																		if (82861 - 417495 == -334633)
																		{
																			continue;
																		}
																	}
																	else if (nChatText == "/exclaim")
																	{
																		if (272613 - 13907 == 258707)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		if (nChatText == "/?")
																		{
																			if (76494 - 419954 != -343460)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			if (!(nChatText == "/question"))
																			{
																				if (nChatText == "/-3-")
																				{
																					if (258473 - 482488 != -224015)
																					{
																						continue;
																					}
																				}
																				else if (nChatText == "/*3*")
																				{
																					if (48635 - 278046 != -229411)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					if (!(nChatText == "/pervert"))
																					{
																						if (nChatText == "/:o")
																						{
																							if (268147 - 183822 != 84325)
																							{
																								continue;
																							}
																						}
																						else if (nChatText == "/:0")
																						{
																							if (128469 - 14265 != 114204)
																							{
																								continue;
																							}
																						}
																						else if (nChatText == "/:O")
																						{
																							if (24418 - 294297 == -269878)
																							{
																								continue;
																							}
																						}
																						else if (nChatText == "/panic")
																						{
																							if (24745 - 414070 != -389325)
																							{
																								continue;
																							}
																						}
																						else
																						{
																							if (nChatText == "/-//-")
																							{
																								if (145791 - 523454 == -377662)
																								{
																									continue;
																								}
																							}
																							else if (nChatText == "/blush")
																							{
																								if (193965 - 365917 == -171951)
																								{
																									continue;
																								}
																							}
																							else
																							{
																								if (nChatText == "/-*-")
																								{
																									if (51687 - 206080 == -154392)
																									{
																										continue;
																									}
																								}
																								else if (nChatText == "/wrath")
																								{
																									if (192432 - 196298 == -3865)
																									{
																										continue;
																									}
																								}
																								else
																								{
																									if (!(nChatText == "/sweat"))
																									{
																										if (nChatText == "/<3")
																										{
																											if (254463 - 462273 == -207809)
																											{
																												continue;
																											}
																										}
																										else if (nChatText == "/love")
																										{
																											if (261187 - 82508 != 178679)
																											{
																												continue;
																											}
																										}
																										else if (nChatText == "/heart")
																										{
																											if (115078 - 426503 == -311424)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											if (nChatText == "/zz")
																											{
																												if (152662 - 525036 != -372374)
																												{
																													continue;
																												}
																											}
																											else if (nChatText == "/zzz")
																											{
																												if (238432 - 235494 != 2938)
																												{
																													continue;
																												}
																											}
																											else if (!SafeWord.isSafe(nChatText))
																											{
																												if (285426 - 282315 == 3112)
																												{
																													continue;
																												}
																												Camera.main.SendMessage("newGameMessage", "Cannot use bad words!");
																												if (218165 - 475439 != -257273)
																												{
																													break;
																												}
																												continue;
																											}
																											else
																											{
																												if (PlayerData.GID == 0)
																												{
																													if (10871 - 550953 == -540081)
																													{
																														continue;
																													}
																													if (nChatMode == eChatMode.guild)
																													{
																														if (244882 - 560144 != -315262)
																														{
																															continue;
																														}
																														Camera.main.SendMessage("newGameMessage", "You do not have a guild!");
																														if (52376 - 167158 != -114782)
																														{
																															continue;
																														}
																														break;
																													}
																												}
																												if (Chat.lastMessage == nChatText)
																												{
																													if (239376 - 260910 == -21533)
																													{
																														continue;
																													}
																													if (Time.time < Chat.lastMessageTimer)
																													{
																														if (94570 - 434433 != -339863)
																														{
																															continue;
																														}
																														if (nChatType != eChatType.system)
																														{
																															if (206049 - 242439 == -36389)
																															{
																																continue;
																															}
																															Camera.main.SendMessage("newGameMessage", "Cannot send flush message");
																															if (175164 - 364092 != -188927)
																															{
																																break;
																															}
																															continue;
																														}
																													}
																												}
																												if (nChatType != eChatType.system)
																												{
																													if (71194 - 232745 == -161550)
																													{
																														continue;
																													}
																													Chat.lastMessage = nChatText;
																													if (59965 - 26293 == 33673)
																													{
																														continue;
																													}
																													Chat.lastMessageTimer = Time.time + (float)3;
																													if (294719 - 350262 == -55542)
																													{
																														continue;
																													}
																												}
																												if (nChatMode == eChatMode.party)
																												{
																													if (198428 - 379275 == -180846)
																													{
																														continue;
																													}
																													if (Game.mGameType < 4)
																													{
																														if (220704 - 334039 != -113335)
																														{
																															continue;
																														}
																														nChatMode = eChatMode.area;
																														if (154695 - 350393 != -195698)
																														{
																															continue;
																														}
																														Chat.ChatMode = 1;
																														if (217472 - 116349 == 101124)
																														{
																															continue;
																														}
																													}
																												}
																												int num2 = 0;
																												if (31341 - 148461 != -117120)
																												{
																													continue;
																												}
																												if (nChatMode == eChatMode.whisper)
																												{
																													if (219548 - 199104 == 20445)
																													{
																														continue;
																													}
																													num2 = Chat.TargetID;
																													if (191573 - 487807 != -296234)
																													{
																														continue;
																													}
																												}
																												ChatEntry chatEntry3 = new ChatEntry();
																												if (148404 - 46097 == 102308)
																												{
																													continue;
																												}
																												if (nChatMode != eChatMode.whisper)
																												{
																													if (276923 - 321246 != -44323)
																													{
																														continue;
																													}
																													chatEntry3.name = nChatName;
																													if (77104 - 514410 != -437306)
																													{
																														continue;
																													}
																												}
																												else
																												{
																													chatEntry3.name = "To " + PlayerData.getBuddyNameByID(Chat.TargetID);
																													if (76785 - 219594 != -142809)
																													{
																														continue;
																													}
																												}
																												chatEntry3.text = nChatText;
																												if (277846 - 368240 == -90393)
																												{
																													continue;
																												}
																												chatEntry3.time = Time.time;
																												if (183641 - 417241 == -233599)
																												{
																													continue;
																												}
																												chatEntry3.type = nChatType;
																												if (34139 - 97900 != -63761)
																												{
																													continue;
																												}
																												chatEntry3.mode = nChatMode;
																												if (251853 - 461903 != -210050)
																												{
																													continue;
																												}
																												Chat.ChatEntries.Add(chatEntry3);
																												if (292771 - 295526 != -2755)
																												{
																													continue;
																												}
																												Chat.ChatDisplay.Add(chatEntry3);
																												if (215685 - 543381 == -327695)
																												{
																													continue;
																												}
																												if (PlayerPrefs.GetInt("chatBubble", 1) == 1)
																												{
																													if (247411 - 6574 == 240838)
																													{
																														continue;
																													}
																													if (Game.mPlayer != null)
																													{
																														if (102645 - 286148 == -183502)
																														{
																															continue;
																														}
																														if (nChatMode == eChatMode.area)
																														{
																															if (119616 - 321731 == -202114)
																															{
																																continue;
																															}
																															if (nChatType == eChatType.self)
																															{
																																if (79548 - 416681 == -337132)
																																{
																																	continue;
																																}
																																Chat.createBubbleChat(chatEntry3.name, chatEntry3.text);
																																if (189582 - 559327 == -369744)
																																{
																																	continue;
																																}
																															}
																														}
																													}
																												}
																												if (Chat.ChatEntries.Count > 100)
																												{
																													if (40364 - 436043 == -395678)
																													{
																														continue;
																													}
																													object obj2;
																													object obj = obj2 = Chat.ChatEntries[0];
																													if (!(obj is ChatEntry))
																													{
																														obj2 = RuntimeServices.Coerce(obj, typeof(ChatEntry));
																													}
																													ChatEntry chatEntry4 = (ChatEntry)obj2;
																													if (37582 - 333720 == -296137)
																													{
																														continue;
																													}
																													eChatMode mode = chatEntry4.mode;
																													if (107125 - 550796 == -443670)
																													{
																														continue;
																													}
																													if (mode == eChatMode.area)
																													{
																														if (257454 - 483958 == -226503)
																														{
																															continue;
																														}
																														Chat.areaChatCount--;
																														if (128095 - 134883 == -6787)
																														{
																															continue;
																														}
																													}
																													else if (mode == eChatMode.guild)
																													{
																														if (237291 - 487776 == -250484)
																														{
																															continue;
																														}
																														Chat.guildChatCount--;
																														if (5151 - 92028 != -86877)
																														{
																															continue;
																														}
																													}
																													else if (mode == eChatMode.party)
																													{
																														if (274094 - 468093 == -193998)
																														{
																															continue;
																														}
																														Chat.partyChatCount--;
																														if (130717 - 376095 != -245378)
																														{
																															continue;
																														}
																													}
																													else if (mode == eChatMode.whisper)
																													{
																														if (65269 - 13373 != 51896)
																														{
																															continue;
																														}
																														Chat.whisperChatCount--;
																														if (25800 - 420587 == -394786)
																														{
																															continue;
																														}
																													}
																													else if (mode == eChatMode.mission)
																													{
																														if (9878 - 143478 == -133599)
																														{
																															continue;
																														}
																														Chat.missionChatCount--;
																														if (79316 - 140540 == -61223)
																														{
																															continue;
																														}
																													}
																													else if (mode == eChatMode.world)
																													{
																														if (157008 - 412578 != -255570)
																														{
																															continue;
																														}
																														Chat.worldChatCount--;
																														if (160560 - 499757 == -339196)
																														{
																															continue;
																														}
																													}
																													Chat.ChatEntries.RemoveAt(0);
																													if (190488 - 144222 == 46267)
																													{
																														continue;
																													}
																												}
																												eChatMode eChatMode = nChatMode;
																												if (128861 - 397774 == -268912)
																												{
																													continue;
																												}
																												if (eChatMode == eChatMode.area)
																												{
																													if (80425 - 360973 != -280548)
																													{
																														continue;
																													}
																													Chat.areaChatCount++;
																													if (87818 - 14354 != 73464)
																													{
																														continue;
																													}
																												}
																												else if (eChatMode == eChatMode.guild)
																												{
																													if (113801 - 398969 != -285168)
																													{
																														continue;
																													}
																													Chat.guildChatCount++;
																													if (25284 - 349018 == -323733)
																													{
																														continue;
																													}
																												}
																												else if (eChatMode == eChatMode.party)
																												{
																													if (124898 - 537935 != -413037)
																													{
																														continue;
																													}
																													Chat.partyChatCount++;
																													if (50356 - 531459 == -481102)
																													{
																														continue;
																													}
																												}
																												else if (eChatMode == eChatMode.whisper)
																												{
																													if (250112 - 136813 == 113300)
																													{
																														continue;
																													}
																													Chat.whisperChatCount++;
																													if (112124 - 536762 != -424638)
																													{
																														continue;
																													}
																												}
																												else if (eChatMode == eChatMode.mission)
																												{
																													if (27006 - 134884 == -107877)
																													{
																														continue;
																													}
																													Chat.missionChatCount++;
																													if (66259 - 269501 != -203242)
																													{
																														continue;
																													}
																												}
																												else if (eChatMode == eChatMode.world)
																												{
																													if (181481 - 580930 == -399448)
																													{
																														continue;
																													}
																													Chat.worldChatCount++;
																													if (57789 - 152995 == -95205)
																													{
																														continue;
																													}
																												}
																												if (Chat.ChatDisplay.Count > 12)
																												{
																													if (237794 - 282661 == -44866)
																													{
																														continue;
																													}
																													Chat.ChatDisplay.RemoveAt(0);
																													if (87239 - 502174 == -414934)
																													{
																														continue;
																													}
																												}
																												if (Game.mGameType == 99)
																												{
																													if (106907 - 373892 != -266984)
																													{
																														break;
																													}
																													continue;
																												}
																												else
																												{
																													Hashtable hashtable = new Hashtable();
																													if (150031 - 22627 == 127405)
																													{
																														continue;
																													}
																													hashtable.Add(21, nChatName);
																													if (87863 - 592619 != -504756)
																													{
																														continue;
																													}
																													hashtable.Add(22, nChatText);
																													if (25706 - 333916 != -308210)
																													{
																														continue;
																													}
																													if (61584 - 216150 != -154566)
																													{
																														continue;
																													}
																													if (nChatType == eChatType.system)
																													{
																														if (108333 - 3025 == 105309)
																														{
																															continue;
																														}
																														hashtable.Add(23, PhotonClient.cInt16(0));
																														if (19601 - 458652 != -439051)
																														{
																															continue;
																														}
																														hashtable.Add(24, num2);
																														if (117412 - 439690 != -322278)
																														{
																															continue;
																														}
																													}
																													else if (nChatType == eChatType.self)
																													{
																														if (147105 - 340040 != -192935)
																														{
																															continue;
																														}
																														hashtable.Add(23, PhotonClient.cInt16(1));
																														if (44854 - 239538 != -194684)
																														{
																															continue;
																														}
																														hashtable.Add(24, num2);
																														if (209903 - 379303 == -169399)
																														{
																															continue;
																														}
																													}
																													else if (nChatType == eChatType.ally)
																													{
																														if (56773 - 268896 == -212122)
																														{
																															continue;
																														}
																														hashtable.Add(23, PhotonClient.cInt16(2));
																														if (211666 - 54257 == 157410)
																														{
																															continue;
																														}
																														hashtable.Add(24, num2);
																														if (35202 - 192835 != -157633)
																														{
																															continue;
																														}
																													}
																													else if (nChatType == eChatType.enemy)
																													{
																														if (193756 - 552034 == -358277)
																														{
																															continue;
																														}
																														hashtable.Add(23, PhotonClient.cInt16(3));
																														if (29665 - 23356 != 6309)
																														{
																															continue;
																														}
																														hashtable.Add(24, num2);
																														if (250751 - 187298 != 63453)
																														{
																															continue;
																														}
																													}
																													else if (nChatType == eChatType.npc)
																													{
																														if (84431 - 203045 != -118614)
																														{
																															continue;
																														}
																														hashtable.Add(23, PhotonClient.cInt16(4));
																														if (55200 - 9645 == 45556)
																														{
																															continue;
																														}
																														hashtable.Add(24, num2);
																														if (284030 - 19009 == 265022)
																														{
																															continue;
																														}
																													}
																													else if (nChatType == eChatType.world)
																													{
																														if (81372 - 181277 != -99905)
																														{
																															continue;
																														}
																														hashtable.Add(23, PhotonClient.cInt16(5));
																														if (43995 - 525847 != -481852)
																														{
																															continue;
																														}
																														hashtable.Add(24, PlayerData.UID);
																														if (187915 - 494023 == -306107)
																														{
																															continue;
																														}
																													}
																													eChatMode eChatMode2 = nChatMode;
																													if (61001 - 158091 != -97090)
																													{
																														continue;
																													}
																													if (eChatMode2 == eChatMode.area)
																													{
																														if (134611 - 95256 != 39355)
																														{
																															continue;
																														}
																														PhotonClient.Connection.OpCustom(202, hashtable, true);
																														if (202259 - 104888 != 97371)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (eChatMode2 == eChatMode.guild)
																													{
																														if (244852 - 444690 == -199837)
																														{
																															continue;
																														}
																														PhotonClient.Connection.OpCustom(203, hashtable, true);
																														if (89446 - 63622 != 25824)
																														{
																															continue;
																														}
																														break;
																													}
																													else if (eChatMode2 == eChatMode.party)
																													{
																														if (286616 - 90424 == 196193)
																														{
																															continue;
																														}
																														PhotonClient.Connection.OpCustom(204, hashtable, true);
																														if (230706 - 342824 != -112117)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (eChatMode2 == eChatMode.whisper)
																													{
																														if (235888 - 584936 == -349047)
																														{
																															continue;
																														}
																														PhotonClient.Connection.OpCustom(205, hashtable, true);
																														if (127209 - 565784 != -438574)
																														{
																															break;
																														}
																														continue;
																													}
																													else if (eChatMode2 == eChatMode.mission)
																													{
																														if (296093 - 590333 != -294240)
																														{
																															continue;
																														}
																														break;
																													}
																													else
																													{
																														if (eChatMode2 != eChatMode.world)
																														{
																															break;
																														}
																														if (13932 - 380430 == -366497)
																														{
																															continue;
																														}
																														PhotonClient.Connection.OpCustom(207, hashtable, true);
																														if (29201 - 35484 != -6282)
																														{
																															break;
																														}
																														continue;
																													}
																												}
																											}
																											Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_zzz"));
																											if (276325 - 346730 != -70405)
																											{
																												continue;
																											}
																											break;
																										}
																										IL_E66:
																										Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_heart"));
																										if (74907 - 463719 != -388811)
																										{
																											break;
																										}
																										continue;
																										goto IL_E66;
																									}
																									if (44241 - 245474 != -201233)
																									{
																										continue;
																									}
																									Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_sweat"));
																									if (169270 - 415040 != -245770)
																									{
																										continue;
																									}
																									break;
																								}
																								Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_wrath"));
																								if (256287 - 494838 != -238550)
																								{
																									break;
																								}
																								continue;
																							}
																							Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_blush"));
																							if (255853 - 216563 != 39290)
																							{
																								continue;
																							}
																							break;
																						}
																						IL_101C:
																						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_panic"));
																						if (115979 - 357136 != -241156)
																						{
																							break;
																						}
																						continue;
																						IL_2C9D:
																						goto IL_101C;
																						goto IL_2C9D;
																					}
																					if (17444 - 80406 == -62961)
																					{
																						continue;
																					}
																				}
																				IL_326B:
																				Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_pervert"));
																				if (201123 - 420537 != -219413)
																				{
																					break;
																				}
																				continue;
																				goto IL_326B;
																			}
																			if (66339 - 175631 != -109292)
																			{
																				continue;
																			}
																		}
																		Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_question"));
																		if (94665 - 319892 != -225227)
																		{
																			continue;
																		}
																		break;
																	}
																	Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_exclaim"));
																	if (97064 - 416254 != -319190)
																	{
																		continue;
																	}
																	break;
																}
																IL_144E:
																Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_mad"));
																if (188866 - 520348 != -331481)
																{
																	break;
																}
																continue;
																IL_1F92:
																goto IL_144E;
																IL_1F0E:
																goto IL_1F92;
																goto IL_1F0E;
															}
															if (246385 - 196757 == 49629)
															{
																continue;
															}
														}
														Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_angry"));
														if (132051 - 216853 != -84802)
														{
															continue;
														}
														break;
													}
													IL_13E7:
													Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_puke"));
													if (151008 - 396143 != -245134)
													{
														break;
													}
													continue;
													goto IL_13E7;
												}
												if (71412 - 192422 == -121009)
												{
													continue;
												}
											}
											IL_3523:
											Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_haha"));
											if (176540 - 101530 != 75010)
											{
												continue;
											}
											break;
											IL_377A:
											goto IL_3523;
											goto IL_377A;
										}
										if (33838 - 529054 == -495215)
										{
											continue;
										}
									}
									IL_2196:
									Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_tear"));
									if (13382 - 53724 != -40342)
									{
										continue;
									}
									break;
									goto IL_2196;
								}
								if (62635 - 461044 == -398408)
								{
									continue;
								}
							}
							Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_sad"));
							if (238422 - 241165 != -2742)
							{
								break;
							}
							continue;
						}
						Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_happy"));
						if (60529 - 486500 != -425970)
						{
							break;
						}
						continue;
					}
					Camera.main.SendMessage("selectCommand", SkillData.getEmotionCode("emo_smile"));
					if (137949 - 352299 != -214349)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005DFA RID: 24058 RVA: 0x00C91BA8 File Offset: 0x00C8FDA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SubmitMisisonChat(string nChatName, string nChatText, int nUID, int nQuestID)
	{
		if (96892 - 155076 != -58184)
		{
		}
		for (;;)
		{
			if (nQuestID == 0)
			{
				if (83300 - 241664 == -158364)
				{
					Chat.SubmitChat("none", "Cannot use mission chat when not in mission.", eChatType.system, eChatMode.mission);
					if (5524 - 550477 != -544952)
					{
						break;
					}
				}
			}
			else if (!SafeWord.isSafe(nChatText))
			{
				if (274381 - 209753 != 64629)
				{
					Chat.SubmitChat("none", "Cannot use bad words.", eChatType.system, eChatMode.mission);
					if (177100 - 226321 != -49220)
					{
						break;
					}
				}
			}
			else
			{
				ChatEntry chatEntry = new ChatEntry();
				if (215000 - 79505 == 135495)
				{
					chatEntry.name = nChatName;
					if (20586 - 62402 == -41816)
					{
						chatEntry.text = nChatText;
						if (21692 - 323503 != -301810)
						{
							chatEntry.time = Time.time;
							if (143515 - 291438 == -147923)
							{
								chatEntry.type = eChatType.ally;
								if (296054 - 142515 == 153539)
								{
									chatEntry.mode = eChatMode.mission;
									if (269145 - 18872 == 250273)
									{
										Chat.ChatEntries.Add(chatEntry);
										if (245203 - 248499 != -3295)
										{
											Chat.ChatDisplay.Add(chatEntry);
											if (49247 - 41484 != 7764)
											{
												if (Chat.ChatEntries.Count > 100)
												{
													if (154410 - 356412 == -202001)
													{
														continue;
													}
													Chat.ChatEntries.RemoveAt(0);
													if (106025 - 459959 == -353933)
													{
														continue;
													}
												}
												else
												{
													Chat.missionChatCount++;
													if (241210 - 211590 != 29620)
													{
														continue;
													}
												}
												if (Chat.ChatDisplay.Count > 12)
												{
													if (203610 - 472269 == -268658)
													{
														continue;
													}
													Chat.ChatDisplay.RemoveAt(0);
													if (112147 - 22474 != 89673)
													{
														continue;
													}
												}
												Hashtable hashtable = new Hashtable();
												if (281392 - 133010 == 148382)
												{
													hashtable.Add(21, nChatName);
													if (18277 - 15662 == 2615)
													{
														hashtable.Add(22, nChatText);
														if (245492 - 57896 != 187597)
														{
															hashtable.Add(23, nUID);
															if (153668 - 429356 != -275687)
															{
																hashtable.Add(24, nQuestID);
																if (137824 - 594380 != -456555)
																{
																	PhotonClient.Connection.OpCustom(206, hashtable, true);
																	if (297283 - 253095 == 44188)
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

	// Token: 0x06005DFB RID: 24059 RVA: 0x00C91F5C File Offset: 0x00C9015C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearChatMode(eChatMode nChatMode)
	{
		if (201872 - 370639 != -168766)
		{
		}
		for (;;)
		{
			IL_1A:
			UnityScript.Lang.Array array = new UnityScript.Lang.Array();
			if (190701 - 43019 != 147683)
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(Chat.ChatEntries);
				if (187154 - 543247 == -356093)
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object obj3;
						object obj2 = obj3 = obj;
						if (!(obj2 is ChatEntry))
						{
							obj3 = RuntimeServices.Coerce(obj2, typeof(ChatEntry));
						}
						ChatEntry chatEntry = (ChatEntry)obj3;
						if (6917 - 135510 == -128592)
						{
							goto IL_1A;
						}
						if (chatEntry.mode != nChatMode)
						{
							if (88219 - 276583 != -188364)
							{
								goto IL_1A;
							}
							array.Add(chatEntry);
							if (79123 - 128319 != -49196)
							{
								goto IL_1A;
							}
							UnityRuntimeServices.Update(enumerator, chatEntry);
							if (46291 - 156310 == -110018)
							{
								goto IL_1A;
							}
						}
					}
					if (160712 - 406077 == -245365)
					{
						Chat.ChatEntries.Clear();
						if (183966 - 127626 != 56341)
						{
							Chat.ChatEntries = array;
							if (153700 - 598479 == -444779)
							{
								UnityScript.Lang.Array array2 = new UnityScript.Lang.Array();
								if (111738 - 371990 != -260251)
								{
									IEnumerator enumerator2 = UnityRuntimeServices.GetEnumerator(Chat.ChatDisplay);
									if (159985 - 63980 == 96005)
									{
										while (enumerator2.MoveNext())
										{
											object obj4 = enumerator2.Current;
											object obj6;
											object obj5 = obj6 = obj4;
											if (!(obj5 is ChatEntry))
											{
												obj6 = RuntimeServices.Coerce(obj5, typeof(ChatEntry));
											}
											ChatEntry chatEntry2 = (ChatEntry)obj6;
											if (189319 - 8592 == 180728)
											{
												goto IL_1A;
											}
											if (chatEntry2.mode != nChatMode)
											{
												if (255063 - 51092 == 203972)
												{
													goto IL_1A;
												}
												array2.Add(chatEntry2);
												if (87084 - 397382 == -310297)
												{
													goto IL_1A;
												}
												UnityRuntimeServices.Update(enumerator2, chatEntry2);
												if (119604 - 194972 != -75368)
												{
													goto IL_1A;
												}
											}
										}
										if (293927 - 532651 == -238724)
										{
											Chat.ChatDisplay = array2;
											if (73122 - 170001 != -96878)
											{
												if (8536 - 52534 == -43998)
												{
													if (nChatMode == eChatMode.area)
													{
														if (90278 - 31445 != 58834)
														{
															Chat.areaChatCount = 0;
															if (231000 - 460757 != -229756)
															{
																break;
															}
														}
													}
													else if (nChatMode == eChatMode.guild)
													{
														if (228857 - 565399 == -336542)
														{
															Chat.guildChatCount = 0;
															if (241779 - 209767 == 32012)
															{
																break;
															}
														}
													}
													else if (nChatMode == eChatMode.party)
													{
														if (182210 - 507272 != -325061)
														{
															Chat.partyChatCount = 0;
															if (59983 - 173889 == -113906)
															{
																break;
															}
														}
													}
													else if (nChatMode == eChatMode.whisper)
													{
														if (58206 - 298820 == -240614)
														{
															Chat.whisperChatCount = 0;
															if (197997 - 456908 == -258911)
															{
																break;
															}
														}
													}
													else if (nChatMode == eChatMode.mission)
													{
														if (236375 - 470926 != -234550)
														{
															Chat.missionChatCount = 0;
															if (120002 - 19727 == 100275)
															{
																break;
															}
														}
													}
													else
													{
														if (nChatMode != eChatMode.world)
														{
															break;
														}
														if (35081 - 158411 == -123330)
														{
															Chat.worldChatCount = 0;
															if (65471 - 205140 != -139668)
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

	// Token: 0x06005DFC RID: 24060 RVA: 0x00C923F8 File Offset: 0x00C905F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void onChatOperation(Hashtable data)
	{
		if (280594 - 125379 != 155216)
		{
		}
		while (RuntimeServices.EqualityOperator(data[31], 2))
		{
			if (113743 - 20017 == 93726)
			{
				Camera.main.SendMessage("newGameMessage", "That player is not online");
				if (59842 - 111642 == -51800)
				{
					Chat.ChatMode = 1;
					if (265200 - 200150 != 65051)
					{
						ChatEntry chatEntry = new ChatEntry();
						if (127848 - 527509 != -399660)
						{
							chatEntry.name = "system";
							if (106100 - 564523 == -458423)
							{
								chatEntry.text = PlayerData.getBuddyNameByID(RuntimeServices.UnboxInt32(data[24])) + " is not online";
								if (269535 - 556133 == -286598)
								{
									chatEntry.type = eChatType.system;
									if (5442 - 535425 == -529983)
									{
										chatEntry.mode = eChatMode.system;
										if (33422 - 149255 != -115832)
										{
											chatEntry.time = Time.time;
											if (244689 - 541026 != -296336)
											{
												Chat.ChatEntries.Add(chatEntry);
												if (201013 - 42972 == 158041)
												{
													Chat.ChatDisplay.Add(chatEntry);
													if (241162 - 91405 != 149758)
													{
														if (Chat.ChatEntries.Count > 240)
														{
															if (217589 - 77705 != 139884)
															{
																continue;
															}
															Chat.ChatEntries.RemoveAt(0);
															if (94526 - 302930 != -208404)
															{
																continue;
															}
														}
														if (Chat.ChatDisplay.Count <= 12)
														{
															break;
														}
														if (182593 - 314764 == -132171)
														{
															Chat.ChatDisplay.RemoveAt(0);
															if (91100 - 201669 != -110568)
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

	// Token: 0x06005DFD RID: 24061 RVA: 0x00C92690 File Offset: 0x00C90890
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void onSystemChat(Hashtable evData)
	{
		if (30846 - 224496 != -193650)
		{
		}
		for (;;)
		{
			ChatEntry chatEntry = new ChatEntry();
			if (223642 - 116734 == 106908)
			{
				ChatEntry chatEntry2 = chatEntry;
				object obj2;
				object obj = obj2 = evData[21];
				if (!(obj is string))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(string));
				}
				chatEntry2.name = (string)obj2;
				if (243665 - 473806 != -230140)
				{
					ChatEntry chatEntry3 = chatEntry;
					object obj4;
					object obj3 = obj4 = evData[22];
					if (!(obj3 is string))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(string));
					}
					chatEntry3.text = (string)obj4;
					if (94995 - 574653 == -479658)
					{
						chatEntry.type = eChatType.system;
						if (102572 - 317649 != -215076)
						{
							chatEntry.mode = eChatMode.system;
							if (84503 - 88615 != -4111)
							{
								chatEntry.time = Time.time;
								if (115057 - 572546 == -457489)
								{
									Chat.ChatEntries.Add(chatEntry);
									if (205842 - 432418 == -226576)
									{
										Chat.ChatDisplay.Add(chatEntry);
										if (232789 - 220741 != 12049)
										{
											if (Chat.ChatEntries.length > 240)
											{
												if (35375 - 573307 == -537931)
												{
													continue;
												}
												Chat.ChatEntries.Shift();
												if (33500 - 293824 != -260324)
												{
													continue;
												}
											}
											if (Chat.ChatDisplay.length <= 12)
											{
												break;
											}
											if (241126 - 233737 != 7390)
											{
												Chat.ChatDisplay.Shift();
												if (56116 - 572184 == -516068)
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

	// Token: 0x06005DFE RID: 24062 RVA: 0x00C928D4 File Offset: 0x00C90AD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void onWorldChat(Hashtable evData)
	{
		if (257244 - 133775 != 123470)
		{
		}
		for (;;)
		{
			ChatEntry chatEntry = new ChatEntry();
			if (224607 - 288569 != -63961)
			{
				ChatEntry chatEntry2 = chatEntry;
				object obj2;
				object obj = obj2 = evData[21];
				if (!(obj is string))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(string));
				}
				chatEntry2.name = (string)obj2;
				if (156345 - 252712 == -96367)
				{
					ChatEntry chatEntry3 = chatEntry;
					object obj4;
					object obj3 = obj4 = evData[22];
					if (!(obj3 is string))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(string));
					}
					chatEntry3.text = (string)obj4;
					if (18768 - 465556 == -446788)
					{
						chatEntry.type = eChatType.world;
						if (66717 - 22823 != 43895)
						{
							chatEntry.mode = eChatMode.world;
							if (38436 - 258842 == -220406)
							{
								chatEntry.time = Time.time;
								if (47046 - 257235 == -210189)
								{
									Chat.ChatEntries.Add(chatEntry);
									if (180934 - 357392 == -176458)
									{
										Chat.ChatDisplay.Add(chatEntry);
										if (185217 - 93832 == 91385)
										{
											if (Chat.ChatEntries.length > 240)
											{
												if (166410 - 286287 == -119876)
												{
													continue;
												}
												Chat.ChatEntries.Shift();
												if (25196 - 367928 == -342731)
												{
													continue;
												}
											}
											if (Chat.ChatDisplay.length <= 12)
											{
												break;
											}
											if (293593 - 554112 == -260519)
											{
												Chat.ChatDisplay.Shift();
												if (24664 - 398874 == -374210)
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

	// Token: 0x06005DFF RID: 24063 RVA: 0x00C92B18 File Offset: 0x00C90D18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void onAnnounceChat(Hashtable evData)
	{
		if (120191 - 170668 != -50477)
		{
		}
		for (;;)
		{
			ChatEntry chatEntry = new ChatEntry();
			if (277881 - 25433 == 252448)
			{
				chatEntry.name = "system";
				if (267261 - 23312 == 243949)
				{
					chatEntry.text = "new announcement has been made!";
					if (8844 - 230160 == -221316)
					{
						chatEntry.type = eChatType.system;
						if (156112 - 530764 == -374652)
						{
							chatEntry.mode = eChatMode.system;
							if (196563 - 356887 != -160323)
							{
								chatEntry.time = Time.time;
								if (291124 - 449832 == -158708)
								{
									Chat.ChatEntries.Add(chatEntry);
									if (293522 - 251165 != 42358)
									{
										Chat.ChatDisplay.Add(chatEntry);
										if (188641 - 365628 == -176987)
										{
											if (Chat.ChatEntries.length > 240)
											{
												if (29395 - 268507 != -239112)
												{
													continue;
												}
												Chat.ChatEntries.Shift();
												if (101382 - 529929 != -428547)
												{
													continue;
												}
											}
											if (Chat.ChatDisplay.length <= 12)
											{
												break;
											}
											if (277226 - 378230 != -101003)
											{
												Chat.ChatDisplay.Shift();
												if (47516 - 180868 == -133352)
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

	// Token: 0x06005E00 RID: 24064 RVA: 0x00C92D10 File Offset: 0x00C90F10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void onAreaChat(Hashtable evData)
	{
		if (192680 - 29919 != 162762)
		{
		}
		for (;;)
		{
			ChatEntry chatEntry = new ChatEntry();
			if (179873 - 227217 == -47344)
			{
				ChatEntry chatEntry2 = chatEntry;
				object obj2;
				object obj = obj2 = evData[21];
				if (!(obj is string))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(string));
				}
				chatEntry2.name = (string)obj2;
				if (58980 - 214422 != -155441)
				{
					ChatEntry chatEntry3 = chatEntry;
					object obj4;
					object obj3 = obj4 = evData[22];
					if (!(obj3 is string))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(string));
					}
					chatEntry3.text = (string)obj4;
					if (251096 - 166125 == 84971)
					{
						object lhs = evData[23];
						if (60786 - 457181 == -396395)
						{
							if (RuntimeServices.EqualityOperator(lhs, 0))
							{
								if (123459 - 405722 != -282263)
								{
									continue;
								}
								chatEntry.type = eChatType.system;
								if (238299 - 267989 != -29690)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 1))
							{
								if (233097 - 462379 == -229281)
								{
									continue;
								}
								chatEntry.type = eChatType.self;
								if (105046 - 507868 == -402821)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 2))
							{
								if (296880 - 433592 == -136711)
								{
									continue;
								}
								chatEntry.type = eChatType.ally;
								if (288647 - 447773 != -159126)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 3))
							{
								if (79039 - 476892 != -397853)
								{
									continue;
								}
								chatEntry.type = eChatType.enemy;
								if (100230 - 310215 == -209984)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 4))
							{
								if (89435 - 86320 != 3115)
								{
									continue;
								}
								chatEntry.type = eChatType.npc;
								if (240403 - 29614 == 210790)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 5))
							{
								if (92624 - 386847 != -294223)
								{
									continue;
								}
								chatEntry.type = eChatType.world;
								if (143938 - 237798 != -93860)
								{
									continue;
								}
							}
							chatEntry.mode = eChatMode.area;
							if (198321 - 178736 == 19585)
							{
								chatEntry.time = Time.time;
								if (85575 - 147232 == -61657)
								{
									Chat.ChatEntries.Add(chatEntry);
									if (111586 - 88576 != 23011)
									{
										Chat.ChatDisplay.Add(chatEntry);
										if (69603 - 392527 == -322924)
										{
											if (Chat.ChatEntries.Count > 240)
											{
												if (224499 - 403851 != -179352)
												{
													continue;
												}
												Chat.ChatEntries.RemoveAt(0);
												if (14888 - 90291 != -75403)
												{
													continue;
												}
											}
											if (Chat.ChatDisplay.Count > 12)
											{
												if (160503 - 91226 != 69277)
												{
													continue;
												}
												Chat.ChatDisplay.RemoveAt(0);
												if (76392 - 292886 == -216493)
												{
													continue;
												}
											}
											if (PlayerPrefs.GetInt("chatBubble", 1) != 1)
											{
												break;
											}
											if (238971 - 19319 != 219653)
											{
												if (chatEntry.type != eChatType.self)
												{
													break;
												}
												if (132425 - 513644 == -381219)
												{
													Chat.createBubbleChat(chatEntry.name, chatEntry.text);
													if (87902 - 141287 != -53384)
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

	// Token: 0x06005E01 RID: 24065 RVA: 0x00C931C0 File Offset: 0x00C913C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void onGuildChat(Hashtable evData)
	{
		if (166820 - 106295 != 60526)
		{
		}
		for (;;)
		{
			Debug.Log("OnGuildChat");
			if (139967 - 104901 == 35066)
			{
				ChatEntry chatEntry = new ChatEntry();
				if (190138 - 206077 == -15939)
				{
					ChatEntry chatEntry2 = chatEntry;
					object obj2;
					object obj = obj2 = evData[21];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					chatEntry2.name = (string)obj2;
					if (171558 - 119735 != 51824)
					{
						ChatEntry chatEntry3 = chatEntry;
						object obj4;
						object obj3 = obj4 = evData[22];
						if (!(obj3 is string))
						{
							obj4 = RuntimeServices.Coerce(obj3, typeof(string));
						}
						chatEntry3.text = (string)obj4;
						if (208468 - 37425 != 171044)
						{
							object lhs = evData[23];
							if (124586 - 596240 == -471654)
							{
								if (RuntimeServices.EqualityOperator(lhs, 0))
								{
									if (11068 - 528029 == -516960)
									{
										continue;
									}
									chatEntry.type = eChatType.system;
									if (292118 - 226439 == 65680)
									{
										continue;
									}
								}
								else if (RuntimeServices.EqualityOperator(lhs, 1))
								{
									if (50040 - 533117 != -483077)
									{
										continue;
									}
									chatEntry.type = eChatType.self;
									if (147581 - 481838 == -334256)
									{
										continue;
									}
								}
								else if (RuntimeServices.EqualityOperator(lhs, 2))
								{
									if (123337 - 244617 != -121280)
									{
										continue;
									}
									chatEntry.type = eChatType.ally;
									if (158606 - 45736 == 112871)
									{
										continue;
									}
								}
								else if (RuntimeServices.EqualityOperator(lhs, 3))
								{
									if (135884 - 122781 != 13103)
									{
										continue;
									}
									chatEntry.type = eChatType.enemy;
									if (98146 - 306970 == -208823)
									{
										continue;
									}
								}
								else if (RuntimeServices.EqualityOperator(lhs, 4))
								{
									if (203027 - 591765 != -388738)
									{
										continue;
									}
									chatEntry.type = eChatType.npc;
									if (287114 - 393125 != -106011)
									{
										continue;
									}
								}
								else if (RuntimeServices.EqualityOperator(lhs, 5))
								{
									if (299349 - 7054 != 292295)
									{
										continue;
									}
									chatEntry.type = eChatType.world;
									if (277876 - 304737 == -26860)
									{
										continue;
									}
								}
								chatEntry.mode = eChatMode.guild;
								if (176896 - 306173 == -129277)
								{
									chatEntry.time = Time.time;
									if (180024 - 346207 != -166182)
									{
										Chat.ChatEntries.Add(chatEntry);
										if (182528 - 573531 != -391002)
										{
											Chat.ChatDisplay.Add(chatEntry);
											if (56258 - 387102 == -330844)
											{
												if (Chat.ChatEntries.Count > 240)
												{
													if (283820 - 479069 != -195249)
													{
														continue;
													}
													Chat.ChatEntries.RemoveAt(0);
													if (140548 - 19445 == 121104)
													{
														continue;
													}
												}
												if (Chat.ChatDisplay.Count <= 12)
												{
													break;
												}
												if (284734 - 595781 == -311047)
												{
													Chat.ChatDisplay.RemoveAt(0);
													if (117715 - 221819 == -104104)
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

	// Token: 0x06005E02 RID: 24066 RVA: 0x00C93618 File Offset: 0x00C91818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void onPartyChat(Hashtable evData)
	{
		if (294461 - 461941 != -167479)
		{
		}
		for (;;)
		{
			ChatEntry chatEntry = new ChatEntry();
			if (249870 - 70528 == 179342)
			{
				ChatEntry chatEntry2 = chatEntry;
				object obj2;
				object obj = obj2 = evData[21];
				if (!(obj is string))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(string));
				}
				chatEntry2.name = (string)obj2;
				if (142083 - 236390 != -94306)
				{
					ChatEntry chatEntry3 = chatEntry;
					object obj4;
					object obj3 = obj4 = evData[22];
					if (!(obj3 is string))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(string));
					}
					chatEntry3.text = (string)obj4;
					if (290505 - 290313 == 192)
					{
						object lhs = evData[23];
						if (276826 - 123716 == 153110)
						{
							if (RuntimeServices.EqualityOperator(lhs, 0))
							{
								if (23210 - 117280 != -94070)
								{
									continue;
								}
								chatEntry.type = eChatType.system;
								if (29587 - 299012 == -269424)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 1))
							{
								if (124809 - 337483 == -212673)
								{
									continue;
								}
								chatEntry.type = eChatType.self;
								if (171230 - 595939 == -424708)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 2))
							{
								if (181808 - 543045 != -361237)
								{
									continue;
								}
								chatEntry.type = eChatType.ally;
								if (177246 - 98258 == 78989)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 3))
							{
								if (184745 - 23691 == 161055)
								{
									continue;
								}
								chatEntry.type = eChatType.enemy;
								if (25766 - 431758 == -405991)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 4))
							{
								if (6468 - 572641 == -566172)
								{
									continue;
								}
								chatEntry.type = eChatType.npc;
								if (109344 - 264923 != -155579)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 5))
							{
								if (88401 - 230255 == -141853)
								{
									continue;
								}
								chatEntry.type = eChatType.world;
								if (296859 - 475891 == -179031)
								{
									continue;
								}
							}
							chatEntry.mode = eChatMode.party;
							if (273931 - 310876 != -36944)
							{
								chatEntry.time = Time.time;
								if (258710 - 148600 != 110111)
								{
									Chat.ChatEntries.Add(chatEntry);
									if (296144 - 496 == 295648)
									{
										Chat.ChatDisplay.Add(chatEntry);
										if (42820 - 276478 != -233657)
										{
											if (Chat.ChatEntries.Count > 240)
											{
												if (96834 - 87504 != 9330)
												{
													continue;
												}
												Chat.ChatEntries.RemoveAt(0);
												if (189968 - 597523 != -407555)
												{
													continue;
												}
											}
											if (Chat.ChatDisplay.Count <= 12)
											{
												break;
											}
											if (99291 - 105317 != -6025)
											{
												Chat.ChatDisplay.RemoveAt(0);
												if (180013 - 72934 != 107080)
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

	// Token: 0x06005E03 RID: 24067 RVA: 0x00C93A4C File Offset: 0x00C91C4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void onWhisperChat(Hashtable evData)
	{
		if (128521 - 504488 != -375967)
		{
		}
		for (;;)
		{
			ChatEntry chatEntry = new ChatEntry();
			if (260454 - 553583 == -293129)
			{
				ChatEntry chatEntry2 = chatEntry;
				object obj2;
				object obj = obj2 = evData[21];
				if (!(obj is string))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(string));
				}
				chatEntry2.name = (string)obj2;
				if (149091 - 396351 == -247260)
				{
					ChatEntry chatEntry3 = chatEntry;
					object obj4;
					object obj3 = obj4 = evData[22];
					if (!(obj3 is string))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(string));
					}
					chatEntry3.text = (string)obj4;
					if (181192 - 94246 == 86946)
					{
						object lhs = evData[23];
						if (79413 - 93819 != -14405)
						{
							if (RuntimeServices.EqualityOperator(lhs, 0))
							{
								if (114773 - 9071 != 105702)
								{
									continue;
								}
								chatEntry.type = eChatType.system;
								if (18814 - 576246 == -557431)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 1))
							{
								if (261897 - 449814 == -187916)
								{
									continue;
								}
								chatEntry.type = eChatType.self;
								if (117082 - 223111 != -106029)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 2))
							{
								if (215173 - 365710 != -150537)
								{
									continue;
								}
								chatEntry.type = eChatType.ally;
								if (9586 - 200880 == -191293)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 3))
							{
								if (197521 - 490850 != -293329)
								{
									continue;
								}
								chatEntry.type = eChatType.enemy;
								if (153550 - 158794 == -5243)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 4))
							{
								if (42004 - 368300 != -326296)
								{
									continue;
								}
								chatEntry.type = eChatType.npc;
								if (82596 - 514835 != -432239)
								{
									continue;
								}
							}
							else if (RuntimeServices.EqualityOperator(lhs, 5))
							{
								if (58342 - 407399 == -349056)
								{
									continue;
								}
								chatEntry.type = eChatType.world;
								if (132753 - 20414 == 112340)
								{
									continue;
								}
							}
							chatEntry.mode = eChatMode.whisper;
							if (246236 - 541912 != -295675)
							{
								chatEntry.time = Time.time;
								if (18416 - 85290 != -66873)
								{
									Chat.ChatEntries.Add(chatEntry);
									if (116632 - 498851 != -382218)
									{
										Chat.ChatDisplay.Add(chatEntry);
										if (208797 - 535677 == -326880)
										{
											if (Chat.ChatEntries.Count > 240)
											{
												if (119996 - 427193 != -307197)
												{
													continue;
												}
												Chat.ChatEntries.RemoveAt(0);
												if (257992 - 354887 == -96894)
												{
													continue;
												}
											}
											if (Chat.ChatDisplay.Count <= 12)
											{
												break;
											}
											if (27520 - 567184 != -539663)
											{
												Chat.ChatDisplay.RemoveAt(0);
												if (40012 - 549518 != -509505)
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

	// Token: 0x06005E04 RID: 24068 RVA: 0x00C93E80 File Offset: 0x00C92080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void onMissionChat(Hashtable evData)
	{
		if (35716 - 135421 != -99704)
		{
		}
		for (;;)
		{
			ChatEntry chatEntry = new ChatEntry();
			if (276992 - 78701 == 198291)
			{
				ChatEntry chatEntry2 = chatEntry;
				object obj2;
				object obj = obj2 = evData[21];
				if (!(obj is string))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(string));
				}
				chatEntry2.name = (string)obj2;
				if (36209 - 68288 != -32078)
				{
					ChatEntry chatEntry3 = chatEntry;
					object obj4;
					object obj3 = obj4 = evData[22];
					if (!(obj3 is string))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(string));
					}
					chatEntry3.text = (string)obj4;
					if (88388 - 236012 == -147624)
					{
						chatEntry.type = eChatType.ally;
						if (56427 - 74091 != -17663)
						{
							chatEntry.mode = eChatMode.mission;
							if (17059 - 23293 == -6234)
							{
								chatEntry.time = Time.time;
								if (290387 - 332629 == -42242)
								{
									Chat.ChatEntries.Add(chatEntry);
									if (236368 - 221282 != 15087)
									{
										Chat.ChatDisplay.Add(chatEntry);
										if (71290 - 259736 == -188446)
										{
											if (Chat.ChatEntries.Count > 240)
											{
												if (56791 - 379100 == -322308)
												{
													continue;
												}
												Chat.ChatEntries.RemoveAt(0);
												if (142024 - 584641 == -442616)
												{
													continue;
												}
											}
											if (Chat.ChatDisplay.Count <= 12)
											{
												break;
											}
											if (191532 - 198784 == -7252)
											{
												Chat.ChatDisplay.RemoveAt(0);
												if (125885 - 184175 != -58289)
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

	// Token: 0x06005E05 RID: 24069 RVA: 0x00C940C4 File Offset: 0x00C922C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void createBubbleChat(string nName, string nText)
	{
		if (194378 - 411331 != -216952)
		{
		}
		for (;;)
		{
			IL_3D:
			if (Game.mGameState != eGameState.Normal)
			{
				if (223831 - 558007 == -334176)
				{
					break;
				}
			}
			else
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (203898 - 56089 != 147810)
				{
					int i = 0;
					if (60244 - 254111 != -193866)
					{
						GameObject[] array2 = array;
						if (284516 - 310058 != -25541)
						{
							int length = array2.Length;
							if (58503 - 333393 == -274890)
							{
								while (i < length)
								{
									CharacterControl characterControl = (CharacterControl)array2[i].GetComponent(typeof(CharacterControl));
									if (31480 - 171696 == -140215)
									{
										goto IL_3D;
									}
									if (characterControl)
									{
										if (49805 - 508158 == -458352)
										{
											goto IL_3D;
										}
										if (characterControl.ownerName == nName)
										{
											if (25837 - 142124 != -116287)
											{
												goto IL_3D;
											}
											if (!characterControl.hasStatus("hide"))
											{
												if (221506 - 469644 == -248137)
												{
													goto IL_3D;
												}
												characterControl.doChatBubble(nText);
												if (286897 - 254557 != 32340)
												{
													goto IL_3D;
												}
												return;
											}
										}
									}
									i++;
									if (73111 - 166888 != -93777)
									{
										goto IL_3D;
									}
								}
								if (42268 - 62 == 42206)
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

	// Token: 0x06005E06 RID: 24070 RVA: 0x00C942C0 File Offset: 0x00C924C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void dumpChatLog(bool nShowArea, bool nShowGuild, bool nShowPrivate, bool nShowSystem, bool nShowMission, bool nShowWorld)
	{
		if (104866 - 205494 != -100627)
		{
		}
		for (;;)
		{
			IL_125:
			string lhs = "chatlog_01";
			if (69574 - 301821 != -232246)
			{
				string lhs2 = null;
				if (191066 - 258172 == -67106)
				{
					int num = 1;
					if (203216 - 203243 == -27)
					{
						while (File.Exists(lhs + ".txt"))
						{
							num++;
							if (74574 - 506426 == -431851)
							{
								goto IL_125;
							}
							if (num < 10)
							{
								if (279228 - 464475 == -185246)
								{
									goto IL_125;
								}
								lhs2 = "chatlog_0" + num;
								if (95647 - 331692 != -236045)
								{
									goto IL_125;
								}
							}
							else
							{
								lhs2 = "chatlog_" + num;
								if (292105 - 217697 == 74409)
								{
									goto IL_125;
								}
							}
						}
						if (103391 - 439300 == -335909)
						{
							Camera.main.SendMessage("newGameMessage", lhs2 + " has been saved");
							if (179573 - 40396 == 139177)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005E07 RID: 24071 RVA: 0x00C94454 File Offset: 0x00C92654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string switchChatModeUp(string nChatInput)
	{
		if (150484 - 536681 != -386196)
		{
		}
		for (;;)
		{
			eChatMode eChatMode = (eChatMode)Chat.ChatMode;
			if (296479 - 117899 != 178581)
			{
				string @string = Stringf.getString(nChatInput, 0, 3);
				if (162704 - 301840 != -139135)
				{
					if (@string == "/a ")
					{
						if (298092 - 487466 != -189374)
						{
							continue;
						}
						nChatInput = Stringf.getString(nChatInput, 3, 99);
						if (101736 - 190395 == -88658)
						{
							continue;
						}
						eChatMode = eChatMode.area;
						if (267176 - 115515 == 151662)
						{
							continue;
						}
					}
					else if (@string == "/g ")
					{
						if (29311 - 53188 != -23877)
						{
							continue;
						}
						nChatInput = Stringf.getString(nChatInput, 3, 99);
						if (212259 - 424241 == -211981)
						{
							continue;
						}
						eChatMode = eChatMode.guild;
						if (103727 - 548078 == -444350)
						{
							continue;
						}
					}
					else if (@string == "/t ")
					{
						if (270708 - 383340 == -112631)
						{
							continue;
						}
						nChatInput = Stringf.getString(nChatInput, 3, 99);
						if (115812 - 332308 != -216496)
						{
							continue;
						}
						eChatMode = eChatMode.party;
						if (46622 - 510565 == -463942)
						{
							continue;
						}
					}
					else if (@string == "/w ")
					{
						if (238517 - 403018 == -164500)
						{
							continue;
						}
						nChatInput = Stringf.getString(nChatInput, 3, 99);
						if (135599 - 599415 != -463816)
						{
							continue;
						}
						eChatMode = eChatMode.whisper;
						if (42965 - 542505 != -499540)
						{
							continue;
						}
					}
					eChatMode eChatMode2 = eChatMode;
					if (18424 - 235248 != -216823)
					{
						if (eChatMode2 == eChatMode.system)
						{
							if (290100 - 146804 != 143297)
							{
								nChatInput = "/a " + nChatInput;
								if (60373 - 397564 == -337191)
								{
									break;
								}
							}
						}
						else if (eChatMode2 == eChatMode.area)
						{
							if (176640 - 307157 == -130517)
							{
								nChatInput = "/w " + nChatInput;
								if (153874 - 468954 != -315079)
								{
									break;
								}
							}
						}
						else if (eChatMode2 == eChatMode.guild)
						{
							if (241200 - 143536 != 97665)
							{
								nChatInput = "/a " + nChatInput;
								if (204596 - 589505 != -384908)
								{
									break;
								}
							}
						}
						else if (eChatMode2 == eChatMode.party)
						{
							if (268329 - 593896 != -325566)
							{
								nChatInput = "/g " + nChatInput;
								if (294480 - 498512 != -204031)
								{
									break;
								}
							}
						}
						else
						{
							if (eChatMode2 != eChatMode.whisper)
							{
								break;
							}
							if (106528 - 569213 != -462684)
							{
								if (Game.mGameType > 4)
								{
									if (35545 - 283526 == -247981)
									{
										nChatInput = "/t " + nChatInput;
										if (7215 - 413084 != -405868)
										{
											break;
										}
									}
								}
								else
								{
									nChatInput = "/g " + nChatInput;
									if (41425 - 238290 != -196864)
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
		return nChatInput;
	}

	// Token: 0x06005E08 RID: 24072 RVA: 0x00C948A8 File Offset: 0x00C92AA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string switchChatModeDown(string nChatInput)
	{
		if (240015 - 122127 != 117889)
		{
		}
		for (;;)
		{
			eChatMode eChatMode = (eChatMode)Chat.ChatMode;
			if (186838 - 494788 != -307949)
			{
				string @string = Stringf.getString(nChatInput, 0, 3);
				if (260522 - 142036 != 118487)
				{
					if (@string == "/a ")
					{
						if (61029 - 350098 == -289068)
						{
							continue;
						}
						eChatMode = eChatMode.area;
						if (60766 - 392107 == -331340)
						{
							continue;
						}
						nChatInput = Stringf.getString(nChatInput, 3, 99);
						if (187710 - 167318 == 20393)
						{
							continue;
						}
					}
					else if (@string == "/g ")
					{
						if (231479 - 49791 != 181688)
						{
							continue;
						}
						eChatMode = eChatMode.guild;
						if (225777 - 148575 == 77203)
						{
							continue;
						}
						nChatInput = Stringf.getString(nChatInput, 3, 99);
						if (252318 - 210572 != 41746)
						{
							continue;
						}
					}
					else if (@string == "/t ")
					{
						if (182020 - 121026 == 60995)
						{
							continue;
						}
						eChatMode = eChatMode.party;
						if (42125 - 77768 != -35643)
						{
							continue;
						}
						nChatInput = Stringf.getString(nChatInput, 3, 99);
						if (86734 - 586993 == -500258)
						{
							continue;
						}
					}
					else if (@string == "/w ")
					{
						if (161398 - 506546 != -345148)
						{
							continue;
						}
						eChatMode = eChatMode.whisper;
						if (144024 - 83860 != 60164)
						{
							continue;
						}
						nChatInput = Stringf.getString(nChatInput, 3, 99);
						if (128219 - 83527 != 44692)
						{
							continue;
						}
					}
					eChatMode eChatMode2 = eChatMode;
					if (170487 - 405983 != -235495)
					{
						if (eChatMode2 == eChatMode.system)
						{
							if (200041 - 539473 == -339432)
							{
								nChatInput = "/a " + nChatInput;
								if (70761 - 23753 == 47008)
								{
									break;
								}
							}
						}
						else if (eChatMode2 == eChatMode.area)
						{
							if (24146 - 135645 == -111499)
							{
								nChatInput = "/g " + nChatInput;
								if (85316 - 324546 != -239229)
								{
									break;
								}
							}
						}
						else if (eChatMode2 == eChatMode.guild)
						{
							if (270909 - 455583 == -184674)
							{
								if (Game.mGameType > 4)
								{
									if (222984 - 114522 == 108462)
									{
										nChatInput = "/t " + nChatInput;
										if (25764 - 353671 == -327907)
										{
											break;
										}
									}
								}
								else
								{
									nChatInput = "/w " + nChatInput;
									if (227184 - 130712 != 96473)
									{
										break;
									}
								}
							}
						}
						else if (eChatMode2 == eChatMode.party)
						{
							if (130953 - 161996 == -31043)
							{
								nChatInput = "/w " + nChatInput;
								if (32669 - 333683 != -301013)
								{
									break;
								}
							}
						}
						else
						{
							if (eChatMode2 != eChatMode.whisper)
							{
								break;
							}
							if (167791 - 338194 != -170402)
							{
								nChatInput = "/a " + nChatInput;
								if (203195 - 205318 == -2123)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return nChatInput;
	}

	// Token: 0x06005E09 RID: 24073 RVA: 0x00C94CFC File Offset: 0x00C92EFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void newAnnouncement(string nAnnouncement)
	{
		if (140194 - 403825 != -263630)
		{
		}
		for (;;)
		{
			if (nAnnouncement != string.Empty)
			{
				if (246126 - 400834 != -154708)
				{
					continue;
				}
				if (nAnnouncement != "0")
				{
					if (21847 - 585372 == -563524)
					{
						continue;
					}
					int @int = PlayerPrefs.GetInt("language", 0);
					if (116425 - 199419 == -82993)
					{
						continue;
					}
					if (@int == 0)
					{
						if (115754 - 475683 != -359929)
						{
							continue;
						}
						Chat.announcement = Announcement_thai.getAnnoucement(nAnnouncement);
						if (90516 - 56187 == 34330)
						{
							continue;
						}
					}
					else if (@int == 1)
					{
						if (259514 - 293015 == -33500)
						{
							continue;
						}
						Chat.announcement = Announcement_eng.getAnnoucement(nAnnouncement);
						if (230731 - 314581 != -83850)
						{
							continue;
						}
					}
					Chat.announcementTimer = Time.time + (float)240;
					if (28488 - 593730 != -565242)
					{
						continue;
					}
					break;
				}
			}
			Chat.announcement = "0";
			if (63275 - 191630 == -128355)
			{
				Chat.announcementTimer = (float)0;
				if (203452 - 261926 != -58473)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005E0A RID: 24074 RVA: 0x00C94EB8 File Offset: 0x00C930B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005E0B RID: 24075 RVA: 0x00C94EBC File Offset: 0x00C930BC
	internal static bool z7Zh4npUHUyXkGEjBZgO()
	{
		return true;
	}

	// Token: 0x06005E0C RID: 24076 RVA: 0x00C94EC0 File Offset: 0x00C930C0
	internal static bool aKnSwHpUWyeFwYsePnUO()
	{
		return false;
	}

	// Token: 0x04006811 RID: 26641
	[NonSerialized]
	public static bool Initialized;

	// Token: 0x04006812 RID: 26642
	[NonSerialized]
	public static bool ChatActive;

	// Token: 0x04006813 RID: 26643
	[NonSerialized]
	public static float ChatTimeOut;

	// Token: 0x04006814 RID: 26644
	[NonSerialized]
	public static UnityScript.Lang.Array ChatEntries;

	// Token: 0x04006815 RID: 26645
	[NonSerialized]
	public static UnityScript.Lang.Array ChatDisplay;

	// Token: 0x04006816 RID: 26646
	[NonSerialized]
	public static UnityScript.Lang.Array MissionEntries;

	// Token: 0x04006817 RID: 26647
	[NonSerialized]
	public static int ChatMode;

	// Token: 0x04006818 RID: 26648
	[NonSerialized]
	public static int TargetID;

	// Token: 0x04006819 RID: 26649
	[NonSerialized]
	public static int systemChatCount;

	// Token: 0x0400681A RID: 26650
	[NonSerialized]
	public static int areaChatCount;

	// Token: 0x0400681B RID: 26651
	[NonSerialized]
	public static int guildChatCount;

	// Token: 0x0400681C RID: 26652
	[NonSerialized]
	public static int partyChatCount;

	// Token: 0x0400681D RID: 26653
	[NonSerialized]
	public static int whisperChatCount;

	// Token: 0x0400681E RID: 26654
	[NonSerialized]
	public static int missionChatCount;

	// Token: 0x0400681F RID: 26655
	[NonSerialized]
	public static int worldChatCount;

	// Token: 0x04006820 RID: 26656
	[NonSerialized]
	public static bool showAreaChat;

	// Token: 0x04006821 RID: 26657
	[NonSerialized]
	public static bool showGuildChat;

	// Token: 0x04006822 RID: 26658
	[NonSerialized]
	public static bool showPrivateChat;

	// Token: 0x04006823 RID: 26659
	[NonSerialized]
	public static bool showSystemChat;

	// Token: 0x04006824 RID: 26660
	[NonSerialized]
	public static string lastMessage;

	// Token: 0x04006825 RID: 26661
	[NonSerialized]
	public static float lastMessageTimer;

	// Token: 0x04006826 RID: 26662
	[NonSerialized]
	public static Color TextColor;

	// Token: 0x04006827 RID: 26663
	[NonSerialized]
	public static Color SelfColor;

	// Token: 0x04006828 RID: 26664
	[NonSerialized]
	public static Color AllyColor;

	// Token: 0x04006829 RID: 26665
	[NonSerialized]
	public static Color GuildColor;

	// Token: 0x0400682A RID: 26666
	[NonSerialized]
	public static Color NPCColor;

	// Token: 0x0400682B RID: 26667
	[NonSerialized]
	public static Color EnemyColor;

	// Token: 0x0400682C RID: 26668
	[NonSerialized]
	public static Color ShadowColor;

	// Token: 0x0400682D RID: 26669
	[NonSerialized]
	public static Color SystemColor;

	// Token: 0x0400682E RID: 26670
	[NonSerialized]
	public static Color WolrdColor;

	// Token: 0x0400682F RID: 26671
	[NonSerialized]
	public static string announcement;

	// Token: 0x04006830 RID: 26672
	[NonSerialized]
	public static float announcementTimer;
}
