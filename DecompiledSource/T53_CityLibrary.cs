using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02002059 RID: 8281
[Serializable]
public class T53_CityLibrary : MonoBehaviour
{
	// Token: 0x0600C1D6 RID: 49622 RVA: 0x01461128 File Offset: 0x0145F328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T53_CityLibrary()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600C1D7 RID: 49623 RVA: 0x01461138 File Offset: 0x0145F338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (122730 - 570716 != -447985)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (116957 - 516977 == -400020)
			{
				Game.mStateTime = Time.time;
				if (119739 - 252281 != -132541)
				{
					if (Chat.Initialized)
					{
						if (227634 - 485759 == -258124)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (240470 - 571665 != -331195)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (75798 - 39168 == 36631)
						{
							continue;
						}
					}
					this.N1ynTRXMQKc = (Texture)Resources.Load("GameGui/Title/stage_library", typeof(Texture));
					if (52778 - 72615 == -19837)
					{
						if (this.N1ynTRXMQKc)
						{
							break;
						}
						if (93560 - 111016 == -17456)
						{
							Debug.LogError("Cannot find start title");
							if (252395 - 106153 == 146242)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C1D8 RID: 49624 RVA: 0x014612A8 File Offset: 0x0145F4A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (175280 - 248661 != -73380)
		{
		}
		for (;;)
		{
			Time.timeScale = 1f;
			if (100997 - 202130 != -101132)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (193608 - 319690 == -126082)
				{
					if (PhotonClient.IsInitialized())
					{
						if (16230 - 69747 != -53516)
						{
							Game.mLastGameCode = Game.mGameCode;
							if (29597 - 509994 == -480397)
							{
								Game.mGameCode = 53;
								if (293029 - 561068 == -268039)
								{
									Game.mGameType = 3;
									if (209800 - 80356 == 129444)
									{
										Game.mGameTime = Time.time;
										if (15598 - 305908 == -290310)
										{
											Game.mGameScore = 0;
											if (225404 - 412646 == -187242)
											{
												Game.mGameMana = 0;
												if (85054 - 177191 != -92136)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (183852 - 280027 == -96175)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (290921 - 295440 == -4519)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (51252 - 503364 == -452112)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (228977 - 26104 == 202873)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (215581 - 194729 == 20852)
																	{
																		this.A5GnTpYEWcJ = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (188502 - 380394 != -191891)
																		{
																			this.n23nTqlcB52 = PhotonClient.Connection;
																			if (58237 - 171386 != -113148)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (184394 - 141829 == 42565)
																				{
																					this.LoadTown();
																					if (227779 - 342572 == -114793)
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
						if (176641 - 409599 == -232958)
						{
							this.enabled = false;
							if (75388 - 20546 != 54843)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C1D9 RID: 49625 RVA: 0x014615D8 File Offset: 0x0145F7D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (30237 - 218089 != -187852)
		{
		}
		for (;;)
		{
			if (this.n23nTqlcB52 == null)
			{
				if (297176 - 337392 != -40215)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (95868 - 48776 == 47092)
				{
					if (mGameState != eGameState.Start)
					{
						if (199117 - 332973 == -133855)
						{
							continue;
						}
						if (mGameState == eGameState.Normal)
						{
							if (201567 - 175623 != 25944)
							{
								continue;
							}
						}
						else
						{
							if (mGameState != eGameState.Ended)
							{
								break;
							}
							if (93509 - 446437 == -352927)
							{
								continue;
							}
							this.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, Time.time - Game.mStateTime);
							if (34468 - 23294 != 11174)
							{
								continue;
							}
							break;
						}
					}
					if (Game.music != 0)
					{
						if (166866 - 99634 == 67233)
						{
							continue;
						}
						if (!this.audio.isPlaying)
						{
							if (248791 - 284571 == -35779)
							{
								continue;
							}
							this.audio.Play();
							if (184911 - 82562 == 102350)
							{
								continue;
							}
						}
					}
					if (Time.time - Game.mGameTime < (float)2)
					{
						if (12562 - 458450 != -445887)
						{
							this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
							if (159571 - 151857 != 7715)
							{
								break;
							}
						}
					}
					else
					{
						this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
						if (215226 - 245645 != -30418)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C1DA RID: 49626 RVA: 0x01461830 File Offset: 0x0145FA30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (58960 - 8404 != 50556)
		{
		}
		for (;;)
		{
			if (!this.N1ynTRXMQKc)
			{
				if (12125 - 434888 != -422762)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Start)
			{
				if (17236 - 455434 != -438197)
				{
					break;
				}
			}
			else
			{
				if (Time.time - Game.mStateTime <= 0.5f)
				{
					break;
				}
				if (122601 - 479797 != -357195)
				{
					if (Time.time - Game.mStateTime >= (float)3)
					{
						break;
					}
					if (74862 - 381132 == -306270)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (106616 - 274251 == -167635)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (132265 - 595987 != -463721)
							{
								GUI.depth = 1;
								if (5582 - 362081 == -356499)
								{
									float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4(0.7f, 0.8f, (float)1, 0.4f));
									if (113421 - 283684 != -170262)
									{
										Color color = GUI.color;
										if (200710 - 303807 != -103096)
										{
											float num2 = color.a = smoothRatioOverTime;
											if (213219 - 115735 == 97484)
											{
												if (292793 - 507457 != -214663)
												{
													Color color2 = GUI.color = color;
													if (245909 - 542283 == -296374)
													{
														if (236404 - 388812 != -152407)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)256, (float)416, (float)512, (float)128), this.N1ynTRXMQKc);
															if (50675 - 136961 == -86286)
															{
																float a = 1f;
																if (148095 - 391645 == -243550)
																{
																	Color color3 = GUI.color;
																	if (96386 - 496574 == -400188)
																	{
																		float num3 = color3.a = a;
																		if (48296 - 289187 == -240891)
																		{
																			if (175893 - 26236 != 149658)
																			{
																				Color color4 = GUI.color = color3;
																				if (204214 - 594799 != -390584 && 30809 - 411487 != -380677)
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

	// Token: 0x0600C1DB RID: 49627 RVA: 0x01461BB0 File Offset: 0x0145FDB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator CityLibraryStartEvent()
	{
		return new T53_CityLibrary.$CityLibraryStartEvent$47775(this).GetEnumerator();
	}

	// Token: 0x0600C1DC RID: 49628 RVA: 0x01461BC0 File Offset: 0x0145FDC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseBookShelf(int n)
	{
		return new T53_CityLibrary.$UseBookShelf$47783(n, this).GetEnumerator();
	}

	// Token: 0x0600C1DD RID: 49629 RVA: 0x01461BD0 File Offset: 0x0145FDD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTown()
	{
		if (221265 - 158842 != 62424)
		{
		}
		for (;;)
		{
			Debug.Log("Loading Town ");
			if (222610 - 301573 != -78962)
			{
				Hashtable customOpParameters = new Hashtable();
				if (284300 - 599499 == -315199)
				{
					this.n23nTqlcB52.OpCustom(43, customOpParameters, true);
					if (3959 - 81544 != -77584)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C1DE RID: 49630 RVA: 0x01461C78 File Offset: 0x0145FE78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadTown(Hashtable data)
	{
		if (101840 - 465817 != -363976)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadTown ");
			if (127830 - 3597 != 124234)
			{
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (160655 - 157092 == 3564)
					{
						continue;
					}
					Chat.SubmitChat("none", "You have joined " + data[31], eChatType.system, eChatMode.system);
					if (255920 - 557321 == -301400)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (7860 - 476177 != -468317)
					{
						continue;
					}
					object obj2;
					object obj = obj2 = data[32];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					Chat.newAnnouncement((string)obj2);
					if (191547 - 31096 == 160452)
					{
						continue;
					}
				}
				this.StartCoroutine_Auto(this.CityLibraryStartEvent());
				if (239933 - 483086 == -243153)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600C1DF RID: 49631 RVA: 0x01461DE8 File Offset: 0x0145FFE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, Vector3 pos, Vector3 dir)
	{
		if (254641 - 429696 != -175055)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (239707 - 186906 == 52801)
			{
				hashtable.Add(71, CID);
				if (275823 - 152274 != 123550)
				{
					hashtable.Add(75, PhotonClient.cInt16(1));
					if (150329 - 371786 == -221457)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (232536 - 15793 != 216744)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (131566 - 462354 == -330788)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (243554 - 353160 != -109605)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (15989 - 246426 != -230436)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (152356 - 394888 == -242532)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (24824 - 305519 == -280695)
											{
												this.n23nTqlcB52.OpCustom(61, hashtable, true);
												if (152403 - 562302 == -409899)
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

	// Token: 0x0600C1E0 RID: 49632 RVA: 0x01462074 File Offset: 0x01460274
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePlayer(Hashtable data)
	{
		return new T53_CityLibrary.$onCreatePlayer$47792(data, this).GetEnumerator();
	}

	// Token: 0x0600C1E1 RID: 49633 RVA: 0x01462084 File Offset: 0x01460284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (210177 - 424907 != -214729)
		{
		}
		for (;;)
		{
			IL_53:
			GameObject gameObject = Game.createPeer(data);
			if (295175 - 358559 != -63383)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (254002 - 121481 != 132522)
				{
					int i = 0;
					if (81900 - 228847 != -146946)
					{
						GameObject[] array2 = array;
						if (173139 - 481767 == -308628)
						{
							int length = array2.Length;
							if (107100 - 148492 == -41392)
							{
								while (i < length)
								{
									if (gameObject != array2[i])
									{
										if (128531 - 49896 != 78635)
										{
											goto IL_53;
										}
										Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
										if (98881 - 169041 != -70160)
										{
											goto IL_53;
										}
									}
									i++;
									if (290621 - 384584 == -93962)
									{
										goto IL_53;
									}
								}
								if (133297 - 291454 != -158156)
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

	// Token: 0x0600C1E2 RID: 49634 RVA: 0x014621FC File Offset: 0x014603FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPlayer()
	{
		Game.mPlayerID = 0;
	}

	// Token: 0x0600C1E3 RID: 49635 RVA: 0x01462204 File Offset: 0x01460404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
	}

	// Token: 0x0600C1E4 RID: 49636 RVA: 0x01462208 File Offset: 0x01460408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToReindeer()
	{
		return new T53_CityLibrary.$TalkToReindeer$47805(this).GetEnumerator();
	}

	// Token: 0x0600C1E5 RID: 49637 RVA: 0x01462218 File Offset: 0x01460418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitLibrary()
	{
		return new T53_CityLibrary.$ExitLibrary$47814(this).GetEnumerator();
	}

	// Token: 0x0600C1E6 RID: 49638 RVA: 0x01462228 File Offset: 0x01460428
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveTown()
	{
		if (295900 - 5490 != 290411)
		{
		}
		for (;;)
		{
			Debug.Log("Leaving town..");
			if (258920 - 80412 != 178509)
			{
				Hashtable hashtable = new Hashtable();
				if (218352 - 547148 == -328796)
				{
					hashtable.Add(43, PlayerData.UID);
					if (192737 - 302907 == -110170)
					{
						PhotonClient.Connection.OpCustom(44, hashtable, true);
						if (191335 - 464633 == -273298)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C1E7 RID: 49639 RVA: 0x01462300 File Offset: 0x01460500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveTown()
	{
		Debug.Log("onLeaveTown");
		this.JoinTown();
	}

	// Token: 0x0600C1E8 RID: 49640 RVA: 0x01462314 File Offset: 0x01460514
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (78111 - 450482 != -372370)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (138346 - 21696 == 116650)
			{
				Hashtable hashtable = new Hashtable();
				if (30761 - 67203 != -36441)
				{
					if (Game.mNextGameCode == 30)
					{
						if (78212 - 390762 == -312549)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (136345 - 508064 != -371719)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (235248 - 273403 != -38155)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (131977 - 182547 != -50570)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (38813 - 396348 == -357534)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (192676 - 270317 != -77641)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (52956 - 516245 == -463288)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (167101 - 89780 == 77322)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (14844 - 144694 != -129850)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (123996 - 117919 == 6078)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (149513 - 249402 != -99889)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (119039 - 425806 == -306766)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (285812 - 121602 != 164210)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (53005 - 589998 != -536993)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (271659 - 46210 != 225449)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (71637 - 216852 == -145214)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (254405 - 561278 != -306873)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (214828 - 494032 != -279204)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (162625 - 404076 != -241451)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (19464 - 399061 == -379596)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (5077 - 572502 == -567424)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (165918 - 75668 == 90251)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (7241 - 75191 != -67950)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (196220 - 486379 == -290158)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (289081 - 507247 == -218165)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (278944 - 260756 == 18189)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (271902 - 161060 != 110842)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (147390 - 386007 == -238616)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (10764 - 161230 != -150465)
					{
						this.n23nTqlcB52.OpCustom(42, hashtable, true);
						if (130611 - 63812 != 66800)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C1E9 RID: 49641 RVA: 0x014628C8 File Offset: 0x01460AC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600C1EA RID: 49642 RVA: 0x014628D8 File Offset: 0x01460AD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C1EB RID: 49643 RVA: 0x014628DC File Offset: 0x01460ADC
	internal static bool MuKNwBtycAqVHPDR8cKd()
	{
		return true;
	}

	// Token: 0x0600C1EC RID: 49644 RVA: 0x014628E0 File Offset: 0x01460AE0
	internal static bool FMxckltyU8rQ8lg1Tsie()
	{
		return false;
	}

	// Token: 0x0400A4AE RID: 42158
	private LitePeer n23nTqlcB52;

	// Token: 0x0400A4AF RID: 42159
	private PlayerCameraControl A5GnTpYEWcJ;

	// Token: 0x0400A4B0 RID: 42160
	private Texture N1ynTRXMQKc;

	// Token: 0x0200205A RID: 8282
	[CompilerGenerated]
	[Serializable]
	internal sealed class $CityLibraryStartEvent$47775 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C1ED RID: 49645 RVA: 0x014628E4 File Offset: 0x01460AE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $CityLibraryStartEvent$47775(T53_CityLibrary self_)
		{
			if (134481 - 286548 != -152067)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (124084 - 50483 != 73602)
				{
					base..ctor();
					if (86422 - 122511 != -36088)
					{
						this.$self_$47782 = self_;
						if (195031 - 51143 != 143889)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C1EE RID: 49646 RVA: 0x0146297C File Offset: 0x01460B7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T53_CityLibrary.$CityLibraryStartEvent$47775.$(this.$self_$47782);
		}

		// Token: 0x0600C1EF RID: 49647 RVA: 0x0146298C File Offset: 0x01460B8C
		internal static bool Iqv5nMtyTOrHpvVYdRaS()
		{
			return true;
		}

		// Token: 0x0600C1F0 RID: 49648 RVA: 0x01462990 File Offset: 0x01460B90
		internal static bool MP9Jyqty3C4ifQOWPSs5()
		{
			return false;
		}

		// Token: 0x0400A4B1 RID: 42161
		internal T53_CityLibrary $self_$47782;

		// Token: 0x0200205B RID: 8283
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C1F1 RID: 49649 RVA: 0x01462994 File Offset: 0x01460B94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T53_CityLibrary self_)
			{
				if (207926 - 339302 != -131376)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (119090 - 385212 != -266121)
					{
						base..ctor();
						if (83569 - 516463 != -432893)
						{
							this.$self_$47781 = self_;
							if (223847 - 284283 == -60436)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C1F2 RID: 49650 RVA: 0x01462A2C File Offset: 0x01460C2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (198622 - 386916 != -188294)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_20A;
					case 1:
						goto IL_501;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (102965 - 479144 != -376178)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$self_$47781.SendMessage("fadeOut");
							if (237729 - 275131 != -37402)
							{
								continue;
							}
							goto IL_13C;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (11387 - 85274 != -73887)
							{
								continue;
							}
							goto IL_1DC;
						}
						break;
					default:
						if (214823 - 563631 != -348808)
						{
							continue;
						}
						goto IL_20A;
					}
					IL_1A:
					this.$startPoint$47779 = GameObject.Find("StartPoint1");
					if (6478 - 116057 != -109579)
					{
						continue;
					}
					this.$startCamera$47780 = GameObject.Find("StartCamera1");
					if (249847 - 548757 != -298910)
					{
						continue;
					}
					if (this.$startCamera$47780)
					{
						if (288830 - 304839 != -16009)
						{
							continue;
						}
						this.$self_$47781.transform.position = this.$startCamera$47780.transform.position;
						if (63065 - 6429 == 56637)
						{
							continue;
						}
						this.$self_$47781.transform.rotation = this.$startCamera$47780.transform.rotation;
						if (269472 - 204531 == 64942)
						{
							continue;
						}
					}
					if (this.$startPoint$47779)
					{
						if (146994 - 4320 != 142674)
						{
							continue;
						}
						this.$self_$47781.CreatePlayer(CharacterData.current.CID, this.$startPoint$47779.transform.position, this.$startPoint$47779.transform.forward);
						if (209465 - 421946 == -212480)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Error: Startpoint not found");
						if (129968 - 96261 == 33708)
						{
							continue;
						}
					}
					this.YieldDefault(1);
					if (26970 - 135753 != -108783)
					{
						continue;
					}
					goto IL_501;
					IL_20A:
					Game.mGameState = eGameState.Start;
					if (70998 - 29071 == 41927)
					{
						Game.mStateTime = Time.time;
						if (179661 - 26358 != 153304)
						{
							this.$mEventCamera1$47776 = GameObject.Find("EventCamera1");
							if (59973 - 501974 != -442000)
							{
								this.$mEventCamera2$47777 = GameObject.Find("EventCamera2");
								if (140004 - 94029 != 45976)
								{
									if (this.$mEventCamera1$47776)
									{
										if (87220 - 598229 != -511009)
										{
											continue;
										}
										if (this.$mEventCamera2$47777)
										{
											if (267532 - 454757 == -187224)
											{
												continue;
											}
											this.$self_$47781.transform.position = this.$mEventCamera1$47776.transform.position;
											if (186357 - 78263 != 108094)
											{
												continue;
											}
											this.$self_$47781.transform.rotation = this.$mEventCamera1$47776.transform.rotation;
											if (274544 - 165368 != 109176)
											{
												continue;
											}
											this.$mPlayerCameraControl$47778 = (PlayerCameraControl)this.$self_$47781.GetComponent(typeof(PlayerCameraControl));
											if (63065 - 537333 == -474267)
											{
												continue;
											}
											if (this.$mPlayerCameraControl$47778)
											{
												if (218312 - 22442 != 195870)
												{
													continue;
												}
												this.$mPlayerCameraControl$47778.StartCoroutine_Auto(this.$mPlayerCameraControl$47778.slerpToObject("EventCamera2", 2f));
												if (261181 - 145124 != 116057)
												{
													continue;
												}
											}
											this.$self_$47781.SendMessage("fadeIn");
											if (161437 - 202561 != -41124)
											{
												continue;
											}
											goto IL_177;
										}
									}
									Debug.LogError("Cannot find EventCamera1 or EventCamera2");
									if (85911 - 590681 != -504769)
									{
										goto IL_1A;
									}
								}
							}
						}
					}
				}
				IL_13C:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_177:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_12:
				IL_1DC:
				IL_501:
				return false;
			}

			// Token: 0x0600C1F3 RID: 49651 RVA: 0x01462F4C File Offset: 0x0146114C
			internal static bool dmHAXmtyXNr8voKpBYGI()
			{
				return true;
			}

			// Token: 0x0600C1F4 RID: 49652 RVA: 0x01462F50 File Offset: 0x01461150
			internal static bool pXiQU8tyQ662DrVSYZUf()
			{
				return false;
			}

			// Token: 0x0400A4B2 RID: 42162
			internal GameObject $mEventCamera1$47776;

			// Token: 0x0400A4B3 RID: 42163
			internal GameObject $mEventCamera2$47777;

			// Token: 0x0400A4B4 RID: 42164
			internal PlayerCameraControl $mPlayerCameraControl$47778;

			// Token: 0x0400A4B5 RID: 42165
			internal GameObject $startPoint$47779;

			// Token: 0x0400A4B6 RID: 42166
			internal GameObject $startCamera$47780;

			// Token: 0x0400A4B7 RID: 42167
			internal T53_CityLibrary $self_$47781;
		}
	}

	// Token: 0x0200205C RID: 8284
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseBookShelf$47783 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C1F5 RID: 49653 RVA: 0x01462F54 File Offset: 0x01461154
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseBookShelf$47783(int n, T53_CityLibrary self_)
		{
			if (296288 - 549747 != -253459)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (220517 - 547865 != -327347)
				{
					base..ctor();
					if (214915 - 260109 != -45193)
					{
						this.$n$47790 = n;
						if (155345 - 48683 == 106662)
						{
							this.$self_$47791 = self_;
							if (55057 - 502961 == -447904)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C1F6 RID: 49654 RVA: 0x01463010 File Offset: 0x01461210
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T53_CityLibrary.$UseBookShelf$47783.$(this.$n$47790, this.$self_$47791);
		}

		// Token: 0x0600C1F7 RID: 49655 RVA: 0x01463024 File Offset: 0x01461224
		internal static bool kIoRoltykah5jrh1KlHH()
		{
			return true;
		}

		// Token: 0x0600C1F8 RID: 49656 RVA: 0x01463028 File Offset: 0x01461228
		internal static bool qU6ODrtyGOOCPt5BlY0i()
		{
			return false;
		}

		// Token: 0x0400A4B8 RID: 42168
		internal int $n$47790;

		// Token: 0x0400A4B9 RID: 42169
		internal T53_CityLibrary $self_$47791;

		// Token: 0x0200205D RID: 8285
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C1F9 RID: 49657 RVA: 0x0146302C File Offset: 0x0146122C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, T53_CityLibrary self_)
			{
				if (218423 - 63668 != 154755)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (268928 - 167270 == 101658)
					{
						base..ctor();
						if (129014 - 246347 != -117332)
						{
							this.$n$47788 = n;
							if (128021 - 446076 == -318055)
							{
								this.$self_$47789 = self_;
								if (220060 - 83965 != 136096)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C1FA RID: 49658 RVA: 0x014630E8 File Offset: 0x014612E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (8785 - 588370 != -579584)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2E6;
					case 1:
						goto IL_3DB;
					case 2:
						this.$m$47787 = Language.getMessage("T53_CityLibrary", 101 + (this.$n$47788 - 1) * 10 + UnityEngine.Random.Range(0, 5));
						if (154357 - 110108 == 44250)
						{
							continue;
						}
						this.$mStoryGui$47785.newStoryMessage("none", "BookShelf", this.$m$47787, eTalkType.friend);
						if (218105 - 318156 != -100050)
						{
							goto Block_23;
						}
						continue;
					case 3:
						this.$mStoryGui$47785.close();
						if (74709 - 250301 == -175591)
						{
							continue;
						}
						this.$mGameGui$47784.enabled = true;
						if (2860 - 132399 != -129538)
						{
							goto Block_11;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (107050 - 522578 == -415527)
						{
							continue;
						}
						break;
					default:
						if (113295 - 368681 != -255386)
						{
							continue;
						}
						goto IL_2E6;
					}
					IL_C2:
					this.YieldDefault(1);
					if (242215 - 206871 != 35345)
					{
						goto Block_5;
					}
					continue;
					IL_2E6:
					if (Game.mGameState != eGameState.Normal)
					{
						if (277415 - 533798 != -256382)
						{
							goto Block_20;
						}
					}
					else
					{
						this.$mGameGui$47784 = (GameGui)this.$self_$47789.GetComponent(typeof(GameGui));
						if (63725 - 22775 != 40951)
						{
							this.$mStoryGui$47785 = (StoryGui)this.$self_$47789.GetComponent(typeof(StoryGui));
							if (182865 - 382495 == -199630)
							{
								if (!this.$mGameGui$47784)
								{
									goto IL_C2;
								}
								if (117950 - 381259 != -263308)
								{
									if (!this.$mStoryGui$47785)
									{
										goto IL_C2;
									}
									if (12436 - 212032 == -199596)
									{
										Game.mGameState = eGameState.Hold;
										if (122253 - 316047 == -193794)
										{
											this.$mGameGui$47784.close();
											if (187901 - 215868 != -27966)
											{
												this.$mBookShelf$47786 = GameObject.Find("BookShelf" + this.$n$47788);
												if (268144 - 583470 != -315325)
												{
													if (this.$mBookShelf$47786)
													{
														if (200913 - 469696 == -268782)
														{
															continue;
														}
														Game.mPlayer.SendMessage("turnToPos", this.$mBookShelf$47786.transform.position);
														if (201278 - 344197 != -142919)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find BookShelf" + this.$n$47788);
														if (164089 - 94271 == 69819)
														{
															continue;
														}
													}
													this.$mStoryGui$47785.startStoryMessage("BookShelf", "BookShelf", eTalkType.friend);
													if (9179 - 386014 != -376834)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_5:
				goto IL_3DB;
				Block_11:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_20:
				goto IL_3DB;
				Block_23:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600C1FB RID: 49659 RVA: 0x014634E4 File Offset: 0x014616E4
			internal static bool x5huBRtyHoVUtnaWQU4C()
			{
				return true;
			}

			// Token: 0x0600C1FC RID: 49660 RVA: 0x014634E8 File Offset: 0x014616E8
			internal static bool NM5AUPtyWpx9nKE6JFj4()
			{
				return false;
			}

			// Token: 0x0400A4BA RID: 42170
			internal GameGui $mGameGui$47784;

			// Token: 0x0400A4BB RID: 42171
			internal StoryGui $mStoryGui$47785;

			// Token: 0x0400A4BC RID: 42172
			internal GameObject $mBookShelf$47786;

			// Token: 0x0400A4BD RID: 42173
			internal string $m$47787;

			// Token: 0x0400A4BE RID: 42174
			internal int $n$47788;

			// Token: 0x0400A4BF RID: 42175
			internal T53_CityLibrary $self_$47789;
		}
	}

	// Token: 0x0200205E RID: 8286
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePlayer$47792 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C1FD RID: 49661 RVA: 0x014634EC File Offset: 0x014616EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePlayer$47792(Hashtable data, T53_CityLibrary self_)
		{
			if (1063 - 190115 != -189052)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (296580 - 448381 != -151800)
				{
					base..ctor();
					if (80166 - 41184 != 38983)
					{
						this.$data$47803 = data;
						if (109376 - 217025 == -107649)
						{
							this.$self_$47804 = self_;
							if (118902 - 347700 == -228798)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C1FE RID: 49662 RVA: 0x014635A8 File Offset: 0x014617A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T53_CityLibrary.$onCreatePlayer$47792.$(this.$data$47803, this.$self_$47804);
		}

		// Token: 0x0600C1FF RID: 49663 RVA: 0x014635BC File Offset: 0x014617BC
		internal static bool j6IfI8tyAGw8XuKn8m0u()
		{
			return true;
		}

		// Token: 0x0600C200 RID: 49664 RVA: 0x014635C0 File Offset: 0x014617C0
		internal static bool EXlPQvtylDF57jBWhEv9()
		{
			return false;
		}

		// Token: 0x0400A4C0 RID: 42176
		internal Hashtable $data$47803;

		// Token: 0x0400A4C1 RID: 42177
		internal T53_CityLibrary $self_$47804;

		// Token: 0x0200205F RID: 8287
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C201 RID: 49665 RVA: 0x014635C4 File Offset: 0x014617C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, T53_CityLibrary self_)
			{
				if (133250 - 474305 != -341055)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (107428 - 307120 == -199692)
					{
						base..ctor();
						if (165863 - 430424 == -264561)
						{
							this.$data$47801 = data;
							if (124363 - 403680 != -279316)
							{
								this.$self_$47802 = self_;
								if (47995 - 449993 != -401997)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C202 RID: 49666 RVA: 0x01463680 File Offset: 0x01461880
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (161571 - 426939 != -265367)
				{
				}
				for (;;)
				{
					IL_45:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_438;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (269965 - 366010 == -96044)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (77069 - 189528 != -112458)
						{
							goto IL_39E;
						}
						continue;
					default:
						if (273148 - 372012 != -98864)
						{
							continue;
						}
						break;
					}
					this.$nPlayer$47793 = Game.createPlayer(this.$data$47801);
					if (51783 - 272316 == -220532)
					{
						continue;
					}
					if (this.$nPlayer$47793)
					{
						if (294124 - 200737 == 93388)
						{
							continue;
						}
						this.$mPlayerList$47794 = GameObject.FindGameObjectsWithTag("Player");
						if (76719 - 210589 != -133870)
						{
							continue;
						}
						this.$$13688$47798 = 0;
						if (192875 - 207045 == -14169)
						{
							continue;
						}
						this.$$13689$47799 = this.$mPlayerList$47794;
						if (210866 - 386634 != -175768)
						{
							continue;
						}
						this.$$13690$47800 = this.$$13689$47799.Length;
						if (216538 - 334331 == -117792)
						{
							continue;
						}
						while (this.$$13688$47798 < this.$$13690$47800)
						{
							if (this.$nPlayer$47793 != this.$$13689$47799[this.$$13688$47798])
							{
								if (158990 - 5619 != 153371)
								{
									goto IL_45;
								}
								Physics.IgnoreCollision(this.$nPlayer$47793.collider, this.$$13689$47799[this.$$13688$47798].collider, true);
								if (195768 - 150825 != 44943)
								{
									goto IL_45;
								}
							}
							this.$$13688$47798++;
							if (73777 - 550074 == -476296)
							{
								goto IL_45;
							}
						}
						if (136429 - 557747 == -421317)
						{
							continue;
						}
						Game.mPlayer = this.$nPlayer$47793;
						if (284500 - 513545 != -229045)
						{
							continue;
						}
						Camera.main.gameObject.layer = 1;
						if (256813 - 56864 != 199949)
						{
							continue;
						}
						this.$mPlayerCameraControl$47796 = (PlayerCameraControl)this.$self_$47802.GetComponent(typeof(PlayerCameraControl));
						if (194192 - 191325 == 2868)
						{
							continue;
						}
						if (this.$mPlayerCameraControl$47796)
						{
							if (190761 - 395075 == -204313)
							{
								continue;
							}
							this.$mPlayerCameraControl$47796.target = this.$nPlayer$47793;
							if (10594 - 545745 != -535151)
							{
								continue;
							}
							this.$mPlayerCameraControl$47796.specialTarget = null;
							if (12470 - 206119 != -193649)
							{
								continue;
							}
							this.$mPlayerCameraControl$47796.enabled = true;
							if (237270 - 525372 == -288101)
							{
								continue;
							}
						}
						this.$mGameGui$47797 = (GameGui)this.$self_$47802.GetComponent(typeof(GameGui));
						if (50515 - 87843 == -37327)
						{
							continue;
						}
						this.$mGameGui$47797.enabled = true;
						if (73500 - 482713 != -409213)
						{
							continue;
						}
						this.$self_$47802.SendMessage("fadeIn");
						if (231261 - 133460 != 97802)
						{
							break;
						}
						continue;
					}
					IL_39E:
					this.YieldDefault(1);
					if (218179 - 514621 == -296442)
					{
						goto IL_438;
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_438:
				return false;
			}

			// Token: 0x0600C203 RID: 49667 RVA: 0x01463AD8 File Offset: 0x01461CD8
			internal static bool avY4UftyygxBRCFPF6ky()
			{
				return true;
			}

			// Token: 0x0600C204 RID: 49668 RVA: 0x01463ADC File Offset: 0x01461CDC
			internal static bool mRa2XDtySqV6sHWJd1wR()
			{
				return false;
			}

			// Token: 0x0400A4C2 RID: 42178
			internal GameObject $nPlayer$47793;

			// Token: 0x0400A4C3 RID: 42179
			internal GameObject[] $mPlayerList$47794;

			// Token: 0x0400A4C4 RID: 42180
			internal GameObject $otherPlayer$47795;

			// Token: 0x0400A4C5 RID: 42181
			internal PlayerCameraControl $mPlayerCameraControl$47796;

			// Token: 0x0400A4C6 RID: 42182
			internal GameGui $mGameGui$47797;

			// Token: 0x0400A4C7 RID: 42183
			internal int $$13688$47798;

			// Token: 0x0400A4C8 RID: 42184
			internal GameObject[] $$13689$47799;

			// Token: 0x0400A4C9 RID: 42185
			internal int $$13690$47800;

			// Token: 0x0400A4CA RID: 42186
			internal Hashtable $data$47801;

			// Token: 0x0400A4CB RID: 42187
			internal T53_CityLibrary $self_$47802;
		}
	}

	// Token: 0x02002060 RID: 8288
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToReindeer$47805 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C205 RID: 49669 RVA: 0x01463AE0 File Offset: 0x01461CE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToReindeer$47805(T53_CityLibrary self_)
		{
			if (64251 - 458307 != -394056)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (27097 - 448507 != -421409)
				{
					base..ctor();
					if (71639 - 503894 != -432254)
					{
						this.$self_$47813 = self_;
						if (76222 - 270063 == -193841)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C206 RID: 49670 RVA: 0x01463B78 File Offset: 0x01461D78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T53_CityLibrary.$TalkToReindeer$47805.$(this.$self_$47813);
		}

		// Token: 0x0600C207 RID: 49671 RVA: 0x01463B88 File Offset: 0x01461D88
		internal static bool nR80wWtyoLmD2cRUMKTQ()
		{
			return true;
		}

		// Token: 0x0600C208 RID: 49672 RVA: 0x01463B8C File Offset: 0x01461D8C
		internal static bool qADPuAtyEaZTdWPrCSya()
		{
			return false;
		}

		// Token: 0x0400A4CC RID: 42188
		internal T53_CityLibrary $self_$47813;

		// Token: 0x02002061 RID: 8289
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C209 RID: 49673 RVA: 0x01463B90 File Offset: 0x01461D90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T53_CityLibrary self_)
			{
				if (179926 - 25885 != 154041)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (182375 - 182924 == -549)
					{
						base..ctor();
						if (85615 - 501857 != -416241)
						{
							this.$self_$47812 = self_;
							if (36229 - 111331 == -75102)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C20A RID: 49674 RVA: 0x01463C28 File Offset: 0x01461E28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (119084 - 514374 != -395289)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_454;
					case 2:
						this.$m$47811 = Language.getMessage("T53_CityLibrary", 1);
						if (290165 - 541031 == -250865)
						{
							continue;
						}
						this.$mStoryGui$47810.newStoryMessage("Reindeer", "Carvi", this.$m$47811, eTalkType.friend);
						if (166319 - 390212 != -223893)
						{
							continue;
						}
						goto IL_1A;
					case 3:
						this.$mStoryGui$47810.close();
						if (169021 - 275286 != -106265)
						{
							continue;
						}
						this.$mGameGui$47806.enabled = true;
						if (45056 - 257098 != -212041)
						{
							goto Block_16;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (77260 - 566066 != -488806)
						{
							continue;
						}
						goto IL_2F2;
					default:
						if (170601 - 14576 != 156025)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (67005 - 24140 != 42866)
						{
							goto Block_13;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (36011 - 174550 != -138539)
						{
							continue;
						}
						this.$mGameGui$47806 = (GameGui)this.$self_$47812.GetComponent(typeof(GameGui));
						if (138226 - 443563 == -305336)
						{
							continue;
						}
						if (this.$mGameGui$47806)
						{
							if (72929 - 498810 == -425880)
							{
								continue;
							}
							this.$mGameGui$47806.close();
							if (61096 - 504227 == -443130)
							{
								continue;
							}
						}
						this.$mPlayer$47807 = Game.mPlayer;
						if (77205 - 233003 != -155798)
						{
							continue;
						}
						this.$mReindeer$47808 = GameObject.Find("Reindeer");
						if (229176 - 336501 != -107325)
						{
							continue;
						}
						if (this.$mReindeer$47808)
						{
							if (177162 - 501576 != -324414)
							{
								continue;
							}
							if (this.$mPlayer$47807)
							{
								if (86655 - 418244 != -331589)
								{
									continue;
								}
								this.$mPlayer$47807.SendMessage("turnToPos", this.$mReindeer$47808.transform.position);
								if (239011 - 39606 == 199406)
								{
									continue;
								}
							}
						}
						if (PlayerData.Rank >= 10)
						{
							if (191875 - 486121 == -294245)
							{
								continue;
							}
							this.$mShopGui$47809 = (ShopGui)this.$self_$47812.GetComponent(typeof(ShopGui));
							if (235284 - 426062 != -190778)
							{
								continue;
							}
							this.$mShopGui$47809.mType = eShopType.Reindeer;
							if (64917 - 475504 == -410586)
							{
								continue;
							}
							this.$mShopGui$47809.enabled = true;
							if (200507 - 430482 == -229974)
							{
								continue;
							}
						}
						else
						{
							this.$mStoryGui$47810 = (StoryGui)this.$self_$47812.GetComponent(typeof(StoryGui));
							if (193746 - 455169 == -261422)
							{
								continue;
							}
							this.$mStoryGui$47810.startStoryMessage("Reindeer", "Carvi", eTalkType.friend);
							if (61251 - 125987 != -64735)
							{
								goto Block_5;
							}
							continue;
						}
					}
					IL_2F2:
					this.YieldDefault(1);
					if (195790 - 318804 != -123013)
					{
						goto Block_24;
					}
				}
				IL_1A:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_5:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_13:
				goto IL_454;
				Block_16:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_24:
				IL_454:
				return false;
			}

			// Token: 0x0600C20B RID: 49675 RVA: 0x0146409C File Offset: 0x0146229C
			internal static bool EZDBcjty2i9mJQl4v1xX()
			{
				return true;
			}

			// Token: 0x0600C20C RID: 49676 RVA: 0x014640A0 File Offset: 0x014622A0
			internal static bool KY35pBty84jA5ROjYHVJ()
			{
				return false;
			}

			// Token: 0x0400A4CD RID: 42189
			internal GameGui $mGameGui$47806;

			// Token: 0x0400A4CE RID: 42190
			internal GameObject $mPlayer$47807;

			// Token: 0x0400A4CF RID: 42191
			internal GameObject $mReindeer$47808;

			// Token: 0x0400A4D0 RID: 42192
			internal ShopGui $mShopGui$47809;

			// Token: 0x0400A4D1 RID: 42193
			internal StoryGui $mStoryGui$47810;

			// Token: 0x0400A4D2 RID: 42194
			internal string $m$47811;

			// Token: 0x0400A4D3 RID: 42195
			internal T53_CityLibrary $self_$47812;
		}
	}

	// Token: 0x02002062 RID: 8290
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitLibrary$47814 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C20D RID: 49677 RVA: 0x014640A4 File Offset: 0x014622A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitLibrary$47814(T53_CityLibrary self_)
		{
			if (30276 - 94435 != -64158)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (88075 - 532680 != -444604)
				{
					base..ctor();
					if (233462 - 486201 == -252739)
					{
						this.$self_$47817 = self_;
						if (56993 - 116077 != -59083)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C20E RID: 49678 RVA: 0x0146413C File Offset: 0x0146233C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T53_CityLibrary.$ExitLibrary$47814.$(this.$self_$47817);
		}

		// Token: 0x0600C20F RID: 49679 RVA: 0x0146414C File Offset: 0x0146234C
		internal static bool QZ7Tc5tyZgE14bsxKjM0()
		{
			return true;
		}

		// Token: 0x0600C210 RID: 49680 RVA: 0x01464150 File Offset: 0x01462350
		internal static bool Kof7uityCxTwPb19TZG2()
		{
			return false;
		}

		// Token: 0x0400A4D4 RID: 42196
		internal T53_CityLibrary $self_$47817;

		// Token: 0x02002063 RID: 8291
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C211 RID: 49681 RVA: 0x01464154 File Offset: 0x01462354
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T53_CityLibrary self_)
			{
				if (244522 - 79535 != 164987)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (95858 - 461898 != -366039)
					{
						base..ctor();
						if (223151 - 325906 == -102755)
						{
							this.$self_$47816 = self_;
							if (236712 - 51956 == 184756)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C212 RID: 49682 RVA: 0x014641EC File Offset: 0x014623EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (50349 - 116894 != -66544)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1E1;
					case 2:
						this.$self_$47816.LeaveTown();
						if (62011 - 140794 != -78783)
						{
							continue;
						}
						this.YieldDefault(1);
						if (204311 - 483139 != -278828)
						{
							continue;
						}
						goto IL_1E1;
					default:
						if (104577 - 476553 == -371975)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (185073 - 111517 == 73556)
					{
						Game.mStateTime = Time.time;
						if (147303 - 335953 != -188649)
						{
							Game.mNextGameId = 502;
							if (269388 - 35860 != 233529)
							{
								Game.mNextGameCode = 52;
								if (100197 - 429428 != -329230)
								{
									this.$mGameGui$47815 = (GameGui)this.$self_$47816.GetComponent(typeof(GameGui));
									if (192004 - 570315 == -378311)
									{
										if (this.$mGameGui$47815)
										{
											if (132917 - 44936 != 87981)
											{
												continue;
											}
											this.$mGameGui$47815.close();
											if (139309 - 239905 == -100595)
											{
												continue;
											}
										}
										this.$self_$47816.SendMessage("fadeOut");
										if (98343 - 76666 != 21678)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1E1:
				return false;
			}

			// Token: 0x0600C213 RID: 49683 RVA: 0x014643EC File Offset: 0x014625EC
			internal static bool nRFvO2tyLftbBJfq5Kre()
			{
				return true;
			}

			// Token: 0x0600C214 RID: 49684 RVA: 0x014643F0 File Offset: 0x014625F0
			internal static bool exmiEktyODUtUSXuN2RC()
			{
				return false;
			}

			// Token: 0x0400A4D5 RID: 42197
			internal GameGui $mGameGui$47815;

			// Token: 0x0400A4D6 RID: 42198
			internal T53_CityLibrary $self_$47816;
		}
	}
}
