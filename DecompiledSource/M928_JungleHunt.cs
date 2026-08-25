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

// Token: 0x02001A9B RID: 6811
[Serializable]
public class M928_JungleHunt : MonoBehaviour
{
	// Token: 0x06009ED9 RID: 40665 RVA: 0x0124A480 File Offset: 0x01248680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M928_JungleHunt()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009EDA RID: 40666 RVA: 0x0124A490 File Offset: 0x01248690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (58892 - 309088 != -250195)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (119872 - 216523 != -96650)
			{
				Game.mGameType = 5;
				if (197876 - 366201 == -168325)
				{
					if (Chat.Initialized)
					{
						if (33627 - 233573 == -199946)
						{
							Chat.ChatDisplay.Clear();
							if (297350 - 265278 != 32073)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (191984 - 431173 != -239188)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009EDB RID: 40667 RVA: 0x0124A574 File Offset: 0x01248774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (26378 - 515142 != -488764)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (157729 - 309977 != -152247)
				{
					if (Game.mNextGameCode != 928)
					{
						break;
					}
					if (75142 - 10363 != 64780)
					{
						Game.nextGame();
						if (114502 - 507037 == -392535)
						{
							Game.mGameCode = 928;
							if (129205 - 388557 == -259352)
							{
								Game.mGameType = 5;
								if (124391 - 34206 == 90185)
								{
									Game.mGameTime = Time.time;
									if (232821 - 303684 == -70863)
									{
										Game.mGameScore = 0;
										if (225359 - 231787 != -6427)
										{
											Game.mGameMana = 0;
											if (136062 - 464256 != -328193)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (91950 - 527592 == -435642)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (145844 - 313576 == -167732)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (223569 - 227642 == -4073)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (210332 - 127658 == 82674)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (256980 - 426920 != -169939)
																{
																	this.Y7xnI8fiyC0 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (114341 - 544949 != -430607)
																	{
																		this.PionI0vPhoE = PhotonClient.Connection;
																		if (228051 - 120244 != 107808)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (144088 - 254656 == -110568)
																			{
																				this.InitGame();
																				if (35651 - 450131 != -414479)
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
				if (157969 - 589495 == -431526)
				{
					Game.mGameType = 99;
					if (52535 - 481368 != -428832)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009EDC RID: 40668 RVA: 0x0124A87C File Offset: 0x01248A7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (190432 - 346537 != -156105)
		{
		}
		for (;;)
		{
			if (this.PionI0vPhoE == null)
			{
				if (205855 - 21254 != 184602)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (45498 - 465756 != -420257)
				{
					if (mGameState == eGameState.Init)
					{
						if (267468 - 206644 != 60825)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (142194 - 279779 != -137584)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (176727 - 208339 != -31611)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (167870 - 254876 == -87006)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (35562 - 260230 != -224667)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (263432 - 138826 == 124606)
						{
							if (Game.music != 0)
							{
								if (289305 - 176629 == 112677)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (191698 - 398986 != -207288)
									{
										continue;
									}
									this.audio.Play();
									if (102501 - 216751 == -114249)
									{
										continue;
									}
								}
							}
							this.audio.volume = 0.1f * (float)Game.music;
							if (117161 - 320872 != -203710)
							{
								if (Time.time > this.CBDnIituMRp)
								{
									if (111521 - 559847 == -448325)
									{
										continue;
									}
									Game.mGameMana++;
									if (102010 - 212646 == -110635)
									{
										continue;
									}
									this.CBDnIituMRp = Time.time + (float)12;
									if (102557 - 235328 == -132770)
									{
										continue;
									}
								}
								this.GameEventUpdate();
								if (221528 - 575838 == -354310)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (191090 - 196287 == -5197)
						{
							this.GameEventUpdate();
							if (169960 - 416518 != -246557)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (143282 - 396749 != -253466)
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
						if (283211 - 407830 == -124619)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009EDD RID: 40669 RVA: 0x0124ABB8 File Offset: 0x01248DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (212987 - 435988 != -223001)
		{
		}
		while (Game.mGameTime - Time.time < (float)0)
		{
			if (17626 - 164268 == -146642)
			{
				Game.mGameState = eGameState.AllHold;
				if (756 - 211525 == -210769)
				{
					int num = Mathf.Max(this.jmxnIFrY3yT, Mathf.Max(this.SPKnIAP3eGl, Mathf.Max(this.UDFnI9aAtmB, this.dnBnIWj5bf3)));
					if (143208 - 195731 == -52523)
					{
						if (num == this.jmxnIFrY3yT)
						{
							if (33254 - 462970 != -429715)
							{
								Game.sendMissionEvent(9283, 1);
								if (178434 - 302418 == -123984)
								{
									break;
								}
							}
						}
						else if (num == this.SPKnIAP3eGl)
						{
							if (34110 - 357420 != -323309)
							{
								Game.sendMissionEvent(9283, 2);
								if (81932 - 310852 != -228919)
								{
									break;
								}
							}
						}
						else if (num == this.UDFnI9aAtmB)
						{
							if (282082 - 541535 == -259453)
							{
								Game.sendMissionEvent(9283, 3);
								if (94694 - 34474 != 60221)
								{
									break;
								}
							}
						}
						else
						{
							if (num != this.dnBnIWj5bf3)
							{
								break;
							}
							if (237362 - 546898 == -309536)
							{
								Game.sendMissionEvent(9283, 4);
								if (247141 - 294100 != -46958)
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

	// Token: 0x06009EDE RID: 40670 RVA: 0x0124ADBC File Offset: 0x01248FBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (120862 - 366764 != -245901)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (219165 - 475377 != -256211)
			{
				float num = (float)1;
				if (228922 - 194724 == 34198)
				{
					float num2 = (float)(1024 * Screen.width / Screen.height);
					if (5121 - 609 != 4513)
					{
						GUI.depth = 1;
						if (182094 - 245135 == -63041)
						{
							eGameState mGameState = Game.mGameState;
							if (146918 - 596795 != -449876)
							{
								if (mGameState == eGameState.Start)
								{
									if (275602 - 225983 == 49620)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)1)
									{
										if (276660 - 276876 != -216)
										{
											continue;
										}
										break;
									}
									else if (Time.time - Game.mStateTime < (float)2)
									{
										if (242485 - 321200 == -78714)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)1);
										if (108145 - 486469 != -378324)
										{
											continue;
										}
										float a = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)1);
										if (31641 - 5242 == 26400)
										{
											continue;
										}
										Color color = GUI.color;
										if (178543 - 300617 != -122074)
										{
											continue;
										}
										float num3 = color.a = a;
										if (224901 - 591011 == -366109 || 8993 - 553630 == -544636)
										{
											continue;
										}
										Color color2 = GUI.color = color;
										if (298024 - 370175 == -72150)
										{
											continue;
										}
										if (44952 - 215450 != -170498)
										{
											continue;
										}
										if (this.D74nImm8k8S)
										{
											if (223740 - 284681 == -60940)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.D74nImm8k8S);
											if (159920 - 188311 == -28390)
											{
												continue;
											}
										}
									}
									else if (Time.time - Game.mStateTime < (float)3)
									{
										if (136727 - 163153 != -26426)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)2);
										if (138016 - 236126 != -98110)
										{
											continue;
										}
										float a2 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)2);
										if (124254 - 111512 != 12742)
										{
											continue;
										}
										Color color3 = GUI.color;
										if (98341 - 10299 != 88042)
										{
											continue;
										}
										float num4 = color3.a = a2;
										if (250205 - 521515 != -271310)
										{
											continue;
										}
										if (134654 - 427242 != -292588)
										{
											continue;
										}
										GUI.color = color3;
										if (229023 - 337328 == -108304 || 25714 - 376581 == -350866)
										{
											continue;
										}
										if (this.H1EnIjprfEP)
										{
											if (237112 - 200855 == 36258)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.H1EnIjprfEP);
											if (92360 - 101987 != -9627)
											{
												continue;
											}
										}
									}
									else if (Time.time - Game.mStateTime < (float)4)
									{
										if (69492 - 566874 != -497382)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)3);
										if (268774 - 432568 != -163794)
										{
											continue;
										}
										float a3 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)3);
										if (169704 - 377846 != -208142)
										{
											continue;
										}
										Color color4 = GUI.color;
										if (246869 - 467476 == -220606)
										{
											continue;
										}
										color4.a = a3;
										if (104155 - 467046 != -362891)
										{
											continue;
										}
										if (104300 - 20633 != 83667)
										{
											continue;
										}
										GUI.color = color4;
										if (116567 - 149361 != -32794)
										{
											continue;
										}
										if (212945 - 45689 == 167257)
										{
											continue;
										}
										if (this.ciAnIob3GFd)
										{
											if (168332 - 333096 != -164764)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.ciAnIob3GFd);
											if (24435 - 442807 == -418371)
											{
												continue;
											}
										}
									}
								}
								else if (mGameState == eGameState.Normal)
								{
									if (149539 - 436948 != -287409)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)2)
									{
										if (163485 - 110472 == 53014)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
										if (200436 - 115840 != 84596)
										{
											continue;
										}
										float a4 = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
										if (254164 - 143724 == 110441)
										{
											continue;
										}
										Color color5 = GUI.color;
										if (273758 - 97344 == 176415)
										{
											continue;
										}
										float num5 = color5.a = a4;
										if (81325 - 279272 != -197947)
										{
											continue;
										}
										if (250297 - 447238 == -196940)
										{
											continue;
										}
										Color color6 = GUI.color = color5;
										if (276294 - 337064 != -60770)
										{
											continue;
										}
										if (161790 - 181259 != -19469)
										{
											continue;
										}
										if (this.myhnIDbZZ4V)
										{
											if (237783 - 141629 == 96155)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.myhnIDbZZ4V);
											if (10645 - 317890 != -307245)
											{
												continue;
											}
										}
									}
								}
								float a5 = 1f;
								if (225850 - 237045 == -11195)
								{
									Color color7 = GUI.color;
									if (147970 - 267942 == -119972)
									{
										color7.a = a5;
										if (210554 - 544434 != -333879 && 228363 - 44284 != 184080)
										{
											GUI.color = color7;
											if (224809 - 327110 == -102301)
											{
												if (291379 - 572040 == -280661)
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

	// Token: 0x06009EDF RID: 40671 RVA: 0x0124B6F8 File Offset: 0x012498F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (148343 - 231225 != -82881)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (25419 - 515293 == -489874)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (24493 - 318427 == -293934)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (181392 - 437219 == -255827)
					{
						int uid = RuntimeServices.UnboxInt32(data[43]);
						if (262482 - 25807 == 236675)
						{
							int num3 = num;
							if (296964 - 459133 == -162169)
							{
								if (num3 == 9281)
								{
									if (121649 - 517587 == -395938)
									{
										Chat.SubmitChat("none", Game.getPlayerName(uid) + " has joined team" + num2, eChatType.system, eChatMode.system);
										if (29858 - 19184 != 10675)
										{
											break;
										}
									}
								}
								else if (num3 == 9282)
								{
									if (162168 - 167826 != -5657)
									{
										int num4 = num2;
										if (20756 - 324745 != -303988)
										{
											if (num4 == 1)
											{
												if (259541 - 299042 == -39500)
												{
													continue;
												}
												this.jmxnIFrY3yT++;
												if (202090 - 443452 != -241362)
												{
													continue;
												}
											}
											else if (num4 == 2)
											{
												if (83962 - 263303 == -179340)
												{
													continue;
												}
												this.SPKnIAP3eGl++;
												if (10940 - 225335 == -214394)
												{
													continue;
												}
											}
											else if (num4 == 3)
											{
												if (111554 - 540597 != -429043)
												{
													continue;
												}
												this.UDFnI9aAtmB++;
												if (200964 - 282625 != -81661)
												{
													continue;
												}
											}
											else if (num4 == 4)
											{
												if (202702 - 553158 != -350456)
												{
													continue;
												}
												this.dnBnIWj5bf3++;
												if (113688 - 10461 == 103228)
												{
													continue;
												}
											}
											this.SendMessage("newGameMessage", "Team" + num2 + " score!: " + this.jmxnIFrY3yT + "/" + this.SPKnIAP3eGl + "/" + this.UDFnI9aAtmB + "/" + this.dnBnIWj5bf3);
											if (3241 - 297459 == -294218)
											{
												Chat.SubmitChat("none", "Team" + num2 + " score!: " + this.jmxnIFrY3yT + "/" + this.SPKnIAP3eGl + "/" + this.UDFnI9aAtmB + "/" + this.dnBnIWj5bf3, eChatType.system, eChatMode.system);
												if (238363 - 545548 == -307185)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									if (num3 != 9283)
									{
										break;
									}
									if (262801 - 37950 == 224851)
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

	// Token: 0x06009EE0 RID: 40672 RVA: 0x0124BB58 File Offset: 0x01249D58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (126942 - 326460 != -199518)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (53449 - 506434 != -452984)
			{
				Hashtable customOpParameters = new Hashtable();
				if (272171 - 87142 != 185030)
				{
					this.PionI0vPhoE.OpCustom(52, customOpParameters, true);
					if (274135 - 11384 != 262752)
					{
						this.myhnIDbZZ4V = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
						if (269097 - 233108 != 35990)
						{
							this.D74nImm8k8S = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
							if (1724 - 559067 == -557343)
							{
								this.H1EnIjprfEP = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
								if (199566 - 259967 != -60400)
								{
									this.ciAnIob3GFd = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
									if (217438 - 181761 == 35677)
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

	// Token: 0x06009EE1 RID: 40673 RVA: 0x0124BCE4 File Offset: 0x01249EE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (113059 - 8652 != 104407)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (55517 - 374449 != -318931)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (168797 - 154099 != 14699)
				{
					Game.mGameState = eGameState.Setup;
					if (63619 - 575046 == -511427)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009EE2 RID: 40674 RVA: 0x0124BD88 File Offset: 0x01249F88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (125043 - 445470 != -320427)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (45321 - 555880 != -510558)
			{
				if (num == PlayerData.UID)
				{
					if (219618 - 585902 == -366284)
					{
						this.SetupActors();
						if (75162 - 434603 != -359440)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (179191 - 463375 == -284184)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009EE3 RID: 40675 RVA: 0x0124BE58 File Offset: 0x0124A058
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (42158 - 65034 != -22876)
		{
		}
		for (;;)
		{
			IL_1AD:
			Debug.Log("Creating Actors");
			if (288106 - 61182 == 226924)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (5432 - 147741 == -142309)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (191233 - 419688 == -228455)
						{
							int i = 0;
							if (225374 - 72087 == 153287)
							{
								CharacterControl[] array2 = array;
								if (170897 - 522651 != -351753)
								{
									int length = array2.Length;
									if (44697 - 72390 == -27693)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (224927 - 440151 == -215223)
												{
													goto IL_1AD;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (68236 - 9766 != 58470)
												{
													goto IL_1AD;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (75285 - 412298 != -337013)
												{
													goto IL_1AD;
												}
												this.BYvnIuLSTuB++;
												if (50299 - 360806 != -310507)
												{
													goto IL_1AD;
												}
											}
											i++;
											if (209059 - 582786 == -373726)
											{
												goto IL_1AD;
											}
										}
										if (222268 - 82370 == 139898)
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
						if (55148 - 474927 == -419779)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009EE4 RID: 40676 RVA: 0x0124C094 File Offset: 0x0124A294
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (99413 - 405959 != -306546)
		{
		}
		for (;;)
		{
			IL_BE:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (62919 - 472490 != -409570)
			{
				int i = 0;
				if (93821 - 531984 == -438163)
				{
					CharacterControl[] array2 = array;
					if (42819 - 19295 == 23524)
					{
						int length = array2.Length;
						if (245721 - 439523 != -193801)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (230692 - 225527 == 5166)
								{
									goto IL_BE;
								}
								i++;
								if (163551 - 345901 != -182350)
								{
									goto IL_BE;
								}
							}
							if (21999 - 61476 != -39476)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009EE5 RID: 40677 RVA: 0x0124C1C4 File Offset: 0x0124A3C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (50704 - 372717 != -322012)
		{
		}
		while (Game.mGameState < eGameState.Ready)
		{
			if (90718 - 155609 == -64891)
			{
				Debug.Log("Game Ready");
				if (55281 - 108192 == -52911)
				{
					Game.mGameState = eGameState.Ready;
					if (33680 - 188117 != -154436)
					{
						int playerSlot = Game.getPlayerSlot(PlayerData.UID);
						if (172489 - 233792 != -61302)
						{
							GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
							if (239751 - 505590 != -265838)
							{
								GameObject gameObject2 = GameObject.Find("StartCamera" + playerSlot);
								if (289202 - 335835 == -46633)
								{
									if (gameObject)
									{
										if (246511 - 260695 != -14184)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, (playerSlot - 1) % 4 + 1, gameObject.transform.position, gameObject.transform.forward);
										if (57737 - 134830 != -77093)
										{
											continue;
										}
									}
									if (gameObject2)
									{
										if (246493 - 463844 != -217351)
										{
											continue;
										}
										this.transform.position = gameObject2.transform.position;
										if (157232 - 559271 != -402039)
										{
											continue;
										}
										this.transform.rotation = gameObject2.transform.rotation;
										if (139846 - 408704 == -268857)
										{
											continue;
										}
									}
									Game.sendMissionEvent(9281, (playerSlot - 1) % 4 + 1);
									if (252847 - 36878 == 215969)
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

	// Token: 0x06009EE6 RID: 40678 RVA: 0x0124C408 File Offset: 0x0124A608
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M928_JungleHunt.$StartGame$43244(this).GetEnumerator();
	}

	// Token: 0x06009EE7 RID: 40679 RVA: 0x0124C418 File Offset: 0x0124A618
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009EE8 RID: 40680 RVA: 0x0124C41C File Offset: 0x0124A61C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (109056 - 502196 != -393140)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (244200 - 562633 == -318433)
			{
				if (gameObject)
				{
					if (174718 - 203922 != -29203)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (142775 - 193135 == -50360)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (156563 - 188473 != -31909)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009EE9 RID: 40681 RVA: 0x0124C518 File Offset: 0x0124A718
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (28604 - 483302 != -454698)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (233949 - 358040 == -124091)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (27462 - 468023 == -440561)
				{
					hashtable.Add(43, PlayerData.UID);
					if (82680 - 95868 != -13187)
					{
						hashtable.Add(73, nType);
						if (189560 - 319341 != -129780)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (73006 - 336562 == -263556)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (81341 - 56591 != 24751)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (62748 - 140034 != -77285)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (195870 - 483712 != -287841)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (111235 - 512988 != -401752)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (78004 - 154503 != -76498)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (263342 - 77079 == 186263)
													{
														this.PionI0vPhoE.OpCustom(63, hashtable, true);
														if (261422 - 302937 != -41514)
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

	// Token: 0x06009EEA RID: 40682 RVA: 0x0124C7FC File Offset: 0x0124A9FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (104096 - 389710 != -285614)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (5841 - 594001 == -588160)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (197238 - 178423 != 18816)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (167700 - 212352 != -44651)
						{
							if (this.BYvnIuLSTuB <= 0)
							{
								break;
							}
							if (164644 - 503322 != -338677)
							{
								this.BYvnIuLSTuB--;
								if (24553 - 225387 != -200833)
								{
									if (this.BYvnIuLSTuB != 0)
									{
										break;
									}
									if (4782 - 333738 == -328956)
									{
										Game.setGameState(eGameState.Ready);
										if (258392 - 299780 == -41388)
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
						if (221895 - 351259 == -129364)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (164046 - 583900 == -419854)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009EEB RID: 40683 RVA: 0x0124C98C File Offset: 0x0124AB8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009EEC RID: 40684 RVA: 0x0124C9A0 File Offset: 0x0124ABA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009EED RID: 40685 RVA: 0x0124C9B4 File Offset: 0x0124ABB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (172315 - 362179 != -189863)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (166445 - 175877 != -9431)
			{
				hashtable.Add(71, CID);
				if (228794 - 23014 == 205780)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (180636 - 449414 != -268777)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (249288 - 251490 != -2201)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (23553 - 33960 == -10407)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (95694 - 333904 != -238209)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (217455 - 410453 != -192997)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (80827 - 305455 == -224628)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (77591 - 487424 != -409832)
											{
												this.PionI0vPhoE.OpCustom(61, hashtable, true);
												if (24251 - 541987 == -517736)
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

	// Token: 0x06009EEE RID: 40686 RVA: 0x0124CC40 File Offset: 0x0124AE40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (152056 - 43336 != 108720)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (210292 - 138112 == 72180)
			{
				if (!gameObject)
				{
					break;
				}
				if (122979 - 156134 == -33155)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (38183 - 456396 != -418212)
					{
						if (characterControl)
						{
							if (133163 - 582064 == -448900)
							{
								continue;
							}
							characterControl.StartCoroutine_Auto(characterControl.addStatus("noDamage", 1, 12, 0, characterControl.ActorNr));
							if (68074 - 162558 != -94484)
							{
								continue;
							}
						}
						PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
						if (205233 - 104644 != 100590)
						{
							playerCameraControl.target = gameObject;
							if (7290 - 392714 == -385424)
							{
								this.createTeamRing(gameObject);
								if (94041 - 343429 == -249388)
								{
									gameObject.SendMessage("createSpecialEffect", 1);
									if (136979 - 513863 != -376883)
									{
										if (Game.mGameState < eGameState.Start)
										{
											if (299587 - 354934 != -55346)
											{
												this.StartCoroutine_Auto(this.StartGame());
												if (92365 - 372964 == -280599)
												{
													break;
												}
											}
										}
										else
										{
											this.onRevivePlayer();
											if (252189 - 47692 == 204497)
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

	// Token: 0x06009EEF RID: 40687 RVA: 0x0124CE58 File Offset: 0x0124B058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (299002 - 390335 != -91333)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPeer(data);
			if (248482 - 64279 != 184204)
			{
				if (!gameObject)
				{
					break;
				}
				if (42669 - 446879 == -404210)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (153875 - 557517 == -403642)
					{
						if (characterControl)
						{
							if (213374 - 151677 == 61698)
							{
								continue;
							}
							characterControl.StartCoroutine_Auto(characterControl.addStatus("noDamage", 1, 12, 0, characterControl.ActorNr));
							if (169669 - 312903 == -143233)
							{
								continue;
							}
						}
						GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
						if (121427 - 414696 != -293268)
						{
							gameGui.ResetTeamBar();
							if (111433 - 476007 != -364573)
							{
								this.createTeamRing(gameObject);
								if (298625 - 53197 != 245429)
								{
									gameObject.SendMessage("createSpecialEffect", 1);
									if (147549 - 67556 != 79994)
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

	// Token: 0x06009EF0 RID: 40688 RVA: 0x0124D000 File Offset: 0x0124B200
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M928_JungleHunt.$onDeadPlayer$43248(this).GetEnumerator();
	}

	// Token: 0x06009EF1 RID: 40689 RVA: 0x0124D010 File Offset: 0x0124B210
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (46091 - 462667 != -416575)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (68815 - 438219 == -369404)
			{
				this.Y7xnI8fiyC0.target = Game.mPlayer;
				if (233260 - 137497 != 95764)
				{
					this.Y7xnI8fiyC0.enabled = true;
					if (43604 - 302111 != -258506)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (165516 - 7705 != 157811)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (98632 - 125651 != -27019)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (133989 - 269282 != -135292)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (281707 - 130569 == 151138)
							{
								if (!gameGui)
								{
									break;
								}
								if (6840 - 500125 != -493284)
								{
									gameGui.enabled = true;
									if (192277 - 41338 != 150940)
									{
										gameGui.closeDeadMenu();
										if (170005 - 395784 == -225779)
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

	// Token: 0x06009EF2 RID: 40690 RVA: 0x0124D1BC File Offset: 0x0124B3BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (108922 - 324027 != -215105)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (110456 - 354875 != -244418)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (45875 - 272601 != -226725)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (208993 - 433568 == -224575)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009EF3 RID: 40691 RVA: 0x0124D280 File Offset: 0x0124B480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009EF4 RID: 40692 RVA: 0x0124D2AC File Offset: 0x0124B4AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M928_JungleHunt.$onChangePlayer$43257(data, this).GetEnumerator();
	}

	// Token: 0x06009EF5 RID: 40693 RVA: 0x0124D2BC File Offset: 0x0124B4BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RespawnPlayer(int nCID)
	{
		return new M928_JungleHunt.$RespawnPlayer$43264(nCID, this).GetEnumerator();
	}

	// Token: 0x06009EF6 RID: 40694 RVA: 0x0124D2CC File Offset: 0x0124B4CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSummon(GameObject nSummon)
	{
		this.createTeamRing(nSummon);
	}

	// Token: 0x06009EF7 RID: 40695 RVA: 0x0124D2D8 File Offset: 0x0124B4D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createTeamRing(GameObject nObject)
	{
		if (170453 - 586933 != -416479)
		{
		}
		for (;;)
		{
			GameObject gameObject = null;
			if (282419 - 452194 != -169774)
			{
				int layer = nObject.layer;
				if (298719 - 575901 != -277181)
				{
					if (layer == 8)
					{
						if (52716 - 338069 == -285352)
						{
							continue;
						}
						if (this.ring_team1)
						{
							if (281609 - 143693 != 137916)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team1, nObject.transform.position, Quaternion.identity);
							if (207676 - 120707 == 86970)
							{
								continue;
							}
						}
					}
					else if (layer == 9)
					{
						if (128945 - 230293 == -101347)
						{
							continue;
						}
						if (this.ring_team2)
						{
							if (157175 - 405975 == -248799)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team2, nObject.transform.position, Quaternion.identity);
							if (292859 - 311035 != -18176)
							{
								continue;
							}
						}
					}
					else if (layer == 10)
					{
						if (112819 - 509081 != -396262)
						{
							continue;
						}
						if (this.ring_team3)
						{
							if (259234 - 341939 != -82705)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team3, nObject.transform.position, Quaternion.identity);
							if (76152 - 94732 != -18580)
							{
								continue;
							}
						}
					}
					else if (layer == 11)
					{
						if (224799 - 78983 != 145816)
						{
							continue;
						}
						if (this.ring_team4)
						{
							if (220649 - 376299 == -155649)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team4, nObject.transform.position, Quaternion.identity);
							if (43735 - 498797 == -455061)
							{
								continue;
							}
						}
					}
					if (!gameObject)
					{
						break;
					}
					if (254356 - 253836 != 521)
					{
						gameObject.transform.parent = nObject.transform;
						if (158714 - 129114 != 29601)
						{
							gameObject.transform.localPosition = Vector3.zero;
							if (101888 - 406983 != -305094)
							{
								if (!nObject.collider)
								{
									break;
								}
								if (86487 - 338054 != -251566)
								{
									gameObject.transform.localScale = Vector3.one * nObject.collider.bounds.size.z;
									if (185234 - 441785 != -256550)
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

	// Token: 0x06009EF8 RID: 40696 RVA: 0x0124D66C File Offset: 0x0124B86C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M928_JungleHunt.$onGameComplete$43278(data, this).GetEnumerator();
	}

	// Token: 0x06009EF9 RID: 40697 RVA: 0x0124D67C File Offset: 0x0124B87C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M928_JungleHunt.$ReturnToTown$43288(this).GetEnumerator();
	}

	// Token: 0x06009EFA RID: 40698 RVA: 0x0124D68C File Offset: 0x0124B88C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M928_JungleHunt.$ReturnToGuild$43293(this).GetEnumerator();
	}

	// Token: 0x06009EFB RID: 40699 RVA: 0x0124D69C File Offset: 0x0124B89C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M928_JungleHunt.$ReturnToCamp$43297(this).GetEnumerator();
	}

	// Token: 0x06009EFC RID: 40700 RVA: 0x0124D6AC File Offset: 0x0124B8AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (124057 - 498369 != -374311)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (177827 - 61435 != 116393)
			{
				Hashtable hashtable = new Hashtable();
				if (247080 - 441791 == -194711)
				{
					hashtable.Add(43, PlayerData.UID);
					if (297273 - 348682 != -51408)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (52767 - 418076 == -365309)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009EFD RID: 40701 RVA: 0x0124D784 File Offset: 0x0124B984
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009EFE RID: 40702 RVA: 0x0124D798 File Offset: 0x0124B998
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (197837 - 346048 != -148211)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (68107 - 3759 == 64348)
			{
				Hashtable hashtable = new Hashtable();
				if (69672 - 570982 == -501310)
				{
					if (Game.mNextGameCode == 30)
					{
						if (79440 - 508254 == -428813)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (211628 - 435597 != -223969)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (86290 - 173990 != -87700)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (73425 - 232788 == -159362)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (16082 - 32524 != -16442)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (30411 - 518113 != -487702)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (129376 - 551532 != -422156)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (6600 - 222982 == -216381)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (112348 - 200197 == -87848)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (217646 - 42118 == 175529)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (36410 - 249339 == -212928)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (68605 - 400025 != -331420)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (275005 - 318162 != -43157)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (208615 - 15387 == 193229)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (24265 - 309220 == -284954)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (4235 - 416360 == -412124)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (116223 - 322638 == -206414)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (235699 - 466454 == -230754)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (129829 - 412035 == -282205)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (54203 - 29236 == 24968)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (45378 - 35567 != 9811)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (90530 - 382409 != -291879)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (60825 - 288300 != -227475)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (75330 - 185563 != -110233)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (156091 - 313126 == -157034)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (73278 - 103548 != -30270)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (211380 - 477359 == -265978)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (220723 - 31542 != 189181)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (216199 - 473719 == -257520)
					{
						this.PionI0vPhoE.OpCustom(42, hashtable, true);
						if (93128 - 65864 != 27265)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009EFF RID: 40703 RVA: 0x0124DD4C File Offset: 0x0124BF4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009F00 RID: 40704 RVA: 0x0124DD5C File Offset: 0x0124BF5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009F01 RID: 40705 RVA: 0x0124DD60 File Offset: 0x0124BF60
	internal static bool B1mM0BVgRmkm7BIoaPTw()
	{
		return true;
	}

	// Token: 0x06009F02 RID: 40706 RVA: 0x0124DD64 File Offset: 0x0124BF64
	internal static bool XBdKfAVgwkpyPuiUEWDE()
	{
		return false;
	}

	// Token: 0x040090C6 RID: 37062
	private LitePeer PionI0vPhoE;

	// Token: 0x040090C7 RID: 37063
	private PlayerCameraControl Y7xnI8fiyC0;

	// Token: 0x040090C8 RID: 37064
	private float CBDnIituMRp;

	// Token: 0x040090C9 RID: 37065
	private Texture myhnIDbZZ4V;

	// Token: 0x040090CA RID: 37066
	private Texture D74nImm8k8S;

	// Token: 0x040090CB RID: 37067
	private Texture H1EnIjprfEP;

	// Token: 0x040090CC RID: 37068
	private Texture ciAnIob3GFd;

	// Token: 0x040090CD RID: 37069
	private int H5lnIk6879L;

	// Token: 0x040090CE RID: 37070
	private int jmxnIFrY3yT;

	// Token: 0x040090CF RID: 37071
	private int SPKnIAP3eGl;

	// Token: 0x040090D0 RID: 37072
	private int UDFnI9aAtmB;

	// Token: 0x040090D1 RID: 37073
	private int dnBnIWj5bf3;

	// Token: 0x040090D2 RID: 37074
	private int BYvnIuLSTuB;

	// Token: 0x040090D3 RID: 37075
	public GameObject ring_team1;

	// Token: 0x040090D4 RID: 37076
	public GameObject ring_team2;

	// Token: 0x040090D5 RID: 37077
	public GameObject ring_team3;

	// Token: 0x040090D6 RID: 37078
	public GameObject ring_team4;

	// Token: 0x02001A9C RID: 6812
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$43244 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009F03 RID: 40707 RVA: 0x0124DD68 File Offset: 0x0124BF68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$43244(M928_JungleHunt self_)
		{
			if (248938 - 357713 != -108775)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (143459 - 461709 != -318249)
				{
					base..ctor();
					if (280268 - 483114 == -202846)
					{
						this.$self_$43247 = self_;
						if (158534 - 87404 == 71130)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009F04 RID: 40708 RVA: 0x0124DE00 File Offset: 0x0124C000
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M928_JungleHunt.$StartGame$43244.$(this.$self_$43247);
		}

		// Token: 0x06009F05 RID: 40709 RVA: 0x0124DE10 File Offset: 0x0124C010
		internal static bool U3ujf7VgqqPY345YfTVX()
		{
			return true;
		}

		// Token: 0x06009F06 RID: 40710 RVA: 0x0124DE14 File Offset: 0x0124C014
		internal static bool MNb6OUVg730dy8FcZWdW()
		{
			return false;
		}

		// Token: 0x040090D7 RID: 37079
		internal M928_JungleHunt $self_$43247;

		// Token: 0x02001A9D RID: 6813
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009F07 RID: 40711 RVA: 0x0124DE18 File Offset: 0x0124C018
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M928_JungleHunt self_)
			{
				if (256613 - 405384 != -148771)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (5753 - 42145 == -36392)
					{
						base..ctor();
						if (98779 - 54197 != 44583)
						{
							this.$self_$43246 = self_;
							if (216406 - 432579 == -216173)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009F08 RID: 40712 RVA: 0x0124DEB0 File Offset: 0x0124C0B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (289088 - 157350 != 131739)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1C0;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (87701 - 347974 == -260272)
						{
							continue;
						}
						Game.mGameTime = Time.time + (float)900;
						if (269543 - 58295 != 211248)
						{
							continue;
						}
						this.YieldDefault(1);
						if (77277 - 419372 != -342094)
						{
							goto Block_3;
						}
						continue;
					default:
						if (250719 - 375880 == -125160)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (118057 - 88345 == 29712)
					{
						Game.mGameState = eGameState.Start;
						if (71622 - 430293 == -358671)
						{
							Game.mGameTime = Time.time;
							if (53748 - 529153 != -475404)
							{
								this.$mGameGui$43245 = (GameGui)this.$self_$43246.GetComponent(typeof(GameGui));
								if (264268 - 90185 == 174083)
								{
									this.$mGameGui$43245.enabled = true;
									if (45037 - 497612 == -452575)
									{
										this.$self_$43246.SendMessage("fadeIn");
										if (143355 - 98166 != 45190)
										{
											goto Block_8;
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_1C0;
				Block_8:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1C0:
				return false;
			}

			// Token: 0x06009F09 RID: 40713 RVA: 0x0124E090 File Offset: 0x0124C290
			internal static bool L8T8bJVgPeOrLqRfG5hP()
			{
				return true;
			}

			// Token: 0x06009F0A RID: 40714 RVA: 0x0124E094 File Offset: 0x0124C294
			internal static bool sPY8hqVg0lWoACCGVg3n()
			{
				return false;
			}

			// Token: 0x040090D8 RID: 37080
			internal GameGui $mGameGui$43245;

			// Token: 0x040090D9 RID: 37081
			internal M928_JungleHunt $self_$43246;
		}
	}

	// Token: 0x02001A9E RID: 6814
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43248 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009F0B RID: 40715 RVA: 0x0124E098 File Offset: 0x0124C298
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43248(M928_JungleHunt self_)
		{
			if (142381 - 501304 != -358922)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193176 - 80572 == 112604)
				{
					base..ctor();
					if (296841 - 358589 == -61748)
					{
						this.$self_$43256 = self_;
						if (241278 - 221048 == 20230)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009F0C RID: 40716 RVA: 0x0124E130 File Offset: 0x0124C330
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M928_JungleHunt.$onDeadPlayer$43248.$(this.$self_$43256);
		}

		// Token: 0x06009F0D RID: 40717 RVA: 0x0124E140 File Offset: 0x0124C340
		internal static bool MOjLxNVgbsVjItSIjyNG()
		{
			return true;
		}

		// Token: 0x06009F0E RID: 40718 RVA: 0x0124E144 File Offset: 0x0124C344
		internal static bool uY1ExbVguSrCZP2fySJ2()
		{
			return false;
		}

		// Token: 0x040090DA RID: 37082
		internal M928_JungleHunt $self_$43256;

		// Token: 0x02001A9F RID: 6815
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009F0F RID: 40719 RVA: 0x0124E148 File Offset: 0x0124C348
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M928_JungleHunt self_)
			{
				if (97401 - 457496 != -360094)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (204227 - 44256 != 159972)
					{
						base..ctor();
						if (289146 - 245611 != 43536)
						{
							this.$self_$43255 = self_;
							if (257520 - 460793 != -203272)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009F10 RID: 40720 RVA: 0x0124E1E0 File Offset: 0x0124C3E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (270437 - 477900 != -207463)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4C7;
					case 2:
						if (Game.mGameState != eGameState.Normal)
						{
							if (148095 - 362045 != -213950)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_2AF;
							}
							if (79810 - 461459 != -381649)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (238054 - 207075 != 30979)
						{
							continue;
						}
						this.$mStoryGui$43252 = (StoryGui)this.$self_$43255.GetComponent(typeof(StoryGui));
						if (271927 - 145446 != 126481)
						{
							continue;
						}
						if (this.$mStoryGui$43252)
						{
							if (203290 - 57569 != 145721)
							{
								continue;
							}
							this.$mStoryGui$43252.close();
							if (168456 - 546873 == -378416)
							{
								continue;
							}
						}
						this.$mChangeGui$43253 = (ChangeGui)this.$self_$43255.GetComponent(typeof(ChangeGui));
						if (10055 - 283136 == -273080)
						{
							continue;
						}
						if (this.$mChangeGui$43253)
						{
							if (178072 - 136832 == 41241)
							{
								continue;
							}
							this.$mChangeGui$43253.close();
							if (222430 - 334535 == -112104)
							{
								continue;
							}
						}
						this.$mGameGui$43254 = (GameGui)this.$self_$43255.GetComponent(typeof(GameGui));
						if (259631 - 50873 != 208758)
						{
							continue;
						}
						if (this.$mGameGui$43254)
						{
							if (191489 - 50423 == 141067)
							{
								continue;
							}
							if (!this.$mGameGui$43254.enabled)
							{
								if (49010 - 414026 != -365016)
								{
									continue;
								}
								this.$mGameGui$43254.enabled = true;
								if (159495 - 121304 != 38191)
								{
									continue;
								}
							}
							this.$mGameGui$43254.openDeadMenu();
							if (58265 - 248728 != -190463)
							{
								continue;
							}
						}
						IL_2AF:
						this.YieldDefault(1);
						if (144313 - 323402 != -179088)
						{
							goto Block_23;
						}
						continue;
					default:
						if (758 - 470886 != -470128)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (84614 - 238933 != -154318)
					{
						if (!Game.mPlayer)
						{
							break;
						}
						if (91828 - 386581 == -294753)
						{
							this.$mPlayerChar$43249 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (82485 - 546096 != -463610)
							{
								if (!this.$mPlayerChar$43249)
								{
									break;
								}
								if (139468 - 95986 == 43482)
								{
									if (this.$mPlayerChar$43249.mLastDamageID == 0)
									{
										break;
									}
									if (103764 - 122812 == -19048)
									{
										object obj2;
										object obj = obj2 = PhotonClient.ActorNrList[this.$mPlayerChar$43249.mLastDamageID];
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										this.$mKiller$43250 = (GameObject)obj2;
										if (86758 - 183164 == -96406)
										{
											if (!this.$mKiller$43250)
											{
												break;
											}
											if (263903 - 559598 != -295694)
											{
												this.$mKillerChar$43251 = (CharacterControl)this.$mKiller$43250.GetComponent(typeof(CharacterControl));
												if (122894 - 68417 == 54477)
												{
													if (!this.$mKillerChar$43251)
													{
														break;
													}
													if (188195 - 144641 == 43554)
													{
														Game.sendMissionEvent(9282, this.$mKillerChar$43251.mOriginalLayer - 7);
														if (15661 - 44578 == -28917)
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
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_23:
				IL_4C7:
				return false;
			}

			// Token: 0x06009F11 RID: 40721 RVA: 0x0124E6C8 File Offset: 0x0124C8C8
			internal static bool DScnuRVgIsJsy4GcbyJc()
			{
				return true;
			}

			// Token: 0x06009F12 RID: 40722 RVA: 0x0124E6CC File Offset: 0x0124C8CC
			internal static bool t9iBvuVgBFaoWRM9LAhx()
			{
				return false;
			}

			// Token: 0x040090DB RID: 37083
			internal CharacterControl $mPlayerChar$43249;

			// Token: 0x040090DC RID: 37084
			internal GameObject $mKiller$43250;

			// Token: 0x040090DD RID: 37085
			internal CharacterControl $mKillerChar$43251;

			// Token: 0x040090DE RID: 37086
			internal StoryGui $mStoryGui$43252;

			// Token: 0x040090DF RID: 37087
			internal ChangeGui $mChangeGui$43253;

			// Token: 0x040090E0 RID: 37088
			internal GameGui $mGameGui$43254;

			// Token: 0x040090E1 RID: 37089
			internal M928_JungleHunt $self_$43255;
		}
	}

	// Token: 0x02001AA0 RID: 6816
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43257 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009F13 RID: 40723 RVA: 0x0124E6D0 File Offset: 0x0124C8D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43257(Hashtable data, M928_JungleHunt self_)
		{
			if (238620 - 83676 != 154945)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (4395 - 122371 != -117975)
				{
					base..ctor();
					if (183857 - 374302 == -190445)
					{
						this.$data$43262 = data;
						if (23256 - 406704 != -383447)
						{
							this.$self_$43263 = self_;
							if (165951 - 216605 == -50654)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009F14 RID: 40724 RVA: 0x0124E78C File Offset: 0x0124C98C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M928_JungleHunt.$onChangePlayer$43257.$(this.$data$43262, this.$self_$43263);
		}

		// Token: 0x06009F15 RID: 40725 RVA: 0x0124E7A0 File Offset: 0x0124C9A0
		internal static bool XHhF63VgeurCspFv2lEg()
		{
			return true;
		}

		// Token: 0x06009F16 RID: 40726 RVA: 0x0124E7A4 File Offset: 0x0124C9A4
		internal static bool y9XSd5VgrAsaUnkAal1R()
		{
			return false;
		}

		// Token: 0x040090E2 RID: 37090
		internal Hashtable $data$43262;

		// Token: 0x040090E3 RID: 37091
		internal M928_JungleHunt $self_$43263;

		// Token: 0x02001AA1 RID: 6817
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009F17 RID: 40727 RVA: 0x0124E7A8 File Offset: 0x0124C9A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M928_JungleHunt self_)
			{
				if (138638 - 370210 != -231571)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (266956 - 588689 == -321733)
					{
						base..ctor();
						if (39655 - 410112 == -370457)
						{
							this.$data$43260 = data;
							if (199428 - 143742 != 55687)
							{
								this.$self_$43261 = self_;
								if (241005 - 23358 != 217648)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009F18 RID: 40728 RVA: 0x0124E864 File Offset: 0x0124CA64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (212827 - 373412 != -160585)
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
							if (295264 - 500594 == -205329)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (196910 - 583245 == -386334)
							{
								continue;
							}
							this.$mGameGui$43259 = (GameGui)this.$self_$43261.GetComponent(typeof(GameGui));
							if (42763 - 418513 != -375750)
							{
								continue;
							}
							this.$mGameGui$43259.enabled = true;
							if (22572 - 510915 != -488343)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (85155 - 159084 != -73929)
						{
							continue;
						}
						goto IL_205;
					default:
						if (277215 - 446406 != -169191)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (180111 - 215 == 179896)
					{
						this.$self_$43261.SendMessage("onCreatePlayer", this.$data$43260);
						if (298427 - 546032 != -247604)
						{
							this.$mChangeGui$43258 = (ChangeGui)this.$self_$43261.GetComponent(typeof(ChangeGui));
							if (211072 - 22533 != 188540)
							{
								if (!this.$mChangeGui$43258.enabled)
								{
									break;
								}
								if (163488 - 495460 != -331971)
								{
									this.$mChangeGui$43258.close();
									if (22300 - 328462 != -306161)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_54:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_54;
				IL_205:
				return false;
			}

			// Token: 0x06009F19 RID: 40729 RVA: 0x0124EA88 File Offset: 0x0124CC88
			internal static bool LCJmvUVgjvfBGSkJwpUC()
			{
				return true;
			}

			// Token: 0x06009F1A RID: 40730 RVA: 0x0124EA8C File Offset: 0x0124CC8C
			internal static bool mQ2pPwVghJeYh9KNb2vD()
			{
				return false;
			}

			// Token: 0x040090E4 RID: 37092
			internal ChangeGui $mChangeGui$43258;

			// Token: 0x040090E5 RID: 37093
			internal GameGui $mGameGui$43259;

			// Token: 0x040090E6 RID: 37094
			internal Hashtable $data$43260;

			// Token: 0x040090E7 RID: 37095
			internal M928_JungleHunt $self_$43261;
		}
	}

	// Token: 0x02001AA2 RID: 6818
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RespawnPlayer$43264 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009F1B RID: 40731 RVA: 0x0124EA90 File Offset: 0x0124CC90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RespawnPlayer$43264(int nCID, M928_JungleHunt self_)
		{
			if (97043 - 504710 != -407667)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (226533 - 560201 != -333667)
				{
					base..ctor();
					if (134271 - 474078 == -339807)
					{
						this.$nCID$43276 = nCID;
						if (190681 - 185960 != 4722)
						{
							this.$self_$43277 = self_;
							if (236564 - 492304 == -255740)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009F1C RID: 40732 RVA: 0x0124EB4C File Offset: 0x0124CD4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M928_JungleHunt.$RespawnPlayer$43264.$(this.$nCID$43276, this.$self_$43277);
		}

		// Token: 0x06009F1D RID: 40733 RVA: 0x0124EB60 File Offset: 0x0124CD60
		internal static bool U1LasoVgswgJOrS6E8V5()
		{
			return true;
		}

		// Token: 0x06009F1E RID: 40734 RVA: 0x0124EB64 File Offset: 0x0124CD64
		internal static bool tqho24Vg9DK0Qk9tCfBR()
		{
			return false;
		}

		// Token: 0x040090E8 RID: 37096
		internal int $nCID$43276;

		// Token: 0x040090E9 RID: 37097
		internal M928_JungleHunt $self_$43277;

		// Token: 0x02001AA3 RID: 6819
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009F1F RID: 40735 RVA: 0x0124EB68 File Offset: 0x0124CD68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nCID, M928_JungleHunt self_)
			{
				if (240971 - 70218 != 170753)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (90954 - 322939 == -231985)
					{
						base..ctor();
						if (191602 - 13383 != 178220)
						{
							this.$nCID$43274 = nCID;
							if (206579 - 40224 == 166355)
							{
								this.$self_$43275 = self_;
								if (147426 - 329007 == -181581)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009F20 RID: 40736 RVA: 0x0124EC24 File Offset: 0x0124CE24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284415 - 157079 != 127337)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_697;
					case 2:
						this.$mPlayerCameraControl$43266 = (PlayerCameraControl)this.$self_$43275.GetComponent(typeof(PlayerCameraControl));
						if (18402 - 317424 == -299021)
						{
							continue;
						}
						this.$mPlayerCameraControl$43266.target = null;
						if (117840 - 474120 == -356279)
						{
							continue;
						}
						this.$slot$43267 = Game.getPlayerSlot(PlayerData.UID);
						if (11268 - 57159 == -45890)
						{
							continue;
						}
						this.$startPoint$43268 = GameObject.Find("StartPoint" + this.$slot$43267);
						if (226981 - 86747 != 140234)
						{
							continue;
						}
						this.$startCamera$43269 = GameObject.Find("StartCamera" + this.$slot$43267);
						if (33595 - 214184 == -180588)
						{
							continue;
						}
						if (this.$startCamera$43269)
						{
							if (165459 - 471366 == -305906)
							{
								continue;
							}
							this.$self_$43275.transform.position = this.$startCamera$43269.transform.position;
							if (15402 - 22577 != -7175)
							{
								continue;
							}
							this.$self_$43275.transform.rotation = this.$startCamera$43269.transform.rotation;
							if (200952 - 300354 == -99401)
							{
								continue;
							}
						}
						this.$self_$43275.SendMessage("fadeIn");
						if (221557 - 458821 != -237264)
						{
							continue;
						}
						if (this.$startPoint$43268)
						{
							if (218186 - 285392 == -67205)
							{
								continue;
							}
							this.$nTeam$43270 = (this.$slot$43267 - 1) % 4 + 1;
							if (2989 - 460338 != -457349)
							{
								continue;
							}
							this.$nPos$43271 = this.$startPoint$43268.transform.position;
							if (255667 - 415917 != -160250)
							{
								continue;
							}
							this.$nDir$43272 = this.$startPoint$43268.transform.forward;
							if (270869 - 228734 == 42136)
							{
								continue;
							}
							this.$data$43273 = new Hashtable();
							if (222348 - 282421 == -60072)
							{
								continue;
							}
							this.$data$43273.Add(43, PlayerData.UID);
							if (241032 - 354323 != -113291)
							{
								continue;
							}
							this.$data$43273.Add(71, this.$nCID$43274);
							if (208852 - 29990 == 178863)
							{
								continue;
							}
							this.$data$43273.Add(75, PhotonClient.cInt16(this.$nTeam$43270));
							if (28852 - 262085 != -233233)
							{
								continue;
							}
							this.$data$43273.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$43271.x * (float)50)));
							if (146110 - 345554 == -199443)
							{
								continue;
							}
							this.$data$43273.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$43271.y * (float)50)));
							if (169043 - 365762 == -196718)
							{
								continue;
							}
							this.$data$43273.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$43271.z * (float)50)));
							if (195243 - 126705 == 68539)
							{
								continue;
							}
							this.$data$43273.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$43272.x * (float)200)));
							if (147109 - 17976 != 129133)
							{
								continue;
							}
							this.$data$43273.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$43272.y * (float)200)));
							if (267418 - 519373 == -251954)
							{
								continue;
							}
							this.$data$43273.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$43272.z * (float)200)));
							if (284491 - 310057 != -25566)
							{
								continue;
							}
							PhotonClient.Connection.OpCustom(65, this.$data$43273, true);
							if (39711 - 567559 != -527848)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (177560 - 410382 != -232821)
						{
							goto Block_3;
						}
						continue;
					default:
						if (156961 - 551236 == -394274)
						{
							continue;
						}
						break;
					}
					Debug.Log("Respawn Player");
					if (10415 - 22014 == -11599)
					{
						this.$self_$43275.SendMessage("fadeOut");
						if (201405 - 432949 != -231543)
						{
							this.$mGameGui$43265 = (GameGui)this.$self_$43275.GetComponent(typeof(GameGui));
							if (296669 - 437085 == -140416)
							{
								if (!this.$mGameGui$43265)
								{
									goto IL_1F3;
								}
								if (108747 - 530974 == -422227)
								{
									this.$mGameGui$43265.close();
									if (265637 - 515939 == -250302)
									{
										goto IL_1F3;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_697;
				IL_1F3:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_697:
				return false;
			}

			// Token: 0x06009F21 RID: 40737 RVA: 0x0124F2DC File Offset: 0x0124D4DC
			internal static bool ejeTbgVg1XaqJj8W2LWi()
			{
				return true;
			}

			// Token: 0x06009F22 RID: 40738 RVA: 0x0124F2E0 File Offset: 0x0124D4E0
			internal static bool Qo9HrsVg4GvHij3HNwGw()
			{
				return false;
			}

			// Token: 0x040090EA RID: 37098
			internal GameGui $mGameGui$43265;

			// Token: 0x040090EB RID: 37099
			internal PlayerCameraControl $mPlayerCameraControl$43266;

			// Token: 0x040090EC RID: 37100
			internal int $slot$43267;

			// Token: 0x040090ED RID: 37101
			internal GameObject $startPoint$43268;

			// Token: 0x040090EE RID: 37102
			internal GameObject $startCamera$43269;

			// Token: 0x040090EF RID: 37103
			internal int $nTeam$43270;

			// Token: 0x040090F0 RID: 37104
			internal Vector3 $nPos$43271;

			// Token: 0x040090F1 RID: 37105
			internal Vector3 $nDir$43272;

			// Token: 0x040090F2 RID: 37106
			internal Hashtable $data$43273;

			// Token: 0x040090F3 RID: 37107
			internal int $nCID$43274;

			// Token: 0x040090F4 RID: 37108
			internal M928_JungleHunt $self_$43275;
		}
	}

	// Token: 0x02001AA4 RID: 6820
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43278 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009F23 RID: 40739 RVA: 0x0124F2E4 File Offset: 0x0124D4E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43278(Hashtable data, M928_JungleHunt self_)
		{
			if (151916 - 145005 != 6912)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (14951 - 360458 == -345507)
				{
					base..ctor();
					if (124411 - 276634 != -152222)
					{
						this.$data$43286 = data;
						if (231089 - 597405 == -366316)
						{
							this.$self_$43287 = self_;
							if (6424 - 191551 == -185127)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009F24 RID: 40740 RVA: 0x0124F3A0 File Offset: 0x0124D5A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M928_JungleHunt.$onGameComplete$43278.$(this.$data$43286, this.$self_$43287);
		}

		// Token: 0x06009F25 RID: 40741 RVA: 0x0124F3B4 File Offset: 0x0124D5B4
		internal static bool t7UKUHVgzBBY6BGZbdf5()
		{
			return true;
		}

		// Token: 0x06009F26 RID: 40742 RVA: 0x0124F3B8 File Offset: 0x0124D5B8
		internal static bool KQ3XrMVfaBcSBfwAAvgr()
		{
			return false;
		}

		// Token: 0x040090F5 RID: 37109
		internal Hashtable $data$43286;

		// Token: 0x040090F6 RID: 37110
		internal M928_JungleHunt $self_$43287;

		// Token: 0x02001AA5 RID: 6821
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009F27 RID: 40743 RVA: 0x0124F3BC File Offset: 0x0124D5BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M928_JungleHunt self_)
			{
				if (89312 - 314502 != -225190)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (51058 - 495025 == -443967)
					{
						base..ctor();
						if (56993 - 348352 == -291359)
						{
							this.$data$43284 = data;
							if (293485 - 506351 == -212866)
							{
								this.$self_$43285 = self_;
								if (80633 - 134671 != -54037)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009F28 RID: 40744 RVA: 0x0124F478 File Offset: 0x0124D678
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224243 - 18039 != 206205)
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
						this.$mCompleteGui$43280 = (CompleteGui)this.$self_$43285.GetComponent(typeof(CompleteGui));
						if (103811 - 411693 != -307882)
						{
							continue;
						}
						this.$mCompleteGui$43280.Init();
						if (65765 - 491953 == -426187)
						{
							continue;
						}
						this.$mCompleteGui$43280.readData(this.$data$43284);
						if (366 - 484800 == -484433)
						{
							continue;
						}
						if (this.$result$43279 == 1)
						{
							if (258569 - 217050 == 41520)
							{
								continue;
							}
							this.$mCompleteGui$43280.displayResult(eCompleteType.Success);
							if (164223 - 290272 == -126048)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43280.displayResult(eCompleteType.Failed);
							if (274089 - 292917 != -18828)
							{
								continue;
							}
						}
						this.$mGameGui$43281 = (GameGui)this.$self_$43285.GetComponent(typeof(GameGui));
						if (123725 - 373480 != -249755)
						{
							continue;
						}
						this.$mStoryGui$43282 = (StoryGui)this.$self_$43285.GetComponent(typeof(StoryGui));
						if (130973 - 386830 == -255856)
						{
							continue;
						}
						this.$mChangeGui$43283 = (ChangeGui)this.$self_$43285.GetComponent(typeof(ChangeGui));
						if (7733 - 268948 != -261215)
						{
							continue;
						}
						if (this.$mGameGui$43281)
						{
							if (260481 - 45140 != 215341)
							{
								continue;
							}
							this.$mGameGui$43281.close();
							if (17688 - 547643 == -529954)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43282)
						{
							if (172245 - 219246 != -47001)
							{
								continue;
							}
							this.$mStoryGui$43282.close();
							if (171210 - 518386 != -347176)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43283)
						{
							if (127466 - 120185 != 7281)
							{
								continue;
							}
							this.$mChangeGui$43283.disable();
							if (123772 - 97410 != 26362)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (22932 - 319166 != -296233)
						{
							goto Block_13;
						}
						continue;
					default:
						if (205672 - 462188 == -256515)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43284[31]);
					if (89460 - 553964 != -464503)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (16458 - 590386 == -573928)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (245809 - 312703 == -66894)
							{
								this.$result$43279 = RuntimeServices.UnboxInt32(this.$data$43284[31]);
								if (225324 - 74586 != 150739)
								{
									goto Block_15;
								}
							}
						}
					}
				}
				Block_13:
				goto IL_3DB;
				Block_15:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06009F29 RID: 40745 RVA: 0x0124F874 File Offset: 0x0124DA74
			internal static bool WZeuIPVf5Bhmmnmm0s0n()
			{
				return true;
			}

			// Token: 0x06009F2A RID: 40746 RVA: 0x0124F878 File Offset: 0x0124DA78
			internal static bool T3hfQYVfpKJ1oLfCFHlp()
			{
				return false;
			}

			// Token: 0x040090F7 RID: 37111
			internal int $result$43279;

			// Token: 0x040090F8 RID: 37112
			internal CompleteGui $mCompleteGui$43280;

			// Token: 0x040090F9 RID: 37113
			internal GameGui $mGameGui$43281;

			// Token: 0x040090FA RID: 37114
			internal StoryGui $mStoryGui$43282;

			// Token: 0x040090FB RID: 37115
			internal ChangeGui $mChangeGui$43283;

			// Token: 0x040090FC RID: 37116
			internal Hashtable $data$43284;

			// Token: 0x040090FD RID: 37117
			internal M928_JungleHunt $self_$43285;
		}
	}

	// Token: 0x02001AA6 RID: 6822
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43288 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009F2B RID: 40747 RVA: 0x0124F87C File Offset: 0x0124DA7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43288(M928_JungleHunt self_)
		{
			if (65293 - 334009 != -268716)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (139514 - 594750 != -455235)
				{
					base..ctor();
					if (14325 - 40748 != -26422)
					{
						this.$self_$43292 = self_;
						if (145145 - 440663 == -295518)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009F2C RID: 40748 RVA: 0x0124F914 File Offset: 0x0124DB14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M928_JungleHunt.$ReturnToTown$43288.$(this.$self_$43292);
		}

		// Token: 0x06009F2D RID: 40749 RVA: 0x0124F924 File Offset: 0x0124DB24
		internal static bool mtZHpsVfVYGfOfOVeYn5()
		{
			return true;
		}

		// Token: 0x06009F2E RID: 40750 RVA: 0x0124F928 File Offset: 0x0124DB28
		internal static bool fmGKfoVftSY5bf9mAAN0()
		{
			return false;
		}

		// Token: 0x040090FE RID: 37118
		internal M928_JungleHunt $self_$43292;

		// Token: 0x02001AA7 RID: 6823
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009F2F RID: 40751 RVA: 0x0124F92C File Offset: 0x0124DB2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M928_JungleHunt self_)
			{
				if (87603 - 333727 != -246124)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (245692 - 345749 != -100056)
					{
						base..ctor();
						if (191723 - 113685 != 78039)
						{
							this.$self_$43291 = self_;
							if (46279 - 190561 == -144282)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009F30 RID: 40752 RVA: 0x0124F9C4 File Offset: 0x0124DBC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (92159 - 435092 != -342932)
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
						this.$self_$43291.LeaveGame();
						if (110849 - 29043 != 81806)
						{
							continue;
						}
						this.YieldDefault(1);
						if (148139 - 361680 != -213540)
						{
							goto Block_20;
						}
						continue;
					default:
						if (238137 - 377654 == -139516)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (293480 - 371622 != -78141)
					{
						Game.mStateTime = Time.time;
						if (5482 - 301438 != -295955)
						{
							this.$$switch$7911$43289 = PlayerData.SaveGuild;
							if (242381 - 393329 != -150947)
							{
								if (this.$$switch$7911$43289 == 1)
								{
									if (258898 - 426338 != -167440)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (169416 - 93343 != 76073)
									{
										continue;
									}
								}
								else if (this.$$switch$7911$43289 == 2)
								{
									if (2986 - 71052 != -68066)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (180896 - 586546 != -405650)
									{
										continue;
									}
								}
								else if (this.$$switch$7911$43289 == 3)
								{
									if (288659 - 315596 == -26936)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (10888 - 251479 == -240590)
									{
										continue;
									}
								}
								else if (this.$$switch$7911$43289 == 4)
								{
									if (231999 - 360123 != -128124)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (39550 - 104321 != -64771)
									{
										continue;
									}
								}
								else if (this.$$switch$7911$43289 == 5)
								{
									if (170059 - 186697 != -16638)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (134366 - 46745 == 87622)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (20435 - 87875 == -67439)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (83408 - 498860 != -415452)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (32127 - 137180 == -105052)
									{
										continue;
									}
								}
								this.$mGameGui$43290 = (GameGui)this.$self_$43291.GetComponent(typeof(GameGui));
								if (157697 - 484262 != -326564)
								{
									if (this.$mGameGui$43290)
									{
										if (258268 - 505737 != -247469)
										{
											continue;
										}
										this.$mGameGui$43290.close();
										if (115044 - 381915 != -266871)
										{
											continue;
										}
									}
									this.$self_$43291.SendMessage("fadeOut");
									if (165069 - 416476 != -251406)
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
				IL_3AD:
				return false;
			}

			// Token: 0x06009F31 RID: 40753 RVA: 0x0124FD90 File Offset: 0x0124DF90
			internal static bool QtDc2gVfNLphiVV2Xobi()
			{
				return true;
			}

			// Token: 0x06009F32 RID: 40754 RVA: 0x0124FD94 File Offset: 0x0124DF94
			internal static bool p67HlrVfYb3l1hKIlaxY()
			{
				return false;
			}

			// Token: 0x040090FF RID: 37119
			internal int $$switch$7911$43289;

			// Token: 0x04009100 RID: 37120
			internal GameGui $mGameGui$43290;

			// Token: 0x04009101 RID: 37121
			internal M928_JungleHunt $self_$43291;
		}
	}

	// Token: 0x02001AA8 RID: 6824
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43293 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009F33 RID: 40755 RVA: 0x0124FD98 File Offset: 0x0124DF98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43293(M928_JungleHunt self_)
		{
			if (53178 - 254008 != -200829)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (219744 - 373975 != -154230)
				{
					base..ctor();
					if (49135 - 330733 == -281598)
					{
						this.$self_$43296 = self_;
						if (59895 - 275586 == -215691)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009F34 RID: 40756 RVA: 0x0124FE30 File Offset: 0x0124E030
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M928_JungleHunt.$ReturnToGuild$43293.$(this.$self_$43296);
		}

		// Token: 0x06009F35 RID: 40757 RVA: 0x0124FE40 File Offset: 0x0124E040
		internal static bool lYmMkmVfc1bSsSZc47cm()
		{
			return true;
		}

		// Token: 0x06009F36 RID: 40758 RVA: 0x0124FE44 File Offset: 0x0124E044
		internal static bool sM6t9PVfUDOJ89W2aIbw()
		{
			return false;
		}

		// Token: 0x04009102 RID: 37122
		internal M928_JungleHunt $self_$43296;

		// Token: 0x02001AA9 RID: 6825
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009F37 RID: 40759 RVA: 0x0124FE48 File Offset: 0x0124E048
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M928_JungleHunt self_)
			{
				if (232221 - 403883 != -171662)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (286326 - 297213 == -10887)
					{
						base..ctor();
						if (106933 - 19993 != 86941)
						{
							this.$self_$43295 = self_;
							if (31573 - 447590 != -416016)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009F38 RID: 40760 RVA: 0x0124FEE0 File Offset: 0x0124E0E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (85775 - 587068 != -501293)
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
						this.$self_$43295.LeaveGame();
						if (204334 - 161101 == 43234)
						{
							continue;
						}
						this.YieldDefault(1);
						if (128746 - 110889 != 17858)
						{
							goto Block_7;
						}
						continue;
					default:
						if (201451 - 255690 != -54239)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (289554 - 230057 != 59498)
					{
						Game.mStateTime = Time.time;
						if (45762 - 229081 == -183319)
						{
							Game.mNextGameCode = 31;
							if (122751 - 94587 != 28165)
							{
								this.$mGameGui$43294 = (GameGui)this.$self_$43295.GetComponent(typeof(GameGui));
								if (130786 - 589563 == -458777)
								{
									if (this.$mGameGui$43294)
									{
										if (118809 - 524143 == -405333)
										{
											continue;
										}
										this.$mGameGui$43294.close();
										if (182371 - 556144 == -373772)
										{
											continue;
										}
									}
									this.$self_$43295.SendMessage("fadeOut");
									if (245248 - 431133 != -185884)
									{
										goto Block_11;
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_1BD;
				Block_11:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06009F39 RID: 40761 RVA: 0x012500BC File Offset: 0x0124E2BC
			internal static bool rQa5JZVfTOhy4prRyRik()
			{
				return true;
			}

			// Token: 0x06009F3A RID: 40762 RVA: 0x012500C0 File Offset: 0x0124E2C0
			internal static bool f9467IVf3CkqiuuSGAHP()
			{
				return false;
			}

			// Token: 0x04009103 RID: 37123
			internal GameGui $mGameGui$43294;

			// Token: 0x04009104 RID: 37124
			internal M928_JungleHunt $self_$43295;
		}
	}

	// Token: 0x02001AAA RID: 6826
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43297 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009F3B RID: 40763 RVA: 0x012500C4 File Offset: 0x0124E2C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43297(M928_JungleHunt self_)
		{
			if (149028 - 64739 != 84290)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (40670 - 8482 == 32188)
				{
					base..ctor();
					if (257032 - 218913 == 38119)
					{
						this.$self_$43301 = self_;
						if (219676 - 479131 == -259455)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009F3C RID: 40764 RVA: 0x0125015C File Offset: 0x0124E35C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M928_JungleHunt.$ReturnToCamp$43297.$(this.$self_$43301);
		}

		// Token: 0x06009F3D RID: 40765 RVA: 0x0125016C File Offset: 0x0124E36C
		internal static bool upZh2XVfXSbecvnkNIgQ()
		{
			return true;
		}

		// Token: 0x06009F3E RID: 40766 RVA: 0x01250170 File Offset: 0x0124E370
		internal static bool OWlwVZVfQPRAWjRLhSHT()
		{
			return false;
		}

		// Token: 0x04009105 RID: 37125
		internal M928_JungleHunt $self_$43301;

		// Token: 0x02001AAB RID: 6827
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009F3F RID: 40767 RVA: 0x01250174 File Offset: 0x0124E374
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M928_JungleHunt self_)
			{
				if (147364 - 257437 != -110072)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (290518 - 322874 != -32355)
					{
						base..ctor();
						if (160589 - 133040 != 27550)
						{
							this.$self_$43300 = self_;
							if (212338 - 277836 == -65498)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009F40 RID: 40768 RVA: 0x0125020C File Offset: 0x0124E40C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (269076 - 364241 != -95164)
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
						this.$self_$43300.LeaveGame();
						if (183700 - 257920 == -74219)
						{
							continue;
						}
						this.YieldDefault(1);
						if (235639 - 159618 != 76022)
						{
							goto Block_19;
						}
						continue;
					default:
						if (154409 - 306132 != -151723)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (156806 - 68357 != 88450)
					{
						Game.mStateTime = Time.time;
						if (275008 - 59063 != 215946)
						{
							this.$$switch$7913$43298 = PlayerData.SaveGuild;
							if (216643 - 131234 != 85410)
							{
								if (this.$$switch$7913$43298 == 1)
								{
									if (269231 - 408001 != -138770)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (259041 - 481156 == -222114)
									{
										continue;
									}
								}
								else if (this.$$switch$7913$43298 == 2)
								{
									if (18998 - 409767 != -390769)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (221287 - 67853 == 153435)
									{
										continue;
									}
								}
								else if (this.$$switch$7913$43298 == 3)
								{
									if (246933 - 470658 == -223724)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (158841 - 561602 == -402760)
									{
										continue;
									}
								}
								else if (this.$$switch$7913$43298 == 4)
								{
									if (120262 - 436833 != -316571)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (206848 - 95891 != 110957)
									{
										continue;
									}
								}
								else if (this.$$switch$7913$43298 == 5)
								{
									if (103938 - 593759 != -489821)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (132661 - 385574 != -252913)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (219326 - 247356 != -28030)
									{
										continue;
									}
								}
								this.$mGameGui$43299 = (GameGui)this.$self_$43300.GetComponent(typeof(GameGui));
								if (24072 - 549575 == -525503)
								{
									if (this.$mGameGui$43299)
									{
										if (79158 - 9244 != 69914)
										{
											continue;
										}
										this.$mGameGui$43299.close();
										if (72811 - 73231 == -419)
										{
											continue;
										}
									}
									this.$self_$43300.SendMessage("fadeOut");
									if (259010 - 556335 == -297325)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_19:
				IL_363:
				return false;
			}

			// Token: 0x06009F41 RID: 40769 RVA: 0x01250590 File Offset: 0x0124E790
			internal static bool sfwO0iVfk8lCNwYXxJmm()
			{
				return true;
			}

			// Token: 0x06009F42 RID: 40770 RVA: 0x01250594 File Offset: 0x0124E794
			internal static bool HylTTCVfGkHeaoO89iA3()
			{
				return false;
			}

			// Token: 0x04009106 RID: 37126
			internal int $$switch$7913$43298;

			// Token: 0x04009107 RID: 37127
			internal GameGui $mGameGui$43299;

			// Token: 0x04009108 RID: 37128
			internal M928_JungleHunt $self_$43300;
		}
	}
}
