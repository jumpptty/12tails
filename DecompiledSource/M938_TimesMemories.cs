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

// Token: 0x02001BCB RID: 7115
[Serializable]
public class M938_TimesMemories : MonoBehaviour
{
	// Token: 0x0600A60E RID: 42510 RVA: 0x012B6808 File Offset: 0x012B4A08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M938_TimesMemories()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A60F RID: 42511 RVA: 0x012B6818 File Offset: 0x012B4A18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (63053 - 85745 != -22692)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (72484 - 282576 == -210092)
			{
				Game.mGameType = 5;
				if (259561 - 122081 == 137480)
				{
					if (Chat.Initialized)
					{
						if (104529 - 275424 != -170895)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (104684 - 352796 != -248112)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (228405 - 146803 != 81602)
						{
							continue;
						}
					}
					this.C7in6AXjNaw = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (169270 - 255667 == -86397)
					{
						this.ElTn697OOHM = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (69922 - 90154 != -20231)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A610 RID: 42512 RVA: 0x012B6970 File Offset: 0x012B4B70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (103168 - 514007 != -410838)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (225597 - 495470 != -269872)
				{
					if (Game.mNextGameCode != 938)
					{
						break;
					}
					if (69374 - 558040 != -488665)
					{
						Game.nextGame();
						if (269573 - 159872 != 109702)
						{
							Game.mGameCode = 938;
							if (76772 - 559209 != -482436)
							{
								Game.mGameType = 5;
								if (225038 - 357807 != -132768)
								{
									Game.mGameTime = Time.time;
									if (289214 - 276548 == 12666)
									{
										Game.mGameScore = 0;
										if (265004 - 173678 == 91326)
										{
											Game.mGameMana = 0;
											if (15270 - 578254 == -562984)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (188962 - 346587 != -157624)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (180813 - 465495 == -284682)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (262736 - 77297 != 185440)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (151662 - 595050 != -443387)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (252882 - 36668 != 216215)
																{
																	this.hMZn6kTXmNB = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (264974 - 255487 == 9487)
																	{
																		this.DnEn6oDkQJX = PhotonClient.Connection;
																		if (37309 - 59958 != -22648)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (103024 - 590529 != -487504)
																			{
																				this.InitGame();
																				if (44504 - 80079 != -35574)
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
				if (203090 - 210060 != -6969)
				{
					Game.mGameType = 99;
					if (204848 - 253913 != -49064)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A611 RID: 42513 RVA: 0x012B6C78 File Offset: 0x012B4E78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (75473 - 496407 != -420934)
		{
		}
		for (;;)
		{
			if (this.DnEn6oDkQJX == null)
			{
				if (45126 - 216156 == -171030)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (243284 - 584706 == -341422)
				{
					if (mGameState == eGameState.Init)
					{
						if (135127 - 258226 != -123098)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (76816 - 175806 != -98989)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (207698 - 355195 != -147496)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (295710 - 410055 == -114345)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (262543 - 402301 != -139757)
						{
							if (Game.music != 0)
							{
								if (87958 - 527575 != -439617)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (44460 - 57715 == -13254)
									{
										continue;
									}
									this.audio.Play();
									if (147351 - 516075 == -368723)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (151080 - 52302 == 98778)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (120038 - 435744 != -315705)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (20982 - 8180 != 12803)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (176462 - 437291 == -260829)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (70965 - 32069 != 38897)
							{
								if (Time.time <= this.VcDn6FKZCTr)
								{
									break;
								}
								if (239269 - 312051 != -72781)
								{
									Game.mGameMana++;
									if (119054 - 452234 == -333180)
									{
										this.VcDn6FKZCTr = Time.time + (float)12;
										if (223269 - 238245 != -14975)
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
						if (185125 - 32326 != 152800)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (5104 - 190650 != -185545)
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
						if (124163 - 425940 != -301776)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A612 RID: 42514 RVA: 0x012B7020 File Offset: 0x012B5220
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (46576 - 536688 != -490111)
		{
		}
		for (;;)
		{
			if (!this.C7in6AXjNaw)
			{
				if (243430 - 72474 == 170956)
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
				if (211890 - 399495 != -187604)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (201685 - 356287 == -154602)
					{
						if (this.MEnn6Wwijxk != 1)
						{
							break;
						}
						if (30118 - 230816 == -200698)
						{
							GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
							if (149597 - 589039 == -439442)
							{
								float num = (float)(1024 * Screen.width / Screen.height);
								if (276494 - 400574 != -124079)
								{
									GUI.depth = 1;
									if (92201 - 104257 == -12056)
									{
										float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
										if (207911 - 344693 == -136782)
										{
											float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
											if (207270 - 206216 != 1055)
											{
												Color color = GUI.color;
												if (54627 - 247921 != -193293)
												{
													color.a = a;
													if (109461 - 373415 == -263954)
													{
														if (169243 - 330888 == -161645)
														{
															GUI.color = color;
															if (85916 - 310130 == -224214)
															{
																if (4439 - 480540 != -476100)
																{
																	GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.C7in6AXjNaw);
																	if (274446 - 391338 == -116892)
																	{
																		float a2 = 1f;
																		if (197289 - 478186 != -280896)
																		{
																			Color color2 = GUI.color;
																			if (51229 - 201940 == -150711)
																			{
																				color2.a = a2;
																				if (205732 - 149073 == 56659)
																				{
																					if (294746 - 83631 != 211116)
																					{
																						Color color3 = GUI.color = color2;
																						if (42616 - 599999 == -557383)
																						{
																							if (278965 - 88555 == 190410)
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

	// Token: 0x0600A613 RID: 42515 RVA: 0x012B73C8 File Offset: 0x012B55C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M938_TimesMemories.$onGameEvent$44174(data, this).GetEnumerator();
	}

	// Token: 0x0600A614 RID: 42516 RVA: 0x012B73D8 File Offset: 0x012B55D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M938_TimesMemories.$StartEvent$44186(this).GetEnumerator();
	}

	// Token: 0x0600A615 RID: 42517 RVA: 0x012B73E8 File Offset: 0x012B55E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWalrusEvent()
	{
		return new M938_TimesMemories.$TalkToWalrusEvent$44192(this).GetEnumerator();
	}

	// Token: 0x0600A616 RID: 42518 RVA: 0x012B73F8 File Offset: 0x012B55F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator KingRayEvent()
	{
		return new M938_TimesMemories.$KingRayEvent$44199(this).GetEnumerator();
	}

	// Token: 0x0600A617 RID: 42519 RVA: 0x012B7408 File Offset: 0x012B5608
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EndEvent()
	{
	}

	// Token: 0x0600A618 RID: 42520 RVA: 0x012B740C File Offset: 0x012B560C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void removeEnemy(string nType)
	{
		if (263750 - 211511 != 52240)
		{
		}
		for (;;)
		{
			IL_3D:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Enemy");
			if (266704 - 325142 == -58438)
			{
				int i = 0;
				if (72699 - 259892 != -187192)
				{
					GameObject[] array2 = array;
					if (275008 - 374345 != -99336)
					{
						int length = array2.Length;
						if (35395 - 355342 == -319947)
						{
							while (i < length)
							{
								CharacterControl characterControl = (CharacterControl)array2[i].GetComponent(typeof(CharacterControl));
								if (47309 - 347124 != -299815)
								{
									goto IL_3D;
								}
								if (characterControl)
								{
									if (225495 - 73336 != 152159)
									{
										goto IL_3D;
									}
									if (characterControl.Type == nType)
									{
										if (175507 - 126865 == 48643)
										{
											goto IL_3D;
										}
										UnityEngine.Object.Destroy(array2[i]);
										if (181447 - 111267 == 70181)
										{
											goto IL_3D;
										}
									}
								}
								i++;
								if (11637 - 141385 == -129747)
								{
									goto IL_3D;
								}
							}
							if (69358 - 150910 == -81552)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A619 RID: 42521 RVA: 0x012B75B0 File Offset: 0x012B57B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToWalrus()
	{
		if (94962 - 548067 != -453105)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (19093 - 16367 != 2727)
				{
					break;
				}
			}
			else
			{
				if (this.MEnn6Wwijxk >= 1)
				{
					break;
				}
				if (279342 - 391219 != -111876)
				{
					this.MEnn6Wwijxk = 1;
					if (288364 - 533190 != -244825)
					{
						Game.sendMissionEvent(9381, 1);
						if (216671 - 523822 != -307150)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A61A RID: 42522 RVA: 0x012B7680 File Offset: 0x012B5880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (40225 - 434105 != -393880)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (27844 - 411320 != -383475)
			{
				Game.mGameState = eGameState.Ready;
				if (241846 - 478946 == -237100)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (164643 - 159270 == 5373)
					{
						if (208544 - 474592 != -266047)
						{
							if (playerSlot < 1)
							{
								goto IL_115;
							}
							if (148721 - 235250 == -86528)
							{
								continue;
							}
							if (playerSlot > 12)
							{
								goto IL_115;
							}
							if (114067 - 212486 == -98418)
							{
								continue;
							}
							GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
							if (106544 - 335860 != -229316)
							{
								continue;
							}
							IL_9D:
							if (gameObject)
							{
								if (241388 - 576856 != -335468)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
								if (83787 - 250965 != -167178)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (4127 - 431843 != -427716)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
									if (204721 - 304836 != -100114)
									{
										break;
									}
									continue;
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (264715 - 522431 != -257715)
									{
										break;
									}
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find startPoint gameObject");
								if (13256 - 574634 != -561378)
								{
									continue;
								}
								break;
							}
							IL_115:
							gameObject = GameObject.Find("TestControl");
							if (111386 - 196297 == -84911)
							{
								goto IL_9D;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A61B RID: 42523 RVA: 0x012B78FC File Offset: 0x012B5AFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (113235 - 284500 != -171265)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (139325 - 43867 != 95459)
			{
				if (gameObject)
				{
					if (25362 - 154921 != -129558)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (450 - 113871 == -113421)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (167770 - 369200 == -201430)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A61C RID: 42524 RVA: 0x012B79F8 File Offset: 0x012B5BF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (132433 - 370410 != -237977)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (252130 - 421152 == -169022)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (101356 - 425470 != -324113)
				{
					hashtable.Add(43, PlayerData.UID);
					if (60859 - 322462 == -261603)
					{
						hashtable.Add(73, nType);
						if (232347 - 305521 != -73173)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (195538 - 169483 == 26055)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (31540 - 220310 != -188769)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (56521 - 290590 == -234069)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (169583 - 286288 == -116705)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (77632 - 230514 == -152882)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (87954 - 564702 != -476747)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (19863 - 125135 != -105271)
													{
														this.DnEn6oDkQJX.OpCustom(63, hashtable, true);
														if (258760 - 203515 != 55246)
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

	// Token: 0x0600A61D RID: 42525 RVA: 0x012B7CDC File Offset: 0x012B5EDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (148025 - 336540 != -188514)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (233651 - 143219 != 90433)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (10263 - 520623 != -510359)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (170792 - 321366 != -150573)
						{
							if (this.Hban6yMKcSq <= 0)
							{
								break;
							}
							if (45587 - 165314 != -119726)
							{
								this.Hban6yMKcSq--;
								if (34190 - 30093 != 4098)
								{
									if (this.Hban6yMKcSq != 0)
									{
										break;
									}
									if (205890 - 513519 != -307628)
									{
										Game.setGameState(eGameState.Ready);
										if (157640 - 384954 != -227313)
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
						if (188178 - 33276 == 154902)
						{
							if (gameObject)
							{
								if (220119 - 439832 == -219712)
								{
									continue;
								}
								if (this.nCreateEffect)
								{
									if (162798 - 374123 == -211324)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.nCreateEffect, gameObject.transform.position, gameObject.transform.rotation);
									if (17532 - 513411 != -495878)
									{
										break;
									}
									continue;
								}
							}
							Debug.LogError("Missing nCreateEffect gameObject");
							if (95183 - 566896 != -471712)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A61E RID: 42526 RVA: 0x012B7EF8 File Offset: 0x012B60F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A61F RID: 42527 RVA: 0x012B7F0C File Offset: 0x012B610C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (215257 - 161683 != 53574)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (100751 - 374274 != -273522)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (204546 - 127010 != 77537)
				{
					if (!characterControl)
					{
						break;
					}
					if (14002 - 586017 != -572014)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (91128 - 488398 != -397269)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (75156 - 55261 != 19896)
							{
								string type = characterControl.Type;
								if (203521 - 593217 == -389696)
								{
									if (type == "ChromeKnight")
									{
										if (136423 - 434368 != -297944)
										{
											Game.sendMissionEvent(9383, 1);
											if (109571 - 284025 == -174454)
											{
												break;
											}
										}
									}
									else if (type == "Germanotta")
									{
										if (266786 - 446983 != -180196)
										{
											Game.sendMissionEvent(9383, 2);
											if (113046 - 451245 == -338199)
											{
												break;
											}
										}
									}
									else if (type == "FirstWhale")
									{
										if (274920 - 113801 == 161119)
										{
											Game.sendMissionEvent(9383, 3);
											if (226974 - 533615 == -306641)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "RangerBug_red"))
										{
											if (236803 - 262817 != -26014)
											{
												continue;
											}
											if (!(type == "RangerBug_yellow"))
											{
												if (140349 - 94735 != 45614)
												{
													continue;
												}
												if (!(type == "RangerBug_pink"))
												{
													if (39154 - 170046 == -130891)
													{
														continue;
													}
													if (!(type == "RangerBug_blue"))
													{
														if (192396 - 471231 == -278834)
														{
															continue;
														}
														if (type == "RangerBug_black")
														{
															if (12913 - 457164 != -444251)
															{
																continue;
															}
														}
														else if (type == "RangerRobot")
														{
															if (65934 - 394606 == -328671)
															{
																continue;
															}
															Game.sendMissionEvent(9383, 4);
															if (107291 - 297054 != -189762)
															{
																break;
															}
															continue;
														}
														else
														{
															if (!(type == "KingRodinia"))
															{
																break;
															}
															if (173952 - 449875 == -275922)
															{
																continue;
															}
															Game.sendMissionEvent(9383, 5);
															if (237824 - 512304 != -274479)
															{
																break;
															}
															continue;
														}
													}
												}
											}
										}
										Game.sendMissionEvent(9384, 0);
										if (233692 - 537919 != -304226)
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

	// Token: 0x0600A620 RID: 42528 RVA: 0x012B82D0 File Offset: 0x012B64D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (12856 - 141553 != -128696)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (190433 - 255418 == -64985)
			{
				hashtable.Add(71, CID);
				if (219464 - 72276 != 147189)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (131724 - 591127 == -459403)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (213478 - 587238 != -373759)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (12834 - 552540 == -539706)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (77734 - 502343 != -424608)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (143410 - 346736 != -203325)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (2566 - 293474 == -290908)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (44031 - 383507 != -339475)
											{
												this.DnEn6oDkQJX.OpCustom(61, hashtable, true);
												if (264895 - 190936 != 73960)
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

	// Token: 0x0600A621 RID: 42529 RVA: 0x012B855C File Offset: 0x012B675C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (17763 - 448898 != -431135)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (21365 - 224642 == -203277)
			{
				if (!gameObject)
				{
					break;
				}
				if (254027 - 40151 == 213876)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (244254 - 79619 == 164635)
					{
						playerCameraControl.target = gameObject;
						if (130599 - 479525 != -348925)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (131799 - 338298 != -206498)
								{
									this.StartGame();
									if (160893 - 131874 == 29019)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (253601 - 34813 != 218789)
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

	// Token: 0x0600A622 RID: 42530 RVA: 0x012B8698 File Offset: 0x012B6898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (223849 - 515794 != -291945)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (266516 - 282396 != -15879)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (19157 - 357738 != -338580)
				{
					gameGui.ResetTeamBar();
					if (40489 - 589649 != -549159)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A623 RID: 42531 RVA: 0x012B8744 File Offset: 0x012B6944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M938_TimesMemories.$onDeadPlayer$44202(this).GetEnumerator();
	}

	// Token: 0x0600A624 RID: 42532 RVA: 0x012B8754 File Offset: 0x012B6954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (88222 - 511143 != -422921)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (82015 - 178434 == -96419)
			{
				this.hMZn6kTXmNB.target = Game.mPlayer;
				if (127243 - 480424 != -353180)
				{
					this.hMZn6kTXmNB.enabled = true;
					if (278826 - 91757 == 187069)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (85958 - 503371 == -417412)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (148497 - 583112 != -434615)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (83912 - 313384 != -229471)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (45515 - 433172 != -387656)
							{
								if (!gameGui)
								{
									break;
								}
								if (195129 - 134660 == 60469)
								{
									gameGui.enabled = true;
									if (106833 - 548309 != -441475)
									{
										gameGui.closeDeadMenu();
										if (115007 - 245434 != -130426)
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

	// Token: 0x0600A625 RID: 42533 RVA: 0x012B8900 File Offset: 0x012B6B00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (43611 - 516905 != -473293)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (144022 - 543059 == -399037)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (126054 - 83128 != 42927)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (35194 - 592575 != -557380)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A626 RID: 42534 RVA: 0x012B89C4 File Offset: 0x012B6BC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A627 RID: 42535 RVA: 0x012B89F0 File Offset: 0x012B6BF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (223118 - 29374 != 193745)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (265853 - 287976 != -22122)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (50097 - 106315 != -56217)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (17980 - 514329 == -496349)
					{
						Hashtable hashtable = new Hashtable();
						if (25771 - 387623 != -361851)
						{
							hashtable.Add(43, PlayerData.UID);
							if (10042 - 567228 == -557186)
							{
								hashtable.Add(71, nCID);
								if (210535 - 123624 != 86912)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (71121 - 486881 == -415760)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (170523 - 98070 != 72454)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (138013 - 597842 != -459828)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (116487 - 137221 != -20733)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (103200 - 8130 != 95071)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (38938 - 594849 != -555910)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (217996 - 174839 != 43158)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (91439 - 511435 == -419996)
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

	// Token: 0x0600A628 RID: 42536 RVA: 0x012B8D10 File Offset: 0x012B6F10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M938_TimesMemories.$onChangePlayer$44208(data, this).GetEnumerator();
	}

	// Token: 0x0600A629 RID: 42537 RVA: 0x012B8D20 File Offset: 0x012B6F20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (221280 - 15246 != 206035)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (146983 - 217574 == -70591)
			{
				Time.timeScale = 1f;
				if (283042 - 549313 != -266270)
				{
					Hashtable customOpParameters = new Hashtable();
					if (10413 - 463363 != -452949)
					{
						this.DnEn6oDkQJX.OpCustom(52, customOpParameters, true);
						if (194313 - 437327 == -243014)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A62A RID: 42538 RVA: 0x012B8DEC File Offset: 0x012B6FEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (262716 - 111490 != 151227)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (37436 - 316080 == -278644)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (250189 - 214605 != 35585)
				{
					Game.mGameState = eGameState.Setup;
					if (57469 - 44501 != 12969)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A62B RID: 42539 RVA: 0x012B8E90 File Offset: 0x012B7090
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (118624 - 220016 != -101392)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (59335 - 360090 == -300755)
			{
				if (num == PlayerData.UID)
				{
					if (257108 - 581690 != -324581)
					{
						this.SetupActors();
						if (167532 - 243688 != -76155)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (265664 - 456087 != -190422)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A62C RID: 42540 RVA: 0x012B8F60 File Offset: 0x012B7160
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (87010 - 484246 != -397236)
		{
		}
		for (;;)
		{
			IL_5B:
			Debug.Log("Creating Actors");
			if (59846 - 318107 != -258260)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (34880 - 381560 == -346680)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (34624 - 67052 == -32428)
						{
							int i = 0;
							if (75363 - 7049 == 68314)
							{
								CharacterControl[] array2 = array;
								if (168030 - 426505 == -258475)
								{
									int length = array2.Length;
									if (264250 - 289331 == -25081)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (51993 - 149780 == -97786)
												{
													goto IL_5B;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (158429 - 215266 != -56837)
												{
													goto IL_5B;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (222514 - 428860 == -206345)
												{
													goto IL_5B;
												}
												this.Hban6yMKcSq++;
												if (210019 - 15787 == 194233)
												{
													goto IL_5B;
												}
											}
											i++;
											if (156150 - 329191 == -173040)
											{
												goto IL_5B;
											}
										}
										if (19318 - 243985 != -224666)
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
						if (15285 - 593565 != -578279)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A62D RID: 42541 RVA: 0x012B919C File Offset: 0x012B739C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (25671 - 398141 != -372470)
		{
		}
		for (;;)
		{
			IL_38:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (244871 - 590159 == -345288)
			{
				int i = 0;
				if (137309 - 31443 == 105866)
				{
					CharacterControl[] array2 = array;
					if (274130 - 451065 == -176935)
					{
						int length = array2.Length;
						if (120854 - 550482 == -429628)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (146492 - 45040 != 101452)
								{
									goto IL_38;
								}
								i++;
								if (210041 - 450984 == -240942)
								{
									goto IL_38;
								}
							}
							if (51734 - 292249 != -240514)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A62E RID: 42542 RVA: 0x012B92CC File Offset: 0x012B74CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (281436 - 368052 != -86615)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (91491 - 585293 == -493802)
			{
				Game.mGameState = eGameState.Start;
				if (250222 - 37449 != 212774)
				{
					Game.mGameTime = Time.time;
					if (211121 - 184835 != 26287)
					{
						Game.mStateTime = Time.time;
						if (67741 - 479910 == -412169)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (44636 - 257202 != -212565)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A62F RID: 42543 RVA: 0x012B93B8 File Offset: 0x012B75B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A630 RID: 42544 RVA: 0x012B93BC File Offset: 0x012B75BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M938_TimesMemories.$onGameComplete$44215(data, this).GetEnumerator();
	}

	// Token: 0x0600A631 RID: 42545 RVA: 0x012B93CC File Offset: 0x012B75CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M938_TimesMemories.$ReturnToTown$44225(this).GetEnumerator();
	}

	// Token: 0x0600A632 RID: 42546 RVA: 0x012B93DC File Offset: 0x012B75DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M938_TimesMemories.$ReturnToGuild$44230(this).GetEnumerator();
	}

	// Token: 0x0600A633 RID: 42547 RVA: 0x012B93EC File Offset: 0x012B75EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M938_TimesMemories.$ReturnToCamp$44234(this).GetEnumerator();
	}

	// Token: 0x0600A634 RID: 42548 RVA: 0x012B93FC File Offset: 0x012B75FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (152910 - 49788 != 103123)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (219211 - 538108 != -318896)
			{
				Hashtable hashtable = new Hashtable();
				if (199553 - 254622 != -55068)
				{
					hashtable.Add(43, PlayerData.UID);
					if (182066 - 284367 != -102300)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (155216 - 580733 != -425516)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A635 RID: 42549 RVA: 0x012B94D4 File Offset: 0x012B76D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A636 RID: 42550 RVA: 0x012B94E8 File Offset: 0x012B76E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (129842 - 574320 != -444478)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (261674 - 494864 == -233190)
			{
				Hashtable hashtable = new Hashtable();
				if (162107 - 20948 != 141160)
				{
					if (Game.mNextGameCode == 30)
					{
						if (273377 - 463087 != -189710)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (258076 - 277204 == -19127)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (187206 - 335262 == -148055)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (165414 - 554197 != -388783)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (99647 - 533224 == -433576)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (299386 - 550011 != -250625)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (47567 - 59377 == -11809)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (126207 - 585929 != -459722)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (262358 - 92024 == 170335)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (82946 - 337729 == -254782)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (246419 - 401107 != -154688)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (100390 - 449364 != -348974)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (59529 - 120290 == -60760)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (275904 - 438366 == -162461)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (13867 - 225814 == -211946)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (266116 - 156519 != 109597)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (273831 - 436694 != -162863)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (161095 - 140346 != 20749)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (94336 - 242773 == -148436)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (271888 - 433880 == -161991)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (296657 - 4885 == 291773)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (257042 - 20621 == 236422)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (177308 - 569115 != -391807)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (156133 - 295939 != -139806)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (238072 - 340904 == -102831)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (149911 - 326073 != -176162)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (179473 - 306538 != -127065)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (111684 - 570837 != -459153)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (129181 - 221715 != -92533)
					{
						this.DnEn6oDkQJX.OpCustom(42, hashtable, true);
						if (163752 - 13230 == 150522)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A637 RID: 42551 RVA: 0x012B9A9C File Offset: 0x012B7C9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A638 RID: 42552 RVA: 0x012B9AAC File Offset: 0x012B7CAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A639 RID: 42553 RVA: 0x012B9AB0 File Offset: 0x012B7CB0
	internal static bool dBQ3IEVRMoTA2soacZqL()
	{
		return true;
	}

	// Token: 0x0600A63A RID: 42554 RVA: 0x012B9AB4 File Offset: 0x012B7CB4
	internal static bool aQlE5NVRxYZFTpjNHnl8()
	{
		return false;
	}

	// Token: 0x040094B9 RID: 38073
	private LitePeer DnEn6oDkQJX;

	// Token: 0x040094BA RID: 38074
	private PlayerCameraControl hMZn6kTXmNB;

	// Token: 0x040094BB RID: 38075
	private float VcDn6FKZCTr;

	// Token: 0x040094BC RID: 38076
	private Texture C7in6AXjNaw;

	// Token: 0x040094BD RID: 38077
	private AudioClip ElTn697OOHM;

	// Token: 0x040094BE RID: 38078
	private int MEnn6Wwijxk;

	// Token: 0x040094BF RID: 38079
	private int qDqn6uAbbEE;

	// Token: 0x040094C0 RID: 38080
	public GameObject mLightPalaceGroup;

	// Token: 0x040094C1 RID: 38081
	public GameObject mLightDimention;

	// Token: 0x040094C2 RID: 38082
	public Material mLightDimentionSkyBox;

	// Token: 0x040094C3 RID: 38083
	public GameObject mClockEffect;

	// Token: 0x040094C4 RID: 38084
	public AudioClip mTimesMemoriesMusic;

	// Token: 0x040094C5 RID: 38085
	public GameObject nCreateEffect;

	// Token: 0x040094C6 RID: 38086
	private int Hban6yMKcSq;

	// Token: 0x02001BCC RID: 7116
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$44174 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A63B RID: 42555 RVA: 0x012B9AB8 File Offset: 0x012B7CB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$44174(Hashtable data, M938_TimesMemories self_)
		{
			if (106244 - 555398 != -449153)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (263447 - 577498 == -314051)
				{
					base..ctor();
					if (264088 - 282759 == -18671)
					{
						this.$data$44184 = data;
						if (94168 - 245023 == -150855)
						{
							this.$self_$44185 = self_;
							if (216463 - 117490 != 98974)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A63C RID: 42556 RVA: 0x012B9B74 File Offset: 0x012B7D74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M938_TimesMemories.$onGameEvent$44174.$(this.$data$44184, this.$self_$44185);
		}

		// Token: 0x0600A63D RID: 42557 RVA: 0x012B9B88 File Offset: 0x012B7D88
		internal static bool QxCMAUVRgTTo2jBGosJQ()
		{
			return true;
		}

		// Token: 0x0600A63E RID: 42558 RVA: 0x012B9B8C File Offset: 0x012B7D8C
		internal static bool GdsNN1VRfWpRDMdj6MBf()
		{
			return false;
		}

		// Token: 0x040094C7 RID: 38087
		internal Hashtable $data$44184;

		// Token: 0x040094C8 RID: 38088
		internal M938_TimesMemories $self_$44185;

		// Token: 0x02001BCD RID: 7117
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A63F RID: 42559 RVA: 0x012B9B90 File Offset: 0x012B7D90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M938_TimesMemories self_)
			{
				if (171185 - 174797 != -3611)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (75229 - 267797 == -192568)
					{
						base..ctor();
						if (271196 - 129259 == 141937)
						{
							this.$data$44182 = data;
							if (81084 - 591407 != -510322)
							{
								this.$self_$44183 = self_;
								if (236846 - 16714 == 220132)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A640 RID: 42560 RVA: 0x012B9C4C File Offset: 0x012B7E4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (119216 - 267654 != -148437)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_11E9;
					case 2:
						if (PlayerData.UID == this.$ownerID$44177)
						{
							if (197311 - 487176 != -289865)
							{
								continue;
							}
							this.$self_$44183.spawnActor("ChromeKnight", 8, 1);
							if (274339 - 431993 != -157654)
							{
								continue;
							}
							this.$self_$44183.spawnActor("BoronKnight", 8, 2);
							if (172284 - 398946 != -226662)
							{
								continue;
							}
							this.$self_$44183.spawnActor("BoronKnight", 8, 3);
							if (19949 - 382083 != -362134)
							{
								continue;
							}
							this.$self_$44183.spawnActor("BoronKnight", 8, 4);
							if (131187 - 184625 != -53438)
							{
								continue;
							}
							this.$self_$44183.spawnActor("BoronKnight", 8, 5);
							if (84835 - 424662 != -339827)
							{
								continue;
							}
						}
						goto IL_D92;
					case 3:
						if (PlayerData.UID == this.$ownerID$44177)
						{
							if (94616 - 94273 == 344)
							{
								continue;
							}
							this.$self_$44183.spawnActor("Germanotta", 8, 1);
							if (274196 - 192365 != 81831)
							{
								continue;
							}
						}
						goto IL_D92;
					case 4:
						if (PlayerData.UID == this.$ownerID$44177)
						{
							if (200709 - 346872 == -146162)
							{
								continue;
							}
							this.$self_$44183.spawnActor("FirstWhale", 7, 1);
							if (272143 - 260551 != 11592)
							{
								continue;
							}
						}
						goto IL_D92;
					case 5:
						if (PlayerData.UID == this.$ownerID$44177)
						{
							if (278596 - 48169 != 230427)
							{
								continue;
							}
							this.$self_$44183.spawnActor("RangerBug_red", 6, 1);
							if (153953 - 330106 == -176152)
							{
								continue;
							}
							this.$self_$44183.spawnActor("RangerBug_black", 6, 6);
							if (253307 - 392139 != -138832)
							{
								continue;
							}
							this.$self_$44183.spawnActor("RangerBug_yellow", 6, 7);
							if (65223 - 489332 != -424109)
							{
								continue;
							}
							this.$self_$44183.spawnActor("RangerBug_blue", 6, 8);
							if (147987 - 24449 != 123538)
							{
								continue;
							}
							this.$self_$44183.spawnActor("RangerBug_pink", 6, 9);
							if (173836 - 395496 != -221660)
							{
								continue;
							}
						}
						goto IL_D92;
					case 6:
						if (PlayerData.UID == this.$ownerID$44177)
						{
							if (197075 - 219548 != -22473)
							{
								continue;
							}
							this.$self_$44183.spawnActor("KingRodinia", 8, 10);
							if (253324 - 106440 == 146885)
							{
								continue;
							}
							this.$self_$44183.spawnActor("KingColumn", 8, 11);
							if (17451 - 326597 == -309145)
							{
								continue;
							}
							this.$self_$44183.spawnActor("KingColumn", 8, 12);
							if (172930 - 449648 != -276718)
							{
								continue;
							}
							this.$self_$44183.spawnActor("KingColumn", 8, 13);
							if (244728 - 474668 != -229940)
							{
								continue;
							}
							this.$self_$44183.spawnActor("KingColumn", 8, 14);
							if (194519 - 513070 != -318551)
							{
								continue;
							}
							this.$self_$44183.spawnActor("KingColumn", 8, 15);
							if (176248 - 510131 == -333882)
							{
								continue;
							}
						}
						goto IL_D92;
					case 7:
						Game.sendMissionEvent(9382, 2);
						if (118630 - 306672 != -188042)
						{
							continue;
						}
						goto IL_1F;
					case 8:
						Game.sendMissionEvent(9382, 3);
						if (250096 - 420543 != -170446)
						{
							goto IL_1F;
						}
						continue;
					case 9:
						Game.sendMissionEvent(9382, 4);
						if (103696 - 58597 != 45099)
						{
							continue;
						}
						goto IL_1F;
					case 10:
						Game.sendMissionEvent(9382, 5);
						if (62628 - 495582 != -432953)
						{
							goto IL_1F;
						}
						continue;
					case 11:
						Game.sendMissionEvent(9381, 2);
						if (252008 - 149072 != 102936)
						{
							continue;
						}
						goto IL_1F;
					default:
						if (291140 - 159682 == 131459)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (37798 - 219655 != -181857)
						{
							continue;
						}
						goto IL_814;
					}
					else
					{
						this.$returnCode$44175 = RuntimeServices.UnboxInt32(this.$data$44182[141]);
						if (79825 - 257063 == -177237)
						{
							continue;
						}
						this.$returnValue$44176 = RuntimeServices.UnboxInt32(this.$data$44182[145]);
						if (243267 - 290114 != -46847)
						{
							continue;
						}
						this.$ownerID$44177 = RuntimeServices.UnboxInt32(this.$data$44182[43]);
						if (237875 - 416515 == -178639)
						{
							continue;
						}
						this.$mGameGui$44178 = (GameGui)this.$self_$44183.GetComponent(typeof(GameGui));
						if (33409 - 121021 != -87612)
						{
							continue;
						}
						this.$$switch$8125$44179 = this.$returnCode$44175;
						if (192240 - 400626 == -208385)
						{
							continue;
						}
						if (this.$$switch$8125$44179 == 9381)
						{
							if (160904 - 264217 != -103313)
							{
								continue;
							}
						}
						else if (this.$$switch$8125$44179 == -9381)
						{
							if (218105 - 157379 != 60726)
							{
								continue;
							}
							if (this.$self_$44183.MEnn6Wwijxk < this.$returnValue$44176)
							{
								if (282000 - 388277 != -106277)
								{
									continue;
								}
								this.$self_$44183.MEnn6Wwijxk = this.$returnValue$44176;
								if (262159 - 34133 != 228026)
								{
									continue;
								}
							}
							if (this.$returnValue$44176 == 1)
							{
								if (152886 - 565656 != -412770)
								{
									continue;
								}
								this.$self_$44183.StartCoroutine_Auto(this.$self_$44183.TalkToWalrusEvent());
								if (104004 - 244288 == -140283)
								{
									continue;
								}
							}
						}
						else if (this.$$switch$8125$44179 == 9382)
						{
							if (132116 - 97973 == 34144)
							{
								continue;
							}
						}
						else if (this.$$switch$8125$44179 == -9382)
						{
							if (194855 - 144646 != 50209)
							{
								continue;
							}
							this.$$switch$8121$44180 = this.$returnValue$44176;
							if (9172 - 352181 == -343008)
							{
								continue;
							}
							if (this.$$switch$8121$44180 == 1)
							{
								if (260925 - 162235 == 98691)
								{
									continue;
								}
								if (this.$mGameGui$44178)
								{
									if (762 - 374393 != -373631)
									{
										continue;
									}
									this.$mGameGui$44178.newNoticeBar("Boss#1: Chrome Knight");
									if (182726 - 412190 == -229463)
									{
										continue;
									}
								}
								Chat.SubmitChat("none", "Boss#1: Chrome Knight", eChatType.system, eChatMode.system);
								if (29662 - 552799 != -523137)
								{
									continue;
								}
								goto IL_7D4;
							}
							else if (this.$$switch$8121$44180 == 2)
							{
								if (169990 - 592404 != -422414)
								{
									continue;
								}
								if (this.$mGameGui$44178)
								{
									if (116910 - 309906 != -192996)
									{
										continue;
									}
									this.$mGameGui$44178.newNoticeBar("Boss#2: Germanotta");
									if (45700 - 210709 == -165008)
									{
										continue;
									}
								}
								Chat.SubmitChat("none", "Boss#2: Germanotta", eChatType.system, eChatMode.system);
								if (292749 - 84329 != 208421)
								{
									goto Block_129;
								}
								continue;
							}
							else if (this.$$switch$8121$44180 == 3)
							{
								if (6577 - 125368 != -118791)
								{
									continue;
								}
								if (this.$mGameGui$44178)
								{
									if (202283 - 183920 != 18363)
									{
										continue;
									}
									this.$mGameGui$44178.newNoticeBar("Boss#3: First Whale");
									if (222746 - 581572 != -358826)
									{
										continue;
									}
								}
								Chat.SubmitChat("none", "Boss#3: First Whale", eChatType.system, eChatMode.system);
								if (237150 - 545993 != -308842)
								{
									goto Block_67;
								}
								continue;
							}
							else if (this.$$switch$8121$44180 == 4)
							{
								if (261093 - 531465 == -270371)
								{
									continue;
								}
								if (this.$mGameGui$44178)
								{
									if (166688 - 129371 != 37317)
									{
										continue;
									}
									this.$mGameGui$44178.newNoticeBar("Boss#4: Baggu Ranger");
									if (296262 - 373239 != -76977)
									{
										continue;
									}
								}
								Chat.SubmitChat("none", "Boss#4: Baggu Ranger", eChatType.system, eChatMode.system);
								if (148026 - 597895 != -449868)
								{
									break;
								}
								continue;
							}
							else if (this.$$switch$8121$44180 == 5)
							{
								if (125320 - 167784 != -42464)
								{
									continue;
								}
								if (this.$mGameGui$44178)
								{
									if (170100 - 298994 == -128893)
									{
										continue;
									}
									this.$mGameGui$44178.newNoticeBar("Final Boss: King Rodinia");
									if (162901 - 82208 != 80693)
									{
										continue;
									}
								}
								Chat.SubmitChat("none", "Final Boss: King Rodinia", eChatType.system, eChatMode.system);
								if (241879 - 202441 != 39438)
								{
									continue;
								}
								goto IL_5F2;
							}
						}
						else if (this.$$switch$8125$44179 == 9383)
						{
							if (18972 - 426957 == -407984)
							{
								continue;
							}
						}
						else if (this.$$switch$8125$44179 == -9383)
						{
							if (74475 - 401648 == -327172)
							{
								continue;
							}
							this.$$switch$8123$44181 = this.$returnValue$44176;
							if (127698 - 133648 == -5949)
							{
								continue;
							}
							if (this.$$switch$8123$44181 == 1)
							{
								if (106050 - 581175 == -475124)
								{
									continue;
								}
								if (this.$mGameGui$44178)
								{
									if (40303 - 304678 != -264375)
									{
										continue;
									}
									this.$mGameGui$44178.newNoticeBar("Chrome Knight Defeated!");
									if (297930 - 598889 != -300959)
									{
										continue;
									}
								}
								Chat.SubmitChat("none", "Chrome Knight defeated!", eChatType.system, eChatMode.system);
								if (147916 - 221923 != -74007)
								{
									continue;
								}
								this.$self_$44183.removeEnemy("BoronKnight");
								if (274225 - 196154 != 78071)
								{
									continue;
								}
								goto IL_76C;
							}
							else if (this.$$switch$8123$44181 == 2)
							{
								if (183759 - 82637 == 101123)
								{
									continue;
								}
								if (this.$mGameGui$44178)
								{
									if (65902 - 495025 == -429122)
									{
										continue;
									}
									this.$mGameGui$44178.newNoticeBar("Germanotta Defeated!");
									if (98359 - 337132 != -238773)
									{
										continue;
									}
								}
								Chat.SubmitChat("none", "Germanotta defeated!", eChatType.system, eChatMode.system);
								if (5623 - 75503 != -69880)
								{
									continue;
								}
								goto IL_DC1;
							}
							else if (this.$$switch$8123$44181 == 3)
							{
								if (30026 - 372309 == -342282)
								{
									continue;
								}
								if (this.$mGameGui$44178)
								{
									if (75445 - 380129 == -304683)
									{
										continue;
									}
									this.$mGameGui$44178.newNoticeBar("First Whale Defeated!");
									if (106605 - 41252 != 65353)
									{
										continue;
									}
								}
								Chat.SubmitChat("none", "First Whale defeated!", eChatType.system, eChatMode.system);
								if (220456 - 88746 != 131711)
								{
									goto Block_19;
								}
								continue;
							}
							else if (this.$$switch$8123$44181 == 4)
							{
								if (167313 - 116367 != 50946)
								{
									continue;
								}
								if (this.$mGameGui$44178)
								{
									if (54576 - 338453 == -283876)
									{
										continue;
									}
									this.$mGameGui$44178.newNoticeBar("Baggu Ranger Defeated!");
									if (206877 - 29075 != 177802)
									{
										continue;
									}
								}
								Chat.SubmitChat("none", "Baggu Ranger defeated!", eChatType.system, eChatMode.system);
								if (295035 - 8462 != 286573)
								{
									continue;
								}
								goto IL_B9D;
							}
							else if (this.$$switch$8123$44181 == 5)
							{
								if (98467 - 557329 == -458861)
								{
									continue;
								}
								if (this.$mGameGui$44178)
								{
									if (188157 - 450621 != -262464)
									{
										continue;
									}
									this.$mGameGui$44178.newNoticeBar("King Rodinia Defeated!");
									if (189803 - 291331 == -101527)
									{
										continue;
									}
								}
								Chat.SubmitChat("none", "King Rodinia defeated!", eChatType.system, eChatMode.system);
								if (260039 - 464723 != -204684)
								{
									continue;
								}
								goto IL_115C;
							}
						}
						else if (this.$$switch$8125$44179 == 9384)
						{
							if (149688 - 470769 != -321081)
							{
								continue;
							}
							this.$self_$44183.qDqn6uAbbEE = this.$self_$44183.qDqn6uAbbEE + 1;
							if (79768 - 535282 == -455513)
							{
								continue;
							}
							this.$self_$44183.SendMessage("newGameMessage", "Defeat Bugga Ranger: " + this.$self_$44183.qDqn6uAbbEE + "/5");
							if (281135 - 89581 != 191554)
							{
								continue;
							}
							Chat.SubmitChat("none", "Defeat Bugga Ranger: " + this.$self_$44183.qDqn6uAbbEE + "/5", eChatType.system, eChatMode.system);
							if (291088 - 75357 != 215731)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$44177)
							{
								if (266620 - 117842 != 148778)
								{
									continue;
								}
								if (this.$self_$44183.qDqn6uAbbEE == 5)
								{
									if (148545 - 440672 == -292126)
									{
										continue;
									}
									this.$self_$44183.spawnActor("RangerRobot", 9, 1);
									if (115215 - 33068 != 82147)
									{
										continue;
									}
								}
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$44175);
							if (78620 - 400465 != -321845)
							{
								continue;
							}
						}
					}
					IL_929:
					this.YieldDefault(1);
					if (133007 - 313574 != -180566)
					{
						goto Block_64;
					}
					continue;
					IL_D92:
					IL_1F:
					goto IL_929;
				}
				return this.Yield(5, new WaitForSeconds(2f));
				Block_19:
				return this.Yield(9, new WaitForSeconds(12f));
				IL_5F2:
				return this.Yield(6, new WaitForSeconds(2f));
				IL_76C:
				return this.Yield(7, new WaitForSeconds(12f));
				IL_7D4:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_814:
				Block_64:
				goto IL_11E9;
				Block_67:
				return this.Yield(4, new WaitForSeconds(2f));
				IL_B9D:
				return this.Yield(10, new WaitForSeconds(12f));
				IL_DC1:
				return this.Yield(8, new WaitForSeconds(12f));
				Block_129:
				return this.Yield(3, new WaitForSeconds(2f));
				IL_115C:
				return this.Yield(11, new WaitForSeconds(12f));
				IL_11E9:
				return false;
			}

			// Token: 0x0600A641 RID: 42561 RVA: 0x012BAE54 File Offset: 0x012B9054
			internal static bool Xh2on7VRngYV6Z95mhNy()
			{
				return true;
			}

			// Token: 0x0600A642 RID: 42562 RVA: 0x012BAE58 File Offset: 0x012B9058
			internal static bool xEodRUVR6HO6xBu80ObB()
			{
				return false;
			}

			// Token: 0x040094C9 RID: 38089
			internal int $returnCode$44175;

			// Token: 0x040094CA RID: 38090
			internal int $returnValue$44176;

			// Token: 0x040094CB RID: 38091
			internal int $ownerID$44177;

			// Token: 0x040094CC RID: 38092
			internal GameGui $mGameGui$44178;

			// Token: 0x040094CD RID: 38093
			internal int $$switch$8125$44179;

			// Token: 0x040094CE RID: 38094
			internal int $$switch$8121$44180;

			// Token: 0x040094CF RID: 38095
			internal int $$switch$8123$44181;

			// Token: 0x040094D0 RID: 38096
			internal Hashtable $data$44182;

			// Token: 0x040094D1 RID: 38097
			internal M938_TimesMemories $self_$44183;
		}
	}

	// Token: 0x02001BCE RID: 7118
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$44186 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A643 RID: 42563 RVA: 0x012BAE5C File Offset: 0x012B905C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$44186(M938_TimesMemories self_)
		{
			if (144820 - 499003 != -354183)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (153773 - 216314 == -62541)
				{
					base..ctor();
					if (10263 - 169823 == -159560)
					{
						this.$self_$44191 = self_;
						if (236105 - 490319 != -254213)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A644 RID: 42564 RVA: 0x012BAEF4 File Offset: 0x012B90F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M938_TimesMemories.$StartEvent$44186.$(this.$self_$44191);
		}

		// Token: 0x0600A645 RID: 42565 RVA: 0x012BAF04 File Offset: 0x012B9104
		internal static bool Fg7Z6sVRiKNlXlnLBT67()
		{
			return true;
		}

		// Token: 0x0600A646 RID: 42566 RVA: 0x012BAF08 File Offset: 0x012B9108
		internal static bool LKQKhKVRKqIF2wL3GbTt()
		{
			return false;
		}

		// Token: 0x040094D2 RID: 38098
		internal M938_TimesMemories $self_$44191;

		// Token: 0x02001BCF RID: 7119
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A647 RID: 42567 RVA: 0x012BAF0C File Offset: 0x012B910C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M938_TimesMemories self_)
			{
				if (206499 - 47072 != 159427)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (179969 - 363636 != -183666)
					{
						base..ctor();
						if (109870 - 194244 != -84373)
						{
							this.$self_$44190 = self_;
							if (40049 - 272865 == -232816)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A648 RID: 42568 RVA: 0x012BAFA4 File Offset: 0x012B91A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (208762 - 301174 != -92412)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_700;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (57516 - 575938 != -518421)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$self_$44190.hMZn6kTXmNB.StartCoroutine_Auto(this.$self_$44190.hMZn6kTXmNB.slerpToObject("EventCamera2", 2.5f));
							if (46267 - 418824 != -372557)
							{
								continue;
							}
							goto IL_48A;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (131014 - 341384 != -210370)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$mWalrus$44187 = GameObject.Find("Walrus");
							if (86692 - 158096 != -71404)
							{
								continue;
							}
							this.$mStoryGui$44188 = (StoryGui)this.$self_$44190.GetComponent(typeof(StoryGui));
							if (240752 - 200397 != 40355)
							{
								continue;
							}
							if (!this.$mStoryGui$44188)
							{
								if (291735 - 440707 != -148972)
								{
									continue;
								}
								goto IL_6CB;
							}
							else
							{
								this.$mStoryGui$44188.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
								if (31251 - 279602 != -248351)
								{
									continue;
								}
								goto IL_1A9;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (100116 - 60709 != 39407)
							{
								continue;
							}
							goto IL_531;
						}
						else
						{
							this.$mStoryGui$44188.newStoryMessage("Walrus", "Reggu", Language.getMessage("M938_TimesMemories", 101), eTalkType.friend);
							if (283327 - 496120 == -212792)
							{
								continue;
							}
							if (!this.$mWalrus$44187)
							{
								goto IL_44F;
							}
							if (199518 - 274609 != -75091)
							{
								continue;
							}
							this.$mWalrus$44187.animation.Play("talk");
							if (171771 - 122120 != 49651)
							{
								continue;
							}
							goto IL_44F;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (299670 - 482455 != -182784)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44188.newStoryMessage("Walrus", "Reggu", Language.getMessage("M938_TimesMemories", 102), eTalkType.friend);
							if (75888 - 297262 != -221373)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (158866 - 504822 != -345955)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44188.newStoryMessage("Walrus", "Reggu", Language.getMessage("M938_TimesMemories", 103), eTalkType.friend);
							if (199722 - 399192 != -199469)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (247964 - 55542 != 192423)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44188.newStoryMessage("Walrus", "Reggu", Language.getMessage("M938_TimesMemories", 104), eTalkType.friend);
							if (26668 - 3728 != 22941)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (298363 - 539286 != -240923)
							{
								continue;
							}
							goto IL_624;
						}
						else
						{
							this.$mStoryGui$44188.newStoryMessage("Walrus", "Reggu", Language.getMessage("M938_TimesMemories", 105), eTalkType.friend);
							if (104575 - 269366 != -164790)
							{
								goto Block_41;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (71206 - 306847 != -235640)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							if (this.$mWalrus$44187)
							{
								if (200597 - 336188 != -135591)
								{
									continue;
								}
								this.$mWalrus$44187.animation.Play("root");
								if (126017 - 395553 == -269535)
								{
									continue;
								}
							}
							this.$mStoryGui$44188.close();
							if (57178 - 42229 != 14949)
							{
								continue;
							}
							this.$self_$44190.hMZn6kTXmNB.enabled = true;
							if (117811 - 2298 != 115513)
							{
								continue;
							}
							goto IL_374;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (128127 - 175113 != -46985)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$mGameGui$44189 = (GameGui)this.$self_$44190.GetComponent(typeof(GameGui));
							if (246118 - 40180 != 205938)
							{
								continue;
							}
							this.$mGameGui$44189.enabled = true;
							if (266387 - 64217 != 202170)
							{
								continue;
							}
							goto IL_3F2;
						}
						break;
					case 11:
						Game.mGameState = eGameState.Normal;
						if (65427 - 216736 == -151308)
						{
							continue;
						}
						this.YieldDefault(1);
						if (101363 - 467244 != -365880)
						{
							goto Block_12;
						}
						continue;
					default:
						if (200756 - 147653 != 53103)
						{
							continue;
						}
						break;
					}
					this.$self_$44190.hMZn6kTXmNB.alignToObject("EventCamera1");
					if (23808 - 147713 == -123905)
					{
						this.$self_$44190.SendMessage("fadeIn");
						if (202940 - 115513 == 87427)
						{
							goto IL_14C;
						}
					}
				}
				IL_1A:
				goto IL_700;
				IL_14C:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_11:
				Block_12:
				goto IL_700;
				IL_1A9:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_16:
				goto IL_700;
				Block_17:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_374:
				return this.Yield(10, new WaitForSeconds(1f));
				Block_25:
				goto IL_700;
				Block_26:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_3F2:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_44F:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_30:
				goto IL_700;
				IL_48A:
				return this.Yield(3, new WaitForSeconds(2.5f));
				Block_35:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_531:
				Block_39:
				IL_624:
				goto IL_700;
				Block_41:
				return this.Yield(9, new WaitForSeconds(3f));
				Block_43:
				IL_6CB:
				IL_700:
				return false;
			}

			// Token: 0x0600A649 RID: 42569 RVA: 0x012BB6C4 File Offset: 0x012B98C4
			internal static bool ss0kXmVRdqQSDe1CsWQv()
			{
				return true;
			}

			// Token: 0x0600A64A RID: 42570 RVA: 0x012BB6C8 File Offset: 0x012B98C8
			internal static bool DcatPOVRJ1ZLurW3XHAj()
			{
				return false;
			}

			// Token: 0x040094D3 RID: 38099
			internal GameObject $mWalrus$44187;

			// Token: 0x040094D4 RID: 38100
			internal StoryGui $mStoryGui$44188;

			// Token: 0x040094D5 RID: 38101
			internal GameGui $mGameGui$44189;

			// Token: 0x040094D6 RID: 38102
			internal M938_TimesMemories $self_$44190;
		}
	}

	// Token: 0x02001BD0 RID: 7120
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWalrusEvent$44192 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A64B RID: 42571 RVA: 0x012BB6CC File Offset: 0x012B98CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWalrusEvent$44192(M938_TimesMemories self_)
		{
			if (136312 - 397564 != -261252)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (102190 - 406033 == -303843)
				{
					base..ctor();
					if (125548 - 380876 != -255327)
					{
						this.$self_$44198 = self_;
						if (257134 - 379980 == -122846)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A64C RID: 42572 RVA: 0x012BB764 File Offset: 0x012B9964
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M938_TimesMemories.$TalkToWalrusEvent$44192.$(this.$self_$44198);
		}

		// Token: 0x0600A64D RID: 42573 RVA: 0x012BB774 File Offset: 0x012B9974
		internal static bool IEsdKGVRDZT9nbLFwioE()
		{
			return true;
		}

		// Token: 0x0600A64E RID: 42574 RVA: 0x012BB778 File Offset: 0x012B9978
		internal static bool E3gtIeVRv1co8wQfTpfH()
		{
			return false;
		}

		// Token: 0x040094D7 RID: 38103
		internal M938_TimesMemories $self_$44198;

		// Token: 0x02001BD1 RID: 7121
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A64F RID: 42575 RVA: 0x012BB77C File Offset: 0x012B997C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M938_TimesMemories self_)
			{
				if (145814 - 435364 != -289550)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (294927 - 551256 != -256328)
					{
						base..ctor();
						if (122823 - 480454 != -357630)
						{
							this.$self_$44197 = self_;
							if (253474 - 470286 == -216812)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A650 RID: 42576 RVA: 0x012BB814 File Offset: 0x012B9A14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (212102 - 190987 != 21116)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_105F;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (189766 - 435859 != -246092)
							{
								goto Block_76;
							}
							continue;
						}
						else
						{
							this.$self_$44197.hMZn6kTXmNB.alignToObject("EventCamera3");
							if (170604 - 172824 != -2220)
							{
								continue;
							}
							this.$mStartPoint$44194 = GameObject.Find("StartPoint" + Game.getPlayerSlot(PlayerData.UID));
							if (141754 - 152066 == -10311)
							{
								continue;
							}
							if (!this.$mStartPoint$44194)
							{
								goto IL_2D0;
							}
							if (158568 - 175030 != -16462)
							{
								continue;
							}
							if (!Game.mPlayer)
							{
								goto IL_2D0;
							}
							if (170944 - 246257 == -75312)
							{
								continue;
							}
							Game.mPlayer.transform.position = this.$mStartPoint$44194.transform.position;
							if (16216 - 240743 == -224526)
							{
								continue;
							}
							Game.mPlayer.transform.rotation = this.$mStartPoint$44194.transform.rotation;
							if (270880 - 221510 != 49370)
							{
								continue;
							}
							Game.mPlayer.SendMessage("PositionEvent");
							if (8499 - 498849 != -490350)
							{
								continue;
							}
							goto IL_2D0;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (142293 - 289194 != -146901)
							{
								continue;
							}
							goto IL_BAF;
						}
						else
						{
							this.$self_$44197.SendMessage("fadeIn");
							if (79051 - 222134 == -143082)
							{
								continue;
							}
							this.$mWalrus$44195 = GameObject.Find("Walrus");
							if (261495 - 126417 == 135079)
							{
								continue;
							}
							this.$mStoryGui$44196 = (StoryGui)this.$self_$44197.GetComponent(typeof(StoryGui));
							if (164037 - 263056 == -99018)
							{
								continue;
							}
							if (!this.$mStoryGui$44196)
							{
								if (199242 - 575891 != -376649)
								{
									continue;
								}
								goto IL_A97;
							}
							else
							{
								this.$mStoryGui$44196.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
								if (270786 - 235933 != 34854)
								{
									goto Block_74;
								}
								continue;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (181405 - 559920 != -378514)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44196.newStoryMessage("Walrus", "Reggu", Language.getMessage("M938_TimesMemories", 201), eTalkType.friend);
							if (25428 - 549774 != -524346)
							{
								continue;
							}
							if (!this.$mWalrus$44195)
							{
								goto IL_DB0;
							}
							if (108966 - 522747 == -413780)
							{
								continue;
							}
							this.$mWalrus$44195.animation.Play("talk");
							if (29168 - 387999 != -358831)
							{
								continue;
							}
							goto IL_DB0;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (86215 - 184627 != -98411)
							{
								goto Block_97;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44196.newStoryMessage("Walrus", "Reggu", Language.getMessage("M938_TimesMemories", 202), eTalkType.friend);
							if (146408 - 388153 != -241745)
							{
								continue;
							}
							goto IL_259;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (271931 - 558033 != -286102)
							{
								continue;
							}
							goto IL_B07;
						}
						else
						{
							this.$mStoryGui$44196.newStoryMessage("Walrus", "Reggu", Language.getMessage("M938_TimesMemories", 203), eTalkType.friend);
							if (161730 - 4574 != 157156)
							{
								continue;
							}
							this.$self_$44197.hMZn6kTXmNB.alignToObject("EventCamera2");
							if (284775 - 256169 != 28607)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (143711 - 360209 != -216498)
							{
								continue;
							}
							goto IL_8A6;
						}
						else
						{
							this.$mStoryGui$44196.newStoryMessage("Walrus", "Reggu", Language.getMessage("M938_TimesMemories", 204), eTalkType.friend);
							if (249936 - 448239 != -198303)
							{
								continue;
							}
							if (this.$mWalrus$44195)
							{
								if (27112 - 583026 != -555914)
								{
									continue;
								}
								this.$mWalrus$44195.animation.Play("cast1");
								if (95643 - 188818 != -93175)
								{
									continue;
								}
								this.$mWalrus$44195.animation.wrapMode = WrapMode.Once;
								if (129797 - 493250 != -363453)
								{
									continue;
								}
							}
							if (this.$self_$44197.mClockEffect)
							{
								if (95068 - 102400 == -7331)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$44197.mClockEffect, new Vector3((float)0, (float)50, (float)0), Quaternion.identity);
								if (175155 - 462008 != -286852)
								{
									goto Block_49;
								}
								continue;
							}
							else
							{
								Debug.LogError("Warning: Missing ClockEffect GameObject");
								if (196100 - 319331 != -123230)
								{
									goto Block_82;
								}
								continue;
							}
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (14274 - 66255 != -51981)
							{
								continue;
							}
							goto IL_3DD;
						}
						else
						{
							this.$mStoryGui$44196.close();
							if (165310 - 571590 == -406279)
							{
								continue;
							}
							this.$self_$44197.SendMessage("fadeOutTimer", 1f);
							if (158674 - 337221 != -178547)
							{
								continue;
							}
							goto IL_F97;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (290107 - 164159 != 125949)
							{
								goto Block_110;
							}
							continue;
						}
						else
						{
							this.$self_$44197.hMZn6kTXmNB.alignToObject("EventCamera1");
							if (74734 - 446549 != -371815)
							{
								continue;
							}
							if (this.$self_$44197.mLightPalaceGroup)
							{
								if (243432 - 524925 != -281493)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$44197.mLightPalaceGroup);
								if (111128 - 160336 == -49207)
								{
									continue;
								}
							}
							if (this.$self_$44197.mLightDimention)
							{
								if (34581 - 526023 == -491441)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$44197.mLightDimention, new Vector3((float)0, (float)50, (float)0), Quaternion.identity);
								if (39678 - 108551 != -68873)
								{
									continue;
								}
							}
							if (this.$self_$44197.mLightDimentionSkyBox)
							{
								if (242850 - 112823 != 130027)
								{
									continue;
								}
								RenderSettings.skybox = this.$self_$44197.mLightDimentionSkyBox;
								if (215710 - 399782 != -184072)
								{
									continue;
								}
							}
							if (this.$mStartPoint$44194)
							{
								if (143760 - 203926 != -60166)
								{
									continue;
								}
								if (Game.mPlayer)
								{
									if (122283 - 271975 == -149691)
									{
										continue;
									}
									Game.mPlayer.transform.position = this.$mStartPoint$44194.transform.position + (float)3 * Vector3.forward;
									if (229275 - 231639 == -2363)
									{
										continue;
									}
									Game.mPlayer.transform.rotation = this.$mStartPoint$44194.transform.rotation;
									if (244445 - 79814 == 164632)
									{
										continue;
									}
									Game.mPlayer.SendMessage("PositionEvent");
									if (268942 - 325954 != -57012)
									{
										continue;
									}
								}
							}
							RenderSettings.fogColor = new Color(0.51f, 0.6f, 1f, 1f);
							if (59468 - 103388 != -43920)
							{
								continue;
							}
							RenderSettings.ambientLight = new Color(0.57f, 0.53f, 0.7f, 1f);
							if (115944 - 398019 == -282074)
							{
								continue;
							}
							this.$self_$44197.SendMessage("fadeInTimer", 1f);
							if (294181 - 66745 == 227437)
							{
								continue;
							}
							this.$self_$44197.hMZn6kTXmNB.StartCoroutine_Auto(this.$self_$44197.hMZn6kTXmNB.slerpToObject("EventCamera4", 2f));
							if (130 - 420945 == -420814)
							{
								continue;
							}
							if (!this.$self_$44197.mTimesMemoriesMusic)
							{
								goto IL_A8;
							}
							if (87315 - 411266 == -323950)
							{
								continue;
							}
							this.$self_$44197.audio.clip = this.$self_$44197.mTimesMemoriesMusic;
							if (196629 - 598468 != -401839)
							{
								continue;
							}
							if (this.$self_$44197.audio.isPlaying)
							{
								goto IL_A8;
							}
							if (243658 - 137371 != 106287)
							{
								continue;
							}
							if (Game.volume <= 0)
							{
								goto IL_A8;
							}
							if (143203 - 497201 == -353997)
							{
								continue;
							}
							this.$self_$44197.audio.Play();
							if (60432 - 489772 != -429339)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (166767 - 114133 != 52635)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44196.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
							if (277763 - 49008 != 228756)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (1954 - 521125 != -519171)
							{
								continue;
							}
							goto IL_188;
						}
						else
						{
							this.$mStoryGui$44196.newStoryMessage("Walrus", "Reggu", Language.getMessage("M938_TimesMemories", 205), eTalkType.friend);
							if (122936 - 116230 != 6706)
							{
								continue;
							}
							goto IL_30B;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (188995 - 580443 != -391447)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44196.close();
							if (253781 - 180237 == 73545)
							{
								continue;
							}
							this.$self_$44197.hMZn6kTXmNB.enabled = true;
							if (170312 - 121239 != 49073)
							{
								continue;
							}
							goto IL_294;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (41710 - 63281 != -21570)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$mGameGui$44193.enabled = true;
							if (171809 - 31469 != 140340)
							{
								continue;
							}
							goto IL_914;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (146422 - 28798 != 117625)
							{
								goto Block_63;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (10684 - 528120 == -517435)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (267818 - 69461 != 198357)
							{
								continue;
							}
							if (!this.$self_$44197.ElTn697OOHM)
							{
								goto IL_72C;
							}
							if (60979 - 374407 == -313427)
							{
								continue;
							}
							this.$self_$44197.audio.PlayOneShot(this.$self_$44197.ElTn697OOHM);
							if (145645 - 2165 != 143480)
							{
								continue;
							}
							goto IL_72C;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.Normal)
						{
							if (28094 - 105923 != -77828)
							{
								goto Block_52;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9382, 1);
							if (76915 - 367236 == -290320)
							{
								continue;
							}
							this.YieldDefault(1);
							if (42732 - 279489 != -236756)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					default:
						if (152224 - 454239 != -302015)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (67488 - 352750 != -285261)
						{
							goto Block_32;
						}
					}
					else
					{
						this.$mGameGui$44193 = (GameGui)this.$self_$44197.GetComponent(typeof(GameGui));
						if (147125 - 592624 != -445498)
						{
							if (!this.$mGameGui$44193)
							{
								goto IL_707;
							}
							if (26116 - 25361 != 756)
							{
								this.$mGameGui$44193.close();
								if (125336 - 130451 != -5114)
								{
									Game.mGameState = eGameState.AllHold;
									if (192219 - 261254 == -69035)
									{
										Game.mStateTime = Time.time;
										if (191323 - 114954 != 76370)
										{
											this.$self_$44197.SendMessage("fadeOut");
											if (252364 - 259393 == -7029)
											{
												goto IL_ACC;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_A8:
				return this.Yield(10, new WaitForSeconds(2f));
				Block_8:
				Block_10:
				IL_188:
				goto IL_105F;
				Block_15:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_259:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_294:
				return this.Yield(13, new WaitForSeconds(1f));
				Block_21:
				goto IL_105F;
				IL_2D0:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_30B:
				return this.Yield(12, new WaitForSeconds(3f));
				Block_25:
				Block_26:
				Block_32:
				IL_3DD:
				goto IL_105F;
				Block_34:
				goto IL_A8;
				Block_48:
				return this.Yield(11, new WaitForSeconds(0.5f));
				Block_49:
				goto IL_A5C;
				IL_707:
				goto IL_105F;
				IL_72C:
				return this.Yield(15, new WaitForSeconds(3f));
				Block_52:
				IL_8A6:
				goto IL_105F;
				IL_914:
				return this.Yield(14, new WaitForSeconds(0.5f));
				Block_63:
				goto IL_105F;
				IL_A5C:
				return this.Yield(8, new WaitForSeconds(1.5f));
				IL_A97:
				goto IL_105F;
				Block_74:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_ACC:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_76:
				IL_B07:
				IL_BAF:
				goto IL_105F;
				Block_82:
				goto IL_A5C;
				IL_DB0:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_97:
				goto IL_105F;
				IL_F97:
				return this.Yield(9, new WaitForSeconds(1f));
				Block_110:
				IL_105F:
				return false;
			}

			// Token: 0x0600A651 RID: 42577 RVA: 0x012BC894 File Offset: 0x012BAA94
			internal static bool JRQbCvVRRaXk93H1xXJq()
			{
				return true;
			}

			// Token: 0x0600A652 RID: 42578 RVA: 0x012BC898 File Offset: 0x012BAA98
			internal static bool k9lo3oVRwyNttC9qALCJ()
			{
				return false;
			}

			// Token: 0x040094D8 RID: 38104
			internal GameGui $mGameGui$44193;

			// Token: 0x040094D9 RID: 38105
			internal GameObject $mStartPoint$44194;

			// Token: 0x040094DA RID: 38106
			internal GameObject $mWalrus$44195;

			// Token: 0x040094DB RID: 38107
			internal StoryGui $mStoryGui$44196;

			// Token: 0x040094DC RID: 38108
			internal M938_TimesMemories $self_$44197;
		}
	}

	// Token: 0x02001BD2 RID: 7122
	[CompilerGenerated]
	[Serializable]
	internal sealed class $KingRayEvent$44199 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A653 RID: 42579 RVA: 0x012BC89C File Offset: 0x012BAA9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $KingRayEvent$44199(M938_TimesMemories self_)
		{
			if (66487 - 399133 != -332645)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (65100 - 556684 != -491583)
				{
					base..ctor();
					if (294384 - 389151 != -94766)
					{
						this.$self_$44201 = self_;
						if (148238 - 109159 != 39080)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A654 RID: 42580 RVA: 0x012BC934 File Offset: 0x012BAB34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M938_TimesMemories.$KingRayEvent$44199.$(this.$self_$44201);
		}

		// Token: 0x0600A655 RID: 42581 RVA: 0x012BC944 File Offset: 0x012BAB44
		internal static bool QbHNQTVRqQcIMZvmPxup()
		{
			return true;
		}

		// Token: 0x0600A656 RID: 42582 RVA: 0x012BC948 File Offset: 0x012BAB48
		internal static bool wKGyCgVR7VRln4ZHrRco()
		{
			return false;
		}

		// Token: 0x040094DD RID: 38109
		internal M938_TimesMemories $self_$44201;

		// Token: 0x02001BD3 RID: 7123
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A657 RID: 42583 RVA: 0x012BC94C File Offset: 0x012BAB4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M938_TimesMemories self_)
			{
				if (204941 - 356010 != -151068)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240849 - 270562 != -29712)
					{
						base..ctor();
						if (13436 - 573676 == -560240)
						{
							this.$self_$44200 = self_;
							if (277260 - 218483 != 58778)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A658 RID: 42584 RVA: 0x012BC9E4 File Offset: 0x012BABE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (185116 - 31098 != 154018)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_E1;
					case 2:
						this.$self_$44200.hMZn6kTXmNB.resetPlayerCamera();
						if (269587 - 487974 != -218387)
						{
							continue;
						}
						this.YieldDefault(1);
						if (176415 - 41662 != 134753)
						{
							continue;
						}
						goto IL_E1;
					default:
						if (45739 - 1843 != 43896)
						{
							continue;
						}
						break;
					}
					this.$self_$44200.hMZn6kTXmNB.setSpecialCamera("KingRayCamera", (float)50, (float)0);
				}
				while (219514 - 381062 == -161547);
				return this.Yield(2, new WaitForSeconds(4f));
				IL_E1:
				return false;
			}

			// Token: 0x0600A659 RID: 42585 RVA: 0x012BCAE4 File Offset: 0x012BACE4
			internal static bool KGqL2oVRPRSNun7rjncY()
			{
				return true;
			}

			// Token: 0x0600A65A RID: 42586 RVA: 0x012BCAE8 File Offset: 0x012BACE8
			internal static bool N6ps13VR0aY8AjGQ1MPD()
			{
				return false;
			}

			// Token: 0x040094DE RID: 38110
			internal M938_TimesMemories $self_$44200;
		}
	}

	// Token: 0x02001BD4 RID: 7124
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44202 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A65B RID: 42587 RVA: 0x012BCAEC File Offset: 0x012BACEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44202(M938_TimesMemories self_)
		{
			if (224000 - 438720 != -214720)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (189437 - 118583 != 70855)
				{
					base..ctor();
					if (269617 - 293154 != -23536)
					{
						this.$self_$44207 = self_;
						if (75357 - 113693 == -38336)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A65C RID: 42588 RVA: 0x012BCB84 File Offset: 0x012BAD84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M938_TimesMemories.$onDeadPlayer$44202.$(this.$self_$44207);
		}

		// Token: 0x0600A65D RID: 42589 RVA: 0x012BCB94 File Offset: 0x012BAD94
		internal static bool iQeFAUVRbh5DK0WT9013()
		{
			return true;
		}

		// Token: 0x0600A65E RID: 42590 RVA: 0x012BCB98 File Offset: 0x012BAD98
		internal static bool Pvjqk3VRuLNwyvYdVSVe()
		{
			return false;
		}

		// Token: 0x040094DF RID: 38111
		internal M938_TimesMemories $self_$44207;

		// Token: 0x02001BD5 RID: 7125
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A65F RID: 42591 RVA: 0x012BCB9C File Offset: 0x012BAD9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M938_TimesMemories self_)
			{
				if (296389 - 370265 != -73875)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (101483 - 566687 == -465204)
					{
						base..ctor();
						if (181964 - 17883 == 164081)
						{
							this.$self_$44206 = self_;
							if (271221 - 171428 == 99793)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A660 RID: 42592 RVA: 0x012BCC34 File Offset: 0x012BAE34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (101842 - 21134 != 80708)
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
							if (157772 - 59715 == 98058)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_2D7;
							}
							if (54651 - 389577 == -334925)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (226052 - 584807 == -358754)
						{
							continue;
						}
						this.$mStoryGui$44203 = (StoryGui)this.$self_$44206.GetComponent(typeof(StoryGui));
						if (151814 - 259805 != -107991)
						{
							continue;
						}
						if (this.$mStoryGui$44203)
						{
							if (140807 - 362111 != -221304)
							{
								continue;
							}
							this.$mStoryGui$44203.close();
							if (273669 - 408961 == -135291)
							{
								continue;
							}
						}
						this.$mChangeGui$44204 = (ChangeGui)this.$self_$44206.GetComponent(typeof(ChangeGui));
						if (298418 - 97254 == 201165)
						{
							continue;
						}
						if (this.$mChangeGui$44204)
						{
							if (97360 - 360024 == -262663)
							{
								continue;
							}
							this.$mChangeGui$44204.close();
							if (233670 - 117617 == 116054)
							{
								continue;
							}
						}
						this.$mGameGui$44205 = (GameGui)this.$self_$44206.GetComponent(typeof(GameGui));
						if (263306 - 54702 == 208605)
						{
							continue;
						}
						if (this.$mGameGui$44205)
						{
							if (22431 - 269799 == -247367)
							{
								continue;
							}
							if (!this.$mGameGui$44205.enabled)
							{
								if (284835 - 454689 != -169854)
								{
									continue;
								}
								this.$mGameGui$44205.enabled = true;
								if (32395 - 343937 == -311541)
								{
									continue;
								}
							}
							this.$mGameGui$44205.openDeadMenu();
							if (139638 - 163346 == -23707)
							{
								continue;
							}
						}
						IL_2D7:
						this.YieldDefault(1);
						if (196451 - 349568 != -153116)
						{
							goto IL_2F9;
						}
						continue;
					default:
						if (175588 - 591431 != -415843)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (112024 - 234499 != -122475);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600A661 RID: 42593 RVA: 0x012BCF4C File Offset: 0x012BB14C
			internal static bool oGPnNGVRIMkcgMsrBFiS()
			{
				return true;
			}

			// Token: 0x0600A662 RID: 42594 RVA: 0x012BCF50 File Offset: 0x012BB150
			internal static bool X2Y0m2VRBrAbWMAar9wD()
			{
				return false;
			}

			// Token: 0x040094E0 RID: 38112
			internal StoryGui $mStoryGui$44203;

			// Token: 0x040094E1 RID: 38113
			internal ChangeGui $mChangeGui$44204;

			// Token: 0x040094E2 RID: 38114
			internal GameGui $mGameGui$44205;

			// Token: 0x040094E3 RID: 38115
			internal M938_TimesMemories $self_$44206;
		}
	}

	// Token: 0x02001BD6 RID: 7126
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$44208 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A663 RID: 42595 RVA: 0x012BCF54 File Offset: 0x012BB154
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$44208(Hashtable data, M938_TimesMemories self_)
		{
			if (291566 - 374259 != -82692)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (55516 - 433892 != -378375)
				{
					base..ctor();
					if (270400 - 127714 != 142687)
					{
						this.$data$44213 = data;
						if (244187 - 507446 == -263259)
						{
							this.$self_$44214 = self_;
							if (233741 - 552719 != -318977)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A664 RID: 42596 RVA: 0x012BD010 File Offset: 0x012BB210
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M938_TimesMemories.$onChangePlayer$44208.$(this.$data$44213, this.$self_$44214);
		}

		// Token: 0x0600A665 RID: 42597 RVA: 0x012BD024 File Offset: 0x012BB224
		internal static bool x8v5PZVRejeMsrKV6KoQ()
		{
			return true;
		}

		// Token: 0x0600A666 RID: 42598 RVA: 0x012BD028 File Offset: 0x012BB228
		internal static bool p3oBTPVRrBs64yTOlcuk()
		{
			return false;
		}

		// Token: 0x040094E4 RID: 38116
		internal Hashtable $data$44213;

		// Token: 0x040094E5 RID: 38117
		internal M938_TimesMemories $self_$44214;

		// Token: 0x02001BD7 RID: 7127
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A667 RID: 42599 RVA: 0x012BD02C File Offset: 0x012BB22C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M938_TimesMemories self_)
			{
				if (245987 - 293041 != -47053)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (249240 - 156512 == 92728)
					{
						base..ctor();
						if (18574 - 377457 != -358882)
						{
							this.$data$44211 = data;
							if (288113 - 127732 == 160381)
							{
								this.$self_$44212 = self_;
								if (213704 - 360911 == -147207)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A668 RID: 42600 RVA: 0x012BD0E8 File Offset: 0x012BB2E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (204606 - 563688 != -359081)
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
							if (151540 - 321377 != -169837)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (110405 - 219277 != -108872)
							{
								continue;
							}
							this.$mGameGui$44210 = (GameGui)this.$self_$44212.GetComponent(typeof(GameGui));
							if (234640 - 88426 == 146215)
							{
								continue;
							}
							this.$mGameGui$44210.enabled = true;
							if (192829 - 443446 == -250616)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (88251 - 333354 != -245102)
						{
							goto Block_13;
						}
						continue;
					default:
						if (86859 - 104275 == -17415)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (12556 - 426235 == -413679)
					{
						this.$self_$44212.SendMessage("onCreatePlayer", this.$data$44211);
						if (18757 - 382227 != -363469)
						{
							this.$mChangeGui$44209 = (ChangeGui)this.$self_$44212.GetComponent(typeof(ChangeGui));
							if (38480 - 142095 == -103615)
							{
								if (!this.$mChangeGui$44209.enabled)
								{
									break;
								}
								if (184434 - 31439 != 152996)
								{
									this.$mChangeGui$44209.close();
									if (43385 - 398908 != -355522)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_13:
				IL_205:
				return false;
			}

			// Token: 0x0600A669 RID: 42601 RVA: 0x012BD30C File Offset: 0x012BB50C
			internal static bool HWiWmWVRj6NJNj6yWAqM()
			{
				return true;
			}

			// Token: 0x0600A66A RID: 42602 RVA: 0x012BD310 File Offset: 0x012BB510
			internal static bool PWllr1VRhx1QbXf19Ngl()
			{
				return false;
			}

			// Token: 0x040094E6 RID: 38118
			internal ChangeGui $mChangeGui$44209;

			// Token: 0x040094E7 RID: 38119
			internal GameGui $mGameGui$44210;

			// Token: 0x040094E8 RID: 38120
			internal Hashtable $data$44211;

			// Token: 0x040094E9 RID: 38121
			internal M938_TimesMemories $self_$44212;
		}
	}

	// Token: 0x02001BD8 RID: 7128
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44215 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A66B RID: 42603 RVA: 0x012BD314 File Offset: 0x012BB514
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44215(Hashtable data, M938_TimesMemories self_)
		{
			if (116758 - 435986 != -319228)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (40892 - 193273 != -152380)
				{
					base..ctor();
					if (51377 - 78556 == -27179)
					{
						this.$data$44223 = data;
						if (13876 - 363905 == -350029)
						{
							this.$self_$44224 = self_;
							if (184181 - 105541 == 78640)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A66C RID: 42604 RVA: 0x012BD3D0 File Offset: 0x012BB5D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M938_TimesMemories.$onGameComplete$44215.$(this.$data$44223, this.$self_$44224);
		}

		// Token: 0x0600A66D RID: 42605 RVA: 0x012BD3E4 File Offset: 0x012BB5E4
		internal static bool Y5wTSuVRsb6lc779kDMJ()
		{
			return true;
		}

		// Token: 0x0600A66E RID: 42606 RVA: 0x012BD3E8 File Offset: 0x012BB5E8
		internal static bool OF3GCfVR9fPSy5O7OMT8()
		{
			return false;
		}

		// Token: 0x040094EA RID: 38122
		internal Hashtable $data$44223;

		// Token: 0x040094EB RID: 38123
		internal M938_TimesMemories $self_$44224;

		// Token: 0x02001BD9 RID: 7129
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A66F RID: 42607 RVA: 0x012BD3EC File Offset: 0x012BB5EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M938_TimesMemories self_)
			{
				if (232536 - 72376 != 160160)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (144239 - 483364 == -339125)
					{
						base..ctor();
						if (188923 - 276895 == -87972)
						{
							this.$data$44221 = data;
							if (192927 - 421165 != -228237)
							{
								this.$self_$44222 = self_;
								if (159507 - 76850 == 82657)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A670 RID: 42608 RVA: 0x012BD4A8 File Offset: 0x012BB6A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (162953 - 297078 != -134125)
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
						this.$mCompleteGui$44217 = (CompleteGui)this.$self_$44222.GetComponent(typeof(CompleteGui));
						if (63482 - 278184 != -214702)
						{
							continue;
						}
						this.$mCompleteGui$44217.Init();
						if (98182 - 139317 != -41135)
						{
							continue;
						}
						this.$mCompleteGui$44217.readData(this.$data$44221);
						if (272540 - 584708 != -312168)
						{
							continue;
						}
						if (this.$result$44216 == 1)
						{
							if (55136 - 180445 == -125308)
							{
								continue;
							}
							this.$mCompleteGui$44217.displayResult(eCompleteType.Success);
							if (18613 - 159880 == -141266)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44217.displayResult(eCompleteType.Failed);
							if (238148 - 498523 != -260375)
							{
								continue;
							}
						}
						this.$mGameGui$44218 = (GameGui)this.$self_$44222.GetComponent(typeof(GameGui));
						if (233450 - 483694 == -250243)
						{
							continue;
						}
						this.$mStoryGui$44219 = (StoryGui)this.$self_$44222.GetComponent(typeof(StoryGui));
						if (271796 - 339800 != -68004)
						{
							continue;
						}
						this.$mChangeGui$44220 = (ChangeGui)this.$self_$44222.GetComponent(typeof(ChangeGui));
						if (221055 - 107522 == 113534)
						{
							continue;
						}
						if (this.$mGameGui$44218)
						{
							if (279468 - 154681 == 124788)
							{
								continue;
							}
							this.$mGameGui$44218.close();
							if (75580 - 282128 == -206547)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44219)
						{
							if (182834 - 96348 != 86486)
							{
								continue;
							}
							this.$mStoryGui$44219.close();
							if (131548 - 472079 != -340531)
							{
								continue;
							}
						}
						if (this.$mChangeGui$44220)
						{
							if (127898 - 49478 == 78421)
							{
								continue;
							}
							this.$mChangeGui$44220.disable();
							if (236660 - 440051 != -203391)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (35888 - 182400 != -146511)
						{
							goto Block_3;
						}
						continue;
					default:
						if (50183 - 480237 == -430053)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44221[31]);
					if (240241 - 262685 == -22444)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (149822 - 445750 == -295928)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (123552 - 520618 != -397065)
							{
								this.$result$44216 = RuntimeServices.UnboxInt32(this.$data$44221[31]);
								if (130690 - 273904 != -143213)
								{
									goto Block_16;
								}
							}
						}
					}
				}
				Block_3:
				goto IL_3DB;
				Block_16:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600A671 RID: 42609 RVA: 0x012BD8A4 File Offset: 0x012BBAA4
			internal static bool OHN0VGVR15E8lx2C0e3g()
			{
				return true;
			}

			// Token: 0x0600A672 RID: 42610 RVA: 0x012BD8A8 File Offset: 0x012BBAA8
			internal static bool UqNi0UVR4AHkWdHSWMIB()
			{
				return false;
			}

			// Token: 0x040094EC RID: 38124
			internal int $result$44216;

			// Token: 0x040094ED RID: 38125
			internal CompleteGui $mCompleteGui$44217;

			// Token: 0x040094EE RID: 38126
			internal GameGui $mGameGui$44218;

			// Token: 0x040094EF RID: 38127
			internal StoryGui $mStoryGui$44219;

			// Token: 0x040094F0 RID: 38128
			internal ChangeGui $mChangeGui$44220;

			// Token: 0x040094F1 RID: 38129
			internal Hashtable $data$44221;

			// Token: 0x040094F2 RID: 38130
			internal M938_TimesMemories $self_$44222;
		}
	}

	// Token: 0x02001BDA RID: 7130
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44225 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A673 RID: 42611 RVA: 0x012BD8AC File Offset: 0x012BBAAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44225(M938_TimesMemories self_)
		{
			if (104408 - 118332 != -13923)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (4390 - 360177 != -355786)
				{
					base..ctor();
					if (206858 - 174235 != 32624)
					{
						this.$self_$44229 = self_;
						if (71945 - 402859 == -330914)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A674 RID: 42612 RVA: 0x012BD944 File Offset: 0x012BBB44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M938_TimesMemories.$ReturnToTown$44225.$(this.$self_$44229);
		}

		// Token: 0x0600A675 RID: 42613 RVA: 0x012BD954 File Offset: 0x012BBB54
		internal static bool At75quVRzUbbRUiIsrjQ()
		{
			return true;
		}

		// Token: 0x0600A676 RID: 42614 RVA: 0x012BD958 File Offset: 0x012BBB58
		internal static bool ScNIvSVwar3yrKKlTnHT()
		{
			return false;
		}

		// Token: 0x040094F3 RID: 38131
		internal M938_TimesMemories $self_$44229;

		// Token: 0x02001BDB RID: 7131
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A677 RID: 42615 RVA: 0x012BD95C File Offset: 0x012BBB5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M938_TimesMemories self_)
			{
				if (164014 - 141087 != 22928)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (145970 - 215329 == -69359)
					{
						base..ctor();
						if (223518 - 445316 == -221798)
						{
							this.$self_$44228 = self_;
							if (291395 - 387612 != -96216)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A678 RID: 42616 RVA: 0x012BD9F4 File Offset: 0x012BBBF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (277313 - 496648 != -219334)
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
						this.$self_$44228.LeaveGame();
						if (59823 - 434199 == -374375)
						{
							continue;
						}
						this.YieldDefault(1);
						if (194710 - 565419 != -370708)
						{
							goto Block_29;
						}
						continue;
					default:
						if (71860 - 562872 == -491011)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (64500 - 361723 != -297222)
					{
						Game.mStateTime = Time.time;
						if (283068 - 351727 != -68658)
						{
							this.$$switch$8129$44226 = PlayerData.SaveGuild;
							if (136579 - 559865 == -423286)
							{
								if (this.$$switch$8129$44226 == 1)
								{
									if (57451 - 88206 != -30755)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (45627 - 84517 != -38890)
									{
										continue;
									}
								}
								else if (this.$$switch$8129$44226 == 2)
								{
									if (257436 - 301203 == -43766)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (70952 - 320676 != -249724)
									{
										continue;
									}
								}
								else if (this.$$switch$8129$44226 == 3)
								{
									if (28251 - 287991 == -259739)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (24846 - 491014 == -466167)
									{
										continue;
									}
								}
								else if (this.$$switch$8129$44226 == 4)
								{
									if (198104 - 79967 != 118137)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (76684 - 331958 == -255273)
									{
										continue;
									}
								}
								else if (this.$$switch$8129$44226 == 5)
								{
									if (41673 - 66736 == -25062)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (179721 - 465491 != -285770)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (237159 - 422281 == -185121)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (212310 - 298603 != -86293)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (52142 - 464140 != -411998)
									{
										continue;
									}
								}
								this.$mGameGui$44227 = (GameGui)this.$self_$44228.GetComponent(typeof(GameGui));
								if (2198 - 507322 == -505124)
								{
									if (this.$mGameGui$44227)
									{
										if (113621 - 231779 == -118157)
										{
											continue;
										}
										this.$mGameGui$44227.close();
										if (253248 - 41058 == 212191)
										{
											continue;
										}
									}
									this.$self_$44228.SendMessage("fadeOut");
									if (79806 - 160420 != -80613)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_29:
				IL_3AD:
				return false;
			}

			// Token: 0x0600A679 RID: 42617 RVA: 0x012BDDC0 File Offset: 0x012BBFC0
			internal static bool dZXI4QVw5EsdJvrUhOjE()
			{
				return true;
			}

			// Token: 0x0600A67A RID: 42618 RVA: 0x012BDDC4 File Offset: 0x012BBFC4
			internal static bool ClrFGlVwpbTtcYeyIdXh()
			{
				return false;
			}

			// Token: 0x040094F4 RID: 38132
			internal int $$switch$8129$44226;

			// Token: 0x040094F5 RID: 38133
			internal GameGui $mGameGui$44227;

			// Token: 0x040094F6 RID: 38134
			internal M938_TimesMemories $self_$44228;
		}
	}

	// Token: 0x02001BDC RID: 7132
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44230 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A67B RID: 42619 RVA: 0x012BDDC8 File Offset: 0x012BBFC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44230(M938_TimesMemories self_)
		{
			if (236732 - 429510 != -192777)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (176612 - 162413 != 14200)
				{
					base..ctor();
					if (106277 - 227668 == -121391)
					{
						this.$self_$44233 = self_;
						if (231312 - 61958 != 169355)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A67C RID: 42620 RVA: 0x012BDE60 File Offset: 0x012BC060
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M938_TimesMemories.$ReturnToGuild$44230.$(this.$self_$44233);
		}

		// Token: 0x0600A67D RID: 42621 RVA: 0x012BDE70 File Offset: 0x012BC070
		internal static bool lcUaFhVwVPYVyLTWMFUX()
		{
			return true;
		}

		// Token: 0x0600A67E RID: 42622 RVA: 0x012BDE74 File Offset: 0x012BC074
		internal static bool NcUH6gVwtc4JkWXFYpBO()
		{
			return false;
		}

		// Token: 0x040094F7 RID: 38135
		internal M938_TimesMemories $self_$44233;

		// Token: 0x02001BDD RID: 7133
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A67F RID: 42623 RVA: 0x012BDE78 File Offset: 0x012BC078
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M938_TimesMemories self_)
			{
				if (234178 - 24271 != 209908)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (215187 - 507608 != -292420)
					{
						base..ctor();
						if (118203 - 488953 != -370749)
						{
							this.$self_$44232 = self_;
							if (161770 - 71480 == 90290)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A680 RID: 42624 RVA: 0x012BDF10 File Offset: 0x012BC110
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (53214 - 324555 != -271341)
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
						this.$self_$44232.LeaveGame();
						if (68544 - 535974 == -467429)
						{
							continue;
						}
						this.YieldDefault(1);
						if (279928 - 132550 != 147379)
						{
							goto IL_1BD;
						}
						continue;
					default:
						if (180765 - 566185 != -385420)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (60170 - 407909 == -347739)
					{
						Game.mStateTime = Time.time;
						if (248246 - 87588 == 160658)
						{
							Game.mNextGameCode = 31;
							if (192528 - 462544 == -270016)
							{
								this.$mGameGui$44231 = (GameGui)this.$self_$44232.GetComponent(typeof(GameGui));
								if (262074 - 109060 != 153015)
								{
									if (this.$mGameGui$44231)
									{
										if (294698 - 141180 == 153519)
										{
											continue;
										}
										this.$mGameGui$44231.close();
										if (206758 - 312063 == -105304)
										{
											continue;
										}
									}
									this.$self_$44232.SendMessage("fadeOut");
									if (108913 - 348183 != -239269)
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

			// Token: 0x0600A681 RID: 42625 RVA: 0x012BE0EC File Offset: 0x012BC2EC
			internal static bool vN70KJVwNRJlNXQMo3Gc()
			{
				return true;
			}

			// Token: 0x0600A682 RID: 42626 RVA: 0x012BE0F0 File Offset: 0x012BC2F0
			internal static bool lLB7goVwYLq54xpFBqCv()
			{
				return false;
			}

			// Token: 0x040094F8 RID: 38136
			internal GameGui $mGameGui$44231;

			// Token: 0x040094F9 RID: 38137
			internal M938_TimesMemories $self_$44232;
		}
	}

	// Token: 0x02001BDE RID: 7134
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44234 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A683 RID: 42627 RVA: 0x012BE0F4 File Offset: 0x012BC2F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44234(M938_TimesMemories self_)
		{
			if (123841 - 246237 != -122395)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (222720 - 439597 == -216877)
				{
					base..ctor();
					if (13737 - 512259 == -498522)
					{
						this.$self_$44238 = self_;
						if (41618 - 529180 != -487561)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A684 RID: 42628 RVA: 0x012BE18C File Offset: 0x012BC38C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M938_TimesMemories.$ReturnToCamp$44234.$(this.$self_$44238);
		}

		// Token: 0x0600A685 RID: 42629 RVA: 0x012BE19C File Offset: 0x012BC39C
		internal static bool Srp1mkVwcdJBnTl5u8xk()
		{
			return true;
		}

		// Token: 0x0600A686 RID: 42630 RVA: 0x012BE1A0 File Offset: 0x012BC3A0
		internal static bool wnS1suVwU1fnC900gLhF()
		{
			return false;
		}

		// Token: 0x040094FA RID: 38138
		internal M938_TimesMemories $self_$44238;

		// Token: 0x02001BDF RID: 7135
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A687 RID: 42631 RVA: 0x012BE1A4 File Offset: 0x012BC3A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M938_TimesMemories self_)
			{
				if (848 - 114646 != -113798)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (54687 - 538992 == -484305)
					{
						base..ctor();
						if (277683 - 353557 == -75874)
						{
							this.$self_$44237 = self_;
							if (133929 - 132383 == 1546)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A688 RID: 42632 RVA: 0x012BE23C File Offset: 0x012BC43C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (228128 - 61087 != 167041)
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
						this.$self_$44237.LeaveGame();
						if (34572 - 332030 != -297458)
						{
							continue;
						}
						this.YieldDefault(1);
						if (120139 - 298530 != -178390)
						{
							goto Block_12;
						}
						continue;
					default:
						if (110167 - 464106 != -353939)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (231946 - 336398 != -104451)
					{
						Game.mStateTime = Time.time;
						if (49344 - 311075 != -261730)
						{
							this.$$switch$8131$44235 = PlayerData.SaveGuild;
							if (282069 - 3532 != 278538)
							{
								if (this.$$switch$8131$44235 == 1)
								{
									if (30559 - 269206 == -238646)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (20721 - 349557 == -328835)
									{
										continue;
									}
								}
								else if (this.$$switch$8131$44235 == 2)
								{
									if (233419 - 382784 == -149364)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (2546 - 449606 == -447059)
									{
										continue;
									}
								}
								else if (this.$$switch$8131$44235 == 3)
								{
									if (212951 - 504686 != -291735)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (40045 - 203187 != -163142)
									{
										continue;
									}
								}
								else if (this.$$switch$8131$44235 == 4)
								{
									if (27025 - 198309 == -171283)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (270593 - 334258 != -63665)
									{
										continue;
									}
								}
								else if (this.$$switch$8131$44235 == 5)
								{
									if (130877 - 470319 == -339441)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (206502 - 400876 != -194374)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (204299 - 391816 == -187516)
									{
										continue;
									}
								}
								this.$mGameGui$44236 = (GameGui)this.$self_$44237.GetComponent(typeof(GameGui));
								if (90474 - 178336 != -87861)
								{
									if (this.$mGameGui$44236)
									{
										if (90770 - 383612 != -292842)
										{
											continue;
										}
										this.$mGameGui$44236.close();
										if (275708 - 33923 == 241786)
										{
											continue;
										}
									}
									this.$self_$44237.SendMessage("fadeOut");
									if (210810 - 268507 == -57697)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_12:
				IL_363:
				return false;
			}

			// Token: 0x0600A689 RID: 42633 RVA: 0x012BE5C0 File Offset: 0x012BC7C0
			internal static bool inhjV3VwTTCTVMyK0BYJ()
			{
				return true;
			}

			// Token: 0x0600A68A RID: 42634 RVA: 0x012BE5C4 File Offset: 0x012BC7C4
			internal static bool pyvkmMVw3SWjkAYx7TIC()
			{
				return false;
			}

			// Token: 0x040094FB RID: 38139
			internal int $$switch$8131$44235;

			// Token: 0x040094FC RID: 38140
			internal GameGui $mGameGui$44236;

			// Token: 0x040094FD RID: 38141
			internal M938_TimesMemories $self_$44237;
		}
	}
}
