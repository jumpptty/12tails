using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x020015F4 RID: 5620
[Serializable]
public class M506_PearlPalace : MonoBehaviour
{
	// Token: 0x06008263 RID: 33379 RVA: 0x01086C30 File Offset: 0x01084E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M506_PearlPalace()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008264 RID: 33380 RVA: 0x01086C40 File Offset: 0x01084E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (32882 - 328737 != -295854)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (268715 - 308129 == -39414)
			{
				Game.mGameType = 5;
				if (237432 - 158981 != 78452)
				{
					if (Chat.Initialized)
					{
						if (236487 - 518580 == -282092)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (109075 - 599043 == -489967)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (116912 - 379125 == -262212)
						{
							continue;
						}
					}
					this.CLcc98Y53U6 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (207011 - 479925 == -272914)
					{
						this.fOGc9inZ1Po = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (150499 - 6613 != 143887)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008265 RID: 33381 RVA: 0x01086D98 File Offset: 0x01084F98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (161397 - 480988 != -319591)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (297325 - 439532 == -142207)
				{
					if (Game.mNextGameCode != 506)
					{
						break;
					}
					if (35061 - 217020 == -181959)
					{
						Game.nextGame();
						if (257548 - 366571 == -109023)
						{
							Game.mGameCode = 506;
							if (12622 - 532607 != -519984)
							{
								Game.mGameType = 5;
								if (47783 - 20145 != 27639)
								{
									Game.mGameTime = Time.time;
									if (13654 - 39931 != -26276)
									{
										Game.mGameScore = 0;
										if (255603 - 540651 == -285048)
										{
											Game.mGameMana = 0;
											if (119518 - 193530 == -74012)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (4797 - 323166 == -318369)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (295651 - 165024 != 130628)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (133945 - 521219 == -387274)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (166492 - 361078 == -194586)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (105804 - 155268 != -49463)
																{
																	this.gkUc9BNH2BL = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (156399 - 348495 == -192096)
																	{
																		this.DsWc9S1oaOm = PhotonClient.Connection;
																		if (175754 - 376501 != -200746)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (62415 - 263591 == -201176)
																			{
																				this.InitGame();
																				if (219740 - 358720 == -138980)
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
				if (225171 - 232491 != -7319)
				{
					Game.mGameType = 99;
					if (281347 - 66956 == 214391)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008266 RID: 33382 RVA: 0x010870A0 File Offset: 0x010852A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (128190 - 346766 != -218576)
		{
		}
		for (;;)
		{
			if (this.DsWc9S1oaOm == null)
			{
				if (146842 - 30782 == 116060)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (7804 - 24763 != -16958)
				{
					if (mGameState == eGameState.Init)
					{
						if (143546 - 136697 != 6850)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (25213 - 371089 == -345876)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (62195 - 147080 != -84884)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (203177 - 31604 != 171574)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (54917 - 309517 != -254599)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (109500 - 348787 != -239286)
						{
							if (Time.time > this.Mujc90b0QPX)
							{
								if (60061 - 552334 == -492272)
								{
									continue;
								}
								Game.mGameMana++;
								if (209714 - 314044 != -104330)
								{
									continue;
								}
								this.Mujc90b0QPX = Time.time + (float)12;
								if (155676 - 340416 == -184739)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (145475 - 131353 != 14122)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (113430 - 430 == 113001)
									{
										continue;
									}
									this.audio.Play();
									if (255488 - 532942 == -277453)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (182215 - 229889 == -47674)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (102655 - 77285 == 25370)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (96715 - 485882 == -389167)
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
						if (241306 - 375621 != -134314)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008267 RID: 33383 RVA: 0x010873A0 File Offset: 0x010855A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (117224 - 438627 != -321402)
		{
		}
		for (;;)
		{
			if (!this.CLcc98Y53U6)
			{
				if (126006 - 183240 != -57233)
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
				if (4779 - 218552 == -213773)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (24580 - 417021 != -392440)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (188968 - 285877 != -96908)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (137607 - 493902 == -356295)
							{
								GUI.depth = 1;
								if (269937 - 574175 != -304237)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (129799 - 184932 == -55133)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (54976 - 210381 != -155404)
										{
											Color color = GUI.color;
											if (269674 - 314079 != -44404)
											{
												color.a = a;
												if (28915 - 12593 == 16322)
												{
													if (87430 - 122544 == -35114)
													{
														Color color2 = GUI.color = color;
														if (87376 - 513361 == -425985)
														{
															if (212885 - 305417 == -92532)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.CLcc98Y53U6);
																if (109836 - 384859 != -275022)
																{
																	float a2 = 1f;
																	if (233012 - 173853 != 59160)
																	{
																		Color color3 = GUI.color;
																		if (272046 - 366198 != -94151)
																		{
																			float num3 = color3.a = a2;
																			if (215432 - 276040 == -60608)
																			{
																				if (135918 - 274922 != -139003)
																				{
																					Color color4 = GUI.color = color3;
																					if (133363 - 517186 != -383822 && 4060 - 71313 == -67253)
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

	// Token: 0x06008268 RID: 33384 RVA: 0x01087720 File Offset: 0x01085920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (229430 - 575658 != -346228)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (67481 - 463726 != -396244)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (25648 - 316472 == -290824)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (281995 - 570489 == -288494)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (98209 - 424469 != -326259)
						{
							int num4 = num;
							if (231561 - 539065 != -307503)
							{
								if (num4 == 5061)
								{
									if (248944 - 512911 == -263967)
									{
										if (this.P7Rc9DLSB3A >= 1)
										{
											break;
										}
										if (71899 - 374561 != -302661)
										{
											this.P7Rc9DLSB3A = 1;
											if (91024 - 385704 == -294680)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (num4 != 5062)
									{
										break;
									}
									if (108284 - 274926 == -166642)
									{
										if (PlayerData.UID != num3)
										{
											break;
										}
										if (184933 - 583242 != -398308)
										{
											if (this.P7Rc9DLSB3A >= 2)
											{
												break;
											}
											if (18563 - 544714 == -526151)
											{
												this.P7Rc9DLSB3A = 2;
												if (154855 - 118507 == 36348)
												{
													GameObject gameObject = GameObject.Find("SpawnPoint1");
													if (56316 - 340314 == -283998)
													{
														if (!gameObject)
														{
															break;
														}
														if (78512 - 18607 != 59906)
														{
															this.createActor("Ammonite", 7, gameObject.transform.position, gameObject.transform.forward);
															if (88980 - 567370 != -478389)
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

	// Token: 0x06008269 RID: 33385 RVA: 0x010879BC File Offset: 0x01085BBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M506_PearlPalace.$StartEvent$39451(this).GetEnumerator();
	}

	// Token: 0x0600826A RID: 33386 RVA: 0x010879CC File Offset: 0x01085BCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AmmoniteEvent(GameObject mAmmnite)
	{
		return new M506_PearlPalace.$AmmoniteEvent$39455(mAmmnite, this).GetEnumerator();
	}

	// Token: 0x0600826B RID: 33387 RVA: 0x010879DC File Offset: 0x01085BDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterBossBattle(GameObject enterObject)
	{
		if (245428 - 409441 != -164013)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (153846 - 90818 == 63028)
			{
				if (this.P7Rc9DLSB3A >= 1)
				{
					break;
				}
				if (270239 - 92082 != 178158)
				{
					Debug.Log("Entering Boss Area");
					if (24419 - 93733 == -69314)
					{
						this.P7Rc9DLSB3A = 1;
						if (27687 - 430749 != -403061)
						{
							Game.sendMissionEvent(5061, 0);
							if (199090 - 441628 != -242537)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600826C RID: 33388 RVA: 0x01087AD4 File Offset: 0x01085CD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (211182 - 17754 != 193428)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (161568 - 340422 != -178853)
			{
				CharacterControl characterControl = null;
				if (150788 - 567349 != -416560)
				{
					if (mPlayer)
					{
						if (20505 - 571071 != -550566)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (195980 - 181602 != 14378)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (153383 - 453735 == -300352)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (40291 - 435417 != -395125)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (280533 - 453619 == -173086)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (218954 - 184272 == 34683)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (93301 - 185065 != -91764)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (25099 - 399792 != -374693)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (215534 - 590221 != -374686)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (49804 - 598175 == -548371)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (158210 - 192447 == -34237)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (206349 - 139559 != 66791)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (212943 - 394146 == -181203)
								{
									if (!changeGui)
									{
										break;
									}
									if (101989 - 193958 == -91969)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (261163 - 430155 != -168992)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (25651 - 48306 != -22655)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (274370 - 529788 == -255418)
										{
											gameGui.close();
											if (40679 - 454206 != -413526)
											{
												changeGui.enabled = true;
												if (86172 - 523007 != -436834)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (150265 - 334224 != -183958)
													{
														if (!gameObject)
														{
															break;
														}
														if (259416 - 344367 != -84950)
														{
															if (!mPlayer)
															{
																break;
															}
															if (30645 - 124539 == -93894)
															{
																Debug.Log("UseLifeAltar");
																if (78875 - 254685 == -175810)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (136391 - 155019 != -18627)
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

	// Token: 0x0600826D RID: 33389 RVA: 0x01087F34 File Offset: 0x01086134
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (229867 - 94111 != 135756)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (262256 - 77031 == 185225)
			{
				hashtable.Add(43, PlayerData.UID);
				if (288855 - 295458 != -6602)
				{
					hashtable.Add(73, nType);
					if (16004 - 40626 == -24622)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (70947 - 270338 != -199390)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (78857 - 98634 == -19777)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (294601 - 557650 == -263049)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (268418 - 135833 != 132586)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (272739 - 250180 == 22559)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (28818 - 52479 == -23661)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (253844 - 288032 == -34188)
												{
													this.DsWc9S1oaOm.OpCustom(63, hashtable, true);
													if (207480 - 308623 != -101142)
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

	// Token: 0x0600826E RID: 33390 RVA: 0x010881EC File Offset: 0x010863EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (184802 - 23039 != 161764)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (24870 - 67357 == -42487)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (116322 - 449381 == -333059)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (168888 - 536448 != -367559)
						{
							if (this.E2Gc9oUFdkf <= 0)
							{
								break;
							}
							if (285693 - 345677 == -59984)
							{
								this.E2Gc9oUFdkf--;
								if (218283 - 71463 != 146821)
								{
									if (this.E2Gc9oUFdkf != 0)
									{
										break;
									}
									if (276806 - 270983 != 5824)
									{
										Game.setGameState(eGameState.Ready);
										if (261514 - 359629 == -98115)
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
						if (!gameObject)
						{
							break;
						}
						if (261797 - 159813 != 101985)
						{
							if (!(gameObject.name == "Ammonite"))
							{
								break;
							}
							if (164196 - 242046 != -77849)
							{
								this.StartCoroutine_Auto(this.AmmoniteEvent(gameObject));
								if (278309 - 325364 != -47054)
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

	// Token: 0x0600826F RID: 33391 RVA: 0x010883A8 File Offset: 0x010865A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (16511 - 139908 != -123396)
		{
		}
		for (;;)
		{
			IL_F8:
			if (Game.mGameState > eGameState.AllHold)
			{
				if (252984 - 228584 != 24401)
				{
					break;
				}
			}
			else
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (279035 - 121503 == 157532)
				{
					int i = 0;
					if (43027 - 94039 != -51011)
					{
						CharacterControl[] array2 = array;
						if (172821 - 24347 == 148474)
						{
							int length = array2.Length;
							if (295746 - 388946 == -93200)
							{
								while (i < length)
								{
									UnityEngine.Object.Destroy(array2[i].gameObject);
									if (92302 - 164373 != -72071)
									{
										goto IL_F8;
									}
									i++;
									if (65491 - 243239 == -177747)
									{
										goto IL_F8;
									}
								}
								if (82040 - 242678 != -160637)
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

	// Token: 0x06008270 RID: 33392 RVA: 0x01088500 File Offset: 0x01086700
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008271 RID: 33393 RVA: 0x01088514 File Offset: 0x01086714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (134507 - 292862 != -158354)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (176771 - 510089 == -333318)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (280956 - 435373 != -154416)
				{
					if (!characterControl)
					{
						break;
					}
					if (28207 - 21953 != 6255)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (44965 - 411781 == -366816)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (10749 - 510717 != -499967)
							{
								string type = characterControl.Type;
								if (43538 - 184011 == -140473)
								{
									if (type == "Ammonite")
									{
										if (291759 - 536829 == -245070)
										{
											Game.sendMissionEvent(5063, 0);
											if (269993 - 375853 == -105860)
											{
												break;
											}
										}
									}
									else if (type == "WaterBug")
									{
										if (185109 - 196409 != -11299)
										{
											Game.sendMissionEvent(5064, 0);
											if (250545 - 535799 != -285253)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "NeonBug"))
										{
											break;
										}
										if (136846 - 455573 == -318727)
										{
											Game.sendMissionEvent(5065, 0);
											if (73387 - 295798 == -222411)
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

	// Token: 0x06008272 RID: 33394 RVA: 0x01088734 File Offset: 0x01086934
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (235367 - 572617 != -337250)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (237976 - 466514 != -228537)
			{
				hashtable.Add(71, CID);
				if (39539 - 299541 == -260002)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (112728 - 404820 == -292092)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (112501 - 332815 == -220314)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (236601 - 401077 == -164476)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (149103 - 311204 != -162100)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (76224 - 523169 != -446944)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (76542 - 216308 != -139765)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (137701 - 419458 != -281756)
											{
												this.DsWc9S1oaOm.OpCustom(61, hashtable, true);
												if (135792 - 30617 == 105175)
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

	// Token: 0x06008273 RID: 33395 RVA: 0x010889C0 File Offset: 0x01086BC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (73461 - 522208 != -448746)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (171007 - 489647 == -318640)
			{
				if (!gameObject)
				{
					break;
				}
				if (161645 - 265093 != -103447)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (201808 - 214100 == -12292)
					{
						playerCameraControl.target = gameObject;
						if (262372 - 518861 == -256489)
						{
							this.StartGame();
							if (148714 - 301951 != -153236)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008274 RID: 33396 RVA: 0x01088AB0 File Offset: 0x01086CB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (8444 - 414573 != -406129)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (224385 - 71572 == 152813)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (2888 - 269958 == -267070)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (16941 - 426049 != -409107)
					{
						Hashtable hashtable = new Hashtable();
						if (50609 - 308499 == -257890)
						{
							hashtable.Add(43, PlayerData.UID);
							if (289497 - 383305 != -93807)
							{
								hashtable.Add(71, nCID);
								if (128239 - 499070 != -370830)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (291675 - 543201 != -251525)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (204856 - 286639 != -81782)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (216287 - 250598 == -34311)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (225477 - 599133 != -373655)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (147629 - 597608 == -449979)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (246417 - 298472 != -52054)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (218742 - 222701 != -3958)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (163204 - 281342 == -118138)
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

	// Token: 0x06008275 RID: 33397 RVA: 0x01088DD0 File Offset: 0x01086FD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M506_PearlPalace.$onChangePlayer$39467(data, this).GetEnumerator();
	}

	// Token: 0x06008276 RID: 33398 RVA: 0x01088DE0 File Offset: 0x01086FE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (241830 - 266772 != -24942)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (275950 - 452120 == -176170)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (268471 - 518849 != -250377)
				{
					gameGui.ResetTeamBar();
					if (168552 - 395669 != -227116)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008277 RID: 33399 RVA: 0x01088E8C File Offset: 0x0108708C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M506_PearlPalace.$onDeadPlayer$39474(this).GetEnumerator();
	}

	// Token: 0x06008278 RID: 33400 RVA: 0x01088E9C File Offset: 0x0108709C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (27046 - 504543 != -477497)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (289018 - 158071 != 130948)
			{
				this.gkUc9BNH2BL.target = Game.mPlayer;
				if (56341 - 452233 == -395892)
				{
					this.gkUc9BNH2BL.enabled = true;
					if (38860 - 335930 != -297069)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (15929 - 241110 != -225181)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (22700 - 375577 == -352876)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (205445 - 159785 != 45661)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (60403 - 71573 != -11169)
							{
								if (!gameGui)
								{
									break;
								}
								if (140304 - 73667 != 66638)
								{
									gameGui.enabled = true;
									if (89984 - 549843 != -459858)
									{
										gameGui.closeDeadMenu();
										if (89699 - 175814 == -86115)
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

	// Token: 0x06008279 RID: 33401 RVA: 0x01089048 File Offset: 0x01087248
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (259060 - 127275 != 131786)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (24238 - 178861 != -154622)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (36704 - 294494 != -257789)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (75456 - 483671 == -408215)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600827A RID: 33402 RVA: 0x0108910C File Offset: 0x0108730C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600827B RID: 33403 RVA: 0x01089138 File Offset: 0x01087338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (120415 - 549135 != -428719)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (176036 - 582048 == -406012)
			{
				Hashtable customOpParameters = new Hashtable();
				if (98690 - 291569 != -192878)
				{
					this.DsWc9S1oaOm.OpCustom(52, customOpParameters, true);
					if (288338 - 63692 != 224647)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600827C RID: 33404 RVA: 0x010891E0 File Offset: 0x010873E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (193618 - 104279 != 89340)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (250281 - 422528 != -172246)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (59412 - 266275 != -206862)
				{
					Game.mGameState = eGameState.Setup;
					if (148523 - 514881 == -366358)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600827D RID: 33405 RVA: 0x01089284 File Offset: 0x01087484
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (148838 - 44846 != 103993)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (119405 - 24358 == 95047)
			{
				if (num == PlayerData.UID)
				{
					if (159216 - 466744 != -307527)
					{
						this.SetupActors();
						if (235600 - 384473 == -148873)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (237737 - 216054 != 21684)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600827E RID: 33406 RVA: 0x01089354 File Offset: 0x01087554
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (95354 - 39853 != 55501)
		{
		}
		for (;;)
		{
			IL_71:
			Debug.Log("Creating Actors");
			if (92082 - 556758 == -464676)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (103382 - 326298 == -222916)
				{
					int i = 0;
					if (85683 - 489680 != -403996)
					{
						CharacterControl[] array2 = array;
						if (141493 - 523214 == -381721)
						{
							int length = array2.Length;
							if (200017 - 145476 != 54542)
							{
								while (i < length)
								{
									string type = array2[i].Type;
									if (86340 - 340794 == -254453)
									{
										goto IL_71;
									}
									if (type == "NeonBug")
									{
										goto IL_B8;
									}
									if (291387 - 514223 == -222835)
									{
										goto IL_71;
									}
									if (type == "WaterBug")
									{
										if (231355 - 20192 != 211164)
										{
											goto IL_B8;
										}
										goto IL_71;
									}
									IL_17C:
									UnityEngine.Object.Destroy(array2[i].gameObject);
									if (17320 - 184089 != -166769)
									{
										goto IL_71;
									}
									this.E2Gc9oUFdkf++;
									if (136249 - 160616 == -24366)
									{
										goto IL_71;
									}
									i++;
									if (64809 - 232603 != -167793)
									{
										continue;
									}
									goto IL_71;
									IL_B8:
									this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
									if (248228 - 272568 != -24340)
									{
										goto IL_71;
									}
									goto IL_17C;
								}
								if (226048 - 358435 != -132386)
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

	// Token: 0x0600827F RID: 33407 RVA: 0x010895A8 File Offset: 0x010877A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (200640 - 547024 != -346383)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (179720 - 314071 == -134351)
			{
				Game.mGameState = eGameState.Ready;
				if (118182 - 72989 != 45194)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (170392 - 145710 == 24682)
					{
						this.pWMc9kv0MqJ = playerSlot;
						if (209497 - 50072 != 159426)
						{
							GameObject gameObject = null;
							if (47642 - 431239 != -383596)
							{
								GameObject gameObject2 = null;
								if (204399 - 439352 != -234952)
								{
									if (playerSlot > 1)
									{
										if (191572 - 193101 != -1529)
										{
											continue;
										}
										if (playerSlot <= 5)
										{
											if (67591 - 204224 == -136632)
											{
												continue;
											}
											gameObject = GameObject.Find("StartPoint" + playerSlot);
											if (185293 - 476067 == -290773)
											{
												continue;
											}
											gameObject2 = GameObject.Find("StartCamera" + playerSlot);
											if (152709 - 568979 != -416270)
											{
												continue;
											}
										}
									}
									if (!gameObject)
									{
										if (27228 - 550593 != -523365)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint1");
										if (148311 - 323265 == -174953)
										{
											continue;
										}
									}
									if (gameObject)
									{
										if (95782 - 203274 == -107491)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
										if (145689 - 481861 != -336172)
										{
											continue;
										}
									}
									if (!gameObject2)
									{
										if (205254 - 154529 == 50726)
										{
											continue;
										}
										gameObject2 = GameObject.Find("startCamera1");
										if (267264 - 299900 == -32635)
										{
											continue;
										}
									}
									if (!gameObject2)
									{
										break;
									}
									if (115749 - 365 != 115385)
									{
										this.transform.position = gameObject2.transform.position;
										if (67424 - 272238 == -204814)
										{
											this.transform.rotation = gameObject2.transform.rotation;
											if (143440 - 24219 != 119222)
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

	// Token: 0x06008280 RID: 33408 RVA: 0x010898C4 File Offset: 0x01087AC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (244807 - 433217 != -188409)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (121094 - 333950 == -212856)
			{
				Game.mGameState = eGameState.Start;
				if (219290 - 279623 == -60333)
				{
					Game.mGameTime = Time.time;
					if (9257 - 440128 != -430870)
					{
						Game.mStateTime = Time.time;
						if (182981 - 397969 == -214988)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (161228 - 117592 != 43637)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008281 RID: 33409 RVA: 0x010899B0 File Offset: 0x01087BB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008282 RID: 33410 RVA: 0x010899B4 File Offset: 0x01087BB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M506_PearlPalace.$onGameComplete$39480(data, this).GetEnumerator();
	}

	// Token: 0x06008283 RID: 33411 RVA: 0x010899C4 File Offset: 0x01087BC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M506_PearlPalace.$ReturnToTown$39491(this).GetEnumerator();
	}

	// Token: 0x06008284 RID: 33412 RVA: 0x010899D4 File Offset: 0x01087BD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M506_PearlPalace.$ReturnToGuild$39496(this).GetEnumerator();
	}

	// Token: 0x06008285 RID: 33413 RVA: 0x010899E4 File Offset: 0x01087BE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M506_PearlPalace.$ReturnToCamp$39500(this).GetEnumerator();
	}

	// Token: 0x06008286 RID: 33414 RVA: 0x010899F4 File Offset: 0x01087BF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (11663 - 139381 != -127718)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (19832 - 432552 != -412719)
			{
				Hashtable hashtable = new Hashtable();
				if (85636 - 140520 != -54883)
				{
					hashtable.Add(43, PlayerData.UID);
					if (44994 - 571600 == -526606)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (104325 - 200201 != -95875)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008287 RID: 33415 RVA: 0x01089ACC File Offset: 0x01087CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008288 RID: 33416 RVA: 0x01089AE0 File Offset: 0x01087CE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (122292 - 381062 != -258769)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (204191 - 72511 != 131681)
			{
				Hashtable hashtable = new Hashtable();
				if (85709 - 55306 != 30404)
				{
					if (Game.mNextGameCode == 30)
					{
						if (101430 - 9932 != 91498)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (217534 - 302709 != -85175)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (178988 - 96438 == 82551)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (275450 - 355037 != -79587)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (123661 - 549662 != -426001)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (184683 - 465683 != -281000)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (49796 - 263894 == -214097)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (67944 - 528040 == -460095)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (172242 - 298729 == -126486)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (710 - 161891 != -161181)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (181261 - 157132 != 24129)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (152399 - 263311 != -110912)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (58103 - 494208 == -436104)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (70879 - 401782 == -330902)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (241173 - 109376 != 131797)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (280630 - 176841 != 103789)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (108673 - 277534 == -168860)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (90568 - 562912 != -472344)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (205082 - 401240 != -196158)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (131914 - 504426 == -372511)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (44523 - 518665 != -474142)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (254274 - 36466 != 217808)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (230150 - 459859 != -229709)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (114967 - 335873 != -220906)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (201256 - 37700 != 163556)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (141447 - 140545 != 902)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (182539 - 298191 != -115652)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (205560 - 54380 != 151180)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (162558 - 259622 == -97064)
					{
						this.DsWc9S1oaOm.OpCustom(42, hashtable, true);
						if (19408 - 77920 == -58512)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008289 RID: 33417 RVA: 0x0108A094 File Offset: 0x01088294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600828A RID: 33418 RVA: 0x0108A0A4 File Offset: 0x010882A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600828B RID: 33419 RVA: 0x0108A0A8 File Offset: 0x010882A8
	internal static bool flQRtIpsA8PLFh4EDOO2()
	{
		return true;
	}

	// Token: 0x0600828C RID: 33420 RVA: 0x0108A0AC File Offset: 0x010882AC
	internal static bool c5g2ClpslgLJYtuKkJRu()
	{
		return false;
	}

	// Token: 0x04008088 RID: 32904
	private LitePeer DsWc9S1oaOm;

	// Token: 0x04008089 RID: 32905
	private PlayerCameraControl gkUc9BNH2BL;

	// Token: 0x0400808A RID: 32906
	private float Mujc90b0QPX;

	// Token: 0x0400808B RID: 32907
	private Texture CLcc98Y53U6;

	// Token: 0x0400808C RID: 32908
	private AudioClip fOGc9inZ1Po;

	// Token: 0x0400808D RID: 32909
	private int P7Rc9DLSB3A;

	// Token: 0x0400808E RID: 32910
	private int yEPc9mQnmuH;

	// Token: 0x0400808F RID: 32911
	private int Cy1c9jd9Bug;

	// Token: 0x04008090 RID: 32912
	public AudioClip battleMusic;

	// Token: 0x04008091 RID: 32913
	private int E2Gc9oUFdkf;

	// Token: 0x04008092 RID: 32914
	private int pWMc9kv0MqJ;

	// Token: 0x04008093 RID: 32915
	public GameObject waterBridge;

	// Token: 0x020015F5 RID: 5621
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$39451 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600828D RID: 33421 RVA: 0x0108A0B0 File Offset: 0x010882B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$39451(M506_PearlPalace self_)
		{
			if (235314 - 130929 != 104386)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (175035 - 124307 == 50728)
				{
					base..ctor();
					if (82196 - 138579 == -56383)
					{
						this.$self_$39454 = self_;
						if (16740 - 246975 != -230234)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600828E RID: 33422 RVA: 0x0108A148 File Offset: 0x01088348
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M506_PearlPalace.$StartEvent$39451.$(this.$self_$39454);
		}

		// Token: 0x0600828F RID: 33423 RVA: 0x0108A158 File Offset: 0x01088358
		internal static bool GMJ8BRpsy0veMpxQeYjT()
		{
			return true;
		}

		// Token: 0x06008290 RID: 33424 RVA: 0x0108A15C File Offset: 0x0108835C
		internal static bool pOksOQpsSxDkOAdG1c7N()
		{
			return false;
		}

		// Token: 0x04008094 RID: 32916
		internal M506_PearlPalace $self_$39454;

		// Token: 0x020015F6 RID: 5622
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008291 RID: 33425 RVA: 0x0108A160 File Offset: 0x01088360
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M506_PearlPalace self_)
			{
				if (242938 - 43819 != 199119)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (128145 - 498675 == -370530)
					{
						base..ctor();
						if (55722 - 328805 != -273082)
						{
							this.$self_$39453 = self_;
							if (204745 - 537906 != -333160)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008292 RID: 33426 RVA: 0x0108A1F8 File Offset: 0x010883F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (67053 - 563963 != -496909)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1FD;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (184439 - 17172 == 167268)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (223055 - 146934 != 76121)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (283379 - 577272 != -293893)
						{
							continue;
						}
						if (this.$self_$39453.fOGc9inZ1Po)
						{
							if (276495 - 340064 == -63568)
							{
								continue;
							}
							this.$self_$39453.audio.PlayOneShot(this.$self_$39453.fOGc9inZ1Po);
							if (148690 - 74939 == 73752)
							{
								continue;
							}
						}
						Time.timeScale = 0.9f;
						if (19883 - 228814 == -208930)
						{
							continue;
						}
						this.YieldDefault(1);
						if (225194 - 253436 != -28242)
						{
							continue;
						}
						goto IL_1FD;
					default:
						if (157379 - 299306 != -141927)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$39452 = (GameGui)this.$self_$39453.GetComponent(typeof(GameGui));
					if (69043 - 515786 != -446742)
					{
						this.$mGameGui$39452.enabled = true;
						if (285945 - 359879 != -73933)
						{
							this.$self_$39453.SendMessage("fadeIn");
							if (44054 - 523607 == -479553)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1FD:
				return false;
			}

			// Token: 0x06008293 RID: 33427 RVA: 0x0108A414 File Offset: 0x01088614
			internal static bool RdUnBhpsoqAfNBSndFgo()
			{
				return true;
			}

			// Token: 0x06008294 RID: 33428 RVA: 0x0108A418 File Offset: 0x01088618
			internal static bool EhwcsBpsEw4BHuCHKOl5()
			{
				return false;
			}

			// Token: 0x04008095 RID: 32917
			internal GameGui $mGameGui$39452;

			// Token: 0x04008096 RID: 32918
			internal M506_PearlPalace $self_$39453;
		}
	}

	// Token: 0x020015F7 RID: 5623
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AmmoniteEvent$39455 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008295 RID: 33429 RVA: 0x0108A41C File Offset: 0x0108861C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AmmoniteEvent$39455(GameObject mAmmnite, M506_PearlPalace self_)
		{
			if (188957 - 238407 != -49450)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (139236 - 86399 == 52837)
				{
					base..ctor();
					if (178872 - 251488 == -72616)
					{
						this.$mAmmnite$39465 = mAmmnite;
						if (252980 - 201241 == 51739)
						{
							this.$self_$39466 = self_;
							if (134223 - 389965 != -255741)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008296 RID: 33430 RVA: 0x0108A4D8 File Offset: 0x010886D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M506_PearlPalace.$AmmoniteEvent$39455.$(this.$mAmmnite$39465, this.$self_$39466);
		}

		// Token: 0x06008297 RID: 33431 RVA: 0x0108A4EC File Offset: 0x010886EC
		internal static bool jhSDsrps23MqYBJk1M44()
		{
			return true;
		}

		// Token: 0x06008298 RID: 33432 RVA: 0x0108A4F0 File Offset: 0x010886F0
		internal static bool Qpyt72ps8nv71d6YQ589()
		{
			return false;
		}

		// Token: 0x04008097 RID: 32919
		internal GameObject $mAmmnite$39465;

		// Token: 0x04008098 RID: 32920
		internal M506_PearlPalace $self_$39466;

		// Token: 0x020015F8 RID: 5624
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008299 RID: 33433 RVA: 0x0108A4F4 File Offset: 0x010886F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GameObject mAmmnite, M506_PearlPalace self_)
			{
				if (242283 - 252561 != -10278)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (54729 - 67579 == -12850)
					{
						base..ctor();
						if (259636 - 254210 != 5427)
						{
							this.$mAmmnite$39463 = mAmmnite;
							if (238958 - 236834 == 2124)
							{
								this.$self_$39464 = self_;
								if (75656 - 451127 == -375471)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600829A RID: 33434 RVA: 0x0108A5B0 File Offset: 0x010887B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (38919 - 98944 != -60024)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B99;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (134555 - 556709 != -422154)
							{
								continue;
							}
							goto IL_19E;
						}
						else
						{
							this.$startPoint$39460 = GameObject.Find("StartPoint" + (this.$self_$39464.pWMc9kv0MqJ + 4));
							if (8156 - 537290 == -529133)
							{
								continue;
							}
							if (this.$startPoint$39460)
							{
								if (47933 - 303630 == -255696)
								{
									continue;
								}
								if (Game.mPlayer)
								{
									if (284047 - 533432 != -249385)
									{
										continue;
									}
									Game.mPlayer.transform.position = this.$startPoint$39460.transform.position;
									if (162394 - 228628 == -66233)
									{
										continue;
									}
									Game.mPlayer.transform.rotation = this.$startPoint$39460.transform.rotation;
									if (161496 - 374435 == -212938)
									{
										continue;
									}
									Game.mPlayer.SendMessage("PositionEvent");
									if (184441 - 259776 != -75335)
									{
										continue;
									}
								}
							}
							this.$startCamera$39461 = GameObject.Find("StartCamera" + (this.$self_$39464.pWMc9kv0MqJ + 4));
							if (289874 - 273856 != 16018)
							{
								continue;
							}
							if (!this.$startCamera$39461)
							{
								goto IL_657;
							}
							if (78633 - 197197 != -118564)
							{
								continue;
							}
							if (!Game.mPlayer)
							{
								goto IL_657;
							}
							if (194921 - 99833 != 95088)
							{
								continue;
							}
							this.$self_$39464.transform.position = this.$startCamera$39461.transform.position;
							if (117977 - 252330 == -134352)
							{
								continue;
							}
							this.$self_$39464.transform.rotation = this.$startCamera$39461.transform.rotation;
							if (136289 - 275655 != -139366)
							{
								continue;
							}
							goto IL_657;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (25370 - 17097 != 8274)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							this.$self_$39464.SendMessage("fadeIn");
							if (263114 - 468217 != -205103)
							{
								continue;
							}
							goto IL_501;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (165576 - 221384 != -55808)
							{
								continue;
							}
							goto IL_A77;
						}
						else
						{
							if (!this.$mAmmoniteCam$39458)
							{
								goto IL_1A;
							}
							if (116160 - 440375 != -324215)
							{
								continue;
							}
							if (!this.$mCameraControl$39459)
							{
								goto IL_1A;
							}
							if (92243 - 489462 == -397218)
							{
								continue;
							}
							this.$mCameraControl$39459.setSpecialTarget(this.$mAmmoniteCam$39458, 2f);
							if (26570 - 559471 != -532900)
							{
								goto Block_56;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (63215 - 153624 != -90409)
							{
								continue;
							}
							goto IL_9E9;
						}
						else
						{
							this.$mStoryGui$39457.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (245711 - 247411 != -1699)
							{
								goto Block_73;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (227071 - 268745 != -41673)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$mAmmnite$39463.SendMessage("RPC_summon");
							if (296174 - 57382 == 238793)
							{
								continue;
							}
							this.$mStoryGui$39457.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M506_PearlPalace", 5061), eTalkType.friend);
							if (111558 - 152327 == -40768)
							{
								continue;
							}
							if (this.$mCameraControl$39459)
							{
								if (155076 - 171330 != -16254)
								{
									continue;
								}
								this.$mCameraControl$39459.AddCamereShake(4f);
								if (126630 - 186443 != -59813)
								{
									continue;
								}
							}
							this.$mGameVolume$39462 = this.$self_$39464.audio.volume;
							if (65832 - 82489 != -16657)
							{
								continue;
							}
							this.$self_$39464.audio.volume = (float)0;
							if (118187 - 127809 != -9621)
							{
								goto Block_67;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (237826 - 290626 != -52800)
							{
								continue;
							}
							goto IL_55;
						}
						else
						{
							this.$mStoryGui$39457.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M506_PearlPalace", 5062), eTalkType.friend);
							if (41717 - 282049 != -240331)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (106189 - 420166 != -313976)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39457.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M506_PearlPalace", 5063), eTalkType.friend);
							if (262874 - 204613 != 58262)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (133271 - 74003 != 59268)
							{
								continue;
							}
							goto IL_368;
						}
						else
						{
							if (this.$mCameraControl$39459)
							{
								if (74179 - 308976 == -234796)
								{
									continue;
								}
								this.$mCameraControl$39459.specialTarget = null;
								if (205591 - 573244 == -367652)
								{
									continue;
								}
							}
							this.$mStoryGui$39457.close();
							if (120989 - 171587 != -50598)
							{
								continue;
							}
							this.$mGameGui$39456.enabled = true;
							if (140134 - 533966 == -393831)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (105221 - 321741 == -216519)
							{
								continue;
							}
							this.$self_$39464.P7Rc9DLSB3A = 3;
							if (38830 - 128435 != -89605)
							{
								continue;
							}
							if (!this.$self_$39464.battleMusic)
							{
								goto IL_827;
							}
							if (79539 - 279792 != -200253)
							{
								continue;
							}
							this.$self_$39464.audio.clip = this.$self_$39464.battleMusic;
							if (153414 - 145287 == 8128)
							{
								continue;
							}
							this.$self_$39464.audio.volume = this.$mGameVolume$39462;
							if (119321 - 394501 == -275179)
							{
								continue;
							}
							if (this.$self_$39464.audio.isPlaying)
							{
								goto IL_827;
							}
							if (26985 - 533171 == -506185)
							{
								continue;
							}
							if (Game.volume <= 0)
							{
								goto IL_827;
							}
							if (136024 - 212018 != -75994)
							{
								continue;
							}
							this.$self_$39464.audio.Play();
							if (160582 - 234790 != -74207)
							{
								goto IL_827;
							}
							continue;
						}
						break;
					default:
						if (78725 - 479079 == -400353)
						{
							continue;
						}
						break;
					}
					if (this.$self_$39464.P7Rc9DLSB3A >= 3)
					{
						goto IL_6EB;
					}
					if (31550 - 129918 == -98367)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (86267 - 112807 != -26540)
						{
							continue;
						}
						goto IL_6EB;
					}
					else
					{
						this.$mGameGui$39456 = (GameGui)this.$self_$39464.GetComponent(typeof(GameGui));
						if (201046 - 34121 == 166926)
						{
							continue;
						}
						this.$mStoryGui$39457 = (StoryGui)this.$self_$39464.GetComponent(typeof(StoryGui));
						if (148595 - 410735 == -262139)
						{
							continue;
						}
						this.$mAmmoniteCam$39458 = GameObject.Find("AmmoniteCam");
						if (161656 - 372071 != -210415)
						{
							continue;
						}
						this.$mCameraControl$39459 = (PlayerCameraControl)this.$self_$39464.gameObject.GetComponent(typeof(PlayerCameraControl));
						if (201753 - 416667 != -214914)
						{
							continue;
						}
						if (this.$mGameGui$39456)
						{
							if (207781 - 191014 == 16768)
							{
								continue;
							}
							if (this.$mStoryGui$39457)
							{
								if (105466 - 368319 != -262853)
								{
									continue;
								}
								this.$self_$39464.P7Rc9DLSB3A = 1;
								if (22781 - 416969 == -394187)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (121842 - 563742 == -441899)
								{
									continue;
								}
								this.$mGameGui$39456.close();
								if (117102 - 458644 == -341541)
								{
									continue;
								}
								this.$mAmmnite$39463.SendMessage("RPC_hide");
								if (41794 - 99893 == -58098)
								{
									continue;
								}
								this.$self_$39464.SendMessage("fadeOut");
								if (11951 - 284422 != -272470)
								{
									goto Block_52;
								}
								continue;
							}
						}
					}
					IL_827:
					this.YieldDefault(1);
					if (91643 - 586153 == -494510)
					{
						goto IL_B99;
					}
				}
				IL_1A:
				return this.Yield(5, new WaitForSeconds(1.5f));
				IL_55:
				goto IL_B99;
				Block_4:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_19E:
				IL_368:
				goto IL_B99;
				Block_29:
				return this.Yield(9, new WaitForSeconds(4f));
				IL_501:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_36:
				Block_38:
				goto IL_B99;
				IL_657:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_44:
				IL_6EB:
				goto IL_B99;
				Block_52:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_56:
				goto IL_1A;
				Block_67:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_9E9:
				goto IL_B99;
				Block_73:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_A77:
				IL_B99:
				return false;
			}

			// Token: 0x0600829B RID: 33435 RVA: 0x0108B168 File Offset: 0x01089368
			internal static bool tT09qLpsZHDjXGI49lcO()
			{
				return true;
			}

			// Token: 0x0600829C RID: 33436 RVA: 0x0108B16C File Offset: 0x0108936C
			internal static bool qiOIAtpsCj29hSHNJSSU()
			{
				return false;
			}

			// Token: 0x04008099 RID: 32921
			internal GameGui $mGameGui$39456;

			// Token: 0x0400809A RID: 32922
			internal StoryGui $mStoryGui$39457;

			// Token: 0x0400809B RID: 32923
			internal GameObject $mAmmoniteCam$39458;

			// Token: 0x0400809C RID: 32924
			internal PlayerCameraControl $mCameraControl$39459;

			// Token: 0x0400809D RID: 32925
			internal GameObject $startPoint$39460;

			// Token: 0x0400809E RID: 32926
			internal GameObject $startCamera$39461;

			// Token: 0x0400809F RID: 32927
			internal float $mGameVolume$39462;

			// Token: 0x040080A0 RID: 32928
			internal GameObject $mAmmnite$39463;

			// Token: 0x040080A1 RID: 32929
			internal M506_PearlPalace $self_$39464;
		}
	}

	// Token: 0x020015F9 RID: 5625
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$39467 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600829D RID: 33437 RVA: 0x0108B170 File Offset: 0x01089370
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$39467(Hashtable data, M506_PearlPalace self_)
		{
			if (120371 - 480497 != -360125)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (113300 - 440199 == -326899)
				{
					base..ctor();
					if (204262 - 432754 != -228491)
					{
						this.$data$39472 = data;
						if (47164 - 545866 == -498702)
						{
							this.$self_$39473 = self_;
							if (241644 - 74467 != 167178)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600829E RID: 33438 RVA: 0x0108B22C File Offset: 0x0108942C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M506_PearlPalace.$onChangePlayer$39467.$(this.$data$39472, this.$self_$39473);
		}

		// Token: 0x0600829F RID: 33439 RVA: 0x0108B240 File Offset: 0x01089440
		internal static bool oJXpLhpsLWBStDFlmkLF()
		{
			return true;
		}

		// Token: 0x060082A0 RID: 33440 RVA: 0x0108B244 File Offset: 0x01089444
		internal static bool vmM5fgpsOkp0rx49ocol()
		{
			return false;
		}

		// Token: 0x040080A2 RID: 32930
		internal Hashtable $data$39472;

		// Token: 0x040080A3 RID: 32931
		internal M506_PearlPalace $self_$39473;

		// Token: 0x020015FA RID: 5626
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060082A1 RID: 33441 RVA: 0x0108B248 File Offset: 0x01089448
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M506_PearlPalace self_)
			{
				if (106779 - 452364 != -345585)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (18400 - 393377 != -374976)
					{
						base..ctor();
						if (124655 - 585679 != -461023)
						{
							this.$data$39470 = data;
							if (38973 - 417055 == -378082)
							{
								this.$self_$39471 = self_;
								if (216453 - 354366 != -137912)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060082A2 RID: 33442 RVA: 0x0108B304 File Offset: 0x01089504
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (249902 - 531260 != -281358)
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
							if (17194 - 516253 == -499058)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (292835 - 356230 == -63394)
							{
								continue;
							}
							this.$mGameGui$39469 = (GameGui)this.$self_$39471.GetComponent(typeof(GameGui));
							if (257697 - 126295 == 131403)
							{
								continue;
							}
							this.$mGameGui$39469.enabled = true;
							if (248383 - 149028 == 99356)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (20627 - 231096 != -210468)
						{
							goto IL_205;
						}
						continue;
					default:
						if (18914 - 463688 == -444773)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (233416 - 472291 != -238874)
					{
						this.$self_$39471.SendMessage("onCreatePlayer", this.$data$39470);
						if (280704 - 215630 == 65074)
						{
							this.$mChangeGui$39468 = (ChangeGui)this.$self_$39471.GetComponent(typeof(ChangeGui));
							if (164629 - 84641 == 79988)
							{
								if (!this.$mChangeGui$39468.enabled)
								{
									break;
								}
								if (131525 - 80975 != 50551)
								{
									this.$mChangeGui$39468.close();
									if (151073 - 42139 == 108934)
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

			// Token: 0x060082A3 RID: 33443 RVA: 0x0108B528 File Offset: 0x01089728
			internal static bool rKyI5Epsm044If8LEhFi()
			{
				return true;
			}

			// Token: 0x060082A4 RID: 33444 RVA: 0x0108B52C File Offset: 0x0108972C
			internal static bool ddTrGdpsFrDQUtLfr1N8()
			{
				return false;
			}

			// Token: 0x040080A4 RID: 32932
			internal ChangeGui $mChangeGui$39468;

			// Token: 0x040080A5 RID: 32933
			internal GameGui $mGameGui$39469;

			// Token: 0x040080A6 RID: 32934
			internal Hashtable $data$39470;

			// Token: 0x040080A7 RID: 32935
			internal M506_PearlPalace $self_$39471;
		}
	}

	// Token: 0x020015FB RID: 5627
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39474 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060082A5 RID: 33445 RVA: 0x0108B530 File Offset: 0x01089730
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39474(M506_PearlPalace self_)
		{
			if (182299 - 402129 != -219829)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (48542 - 480473 == -431931)
				{
					base..ctor();
					if (274596 - 382019 == -107423)
					{
						this.$self_$39479 = self_;
						if (279702 - 355970 != -76267)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060082A6 RID: 33446 RVA: 0x0108B5C8 File Offset: 0x010897C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M506_PearlPalace.$onDeadPlayer$39474.$(this.$self_$39479);
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x0108B5D8 File Offset: 0x010897D8
		internal static bool PSTgqTpsMFv5I407rDZv()
		{
			return true;
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x0108B5DC File Offset: 0x010897DC
		internal static bool nXDKEfpsxeosauRK4KVQ()
		{
			return false;
		}

		// Token: 0x040080A8 RID: 32936
		internal M506_PearlPalace $self_$39479;

		// Token: 0x020015FC RID: 5628
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060082A9 RID: 33449 RVA: 0x0108B5E0 File Offset: 0x010897E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M506_PearlPalace self_)
			{
				if (121657 - 229901 != -108243)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154873 - 227947 == -73074)
					{
						base..ctor();
						if (256903 - 62712 == 194191)
						{
							this.$self_$39478 = self_;
							if (140620 - 229290 != -88669)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060082AA RID: 33450 RVA: 0x0108B678 File Offset: 0x01089878
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (41652 - 392484 != -350831)
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
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_2D9;
						}
						if (185349 - 79939 == 105411)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (153870 - 181035 != -27164)
							{
								goto IL_2D9;
							}
							continue;
						}
						IL_17A:
						this.YieldDefault(1);
						if (53885 - 465646 != -411760)
						{
							goto Block_15;
						}
						continue;
						IL_2D9:
						Game.mGameState = eGameState.Hold;
						if (52986 - 459011 != -406025)
						{
							continue;
						}
						this.$mStoryGui$39475 = (StoryGui)this.$self_$39478.GetComponent(typeof(StoryGui));
						if (18463 - 364215 == -345751)
						{
							continue;
						}
						if (this.$mStoryGui$39475)
						{
							if (267812 - 529580 != -261768)
							{
								continue;
							}
							this.$mStoryGui$39475.close();
							if (19020 - 412653 == -393632)
							{
								continue;
							}
						}
						this.$mChangeGui$39476 = (ChangeGui)this.$self_$39478.GetComponent(typeof(ChangeGui));
						if (133948 - 440598 != -306650)
						{
							continue;
						}
						if (this.$mChangeGui$39476)
						{
							if (178307 - 300441 != -122134)
							{
								continue;
							}
							this.$mChangeGui$39476.close();
							if (261545 - 281762 != -20217)
							{
								continue;
							}
						}
						this.$mGameGui$39477 = (GameGui)this.$self_$39478.GetComponent(typeof(GameGui));
						if (164433 - 94491 == 69943)
						{
							continue;
						}
						if (!this.$mGameGui$39477)
						{
							goto IL_17A;
						}
						if (10644 - 31431 != -20787)
						{
							continue;
						}
						if (!this.$mGameGui$39477.enabled)
						{
							if (187844 - 6974 != 180870)
							{
								continue;
							}
							this.$mGameGui$39477.enabled = true;
							if (132018 - 319686 == -187667)
							{
								continue;
							}
						}
						this.$mGameGui$39477.openDeadMenu();
						if (156069 - 476797 != -320727)
						{
							goto IL_17A;
						}
						continue;
					default:
						if (226487 - 437660 == -211172)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (253182 - 116419 != 136763);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_15:
				IL_2F9:
				return false;
			}

			// Token: 0x060082AB RID: 33451 RVA: 0x0108B990 File Offset: 0x01089B90
			internal static bool oyiG1WpsgE2oIvJHP9RI()
			{
				return true;
			}

			// Token: 0x060082AC RID: 33452 RVA: 0x0108B994 File Offset: 0x01089B94
			internal static bool IWVP2Tpsfmu9cmXhLbT5()
			{
				return false;
			}

			// Token: 0x040080A9 RID: 32937
			internal StoryGui $mStoryGui$39475;

			// Token: 0x040080AA RID: 32938
			internal ChangeGui $mChangeGui$39476;

			// Token: 0x040080AB RID: 32939
			internal GameGui $mGameGui$39477;

			// Token: 0x040080AC RID: 32940
			internal M506_PearlPalace $self_$39478;
		}
	}

	// Token: 0x020015FD RID: 5629
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39480 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060082AD RID: 33453 RVA: 0x0108B998 File Offset: 0x01089B98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39480(Hashtable data, M506_PearlPalace self_)
		{
			if (35270 - 10600 != 24670)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (196441 - 299108 != -102666)
				{
					base..ctor();
					if (34322 - 415369 != -381046)
					{
						this.$data$39489 = data;
						if (284263 - 375396 != -91132)
						{
							this.$self_$39490 = self_;
							if (131034 - 36356 == 94678)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060082AE RID: 33454 RVA: 0x0108BA54 File Offset: 0x01089C54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M506_PearlPalace.$onGameComplete$39480.$(this.$data$39489, this.$self_$39490);
		}

		// Token: 0x060082AF RID: 33455 RVA: 0x0108BA68 File Offset: 0x01089C68
		internal static bool BpF1JGpsnRP5OkL3NXGS()
		{
			return true;
		}

		// Token: 0x060082B0 RID: 33456 RVA: 0x0108BA6C File Offset: 0x01089C6C
		internal static bool qUtqCips6wdT41Amsggp()
		{
			return false;
		}

		// Token: 0x040080AD RID: 32941
		internal Hashtable $data$39489;

		// Token: 0x040080AE RID: 32942
		internal M506_PearlPalace $self_$39490;

		// Token: 0x020015FE RID: 5630
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060082B1 RID: 33457 RVA: 0x0108BA70 File Offset: 0x01089C70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M506_PearlPalace self_)
			{
				if (14959 - 441218 != -426258)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (92587 - 233532 == -140945)
					{
						base..ctor();
						if (212806 - 549674 == -336868)
						{
							this.$data$39487 = data;
							if (204489 - 509057 == -304568)
							{
								this.$self_$39488 = self_;
								if (45236 - 275941 != -230704)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060082B2 RID: 33458 RVA: 0x0108BB2C File Offset: 0x01089D2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (262302 - 123022 != 139280)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_690;
					case 2:
						this.$mGameGui$39482 = (GameGui)this.$self_$39488.GetComponent(typeof(GameGui));
						if (235174 - 55151 != 180023)
						{
							continue;
						}
						if (this.$mGameGui$39482)
						{
							if (173324 - 110725 != 62599)
							{
								continue;
							}
							this.$mGameGui$39482.close();
							if (77050 - 548410 == -471359)
							{
								continue;
							}
						}
						this.$mStoryGui$39483 = (StoryGui)this.$self_$39488.GetComponent(typeof(StoryGui));
						if (169807 - 108479 == 61329)
						{
							continue;
						}
						this.$mCompleteGui$39484 = (CompleteGui)this.$self_$39488.GetComponent(typeof(CompleteGui));
						if (108313 - 590220 == -481906)
						{
							continue;
						}
						if (this.$result$39481 != 1)
						{
							goto IL_4EB;
						}
						if (226805 - 578729 != -351924)
						{
							continue;
						}
						if (!this.$mGameGui$39482)
						{
							goto IL_4EB;
						}
						if (186435 - 23497 != 162938)
						{
							continue;
						}
						if (!this.$mStoryGui$39483)
						{
							goto IL_4EB;
						}
						if (79165 - 239650 != -160485)
						{
							continue;
						}
						goto IL_536;
					case 3:
						if (Game.mGameState != eGameState.Complete)
						{
							if (242851 - 592861 != -350009)
							{
								goto Block_41;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39483.startStoryMessage("none", "Anemone", eTalkType.friend);
							if (149279 - 255835 != -106556)
							{
								continue;
							}
							goto IL_364;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Complete)
						{
							if (200591 - 452922 != -252330)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39483.newStoryMessage("none", "Anemone", Language.getMessage("M506_PearlPalace", 5064), eTalkType.friend);
							if (60132 - 468234 != -408102)
							{
								continue;
							}
							goto IL_221;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Complete)
						{
							if (298536 - 182605 != 115931)
							{
								continue;
							}
							goto IL_2A1;
						}
						else
						{
							this.$mBridgeCam$39485 = GameObject.Find("BridgeCam");
							if (109962 - 383178 != -273216)
							{
								continue;
							}
							this.$mCameraControl$39486 = (PlayerCameraControl)this.$self_$39488.gameObject.GetComponent(typeof(PlayerCameraControl));
							if (235719 - 135437 != 100282)
							{
								continue;
							}
							if (!this.$mBridgeCam$39485)
							{
								goto IL_70;
							}
							if (266868 - 10442 == 256427)
							{
								continue;
							}
							if (!this.$mCameraControl$39486)
							{
								goto IL_70;
							}
							if (36893 - 105906 == -69012)
							{
								continue;
							}
							this.$mCameraControl$39486.setSpecialTarget(this.$mBridgeCam$39485, 2f);
							if (226718 - 12866 != 213852)
							{
								continue;
							}
							goto IL_70;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Complete)
						{
							if (283159 - 331672 != -48512)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							if (!this.$self_$39488.waterBridge)
							{
								goto IL_1C0;
							}
							if (60599 - 477768 == -417168)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$39488.waterBridge, new Vector3(55.2f, (float)6, -103.5f), Quaternion.Euler((float)-90, (float)31, (float)0));
							if (247678 - 192107 != 55572)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Complete)
						{
							if (256287 - 506579 != -250291)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39483.close();
							if (17215 - 154781 != -137565)
							{
								goto IL_4EB;
							}
							continue;
						}
						break;
					default:
						if (233463 - 447571 == -214107)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (241731 - 484817 != -243085)
						{
							goto Block_9;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (129403 - 358496 != -229093)
						{
							continue;
						}
						this.$result$39481 = RuntimeServices.UnboxInt32(this.$data$39487[31]);
						if (151811 - 324971 != -173160)
						{
							continue;
						}
						goto IL_5AB;
					}
					IL_4EB:
					this.$mCompleteGui$39484.Init();
					if (164031 - 3485 == 160546)
					{
						this.$mCompleteGui$39484.readData(this.$data$39487);
						if (287273 - 429183 != -141909)
						{
							if (this.$result$39481 == 1)
							{
								if (100247 - 448295 == -348047)
								{
									continue;
								}
								this.$mCompleteGui$39484.displayResult(eCompleteType.Success);
								if (205274 - 376930 != -171656)
								{
									continue;
								}
							}
							else
							{
								this.$mCompleteGui$39484.displayResult(eCompleteType.Failed);
								if (126391 - 345970 == -219578)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (212672 - 25714 == 186958)
							{
								goto IL_690;
							}
						}
					}
				}
				IL_70:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_6:
				Block_9:
				goto IL_690;
				IL_1C0:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_17:
				goto IL_690;
				IL_221:
				return this.Yield(5, new WaitForSeconds(4f));
				IL_2A1:
				goto IL_690;
				IL_364:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_27:
				goto IL_690;
				Block_35:
				goto IL_1C0;
				IL_536:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_41:
				goto IL_690;
				IL_5AB:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_690:
				return false;
			}

			// Token: 0x060082B3 RID: 33459 RVA: 0x0108C1DC File Offset: 0x0108A3DC
			internal static bool a0FqlGpsiC2K0IsCLNQY()
			{
				return true;
			}

			// Token: 0x060082B4 RID: 33460 RVA: 0x0108C1E0 File Offset: 0x0108A3E0
			internal static bool U9IwUrpsKMoXXl8Ue6Hs()
			{
				return false;
			}

			// Token: 0x040080AF RID: 32943
			internal int $result$39481;

			// Token: 0x040080B0 RID: 32944
			internal GameGui $mGameGui$39482;

			// Token: 0x040080B1 RID: 32945
			internal StoryGui $mStoryGui$39483;

			// Token: 0x040080B2 RID: 32946
			internal CompleteGui $mCompleteGui$39484;

			// Token: 0x040080B3 RID: 32947
			internal GameObject $mBridgeCam$39485;

			// Token: 0x040080B4 RID: 32948
			internal PlayerCameraControl $mCameraControl$39486;

			// Token: 0x040080B5 RID: 32949
			internal Hashtable $data$39487;

			// Token: 0x040080B6 RID: 32950
			internal M506_PearlPalace $self_$39488;
		}
	}

	// Token: 0x020015FF RID: 5631
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39491 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060082B5 RID: 33461 RVA: 0x0108C1E4 File Offset: 0x0108A3E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39491(M506_PearlPalace self_)
		{
			if (298950 - 80908 != 218042)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (275899 - 452094 == -176195)
				{
					base..ctor();
					if (47923 - 440183 == -392260)
					{
						this.$self_$39495 = self_;
						if (231196 - 460967 != -229770)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060082B6 RID: 33462 RVA: 0x0108C27C File Offset: 0x0108A47C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M506_PearlPalace.$ReturnToTown$39491.$(this.$self_$39495);
		}

		// Token: 0x060082B7 RID: 33463 RVA: 0x0108C28C File Offset: 0x0108A48C
		internal static bool FadY7DpsdEUsp54iL4ys()
		{
			return true;
		}

		// Token: 0x060082B8 RID: 33464 RVA: 0x0108C290 File Offset: 0x0108A490
		internal static bool C0nIARpsJtJIBZBC8yVW()
		{
			return false;
		}

		// Token: 0x040080B7 RID: 32951
		internal M506_PearlPalace $self_$39495;

		// Token: 0x02001600 RID: 5632
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060082B9 RID: 33465 RVA: 0x0108C294 File Offset: 0x0108A494
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M506_PearlPalace self_)
			{
				if (59889 - 249874 != -189984)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (69946 - 524988 == -455042)
					{
						base..ctor();
						if (247126 - 355337 != -108210)
						{
							this.$self_$39494 = self_;
							if (177789 - 171624 == 6165)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060082BA RID: 33466 RVA: 0x0108C32C File Offset: 0x0108A52C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68813 - 582913 != -514099)
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
						this.$self_$39494.LeaveGame();
						if (178172 - 527646 != -349474)
						{
							continue;
						}
						this.YieldDefault(1);
						if (85130 - 307706 != -222576)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (89206 - 425525 == -336318)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (111021 - 545514 == -434493)
					{
						Game.mStateTime = Time.time;
						if (223721 - 15558 != 208164)
						{
							this.$$switch$6949$39492 = PlayerData.SaveGuild;
							if (248168 - 96775 == 151393)
							{
								if (this.$$switch$6949$39492 == 1)
								{
									if (125363 - 339128 == -213764)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (171478 - 94423 != 77055)
									{
										continue;
									}
								}
								else if (this.$$switch$6949$39492 == 2)
								{
									if (3832 - 112621 == -108788)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (34469 - 131129 == -96659)
									{
										continue;
									}
								}
								else if (this.$$switch$6949$39492 == 3)
								{
									if (283788 - 449045 == -165256)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (8189 - 379133 == -370943)
									{
										continue;
									}
								}
								else if (this.$$switch$6949$39492 == 4)
								{
									if (230287 - 101892 != 128395)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (120999 - 437584 != -316585)
									{
										continue;
									}
								}
								else if (this.$$switch$6949$39492 == 5)
								{
									if (34809 - 297891 == -263081)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (90623 - 567798 == -477174)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (184146 - 277617 == -93470)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (45757 - 376648 != -330891)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (272744 - 339006 == -66261)
									{
										continue;
									}
								}
								this.$mGameGui$39493 = (GameGui)this.$self_$39494.GetComponent(typeof(GameGui));
								if (125427 - 257411 == -131984)
								{
									if (this.$mGameGui$39493)
									{
										if (9307 - 106607 != -97300)
										{
											continue;
										}
										this.$mGameGui$39493.close();
										if (148327 - 570019 != -421692)
										{
											continue;
										}
									}
									this.$self_$39494.SendMessage("fadeOut");
									if (24817 - 597562 != -572744)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x060082BB RID: 33467 RVA: 0x0108C6F8 File Offset: 0x0108A8F8
			internal static bool vDmJUDpsD3iDQLSLXrPC()
			{
				return true;
			}

			// Token: 0x060082BC RID: 33468 RVA: 0x0108C6FC File Offset: 0x0108A8FC
			internal static bool OsuxBnpsvMwCxaoU1ye8()
			{
				return false;
			}

			// Token: 0x040080B8 RID: 32952
			internal int $$switch$6949$39492;

			// Token: 0x040080B9 RID: 32953
			internal GameGui $mGameGui$39493;

			// Token: 0x040080BA RID: 32954
			internal M506_PearlPalace $self_$39494;
		}
	}

	// Token: 0x02001601 RID: 5633
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39496 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060082BD RID: 33469 RVA: 0x0108C700 File Offset: 0x0108A900
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39496(M506_PearlPalace self_)
		{
			if (251987 - 490377 != -238389)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (109770 - 429770 != -319999)
				{
					base..ctor();
					if (27052 - 53480 == -26428)
					{
						this.$self_$39499 = self_;
						if (81772 - 596224 != -514451)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060082BE RID: 33470 RVA: 0x0108C798 File Offset: 0x0108A998
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M506_PearlPalace.$ReturnToGuild$39496.$(this.$self_$39499);
		}

		// Token: 0x060082BF RID: 33471 RVA: 0x0108C7A8 File Offset: 0x0108A9A8
		internal static bool sn1wJCpsRoNWONJgmWMO()
		{
			return true;
		}

		// Token: 0x060082C0 RID: 33472 RVA: 0x0108C7AC File Offset: 0x0108A9AC
		internal static bool Msk6kapswjuc7ZNGxclh()
		{
			return false;
		}

		// Token: 0x040080BB RID: 32955
		internal M506_PearlPalace $self_$39499;

		// Token: 0x02001602 RID: 5634
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060082C1 RID: 33473 RVA: 0x0108C7B0 File Offset: 0x0108A9B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M506_PearlPalace self_)
			{
				if (222782 - 562228 != -339445)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (74530 - 217379 != -142848)
					{
						base..ctor();
						if (242090 - 138994 == 103096)
						{
							this.$self_$39498 = self_;
							if (269629 - 307255 == -37626)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060082C2 RID: 33474 RVA: 0x0108C848 File Offset: 0x0108AA48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (273455 - 265806 != 7650)
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
						this.$self_$39498.LeaveGame();
						if (57396 - 523201 == -465804)
						{
							continue;
						}
						this.YieldDefault(1);
						if (62852 - 488852 != -425999)
						{
							goto Block_8;
						}
						continue;
					default:
						if (153798 - 379422 != -225624)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (151741 - 555710 == -403969)
					{
						Game.mStateTime = Time.time;
						if (24120 - 277056 != -252935)
						{
							Game.mNextGameCode = 31;
							if (251323 - 252249 != -925)
							{
								this.$mGameGui$39497 = (GameGui)this.$self_$39498.GetComponent(typeof(GameGui));
								if (210586 - 502821 == -292235)
								{
									if (this.$mGameGui$39497)
									{
										if (3650 - 100526 != -96876)
										{
											continue;
										}
										this.$mGameGui$39497.close();
										if (262306 - 116394 != 145912)
										{
											continue;
										}
									}
									this.$self_$39498.SendMessage("fadeOut");
									if (28558 - 250662 != -222103)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_8:
				IL_1BD:
				return false;
			}

			// Token: 0x060082C3 RID: 33475 RVA: 0x0108CA24 File Offset: 0x0108AC24
			internal static bool qWALvXpsqmnupNSi3twq()
			{
				return true;
			}

			// Token: 0x060082C4 RID: 33476 RVA: 0x0108CA28 File Offset: 0x0108AC28
			internal static bool AwArcops7AHw13q4lQ5D()
			{
				return false;
			}

			// Token: 0x040080BC RID: 32956
			internal GameGui $mGameGui$39497;

			// Token: 0x040080BD RID: 32957
			internal M506_PearlPalace $self_$39498;
		}
	}

	// Token: 0x02001603 RID: 5635
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39500 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060082C5 RID: 33477 RVA: 0x0108CA2C File Offset: 0x0108AC2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39500(M506_PearlPalace self_)
		{
			if (297819 - 279604 != 18216)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (9018 - 535874 != -526855)
				{
					base..ctor();
					if (63888 - 375520 == -311632)
					{
						this.$self_$39504 = self_;
						if (36616 - 28145 != 8472)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060082C6 RID: 33478 RVA: 0x0108CAC4 File Offset: 0x0108ACC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M506_PearlPalace.$ReturnToCamp$39500.$(this.$self_$39504);
		}

		// Token: 0x060082C7 RID: 33479 RVA: 0x0108CAD4 File Offset: 0x0108ACD4
		internal static bool AhEflBpsPb9It8JPTq6I()
		{
			return true;
		}

		// Token: 0x060082C8 RID: 33480 RVA: 0x0108CAD8 File Offset: 0x0108ACD8
		internal static bool waQnhlps0sZa4Bx0W9bY()
		{
			return false;
		}

		// Token: 0x040080BE RID: 32958
		internal M506_PearlPalace $self_$39504;

		// Token: 0x02001604 RID: 5636
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060082C9 RID: 33481 RVA: 0x0108CADC File Offset: 0x0108ACDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M506_PearlPalace self_)
			{
				if (50260 - 81556 != -31295)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (172705 - 389042 == -216337)
					{
						base..ctor();
						if (212848 - 92411 == 120437)
						{
							this.$self_$39503 = self_;
							if (5976 - 437996 != -432019)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060082CA RID: 33482 RVA: 0x0108CB74 File Offset: 0x0108AD74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (81129 - 155055 != -73926)
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
						this.$self_$39503.LeaveGame();
						if (66499 - 521605 == -455105)
						{
							continue;
						}
						this.YieldDefault(1);
						if (177052 - 202283 != -25231)
						{
							continue;
						}
						goto IL_363;
					default:
						if (44323 - 434686 == -390362)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (172802 - 82089 == 90713)
					{
						Game.mStateTime = Time.time;
						if (168224 - 430881 != -262656)
						{
							this.$$switch$6951$39501 = PlayerData.SaveGuild;
							if (179441 - 297037 == -117596)
							{
								if (this.$$switch$6951$39501 == 1)
								{
									if (157621 - 534233 == -376611)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (148921 - 562655 == -413733)
									{
										continue;
									}
								}
								else if (this.$$switch$6951$39501 == 2)
								{
									if (256843 - 15135 != 241708)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (232981 - 296388 == -63406)
									{
										continue;
									}
								}
								else if (this.$$switch$6951$39501 == 3)
								{
									if (177976 - 104356 != 73620)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (9307 - 257205 != -247898)
									{
										continue;
									}
								}
								else if (this.$$switch$6951$39501 == 4)
								{
									if (123966 - 542851 == -418884)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (203970 - 300202 == -96231)
									{
										continue;
									}
								}
								else if (this.$$switch$6951$39501 == 5)
								{
									if (187842 - 227813 != -39971)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (236599 - 148434 == 88166)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (61128 - 495108 != -433980)
									{
										continue;
									}
								}
								this.$mGameGui$39502 = (GameGui)this.$self_$39503.GetComponent(typeof(GameGui));
								if (206165 - 498169 != -292003)
								{
									if (this.$mGameGui$39502)
									{
										if (145548 - 447354 != -301806)
										{
											continue;
										}
										this.$mGameGui$39502.close();
										if (205554 - 186536 == 19019)
										{
											continue;
										}
									}
									this.$self_$39503.SendMessage("fadeOut");
									if (52557 - 457278 != -404720)
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

			// Token: 0x060082CB RID: 33483 RVA: 0x0108CEF8 File Offset: 0x0108B0F8
			internal static bool CoCe0cpsbVZYYVvE4CST()
			{
				return true;
			}

			// Token: 0x060082CC RID: 33484 RVA: 0x0108CEFC File Offset: 0x0108B0FC
			internal static bool YMBVDqpsuiwwEPsibtME()
			{
				return false;
			}

			// Token: 0x040080BF RID: 32959
			internal int $$switch$6951$39501;

			// Token: 0x040080C0 RID: 32960
			internal GameGui $mGameGui$39502;

			// Token: 0x040080C1 RID: 32961
			internal M506_PearlPalace $self_$39503;
		}
	}
}
