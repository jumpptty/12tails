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

// Token: 0x020018D4 RID: 6356
[Serializable]
public class M908_SurprisedAssault : MonoBehaviour
{
	// Token: 0x060093DD RID: 37853 RVA: 0x011A66C4 File Offset: 0x011A48C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M908_SurprisedAssault()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060093DE RID: 37854 RVA: 0x011A66D4 File Offset: 0x011A48D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (215522 - 154606 != 60916)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (222369 - 166218 == 56151)
			{
				Game.mGameType = 5;
				if (144137 - 480521 == -336384)
				{
					if (Chat.Initialized)
					{
						if (118874 - 534759 == -415885)
						{
							Chat.ChatDisplay.Clear();
							if (138102 - 343933 != -205830)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (288697 - 163436 != 125262)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060093DF RID: 37855 RVA: 0x011A67B8 File Offset: 0x011A49B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (33062 - 88593 != -55530)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (161451 - 77750 != 83702)
				{
					Game.nextGame();
					if (50416 - 334290 != -283873)
					{
						Game.mGameCode = 908;
						if (226527 - 468299 == -241772)
						{
							Game.mGameType = 5;
							if (76159 - 557371 != -481211)
							{
								Game.mGameTime = Time.time;
								if (11748 - 383549 != -371800)
								{
									Game.mGameScore = 0;
									if (15857 - 121938 != -106080)
									{
										Game.mGameMana = 0;
										if (282936 - 443961 == -161025)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (216306 - 476121 == -259815)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (21102 - 32210 != -11107)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (233696 - 515051 == -281355)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (138268 - 554856 != -416587)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (168922 - 33219 != 135704)
															{
																this.dXunciaYZU0 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (152986 - 143439 != 9548)
																{
																	this.x2snc8IP1Yu = PhotonClient.Connection;
																	if (287853 - 49314 != 238540)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (9321 - 542484 == -533163)
																		{
																			this.InitGame();
																			if (211384 - 39954 == 171430)
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
				if (156832 - 141175 != 15658)
				{
					Game.mGameType = 99;
					if (128964 - 168901 != -39936)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060093E0 RID: 37856 RVA: 0x011A6A98 File Offset: 0x011A4C98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (159784 - 230726 != -70941)
		{
		}
		for (;;)
		{
			if (this.x2snc8IP1Yu == null)
			{
				if (288974 - 418521 != -129546)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (159532 - 463100 != -303567)
				{
					if (mGameState == eGameState.Init)
					{
						if (249784 - 183477 == 66307)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (216084 - 218841 != -2756)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (253792 - 159373 != 94420)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (184217 - 471921 == -287704)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (247835 - 509140 != -261304)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (142262 - 184473 == -42211)
						{
							if (Time.time > this.DCXncDnxFQB)
							{
								if (76025 - 50591 == 25435)
								{
									continue;
								}
								Game.mGameMana++;
								if (7945 - 165429 != -157484)
								{
									continue;
								}
								this.DCXncDnxFQB = Time.time + (float)12;
								if (254997 - 532872 != -277875)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (278164 - 591753 == -313588)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (73164 - 80281 != -7117)
									{
										continue;
									}
									this.audio.Play();
									if (62701 - 270389 == -207687)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (236972 - 574507 != -337534)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (144763 - 28066 != 116698)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (187774 - 535094 != -347319)
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
						if (157699 - 585254 != -427554)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060093E1 RID: 37857 RVA: 0x011A6D98 File Offset: 0x011A4F98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (279800 - 474377 != -194577)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (80470 - 412706 == -332236)
			{
				float num = (float)1;
				if (219938 - 393522 != -173583)
				{
					float num2 = (float)(1024 * Screen.width / Screen.height);
					if (273384 - 77469 == 195915)
					{
						GUI.depth = 1;
						if (7760 - 383257 == -375497)
						{
							eGameState mGameState = Game.mGameState;
							if (161403 - 272801 == -111398)
							{
								if (mGameState == eGameState.Start)
								{
									if (215245 - 541877 != -326632)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)1)
									{
										if (235135 - 55772 != 179363)
										{
											continue;
										}
										break;
									}
									else if (Time.time - Game.mStateTime < (float)2)
									{
										if (12473 - 567975 == -555501)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)1);
										if (288476 - 512556 != -224080)
										{
											continue;
										}
										float a = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)1);
										if (241139 - 259479 != -18340)
										{
											continue;
										}
										Color color = GUI.color;
										if (187127 - 295180 == -108052)
										{
											continue;
										}
										color.a = a;
										if (87026 - 375591 != -288565)
										{
											continue;
										}
										if (14050 - 214663 == -200612)
										{
											continue;
										}
										Color color2 = GUI.color = color;
										if (163256 - 250935 != -87679)
										{
											continue;
										}
										if (13041 - 598518 != -585477)
										{
											continue;
										}
										if (this.Ri9ncjR0Uyw)
										{
											if (191310 - 410046 == -218735)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.Ri9ncjR0Uyw);
											if (124173 - 485642 != -361469)
											{
												continue;
											}
										}
									}
									else if (Time.time - Game.mStateTime < (float)3)
									{
										if (20759 - 470278 != -449519)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)2);
										if (250865 - 266033 != -15168)
										{
											continue;
										}
										float a2 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)2);
										if (13196 - 184626 != -171430)
										{
											continue;
										}
										Color color3 = GUI.color;
										if (52054 - 112712 == -60657)
										{
											continue;
										}
										color3.a = a2;
										if (262684 - 340357 == -77672 || 290911 - 212247 == 78665)
										{
											continue;
										}
										Color color4 = GUI.color = color3;
										if (71798 - 114747 == -42948 || 193458 - 443236 == -249777)
										{
											continue;
										}
										if (this.E7fncoV9aFY)
										{
											if (108642 - 197788 == -89145)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.E7fncoV9aFY);
											if (216729 - 187277 == 29453)
											{
												continue;
											}
										}
									}
									else if (Time.time - Game.mStateTime < (float)4)
									{
										if (263190 - 491858 == -228667)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)3);
										if (30627 - 179451 != -148824)
										{
											continue;
										}
										float a3 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)3);
										if (222885 - 417483 == -194597)
										{
											continue;
										}
										Color color5 = GUI.color;
										if (242841 - 525694 == -282852)
										{
											continue;
										}
										float num3 = color5.a = a3;
										if (44211 - 75556 == -31344)
										{
											continue;
										}
										if (264811 - 48638 != 216173)
										{
											continue;
										}
										Color color6 = GUI.color = color5;
										if (279924 - 465081 != -185157)
										{
											continue;
										}
										if (1651 - 67299 != -65648)
										{
											continue;
										}
										if (this.BPlnckah8yN)
										{
											if (113901 - 89283 != 24618)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.BPlnckah8yN);
											if (222123 - 181701 != 40422)
											{
												continue;
											}
										}
									}
								}
								else if (mGameState == eGameState.Normal)
								{
									if (64230 - 505151 != -440921)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)2)
									{
										if (239544 - 302382 != -62838)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
										if (212183 - 115697 == 96487)
										{
											continue;
										}
										float a4 = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
										if (73949 - 27512 != 46437)
										{
											continue;
										}
										Color color7 = GUI.color;
										if (259041 - 115718 != 143323)
										{
											continue;
										}
										float num4 = color7.a = a4;
										if (88847 - 567904 != -479057)
										{
											continue;
										}
										if (248849 - 59910 == 188940)
										{
											continue;
										}
										Color color8 = GUI.color = color7;
										if (62460 - 115385 != -52925)
										{
											continue;
										}
										if (116504 - 119923 == -3418)
										{
											continue;
										}
										if (this.LaGncmEkokR)
										{
											if (228712 - 575413 != -346701)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.LaGncmEkokR);
											if (142718 - 553670 != -410952)
											{
												continue;
											}
										}
									}
								}
								float a5 = 1f;
								if (215969 - 323756 != -107786)
								{
									Color color9 = GUI.color;
									if (20215 - 570993 == -550778)
									{
										color9.a = a5;
										if (10747 - 57638 != -46890 && 51195 - 291864 != -240668)
										{
											Color color10 = GUI.color = color9;
											if (234918 - 369590 == -134672)
											{
												if (103077 - 100642 == 2435)
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

	// Token: 0x060093E2 RID: 37858 RVA: 0x011A76D4 File Offset: 0x011A58D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (78771 - 594629 != -515858)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (92243 - 419455 == -327212)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (43135 - 517357 == -474222)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (267260 - 435901 == -168641)
					{
						int uid = RuntimeServices.UnboxInt32(data[43]);
						if (164857 - 55144 == 109713)
						{
							int num3 = num;
							if (78767 - 383571 != -304803)
							{
								if (num3 == 9081)
								{
									if (169387 - 236950 == -67563)
									{
										Chat.SubmitChat("none", Game.getPlayerName(uid) + " has joined team" + num2, eChatType.system, eChatMode.system);
										if (358 - 473239 == -472881)
										{
											break;
										}
									}
								}
								else
								{
									if (num3 != 9082)
									{
										break;
									}
									if (184763 - 560175 != -375411)
									{
										if (num2 == 1)
										{
											if (76975 - 328633 != -251657)
											{
												this.Afnnc9arDYv++;
												if (94798 - 254184 != -159385)
												{
													this.SendMessage("newGameMessage", "Team2 Score!: " + this.j7vncAADfqp + "/" + this.Afnnc9arDYv);
													if (135996 - 29118 != 106879)
													{
														Chat.SubmitChat("none", "Team2 Score!: " + this.j7vncAADfqp + "/" + this.Afnnc9arDYv, eChatType.system, eChatMode.system);
														if (164296 - 373666 == -209370)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.j7vncAADfqp++;
											if (213981 - 381930 == -167949)
											{
												this.SendMessage("newGameMessage", "Team1 Score!: " + this.j7vncAADfqp + "/" + this.Afnnc9arDYv);
												if (205966 - 488398 != -282431)
												{
													Chat.SubmitChat("none", "Team1 Score!: " + this.j7vncAADfqp + "/" + this.Afnnc9arDYv, eChatType.system, eChatMode.system);
													if (153840 - 81550 == 72290)
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

	// Token: 0x060093E3 RID: 37859 RVA: 0x011A7A3C File Offset: 0x011A5C3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseShadowMirror(int mVar)
	{
		return new M908_SurprisedAssault.$UseShadowMirror$41833(mVar, this).GetEnumerator();
	}

	// Token: 0x060093E4 RID: 37860 RVA: 0x011A7A4C File Offset: 0x011A5C4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (140782 - 531125 != -390342)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (146342 - 54010 == 92332)
			{
				Hashtable customOpParameters = new Hashtable();
				if (254547 - 407465 != -152917)
				{
					this.x2snc8IP1Yu.OpCustom(52, customOpParameters, true);
					if (35751 - 264578 == -228827)
					{
						this.LaGncmEkokR = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
						if (17743 - 72869 != -55125)
						{
							this.Ri9ncjR0Uyw = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
							if (177344 - 433239 != -255894)
							{
								this.E7fncoV9aFY = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
								if (235988 - 569995 != -334006)
								{
									this.BPlnckah8yN = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
									if (17822 - 462601 == -444779)
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

	// Token: 0x060093E5 RID: 37861 RVA: 0x011A7BD8 File Offset: 0x011A5DD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (129970 - 427662 != -297691)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (285992 - 523278 == -237286)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (113309 - 573738 == -460429)
				{
					Game.mGameState = eGameState.Setup;
					if (254707 - 147528 != 107180)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060093E6 RID: 37862 RVA: 0x011A7C7C File Offset: 0x011A5E7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (213647 - 411261 != -197613)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (105946 - 343281 == -237335)
			{
				if (num == PlayerData.UID)
				{
					if (239146 - 497464 == -258318)
					{
						this.SetupActors();
						if (124075 - 127301 == -3226)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (99035 - 134770 == -35735)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060093E7 RID: 37863 RVA: 0x011A7D4C File Offset: 0x011A5F4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (252371 - 478477 != -226106)
		{
		}
		for (;;)
		{
			IL_1A:
			Debug.Log("Creating Actors");
			if (273842 - 538866 == -265024)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (130225 - 544276 != -414050)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (4125 - 254798 != -250672)
						{
							int i = 0;
							if (184862 - 427901 != -243038)
							{
								CharacterControl[] array2 = array;
								if (296308 - 372087 != -75778)
								{
									int length = array2.Length;
									if (188163 - 337645 == -149482)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (73408 - 56920 == 16489)
											{
												goto IL_1A;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (218657 - 391991 != -173334)
											{
												goto IL_1A;
											}
											this.Tk9ncusC5OT++;
											if (241256 - 460154 != -218898)
											{
												goto IL_1A;
											}
											i++;
											if (95748 - 242215 != -146467)
											{
												goto IL_1A;
											}
										}
										if (220194 - 185949 != 34246)
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
						if (299416 - 275375 == 24041)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060093E8 RID: 37864 RVA: 0x011A7F64 File Offset: 0x011A6164
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (285543 - 505984 != -220441)
		{
		}
		for (;;)
		{
			IL_5A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (45280 - 361253 == -315973)
			{
				int i = 0;
				if (282943 - 475849 != -192905)
				{
					CharacterControl[] array2 = array;
					if (225588 - 379105 != -153516)
					{
						int length = array2.Length;
						if (286926 - 113326 != 173601)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (156415 - 413754 != -257339)
								{
									goto IL_5A;
								}
								i++;
								if (254212 - 352855 == -98642)
								{
									goto IL_5A;
								}
							}
							if (79636 - 580059 != -500422)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060093E9 RID: 37865 RVA: 0x011A8094 File Offset: 0x011A6294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (8385 - 233131 != -224745)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (260204 - 542060 == -281856)
			{
				hashtable.Add(43, PlayerData.UID);
				if (217878 - 123178 != 94701)
				{
					hashtable.Add(73, nType);
					if (53333 - 573857 == -520524)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (269891 - 515939 == -246048)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (206150 - 142981 == 63169)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (75035 - 441736 == -366701)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (259122 - 384074 == -124952)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (221278 - 339177 == -117899)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (244732 - 575672 == -330940)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (283027 - 351126 == -68099)
												{
													this.x2snc8IP1Yu.OpCustom(63, hashtable, true);
													if (289193 - 87767 == 201426)
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

	// Token: 0x060093EA RID: 37866 RVA: 0x011A834C File Offset: 0x011A654C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (26159 - 302627 != -276468)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (280346 - 255070 == 25276)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (271403 - 519537 != -248133)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (87218 - 238278 != -151059)
						{
							if (this.Tk9ncusC5OT <= 0)
							{
								break;
							}
							if (3390 - 75299 == -71909)
							{
								this.Tk9ncusC5OT--;
								if (282797 - 502986 != -220188)
								{
									if (this.Tk9ncusC5OT != 0)
									{
										break;
									}
									if (191208 - 517766 == -326558)
									{
										Game.setGameState(eGameState.Ready);
										if (51800 - 520832 == -469032)
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
						if (168939 - 81045 != 87895)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (252183 - 28326 != 223858)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060093EB RID: 37867 RVA: 0x011A84DC File Offset: 0x011A66DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (43053 - 298287 != -255234)
		{
		}
		while (Game.mGameState < eGameState.Ready)
		{
			if (72182 - 565755 != -493572)
			{
				Debug.Log("Game Ready");
				if (129364 - 353964 == -224600)
				{
					Game.mGameState = eGameState.Ready;
					if (145839 - 118480 != 27360)
					{
						int playerSlot = Game.getPlayerSlot(PlayerData.UID);
						if (162412 - 258076 == -95664)
						{
							if (267803 - 493458 != -225654)
							{
								GameObject gameObject = null;
								if (222863 - 259486 != -36622)
								{
									if (playerSlot <= 1)
									{
										goto IL_A4;
									}
									if (30173 - 481418 != -451245)
									{
										continue;
									}
									if (playerSlot > 10)
									{
										goto IL_A4;
									}
									if (156028 - 239485 == -83456)
									{
										continue;
									}
									GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
									if (192867 - 18267 != 174600)
									{
										continue;
									}
									gameObject = GameObject.Find("StartCamera" + playerSlot);
									if (2696 - 12230 == -9533)
									{
										continue;
									}
									IL_212:
									if (gameObject2)
									{
										if (259305 - 272762 == -13456)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, (playerSlot - 1) % 2 + 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (193831 - 169872 != 23959)
										{
											continue;
										}
									}
									if (gameObject)
									{
										if (63081 - 396912 == -333830)
										{
											continue;
										}
										this.transform.position = gameObject.transform.position;
										if (175099 - 7629 == 167471)
										{
											continue;
										}
										this.transform.rotation = gameObject.transform.rotation;
										if (247806 - 71957 == 175850)
										{
											continue;
										}
									}
									if ((playerSlot - 1) % 2 + 1 == 1)
									{
										if (208567 - 494892 == -286324)
										{
											continue;
										}
										Game.sendMissionEvent(9081, 1);
										if (29540 - 283227 != -253686)
										{
											break;
										}
										continue;
									}
									else
									{
										Game.sendMissionEvent(9081, 2);
										if (253922 - 246042 != 7880)
										{
											continue;
										}
										break;
									}
									IL_A4:
									gameObject2 = GameObject.Find("StartPoint1");
									if (159540 - 531780 != -372239)
									{
										goto IL_212;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060093EC RID: 37868 RVA: 0x011A8810 File Offset: 0x011A6A10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M908_SurprisedAssault.$StartGame$41846(this).GetEnumerator();
	}

	// Token: 0x060093ED RID: 37869 RVA: 0x011A8820 File Offset: 0x011A6A20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060093EE RID: 37870 RVA: 0x011A8824 File Offset: 0x011A6A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (80908 - 158633 != -77725)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (173162 - 305996 != -132833)
			{
				hashtable.Add(71, CID);
				if (243154 - 158714 == 84440)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (109243 - 290896 == -181653)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (7639 - 371891 == -364252)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (61589 - 51543 != 10047)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (156382 - 464040 == -307658)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (69337 - 105272 != -35934)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (63893 - 198728 != -134834)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (22687 - 21480 != 1208)
											{
												this.x2snc8IP1Yu.OpCustom(61, hashtable, true);
												if (207235 - 156286 != 50950)
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

	// Token: 0x060093EF RID: 37871 RVA: 0x011A8AB0 File Offset: 0x011A6CB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (220177 - 561337 != -341160)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (299173 - 205614 == 93559)
			{
				if (!gameObject)
				{
					break;
				}
				if (165361 - 109479 == 55882)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (35581 - 184329 == -148748)
					{
						playerCameraControl.target = gameObject;
						if (108011 - 389010 == -280999)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (9319 - 18411 == -9092)
								{
									this.StartCoroutine_Auto(this.StartGame());
									if (268662 - 295263 != -26600)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (80560 - 413956 == -333396)
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

	// Token: 0x060093F0 RID: 37872 RVA: 0x011A8BF0 File Offset: 0x011A6DF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (221584 - 119565 != 102020)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (841 - 45169 == -44328)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (133913 - 481165 != -347251)
				{
					gameGui.ResetTeamBar();
					if (3758 - 220650 == -216892)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060093F1 RID: 37873 RVA: 0x011A8C9C File Offset: 0x011A6E9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x060093F2 RID: 37874 RVA: 0x011A8CA0 File Offset: 0x011A6EA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x060093F3 RID: 37875 RVA: 0x011A8CA4 File Offset: 0x011A6EA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M908_SurprisedAssault.$onGameComplete$41850(data, this).GetEnumerator();
	}

	// Token: 0x060093F4 RID: 37876 RVA: 0x011A8CB4 File Offset: 0x011A6EB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M908_SurprisedAssault.$onDeadPlayer$41858(this).GetEnumerator();
	}

	// Token: 0x060093F5 RID: 37877 RVA: 0x011A8CC4 File Offset: 0x011A6EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RespawnPlayer(int nCID)
	{
		return new M908_SurprisedAssault.$RespawnPlayer$41865(nCID, this).GetEnumerator();
	}

	// Token: 0x060093F6 RID: 37878 RVA: 0x011A8CD4 File Offset: 0x011A6ED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M908_SurprisedAssault.$onChangePlayer$41877(data, this).GetEnumerator();
	}

	// Token: 0x060093F7 RID: 37879 RVA: 0x011A8CE4 File Offset: 0x011A6EE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (209221 - 431818 != -222597)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (175471 - 262452 == -86981)
			{
				if (Game.mPlayer)
				{
					if (180532 - 554461 == -373928)
					{
						continue;
					}
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (211566 - 151176 == 60391)
					{
						continue;
					}
				}
				PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
				if (104699 - 393388 != -288688)
				{
					playerCameraControl.target = Game.mPlayer;
					if (11828 - 346807 == -334979)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (118672 - 489197 != -370525)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (184946 - 512018 != -327072)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (202634 - 377104 == -174470)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (106444 - 393647 == -287203)
							{
								if (!gameGui)
								{
									break;
								}
								if (161090 - 287121 != -126030)
								{
									gameGui.enabled = true;
									if (86368 - 277738 != -191369)
									{
										gameGui.closeDeadMenu();
										if (72670 - 552794 != -480123)
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

	// Token: 0x060093F8 RID: 37880 RVA: 0x011A8EF4 File Offset: 0x011A70F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (10185 - 549447 != -539262)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (124656 - 553055 != -428398)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (126911 - 589169 != -462257)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (56998 - 147328 == -90330)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060093F9 RID: 37881 RVA: 0x011A8FB8 File Offset: 0x011A71B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (47320 - 355461 != -308140)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
			{
				if (186126 - 441000 != -254873)
				{
					Game.mGameState = eGameState.Ended;
					if (174226 - 349579 != -175352)
					{
						break;
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.AllHold;
				if (258351 - 101609 != 156743)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060093FA RID: 37882 RVA: 0x011A9070 File Offset: 0x011A7270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M908_SurprisedAssault.$ReturnToTown$41884(this).GetEnumerator();
	}

	// Token: 0x060093FB RID: 37883 RVA: 0x011A9080 File Offset: 0x011A7280
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M908_SurprisedAssault.$ReturnToGuild$41889(this).GetEnumerator();
	}

	// Token: 0x060093FC RID: 37884 RVA: 0x011A9090 File Offset: 0x011A7290
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M908_SurprisedAssault.$ReturnToCamp$41893(this).GetEnumerator();
	}

	// Token: 0x060093FD RID: 37885 RVA: 0x011A90A0 File Offset: 0x011A72A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (154865 - 16059 != 138807)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (250290 - 239165 != 11126)
			{
				Hashtable hashtable = new Hashtable();
				if (147587 - 35212 == 112375)
				{
					hashtable.Add(43, PlayerData.UID);
					if (60991 - 450465 != -389473)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (36143 - 274243 == -238100)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060093FE RID: 37886 RVA: 0x011A9178 File Offset: 0x011A7378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060093FF RID: 37887 RVA: 0x011A918C File Offset: 0x011A738C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (154449 - 525952 != -371503)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (148712 - 380778 == -232066)
			{
				Hashtable hashtable = new Hashtable();
				if (251780 - 368780 != -116999)
				{
					if (Game.mNextGameCode == 30)
					{
						if (235043 - 478849 != -243806)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (140018 - 111930 != 28088)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (276063 - 154215 != 121848)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (151803 - 592670 == -440866)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (69515 - 575125 != -505610)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (33708 - 395945 != -362237)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (195694 - 393195 == -197500)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (6893 - 194240 == -187346)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (42317 - 110993 != -68676)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (286709 - 119484 == 167226)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (103342 - 543791 != -440449)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (135682 - 190077 == -54394)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (10747 - 136999 != -126252)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (176674 - 450359 != -273685)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (216106 - 130223 == 85884)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (25684 - 538579 != -512895)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (51030 - 244823 != -193793)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (121676 - 45727 != 75949)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (229987 - 16799 != 213188)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (244640 - 56397 == 188244)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (117928 - 379197 == -261268)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (10529 - 230551 == -220021)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (42954 - 484032 != -441078)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (62708 - 103472 == -40763)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (103414 - 290495 != -187081)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (260611 - 299739 == -39127)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (287262 - 114619 != 172643)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (269300 - 65296 == 204005)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (8282 - 335654 != -327371)
					{
						this.x2snc8IP1Yu.OpCustom(42, hashtable, true);
						if (296114 - 267171 != 28944)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009400 RID: 37888 RVA: 0x011A9740 File Offset: 0x011A7940
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009401 RID: 37889 RVA: 0x011A9750 File Offset: 0x011A7950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009402 RID: 37890 RVA: 0x011A9754 File Offset: 0x011A7954
	internal static bool RgRmoOVy5vJlgORotImv()
	{
		return true;
	}

	// Token: 0x06009403 RID: 37891 RVA: 0x011A9758 File Offset: 0x011A7958
	internal static bool HPyNqFVypjl1cWrEYEQa()
	{
		return false;
	}

	// Token: 0x04008AE4 RID: 35556
	private LitePeer x2snc8IP1Yu;

	// Token: 0x04008AE5 RID: 35557
	private PlayerCameraControl dXunciaYZU0;

	// Token: 0x04008AE6 RID: 35558
	private float DCXncDnxFQB;

	// Token: 0x04008AE7 RID: 35559
	private Texture LaGncmEkokR;

	// Token: 0x04008AE8 RID: 35560
	private Texture Ri9ncjR0Uyw;

	// Token: 0x04008AE9 RID: 35561
	private Texture E7fncoV9aFY;

	// Token: 0x04008AEA RID: 35562
	private Texture BPlnckah8yN;

	// Token: 0x04008AEB RID: 35563
	private int tZrncFTis0n;

	// Token: 0x04008AEC RID: 35564
	private int j7vncAADfqp;

	// Token: 0x04008AED RID: 35565
	private int Afnnc9arDYv;

	// Token: 0x04008AEE RID: 35566
	public AudioClip shadowMirrorFx;

	// Token: 0x04008AEF RID: 35567
	private float Bn7ncWKUvHE;

	// Token: 0x04008AF0 RID: 35568
	private int Tk9ncusC5OT;

	// Token: 0x020018D5 RID: 6357
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseShadowMirror$41833 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009404 RID: 37892 RVA: 0x011A975C File Offset: 0x011A795C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseShadowMirror$41833(int mVar, M908_SurprisedAssault self_)
		{
			if (119543 - 329351 != -209807)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (35446 - 255159 == -219713)
				{
					base..ctor();
					if (151660 - 234472 == -82812)
					{
						this.$mVar$41844 = mVar;
						if (215598 - 232120 == -16522)
						{
							this.$self_$41845 = self_;
							if (220718 - 513534 != -292815)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009405 RID: 37893 RVA: 0x011A9818 File Offset: 0x011A7A18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M908_SurprisedAssault.$UseShadowMirror$41833.$(this.$mVar$41844, this.$self_$41845);
		}

		// Token: 0x06009406 RID: 37894 RVA: 0x011A982C File Offset: 0x011A7A2C
		internal static bool I6Duc1VyVmiME9qqT0ik()
		{
			return true;
		}

		// Token: 0x06009407 RID: 37895 RVA: 0x011A9830 File Offset: 0x011A7A30
		internal static bool XyVJuEVytodwjBaxCPPI()
		{
			return false;
		}

		// Token: 0x04008AF1 RID: 35569
		internal int $mVar$41844;

		// Token: 0x04008AF2 RID: 35570
		internal M908_SurprisedAssault $self_$41845;

		// Token: 0x020018D6 RID: 6358
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009408 RID: 37896 RVA: 0x011A9834 File Offset: 0x011A7A34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int mVar, M908_SurprisedAssault self_)
			{
				if (50798 - 497290 != -446491)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (4519 - 529510 == -524991)
					{
						base..ctor();
						if (179496 - 152360 != 27137)
						{
							this.$mVar$41842 = mVar;
							if (7301 - 456491 == -449190)
							{
								this.$self_$41843 = self_;
								if (140965 - 391334 == -250369)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009409 RID: 37897 RVA: 0x011A98F0 File Offset: 0x011A7AF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (226639 - 264935 != -38295)
				{
				}
				for (;;)
				{
					IL_3C8:
					switch (this._state)
					{
					case 0:
						goto IL_422;
					case 1:
						goto IL_8A2;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (190642 - 205474 != -14832)
							{
								continue;
							}
							goto IL_394;
						}
						else
						{
							if (this.$self_$41843.shadowMirrorFx)
							{
								if (32036 - 481883 != -449847)
								{
									continue;
								}
								this.$self_$41843.audio.PlayOneShot(this.$self_$41843.shadowMirrorFx);
								if (79113 - 549728 != -470615)
								{
									continue;
								}
							}
							this.$mCameraEffect$41836 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
							if (118972 - 119682 != -710)
							{
								continue;
							}
							if (this.$mCameraEffect$41836)
							{
								if (132045 - 139057 != -7012)
								{
									continue;
								}
								this.$mCameraEffect$41836.AddColorRamp("shadowRamp", "none", (float)10, new Vector4((float)0, (float)0, 0.1f, 0.1f));
								if (173420 - 328742 != -155322)
								{
									continue;
								}
							}
							this.$warpList$41837 = Damage.FindAreaTarget(Game.mPlayer.transform.position, (float)40, (float)12, 1 << Game.mPlayer.layer);
							if (68337 - 175760 == -107422)
							{
								continue;
							}
							this.$$iterator$10962$41841 = UnityRuntimeServices.GetEnumerator(this.$warpList$41837);
							if (47814 - 354218 != -306404)
							{
								continue;
							}
							while (this.$$iterator$10962$41841.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10962$41841.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$warpObject$41838 = (GameObject)obj2;
								if (137789 - 122258 == 15532)
								{
									goto IL_3C8;
								}
								this.$warpChar$41839 = (CharacterControl)this.$warpObject$41838.GetComponent(typeof(CharacterControl));
								if (206247 - 296732 != -90485)
								{
									goto IL_3C8;
								}
								UnityRuntimeServices.Update(this.$$iterator$10962$41841, this.$warpObject$41838);
								if (84650 - 69326 == 15325)
								{
									goto IL_3C8;
								}
								if (!(this.$warpObject$41838 == Game.mPlayer))
								{
									if (298971 - 202603 != 96368)
									{
										goto IL_3C8;
									}
									if (!this.$warpChar$41839.isMine)
									{
										continue;
									}
									if (7957 - 9027 != -1070)
									{
										goto IL_3C8;
									}
									if (!this.$warpChar$41839.isSummon)
									{
										continue;
									}
									if (93035 - 65270 != 27765)
									{
										goto IL_3C8;
									}
									if (!(this.$warpChar$41839.mSummoner == Game.mPlayer))
									{
										continue;
									}
									if (39797 - 266574 != -226777)
									{
										goto IL_3C8;
									}
									if (!this.$warpChar$41839.recieveMovement)
									{
										continue;
									}
									if (224883 - 115099 != 109784)
									{
										goto IL_3C8;
									}
								}
								this.$mWarpPos$41840 = global::Math.getRandomSpawnPos(this.$mWarpPoint$41835.transform.position, 2);
								if (287393 - 299191 != -11798)
								{
									goto IL_3C8;
								}
								if (this.$mWarpPos$41840 == Vector3.zero)
								{
									if (28592 - 65871 != -37279)
									{
										goto IL_3C8;
									}
									this.$mWarpPos$41840 = this.$mWarpPoint$41835.transform.position;
									if (219178 - 344117 == -124938)
									{
										goto IL_3C8;
									}
								}
								this.$warpObject$41838.transform.position = this.$mWarpPos$41840;
								if (118352 - 372648 == -254295)
								{
									goto IL_3C8;
								}
								UnityRuntimeServices.Update(this.$$iterator$10962$41841, this.$warpObject$41838);
								if (279710 - 297644 != -17934)
								{
									goto IL_3C8;
								}
								this.$warpObject$41838.transform.rotation = Quaternion.LookRotation(this.$mWarpPoint$41835.transform.forward);
								if (270206 - 274605 == -4398)
								{
									goto IL_3C8;
								}
								UnityRuntimeServices.Update(this.$$iterator$10962$41841, this.$warpObject$41838);
								if (92095 - 125495 != -33400)
								{
									goto IL_3C8;
								}
								if (this.$warpChar$41839)
								{
									if (236554 - 118706 == 117849)
									{
										goto IL_3C8;
									}
									this.$warpChar$41839.PositionEvent();
									if (131378 - 209879 == -78500)
									{
										goto IL_3C8;
									}
								}
							}
							if (152069 - 40743 != 111327)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (175135 - 122131 != 53005)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (57207 - 144447 == -87239)
							{
								continue;
							}
						}
						break;
					default:
						if (216261 - 172196 != 44065)
						{
							continue;
						}
						goto IL_422;
					}
					IL_1A:
					this.$self_$41843.Bn7ncWKUvHE = Time.time + 0.5f;
					if (218975 - 234572 == -15596)
					{
						continue;
					}
					IL_4A:
					this.YieldDefault(1);
					if (143723 - 75540 != 68184)
					{
						break;
					}
					continue;
					IL_422:
					if (Game.mGameState != eGameState.Normal)
					{
						if (9759 - 540915 != -531155)
						{
							break;
						}
					}
					else if (!Game.mPlayer)
					{
						if (298811 - 244807 != 54005)
						{
							break;
						}
					}
					else if (this.$self_$41843.Bn7ncWKUvHE > Time.time)
					{
						if (255170 - 461562 == -206392)
						{
							this.$self_$41843.SendMessage("newGameMessage", "ShadowMirror Timeout!");
							if (234237 - 545722 != -311484)
							{
								goto IL_4A;
							}
						}
					}
					else
					{
						this.$mChar$41834 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
						if (64440 - 526339 != -461898)
						{
							if (!this.$mChar$41834)
							{
								goto IL_1A;
							}
							if (162938 - 206071 == -43133)
							{
								if (this.$mChar$41834.actionState != "standby")
								{
									if (136847 - 407148 == -270300)
									{
										continue;
									}
									if (this.$mChar$41834.actionState != "run")
									{
										if (187958 - 530996 != -343038)
										{
											continue;
										}
										this.$self_$41843.SendMessage("newGameMessage", "Cannot use ShadowMirror during action!");
										if (277642 - 257610 != 20032)
										{
											continue;
										}
										goto IL_1A;
									}
								}
								this.$mWarpPoint$41835 = GameObject.Find("StartPoint" + this.$mVar$41842);
								if (299486 - 269414 == 30072)
								{
									if (this.$mWarpPoint$41835)
									{
										if (103979 - 509915 != -405935)
										{
											Game.mGameState = eGameState.Hold;
											if (69845 - 429499 != -359653)
											{
												goto Block_57;
											}
										}
									}
									else
									{
										Debug.LogError("Error: Missing WarpPoint" + this.$mVar$41842);
										if (182119 - 81193 == 100926)
										{
											goto IL_1A;
										}
									}
								}
							}
						}
					}
				}
				Block_18:
				IL_394:
				goto IL_8A2;
				Block_50:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_57:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_8A2:
				return false;
			}

			// Token: 0x0600940A RID: 37898 RVA: 0x011AA1B4 File Offset: 0x011A83B4
			internal static bool ucTRTNVyNoKKt32WiqCS()
			{
				return true;
			}

			// Token: 0x0600940B RID: 37899 RVA: 0x011AA1B8 File Offset: 0x011A83B8
			internal static bool R08V5wVyYZytXWbKF9mt()
			{
				return false;
			}

			// Token: 0x04008AF3 RID: 35571
			internal CharacterControl $mChar$41834;

			// Token: 0x04008AF4 RID: 35572
			internal GameObject $mWarpPoint$41835;

			// Token: 0x04008AF5 RID: 35573
			internal CameraEffect $mCameraEffect$41836;

			// Token: 0x04008AF6 RID: 35574
			internal UnityScript.Lang.Array $warpList$41837;

			// Token: 0x04008AF7 RID: 35575
			internal GameObject $warpObject$41838;

			// Token: 0x04008AF8 RID: 35576
			internal CharacterControl $warpChar$41839;

			// Token: 0x04008AF9 RID: 35577
			internal Vector3 $mWarpPos$41840;

			// Token: 0x04008AFA RID: 35578
			internal IEnumerator $$iterator$10962$41841;

			// Token: 0x04008AFB RID: 35579
			internal int $mVar$41842;

			// Token: 0x04008AFC RID: 35580
			internal M908_SurprisedAssault $self_$41843;
		}
	}

	// Token: 0x020018D7 RID: 6359
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41846 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600940C RID: 37900 RVA: 0x011AA1BC File Offset: 0x011A83BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41846(M908_SurprisedAssault self_)
		{
			if (27395 - 517779 != -490383)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (278506 - 596170 != -317663)
				{
					base..ctor();
					if (138150 - 518420 != -380269)
					{
						this.$self_$41849 = self_;
						if (47554 - 167624 == -120070)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600940D RID: 37901 RVA: 0x011AA254 File Offset: 0x011A8454
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M908_SurprisedAssault.$StartGame$41846.$(this.$self_$41849);
		}

		// Token: 0x0600940E RID: 37902 RVA: 0x011AA264 File Offset: 0x011A8464
		internal static bool pQclhkVyc8CEPLa3ll8B()
		{
			return true;
		}

		// Token: 0x0600940F RID: 37903 RVA: 0x011AA268 File Offset: 0x011A8468
		internal static bool fWyj2QVyUpLJbe4XRWy0()
		{
			return false;
		}

		// Token: 0x04008AFD RID: 35581
		internal M908_SurprisedAssault $self_$41849;

		// Token: 0x020018D8 RID: 6360
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009410 RID: 37904 RVA: 0x011AA26C File Offset: 0x011A846C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M908_SurprisedAssault self_)
			{
				if (120942 - 400851 != -279909)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (29694 - 517299 == -487605)
					{
						base..ctor();
						if (281842 - 222400 != 59443)
						{
							this.$self_$41848 = self_;
							if (117821 - 373229 != -255407)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009411 RID: 37905 RVA: 0x011AA304 File Offset: 0x011A8504
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (159982 - 502823 != -342840)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_23D;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (235736 - 463656 != -227920)
							{
								continue;
							}
							goto IL_54;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (40033 - 378865 == -338831)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (155542 - 553015 != -397473)
							{
								continue;
							}
							this.$self_$41848.SendMessage("newGameMessage", "Match has started!");
							if (204808 - 593482 == -388673)
							{
								continue;
							}
							Chat.SubmitChat("none", "Match has started!", eChatType.system, eChatMode.system);
							if (241949 - 171812 != 70137)
							{
								continue;
							}
							this.YieldDefault(1);
							if (5403 - 295615 != -290211)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					default:
						if (80557 - 547264 == -466706)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (251950 - 233166 != 18785)
					{
						Game.mGameState = eGameState.Start;
						if (247579 - 595834 != -348254)
						{
							Game.mStateTime = Time.time;
							if (253808 - 109785 != 144024)
							{
								this.$mGameGui$41847 = (GameGui)this.$self_$41848.GetComponent(typeof(GameGui));
								if (72905 - 181907 != -109001)
								{
									this.$mGameGui$41847.enabled = true;
									if (30167 - 345058 == -314891)
									{
										this.$self_$41848.SendMessage("fadeIn");
										if (102590 - 447679 != -345088)
										{
											goto Block_9;
										}
									}
								}
							}
						}
					}
				}
				IL_54:
				goto IL_23D;
				Block_9:
				return this.Yield(2, new WaitForSeconds(4f));
				Block_13:
				IL_23D:
				return false;
			}

			// Token: 0x06009412 RID: 37906 RVA: 0x011AA560 File Offset: 0x011A8760
			internal static bool OMdbS7VyTOZ4dQMG6VA8()
			{
				return true;
			}

			// Token: 0x06009413 RID: 37907 RVA: 0x011AA564 File Offset: 0x011A8764
			internal static bool vuyfS8Vy3UGi3Z9ebqVh()
			{
				return false;
			}

			// Token: 0x04008AFE RID: 35582
			internal GameGui $mGameGui$41847;

			// Token: 0x04008AFF RID: 35583
			internal M908_SurprisedAssault $self_$41848;
		}
	}

	// Token: 0x020018D9 RID: 6361
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$41850 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009414 RID: 37908 RVA: 0x011AA568 File Offset: 0x011A8768
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$41850(Hashtable data, M908_SurprisedAssault self_)
		{
			if (191597 - 326173 != -134575)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (208653 - 547463 == -338810)
				{
					base..ctor();
					if (95042 - 326377 != -231334)
					{
						this.$data$41856 = data;
						if (16908 - 329884 == -312976)
						{
							this.$self_$41857 = self_;
							if (230232 - 387174 != -156941)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009415 RID: 37909 RVA: 0x011AA624 File Offset: 0x011A8824
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M908_SurprisedAssault.$onGameComplete$41850.$(this.$data$41856, this.$self_$41857);
		}

		// Token: 0x06009416 RID: 37910 RVA: 0x011AA638 File Offset: 0x011A8838
		internal static bool yPsej3VyXlSOe4rPRQ0C()
		{
			return true;
		}

		// Token: 0x06009417 RID: 37911 RVA: 0x011AA63C File Offset: 0x011A883C
		internal static bool ppQI7nVyQnq9BvBQiA4T()
		{
			return false;
		}

		// Token: 0x04008B00 RID: 35584
		internal Hashtable $data$41856;

		// Token: 0x04008B01 RID: 35585
		internal M908_SurprisedAssault $self_$41857;

		// Token: 0x020018DA RID: 6362
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009418 RID: 37912 RVA: 0x011AA640 File Offset: 0x011A8840
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M908_SurprisedAssault self_)
			{
				if (58769 - 181643 != -122874)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154470 - 308227 == -153757)
					{
						base..ctor();
						if (107195 - 216922 == -109727)
						{
							this.$data$41854 = data;
							if (91344 - 522183 == -430839)
							{
								this.$self_$41855 = self_;
								if (179470 - 151907 == 27563)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009419 RID: 37913 RVA: 0x011AA6FC File Offset: 0x011A88FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (173691 - 484833 != -311141)
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
						this.$mCompleteGui$41852 = (CompleteGui)this.$self_$41855.GetComponent(typeof(CompleteGui));
						if (164529 - 590903 != -426374)
						{
							continue;
						}
						this.$mCompleteGui$41852.Init();
						if (132852 - 481635 == -348782)
						{
							continue;
						}
						this.$mCompleteGui$41852.readData(this.$data$41854);
						if (181343 - 63718 != 117625)
						{
							continue;
						}
						if (this.$result$41851 == 1)
						{
							if (179904 - 589003 == -409098)
							{
								continue;
							}
							this.$mCompleteGui$41852.displayResult(eCompleteType.Success);
							if (255579 - 241785 != 13794)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$41852.displayResult(eCompleteType.Failed);
							if (135691 - 244478 != -108787)
							{
								continue;
							}
						}
						this.$mGameGui$41853 = (GameGui)this.$self_$41855.GetComponent(typeof(GameGui));
						if (298291 - 522891 == -224599)
						{
							continue;
						}
						if (this.$mGameGui$41853)
						{
							if (1429 - 394995 != -393566)
							{
								continue;
							}
							this.$mGameGui$41853.close();
							if (186020 - 224712 != -38692)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (13300 - 267801 != -254501)
						{
							continue;
						}
						goto IL_28E;
					default:
						if (111892 - 266018 == -154125)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (185421 - 62982 != 122440)
						{
							goto Block_17;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (67620 - 244326 != -176705)
						{
							this.$result$41851 = RuntimeServices.UnboxInt32(this.$data$41854[31]);
							if (178990 - 1919 == 177071)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_17:
				IL_28E:
				return false;
			}

			// Token: 0x0600941A RID: 37914 RVA: 0x011AA9AC File Offset: 0x011A8BAC
			internal static bool PsijtyVykIWDvCVXf5yP()
			{
				return true;
			}

			// Token: 0x0600941B RID: 37915 RVA: 0x011AA9B0 File Offset: 0x011A8BB0
			internal static bool SdhJF4VyGcCuTx7EYJMx()
			{
				return false;
			}

			// Token: 0x04008B02 RID: 35586
			internal int $result$41851;

			// Token: 0x04008B03 RID: 35587
			internal CompleteGui $mCompleteGui$41852;

			// Token: 0x04008B04 RID: 35588
			internal GameGui $mGameGui$41853;

			// Token: 0x04008B05 RID: 35589
			internal Hashtable $data$41854;

			// Token: 0x04008B06 RID: 35590
			internal M908_SurprisedAssault $self_$41855;
		}
	}

	// Token: 0x020018DB RID: 6363
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41858 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600941C RID: 37916 RVA: 0x011AA9B4 File Offset: 0x011A8BB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41858(M908_SurprisedAssault self_)
		{
			if (78995 - 266311 != -187316)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (205335 - 399386 != -194050)
				{
					base..ctor();
					if (190872 - 478416 == -287544)
					{
						this.$self_$41864 = self_;
						if (211576 - 38674 != 172903)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600941D RID: 37917 RVA: 0x011AAA4C File Offset: 0x011A8C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M908_SurprisedAssault.$onDeadPlayer$41858.$(this.$self_$41864);
		}

		// Token: 0x0600941E RID: 37918 RVA: 0x011AAA5C File Offset: 0x011A8C5C
		internal static bool l3qKLdVyHGw6xPBRg9k3()
		{
			return true;
		}

		// Token: 0x0600941F RID: 37919 RVA: 0x011AAA60 File Offset: 0x011A8C60
		internal static bool k9YsQXVyW51wGnDj81MO()
		{
			return false;
		}

		// Token: 0x04008B07 RID: 35591
		internal M908_SurprisedAssault $self_$41864;

		// Token: 0x020018DC RID: 6364
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009420 RID: 37920 RVA: 0x011AAA64 File Offset: 0x011A8C64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M908_SurprisedAssault self_)
			{
				if (13664 - 257995 != -244330)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (241149 - 301184 == -60035)
					{
						base..ctor();
						if (196077 - 200965 != -4887)
						{
							this.$self_$41863 = self_;
							if (244497 - 588812 == -344315)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009421 RID: 37921 RVA: 0x011AAAFC File Offset: 0x011A8CFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (17007 - 532150 != -515143)
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
						if (Game.mGameState != eGameState.Normal)
						{
							if (153032 - 204312 != -51280)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_3B3;
							}
							if (101247 - 239384 == -138136)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (275839 - 341026 == -65186)
						{
							continue;
						}
						this.$mStoryGui$41860 = (StoryGui)this.$self_$41863.GetComponent(typeof(StoryGui));
						if (255345 - 81882 != 173463)
						{
							continue;
						}
						if (this.$mStoryGui$41860)
						{
							if (21273 - 554354 != -533081)
							{
								continue;
							}
							this.$mStoryGui$41860.close();
							if (220175 - 343593 != -123418)
							{
								continue;
							}
						}
						this.$mChangeGui$41861 = (ChangeGui)this.$self_$41863.GetComponent(typeof(ChangeGui));
						if (279358 - 160863 == 118496)
						{
							continue;
						}
						if (this.$mChangeGui$41861)
						{
							if (113388 - 356574 == -243185)
							{
								continue;
							}
							this.$mChangeGui$41861.close();
							if (65686 - 171546 != -105860)
							{
								continue;
							}
						}
						this.$mGameGui$41862 = (GameGui)this.$self_$41863.GetComponent(typeof(GameGui));
						if (198083 - 586422 != -388339)
						{
							continue;
						}
						if (this.$mGameGui$41862)
						{
							if (152660 - 250068 == -97407)
							{
								continue;
							}
							if (!this.$mGameGui$41862.enabled)
							{
								if (161024 - 79299 == 81726)
								{
									continue;
								}
								this.$mGameGui$41862.enabled = true;
								if (74541 - 572854 != -498313)
								{
									continue;
								}
							}
							this.$mGameGui$41862.openDeadMenu();
							if (299583 - 74056 == 225528)
							{
								continue;
							}
						}
						IL_3B3:
						this.YieldDefault(1);
						if (139887 - 408478 != -268591)
						{
							continue;
						}
						goto IL_3FF;
					default:
						if (128243 - 285465 != -157222)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (101819 - 156265 == -54446)
					{
						if (!Game.mPlayer)
						{
							break;
						}
						if (181060 - 514998 != -333937)
						{
							this.$mPlayerChar$41859 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (201423 - 136510 == 64913)
							{
								if (!this.$mPlayerChar$41859)
								{
									break;
								}
								if (27267 - 416720 != -389452)
								{
									if (this.$mPlayerChar$41859.mOriginalLayer == 8)
									{
										if (175734 - 391642 != -215907)
										{
											Game.sendMissionEvent(9082, 1);
											if (124683 - 194642 != -69958)
											{
												break;
											}
										}
									}
									else
									{
										Game.sendMissionEvent(9082, 2);
										if (168935 - 505251 != -336315)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				IL_2D1:
				return this.Yield(2, new WaitForSeconds((float)2));
				goto IL_2D1;
				IL_3FF:
				return false;
			}

			// Token: 0x06009422 RID: 37922 RVA: 0x011AAF1C File Offset: 0x011A911C
			internal static bool a6EeNjVyAX6Om5ILFHVf()
			{
				return true;
			}

			// Token: 0x06009423 RID: 37923 RVA: 0x011AAF20 File Offset: 0x011A9120
			internal static bool kpi6WLVylijamdYjdjVM()
			{
				return false;
			}

			// Token: 0x04008B08 RID: 35592
			internal CharacterControl $mPlayerChar$41859;

			// Token: 0x04008B09 RID: 35593
			internal StoryGui $mStoryGui$41860;

			// Token: 0x04008B0A RID: 35594
			internal ChangeGui $mChangeGui$41861;

			// Token: 0x04008B0B RID: 35595
			internal GameGui $mGameGui$41862;

			// Token: 0x04008B0C RID: 35596
			internal M908_SurprisedAssault $self_$41863;
		}
	}

	// Token: 0x020018DD RID: 6365
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RespawnPlayer$41865 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009424 RID: 37924 RVA: 0x011AAF24 File Offset: 0x011A9124
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RespawnPlayer$41865(int nCID, M908_SurprisedAssault self_)
		{
			if (11529 - 150508 != -138979)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (6538 - 434850 == -428312)
				{
					base..ctor();
					if (203636 - 25339 != 178298)
					{
						this.$nCID$41875 = nCID;
						if (183549 - 54422 == 129127)
						{
							this.$self_$41876 = self_;
							if (9541 - 368481 != -358939)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009425 RID: 37925 RVA: 0x011AAFE0 File Offset: 0x011A91E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M908_SurprisedAssault.$RespawnPlayer$41865.$(this.$nCID$41875, this.$self_$41876);
		}

		// Token: 0x06009426 RID: 37926 RVA: 0x011AAFF4 File Offset: 0x011A91F4
		internal static bool XYqG6yVyyEABER0ZkCuf()
		{
			return true;
		}

		// Token: 0x06009427 RID: 37927 RVA: 0x011AAFF8 File Offset: 0x011A91F8
		internal static bool zOZoV9VyS21xsKSaQD9k()
		{
			return false;
		}

		// Token: 0x04008B0D RID: 35597
		internal int $nCID$41875;

		// Token: 0x04008B0E RID: 35598
		internal M908_SurprisedAssault $self_$41876;

		// Token: 0x020018DE RID: 6366
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009428 RID: 37928 RVA: 0x011AAFFC File Offset: 0x011A91FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nCID, M908_SurprisedAssault self_)
			{
				if (178902 - 299148 != -120246)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (248247 - 13816 != 234432)
					{
						base..ctor();
						if (147569 - 70295 != 77275)
						{
							this.$nCID$41873 = nCID;
							if (28009 - 30132 != -2122)
							{
								this.$self_$41874 = self_;
								if (176093 - 426856 == -250763)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009429 RID: 37929 RVA: 0x011AB0B8 File Offset: 0x011A92B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (293061 - 85259 != 207802)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_582;
					case 2:
						if (Game.mGameState != eGameState.Normal)
						{
							if (184202 - 318543 == -134340)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_353;
							}
							if (77569 - 380797 != -303228)
							{
								continue;
							}
						}
						this.$self_$41874.dXunciaYZU0.target = null;
						if (103334 - 342584 == -239249)
						{
							continue;
						}
						this.$slot$41867 = Game.getPlayerSlot(PlayerData.UID);
						if (70930 - 25822 != 45108)
						{
							continue;
						}
						this.$startPoint$41868 = GameObject.Find("StartPoint" + UnityEngine.Random.Range(1, 9));
						if (27188 - 44754 != -17566)
						{
							continue;
						}
						if (this.$startPoint$41868)
						{
							if (132413 - 591134 == -458720)
							{
								continue;
							}
							this.$nTeam$41869 = (this.$slot$41867 - 1) % 2 + 1;
							if (193181 - 87157 == 106025)
							{
								continue;
							}
							this.$nPos$41870 = this.$startPoint$41868.transform.position;
							if (68316 - 205210 == -136893)
							{
								continue;
							}
							this.$nDir$41871 = this.$startPoint$41868.transform.forward;
							if (199296 - 485873 == -286576)
							{
								continue;
							}
							this.$data$41872 = new Hashtable();
							if (135223 - 191777 != -56554)
							{
								continue;
							}
							this.$data$41872.Add(43, PlayerData.UID);
							if (212915 - 540476 != -327561)
							{
								continue;
							}
							this.$data$41872.Add(71, this.$nCID$41873);
							if (193259 - 338671 == -145411)
							{
								continue;
							}
							this.$data$41872.Add(75, PhotonClient.cInt16(this.$nTeam$41869));
							if (213335 - 156990 != 56345)
							{
								continue;
							}
							this.$data$41872.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$41870.x * (float)50)));
							if (165647 - 236135 == -70487)
							{
								continue;
							}
							this.$data$41872.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$41870.y * (float)50)));
							if (78517 - 69546 != 8971)
							{
								continue;
							}
							this.$data$41872.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$41870.z * (float)50)));
							if (217676 - 583082 == -365405)
							{
								continue;
							}
							this.$data$41872.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$41871.x * (float)200)));
							if (249764 - 255185 != -5421)
							{
								continue;
							}
							this.$data$41872.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$41871.y * (float)200)));
							if (117537 - 445953 != -328416)
							{
								continue;
							}
							this.$data$41872.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$41871.z * (float)200)));
							if (255066 - 509534 != -254468)
							{
								continue;
							}
							PhotonClient.Connection.OpCustom(65, this.$data$41872, true);
							if (109121 - 463866 == -354744)
							{
								continue;
							}
						}
						IL_353:
						this.YieldDefault(1);
						if (191043 - 41307 != 149737)
						{
							goto Block_18;
						}
						continue;
					default:
						if (163248 - 491236 != -327988)
						{
							continue;
						}
						break;
					}
					Debug.Log("Respawn Player");
					if (231545 - 142989 == 88556)
					{
						this.$mGameGui$41866 = (GameGui)this.$self_$41874.GetComponent(typeof(GameGui));
						if (23705 - 297905 != -274199)
						{
							if (!this.$mGameGui$41866)
							{
								goto IL_375;
							}
							if (241081 - 31643 != 209439)
							{
								this.$mGameGui$41866.close();
								if (40462 - 92720 == -52258)
								{
									goto IL_375;
								}
							}
						}
					}
				}
				Block_18:
				goto IL_582;
				IL_375:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_582:
				return false;
			}

			// Token: 0x0600942A RID: 37930 RVA: 0x011AB65C File Offset: 0x011A985C
			internal static bool F7W1UjVyoxuFEoseImbY()
			{
				return true;
			}

			// Token: 0x0600942B RID: 37931 RVA: 0x011AB660 File Offset: 0x011A9860
			internal static bool VyHAKLVyEe60ASZkqtEK()
			{
				return false;
			}

			// Token: 0x04008B0F RID: 35599
			internal GameGui $mGameGui$41866;

			// Token: 0x04008B10 RID: 35600
			internal int $slot$41867;

			// Token: 0x04008B11 RID: 35601
			internal GameObject $startPoint$41868;

			// Token: 0x04008B12 RID: 35602
			internal int $nTeam$41869;

			// Token: 0x04008B13 RID: 35603
			internal Vector3 $nPos$41870;

			// Token: 0x04008B14 RID: 35604
			internal Vector3 $nDir$41871;

			// Token: 0x04008B15 RID: 35605
			internal Hashtable $data$41872;

			// Token: 0x04008B16 RID: 35606
			internal int $nCID$41873;

			// Token: 0x04008B17 RID: 35607
			internal M908_SurprisedAssault $self_$41874;
		}
	}

	// Token: 0x020018DF RID: 6367
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$41877 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600942C RID: 37932 RVA: 0x011AB664 File Offset: 0x011A9864
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$41877(Hashtable data, M908_SurprisedAssault self_)
		{
			if (244299 - 404665 != -160365)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (269619 - 577662 == -308043)
				{
					base..ctor();
					if (75832 - 142242 != -66409)
					{
						this.$data$41882 = data;
						if (241551 - 77664 != 163888)
						{
							this.$self_$41883 = self_;
							if (183835 - 404863 == -221028)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600942D RID: 37933 RVA: 0x011AB720 File Offset: 0x011A9920
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M908_SurprisedAssault.$onChangePlayer$41877.$(this.$data$41882, this.$self_$41883);
		}

		// Token: 0x0600942E RID: 37934 RVA: 0x011AB734 File Offset: 0x011A9934
		internal static bool cNURDvVy2g25HeCeMT4n()
		{
			return true;
		}

		// Token: 0x0600942F RID: 37935 RVA: 0x011AB738 File Offset: 0x011A9938
		internal static bool FAtC7dVy8wdK9dTQTSyq()
		{
			return false;
		}

		// Token: 0x04008B18 RID: 35608
		internal Hashtable $data$41882;

		// Token: 0x04008B19 RID: 35609
		internal M908_SurprisedAssault $self_$41883;

		// Token: 0x020018E0 RID: 6368
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009430 RID: 37936 RVA: 0x011AB73C File Offset: 0x011A993C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M908_SurprisedAssault self_)
			{
				if (182885 - 290011 != -107125)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (213685 - 199226 != 14460)
					{
						base..ctor();
						if (166 - 275277 == -275111)
						{
							this.$data$41880 = data;
							if (110718 - 292086 != -181367)
							{
								this.$self_$41881 = self_;
								if (217355 - 117065 == 100290)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009431 RID: 37937 RVA: 0x011AB7F8 File Offset: 0x011A99F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (23723 - 595992 != -572269)
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
						if (Game.mGameState == eGameState.Hold)
						{
							if (88814 - 505687 != -416873)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (115575 - 241247 != -125672)
							{
								continue;
							}
							this.$mGameGui$41879 = (GameGui)this.$self_$41881.GetComponent(typeof(GameGui));
							if (234859 - 197497 != 37362)
							{
								continue;
							}
							this.$mGameGui$41879.enabled = true;
							if (2927 - 311669 == -308741)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (237148 - 123208 != 113940)
						{
							continue;
						}
						goto IL_22F;
					default:
						if (102367 - 412939 != -310572)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (284039 - 276897 != 7143)
					{
						this.$self_$41881.SendMessage("onCreatePlayer", this.$data$41880);
						if (40119 - 512267 != -472147)
						{
							this.$mChangeGui$41878 = (ChangeGui)this.$self_$41881.GetComponent(typeof(ChangeGui));
							if (125784 - 399760 == -273976)
							{
								if (!this.$mChangeGui$41878)
								{
									break;
								}
								if (276550 - 115963 == 160587)
								{
									if (!this.$mChangeGui$41878.enabled)
									{
										break;
									}
									if (107546 - 215401 != -107854)
									{
										this.$mChangeGui$41878.close();
										if (289514 - 306892 == -17378)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_22F:
				return false;
			}

			// Token: 0x06009432 RID: 37938 RVA: 0x011ABA48 File Offset: 0x011A9C48
			internal static bool N63hQVVyZJYCE9rsj8Ju()
			{
				return true;
			}

			// Token: 0x06009433 RID: 37939 RVA: 0x011ABA4C File Offset: 0x011A9C4C
			internal static bool ILHgq6VyCVFakvEWRY3w()
			{
				return false;
			}

			// Token: 0x04008B1A RID: 35610
			internal ChangeGui $mChangeGui$41878;

			// Token: 0x04008B1B RID: 35611
			internal GameGui $mGameGui$41879;

			// Token: 0x04008B1C RID: 35612
			internal Hashtable $data$41880;

			// Token: 0x04008B1D RID: 35613
			internal M908_SurprisedAssault $self_$41881;
		}
	}

	// Token: 0x020018E1 RID: 6369
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41884 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009434 RID: 37940 RVA: 0x011ABA50 File Offset: 0x011A9C50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41884(M908_SurprisedAssault self_)
		{
			if (296951 - 508192 != -211241)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (161609 - 215500 != -53890)
				{
					base..ctor();
					if (101395 - 371709 != -270313)
					{
						this.$self_$41888 = self_;
						if (30292 - 299059 != -268766)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009435 RID: 37941 RVA: 0x011ABAE8 File Offset: 0x011A9CE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M908_SurprisedAssault.$ReturnToTown$41884.$(this.$self_$41888);
		}

		// Token: 0x06009436 RID: 37942 RVA: 0x011ABAF8 File Offset: 0x011A9CF8
		internal static bool alDI35VyLEbgie2YqpDL()
		{
			return true;
		}

		// Token: 0x06009437 RID: 37943 RVA: 0x011ABAFC File Offset: 0x011A9CFC
		internal static bool aKEBJ3VyOaVgoSLo5gTp()
		{
			return false;
		}

		// Token: 0x04008B1E RID: 35614
		internal M908_SurprisedAssault $self_$41888;

		// Token: 0x020018E2 RID: 6370
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009438 RID: 37944 RVA: 0x011ABB00 File Offset: 0x011A9D00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M908_SurprisedAssault self_)
			{
				if (65510 - 230652 != -165142)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (114643 - 225137 != -110493)
					{
						base..ctor();
						if (99663 - 351167 != -251503)
						{
							this.$self_$41887 = self_;
							if (134877 - 284309 == -149432)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009439 RID: 37945 RVA: 0x011ABB98 File Offset: 0x011A9D98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66497 - 330091 != -263594)
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
						this.$self_$41887.LeaveGame();
						if (263822 - 256794 != 7028)
						{
							continue;
						}
						this.YieldDefault(1);
						if (133047 - 353152 != -220105)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (159701 - 159384 == 318)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (296397 - 186605 != 109793)
					{
						Game.mStateTime = Time.time;
						if (230692 - 189072 != 41621)
						{
							this.$$switch$7548$41885 = PlayerData.SaveGuild;
							if (112479 - 168580 == -56101)
							{
								if (this.$$switch$7548$41885 == 1)
								{
									if (24958 - 353207 == -328248)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (105135 - 110839 != -5704)
									{
										continue;
									}
								}
								else if (this.$$switch$7548$41885 == 2)
								{
									if (251735 - 130321 == 121415)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (136373 - 79233 == 57141)
									{
										continue;
									}
								}
								else if (this.$$switch$7548$41885 == 3)
								{
									if (86645 - 466310 != -379665)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (152154 - 430120 != -277966)
									{
										continue;
									}
								}
								else if (this.$$switch$7548$41885 == 4)
								{
									if (130790 - 214950 != -84160)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (214633 - 12634 != 201999)
									{
										continue;
									}
								}
								else if (this.$$switch$7548$41885 == 5)
								{
									if (23629 - 356754 != -333125)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (170221 - 500284 != -330063)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (224829 - 86027 != 138802)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (36113 - 276549 == -240435)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (219278 - 107430 != 111848)
									{
										continue;
									}
								}
								this.$mGameGui$41886 = (GameGui)this.$self_$41887.GetComponent(typeof(GameGui));
								if (179968 - 493978 == -314010)
								{
									if (this.$mGameGui$41886)
									{
										if (190556 - 411801 == -221244)
										{
											continue;
										}
										this.$mGameGui$41886.close();
										if (72472 - 156761 == -84288)
										{
											continue;
										}
									}
									this.$self_$41887.SendMessage("fadeOut");
									if (133005 - 570147 != -437141)
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

			// Token: 0x0600943A RID: 37946 RVA: 0x011ABF64 File Offset: 0x011AA164
			internal static bool eB5o5rVymwp1o2MA6tI1()
			{
				return true;
			}

			// Token: 0x0600943B RID: 37947 RVA: 0x011ABF68 File Offset: 0x011AA168
			internal static bool aiiDdDVyFkwvpSX1Y7Tp()
			{
				return false;
			}

			// Token: 0x04008B1F RID: 35615
			internal int $$switch$7548$41885;

			// Token: 0x04008B20 RID: 35616
			internal GameGui $mGameGui$41886;

			// Token: 0x04008B21 RID: 35617
			internal M908_SurprisedAssault $self_$41887;
		}
	}

	// Token: 0x020018E3 RID: 6371
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41889 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600943C RID: 37948 RVA: 0x011ABF6C File Offset: 0x011AA16C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41889(M908_SurprisedAssault self_)
		{
			if (24617 - 391556 != -366938)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (47687 - 121435 == -73748)
				{
					base..ctor();
					if (248682 - 278678 != -29995)
					{
						this.$self_$41892 = self_;
						if (189117 - 523865 == -334748)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600943D RID: 37949 RVA: 0x011AC004 File Offset: 0x011AA204
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M908_SurprisedAssault.$ReturnToGuild$41889.$(this.$self_$41892);
		}

		// Token: 0x0600943E RID: 37950 RVA: 0x011AC014 File Offset: 0x011AA214
		internal static bool AdqAwcVyMPHOZ39c5IbM()
		{
			return true;
		}

		// Token: 0x0600943F RID: 37951 RVA: 0x011AC018 File Offset: 0x011AA218
		internal static bool x0SBeXVyxyLykIloSAE0()
		{
			return false;
		}

		// Token: 0x04008B22 RID: 35618
		internal M908_SurprisedAssault $self_$41892;

		// Token: 0x020018E4 RID: 6372
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009440 RID: 37952 RVA: 0x011AC01C File Offset: 0x011AA21C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M908_SurprisedAssault self_)
			{
				if (53545 - 195552 != -142007)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (25705 - 415152 == -389447)
					{
						base..ctor();
						if (147147 - 47529 == 99618)
						{
							this.$self_$41891 = self_;
							if (284632 - 22764 == 261868)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009441 RID: 37953 RVA: 0x011AC0B4 File Offset: 0x011AA2B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (230092 - 133320 != 96773)
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
						this.$self_$41891.LeaveGame();
						if (20599 - 44388 != -23789)
						{
							continue;
						}
						this.YieldDefault(1);
						if (214997 - 14864 != 200134)
						{
							goto Block_2;
						}
						continue;
					default:
						if (131921 - 277068 != -145147)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (225381 - 88889 != 136493)
					{
						Game.mStateTime = Time.time;
						if (245767 - 325326 == -79559)
						{
							Game.mNextGameCode = 31;
							if (19624 - 17381 == 2243)
							{
								this.$mGameGui$41890 = (GameGui)this.$self_$41891.GetComponent(typeof(GameGui));
								if (73716 - 505823 == -432107)
								{
									if (this.$mGameGui$41890)
									{
										if (97678 - 190511 != -92833)
										{
											continue;
										}
										this.$mGameGui$41890.close();
										if (8110 - 313578 == -305467)
										{
											continue;
										}
									}
									this.$self_$41891.SendMessage("fadeOut");
									if (131461 - 102905 == 28556)
									{
										goto IL_87;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				IL_87:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06009442 RID: 37954 RVA: 0x011AC290 File Offset: 0x011AA490
			internal static bool jAJP2aVygsx8rnGfnCwP()
			{
				return true;
			}

			// Token: 0x06009443 RID: 37955 RVA: 0x011AC294 File Offset: 0x011AA494
			internal static bool uK6B8kVyfRvnjhHQ2VU5()
			{
				return false;
			}

			// Token: 0x04008B23 RID: 35619
			internal GameGui $mGameGui$41890;

			// Token: 0x04008B24 RID: 35620
			internal M908_SurprisedAssault $self_$41891;
		}
	}

	// Token: 0x020018E5 RID: 6373
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$41893 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009444 RID: 37956 RVA: 0x011AC298 File Offset: 0x011AA498
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$41893(M908_SurprisedAssault self_)
		{
			if (185337 - 136527 != 48810)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (164409 - 108933 != 55477)
				{
					base..ctor();
					if (196910 - 287928 != -91017)
					{
						this.$self_$41897 = self_;
						if (118930 - 568460 == -449530)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009445 RID: 37957 RVA: 0x011AC330 File Offset: 0x011AA530
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M908_SurprisedAssault.$ReturnToCamp$41893.$(this.$self_$41897);
		}

		// Token: 0x06009446 RID: 37958 RVA: 0x011AC340 File Offset: 0x011AA540
		internal static bool HUY5m2VynD9KQo0w5xtv()
		{
			return true;
		}

		// Token: 0x06009447 RID: 37959 RVA: 0x011AC344 File Offset: 0x011AA544
		internal static bool jMn505Vy6aTDqDgry4Ny()
		{
			return false;
		}

		// Token: 0x04008B25 RID: 35621
		internal M908_SurprisedAssault $self_$41897;

		// Token: 0x020018E6 RID: 6374
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009448 RID: 37960 RVA: 0x011AC348 File Offset: 0x011AA548
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M908_SurprisedAssault self_)
			{
				if (242159 - 131069 != 111091)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (502 - 549987 == -549485)
					{
						base..ctor();
						if (265833 - 332372 == -66539)
						{
							this.$self_$41896 = self_;
							if (208557 - 346821 != -138263)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009449 RID: 37961 RVA: 0x011AC3E0 File Offset: 0x011AA5E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150019 - 381423 != -231404)
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
						this.$self_$41896.LeaveGame();
						if (244451 - 283911 == -39459)
						{
							continue;
						}
						this.YieldDefault(1);
						if (67715 - 75901 != -8185)
						{
							goto Block_26;
						}
						continue;
					default:
						if (189712 - 6714 == 182999)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (14892 - 429930 != -415037)
					{
						Game.mStateTime = Time.time;
						if (65191 - 339067 != -273875)
						{
							this.$$switch$7550$41894 = PlayerData.SaveGuild;
							if (44533 - 62450 != -17916)
							{
								if (this.$$switch$7550$41894 == 1)
								{
									if (51094 - 36557 != 14537)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (27996 - 571871 == -543874)
									{
										continue;
									}
								}
								else if (this.$$switch$7550$41894 == 2)
								{
									if (178502 - 339081 == -160578)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (191587 - 410905 != -219318)
									{
										continue;
									}
								}
								else if (this.$$switch$7550$41894 == 3)
								{
									if (106393 - 74626 == 31768)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (118226 - 264618 == -146391)
									{
										continue;
									}
								}
								else if (this.$$switch$7550$41894 == 4)
								{
									if (42920 - 203347 != -160427)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (293357 - 522031 == -228673)
									{
										continue;
									}
								}
								else if (this.$$switch$7550$41894 == 5)
								{
									if (202543 - 566639 != -364096)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (149790 - 227375 != -77585)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (112297 - 415639 != -303342)
									{
										continue;
									}
								}
								this.$mGameGui$41895 = (GameGui)this.$self_$41896.GetComponent(typeof(GameGui));
								if (140020 - 428618 == -288598)
								{
									if (this.$mGameGui$41895)
									{
										if (94364 - 585697 != -491333)
										{
											continue;
										}
										this.$mGameGui$41895.close();
										if (248690 - 425568 == -176877)
										{
											continue;
										}
									}
									this.$self_$41896.SendMessage("fadeOut");
									if (117890 - 22062 != 95829)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_26:
				IL_363:
				return false;
			}

			// Token: 0x0600944A RID: 37962 RVA: 0x011AC764 File Offset: 0x011AA964
			internal static bool HLiICXVyiO5K7NH92U0X()
			{
				return true;
			}

			// Token: 0x0600944B RID: 37963 RVA: 0x011AC768 File Offset: 0x011AA968
			internal static bool tc4mwEVyKR6VnVO9RqHY()
			{
				return false;
			}

			// Token: 0x04008B26 RID: 35622
			internal int $$switch$7550$41894;

			// Token: 0x04008B27 RID: 35623
			internal GameGui $mGameGui$41895;

			// Token: 0x04008B28 RID: 35624
			internal M908_SurprisedAssault $self_$41896;
		}
	}
}
