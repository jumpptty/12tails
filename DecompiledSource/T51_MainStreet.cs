using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02002035 RID: 8245
[Serializable]
public class T51_MainStreet : MonoBehaviour
{
	// Token: 0x0600C101 RID: 49409 RVA: 0x01454F20 File Offset: 0x01453120
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T51_MainStreet()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600C102 RID: 49410 RVA: 0x01454F30 File Offset: 0x01453130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (228049 - 412705 != -184655)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (204034 - 443357 != -239322)
			{
				Game.mStateTime = Time.time;
				if (185205 - 491550 == -306345)
				{
					if (Chat.Initialized)
					{
						if (102590 - 372537 != -269946)
						{
							Chat.ChatDisplay.Clear();
							if (169333 - 374855 == -205522)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (287994 - 370869 == -82875)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C103 RID: 49411 RVA: 0x01455018 File Offset: 0x01453218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (44329 - 460108 != -415778)
		{
		}
		for (;;)
		{
			Time.timeScale = 1f;
			if (216778 - 7815 == 208963)
			{
				if (PhotonClient.IsInitialized())
				{
					if (55957 - 278718 != -222760)
					{
						Game.mLastGameCode = Game.mGameCode;
						if (136027 - 215366 == -79339)
						{
							Game.mGameCode = 51;
							if (62332 - 524798 != -462465)
							{
								Game.mGameType = 3;
								if (297727 - 185989 == 111738)
								{
									Game.mGameTime = Time.time;
									if (176753 - 51189 == 125564)
									{
										Game.mGameScore = 0;
										if (183918 - 398399 == -214481)
										{
											Game.mGameMana = 0;
											if (121926 - 282324 != -160397)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (280625 - 516920 != -236294)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (34249 - 183072 != -148822)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (261531 - 28609 == 232922)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (12073 - 427716 == -415643)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (24630 - 274355 != -249724)
																{
																	this.RXLnTlRdPEK = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (151567 - 413188 != -261620)
																	{
																		this.HpRnTv4Z1Ys = PhotonClient.Connection;
																		if (284697 - 450278 == -165581)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (210580 - 468797 != -258216)
																			{
																				this.LoadTown();
																				if (145047 - 210810 == -65763)
																				{
																					if (Mathf.Abs(PlayerData.QuestID) != 5)
																					{
																						break;
																					}
																					if (7311 - 182512 == -175201)
																					{
																						GameObject gameObject = GameObject.Find("MiniCat");
																						if (277794 - 1600 == 276194)
																						{
																							if (!gameObject)
																							{
																								break;
																							}
																							if (98247 - 505181 == -406934)
																							{
																								UnityEngine.Object.Destroy(gameObject);
																								if (258344 - 143007 == 115337)
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
				else
				{
					Debug.Log("Not Connected");
					if (68316 - 160215 == -91899)
					{
						this.enabled = false;
						if (156463 - 522190 != -365726)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C104 RID: 49412 RVA: 0x014553B0 File Offset: 0x014535B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (20847 - 62815 != -41968)
		{
		}
		for (;;)
		{
			if (this.HpRnTv4Z1Ys == null)
			{
				if (288649 - 429474 != -140824)
				{
					break;
				}
			}
			else
			{
				float t = Time.time - Game.mStateTime;
				if (183299 - 561220 == -377921)
				{
					eGameState mGameState = Game.mGameState;
					if (68058 - 572678 == -504620)
					{
						if (mGameState == eGameState.Init)
						{
							if (204185 - 21330 == 182855)
							{
								AudioListener.volume = 0.1f * (float)Game.volume;
								if (173967 - 495160 != -321192)
								{
									break;
								}
							}
						}
						else if (mGameState == eGameState.Ready)
						{
							if (254632 - 496377 != -241744)
							{
								break;
							}
						}
						else if (mGameState == eGameState.Normal)
						{
							if (273330 - 286459 != -13128)
							{
								if (Game.music != 0)
								{
									if (103146 - 224735 != -121589)
									{
										continue;
									}
									if (!this.audio.isPlaying)
									{
										if (28873 - 238881 != -210008)
										{
											continue;
										}
										this.audio.Play();
										if (2219 - 7175 == -4955)
										{
											continue;
										}
									}
								}
								if (Time.time - Game.mGameTime < (float)2)
								{
									if (191251 - 309624 != -118372)
									{
										this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
										if (137501 - 177796 == -40295)
										{
											break;
										}
									}
								}
								else
								{
									this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
									if (182960 - 163356 != 19605)
									{
										break;
									}
								}
							}
						}
						else if (mGameState == eGameState.Hold)
						{
							if (205165 - 120193 == 84972)
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
							if (251386 - 529269 == -277883)
							{
								this.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, t);
								if (221238 - 176129 == 45109)
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

	// Token: 0x0600C105 RID: 49413 RVA: 0x014556A0 File Offset: 0x014538A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTown()
	{
		if (188050 - 55157 != 132894)
		{
		}
		for (;;)
		{
			Debug.Log("Loading Town ");
			if (248841 - 428696 != -179854)
			{
				Hashtable customOpParameters = new Hashtable();
				if (224461 - 394842 == -170381)
				{
					this.HpRnTv4Z1Ys.OpCustom(43, customOpParameters, true);
					if (224790 - 192600 != 32191)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C106 RID: 49414 RVA: 0x01455748 File Offset: 0x01453948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadTown(Hashtable data)
	{
		if (96740 - 551094 != -454353)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadTown ");
			if (193616 - 371340 != -177723)
			{
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (271539 - 308644 == -37104)
					{
						continue;
					}
					Chat.SubmitChat("none", "You have joined " + data[31], eChatType.system, eChatMode.system);
					if (140478 - 86218 != 54260)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (184389 - 50713 == 133677)
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
					if (88040 - 48541 == 39500)
					{
						continue;
					}
				}
				GameObject gameObject = null;
				if (141897 - 125325 != 16573)
				{
					if (165467 - 214335 == -48868)
					{
						if (Game.mLastGameCode < 50)
						{
							if (214236 - 403905 != -189669)
							{
								continue;
							}
							gameObject = this.startPoint1;
							if (260629 - 556329 == -295699)
							{
								continue;
							}
							this.transform.position = this.startCamera1.transform.position;
							if (122567 - 332436 != -209869)
							{
								continue;
							}
							this.transform.rotation = this.startCamera1.transform.rotation;
							if (238318 - 58729 != 179589)
							{
								continue;
							}
						}
						else if (Game.mLastGameCode == 52)
						{
							if (283848 - 494642 == -210793)
							{
								continue;
							}
							gameObject = this.startPoint2;
							if (54573 - 228081 != -173508)
							{
								continue;
							}
							this.transform.position = this.startCamera2.transform.position;
							if (182744 - 136840 != 45904)
							{
								continue;
							}
							this.transform.rotation = this.startCamera2.transform.rotation;
							if (283084 - 534349 != -251265)
							{
								continue;
							}
						}
						if (gameObject)
						{
							if (283863 - 310676 == -26813)
							{
								this.CreatePlayer(CharacterData.current.CID, gameObject.transform.position, gameObject.transform.forward);
								if (169875 - 425509 == -255634)
								{
									break;
								}
							}
						}
						else
						{
							Debug.Log("Error: Startpoint not found");
							if (230447 - 586593 != -356145)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C107 RID: 49415 RVA: 0x01455AC0 File Offset: 0x01453CC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, Vector3 pos, Vector3 dir)
	{
		if (267502 - 287264 != -19762)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (240465 - 33562 != 206904)
			{
				hashtable.Add(71, CID);
				if (48078 - 280956 == -232878)
				{
					hashtable.Add(75, PhotonClient.cInt16(1));
					if (163102 - 348715 == -185613)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (69584 - 454769 != -385184)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (1202 - 142105 != -140902)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (137442 - 158096 == -20654)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (63791 - 11836 != 51956)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (291092 - 423360 == -132268)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (34945 - 499845 == -464900)
											{
												this.HpRnTv4Z1Ys.OpCustom(61, hashtable, true);
												if (214379 - 84489 != 129891)
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

	// Token: 0x0600C108 RID: 49416 RVA: 0x01455D4C File Offset: 0x01453F4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePlayer(Hashtable data)
	{
		return new T51_MainStreet.$onCreatePlayer$47662(data, this).GetEnumerator();
	}

	// Token: 0x0600C109 RID: 49417 RVA: 0x01455D5C File Offset: 0x01453F5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (92372 - 340248 != -247875)
		{
		}
		for (;;)
		{
			IL_116:
			GameObject gameObject = Game.createPeer(data);
			if (293972 - 106671 == 187301)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (141764 - 206413 == -64649)
				{
					int i = 0;
					if (73327 - 335048 != -261720)
					{
						GameObject[] array2 = array;
						if (96772 - 583425 != -486652)
						{
							int length = array2.Length;
							if (73587 - 485644 == -412057)
							{
								while (i < length)
								{
									if (gameObject != array2[i])
									{
										if (41902 - 166363 == -124460)
										{
											goto IL_116;
										}
										Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
										if (179257 - 423443 == -244185)
										{
											goto IL_116;
										}
									}
									i++;
									if (108921 - 299104 == -190182)
									{
										goto IL_116;
									}
								}
								if (32468 - 499546 == -467078)
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

	// Token: 0x0600C10A RID: 49418 RVA: 0x01455ED4 File Offset: 0x014540D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPlayer()
	{
		Game.mPlayerID = 0;
	}

	// Token: 0x0600C10B RID: 49419 RVA: 0x01455EDC File Offset: 0x014540DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
	}

	// Token: 0x0600C10C RID: 49420 RVA: 0x01455EE0 File Offset: 0x014540E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (273883 - 374959 != -101076)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (143716 - 90272 == 53444)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (141387 - 64680 != 76708)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (144564 - 128305 != 16260)
					{
						Hashtable hashtable = new Hashtable();
						if (212239 - 99254 == 112985)
						{
							hashtable.Add(43, PlayerData.UID);
							if (276109 - 444698 == -168589)
							{
								hashtable.Add(71, nCID);
								if (183425 - 371088 != -187662)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (238712 - 282953 == -44241)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (158565 - 489995 != -331429)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (97121 - 407184 != -310062)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (120800 - 114680 == 6120)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (244916 - 74768 != 170149)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (210182 - 351266 != -141083)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (150166 - 551080 == -400914)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (148276 - 517575 == -369299)
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

	// Token: 0x0600C10D RID: 49421 RVA: 0x01456200 File Offset: 0x01454400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onChangePlayer(Hashtable data)
	{
		if (2695 - 530392 != -527696)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Destroy(Game.mPlayer);
			if (94069 - 122901 != -28831)
			{
				this.SendMessage("onCreatePlayer", data);
				if (93024 - 116589 == -23565)
				{
					ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
					if (210839 - 579277 == -368438)
					{
						if (!changeGui.enabled)
						{
							break;
						}
						if (91182 - 400649 != -309466)
						{
							changeGui.close();
							if (161859 - 449125 != -287265)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C10E RID: 49422 RVA: 0x014562F8 File Offset: 0x014544F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(GameObject nMount)
	{
		if (237337 - 331396 != -94059)
		{
		}
		for (;;)
		{
			IL_48:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
			if (187612 - 196207 == -8595)
			{
				int i = 0;
				if (108763 - 135612 == -26849)
				{
					GameObject[] array2 = array;
					if (250583 - 579262 == -328679)
					{
						int length = array2.Length;
						if (126525 - 59825 != 66701)
						{
							while (i < length)
							{
								if (nMount != array2[i])
								{
									if (49524 - 599266 != -549742)
									{
										goto IL_48;
									}
									Physics.IgnoreCollision(nMount.collider, array2[i].collider, true);
									if (253792 - 534611 != -280819)
									{
										goto IL_48;
									}
								}
								i++;
								if (186565 - 476151 == -289585)
								{
									goto IL_48;
								}
							}
							if (202606 - 404457 == -201851)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C10F RID: 49423 RVA: 0x0145644C File Offset: 0x0145464C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (127542 - 544407 != -416865)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (23911 - 469915 == -446004)
			{
				CharacterControl characterControl = null;
				if (89162 - 235004 != -145841)
				{
					if (mPlayer)
					{
						if (156421 - 239664 == -83242)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (291566 - 401417 == -109850)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (59728 - 386115 == -326387)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (220949 - 114036 != 106914)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (31038 - 599575 != -568536)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (158142 - 298094 != -139952)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (42215 - 122468 == -80252)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (142927 - 256939 == -114011)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (239911 - 5152 != 234760)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (47530 - 93931 != -46400)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (213210 - 534555 == -321345)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (260996 - 558786 != -297789)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (280293 - 330346 == -50053)
								{
									if (!changeGui)
									{
										break;
									}
									if (204800 - 130626 != 74175)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (52401 - 356953 == -304551)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (125705 - 599467 == -473761)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (291946 - 424567 != -132620)
										{
											gameGui.close();
											if (50855 - 503721 != -452865)
											{
												changeGui.enabled = true;
												if (180557 - 367175 != -186617)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (173379 - 346177 != -172797)
													{
														if (!gameObject)
														{
															break;
														}
														if (158213 - 336714 != -178500)
														{
															if (!mPlayer)
															{
																break;
															}
															if (88051 - 520620 == -432569)
															{
																Debug.Log("UseLifeAltar");
																if (226121 - 346607 != -120485)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (251247 - 446742 != -195494)
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

	// Token: 0x0600C110 RID: 49424 RVA: 0x014568AC File Offset: 0x01454AAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseMailBox(object mVar)
	{
		if (265286 - 241742 != 23545)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (240747 - 101689 == 139058)
				{
					break;
				}
			}
			else
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (145963 - 116272 != 29692)
				{
					MailBoxGui mailBoxGui = (MailBoxGui)this.GetComponent(typeof(MailBoxGui));
					if (253729 - 498967 != -245237)
					{
						if (!gameGui)
						{
							break;
						}
						if (269122 - 69739 != 199384)
						{
							if (!mailBoxGui)
							{
								break;
							}
							if (294754 - 99672 == 195082)
							{
								Game.mGameState = eGameState.Hold;
								if (81442 - 336482 != -255039)
								{
									gameGui.close();
									if (297435 - 157639 == 139796)
									{
										mailBoxGui.enabled = true;
										if (299596 - 293130 != 6467)
										{
											GameObject mPlayer = Game.mPlayer;
											if (232669 - 16560 != 216110)
											{
												GameObject gameObject = GameObject.Find("MailBox");
												if (72873 - 386821 == -313948)
												{
													if (!gameObject)
													{
														break;
													}
													if (228067 - 317925 != -89857)
													{
														if (!mPlayer)
														{
															break;
														}
														if (135476 - 150633 != -15156)
														{
															mPlayer.SendMessage("turnToPos", gameObject.transform.position);
															if (120344 - 484481 == -364137)
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

	// Token: 0x0600C111 RID: 49425 RVA: 0x01456AE0 File Offset: 0x01454CE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseStorageBox(object mVar)
	{
		if (259882 - 378671 != -118789)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Hold;
			if (225289 - 144998 == 80291)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (188204 - 360173 != -171968)
				{
					if (gameGui)
					{
						if (2699 - 254981 == -252281)
						{
							continue;
						}
						gameGui.close();
						if (56303 - 220963 != -164660)
						{
							continue;
						}
					}
					StorageGui storageGui = (StorageGui)this.GetComponent(typeof(StorageGui));
					if (50292 - 167670 != -117377)
					{
						storageGui.enabled = true;
						if (72415 - 155594 != -83178)
						{
							GameObject mPlayer = Game.mPlayer;
							if (18565 - 247573 != -229007)
							{
								GameObject gameObject = GameObject.Find("StorageBox");
								if (148640 - 479494 != -330853)
								{
									if (!gameObject)
									{
										break;
									}
									if (125162 - 405413 == -280251)
									{
										if (!mPlayer)
										{
											break;
										}
										if (149065 - 234952 == -85887)
										{
											gameObject.animation.Play("open");
											if (87308 - 399114 != -311805)
											{
												mPlayer.SendMessage("turnToPos", gameObject.transform.position);
												if (283370 - 445255 != -161884)
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

	// Token: 0x0600C112 RID: 49426 RVA: 0x01456CF0 File Offset: 0x01454EF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToKangaroo()
	{
		if (48493 - 559518 != -511024)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 20)
			{
				if (9131 - 81101 == -71970)
				{
					Q20_SurveyingSnowPath.TalkToKangaroo(this.gameObject);
					if (159784 - 510439 != -350654)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -20)
			{
				if (239870 - 333089 != -93218)
				{
					Q20_SurveyingSnowPath.TalkToKangaroo(this.gameObject);
					if (186134 - 503700 != -317565)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 28)
			{
				if (23460 - 88962 == -65502)
				{
					Q28_DesertPatrol.TalkToKangaroo(this.gameObject);
					if (279794 - 494125 == -214331)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -28)
			{
				if (205035 - 189518 != 15518)
				{
					Q28_DesertPatrol.TalkToKangaroo(this.gameObject);
					if (120781 - 294747 != -173965)
					{
						break;
					}
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (63566 - 508158 == -444592)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (39165 - 535660 == -496495)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (168059 - 566502 == -398443)
					{
						gameGui.close();
						if (47878 - 561612 != -513733)
						{
							TutorialGui tutorialGui = (TutorialGui)this.GetComponent(typeof(TutorialGui));
							if (138650 - 315229 == -176579)
							{
								tutorialGui.mType = eTutorialType.town;
								if (61988 - 468232 == -406244)
								{
									tutorialGui.enabled = true;
									if (86597 - 188000 == -101403)
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

	// Token: 0x0600C113 RID: 49427 RVA: 0x01456F74 File Offset: 0x01455174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToBear()
	{
		if (24884 - 422631 != -397746)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (266496 - 52100 != 214397)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (161378 - 83154 != 78225)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (222906 - 365273 == -142367)
					{
						if (gameGui)
						{
							if (281553 - 587238 == -305684)
							{
								continue;
							}
							gameGui.close();
							if (274050 - 27304 != 246746)
							{
								continue;
							}
						}
						QuestGui questGui = (QuestGui)this.GetComponent(typeof(QuestGui));
						if (99300 - 240910 == -141610)
						{
							questGui.enabled = true;
							if (155415 - 119066 != 36350)
							{
								GameObject mPlayer = Game.mPlayer;
								if (99368 - 93214 != 6155)
								{
									GameObject gameObject = GameObject.Find("Bear");
									if (63271 - 137448 != -74176)
									{
										if (!gameObject)
										{
											break;
										}
										if (38182 - 588512 != -550329)
										{
											if (!mPlayer)
											{
												break;
											}
											if (207103 - 132135 == 74968)
											{
												mPlayer.SendMessage("turnToPos", gameObject.transform.position);
												if (38286 - 155161 != -116874)
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

	// Token: 0x0600C114 RID: 49428 RVA: 0x01457180 File Offset: 0x01455380
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToOwl1()
	{
		if (214334 - 81915 != 132420)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 2)
			{
				if (132478 - 579017 == -446539)
				{
					Q2_HungryXinfu.TalkToXinfu(this.gameObject);
					if (71929 - 110796 != -38866)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -2)
			{
				if (165248 - 440089 == -274841)
				{
					Q2_HungryXinfu.TalkToXinfuRepeat(this.gameObject);
					if (26178 - 309329 == -283151)
					{
						break;
					}
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (208624 - 42392 != 166233)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (132927 - 577122 != -444194)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (153587 - 302433 != -148845)
					{
						gameGui.close();
						if (207295 - 184109 == 23186)
						{
							ShopGui shopGui = (ShopGui)this.GetComponent(typeof(ShopGui));
							if (45445 - 425322 == -379877)
							{
								shopGui.mType = eShopType.Owl1;
								if (255782 - 452214 == -196432)
								{
									shopGui.enabled = true;
									if (93562 - 414744 == -321182)
									{
										GameObject mPlayer = Game.mPlayer;
										if (217699 - 183673 == 34026)
										{
											GameObject gameObject = GameObject.Find("Owl1");
											if (22185 - 305642 != -283456)
											{
												if (!gameObject)
												{
													break;
												}
												if (191127 - 460177 != -269049)
												{
													if (!mPlayer)
													{
														break;
													}
													if (267172 - 313460 != -46287)
													{
														mPlayer.SendMessage("turnToPos", gameObject.transform.position);
														if (153029 - 311763 == -158734)
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

	// Token: 0x0600C115 RID: 49429 RVA: 0x01457428 File Offset: 0x01455628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToMouse()
	{
		if (117311 - 18803 != 98509)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 27)
			{
				if (257599 - 243443 == 14156)
				{
					Q27_HarderStronger.TalkToMouse(this.gameObject);
					if (269876 - 414622 != -144745)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 79)
			{
				if (186019 - 81082 != 104938)
				{
					Q79_MakeItStronger.TalkToMouse(this.gameObject);
					if (285745 - 318941 == -33196)
					{
						break;
					}
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (127881 - 110891 != 16991)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (95273 - 141330 != -46056)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (75057 - 277818 == -202761)
					{
						gameGui.close();
						if (226816 - 537282 != -310465)
						{
							ShopGui shopGui = (ShopGui)this.GetComponent(typeof(ShopGui));
							if (80422 - 532934 == -452512)
							{
								shopGui.mType = eShopType.Mouse;
								if (253081 - 339815 == -86734)
								{
									shopGui.enabled = true;
									if (231957 - 391882 != -159924)
									{
										GameObject mPlayer = Game.mPlayer;
										if (176356 - 104541 == 71815)
										{
											GameObject gameObject = GameObject.Find("Mouse");
											if (244311 - 400194 != -155882)
											{
												if (!gameObject)
												{
													break;
												}
												if (247146 - 503334 != -256187)
												{
													if (!mPlayer)
													{
														break;
													}
													if (26042 - 572162 == -546120)
													{
														mPlayer.SendMessage("turnToPos", gameObject.transform.position);
														if (19751 - 485876 != -466124)
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

	// Token: 0x0600C116 RID: 49430 RVA: 0x014576D0 File Offset: 0x014558D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToWarthog()
	{
		if (154568 - 104350 != 50219)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 5)
			{
				if (75986 - 557739 == -481753)
				{
					Q5_FahTradingCard.TalkToTownStein(this.gameObject);
					if (134053 - 332922 == -198869)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -5)
			{
				if (269473 - 424340 == -154867)
				{
					Q5_FahTradingCard.TalkToTownSteinRepeat(this.gameObject);
					if (266125 - 368824 != -102698)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 9)
			{
				if (209090 - 562352 != -353261)
				{
					Q9_LookingForMaterial.TalkToWarthog(this.gameObject);
					if (8232 - 488566 == -480334)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -9)
			{
				if (224940 - 326246 != -101305)
				{
					Q9_LookingForMaterial.TalkToWarthogRepeat(this.gameObject);
					if (186932 - 427949 == -241017)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 22)
			{
				if (65586 - 320179 == -254593)
				{
					Q22_DesignerDisfavour.TalkToWarthog(this.gameObject);
					if (210301 - 135268 == 75033)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 27)
			{
				if (2063 - 63537 != -61473)
				{
					Q27_HarderStronger.TalkToWarthog(this.gameObject);
					if (2857 - 51148 == -48291)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 52)
			{
				if (205702 - 104979 == 100723)
				{
					Q52_IBeliveMoleCanFly.TalkToWarthog(this.gameObject);
					if (190878 - 170011 == 20867)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -52)
			{
				if (66755 - 327322 != -260566)
				{
					Q52_IBeliveMoleCanFly.TalkToWarthogRepeat(this.gameObject);
					if (197373 - 92610 == 104763)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 79)
			{
				if (128545 - 383506 == -254961)
				{
					Q79_MakeItStronger.TalkToWarthog(this.gameObject);
					if (142841 - 366528 == -223687)
					{
						break;
					}
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (12429 - 190272 != -177842)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (70628 - 557212 == -486584)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (172593 - 316671 == -144078)
					{
						gameGui.close();
						if (295775 - 193626 == 102149)
						{
							ShopGui shopGui = (ShopGui)this.GetComponent(typeof(ShopGui));
							if (199602 - 298411 != -98808)
							{
								shopGui.mType = eShopType.Warthog;
								if (144851 - 184054 == -39203)
								{
									shopGui.enabled = true;
									if (207103 - 40713 == 166390)
									{
										GameObject mPlayer = Game.mPlayer;
										if (102133 - 120937 != -18803)
										{
											GameObject gameObject = GameObject.Find("Warthog");
											if (37608 - 180972 == -143364)
											{
												if (!gameObject)
												{
													break;
												}
												if (105964 - 460710 == -354746)
												{
													if (!mPlayer)
													{
														break;
													}
													if (119752 - 221433 != -101680)
													{
														mPlayer.SendMessage("turnToPos", gameObject.transform.position);
														if (119104 - 304263 != -185158)
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

	// Token: 0x0600C117 RID: 49431 RVA: 0x01457BA8 File Offset: 0x01455DA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToAlpaca()
	{
		if (157937 - 491735 != -333797)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 22)
			{
				if (124575 - 458804 != -334228)
				{
					Q22_DesignerDisfavour.TalkToAlpaca(this.gameObject);
					if (69741 - 147453 != -77711)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 57)
			{
				if (295617 - 522663 == -227046)
				{
					Q57_NewTasteSalad.TalkToYves(this.gameObject);
					if (137165 - 367183 == -230018)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -57)
			{
				if (36410 - 22130 != 14281)
				{
					Q57_NewTasteSalad.TalkToYvesRepeat(this.gameObject);
					if (166560 - 2054 == 164506)
					{
						break;
					}
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (64057 - 426432 == -362375)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (145344 - 185 == 145159)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (287482 - 446267 != -158784)
					{
						gameGui.close();
						if (105764 - 80703 != 25062)
						{
							ShopGui shopGui = (ShopGui)this.GetComponent(typeof(ShopGui));
							if (213673 - 546718 == -333045)
							{
								shopGui.mType = eShopType.Alpaca;
								if (51472 - 121690 == -70218)
								{
									shopGui.enabled = true;
									if (272172 - 376270 == -104098)
									{
										GameObject mPlayer = Game.mPlayer;
										if (61119 - 514623 == -453504)
										{
											GameObject gameObject = GameObject.Find("Alpaca");
											if (19582 - 58724 != -39141)
											{
												if (!gameObject)
												{
													break;
												}
												if (12796 - 421902 != -409105)
												{
													if (!mPlayer)
													{
														break;
													}
													if (104823 - 19451 == 85372)
													{
														mPlayer.SendMessage("turnToPos", gameObject.transform.position);
														if (283804 - 142792 == 141012)
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

	// Token: 0x0600C118 RID: 49432 RVA: 0x01457EA0 File Offset: 0x014560A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLemur(int n)
	{
		return new T51_MainStreet.$TalkToLemur$47675(n, this).GetEnumerator();
	}

	// Token: 0x0600C119 RID: 49433 RVA: 0x01457EB0 File Offset: 0x014560B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToCatfish()
	{
		if (91246 - 564250 != -473004)
		{
		}
		for (;;)
		{
			GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
			if (108579 - 582708 != -474128)
			{
				BankGui bankGui = (BankGui)this.GetComponent(typeof(BankGui));
				if (103835 - 131938 == -28103)
				{
					if (!gameGui)
					{
						break;
					}
					if (65946 - 433194 != -367247)
					{
						if (!bankGui)
						{
							break;
						}
						if (35617 - 55733 == -20116)
						{
							if (Game.mGameState != eGameState.Normal)
							{
								if (67643 - 2534 != 65110)
								{
									break;
								}
							}
							else
							{
								Game.mGameState = eGameState.Hold;
								if (97301 - 406043 != -308741)
								{
									gameGui.close();
									if (82784 - 100166 != -17381)
									{
										bankGui.enabled = true;
										if (150824 - 533096 != -382271)
										{
											GameObject mPlayer = Game.mPlayer;
											if (171862 - 420497 != -248634)
											{
												GameObject gameObject = GameObject.Find("Catfish");
												if (126376 - 467326 == -340950)
												{
													if (!gameObject)
													{
														break;
													}
													if (134983 - 382880 != -247896)
													{
														if (!mPlayer)
														{
															break;
														}
														if (225628 - 486197 != -260568)
														{
															mPlayer.SendMessage("turnToPos", gameObject.transform.position);
															if (175994 - 66970 == 109024)
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

	// Token: 0x0600C11A RID: 49434 RVA: 0x014580E4 File Offset: 0x014562E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMiniCat()
	{
		return new T51_MainStreet.$TalkToMiniCat$47683(this).GetEnumerator();
	}

	// Token: 0x0600C11B RID: 49435 RVA: 0x014580F4 File Offset: 0x014562F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMiniSheep()
	{
		return new T51_MainStreet.$TalkToMiniSheep$47689(this).GetEnumerator();
	}

	// Token: 0x0600C11C RID: 49436 RVA: 0x01458104 File Offset: 0x01456304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther(int n)
	{
		return new T51_MainStreet.$TalkToPanther$47697(n, this).GetEnumerator();
	}

	// Token: 0x0600C11D RID: 49437 RVA: 0x01458114 File Offset: 0x01456314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToGuild()
	{
		return new T51_MainStreet.$ExitToGuild$47705(this).GetEnumerator();
	}

	// Token: 0x0600C11E RID: 49438 RVA: 0x01458124 File Offset: 0x01456324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToCentralStreet()
	{
		return new T51_MainStreet.$ExitToCentralStreet$47709(this).GetEnumerator();
	}

	// Token: 0x0600C11F RID: 49439 RVA: 0x01458134 File Offset: 0x01456334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveTown()
	{
		if (253529 - 12154 != 241375)
		{
		}
		for (;;)
		{
			Debug.Log("Leaving town..");
			if (215439 - 404390 != -188950)
			{
				Hashtable hashtable = new Hashtable();
				if (59331 - 149527 == -90196)
				{
					hashtable.Add(43, PlayerData.UID);
					if (104897 - 233543 == -128646)
					{
						PhotonClient.Connection.OpCustom(44, hashtable, true);
						if (36790 - 220028 != -183237)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C120 RID: 49440 RVA: 0x0145820C File Offset: 0x0145640C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveTown()
	{
		if (263096 - 298903 != -35806)
		{
		}
		for (;;)
		{
			Debug.Log("onLeaveTown");
			if (211096 - 165674 == 45422)
			{
				if (Game.mNextGameCode > 100)
				{
					if (168996 - 114786 != 54211)
					{
						this.JoinGame();
						if (45431 - 58684 == -13253)
						{
							break;
						}
					}
				}
				else
				{
					this.JoinTown();
					if (175454 - 355071 == -179617)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C121 RID: 49441 RVA: 0x014582D4 File Offset: 0x014564D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (167471 - 517394 != -349922)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (241304 - 11577 == 229727)
			{
				Hashtable hashtable = new Hashtable();
				if (181146 - 64329 == 116817)
				{
					if (Game.mNextGameCode == 30)
					{
						if (188112 - 365020 != -176908)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (71289 - 418954 == -347664)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (119449 - 568775 != -449326)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (24013 - 2167 == 21847)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (164604 - 272132 != -107528)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (21061 - 111795 == -90733)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (187628 - 281744 != -94116)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (109726 - 69839 != 39887)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (21361 - 221914 != -200553)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (106936 - 365895 == -258958)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (75545 - 71158 != 4387)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (118779 - 367344 == -248564)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (32483 - 380951 == -348467)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (158938 - 220308 != -61370)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (102495 - 501249 != -398754)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (281391 - 48194 == 233198)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (289697 - 563689 == -273991)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (158290 - 513010 == -354719)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (228733 - 518628 == -289894)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (5776 - 440519 == -434742)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (216214 - 495894 == -279679)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (256120 - 237838 != 18282)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (124945 - 455928 == -330982)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (44339 - 439817 == -395477)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (158378 - 45840 == 112539)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (54228 - 362125 != -307897)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (132541 - 256843 != -124302)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (289292 - 201989 != 87303)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (216186 - 394091 == -177905)
					{
						this.HpRnTv4Z1Ys.OpCustom(42, hashtable, true);
						if (58604 - 224389 == -165785)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C122 RID: 49442 RVA: 0x01458888 File Offset: 0x01456A88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600C123 RID: 49443 RVA: 0x01458898 File Offset: 0x01456A98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinGame()
	{
		if (10007 - 564425 != -554418)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Game : " + Game.mNextGameId);
			if (142830 - 75304 == 67526)
			{
				Hashtable hashtable = new Hashtable();
				if (101062 - 77072 != 23991)
				{
					hashtable.Add(4, Game.mNextGameId);
					if (266042 - 223171 != 42872)
					{
						this.HpRnTv4Z1Ys.OpCustom(51, hashtable, true);
						if (137601 - 432660 != -295058)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C124 RID: 49444 RVA: 0x01458980 File Offset: 0x01456B80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinGame(Hashtable data)
	{
		Game.loadNextLevel();
	}

	// Token: 0x0600C125 RID: 49445 RVA: 0x01458988 File Offset: 0x01456B88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C126 RID: 49446 RVA: 0x0145898C File Offset: 0x01456B8C
	internal static bool BSdVmetA1vFxTKxaea3G()
	{
		return true;
	}

	// Token: 0x0600C127 RID: 49447 RVA: 0x01458990 File Offset: 0x01456B90
	internal static bool amYgX9tA4LZUSK2sKwe5()
	{
		return false;
	}

	// Token: 0x0400A43E RID: 42046
	private LitePeer HpRnTv4Z1Ys;

	// Token: 0x0400A43F RID: 42047
	private PlayerCameraControl RXLnTlRdPEK;

	// Token: 0x0400A440 RID: 42048
	public GameObject startPoint1;

	// Token: 0x0400A441 RID: 42049
	public GameObject startPoint2;

	// Token: 0x0400A442 RID: 42050
	public GameObject startCamera1;

	// Token: 0x0400A443 RID: 42051
	public GameObject startCamera2;

	// Token: 0x02002036 RID: 8246
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePlayer$47662 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C128 RID: 49448 RVA: 0x01458994 File Offset: 0x01456B94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePlayer$47662(Hashtable data, T51_MainStreet self_)
		{
			if (15873 - 193663 != -177790)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (213916 - 541638 != -327721)
				{
					base..ctor();
					if (154058 - 232408 == -78350)
					{
						this.$data$47673 = data;
						if (207091 - 300120 != -93028)
						{
							this.$self_$47674 = self_;
							if (151856 - 336148 == -184292)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C129 RID: 49449 RVA: 0x01458A50 File Offset: 0x01456C50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T51_MainStreet.$onCreatePlayer$47662.$(this.$data$47673, this.$self_$47674);
		}

		// Token: 0x0600C12A RID: 49450 RVA: 0x01458A64 File Offset: 0x01456C64
		internal static bool xIOFcNtAzFRDi7LX9Wks()
		{
			return true;
		}

		// Token: 0x0600C12B RID: 49451 RVA: 0x01458A68 File Offset: 0x01456C68
		internal static bool aU0wN2tlaF68KKocRxIR()
		{
			return false;
		}

		// Token: 0x0400A444 RID: 42052
		internal Hashtable $data$47673;

		// Token: 0x0400A445 RID: 42053
		internal T51_MainStreet $self_$47674;

		// Token: 0x02002037 RID: 8247
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C12C RID: 49452 RVA: 0x01458A6C File Offset: 0x01456C6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, T51_MainStreet self_)
			{
				if (292153 - 112647 != 179507)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (251654 - 151687 != 99968)
					{
						base..ctor();
						if (246980 - 564728 == -317748)
						{
							this.$data$47671 = data;
							if (156625 - 209772 != -53146)
							{
								this.$self_$47672 = self_;
								if (143399 - 462271 != -318871)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C12D RID: 49453 RVA: 0x01458B28 File Offset: 0x01456D28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (226109 - 517329 != -291219)
				{
				}
				for (;;)
				{
					IL_FC:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_398;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (242688 - 402852 == -160163)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (258653 - 494200 == -235546)
						{
							continue;
						}
						this.YieldDefault(1);
						if (35049 - 293475 != -258425)
						{
							goto Block_6;
						}
						continue;
					default:
						if (141445 - 102546 != 38899)
						{
							continue;
						}
						break;
					}
					this.$nPlayer$47663 = Game.createPlayer(this.$data$47671);
					if (214274 - 197200 != 17075)
					{
						this.$mPlayerList$47664 = GameObject.FindGameObjectsWithTag("Player");
						if (286942 - 325514 != -38571)
						{
							this.$$13664$47668 = 0;
							if (267321 - 479695 == -212374)
							{
								this.$$13665$47669 = this.$mPlayerList$47664;
								if (271601 - 547210 != -275608)
								{
									this.$$13666$47670 = this.$$13665$47669.Length;
									if (67627 - 597886 != -530258)
									{
										while (this.$$13664$47668 < this.$$13666$47670)
										{
											if (this.$nPlayer$47663 != this.$$13665$47669[this.$$13664$47668])
											{
												if (108234 - 484047 != -375813)
												{
													goto IL_FC;
												}
												Physics.IgnoreCollision(this.$nPlayer$47663.collider, this.$$13665$47669[this.$$13664$47668].collider, true);
												if (287942 - 171894 != 116048)
												{
													goto IL_FC;
												}
											}
											this.$$13664$47668++;
											if (254522 - 306865 != -52343)
											{
												goto IL_FC;
											}
										}
										if (285849 - 382255 != -96405)
										{
											this.$mPlayerCameraControl$47666 = (PlayerCameraControl)this.$self_$47672.GetComponent(typeof(PlayerCameraControl));
											if (196123 - 114837 != 81287)
											{
												this.$mPlayerCameraControl$47666.target = this.$nPlayer$47663;
												if (217812 - 453280 != -235467)
												{
													Camera.main.gameObject.layer = 1;
													if (224755 - 544662 != -319906)
													{
														Game.mPlayer = this.$nPlayer$47663;
														if (53361 - 466074 != -412712)
														{
															this.$mGameGui$47667 = (GameGui)this.$self_$47672.GetComponent(typeof(GameGui));
															if (31984 - 263377 != -231392)
															{
																this.$mGameGui$47667.enabled = true;
																if (214233 - 573979 != -359745)
																{
																	this.$self_$47672.SendMessage("fadeIn");
																	if (254404 - 558441 != -304036)
																	{
																		goto Block_22;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_398;
				Block_22:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_398:
				return false;
			}

			// Token: 0x0600C12E RID: 49454 RVA: 0x01458EE0 File Offset: 0x014570E0
			internal static bool BYF3SMtl5X0UM5a4LVZ4()
			{
				return true;
			}

			// Token: 0x0600C12F RID: 49455 RVA: 0x01458EE4 File Offset: 0x014570E4
			internal static bool eovgestlpv88xeHpahS2()
			{
				return false;
			}

			// Token: 0x0400A446 RID: 42054
			internal GameObject $nPlayer$47663;

			// Token: 0x0400A447 RID: 42055
			internal GameObject[] $mPlayerList$47664;

			// Token: 0x0400A448 RID: 42056
			internal GameObject $otherPlayer$47665;

			// Token: 0x0400A449 RID: 42057
			internal PlayerCameraControl $mPlayerCameraControl$47666;

			// Token: 0x0400A44A RID: 42058
			internal GameGui $mGameGui$47667;

			// Token: 0x0400A44B RID: 42059
			internal int $$13664$47668;

			// Token: 0x0400A44C RID: 42060
			internal GameObject[] $$13665$47669;

			// Token: 0x0400A44D RID: 42061
			internal int $$13666$47670;

			// Token: 0x0400A44E RID: 42062
			internal Hashtable $data$47671;

			// Token: 0x0400A44F RID: 42063
			internal T51_MainStreet $self_$47672;
		}
	}

	// Token: 0x02002038 RID: 8248
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLemur$47675 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C130 RID: 49456 RVA: 0x01458EE8 File Offset: 0x014570E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLemur$47675(int n, T51_MainStreet self_)
		{
			if (15558 - 582630 != -567072)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (62416 - 33187 != 29230)
				{
					base..ctor();
					if (197062 - 309474 != -112411)
					{
						this.$n$47681 = n;
						if (48603 - 470011 == -421408)
						{
							this.$self_$47682 = self_;
							if (262403 - 138316 != 124088)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C131 RID: 49457 RVA: 0x01458FA4 File Offset: 0x014571A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T51_MainStreet.$TalkToLemur$47675.$(this.$n$47681, this.$self_$47682);
		}

		// Token: 0x0600C132 RID: 49458 RVA: 0x01458FB8 File Offset: 0x014571B8
		internal static bool iKPbU4tlVmlsFqmxe7Dh()
		{
			return true;
		}

		// Token: 0x0600C133 RID: 49459 RVA: 0x01458FBC File Offset: 0x014571BC
		internal static bool VrbRSQtltr37qZB5qDwP()
		{
			return false;
		}

		// Token: 0x0400A450 RID: 42064
		internal int $n$47681;

		// Token: 0x0400A451 RID: 42065
		internal T51_MainStreet $self_$47682;

		// Token: 0x02002039 RID: 8249
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C134 RID: 49460 RVA: 0x01458FC0 File Offset: 0x014571C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, T51_MainStreet self_)
			{
				if (52595 - 198339 != -145744)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (143055 - 212099 != -69043)
					{
						base..ctor();
						if (164558 - 225402 == -60844)
						{
							this.$n$47679 = n;
							if (129133 - 301802 == -172669)
							{
								this.$self_$47680 = self_;
								if (266236 - 1161 == 265075)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C135 RID: 49461 RVA: 0x0145907C File Offset: 0x0145727C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (189577 - 493492 != -303914)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2C0;
					case 2:
						this.$mLemur$47678.animation.CrossFade("root", 0.2f);
						if (48700 - 569545 != -520845)
						{
							continue;
						}
						goto IL_1C5;
					default:
						if (224638 - 116797 != 107841)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (115032 - 215264 != -100232)
						{
							continue;
						}
						goto IL_29B;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (124030 - 159025 != -34995)
						{
							continue;
						}
						this.$mGameGui$47676 = (GameGui)this.$self_$47680.GetComponent(typeof(GameGui));
						if (70905 - 531178 != -460273)
						{
							continue;
						}
						if (this.$mGameGui$47676)
						{
							if (200739 - 361860 == -161120)
							{
								continue;
							}
							this.$mGameGui$47676.close();
							if (225230 - 20769 == 204462)
							{
								continue;
							}
						}
						this.$mAuctionGui$47677 = (AuctionGui)this.$self_$47680.GetComponent(typeof(AuctionGui));
						if (23177 - 153707 != -130530)
						{
							continue;
						}
						this.$mAuctionGui$47677.enabled = true;
						if (262054 - 574960 != -312906)
						{
							continue;
						}
						this.$mLemur$47678 = GameObject.Find("Lemur" + this.$n$47679);
						if (202365 - 315272 == -112906)
						{
							continue;
						}
						if (this.$mLemur$47678)
						{
							if (173237 - 160662 != 12575)
							{
								continue;
							}
							this.$mLemur$47678.animation.CrossFade("talk", 0.2f);
							if (20737 - 78809 != -58072)
							{
								continue;
							}
							Game.mPlayer.SendMessage("turnToPos", this.$mLemur$47678.transform.position);
							if (25606 - 350713 != -325106)
							{
								break;
							}
							continue;
						}
					}
					IL_1C5:
					this.YieldDefault(1);
					if (114478 - 145905 != -31426)
					{
						goto Block_10;
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				Block_10:
				IL_29B:
				IL_2C0:
				return false;
			}

			// Token: 0x0600C136 RID: 49462 RVA: 0x0145935C File Offset: 0x0145755C
			internal static bool as0kiDtlNS32fJMim97c()
			{
				return true;
			}

			// Token: 0x0600C137 RID: 49463 RVA: 0x01459360 File Offset: 0x01457560
			internal static bool fde9tbtlY0R4TAB2jyEh()
			{
				return false;
			}

			// Token: 0x0400A452 RID: 42066
			internal GameGui $mGameGui$47676;

			// Token: 0x0400A453 RID: 42067
			internal AuctionGui $mAuctionGui$47677;

			// Token: 0x0400A454 RID: 42068
			internal GameObject $mLemur$47678;

			// Token: 0x0400A455 RID: 42069
			internal int $n$47679;

			// Token: 0x0400A456 RID: 42070
			internal T51_MainStreet $self_$47680;
		}
	}

	// Token: 0x0200203A RID: 8250
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMiniCat$47683 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C138 RID: 49464 RVA: 0x01459364 File Offset: 0x01457564
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMiniCat$47683(T51_MainStreet self_)
		{
			if (200741 - 9031 != 191711)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217712 - 280120 != -62407)
				{
					base..ctor();
					if (157540 - 297294 == -139754)
					{
						this.$self_$47688 = self_;
						if (83721 - 440360 != -356638)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C139 RID: 49465 RVA: 0x014593FC File Offset: 0x014575FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T51_MainStreet.$TalkToMiniCat$47683.$(this.$self_$47688);
		}

		// Token: 0x0600C13A RID: 49466 RVA: 0x0145940C File Offset: 0x0145760C
		internal static bool uRJXWstlccfjEQGQinat()
		{
			return true;
		}

		// Token: 0x0600C13B RID: 49467 RVA: 0x01459410 File Offset: 0x01457610
		internal static bool aRl3kvtlUaEakduqCbQ7()
		{
			return false;
		}

		// Token: 0x0400A457 RID: 42071
		internal T51_MainStreet $self_$47688;

		// Token: 0x0200203B RID: 8251
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C13C RID: 49468 RVA: 0x01459414 File Offset: 0x01457614
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T51_MainStreet self_)
			{
				if (73143 - 563806 != -490663)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (220107 - 505062 == -284955)
					{
						base..ctor();
						if (194147 - 309443 != -115295)
						{
							this.$self_$47687 = self_;
							if (117725 - 375203 == -257478)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C13D RID: 49469 RVA: 0x014594AC File Offset: 0x014576AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (116111 - 231307 != -115195)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4F5;
					case 2:
						this.$mStoryGui$47686.newStoryMessage("none", "MiniCat", Language.getMessage("T51_MainStreet", 701 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
						if (143835 - 3005 != 140830)
						{
							continue;
						}
						goto IL_221;
					case 3:
						if (this.$mMiniCat$47684)
						{
							if (15516 - 368900 == -353383)
							{
								continue;
							}
							this.$mMiniCat$47684.animation.CrossFade("root", 0.2f);
							if (185803 - 297825 != -112022)
							{
								continue;
							}
						}
						this.$mStoryGui$47686.close();
						if (247103 - 92931 != 154172)
						{
							continue;
						}
						this.$mGameGui$47685.enabled = true;
						if (177122 - 378771 != -201649)
						{
							continue;
						}
						goto IL_195;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (176329 - 94857 != 81472)
						{
							continue;
						}
						goto IL_2F4;
					default:
						if (116151 - 395730 == -279578)
						{
							continue;
						}
						break;
					}
					if (PlayerData.QuestID == 15)
					{
						if (271710 - 247786 == 23925)
						{
							continue;
						}
						Q15_FakeBug.TalkToNico(this.$self_$47687.gameObject);
						if (186953 - 356729 == -169775)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == -15)
					{
						if (191988 - 283177 == -91188)
						{
							continue;
						}
						Q15_FakeBug.TalkToNicoRepeat(this.$self_$47687.gameObject);
						if (105499 - 217429 == -111929)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == 61)
					{
						if (198485 - 466381 != -267896)
						{
							continue;
						}
						Q61_NicoNeedHelp.TalkToNico(this.$self_$47687.gameObject);
						if (254956 - 333292 != -78336)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == -61)
					{
						if (113769 - 133232 != -19463)
						{
							continue;
						}
						Q61_NicoNeedHelp.TalkToNicoRepeat(this.$self_$47687.gameObject);
						if (222407 - 276459 == -54051)
						{
							continue;
						}
					}
					else if (Game.mGameState != eGameState.Normal)
					{
						if (288957 - 17414 != 271543)
						{
							continue;
						}
						goto IL_413;
					}
					else
					{
						this.$mMiniCat$47684 = GameObject.Find("MiniCat");
						if (212861 - 521853 != -308992)
						{
							continue;
						}
						if (this.$mMiniCat$47684)
						{
							if (169061 - 14558 != 154503)
							{
								continue;
							}
							this.$mMiniCat$47684.animation.CrossFade("talk", 0.2f);
							if (266839 - 194928 != 71911)
							{
								continue;
							}
							Game.mPlayer.SendMessage("turnToPos", this.$mMiniCat$47684.transform.position);
							if (207299 - 568331 != -361032)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (280811 - 277066 != 3745)
						{
							continue;
						}
						this.$mGameGui$47685 = (GameGui)this.$self_$47687.GetComponent(typeof(GameGui));
						if (155485 - 252694 == -97208)
						{
							continue;
						}
						this.$mGameGui$47685.close();
						if (19297 - 540113 != -520816)
						{
							continue;
						}
						this.$mStoryGui$47686 = (StoryGui)this.$self_$47687.GetComponent(typeof(StoryGui));
						if (235387 - 234640 == 748)
						{
							continue;
						}
						this.$mStoryGui$47686.startStoryMessage("none", "MiniCat", eTalkType.friend);
						if (48387 - 22688 != 25700)
						{
							goto Block_11;
						}
						continue;
					}
					IL_2F4:
					this.YieldDefault(1);
					if (107083 - 266949 != -159865)
					{
						goto Block_21;
					}
				}
				IL_195:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_11:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_221:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_21:
				IL_413:
				IL_4F5:
				return false;
			}

			// Token: 0x0600C13E RID: 49470 RVA: 0x014599C0 File Offset: 0x01457BC0
			internal static bool I0ykoatlTKkhoyJZ5Jdc()
			{
				return true;
			}

			// Token: 0x0600C13F RID: 49471 RVA: 0x014599C4 File Offset: 0x01457BC4
			internal static bool sTyNDwtl3QU2P8whp3eK()
			{
				return false;
			}

			// Token: 0x0400A458 RID: 42072
			internal GameObject $mMiniCat$47684;

			// Token: 0x0400A459 RID: 42073
			internal GameGui $mGameGui$47685;

			// Token: 0x0400A45A RID: 42074
			internal StoryGui $mStoryGui$47686;

			// Token: 0x0400A45B RID: 42075
			internal T51_MainStreet $self_$47687;
		}
	}

	// Token: 0x0200203C RID: 8252
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMiniSheep$47689 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C140 RID: 49472 RVA: 0x014599C8 File Offset: 0x01457BC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMiniSheep$47689(T51_MainStreet self_)
		{
			if (29574 - 335019 != -305444)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (115814 - 371824 != -256009)
				{
					base..ctor();
					if (72922 - 458528 == -385606)
					{
						this.$self_$47696 = self_;
						if (274797 - 11873 != 262925)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C141 RID: 49473 RVA: 0x01459A60 File Offset: 0x01457C60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T51_MainStreet.$TalkToMiniSheep$47689.$(this.$self_$47696);
		}

		// Token: 0x0600C142 RID: 49474 RVA: 0x01459A70 File Offset: 0x01457C70
		internal static bool ScRWaKtlXaiZfE6wB1WG()
		{
			return true;
		}

		// Token: 0x0600C143 RID: 49475 RVA: 0x01459A74 File Offset: 0x01457C74
		internal static bool KVJ51ItlQPW07hg3b6G0()
		{
			return false;
		}

		// Token: 0x0400A45C RID: 42076
		internal T51_MainStreet $self_$47696;

		// Token: 0x0200203D RID: 8253
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C144 RID: 49476 RVA: 0x01459A78 File Offset: 0x01457C78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T51_MainStreet self_)
			{
				if (41636 - 351479 != -309842)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (166491 - 340275 == -173784)
					{
						base..ctor();
						if (26946 - 32043 == -5097)
						{
							this.$self_$47695 = self_;
							if (92403 - 405084 == -312681)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C145 RID: 49477 RVA: 0x01459B10 File Offset: 0x01457D10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (121730 - 539840 != -418109)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_37E;
					case 1:
						goto IL_4D7;
					case 2:
						this.$mStoryGui$47694.newStoryMessage("none", "Fah", Language.getMessage("T51_MainStreet", 801 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
						if (26468 - 393023 != -366554)
						{
							goto Block_3;
						}
						continue;
					case 3:
						this.$mStoryGui$47694.close();
						if (229553 - 234821 != -5268)
						{
							continue;
						}
						this.$mGameGui$47693.enabled = true;
						if (150819 - 200959 != -50139)
						{
							goto Block_31;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (278312 - 573730 != -295418)
						{
							continue;
						}
						break;
					default:
						if (115607 - 18356 != 97251)
						{
							continue;
						}
						goto IL_37E;
					}
					IL_103:
					this.YieldDefault(1);
					if (91690 - 190695 != -99004)
					{
						goto Block_6;
					}
					continue;
					IL_37E:
					if (PlayerData.QuestID == 4)
					{
						if (285829 - 391001 != -105171)
						{
							Q4_DontSkipYourBreakfast.TalkToFah(this.$self_$47695.gameObject);
							if (73303 - 335858 != -262554)
							{
								goto IL_103;
							}
						}
					}
					else if (PlayerData.QuestID == -4)
					{
						if (204801 - 589293 == -384492)
						{
							Q4_DontSkipYourBreakfast.TalkToFahRepeat(this.$self_$47695.gameObject);
							if (134137 - 453910 != -319772)
							{
								goto IL_103;
							}
						}
					}
					else if (PlayerData.QuestID == 5)
					{
						if (269295 - 78625 != 190671)
						{
							Q5_FahTradingCard.TalkToTownFah(this.$self_$47695.gameObject);
							if (51991 - 400595 == -348604)
							{
								goto IL_103;
							}
						}
					}
					else if (PlayerData.QuestID == -5)
					{
						if (40041 - 533328 == -493287)
						{
							Q5_FahTradingCard.TalkToTownFahRepeat(this.$self_$47695.gameObject);
							if (199390 - 495002 != -295611)
							{
								goto IL_103;
							}
						}
					}
					else if (Game.mGameState != eGameState.Normal)
					{
						if (180479 - 69961 != 110519)
						{
							goto Block_16;
						}
					}
					else
					{
						this.$mPlayer$47690 = Game.mPlayer;
						if (158135 - 35994 != 122142)
						{
							this.$mMiniSheep$47691 = GameObject.Find("MiniSheep");
							if (159045 - 320937 == -161892)
							{
								this.$mMiniSheepOriginalDir$47692 = default(Vector3);
								if (120993 - 220684 != -99690)
								{
									if (this.$mMiniSheep$47691)
									{
										if (124081 - 575372 != -451291)
										{
											continue;
										}
										if (this.$mPlayer$47690)
										{
											if (245729 - 428640 != -182911)
											{
												continue;
											}
											this.$mPlayer$47690.SendMessage("turnToPos", this.$mMiniSheep$47691.transform.position);
											if (259471 - 336631 != -77160)
											{
												continue;
											}
										}
									}
									Game.mGameState = eGameState.Hold;
									if (203042 - 83976 != 119067)
									{
										this.$mGameGui$47693 = (GameGui)this.$self_$47695.GetComponent(typeof(GameGui));
										if (248082 - 238025 == 10057)
										{
											this.$mGameGui$47693.close();
											if (178979 - 509628 == -330649)
											{
												this.$mStoryGui$47694 = (StoryGui)this.$self_$47695.GetComponent(typeof(StoryGui));
												if (11445 - 162107 == -150662)
												{
													this.$mStoryGui$47694.startStoryMessage("none", "Fah", eTalkType.friend);
													if (120679 - 182039 != -61359)
													{
														goto Block_20;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_6:
				Block_16:
				goto IL_4D7;
				Block_20:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_31:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_4D7:
				return false;
			}

			// Token: 0x0600C146 RID: 49478 RVA: 0x0145A008 File Offset: 0x01458208
			internal static bool vx9kaKtlk9RbndVPEpb6()
			{
				return true;
			}

			// Token: 0x0600C147 RID: 49479 RVA: 0x0145A00C File Offset: 0x0145820C
			internal static bool OwmeZKtlGvrLjmfPoVuU()
			{
				return false;
			}

			// Token: 0x0400A45D RID: 42077
			internal GameObject $mPlayer$47690;

			// Token: 0x0400A45E RID: 42078
			internal GameObject $mMiniSheep$47691;

			// Token: 0x0400A45F RID: 42079
			internal Vector3 $mMiniSheepOriginalDir$47692;

			// Token: 0x0400A460 RID: 42080
			internal GameGui $mGameGui$47693;

			// Token: 0x0400A461 RID: 42081
			internal StoryGui $mStoryGui$47694;

			// Token: 0x0400A462 RID: 42082
			internal T51_MainStreet $self_$47695;
		}
	}

	// Token: 0x0200203E RID: 8254
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$47697 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C148 RID: 49480 RVA: 0x0145A010 File Offset: 0x01458210
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$47697(int n, T51_MainStreet self_)
		{
			if (143511 - 348690 != -205179)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (168214 - 152007 == 16207)
				{
					base..ctor();
					if (270213 - 113329 == 156884)
					{
						this.$n$47703 = n;
						if (29779 - 201890 == -172111)
						{
							this.$self_$47704 = self_;
							if (257952 - 336938 == -78986)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C149 RID: 49481 RVA: 0x0145A0CC File Offset: 0x014582CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T51_MainStreet.$TalkToPanther$47697.$(this.$n$47703, this.$self_$47704);
		}

		// Token: 0x0600C14A RID: 49482 RVA: 0x0145A0E0 File Offset: 0x014582E0
		internal static bool H3U786tlH4aHOrqLqTwD()
		{
			return true;
		}

		// Token: 0x0600C14B RID: 49483 RVA: 0x0145A0E4 File Offset: 0x014582E4
		internal static bool QVy7PXtlW51wOb8HIBjy()
		{
			return false;
		}

		// Token: 0x0400A463 RID: 42083
		internal int $n$47703;

		// Token: 0x0400A464 RID: 42084
		internal T51_MainStreet $self_$47704;

		// Token: 0x0200203F RID: 8255
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C14C RID: 49484 RVA: 0x0145A0E8 File Offset: 0x014582E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, T51_MainStreet self_)
			{
				if (52431 - 221529 != -169097)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (295799 - 149172 != 146628)
					{
						base..ctor();
						if (74402 - 338056 != -263653)
						{
							this.$n$47701 = n;
							if (47222 - 589575 == -542353)
							{
								this.$self_$47702 = self_;
								if (127937 - 62735 == 65202)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C14D RID: 49485 RVA: 0x0145A1A4 File Offset: 0x014583A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (207625 - 173656 != 33969)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9D2;
					case 2:
						if (this.$n$47701 < 3)
						{
							if (31567 - 167753 == -136185)
							{
								continue;
							}
							this.$mStoryGui$47699.newStoryMessage("none", "Panther", Language.getMessage("T51_MainStreet", 901 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
							if (249037 - 184811 != 64227)
							{
								goto Block_74;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47699.newStoryMessage("none", "Panther", Language.getMessage("T51_MainStreet", 906 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
							if (137979 - 434808 != -296829)
							{
								continue;
							}
							goto IL_570;
						}
						break;
					case 3:
						this.$mStoryGui$47699.close();
						if (170086 - 50147 == 119940)
						{
							continue;
						}
						if (this.$mPanther$47700)
						{
							if (237763 - 162797 != 74966)
							{
								continue;
							}
							this.$mPanther$47700.animation.CrossFade("root", 0.2f);
							if (113689 - 325163 == -211473)
							{
								continue;
							}
						}
						this.$mGameGui$47698.enabled = true;
						if (69642 - 161726 != -92083)
						{
							goto Block_39;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (178273 - 486065 != -307791)
						{
							goto IL_453;
						}
						continue;
					default:
						if (149061 - 407274 == -258212)
						{
							continue;
						}
						break;
					}
					if (this.$n$47701 == 1)
					{
						if (209928 - 211003 == -1074)
						{
							continue;
						}
						if (PlayerData.QuestID == 6)
						{
							if (193459 - 27711 != 165748)
							{
								continue;
							}
							Q6_DaringChallenge.TalkToPanther1(this.$self_$47702.gameObject);
							if (213199 - 446168 != -232968)
							{
								goto IL_453;
							}
							continue;
						}
					}
					if (this.$n$47701 == 2)
					{
						if (172021 - 205055 == -33033)
						{
							continue;
						}
						if (PlayerData.QuestID == 6)
						{
							if (290583 - 116724 == 173860)
							{
								continue;
							}
							Q6_DaringChallenge.TalkToPanther2(this.$self_$47702.gameObject);
							if (139942 - 129177 != 10765)
							{
								continue;
							}
							goto IL_453;
						}
					}
					if (this.$n$47701 == 1)
					{
						if (262549 - 450443 == -187893)
						{
							continue;
						}
						if (PlayerData.QuestID == -6)
						{
							if (71035 - 327359 == -256323)
							{
								continue;
							}
							Q6_DaringChallenge.TalkToPanther1Repeat(this.$self_$47702.gameObject);
							if (231608 - 20716 != 210892)
							{
								continue;
							}
							goto IL_453;
						}
					}
					if (this.$n$47701 == 2)
					{
						if (159311 - 223970 != -64659)
						{
							continue;
						}
						if (PlayerData.QuestID == -6)
						{
							if (13925 - 68020 != -54095)
							{
								continue;
							}
							Q6_DaringChallenge.TalkToPanther2Repeat(this.$self_$47702.gameObject);
							if (221461 - 391604 != -170142)
							{
								goto IL_453;
							}
							continue;
						}
					}
					if (this.$n$47701 == 1)
					{
						if (217502 - 494091 != -276589)
						{
							continue;
						}
						if (PlayerData.QuestID == 13)
						{
							if (265386 - 324525 != -59139)
							{
								continue;
							}
							Q13_PantherParty.TalkToPanther1(this.$self_$47702.gameObject);
							if (252989 - 304305 != -51316)
							{
								continue;
							}
							goto IL_453;
						}
					}
					if (this.$n$47701 == 2)
					{
						if (5980 - 453316 != -447336)
						{
							continue;
						}
						if (PlayerData.QuestID == 13)
						{
							if (152311 - 187719 != -35408)
							{
								continue;
							}
							Q13_PantherParty.TalkToPanther2(this.$self_$47702.gameObject);
							if (56372 - 284811 != -228439)
							{
								continue;
							}
							goto IL_453;
						}
					}
					if (this.$n$47701 == 1)
					{
						if (167844 - 247914 != -80070)
						{
							continue;
						}
						if (PlayerData.QuestID == -13)
						{
							if (271664 - 434399 == -162734)
							{
								continue;
							}
							Q13_PantherParty.TalkToPanther1Repeat(this.$self_$47702.gameObject);
							if (57099 - 164558 != -107459)
							{
								continue;
							}
							goto IL_453;
						}
					}
					if (this.$n$47701 == 2)
					{
						if (115132 - 373732 == -258599)
						{
							continue;
						}
						if (PlayerData.QuestID == -13)
						{
							if (156596 - 39341 == 117256)
							{
								continue;
							}
							Q13_PantherParty.TalkToPanther2Repeat(this.$self_$47702.gameObject);
							if (98873 - 507460 != -408586)
							{
								goto IL_453;
							}
							continue;
						}
					}
					if (this.$n$47701 != 1)
					{
						if (26926 - 437690 != -410764)
						{
							continue;
						}
						if (this.$n$47701 != 2)
						{
							goto IL_7F1;
						}
						if (183851 - 210456 == -26604)
						{
							continue;
						}
					}
					if (PlayerData.QuestID == 27)
					{
						if (134916 - 582804 == -447887)
						{
							continue;
						}
						Q27_HarderStronger.TalkToPanther(this.$self_$47702.gameObject);
						if (237602 - 414308 != -176706)
						{
							continue;
						}
						goto IL_453;
					}
					IL_7F1:
					if (PlayerData.QuestID == 61)
					{
						if (298645 - 141914 == 156732)
						{
							continue;
						}
						Q61_NicoNeedHelp.TalkToPanther(this.$self_$47702.gameObject);
						if (270272 - 510443 != -240171)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == -61)
					{
						if (129292 - 358823 != -229531)
						{
							continue;
						}
						Q61_NicoNeedHelp.TalkToPantherRepeat(this.$self_$47702.gameObject);
						if (245637 - 69382 == 176256)
						{
							continue;
						}
					}
					else if (Game.mGameState != eGameState.Normal)
					{
						if (168750 - 381989 != -213238)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mGameGui$47698 = (GameGui)this.$self_$47702.GetComponent(typeof(GameGui));
						if (13416 - 364032 == -350615)
						{
							continue;
						}
						this.$mStoryGui$47699 = (StoryGui)this.$self_$47702.GetComponent(typeof(StoryGui));
						if (246204 - 185994 != 60210)
						{
							continue;
						}
						if (this.$mGameGui$47698)
						{
							if (193286 - 429089 == -235802)
							{
								continue;
							}
							if (this.$mStoryGui$47699)
							{
								if (171493 - 430355 == -258861)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (139357 - 224964 != -85607)
								{
									continue;
								}
								this.$mGameGui$47698.close();
								if (36794 - 116154 == -79359)
								{
									continue;
								}
								this.$mPanther$47700 = GameObject.Find("Panther" + this.$n$47701);
								if (272328 - 506845 != -234517)
								{
									continue;
								}
								if (this.$mPanther$47700)
								{
									if (132389 - 301152 != -168763)
									{
										continue;
									}
									this.$mPanther$47700.animation.CrossFade("talk", 0.15f);
									if (162799 - 143910 == 18890)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mPanther$47700.transform.position);
									if (191162 - 172552 == 18611)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Panther" + this.$n$47701);
									if (289036 - 197464 == 91573)
									{
										continue;
									}
								}
								this.$mStoryGui$47699.startStoryMessage("none", "Panther", eTalkType.friend);
								if (218246 - 237017 != -18771)
								{
									continue;
								}
								goto IL_5D5;
							}
						}
					}
					IL_453:
					this.YieldDefault(1);
				}
				while (60265 - 409585 != -349320);
				goto IL_9D2;
				Block_39:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_570:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_5D5:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_74:
				goto IL_570;
				IL_9D2:
				return false;
			}

			// Token: 0x0600C14E RID: 49486 RVA: 0x0145AB98 File Offset: 0x01458D98
			internal static bool ICfstqtlA7CDKtJHSSY1()
			{
				return true;
			}

			// Token: 0x0600C14F RID: 49487 RVA: 0x0145AB9C File Offset: 0x01458D9C
			internal static bool QU6NaYtll0uPnlO4KccQ()
			{
				return false;
			}

			// Token: 0x0400A465 RID: 42085
			internal GameGui $mGameGui$47698;

			// Token: 0x0400A466 RID: 42086
			internal StoryGui $mStoryGui$47699;

			// Token: 0x0400A467 RID: 42087
			internal GameObject $mPanther$47700;

			// Token: 0x0400A468 RID: 42088
			internal int $n$47701;

			// Token: 0x0400A469 RID: 42089
			internal T51_MainStreet $self_$47702;
		}
	}

	// Token: 0x02002040 RID: 8256
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToGuild$47705 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C150 RID: 49488 RVA: 0x0145ABA0 File Offset: 0x01458DA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToGuild$47705(T51_MainStreet self_)
		{
			if (96323 - 455474 != -359151)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (172365 - 190631 == -18266)
				{
					base..ctor();
					if (56559 - 36984 != 19576)
					{
						this.$self_$47708 = self_;
						if (69332 - 54461 == 14871)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C151 RID: 49489 RVA: 0x0145AC38 File Offset: 0x01458E38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T51_MainStreet.$ExitToGuild$47705.$(this.$self_$47708);
		}

		// Token: 0x0600C152 RID: 49490 RVA: 0x0145AC48 File Offset: 0x01458E48
		internal static bool cJLJrctlyofiiPjx0bCx()
		{
			return true;
		}

		// Token: 0x0600C153 RID: 49491 RVA: 0x0145AC4C File Offset: 0x01458E4C
		internal static bool q79b11tlSaQZhCoLfwNv()
		{
			return false;
		}

		// Token: 0x0400A46A RID: 42090
		internal T51_MainStreet $self_$47708;

		// Token: 0x02002041 RID: 8257
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C154 RID: 49492 RVA: 0x0145AC50 File Offset: 0x01458E50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T51_MainStreet self_)
			{
				if (85667 - 539527 != -453860)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (100062 - 484371 == -384309)
					{
						base..ctor();
						if (241146 - 304183 == -63037)
						{
							this.$self_$47707 = self_;
							if (246902 - 86254 != 160649)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C155 RID: 49493 RVA: 0x0145ACE8 File Offset: 0x01458EE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (135415 - 303289 != -167873)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_24F;
					case 2:
						this.$self_$47707.LeaveTown();
						if (68184 - 47196 == 20989)
						{
							continue;
						}
						this.YieldDefault(1);
						if (156081 - 465716 != -309634)
						{
							goto Block_14;
						}
						continue;
					default:
						if (223212 - 442631 != -219419)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (93128 - 141332 != -48203)
					{
						Game.mStateTime = Time.time;
						if (238235 - 165376 != 72860)
						{
							if (PlayerData.GID == 0)
							{
								if (276886 - 292935 == -16048)
								{
									continue;
								}
								Game.mNextGameId = 300;
								if (51888 - 575835 == -523946)
								{
									continue;
								}
								Game.mNextGameCode = 30;
								if (260346 - 477269 == -216922)
								{
									continue;
								}
							}
							else
							{
								Game.mNextGameId = 301;
								if (170329 - 5423 != 164906)
								{
									continue;
								}
								Game.mNextGameCode = 31;
								if (57568 - 245808 != -188240)
								{
									continue;
								}
							}
							this.$mGameGui$47706 = (GameGui)this.$self_$47707.GetComponent(typeof(GameGui));
							if (100468 - 236087 == -135619)
							{
								if (this.$mGameGui$47706)
								{
									if (161756 - 3473 == 158284)
									{
										continue;
									}
									this.$mGameGui$47706.close();
									if (81501 - 336218 != -254717)
									{
										continue;
									}
								}
								this.$self_$47707.SendMessage("fadeOut");
								if (78138 - 234449 != -156310)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_14:
				IL_24F:
				return false;
			}

			// Token: 0x0600C156 RID: 49494 RVA: 0x0145AF58 File Offset: 0x01459158
			internal static bool H4J7NntlodmPBHvUpMEd()
			{
				return true;
			}

			// Token: 0x0600C157 RID: 49495 RVA: 0x0145AF5C File Offset: 0x0145915C
			internal static bool jaC6fXtlE1MCoHFOCQDm()
			{
				return false;
			}

			// Token: 0x0400A46B RID: 42091
			internal GameGui $mGameGui$47706;

			// Token: 0x0400A46C RID: 42092
			internal T51_MainStreet $self_$47707;
		}
	}

	// Token: 0x02002042 RID: 8258
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToCentralStreet$47709 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C158 RID: 49496 RVA: 0x0145AF60 File Offset: 0x01459160
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToCentralStreet$47709(T51_MainStreet self_)
		{
			if (89405 - 974 != 88432)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (124432 - 266642 != -142209)
				{
					base..ctor();
					if (31105 - 12487 != 18619)
					{
						this.$self_$47712 = self_;
						if (15040 - 183845 != -168804)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C159 RID: 49497 RVA: 0x0145AFF8 File Offset: 0x014591F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T51_MainStreet.$ExitToCentralStreet$47709.$(this.$self_$47712);
		}

		// Token: 0x0600C15A RID: 49498 RVA: 0x0145B008 File Offset: 0x01459208
		internal static bool kRZOOmtl2Escb11ExXJm()
		{
			return true;
		}

		// Token: 0x0600C15B RID: 49499 RVA: 0x0145B00C File Offset: 0x0145920C
		internal static bool U1IGF3tl8I1JU2LQnoy1()
		{
			return false;
		}

		// Token: 0x0400A46D RID: 42093
		internal T51_MainStreet $self_$47712;

		// Token: 0x02002043 RID: 8259
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C15C RID: 49500 RVA: 0x0145B010 File Offset: 0x01459210
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T51_MainStreet self_)
			{
				if (294636 - 197531 != 97105)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (126553 - 567641 == -441088)
					{
						base..ctor();
						if (250002 - 187258 == 62744)
						{
							this.$self_$47711 = self_;
							if (268474 - 371629 != -103154)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C15D RID: 49501 RVA: 0x0145B0A8 File Offset: 0x014592A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (128223 - 156077 != -27853)
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
						this.$self_$47711.LeaveTown();
						if (40861 - 509933 == -469071)
						{
							continue;
						}
						this.YieldDefault(1);
						if (166348 - 216942 != -50594)
						{
							continue;
						}
						goto IL_1E1;
					default:
						if (287255 - 485734 != -198479)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (137718 - 298739 != -161020)
					{
						Game.mStateTime = Time.time;
						if (187849 - 590864 != -403014)
						{
							Game.mNextGameId = 502;
							if (121193 - 387708 != -266514)
							{
								Game.mNextGameCode = 52;
								if (71536 - 6879 == 64657)
								{
									this.$mGameGui$47710 = (GameGui)this.$self_$47711.GetComponent(typeof(GameGui));
									if (141484 - 71224 == 70260)
									{
										if (this.$mGameGui$47710)
										{
											if (102708 - 567281 == -464572)
											{
												continue;
											}
											this.$mGameGui$47710.close();
											if (5526 - 288823 != -283297)
											{
												continue;
											}
										}
										this.$self_$47711.SendMessage("fadeOut");
										if (132648 - 482096 == -349448)
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

			// Token: 0x0600C15E RID: 49502 RVA: 0x0145B2A8 File Offset: 0x014594A8
			internal static bool FwuPy1tlZFDhf8aVrJcN()
			{
				return true;
			}

			// Token: 0x0600C15F RID: 49503 RVA: 0x0145B2AC File Offset: 0x014594AC
			internal static bool djPDMrtlCSeEDJBCOGRK()
			{
				return false;
			}

			// Token: 0x0400A46E RID: 42094
			internal GameGui $mGameGui$47710;

			// Token: 0x0400A46F RID: 42095
			internal T51_MainStreet $self_$47711;
		}
	}
}
