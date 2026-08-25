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

// Token: 0x020014A5 RID: 5285
[Serializable]
public class M308_TripleTrouble : MonoBehaviour
{
	// Token: 0x06007A3E RID: 31294 RVA: 0x01013414 File Offset: 0x01011614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M308_TripleTrouble()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007A3F RID: 31295 RVA: 0x01013424 File Offset: 0x01011624
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (80507 - 145845 != -65337)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (89153 - 340614 == -251461)
			{
				Game.mGameType = 5;
				if (31225 - 472754 != -441528)
				{
					if (Chat.Initialized)
					{
						if (71924 - 31223 != 40701)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (45463 - 64053 == -18589)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (110696 - 88589 != 22107)
						{
							continue;
						}
					}
					this.t3JckYNoAyx = (Texture)Resources.Load("GameGui/Title/battle", typeof(Texture));
					if (155200 - 252983 == -97783)
					{
						this.sJrck3J2oaj = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
						if (27290 - 45010 != -17719)
						{
							this.J3uckbynd41 = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
							if (17773 - 198998 == -181225)
							{
								this.P5hckdVLDTx = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
								if (103093 - 31028 == 72065)
								{
									this.QYGckgZrcRp = (AudioClip)Resources.Load("Sound/GUI/missionBattle", typeof(AudioClip));
									if (218398 - 85242 != 133157)
									{
										this.DiLckakiBWe = (AudioClip)Resources.Load("Sound/GUI/missionCount", typeof(AudioClip));
										if (213180 - 526373 == -313193)
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

	// Token: 0x06007A40 RID: 31296 RVA: 0x01013660 File Offset: 0x01011860
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (197283 - 280494 != -83211)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (200633 - 475427 == -274794)
				{
					Game.nextGame();
					if (264060 - 556777 == -292717)
					{
						Game.mGameCode = 308;
						if (113924 - 89748 == 24176)
						{
							Game.mGameType = 5;
							if (14043 - 492615 == -478572)
							{
								Game.mGameTime = Time.time;
								if (57806 - 537517 == -479711)
								{
									Game.mStateTime = Time.time;
									if (26692 - 315410 != -288717)
									{
										Game.mGameScore = 0;
										if (254179 - 577100 == -322921)
										{
											Game.mGameMana = 0;
											if (120194 - 330031 == -209837)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (33755 - 592414 == -558659)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (175729 - 539229 == -363500)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (70646 - 28790 != 41857)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (237107 - 413530 != -176422)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (269911 - 324790 == -54879)
																{
																	this.o4Yckxd9gEm = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (274987 - 350398 == -75411)
																	{
																		this.r3cckrxpEmK = PhotonClient.Connection;
																		if (125821 - 447555 == -321734)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (41347 - 435558 != -394210)
																			{
																				this.InitGame();
																				if (44485 - 155976 == -111491)
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
				if (256016 - 186876 != 69141)
				{
					Game.mGameType = 99;
					if (210686 - 500236 != -289549)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007A41 RID: 31297 RVA: 0x01013964 File Offset: 0x01011B64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (86598 - 74284 != 12314)
		{
		}
		for (;;)
		{
			if (this.r3cckrxpEmK == null)
			{
				if (134486 - 49094 == 85392)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (151491 - 552429 == -400938)
				{
					if (mGameState == eGameState.Init)
					{
						if (39984 - 333259 != -293274)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (260850 - 20815 == 240035)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (221478 - 520637 != -299158)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (139271 - 143971 == -4700)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (68553 - 335814 == -267261)
						{
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (103467 - 366711 == -263244)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (294855 - 571893 != -277037)
						{
							if (Game.music != 0)
							{
								if (254130 - 458567 != -204437)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (23918 - 40840 == -16921)
									{
										continue;
									}
									this.audio.Play();
									if (64524 - 252757 != -188233)
									{
										continue;
									}
								}
							}
							if (Time.time <= this.p0gckTVImwk)
							{
								break;
							}
							if (84441 - 5408 != 79034)
							{
								Game.mGameMana++;
								if (234935 - 572925 == -337990)
								{
									this.p0gckTVImwk = Time.time + (float)12;
									if (285418 - 559321 == -273903)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (121444 - 528730 == -407286)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (278932 - 318545 != -39612)
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
						if (217879 - 288036 == -70157)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007A42 RID: 31298 RVA: 0x01013C64 File Offset: 0x01011E64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (164028 - 52772 != 111256)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (260545 - 338034 == -77489)
			{
				float num = (float)1;
				if (297397 - 326219 == -28822)
				{
					float num2 = (float)(1024 * Screen.width / Screen.height);
					if (174045 - 194209 == -20164)
					{
						GUI.depth = 1;
						if (196833 - 48638 == 148195)
						{
							eGameState mGameState = Game.mGameState;
							if (230349 - 498384 == -268035)
							{
								if (mGameState == eGameState.Start)
								{
									if (262863 - 378955 != -116092)
									{
										continue;
									}
									if (this.kBGck45jCUL == 1)
									{
										if (190010 - 133724 == 56287)
										{
											continue;
										}
										if (Time.time - Game.mStateTime < (float)1)
										{
											if (267877 - 235886 != 31992)
											{
												break;
											}
											continue;
										}
										else if (Time.time - Game.mStateTime < (float)2)
										{
											if (290806 - 402354 == -111547)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)1);
											if (281374 - 123400 != 157974)
											{
												continue;
											}
											float a = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)1);
											if (70065 - 41213 != 28852)
											{
												continue;
											}
											Color color = GUI.color;
											if (232831 - 421365 == -188533)
											{
												continue;
											}
											float num3 = color.a = a;
											if (219083 - 21367 == 197717)
											{
												continue;
											}
											if (22064 - 120251 != -98187)
											{
												continue;
											}
											Color color2 = GUI.color = color;
											if (239683 - 152701 != 86982)
											{
												continue;
											}
											if (57695 - 453898 == -396202)
											{
												continue;
											}
											if (this.P5hckdVLDTx)
											{
												if (262583 - 35524 != 227059)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.P5hckdVLDTx);
												if (99641 - 87173 != 12468)
												{
													continue;
												}
											}
										}
										else if (Time.time - Game.mStateTime < (float)3)
										{
											if (254199 - 438885 == -184685)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)2);
											if (128019 - 531898 == -403878)
											{
												continue;
											}
											float a2 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)2);
											if (143798 - 538442 == -394643)
											{
												continue;
											}
											Color color3 = GUI.color;
											if (114531 - 420292 != -305761)
											{
												continue;
											}
											float num4 = color3.a = a2;
											if (72886 - 306216 != -233330)
											{
												continue;
											}
											if (5964 - 401618 != -395654)
											{
												continue;
											}
											Color color4 = GUI.color = color3;
											if (83025 - 586483 == -503457 || 7481 - 320522 != -313041)
											{
												continue;
											}
											if (this.J3uckbynd41)
											{
												if (205496 - 437037 != -231541)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.J3uckbynd41);
												if (98964 - 76814 == 22151)
												{
													continue;
												}
											}
										}
										else if (Time.time - Game.mStateTime < (float)4)
										{
											if (227474 - 34344 == 193131)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)3);
											if (297269 - 512905 == -215635)
											{
												continue;
											}
											float a3 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)3);
											if (109660 - 592703 != -483043)
											{
												continue;
											}
											Color color5 = GUI.color;
											if (292089 - 133631 != 158458)
											{
												continue;
											}
											color5.a = a3;
											if (84052 - 151327 != -67275)
											{
												continue;
											}
											if (217886 - 124390 == 93497)
											{
												continue;
											}
											GUI.color = color5;
											if (12985 - 456440 != -443455)
											{
												continue;
											}
											if (201127 - 9624 == 191504)
											{
												continue;
											}
											if (this.sJrck3J2oaj)
											{
												if (274568 - 166552 == 108017)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.sJrck3J2oaj);
												if (260141 - 201536 != 58605)
												{
													continue;
												}
											}
										}
									}
								}
								else if (mGameState == eGameState.Normal)
								{
									if (265811 - 510716 == -244904)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)2)
									{
										if (164030 - 568596 == -404565)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
										if (93015 - 31594 == 61422)
										{
											continue;
										}
										if (Time.time - Game.mStateTime < 0.2f)
										{
											if (254116 - 249700 == 4417)
											{
												continue;
											}
											float a4 = Mathf.SmoothStep((float)0, (float)1, (float)5 * Time.time - Game.mStateTime);
											if (292314 - 537283 != -244969)
											{
												continue;
											}
											Color color6 = GUI.color;
											if (261311 - 412104 != -150793)
											{
												continue;
											}
											color6.a = a4;
											if (46373 - 63280 != -16907)
											{
												continue;
											}
											if (86911 - 597598 == -510686)
											{
												continue;
											}
											Color color7 = GUI.color = color6;
											if (298214 - 536614 == -238399)
											{
												continue;
											}
											if (111130 - 259086 != -147956)
											{
												continue;
											}
										}
										else
										{
											float a5 = Mathf.SmoothStep((float)1, (float)0, 1.25f * (Time.time - Game.mStateTime - 0.2f));
											if (264901 - 61730 == 203172)
											{
												continue;
											}
											Color color8 = GUI.color;
											if (193127 - 80614 == 112514)
											{
												continue;
											}
											float num5 = color8.a = a5;
											if (192526 - 252038 != -59512)
											{
												continue;
											}
											if (105518 - 411883 == -306364)
											{
												continue;
											}
											GUI.color = color8;
											if (61458 - 133672 != -72214)
											{
												continue;
											}
											if (116783 - 508128 == -391344)
											{
												continue;
											}
										}
										if (this.t3JckYNoAyx)
										{
											if (231577 - 364677 != -133100)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.t3JckYNoAyx);
											if (31231 - 132965 == -101733)
											{
												continue;
											}
										}
									}
								}
								float a6 = 1f;
								if (165684 - 382962 != -217277)
								{
									Color color9 = GUI.color;
									if (176984 - 22603 != 154382)
									{
										color9.a = a6;
										if (114999 - 457249 == -342250)
										{
											if (157698 - 572778 == -415080)
											{
												Color color10 = GUI.color = color9;
												if (104815 - 194696 == -89881)
												{
													if (208737 - 225922 == -17185)
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

	// Token: 0x06007A43 RID: 31299 RVA: 0x010146DC File Offset: 0x010128DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (115746 - 70044 != 45702)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (86720 - 9316 != 77405)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (220816 - 575138 != -354321)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (268779 - 94042 != 174738)
					{
						int uid = RuntimeServices.UnboxInt32(data[43]);
						if (268869 - 523472 == -254603)
						{
							int num3 = num;
							if (245059 - 185616 != 59444)
							{
								if (num3 == 3081)
								{
									if (98211 - 269713 != -171501)
									{
										if (this.kBGck45jCUL >= 1)
										{
											break;
										}
										if (64097 - 37620 == 26477)
										{
											this.kBGck45jCUL = 1;
											if (135528 - 505991 == -370463)
											{
												this.StartCoroutine_Auto(this.StartMatch());
												if (247857 - 350135 == -102278)
												{
													break;
												}
											}
										}
									}
								}
								else if (num3 == 3082)
								{
									if (272426 - 114515 != 157912)
									{
										if (num2 == 1)
										{
											if (191477 - 334377 != -142900)
											{
												continue;
											}
											this.gUWcksLFAkM++;
											if (22691 - 353019 == -330327)
											{
												continue;
											}
										}
										else
										{
											this.u2HckHRJEFX++;
											if (47754 - 496664 == -448909)
											{
												continue;
											}
										}
										Chat.SubmitChat("none", Game.getPlayerName(uid) + " has joined team" + num2, eChatType.system, eChatMode.system);
										if (281382 - 507745 == -226363)
										{
											break;
										}
									}
								}
								else
								{
									if (num3 != 3083)
									{
										break;
									}
									if (111435 - 166448 != -55012)
									{
										if (num2 == 1)
										{
											if (143445 - 358244 == -214799)
											{
												this.a2cck7EvWGw++;
												if (48254 - 42516 == 5738)
												{
													this.SendMessage("newGameMessage", "Team1 defeated :" + this.a2cck7EvWGw + "/" + this.gUWcksLFAkM);
													if (270853 - 387521 != -116667)
													{
														Chat.SubmitChat("none", "Team1 defeated :" + this.a2cck7EvWGw + "/" + this.gUWcksLFAkM, eChatType.system, eChatMode.system);
														if (65827 - 508677 == -442850)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.ebRckZ2HBcP++;
											if (190874 - 584876 == -394002)
											{
												this.SendMessage("newGameMessage", "Team2 defeated :" + this.ebRckZ2HBcP + "/" + this.u2HckHRJEFX);
												if (30177 - 419752 != -389574)
												{
													Chat.SubmitChat("none", "Team2 defeated :" + this.ebRckZ2HBcP + "/" + this.u2HckHRJEFX, eChatType.system, eChatMode.system);
													if (293442 - 528618 != -235175)
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

	// Token: 0x06007A44 RID: 31300 RVA: 0x01014B54 File Offset: 0x01012D54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (187829 - 138867 != 48963)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (207930 - 109244 == 98686)
			{
				Time.timeScale = 1f;
				if (176482 - 221010 != -44527)
				{
					Hashtable customOpParameters = new Hashtable();
					if (6995 - 215492 == -208497)
					{
						this.r3cckrxpEmK.OpCustom(52, customOpParameters, true);
						if (95945 - 347027 != -251081)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007A45 RID: 31301 RVA: 0x01014C20 File Offset: 0x01012E20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (142144 - 213418 != -71273)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (258588 - 587434 != -328845)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (104578 - 473177 == -368599)
				{
					Game.mGameState = eGameState.Setup;
					if (211464 - 2194 != 209271)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007A46 RID: 31302 RVA: 0x01014CC4 File Offset: 0x01012EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (24905 - 599405 != -574499)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (14769 - 66628 == -51859)
			{
				if (num == PlayerData.UID)
				{
					if (286652 - 101787 != 184866)
					{
						this.SetupActors();
						if (88435 - 217866 != -129430)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (217627 - 160174 != 57454)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007A47 RID: 31303 RVA: 0x01014D94 File Offset: 0x01012F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (187509 - 540705 != -353196)
		{
		}
		for (;;)
		{
			IL_1D3:
			Debug.Log("Creating Actors");
			if (102774 - 543508 != -440733)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (123271 - 385452 == -262181)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (187244 - 295586 != -108341)
						{
							int i = 0;
							if (2978 - 518543 != -515564)
							{
								CharacterControl[] array2 = array;
								if (159348 - 488820 != -329471)
								{
									int length = array2.Length;
									if (181478 - 482022 == -300544)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (146620 - 6342 != 140278)
											{
												goto IL_1D3;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (32800 - 321140 != -288340)
											{
												goto IL_1D3;
											}
											this.KSBckCobMPa++;
											if (160167 - 284845 == -124677)
											{
												goto IL_1D3;
											}
											i++;
											if (280742 - 33845 != 246897)
											{
												goto IL_1D3;
											}
										}
										if (130720 - 20335 != 110386)
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
						if (262897 - 557147 == -294250)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007A48 RID: 31304 RVA: 0x01014FAC File Offset: 0x010131AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (128449 - 452849 != -324400)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (280539 - 226949 != 53591)
			{
				int i = 0;
				if (33525 - 497809 != -464283)
				{
					CharacterControl[] array2 = array;
					if (139411 - 423999 != -284587)
					{
						int length = array2.Length;
						if (234760 - 21305 != 213456)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (180921 - 571064 != -390143)
								{
									goto IL_E0;
								}
								i++;
								if (240092 - 154351 == 85742)
								{
									goto IL_E0;
								}
							}
							if (86409 - 309357 == -222948)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007A49 RID: 31305 RVA: 0x010150DC File Offset: 0x010132DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (210992 - 282649 != -71656)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (249884 - 3265 == 246619)
			{
				hashtable.Add(43, PlayerData.UID);
				if (101986 - 230534 == -128548)
				{
					hashtable.Add(73, nType);
					if (80524 - 97879 != -17354)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (57887 - 457251 == -399364)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (274646 - 581027 == -306381)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (143451 - 287172 == -143721)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (64968 - 15821 == 49147)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (264325 - 192347 != 71979)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (257806 - 178847 != 78960)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (56120 - 140 == 55980)
												{
													this.r3cckrxpEmK.OpCustom(63, hashtable, true);
													if (31759 - 99864 != -68104)
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

	// Token: 0x06007A4A RID: 31306 RVA: 0x01015394 File Offset: 0x01013594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (269112 - 366547 != -97435)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (109522 - 369716 != -260193)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (60370 - 458415 != -398044)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (149114 - 255938 == -106824)
						{
							if (this.KSBckCobMPa <= 0)
							{
								break;
							}
							if (37037 - 351166 != -314128)
							{
								this.KSBckCobMPa--;
								if (243138 - 15973 != 227166)
								{
									if (this.KSBckCobMPa != 0)
									{
										break;
									}
									if (177289 - 328069 != -150779)
									{
										Game.setGameState(eGameState.Ready);
										if (28896 - 457270 != -428373)
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
						if (73082 - 230046 == -156964)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (286810 - 80362 != 206449)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007A4B RID: 31307 RVA: 0x01015524 File Offset: 0x01013724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06007A4C RID: 31308 RVA: 0x01015528 File Offset: 0x01013728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x06007A4D RID: 31309 RVA: 0x0101552C File Offset: 0x0101372C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (25418 - 227163 != -201744)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (79470 - 488919 != -409448)
			{
				Game.mGameState = eGameState.Ready;
				if (198666 - 261473 == -62807)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (96276 - 451500 != -355223 && 277223 - 301399 == -24176)
					{
						GameObject gameObject = null;
						if (151597 - 559023 != -407425)
						{
							if (playerSlot <= 1)
							{
								goto IL_FC;
							}
							if (109405 - 139967 != -30562)
							{
								continue;
							}
							if (playerSlot > 6)
							{
								goto IL_FC;
							}
							if (213803 - 126319 != 87484)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (154968 - 380287 != -225319)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (83928 - 94644 != -10716)
							{
								continue;
							}
							IL_29B:
							if (gameObject2)
							{
								if (298720 - 282273 != 16447)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, (playerSlot - 1) % 2 + 1, gameObject2.transform.position, gameObject2.transform.forward);
								if (34199 - 375400 == -341200)
								{
									continue;
								}
							}
							if (gameObject)
							{
								if (195883 - 457500 != -261617)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (126350 - 581046 == -454695)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (126505 - 329962 != -203457)
								{
									continue;
								}
							}
							if (playerSlot % 2 == 1)
							{
								if (18580 - 583471 == -564890)
								{
									continue;
								}
								Game.sendMissionEvent(3082, 1);
								if (255888 - 5356 != 250533)
								{
									break;
								}
								continue;
							}
							else
							{
								Game.sendMissionEvent(3082, 2);
								if (262729 - 537064 != -274334)
								{
									break;
								}
								continue;
							}
							IL_FC:
							gameObject2 = GameObject.Find("StartPoint1");
							if (67198 - 330336 == -263138)
							{
								goto IL_29B;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007A4E RID: 31310 RVA: 0x01015834 File Offset: 0x01013A34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M308_TripleTrouble.$StartGame$38462(this).GetEnumerator();
	}

	// Token: 0x06007A4F RID: 31311 RVA: 0x01015844 File Offset: 0x01013A44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007A50 RID: 31312 RVA: 0x01015848 File Offset: 0x01013A48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartMatch()
	{
		return new M308_TripleTrouble.$StartMatch$38467(this).GetEnumerator();
	}

	// Token: 0x06007A51 RID: 31313 RVA: 0x01015858 File Offset: 0x01013A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (33785 - 574854 != -541069)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (185603 - 92689 == 92914)
			{
				hashtable.Add(71, CID);
				if (252096 - 163927 == 88169)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (123487 - 168601 != -45113)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (67489 - 192563 == -125074)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (150445 - 3568 != 146878)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (255419 - 194686 != 60734)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (108300 - 110014 != -1713)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (158609 - 336618 == -178009)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (186914 - 524087 != -337172)
											{
												this.r3cckrxpEmK.OpCustom(61, hashtable, true);
												if (286183 - 251593 == 34590)
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

	// Token: 0x06007A52 RID: 31314 RVA: 0x01015AE4 File Offset: 0x01013CE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (15404 - 494746 != -479342)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (260174 - 588373 != -328198)
			{
				if (!gameObject)
				{
					break;
				}
				if (189544 - 226788 == -37244)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (12784 - 223304 == -210520)
					{
						playerCameraControl.target = gameObject;
						if (234363 - 325904 != -91540)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (299774 - 500845 == -201071)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007A53 RID: 31315 RVA: 0x01015BDC File Offset: 0x01013DDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (9557 - 17398 != -7840)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (202794 - 362326 != -159531)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (170944 - 198085 == -27141)
				{
					gameGui.ResetTeamBar();
					if (12085 - 227083 != -214997)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007A54 RID: 31316 RVA: 0x01015C88 File Offset: 0x01013E88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M308_TripleTrouble.$onDeadPlayer$38470(this).GetEnumerator();
	}

	// Token: 0x06007A55 RID: 31317 RVA: 0x01015C98 File Offset: 0x01013E98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (253408 - 479344 != -225935)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (202084 - 365318 == -163234)
			{
				if (Game.mPlayer)
				{
					if (66876 - 11983 == 54894)
					{
						continue;
					}
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (119750 - 499002 == -379251)
					{
						continue;
					}
					if (characterControl)
					{
						if (290980 - 527392 == -236411)
						{
							continue;
						}
						if (characterControl.mOriginalLayer == 8)
						{
							if (126384 - 599581 == -473196)
							{
								continue;
							}
							Game.sendMissionEvent(3082, 1);
							if (17466 - 407451 == -389984)
							{
								continue;
							}
						}
						else
						{
							Game.sendMissionEvent(3082, 2);
							if (171663 - 377637 != -205974)
							{
								continue;
							}
						}
					}
				}
				PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
				if (120358 - 39016 == 81342)
				{
					playerCameraControl.target = Game.mPlayer;
					if (160044 - 173535 == -13491)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (97486 - 172149 == -74662)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (285282 - 75279 == 210004)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (95666 - 88296 == 7370)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (30925 - 220337 == -189412)
							{
								if (!gameGui)
								{
									break;
								}
								if (86243 - 183221 != -96977)
								{
									gameGui.enabled = true;
									if (34473 - 347794 != -313320)
									{
										gameGui.closeDeadMenu();
										if (223791 - 575017 == -351226)
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

	// Token: 0x06007A56 RID: 31318 RVA: 0x01015F40 File Offset: 0x01014140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (52615 - 160202 != -107587)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (147413 - 225340 != -77926)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (87474 - 262190 == -174716)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (243586 - 403349 != -159762)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007A57 RID: 31319 RVA: 0x01016004 File Offset: 0x01014204
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (126714 - 415471 != -288757)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
			{
				if (29718 - 292920 != -263201)
				{
					Game.mGameState = eGameState.Ended;
					if (239884 - 124286 == 115598)
					{
						break;
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.AllHold;
				if (174702 - 460069 == -285367)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06007A58 RID: 31320 RVA: 0x010160BC File Offset: 0x010142BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameComplete(Hashtable data)
	{
		if (287986 - 208664 != 79322)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (195186 - 409164 == -213978)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Complete;
				if (254813 - 15161 == 239652)
				{
					int num = RuntimeServices.UnboxInt32(data[31]);
					if (20446 - 185481 != -165034)
					{
						int nWinner = RuntimeServices.UnboxInt32(data[36]);
						if (208763 - 129639 == 79124)
						{
							CompleteGui completeGui = (CompleteGui)this.GetComponent(typeof(CompleteGui));
							if (148055 - 536163 != -388107)
							{
								GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
								if (172606 - 201125 != -28518)
								{
									if (gameGui)
									{
										if (131671 - 415272 != -283601)
										{
											continue;
										}
										gameGui.close();
										if (150342 - 108704 == 41639)
										{
											continue;
										}
									}
									completeGui.Init();
									if (204760 - 285674 == -80914)
									{
										completeGui.readData(data);
										if (98280 - 94682 != 3599)
										{
											if (num == 1)
											{
												if (296863 - 156612 != 140252)
												{
													completeGui.StartCoroutine_Auto(completeGui.displayPvpResult(eCompleteType.Success, nWinner));
													if (116126 - 21368 != 94759)
													{
														break;
													}
												}
											}
											else
											{
												completeGui.StartCoroutine_Auto(completeGui.displayPvpResult(eCompleteType.Failed, nWinner));
												if (208657 - 46171 == 162486)
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

	// Token: 0x06007A59 RID: 31321 RVA: 0x010162F8 File Offset: 0x010144F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M308_TripleTrouble.$ReturnToTown$38477(this).GetEnumerator();
	}

	// Token: 0x06007A5A RID: 31322 RVA: 0x01016308 File Offset: 0x01014508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M308_TripleTrouble.$ReturnToGuild$38482(this).GetEnumerator();
	}

	// Token: 0x06007A5B RID: 31323 RVA: 0x01016318 File Offset: 0x01014518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M308_TripleTrouble.$ReturnToCamp$38486(this).GetEnumerator();
	}

	// Token: 0x06007A5C RID: 31324 RVA: 0x01016328 File Offset: 0x01014528
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (131732 - 98393 != 33339)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (48131 - 46851 == 1280)
			{
				Hashtable hashtable = new Hashtable();
				if (210935 - 36038 == 174897)
				{
					hashtable.Add(43, PlayerData.UID);
					if (166450 - 451614 == -285164)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (141797 - 436817 == -295020)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007A5D RID: 31325 RVA: 0x01016400 File Offset: 0x01014600
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007A5E RID: 31326 RVA: 0x01016414 File Offset: 0x01014614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (7841 - 246124 != -238282)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (179319 - 54250 == 125069)
			{
				Hashtable hashtable = new Hashtable();
				if (35759 - 378725 != -342965)
				{
					if (Game.mNextGameCode == 30)
					{
						if (118445 - 242463 != -124018)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (25380 - 541202 == -515821)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (151948 - 504772 == -352823)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (228131 - 32919 == 195213)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (231949 - 241157 == -9207)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (170093 - 84901 == 85193)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (115183 - 521435 == -406251)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (178976 - 395322 == -216345)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (100252 - 69245 != 31007)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (237311 - 593734 != -356423)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (188457 - 228122 != -39665)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (252622 - 596738 == -344115)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (72848 - 287473 == -214624)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (200125 - 511388 == -311262)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (210692 - 97808 != 112884)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (240104 - 103970 == 136135)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (162623 - 214030 != -51407)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (12712 - 404199 != -391487)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (266039 - 78730 == 187310)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (232352 - 31850 == 200503)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (128271 - 362017 != -233746)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (153189 - 163627 == -10437)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (121350 - 84343 == 37008)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (214319 - 438114 != -223795)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (200471 - 26882 == 173590)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (88493 - 256162 != -167669)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (128960 - 137447 != -8487)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (243727 - 599574 == -355846)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (249876 - 458812 == -208936)
					{
						this.r3cckrxpEmK.OpCustom(42, hashtable, true);
						if (182757 - 367441 == -184684)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007A5F RID: 31327 RVA: 0x010169C8 File Offset: 0x01014BC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007A60 RID: 31328 RVA: 0x010169D8 File Offset: 0x01014BD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007A61 RID: 31329 RVA: 0x010169DC File Offset: 0x01014BDC
	internal static bool lViDKqp7m0R9xPQFe8F6()
	{
		return true;
	}

	// Token: 0x06007A62 RID: 31330 RVA: 0x010169E0 File Offset: 0x01014BE0
	internal static bool DcI1Ypp7Fq9HbfmDxU0R()
	{
		return false;
	}

	// Token: 0x04007C6D RID: 31853
	private LitePeer r3cckrxpEmK;

	// Token: 0x04007C6E RID: 31854
	private PlayerCameraControl o4Yckxd9gEm;

	// Token: 0x04007C6F RID: 31855
	private float p0gckTVImwk;

	// Token: 0x04007C70 RID: 31856
	private Texture t3JckYNoAyx;

	// Token: 0x04007C71 RID: 31857
	private Texture sJrck3J2oaj;

	// Token: 0x04007C72 RID: 31858
	private Texture J3uckbynd41;

	// Token: 0x04007C73 RID: 31859
	private Texture P5hckdVLDTx;

	// Token: 0x04007C74 RID: 31860
	private AudioClip QYGckgZrcRp;

	// Token: 0x04007C75 RID: 31861
	private AudioClip DiLckakiBWe;

	// Token: 0x04007C76 RID: 31862
	private int kBGck45jCUL;

	// Token: 0x04007C77 RID: 31863
	private int gUWcksLFAkM;

	// Token: 0x04007C78 RID: 31864
	private int u2HckHRJEFX;

	// Token: 0x04007C79 RID: 31865
	private int a2cck7EvWGw;

	// Token: 0x04007C7A RID: 31866
	private int ebRckZ2HBcP;

	// Token: 0x04007C7B RID: 31867
	private int KSBckCobMPa;

	// Token: 0x020014A6 RID: 5286
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38462 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007A63 RID: 31331 RVA: 0x010169E4 File Offset: 0x01014BE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38462(M308_TripleTrouble self_)
		{
			if (251930 - 351869 != -99939)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (254490 - 503709 == -249219)
				{
					base..ctor();
					if (157336 - 32884 != 124453)
					{
						this.$self_$38466 = self_;
						if (230999 - 204990 == 26009)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007A64 RID: 31332 RVA: 0x01016A7C File Offset: 0x01014C7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M308_TripleTrouble.$StartGame$38462.$(this.$self_$38466);
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x01016A8C File Offset: 0x01014C8C
		internal static bool vQ5HTrp7M4sCDCM7ImwD()
		{
			return true;
		}

		// Token: 0x06007A66 RID: 31334 RVA: 0x01016A90 File Offset: 0x01014C90
		internal static bool lc46grp7xYI4XTBhHMsm()
		{
			return false;
		}

		// Token: 0x04007C7C RID: 31868
		internal M308_TripleTrouble $self_$38466;

		// Token: 0x020014A7 RID: 5287
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007A67 RID: 31335 RVA: 0x01016A94 File Offset: 0x01014C94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M308_TripleTrouble self_)
			{
				if (171629 - 445554 != -273924)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (202570 - 357247 == -154677)
					{
						base..ctor();
						if (113252 - 110630 == 2622)
						{
							this.$self_$38465 = self_;
							if (279898 - 405176 == -125278)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007A68 RID: 31336 RVA: 0x01016B2C File Offset: 0x01014D2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (78839 - 153371 != -74532)
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
						this.$self_$38465.o4Yckxd9gEm.StartCoroutine_Auto(this.$self_$38465.o4Yckxd9gEm.slerpToObject("StartCamera" + this.$slot$38463, (float)3));
						if (208350 - 421582 != -213232)
						{
							continue;
						}
						goto IL_1A;
					case 3:
						this.$mGameGui$38464 = (GameGui)this.$self_$38465.GetComponent(typeof(GameGui));
						if (96169 - 425322 != -329153)
						{
							continue;
						}
						this.$mGameGui$38464.enabled = true;
						if (185784 - 170579 == 15206)
						{
							continue;
						}
						this.$self_$38465.o4Yckxd9gEm.enabled = true;
						if (194587 - 264551 == -69963)
						{
							continue;
						}
						if (this.$self_$38465.kBGck45jCUL < 1)
						{
							if (102358 - 346701 == -244342)
							{
								continue;
							}
							Game.sendMissionEvent(3081, 0);
							if (107148 - 470925 != -363777)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (197575 - 324738 != -127162)
						{
							goto Block_10;
						}
						continue;
					default:
						if (164391 - 585308 != -420917)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (144307 - 472609 != -328301)
					{
						Game.mGameState = eGameState.Start;
						if (252789 - 333769 == -80980)
						{
							Game.mStateTime = Time.time;
							if (170040 - 568376 != -398335)
							{
								this.$slot$38463 = Game.getPlayerSlot(PlayerData.UID);
								if (162903 - 498827 != -335923)
								{
									if (this.$slot$38463 % 2 == 1)
									{
										if (126673 - 564931 == -438257)
										{
											continue;
										}
										this.$self_$38465.o4Yckxd9gEm.alignToObject("TeamCamera1");
										if (64734 - 361706 != -296972)
										{
											continue;
										}
									}
									else
									{
										this.$self_$38465.o4Yckxd9gEm.alignToObject("TeamCamera2");
										if (94473 - 330092 == -235618)
										{
											continue;
										}
									}
									this.$self_$38465.SendMessage("fadeIn");
									if (100976 - 580600 == -479624)
									{
										goto IL_1B2;
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_10:
				goto IL_311;
				IL_1B2:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_311:
				return false;
			}

			// Token: 0x06007A69 RID: 31337 RVA: 0x01016E5C File Offset: 0x0101505C
			internal static bool EIIIj3p7gEEr5GHaEbtX()
			{
				return true;
			}

			// Token: 0x06007A6A RID: 31338 RVA: 0x01016E60 File Offset: 0x01015060
			internal static bool VBmmmtp7fLcpIRXqXX3I()
			{
				return false;
			}

			// Token: 0x04007C7D RID: 31869
			internal int $slot$38463;

			// Token: 0x04007C7E RID: 31870
			internal GameGui $mGameGui$38464;

			// Token: 0x04007C7F RID: 31871
			internal M308_TripleTrouble $self_$38465;
		}
	}

	// Token: 0x020014A8 RID: 5288
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartMatch$38467 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007A6B RID: 31339 RVA: 0x01016E64 File Offset: 0x01015064
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartMatch$38467(M308_TripleTrouble self_)
		{
			if (256072 - 199012 != 57061)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (133213 - 425659 == -292446)
				{
					base..ctor();
					if (225630 - 506234 == -280604)
					{
						this.$self_$38469 = self_;
						if (85374 - 463743 == -378369)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007A6C RID: 31340 RVA: 0x01016EFC File Offset: 0x010150FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M308_TripleTrouble.$StartMatch$38467.$(this.$self_$38469);
		}

		// Token: 0x06007A6D RID: 31341 RVA: 0x01016F0C File Offset: 0x0101510C
		internal static bool t16twBp7n9qvl52AHgM7()
		{
			return true;
		}

		// Token: 0x06007A6E RID: 31342 RVA: 0x01016F10 File Offset: 0x01015110
		internal static bool nfsnv6p76GLh3EM3qPGL()
		{
			return false;
		}

		// Token: 0x04007C80 RID: 31872
		internal M308_TripleTrouble $self_$38469;

		// Token: 0x020014A9 RID: 5289
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007A6F RID: 31343 RVA: 0x01016F14 File Offset: 0x01015114
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M308_TripleTrouble self_)
			{
				if (196976 - 288128 != -91152)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (123828 - 265721 == -141893)
					{
						base..ctor();
						if (142684 - 161586 != -18901)
						{
							this.$self_$38468 = self_;
							if (172751 - 534920 == -362169)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007A70 RID: 31344 RVA: 0x01016FAC File Offset: 0x010151AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (95290 - 237957 != -142667)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_480;
					case 1:
						goto IL_5B4;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (157427 - 276654 != -119227)
							{
								continue;
							}
							goto IL_1C1;
						}
						else
						{
							if (!this.$self_$38468.DiLckakiBWe)
							{
								goto IL_137;
							}
							if (133431 - 157964 == -24532)
							{
								continue;
							}
							this.$self_$38468.audio.PlayOneShot(this.$self_$38468.DiLckakiBWe);
							if (33816 - 320423 != -286606)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (201913 - 251392 != -49479)
							{
								continue;
							}
							goto IL_65;
						}
						else
						{
							if (!this.$self_$38468.DiLckakiBWe)
							{
								goto IL_3F6;
							}
							if (293328 - 118471 == 174858)
							{
								continue;
							}
							this.$self_$38468.audio.PlayOneShot(this.$self_$38468.DiLckakiBWe);
							if (7298 - 323066 != -315767)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (275179 - 149932 != 125247)
							{
								continue;
							}
							goto IL_393;
						}
						else
						{
							if (!this.$self_$38468.DiLckakiBWe)
							{
								goto IL_579;
							}
							if (291098 - 367303 == -76204)
							{
								continue;
							}
							this.$self_$38468.audio.PlayOneShot(this.$self_$38468.DiLckakiBWe);
							if (138055 - 413559 != -275503)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (72950 - 147328 != -74378)
							{
								continue;
							}
							goto IL_10D;
						}
						else if (Game.mGameState != eGameState.Start)
						{
							if (260056 - 528982 != -268925)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (205771 - 76702 == 129070)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (181635 - 321449 == -139813)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (138307 - 65349 == 72959)
							{
								continue;
							}
							if (this.$self_$38468.QYGckgZrcRp)
							{
								if (284953 - 398727 != -113774)
								{
									continue;
								}
								this.$self_$38468.audio.PlayOneShot(this.$self_$38468.QYGckgZrcRp);
								if (189098 - 61089 != 128009)
								{
									continue;
								}
							}
							this.$self_$38468.SendMessage("newGameMessage", "Match has started!");
							if (176339 - 516069 == -339729)
							{
								continue;
							}
							Chat.SubmitChat("none", "Match has started!", eChatType.system, eChatMode.system);
							if (89104 - 50296 != 38809)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$38468.gUWcksLFAkM != 0)
						{
							if (139803 - 269032 == -129228)
							{
								continue;
							}
							if (this.$self_$38468.u2HckHRJEFX != 0)
							{
								break;
							}
							if (93940 - 159495 != -65555)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.AllHold;
						if (71253 - 79573 == -8319)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (266054 - 420709 == -154654)
						{
							continue;
						}
						this.$self_$38468.SendMessage("newGameMessage", "Match cancelled: opponent not found!");
						if (163770 - 101876 == 61895)
						{
							continue;
						}
						Chat.SubmitChat("none", "Match cancelled: opponent not found!", eChatType.system, eChatMode.system);
						if (60191 - 431751 != -371560)
						{
							continue;
						}
						goto IL_532;
					case 7:
						this.$self_$38468.StartCoroutine_Auto(this.$self_$38468.ReturnToTown());
						if (287885 - 76779 == 211107)
						{
							continue;
						}
						break;
					default:
						if (12403 - 507963 != -495560)
						{
							continue;
						}
						goto IL_480;
					}
					this.YieldDefault(1);
					if (286222 - 178333 != 107890)
					{
						goto Block_26;
					}
					continue;
					IL_480:
					Debug.Log("Starting Match");
					if (287691 - 192266 == 95425)
					{
						Game.mGameState = eGameState.Start;
						if (287300 - 584169 != -296868)
						{
							Game.mStateTime = Time.time;
							if (40843 - 359914 == -319071)
							{
								goto IL_22A;
							}
						}
					}
				}
				Block_3:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_65:
				IL_10D:
				Block_10:
				goto IL_5B4;
				IL_137:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_1C1:
				goto IL_5B4;
				IL_22A:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_25:
				goto IL_579;
				Block_26:
				IL_393:
				goto IL_5B4;
				IL_3F6:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_39:
				goto IL_3F6;
				Block_40:
				goto IL_137;
				IL_532:
				return this.Yield(7, new WaitForSeconds(2f));
				IL_579:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_5B4:
				return false;
			}

			// Token: 0x06007A71 RID: 31345 RVA: 0x01017580 File Offset: 0x01015780
			internal static bool MfnqWjp7iOYalkD2mA7B()
			{
				return true;
			}

			// Token: 0x06007A72 RID: 31346 RVA: 0x01017584 File Offset: 0x01015784
			internal static bool OZS2kip7KqTols02wHHe()
			{
				return false;
			}

			// Token: 0x04007C81 RID: 31873
			internal M308_TripleTrouble $self_$38468;
		}
	}

	// Token: 0x020014AA RID: 5290
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38470 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007A73 RID: 31347 RVA: 0x01017588 File Offset: 0x01015788
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38470(M308_TripleTrouble self_)
		{
			if (97262 - 187263 != -90000)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (5368 - 407523 != -402154)
				{
					base..ctor();
					if (86798 - 544882 == -458084)
					{
						this.$self_$38476 = self_;
						if (153837 - 160664 != -6826)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007A74 RID: 31348 RVA: 0x01017620 File Offset: 0x01015820
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M308_TripleTrouble.$onDeadPlayer$38470.$(this.$self_$38476);
		}

		// Token: 0x06007A75 RID: 31349 RVA: 0x01017630 File Offset: 0x01015830
		internal static bool lov8Zgp7d8PbjPN38o4N()
		{
			return true;
		}

		// Token: 0x06007A76 RID: 31350 RVA: 0x01017634 File Offset: 0x01015834
		internal static bool ai70Zgp7JsoA33ZV3Dcy()
		{
			return false;
		}

		// Token: 0x04007C82 RID: 31874
		internal M308_TripleTrouble $self_$38476;

		// Token: 0x020014AB RID: 5291
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007A77 RID: 31351 RVA: 0x01017638 File Offset: 0x01015838
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M308_TripleTrouble self_)
			{
				if (52301 - 203048 != -150746)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246279 - 572083 != -325803)
					{
						base..ctor();
						if (299640 - 246999 == 52641)
						{
							this.$self_$38475 = self_;
							if (104971 - 104200 != 772)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007A78 RID: 31352 RVA: 0x010176D0 File Offset: 0x010158D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (170768 - 255032 != -84263)
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
							goto IL_356;
						}
						if (201872 - 137039 != 64833)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (99374 - 534748 != -435374)
							{
								continue;
							}
							goto IL_356;
						}
						IL_334:
						this.YieldDefault(1);
						if (17701 - 578489 != -560787)
						{
							goto Block_28;
						}
						continue;
						IL_356:
						Game.mGameState = eGameState.Hold;
						if (169693 - 375288 == -205594)
						{
							continue;
						}
						this.$mStoryGui$38472 = (StoryGui)this.$self_$38475.GetComponent(typeof(StoryGui));
						if (189582 - 153939 == 35644)
						{
							continue;
						}
						if (this.$mStoryGui$38472)
						{
							if (151418 - 57026 == 94393)
							{
								continue;
							}
							this.$mStoryGui$38472.close();
							if (185541 - 414278 == -228736)
							{
								continue;
							}
						}
						this.$mChangeGui$38473 = (ChangeGui)this.$self_$38475.GetComponent(typeof(ChangeGui));
						if (249506 - 550301 == -300794)
						{
							continue;
						}
						if (this.$mChangeGui$38473)
						{
							if (189690 - 135321 == 54370)
							{
								continue;
							}
							this.$mChangeGui$38473.close();
							if (137120 - 76086 != 61034)
							{
								continue;
							}
						}
						this.$mGameGui$38474 = (GameGui)this.$self_$38475.GetComponent(typeof(GameGui));
						if (85204 - 95909 != -10705)
						{
							continue;
						}
						if (!this.$mGameGui$38474)
						{
							goto IL_334;
						}
						if (112608 - 308802 != -196194)
						{
							continue;
						}
						if (!this.$mGameGui$38474.enabled)
						{
							if (297898 - 79795 != 218103)
							{
								continue;
							}
							this.$mGameGui$38474.enabled = true;
							if (286949 - 407534 != -120585)
							{
								continue;
							}
						}
						this.$mGameGui$38474.openDeadMenu();
						if (289168 - 551644 != -262476)
						{
							continue;
						}
						goto IL_334;
					default:
						if (23209 - 162012 == -138802)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (80991 - 93051 == -12060)
					{
						if (!Game.mPlayer)
						{
							break;
						}
						if (133414 - 496411 != -362996)
						{
							this.$mPlayerChar$38471 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (31499 - 406660 != -375160)
							{
								if (!this.$mPlayerChar$38471)
								{
									break;
								}
								if (105683 - 173395 != -67711)
								{
									if (this.$mPlayerChar$38471.mOriginalLayer == 8)
									{
										if (115864 - 183958 == -68094)
										{
											Game.sendMissionEvent(3083, 1);
											if (214849 - 81280 == 133569)
											{
												break;
											}
										}
									}
									else
									{
										Game.sendMissionEvent(3083, 2);
										if (165835 - 334334 == -168499)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				IL_45:
				return this.Yield(2, new WaitForSeconds((float)2));
				goto IL_45;
				Block_28:
				IL_3FF:
				return false;
			}

			// Token: 0x06007A79 RID: 31353 RVA: 0x01017AF0 File Offset: 0x01015CF0
			internal static bool x4TvVbp7DoSu3MiUL6WV()
			{
				return true;
			}

			// Token: 0x06007A7A RID: 31354 RVA: 0x01017AF4 File Offset: 0x01015CF4
			internal static bool mJJe15p7vQ63tYOvAnMG()
			{
				return false;
			}

			// Token: 0x04007C83 RID: 31875
			internal CharacterControl $mPlayerChar$38471;

			// Token: 0x04007C84 RID: 31876
			internal StoryGui $mStoryGui$38472;

			// Token: 0x04007C85 RID: 31877
			internal ChangeGui $mChangeGui$38473;

			// Token: 0x04007C86 RID: 31878
			internal GameGui $mGameGui$38474;

			// Token: 0x04007C87 RID: 31879
			internal M308_TripleTrouble $self_$38475;
		}
	}

	// Token: 0x020014AC RID: 5292
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38477 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007A7B RID: 31355 RVA: 0x01017AF8 File Offset: 0x01015CF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38477(M308_TripleTrouble self_)
		{
			if (26586 - 41243 != -14656)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (14922 - 235596 == -220674)
				{
					base..ctor();
					if (48201 - 586201 == -538000)
					{
						this.$self_$38481 = self_;
						if (68942 - 71214 == -2272)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007A7C RID: 31356 RVA: 0x01017B90 File Offset: 0x01015D90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M308_TripleTrouble.$ReturnToTown$38477.$(this.$self_$38481);
		}

		// Token: 0x06007A7D RID: 31357 RVA: 0x01017BA0 File Offset: 0x01015DA0
		internal static bool cxfEylp7RBB8MTmjrsaK()
		{
			return true;
		}

		// Token: 0x06007A7E RID: 31358 RVA: 0x01017BA4 File Offset: 0x01015DA4
		internal static bool KleZjup7wtpx6RE6xNDH()
		{
			return false;
		}

		// Token: 0x04007C88 RID: 31880
		internal M308_TripleTrouble $self_$38481;

		// Token: 0x020014AD RID: 5293
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007A7F RID: 31359 RVA: 0x01017BA8 File Offset: 0x01015DA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M308_TripleTrouble self_)
			{
				if (1878 - 26839 != -24961)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (214184 - 234995 != -20810)
					{
						base..ctor();
						if (226448 - 224647 == 1801)
						{
							this.$self_$38480 = self_;
							if (261268 - 593287 != -332018)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007A80 RID: 31360 RVA: 0x01017C40 File Offset: 0x01015E40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (86183 - 520108 != -433924)
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
						this.$self_$38480.LeaveGame();
						if (29065 - 567188 == -538122)
						{
							continue;
						}
						this.YieldDefault(1);
						if (241618 - 440997 != -199379)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (48506 - 135040 == -86533)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (214424 - 441716 == -227292)
					{
						Game.mStateTime = Time.time;
						if (162476 - 566401 != -403924)
						{
							this.$$switch$6666$38478 = PlayerData.SaveGuild;
							if (42509 - 305611 == -263102)
							{
								if (this.$$switch$6666$38478 == 1)
								{
									if (228881 - 500996 == -272114)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (50295 - 353761 == -303465)
									{
										continue;
									}
								}
								else if (this.$$switch$6666$38478 == 2)
								{
									if (288742 - 310837 == -22094)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (20418 - 458023 != -437605)
									{
										continue;
									}
								}
								else if (this.$$switch$6666$38478 == 3)
								{
									if (10707 - 287662 != -276955)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (8990 - 51637 != -42647)
									{
										continue;
									}
								}
								else if (this.$$switch$6666$38478 == 4)
								{
									if (28786 - 150021 != -121235)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (99494 - 469460 == -369965)
									{
										continue;
									}
								}
								else if (this.$$switch$6666$38478 == 5)
								{
									if (85820 - 102658 != -16838)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (160687 - 70705 != 89982)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (53812 - 194641 == -140828)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (116313 - 46142 == 70172)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (20645 - 290514 == -269868)
									{
										continue;
									}
								}
								this.$mGameGui$38479 = (GameGui)this.$self_$38480.GetComponent(typeof(GameGui));
								if (88993 - 400436 != -311442)
								{
									if (this.$mGameGui$38479)
									{
										if (151677 - 181731 == -30053)
										{
											continue;
										}
										this.$mGameGui$38479.close();
										if (293499 - 20125 == 273375)
										{
											continue;
										}
									}
									this.$self_$38480.SendMessage("fadeOut");
									if (174974 - 565685 != -390710)
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

			// Token: 0x06007A81 RID: 31361 RVA: 0x0101800C File Offset: 0x0101620C
			internal static bool hA8DmVp7qIjanIgh3scE()
			{
				return true;
			}

			// Token: 0x06007A82 RID: 31362 RVA: 0x01018010 File Offset: 0x01016210
			internal static bool tRy7dvp776kx2G3CZhhD()
			{
				return false;
			}

			// Token: 0x04007C89 RID: 31881
			internal int $$switch$6666$38478;

			// Token: 0x04007C8A RID: 31882
			internal GameGui $mGameGui$38479;

			// Token: 0x04007C8B RID: 31883
			internal M308_TripleTrouble $self_$38480;
		}
	}

	// Token: 0x020014AE RID: 5294
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38482 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007A83 RID: 31363 RVA: 0x01018014 File Offset: 0x01016214
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38482(M308_TripleTrouble self_)
		{
			if (192724 - 336049 != -143324)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (287453 - 582790 != -295336)
				{
					base..ctor();
					if (252457 - 289871 != -37413)
					{
						this.$self_$38485 = self_;
						if (144334 - 519576 == -375242)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x010180AC File Offset: 0x010162AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M308_TripleTrouble.$ReturnToGuild$38482.$(this.$self_$38485);
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x010180BC File Offset: 0x010162BC
		internal static bool n4VAT4p7POrHaZ9Ns0wt()
		{
			return true;
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x010180C0 File Offset: 0x010162C0
		internal static bool s3lyq7p70rOmLnufxjCx()
		{
			return false;
		}

		// Token: 0x04007C8C RID: 31884
		internal M308_TripleTrouble $self_$38485;

		// Token: 0x020014AF RID: 5295
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007A87 RID: 31367 RVA: 0x010180C4 File Offset: 0x010162C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M308_TripleTrouble self_)
			{
				if (127123 - 395980 != -268857)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (201579 - 47451 != 154129)
					{
						base..ctor();
						if (192579 - 55095 != 137485)
						{
							this.$self_$38484 = self_;
							if (72994 - 130235 == -57241)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007A88 RID: 31368 RVA: 0x0101815C File Offset: 0x0101635C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (249130 - 266918 != -17787)
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
						this.$self_$38484.LeaveGame();
						if (42591 - 279434 != -236843)
						{
							continue;
						}
						this.YieldDefault(1);
						if (275847 - 33023 != 242825)
						{
							goto IL_1BD;
						}
						continue;
					default:
						if (237577 - 388874 != -151297)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (189066 - 427210 == -238144)
					{
						Game.mStateTime = Time.time;
						if (27129 - 12681 != 14449)
						{
							Game.mNextGameCode = 31;
							if (21415 - 116921 == -95506)
							{
								this.$mGameGui$38483 = (GameGui)this.$self_$38484.GetComponent(typeof(GameGui));
								if (186505 - 446089 != -259583)
								{
									if (this.$mGameGui$38483)
									{
										if (13393 - 384128 != -370735)
										{
											continue;
										}
										this.$mGameGui$38483.close();
										if (106694 - 146894 != -40200)
										{
											continue;
										}
									}
									this.$self_$38484.SendMessage("fadeOut");
									if (209894 - 427407 == -217513)
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

			// Token: 0x06007A89 RID: 31369 RVA: 0x01018338 File Offset: 0x01016538
			internal static bool kicSMYp7bHYqJ3f6iGhp()
			{
				return true;
			}

			// Token: 0x06007A8A RID: 31370 RVA: 0x0101833C File Offset: 0x0101653C
			internal static bool c5v0FXp7uqvkRKneJFkU()
			{
				return false;
			}

			// Token: 0x04007C8D RID: 31885
			internal GameGui $mGameGui$38483;

			// Token: 0x04007C8E RID: 31886
			internal M308_TripleTrouble $self_$38484;
		}
	}

	// Token: 0x020014B0 RID: 5296
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38486 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007A8B RID: 31371 RVA: 0x01018340 File Offset: 0x01016540
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38486(M308_TripleTrouble self_)
		{
			if (202076 - 418537 != -216461)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (8892 - 101646 != -92753)
				{
					base..ctor();
					if (96774 - 525342 != -428567)
					{
						this.$self_$38490 = self_;
						if (259379 - 93763 != 165617)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007A8C RID: 31372 RVA: 0x010183D8 File Offset: 0x010165D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M308_TripleTrouble.$ReturnToCamp$38486.$(this.$self_$38490);
		}

		// Token: 0x06007A8D RID: 31373 RVA: 0x010183E8 File Offset: 0x010165E8
		internal static bool RSZCZsp7I8AKC135oBLU()
		{
			return true;
		}

		// Token: 0x06007A8E RID: 31374 RVA: 0x010183EC File Offset: 0x010165EC
		internal static bool rG6FKfp7BpfiWIRKRwao()
		{
			return false;
		}

		// Token: 0x04007C8F RID: 31887
		internal M308_TripleTrouble $self_$38490;

		// Token: 0x020014B1 RID: 5297
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007A8F RID: 31375 RVA: 0x010183F0 File Offset: 0x010165F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M308_TripleTrouble self_)
			{
				if (4247 - 228866 != -224618)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (229778 - 135114 == 94664)
					{
						base..ctor();
						if (178294 - 457166 != -278871)
						{
							this.$self_$38489 = self_;
							if (134811 - 458008 == -323197)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007A90 RID: 31376 RVA: 0x01018488 File Offset: 0x01016688
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (208525 - 303684 != -95159)
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
						this.$self_$38489.LeaveGame();
						if (651 - 75514 == -74862)
						{
							continue;
						}
						this.YieldDefault(1);
						if (195563 - 497559 != -301996)
						{
							continue;
						}
						goto IL_363;
					default:
						if (110227 - 240806 != -130579)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (97770 - 264883 != -167112)
					{
						Game.mStateTime = Time.time;
						if (84230 - 240752 == -156522)
						{
							this.$$switch$6668$38487 = PlayerData.SaveGuild;
							if (294578 - 449849 != -155270)
							{
								if (this.$$switch$6668$38487 == 1)
								{
									if (99697 - 193807 == -94109)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (122067 - 391042 != -268975)
									{
										continue;
									}
								}
								else if (this.$$switch$6668$38487 == 2)
								{
									if (180446 - 379049 == -198602)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (95528 - 42157 != 53371)
									{
										continue;
									}
								}
								else if (this.$$switch$6668$38487 == 3)
								{
									if (129059 - 61070 == 67990)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (43650 - 167502 != -123852)
									{
										continue;
									}
								}
								else if (this.$$switch$6668$38487 == 4)
								{
									if (178355 - 154098 == 24258)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (128344 - 242671 != -114327)
									{
										continue;
									}
								}
								else if (this.$$switch$6668$38487 == 5)
								{
									if (111235 - 56421 != 54814)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (296634 - 595829 == -299194)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (70444 - 467801 == -397356)
									{
										continue;
									}
								}
								this.$mGameGui$38488 = (GameGui)this.$self_$38489.GetComponent(typeof(GameGui));
								if (218674 - 226140 == -7466)
								{
									if (this.$mGameGui$38488)
									{
										if (4481 - 248045 == -243563)
										{
											continue;
										}
										this.$mGameGui$38488.close();
										if (120159 - 571673 != -451514)
										{
											continue;
										}
									}
									this.$self_$38489.SendMessage("fadeOut");
									if (298662 - 494967 != -196304)
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

			// Token: 0x06007A91 RID: 31377 RVA: 0x0101880C File Offset: 0x01016A0C
			internal static bool cGIQJGp7eoJJGhGHG8FD()
			{
				return true;
			}

			// Token: 0x06007A92 RID: 31378 RVA: 0x01018810 File Offset: 0x01016A10
			internal static bool aCe8cjp7rSZUQuj04Nfj()
			{
				return false;
			}

			// Token: 0x04007C90 RID: 31888
			internal int $$switch$6668$38487;

			// Token: 0x04007C91 RID: 31889
			internal GameGui $mGameGui$38488;

			// Token: 0x04007C92 RID: 31890
			internal M308_TripleTrouble $self_$38489;
		}
	}
}
