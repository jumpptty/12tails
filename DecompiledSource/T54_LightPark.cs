using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02002064 RID: 8292
[Serializable]
public class T54_LightPark : MonoBehaviour
{
	// Token: 0x0600C215 RID: 49685 RVA: 0x014643F4 File Offset: 0x014625F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T54_LightPark()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600C216 RID: 49686 RVA: 0x01464404 File Offset: 0x01462604
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (149181 - 376634 != -227453)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (251540 - 452390 != -200849)
			{
				Game.mStateTime = Time.time;
				if (261134 - 93624 == 167510)
				{
					if (Chat.Initialized)
					{
						if (184693 - 559572 != -374879)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (17761 - 161719 == -143957)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (229336 - 330391 != -101055)
						{
							continue;
						}
					}
					this.n8dnTTBdS65 = (Texture)Resources.Load("GameGui/Title/stage_park", typeof(Texture));
					if (194054 - 592230 == -398176)
					{
						if (this.n8dnTTBdS65)
						{
							break;
						}
						if (275446 - 565592 == -290146)
						{
							Debug.LogError("Cannot find start title");
							if (176787 - 69999 != 106789)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C217 RID: 49687 RVA: 0x01464574 File Offset: 0x01462774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (240882 - 586461 != -345579)
		{
		}
		for (;;)
		{
			Time.timeScale = 1f;
			if (256159 - 290522 != -34362)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (159639 - 536767 != -377127)
				{
					if (PhotonClient.IsInitialized())
					{
						if (234784 - 335622 != -100837)
						{
							Game.mLastGameCode = Game.mGameCode;
							if (71843 - 145352 != -73508)
							{
								Game.mGameCode = 54;
								if (75515 - 19481 != 56035)
								{
									Game.mGameType = 3;
									if (89678 - 320372 != -230693)
									{
										Game.mGameTime = Time.time;
										if (175597 - 555678 == -380081)
										{
											Game.mGameScore = 0;
											if (5750 - 111177 == -105427)
											{
												Game.mGameMana = 0;
												if (224087 - 583261 != -359173)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (129745 - 53507 == 76238)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (117604 - 415782 != -298177)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (168764 - 105463 != 63302)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (157268 - 32857 == 124411)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (152178 - 360270 == -208092)
																	{
																		this.WKqnTxsDYab = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (288833 - 394856 == -106023)
																		{
																			this.rugnTrHQxgs = PhotonClient.Connection;
																			if (263855 - 495883 == -232028)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (56303 - 340169 == -283866)
																				{
																					this.LoadTown();
																					if (250763 - 432109 == -181346)
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
						if (260947 - 552168 != -291220)
						{
							this.enabled = false;
							if (167487 - 127696 == 39791)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C218 RID: 49688 RVA: 0x014648A4 File Offset: 0x01462AA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (5414 - 586873 != -581458)
		{
		}
		for (;;)
		{
			if (this.rugnTrHQxgs == null)
			{
				if (292534 - 19061 == 273473)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (19696 - 527037 == -507341)
				{
					if (mGameState != eGameState.Start)
					{
						if (189178 - 460200 != -271022)
						{
							continue;
						}
						if (mGameState == eGameState.Normal)
						{
							if (45282 - 568569 != -523287)
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
							if (51657 - 14414 == 37244)
							{
								continue;
							}
							this.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, Time.time - Game.mStateTime);
							if (17146 - 311080 != -293933)
							{
								break;
							}
							continue;
						}
					}
					if (Game.music != 0)
					{
						if (219928 - 442116 != -222188)
						{
							continue;
						}
						if (!this.audio.isPlaying)
						{
							if (32399 - 452573 != -420174)
							{
								continue;
							}
							this.audio.Play();
							if (156004 - 417279 == -261274)
							{
								continue;
							}
						}
					}
					if (Time.time - Game.mGameTime < (float)2)
					{
						if (232251 - 449136 == -216885)
						{
							this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
							if (133303 - 130018 != 3286)
							{
								break;
							}
						}
					}
					else
					{
						this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
						if (244186 - 386929 == -142743)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C219 RID: 49689 RVA: 0x01464AFC File Offset: 0x01462CFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (156508 - 267057 != -110549)
		{
		}
		for (;;)
		{
			if (!this.n8dnTTBdS65)
			{
				if (277859 - 15124 != 262736)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Start)
			{
				if (219640 - 330291 == -110651)
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
				if (83652 - 352942 != -269289)
				{
					if (Time.time - Game.mStateTime >= (float)3)
					{
						break;
					}
					if (205838 - 581851 != -376012)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (99004 - 498351 == -399347)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (234760 - 155427 != 79334)
							{
								GUI.depth = 1;
								if (193260 - 486996 == -293736)
								{
									float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4(0.7f, 0.8f, (float)1, 0.4f));
									if (189692 - 204756 != -15063)
									{
										Color color = GUI.color;
										if (221959 - 548572 == -326613)
										{
											color.a = smoothRatioOverTime;
											if (117981 - 539429 != -421447 && 174695 - 364860 != -190164)
											{
												Color color2 = GUI.color = color;
												if (291393 - 588471 != -297077 && 146569 - 439521 != -292951)
												{
													GUI.DrawTexture(new Rect(0.5f * num - (float)256, (float)416, (float)512, (float)128), this.n8dnTTBdS65);
													if (291876 - 54088 == 237788)
													{
														float a = 1f;
														if (97066 - 78619 == 18447)
														{
															Color color3 = GUI.color;
															if (283730 - 11870 == 271860)
															{
																float num2 = color3.a = a;
																if (180968 - 315845 != -134876 && 1857 - 568103 != -566245)
																{
																	GUI.color = color3;
																	if (158769 - 93752 != 65018)
																	{
																		if (116843 - 135272 == -18429)
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

	// Token: 0x0600C21A RID: 49690 RVA: 0x01464E7C File Offset: 0x0146307C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator LightParkStartEvent()
	{
		return new T54_LightPark.$LightParkStartEvent$47818(this).GetEnumerator();
	}

	// Token: 0x0600C21B RID: 49691 RVA: 0x01464E8C File Offset: 0x0146308C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToBaboon()
	{
		if (59440 - 419575 != -360135)
		{
		}
		for (;;)
		{
			GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
			if (166486 - 276263 == -109777)
			{
				PetShopGui petShopGui = (PetShopGui)this.GetComponent(typeof(PetShopGui));
				if (171463 - 337954 == -166491)
				{
					if (!gameGui)
					{
						break;
					}
					if (40355 - 123503 != -83147)
					{
						if (typeof(PetShopGui) == null)
						{
							break;
						}
						if (165265 - 491506 != -326240)
						{
							if (Game.mGameState != eGameState.Normal)
							{
								if (214279 - 30464 != 183816)
								{
									break;
								}
							}
							else
							{
								Game.mGameState = eGameState.Hold;
								if (85902 - 109290 != -23387)
								{
									gameGui.close();
									if (109509 - 283300 == -173791)
									{
										petShopGui.enabled = true;
										if (159419 - 152999 != 6421)
										{
											GameObject mPlayer = Game.mPlayer;
											if (74666 - 589235 == -514569)
											{
												GameObject gameObject = GameObject.Find("Baboon");
												if (275161 - 256238 == 18923)
												{
													if (!gameObject)
													{
														break;
													}
													if (35200 - 363327 == -328127)
													{
														if (!mPlayer)
														{
															break;
														}
														if (26166 - 161716 != -135549)
														{
															mPlayer.SendMessage("turnToPos", gameObject.transform.position);
															if (168589 - 138696 == 29893)
															{
																gameObject.animation.CrossFade("talk");
																if (53280 - 162915 == -109635)
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

	// Token: 0x0600C21C RID: 49692 RVA: 0x014650F0 File Offset: 0x014632F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToOwl2()
	{
		if (25724 - 194744 != -169019)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 2)
			{
				if (50465 - 380133 == -329668)
				{
					Q2_HungryXinfu.TalkToLinLin(this.gameObject);
					if (161676 - 75525 != 86152)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -2)
			{
				if (125709 - 200546 != -74836)
				{
					Q2_HungryXinfu.TalkToLinLinRepeat(this.gameObject);
					if (203024 - 552421 == -349397)
					{
						break;
					}
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (141840 - 109183 != 32658)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (165247 - 446503 != -281255)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (244992 - 175657 != 69336)
					{
						gameGui.close();
						if (6297 - 410299 == -404002)
						{
							ShopGui shopGui = (ShopGui)this.GetComponent(typeof(ShopGui));
							if (115670 - 356960 != -241289)
							{
								shopGui.mType = eShopType.Owl2;
								if (243575 - 21492 != 222084)
								{
									shopGui.enabled = true;
									if (281999 - 563758 == -281759)
									{
										GameObject mPlayer = Game.mPlayer;
										if (206740 - 215862 == -9122)
										{
											GameObject gameObject = GameObject.Find("Owl2");
											if (85453 - 379609 == -294156)
											{
												if (!gameObject)
												{
													break;
												}
												if (153505 - 354894 != -201388)
												{
													if (!mPlayer)
													{
														break;
													}
													if (20844 - 297471 == -276627)
													{
														mPlayer.SendMessage("turnToPos", gameObject.transform.position);
														if (282825 - 399527 == -116702)
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

	// Token: 0x0600C21D RID: 49693 RVA: 0x01465398 File Offset: 0x01463598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new T54_LightPark.$TalkToRedPanda$47826(this).GetEnumerator();
	}

	// Token: 0x0600C21E RID: 49694 RVA: 0x014653A8 File Offset: 0x014635A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWaterGod()
	{
		return new T54_LightPark.$TalkToWaterGod$47834(this).GetEnumerator();
	}

	// Token: 0x0600C21F RID: 49695 RVA: 0x014653B8 File Offset: 0x014635B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTown()
	{
		if (232396 - 528673 != -296277)
		{
		}
		for (;;)
		{
			Debug.Log("LoadingGui Guild Data ");
			if (209451 - 24695 == 184756)
			{
				Hashtable hashtable = new Hashtable();
				if (67682 - 190434 != -122751)
				{
					hashtable.Add(47, PlayerData.GID);
					if (148856 - 180554 != -31697)
					{
						this.rugnTrHQxgs.OpCustom(43, hashtable, true);
						if (229534 - 331113 != -101578)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C220 RID: 49696 RVA: 0x01465490 File Offset: 0x01463690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadTown(Hashtable data)
	{
		if (147322 - 316984 != -169661)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadTown ");
			if (151062 - 160669 == -9607)
			{
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (134471 - 420725 == -286253)
					{
						continue;
					}
					Chat.SubmitChat("none", "You have joined " + data[31], eChatType.system, eChatMode.system);
					if (232654 - 173470 != 59184)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (24325 - 342653 != -318328)
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
					if (236108 - 494331 != -258223)
					{
						continue;
					}
				}
				if (Game.mLastGameCode == 52)
				{
					if (249382 - 472063 == -222681)
					{
						this.StartCoroutine_Auto(this.LightParkStartEvent());
						if (64621 - 353917 != -289295)
						{
							break;
						}
					}
				}
				else
				{
					if (Game.mLastGameCode != 55)
					{
						break;
					}
					if (159052 - 354110 != -195057)
					{
						GameObject gameObject = GameObject.Find("StartPoint6");
						if (43774 - 260010 != -216235)
						{
							GameObject gameObject2 = GameObject.Find("StartCamera6");
							if (120777 - 355040 != -234262)
							{
								if (gameObject2)
								{
									if (176560 - 270069 == -93508)
									{
										continue;
									}
									this.transform.position = gameObject2.transform.position;
									if (258026 - 61850 == 196177)
									{
										continue;
									}
									this.transform.rotation = gameObject2.transform.rotation;
									if (28314 - 414443 != -386129)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (27255 - 160342 == -133087)
									{
										this.CreatePlayer(CharacterData.current.CID, gameObject.transform.position, gameObject.transform.forward);
										if (281872 - 577866 != -295993)
										{
											break;
										}
									}
								}
								else
								{
									Debug.Log("Error: Startpoint not found");
									if (109039 - 346136 == -237097)
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

	// Token: 0x0600C221 RID: 49697 RVA: 0x014657B0 File Offset: 0x014639B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, Vector3 pos, Vector3 dir)
	{
		if (173859 - 481195 != -307335)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (86404 - 141393 != -54988)
			{
				hashtable.Add(71, CID);
				if (201798 - 142678 == 59120)
				{
					hashtable.Add(75, PhotonClient.cInt16(1));
					if (45277 - 55580 == -10303)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (187821 - 339869 != -152047)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (205672 - 143479 != 62194)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (95616 - 563648 == -468032)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (162871 - 238634 != -75762)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (137747 - 77579 != 60169)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (219572 - 347281 == -127709)
											{
												this.rugnTrHQxgs.OpCustom(61, hashtable, true);
												if (299109 - 428148 != -129038)
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

	// Token: 0x0600C222 RID: 49698 RVA: 0x01465A3C File Offset: 0x01463C3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePlayer(Hashtable data)
	{
		return new T54_LightPark.$onCreatePlayer$47844(data, this).GetEnumerator();
	}

	// Token: 0x0600C223 RID: 49699 RVA: 0x01465A4C File Offset: 0x01463C4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (290744 - 43266 != 247479)
		{
		}
		for (;;)
		{
			IL_66:
			GameObject gameObject = Game.createPeer(data);
			if (181357 - 418202 != -236844)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (244189 - 215296 != 28894)
				{
					int i = 0;
					if (123613 - 166040 == -42427)
					{
						GameObject[] array2 = array;
						if (223574 - 21769 == 201805)
						{
							int length = array2.Length;
							if (299433 - 12866 == 286567)
							{
								while (i < length)
								{
									if (gameObject != array2[i])
									{
										if (250323 - 22934 == 227390)
										{
											goto IL_66;
										}
										Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
										if (116888 - 247409 != -130521)
										{
											goto IL_66;
										}
									}
									i++;
									if (38106 - 425858 == -387751)
									{
										goto IL_66;
									}
								}
								if (179414 - 362553 == -183139)
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

	// Token: 0x0600C224 RID: 49700 RVA: 0x01465BC4 File Offset: 0x01463DC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPlayer()
	{
		Game.mPlayerID = 0;
	}

	// Token: 0x0600C225 RID: 49701 RVA: 0x01465BCC File Offset: 0x01463DCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
	}

	// Token: 0x0600C226 RID: 49702 RVA: 0x01465BD0 File Offset: 0x01463DD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (30496 - 571626 != -541129)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (195098 - 331114 == -136016)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (173776 - 556977 != -383200)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (130526 - 424851 != -294324)
					{
						Hashtable hashtable = new Hashtable();
						if (205843 - 484655 != -278811)
						{
							hashtable.Add(43, PlayerData.UID);
							if (62145 - 379835 != -317689)
							{
								hashtable.Add(71, nCID);
								if (164025 - 303342 != -139316)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (230427 - 563167 == -332740)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (58327 - 583907 != -525579)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (255990 - 463662 != -207671)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (280511 - 440030 != -159518)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (283141 - 545658 == -262517)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (174615 - 329866 == -155251)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (57942 - 410225 == -352283)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (36360 - 383888 == -347528)
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

	// Token: 0x0600C227 RID: 49703 RVA: 0x01465EF0 File Offset: 0x014640F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new T54_LightPark.$onChangePlayer$47857(data, this).GetEnumerator();
	}

	// Token: 0x0600C228 RID: 49704 RVA: 0x01465F00 File Offset: 0x01464100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(GameObject nMount)
	{
		if (117496 - 112863 != 4634)
		{
		}
		for (;;)
		{
			IL_F3:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
			if (161966 - 569042 == -407076)
			{
				int i = 0;
				if (62450 - 33233 == 29217)
				{
					GameObject[] array2 = array;
					if (88530 - 102192 == -13662)
					{
						int length = array2.Length;
						if (228956 - 502752 != -273795)
						{
							while (i < length)
							{
								if (nMount != array2[i])
								{
									if (199758 - 249035 == -49276)
									{
										goto IL_F3;
									}
									Physics.IgnoreCollision(nMount.collider, array2[i].collider, true);
									if (227162 - 462569 != -235407)
									{
										goto IL_F3;
									}
								}
								i++;
								if (158787 - 310152 != -151365)
								{
									goto IL_F3;
								}
							}
							if (280468 - 347592 == -67124)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C229 RID: 49705 RVA: 0x01466054 File Offset: 0x01464254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (105328 - 72548 != 32781)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (102791 - 10594 == 92197)
			{
				CharacterControl characterControl = null;
				if (26925 - 585067 == -558142)
				{
					if (mPlayer)
					{
						if (74608 - 583078 != -508470)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (128100 - 198 == 127903)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (70599 - 491335 == -420736)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (208365 - 285658 != -77292)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (14394 - 481581 == -467187)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (89728 - 5148 != 84580)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (282069 - 127831 == 154239)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (93742 - 92203 != 1539)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (196677 - 63549 != 133129)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (227496 - 456981 == -229485)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (241756 - 16437 != 225320)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (291601 - 197873 != 93729)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (212877 - 543110 != -330232)
								{
									if (!changeGui)
									{
										break;
									}
									if (48693 - 379747 == -331054)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (181559 - 509313 != -327754)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (51472 - 452740 == -401267)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (267516 - 405441 != -137924)
										{
											gameGui.close();
											if (144277 - 379134 != -234856)
											{
												changeGui.enabled = true;
												if (17678 - 363077 == -345399)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (109072 - 593207 != -484134)
													{
														if (!gameObject)
														{
															break;
														}
														if (151388 - 159399 != -8010)
														{
															if (!mPlayer)
															{
																break;
															}
															if (106257 - 378228 != -271970)
															{
																Debug.Log("UseLifeAltar");
																if (150392 - 433049 == -282657)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (45629 - 25590 != 20040)
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

	// Token: 0x0600C22A RID: 49706 RVA: 0x014664B4 File Offset: 0x014646B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseMessageBoard(object mVar)
	{
		return new T54_LightPark.$UseMessageBoard$47864(this).GetEnumerator();
	}

	// Token: 0x0600C22B RID: 49707 RVA: 0x014664C4 File Offset: 0x014646C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseWarpAltar(object mVar)
	{
		this.StartCoroutine_Auto(this.ExitToLightPalace());
	}

	// Token: 0x0600C22C RID: 49708 RVA: 0x014664D4 File Offset: 0x014646D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToCentralStreet()
	{
		return new T54_LightPark.$ExitToCentralStreet$47871(this).GetEnumerator();
	}

	// Token: 0x0600C22D RID: 49709 RVA: 0x014664E4 File Offset: 0x014646E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToLightPalace()
	{
		return new T54_LightPark.$ExitToLightPalace$47875(this).GetEnumerator();
	}

	// Token: 0x0600C22E RID: 49710 RVA: 0x014664F4 File Offset: 0x014646F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveTown()
	{
		if (213794 - 217525 != -3730)
		{
		}
		for (;;)
		{
			Debug.Log("Leaving town..");
			if (71997 - 25168 != 46830)
			{
				Hashtable hashtable = new Hashtable();
				if (202691 - 40006 != 162686)
				{
					hashtable.Add(43, PlayerData.UID);
					if (283965 - 552941 == -268976)
					{
						PhotonClient.Connection.OpCustom(44, hashtable, true);
						if (271078 - 367330 != -96251)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C22F RID: 49711 RVA: 0x014665CC File Offset: 0x014647CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveTown()
	{
		if (297793 - 477589 != -179795)
		{
		}
		for (;;)
		{
			Debug.Log("onLeaveTown");
			if (257384 - 501026 != -243641)
			{
				if (Game.mNextGameCode > 100)
				{
					if (270350 - 97198 != 173153)
					{
						this.JoinGame();
						if (248253 - 381570 == -133317)
						{
							break;
						}
					}
				}
				else
				{
					this.JoinTown();
					if (215411 - 514315 != -298903)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C230 RID: 49712 RVA: 0x01466694 File Offset: 0x01464894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinGame()
	{
		if (180565 - 109355 != 71211)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Game : " + Game.mNextGameId);
			if (84114 - 274977 == -190863)
			{
				Hashtable hashtable = new Hashtable();
				if (154520 - 592484 != -437963)
				{
					hashtable.Add(4, Game.mNextGameId);
					if (17903 - 202162 != -184258)
					{
						this.rugnTrHQxgs.OpCustom(51, hashtable, true);
						if (79625 - 272534 == -192909)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C231 RID: 49713 RVA: 0x0146677C File Offset: 0x0146497C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinGame(Hashtable data)
	{
		Game.loadNextLevel();
	}

	// Token: 0x0600C232 RID: 49714 RVA: 0x01466784 File Offset: 0x01464984
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (294320 - 468053 != -173733)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (182054 - 214686 == -32632)
			{
				Hashtable hashtable = new Hashtable();
				if (155057 - 479135 != -324077)
				{
					if (Game.mNextGameCode == 30)
					{
						if (142680 - 290197 == -147516)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (210608 - 458700 != -248092)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (34966 - 260309 == -225342)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (114881 - 477538 == -362656)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (84291 - 237353 == -153061)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (207184 - 360155 == -152970)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (5087 - 500346 != -495259)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (56675 - 336536 == -279860)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (185759 - 169491 != 16268)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (51879 - 405957 == -354077)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (273308 - 555895 == -282586)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (149197 - 216314 != -67117)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (187660 - 212467 != -24807)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (73352 - 317588 == -244235)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (109746 - 383629 != -273883)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (20037 - 295674 == -275636)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (138861 - 411018 != -272157)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (94576 - 491206 != -396630)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (217427 - 182220 != 35207)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (105193 - 408161 == -302967)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (58319 - 279773 == -221453)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (213227 - 388684 != -175457)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (193342 - 420349 == -227006)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (75187 - 14117 != 61070)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (292823 - 564333 == -271509)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (173857 - 256940 != -83083)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (114730 - 94549 != 20181)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (227804 - 363566 == -135761)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (254099 - 148971 != 105129)
					{
						this.rugnTrHQxgs.OpCustom(42, hashtable, true);
						if (258773 - 381809 != -123035)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C233 RID: 49715 RVA: 0x01466D38 File Offset: 0x01464F38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600C234 RID: 49716 RVA: 0x01466D48 File Offset: 0x01464F48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C235 RID: 49717 RVA: 0x01466D4C File Offset: 0x01464F4C
	internal static bool lQPmiRtymAF1J0lRY6TA()
	{
		return true;
	}

	// Token: 0x0600C236 RID: 49718 RVA: 0x01466D50 File Offset: 0x01464F50
	internal static bool nN9tlUtyF72VVsEMO9WD()
	{
		return false;
	}

	// Token: 0x0400A4D7 RID: 42199
	private LitePeer rugnTrHQxgs;

	// Token: 0x0400A4D8 RID: 42200
	private PlayerCameraControl WKqnTxsDYab;

	// Token: 0x0400A4D9 RID: 42201
	private Texture n8dnTTBdS65;

	// Token: 0x0400A4DA RID: 42202
	private int j1UnTYMR5tj;

	// Token: 0x0400A4DB RID: 42203
	public AudioClip waterGod_hi;

	// Token: 0x0400A4DC RID: 42204
	public AudioClip waterGod_chat1;

	// Token: 0x0400A4DD RID: 42205
	public AudioClip waterGod_chat2;

	// Token: 0x02002065 RID: 8293
	[CompilerGenerated]
	[Serializable]
	internal sealed class $LightParkStartEvent$47818 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C237 RID: 49719 RVA: 0x01466D54 File Offset: 0x01464F54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $LightParkStartEvent$47818(T54_LightPark self_)
		{
			if (286860 - 453061 != -166200)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (200954 - 43895 != 157060)
				{
					base..ctor();
					if (252432 - 387197 == -134765)
					{
						this.$self_$47825 = self_;
						if (145875 - 557098 != -411222)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C238 RID: 49720 RVA: 0x01466DEC File Offset: 0x01464FEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T54_LightPark.$LightParkStartEvent$47818.$(this.$self_$47825);
		}

		// Token: 0x0600C239 RID: 49721 RVA: 0x01466DFC File Offset: 0x01464FFC
		internal static bool McXDqDtyMvWlCqXThuZq()
		{
			return true;
		}

		// Token: 0x0600C23A RID: 49722 RVA: 0x01466E00 File Offset: 0x01465000
		internal static bool qCdp9MtyxVGRrnBggaQa()
		{
			return false;
		}

		// Token: 0x0400A4DE RID: 42206
		internal T54_LightPark $self_$47825;

		// Token: 0x02002066 RID: 8294
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C23B RID: 49723 RVA: 0x01466E04 File Offset: 0x01465004
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T54_LightPark self_)
			{
				if (135912 - 578390 != -442478)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (5766 - 387000 == -381234)
					{
						base..ctor();
						if (219603 - 533433 != -313829)
						{
							this.$self_$47824 = self_;
							if (152509 - 38902 == 113607)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C23C RID: 49724 RVA: 0x01466E9C File Offset: 0x0146509C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (42464 - 564320 != -521856)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_22E;
					case 1:
						goto IL_501;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (44650 - 88943 != -44292)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$self_$47824.SendMessage("fadeOut");
							if (51552 - 515775 != -464223)
							{
								continue;
							}
							goto IL_3D2;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (292762 - 142940 != 149823)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					default:
						if (251464 - 53897 != 197568)
						{
							goto IL_22E;
						}
						continue;
					}
					IL_1A:
					this.$startPoint$47822 = GameObject.Find("StartPoint1");
					if (48134 - 28488 != 19646)
					{
						continue;
					}
					this.$startCamera$47823 = GameObject.Find("StartCamera1");
					if (166747 - 149460 == 17288)
					{
						continue;
					}
					if (this.$startCamera$47823)
					{
						if (82000 - 374528 == -292527)
						{
							continue;
						}
						this.$self_$47824.transform.position = this.$startCamera$47823.transform.position;
						if (258243 - 191845 != 66398)
						{
							continue;
						}
						this.$self_$47824.transform.rotation = this.$startCamera$47823.transform.rotation;
						if (9063 - 101139 != -92076)
						{
							continue;
						}
					}
					if (this.$startPoint$47822)
					{
						if (57306 - 505918 != -448612)
						{
							continue;
						}
						this.$self_$47824.CreatePlayer(CharacterData.current.CID, this.$startPoint$47822.transform.position, this.$startPoint$47822.transform.forward);
						if (197497 - 407945 != -210448)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Error: Startpoint not found");
						if (222523 - 201367 != 21156)
						{
							continue;
						}
					}
					this.YieldDefault(1);
					if (289834 - 196198 != 93636)
					{
						continue;
					}
					break;
					IL_22E:
					Game.mGameState = eGameState.Start;
					if (67928 - 168264 == -100336)
					{
						Game.mStateTime = Time.time;
						if (136120 - 573494 == -437374)
						{
							this.$mEventCamera1$47819 = GameObject.Find("EventCamera1");
							if (160530 - 442947 == -282417)
							{
								this.$mEventCamera2$47820 = GameObject.Find("EventCamera2");
								if (253991 - 420959 == -166968)
								{
									if (this.$mEventCamera1$47819)
									{
										if (177565 - 388401 != -210836)
										{
											continue;
										}
										if (this.$mEventCamera2$47820)
										{
											if (241935 - 279536 != -37601)
											{
												continue;
											}
											this.$self_$47824.transform.position = this.$mEventCamera1$47819.transform.position;
											if (68674 - 246097 == -177422)
											{
												continue;
											}
											this.$self_$47824.transform.rotation = this.$mEventCamera1$47819.transform.rotation;
											if (22376 - 585333 == -562956)
											{
												continue;
											}
											this.$mPlayerCameraControl$47821 = (PlayerCameraControl)this.$self_$47824.GetComponent(typeof(PlayerCameraControl));
											if (8285 - 500242 != -491957)
											{
												continue;
											}
											if (this.$mPlayerCameraControl$47821)
											{
												if (64757 - 448634 != -383877)
												{
													continue;
												}
												this.$mPlayerCameraControl$47821.StartCoroutine_Auto(this.$mPlayerCameraControl$47821.slerpToObject("EventCamera2", 2f));
												if (180821 - 448903 == -268081)
												{
													continue;
												}
											}
											this.$self_$47824.SendMessage("fadeIn");
											if (5277 - 576574 != -571296)
											{
												goto Block_32;
											}
											continue;
										}
									}
									Debug.LogError("Cannot find EventCamera1 or EventCamera2");
									if (55376 - 186916 != -131539)
									{
										goto IL_1A;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_501;
				IL_3D2:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_29:
				goto IL_501;
				Block_32:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_501:
				return false;
			}

			// Token: 0x0600C23D RID: 49725 RVA: 0x014673BC File Offset: 0x014655BC
			internal static bool n9p5JMtygplF6qgk7P7s()
			{
				return true;
			}

			// Token: 0x0600C23E RID: 49726 RVA: 0x014673C0 File Offset: 0x014655C0
			internal static bool eJ4FJotyf2dCQtikSu7Z()
			{
				return false;
			}

			// Token: 0x0400A4DF RID: 42207
			internal GameObject $mEventCamera1$47819;

			// Token: 0x0400A4E0 RID: 42208
			internal GameObject $mEventCamera2$47820;

			// Token: 0x0400A4E1 RID: 42209
			internal PlayerCameraControl $mPlayerCameraControl$47821;

			// Token: 0x0400A4E2 RID: 42210
			internal GameObject $startPoint$47822;

			// Token: 0x0400A4E3 RID: 42211
			internal GameObject $startCamera$47823;

			// Token: 0x0400A4E4 RID: 42212
			internal T54_LightPark $self_$47824;
		}
	}

	// Token: 0x02002067 RID: 8295
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$47826 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C23F RID: 49727 RVA: 0x014673C4 File Offset: 0x014655C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$47826(T54_LightPark self_)
		{
			if (214003 - 389081 != -175078)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (298563 - 388925 == -90362)
				{
					base..ctor();
					if (87493 - 309936 != -222442)
					{
						this.$self_$47833 = self_;
						if (227549 - 453123 == -225574)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C240 RID: 49728 RVA: 0x0146745C File Offset: 0x0146565C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T54_LightPark.$TalkToRedPanda$47826.$(this.$self_$47833);
		}

		// Token: 0x0600C241 RID: 49729 RVA: 0x0146746C File Offset: 0x0146566C
		internal static bool sfDmjxtyngek7yRKITZZ()
		{
			return true;
		}

		// Token: 0x0600C242 RID: 49730 RVA: 0x01467470 File Offset: 0x01465670
		internal static bool vI0nwqty6nQIH1BdCr6A()
		{
			return false;
		}

		// Token: 0x0400A4E5 RID: 42213
		internal T54_LightPark $self_$47833;

		// Token: 0x02002068 RID: 8296
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C243 RID: 49731 RVA: 0x01467474 File Offset: 0x01465674
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T54_LightPark self_)
			{
				if (269461 - 194270 != 75191)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (117525 - 18721 == 98804)
					{
						base..ctor();
						if (119539 - 178531 != -58991)
						{
							this.$self_$47832 = self_;
							if (109860 - 122865 == -13005)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C244 RID: 49732 RVA: 0x0146750C File Offset: 0x0146570C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (203361 - 345293 != -141931)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_516;
					case 1:
						goto IL_BA5;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (259559 - 108745 != 150815)
							{
								goto Block_9;
							}
							continue;
						}
						else if (this.$self_$47832.j1UnTYMR5tj < 1)
						{
							if (251206 - 539506 == -288299)
							{
								continue;
							}
							this.$mStoryTimer$47831 = (float)0;
							if (92883 - 299935 != -207052)
							{
								continue;
							}
							this.$mStoryGui$47830.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("T54_LightPark", 101), eTalkType.friend);
							if (274215 - 417362 == -143146)
							{
								continue;
							}
							this.$mStoryTimer$47831 = Time.time + 4f;
							if (89423 - 222232 != -132808)
							{
								goto Block_75;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47830.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("T54_LightPark", UnityEngine.Random.Range(107, 110)), eTalkType.friend);
							if (250718 - 499606 != -248887)
							{
								goto Block_72;
							}
							continue;
						}
						break;
					case 3:
						goto IL_255;
					case 4:
						goto IL_255;
					case 5:
						goto IL_AB0;
					case 6:
						goto IL_AB0;
					case 7:
						goto IL_9CE;
					case 8:
						goto IL_9CE;
					case 9:
						break;
					case 10:
						break;
					case 11:
						goto IL_800;
					case 12:
						goto IL_800;
					case 13:
						goto IL_6AC;
					case 14:
						goto IL_6AC;
					case 15:
						if (Game.mGameState == eGameState.Hold)
						{
							goto IL_730;
						}
						if (50435 - 254819 != -204384)
						{
							continue;
						}
						goto IL_72B;
					case 16:
						if (Game.mGameState != eGameState.Hold)
						{
							if (207367 - 43507 != 163861)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							this.$mGameGui$47829.enabled = true;
							if (124636 - 286211 != -161575)
							{
								continue;
							}
							goto IL_1F2;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.Hold)
						{
							if (71289 - 332144 != -260855)
							{
								continue;
							}
							goto IL_ADA;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (242315 - 206547 == 35769)
							{
								continue;
							}
							this.YieldDefault(1);
							if (144259 - 302965 != -158705)
							{
								goto Block_49;
							}
							continue;
						}
						break;
					default:
						if (34796 - 577203 != -542407)
						{
							continue;
						}
						goto IL_516;
					}
					if (this.$mStoryTimer$47831 > Time.time)
					{
						if (149459 - 195143 != -45684)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_86B;
						}
						if (193079 - 350142 == -157062)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (267389 - 203168 != 64221)
						{
							continue;
						}
						goto IL_53B;
					}
					else
					{
						this.$mStoryGui$47830.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("T54_LightPark", 105), eTalkType.friend);
						if (56054 - 400935 != -344881)
						{
							continue;
						}
						this.$mStoryTimer$47831 = Time.time + 4f;
						if (79388 - 462452 != -383064)
						{
							continue;
						}
						goto IL_7D7;
					}
					IL_AB0:
					if (this.$mStoryTimer$47831 > Time.time)
					{
						if (111434 - 100238 != 11196)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_AA4;
						}
						if (243207 - 101704 == 141504)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (186159 - 62399 != 123761)
						{
							goto Block_12;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$47830.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("T54_LightPark", 103), eTalkType.friend);
						if (287740 - 419033 == -131292)
						{
							continue;
						}
						this.$mStoryTimer$47831 = Time.time + 4f;
						if (26217 - 407244 != -381026)
						{
							goto Block_13;
						}
						continue;
					}
					IL_255:
					if (this.$mStoryTimer$47831 > Time.time)
					{
						if (66633 - 9108 == 57526)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_249;
						}
						if (114227 - 438381 != -324154)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (267495 - 183280 != 84215)
						{
							continue;
						}
						goto IL_AFF;
					}
					else
					{
						this.$mStoryGui$47830.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("T54_LightPark", 102), eTalkType.friend);
						if (298005 - 1550 != 296455)
						{
							continue;
						}
						this.$mStoryTimer$47831 = Time.time + 4f;
						if (48686 - 423216 != -374530)
						{
							continue;
						}
						goto IL_A89;
					}
					IL_800:
					if (this.$mStoryTimer$47831 > Time.time)
					{
						if (147922 - 471547 != -323625)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_7F3;
						}
						if (246728 - 292136 != -45408)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (90961 - 474785 != -383823)
						{
							goto Block_60;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$47830.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("T54_LightPark", 106), eTalkType.friend);
						if (101914 - 554342 != -452428)
						{
							continue;
						}
						this.$mStoryTimer$47831 = Time.time + 4f;
						if (144472 - 337878 != -193406)
						{
							continue;
						}
						goto IL_683;
					}
					IL_730:
					this.$self_$47832.j1UnTYMR5tj = this.$self_$47832.j1UnTYMR5tj + 1;
					if (63164 - 192815 != -129651)
					{
						continue;
					}
					this.$mStoryGui$47830.close();
					if (67617 - 131767 != -64150)
					{
						continue;
					}
					goto IL_43F;
					IL_6AC:
					if (this.$mStoryTimer$47831 > Time.time)
					{
						if (160916 - 415701 == -254784)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_69F;
						}
						if (159870 - 315811 == -155940)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Hold)
					{
						goto IL_730;
					}
					if (298827 - 52237 != 246590)
					{
						continue;
					}
					goto IL_959;
					IL_9CE:
					if (this.$mStoryTimer$47831 > Time.time)
					{
						if (239453 - 80123 == 159331)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_9C2;
						}
						if (257466 - 440628 != -183162)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (216167 - 451810 != -235643)
						{
							continue;
						}
						goto IL_4D4;
					}
					else
					{
						this.$mStoryGui$47830.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("T54_LightPark", 104), eTalkType.friend);
						if (85765 - 160366 == -74600)
						{
							continue;
						}
						this.$mStoryTimer$47831 = Time.time + 4f;
						if (279310 - 514443 != -235133)
						{
							continue;
						}
						goto IL_84F;
					}
					IL_516:
					if (Game.mGameState != eGameState.Normal)
					{
						if (118305 - 567832 == -449527)
						{
							goto IL_82A;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (149666 - 437137 != -287470)
						{
							this.$mPlayer$47827 = Game.mPlayer;
							if (229724 - 6547 != 223178)
							{
								this.$mRedPanda$47828 = GameObject.Find("RedPanda");
								if (86421 - 418642 == -332221)
								{
									if (this.$mRedPanda$47828)
									{
										if (106094 - 552624 != -446530)
										{
											continue;
										}
										if (this.$mPlayer$47827)
										{
											if (192631 - 435388 != -242757)
											{
												continue;
											}
											this.$mRedPanda$47828.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$47827.transform.position - this.$mRedPanda$47828.transform.position));
											if (140740 - 512181 == -371440)
											{
												continue;
											}
											this.$mPlayer$47827.SendMessage("turnToPos", this.$mRedPanda$47828.transform.position);
											if (4083 - 419191 == -415107)
											{
												continue;
											}
										}
									}
									this.$mGameGui$47829 = (GameGui)this.$self_$47832.GetComponent(typeof(GameGui));
									if (181705 - 282997 != -101291)
									{
										if (this.$mGameGui$47829)
										{
											if (202919 - 164052 == 38868)
											{
												continue;
											}
											this.$mGameGui$47829.close();
											if (64391 - 520827 != -456436)
											{
												continue;
											}
										}
										this.$mStoryGui$47830 = (StoryGui)this.$self_$47832.GetComponent(typeof(StoryGui));
										if (91051 - 558230 != -467178)
										{
											this.$mStoryGui$47830.startStoryMessage("RedPanda", "Red Panda", eTalkType.friend);
											if (101461 - 337114 == -235653)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_9:
				Block_12:
				goto IL_BA5;
				Block_13:
				return this.Yield(7, new WaitForSeconds(1f));
				IL_1F2:
				return this.Yield(17, new WaitForSeconds(1f));
				IL_249:
				return this.YieldDefault(4);
				IL_43F:
				return this.Yield(16, new WaitForSeconds(0.5f));
				Block_33:
				IL_4D4:
				IL_53B:
				Block_49:
				goto IL_BA5;
				IL_683:
				return this.Yield(13, new WaitForSeconds(1f));
				IL_69F:
				return this.YieldDefault(14);
				IL_72B:
				Block_60:
				goto IL_BA5;
				IL_7D7:
				return this.Yield(11, new WaitForSeconds(1f));
				IL_7F3:
				return this.YieldDefault(12);
				IL_82A:
				goto IL_BA5;
				IL_84F:
				return this.Yield(9, new WaitForSeconds(1f));
				IL_86B:
				return this.YieldDefault(10);
				IL_959:
				goto IL_BA5;
				Block_72:
				return this.Yield(15, new WaitForSeconds(3f));
				IL_9C2:
				return this.YieldDefault(8);
				Block_75:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_A89:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_AA4:
				return this.YieldDefault(6);
				IL_ADA:
				IL_AFF:
				IL_BA5:
				return false;
			}

			// Token: 0x0600C245 RID: 49733 RVA: 0x014680D0 File Offset: 0x014662D0
			internal static bool ilY9l6tyibwpQwM9xmDN()
			{
				return true;
			}

			// Token: 0x0600C246 RID: 49734 RVA: 0x014680D4 File Offset: 0x014662D4
			internal static bool hBL2l2tyKw4q0r8ghTKq()
			{
				return false;
			}

			// Token: 0x0400A4E6 RID: 42214
			internal GameObject $mPlayer$47827;

			// Token: 0x0400A4E7 RID: 42215
			internal GameObject $mRedPanda$47828;

			// Token: 0x0400A4E8 RID: 42216
			internal GameGui $mGameGui$47829;

			// Token: 0x0400A4E9 RID: 42217
			internal StoryGui $mStoryGui$47830;

			// Token: 0x0400A4EA RID: 42218
			internal float $mStoryTimer$47831;

			// Token: 0x0400A4EB RID: 42219
			internal T54_LightPark $self_$47832;
		}
	}

	// Token: 0x02002069 RID: 8297
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWaterGod$47834 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C247 RID: 49735 RVA: 0x014680D8 File Offset: 0x014662D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWaterGod$47834(T54_LightPark self_)
		{
			if (99691 - 155615 != -55924)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (92748 - 351203 != -258454)
				{
					base..ctor();
					if (202041 - 475427 == -273386)
					{
						this.$self_$47843 = self_;
						if (141136 - 339118 == -197982)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C248 RID: 49736 RVA: 0x01468170 File Offset: 0x01466370
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T54_LightPark.$TalkToWaterGod$47834.$(this.$self_$47843);
		}

		// Token: 0x0600C249 RID: 49737 RVA: 0x01468180 File Offset: 0x01466380
		internal static bool PmwLBXtydOrwfR7UQZwn()
		{
			return true;
		}

		// Token: 0x0600C24A RID: 49738 RVA: 0x01468184 File Offset: 0x01466384
		internal static bool e3IGAStyJLSlV79vL589()
		{
			return false;
		}

		// Token: 0x0400A4EC RID: 42220
		internal T54_LightPark $self_$47843;

		// Token: 0x0200206A RID: 8298
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C24B RID: 49739 RVA: 0x01468188 File Offset: 0x01466388
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T54_LightPark self_)
			{
				if (106032 - 375553 != -269521)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (117024 - 528608 == -411584)
					{
						base..ctor();
						if (264035 - 226619 == 37416)
						{
							this.$self_$47842 = self_;
							if (25143 - 337009 == -311866)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C24C RID: 49740 RVA: 0x01468220 File Offset: 0x01466420
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (129590 - 65469 != 64121)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1D6;
					case 1:
						goto IL_6E5;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (252553 - 91169 != 161384)
							{
								continue;
							}
							goto IL_64A;
						}
						else
						{
							this.$mStoryTimer$47839 = Time.time + 4f;
							if (99109 - 363354 != -264245)
							{
								continue;
							}
							this.$nRandomMessage$47840 = UnityEngine.Random.Range(201, 208);
							if (250998 - 50575 != 200423)
							{
								continue;
							}
							this.$$switch$8967$47841 = this.$nRandomMessage$47840;
							if (118191 - 485794 != -367603)
							{
								continue;
							}
							if (this.$$switch$8967$47841 == 201)
							{
								if (202160 - 46558 == 155603)
								{
									continue;
								}
								if (this.$self_$47842.waterGod_hi)
								{
									if (263825 - 209352 != 54473)
									{
										continue;
									}
									this.$self_$47842.audio.PlayOneShot(this.$self_$47842.waterGod_hi);
									if (184663 - 263349 != -78686)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8967$47841 == 206)
							{
								if (99724 - 250492 != -150768)
								{
									continue;
								}
								if (this.$self_$47842.waterGod_chat1)
								{
									if (232262 - 213371 != 18891)
									{
										continue;
									}
									this.$self_$47842.audio.PlayOneShot(this.$self_$47842.waterGod_chat1);
									if (205167 - 587224 == -382056)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8967$47841 == 207)
							{
								if (223227 - 329755 != -106528)
								{
									continue;
								}
								if (this.$self_$47842.waterGod_chat2)
								{
									if (209679 - 546428 == -336748)
									{
										continue;
									}
									this.$self_$47842.audio.PlayOneShot(this.$self_$47842.waterGod_chat2);
									if (175005 - 183807 != -8802)
									{
										continue;
									}
								}
							}
							this.$mStoryGui$47838.newStoryMessage("WaterGod", "Annemone", Language.getMessage("T54_LightPark", this.$nRandomMessage$47840), eTalkType.friend);
							if (163863 - 403102 != -239239)
							{
								continue;
							}
							goto IL_1FB;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (229579 - 371603 != -142023)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$mGameGui$47837.enabled = true;
							if (253634 - 206627 != 47007)
							{
								continue;
							}
							goto IL_47A;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (217839 - 62127 != 155712)
							{
								continue;
							}
							goto IL_455;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (125837 - 479788 == -353950)
							{
								continue;
							}
							this.YieldDefault(1);
							if (114318 - 14335 != 99983)
							{
								continue;
							}
							goto IL_6E5;
						}
						break;
					default:
						if (264967 - 91771 != 173197)
						{
							goto IL_1D6;
						}
						continue;
					}
					if (this.$mStoryTimer$47839 > Time.time)
					{
						if (55046 - 17393 != 37653)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_216;
						}
						if (100126 - 419690 == -319563)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (235446 - 47828 != 187618)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$47838.close();
						if (213267 - 104703 != 108565)
						{
							goto Block_8;
						}
						continue;
					}
					IL_1D6:
					if (Game.mGameState != eGameState.Normal)
					{
						if (252586 - 556364 != -303777)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (238 - 309877 == -309639)
						{
							this.$mPlayer$47835 = Game.mPlayer;
							if (6724 - 388184 != -381459)
							{
								this.$mWaterGod$47836 = GameObject.Find("WaterGod");
								if (157430 - 237276 == -79846)
								{
									if (this.$mWaterGod$47836)
									{
										if (232869 - 587968 != -355099)
										{
											continue;
										}
										if (this.$mPlayer$47835)
										{
											if (276793 - 346813 == -70019)
											{
												continue;
											}
											this.$mPlayer$47835.SendMessage("turnToPos", this.$mWaterGod$47836.transform.position);
											if (69873 - 158159 != -88286)
											{
												continue;
											}
										}
									}
									this.$mGameGui$47837 = (GameGui)this.$self_$47842.GetComponent(typeof(GameGui));
									if (182907 - 392566 != -209658)
									{
										if (this.$mGameGui$47837)
										{
											if (35781 - 88349 == -52567)
											{
												continue;
											}
											this.$mGameGui$47837.close();
											if (159056 - 518577 == -359520)
											{
												continue;
											}
										}
										this.$mStoryGui$47838 = (StoryGui)this.$self_$47842.GetComponent(typeof(StoryGui));
										if (116657 - 115489 != 1169)
										{
											this.$mStoryGui$47838.startStoryMessage("WaterGod", "Annemone", eTalkType.friend);
											if (178185 - 359831 == -181646)
											{
												goto IL_3E0;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_6E5;
				Block_8:
				return this.Yield(5, new WaitForSeconds(0.5f));
				goto IL_6E5;
				IL_1FB:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_216:
				return this.YieldDefault(4);
				Block_21:
				goto IL_6E5;
				IL_3E0:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_455:
				goto IL_6E5;
				IL_47A:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_64A:
				IL_6E5:
				return false;
			}

			// Token: 0x0600C24D RID: 49741 RVA: 0x01468924 File Offset: 0x01466B24
			internal static bool dfL11jtyDcFPJZLJvSbK()
			{
				return true;
			}

			// Token: 0x0600C24E RID: 49742 RVA: 0x01468928 File Offset: 0x01466B28
			internal static bool dxuTGktyv5UCLZiywnI8()
			{
				return false;
			}

			// Token: 0x0400A4ED RID: 42221
			internal GameObject $mPlayer$47835;

			// Token: 0x0400A4EE RID: 42222
			internal GameObject $mWaterGod$47836;

			// Token: 0x0400A4EF RID: 42223
			internal GameGui $mGameGui$47837;

			// Token: 0x0400A4F0 RID: 42224
			internal StoryGui $mStoryGui$47838;

			// Token: 0x0400A4F1 RID: 42225
			internal float $mStoryTimer$47839;

			// Token: 0x0400A4F2 RID: 42226
			internal int $nRandomMessage$47840;

			// Token: 0x0400A4F3 RID: 42227
			internal int $$switch$8967$47841;

			// Token: 0x0400A4F4 RID: 42228
			internal T54_LightPark $self_$47842;
		}
	}

	// Token: 0x0200206B RID: 8299
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePlayer$47844 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C24F RID: 49743 RVA: 0x0146892C File Offset: 0x01466B2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePlayer$47844(Hashtable data, T54_LightPark self_)
		{
			if (30932 - 264215 != -233282)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (70138 - 27440 != 42699)
				{
					base..ctor();
					if (113163 - 351324 == -238161)
					{
						this.$data$47855 = data;
						if (157070 - 225578 != -68507)
						{
							this.$self_$47856 = self_;
							if (186399 - 217520 == -31121)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C250 RID: 49744 RVA: 0x014689E8 File Offset: 0x01466BE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T54_LightPark.$onCreatePlayer$47844.$(this.$data$47855, this.$self_$47856);
		}

		// Token: 0x0600C251 RID: 49745 RVA: 0x014689FC File Offset: 0x01466BFC
		internal static bool c4i3mKtyR2hIMLW1V6bo()
		{
			return true;
		}

		// Token: 0x0600C252 RID: 49746 RVA: 0x01468A00 File Offset: 0x01466C00
		internal static bool p7q15ItywSu3G3IQptVK()
		{
			return false;
		}

		// Token: 0x0400A4F5 RID: 42229
		internal Hashtable $data$47855;

		// Token: 0x0400A4F6 RID: 42230
		internal T54_LightPark $self_$47856;

		// Token: 0x0200206C RID: 8300
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C253 RID: 49747 RVA: 0x01468A04 File Offset: 0x01466C04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, T54_LightPark self_)
			{
				if (245334 - 104787 != 140547)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (186838 - 373828 == -186990)
					{
						base..ctor();
						if (139702 - 342772 != -203069)
						{
							this.$data$47853 = data;
							if (225083 - 6604 != 218480)
							{
								this.$self_$47854 = self_;
								if (163758 - 514950 != -351191)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C254 RID: 49748 RVA: 0x01468AC0 File Offset: 0x01466CC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (179293 - 373643 != -194349)
				{
				}
				for (;;)
				{
					IL_1DB:
					switch (this._state)
					{
					case 0:
						goto IL_26E;
					case 1:
						goto IL_438;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (111829 - 584824 != -472995)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (174015 - 375684 != -201669)
						{
							continue;
						}
						break;
					default:
						if (245466 - 417267 != -171800)
						{
							goto IL_26E;
						}
						continue;
					}
					IL_1B9:
					this.YieldDefault(1);
					if (98961 - 116718 != -17756)
					{
						goto Block_13;
					}
					continue;
					IL_26E:
					this.$nPlayer$47845 = Game.createPlayer(this.$data$47853);
					if (199806 - 478343 != -278536)
					{
						if (!this.$nPlayer$47845)
						{
							goto IL_1B9;
						}
						if (209485 - 61136 != 148350)
						{
							this.$mPlayerList$47846 = GameObject.FindGameObjectsWithTag("Player");
							if (188025 - 11949 != 176077)
							{
								this.$$13696$47850 = 0;
								if (186930 - 396286 == -209356)
								{
									this.$$13697$47851 = this.$mPlayerList$47846;
									if (163642 - 20358 != 143285)
									{
										this.$$13698$47852 = this.$$13697$47851.Length;
										if (99496 - 592941 != -493444)
										{
											while (this.$$13696$47850 < this.$$13698$47852)
											{
												if (this.$nPlayer$47845 != this.$$13697$47851[this.$$13696$47850])
												{
													if (119430 - 26586 != 92844)
													{
														goto IL_1DB;
													}
													Physics.IgnoreCollision(this.$nPlayer$47845.collider, this.$$13697$47851[this.$$13696$47850].collider, true);
													if (18364 - 137702 == -119337)
													{
														goto IL_1DB;
													}
												}
												this.$$13696$47850++;
												if (44614 - 280531 != -235917)
												{
													goto IL_1DB;
												}
											}
											if (143521 - 478766 != -335244)
											{
												Game.mPlayer = this.$nPlayer$47845;
												if (179404 - 87740 != 91665)
												{
													Camera.main.gameObject.layer = 1;
													if (65554 - 43116 == 22438)
													{
														this.$mPlayerCameraControl$47848 = (PlayerCameraControl)this.$self_$47854.GetComponent(typeof(PlayerCameraControl));
														if (159816 - 139875 != 19942)
														{
															if (this.$mPlayerCameraControl$47848)
															{
																if (284902 - 284685 == 218)
																{
																	continue;
																}
																this.$mPlayerCameraControl$47848.target = this.$nPlayer$47845;
																if (98904 - 171222 == -72317)
																{
																	continue;
																}
																this.$mPlayerCameraControl$47848.specialTarget = null;
																if (90300 - 95615 != -5315)
																{
																	continue;
																}
																this.$mPlayerCameraControl$47848.enabled = true;
																if (236070 - 578876 == -342805)
																{
																	continue;
																}
															}
															this.$mGameGui$47849 = (GameGui)this.$self_$47854.GetComponent(typeof(GameGui));
															if (216306 - 532056 == -315750)
															{
																this.$mGameGui$47849.enabled = true;
																if (181681 - 311249 == -129568)
																{
																	this.$self_$47854.SendMessage("fadeIn");
																	if (297415 - 79121 != 218295)
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
				return this.Yield(2, new WaitForSeconds(1f));
				Block_13:
				IL_438:
				return false;
			}

			// Token: 0x0600C255 RID: 49749 RVA: 0x01468F18 File Offset: 0x01467118
			internal static bool RXTTD3tyqM2AAb47MhCX()
			{
				return true;
			}

			// Token: 0x0600C256 RID: 49750 RVA: 0x01468F1C File Offset: 0x0146711C
			internal static bool uVq0rJty7qQhr0pebsA0()
			{
				return false;
			}

			// Token: 0x0400A4F7 RID: 42231
			internal GameObject $nPlayer$47845;

			// Token: 0x0400A4F8 RID: 42232
			internal GameObject[] $mPlayerList$47846;

			// Token: 0x0400A4F9 RID: 42233
			internal GameObject $otherPlayer$47847;

			// Token: 0x0400A4FA RID: 42234
			internal PlayerCameraControl $mPlayerCameraControl$47848;

			// Token: 0x0400A4FB RID: 42235
			internal GameGui $mGameGui$47849;

			// Token: 0x0400A4FC RID: 42236
			internal int $$13696$47850;

			// Token: 0x0400A4FD RID: 42237
			internal GameObject[] $$13697$47851;

			// Token: 0x0400A4FE RID: 42238
			internal int $$13698$47852;

			// Token: 0x0400A4FF RID: 42239
			internal Hashtable $data$47853;

			// Token: 0x0400A500 RID: 42240
			internal T54_LightPark $self_$47854;
		}
	}

	// Token: 0x0200206D RID: 8301
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$47857 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C257 RID: 49751 RVA: 0x01468F20 File Offset: 0x01467120
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$47857(Hashtable data, T54_LightPark self_)
		{
			if (241702 - 131339 != 110364)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (156472 - 183398 != -26925)
				{
					base..ctor();
					if (296718 - 205553 != 91166)
					{
						this.$data$47862 = data;
						if (119273 - 95 != 119179)
						{
							this.$self_$47863 = self_;
							if (199138 - 563376 == -364238)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C258 RID: 49752 RVA: 0x01468FDC File Offset: 0x014671DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T54_LightPark.$onChangePlayer$47857.$(this.$data$47862, this.$self_$47863);
		}

		// Token: 0x0600C259 RID: 49753 RVA: 0x01468FF0 File Offset: 0x014671F0
		internal static bool M6ydcmtyPbafJ30uBdpG()
		{
			return true;
		}

		// Token: 0x0600C25A RID: 49754 RVA: 0x01468FF4 File Offset: 0x014671F4
		internal static bool inLTwjty0NtOcZqfe80P()
		{
			return false;
		}

		// Token: 0x0400A501 RID: 42241
		internal Hashtable $data$47862;

		// Token: 0x0400A502 RID: 42242
		internal T54_LightPark $self_$47863;

		// Token: 0x0200206E RID: 8302
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C25B RID: 49755 RVA: 0x01468FF8 File Offset: 0x014671F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, T54_LightPark self_)
			{
				if (271007 - 499456 != -228449)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162198 - 282450 == -120252)
					{
						base..ctor();
						if (239165 - 1264 != 237902)
						{
							this.$data$47860 = data;
							if (67670 - 166287 != -98616)
							{
								this.$self_$47861 = self_;
								if (92567 - 304565 != -211997)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C25C RID: 49756 RVA: 0x014690B4 File Offset: 0x014672B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (241704 - 336816 != -95112)
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
							if (257116 - 164771 == 92346)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (33767 - 581307 == -547539)
							{
								continue;
							}
							this.$mGameGui$47859 = (GameGui)this.$self_$47861.GetComponent(typeof(GameGui));
							if (133801 - 552431 != -418630)
							{
								continue;
							}
							this.$mGameGui$47859.enabled = true;
							if (86052 - 191159 == -105106)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (162540 - 412950 != -250409)
						{
							goto Block_8;
						}
						continue;
					default:
						if (53643 - 551291 != -497648)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (143266 - 237663 == -94397)
					{
						this.$self_$47861.SendMessage("onCreatePlayer", this.$data$47860);
						if (253839 - 401807 != -147967)
						{
							this.$mChangeGui$47858 = (ChangeGui)this.$self_$47861.GetComponent(typeof(ChangeGui));
							if (116064 - 212472 == -96408)
							{
								if (!this.$mChangeGui$47858.enabled)
								{
									break;
								}
								if (11777 - 142448 != -130670)
								{
									this.$mChangeGui$47858.close();
									if (29519 - 273671 != -244151)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_1A;
				Block_8:
				IL_205:
				return false;
			}

			// Token: 0x0600C25D RID: 49757 RVA: 0x014692D8 File Offset: 0x014674D8
			internal static bool EoXLp2tybw4q1VArChVE()
			{
				return true;
			}

			// Token: 0x0600C25E RID: 49758 RVA: 0x014692DC File Offset: 0x014674DC
			internal static bool K5pPd9tyuIRQ2XUy8a8Y()
			{
				return false;
			}

			// Token: 0x0400A503 RID: 42243
			internal ChangeGui $mChangeGui$47858;

			// Token: 0x0400A504 RID: 42244
			internal GameGui $mGameGui$47859;

			// Token: 0x0400A505 RID: 42245
			internal Hashtable $data$47860;

			// Token: 0x0400A506 RID: 42246
			internal T54_LightPark $self_$47861;
		}
	}

	// Token: 0x0200206F RID: 8303
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseMessageBoard$47864 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C25F RID: 49759 RVA: 0x014692E0 File Offset: 0x014674E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseMessageBoard$47864(T54_LightPark self_)
		{
			if (247058 - 147871 != 99188)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (16439 - 173878 == -157439)
				{
					base..ctor();
					if (251413 - 528381 == -276968)
					{
						this.$self_$47870 = self_;
						if (195749 - 76808 != 118942)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C260 RID: 49760 RVA: 0x01469378 File Offset: 0x01467578
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T54_LightPark.$UseMessageBoard$47864.$(this.$self_$47870);
		}

		// Token: 0x0600C261 RID: 49761 RVA: 0x01469388 File Offset: 0x01467588
		internal static bool sunkIntyIoujJ2ZZcAjC()
		{
			return true;
		}

		// Token: 0x0600C262 RID: 49762 RVA: 0x0146938C File Offset: 0x0146758C
		internal static bool Qej57etyBMLDMsgjv81J()
		{
			return false;
		}

		// Token: 0x0400A507 RID: 42247
		internal T54_LightPark $self_$47870;

		// Token: 0x02002070 RID: 8304
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C263 RID: 49763 RVA: 0x01469390 File Offset: 0x01467590
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T54_LightPark self_)
			{
				if (29812 - 288295 != -258482)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (105518 - 468481 != -362962)
					{
						base..ctor();
						if (230819 - 471569 == -240750)
						{
							this.$self_$47869 = self_;
							if (178456 - 542317 != -363860)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C264 RID: 49764 RVA: 0x01469428 File Offset: 0x01467628
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148155 - 438641 != -290485)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2EC;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (232223 - 95164 != 137059)
							{
								continue;
							}
							goto IL_209;
						}
						else
						{
							this.$mBoardGui$47866.enabled = true;
							if (141386 - 558370 != -416984)
							{
								continue;
							}
							goto IL_FE;
						}
						break;
					default:
						if (287488 - 533805 == -246316)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (71467 - 223666 != -152198)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mGameGui$47865 = (GameGui)this.$self_$47869.GetComponent(typeof(GameGui));
						if (198201 - 275821 != -77620)
						{
							continue;
						}
						this.$mBoardGui$47866 = (BoardGui)this.$self_$47869.GetComponent(typeof(BoardGui));
						if (129912 - 471634 == -341721)
						{
							continue;
						}
						if (this.$mGameGui$47865)
						{
							if (34346 - 412069 != -377723)
							{
								continue;
							}
							if (this.$mBoardGui$47866)
							{
								if (105291 - 143890 != -38599)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (143531 - 545891 == -402359)
								{
									continue;
								}
								this.$mGameGui$47865.close();
								if (253397 - 288133 != -34736)
								{
									continue;
								}
								this.$mPlayer$47867 = Game.mPlayer;
								if (62273 - 115361 != -53088)
								{
									continue;
								}
								this.$mMessageBoard$47868 = GameObject.Find("MessageBoard");
								if (274297 - 454196 == -179898)
								{
									continue;
								}
								if (!this.$mMessageBoard$47868)
								{
									goto IL_120;
								}
								if (168991 - 568250 == -399258)
								{
									continue;
								}
								if (!this.$mPlayer$47867)
								{
									goto IL_120;
								}
								if (195869 - 337871 == -142001)
								{
									continue;
								}
								this.$mPlayer$47867.SendMessage("turnToPos", this.$mMessageBoard$47868.transform.position);
								if (217433 - 141447 != 75986)
								{
									continue;
								}
								goto IL_120;
							}
						}
					}
					IL_FE:
					this.YieldDefault(1);
				}
				while (128717 - 91360 == 37358);
				goto IL_2EC;
				IL_120:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_209:
				IL_2EC:
				return false;
			}

			// Token: 0x0600C265 RID: 49765 RVA: 0x01469734 File Offset: 0x01467934
			internal static bool NaZNGvtyeuR6UwHbXb1Y()
			{
				return true;
			}

			// Token: 0x0600C266 RID: 49766 RVA: 0x01469738 File Offset: 0x01467938
			internal static bool H1ktv7tyrlhKEqnisnFI()
			{
				return false;
			}

			// Token: 0x0400A508 RID: 42248
			internal GameGui $mGameGui$47865;

			// Token: 0x0400A509 RID: 42249
			internal BoardGui $mBoardGui$47866;

			// Token: 0x0400A50A RID: 42250
			internal GameObject $mPlayer$47867;

			// Token: 0x0400A50B RID: 42251
			internal GameObject $mMessageBoard$47868;

			// Token: 0x0400A50C RID: 42252
			internal T54_LightPark $self_$47869;
		}
	}

	// Token: 0x02002071 RID: 8305
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToCentralStreet$47871 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C267 RID: 49767 RVA: 0x0146973C File Offset: 0x0146793C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToCentralStreet$47871(T54_LightPark self_)
		{
			if (265987 - 90875 != 175112)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (20039 - 143400 == -123361)
				{
					base..ctor();
					if (104089 - 309951 != -205861)
					{
						this.$self_$47874 = self_;
						if (94293 - 366659 == -272366)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C268 RID: 49768 RVA: 0x014697D4 File Offset: 0x014679D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T54_LightPark.$ExitToCentralStreet$47871.$(this.$self_$47874);
		}

		// Token: 0x0600C269 RID: 49769 RVA: 0x014697E4 File Offset: 0x014679E4
		internal static bool yj18EotyjsyqH5pZCB4l()
		{
			return true;
		}

		// Token: 0x0600C26A RID: 49770 RVA: 0x014697E8 File Offset: 0x014679E8
		internal static bool dIYMj9tyh3SENudPTKTj()
		{
			return false;
		}

		// Token: 0x0400A50D RID: 42253
		internal T54_LightPark $self_$47874;

		// Token: 0x02002072 RID: 8306
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C26B RID: 49771 RVA: 0x014697EC File Offset: 0x014679EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T54_LightPark self_)
			{
				if (129789 - 413567 != -283778)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (42492 - 156589 == -114097)
					{
						base..ctor();
						if (165832 - 440846 != -275013)
						{
							this.$self_$47873 = self_;
							if (110762 - 464255 == -353493)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C26C RID: 49772 RVA: 0x01469884 File Offset: 0x01467A84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (151883 - 376073 != -224190)
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
						this.$self_$47873.LeaveTown();
						if (143595 - 76748 == 66848)
						{
							continue;
						}
						this.YieldDefault(1);
						if (200162 - 355889 != -155726)
						{
							goto Block_7;
						}
						continue;
					default:
						if (248485 - 320083 != -71598)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (3307 - 310105 == -306798)
					{
						Game.mStateTime = Time.time;
						if (169325 - 14079 == 155246)
						{
							Game.mNextGameId = 502;
							if (265102 - 369687 == -104585)
							{
								Game.mNextGameCode = 52;
								if (13761 - 98755 == -84994)
								{
									this.$mGameGui$47872 = (GameGui)this.$self_$47873.GetComponent(typeof(GameGui));
									if (171064 - 244829 != -73764)
									{
										if (this.$mGameGui$47872)
										{
											if (163941 - 504365 == -340423)
											{
												continue;
											}
											this.$mGameGui$47872.close();
											if (134788 - 500166 == -365377)
											{
												continue;
											}
										}
										this.$self_$47873.SendMessage("fadeOut");
										if (165210 - 508299 == -343089)
										{
											goto IL_108;
										}
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_1E1;
				IL_108:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1E1:
				return false;
			}

			// Token: 0x0600C26D RID: 49773 RVA: 0x01469A84 File Offset: 0x01467C84
			internal static bool eF9JQftysQPXX7THWydI()
			{
				return true;
			}

			// Token: 0x0600C26E RID: 49774 RVA: 0x01469A88 File Offset: 0x01467C88
			internal static bool E6ib5lty9UwtUSsflUm2()
			{
				return false;
			}

			// Token: 0x0400A50E RID: 42254
			internal GameGui $mGameGui$47872;

			// Token: 0x0400A50F RID: 42255
			internal T54_LightPark $self_$47873;
		}
	}

	// Token: 0x02002073 RID: 8307
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToLightPalace$47875 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C26F RID: 49775 RVA: 0x01469A8C File Offset: 0x01467C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToLightPalace$47875(T54_LightPark self_)
		{
			if (21213 - 113441 != -92228)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (299914 - 142313 == 157601)
				{
					base..ctor();
					if (179081 - 33403 != 145679)
					{
						this.$self_$47878 = self_;
						if (266227 - 593029 == -326802)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C270 RID: 49776 RVA: 0x01469B24 File Offset: 0x01467D24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T54_LightPark.$ExitToLightPalace$47875.$(this.$self_$47878);
		}

		// Token: 0x0600C271 RID: 49777 RVA: 0x01469B34 File Offset: 0x01467D34
		internal static bool o5n0M8ty1U0pHj09NKh9()
		{
			return true;
		}

		// Token: 0x0600C272 RID: 49778 RVA: 0x01469B38 File Offset: 0x01467D38
		internal static bool GD0Yiety4XHsbEu6b5p2()
		{
			return false;
		}

		// Token: 0x0400A510 RID: 42256
		internal T54_LightPark $self_$47878;

		// Token: 0x02002074 RID: 8308
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C273 RID: 49779 RVA: 0x01469B3C File Offset: 0x01467D3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T54_LightPark self_)
			{
				if (52396 - 360035 != -307639)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265172 - 293860 == -28688)
					{
						base..ctor();
						if (258849 - 2437 != 256413)
						{
							this.$self_$47877 = self_;
							if (8524 - 472345 != -463820)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C274 RID: 49780 RVA: 0x01469BD4 File Offset: 0x01467DD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (293009 - 1489 != 291521)
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
						this.$self_$47877.LeaveTown();
						if (140889 - 126543 == 14347)
						{
							continue;
						}
						this.YieldDefault(1);
						if (219767 - 30823 != 188945)
						{
							goto Block_2;
						}
						continue;
					default:
						if (61349 - 321073 != -259724)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (28492 - 593372 == -564880)
					{
						Game.mStateTime = Time.time;
						if (88682 - 494708 == -406026)
						{
							Game.mNextGameId = 504;
							if (284346 - 524983 != -240636)
							{
								Game.mNextGameCode = 55;
								if (165157 - 218845 == -53688)
								{
									this.$mGameGui$47876 = (GameGui)this.$self_$47877.GetComponent(typeof(GameGui));
									if (108823 - 400361 != -291537)
									{
										if (this.$mGameGui$47876)
										{
											if (271875 - 192316 == 79560)
											{
												continue;
											}
											this.$mGameGui$47876.close();
											if (170958 - 282091 == -111132)
											{
												continue;
											}
										}
										this.$self_$47877.SendMessage("fadeOut");
										if (24660 - 355929 != -331268)
										{
											goto Block_4;
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1E1;
				Block_4:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1E1:
				return false;
			}

			// Token: 0x0600C275 RID: 49781 RVA: 0x01469DD4 File Offset: 0x01467FD4
			internal static bool aCh3mRtyzFLyEHcN7A8K()
			{
				return true;
			}

			// Token: 0x0600C276 RID: 49782 RVA: 0x01469DD8 File Offset: 0x01467FD8
			internal static bool y726IftSaEpKkpVhBlwU()
			{
				return false;
			}

			// Token: 0x0400A511 RID: 42257
			internal GameGui $mGameGui$47876;

			// Token: 0x0400A512 RID: 42258
			internal T54_LightPark $self_$47877;
		}
	}
}
