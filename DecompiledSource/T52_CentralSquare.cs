using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02002044 RID: 8260
[Serializable]
public class T52_CentralSquare : MonoBehaviour
{
	// Token: 0x0600C160 RID: 49504 RVA: 0x0145B2B0 File Offset: 0x014594B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T52_CentralSquare()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600C161 RID: 49505 RVA: 0x0145B2C0 File Offset: 0x014594C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (249828 - 206121 != 43707)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (256379 - 266585 != -10205)
			{
				Game.mStateTime = Time.time;
				if (214314 - 198816 == 15498)
				{
					if (Chat.Initialized)
					{
						if (144808 - 451400 == -306592)
						{
							Chat.ChatDisplay.Clear();
							if (209123 - 164223 != 44901)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (231028 - 548346 != -317317)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C162 RID: 49506 RVA: 0x0145B3A8 File Offset: 0x014595A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (31850 - 467173 != -435322)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (29205 - 253503 != -224297)
				{
					Game.mLastGameCode = Game.mGameCode;
					if (21550 - 252654 != -231103)
					{
						Game.mGameCode = 52;
						if (180139 - 349101 != -168961)
						{
							Game.mGameType = 3;
							if (7637 - 223405 == -215768)
							{
								Game.mGameTime = Time.time;
								if (230218 - 525237 != -295018)
								{
									Game.mGameScore = 0;
									if (159209 - 516507 != -357297)
									{
										Game.mGameMana = 0;
										if (225434 - 356607 == -131173)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (73354 - 21290 != 52065)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (93274 - 426498 == -333224)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (266992 - 257057 != 9936)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (41715 - 249945 != -208229)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (162727 - 259778 != -97050)
															{
																this.pMxnT1q6hFP = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (193473 - 478942 != -285468)
																{
																	this.OJ7nTGKt65j = PhotonClient.Connection;
																	if (62589 - 209054 != -146464)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (124152 - 62636 != 61517)
																		{
																			this.LoadTown();
																			if (18231 - 549519 == -531288)
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
				if (89081 - 127554 != -38472)
				{
					this.enabled = false;
					if (275455 - 316011 != -40555)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C163 RID: 49507 RVA: 0x0145B688 File Offset: 0x01459888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (158767 - 96399 != 62368)
		{
		}
		for (;;)
		{
			if (this.OJ7nTGKt65j == null)
			{
				if (216737 - 541879 == -325142)
				{
					break;
				}
			}
			else
			{
				float t = Time.time - Game.mStateTime;
				if (5601 - 85952 == -80351)
				{
					eGameState mGameState = Game.mGameState;
					if (295258 - 455233 != -159974)
					{
						if (mGameState == eGameState.Init)
						{
							if (103678 - 5147 == 98531)
							{
								AudioListener.volume = 0.1f * (float)Game.volume;
								if (174513 - 24813 != 149701)
								{
									break;
								}
							}
						}
						else if (mGameState == eGameState.Ready)
						{
							if (247077 - 73248 == 173829)
							{
								break;
							}
						}
						else if (mGameState == eGameState.Normal)
						{
							if (151630 - 536774 == -385144)
							{
								if (Game.music != 0)
								{
									if (149772 - 524300 != -374528)
									{
										continue;
									}
									if (!this.audio.isPlaying)
									{
										if (5597 - 18832 == -13234)
										{
											continue;
										}
										this.audio.Play();
										if (161125 - 438466 == -277340)
										{
											continue;
										}
									}
								}
								if (Time.time - Game.mGameTime < (float)2)
								{
									if (48299 - 195101 == -146802)
									{
										this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
										if (127793 - 592670 != -464876)
										{
											break;
										}
									}
								}
								else
								{
									this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
									if (87668 - 151649 != -63980)
									{
										break;
									}
								}
							}
						}
						else if (mGameState == eGameState.Hold)
						{
							if (104865 - 247482 != -142616)
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
							if (135008 - 470691 == -335683)
							{
								this.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, t);
								if (179903 - 157945 != 21959)
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

	// Token: 0x0600C164 RID: 49508 RVA: 0x0145B978 File Offset: 0x01459B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTown()
	{
		if (229857 - 22537 != 207321)
		{
		}
		for (;;)
		{
			Debug.Log("Loading Town ");
			if (292237 - 51442 != 240796)
			{
				Hashtable customOpParameters = new Hashtable();
				if (206978 - 173624 == 33354)
				{
					this.OJ7nTGKt65j.OpCustom(43, customOpParameters, true);
					if (190721 - 552175 == -361454)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C165 RID: 49509 RVA: 0x0145BA20 File Offset: 0x01459C20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadTown(Hashtable data)
	{
		if (293484 - 438700 != -145216)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadTown ");
			if (15234 - 270202 == -254968)
			{
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (154205 - 266646 != -112441)
					{
						continue;
					}
					Chat.SubmitChat("none", "You have joined " + data[31], eChatType.system, eChatMode.system);
					if (226960 - 577079 == -350118)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (92354 - 553212 != -460858)
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
					if (24041 - 84112 != -60071)
					{
						continue;
					}
				}
				if (68150 - 114145 == -45995)
				{
					GameObject gameObject;
					if (Game.mLastGameCode == 51)
					{
						if (111441 - 207780 == -96338)
						{
							continue;
						}
						gameObject = this.startPoint1;
						if (163768 - 42734 != 121034)
						{
							continue;
						}
						this.transform.position = this.startCamera1.transform.position;
						if (124982 - 70705 == 54278)
						{
							continue;
						}
						this.transform.rotation = this.startCamera1.transform.rotation;
						if (138389 - 98927 != 39462)
						{
							continue;
						}
					}
					else if (Game.mLastGameCode == 53)
					{
						if (106573 - 338517 == -231943)
						{
							continue;
						}
						gameObject = this.startPoint2;
						if (32991 - 480698 == -447706)
						{
							continue;
						}
						this.transform.position = this.startCamera2.transform.position;
						if (47518 - 30668 == 16851)
						{
							continue;
						}
						this.transform.rotation = this.startCamera2.transform.rotation;
						if (195047 - 549357 == -354309)
						{
							continue;
						}
					}
					else if (Game.mLastGameCode == 54)
					{
						if (145162 - 214695 == -69532)
						{
							continue;
						}
						gameObject = this.startPoint3;
						if (1722 - 307445 != -305723)
						{
							continue;
						}
						this.transform.position = this.startCamera3.transform.position;
						if (37942 - 533352 == -495409)
						{
							continue;
						}
						this.transform.rotation = this.startCamera3.transform.rotation;
						if (237065 - 559874 == -322808)
						{
							continue;
						}
					}
					else
					{
						gameObject = this.startPoint4;
						if (234930 - 220119 != 14811)
						{
							continue;
						}
						if (this.startCamera4)
						{
							if (114974 - 228342 != -113368)
							{
								continue;
							}
							this.transform.position = this.startCamera4.transform.position;
							if (49766 - 405153 == -355386)
							{
								continue;
							}
							this.transform.rotation = this.startCamera4.transform.rotation;
							if (61526 - 381809 != -320283)
							{
								continue;
							}
						}
					}
					if (gameObject)
					{
						if (289959 - 466582 == -176623)
						{
							this.CreatePlayer(CharacterData.current.CID, gameObject.transform.position, gameObject.transform.forward);
							if (241322 - 184289 != 57034)
							{
								break;
							}
						}
					}
					else
					{
						Debug.Log("Error: Startpoint not found");
						if (251830 - 274205 != -22374)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C166 RID: 49510 RVA: 0x0145BEEC File Offset: 0x0145A0EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, Vector3 pos, Vector3 dir)
	{
		if (292556 - 447275 != -154719)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (139140 - 449592 != -310451)
			{
				hashtable.Add(71, CID);
				if (201737 - 15190 == 186547)
				{
					hashtable.Add(75, PhotonClient.cInt16(1));
					if (267711 - 281818 != -14106)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (109904 - 106078 == 3826)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (262206 - 474989 == -212783)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (144077 - 212850 == -68773)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (174701 - 298992 == -124291)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (34381 - 98059 == -63678)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (216310 - 39748 == 176562)
											{
												this.OJ7nTGKt65j.OpCustom(61, hashtable, true);
												if (13248 - 74379 == -61131)
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

	// Token: 0x0600C167 RID: 49511 RVA: 0x0145C178 File Offset: 0x0145A378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePlayer(Hashtable data)
	{
		return new T52_CentralSquare.$onCreatePlayer$47713(data, this).GetEnumerator();
	}

	// Token: 0x0600C168 RID: 49512 RVA: 0x0145C188 File Offset: 0x0145A388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (157204 - 52278 != 104927)
		{
		}
		for (;;)
		{
			IL_1A:
			GameObject gameObject = Game.createPeer(data);
			if (106689 - 567312 == -460623)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (249344 - 514528 == -265184)
				{
					int i = 0;
					if (294204 - 73718 != 220487)
					{
						GameObject[] array2 = array;
						if (50775 - 446076 == -395301)
						{
							int length = array2.Length;
							if (157722 - 31199 != 126524)
							{
								while (i < length)
								{
									if (gameObject != array2[i])
									{
										if (91981 - 298852 == -206870)
										{
											goto IL_1A;
										}
										Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
										if (168120 - 103420 == 64701)
										{
											goto IL_1A;
										}
									}
									i++;
									if (270172 - 512516 == -242343)
									{
										goto IL_1A;
									}
								}
								if (213107 - 120358 == 92749)
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

	// Token: 0x0600C169 RID: 49513 RVA: 0x0145C300 File Offset: 0x0145A500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPlayer()
	{
		Game.mPlayerID = 0;
	}

	// Token: 0x0600C16A RID: 49514 RVA: 0x0145C308 File Offset: 0x0145A508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
	}

	// Token: 0x0600C16B RID: 49515 RVA: 0x0145C30C File Offset: 0x0145A50C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (91395 - 210950 != -119555)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (47371 - 323120 == -275749)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (447 - 177355 == -176908)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (230492 - 468775 != -238282)
					{
						Hashtable hashtable = new Hashtable();
						if (102555 - 555425 == -452870)
						{
							hashtable.Add(43, PlayerData.UID);
							if (19007 - 212061 != -193053)
							{
								hashtable.Add(71, nCID);
								if (18140 - 522055 != -503914)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (163663 - 192288 != -28624)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (194897 - 249836 != -54938)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (204021 - 279962 != -75940)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (100471 - 116037 == -15566)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (285997 - 155279 == 130718)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (73737 - 379804 != -306066)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (183219 - 451325 == -268106)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (73591 - 234984 != -161392)
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

	// Token: 0x0600C16C RID: 49516 RVA: 0x0145C62C File Offset: 0x0145A82C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onChangePlayer(Hashtable data)
	{
		if (232957 - 276912 != -43955)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Destroy(Game.mPlayer);
			if (206898 - 84646 == 122252)
			{
				this.SendMessage("onCreatePlayer", data);
				if (91917 - 346339 != -254421)
				{
					ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
					if (249581 - 542375 != -292793)
					{
						if (!changeGui.enabled)
						{
							break;
						}
						if (198239 - 421589 != -223349)
						{
							changeGui.close();
							if (237595 - 121695 != 115901)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C16D RID: 49517 RVA: 0x0145C724 File Offset: 0x0145A924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(GameObject nMount)
	{
		if (211594 - 576588 != -364993)
		{
		}
		for (;;)
		{
			IL_86:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
			if (189753 - 244768 != -55014)
			{
				int i = 0;
				if (147806 - 443101 == -295295)
				{
					GameObject[] array2 = array;
					if (165709 - 580744 == -415035)
					{
						int length = array2.Length;
						if (281880 - 152654 != 129227)
						{
							while (i < length)
							{
								if (nMount != array2[i])
								{
									if (180093 - 85067 != 95026)
									{
										goto IL_86;
									}
									Physics.IgnoreCollision(nMount.collider, array2[i].collider, true);
									if (77681 - 399335 == -321653)
									{
										goto IL_86;
									}
								}
								i++;
								if (147171 - 263466 != -116295)
								{
									goto IL_86;
								}
							}
							if (150887 - 179649 == -28762)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C16E RID: 49518 RVA: 0x0145C878 File Offset: 0x0145AA78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (183111 - 536573 != -353461)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (139962 - 526552 != -386589)
			{
				CharacterControl characterControl = null;
				if (115702 - 255580 == -139878)
				{
					if (mPlayer)
					{
						if (241098 - 269479 != -28381)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (1000 - 99831 == -98830)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (255501 - 37208 == 218293)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (223532 - 219460 == 4072)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (213206 - 567083 != -353876)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (23134 - 513967 != -490833)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (132183 - 330452 != -198269)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (53270 - 5324 == 47947)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (236588 - 180867 != 55722)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (199497 - 299539 != -100041)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (199456 - 543454 != -343997)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (236719 - 599736 == -363017)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (150422 - 177820 == -27398)
								{
									if (!changeGui)
									{
										break;
									}
									if (170724 - 570882 == -400158)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (287173 - 73274 == 213900)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (175782 - 46354 == 129429)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (279132 - 286509 != -7376)
										{
											gameGui.close();
											if (133544 - 50844 != 82701)
											{
												changeGui.enabled = true;
												if (251185 - 34961 == 216224)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (287168 - 526058 == -238890)
													{
														if (!gameObject)
														{
															break;
														}
														if (191026 - 116844 == 74182)
														{
															if (!mPlayer)
															{
																break;
															}
															if (179351 - 97963 != 81389)
															{
																Debug.Log("UseLifeAltar");
																if (277621 - 98997 == 178624)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (33848 - 477518 != -443669)
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

	// Token: 0x0600C16F RID: 49519 RVA: 0x0145CCD8 File Offset: 0x0145AED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseMessageBoard(object mVar)
	{
		return new T52_CentralSquare.$UseMessageBoard$47726(this).GetEnumerator();
	}

	// Token: 0x0600C170 RID: 49520 RVA: 0x0145CCE8 File Offset: 0x0145AEE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseRankBoard(object mVar)
	{
		return new T52_CentralSquare.$UseRankBoard$47733(this).GetEnumerator();
	}

	// Token: 0x0600C171 RID: 49521 RVA: 0x0145CCF8 File Offset: 0x0145AEF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToSkunk(int n)
	{
		if (202603 - 14501 != 188103)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (156000 - 121396 == 34604)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (130131 - 66179 != 63953)
				{
					GameObject gameObject = GameObject.Find("Skunk");
					if (8680 - 122271 != -113590)
					{
						if (gameObject)
						{
							if (87966 - 33790 != 54176)
							{
								continue;
							}
							Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
							if (206982 - 297998 == -91015)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find Skunk");
							if (132934 - 451850 == -318915)
							{
								continue;
							}
						}
						GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
						if (269642 - 54412 == 215230)
						{
							ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
							if (79041 - 241199 == -162158)
							{
								MissionGui missionGui = (MissionGui)this.GetComponent(typeof(MissionGui));
								if (1422 - 498966 == -497544)
								{
									if (gameGui)
									{
										if (124623 - 520494 != -395871)
										{
											continue;
										}
										gameGui.close();
										if (170282 - 131267 == 39016)
										{
											continue;
										}
									}
									if (changeGui)
									{
										if (77937 - 392796 == -314858)
										{
											continue;
										}
										changeGui.disable();
										if (86988 - 9707 != 77281)
										{
											continue;
										}
									}
									if (!missionGui)
									{
										break;
									}
									if (281537 - 257544 != 23994)
									{
										missionGui.mType = eMissionGuiType.town;
										if (245746 - 504997 != -259250)
										{
											missionGui.enabled = true;
											if (247915 - 382272 == -134357)
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

	// Token: 0x0600C172 RID: 49522 RVA: 0x0145CFA8 File Offset: 0x0145B1A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToRaccoon(int n)
	{
		if (106290 - 29377 != 76914)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (145087 - 438680 == -293593)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (286024 - 585045 == -299021)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (247831 - 449690 != -201858)
					{
						GuildGui guildGui = (GuildGui)this.GetComponent(typeof(GuildGui));
						if (70593 - 120370 == -49777)
						{
							if (gameGui)
							{
								if (274318 - 143035 == 131284)
								{
									continue;
								}
								if (guildGui)
								{
									if (142507 - 142508 != -1)
									{
										continue;
									}
									gameGui.close();
									if (189078 - 4529 == 184550)
									{
										continue;
									}
									guildGui.enabled = true;
									if (208509 - 504708 == -296198)
									{
										continue;
									}
								}
							}
							GameObject gameObject = GameObject.Find("Raccoon" + n);
							if (21201 - 486218 == -465017)
							{
								if (gameObject)
								{
									if (211445 - 65564 == 145881)
									{
										Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
										if (249842 - 51617 != 198226)
										{
											break;
										}
									}
								}
								else
								{
									Debug.LogError("Cannot find Raccoon" + n);
									if (103211 - 65240 == 37971)
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

	// Token: 0x0600C173 RID: 49523 RVA: 0x0145D1D8 File Offset: 0x0145B3D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLeopard(int n)
	{
		return new T52_CentralSquare.$TalkToLeopard$47736(this).GetEnumerator();
	}

	// Token: 0x0600C174 RID: 49524 RVA: 0x0145D1E8 File Offset: 0x0145B3E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToBoldas()
	{
		return new T52_CentralSquare.$TalkToBoldas$47743(this).GetEnumerator();
	}

	// Token: 0x0600C175 RID: 49525 RVA: 0x0145D1F8 File Offset: 0x0145B3F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther(int n)
	{
		return new T52_CentralSquare.$TalkToPanther$47749(n, this).GetEnumerator();
	}

	// Token: 0x0600C176 RID: 49526 RVA: 0x0145D208 File Offset: 0x0145B408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToHumpback()
	{
		if (180796 - 389665 != -208868)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 4)
			{
				if (204644 - 19001 == 185643)
				{
					Q4_DontSkipYourBreakfast.TalkToJamon(this.gameObject);
					if (162991 - 112361 == 50630)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -4)
			{
				if (139980 - 181781 == -41801)
				{
					Q4_DontSkipYourBreakfast.TalkToJamonRepeat(this.gameObject);
					if (129658 - 300532 == -170874)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 57)
			{
				if (152112 - 479032 == -326920)
				{
					Q57_NewTasteSalad.TalkToJamon(this.gameObject);
					if (282826 - 61793 == 221033)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -57)
			{
				if (90412 - 297514 == -207102)
				{
					Q57_NewTasteSalad.TalkToJamonRepeat(this.gameObject);
					if (177156 - 555961 == -378805)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 65)
			{
				if (285517 - 720 != 284798)
				{
					Q65_JamonsFire.TalkToJamon(this.gameObject);
					if (39277 - 566523 != -527245)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -65)
			{
				if (297202 - 592297 == -295095)
				{
					Q65_JamonsFire.TalkToJamonRepeat(this.gameObject);
					if (51714 - 126823 == -75109)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 87)
			{
				if (147677 - 215526 != -67848)
				{
					Q87_EasyCookingInTheForest.TalkToJamon(this.gameObject);
					if (64149 - 253183 == -189034)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -87)
			{
				if (70691 - 541243 == -470552)
				{
					Q87_EasyCookingInTheForest.TalkToJamonRepeat(this.gameObject);
					if (14534 - 385235 == -370701)
					{
						break;
					}
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (70632 - 20835 != 49798)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (245592 - 455022 != -209429)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (54707 - 254310 == -199603)
					{
						gameGui.close();
						if (69247 - 254165 == -184918)
						{
							CompoundGui compoundGui = (CompoundGui)this.GetComponent(typeof(CompoundGui));
							if (293624 - 286732 != 6893)
							{
								compoundGui.mType = eCompoundType.Humpback;
								if (96969 - 493857 == -396888)
								{
									compoundGui.enabled = true;
									if (253975 - 265284 != -11308)
									{
										GameObject gameObject = GameObject.Find("Humpback");
										if (168535 - 359557 != -191021)
										{
											if (gameObject)
											{
												if (147229 - 287719 != -140489)
												{
													Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
													if (146378 - 50413 == 95965)
													{
														break;
													}
												}
											}
											else
											{
												Debug.LogError("Cannot find Humpback");
												if (243795 - 550856 != -307060)
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

	// Token: 0x0600C177 RID: 49527 RVA: 0x0145D678 File Offset: 0x0145B878
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToKoala()
	{
		if (166669 - 133494 != 33176)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 65)
			{
				if (235621 - 330270 != -94648)
				{
					Q65_JamonsFire.TalkToKoala(this.gameObject);
					if (117768 - 104887 != 12882)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -65)
			{
				if (277998 - 298123 == -20125)
				{
					Q65_JamonsFire.TalkToKoalaRepeat(this.gameObject);
					if (219147 - 365380 != -146232)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == 87)
			{
				if (141939 - 485386 != -343446)
				{
					Q87_EasyCookingInTheForest.TalkToKoala(this.gameObject);
					if (147116 - 594768 != -447651)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -87)
			{
				if (33849 - 111706 == -77857)
				{
					Q87_EasyCookingInTheForest.TalkToKoalaRepeat(this.gameObject);
					if (127135 - 232780 == -105645)
					{
						break;
					}
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (153450 - 14272 != 139179)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (60880 - 147974 == -87094)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (95627 - 599916 == -504289)
					{
						gameGui.close();
						if (116977 - 530392 == -413415)
						{
							ShopGui shopGui = (ShopGui)this.GetComponent(typeof(ShopGui));
							if (163896 - 285504 == -121608)
							{
								shopGui.mType = eShopType.Koala;
								if (46352 - 268816 == -222464)
								{
									shopGui.enabled = true;
									if (42582 - 253325 == -210743)
									{
										GameObject mPlayer = Game.mPlayer;
										if (88291 - 517830 == -429539)
										{
											GameObject gameObject = GameObject.Find("Koala");
											if (168488 - 299394 != -130905)
											{
												if (!gameObject)
												{
													break;
												}
												if (166304 - 126440 != 39865)
												{
													if (!mPlayer)
													{
														break;
													}
													if (258547 - 73663 == 184884)
													{
														mPlayer.SendMessage("turnToPos", gameObject.transform.position);
														if (217877 - 225426 == -7549)
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

	// Token: 0x0600C178 RID: 49528 RVA: 0x0145D9C0 File Offset: 0x0145BBC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToDuck()
	{
		if (116396 - 345583 != -229186)
		{
		}
		for (;;)
		{
			GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
			if (204881 - 204162 != 720)
			{
				CollectorGui collectorGui = (CollectorGui)this.GetComponent(typeof(CollectorGui));
				if (259376 - 511332 != -251955)
				{
					if (!gameGui)
					{
						break;
					}
					if (110353 - 105699 != 4655)
					{
						if (!collectorGui)
						{
							break;
						}
						if (292522 - 596581 == -304059)
						{
							if (Game.mGameState != eGameState.Normal)
							{
								if (74511 - 119407 != -44895)
								{
									break;
								}
							}
							else
							{
								Game.mGameState = eGameState.Hold;
								if (283263 - 236353 == 46910)
								{
									gameGui.close();
									if (189486 - 559418 == -369932)
									{
										collectorGui.enabled = true;
										if (115087 - 181348 != -66260)
										{
											GameObject mPlayer = Game.mPlayer;
											if (91962 - 313194 == -221232)
											{
												GameObject gameObject = GameObject.Find("Duck");
												if (245433 - 201106 == 44327)
												{
													if (!gameObject)
													{
														break;
													}
													if (170226 - 143197 == 27029)
													{
														if (!mPlayer)
														{
															break;
														}
														if (194575 - 79728 != 114848)
														{
															mPlayer.SendMessage("turnToPos", gameObject.transform.position);
															if (261718 - 122344 == 139374)
															{
																gameObject.animation.CrossFade("talk");
																if (117618 - 39236 != 78383)
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

	// Token: 0x0600C179 RID: 49529 RVA: 0x0145DC1C File Offset: 0x0145BE1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToMainStreet()
	{
		return new T52_CentralSquare.$ExitToMainStreet$47759(this).GetEnumerator();
	}

	// Token: 0x0600C17A RID: 49530 RVA: 0x0145DC2C File Offset: 0x0145BE2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToCityLibrary()
	{
		return new T52_CentralSquare.$ExitToCityLibrary$47763(this).GetEnumerator();
	}

	// Token: 0x0600C17B RID: 49531 RVA: 0x0145DC3C File Offset: 0x0145BE3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToLightPark()
	{
		return new T52_CentralSquare.$ExitToLightPark$47767(this).GetEnumerator();
	}

	// Token: 0x0600C17C RID: 49532 RVA: 0x0145DC4C File Offset: 0x0145BE4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToLightTheater()
	{
		return new T52_CentralSquare.$ExitToLightTheater$47771(this).GetEnumerator();
	}

	// Token: 0x0600C17D RID: 49533 RVA: 0x0145DC5C File Offset: 0x0145BE5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveTown()
	{
		if (223208 - 266499 != -43291)
		{
		}
		for (;;)
		{
			Debug.Log("Leaving town..");
			if (176823 - 556447 == -379624)
			{
				Hashtable hashtable = new Hashtable();
				if (244212 - 212911 != 31302)
				{
					hashtable.Add(43, PlayerData.UID);
					if (82865 - 447849 == -364984)
					{
						PhotonClient.Connection.OpCustom(44, hashtable, true);
						if (19299 - 534824 != -515524)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C17E RID: 49534 RVA: 0x0145DD34 File Offset: 0x0145BF34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveTown()
	{
		if (265134 - 250001 != 15133)
		{
		}
		for (;;)
		{
			Debug.Log("onLeaveTown");
			if (15136 - 43367 == -28231)
			{
				if (Game.mNextGameCode < 100)
				{
					if (111223 - 16251 != 94973)
					{
						this.JoinTown();
						if (161966 - 367279 != -205312)
						{
							break;
						}
					}
				}
				else
				{
					this.JoinGame();
					if (215172 - 329313 == -114141)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C17F RID: 49535 RVA: 0x0145DDFC File Offset: 0x0145BFFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (106301 - 99544 != 6757)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (140793 - 330169 != -189375)
			{
				Hashtable hashtable = new Hashtable();
				if (37936 - 298235 != -260298)
				{
					if (Game.mNextGameCode == 30)
					{
						if (185893 - 162263 == 23631)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (93956 - 467788 != -373832)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (147482 - 162469 == -14986)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (261792 - 267256 == -5463)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (103518 - 407003 != -303485)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (255253 - 111566 != 143687)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (197768 - 583631 != -385863)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (248485 - 239681 == 8805)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (128140 - 556985 != -428845)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (244941 - 281385 != -36444)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (278289 - 72036 != 206253)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (193804 - 309251 == -115446)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (238000 - 242062 == -4061)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (152479 - 580266 == -427786)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (124493 - 10840 != 113653)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (134497 - 585729 == -451231)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (258855 - 313859 != -55004)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (196952 - 248532 == -51579)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (103691 - 278355 != -174664)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (286055 - 271270 == 14786)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (38720 - 58452 == -19731)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (291810 - 331327 != -39517)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (72210 - 518502 == -446291)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (3671 - 473580 != -469909)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (24125 - 18038 != 6087)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (232901 - 229209 != 3692)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (55609 - 58726 != -3117)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (30387 - 352556 == -322168)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (87027 - 77361 == 9666)
					{
						this.OJ7nTGKt65j.OpCustom(42, hashtable, true);
						if (81808 - 48057 == 33751)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C180 RID: 49536 RVA: 0x0145E3B0 File Offset: 0x0145C5B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600C181 RID: 49537 RVA: 0x0145E3C0 File Offset: 0x0145C5C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinGame()
	{
		if (203726 - 441275 != -237549)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Game : " + Game.mNextGameId);
			if (26408 - 297270 != -270861)
			{
				Hashtable hashtable = new Hashtable();
				if (289225 - 393523 == -104298)
				{
					hashtable.Add(4, Game.mNextGameId);
					if (42170 - 388724 != -346553)
					{
						hashtable.Add(5, PhotonClient.cInt16(Game.mNextGameCode));
						if (78715 - 303338 != -224622)
						{
							this.OJ7nTGKt65j.OpCustom(51, hashtable, true);
							if (155694 - 360451 == -204757)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C182 RID: 49538 RVA: 0x0145E4DC File Offset: 0x0145C6DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinGame(Hashtable data)
	{
		Game.loadNextLevel();
	}

	// Token: 0x0600C183 RID: 49539 RVA: 0x0145E4E4 File Offset: 0x0145C6E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C184 RID: 49540 RVA: 0x0145E4E8 File Offset: 0x0145C6E8
	internal static bool O0gFVQtlLWHevZSGfQS1()
	{
		return true;
	}

	// Token: 0x0600C185 RID: 49541 RVA: 0x0145E4EC File Offset: 0x0145C6EC
	internal static bool MT4RqXtlOrB1ZbUHCyfc()
	{
		return false;
	}

	// Token: 0x0400A470 RID: 42096
	private LitePeer OJ7nTGKt65j;

	// Token: 0x0400A471 RID: 42097
	private PlayerCameraControl pMxnT1q6hFP;

	// Token: 0x0400A472 RID: 42098
	public GameObject startPoint1;

	// Token: 0x0400A473 RID: 42099
	public GameObject startPoint2;

	// Token: 0x0400A474 RID: 42100
	public GameObject startPoint3;

	// Token: 0x0400A475 RID: 42101
	public GameObject startPoint4;

	// Token: 0x0400A476 RID: 42102
	public GameObject startCamera1;

	// Token: 0x0400A477 RID: 42103
	public GameObject startCamera2;

	// Token: 0x0400A478 RID: 42104
	public GameObject startCamera3;

	// Token: 0x0400A479 RID: 42105
	public GameObject startCamera4;

	// Token: 0x02002045 RID: 8261
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePlayer$47713 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C186 RID: 49542 RVA: 0x0145E4F0 File Offset: 0x0145C6F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePlayer$47713(Hashtable data, T52_CentralSquare self_)
		{
			if (289574 - 447097 != -157523)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (283783 - 504605 != -220821)
				{
					base..ctor();
					if (86275 - 565599 != -479323)
					{
						this.$data$47724 = data;
						if (38728 - 338843 != -300114)
						{
							this.$self_$47725 = self_;
							if (25211 - 203330 == -178119)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C187 RID: 49543 RVA: 0x0145E5AC File Offset: 0x0145C7AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T52_CentralSquare.$onCreatePlayer$47713.$(this.$data$47724, this.$self_$47725);
		}

		// Token: 0x0600C188 RID: 49544 RVA: 0x0145E5C0 File Offset: 0x0145C7C0
		internal static bool SxqkR0tlmE55CRqWWI5x()
		{
			return true;
		}

		// Token: 0x0600C189 RID: 49545 RVA: 0x0145E5C4 File Offset: 0x0145C7C4
		internal static bool JLKBLatlFNlVNNnCtjag()
		{
			return false;
		}

		// Token: 0x0400A47A RID: 42106
		internal Hashtable $data$47724;

		// Token: 0x0400A47B RID: 42107
		internal T52_CentralSquare $self_$47725;

		// Token: 0x02002046 RID: 8262
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C18A RID: 49546 RVA: 0x0145E5C8 File Offset: 0x0145C7C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, T52_CentralSquare self_)
			{
				if (251974 - 577919 != -325944)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (251322 - 86676 != 164647)
					{
						base..ctor();
						if (180528 - 598186 != -417657)
						{
							this.$data$47722 = data;
							if (14897 - 566327 != -551429)
							{
								this.$self_$47723 = self_;
								if (205472 - 40923 == 164549)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C18B RID: 49547 RVA: 0x0145E684 File Offset: 0x0145C884
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (179779 - 226657 != -46878)
				{
				}
				for (;;)
				{
					IL_1A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_398;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (95704 - 125463 != -29759)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (202834 - 386051 == -183216)
						{
							continue;
						}
						this.YieldDefault(1);
						if (146539 - 298213 != -151674)
						{
							continue;
						}
						goto IL_398;
					default:
						if (298279 - 99509 == 198771)
						{
							continue;
						}
						break;
					}
					this.$nPlayer$47714 = Game.createPlayer(this.$data$47722);
					if (250231 - 250528 == -297)
					{
						this.$mPlayerList$47715 = GameObject.FindGameObjectsWithTag("Player");
						if (257513 - 113407 == 144106)
						{
							this.$$13676$47719 = 0;
							if (98931 - 285554 != -186622)
							{
								this.$$13677$47720 = this.$mPlayerList$47715;
								if (243475 - 459999 != -216523)
								{
									this.$$13678$47721 = this.$$13677$47720.Length;
									if (128445 - 442832 != -314386)
									{
										while (this.$$13676$47719 < this.$$13678$47721)
										{
											if (this.$nPlayer$47714 != this.$$13677$47720[this.$$13676$47719])
											{
												if (142534 - 485235 == -342700)
												{
													goto IL_1A;
												}
												Physics.IgnoreCollision(this.$nPlayer$47714.collider, this.$$13677$47720[this.$$13676$47719].collider, true);
												if (296918 - 328320 != -31402)
												{
													goto IL_1A;
												}
											}
											this.$$13676$47719++;
											if (192805 - 411648 == -218842)
											{
												goto IL_1A;
											}
										}
										if (271816 - 287841 == -16025)
										{
											this.$mPlayerCameraControl$47717 = (PlayerCameraControl)this.$self_$47723.GetComponent(typeof(PlayerCameraControl));
											if (258170 - 381297 == -123127)
											{
												this.$mPlayerCameraControl$47717.target = this.$nPlayer$47714;
												if (204834 - 7843 == 196991)
												{
													Camera.main.gameObject.layer = 1;
													if (42912 - 517230 == -474318)
													{
														Game.mPlayer = this.$nPlayer$47714;
														if (87230 - 368787 != -281556)
														{
															this.$mGameGui$47718 = (GameGui)this.$self_$47723.GetComponent(typeof(GameGui));
															if (172168 - 385044 != -212875)
															{
																this.$mGameGui$47718.enabled = true;
																if (218291 - 292802 == -74511)
																{
																	this.$self_$47723.SendMessage("fadeIn");
																	if (124374 - 539020 == -414646)
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
				IL_398:
				return false;
			}

			// Token: 0x0600C18C RID: 49548 RVA: 0x0145EA3C File Offset: 0x0145CC3C
			internal static bool pn2e20tlMhm7kMykOq5L()
			{
				return true;
			}

			// Token: 0x0600C18D RID: 49549 RVA: 0x0145EA40 File Offset: 0x0145CC40
			internal static bool pBTlvftlxHcwYeYcasLG()
			{
				return false;
			}

			// Token: 0x0400A47C RID: 42108
			internal GameObject $nPlayer$47714;

			// Token: 0x0400A47D RID: 42109
			internal GameObject[] $mPlayerList$47715;

			// Token: 0x0400A47E RID: 42110
			internal GameObject $otherPlayer$47716;

			// Token: 0x0400A47F RID: 42111
			internal PlayerCameraControl $mPlayerCameraControl$47717;

			// Token: 0x0400A480 RID: 42112
			internal GameGui $mGameGui$47718;

			// Token: 0x0400A481 RID: 42113
			internal int $$13676$47719;

			// Token: 0x0400A482 RID: 42114
			internal GameObject[] $$13677$47720;

			// Token: 0x0400A483 RID: 42115
			internal int $$13678$47721;

			// Token: 0x0400A484 RID: 42116
			internal Hashtable $data$47722;

			// Token: 0x0400A485 RID: 42117
			internal T52_CentralSquare $self_$47723;
		}
	}

	// Token: 0x02002047 RID: 8263
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseMessageBoard$47726 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C18E RID: 49550 RVA: 0x0145EA44 File Offset: 0x0145CC44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseMessageBoard$47726(T52_CentralSquare self_)
		{
			if (275935 - 356771 != -80835)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (7486 - 212940 != -205453)
				{
					base..ctor();
					if (176941 - 324605 != -147663)
					{
						this.$self_$47732 = self_;
						if (151034 - 592996 != -441961)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C18F RID: 49551 RVA: 0x0145EADC File Offset: 0x0145CCDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T52_CentralSquare.$UseMessageBoard$47726.$(this.$self_$47732);
		}

		// Token: 0x0600C190 RID: 49552 RVA: 0x0145EAEC File Offset: 0x0145CCEC
		internal static bool kreayPtlgjeI80dUHs4h()
		{
			return true;
		}

		// Token: 0x0600C191 RID: 49553 RVA: 0x0145EAF0 File Offset: 0x0145CCF0
		internal static bool EnTntCtlfZuhHo03oJC1()
		{
			return false;
		}

		// Token: 0x0400A486 RID: 42118
		internal T52_CentralSquare $self_$47732;

		// Token: 0x02002048 RID: 8264
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C192 RID: 49554 RVA: 0x0145EAF4 File Offset: 0x0145CCF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T52_CentralSquare self_)
			{
				if (173235 - 54080 != 119155)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265272 - 559831 != -294558)
					{
						base..ctor();
						if (197311 - 391116 != -193804)
						{
							this.$self_$47731 = self_;
							if (246535 - 303963 == -57428)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C193 RID: 49555 RVA: 0x0145EB8C File Offset: 0x0145CD8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (69469 - 211877 != -142408)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_222;
					case 1:
						goto IL_2EC;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (128395 - 440627 != -312232)
							{
								continue;
							}
							goto IL_1B8;
						}
						else
						{
							this.$mBoardGui$47728.enabled = true;
							if (248789 - 138846 != 109943)
							{
								continue;
							}
						}
						break;
					default:
						if (229493 - 465306 != -235813)
						{
							continue;
						}
						goto IL_222;
					}
					IL_3A:
					this.YieldDefault(1);
					if (258183 - 262162 != -3979)
					{
						continue;
					}
					goto IL_2EC;
					IL_222:
					if (Game.mGameState != eGameState.Normal)
					{
						if (263289 - 334797 == -71508)
						{
							goto IL_FB;
						}
					}
					else
					{
						this.$mGameGui$47727 = (GameGui)this.$self_$47731.GetComponent(typeof(GameGui));
						if (113116 - 533097 != -419980)
						{
							this.$mBoardGui$47728 = (BoardGui)this.$self_$47731.GetComponent(typeof(BoardGui));
							if (166042 - 510003 == -343961)
							{
								if (!this.$mGameGui$47727)
								{
									goto IL_3A;
								}
								if (127018 - 230721 == -103703)
								{
									if (!this.$mBoardGui$47728)
									{
										goto IL_3A;
									}
									if (230092 - 422385 != -192292)
									{
										Game.mGameState = eGameState.Hold;
										if (46303 - 76259 != -29955)
										{
											this.$mGameGui$47727.close();
											if (250067 - 548582 != -298514)
											{
												this.$mPlayer$47729 = Game.mPlayer;
												if (159711 - 293012 == -133301)
												{
													this.$mMessageBoard$47730 = GameObject.Find("MessageBoard");
													if (144748 - 449392 == -304644)
													{
														if (!this.$mMessageBoard$47730)
														{
															break;
														}
														if (114754 - 142034 == -27280)
														{
															if (!this.$mPlayer$47729)
															{
																break;
															}
															if (190408 - 375772 != -185363)
															{
																this.$mPlayer$47729.SendMessage("turnToPos", this.$mMessageBoard$47730.transform.position);
																if (288009 - 328620 != -40610)
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
				IL_C0:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_FB:
				IL_1B8:
				goto IL_2EC;
				goto IL_C0;
				IL_2EC:
				return false;
			}

			// Token: 0x0600C194 RID: 49556 RVA: 0x0145EE98 File Offset: 0x0145D098
			internal static bool YmT2QitlnXJosgoA7Md9()
			{
				return true;
			}

			// Token: 0x0600C195 RID: 49557 RVA: 0x0145EE9C File Offset: 0x0145D09C
			internal static bool DH6HfLtl6ckSghNJYIlD()
			{
				return false;
			}

			// Token: 0x0400A487 RID: 42119
			internal GameGui $mGameGui$47727;

			// Token: 0x0400A488 RID: 42120
			internal BoardGui $mBoardGui$47728;

			// Token: 0x0400A489 RID: 42121
			internal GameObject $mPlayer$47729;

			// Token: 0x0400A48A RID: 42122
			internal GameObject $mMessageBoard$47730;

			// Token: 0x0400A48B RID: 42123
			internal T52_CentralSquare $self_$47731;
		}
	}

	// Token: 0x02002049 RID: 8265
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseRankBoard$47733 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C196 RID: 49558 RVA: 0x0145EEA0 File Offset: 0x0145D0A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseRankBoard$47733(T52_CentralSquare self_)
		{
			if (182489 - 482095 != -299605)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (219056 - 553005 != -333948)
				{
					base..ctor();
					if (205508 - 285667 == -80159)
					{
						this.$self_$47735 = self_;
						if (142053 - 132127 != 9927)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C197 RID: 49559 RVA: 0x0145EF38 File Offset: 0x0145D138
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T52_CentralSquare.$UseRankBoard$47733.$(this.$self_$47735);
		}

		// Token: 0x0600C198 RID: 49560 RVA: 0x0145EF48 File Offset: 0x0145D148
		internal static bool cYovTptlihPVVSXUTaII()
		{
			return true;
		}

		// Token: 0x0600C199 RID: 49561 RVA: 0x0145EF4C File Offset: 0x0145D14C
		internal static bool taSpWOtlK6hwsidpFWOX()
		{
			return false;
		}

		// Token: 0x0400A48C RID: 42124
		internal T52_CentralSquare $self_$47735;

		// Token: 0x0200204A RID: 8266
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C19A RID: 49562 RVA: 0x0145EF50 File Offset: 0x0145D150
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T52_CentralSquare self_)
			{
				if (86565 - 559965 != -473399)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (130050 - 495585 == -365535)
					{
						base..ctor();
						if (72875 - 374037 != -301161)
						{
							this.$self_$47734 = self_;
							if (69824 - 289030 == -219206)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C19B RID: 49563 RVA: 0x0145EFE8 File Offset: 0x0145D1E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (8791 - 344045 != -335253)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_FD;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (277788 - 131699 != 146089)
						{
							continue;
						}
						this.YieldDefault(1);
						if (267692 - 206048 != 61644)
						{
							continue;
						}
						goto IL_FD;
					default:
						if (232554 - 455970 == -223415)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Hold;
					if (224128 - 547623 != -323494)
					{
						this.$self_$47734.SendMessage("newNoticeBar", Language.getMessage("T52_CentralSquare", 903), SendMessageOptions.DontRequireReceiver);
						if (225012 - 268231 != -43218)
						{
							break;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				IL_FD:
				return false;
			}

			// Token: 0x0600C19C RID: 49564 RVA: 0x0145F104 File Offset: 0x0145D304
			internal static bool QUy4s0tldya6p7jD5SLG()
			{
				return true;
			}

			// Token: 0x0600C19D RID: 49565 RVA: 0x0145F108 File Offset: 0x0145D308
			internal static bool hKSNTftlJLtMi7URpwiH()
			{
				return false;
			}

			// Token: 0x0400A48D RID: 42125
			internal T52_CentralSquare $self_$47734;
		}
	}

	// Token: 0x0200204B RID: 8267
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLeopard$47736 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C19E RID: 49566 RVA: 0x0145F10C File Offset: 0x0145D30C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLeopard$47736(T52_CentralSquare self_)
		{
			if (91949 - 145626 != -53676)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (51041 - 488956 != -437914)
				{
					base..ctor();
					if (104895 - 5503 == 99392)
					{
						this.$self_$47742 = self_;
						if (259958 - 341211 != -81252)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C19F RID: 49567 RVA: 0x0145F1A4 File Offset: 0x0145D3A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T52_CentralSquare.$TalkToLeopard$47736.$(this.$self_$47742);
		}

		// Token: 0x0600C1A0 RID: 49568 RVA: 0x0145F1B4 File Offset: 0x0145D3B4
		internal static bool axAUkItlDw73jNDOq6ri()
		{
			return true;
		}

		// Token: 0x0600C1A1 RID: 49569 RVA: 0x0145F1B8 File Offset: 0x0145D3B8
		internal static bool IjUcKdtlvABwH7rBbDVh()
		{
			return false;
		}

		// Token: 0x0400A48E RID: 42126
		internal T52_CentralSquare $self_$47742;

		// Token: 0x0200204C RID: 8268
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C1A2 RID: 49570 RVA: 0x0145F1BC File Offset: 0x0145D3BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T52_CentralSquare self_)
			{
				if (260663 - 22954 != 237709)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (297747 - 205552 != 92196)
					{
						base..ctor();
						if (283418 - 340762 != -57343)
						{
							this.$self_$47741 = self_;
							if (271174 - 508459 != -237284)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C1A3 RID: 49571 RVA: 0x0145F254 File Offset: 0x0145D454
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (203122 - 536699 != -333576)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_38A;
					case 2:
						this.$m$47740 = Language.getMessage("T52_CentralSquare", UnityEngine.Random.Range(231, 240));
						if (107860 - 69234 != 38626)
						{
							continue;
						}
						this.$mStoryGui$47739.newStoryMessage("Leopard", "Leopard", this.$m$47740, eTalkType.friend);
						if (14087 - 4935 != 9153)
						{
							goto Block_13;
						}
						continue;
					case 3:
						this.$mStoryGui$47739.close();
						if (292265 - 507346 == -215080)
						{
							continue;
						}
						this.$mGameGui$47737.enabled = true;
						if (112515 - 402971 != -290455)
						{
							goto Block_5;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (12857 - 265233 != -252376)
						{
							continue;
						}
						this.YieldDefault(1);
						if (169637 - 217474 != -47837)
						{
							continue;
						}
						goto IL_38A;
					default:
						if (128523 - 235290 != -106767)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (197644 - 391169 != -193524)
						{
							goto Block_17;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (123259 - 599822 == -476563)
						{
							this.$mGameGui$47737 = (GameGui)this.$self_$47741.GetComponent(typeof(GameGui));
							if (83845 - 218460 != -134614)
							{
								if (this.$mGameGui$47737)
								{
									if (44079 - 503 != 43576)
									{
										continue;
									}
									this.$mGameGui$47737.close();
									if (282261 - 147970 != 134291)
									{
										continue;
									}
								}
								this.$mLeopard$47738 = GameObject.Find("Leopard");
								if (149492 - 243368 == -93876)
								{
									if (this.$mLeopard$47738)
									{
										if (93608 - 433781 == -340172)
										{
											continue;
										}
										Game.mPlayer.SendMessage("turnToPos", this.$mLeopard$47738.transform.position);
										if (17263 - 171618 == -154354)
										{
											continue;
										}
									}
									else
									{
										Debug.LogError("Cannot find Leopard");
										if (65027 - 530047 == -465019)
										{
											continue;
										}
									}
									this.$mStoryGui$47739 = (StoryGui)this.$self_$47741.GetComponent(typeof(StoryGui));
									if (172470 - 183627 != -11156)
									{
										this.$mStoryGui$47739.startStoryMessage("Leopard", "Leopard", eTalkType.friend);
										if (172972 - 240562 == -67590)
										{
											goto IL_144;
										}
									}
								}
							}
						}
					}
				}
				Block_5:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_144:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_13:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_17:
				IL_38A:
				return false;
			}

			// Token: 0x0600C1A4 RID: 49572 RVA: 0x0145F600 File Offset: 0x0145D800
			internal static bool NRvVZ8tlRakU4s0iYavH()
			{
				return true;
			}

			// Token: 0x0600C1A5 RID: 49573 RVA: 0x0145F604 File Offset: 0x0145D804
			internal static bool Nvt1iStlwWX0Gkp4bS9a()
			{
				return false;
			}

			// Token: 0x0400A48F RID: 42127
			internal GameGui $mGameGui$47737;

			// Token: 0x0400A490 RID: 42128
			internal GameObject $mLeopard$47738;

			// Token: 0x0400A491 RID: 42129
			internal StoryGui $mStoryGui$47739;

			// Token: 0x0400A492 RID: 42130
			internal string $m$47740;

			// Token: 0x0400A493 RID: 42131
			internal T52_CentralSquare $self_$47741;
		}
	}

	// Token: 0x0200204D RID: 8269
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToBoldas$47743 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C1A6 RID: 49574 RVA: 0x0145F608 File Offset: 0x0145D808
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToBoldas$47743(T52_CentralSquare self_)
		{
			if (122405 - 324125 != -201720)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (76918 - 427658 == -350740)
				{
					base..ctor();
					if (284061 - 399201 != -115139)
					{
						this.$self_$47748 = self_;
						if (72343 - 599342 == -526999)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C1A7 RID: 49575 RVA: 0x0145F6A0 File Offset: 0x0145D8A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T52_CentralSquare.$TalkToBoldas$47743.$(this.$self_$47748);
		}

		// Token: 0x0600C1A8 RID: 49576 RVA: 0x0145F6B0 File Offset: 0x0145D8B0
		internal static bool xM6YLEtlqbHJ0lBY4451()
		{
			return true;
		}

		// Token: 0x0600C1A9 RID: 49577 RVA: 0x0145F6B4 File Offset: 0x0145D8B4
		internal static bool alYarbtl75CGg9HIH8Ph()
		{
			return false;
		}

		// Token: 0x0400A494 RID: 42132
		internal T52_CentralSquare $self_$47748;

		// Token: 0x0200204E RID: 8270
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C1AA RID: 49578 RVA: 0x0145F6B8 File Offset: 0x0145D8B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T52_CentralSquare self_)
			{
				if (168359 - 362211 != -193852)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (257385 - 1602 != 255784)
					{
						base..ctor();
						if (175508 - 210647 == -35139)
						{
							this.$self_$47747 = self_;
							if (278866 - 215624 != 63243)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C1AB RID: 49579 RVA: 0x0145F750 File Offset: 0x0145D950
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7155 - 86515 != -79359)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_518;
					case 2:
						this.$mStoryGui$47745.newStoryMessage("Liger", "Boldas", Language.getMessage("T52_CentralSquare", 101 + UnityEngine.Random.Range(0, 9)), eTalkType.friend);
						if (176070 - 291126 != -115055)
						{
							goto Block_22;
						}
						continue;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (72701 - 191634 != -118932)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$47745.close();
							if (204720 - 524607 != -319887)
							{
								continue;
							}
							if (this.$mBoldas$47746)
							{
								if (85993 - 247770 != -161777)
								{
									continue;
								}
								this.$mBoldas$47746.animation.CrossFade("root", 0.2f);
								if (264021 - 387700 == -123678)
								{
									continue;
								}
							}
							this.$mGameGui$47744.enabled = true;
							if (26288 - 347117 != -320828)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (155329 - 536497 != -381167)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (279476 - 28004 != 251472)
							{
								continue;
							}
							goto IL_204;
						}
						break;
					default:
						if (285481 - 106690 == 178792)
						{
							continue;
						}
						break;
					}
					if (PlayerData.QuestID == 1)
					{
						if (124199 - 282982 == -158782)
						{
							continue;
						}
						Q1_LetterToBoldas.TalkToBoldas(this.$self_$47747.gameObject);
						if (269749 - 195852 == 73898)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == -1)
					{
						if (258812 - 168332 != 90480)
						{
							continue;
						}
						Q1_LetterToBoldas.TalkToBoldasRepeat(this.$self_$47747.gameObject);
						if (246929 - 518462 != -271533)
						{
							continue;
						}
					}
					else if (Game.mGameState != eGameState.Normal)
					{
						if (197963 - 487494 != -289530)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mGameGui$47744 = (GameGui)this.$self_$47747.GetComponent(typeof(GameGui));
						if (62505 - 568331 != -505826)
						{
							continue;
						}
						this.$mStoryGui$47745 = (StoryGui)this.$self_$47747.GetComponent(typeof(StoryGui));
						if (213368 - 127896 != 85472)
						{
							continue;
						}
						if (this.$mGameGui$47744)
						{
							if (74678 - 39030 == 35649)
							{
								continue;
							}
							if (this.$mStoryGui$47745)
							{
								if (120991 - 352995 != -232004)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (177847 - 19608 != 158239)
								{
									continue;
								}
								this.$mGameGui$47744.close();
								if (183029 - 40298 == 142732)
								{
									continue;
								}
								this.$mBoldas$47746 = GameObject.Find("Boldas");
								if (69950 - 518741 != -448791)
								{
									continue;
								}
								if (this.$mBoldas$47746)
								{
									if (76416 - 590860 == -514443)
									{
										continue;
									}
									this.$mBoldas$47746.animation.CrossFade("talk", 0.2f);
									if (171799 - 283954 != -112155)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mBoldas$47746.transform.position);
									if (14027 - 173495 == -159467)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Boldas");
									if (62654 - 592561 == -529906)
									{
										continue;
									}
								}
								this.$mStoryGui$47745.startStoryMessage("Liger", "Boldas", eTalkType.friend);
								if (269685 - 249640 != 20045)
								{
									continue;
								}
								goto IL_2FE;
							}
						}
					}
					IL_204:
					this.YieldDefault(1);
				}
				while (134430 - 285052 != -150622);
				goto IL_518;
				Block_15:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_21:
				goto IL_518;
				IL_2FE:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_22:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_29:
				IL_518:
				return false;
			}

			// Token: 0x0600C1AC RID: 49580 RVA: 0x0145FC88 File Offset: 0x0145DE88
			internal static bool rWgTe9tlPDTEpQrgkSJX()
			{
				return true;
			}

			// Token: 0x0600C1AD RID: 49581 RVA: 0x0145FC8C File Offset: 0x0145DE8C
			internal static bool DMjjQItl0hTLVAftOEKI()
			{
				return false;
			}

			// Token: 0x0400A495 RID: 42133
			internal GameGui $mGameGui$47744;

			// Token: 0x0400A496 RID: 42134
			internal StoryGui $mStoryGui$47745;

			// Token: 0x0400A497 RID: 42135
			internal GameObject $mBoldas$47746;

			// Token: 0x0400A498 RID: 42136
			internal T52_CentralSquare $self_$47747;
		}
	}

	// Token: 0x0200204F RID: 8271
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$47749 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C1AE RID: 49582 RVA: 0x0145FC90 File Offset: 0x0145DE90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$47749(int n, T52_CentralSquare self_)
		{
			if (136796 - 517516 != -380719)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (78696 - 551428 != -472731)
				{
					base..ctor();
					if (285299 - 328731 != -43431)
					{
						this.$n$47757 = n;
						if (51168 - 294376 != -243207)
						{
							this.$self_$47758 = self_;
							if (196457 - 458416 == -261959)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C1AF RID: 49583 RVA: 0x0145FD4C File Offset: 0x0145DF4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T52_CentralSquare.$TalkToPanther$47749.$(this.$n$47757, this.$self_$47758);
		}

		// Token: 0x0600C1B0 RID: 49584 RVA: 0x0145FD60 File Offset: 0x0145DF60
		internal static bool Wjc9Ewtlbp531cwVcDNr()
		{
			return true;
		}

		// Token: 0x0600C1B1 RID: 49585 RVA: 0x0145FD64 File Offset: 0x0145DF64
		internal static bool B4OavntluNXLa7Y0b6DB()
		{
			return false;
		}

		// Token: 0x0400A499 RID: 42137
		internal int $n$47757;

		// Token: 0x0400A49A RID: 42138
		internal T52_CentralSquare $self_$47758;

		// Token: 0x02002050 RID: 8272
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C1B2 RID: 49586 RVA: 0x0145FD68 File Offset: 0x0145DF68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, T52_CentralSquare self_)
			{
				if (11279 - 557046 != -545767)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (66611 - 486967 != -420355)
					{
						base..ctor();
						if (132035 - 570128 != -438092)
						{
							this.$n$47755 = n;
							if (298070 - 496520 != -198449)
							{
								this.$self_$47756 = self_;
								if (274690 - 467081 != -192390)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600C1B3 RID: 49587 RVA: 0x0145FE24 File Offset: 0x0145E024
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211896 - 509355 != -297459)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_59D;
					case 2:
						this.$m$47753 = null;
						if (62108 - 540871 != -478763)
						{
							continue;
						}
						this.$$switch$8961$47754 = this.$n$47755;
						if (164365 - 167288 == -2922)
						{
							continue;
						}
						if (this.$$switch$8961$47754 == 1)
						{
							if (285752 - 258788 != 26964)
							{
								continue;
							}
							this.$m$47753 = Language.getMessage("T52_CentralSquare", 201 + UnityEngine.Random.Range(0, 9));
							if (45977 - 245570 == -199592)
							{
								continue;
							}
						}
						else if (this.$$switch$8961$47754 == 2)
						{
							if (272947 - 110430 == 162518)
							{
								continue;
							}
							this.$m$47753 = Language.getMessage("T52_CentralSquare", 211 + UnityEngine.Random.Range(0, 9));
							if (7375 - 449042 == -441666)
							{
								continue;
							}
						}
						else if (this.$$switch$8961$47754 == 3)
						{
							if (70385 - 230935 == -160549)
							{
								continue;
							}
							this.$m$47753 = Language.getMessage("T52_CentralSquare", 221 + UnityEngine.Random.Range(0, 9));
							if (40639 - 225435 == -184795)
							{
								continue;
							}
						}
						this.$mStoryGui$47751.newStoryMessage("none", "Panther", this.$m$47753, eTalkType.friend);
						if (131223 - 80334 != 50890)
						{
							goto Block_36;
						}
						continue;
					case 3:
						this.$mStoryGui$47751.close();
						if (108009 - 531695 == -423685)
						{
							continue;
						}
						if (this.$mPanther$47752)
						{
							if (162552 - 300046 != -137494)
							{
								continue;
							}
							this.$mPanther$47752.animation.CrossFade("root", 0.2f);
							if (65165 - 31984 != 33181)
							{
								continue;
							}
						}
						this.$mGameGui$47750.enabled = true;
						if (10243 - 530074 != -519831)
						{
							continue;
						}
						goto IL_3B8;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (107685 - 448287 != -340602)
						{
							continue;
						}
						goto IL_35E;
					default:
						if (250360 - 555489 != -305129)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (22783 - 508503 != -485720)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mGameGui$47750 = (GameGui)this.$self_$47756.GetComponent(typeof(GameGui));
						if (194896 - 142393 == 52504)
						{
							continue;
						}
						this.$mStoryGui$47751 = (StoryGui)this.$self_$47756.GetComponent(typeof(StoryGui));
						if (291788 - 81359 == 210430)
						{
							continue;
						}
						if (this.$mGameGui$47750)
						{
							if (55353 - 91354 == -36000)
							{
								continue;
							}
							if (this.$mStoryGui$47751)
							{
								if (113338 - 408251 != -294913)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (98455 - 332562 == -234106)
								{
									continue;
								}
								this.$mGameGui$47750.close();
								if (79770 - 37173 == 42598)
								{
									continue;
								}
								this.$mPanther$47752 = GameObject.Find("Panther" + this.$n$47755);
								if (244865 - 9389 != 235476)
								{
									continue;
								}
								if (this.$mPanther$47752)
								{
									if (164832 - 452043 != -287211)
									{
										continue;
									}
									this.$mPanther$47752.animation.CrossFade("talk", 0.2f);
									if (125901 - 389602 != -263701)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mPanther$47752.transform.position);
									if (75287 - 204544 != -129257)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Panther" + this.$n$47755);
									if (138243 - 457561 == -319317)
									{
										continue;
									}
								}
								this.$mStoryGui$47751.startStoryMessage("none", "Panther", eTalkType.friend);
								if (20911 - 514860 != -493949)
								{
									continue;
								}
								goto IL_422;
							}
						}
					}
					IL_35E:
					this.YieldDefault(1);
				}
				while (280141 - 352191 == -72049);
				goto IL_59D;
				IL_3B8:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_422:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_59D;
				Block_36:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_59D:
				return false;
			}

			// Token: 0x0600C1B4 RID: 49588 RVA: 0x014603E0 File Offset: 0x0145E5E0
			internal static bool iYvZictlIJydPIaAHlPl()
			{
				return true;
			}

			// Token: 0x0600C1B5 RID: 49589 RVA: 0x014603E4 File Offset: 0x0145E5E4
			internal static bool Xm7MIptlB6D7dW3pj1St()
			{
				return false;
			}

			// Token: 0x0400A49B RID: 42139
			internal GameGui $mGameGui$47750;

			// Token: 0x0400A49C RID: 42140
			internal StoryGui $mStoryGui$47751;

			// Token: 0x0400A49D RID: 42141
			internal GameObject $mPanther$47752;

			// Token: 0x0400A49E RID: 42142
			internal string $m$47753;

			// Token: 0x0400A49F RID: 42143
			internal int $$switch$8961$47754;

			// Token: 0x0400A4A0 RID: 42144
			internal int $n$47755;

			// Token: 0x0400A4A1 RID: 42145
			internal T52_CentralSquare $self_$47756;
		}
	}

	// Token: 0x02002051 RID: 8273
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToMainStreet$47759 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C1B6 RID: 49590 RVA: 0x014603E8 File Offset: 0x0145E5E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToMainStreet$47759(T52_CentralSquare self_)
		{
			if (119055 - 313191 != -194136)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (207306 - 50524 == 156782)
				{
					base..ctor();
					if (28645 - 374743 == -346098)
					{
						this.$self_$47762 = self_;
						if (78261 - 502654 == -424393)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C1B7 RID: 49591 RVA: 0x01460480 File Offset: 0x0145E680
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T52_CentralSquare.$ExitToMainStreet$47759.$(this.$self_$47762);
		}

		// Token: 0x0600C1B8 RID: 49592 RVA: 0x01460490 File Offset: 0x0145E690
		internal static bool ganBwptler3jP6vcYFWL()
		{
			return true;
		}

		// Token: 0x0600C1B9 RID: 49593 RVA: 0x01460494 File Offset: 0x0145E694
		internal static bool eQKbPTtlrTFQ4AhJWkOY()
		{
			return false;
		}

		// Token: 0x0400A4A2 RID: 42146
		internal T52_CentralSquare $self_$47762;

		// Token: 0x02002052 RID: 8274
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C1BA RID: 49594 RVA: 0x01460498 File Offset: 0x0145E698
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T52_CentralSquare self_)
			{
				if (165715 - 579518 != -413802)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (144003 - 448800 == -304797)
					{
						base..ctor();
						if (190999 - 472335 != -281335)
						{
							this.$self_$47761 = self_;
							if (12869 - 176949 == -164080)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C1BB RID: 49595 RVA: 0x01460530 File Offset: 0x0145E730
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (225205 - 77904 != 147302)
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
						this.$self_$47761.LeaveTown();
						if (52368 - 586376 == -534007)
						{
							continue;
						}
						this.YieldDefault(1);
						if (198792 - 9470 != 189322)
						{
							continue;
						}
						goto IL_1E1;
					default:
						if (141484 - 522222 != -380738)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (263269 - 166381 != 96889)
					{
						Game.mStateTime = Time.time;
						if (89475 - 556062 != -466586)
						{
							Game.mNextGameId = 501;
							if (86744 - 504241 != -417496)
							{
								Game.mNextGameCode = 51;
								if (235941 - 409442 != -173500)
								{
									this.$mGameGui$47760 = (GameGui)this.$self_$47761.GetComponent(typeof(GameGui));
									if (91963 - 126692 != -34728)
									{
										if (this.$mGameGui$47760)
										{
											if (15921 - 334372 == -318450)
											{
												continue;
											}
											this.$mGameGui$47760.close();
											if (166826 - 121410 != 45416)
											{
												continue;
											}
										}
										this.$self_$47761.SendMessage("fadeOut");
										if (111846 - 32229 == 79617)
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

			// Token: 0x0600C1BC RID: 49596 RVA: 0x01460730 File Offset: 0x0145E930
			internal static bool jJ2NG2tljotnIJHcLXyb()
			{
				return true;
			}

			// Token: 0x0600C1BD RID: 49597 RVA: 0x01460734 File Offset: 0x0145E934
			internal static bool Ls5Zn1tlhMV9WPhdyCLL()
			{
				return false;
			}

			// Token: 0x0400A4A3 RID: 42147
			internal GameGui $mGameGui$47760;

			// Token: 0x0400A4A4 RID: 42148
			internal T52_CentralSquare $self_$47761;
		}
	}

	// Token: 0x02002053 RID: 8275
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToCityLibrary$47763 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C1BE RID: 49598 RVA: 0x01460738 File Offset: 0x0145E938
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToCityLibrary$47763(T52_CentralSquare self_)
		{
			if (17304 - 474648 != -457344)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (101538 - 283387 != -181848)
				{
					base..ctor();
					if (255671 - 379660 == -123989)
					{
						this.$self_$47766 = self_;
						if (181954 - 76512 == 105442)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C1BF RID: 49599 RVA: 0x014607D0 File Offset: 0x0145E9D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T52_CentralSquare.$ExitToCityLibrary$47763.$(this.$self_$47766);
		}

		// Token: 0x0600C1C0 RID: 49600 RVA: 0x014607E0 File Offset: 0x0145E9E0
		internal static bool BZ2ZSFtlsFim0ViMNmqu()
		{
			return true;
		}

		// Token: 0x0600C1C1 RID: 49601 RVA: 0x014607E4 File Offset: 0x0145E9E4
		internal static bool KFKYeEtl9LJHZIFsuRbq()
		{
			return false;
		}

		// Token: 0x0400A4A5 RID: 42149
		internal T52_CentralSquare $self_$47766;

		// Token: 0x02002054 RID: 8276
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C1C2 RID: 49602 RVA: 0x014607E8 File Offset: 0x0145E9E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T52_CentralSquare self_)
			{
				if (167146 - 205809 != -38663)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (277595 - 260320 != 17276)
					{
						base..ctor();
						if (288371 - 55320 != 233052)
						{
							this.$self_$47765 = self_;
							if (28695 - 268002 == -239307)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C1C3 RID: 49603 RVA: 0x01460880 File Offset: 0x0145EA80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (188550 - 200269 != -11719)
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
						this.$self_$47765.LeaveTown();
						if (184077 - 122103 != 61974)
						{
							continue;
						}
						this.YieldDefault(1);
						if (153401 - 442295 != -288894)
						{
							continue;
						}
						goto IL_1E1;
					default:
						if (165777 - 15208 == 150570)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (7485 - 147437 == -139952)
					{
						Game.mStateTime = Time.time;
						if (137131 - 251017 == -113886)
						{
							Game.mNextGameId = 503;
							if (137861 - 93223 != 44639)
							{
								Game.mNextGameCode = 53;
								if (30716 - 179360 == -148644)
								{
									this.$mGameGui$47764 = (GameGui)this.$self_$47765.GetComponent(typeof(GameGui));
									if (164141 - 89448 != 74694)
									{
										if (this.$mGameGui$47764)
										{
											if (286808 - 566172 == -279363)
											{
												continue;
											}
											this.$mGameGui$47764.close();
											if (32733 - 71699 != -38966)
											{
												continue;
											}
										}
										this.$self_$47765.SendMessage("fadeOut");
										if (53250 - 153194 != -99943)
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

			// Token: 0x0600C1C4 RID: 49604 RVA: 0x01460A80 File Offset: 0x0145EC80
			internal static bool g4W7futl1mWZG4GBXPnE()
			{
				return true;
			}

			// Token: 0x0600C1C5 RID: 49605 RVA: 0x01460A84 File Offset: 0x0145EC84
			internal static bool OA7YCytl4xODr8jXCLCU()
			{
				return false;
			}

			// Token: 0x0400A4A6 RID: 42150
			internal GameGui $mGameGui$47764;

			// Token: 0x0400A4A7 RID: 42151
			internal T52_CentralSquare $self_$47765;
		}
	}

	// Token: 0x02002055 RID: 8277
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToLightPark$47767 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C1C6 RID: 49606 RVA: 0x01460A88 File Offset: 0x0145EC88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToLightPark$47767(T52_CentralSquare self_)
		{
			if (116499 - 566549 != -450049)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217716 - 355472 != -137755)
				{
					base..ctor();
					if (230092 - 137396 == 92696)
					{
						this.$self_$47770 = self_;
						if (196507 - 377470 == -180963)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C1C7 RID: 49607 RVA: 0x01460B20 File Offset: 0x0145ED20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T52_CentralSquare.$ExitToLightPark$47767.$(this.$self_$47770);
		}

		// Token: 0x0600C1C8 RID: 49608 RVA: 0x01460B30 File Offset: 0x0145ED30
		internal static bool LHD06gtlzoSmpGKljCi5()
		{
			return true;
		}

		// Token: 0x0600C1C9 RID: 49609 RVA: 0x01460B34 File Offset: 0x0145ED34
		internal static bool NBSEt5tya0Wpsxqu37Sp()
		{
			return false;
		}

		// Token: 0x0400A4A8 RID: 42152
		internal T52_CentralSquare $self_$47770;

		// Token: 0x02002056 RID: 8278
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C1CA RID: 49610 RVA: 0x01460B38 File Offset: 0x0145ED38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T52_CentralSquare self_)
			{
				if (194264 - 594737 != -400473)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (140942 - 566272 == -425330)
					{
						base..ctor();
						if (162768 - 508633 != -345864)
						{
							this.$self_$47769 = self_;
							if (65717 - 363067 == -297350)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C1CB RID: 49611 RVA: 0x01460BD0 File Offset: 0x0145EDD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211229 - 265467 != -54237)
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
						this.$self_$47769.LeaveTown();
						if (33588 - 331459 != -297871)
						{
							continue;
						}
						this.YieldDefault(1);
						if (184782 - 473743 != -288961)
						{
							continue;
						}
						goto IL_1E1;
					default:
						if (84920 - 7127 == 77794)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (56938 - 457241 != -400302)
					{
						Game.mStateTime = Time.time;
						if (84754 - 477691 == -392937)
						{
							Game.mNextGameId = 504;
							if (272032 - 129633 == 142399)
							{
								Game.mNextGameCode = 54;
								if (286193 - 35976 != 250218)
								{
									this.$mGameGui$47768 = (GameGui)this.$self_$47769.GetComponent(typeof(GameGui));
									if (111078 - 47875 != 63204)
									{
										if (this.$mGameGui$47768)
										{
											if (95866 - 161795 != -65929)
											{
												continue;
											}
											this.$mGameGui$47768.close();
											if (281662 - 494374 == -212711)
											{
												continue;
											}
										}
										this.$self_$47769.SendMessage("fadeOut");
										if (54747 - 36943 == 17804)
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

			// Token: 0x0600C1CC RID: 49612 RVA: 0x01460DD0 File Offset: 0x0145EFD0
			internal static bool UYiR1Bty5cDrBblrWJKw()
			{
				return true;
			}

			// Token: 0x0600C1CD RID: 49613 RVA: 0x01460DD4 File Offset: 0x0145EFD4
			internal static bool gf5JOGtypZZAIqexHyFM()
			{
				return false;
			}

			// Token: 0x0400A4A9 RID: 42153
			internal GameGui $mGameGui$47768;

			// Token: 0x0400A4AA RID: 42154
			internal T52_CentralSquare $self_$47769;
		}
	}

	// Token: 0x02002057 RID: 8279
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToLightTheater$47771 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600C1CE RID: 49614 RVA: 0x01460DD8 File Offset: 0x0145EFD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToLightTheater$47771(T52_CentralSquare self_)
		{
			if (208564 - 167742 != 40823)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (266914 - 374917 != -108002)
				{
					base..ctor();
					if (216243 - 281393 != -65149)
					{
						this.$self_$47774 = self_;
						if (290953 - 282236 != 8718)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600C1CF RID: 49615 RVA: 0x01460E70 File Offset: 0x0145F070
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new T52_CentralSquare.$ExitToLightTheater$47771.$(this.$self_$47774);
		}

		// Token: 0x0600C1D0 RID: 49616 RVA: 0x01460E80 File Offset: 0x0145F080
		internal static bool flK1iktyVuHJbg34rDdg()
		{
			return true;
		}

		// Token: 0x0600C1D1 RID: 49617 RVA: 0x01460E84 File Offset: 0x0145F084
		internal static bool jt93QKtytuiae5NtXBFu()
		{
			return false;
		}

		// Token: 0x0400A4AB RID: 42155
		internal T52_CentralSquare $self_$47774;

		// Token: 0x02002058 RID: 8280
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600C1D2 RID: 49618 RVA: 0x01460E88 File Offset: 0x0145F088
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(T52_CentralSquare self_)
			{
				if (186869 - 171701 != 15168)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (180224 - 428783 == -248559)
					{
						base..ctor();
						if (67303 - 572958 == -505655)
						{
							this.$self_$47773 = self_;
							if (238845 - 316870 == -78025)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600C1D3 RID: 49619 RVA: 0x01460F20 File Offset: 0x0145F120
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224351 - 547409 != -323057)
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
						this.$self_$47773.LeaveTown();
						if (286568 - 397503 == -110934)
						{
							continue;
						}
						this.YieldDefault(1);
						if (58280 - 327072 != -268792)
						{
							continue;
						}
						goto IL_1E1;
					default:
						if (270054 - 476329 == -206274)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (107684 - 103895 != 3790)
					{
						Game.mStateTime = Time.time;
						if (169003 - 499900 != -330896)
						{
							Game.mNextGameId = 507;
							if (226750 - 550877 != -324126)
							{
								Game.mNextGameCode = 57;
								if (56710 - 8564 != 48147)
								{
									this.$mGameGui$47772 = (GameGui)this.$self_$47773.GetComponent(typeof(GameGui));
									if (212358 - 377124 == -164766)
									{
										if (this.$mGameGui$47772)
										{
											if (48167 - 111807 != -63640)
											{
												continue;
											}
											this.$mGameGui$47772.close();
											if (122990 - 343937 != -220947)
											{
												continue;
											}
										}
										this.$self_$47773.SendMessage("fadeOut");
										if (216781 - 184610 != 32172)
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

			// Token: 0x0600C1D4 RID: 49620 RVA: 0x01461120 File Offset: 0x0145F320
			internal static bool UpotWTtyNvVpnbQaf9aI()
			{
				return true;
			}

			// Token: 0x0600C1D5 RID: 49621 RVA: 0x01461124 File Offset: 0x0145F324
			internal static bool vXjAdhtyY5B3aXYovEed()
			{
				return false;
			}

			// Token: 0x0400A4AC RID: 42156
			internal GameGui $mGameGui$47772;

			// Token: 0x0400A4AD RID: 42157
			internal T52_CentralSquare $self_$47773;
		}
	}
}
