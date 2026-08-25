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

// Token: 0x020012A0 RID: 4768
[Serializable]
public class M100_GameTutorial1 : MonoBehaviour
{
	// Token: 0x06006DBD RID: 28093 RVA: 0x00F3E910 File Offset: 0x00F3CB10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M100_GameTutorial1()
	{
		if (149735 - 144778 != 4957)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (57987 - 296926 == -238939)
			{
				base..ctor();
				if (127526 - 302553 != -175026)
				{
					this.FZrcBLWBytN = 1;
					if (65819 - 451127 != -385307)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006DBE RID: 28094 RVA: 0x00F3E9A8 File Offset: 0x00F3CBA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (45964 - 340944 != -294979)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (281678 - 71553 != 210126)
			{
				Game.mGameType = 5;
				if (205594 - 419921 != -214326)
				{
					if (Chat.Initialized)
					{
						if (17327 - 90809 == -73482)
						{
							Chat.ChatDisplay.Clear();
							if (29415 - 221226 == -191811)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (231877 - 43083 == 188794)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006DBF RID: 28095 RVA: 0x00F3EA8C File Offset: 0x00F3CC8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (111762 - 93666 != 18096)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (299708 - 202149 == 97559)
				{
					Game.nextGame();
					if (26856 - 547077 == -520221)
					{
						Game.mGameCode = 100;
						if (24975 - 199334 == -174359)
						{
							Game.mGameType = 5;
							if (82693 - 105203 == -22510)
							{
								Game.mGameTime = Time.time;
								if (190787 - 225127 != -34339)
								{
									Game.mGameScore = 0;
									if (143170 - 396354 != -253183)
									{
										Game.mGameMana = 0;
										if (84060 - 219810 == -135750)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (160038 - 47308 != 112731)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (170194 - 373252 != -203057)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (293815 - 413600 == -119785)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (247538 - 558521 != -310982)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (263727 - 560816 == -297089)
															{
																this.P6KcBTO1K6U = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (151571 - 314 != 151258)
																{
																	this.P6KcBTO1K6U.enabled = false;
																	if (280290 - 497814 == -217524)
																	{
																		this.KjpcBxEZcGi = PhotonClient.Connection;
																		if (171522 - 32917 == 138605)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (89568 - 121063 == -31495)
																			{
																				this.InitGame();
																				if (146803 - 159199 != -12395)
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
				if (232009 - 349613 != -117603)
				{
					Game.mGameType = 99;
					if (210963 - 397462 == -186499)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006DC0 RID: 28096 RVA: 0x00F3ED8C File Offset: 0x00F3CF8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (215710 - 62686 != 153024)
		{
		}
		for (;;)
		{
			if (this.KjpcBxEZcGi == null)
			{
				if (64838 - 65180 == -342)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (11506 - 372238 == -360732)
				{
					if (mGameState == eGameState.Init)
					{
						if (81890 - 451577 == -369687)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (287659 - 440374 == -152715)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (254991 - 562135 != -307143)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (61353 - 190739 != -129385)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (275532 - 19596 != 255937)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (47026 - 136438 != -89411)
						{
							this.StartCoroutine_Auto(this.TutorialEvent());
							if (136113 - 198933 == -62820)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (43765 - 237630 == -193865)
						{
							this.StartCoroutine_Auto(this.TutorialEvent());
							if (189835 - 153935 != 35901)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (94599 - 2227 != 92373)
						{
							this.StartCoroutine_Auto(this.TutorialEvent());
							if (267888 - 285343 != -17454)
							{
								break;
							}
						}
					}
					else
					{
						if (mGameState != eGameState.Ended)
						{
							break;
						}
						if (268853 - 472801 == -203948)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006DC1 RID: 28097 RVA: 0x00F3EFE0 File Offset: 0x00F3D1E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M100_GameTutorial1.$onGameEvent$36937(data, this).GetEnumerator();
	}

	// Token: 0x06006DC2 RID: 28098 RVA: 0x00F3EFF0 File Offset: 0x00F3D1F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitTutorialEvent()
	{
		if (165083 - 47940 != 117143)
		{
		}
		for (;;)
		{
			this.oVDcB7pvXvE = new GUIStyle();
			if (171040 - 550514 != -379473)
			{
				this.oVDcB7pvXvE.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_close_h", typeof(Texture)));
				if (194561 - 350420 != -155858)
				{
					int @int = PlayerPrefs.GetInt("language", 0);
					if (253882 - 177572 != 76311)
					{
						if (@int == 1)
						{
							if (73072 - 474564 != -401492)
							{
								continue;
							}
							this.Wh5cBHn1c3Z = (Texture)Resources.Load("GameGui/Tutorial/english/guide_menu", typeof(Texture));
							if (91196 - 387903 != -296707)
							{
								continue;
							}
							this.B3YcBw3JUTS = (Texture)Resources.Load("GameGui/Tutorial/english/guide_100", typeof(Texture));
							if (209989 - 253361 != -43372)
							{
								continue;
							}
							this.MaFcBUiGnkH = (Texture)Resources.Load("GameGui/Tutorial/english/guide_101", typeof(Texture));
							if (2715 - 129836 != -127121)
							{
								continue;
							}
							this.IhbcBNhAj8J = (Texture)Resources.Load("GameGui/Tutorial/english/guide_200", typeof(Texture));
							if (14007 - 303234 != -289227)
							{
								continue;
							}
							this.HYmcBEiWWQA = (Texture)Resources.Load("GameGui/Tutorial/english/guide_201", typeof(Texture));
							if (134578 - 542313 != -407735)
							{
								continue;
							}
							this.KlFcBPPTjwN = (Texture)Resources.Load("GameGui/Tutorial/english/guide_300", typeof(Texture));
							if (296921 - 128420 == 168502)
							{
								continue;
							}
							this.u6PcBSLO9Io = (Texture)Resources.Load("GameGui/Tutorial/english/guide_301", typeof(Texture));
							if (93 - 4575 != -4482)
							{
								continue;
							}
						}
						else
						{
							this.Wh5cBHn1c3Z = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_menu", typeof(Texture));
							if (106460 - 581777 == -475316)
							{
								continue;
							}
							this.B3YcBw3JUTS = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_100", typeof(Texture));
							if (39827 - 449517 == -409689)
							{
								continue;
							}
							this.MaFcBUiGnkH = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_101", typeof(Texture));
							if (192464 - 239339 != -46875)
							{
								continue;
							}
							this.IhbcBNhAj8J = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_200", typeof(Texture));
							if (75874 - 2952 != 72922)
							{
								continue;
							}
							this.HYmcBEiWWQA = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_201", typeof(Texture));
							if (186039 - 93238 != 92801)
							{
								continue;
							}
							this.KlFcBPPTjwN = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_300", typeof(Texture));
							if (38628 - 435394 == -396765)
							{
								continue;
							}
							this.u6PcBSLO9Io = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_301", typeof(Texture));
							if (41263 - 430005 != -388742)
							{
								continue;
							}
						}
						this.DmicB8Nie34 = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
						if (40713 - 415011 != -374297)
						{
							this.SUjcBifwx3l = (AudioClip)Resources.Load("Sound/GUI/click", typeof(AudioClip));
							if (69742 - 580582 == -510840)
							{
								this.oXGcBDWFHVd = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
								if (115153 - 157526 == -42373)
								{
									this.SD8cBmNwZws = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
									if (269304 - 361076 != -91771)
									{
										this.pW0cBBScBYI = GameObject.Find("Walrus");
										if (59768 - 380706 != -320937)
										{
											this.xP4cB0Qy2Li = (GameObject)Resources.Load("GameAssets/Characters/Tails/Walrus/Effects/blink", typeof(GameObject));
											if (79530 - 274912 != -195381)
											{
												this.V35cBMYnDfl = new GUIStyle();
												if (142936 - 505868 == -362932)
												{
													this.V35cBMYnDfl.font = (Font)Resources.Load("GameGui/Fonts/Century32", typeof(Font));
													if (51013 - 365202 == -314189)
													{
														this.V35cBMYnDfl.normal.textColor = new Color(0.42f, 0.33f, 0.28f, (float)1);
														if (143071 - 40338 == 102733)
														{
															this.V35cBMYnDfl.alignment = TextAnchor.MiddleLeft;
															if (73640 - 565106 != -491465)
															{
																this.hQTcBfRVnmG = new GUIStyle();
																if (34547 - 350352 != -315804)
																{
																	this.hQTcBfRVnmG.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																	if (58930 - 578216 == -519286)
																	{
																		this.hQTcBfRVnmG.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																		if (37622 - 221806 == -184184)
																		{
																			this.hQTcBfRVnmG.alignment = TextAnchor.MiddleLeft;
																			if (241947 - 136074 != 105874)
																			{
																				this.YFLcBZQEoBJ = new GUIStyle();
																				if (205048 - 496258 != -291209)
																				{
																					this.YFLcBZQEoBJ.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageNext_h", typeof(Texture)));
																					if (196426 - 461985 == -265559)
																					{
																						this.l2TcBCh9Qfh = new GUIStyle();
																						if (127946 - 85759 == 42187)
																						{
																							this.l2TcBCh9Qfh.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageBack_h", typeof(Texture)));
																							if (254124 - 464994 != -210869)
																							{
																								this.MFecB4ldj2R = (GameGui)this.GetComponent(typeof(GameGui));
																								if (118596 - 259667 != -141070)
																								{
																									this.TCLcBsTVlNu = (StoryGui)this.GetComponent(typeof(StoryGui));
																									if (214962 - 183740 == 31222)
																									{
																										this.HvucBj19U7E = this.transform.position;
																										if (136739 - 432259 != -295519)
																										{
																											this.rlncBoUEkFI = this.transform.rotation;
																											if (251610 - 506546 == -254936)
																											{
																												GameObject gameObject = GameObject.Find("StartCamera1");
																												if (194946 - 510483 != -315536)
																												{
																													if (gameObject)
																													{
																														if (40087 - 187717 != -147629)
																														{
																															this.WwgcBk23WF5 = gameObject.transform.position;
																															if (86980 - 452509 == -365529)
																															{
																																this.yt9cBFikQmq = gameObject.transform.rotation;
																																if (19750 - 344391 != -324640)
																																{
																																	break;
																																}
																															}
																														}
																													}
																													else
																													{
																														Debug.LogError("Cannot find StartCamera1");
																														if (63038 - 566896 == -503858)
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
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006DC3 RID: 28099 RVA: 0x00F3F938 File Offset: 0x00F3DB38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (120389 - 447114 != -326724)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (260420 - 233009 == 27411)
			{
				float num = (float)(1024 * Screen.width / Screen.height);
				if (136935 - 238250 == -101315)
				{
					GUI.depth = 1;
					if (179024 - 141137 != 37888)
					{
						int lrhcB3KRbKm = this.LrhcB3KRbKm;
						if (206346 - 31516 != 174831)
						{
							if (lrhcB3KRbKm == 7)
							{
								if (243252 - 505890 == -262638)
								{
									if (Time.time - this.B1kcBbakxdR <= (float)2)
									{
										break;
									}
									if (28778 - 186329 != -157550)
									{
										if (this.Wh5cBHn1c3Z)
										{
											if (37312 - 266426 == -229113)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num - (float)330, (float)200, (float)668, (float)676), this.Wh5cBHn1c3Z);
											if (173047 - 138669 == 34379)
											{
												continue;
											}
										}
										GUI.Label(new Rect(0.5f * num - (float)330 + (float)112, (float)244, (float)400, (float)36), "Basic Movement", this.V35cBMYnDfl);
										if (118572 - 378595 != -260022)
										{
											if (this.B3YcBw3JUTS)
											{
												if (220486 - 407016 != -186530)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num - (float)330 + (float)93, (float)296, (float)512, (float)512), this.B3YcBw3JUTS);
												if (250641 - 168579 == 82063)
												{
													continue;
												}
											}
											GUI.Label(new Rect(0.5f * num - (float)330 + (float)362, (float)813, (float)50, (float)30), string.Empty + this.FZrcBLWBytN, this.hQTcBfRVnmG);
											if (270595 - 135913 == 134682)
											{
												if (GUI.Button(new Rect(0.5f * num - (float)330 + (float)218, (float)803, (float)85, (float)57), string.Empty, this.l2TcBCh9Qfh))
												{
													if (87563 - 558484 == -470920)
													{
														continue;
													}
													this.audio.PlayOneShot(this.oXGcBDWFHVd);
													if (7591 - 323050 == -315458)
													{
														continue;
													}
												}
												if (GUI.Button(new Rect(0.5f * num - (float)330 + (float)375, (float)803, (float)85, (float)57), string.Empty, this.YFLcBZQEoBJ))
												{
													if (97105 - 316694 == -219588)
													{
														continue;
													}
													this.audio.PlayOneShot(this.oXGcBDWFHVd);
													if (19899 - 402063 != -382164)
													{
														continue;
													}
												}
												if (!GUI.Button(new Rect(0.5f * num - (float)330 + (float)592, (float)204, (float)57, (float)52), string.Empty, this.oVDcB7pvXvE))
												{
													break;
												}
												if (273624 - 77862 == 195762)
												{
													this.LrhcB3KRbKm = 8;
													if (196679 - 445043 == -248364)
													{
														this.B1kcBbakxdR = Time.time;
														if (170030 - 366664 != -196633)
														{
															if (this.MFecB4ldj2R)
															{
																if (73631 - 40777 == 32855)
																{
																	continue;
																}
																this.MFecB4ldj2R.enabled = true;
																if (157989 - 38874 == 119116)
																{
																	continue;
																}
															}
															this.P6KcBTO1K6U.enabled = true;
															if (297410 - 562728 != -265317)
															{
																Game.mGameState = eGameState.Normal;
																if (97962 - 591527 != -493564)
																{
																	if (!this.SD8cBmNwZws)
																	{
																		break;
																	}
																	if (193400 - 130322 == 63078)
																	{
																		this.audio.PlayOneShot(this.SD8cBmNwZws);
																		if (242281 - 82047 == 160234)
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
							else if (lrhcB3KRbKm == 18)
							{
								if (87990 - 290781 == -202791)
								{
									if (Time.time - this.B1kcBbakxdR <= (float)1)
									{
										break;
									}
									if (2027 - 537340 != -535312)
									{
										if (this.Wh5cBHn1c3Z)
										{
											if (166783 - 207925 == -41141)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num - (float)330, (float)200, (float)668, (float)676), this.Wh5cBHn1c3Z);
											if (3370 - 73226 != -69856)
											{
												continue;
											}
										}
										GUI.Label(new Rect(0.5f * num - (float)330 + (float)112, (float)244, (float)400, (float)36), "Battle Basics", this.V35cBMYnDfl);
										if (53872 - 104862 == -50990)
										{
											if (this.MaFcBUiGnkH)
											{
												if (27033 - 597108 != -570075)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num - (float)330 + (float)93, (float)296, (float)512, (float)512), this.MaFcBUiGnkH);
												if (242846 - 197488 == 45359)
												{
													continue;
												}
											}
											GUI.Label(new Rect(0.5f * num - (float)330 + (float)362, (float)813, (float)50, (float)30), string.Empty + this.FZrcBLWBytN, this.hQTcBfRVnmG);
											if (89696 - 206039 == -116343)
											{
												if (GUI.Button(new Rect(0.5f * num - (float)330 + (float)218, (float)803, (float)85, (float)57), string.Empty, this.l2TcBCh9Qfh))
												{
													if (63307 - 95839 == -32531)
													{
														continue;
													}
													this.audio.PlayOneShot(this.oXGcBDWFHVd);
													if (140533 - 254739 == -114205)
													{
														continue;
													}
												}
												if (GUI.Button(new Rect(0.5f * num - (float)330 + (float)375, (float)803, (float)85, (float)57), string.Empty, this.YFLcBZQEoBJ))
												{
													if (31705 - 28328 == 3378)
													{
														continue;
													}
													this.audio.PlayOneShot(this.oXGcBDWFHVd);
													if (284578 - 360024 != -75446)
													{
														continue;
													}
												}
												if (!GUI.Button(new Rect(0.5f * num - (float)330 + (float)592, (float)204, (float)57, (float)52), string.Empty, this.oVDcB7pvXvE))
												{
													break;
												}
												if (295711 - 428494 != -132782)
												{
													this.LrhcB3KRbKm = 19;
													if (38288 - 237141 == -198853)
													{
														this.B1kcBbakxdR = Time.time;
														if (98853 - 51392 != 47462)
														{
															if (this.MFecB4ldj2R)
															{
																if (158394 - 12411 == 145984)
																{
																	continue;
																}
																this.MFecB4ldj2R.enabled = true;
																if (40227 - 552534 == -512306)
																{
																	continue;
																}
															}
															this.P6KcBTO1K6U.enabled = true;
															if (57594 - 328526 == -270932)
															{
																Game.mGameState = eGameState.Normal;
																if (197213 - 423228 == -226015)
																{
																	if (!this.SD8cBmNwZws)
																	{
																		break;
																	}
																	if (152482 - 235188 != -82705)
																	{
																		this.audio.PlayOneShot(this.SD8cBmNwZws);
																		if (95304 - 77015 != 18290)
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
							else if (lrhcB3KRbKm == 29)
							{
								if (43925 - 544607 == -500682)
								{
									if (Time.time - this.B1kcBbakxdR <= (float)1)
									{
										break;
									}
									if (154334 - 288264 != -133929)
									{
										if (this.Wh5cBHn1c3Z)
										{
											if (231198 - 492076 == -260877)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num - (float)330, (float)200, (float)668, (float)676), this.Wh5cBHn1c3Z);
											if (141788 - 557593 == -415804)
											{
												continue;
											}
										}
										GUI.Label(new Rect(0.5f * num - (float)330 + (float)112, (float)244, (float)400, (float)36), "Level and Status", this.V35cBMYnDfl);
										if (82722 - 482233 == -399511)
										{
											int fzrcBLWBytN = this.FZrcBLWBytN;
											if (188265 - 189724 != -1458)
											{
												if (fzrcBLWBytN == 1)
												{
													if (222933 - 85677 != 137256)
													{
														continue;
													}
													if (this.IhbcBNhAj8J)
													{
														if (66637 - 230091 != -163454)
														{
															continue;
														}
														GUI.DrawTexture(new Rect(0.5f * num - (float)330 + (float)93, (float)296, (float)512, (float)512), this.IhbcBNhAj8J);
														if (270983 - 124475 == 146509)
														{
															continue;
														}
													}
												}
												else if (fzrcBLWBytN == 2)
												{
													if (191429 - 408577 == -217147)
													{
														continue;
													}
													if (this.HYmcBEiWWQA)
													{
														if (53691 - 217905 == -164213)
														{
															continue;
														}
														GUI.DrawTexture(new Rect(0.5f * num - (float)330 + (float)93, (float)296, (float)512, (float)512), this.HYmcBEiWWQA);
														if (188528 - 10572 == 177957)
														{
															continue;
														}
													}
												}
												else if (fzrcBLWBytN == 3)
												{
													if (236863 - 260086 != -23223)
													{
														continue;
													}
													if (this.KlFcBPPTjwN)
													{
														if (75738 - 278102 == -202363)
														{
															continue;
														}
														GUI.DrawTexture(new Rect(0.5f * num - (float)330 + (float)93, (float)296, (float)512, (float)512), this.KlFcBPPTjwN);
														if (203105 - 542933 != -339828)
														{
															continue;
														}
													}
												}
												GUI.Label(new Rect(0.5f * num - (float)330 + (float)362, (float)813, (float)50, (float)30), string.Empty + this.FZrcBLWBytN, this.hQTcBfRVnmG);
												if (17311 - 100945 == -83634)
												{
													if (GUI.Button(new Rect(0.5f * num - (float)330 + (float)218, (float)803, (float)85, (float)57), string.Empty, this.l2TcBCh9Qfh))
													{
														if (251256 - 579061 != -327805)
														{
															continue;
														}
														this.FZrcBLWBytN = Mathf.Clamp(this.FZrcBLWBytN - 1, 1, 3);
														if (7701 - 558335 == -550633)
														{
															continue;
														}
														this.audio.PlayOneShot(this.oXGcBDWFHVd);
														if (142943 - 557618 != -414675)
														{
															continue;
														}
													}
													if (GUI.Button(new Rect(0.5f * num - (float)330 + (float)375, (float)803, (float)85, (float)57), string.Empty, this.YFLcBZQEoBJ))
													{
														if (75091 - 557644 != -482553)
														{
															continue;
														}
														this.FZrcBLWBytN = Mathf.Clamp(this.FZrcBLWBytN + 1, 1, 3);
														if (24610 - 474169 == -449558)
														{
															continue;
														}
														this.audio.PlayOneShot(this.oXGcBDWFHVd);
														if (215724 - 412013 == -196288)
														{
															continue;
														}
													}
													if (!GUI.Button(new Rect(0.5f * num - (float)330 + (float)592, (float)204, (float)57, (float)52), string.Empty, this.oVDcB7pvXvE))
													{
														break;
													}
													if (249484 - 454470 != -204985)
													{
														this.LrhcB3KRbKm = 30;
														if (107377 - 399197 != -291819)
														{
															this.B1kcBbakxdR = Time.time;
															if (1257 - 215721 != -214463)
															{
																if (this.MFecB4ldj2R)
																{
																	if (4488 - 355498 == -351009)
																	{
																		continue;
																	}
																	this.MFecB4ldj2R.enabled = true;
																	if (255118 - 282106 != -26988)
																	{
																		continue;
																	}
																}
																this.P6KcBTO1K6U.enabled = true;
																if (198658 - 548438 == -349780)
																{
																	Game.mGameState = eGameState.Normal;
																	if (254375 - 219886 != 34490)
																	{
																		if (!this.SD8cBmNwZws)
																		{
																			break;
																		}
																		if (171420 - 456732 == -285312)
																		{
																			this.audio.PlayOneShot(this.SD8cBmNwZws);
																			if (88870 - 531254 != -442383)
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
								if (lrhcB3KRbKm != 505)
								{
									break;
								}
								if (88515 - 414023 == -325508)
								{
									if (Time.time - this.B1kcBbakxdR <= (float)1)
									{
										break;
									}
									if (91815 - 164490 != -72674)
									{
										if (this.Wh5cBHn1c3Z)
										{
											if (181525 - 72451 != 109074)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num - (float)330, (float)200, (float)668, (float)676), this.Wh5cBHn1c3Z);
											if (71560 - 337691 == -266130)
											{
												continue;
											}
										}
										GUI.Label(new Rect(0.5f * num - (float)330 + (float)112, (float)244, (float)400, (float)36), "Skill Basic", this.V35cBMYnDfl);
										if (297825 - 166006 == 131819)
										{
											if (this.u6PcBSLO9Io)
											{
												if (86361 - 372329 == -285967)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num - (float)330 + (float)93, (float)296, (float)512, (float)512), this.u6PcBSLO9Io);
												if (171925 - 201151 == -29225)
												{
													continue;
												}
											}
											GUI.Label(new Rect(0.5f * num - (float)330 + (float)362, (float)813, (float)50, (float)30), string.Empty + this.FZrcBLWBytN, this.hQTcBfRVnmG);
											if (217080 - 317023 != -99942)
											{
												if (GUI.Button(new Rect(0.5f * num - (float)330 + (float)218, (float)803, (float)85, (float)57), string.Empty, this.l2TcBCh9Qfh))
												{
													if (9584 - 221707 == -212122)
													{
														continue;
													}
													this.audio.PlayOneShot(this.oXGcBDWFHVd);
													if (251520 - 416956 != -165436)
													{
														continue;
													}
												}
												if (GUI.Button(new Rect(0.5f * num - (float)330 + (float)375, (float)803, (float)85, (float)57), string.Empty, this.YFLcBZQEoBJ))
												{
													if (132551 - 407594 == -275042)
													{
														continue;
													}
													this.audio.PlayOneShot(this.oXGcBDWFHVd);
													if (97426 - 455367 == -357940)
													{
														continue;
													}
												}
												if (!GUI.Button(new Rect(0.5f * num - (float)330 + (float)592, (float)204, (float)57, (float)52), string.Empty, this.oVDcB7pvXvE))
												{
													break;
												}
												if (216360 - 570117 != -353756)
												{
													this.LrhcB3KRbKm = 506;
													if (181121 - 91778 != 89344)
													{
														this.B1kcBbakxdR = Time.time;
														if (283068 - 72465 == 210603)
														{
															if (this.MFecB4ldj2R)
															{
																if (267871 - 295899 == -28027)
																{
																	continue;
																}
																this.MFecB4ldj2R.enabled = true;
																if (217862 - 579874 == -362011)
																{
																	continue;
																}
															}
															this.P6KcBTO1K6U.enabled = true;
															if (11427 - 572408 == -560981)
															{
																Game.mGameState = eGameState.Normal;
																if (33356 - 55130 != -21773)
																{
																	if (!this.SD8cBmNwZws)
																	{
																		break;
																	}
																	if (271640 - 185108 != 86533)
																	{
																		this.audio.PlayOneShot(this.SD8cBmNwZws);
																		if (296452 - 299466 != -3013)
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

	// Token: 0x06006DC4 RID: 28100 RVA: 0x00F40DEC File Offset: 0x00F3EFEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator TutorialEvent()
	{
		return new M100_GameTutorial1.$TutorialEvent$36946(this).GetEnumerator();
	}

	// Token: 0x06006DC5 RID: 28101 RVA: 0x00F40DFC File Offset: 0x00F3EFFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EndTutorialEvent()
	{
		return new M100_GameTutorial1.$EndTutorialEvent$36966(this).GetEnumerator();
	}

	// Token: 0x06006DC6 RID: 28102 RVA: 0x00F40E0C File Offset: 0x00F3F00C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWalrus()
	{
		return new M100_GameTutorial1.$TalkToWalrus$36973(this).GetEnumerator();
	}

	// Token: 0x06006DC7 RID: 28103 RVA: 0x00F40E1C File Offset: 0x00F3F01C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddTemporarySkill()
	{
		if (147611 - 593955 != -446344)
		{
		}
		while (Game.mPlayer)
		{
			if (99091 - 357064 == -257973)
			{
				CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
				if (140093 - 198435 != -58341)
				{
					if (!characterControl)
					{
						break;
					}
					if (286243 - 519220 != -232976)
					{
						CharacterData.current.addSkill(102);
						if (178675 - 289008 == -110333)
						{
							CharacterData.current.addSkill(103);
							if (51568 - 278457 == -226889)
							{
								CharacterData.current.addSkill(104);
								if (177398 - 421606 != -244207)
								{
									CharacterData.current.addSkill(111);
									if (205509 - 115660 == 89849)
									{
										CharacterData.current.addSkill(112);
										if (38880 - 291712 == -252832)
										{
											CharacterData.current.addSkill(113);
											if (73371 - 269115 == -195744)
											{
												CharacterData.current.addSkill(114);
												if (159021 - 210307 == -51286)
												{
													CharacterData.current.addSkill(201);
													if (100719 - 165280 == -64561)
													{
														CharacterData.current.addSkill(202);
														if (149101 - 434668 == -285567)
														{
															CharacterData.current.addSkill(203);
															if (205721 - 28135 == 177586)
															{
																CharacterData.current.addSkill(204);
																if (219976 - 266659 != -46682)
																{
																	CharacterData.current.addSkill(301);
																	if (228086 - 481185 != -253098)
																	{
																		CharacterData.current.addSkill(302);
																		if (127846 - 448172 == -320326)
																		{
																			CharacterData.current.addSkill(303);
																			if (163076 - 86083 != 76994)
																			{
																				CharacterData.current.addSkill(304);
																				if (165464 - 157919 != 7546)
																				{
																					characterControl.RPC_AddStatus("flameOfReggu", 1, 300, 0, characterControl.ActorNr);
																					if (55214 - 121249 == -66035)
																					{
																						characterControl.addSkill(102);
																						if (85843 - 324357 != -238513)
																						{
																							characterControl.addSkill(103);
																							if (63952 - 284539 != -220586)
																							{
																								characterControl.addSkill(104);
																								if (145487 - 521210 == -375723)
																								{
																									characterControl.addSkill(111);
																									if (238119 - 312033 == -73914)
																									{
																										characterControl.addSkill(112);
																										if (209782 - 544236 != -334453)
																										{
																											characterControl.addSkill(113);
																											if (55256 - 301749 != -246492)
																											{
																												characterControl.addSkill(114);
																												if (98189 - 161157 == -62968)
																												{
																													characterControl.addSkill(201);
																													if (29881 - 13663 != 16219)
																													{
																														characterControl.addSkill(202);
																														if (237226 - 107490 != 129737)
																														{
																															characterControl.addSkill(203);
																															if (88565 - 578702 == -490137)
																															{
																																characterControl.addSkill(204);
																																if (47042 - 582728 != -535685)
																																{
																																	characterControl.addSkill(301);
																																	if (176178 - 363694 != -187515)
																																	{
																																		characterControl.addSkill(302);
																																		if (104277 - 288370 != -184092)
																																		{
																																			characterControl.addSkill(303);
																																			if (259181 - 208928 == 50253)
																																			{
																																				characterControl.addSkill(304);
																																				if (289369 - 271784 != 17586)
																																				{
																																					this.MFecB4ldj2R.ReplaceCommand(0, CharacterData.current.Type, 204);
																																					if (223315 - 92537 != 130779)
																																					{
																																						if (!(CharacterData.current.Type == "Wolf"))
																																						{
																																							if (245831 - 39372 != 206459)
																																							{
																																								continue;
																																							}
																																							if (CharacterData.current.Type == "Bison")
																																							{
																																								if (293001 - 71390 != 221611)
																																								{
																																									continue;
																																								}
																																							}
																																							else if (CharacterData.current.Type == "Panda")
																																							{
																																								if (183620 - 323061 == -139440)
																																								{
																																									continue;
																																								}
																																								this.MFecB4ldj2R.ReplaceCommand(1, CharacterData.current.Type, 302);
																																								if (245808 - 484081 != -238272)
																																								{
																																									break;
																																								}
																																								continue;
																																							}
																																							else
																																							{
																																								this.MFecB4ldj2R.ReplaceCommand(1, CharacterData.current.Type, 304);
																																								if (119987 - 438221 != -318234)
																																								{
																																									continue;
																																								}
																																								break;
																																							}
																																						}
																																						this.MFecB4ldj2R.ReplaceCommand(1, CharacterData.current.Type, 303);
																																						if (71214 - 599427 != -528212)
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
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006DC8 RID: 28104 RVA: 0x00F414F8 File Offset: 0x00F3F6F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RemoveRemporarySkill()
	{
		if (176221 - 566439 != -390217)
		{
		}
		for (;;)
		{
			CharacterData.current.deleteSkill(102);
			if (84590 - 521651 != -437060)
			{
				CharacterData.current.deleteSkill(103);
				if (199325 - 348811 != -149485)
				{
					CharacterData.current.deleteSkill(104);
					if (154955 - 351437 == -196482)
					{
						CharacterData.current.deleteSkill(111);
						if (143050 - 101912 == 41138)
						{
							CharacterData.current.deleteSkill(112);
							if (217353 - 182031 != 35323)
							{
								CharacterData.current.deleteSkill(113);
								if (217718 - 481523 == -263805)
								{
									CharacterData.current.deleteSkill(114);
									if (188647 - 194365 == -5718)
									{
										CharacterData.current.deleteSkill(201);
										if (252880 - 382829 != -129948)
										{
											CharacterData.current.deleteSkill(202);
											if (68370 - 434690 == -366320)
											{
												CharacterData.current.deleteSkill(203);
												if (252371 - 188527 == 63844)
												{
													CharacterData.current.deleteSkill(204);
													if (108152 - 188806 != -80653)
													{
														CharacterData.current.deleteSkill(301);
														if (55751 - 83564 == -27813)
														{
															CharacterData.current.deleteSkill(302);
															if (67428 - 333358 != -265929)
															{
																CharacterData.current.deleteSkill(303);
																if (9632 - 228597 == -218965)
																{
																	CharacterData.current.deleteSkill(304);
																	if (176807 - 222016 != -45208)
																	{
																		CharacterData.current.removeCommand(111);
																		if (98399 - 463351 != -364951)
																		{
																			CharacterData.current.removeCommand(112);
																			if (101737 - 437330 != -335592)
																			{
																				CharacterData.current.removeCommand(113);
																				if (712 - 488322 == -487610)
																				{
																					CharacterData.current.removeCommand(114);
																					if (192651 - 283078 == -90427)
																					{
																						CharacterData.current.removeCommand(201);
																						if (137533 - 587642 != -450108)
																						{
																							CharacterData.current.removeCommand(202);
																							if (56750 - 375312 == -318562)
																							{
																								CharacterData.current.removeCommand(203);
																								if (142572 - 81746 == 60826)
																								{
																									CharacterData.current.removeCommand(204);
																									if (130239 - 216456 == -86217)
																									{
																										CharacterData.current.removeCommand(301);
																										if (212491 - 453729 != -241237)
																										{
																											CharacterData.current.removeCommand(302);
																											if (86770 - 237547 != -150776)
																											{
																												CharacterData.current.removeCommand(303);
																												if (119019 - 276830 != -157810)
																												{
																													CharacterData.current.removeCommand(304);
																													if (107477 - 442282 == -334805)
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
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006DC9 RID: 28105 RVA: 0x00F41974 File Offset: 0x00F3FB74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (238140 - 539373 != -301232)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (65800 - 164999 == -99199)
			{
				Time.timeScale = 1f;
				if (161500 - 309112 == -147612)
				{
					this.InitTutorialEvent();
					if (259321 - 505753 == -246432)
					{
						Hashtable customOpParameters = new Hashtable();
						if (227400 - 195847 != 31554)
						{
							this.KjpcBxEZcGi.OpCustom(52, customOpParameters, true);
							if (149983 - 522327 == -372344)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006DCA RID: 28106 RVA: 0x00F41A60 File Offset: 0x00F3FC60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (20882 - 266396 != -245513)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (215381 - 97781 == 117600)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (3500 - 529994 != -526493)
				{
					Game.mGameState = eGameState.Setup;
					if (153260 - 238391 != -85130)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006DCB RID: 28107 RVA: 0x00F41B04 File Offset: 0x00F3FD04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (93830 - 330211 != -236381)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (24203 - 469560 != -445356)
			{
				if (num == PlayerData.UID)
				{
					if (111307 - 263638 != -152330)
					{
						this.SetupActors();
						if (268690 - 242588 != 26103)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (69486 - 373306 == -303820)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006DCC RID: 28108 RVA: 0x00F41BD4 File Offset: 0x00F3FDD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (32323 - 26022 != 6301)
		{
		}
		for (;;)
		{
			IL_C2:
			Debug.Log("Creating Actors");
			if (18833 - 380939 != -362105)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (223278 - 144915 != 78364)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (54694 - 411249 == -356555)
						{
							int i = 0;
							if (147046 - 117699 != 29348)
							{
								CharacterControl[] array2 = array;
								if (190484 - 22674 != 167811)
								{
									int length = array2.Length;
									if (52507 - 490397 == -437890)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (43261 - 290311 != -247050)
												{
													goto IL_C2;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (196002 - 502615 == -306612)
												{
													goto IL_C2;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (37681 - 329615 == -291933)
												{
													goto IL_C2;
												}
												this.J1scBA90wfp++;
												if (5391 - 58684 != -53293)
												{
													goto IL_C2;
												}
											}
											i++;
											if (14683 - 465746 != -451063)
											{
												goto IL_C2;
											}
										}
										if (244761 - 527036 == -282275)
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
						if (92160 - 284921 == -192761)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006DCD RID: 28109 RVA: 0x00F41E10 File Offset: 0x00F40010
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (189394 - 234853 != -45459)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (8667 - 172608 == -163941)
			{
				int i = 0;
				if (180371 - 422912 == -242541)
				{
					CharacterControl[] array2 = array;
					if (78218 - 335880 == -257662)
					{
						int length = array2.Length;
						if (83543 - 591782 == -508239)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (157559 - 343384 == -185824)
								{
									goto IL_E0;
								}
								i++;
								if (158261 - 362295 != -204034)
								{
									goto IL_E0;
								}
							}
							if (147104 - 374153 != -227048)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006DCE RID: 28110 RVA: 0x00F41F40 File Offset: 0x00F40140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (168765 - 63562 != 105203)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (223293 - 122871 == 100422)
			{
				Game.mGameState = eGameState.Ready;
				if (297308 - 63188 == 234120)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (293158 - 392400 != -99241 && 233260 - 267057 != -33796)
					{
						if (216813 - 69748 == 147065)
						{
							if (playerSlot <= 1)
							{
								goto IL_1A2;
							}
							if (9683 - 406229 != -396546)
							{
								continue;
							}
							if (playerSlot > 6)
							{
								goto IL_1A2;
							}
							if (216512 - 400327 != -183815)
							{
								continue;
							}
							GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
							if (173829 - 80365 != 93464)
							{
								continue;
							}
							IL_D1:
							if (!gameObject)
							{
								break;
							}
							if (26998 - 448523 == -421524)
							{
								continue;
							}
							Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
							if (25057 - 180304 != -155247)
							{
								continue;
							}
							if (spawnPos != Vector3.zero)
							{
								if (244337 - 475277 == -230939)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
								if (225066 - 44856 != 180210)
								{
									continue;
								}
								break;
							}
							else
							{
								this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
								if (282286 - 162958 != 119328)
								{
									continue;
								}
								break;
							}
							IL_1A2:
							gameObject = GameObject.Find("StartPoint1");
							if (108538 - 234791 == -126253)
							{
								goto IL_D1;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006DCF RID: 28111 RVA: 0x00F421AC File Offset: 0x00F403AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M100_GameTutorial1.$StartGame$36977(this).GetEnumerator();
	}

	// Token: 0x06006DD0 RID: 28112 RVA: 0x00F421BC File Offset: 0x00F403BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06006DD1 RID: 28113 RVA: 0x00F421C0 File Offset: 0x00F403C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M100_GameTutorial1.$onGameComplete$36981(data, this).GetEnumerator();
	}

	// Token: 0x06006DD2 RID: 28114 RVA: 0x00F421D0 File Offset: 0x00F403D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (237903 - 211108 != 26795)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (26033 - 474680 == -448647)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (233109 - 244308 != -11198)
				{
					hashtable.Add(43, PlayerData.UID);
					if (126088 - 579911 == -453823)
					{
						hashtable.Add(73, nType);
						if (90987 - 537341 != -446353)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (183941 - 568491 != -384549)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (6807 - 106654 != -99846)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (191480 - 524205 == -332725)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (125991 - 537696 == -411705)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (127763 - 68879 != 58885)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (158925 - 510058 == -351133)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (193114 - 478362 == -285248)
													{
														this.KjpcBxEZcGi.OpCustom(63, hashtable, true);
														if (22358 - 535056 != -512697)
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

	// Token: 0x06006DD3 RID: 28115 RVA: 0x00F424B4 File Offset: 0x00F406B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (114834 - 94721 != 20113)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (64993 - 434819 == -369826)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (12772 - 344277 == -331505)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (291726 - 450978 != -159251)
						{
							if (this.J1scBA90wfp <= 0)
							{
								break;
							}
							if (153243 - 596587 != -443343)
							{
								this.J1scBA90wfp--;
								if (91076 - 551346 != -460269)
								{
									if (this.J1scBA90wfp != 0)
									{
										break;
									}
									if (253792 - 98759 != 155034)
									{
										Game.setGameState(eGameState.Ready);
										if (16880 - 209253 != -192372)
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
						if (18120 - 143145 != -125024)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (254823 - 230217 != 24607)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006DD4 RID: 28116 RVA: 0x00F42644 File Offset: 0x00F40844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06006DD5 RID: 28117 RVA: 0x00F42658 File Offset: 0x00F40858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (24626 - 567013 != -542387)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (289240 - 594503 != -305262)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (239936 - 414251 != -174314)
				{
					if (!characterControl)
					{
						break;
					}
					if (275247 - 491396 != -216148)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (117432 - 325225 == -207793)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (72069 - 575995 != -503925)
							{
								string type = characterControl.Type;
								if (192239 - 237451 != -45211)
								{
									if (type == "TargetPractice")
									{
										if (299873 - 1336 == 298537)
										{
											Game.sendMissionEvent(1002, 0);
											if (115560 - 447095 == -331535)
											{
												break;
											}
										}
									}
									else if (type == "LittleFatBug_w")
									{
										if (7895 - 303638 != -295742)
										{
											Game.sendMissionEvent(1003, 0);
											if (210171 - 195484 != 14688)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "FatBug_g"))
										{
											break;
										}
										if (127064 - 63458 == 63606)
										{
											Game.sendMissionEvent(1004, 0);
											if (15359 - 30809 != -15449)
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

	// Token: 0x06006DD6 RID: 28118 RVA: 0x00F42878 File Offset: 0x00F40A78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (52825 - 526950 != -474124)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (281556 - 154978 == 126578)
			{
				hashtable.Add(71, CID);
				if (36081 - 583078 != -546996)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (259669 - 346291 != -86621)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (194842 - 504203 != -309360)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (199652 - 106178 != 93475)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (190775 - 599266 == -408491)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (118386 - 366981 == -248595)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (55867 - 236876 != -181008)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (163083 - 468388 != -305304)
											{
												this.KjpcBxEZcGi.OpCustom(61, hashtable, true);
												if (71810 - 539206 != -467395)
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

	// Token: 0x06006DD7 RID: 28119 RVA: 0x00F42B04 File Offset: 0x00F40D04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (128894 - 342278 != -213384)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (143671 - 592152 == -448481)
			{
				if (!gameObject)
				{
					break;
				}
				if (142438 - 486923 != -344484)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (285764 - 552334 != -266569)
					{
						playerCameraControl.target = gameObject;
						if (260285 - 599252 != -338966)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (35449 - 77685 != -42235)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006DD8 RID: 28120 RVA: 0x00F42BFC File Offset: 0x00F40DFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (44016 - 526698 != -482682)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (71874 - 232302 == -160428)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (65631 - 404378 != -338746)
				{
					gameGui.ResetTeamBar();
					if (116644 - 203247 != -86602)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006DD9 RID: 28121 RVA: 0x00F42CA8 File Offset: 0x00F40EA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M100_GameTutorial1.$onDeadPlayer$36991(this).GetEnumerator();
	}

	// Token: 0x06006DDA RID: 28122 RVA: 0x00F42CB8 File Offset: 0x00F40EB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (220275 - 247516 != -27240)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (150393 - 311499 != -161105)
			{
				ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
				if (74672 - 35079 != 39594)
				{
					if (changeGui)
					{
						if (46252 - 516166 != -469914)
						{
							continue;
						}
						changeGui.disable();
						if (299395 - 59548 == 239848)
						{
							continue;
						}
					}
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (262875 - 452847 != -189971)
					{
						playerCameraControl.target = Game.mPlayer;
						if (89932 - 142985 == -53053)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006DDB RID: 28123 RVA: 0x00F42DE0 File Offset: 0x00F40FE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (233419 - 292328 != -58908)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (57092 - 331575 == -274483)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (166660 - 4004 != 162657)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (67858 - 24252 != 43607)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006DDC RID: 28124 RVA: 0x00F42EA4 File Offset: 0x00F410A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06006DDD RID: 28125 RVA: 0x00F42ED0 File Offset: 0x00F410D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (57430 - 54197 != 3233)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (74071 - 1095 == 72976)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (174240 - 2575 == 171665)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (75942 - 410914 == -334972)
					{
						Hashtable hashtable = new Hashtable();
						if (237080 - 538737 != -301656)
						{
							hashtable.Add(43, PlayerData.UID);
							if (178930 - 84779 == 94151)
							{
								hashtable.Add(71, nCID);
								if (40809 - 136996 != -96186)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (93184 - 573371 != -480186)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (92137 - 80567 != 11571)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (16226 - 446589 == -430363)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (264790 - 102859 == 161931)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (271481 - 388667 == -117186)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (173288 - 86088 == 87200)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (254432 - 414678 != -160245)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (231499 - 563792 != -332292)
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

	// Token: 0x06006DDE RID: 28126 RVA: 0x00F431F0 File Offset: 0x00F413F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M100_GameTutorial1.$onChangePlayer$36997(data, this).GetEnumerator();
	}

	// Token: 0x06006DDF RID: 28127 RVA: 0x00F43200 File Offset: 0x00F41400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M100_GameTutorial1.$ReturnToTown$37004(this).GetEnumerator();
	}

	// Token: 0x06006DE0 RID: 28128 RVA: 0x00F43210 File Offset: 0x00F41410
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M100_GameTutorial1.$ReturnToGuild$37009(this).GetEnumerator();
	}

	// Token: 0x06006DE1 RID: 28129 RVA: 0x00F43220 File Offset: 0x00F41420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M100_GameTutorial1.$ReturnToCamp$37013(this).GetEnumerator();
	}

	// Token: 0x06006DE2 RID: 28130 RVA: 0x00F43230 File Offset: 0x00F41430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (263387 - 256315 != 7072)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (113060 - 334946 == -221886)
			{
				Hashtable hashtable = new Hashtable();
				if (269277 - 203226 != 66052)
				{
					hashtable.Add(43, PlayerData.UID);
					if (263164 - 152842 == 110322)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (284427 - 362522 == -78095)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006DE3 RID: 28131 RVA: 0x00F43308 File Offset: 0x00F41508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		if (201685 - 440886 != -239201)
		{
		}
		for (;;)
		{
			Debug.Log("onLeaveGame");
			if (287490 - 334340 == -46850)
			{
				this.RemoveRemporarySkill();
				if (75059 - 108614 == -33555)
				{
					this.JoinTown();
					if (26399 - 149891 == -123492)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006DE4 RID: 28132 RVA: 0x00F433A4 File Offset: 0x00F415A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (16567 - 122713 != -106146)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (284990 - 535157 != -250166)
			{
				Hashtable hashtable = new Hashtable();
				if (203643 - 503668 != -300024)
				{
					if (Game.mNextGameCode == 30)
					{
						if (230408 - 217295 != 13113)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (80604 - 250836 != -170232)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (265472 - 535314 != -269842)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (83515 - 561977 != -478462)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (287665 - 340227 == -52561)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (298423 - 468059 == -169635)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (189419 - 233367 == -43947)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (268364 - 222141 == 46224)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (250237 - 132551 != 117686)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (119098 - 583567 == -464468)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (93186 - 76669 != 16517)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (109046 - 123863 == -14816)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (276021 - 518782 != -242761)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (14978 - 395747 == -380768)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (61189 - 285382 != -224193)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (143408 - 581331 == -437922)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (44414 - 224283 != -179869)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (224505 - 396687 != -172182)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (56760 - 41902 == 14859)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (288180 - 434941 != -146761)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (36025 - 387151 != -351126)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (97036 - 381871 != -284835)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (240067 - 565015 == -324947)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (11593 - 71487 == -59893)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (158972 - 402393 == -243420)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (180593 - 220049 != -39456)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (235762 - 324094 == -88331)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (57357 - 300915 != -243558)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (258011 - 231055 != 26957)
					{
						this.KjpcBxEZcGi.OpCustom(42, hashtable, true);
						if (22768 - 347978 == -325210)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006DE5 RID: 28133 RVA: 0x00F43958 File Offset: 0x00F41B58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06006DE6 RID: 28134 RVA: 0x00F43968 File Offset: 0x00F41B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006DE7 RID: 28135 RVA: 0x00F4396C File Offset: 0x00F41B6C
	internal static bool tWYW3upmb7paVZquiZDV()
	{
		return true;
	}

	// Token: 0x06006DE8 RID: 28136 RVA: 0x00F43970 File Offset: 0x00F41B70
	internal static bool seHLLJpmuBRSw5NxkbPu()
	{
		return false;
	}

	// Token: 0x0400755F RID: 30047
	private LitePeer KjpcBxEZcGi;

	// Token: 0x04007560 RID: 30048
	private PlayerCameraControl P6KcBTO1K6U;

	// Token: 0x04007561 RID: 30049
	private float wevcBYqqQ71;

	// Token: 0x04007562 RID: 30050
	private int LrhcB3KRbKm;

	// Token: 0x04007563 RID: 30051
	private float B1kcBbakxdR;

	// Token: 0x04007564 RID: 30052
	private int guocBd2ujGG;

	// Token: 0x04007565 RID: 30053
	private int aUGcBgQDhEo;

	// Token: 0x04007566 RID: 30054
	private int ECAcBa7bcv8;

	// Token: 0x04007567 RID: 30055
	private GameGui MFecB4ldj2R;

	// Token: 0x04007568 RID: 30056
	private StoryGui TCLcBsTVlNu;

	// Token: 0x04007569 RID: 30057
	private Texture Wh5cBHn1c3Z;

	// Token: 0x0400756A RID: 30058
	private GUIStyle oVDcB7pvXvE;

	// Token: 0x0400756B RID: 30059
	private GUIStyle YFLcBZQEoBJ;

	// Token: 0x0400756C RID: 30060
	private GUIStyle l2TcBCh9Qfh;

	// Token: 0x0400756D RID: 30061
	private GUIStyle V35cBMYnDfl;

	// Token: 0x0400756E RID: 30062
	private GUIStyle hQTcBfRVnmG;

	// Token: 0x0400756F RID: 30063
	private int FZrcBLWBytN;

	// Token: 0x04007570 RID: 30064
	private Texture B3YcBw3JUTS;

	// Token: 0x04007571 RID: 30065
	private Texture MaFcBUiGnkH;

	// Token: 0x04007572 RID: 30066
	private Texture IhbcBNhAj8J;

	// Token: 0x04007573 RID: 30067
	private Texture HYmcBEiWWQA;

	// Token: 0x04007574 RID: 30068
	private Texture KlFcBPPTjwN;

	// Token: 0x04007575 RID: 30069
	private Texture u6PcBSLO9Io;

	// Token: 0x04007576 RID: 30070
	private GameObject pW0cBBScBYI;

	// Token: 0x04007577 RID: 30071
	private GameObject xP4cB0Qy2Li;

	// Token: 0x04007578 RID: 30072
	private AudioClip DmicB8Nie34;

	// Token: 0x04007579 RID: 30073
	private AudioClip SUjcBifwx3l;

	// Token: 0x0400757A RID: 30074
	private AudioClip oXGcBDWFHVd;

	// Token: 0x0400757B RID: 30075
	private AudioClip SD8cBmNwZws;

	// Token: 0x0400757C RID: 30076
	public AudioClip music_battle1;

	// Token: 0x0400757D RID: 30077
	public AudioClip hi_vc;

	// Token: 0x0400757E RID: 30078
	public AudioClip good_vc;

	// Token: 0x0400757F RID: 30079
	public AudioClip cast_vc;

	// Token: 0x04007580 RID: 30080
	public AudioClip laugh_vc;

	// Token: 0x04007581 RID: 30081
	public AudioClip chat_vc;

	// Token: 0x04007582 RID: 30082
	private Vector3 HvucBj19U7E;

	// Token: 0x04007583 RID: 30083
	private Quaternion rlncBoUEkFI;

	// Token: 0x04007584 RID: 30084
	private Vector3 WwgcBk23WF5;

	// Token: 0x04007585 RID: 30085
	private Quaternion yt9cBFikQmq;

	// Token: 0x04007586 RID: 30086
	private int J1scBA90wfp;

	// Token: 0x020012A1 RID: 4769
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$36937 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006DE9 RID: 28137 RVA: 0x00F43974 File Offset: 0x00F41B74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$36937(Hashtable data, M100_GameTutorial1 self_)
		{
			if (18109 - 253800 != -235690)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (50048 - 312234 == -262186)
				{
					base..ctor();
					if (74543 - 443558 == -369015)
					{
						this.$data$36944 = data;
						if (17136 - 494506 == -477370)
						{
							this.$self_$36945 = self_;
							if (6780 - 578301 != -571520)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x00F43A30 File Offset: 0x00F41C30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial1.$onGameEvent$36937.$(this.$data$36944, this.$self_$36945);
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x00F43A44 File Offset: 0x00F41C44
		internal static bool yyc0mbpmIecl6660cXHb()
		{
			return true;
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x00F43A48 File Offset: 0x00F41C48
		internal static bool NHypt5pmBA7CgqgbYgjS()
		{
			return false;
		}

		// Token: 0x04007587 RID: 30087
		internal Hashtable $data$36944;

		// Token: 0x04007588 RID: 30088
		internal M100_GameTutorial1 $self_$36945;

		// Token: 0x020012A2 RID: 4770
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006DED RID: 28141 RVA: 0x00F43A4C File Offset: 0x00F41C4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M100_GameTutorial1 self_)
			{
				if (61805 - 521861 != -460056)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (163175 - 195036 != -31860)
					{
						base..ctor();
						if (141328 - 4099 == 137229)
						{
							this.$data$36942 = data;
							if (172826 - 89573 == 83253)
							{
								this.$self_$36943 = self_;
								if (138081 - 119945 == 18136)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006DEE RID: 28142 RVA: 0x00F43B08 File Offset: 0x00F41D08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (121422 - 318197 != -196774)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_597;
					case 2:
						Application.LoadLevel("M100_GameTutorial2");
						if (161630 - 518336 != -356706)
						{
							continue;
						}
						goto IL_33A;
					default:
						if (1144 - 334014 != -332870)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (274472 - 86109 != 188364)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$36938 = RuntimeServices.UnboxInt32(this.$data$36942[141]);
						if (43538 - 272748 != -229210)
						{
							continue;
						}
						this.$returnValue$36939 = RuntimeServices.UnboxInt32(this.$data$36942[145]);
						if (203039 - 416562 != -213523)
						{
							continue;
						}
						this.$ownerID$36940 = RuntimeServices.UnboxInt32(this.$data$36942[43]);
						if (283656 - 177021 == 106636)
						{
							continue;
						}
						this.$$switch$6212$36941 = this.$returnCode$36938;
						if (250304 - 174476 == 75829)
						{
							continue;
						}
						if (this.$$switch$6212$36941 == 1001)
						{
							if (99596 - 145483 == -45886)
							{
								continue;
							}
							this.$self_$36943.SendMessage("newGameMessage", "Mission Objective: Chase Reggu - Complete!");
							if (207832 - 30392 != 177440)
							{
								continue;
							}
						}
						else if (this.$$switch$6212$36941 == 1002)
						{
							if (194189 - 514800 != -320611)
							{
								continue;
							}
							this.$self_$36943.guocBd2ujGG = this.$self_$36943.guocBd2ujGG + 1;
							if (284632 - 591717 == -307084)
							{
								continue;
							}
							this.$self_$36943.SendMessage("newGameMessage", "Mission Objective: Destroy Practice Target:" + this.$self_$36943.guocBd2ujGG + "/3");
							if (206064 - 174744 == 31321)
							{
								continue;
							}
							Chat.SubmitChat("none", "Destroy Practice Target:" + this.$self_$36943.guocBd2ujGG + "/3", eChatType.system, eChatMode.system);
							if (43305 - 114272 == -70966)
							{
								continue;
							}
						}
						else if (this.$$switch$6212$36941 == 1003)
						{
							if (117518 - 526687 == -409168)
							{
								continue;
							}
							this.$self_$36943.aUGcBgQDhEo = this.$self_$36943.aUGcBgQDhEo + 1;
							if (138855 - 190177 != -51322)
							{
								continue;
							}
							this.$self_$36943.SendMessage("newGameMessage", "Mission Objective: Little Fatbug Eliminated:" + this.$self_$36943.aUGcBgQDhEo + "/1");
							if (142842 - 536392 == -393549)
							{
								continue;
							}
							Chat.SubmitChat("none", "Little Fatbug Eliminated:" + this.$self_$36943.aUGcBgQDhEo + "/1", eChatType.system, eChatMode.system);
							if (260917 - 311318 != -50401)
							{
								continue;
							}
						}
						else if (this.$$switch$6212$36941 == 1004)
						{
							if (21707 - 597281 != -575574)
							{
								continue;
							}
							this.$self_$36943.ECAcBa7bcv8 = this.$self_$36943.ECAcBa7bcv8 + 1;
							if (40081 - 3564 != 36517)
							{
								continue;
							}
							this.$self_$36943.SendMessage("newGameMessage", "Mission Objective: Fatbug Eliminated:" + this.$self_$36943.ECAcBa7bcv8 + "/1");
							if (213989 - 24904 == 189086)
							{
								continue;
							}
							Chat.SubmitChat("none", "Fatbug Eliminated:" + this.$self_$36943.ECAcBa7bcv8 + "/1", eChatType.system, eChatMode.system);
							if (149152 - 69251 == 79902)
							{
								continue;
							}
							this.$self_$36943.StartCoroutine_Auto(this.$self_$36943.EndTutorialEvent());
							if (121123 - 107967 == 13157)
							{
								continue;
							}
						}
						else if (this.$$switch$6212$36941 == 1005)
						{
							if (132954 - 468931 == -335976)
							{
								continue;
							}
							this.$self_$36943.RemoveRemporarySkill();
							if (48444 - 590542 == -542097)
							{
								continue;
							}
							this.$self_$36943.SendMessage("fadeOut");
							if (125866 - 573603 != -447737)
							{
								continue;
							}
							goto IL_560;
						}
					}
					IL_33A:
					this.YieldDefault(1);
				}
				while (136179 - 361678 != -225499);
				goto IL_597;
				IL_560:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_597:
				return false;
			}

			// Token: 0x06006DEF RID: 28143 RVA: 0x00F440C0 File Offset: 0x00F422C0
			internal static bool cCTBWJpmeGqBBqmWfPT9()
			{
				return true;
			}

			// Token: 0x06006DF0 RID: 28144 RVA: 0x00F440C4 File Offset: 0x00F422C4
			internal static bool sZHgiApmrhXqO8KZF5e4()
			{
				return false;
			}

			// Token: 0x04007589 RID: 30089
			internal int $returnCode$36938;

			// Token: 0x0400758A RID: 30090
			internal int $returnValue$36939;

			// Token: 0x0400758B RID: 30091
			internal int $ownerID$36940;

			// Token: 0x0400758C RID: 30092
			internal int $$switch$6212$36941;

			// Token: 0x0400758D RID: 30093
			internal Hashtable $data$36942;

			// Token: 0x0400758E RID: 30094
			internal M100_GameTutorial1 $self_$36943;
		}
	}

	// Token: 0x020012A3 RID: 4771
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TutorialEvent$36946 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006DF1 RID: 28145 RVA: 0x00F440C8 File Offset: 0x00F422C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TutorialEvent$36946(M100_GameTutorial1 self_)
		{
			if (5438 - 492865 != -487427)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (185243 - 439762 == -254519)
				{
					base..ctor();
					if (121096 - 225980 != -104883)
					{
						this.$self_$36965 = self_;
						if (44569 - 560643 == -516074)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006DF2 RID: 28146 RVA: 0x00F44160 File Offset: 0x00F42360
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial1.$TutorialEvent$36946.$(this.$self_$36965);
		}

		// Token: 0x06006DF3 RID: 28147 RVA: 0x00F44170 File Offset: 0x00F42370
		internal static bool yNxOvbpmj6nbFrrRH36v()
		{
			return true;
		}

		// Token: 0x06006DF4 RID: 28148 RVA: 0x00F44174 File Offset: 0x00F42374
		internal static bool SiYBxnpmhTDL9eSJDGs4()
		{
			return false;
		}

		// Token: 0x0400758F RID: 30095
		internal M100_GameTutorial1 $self_$36965;

		// Token: 0x020012A4 RID: 4772
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006DF5 RID: 28149 RVA: 0x00F44178 File Offset: 0x00F42378
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial1 self_)
			{
				if (29802 - 489341 != -459538)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161794 - 526042 != -364247)
					{
						base..ctor();
						if (153092 - 329365 != -176272)
						{
							this.$self_$36964 = self_;
							if (83074 - 506940 == -423866)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006DF6 RID: 28150 RVA: 0x00F44210 File Offset: 0x00F42410
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (275818 - 252314 != 23504)
				{
				}
				for (;;)
				{
					IL_4708:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5F61;
					case 2:
						this.$mSpawnPoint1$36948 = GameObject.Find("SpawnPoint1");
						if (162430 - 349376 == -186945)
						{
							continue;
						}
						if (!this.$self_$36964.pW0cBBScBYI)
						{
							goto IL_12DC;
						}
						if (144417 - 101426 == 42992)
						{
							continue;
						}
						if (!this.$mSpawnPoint1$36948)
						{
							goto IL_12DC;
						}
						if (206656 - 112281 == 94376)
						{
							continue;
						}
						if (this.$self_$36964.xP4cB0Qy2Li)
						{
							if (278569 - 356346 == -77776)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$36964.xP4cB0Qy2Li, this.$self_$36964.pW0cBBScBYI.transform.position, this.$self_$36964.pW0cBBScBYI.transform.rotation);
							if (89818 - 44489 != 45329)
							{
								continue;
							}
						}
						this.$self_$36964.pW0cBBScBYI.transform.position = this.$mSpawnPoint1$36948.transform.position;
						if (64451 - 196125 != -131674)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.transform.rotation = this.$mSpawnPoint1$36948.transform.rotation;
						if (210149 - 282828 != -72679)
						{
							continue;
						}
						if (this.$self_$36964.xP4cB0Qy2Li)
						{
							if (40786 - 36455 == 4332)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$36964.xP4cB0Qy2Li, this.$self_$36964.pW0cBBScBYI.transform.position, this.$self_$36964.pW0cBBScBYI.transform.rotation);
							if (84725 - 9817 == 74909)
							{
								continue;
							}
						}
						this.$self_$36964.pW0cBBScBYI.animation.CrossFade("root");
						if (288636 - 517474 == -228837)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.wrapMode = WrapMode.Loop;
						if (232324 - 216814 != 15511)
						{
							goto IL_12DC;
						}
						continue;
					case 3:
						this.$t$36952 = 0;
						if (167016 - 137669 == 29348)
						{
							continue;
						}
						while (this.$t$36952 < 3)
						{
							this.$mTargetSpawnPos$36953 = GameObject.Find("SpawnPoint" + (4 + this.$t$36952));
							if (262000 - 288959 != -26959)
							{
								goto IL_4708;
							}
							if (this.$mTargetSpawnPos$36953)
							{
								if (191303 - 553102 != -361799)
								{
									goto IL_4708;
								}
								this.$self_$36964.createActor("TargetPractice", 6, this.$mTargetSpawnPos$36953.transform.position, this.$mTargetSpawnPos$36953.transform.forward);
								if (279639 - 438388 != -158749)
								{
									goto IL_4708;
								}
								if (this.$self_$36964.xP4cB0Qy2Li)
								{
									if (77303 - 408052 != -330749)
									{
										goto IL_4708;
									}
									UnityEngine.Object.Instantiate(this.$self_$36964.xP4cB0Qy2Li, this.$mTargetSpawnPos$36953.transform.position, this.$mTargetSpawnPos$36953.transform.rotation);
									if (101233 - 409174 == -307940)
									{
										goto IL_4708;
									}
								}
							}
							this.$t$36952++;
							if (256652 - 359993 != -103341)
							{
								goto IL_4708;
							}
						}
						if (258161 - 46791 != 211370)
						{
							continue;
						}
						goto IL_5EB5;
					case 4:
						this.$self_$36964.pW0cBBScBYI.animation.CrossFade("root");
						if (230555 - 284578 == -54022)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.wrapMode = WrapMode.Loop;
						if (233898 - 562396 != -328498)
						{
							continue;
						}
						goto IL_2CF0;
					default:
						if (56712 - 113706 != -56994)
						{
							continue;
						}
						break;
					}
					this.$$switch$6220$36947 = this.$self_$36964.LrhcB3KRbKm;
					if (111803 - 164709 == -52905)
					{
						continue;
					}
					if (this.$$switch$6220$36947 == 1)
					{
						if (279407 - 333046 == -53638)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR < (float)5)
						{
							if (291463 - 288711 != 2752)
							{
								continue;
							}
							float num = this.$$14132$36958 = Mathf.SmoothStep(this.$self_$36964.HvucBj19U7E.x, this.$self_$36964.WwgcBk23WF5.x, 0.2f * (Time.time - this.$self_$36964.B1kcBbakxdR));
							if (139440 - 128647 == 10794 || 288970 - 250041 == 38930)
							{
								continue;
							}
							Vector3 vector = this.$$14133$36959 = this.$self_$36964.transform.position;
							if (211319 - 578253 == -366933)
							{
								continue;
							}
							if (84860 - 225432 != -140572)
							{
								continue;
							}
							this.$$14133$36959.x = this.$$14132$36958;
							if (110667 - 167722 == -57054 || 268103 - 468127 == -200023)
							{
								continue;
							}
							this.$self_$36964.transform.position = this.$$14133$36959;
							if (29317 - 442866 != -413549)
							{
								continue;
							}
							if (218488 - 317305 != -98817)
							{
								continue;
							}
							this.$$14134$36960 = Mathf.SmoothStep(this.$self_$36964.HvucBj19U7E.y, this.$self_$36964.WwgcBk23WF5.y, 0.2f * (Time.time - this.$self_$36964.B1kcBbakxdR));
							if (201403 - 365934 != -164531)
							{
								continue;
							}
							if (229103 - 305166 == -76062)
							{
								continue;
							}
							this.$$14135$36961 = this.$self_$36964.transform.position;
							if (85526 - 319071 == -233544)
							{
								continue;
							}
							if (251457 - 156325 != 95132)
							{
								continue;
							}
							float num2 = this.$$14135$36961.y = this.$$14134$36960;
							if (38146 - 251679 != -213533)
							{
								continue;
							}
							if (290084 - 443314 != -153230)
							{
								continue;
							}
							this.$self_$36964.transform.position = this.$$14135$36961;
							if (98805 - 553758 != -454953)
							{
								continue;
							}
							if (156766 - 194953 == -38186)
							{
								continue;
							}
							float num3 = this.$$14136$36962 = Mathf.SmoothStep(this.$self_$36964.HvucBj19U7E.z, this.$self_$36964.WwgcBk23WF5.z, 0.2f * (Time.time - this.$self_$36964.B1kcBbakxdR));
							if (1170 - 424446 != -423276)
							{
								continue;
							}
							if (283185 - 28765 != 254420)
							{
								continue;
							}
							this.$$14137$36963 = this.$self_$36964.transform.position;
							if (72378 - 587637 == -515258)
							{
								continue;
							}
							if (214104 - 340602 != -126498)
							{
								continue;
							}
							this.$$14137$36963.z = this.$$14136$36962;
							if (106588 - 270594 != -164006)
							{
								continue;
							}
							if (138152 - 326589 == -188436)
							{
								continue;
							}
							this.$self_$36964.transform.position = this.$$14137$36963;
							if (172002 - 585181 == -413178)
							{
								continue;
							}
							if (261094 - 284840 != -23746)
							{
								continue;
							}
							this.$self_$36964.transform.rotation = Quaternion.Slerp(this.$self_$36964.rlncBoUEkFI, this.$self_$36964.yt9cBFikQmq, 0.2f * (Time.time - this.$self_$36964.B1kcBbakxdR));
							if (291667 - 187241 != 104426)
							{
								continue;
							}
						}
						else
						{
							this.$self_$36964.LrhcB3KRbKm = 2;
							if (208741 - 198065 == 10677)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (24028 - 392782 == -368753)
							{
								continue;
							}
							if (this.$self_$36964.TCLcBsTVlNu)
							{
								if (271502 - 587539 != -316037)
								{
									continue;
								}
								this.$self_$36964.TCLcBsTVlNu.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
								if (20118 - 307981 != -287863)
								{
									continue;
								}
							}
						}
						if (Game.music != 0)
						{
							if (259140 - 350053 == -90912)
							{
								continue;
							}
							if (!this.$self_$36964.audio.isPlaying)
							{
								if (13609 - 466632 == -453022)
								{
									continue;
								}
								this.$self_$36964.audio.Play();
								if (210956 - 207958 != 2998)
								{
									continue;
								}
							}
						}
						if (Time.time - Game.mGameTime < (float)2)
						{
							if (233503 - 196171 == 37333)
							{
								continue;
							}
							this.$self_$36964.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
							if (211984 - 297932 != -85948)
							{
								continue;
							}
						}
						else
						{
							this.$self_$36964.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (73363 - 408439 != -335076)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 2)
					{
						if (282270 - 68716 == 213555)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 0.5f)
						{
							if (86216 - 186762 != -100546)
							{
								continue;
							}
							this.$self_$36964.LrhcB3KRbKm = 3;
							if (58179 - 550312 != -492133)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (186709 - 306230 != -119521)
							{
								continue;
							}
							this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 1), eTalkType.friend);
							if (237662 - 486076 == -248413)
							{
								continue;
							}
							if (this.$self_$36964.pW0cBBScBYI)
							{
								if (113449 - 511481 == -398031)
								{
									continue;
								}
								this.$self_$36964.pW0cBBScBYI.animation.Play("talk");
								if (266498 - 599082 == -332583)
								{
									continue;
								}
								this.$self_$36964.pW0cBBScBYI.animation.wrapMode = WrapMode.Loop;
								if (31041 - 417529 != -386488)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("nvoice", 1) != 0)
							{
								if (165144 - 297866 != -132722)
								{
									continue;
								}
								if (this.$self_$36964.hi_vc)
								{
									if (242807 - 76579 != 166228)
									{
										continue;
									}
									this.$self_$36964.audio.PlayOneShot(this.$self_$36964.hi_vc);
									if (230517 - 363909 != -133392)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find hi voice");
									if (270368 - 319334 != -48966)
									{
										continue;
									}
								}
							}
						}
					}
					else if (this.$$switch$6220$36947 == 3)
					{
						if (153604 - 492789 == -339184)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 5f)
						{
							if (63802 - 108403 != -44601)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_105A;
							}
							if (204606 - 52203 != 152403)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_105A;
							}
							if (198390 - 454263 == -255872)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 4;
						if (65422 - 470050 != -404628)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (262176 - 277009 != -14833)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 2), eTalkType.friend);
						if (40773 - 125842 != -85069)
						{
							continue;
						}
						IL_105A:;
					}
					else if (this.$$switch$6220$36947 == 4)
					{
						if (165863 - 577744 != -411881)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 5f)
						{
							if (296502 - 137388 == 159115)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_2A45;
							}
							if (154303 - 228459 != -74156)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_2A45;
							}
							if (258637 - 146965 != 111672)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 5;
						if (118953 - 60314 != 58639)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (63340 - 219708 != -156368)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 3), eTalkType.friend);
						if (40162 - 271168 != -231006)
						{
							continue;
						}
						IL_2A45:;
					}
					else if (this.$$switch$6220$36947 == 5)
					{
						if (224300 - 412788 != -188488)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 5f)
						{
							if (278001 - 251114 == 26888)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_4799;
							}
							if (99623 - 252006 == -152382)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_4799;
							}
							if (245594 - 367423 == -121828)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 6;
						if (26116 - 191080 != -164964)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (65290 - 244699 != -179409)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 4), eTalkType.friend);
						if (56880 - 415142 == -358261)
						{
							continue;
						}
						IL_4799:;
					}
					else if (this.$$switch$6220$36947 == 6)
					{
						if (257847 - 381925 != -124078)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 5f)
						{
							if (191682 - 156308 == 35375)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_12DC;
							}
							if (23511 - 138401 == -114889)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_12DC;
							}
							if (64689 - 383930 != -319241)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 7;
						if (255571 - 264237 != -8666)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (119005 - 31747 != 87258)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.close();
						if (280600 - 530176 != -249576)
						{
							continue;
						}
						this.$self_$36964.FZrcBLWBytN = 1;
						if (168680 - 564107 != -395427)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.CrossFade("cast1");
						if (111071 - 198215 != -87144)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.wrapMode = WrapMode.Once;
						if (265573 - 308260 != -42687)
						{
							continue;
						}
						break;
					}
					else if (this.$$switch$6220$36947 == 7)
					{
						if (244771 - 55717 != 189054)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 8)
					{
						if (222994 - 351765 == -128770)
						{
							continue;
						}
						Vector3 vector2 = this.$self_$36964.pW0cBBScBYI.transform.position - Game.mPlayer.transform.position;
						if (245035 - 77032 != 168003)
						{
							continue;
						}
						if (vector2.sqrMagnitude < (float)9)
						{
							if (260469 - 473237 == -212767)
							{
								continue;
							}
							this.$mSpawnPoint2$36949 = GameObject.Find("SpawnPoint2");
							if (259454 - 91372 == 168083)
							{
								continue;
							}
							if (this.$mSpawnPoint2$36949)
							{
								if (111418 - 424204 != -312786)
								{
									continue;
								}
								this.$self_$36964.LrhcB3KRbKm = 9;
								if (53860 - 561769 == -507908)
								{
									continue;
								}
								this.$self_$36964.B1kcBbakxdR = Time.time;
								if (23285 - 340095 != -316810)
								{
									continue;
								}
								if (this.$self_$36964.xP4cB0Qy2Li)
								{
									if (285597 - 54782 != 230815)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$36964.xP4cB0Qy2Li, this.$self_$36964.pW0cBBScBYI.transform.position, this.$self_$36964.pW0cBBScBYI.transform.rotation);
									if (18234 - 194056 == -175821)
									{
										continue;
									}
								}
								this.$self_$36964.pW0cBBScBYI.transform.position = this.$mSpawnPoint2$36949.transform.position;
								if (263283 - 350405 != -87122)
								{
									continue;
								}
								this.$self_$36964.pW0cBBScBYI.transform.rotation = this.$mSpawnPoint2$36949.transform.rotation;
								if (89465 - 572563 != -483098)
								{
									continue;
								}
								if (this.$self_$36964.xP4cB0Qy2Li)
								{
									if (15876 - 301012 == -285135)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$36964.xP4cB0Qy2Li, this.$self_$36964.pW0cBBScBYI.transform.position, this.$self_$36964.pW0cBBScBYI.transform.rotation);
									if (268781 - 327509 == -58727)
									{
										continue;
									}
								}
								Chat.SubmitChat("Reggu", Language.getMessage("M100_GameTutorial", 5), eChatType.npc, eChatMode.area);
								if (120821 - 233493 == -112671)
								{
									continue;
								}
							}
						}
						else
						{
							this.$self_$36964.pW0cBBScBYI.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$self_$36964.pW0cBBScBYI.transform.position));
							if (47880 - 302625 == -254744)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 9)
					{
						if (58828 - 459454 == -400625)
						{
							continue;
						}
						Vector3 vector3 = this.$self_$36964.pW0cBBScBYI.transform.position - Game.mPlayer.transform.position;
						if (159815 - 75448 != 84367)
						{
							continue;
						}
						if (vector3.sqrMagnitude < (float)9)
						{
							if (111711 - 502886 != -391175)
							{
								continue;
							}
							this.$mSpawnPoint3$36950 = GameObject.Find("SpawnPoint3");
							if (52976 - 557100 == -504123)
							{
								continue;
							}
							if (this.$mSpawnPoint3$36950)
							{
								if (207513 - 136104 != 71409)
								{
									continue;
								}
								this.$self_$36964.LrhcB3KRbKm = 10;
								if (294720 - 548579 == -253858)
								{
									continue;
								}
								this.$self_$36964.B1kcBbakxdR = Time.time;
								if (15796 - 6693 == 9104)
								{
									continue;
								}
								if (this.$self_$36964.xP4cB0Qy2Li)
								{
									if (194527 - 296105 != -101578)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$36964.xP4cB0Qy2Li, this.$self_$36964.pW0cBBScBYI.transform.position, this.$self_$36964.pW0cBBScBYI.transform.rotation);
									if (237784 - 355705 != -117921)
									{
										continue;
									}
								}
								this.$self_$36964.pW0cBBScBYI.transform.position = this.$mSpawnPoint3$36950.transform.position;
								if (136759 - 583940 == -447180)
								{
									continue;
								}
								this.$self_$36964.pW0cBBScBYI.transform.rotation = this.$mSpawnPoint3$36950.transform.rotation;
								if (72893 - 505175 == -432281)
								{
									continue;
								}
								if (this.$self_$36964.xP4cB0Qy2Li)
								{
									if (122648 - 477545 == -354896)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$36964.xP4cB0Qy2Li, this.$self_$36964.pW0cBBScBYI.transform.position, this.$self_$36964.pW0cBBScBYI.transform.rotation);
									if (73252 - 41666 == 31587)
									{
										continue;
									}
								}
								Chat.SubmitChat("Reggu", Language.getMessage("M100_GameTutorial", 6), eChatType.npc, eChatMode.area);
								if (203989 - 309304 != -105315)
								{
									continue;
								}
							}
						}
						else
						{
							this.$self_$36964.pW0cBBScBYI.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$self_$36964.pW0cBBScBYI.transform.position));
							if (77763 - 292445 != -214682)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 10)
					{
						if (120464 - 582929 == -462464)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$self_$36964.pW0cBBScBYI.transform.position));
						if (14352 - 125323 != -110971)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 11)
					{
						if (210460 - 159705 == 50756)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 2f)
						{
							if (117444 - 246445 != -129001)
							{
								continue;
							}
							this.$self_$36964.LrhcB3KRbKm = 12;
							if (45232 - 305386 == -260153)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (188828 - 181058 != 7770)
							{
								continue;
							}
							this.$self_$36964.MFecB4ldj2R.close();
							if (119770 - 502828 != -383058)
							{
								continue;
							}
							if (this.$self_$36964.TCLcBsTVlNu)
							{
								if (151219 - 166593 != -15374)
								{
									continue;
								}
								this.$self_$36964.TCLcBsTVlNu.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
								if (19274 - 454758 != -435484)
								{
									continue;
								}
							}
						}
					}
					else if (this.$$switch$6220$36947 == 12)
					{
						if (174521 - 41714 == 132808)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 0.5f)
						{
							if (4701 - 575773 != -571072)
							{
								continue;
							}
							this.$self_$36964.LrhcB3KRbKm = 13;
							if (66050 - 86865 != -20815)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (30709 - 460906 != -430197)
							{
								continue;
							}
							this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 8), eTalkType.friend);
							if (6388 - 438528 == -432139)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 13)
					{
						if (93628 - 504446 == -410817)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 5f)
						{
							if (152134 - 537586 != -385452)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_1808;
							}
							if (90180 - 223850 != -133670)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_1808;
							}
							if (236312 - 86170 == 150143)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 14;
						if (183238 - 256411 == -73172)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (37080 - 249600 == -212519)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.CrossFade("root");
						if (73212 - 9160 == 64053)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 9), eTalkType.friend);
						if (123861 - 369999 != -246138)
						{
							continue;
						}
						IL_1808:;
					}
					else if (this.$$switch$6220$36947 == 14)
					{
						if (212345 - 195742 != 16603)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 5f)
						{
							goto IL_3EF6;
						}
						if (158548 - 410733 == -252184)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > (float)1)
						{
							if (157816 - 214837 != -57021)
							{
								continue;
							}
							if (Input.GetKeyDown("mouse 0"))
							{
								if (56890 - 552627 != -495736)
								{
									goto IL_3EF6;
								}
								continue;
							}
						}
						goto IL_1D07;
						IL_3EF6:
						this.$self_$36964.LrhcB3KRbKm = 15;
						if (21168 - 292371 != -271203)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (39696 - 418563 != -378867)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 10), eTalkType.friend);
						if (96175 - 330690 == -234514)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 15)
					{
						if (149122 - 379748 != -230626)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 5f)
						{
							goto IL_4E79;
						}
						if (178240 - 536932 != -358692)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > (float)1)
						{
							if (75338 - 43252 == 32087)
							{
								continue;
							}
							if (Input.GetKeyDown("mouse 0"))
							{
								if (190036 - 417505 != -227468)
								{
									goto IL_4E79;
								}
								continue;
							}
						}
						goto IL_1D07;
						IL_4E79:
						this.$self_$36964.LrhcB3KRbKm = 16;
						if (243568 - 141266 == 102303)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (181085 - 350696 != -169611)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 11), eTalkType.friend);
						if (151174 - 104426 != 46748)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 16)
					{
						if (198321 - 103941 != 94380)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 5f)
						{
							if (108569 - 99081 == 9489)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_2CF0;
							}
							if (111358 - 94991 != 16367)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_2CF0;
							}
							if (272278 - 307723 == -35444)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 17;
						if (5191 - 104933 != -99742)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (162231 - 596515 != -434284)
						{
							continue;
						}
						this.$mStartCamera2$36951 = GameObject.Find("StartCamera2");
						if (245049 - 86345 != 158704)
						{
							continue;
						}
						if (this.$mStartCamera2$36951)
						{
							if (162794 - 310599 != -147805)
							{
								continue;
							}
							this.$self_$36964.P6KcBTO1K6U.enabled = false;
							if (16468 - 516952 == -500483)
							{
								continue;
							}
							this.$self_$36964.transform.position = this.$mStartCamera2$36951.transform.position;
							if (157859 - 536795 == -378935)
							{
								continue;
							}
							this.$self_$36964.transform.rotation = this.$mStartCamera2$36951.transform.rotation;
							if (296607 - 517552 != -220945)
							{
								continue;
							}
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 12), eTalkType.friend);
						if (253142 - 570093 == -316950)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.Play("nAttack");
						if (299226 - 135759 != 163467)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.wrapMode = WrapMode.Once;
						if (222693 - 583289 == -360595)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) == 0)
						{
							goto IL_492A;
						}
						if (188208 - 222292 != -34084)
						{
							continue;
						}
						if (this.$self_$36964.cast_vc)
						{
							if (232777 - 414927 == -182149)
							{
								continue;
							}
							this.$self_$36964.audio.PlayOneShot(this.$self_$36964.cast_vc);
							if (4677 - 495289 != -490611)
							{
								goto Block_327;
							}
							continue;
						}
						else
						{
							Debug.LogError("Cannot find cast voice");
							if (219442 - 200683 != 18760)
							{
								goto Block_521;
							}
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 17)
					{
						if (244708 - 393917 != -149209)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 3f)
						{
							if (153790 - 510776 != -356986)
							{
								continue;
							}
							this.$self_$36964.LrhcB3KRbKm = 18;
							if (93029 - 43712 != 49317)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (176067 - 481767 != -305700)
							{
								continue;
							}
							this.$self_$36964.FZrcBLWBytN = 1;
							if (132599 - 46523 != 86076)
							{
								continue;
							}
							this.$self_$36964.TCLcBsTVlNu.close();
							if (43370 - 231626 != -188256)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 18)
					{
						if (41984 - 50169 != -8185)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 19)
					{
						if (175395 - 98805 != 76590)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$self_$36964.pW0cBBScBYI.transform.position));
						if (164126 - 160322 == 3805)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 20)
					{
						if (260704 - 141131 == 119574)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 0.5f)
						{
							if (283630 - 338714 == -55083)
							{
								continue;
							}
							this.$self_$36964.LrhcB3KRbKm = 21;
							if (283139 - 143074 == 140066)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (259707 - 470407 != -210700)
							{
								continue;
							}
							this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 13), eTalkType.friend);
							if (25342 - 132241 != -106899)
							{
								continue;
							}
							this.$self_$36964.pW0cBBScBYI.animation.CrossFade("talk");
							if (275557 - 595421 == -319863)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) != 0)
							{
								if (294122 - 119476 != 174646)
								{
									continue;
								}
								if (this.$self_$36964.good_vc)
								{
									if (66469 - 80910 != -14441)
									{
										continue;
									}
									this.$self_$36964.audio.PlayOneShot(this.$self_$36964.good_vc);
									if (191848 - 210077 != -18229)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find good voice");
									if (247765 - 452182 == -204416)
									{
										continue;
									}
								}
							}
						}
					}
					else if (this.$$switch$6220$36947 == 21)
					{
						if (228233 - 285830 != -57597)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 5f)
						{
							if (15067 - 516330 != -501263)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_4B7;
							}
							if (27271 - 452332 == -425060)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_4B7;
							}
							if (147708 - 161123 == -13414)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 22;
						if (84474 - 256538 == -172063)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (90217 - 398061 != -307844)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 14), eTalkType.friend);
						if (50837 - 311289 == -260451)
						{
							continue;
						}
						IL_4B7:;
					}
					else if (this.$$switch$6220$36947 == 22)
					{
						if (98223 - 273736 != -175513)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 5f)
						{
							if (97184 - 320435 == -223250)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_21C9;
							}
							if (119514 - 164829 != -45315)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_21C9;
							}
							if (242447 - 174364 == 68084)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 23;
						if (240067 - 56542 != 183525)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (84089 - 202863 == -118773)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 15), eTalkType.friend);
						if (151114 - 476353 != -325239)
						{
							continue;
						}
						IL_21C9:;
					}
					else if (this.$$switch$6220$36947 == 23)
					{
						if (122232 - 273199 != -150967)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 5f)
						{
							goto IL_5CA2;
						}
						if (240687 - 497696 == -257008)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > (float)1)
						{
							if (210833 - 243839 == -33005)
							{
								continue;
							}
							if (Input.GetKeyDown("mouse 0"))
							{
								if (204788 - 206029 != -1240)
								{
									goto IL_5CA2;
								}
								continue;
							}
						}
						goto IL_1D07;
						IL_5CA2:
						this.$self_$36964.LrhcB3KRbKm = 24;
						if (35887 - 425016 == -389128)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (201825 - 183290 != 18535)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.CrossFade("root");
						if (51136 - 178484 == -127347)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 16), eTalkType.friend);
						if (18596 - 143230 != -124634)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 24)
					{
						if (185866 - 229832 == -43965)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 5f)
						{
							if (43616 - 231611 != -187995)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_26AC;
							}
							if (167463 - 249927 == -82463)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_26AC;
							}
							if (65808 - 302805 != -236997)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 25;
						if (78039 - 137584 != -59545)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (1714 - 591577 == -589862)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 17), eTalkType.friend);
						if (108938 - 561387 == -452448)
						{
							continue;
						}
						IL_26AC:;
					}
					else if (this.$$switch$6220$36947 == 25)
					{
						if (294012 - 22167 == 271846)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 5f)
						{
							goto IL_4EC7;
						}
						if (266684 - 132701 != 133983)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > (float)1)
						{
							if (166364 - 596209 != -429845)
							{
								continue;
							}
							if (Input.GetKeyDown("mouse 0"))
							{
								if (180122 - 384036 != -203913)
								{
									goto IL_4EC7;
								}
								continue;
							}
						}
						goto IL_1D07;
						IL_4EC7:
						this.$self_$36964.LrhcB3KRbKm = 26;
						if (111766 - 237525 == -125758)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (205182 - 29238 == 175945)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 18), eTalkType.friend);
						if (197011 - 412517 != -215506)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 26)
					{
						if (209159 - 573576 == -364416)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 5f)
						{
							goto IL_2760;
						}
						if (265383 - 331185 == -65801)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > (float)1)
						{
							if (181375 - 504102 != -322727)
							{
								continue;
							}
							if (Input.GetKeyDown("mouse 0"))
							{
								if (275966 - 153427 != 122540)
								{
									goto IL_2760;
								}
								continue;
							}
						}
						goto IL_1D07;
						IL_2760:
						this.$self_$36964.LrhcB3KRbKm = 27;
						if (133686 - 275774 == -142087)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (16530 - 515698 != -499168)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.CrossFade("talk");
						if (86254 - 372943 != -286689)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 19), eTalkType.friend);
						if (276850 - 264550 == 12301)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 27)
					{
						if (276671 - 580146 == -303474)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 5f)
						{
							goto IL_556A;
						}
						if (123976 - 140128 != -16152)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > (float)1)
						{
							if (47283 - 57249 != -9966)
							{
								continue;
							}
							if (Input.GetKeyDown("mouse 0"))
							{
								if (215855 - 207933 != 7923)
								{
									goto IL_556A;
								}
								continue;
							}
						}
						goto IL_1D07;
						IL_556A:
						this.$self_$36964.LrhcB3KRbKm = 28;
						if (198390 - 305453 == -107062)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (155785 - 275866 == -120080)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 20), eTalkType.friend);
						if (6080 - 596673 == -590592)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 28)
					{
						if (54249 - 394399 == -340149)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 5f)
						{
							goto IL_232C;
						}
						if (90388 - 125032 != -34644)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > (float)1)
						{
							if (225835 - 307012 != -81177)
							{
								continue;
							}
							if (Input.GetKeyDown("mouse 0"))
							{
								if (227864 - 428818 != -200953)
								{
									goto IL_232C;
								}
								continue;
							}
						}
						goto IL_1D07;
						IL_232C:
						this.$self_$36964.LrhcB3KRbKm = 29;
						if (122692 - 87621 != 35071)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (217111 - 162470 == 54642)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.CrossFade("root");
						if (111474 - 451941 == -340466)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.wrapMode = WrapMode.Loop;
						if (201490 - 571888 == -370397)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.close();
						if (271567 - 484645 != -213078)
						{
							continue;
						}
						this.$self_$36964.FZrcBLWBytN = 1;
						if (53224 - 104418 == -51193)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 29)
					{
						if (241668 - 439447 != -197779)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 30)
					{
						if (264733 - 539432 != -274699)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$self_$36964.pW0cBBScBYI.transform.position));
						if (121483 - 431942 != -310459)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 31)
					{
						if (193794 - 339344 == -145549)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 0.5f)
						{
							if (11061 - 197112 == -186050)
							{
								continue;
							}
							this.$self_$36964.LrhcB3KRbKm = 32;
							if (152833 - 18849 != 133984)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (228876 - 54142 != 174734)
							{
								continue;
							}
							this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 21), eTalkType.friend);
							if (132236 - 459672 == -327435)
							{
								continue;
							}
							this.$self_$36964.pW0cBBScBYI.animation.Play("talk");
							if (75916 - 330539 == -254622)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 32)
					{
						if (234481 - 469375 == -234893)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 5f)
						{
							goto IL_28BC;
						}
						if (182121 - 549215 == -367093)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > (float)1)
						{
							if (147797 - 407383 == -259585)
							{
								continue;
							}
							if (Input.GetKeyDown("mouse 0"))
							{
								if (283785 - 285946 != -2161)
								{
									continue;
								}
								goto IL_28BC;
							}
						}
						goto IL_1D07;
						IL_28BC:
						this.$self_$36964.LrhcB3KRbKm = 33;
						if (139544 - 473914 == -334369)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (258670 - 24021 != 234649)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 22), eTalkType.friend);
						if (68089 - 143574 == -75484)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 33)
					{
						if (196490 - 187228 != 9262)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 5f)
						{
							if (274656 - 46209 == 228448)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_C36;
							}
							if (204895 - 433356 == -228460)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_C36;
							}
							if (121279 - 20028 == 101252)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 34;
						if (94100 - 506697 != -412597)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (271412 - 494227 != -222815)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.CrossFade("root");
						if (131467 - 185436 != -53969)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 23), eTalkType.friend);
						if (123077 - 236172 == -113094)
						{
							continue;
						}
						IL_C36:;
					}
					else if (this.$$switch$6220$36947 == 34)
					{
						if (237255 - 351841 != -114586)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 5f)
						{
							goto IL_3730;
						}
						if (191888 - 454754 != -262866)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > (float)1)
						{
							if (245364 - 315960 != -70596)
							{
								continue;
							}
							if (Input.GetKeyDown("mouse 0"))
							{
								if (78190 - 355026 != -276835)
								{
									goto IL_3730;
								}
								continue;
							}
						}
						goto IL_1D07;
						IL_3730:
						this.$self_$36964.LrhcB3KRbKm = 35;
						if (187204 - 51385 == 135820)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (73035 - 217451 == -144415)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 24), eTalkType.friend);
						if (169359 - 133394 == 35966)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 35)
					{
						if (121727 - 521218 == -399490)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 5f)
						{
							goto IL_293E;
						}
						if (57008 - 397091 != -340083)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > (float)1)
						{
							if (87977 - 205300 == -117322)
							{
								continue;
							}
							if (Input.GetKeyDown("mouse 0"))
							{
								if (228655 - 39517 != 189138)
								{
									continue;
								}
								goto IL_293E;
							}
						}
						goto IL_1D07;
						IL_293E:
						this.$self_$36964.LrhcB3KRbKm = 36;
						if (189170 - 351996 != -162826)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (17032 - 464514 == -447481)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 25), eTalkType.friend);
						if (115304 - 102280 == 13025)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 36)
					{
						if (53471 - 252082 == -198610)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 5f)
						{
							if (106629 - 298216 == -191586)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_1A15;
							}
							if (90053 - 589984 == -499930)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_1A15;
							}
							if (136606 - 592103 == -455496)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 37;
						if (257018 - 146991 != 110027)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (222865 - 562519 != -339654)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.CrossFade("nAttack");
						if (112683 - 413984 == -301300)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.wrapMode = WrapMode.Once;
						if (77102 - 73443 == 3660)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (40877 - 132677 != -91800)
							{
								continue;
							}
							if (this.$self_$36964.cast_vc)
							{
								if (23019 - 145532 != -122513)
								{
									continue;
								}
								this.$self_$36964.audio.PlayOneShot(this.$self_$36964.cast_vc);
								if (186856 - 396802 != -209946)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find cast voice");
								if (74827 - 138212 == -63384)
								{
									continue;
								}
							}
						}
						this.$mStartCamera3$36954 = GameObject.Find("StartCamera3");
						if (238744 - 87480 != 151264)
						{
							continue;
						}
						if (this.$mStartCamera3$36954)
						{
							if (201791 - 420348 != -218557)
							{
								continue;
							}
							this.$self_$36964.P6KcBTO1K6U.enabled = false;
							if (115202 - 221076 == -105873)
							{
								continue;
							}
							this.$self_$36964.transform.position = this.$mStartCamera3$36954.transform.position;
							if (221299 - 404446 == -183146)
							{
								continue;
							}
							this.$self_$36964.transform.rotation = this.$mStartCamera3$36954.transform.rotation;
							if (95353 - 189348 == -93994)
							{
								continue;
							}
						}
						IL_1A15:;
					}
					else if (this.$$switch$6220$36947 == 37)
					{
						if (124358 - 476185 == -351826)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 0.5f)
						{
							if (262058 - 150300 != 111758)
							{
								continue;
							}
							this.$mLittleFatBugPos$36955 = GameObject.Find("SpawnPoint1");
							if (171473 - 412577 != -241104)
							{
								continue;
							}
							if (this.$mLittleFatBugPos$36955)
							{
								if (116823 - 241082 != -124259)
								{
									continue;
								}
								this.$self_$36964.createActor("LittleFatBug_w", 6, this.$mLittleFatBugPos$36955.transform.position, this.$mLittleFatBugPos$36955.transform.forward);
								if (131807 - 341837 != -210030)
								{
									continue;
								}
								if (this.$self_$36964.xP4cB0Qy2Li)
								{
									if (222757 - 2413 == 220345)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$36964.xP4cB0Qy2Li, this.$mLittleFatBugPos$36955.transform.position, this.$mLittleFatBugPos$36955.transform.rotation);
									if (98264 - 215756 == -117491)
									{
										continue;
									}
								}
							}
							else
							{
								Debug.LogError("Cannot find SpawnPoint1");
								if (169005 - 44915 == 124091)
								{
									continue;
								}
							}
							this.$self_$36964.LrhcB3KRbKm = 38;
							if (28798 - 128297 == -99498)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (128708 - 553641 == -424932)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 38)
					{
						if (51842 - 539526 == -487683)
						{
							continue;
						}
						this.$self_$36964.LrhcB3KRbKm = 39;
						if (200634 - 258791 != -58157)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (261637 - 524525 == -262887)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 26), eTalkType.friend);
						if (48087 - 552469 != -504382)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (143265 - 48994 == 94272)
							{
								continue;
							}
							if (this.$self_$36964.laugh_vc)
							{
								if (30703 - 241159 == -210455)
								{
									continue;
								}
								this.$self_$36964.audio.PlayOneShot(this.$self_$36964.laugh_vc);
								if (294792 - 282108 == 12685)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find laugh voice");
								if (168283 - 17426 == 150858)
								{
									continue;
								}
							}
						}
					}
					else if (this.$$switch$6220$36947 == 39)
					{
						if (38686 - 298906 != -260220)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 0.5f)
						{
							if (248435 - 551854 == -303418)
							{
								continue;
							}
							this.$self_$36964.pW0cBBScBYI.animation.CrossFade("root");
							if (256661 - 568273 != -311612)
							{
								continue;
							}
							this.$self_$36964.pW0cBBScBYI.animation.wrapMode = WrapMode.Loop;
							if (295653 - 10229 != 285424)
							{
								continue;
							}
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 5f)
						{
							if (63055 - 361543 == -298487)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_3D65;
							}
							if (111937 - 68209 == 43729)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_3D65;
							}
							if (129084 - 58597 != 70487)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 40;
						if (95522 - 21096 != 74426)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (157589 - 478594 == -321004)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.close();
						if (77821 - 24226 != 53595)
						{
							continue;
						}
						IL_3D65:;
					}
					else if (this.$$switch$6220$36947 == 40)
					{
						if (178420 - 358712 == -180291)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 1f)
						{
							if (256063 - 151214 == 104850)
							{
								continue;
							}
							this.$self_$36964.pW0cBBScBYI.animation.CrossFade("root");
							if (20611 - 460895 != -440284)
							{
								continue;
							}
							this.$self_$36964.pW0cBBScBYI.animation.wrapMode = WrapMode.Loop;
							if (225454 - 238728 != -13274)
							{
								continue;
							}
							this.$self_$36964.LrhcB3KRbKm = 41;
							if (224059 - 234452 != -10393)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (200288 - 302343 != -102055)
							{
								continue;
							}
							this.$self_$36964.MFecB4ldj2R.enabled = true;
							if (32878 - 586708 != -553830)
							{
								continue;
							}
							this.$self_$36964.P6KcBTO1K6U.enabled = true;
							if (73104 - 190972 != -117868)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (295336 - 481879 == -186542)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 41)
					{
						if (7338 - 489115 == -481776)
						{
							continue;
						}
						if (this.$self_$36964.pW0cBBScBYI)
						{
							if (223065 - 379063 != -155998)
							{
								continue;
							}
							this.$self_$36964.pW0cBBScBYI.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$self_$36964.pW0cBBScBYI.transform.position));
							if (193498 - 489716 != -296218)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 42)
					{
						if (1149 - 202810 != -201661)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 0.5f)
						{
							if (97386 - 327100 == -229713)
							{
								continue;
							}
							this.$self_$36964.LrhcB3KRbKm = 43;
							if (180743 - 64648 != 116095)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (41856 - 239665 == -197808)
							{
								continue;
							}
							this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 27), eTalkType.friend);
							if (10621 - 352736 != -342115)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) != 0)
							{
								if (185123 - 55886 != 129237)
								{
									continue;
								}
								if (this.$self_$36964.good_vc)
								{
									if (103444 - 5702 != 97742)
									{
										continue;
									}
									this.$self_$36964.audio.PlayOneShot(this.$self_$36964.good_vc);
									if (201298 - 523695 != -322397)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find good voice");
									if (260777 - 159826 != 100951)
									{
										continue;
									}
								}
							}
						}
					}
					else if (this.$$switch$6220$36947 == 43)
					{
						if (96266 - 421464 == -325197)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 5f)
						{
							goto IL_2618;
						}
						if (111631 - 78199 == 33433)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > (float)1)
						{
							if (35933 - 194980 == -159046)
							{
								continue;
							}
							if (Input.GetKeyDown("mouse 0"))
							{
								if (39351 - 265867 != -226516)
								{
									continue;
								}
								goto IL_2618;
							}
						}
						goto IL_1D07;
						IL_2618:
						this.$self_$36964.LrhcB3KRbKm = 44;
						if (146532 - 597312 != -450780)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (123372 - 164608 != -41236)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 28), eTalkType.friend);
						if (266407 - 419875 == -153467)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 44)
					{
						if (191404 - 557612 == -366207)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 5f)
						{
							if (142641 - 293450 == -150808)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_1663;
							}
							if (143613 - 450748 != -307135)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_1663;
							}
							if (112073 - 159199 == -47125)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 45;
						if (58412 - 281551 == -223138)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (242882 - 140646 == 102237)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 29), eTalkType.friend);
						if (94618 - 332648 == -238029)
						{
							continue;
						}
						IL_1663:;
					}
					else if (this.$$switch$6220$36947 == 45)
					{
						if (90293 - 566142 != -475849)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 5f)
						{
							goto IL_22A1;
						}
						if (36865 - 123593 == -86727)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > (float)1)
						{
							if (142714 - 479918 != -337204)
							{
								continue;
							}
							if (Input.GetKeyDown("mouse 0"))
							{
								if (273048 - 494006 != -220957)
								{
									goto IL_22A1;
								}
								continue;
							}
						}
						goto IL_1D07;
						IL_22A1:
						this.$self_$36964.LrhcB3KRbKm = 46;
						if (79068 - 395067 == -315998)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (84440 - 480641 == -396200)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 30), eTalkType.friend);
						if (38413 - 65137 == -26723)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 46)
					{
						if (210034 - 410352 == -200317)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 5f)
						{
							goto IL_1FED;
						}
						if (145030 - 65742 != 79288)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > (float)1)
						{
							if (173552 - 592356 == -418803)
							{
								continue;
							}
							if (Input.GetKeyDown("mouse 0"))
							{
								if (38193 - 291489 != -253296)
								{
									continue;
								}
								goto IL_1FED;
							}
						}
						goto IL_1D07;
						IL_1FED:
						this.$self_$36964.LrhcB3KRbKm = 47;
						if (166973 - 46629 == 120345)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (233232 - 351780 != -118548)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.close();
						if (79837 - 413073 != -333236)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 47)
					{
						if (235082 - 326551 != -91469)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 0.5f)
						{
							if (266836 - 597936 != -331100)
							{
								continue;
							}
							this.$self_$36964.LrhcB3KRbKm = 48;
							if (265488 - 362085 != -96597)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (58632 - 430161 != -371529)
							{
								continue;
							}
							this.$self_$36964.MFecB4ldj2R.enabled = true;
							if (247061 - 384035 != -136974)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 48)
					{
						if (67527 - 265400 == -197872)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 0.5f)
						{
							if (133503 - 422273 == -288769)
							{
								continue;
							}
							this.$self_$36964.LrhcB3KRbKm = 49;
							if (108569 - 183202 == -74632)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (234493 - 446474 != -211981)
							{
								continue;
							}
							this.$self_$36964.pW0cBBScBYI.animation.CrossFade("nAttack");
							if (101196 - 187928 != -86732)
							{
								continue;
							}
							this.$self_$36964.pW0cBBScBYI.animation.wrapMode = WrapMode.Once;
							if (19817 - 344208 == -324390)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) != 0)
							{
								if (173126 - 474558 != -301432)
								{
									continue;
								}
								if (this.$self_$36964.cast_vc)
								{
									if (189210 - 496671 != -307461)
									{
										continue;
									}
									this.$self_$36964.audio.PlayOneShot(this.$self_$36964.cast_vc);
									if (119936 - 251041 != -131105)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find cast voice");
									if (52718 - 336494 != -283776)
									{
										continue;
									}
								}
							}
						}
					}
					else if (this.$$switch$6220$36947 == 49)
					{
						if (116600 - 401685 == -285084)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 1f)
						{
							if (255129 - 168503 != 86626)
							{
								continue;
							}
							this.$self_$36964.LrhcB3KRbKm = 50;
							if (192951 - 493904 != -300953)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (53808 - 449883 != -396075)
							{
								continue;
							}
							Game.mGameState = eGameState.Hold;
							if (210027 - 473661 != -263634)
							{
								continue;
							}
							this.$self_$36964.pW0cBBScBYI.animation.CrossFade("root");
							if (36223 - 237838 != -201615)
							{
								continue;
							}
							this.$self_$36964.pW0cBBScBYI.animation.wrapMode = WrapMode.Loop;
							if (299940 - 396747 == -96806)
							{
								continue;
							}
							this.$self_$36964.AddTemporarySkill();
							if (270658 - 303200 == -32541)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 50)
					{
						if (96315 - 10420 == 85896)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR < 1f)
						{
							if (151339 - 189911 != -38571)
							{
								goto Block_199;
							}
							continue;
						}
						else if (Time.time - this.$self_$36964.B1kcBbakxdR < 2f)
						{
							if (139704 - 496364 != -356660)
							{
								continue;
							}
							this.$self_$36964.MFecB4ldj2R.newNoticeBar("All Combo Attack has been released");
							if (220641 - 292479 != -71838)
							{
								continue;
							}
						}
						else if (Time.time - this.$self_$36964.B1kcBbakxdR < 3f)
						{
							if (102317 - 498205 != -395888)
							{
								continue;
							}
							this.$self_$36964.MFecB4ldj2R.newNoticeBar("Charge Attack is now available!");
							if (266208 - 471028 != -204820)
							{
								continue;
							}
						}
						else if (Time.time - this.$self_$36964.B1kcBbakxdR < 3.2f)
						{
							if (98024 - 526358 != -428334)
							{
								continue;
							}
							this.$self_$36964.MFecB4ldj2R.newNoticeBar("Skill Move is now available!");
							if (146175 - 2724 != 143451)
							{
								continue;
							}
						}
						else
						{
							this.$self_$36964.LrhcB3KRbKm = 505;
							if (27257 - 318758 == -291500)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (82637 - 157645 != -75008)
							{
								continue;
							}
							this.$self_$36964.FZrcBLWBytN = 1;
							if (190441 - 466101 != -275660)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 505)
					{
						if (244190 - 239982 != 4208)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 506)
					{
						if (236389 - 58079 == 178311)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 51)
					{
						if (139319 - 298363 == -159043)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 0.5f)
						{
							if (221040 - 524207 == -303166)
							{
								continue;
							}
							this.$self_$36964.LrhcB3KRbKm = 52;
							if (197043 - 554800 != -357757)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (111387 - 490897 == -379509)
							{
								continue;
							}
							this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 31), eTalkType.friend);
							if (292458 - 486969 != -194511)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 52)
					{
						if (272479 - 349396 != -76917)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 5f)
						{
							if (5157 - 478516 == -473358)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_4C3E;
							}
							if (293561 - 474478 != -180917)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_4C3E;
							}
							if (29720 - 557836 == -528115)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 53;
						if (245737 - 105766 != 139971)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (14095 - 178626 != -164531)
						{
							continue;
						}
						this.$mStartCamera4$36956 = GameObject.Find("StartCamera3");
						if (82395 - 269879 == -187483)
						{
							continue;
						}
						if (this.$mStartCamera4$36956)
						{
							if (198914 - 343749 != -144835)
							{
								continue;
							}
							this.$self_$36964.P6KcBTO1K6U.enabled = false;
							if (237010 - 334471 != -97461)
							{
								continue;
							}
							this.$self_$36964.transform.position = this.$mStartCamera4$36956.transform.position;
							if (51111 - 67824 == -16712)
							{
								continue;
							}
							this.$self_$36964.transform.rotation = this.$mStartCamera4$36956.transform.rotation;
							if (132893 - 427188 == -294294)
							{
								continue;
							}
						}
						this.$self_$36964.pW0cBBScBYI.animation.CrossFade("nAttack");
						if (64251 - 265187 == -200935)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.wrapMode = WrapMode.Once;
						if (166453 - 56262 != 110191)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (182301 - 166553 == 15749)
							{
								continue;
							}
							if (this.$self_$36964.cast_vc)
							{
								if (118067 - 292388 == -174320)
								{
									continue;
								}
								this.$self_$36964.audio.PlayOneShot(this.$self_$36964.cast_vc);
								if (31129 - 291882 != -260753)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find cast voice");
								if (54311 - 427562 == -373250)
								{
									continue;
								}
							}
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 32), eTalkType.friend);
						if (280217 - 12571 != 267646)
						{
							continue;
						}
						IL_4C3E:;
					}
					else if (this.$$switch$6220$36947 == 53)
					{
						if (252913 - 479762 != -226849)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 0.5f)
						{
							if (246936 - 323833 == -76896)
							{
								continue;
							}
							this.$self_$36964.LrhcB3KRbKm = 54;
							if (123458 - 290589 != -167131)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (50500 - 328568 != -278068)
							{
								continue;
							}
							this.$mFatBugPos$36957 = GameObject.Find("SpawnPoint1");
							if (108973 - 470597 == -361623)
							{
								continue;
							}
							if (this.$mFatBugPos$36957)
							{
								if (3435 - 419374 != -415939)
								{
									continue;
								}
								this.$self_$36964.createActor("FatBug_g", 6, this.$mFatBugPos$36957.transform.position, this.$mFatBugPos$36957.transform.forward);
								if (128229 - 67323 == 60907)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$36964.xP4cB0Qy2Li, this.$mFatBugPos$36957.transform.position, this.$mFatBugPos$36957.transform.rotation);
								if (272396 - 537454 != -265058)
								{
									continue;
								}
							}
							this.$self_$36964.audio.clip = this.$self_$36964.music_battle1;
							if (35215 - 283895 == -248679)
							{
								continue;
							}
							this.$self_$36964.audio.loop = true;
							if (250172 - 403362 == -153189)
							{
								continue;
							}
							this.$self_$36964.audio.Play();
							if (155318 - 316557 != -161239)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 54)
					{
						if (92486 - 310707 != -218221)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 0.5f)
						{
							if (191701 - 418582 != -226881)
							{
								continue;
							}
							this.$self_$36964.pW0cBBScBYI.animation.CrossFade("root");
							if (69801 - 129464 != -59663)
							{
								continue;
							}
							this.$self_$36964.pW0cBBScBYI.animation.wrapMode = WrapMode.Loop;
							if (237743 - 269371 == -31627)
							{
								continue;
							}
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR <= 2f)
						{
							if (131018 - 211379 != -80361)
							{
								continue;
							}
							if (Time.time - this.$self_$36964.B1kcBbakxdR <= (float)1)
							{
								goto IL_3026;
							}
							if (22832 - 52263 == -29430)
							{
								continue;
							}
							if (!Input.GetKeyDown("mouse 0"))
							{
								goto IL_3026;
							}
							if (15574 - 451968 != -436394)
							{
								continue;
							}
						}
						this.$self_$36964.LrhcB3KRbKm = 55;
						if (96323 - 31005 != 65318)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (39434 - 528477 == -489042)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.CrossFade("root");
						if (58483 - 84729 == -26245)
						{
							continue;
						}
						this.$self_$36964.pW0cBBScBYI.animation.wrapMode = WrapMode.Loop;
						if (76407 - 184340 == -107932)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 33), eTalkType.friend);
						if (271322 - 144146 == 127177)
						{
							continue;
						}
						IL_3026:;
					}
					else if (this.$$switch$6220$36947 == 55)
					{
						if (14611 - 487797 == -473185)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 2f)
						{
							goto IL_4687;
						}
						if (80820 - 322179 != -241359)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > (float)1)
						{
							if (43801 - 516299 == -472497)
							{
								continue;
							}
							if (Input.GetKeyDown("mouse 0"))
							{
								if (63577 - 54686 != 8891)
								{
									continue;
								}
								goto IL_4687;
							}
						}
						goto IL_1D07;
						IL_4687:
						this.$self_$36964.LrhcB3KRbKm = 59;
						if (181719 - 396283 != -214564)
						{
							continue;
						}
						this.$self_$36964.B1kcBbakxdR = Time.time;
						if (60659 - 78666 == -18006)
						{
							continue;
						}
						this.$self_$36964.MFecB4ldj2R.enabled = true;
						if (78547 - 251893 == -173345)
						{
							continue;
						}
						this.$self_$36964.TCLcBsTVlNu.close();
						if (266201 - 356676 != -90475)
						{
							continue;
						}
					}
					else if (this.$$switch$6220$36947 == 59)
					{
						if (83505 - 529565 == -446059)
						{
							continue;
						}
						if (Time.time - this.$self_$36964.B1kcBbakxdR > 1f)
						{
							if (53414 - 288284 == -234869)
							{
								continue;
							}
							this.$self_$36964.LrhcB3KRbKm = 60;
							if (273820 - 226599 == 47222)
							{
								continue;
							}
							this.$self_$36964.B1kcBbakxdR = Time.time;
							if (16418 - 409485 == -393066)
							{
								continue;
							}
							this.$self_$36964.P6KcBTO1K6U.enabled = true;
							if (127855 - 279735 != -151880)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (86661 - 578435 == -491773)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 60)
					{
						if (169096 - 162029 == 7068)
						{
							continue;
						}
						if (this.$self_$36964.pW0cBBScBYI)
						{
							if (213961 - 281565 != -67604)
							{
								continue;
							}
							this.$self_$36964.pW0cBBScBYI.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$self_$36964.pW0cBBScBYI.transform.position));
							if (152022 - 342809 == -190786)
							{
								continue;
							}
						}
					}
					else if (this.$$switch$6220$36947 == 61)
					{
						if (33172 - 194443 != -161271)
						{
							continue;
						}
					}
					IL_1D07:
					this.YieldDefault(1);
					if (185281 - 580800 != -395519)
					{
						continue;
					}
					goto IL_5F61;
					IL_2CF0:
					IL_12DC:
					goto IL_1D07;
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_199:
				goto IL_5F61;
				Block_327:
				Block_521:
				IL_492A:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_5EB5:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_5F61:
				return false;
			}

			// Token: 0x06006DF7 RID: 28151 RVA: 0x00F4A190 File Offset: 0x00F48390
			internal static bool qslBcipmsNQRZQD4rgDj()
			{
				return true;
			}

			// Token: 0x06006DF8 RID: 28152 RVA: 0x00F4A194 File Offset: 0x00F48394
			internal static bool j80Cvkpm9fNRqBoI7egs()
			{
				return false;
			}

			// Token: 0x04007590 RID: 30096
			internal int $$switch$6220$36947;

			// Token: 0x04007591 RID: 30097
			internal GameObject $mSpawnPoint1$36948;

			// Token: 0x04007592 RID: 30098
			internal GameObject $mSpawnPoint2$36949;

			// Token: 0x04007593 RID: 30099
			internal GameObject $mSpawnPoint3$36950;

			// Token: 0x04007594 RID: 30100
			internal GameObject $mStartCamera2$36951;

			// Token: 0x04007595 RID: 30101
			internal int $t$36952;

			// Token: 0x04007596 RID: 30102
			internal GameObject $mTargetSpawnPos$36953;

			// Token: 0x04007597 RID: 30103
			internal GameObject $mStartCamera3$36954;

			// Token: 0x04007598 RID: 30104
			internal GameObject $mLittleFatBugPos$36955;

			// Token: 0x04007599 RID: 30105
			internal GameObject $mStartCamera4$36956;

			// Token: 0x0400759A RID: 30106
			internal GameObject $mFatBugPos$36957;

			// Token: 0x0400759B RID: 30107
			internal float $$14132$36958;

			// Token: 0x0400759C RID: 30108
			internal Vector3 $$14133$36959;

			// Token: 0x0400759D RID: 30109
			internal float $$14134$36960;

			// Token: 0x0400759E RID: 30110
			internal Vector3 $$14135$36961;

			// Token: 0x0400759F RID: 30111
			internal float $$14136$36962;

			// Token: 0x040075A0 RID: 30112
			internal Vector3 $$14137$36963;

			// Token: 0x040075A1 RID: 30113
			internal M100_GameTutorial1 $self_$36964;
		}
	}

	// Token: 0x020012A5 RID: 4773
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndTutorialEvent$36966 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006DF9 RID: 28153 RVA: 0x00F4A198 File Offset: 0x00F48398
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndTutorialEvent$36966(M100_GameTutorial1 self_)
		{
			if (118397 - 382713 != -264315)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (40606 - 11931 != 28676)
				{
					base..ctor();
					if (30208 - 36883 == -6675)
					{
						this.$self_$36972 = self_;
						if (205036 - 333900 == -128864)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006DFA RID: 28154 RVA: 0x00F4A230 File Offset: 0x00F48430
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial1.$EndTutorialEvent$36966.$(this.$self_$36972);
		}

		// Token: 0x06006DFB RID: 28155 RVA: 0x00F4A240 File Offset: 0x00F48440
		internal static bool AJNB8apm1F2KutoFnB9k()
		{
			return true;
		}

		// Token: 0x06006DFC RID: 28156 RVA: 0x00F4A244 File Offset: 0x00F48444
		internal static bool pPqe0kpm4bZkkUWCaH9J()
		{
			return false;
		}

		// Token: 0x040075A2 RID: 30114
		internal M100_GameTutorial1 $self_$36972;

		// Token: 0x020012A6 RID: 4774
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006DFD RID: 28157 RVA: 0x00F4A248 File Offset: 0x00F48448
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial1 self_)
			{
				if (44963 - 574419 != -529455)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (55891 - 589213 != -533321)
					{
						base..ctor();
						if (197124 - 24230 == 172894)
						{
							this.$self_$36971 = self_;
							if (260050 - 450128 == -190078)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006DFE RID: 28158 RVA: 0x00F4A2E0 File Offset: 0x00F484E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (40812 - 530312 != -489500)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_935;
					case 1:
						goto IL_955;
					case 2:
						this.$mGameGui$36967 = (GameGui)this.$self_$36971.GetComponent(typeof(GameGui));
						if (148639 - 163584 == -14944)
						{
							continue;
						}
						if (!this.$mGameGui$36967)
						{
							goto IL_10B;
						}
						if (299456 - 125021 == 174436)
						{
							continue;
						}
						this.$mGameGui$36967.close();
						if (4930 - 413763 != -408832)
						{
							goto Block_61;
						}
						continue;
					case 3:
						this.$self_$36971.SendMessage("fadeOut");
						if (11967 - 390568 != -378600)
						{
							goto Block_11;
						}
						continue;
					case 4:
						this.$mPlayer$36968 = Game.mPlayer;
						if (80297 - 591430 == -511132)
						{
							continue;
						}
						this.$mStartPoint$36969 = GameObject.Find("StartPoint1");
						if (222672 - 490234 == -267561)
						{
							continue;
						}
						if (this.$mPlayer$36968)
						{
							if (70146 - 360732 != -290586)
							{
								continue;
							}
							if (this.$mStartPoint$36969)
							{
								if (19854 - 579104 == -559249)
								{
									continue;
								}
								this.$mPlayer$36968.transform.position = this.$mStartPoint$36969.transform.position;
								if (195117 - 146644 == 48474)
								{
									continue;
								}
								this.$mPlayer$36968.transform.rotation = this.$mStartPoint$36969.transform.rotation;
								if (193533 - 5613 == 187921)
								{
									continue;
								}
							}
						}
						if (this.$self_$36971.pW0cBBScBYI)
						{
							if (8916 - 344609 != -335693)
							{
								continue;
							}
							this.$self_$36971.pW0cBBScBYI.transform.position = new Vector3((float)0, (float)50, (float)26);
							if (273854 - 116686 != 157168)
							{
								continue;
							}
							this.$self_$36971.pW0cBBScBYI.transform.rotation = Quaternion.Euler((float)0, (float)180, (float)0);
							if (105376 - 118935 != -13559)
							{
								continue;
							}
						}
						this.$self_$36971.P6KcBTO1K6U.alignToObject("EndCamera1");
						if (53000 - 101483 == -48482)
						{
							continue;
						}
						this.$self_$36971.SendMessage("fadeIn");
						if (12793 - 579731 != -566938)
						{
							continue;
						}
						goto IL_40E;
					case 5:
						this.$mStoryTimer$36970 = 0f;
						if (81893 - 64499 != 17394)
						{
							continue;
						}
						if (!this.$self_$36971.TCLcBsTVlNu)
						{
							goto IL_D0;
						}
						if (143898 - 108754 == 35145)
						{
							continue;
						}
						this.$self_$36971.TCLcBsTVlNu.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
						if (201104 - 320020 != -118915)
						{
							goto Block_30;
						}
						continue;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (122162 - 68446 != 53716)
							{
								continue;
							}
							goto IL_677;
						}
						else
						{
							this.$self_$36971.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 34), eTalkType.friend);
							if (61611 - 399685 != -338074)
							{
								continue;
							}
							if (this.$self_$36971.pW0cBBScBYI)
							{
								if (195018 - 23700 == 171319)
								{
									continue;
								}
								this.$self_$36971.pW0cBBScBYI.animation.CrossFade("talk");
								if (192629 - 190508 != 2121)
								{
									continue;
								}
							}
							this.$mStoryTimer$36970 = Time.time + 2f;
							if (283630 - 196065 != 87565)
							{
								continue;
							}
							goto IL_82D;
						}
						break;
					case 7:
						break;
					case 8:
						break;
					case 9:
						goto IL_473;
					case 10:
						goto IL_473;
					case 11:
						goto IL_529;
					case 12:
						goto IL_529;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (132090 - 56554 != 75536)
							{
								continue;
							}
							goto IL_258;
						}
						else
						{
							Game.sendMissionEvent(1005, 0);
							if (199859 - 242909 != -43050)
							{
								continue;
							}
							this.YieldDefault(1);
							if (16759 - 587023 != -570263)
							{
								goto Block_51;
							}
							continue;
						}
						break;
					default:
						if (201964 - 46853 != 155112)
						{
							goto IL_935;
						}
						continue;
					}
					if (this.$mStoryTimer$36970 > Time.time)
					{
						if (41062 - 341515 == -300452)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_848;
						}
						if (297084 - 331096 != -34012)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (168793 - 275974 != -107181)
						{
							continue;
						}
						goto IL_792;
					}
					else
					{
						this.$self_$36971.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 35), eTalkType.friend);
						if (284977 - 96121 != 188856)
						{
							continue;
						}
						this.$mStoryTimer$36970 = Time.time + 3f;
						if (274786 - 243802 != 30984)
						{
							continue;
						}
						goto IL_44A;
					}
					IL_529:
					if (this.$mStoryTimer$36970 > Time.time)
					{
						if (130701 - 137152 == -6450)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_51C;
						}
						if (180713 - 424722 == -244008)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (226329 - 567072 != -340743)
						{
							continue;
						}
						goto IL_33A;
					}
					else
					{
						if (this.$self_$36971.pW0cBBScBYI)
						{
							if (173716 - 166627 != 7089)
							{
								continue;
							}
							this.$self_$36971.pW0cBBScBYI.animation.CrossFade("root");
							if (184806 - 559297 == -374490)
							{
								continue;
							}
						}
						this.$self_$36971.TCLcBsTVlNu.close();
						if (139177 - 281112 != -141934)
						{
							goto Block_57;
						}
						continue;
					}
					IL_473:
					if (this.$mStoryTimer$36970 > Time.time)
					{
						if (78292 - 169350 == -91057)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_466;
						}
						if (173863 - 410125 == -236261)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (9510 - 272247 != -262737)
						{
							continue;
						}
						goto IL_36E;
					}
					else
					{
						this.$self_$36971.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 36), eTalkType.friend);
						if (114708 - 310429 == -195720)
						{
							continue;
						}
						this.$mStoryTimer$36970 = Time.time + 3f;
						if (112067 - 107022 != 5045)
						{
							continue;
						}
						goto IL_500;
					}
					IL_935:
					Game.mGameState = eGameState.AllHold;
					if (253432 - 475919 == -222487)
					{
						Game.mStateTime = Time.time;
						if (23168 - 492413 != -469244)
						{
							goto Block_29;
						}
					}
				}
				IL_D0:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_10B:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_11:
				return this.Yield(4, new WaitForSeconds(0.6f));
				IL_258:
				IL_33A:
				IL_36E:
				goto IL_955;
				Block_29:
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_30:
				goto IL_D0;
				IL_40E:
				return this.Yield(5, new WaitForSeconds(0.7f));
				IL_44A:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_466:
				return this.YieldDefault(10);
				IL_500:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_51C:
				return this.YieldDefault(12);
				IL_677:
				Block_51:
				IL_792:
				goto IL_955;
				Block_57:
				return this.Yield(13, new WaitForSeconds(1f));
				IL_82D:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_848:
				return this.YieldDefault(8);
				Block_61:
				goto IL_10B;
				IL_955:
				return false;
			}

			// Token: 0x06006DFF RID: 28159 RVA: 0x00F4AC54 File Offset: 0x00F48E54
			internal static bool Da4hYNpmz70gMgJQ0iyZ()
			{
				return true;
			}

			// Token: 0x06006E00 RID: 28160 RVA: 0x00F4AC58 File Offset: 0x00F48E58
			internal static bool DiHP70pFaxSABvgsASLR()
			{
				return false;
			}

			// Token: 0x040075A3 RID: 30115
			internal GameGui $mGameGui$36967;

			// Token: 0x040075A4 RID: 30116
			internal GameObject $mPlayer$36968;

			// Token: 0x040075A5 RID: 30117
			internal GameObject $mStartPoint$36969;

			// Token: 0x040075A6 RID: 30118
			internal float $mStoryTimer$36970;

			// Token: 0x040075A7 RID: 30119
			internal M100_GameTutorial1 $self_$36971;
		}
	}

	// Token: 0x020012A7 RID: 4775
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWalrus$36973 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006E01 RID: 28161 RVA: 0x00F4AC5C File Offset: 0x00F48E5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWalrus$36973(M100_GameTutorial1 self_)
		{
			if (93384 - 592730 != -499346)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (47818 - 540346 == -492528)
				{
					base..ctor();
					if (114798 - 134571 != -19772)
					{
						this.$self_$36976 = self_;
						if (208526 - 228200 == -19674)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x00F4ACF4 File Offset: 0x00F48EF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial1.$TalkToWalrus$36973.$(this.$self_$36976);
		}

		// Token: 0x06006E03 RID: 28163 RVA: 0x00F4AD04 File Offset: 0x00F48F04
		internal static bool q9byA7pF5LQ25J0cowFK()
		{
			return true;
		}

		// Token: 0x06006E04 RID: 28164 RVA: 0x00F4AD08 File Offset: 0x00F48F08
		internal static bool wVLX7IpFpj7HBB2GBe4P()
		{
			return false;
		}

		// Token: 0x040075A8 RID: 30120
		internal M100_GameTutorial1 $self_$36976;

		// Token: 0x020012A8 RID: 4776
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006E05 RID: 28165 RVA: 0x00F4AD0C File Offset: 0x00F48F0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial1 self_)
			{
				if (67005 - 544958 != -477952)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (48510 - 290644 != -242133)
					{
						base..ctor();
						if (18133 - 29039 == -10906)
						{
							this.$self_$36975 = self_;
							if (218405 - 290963 != -72557)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006E06 RID: 28166 RVA: 0x00F4ADA4 File Offset: 0x00F48FA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (43231 - 332446 != -289215)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_D69;
					case 1:
						goto IL_129C;
					case 2:
						this.$self_$36975.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", -12), eTalkType.friend);
						if (186707 - 418833 != -232125)
						{
							goto Block_8;
						}
						continue;
					case 3:
						this.$self_$36975.TCLcBsTVlNu.close();
						if (28260 - 39678 != -11418)
						{
							continue;
						}
						this.$self_$36975.MFecB4ldj2R.enabled = true;
						if (270750 - 44478 == 226273)
						{
							continue;
						}
						this.$self_$36975.pW0cBBScBYI.animation.CrossFade("root");
						if (261019 - 251087 != 9933)
						{
							goto Block_4;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (289632 - 480320 != -190688)
						{
							continue;
						}
						break;
					case 5:
						this.$self_$36975.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", -27), eTalkType.friend);
						if (158305 - 329527 != -171221)
						{
							goto Block_9;
						}
						continue;
					case 6:
						this.$self_$36975.TCLcBsTVlNu.close();
						if (243273 - 590175 != -346902)
						{
							continue;
						}
						this.$self_$36975.MFecB4ldj2R.enabled = true;
						if (161788 - 586359 != -424571)
						{
							continue;
						}
						this.$self_$36975.pW0cBBScBYI.animation.CrossFade("root");
						if (8669 - 573225 != -564555)
						{
							goto Block_71;
						}
						continue;
					case 7:
						Game.mGameState = eGameState.Normal;
						if (199537 - 307502 == -107964)
						{
							continue;
						}
						break;
					case 8:
						this.$self_$36975.TCLcBsTVlNu.newStoryMessage("Walrus", "Reggu", Language.getMessage("M100_GameTutorial", 33), eTalkType.friend);
						if (12150 - 552704 != -540553)
						{
							goto Block_16;
						}
						continue;
					case 9:
						this.$self_$36975.TCLcBsTVlNu.close();
						if (266418 - 56855 != 209563)
						{
							continue;
						}
						this.$self_$36975.MFecB4ldj2R.enabled = true;
						if (292305 - 513907 == -221601)
						{
							continue;
						}
						this.$self_$36975.pW0cBBScBYI.animation.CrossFade("root");
						if (72468 - 441408 != -368940)
						{
							continue;
						}
						goto IL_A07;
					case 10:
						Game.mGameState = eGameState.Normal;
						if (287709 - 265651 == 22059)
						{
							continue;
						}
						break;
					default:
						if (99210 - 189859 != -90649)
						{
							continue;
						}
						goto IL_D69;
					}
					IL_BEF:
					this.YieldDefault(1);
					if (204743 - 535402 != -330658)
					{
						goto Block_80;
					}
					continue;
					IL_5EA:
					IL_445:
					goto IL_BEF;
					IL_D69:
					this.$$switch$6222$36974 = this.$self_$36975.LrhcB3KRbKm;
					if (119638 - 273778 != -154139)
					{
						if (this.$$switch$6222$36974 == 10)
						{
							if (290818 - 86955 != 203864)
							{
								this.$self_$36975.LrhcB3KRbKm = 11;
								if (107318 - 562972 != -455653)
								{
									this.$self_$36975.B1kcBbakxdR = Time.time;
									if (198643 - 195972 != 2672)
									{
										Game.mGameState = eGameState.AllHold;
										if (239843 - 278571 != -38727)
										{
											this.$self_$36975.pW0cBBScBYI.animation.CrossFade("talk");
											if (262924 - 282361 == -19437)
											{
												this.$self_$36975.pW0cBBScBYI.animation.wrapMode = WrapMode.Loop;
												if (20315 - 52418 == -32103)
												{
													Chat.SubmitChat("Reggu", Language.getMessage("M100_GameTutorial", 7), eChatType.npc, eChatMode.area);
													if (19444 - 416951 == -397507)
													{
														if (PlayerPrefs.GetInt("nvoice", 1) != 0)
														{
															if (52226 - 303858 == -251631)
															{
																continue;
															}
															if (this.$self_$36975.good_vc)
															{
																if (19463 - 424140 == -404676)
																{
																	continue;
																}
																this.$self_$36975.audio.PlayOneShot(this.$self_$36975.good_vc);
																if (247934 - 67092 == 180843)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Cannot find good voice");
																if (123491 - 98693 == 24799)
																{
																	continue;
																}
															}
														}
														if (Game.mPlayer)
														{
															if (157675 - 539795 == -382119)
															{
																continue;
															}
															Game.mPlayer.SendMessage("turnToPos", this.$self_$36975.pW0cBBScBYI.transform.position);
															if (245145 - 113523 == 131623)
															{
																continue;
															}
														}
														Game.sendMissionEvent(1001, 0);
														if (148504 - 96234 != 52271)
														{
															goto IL_BEF;
														}
													}
												}
											}
										}
									}
								}
							}
						}
						else if (this.$$switch$6222$36974 == 19)
						{
							if (265254 - 201734 != 63521)
							{
								if (this.$self_$36975.guocBd2ujGG >= 3)
								{
									if (122627 - 163336 != -40708)
									{
										Game.mGameState = eGameState.AllHold;
										if (230816 - 334858 == -104042)
										{
											this.$self_$36975.LrhcB3KRbKm = 20;
											if (90292 - 144231 != -53938)
											{
												this.$self_$36975.B1kcBbakxdR = Time.time;
												if (71150 - 48572 != 22579)
												{
													this.$self_$36975.MFecB4ldj2R.close();
													if (182160 - 72137 != 110024)
													{
														this.$self_$36975.pW0cBBScBYI.animation.CrossFade("talk");
														if (214806 - 379083 == -164277)
														{
															if (Game.mPlayer)
															{
																if (76035 - 371955 != -295920)
																{
																	continue;
																}
																Game.mPlayer.SendMessage("turnToPos", this.$self_$36975.pW0cBBScBYI.transform.position);
																if (106595 - 19273 != 87322)
																{
																	continue;
																}
															}
															if (this.$self_$36975.TCLcBsTVlNu)
															{
																if (3995 - 545508 == -541512)
																{
																	continue;
																}
																this.$self_$36975.TCLcBsTVlNu.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
																if (32736 - 215876 == -183139)
																{
																	continue;
																}
															}
															goto IL_5EA;
														}
													}
												}
											}
										}
									}
								}
								else
								{
									Game.mGameState = eGameState.Hold;
									if (220022 - 514338 == -294316)
									{
										this.$self_$36975.MFecB4ldj2R.close();
										if (194728 - 56269 != 138460)
										{
											this.$self_$36975.pW0cBBScBYI.animation.CrossFade("talk");
											if (62076 - 477462 != -415385)
											{
												if (Game.mPlayer)
												{
													if (108216 - 410946 != -302730)
													{
														continue;
													}
													Game.mPlayer.SendMessage("turnToPos", this.$self_$36975.pW0cBBScBYI.transform.position);
													if (5666 - 363148 != -357482)
													{
														continue;
													}
												}
												if (!this.$self_$36975.TCLcBsTVlNu)
												{
													goto IL_D1;
												}
												if (226593 - 251300 == -24707)
												{
													this.$self_$36975.TCLcBsTVlNu.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
													if (228066 - 534364 != -306297)
													{
														goto Block_15;
													}
												}
											}
										}
									}
								}
							}
						}
						else if (this.$$switch$6222$36974 == 30)
						{
							if (71953 - 570716 == -498763)
							{
								Game.mGameState = eGameState.AllHold;
								if (69066 - 125913 != -56846)
								{
									this.$self_$36975.LrhcB3KRbKm = 31;
									if (103959 - 68571 == 35388)
									{
										this.$self_$36975.B1kcBbakxdR = Time.time;
										if (14295 - 539083 == -524788)
										{
											this.$self_$36975.MFecB4ldj2R.close();
											if (259935 - 168014 == 91921)
											{
												this.$self_$36975.pW0cBBScBYI.animation.Play("talk");
												if (83880 - 536845 == -452965)
												{
													if (Game.mPlayer)
													{
														if (142874 - 370512 != -227638)
														{
															continue;
														}
														Game.mPlayer.SendMessage("turnToPos", this.$self_$36975.pW0cBBScBYI.transform.position);
														if (195769 - 311112 == -115342)
														{
															continue;
														}
													}
													if (this.$self_$36975.TCLcBsTVlNu)
													{
														if (141724 - 406618 != -264894)
														{
															continue;
														}
														this.$self_$36975.TCLcBsTVlNu.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
														if (203224 - 200430 != 2794)
														{
															continue;
														}
													}
													goto IL_BEF;
												}
											}
										}
									}
								}
							}
						}
						else if (this.$$switch$6222$36974 == 41)
						{
							if (169656 - 253081 != -83424)
							{
								if (this.$self_$36975.aUGcBgQDhEo >= 1)
								{
									if (282796 - 184678 != 98119)
									{
										Game.mGameState = eGameState.AllHold;
										if (124359 - 50956 == 73403)
										{
											this.$self_$36975.LrhcB3KRbKm = 42;
											if (34684 - 306532 != -271847)
											{
												this.$self_$36975.B1kcBbakxdR = Time.time;
												if (270209 - 145158 != 125052)
												{
													this.$self_$36975.MFecB4ldj2R.close();
													if (117842 - 82517 == 35325)
													{
														this.$self_$36975.pW0cBBScBYI.animation.Play("talk");
														if (248107 - 483376 != -235268)
														{
															if (Game.mPlayer)
															{
																if (10947 - 238723 == -227775)
																{
																	continue;
																}
																Game.mPlayer.SendMessage("turnToPos", this.$self_$36975.pW0cBBScBYI.transform.position);
																if (233194 - 276319 == -43124)
																{
																	continue;
																}
															}
															if (this.$self_$36975.TCLcBsTVlNu)
															{
																if (219911 - 330699 != -110788)
																{
																	continue;
																}
																this.$self_$36975.TCLcBsTVlNu.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
																if (51383 - 493520 != -442137)
																{
																	continue;
																}
															}
															goto IL_445;
														}
													}
												}
											}
										}
									}
								}
								else
								{
									Game.mGameState = eGameState.Hold;
									if (52403 - 452699 == -400296)
									{
										this.$self_$36975.MFecB4ldj2R.close();
										if (16764 - 370527 == -353763)
										{
											this.$self_$36975.pW0cBBScBYI.animation.CrossFade("talk");
											if (136771 - 20826 != 115946)
											{
												if (Game.mPlayer)
												{
													if (240710 - 23435 == 217276)
													{
														continue;
													}
													Game.mPlayer.SendMessage("turnToPos", this.$self_$36975.pW0cBBScBYI.transform.position);
													if (69502 - 471795 == -402292)
													{
														continue;
													}
												}
												if (!this.$self_$36975.TCLcBsTVlNu)
												{
													goto IL_129;
												}
												if (236500 - 324410 != -87909)
												{
													this.$self_$36975.TCLcBsTVlNu.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
													if (280649 - 388397 != -107747)
													{
														goto Block_102;
													}
												}
											}
										}
									}
								}
							}
						}
						else if (this.$$switch$6222$36974 == 506)
						{
							if (18456 - 320994 == -302538)
							{
								Game.mGameState = eGameState.AllHold;
								if (255616 - 102089 == 153527)
								{
									this.$self_$36975.LrhcB3KRbKm = 51;
									if (89023 - 339324 != -250300)
									{
										this.$self_$36975.B1kcBbakxdR = Time.time;
										if (123153 - 357845 == -234692)
										{
											this.$self_$36975.MFecB4ldj2R.close();
											if (63655 - 538056 != -474400)
											{
												this.$self_$36975.pW0cBBScBYI.animation.Play("talk");
												if (43384 - 372289 != -328904)
												{
													if (Game.mPlayer)
													{
														if (156781 - 329950 != -173169)
														{
															continue;
														}
														Game.mPlayer.SendMessage("turnToPos", this.$self_$36975.pW0cBBScBYI.transform.position);
														if (189182 - 244305 != -55123)
														{
															continue;
														}
													}
													if (this.$self_$36975.TCLcBsTVlNu)
													{
														if (80177 - 359465 != -279288)
														{
															continue;
														}
														this.$self_$36975.TCLcBsTVlNu.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
														if (281600 - 553430 == -271829)
														{
															continue;
														}
													}
													goto IL_BEF;
												}
											}
										}
									}
								}
							}
						}
						else if (this.$$switch$6222$36974 == 60)
						{
							if (273542 - 293197 == -19655)
							{
								Game.mGameState = eGameState.Hold;
								if (95143 - 513115 == -417972)
								{
									this.$self_$36975.MFecB4ldj2R.close();
									if (20540 - 455851 != -435310)
									{
										this.$self_$36975.pW0cBBScBYI.animation.CrossFade("talk");
										if (161037 - 377553 != -216515)
										{
											if (Game.mPlayer)
											{
												if (277827 - 149712 != 128115)
												{
													continue;
												}
												Game.mPlayer.SendMessage("turnToPos", this.$self_$36975.pW0cBBScBYI.transform.position);
												if (115876 - 106850 == 9027)
												{
													continue;
												}
											}
											if (!this.$self_$36975.TCLcBsTVlNu)
											{
												goto IL_269;
											}
											if (297723 - 341810 != -44086)
											{
												this.$self_$36975.TCLcBsTVlNu.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
												if (275103 - 226311 != 48793)
												{
													goto Block_17;
												}
											}
										}
									}
								}
							}
						}
						else
						{
							Debug.LogError("Unknown TalktoWalrus State:" + this.$self_$36975.LrhcB3KRbKm);
							if (96548 - 446694 != -350145)
							{
								goto IL_BEF;
							}
						}
					}
				}
				Block_4:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_D1:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_8:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_129:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_9:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_15:
				goto IL_D1;
				IL_269:
				return this.Yield(8, new WaitForSeconds(0.5f));
				Block_16:
				return this.Yield(9, new WaitForSeconds(3f));
				Block_17:
				goto IL_269;
				IL_A07:
				return this.Yield(10, new WaitForSeconds(0.5f));
				Block_71:
				return this.Yield(7, new WaitForSeconds(0.5f));
				Block_80:
				goto IL_129C;
				Block_102:
				goto IL_129;
				IL_129C:
				return false;
			}

			// Token: 0x06006E07 RID: 28167 RVA: 0x00F4C060 File Offset: 0x00F4A260
			internal static bool M85pLgpFVt30u3Lb5ajA()
			{
				return true;
			}

			// Token: 0x06006E08 RID: 28168 RVA: 0x00F4C064 File Offset: 0x00F4A264
			internal static bool xLF72PpFt8fMBeRRn4i3()
			{
				return false;
			}

			// Token: 0x040075A9 RID: 30121
			internal int $$switch$6222$36974;

			// Token: 0x040075AA RID: 30122
			internal M100_GameTutorial1 $self_$36975;
		}
	}

	// Token: 0x020012A9 RID: 4777
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$36977 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006E09 RID: 28169 RVA: 0x00F4C068 File Offset: 0x00F4A268
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$36977(M100_GameTutorial1 self_)
		{
			if (251533 - 540881 != -289347)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (33843 - 549604 == -515761)
				{
					base..ctor();
					if (236017 - 518765 != -282747)
					{
						this.$self_$36980 = self_;
						if (98885 - 401237 == -302352)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x00F4C100 File Offset: 0x00F4A300
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial1.$StartGame$36977.$(this.$self_$36980);
		}

		// Token: 0x06006E0B RID: 28171 RVA: 0x00F4C110 File Offset: 0x00F4A310
		internal static bool SdEYAxpFNZcpeGXupTLB()
		{
			return true;
		}

		// Token: 0x06006E0C RID: 28172 RVA: 0x00F4C114 File Offset: 0x00F4A314
		internal static bool ER9Pf2pFYeQvIIHIg1pu()
		{
			return false;
		}

		// Token: 0x040075AB RID: 30123
		internal M100_GameTutorial1 $self_$36980;

		// Token: 0x020012AA RID: 4778
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006E0D RID: 28173 RVA: 0x00F4C118 File Offset: 0x00F4A318
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial1 self_)
			{
				if (109713 - 238460 != -128746)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (189378 - 15719 != 173660)
					{
						base..ctor();
						if (119564 - 47762 == 71802)
						{
							this.$self_$36979 = self_;
							if (118825 - 131985 == -13160)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006E0E RID: 28174 RVA: 0x00F4C1B0 File Offset: 0x00F4A3B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153593 - 73466 != 80128)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_19F;
					case 2:
						this.$mLoadingGui$36978.fadeInTimer(1f);
						if (27333 - 389924 == -362590)
						{
							continue;
						}
						this.YieldDefault(1);
						if (100240 - 514246 != -414005)
						{
							goto IL_19F;
						}
						continue;
					default:
						if (194681 - 404470 == -209788)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (177296 - 128074 != 49223)
					{
						Game.mGameState = eGameState.AllHold;
						if (131496 - 448218 != -316721)
						{
							Game.mGameTime = Time.time;
							if (188952 - 297594 == -108642)
							{
								this.$mLoadingGui$36978 = (LoadingGui)this.$self_$36979.GetComponent(typeof(LoadingGui));
								if (153637 - 472199 != -318561)
								{
									this.$self_$36979.LrhcB3KRbKm = 1;
									if (172379 - 460764 != -288384)
									{
										this.$self_$36979.B1kcBbakxdR = Time.time;
										if (79240 - 54070 == 25170)
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
				IL_19F:
				return false;
			}

			// Token: 0x06006E0F RID: 28175 RVA: 0x00F4C370 File Offset: 0x00F4A570
			internal static bool jmVOkOpFct8IukPB9Ir9()
			{
				return true;
			}

			// Token: 0x06006E10 RID: 28176 RVA: 0x00F4C374 File Offset: 0x00F4A574
			internal static bool SWHx4ipFULZEFdUB3spG()
			{
				return false;
			}

			// Token: 0x040075AC RID: 30124
			internal LoadingGui $mLoadingGui$36978;

			// Token: 0x040075AD RID: 30125
			internal M100_GameTutorial1 $self_$36979;
		}
	}

	// Token: 0x020012AB RID: 4779
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$36981 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006E11 RID: 28177 RVA: 0x00F4C378 File Offset: 0x00F4A578
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$36981(Hashtable data, M100_GameTutorial1 self_)
		{
			if (45340 - 486131 != -440790)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (118989 - 461670 == -342681)
				{
					base..ctor();
					if (19838 - 134116 != -114277)
					{
						this.$data$36989 = data;
						if (5637 - 289000 != -283362)
						{
							this.$self_$36990 = self_;
							if (108406 - 81343 == 27063)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x00F4C434 File Offset: 0x00F4A634
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial1.$onGameComplete$36981.$(this.$data$36989, this.$self_$36990);
		}

		// Token: 0x06006E13 RID: 28179 RVA: 0x00F4C448 File Offset: 0x00F4A648
		internal static bool uju3AJpFTUsZWNujGGxn()
		{
			return true;
		}

		// Token: 0x06006E14 RID: 28180 RVA: 0x00F4C44C File Offset: 0x00F4A64C
		internal static bool CFWffypF3Mak9ANiUq5L()
		{
			return false;
		}

		// Token: 0x040075AE RID: 30126
		internal Hashtable $data$36989;

		// Token: 0x040075AF RID: 30127
		internal M100_GameTutorial1 $self_$36990;

		// Token: 0x020012AC RID: 4780
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006E15 RID: 28181 RVA: 0x00F4C450 File Offset: 0x00F4A650
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M100_GameTutorial1 self_)
			{
				if (174647 - 141016 != 33632)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (106109 - 328203 == -222094)
					{
						base..ctor();
						if (296941 - 465568 == -168627)
						{
							this.$data$36987 = data;
							if (267552 - 14623 != 252930)
							{
								this.$self_$36988 = self_;
								if (293189 - 225839 == 67350)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006E16 RID: 28182 RVA: 0x00F4C50C File Offset: 0x00F4A70C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (193697 - 312506 != -118808)
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
						this.$mCompleteGui$36983 = (CompleteGui)this.$self_$36988.GetComponent(typeof(CompleteGui));
						if (114941 - 441692 != -326751)
						{
							continue;
						}
						this.$mCompleteGui$36983.Init();
						if (177850 - 220428 == -42577)
						{
							continue;
						}
						this.$mCompleteGui$36983.readData(this.$data$36987);
						if (167989 - 133892 == 34098)
						{
							continue;
						}
						if (this.$result$36982 == 1)
						{
							if (111629 - 73384 == 38246)
							{
								continue;
							}
							this.$mCompleteGui$36983.displayResult(eCompleteType.Success);
							if (292539 - 397456 == -104916)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$36983.displayResult(eCompleteType.Failed);
							if (92890 - 393181 != -300291)
							{
								continue;
							}
						}
						this.$mGameGui$36984 = (GameGui)this.$self_$36988.GetComponent(typeof(GameGui));
						if (23702 - 286285 != -262583)
						{
							continue;
						}
						this.$mStoryGui$36985 = (StoryGui)this.$self_$36988.GetComponent(typeof(StoryGui));
						if (230128 - 72568 != 157560)
						{
							continue;
						}
						this.$mChangeGui$36986 = (ChangeGui)this.$self_$36988.GetComponent(typeof(ChangeGui));
						if (72091 - 586680 == -514588)
						{
							continue;
						}
						if (this.$mGameGui$36984)
						{
							if (26048 - 36700 == -10651)
							{
								continue;
							}
							this.$mGameGui$36984.close();
							if (131595 - 423641 == -292045)
							{
								continue;
							}
						}
						if (this.$mStoryGui$36985)
						{
							if (70341 - 54336 != 16005)
							{
								continue;
							}
							this.$mStoryGui$36985.close();
							if (214342 - 434413 != -220071)
							{
								continue;
							}
						}
						if (this.$mChangeGui$36986)
						{
							if (11207 - 300989 != -289782)
							{
								continue;
							}
							this.$mChangeGui$36986.disable();
							if (114834 - 551723 != -436889)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (103219 - 504610 != -401390)
						{
							goto Block_21;
						}
						continue;
					default:
						if (272200 - 7528 == 264673)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$36987[31]);
					if (289394 - 89441 != 199954)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (108007 - 120219 == -12212)
							{
								goto IL_256;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (209556 - 436915 != -227358)
							{
								this.$result$36982 = RuntimeServices.UnboxInt32(this.$data$36987[31]);
								if (37024 - 148137 == -111113)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_256:
				Block_21:
				IL_3DB:
				return false;
			}

			// Token: 0x06006E17 RID: 28183 RVA: 0x00F4C908 File Offset: 0x00F4AB08
			internal static bool xTYCr0pFXdxHRcqiDYjg()
			{
				return true;
			}

			// Token: 0x06006E18 RID: 28184 RVA: 0x00F4C90C File Offset: 0x00F4AB0C
			internal static bool l6gsTOpFQyvJton8HxNI()
			{
				return false;
			}

			// Token: 0x040075B0 RID: 30128
			internal int $result$36982;

			// Token: 0x040075B1 RID: 30129
			internal CompleteGui $mCompleteGui$36983;

			// Token: 0x040075B2 RID: 30130
			internal GameGui $mGameGui$36984;

			// Token: 0x040075B3 RID: 30131
			internal StoryGui $mStoryGui$36985;

			// Token: 0x040075B4 RID: 30132
			internal ChangeGui $mChangeGui$36986;

			// Token: 0x040075B5 RID: 30133
			internal Hashtable $data$36987;

			// Token: 0x040075B6 RID: 30134
			internal M100_GameTutorial1 $self_$36988;
		}
	}

	// Token: 0x020012AD RID: 4781
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$36991 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006E19 RID: 28185 RVA: 0x00F4C910 File Offset: 0x00F4AB10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$36991(M100_GameTutorial1 self_)
		{
			if (195457 - 269609 != -74151)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (46533 - 496415 == -449882)
				{
					base..ctor();
					if (97906 - 507907 == -410001)
					{
						this.$self_$36996 = self_;
						if (58986 - 1399 != 57588)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006E1A RID: 28186 RVA: 0x00F4C9A8 File Offset: 0x00F4ABA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial1.$onDeadPlayer$36991.$(this.$self_$36996);
		}

		// Token: 0x06006E1B RID: 28187 RVA: 0x00F4C9B8 File Offset: 0x00F4ABB8
		internal static bool T5fyGmpFk77vE8NnqUXI()
		{
			return true;
		}

		// Token: 0x06006E1C RID: 28188 RVA: 0x00F4C9BC File Offset: 0x00F4ABBC
		internal static bool jWUtF8pFG3412nMwclSU()
		{
			return false;
		}

		// Token: 0x040075B7 RID: 30135
		internal M100_GameTutorial1 $self_$36996;

		// Token: 0x020012AE RID: 4782
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006E1D RID: 28189 RVA: 0x00F4C9C0 File Offset: 0x00F4ABC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial1 self_)
			{
				if (143528 - 220292 != -76763)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (215597 - 72511 != 143087)
					{
						base..ctor();
						if (264303 - 359234 == -94931)
						{
							this.$self_$36995 = self_;
							if (103991 - 579525 != -475533)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006E1E RID: 28190 RVA: 0x00F4CA58 File Offset: 0x00F4AC58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (255865 - 438179 != -182314)
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
							if (121972 - 173947 == -51974)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1A9;
							}
							if (204111 - 254621 != -50510)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.AllHold;
						if (25431 - 516530 != -491099)
						{
							continue;
						}
						this.$mStoryGui$36992 = (StoryGui)this.$self_$36995.GetComponent(typeof(StoryGui));
						if (240253 - 160804 != 79449)
						{
							continue;
						}
						if (this.$mStoryGui$36992)
						{
							if (293975 - 52989 != 240986)
							{
								continue;
							}
							this.$mStoryGui$36992.close();
							if (177416 - 420328 != -242912)
							{
								continue;
							}
						}
						this.$mChangeGui$36993 = (ChangeGui)this.$self_$36995.GetComponent(typeof(ChangeGui));
						if (267773 - 214673 == 53101)
						{
							continue;
						}
						if (this.$mChangeGui$36993)
						{
							if (185681 - 310439 == -124757)
							{
								continue;
							}
							this.$mChangeGui$36993.close();
							if (184738 - 354733 == -169994)
							{
								continue;
							}
						}
						this.$mGameGui$36994 = (GameGui)this.$self_$36995.GetComponent(typeof(GameGui));
						if (203454 - 55128 != 148326)
						{
							continue;
						}
						if (this.$mGameGui$36994)
						{
							if (3317 - 161648 == -158330)
							{
								continue;
							}
							if (!this.$mGameGui$36994.enabled)
							{
								if (85068 - 554949 == -469880)
								{
									continue;
								}
								this.$mGameGui$36994.enabled = true;
								if (28004 - 531798 == -503793)
								{
									continue;
								}
							}
							this.$mGameGui$36994.openDeadMenu();
							if (242874 - 573782 == -330907)
							{
								continue;
							}
						}
						IL_1A9:
						this.YieldDefault(1);
						if (276281 - 80154 != 196128)
						{
							goto Block_14;
						}
						continue;
					default:
						if (247254 - 447271 == -200016)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (143751 - 163358 != -19607);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_14:
				IL_2F9:
				return false;
			}

			// Token: 0x06006E1F RID: 28191 RVA: 0x00F4CD70 File Offset: 0x00F4AF70
			internal static bool eeLiMQpFHSciktj6eFDI()
			{
				return true;
			}

			// Token: 0x06006E20 RID: 28192 RVA: 0x00F4CD74 File Offset: 0x00F4AF74
			internal static bool aepTX4pFWcbK6KfUOjIF()
			{
				return false;
			}

			// Token: 0x040075B8 RID: 30136
			internal StoryGui $mStoryGui$36992;

			// Token: 0x040075B9 RID: 30137
			internal ChangeGui $mChangeGui$36993;

			// Token: 0x040075BA RID: 30138
			internal GameGui $mGameGui$36994;

			// Token: 0x040075BB RID: 30139
			internal M100_GameTutorial1 $self_$36995;
		}
	}

	// Token: 0x020012AF RID: 4783
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$36997 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006E21 RID: 28193 RVA: 0x00F4CD78 File Offset: 0x00F4AF78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$36997(Hashtable data, M100_GameTutorial1 self_)
		{
			if (191692 - 62134 != 129559)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (83861 - 288730 == -204869)
				{
					base..ctor();
					if (247187 - 551265 != -304077)
					{
						this.$data$37002 = data;
						if (170110 - 125737 != 44374)
						{
							this.$self_$37003 = self_;
							if (252422 - 32507 != 219916)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006E22 RID: 28194 RVA: 0x00F4CE34 File Offset: 0x00F4B034
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial1.$onChangePlayer$36997.$(this.$data$37002, this.$self_$37003);
		}

		// Token: 0x06006E23 RID: 28195 RVA: 0x00F4CE48 File Offset: 0x00F4B048
		internal static bool nMhDO5pFArFu527Rt8tM()
		{
			return true;
		}

		// Token: 0x06006E24 RID: 28196 RVA: 0x00F4CE4C File Offset: 0x00F4B04C
		internal static bool eLAUJTpFlKeKorcQYLeo()
		{
			return false;
		}

		// Token: 0x040075BC RID: 30140
		internal Hashtable $data$37002;

		// Token: 0x040075BD RID: 30141
		internal M100_GameTutorial1 $self_$37003;

		// Token: 0x020012B0 RID: 4784
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006E25 RID: 28197 RVA: 0x00F4CE50 File Offset: 0x00F4B050
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M100_GameTutorial1 self_)
			{
				if (148898 - 157477 != -8579)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (141409 - 292616 != -151206)
					{
						base..ctor();
						if (89598 - 258683 == -169085)
						{
							this.$data$37000 = data;
							if (82302 - 382994 == -300692)
							{
								this.$self_$37001 = self_;
								if (191437 - 146107 != 45331)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006E26 RID: 28198 RVA: 0x00F4CF0C File Offset: 0x00F4B10C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (154571 - 439811 != -285239)
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
							if (237774 - 239605 == -1830)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (279563 - 42155 == 237409)
							{
								continue;
							}
							this.$mGameGui$36999 = (GameGui)this.$self_$37001.GetComponent(typeof(GameGui));
							if (225379 - 193876 != 31503)
							{
								continue;
							}
							this.$mGameGui$36999.enabled = true;
							if (91927 - 57451 != 34476)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (99035 - 350119 != -251084)
						{
							continue;
						}
						goto IL_205;
					default:
						if (178243 - 108097 == 70147)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (158506 - 490669 == -332163)
					{
						this.$self_$37001.SendMessage("onCreatePlayer", this.$data$37000);
						if (145635 - 549283 != -403647)
						{
							this.$mChangeGui$36998 = (ChangeGui)this.$self_$37001.GetComponent(typeof(ChangeGui));
							if (201737 - 536788 == -335051)
							{
								if (!this.$mChangeGui$36998.enabled)
								{
									break;
								}
								if (31287 - 315111 == -283824)
								{
									this.$mChangeGui$36998.close();
									if (259635 - 187898 != 71738)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_C4:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_C4;
				IL_205:
				return false;
			}

			// Token: 0x06006E27 RID: 28199 RVA: 0x00F4D130 File Offset: 0x00F4B330
			internal static bool jZmvqHpFyQgo5tc9us7E()
			{
				return true;
			}

			// Token: 0x06006E28 RID: 28200 RVA: 0x00F4D134 File Offset: 0x00F4B334
			internal static bool B1IRkKpFSIHvvEyt0m7S()
			{
				return false;
			}

			// Token: 0x040075BE RID: 30142
			internal ChangeGui $mChangeGui$36998;

			// Token: 0x040075BF RID: 30143
			internal GameGui $mGameGui$36999;

			// Token: 0x040075C0 RID: 30144
			internal Hashtable $data$37000;

			// Token: 0x040075C1 RID: 30145
			internal M100_GameTutorial1 $self_$37001;
		}
	}

	// Token: 0x020012B1 RID: 4785
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37004 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006E29 RID: 28201 RVA: 0x00F4D138 File Offset: 0x00F4B338
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37004(M100_GameTutorial1 self_)
		{
			if (24637 - 477678 != -453041)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (162189 - 410375 != -248185)
				{
					base..ctor();
					if (185732 - 81201 != 104532)
					{
						this.$self_$37008 = self_;
						if (298615 - 334070 != -35454)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006E2A RID: 28202 RVA: 0x00F4D1D0 File Offset: 0x00F4B3D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial1.$ReturnToTown$37004.$(this.$self_$37008);
		}

		// Token: 0x06006E2B RID: 28203 RVA: 0x00F4D1E0 File Offset: 0x00F4B3E0
		internal static bool qKCyqMpFoWYrKdJmt6XD()
		{
			return true;
		}

		// Token: 0x06006E2C RID: 28204 RVA: 0x00F4D1E4 File Offset: 0x00F4B3E4
		internal static bool HWiQGJpFEbEYyVXIqlJ8()
		{
			return false;
		}

		// Token: 0x040075C2 RID: 30146
		internal M100_GameTutorial1 $self_$37008;

		// Token: 0x020012B2 RID: 4786
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006E2D RID: 28205 RVA: 0x00F4D1E8 File Offset: 0x00F4B3E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial1 self_)
			{
				if (19819 - 95348 != -75528)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (89551 - 39889 != 49663)
					{
						base..ctor();
						if (207975 - 399236 != -191260)
						{
							this.$self_$37007 = self_;
							if (174087 - 532417 == -358330)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006E2E RID: 28206 RVA: 0x00F4D280 File Offset: 0x00F4B480
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (290346 - 466543 != -176197)
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
						this.$self_$37007.LeaveGame();
						if (93160 - 161718 != -68558)
						{
							continue;
						}
						this.YieldDefault(1);
						if (89614 - 586528 != -496914)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (265426 - 28983 != 236443)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (266481 - 583237 == -316756)
					{
						Game.mStateTime = Time.time;
						if (46442 - 545089 != -498646)
						{
							this.$$switch$6226$37005 = PlayerData.SaveGuild;
							if (110916 - 268784 == -157868)
							{
								if (this.$$switch$6226$37005 == 1)
								{
									if (252672 - 431965 == -179292)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (49204 - 51824 != -2620)
									{
										continue;
									}
								}
								else if (this.$$switch$6226$37005 == 2)
								{
									if (144733 - 425036 != -280303)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (104612 - 94309 == 10304)
									{
										continue;
									}
								}
								else if (this.$$switch$6226$37005 == 3)
								{
									if (13490 - 276465 == -262974)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (140038 - 248810 != -108772)
									{
										continue;
									}
								}
								else if (this.$$switch$6226$37005 == 4)
								{
									if (258300 - 199952 != 58348)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (227615 - 176598 == 51018)
									{
										continue;
									}
								}
								else if (this.$$switch$6226$37005 == 5)
								{
									if (5683 - 68375 != -62692)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (263750 - 93800 != 169950)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (132229 - 59335 == 72895)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (15382 - 495664 == -480281)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (90553 - 158079 == -67525)
									{
										continue;
									}
								}
								this.$mGameGui$37006 = (GameGui)this.$self_$37007.GetComponent(typeof(GameGui));
								if (146512 - 68015 != 78498)
								{
									if (this.$mGameGui$37006)
									{
										if (151556 - 478800 != -327244)
										{
											continue;
										}
										this.$mGameGui$37006.close();
										if (205799 - 335389 != -129590)
										{
											continue;
										}
									}
									this.$self_$37007.SendMessage("fadeOut");
									if (151690 - 455125 != -303434)
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

			// Token: 0x06006E2F RID: 28207 RVA: 0x00F4D64C File Offset: 0x00F4B84C
			internal static bool CYqNXRpF2tDypdNbjp3C()
			{
				return true;
			}

			// Token: 0x06006E30 RID: 28208 RVA: 0x00F4D650 File Offset: 0x00F4B850
			internal static bool y03jOdpF8mybtQ2A0aIS()
			{
				return false;
			}

			// Token: 0x040075C3 RID: 30147
			internal int $$switch$6226$37005;

			// Token: 0x040075C4 RID: 30148
			internal GameGui $mGameGui$37006;

			// Token: 0x040075C5 RID: 30149
			internal M100_GameTutorial1 $self_$37007;
		}
	}

	// Token: 0x020012B3 RID: 4787
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37009 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006E31 RID: 28209 RVA: 0x00F4D654 File Offset: 0x00F4B854
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37009(M100_GameTutorial1 self_)
		{
			if (1563 - 94495 != -92932)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (218968 - 54827 != 164142)
				{
					base..ctor();
					if (180988 - 570187 == -389199)
					{
						this.$self_$37012 = self_;
						if (13034 - 62642 == -49608)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006E32 RID: 28210 RVA: 0x00F4D6EC File Offset: 0x00F4B8EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial1.$ReturnToGuild$37009.$(this.$self_$37012);
		}

		// Token: 0x06006E33 RID: 28211 RVA: 0x00F4D6FC File Offset: 0x00F4B8FC
		internal static bool XEcCvXpFZJZ3TKUDjtZq()
		{
			return true;
		}

		// Token: 0x06006E34 RID: 28212 RVA: 0x00F4D700 File Offset: 0x00F4B900
		internal static bool cRgkFXpFCphi4GLO7i8e()
		{
			return false;
		}

		// Token: 0x040075C6 RID: 30150
		internal M100_GameTutorial1 $self_$37012;

		// Token: 0x020012B4 RID: 4788
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006E35 RID: 28213 RVA: 0x00F4D704 File Offset: 0x00F4B904
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial1 self_)
			{
				if (14323 - 310360 != -296037)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161477 - 159039 != 2439)
					{
						base..ctor();
						if (59916 - 531375 == -471459)
						{
							this.$self_$37011 = self_;
							if (227163 - 572802 != -345638)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006E36 RID: 28214 RVA: 0x00F4D79C File Offset: 0x00F4B99C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (236715 - 344430 != -107714)
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
						this.$self_$37011.LeaveGame();
						if (193954 - 449618 == -255663)
						{
							continue;
						}
						this.YieldDefault(1);
						if (118338 - 486871 != -368533)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (201882 - 373920 == -172037)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (99443 - 502043 == -402600)
					{
						Game.mStateTime = Time.time;
						if (280702 - 238484 != 42219)
						{
							Game.mNextGameCode = 31;
							if (285236 - 224559 != 60678)
							{
								this.$mGameGui$37010 = (GameGui)this.$self_$37011.GetComponent(typeof(GameGui));
								if (61006 - 562840 != -501833)
								{
									if (this.$mGameGui$37010)
									{
										if (238633 - 316250 != -77617)
										{
											continue;
										}
										this.$mGameGui$37010.close();
										if (43764 - 591415 == -547650)
										{
											continue;
										}
									}
									this.$self_$37011.SendMessage("fadeOut");
									if (278022 - 30221 != 247802)
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

			// Token: 0x06006E37 RID: 28215 RVA: 0x00F4D978 File Offset: 0x00F4BB78
			internal static bool puvXi4pFLs8qMHI7MKT2()
			{
				return true;
			}

			// Token: 0x06006E38 RID: 28216 RVA: 0x00F4D97C File Offset: 0x00F4BB7C
			internal static bool IOuiyjpFOHOi6KTpguoY()
			{
				return false;
			}

			// Token: 0x040075C7 RID: 30151
			internal GameGui $mGameGui$37010;

			// Token: 0x040075C8 RID: 30152
			internal M100_GameTutorial1 $self_$37011;
		}
	}

	// Token: 0x020012B5 RID: 4789
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37013 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006E39 RID: 28217 RVA: 0x00F4D980 File Offset: 0x00F4BB80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37013(M100_GameTutorial1 self_)
		{
			if (88177 - 551059 != -462882)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (13437 - 422402 != -408964)
				{
					base..ctor();
					if (74598 - 321601 == -247003)
					{
						this.$self_$37017 = self_;
						if (141589 - 15558 == 126031)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006E3A RID: 28218 RVA: 0x00F4DA18 File Offset: 0x00F4BC18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial1.$ReturnToCamp$37013.$(this.$self_$37017);
		}

		// Token: 0x06006E3B RID: 28219 RVA: 0x00F4DA28 File Offset: 0x00F4BC28
		internal static bool xYvqg6pFmMe7bWX3aBX7()
		{
			return true;
		}

		// Token: 0x06006E3C RID: 28220 RVA: 0x00F4DA2C File Offset: 0x00F4BC2C
		internal static bool HQ8cNipFFbmTdKjOMZX9()
		{
			return false;
		}

		// Token: 0x040075C9 RID: 30153
		internal M100_GameTutorial1 $self_$37017;

		// Token: 0x020012B6 RID: 4790
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006E3D RID: 28221 RVA: 0x00F4DA30 File Offset: 0x00F4BC30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial1 self_)
			{
				if (204006 - 336150 != -132143)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (233686 - 468150 != -234463)
					{
						base..ctor();
						if (205609 - 86938 != 118672)
						{
							this.$self_$37016 = self_;
							if (63197 - 139479 != -76281)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006E3E RID: 28222 RVA: 0x00F4DAC8 File Offset: 0x00F4BCC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (149569 - 599191 != -449622)
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
						this.$self_$37016.LeaveGame();
						if (49432 - 429734 != -380302)
						{
							continue;
						}
						this.YieldDefault(1);
						if (57863 - 258960 != -201097)
						{
							continue;
						}
						goto IL_363;
					default:
						if (261718 - 409587 != -147869)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (258640 - 396090 != -137449)
					{
						Game.mStateTime = Time.time;
						if (30353 - 231559 != -201205)
						{
							this.$$switch$6228$37014 = PlayerData.SaveGuild;
							if (93936 - 298552 != -204615)
							{
								if (this.$$switch$6228$37014 == 1)
								{
									if (135142 - 236980 == -101837)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (247445 - 121425 == 126021)
									{
										continue;
									}
								}
								else if (this.$$switch$6228$37014 == 2)
								{
									if (95839 - 431710 != -335871)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (61604 - 76060 != -14456)
									{
										continue;
									}
								}
								else if (this.$$switch$6228$37014 == 3)
								{
									if (283746 - 175417 == 108330)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (233920 - 149953 != 83967)
									{
										continue;
									}
								}
								else if (this.$$switch$6228$37014 == 4)
								{
									if (249863 - 581145 != -331282)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (13282 - 231574 == -218291)
									{
										continue;
									}
								}
								else if (this.$$switch$6228$37014 == 5)
								{
									if (238522 - 253147 == -14624)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (29922 - 307164 == -277241)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (87005 - 56025 != 30980)
									{
										continue;
									}
								}
								this.$mGameGui$37015 = (GameGui)this.$self_$37016.GetComponent(typeof(GameGui));
								if (122011 - 505783 == -383772)
								{
									if (this.$mGameGui$37015)
									{
										if (214378 - 115309 != 99069)
										{
											continue;
										}
										this.$mGameGui$37015.close();
										if (197304 - 233482 != -36178)
										{
											continue;
										}
									}
									this.$self_$37016.SendMessage("fadeOut");
									if (110854 - 63983 == 46871)
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

			// Token: 0x06006E3F RID: 28223 RVA: 0x00F4DE4C File Offset: 0x00F4C04C
			internal static bool EUXMCdpFMY6PoU6Hhpen()
			{
				return true;
			}

			// Token: 0x06006E40 RID: 28224 RVA: 0x00F4DE50 File Offset: 0x00F4C050
			internal static bool tx5CRnpFxt7S9VvilVr6()
			{
				return false;
			}

			// Token: 0x040075CA RID: 30154
			internal int $$switch$6228$37014;

			// Token: 0x040075CB RID: 30155
			internal GameGui $mGameGui$37015;

			// Token: 0x040075CC RID: 30156
			internal M100_GameTutorial1 $self_$37016;
		}
	}
}
