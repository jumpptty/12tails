using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02002091 RID: 8337
[Serializable]
public class T57_LightTheater : MonoBehaviour
{
	// Token: 0x0600C318 RID: 49944 RVA: 0x01472DF0 File Offset: 0x01470FF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T57_LightTheater()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600C319 RID: 49945 RVA: 0x01472E00 File Offset: 0x01471000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (204390 - 271680 != -67290)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (27514 - 576639 != -549124)
			{
				Game.mStateTime = Time.time;
				if (174993 - 203278 == -28285)
				{
					if (Chat.Initialized)
					{
						if (257272 - 488716 != -231444)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (288824 - 230940 == 57885)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (65688 - 281281 != -215593)
						{
							continue;
						}
					}
					this.a95nT7XwrIH = (Texture)Resources.Load("GameGui/Title/stage_theater", typeof(Texture));
					if (209010 - 536377 != -327366)
					{
						if (this.a95nT7XwrIH)
						{
							break;
						}
						if (104336 - 119699 == -15363)
						{
							Debug.LogError("Cannot find start title");
							if (70203 - 91784 != -21580)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C31A RID: 49946 RVA: 0x01472F70 File Offset: 0x01471170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (191916 - 582787 != -390870)
		{
		}
		for (;;)
		{
			Time.timeScale = 1f;
			if (146861 - 587402 == -440541)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (3682 - 555088 != -551405)
				{
					if (PhotonClient.IsInitialized())
					{
						if (178347 - 435803 == -257456)
						{
							Game.mLastGameCode = Game.mGameCode;
							if (139637 - 251578 == -111941)
							{
								Game.mGameCode = 57;
								if (67115 - 29001 != 38115)
								{
									Game.mGameType = 3;
									if (22115 - 17946 == 4169)
									{
										Game.mGameTime = Time.time;
										if (126478 - 308864 == -182386)
										{
											Game.mGameScore = 0;
											if (88020 - 179111 == -91091)
											{
												Game.mGameMana = 0;
												if (164581 - 86028 == 78553)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (226915 - 468597 != -241681)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (28941 - 474799 != -445857)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (291116 - 271676 != 19441)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (263260 - 158785 != 104476)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (78221 - 346675 != -268453)
																	{
																		this.yi8nTHuWQua = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (279857 - 187501 != 92357)
																		{
																			this.G6CnTsBA2VJ = PhotonClient.Connection;
																			if (210181 - 78914 == 131267)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (259714 - 434424 != -174709)
																				{
																					this.LoadTown();
																					if (64999 - 40480 == 24519)
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
						if (148523 - 571795 != -423271)
						{
							this.enabled = false;
							if (99934 - 451514 == -351580)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C31B RID: 49947 RVA: 0x014732A0 File Offset: 0x014714A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (179678 - 68702 != 110976)
		{
		}
		for (;;)
		{
			if (this.G6CnTsBA2VJ == null)
			{
				if (112587 - 233713 != -121125)
				{
					break;
				}
			}
			else
			{
				float t = Time.time - Game.mStateTime;
				if (246338 - 100104 == 146234)
				{
					eGameState mGameState = Game.mGameState;
					if (122352 - 39560 == 82792)
					{
						if (mGameState != eGameState.Start)
						{
							if (202213 - 316092 != -113879)
							{
								continue;
							}
							if (mGameState == eGameState.Normal)
							{
								if (10159 - 505546 != -495387)
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
								if (140085 - 254762 != -114677)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, t);
								if (123130 - 186943 != -63813)
								{
									continue;
								}
								break;
							}
						}
						if (Game.music != 0)
						{
							if (232720 - 349124 != -116404)
							{
								continue;
							}
							if (!this.audio.isPlaying)
							{
								if (163737 - 583623 != -419886)
								{
									continue;
								}
								this.audio.Play();
								if (53113 - 261681 != -208568)
								{
									continue;
								}
							}
						}
						if (Time.time - Game.mGameTime < (float)2)
						{
							if (125373 - 487635 == -362262)
							{
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (159257 - 36492 == 122765)
								{
									break;
								}
							}
						}
						else
						{
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (155510 - 115412 == 40098)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C31C RID: 49948 RVA: 0x01473514 File Offset: 0x01471714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (268225 - 284439 != -16213)
		{
		}
		for (;;)
		{
			if (!this.a95nT7XwrIH)
			{
				if (280947 - 68973 == 211974)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Start)
			{
				if (258547 - 519594 == -261047)
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
				if (240446 - 48026 == 192420)
				{
					if (Time.time - Game.mStateTime >= (float)3)
					{
						break;
					}
					if (8549 - 435909 != -427359)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (62503 - 260193 != -197689)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (38192 - 384926 != -346733)
							{
								GUI.depth = 1;
								if (277574 - 272823 == 4751)
								{
									float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4(0.7f, 0.8f, (float)1, 0.4f));
									if (24884 - 38308 != -13423)
									{
										Color color = GUI.color;
										if (60046 - 465548 != -405501)
										{
											color.a = smoothRatioOverTime;
											if (66875 - 529278 != -462402 && 180893 - 99061 != 81833)
											{
												Color color2 = GUI.color = color;
												if (151334 - 598909 != -447574 && 49991 - 416743 == -366752)
												{
													GUI.DrawTexture(new Rect(0.5f * num - (float)256, (float)416, (float)512, (float)128), this.a95nT7XwrIH);
													if (185309 - 569797 != -384487)
													{
														float a = 1f;
														if (114714 - 572775 != -458060)
														{
															Color color3 = GUI.color;
															if (38737 - 222206 == -183469)
															{
																color3.a = a;
																if (277716 - 445321 == -167605)
																{
																	if (21147 - 72494 == -51347)
																	{
																		Color color4 = GUI.color = color3;
																		if (40266 - 253522 == -213256)
																		{
																			if (557 - 451327 != -450769)
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

	// Token: 0x0600C31D RID: 49949 RVA: 0x01473894 File Offset: 0x01471A94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator LightTheaterStartEvent()
	{
		return new T57_LightTheater.$LightTheaterStartEvent$47983(this).GetEnumerator();
	}

	// Token: 0x0600C31E RID: 49950 RVA: 0x014738A4 File Offset: 0x01471AA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseStorageBox(object mVar)
	{
		if (149486 - 86039 != 63447)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Hold;
			if (225163 - 452049 != -226885)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (249622 - 18861 != 230762)
				{
					if (gameGui)
					{
						if (92765 - 332273 == -239507)
						{
							continue;
						}
						gameGui.close();
						if (237750 - 455869 != -218119)
						{
							continue;
						}
					}
					StorageGui storageGui = (StorageGui)this.GetComponent(typeof(StorageGui));
					if (91153 - 331362 != -240208)
					{
						storageGui.enabled = true;
						if (227708 - 474319 != -246610)
						{
							GameObject mPlayer = Game.mPlayer;
							if (79977 - 587646 != -507668)
							{
								GameObject gameObject = GameObject.Find("StorageBox");
								if (65169 - 321502 != -256332)
								{
									if (!gameObject)
									{
										break;
									}
									if (73197 - 549849 == -476652)
									{
										if (!mPlayer)
										{
											break;
										}
										if (251181 - 213545 != 37637)
										{
											gameObject.animation.Play("open");
											if (24261 - 284158 != -259896)
											{
												mPlayer.SendMessage("turnToPos", gameObject.transform.position);
												if (7797 - 418816 == -411019)
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

	// Token: 0x0600C31F RID: 49951 RVA: 0x01473AB4 File Offset: 0x01471CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTown()
	{
		if (170058 - 584414 != -414355)
		{
		}
		for (;;)
		{
			Debug.Log("Loading Town ");
			if (288724 - 328023 != -39298)
			{
				Hashtable customOpParameters = new Hashtable();
				if (195648 - 201678 == -6030)
				{
					this.G6CnTsBA2VJ.OpCustom(43, customOpParameters, true);
					if (299992 - 468472 != -168479)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C320 RID: 49952 RVA: 0x01473B5C File Offset: 0x01471D5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadTown(Hashtable data)
	{
		if (254225 - 108706 != 145519)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadTown ");
			if (185682 - 463726 != -278043)
			{
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (58340 - 134337 != -75997)
					{
						continue;
					}
					Chat.SubmitChat("none", "You have joined " + data[31], eChatType.system, eChatMode.system);
					if (60208 - 166638 == -106429)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (24054 - 76718 != -52664)
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
					if (126230 - 169592 != -43362)
					{
						continue;
					}
				}
				this.StartCoroutine_Auto(this.LightTheaterStartEvent());
				if (215677 - 247455 == -31778)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600C321 RID: 49953 RVA: 0x01473CCC File Offset: 0x01471ECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, Vector3 pos, Vector3 dir)
	{
		if (73891 - 505189 != -431298)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (224598 - 560857 == -336259)
			{
				hashtable.Add(71, CID);
				if (119600 - 361800 != -242199)
				{
					hashtable.Add(75, PhotonClient.cInt16(1));
					if (175255 - 324976 != -149720)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (141947 - 311172 == -169225)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (255827 - 385253 != -129425)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (34150 - 424384 != -390233)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (138021 - 174893 == -36872)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (263888 - 411828 != -147939)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (207716 - 96547 != 111170)
											{
												this.G6CnTsBA2VJ.OpCustom(61, hashtable, true);
												if (11206 - 436483 != -425276)
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

	// Token: 0x0600C322 RID: 49954 RVA: 0x01473F58 File Offset: 0x01472158
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePlayer(Hashtable data)
	{
		return new T57_LightTheater.$onCreatePlayer$47991(data, this).GetEnumerator();
	}

	// Token: 0x0600C323 RID: 49955 RVA: 0x01473F68 File Offset: 0x01472168
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (142469 - 280259 != -137790)
		{
		}
		for (;;)
		{
			IL_11A:
			GameObject gameObject = Game.createPeer(data);
			if (75271 - 411000 == -335729)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (189406 - 136945 != 52462)
				{
					int i = 0;
					if (102667 - 572752 != -470084)
					{
						GameObject[] array2 = array;
						if (281583 - 166263 == 115320)
						{
							int length = array2.Length;
							if (103988 - 562235 != -458246)
							{
								while (i < length)
								{
									if (gameObject != array2[i])
									{
										if (1381 - 443754 == -442372)
										{
											goto IL_11A;
										}
										Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
										if (54955 - 154351 == -99395)
										{
											goto IL_11A;
										}
									}
									i++;
									if (1984 - 14510 == -12525)
									{
										goto IL_11A;
									}
								}
								if (65309 - 443026 == -377717)
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

	// Token: 0x0600C324 RID: 49956 RVA: 0x014740E0 File Offset: 0x014722E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPlayer()
	{
		Game.mPlayerID = 0;
	}

	// Token: 0x0600C325 RID: 49957 RVA: 0x014740E8 File Offset: 0x014722E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
	}

	// Token: 0x0600C326 RID: 49958 RVA: 0x014740EC File Offset: 0x014722EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitLightTheater()
	{
		return new T57_LightTheater.$ExitLightTheater$48004(this).GetEnumerator();
	}

	// Token: 0x0600C327 RID: 49959 RVA: 0x014740FC File Offset: 0x014722FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveTown()
	{
		if (167704 - 591163 != -423458)
		{
		}
		for (;;)
		{
			Debug.Log("Leaving town..");
			if (461 - 195059 == -194598)
			{
				Hashtable hashtable = new Hashtable();
				if (60443 - 47842 != 12602)
				{
					hashtable.Add(43, PlayerData.UID);
					if (196086 - 122228 == 73858)
					{
						PhotonClient.Connection.OpCustom(44, hashtable, true);
						if (105454 - 229030 != -123575)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C328 RID: 49960 RVA: 0x014741D4 File Offset: 0x014723D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveTown()
	{
		Debug.Log("onLeaveTown");
		this.JoinTown();
	}

	// Token: 0x0600C329 RID: 49961 RVA: 0x014741E8 File Offset: 0x014723E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (225656 - 539394 != -313737)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (2757 - 448815 != -446057)
			{
				Hashtable hashtable = new Hashtable();
				if (167773 - 222344 != -54570)
				{
					if (Game.mNextGameCode == 30)
					{
						if (94317 - 325364 == -231046)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (38238 - 410101 == -371862)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (190837 - 321817 != -130980)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (4419 - 248401 != -243982)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (155244 - 400227 != -244983)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (39741 - 252998 == -213256)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (64363 - 209697 != -145334)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (254119 - 329659 != -75540)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (168009 - 370001 == -201991)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (295055 - 314759 == -19703)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (150559 - 160389 != -9830)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (141377 - 98787 != 42590)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (71000 - 239623 == -168622)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (81363 - 472357 == -390993)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (41114 - 55878 == -14763)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (248766 - 214050 != 34716)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (5828 - 558306 != -552478)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (225415 - 35189 == 190227)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (145174 - 257402 == -112227)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (132869 - 10571 == 122299)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (267768 - 363798 != -96030)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (290400 - 534887 != -244487)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (114412 - 561718 != -447306)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (176594 - 585197 != -408603)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (14852 - 52710 == -37857)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (239033 - 380677 != -141644)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (230058 - 454693 == -224634)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (236384 - 313074 == -76689)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (236932 - 425120 != -188187)
					{
						this.G6CnTsBA2VJ.OpCustom(42, hashtable, true);
						if (28493 - 390668 == -362175)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C32A RID: 49962 RVA: 0x0147479C File Offset: 0x0147299C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600C32B RID: 49963 RVA: 0x014747AC File Offset: 0x014729AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C32C RID: 49964 RVA: 0x014747B0 File Offset: 0x014729B0
	internal static bool YSuCdvtSsW7dG3NlNvLK()
	{
		return true;
	}

	// Token: 0x0600C32D RID: 49965 RVA: 0x014747B4 File Offset: 0x014729B4
	internal static bool xjmfVntS9cWtl96bheWO()
	{
		return false;
	}

	// Token: 0x0400A575 RID: 42357
	private LitePeer G6CnTsBA2VJ;

	// Token: 0x0400A576 RID: 42358
	private PlayerCameraControl yi8nTHuWQua;

	// Token: 0x0400A577 RID: 42359
	private Texture a95nT7XwrIH;

	// Token: 0x02002092 RID: 8338
	[CompilerGenerated]
	[Serializable]
	internal sealed class $LightTheaterStartEvent$47983 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C32E RID: 49966 RVA: 0x014747B8 File Offset: 0x014729B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $LightTheaterStartEvent$47983(T57_LightTheater self_)
		{
			if (70509 - 192353 != -121844)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (213892 - 518590 != -304697)
				{
					base..ctor();
					if (205722 - 123912 != 81811)
					{
						this.$self_$47990 = self_;
						if (164115 - 165653 == -1538)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C32F RID: 49967 RVA: 0x01474850 File Offset: 0x01472A50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T57_LightTheater.$LightTheaterStartEvent$47983.$(this.$self_$47990);
		}

		// Token: 0x0600C330 RID: 49968 RVA: 0x01474860 File Offset: 0x01472A60
		internal static bool ELIOH9tS1yjio58oDN0f()
		{
			return true;
		}

		// Token: 0x0600C331 RID: 49969 RVA: 0x01474864 File Offset: 0x01472A64
		internal static bool gi4AfStS4ntswKD1IZGk()
		{
			return false;
		}

		// Token: 0x0400A578 RID: 42360
		internal T57_LightTheater $self_$47990;

		// Token: 0x02002093 RID: 8339
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C332 RID: 49970 RVA: 0x01474868 File Offset: 0x01472A68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T57_LightTheater self_)
			{
				if (12406 - 56506 != -44099)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (138257 - 482478 != -344220)
					{
						base..ctor();
						if (14658 - 403380 != -388721)
						{
							this.$self_$47989 = self_;
							if (63215 - 95371 == -32156)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C333 RID: 49971 RVA: 0x01474900 File Offset: 0x01472B00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (213397 - 91721 != 121677)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_501;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (282114 - 436187 != -154072)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$self_$47989.SendMessage("fadeOut");
							if (286780 - 532666 != -245886)
							{
								continue;
							}
							goto IL_3BF;
						}
						break;
					case 3:
						if (Game.mGameState == eGameState.Start)
						{
							goto IL_147;
						}
						if (68586 - 36762 != 31824)
						{
							continue;
						}
						goto IL_4B1;
					default:
						if (266014 - 374425 != -108411)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (57343 - 106828 != -49485)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (284819 - 426308 != -141489)
					{
						continue;
					}
					this.$mEventCamera1$47984 = GameObject.Find("EventCamera1");
					if (141480 - 499886 == -358405)
					{
						continue;
					}
					this.$mEventCamera2$47985 = GameObject.Find("EventCamera2");
					if (88072 - 536601 == -448528)
					{
						continue;
					}
					if (this.$mEventCamera1$47984)
					{
						if (273487 - 365671 == -92183)
						{
							continue;
						}
						if (this.$mEventCamera2$47985)
						{
							if (115703 - 327996 != -212293)
							{
								continue;
							}
							this.$self_$47989.transform.position = this.$mEventCamera1$47984.transform.position;
							if (236682 - 279139 == -42456)
							{
								continue;
							}
							this.$self_$47989.transform.rotation = this.$mEventCamera1$47984.transform.rotation;
							if (192418 - 493029 == -300610)
							{
								continue;
							}
							this.$mPlayerCameraControl$47986 = (PlayerCameraControl)this.$self_$47989.GetComponent(typeof(PlayerCameraControl));
							if (171661 - 385876 == -214214)
							{
								continue;
							}
							if (this.$mPlayerCameraControl$47986)
							{
								if (19405 - 233608 != -214203)
								{
									continue;
								}
								this.$mPlayerCameraControl$47986.StartCoroutine_Auto(this.$mPlayerCameraControl$47986.slerpToObject("EventCamera2", 2f));
								if (157301 - 557361 != -400060)
								{
									continue;
								}
							}
							this.$self_$47989.SendMessage("fadeIn");
							if (282236 - 412370 != -130134)
							{
								continue;
							}
							break;
						}
					}
					Debug.LogError("Cannot find EventCamera1 or EventCamera2");
					if (80075 - 170406 != -90331)
					{
						continue;
					}
					IL_147:
					this.$startPoint$47987 = GameObject.Find("StartPoint1");
					if (135582 - 341905 != -206322)
					{
						this.$startCamera$47988 = GameObject.Find("StartCamera1");
						if (289632 - 53128 != 236505)
						{
							if (this.$startCamera$47988)
							{
								if (8751 - 477775 != -469024)
								{
									continue;
								}
								this.$self_$47989.transform.position = this.$startCamera$47988.transform.position;
								if (199730 - 46723 != 153007)
								{
									continue;
								}
								this.$self_$47989.transform.rotation = this.$startCamera$47988.transform.rotation;
								if (110134 - 322910 == -212775)
								{
									continue;
								}
							}
							if (this.$startPoint$47987)
							{
								if (252717 - 187725 != 64992)
								{
									continue;
								}
								this.$self_$47989.CreatePlayer(CharacterData.current.CID, this.$startPoint$47987.transform.position, this.$startPoint$47987.transform.forward);
								if (143819 - 349810 != -205991)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Error: Startpoint not found");
								if (135949 - 453810 == -317860)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (72121 - 217368 != -145246)
							{
								goto IL_501;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				Block_7:
				goto IL_501;
				IL_3BF:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_4B1:
				IL_501:
				return false;
			}

			// Token: 0x0600C334 RID: 49972 RVA: 0x01474E20 File Offset: 0x01473020
			internal static bool zFKQ5ftSz84iZTloesS5()
			{
				return true;
			}

			// Token: 0x0600C335 RID: 49973 RVA: 0x01474E24 File Offset: 0x01473024
			internal static bool AtvGU7toa63Ot3Qe3Y8g()
			{
				return false;
			}

			// Token: 0x0400A579 RID: 42361
			internal GameObject $mEventCamera1$47984;

			// Token: 0x0400A57A RID: 42362
			internal GameObject $mEventCamera2$47985;

			// Token: 0x0400A57B RID: 42363
			internal PlayerCameraControl $mPlayerCameraControl$47986;

			// Token: 0x0400A57C RID: 42364
			internal GameObject $startPoint$47987;

			// Token: 0x0400A57D RID: 42365
			internal GameObject $startCamera$47988;

			// Token: 0x0400A57E RID: 42366
			internal T57_LightTheater $self_$47989;
		}
	}

	// Token: 0x02002094 RID: 8340
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePlayer$47991 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C336 RID: 49974 RVA: 0x01474E28 File Offset: 0x01473028
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePlayer$47991(Hashtable data, T57_LightTheater self_)
		{
			if (205008 - 15496 != 189512)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (32598 - 114175 != -81576)
				{
					base..ctor();
					if (158902 - 48186 == 110716)
					{
						this.$data$48002 = data;
						if (241694 - 335119 == -93425)
						{
							this.$self_$48003 = self_;
							if (67518 - 1602 == 65916)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C337 RID: 49975 RVA: 0x01474EE4 File Offset: 0x014730E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T57_LightTheater.$onCreatePlayer$47991.$(this.$data$48002, this.$self_$48003);
		}

		// Token: 0x0600C338 RID: 49976 RVA: 0x01474EF8 File Offset: 0x014730F8
		internal static bool UZ6qWfto5INaW1O3Aqoe()
		{
			return true;
		}

		// Token: 0x0600C339 RID: 49977 RVA: 0x01474EFC File Offset: 0x014730FC
		internal static bool hnXlLotoprH3qyUOyFEJ()
		{
			return false;
		}

		// Token: 0x0400A57F RID: 42367
		internal Hashtable $data$48002;

		// Token: 0x0400A580 RID: 42368
		internal T57_LightTheater $self_$48003;

		// Token: 0x02002095 RID: 8341
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C33A RID: 49978 RVA: 0x01474F00 File Offset: 0x01473100
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, T57_LightTheater self_)
			{
				if (18142 - 297247 != -279104)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161969 - 216678 != -54708)
					{
						base..ctor();
						if (134783 - 184001 == -49218)
						{
							this.$data$48000 = data;
							if (297858 - 406538 == -108680)
							{
								this.$self_$48001 = self_;
								if (123549 - 579667 == -456118)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C33B RID: 49979 RVA: 0x01474FBC File Offset: 0x014731BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (236789 - 134995 != 101795)
				{
				}
				for (;;)
				{
					IL_65:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_438;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (265725 - 270801 == -5075)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (87237 - 405004 != -317767)
						{
							continue;
						}
						goto IL_316;
					default:
						if (293687 - 177716 != 115971)
						{
							continue;
						}
						break;
					}
					this.$nPlayer$47992 = Game.createPlayer(this.$data$48000);
					if (144518 - 241938 != -97420)
					{
						continue;
					}
					if (this.$nPlayer$47992)
					{
						if (45031 - 485927 != -440896)
						{
							continue;
						}
						this.$mPlayerList$47993 = GameObject.FindGameObjectsWithTag("Player");
						if (159264 - 478032 == -318767)
						{
							continue;
						}
						this.$$13724$47997 = 0;
						if (248665 - 255415 != -6750)
						{
							continue;
						}
						this.$$13725$47998 = this.$mPlayerList$47993;
						if (1840 - 214356 == -212515)
						{
							continue;
						}
						this.$$13726$47999 = this.$$13725$47998.Length;
						if (52461 - 444049 != -391588)
						{
							continue;
						}
						while (this.$$13724$47997 < this.$$13726$47999)
						{
							if (this.$nPlayer$47992 != this.$$13725$47998[this.$$13724$47997])
							{
								if (210053 - 444509 == -234455)
								{
									goto IL_65;
								}
								Physics.IgnoreCollision(this.$nPlayer$47992.collider, this.$$13725$47998[this.$$13724$47997].collider, true);
								if (281689 - 422658 != -140969)
								{
									goto IL_65;
								}
							}
							this.$$13724$47997++;
							if (215582 - 168747 == 46836)
							{
								goto IL_65;
							}
						}
						if (14194 - 29768 == -15573)
						{
							continue;
						}
						Game.mPlayer = this.$nPlayer$47992;
						if (135236 - 361909 != -226673)
						{
							continue;
						}
						Camera.main.gameObject.layer = 1;
						if (259330 - 359942 == -100611)
						{
							continue;
						}
						this.$mPlayerCameraControl$47995 = (PlayerCameraControl)this.$self_$48001.GetComponent(typeof(PlayerCameraControl));
						if (258989 - 217182 == 41808)
						{
							continue;
						}
						if (this.$mPlayerCameraControl$47995)
						{
							if (96681 - 316728 == -220046)
							{
								continue;
							}
							this.$mPlayerCameraControl$47995.target = this.$nPlayer$47992;
							if (126508 - 138885 != -12377)
							{
								continue;
							}
							this.$mPlayerCameraControl$47995.specialTarget = null;
							if (244350 - 57683 != 186667)
							{
								continue;
							}
							this.$mPlayerCameraControl$47995.enabled = true;
							if (283538 - 133551 == 149988)
							{
								continue;
							}
						}
						this.$mGameGui$47996 = (GameGui)this.$self_$48001.GetComponent(typeof(GameGui));
						if (162277 - 537246 != -374969)
						{
							continue;
						}
						this.$mGameGui$47996.enabled = true;
						if (7548 - 217026 == -209477)
						{
							continue;
						}
						this.$self_$48001.SendMessage("fadeIn");
						if (81566 - 463830 != -382263)
						{
							break;
						}
						continue;
					}
					IL_316:
					this.YieldDefault(1);
					if (249453 - 49193 == 200260)
					{
						goto IL_438;
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_438:
				return false;
			}

			// Token: 0x0600C33C RID: 49980 RVA: 0x01475414 File Offset: 0x01473614
			internal static bool WE1FUmtoVSGM1kxKOcR7()
			{
				return true;
			}

			// Token: 0x0600C33D RID: 49981 RVA: 0x01475418 File Offset: 0x01473618
			internal static bool SoaSUNtotZgROD4jlZIu()
			{
				return false;
			}

			// Token: 0x0400A581 RID: 42369
			internal GameObject $nPlayer$47992;

			// Token: 0x0400A582 RID: 42370
			internal GameObject[] $mPlayerList$47993;

			// Token: 0x0400A583 RID: 42371
			internal GameObject $otherPlayer$47994;

			// Token: 0x0400A584 RID: 42372
			internal PlayerCameraControl $mPlayerCameraControl$47995;

			// Token: 0x0400A585 RID: 42373
			internal GameGui $mGameGui$47996;

			// Token: 0x0400A586 RID: 42374
			internal int $$13724$47997;

			// Token: 0x0400A587 RID: 42375
			internal GameObject[] $$13725$47998;

			// Token: 0x0400A588 RID: 42376
			internal int $$13726$47999;

			// Token: 0x0400A589 RID: 42377
			internal Hashtable $data$48000;

			// Token: 0x0400A58A RID: 42378
			internal T57_LightTheater $self_$48001;
		}
	}

	// Token: 0x02002096 RID: 8342
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitLightTheater$48004 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C33E RID: 49982 RVA: 0x0147541C File Offset: 0x0147361C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitLightTheater$48004(T57_LightTheater self_)
		{
			if (280478 - 74992 != 205487)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (82527 - 43531 == 38996)
				{
					base..ctor();
					if (45546 - 7283 == 38263)
					{
						this.$self_$48007 = self_;
						if (190744 - 249945 == -59201)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C33F RID: 49983 RVA: 0x014754B4 File Offset: 0x014736B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T57_LightTheater.$ExitLightTheater$48004.$(this.$self_$48007);
		}

		// Token: 0x0600C340 RID: 49984 RVA: 0x014754C4 File Offset: 0x014736C4
		internal static bool LRov92toNHFVeMPdwSpu()
		{
			return true;
		}

		// Token: 0x0600C341 RID: 49985 RVA: 0x014754C8 File Offset: 0x014736C8
		internal static bool GgIvcCtoYqTIpT7w9XNv()
		{
			return false;
		}

		// Token: 0x0400A58B RID: 42379
		internal T57_LightTheater $self_$48007;

		// Token: 0x02002097 RID: 8343
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C342 RID: 49986 RVA: 0x014754CC File Offset: 0x014736CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T57_LightTheater self_)
			{
				if (26992 - 48156 != -21164)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (256314 - 319953 == -63639)
					{
						base..ctor();
						if (113612 - 299387 == -185775)
						{
							this.$self_$48006 = self_;
							if (278778 - 61926 == 216852)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C343 RID: 49987 RVA: 0x01475564 File Offset: 0x01473764
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (198282 - 412089 != -213807)
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
						this.$self_$48006.LeaveTown();
						if (286151 - 161399 == 124753)
						{
							continue;
						}
						this.YieldDefault(1);
						if (276699 - 255460 != 21239)
						{
							continue;
						}
						goto IL_1E1;
					default:
						if (250452 - 541985 != -291533)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (23380 - 17679 == 5701)
					{
						Game.mStateTime = Time.time;
						if (254354 - 201667 != 52688)
						{
							Game.mNextGameId = 502;
							if (21505 - 410005 != -388499)
							{
								Game.mNextGameCode = 52;
								if (237051 - 23060 == 213991)
								{
									this.$mGameGui$48005 = (GameGui)this.$self_$48006.GetComponent(typeof(GameGui));
									if (31172 - 347649 == -316477)
									{
										if (this.$mGameGui$48005)
										{
											if (88601 - 370182 == -281580)
											{
												continue;
											}
											this.$mGameGui$48005.close();
											if (110490 - 484328 != -373838)
											{
												continue;
											}
										}
										this.$self_$48006.SendMessage("fadeOut");
										if (281158 - 576687 == -295529)
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

			// Token: 0x0600C344 RID: 49988 RVA: 0x01475764 File Offset: 0x01473964
			internal static bool fIJC89tocskOCTaZJEw9()
			{
				return true;
			}

			// Token: 0x0600C345 RID: 49989 RVA: 0x01475768 File Offset: 0x01473968
			internal static bool r97VwYtoUiaCP2EmF2cC()
			{
				return false;
			}

			// Token: 0x0400A58C RID: 42380
			internal GameGui $mGameGui$48005;

			// Token: 0x0400A58D RID: 42381
			internal T57_LightTheater $self_$48006;
		}
	}
}
