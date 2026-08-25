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

// Token: 0x0200140B RID: 5131
[Serializable]
public class M208_DoubleDuel : MonoBehaviour
{
	// Token: 0x0600767B RID: 30331 RVA: 0x00FDDD7C File Offset: 0x00FDBF7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M208_DoubleDuel()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600767C RID: 30332 RVA: 0x00FDDD8C File Offset: 0x00FDBF8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (3906 - 239177 != -235270)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (213830 - 73730 == 140100)
			{
				Game.mGameType = 5;
				if (225935 - 427358 != -201422)
				{
					if (Chat.Initialized)
					{
						if (57237 - 343943 != -286705)
						{
							Chat.ChatDisplay.Clear();
							if (227712 - 184600 == 43112)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (147114 - 138874 != 8241)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600767D RID: 30333 RVA: 0x00FDDE70 File Offset: 0x00FDC070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (210785 - 504596 != -293810)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (61224 - 270681 != -209456)
				{
					Game.nextGame();
					if (176441 - 197257 == -20816)
					{
						Game.mGameCode = 208;
						if (163404 - 370187 == -206783)
						{
							Game.mGameType = 5;
							if (31259 - 40622 == -9363)
							{
								Game.mGameTime = Time.time;
								if (242823 - 421122 != -178298)
								{
									Game.mGameScore = 0;
									if (75239 - 84035 != -8795)
									{
										Game.mGameMana = 0;
										if (207355 - 194310 == 13045)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (245515 - 554472 == -308957)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (277436 - 115347 == 162089)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (97647 - 171174 != -73526)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (131864 - 432991 == -301127)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (176911 - 501514 == -324603)
															{
																this.zB5cjAZvtBG = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (202982 - 330380 == -127398)
																{
																	this.IyOcjFIjkN9 = PhotonClient.Connection;
																	if (159706 - 346899 == -187193)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (156931 - 186797 == -29866)
																		{
																			this.InitGame();
																			if (165970 - 210637 == -44667)
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
				if (283135 - 284663 == -1528)
				{
					Game.mGameType = 99;
					if (173082 - 441885 == -268803)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600767E RID: 30334 RVA: 0x00FDE150 File Offset: 0x00FDC350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (217265 - 438319 != -221054)
		{
		}
		for (;;)
		{
			if (this.IyOcjFIjkN9 == null)
			{
				if (254865 - 196284 != 58582)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (67258 - 7239 == 60019)
				{
					if (mGameState == eGameState.Init)
					{
						if (31132 - 12269 == 18863)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (31044 - 318140 == -287096)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (205692 - 211199 != -5506)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (193979 - 136844 != 57136)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (155154 - 63697 == 91457)
						{
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (16399 - 392202 != -375802)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (78785 - 445079 == -366294)
						{
							if (Game.music != 0)
							{
								if (40324 - 427150 != -386826)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (242947 - 386852 == -143904)
									{
										continue;
									}
									this.audio.Play();
									if (12377 - 158987 == -146609)
									{
										continue;
									}
								}
							}
							if (Time.time <= this.XTDcj9yrovg)
							{
								break;
							}
							if (263155 - 252236 == 10919)
							{
								Game.mGameMana++;
								if (52575 - 424105 == -371530)
								{
									this.XTDcj9yrovg = Time.time + (float)12;
									if (93435 - 327802 != -234366)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (79202 - 502348 == -423146)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (213780 - 163985 == 49795)
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
						if (240882 - 42570 != 198313)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600767F RID: 30335 RVA: 0x00FDE450 File Offset: 0x00FDC650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (33678 - 7180 != 26498)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (196353 - 192426 == 3927)
			{
				float num = (float)1;
				if (92143 - 314181 == -222038)
				{
					float num2 = (float)(1024 * Screen.width / Screen.height);
					if (244064 - 359303 != -115238)
					{
						GUI.depth = 1;
						if (287440 - 2727 != 284714)
						{
							eGameState mGameState = Game.mGameState;
							if (196524 - 42102 == 154422)
							{
								if (mGameState == eGameState.Start)
								{
									if (56922 - 28268 == 28655)
									{
										continue;
									}
									if (this.Ucocjz2TWaL == 1)
									{
										if (156181 - 79951 != 76230)
										{
											continue;
										}
										if (Time.time - Game.mStateTime < (float)1)
										{
											if (276974 - 212952 != 64023)
											{
												break;
											}
											continue;
										}
										else if (Time.time - Game.mStateTime < (float)2)
										{
											if (225566 - 533486 != -307920)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)1);
											if (2904 - 71893 == -68988)
											{
												continue;
											}
											float a = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)1);
											if (95862 - 302448 == -206585)
											{
												continue;
											}
											Color color = GUI.color;
											if (28308 - 81759 != -53451)
											{
												continue;
											}
											float num3 = color.a = a;
											if (257919 - 311942 != -54023)
											{
												continue;
											}
											if (29757 - 296656 != -266899)
											{
												continue;
											}
											Color color2 = GUI.color = color;
											if (49153 - 49286 == -132)
											{
												continue;
											}
											if (29080 - 447505 != -418425)
											{
												continue;
											}
											if (this.O1DcjVvwnMl)
											{
												if (61713 - 403083 != -341370)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.O1DcjVvwnMl);
												if (45353 - 222661 == -177307)
												{
													continue;
												}
											}
										}
										else if (Time.time - Game.mStateTime < (float)3)
										{
											if (189635 - 63958 == 125678)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)2);
											if (129404 - 211396 == -81991)
											{
												continue;
											}
											float a2 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)2);
											if (166355 - 309821 == -143465)
											{
												continue;
											}
											Color color3 = GUI.color;
											if (50363 - 92 == 50272)
											{
												continue;
											}
											float num4 = color3.a = a2;
											if (112375 - 386997 == -274621)
											{
												continue;
											}
											if (32375 - 229667 != -197292)
											{
												continue;
											}
											GUI.color = color3;
											if (199031 - 412502 == -213470 || 198400 - 435557 == -237156)
											{
												continue;
											}
											if (this.VwscjyIL3Ku)
											{
												if (296341 - 147302 == 149040)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.VwscjyIL3Ku);
												if (40354 - 508143 == -467788)
												{
													continue;
												}
											}
										}
										else if (Time.time - Game.mStateTime < (float)4)
										{
											if (231197 - 364332 == -133134)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)3);
											if (26154 - 368340 == -342185)
											{
												continue;
											}
											float a3 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)3);
											if (119586 - 595025 != -475439)
											{
												continue;
											}
											Color color4 = GUI.color;
											if (285825 - 575264 == -289438)
											{
												continue;
											}
											float num5 = color4.a = a3;
											if (90142 - 304936 == -214793)
											{
												continue;
											}
											if (207768 - 383620 != -175852)
											{
												continue;
											}
											GUI.color = color4;
											if (35136 - 571365 != -536229)
											{
												continue;
											}
											if (3142 - 457758 == -454615)
											{
												continue;
											}
											if (this.YyccjuI35VX)
											{
												if (224893 - 483608 == -258714)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.YyccjuI35VX);
												if (74227 - 466846 == -392618)
												{
													continue;
												}
											}
										}
									}
								}
								else if (mGameState == eGameState.Normal)
								{
									if (86657 - 481612 != -394955)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)2)
									{
										if (139625 - 399584 != -259959)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
										if (78195 - 60244 != 17951)
										{
											continue;
										}
										if (Time.time - Game.mStateTime < 0.2f)
										{
											if (91064 - 520722 == -429657)
											{
												continue;
											}
											float a4 = Mathf.SmoothStep((float)0, (float)1, (float)5 * Time.time - Game.mStateTime);
											if (276893 - 24327 == 252567)
											{
												continue;
											}
											Color color5 = GUI.color;
											if (257019 - 274979 != -17960)
											{
												continue;
											}
											float num6 = color5.a = a4;
											if (212310 - 590299 == -377988 || 234188 - 104438 == 129751)
											{
												continue;
											}
											GUI.color = color5;
											if (90565 - 115725 == -25159 || 145688 - 271354 == -125665)
											{
												continue;
											}
										}
										else
										{
											float a5 = Mathf.SmoothStep((float)1, (float)0, 1.25f * (Time.time - Game.mStateTime - 0.2f));
											if (197765 - 163629 == 34137)
											{
												continue;
											}
											Color color6 = GUI.color;
											if (98258 - 547260 == -449001)
											{
												continue;
											}
											color6.a = a5;
											if (141962 - 555547 == -413584)
											{
												continue;
											}
											if (293200 - 380304 != -87104)
											{
												continue;
											}
											GUI.color = color6;
											if (180209 - 579219 == -399009 || 215365 - 49637 == 165729)
											{
												continue;
											}
										}
										if (this.oV6cjWB3d6v)
										{
											if (132220 - 594575 != -462355)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.oV6cjWB3d6v);
											if (217016 - 205165 != 11851)
											{
												continue;
											}
										}
									}
								}
								float a6 = 1f;
								if (170522 - 205342 == -34820)
								{
									Color color7 = GUI.color;
									if (49707 - 383826 != -334118)
									{
										color7.a = a6;
										if (235857 - 425211 != -189353 && 138096 - 384232 != -246135)
										{
											GUI.color = color7;
											if (31741 - 496504 != -464762)
											{
												if (74033 - 350893 == -276860)
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

	// Token: 0x06007680 RID: 30336 RVA: 0x00FDEEC8 File Offset: 0x00FDD0C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (29767 - 169143 != -139376)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (48200 - 14422 != 33779)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (80437 - 227230 != -146792)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (48211 - 270806 != -222594)
					{
						int uid = RuntimeServices.UnboxInt32(data[43]);
						if (140818 - 183320 == -42502)
						{
							int num3 = num;
							if (161553 - 380465 != -218911)
							{
								if (num3 == 2081)
								{
									if (240669 - 361571 != -120901)
									{
										if (this.Ucocjz2TWaL >= 1)
										{
											break;
										}
										if (85844 - 293964 == -208120)
										{
											this.Ucocjz2TWaL = 1;
											if (26300 - 202821 == -176521)
											{
												this.StartCoroutine_Auto(this.StartMatch());
												if (190049 - 148668 != 41382)
												{
													break;
												}
											}
										}
									}
								}
								else if (num3 == 2082)
								{
									if (111416 - 363736 != -252319)
									{
										if (num2 == 1)
										{
											if (89462 - 320111 != -230649)
											{
												continue;
											}
											this.Vu9co5OJSZy++;
											if (131520 - 317011 != -185491)
											{
												continue;
											}
										}
										else
										{
											this.taCcocyfGMd++;
											if (127510 - 461745 != -334235)
											{
												continue;
											}
										}
										Chat.SubmitChat("none", Game.getPlayerName(uid) + " has joined team" + num2, eChatType.system, eChatMode.system);
										if (184541 - 314715 != -130173)
										{
											break;
										}
									}
								}
								else
								{
									if (num3 != 2083)
									{
										break;
									}
									if (268351 - 423172 != -154820)
									{
										if (num2 == 1)
										{
											if (66918 - 108848 != -41929)
											{
												this.OJhconsVfqu++;
												if (99489 - 434598 == -335109)
												{
													this.SendMessage("newGameMessage", "Team1 defeated :" + this.OJhconsVfqu + "/" + this.Vu9co5OJSZy);
													if (256085 - 376298 != -120212)
													{
														Chat.SubmitChat("none", "Team1 defeated :" + this.OJhconsVfqu + "/" + this.Vu9co5OJSZy, eChatType.system, eChatMode.system);
														if (274797 - 13082 != 261716)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.FA4coQ8hAFv++;
											if (204355 - 430249 == -225894)
											{
												this.SendMessage("newGameMessage", "Team2 defeated :" + this.FA4coQ8hAFv + "/" + this.taCcocyfGMd);
												if (92475 - 566589 != -474113)
												{
													Chat.SubmitChat("none", "Team2 defeated :" + this.FA4coQ8hAFv + "/" + this.taCcocyfGMd, eChatType.system, eChatMode.system);
													if (141846 - 293354 == -151508)
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

	// Token: 0x06007681 RID: 30337 RVA: 0x00FDF340 File Offset: 0x00FDD540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartMatch()
	{
		return new M208_DoubleDuel.$StartMatch$38044(this).GetEnumerator();
	}

	// Token: 0x06007682 RID: 30338 RVA: 0x00FDF350 File Offset: 0x00FDD550
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameComplete(Hashtable data)
	{
		if (252811 - 450348 != -197537)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (166532 - 304843 != -138310)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Complete;
				if (120875 - 124300 != -3424)
				{
					int num = RuntimeServices.UnboxInt32(data[31]);
					if (194716 - 556098 != -361381)
					{
						int nWinner = RuntimeServices.UnboxInt32(data[36]);
						if (50040 - 485766 == -435726)
						{
							CompleteGui completeGui = (CompleteGui)this.GetComponent(typeof(CompleteGui));
							if (276220 - 213613 != 62608)
							{
								GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
								if (164577 - 481985 == -317408)
								{
									if (gameGui)
									{
										if (237797 - 455013 != -217216)
										{
											continue;
										}
										gameGui.close();
										if (186333 - 18867 == 167467)
										{
											continue;
										}
									}
									completeGui.Init();
									if (13969 - 367061 == -353092)
									{
										completeGui.readData(data);
										if (235912 - 373366 == -137454)
										{
											if (num == 1)
											{
												if (85766 - 595638 == -509872)
												{
													completeGui.StartCoroutine_Auto(completeGui.displayPvpResult(eCompleteType.Success, nWinner));
													if (146424 - 174895 != -28470)
													{
														break;
													}
												}
											}
											else
											{
												completeGui.StartCoroutine_Auto(completeGui.displayPvpResult(eCompleteType.Failed, nWinner));
												if (109802 - 429365 == -319563)
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

	// Token: 0x06007683 RID: 30339 RVA: 0x00FDF58C File Offset: 0x00FDD78C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (265123 - 473927 != -208804)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (255257 - 495845 != -240587)
			{
				Time.timeScale = 1f;
				if (112091 - 22407 == 89684)
				{
					this.oV6cjWB3d6v = (Texture)Resources.Load("GameGui/Title/battle", typeof(Texture));
					if (270522 - 335498 == -64976)
					{
						this.YyccjuI35VX = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
						if (244753 - 573283 == -328530)
						{
							this.VwscjyIL3Ku = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
							if (228559 - 471956 != -243396)
							{
								this.O1DcjVvwnMl = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
								if (18958 - 371574 == -352616)
								{
									this.hYdcjhmOSWm = (AudioClip)Resources.Load("Sound/GUI/missionBattle", typeof(AudioClip));
									if (10015 - 276238 == -266223)
									{
										this.qDFcjKqL1qK = (AudioClip)Resources.Load("Sound/GUI/missionCount", typeof(AudioClip));
										if (64779 - 227441 == -162662)
										{
											Hashtable customOpParameters = new Hashtable();
											if (9893 - 13710 == -3817)
											{
												this.IyOcjFIjkN9.OpCustom(52, customOpParameters, true);
												if (182136 - 61368 != 120769)
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

	// Token: 0x06007684 RID: 30340 RVA: 0x00FDF7AC File Offset: 0x00FDD9AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (25330 - 102930 != -77600)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (59126 - 476509 == -417383)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (295505 - 256999 == 38506)
				{
					Game.mGameState = eGameState.Setup;
					if (105371 - 575385 == -470014)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007685 RID: 30341 RVA: 0x00FDF850 File Offset: 0x00FDDA50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (213657 - 452318 != -238660)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (204301 - 320112 != -115810)
			{
				if (num == PlayerData.UID)
				{
					if (192001 - 449725 == -257724)
					{
						this.SetupActors();
						if (150296 - 358271 == -207975)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (24630 - 345381 != -320750)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007686 RID: 30342 RVA: 0x00FDF920 File Offset: 0x00FDDB20
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (215152 - 363098 != -147946)
		{
		}
		for (;;)
		{
			IL_41:
			Debug.Log("Creating Actors");
			if (281258 - 304995 == -23737)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (137541 - 325951 != -188409)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (96863 - 500439 != -403575)
						{
							int i = 0;
							if (262898 - 568235 == -305337)
							{
								CharacterControl[] array2 = array;
								if (228847 - 361702 != -132854)
								{
									int length = array2.Length;
									if (240650 - 181149 == 59501)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (69939 - 77709 == -7769)
											{
												goto IL_41;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (98483 - 63234 == 35250)
											{
												goto IL_41;
											}
											this.rSVcoenucCe++;
											if (86632 - 182467 == -95834)
											{
												goto IL_41;
											}
											i++;
											if (58693 - 43664 != 15029)
											{
												goto IL_41;
											}
										}
										if (111310 - 457892 == -346582)
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
						if (197370 - 55905 == 141465)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007687 RID: 30343 RVA: 0x00FDFB38 File Offset: 0x00FDDD38
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (1258 - 312838 != -311580)
		{
		}
		for (;;)
		{
			IL_3C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (20859 - 316112 != -295252)
			{
				int i = 0;
				if (55343 - 209813 == -154470)
				{
					CharacterControl[] array2 = array;
					if (220019 - 162746 != 57274)
					{
						int length = array2.Length;
						if (133852 - 472920 != -339067)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (175900 - 79315 == 96586)
								{
									goto IL_3C;
								}
								i++;
								if (236520 - 333167 != -96647)
								{
									goto IL_3C;
								}
							}
							if (103028 - 131713 != -28684)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007688 RID: 30344 RVA: 0x00FDFC68 File Offset: 0x00FDDE68
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (221391 - 477067 != -255676)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (159229 - 240022 != -80792)
			{
				hashtable.Add(43, PlayerData.UID);
				if (86307 - 486699 == -400392)
				{
					hashtable.Add(73, nType);
					if (175479 - 554260 == -378781)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (163851 - 560771 != -396919)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (184978 - 358376 == -173398)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (223378 - 550731 != -327352)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (86823 - 56806 != 30018)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (247158 - 108908 != 138251)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (148716 - 548013 == -399297)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (164902 - 483276 != -318373)
												{
													this.IyOcjFIjkN9.OpCustom(63, hashtable, true);
													if (173679 - 389010 == -215331)
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

	// Token: 0x06007689 RID: 30345 RVA: 0x00FDFF20 File Offset: 0x00FDE120
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (79471 - 225984 != -146513)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (286023 - 116453 != 169571)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (7516 - 243353 != -235836)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (220228 - 569698 != -349469)
						{
							if (this.rSVcoenucCe <= 0)
							{
								break;
							}
							if (54055 - 583754 != -529698)
							{
								this.rSVcoenucCe--;
								if (25937 - 141962 == -116025)
								{
									if (this.rSVcoenucCe != 0)
									{
										break;
									}
									if (46814 - 76804 != -29989)
									{
										Game.setGameState(eGameState.Ready);
										if (139749 - 463088 == -323339)
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
						if (243475 - 448782 == -205307)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (288545 - 58805 == 229740)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600768A RID: 30346 RVA: 0x00FE00B0 File Offset: 0x00FDE2B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x0600768B RID: 30347 RVA: 0x00FE00B4 File Offset: 0x00FDE2B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x0600768C RID: 30348 RVA: 0x00FE00B8 File Offset: 0x00FDE2B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (139941 - 37683 != 102259)
		{
		}
		while (Game.mGameState < eGameState.Ready)
		{
			if (191141 - 302183 == -111042)
			{
				Debug.Log("Game Ready");
				if (101147 - 109798 != -8650)
				{
					Game.mGameState = eGameState.Ready;
					if (62467 - 531939 == -469472)
					{
						int playerSlot = Game.getPlayerSlot(PlayerData.UID);
						if (276182 - 412058 != -135875)
						{
							if (231149 - 171079 == 60070)
							{
								if (playerSlot <= 1)
								{
									goto IL_8B;
								}
								if (187863 - 370640 != -182777)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_8B;
								}
								if (117432 - 449984 == -332551)
								{
									continue;
								}
								GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
								if (64187 - 595933 == -531745)
								{
									continue;
								}
								IL_12F:
								if (gameObject)
								{
									if (289913 - 102898 != 187015)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, (playerSlot - 1) % 2 + 1, gameObject.transform.position, gameObject.transform.forward);
									if (132687 - 385180 == -252492)
									{
										continue;
									}
								}
								if (playerSlot % 2 == 1)
								{
									if (169275 - 114653 != 54622)
									{
										continue;
									}
									Game.sendMissionEvent(2082, 1);
									if (137957 - 262825 != -124867)
									{
										break;
									}
									continue;
								}
								else
								{
									Game.sendMissionEvent(2082, 2);
									if (44641 - 364970 != -320328)
									{
										break;
									}
									continue;
								}
								IL_8B:
								gameObject = GameObject.Find("StartPoint1");
								if (1590 - 57541 == -55951)
								{
									goto IL_12F;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600768D RID: 30349 RVA: 0x00FE0314 File Offset: 0x00FDE514
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M208_DoubleDuel.$StartGame$38047(this).GetEnumerator();
	}

	// Token: 0x0600768E RID: 30350 RVA: 0x00FE0324 File Offset: 0x00FDE524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600768F RID: 30351 RVA: 0x00FE0328 File Offset: 0x00FDE528
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (56707 - 137502 != -80795)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (170120 - 448506 != -278385)
			{
				hashtable.Add(71, CID);
				if (133761 - 431828 == -298067)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (267480 - 419837 == -152357)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (134793 - 355069 == -220276)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (204468 - 553560 != -349091)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (96520 - 97341 == -821)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (99493 - 554537 == -455044)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (33542 - 294485 == -260943)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (111474 - 432155 != -320680)
											{
												this.IyOcjFIjkN9.OpCustom(61, hashtable, true);
												if (38004 - 300617 == -262613)
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

	// Token: 0x06007690 RID: 30352 RVA: 0x00FE05B4 File Offset: 0x00FDE7B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (24948 - 115364 != -90416)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (20157 - 197626 == -177469)
			{
				if (!gameObject)
				{
					break;
				}
				if (231532 - 185493 == 46039)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (195096 - 572514 == -377418)
					{
						playerCameraControl.target = gameObject;
						if (31610 - 242313 == -210703)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (226741 - 38884 == 187857)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007691 RID: 30353 RVA: 0x00FE06AC File Offset: 0x00FDE8AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (56765 - 238938 != -182172)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (102518 - 530660 == -428142)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (165648 - 16389 != 149260)
				{
					gameGui.ResetTeamBar();
					if (78360 - 69741 == 8619)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007692 RID: 30354 RVA: 0x00FE0758 File Offset: 0x00FDE958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M208_DoubleDuel.$onDeadPlayer$38052(this).GetEnumerator();
	}

	// Token: 0x06007693 RID: 30355 RVA: 0x00FE0768 File Offset: 0x00FDE968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (268285 - 440968 != -172683)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (299103 - 235361 == 63742)
			{
				if (Game.mPlayer)
				{
					if (172603 - 330286 != -157683)
					{
						continue;
					}
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (86347 - 350300 != -263953)
					{
						continue;
					}
					if (characterControl)
					{
						if (211368 - 323752 == -112383)
						{
							continue;
						}
						if (characterControl.mOriginalLayer == 8)
						{
							if (57094 - 272193 != -215099)
							{
								continue;
							}
							Game.sendMissionEvent(2082, 1);
							if (221477 - 183941 != 37536)
							{
								continue;
							}
						}
						else
						{
							Game.sendMissionEvent(2082, 2);
							if (87192 - 6809 == 80384)
							{
								continue;
							}
						}
					}
				}
				PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
				if (83909 - 116575 == -32666)
				{
					playerCameraControl.target = Game.mPlayer;
					if (109426 - 471802 != -362375)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (97235 - 30545 == 66691)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (38937 - 433501 != -394564)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (238064 - 136748 == 101316)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (61046 - 491530 != -430483)
							{
								if (!gameGui)
								{
									break;
								}
								if (215368 - 145231 != 70138)
								{
									gameGui.enabled = true;
									if (100261 - 381251 != -280989)
									{
										gameGui.closeDeadMenu();
										if (257462 - 595047 != -337584)
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

	// Token: 0x06007694 RID: 30356 RVA: 0x00FE0A10 File Offset: 0x00FDEC10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (81986 - 384481 != -302495)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (169634 - 234728 == -65094)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (91381 - 500372 == -408991)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (118769 - 587734 == -468965)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007695 RID: 30357 RVA: 0x00FE0AD4 File Offset: 0x00FDECD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (111293 - 22817 != 88476)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
			{
				if (254052 - 161354 != 92699)
				{
					Game.mGameState = eGameState.Ended;
					if (107373 - 503708 == -396335)
					{
						break;
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.AllHold;
				if (259935 - 317811 != -57875)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06007696 RID: 30358 RVA: 0x00FE0B8C File Offset: 0x00FDED8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M208_DoubleDuel.$ReturnToTown$38059(this).GetEnumerator();
	}

	// Token: 0x06007697 RID: 30359 RVA: 0x00FE0B9C File Offset: 0x00FDED9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M208_DoubleDuel.$ReturnToGuild$38064(this).GetEnumerator();
	}

	// Token: 0x06007698 RID: 30360 RVA: 0x00FE0BAC File Offset: 0x00FDEDAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M208_DoubleDuel.$ReturnToCamp$38068(this).GetEnumerator();
	}

	// Token: 0x06007699 RID: 30361 RVA: 0x00FE0BBC File Offset: 0x00FDEDBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (209900 - 379587 != -169687)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (64985 - 262125 != -197139)
			{
				Hashtable hashtable = new Hashtable();
				if (53025 - 436616 != -383590)
				{
					hashtable.Add(43, PlayerData.UID);
					if (256186 - 26392 != 229795)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (98532 - 249194 == -150662)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600769A RID: 30362 RVA: 0x00FE0C94 File Offset: 0x00FDEE94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600769B RID: 30363 RVA: 0x00FE0CA8 File Offset: 0x00FDEEA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (239855 - 455437 != -215581)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (5187 - 382886 != -377698)
			{
				Hashtable hashtable = new Hashtable();
				if (288208 - 364168 == -75960)
				{
					if (Game.mNextGameCode == 30)
					{
						if (125374 - 73516 != 51858)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (66028 - 416924 != -350896)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (101933 - 408673 == -306739)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (53569 - 391667 == -338097)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (109652 - 457719 != -348067)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (282702 - 83941 != 198761)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (154185 - 358156 != -203971)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (193845 - 429059 == -235213)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (151032 - 276064 != -125032)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (185042 - 52728 == 132315)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (91477 - 551301 == -459823)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (68116 - 21824 == 46293)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (139088 - 181467 == -42378)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (62926 - 452364 == -389437)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (55338 - 333619 != -278281)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (125231 - 308748 == -183516)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (120334 - 538129 != -417795)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (17255 - 45095 != -27840)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (18862 - 494074 == -475211)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (291666 - 107805 == 183862)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (8122 - 530330 != -522208)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (115687 - 52064 == 63624)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (206301 - 37948 != 168353)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (160529 - 233036 != -72507)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (358 - 245955 != -245597)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (105917 - 93966 == 11952)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (103682 - 42727 != 60955)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (230944 - 194143 != 36801)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (224374 - 560729 == -336355)
					{
						this.IyOcjFIjkN9.OpCustom(42, hashtable, true);
						if (88445 - 183607 != -95161)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600769C RID: 30364 RVA: 0x00FE125C File Offset: 0x00FDF45C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600769D RID: 30365 RVA: 0x00FE126C File Offset: 0x00FDF46C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600769E RID: 30366 RVA: 0x00FE1270 File Offset: 0x00FDF470
	internal static bool rtfXR2pDMARVVe2loLSJ()
	{
		return true;
	}

	// Token: 0x0600769F RID: 30367 RVA: 0x00FE1274 File Offset: 0x00FDF474
	internal static bool yBZ055pDxqItvfoYYUJA()
	{
		return false;
	}

	// Token: 0x04007AB1 RID: 31409
	private LitePeer IyOcjFIjkN9;

	// Token: 0x04007AB2 RID: 31410
	private PlayerCameraControl zB5cjAZvtBG;

	// Token: 0x04007AB3 RID: 31411
	private float XTDcj9yrovg;

	// Token: 0x04007AB4 RID: 31412
	private Texture oV6cjWB3d6v;

	// Token: 0x04007AB5 RID: 31413
	private Texture YyccjuI35VX;

	// Token: 0x04007AB6 RID: 31414
	private Texture VwscjyIL3Ku;

	// Token: 0x04007AB7 RID: 31415
	private Texture O1DcjVvwnMl;

	// Token: 0x04007AB8 RID: 31416
	private AudioClip hYdcjhmOSWm;

	// Token: 0x04007AB9 RID: 31417
	private AudioClip qDFcjKqL1qK;

	// Token: 0x04007ABA RID: 31418
	private int Ucocjz2TWaL;

	// Token: 0x04007ABB RID: 31419
	private int Vu9co5OJSZy;

	// Token: 0x04007ABC RID: 31420
	private int taCcocyfGMd;

	// Token: 0x04007ABD RID: 31421
	private int OJhconsVfqu;

	// Token: 0x04007ABE RID: 31422
	private int FA4coQ8hAFv;

	// Token: 0x04007ABF RID: 31423
	private int rSVcoenucCe;

	// Token: 0x0200140C RID: 5132
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartMatch$38044 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060076A0 RID: 30368 RVA: 0x00FE1278 File Offset: 0x00FDF478
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartMatch$38044(M208_DoubleDuel self_)
		{
			if (19143 - 286449 != -267306)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (116251 - 455398 == -339147)
				{
					base..ctor();
					if (251972 - 97940 != 154033)
					{
						this.$self_$38046 = self_;
						if (189336 - 197331 == -7995)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x00FE1310 File Offset: 0x00FDF510
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M208_DoubleDuel.$StartMatch$38044.$(this.$self_$38046);
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x00FE1320 File Offset: 0x00FDF520
		internal static bool inq0KPpDgcgZgo0EaB9X()
		{
			return true;
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x00FE1324 File Offset: 0x00FDF524
		internal static bool R4C3VmpDfWKbBpl0cM8l()
		{
			return false;
		}

		// Token: 0x04007AC0 RID: 31424
		internal M208_DoubleDuel $self_$38046;

		// Token: 0x0200140D RID: 5133
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060076A4 RID: 30372 RVA: 0x00FE1328 File Offset: 0x00FDF528
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M208_DoubleDuel self_)
			{
				if (272084 - 587068 != -314983)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (184515 - 64193 != 120323)
					{
						base..ctor();
						if (4783 - 131340 != -126556)
						{
							this.$self_$38045 = self_;
							if (53196 - 303144 != -249947)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060076A5 RID: 30373 RVA: 0x00FE13C0 File Offset: 0x00FDF5C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (295075 - 340612 != -45537)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_527;
					case 1:
						goto IL_5B4;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (24204 - 571042 != -546837)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							if (!this.$self_$38045.qDFcjKqL1qK)
							{
								goto IL_3DE;
							}
							if (101826 - 296396 == -194569)
							{
								continue;
							}
							this.$self_$38045.audio.PlayOneShot(this.$self_$38045.qDFcjKqL1qK);
							if (170143 - 537801 != -367658)
							{
								continue;
							}
							goto IL_3DE;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (255993 - 472060 != -216066)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							if (!this.$self_$38045.qDFcjKqL1qK)
							{
								goto IL_155;
							}
							if (182315 - 497938 != -315623)
							{
								continue;
							}
							this.$self_$38045.audio.PlayOneShot(this.$self_$38045.qDFcjKqL1qK);
							if (293497 - 587909 != -294411)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (179036 - 581950 != -402914)
							{
								continue;
							}
							goto IL_419;
						}
						else
						{
							if (!this.$self_$38045.qDFcjKqL1qK)
							{
								goto IL_2D5;
							}
							if (77235 - 528420 != -451185)
							{
								continue;
							}
							this.$self_$38045.audio.PlayOneShot(this.$self_$38045.qDFcjKqL1qK);
							if (183810 - 374066 != -190255)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (228411 - 336815 != -108404)
							{
								continue;
							}
							goto IL_4B8;
						}
						else if (Game.mGameState != eGameState.Start)
						{
							if (296149 - 274952 != 21197)
							{
								continue;
							}
							goto IL_1EE;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (273906 - 379087 == -105180)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (146844 - 177929 == -31084)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (51829 - 85550 == -33720)
							{
								continue;
							}
							if (this.$self_$38045.hYdcjhmOSWm)
							{
								if (282892 - 34153 == 248740)
								{
									continue;
								}
								this.$self_$38045.audio.PlayOneShot(this.$self_$38045.hYdcjhmOSWm);
								if (21878 - 501547 == -479668)
								{
									continue;
								}
							}
							this.$self_$38045.SendMessage("newGameMessage", "Match has started!");
							if (54265 - 228866 == -174600)
							{
								continue;
							}
							Chat.SubmitChat("none", "Match has started!", eChatType.system, eChatMode.system);
							if (225656 - 369613 != -143956)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$38045.Vu9co5OJSZy != 0)
						{
							if (218042 - 162 != 217880)
							{
								continue;
							}
							if (this.$self_$38045.taCcocyfGMd != 0)
							{
								break;
							}
							if (67617 - 4923 == 62695)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.AllHold;
						if (52941 - 337336 != -284395)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (19419 - 199699 == -180279)
						{
							continue;
						}
						this.$self_$38045.SendMessage("newGameMessage", "Match cancelled: opponent not found!");
						if (115856 - 527464 != -411608)
						{
							continue;
						}
						Chat.SubmitChat("none", "Match cancelled: opponent not found!", eChatType.system, eChatMode.system);
						if (17928 - 311646 != -293717)
						{
							goto Block_22;
						}
						continue;
					case 7:
						this.$self_$38045.StartCoroutine_Auto(this.$self_$38045.ReturnToTown());
						if (40596 - 183659 == -143062)
						{
							continue;
						}
						break;
					default:
						if (44018 - 444816 != -400797)
						{
							goto IL_527;
						}
						continue;
					}
					this.YieldDefault(1);
					if (143657 - 287343 != -143685)
					{
						break;
					}
					continue;
					IL_527:
					Debug.Log("Starting Match");
					if (9348 - 381429 == -372081)
					{
						Game.mGameState = eGameState.Start;
						if (290467 - 81659 != 208809)
						{
							Game.mStateTime = Time.time;
							if (225754 - 512411 != -286656)
							{
								goto Block_29;
							}
						}
					}
				}
				Block_5:
				goto IL_5B4;
				Block_8:
				return this.Yield(6, new WaitForSeconds(3f));
				goto IL_5B4;
				Block_10:
				goto IL_2D5;
				IL_155:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_1EE:
				goto IL_5B4;
				Block_22:
				return this.Yield(7, new WaitForSeconds(2f));
				IL_2D5:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_25:
				goto IL_155;
				Block_29:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DE:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_31:
				IL_419:
				IL_4B8:
				IL_5B4:
				return false;
			}

			// Token: 0x060076A6 RID: 30374 RVA: 0x00FE1994 File Offset: 0x00FDFB94
			internal static bool McHeYGpDnpu6nrpht3X1()
			{
				return true;
			}

			// Token: 0x060076A7 RID: 30375 RVA: 0x00FE1998 File Offset: 0x00FDFB98
			internal static bool esOooWpD600uSLGyidLe()
			{
				return false;
			}

			// Token: 0x04007AC1 RID: 31425
			internal M208_DoubleDuel $self_$38045;
		}
	}

	// Token: 0x0200140E RID: 5134
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38047 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060076A8 RID: 30376 RVA: 0x00FE199C File Offset: 0x00FDFB9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38047(M208_DoubleDuel self_)
		{
			if (148034 - 461473 != -313439)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (60976 - 523778 != -462801)
				{
					base..ctor();
					if (273944 - 374762 != -100817)
					{
						this.$self_$38051 = self_;
						if (6689 - 568145 == -561456)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x00FE1A34 File Offset: 0x00FDFC34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M208_DoubleDuel.$StartGame$38047.$(this.$self_$38051);
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x00FE1A44 File Offset: 0x00FDFC44
		internal static bool N38MNYpDiqO3j9KpyfLH()
		{
			return true;
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x00FE1A48 File Offset: 0x00FDFC48
		internal static bool FImDQUpDKYpTrsWbnEQW()
		{
			return false;
		}

		// Token: 0x04007AC2 RID: 31426
		internal M208_DoubleDuel $self_$38051;

		// Token: 0x0200140F RID: 5135
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060076AC RID: 30380 RVA: 0x00FE1A4C File Offset: 0x00FDFC4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M208_DoubleDuel self_)
			{
				if (238600 - 391385 != -152784)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (85867 - 215360 == -129493)
					{
						base..ctor();
						if (13394 - 269851 != -256456)
						{
							this.$self_$38050 = self_;
							if (7443 - 292933 != -285489)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060076AD RID: 30381 RVA: 0x00FE1AE4 File Offset: 0x00FDFCE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (82922 - 514267 != -431345)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_355;
					case 2:
						this.$self_$38050.zB5cjAZvtBG.StartCoroutine_Auto(this.$self_$38050.zB5cjAZvtBG.slerpToObject("StartCamera" + this.$slot$38048, (float)3));
						if (197792 - 441682 != -243889)
						{
							goto Block_2;
						}
						continue;
					case 3:
						this.$mGameGui$38049 = (GameGui)this.$self_$38050.GetComponent(typeof(GameGui));
						if (284951 - 60764 == 224188)
						{
							continue;
						}
						this.$mGameGui$38049.enabled = true;
						if (187630 - 53991 == 133640)
						{
							continue;
						}
						this.$self_$38050.zB5cjAZvtBG.enabled = true;
						if (270561 - 381713 != -111151)
						{
							goto Block_14;
						}
						continue;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (127341 - 328139 != -200798)
							{
								continue;
							}
							goto IL_232;
						}
						else
						{
							if (this.$self_$38050.Ucocjz2TWaL < 1)
							{
								if (169648 - 407610 != -237962)
								{
									continue;
								}
								Game.sendMissionEvent(2081, 0);
								if (133578 - 455720 == -322141)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (22672 - 317760 != -295087)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					default:
						if (291273 - 397182 == -105908)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (129319 - 589857 != -460537)
					{
						Game.mGameState = eGameState.Start;
						if (112906 - 522986 == -410080)
						{
							Game.mStateTime = Time.time;
							if (165084 - 102579 != 62506)
							{
								this.$slot$38048 = Game.getPlayerSlot(PlayerData.UID);
								if (111781 - 99563 == 12218)
								{
									if (this.$slot$38048 % 2 == 1)
									{
										if (40475 - 238159 == -197683)
										{
											continue;
										}
										this.$self_$38050.zB5cjAZvtBG.alignToObject("TeamCamera1");
										if (192415 - 471379 != -278964)
										{
											continue;
										}
									}
									else
									{
										this.$self_$38050.zB5cjAZvtBG.alignToObject("TeamCamera2");
										if (236640 - 533763 == -297122)
										{
											continue;
										}
									}
									this.$self_$38050.SendMessage("fadeIn");
									if (160637 - 127013 == 33624)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_2:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_13:
				goto IL_355;
				Block_14:
				return this.Yield(4, new WaitForSeconds(2f));
				IL_232:
				IL_355:
				return false;
			}

			// Token: 0x060076AE RID: 30382 RVA: 0x00FE1E58 File Offset: 0x00FE0058
			internal static bool Hq5yExpDd0tsQtf9bTQA()
			{
				return true;
			}

			// Token: 0x060076AF RID: 30383 RVA: 0x00FE1E5C File Offset: 0x00FE005C
			internal static bool A7nt9gpDJKGVhMkogUC6()
			{
				return false;
			}

			// Token: 0x04007AC3 RID: 31427
			internal int $slot$38048;

			// Token: 0x04007AC4 RID: 31428
			internal GameGui $mGameGui$38049;

			// Token: 0x04007AC5 RID: 31429
			internal M208_DoubleDuel $self_$38050;
		}
	}

	// Token: 0x02001410 RID: 5136
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38052 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060076B0 RID: 30384 RVA: 0x00FE1E60 File Offset: 0x00FE0060
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38052(M208_DoubleDuel self_)
		{
			if (99408 - 268810 != -169401)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (199483 - 224048 != -24564)
				{
					base..ctor();
					if (159103 - 530250 == -371147)
					{
						this.$self_$38058 = self_;
						if (202251 - 30348 != 171904)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060076B1 RID: 30385 RVA: 0x00FE1EF8 File Offset: 0x00FE00F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M208_DoubleDuel.$onDeadPlayer$38052.$(this.$self_$38058);
		}

		// Token: 0x060076B2 RID: 30386 RVA: 0x00FE1F08 File Offset: 0x00FE0108
		internal static bool o14UFFpDDNd8pVgYpERy()
		{
			return true;
		}

		// Token: 0x060076B3 RID: 30387 RVA: 0x00FE1F0C File Offset: 0x00FE010C
		internal static bool DecXm9pDvXINRLZGdBWp()
		{
			return false;
		}

		// Token: 0x04007AC6 RID: 31430
		internal M208_DoubleDuel $self_$38058;

		// Token: 0x02001411 RID: 5137
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060076B4 RID: 30388 RVA: 0x00FE1F10 File Offset: 0x00FE0110
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M208_DoubleDuel self_)
			{
				if (131278 - 345084 != -213805)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (111397 - 67673 != 43725)
					{
						base..ctor();
						if (247199 - 572718 != -325518)
						{
							this.$self_$38057 = self_;
							if (51552 - 275288 != -223735)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060076B5 RID: 30389 RVA: 0x00FE1FA8 File Offset: 0x00FE01A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (221017 - 94522 != 126496)
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
							goto IL_2A1;
						}
						if (94811 - 435232 != -340421)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (50606 - 162651 != -112044)
							{
								goto IL_2A1;
							}
							continue;
						}
						IL_1F4:
						this.YieldDefault(1);
						if (62036 - 99266 != -37230)
						{
							continue;
						}
						goto IL_3FF;
						IL_2A1:
						Game.mGameState = eGameState.Hold;
						if (189439 - 571706 == -382266)
						{
							continue;
						}
						this.$mStoryGui$38054 = (StoryGui)this.$self_$38057.GetComponent(typeof(StoryGui));
						if (176259 - 25347 != 150912)
						{
							continue;
						}
						if (this.$mStoryGui$38054)
						{
							if (184691 - 171619 != 13072)
							{
								continue;
							}
							this.$mStoryGui$38054.close();
							if (277896 - 385675 != -107779)
							{
								continue;
							}
						}
						this.$mChangeGui$38055 = (ChangeGui)this.$self_$38057.GetComponent(typeof(ChangeGui));
						if (210248 - 159660 == 50589)
						{
							continue;
						}
						if (this.$mChangeGui$38055)
						{
							if (99103 - 401002 != -301899)
							{
								continue;
							}
							this.$mChangeGui$38055.close();
							if (12846 - 499075 == -486228)
							{
								continue;
							}
						}
						this.$mGameGui$38056 = (GameGui)this.$self_$38057.GetComponent(typeof(GameGui));
						if (1382 - 431446 != -430064)
						{
							continue;
						}
						if (!this.$mGameGui$38056)
						{
							goto IL_1F4;
						}
						if (257270 - 424683 != -167413)
						{
							continue;
						}
						if (!this.$mGameGui$38056.enabled)
						{
							if (15592 - 361656 != -346064)
							{
								continue;
							}
							this.$mGameGui$38056.enabled = true;
							if (153291 - 598329 != -445038)
							{
								continue;
							}
						}
						this.$mGameGui$38056.openDeadMenu();
						if (256021 - 76544 != 179478)
						{
							goto IL_1F4;
						}
						continue;
					default:
						if (64566 - 163034 != -98468)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (25552 - 537379 == -511827)
					{
						if (!Game.mPlayer)
						{
							break;
						}
						if (61578 - 188441 == -126863)
						{
							this.$mPlayerChar$38053 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (252909 - 307158 == -54249)
							{
								if (!this.$mPlayerChar$38053)
								{
									break;
								}
								if (79335 - 42442 == 36893)
								{
									if (this.$mPlayerChar$38053.mOriginalLayer == 8)
									{
										if (48964 - 570915 == -521951)
										{
											Game.sendMissionEvent(2083, 1);
											if (264741 - 330645 != -65903)
											{
												break;
											}
										}
									}
									else
									{
										Game.sendMissionEvent(2083, 2);
										if (29434 - 424620 == -395186)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_3FF:
				return false;
			}

			// Token: 0x060076B6 RID: 30390 RVA: 0x00FE23C8 File Offset: 0x00FE05C8
			internal static bool hfFCWupDRaqrKlhjO8bc()
			{
				return true;
			}

			// Token: 0x060076B7 RID: 30391 RVA: 0x00FE23CC File Offset: 0x00FE05CC
			internal static bool d5rBNNpDw8l6BSgdZIcX()
			{
				return false;
			}

			// Token: 0x04007AC7 RID: 31431
			internal CharacterControl $mPlayerChar$38053;

			// Token: 0x04007AC8 RID: 31432
			internal StoryGui $mStoryGui$38054;

			// Token: 0x04007AC9 RID: 31433
			internal ChangeGui $mChangeGui$38055;

			// Token: 0x04007ACA RID: 31434
			internal GameGui $mGameGui$38056;

			// Token: 0x04007ACB RID: 31435
			internal M208_DoubleDuel $self_$38057;
		}
	}

	// Token: 0x02001412 RID: 5138
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38059 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060076B8 RID: 30392 RVA: 0x00FE23D0 File Offset: 0x00FE05D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38059(M208_DoubleDuel self_)
		{
			if (211039 - 55484 != 155556)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (186916 - 363501 == -176585)
				{
					base..ctor();
					if (83265 - 512268 == -429003)
					{
						this.$self_$38063 = self_;
						if (185799 - 423181 == -237382)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060076B9 RID: 30393 RVA: 0x00FE2468 File Offset: 0x00FE0668
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M208_DoubleDuel.$ReturnToTown$38059.$(this.$self_$38063);
		}

		// Token: 0x060076BA RID: 30394 RVA: 0x00FE2478 File Offset: 0x00FE0678
		internal static bool MGuSPLpDqNnOySgiLi5B()
		{
			return true;
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x00FE247C File Offset: 0x00FE067C
		internal static bool gU5uJgpD7ntY8ts5Iqtm()
		{
			return false;
		}

		// Token: 0x04007ACC RID: 31436
		internal M208_DoubleDuel $self_$38063;

		// Token: 0x02001413 RID: 5139
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060076BC RID: 30396 RVA: 0x00FE2480 File Offset: 0x00FE0680
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M208_DoubleDuel self_)
			{
				if (52535 - 407731 != -355196)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (136004 - 594543 != -458538)
					{
						base..ctor();
						if (269757 - 540640 == -270883)
						{
							this.$self_$38062 = self_;
							if (280689 - 307103 != -26413)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060076BD RID: 30397 RVA: 0x00FE2518 File Offset: 0x00FE0718
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (9669 - 378229 != -368559)
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
						this.$self_$38062.LeaveGame();
						if (240741 - 132676 == 108066)
						{
							continue;
						}
						this.YieldDefault(1);
						if (120948 - 519324 != -398375)
						{
							goto Block_28;
						}
						continue;
					default:
						if (174386 - 373898 == -199511)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (73681 - 489369 != -415687)
					{
						Game.mStateTime = Time.time;
						if (81497 - 311298 != -229800)
						{
							this.$$switch$6536$38060 = PlayerData.SaveGuild;
							if (160059 - 354786 != -194726)
							{
								if (this.$$switch$6536$38060 == 1)
								{
									if (169495 - 424287 != -254792)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (221932 - 140158 == 81775)
									{
										continue;
									}
								}
								else if (this.$$switch$6536$38060 == 2)
								{
									if (121483 - 497035 != -375552)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (148700 - 175284 != -26584)
									{
										continue;
									}
								}
								else if (this.$$switch$6536$38060 == 3)
								{
									if (208367 - 562441 == -354073)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (130521 - 404739 != -274218)
									{
										continue;
									}
								}
								else if (this.$$switch$6536$38060 == 4)
								{
									if (224050 - 502605 != -278555)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (88714 - 265348 != -176634)
									{
										continue;
									}
								}
								else if (this.$$switch$6536$38060 == 5)
								{
									if (250369 - 1243 == 249127)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (156207 - 229197 != -72990)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (180699 - 295424 == -114724)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (137827 - 291309 == -153481)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (298167 - 257530 == 40638)
									{
										continue;
									}
								}
								this.$mGameGui$38061 = (GameGui)this.$self_$38062.GetComponent(typeof(GameGui));
								if (16922 - 329961 != -313038)
								{
									if (this.$mGameGui$38061)
									{
										if (247428 - 213211 != 34217)
										{
											continue;
										}
										this.$mGameGui$38061.close();
										if (52388 - 530933 != -478545)
										{
											continue;
										}
									}
									this.$self_$38062.SendMessage("fadeOut");
									if (66034 - 428240 != -362205)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_28:
				IL_3AD:
				return false;
			}

			// Token: 0x060076BE RID: 30398 RVA: 0x00FE28E4 File Offset: 0x00FE0AE4
			internal static bool SbbrZppDPRZp6Hl6Fj55()
			{
				return true;
			}

			// Token: 0x060076BF RID: 30399 RVA: 0x00FE28E8 File Offset: 0x00FE0AE8
			internal static bool e7lfPlpD0g20WbE5j7ch()
			{
				return false;
			}

			// Token: 0x04007ACD RID: 31437
			internal int $$switch$6536$38060;

			// Token: 0x04007ACE RID: 31438
			internal GameGui $mGameGui$38061;

			// Token: 0x04007ACF RID: 31439
			internal M208_DoubleDuel $self_$38062;
		}
	}

	// Token: 0x02001414 RID: 5140
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38064 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060076C0 RID: 30400 RVA: 0x00FE28EC File Offset: 0x00FE0AEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38064(M208_DoubleDuel self_)
		{
			if (142099 - 47181 != 94918)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179990 - 566597 != -386606)
				{
					base..ctor();
					if (25702 - 116660 == -90958)
					{
						this.$self_$38067 = self_;
						if (136921 - 49041 != 87881)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x00FE2984 File Offset: 0x00FE0B84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M208_DoubleDuel.$ReturnToGuild$38064.$(this.$self_$38067);
		}

		// Token: 0x060076C2 RID: 30402 RVA: 0x00FE2994 File Offset: 0x00FE0B94
		internal static bool xOBNcKpDbXp4Cvu0x06Y()
		{
			return true;
		}

		// Token: 0x060076C3 RID: 30403 RVA: 0x00FE2998 File Offset: 0x00FE0B98
		internal static bool rUSKI6pDu1c1OvM7fNHA()
		{
			return false;
		}

		// Token: 0x04007AD0 RID: 31440
		internal M208_DoubleDuel $self_$38067;

		// Token: 0x02001415 RID: 5141
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060076C4 RID: 30404 RVA: 0x00FE299C File Offset: 0x00FE0B9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M208_DoubleDuel self_)
			{
				if (225183 - 470107 != -244923)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (84502 - 472630 != -388127)
					{
						base..ctor();
						if (17238 - 365064 == -347826)
						{
							this.$self_$38066 = self_;
							if (33728 - 442165 != -408436)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060076C5 RID: 30405 RVA: 0x00FE2A34 File Offset: 0x00FE0C34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (111809 - 536919 != -425110)
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
						this.$self_$38066.LeaveGame();
						if (16925 - 554818 == -537892)
						{
							continue;
						}
						this.YieldDefault(1);
						if (243250 - 177499 != 65751)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (157507 - 339817 != -182310)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (294249 - 155078 == 139171)
					{
						Game.mStateTime = Time.time;
						if (79098 - 13615 != 65484)
						{
							Game.mNextGameCode = 31;
							if (11360 - 416697 != -405336)
							{
								this.$mGameGui$38065 = (GameGui)this.$self_$38066.GetComponent(typeof(GameGui));
								if (187918 - 88712 == 99206)
								{
									if (this.$mGameGui$38065)
									{
										if (180769 - 529487 != -348718)
										{
											continue;
										}
										this.$mGameGui$38065.close();
										if (256248 - 183291 == 72958)
										{
											continue;
										}
									}
									this.$self_$38066.SendMessage("fadeOut");
									if (137488 - 594885 == -457397)
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

			// Token: 0x060076C6 RID: 30406 RVA: 0x00FE2C10 File Offset: 0x00FE0E10
			internal static bool iuvxnypDIvvCaOaKp529()
			{
				return true;
			}

			// Token: 0x060076C7 RID: 30407 RVA: 0x00FE2C14 File Offset: 0x00FE0E14
			internal static bool AsKUNopDBMs7TkUmrnJS()
			{
				return false;
			}

			// Token: 0x04007AD1 RID: 31441
			internal GameGui $mGameGui$38065;

			// Token: 0x04007AD2 RID: 31442
			internal M208_DoubleDuel $self_$38066;
		}
	}

	// Token: 0x02001416 RID: 5142
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38068 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060076C8 RID: 30408 RVA: 0x00FE2C18 File Offset: 0x00FE0E18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38068(M208_DoubleDuel self_)
		{
			if (28662 - 294669 != -266006)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (239049 - 284794 != -45744)
				{
					base..ctor();
					if (42412 - 15763 == 26649)
					{
						this.$self_$38072 = self_;
						if (138153 - 507318 != -369164)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060076C9 RID: 30409 RVA: 0x00FE2CB0 File Offset: 0x00FE0EB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M208_DoubleDuel.$ReturnToCamp$38068.$(this.$self_$38072);
		}

		// Token: 0x060076CA RID: 30410 RVA: 0x00FE2CC0 File Offset: 0x00FE0EC0
		internal static bool ufSLZepDedN1TCM6xgAp()
		{
			return true;
		}

		// Token: 0x060076CB RID: 30411 RVA: 0x00FE2CC4 File Offset: 0x00FE0EC4
		internal static bool ehKg4ApDrcbw0V8OZje3()
		{
			return false;
		}

		// Token: 0x04007AD3 RID: 31443
		internal M208_DoubleDuel $self_$38072;

		// Token: 0x02001417 RID: 5143
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060076CC RID: 30412 RVA: 0x00FE2CC8 File Offset: 0x00FE0EC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M208_DoubleDuel self_)
			{
				if (256761 - 181139 != 75622)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (216714 - 413529 == -196815)
					{
						base..ctor();
						if (60691 - 586944 == -526253)
						{
							this.$self_$38071 = self_;
							if (273850 - 323060 == -49210)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060076CD RID: 30413 RVA: 0x00FE2D60 File Offset: 0x00FE0F60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (114681 - 134504 != -19822)
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
						this.$self_$38071.LeaveGame();
						if (271451 - 275433 != -3982)
						{
							continue;
						}
						this.YieldDefault(1);
						if (267471 - 73575 != 193896)
						{
							continue;
						}
						goto IL_363;
					default:
						if (19607 - 348942 != -329335)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (197585 - 234259 == -36674)
					{
						Game.mStateTime = Time.time;
						if (208810 - 457903 == -249093)
						{
							this.$$switch$6538$38069 = PlayerData.SaveGuild;
							if (76819 - 321890 != -245070)
							{
								if (this.$$switch$6538$38069 == 1)
								{
									if (155423 - 410616 != -255193)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (89863 - 483944 != -394081)
									{
										continue;
									}
								}
								else if (this.$$switch$6538$38069 == 2)
								{
									if (32775 - 78815 != -46040)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (97487 - 577033 == -479545)
									{
										continue;
									}
								}
								else if (this.$$switch$6538$38069 == 3)
								{
									if (203890 - 288474 != -84584)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (67951 - 263158 == -195206)
									{
										continue;
									}
								}
								else if (this.$$switch$6538$38069 == 4)
								{
									if (95378 - 325505 != -230127)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (190555 - 560540 != -369985)
									{
										continue;
									}
								}
								else if (this.$$switch$6538$38069 == 5)
								{
									if (280202 - 352267 == -72064)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (72566 - 27174 == 45393)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (53490 - 271514 != -218024)
									{
										continue;
									}
								}
								this.$mGameGui$38070 = (GameGui)this.$self_$38071.GetComponent(typeof(GameGui));
								if (239153 - 471709 == -232556)
								{
									if (this.$mGameGui$38070)
									{
										if (77327 - 44278 == 33050)
										{
											continue;
										}
										this.$mGameGui$38070.close();
										if (196006 - 13033 != 182973)
										{
											continue;
										}
									}
									this.$self_$38071.SendMessage("fadeOut");
									if (84203 - 567919 != -483715)
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

			// Token: 0x060076CE RID: 30414 RVA: 0x00FE30E4 File Offset: 0x00FE12E4
			internal static bool jsxFxNpDjvYUmC2ZAjwg()
			{
				return true;
			}

			// Token: 0x060076CF RID: 30415 RVA: 0x00FE30E8 File Offset: 0x00FE12E8
			internal static bool vc9Yk8pDhWCa8EPs0QoL()
			{
				return false;
			}

			// Token: 0x04007AD4 RID: 31444
			internal int $$switch$6538$38069;

			// Token: 0x04007AD5 RID: 31445
			internal GameGui $mGameGui$38070;

			// Token: 0x04007AD6 RID: 31446
			internal M208_DoubleDuel $self_$38071;
		}
	}
}
