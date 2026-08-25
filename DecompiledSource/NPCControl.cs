using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000FAC RID: 4012
[AddComponentMenu("MissionControl/NPCControl")]
[Serializable]
public class NPCControl : MonoBehaviour
{
	// Token: 0x06005B5D RID: 23389 RVA: 0x00B2AF50 File Offset: 0x00B29150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPCControl()
	{
		if (170564 - 154109 != 16455)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (138396 - 313082 == -174686)
			{
				base..ctor();
				if (154054 - 140683 == 13371)
				{
					this.mCommand = "none";
					if (172243 - 448011 != -275767)
					{
						this.mRange = 2;
						if (10101 - 155962 == -145861)
						{
							this.mButtonScale = 1f;
							if (162630 - 277726 == -115096)
							{
								this.mName = "none";
								if (30276 - 398982 != -368705)
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

	// Token: 0x06005B5E RID: 23390 RVA: 0x00B2B058 File Offset: 0x00B29258
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (240963 - 349501 != -108538)
		{
		}
		do
		{
			if (!(this.mCommand == "none"))
			{
				if (110416 - 244811 == -134394)
				{
					continue;
				}
				if (this.mCommand == string.Empty)
				{
					if (268960 - 299598 == -30637)
					{
						continue;
					}
				}
				else
				{
					this.kGPc2Imi4NT = Time.time + 0.5f;
					if (260611 - 329388 != -68777)
					{
						continue;
					}
					this.XHfc25A7H2f = this.collider.bounds.center + this.transform.forward * this.collider.bounds.extents.z * 0.7f;
					if (2837 - 464355 == -461517)
					{
						continue;
					}
					this.dqfc2c18mhH = new GUIStyle();
					if (52878 - 265633 == -212754)
					{
						continue;
					}
					this.dqfc2c18mhH.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/TargetArea/targetNPC", typeof(Texture)));
					if (87288 - 362945 != -275657)
					{
						continue;
					}
					this.dqfc2c18mhH.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/TargetArea/targetNPC_h", typeof(Texture)));
					if (139126 - 521728 == -382601)
					{
						continue;
					}
					this.xgqc2novAX3 = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
					if (98786 - 540401 != -441615)
					{
						continue;
					}
					this.u6Pc2QmVtPd = this.collider.bounds.center + Vector3.up * this.collider.bounds.extents.y;
					if (75104 - 275661 != -200557)
					{
						continue;
					}
					this.X0rc2eM5VUq = new GUIStyle();
					if (299087 - 20020 == 279068)
					{
						continue;
					}
					this.X0rc2eM5VUq.font = (Font)Resources.Load("GameGui/Fonts/GMO24");
					if (175526 - 411170 != -235644)
					{
						continue;
					}
					this.X0rc2eM5VUq.normal.textColor = new Color(0.6f, 0.9f, 0.6f, (float)1);
					if (198866 - 297181 != -98315)
					{
						continue;
					}
					this.X0rc2eM5VUq.alignment = TextAnchor.MiddleCenter;
					if (163609 - 438075 != -274466)
					{
						continue;
					}
					break;
				}
			}
			this.enabled = false;
		}
		while (210041 - 180066 != 29975);
	}

	// Token: 0x06005B5F RID: 23391 RVA: 0x00B2B3B8 File Offset: 0x00B295B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (this.animation)
		{
			this.animation.Play();
		}
	}

	// Token: 0x06005B60 RID: 23392 RVA: 0x00B2B3D8 File Offset: 0x00B295D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBecameVisible()
	{
		this.enabled = true;
	}

	// Token: 0x06005B61 RID: 23393 RVA: 0x00B2B3E4 File Offset: 0x00B295E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBecameInvisible()
	{
		this.enabled = false;
	}

	// Token: 0x06005B62 RID: 23394 RVA: 0x00B2B3F0 File Offset: 0x00B295F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (163531 - 86859 != 76672)
		{
		}
		for (;;)
		{
			if (!Camera.main)
			{
				if (100536 - 302997 == -202461)
				{
					break;
				}
			}
			else
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (241182 - 477636 == -236454)
				{
					if (Game.mPlayer == null)
					{
						if (19588 - 386186 != -366597)
						{
							break;
						}
					}
					else
					{
						GUI.depth = 3;
						if (244477 - 283630 != -39152)
						{
							if (Time.time > this.kGPc2Imi4NT)
							{
								if (238007 - 533689 != -295682)
								{
									continue;
								}
								this.a2sc2JZUgyc = (int)Mathf.Clamp((Game.mPlayer.transform.position - this.transform.position).sqrMagnitude, (float)0, (float)100);
								if (132840 - 277767 != -144927)
								{
									continue;
								}
								if (this.a2sc2JZUgyc <= this.mRange * this.mRange)
								{
									if (67008 - 345256 == -278247)
									{
										continue;
									}
									if (this.isMovable)
									{
										if (179104 - 494129 != -315025)
										{
											continue;
										}
										this.XHfc25A7H2f = this.collider.bounds.center + this.transform.forward * this.collider.bounds.extents.z * 0.7f;
										if (2466 - 122696 == -120229)
										{
											continue;
										}
									}
									Vector3 vector = Camera.main.WorldToScreenPoint(this.XHfc25A7H2f);
									if (140105 - 381945 == -241839)
									{
										continue;
									}
									if (vector.z > (float)0)
									{
										if (197499 - 400335 == -202835)
										{
											continue;
										}
										float num = this.mButtonScale * Mathf.Clamp(0.5f * (float)Screen.height / vector.z, (float)32, (float)128);
										if (285239 - 58366 != 226873)
										{
											continue;
										}
										Rect position = new Rect(vector.x - num, (float)Screen.height - vector.y + (float)this.mButtonOffset, num * (float)2, num);
										if (134225 - 439411 != -305186)
										{
											continue;
										}
										if (GUI.Button(position, string.Empty, this.dqfc2c18mhH))
										{
											if (164842 - 408878 != -244036)
											{
												continue;
											}
											GameObject mPlayer = Game.mPlayer;
											if (91581 - 341077 != -249496)
											{
												continue;
											}
											CharacterControl characterControl = null;
											if (202534 - 491826 != -289292)
											{
												continue;
											}
											if (mPlayer)
											{
												if (102905 - 208956 == -106050)
												{
													continue;
												}
												characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
												if (47223 - 599855 == -552631)
												{
													continue;
												}
											}
											if (!characterControl)
											{
												if (29703 - 188891 != -159188)
												{
													continue;
												}
												break;
											}
											else if (characterControl.isTransform)
											{
												if (73746 - 527730 == -453983)
												{
													continue;
												}
												Camera.main.SendMessage("newGameMessage", "Cannot talk during mount or transformed");
												if (294013 - 422948 == -128934)
												{
													continue;
												}
											}
											else
											{
												this.kGPc2Imi4NT = Time.time + 0.2f;
												if (210911 - 251379 == -40467)
												{
													continue;
												}
												Camera.main.SendMessage(this.mCommand, this.mVariable);
												if (189092 - 453181 == -264088)
												{
													continue;
												}
												if (Camera.main.audio)
												{
													if (95118 - 112386 != -17268)
													{
														continue;
													}
													if (this.xgqc2novAX3)
													{
														if (275960 - 556164 == -280203)
														{
															continue;
														}
														Camera.main.audio.PlayOneShot(this.xgqc2novAX3);
														if (221883 - 420086 == -198202)
														{
															continue;
														}
													}
													if (this.mVoice)
													{
														if (6704 - 3763 == 2942)
														{
															continue;
														}
														if (PlayerPrefs.GetInt("nvoice", 1) != 0)
														{
															if (124180 - 394093 == -269912)
															{
																continue;
															}
															Camera.main.audio.PlayOneShot(this.mVoice);
															if (66991 - 553183 == -486191)
															{
																continue;
															}
														}
													}
												}
												if (this.mTutorialIcon)
												{
													if (73241 - 198764 == -125522)
													{
														continue;
													}
													UnityEngine.Object.Destroy(this.mTutorialIcon);
													if (61050 - 574206 != -513156)
													{
														continue;
													}
												}
											}
										}
									}
									else
									{
										this.kGPc2Imi4NT = Time.time + 0.5f;
										if (276368 - 62983 != 213385)
										{
											continue;
										}
									}
								}
								else
								{
									this.kGPc2Imi4NT = Time.time + (float)this.a2sc2JZUgyc * 0.02f;
									if (19724 - 202912 == -183187)
									{
										continue;
									}
								}
							}
							if (!(this.mName != "none"))
							{
								break;
							}
							if (101917 - 525507 == -423590)
							{
								if (!(this.mName != string.Empty))
								{
									break;
								}
								if (261365 - 172548 != 88818)
								{
									if (this.a2sc2JZUgyc > 36)
									{
										break;
									}
									if (102553 - 471406 != -368852)
									{
										if (PlayerPrefs.GetInt("display", 1) == 0)
										{
											break;
										}
										if (192201 - 548856 != -356654)
										{
											if (PlayerPrefs.GetInt("cname", 1) == 0)
											{
												break;
											}
											if (271357 - 215525 != 55833)
											{
												if (this.isMovable)
												{
													if (160487 - 55947 != 104540)
													{
														continue;
													}
													this.u6Pc2QmVtPd = this.collider.bounds.center + Vector3.up * this.collider.bounds.extents.y;
													if (202794 - 420048 != -217254)
													{
														continue;
													}
												}
												Vector3 vector2 = Camera.main.WorldToScreenPoint(this.u6Pc2QmVtPd);
												if (63581 - 569538 != -505956)
												{
													if ((float)0 > vector2.z)
													{
														break;
													}
													if (126452 - 189682 == -63230)
													{
														if (vector2.z > (float)24)
														{
															break;
														}
														if (31206 - 115477 == -84271)
														{
															GUI.Label(new Rect((float)(Mathf.FloorToInt(vector2.x) - 100), (float)(Mathf.FloorToInt((float)Screen.height - vector2.y) - 40), (float)200, (float)40), this.mName, this.X0rc2eM5VUq);
															if (3801 - 40817 != -37015)
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

	// Token: 0x06005B63 RID: 23395 RVA: 0x00B2BC8C File Offset: 0x00B29E8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005B64 RID: 23396 RVA: 0x00B2BC90 File Offset: 0x00B29E90
	internal static bool RjlamkpNZ4iAQ4EyaGJd()
	{
		return true;
	}

	// Token: 0x06005B65 RID: 23397 RVA: 0x00B2BC94 File Offset: 0x00B29E94
	internal static bool f1XxLlpNCFCV2aqoOrYY()
	{
		return false;
	}

	// Token: 0x04006697 RID: 26263
	public Texture MapIcon;

	// Token: 0x04006698 RID: 26264
	public string mCommand;

	// Token: 0x04006699 RID: 26265
	public int mVariable;

	// Token: 0x0400669A RID: 26266
	public int mRange;

	// Token: 0x0400669B RID: 26267
	public float mButtonScale;

	// Token: 0x0400669C RID: 26268
	public int mButtonOffset;

	// Token: 0x0400669D RID: 26269
	public bool isMovable;

	// Token: 0x0400669E RID: 26270
	public string mName;

	// Token: 0x0400669F RID: 26271
	public int mNameOffset;

	// Token: 0x040066A0 RID: 26272
	public AudioClip mVoice;

	// Token: 0x040066A1 RID: 26273
	public GameObject mTutorialIcon;

	// Token: 0x040066A2 RID: 26274
	private Vector3 XHfc25A7H2f;

	// Token: 0x040066A3 RID: 26275
	private GUIStyle dqfc2c18mhH;

	// Token: 0x040066A4 RID: 26276
	private AudioClip xgqc2novAX3;

	// Token: 0x040066A5 RID: 26277
	private Vector3 u6Pc2QmVtPd;

	// Token: 0x040066A6 RID: 26278
	private GUIStyle X0rc2eM5VUq;

	// Token: 0x040066A7 RID: 26279
	private float kGPc2Imi4NT;

	// Token: 0x040066A8 RID: 26280
	private int a2sc2JZUgyc;
}
