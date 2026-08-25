using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000267 RID: 615
[Serializable]
public class DancerControl : MonoBehaviour
{
	// Token: 0x06000E0F RID: 3599 RVA: 0x00167110 File Offset: 0x00165310
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DancerControl()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000E10 RID: 3600 RVA: 0x00167120 File Offset: 0x00165320
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.SlbIhDOFoi = (CharacterController)this.GetComponent(typeof(CharacterController));
	}

	// Token: 0x06000E11 RID: 3601 RVA: 0x00167140 File Offset: 0x00165340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (this.SlbIhDOFoi)
		{
			this.Init();
		}
	}

	// Token: 0x06000E12 RID: 3602 RVA: 0x00167158 File Offset: 0x00165358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init()
	{
		if (59669 - 317597 != -257928)
		{
		}
		for (;;)
		{
			this.iQwIKCZlBN = new GUIStyle();
			if (76126 - 86475 != -10348)
			{
				this.iQwIKCZlBN.font = (Font)Resources.Load("GameGui/Fonts/GMO24");
				if (3416 - 570500 == -567084)
				{
					this.iQwIKCZlBN.normal.textColor = new Color(0.5f, 0.8f, (float)1, (float)1);
					if (80223 - 47766 == 32457)
					{
						this.iQwIKCZlBN.alignment = TextAnchor.MiddleCenter;
						if (3569 - 560371 == -556802)
						{
							this.jE6IzxnWNb = new GUIStyle();
							if (89101 - 39235 == 49866)
							{
								this.jE6IzxnWNb.font = this.iQwIKCZlBN.font;
								if (152689 - 325923 != -173233)
								{
									this.jE6IzxnWNb.normal.textColor = new Color((float)1, 0.64f, 0.45f, (float)1);
									if (287909 - 107200 != 180710)
									{
										this.jE6IzxnWNb.alignment = TextAnchor.MiddleCenter;
										if (210252 - 118635 == 91617)
										{
											this.WLUJ5OJoBO = new GUIStyle();
											if (28731 - 584553 == -555822)
											{
												this.WLUJ5OJoBO.font = this.iQwIKCZlBN.font;
												if (21980 - 110132 != -88151)
												{
													this.WLUJ5OJoBO.normal.textColor = new Color(0.9f, 0.9f, 0.9f, (float)1);
													if (145347 - 232888 == -87541)
													{
														this.WLUJ5OJoBO.alignment = TextAnchor.MiddleCenter;
														if (274117 - 397465 == -123348)
														{
															this.jBfJcSubTf = new GUIStyle();
															if (16552 - 395519 != -378966)
															{
																this.jBfJcSubTf.font = this.iQwIKCZlBN.font;
																if (282151 - 597306 == -315155)
																{
																	this.jBfJcSubTf.normal.textColor = new Color(0.8f, 0.3f, 0.3f, (float)1);
																	if (227771 - 51290 != 176482)
																	{
																		this.jBfJcSubTf.alignment = TextAnchor.MiddleCenter;
																		if (211297 - 367025 != -155727)
																		{
																			this.xyIJnglyWJ = new GUIStyle();
																			if (94119 - 340449 == -246330)
																			{
																				this.xyIJnglyWJ.font = this.iQwIKCZlBN.font;
																				if (228529 - 52289 == 176240)
																				{
																					this.xyIJnglyWJ.normal.textColor = new Color(0.62f, 0.31f, 0.91f, (float)1);
																					if (274330 - 115771 == 158559)
																					{
																						this.xyIJnglyWJ.alignment = TextAnchor.MiddleLeft;
																						if (33627 - 122245 != -88617)
																						{
																							this.mState = "standby";
																							if (88176 - 464789 != -376612)
																							{
																								this.mStateTimer = Time.time;
																								if (196008 - 74642 == 121366)
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

	// Token: 0x06000E13 RID: 3603 RVA: 0x00167580 File Offset: 0x00165780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void dance(int nStep)
	{
		if (28320 - 387384 != -359063)
		{
		}
		for (;;)
		{
			this.mDanceStep = nStep;
			if (239434 - 308136 != -68701)
			{
				if (!(this.mState == "standby"))
				{
					if (69793 - 292959 == -223165)
					{
						continue;
					}
					if (!(this.mState == "dance"))
					{
						break;
					}
					if (18377 - 153856 == -135478)
					{
						continue;
					}
				}
				this.mState = "dance";
				if (53412 - 203101 == -149689)
				{
					this.mStateTimer = Time.time;
					if (98201 - 522789 != -424587)
					{
						this.animation.CrossFade("step" + nStep);
						if (232183 - 579296 == -347113)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (62608 - 583249 != -520640)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x001676DC File Offset: 0x001658DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ko()
	{
		return new DancerControl.$ko$17659(this).GetEnumerator();
	}

	// Token: 0x06000E15 RID: 3605 RVA: 0x001676EC File Offset: 0x001658EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void dead()
	{
		if (58019 - 368895 != -310875)
		{
		}
		for (;;)
		{
			this.mState = "dead";
			if (218644 - 372490 != -153845)
			{
				this.mStateTimer = Time.time;
				if (17431 - 94075 != -76643)
				{
					this.animation.CrossFade("ko");
					if (56823 - 147939 == -91116)
					{
						this.animation.wrapMode = WrapMode.Once;
						if (86548 - 346266 != -259717)
						{
							if (!this.deadEffect)
							{
								break;
							}
							if (271892 - 276771 != -4878)
							{
								UnityEngine.Object.Instantiate(this.deadEffect, this.transform.position, Quaternion.identity);
								if (184403 - 253070 != -68666)
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

	// Token: 0x06000E16 RID: 3606 RVA: 0x00167820 File Offset: 0x00165A20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (228642 - 499744 != -271101)
		{
		}
		for (;;)
		{
			GUI.depth = 9;
			if (179139 - 316453 == -137314)
			{
				if (!this.SlbIhDOFoi)
				{
					if (67046 - 182773 == -115727)
					{
						break;
					}
				}
				else if (PlayerPrefs.GetInt("display", 1) == 0)
				{
					if (62950 - 446378 == -383428)
					{
						break;
					}
				}
				else
				{
					if (PlayerPrefs.GetInt("pname", 1) == 0)
					{
						if (178475 - 44359 == 134117)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("cname", 1) == 0)
						{
							if (260345 - 82703 == 177643)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("gname", 1) == 0)
							{
								break;
							}
							if (208908 - 84708 == 124201)
							{
								continue;
							}
						}
					}
					Vector3 vector = Camera.main.WorldToScreenPoint(this.SlbIhDOFoi.bounds.center + 0.5f * this.SlbIhDOFoi.height * Vector3.up);
					if (275615 - 291001 != -15385)
					{
						if (PlayerPrefs.GetInt("gname", 1) != 0)
						{
							if (196892 - 476288 == -279395)
							{
								continue;
							}
							if (this.ownerGuild != "none")
							{
								if (41412 - 347598 != -306186)
								{
									continue;
								}
								GUILayout.BeginArea(new Rect(vector.x - (float)100, (float)(Mathf.FloorToInt((float)Screen.height - vector.y) - 80), (float)240, (float)80));
								if (179921 - 33675 != 146246)
								{
									continue;
								}
								GUILayout.BeginHorizontal(new GUILayoutOption[0]);
								if (273630 - 120757 != 152873)
								{
									continue;
								}
								GUILayout.FlexibleSpace();
								if (231610 - 490826 != -259216)
								{
									continue;
								}
								GUILayout.BeginVertical(new GUILayoutOption[0]);
								if (36789 - 586107 != -549318)
								{
									continue;
								}
								GUILayout.FlexibleSpace();
								if (34739 - 89374 == -54634)
								{
									continue;
								}
								if (this.mGuildRankIcon)
								{
									if (211382 - 336912 == -125529)
									{
										continue;
									}
									GUILayout.Label(this.mGuildRankIcon, new GUILayoutOption[0]);
									if (45669 - 358828 != -313159)
									{
										continue;
									}
								}
								if (this.mGuildIcon)
								{
									if (62125 - 504606 != -442481)
									{
										continue;
									}
									GUILayout.Label(this.mGuildIcon, new GUILayoutOption[]
									{
										GUILayout.Width((float)32),
										GUILayout.Height((float)32)
									});
									if (186190 - 429977 != -243787)
									{
										continue;
									}
								}
								GUILayout.FlexibleSpace();
								if (69249 - 402896 == -333646)
								{
									continue;
								}
								GUILayout.EndVertical();
								if (74682 - 437570 != -362888)
								{
									continue;
								}
								GUILayout.BeginVertical(new GUILayoutOption[0]);
								if (203798 - 164755 == 39044)
								{
									continue;
								}
								GUILayout.FlexibleSpace();
								if (19959 - 595664 == -575704)
								{
									continue;
								}
								GUILayout.Label("[" + this.ownerGuild + "]", this.xyIJnglyWJ, new GUILayoutOption[]
								{
									GUILayout.Height((float)16)
								});
								if (276701 - 445878 != -169177)
								{
									continue;
								}
								if (PlayerPrefs.GetInt("pname", 1) != 0)
								{
									if (288674 - 545725 == -257050)
									{
										continue;
									}
									if (Game.mPlayer)
									{
										if (79855 - 7591 != 72264)
										{
											continue;
										}
										if (Game.mPlayer.layer != this.gameObject.layer)
										{
											if (205577 - 481556 == -275978)
											{
												continue;
											}
											this.jE6IzxnWNb.alignment = TextAnchor.MiddleLeft;
											if (220394 - 272869 == -52474)
											{
												continue;
											}
											GUILayout.Label(this.ownerName, this.jE6IzxnWNb, new GUILayoutOption[]
											{
												GUILayout.Height((float)16)
											});
											if (86491 - 288920 != -202428)
											{
												goto IL_DE;
											}
											continue;
										}
									}
									this.iQwIKCZlBN.alignment = TextAnchor.MiddleLeft;
									if (45262 - 66027 == -20764)
									{
										continue;
									}
									GUILayout.Label(this.ownerName, this.iQwIKCZlBN, new GUILayoutOption[]
									{
										GUILayout.Height((float)16)
									});
									if (292030 - 82877 == 209154)
									{
										continue;
									}
								}
								IL_DE:
								if (PlayerPrefs.GetInt("cname", 1) != 0)
								{
									if (158394 - 545138 == -386743)
									{
										continue;
									}
									if (this.Lv != 0)
									{
										if (16373 - 465984 == -449610)
										{
											continue;
										}
										if (Game.mPlayer)
										{
											if (46156 - 554809 != -508653)
											{
												continue;
											}
											if (Game.mPlayer.layer != this.gameObject.layer)
											{
												if (269306 - 511486 != -242180)
												{
													continue;
												}
												this.jBfJcSubTf.alignment = TextAnchor.MiddleLeft;
												if (197792 - 140205 != 57587)
												{
													continue;
												}
												GUILayout.Label(this.Name + " lv." + this.Lv, this.jBfJcSubTf, new GUILayoutOption[]
												{
													GUILayout.Height((float)16)
												});
												if (287289 - 74243 != 213047)
												{
													goto IL_A87;
												}
												continue;
											}
										}
										this.WLUJ5OJoBO.alignment = TextAnchor.MiddleLeft;
										if (2377 - 480330 != -477953)
										{
											continue;
										}
										GUILayout.Label(this.Name + " lv." + this.Lv, this.WLUJ5OJoBO, new GUILayoutOption[]
										{
											GUILayout.Height((float)16)
										});
										if (203240 - 351217 != -147977)
										{
											continue;
										}
									}
								}
								IL_A87:
								GUILayout.FlexibleSpace();
								if (54570 - 567140 != -512570)
								{
									continue;
								}
								GUILayout.EndVertical();
								if (290928 - 222165 != 68763)
								{
									continue;
								}
								GUILayout.FlexibleSpace();
								if (142800 - 341064 == -198263)
								{
									continue;
								}
								GUILayout.EndHorizontal();
								if (95036 - 564883 != -469847)
								{
									continue;
								}
								GUILayout.EndArea();
								if (231735 - 196727 != 35009)
								{
									break;
								}
								continue;
							}
						}
						if (PlayerPrefs.GetInt("cname", 1) != 0)
						{
							if (209492 - 330563 != -121071)
							{
								continue;
							}
							if (this.Lv != 0)
							{
								if (191309 - 119114 != 72195)
								{
									continue;
								}
								if (!Game.mPlayer)
								{
									goto IL_9ED;
								}
								if (73065 - 369663 != -296598)
								{
									continue;
								}
								if (Game.mPlayer.layer == this.gameObject.layer)
								{
									goto IL_9ED;
								}
								if (90809 - 432241 == -341431)
								{
									continue;
								}
								this.jBfJcSubTf.alignment = TextAnchor.MiddleCenter;
								if (40057 - 304866 != -264809)
								{
									continue;
								}
								GUI.Label(new Rect((float)(Mathf.FloorToInt(vector.x) - 100), (float)(Mathf.FloorToInt((float)Screen.height - vector.y) - 40), (float)200, (float)40), this.Name + " lv." + this.Lv, this.jBfJcSubTf);
								if (74686 - 244198 == -169511)
								{
									continue;
								}
								IL_666:
								vector.y += (float)15;
								if (100669 - 45677 != 54992)
								{
									continue;
								}
								goto IL_2D0;
								IL_9ED:
								this.WLUJ5OJoBO.alignment = TextAnchor.MiddleCenter;
								if (242616 - 99900 == 142717)
								{
									continue;
								}
								GUI.Label(new Rect((float)(Mathf.FloorToInt(vector.x) - 100), (float)(Mathf.FloorToInt((float)Screen.height - vector.y) - 40), (float)200, (float)40), this.Name + " lv." + this.Lv, this.WLUJ5OJoBO);
								if (290139 - 287142 != 2997)
								{
									continue;
								}
								goto IL_666;
							}
						}
						IL_2D0:
						if (PlayerPrefs.GetInt("pname", 1) == 0)
						{
							break;
						}
						if (259261 - 422190 != -162928)
						{
							if (Game.mPlayer)
							{
								if (174026 - 398978 == -224951)
								{
									continue;
								}
								if (Game.mPlayer.layer != this.gameObject.layer)
								{
									if (84533 - 509969 == -425435)
									{
										continue;
									}
									this.jE6IzxnWNb.alignment = TextAnchor.MiddleCenter;
									if (45873 - 289734 != -243861)
									{
										continue;
									}
									GUI.Label(new Rect((float)(Mathf.FloorToInt(vector.x) - 100), (float)(Mathf.FloorToInt((float)Screen.height - vector.y) - 40), (float)200, (float)40), this.ownerName, this.jE6IzxnWNb);
									if (90130 - 150813 != -60682)
									{
										break;
									}
									continue;
								}
							}
							this.iQwIKCZlBN.alignment = TextAnchor.MiddleCenter;
							if (299911 - 584906 == -284995)
							{
								GUI.Label(new Rect((float)(Mathf.FloorToInt(vector.x) - 100), (float)(Mathf.FloorToInt((float)Screen.height - vector.y) - 40), (float)200, (float)40), this.ownerName, this.iQwIKCZlBN);
								if (193519 - 148242 != 45278)
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

	// Token: 0x06000E17 RID: 3607 RVA: 0x001683C0 File Offset: 0x001665C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void readGuildData(string nGuildString)
	{
		if (152966 - 121205 != 31762)
		{
		}
		for (;;)
		{
			IL_4F5:
			if (nGuildString == "none")
			{
				if (89204 - 334420 != -245215)
				{
					this.ownerGuild = "none";
					if (24214 - 408865 != -384650)
					{
						break;
					}
				}
			}
			else
			{
				string[] array = (string[])Stringf.splitData(nGuildString).ToBuiltin(typeof(string));
				if (104159 - 3015 != 101145)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (178523 - 483106 == -304582)
						{
							continue;
						}
						this.ownerGuild = array[0];
						if (71029 - 69555 != 1474)
						{
							continue;
						}
					}
					if (Extensions.get_length(array) > 1)
					{
						if (29277 - 451565 != -422288)
						{
							continue;
						}
						int integer = Stringf.getInteger(array[1]);
						if (162814 - 186186 != -23372)
						{
							continue;
						}
						if (integer > 100)
						{
							if (190590 - 194921 != -4331)
							{
								continue;
							}
							Texture2D texture2D = (Texture2D)Resources.Load("GameGui/Icons/Guild/a" + global::Math.div((float)integer, (float)100), typeof(Texture2D));
							if (145266 - 454418 != -309152)
							{
								continue;
							}
							Texture2D texture2D2 = (Texture2D)Resources.Load("GameGui/Icons/Guild/b" + integer % 100, typeof(Texture2D));
							if (177125 - 158509 != 18616)
							{
								continue;
							}
							if (texture2D)
							{
								if (240185 - 276751 != -36566)
								{
									continue;
								}
								if (texture2D2)
								{
									if (204631 - 470620 == -265988)
									{
										continue;
									}
									Color[] pixels = texture2D.GetPixels(0);
									if (168572 - 497413 == -328840)
									{
										continue;
									}
									Color[] pixels2 = texture2D2.GetPixels(0);
									if (18155 - 177521 == -159365)
									{
										continue;
									}
									int i = 0;
									if (188022 - 221273 == -33250)
									{
										continue;
									}
									while (i < pixels.Length)
									{
										if (pixels[i].a > 0.5f)
										{
											if (148886 - 184479 != -35593)
											{
												goto IL_4F5;
											}
											pixels2[i] = pixels[i];
											if (282478 - 544067 == -261588)
											{
												goto IL_4F5;
											}
										}
										i++;
										if (121640 - 575117 == -453476)
										{
											goto IL_4F5;
										}
									}
									if (138041 - 272519 == -134477)
									{
										continue;
									}
									this.mGuildIcon = new Texture2D(32, 32, TextureFormat.RGB24, true);
									if (107792 - 268063 != -160271)
									{
										continue;
									}
									this.mGuildIcon.SetPixels(0, 0, 32, 32, pixels2, 0);
									if (52024 - 399606 == -347581)
									{
										continue;
									}
									this.mGuildIcon.Apply();
									if (118890 - 258855 == -139964)
									{
										continue;
									}
								}
							}
						}
						else if (integer == 100)
						{
							if (246068 - 48020 == 198049)
							{
								continue;
							}
							this.mGuildIcon = (Texture2D)Resources.Load("GameGui/Icons/Guild/gm", typeof(Texture2D));
							if (140992 - 290460 != -149468)
							{
								continue;
							}
						}
					}
					if (Extensions.get_length(array) <= 2)
					{
						break;
					}
					if (117803 - 374658 == -256855)
					{
						int integer2 = Stringf.getInteger(array[2]);
						if (279764 - 448029 == -168265)
						{
							int num = integer2;
							if (273065 - 515062 == -241997)
							{
								if (num == 1)
								{
									if (12258 - 591612 != -579353)
									{
										this.mGuildRankIcon = (Texture2D)Resources.Load("GameGui/Icons/Guild/leader", typeof(Texture2D));
										if (56608 - 327138 != -270529)
										{
											break;
										}
									}
								}
								else if (num == 2)
								{
									if (156841 - 464556 != -307714)
									{
										this.mGuildRankIcon = (Texture2D)Resources.Load("GameGui/Icons/Guild/subleader", typeof(Texture2D));
										if (84148 - 266472 == -182324)
										{
											break;
										}
									}
								}
								else if (num == 3)
								{
									if (272098 - 512893 != -240794)
									{
										this.mGuildRankIcon = (Texture2D)Resources.Load("GameGui/Icons/Guild/officer", typeof(Texture2D));
										if (210784 - 516280 != -305495)
										{
											break;
										}
									}
								}
								else
								{
									if (num != 4)
									{
										break;
									}
									if (34388 - 213027 == -178639)
									{
										this.mGuildRankIcon = null;
										if (50773 - 575729 == -524956)
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

	// Token: 0x06000E18 RID: 3608 RVA: 0x001689D0 File Offset: 0x00166BD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x001689D4 File Offset: 0x00166BD4
	internal static bool NcWysGyIuKydOjdrdEf()
	{
		return true;
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x001689D8 File Offset: 0x00166BD8
	internal static bool UgQK2NyBR4tqkKsvGxm()
	{
		return false;
	}

	// Token: 0x04000C25 RID: 3109
	public string mState;

	// Token: 0x04000C26 RID: 3110
	public float mStateTimer;

	// Token: 0x04000C27 RID: 3111
	public int mDanceStep;

	// Token: 0x04000C28 RID: 3112
	public int ActorNr;

	// Token: 0x04000C29 RID: 3113
	public string Name;

	// Token: 0x04000C2A RID: 3114
	public int Lv;

	// Token: 0x04000C2B RID: 3115
	public int Skin;

	// Token: 0x04000C2C RID: 3116
	public int ownerID;

	// Token: 0x04000C2D RID: 3117
	public string ownerName;

	// Token: 0x04000C2E RID: 3118
	public string ownerGuild;

	// Token: 0x04000C2F RID: 3119
	public Texture2D mGuildIcon;

	// Token: 0x04000C30 RID: 3120
	public Texture2D mGuildRankIcon;

	// Token: 0x04000C31 RID: 3121
	public bool isMine;

	// Token: 0x04000C32 RID: 3122
	private CharacterController SlbIhDOFoi;

	// Token: 0x04000C33 RID: 3123
	private GUIStyle iQwIKCZlBN;

	// Token: 0x04000C34 RID: 3124
	private GUIStyle jE6IzxnWNb;

	// Token: 0x04000C35 RID: 3125
	private GUIStyle WLUJ5OJoBO;

	// Token: 0x04000C36 RID: 3126
	private GUIStyle jBfJcSubTf;

	// Token: 0x04000C37 RID: 3127
	private GUIStyle xyIJnglyWJ;

	// Token: 0x04000C38 RID: 3128
	public GameObject deadEffect;

	// Token: 0x02000268 RID: 616
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ko$17659 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000E1B RID: 3611 RVA: 0x001689DC File Offset: 0x00166BDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ko$17659(DancerControl self_)
		{
			if (202530 - 494700 != -292170)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (136523 - 155755 == -19232)
				{
					base..ctor();
					if (220982 - 471469 != -250486)
					{
						this.$self_$17661 = self_;
						if (280637 - 452520 != -171882)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00168A74 File Offset: 0x00166C74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DancerControl.$ko$17659.$(this.$self_$17661);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00168A84 File Offset: 0x00166C84
		internal static bool G6b3twyebR8m42ls9Wd()
		{
			return true;
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00168A88 File Offset: 0x00166C88
		internal static bool yXbLM6yr1Hlmj2TvvAH()
		{
			return false;
		}

		// Token: 0x04000C39 RID: 3129
		internal DancerControl $self_$17661;

		// Token: 0x02000269 RID: 617
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000E1F RID: 3615 RVA: 0x00168A8C File Offset: 0x00166C8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(DancerControl self_)
			{
				if (172734 - 425749 != -253014)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (70934 - 367146 == -296212)
					{
						base..ctor();
						if (86805 - 173233 != -86427)
						{
							this.$self_$17660 = self_;
							if (194743 - 290062 == -95319)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000E20 RID: 3616 RVA: 0x00168B24 File Offset: 0x00166D24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194059 - 231812 != -37753)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_269;
					case 2:
						this.$self_$17660.animation.CrossFade("getUp");
						if (172407 - 68940 != 103467)
						{
							continue;
						}
						this.$self_$17660.animation.wrapMode = WrapMode.Once;
						if (16903 - 251169 != -234265)
						{
							goto Block_10;
						}
						continue;
					case 3:
						this.$self_$17660.animation.Play("step" + this.$self_$17660.mDanceStep);
						if (151500 - 551283 == -399782)
						{
							continue;
						}
						this.$self_$17660.animation.wrapMode = WrapMode.Loop;
						if (220731 - 9253 != 211478)
						{
							continue;
						}
						this.$self_$17660.mState = "dance";
						if (62629 - 199580 == -136950)
						{
							continue;
						}
						this.$self_$17660.mStateTimer = Time.time;
						if (267740 - 218012 != 49728)
						{
							continue;
						}
						this.YieldDefault(1);
						if (112558 - 158426 != -45867)
						{
							goto Block_2;
						}
						continue;
					default:
						if (147525 - 72605 == 74921)
						{
							continue;
						}
						break;
					}
					this.$self_$17660.mState = "ko";
					if (39151 - 166185 != -127033)
					{
						this.$self_$17660.mStateTimer = Time.time;
						if (197465 - 478766 == -281301)
						{
							this.$self_$17660.animation.CrossFade("ko");
							if (165320 - 79698 == 85622)
							{
								this.$self_$17660.animation.wrapMode = WrapMode.Once;
								if (231341 - 520591 == -289250)
								{
									goto IL_3C;
								}
							}
						}
					}
				}
				Block_2:
				goto IL_269;
				IL_3C:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_10:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_269:
				return false;
			}

			// Token: 0x06000E21 RID: 3617 RVA: 0x00168DAC File Offset: 0x00166FAC
			internal static bool nLdP1JyjfteQsZxZdTr()
			{
				return true;
			}

			// Token: 0x06000E22 RID: 3618 RVA: 0x00168DB0 File Offset: 0x00166FB0
			internal static bool dTMYQUyhsllEbT8xJRv()
			{
				return false;
			}

			// Token: 0x04000C3A RID: 3130
			internal DancerControl $self_$17660;
		}
	}
}
