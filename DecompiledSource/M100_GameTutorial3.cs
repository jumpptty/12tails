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

// Token: 0x020012D2 RID: 4818
[Serializable]
public class M100_GameTutorial3 : MonoBehaviour
{
	// Token: 0x06006EDF RID: 28383 RVA: 0x00F58CB8 File Offset: 0x00F56EB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M100_GameTutorial3()
	{
		if (93684 - 56256 != 37428)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (107979 - 373432 == -265453)
			{
				base..ctor();
				if (256637 - 383583 == -126946)
				{
					this.lGHc04qLQdp = 1;
					if (192027 - 307557 == -115530)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006EE0 RID: 28384 RVA: 0x00F58D50 File Offset: 0x00F56F50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (93388 - 436946 != -343558)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (212735 - 269264 == -56529)
			{
				Game.mGameType = 5;
				if (100405 - 385350 == -284945)
				{
					if (Chat.Initialized)
					{
						if (212907 - 340280 == -127373)
						{
							Chat.ChatDisplay.Clear();
							if (23786 - 492559 != -468772)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (234188 - 416445 != -182256)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006EE1 RID: 28385 RVA: 0x00F58E34 File Offset: 0x00F57034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (10373 - 390752 != -380379)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (4323 - 514637 != -510313)
				{
					Game.nextGame();
					if (244801 - 189640 == 55161)
					{
						Game.mGameCode = 100;
						if (144260 - 309792 != -165531)
						{
							Game.mGameType = 5;
							if (51207 - 300336 == -249129)
							{
								Game.mStateTime = Time.time;
								if (9058 - 447012 != -437953)
								{
									Game.canUseItem = true;
									if (190800 - 271221 != -80420)
									{
										Game.canUseMount = false;
										if (225081 - 534846 != -309764)
										{
											Game.canRespawn = false;
											if (104746 - 53591 != 51156)
											{
												this.D20c0pwpjZq = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
												if (103363 - 39726 != 63638)
												{
													this.Jx7c0q9meeu = PhotonClient.Connection;
													if (98040 - 402884 == -304844)
													{
														PhotonClient.ActorNrList.Clear();
														if (179247 - 305002 != -125754)
														{
															this.InitGame();
															if (259804 - 553554 != -293749)
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
			else
			{
				Debug.Log("Not Connected");
				if (240801 - 322875 != -82073)
				{
					Game.mGameType = 99;
					if (233820 - 500360 != -266539)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006EE2 RID: 28386 RVA: 0x00F59064 File Offset: 0x00F57264
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (297519 - 248575 != 48944)
		{
		}
		for (;;)
		{
			if (this.Jx7c0q9meeu == null)
			{
				if (160630 - 235666 == -75036)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (202847 - 430631 != -227783)
				{
					if (mGameState == eGameState.Init)
					{
						if (257544 - 414744 == -157200)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (177165 - 242203 == -65038)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (199198 - 182426 != 16773)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (99083 - 93275 == 5808)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (73435 - 8700 == 64735)
						{
							if (Game.music != 0)
							{
								if (202577 - 450353 == -247775)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (175023 - 505397 == -330373)
									{
										continue;
									}
									this.audio.Play();
									if (47868 - 261186 == -213317)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (86329 - 394919 == -308590)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (226424 - 524448 != -298023)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (210083 - 475765 == -265682)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (211464 - 103113 != 108352)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (260714 - 569365 != -308650)
							{
								if (Time.time <= this.rulc0RLvx9p)
								{
									break;
								}
								if (283586 - 528139 != -244552)
								{
									Game.mGameMana++;
									if (252195 - 496497 != -244301)
									{
										this.rulc0RLvx9p = Time.time + (float)12;
										if (9030 - 277530 == -268500)
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
						if (20881 - 417417 != -396535)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (4780 - 359387 == -354607)
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
						if (108195 - 590571 == -482376)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006EE3 RID: 28387 RVA: 0x00F5940C File Offset: 0x00F5760C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (139030 - 448935 != -309904)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (3677 - 244842 != -241164)
			{
				GUI.depth = 1;
				if (125625 - 270164 == -144539)
				{
					int num = this.epQc0wjJn72;
					if (133209 - 308835 == -175626)
					{
						if (num == 500)
						{
							if (39066 - 33123 == 5943)
							{
								if (!this.H9Nc0xw6W9k)
								{
									break;
								}
								if (132096 - 532899 == -400803)
								{
									this.RenderTutorialGui(this.H9Nc0xw6W9k);
									if (109918 - 549422 == -439504)
									{
										break;
									}
								}
							}
						}
						else if (num == 501)
						{
							if (17409 - 117226 == -99817)
							{
								if (!this.uaLc0TxQgh7)
								{
									break;
								}
								if (298376 - 97778 == 200598)
								{
									this.RenderTutorialGui(this.uaLc0TxQgh7);
									if (167405 - 364634 != -197228)
									{
										break;
									}
								}
							}
						}
						else if (num == 600)
						{
							if (282127 - 403793 != -121665)
							{
								if (!this.CvEc0YtwBox)
								{
									break;
								}
								if (203721 - 382791 == -179070)
								{
									this.RenderTutorialGui(this.CvEc0YtwBox);
									if (178427 - 323029 != -144601)
									{
										break;
									}
								}
							}
						}
						else if (num == 601)
						{
							if (63746 - 449846 == -386100)
							{
								if (!this.l4Hc03BEXYM)
								{
									break;
								}
								if (57326 - 102350 == -45024)
								{
									this.RenderTutorialGui(this.l4Hc03BEXYM);
									if (74216 - 204348 == -130132)
									{
										break;
									}
								}
							}
						}
						else if (num == 800)
						{
							if (136257 - 554436 != -418178)
							{
								if (!this.Apvc0bsFRf9)
								{
									break;
								}
								if (165777 - 503246 != -337468)
								{
									this.RenderTutorialGui(this.Apvc0bsFRf9);
									if (221805 - 313683 != -91877)
									{
										break;
									}
								}
							}
						}
						else
						{
							if (num != 801)
							{
								break;
							}
							if (9057 - 326168 == -317111)
							{
								if (!this.jf8c0dpYVSu)
								{
									break;
								}
								if (162687 - 209998 == -47311)
								{
									this.RenderTutorialGui(this.jf8c0dpYVSu);
									if (261659 - 471324 == -209665)
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

	// Token: 0x06006EE4 RID: 28388 RVA: 0x00F597B0 File Offset: 0x00F579B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitTutorialGui()
	{
		if (207873 - 574806 != -366933)
		{
		}
		for (;;)
		{
			int @int = PlayerPrefs.GetInt("language", 0);
			if (55378 - 323758 == -268380)
			{
				if (@int == 1)
				{
					if (107234 - 285496 == -178261)
					{
						continue;
					}
					this.c8pc0rb3SYu = (Texture)Resources.Load("GameGui/Tutorial/english/guide_menu", typeof(Texture));
					if (10110 - 221522 != -211412)
					{
						continue;
					}
					this.H9Nc0xw6W9k = (Texture)Resources.Load("GameGui/Tutorial/english/guide_500", typeof(Texture));
					if (277512 - 528524 == -251011)
					{
						continue;
					}
					this.uaLc0TxQgh7 = (Texture)Resources.Load("GameGui/Tutorial/english/guide_501", typeof(Texture));
					if (161903 - 64163 != 97740)
					{
						continue;
					}
					this.CvEc0YtwBox = (Texture)Resources.Load("GameGui/Tutorial/english/guide_600", typeof(Texture));
					if (243146 - 16619 != 226527)
					{
						continue;
					}
					this.l4Hc03BEXYM = (Texture)Resources.Load("GameGui/Tutorial/english/guide_601", typeof(Texture));
					if (182523 - 426230 == -243706)
					{
						continue;
					}
					this.Apvc0bsFRf9 = (Texture)Resources.Load("GameGui/Tutorial/english/guide_800", typeof(Texture));
					if (193873 - 133195 == 60679)
					{
						continue;
					}
					this.jf8c0dpYVSu = (Texture)Resources.Load("GameGui/Tutorial/english/guide_801", typeof(Texture));
					if (83913 - 232553 == -148639)
					{
						continue;
					}
				}
				else
				{
					this.c8pc0rb3SYu = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_menu", typeof(Texture));
					if (178829 - 16693 != 162136)
					{
						continue;
					}
					this.H9Nc0xw6W9k = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_500", typeof(Texture));
					if (262855 - 429236 != -166381)
					{
						continue;
					}
					this.uaLc0TxQgh7 = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_501", typeof(Texture));
					if (223545 - 119244 == 104302)
					{
						continue;
					}
					this.CvEc0YtwBox = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_600", typeof(Texture));
					if (20688 - 441524 != -420836)
					{
						continue;
					}
					this.l4Hc03BEXYM = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_601", typeof(Texture));
					if (58957 - 73928 != -14971)
					{
						continue;
					}
					this.Apvc0bsFRf9 = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_800", typeof(Texture));
					if (289933 - 431742 != -141809)
					{
						continue;
					}
					this.jf8c0dpYVSu = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_801", typeof(Texture));
					if (222337 - 28426 != 193911)
					{
						continue;
					}
				}
				this.vqOc0gOsZEf = new GUIStyle();
				if (131641 - 71696 != 59946)
				{
					this.vqOc0gOsZEf.font = (Font)Resources.Load("GameGui/Fonts/Century32", typeof(Font));
					if (172983 - 187156 != -14172)
					{
						this.vqOc0gOsZEf.normal.textColor = new Color(0.42f, 0.33f, 0.28f, (float)1);
						if (281511 - 313955 == -32444)
						{
							this.vqOc0gOsZEf.alignment = TextAnchor.MiddleLeft;
							if (276080 - 496250 != -220169)
							{
								this.L3Fc0aGQ482 = new GUIStyle();
								if (65305 - 247961 == -182656)
								{
									this.L3Fc0aGQ482.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
									if (37872 - 466001 != -428128)
									{
										this.L3Fc0aGQ482.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
										if (277070 - 166649 == 110421)
										{
											this.L3Fc0aGQ482.alignment = TextAnchor.MiddleLeft;
											if (247701 - 172807 != 74895)
											{
												this.K9Hc0sUOpNm = new GUIStyle();
												if (298735 - 503394 == -204659)
												{
													this.K9Hc0sUOpNm.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageNext_h", typeof(Texture)));
													if (143588 - 514922 != -371333)
													{
														this.xN8c0H8ahSu = new GUIStyle();
														if (119368 - 88920 != 30449)
														{
															this.xN8c0H8ahSu.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageBack_h", typeof(Texture)));
															if (97050 - 497509 != -400458)
															{
																this.Yyfc07UuHOI = new GUIStyle();
																if (108826 - 318888 != -210061)
																{
																	this.Yyfc07UuHOI.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_close_h", typeof(Texture)));
																	if (240932 - 287433 != -46500)
																	{
																		this.TWJc0ZCE6Sb = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
																		if (188231 - 394164 == -205933)
																		{
																			this.ucsc0C81TZl = (AudioClip)Resources.Load("Sound/GUI/click", typeof(AudioClip));
																			if (200240 - 580175 == -379935)
																			{
																				this.fjFc0MW19tB = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																				if (130096 - 142406 != -12309)
																				{
																					this.OGKc0fSULGa = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
																					if (283060 - 302440 == -19380)
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
			}
		}
	}

	// Token: 0x06006EE5 RID: 28389 RVA: 0x00F59F0C File Offset: 0x00F5810C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderTutorialGui(Texture nTutorial)
	{
		if (122502 - 307443 != -184941)
		{
		}
		for (;;)
		{
			float num = (float)(1024 * Screen.width / Screen.height);
			if (280125 - 486411 != -206285)
			{
				if (this.c8pc0rb3SYu)
				{
					if (23775 - 397528 == -373752)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * num - (float)330, (float)200, (float)668, (float)676), this.c8pc0rb3SYu);
					if (262096 - 310691 == -48594)
					{
						continue;
					}
				}
				GUI.Label(new Rect(0.5f * num - (float)330 + (float)112, (float)244, (float)400, (float)36), "Game Tutorial", this.vqOc0gOsZEf);
				if (297760 - 71537 == 226223)
				{
					if (nTutorial)
					{
						if (213270 - 597788 != -384518)
						{
							continue;
						}
						GUI.DrawTexture(new Rect(0.5f * num - (float)330 + (float)93, (float)296, (float)512, (float)512), nTutorial);
						if (220659 - 534625 != -313966)
						{
							continue;
						}
					}
					GUI.Label(new Rect(0.5f * num - (float)330 + (float)362, (float)813, (float)50, (float)30), string.Empty + this.lGHc04qLQdp, this.L3Fc0aGQ482);
					if (254762 - 134157 != 120606)
					{
						if (GUI.Button(new Rect(0.5f * num - (float)330 + (float)218, (float)803, (float)85, (float)57), string.Empty, this.xN8c0H8ahSu))
						{
							if (226993 - 130423 == 96571)
							{
								continue;
							}
							this.audio.PlayOneShot(this.fjFc0MW19tB);
							if (236063 - 349538 != -113475)
							{
								continue;
							}
						}
						if (GUI.Button(new Rect(0.5f * num - (float)330 + (float)375, (float)803, (float)85, (float)57), string.Empty, this.K9Hc0sUOpNm))
						{
							if (1794 - 185694 != -183900)
							{
								continue;
							}
							this.epQc0wjJn72 = 0;
							if (27948 - 95544 != -67596)
							{
								continue;
							}
							this.audio.PlayOneShot(this.fjFc0MW19tB);
							if (257484 - 17911 != 239573)
							{
								continue;
							}
						}
						if (!GUI.Button(new Rect(0.5f * num - (float)330 + (float)592, (float)204, (float)57, (float)52), string.Empty, this.Yyfc07UuHOI))
						{
							break;
						}
						if (1751 - 60060 != -58308)
						{
							this.epQc0wjJn72 = 0;
							if (282591 - 9920 != 272672)
							{
								this.audio.PlayOneShot(this.OGKc0fSULGa);
								if (285533 - 102736 != 182798)
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

	// Token: 0x06006EE6 RID: 28390 RVA: 0x00F5A2C8 File Offset: 0x00F584C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (221995 - 299326 != -77331)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (117373 - 392797 != -275423)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (124055 - 171000 != -46944)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (233237 - 178273 != 54965)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (175265 - 247506 == -72241)
						{
							int num4 = num;
							if (148351 - 340588 == -192237)
							{
								if (num4 == 1007)
								{
									if (238205 - 27737 != 210469)
									{
										break;
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (49840 - 463221 != -413380)
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

	// Token: 0x06006EE7 RID: 28391 RVA: 0x00F5A434 File Offset: 0x00F58634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M100_GameTutorial3.$StartEvent$37103(this).GetEnumerator();
	}

	// Token: 0x06006EE8 RID: 28392 RVA: 0x00F5A444 File Offset: 0x00F58644
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToKangaroo()
	{
		return new M100_GameTutorial3.$TalkToKangaroo$37110(this).GetEnumerator();
	}

	// Token: 0x06006EE9 RID: 28393 RVA: 0x00F5A454 File Offset: 0x00F58654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToBear()
	{
		return new M100_GameTutorial3.$TalkToBear$37118(this).GetEnumerator();
	}

	// Token: 0x06006EEA RID: 28394 RVA: 0x00F5A464 File Offset: 0x00F58664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToOwl1()
	{
		return new M100_GameTutorial3.$TalkToOwl1$37126(this).GetEnumerator();
	}

	// Token: 0x06006EEB RID: 28395 RVA: 0x00F5A474 File Offset: 0x00F58674
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMouse()
	{
		return new M100_GameTutorial3.$TalkToMouse$37134(this).GetEnumerator();
	}

	// Token: 0x06006EEC RID: 28396 RVA: 0x00F5A484 File Offset: 0x00F58684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWarthog()
	{
		return new M100_GameTutorial3.$TalkToWarthog$37142(this).GetEnumerator();
	}

	// Token: 0x06006EED RID: 28397 RVA: 0x00F5A494 File Offset: 0x00F58694
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToAlpaca()
	{
		return new M100_GameTutorial3.$TalkToAlpaca$37150(this).GetEnumerator();
	}

	// Token: 0x06006EEE RID: 28398 RVA: 0x00F5A4A4 File Offset: 0x00F586A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMiniSheep()
	{
		return new M100_GameTutorial3.$TalkToMiniSheep$37158(this).GetEnumerator();
	}

	// Token: 0x06006EEF RID: 28399 RVA: 0x00F5A4B4 File Offset: 0x00F586B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther(int n)
	{
		return new M100_GameTutorial3.$TalkToPanther$37165(n, this).GetEnumerator();
	}

	// Token: 0x06006EF0 RID: 28400 RVA: 0x00F5A4C4 File Offset: 0x00F586C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (110460 - 48261 != 62199)
		{
		}
		for (;;)
		{
			GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
			if (213284 - 594244 == -380960)
			{
				if (!gameGui)
				{
					break;
				}
				if (212038 - 14884 != 197155)
				{
					gameGui.newNoticeBar(Language.getMessage("M100_GameTutorial", 164));
					if (176120 - 391370 == -215250)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006EF1 RID: 28401 RVA: 0x00F5A580 File Offset: 0x00F58780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseStorageBox(object mVar)
	{
		if (15651 - 514412 != -498761)
		{
		}
		for (;;)
		{
			GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
			if (206821 - 235716 != -28894)
			{
				if (!gameGui)
				{
					break;
				}
				if (193435 - 570087 != -376651)
				{
					gameGui.newNoticeBar(Language.getMessage("M100_GameTutorial", 164));
					if (110853 - 299937 != -189083)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006EF2 RID: 28402 RVA: 0x00F5A63C File Offset: 0x00F5883C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitToGuild()
	{
		if (198506 - 181095 != 17412)
		{
		}
		for (;;)
		{
			GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
			if (15362 - 314877 == -299515)
			{
				if (!gameGui)
				{
					break;
				}
				if (76825 - 405863 == -329038)
				{
					gameGui.newNoticeBar(Language.getMessage("M100_GameTutorial", 351));
					if (221629 - 321341 == -99712)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006EF3 RID: 28403 RVA: 0x00F5A6F8 File Offset: 0x00F588F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitToCentralStreet()
	{
		if (43429 - 534703 != -491274)
		{
		}
		for (;;)
		{
			GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
			if (8485 - 209822 == -201337)
			{
				if (!gameGui)
				{
					break;
				}
				if (287753 - 71597 == 216156)
				{
					gameGui.newNoticeBar(Language.getMessage("M100_GameTutorial", 352));
					if (86868 - 513814 != -426945)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006EF4 RID: 28404 RVA: 0x00F5A7B4 File Offset: 0x00F589B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (99980 - 487297 != -387316)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (143755 - 398247 != -254491)
			{
				Time.timeScale = 1f;
				if (268862 - 453765 != -184902)
				{
					Hashtable customOpParameters = new Hashtable();
					if (295682 - 277253 != 18430)
					{
						this.Jx7c0q9meeu.OpCustom(52, customOpParameters, true);
						if (229089 - 432244 != -203154)
						{
							this.InitTutorialGui();
							if (67229 - 39740 == 27489)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006EF5 RID: 28405 RVA: 0x00F5A8A0 File Offset: 0x00F58AA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (257391 - 582270 != -324879)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (208198 - 178019 != 30180)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (113074 - 367918 == -254844)
				{
					Game.mGameState = eGameState.Setup;
					if (40137 - 407845 != -367707)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006EF6 RID: 28406 RVA: 0x00F5A944 File Offset: 0x00F58B44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (133357 - 432590 != -299233)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (248103 - 453628 != -205524)
			{
				if (num == PlayerData.UID)
				{
					if (25861 - 267858 == -241997)
					{
						this.SetupActors();
						if (179007 - 9091 == 169916)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (98461 - 473776 != -375314)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006EF7 RID: 28407 RVA: 0x00F5AA14 File Offset: 0x00F58C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (54512 - 391318 != -336805)
		{
		}
		for (;;)
		{
			IL_1D4:
			Debug.Log("Creating Actors");
			if (172805 - 371404 != -198598)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (224458 - 307235 == -82777)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (138073 - 317253 == -179180)
						{
							int i = 0;
							if (189897 - 155089 == 34808)
							{
								CharacterControl[] array2 = array;
								if (68791 - 460688 != -391896)
								{
									int length = array2.Length;
									if (171918 - 124189 == 47729)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (133543 - 158371 != -24828)
												{
													goto IL_1D4;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (239431 - 63201 != 176230)
												{
													goto IL_1D4;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (9218 - 186349 != -177131)
												{
													goto IL_1D4;
												}
												this.vZXc08Xx8kO++;
												if (103721 - 416304 != -312583)
												{
													goto IL_1D4;
												}
											}
											i++;
											if (220463 - 578429 != -357966)
											{
												goto IL_1D4;
											}
										}
										if (207509 - 11342 == 196167)
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
						if (91188 - 235594 == -144406)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006EF8 RID: 28408 RVA: 0x00F5AC50 File Offset: 0x00F58E50
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (183693 - 30143 != 153551)
		{
		}
		for (;;)
		{
			IL_58:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (29832 - 314256 != -284423)
			{
				int i = 0;
				if (67533 - 322330 != -254796)
				{
					CharacterControl[] array2 = array;
					if (132007 - 186988 == -54981)
					{
						int length = array2.Length;
						if (126747 - 129335 == -2588)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (264707 - 483766 == -219058)
								{
									goto IL_58;
								}
								i++;
								if (272384 - 59593 != 212791)
								{
									goto IL_58;
								}
							}
							if (248449 - 167298 == 81151)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006EF9 RID: 28409 RVA: 0x00F5AD80 File Offset: 0x00F58F80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (241642 - 436166 != -194523)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (123575 - 136738 == -13163)
			{
				Game.mGameState = eGameState.Ready;
				if (143969 - 322411 != -178441)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (297381 - 194903 != 102479)
					{
						if (69702 - 506376 == -436674)
						{
							GameObject gameObject = null;
							if (184430 - 269251 == -84821)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (149586 - 557824 != -408238)
									{
										continue;
									}
									if (playerSlot <= 12)
									{
										if (57171 - 229830 != -172659)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (181393 - 528502 != -347109)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (150865 - 177227 != -26362)
										{
											continue;
										}
										goto IL_A1;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (286576 - 346622 == -60045)
								{
									continue;
								}
								IL_A1:
								if (gameObject2)
								{
									if (196864 - 33579 == 163286)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (67964 - 267192 != -199228)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (65535 - 577743 != -512208)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (219423 - 560540 != -341117)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (133493 - 88411 == 45083)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (101212 - 279045 == -177833)
								{
									this.transform.position = gameObject.transform.position;
									if (268395 - 157909 == 110486)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (84426 - 345012 != -260585)
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

	// Token: 0x06006EFA RID: 28410 RVA: 0x00F5B0A4 File Offset: 0x00F592A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (27208 - 388573 != -361364)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (97865 - 586887 == -489022)
			{
				Game.mGameState = eGameState.Start;
				if (127885 - 91374 != 36512)
				{
					Game.mStateTime = Time.time;
					if (78246 - 95528 == -17282)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (131993 - 58910 == 73083)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006EFB RID: 28411 RVA: 0x00F5B16C File Offset: 0x00F5936C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06006EFC RID: 28412 RVA: 0x00F5B170 File Offset: 0x00F59370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (36736 - 227025 != -190289)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (125013 - 447944 != -322930)
			{
				if (gameObject)
				{
					if (278889 - 551143 != -272253)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (223306 - 413547 == -190241)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (263248 - 108041 != 155208)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006EFD RID: 28413 RVA: 0x00F5B26C File Offset: 0x00F5946C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (256408 - 567561 != -311153)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (129694 - 519120 == -389426)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (215957 - 426866 != -210908)
				{
					hashtable.Add(43, PlayerData.UID);
					if (148201 - 305196 == -156995)
					{
						hashtable.Add(73, nType);
						if (73126 - 585509 != -512382)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (70380 - 125127 == -54747)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (115257 - 97169 != 18089)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (280733 - 220506 != 60228)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (233967 - 189870 == 44097)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (299695 - 33545 == 266150)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (149609 - 252154 != -102544)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (229883 - 561536 == -331653)
													{
														this.Jx7c0q9meeu.OpCustom(63, hashtable, true);
														if (101800 - 460285 != -358484)
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

	// Token: 0x06006EFE RID: 28414 RVA: 0x00F5B550 File Offset: 0x00F59750
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (140619 - 163544 != -22925)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (111284 - 521894 == -410610)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (217728 - 200180 == 17548)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (59809 - 505015 == -445206)
						{
							if (this.vZXc08Xx8kO <= 0)
							{
								break;
							}
							if (87600 - 126258 == -38658)
							{
								this.vZXc08Xx8kO--;
								if (151822 - 483364 != -331541)
								{
									if (this.vZXc08Xx8kO != 0)
									{
										break;
									}
									if (164090 - 292762 != -128671)
									{
										Game.setGameState(eGameState.Ready);
										if (279963 - 192603 != 87361)
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
						if (295945 - 85490 != 210456)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (32781 - 422160 != -389378)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006EFF RID: 28415 RVA: 0x00F5B6E0 File Offset: 0x00F598E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06006F00 RID: 28416 RVA: 0x00F5B6F4 File Offset: 0x00F598F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (40171 - 417074 != -376902)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (244195 - 483945 != -239749)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (211552 - 260997 == -49445)
				{
					if (!characterControl)
					{
						break;
					}
					if (250214 - 193521 != 56694)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (173549 - 226342 == -52793)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (104402 - 34675 == 69727)
							{
								string type = characterControl.Type;
								if (299135 - 73006 == 226129)
								{
									if (!(type == string.Empty))
									{
										break;
									}
									if (175302 - 269789 != -94486)
									{
										Game.sendMissionEvent(0, 0);
										if (280528 - 453355 != -172826)
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

	// Token: 0x06006F01 RID: 28417 RVA: 0x00F5B868 File Offset: 0x00F59A68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (19566 - 224770 != -205204)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (218059 - 131934 == 86125)
			{
				hashtable.Add(71, CID);
				if (249748 - 569006 != -319257)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (273465 - 484521 == -211056)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (172208 - 376972 != -204763)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (193238 - 405264 == -212026)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (254506 - 191843 == 62663)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (271261 - 189338 == 81923)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (295881 - 474000 == -178119)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (120290 - 281436 == -161146)
											{
												this.Jx7c0q9meeu.OpCustom(61, hashtable, true);
												if (288443 - 447927 != -159483)
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

	// Token: 0x06006F02 RID: 28418 RVA: 0x00F5BAF4 File Offset: 0x00F59CF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (106618 - 170808 != -64189)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (102012 - 501226 == -399214)
			{
				if (!gameObject)
				{
					break;
				}
				if (200701 - 361982 == -161281)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (136190 - 450583 == -314393)
					{
						playerCameraControl.target = gameObject;
						if (283627 - 141861 == 141766)
						{
							this.StartGame();
							if (76620 - 322110 != -245489)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006F03 RID: 28419 RVA: 0x00F5BBE4 File Offset: 0x00F59DE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (76786 - 231105 != -154318)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (161245 - 588644 != -427398)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (65296 - 290143 != -224846)
				{
					gameGui.ResetTeamBar();
					if (29926 - 562224 == -532298)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006F04 RID: 28420 RVA: 0x00F5BC90 File Offset: 0x00F59E90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M100_GameTutorial3.$onDeadPlayer$37173(this).GetEnumerator();
	}

	// Token: 0x06006F05 RID: 28421 RVA: 0x00F5BCA0 File Offset: 0x00F59EA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (277770 - 580902 != -303131)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (157427 - 199593 == -42166)
			{
				this.D20c0pwpjZq.target = Game.mPlayer;
				if (96739 - 227513 != -130773)
				{
					this.D20c0pwpjZq.enabled = true;
					if (293735 - 453680 != -159944)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (228273 - 5449 == 222825)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (250413 - 183953 == 66461)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (279945 - 167831 == 112114)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (73091 - 465954 == -392863)
							{
								if (!gameGui)
								{
									break;
								}
								if (229251 - 12716 != 216536)
								{
									gameGui.enabled = true;
									if (131130 - 394286 == -263156)
									{
										gameGui.closeDeadMenu();
										if (225492 - 302151 == -76659)
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

	// Token: 0x06006F06 RID: 28422 RVA: 0x00F5BE4C File Offset: 0x00F5A04C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (170764 - 49745 != 121019)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (89475 - 67414 == 22061)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (82224 - 510719 == -428495)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (257838 - 474043 == -216205)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006F07 RID: 28423 RVA: 0x00F5BF10 File Offset: 0x00F5A110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06006F08 RID: 28424 RVA: 0x00F5BF3C File Offset: 0x00F5A13C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (210230 - 451457 != -241227)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (193942 - 143976 == 49966)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (70405 - 233353 != -162947)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (262469 - 151836 != 110634)
					{
						Hashtable hashtable = new Hashtable();
						if (7811 - 44137 == -36326)
						{
							hashtable.Add(43, PlayerData.UID);
							if (181065 - 486495 != -305429)
							{
								hashtable.Add(71, nCID);
								if (240120 - 161462 != 78659)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (257409 - 108623 != 148787)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (210205 - 94815 != 115391)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (248560 - 240326 == 8234)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (237506 - 468881 == -231375)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (287432 - 221839 == 65593)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (95899 - 338626 == -242727)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (5799 - 584930 == -579131)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (215482 - 87836 == 127646)
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

	// Token: 0x06006F09 RID: 28425 RVA: 0x00F5C25C File Offset: 0x00F5A45C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M100_GameTutorial3.$onChangePlayer$37179(data, this).GetEnumerator();
	}

	// Token: 0x06006F0A RID: 28426 RVA: 0x00F5C26C File Offset: 0x00F5A46C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M100_GameTutorial3.$onGameComplete$37186(data, this).GetEnumerator();
	}

	// Token: 0x06006F0B RID: 28427 RVA: 0x00F5C27C File Offset: 0x00F5A47C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M100_GameTutorial3.$ReturnToTown$37196(this).GetEnumerator();
	}

	// Token: 0x06006F0C RID: 28428 RVA: 0x00F5C28C File Offset: 0x00F5A48C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M100_GameTutorial3.$ReturnToGuild$37201(this).GetEnumerator();
	}

	// Token: 0x06006F0D RID: 28429 RVA: 0x00F5C29C File Offset: 0x00F5A49C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M100_GameTutorial3.$ReturnToCamp$37205(this).GetEnumerator();
	}

	// Token: 0x06006F0E RID: 28430 RVA: 0x00F5C2AC File Offset: 0x00F5A4AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (71411 - 544807 != -473396)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (21076 - 406331 == -385255)
			{
				Hashtable hashtable = new Hashtable();
				if (89596 - 448650 == -359054)
				{
					hashtable.Add(43, PlayerData.UID);
					if (253208 - 117017 == 136191)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (198540 - 526441 == -327901)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006F0F RID: 28431 RVA: 0x00F5C384 File Offset: 0x00F5A584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06006F10 RID: 28432 RVA: 0x00F5C398 File Offset: 0x00F5A598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (77949 - 420536 != -342587)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (108202 - 144878 == -36676)
			{
				Hashtable hashtable = new Hashtable();
				if (1813 - 573305 == -571492)
				{
					if (Game.mNextGameCode == 30)
					{
						if (47636 - 172158 == -124521)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (154228 - 357170 == -202941)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (239084 - 343024 == -103939)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (155766 - 261669 == -105902)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (209833 - 248941 == -39107)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (117534 - 378889 == -261354)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (150929 - 440349 == -289419)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (233085 - 40306 == 192780)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (288985 - 358 != 288627)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (226119 - 583745 != -357626)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (50459 - 184080 != -133621)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (11270 - 199517 == -188246)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (222148 - 163682 == 58467)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (51433 - 38686 == 12748)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (136410 - 152477 != -16067)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (183370 - 492322 == -308951)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (243322 - 308416 != -65094)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (293997 - 78661 == 215337)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (67668 - 460855 == -393186)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (60765 - 581391 != -520626)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (74061 - 522755 == -448693)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (79226 - 549791 == -470564)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (90060 - 497333 == -407272)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (2459 - 302602 != -300143)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (18710 - 461276 != -442566)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (81292 - 566690 != -485398)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (129535 - 524162 == -394626)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (171462 - 429695 == -258232)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (212261 - 385733 != -173471)
					{
						this.Jx7c0q9meeu.OpCustom(42, hashtable, true);
						if (162763 - 129454 == 33309)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006F11 RID: 28433 RVA: 0x00F5C94C File Offset: 0x00F5AB4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06006F12 RID: 28434 RVA: 0x00F5C95C File Offset: 0x00F5AB5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006F13 RID: 28435 RVA: 0x00F5C960 File Offset: 0x00F5AB60
	internal static bool KEnr9dpMZlabDeCdi7CM()
	{
		return true;
	}

	// Token: 0x06006F14 RID: 28436 RVA: 0x00F5C964 File Offset: 0x00F5AB64
	internal static bool fQYvM6pMCwvi7cyUCsDb()
	{
		return false;
	}

	// Token: 0x0400762D RID: 30253
	private LitePeer Jx7c0q9meeu;

	// Token: 0x0400762E RID: 30254
	private PlayerCameraControl D20c0pwpjZq;

	// Token: 0x0400762F RID: 30255
	private float rulc0RLvx9p;

	// Token: 0x04007630 RID: 30256
	private Texture c8pc0rb3SYu;

	// Token: 0x04007631 RID: 30257
	private Texture H9Nc0xw6W9k;

	// Token: 0x04007632 RID: 30258
	private Texture uaLc0TxQgh7;

	// Token: 0x04007633 RID: 30259
	private Texture CvEc0YtwBox;

	// Token: 0x04007634 RID: 30260
	private Texture l4Hc03BEXYM;

	// Token: 0x04007635 RID: 30261
	private Texture Apvc0bsFRf9;

	// Token: 0x04007636 RID: 30262
	private Texture jf8c0dpYVSu;

	// Token: 0x04007637 RID: 30263
	private GUIStyle vqOc0gOsZEf;

	// Token: 0x04007638 RID: 30264
	private GUIStyle L3Fc0aGQ482;

	// Token: 0x04007639 RID: 30265
	private int lGHc04qLQdp;

	// Token: 0x0400763A RID: 30266
	private GUIStyle K9Hc0sUOpNm;

	// Token: 0x0400763B RID: 30267
	private GUIStyle xN8c0H8ahSu;

	// Token: 0x0400763C RID: 30268
	private GUIStyle Yyfc07UuHOI;

	// Token: 0x0400763D RID: 30269
	private AudioClip TWJc0ZCE6Sb;

	// Token: 0x0400763E RID: 30270
	private AudioClip ucsc0C81TZl;

	// Token: 0x0400763F RID: 30271
	private AudioClip fjFc0MW19tB;

	// Token: 0x04007640 RID: 30272
	private AudioClip OGKc0fSULGa;

	// Token: 0x04007641 RID: 30273
	private int fHTc0LmNHio;

	// Token: 0x04007642 RID: 30274
	private int epQc0wjJn72;

	// Token: 0x04007643 RID: 30275
	private int hn6c0URv4x0;

	// Token: 0x04007644 RID: 30276
	private int zshc0Nl11xx;

	// Token: 0x04007645 RID: 30277
	private int JwLc0EYiQvX;

	// Token: 0x04007646 RID: 30278
	private int qdQc0PkEmKw;

	// Token: 0x04007647 RID: 30279
	private int cFQc0SB7gqY;

	// Token: 0x04007648 RID: 30280
	private int uq5c0BPs4X6;

	// Token: 0x04007649 RID: 30281
	private int w5gc00mqqP3;

	// Token: 0x0400764A RID: 30282
	private int vZXc08Xx8kO;

	// Token: 0x020012D3 RID: 4819
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$37103 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F15 RID: 28437 RVA: 0x00F5C968 File Offset: 0x00F5AB68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$37103(M100_GameTutorial3 self_)
		{
			if (39155 - 574767 != -535612)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (267101 - 332763 == -65662)
				{
					base..ctor();
					if (232006 - 185474 == 46532)
					{
						this.$self_$37109 = self_;
						if (23151 - 5385 != 17767)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006F16 RID: 28438 RVA: 0x00F5CA00 File Offset: 0x00F5AC00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$StartEvent$37103.$(this.$self_$37109);
		}

		// Token: 0x06006F17 RID: 28439 RVA: 0x00F5CA10 File Offset: 0x00F5AC10
		internal static bool UHAIkvpMLU2xVhsQ783e()
		{
			return true;
		}

		// Token: 0x06006F18 RID: 28440 RVA: 0x00F5CA14 File Offset: 0x00F5AC14
		internal static bool aAXQNjpMO0tumP4yDrZl()
		{
			return false;
		}

		// Token: 0x0400764B RID: 30283
		internal M100_GameTutorial3 $self_$37109;

		// Token: 0x020012D4 RID: 4820
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F19 RID: 28441 RVA: 0x00F5CA18 File Offset: 0x00F5AC18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial3 self_)
			{
				if (27986 - 353927 != -325940)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (257246 - 458907 != -201660)
					{
						base..ctor();
						if (109236 - 387185 != -277948)
						{
							this.$self_$37108 = self_;
							if (151019 - 234533 != -83513)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006F1A RID: 28442 RVA: 0x00F5CAB0 File Offset: 0x00F5ACB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (197887 - 519934 != -322047)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_599;
					case 1:
						goto IL_692;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (250340 - 499522 != -249182)
							{
								continue;
							}
							goto IL_2BB;
						}
						else
						{
							this.$self_$37108.D20c0pwpjZq.StartCoroutine_Auto(this.$self_$37108.D20c0pwpjZq.slerpToObject("EventCamera2", (float)2));
							if (160509 - 378023 != -217514)
							{
								continue;
							}
							goto IL_280;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (168930 - 391579 != -222648)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$37108.D20c0pwpjZq.alignToObject("EventCamera3");
							if (50904 - 315913 == -265008)
							{
								continue;
							}
							this.$mStoryGui$37104 = (StoryGui)this.$self_$37108.GetComponent(typeof(StoryGui));
							if (89939 - 535000 != -445061)
							{
								continue;
							}
							this.$mStoryTimer$37105 = 0f;
							if (212485 - 13534 == 198952)
							{
								continue;
							}
							if (!this.$mStoryGui$37104)
							{
								if (116414 - 166447 != -50033)
								{
									continue;
								}
								goto IL_663;
							}
							else
							{
								this.$mKangaroo$37106 = GameObject.Find("Kangaroo");
								if (176879 - 178774 == -1894)
								{
									continue;
								}
								this.$mStoryGui$37104.startStoryMessage("Kangaroo", "Kuru", eTalkType.friend);
								if (224989 - 393874 != -168884)
								{
									goto Block_5;
								}
								continue;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (269987 - 422301 != -152314)
							{
								continue;
							}
							goto IL_151;
						}
						else
						{
							this.$mStoryGui$37104.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 201), eTalkType.friend);
							if (169451 - 251984 == -82532)
							{
								continue;
							}
							if (this.$mKangaroo$37106)
							{
								if (5388 - 218003 != -212615)
								{
									continue;
								}
								this.$mKangaroo$37106.animation.CrossFade("talk", 0.2f);
								if (21391 - 521412 == -500020)
								{
									continue;
								}
							}
							this.$mStoryTimer$37105 = Time.time + 4f;
							if (96264 - 166099 != -69835)
							{
								continue;
							}
							goto IL_5C8;
						}
						break;
					case 5:
						break;
					case 6:
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (61740 - 182191 != -120451)
							{
								continue;
							}
							goto IL_3AD;
						}
						else
						{
							this.$self_$37108.D20c0pwpjZq.enabled = true;
							if (47615 - 243091 == -195475)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (44219 - 5827 != 38392)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (264586 - 65106 != 199480)
							{
								continue;
							}
							this.$mGameGui$37107 = (GameGui)this.$self_$37108.GetComponent(typeof(GameGui));
							if (130390 - 416697 != -286307)
							{
								continue;
							}
							this.$mGameGui$37107.enabled = true;
							if (234518 - 310311 != -75793)
							{
								continue;
							}
							this.$self_$37108.SendMessage("newGameMessage", "New Mission Objective: Talk to Kuru.");
							if (210462 - 302162 == -91699)
							{
								continue;
							}
							Chat.SubmitChat("none", "New Mission Objective: Talk to Kuru", eChatType.system, eChatMode.system);
							if (74053 - 185073 == -111019)
							{
								continue;
							}
							this.YieldDefault(1);
							if (141382 - 484528 != -343146)
							{
								continue;
							}
							goto IL_692;
						}
						break;
					default:
						if (69726 - 290165 != -220439)
						{
							continue;
						}
						goto IL_599;
					}
					if (this.$mStoryTimer$37105 > Time.time)
					{
						if (108525 - 91625 == 16901)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5E3;
						}
						if (165660 - 34594 != 131066)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (58807 - 204836 != -146029)
						{
							continue;
						}
						goto IL_EE;
					}
					else
					{
						if (this.$mKangaroo$37106)
						{
							if (13751 - 179802 == -166050)
							{
								continue;
							}
							this.$mKangaroo$37106.animation.CrossFade("root", 0.5f);
							if (72052 - 502717 == -430664)
							{
								continue;
							}
						}
						this.$mStoryGui$37104.close();
						if (155913 - 207839 == -51925)
						{
							continue;
						}
						this.$self_$37108.D20c0pwpjZq.StartCoroutine_Auto(this.$self_$37108.D20c0pwpjZq.slerpToObject("EventCamera4", 1.5f));
						if (81919 - 373150 != -291230)
						{
							goto Block_33;
						}
						continue;
					}
					IL_599:
					this.$self_$37108.D20c0pwpjZq.alignToObject("EventCamera1");
					if (238744 - 566024 != -327279)
					{
						this.$self_$37108.SendMessage("fadeIn");
						if (141134 - 240308 == -99174)
						{
							break;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_5:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_EE:
				IL_151:
				goto IL_692;
				IL_280:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_19:
				IL_2BB:
				IL_3AD:
				goto IL_692;
				Block_33:
				return this.Yield(7, new WaitForSeconds(2f));
				IL_5C8:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_5E3:
				return this.YieldDefault(6);
				IL_663:
				IL_692:
				return false;
			}

			// Token: 0x06006F1B RID: 28443 RVA: 0x00F5D164 File Offset: 0x00F5B364
			internal static bool HqY06FpMmo743apTiWSc()
			{
				return true;
			}

			// Token: 0x06006F1C RID: 28444 RVA: 0x00F5D168 File Offset: 0x00F5B368
			internal static bool DvsSXYpMFXiVslfhtsvU()
			{
				return false;
			}

			// Token: 0x0400764C RID: 30284
			internal StoryGui $mStoryGui$37104;

			// Token: 0x0400764D RID: 30285
			internal float $mStoryTimer$37105;

			// Token: 0x0400764E RID: 30286
			internal GameObject $mKangaroo$37106;

			// Token: 0x0400764F RID: 30287
			internal GameGui $mGameGui$37107;

			// Token: 0x04007650 RID: 30288
			internal M100_GameTutorial3 $self_$37108;
		}
	}

	// Token: 0x020012D5 RID: 4821
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToKangaroo$37110 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F1D RID: 28445 RVA: 0x00F5D16C File Offset: 0x00F5B36C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToKangaroo$37110(M100_GameTutorial3 self_)
		{
			if (255917 - 502367 != -246449)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (137268 - 449817 != -312548)
				{
					base..ctor();
					if (86195 - 101127 == -14932)
					{
						this.$self_$37117 = self_;
						if (23447 - 114128 == -90681)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006F1E RID: 28446 RVA: 0x00F5D204 File Offset: 0x00F5B404
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$TalkToKangaroo$37110.$(this.$self_$37117);
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x00F5D214 File Offset: 0x00F5B414
		internal static bool mIf9YEpMMWfuQipaxxGa()
		{
			return true;
		}

		// Token: 0x06006F20 RID: 28448 RVA: 0x00F5D218 File Offset: 0x00F5B418
		internal static bool CRRVCHpMxBbZnd5jcyvv()
		{
			return false;
		}

		// Token: 0x04007651 RID: 30289
		internal M100_GameTutorial3 $self_$37117;

		// Token: 0x020012D6 RID: 4822
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F21 RID: 28449 RVA: 0x00F5D21C File Offset: 0x00F5B41C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial3 self_)
			{
				if (227241 - 511056 != -283815)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (55089 - 383860 == -328771)
					{
						base..ctor();
						if (268155 - 507730 != -239574)
						{
							this.$self_$37116 = self_;
							if (74273 - 168620 != -94346)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006F22 RID: 28450 RVA: 0x00F5D2B4 File Offset: 0x00F5B4B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (181318 - 442042 != -260724)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1C35;
					case 1:
						goto IL_2FDF;
					case 2:
						if (this.$mKangaroo$37112)
						{
							if (298799 - 558309 == -259509)
							{
								continue;
							}
							this.$mKangaroo$37112.animation.CrossFade("talk", 0.2f);
							if (250286 - 539134 != -288848)
							{
								continue;
							}
						}
						if (this.$self_$37116.zshc0Nl11xx < 1)
						{
							if (105762 - 40833 != 64929)
							{
								continue;
							}
							this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 211), eTalkType.friend);
							if (127584 - 127569 != 15)
							{
								continue;
							}
							this.$mStoryTimer$37115 = Time.time + 4f;
							if (2039 - 350738 != -348698)
							{
								goto Block_119;
							}
							continue;
						}
						else if (this.$self_$37116.hn6c0URv4x0 < 5)
						{
							if (277063 - 384241 == -107177)
							{
								continue;
							}
							this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 300), eTalkType.friend);
							if (162217 - 31958 == 130260)
							{
								continue;
							}
							this.$mStoryTimer$37115 = Time.time + 4f;
							if (289605 - 62721 != 226885)
							{
								goto Block_98;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 301), eTalkType.friend);
							if (187377 - 303666 == -116288)
							{
								continue;
							}
							this.$mStoryTimer$37115 = Time.time + 4f;
							if (191596 - 47579 != 144018)
							{
								goto Block_92;
							}
							continue;
						}
						break;
					case 3:
						goto IL_2626;
					case 4:
						goto IL_2626;
					case 5:
						goto IL_24A0;
					case 6:
						goto IL_24A0;
					case 7:
						goto IL_1A4A;
					case 8:
						goto IL_1A4A;
					case 9:
						goto IL_14ED;
					case 10:
						goto IL_14ED;
					case 11:
						goto IL_EC4;
					case 12:
						goto IL_EC4;
					case 13:
						goto IL_29DD;
					case 14:
						goto IL_29DD;
					case 15:
						goto IL_2118;
					case 16:
						goto IL_2118;
					case 17:
						goto IL_2542;
					case 18:
						goto IL_2542;
					case 19:
						goto IL_10A0;
					case 20:
						goto IL_10A0;
					case 21:
						goto IL_290C;
					case 22:
						goto IL_290C;
					case 23:
						goto IL_1744;
					case 24:
						goto IL_1744;
					case 25:
						goto IL_10F3;
					case 26:
						goto IL_10F3;
					case 27:
						goto IL_777;
					case 28:
						goto IL_777;
					case 29:
						goto IL_906;
					case 30:
						goto IL_906;
					case 31:
						goto IL_1430;
					case 32:
						goto IL_1430;
					case 33:
						goto IL_295F;
					case 34:
						goto IL_295F;
					case 35:
						break;
					case 36:
						break;
					case 37:
						goto IL_1E28;
					case 38:
						goto IL_1E28;
					case 39:
						goto IL_2300;
					case 40:
						goto IL_2300;
					case 41:
						goto IL_20C5;
					case 42:
						goto IL_20C5;
					case 43:
						goto IL_A9B;
					case 44:
						goto IL_A9B;
					case 45:
						goto IL_22AD;
					case 46:
						goto IL_22AD;
					case 47:
						goto IL_2E0;
					case 48:
						goto IL_2E0;
					case 49:
						goto IL_2F3D;
					case 50:
						goto IL_2F3D;
					case 51:
						goto IL_237D;
					case 52:
						goto IL_237D;
					case 53:
						goto IL_645;
					case 54:
						goto IL_19F4;
					case 55:
						goto IL_D8F;
					case 56:
						goto IL_D8F;
					case 57:
						goto IL_2FB5;
					case 58:
						goto IL_2FB5;
					case 59:
						goto IL_579;
					case 60:
						goto IL_579;
					case 61:
						goto IL_2890;
					case 62:
						goto IL_2890;
					case 63:
						goto IL_1146;
					case 64:
						goto IL_1146;
					case 65:
						goto IL_AEE;
					case 66:
						goto IL_AEE;
					case 67:
						goto IL_2B49;
					case 68:
						goto IL_2B49;
					case 69:
						goto IL_26DF;
					case 70:
						goto IL_45C;
					case 71:
						goto IL_21C1;
					case 72:
						goto IL_21C1;
					case 73:
						goto IL_1DAC;
					case 74:
						goto IL_1DAC;
					case 75:
						goto IL_2DBA;
					case 76:
						goto IL_2DBA;
					case 77:
						goto IL_85F;
					case 78:
						goto IL_85F;
					case 79:
						if (Game.mGameState != eGameState.Hold)
						{
							if (7062 - 533854 != -526791)
							{
								goto Block_27;
							}
							continue;
						}
						else if (this.$self_$37116.zshc0Nl11xx < 2)
						{
							if (188285 - 341718 != -153433)
							{
								continue;
							}
							this.$self_$37116.D20c0pwpjZq.enabled = true;
							if (33681 - 526994 == -493312)
							{
								continue;
							}
							this.$mGameGui$37113.enabled = true;
							if (132842 - 305800 == -172957)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (63226 - 363795 != -300569)
							{
								continue;
							}
							goto IL_1882;
						}
						else
						{
							Game.mGameState = eGameState.AllHold;
							if (148909 - 552688 != -403779)
							{
								continue;
							}
							goto IL_E36;
						}
						break;
					case 80:
						Game.sendMissionEvent(1007, 0);
						if (95826 - 380876 != -285050)
						{
							continue;
						}
						goto IL_1882;
					default:
						if (290977 - 408306 != -117329)
						{
							continue;
						}
						goto IL_1C35;
					}
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (258950 - 143742 == 115209)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_36;
						}
						if (76109 - 210798 != -134689)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (220897 - 260935 != -40038)
						{
							continue;
						}
						goto IL_1CA9;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 309), eTalkType.friend);
						if (49426 - 246169 != -196743)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (45016 - 240186 != -195170)
						{
							continue;
						}
						goto IL_1DFF;
					}
					IL_2118:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (152558 - 385329 != -232771)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_210B;
						}
						if (159431 - 291719 == -132287)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (71005 - 503045 != -432040)
						{
							continue;
						}
						goto IL_1244;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 218), eTalkType.friend);
						if (167019 - 19744 == 147276)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (40189 - 306312 != -266123)
						{
							continue;
						}
						goto IL_2519;
					}
					IL_2626:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (270055 - 26373 != 243682)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_261A;
						}
						if (106593 - 96836 != 9757)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (168543 - 289467 != -120923)
						{
							goto Block_40;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 212), eTalkType.friend);
						if (293685 - 530926 != -237241)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (54650 - 113338 != -58688)
						{
							continue;
						}
						goto IL_2479;
					}
					IL_20C5:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (221720 - 522833 == -301112)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_20B8;
						}
						if (264810 - 453131 != -188321)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (264867 - 461141 != -196274)
						{
							continue;
						}
						goto IL_27B3;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 312), eTalkType.friend);
						if (152038 - 174807 != -22769)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (274844 - 303480 != -28636)
						{
							continue;
						}
						goto IL_A72;
					}
					IL_EC4:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (299688 - 254383 != 45305)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_EB7;
						}
						if (151914 - 379145 != -227231)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (111507 - 485186 != -373679)
						{
							continue;
						}
						goto IL_709;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 216), eTalkType.friend);
						if (117264 - 2631 == 114634)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (123230 - 327801 != -204571)
						{
							continue;
						}
						goto IL_29B4;
					}
					IL_2300:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (237102 - 18527 == 218576)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_22F3;
						}
						if (216553 - 556050 != -339497)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (28874 - 581115 != -552241)
						{
							continue;
						}
						goto IL_CFC;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 311), eTalkType.friend);
						if (260929 - 507219 != -246290)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (40027 - 437023 != -396996)
						{
							continue;
						}
						goto IL_209C;
					}
					IL_21C1:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (181203 - 384488 == -203284)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_21B4;
						}
						if (270076 - 283224 == -13147)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (237945 - 348191 != -110246)
						{
							continue;
						}
						goto IL_1E3;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 325), eTalkType.friend);
						if (77672 - 544695 == -467022)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (160032 - 576142 != -416109)
						{
							goto Block_118;
						}
						continue;
					}
					IL_24A0:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (124240 - 204871 != -80631)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2494;
						}
						if (79818 - 24544 != 55274)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (264403 - 150505 != 113899)
						{
							goto Block_293;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 213), eTalkType.friend);
						if (115662 - 292515 != -176853)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (66933 - 479331 != -412398)
						{
							continue;
						}
						goto IL_1A23;
					}
					IL_2E0:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (299040 - 556182 != -257142)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2D3;
						}
						if (107932 - 490712 == -382779)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (76071 - 481725 != -405653)
						{
							goto Block_76;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 315), eTalkType.friend);
						if (166994 - 371072 != -204078)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (16346 - 300452 != -284105)
						{
							goto Block_30;
						}
						continue;
					}
					IL_1A4A:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (66226 - 559789 != -493563)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1A3E;
						}
						if (48254 - 25638 == 22617)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (65080 - 275959 != -210878)
						{
							goto Block_113;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 214), eTalkType.friend);
						if (77263 - 149225 != -71962)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (200899 - 372119 != -171220)
						{
							continue;
						}
						goto IL_14C4;
					}
					IL_45C:
					if (this.$self_$37116.epQc0wjJn72 == 801)
					{
						goto IL_44F;
					}
					if (264776 - 219701 == 45076)
					{
						continue;
					}
					this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 324), eTalkType.friend);
					if (299552 - 347350 != -47798)
					{
						continue;
					}
					this.$mStoryTimer$37115 = Time.time + 4f;
					if (35175 - 43848 != -8672)
					{
						goto Block_177;
					}
					continue;
					IL_1C35:
					if (Game.mGameState != eGameState.Normal)
					{
						if (111846 - 454558 != -342712)
						{
							continue;
						}
						goto IL_1BBC;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (153614 - 201420 != -47806)
						{
							continue;
						}
						this.$mPlayer$37111 = Game.mPlayer;
						if (171746 - 441430 == -269683)
						{
							continue;
						}
						this.$mKangaroo$37112 = GameObject.Find("Kangaroo");
						if (157095 - 225163 == -68067)
						{
							continue;
						}
						if (this.$mKangaroo$37112)
						{
							if (22647 - 538346 == -515698)
							{
								continue;
							}
							if (this.$mPlayer$37111)
							{
								if (192668 - 106174 == 86495)
								{
									continue;
								}
								this.$mPlayer$37111.SendMessage("turnToPos", this.$mKangaroo$37112.transform.position);
								if (131019 - 305283 == -174263)
								{
									continue;
								}
								this.$mKangaroo$37112.transform.rotation = Quaternion.LookRotation(this.$mPlayer$37111.transform.position - this.$mKangaroo$37112.transform.position);
								if (271886 - 551041 != -279155)
								{
									continue;
								}
							}
						}
						this.$mGameGui$37113 = (GameGui)this.$self_$37116.GetComponent(typeof(GameGui));
						if (30457 - 534549 == -504091)
						{
							continue;
						}
						if (this.$mGameGui$37113)
						{
							if (219062 - 171326 != 47736)
							{
								continue;
							}
							this.$mGameGui$37113.close();
							if (251546 - 64870 == 186677)
							{
								continue;
							}
						}
						this.$mStoryGui$37114 = (StoryGui)this.$self_$37116.GetComponent(typeof(StoryGui));
						if (12382 - 538062 != -525680)
						{
							continue;
						}
						this.$mStoryTimer$37115 = 0f;
						if (165835 - 37136 != 128699)
						{
							continue;
						}
						if (!this.$mStoryGui$37114)
						{
							goto IL_333;
						}
						if (259743 - 175236 == 84508)
						{
							continue;
						}
						this.$self_$37116.D20c0pwpjZq.StartCoroutine_Auto(this.$self_$37116.D20c0pwpjZq.slerpToObject("KuruCamera", (float)1));
						if (131571 - 307322 != -175751)
						{
							continue;
						}
						this.$mStoryGui$37114.startStoryMessage("Kangaroo", "Kuru", eTalkType.friend);
						if (26810 - 205750 != -178940)
						{
							continue;
						}
						goto IL_197D;
					}
					IL_AEE:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (11630 - 246731 == -235100)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_AE1;
						}
						if (112838 - 29585 == 83254)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (224084 - 341215 != -117130)
						{
							goto Block_42;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 323), eTalkType.friend);
						if (190415 - 520171 == -329755)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (3489 - 168656 != -165167)
						{
							continue;
						}
						goto IL_2B20;
					}
					IL_1146:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (137765 - 80236 != 57529)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1139;
						}
						if (24503 - 62321 != -37818)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (88212 - 58579 != 29633)
						{
							continue;
						}
						goto IL_2A4C;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 322), eTalkType.friend);
						if (151988 - 588610 != -436622)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (182516 - 319216 != -136699)
						{
							goto Block_43;
						}
						continue;
					}
					IL_579:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (246222 - 50920 == 195303)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_56C;
						}
						if (131454 - 155409 != -23955)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (148364 - 251287 != -102923)
						{
							continue;
						}
						goto IL_1EF6;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 320), eTalkType.friend);
						if (208715 - 56296 == 152420)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (285969 - 342737 != -56768)
						{
							continue;
						}
						goto IL_2867;
					}
					IL_2F3D:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (64565 - 380506 != -315941)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2F30;
						}
						if (280350 - 63956 != 216394)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (50406 - 59326 != -8919)
						{
							goto Block_78;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 316), eTalkType.friend);
						if (208437 - 302577 == -94139)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (252536 - 319328 != -66791)
						{
							goto Block_128;
						}
						continue;
					}
					IL_645:
					if (this.$self_$37116.epQc0wjJn72 == 600)
					{
						goto IL_638;
					}
					if (90529 - 372658 != -282129)
					{
						continue;
					}
					this.$self_$37116.epQc0wjJn72 = 601;
					if (278713 - 387878 != -109164)
					{
						goto IL_19F4;
					}
					continue;
					IL_2B49:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (85280 - 358921 == -273640)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2B3C;
						}
						if (184996 - 586613 == -401616)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (152854 - 579839 != -426984)
						{
							goto Block_54;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.blank();
						if (78538 - 440915 == -362376)
						{
							continue;
						}
						this.$self_$37116.epQc0wjJn72 = 800;
						if (113725 - 26599 != 87127)
						{
							goto IL_26DF;
						}
						continue;
					}
					IL_777:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (197175 - 493410 == -296234)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_76A;
						}
						if (113884 - 463979 == -350094)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (255589 - 470661 != -215071)
						{
							goto Block_289;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 305), eTalkType.friend);
						if (86000 - 151320 != -65320)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (59450 - 232022 != -172571)
						{
							goto Block_135;
						}
						continue;
					}
					IL_1430:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (228933 - 311171 != -82238)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1423;
						}
						if (288453 - 560815 != -272362)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (149018 - 386716 != -237697)
						{
							goto Block_62;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 307), eTalkType.friend);
						if (209756 - 301710 == -91953)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (257663 - 357560 != -99897)
						{
							continue;
						}
						goto IL_2936;
					}
					IL_2FB5:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (310 - 124941 != -124631)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2FA8;
						}
						if (30144 - 14948 == 15197)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (75865 - 338708 != -262842)
						{
							goto Block_269;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 319), eTalkType.friend);
						if (267037 - 177717 != 89320)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (262075 - 459807 != -197732)
						{
							continue;
						}
						goto IL_550;
					}
					IL_85F:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (67173 - 134029 == -66855)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_852;
						}
						if (196671 - 32022 != 164649)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (143301 - 154514 != -11212)
						{
							goto Block_95;
						}
						continue;
					}
					else
					{
						this.$self_$37116.zshc0Nl11xx = 2;
						if (180348 - 390859 != -210510)
						{
							goto IL_23D2;
						}
						continue;
					}
					IL_906:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (270236 - 28904 != 241332)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_8F9;
						}
						if (84594 - 228054 != -143460)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (26854 - 78278 != -51424)
						{
							continue;
						}
						goto IL_183D;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 306), eTalkType.friend);
						if (218521 - 596202 == -377680)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (83056 - 131941 != -48885)
						{
							continue;
						}
						goto IL_1407;
					}
					IL_10A0:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (11706 - 574102 == -562395)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1093;
						}
						if (22901 - 566241 != -543340)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Hold)
					{
						goto IL_23D2;
					}
					if (30180 - 194711 != -164531)
					{
						continue;
					}
					goto IL_13BD;
					IL_1744:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (260063 - 166356 != 93707)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1737;
						}
						if (208415 - 117562 == 90854)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (262110 - 390423 != -128313)
						{
							continue;
						}
						goto IL_1938;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 303), eTalkType.friend);
						if (163813 - 6075 != 157738)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (159619 - 182872 != -23252)
						{
							goto Block_116;
						}
						continue;
					}
					IL_A9B:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (44442 - 325999 == -281556)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_A8E;
						}
						if (36603 - 223972 != -187369)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (216176 - 167561 != 48616)
						{
							goto Block_347;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 313), eTalkType.friend);
						if (35855 - 231063 == -195207)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (258179 - 12062 != 246117)
						{
							continue;
						}
						goto IL_2284;
					}
					IL_29DD:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (272415 - 452140 == -179724)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_29D0;
						}
						if (260372 - 317088 != -56716)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (94493 - 579563 != -485069)
						{
							goto Block_90;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 217), eTalkType.friend);
						if (138131 - 115088 == 23044)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (237586 - 165450 != 72136)
						{
							continue;
						}
						goto IL_20EF;
					}
					IL_D8F:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (271167 - 420217 == -149049)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_D82;
						}
						if (250828 - 65557 != 185271)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (156884 - 11 != 156873)
						{
							continue;
						}
						goto IL_147F;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 318), eTalkType.friend);
						if (87822 - 115032 != -27210)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (167684 - 179596 != -11911)
						{
							goto Block_272;
						}
						continue;
					}
					IL_237D:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (130817 - 161623 != -30806)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2370;
						}
						if (272521 - 327130 == -54608)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (230727 - 167257 != 63471)
						{
							goto Block_340;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.blank();
						if (12169 - 503189 == -491019)
						{
							continue;
						}
						this.$self_$37116.epQc0wjJn72 = 600;
						if (192105 - 436622 != -244516)
						{
							goto IL_645;
						}
						continue;
					}
					IL_2542:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (55474 - 205551 != -150077)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2535;
						}
						if (299677 - 239006 == 60672)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (47266 - 61246 != -13980)
						{
							continue;
						}
						goto IL_F56;
					}
					else
					{
						this.$self_$37116.zshc0Nl11xx = 1;
						if (183665 - 72271 != 111394)
						{
							continue;
						}
						goto IL_23D2;
					}
					IL_1E28:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (5254 - 269018 == -263763)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1E1B;
						}
						if (275961 - 116036 != 159925)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (103173 - 203940 != -100766)
						{
							goto Block_115;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 310), eTalkType.friend);
						if (94260 - 218865 == -124604)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (131504 - 219952 != -88447)
						{
							goto Block_322;
						}
						continue;
					}
					IL_1DAC:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (84817 - 444120 == -359302)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1D9F;
						}
						if (33396 - 190112 != -156716)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (276366 - 26897 != 249470)
						{
							goto Block_207;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 326), eTalkType.friend);
						if (9150 - 162344 != -153194)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (73259 - 183502 != -110243)
						{
							continue;
						}
						goto IL_2D91;
					}
					IL_10F3:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (248497 - 578878 != -330381)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_10E6;
						}
						if (200182 - 51908 != 148274)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (94367 - 259674 != -165306)
						{
							goto Block_139;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 304), eTalkType.friend);
						if (72259 - 213369 == -141109)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (125985 - 66675 != 59311)
						{
							goto Block_218;
						}
						continue;
					}
					IL_2DBA:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (131051 - 183922 == -52870)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2DAD;
						}
						if (87599 - 303278 == -215678)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (101093 - 72053 != 29041)
						{
							goto Block_161;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 327), eTalkType.friend);
						if (190980 - 499649 != -308669)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (254713 - 434246 != -179532)
						{
							goto Block_137;
						}
						continue;
					}
					IL_14ED:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (137027 - 392154 != -255127)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_14E0;
						}
						if (29654 - 67734 == -38079)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (29491 - 265659 != -236167)
						{
							goto Block_143;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 215), eTalkType.friend);
						if (94043 - 62573 == 31471)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (64840 - 239558 != -174718)
						{
							continue;
						}
						goto IL_E9B;
					}
					IL_2890:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (88010 - 320438 != -232428)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2883;
						}
						if (233391 - 216297 != 17094)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (172161 - 69405 != 102757)
						{
							goto Block_148;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 321), eTalkType.friend);
						if (269687 - 144316 == 125372)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (170474 - 242567 != -72093)
						{
							continue;
						}
						goto IL_111D;
					}
					IL_23D2:
					if (this.$mKangaroo$37112)
					{
						if (181248 - 106371 != 74877)
						{
							continue;
						}
						this.$mKangaroo$37112.animation.CrossFade("root", 0.5f);
						if (190933 - 250297 != -59364)
						{
							continue;
						}
					}
					this.$mStoryGui$37114.close();
					if (272468 - 138868 != 133601)
					{
						goto Block_169;
					}
					continue;
					IL_1882:
					this.YieldDefault(1);
					if (30503 - 241355 != -210852)
					{
						continue;
					}
					goto IL_2FDF;
					IL_22AD:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (19404 - 178801 != -159397)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_22A0;
						}
						if (27385 - 265069 == -237683)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (130936 - 327718 != -196781)
						{
							goto Block_216;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 314), eTalkType.friend);
						if (260674 - 251963 == 8712)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (176589 - 456276 != -279686)
						{
							goto Block_229;
						}
						continue;
					}
					IL_19F4:
					if (this.$self_$37116.epQc0wjJn72 == 601)
					{
						goto IL_19E7;
					}
					if (51333 - 243812 == -192478)
					{
						continue;
					}
					this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 317), eTalkType.friend);
					if (102350 - 32504 == 69847)
					{
						continue;
					}
					this.$mStoryTimer$37115 = Time.time + 4f;
					if (6784 - 538170 != -531385)
					{
						goto Block_152;
					}
					continue;
					IL_295F:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (286193 - 494166 != -207973)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2952;
						}
						if (13836 - 149752 == -135915)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (132681 - 37434 != 95248)
						{
							goto Block_261;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 308), eTalkType.friend);
						if (269011 - 189680 == 79332)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (247001 - 161922 != 85079)
						{
							continue;
						}
						break;
					}
					IL_290C:
					if (this.$mStoryTimer$37115 > Time.time)
					{
						if (14264 - 208018 == -193753)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_28FF;
						}
						if (200286 - 464161 == -263874)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (93172 - 406183 != -313011)
						{
							continue;
						}
						goto IL_21EB;
					}
					else
					{
						this.$mStoryGui$37114.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 302), eTalkType.friend);
						if (104606 - 61833 == 42774)
						{
							continue;
						}
						this.$mStoryTimer$37115 = Time.time + 4f;
						if (201887 - 545666 != -343779)
						{
							continue;
						}
						goto IL_171B;
					}
					IL_26DF:
					if (this.$self_$37116.epQc0wjJn72 == 800)
					{
						goto IL_26D2;
					}
					if (194258 - 358882 != -164623)
					{
						this.$self_$37116.epQc0wjJn72 = 801;
						if (176392 - 38061 != 138332)
						{
							goto IL_45C;
						}
					}
				}
				return this.Yield(35, new WaitForSeconds(0.5f));
				IL_36:
				return this.YieldDefault(36);
				IL_1E3:
				goto IL_2FDF;
				IL_2D3:
				return this.YieldDefault(48);
				IL_333:
				return this.Yield(79, new WaitForSeconds(0.5f));
				Block_27:
				goto IL_2FDF;
				Block_30:
				return this.Yield(49, new WaitForSeconds(0.5f));
				IL_44F:
				return this.YieldDefault(70);
				Block_40:
				Block_42:
				goto IL_2FDF;
				Block_43:
				return this.Yield(65, new WaitForSeconds(0.5f));
				IL_550:
				return this.Yield(59, new WaitForSeconds(0.5f));
				IL_56C:
				return this.YieldDefault(60);
				IL_638:
				return this.YieldDefault(53);
				Block_54:
				IL_709:
				goto IL_2FDF;
				IL_76A:
				return this.YieldDefault(28);
				Block_62:
				goto IL_2FDF;
				IL_852:
				return this.YieldDefault(78);
				IL_8F9:
				return this.YieldDefault(30);
				Block_76:
				Block_78:
				goto IL_2FDF;
				IL_A72:
				return this.Yield(43, new WaitForSeconds(0.5f));
				IL_A8E:
				return this.YieldDefault(44);
				IL_AE1:
				return this.YieldDefault(66);
				Block_90:
				goto IL_2FDF;
				Block_92:
				return this.Yield(21, new WaitForSeconds(0.5f));
				IL_CFC:
				Block_95:
				goto IL_2FDF;
				IL_D82:
				return this.YieldDefault(56);
				Block_98:
				return this.Yield(19, new WaitForSeconds(0.5f));
				IL_E36:
				return this.Yield(80, new WaitForSeconds(1f));
				IL_E9B:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_EB7:
				return this.YieldDefault(12);
				IL_F56:
				Block_113:
				Block_115:
				goto IL_2FDF;
				Block_116:
				return this.Yield(25, new WaitForSeconds(0.5f));
				Block_118:
				return this.Yield(73, new WaitForSeconds(0.5f));
				Block_119:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_1093:
				return this.YieldDefault(20);
				IL_10E6:
				return this.YieldDefault(26);
				IL_111D:
				return this.Yield(63, new WaitForSeconds(0.5f));
				IL_1139:
				return this.YieldDefault(64);
				Block_128:
				return this.Yield(51, new WaitForSeconds(0.5f));
				IL_1244:
				goto IL_2FDF;
				Block_135:
				return this.Yield(29, new WaitForSeconds(0.5f));
				Block_137:
				return this.Yield(77, new WaitForSeconds(0.5f));
				Block_139:
				Block_143:
				IL_13BD:
				goto IL_2FDF;
				IL_1407:
				return this.Yield(31, new WaitForSeconds(0.5f));
				IL_1423:
				return this.YieldDefault(32);
				Block_148:
				IL_147F:
				goto IL_2FDF;
				IL_14C4:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_14E0:
				return this.YieldDefault(10);
				Block_152:
				return this.Yield(55, new WaitForSeconds(0.5f));
				Block_161:
				goto IL_2FDF;
				IL_171B:
				return this.Yield(23, new WaitForSeconds(0.5f));
				IL_1737:
				return this.YieldDefault(24);
				Block_169:
				goto IL_333;
				IL_183D:
				goto IL_2FDF;
				Block_177:
				return this.Yield(71, new WaitForSeconds(0.5f));
				IL_1938:
				goto IL_2FDF;
				IL_197D:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_19E7:
				return this.YieldDefault(54);
				IL_1A23:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_1A3E:
				return this.YieldDefault(8);
				IL_1BBC:
				IL_1CA9:
				Block_207:
				goto IL_2FDF;
				IL_1D9F:
				return this.YieldDefault(74);
				IL_1DFF:
				return this.Yield(37, new WaitForSeconds(0.5f));
				IL_1E1B:
				return this.YieldDefault(38);
				Block_216:
				goto IL_2FDF;
				Block_218:
				return this.Yield(27, new WaitForSeconds(0.5f));
				IL_1EF6:
				goto IL_2FDF;
				Block_229:
				return this.Yield(47, new WaitForSeconds(0.5f));
				IL_209C:
				return this.Yield(41, new WaitForSeconds(0.5f));
				IL_20B8:
				return this.YieldDefault(42);
				IL_20EF:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_210B:
				return this.YieldDefault(16);
				IL_21B4:
				return this.YieldDefault(72);
				IL_21EB:
				goto IL_2FDF;
				IL_2284:
				return this.Yield(45, new WaitForSeconds(0.5f));
				IL_22A0:
				return this.YieldDefault(46);
				IL_22F3:
				return this.YieldDefault(40);
				IL_2370:
				return this.YieldDefault(52);
				IL_2479:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_2494:
				return this.YieldDefault(6);
				Block_261:
				goto IL_2FDF;
				IL_2519:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_2535:
				return this.YieldDefault(18);
				Block_269:
				goto IL_2FDF;
				IL_261A:
				return this.YieldDefault(4);
				Block_272:
				return this.Yield(57, new WaitForSeconds(0.5f));
				IL_26D2:
				return this.YieldDefault(69);
				IL_27B3:
				Block_289:
				Block_293:
				goto IL_2FDF;
				IL_2867:
				return this.Yield(61, new WaitForSeconds(0.5f));
				IL_2883:
				return this.YieldDefault(62);
				IL_28FF:
				return this.YieldDefault(22);
				IL_2936:
				return this.Yield(33, new WaitForSeconds(0.5f));
				IL_2952:
				return this.YieldDefault(34);
				IL_29B4:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_29D0:
				return this.YieldDefault(14);
				IL_2A4C:
				goto IL_2FDF;
				IL_2B20:
				return this.Yield(67, new WaitForSeconds(0.5f));
				IL_2B3C:
				return this.YieldDefault(68);
				Block_322:
				return this.Yield(39, new WaitForSeconds(0.5f));
				IL_2D91:
				return this.Yield(75, new WaitForSeconds(0.5f));
				IL_2DAD:
				return this.YieldDefault(76);
				Block_340:
				goto IL_2FDF;
				IL_2F30:
				return this.YieldDefault(50);
				Block_347:
				goto IL_2FDF;
				IL_2FA8:
				return this.YieldDefault(58);
				IL_2FDF:
				return false;
			}

			// Token: 0x06006F23 RID: 28451 RVA: 0x00F602B4 File Offset: 0x00F5E4B4
			internal static bool R2BAPApMgvdi6qAMT2i8()
			{
				return true;
			}

			// Token: 0x06006F24 RID: 28452 RVA: 0x00F602B8 File Offset: 0x00F5E4B8
			internal static bool GBcoPxpMf2yCh87YsW6R()
			{
				return false;
			}

			// Token: 0x04007652 RID: 30290
			internal GameObject $mPlayer$37111;

			// Token: 0x04007653 RID: 30291
			internal GameObject $mKangaroo$37112;

			// Token: 0x04007654 RID: 30292
			internal GameGui $mGameGui$37113;

			// Token: 0x04007655 RID: 30293
			internal StoryGui $mStoryGui$37114;

			// Token: 0x04007656 RID: 30294
			internal float $mStoryTimer$37115;

			// Token: 0x04007657 RID: 30295
			internal M100_GameTutorial3 $self_$37116;
		}
	}

	// Token: 0x020012D7 RID: 4823
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToBear$37118 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F25 RID: 28453 RVA: 0x00F602BC File Offset: 0x00F5E4BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToBear$37118(M100_GameTutorial3 self_)
		{
			if (39756 - 127488 != -87731)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (239908 - 312392 == -72484)
				{
					base..ctor();
					if (88336 - 154274 == -65938)
					{
						this.$self_$37125 = self_;
						if (265779 - 382589 == -116810)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006F26 RID: 28454 RVA: 0x00F60354 File Offset: 0x00F5E554
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$TalkToBear$37118.$(this.$self_$37125);
		}

		// Token: 0x06006F27 RID: 28455 RVA: 0x00F60364 File Offset: 0x00F5E564
		internal static bool Ytw3xypMnnT3srYbgDoI()
		{
			return true;
		}

		// Token: 0x06006F28 RID: 28456 RVA: 0x00F60368 File Offset: 0x00F5E568
		internal static bool CgVIhKpM6msdsQSLkPfp()
		{
			return false;
		}

		// Token: 0x04007658 RID: 30296
		internal M100_GameTutorial3 $self_$37125;

		// Token: 0x020012D8 RID: 4824
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F29 RID: 28457 RVA: 0x00F6036C File Offset: 0x00F5E56C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial3 self_)
			{
				if (296617 - 174137 != 122480)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (36619 - 25215 == 11404)
					{
						base..ctor();
						if (182027 - 283815 != -101787)
						{
							this.$self_$37124 = self_;
							if (239142 - 570677 != -331534)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006F2A RID: 28458 RVA: 0x00F60404 File Offset: 0x00F5E604
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (263404 - 446322 != -182917)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_634;
					case 1:
						goto IL_FBC;
					case 2:
						if (this.$mBear$37120)
						{
							if (234802 - 147807 == 86996)
							{
								continue;
							}
							this.$mBear$37120.animation.CrossFade("talk", 0.2f);
							if (30708 - 132787 != -102079)
							{
								continue;
							}
						}
						if (this.$self_$37124.JwLc0EYiQvX < 1)
						{
							if (258215 - 235883 != 22332)
							{
								continue;
							}
							this.$mStoryGui$37122.newStoryMessage("Bear", "Mimi", Language.getMessage("M100_GameTutorial", 231), eTalkType.friend);
							if (71391 - 78211 == -6819)
							{
								continue;
							}
							this.$mStoryTimer$37123 = Time.time + 4f;
							if (23606 - 277751 != -254144)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$37122.newStoryMessage("Bear", "Mimi", Language.getMessage("M100_GameTutorial", 238), eTalkType.friend);
							if (68747 - 32065 == 36683)
							{
								continue;
							}
							this.$mStoryTimer$37123 = Time.time + 4f;
							if (72417 - 204215 != -131797)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						goto IL_DC4;
					case 6:
						goto IL_DC4;
					case 7:
						goto IL_B1B;
					case 8:
						goto IL_B1B;
					case 9:
						goto IL_1E7;
					case 10:
						goto IL_1E7;
					case 11:
						goto IL_98A;
					case 12:
						goto IL_98A;
					case 13:
						goto IL_757;
					case 14:
						goto IL_757;
					case 15:
						goto IL_6FF;
					case 16:
						goto IL_3BE;
					case 17:
						goto IL_87F;
					case 18:
						goto IL_87F;
					case 19:
						goto IL_8FD;
					case 20:
						goto IL_8FD;
					case 21:
						if (Game.mGameState != eGameState.Hold)
						{
							if (228594 - 149155 != 79440)
							{
								goto Block_104;
							}
							continue;
						}
						else
						{
							this.$self_$37124.D20c0pwpjZq.enabled = true;
							if (56462 - 287602 != -231140)
							{
								continue;
							}
							this.$mGameGui$37121.enabled = true;
							if (126146 - 95639 == 30508)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (2948 - 151232 != -148284)
							{
								continue;
							}
							this.$self_$37124.SendMessage("newGameMessage", "Mission Objective: Talk to NPC " + this.$self_$37124.hn6c0URv4x0 + "/5");
							if (142644 - 212478 == -69833)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mission Objective: Talk to NPC " + this.$self_$37124.hn6c0URv4x0 + "/5", eChatType.system, eChatMode.system);
							if (283569 - 150806 == 132764)
							{
								continue;
							}
							this.YieldDefault(1);
							if (93932 - 274485 != -180552)
							{
								goto Block_91;
							}
							continue;
						}
						break;
					default:
						if (173283 - 222022 != -48738)
						{
							goto IL_634;
						}
						continue;
					}
					if (this.$mStoryTimer$37123 > Time.time)
					{
						if (231512 - 578681 != -347169)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_154;
						}
						if (6372 - 425725 != -419353)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (243245 - 178062 != 65184)
						{
							goto Block_69;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37122.newStoryMessage("Bear", "Mimi", Language.getMessage("M100_GameTutorial", 232), eTalkType.friend);
						if (206547 - 565424 != -358877)
						{
							continue;
						}
						this.$mStoryTimer$37123 = Time.time + 4f;
						if (118796 - 492971 != -374174)
						{
							goto Block_48;
						}
						continue;
					}
					IL_DC4:
					if (this.$mStoryTimer$37123 > Time.time)
					{
						if (38427 - 446903 != -408476)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_DB8;
						}
						if (194604 - 493516 != -298912)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (94995 - 276845 != -181849)
						{
							goto Block_34;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37122.newStoryMessage("Bear", "Mimi", Language.getMessage("M100_GameTutorial", 233), eTalkType.friend);
						if (265406 - 481827 == -216420)
						{
							continue;
						}
						this.$mStoryTimer$37123 = Time.time + 4f;
						if (801 - 140083 != -139281)
						{
							goto Block_62;
						}
						continue;
					}
					IL_1E7:
					if (this.$mStoryTimer$37123 > Time.time)
					{
						if (225663 - 126737 == 98927)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1DA;
						}
						if (108110 - 64958 != 43152)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (160646 - 518919 != -358273)
						{
							continue;
						}
						goto IL_CE9;
					}
					else
					{
						this.$mStoryGui$37122.newStoryMessage("Bear", "Mimi", Language.getMessage("M100_GameTutorial", 235), eTalkType.friend);
						if (105571 - 298866 == -193294)
						{
							continue;
						}
						this.$mStoryTimer$37123 = Time.time + 4f;
						if (234371 - 94019 != 140352)
						{
							continue;
						}
						goto IL_961;
					}
					IL_87F:
					if (this.$mStoryTimer$37123 > Time.time)
					{
						if (299823 - 487136 == -187312)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_872;
						}
						if (2728 - 130579 != -127851)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (234673 - 250685 != -16011)
						{
							goto Block_37;
						}
						continue;
					}
					else
					{
						this.$self_$37124.JwLc0EYiQvX = this.$self_$37124.JwLc0EYiQvX + 1;
						if (169857 - 188620 != -18763)
						{
							continue;
						}
						this.$self_$37124.hn6c0URv4x0 = this.$self_$37124.hn6c0URv4x0 + 1;
						if (180714 - 312233 != -131519)
						{
							continue;
						}
					}
					IL_296:
					this.$mStoryGui$37122.close();
					if (171115 - 480729 == -309613)
					{
						continue;
					}
					if (!this.$mBear$37120)
					{
						goto IL_E8D;
					}
					if (234790 - 294470 != -59680)
					{
						continue;
					}
					this.$mBear$37120.animation.CrossFade("root", 0.5f);
					if (42169 - 143499 != -101329)
					{
						goto Block_72;
					}
					continue;
					IL_8FD:
					if (this.$mStoryTimer$37123 > Time.time)
					{
						if (195350 - 468669 == -273318)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_8F0;
						}
						if (108975 - 256817 != -147842)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Hold)
					{
						goto IL_296;
					}
					if (82191 - 551815 != -469623)
					{
						goto Block_22;
					}
					continue;
					IL_757:
					if (this.$mStoryTimer$37123 > Time.time)
					{
						if (54934 - 384578 == -329643)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_74A;
						}
						if (11748 - 76203 != -64455)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (51800 - 50376 != 1425)
						{
							goto Block_101;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37122.blank();
						if (104266 - 500013 == -395746)
						{
							continue;
						}
						this.$self_$37124.epQc0wjJn72 = 500;
						if (13604 - 360164 != -346559)
						{
							goto IL_6FF;
						}
						continue;
					}
					IL_634:
					if (Game.mGameState != eGameState.Normal)
					{
						if (237734 - 402687 != -164953)
						{
							continue;
						}
						goto IL_387;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (288874 - 494098 == -205223)
						{
							continue;
						}
						this.$mPlayer$37119 = Game.mPlayer;
						if (195118 - 216763 != -21645)
						{
							continue;
						}
						this.$mBear$37120 = GameObject.Find("Bear");
						if (6653 - 382953 == -376299)
						{
							continue;
						}
						if (this.$mBear$37120)
						{
							if (102320 - 135301 == -32980)
							{
								continue;
							}
							if (this.$mPlayer$37119)
							{
								if (144239 - 410492 != -266253)
								{
									continue;
								}
								this.$mPlayer$37119.SendMessage("turnToPos", this.$mBear$37120.transform.position);
								if (165012 - 215249 == -50236)
								{
									continue;
								}
							}
						}
						this.$mGameGui$37121 = (GameGui)this.$self_$37124.GetComponent(typeof(GameGui));
						if (83407 - 426837 != -343430)
						{
							continue;
						}
						if (this.$mGameGui$37121)
						{
							if (253367 - 587059 == -333691)
							{
								continue;
							}
							this.$mGameGui$37121.close();
							if (216760 - 470386 != -253626)
							{
								continue;
							}
						}
						this.$mStoryGui$37122 = (StoryGui)this.$self_$37124.GetComponent(typeof(StoryGui));
						if (241270 - 425497 != -184227)
						{
							continue;
						}
						this.$mStoryTimer$37123 = 0f;
						if (293502 - 86304 != 207198)
						{
							continue;
						}
						if (!this.$mStoryGui$37122)
						{
							goto IL_E8D;
						}
						if (106204 - 11624 != 94580)
						{
							continue;
						}
						this.$self_$37124.D20c0pwpjZq.StartCoroutine_Auto(this.$self_$37124.D20c0pwpjZq.slerpToObject("BearCamera", (float)1));
						if (132549 - 108619 != 23930)
						{
							continue;
						}
						this.$mStoryGui$37122.startStoryMessage("Bear", "Mimi", eTalkType.friend);
						if (49345 - 311230 != -261885)
						{
							continue;
						}
						goto IL_F45;
					}
					IL_3BE:
					if (this.$self_$37124.epQc0wjJn72 == 501)
					{
						goto IL_3B1;
					}
					if (287492 - 116411 == 171082)
					{
						continue;
					}
					this.$mStoryGui$37122.newStoryMessage("Bear", "Mimi", Language.getMessage("M100_GameTutorial", 237), eTalkType.friend);
					if (161742 - 530936 != -369194)
					{
						continue;
					}
					this.$mStoryTimer$37123 = Time.time + 4f;
					if (55389 - 331201 != -275812)
					{
						continue;
					}
					goto IL_856;
					IL_98A:
					if (this.$mStoryTimer$37123 > Time.time)
					{
						if (28845 - 89598 == -60752)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_97D;
						}
						if (67824 - 477673 != -409849)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (74313 - 13799 != 60515)
						{
							goto Block_39;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37122.newStoryMessage("Bear", "Mimi", Language.getMessage("M100_GameTutorial", 236), eTalkType.friend);
						if (21095 - 292726 != -271631)
						{
							continue;
						}
						this.$mStoryTimer$37123 = Time.time + 4f;
						if (109399 - 178141 != -68741)
						{
							goto Block_102;
						}
						continue;
					}
					IL_6FF:
					if (this.$self_$37124.epQc0wjJn72 == 500)
					{
						goto IL_6F2;
					}
					if (16066 - 507164 != -491098)
					{
						continue;
					}
					this.$self_$37124.epQc0wjJn72 = 501;
					if (104532 - 587206 != -482673)
					{
						goto IL_3BE;
					}
					continue;
					IL_B1B:
					if (this.$mStoryTimer$37123 > Time.time)
					{
						if (83341 - 147246 == -63904)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_B0F;
						}
						if (257854 - 249547 == 8308)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (101241 - 457736 == -356495)
						{
							goto IL_A86;
						}
					}
					else
					{
						this.$mStoryGui$37122.newStoryMessage("Bear", "Mimi", Language.getMessage("M100_GameTutorial", 234), eTalkType.friend);
						if (237667 - 432949 != -195281)
						{
							this.$mStoryTimer$37123 = Time.time + 4f;
							if (289453 - 162268 != 127186)
							{
								goto Block_53;
							}
						}
					}
				}
				Block_5:
				return this.Yield(19, new WaitForSeconds(0.5f));
				IL_154:
				return this.YieldDefault(4);
				IL_1DA:
				return this.YieldDefault(10);
				Block_22:
				IL_387:
				goto IL_FBC;
				IL_3B1:
				return this.YieldDefault(16);
				Block_34:
				Block_37:
				Block_39:
				goto IL_FBC;
				Block_40:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_48:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_6F2:
				return this.YieldDefault(15);
				IL_74A:
				return this.YieldDefault(14);
				Block_53:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_856:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_872:
				return this.YieldDefault(18);
				Block_62:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_8F0:
				return this.YieldDefault(20);
				IL_961:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_97D:
				return this.YieldDefault(12);
				Block_69:
				goto IL_FBC;
				Block_72:
				goto IL_E8D;
				IL_A86:
				goto IL_FBC;
				IL_B0F:
				return this.YieldDefault(8);
				Block_91:
				IL_CE9:
				goto IL_FBC;
				IL_DB8:
				return this.YieldDefault(6);
				Block_101:
				goto IL_FBC;
				Block_102:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_E8D:
				return this.Yield(21, new WaitForSeconds(0.5f));
				Block_104:
				goto IL_FBC;
				IL_F45:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_FBC:
				return false;
			}

			// Token: 0x06006F2B RID: 28459 RVA: 0x00F613E0 File Offset: 0x00F5F5E0
			internal static bool sCfSE5pMiamWwgtcgxLY()
			{
				return true;
			}

			// Token: 0x06006F2C RID: 28460 RVA: 0x00F613E4 File Offset: 0x00F5F5E4
			internal static bool E9pVbXpMKRSJKSrnwXnP()
			{
				return false;
			}

			// Token: 0x04007659 RID: 30297
			internal GameObject $mPlayer$37119;

			// Token: 0x0400765A RID: 30298
			internal GameObject $mBear$37120;

			// Token: 0x0400765B RID: 30299
			internal GameGui $mGameGui$37121;

			// Token: 0x0400765C RID: 30300
			internal StoryGui $mStoryGui$37122;

			// Token: 0x0400765D RID: 30301
			internal float $mStoryTimer$37123;

			// Token: 0x0400765E RID: 30302
			internal M100_GameTutorial3 $self_$37124;
		}
	}

	// Token: 0x020012D9 RID: 4825
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToOwl1$37126 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F2D RID: 28461 RVA: 0x00F613E8 File Offset: 0x00F5F5E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToOwl1$37126(M100_GameTutorial3 self_)
		{
			if (57314 - 465804 != -408489)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217379 - 478323 != -260943)
				{
					base..ctor();
					if (280758 - 410951 == -130193)
					{
						this.$self_$37133 = self_;
						if (56391 - 287282 == -230891)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006F2E RID: 28462 RVA: 0x00F61480 File Offset: 0x00F5F680
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$TalkToOwl1$37126.$(this.$self_$37133);
		}

		// Token: 0x06006F2F RID: 28463 RVA: 0x00F61490 File Offset: 0x00F5F690
		internal static bool XcSbsjpMdmqApvaFXjuy()
		{
			return true;
		}

		// Token: 0x06006F30 RID: 28464 RVA: 0x00F61494 File Offset: 0x00F5F694
		internal static bool jDYLGopMJ987Ra1O8s9H()
		{
			return false;
		}

		// Token: 0x0400765F RID: 30303
		internal M100_GameTutorial3 $self_$37133;

		// Token: 0x020012DA RID: 4826
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F31 RID: 28465 RVA: 0x00F61498 File Offset: 0x00F5F698
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial3 self_)
			{
				if (6659 - 458901 != -452242)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (143084 - 26644 == 116440)
					{
						base..ctor();
						if (262703 - 191423 == 71280)
						{
							this.$self_$37132 = self_;
							if (220200 - 133178 == 87022)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006F32 RID: 28466 RVA: 0x00F61530 File Offset: 0x00F5F730
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (254814 - 592211 != -337396)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_57F;
					case 1:
						goto IL_DA0;
					case 2:
						if (this.$mOwl1$37128)
						{
							if (40870 - 176515 != -135645)
							{
								continue;
							}
							this.$mOwl1$37128.animation.CrossFade("talk", 0.2f);
							if (43148 - 12182 != 30966)
							{
								continue;
							}
						}
						if (this.$self_$37132.qdQc0PkEmKw < 1)
						{
							if (147172 - 470395 != -323223)
							{
								continue;
							}
							this.$mStoryGui$37130.newStoryMessage("Owl1", "Xin Fu", Language.getMessage("M100_GameTutorial", 241), eTalkType.friend);
							if (109205 - 343076 == -233870)
							{
								continue;
							}
							this.$mStoryTimer$37131 = Time.time + 4f;
							if (133125 - 411260 != -278135)
							{
								continue;
							}
							goto IL_52E;
						}
						else
						{
							this.$mStoryGui$37130.newStoryMessage("Owl1", "Xin Fu", Language.getMessage("M100_GameTutorial", 247), eTalkType.friend);
							if (44405 - 199526 == -155120)
							{
								continue;
							}
							this.$mStoryTimer$37131 = Time.time + 4f;
							if (144057 - 290385 != -146327)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 3:
						goto IL_555;
					case 4:
						goto IL_555;
					case 5:
						goto IL_7DC;
					case 6:
						goto IL_7DC;
					case 7:
						goto IL_1B3;
					case 8:
						goto IL_1B3;
					case 9:
						break;
					case 10:
						break;
					case 11:
						goto IL_6A8;
					case 12:
						goto IL_6A8;
					case 13:
						goto IL_206;
					case 14:
						goto IL_206;
					case 15:
						goto IL_2D8;
					case 16:
						goto IL_2D8;
					case 17:
						if (Game.mGameState != eGameState.Hold)
						{
							if (260065 - 472128 != -212063)
							{
								continue;
							}
							goto IL_BDD;
						}
						else
						{
							this.$self_$37132.D20c0pwpjZq.enabled = true;
							if (224887 - 7737 == 217151)
							{
								continue;
							}
							this.$mGameGui$37129.enabled = true;
							if (222959 - 135988 == 86972)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (175774 - 140414 == 35361)
							{
								continue;
							}
							this.$self_$37132.SendMessage("newGameMessage", "Mission Objective: Talk to NPC " + this.$self_$37132.hn6c0URv4x0 + "/5");
							if (215350 - 489402 == -274051)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mission Objective: Talk to NPC " + this.$self_$37132.hn6c0URv4x0 + "/5", eChatType.system, eChatMode.system);
							if (164970 - 85325 != 79645)
							{
								continue;
							}
							this.YieldDefault(1);
							if (130376 - 488413 != -358037)
							{
								continue;
							}
							goto IL_DA0;
						}
						break;
					default:
						if (69706 - 248522 != -178815)
						{
							goto IL_57F;
						}
						continue;
					}
					if (this.$mStoryTimer$37131 > Time.time)
					{
						if (178156 - 61104 != 117052)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_CBB;
						}
						if (215618 - 57611 != 158007)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (268797 - 377791 != -108994)
						{
							continue;
						}
						goto IL_806;
					}
					else
					{
						this.$mStoryGui$37130.newStoryMessage("Owl1", "Xin Fu", Language.getMessage("M100_GameTutorial", 245), eTalkType.friend);
						if (2809 - 64228 == -61418)
						{
							continue;
						}
						this.$mStoryTimer$37131 = Time.time + 4f;
						if (203003 - 306774 != -103770)
						{
							goto Block_27;
						}
						continue;
					}
					IL_206:
					if (this.$mStoryTimer$37131 > Time.time)
					{
						if (166898 - 94818 == 72081)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1F9;
						}
						if (210984 - 225127 != -14143)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (239977 - 94536 != 145441)
						{
							continue;
						}
						goto IL_155;
					}
					else
					{
						this.$self_$37132.qdQc0PkEmKw = this.$self_$37132.qdQc0PkEmKw + 1;
						if (91594 - 441257 == -349662)
						{
							continue;
						}
						this.$self_$37132.hn6c0URv4x0 = this.$self_$37132.hn6c0URv4x0 + 1;
						if (205791 - 394262 != -188470)
						{
							goto IL_765;
						}
						continue;
					}
					IL_1B3:
					if (this.$mStoryTimer$37131 > Time.time)
					{
						if (215242 - 481482 == -266239)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1A7;
						}
						if (130343 - 438042 != -307699)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (253798 - 239224 != 14575)
						{
							goto Block_90;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37130.newStoryMessage("Owl1", "Xin Fu", Language.getMessage("M100_GameTutorial", 244), eTalkType.friend);
						if (90841 - 28269 != 62572)
						{
							continue;
						}
						this.$mStoryTimer$37131 = Time.time + 4f;
						if (179459 - 565433 != -385974)
						{
							continue;
						}
						goto IL_C9F;
					}
					IL_2D8:
					if (this.$mStoryTimer$37131 > Time.time)
					{
						if (200139 - 444982 == -244842)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2CB;
						}
						if (131615 - 344262 != -212647)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Hold)
					{
						goto IL_765;
					}
					if (276053 - 535021 != -258968)
					{
						continue;
					}
					goto IL_760;
					IL_7DC:
					if (this.$mStoryTimer$37131 > Time.time)
					{
						if (54950 - 88370 == -33419)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_7D0;
						}
						if (111210 - 188685 != -77475)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (261741 - 413216 != -151475)
						{
							continue;
						}
						goto IL_32B;
					}
					else
					{
						this.$mStoryGui$37130.newStoryMessage("Owl1", "Xin Fu", Language.getMessage("M100_GameTutorial", 243), eTalkType.friend);
						if (211083 - 437871 != -226788)
						{
							continue;
						}
						this.$mStoryTimer$37131 = Time.time + 4f;
						if (87332 - 3076 != 84257)
						{
							goto Block_77;
						}
						continue;
					}
					IL_555:
					if (this.$mStoryTimer$37131 > Time.time)
					{
						if (46810 - 362235 == -315424)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_549;
						}
						if (208120 - 59436 != 148684)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (100065 - 76350 != 23715)
						{
							continue;
						}
						goto IL_6FB;
					}
					else
					{
						this.$mStoryGui$37130.newStoryMessage("Owl1", "Xin Fu", Language.getMessage("M100_GameTutorial", 242), eTalkType.friend);
						if (71176 - 272164 != -200988)
						{
							continue;
						}
						this.$mStoryTimer$37131 = Time.time + 4f;
						if (109180 - 317326 != -208146)
						{
							continue;
						}
						goto IL_7B5;
					}
					IL_57F:
					if (Game.mGameState != eGameState.Normal)
					{
						if (149136 - 357324 != -208188)
						{
							continue;
						}
						goto IL_A9E;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (60957 - 187956 != -126999)
						{
							continue;
						}
						this.$mPlayer$37127 = Game.mPlayer;
						if (182518 - 328303 == -145784)
						{
							continue;
						}
						this.$mOwl1$37128 = GameObject.Find("Owl1");
						if (239866 - 397881 == -158014)
						{
							continue;
						}
						if (this.$mOwl1$37128)
						{
							if (298272 - 185358 != 112914)
							{
								continue;
							}
							if (this.$mPlayer$37127)
							{
								if (124303 - 375069 != -250766)
								{
									continue;
								}
								this.$mPlayer$37127.SendMessage("turnToPos", this.$mOwl1$37128.transform.position);
								if (87404 - 425511 == -338106)
								{
									continue;
								}
							}
						}
						this.$mGameGui$37129 = (GameGui)this.$self_$37132.GetComponent(typeof(GameGui));
						if (122784 - 329315 == -206530)
						{
							continue;
						}
						if (this.$mGameGui$37129)
						{
							if (10935 - 200412 == -189476)
							{
								continue;
							}
							this.$mGameGui$37129.close();
							if (245956 - 296934 != -50978)
							{
								continue;
							}
						}
						this.$mStoryGui$37130 = (StoryGui)this.$self_$37132.GetComponent(typeof(StoryGui));
						if (247886 - 46142 == 201745)
						{
							continue;
						}
						this.$mStoryTimer$37131 = 0f;
						if (257133 - 124403 != 132730)
						{
							continue;
						}
						if (!this.$mStoryGui$37130)
						{
							goto IL_9F3;
						}
						if (99074 - 492313 == -393238)
						{
							continue;
						}
						this.$self_$37132.D20c0pwpjZq.StartCoroutine_Auto(this.$self_$37132.D20c0pwpjZq.slerpToObject("OwlCamera", (float)1));
						if (221443 - 418072 == -196628)
						{
							continue;
						}
						this.$mStoryGui$37130.startStoryMessage("Owl1", "Xin Fu", eTalkType.friend);
						if (104910 - 216199 != -111288)
						{
							goto Block_67;
						}
						continue;
					}
					IL_6A8:
					if (this.$mStoryTimer$37131 > Time.time)
					{
						if (125388 - 38782 != 86606)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_69B;
						}
						if (47844 - 435424 != -387580)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (72244 - 324779 != -252535)
						{
							continue;
						}
						goto IL_A2F;
					}
					else
					{
						this.$mStoryGui$37130.newStoryMessage("Owl1", "Xin Fu", Language.getMessage("M100_GameTutorial", 246), eTalkType.friend);
						if (30038 - 25398 == 4641)
						{
							continue;
						}
						this.$mStoryTimer$37131 = Time.time + 4f;
						if (270886 - 564876 != -293989)
						{
							goto Block_88;
						}
						continue;
					}
					IL_765:
					this.$mStoryGui$37130.close();
					if (21239 - 296014 != -274774)
					{
						if (!this.$mOwl1$37128)
						{
							goto IL_9F3;
						}
						if (35696 - 570886 == -535190)
						{
							this.$mOwl1$37128.animation.CrossFade("root", 0.5f);
							if (50572 - 363375 == -312803)
							{
								goto IL_9F3;
							}
						}
					}
				}
				Block_2:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_155:
				goto IL_DA0;
				IL_1A7:
				return this.YieldDefault(8);
				IL_1F9:
				return this.YieldDefault(14);
				IL_2CB:
				return this.YieldDefault(16);
				IL_32B:
				goto IL_DA0;
				Block_27:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_52E:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_549:
				return this.YieldDefault(4);
				IL_69B:
				return this.YieldDefault(12);
				IL_6FB:
				IL_760:
				goto IL_DA0;
				IL_7B5:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_7D0:
				return this.YieldDefault(6);
				IL_806:
				goto IL_DA0;
				Block_67:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_9F3:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_A2F:
				IL_A9E:
				goto IL_DA0;
				Block_77:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_BDD:
				goto IL_DA0;
				Block_88:
				return this.Yield(13, new WaitForSeconds(0.5f));
				Block_90:
				goto IL_DA0;
				IL_C9F:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_CBB:
				return this.YieldDefault(10);
				IL_DA0:
				return false;
			}

			// Token: 0x06006F33 RID: 28467 RVA: 0x00F622F0 File Offset: 0x00F604F0
			internal static bool eFGfLrpMDw9hhvVLRhB3()
			{
				return true;
			}

			// Token: 0x06006F34 RID: 28468 RVA: 0x00F622F4 File Offset: 0x00F604F4
			internal static bool cZNpPGpMvcUliLGLdHW1()
			{
				return false;
			}

			// Token: 0x04007660 RID: 30304
			internal GameObject $mPlayer$37127;

			// Token: 0x04007661 RID: 30305
			internal GameObject $mOwl1$37128;

			// Token: 0x04007662 RID: 30306
			internal GameGui $mGameGui$37129;

			// Token: 0x04007663 RID: 30307
			internal StoryGui $mStoryGui$37130;

			// Token: 0x04007664 RID: 30308
			internal float $mStoryTimer$37131;

			// Token: 0x04007665 RID: 30309
			internal M100_GameTutorial3 $self_$37132;
		}
	}

	// Token: 0x020012DB RID: 4827
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMouse$37134 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F35 RID: 28469 RVA: 0x00F622F8 File Offset: 0x00F604F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMouse$37134(M100_GameTutorial3 self_)
		{
			if (243359 - 94319 != 149041)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (168483 - 48482 == 120001)
				{
					base..ctor();
					if (122839 - 472528 == -349689)
					{
						this.$self_$37141 = self_;
						if (205630 - 188113 == 17517)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006F36 RID: 28470 RVA: 0x00F62390 File Offset: 0x00F60590
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$TalkToMouse$37134.$(this.$self_$37141);
		}

		// Token: 0x06006F37 RID: 28471 RVA: 0x00F623A0 File Offset: 0x00F605A0
		internal static bool KDFDFIpMRNjq7oTLrrrD()
		{
			return true;
		}

		// Token: 0x06006F38 RID: 28472 RVA: 0x00F623A4 File Offset: 0x00F605A4
		internal static bool hAA4EFpMwyNCmr7N9i8X()
		{
			return false;
		}

		// Token: 0x04007666 RID: 30310
		internal M100_GameTutorial3 $self_$37141;

		// Token: 0x020012DC RID: 4828
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F39 RID: 28473 RVA: 0x00F623A8 File Offset: 0x00F605A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial3 self_)
			{
				if (14134 - 285922 != -271787)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (46106 - 204878 == -158772)
					{
						base..ctor();
						if (218111 - 217302 == 809)
						{
							this.$self_$37140 = self_;
							if (185460 - 521025 != -335564)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006F3A RID: 28474 RVA: 0x00F62440 File Offset: 0x00F60640
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (275787 - 426689 != -150901)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_ABA;
					case 1:
						goto IL_DA0;
					case 2:
						if (this.$mMouse$37136)
						{
							if (20937 - 147757 != -126820)
							{
								continue;
							}
							this.$mMouse$37136.animation.CrossFade("talk", 0.2f);
							if (59282 - 480065 == -420782)
							{
								continue;
							}
						}
						if (this.$self_$37140.cFQc0SB7gqY < 1)
						{
							if (177448 - 55234 != 122214)
							{
								continue;
							}
							this.$mStoryGui$37138.newStoryMessage("Mouse", "Abette", Language.getMessage("M100_GameTutorial", 251), eTalkType.friend);
							if (223162 - 170772 == 52391)
							{
								continue;
							}
							this.$mStoryTimer$37139 = Time.time + 4f;
							if (38105 - 553094 != -514989)
							{
								continue;
							}
							goto IL_C8C;
						}
						else
						{
							this.$mStoryGui$37138.newStoryMessage("Mouse", "Abette", Language.getMessage("M100_GameTutorial", 257), eTalkType.friend);
							if (124776 - 45353 == 79424)
							{
								continue;
							}
							this.$mStoryTimer$37139 = Time.time + 4f;
							if (259953 - 284843 != -24890)
							{
								continue;
							}
							goto IL_739;
						}
						break;
					case 3:
						goto IL_CB3;
					case 4:
						goto IL_CB3;
					case 5:
						goto IL_953;
					case 6:
						goto IL_953;
					case 7:
						goto IL_9C9;
					case 8:
						goto IL_9C9;
					case 9:
						goto IL_24B;
					case 10:
						goto IL_24B;
					case 11:
						break;
					case 12:
						break;
					case 13:
						goto IL_D06;
					case 14:
						goto IL_D06;
					case 15:
						goto IL_762;
					case 16:
						goto IL_762;
					case 17:
						if (Game.mGameState != eGameState.Hold)
						{
							if (197149 - 218376 != -21227)
							{
								continue;
							}
							goto IL_B6E;
						}
						else
						{
							this.$self_$37140.D20c0pwpjZq.enabled = true;
							if (247525 - 388767 != -141242)
							{
								continue;
							}
							this.$mGameGui$37137.enabled = true;
							if (252641 - 454880 != -202239)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (278128 - 322520 != -44392)
							{
								continue;
							}
							this.$self_$37140.SendMessage("newGameMessage", "Mission Objective: Talk to NPC " + this.$self_$37140.hn6c0URv4x0 + "/5");
							if (129913 - 120108 != 9805)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mission Objective: Talk to NPC " + this.$self_$37140.hn6c0URv4x0 + "/5", eChatType.system, eChatMode.system);
							if (45063 - 353391 == -308327)
							{
								continue;
							}
							this.YieldDefault(1);
							if (105250 - 516322 != -411071)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					default:
						if (205682 - 565752 != -360069)
						{
							goto IL_ABA;
						}
						continue;
					}
					if (this.$mStoryTimer$37139 > Time.time)
					{
						if (272278 - 68893 != 203385)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_181;
						}
						if (259278 - 576114 != -316836)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (280060 - 119811 != 160249)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37138.newStoryMessage("Mouse", "Abette", Language.getMessage("M100_GameTutorial", 256), eTalkType.friend);
						if (216622 - 428416 != -211794)
						{
							continue;
						}
						this.$mStoryTimer$37139 = Time.time + 4f;
						if (42021 - 176783 != -134761)
						{
							goto Block_52;
						}
						continue;
					}
					IL_9C9:
					if (this.$mStoryTimer$37139 > Time.time)
					{
						if (103069 - 566512 != -463443)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_9BD;
						}
						if (215246 - 297564 == -82317)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (157690 - 208825 != -51134)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37138.newStoryMessage("Mouse", "Abette", Language.getMessage("M100_GameTutorial", 254), eTalkType.friend);
						if (165614 - 275815 != -110201)
						{
							continue;
						}
						this.$mStoryTimer$37139 = Time.time + 4f;
						if (99066 - 154195 != -55129)
						{
							continue;
						}
						goto IL_222;
					}
					IL_24B:
					if (this.$mStoryTimer$37139 > Time.time)
					{
						if (287378 - 550182 == -262803)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_23E;
						}
						if (199681 - 321734 != -122053)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (247233 - 188154 != 59079)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37138.newStoryMessage("Mouse", "Abette", Language.getMessage("M100_GameTutorial", 255), eTalkType.friend);
						if (77347 - 209389 != -132042)
						{
							continue;
						}
						this.$mStoryTimer$37139 = Time.time + 4f;
						if (81986 - 1416 != 80571)
						{
							goto Block_39;
						}
						continue;
					}
					IL_CB3:
					if (this.$mStoryTimer$37139 > Time.time)
					{
						if (291622 - 590488 == -298865)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_CA7;
						}
						if (171349 - 384397 != -213048)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (64398 - 64364 != 34)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37138.newStoryMessage("Mouse", "Abette", Language.getMessage("M100_GameTutorial", 252), eTalkType.friend);
						if (193632 - 120856 != 72776)
						{
							continue;
						}
						this.$mStoryTimer$37139 = Time.time + 4f;
						if (80525 - 149781 != -69256)
						{
							continue;
						}
						goto IL_92C;
					}
					IL_ABA:
					if (Game.mGameState != eGameState.Normal)
					{
						if (288054 - 163107 != 124948)
						{
							break;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (157236 - 1451 != 155785)
						{
							continue;
						}
						this.$mPlayer$37135 = Game.mPlayer;
						if (15679 - 555334 != -539655)
						{
							continue;
						}
						this.$mMouse$37136 = GameObject.Find("Mouse");
						if (17739 - 22278 == -4538)
						{
							continue;
						}
						if (this.$mMouse$37136)
						{
							if (209577 - 392520 == -182942)
							{
								continue;
							}
							if (this.$mPlayer$37135)
							{
								if (243393 - 474822 != -231429)
								{
									continue;
								}
								this.$mPlayer$37135.SendMessage("turnToPos", this.$mMouse$37136.transform.position);
								if (48226 - 280021 != -231795)
								{
									continue;
								}
							}
						}
						this.$mGameGui$37137 = (GameGui)this.$self_$37140.GetComponent(typeof(GameGui));
						if (255019 - 472248 == -217228)
						{
							continue;
						}
						if (this.$mGameGui$37137)
						{
							if (163602 - 443050 == -279447)
							{
								continue;
							}
							this.$mGameGui$37137.close();
							if (86062 - 71119 != 14943)
							{
								continue;
							}
						}
						this.$mStoryGui$37138 = (StoryGui)this.$self_$37140.GetComponent(typeof(StoryGui));
						if (145129 - 428459 != -283330)
						{
							continue;
						}
						this.$mStoryTimer$37139 = 0f;
						if (111963 - 534979 == -423015)
						{
							continue;
						}
						if (!this.$mStoryGui$37138)
						{
							goto IL_395;
						}
						if (227730 - 471981 == -244250)
						{
							continue;
						}
						this.$self_$37140.D20c0pwpjZq.StartCoroutine_Auto(this.$self_$37140.D20c0pwpjZq.slerpToObject("MouseCamera", (float)1));
						if (125618 - 28947 == 96672)
						{
							continue;
						}
						this.$mStoryGui$37138.startStoryMessage("Mouse", "Abette", eTalkType.friend);
						if (213222 - 196338 != 16884)
						{
							continue;
						}
						goto IL_1B8;
					}
					IL_D06:
					if (this.$mStoryTimer$37139 > Time.time)
					{
						if (148797 - 302883 != -154086)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_CF9;
						}
						if (65698 - 329177 != -263479)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (81028 - 595267 != -514239)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$self_$37140.cFQc0SB7gqY = this.$self_$37140.cFQc0SB7gqY + 1;
						if (25192 - 283902 != -258710)
						{
							continue;
						}
						this.$self_$37140.hn6c0URv4x0 = this.$self_$37140.hn6c0URv4x0 + 1;
						if (263613 - 37188 != 226426)
						{
							goto IL_A28;
						}
						continue;
					}
					IL_953:
					if (this.$mStoryTimer$37139 > Time.time)
					{
						if (193227 - 210268 != -17041)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_947;
						}
						if (30712 - 392361 == -361648)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (90383 - 596169 != -505785)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37138.newStoryMessage("Mouse", "Abette", Language.getMessage("M100_GameTutorial", 253), eTalkType.friend);
						if (6129 - 180624 == -174494)
						{
							continue;
						}
						this.$mStoryTimer$37139 = Time.time + 4f;
						if (296683 - 76079 != 220605)
						{
							goto Block_80;
						}
						continue;
					}
					IL_762:
					if (this.$mStoryTimer$37139 > Time.time)
					{
						if (183704 - 523086 != -339382)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_755;
						}
						if (81886 - 485731 != -403845)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (234990 - 334986 != -99995)
						{
							break;
						}
						continue;
					}
					IL_A28:
					this.$mStoryGui$37138.close();
					if (84619 - 421788 == -337169)
					{
						if (!this.$mMouse$37136)
						{
							goto IL_395;
						}
						if (140689 - 364030 != -223340)
						{
							this.$mMouse$37136.animation.CrossFade("root", 0.5f);
							if (263830 - 547053 == -283223)
							{
								goto IL_395;
							}
						}
					}
				}
				goto IL_DA0;
				IL_181:
				return this.YieldDefault(12);
				IL_1B8:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_222:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_23E:
				return this.YieldDefault(10);
				IL_395:
				return this.Yield(17, new WaitForSeconds(0.5f));
				Block_34:
				goto IL_DA0;
				Block_39:
				return this.Yield(11, new WaitForSeconds(0.5f));
				goto IL_DA0;
				Block_52:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_739:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_755:
				return this.YieldDefault(16);
				goto IL_DA0;
				IL_92C:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_947:
				return this.YieldDefault(6);
				IL_9BD:
				return this.YieldDefault(8);
				goto IL_DA0;
				Block_80:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_B6E:
				goto IL_DA0;
				IL_C8C:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_CA7:
				return this.YieldDefault(4);
				IL_CF9:
				return this.YieldDefault(14);
				IL_DA0:
				return false;
			}

			// Token: 0x06006F3B RID: 28475 RVA: 0x00F63200 File Offset: 0x00F61400
			internal static bool QDSJClpMqEeymCiMRpTM()
			{
				return true;
			}

			// Token: 0x06006F3C RID: 28476 RVA: 0x00F63204 File Offset: 0x00F61404
			internal static bool knFT8xpM797tKIRkVmQM()
			{
				return false;
			}

			// Token: 0x04007667 RID: 30311
			internal GameObject $mPlayer$37135;

			// Token: 0x04007668 RID: 30312
			internal GameObject $mMouse$37136;

			// Token: 0x04007669 RID: 30313
			internal GameGui $mGameGui$37137;

			// Token: 0x0400766A RID: 30314
			internal StoryGui $mStoryGui$37138;

			// Token: 0x0400766B RID: 30315
			internal float $mStoryTimer$37139;

			// Token: 0x0400766C RID: 30316
			internal M100_GameTutorial3 $self_$37140;
		}
	}

	// Token: 0x020012DD RID: 4829
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWarthog$37142 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F3D RID: 28477 RVA: 0x00F63208 File Offset: 0x00F61408
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWarthog$37142(M100_GameTutorial3 self_)
		{
			if (119007 - 21557 != 97451)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (182505 - 344330 == -161825)
				{
					base..ctor();
					if (201904 - 490050 != -288145)
					{
						this.$self_$37149 = self_;
						if (124604 - 344648 != -220043)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006F3E RID: 28478 RVA: 0x00F632A0 File Offset: 0x00F614A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$TalkToWarthog$37142.$(this.$self_$37149);
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x00F632B0 File Offset: 0x00F614B0
		internal static bool JVuvnBpMPwDPcI3BP8yJ()
		{
			return true;
		}

		// Token: 0x06006F40 RID: 28480 RVA: 0x00F632B4 File Offset: 0x00F614B4
		internal static bool wIbQ8OpM04KmOPUeGCqA()
		{
			return false;
		}

		// Token: 0x0400766D RID: 30317
		internal M100_GameTutorial3 $self_$37149;

		// Token: 0x020012DE RID: 4830
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F41 RID: 28481 RVA: 0x00F632B8 File Offset: 0x00F614B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial3 self_)
			{
				if (123270 - 255215 != -131944)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (201471 - 163324 == 38147)
					{
						base..ctor();
						if (147203 - 429358 != -282154)
						{
							this.$self_$37148 = self_;
							if (10404 - 369025 == -358621)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006F42 RID: 28482 RVA: 0x00F63350 File Offset: 0x00F61550
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (33240 - 362786 != -329545)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_A67;
					case 1:
						goto IL_FD2;
					case 2:
						if (this.$mWarthog$37144)
						{
							if (44379 - 34124 != 10255)
							{
								continue;
							}
							this.$mWarthog$37144.animation.CrossFade("talk", 0.2f);
							if (171740 - 151555 == 20186)
							{
								continue;
							}
						}
						if (this.$self_$37148.uq5c0BPs4X6 < 1)
						{
							if (191394 - 212920 == -21525)
							{
								continue;
							}
							this.$mStoryGui$37146.newStoryMessage("Warthog", "Stein", Language.getMessage("M100_GameTutorial", 261), eTalkType.friend);
							if (33050 - 97424 == -64373)
							{
								continue;
							}
							this.$mStoryTimer$37147 = Time.time + 4f;
							if (189339 - 80883 != 108456)
							{
								continue;
							}
							goto IL_2DD;
						}
						else
						{
							this.$mStoryGui$37146.newStoryMessage("Warthog", "Stein", Language.getMessage("M100_GameTutorial", 269), eTalkType.friend);
							if (188412 - 474472 != -286060)
							{
								continue;
							}
							this.$mStoryTimer$37147 = Time.time + 4f;
							if (196060 - 142533 != 53528)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 3:
						goto IL_304;
					case 4:
						goto IL_304;
					case 5:
						goto IL_DFD;
					case 6:
						goto IL_DFD;
					case 7:
						break;
					case 8:
						break;
					case 9:
						goto IL_3BB;
					case 10:
						goto IL_3BB;
					case 11:
						goto IL_1F0;
					case 12:
						goto IL_1F0;
					case 13:
						goto IL_CD2;
					case 14:
						goto IL_CD2;
					case 15:
						goto IL_A3D;
					case 16:
						goto IL_A3D;
					case 17:
						goto IL_62C;
					case 18:
						goto IL_62C;
					case 19:
						goto IL_B69;
					case 20:
						goto IL_B69;
					case 21:
						if (Game.mGameState != eGameState.Hold)
						{
							if (7143 - 92160 != -85016)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							this.$self_$37148.D20c0pwpjZq.enabled = true;
							if (51131 - 547717 == -496585)
							{
								continue;
							}
							this.$mGameGui$37145.enabled = true;
							if (129471 - 177083 == -47611)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (226851 - 272687 == -45835)
							{
								continue;
							}
							this.$self_$37148.SendMessage("newGameMessage", "Mission Objective: Talk to NPC " + this.$self_$37148.hn6c0URv4x0 + "/5");
							if (184839 - 597798 == -412958)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mission Objective: Talk to NPC " + this.$self_$37148.hn6c0URv4x0 + "/5", eChatType.system, eChatMode.system);
							if (191273 - 546644 == -355370)
							{
								continue;
							}
							this.YieldDefault(1);
							if (142490 - 58472 != 84019)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					default:
						if (75169 - 430758 != -355589)
						{
							continue;
						}
						goto IL_A67;
					}
					if (this.$mStoryTimer$37147 > Time.time)
					{
						if (92533 - 436977 != -344444)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_857;
						}
						if (225161 - 144802 != 80359)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (160107 - 193014 != -32906)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37146.newStoryMessage("Warthog", "Stein", Language.getMessage("M100_GameTutorial", 264), eTalkType.friend);
						if (268515 - 257269 == 11247)
						{
							continue;
						}
						this.$mStoryTimer$37147 = Time.time + 4f;
						if (140190 - 306774 != -166584)
						{
							continue;
						}
						goto IL_392;
					}
					IL_A67:
					if (Game.mGameState != eGameState.Normal)
					{
						if (94040 - 127929 != -33888)
						{
							break;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (53629 - 300479 != -246850)
						{
							continue;
						}
						this.$mPlayer$37143 = Game.mPlayer;
						if (32108 - 103682 == -71573)
						{
							continue;
						}
						this.$mWarthog$37144 = GameObject.Find("Warthog");
						if (99378 - 299221 == -199842)
						{
							continue;
						}
						if (this.$mWarthog$37144)
						{
							if (12500 - 120670 != -108170)
							{
								continue;
							}
							if (this.$mPlayer$37143)
							{
								if (170991 - 479480 == -308488)
								{
									continue;
								}
								this.$mPlayer$37143.SendMessage("turnToPos", this.$mWarthog$37144.transform.position);
								if (102893 - 327003 == -224109)
								{
									continue;
								}
							}
						}
						this.$mGameGui$37145 = (GameGui)this.$self_$37148.GetComponent(typeof(GameGui));
						if (222290 - 301412 != -79122)
						{
							continue;
						}
						if (this.$mGameGui$37145)
						{
							if (146350 - 152892 == -6541)
							{
								continue;
							}
							this.$mGameGui$37145.close();
							if (120709 - 30620 == 90090)
							{
								continue;
							}
						}
						this.$mStoryGui$37146 = (StoryGui)this.$self_$37148.GetComponent(typeof(StoryGui));
						if (105319 - 126483 != -21164)
						{
							continue;
						}
						this.$mStoryTimer$37147 = 0f;
						if (56489 - 343886 != -287397)
						{
							continue;
						}
						if (!this.$mStoryGui$37146)
						{
							goto IL_4CD;
						}
						if (275183 - 285874 == -10690)
						{
							continue;
						}
						this.$self_$37148.D20c0pwpjZq.StartCoroutine_Auto(this.$self_$37148.D20c0pwpjZq.slerpToObject("WarthogCamera", (float)1));
						if (80145 - 131255 == -51109)
						{
							continue;
						}
						this.$mStoryGui$37146.startStoryMessage("Warthog", "Stein", eTalkType.friend);
						if (156692 - 525215 != -368523)
						{
							continue;
						}
						goto IL_8B6;
					}
					IL_304:
					if (this.$mStoryTimer$37147 > Time.time)
					{
						if (242585 - 527304 != -284719)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2F8;
						}
						if (229476 - 3883 != 225593)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (182193 - 473336 != -291142)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37146.newStoryMessage("Warthog", "Stein", Language.getMessage("M100_GameTutorial", 262), eTalkType.friend);
						if (126530 - 124763 != 1767)
						{
							continue;
						}
						this.$mStoryTimer$37147 = Time.time + 4f;
						if (203165 - 37033 != 166133)
						{
							goto Block_13;
						}
						continue;
					}
					IL_1F0:
					if (this.$mStoryTimer$37147 > Time.time)
					{
						if (291283 - 578918 == -287634)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1E3;
						}
						if (7570 - 301831 != -294261)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (272715 - 153833 != 118883)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37146.newStoryMessage("Warthog", "Stein", Language.getMessage("M100_GameTutorial", 266), eTalkType.friend);
						if (172011 - 465795 != -293784)
						{
							continue;
						}
						this.$mStoryTimer$37147 = Time.time + 4f;
						if (122109 - 445953 != -323844)
						{
							continue;
						}
						goto IL_CA9;
					}
					IL_B69:
					if (this.$mStoryTimer$37147 > Time.time)
					{
						if (27304 - 523697 == -496392)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_B5C;
						}
						if (120336 - 55167 == 65170)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Hold)
					{
						goto IL_6AE;
					}
					if (238449 - 496093 != -257643)
					{
						break;
					}
					continue;
					IL_62C:
					if (this.$mStoryTimer$37147 > Time.time)
					{
						if (298093 - 232038 != 66055)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_61F;
						}
						if (82074 - 162489 != -80415)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (103189 - 201257 != -98067)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$self_$37148.uq5c0BPs4X6 = this.$self_$37148.uq5c0BPs4X6 + 1;
						if (173087 - 439068 != -265981)
						{
							continue;
						}
						this.$self_$37148.hn6c0URv4x0 = this.$self_$37148.hn6c0URv4x0 + 1;
						if (227879 - 480766 == -252886)
						{
							continue;
						}
					}
					IL_6AE:
					this.$mStoryGui$37146.close();
					if (112328 - 159638 != -47310)
					{
						continue;
					}
					if (!this.$mWarthog$37144)
					{
						goto IL_4CD;
					}
					if (185794 - 50118 != 135676)
					{
						continue;
					}
					this.$mWarthog$37144.animation.CrossFade("root", 0.5f);
					if (282687 - 123094 != 159593)
					{
						continue;
					}
					goto IL_4CD;
					IL_3BB:
					if (this.$mStoryTimer$37147 > Time.time)
					{
						if (275201 - 351301 != -76100)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3AE;
						}
						if (231891 - 362648 == -130756)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (22101 - 515226 != -493124)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37146.newStoryMessage("Warthog", "Stein", Language.getMessage("M100_GameTutorial", 265), eTalkType.friend);
						if (18011 - 593416 != -575405)
						{
							continue;
						}
						this.$mStoryTimer$37147 = Time.time + 4f;
						if (277424 - 52472 != 224952)
						{
							continue;
						}
						goto IL_1C7;
					}
					IL_A3D:
					if (this.$mStoryTimer$37147 > Time.time)
					{
						if (243653 - 25408 == 218246)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_A30;
						}
						if (152322 - 59297 != 93025)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (283595 - 395017 != -111422)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37146.newStoryMessage("Warthog", "Stein", Language.getMessage("M100_GameTutorial", 268), eTalkType.friend);
						if (170227 - 225058 != -54831)
						{
							continue;
						}
						this.$mStoryTimer$37147 = Time.time + 4f;
						if (32886 - 363080 != -330194)
						{
							continue;
						}
						goto IL_603;
					}
					IL_DFD:
					if (this.$mStoryTimer$37147 > Time.time)
					{
						if (226775 - 368069 != -141294)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_DF1;
						}
						if (245465 - 36789 != 208676)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (83049 - 82188 != 861)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37146.newStoryMessage("Warthog", "Stein", Language.getMessage("M100_GameTutorial", 263), eTalkType.friend);
						if (3237 - 416908 != -413671)
						{
							continue;
						}
						this.$mStoryTimer$37147 = Time.time + 4f;
						if (77448 - 207479 != -130030)
						{
							goto Block_58;
						}
						continue;
					}
					IL_CD2:
					if (this.$mStoryTimer$37147 > Time.time)
					{
						if (152931 - 270563 != -117632)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_CC5;
						}
						if (247950 - 195914 != 52036)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (291585 - 317788 == -26203)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$37146.newStoryMessage("Warthog", "Stein", Language.getMessage("M100_GameTutorial", 267), eTalkType.friend);
						if (187643 - 505754 != -318110)
						{
							this.$mStoryTimer$37147 = Time.time + 4f;
							if (291831 - 380071 == -88240)
							{
								goto IL_A14;
							}
						}
					}
				}
				Block_11:
				goto IL_FD2;
				Block_13:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_1C7:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_1E3:
				return this.YieldDefault(12);
				goto IL_FD2;
				IL_2DD:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_2F8:
				return this.YieldDefault(4);
				IL_392:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_3AE:
				return this.YieldDefault(10);
				goto IL_FD2;
				Block_37:
				return this.Yield(19, new WaitForSeconds(0.5f));
				IL_4CD:
				return this.Yield(21, new WaitForSeconds(0.5f));
				Block_39:
				goto IL_FD2;
				IL_603:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_61F:
				return this.YieldDefault(18);
				goto IL_FD2;
				Block_58:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_857:
				return this.YieldDefault(8);
				IL_8B6:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_FD2;
				IL_A14:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_A30:
				return this.YieldDefault(16);
				goto IL_FD2;
				IL_B5C:
				return this.YieldDefault(20);
				IL_CA9:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_CC5:
				return this.YieldDefault(14);
				goto IL_FD2;
				IL_DF1:
				return this.YieldDefault(6);
				IL_FD2:
				return false;
			}

			// Token: 0x06006F43 RID: 28483 RVA: 0x00F64344 File Offset: 0x00F62544
			internal static bool UqIujIpMbQZ9PTuMaGW7()
			{
				return true;
			}

			// Token: 0x06006F44 RID: 28484 RVA: 0x00F64348 File Offset: 0x00F62548
			internal static bool YGciTopMuyorp8n61wYJ()
			{
				return false;
			}

			// Token: 0x0400766E RID: 30318
			internal GameObject $mPlayer$37143;

			// Token: 0x0400766F RID: 30319
			internal GameObject $mWarthog$37144;

			// Token: 0x04007670 RID: 30320
			internal GameGui $mGameGui$37145;

			// Token: 0x04007671 RID: 30321
			internal StoryGui $mStoryGui$37146;

			// Token: 0x04007672 RID: 30322
			internal float $mStoryTimer$37147;

			// Token: 0x04007673 RID: 30323
			internal M100_GameTutorial3 $self_$37148;
		}
	}

	// Token: 0x020012DF RID: 4831
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToAlpaca$37150 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F45 RID: 28485 RVA: 0x00F6434C File Offset: 0x00F6254C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToAlpaca$37150(M100_GameTutorial3 self_)
		{
			if (29799 - 496988 != -467189)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (25792 - 234087 == -208295)
				{
					base..ctor();
					if (262649 - 532508 == -269859)
					{
						this.$self_$37157 = self_;
						if (117054 - 318033 == -200979)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006F46 RID: 28486 RVA: 0x00F643E4 File Offset: 0x00F625E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$TalkToAlpaca$37150.$(this.$self_$37157);
		}

		// Token: 0x06006F47 RID: 28487 RVA: 0x00F643F4 File Offset: 0x00F625F4
		internal static bool GluJbGpMIl8oMV4OJbRl()
		{
			return true;
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x00F643F8 File Offset: 0x00F625F8
		internal static bool IgH094pMBBSF9107rsA1()
		{
			return false;
		}

		// Token: 0x04007674 RID: 30324
		internal M100_GameTutorial3 $self_$37157;

		// Token: 0x020012E0 RID: 4832
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F49 RID: 28489 RVA: 0x00F643FC File Offset: 0x00F625FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial3 self_)
			{
				if (178255 - 367369 != -189113)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (237923 - 427773 == -189850)
					{
						base..ctor();
						if (6051 - 577589 == -571538)
						{
							this.$self_$37156 = self_;
							if (67653 - 267650 != -199996)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006F4A RID: 28490 RVA: 0x00F64494 File Offset: 0x00F62694
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (215889 - 561912 != -346022)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						goto IL_6E;
					case 1:
						goto IL_EB9;
					case 2:
						if (this.$mAlpaca$37152)
						{
							if (22304 - 592395 == -570090)
							{
								continue;
							}
							this.$mAlpaca$37152.animation.CrossFade("talk", 0.2f);
							if (27043 - 151792 != -124749)
							{
								continue;
							}
						}
						if (this.$self_$37156.w5gc00mqqP3 < 1)
						{
							if (19919 - 361479 != -341560)
							{
								continue;
							}
							this.$mStoryGui$37154.newStoryMessage("Alpaca", "Yves", Language.getMessage("M100_GameTutorial", 271), eTalkType.friend);
							if (36368 - 575928 != -539560)
							{
								continue;
							}
							this.$mStoryTimer$37155 = Time.time + 4f;
							if (174071 - 478406 != -304335)
							{
								continue;
							}
							goto IL_49A;
						}
						else
						{
							this.$mStoryGui$37154.newStoryMessage("Alpaca", "Yves", Language.getMessage("M100_GameTutorial", 278), eTalkType.friend);
							if (132990 - 566713 == -433722)
							{
								continue;
							}
							this.$mStoryTimer$37155 = Time.time + 4f;
							if (290862 - 243760 != 47103)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					case 3:
						goto IL_4C1;
					case 4:
						goto IL_4C1;
					case 5:
						goto IL_E3;
					case 6:
						goto IL_E3;
					case 7:
						goto IL_A50;
					case 8:
						goto IL_A50;
					case 9:
						goto IL_837;
					case 10:
						goto IL_837;
					case 11:
						goto IL_670;
					case 12:
						goto IL_670;
					case 13:
						goto IL_76E;
					case 14:
						goto IL_76E;
					case 15:
						goto IL_88A;
					case 16:
						goto IL_88A;
					case 17:
						goto IL_BE3;
					case 18:
						goto IL_BE3;
					case 19:
						if (Game.mGameState != eGameState.Hold)
						{
							if (241398 - 197669 != 43730)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$self_$37156.D20c0pwpjZq.enabled = true;
							if (93534 - 271766 == -178231)
							{
								continue;
							}
							this.$mGameGui$37153.enabled = true;
							if (73497 - 579595 != -506098)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (48042 - 395719 == -347676)
							{
								continue;
							}
							this.$self_$37156.SendMessage("newGameMessage", "Mission Objective: Talk to NPC " + this.$self_$37156.hn6c0URv4x0 + "/5");
							if (24919 - 477058 == -452138)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mission Objective: Talk to NPC " + this.$self_$37156.hn6c0URv4x0 + "/5", eChatType.system, eChatMode.system);
							if (29883 - 41562 != -11679)
							{
								continue;
							}
							this.YieldDefault(1);
							if (177120 - 332933 != -155813)
							{
								continue;
							}
							goto IL_EB9;
						}
						break;
					default:
						if (12840 - 291579 != -278738)
						{
							goto IL_6E;
						}
						continue;
					}
					IL_49:
					this.$mStoryGui$37154.close();
					if (122660 - 578606 != -455946)
					{
						continue;
					}
					if (!this.$mAlpaca$37152)
					{
						goto IL_39A;
					}
					if (226446 - 576406 != -349960)
					{
						continue;
					}
					this.$mAlpaca$37152.animation.CrossFade("root", 0.5f);
					if (266965 - 591074 != -324109)
					{
						continue;
					}
					goto IL_39A;
					IL_6E:
					if (Game.mGameState != eGameState.Normal)
					{
						if (197514 - 24098 != 173417)
						{
							break;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (151775 - 280258 == -128482)
						{
							continue;
						}
						this.$mPlayer$37151 = Game.mPlayer;
						if (149424 - 527363 == -377938)
						{
							continue;
						}
						this.$mAlpaca$37152 = GameObject.Find("Alpaca");
						if (109423 - 115008 == -5584)
						{
							continue;
						}
						if (this.$mAlpaca$37152)
						{
							if (67624 - 238065 != -170441)
							{
								continue;
							}
							if (this.$mPlayer$37151)
							{
								if (67537 - 393107 != -325570)
								{
									continue;
								}
								this.$mPlayer$37151.SendMessage("turnToPos", this.$mAlpaca$37152.transform.position);
								if (169011 - 391864 == -222852)
								{
									continue;
								}
							}
						}
						this.$mGameGui$37153 = (GameGui)this.$self_$37156.GetComponent(typeof(GameGui));
						if (12219 - 196347 != -184128)
						{
							continue;
						}
						if (this.$mGameGui$37153)
						{
							if (192281 - 461888 == -269606)
							{
								continue;
							}
							this.$mGameGui$37153.close();
							if (279851 - 561992 != -282141)
							{
								continue;
							}
						}
						this.$mStoryGui$37154 = (StoryGui)this.$self_$37156.GetComponent(typeof(StoryGui));
						if (31947 - 300241 != -268294)
						{
							continue;
						}
						this.$mStoryTimer$37155 = 0f;
						if (297556 - 563097 == -265540)
						{
							continue;
						}
						if (!this.$mStoryGui$37154)
						{
							goto IL_39A;
						}
						if (87093 - 540108 != -453015)
						{
							continue;
						}
						this.$self_$37156.D20c0pwpjZq.StartCoroutine_Auto(this.$self_$37156.D20c0pwpjZq.slerpToObject("AlpacaCamera", (float)1));
						if (288296 - 121507 == 166790)
						{
							continue;
						}
						this.$mStoryGui$37154.startStoryMessage("Alpaca", "Yves", eTalkType.friend);
						if (4384 - 558902 != -554517)
						{
							goto Block_18;
						}
						continue;
					}
					IL_837:
					if (this.$mStoryTimer$37155 > Time.time)
					{
						if (137603 - 337628 != -200025)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_82A;
						}
						if (255863 - 564026 == -308162)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (140580 - 66770 != 73811)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37154.newStoryMessage("Alpaca", "Yves", Language.getMessage("M100_GameTutorial", 275), eTalkType.friend);
						if (106068 - 370506 != -264438)
						{
							continue;
						}
						this.$mStoryTimer$37155 = Time.time + 4f;
						if (71517 - 295924 != -224406)
						{
							goto Block_23;
						}
						continue;
					}
					IL_E3:
					if (this.$mStoryTimer$37155 > Time.time)
					{
						if (266478 - 146389 != 120089)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_D7;
						}
						if (192360 - 261889 == -69528)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (203569 - 88855 != 114714)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37154.newStoryMessage("Alpaca", "Yves", Language.getMessage("M100_GameTutorial", 273), eTalkType.friend);
						if (210841 - 407503 != -196662)
						{
							continue;
						}
						this.$mStoryTimer$37155 = Time.time + 4f;
						if (83698 - 404654 != -320956)
						{
							continue;
						}
						goto IL_A29;
					}
					IL_4C1:
					if (this.$mStoryTimer$37155 > Time.time)
					{
						if (171444 - 197515 != -26071)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4B5;
						}
						if (2557 - 574850 == -572292)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (20221 - 239464 != -219243)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37154.newStoryMessage("Alpaca", "Yves", Language.getMessage("M100_GameTutorial", 272), eTalkType.friend);
						if (140929 - 235224 != -94295)
						{
							continue;
						}
						this.$mStoryTimer$37155 = Time.time + 4f;
						if (139550 - 66565 != 72986)
						{
							goto Block_105;
						}
						continue;
					}
					IL_A50:
					if (this.$mStoryTimer$37155 > Time.time)
					{
						if (109696 - 289061 != -179365)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_A44;
						}
						if (251184 - 204499 != 46685)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (20782 - 16155 != 4627)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37154.newStoryMessage("Alpaca", "Yves", Language.getMessage("M100_GameTutorial", 274), eTalkType.friend);
						if (54423 - 524312 == -469888)
						{
							continue;
						}
						this.$mStoryTimer$37155 = Time.time + 4f;
						if (1742 - 393172 != -391430)
						{
							continue;
						}
						goto IL_80E;
					}
					IL_670:
					if (this.$mStoryTimer$37155 > Time.time)
					{
						if (239687 - 477683 == -237995)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_663;
						}
						if (270255 - 244285 != 25970)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (83165 - 195445 != -112280)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37154.newStoryMessage("Alpaca", "Yves", Language.getMessage("M100_GameTutorial", 276), eTalkType.friend);
						if (84277 - 447099 != -362822)
						{
							continue;
						}
						this.$mStoryTimer$37155 = Time.time + 4f;
						if (32772 - 26673 != 6099)
						{
							continue;
						}
						goto IL_745;
					}
					IL_88A:
					if (this.$mStoryTimer$37155 > Time.time)
					{
						if (152501 - 270366 != -117865)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_87D;
						}
						if (135876 - 534541 != -398665)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (177976 - 263206 != -85229)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$self_$37156.w5gc00mqqP3 = this.$self_$37156.w5gc00mqqP3 + 1;
						if (45376 - 175276 == -129899)
						{
							continue;
						}
						this.$self_$37156.hn6c0URv4x0 = this.$self_$37156.hn6c0URv4x0 + 1;
						if (212139 - 202132 != 10008)
						{
							goto IL_49;
						}
						continue;
					}
					IL_76E:
					if (this.$mStoryTimer$37155 > Time.time)
					{
						if (271075 - 160210 != 110865)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_761;
						}
						if (273237 - 313575 == -40337)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (63171 - 337518 != -274346)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37154.newStoryMessage("Alpaca", "Yves", Language.getMessage("M100_GameTutorial", 277), eTalkType.friend);
						if (74037 - 178021 == -103983)
						{
							continue;
						}
						this.$mStoryTimer$37155 = Time.time + 4f;
						if (144366 - 93966 != 50400)
						{
							continue;
						}
						goto IL_861;
					}
					IL_BE3:
					if (this.$mStoryTimer$37155 > Time.time)
					{
						if (258319 - 440419 != -182100)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_BD6;
						}
						if (86497 - 532806 != -446309)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Hold)
					{
						goto IL_49;
					}
				}
				while (209059 - 315508 == -106448);
				goto IL_EB9;
				IL_D7:
				return this.YieldDefault(6);
				Block_18:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_23:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_39A:
				return this.Yield(19, new WaitForSeconds(0.5f));
				Block_32:
				goto IL_EB9;
				IL_49A:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_4B5:
				return this.YieldDefault(4);
				Block_42:
				return this.Yield(17, new WaitForSeconds(0.5f));
				goto IL_EB9;
				IL_663:
				return this.YieldDefault(12);
				IL_745:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_761:
				return this.YieldDefault(14);
				IL_80E:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_82A:
				return this.YieldDefault(10);
				IL_861:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_87D:
				return this.YieldDefault(16);
				goto IL_EB9;
				IL_A29:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_A44:
				return this.YieldDefault(8);
				IL_BD6:
				return this.YieldDefault(18);
				goto IL_EB9;
				Block_105:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_EB9:
				return false;
			}

			// Token: 0x06006F4B RID: 28491 RVA: 0x00F6536C File Offset: 0x00F6356C
			internal static bool Ck4OIUpMepWGmQsCl607()
			{
				return true;
			}

			// Token: 0x06006F4C RID: 28492 RVA: 0x00F65370 File Offset: 0x00F63570
			internal static bool spUQ6vpMrv3jauG9HksJ()
			{
				return false;
			}

			// Token: 0x04007675 RID: 30325
			internal GameObject $mPlayer$37151;

			// Token: 0x04007676 RID: 30326
			internal GameObject $mAlpaca$37152;

			// Token: 0x04007677 RID: 30327
			internal GameGui $mGameGui$37153;

			// Token: 0x04007678 RID: 30328
			internal StoryGui $mStoryGui$37154;

			// Token: 0x04007679 RID: 30329
			internal float $mStoryTimer$37155;

			// Token: 0x0400767A RID: 30330
			internal M100_GameTutorial3 $self_$37156;
		}
	}

	// Token: 0x020012E1 RID: 4833
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMiniSheep$37158 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F4D RID: 28493 RVA: 0x00F65374 File Offset: 0x00F63574
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMiniSheep$37158(M100_GameTutorial3 self_)
		{
			if (168493 - 21674 != 146819)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (3908 - 419204 != -415295)
				{
					base..ctor();
					if (275817 - 160503 != 115315)
					{
						this.$self_$37164 = self_;
						if (105339 - 213854 != -108514)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006F4E RID: 28494 RVA: 0x00F6540C File Offset: 0x00F6360C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$TalkToMiniSheep$37158.$(this.$self_$37164);
		}

		// Token: 0x06006F4F RID: 28495 RVA: 0x00F6541C File Offset: 0x00F6361C
		internal static bool E8yoPSpMjjndBIqQBcHF()
		{
			return true;
		}

		// Token: 0x06006F50 RID: 28496 RVA: 0x00F65420 File Offset: 0x00F63620
		internal static bool dRdg7WpMhSiW2XUJZeB5()
		{
			return false;
		}

		// Token: 0x0400767B RID: 30331
		internal M100_GameTutorial3 $self_$37164;

		// Token: 0x020012E2 RID: 4834
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F51 RID: 28497 RVA: 0x00F65424 File Offset: 0x00F63624
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial3 self_)
			{
				if (42921 - 441816 != -398894)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14972 - 101540 != -86567)
					{
						base..ctor();
						if (13366 - 119943 == -106577)
						{
							this.$self_$37163 = self_;
							if (25090 - 220705 == -195615)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006F52 RID: 28498 RVA: 0x00F654BC File Offset: 0x00F636BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (262467 - 552554 != -290087)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_357;
					case 2:
						this.$mStoryGui$37162.newStoryMessage("none", "Fah", Language.getMessage("M100_GameTutorial", 281), eTalkType.friend);
						if (176544 - 309744 != -133199)
						{
							goto Block_9;
						}
						continue;
					case 3:
						this.$mStoryGui$37162.close();
						if (281864 - 195549 == 86316)
						{
							continue;
						}
						this.$mGameGui$37161.enabled = true;
						if (52089 - 553911 != -501822)
						{
							continue;
						}
						goto IL_95;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (184112 - 96282 != 87830)
						{
							continue;
						}
						this.YieldDefault(1);
						if (109863 - 72054 != 37810)
						{
							goto Block_2;
						}
						continue;
					default:
						if (259821 - 462957 == -203135)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (258531 - 430264 != -171732)
						{
							break;
						}
					}
					else
					{
						this.$mPlayer$37159 = Game.mPlayer;
						if (98617 - 258916 != -160298)
						{
							this.$mMiniSheep$37160 = GameObject.Find("MiniSheep");
							if (210011 - 516208 != -306196)
							{
								if (this.$mMiniSheep$37160)
								{
									if (206758 - 406372 == -199613)
									{
										continue;
									}
									if (this.$mPlayer$37159)
									{
										if (235637 - 4291 != 231346)
										{
											continue;
										}
										this.$mPlayer$37159.SendMessage("turnToPos", this.$mMiniSheep$37160.transform.position);
										if (65962 - 261217 != -195255)
										{
											continue;
										}
									}
								}
								Game.mGameState = eGameState.Hold;
								if (163864 - 599039 == -435175)
								{
									this.$mGameGui$37161 = (GameGui)this.$self_$37163.GetComponent(typeof(GameGui));
									if (216881 - 354850 != -137968)
									{
										this.$mGameGui$37161.close();
										if (288772 - 513121 == -224349)
										{
											this.$mStoryGui$37162 = (StoryGui)this.$self_$37163.GetComponent(typeof(StoryGui));
											if (113455 - 481248 != -367792)
											{
												this.$mStoryGui$37162.startStoryMessage("none", "Fah", eTalkType.friend);
												if (218065 - 219031 != -965)
												{
													goto Block_17;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_357;
				IL_95:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_9:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_17:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_357:
				return false;
			}

			// Token: 0x06006F53 RID: 28499 RVA: 0x00F65834 File Offset: 0x00F63A34
			internal static bool jqBLBUpMsEiOQDyEKlZ0()
			{
				return true;
			}

			// Token: 0x06006F54 RID: 28500 RVA: 0x00F65838 File Offset: 0x00F63A38
			internal static bool SMfWLupM9DlHupPcaPhd()
			{
				return false;
			}

			// Token: 0x0400767C RID: 30332
			internal GameObject $mPlayer$37159;

			// Token: 0x0400767D RID: 30333
			internal GameObject $mMiniSheep$37160;

			// Token: 0x0400767E RID: 30334
			internal GameGui $mGameGui$37161;

			// Token: 0x0400767F RID: 30335
			internal StoryGui $mStoryGui$37162;

			// Token: 0x04007680 RID: 30336
			internal M100_GameTutorial3 $self_$37163;
		}
	}

	// Token: 0x020012E3 RID: 4835
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$37165 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F55 RID: 28501 RVA: 0x00F6583C File Offset: 0x00F63A3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$37165(int n, M100_GameTutorial3 self_)
		{
			if (41855 - 383504 != -341648)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (182075 - 5491 == 176584)
				{
					base..ctor();
					if (186385 - 571280 == -384895)
					{
						this.$n$37171 = n;
						if (85808 - 422116 != -336307)
						{
							this.$self_$37172 = self_;
							if (261169 - 220807 == 40362)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x00F658F8 File Offset: 0x00F63AF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$TalkToPanther$37165.$(this.$n$37171, this.$self_$37172);
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x00F6590C File Offset: 0x00F63B0C
		internal static bool HfklDmpM1ulq4yVwJ1XZ()
		{
			return true;
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x00F65910 File Offset: 0x00F63B10
		internal static bool MbDorHpM458fN51cKan8()
		{
			return false;
		}

		// Token: 0x04007681 RID: 30337
		internal int $n$37171;

		// Token: 0x04007682 RID: 30338
		internal M100_GameTutorial3 $self_$37172;

		// Token: 0x020012E4 RID: 4836
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F59 RID: 28505 RVA: 0x00F65914 File Offset: 0x00F63B14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, M100_GameTutorial3 self_)
			{
				if (224872 - 596871 != -371999)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (211345 - 99965 != 111381)
					{
						base..ctor();
						if (10735 - 276056 == -265321)
						{
							this.$n$37169 = n;
							if (123844 - 94725 != 29120)
							{
								this.$self_$37170 = self_;
								if (117019 - 286257 != -169237)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006F5A RID: 28506 RVA: 0x00F659D0 File Offset: 0x00F63BD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (256599 - 123270 != 133330)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_43D;
					case 2:
						this.$mStoryGui$37167.newStoryMessage("none", "Panther", Language.getMessage("M100_GameTutorial", 290 + this.$n$37169), eTalkType.friend);
						if (44791 - 406442 != -361651)
						{
							continue;
						}
						goto IL_336;
					case 3:
						this.$mStoryGui$37167.close();
						if (179154 - 281692 == -102537)
						{
							continue;
						}
						if (this.$mPanther$37168)
						{
							if (223249 - 78651 != 144598)
							{
								continue;
							}
							this.$mPanther$37168.animation.CrossFade("root", 0.2f);
							if (25103 - 389096 != -363993)
							{
								continue;
							}
						}
						this.$mGameGui$37166.enabled = true;
						if (38402 - 200503 != -162101)
						{
							continue;
						}
						goto IL_F3;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (113807 - 243945 != -130138)
						{
							continue;
						}
						goto IL_D1;
					default:
						if (216921 - 513046 == -296124)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (269203 - 315758 != -46554)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mGameGui$37166 = (GameGui)this.$self_$37170.GetComponent(typeof(GameGui));
						if (98736 - 267392 == -168655)
						{
							continue;
						}
						this.$mStoryGui$37167 = (StoryGui)this.$self_$37170.GetComponent(typeof(StoryGui));
						if (86968 - 50024 == 36945)
						{
							continue;
						}
						if (this.$mGameGui$37166)
						{
							if (227881 - 138456 != 89425)
							{
								continue;
							}
							if (this.$mStoryGui$37167)
							{
								if (149516 - 41744 != 107772)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (44564 - 549945 != -505381)
								{
									continue;
								}
								this.$mGameGui$37166.close();
								if (86392 - 204799 != -118407)
								{
									continue;
								}
								this.$mPanther$37168 = GameObject.Find("Panther" + this.$n$37169);
								if (284970 - 294711 != -9741)
								{
									continue;
								}
								if (this.$mPanther$37168)
								{
									if (195352 - 116385 == 78968)
									{
										continue;
									}
									this.$mPanther$37168.animation.CrossFade("talk", 0.15f);
									if (135857 - 187000 != -51143)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mPanther$37168.transform.position);
									if (162534 - 328403 == -165868)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Panther" + this.$n$37169);
									if (69065 - 78711 != -9646)
									{
										continue;
									}
								}
								this.$mStoryGui$37167.startStoryMessage("none", "Panther", eTalkType.friend);
								if (18093 - 171062 != -152968)
								{
									goto Block_16;
								}
								continue;
							}
						}
					}
					IL_D1:
					this.YieldDefault(1);
				}
				while (165953 - 2728 == 163226);
				goto IL_43D;
				IL_F3:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_16:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_336:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_43D:
				return false;
			}

			// Token: 0x06006F5B RID: 28507 RVA: 0x00F65E2C File Offset: 0x00F6402C
			internal static bool yxOOyOpMzJDq6WlIxrCU()
			{
				return true;
			}

			// Token: 0x06006F5C RID: 28508 RVA: 0x00F65E30 File Offset: 0x00F64030
			internal static bool AnGJEwpxaw1esrySvPC5()
			{
				return false;
			}

			// Token: 0x04007683 RID: 30339
			internal GameGui $mGameGui$37166;

			// Token: 0x04007684 RID: 30340
			internal StoryGui $mStoryGui$37167;

			// Token: 0x04007685 RID: 30341
			internal GameObject $mPanther$37168;

			// Token: 0x04007686 RID: 30342
			internal int $n$37169;

			// Token: 0x04007687 RID: 30343
			internal M100_GameTutorial3 $self_$37170;
		}
	}

	// Token: 0x020012E5 RID: 4837
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37173 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F5D RID: 28509 RVA: 0x00F65E34 File Offset: 0x00F64034
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37173(M100_GameTutorial3 self_)
		{
			if (266041 - 409852 != -143810)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (181665 - 197175 != -15509)
				{
					base..ctor();
					if (15513 - 443147 != -427633)
					{
						this.$self_$37178 = self_;
						if (197286 - 154885 == 42401)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x00F65ECC File Offset: 0x00F640CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$onDeadPlayer$37173.$(this.$self_$37178);
		}

		// Token: 0x06006F5F RID: 28511 RVA: 0x00F65EDC File Offset: 0x00F640DC
		internal static bool zv29mepx57kE1IiZA4oB()
		{
			return true;
		}

		// Token: 0x06006F60 RID: 28512 RVA: 0x00F65EE0 File Offset: 0x00F640E0
		internal static bool dDBAKapxpQM5Qih1dd74()
		{
			return false;
		}

		// Token: 0x04007688 RID: 30344
		internal M100_GameTutorial3 $self_$37178;

		// Token: 0x020012E6 RID: 4838
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F61 RID: 28513 RVA: 0x00F65EE4 File Offset: 0x00F640E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial3 self_)
			{
				if (116021 - 386989 != -270968)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (95808 - 138843 == -43035)
					{
						base..ctor();
						if (43181 - 285970 != -242788)
						{
							this.$self_$37177 = self_;
							if (295797 - 40500 == 255297)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006F62 RID: 28514 RVA: 0x00F65F7C File Offset: 0x00F6417C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (108840 - 433488 != -324648)
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
							if (36788 - 150158 != -113370)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_233;
							}
							if (111874 - 236381 == -124506)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (75097 - 388105 != -313008)
						{
							continue;
						}
						this.$mStoryGui$37174 = (StoryGui)this.$self_$37177.GetComponent(typeof(StoryGui));
						if (110994 - 425051 == -314056)
						{
							continue;
						}
						if (this.$mStoryGui$37174)
						{
							if (39603 - 466987 != -427384)
							{
								continue;
							}
							this.$mStoryGui$37174.close();
							if (29790 - 237580 != -207790)
							{
								continue;
							}
						}
						this.$mChangeGui$37175 = (ChangeGui)this.$self_$37177.GetComponent(typeof(ChangeGui));
						if (68349 - 290977 == -222627)
						{
							continue;
						}
						if (this.$mChangeGui$37175)
						{
							if (180587 - 138254 != 42333)
							{
								continue;
							}
							this.$mChangeGui$37175.close();
							if (243150 - 365044 == -121893)
							{
								continue;
							}
						}
						this.$mGameGui$37176 = (GameGui)this.$self_$37177.GetComponent(typeof(GameGui));
						if (223382 - 359311 == -135928)
						{
							continue;
						}
						if (this.$mGameGui$37176)
						{
							if (296163 - 431077 == -134913)
							{
								continue;
							}
							if (!this.$mGameGui$37176.enabled)
							{
								if (51897 - 71831 == -19933)
								{
									continue;
								}
								this.$mGameGui$37176.enabled = true;
								if (224464 - 513927 != -289463)
								{
									continue;
								}
							}
							this.$mGameGui$37176.openDeadMenu();
							if (281547 - 56149 != 225398)
							{
								continue;
							}
						}
						IL_233:
						this.YieldDefault(1);
						if (94948 - 392251 != -297303)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (144036 - 82219 == 61818)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (147821 - 184938 == -37116);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06006F63 RID: 28515 RVA: 0x00F66294 File Offset: 0x00F64494
			internal static bool kvaKSHpxVZJiMIfefgCS()
			{
				return true;
			}

			// Token: 0x06006F64 RID: 28516 RVA: 0x00F66298 File Offset: 0x00F64498
			internal static bool IYSetLpxty0IauCO2IAt()
			{
				return false;
			}

			// Token: 0x04007689 RID: 30345
			internal StoryGui $mStoryGui$37174;

			// Token: 0x0400768A RID: 30346
			internal ChangeGui $mChangeGui$37175;

			// Token: 0x0400768B RID: 30347
			internal GameGui $mGameGui$37176;

			// Token: 0x0400768C RID: 30348
			internal M100_GameTutorial3 $self_$37177;
		}
	}

	// Token: 0x020012E7 RID: 4839
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$37179 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F65 RID: 28517 RVA: 0x00F6629C File Offset: 0x00F6449C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$37179(Hashtable data, M100_GameTutorial3 self_)
		{
			if (261772 - 155982 != 105790)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (256131 - 31148 != 224984)
				{
					base..ctor();
					if (8771 - 214333 != -205561)
					{
						this.$data$37184 = data;
						if (119227 - 307982 != -188754)
						{
							this.$self_$37185 = self_;
							if (212756 - 145104 != 67653)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x00F66358 File Offset: 0x00F64558
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$onChangePlayer$37179.$(this.$data$37184, this.$self_$37185);
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x00F6636C File Offset: 0x00F6456C
		internal static bool D4sL0XpxNqneWvRvC3aQ()
		{
			return true;
		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x00F66370 File Offset: 0x00F64570
		internal static bool NloLCDpxYJaDjwj3nsWs()
		{
			return false;
		}

		// Token: 0x0400768D RID: 30349
		internal Hashtable $data$37184;

		// Token: 0x0400768E RID: 30350
		internal M100_GameTutorial3 $self_$37185;

		// Token: 0x020012E8 RID: 4840
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F69 RID: 28521 RVA: 0x00F66374 File Offset: 0x00F64574
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M100_GameTutorial3 self_)
			{
				if (233827 - 512663 != -278835)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (64277 - 420147 != -355869)
					{
						base..ctor();
						if (155495 - 299052 == -143557)
						{
							this.$data$37182 = data;
							if (47331 - 95278 == -47947)
							{
								this.$self_$37183 = self_;
								if (66000 - 30585 == 35415)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006F6A RID: 28522 RVA: 0x00F66430 File Offset: 0x00F64630
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (296071 - 222159 != 73912)
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
							if (97145 - 148544 == -51398)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (288635 - 327583 == -38947)
							{
								continue;
							}
							this.$mGameGui$37181 = (GameGui)this.$self_$37183.GetComponent(typeof(GameGui));
							if (278670 - 264449 != 14221)
							{
								continue;
							}
							this.$mGameGui$37181.enabled = true;
							if (29326 - 353622 != -324296)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (96331 - 284361 != -188029)
						{
							goto Block_9;
						}
						continue;
					default:
						if (128329 - 446421 != -318092)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (285353 - 333064 == -47711)
					{
						this.$self_$37183.SendMessage("onCreatePlayer", this.$data$37182);
						if (84283 - 429297 == -345014)
						{
							this.$mChangeGui$37180 = (ChangeGui)this.$self_$37183.GetComponent(typeof(ChangeGui));
							if (256515 - 459070 == -202555)
							{
								if (!this.$mChangeGui$37180.enabled)
								{
									break;
								}
								if (125256 - 355979 != -230722)
								{
									this.$mChangeGui$37180.close();
									if (172411 - 553409 == -380998)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_9:
				IL_205:
				return false;
			}

			// Token: 0x06006F6B RID: 28523 RVA: 0x00F66654 File Offset: 0x00F64854
			internal static bool VFyBXppxcVJEYu5XQ4e6()
			{
				return true;
			}

			// Token: 0x06006F6C RID: 28524 RVA: 0x00F66658 File Offset: 0x00F64858
			internal static bool kCcJ0upxUvSISs20eFpp()
			{
				return false;
			}

			// Token: 0x0400768F RID: 30351
			internal ChangeGui $mChangeGui$37180;

			// Token: 0x04007690 RID: 30352
			internal GameGui $mGameGui$37181;

			// Token: 0x04007691 RID: 30353
			internal Hashtable $data$37182;

			// Token: 0x04007692 RID: 30354
			internal M100_GameTutorial3 $self_$37183;
		}
	}

	// Token: 0x020012E9 RID: 4841
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37186 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F6D RID: 28525 RVA: 0x00F6665C File Offset: 0x00F6485C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37186(Hashtable data, M100_GameTutorial3 self_)
		{
			if (135473 - 185855 != -50382)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (228433 - 236656 != -8222)
				{
					base..ctor();
					if (27636 - 385259 != -357622)
					{
						this.$data$37194 = data;
						if (57617 - 331476 != -273858)
						{
							this.$self_$37195 = self_;
							if (265263 - 314146 != -48882)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006F6E RID: 28526 RVA: 0x00F66718 File Offset: 0x00F64918
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$onGameComplete$37186.$(this.$data$37194, this.$self_$37195);
		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x00F6672C File Offset: 0x00F6492C
		internal static bool Y5JLjspxTfmPooqjGxYI()
		{
			return true;
		}

		// Token: 0x06006F70 RID: 28528 RVA: 0x00F66730 File Offset: 0x00F64930
		internal static bool KCj63Lpx3EsKH6WNpJKI()
		{
			return false;
		}

		// Token: 0x04007693 RID: 30355
		internal Hashtable $data$37194;

		// Token: 0x04007694 RID: 30356
		internal M100_GameTutorial3 $self_$37195;

		// Token: 0x020012EA RID: 4842
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F71 RID: 28529 RVA: 0x00F66734 File Offset: 0x00F64934
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M100_GameTutorial3 self_)
			{
				if (19639 - 353303 != -333664)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (194497 - 393731 == -199234)
					{
						base..ctor();
						if (76871 - 75452 == 1419)
						{
							this.$data$37192 = data;
							if (93262 - 474078 != -380815)
							{
								this.$self_$37193 = self_;
								if (146329 - 357181 != -210851)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006F72 RID: 28530 RVA: 0x00F667F0 File Offset: 0x00F649F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (141948 - 515566 != -373618)
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
						this.$mCompleteGui$37188 = (CompleteGui)this.$self_$37193.GetComponent(typeof(CompleteGui));
						if (59823 - 551916 != -492093)
						{
							continue;
						}
						this.$mCompleteGui$37188.Init();
						if (250009 - 309168 != -59159)
						{
							continue;
						}
						this.$mCompleteGui$37188.readData(this.$data$37192);
						if (179917 - 578939 != -399022)
						{
							continue;
						}
						if (this.$result$37187 == 1)
						{
							if (269698 - 158475 == 111224)
							{
								continue;
							}
							this.$mCompleteGui$37188.displayResult(eCompleteType.Success);
							if (180774 - 206627 != -25853)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37188.displayResult(eCompleteType.Failed);
							if (293804 - 280850 != 12954)
							{
								continue;
							}
						}
						this.$mGameGui$37189 = (GameGui)this.$self_$37193.GetComponent(typeof(GameGui));
						if (232018 - 324699 == -92680)
						{
							continue;
						}
						this.$mStoryGui$37190 = (StoryGui)this.$self_$37193.GetComponent(typeof(StoryGui));
						if (257045 - 577335 == -320289)
						{
							continue;
						}
						this.$mChangeGui$37191 = (ChangeGui)this.$self_$37193.GetComponent(typeof(ChangeGui));
						if (139013 - 247851 == -108837)
						{
							continue;
						}
						if (this.$mGameGui$37189)
						{
							if (255917 - 407516 == -151598)
							{
								continue;
							}
							this.$mGameGui$37189.close();
							if (143327 - 416941 == -273613)
							{
								continue;
							}
						}
						if (this.$mStoryGui$37190)
						{
							if (141525 - 266884 != -125359)
							{
								continue;
							}
							this.$mStoryGui$37190.close();
							if (26608 - 168913 != -142305)
							{
								continue;
							}
						}
						if (this.$mChangeGui$37191)
						{
							if (110465 - 558617 != -448152)
							{
								continue;
							}
							this.$mChangeGui$37191.disable();
							if (294669 - 435199 == -140529)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (295195 - 364170 != -68975)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (191483 - 494803 != -303320)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$37192[31]);
					if (91999 - 518269 == -426270)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (34263 - 224616 == -190353)
							{
								goto IL_385;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (148823 - 312415 == -163592)
							{
								this.$result$37187 = RuntimeServices.UnboxInt32(this.$data$37192[31]);
								if (233074 - 183192 != 49883)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_385:
				IL_3DB:
				return false;
			}

			// Token: 0x06006F73 RID: 28531 RVA: 0x00F66BEC File Offset: 0x00F64DEC
			internal static bool TgGHFFpxXVC6Tf6IuCSR()
			{
				return true;
			}

			// Token: 0x06006F74 RID: 28532 RVA: 0x00F66BF0 File Offset: 0x00F64DF0
			internal static bool GiqQyLpxQNrgFiiNqXoC()
			{
				return false;
			}

			// Token: 0x04007695 RID: 30357
			internal int $result$37187;

			// Token: 0x04007696 RID: 30358
			internal CompleteGui $mCompleteGui$37188;

			// Token: 0x04007697 RID: 30359
			internal GameGui $mGameGui$37189;

			// Token: 0x04007698 RID: 30360
			internal StoryGui $mStoryGui$37190;

			// Token: 0x04007699 RID: 30361
			internal ChangeGui $mChangeGui$37191;

			// Token: 0x0400769A RID: 30362
			internal Hashtable $data$37192;

			// Token: 0x0400769B RID: 30363
			internal M100_GameTutorial3 $self_$37193;
		}
	}

	// Token: 0x020012EB RID: 4843
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37196 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F75 RID: 28533 RVA: 0x00F66BF4 File Offset: 0x00F64DF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37196(M100_GameTutorial3 self_)
		{
			if (86500 - 76489 != 10011)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (45204 - 554348 == -509144)
				{
					base..ctor();
					if (174986 - 101665 == 73321)
					{
						this.$self_$37200 = self_;
						if (33401 - 61703 == -28302)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006F76 RID: 28534 RVA: 0x00F66C8C File Offset: 0x00F64E8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$ReturnToTown$37196.$(this.$self_$37200);
		}

		// Token: 0x06006F77 RID: 28535 RVA: 0x00F66C9C File Offset: 0x00F64E9C
		internal static bool ebtixUpxkqaYMcyetCcN()
		{
			return true;
		}

		// Token: 0x06006F78 RID: 28536 RVA: 0x00F66CA0 File Offset: 0x00F64EA0
		internal static bool iP9G5jpxGQL5a8Ov6IDS()
		{
			return false;
		}

		// Token: 0x0400769C RID: 30364
		internal M100_GameTutorial3 $self_$37200;

		// Token: 0x020012EC RID: 4844
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F79 RID: 28537 RVA: 0x00F66CA4 File Offset: 0x00F64EA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial3 self_)
			{
				if (37984 - 398417 != -360433)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (213083 - 506564 == -293481)
					{
						base..ctor();
						if (136080 - 240572 == -104492)
						{
							this.$self_$37199 = self_;
							if (186022 - 39672 == 146350)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006F7A RID: 28538 RVA: 0x00F66D3C File Offset: 0x00F64F3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (266591 - 96338 != 170254)
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
						this.$self_$37199.LeaveGame();
						if (72163 - 64583 != 7580)
						{
							continue;
						}
						this.YieldDefault(1);
						if (214770 - 96069 != 118701)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (281262 - 593717 == -312454)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (248353 - 127271 != 121083)
					{
						Game.mStateTime = Time.time;
						if (77700 - 591537 != -513836)
						{
							this.$$switch$6254$37197 = PlayerData.SaveGuild;
							if (215170 - 364830 == -149660)
							{
								if (this.$$switch$6254$37197 == 1)
								{
									if (121238 - 130928 == -9689)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (202353 - 253812 != -51459)
									{
										continue;
									}
								}
								else if (this.$$switch$6254$37197 == 2)
								{
									if (129232 - 384952 != -255720)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (273083 - 441384 != -168301)
									{
										continue;
									}
								}
								else if (this.$$switch$6254$37197 == 3)
								{
									if (162422 - 81088 != 81334)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (33390 - 207964 == -174573)
									{
										continue;
									}
								}
								else if (this.$$switch$6254$37197 == 4)
								{
									if (1845 - 554380 != -552535)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (106197 - 454783 == -348585)
									{
										continue;
									}
								}
								else if (this.$$switch$6254$37197 == 5)
								{
									if (177310 - 123015 == 54296)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (208698 - 173661 != 35037)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (102057 - 194831 != -92774)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (100857 - 426768 != -325911)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (75791 - 346791 != -271000)
									{
										continue;
									}
								}
								this.$mGameGui$37198 = (GameGui)this.$self_$37199.GetComponent(typeof(GameGui));
								if (213611 - 338057 == -124446)
								{
									if (this.$mGameGui$37198)
									{
										if (67573 - 487147 != -419574)
										{
											continue;
										}
										this.$mGameGui$37198.close();
										if (125512 - 74362 != 51150)
										{
											continue;
										}
									}
									this.$self_$37199.SendMessage("fadeOut");
									if (200910 - 49077 != 151834)
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

			// Token: 0x06006F7B RID: 28539 RVA: 0x00F67108 File Offset: 0x00F65308
			internal static bool vsANXPpxHseLoMtebijk()
			{
				return true;
			}

			// Token: 0x06006F7C RID: 28540 RVA: 0x00F6710C File Offset: 0x00F6530C
			internal static bool ahZKUkpxWQYn6EVwT50a()
			{
				return false;
			}

			// Token: 0x0400769D RID: 30365
			internal int $$switch$6254$37197;

			// Token: 0x0400769E RID: 30366
			internal GameGui $mGameGui$37198;

			// Token: 0x0400769F RID: 30367
			internal M100_GameTutorial3 $self_$37199;
		}
	}

	// Token: 0x020012ED RID: 4845
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37201 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F7D RID: 28541 RVA: 0x00F67110 File Offset: 0x00F65310
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37201(M100_GameTutorial3 self_)
		{
			if (96095 - 159798 != -63702)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (63500 - 243036 != -179535)
				{
					base..ctor();
					if (34572 - 198279 != -163706)
					{
						this.$self_$37204 = self_;
						if (113072 - 285582 == -172510)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x00F671A8 File Offset: 0x00F653A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$ReturnToGuild$37201.$(this.$self_$37204);
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x00F671B8 File Offset: 0x00F653B8
		internal static bool L7T4swpxAoDUY1Vvq5cp()
		{
			return true;
		}

		// Token: 0x06006F80 RID: 28544 RVA: 0x00F671BC File Offset: 0x00F653BC
		internal static bool WJR2KypxlN2s7Y0WMqIj()
		{
			return false;
		}

		// Token: 0x040076A0 RID: 30368
		internal M100_GameTutorial3 $self_$37204;

		// Token: 0x020012EE RID: 4846
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F81 RID: 28545 RVA: 0x00F671C0 File Offset: 0x00F653C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial3 self_)
			{
				if (62987 - 585041 != -522053)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (297572 - 122607 != 174966)
					{
						base..ctor();
						if (216462 - 97066 != 119397)
						{
							this.$self_$37203 = self_;
							if (65063 - 127602 == -62539)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006F82 RID: 28546 RVA: 0x00F67258 File Offset: 0x00F65458
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (132030 - 225268 != -93237)
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
						this.$self_$37203.LeaveGame();
						if (83383 - 312664 != -229281)
						{
							continue;
						}
						this.YieldDefault(1);
						if (9636 - 275614 != -265978)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (240282 - 562100 == -321817)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (213412 - 108463 != 104950)
					{
						Game.mStateTime = Time.time;
						if (209622 - 527946 != -318323)
						{
							Game.mNextGameCode = 31;
							if (209609 - 10926 == 198683)
							{
								this.$mGameGui$37202 = (GameGui)this.$self_$37203.GetComponent(typeof(GameGui));
								if (155534 - 508294 == -352760)
								{
									if (this.$mGameGui$37202)
									{
										if (32683 - 208233 != -175550)
										{
											continue;
										}
										this.$mGameGui$37202.close();
										if (86510 - 184682 == -98171)
										{
											continue;
										}
									}
									this.$self_$37203.SendMessage("fadeOut");
									if (64299 - 549171 == -484872)
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

			// Token: 0x06006F83 RID: 28547 RVA: 0x00F67434 File Offset: 0x00F65634
			internal static bool zAOP3gpxyJhoZ16e0N0e()
			{
				return true;
			}

			// Token: 0x06006F84 RID: 28548 RVA: 0x00F67438 File Offset: 0x00F65638
			internal static bool EHA1i2pxS0utIDZ3Yibg()
			{
				return false;
			}

			// Token: 0x040076A1 RID: 30369
			internal GameGui $mGameGui$37202;

			// Token: 0x040076A2 RID: 30370
			internal M100_GameTutorial3 $self_$37203;
		}
	}

	// Token: 0x020012EF RID: 4847
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37205 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006F85 RID: 28549 RVA: 0x00F6743C File Offset: 0x00F6563C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37205(M100_GameTutorial3 self_)
		{
			if (119775 - 301145 != -181370)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (278855 - 79044 != 199812)
				{
					base..ctor();
					if (243718 - 310211 != -66492)
					{
						this.$self_$37209 = self_;
						if (205378 - 396494 != -191115)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006F86 RID: 28550 RVA: 0x00F674D4 File Offset: 0x00F656D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial3.$ReturnToCamp$37205.$(this.$self_$37209);
		}

		// Token: 0x06006F87 RID: 28551 RVA: 0x00F674E4 File Offset: 0x00F656E4
		internal static bool MUH6V4pxorC6FTEP26Lw()
		{
			return true;
		}

		// Token: 0x06006F88 RID: 28552 RVA: 0x00F674E8 File Offset: 0x00F656E8
		internal static bool XkJXWXpxEP919hodySkg()
		{
			return false;
		}

		// Token: 0x040076A3 RID: 30371
		internal M100_GameTutorial3 $self_$37209;

		// Token: 0x020012F0 RID: 4848
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006F89 RID: 28553 RVA: 0x00F674EC File Offset: 0x00F656EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial3 self_)
			{
				if (13942 - 331179 != -317236)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (217462 - 370217 != -152754)
					{
						base..ctor();
						if (267913 - 504382 != -236468)
						{
							this.$self_$37208 = self_;
							if (58460 - 78002 == -19542)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006F8A RID: 28554 RVA: 0x00F67584 File Offset: 0x00F65784
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284852 - 63613 != 221240)
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
						this.$self_$37208.LeaveGame();
						if (248534 - 284265 != -35731)
						{
							continue;
						}
						this.YieldDefault(1);
						if (28747 - 235635 != -206888)
						{
							continue;
						}
						goto IL_363;
					default:
						if (161944 - 560989 == -399044)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (247453 - 495191 == -247738)
					{
						Game.mStateTime = Time.time;
						if (173192 - 18593 == 154599)
						{
							this.$$switch$6256$37206 = PlayerData.SaveGuild;
							if (296320 - 143317 == 153003)
							{
								if (this.$$switch$6256$37206 == 1)
								{
									if (234332 - 512244 == -277911)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (158609 - 575343 != -416734)
									{
										continue;
									}
								}
								else if (this.$$switch$6256$37206 == 2)
								{
									if (161048 - 469219 == -308170)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (296110 - 57594 != 238516)
									{
										continue;
									}
								}
								else if (this.$$switch$6256$37206 == 3)
								{
									if (244029 - 222700 == 21330)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (42480 - 69336 != -26856)
									{
										continue;
									}
								}
								else if (this.$$switch$6256$37206 == 4)
								{
									if (191784 - 284036 == -92251)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (84845 - 402332 != -317487)
									{
										continue;
									}
								}
								else if (this.$$switch$6256$37206 == 5)
								{
									if (68552 - 162694 == -94141)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (284393 - 118353 != 166040)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (216904 - 147023 == 69882)
									{
										continue;
									}
								}
								this.$mGameGui$37207 = (GameGui)this.$self_$37208.GetComponent(typeof(GameGui));
								if (183252 - 357162 == -173910)
								{
									if (this.$mGameGui$37207)
									{
										if (20991 - 332607 == -311615)
										{
											continue;
										}
										this.$mGameGui$37207.close();
										if (7642 - 213715 == -206072)
										{
											continue;
										}
									}
									this.$self_$37208.SendMessage("fadeOut");
									if (231359 - 547685 == -316326)
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

			// Token: 0x06006F8B RID: 28555 RVA: 0x00F67908 File Offset: 0x00F65B08
			internal static bool FHxmR6px2MsqEFyQSJmA()
			{
				return true;
			}

			// Token: 0x06006F8C RID: 28556 RVA: 0x00F6790C File Offset: 0x00F65B0C
			internal static bool tU4E77px8pYE8MVb2367()
			{
				return false;
			}

			// Token: 0x040076A4 RID: 30372
			internal int $$switch$6256$37206;

			// Token: 0x040076A5 RID: 30373
			internal GameGui $mGameGui$37207;

			// Token: 0x040076A6 RID: 30374
			internal M100_GameTutorial3 $self_$37208;
		}
	}
}
