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

// Token: 0x0200156D RID: 5485
[Serializable]
public class M408_DesertSurvival : MonoBehaviour
{
	// Token: 0x06007F0D RID: 32525 RVA: 0x010579D8 File Offset: 0x01055BD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M408_DesertSurvival()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007F0E RID: 32526 RVA: 0x010579E8 File Offset: 0x01055BE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (195316 - 284278 != -88961)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (71437 - 452719 == -381282)
			{
				Game.mGameType = 5;
				if (234503 - 210281 == 24222)
				{
					if (Chat.Initialized)
					{
						if (5036 - 103732 == -98696)
						{
							Chat.ChatDisplay.Clear();
							if (147036 - 62713 == 84323)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (97853 - 550010 != -452156)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F0F RID: 32527 RVA: 0x01057ACC File Offset: 0x01055CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (254127 - 558734 != -304606)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (90900 - 157230 != -66329)
				{
					Game.nextGame();
					if (139495 - 415210 == -275715)
					{
						Game.mGameCode = 408;
						if (259944 - 532066 != -272121)
						{
							Game.mGameType = 5;
							if (98801 - 16339 != 82463)
							{
								Game.mGameTime = Time.time;
								if (272718 - 467887 == -195169)
								{
									Game.mGameScore = 0;
									if (177316 - 448381 != -271064)
									{
										Game.mGameMana = 0;
										if (129977 - 309215 != -179237)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (221181 - 308491 != -87309)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (99480 - 18573 != 80908)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (261585 - 349670 != -88084)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (199122 - 426094 == -226972)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (86298 - 433091 == -346793)
															{
																this.Xe5cAGhjWY1 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (191271 - 477281 != -286009)
																{
																	this.Tn5cAlAjWFM = PhotonClient.Connection;
																	if (214162 - 398933 != -184770)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (154957 - 130094 != 24864)
																		{
																			this.InitGame();
																			if (111540 - 29118 != 82423)
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
				if (282088 - 519750 != -237661)
				{
					Game.mGameType = 99;
					if (100210 - 66925 == 33285)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007F10 RID: 32528 RVA: 0x01057DAC File Offset: 0x01055FAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (243146 - 190263 != 52884)
		{
		}
		for (;;)
		{
			if (this.Tn5cAlAjWFM == null)
			{
				if (269835 - 473263 != -203427)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (234633 - 142204 == 92429)
				{
					if (mGameState == eGameState.Init)
					{
						if (65302 - 138515 == -73213)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (8523 - 592254 != -583730)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (204935 - 359152 != -154216)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (163358 - 83663 == 79695)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (165822 - 125303 != 40520)
						{
							if (Game.music != 0)
							{
								if (102409 - 508628 != -406219)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (185262 - 504968 == -319705)
									{
										continue;
									}
									this.audio.Play();
									if (97049 - 278889 == -181839)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (196397 - 271030 != -74632)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (245063 - 476950 == -231887)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (225916 - 548413 == -322497)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (12189 - 319083 == -306894)
						{
							if (Time.time <= this.aZecA1It1al)
							{
								break;
							}
							if (284208 - 484627 == -200419)
							{
								Game.mGameMana++;
								if (121458 - 384999 != -263540)
								{
									this.aZecA1It1al = Time.time + (float)12;
									if (188044 - 560970 != -372925)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (189097 - 434204 != -245106)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (163802 - 478778 == -314976)
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
						if (274659 - 207614 != 67046)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F11 RID: 32529 RVA: 0x01058128 File Offset: 0x01056328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (270934 - 184314 != 86620)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (162891 - 583630 == -420739)
			{
				float num = (float)1;
				if (244110 - 210533 == 33577)
				{
					float num2 = (float)(1024 * Screen.width / Screen.height);
					if (72052 - 359105 == -287053)
					{
						GUI.depth = 1;
						if (163309 - 202223 != -38913)
						{
							eGameState mGameState = Game.mGameState;
							if (2010 - 201739 != -199728)
							{
								if (mGameState == eGameState.Start)
								{
									if (15000 - 422316 == -407315)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)1)
									{
										if (86819 - 77452 != 9368)
										{
											break;
										}
										continue;
									}
									else if (Time.time - Game.mStateTime < (float)2)
									{
										if (53079 - 501865 == -448785)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)1);
										if (233325 - 414647 != -181322)
										{
											continue;
										}
										float a = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)1);
										if (149751 - 254933 == -105181)
										{
											continue;
										}
										Color color = GUI.color;
										if (78676 - 263759 != -185083)
										{
											continue;
										}
										color.a = a;
										if (143763 - 78432 == 65332 || 182547 - 328485 == -145937)
										{
											continue;
										}
										GUI.color = color;
										if (173347 - 132884 == 40464)
										{
											continue;
										}
										if (226150 - 114858 != 111292)
										{
											continue;
										}
										if (this.jgicAR9ucZ0)
										{
											if (147255 - 243231 != -95976)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.jgicAR9ucZ0);
											if (10099 - 113217 == -103117)
											{
												continue;
											}
										}
									}
									else if (Time.time - Game.mStateTime < (float)3)
									{
										if (108722 - 389053 == -280330)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)2);
										if (248307 - 431955 != -183648)
										{
											continue;
										}
										float a2 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)2);
										if (82268 - 322027 != -239759)
										{
											continue;
										}
										Color color2 = GUI.color;
										if (228262 - 61249 == 167014)
										{
											continue;
										}
										color2.a = a2;
										if (44972 - 379599 != -334627)
										{
											continue;
										}
										if (258676 - 581860 != -323184)
										{
											continue;
										}
										GUI.color = color2;
										if (233302 - 592721 != -359419)
										{
											continue;
										}
										if (199796 - 453095 == -253298)
										{
											continue;
										}
										if (this.HW4cArecAnf)
										{
											if (63285 - 257696 == -194410)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.HW4cArecAnf);
											if (209114 - 331398 == -122283)
											{
												continue;
											}
										}
									}
									else if (Time.time - Game.mStateTime < (float)4)
									{
										if (54295 - 41011 == 13285)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)3);
										if (204176 - 97696 != 106480)
										{
											continue;
										}
										float a3 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)3);
										if (236522 - 445842 != -209320)
										{
											continue;
										}
										Color color3 = GUI.color;
										if (225608 - 377672 != -152064)
										{
											continue;
										}
										color3.a = a3;
										if (227626 - 88483 != 139143)
										{
											continue;
										}
										if (105255 - 277688 != -172433)
										{
											continue;
										}
										GUI.color = color3;
										if (219212 - 248277 == -29064)
										{
											continue;
										}
										if (196617 - 229965 != -33348)
										{
											continue;
										}
										if (this.OkjcAx2ZLU2)
										{
											if (10557 - 344931 == -334373)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.OkjcAx2ZLU2);
											if (184916 - 314922 == -130005)
											{
												continue;
											}
										}
									}
								}
								else if (mGameState == eGameState.Normal)
								{
									if (109979 - 369291 == -259311)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)2)
									{
										if (70670 - 400639 != -329969)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
										if (176358 - 514941 != -338583)
										{
											continue;
										}
										float a4 = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
										if (200692 - 481953 != -281261)
										{
											continue;
										}
										Color color4 = GUI.color;
										if (101353 - 554730 != -453377)
										{
											continue;
										}
										color4.a = a4;
										if (57270 - 334724 == -277453 || 230242 - 28910 == 201333)
										{
											continue;
										}
										GUI.color = color4;
										if (182537 - 353152 == -170614 || 74655 - 439442 == -364786)
										{
											continue;
										}
										if (this.LHOcAplXLTH)
										{
											if (151941 - 59920 == 92022)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.LHOcAplXLTH);
											if (292211 - 131571 == 160641)
											{
												continue;
											}
										}
									}
								}
								float a5 = 1f;
								if (83996 - 250005 == -166009)
								{
									Color color5 = GUI.color;
									if (285900 - 522979 != -237078)
									{
										float num3 = color5.a = a5;
										if (116455 - 108174 == 8281)
										{
											if (22667 - 262920 == -240253)
											{
												Color color6 = GUI.color = color5;
												if (79749 - 548486 != -468736)
												{
													if (155599 - 406359 == -250760)
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

	// Token: 0x06007F12 RID: 32530 RVA: 0x01058A64 File Offset: 0x01056C64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06007F13 RID: 32531 RVA: 0x01058A68 File Offset: 0x01056C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x06007F14 RID: 32532 RVA: 0x01058A6C File Offset: 0x01056C6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		Debug.Log("On Mission Event:" + data[141]);
	}

	// Token: 0x06007F15 RID: 32533 RVA: 0x01058A90 File Offset: 0x01056C90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M408_DesertSurvival.$onGameComplete$39029(data, this).GetEnumerator();
	}

	// Token: 0x06007F16 RID: 32534 RVA: 0x01058AA0 File Offset: 0x01056CA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (37974 - 257256 != -219282)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (80421 - 210326 != -129904)
			{
				Time.timeScale = 1f;
				if (260500 - 357590 != -97089)
				{
					Hashtable customOpParameters = new Hashtable();
					if (116270 - 536285 != -420014)
					{
						this.Tn5cAlAjWFM.OpCustom(52, customOpParameters, true);
						if (168645 - 187758 == -19113)
						{
							this.LHOcAplXLTH = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
							if (141441 - 445587 != -304145)
							{
								this.jgicAR9ucZ0 = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
								if (274913 - 4567 != 270347)
								{
									this.HW4cArecAnf = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
									if (171987 - 461640 != -289652)
									{
										this.OkjcAx2ZLU2 = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
										if (283712 - 281540 != 2173)
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

	// Token: 0x06007F17 RID: 32535 RVA: 0x01058C50 File Offset: 0x01056E50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (65077 - 117199 != -52122)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (259670 - 394250 != -134579)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (189310 - 494256 == -304946)
				{
					Game.mGameState = eGameState.Setup;
					if (291851 - 8223 == 283628)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007F18 RID: 32536 RVA: 0x01058CF4 File Offset: 0x01056EF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (155979 - 305320 != -149341)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (11964 - 223168 == -211204)
			{
				if (num == PlayerData.UID)
				{
					if (34292 - 436977 == -402685)
					{
						this.SetupActors();
						if (6678 - 8267 != -1588)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (275427 - 279132 != -3704)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007F19 RID: 32537 RVA: 0x01058DC4 File Offset: 0x01056FC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (62814 - 311335 != -248520)
		{
		}
		for (;;)
		{
			IL_C1:
			Debug.Log("Creating Actors");
			if (22020 - 580287 == -558267)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (117969 - 82219 == 35750)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (140745 - 175929 != -35183)
						{
							int i = 0;
							if (175992 - 146288 == 29704)
							{
								CharacterControl[] array2 = array;
								if (53944 - 472159 == -418215)
								{
									int length = array2.Length;
									if (71546 - 188390 == -116844)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (234473 - 356304 == -121830)
											{
												goto IL_C1;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (71417 - 206612 != -135195)
											{
												goto IL_C1;
											}
											this.y1scAT3j2mp++;
											if (113157 - 504406 != -391249)
											{
												goto IL_C1;
											}
											i++;
											if (196686 - 439132 != -242446)
											{
												goto IL_C1;
											}
										}
										if (143603 - 251594 == -107991)
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
						if (24347 - 138340 != -113992)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F1A RID: 32538 RVA: 0x01058FDC File Offset: 0x010571DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (150956 - 28070 != 122886)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (61590 - 118542 == -56952)
			{
				int i = 0;
				if (299036 - 446773 == -147737)
				{
					CharacterControl[] array2 = array;
					if (150639 - 50842 != 99798)
					{
						int length = array2.Length;
						if (154057 - 218141 != -64083)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (139493 - 166284 != -26791)
								{
									goto IL_1A;
								}
								i++;
								if (208486 - 304446 != -95960)
								{
									goto IL_1A;
								}
							}
							if (141716 - 332779 != -191062)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F1B RID: 32539 RVA: 0x0105910C File Offset: 0x0105730C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (9497 - 252846 != -243349)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (222741 - 231377 == -8636)
			{
				hashtable.Add(43, PlayerData.UID);
				if (217516 - 343182 != -125665)
				{
					hashtable.Add(73, nType);
					if (183782 - 480467 != -296684)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (175093 - 353169 != -178075)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (201213 - 263601 == -62388)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (120126 - 191271 == -71145)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (52237 - 213282 == -161045)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (285615 - 159428 == 126187)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (132656 - 187089 != -54432)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (57742 - 509629 != -451886)
												{
													this.Tn5cAlAjWFM.OpCustom(63, hashtable, true);
													if (138178 - 251537 != -113358)
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

	// Token: 0x06007F1C RID: 32540 RVA: 0x010593C4 File Offset: 0x010575C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (216398 - 154316 != 62083)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (299366 - 2900 != 296467)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (82594 - 47345 == 35249)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (140261 - 546251 == -405990)
						{
							if (this.y1scAT3j2mp <= 0)
							{
								break;
							}
							if (25219 - 540650 != -515430)
							{
								this.y1scAT3j2mp--;
								if (72086 - 4255 == 67831)
								{
									if (this.y1scAT3j2mp != 0)
									{
										break;
									}
									if (233364 - 527267 == -293903)
									{
										Game.setGameState(eGameState.Ready);
										if (47097 - 572748 != -525650)
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
						if (2725 - 411045 == -408320)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (33455 - 313384 == -279929)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F1D RID: 32541 RVA: 0x01059554 File Offset: 0x01057754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (201231 - 122612 != 78619)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (56512 - 89256 == -32744)
			{
				Game.mGameState = eGameState.Ready;
				if (1781 - 589521 == -587740)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (15162 - 92227 != -77064)
					{
						if (6206 - 327237 == -321031)
						{
							GameObject gameObject = null;
							if (145908 - 87611 != 58298)
							{
								if (playerSlot <= 1)
								{
									goto IL_251;
								}
								if (243606 - 383410 == -139803)
								{
									continue;
								}
								if (playerSlot > 5)
								{
									goto IL_251;
								}
								if (297899 - 125614 != 172285)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (69811 - 254819 == -185007)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (71680 - 346135 != -274455)
								{
									continue;
								}
								IL_FA:
								if (gameObject2)
								{
									if (33002 - 201115 != -168113)
									{
										continue;
									}
									Game.sendMissionEvent(4081, playerSlot);
									if (84144 - 54018 == 30127)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, playerSlot, gameObject2.transform.position, gameObject2.transform.forward);
									if (25126 - 149823 == -124696)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (159751 - 48251 == 111501)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (257288 - 451057 == -193768)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (245336 - 242412 != 2925)
								{
									break;
								}
								continue;
								IL_251:
								gameObject2 = GameObject.Find("StartPoint1");
								if (23930 - 299156 != -275225)
								{
									goto IL_FA;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F1E RID: 32542 RVA: 0x0105980C File Offset: 0x01057A0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M408_DesertSurvival.$StartGame$39037(this).GetEnumerator();
	}

	// Token: 0x06007F1F RID: 32543 RVA: 0x0105981C File Offset: 0x01057A1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007F20 RID: 32544 RVA: 0x01059820 File Offset: 0x01057A20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (2158 - 306732 != -304574)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (175186 - 97683 != 77504)
			{
				hashtable.Add(71, CID);
				if (183115 - 540779 != -357663)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (155863 - 20282 == 135581)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (239966 - 183833 != 56134)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (264880 - 11224 != 253657)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (24311 - 427572 != -403260)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (133784 - 338357 == -204573)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (219162 - 310704 != -91541)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (183171 - 1938 == 181233)
											{
												this.Tn5cAlAjWFM.OpCustom(61, hashtable, true);
												if (108324 - 426176 != -317851)
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

	// Token: 0x06007F21 RID: 32545 RVA: 0x01059AAC File Offset: 0x01057CAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (200214 - 584602 != -384387)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (291700 - 373639 != -81938)
			{
				if (!gameObject)
				{
					break;
				}
				if (25736 - 436195 != -410458)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (246885 - 280719 != -33833)
					{
						playerCameraControl.target = gameObject;
						if (100450 - 527189 != -426738)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (225409 - 100111 == 125298)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F22 RID: 32546 RVA: 0x01059BA4 File Offset: 0x01057DA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (46713 - 425751 != -379037)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (225894 - 3005 == 222889)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (91316 - 353529 == -262213)
				{
					gameGui.ResetTeamBar();
					if (29324 - 128934 == -99610)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007F23 RID: 32547 RVA: 0x01059C50 File Offset: 0x01057E50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M408_DesertSurvival.$onDeadPlayer$39041(this).GetEnumerator();
	}

	// Token: 0x06007F24 RID: 32548 RVA: 0x01059C60 File Offset: 0x01057E60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (13847 - 112158 != -98311)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (158986 - 25854 == 133132)
			{
				if (Game.mPlayer)
				{
					if (72375 - 530535 != -458160)
					{
						continue;
					}
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (95326 - 284032 != -188706)
					{
						continue;
					}
					if (characterControl)
					{
						if (7541 - 347144 == -339602)
						{
							continue;
						}
						Game.sendMissionEvent(4081, characterControl.mOriginalLayer - 7);
						if (91467 - 120641 != -29174)
						{
							continue;
						}
					}
				}
				PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
				if (46815 - 5984 != 40832)
				{
					playerCameraControl.target = Game.mPlayer;
					if (245331 - 259266 == -13935)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (51194 - 128215 == -77020)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (122680 - 146762 != -24082)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (208540 - 391359 == -182819)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (124093 - 288811 != -164717)
							{
								if (!gameGui)
								{
									break;
								}
								if (41513 - 257954 != -216440)
								{
									gameGui.enabled = true;
									if (233853 - 307363 == -73510)
									{
										gameGui.closeDeadMenu();
										if (66580 - 334825 == -268245)
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

	// Token: 0x06007F25 RID: 32549 RVA: 0x01059EC0 File Offset: 0x010580C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (56799 - 491121 != -434321)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (189433 - 187727 == 1706)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (1567 - 344761 == -343194)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (136145 - 468709 != -332563)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007F26 RID: 32550 RVA: 0x01059F84 File Offset: 0x01058184
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (48972 - 459332 != -410359)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
			{
				if (232026 - 441587 != -209560)
				{
					Game.mGameState = eGameState.Ended;
					if (22543 - 109564 == -87021)
					{
						break;
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.AllHold;
				if (249256 - 83141 == 166115)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06007F27 RID: 32551 RVA: 0x0105A03C File Offset: 0x0105823C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M408_DesertSurvival.$ReturnToTown$39048(this).GetEnumerator();
	}

	// Token: 0x06007F28 RID: 32552 RVA: 0x0105A04C File Offset: 0x0105824C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M408_DesertSurvival.$ReturnToGuild$39053(this).GetEnumerator();
	}

	// Token: 0x06007F29 RID: 32553 RVA: 0x0105A05C File Offset: 0x0105825C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M408_DesertSurvival.$ReturnToCamp$39057(this).GetEnumerator();
	}

	// Token: 0x06007F2A RID: 32554 RVA: 0x0105A06C File Offset: 0x0105826C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (209613 - 5993 != 203620)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (54508 - 247707 != -193198)
			{
				Hashtable hashtable = new Hashtable();
				if (170682 - 382917 != -212234)
				{
					hashtable.Add(43, PlayerData.UID);
					if (171359 - 120302 != 51058)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (209789 - 564311 == -354522)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F2B RID: 32555 RVA: 0x0105A144 File Offset: 0x01058344
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007F2C RID: 32556 RVA: 0x0105A158 File Offset: 0x01058358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (247438 - 541137 != -293698)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (156071 - 284210 != -128138)
			{
				Hashtable hashtable = new Hashtable();
				if (87806 - 442434 == -354628)
				{
					if (Game.mNextGameCode == 30)
					{
						if (259890 - 589656 != -329766)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (208540 - 157167 == 51374)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (181921 - 320803 == -138881)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (7497 - 279642 != -272145)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (238434 - 532165 != -293731)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (84737 - 123868 == -39130)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (225931 - 566883 != -340952)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (296297 - 243557 == 52741)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (210985 - 566782 == -355796)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (47274 - 483312 != -436038)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (118549 - 580800 != -462251)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (269739 - 469522 != -199783)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (133303 - 590071 == -456767)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (211265 - 451760 != -240495)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (97507 - 515609 == -418101)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (80600 - 416278 == -335677)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (209257 - 481981 != -272724)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (235721 - 593984 != -358263)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (272605 - 37845 == 234761)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (225429 - 500960 != -275531)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (19424 - 148209 != -128785)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (56430 - 439772 == -383341)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (124805 - 227483 == -102677)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (106543 - 115096 != -8553)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (143202 - 280339 == -137136)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (125359 - 322085 != -196726)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (49145 - 326677 == -277531)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (27446 - 151434 == -123987)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (154850 - 483860 == -329010)
					{
						this.Tn5cAlAjWFM.OpCustom(42, hashtable, true);
						if (210873 - 100898 != 109976)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F2D RID: 32557 RVA: 0x0105A70C File Offset: 0x0105890C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007F2E RID: 32558 RVA: 0x0105A71C File Offset: 0x0105891C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007F2F RID: 32559 RVA: 0x0105A720 File Offset: 0x01058920
	internal static bool AR4biHpBs7IPEM9iSLxU()
	{
		return true;
	}

	// Token: 0x06007F30 RID: 32560 RVA: 0x0105A724 File Offset: 0x01058924
	internal static bool LaYAtepB9VIvb8tksmfG()
	{
		return false;
	}

	// Token: 0x04007EC3 RID: 32451
	private LitePeer Tn5cAlAjWFM;

	// Token: 0x04007EC4 RID: 32452
	private PlayerCameraControl Xe5cAGhjWY1;

	// Token: 0x04007EC5 RID: 32453
	private float aZecA1It1al;

	// Token: 0x04007EC6 RID: 32454
	private int OpBcAqLOVaA;

	// Token: 0x04007EC7 RID: 32455
	private Texture LHOcAplXLTH;

	// Token: 0x04007EC8 RID: 32456
	private Texture jgicAR9ucZ0;

	// Token: 0x04007EC9 RID: 32457
	private Texture HW4cArecAnf;

	// Token: 0x04007ECA RID: 32458
	private Texture OkjcAx2ZLU2;

	// Token: 0x04007ECB RID: 32459
	private int y1scAT3j2mp;

	// Token: 0x0200156E RID: 5486
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39029 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007F31 RID: 32561 RVA: 0x0105A728 File Offset: 0x01058928
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39029(Hashtable data, M408_DesertSurvival self_)
		{
			if (294660 - 367948 != -73288)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (249581 - 383828 == -134247)
				{
					base..ctor();
					if (217145 - 380014 == -162869)
					{
						this.$data$39035 = data;
						if (246627 - 23234 != 223394)
						{
							this.$self_$39036 = self_;
							if (13482 - 293979 == -280497)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007F32 RID: 32562 RVA: 0x0105A7E4 File Offset: 0x010589E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M408_DesertSurvival.$onGameComplete$39029.$(this.$data$39035, this.$self_$39036);
		}

		// Token: 0x06007F33 RID: 32563 RVA: 0x0105A7F8 File Offset: 0x010589F8
		internal static bool e0TSMhpB1YOMrUldV7oo()
		{
			return true;
		}

		// Token: 0x06007F34 RID: 32564 RVA: 0x0105A7FC File Offset: 0x010589FC
		internal static bool sPIxvUpB4JW6mtyFnhyV()
		{
			return false;
		}

		// Token: 0x04007ECC RID: 32460
		internal Hashtable $data$39035;

		// Token: 0x04007ECD RID: 32461
		internal M408_DesertSurvival $self_$39036;

		// Token: 0x0200156F RID: 5487
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007F35 RID: 32565 RVA: 0x0105A800 File Offset: 0x01058A00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M408_DesertSurvival self_)
			{
				if (197506 - 353014 != -155508)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (292447 - 73845 == 218602)
					{
						base..ctor();
						if (229707 - 181362 != 48346)
						{
							this.$data$39033 = data;
							if (134700 - 350337 != -215636)
							{
								this.$self_$39034 = self_;
								if (246909 - 105943 == 140966)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007F36 RID: 32566 RVA: 0x0105A8BC File Offset: 0x01058ABC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (97263 - 52957 != 44307)
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
						this.$mCompleteGui$39031 = (CompleteGui)this.$self_$39034.GetComponent(typeof(CompleteGui));
						if (136530 - 388773 == -252242)
						{
							continue;
						}
						this.$mCompleteGui$39031.Init();
						if (118895 - 67190 != 51705)
						{
							continue;
						}
						this.$mCompleteGui$39031.readData(this.$data$39033);
						if (141825 - 424188 != -282363)
						{
							continue;
						}
						if (this.$result$39030 == 1)
						{
							if (43597 - 262243 != -218646)
							{
								continue;
							}
							this.$mCompleteGui$39031.displayResult(eCompleteType.Success);
							if (209612 - 22965 == 186648)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39031.displayResult(eCompleteType.Failed);
							if (168550 - 471943 == -303392)
							{
								continue;
							}
						}
						this.$mGameGui$39032 = (GameGui)this.$self_$39034.GetComponent(typeof(GameGui));
						if (269885 - 476529 != -206644)
						{
							continue;
						}
						if (this.$mGameGui$39032)
						{
							if (93171 - 457157 != -363986)
							{
								continue;
							}
							this.$mGameGui$39032.close();
							if (71942 - 297392 != -225450)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (235861 - 501353 != -265492)
						{
							continue;
						}
						goto IL_28E;
					default:
						if (54542 - 303408 != -248866)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (255779 - 407373 != -151593)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (220194 - 296491 == -76297)
						{
							this.$result$39030 = RuntimeServices.UnboxInt32(this.$data$39033[31]);
							if (256939 - 191629 != 65311)
							{
								goto Block_16;
							}
						}
					}
				}
				goto IL_28E;
				Block_16:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_28E:
				return false;
			}

			// Token: 0x06007F37 RID: 32567 RVA: 0x0105AB6C File Offset: 0x01058D6C
			internal static bool tD5yWjpBzuQe7nAHPAG7()
			{
				return true;
			}

			// Token: 0x06007F38 RID: 32568 RVA: 0x0105AB70 File Offset: 0x01058D70
			internal static bool zqLanTpeavH8xbcldsUa()
			{
				return false;
			}

			// Token: 0x04007ECE RID: 32462
			internal int $result$39030;

			// Token: 0x04007ECF RID: 32463
			internal CompleteGui $mCompleteGui$39031;

			// Token: 0x04007ED0 RID: 32464
			internal GameGui $mGameGui$39032;

			// Token: 0x04007ED1 RID: 32465
			internal Hashtable $data$39033;

			// Token: 0x04007ED2 RID: 32466
			internal M408_DesertSurvival $self_$39034;
		}
	}

	// Token: 0x02001570 RID: 5488
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$39037 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007F39 RID: 32569 RVA: 0x0105AB74 File Offset: 0x01058D74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$39037(M408_DesertSurvival self_)
		{
			if (152932 - 32800 != 120132)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (221225 - 140519 != 80707)
				{
					base..ctor();
					if (38892 - 390129 == -351237)
					{
						this.$self_$39040 = self_;
						if (56197 - 334248 != -278050)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007F3A RID: 32570 RVA: 0x0105AC0C File Offset: 0x01058E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M408_DesertSurvival.$StartGame$39037.$(this.$self_$39040);
		}

		// Token: 0x06007F3B RID: 32571 RVA: 0x0105AC1C File Offset: 0x01058E1C
		internal static bool OK7thxpe5U9qlsCnkfEl()
		{
			return true;
		}

		// Token: 0x06007F3C RID: 32572 RVA: 0x0105AC20 File Offset: 0x01058E20
		internal static bool k3Wo9ZpeprZxrqkGUcCS()
		{
			return false;
		}

		// Token: 0x04007ED3 RID: 32467
		internal M408_DesertSurvival $self_$39040;

		// Token: 0x02001571 RID: 5489
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007F3D RID: 32573 RVA: 0x0105AC24 File Offset: 0x01058E24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M408_DesertSurvival self_)
			{
				if (299917 - 198018 != 101899)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240938 - 158967 == 81971)
					{
						base..ctor();
						if (241231 - 485963 == -244732)
						{
							this.$self_$39039 = self_;
							if (96667 - 189053 != -92385)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007F3E RID: 32574 RVA: 0x0105ACBC File Offset: 0x01058EBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (221465 - 598854 != -377389)
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
							if (218249 - 534590 != -316340)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (210481 - 529863 != -319382)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (123839 - 134431 != -10592)
							{
								continue;
							}
							this.$self_$39039.SendMessage("newGameMessage", "Match has started!");
							if (40804 - 81316 == -40511)
							{
								continue;
							}
							Chat.SubmitChat("none", "Match has started!", eChatType.system, eChatMode.system);
							if (188505 - 28769 != 159736)
							{
								continue;
							}
							this.YieldDefault(1);
							if (119622 - 63372 != 56250)
							{
								continue;
							}
							goto IL_23D;
						}
						break;
					default:
						if (206939 - 492901 != -285962)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (128924 - 253033 != -124108)
					{
						Game.mGameState = eGameState.Start;
						if (215543 - 584083 == -368540)
						{
							Game.mStateTime = Time.time;
							if (132999 - 429258 != -296258)
							{
								this.$mGameGui$39038 = (GameGui)this.$self_$39039.GetComponent(typeof(GameGui));
								if (21716 - 340301 == -318585)
								{
									this.$mGameGui$39038.enabled = true;
									if (57604 - 233869 != -176264)
									{
										this.$self_$39039.SendMessage("fadeIn");
										if (114146 - 259910 != -145763)
										{
											goto Block_11;
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_23D;
				Block_11:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_23D:
				return false;
			}

			// Token: 0x06007F3F RID: 32575 RVA: 0x0105AF18 File Offset: 0x01059118
			internal static bool EA07WhpeVkMc6HAlDvHi()
			{
				return true;
			}

			// Token: 0x06007F40 RID: 32576 RVA: 0x0105AF1C File Offset: 0x0105911C
			internal static bool k75KIlpetu1R6r2fwvbV()
			{
				return false;
			}

			// Token: 0x04007ED4 RID: 32468
			internal GameGui $mGameGui$39038;

			// Token: 0x04007ED5 RID: 32469
			internal M408_DesertSurvival $self_$39039;
		}
	}

	// Token: 0x02001572 RID: 5490
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39041 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007F41 RID: 32577 RVA: 0x0105AF20 File Offset: 0x01059120
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39041(M408_DesertSurvival self_)
		{
			if (222754 - 262618 != -39863)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (112836 - 276179 == -163343)
				{
					base..ctor();
					if (230304 - 547962 != -317657)
					{
						this.$self_$39047 = self_;
						if (193989 - 201992 != -8002)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x0105AFB8 File Offset: 0x010591B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M408_DesertSurvival.$onDeadPlayer$39041.$(this.$self_$39047);
		}

		// Token: 0x06007F43 RID: 32579 RVA: 0x0105AFC8 File Offset: 0x010591C8
		internal static bool mNTGAdpeNYjOFHEhK5Xq()
		{
			return true;
		}

		// Token: 0x06007F44 RID: 32580 RVA: 0x0105AFCC File Offset: 0x010591CC
		internal static bool NAXyVupeYdP6vh9hwxDk()
		{
			return false;
		}

		// Token: 0x04007ED6 RID: 32470
		internal M408_DesertSurvival $self_$39047;

		// Token: 0x02001573 RID: 5491
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007F45 RID: 32581 RVA: 0x0105AFD0 File Offset: 0x010591D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M408_DesertSurvival self_)
			{
				if (192638 - 180598 != 12040)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (139345 - 466189 == -326844)
					{
						base..ctor();
						if (173826 - 375911 == -202085)
						{
							this.$self_$39046 = self_;
							if (121630 - 211401 != -89770)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007F46 RID: 32582 RVA: 0x0105B068 File Offset: 0x01059268
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (181420 - 1142 != 180278)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3B6;
					case 2:
						if (Game.mGameState != eGameState.Normal)
						{
							if (205814 - 118953 != 86861)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_394;
							}
							if (270836 - 186407 != 84429)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (89425 - 158824 == -69398)
						{
							continue;
						}
						this.$mStoryGui$39043 = (StoryGui)this.$self_$39046.GetComponent(typeof(StoryGui));
						if (154543 - 424442 == -269898)
						{
							continue;
						}
						if (this.$mStoryGui$39043)
						{
							if (188095 - 89690 != 98405)
							{
								continue;
							}
							this.$mStoryGui$39043.close();
							if (249439 - 238162 == 11278)
							{
								continue;
							}
						}
						this.$mChangeGui$39044 = (ChangeGui)this.$self_$39046.GetComponent(typeof(ChangeGui));
						if (286622 - 579129 == -292506)
						{
							continue;
						}
						if (this.$mChangeGui$39044)
						{
							if (37124 - 168265 == -131140)
							{
								continue;
							}
							this.$mChangeGui$39044.close();
							if (38554 - 188203 == -149648)
							{
								continue;
							}
						}
						this.$mGameGui$39045 = (GameGui)this.$self_$39046.GetComponent(typeof(GameGui));
						if (229912 - 502841 == -272928)
						{
							continue;
						}
						if (this.$mGameGui$39045)
						{
							if (235447 - 312229 != -76782)
							{
								continue;
							}
							if (!this.$mGameGui$39045.enabled)
							{
								if (68684 - 375832 == -307147)
								{
									continue;
								}
								this.$mGameGui$39045.enabled = true;
								if (57486 - 545197 != -487711)
								{
									continue;
								}
							}
							this.$mGameGui$39045.openDeadMenu();
							if (9751 - 170134 != -160383)
							{
								continue;
							}
						}
						IL_394:
						this.YieldDefault(1);
						if (189989 - 136098 != 53892)
						{
							goto IL_3B6;
						}
						continue;
					default:
						if (142127 - 367443 != -225316)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (86534 - 268952 != -182417)
					{
						if (!Game.mPlayer)
						{
							break;
						}
						if (280750 - 56441 == 224309)
						{
							this.$mPlayerChar$39042 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (265930 - 365211 != -99280)
							{
								if (!this.$mPlayerChar$39042)
								{
									break;
								}
								if (32437 - 346264 != -313826)
								{
									Game.sendMissionEvent(4082, this.$mPlayerChar$39042.mOriginalLayer - 7);
									if (233548 - 403238 == -169690)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_3B6:
				return false;
			}

			// Token: 0x06007F47 RID: 32583 RVA: 0x0105B440 File Offset: 0x01059640
			internal static bool ztOjXjpecbWoY7kICGea()
			{
				return true;
			}

			// Token: 0x06007F48 RID: 32584 RVA: 0x0105B444 File Offset: 0x01059644
			internal static bool nVuJL4peUNC5cblQ012n()
			{
				return false;
			}

			// Token: 0x04007ED7 RID: 32471
			internal CharacterControl $mPlayerChar$39042;

			// Token: 0x04007ED8 RID: 32472
			internal StoryGui $mStoryGui$39043;

			// Token: 0x04007ED9 RID: 32473
			internal ChangeGui $mChangeGui$39044;

			// Token: 0x04007EDA RID: 32474
			internal GameGui $mGameGui$39045;

			// Token: 0x04007EDB RID: 32475
			internal M408_DesertSurvival $self_$39046;
		}
	}

	// Token: 0x02001574 RID: 5492
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39048 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007F49 RID: 32585 RVA: 0x0105B448 File Offset: 0x01059648
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39048(M408_DesertSurvival self_)
		{
			if (232304 - 296212 != -63908)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (138803 - 255520 != -116716)
				{
					base..ctor();
					if (188799 - 168186 != 20614)
					{
						this.$self_$39052 = self_;
						if (147267 - 7198 != 140070)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007F4A RID: 32586 RVA: 0x0105B4E0 File Offset: 0x010596E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M408_DesertSurvival.$ReturnToTown$39048.$(this.$self_$39052);
		}

		// Token: 0x06007F4B RID: 32587 RVA: 0x0105B4F0 File Offset: 0x010596F0
		internal static bool jGirYYpeTws0V2ru2IHJ()
		{
			return true;
		}

		// Token: 0x06007F4C RID: 32588 RVA: 0x0105B4F4 File Offset: 0x010596F4
		internal static bool YwyGCGpe3etxmxsiKvMC()
		{
			return false;
		}

		// Token: 0x04007EDC RID: 32476
		internal M408_DesertSurvival $self_$39052;

		// Token: 0x02001575 RID: 5493
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007F4D RID: 32589 RVA: 0x0105B4F8 File Offset: 0x010596F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M408_DesertSurvival self_)
			{
				if (163464 - 515374 != -351910)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (102369 - 128380 != -26010)
					{
						base..ctor();
						if (67539 - 432216 == -364677)
						{
							this.$self_$39051 = self_;
							if (241183 - 543655 == -302472)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007F4E RID: 32590 RVA: 0x0105B590 File Offset: 0x01059790
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (240962 - 249390 != -8427)
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
						this.$self_$39051.LeaveGame();
						if (23867 - 410532 == -386664)
						{
							continue;
						}
						this.YieldDefault(1);
						if (285634 - 22938 != 262696)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (202027 - 357465 == -155437)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (36878 - 370378 == -333500)
					{
						Game.mStateTime = Time.time;
						if (50545 - 576906 != -526360)
						{
							this.$$switch$6838$39049 = PlayerData.SaveGuild;
							if (28462 - 145240 != -116777)
							{
								if (this.$$switch$6838$39049 == 1)
								{
									if (99272 - 5960 != 93312)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (212407 - 199314 != 13093)
									{
										continue;
									}
								}
								else if (this.$$switch$6838$39049 == 2)
								{
									if (278442 - 190331 == 88112)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (48315 - 37810 == 10506)
									{
										continue;
									}
								}
								else if (this.$$switch$6838$39049 == 3)
								{
									if (101141 - 402398 != -301257)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (197223 - 324934 != -127711)
									{
										continue;
									}
								}
								else if (this.$$switch$6838$39049 == 4)
								{
									if (292171 - 113424 != 178747)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (170 - 279698 != -279528)
									{
										continue;
									}
								}
								else if (this.$$switch$6838$39049 == 5)
								{
									if (159902 - 378567 == -218664)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (214672 - 392842 == -178169)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (173951 - 216421 == -42469)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (95009 - 166334 == -71324)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (140266 - 449599 != -309333)
									{
										continue;
									}
								}
								this.$mGameGui$39050 = (GameGui)this.$self_$39051.GetComponent(typeof(GameGui));
								if (187619 - 207195 != -19575)
								{
									if (this.$mGameGui$39050)
									{
										if (82742 - 128031 == -45288)
										{
											continue;
										}
										this.$mGameGui$39050.close();
										if (154531 - 70640 == 83892)
										{
											continue;
										}
									}
									this.$self_$39051.SendMessage("fadeOut");
									if (78511 - 115558 != -37046)
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

			// Token: 0x06007F4F RID: 32591 RVA: 0x0105B95C File Offset: 0x01059B5C
			internal static bool U6kx2NpeXnpEgwKm3Vle()
			{
				return true;
			}

			// Token: 0x06007F50 RID: 32592 RVA: 0x0105B960 File Offset: 0x01059B60
			internal static bool jH4Qg2peQXpJQbTa3CjG()
			{
				return false;
			}

			// Token: 0x04007EDD RID: 32477
			internal int $$switch$6838$39049;

			// Token: 0x04007EDE RID: 32478
			internal GameGui $mGameGui$39050;

			// Token: 0x04007EDF RID: 32479
			internal M408_DesertSurvival $self_$39051;
		}
	}

	// Token: 0x02001576 RID: 5494
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39053 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007F51 RID: 32593 RVA: 0x0105B964 File Offset: 0x01059B64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39053(M408_DesertSurvival self_)
		{
			if (153988 - 407433 != -253444)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (135618 - 470629 != -335010)
				{
					base..ctor();
					if (262072 - 299253 == -37181)
					{
						this.$self_$39056 = self_;
						if (76739 - 324043 == -247304)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007F52 RID: 32594 RVA: 0x0105B9FC File Offset: 0x01059BFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M408_DesertSurvival.$ReturnToGuild$39053.$(this.$self_$39056);
		}

		// Token: 0x06007F53 RID: 32595 RVA: 0x0105BA0C File Offset: 0x01059C0C
		internal static bool GgniS9pekiyxyO5rK2TO()
		{
			return true;
		}

		// Token: 0x06007F54 RID: 32596 RVA: 0x0105BA10 File Offset: 0x01059C10
		internal static bool sWk2ZCpeGV2du21dHopd()
		{
			return false;
		}

		// Token: 0x04007EE0 RID: 32480
		internal M408_DesertSurvival $self_$39056;

		// Token: 0x02001577 RID: 5495
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007F55 RID: 32597 RVA: 0x0105BA14 File Offset: 0x01059C14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M408_DesertSurvival self_)
			{
				if (61748 - 443872 != -382123)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (17518 - 420249 == -402731)
					{
						base..ctor();
						if (78862 - 497043 != -418180)
						{
							this.$self_$39055 = self_;
							if (160072 - 349905 != -189832)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007F56 RID: 32598 RVA: 0x0105BAAC File Offset: 0x01059CAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (228368 - 430187 != -201818)
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
						this.$self_$39055.LeaveGame();
						if (27198 - 198212 == -171013)
						{
							continue;
						}
						this.YieldDefault(1);
						if (114252 - 511965 != -397712)
						{
							goto Block_7;
						}
						continue;
					default:
						if (202839 - 341373 != -138534)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (128028 - 284481 != -156452)
					{
						Game.mStateTime = Time.time;
						if (16668 - 233740 == -217072)
						{
							Game.mNextGameCode = 31;
							if (71692 - 589437 != -517744)
							{
								this.$mGameGui$39054 = (GameGui)this.$self_$39055.GetComponent(typeof(GameGui));
								if (5915 - 197472 != -191556)
								{
									if (this.$mGameGui$39054)
									{
										if (71130 - 212951 == -141820)
										{
											continue;
										}
										this.$mGameGui$39054.close();
										if (292079 - 189377 == 102703)
										{
											continue;
										}
									}
									this.$self_$39055.SendMessage("fadeOut");
									if (135525 - 242419 == -106894)
									{
										goto IL_109;
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_1BD;
				IL_109:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06007F57 RID: 32599 RVA: 0x0105BC88 File Offset: 0x01059E88
			internal static bool c7S3SXpeH2OVQUpUWj99()
			{
				return true;
			}

			// Token: 0x06007F58 RID: 32600 RVA: 0x0105BC8C File Offset: 0x01059E8C
			internal static bool j28SVDpeWfUyly8xTR5B()
			{
				return false;
			}

			// Token: 0x04007EE1 RID: 32481
			internal GameGui $mGameGui$39054;

			// Token: 0x04007EE2 RID: 32482
			internal M408_DesertSurvival $self_$39055;
		}
	}

	// Token: 0x02001578 RID: 5496
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39057 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007F59 RID: 32601 RVA: 0x0105BC90 File Offset: 0x01059E90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39057(M408_DesertSurvival self_)
		{
			if (188013 - 412203 != -224190)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193832 - 316655 == -122823)
				{
					base..ctor();
					if (212685 - 98642 == 114043)
					{
						this.$self_$39061 = self_;
						if (121099 - 140850 != -19750)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007F5A RID: 32602 RVA: 0x0105BD28 File Offset: 0x01059F28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M408_DesertSurvival.$ReturnToCamp$39057.$(this.$self_$39061);
		}

		// Token: 0x06007F5B RID: 32603 RVA: 0x0105BD38 File Offset: 0x01059F38
		internal static bool YdIH4JpeAdTr7JhWEtNx()
		{
			return true;
		}

		// Token: 0x06007F5C RID: 32604 RVA: 0x0105BD3C File Offset: 0x01059F3C
		internal static bool nQsuPvpel0RKBbjbbiKy()
		{
			return false;
		}

		// Token: 0x04007EE3 RID: 32483
		internal M408_DesertSurvival $self_$39061;

		// Token: 0x02001579 RID: 5497
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007F5D RID: 32605 RVA: 0x0105BD40 File Offset: 0x01059F40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M408_DesertSurvival self_)
			{
				if (247624 - 151816 != 95809)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (34072 - 442051 == -407979)
					{
						base..ctor();
						if (143828 - 592187 == -448359)
						{
							this.$self_$39060 = self_;
							if (179050 - 143089 == 35961)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007F5E RID: 32606 RVA: 0x0105BDD8 File Offset: 0x01059FD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (96722 - 307188 != -210465)
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
						this.$self_$39060.LeaveGame();
						if (295439 - 160745 != 134694)
						{
							continue;
						}
						this.YieldDefault(1);
						if (298560 - 521119 != -222558)
						{
							goto Block_7;
						}
						continue;
					default:
						if (53862 - 123002 == -69139)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (253838 - 167108 != 86731)
					{
						Game.mStateTime = Time.time;
						if (178987 - 371611 == -192624)
						{
							this.$$switch$6840$39058 = PlayerData.SaveGuild;
							if (227174 - 437630 == -210456)
							{
								if (this.$$switch$6840$39058 == 1)
								{
									if (293536 - 553793 == -260256)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (176311 - 332769 != -156458)
									{
										continue;
									}
								}
								else if (this.$$switch$6840$39058 == 2)
								{
									if (142680 - 265275 == -122594)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (24278 - 236598 == -212319)
									{
										continue;
									}
								}
								else if (this.$$switch$6840$39058 == 3)
								{
									if (206563 - 59000 == 147564)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (103307 - 482537 != -379230)
									{
										continue;
									}
								}
								else if (this.$$switch$6840$39058 == 4)
								{
									if (182340 - 592742 != -410402)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (282815 - 407623 == -124807)
									{
										continue;
									}
								}
								else if (this.$$switch$6840$39058 == 5)
								{
									if (117642 - 137037 == -19394)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (50391 - 197621 != -147230)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (9629 - 82938 != -73309)
									{
										continue;
									}
								}
								this.$mGameGui$39059 = (GameGui)this.$self_$39060.GetComponent(typeof(GameGui));
								if (75666 - 569417 == -493751)
								{
									if (this.$mGameGui$39059)
									{
										if (12598 - 468011 != -455413)
										{
											continue;
										}
										this.$mGameGui$39059.close();
										if (69004 - 118340 != -49336)
										{
											continue;
										}
									}
									this.$self_$39060.SendMessage("fadeOut");
									if (122140 - 154475 == -32335)
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
				IL_363:
				return false;
			}

			// Token: 0x06007F5F RID: 32607 RVA: 0x0105C15C File Offset: 0x0105A35C
			internal static bool Lc9wQEpeyCDjhZM7EW0Y()
			{
				return true;
			}

			// Token: 0x06007F60 RID: 32608 RVA: 0x0105C160 File Offset: 0x0105A360
			internal static bool XB46c6peSbrdBWWxy8ke()
			{
				return false;
			}

			// Token: 0x04007EE4 RID: 32484
			internal int $$switch$6840$39058;

			// Token: 0x04007EE5 RID: 32485
			internal GameGui $mGameGui$39059;

			// Token: 0x04007EE6 RID: 32486
			internal M408_DesertSurvival $self_$39060;
		}
	}
}
