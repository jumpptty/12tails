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

// Token: 0x02001766 RID: 5990
[Serializable]
public class M708_SmackRun : MonoBehaviour
{
	// Token: 0x06008B39 RID: 35641 RVA: 0x0110B220 File Offset: 0x01109420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M708_SmackRun()
	{
		if (156826 - 570112 != -413285)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (222603 - 382607 == -160004)
			{
				base..ctor();
				if (242541 - 504331 == -261790)
				{
					this.Cw0cV7Cqqko = new int[8];
					if (295275 - 325351 == -30076)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008B3A RID: 35642 RVA: 0x0110B2C0 File Offset: 0x011094C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (103624 - 72941 != 30684)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (104132 - 247917 == -143785)
			{
				Game.mGameType = 5;
				if (281940 - 279420 == 2520)
				{
					if (Chat.Initialized)
					{
						if (169909 - 504281 != -334371)
						{
							Chat.ChatDisplay.Clear();
							if (27081 - 254485 != -227403)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (277497 - 86305 == 191192)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008B3B RID: 35643 RVA: 0x0110B3A4 File Offset: 0x011095A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (155691 - 226959 != -71267)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (216782 - 539221 != -322438)
				{
					if (Game.mNextGameCode != 708)
					{
						break;
					}
					if (179580 - 466650 != -287069)
					{
						Game.nextGame();
						if (42389 - 192742 == -150353)
						{
							Game.mGameCode = 708;
							if (294790 - 447641 != -152850)
							{
								Game.mGameType = 5;
								if (261508 - 174880 != 86629)
								{
									Game.mGameTime = (float)0;
									if (70484 - 509365 != -438880)
									{
										Game.mGameScore = 0;
										if (222660 - 410458 != -187797)
										{
											Game.mGameMana = 0;
											if (29688 - 377570 == -347882)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (115691 - 491317 != -375625)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (236022 - 230910 == 5112)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (64986 - 450619 == -385633)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (26590 - 304920 == -278330)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (37713 - 414475 != -376761)
																{
																	this.VLbcV4wwbwT = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (22850 - 165388 == -142538)
																	{
																		this.aU9cVa1HuBQ = PhotonClient.Connection;
																		if (245462 - 149026 != 96437)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (255995 - 438426 == -182431)
																			{
																				this.InitGame();
																				if (276717 - 410367 != -133649)
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
				if (44714 - 463776 != -419061)
				{
					Game.mGameType = 99;
					if (186834 - 584843 == -398009)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008B3C RID: 35644 RVA: 0x0110B6A8 File Offset: 0x011098A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (170532 - 71387 != 99145)
		{
		}
		for (;;)
		{
			IL_538:
			if (this.aU9cVa1HuBQ == null)
			{
				if (152128 - 139097 != 13032)
				{
					break;
				}
			}
			else
			{
				if (Game.mGameTime != (float)0)
				{
					if (5340 - 6284 != -944)
					{
						continue;
					}
					if (Game.mGameTime - Time.time <= (float)0)
					{
						if (153265 - 569476 != -416211)
						{
							continue;
						}
						Game.mGameTime = (float)0;
						if (279717 - 90492 != 189225)
						{
							continue;
						}
						int num = 0;
						if (194867 - 451213 == -256345)
						{
							continue;
						}
						int num2 = 0;
						if (215388 - 213489 == 1900)
						{
							continue;
						}
						GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
						if (286474 - 76982 != 209492)
						{
							continue;
						}
						int i = 0;
						if (82210 - 64775 != 17435)
						{
							continue;
						}
						GameObject[] array2 = array;
						if (38668 - 222145 != -183477)
						{
							continue;
						}
						int length = array2.Length;
						if (4894 - 524512 == -519617)
						{
							continue;
						}
						while (i < length)
						{
							CharacterControl characterControl = (CharacterControl)array2[i].GetComponent(typeof(CharacterControl));
							if (150733 - 562379 != -411646)
							{
								goto IL_538;
							}
							if (characterControl)
							{
								if (114956 - 531792 == -416835)
								{
									goto IL_538;
								}
								if (characterControl.mOriginalLayer == 8)
								{
									if (195186 - 4390 != 190796)
									{
										goto IL_538;
									}
									num++;
									if (145339 - 380252 != -234913)
									{
										goto IL_538;
									}
								}
								else
								{
									num2++;
									if (190100 - 563800 == -373699)
									{
										goto IL_538;
									}
								}
							}
							i++;
							if (161831 - 355739 != -193908)
							{
								goto IL_538;
							}
						}
						if (59739 - 292271 == -232531)
						{
							continue;
						}
						if (num != 0)
						{
							if (283213 - 40202 != 243011)
							{
								continue;
							}
							if (num2 == 0)
							{
								if (28400 - 300552 != -272152)
								{
									continue;
								}
							}
							else
							{
								Game.sendMissionEvent(7081, this.AhtcVHs58FC + 1);
								if (63125 - 532006 != -468880)
								{
									goto IL_330;
								}
								continue;
							}
						}
						Game.sendMissionEvent(7084, 0);
						if (189910 - 215025 != -25115)
						{
							continue;
						}
					}
				}
				IL_330:
				eGameState mGameState = Game.mGameState;
				if (239665 - 53656 != 186010)
				{
					if (mGameState == eGameState.Init)
					{
						if (22832 - 453622 != -430789)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (181801 - 199947 == -18146)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (229057 - 150270 == 78787)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (219310 - 476428 != -257117)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (22901 - 303565 != -280663)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (153181 - 466170 != -312988)
						{
							if (Time.time > this.sTVcVsxGYJk)
							{
								if (128694 - 203543 == -74848)
								{
									continue;
								}
								Game.mGameMana++;
								if (123987 - 319569 != -195582)
								{
									continue;
								}
								this.sTVcVsxGYJk = Time.time + (float)12;
								if (68917 - 131686 == -62768)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (97058 - 42605 == 54454)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (154017 - 167554 == -13536)
									{
										continue;
									}
									this.audio.Play();
									if (295803 - 45659 == 250145)
									{
										continue;
									}
								}
							}
							this.audio.volume = 0.1f * (float)Game.music;
							if (48515 - 334474 == -285959)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (22527 - 22196 != 332)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (52565 - 574575 != -522009)
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
						if (100848 - 380625 != -279776)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008B3D RID: 35645 RVA: 0x0110BC7C File Offset: 0x01109E7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterSmackGoal(GameObject enterObject)
	{
		if (12343 - 516655 != -504312)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (23166 - 215936 == -192770)
				{
					break;
				}
			}
			else
			{
				if (!Game.mPlayer)
				{
					break;
				}
				if (256719 - 562456 != -305736)
				{
					if (!(Game.mPlayer == enterObject))
					{
						break;
					}
					if (240925 - 373086 == -132161)
					{
						CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
						if (291214 - 330702 == -39488)
						{
							if (!characterControl)
							{
								break;
							}
							if (210121 - 179551 != 30571)
							{
								if (characterControl.mOriginalLayer % 2 != this.AhtcVHs58FC % 2)
								{
									break;
								}
								if (146469 - 383066 != -236596)
								{
									Game.mGameState = eGameState.Hold;
									if (106273 - 454615 != -348341)
									{
										this.mkAcVfJvwdq = Time.time + (float)2;
										if (49033 - 36397 == 12636)
										{
											if (characterControl.mOriginalLayer == 8)
											{
												if (162228 - 60762 != 101467)
												{
													Game.sendMissionEvent(7082, this.AhtcVHs58FC);
													if (20646 - 528797 != -508150)
													{
														break;
													}
												}
											}
											else
											{
												Game.sendMissionEvent(7083, this.AhtcVHs58FC);
												if (37598 - 457036 == -419438)
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

	// Token: 0x06008B3E RID: 35646 RVA: 0x0110BE7C File Offset: 0x0110A07C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartNextRound(int nRound)
	{
		return new M708_SmackRun.$StartNextRound$40570(nRound, this).GetEnumerator();
	}

	// Token: 0x06008B3F RID: 35647 RVA: 0x0110BE8C File Offset: 0x0110A08C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSummon(GameObject nSummon)
	{
		if (92422 - 351423 != -259000)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("runCollision");
			if (172683 - 119065 == 53618)
			{
				GameObject gameObject2 = GameObject.Find("zoneCollision");
				if (89726 - 14539 != 75188)
				{
					if ((nSummon.layer + this.AhtcVHs58FC) % 2 == 1)
					{
						if (292279 - 141270 != 151010)
						{
							Physics.IgnoreCollision(nSummon.collider, gameObject.collider, false);
							if (139293 - 461428 == -322135)
							{
								Physics.IgnoreCollision(nSummon.collider, gameObject2.collider, true);
								if (22685 - 330936 == -308251)
								{
									break;
								}
							}
						}
					}
					else
					{
						Physics.IgnoreCollision(nSummon.collider, gameObject.collider, true);
						if (37438 - 494057 != -456618)
						{
							Physics.IgnoreCollision(nSummon.collider, gameObject2.collider, false);
							if (79193 - 483293 == -404100)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008B40 RID: 35648 RVA: 0x0110BFF4 File Offset: 0x0110A1F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onTransform(GameObject nTransform)
	{
		if (81713 - 235936 != -154222)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("runCollision");
			if (181927 - 25006 == 156921)
			{
				GameObject gameObject2 = GameObject.Find("zoneCollision");
				if (78697 - 106742 != -28044)
				{
					if ((nTransform.layer + this.AhtcVHs58FC) % 2 == 1)
					{
						if (244548 - 406743 != -162194)
						{
							Physics.IgnoreCollision(nTransform.collider, gameObject.collider, false);
							if (251432 - 273478 == -22046)
							{
								Physics.IgnoreCollision(nTransform.collider, gameObject2.collider, true);
								if (64617 - 341577 == -276960)
								{
									break;
								}
							}
						}
					}
					else
					{
						Physics.IgnoreCollision(nTransform.collider, gameObject.collider, true);
						if (156885 - 406345 == -249460)
						{
							Physics.IgnoreCollision(nTransform.collider, gameObject2.collider, false);
							if (131319 - 572263 == -440944)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008B41 RID: 35649 RVA: 0x0110C15C File Offset: 0x0110A35C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (130059 - 196853 != -66794)
		{
		}
		for (;;)
		{
			if (this.AhtcVHs58FC != 0)
			{
				if (220290 - 23495 == 196796)
				{
					continue;
				}
				if (this.fqRcVM1Mptj < Time.time)
				{
					if (21949 - 263869 != -241920)
					{
						continue;
					}
					if (this.mkAcVfJvwdq < Time.time)
					{
						if (201640 - 245642 != -44001)
						{
							break;
						}
						continue;
					}
				}
			}
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (58568 - 49882 == 8686)
			{
				float num = this.fqRcVM1Mptj - Time.time;
				if (189051 - 159707 != 29345)
				{
					float num2 = (float)1;
					if (60439 - 10451 != 49989)
					{
						float num3 = (float)(1024 * Screen.width / Screen.height);
						if (237231 - 226277 != 10955)
						{
							GUI.depth = 1;
							if (154235 - 473030 == -318795)
							{
								if (this.AhtcVHs58FC == 0)
								{
									if (12924 - 234127 != -221203)
									{
										continue;
									}
									if (Time.time - Game.mGameTime > (float)3)
									{
										if (146784 - 181719 == -34934)
										{
											continue;
										}
										if (Time.time - Game.mGameTime < (float)5)
										{
											if (27613 - 241256 == -213642)
											{
												continue;
											}
											num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime - (float)3);
											if (207881 - 88410 == 119472)
											{
												continue;
											}
											float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime - (float)3, (float)1));
											if (73387 - 403686 == -330298)
											{
												continue;
											}
											Color color = GUI.color;
											if (199418 - 246699 == -47280)
											{
												continue;
											}
											color.a = a;
											if (233541 - 113043 == 120499 || 118200 - 554564 == -436363)
											{
												continue;
											}
											Color color2 = GUI.color = color;
											if (81661 - 474109 == -392447)
											{
												continue;
											}
											if (278064 - 493873 != -215809)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num3 - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.VdAcVLqH7AY);
											if (208917 - 72585 != 136333)
											{
												goto IL_A11;
											}
											continue;
										}
									}
								}
								if (this.mkAcVfJvwdq > Time.time)
								{
									if (81350 - 452134 == -370783)
									{
										continue;
									}
									num2 = Mathf.SmoothStep((float)1, 1.5f, Time.time - this.mkAcVfJvwdq);
									if (226571 - 521709 == -295137)
									{
										continue;
									}
									float a2 = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - this.mkAcVfJvwdq, (float)1));
									if (241233 - 429922 == -188688)
									{
										continue;
									}
									Color color3 = GUI.color;
									if (106163 - 161691 != -55528)
									{
										continue;
									}
									color3.a = a2;
									if (111935 - 438757 != -326822)
									{
										continue;
									}
									if (1630 - 286766 == -285135)
									{
										continue;
									}
									GUI.color = color3;
									if (153491 - 379638 == -226146 || 26875 - 151562 == -124686)
									{
										continue;
									}
									GUI.DrawTexture(new Rect(0.5f * num3 - 252f * num2, (float)450 - 75f * num2, (float)504 * num2, (float)150 * num2), this.Gb5cVPKJdT6);
									if (97440 - 120369 == -22928)
									{
										continue;
									}
								}
								else if (num > (float)3)
								{
									if (184313 - 599563 == -415249)
									{
										continue;
									}
									num2 = Mathf.SmoothStep((float)1, (float)2, num - (float)3);
									if (201436 - 21360 == 180077)
									{
										continue;
									}
									float a3 = Mathf.SmoothStep((float)0, (float)1, num - (float)3);
									if (285658 - 289409 == -3750)
									{
										continue;
									}
									Color color4 = GUI.color;
									if (203073 - 165334 != 37739)
									{
										continue;
									}
									float num4 = color4.a = a3;
									if (182721 - 242505 != -59784)
									{
										continue;
									}
									if (133948 - 320914 == -186965)
									{
										continue;
									}
									GUI.color = color4;
									if (154143 - 369694 == -215550 || 201497 - 225869 == -24371)
									{
										continue;
									}
									if (this.LxGcVNgRGaT)
									{
										if (83148 - 233573 == -150424)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(0.5f * num3 - 34f * num2, (float)350 - 43.5f * num2, (float)68 * num2, (float)87 * num2), this.LxGcVNgRGaT);
										if (175469 - 180814 != -5345)
										{
											continue;
										}
									}
								}
								else if (num > (float)2)
								{
									if (161891 - 453722 == -291830)
									{
										continue;
									}
									num2 = Mathf.SmoothStep((float)1, (float)2, num - (float)2);
									if (287048 - 192931 != 94117)
									{
										continue;
									}
									float a4 = Mathf.SmoothStep((float)0, (float)1, num - (float)2);
									if (226974 - 377721 == -150746)
									{
										continue;
									}
									Color color5 = GUI.color;
									if (288027 - 184783 == 103245)
									{
										continue;
									}
									color5.a = a4;
									if (268248 - 195599 != 72649)
									{
										continue;
									}
									if (194923 - 291968 != -97045)
									{
										continue;
									}
									GUI.color = color5;
									if (43013 - 111542 != -68529)
									{
										continue;
									}
									if (14280 - 327435 != -313155)
									{
										continue;
									}
									if (this.kq7cVURpk0I)
									{
										if (281684 - 300669 == -18984)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(0.5f * num3 - 32.5f * num2, (float)350 - 43.5f * num2, (float)65 * num2, (float)87 * num2), this.kq7cVURpk0I);
										if (159310 - 302539 != -143229)
										{
											continue;
										}
									}
								}
								else if (num > (float)1)
								{
									if (19124 - 56841 == -37716)
									{
										continue;
									}
									num2 = Mathf.SmoothStep((float)1, (float)2, num - (float)1);
									if (102896 - 471981 == -369084)
									{
										continue;
									}
									float a5 = Mathf.SmoothStep((float)0, (float)1, num - (float)1);
									if (99257 - 270355 != -171098)
									{
										continue;
									}
									Color color6 = GUI.color;
									if (105712 - 353102 != -247390)
									{
										continue;
									}
									float num5 = color6.a = a5;
									if (211874 - 167563 == 44312)
									{
										continue;
									}
									if (64256 - 539930 != -475674)
									{
										continue;
									}
									GUI.color = color6;
									if (222720 - 78430 == 144291 || 35462 - 491155 == -455692)
									{
										continue;
									}
									if (this.R9mcVw0SWsE)
									{
										if (167505 - 318326 == -150820)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(0.5f * num3 - 28f * num2, (float)350 - 43.5f * num2, (float)56 * num2, (float)87 * num2), this.R9mcVw0SWsE);
										if (251755 - 510867 == -259111)
										{
											continue;
										}
									}
								}
								else
								{
									num2 = Mathf.SmoothStep(1.2f, (float)1, num);
									if (143187 - 22184 != 121003)
									{
										continue;
									}
									float a6 = Mathf.SmoothStep((float)0, (float)1, num);
									if (13104 - 31580 == -18475)
									{
										continue;
									}
									Color color7 = GUI.color;
									if (51349 - 201711 != -150362)
									{
										continue;
									}
									color7.a = a6;
									if (269427 - 158755 != 110672)
									{
										continue;
									}
									if (142544 - 505401 != -362857)
									{
										continue;
									}
									Color color8 = GUI.color = color7;
									if (268131 - 317778 == -49646 || 144704 - 561936 == -417231)
									{
										continue;
									}
									GUI.DrawTexture(new Rect(0.5f * num3 - 84.5f * num2, (float)350 - 42.5f * num2, (float)169 * num2, (float)85 * num2), this.NLocVExht9S);
									if (261366 - 292399 != -31033)
									{
										continue;
									}
								}
								IL_A11:
								float a7 = 1f;
								if (114245 - 594585 == -480340)
								{
									Color color9 = GUI.color;
									if (192113 - 95832 == 96281)
									{
										float num6 = color9.a = a7;
										if (156788 - 207591 != -50802 && 19049 - 481533 != -462483)
										{
											Color color10 = GUI.color = color9;
											if (39149 - 139786 != -100636 && 44073 - 166665 != -122591)
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

	// Token: 0x06008B42 RID: 35650 RVA: 0x0110CD64 File Offset: 0x0110AF64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (51438 - 539830 != -488392)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (235782 - 461568 == -225786)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (189720 - 568440 == -378720)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (197266 - 78846 != 118421)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (191004 - 390006 == -199002)
						{
							int num4 = num;
							if (153373 - 480405 == -327032)
							{
								if (num4 == 7081)
								{
									if (52730 - 395896 != -343165)
									{
										break;
									}
								}
								else if (num4 == -7081)
								{
									if (122147 - 444566 == -322419)
									{
										if (this.AhtcVHs58FC >= num2)
										{
											break;
										}
										if (143985 - 470840 != -326854)
										{
											this.StartCoroutine_Auto(this.StartNextRound(num2));
											if (184490 - 53310 != 131181)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 7082)
								{
									if (263780 - 22339 == 241441)
									{
										break;
									}
								}
								else if (num4 == -7082)
								{
									if (161320 - 503841 == -342521)
									{
										if (num2 != 0)
										{
											if (91136 - 332093 != -240957)
											{
												continue;
											}
											if (num2 != 2)
											{
												if (115598 - 16826 != 98772)
												{
													continue;
												}
												if (num2 == 4)
												{
													if (153314 - 468224 == -314909)
													{
														continue;
													}
												}
												else
												{
													Debug.LogError("Unknown score1 smack round: " + num2);
													if (208770 - 175140 != 33631)
													{
														break;
													}
													continue;
												}
											}
										}
										this.Cw0cV7Cqqko[num2] = this.Cw0cV7Cqqko[num2] + 1;
										if (241717 - 557657 == -315940)
										{
											this.Cw0cV7Cqqko[6] = this.Cw0cV7Cqqko[0] + this.Cw0cV7Cqqko[2] + this.Cw0cV7Cqqko[4];
											if (102278 - 317901 != -215622)
											{
												this.SendMessage("newGameMessage", "TouchDown: " + this.Cw0cV7Cqqko[num2]);
												if (56977 - 222124 != -165146)
												{
													GameObject gameObject = GameObject.Find("SmackScore" + (this.AhtcVHs58FC + 1));
													if (185190 - 206920 == -21730)
													{
														if (gameObject)
														{
															if (283427 - 196700 == 86728)
															{
																continue;
															}
															gameObject.animation.Play("score" + this.Cw0cV7Cqqko[num2]);
															if (43349 - 18751 == 24599)
															{
																continue;
															}
														}
														else
														{
															Debug.LogError("Cannot find score" + (this.AhtcVHs58FC + 1));
															if (89169 - 314961 == -225791)
															{
																continue;
															}
														}
														if (this.Cw0cV7Cqqko[6] % 10 == 0)
														{
															if (85119 - 447324 != -362205)
															{
																continue;
															}
															GameObject gameObject2 = GameObject.Find("SmackScore10");
															if (246799 - 336052 == -89252)
															{
																continue;
															}
															if (gameObject2)
															{
																if (214472 - 424360 != -209888)
																{
																	continue;
																}
																gameObject2.animation.Play("score" + global::Math.div((float)this.Cw0cV7Cqqko[6], (float)10));
																if (21523 - 310444 == -288920)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Cannot find SmackScore10");
																if (218122 - 166658 == 51465)
																{
																	continue;
																}
															}
														}
														GameObject gameObject3 = GameObject.Find("SmackScore11");
														if (121758 - 488271 != -366512)
														{
															if (gameObject3)
															{
																if (60306 - 242482 == -182175)
																{
																	continue;
																}
																gameObject3.animation.Play("score" + this.Cw0cV7Cqqko[6] % 10);
																if (115293 - 533232 == -417938)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Cannot find SmackScore11");
																if (133283 - 1834 == 131450)
																{
																	continue;
																}
															}
															this.VNycVZ2RVZc--;
															if (136526 - 540902 == -404376)
															{
																if (this.VNycVZ2RVZc != 0)
																{
																	break;
																}
																if (75036 - 112678 == -37642)
																{
																	if (Game.mGameTime == (float)0)
																	{
																		break;
																	}
																	if (198782 - 506107 == -307325)
																	{
																		if (Game.mGameTime - Time.time < (float)6)
																		{
																			break;
																		}
																		if (124797 - 465972 != -341174)
																		{
																			Game.mGameTime = Time.time + (float)3;
																			if (214205 - 96541 == 117664)
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
								else if (num4 == 7083)
								{
									if (169709 - 54086 == 115623)
									{
										break;
									}
								}
								else
								{
									if (num4 != -7083)
									{
										break;
									}
									if (168861 - 332332 == -163471)
									{
										if (num2 != 1)
										{
											if (249971 - 315271 == -65299)
											{
												continue;
											}
											if (num2 != 3)
											{
												if (292130 - 197129 == 95002)
												{
													continue;
												}
												if (num2 != 5)
												{
													break;
												}
												if (280492 - 190171 != 90321)
												{
													continue;
												}
											}
										}
										this.Cw0cV7Cqqko[num2] = this.Cw0cV7Cqqko[num2] + 1;
										if (268080 - 510849 == -242769)
										{
											this.Cw0cV7Cqqko[7] = this.Cw0cV7Cqqko[1] + this.Cw0cV7Cqqko[3] + this.Cw0cV7Cqqko[5];
											if (104187 - 385897 == -281710)
											{
												this.SendMessage("newGameMessage", "TouchDown : " + this.Cw0cV7Cqqko[num2]);
												if (166579 - 354699 == -188120)
												{
													this.E4pcVCLPSoD--;
													if (139830 - 505204 != -365373)
													{
														GameObject gameObject4 = GameObject.Find("SmackScore" + (this.AhtcVHs58FC + 1));
														if (43986 - 454636 == -410650)
														{
															if (gameObject4)
															{
																if (142864 - 50274 == 92591)
																{
																	continue;
																}
																gameObject4.animation.Play("score" + this.Cw0cV7Cqqko[num2]);
																if (210310 - 305205 == -94894)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Cannot find score" + (this.AhtcVHs58FC + 1));
																if (185454 - 362306 == -176851)
																{
																	continue;
																}
															}
															if (this.Cw0cV7Cqqko[7] % 10 == 0)
															{
																if (175333 - 8708 != 166625)
																{
																	continue;
																}
																GameObject gameObject5 = GameObject.Find("SmackScore20");
																if (47056 - 180902 == -133845)
																{
																	continue;
																}
																if (gameObject5)
																{
																	if (92646 - 210945 != -118299)
																	{
																		continue;
																	}
																	gameObject5.animation.Play("score" + global::Math.div((float)this.Cw0cV7Cqqko[7], (float)10));
																	if (278530 - 498006 == -219475)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Cannot find SmackScore20");
																	if (70014 - 433076 != -363062)
																	{
																		continue;
																	}
																}
															}
															GameObject gameObject6 = GameObject.Find("SmackScore21");
															if (103093 - 363526 == -260433)
															{
																if (gameObject6)
																{
																	if (66351 - 390499 == -324147)
																	{
																		continue;
																	}
																	gameObject6.animation.Play("score" + this.Cw0cV7Cqqko[7] % 10);
																	if (57841 - 594357 != -536516)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Cannot find mSmackScore21");
																	if (271716 - 27427 != 244289)
																	{
																		continue;
																	}
																}
																if (this.E4pcVCLPSoD != 0)
																{
																	break;
																}
																if (230692 - 473246 != -242553)
																{
																	if (Game.mGameTime == (float)0)
																	{
																		break;
																	}
																	if (230791 - 516404 != -285612)
																	{
																		if (Game.mGameTime - Time.time < (float)6)
																		{
																			break;
																		}
																		if (82035 - 25868 != 56168)
																		{
																			Game.mGameTime = Time.time + (float)3;
																			if (74655 - 298333 != -223677)
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

	// Token: 0x06008B43 RID: 35651 RVA: 0x0110D86C File Offset: 0x0110BA6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (275830 - 502317 != -226487)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (132074 - 361638 != -229563)
			{
				Time.timeScale = 1f;
				if (5298 - 499022 == -493724)
				{
					Hashtable customOpParameters = new Hashtable();
					if (231087 - 552860 != -321772)
					{
						this.aU9cVa1HuBQ.OpCustom(52, customOpParameters, true);
						if (46346 - 256871 != -210524)
						{
							this.VdAcVLqH7AY = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
							if (175906 - 501447 == -325541)
							{
								this.R9mcVw0SWsE = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
								if (141099 - 125431 != 15669)
								{
									this.kq7cVURpk0I = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
									if (214352 - 569345 != -354992)
									{
										this.LxGcVNgRGaT = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
										if (247083 - 101154 == 145929)
										{
											this.NLocVExht9S = (Texture)Resources.Load("GameGui/Title/go", typeof(Texture));
											if (108903 - 184197 == -75294)
											{
												this.Gb5cVPKJdT6 = (Texture)Resources.Load("GameGui/Title/goal", typeof(Texture));
												if (216423 - 350936 != -134512)
												{
													this.iIEcVSuWndy = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
													if (190039 - 246045 != -56005)
													{
														this.AKycVBadMVF = (AudioClip)Resources.Load("Sound/GUI/whistle", typeof(AudioClip));
														if (240667 - 138160 != 102508)
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

	// Token: 0x06008B44 RID: 35652 RVA: 0x0110DB00 File Offset: 0x0110BD00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (289133 - 468216 != -179082)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (158113 - 376718 != -218604)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (167122 - 251366 != -84243)
				{
					Game.mGameState = eGameState.Setup;
					if (32296 - 279921 != -247624)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008B45 RID: 35653 RVA: 0x0110DBA4 File Offset: 0x0110BDA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (37956 - 343298 != -305342)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (74079 - 2187 == 71892)
			{
				if (num == PlayerData.UID)
				{
					if (198612 - 112286 != 86327)
					{
						this.SetupActors();
						if (261717 - 401474 != -139756)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (22511 - 234426 == -211915)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008B46 RID: 35654 RVA: 0x0110DC74 File Offset: 0x0110BE74
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (113184 - 313140 != -199955)
		{
		}
		for (;;)
		{
			IL_1A:
			Debug.Log("Creating Actors");
			if (625 - 476661 != -476035)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (131440 - 122371 == 9069)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (126673 - 189598 == -62925)
						{
							int i = 0;
							if (5186 - 395835 == -390649)
							{
								CharacterControl[] array2 = array;
								if (33643 - 265757 == -232114)
								{
									int length = array2.Length;
									if (124096 - 506748 == -382652)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (144807 - 133601 != 11206)
												{
													goto IL_1A;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (119842 - 341748 == -221905)
												{
													goto IL_1A;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (155287 - 592424 != -437137)
												{
													goto IL_1A;
												}
												this.K8ycV0tyhyD++;
												if (102137 - 475716 != -373579)
												{
													goto IL_1A;
												}
											}
											i++;
											if (165074 - 360532 == -195457)
											{
												goto IL_1A;
											}
										}
										if (214588 - 494068 == -279480)
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
						if (34869 - 165747 == -130878)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008B47 RID: 35655 RVA: 0x0110DEB0 File Offset: 0x0110C0B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (12596 - 160097 != -147501)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (139727 - 301423 != -161695)
			{
				int i = 0;
				if (171312 - 136842 == 34470)
				{
					CharacterControl[] array2 = array;
					if (7295 - 547035 != -539739)
					{
						int length = array2.Length;
						if (80404 - 333075 == -252671)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (46815 - 316109 == -269293)
								{
									goto IL_E0;
								}
								i++;
								if (299758 - 154520 != 145238)
								{
									goto IL_E0;
								}
							}
							if (141985 - 518603 != -376617)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008B48 RID: 35656 RVA: 0x0110DFE0 File Offset: 0x0110C1E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (85574 - 462265 != -376690)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (49102 - 191626 == -142524)
			{
				Game.mGameState = eGameState.Ready;
				if (1161 - 63232 != -62070)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (123382 - 310800 != -187417 && 246550 - 565653 != -319102)
					{
						if (20358 - 518043 == -497685)
						{
							GameObject gameObject;
							GameObject gameObject2;
							if (playerSlot % 2 == 1)
							{
								if (214123 - 219902 != -5779)
								{
									continue;
								}
								gameObject = GameObject.Find("StartPoint" + (global::Math.div((float)playerSlot, (float)2) + 1));
								if (231740 - 480695 != -248955)
								{
									continue;
								}
								gameObject2 = GameObject.Find("StartCamera" + (global::Math.div((float)playerSlot, (float)2) + 1));
								if (227556 - 5346 == 222211)
								{
									continue;
								}
							}
							else
							{
								gameObject = GameObject.Find("StartPoint" + (global::Math.div((float)playerSlot, (float)2) + 5));
								if (199788 - 66645 == 133144)
								{
									continue;
								}
								gameObject2 = GameObject.Find("StartPoint" + (global::Math.div((float)playerSlot, (float)2) + 5));
								if (224633 - 565071 == -340437)
								{
									continue;
								}
							}
							if (gameObject)
							{
								if (50021 - 549275 != -499254)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, (playerSlot - 1) % 2 + 1, gameObject.transform.position, gameObject.transform.forward);
								if (213023 - 535853 != -322830)
								{
									continue;
								}
							}
							if (!gameObject2)
							{
								break;
							}
							if (258255 - 199919 == 58336)
							{
								this.transform.position = gameObject2.transform.position;
								if (146786 - 387363 == -240577)
								{
									this.transform.rotation = gameObject2.transform.rotation;
									if (222406 - 484835 == -262429)
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

	// Token: 0x06008B49 RID: 35657 RVA: 0x0110E2BC File Offset: 0x0110C4BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M708_SmackRun.$StartGame$40595(this).GetEnumerator();
	}

	// Token: 0x06008B4A RID: 35658 RVA: 0x0110E2CC File Offset: 0x0110C4CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008B4B RID: 35659 RVA: 0x0110E2D0 File Offset: 0x0110C4D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (264153 - 363899 != -99745)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (154698 - 109898 == 44800)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (57533 - 393236 == -335703)
				{
					hashtable.Add(43, PlayerData.UID);
					if (9467 - 589162 == -579695)
					{
						hashtable.Add(73, nType);
						if (167166 - 93647 != 73520)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (103762 - 540319 == -436557)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (268978 - 535891 != -266912)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (184242 - 153145 != 31098)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (193204 - 586848 == -393644)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (138615 - 83871 != 54745)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (229164 - 591781 == -362617)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (85777 - 535334 == -449557)
													{
														this.aU9cVa1HuBQ.OpCustom(63, hashtable, true);
														if (40999 - 582368 == -541369)
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

	// Token: 0x06008B4C RID: 35660 RVA: 0x0110E5B4 File Offset: 0x0110C7B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (174419 - 211499 != -37079)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (227664 - 531791 == -304127)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (205215 - 217711 != -12495)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (150223 - 522301 == -372078)
						{
							if (this.K8ycV0tyhyD <= 0)
							{
								break;
							}
							if (147078 - 289896 == -142818)
							{
								this.K8ycV0tyhyD--;
								if (288363 - 317439 != -29075)
								{
									if (this.K8ycV0tyhyD != 0)
									{
										break;
									}
									if (16301 - 252174 != -235872)
									{
										Game.setGameState(eGameState.Ready);
										if (37976 - 238164 != -200187)
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
						if (104346 - 133771 == -29425)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (80536 - 174652 == -94116)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008B4D RID: 35661 RVA: 0x0110E744 File Offset: 0x0110C944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008B4E RID: 35662 RVA: 0x0110E758 File Offset: 0x0110C958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008B4F RID: 35663 RVA: 0x0110E76C File Offset: 0x0110C96C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (70331 - 120300 != -49969)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (171273 - 336141 == -164868)
			{
				hashtable.Add(71, CID);
				if (58283 - 364867 != -306583)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (148157 - 404609 != -256451)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (23802 - 17206 != 6597)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (260468 - 428563 == -168095)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (25911 - 547523 != -521611)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (278443 - 70838 == 207605)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (157741 - 444548 != -286806)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (274139 - 430414 != -156274)
											{
												this.aU9cVa1HuBQ.OpCustom(61, hashtable, true);
												if (236756 - 203776 != 32981)
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

	// Token: 0x06008B50 RID: 35664 RVA: 0x0110E9F8 File Offset: 0x0110CBF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (27575 - 216244 != -188668)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (40850 - 26368 == 14482)
			{
				if (!gameObject)
				{
					break;
				}
				if (218832 - 166447 != 52386)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (280988 - 414744 != -133755)
					{
						playerCameraControl.target = gameObject;
						if (148410 - 393458 == -245048)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (79459 - 61942 == 17517)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008B51 RID: 35665 RVA: 0x0110EAF0 File Offset: 0x0110CCF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (292400 - 73059 != 219342)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (187589 - 166581 != 21009)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (167400 - 421035 != -253634)
				{
					gameGui.ResetTeamBar();
					if (293209 - 444089 != -150879)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008B52 RID: 35666 RVA: 0x0110EB9C File Offset: 0x0110CD9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M708_SmackRun.$onDeadPlayer$40599(this).GetEnumerator();
	}

	// Token: 0x06008B53 RID: 35667 RVA: 0x0110EBAC File Offset: 0x0110CDAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (34052 - 451968 != -417915)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (97426 - 134419 != -36992)
			{
				this.VLbcV4wwbwT.target = Game.mPlayer;
				if (201468 - 529584 != -328115)
				{
					this.VLbcV4wwbwT.enabled = true;
					if (124651 - 366279 != -241627)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (271557 - 284088 != -12531)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (123629 - 215102 != -91473)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (120667 - 575107 == -454440)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (214748 - 37623 == 177125)
							{
								if (!gameGui)
								{
									break;
								}
								if (153349 - 116177 == 37172)
								{
									gameGui.enabled = true;
									if (189907 - 597787 != -407879)
									{
										gameGui.closeDeadMenu();
										if (103042 - 362366 != -259323)
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

	// Token: 0x06008B54 RID: 35668 RVA: 0x0110ED58 File Offset: 0x0110CF58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (34959 - 427897 != -392937)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (157481 - 144059 == 13422)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (161970 - 71505 != 90466)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (219619 - 315236 == -95617)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008B55 RID: 35669 RVA: 0x0110EE1C File Offset: 0x0110D01C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008B56 RID: 35670 RVA: 0x0110EE48 File Offset: 0x0110D048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M708_SmackRun.$onGameComplete$40605(data, this).GetEnumerator();
	}

	// Token: 0x06008B57 RID: 35671 RVA: 0x0110EE58 File Offset: 0x0110D058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M708_SmackRun.$ReturnToTown$40616(this).GetEnumerator();
	}

	// Token: 0x06008B58 RID: 35672 RVA: 0x0110EE68 File Offset: 0x0110D068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M708_SmackRun.$ReturnToGuild$40621(this).GetEnumerator();
	}

	// Token: 0x06008B59 RID: 35673 RVA: 0x0110EE78 File Offset: 0x0110D078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M708_SmackRun.$ReturnToCamp$40625(this).GetEnumerator();
	}

	// Token: 0x06008B5A RID: 35674 RVA: 0x0110EE88 File Offset: 0x0110D088
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (75187 - 499687 != -424499)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (252227 - 490299 == -238072)
			{
				Hashtable hashtable = new Hashtable();
				if (230001 - 481774 == -251773)
				{
					hashtable.Add(43, PlayerData.UID);
					if (92031 - 410827 == -318796)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (181997 - 339886 != -157888)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008B5B RID: 35675 RVA: 0x0110EF60 File Offset: 0x0110D160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008B5C RID: 35676 RVA: 0x0110EF74 File Offset: 0x0110D174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (269889 - 432368 != -162478)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (142037 - 555295 == -413258)
			{
				Hashtable hashtable = new Hashtable();
				if (73006 - 531750 == -458744)
				{
					if (Game.mNextGameCode == 30)
					{
						if (202991 - 563163 == -360171)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (219008 - 498102 == -279093)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (216599 - 63783 == 152817)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (233444 - 509603 != -276159)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (297437 - 373075 == -75637)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (275022 - 347199 == -72176)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (246728 - 162421 == 84308)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (60924 - 425723 != -364799)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (51832 - 578374 != -526542)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (116862 - 356644 == -239781)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (232391 - 234321 == -1929)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (116498 - 489914 != -373416)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (189610 - 335476 == -145865)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (220448 - 273648 == -53199)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (133820 - 82289 != 51531)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (277210 - 45440 == 231771)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (226518 - 165601 != 60917)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (251591 - 171588 == 80004)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (68379 - 248875 == -180495)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (263654 - 55646 != 208008)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (134956 - 267659 == -132702)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (112703 - 215867 != -103164)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (83684 - 163915 != -80231)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (45639 - 96080 != -50441)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (176795 - 75035 == 101761)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (229797 - 449106 != -219309)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (130819 - 50302 != 80517)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (172549 - 571774 == -399224)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (74531 - 157766 != -83234)
					{
						this.aU9cVa1HuBQ.OpCustom(42, hashtable, true);
						if (163952 - 281861 != -117908)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008B5D RID: 35677 RVA: 0x0110F528 File Offset: 0x0110D728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008B5E RID: 35678 RVA: 0x0110F538 File Offset: 0x0110D738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008B5F RID: 35679 RVA: 0x0110F53C File Offset: 0x0110D73C
	internal static bool hJyCoCVckg1g0MlHP5Sm()
	{
		return true;
	}

	// Token: 0x06008B60 RID: 35680 RVA: 0x0110F540 File Offset: 0x0110D740
	internal static bool DbVtWqVcGfG8lqTgikRE()
	{
		return false;
	}

	// Token: 0x0400853B RID: 34107
	private LitePeer aU9cVa1HuBQ;

	// Token: 0x0400853C RID: 34108
	private PlayerCameraControl VLbcV4wwbwT;

	// Token: 0x0400853D RID: 34109
	private float sTVcVsxGYJk;

	// Token: 0x0400853E RID: 34110
	private int AhtcVHs58FC;

	// Token: 0x0400853F RID: 34111
	private int[] Cw0cV7Cqqko;

	// Token: 0x04008540 RID: 34112
	private int VNycVZ2RVZc;

	// Token: 0x04008541 RID: 34113
	private int E4pcVCLPSoD;

	// Token: 0x04008542 RID: 34114
	private float fqRcVM1Mptj;

	// Token: 0x04008543 RID: 34115
	private float mkAcVfJvwdq;

	// Token: 0x04008544 RID: 34116
	private Texture VdAcVLqH7AY;

	// Token: 0x04008545 RID: 34117
	private Texture R9mcVw0SWsE;

	// Token: 0x04008546 RID: 34118
	private Texture kq7cVURpk0I;

	// Token: 0x04008547 RID: 34119
	private Texture LxGcVNgRGaT;

	// Token: 0x04008548 RID: 34120
	private Texture NLocVExht9S;

	// Token: 0x04008549 RID: 34121
	private Texture Gb5cVPKJdT6;

	// Token: 0x0400854A RID: 34122
	private AudioClip iIEcVSuWndy;

	// Token: 0x0400854B RID: 34123
	private AudioClip AKycVBadMVF;

	// Token: 0x0400854C RID: 34124
	private int K8ycV0tyhyD;

	// Token: 0x02001767 RID: 5991
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartNextRound$40570 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008B61 RID: 35681 RVA: 0x0110F544 File Offset: 0x0110D744
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartNextRound$40570(int nRound, M708_SmackRun self_)
		{
			if (113557 - 87079 != 26479)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193675 - 570464 != -376788)
				{
					base..ctor();
					if (208637 - 149604 == 59033)
					{
						this.$nRound$40593 = nRound;
						if (18698 - 564873 == -546175)
						{
							this.$self_$40594 = self_;
							if (271 - 395218 != -394946)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008B62 RID: 35682 RVA: 0x0110F600 File Offset: 0x0110D800
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M708_SmackRun.$StartNextRound$40570.$(this.$nRound$40593, this.$self_$40594);
		}

		// Token: 0x06008B63 RID: 35683 RVA: 0x0110F614 File Offset: 0x0110D814
		internal static bool voJKohVcH1ODlNOtdCSV()
		{
			return true;
		}

		// Token: 0x06008B64 RID: 35684 RVA: 0x0110F618 File Offset: 0x0110D818
		internal static bool YKwpObVcWRtCRDnJ5Brx()
		{
			return false;
		}

		// Token: 0x0400854D RID: 34125
		internal int $nRound$40593;

		// Token: 0x0400854E RID: 34126
		internal M708_SmackRun $self_$40594;

		// Token: 0x02001768 RID: 5992
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008B65 RID: 35685 RVA: 0x0110F61C File Offset: 0x0110D81C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nRound, M708_SmackRun self_)
			{
				if (188288 - 363370 != -175081)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (1835 - 450431 != -448595)
					{
						base..ctor();
						if (240321 - 176067 != 64255)
						{
							this.$nRound$40591 = nRound;
							if (190425 - 583297 == -392872)
							{
								this.$self_$40592 = self_;
								if (29822 - 157329 != -127506)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008B66 RID: 35686 RVA: 0x0110F6D8 File Offset: 0x0110D8D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (242947 - 290356 != -47409)
				{
				}
				for (;;)
				{
					IL_958:
					switch (this._state)
					{
					case 0:
						goto IL_ECA;
					case 1:
						goto IL_FC7;
					case 2:
						this.$mCameraControl$40572 = (PlayerCameraControl)this.$self_$40592.GetComponent(typeof(PlayerCameraControl));
						if (178043 - 365065 != -187022)
						{
							continue;
						}
						this.$mSmackBoardCam$40573 = GameObject.Find("SmackBoardCam");
						if (265004 - 9618 == 255387)
						{
							continue;
						}
						if (this.$mCameraControl$40572)
						{
							if (92222 - 424525 != -332303)
							{
								continue;
							}
							this.$mCameraControl$40572.setSpecialTarget(this.$mSmackBoardCam$40573, (float)0);
							if (184052 - 150651 == 33402)
							{
								continue;
							}
						}
						this.$self_$40592.SendMessage("fadeIn");
						if (260641 - 123205 != 137436)
						{
							continue;
						}
						goto IL_14E;
					case 3:
						this.$self_$40592.SendMessage("fadeOut");
						if (73277 - 416868 != -343590)
						{
							goto Block_11;
						}
						continue;
					case 4:
						if (this.$mCameraControl$40572)
						{
							if (82477 - 168583 == -86105)
							{
								continue;
							}
							this.$mCameraControl$40572.specialTarget = null;
							if (54173 - 238193 == -184019)
							{
								continue;
							}
						}
						this.$slot$40574 = Game.getPlayerSlot(PlayerData.UID);
						if (87292 - 429905 == -342612)
						{
							continue;
						}
						this.$startPoint$40575 = null;
						if (113298 - 451964 != -338666)
						{
							continue;
						}
						this.$startCamera$40576 = null;
						if (269143 - 565494 == -296350)
						{
							continue;
						}
						if (this.$slot$40574 % 2 != this.$nRound$40591 % 2)
						{
							if (30002 - 384595 != -354593)
							{
								continue;
							}
							this.$startPoint$40575 = GameObject.Find("StartPoint" + global::Math.div((float)(this.$slot$40574 + 1), (float)2));
							if (119670 - 410548 == -290877)
							{
								continue;
							}
							this.$startCamera$40576 = GameObject.Find("StartCamera" + global::Math.div((float)(this.$slot$40574 + 1), (float)2));
							if (25802 - 308883 != -283081)
							{
								continue;
							}
						}
						else
						{
							this.$startPoint$40575 = GameObject.Find("StartPoint" + (global::Math.div((float)(this.$slot$40574 + this.$nRound$40591), (float)2) % 5 + 6));
							if (259371 - 562336 == -302964)
							{
								continue;
							}
							this.$startCamera$40576 = GameObject.Find("StartCamera" + (global::Math.div((float)(this.$slot$40574 + this.$nRound$40591), (float)2) % 5 + 6));
							if (209230 - 477998 == -268767)
							{
								continue;
							}
						}
						if (this.$startPoint$40575)
						{
							if (260580 - 123457 == 137124)
							{
								continue;
							}
							Game.mPlayer.transform.position = this.$startPoint$40575.transform.position;
							if (518 - 133709 == -133190)
							{
								continue;
							}
							Game.mPlayer.transform.rotation = this.$startPoint$40575.transform.rotation;
							if (259126 - 199580 == 59547)
							{
								continue;
							}
							this.$mPlayerChar$40577 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (241618 - 548824 == -307205)
							{
								continue;
							}
							if (this.$mPlayerChar$40577)
							{
								if (168242 - 120746 != 47496)
								{
									continue;
								}
								this.$mPlayerChar$40577.PositionEvent();
								if (135941 - 267307 != -131366)
								{
									continue;
								}
							}
						}
						if (this.$startCamera$40576)
						{
							if (187902 - 494506 == -306603)
							{
								continue;
							}
							this.$self_$40592.transform.position = this.$startCamera$40576.transform.position;
							if (168426 - 337879 != -169453)
							{
								continue;
							}
							this.$self_$40592.transform.rotation = this.$startCamera$40576.transform.rotation;
							if (138433 - 121261 != 17172)
							{
								continue;
							}
						}
						this.$deleteList$40578 = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Enemy"), GameObject.FindGameObjectsWithTag("Item"));
						if (72751 - 156631 != -83880)
						{
							continue;
						}
						this.$$12656$40585 = 0;
						if (95600 - 469167 != -373567)
						{
							continue;
						}
						this.$$12657$40586 = this.$deleteList$40578;
						if (98958 - 392038 == -293079)
						{
							continue;
						}
						this.$$12658$40587 = this.$$12657$40586.Length;
						if (110561 - 312446 == -201884)
						{
							continue;
						}
						while (this.$$12656$40585 < this.$$12658$40587)
						{
							UnityEngine.Object.Destroy(this.$$12657$40586[this.$$12656$40585]);
							if (266458 - 295326 == -28867)
							{
								goto IL_958;
							}
							this.$$12656$40585++;
							if (218842 - 217109 != 1733)
							{
								goto IL_958;
							}
						}
						if (130481 - 80880 != 49602)
						{
							goto Block_16;
						}
						continue;
					case 5:
						this.$self_$40592.SendMessage("fadeIn");
						if (32586 - 424258 == -391671)
						{
							continue;
						}
						break;
					case 6:
						this.$self_$40592.audio.PlayOneShot(this.$self_$40592.iIEcVSuWndy);
						if (185052 - 362668 != -177616)
						{
							continue;
						}
						goto IL_E7F;
					case 7:
						this.$self_$40592.audio.PlayOneShot(this.$self_$40592.iIEcVSuWndy);
						if (141297 - 408900 != -267603)
						{
							continue;
						}
						goto IL_18E;
					case 8:
						this.$self_$40592.audio.PlayOneShot(this.$self_$40592.AKycVBadMVF);
						if (250120 - 139150 != 110970)
						{
							continue;
						}
						Debug.Log("Starting Round : " + this.$nRound$40591);
						if (165651 - 84706 == 80946)
						{
							continue;
						}
						this.$self_$40592.AhtcVHs58FC = this.$nRound$40591;
						if (282039 - 388685 != -106646)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (105824 - 486073 != -380249)
						{
							continue;
						}
						Game.mGameTime = Time.time + (float)30;
						if (133936 - 163625 != -29689)
						{
							continue;
						}
						this.YieldDefault(1);
						if (77149 - 234855 != -157706)
						{
							continue;
						}
						goto IL_FC7;
					default:
						if (284283 - 439566 != -155283)
						{
							continue;
						}
						goto IL_ECA;
					}
					IL_5A9:
					this.$self_$40592.VNycVZ2RVZc = 0;
					if (93655 - 77001 != 16654)
					{
						continue;
					}
					this.$self_$40592.E4pcVCLPSoD = 0;
					if (204978 - 439943 != -234965)
					{
						continue;
					}
					this.$playerList$40580 = GameObject.FindGameObjectsWithTag("Player");
					if (47612 - 499382 == -451769)
					{
						continue;
					}
					this.$runCollision$40581 = GameObject.Find("runCollision");
					if (87151 - 250563 != -163412)
					{
						continue;
					}
					this.$zoneCollision$40582 = GameObject.Find("zoneCollision");
					if (235214 - 264595 == -29380)
					{
						continue;
					}
					if (Extensions.get_length(this.$playerList$40580) > 0)
					{
						if (171389 - 527184 == -355794)
						{
							continue;
						}
						if (this.$runCollision$40581)
						{
							if (125587 - 592927 != -467340)
							{
								continue;
							}
							if (this.$zoneCollision$40582)
							{
								if (33123 - 75155 == -42031)
								{
									continue;
								}
								this.$$12660$40588 = 0;
								if (273257 - 548504 == -275246)
								{
									continue;
								}
								this.$$12661$40589 = this.$playerList$40580;
								if (254768 - 222829 == 31940)
								{
									continue;
								}
								this.$$12662$40590 = this.$$12661$40589.Length;
								if (14255 - 556914 != -542659)
								{
									continue;
								}
								while (this.$$12660$40588 < this.$$12662$40590)
								{
									this.$playerChar$40584 = (CharacterControl)this.$$12661$40589[this.$$12660$40588].GetComponent(typeof(CharacterControl));
									if (300 - 219229 == -218928)
									{
										goto IL_958;
									}
									if (this.$playerChar$40584)
									{
										if (66460 - 125249 == -58788)
										{
											goto IL_958;
										}
										if (this.$playerChar$40584.actionState == "dead")
										{
											if (147811 - 572942 == -425130)
											{
												goto IL_958;
											}
											this.$playerChar$40584.reset();
											if (193166 - 500297 == -307130)
											{
												goto IL_958;
											}
										}
										else
										{
											this.$playerChar$40584.removeAllStatus();
											if (71427 - 127690 != -56263)
											{
												goto IL_958;
											}
										}
										if (this.$playerChar$40584.mOriginalLayer == 8)
										{
											if (259997 - 294204 == -34206)
											{
												goto IL_958;
											}
											this.$self_$40592.VNycVZ2RVZc = this.$self_$40592.VNycVZ2RVZc + 1;
											if (103832 - 262300 != -158468)
											{
												goto IL_958;
											}
										}
										else
										{
											this.$self_$40592.E4pcVCLPSoD = this.$self_$40592.E4pcVCLPSoD + 1;
											if (295390 - 264897 == 30494)
											{
												goto IL_958;
											}
										}
										if ((this.$playerChar$40584.mOriginalLayer + this.$nRound$40591) % 2 == 1)
										{
											if (217662 - 479601 == -261938)
											{
												goto IL_958;
											}
											Physics.IgnoreCollision(this.$$12661$40589[this.$$12660$40588].collider, this.$runCollision$40581.collider, true);
											if (198994 - 585914 != -386920)
											{
												goto IL_958;
											}
											Physics.IgnoreCollision(this.$$12661$40589[this.$$12660$40588].collider, this.$zoneCollision$40582.collider, false);
											if (36671 - 451609 == -414937)
											{
												goto IL_958;
											}
										}
										else
										{
											Physics.IgnoreCollision(this.$$12661$40589[this.$$12660$40588].collider, this.$runCollision$40581.collider, false);
											if (234800 - 304247 != -69447)
											{
												goto IL_958;
											}
											Physics.IgnoreCollision(this.$$12661$40589[this.$$12660$40588].collider, this.$zoneCollision$40582.collider, true);
											if (77786 - 253620 == -175833)
											{
												goto IL_958;
											}
										}
									}
									this.$$12660$40588++;
									if (92493 - 21388 != 71105)
									{
										goto IL_958;
									}
								}
								if (118877 - 150021 != -31144)
								{
									continue;
								}
							}
						}
					}
					this.$mGameGui$40571.enabled = true;
					if (251175 - 138445 == 112731)
					{
						continue;
					}
					this.$self_$40592.fqRcVM1Mptj = Time.time + (float)4;
					if (142637 - 72186 == 70452)
					{
						continue;
					}
					this.$self_$40592.audio.volume = 0.1f * (float)Game.music;
					if (117627 - 377248 != -259621)
					{
						continue;
					}
					this.$self_$40592.audio.PlayOneShot(this.$self_$40592.iIEcVSuWndy);
					if (258817 - 432114 != -173297)
					{
						continue;
					}
					goto IL_8D0;
					IL_ECA:
					Debug.Log("StartNextRound:" + this.$nRound$40591);
					if (235975 - 337171 == -101196)
					{
						this.$mGameGui$40571 = (GameGui)this.$self_$40592.GetComponent(typeof(GameGui));
						if (251296 - 570651 != -319354)
						{
							if (this.$nRound$40591 == 0)
							{
								if (128009 - 147784 == -19775)
								{
									Game.mGameTime = (float)0;
									if (5094 - 322787 != -317692)
									{
										goto IL_5A9;
									}
								}
							}
							else
							{
								Game.mGameState = eGameState.AllHold;
								if (51497 - 546166 == -494669)
								{
									Game.mGameTime = (float)0;
									if (174576 - 116206 == 58370)
									{
										this.$self_$40592.mkAcVfJvwdq = (float)0;
										if (33151 - 184053 == -150902)
										{
											this.$self_$40592.fqRcVM1Mptj = (float)0;
											if (199235 - 540391 == -341156)
											{
												this.$mGameGui$40571.close();
												if (82553 - 565238 == -482685)
												{
													this.$self_$40592.SendMessage("fadeOut");
													if (261742 - 20966 == 240776)
													{
														goto IL_84E;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_14E:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_11:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_18E:
				return this.Yield(8, new WaitForSeconds(1f));
				Block_16:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_84E:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_8D0:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_E7F:
				return this.Yield(7, new WaitForSeconds(1f));
				IL_FC7:
				return false;
			}

			// Token: 0x06008B67 RID: 35687 RVA: 0x011106C0 File Offset: 0x0110E8C0
			internal static bool Kie3LiVcAH4s2rsOwCPT()
			{
				return true;
			}

			// Token: 0x06008B68 RID: 35688 RVA: 0x011106C4 File Offset: 0x0110E8C4
			internal static bool Sf4AFOVclC3PNLK5dGGV()
			{
				return false;
			}

			// Token: 0x0400854F RID: 34127
			internal GameGui $mGameGui$40571;

			// Token: 0x04008550 RID: 34128
			internal PlayerCameraControl $mCameraControl$40572;

			// Token: 0x04008551 RID: 34129
			internal GameObject $mSmackBoardCam$40573;

			// Token: 0x04008552 RID: 34130
			internal int $slot$40574;

			// Token: 0x04008553 RID: 34131
			internal GameObject $startPoint$40575;

			// Token: 0x04008554 RID: 34132
			internal GameObject $startCamera$40576;

			// Token: 0x04008555 RID: 34133
			internal CharacterControl $mPlayerChar$40577;

			// Token: 0x04008556 RID: 34134
			internal GameObject[] $deleteList$40578;

			// Token: 0x04008557 RID: 34135
			internal GameObject $deleteObject$40579;

			// Token: 0x04008558 RID: 34136
			internal GameObject[] $playerList$40580;

			// Token: 0x04008559 RID: 34137
			internal GameObject $runCollision$40581;

			// Token: 0x0400855A RID: 34138
			internal GameObject $zoneCollision$40582;

			// Token: 0x0400855B RID: 34139
			internal GameObject $playerObject$40583;

			// Token: 0x0400855C RID: 34140
			internal CharacterControl $playerChar$40584;

			// Token: 0x0400855D RID: 34141
			internal int $$12656$40585;

			// Token: 0x0400855E RID: 34142
			internal GameObject[] $$12657$40586;

			// Token: 0x0400855F RID: 34143
			internal int $$12658$40587;

			// Token: 0x04008560 RID: 34144
			internal int $$12660$40588;

			// Token: 0x04008561 RID: 34145
			internal GameObject[] $$12661$40589;

			// Token: 0x04008562 RID: 34146
			internal int $$12662$40590;

			// Token: 0x04008563 RID: 34147
			internal int $nRound$40591;

			// Token: 0x04008564 RID: 34148
			internal M708_SmackRun $self_$40592;
		}
	}

	// Token: 0x02001769 RID: 5993
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$40595 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008B69 RID: 35689 RVA: 0x011106C8 File Offset: 0x0110E8C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$40595(M708_SmackRun self_)
		{
			if (9086 - 60451 != -51364)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (157906 - 317009 != -159102)
				{
					base..ctor();
					if (125804 - 49241 == 76563)
					{
						this.$self_$40598 = self_;
						if (94594 - 547197 == -452603)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008B6A RID: 35690 RVA: 0x01110760 File Offset: 0x0110E960
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M708_SmackRun.$StartGame$40595.$(this.$self_$40598);
		}

		// Token: 0x06008B6B RID: 35691 RVA: 0x01110770 File Offset: 0x0110E970
		internal static bool iVTHKRVcy8MWqdmqen52()
		{
			return true;
		}

		// Token: 0x06008B6C RID: 35692 RVA: 0x01110774 File Offset: 0x0110E974
		internal static bool VOIfiwVcSNBdwtq2819m()
		{
			return false;
		}

		// Token: 0x04008565 RID: 34149
		internal M708_SmackRun $self_$40598;

		// Token: 0x0200176A RID: 5994
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008B6D RID: 35693 RVA: 0x01110778 File Offset: 0x0110E978
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M708_SmackRun self_)
			{
				if (242999 - 131656 != 111344)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (136808 - 235261 == -98453)
					{
						base..ctor();
						if (112630 - 540182 != -427551)
						{
							this.$self_$40597 = self_;
							if (8693 - 310594 == -301901)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008B6E RID: 35694 RVA: 0x01110810 File Offset: 0x0110EA10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (117665 - 101713 != 15952)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_179;
					case 2:
						this.$self_$40597.StartCoroutine_Auto(this.$self_$40597.StartNextRound(0));
						if (206720 - 549174 != -342454)
						{
							continue;
						}
						this.YieldDefault(1);
						if (38370 - 393483 != -355113)
						{
							continue;
						}
						goto IL_179;
					default:
						if (135136 - 199947 == -64810)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (16989 - 589322 != -572332)
					{
						Game.mGameState = eGameState.Hold;
						if (64359 - 456717 == -392358)
						{
							Game.mGameTime = (float)0;
							if (161301 - 533064 == -371763)
							{
								this.$mLoadingGui$40596 = (LoadingGui)this.$self_$40597.GetComponent(typeof(LoadingGui));
								if (266559 - 181197 == 85362)
								{
									this.$mLoadingGui$40596.fadeIn();
									if (294233 - 411264 != -117030)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				IL_179:
				return false;
			}

			// Token: 0x06008B6F RID: 35695 RVA: 0x011109A8 File Offset: 0x0110EBA8
			internal static bool iExYSuVcoVwsSAM3Arjr()
			{
				return true;
			}

			// Token: 0x06008B70 RID: 35696 RVA: 0x011109AC File Offset: 0x0110EBAC
			internal static bool Xnd5r8VcEnWqBGaA1082()
			{
				return false;
			}

			// Token: 0x04008566 RID: 34150
			internal LoadingGui $mLoadingGui$40596;

			// Token: 0x04008567 RID: 34151
			internal M708_SmackRun $self_$40597;
		}
	}

	// Token: 0x0200176B RID: 5995
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40599 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008B71 RID: 35697 RVA: 0x011109B0 File Offset: 0x0110EBB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40599(M708_SmackRun self_)
		{
			if (96299 - 177429 != -81130)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (11720 - 149745 == -138025)
				{
					base..ctor();
					if (119178 - 256547 == -137369)
					{
						this.$self_$40604 = self_;
						if (214021 - 163516 != 50506)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008B72 RID: 35698 RVA: 0x01110A48 File Offset: 0x0110EC48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M708_SmackRun.$onDeadPlayer$40599.$(this.$self_$40604);
		}

		// Token: 0x06008B73 RID: 35699 RVA: 0x01110A58 File Offset: 0x0110EC58
		internal static bool t3FdsqVc286sRsQXcKEH()
		{
			return true;
		}

		// Token: 0x06008B74 RID: 35700 RVA: 0x01110A5C File Offset: 0x0110EC5C
		internal static bool MDF1GMVc88XaAc4xw8qK()
		{
			return false;
		}

		// Token: 0x04008568 RID: 34152
		internal M708_SmackRun $self_$40604;

		// Token: 0x0200176C RID: 5996
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008B75 RID: 35701 RVA: 0x01110A60 File Offset: 0x0110EC60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M708_SmackRun self_)
			{
				if (267738 - 182035 != 85703)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (65198 - 40474 != 24725)
					{
						base..ctor();
						if (269368 - 461804 != -192435)
						{
							this.$self_$40603 = self_;
							if (190543 - 382871 == -192328)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008B76 RID: 35702 RVA: 0x01110AF8 File Offset: 0x0110ECF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229782 - 341618 != -111835)
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
							if (281044 - 542359 == -261314)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_29D;
							}
							if (113271 - 54086 != 59185)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (252628 - 576350 != -323722)
						{
							continue;
						}
						this.$mStoryGui$40600 = (StoryGui)this.$self_$40603.GetComponent(typeof(StoryGui));
						if (178900 - 494914 == -316013)
						{
							continue;
						}
						if (this.$mStoryGui$40600)
						{
							if (192299 - 263436 == -71136)
							{
								continue;
							}
							this.$mStoryGui$40600.close();
							if (270438 - 300240 != -29802)
							{
								continue;
							}
						}
						this.$mChangeGui$40601 = (ChangeGui)this.$self_$40603.GetComponent(typeof(ChangeGui));
						if (85764 - 368216 != -282452)
						{
							continue;
						}
						if (this.$mChangeGui$40601)
						{
							if (135851 - 168070 != -32219)
							{
								continue;
							}
							this.$mChangeGui$40601.close();
							if (195860 - 443086 == -247225)
							{
								continue;
							}
						}
						this.$mGameGui$40602 = (GameGui)this.$self_$40603.GetComponent(typeof(GameGui));
						if (141769 - 480616 == -338846)
						{
							continue;
						}
						if (this.$mGameGui$40602)
						{
							if (275189 - 218252 == 56938)
							{
								continue;
							}
							if (!this.$mGameGui$40602.enabled)
							{
								if (19938 - 212150 == -192211)
								{
									continue;
								}
								this.$mGameGui$40602.enabled = true;
								if (162485 - 318431 != -155946)
								{
									continue;
								}
							}
							this.$mGameGui$40602.openDeadMenu();
							if (93970 - 541996 != -448026)
							{
								continue;
							}
						}
						IL_29D:
						this.YieldDefault(1);
						if (256689 - 24524 != 232165)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (33342 - 296998 == -263655)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (10986 - 324853 != -313867);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008B77 RID: 35703 RVA: 0x01110E10 File Offset: 0x0110F010
			internal static bool fBunMEVcZqQMbcgbA3iq()
			{
				return true;
			}

			// Token: 0x06008B78 RID: 35704 RVA: 0x01110E14 File Offset: 0x0110F014
			internal static bool KkIpDCVcCIpy7cXfSpXu()
			{
				return false;
			}

			// Token: 0x04008569 RID: 34153
			internal StoryGui $mStoryGui$40600;

			// Token: 0x0400856A RID: 34154
			internal ChangeGui $mChangeGui$40601;

			// Token: 0x0400856B RID: 34155
			internal GameGui $mGameGui$40602;

			// Token: 0x0400856C RID: 34156
			internal M708_SmackRun $self_$40603;
		}
	}

	// Token: 0x0200176D RID: 5997
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40605 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008B79 RID: 35705 RVA: 0x01110E18 File Offset: 0x0110F018
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40605(Hashtable data, M708_SmackRun self_)
		{
			if (238390 - 349486 != -111095)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (87246 - 545696 == -458450)
				{
					base..ctor();
					if (143508 - 394435 == -250927)
					{
						this.$data$40614 = data;
						if (115757 - 428563 == -312806)
						{
							this.$self_$40615 = self_;
							if (224165 - 528842 != -304676)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008B7A RID: 35706 RVA: 0x01110ED4 File Offset: 0x0110F0D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M708_SmackRun.$onGameComplete$40605.$(this.$data$40614, this.$self_$40615);
		}

		// Token: 0x06008B7B RID: 35707 RVA: 0x01110EE8 File Offset: 0x0110F0E8
		internal static bool lbbL09VcLvonyNBlL3FC()
		{
			return true;
		}

		// Token: 0x06008B7C RID: 35708 RVA: 0x01110EEC File Offset: 0x0110F0EC
		internal static bool ylakM3VcOZ8Ok9osIdgE()
		{
			return false;
		}

		// Token: 0x0400856D RID: 34157
		internal Hashtable $data$40614;

		// Token: 0x0400856E RID: 34158
		internal M708_SmackRun $self_$40615;

		// Token: 0x0200176E RID: 5998
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008B7D RID: 35709 RVA: 0x01110EF0 File Offset: 0x0110F0F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M708_SmackRun self_)
			{
				if (141867 - 397647 != -255779)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (4825 - 16153 == -11328)
					{
						base..ctor();
						if (184778 - 244848 == -60070)
						{
							this.$data$40612 = data;
							if (239612 - 141144 != 98469)
							{
								this.$self_$40613 = self_;
								if (119677 - 251340 == -131663)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008B7E RID: 35710 RVA: 0x01110FAC File Offset: 0x0110F1AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (54268 - 382963 != -328694)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_47B;
					case 2:
						this.$mCameraControl$40608 = (PlayerCameraControl)this.$self_$40613.GetComponent(typeof(PlayerCameraControl));
						if (296986 - 540349 == -243362)
						{
							continue;
						}
						this.$mSmackBoardCam$40609 = GameObject.Find("SmackBoardCam");
						if (286911 - 239747 != 47164)
						{
							continue;
						}
						if (this.$mCameraControl$40608)
						{
							if (183209 - 486125 != -302916)
							{
								continue;
							}
							this.$mCameraControl$40608.setSpecialTarget(this.$mSmackBoardCam$40609, (float)0);
							if (287193 - 520364 != -233171)
							{
								continue;
							}
						}
						this.$self_$40613.SendMessage("fadeIn");
						if (36331 - 283742 != -247410)
						{
							goto Block_26;
						}
						continue;
					case 3:
						this.$result$40610 = RuntimeServices.UnboxInt32(this.$data$40612[31]);
						if (185928 - 312767 != -126839)
						{
							continue;
						}
						this.$mCompleteGui$40611 = (CompleteGui)this.$self_$40613.GetComponent(typeof(CompleteGui));
						if (121372 - 442849 == -321476)
						{
							continue;
						}
						this.$mCompleteGui$40611.Init();
						if (41305 - 497091 != -455786)
						{
							continue;
						}
						this.$mCompleteGui$40611.readData(this.$data$40612);
						if (159176 - 217688 != -58512)
						{
							continue;
						}
						if (this.$result$40610 == 1)
						{
							if (198188 - 325073 == -126884)
							{
								continue;
							}
							this.$mCompleteGui$40611.displayResult(eCompleteType.Success);
							if (147354 - 80998 != 66356)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40611.displayResult(eCompleteType.Failed);
							if (123457 - 537549 == -414091)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (67019 - 368369 != -301350)
						{
							continue;
						}
						goto IL_47B;
					default:
						if (250098 - 308678 != -58580)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40612[31]);
					if (134242 - 566078 != -431835)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (63883 - 101911 == -38028)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (22106 - 132229 == -110123)
							{
								this.$mGameGui$40606 = (GameGui)this.$self_$40613.GetComponent(typeof(GameGui));
								if (26891 - 553703 == -526812)
								{
									this.$mStoryGui$40607 = (StoryGui)this.$self_$40613.GetComponent(typeof(StoryGui));
									if (91960 - 481650 == -389690)
									{
										if (this.$mGameGui$40606)
										{
											if (203345 - 101840 != 101505)
											{
												continue;
											}
											this.$mGameGui$40606.close();
											if (115622 - 530683 != -415061)
											{
												continue;
											}
										}
										if (this.$mStoryGui$40607)
										{
											if (272971 - 512440 == -239468)
											{
												continue;
											}
											this.$mStoryGui$40607.close();
											if (125977 - 597915 == -471937)
											{
												continue;
											}
										}
										this.$self_$40613.SendMessage("fadeOut");
										if (76223 - 100625 != -24401)
										{
											goto Block_29;
										}
									}
								}
							}
						}
					}
				}
				goto IL_47B;
				Block_26:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_29:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_47B:
				return false;
			}

			// Token: 0x06008B7F RID: 35711 RVA: 0x01111448 File Offset: 0x0110F648
			internal static bool UpCBt5Vcm0bZUQAcNOpb()
			{
				return true;
			}

			// Token: 0x06008B80 RID: 35712 RVA: 0x0111144C File Offset: 0x0110F64C
			internal static bool k7kjONVcFBB1daBiGgOL()
			{
				return false;
			}

			// Token: 0x0400856F RID: 34159
			internal GameGui $mGameGui$40606;

			// Token: 0x04008570 RID: 34160
			internal StoryGui $mStoryGui$40607;

			// Token: 0x04008571 RID: 34161
			internal PlayerCameraControl $mCameraControl$40608;

			// Token: 0x04008572 RID: 34162
			internal GameObject $mSmackBoardCam$40609;

			// Token: 0x04008573 RID: 34163
			internal int $result$40610;

			// Token: 0x04008574 RID: 34164
			internal CompleteGui $mCompleteGui$40611;

			// Token: 0x04008575 RID: 34165
			internal Hashtable $data$40612;

			// Token: 0x04008576 RID: 34166
			internal M708_SmackRun $self_$40613;
		}
	}

	// Token: 0x0200176F RID: 5999
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40616 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008B81 RID: 35713 RVA: 0x01111450 File Offset: 0x0110F650
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40616(M708_SmackRun self_)
		{
			if (68948 - 134600 != -65651)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (90574 - 509999 == -419425)
				{
					base..ctor();
					if (22494 - 36450 == -13956)
					{
						this.$self_$40620 = self_;
						if (195180 - 84981 != 110200)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008B82 RID: 35714 RVA: 0x011114E8 File Offset: 0x0110F6E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M708_SmackRun.$ReturnToTown$40616.$(this.$self_$40620);
		}

		// Token: 0x06008B83 RID: 35715 RVA: 0x011114F8 File Offset: 0x0110F6F8
		internal static bool sjLVlaVcMabsR3BJ0GRo()
		{
			return true;
		}

		// Token: 0x06008B84 RID: 35716 RVA: 0x011114FC File Offset: 0x0110F6FC
		internal static bool AlrsVRVcx9YsXJJxki31()
		{
			return false;
		}

		// Token: 0x04008577 RID: 34167
		internal M708_SmackRun $self_$40620;

		// Token: 0x02001770 RID: 6000
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008B85 RID: 35717 RVA: 0x01111500 File Offset: 0x0110F700
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M708_SmackRun self_)
			{
				if (256196 - 114011 != 142185)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (64760 - 62739 != 2022)
					{
						base..ctor();
						if (22252 - 142040 != -119787)
						{
							this.$self_$40619 = self_;
							if (60239 - 470130 != -409890)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008B86 RID: 35718 RVA: 0x01111598 File Offset: 0x0110F798
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (118082 - 179767 != -61684)
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
						this.$self_$40619.LeaveGame();
						if (268194 - 546990 == -278795)
						{
							continue;
						}
						this.YieldDefault(1);
						if (195070 - 369453 != -174382)
						{
							goto Block_25;
						}
						continue;
					default:
						if (153074 - 586250 == -433175)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (194834 - 509153 != -314318)
					{
						Game.mStateTime = Time.time;
						if (68325 - 335470 != -267144)
						{
							this.$$switch$7218$40617 = PlayerData.SaveGuild;
							if (196901 - 594598 == -397697)
							{
								if (this.$$switch$7218$40617 == 1)
								{
									if (292383 - 297803 == -5419)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (195849 - 224715 == -28865)
									{
										continue;
									}
								}
								else if (this.$$switch$7218$40617 == 2)
								{
									if (266918 - 159394 != 107524)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (253362 - 40683 == 212680)
									{
										continue;
									}
								}
								else if (this.$$switch$7218$40617 == 3)
								{
									if (93441 - 21364 == 72078)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (256827 - 264416 != -7589)
									{
										continue;
									}
								}
								else if (this.$$switch$7218$40617 == 4)
								{
									if (65509 - 395139 != -329630)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (180253 - 357956 == -177702)
									{
										continue;
									}
								}
								else if (this.$$switch$7218$40617 == 5)
								{
									if (1273 - 72280 != -71007)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (29793 - 402632 == -372838)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (86943 - 127190 == -40246)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (171633 - 187607 != -15974)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (214049 - 327629 == -113579)
									{
										continue;
									}
								}
								this.$mGameGui$40618 = (GameGui)this.$self_$40619.GetComponent(typeof(GameGui));
								if (24962 - 366492 == -341530)
								{
									if (this.$mGameGui$40618)
									{
										if (26004 - 250254 == -224249)
										{
											continue;
										}
										this.$mGameGui$40618.close();
										if (144971 - 553048 == -408076)
										{
											continue;
										}
									}
									this.$self_$40619.SendMessage("fadeOut");
									if (162381 - 213855 == -51474)
									{
										goto IL_2D4;
									}
								}
							}
						}
					}
				}
				Block_25:
				goto IL_3AD;
				IL_2D4:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06008B87 RID: 35719 RVA: 0x01111964 File Offset: 0x0110FB64
			internal static bool cxM7tpVcgWiTSZ9sduMB()
			{
				return true;
			}

			// Token: 0x06008B88 RID: 35720 RVA: 0x01111968 File Offset: 0x0110FB68
			internal static bool X9UVsqVcfhDlp8IdxPdT()
			{
				return false;
			}

			// Token: 0x04008578 RID: 34168
			internal int $$switch$7218$40617;

			// Token: 0x04008579 RID: 34169
			internal GameGui $mGameGui$40618;

			// Token: 0x0400857A RID: 34170
			internal M708_SmackRun $self_$40619;
		}
	}

	// Token: 0x02001771 RID: 6001
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40621 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008B89 RID: 35721 RVA: 0x0111196C File Offset: 0x0110FB6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40621(M708_SmackRun self_)
		{
			if (175281 - 303660 != -128379)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (14480 - 34074 == -19594)
				{
					base..ctor();
					if (22960 - 462540 == -439580)
					{
						this.$self_$40624 = self_;
						if (120885 - 475464 == -354579)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008B8A RID: 35722 RVA: 0x01111A04 File Offset: 0x0110FC04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M708_SmackRun.$ReturnToGuild$40621.$(this.$self_$40624);
		}

		// Token: 0x06008B8B RID: 35723 RVA: 0x01111A14 File Offset: 0x0110FC14
		internal static bool SH6md4VcnsPxU5mM5FDi()
		{
			return true;
		}

		// Token: 0x06008B8C RID: 35724 RVA: 0x01111A18 File Offset: 0x0110FC18
		internal static bool Hdme7cVc6hEW9kgmMHPq()
		{
			return false;
		}

		// Token: 0x0400857B RID: 34171
		internal M708_SmackRun $self_$40624;

		// Token: 0x02001772 RID: 6002
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008B8D RID: 35725 RVA: 0x01111A1C File Offset: 0x0110FC1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M708_SmackRun self_)
			{
				if (229455 - 219211 != 10244)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (230669 - 258973 != -28303)
					{
						base..ctor();
						if (75170 - 112607 != -37436)
						{
							this.$self_$40623 = self_;
							if (124796 - 6966 == 117830)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008B8E RID: 35726 RVA: 0x01111AB4 File Offset: 0x0110FCB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (52180 - 539517 != -487336)
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
						this.$self_$40623.LeaveGame();
						if (7701 - 30708 == -23006)
						{
							continue;
						}
						this.YieldDefault(1);
						if (294073 - 260758 != 33316)
						{
							goto Block_3;
						}
						continue;
					default:
						if (207173 - 398762 != -191589)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (242502 - 120223 == 122279)
					{
						Game.mStateTime = Time.time;
						if (75643 - 574947 == -499304)
						{
							Game.mNextGameCode = 31;
							if (40217 - 16857 == 23360)
							{
								this.$mGameGui$40622 = (GameGui)this.$self_$40623.GetComponent(typeof(GameGui));
								if (24010 - 434803 == -410793)
								{
									if (this.$mGameGui$40622)
									{
										if (28721 - 536234 == -507512)
										{
											continue;
										}
										this.$mGameGui$40622.close();
										if (233387 - 478436 == -245048)
										{
											continue;
										}
									}
									this.$self_$40623.SendMessage("fadeOut");
									if (50409 - 405376 != -354966)
									{
										goto Block_9;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_1BD;
				Block_9:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06008B8F RID: 35727 RVA: 0x01111C90 File Offset: 0x0110FE90
			internal static bool fRRT5uVcin0C3EJvFnpT()
			{
				return true;
			}

			// Token: 0x06008B90 RID: 35728 RVA: 0x01111C94 File Offset: 0x0110FE94
			internal static bool DMDp5VVcKoJAEFmIe3L7()
			{
				return false;
			}

			// Token: 0x0400857C RID: 34172
			internal GameGui $mGameGui$40622;

			// Token: 0x0400857D RID: 34173
			internal M708_SmackRun $self_$40623;
		}
	}

	// Token: 0x02001773 RID: 6003
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40625 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008B91 RID: 35729 RVA: 0x01111C98 File Offset: 0x0110FE98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40625(M708_SmackRun self_)
		{
			if (184361 - 508143 != -323782)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (123425 - 242521 == -119096)
				{
					base..ctor();
					if (144193 - 314473 == -170280)
					{
						this.$self_$40629 = self_;
						if (201495 - 328344 != -126848)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008B92 RID: 35730 RVA: 0x01111D30 File Offset: 0x0110FF30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M708_SmackRun.$ReturnToCamp$40625.$(this.$self_$40629);
		}

		// Token: 0x06008B93 RID: 35731 RVA: 0x01111D40 File Offset: 0x0110FF40
		internal static bool SlAKiPVcdX4w4VxMhE1F()
		{
			return true;
		}

		// Token: 0x06008B94 RID: 35732 RVA: 0x01111D44 File Offset: 0x0110FF44
		internal static bool JVcySjVcJRWUh1ukcSGM()
		{
			return false;
		}

		// Token: 0x0400857E RID: 34174
		internal M708_SmackRun $self_$40629;

		// Token: 0x02001774 RID: 6004
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008B95 RID: 35733 RVA: 0x01111D48 File Offset: 0x0110FF48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M708_SmackRun self_)
			{
				if (134763 - 45858 != 88905)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (215637 - 129816 == 85821)
					{
						base..ctor();
						if (37758 - 330538 == -292780)
						{
							this.$self_$40628 = self_;
							if (44536 - 456684 == -412148)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008B96 RID: 35734 RVA: 0x01111DE0 File Offset: 0x0110FFE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (201736 - 311654 != -109917)
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
						this.$self_$40628.LeaveGame();
						if (55919 - 154169 == -98249)
						{
							continue;
						}
						this.YieldDefault(1);
						if (61945 - 384947 != -323002)
						{
							continue;
						}
						goto IL_363;
					default:
						if (115346 - 525371 == -410024)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (298895 - 568188 == -269293)
					{
						Game.mStateTime = Time.time;
						if (129413 - 536656 != -407242)
						{
							this.$$switch$7220$40626 = PlayerData.SaveGuild;
							if (184580 - 313461 != -128880)
							{
								if (this.$$switch$7220$40626 == 1)
								{
									if (39190 - 408092 != -368902)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (276633 - 168038 != 108595)
									{
										continue;
									}
								}
								else if (this.$$switch$7220$40626 == 2)
								{
									if (255008 - 170104 == 84905)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (18892 - 50760 != -31868)
									{
										continue;
									}
								}
								else if (this.$$switch$7220$40626 == 3)
								{
									if (195684 - 183807 != 11877)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (223624 - 467355 == -243730)
									{
										continue;
									}
								}
								else if (this.$$switch$7220$40626 == 4)
								{
									if (21929 - 114260 != -92331)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (47118 - 336200 != -289082)
									{
										continue;
									}
								}
								else if (this.$$switch$7220$40626 == 5)
								{
									if (187452 - 73993 != 113459)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (150922 - 417813 == -266890)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (179109 - 198081 == -18971)
									{
										continue;
									}
								}
								this.$mGameGui$40627 = (GameGui)this.$self_$40628.GetComponent(typeof(GameGui));
								if (171526 - 419444 == -247918)
								{
									if (this.$mGameGui$40627)
									{
										if (241273 - 403039 != -161766)
										{
											continue;
										}
										this.$mGameGui$40627.close();
										if (17660 - 498707 != -481047)
										{
											continue;
										}
									}
									this.$self_$40628.SendMessage("fadeOut");
									if (147227 - 593868 == -446641)
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

			// Token: 0x06008B97 RID: 35735 RVA: 0x01112164 File Offset: 0x01110364
			internal static bool Aip9LRVcDZyLZysjBo2p()
			{
				return true;
			}

			// Token: 0x06008B98 RID: 35736 RVA: 0x01112168 File Offset: 0x01110368
			internal static bool ejLaIjVcvddsNe8DJ4os()
			{
				return false;
			}

			// Token: 0x0400857F RID: 34175
			internal int $$switch$7220$40626;

			// Token: 0x04008580 RID: 34176
			internal GameGui $mGameGui$40627;

			// Token: 0x04008581 RID: 34177
			internal M708_SmackRun $self_$40628;
		}
	}
}
