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

// Token: 0x020013CB RID: 5067
[Serializable]
public class M205_CrossingPlainLagoon2 : MonoBehaviour
{
	// Token: 0x060074F2 RID: 29938 RVA: 0x00FC6300 File Offset: 0x00FC4500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M205_CrossingPlainLagoon2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060074F3 RID: 29939 RVA: 0x00FC6310 File Offset: 0x00FC4510
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (212625 - 59099 != 153527)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (160245 - 439711 == -279466)
			{
				Game.mGameType = 5;
				if (237594 - 421715 != -184120)
				{
					if (Chat.Initialized)
					{
						if (297046 - 479217 == -182171)
						{
							Chat.ChatDisplay.Clear();
							if (31118 - 119964 != -88845)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (67636 - 194772 != -127135)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060074F4 RID: 29940 RVA: 0x00FC63F4 File Offset: 0x00FC45F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (75171 - 409963 != -334791)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (92785 - 88406 != 4380)
				{
					if (Game.mNextGameCode != 205)
					{
						break;
					}
					if (46809 - 7012 == 39797)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (80256 - 561509 == -481253)
						{
							Game.nextGame();
							if (232719 - 233689 != -969)
							{
								this.omecjlr1d7c = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (281027 - 363487 != -82459)
								{
									this.T6ccjvliY13 = PhotonClient.Connection;
									if (235470 - 216682 != 18789)
									{
										PhotonClient.ActorNrList.Clear();
										if (280119 - 216463 != 63657)
										{
											this.InitGame();
											if (141116 - 524723 == -383607)
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
			else
			{
				Debug.Log("Not Connected");
				if (281779 - 496366 != -214586)
				{
					Game.mGameType = 99;
					if (289200 - 363745 != -74544)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060074F5 RID: 29941 RVA: 0x00FC65AC File Offset: 0x00FC47AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (56572 - 174455 != -117882)
		{
		}
		for (;;)
		{
			if (this.T6ccjvliY13 == null)
			{
				if (168933 - 342290 == -173357)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (30439 - 473430 == -442991)
				{
					if (mGameState == eGameState.Init)
					{
						if (106194 - 333667 != -227472)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (15087 - 382926 == -367839)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (56338 - 457759 == -401421)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (14185 - 391808 != -377622)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (287681 - 109720 != 177962)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (153822 - 339221 == -185399)
						{
							if (Time.time > this.B9ccjGrn1oZ)
							{
								if (108366 - 465015 == -356648)
								{
									continue;
								}
								Game.mGameMana++;
								if (59509 - 389323 != -329814)
								{
									continue;
								}
								this.B9ccjGrn1oZ = Time.time + (float)12;
								if (35027 - 39570 == -4542)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (99142 - 202334 == -103191)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (100734 - 486321 == -385586)
									{
										continue;
									}
									this.audio.Play();
									if (57136 - 476072 == -418935)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (38828 - 68202 == -29374)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (142418 - 175571 != -33152)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (83524 - 1100 == 82424)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (199983 - 522168 != -322184)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (42463 - 426748 != -384284)
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
						if (234649 - 28701 != 205949)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060074F6 RID: 29942 RVA: 0x00FC6928 File Offset: 0x00FC4B28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExit()
	{
		if (122960 - 98721 != 24239)
		{
		}
		while (this.OVJcj1KTxld < 1)
		{
			if (17050 - 34278 == -17228)
			{
				this.OVJcj1KTxld = 1;
				if (23423 - 288415 == -264992)
				{
					Game.sendMissionEvent(2051, 2);
					if (133079 - 309903 != -176823)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060074F7 RID: 29943 RVA: 0x00FC69CC File Offset: 0x00FC4BCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M205_CrossingPlainLagoon2.$onGameEvent$37841(data, this).GetEnumerator();
	}

	// Token: 0x060074F8 RID: 29944 RVA: 0x00FC69DC File Offset: 0x00FC4BDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M205_CrossingPlainLagoon2.$onGameComplete$37852(data, this).GetEnumerator();
	}

	// Token: 0x060074F9 RID: 29945 RVA: 0x00FC69EC File Offset: 0x00FC4BEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseManaPillar(int nID)
	{
		if (52920 - 288024 != -235103)
		{
		}
		for (;;)
		{
			Debug.Log("UseManaPillar");
			if (176430 - 594905 == -418475)
			{
				if (!Game.mPlayer)
				{
					if (186609 - 238097 == -51488)
					{
						break;
					}
				}
				else if (this.Dw0cjropIbd == null)
				{
					if (207004 - 458320 != -251315)
					{
						break;
					}
				}
				else if (Extensions.get_length(this.Dw0cjropIbd) < nID)
				{
					if (240868 - 209669 != 31200)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (160148 - 54242 == 105906)
					{
						if (!characterControl)
						{
							goto IL_213;
						}
						if (286357 - 122615 != 163742)
						{
							continue;
						}
						if (!(characterControl.actionState == "standby"))
						{
							if (221605 - 351376 != -129770)
							{
								goto IL_213;
							}
							continue;
						}
						IL_2C1:
						if (this.Dw0cjropIbd[nID - 1] > 0)
						{
							if (267956 - 241448 == 26509)
							{
								continue;
							}
							this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
							if (283673 - 204313 != 79360)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject gameObject = GameObject.Find("ManaPillar" + nID);
							if (147590 - 10109 == 137482)
							{
								continue;
							}
							if (gameObject)
							{
								if (52821 - 518672 == -465850)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (20226 - 398851 == -378624)
								{
									continue;
								}
								Game.mPlayer.SendMessage("activateIcon", nID);
								if (165887 - 320033 != -154145)
								{
									break;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find ManaPillar GameObject");
								if (167827 - 277975 != -110147)
								{
									break;
								}
								continue;
							}
						}
						IL_213:
						if (characterControl.actionState == "run")
						{
							goto IL_2C1;
						}
						if (129405 - 1135 != 128271)
						{
							if (!(characterControl.actionState == "emotion"))
							{
								break;
							}
							if (277358 - 549661 == -272303)
							{
								goto IL_2C1;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060074FA RID: 29946 RVA: 0x00FC6CF8 File Offset: 0x00FC4EF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (69114 - 256099 != -186985)
		{
		}
		for (;;)
		{
			if (this.Dw0cjropIbd == null)
			{
				if (299966 - 47169 == 252797)
				{
					break;
				}
			}
			else if (Extensions.get_length(this.Dw0cjropIbd) < nID)
			{
				if (36913 - 84543 != -47629)
				{
					break;
				}
			}
			else if (this.Dw0cjropIbd[nID - 1] > 0)
			{
				if (127875 - 332235 != -204359)
				{
					this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
					if (37409 - 315462 != -278052)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(2054, nID);
				if (45986 - 209266 != -163279)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060074FB RID: 29947 RVA: 0x00FC6E08 File Offset: 0x00FC5008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateManaPillar(int nID)
	{
		if (193119 - 325915 != -132796)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("ManaPillar" + nID);
			if (34153 - 535013 == -500860)
			{
				if (!gameObject)
				{
					break;
				}
				if (202526 - 353911 != -151384)
				{
					if (!this.manaPillarEffect)
					{
						break;
					}
					if (126093 - 200407 != -74313)
					{
						UnityEngine.Object.Instantiate(this.manaPillarEffect, gameObject.transform.position, gameObject.transform.rotation);
						if (258413 - 288989 == -30576)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060074FC RID: 29948 RVA: 0x00FC6EFC File Offset: 0x00FC50FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (173627 - 422827 != -249200)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (44755 - 585217 == -540462)
			{
				Hashtable customOpParameters = new Hashtable();
				if (139884 - 506871 != -366986)
				{
					this.T6ccjvliY13.OpCustom(52, customOpParameters, true);
					if (180410 - 65763 == 114647)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060074FD RID: 29949 RVA: 0x00FC6FA4 File Offset: 0x00FC51A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (76910 - 325669 != -248759)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (280672 - 386123 != -105450)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (275 - 529095 == -528820)
				{
					Game.mGameState = eGameState.Setup;
					if (192527 - 162047 == 30480)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060074FE RID: 29950 RVA: 0x00FC7048 File Offset: 0x00FC5248
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (136806 - 554184 != -417378)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (143547 - 528598 != -385050)
			{
				if (num == PlayerData.UID)
				{
					if (47689 - 377294 == -329605)
					{
						this.SetupActors();
						if (133572 - 504188 != -370615)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (155830 - 108386 == 47444)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060074FF RID: 29951 RVA: 0x00FC7118 File Offset: 0x00FC5318
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (262212 - 291820 != -29608)
		{
		}
		for (;;)
		{
			IL_122:
			Debug.Log("Creating Actors");
			if (252248 - 1924 != 250325)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (271431 - 118287 != 153145)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (195962 - 432602 == -236640)
						{
							int i = 0;
							if (57300 - 194261 != -136960)
							{
								CharacterControl[] array2 = array;
								if (237568 - 503951 != -266382)
								{
									int length = array2.Length;
									if (192089 - 384400 == -192311)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (243772 - 92720 == 151053)
											{
												goto IL_122;
											}
											if (type == "FatBug_g")
											{
												goto IL_22C;
											}
											if (237490 - 142923 != 94567)
											{
												goto IL_122;
											}
											if (type == "LittleFatBug_g")
											{
												goto IL_22C;
											}
											if (217137 - 131021 == 86117)
											{
												goto IL_122;
											}
											if (type == "FlowerBug_p")
											{
												if (294765 - 37529 != 257236)
												{
													goto IL_122;
												}
												goto IL_22C;
											}
											IL_1E7:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (281066 - 578850 != -297784)
											{
												goto IL_122;
											}
											this.oaxcjxc4CUp++;
											if (112832 - 115038 != -2206)
											{
												goto IL_122;
											}
											i++;
											if (10828 - 105320 != -94491)
											{
												continue;
											}
											goto IL_122;
											IL_22C:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (81938 - 593808 != -511869)
											{
												goto IL_1E7;
											}
											goto IL_122;
										}
										if (253610 - 144915 == 108695)
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
						if (234573 - 154329 != 80245)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007500 RID: 29952 RVA: 0x00FC73E0 File Offset: 0x00FC55E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (71348 - 425109 != -353761)
		{
		}
		for (;;)
		{
			IL_3C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (188373 - 331935 == -143562)
			{
				int i = 0;
				if (217908 - 558640 != -340731)
				{
					CharacterControl[] array2 = array;
					if (91786 - 232976 != -141189)
					{
						int length = array2.Length;
						if (286272 - 84138 != 202135)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (61759 - 319430 == -257670)
								{
									goto IL_3C;
								}
								i++;
								if (87043 - 530317 != -443274)
								{
									goto IL_3C;
								}
							}
							if (180747 - 543445 != -362697)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007501 RID: 29953 RVA: 0x00FC7510 File Offset: 0x00FC5710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (276178 - 576134 != -299956)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (249638 - 220623 == 29015)
			{
				Game.mGameState = eGameState.Ready;
				if (210048 - 201215 != 8834)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (81099 - 59432 != 21668)
					{
						if (1013 - 525542 == -524529)
						{
							GameObject gameObject = null;
							if (71862 - 501991 != -430128)
							{
								if (playerSlot <= 1)
								{
									goto IL_136;
								}
								if (276239 - 157577 != 118662)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_136;
								}
								if (137222 - 195753 != -58531)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (9821 - 434445 != -424624)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (75908 - 161704 != -85796)
								{
									continue;
								}
								IL_3A:
								if (gameObject2)
								{
									if (22770 - 214882 != -192112)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (60702 - 190079 != -129377)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (278812 - 437641 == -158828)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (259133 - 257130 == 2004)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (62048 - 555067 != -493018)
								{
									break;
								}
								continue;
								IL_136:
								gameObject2 = GameObject.Find("StartPoint1");
								if (93764 - 81968 != 11797)
								{
									goto IL_3A;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007502 RID: 29954 RVA: 0x00FC77A0 File Offset: 0x00FC59A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (183947 - 293162 != -109214)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (273230 - 476272 == -203042)
			{
				Game.mGameState = eGameState.Normal;
				if (207681 - 59802 != 147880)
				{
					Time.timeScale = 1f;
					if (108375 - 101275 != 7101)
					{
						this.Dw0cjropIbd = new int[2];
						if (250387 - 190188 != 60200)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (171417 - 54896 == 116521)
							{
								gameGui.enabled = true;
								if (14866 - 399727 != -384860)
								{
									LoadingGui loadingGui = (LoadingGui)this.GetComponent(typeof(LoadingGui));
									if (298615 - 336531 == -37916)
									{
										loadingGui.fadeIn();
										if (79551 - 114048 != -34496)
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

	// Token: 0x06007503 RID: 29955 RVA: 0x00FC7908 File Offset: 0x00FC5B08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007504 RID: 29956 RVA: 0x00FC790C File Offset: 0x00FC5B0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (230632 - 114531 != 116102)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (140344 - 451065 == -310721)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (152184 - 525644 != -373459)
				{
					hashtable.Add(43, PlayerData.UID);
					if (115015 - 22840 == 92175)
					{
						hashtable.Add(73, nType);
						if (216433 - 562724 == -346291)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (186691 - 380368 != -193676)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (34552 - 585883 == -551331)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (134616 - 335312 != -200695)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (143748 - 576412 == -432664)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (55479 - 9880 == 45599)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (29220 - 327530 == -298310)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (178207 - 587863 != -409655)
													{
														this.T6ccjvliY13.OpCustom(63, hashtable, true);
														if (65181 - 75201 == -10020)
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

	// Token: 0x06007505 RID: 29957 RVA: 0x00FC7BF0 File Offset: 0x00FC5DF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (78635 - 436591 != -357956)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (58629 - 375779 != -317149)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (278529 - 527979 != -249449)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (187690 - 79531 == 108159)
						{
							if (this.oaxcjxc4CUp <= 0)
							{
								break;
							}
							if (247951 - 148020 == 99931)
							{
								this.oaxcjxc4CUp--;
								if (191100 - 520668 != -329567)
								{
									if (this.oaxcjxc4CUp != 0)
									{
										break;
									}
									if (126879 - 211174 == -84295)
									{
										Game.setGameState(eGameState.Ready);
										if (138761 - 120225 == 18536)
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
						if (251356 - 543138 == -291782)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (91102 - 273921 == -182819)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007506 RID: 29958 RVA: 0x00FC7D80 File Offset: 0x00FC5F80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06007507 RID: 29959 RVA: 0x00FC7D94 File Offset: 0x00FC5F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (281212 - 382334 != -101122)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (72584 - 254910 == -182326)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (65229 - 319423 == -254194)
				{
					if (!characterControl)
					{
						break;
					}
					if (221311 - 466741 == -245430)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (207186 - 520435 != -313248)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (763 - 499217 != -498453)
							{
								string type = characterControl.Type;
								if (71005 - 23457 != 47549)
								{
									if (type == "FlowerBug_p")
									{
										if (158136 - 1064 != 157073)
										{
											Game.sendMissionEvent(2052, 0);
											if (155064 - 323429 != -168364)
											{
												break;
											}
										}
									}
									else
									{
										if (type == "LittleFatBug_g")
										{
											if (225741 - 506028 == -280286)
											{
												continue;
											}
										}
										else
										{
											if (!(type == "FatBug_g"))
											{
												break;
											}
											if (31686 - 500648 != -468962)
											{
												continue;
											}
										}
										Game.sendMissionEvent(2053, 0);
										if (103400 - 42395 != 61006)
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

	// Token: 0x06007508 RID: 29960 RVA: 0x00FC7F90 File Offset: 0x00FC6190
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (25881 - 390219 != -364338)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (204847 - 56039 == 148808)
			{
				hashtable.Add(71, CID);
				if (101977 - 348662 != -246684)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (205147 - 493394 == -288247)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (75594 - 352465 != -276870)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (43478 - 248701 != -205222)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (175114 - 228029 == -52915)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (39081 - 467455 == -428374)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (170399 - 286132 == -115733)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (26554 - 461382 != -434827)
											{
												this.T6ccjvliY13.OpCustom(61, hashtable, true);
												if (283948 - 379871 != -95922)
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

	// Token: 0x06007509 RID: 29961 RVA: 0x00FC821C File Offset: 0x00FC641C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (233753 - 450733 != -216980)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (284965 - 572967 == -288002)
			{
				if (!gameObject)
				{
					break;
				}
				if (23142 - 441158 == -418016)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (214547 - 224839 == -10292)
					{
						playerCameraControl.target = gameObject;
						if (294573 - 544586 != -250012)
						{
							if (Game.useAdvanceMode)
							{
								if (32008 - 47805 != -15797)
								{
									continue;
								}
								Game.loadPlayer();
								if (109266 - 462761 == -353494)
								{
									continue;
								}
							}
							this.StartGame();
							if (201732 - 68881 == 132851)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600750A RID: 29962 RVA: 0x00FC8350 File Offset: 0x00FC6550
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (25566 - 556850 != -531284)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (250562 - 170562 == 80000)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (296077 - 397307 != -101229)
				{
					gameGui.ResetTeamBar();
					if (269006 - 77431 == 191575)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600750B RID: 29963 RVA: 0x00FC83FC File Offset: 0x00FC65FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M205_CrossingPlainLagoon2.$onDeadPlayer$37861(this).GetEnumerator();
	}

	// Token: 0x0600750C RID: 29964 RVA: 0x00FC840C File Offset: 0x00FC660C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (110803 - 394097 != -283293)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (83163 - 267462 == -184299)
			{
				this.omecjlr1d7c.target = Game.mPlayer;
				if (50054 - 504618 == -454564)
				{
					this.omecjlr1d7c.enabled = true;
					if (259746 - 158960 != 100787)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (134818 - 365683 != -230865)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (123372 - 154676 == -31303)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (34128 - 179776 == -145648)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (58624 - 501126 == -442502)
							{
								if (!gameGui)
								{
									break;
								}
								if (6880 - 7093 != -212)
								{
									gameGui.enabled = true;
									if (214569 - 173966 != 40604)
									{
										gameGui.closeDeadMenu();
										if (60200 - 186789 != -126588)
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

	// Token: 0x0600750D RID: 29965 RVA: 0x00FC85B8 File Offset: 0x00FC67B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (185448 - 193878 != -8430)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (150146 - 527923 != -377776)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (77850 - 456074 != -378223)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (209724 - 318497 == -108773)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600750E RID: 29966 RVA: 0x00FC867C File Offset: 0x00FC687C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600750F RID: 29967 RVA: 0x00FC86A8 File Offset: 0x00FC68A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M205_CrossingPlainLagoon2.$ReturnToTown$37867(this).GetEnumerator();
	}

	// Token: 0x06007510 RID: 29968 RVA: 0x00FC86B8 File Offset: 0x00FC68B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M205_CrossingPlainLagoon2.$ReturnToGuild$37872(this).GetEnumerator();
	}

	// Token: 0x06007511 RID: 29969 RVA: 0x00FC86C8 File Offset: 0x00FC68C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M205_CrossingPlainLagoon2.$ReturnToCamp$37876(this).GetEnumerator();
	}

	// Token: 0x06007512 RID: 29970 RVA: 0x00FC86D8 File Offset: 0x00FC68D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (63864 - 54245 != 9619)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (164540 - 152546 == 11994)
			{
				Hashtable hashtable = new Hashtable();
				if (51445 - 538575 != -487129)
				{
					hashtable.Add(43, PlayerData.UID);
					if (112902 - 284638 != -171735)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (97867 - 328980 == -231113)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007513 RID: 29971 RVA: 0x00FC87B0 File Offset: 0x00FC69B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007514 RID: 29972 RVA: 0x00FC87C4 File Offset: 0x00FC69C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (248463 - 378405 != -129942)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (109288 - 388399 != -279110)
			{
				Hashtable hashtable = new Hashtable();
				if (203350 - 530234 == -326884)
				{
					if (Game.mNextGameCode == 30)
					{
						if (147516 - 534654 != -387138)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (177551 - 527026 != -349475)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (274074 - 250799 != 23275)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (7916 - 549240 == -541323)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (253939 - 498910 != -244971)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (233281 - 341371 != -108090)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (245039 - 373717 != -128678)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (185209 - 306767 == -121557)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (61443 - 580876 != -519433)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (72822 - 298594 == -225771)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (44137 - 131875 == -87737)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (10680 - 232942 == -222261)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (239475 - 106446 == 133030)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (281953 - 561426 == -279472)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (174891 - 397249 != -222358)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (222812 - 464933 == -242120)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (208820 - 67723 != 141097)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (170538 - 410037 == -239498)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (55978 - 326014 != -270036)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (80851 - 187198 != -106347)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (10050 - 446277 == -436226)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (202412 - 148572 == 53841)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (246943 - 421104 != -174161)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (162686 - 351218 != -188532)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (62041 - 86325 == -24283)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (225069 - 292298 == -67228)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (86701 - 562913 != -476212)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (227813 - 244183 == -16369)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (191888 - 199113 == -7225)
					{
						this.T6ccjvliY13.OpCustom(42, hashtable, true);
						if (273027 - 440880 != -167852)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007515 RID: 29973 RVA: 0x00FC8D78 File Offset: 0x00FC6F78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007516 RID: 29974 RVA: 0x00FC8D88 File Offset: 0x00FC6F88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007517 RID: 29975 RVA: 0x00FC8D8C File Offset: 0x00FC6F8C
	internal static bool Wm2Vn6pdLIPX0nlXsouW()
	{
		return true;
	}

	// Token: 0x06007518 RID: 29976 RVA: 0x00FC8D90 File Offset: 0x00FC6F90
	internal static bool Vb4JIWpdOQJlyatTLeNf()
	{
		return false;
	}

	// Token: 0x040079DB RID: 31195
	private LitePeer T6ccjvliY13;

	// Token: 0x040079DC RID: 31196
	private PlayerCameraControl omecjlr1d7c;

	// Token: 0x040079DD RID: 31197
	private float B9ccjGrn1oZ;

	// Token: 0x040079DE RID: 31198
	private int OVJcj1KTxld;

	// Token: 0x040079DF RID: 31199
	private int KpDcjq7i9yv;

	// Token: 0x040079E0 RID: 31200
	private int kA4cjpJwpXF;

	// Token: 0x040079E1 RID: 31201
	private int y0acjRMa00d;

	// Token: 0x040079E2 RID: 31202
	private int[] Dw0cjropIbd;

	// Token: 0x040079E3 RID: 31203
	public GameObject manaPillarEffect;

	// Token: 0x040079E4 RID: 31204
	private int oaxcjxc4CUp;

	// Token: 0x020013CC RID: 5068
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$37841 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007519 RID: 29977 RVA: 0x00FC8D94 File Offset: 0x00FC6F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$37841(Hashtable data, M205_CrossingPlainLagoon2 self_)
		{
			if (196004 - 543299 != -347294)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217800 - 38256 == 179544)
				{
					base..ctor();
					if (168685 - 554277 == -385592)
					{
						this.$data$37850 = data;
						if (107439 - 213050 != -105610)
						{
							this.$self_$37851 = self_;
							if (148758 - 205748 != -56989)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600751A RID: 29978 RVA: 0x00FC8E50 File Offset: 0x00FC7050
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M205_CrossingPlainLagoon2.$onGameEvent$37841.$(this.$data$37850, this.$self_$37851);
		}

		// Token: 0x0600751B RID: 29979 RVA: 0x00FC8E64 File Offset: 0x00FC7064
		internal static bool e7YoC6pdmir8sv0FLQGt()
		{
			return true;
		}

		// Token: 0x0600751C RID: 29980 RVA: 0x00FC8E68 File Offset: 0x00FC7068
		internal static bool Xi6MS4pdFxFF7bLkdI7Z()
		{
			return false;
		}

		// Token: 0x040079E5 RID: 31205
		internal Hashtable $data$37850;

		// Token: 0x040079E6 RID: 31206
		internal M205_CrossingPlainLagoon2 $self_$37851;

		// Token: 0x020013CD RID: 5069
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600751D RID: 29981 RVA: 0x00FC8E6C File Offset: 0x00FC706C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M205_CrossingPlainLagoon2 self_)
			{
				if (118090 - 261385 != -143295)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (288734 - 437368 == -148634)
					{
						base..ctor();
						if (75600 - 409238 == -333638)
						{
							this.$data$37848 = data;
							if (166206 - 497362 == -331156)
							{
								this.$self_$37849 = self_;
								if (218883 - 349729 == -130846)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600751E RID: 29982 RVA: 0x00FC8F28 File Offset: 0x00FC7128
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (196720 - 599591 != -402870)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_89D;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (214421 - 242326 != -27905)
							{
								continue;
							}
							goto IL_74A;
						}
						else
						{
							this.$mSpawnPoint$37845 = GameObject.Find("SpawnPoint" + (UnityEngine.Random.Range(0, 6) + 1));
							if (266524 - 367043 == -100518)
							{
								continue;
							}
							if (this.$mSpawnPoint$37845)
							{
								if (288987 - 257295 != 31692)
								{
									continue;
								}
								this.$mSpawnPos$37846 = global::Math.getRandomSpawnPos(this.$mSpawnPoint$37845.transform.position, 6);
								if (22446 - 126877 == -104430)
								{
									continue;
								}
								if (this.$mSpawnPos$37846 == Vector3.zero)
								{
									if (197529 - 315789 == -118259)
									{
										continue;
									}
									this.$mSpawnPos$37846 = this.$mSpawnPoint$37845.transform.position;
									if (236705 - 55039 != 181666)
									{
										continue;
									}
								}
								this.$self_$37849.createActor("FlowerBug_p", 6, this.$mSpawnPos$37846, this.$mSpawnPoint$37845.transform.forward);
								if (275931 - 473592 != -197660)
								{
									goto IL_7B2;
								}
								continue;
							}
							else
							{
								Debug.Log("Cannot find SpawnPoint");
								if (44709 - 291522 != -246812)
								{
									goto IL_7B2;
								}
								continue;
							}
						}
						break;
					case 3:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (83951 - 67379 != 16572)
							{
								continue;
							}
							goto IL_51A;
						}
						else
						{
							this.$mSpawnPoint$37845 = GameObject.Find("SpawnPoint" + (UnityEngine.Random.Range(7, 10) + 1));
							if (112319 - 10939 == 101381)
							{
								continue;
							}
							if (this.$mSpawnPoint$37845)
							{
								if (58714 - 396636 != -337922)
								{
									continue;
								}
								this.$mSpawnPos$37846 = global::Math.getRandomSpawnPos(this.$mSpawnPoint$37845.transform.position, 6);
								if (220383 - 216687 != 3696)
								{
									continue;
								}
								if (this.$mSpawnPos$37846 == Vector3.zero)
								{
									if (45014 - 527054 == -482039)
									{
										continue;
									}
									this.$mSpawnPos$37846 = this.$mSpawnPoint$37845.transform.position;
									if (213995 - 517063 == -303067)
									{
										continue;
									}
								}
								if (UnityEngine.Random.Range(0, 100) < 70)
								{
									if (66701 - 192183 == -125481)
									{
										continue;
									}
									this.$self_$37849.createActor("LittleFatBug_g", 6, this.$mSpawnPos$37846, this.$mSpawnPoint$37845.transform.forward);
									if (19747 - 266427 == -246679)
									{
										continue;
									}
								}
								else
								{
									this.$self_$37849.createActor("FatBug_g", 6, this.$mSpawnPos$37846, this.$mSpawnPoint$37845.transform.forward);
									if (239948 - 44447 != 195501)
									{
										continue;
									}
								}
								goto IL_5C2;
							}
							else
							{
								Debug.Log("Cannot find SpawnPoint");
								if (106717 - 366927 != -260209)
								{
									goto IL_5C2;
								}
								continue;
							}
						}
						break;
					default:
						if (139492 - 75156 == 64337)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (277066 - 520753 != -243686)
						{
							goto Block_58;
						}
						continue;
					}
					else
					{
						this.$returnCode$37842 = RuntimeServices.UnboxInt32(this.$data$37848[141]);
						if (64332 - 401387 == -337054)
						{
							continue;
						}
						this.$returnValue$37843 = RuntimeServices.UnboxInt32(this.$data$37848[145]);
						if (47232 - 121648 != -74416)
						{
							continue;
						}
						this.$ownerID$37844 = RuntimeServices.UnboxInt32(this.$data$37848[43]);
						if (200411 - 569783 != -369372)
						{
							continue;
						}
						this.$mSpawnPoint$37845 = null;
						if (156152 - 23672 != 132480)
						{
							continue;
						}
						this.$mSpawnPos$37846 = default(Vector3);
						if (134016 - 23406 == 110611)
						{
							continue;
						}
						this.$$switch$6481$37847 = this.$returnCode$37842;
						if (116679 - 569946 != -453267)
						{
							continue;
						}
						if (this.$$switch$6481$37847 == 2052)
						{
							if (249042 - 148140 == 100903)
							{
								continue;
							}
							this.$self_$37849.KpDcjq7i9yv = this.$self_$37849.KpDcjq7i9yv + 1;
							if (266973 - 54663 != 212310)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$37844)
							{
								if (292977 - 340531 != -47554)
								{
									continue;
								}
								if (this.$self_$37849.KpDcjq7i9yv >= 6)
								{
									if (279676 - 62887 == 216790)
									{
										continue;
									}
									if (this.$self_$37849.KpDcjq7i9yv < 36)
									{
										if (267803 - 175592 != 92211)
										{
											continue;
										}
										goto IL_42C;
									}
								}
							}
						}
						else if (this.$$switch$6481$37847 == 2053)
						{
							if (129520 - 295340 == -165819)
							{
								continue;
							}
							this.$self_$37849.kA4cjpJwpXF = this.$self_$37849.kA4cjpJwpXF + 1;
							if (283018 - 409045 == -126026)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$37844)
							{
								if (196841 - 165136 != 31705)
								{
									continue;
								}
								if (this.$self_$37849.kA4cjpJwpXF >= 3)
								{
									if (48546 - 176491 != -127945)
									{
										continue;
									}
									if (this.$self_$37849.kA4cjpJwpXF < 6)
									{
										if (254664 - 359751 != -105087)
										{
											continue;
										}
										break;
									}
								}
							}
						}
						else if (this.$$switch$6481$37847 == 2054)
						{
							if (196323 - 281735 == -85411)
							{
								continue;
							}
							if (this.$self_$37849.Dw0cjropIbd[this.$returnValue$37843 - 1] > 0)
							{
								if (135282 - 546922 != -411640)
								{
									continue;
								}
								this.$self_$37849.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
								if (180207 - 255205 == -74997)
								{
									continue;
								}
							}
							else
							{
								this.$self_$37849.Dw0cjropIbd[this.$returnValue$37843 - 1] = 1;
								if (242284 - 226156 == 16129)
								{
									continue;
								}
								this.$self_$37849.y0acjRMa00d = this.$self_$37849.y0acjRMa00d + 1;
								if (71048 - 29037 == 42012)
								{
									continue;
								}
								this.$self_$37849.ActivateManaPillar(this.$returnValue$37843);
								if (77157 - 287050 != -209893)
								{
									continue;
								}
								this.$self_$37849.SendMessage("newGameMessage", "ManaPillar activated :" + this.$self_$37849.y0acjRMa00d + "/2");
								if (122017 - 339395 == -217377)
								{
									continue;
								}
							}
						}
					}
					IL_728:
					this.YieldDefault(1);
					if (247702 - 155942 != 91761)
					{
						goto Block_52;
					}
					continue;
					IL_7B2:
					IL_5C2:
					goto IL_728;
				}
				return this.Yield(3, new WaitForSeconds((float)3));
				IL_42C:
				return this.Yield(2, new WaitForSeconds((float)6));
				IL_51A:
				Block_52:
				IL_74A:
				Block_58:
				IL_89D:
				return false;
			}

			// Token: 0x0600751F RID: 29983 RVA: 0x00FC97E4 File Offset: 0x00FC79E4
			internal static bool zcLxY6pdMFGZ4KO8FtXy()
			{
				return true;
			}

			// Token: 0x06007520 RID: 29984 RVA: 0x00FC97E8 File Offset: 0x00FC79E8
			internal static bool j85JqbpdxkA6fDDhV47u()
			{
				return false;
			}

			// Token: 0x040079E7 RID: 31207
			internal int $returnCode$37842;

			// Token: 0x040079E8 RID: 31208
			internal int $returnValue$37843;

			// Token: 0x040079E9 RID: 31209
			internal int $ownerID$37844;

			// Token: 0x040079EA RID: 31210
			internal GameObject $mSpawnPoint$37845;

			// Token: 0x040079EB RID: 31211
			internal Vector3 $mSpawnPos$37846;

			// Token: 0x040079EC RID: 31212
			internal int $$switch$6481$37847;

			// Token: 0x040079ED RID: 31213
			internal Hashtable $data$37848;

			// Token: 0x040079EE RID: 31214
			internal M205_CrossingPlainLagoon2 $self_$37849;
		}
	}

	// Token: 0x020013CE RID: 5070
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37852 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007521 RID: 29985 RVA: 0x00FC97EC File Offset: 0x00FC79EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37852(Hashtable data, M205_CrossingPlainLagoon2 self_)
		{
			if (214121 - 516625 != -302503)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (247245 - 507864 != -260618)
				{
					base..ctor();
					if (200483 - 385642 != -185158)
					{
						this.$data$37859 = data;
						if (182853 - 348511 == -165658)
						{
							this.$self_$37860 = self_;
							if (162837 - 191057 != -28219)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007522 RID: 29986 RVA: 0x00FC98A8 File Offset: 0x00FC7AA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M205_CrossingPlainLagoon2.$onGameComplete$37852.$(this.$data$37859, this.$self_$37860);
		}

		// Token: 0x06007523 RID: 29987 RVA: 0x00FC98BC File Offset: 0x00FC7ABC
		internal static bool tZGK8FpdgHBDKA4jyv9t()
		{
			return true;
		}

		// Token: 0x06007524 RID: 29988 RVA: 0x00FC98C0 File Offset: 0x00FC7AC0
		internal static bool K8Nc2wpdfvk3QsiWtkXF()
		{
			return false;
		}

		// Token: 0x040079EF RID: 31215
		internal Hashtable $data$37859;

		// Token: 0x040079F0 RID: 31216
		internal M205_CrossingPlainLagoon2 $self_$37860;

		// Token: 0x020013CF RID: 5071
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007525 RID: 29989 RVA: 0x00FC98C4 File Offset: 0x00FC7AC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M205_CrossingPlainLagoon2 self_)
			{
				if (141481 - 487794 != -346313)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (10268 - 394320 != -384051)
					{
						base..ctor();
						if (224884 - 412376 != -187491)
						{
							this.$data$37857 = data;
							if (158131 - 33825 == 124306)
							{
								this.$self_$37858 = self_;
								if (145501 - 284537 != -139035)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007526 RID: 29990 RVA: 0x00FC9980 File Offset: 0x00FC7B80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (67406 - 448962 != -381556)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_352;
					case 2:
						this.$mCompleteGui$37854 = (CompleteGui)this.$self_$37858.GetComponent(typeof(CompleteGui));
						if (85593 - 59537 != 26056)
						{
							continue;
						}
						this.$mCompleteGui$37854.Init();
						if (166564 - 356111 == -189546)
						{
							continue;
						}
						this.$mCompleteGui$37854.readData(this.$data$37857);
						if (37060 - 310549 != -273489)
						{
							continue;
						}
						if (this.$result$37853 == 1)
						{
							if (260738 - 451247 != -190509)
							{
								continue;
							}
							this.$mCompleteGui$37854.displayResult(eCompleteType.Success);
							if (155819 - 377072 == -221252)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37854.displayResult(eCompleteType.Failed);
							if (248524 - 551466 == -302941)
							{
								continue;
							}
						}
						this.$mGameGui$37855 = (GameGui)this.$self_$37858.GetComponent(typeof(GameGui));
						if (243121 - 305311 == -62189)
						{
							continue;
						}
						this.$mStoryGui$37856 = (StoryGui)this.$self_$37858.GetComponent(typeof(StoryGui));
						if (51406 - 196230 == -144823)
						{
							continue;
						}
						if (this.$mGameGui$37855)
						{
							if (295453 - 131782 != 163671)
							{
								continue;
							}
							this.$mGameGui$37855.close();
							if (86383 - 158697 != -72314)
							{
								continue;
							}
						}
						if (this.$mStoryGui$37856)
						{
							if (112272 - 382140 != -269868)
							{
								continue;
							}
							this.$mStoryGui$37856.close();
							if (142060 - 198719 == -56658)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (216511 - 31806 != 184705)
						{
							continue;
						}
						goto IL_352;
					default:
						if (57062 - 76997 == -19934)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$37857[31]);
					if (95672 - 550853 == -455181)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (260141 - 342921 != -82779)
							{
								goto Block_19;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (282930 - 477934 != -195003)
							{
								this.$result$37853 = RuntimeServices.UnboxInt32(this.$data$37857[31]);
								if (215464 - 146601 == 68863)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_19:
				IL_352:
				return false;
			}

			// Token: 0x06007527 RID: 29991 RVA: 0x00FC9CF4 File Offset: 0x00FC7EF4
			internal static bool WhHUutpdn6bydYSfwR3x()
			{
				return true;
			}

			// Token: 0x06007528 RID: 29992 RVA: 0x00FC9CF8 File Offset: 0x00FC7EF8
			internal static bool I9IFuopd65AGWxQRJ1CL()
			{
				return false;
			}

			// Token: 0x040079F1 RID: 31217
			internal int $result$37853;

			// Token: 0x040079F2 RID: 31218
			internal CompleteGui $mCompleteGui$37854;

			// Token: 0x040079F3 RID: 31219
			internal GameGui $mGameGui$37855;

			// Token: 0x040079F4 RID: 31220
			internal StoryGui $mStoryGui$37856;

			// Token: 0x040079F5 RID: 31221
			internal Hashtable $data$37857;

			// Token: 0x040079F6 RID: 31222
			internal M205_CrossingPlainLagoon2 $self_$37858;
		}
	}

	// Token: 0x020013D0 RID: 5072
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37861 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007529 RID: 29993 RVA: 0x00FC9CFC File Offset: 0x00FC7EFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37861(M205_CrossingPlainLagoon2 self_)
		{
			if (241337 - 542428 != -301090)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (34916 - 203580 == -168664)
				{
					base..ctor();
					if (101594 - 51645 == 49949)
					{
						this.$self_$37866 = self_;
						if (44974 - 591788 == -546814)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600752A RID: 29994 RVA: 0x00FC9D94 File Offset: 0x00FC7F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M205_CrossingPlainLagoon2.$onDeadPlayer$37861.$(this.$self_$37866);
		}

		// Token: 0x0600752B RID: 29995 RVA: 0x00FC9DA4 File Offset: 0x00FC7FA4
		internal static bool nagTUDpdiOINALiDau7E()
		{
			return true;
		}

		// Token: 0x0600752C RID: 29996 RVA: 0x00FC9DA8 File Offset: 0x00FC7FA8
		internal static bool nNJdispdKRLsM08QMkr3()
		{
			return false;
		}

		// Token: 0x040079F7 RID: 31223
		internal M205_CrossingPlainLagoon2 $self_$37866;

		// Token: 0x020013D1 RID: 5073
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600752D RID: 29997 RVA: 0x00FC9DAC File Offset: 0x00FC7FAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M205_CrossingPlainLagoon2 self_)
			{
				if (178177 - 112015 != 66163)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (179702 - 211044 != -31341)
					{
						base..ctor();
						if (194716 - 587849 != -393132)
						{
							this.$self_$37865 = self_;
							if (69707 - 509781 == -440074)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600752E RID: 29998 RVA: 0x00FC9E44 File Offset: 0x00FC8044
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (271349 - 233657 != 37692)
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
							goto IL_27A;
						}
						if (46995 - 598558 == -551562)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (58267 - 474235 != -415968)
							{
								continue;
							}
							goto IL_27A;
						}
						IL_B6:
						this.YieldDefault(1);
						if (114514 - 225256 != -110742)
						{
							continue;
						}
						goto IL_2F9;
						IL_27A:
						Game.mGameState = eGameState.Hold;
						if (186123 - 246143 == -60019)
						{
							continue;
						}
						this.$mStoryGui$37862 = (StoryGui)this.$self_$37865.GetComponent(typeof(StoryGui));
						if (122988 - 262425 == -139436)
						{
							continue;
						}
						if (this.$mStoryGui$37862)
						{
							if (133974 - 307032 == -173057)
							{
								continue;
							}
							this.$mStoryGui$37862.close();
							if (35126 - 580405 == -545278)
							{
								continue;
							}
						}
						this.$mChangeGui$37863 = (ChangeGui)this.$self_$37865.GetComponent(typeof(ChangeGui));
						if (201412 - 292237 == -90824)
						{
							continue;
						}
						if (this.$mChangeGui$37863)
						{
							if (92968 - 68145 != 24823)
							{
								continue;
							}
							this.$mChangeGui$37863.close();
							if (97394 - 429186 != -331792)
							{
								continue;
							}
						}
						this.$mGameGui$37864 = (GameGui)this.$self_$37865.GetComponent(typeof(GameGui));
						if (88901 - 585103 == -496201)
						{
							continue;
						}
						if (!this.$mGameGui$37864)
						{
							goto IL_B6;
						}
						if (118037 - 476140 != -358103)
						{
							continue;
						}
						if (!this.$mGameGui$37864.enabled)
						{
							if (5694 - 407068 == -401373)
							{
								continue;
							}
							this.$mGameGui$37864.enabled = true;
							if (239282 - 94896 == 144387)
							{
								continue;
							}
						}
						this.$mGameGui$37864.openDeadMenu();
						if (6301 - 173411 != -167110)
						{
							continue;
						}
						goto IL_B6;
					default:
						if (160804 - 14852 == 145953)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (271609 - 409820 != -138211);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600752F RID: 29999 RVA: 0x00FCA15C File Offset: 0x00FC835C
			internal static bool a2lACApddhROeWu2xZXW()
			{
				return true;
			}

			// Token: 0x06007530 RID: 30000 RVA: 0x00FCA160 File Offset: 0x00FC8360
			internal static bool kAHgKnpdJiF9i1qYbdLy()
			{
				return false;
			}

			// Token: 0x040079F8 RID: 31224
			internal StoryGui $mStoryGui$37862;

			// Token: 0x040079F9 RID: 31225
			internal ChangeGui $mChangeGui$37863;

			// Token: 0x040079FA RID: 31226
			internal GameGui $mGameGui$37864;

			// Token: 0x040079FB RID: 31227
			internal M205_CrossingPlainLagoon2 $self_$37865;
		}
	}

	// Token: 0x020013D2 RID: 5074
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37867 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007531 RID: 30001 RVA: 0x00FCA164 File Offset: 0x00FC8364
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37867(M205_CrossingPlainLagoon2 self_)
		{
			if (200860 - 521591 != -320730)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (70215 - 386604 == -316389)
				{
					base..ctor();
					if (41331 - 187210 != -145878)
					{
						this.$self_$37871 = self_;
						if (115236 - 245108 != -129871)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007532 RID: 30002 RVA: 0x00FCA1FC File Offset: 0x00FC83FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M205_CrossingPlainLagoon2.$ReturnToTown$37867.$(this.$self_$37871);
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x00FCA20C File Offset: 0x00FC840C
		internal static bool gJkHvFpdD2AGZcH4MxAC()
		{
			return true;
		}

		// Token: 0x06007534 RID: 30004 RVA: 0x00FCA210 File Offset: 0x00FC8410
		internal static bool l0BMv2pdvThs394pd2S7()
		{
			return false;
		}

		// Token: 0x040079FC RID: 31228
		internal M205_CrossingPlainLagoon2 $self_$37871;

		// Token: 0x020013D3 RID: 5075
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007535 RID: 30005 RVA: 0x00FCA214 File Offset: 0x00FC8414
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M205_CrossingPlainLagoon2 self_)
			{
				if (141711 - 233986 != -92275)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (242536 - 518530 == -275994)
					{
						base..ctor();
						if (20710 - 248122 != -227411)
						{
							this.$self_$37870 = self_;
							if (17787 - 298054 != -280266)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007536 RID: 30006 RVA: 0x00FCA2AC File Offset: 0x00FC84AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280631 - 535433 != -254801)
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
						this.$self_$37870.LeaveGame();
						if (205822 - 20125 != 185697)
						{
							continue;
						}
						this.YieldDefault(1);
						if (126782 - 506155 != -379373)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (193010 - 330488 == -137477)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (147341 - 162979 == -15638)
					{
						Game.mStateTime = Time.time;
						if (285584 - 201619 == 83965)
						{
							this.$$switch$6488$37868 = PlayerData.SaveGuild;
							if (262068 - 437725 != -175656)
							{
								if (this.$$switch$6488$37868 == 1)
								{
									if (53743 - 599383 != -545640)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (239331 - 8116 == 231216)
									{
										continue;
									}
								}
								else if (this.$$switch$6488$37868 == 2)
								{
									if (153855 - 358971 == -205115)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (38438 - 568230 == -529791)
									{
										continue;
									}
								}
								else if (this.$$switch$6488$37868 == 3)
								{
									if (147248 - 137916 == 9333)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (102658 - 67336 == 35323)
									{
										continue;
									}
								}
								else if (this.$$switch$6488$37868 == 4)
								{
									if (109709 - 515599 != -405890)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (126447 - 462465 == -336017)
									{
										continue;
									}
								}
								else if (this.$$switch$6488$37868 == 5)
								{
									if (81924 - 59263 != 22661)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (30917 - 62670 == -31752)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (58868 - 132932 == -74063)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (220762 - 187901 != 32861)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (122088 - 467894 != -345806)
									{
										continue;
									}
								}
								this.$mGameGui$37869 = (GameGui)this.$self_$37870.GetComponent(typeof(GameGui));
								if (52088 - 112821 == -60733)
								{
									if (this.$mGameGui$37869)
									{
										if (11393 - 417269 != -405876)
										{
											continue;
										}
										this.$mGameGui$37869.close();
										if (142991 - 425808 != -282817)
										{
											continue;
										}
									}
									this.$self_$37870.SendMessage("fadeOut");
									if (29259 - 173877 != -144617)
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

			// Token: 0x06007537 RID: 30007 RVA: 0x00FCA678 File Offset: 0x00FC8878
			internal static bool hHesbApdR95ZytPGshAF()
			{
				return true;
			}

			// Token: 0x06007538 RID: 30008 RVA: 0x00FCA67C File Offset: 0x00FC887C
			internal static bool aOd9FupdwTOCjDTsJoEY()
			{
				return false;
			}

			// Token: 0x040079FD RID: 31229
			internal int $$switch$6488$37868;

			// Token: 0x040079FE RID: 31230
			internal GameGui $mGameGui$37869;

			// Token: 0x040079FF RID: 31231
			internal M205_CrossingPlainLagoon2 $self_$37870;
		}
	}

	// Token: 0x020013D4 RID: 5076
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37872 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007539 RID: 30009 RVA: 0x00FCA680 File Offset: 0x00FC8880
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37872(M205_CrossingPlainLagoon2 self_)
		{
			if (139057 - 406020 != -266962)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (160318 - 421019 != -260700)
				{
					base..ctor();
					if (221823 - 163443 == 58380)
					{
						this.$self_$37875 = self_;
						if (91204 - 378695 == -287491)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600753A RID: 30010 RVA: 0x00FCA718 File Offset: 0x00FC8918
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M205_CrossingPlainLagoon2.$ReturnToGuild$37872.$(this.$self_$37875);
		}

		// Token: 0x0600753B RID: 30011 RVA: 0x00FCA728 File Offset: 0x00FC8928
		internal static bool abwA4qpdqvR5IDQ9ZQPs()
		{
			return true;
		}

		// Token: 0x0600753C RID: 30012 RVA: 0x00FCA72C File Offset: 0x00FC892C
		internal static bool q0yUANpd7OnR4MCOXgB7()
		{
			return false;
		}

		// Token: 0x04007A00 RID: 31232
		internal M205_CrossingPlainLagoon2 $self_$37875;

		// Token: 0x020013D5 RID: 5077
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600753D RID: 30013 RVA: 0x00FCA730 File Offset: 0x00FC8930
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M205_CrossingPlainLagoon2 self_)
			{
				if (271522 - 227704 != 43819)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (45134 - 207104 != -161969)
					{
						base..ctor();
						if (295129 - 454963 != -159833)
						{
							this.$self_$37874 = self_;
							if (117426 - 221777 != -104350)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600753E RID: 30014 RVA: 0x00FCA7C8 File Offset: 0x00FC89C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (9894 - 404862 != -394968)
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
						this.$self_$37874.LeaveGame();
						if (204488 - 180870 != 23618)
						{
							continue;
						}
						this.YieldDefault(1);
						if (66015 - 262223 != -196207)
						{
							goto Block_11;
						}
						continue;
					default:
						if (200698 - 96545 == 104154)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (192541 - 55675 != 136867)
					{
						Game.mStateTime = Time.time;
						if (8512 - 472397 == -463885)
						{
							Game.mNextGameCode = 31;
							if (45932 - 143012 == -97080)
							{
								this.$mGameGui$37873 = (GameGui)this.$self_$37874.GetComponent(typeof(GameGui));
								if (294584 - 182322 == 112262)
								{
									if (this.$mGameGui$37873)
									{
										if (260950 - 79826 == 181125)
										{
											continue;
										}
										this.$mGameGui$37873.close();
										if (230998 - 280710 == -49711)
										{
											continue;
										}
									}
									this.$self_$37874.SendMessage("fadeOut");
									if (286390 - 456711 != -170320)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_11:
				IL_1BD:
				return false;
			}

			// Token: 0x0600753F RID: 30015 RVA: 0x00FCA9A4 File Offset: 0x00FC8BA4
			internal static bool pJmsyFpdPYB640eNh8iQ()
			{
				return true;
			}

			// Token: 0x06007540 RID: 30016 RVA: 0x00FCA9A8 File Offset: 0x00FC8BA8
			internal static bool suC9Aopd0qjOLuDNyoTM()
			{
				return false;
			}

			// Token: 0x04007A01 RID: 31233
			internal GameGui $mGameGui$37873;

			// Token: 0x04007A02 RID: 31234
			internal M205_CrossingPlainLagoon2 $self_$37874;
		}
	}

	// Token: 0x020013D6 RID: 5078
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37876 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007541 RID: 30017 RVA: 0x00FCA9AC File Offset: 0x00FC8BAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37876(M205_CrossingPlainLagoon2 self_)
		{
			if (184351 - 158794 != 25558)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (171229 - 333278 == -162049)
				{
					base..ctor();
					if (92460 - 116904 == -24444)
					{
						this.$self_$37880 = self_;
						if (165918 - 568817 != -402898)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007542 RID: 30018 RVA: 0x00FCAA44 File Offset: 0x00FC8C44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M205_CrossingPlainLagoon2.$ReturnToCamp$37876.$(this.$self_$37880);
		}

		// Token: 0x06007543 RID: 30019 RVA: 0x00FCAA54 File Offset: 0x00FC8C54
		internal static bool IM9JkNpdb3oPyfg5pMcM()
		{
			return true;
		}

		// Token: 0x06007544 RID: 30020 RVA: 0x00FCAA58 File Offset: 0x00FC8C58
		internal static bool wW2gwgpdue8au5jj0HkC()
		{
			return false;
		}

		// Token: 0x04007A03 RID: 31235
		internal M205_CrossingPlainLagoon2 $self_$37880;

		// Token: 0x020013D7 RID: 5079
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007545 RID: 30021 RVA: 0x00FCAA5C File Offset: 0x00FC8C5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M205_CrossingPlainLagoon2 self_)
			{
				if (134058 - 136450 != -2392)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (262885 - 433527 == -170642)
					{
						base..ctor();
						if (63149 - 273917 != -210767)
						{
							this.$self_$37879 = self_;
							if (40493 - 34288 != 6206)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007546 RID: 30022 RVA: 0x00FCAAF4 File Offset: 0x00FC8CF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (109889 - 438527 != -328638)
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
						this.$self_$37879.LeaveGame();
						if (255292 - 126007 != 129285)
						{
							continue;
						}
						this.YieldDefault(1);
						if (185939 - 330077 != -144137)
						{
							goto Block_25;
						}
						continue;
					default:
						if (9174 - 273953 == -264778)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (240557 - 250758 != -10200)
					{
						Game.mStateTime = Time.time;
						if (240802 - 123828 != 116975)
						{
							this.$$switch$6490$37877 = PlayerData.SaveGuild;
							if (86978 - 240207 == -153229)
							{
								if (this.$$switch$6490$37877 == 1)
								{
									if (268367 - 246279 != 22088)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (172091 - 283766 != -111675)
									{
										continue;
									}
								}
								else if (this.$$switch$6490$37877 == 2)
								{
									if (294672 - 435630 != -140958)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (298142 - 389274 == -91131)
									{
										continue;
									}
								}
								else if (this.$$switch$6490$37877 == 3)
								{
									if (87012 - 539383 != -452371)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (283646 - 435767 != -152121)
									{
										continue;
									}
								}
								else if (this.$$switch$6490$37877 == 4)
								{
									if (191474 - 28565 == 162910)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (291615 - 284551 != 7064)
									{
										continue;
									}
								}
								else if (this.$$switch$6490$37877 == 5)
								{
									if (64009 - 28513 != 35496)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (297678 - 113445 == 184234)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (6369 - 519089 == -512719)
									{
										continue;
									}
								}
								this.$mGameGui$37878 = (GameGui)this.$self_$37879.GetComponent(typeof(GameGui));
								if (10658 - 278455 == -267797)
								{
									if (this.$mGameGui$37878)
									{
										if (72328 - 577418 == -505089)
										{
											continue;
										}
										this.$mGameGui$37878.close();
										if (137312 - 323476 != -186164)
										{
											continue;
										}
									}
									this.$self_$37879.SendMessage("fadeOut");
									if (67650 - 109868 == -42218)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_25:
				IL_363:
				return false;
			}

			// Token: 0x06007547 RID: 30023 RVA: 0x00FCAE78 File Offset: 0x00FC9078
			internal static bool wFfkSOpdIBEgCJmKcNmh()
			{
				return true;
			}

			// Token: 0x06007548 RID: 30024 RVA: 0x00FCAE7C File Offset: 0x00FC907C
			internal static bool Gl2WRRpdBIEYIVlSxgAV()
			{
				return false;
			}

			// Token: 0x04007A04 RID: 31236
			internal int $$switch$6490$37877;

			// Token: 0x04007A05 RID: 31237
			internal GameGui $mGameGui$37878;

			// Token: 0x04007A06 RID: 31238
			internal M205_CrossingPlainLagoon2 $self_$37879;
		}
	}
}
