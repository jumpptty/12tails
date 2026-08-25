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

// Token: 0x020012B7 RID: 4791
[Serializable]
public class M100_GameTutorial2 : MonoBehaviour
{
	// Token: 0x06006E41 RID: 28225 RVA: 0x00F4DE54 File Offset: 0x00F4C054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M100_GameTutorial2()
	{
		if (88848 - 289105 != -200256)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (274681 - 94362 == 180319)
			{
				base..ctor();
				if (13416 - 470446 == -457030)
				{
					this.w7uc0csxsg4 = 1;
					if (249117 - 171671 == 77446)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006E42 RID: 28226 RVA: 0x00F4DEEC File Offset: 0x00F4C0EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (104802 - 159800 != -54997)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (42377 - 33885 != 8493)
			{
				Game.mGameType = 5;
				if (28378 - 266652 != -238273)
				{
					if (Chat.Initialized)
					{
						if (207828 - 46764 == 161064)
						{
							Chat.ChatDisplay.Clear();
							if (276899 - 362235 != -85335)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (74060 - 371815 != -297754)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006E43 RID: 28227 RVA: 0x00F4DFD0 File Offset: 0x00F4C1D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (154617 - 182305 != -27687)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (252761 - 494742 != -241980)
				{
					Game.nextGame();
					if (5437 - 205524 == -200087)
					{
						Game.mGameCode = 100;
						if (287024 - 558902 != -271877)
						{
							Game.mGameType = 5;
							if (86028 - 506231 != -420202)
							{
								Game.mStateTime = Time.time;
								if (205872 - 412046 == -206174)
								{
									Game.canUseItem = true;
									if (84783 - 331094 == -246311)
									{
										Game.canUseMount = false;
										if (396 - 302596 != -302199)
										{
											Game.canRespawn = false;
											if (185438 - 99003 != 86436)
											{
												this.rUhcBWrk3Ls = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
												if (297659 - 335976 != -38316)
												{
													this.zIXcB9uqqWD = PhotonClient.Connection;
													if (128925 - 347574 != -218648)
													{
														PhotonClient.ActorNrList.Clear();
														if (282825 - 449524 == -166699)
														{
															this.InitGame();
															if (204576 - 374792 != -170215)
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
				if (109736 - 228907 != -119170)
				{
					Game.mGameType = 99;
					if (140064 - 24777 == 115287)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006E44 RID: 28228 RVA: 0x00F4E200 File Offset: 0x00F4C400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (176407 - 111060 != 65347)
		{
		}
		for (;;)
		{
			if (this.zIXcB9uqqWD == null)
			{
				if (285815 - 82007 == 203808)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (285504 - 99339 != 186166)
				{
					if (mGameState == eGameState.Init)
					{
						if (250092 - 105317 == 144775)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (20466 - 319634 != -299167)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (141635 - 490067 == -348432)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (239380 - 195052 != 44329)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (97723 - 423305 != -325581)
						{
							if (Game.music != 0)
							{
								if (113389 - 107112 == 6278)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (132548 - 7734 == 124815)
									{
										continue;
									}
									this.audio.Play();
									if (199604 - 18266 != 181338)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (22789 - 63115 != -40325)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (185216 - 72062 != 113155)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (74533 - 476760 != -402226)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (58258 - 521720 != -463461)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (245889 - 206044 != 39846)
							{
								if (Time.time <= this.AmUcBuY1nrn)
								{
									break;
								}
								if (41297 - 246387 != -205089)
								{
									Game.mGameMana++;
									if (5757 - 476130 != -470372)
									{
										this.AmUcBuY1nrn = Time.time + (float)12;
										if (273011 - 375111 == -102100)
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
						if (272657 - 451594 != -178936)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (261307 - 225905 != 35403)
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
						if (279667 - 549329 == -269662)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006E45 RID: 28229 RVA: 0x00F4E5A8 File Offset: 0x00F4C7A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (293364 - 595930 != -302565)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (187353 - 501908 == -314555)
			{
				GUI.depth = 1;
				if (35099 - 294508 != -259408)
				{
					int num = this.v0Nc0ObAiKy;
					if (175408 - 49974 == 125434)
					{
						if (num == 400)
						{
							if (26126 - 580765 != -554638)
							{
								if (!this.iFBcBVHc3T2)
								{
									break;
								}
								if (73349 - 270716 != -197366)
								{
									this.RenderTutorialGui(this.iFBcBVHc3T2);
									if (251561 - 195605 == 55956)
									{
										break;
									}
								}
							}
						}
						else if (num == 401)
						{
							if (249849 - 188840 != 61010)
							{
								if (!this.DsAcBhYcY3w)
								{
									break;
								}
								if (41019 - 198407 == -157388)
								{
									this.RenderTutorialGui(this.DsAcBhYcY3w);
									if (157964 - 375194 == -217230)
									{
										break;
									}
								}
							}
						}
						else
						{
							if (num != 700)
							{
								break;
							}
							if (268138 - 143284 == 124854)
							{
								if (!this.VwycBKr5h5G)
								{
									break;
								}
								if (274022 - 267653 != 6370)
								{
									this.RenderTutorialGui(this.VwycBKr5h5G);
									if (176758 - 501593 != -324834)
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

	// Token: 0x06006E46 RID: 28230 RVA: 0x00F4E7DC File Offset: 0x00F4C9DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitTutorialGui()
	{
		if (152419 - 11600 != 140820)
		{
		}
		for (;;)
		{
			int @int = PlayerPrefs.GetInt("language", 0);
			if (236505 - 471347 != -234841)
			{
				if (@int == 1)
				{
					if (47281 - 251825 == -204543)
					{
						continue;
					}
					this.YxUcBy1flW1 = (Texture)Resources.Load("GameGui/Tutorial/english/guide_menu", typeof(Texture));
					if (173051 - 294406 == -121354)
					{
						continue;
					}
					this.iFBcBVHc3T2 = (Texture)Resources.Load("GameGui/Tutorial/english/guide_400", typeof(Texture));
					if (168529 - 158516 != 10013)
					{
						continue;
					}
					this.DsAcBhYcY3w = (Texture)Resources.Load("GameGui/Tutorial/english/guide_401", typeof(Texture));
					if (37451 - 558320 != -520869)
					{
						continue;
					}
					this.VwycBKr5h5G = (Texture)Resources.Load("GameGui/Tutorial/english/guide_700", typeof(Texture));
					if (294461 - 186075 != 108386)
					{
						continue;
					}
				}
				else
				{
					this.YxUcBy1flW1 = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_menu", typeof(Texture));
					if (92257 - 312673 == -220415)
					{
						continue;
					}
					this.iFBcBVHc3T2 = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_400", typeof(Texture));
					if (10240 - 351833 != -341593)
					{
						continue;
					}
					this.DsAcBhYcY3w = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_401", typeof(Texture));
					if (139534 - 355335 == -215800)
					{
						continue;
					}
					this.VwycBKr5h5G = (Texture)Resources.Load("GameGui/Tutorial/thai/guide_700", typeof(Texture));
					if (256469 - 76517 != 179952)
					{
						continue;
					}
				}
				this.JNUcBzdNcbL = new GUIStyle();
				if (39219 - 110544 != -71324)
				{
					this.JNUcBzdNcbL.font = (Font)Resources.Load("GameGui/Fonts/Century32", typeof(Font));
					if (277943 - 264419 != 13525)
					{
						this.JNUcBzdNcbL.normal.textColor = new Color(0.42f, 0.33f, 0.28f, (float)1);
						if (116803 - 530784 != -413980)
						{
							this.JNUcBzdNcbL.alignment = TextAnchor.MiddleLeft;
							if (147420 - 298349 != -150928)
							{
								this.B68c05fmZY0 = new GUIStyle();
								if (181163 - 313306 != -132142)
								{
									this.B68c05fmZY0.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
									if (159088 - 379482 == -220394)
									{
										this.B68c05fmZY0.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
										if (133231 - 592492 != -459260)
										{
											this.B68c05fmZY0.alignment = TextAnchor.MiddleLeft;
											if (130329 - 357337 != -227007)
											{
												this.aWSc0nZSuMP = new GUIStyle();
												if (252585 - 33807 != 218779)
												{
													this.aWSc0nZSuMP.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageNext_h", typeof(Texture)));
													if (42612 - 381865 != -339252)
													{
														this.Dlxc0QocGkX = new GUIStyle();
														if (269500 - 85651 == 183849)
														{
															this.Dlxc0QocGkX.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/pageBack_h", typeof(Texture)));
															if (235684 - 534812 == -299128)
															{
																this.xjjc0eS5v9y = new GUIStyle();
																if (76218 - 282945 == -206727)
																{
																	this.xjjc0eS5v9y.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_close_h", typeof(Texture)));
																	if (55847 - 145204 == -89357)
																	{
																		this.k0ic0IMlm0U = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
																		if (212042 - 514694 == -302652)
																		{
																			this.FLac0JcN29t = (AudioClip)Resources.Load("Sound/GUI/click", typeof(AudioClip));
																			if (30569 - 85176 != -54606)
																			{
																				this.CQQc06SIZUC = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																				if (34104 - 398195 != -364090)
																				{
																					this.eVOc0tYaoMI = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
																					if (180610 - 202500 != -21889)
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

	// Token: 0x06006E47 RID: 28231 RVA: 0x00F4EDE4 File Offset: 0x00F4CFE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderTutorialGui(Texture nTutorial)
	{
		if (236225 - 535746 != -299521)
		{
		}
		for (;;)
		{
			float num = (float)(1024 * Screen.width / Screen.height);
			if (267391 - 337359 == -69968)
			{
				if (this.YxUcBy1flW1)
				{
					if (219852 - 136443 != 83409)
					{
						continue;
					}
					GUI.DrawTexture(new Rect(0.5f * num - (float)330, (float)200, (float)668, (float)676), this.YxUcBy1flW1);
					if (265403 - 310779 == -45375)
					{
						continue;
					}
				}
				GUI.Label(new Rect(0.5f * num - (float)330 + (float)112, (float)244, (float)400, (float)36), "Game Tutorial", this.JNUcBzdNcbL);
				if (154132 - 421054 != -266921)
				{
					if (nTutorial)
					{
						if (179988 - 109593 != 70395)
						{
							continue;
						}
						GUI.DrawTexture(new Rect(0.5f * num - (float)330 + (float)93, (float)296, (float)512, (float)512), nTutorial);
						if (90329 - 257407 != -167078)
						{
							continue;
						}
					}
					GUI.Label(new Rect(0.5f * num - (float)330 + (float)362, (float)813, (float)50, (float)30), string.Empty + this.w7uc0csxsg4, this.B68c05fmZY0);
					if (158637 - 256057 != -97419)
					{
						if (GUI.Button(new Rect(0.5f * num - (float)330 + (float)218, (float)803, (float)85, (float)57), string.Empty, this.Dlxc0QocGkX))
						{
							if (53603 - 218517 != -164914)
							{
								continue;
							}
							this.audio.PlayOneShot(this.CQQc06SIZUC);
							if (284785 - 115703 == 169083)
							{
								continue;
							}
						}
						if (GUI.Button(new Rect(0.5f * num - (float)330 + (float)375, (float)803, (float)85, (float)57), string.Empty, this.aWSc0nZSuMP))
						{
							if (14912 - 519840 != -504928)
							{
								continue;
							}
							this.v0Nc0ObAiKy = 0;
							if (139262 - 427434 == -288171)
							{
								continue;
							}
							this.audio.PlayOneShot(this.CQQc06SIZUC);
							if (27157 - 495764 == -468606)
							{
								continue;
							}
						}
						if (!GUI.Button(new Rect(0.5f * num - (float)330 + (float)592, (float)204, (float)57, (float)52), string.Empty, this.xjjc0eS5v9y))
						{
							break;
						}
						if (18219 - 294034 == -275815)
						{
							this.v0Nc0ObAiKy = 0;
							if (82051 - 97810 == -15759)
							{
								this.audio.PlayOneShot(this.eVOc0tYaoMI);
								if (32770 - 295658 == -262888)
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

	// Token: 0x06006E48 RID: 28232 RVA: 0x00F4F1A0 File Offset: 0x00F4D3A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M100_GameTutorial2.$onGameEvent$37018(data, this).GetEnumerator();
	}

	// Token: 0x06006E49 RID: 28233 RVA: 0x00F4F1B0 File Offset: 0x00F4D3B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M100_GameTutorial2.$StartEvent$37028(this).GetEnumerator();
	}

	// Token: 0x06006E4A RID: 28234 RVA: 0x00F4F1C0 File Offset: 0x00F4D3C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToKangaroo()
	{
		return new M100_GameTutorial2.$TalkToKangaroo$37035(this).GetEnumerator();
	}

	// Token: 0x06006E4B RID: 28235 RVA: 0x00F4F1D0 File Offset: 0x00F4D3D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new M100_GameTutorial2.$TalkToRedPanda$37043(this).GetEnumerator();
	}

	// Token: 0x06006E4C RID: 28236 RVA: 0x00F4F1E0 File Offset: 0x00F4D3E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToOwl2()
	{
		return new M100_GameTutorial2.$TalkToOwl2$37051(this).GetEnumerator();
	}

	// Token: 0x06006E4D RID: 28237 RVA: 0x00F4F1F0 File Offset: 0x00F4D3F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitToTown()
	{
		if (174936 - 548640 != -373704)
		{
		}
		for (;;)
		{
			if (this.HIuc0vF3Gx3 < 1)
			{
				if (98467 - 589879 == -491412)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (238355 - 401485 == -163130)
					{
						if (!gameGui)
						{
							break;
						}
						if (278888 - 31719 != 247170)
						{
							gameGui.newNoticeBar(Language.getMessage("M100_GameTutorial", 161));
							if (257182 - 504125 == -246943)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (242825 - 393599 == -150774)
				{
					Game.mGameState = eGameState.AllHold;
					if (162842 - 550431 == -387589)
					{
						Game.sendMissionEvent(1006, 0);
						if (149041 - 209933 != -60891)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006E4E RID: 28238 RVA: 0x00F4F344 File Offset: 0x00F4D544
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitToColosseum()
	{
		if (142421 - 166605 != -24184)
		{
		}
		for (;;)
		{
			GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
			if (28527 - 83166 == -54639)
			{
				if (!gameGui)
				{
					break;
				}
				if (200201 - 29219 == 170982)
				{
					gameGui.newNoticeBar(Language.getMessage("M100_GameTutorial", 162));
					if (209288 - 407497 == -198209)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006E4F RID: 28239 RVA: 0x00F4F400 File Offset: 0x00F4D600
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (291966 - 97176 != 194790)
		{
		}
		for (;;)
		{
			GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
			if (43068 - 576484 != -533415)
			{
				if (!gameGui)
				{
					break;
				}
				if (62685 - 43446 != 19240)
				{
					gameGui.newNoticeBar(Language.getMessage("M100_GameTutorial", 164));
					if (208385 - 252974 != -44588)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006E50 RID: 28240 RVA: 0x00F4F4BC File Offset: 0x00F4D6BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseMailBox(object mVar)
	{
		if (94608 - 265021 != -170412)
		{
		}
		for (;;)
		{
			GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
			if (136386 - 581930 != -445543)
			{
				if (!gameGui)
				{
					break;
				}
				if (182340 - 598656 != -416315)
				{
					gameGui.newNoticeBar(Language.getMessage("M100_GameTutorial", 164));
					if (217793 - 537572 != -319778)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006E51 RID: 28241 RVA: 0x00F4F578 File Offset: 0x00F4D778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseMessageBoard(int mVar)
	{
		if (175486 - 243694 != -68207)
		{
		}
		for (;;)
		{
			GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
			if (77102 - 95872 != -18769)
			{
				if (!gameGui)
				{
					break;
				}
				if (93121 - 204381 == -111260)
				{
					gameGui.newNoticeBar(Language.getMessage("M100_GameTutorial", 164));
					if (277314 - 47766 != 229549)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006E52 RID: 28242 RVA: 0x00F4F634 File Offset: 0x00F4D834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseTrashBin(int mVar)
	{
		if (164424 - 529228 != -364803)
		{
		}
		for (;;)
		{
			GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
			if (39495 - 501534 == -462039)
			{
				if (!gameGui)
				{
					break;
				}
				if (171046 - 41781 != 129266)
				{
					gameGui.newNoticeBar(Language.getMessage("M100_GameTutorial", 164));
					if (160183 - 429761 != -269577)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006E53 RID: 28243 RVA: 0x00F4F6F0 File Offset: 0x00F4D8F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseStorageBox(object mVar)
	{
		if (165615 - 183894 != -18278)
		{
		}
		for (;;)
		{
			GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
			if (199493 - 447242 == -247749)
			{
				if (!gameGui)
				{
					break;
				}
				if (95244 - 61561 != 33684)
				{
					gameGui.newNoticeBar(Language.getMessage("M100_GameTutorial", 164));
					if (219672 - 520692 != -301019)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006E54 RID: 28244 RVA: 0x00F4F7AC File Offset: 0x00F4D9AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(object mVar)
	{
		return new M100_GameTutorial2.$UseSignPost$37059(this).GetEnumerator();
	}

	// Token: 0x06006E55 RID: 28245 RVA: 0x00F4F7BC File Offset: 0x00F4D9BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseFirstTailShrine(object mVar)
	{
		return new M100_GameTutorial2.$UseFirstTailShrine$37062(this).GetEnumerator();
	}

	// Token: 0x06006E56 RID: 28246 RVA: 0x00F4F7CC File Offset: 0x00F4D9CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (150685 - 14230 != 136455)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (155098 - 399659 != -244560)
			{
				Time.timeScale = 1f;
				if (264947 - 402197 != -137249)
				{
					Hashtable customOpParameters = new Hashtable();
					if (69780 - 255970 != -186189)
					{
						this.zIXcB9uqqWD.OpCustom(52, customOpParameters, true);
						if (217489 - 519905 != -302415)
						{
							this.InitTutorialGui();
							if (265798 - 527793 != -261994)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006E57 RID: 28247 RVA: 0x00F4F8B8 File Offset: 0x00F4DAB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (204162 - 469450 != -265288)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (272088 - 583057 != -310968)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (49039 - 424544 != -375504)
				{
					Game.mGameState = eGameState.Setup;
					if (157564 - 244278 != -86713)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006E58 RID: 28248 RVA: 0x00F4F95C File Offset: 0x00F4DB5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (229801 - 44342 != 185459)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (46450 - 86105 == -39655)
			{
				if (num == PlayerData.UID)
				{
					if (256997 - 540652 != -283654)
					{
						this.SetupActors();
						if (222273 - 54696 != 167578)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (285245 - 103352 == 181893)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006E59 RID: 28249 RVA: 0x00F4FA2C File Offset: 0x00F4DC2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (271456 - 116101 != 155355)
		{
		}
		for (;;)
		{
			IL_160:
			Debug.Log("Creating Actors");
			if (262943 - 80202 == 182741)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (28292 - 595543 != -567250)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (11596 - 125830 != -114233)
						{
							int i = 0;
							if (218460 - 356711 != -138250)
							{
								CharacterControl[] array2 = array;
								if (59930 - 492377 != -432446)
								{
									int length = array2.Length;
									if (261410 - 570930 == -309520)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (124381 - 139542 != -15161)
												{
													goto IL_160;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (290397 - 304051 == -13653)
												{
													goto IL_160;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (43001 - 379089 != -336088)
												{
													goto IL_160;
												}
												this.I1ec01dGUXG++;
												if (178146 - 117322 != 60824)
												{
													goto IL_160;
												}
											}
											i++;
											if (144401 - 467326 == -322924)
											{
												goto IL_160;
											}
										}
										if (218324 - 14290 == 204034)
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
						if (16328 - 506934 == -490606)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006E5A RID: 28250 RVA: 0x00F4FC68 File Offset: 0x00F4DE68
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (274749 - 496162 != -221413)
		{
		}
		for (;;)
		{
			IL_A0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (207374 - 459838 != -252463)
			{
				int i = 0;
				if (286703 - 544291 == -257588)
				{
					CharacterControl[] array2 = array;
					if (45529 - 545363 == -499834)
					{
						int length = array2.Length;
						if (114708 - 353591 == -238883)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (245517 - 381495 != -135978)
								{
									goto IL_A0;
								}
								i++;
								if (185940 - 222065 != -36125)
								{
									goto IL_A0;
								}
							}
							if (149489 - 440521 == -291032)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006E5B RID: 28251 RVA: 0x00F4FD98 File Offset: 0x00F4DF98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (174480 - 543189 != -368709)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (152671 - 20880 == 131791)
			{
				Game.mGameState = eGameState.Ready;
				if (87217 - 576514 == -489297)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (249298 - 581731 == -332433)
					{
						if (154408 - 430467 == -276059)
						{
							GameObject gameObject = null;
							if (131447 - 552664 == -421217)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (102742 - 297189 == -194446)
									{
										continue;
									}
									if (playerSlot <= 12)
									{
										if (80939 - 265146 != -184207)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (221648 - 275527 == -53878)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (31088 - 434932 != -403843)
										{
											goto IL_A5;
										}
										continue;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (189322 - 304632 != -115310)
								{
									continue;
								}
								IL_A5:
								if (gameObject2)
								{
									if (37343 - 485534 != -448191)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (60322 - 451226 != -390904)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (7326 - 584465 == -577138)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (75698 - 156128 == -80429)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (221368 - 135343 == 86026)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (27112 - 374918 == -347806)
								{
									this.transform.position = gameObject.transform.position;
									if (140704 - 284977 != -144272)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (88175 - 432959 != -344783)
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

	// Token: 0x06006E5C RID: 28252 RVA: 0x00F500BC File Offset: 0x00F4E2BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (187721 - 79976 != 107745)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (282754 - 493493 != -210738)
			{
				Game.mGameState = eGameState.Start;
				if (210251 - 18373 != 191879)
				{
					Game.mStateTime = Time.time;
					if (42091 - 452892 == -410801)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (139453 - 9323 != 130131)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006E5D RID: 28253 RVA: 0x00F50184 File Offset: 0x00F4E384
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06006E5E RID: 28254 RVA: 0x00F50188 File Offset: 0x00F4E388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (123935 - 72628 != 51308)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (197728 - 489001 == -291273)
			{
				if (gameObject)
				{
					if (150563 - 586758 != -436194)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (118079 - 141226 != -23146)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (278188 - 371960 != -93771)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006E5F RID: 28255 RVA: 0x00F50284 File Offset: 0x00F4E484
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (132578 - 391974 != -259395)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (39638 - 153430 != -113791)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (63717 - 335630 != -271912)
				{
					hashtable.Add(43, PlayerData.UID);
					if (237259 - 17947 != 219313)
					{
						hashtable.Add(73, nType);
						if (209112 - 473103 != -263990)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (56713 - 21984 == 34729)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (207021 - 400244 != -193222)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (76204 - 424042 == -347838)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (176041 - 559218 != -383176)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (5178 - 206190 != -201011)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (226115 - 372326 != -146210)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (248454 - 322248 != -73793)
													{
														this.zIXcB9uqqWD.OpCustom(63, hashtable, true);
														if (87268 - 305509 == -218241)
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

	// Token: 0x06006E60 RID: 28256 RVA: 0x00F50568 File Offset: 0x00F4E768
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (280272 - 52088 != 228184)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (241787 - 268791 == -27004)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (179015 - 478604 == -299589)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (35819 - 347512 == -311693)
						{
							if (this.I1ec01dGUXG <= 0)
							{
								break;
							}
							if (33369 - 311315 == -277946)
							{
								this.I1ec01dGUXG--;
								if (68008 - 553118 != -485109)
								{
									if (this.I1ec01dGUXG != 0)
									{
										break;
									}
									if (71459 - 155218 == -83759)
									{
										Game.setGameState(eGameState.Ready);
										if (153356 - 252796 != -99439)
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
						if (59092 - 209831 == -150739)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (248124 - 316818 == -68694)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006E61 RID: 28257 RVA: 0x00F506F8 File Offset: 0x00F4E8F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06006E62 RID: 28258 RVA: 0x00F5070C File Offset: 0x00F4E90C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (11172 - 430806 != -419633)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (228961 - 334659 == -105698)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (292336 - 115703 != 176634)
				{
					if (!characterControl)
					{
						break;
					}
					if (264577 - 429959 == -165382)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (109040 - 342012 != -232971)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (78478 - 292263 == -213785)
							{
								string type = characterControl.Type;
								if (86938 - 430768 == -343830)
								{
									if (!(type == string.Empty))
									{
										break;
									}
									if (201474 - 373149 != -171674)
									{
										Game.sendMissionEvent(0, 0);
										if (282899 - 144903 != 137997)
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

	// Token: 0x06006E63 RID: 28259 RVA: 0x00F50880 File Offset: 0x00F4EA80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (184163 - 526973 != -342809)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (71426 - 359978 != -288551)
			{
				hashtable.Add(71, CID);
				if (4748 - 382813 == -378065)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (26928 - 285658 == -258730)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (57181 - 571434 != -514252)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (40016 - 169762 == -129746)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (106423 - 200185 == -93762)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (52786 - 571796 != -519009)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (157802 - 566578 == -408776)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (34464 - 510354 == -475890)
											{
												this.zIXcB9uqqWD.OpCustom(61, hashtable, true);
												if (96101 - 20520 == 75581)
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

	// Token: 0x06006E64 RID: 28260 RVA: 0x00F50B0C File Offset: 0x00F4ED0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (10506 - 165136 != -154630)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (297804 - 186798 == 111006)
			{
				if (!gameObject)
				{
					break;
				}
				if (118892 - 359256 == -240364)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (263172 - 92626 != 170547)
					{
						playerCameraControl.target = gameObject;
						if (19960 - 240155 == -220195)
						{
							this.StartGame();
							if (99954 - 14692 != 85263)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006E65 RID: 28261 RVA: 0x00F50BFC File Offset: 0x00F4EDFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (17331 - 21282 != -3951)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (22102 - 178344 == -156242)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (257932 - 103418 == 154514)
				{
					gameGui.ResetTeamBar();
					if (296000 - 564393 == -268393)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006E66 RID: 28262 RVA: 0x00F50CA8 File Offset: 0x00F4EEA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M100_GameTutorial2.$onDeadPlayer$37066(this).GetEnumerator();
	}

	// Token: 0x06006E67 RID: 28263 RVA: 0x00F50CB8 File Offset: 0x00F4EEB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (115080 - 422907 != -307827)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (282857 - 34464 != 248394)
			{
				this.rUhcBWrk3Ls.target = Game.mPlayer;
				if (188321 - 402573 != -214251)
				{
					this.rUhcBWrk3Ls.enabled = true;
					if (9007 - 136893 != -127885)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (233340 - 443698 != -210358)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (21203 - 139488 != -118285)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (92696 - 369933 == -277237)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (76342 - 450716 == -374374)
							{
								if (!gameGui)
								{
									break;
								}
								if (230221 - 408380 == -178159)
								{
									gameGui.enabled = true;
									if (269971 - 317506 != -47534)
									{
										gameGui.closeDeadMenu();
										if (254395 - 148550 == 105845)
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

	// Token: 0x06006E68 RID: 28264 RVA: 0x00F50E64 File Offset: 0x00F4F064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (117209 - 211387 != -94178)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (6720 - 168484 == -161764)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (233555 - 81249 == 152306)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (293881 - 197484 != 96398)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006E69 RID: 28265 RVA: 0x00F50F28 File Offset: 0x00F4F128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06006E6A RID: 28266 RVA: 0x00F50F54 File Offset: 0x00F4F154
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (58267 - 189439 != -131172)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (249306 - 82635 == 166671)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (69892 - 1525 == 68367)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (296075 - 537088 != -241012)
					{
						Hashtable hashtable = new Hashtable();
						if (138935 - 447601 == -308666)
						{
							hashtable.Add(43, PlayerData.UID);
							if (9495 - 21181 != -11685)
							{
								hashtable.Add(71, nCID);
								if (203467 - 277542 != -74074)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (127658 - 451294 != -323635)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (269965 - 564296 == -294331)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (222794 - 411201 != -188406)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (150380 - 478944 != -328563)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (247539 - 476396 == -228857)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (211006 - 431463 == -220457)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (178735 - 199859 != -21123)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (107432 - 545745 != -438312)
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

	// Token: 0x06006E6B RID: 28267 RVA: 0x00F51274 File Offset: 0x00F4F474
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M100_GameTutorial2.$onChangePlayer$37072(data, this).GetEnumerator();
	}

	// Token: 0x06006E6C RID: 28268 RVA: 0x00F51284 File Offset: 0x00F4F484
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M100_GameTutorial2.$onGameComplete$37079(data, this).GetEnumerator();
	}

	// Token: 0x06006E6D RID: 28269 RVA: 0x00F51294 File Offset: 0x00F4F494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M100_GameTutorial2.$ReturnToTown$37089(this).GetEnumerator();
	}

	// Token: 0x06006E6E RID: 28270 RVA: 0x00F512A4 File Offset: 0x00F4F4A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M100_GameTutorial2.$ReturnToGuild$37094(this).GetEnumerator();
	}

	// Token: 0x06006E6F RID: 28271 RVA: 0x00F512B4 File Offset: 0x00F4F4B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M100_GameTutorial2.$ReturnToCamp$37098(this).GetEnumerator();
	}

	// Token: 0x06006E70 RID: 28272 RVA: 0x00F512C4 File Offset: 0x00F4F4C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (35153 - 140015 != -104862)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (154045 - 230654 != -76608)
			{
				Hashtable hashtable = new Hashtable();
				if (104047 - 160891 == -56844)
				{
					hashtable.Add(43, PlayerData.UID);
					if (293535 - 561944 != -268408)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (69262 - 73784 == -4522)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006E71 RID: 28273 RVA: 0x00F5139C File Offset: 0x00F4F59C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06006E72 RID: 28274 RVA: 0x00F513B0 File Offset: 0x00F4F5B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (71749 - 195762 != -124012)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (141548 - 324557 != -183008)
			{
				Hashtable hashtable = new Hashtable();
				if (175016 - 376305 == -201289)
				{
					if (Game.mNextGameCode == 30)
					{
						if (75021 - 46813 != 28208)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (118235 - 8570 != 109665)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (189928 - 525522 != -335594)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (141883 - 172751 != -30868)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (247743 - 144919 == 102825)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (227213 - 191462 != 35751)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (129131 - 425798 != -296667)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (42198 - 454782 == -412583)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (241626 - 583161 == -341534)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (176597 - 508477 == -331879)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (97902 - 203967 != -106065)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (216762 - 421302 == -204539)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (118289 - 73953 != 44336)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (247470 - 117678 != 129792)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (71678 - 326590 == -254911)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (34510 - 274736 == -240225)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (27522 - 368982 == -341459)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (223840 - 174392 == 49449)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (179618 - 116843 != 62775)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (3198 - 396924 == -393725)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (149709 - 397733 == -248023)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (247082 - 397430 != -150348)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (217417 - 500823 != -283406)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (30744 - 373931 != -343187)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (205068 - 198392 == 6677)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (128803 - 107245 != 21558)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (167821 - 409912 == -242090)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (298409 - 507133 != -208724)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (211997 - 259153 != -47155)
					{
						this.zIXcB9uqqWD.OpCustom(42, hashtable, true);
						if (234974 - 153828 == 81146)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006E73 RID: 28275 RVA: 0x00F51964 File Offset: 0x00F4FB64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06006E74 RID: 28276 RVA: 0x00F51974 File Offset: 0x00F4FB74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006E75 RID: 28277 RVA: 0x00F51978 File Offset: 0x00F4FB78
	internal static bool LXBnkkpFgawbSLXuqF68()
	{
		return true;
	}

	// Token: 0x06006E76 RID: 28278 RVA: 0x00F5197C File Offset: 0x00F4FB7C
	internal static bool Lp67PEpFfDTA6wkYYh4b()
	{
		return false;
	}

	// Token: 0x040075CD RID: 30157
	private LitePeer zIXcB9uqqWD;

	// Token: 0x040075CE RID: 30158
	private PlayerCameraControl rUhcBWrk3Ls;

	// Token: 0x040075CF RID: 30159
	private float AmUcBuY1nrn;

	// Token: 0x040075D0 RID: 30160
	private Texture YxUcBy1flW1;

	// Token: 0x040075D1 RID: 30161
	private Texture iFBcBVHc3T2;

	// Token: 0x040075D2 RID: 30162
	private Texture DsAcBhYcY3w;

	// Token: 0x040075D3 RID: 30163
	private Texture VwycBKr5h5G;

	// Token: 0x040075D4 RID: 30164
	private GUIStyle JNUcBzdNcbL;

	// Token: 0x040075D5 RID: 30165
	private GUIStyle B68c05fmZY0;

	// Token: 0x040075D6 RID: 30166
	private int w7uc0csxsg4;

	// Token: 0x040075D7 RID: 30167
	private GUIStyle aWSc0nZSuMP;

	// Token: 0x040075D8 RID: 30168
	private GUIStyle Dlxc0QocGkX;

	// Token: 0x040075D9 RID: 30169
	private GUIStyle xjjc0eS5v9y;

	// Token: 0x040075DA RID: 30170
	private AudioClip k0ic0IMlm0U;

	// Token: 0x040075DB RID: 30171
	private AudioClip FLac0JcN29t;

	// Token: 0x040075DC RID: 30172
	private AudioClip CQQc06SIZUC;

	// Token: 0x040075DD RID: 30173
	private AudioClip eVOc0tYaoMI;

	// Token: 0x040075DE RID: 30174
	private int qWIc0Xv3k0c;

	// Token: 0x040075DF RID: 30175
	private int v0Nc0ObAiKy;

	// Token: 0x040075E0 RID: 30176
	private int olpc02rkvCo;

	// Token: 0x040075E1 RID: 30177
	private int HIuc0vF3Gx3;

	// Token: 0x040075E2 RID: 30178
	private int lCKc0lKgWUJ;

	// Token: 0x040075E3 RID: 30179
	private int Fgbc0GX6TVY;

	// Token: 0x040075E4 RID: 30180
	private int I1ec01dGUXG;

	// Token: 0x020012B8 RID: 4792
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$37018 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006E77 RID: 28279 RVA: 0x00F51980 File Offset: 0x00F4FB80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$37018(Hashtable data, M100_GameTutorial2 self_)
		{
			if (165799 - 467636 != -301837)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (283134 - 390138 != -107003)
				{
					base..ctor();
					if (280645 - 458663 != -178017)
					{
						this.$data$37026 = data;
						if (147921 - 184664 == -36743)
						{
							this.$self_$37027 = self_;
							if (211734 - 10883 != 200852)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006E78 RID: 28280 RVA: 0x00F51A3C File Offset: 0x00F4FC3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial2.$onGameEvent$37018.$(this.$data$37026, this.$self_$37027);
		}

		// Token: 0x06006E79 RID: 28281 RVA: 0x00F51A50 File Offset: 0x00F4FC50
		internal static bool BUMTl9pFnVjw1I7kPiRT()
		{
			return true;
		}

		// Token: 0x06006E7A RID: 28282 RVA: 0x00F51A54 File Offset: 0x00F4FC54
		internal static bool OSFdV4pF6RsfAhXqbCQD()
		{
			return false;
		}

		// Token: 0x040075E5 RID: 30181
		internal Hashtable $data$37026;

		// Token: 0x040075E6 RID: 30182
		internal M100_GameTutorial2 $self_$37027;

		// Token: 0x020012B9 RID: 4793
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006E7B RID: 28283 RVA: 0x00F51A58 File Offset: 0x00F4FC58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M100_GameTutorial2 self_)
			{
				if (187362 - 385100 != -197737)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (176620 - 18281 == 158339)
					{
						base..ctor();
						if (144861 - 205489 == -60628)
						{
							this.$data$37024 = data;
							if (102588 - 468634 != -366045)
							{
								this.$self_$37025 = self_;
								if (201421 - 401507 == -200086)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006E7C RID: 28284 RVA: 0x00F51B14 File Offset: 0x00F4FD14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (164922 - 171396 != -6474)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2CF;
					case 2:
						Application.LoadLevel("M100_GameTutorial3");
						if (278496 - 374071 != -95575)
						{
							continue;
						}
						goto IL_1B2;
					default:
						if (111628 - 28862 == 82767)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (174185 - 465524 != -291338)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$37019 = RuntimeServices.UnboxInt32(this.$data$37024[141]);
						if (272725 - 239975 == 32751)
						{
							continue;
						}
						this.$returnValue$37020 = RuntimeServices.UnboxInt32(this.$data$37024[145]);
						if (211188 - 345408 == -134219)
						{
							continue;
						}
						this.$ownerID$37021 = RuntimeServices.UnboxInt32(this.$data$37024[43]);
						if (93156 - 181153 != -87997)
						{
							continue;
						}
						this.$$switch$6236$37022 = this.$returnCode$37019;
						if (298127 - 159192 == 138936)
						{
							continue;
						}
						if (this.$$switch$6236$37022 == 1006)
						{
							if (144216 - 417944 == -273727)
							{
								continue;
							}
							Game.mGameState = eGameState.AllHold;
							if (295918 - 5729 != 290189)
							{
								continue;
							}
							this.$mGameGui$37023 = (GameGui)this.$self_$37025.GetComponent(typeof(GameGui));
							if (147886 - 375388 == -227501)
							{
								continue;
							}
							this.$mGameGui$37023.close();
							if (265150 - 36657 == 228494)
							{
								continue;
							}
							Game.savePlayer();
							if (263186 - 51076 != 212110)
							{
								continue;
							}
							this.$self_$37025.SendMessage("fadeOut");
							if (225541 - 338852 != -113310)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$37019);
							if (162691 - 201478 != -38787)
							{
								continue;
							}
						}
					}
					IL_1B2:
					this.YieldDefault(1);
				}
				while (52809 - 12888 == 39922);
				goto IL_2CF;
				Block_12:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_2CF:
				return false;
			}

			// Token: 0x06006E7D RID: 28285 RVA: 0x00F51E04 File Offset: 0x00F50004
			internal static bool G9JW4WpFimKZ5voSU7Kr()
			{
				return true;
			}

			// Token: 0x06006E7E RID: 28286 RVA: 0x00F51E08 File Offset: 0x00F50008
			internal static bool AnUDEapFKNxlBD7RpAan()
			{
				return false;
			}

			// Token: 0x040075E7 RID: 30183
			internal int $returnCode$37019;

			// Token: 0x040075E8 RID: 30184
			internal int $returnValue$37020;

			// Token: 0x040075E9 RID: 30185
			internal int $ownerID$37021;

			// Token: 0x040075EA RID: 30186
			internal int $$switch$6236$37022;

			// Token: 0x040075EB RID: 30187
			internal GameGui $mGameGui$37023;

			// Token: 0x040075EC RID: 30188
			internal Hashtable $data$37024;

			// Token: 0x040075ED RID: 30189
			internal M100_GameTutorial2 $self_$37025;
		}
	}

	// Token: 0x020012BA RID: 4794
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$37028 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006E7F RID: 28287 RVA: 0x00F51E0C File Offset: 0x00F5000C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$37028(M100_GameTutorial2 self_)
		{
			if (1800 - 537868 != -536068)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (246179 - 360192 == -114013)
				{
					base..ctor();
					if (242939 - 321295 == -78356)
					{
						this.$self_$37034 = self_;
						if (126251 - 515791 != -389539)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006E80 RID: 28288 RVA: 0x00F51EA4 File Offset: 0x00F500A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial2.$StartEvent$37028.$(this.$self_$37034);
		}

		// Token: 0x06006E81 RID: 28289 RVA: 0x00F51EB4 File Offset: 0x00F500B4
		internal static bool z6JrlcpFdFZaxVY2L6KS()
		{
			return true;
		}

		// Token: 0x06006E82 RID: 28290 RVA: 0x00F51EB8 File Offset: 0x00F500B8
		internal static bool NqN84PpFJ97MMpOZBDkW()
		{
			return false;
		}

		// Token: 0x040075EE RID: 30190
		internal M100_GameTutorial2 $self_$37034;

		// Token: 0x020012BB RID: 4795
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006E83 RID: 28291 RVA: 0x00F51EBC File Offset: 0x00F500BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial2 self_)
			{
				if (124894 - 117643 != 7252)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (12159 - 590998 != -578838)
					{
						base..ctor();
						if (263703 - 550193 != -286489)
						{
							this.$self_$37033 = self_;
							if (222735 - 243972 != -21236)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006E84 RID: 28292 RVA: 0x00F51F54 File Offset: 0x00F50154
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (184409 - 525449 != -341040)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_10F9;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (247703 - 286951 != -39247)
							{
								goto Block_41;
							}
							continue;
						}
						else
						{
							this.$self_$37033.rUhcBWrk3Ls.alignToObject("EventCamera2");
							if (91802 - 225801 != -133998)
							{
								goto Block_71;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (2942 - 596777 != -593834)
							{
								goto Block_47;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$37029 = (StoryGui)this.$self_$37033.GetComponent(typeof(StoryGui));
							if (262442 - 473713 == -211270)
							{
								continue;
							}
							this.$mStoryTimer$37030 = 0f;
							if (283406 - 423298 != -139892)
							{
								continue;
							}
							if (!this.$mStoryGui$37029)
							{
								if (7928 - 185894 != -177966)
								{
									continue;
								}
								goto IL_E7;
							}
							else
							{
								this.$mKangaroo$37031 = GameObject.Find("Kangaroo");
								if (226917 - 542346 == -315428)
								{
									continue;
								}
								this.$mStoryGui$37029.startStoryMessage("Kangaroo", "Kuru", eTalkType.friend);
								if (141160 - 407921 != -266760)
								{
									goto Block_10;
								}
								continue;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (221985 - 233504 != -11518)
							{
								goto Block_99;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$37029.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 101), eTalkType.friend);
							if (247837 - 7735 != 240102)
							{
								continue;
							}
							this.$self_$37033.rUhcBWrk3Ls.StartCoroutine_Auto(this.$self_$37033.rUhcBWrk3Ls.slerpToObject("EventCamera3", (float)2));
							if (266178 - 502997 == -236818)
							{
								continue;
							}
							if (this.$mKangaroo$37031)
							{
								if (208119 - 186015 != 22104)
								{
									continue;
								}
								this.$mKangaroo$37031.animation.CrossFade("talk", 0.2f);
								if (110015 - 112000 == -1984)
								{
									continue;
								}
							}
							this.$mStoryTimer$37030 = Time.time + 4f;
							if (191605 - 572777 != -381172)
							{
								continue;
							}
							goto IL_207;
						}
						break;
					case 5:
						goto IL_22E;
					case 6:
						goto IL_22E;
					case 7:
						goto IL_E58;
					case 8:
						goto IL_E58;
					case 9:
						goto IL_347;
					case 10:
						goto IL_347;
					case 11:
						goto IL_F18;
					case 12:
						goto IL_F18;
					case 13:
						goto IL_C31;
					case 14:
						goto IL_C31;
					case 15:
						goto IL_10A4;
					case 16:
						goto IL_10A4;
					case 17:
						goto IL_FFE;
					case 18:
						goto IL_FFE;
					case 19:
						goto IL_81E;
					case 20:
						goto IL_81E;
					case 21:
						goto IL_586;
					case 22:
						goto IL_871;
					case 23:
						goto IL_871;
					case 24:
						goto IL_520;
					case 25:
						goto IL_520;
					case 26:
						if (Game.mGameState != eGameState.Start)
						{
							if (233936 - 215040 != 18896)
							{
								continue;
							}
							goto IL_42B;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (69504 - 591954 != -522450)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (1748 - 152788 != -151040)
							{
								continue;
							}
							this.$mGameGui$37032 = (GameGui)this.$self_$37033.GetComponent(typeof(GameGui));
							if (136912 - 364507 == -227594)
							{
								continue;
							}
							this.$mGameGui$37032.enabled = true;
							if (250635 - 22952 == 227684)
							{
								continue;
							}
							this.$self_$37033.SendMessage("newGameMessage", "New Mission Objective: Talk to NPC 0/2");
							if (69481 - 559713 != -490232)
							{
								continue;
							}
							Chat.SubmitChat("none", "New Mission Objective: Talk to NPC 0/2", eChatType.system, eChatMode.system);
							if (272919 - 318034 != -45115)
							{
								continue;
							}
							this.YieldDefault(1);
							if (240931 - 10576 != 230356)
							{
								goto Block_87;
							}
							continue;
						}
						break;
					default:
						if (121641 - 66032 != 55609)
						{
							continue;
						}
						break;
					}
					this.$self_$37033.rUhcBWrk3Ls.alignToObject("EventCamera1");
					if (15203 - 8684 == 6520)
					{
						continue;
					}
					this.$self_$37033.SendMessage("fadeIn");
					if (136943 - 421161 != -284217)
					{
						goto Block_28;
					}
					continue;
					IL_10A4:
					if (this.$mStoryTimer$37030 > Time.time)
					{
						if (212817 - 375135 != -162318)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1097;
						}
						if (297050 - 367849 == -70798)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (279870 - 486645 != -206774)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37029.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 107), eTalkType.friend);
						if (287707 - 334896 != -47189)
						{
							continue;
						}
						this.$mStoryTimer$37030 = Time.time + 4f;
						if (15265 - 554586 != -539320)
						{
							goto Block_107;
						}
						continue;
					}
					IL_22E:
					if (this.$mStoryTimer$37030 > Time.time)
					{
						if (1896 - 384557 != -382661)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_222;
						}
						if (46932 - 511980 == -465047)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (199473 - 539826 != -340353)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37029.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 102), eTalkType.friend);
						if (144439 - 254946 != -110507)
						{
							continue;
						}
						this.$mStoryTimer$37030 = Time.time + 4f;
						if (75550 - 116872 != -41321)
						{
							goto Block_15;
						}
						continue;
					}
					IL_C31:
					if (this.$mStoryTimer$37030 > Time.time)
					{
						if (283261 - 408408 != -125147)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_C24;
						}
						if (13198 - 152775 != -139577)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (37165 - 36719 != 446)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37029.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 106), eTalkType.friend);
						if (165363 - 85798 == 79566)
						{
							continue;
						}
						this.$self_$37033.rUhcBWrk3Ls.StartCoroutine_Auto(this.$self_$37033.rUhcBWrk3Ls.slerpToObject("EventCamera4", (float)2));
						if (186293 - 571652 == -385358)
						{
							continue;
						}
						this.$mStoryTimer$37030 = Time.time + 4f;
						if (68727 - 240729 != -172001)
						{
							goto Block_76;
						}
						continue;
					}
					IL_E58:
					if (this.$mStoryTimer$37030 > Time.time)
					{
						if (75049 - 451261 == -376211)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_E4C;
						}
						if (64026 - 78956 == -14929)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (178453 - 433259 != -254806)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37029.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 103), eTalkType.friend);
						if (45135 - 306685 == -261549)
						{
							continue;
						}
						this.$mStoryTimer$37030 = Time.time + 4f;
						if (204287 - 353328 != -149041)
						{
							continue;
						}
						goto IL_31E;
					}
					IL_347:
					if (this.$mStoryTimer$37030 > Time.time)
					{
						if (156453 - 415535 != -259082)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_33A;
						}
						if (14203 - 314314 == -300110)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (93649 - 425941 != -332291)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37029.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 104), eTalkType.friend);
						if (290758 - 539332 != -248574)
						{
							continue;
						}
						this.$mStoryTimer$37030 = Time.time + 4f;
						if (228941 - 494738 != -265797)
						{
							continue;
						}
						goto IL_EEF;
					}
					IL_F18:
					if (this.$mStoryTimer$37030 > Time.time)
					{
						if (193833 - 333319 != -139486)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_F0B;
						}
						if (159564 - 38926 != 120638)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (106281 - 359456 != -253174)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37029.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 105), eTalkType.friend);
						if (39046 - 581124 == -542077)
						{
							continue;
						}
						this.$mStoryTimer$37030 = Time.time + 4f;
						if (134205 - 518829 != -384624)
						{
							continue;
						}
						goto IL_C08;
					}
					IL_871:
					if (this.$mStoryTimer$37030 > Time.time)
					{
						if (145627 - 188451 == -42823)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_864;
						}
						if (104528 - 7469 != 97059)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (178021 - 214255 != -36233)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37029.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 110), eTalkType.friend);
						if (83161 - 362664 == -279502)
						{
							continue;
						}
						if (this.$mKangaroo$37031)
						{
							if (159565 - 282083 != -122518)
							{
								continue;
							}
							this.$mKangaroo$37031.animation.Play("root");
							if (30371 - 519237 == -488865)
							{
								continue;
							}
						}
						this.$mStoryTimer$37030 = Time.time + 4f;
						if (51838 - 226997 != -175158)
						{
							goto Block_88;
						}
						continue;
					}
					IL_520:
					if (this.$mStoryTimer$37030 > Time.time)
					{
						if (105623 - 352284 != -246661)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_513;
						}
						if (163397 - 521337 == -357939)
						{
							continue;
						}
					}
					this.$mStoryGui$37029.close();
					if (13684 - 575501 == -561816)
					{
						continue;
					}
					this.$self_$37033.rUhcBWrk3Ls.enabled = true;
					if (87427 - 100115 != -12687)
					{
						goto Block_110;
					}
					continue;
					IL_586:
					if (this.$self_$37033.v0Nc0ObAiKy == 400)
					{
						goto IL_579;
					}
					if (299294 - 501958 != -202664)
					{
						continue;
					}
					this.$mStoryGui$37029.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 109), eTalkType.friend);
					if (263116 - 115673 == 147444)
					{
						continue;
					}
					this.$self_$37033.rUhcBWrk3Ls.StartCoroutine_Auto(this.$self_$37033.rUhcBWrk3Ls.slerpToObject("EventCamera5", (float)2));
					if (211652 - 227447 != -15795)
					{
						continue;
					}
					this.$mStoryTimer$37030 = Time.time + 4f;
					if (101876 - 8948 != 92928)
					{
						continue;
					}
					goto IL_848;
					IL_81E:
					if (this.$mStoryTimer$37030 > Time.time)
					{
						if (274606 - 345311 == -70704)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_811;
						}
						if (48214 - 242554 == -194339)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (183074 - 340656 != -157581)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37029.blank();
						if (38958 - 273494 == -234535)
						{
							continue;
						}
						this.$self_$37033.v0Nc0ObAiKy = 400;
						if (250486 - 2212 != 248275)
						{
							goto IL_586;
						}
						continue;
					}
					IL_FFE:
					if (this.$mStoryTimer$37030 > Time.time)
					{
						if (157507 - 443792 == -286284)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_FF1;
						}
						if (111077 - 543271 != -432194)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (125851 - 297324 == -171473)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$37029.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 108), eTalkType.friend);
						if (244263 - 374073 == -129810)
						{
							this.$mStoryTimer$37030 = Time.time + 4f;
							if (136970 - 88107 != 48864)
							{
								goto Block_91;
							}
						}
					}
				}
				IL_E7:
				goto IL_10F9;
				Block_10:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_15:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_207:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_222:
				return this.YieldDefault(6);
				goto IL_10F9;
				IL_31E:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_33A:
				return this.YieldDefault(10);
				goto IL_10F9;
				Block_28:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_42B:
				goto IL_10F9;
				IL_513:
				return this.YieldDefault(25);
				IL_579:
				return this.YieldDefault(21);
				Block_41:
				Block_47:
				goto IL_10F9;
				IL_811:
				return this.YieldDefault(20);
				IL_848:
				return this.Yield(22, new WaitForSeconds(1f));
				IL_864:
				return this.YieldDefault(23);
				Block_71:
				return this.Yield(3, new WaitForSeconds(0.5f));
				goto IL_10F9;
				Block_76:
				return this.Yield(15, new WaitForSeconds(1f));
				goto IL_10F9;
				IL_C08:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_C24:
				return this.YieldDefault(14);
				Block_87:
				goto IL_10F9;
				Block_88:
				return this.Yield(24, new WaitForSeconds(0.5f));
				goto IL_10F9;
				Block_91:
				return this.Yield(19, new WaitForSeconds(0.5f));
				Block_99:
				goto IL_10F9;
				IL_E4C:
				return this.YieldDefault(8);
				Block_107:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_EEF:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_F0B:
				return this.YieldDefault(12);
				Block_110:
				return this.Yield(26, new WaitForSeconds(0.5f));
				goto IL_10F9;
				IL_FF1:
				return this.YieldDefault(18);
				IL_1097:
				return this.YieldDefault(16);
				IL_10F9:
				return false;
			}

			// Token: 0x06006E85 RID: 28293 RVA: 0x00F5306C File Offset: 0x00F5126C
			internal static bool hlvYH9pFDKMcVyelTDe9()
			{
				return true;
			}

			// Token: 0x06006E86 RID: 28294 RVA: 0x00F53070 File Offset: 0x00F51270
			internal static bool Rk3yfMpFv5fHLnwkAoYg()
			{
				return false;
			}

			// Token: 0x040075EF RID: 30191
			internal StoryGui $mStoryGui$37029;

			// Token: 0x040075F0 RID: 30192
			internal float $mStoryTimer$37030;

			// Token: 0x040075F1 RID: 30193
			internal GameObject $mKangaroo$37031;

			// Token: 0x040075F2 RID: 30194
			internal GameGui $mGameGui$37032;

			// Token: 0x040075F3 RID: 30195
			internal M100_GameTutorial2 $self_$37033;
		}
	}

	// Token: 0x020012BC RID: 4796
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToKangaroo$37035 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006E87 RID: 28295 RVA: 0x00F53074 File Offset: 0x00F51274
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToKangaroo$37035(M100_GameTutorial2 self_)
		{
			if (194494 - 365324 != -170829)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (21623 - 23153 == -1530)
				{
					base..ctor();
					if (154510 - 36311 != 118200)
					{
						this.$self_$37042 = self_;
						if (26650 - 220980 != -194329)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006E88 RID: 28296 RVA: 0x00F5310C File Offset: 0x00F5130C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial2.$TalkToKangaroo$37035.$(this.$self_$37042);
		}

		// Token: 0x06006E89 RID: 28297 RVA: 0x00F5311C File Offset: 0x00F5131C
		internal static bool hKBJUEpFRNyPmprP4ket()
		{
			return true;
		}

		// Token: 0x06006E8A RID: 28298 RVA: 0x00F53120 File Offset: 0x00F51320
		internal static bool MljA1HpFwumv28Kd24DY()
		{
			return false;
		}

		// Token: 0x040075F4 RID: 30196
		internal M100_GameTutorial2 $self_$37042;

		// Token: 0x020012BD RID: 4797
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006E8B RID: 28299 RVA: 0x00F53124 File Offset: 0x00F51324
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial2 self_)
			{
				if (272885 - 215771 != 57115)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (148163 - 271869 == -123706)
					{
						base..ctor();
						if (104890 - 189015 == -84125)
						{
							this.$self_$37041 = self_;
							if (90403 - 56466 == 33937)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006E8C RID: 28300 RVA: 0x00F531BC File Offset: 0x00F513BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (201706 - 231948 != -30242)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_87A;
					case 1:
						goto IL_12C8;
					case 2:
						if (this.$mKangaroo$37037)
						{
							if (159767 - 130075 == 29693)
							{
								continue;
							}
							this.$mKangaroo$37037.animation.CrossFade("talk", 0.2f);
							if (76558 - 242833 != -166275)
							{
								continue;
							}
						}
						if (this.$self_$37041.lCKc0lKgWUJ >= 1)
						{
							if (283439 - 43453 != 239986)
							{
								continue;
							}
							if (this.$self_$37041.Fgbc0GX6TVY < 1)
							{
								if (142205 - 281459 != -139254)
								{
									continue;
								}
							}
							else if (this.$self_$37041.HIuc0vF3Gx3 < 1)
							{
								if (67954 - 194319 != -126365)
								{
									continue;
								}
								this.$mStoryGui$37039.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 151), eTalkType.friend);
								if (48472 - 580285 != -531813)
								{
									continue;
								}
								this.$mStoryTimer$37040 = Time.time + 4f;
								if (42277 - 536583 != -494306)
								{
									continue;
								}
								goto IL_5C7;
							}
							else
							{
								this.$mStoryGui$37039.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 160), eTalkType.friend);
								if (130138 - 535360 != -405222)
								{
									continue;
								}
								this.$self_$37041.rUhcBWrk3Ls.alignToObject("EventCamera7");
								if (94609 - 202724 == -108114)
								{
									continue;
								}
								this.$mStoryTimer$37040 = Time.time + 4f;
								if (43472 - 398745 != -355273)
								{
									continue;
								}
								goto IL_70F;
							}
						}
						this.$mStoryGui$37039.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 150), eTalkType.friend);
						if (139857 - 461635 == -321777)
						{
							continue;
						}
						this.$mStoryTimer$37040 = Time.time + 4f;
						if (142384 - 478773 != -336388)
						{
							goto Block_90;
						}
						continue;
					case 3:
						goto IL_B72;
					case 4:
						goto IL_B72;
					case 5:
						goto IL_5EE;
					case 6:
						goto IL_5EE;
					case 7:
						goto IL_66A;
					case 8:
						goto IL_66A;
					case 9:
						goto IL_1096;
					case 10:
						goto IL_1096;
					case 11:
						goto IL_D9;
					case 12:
						goto IL_D9;
					case 13:
						goto IL_121A;
					case 14:
						goto IL_121A;
					case 15:
						goto IL_C17;
					case 16:
						goto IL_C17;
					case 17:
						goto IL_4F8;
					case 18:
						goto IL_4F8;
					case 19:
						goto IL_E46;
					case 20:
						goto IL_E46;
					case 21:
						break;
					case 22:
						break;
					case 23:
						goto IL_738;
					case 24:
						goto IL_738;
					case 25:
						if (Game.mGameState != eGameState.Hold)
						{
							if (183051 - 180713 != 2338)
							{
								continue;
							}
							goto IL_F09;
						}
						else
						{
							this.$self_$37041.rUhcBWrk3Ls.enabled = true;
							if (217295 - 310825 == -93529)
							{
								continue;
							}
							this.$mGameGui$37038.enabled = true;
							if (179311 - 164640 == 14672)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (30341 - 357727 == -327385)
							{
								continue;
							}
							if (this.$self_$37041.HIuc0vF3Gx3 > 0)
							{
								if (96991 - 249773 == -152781)
								{
									continue;
								}
								this.$self_$37041.SendMessage("newGameMessage", "New Mission Objective: Go to Light City.");
								if (200106 - 507985 != -307879)
								{
									continue;
								}
								Chat.SubmitChat("none", "New Mission Objective: Go to Light City.", eChatType.system, eChatMode.system);
								if (93058 - 548884 == -455825)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (87720 - 182613 != -94893)
							{
								continue;
							}
							goto IL_12C8;
						}
						break;
					default:
						if (201261 - 594053 != -392792)
						{
							continue;
						}
						goto IL_87A;
					}
					if (this.$mStoryTimer$37040 > Time.time)
					{
						if (231750 - 535158 == -303407)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_590;
						}
						if (205803 - 298112 != -92309)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (32990 - 151089 != -118098)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$self_$37041.HIuc0vF3Gx3 = this.$self_$37041.HIuc0vF3Gx3 + 1;
						if (93277 - 237775 != -144498)
						{
							continue;
						}
						goto IL_D31;
					}
					IL_D9:
					if (this.$mStoryTimer$37040 > Time.time)
					{
						if (105981 - 485588 == -379606)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_CC;
						}
						if (24152 - 116257 != -92105)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (578 - 573651 != -573073)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37039.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 155), eTalkType.friend);
						if (155174 - 280524 == -125349)
						{
							continue;
						}
						this.$mStoryTimer$37040 = Time.time + 4f;
						if (268703 - 118905 != 149798)
						{
							continue;
						}
						goto IL_11F1;
					}
					IL_66A:
					if (this.$mStoryTimer$37040 > Time.time)
					{
						if (143821 - 417387 == -273565)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_65E;
						}
						if (116221 - 470930 == -354708)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (256451 - 488952 != -232501)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37039.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 153), eTalkType.friend);
						if (106815 - 124151 == -17335)
						{
							continue;
						}
						this.$mStoryTimer$37040 = Time.time + 4f;
						if (254341 - 417483 != -163141)
						{
							goto Block_45;
						}
						continue;
					}
					IL_121A:
					if (this.$mStoryTimer$37040 > Time.time)
					{
						if (295511 - 150368 != 145143)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_120D;
						}
						if (53488 - 329294 != -275806)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (166360 - 318578 != -152218)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37039.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 156), eTalkType.friend);
						if (154508 - 447549 != -293041)
						{
							continue;
						}
						this.$mStoryTimer$37040 = Time.time + 4f;
						if (65055 - 268492 != -203436)
						{
							goto Block_12;
						}
						continue;
					}
					IL_1096:
					if (this.$mStoryTimer$37040 > Time.time)
					{
						if (2534 - 349216 == -346681)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1089;
						}
						if (197705 - 539734 == -342028)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (159959 - 326226 != -166267)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37039.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 154), eTalkType.friend);
						if (154090 - 576966 == -422875)
						{
							continue;
						}
						this.$mStoryTimer$37040 = Time.time + 4f;
						if (235014 - 393374 != -158360)
						{
							continue;
						}
						goto IL_B0;
					}
					IL_87A:
					if (Game.mGameState != eGameState.Normal)
					{
						if (252164 - 328138 != -75973)
						{
							break;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (230434 - 233445 != -3011)
						{
							continue;
						}
						this.$mPlayer$37036 = Game.mPlayer;
						if (28908 - 461626 != -432718)
						{
							continue;
						}
						this.$mKangaroo$37037 = GameObject.Find("Kangaroo");
						if (110847 - 66604 == 44244)
						{
							continue;
						}
						if (this.$mKangaroo$37037)
						{
							if (273879 - 37457 == 236423)
							{
								continue;
							}
							if (this.$mPlayer$37036)
							{
								if (58344 - 278150 == -219805)
								{
									continue;
								}
								this.$mPlayer$37036.SendMessage("turnToPos", this.$mKangaroo$37037.transform.position);
								if (84476 - 124585 != -40109)
								{
									continue;
								}
								this.$mKangaroo$37037.transform.rotation = Quaternion.LookRotation(this.$mPlayer$37036.transform.position - this.$mKangaroo$37037.transform.position);
								if (178778 - 226272 == -47493)
								{
									continue;
								}
							}
						}
						this.$mGameGui$37038 = (GameGui)this.$self_$37041.GetComponent(typeof(GameGui));
						if (55073 - 455380 == -400306)
						{
							continue;
						}
						if (this.$mGameGui$37038)
						{
							if (242211 - 52347 != 189864)
							{
								continue;
							}
							this.$mGameGui$37038.close();
							if (164479 - 142564 != 21915)
							{
								continue;
							}
						}
						this.$mStoryGui$37039 = (StoryGui)this.$self_$37041.GetComponent(typeof(StoryGui));
						if (47424 - 292247 != -244823)
						{
							continue;
						}
						this.$mStoryTimer$37040 = 0f;
						if (76295 - 502403 != -426108)
						{
							continue;
						}
						if (!this.$mStoryGui$37039)
						{
							goto IL_CF0;
						}
						if (29196 - 336935 == -307738)
						{
							continue;
						}
						this.$mStoryGui$37039.startStoryMessage("Kangaroo", "Kangaroo", eTalkType.friend);
						if (232686 - 334616 != -101930)
						{
							continue;
						}
						goto IL_236;
					}
					IL_D31:
					if (this.$mKangaroo$37037)
					{
						if (26811 - 500901 == -474089)
						{
							continue;
						}
						this.$mKangaroo$37037.animation.Play("root");
						if (123964 - 277726 != -153762)
						{
							continue;
						}
					}
					this.$mStoryGui$37039.close();
					if (102470 - 294528 != -192057)
					{
						goto Block_31;
					}
					continue;
					IL_B72:
					if (this.$mStoryTimer$37040 > Time.time)
					{
						if (99476 - 111968 != -12492)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_B66;
						}
						if (245429 - 346828 != -101399)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Hold)
					{
						goto IL_D31;
					}
					if (91135 - 550037 != -458902)
					{
						continue;
					}
					break;
					IL_738:
					if (this.$mStoryTimer$37040 > Time.time)
					{
						if (60764 - 493213 == -432448)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_72B;
						}
						if (269157 - 13843 == 255315)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Hold)
					{
						goto IL_D31;
					}
					if (205286 - 133596 != 71691)
					{
						break;
					}
					continue;
					IL_E46:
					if (this.$mStoryTimer$37040 > Time.time)
					{
						if (47247 - 229042 != -181795)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_E39;
						}
						if (244976 - 268742 != -23766)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (91220 - 456345 != -365125)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37039.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 159), eTalkType.friend);
						if (92654 - 431308 != -338654)
						{
							continue;
						}
						this.$mStoryTimer$37040 = Time.time + 4f;
						if (110229 - 349447 != -239218)
						{
							continue;
						}
						goto IL_574;
					}
					IL_4F8:
					if (this.$mStoryTimer$37040 > Time.time)
					{
						if (253390 - 369799 != -116409)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4EB;
						}
						if (270107 - 566131 != -296024)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (175622 - 365675 != -190052)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37039.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 158), eTalkType.friend);
						if (11872 - 273925 == -262052)
						{
							continue;
						}
						this.$self_$37041.rUhcBWrk3Ls.alignToObject("EventCamera7");
						if (52652 - 100349 != -47697)
						{
							continue;
						}
						this.$mStoryTimer$37040 = Time.time + 4f;
						if (94496 - 29260 != 65236)
						{
							continue;
						}
						goto IL_E1D;
					}
					IL_5EE:
					if (this.$mStoryTimer$37040 > Time.time)
					{
						if (179645 - 78641 != 101004)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5E2;
						}
						if (30959 - 529939 == -498979)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (7900 - 160423 != -152523)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37039.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 152), eTalkType.friend);
						if (165813 - 236692 == -70878)
						{
							continue;
						}
						this.$self_$37041.rUhcBWrk3Ls.StartCoroutine_Auto(this.$self_$37041.rUhcBWrk3Ls.slerpToObject("EventCamera6", (float)2));
						if (216585 - 454491 != -237906)
						{
							continue;
						}
						this.$mStoryTimer$37040 = Time.time + 4f;
						if (242289 - 590375 != -348085)
						{
							goto Block_89;
						}
						continue;
					}
					IL_C17:
					if (this.$mStoryTimer$37040 > Time.time)
					{
						if (134993 - 210029 == -75035)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_C0A;
						}
						if (229079 - 146100 == 82980)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (143221 - 227229 == -84008)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$37039.newStoryMessage("Kangaroo", "Kuru", Language.getMessage("M100_GameTutorial", 157), eTalkType.friend);
						if (179503 - 211029 == -31526)
						{
							this.$mStoryTimer$37040 = Time.time + 4f;
							if (19677 - 527243 == -507566)
							{
								goto IL_4CF;
							}
						}
					}
				}
				goto IL_12C8;
				IL_B0:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_CC:
				return this.YieldDefault(12);
				goto IL_12C8;
				Block_12:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_236:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_12C8;
				Block_31:
				goto IL_CF0;
				IL_4CF:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_4EB:
				return this.YieldDefault(18);
				IL_574:
				return this.Yield(21, new WaitForSeconds(0.5f));
				IL_590:
				return this.YieldDefault(22);
				IL_5C7:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_5E2:
				return this.YieldDefault(6);
				Block_45:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_65E:
				return this.YieldDefault(8);
				IL_70F:
				return this.Yield(23, new WaitForSeconds(0.5f));
				IL_72B:
				return this.YieldDefault(24);
				goto IL_12C8;
				IL_B66:
				return this.YieldDefault(4);
				IL_C0A:
				return this.YieldDefault(16);
				Block_89:
				return this.Yield(7, new WaitForSeconds(0.5f));
				Block_90:
				return this.Yield(3, new WaitForSeconds(0.5f));
				goto IL_12C8;
				IL_CF0:
				return this.Yield(25, new WaitForSeconds(0.5f));
				IL_E1D:
				return this.Yield(19, new WaitForSeconds(0.5f));
				IL_E39:
				return this.YieldDefault(20);
				IL_F09:
				goto IL_12C8;
				IL_1089:
				return this.YieldDefault(10);
				goto IL_12C8;
				IL_11F1:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_120D:
				return this.YieldDefault(14);
				IL_12C8:
				return false;
			}

			// Token: 0x06006E8D RID: 28301 RVA: 0x00F544A4 File Offset: 0x00F526A4
			internal static bool EN5myOpFq3HT4pNxHv62()
			{
				return true;
			}

			// Token: 0x06006E8E RID: 28302 RVA: 0x00F544A8 File Offset: 0x00F526A8
			internal static bool ByQr6cpF7nKtLeA5oyH0()
			{
				return false;
			}

			// Token: 0x040075F5 RID: 30197
			internal GameObject $mPlayer$37036;

			// Token: 0x040075F6 RID: 30198
			internal GameObject $mKangaroo$37037;

			// Token: 0x040075F7 RID: 30199
			internal GameGui $mGameGui$37038;

			// Token: 0x040075F8 RID: 30200
			internal StoryGui $mStoryGui$37039;

			// Token: 0x040075F9 RID: 30201
			internal float $mStoryTimer$37040;

			// Token: 0x040075FA RID: 30202
			internal M100_GameTutorial2 $self_$37041;
		}
	}

	// Token: 0x020012BE RID: 4798
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$37043 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006E8F RID: 28303 RVA: 0x00F544AC File Offset: 0x00F526AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$37043(M100_GameTutorial2 self_)
		{
			if (114470 - 409094 != -294623)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (176475 - 310408 == -133933)
				{
					base..ctor();
					if (46320 - 28528 != 17793)
					{
						this.$self_$37050 = self_;
						if (186118 - 332972 != -146853)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006E90 RID: 28304 RVA: 0x00F54544 File Offset: 0x00F52744
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial2.$TalkToRedPanda$37043.$(this.$self_$37050);
		}

		// Token: 0x06006E91 RID: 28305 RVA: 0x00F54554 File Offset: 0x00F52754
		internal static bool oniwhOpFP2YQSOO3AyhC()
		{
			return true;
		}

		// Token: 0x06006E92 RID: 28306 RVA: 0x00F54558 File Offset: 0x00F52758
		internal static bool G3b7nupF054yLJkQLPOv()
		{
			return false;
		}

		// Token: 0x040075FB RID: 30203
		internal M100_GameTutorial2 $self_$37050;

		// Token: 0x020012BF RID: 4799
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006E93 RID: 28307 RVA: 0x00F5455C File Offset: 0x00F5275C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial2 self_)
			{
				if (136234 - 434809 != -298575)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (313 - 267538 != -267224)
					{
						base..ctor();
						if (175954 - 419546 == -243592)
						{
							this.$self_$37049 = self_;
							if (62761 - 330607 == -267846)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006E94 RID: 28308 RVA: 0x00F545F4 File Offset: 0x00F527F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (23346 - 125918 != -102571)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_D15;
					case 1:
						goto IL_15A1;
					case 2:
						if (this.$self_$37049.lCKc0lKgWUJ >= 1)
						{
							goto IL_401;
						}
						if (237603 - 409264 != -171661)
						{
							continue;
						}
						this.$mStoryGui$37047.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("M100_GameTutorial", 121), eTalkType.friend);
						if (238929 - 26754 == 212176)
						{
							continue;
						}
						this.$mStoryTimer$37048 = Time.time + 4f;
						if (161441 - 201419 != -39977)
						{
							goto Block_36;
						}
						continue;
					case 3:
						goto IL_1C0;
					case 4:
						goto IL_1C0;
					case 5:
						break;
					case 6:
						break;
					case 7:
						goto IL_13D0;
					case 8:
						goto IL_13D0;
					case 9:
						goto IL_882;
					case 10:
						goto IL_882;
					case 11:
						goto IL_1209;
					case 12:
						goto IL_C96;
					case 13:
						goto IL_C96;
					case 14:
						goto IL_5CE;
					case 15:
						goto IL_5CE;
					case 16:
						goto IL_92E;
					case 17:
						goto IL_92E;
					case 18:
						goto IL_4E7;
					case 19:
						goto IL_4E7;
					case 20:
						goto IL_B6B;
					case 21:
						goto IL_B6B;
					case 22:
						goto IL_35B;
					case 23:
						goto IL_35B;
					case 24:
						goto IL_137F;
					case 25:
						goto IL_137F;
					case 26:
						goto IL_54D;
					case 27:
						goto IL_DE3;
					case 28:
						goto IL_DE3;
					case 29:
						goto IL_7F0;
					case 30:
						goto IL_7F0;
					case 31:
						goto IL_14A3;
					case 32:
						goto IL_14A3;
					case 33:
						if (Game.mGameState != eGameState.Hold)
						{
							if (68426 - 471836 != -403409)
							{
								goto Block_58;
							}
							continue;
						}
						else
						{
							this.$self_$37049.rUhcBWrk3Ls.enabled = true;
							if (30048 - 143618 != -113570)
							{
								continue;
							}
							this.$mGameGui$37046.enabled = true;
							if (136277 - 187441 == -51163)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (214549 - 344167 == -129617)
							{
								continue;
							}
							this.$self_$37049.SendMessage("newGameMessage", "Mission Objective: Talk to NPC " + this.$self_$37049.olpc02rkvCo + "/2");
							if (194560 - 434422 == -239861)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mission Objective: Talk to NPC " + this.$self_$37049.olpc02rkvCo + "/2", eChatType.system, eChatMode.system);
							if (58186 - 386458 != -328272)
							{
								continue;
							}
							this.YieldDefault(1);
							if (156470 - 305455 != -148985)
							{
								continue;
							}
							goto IL_15A1;
						}
						break;
					default:
						if (99468 - 93510 != 5958)
						{
							continue;
						}
						goto IL_D15;
					}
					if (this.$mStoryTimer$37048 > Time.time)
					{
						if (70071 - 366349 != -296278)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3A0;
						}
						if (107059 - 136932 == -29872)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (199013 - 111653 != 87360)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37047.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("M100_GameTutorial", 123), eTalkType.friend);
						if (200965 - 363713 == -162747)
						{
							continue;
						}
						this.$mStoryTimer$37048 = Time.time + 4f;
						if (184652 - 518760 != -334108)
						{
							continue;
						}
						goto IL_13A9;
					}
					IL_137F:
					if (this.$mStoryTimer$37048 > Time.time)
					{
						if (104940 - 116628 != -11688)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1372;
						}
						if (106718 - 242153 != -135435)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (12342 - 502818 != -490475)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37047.blank();
						if (139006 - 148423 == -9416)
						{
							continue;
						}
						this.$self_$37049.v0Nc0ObAiKy = 700;
						if (65068 - 419615 != -354547)
						{
							continue;
						}
						goto IL_54D;
					}
					IL_14A3:
					if (this.$mStoryTimer$37048 > Time.time)
					{
						if (123361 - 363944 == -240582)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1496;
						}
						if (246559 - 366658 != -120099)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (2424 - 596555 != -594130)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37047.close();
						if (143047 - 575898 != -432851)
						{
							continue;
						}
						goto IL_714;
					}
					IL_C96:
					if (this.$mStoryTimer$37048 > Time.time)
					{
						if (76944 - 502162 != -425218)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_C89;
						}
						if (234699 - 480572 != -245873)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (35171 - 529231 != -494059)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37047.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("M100_GameTutorial", 126), eTalkType.friend);
						if (85052 - 179656 == -94603)
						{
							continue;
						}
						this.$mStoryTimer$37048 = Time.time + 4f;
						if (190361 - 175170 != 15191)
						{
							continue;
						}
						goto IL_5A5;
					}
					IL_1C0:
					if (this.$mStoryTimer$37048 > Time.time)
					{
						if (55330 - 443959 == -388628)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1B4;
						}
						if (58725 - 386525 == -327799)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (238621 - 66887 != 171735)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37047.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("M100_GameTutorial", 122), eTalkType.friend);
						if (205846 - 357397 != -151551)
						{
							continue;
						}
						this.$mStoryTimer$37048 = Time.time + 4f;
						if (127265 - 593628 != -466363)
						{
							continue;
						}
						goto IL_385;
					}
					IL_35B:
					if (this.$mStoryTimer$37048 > Time.time)
					{
						if (222832 - 257548 == -34715)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_34E;
						}
						if (11628 - 306070 != -294442)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (255124 - 421338 != -166214)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37047.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("M100_GameTutorial", 131), eTalkType.friend);
						if (116043 - 67875 != 48168)
						{
							continue;
						}
						this.$mStoryTimer$37048 = Time.time + 4f;
						if (113676 - 119691 != -6015)
						{
							continue;
						}
						goto IL_1356;
					}
					IL_92E:
					if (this.$mStoryTimer$37048 > Time.time)
					{
						if (184050 - 452913 == -268862)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_921;
						}
						if (192124 - 178835 == 13290)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (213043 - 311738 != -98694)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37047.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("M100_GameTutorial", 128), eTalkType.friend);
						if (150538 - 250081 != -99543)
						{
							continue;
						}
						this.$mStoryTimer$37048 = Time.time + 4f;
						if (290597 - 511687 != -221090)
						{
							continue;
						}
						goto IL_4BE;
					}
					IL_401:
					this.$mStoryGui$37047.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("M100_GameTutorial", 134), eTalkType.friend);
					if (265075 - 64723 != 200352)
					{
						continue;
					}
					this.$mStoryTimer$37048 = Time.time + 4f;
					if (299128 - 322128 != -22999)
					{
						goto Block_145;
					}
					continue;
					IL_4E7:
					if (this.$mStoryTimer$37048 > Time.time)
					{
						if (56947 - 55789 == 1159)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4DA;
						}
						if (124893 - 357438 == -232544)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (102454 - 391427 != -288973)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37047.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("M100_GameTutorial", 129), eTalkType.friend);
						if (235575 - 567749 == -332173)
						{
							continue;
						}
						this.$mStoryTimer$37048 = Time.time + 4f;
						if (132619 - 325487 != -192867)
						{
							goto Block_25;
						}
						continue;
					}
					IL_54D:
					if (this.$self_$37049.v0Nc0ObAiKy == 700)
					{
						goto IL_540;
					}
					if (200132 - 409200 == -209067)
					{
						continue;
					}
					this.$mStoryGui$37047.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("M100_GameTutorial", 132), eTalkType.friend);
					if (190406 - 126461 == 63946)
					{
						continue;
					}
					this.$mStoryTimer$37048 = Time.time + 4f;
					if (92613 - 139808 != -47194)
					{
						goto Block_130;
					}
					continue;
					IL_5CE:
					if (this.$mStoryTimer$37048 > Time.time)
					{
						if (17277 - 85539 == -68261)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5C1;
						}
						if (50067 - 505697 != -455630)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (241240 - 106571 != 134670)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37047.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("M100_GameTutorial", 127), eTalkType.friend);
						if (122717 - 285500 != -162783)
						{
							continue;
						}
						this.$mStoryTimer$37048 = Time.time + 4f;
						if (126447 - 455312 != -328865)
						{
							continue;
						}
						goto IL_905;
					}
					IL_B6B:
					if (this.$mStoryTimer$37048 > Time.time)
					{
						if (192195 - 330780 != -138585)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_B5E;
						}
						if (245346 - 286562 != -41216)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (126846 - 210929 != -84083)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37047.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("M100_GameTutorial", 130), eTalkType.friend);
						if (149766 - 594517 == -444750)
						{
							continue;
						}
						this.$mStoryTimer$37048 = Time.time + 4f;
						if (181536 - 305124 != -123587)
						{
							goto Block_103;
						}
						continue;
					}
					IL_13D0:
					if (this.$mStoryTimer$37048 > Time.time)
					{
						if (21619 - 313 == 21307)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_13C4;
						}
						if (83527 - 456965 == -373437)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (6320 - 274575 != -268255)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37047.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("M100_GameTutorial", 124), eTalkType.friend);
						if (95267 - 270737 == -175469)
						{
							continue;
						}
						this.$mStoryTimer$37048 = Time.time + 4f;
						if (228133 - 470274 != -242140)
						{
							goto Block_76;
						}
						continue;
					}
					IL_7F0:
					if (this.$mStoryTimer$37048 > Time.time)
					{
						if (103923 - 397072 == -293148)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_7E3;
						}
						if (252084 - 592188 != -340104)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (268731 - 505222 != -236490)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$self_$37049.lCKc0lKgWUJ = this.$self_$37049.lCKc0lKgWUJ + 1;
						if (175689 - 584219 == -408529)
						{
							continue;
						}
						this.$self_$37049.olpc02rkvCo = this.$self_$37049.olpc02rkvCo + 1;
						if (166913 - 159467 != 7447)
						{
							goto IL_401;
						}
						continue;
					}
					IL_882:
					if (this.$mStoryTimer$37048 > Time.time)
					{
						if (178000 - 114443 != 63557)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_875;
						}
						if (96591 - 529837 != -433246)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (97129 - 238732 != -141602)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37047.blank();
						if (120683 - 91439 == 29245)
						{
							continue;
						}
						this.$self_$37049.v0Nc0ObAiKy = 401;
						if (89049 - 568445 != -479396)
						{
							continue;
						}
						goto IL_1209;
					}
					IL_DE3:
					if (this.$mStoryTimer$37048 > Time.time)
					{
						if (51069 - 209749 != -158680)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_DD6;
						}
						if (130509 - 538436 == -407926)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (123850 - 577030 != -453179)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37047.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("M100_GameTutorial", 133), eTalkType.friend);
						if (212050 - 376029 != -163979)
						{
							continue;
						}
						this.$mStoryTimer$37048 = Time.time + 4f;
						if (60316 - 70949 != -10633)
						{
							continue;
						}
						goto IL_7C7;
					}
					IL_D15:
					if (Game.mGameState != eGameState.Normal)
					{
						if (196019 - 587186 != -391167)
						{
							continue;
						}
						break;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (65992 - 430173 != -364181)
						{
							continue;
						}
						this.$mPlayer$37044 = Game.mPlayer;
						if (167374 - 127930 == 39445)
						{
							continue;
						}
						this.$mRedPanda$37045 = GameObject.Find("RedPanda");
						if (15096 - 74314 != -59218)
						{
							continue;
						}
						if (this.$mRedPanda$37045)
						{
							if (297844 - 592124 != -294280)
							{
								continue;
							}
							if (this.$mPlayer$37044)
							{
								if (92887 - 583255 == -490367)
								{
									continue;
								}
								this.$mPlayer$37044.SendMessage("turnToPos", this.$mRedPanda$37045.transform.position);
								if (134350 - 92270 == 42081)
								{
									continue;
								}
							}
						}
						this.$mGameGui$37046 = (GameGui)this.$self_$37049.GetComponent(typeof(GameGui));
						if (99700 - 32348 == 67353)
						{
							continue;
						}
						if (this.$mGameGui$37046)
						{
							if (3758 - 469602 != -465844)
							{
								continue;
							}
							this.$mGameGui$37046.close();
							if (80491 - 561307 != -480816)
							{
								continue;
							}
						}
						this.$mStoryGui$37047 = (StoryGui)this.$self_$37049.GetComponent(typeof(StoryGui));
						if (50704 - 42373 != 8331)
						{
							continue;
						}
						this.$mStoryTimer$37048 = 0f;
						if (152505 - 328159 == -175653)
						{
							continue;
						}
						if (!this.$mStoryGui$37047)
						{
							goto IL_714;
						}
						if (25176 - 329339 == -304162)
						{
							continue;
						}
						this.$self_$37049.rUhcBWrk3Ls.StartCoroutine_Auto(this.$self_$37049.rUhcBWrk3Ls.slerpToObject("EventCamera4", (float)2));
						if (5412 - 483654 == -478241)
						{
							continue;
						}
						this.$mStoryGui$37047.startStoryMessage("RedPandaSit", "RedPanda", eTalkType.friend);
						if (109896 - 400253 != -290356)
						{
							goto Block_116;
						}
						continue;
					}
					IL_1209:
					if (this.$self_$37049.v0Nc0ObAiKy == 401)
					{
						goto IL_11FC;
					}
					if (217557 - 62229 == 155328)
					{
						this.$mStoryGui$37047.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("M100_GameTutorial", 125), eTalkType.friend);
						if (151389 - 22010 == 129379)
						{
							this.$mStoryTimer$37048 = Time.time + 4f;
							if (109246 - 376753 != -267506)
							{
								goto Block_128;
							}
						}
					}
				}
				goto IL_15A1;
				IL_1B4:
				return this.YieldDefault(4);
				goto IL_15A1;
				Block_25:
				return this.Yield(20, new WaitForSeconds(0.5f));
				IL_34E:
				return this.YieldDefault(23);
				IL_385:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_3A0:
				return this.YieldDefault(6);
				Block_36:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_4BE:
				return this.Yield(18, new WaitForSeconds(0.5f));
				IL_4DA:
				return this.YieldDefault(19);
				IL_540:
				return this.YieldDefault(26);
				IL_5A5:
				return this.Yield(14, new WaitForSeconds(0.5f));
				IL_5C1:
				return this.YieldDefault(15);
				IL_714:
				return this.Yield(33, new WaitForSeconds(0.5f));
				Block_58:
				goto IL_15A1;
				IL_7C7:
				return this.Yield(29, new WaitForSeconds(0.5f));
				IL_7E3:
				return this.YieldDefault(30);
				IL_875:
				return this.YieldDefault(10);
				IL_905:
				return this.Yield(16, new WaitForSeconds(0.5f));
				IL_921:
				return this.YieldDefault(17);
				Block_76:
				return this.Yield(9, new WaitForSeconds(0.5f));
				goto IL_15A1;
				IL_B5E:
				return this.YieldDefault(21);
				goto IL_15A1;
				IL_C89:
				return this.YieldDefault(13);
				Block_103:
				return this.Yield(22, new WaitForSeconds(0.5f));
				IL_DD6:
				return this.YieldDefault(28);
				Block_116:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_15A1;
				Block_128:
				return this.Yield(12, new WaitForSeconds(0.5f));
				Block_130:
				return this.Yield(27, new WaitForSeconds(0.5f));
				IL_11FC:
				return this.YieldDefault(11);
				goto IL_15A1;
				IL_1356:
				return this.Yield(24, new WaitForSeconds(0.5f));
				IL_1372:
				return this.YieldDefault(25);
				IL_13A9:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_13C4:
				return this.YieldDefault(8);
				Block_145:
				return this.Yield(31, new WaitForSeconds(0.5f));
				IL_1496:
				return this.YieldDefault(32);
				IL_15A1:
				return false;
			}

			// Token: 0x06006E95 RID: 28309 RVA: 0x00F55BB4 File Offset: 0x00F53DB4
			internal static bool SpYJcBpFb1xylxJS8VRO()
			{
				return true;
			}

			// Token: 0x06006E96 RID: 28310 RVA: 0x00F55BB8 File Offset: 0x00F53DB8
			internal static bool Cv26rbpFuo6nXpPORWy3()
			{
				return false;
			}

			// Token: 0x040075FC RID: 30204
			internal GameObject $mPlayer$37044;

			// Token: 0x040075FD RID: 30205
			internal GameObject $mRedPanda$37045;

			// Token: 0x040075FE RID: 30206
			internal GameGui $mGameGui$37046;

			// Token: 0x040075FF RID: 30207
			internal StoryGui $mStoryGui$37047;

			// Token: 0x04007600 RID: 30208
			internal float $mStoryTimer$37048;

			// Token: 0x04007601 RID: 30209
			internal M100_GameTutorial2 $self_$37049;
		}
	}

	// Token: 0x020012C0 RID: 4800
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToOwl2$37051 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006E97 RID: 28311 RVA: 0x00F55BBC File Offset: 0x00F53DBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToOwl2$37051(M100_GameTutorial2 self_)
		{
			if (84265 - 112507 != -28241)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (159915 - 336568 != -176652)
				{
					base..ctor();
					if (240074 - 572159 == -332085)
					{
						this.$self_$37058 = self_;
						if (2497 - 96545 == -94048)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006E98 RID: 28312 RVA: 0x00F55C54 File Offset: 0x00F53E54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial2.$TalkToOwl2$37051.$(this.$self_$37058);
		}

		// Token: 0x06006E99 RID: 28313 RVA: 0x00F55C64 File Offset: 0x00F53E64
		internal static bool AZoFNSpFIpcAk0EaikWI()
		{
			return true;
		}

		// Token: 0x06006E9A RID: 28314 RVA: 0x00F55C68 File Offset: 0x00F53E68
		internal static bool MkPBmbpFB1l60NCU0GWy()
		{
			return false;
		}

		// Token: 0x04007602 RID: 30210
		internal M100_GameTutorial2 $self_$37058;

		// Token: 0x020012C1 RID: 4801
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006E9B RID: 28315 RVA: 0x00F55C6C File Offset: 0x00F53E6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial2 self_)
			{
				if (129317 - 324441 != -195124)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (285775 - 195687 != 90089)
					{
						base..ctor();
						if (259724 - 476535 == -216811)
						{
							this.$self_$37057 = self_;
							if (24408 - 463411 != -439002)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006E9C RID: 28316 RVA: 0x00F55D04 File Offset: 0x00F53F04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (144043 - 376469 != -232426)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_9FF;
					case 1:
						goto IL_DE5;
					case 2:
						if (this.$self_$37057.Fgbc0GX6TVY >= 1)
						{
							goto IL_49A;
						}
						if (211753 - 326651 != -114898)
						{
							continue;
						}
						this.$mStoryGui$37055.newStoryMessage("Owl2", "Lin Lin", Language.getMessage("M100_GameTutorial", 141), eTalkType.friend);
						if (202612 - 323569 != -120957)
						{
							continue;
						}
						this.$mStoryTimer$37056 = Time.time + 4f;
						if (258197 - 214694 != 43503)
						{
							continue;
						}
						goto IL_8D;
					case 3:
						goto IL_B4;
					case 4:
						goto IL_B4;
					case 5:
						goto IL_5E7;
					case 6:
						goto IL_5E7;
					case 7:
						goto IL_84B;
					case 8:
						goto IL_84B;
					case 9:
						goto IL_7D0;
					case 10:
						goto IL_7D0;
					case 11:
						goto IL_236;
					case 12:
						goto IL_236;
					case 13:
						goto IL_AA0;
					case 14:
						goto IL_AA0;
					case 15:
						goto IL_D46;
					case 16:
						goto IL_D46;
					case 17:
						break;
					case 18:
						break;
					case 19:
						if (Game.mGameState != eGameState.Hold)
						{
							if (14790 - 174081 != -159291)
							{
								continue;
							}
							goto IL_650;
						}
						else
						{
							this.$self_$37057.rUhcBWrk3Ls.enabled = true;
							if (36152 - 550155 == -514002)
							{
								continue;
							}
							this.$mGameGui$37054.enabled = true;
							if (256658 - 19913 != 236745)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (280165 - 101246 == 178920)
							{
								continue;
							}
							this.$self_$37057.SendMessage("newGameMessage", "Mission Objective: Talk to NPC " + this.$self_$37057.olpc02rkvCo + "/2");
							if (252183 - 377026 != -124843)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mission Objective: Talk to NPC " + this.$self_$37057.olpc02rkvCo + "/2", eChatType.system, eChatMode.system);
							if (198114 - 556389 == -358274)
							{
								continue;
							}
							this.YieldDefault(1);
							if (72775 - 525707 != -452932)
							{
								continue;
							}
							goto IL_DE5;
						}
						break;
					default:
						if (85453 - 243022 != -157568)
						{
							goto IL_9FF;
						}
						continue;
					}
					if (this.$mStoryTimer$37056 > Time.time)
					{
						if (47086 - 331913 != -284827)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_A40;
						}
						if (269019 - 443284 != -174265)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (44265 - 154079 != -109814)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37055.close();
						if (75004 - 175877 != -100873)
						{
							continue;
						}
						goto IL_99D;
					}
					IL_9FF:
					if (Game.mGameState != eGameState.Normal)
					{
						if (30708 - 33476 != -2768)
						{
							continue;
						}
						break;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (228712 - 290599 != -61887)
						{
							continue;
						}
						this.$mPlayer$37052 = Game.mPlayer;
						if (213138 - 109588 == 103551)
						{
							continue;
						}
						this.$mOwl2$37053 = GameObject.Find("Owl2");
						if (3102 - 414038 != -410936)
						{
							continue;
						}
						if (this.$mOwl2$37053)
						{
							if (151073 - 410974 != -259901)
							{
								continue;
							}
							if (this.$mPlayer$37052)
							{
								if (283757 - 79250 == 204508)
								{
									continue;
								}
								this.$mPlayer$37052.SendMessage("turnToPos", this.$mOwl2$37053.transform.position);
								if (292180 - 48404 == 243777)
								{
									continue;
								}
							}
						}
						this.$mGameGui$37054 = (GameGui)this.$self_$37057.GetComponent(typeof(GameGui));
						if (53835 - 177904 != -124069)
						{
							continue;
						}
						if (this.$mGameGui$37054)
						{
							if (80530 - 555100 == -474569)
							{
								continue;
							}
							this.$mGameGui$37054.close();
							if (189102 - 87524 != 101578)
							{
								continue;
							}
						}
						this.$mStoryGui$37055 = (StoryGui)this.$self_$37057.GetComponent(typeof(StoryGui));
						if (89057 - 63820 == 25238)
						{
							continue;
						}
						this.$mStoryTimer$37056 = 0f;
						if (172564 - 110716 != 61848)
						{
							continue;
						}
						if (!this.$mStoryGui$37055)
						{
							goto IL_99D;
						}
						if (71658 - 390057 != -318399)
						{
							continue;
						}
						this.$self_$37057.rUhcBWrk3Ls.alignToObject("EventCamera5");
						if (75699 - 180438 == -104738)
						{
							continue;
						}
						this.$mStoryGui$37055.startStoryMessage("Owl2", "Lin Lin", eTalkType.friend);
						if (163872 - 31739 != 132133)
						{
							continue;
						}
						goto IL_55A;
					}
					IL_B4:
					if (this.$mStoryTimer$37056 > Time.time)
					{
						if (179106 - 511493 != -332387)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_A8;
						}
						if (52319 - 797 == 51523)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (154528 - 310938 != -156409)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37055.newStoryMessage("Owl2", "Lin Lin", Language.getMessage("M100_GameTutorial", 142), eTalkType.friend);
						if (176911 - 597228 == -420316)
						{
							continue;
						}
						this.$mStoryTimer$37056 = Time.time + 4f;
						if (37227 - 148682 != -111454)
						{
							goto Block_95;
						}
						continue;
					}
					IL_84B:
					if (this.$mStoryTimer$37056 > Time.time)
					{
						if (9182 - 363357 == -354174)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_83F;
						}
						if (178596 - 116619 == 61978)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (96657 - 570605 != -473948)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37055.newStoryMessage("Owl2", "Lin Lin", Language.getMessage("M100_GameTutorial", 144), eTalkType.friend);
						if (191617 - 99570 != 92047)
						{
							continue;
						}
						this.$mStoryTimer$37056 = Time.time + 4f;
						if (86998 - 569454 != -482455)
						{
							goto Block_29;
						}
						continue;
					}
					IL_5E7:
					if (this.$mStoryTimer$37056 > Time.time)
					{
						if (149626 - 155046 == -5419)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5DB;
						}
						if (183885 - 341723 != -157838)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (592 - 486433 != -485841)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37055.newStoryMessage("Owl2", "Lin Lin", Language.getMessage("M100_GameTutorial", 143), eTalkType.friend);
						if (145759 - 280444 == -134684)
						{
							continue;
						}
						this.$mStoryTimer$37056 = Time.time + 4f;
						if (11657 - 282927 != -271270)
						{
							continue;
						}
						goto IL_824;
					}
					IL_236:
					if (this.$mStoryTimer$37056 > Time.time)
					{
						if (155074 - 382679 != -227605)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_229;
						}
						if (272106 - 469599 != -197493)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (190428 - 524385 != -333956)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37055.newStoryMessage("Owl2", "Lin Lin", Language.getMessage("M100_GameTutorial", 146), eTalkType.friend);
						if (102066 - 18822 != 83244)
						{
							continue;
						}
						this.$mStoryTimer$37056 = Time.time + 4f;
						if (241364 - 223979 != 17386)
						{
							goto Block_28;
						}
						continue;
					}
					IL_D46:
					if (this.$mStoryTimer$37056 > Time.time)
					{
						if (74838 - 387048 == -312209)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_D39;
						}
						if (64123 - 562166 == -498042)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (106784 - 492266 != -385481)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$self_$37057.Fgbc0GX6TVY = this.$self_$37057.Fgbc0GX6TVY + 1;
						if (258304 - 294055 != -35751)
						{
							continue;
						}
						this.$self_$37057.olpc02rkvCo = this.$self_$37057.olpc02rkvCo + 1;
						if (227228 - 153837 != 73391)
						{
							continue;
						}
						goto IL_49A;
					}
					IL_AA0:
					if (this.$mStoryTimer$37056 > Time.time)
					{
						if (59101 - 171673 == -112571)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_A93;
						}
						if (261741 - 350321 != -88580)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (252263 - 512504 != -260240)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37055.newStoryMessage("Owl2", "Lin Lin", Language.getMessage("M100_GameTutorial", 147), eTalkType.friend);
						if (184704 - 197284 != -12580)
						{
							continue;
						}
						this.$mStoryTimer$37056 = Time.time + 4f;
						if (105140 - 108256 != -3116)
						{
							continue;
						}
						goto IL_D1D;
					}
					IL_49A:
					this.$mStoryGui$37055.newStoryMessage("Owl2", "Lin Lin", Language.getMessage("M100_GameTutorial", 148), eTalkType.friend);
					if (67832 - 483240 != -415408)
					{
						continue;
					}
					this.$mStoryTimer$37056 = Time.time + 4f;
					if (100626 - 298849 != -198223)
					{
						continue;
					}
					goto IL_A24;
					IL_7D0:
					if (this.$mStoryTimer$37056 > Time.time)
					{
						if (263531 - 155585 == 107947)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_7C3;
						}
						if (57179 - 511944 == -454764)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (252707 - 448295 == -195588)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$37055.newStoryMessage("Owl2", "Lin Lin", Language.getMessage("M100_GameTutorial", 145), eTalkType.friend);
						if (198549 - 207958 != -9408)
						{
							this.$mStoryTimer$37056 = Time.time + 4f;
							if (274481 - 107269 == 167212)
							{
								goto IL_20D;
							}
						}
					}
				}
				goto IL_DE5;
				IL_8D:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_A8:
				return this.YieldDefault(4);
				goto IL_DE5;
				IL_20D:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_229:
				return this.YieldDefault(12);
				goto IL_DE5;
				Block_28:
				return this.Yield(13, new WaitForSeconds(0.5f));
				Block_29:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_55A:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_5DB:
				return this.YieldDefault(6);
				IL_650:
				goto IL_DE5;
				IL_7C3:
				return this.YieldDefault(10);
				IL_824:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_83F:
				return this.YieldDefault(8);
				IL_99D:
				return this.Yield(19, new WaitForSeconds(0.5f));
				IL_A24:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_A40:
				return this.YieldDefault(18);
				IL_A93:
				return this.YieldDefault(14);
				goto IL_DE5;
				Block_95:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_D1D:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_D39:
				return this.YieldDefault(16);
				IL_DE5:
				return false;
			}

			// Token: 0x06006E9D RID: 28317 RVA: 0x00F56B08 File Offset: 0x00F54D08
			internal static bool hRlMHwpFexGERoD58D8A()
			{
				return true;
			}

			// Token: 0x06006E9E RID: 28318 RVA: 0x00F56B0C File Offset: 0x00F54D0C
			internal static bool plgP60pFrjtxIlgav6lD()
			{
				return false;
			}

			// Token: 0x04007603 RID: 30211
			internal GameObject $mPlayer$37052;

			// Token: 0x04007604 RID: 30212
			internal GameObject $mOwl2$37053;

			// Token: 0x04007605 RID: 30213
			internal GameGui $mGameGui$37054;

			// Token: 0x04007606 RID: 30214
			internal StoryGui $mStoryGui$37055;

			// Token: 0x04007607 RID: 30215
			internal float $mStoryTimer$37056;

			// Token: 0x04007608 RID: 30216
			internal M100_GameTutorial2 $self_$37057;
		}
	}

	// Token: 0x020012C2 RID: 4802
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$37059 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006E9F RID: 28319 RVA: 0x00F56B10 File Offset: 0x00F54D10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$37059(M100_GameTutorial2 self_)
		{
			if (121860 - 550539 != -428678)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (260914 - 224443 != 36472)
				{
					base..ctor();
					if (106832 - 397324 == -290492)
					{
						this.$self_$37061 = self_;
						if (291856 - 553590 == -261734)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006EA0 RID: 28320 RVA: 0x00F56BA8 File Offset: 0x00F54DA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial2.$UseSignPost$37059.$(this.$self_$37061);
		}

		// Token: 0x06006EA1 RID: 28321 RVA: 0x00F56BB8 File Offset: 0x00F54DB8
		internal static bool VrHG0bpFjibekJ8G3k2k()
		{
			return true;
		}

		// Token: 0x06006EA2 RID: 28322 RVA: 0x00F56BBC File Offset: 0x00F54DBC
		internal static bool Ys2DqupFhvLv7GCXsaYW()
		{
			return false;
		}

		// Token: 0x04007609 RID: 30217
		internal M100_GameTutorial2 $self_$37061;

		// Token: 0x020012C3 RID: 4803
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006EA3 RID: 28323 RVA: 0x00F56BC0 File Offset: 0x00F54DC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial2 self_)
			{
				if (192486 - 39147 != 153340)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (156991 - 99723 != 57269)
					{
						base..ctor();
						if (100064 - 248692 == -148628)
						{
							this.$self_$37060 = self_;
							if (7002 - 173520 != -166517)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006EA4 RID: 28324 RVA: 0x00F56C58 File Offset: 0x00F54E58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (84491 - 93581 != -9089)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_126;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (289833 - 510977 != -221144)
						{
							continue;
						}
						this.YieldDefault(1);
						if (110176 - 116827 != -6651)
						{
							continue;
						}
						goto IL_126;
					default:
						if (220981 - 147787 != 73194)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (139369 - 213628 != -74258)
						{
							goto Block_7;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (148458 - 240063 != -91604)
						{
							this.$self_$37060.SendMessage("newNoticeBar", Language.getMessage("G30_NoGuild", 201));
							if (162106 - 330917 != -168810)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				Block_7:
				IL_126:
				return false;
			}

			// Token: 0x06006EA5 RID: 28325 RVA: 0x00F56DA0 File Offset: 0x00F54FA0
			internal static bool cvenJWpFsZJXV2OYmt0e()
			{
				return true;
			}

			// Token: 0x06006EA6 RID: 28326 RVA: 0x00F56DA4 File Offset: 0x00F54FA4
			internal static bool ThxC2VpF9aX3VsNxBF3y()
			{
				return false;
			}

			// Token: 0x0400760A RID: 30218
			internal M100_GameTutorial2 $self_$37060;
		}
	}

	// Token: 0x020012C4 RID: 4804
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseFirstTailShrine$37062 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006EA7 RID: 28327 RVA: 0x00F56DA8 File Offset: 0x00F54FA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseFirstTailShrine$37062(M100_GameTutorial2 self_)
		{
			if (242076 - 599451 != -357375)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (155659 - 510603 != -354943)
				{
					base..ctor();
					if (222086 - 361240 != -139153)
					{
						this.$self_$37065 = self_;
						if (84691 - 544847 == -460156)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006EA8 RID: 28328 RVA: 0x00F56E40 File Offset: 0x00F55040
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial2.$UseFirstTailShrine$37062.$(this.$self_$37065);
		}

		// Token: 0x06006EA9 RID: 28329 RVA: 0x00F56E50 File Offset: 0x00F55050
		internal static bool uhUkqfpF1yPmm1RD3jWh()
		{
			return true;
		}

		// Token: 0x06006EAA RID: 28330 RVA: 0x00F56E54 File Offset: 0x00F55054
		internal static bool Yc3KpRpF41PiKvyl2OpX()
		{
			return false;
		}

		// Token: 0x0400760B RID: 30219
		internal M100_GameTutorial2 $self_$37065;

		// Token: 0x020012C5 RID: 4805
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006EAB RID: 28331 RVA: 0x00F56E58 File Offset: 0x00F55058
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial2 self_)
			{
				if (262138 - 506796 != -244657)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (266917 - 425201 != -158283)
					{
						base..ctor();
						if (7806 - 478367 == -470561)
						{
							this.$self_$37064 = self_;
							if (286803 - 433176 != -146372)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006EAC RID: 28332 RVA: 0x00F56EF0 File Offset: 0x00F550F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (130498 - 568821 != -438323)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2C4;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (114584 - 587959 != -473375)
						{
							continue;
						}
						goto IL_172;
					default:
						if (64281 - 317502 == -253220)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (202261 - 184501 != 17760)
						{
							continue;
						}
						break;
					}
					else if (Game.mPlayer)
					{
						if (219983 - 495296 == -275312)
						{
							continue;
						}
						this.$mChar$37063 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
						if (229381 - 431982 == -202600)
						{
							continue;
						}
						if (!this.$mChar$37063)
						{
							if (118284 - 183219 != -64935)
							{
								continue;
							}
							break;
						}
						else
						{
							if (!(this.$mChar$37063.actionState == "standby"))
							{
								if (27796 - 37459 == -9662)
								{
									continue;
								}
								if (!(this.$mChar$37063.actionState == "run"))
								{
									if (34749 - 476072 == -441322)
									{
										continue;
									}
									if (!(this.$mChar$37063.actionState == "emotion"))
									{
										goto IL_172;
									}
									if (155650 - 377451 == -221800)
									{
										continue;
									}
								}
							}
							this.$mChar$37063.turnToPos(new Vector3(-7.5f, 50.4f, -8.5f));
							if (124368 - 293088 != -168720)
							{
								continue;
							}
							this.$self_$37064.SendMessage("selectCommand", SkillData.getEmotionCode("emo_beg"), SendMessageOptions.DontRequireReceiver);
							if (73940 - 189413 != -115473)
							{
								continue;
							}
							Game.mGameState = eGameState.Hold;
							if (201859 - 201940 == -80)
							{
								continue;
							}
							this.$self_$37064.SendMessage("newNoticeBar", Language.getMessage("G30_NoGuild", 101), SendMessageOptions.DontRequireReceiver);
							if (76004 - 552020 != -476016)
							{
								continue;
							}
							goto IL_DB;
						}
					}
					IL_172:
					this.YieldDefault(1);
				}
				while (83182 - 69135 == 14048);
				goto IL_2C4;
				IL_DB:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_2C4:
				return false;
			}

			// Token: 0x06006EAD RID: 28333 RVA: 0x00F571D4 File Offset: 0x00F553D4
			internal static bool rMDB46pFz3gaO4x2JHlE()
			{
				return true;
			}

			// Token: 0x06006EAE RID: 28334 RVA: 0x00F571D8 File Offset: 0x00F553D8
			internal static bool iJY4kqpMa2oaKf3N00qo()
			{
				return false;
			}

			// Token: 0x0400760C RID: 30220
			internal CharacterControl $mChar$37063;

			// Token: 0x0400760D RID: 30221
			internal M100_GameTutorial2 $self_$37064;
		}
	}

	// Token: 0x020012C6 RID: 4806
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37066 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006EAF RID: 28335 RVA: 0x00F571DC File Offset: 0x00F553DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37066(M100_GameTutorial2 self_)
		{
			if (157005 - 319380 != -162375)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (19348 - 165497 != -146148)
				{
					base..ctor();
					if (268460 - 525285 == -256825)
					{
						this.$self_$37071 = self_;
						if (119434 - 110852 != 8583)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006EB0 RID: 28336 RVA: 0x00F57274 File Offset: 0x00F55474
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial2.$onDeadPlayer$37066.$(this.$self_$37071);
		}

		// Token: 0x06006EB1 RID: 28337 RVA: 0x00F57284 File Offset: 0x00F55484
		internal static bool UELGd4pM56nMgcNIyv51()
		{
			return true;
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x00F57288 File Offset: 0x00F55488
		internal static bool m0Z4bfpMppcXVMGvVaxg()
		{
			return false;
		}

		// Token: 0x0400760E RID: 30222
		internal M100_GameTutorial2 $self_$37071;

		// Token: 0x020012C7 RID: 4807
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006EB3 RID: 28339 RVA: 0x00F5728C File Offset: 0x00F5548C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial2 self_)
			{
				if (244830 - 535186 != -290356)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (219267 - 24036 == 195231)
					{
						base..ctor();
						if (181136 - 594880 != -413743)
						{
							this.$self_$37070 = self_;
							if (298851 - 551787 == -252936)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006EB4 RID: 28340 RVA: 0x00F57324 File Offset: 0x00F55524
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (299850 - 490736 != -190885)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2F9;
					case 2:
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_1E6;
						}
						if (116558 - 567459 != -450901)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (192585 - 268531 != -75945)
							{
								goto IL_1E6;
							}
							continue;
						}
						IL_19F:
						this.YieldDefault(1);
						if (163496 - 432050 != -268553)
						{
							goto Block_16;
						}
						continue;
						IL_1E6:
						Game.mGameState = eGameState.Hold;
						if (118257 - 280467 == -162209)
						{
							continue;
						}
						this.$mStoryGui$37067 = (StoryGui)this.$self_$37070.GetComponent(typeof(StoryGui));
						if (215913 - 346719 != -130806)
						{
							continue;
						}
						if (this.$mStoryGui$37067)
						{
							if (144327 - 137589 != 6738)
							{
								continue;
							}
							this.$mStoryGui$37067.close();
							if (254514 - 535490 != -280976)
							{
								continue;
							}
						}
						this.$mChangeGui$37068 = (ChangeGui)this.$self_$37070.GetComponent(typeof(ChangeGui));
						if (253061 - 269380 == -16318)
						{
							continue;
						}
						if (this.$mChangeGui$37068)
						{
							if (84336 - 4463 == 79874)
							{
								continue;
							}
							this.$mChangeGui$37068.close();
							if (100474 - 410008 == -309533)
							{
								continue;
							}
						}
						this.$mGameGui$37069 = (GameGui)this.$self_$37070.GetComponent(typeof(GameGui));
						if (167540 - 144165 != 23375)
						{
							continue;
						}
						if (!this.$mGameGui$37069)
						{
							goto IL_19F;
						}
						if (274957 - 514037 != -239080)
						{
							continue;
						}
						if (!this.$mGameGui$37069.enabled)
						{
							if (26383 - 579849 != -553466)
							{
								continue;
							}
							this.$mGameGui$37069.enabled = true;
							if (123618 - 231446 != -107828)
							{
								continue;
							}
						}
						this.$mGameGui$37069.openDeadMenu();
						if (249741 - 214410 != 35331)
						{
							continue;
						}
						goto IL_19F;
					default:
						if (181569 - 369761 != -188192)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (12100 - 46556 != -34455)
					{
						goto Block_19;
					}
				}
				Block_16:
				goto IL_2F9;
				Block_19:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06006EB5 RID: 28341 RVA: 0x00F5763C File Offset: 0x00F5583C
			internal static bool OxjmrwpMVP8FDYeXudC0()
			{
				return true;
			}

			// Token: 0x06006EB6 RID: 28342 RVA: 0x00F57640 File Offset: 0x00F55840
			internal static bool Oeydy3pMtCnZ8WLV3rl0()
			{
				return false;
			}

			// Token: 0x0400760F RID: 30223
			internal StoryGui $mStoryGui$37067;

			// Token: 0x04007610 RID: 30224
			internal ChangeGui $mChangeGui$37068;

			// Token: 0x04007611 RID: 30225
			internal GameGui $mGameGui$37069;

			// Token: 0x04007612 RID: 30226
			internal M100_GameTutorial2 $self_$37070;
		}
	}

	// Token: 0x020012C8 RID: 4808
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$37072 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006EB7 RID: 28343 RVA: 0x00F57644 File Offset: 0x00F55844
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$37072(Hashtable data, M100_GameTutorial2 self_)
		{
			if (109180 - 6711 != 102470)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (122511 - 233073 != -110561)
				{
					base..ctor();
					if (146979 - 155296 == -8317)
					{
						this.$data$37077 = data;
						if (177144 - 327560 == -150416)
						{
							this.$self_$37078 = self_;
							if (290769 - 78199 == 212570)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006EB8 RID: 28344 RVA: 0x00F57700 File Offset: 0x00F55900
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial2.$onChangePlayer$37072.$(this.$data$37077, this.$self_$37078);
		}

		// Token: 0x06006EB9 RID: 28345 RVA: 0x00F57714 File Offset: 0x00F55914
		internal static bool xTBhqjpMNO4v20s3vPU2()
		{
			return true;
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x00F57718 File Offset: 0x00F55918
		internal static bool Qqk6FVpMYXbd8yrcEQrk()
		{
			return false;
		}

		// Token: 0x04007613 RID: 30227
		internal Hashtable $data$37077;

		// Token: 0x04007614 RID: 30228
		internal M100_GameTutorial2 $self_$37078;

		// Token: 0x020012C9 RID: 4809
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006EBB RID: 28347 RVA: 0x00F5771C File Offset: 0x00F5591C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M100_GameTutorial2 self_)
			{
				if (86077 - 464683 != -378606)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (63293 - 527578 == -464285)
					{
						base..ctor();
						if (23748 - 129948 != -106199)
						{
							this.$data$37075 = data;
							if (158306 - 331888 != -173581)
							{
								this.$self_$37076 = self_;
								if (275220 - 506751 != -231530)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006EBC RID: 28348 RVA: 0x00F577D8 File Offset: 0x00F559D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (270707 - 320869 != -50162)
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
							if (135917 - 55639 != 80278)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (80221 - 550168 != -469947)
							{
								continue;
							}
							this.$mGameGui$37074 = (GameGui)this.$self_$37076.GetComponent(typeof(GameGui));
							if (135821 - 338613 == -202791)
							{
								continue;
							}
							this.$mGameGui$37074.enabled = true;
							if (161437 - 479024 != -317587)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (99446 - 485913 != -386467)
						{
							continue;
						}
						goto IL_205;
					default:
						if (271837 - 17610 == 254228)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (259542 - 313797 == -54255)
					{
						this.$self_$37076.SendMessage("onCreatePlayer", this.$data$37075);
						if (288463 - 538403 == -249940)
						{
							this.$mChangeGui$37073 = (ChangeGui)this.$self_$37076.GetComponent(typeof(ChangeGui));
							if (62613 - 594560 != -531946)
							{
								if (!this.$mChangeGui$37073.enabled)
								{
									break;
								}
								if (225295 - 314027 == -88732)
								{
									this.$mChangeGui$37073.close();
									if (95391 - 342849 != -247457)
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

			// Token: 0x06006EBD RID: 28349 RVA: 0x00F579FC File Offset: 0x00F55BFC
			internal static bool jHHaItpMcNiUa19udcq1()
			{
				return true;
			}

			// Token: 0x06006EBE RID: 28350 RVA: 0x00F57A00 File Offset: 0x00F55C00
			internal static bool FCT1FnpMUhNBbjYySTFx()
			{
				return false;
			}

			// Token: 0x04007615 RID: 30229
			internal ChangeGui $mChangeGui$37073;

			// Token: 0x04007616 RID: 30230
			internal GameGui $mGameGui$37074;

			// Token: 0x04007617 RID: 30231
			internal Hashtable $data$37075;

			// Token: 0x04007618 RID: 30232
			internal M100_GameTutorial2 $self_$37076;
		}
	}

	// Token: 0x020012CA RID: 4810
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37079 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006EBF RID: 28351 RVA: 0x00F57A04 File Offset: 0x00F55C04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37079(Hashtable data, M100_GameTutorial2 self_)
		{
			if (266527 - 187581 != 78947)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (133054 - 557469 == -424415)
				{
					base..ctor();
					if (104321 - 285923 == -181602)
					{
						this.$data$37087 = data;
						if (113878 - 44487 != 69392)
						{
							this.$self_$37088 = self_;
							if (145993 - 273048 == -127055)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006EC0 RID: 28352 RVA: 0x00F57AC0 File Offset: 0x00F55CC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial2.$onGameComplete$37079.$(this.$data$37087, this.$self_$37088);
		}

		// Token: 0x06006EC1 RID: 28353 RVA: 0x00F57AD4 File Offset: 0x00F55CD4
		internal static bool GlV7T7pMTMBYCglr6RLv()
		{
			return true;
		}

		// Token: 0x06006EC2 RID: 28354 RVA: 0x00F57AD8 File Offset: 0x00F55CD8
		internal static bool kmB9ykpM3jJrr1cJjUTq()
		{
			return false;
		}

		// Token: 0x04007619 RID: 30233
		internal Hashtable $data$37087;

		// Token: 0x0400761A RID: 30234
		internal M100_GameTutorial2 $self_$37088;

		// Token: 0x020012CB RID: 4811
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006EC3 RID: 28355 RVA: 0x00F57ADC File Offset: 0x00F55CDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M100_GameTutorial2 self_)
			{
				if (67729 - 343155 != -275426)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (115651 - 18584 != 97068)
					{
						base..ctor();
						if (39244 - 450596 == -411352)
						{
							this.$data$37085 = data;
							if (148596 - 430776 == -282180)
							{
								this.$self_$37086 = self_;
								if (141374 - 253213 != -111838)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006EC4 RID: 28356 RVA: 0x00F57B98 File Offset: 0x00F55D98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (228765 - 204058 != 24708)
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
						this.$mCompleteGui$37081 = (CompleteGui)this.$self_$37086.GetComponent(typeof(CompleteGui));
						if (251896 - 255376 == -3479)
						{
							continue;
						}
						this.$mCompleteGui$37081.Init();
						if (180028 - 492603 != -312575)
						{
							continue;
						}
						this.$mCompleteGui$37081.readData(this.$data$37085);
						if (96642 - 124330 == -27687)
						{
							continue;
						}
						if (this.$result$37080 == 1)
						{
							if (118584 - 319492 != -200908)
							{
								continue;
							}
							this.$mCompleteGui$37081.displayResult(eCompleteType.Success);
							if (83823 - 396339 != -312516)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37081.displayResult(eCompleteType.Failed);
							if (99304 - 94303 != 5001)
							{
								continue;
							}
						}
						this.$mGameGui$37082 = (GameGui)this.$self_$37086.GetComponent(typeof(GameGui));
						if (145677 - 457580 == -311902)
						{
							continue;
						}
						this.$mStoryGui$37083 = (StoryGui)this.$self_$37086.GetComponent(typeof(StoryGui));
						if (248369 - 495735 == -247365)
						{
							continue;
						}
						this.$mChangeGui$37084 = (ChangeGui)this.$self_$37086.GetComponent(typeof(ChangeGui));
						if (51716 - 276893 != -225177)
						{
							continue;
						}
						if (this.$mGameGui$37082)
						{
							if (63066 - 50072 != 12994)
							{
								continue;
							}
							this.$mGameGui$37082.close();
							if (83604 - 587717 == -504112)
							{
								continue;
							}
						}
						if (this.$mStoryGui$37083)
						{
							if (283907 - 19030 == 264878)
							{
								continue;
							}
							this.$mStoryGui$37083.close();
							if (245233 - 18447 != 226786)
							{
								continue;
							}
						}
						if (this.$mChangeGui$37084)
						{
							if (236563 - 15486 != 221077)
							{
								continue;
							}
							this.$mChangeGui$37084.disable();
							if (258301 - 535899 != -277598)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (15818 - 314142 != -298323)
						{
							goto Block_13;
						}
						continue;
					default:
						if (163800 - 594547 != -430747)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$37085[31]);
					if (89692 - 567691 != -477998)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (189596 - 378353 != -188756)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (187798 - 189383 == -1585)
							{
								this.$result$37080 = RuntimeServices.UnboxInt32(this.$data$37085[31]);
								if (269584 - 187082 == 82502)
								{
									goto IL_2D8;
								}
							}
						}
					}
				}
				Block_13:
				goto IL_3DB;
				IL_2D8:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06006EC5 RID: 28357 RVA: 0x00F57F94 File Offset: 0x00F56194
			internal static bool tX7qmWpMXEhFNDOktPla()
			{
				return true;
			}

			// Token: 0x06006EC6 RID: 28358 RVA: 0x00F57F98 File Offset: 0x00F56198
			internal static bool ISnoUZpMQYJ9JQ4fedGt()
			{
				return false;
			}

			// Token: 0x0400761B RID: 30235
			internal int $result$37080;

			// Token: 0x0400761C RID: 30236
			internal CompleteGui $mCompleteGui$37081;

			// Token: 0x0400761D RID: 30237
			internal GameGui $mGameGui$37082;

			// Token: 0x0400761E RID: 30238
			internal StoryGui $mStoryGui$37083;

			// Token: 0x0400761F RID: 30239
			internal ChangeGui $mChangeGui$37084;

			// Token: 0x04007620 RID: 30240
			internal Hashtable $data$37085;

			// Token: 0x04007621 RID: 30241
			internal M100_GameTutorial2 $self_$37086;
		}
	}

	// Token: 0x020012CC RID: 4812
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37089 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006EC7 RID: 28359 RVA: 0x00F57F9C File Offset: 0x00F5619C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37089(M100_GameTutorial2 self_)
		{
			if (71196 - 369755 != -298559)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (7696 - 117263 == -109567)
				{
					base..ctor();
					if (217456 - 123400 == 94056)
					{
						this.$self_$37093 = self_;
						if (18702 - 126694 != -107991)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006EC8 RID: 28360 RVA: 0x00F58034 File Offset: 0x00F56234
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial2.$ReturnToTown$37089.$(this.$self_$37093);
		}

		// Token: 0x06006EC9 RID: 28361 RVA: 0x00F58044 File Offset: 0x00F56244
		internal static bool TLHw8FpMkMRNVsiwRxDb()
		{
			return true;
		}

		// Token: 0x06006ECA RID: 28362 RVA: 0x00F58048 File Offset: 0x00F56248
		internal static bool kYXURspMGtgnlU6mnKIF()
		{
			return false;
		}

		// Token: 0x04007622 RID: 30242
		internal M100_GameTutorial2 $self_$37093;

		// Token: 0x020012CD RID: 4813
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006ECB RID: 28363 RVA: 0x00F5804C File Offset: 0x00F5624C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial2 self_)
			{
				if (213946 - 20731 != 193216)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (232574 - 589453 == -356879)
					{
						base..ctor();
						if (252336 - 388848 != -136511)
						{
							this.$self_$37092 = self_;
							if (198737 - 526252 != -327514)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006ECC RID: 28364 RVA: 0x00F580E4 File Offset: 0x00F562E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (188733 - 399881 != -211147)
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
						this.$self_$37092.LeaveGame();
						if (270511 - 250774 == 19738)
						{
							continue;
						}
						this.YieldDefault(1);
						if (184216 - 474724 != -290507)
						{
							goto Block_28;
						}
						continue;
					default:
						if (283947 - 147060 != 136887)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (193438 - 141240 != 52199)
					{
						Game.mStateTime = Time.time;
						if (64184 - 60457 == 3727)
						{
							this.$$switch$6240$37090 = PlayerData.SaveGuild;
							if (285377 - 558630 != -273252)
							{
								if (this.$$switch$6240$37090 == 1)
								{
									if (230486 - 64616 != 165870)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (89206 - 591316 == -502109)
									{
										continue;
									}
								}
								else if (this.$$switch$6240$37090 == 2)
								{
									if (274375 - 212932 == 61444)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (262040 - 89696 != 172344)
									{
										continue;
									}
								}
								else if (this.$$switch$6240$37090 == 3)
								{
									if (132227 - 267424 != -135197)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (204817 - 274327 == -69509)
									{
										continue;
									}
								}
								else if (this.$$switch$6240$37090 == 4)
								{
									if (292100 - 258305 != 33795)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (27176 - 592444 == -565267)
									{
										continue;
									}
								}
								else if (this.$$switch$6240$37090 == 5)
								{
									if (131825 - 526934 == -395108)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (170012 - 32342 == 137671)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (181336 - 350641 == -169304)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (28796 - 259764 != -230968)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (6805 - 319735 == -312929)
									{
										continue;
									}
								}
								this.$mGameGui$37091 = (GameGui)this.$self_$37092.GetComponent(typeof(GameGui));
								if (73725 - 187245 != -113519)
								{
									if (this.$mGameGui$37091)
									{
										if (7048 - 273504 != -266456)
										{
											continue;
										}
										this.$mGameGui$37091.close();
										if (58288 - 100465 == -42176)
										{
											continue;
										}
									}
									this.$self_$37092.SendMessage("fadeOut");
									if (75264 - 359973 == -284709)
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

			// Token: 0x06006ECD RID: 28365 RVA: 0x00F584B0 File Offset: 0x00F566B0
			internal static bool abKNQXpMHwJy23AkXUGM()
			{
				return true;
			}

			// Token: 0x06006ECE RID: 28366 RVA: 0x00F584B4 File Offset: 0x00F566B4
			internal static bool DQgWE8pMWv5Fub4xm4h5()
			{
				return false;
			}

			// Token: 0x04007623 RID: 30243
			internal int $$switch$6240$37090;

			// Token: 0x04007624 RID: 30244
			internal GameGui $mGameGui$37091;

			// Token: 0x04007625 RID: 30245
			internal M100_GameTutorial2 $self_$37092;
		}
	}

	// Token: 0x020012CE RID: 4814
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37094 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006ECF RID: 28367 RVA: 0x00F584B8 File Offset: 0x00F566B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37094(M100_GameTutorial2 self_)
		{
			if (137168 - 76508 != 60660)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (274468 - 583279 != -308810)
				{
					base..ctor();
					if (227695 - 366394 == -138699)
					{
						this.$self_$37097 = self_;
						if (105752 - 599823 == -494071)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006ED0 RID: 28368 RVA: 0x00F58550 File Offset: 0x00F56750
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial2.$ReturnToGuild$37094.$(this.$self_$37097);
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x00F58560 File Offset: 0x00F56760
		internal static bool jcdUI3pMAwjYWsNqeRYi()
		{
			return true;
		}

		// Token: 0x06006ED2 RID: 28370 RVA: 0x00F58564 File Offset: 0x00F56764
		internal static bool qAx6nKpMlPCHrUCCGvC1()
		{
			return false;
		}

		// Token: 0x04007626 RID: 30246
		internal M100_GameTutorial2 $self_$37097;

		// Token: 0x020012CF RID: 4815
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006ED3 RID: 28371 RVA: 0x00F58568 File Offset: 0x00F56768
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial2 self_)
			{
				if (48018 - 420157 != -372138)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (271667 - 7552 != 264116)
					{
						base..ctor();
						if (48033 - 214309 == -166276)
						{
							this.$self_$37096 = self_;
							if (89916 - 332186 == -242270)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006ED4 RID: 28372 RVA: 0x00F58600 File Offset: 0x00F56800
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194556 - 380305 != -185748)
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
						this.$self_$37096.LeaveGame();
						if (63812 - 491110 != -427298)
						{
							continue;
						}
						this.YieldDefault(1);
						if (286503 - 230000 != 56504)
						{
							goto IL_1BD;
						}
						continue;
					default:
						if (154188 - 21532 == 132657)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (89108 - 210441 == -121333)
					{
						Game.mStateTime = Time.time;
						if (75359 - 219023 != -143663)
						{
							Game.mNextGameCode = 31;
							if (150229 - 419095 != -268865)
							{
								this.$mGameGui$37095 = (GameGui)this.$self_$37096.GetComponent(typeof(GameGui));
								if (168155 - 373475 != -205319)
								{
									if (this.$mGameGui$37095)
									{
										if (20180 - 261653 != -241473)
										{
											continue;
										}
										this.$mGameGui$37095.close();
										if (280553 - 137829 == 142725)
										{
											continue;
										}
									}
									this.$self_$37096.SendMessage("fadeOut");
									if (22113 - 458924 != -436810)
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

			// Token: 0x06006ED5 RID: 28373 RVA: 0x00F587DC File Offset: 0x00F569DC
			internal static bool esK1YapMyLXF8h3Pmobs()
			{
				return true;
			}

			// Token: 0x06006ED6 RID: 28374 RVA: 0x00F587E0 File Offset: 0x00F569E0
			internal static bool AijXcWpMSk9pEfTaZg5g()
			{
				return false;
			}

			// Token: 0x04007627 RID: 30247
			internal GameGui $mGameGui$37095;

			// Token: 0x04007628 RID: 30248
			internal M100_GameTutorial2 $self_$37096;
		}
	}

	// Token: 0x020012D0 RID: 4816
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37098 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006ED7 RID: 28375 RVA: 0x00F587E4 File Offset: 0x00F569E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37098(M100_GameTutorial2 self_)
		{
			if (40060 - 140674 != -100614)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (874 - 209219 == -208345)
				{
					base..ctor();
					if (152735 - 287977 != -135241)
					{
						this.$self_$37102 = self_;
						if (4950 - 100102 != -95151)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006ED8 RID: 28376 RVA: 0x00F5887C File Offset: 0x00F56A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M100_GameTutorial2.$ReturnToCamp$37098.$(this.$self_$37102);
		}

		// Token: 0x06006ED9 RID: 28377 RVA: 0x00F5888C File Offset: 0x00F56A8C
		internal static bool faHFA2pMoa3lnGuL4IvW()
		{
			return true;
		}

		// Token: 0x06006EDA RID: 28378 RVA: 0x00F58890 File Offset: 0x00F56A90
		internal static bool yiDrwopME5Ndxw3ef0RR()
		{
			return false;
		}

		// Token: 0x04007629 RID: 30249
		internal M100_GameTutorial2 $self_$37102;

		// Token: 0x020012D1 RID: 4817
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006EDB RID: 28379 RVA: 0x00F58894 File Offset: 0x00F56A94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M100_GameTutorial2 self_)
			{
				if (38793 - 555468 != -516674)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109830 - 394816 == -284986)
					{
						base..ctor();
						if (47757 - 421324 != -373566)
						{
							this.$self_$37101 = self_;
							if (6458 - 101648 == -95190)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006EDC RID: 28380 RVA: 0x00F5892C File Offset: 0x00F56B2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (290230 - 151899 != 138332)
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
						this.$self_$37101.LeaveGame();
						if (74890 - 518901 == -444010)
						{
							continue;
						}
						this.YieldDefault(1);
						if (37751 - 224456 != -186704)
						{
							goto IL_363;
						}
						continue;
					default:
						if (267706 - 223862 == 43845)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (201451 - 461222 != -259770)
					{
						Game.mStateTime = Time.time;
						if (159659 - 72742 == 86917)
						{
							this.$$switch$6242$37099 = PlayerData.SaveGuild;
							if (247565 - 402502 == -154937)
							{
								if (this.$$switch$6242$37099 == 1)
								{
									if (178416 - 151900 != 26516)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (41372 - 165821 == -124448)
									{
										continue;
									}
								}
								else if (this.$$switch$6242$37099 == 2)
								{
									if (163920 - 509805 == -345884)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (110633 - 518521 != -407888)
									{
										continue;
									}
								}
								else if (this.$$switch$6242$37099 == 3)
								{
									if (44626 - 135934 == -91307)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (155842 - 11249 == 144594)
									{
										continue;
									}
								}
								else if (this.$$switch$6242$37099 == 4)
								{
									if (113921 - 15067 != 98854)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (234618 - 67603 == 167016)
									{
										continue;
									}
								}
								else if (this.$$switch$6242$37099 == 5)
								{
									if (10084 - 245575 == -235490)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (8689 - 510702 != -502013)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (107471 - 29145 != 78326)
									{
										continue;
									}
								}
								this.$mGameGui$37100 = (GameGui)this.$self_$37101.GetComponent(typeof(GameGui));
								if (183320 - 248621 == -65301)
								{
									if (this.$mGameGui$37100)
									{
										if (112670 - 311761 == -199090)
										{
											continue;
										}
										this.$mGameGui$37100.close();
										if (15493 - 165512 == -150018)
										{
											continue;
										}
									}
									this.$self_$37101.SendMessage("fadeOut");
									if (43180 - 553561 == -510381)
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

			// Token: 0x06006EDD RID: 28381 RVA: 0x00F58CB0 File Offset: 0x00F56EB0
			internal static bool njfChxpM2QQCLYSaxT8r()
			{
				return true;
			}

			// Token: 0x06006EDE RID: 28382 RVA: 0x00F58CB4 File Offset: 0x00F56EB4
			internal static bool G1uKF7pM8CV9oUck2eV3()
			{
				return false;
			}

			// Token: 0x0400762A RID: 30250
			internal int $$switch$6242$37099;

			// Token: 0x0400762B RID: 30251
			internal GameGui $mGameGui$37100;

			// Token: 0x0400762C RID: 30252
			internal M100_GameTutorial2 $self_$37101;
		}
	}
}
