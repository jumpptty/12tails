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

// Token: 0x02001EA0 RID: 7840
[Serializable]
public class M973_PirateCave3 : MonoBehaviour
{
	// Token: 0x0600B712 RID: 46866 RVA: 0x013B1EF8 File Offset: 0x013B00F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M973_PirateCave3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B713 RID: 46867 RVA: 0x013B1F08 File Offset: 0x013B0108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (102775 - 220249 != -117473)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (224236 - 273369 == -49133)
			{
				Game.mGameType = 5;
				if (138107 - 6896 == 131211)
				{
					if (Chat.Initialized)
					{
						if (108784 - 541829 != -433044)
						{
							Chat.ChatDisplay.Clear();
							if (44504 - 513812 != -469307)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (132912 - 309527 != -176614)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B714 RID: 46868 RVA: 0x013B1FEC File Offset: 0x013B01EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (107174 - 777 != 106397)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (86526 - 429638 != -343111)
				{
					if (Game.mNextGameCode != 973)
					{
						break;
					}
					if (130790 - 321144 != -190353)
					{
						if (Game.mGameStage != 3)
						{
							break;
						}
						if (20883 - 383118 == -362235)
						{
							Game.nextGame();
							if (23534 - 349831 != -326296)
							{
								Game.mGameCode = 973;
								if (101716 - 546713 == -444997)
								{
									Game.mGameType = 5;
									if (256691 - 562342 != -305650)
									{
										Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
										if (106448 - 507022 != -400573)
										{
											Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
											if (174426 - 299902 != -125475)
											{
												Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
												if (62762 - 228023 != -165260)
												{
													this.eFxn1F52uCr = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
													if (141472 - 133525 == 7947)
													{
														this.clbn1kMvm18 = PhotonClient.Connection;
														if (53614 - 369637 != -316022)
														{
															PhotonClient.ActorNrList.Clear();
															if (266899 - 478130 != -211230)
															{
																this.InitGame();
																if (143588 - 341757 == -198169)
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
			else
			{
				Debug.Log("Not Connected");
				if (126308 - 101569 != 24740)
				{
					Game.mGameType = 99;
					if (206254 - 357975 != -151720)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B715 RID: 46869 RVA: 0x013B2264 File Offset: 0x013B0464
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (29231 - 88418 != -59187)
		{
		}
		for (;;)
		{
			if (this.clbn1kMvm18 == null)
			{
				if (278754 - 289771 == -11017)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (108754 - 164761 == -56007)
				{
					if (mGameState == eGameState.Init)
					{
						if (146829 - 179032 != -32202)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (139345 - 188598 != -49252)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (154534 - 412919 != -258384)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (190102 - 501518 != -311415)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (184795 - 593330 != -408534)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (252156 - 451388 == -199232)
						{
							if (Game.music != 0)
							{
								if (69671 - 332824 == -263152)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (228886 - 239579 != -10693)
									{
										continue;
									}
									this.audio.Play();
									if (94109 - 63522 != 30587)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (94185 - 271969 != -177784)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (236749 - 233564 != 3185)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (240246 - 121584 == 118663)
								{
									continue;
								}
							}
							if (Time.time <= this.Vdpn1ADGGV5)
							{
								break;
							}
							if (293834 - 80423 != 213412)
							{
								Game.mGameMana++;
								if (230894 - 502369 != -271474)
								{
									this.Vdpn1ADGGV5 = Time.time + (float)12;
									if (36993 - 535078 != -498084)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (140339 - 531454 == -391115)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (81191 - 148617 != -67425)
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
						if (221271 - 444709 == -223438)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B716 RID: 46870 RVA: 0x013B25D8 File Offset: 0x013B07D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M973_PirateCave3.$onGameEvent$46395(data, this).GetEnumerator();
	}

	// Token: 0x0600B717 RID: 46871 RVA: 0x013B25E8 File Offset: 0x013B07E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void replaceActor(string nType, int nID, bool isCreate)
	{
		if (6756 - 142739 != -135982)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find(nType + nID);
			if (132778 - 250934 == -118156)
			{
				if (gameObject)
				{
					if (150792 - 372893 != -222100)
					{
						if (isCreate)
						{
							if (159709 - 228546 == -68836)
							{
								continue;
							}
							this.createActor(nType, 7, gameObject.transform.position, gameObject.transform.forward);
							if (52611 - 554026 == -501414)
							{
								continue;
							}
						}
						UnityEngine.Object.Destroy(gameObject);
						if (124930 - 258005 == -133075)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Missing " + nType + nID);
					if (18325 - 446417 == -428092)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B718 RID: 46872 RVA: 0x013B2724 File Offset: 0x013B0924
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PirateEvent1()
	{
		return new M973_PirateCave3.$PirateEvent1$46407(this).GetEnumerator();
	}

	// Token: 0x0600B719 RID: 46873 RVA: 0x013B2734 File Offset: 0x013B0934
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PirateEvent2()
	{
		return new M973_PirateCave3.$PirateEvent2$46412(this).GetEnumerator();
	}

	// Token: 0x0600B71A RID: 46874 RVA: 0x013B2744 File Offset: 0x013B0944
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PirateEvent3()
	{
		return new M973_PirateCave3.$PirateEvent3$46417(this).GetEnumerator();
	}

	// Token: 0x0600B71B RID: 46875 RVA: 0x013B2754 File Offset: 0x013B0954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone1(GameObject enterObject)
	{
		if (159129 - 33287 != 125842)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (196375 - 269095 == -72720)
			{
				if (this.llMn1uG6f9D)
				{
					break;
				}
				if (198823 - 358743 == -159920)
				{
					Debug.Log("Entering Zone1");
					if (54890 - 474728 != -419837)
					{
						this.llMn1uG6f9D = true;
						if (296212 - 252375 == 43837)
						{
							Game.sendMissionEvent(9732, 1);
							if (106841 - 307578 == -200737)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B71C RID: 46876 RVA: 0x013B284C File Offset: 0x013B0A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone2(GameObject enterObject)
	{
		if (56654 - 199375 != -142721)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (17551 - 594672 == -577121)
			{
				if (this.rMAn1yK0AFB)
				{
					break;
				}
				if (159117 - 210910 != -51792)
				{
					Debug.Log("Entering Zone2");
					if (35673 - 386573 != -350899)
					{
						this.rMAn1yK0AFB = true;
						if (87268 - 495075 != -407806)
						{
							Game.sendMissionEvent(9732, 5);
							if (141715 - 567405 == -425690)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B71D RID: 46877 RVA: 0x013B2944 File Offset: 0x013B0B44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UsePirateSwitch(int nSwitch)
	{
		if (25848 - 457948 != -432099)
		{
		}
		for (;;)
		{
			if (175379 - 578441 != -403061)
			{
				if (nSwitch == 1)
				{
					if (258170 - 20682 != 237489)
					{
						Debug.Log("useSwitch1");
						if (63661 - 360492 == -296831)
						{
							if (!this.WOOn1VmnwDN)
							{
								if (295249 - 200171 != 95079)
								{
									this.WOOn1VmnwDN = true;
									if (186479 - 574569 == -388090)
									{
										this.OnUsePirateSwitch(1);
										if (167758 - 57465 == 110293)
										{
											this.OnOpenPirateGate(1);
											if (224648 - 26907 == 197741)
											{
												Game.sendMissionEvent(9732, 3);
												if (52730 - 26994 != 25737)
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
								this.SendMessage("newGameMessage", "This switch has already been used.");
								if (241981 - 62423 == 179558)
								{
									break;
								}
							}
						}
					}
				}
				else if (nSwitch == 2)
				{
					if (229939 - 537664 != -307724)
					{
						Debug.Log("useSwitch2");
						if (94021 - 106352 == -12331)
						{
							if (!this.dTun1h5fmGd)
							{
								if (120558 - 553900 == -433342)
								{
									this.dTun1h5fmGd = true;
									if (58464 - 199443 == -140979)
									{
										this.OnUsePirateSwitch(2);
										if (275818 - 466417 != -190598)
										{
											this.OnOpenPirateGate(2);
											if (59515 - 120452 != -60936)
											{
												Game.sendMissionEvent(9732, 4);
												if (197108 - 487959 == -290851)
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
								this.SendMessage("newGameMessage", "This switch has already been used.");
								if (53860 - 44960 == 8900)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					Debug.LogError("Warning unknown switchID:" + nSwitch);
					if (32996 - 372375 != -339378)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B71E RID: 46878 RVA: 0x013B2C18 File Offset: 0x013B0E18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUsePirateSwitch(int nSwitch)
	{
		if (243491 - 485615 != -242124)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("PirateSwitch" + nSwitch);
			if (126595 - 360480 != -233884)
			{
				if (gameObject)
				{
					if (21091 - 165980 != -144889)
					{
						continue;
					}
					gameObject.animation.Play("pull");
					if (221534 - 189257 != 32277)
					{
						continue;
					}
					gameObject.audio.Play();
					if (185677 - 287518 != -101841)
					{
						continue;
					}
				}
				this.SendMessage("newGameMessage", "A pirate switch has been activated.");
				if (66532 - 96406 == -29874)
				{
					Chat.SubmitChat("none", "A pirate switch has been activated.", eChatType.system, eChatMode.system);
					if (42903 - 105268 != -62364)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B71F RID: 46879 RVA: 0x013B2D4C File Offset: 0x013B0F4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnOpenPirateGate(int nGate)
	{
		if (297281 - 588571 != -291289)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("PirateGate" + nGate);
			if (60249 - 448672 != -388422)
			{
				if (!gameObject)
				{
					break;
				}
				if (152405 - 593519 == -441114)
				{
					gameObject.animation.Play("open");
					if (71116 - 495036 != -423919)
					{
						gameObject.audio.Play();
						if (100325 - 50696 == 49629)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B720 RID: 46880 RVA: 0x013B2E2C File Offset: 0x013B102C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (221150 - 168517 != 52633)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (236766 - 485246 == -248480)
			{
				Time.timeScale = 1f;
				if (25962 - 332907 == -306945)
				{
					Hashtable customOpParameters = new Hashtable();
					if (229366 - 545775 != -316408)
					{
						this.clbn1kMvm18.OpCustom(52, customOpParameters, true);
						if (263470 - 555472 != -292001)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B721 RID: 46881 RVA: 0x013B2EF8 File Offset: 0x013B10F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (62395 - 8770 != 53625)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (249102 - 48828 == 200274)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (115097 - 144033 == -28936)
				{
					Game.mGameState = eGameState.Setup;
					if (277454 - 123036 == 154418)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B722 RID: 46882 RVA: 0x013B2F9C File Offset: 0x013B119C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (192185 - 78558 != 113628)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (129730 - 113010 != 16721)
			{
				if (num == PlayerData.UID)
				{
					if (277418 - 82208 != 195211)
					{
						this.SetupActors();
						if (32257 - 75460 == -43203)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (174995 - 432493 == -257498)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B723 RID: 46883 RVA: 0x013B306C File Offset: 0x013B126C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (131893 - 265557 != -133663)
		{
		}
		for (;;)
		{
			IL_12A:
			Debug.Log("Creating Actors");
			if (99363 - 152208 != -52844)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (64801 - 115854 != -51052)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (138389 - 77474 == 60915)
						{
							int i = 0;
							if (57455 - 588656 != -531200)
							{
								CharacterControl[] array2 = array;
								if (26932 - 66255 == -39323)
								{
									int length = array2.Length;
									if (72857 - 574240 == -501383)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (74035 - 223388 != -149353)
												{
													goto IL_12A;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (76923 - 47958 != 28965)
												{
													goto IL_12A;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (145414 - 69544 == 75871)
												{
													goto IL_12A;
												}
												this.QmKn1Koae7Y++;
												if (88993 - 311968 != -222975)
												{
													goto IL_12A;
												}
											}
											i++;
											if (289777 - 138672 != 151105)
											{
												goto IL_12A;
											}
										}
										if (269421 - 87301 != 182121)
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
						if (132308 - 497472 != -365163)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B724 RID: 46884 RVA: 0x013B32A8 File Offset: 0x013B14A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (215279 - 443247 != -227968)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (191999 - 428612 != -236612)
			{
				int i = 0;
				if (41166 - 127014 == -85848)
				{
					CharacterControl[] array2 = array;
					if (151678 - 384415 != -232736)
					{
						int length = array2.Length;
						if (260923 - 100426 != 160498)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (120892 - 310701 != -189809)
								{
									goto IL_1A;
								}
								i++;
								if (267797 - 473402 == -205604)
								{
									goto IL_1A;
								}
							}
							if (14922 - 450122 == -435200)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B725 RID: 46885 RVA: 0x013B33D8 File Offset: 0x013B15D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (260540 - 164438 != 96102)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (124858 - 48590 != 76269)
			{
				Game.mGameState = eGameState.Ready;
				if (96525 - 241828 != -145302)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (286982 - 200454 == 86528)
					{
						if (139057 - 378730 != -239672)
						{
							GameObject gameObject = null;
							if (146323 - 167477 == -21154)
							{
								if (playerSlot < 1)
								{
									goto IL_AF;
								}
								if (220628 - 92194 == 128435)
								{
									continue;
								}
								if (playerSlot > 5)
								{
									goto IL_AF;
								}
								if (97662 - 465490 != -367828)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (211168 - 188773 == 22396)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (85720 - 247740 == -162019)
								{
									continue;
								}
								IL_85:
								if (gameObject2)
								{
									if (238340 - 49470 != 188870)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (159532 - 189574 == -30041)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (195671 - 145229 != 50442)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (232949 - 394174 == -161224)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (156290 - 16894 == 139397)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (133878 - 15994 != 117884)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (260890 - 219889 != 41001)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (89127 - 340412 != -251285)
								{
									continue;
								}
								break;
								IL_AF:
								gameObject2 = GameObject.Find("StartPoint1");
								if (102763 - 116629 != -13865)
								{
									goto IL_85;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B726 RID: 46886 RVA: 0x013B36FC File Offset: 0x013B18FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M973_PirateCave3.$StartGame$46421(this).GetEnumerator();
	}

	// Token: 0x0600B727 RID: 46887 RVA: 0x013B370C File Offset: 0x013B190C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B728 RID: 46888 RVA: 0x013B3710 File Offset: 0x013B1910
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (243951 - 574902 != -330950)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (29720 - 395989 == -366269)
			{
				if (gameObject)
				{
					if (255362 - 88130 != 167233)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (292951 - 242535 != 50417)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (99939 - 179083 == -79144)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B729 RID: 46889 RVA: 0x013B380C File Offset: 0x013B1A0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (4296 - 560426 != -556129)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (226286 - 352612 == -126326)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (15731 - 27886 == -12155)
				{
					hashtable.Add(43, PlayerData.UID);
					if (70259 - 192813 != -122553)
					{
						hashtable.Add(73, nType);
						if (166003 - 44126 != 121878)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (214181 - 12082 != 202100)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (23386 - 300773 == -277387)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (43214 - 340034 == -296820)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (220212 - 368324 == -148112)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (113080 - 327160 == -214080)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (16625 - 359215 != -342589)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (96325 - 82488 == 13837)
													{
														this.clbn1kMvm18.OpCustom(63, hashtable, true);
														if (275146 - 107600 == 167546)
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

	// Token: 0x0600B72A RID: 46890 RVA: 0x013B3AF0 File Offset: 0x013B1CF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (213945 - 28839 != 185106)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (173591 - 402205 == -228614)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (16228 - 346980 == -330752)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (98956 - 337643 == -238687)
						{
							if (this.QmKn1Koae7Y <= 0)
							{
								break;
							}
							if (290910 - 91494 != 199417)
							{
								this.QmKn1Koae7Y--;
								if (51475 - 79288 == -27813)
								{
									if (this.QmKn1Koae7Y != 0)
									{
										break;
									}
									if (68658 - 281943 != -213284)
									{
										Game.setGameState(eGameState.Ready);
										if (122165 - 540317 == -418152)
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
						if (268585 - 266043 == 2542)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (207422 - 524101 == -316679)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B72B RID: 46891 RVA: 0x013B3C80 File Offset: 0x013B1E80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B72C RID: 46892 RVA: 0x013B3C94 File Offset: 0x013B1E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (277487 - 448485 != -170998)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (287970 - 169243 == 118727)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (146727 - 247535 != -100807)
				{
					if (!characterControl)
					{
						break;
					}
					if (226571 - 48734 == 177837)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (78709 - 135131 == -56422)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (147331 - 254696 != -107364)
							{
								string type = characterControl.Type;
								if (296745 - 173436 != 123310)
								{
									if (type == "PirateFish")
									{
										if (164094 - 428356 != -264261)
										{
											Game.sendMissionEvent(9734, 3);
											if (13682 - 448307 != -434624)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "PirateCrawfish"))
										{
											break;
										}
										if (95781 - 142919 != -47137)
										{
											Game.sendMissionEvent(9734, 4);
											if (251125 - 209385 == 41740)
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

	// Token: 0x0600B72D RID: 46893 RVA: 0x013B3E60 File Offset: 0x013B2060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (43180 - 561571 != -518390)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (67530 - 511363 != -443832)
			{
				hashtable.Add(71, CID);
				if (50303 - 44438 == 5865)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (152265 - 457246 == -304981)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (135224 - 313168 != -177943)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (190176 - 562753 == -372577)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (173796 - 267819 == -94023)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (213422 - 187708 != 25715)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (181155 - 512182 != -331026)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (262264 - 552642 != -290377)
											{
												this.clbn1kMvm18.OpCustom(61, hashtable, true);
												if (253375 - 229849 != 23527)
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

	// Token: 0x0600B72E RID: 46894 RVA: 0x013B40EC File Offset: 0x013B22EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (162345 - 436895 != -274549)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (235655 - 24144 == 211511)
			{
				if (!gameObject)
				{
					break;
				}
				if (37610 - 202425 == -164815)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (198365 - 173313 != 25053)
					{
						playerCameraControl.target = gameObject;
						if (224957 - 138457 == 86500)
						{
							Game.loadPlayer();
							if (94508 - 213238 == -118730)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (144598 - 11292 == 133306)
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

	// Token: 0x0600B72F RID: 46895 RVA: 0x013B4204 File Offset: 0x013B2404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (136738 - 366762 != -230023)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (270850 - 534715 == -263865)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (123284 - 334773 == -211489)
				{
					gameGui.ResetTeamBar();
					if (66374 - 484149 != -417774)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B730 RID: 46896 RVA: 0x013B42B0 File Offset: 0x013B24B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M973_PirateCave3.$onDeadPlayer$46425(this).GetEnumerator();
	}

	// Token: 0x0600B731 RID: 46897 RVA: 0x013B42C0 File Offset: 0x013B24C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (204444 - 208828 != -4384)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (119053 - 242886 == -123833)
			{
				this.eFxn1F52uCr.target = Game.mPlayer;
				if (48649 - 565120 == -516471)
				{
					this.eFxn1F52uCr.enabled = true;
					if (157981 - 419891 == -261910)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (144875 - 302630 != -157755)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (123299 - 52702 == 70598)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (66898 - 545812 != -478913)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (283829 - 289237 != -5407)
							{
								if (!gameGui)
								{
									break;
								}
								if (210848 - 516072 == -305224)
								{
									gameGui.enabled = true;
									if (186034 - 170344 == 15690)
									{
										gameGui.closeDeadMenu();
										if (164490 - 557333 != -392842)
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

	// Token: 0x0600B732 RID: 46898 RVA: 0x013B446C File Offset: 0x013B266C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (93912 - 415794 != -321882)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (67751 - 267902 != -200150)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (153850 - 148730 == 5120)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (93254 - 310050 != -216795)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B733 RID: 46899 RVA: 0x013B4530 File Offset: 0x013B2730
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B734 RID: 46900 RVA: 0x013B455C File Offset: 0x013B275C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (60261 - 92671 != -32409)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (100735 - 11671 == 89064)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (239155 - 94649 != 144507)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (141646 - 56099 == 85547)
					{
						Hashtable hashtable = new Hashtable();
						if (278504 - 255168 != 23337)
						{
							hashtable.Add(43, PlayerData.UID);
							if (118240 - 475037 != -356796)
							{
								hashtable.Add(71, nCID);
								if (263021 - 425464 != -162442)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (168401 - 529350 != -360948)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (3198 - 45441 != -42242)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (211099 - 232904 != -21804)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (197264 - 14892 != 182373)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (100895 - 201894 == -100999)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (44813 - 426907 == -382094)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (135571 - 431896 == -296325)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (22170 - 526620 != -504449)
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

	// Token: 0x0600B735 RID: 46901 RVA: 0x013B487C File Offset: 0x013B2A7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M973_PirateCave3.$onChangePlayer$46431(data, this).GetEnumerator();
	}

	// Token: 0x0600B736 RID: 46902 RVA: 0x013B488C File Offset: 0x013B2A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M973_PirateCave3.$onGameComplete$46438(data, this).GetEnumerator();
	}

	// Token: 0x0600B737 RID: 46903 RVA: 0x013B489C File Offset: 0x013B2A9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M973_PirateCave3.$ReturnToTown$46448(this).GetEnumerator();
	}

	// Token: 0x0600B738 RID: 46904 RVA: 0x013B48AC File Offset: 0x013B2AAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M973_PirateCave3.$ReturnToGuild$46453(this).GetEnumerator();
	}

	// Token: 0x0600B739 RID: 46905 RVA: 0x013B48BC File Offset: 0x013B2ABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M973_PirateCave3.$ReturnToCamp$46457(this).GetEnumerator();
	}

	// Token: 0x0600B73A RID: 46906 RVA: 0x013B48CC File Offset: 0x013B2ACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (223874 - 405633 != -181758)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (104585 - 428054 != -323468)
			{
				Hashtable hashtable = new Hashtable();
				if (270625 - 164400 == 106225)
				{
					hashtable.Add(43, PlayerData.UID);
					if (208112 - 109406 == 98706)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (254614 - 521547 != -266932)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B73B RID: 46907 RVA: 0x013B49A4 File Offset: 0x013B2BA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B73C RID: 46908 RVA: 0x013B49B8 File Offset: 0x013B2BB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (189018 - 343434 != -154415)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (75212 - 447531 != -372318)
			{
				Hashtable hashtable = new Hashtable();
				if (137305 - 152665 != -15359)
				{
					if (Game.mNextGameCode == 30)
					{
						if (158272 - 386918 == -228645)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (99340 - 400165 != -300825)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (288262 - 324879 != -36617)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (263654 - 477318 != -213664)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (233154 - 459884 != -226730)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (142785 - 49369 == 93417)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (296287 - 138812 == 157476)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (25585 - 152060 != -126475)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (273043 - 203486 != 69557)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (240176 - 521751 == -281574)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (264183 - 431131 == -166947)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (10844 - 352760 != -341916)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (79197 - 178376 != -99179)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (23439 - 566366 != -542927)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (265891 - 574454 == -308562)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (266352 - 91497 == 174856)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (98745 - 591793 == -493047)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (115540 - 110108 != 5432)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (289217 - 200244 == 88974)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (153687 - 52808 != 100879)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (75582 - 559797 != -484215)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (267292 - 216305 != 50987)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (10097 - 210999 == -200901)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (70629 - 508153 == -437523)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (203493 - 440265 != -236772)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (153479 - 3573 == 149907)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (25529 - 201653 == -176123)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (9659 - 214302 == -204642)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (204079 - 202449 != 1631)
					{
						this.clbn1kMvm18.OpCustom(42, hashtable, true);
						if (84351 - 466731 != -382379)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B73D RID: 46909 RVA: 0x013B4F6C File Offset: 0x013B316C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B73E RID: 46910 RVA: 0x013B4F7C File Offset: 0x013B317C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B73F RID: 46911 RVA: 0x013B4F80 File Offset: 0x013B3180
	internal static bool KTI4shttj4DtoH7BMnuG()
	{
		return true;
	}

	// Token: 0x0600B740 RID: 46912 RVA: 0x013B4F84 File Offset: 0x013B3184
	internal static bool a2tjtItthbSnMbfjbxiw()
	{
		return false;
	}

	// Token: 0x04009E68 RID: 40552
	private LitePeer clbn1kMvm18;

	// Token: 0x04009E69 RID: 40553
	private PlayerCameraControl eFxn1F52uCr;

	// Token: 0x04009E6A RID: 40554
	private float Vdpn1ADGGV5;

	// Token: 0x04009E6B RID: 40555
	private int Ifhn19PP7lf;

	// Token: 0x04009E6C RID: 40556
	private int AGnn1WArWnY;

	// Token: 0x04009E6D RID: 40557
	private bool llMn1uG6f9D;

	// Token: 0x04009E6E RID: 40558
	private bool rMAn1yK0AFB;

	// Token: 0x04009E6F RID: 40559
	private bool WOOn1VmnwDN;

	// Token: 0x04009E70 RID: 40560
	private bool dTun1h5fmGd;

	// Token: 0x04009E71 RID: 40561
	private int QmKn1Koae7Y;

	// Token: 0x02001EA1 RID: 7841
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$46395 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B741 RID: 46913 RVA: 0x013B4F88 File Offset: 0x013B3188
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$46395(Hashtable data, M973_PirateCave3 self_)
		{
			if (119355 - 44804 != 74552)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (164472 - 88200 == 76272)
				{
					base..ctor();
					if (284537 - 417413 == -132876)
					{
						this.$data$46405 = data;
						if (102318 - 498055 == -395737)
						{
							this.$self_$46406 = self_;
							if (292130 - 489886 == -197756)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x013B5044 File Offset: 0x013B3244
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave3.$onGameEvent$46395.$(this.$data$46405, this.$self_$46406);
		}

		// Token: 0x0600B743 RID: 46915 RVA: 0x013B5058 File Offset: 0x013B3258
		internal static bool tYq8L1ttsQ4j7b6TFs08()
		{
			return true;
		}

		// Token: 0x0600B744 RID: 46916 RVA: 0x013B505C File Offset: 0x013B325C
		internal static bool t1yGXott94Aa0FusOdMe()
		{
			return false;
		}

		// Token: 0x04009E72 RID: 40562
		internal Hashtable $data$46405;

		// Token: 0x04009E73 RID: 40563
		internal M973_PirateCave3 $self_$46406;

		// Token: 0x02001EA2 RID: 7842
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B745 RID: 46917 RVA: 0x013B5060 File Offset: 0x013B3260
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave3 self_)
			{
				if (126141 - 290872 != -164730)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (150685 - 475895 != -325209)
					{
						base..ctor();
						if (88804 - 237725 != -148920)
						{
							this.$data$46403 = data;
							if (124351 - 65784 == 58567)
							{
								this.$self_$46404 = self_;
								if (57125 - 421784 != -364658)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B746 RID: 46918 RVA: 0x013B511C File Offset: 0x013B331C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (221144 - 373291 != -152146)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_EE5;
					case 2:
						Game.savePlayer();
						if (42436 - 55770 != -13334)
						{
							continue;
						}
						Game.mGameStage = 4;
						if (53853 - 436010 != -382157)
						{
							continue;
						}
						Application.LoadLevel("M973_PirateCave4");
						if (201504 - 85056 != 116448)
						{
							continue;
						}
						goto IL_173;
					default:
						if (181139 - 320939 == -139799)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (273797 - 540115 != -266317)
						{
							goto Block_96;
						}
						continue;
					}
					else
					{
						this.$returnCode$46396 = RuntimeServices.UnboxInt32(this.$data$46403[141]);
						if (55162 - 539572 == -484409)
						{
							continue;
						}
						this.$returnValue$46397 = RuntimeServices.UnboxInt32(this.$data$46403[145]);
						if (79332 - 598914 != -519582)
						{
							continue;
						}
						this.$ownerID$46398 = RuntimeServices.UnboxInt32(this.$data$46403[43]);
						if (230197 - 47211 != 182986)
						{
							continue;
						}
						this.$$switch$8658$46399 = this.$returnCode$46396;
						if (207629 - 36300 != 171329)
						{
							continue;
						}
						if (this.$$switch$8658$46399 == 9731)
						{
							if (79996 - 371550 == -291553)
							{
								continue;
							}
						}
						else if (this.$$switch$8658$46399 == -9731)
						{
							if (221637 - 532842 == -311204)
							{
								continue;
							}
							if (this.$self_$46404.Ifhn19PP7lf < 3)
							{
								if (123612 - 521239 == -397626)
								{
									continue;
								}
								this.$self_$46404.Ifhn19PP7lf = 3;
								if (136808 - 452794 != -315986)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (42821 - 382663 == -339841)
								{
									continue;
								}
								this.$mGameGui$46400 = (GameGui)this.$self_$46404.GetComponent(typeof(GameGui));
								if (238185 - 439302 != -201117)
								{
									continue;
								}
								this.$mGameGui$46400.close();
								if (286107 - 144886 == 141222)
								{
									continue;
								}
								this.$self_$46404.SendMessage("fadeOut");
								if (152299 - 216462 != -64163)
								{
									continue;
								}
								break;
							}
						}
						else if (this.$$switch$8658$46399 == 9732)
						{
							if (256498 - 550922 != -294424)
							{
								continue;
							}
						}
						else if (this.$$switch$8658$46399 == -9732)
						{
							if (279495 - 120713 != 158782)
							{
								continue;
							}
							this.$$switch$8654$46401 = this.$returnValue$46397;
							if (76869 - 394815 != -317946)
							{
								continue;
							}
							if (this.$$switch$8654$46401 == 1)
							{
								if (88224 - 471239 != -383015)
								{
									continue;
								}
								this.$self_$46404.llMn1uG6f9D = true;
								if (187443 - 346211 != -158768)
								{
									continue;
								}
								this.$self_$46404.StartCoroutine_Auto(this.$self_$46404.PirateEvent1());
								if (196126 - 387659 == -191532)
								{
									continue;
								}
							}
							else if (this.$$switch$8654$46401 == 2)
							{
								if (33756 - 209983 != -176227)
								{
									continue;
								}
								this.$self_$46404.replaceActor("PirateFish", 1, PlayerData.UID == this.$ownerID$46398);
								if (5262 - 244977 != -239715)
								{
									continue;
								}
								this.$self_$46404.replaceActor("PirateFish", 2, PlayerData.UID == this.$ownerID$46398);
								if (19491 - 585450 != -565959)
								{
									continue;
								}
								this.$self_$46404.replaceActor("PirateCrawfish", 1, PlayerData.UID == this.$ownerID$46398);
								if (227398 - 520306 != -292908)
								{
									continue;
								}
								this.$self_$46404.replaceActor("PirateCrawfish", 2, PlayerData.UID == this.$ownerID$46398);
								if (264558 - 291803 == -27244)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$46398)
								{
									if (66120 - 500938 == -434817)
									{
										continue;
									}
									this.$self_$46404.spawnActor("PirateFish", 7, 1);
									if (28782 - 155887 != -127105)
									{
										continue;
									}
									this.$self_$46404.spawnActor("PirateCrawfish", 7, 2);
									if (200531 - 484651 == -284119)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8654$46401 == 3)
							{
								if (121166 - 136073 != -14907)
								{
									continue;
								}
								if (!this.$self_$46404.WOOn1VmnwDN)
								{
									if (273737 - 390110 != -116373)
									{
										continue;
									}
									this.$self_$46404.WOOn1VmnwDN = true;
									if (139227 - 94564 != 44663)
									{
										continue;
									}
									this.$self_$46404.OnUsePirateSwitch(1);
									if (233901 - 464829 == -230927)
									{
										continue;
									}
									this.$self_$46404.OnOpenPirateGate(1);
									if (157738 - 306889 == -149150)
									{
										continue;
									}
								}
								if (PlayerData.UID == this.$ownerID$46398)
								{
									if (161222 - 514412 != -353190)
									{
										continue;
									}
									this.$self_$46404.spawnActor("PirateFish", 7, 11);
									if (196247 - 421788 != -225541)
									{
										continue;
									}
									this.$self_$46404.spawnActor("PirateFish", 7, 12);
									if (35060 - 29129 != 5931)
									{
										continue;
									}
									this.$self_$46404.spawnActor("PirateCrawfish", 7, 13);
									if (58141 - 272288 == -214146)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8654$46401 == 4)
							{
								if (150490 - 211701 == -61210)
								{
									continue;
								}
								if (!this.$self_$46404.dTun1h5fmGd)
								{
									if (164971 - 201214 == -36242)
									{
										continue;
									}
									this.$self_$46404.dTun1h5fmGd = true;
									if (47211 - 353735 != -306524)
									{
										continue;
									}
									this.$self_$46404.OnUsePirateSwitch(2);
									if (207873 - 492235 == -284361)
									{
										continue;
									}
									this.$self_$46404.OnOpenPirateGate(2);
									if (117901 - 451406 == -333504)
									{
										continue;
									}
								}
								if (PlayerData.UID == this.$ownerID$46398)
								{
									if (219445 - 2132 == 217314)
									{
										continue;
									}
									this.$self_$46404.spawnActor("PirateFish", 7, 21);
									if (281179 - 151603 == 129577)
									{
										continue;
									}
									this.$self_$46404.spawnActor("PirateFish", 7, 22);
									if (85359 - 81814 == 3546)
									{
										continue;
									}
									this.$self_$46404.spawnActor("PirateFish", 7, 23);
									if (105446 - 396338 == -290891)
									{
										continue;
									}
									this.$self_$46404.spawnActor("PirateCrawfish", 7, 24);
									if (289864 - 276781 != 13083)
									{
										continue;
									}
									this.$self_$46404.spawnActor("PirateCrawfish", 7, 25);
									if (90619 - 272770 == -182150)
									{
										continue;
									}
									this.$self_$46404.spawnActor("PirateCrawfish", 7, 26);
									if (18056 - 531904 != -513848)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8654$46401 == 5)
							{
								if (251781 - 367444 != -115663)
								{
									continue;
								}
								this.$self_$46404.rMAn1yK0AFB = true;
								if (175858 - 347693 != -171835)
								{
									continue;
								}
								this.$self_$46404.StartCoroutine_Auto(this.$self_$46404.PirateEvent2());
								if (240439 - 516528 == -276088)
								{
									continue;
								}
							}
							else if (this.$$switch$8654$46401 == 6)
							{
								if (19213 - 438821 != -419608)
								{
									continue;
								}
								this.$self_$46404.replaceActor("PirateFish", 11, PlayerData.UID == this.$ownerID$46398);
								if (119239 - 216472 == -97232)
								{
									continue;
								}
								this.$self_$46404.replaceActor("PirateFish", 12, PlayerData.UID == this.$ownerID$46398);
								if (259910 - 432682 == -172771)
								{
									continue;
								}
								this.$self_$46404.replaceActor("PirateFish", 13, PlayerData.UID == this.$ownerID$46398);
								if (42331 - 399392 == -357060)
								{
									continue;
								}
								this.$self_$46404.replaceActor("PirateFish", 14, PlayerData.UID == this.$ownerID$46398);
								if (233552 - 60138 != 173414)
								{
									continue;
								}
								this.$self_$46404.replaceActor("PirateFish", 15, PlayerData.UID == this.$ownerID$46398);
								if (34307 - 433755 != -399448)
								{
									continue;
								}
								this.$self_$46404.replaceActor("PirateCrawfish", 11, PlayerData.UID == this.$ownerID$46398);
								if (296637 - 497637 != -201000)
								{
									continue;
								}
								this.$self_$46404.replaceActor("PirateCrawfish", 12, PlayerData.UID == this.$ownerID$46398);
								if (71188 - 473986 != -402798)
								{
									continue;
								}
								this.$self_$46404.replaceActor("PirateCrawfish", 13, PlayerData.UID == this.$ownerID$46398);
								if (175612 - 194949 != -19337)
								{
									continue;
								}
								this.$self_$46404.replaceActor("PirateCrawfish", 14, PlayerData.UID == this.$ownerID$46398);
								if (223067 - 568841 == -345773)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$46398)
								{
									if (54430 - 221572 != -167142)
									{
										continue;
									}
									this.$self_$46404.spawnActor("PirateFish", 7, 31);
									if (244506 - 255112 == -10605)
									{
										continue;
									}
									this.$self_$46404.spawnActor("PirateFish", 7, 32);
									if (263741 - 60542 == 203200)
									{
										continue;
									}
									this.$self_$46404.spawnActor("PirateCrawfish", 7, 33);
									if (139014 - 553611 != -414597)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8658$46399 == 9734)
						{
							if (290999 - 335398 == -44398)
							{
								continue;
							}
							this.$$switch$8656$46402 = this.$returnValue$46397;
							if (282251 - 315696 != -33445)
							{
								continue;
							}
							if (this.$$switch$8656$46402 != 3)
							{
								if (184717 - 435945 != -251228)
								{
									continue;
								}
								if (this.$$switch$8656$46402 != 4)
								{
									goto IL_746;
								}
								if (268918 - 285175 != -16257)
								{
									continue;
								}
							}
							this.$self_$46404.AGnn1WArWnY = this.$self_$46404.AGnn1WArWnY + 1;
							if (279716 - 515536 != -235820)
							{
								continue;
							}
							Debug.Log("Pirate Eliminate: " + this.$self_$46404.AGnn1WArWnY);
							if (83089 - 109493 != -26404)
							{
								continue;
							}
							this.$self_$46404.SendMessage("newGameMessage", "Pirate Eliminated : " + this.$self_$46404.AGnn1WArWnY + "/27");
							if (138569 - 22409 == 116161)
							{
								continue;
							}
							if (this.$self_$46404.AGnn1WArWnY >= 27)
							{
								if (97976 - 493024 != -395048)
								{
									continue;
								}
								if (this.$self_$46404.Ifhn19PP7lf < 2)
								{
									if (61473 - 444031 != -382558)
									{
										continue;
									}
									this.$self_$46404.Ifhn19PP7lf = 2;
									if (219189 - 91785 != 127404)
									{
										continue;
									}
									this.$self_$46404.StartCoroutine_Auto(this.$self_$46404.PirateEvent3());
									if (30475 - 572652 == -542176)
									{
										continue;
									}
								}
							}
							IL_746:;
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$46396);
							if (264148 - 579029 != -314881)
							{
								continue;
							}
						}
					}
					IL_DF0:
					this.YieldDefault(1);
					if (121532 - 468094 != -346562)
					{
						continue;
					}
					goto IL_EE5;
					IL_173:
					goto IL_DF0;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_96:
				IL_EE5:
				return false;
			}

			// Token: 0x0600B747 RID: 46919 RVA: 0x013B6020 File Offset: 0x013B4220
			internal static bool aNoIXJtt1UPkYMy7EH4Y()
			{
				return true;
			}

			// Token: 0x0600B748 RID: 46920 RVA: 0x013B6024 File Offset: 0x013B4224
			internal static bool a8YP2ott4siwLtScnIqK()
			{
				return false;
			}

			// Token: 0x04009E74 RID: 40564
			internal int $returnCode$46396;

			// Token: 0x04009E75 RID: 40565
			internal int $returnValue$46397;

			// Token: 0x04009E76 RID: 40566
			internal int $ownerID$46398;

			// Token: 0x04009E77 RID: 40567
			internal int $$switch$8658$46399;

			// Token: 0x04009E78 RID: 40568
			internal GameGui $mGameGui$46400;

			// Token: 0x04009E79 RID: 40569
			internal int $$switch$8654$46401;

			// Token: 0x04009E7A RID: 40570
			internal int $$switch$8656$46402;

			// Token: 0x04009E7B RID: 40571
			internal Hashtable $data$46403;

			// Token: 0x04009E7C RID: 40572
			internal M973_PirateCave3 $self_$46404;
		}
	}

	// Token: 0x02001EA3 RID: 7843
	[CompilerGenerated]
	[Serializable]
	internal sealed class $PirateEvent1$46407 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B749 RID: 46921 RVA: 0x013B6028 File Offset: 0x013B4228
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $PirateEvent1$46407(M973_PirateCave3 self_)
		{
			if (258207 - 130934 != 127273)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (140042 - 64309 == 75733)
				{
					base..ctor();
					if (259205 - 410474 == -151269)
					{
						this.$self_$46411 = self_;
						if (219432 - 543178 != -323745)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B74A RID: 46922 RVA: 0x013B60C0 File Offset: 0x013B42C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave3.$PirateEvent1$46407.$(this.$self_$46411);
		}

		// Token: 0x0600B74B RID: 46923 RVA: 0x013B60D0 File Offset: 0x013B42D0
		internal static bool l2hSIAttzPTNjIsjeeHk()
		{
			return true;
		}

		// Token: 0x0600B74C RID: 46924 RVA: 0x013B60D4 File Offset: 0x013B42D4
		internal static bool oY9MobtNaMEZJfhOJk56()
		{
			return false;
		}

		// Token: 0x04009E7D RID: 40573
		internal M973_PirateCave3 $self_$46411;

		// Token: 0x02001EA4 RID: 7844
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B74D RID: 46925 RVA: 0x013B60D8 File Offset: 0x013B42D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave3 self_)
			{
				if (218108 - 204311 != 13798)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (30129 - 190144 != -160014)
					{
						base..ctor();
						if (267102 - 201363 != 65740)
						{
							this.$self_$46410 = self_;
							if (207120 - 131344 != 75777)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B74E RID: 46926 RVA: 0x013B6170 File Offset: 0x013B4370
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (39814 - 481255 != -441440)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4FB;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (36664 - 284623 != -247959)
							{
								continue;
							}
							goto IL_5C;
						}
						else
						{
							this.$mStoryGui$46409 = (StoryGui)this.$self_$46410.GetComponent(typeof(StoryGui));
							if (25813 - 158405 != -132592)
							{
								continue;
							}
							if (!this.$mStoryGui$46409)
							{
								goto IL_18A;
							}
							if (80544 - 252960 != -172416)
							{
								continue;
							}
							this.$mStoryGui$46409.startStoryMessage("none", "Pirate Fish", eTalkType.enemy);
							if (41071 - 447313 != -406242)
							{
								continue;
							}
							goto IL_406;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (53014 - 260409 != -207395)
							{
								continue;
							}
							goto IL_27B;
						}
						else
						{
							this.$mStoryGui$46409.newStoryMessage("none", "Pirate Fish", Language.getMessage("M973_PirateCave", 301), eTalkType.enemy);
							if (76836 - 313770 != -236933)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (90826 - 309906 != -219079)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46409.newStoryMessage("none", "Pirate Crawfish", Language.getMessage("M973_PirateCave", 302), eTalkType.enemy);
							if (44200 - 234298 != -190097)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (291452 - 233615 != 57838)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46409.newStoryMessage("none", "Pirate Fish", Language.getMessage("M973_PirateCave", 303), eTalkType.enemy);
							if (236506 - 348528 != -112022)
							{
								continue;
							}
							goto IL_2FB;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (116998 - 93747 != 23251)
							{
								continue;
							}
							goto IL_160;
						}
						else
						{
							Game.sendMissionEvent(9732, 2);
							if (174724 - 153805 == 20920)
							{
								continue;
							}
							this.$mStoryGui$46409.close();
							if (179940 - 462360 != -282420)
							{
								continue;
							}
							this.$self_$46410.eFxn1F52uCr.enabled = true;
							if (198301 - 199724 != -1422)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (295354 - 545274 != -249920)
							{
								continue;
							}
							goto IL_21B;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (62808 - 300934 == -238125)
							{
								continue;
							}
							this.$mGameGui$46408.enabled = true;
							if (78225 - 417677 != -339451)
							{
								goto IL_18A;
							}
							continue;
						}
						break;
					default:
						if (47775 - 460479 != -412704)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (188882 - 406832 != -217950)
					{
						continue;
					}
					this.$mGameGui$46408 = (GameGui)this.$self_$46410.GetComponent(typeof(GameGui));
					if (263767 - 110916 != 152851)
					{
						continue;
					}
					if (this.$mGameGui$46408)
					{
						if (138880 - 113157 == 25724)
						{
							continue;
						}
						this.$mGameGui$46408.close();
						if (76370 - 78755 != -2385)
						{
							continue;
						}
					}
					this.$self_$46410.eFxn1F52uCr.StartCoroutine_Auto(this.$self_$46410.eFxn1F52uCr.slerpToObject("EventCamera1", (float)2));
					if (134485 - 248118 != -113632)
					{
						break;
					}
					continue;
					IL_18A:
					this.YieldDefault(1);
					if (280611 - 397830 != -117218)
					{
						goto Block_10;
					}
				}
				return this.Yield(2, new WaitForSeconds(1.5f));
				IL_5C:
				goto IL_4FB;
				Block_7:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_160:
				Block_10:
				IL_21B:
				Block_16:
				IL_27B:
				goto IL_4FB;
				Block_17:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_19:
				goto IL_4FB;
				IL_2FB:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_25:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_406:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_4FB:
				return false;
			}

			// Token: 0x0600B74F RID: 46927 RVA: 0x013B668C File Offset: 0x013B488C
			internal static bool ijHMlBtN5hhDs4e3Yajg()
			{
				return true;
			}

			// Token: 0x0600B750 RID: 46928 RVA: 0x013B6690 File Offset: 0x013B4890
			internal static bool qwZtN0tNpoGuyCKkBbh8()
			{
				return false;
			}

			// Token: 0x04009E7E RID: 40574
			internal GameGui $mGameGui$46408;

			// Token: 0x04009E7F RID: 40575
			internal StoryGui $mStoryGui$46409;

			// Token: 0x04009E80 RID: 40576
			internal M973_PirateCave3 $self_$46410;
		}
	}

	// Token: 0x02001EA5 RID: 7845
	[CompilerGenerated]
	[Serializable]
	internal sealed class $PirateEvent2$46412 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B751 RID: 46929 RVA: 0x013B6694 File Offset: 0x013B4894
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $PirateEvent2$46412(M973_PirateCave3 self_)
		{
			if (285299 - 96011 != 189289)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (61523 - 233493 != -171969)
				{
					base..ctor();
					if (115445 - 202856 == -87411)
					{
						this.$self_$46416 = self_;
						if (166851 - 577843 == -410992)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B752 RID: 46930 RVA: 0x013B672C File Offset: 0x013B492C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave3.$PirateEvent2$46412.$(this.$self_$46416);
		}

		// Token: 0x0600B753 RID: 46931 RVA: 0x013B673C File Offset: 0x013B493C
		internal static bool freJcitNVZCcaLb9eunQ()
		{
			return true;
		}

		// Token: 0x0600B754 RID: 46932 RVA: 0x013B6740 File Offset: 0x013B4940
		internal static bool EFUMYAtNtc9hQQicFkKZ()
		{
			return false;
		}

		// Token: 0x04009E81 RID: 40577
		internal M973_PirateCave3 $self_$46416;

		// Token: 0x02001EA6 RID: 7846
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B755 RID: 46933 RVA: 0x013B6744 File Offset: 0x013B4944
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave3 self_)
			{
				if (284422 - 391092 != -106669)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (126344 - 116609 != 9736)
					{
						base..ctor();
						if (54004 - 467137 != -413132)
						{
							this.$self_$46415 = self_;
							if (144118 - 581309 == -437191)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B756 RID: 46934 RVA: 0x013B67DC File Offset: 0x013B49DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (285429 - 447888 != -162459)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_60E;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (166280 - 132804 != 33477)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46414 = (StoryGui)this.$self_$46415.GetComponent(typeof(StoryGui));
							if (288431 - 208375 != 80056)
							{
								continue;
							}
							if (!this.$mStoryGui$46414)
							{
								goto IL_2CB;
							}
							if (165083 - 291158 == -126074)
							{
								continue;
							}
							this.$mStoryGui$46414.startStoryMessage("none", "Pirate Fish", eTalkType.enemy);
							if (90810 - 131618 != -40807)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (9896 - 399787 != -389891)
							{
								continue;
							}
							goto IL_515;
						}
						else
						{
							this.$mStoryGui$46414.newStoryMessage("none", "Pirate Crawfish", Language.getMessage("M973_PirateCave", 311), eTalkType.enemy);
							if (231442 - 158250 != 73192)
							{
								continue;
							}
							goto IL_97;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (214267 - 319308 != -105040)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46414.newStoryMessage("none", "Pirate Crawfish", Language.getMessage("M973_PirateCave", 312), eTalkType.enemy);
							if (97727 - 224464 != -126737)
							{
								continue;
							}
							goto IL_D2;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (36461 - 251165 != -214703)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46414.newStoryMessage("none", "Pirate Crawfish", Language.getMessage("M973_PirateCave", 313), eTalkType.enemy);
							if (286271 - 7302 != 278970)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (185958 - 104751 != 81208)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46414.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 314), eTalkType.friend);
							if (120401 - 309193 != -188792)
							{
								continue;
							}
							goto IL_5C;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (142005 - 557849 != -415843)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46414.newStoryMessage("none", "Pirate Crawfish", Language.getMessage("M973_PirateCave", 315), eTalkType.enemy);
							if (166697 - 363943 != -197245)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (97697 - 76570 != 21128)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9732, 6);
							if (151499 - 77263 != 74236)
							{
								continue;
							}
							this.$mStoryGui$46414.close();
							if (111703 - 532669 == -420965)
							{
								continue;
							}
							this.$self_$46415.eFxn1F52uCr.enabled = true;
							if (252750 - 58826 != 193925)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (163310 - 107637 != 55673)
							{
								continue;
							}
							goto IL_197;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (285671 - 392762 != -107091)
							{
								continue;
							}
							this.$mGameGui$46413.enabled = true;
							if (65266 - 548682 != -483416)
							{
								continue;
							}
							goto IL_2CB;
						}
						break;
					default:
						if (203510 - 505244 != -301734)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (46998 - 484928 != -437930)
					{
						continue;
					}
					this.$mGameGui$46413 = (GameGui)this.$self_$46415.GetComponent(typeof(GameGui));
					if (34008 - 530957 != -496949)
					{
						continue;
					}
					if (this.$mGameGui$46413)
					{
						if (141083 - 184793 == -43709)
						{
							continue;
						}
						this.$mGameGui$46413.close();
						if (90104 - 50656 != 39448)
						{
							continue;
						}
					}
					this.$self_$46415.eFxn1F52uCr.StartCoroutine_Auto(this.$self_$46415.eFxn1F52uCr.slerpToObject("EventCamera2", (float)2));
					if (202602 - 594768 != -392166)
					{
						continue;
					}
					goto IL_5A9;
					IL_2CB:
					this.YieldDefault(1);
					if (225628 - 286348 == -60720)
					{
						goto IL_60E;
					}
				}
				IL_5C:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_4:
				goto IL_60E;
				IL_97:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_6:
				goto IL_60E;
				IL_D2:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_8:
				goto IL_60E;
				Block_10:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_197:
				goto IL_60E;
				Block_13:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_17:
				goto IL_60E;
				Block_24:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_28:
				goto IL_60E;
				Block_31:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_515:
				goto IL_60E;
				IL_5A9:
				return this.Yield(2, new WaitForSeconds(1.5f));
				Block_38:
				IL_60E:
				return false;
			}

			// Token: 0x0600B757 RID: 46935 RVA: 0x013B6E0C File Offset: 0x013B500C
			internal static bool ODh52ntNNTo3RhMjh3sW()
			{
				return true;
			}

			// Token: 0x0600B758 RID: 46936 RVA: 0x013B6E10 File Offset: 0x013B5010
			internal static bool mouEkutNYcBOxJAexhPn()
			{
				return false;
			}

			// Token: 0x04009E82 RID: 40578
			internal GameGui $mGameGui$46413;

			// Token: 0x04009E83 RID: 40579
			internal StoryGui $mStoryGui$46414;

			// Token: 0x04009E84 RID: 40580
			internal M973_PirateCave3 $self_$46415;
		}
	}

	// Token: 0x02001EA7 RID: 7847
	[CompilerGenerated]
	[Serializable]
	internal sealed class $PirateEvent3$46417 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B759 RID: 46937 RVA: 0x013B6E14 File Offset: 0x013B5014
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $PirateEvent3$46417(M973_PirateCave3 self_)
		{
			if (92692 - 130025 != -37332)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (109086 - 500559 != -391472)
				{
					base..ctor();
					if (180977 - 279560 != -98582)
					{
						this.$self_$46420 = self_;
						if (34997 - 598022 != -563024)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B75A RID: 46938 RVA: 0x013B6EAC File Offset: 0x013B50AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave3.$PirateEvent3$46417.$(this.$self_$46420);
		}

		// Token: 0x0600B75B RID: 46939 RVA: 0x013B6EBC File Offset: 0x013B50BC
		internal static bool aknIwwtNcYJNgpqLHheo()
		{
			return true;
		}

		// Token: 0x0600B75C RID: 46940 RVA: 0x013B6EC0 File Offset: 0x013B50C0
		internal static bool aT0IkutNUjCh9Ebat4Hb()
		{
			return false;
		}

		// Token: 0x04009E85 RID: 40581
		internal M973_PirateCave3 $self_$46420;

		// Token: 0x02001EA8 RID: 7848
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B75D RID: 46941 RVA: 0x013B6EC4 File Offset: 0x013B50C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave3 self_)
			{
				if (32521 - 302560 != -270039)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284977 - 557747 != -272769)
					{
						base..ctor();
						if (227799 - 157994 == 69805)
						{
							this.$self_$46419 = self_;
							if (191531 - 292441 != -100909)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B75E RID: 46942 RVA: 0x013B6F5C File Offset: 0x013B515C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (297271 - 298991 != -1720)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1A;
					case 1:
						goto IL_211;
					case 2:
						Game.mGameState = eGameState.AllHold;
						if (133210 - 297388 != -164177)
						{
							this.$mGameGui$46418 = (GameGui)this.$self_$46419.GetComponent(typeof(GameGui));
							if (198196 - 440512 != -242315)
							{
								if (this.$mGameGui$46418)
								{
									if (224843 - 46247 != 178596)
									{
										break;
									}
									this.$mGameGui$46418.close();
									if (151337 - 488836 == -337498)
									{
										break;
									}
								}
								this.$self_$46419.eFxn1F52uCr.StartCoroutine_Auto(this.$self_$46419.eFxn1F52uCr.slerpToObject("EventCamera3", (float)2));
								if (24912 - 422297 != -397384)
								{
									goto Block_3;
								}
							}
						}
						break;
					case 3:
						this.$self_$46419.OnOpenPirateGate(3);
						if (97286 - 205514 == -108228)
						{
							goto IL_129;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (292331 - 334612 == -42281)
							{
								goto IL_1E7;
							}
						}
						else
						{
							Game.sendMissionEvent(9731, 4);
							if (280783 - 417406 == -136623)
							{
								this.YieldDefault(1);
								if (216093 - 317788 != -101694)
								{
									goto Block_9;
								}
							}
						}
						break;
					default:
						if (143328 - 509057 == -365729)
						{
							goto IL_1A;
						}
						break;
					}
				}
				IL_1A:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_3:
				return this.Yield(3, new WaitForSeconds((float)2));
				IL_129:
				return this.Yield(4, new WaitForSeconds((float)3));
				Block_9:
				IL_1E7:
				IL_211:
				return false;
			}

			// Token: 0x0600B75F RID: 46943 RVA: 0x013B718C File Offset: 0x013B538C
			internal static bool B04JBQtNTxkfYB4QeQOs()
			{
				return true;
			}

			// Token: 0x0600B760 RID: 46944 RVA: 0x013B7190 File Offset: 0x013B5390
			internal static bool RTnPmRtN3H1wqykGtLO3()
			{
				return false;
			}

			// Token: 0x04009E86 RID: 40582
			internal GameGui $mGameGui$46418;

			// Token: 0x04009E87 RID: 40583
			internal M973_PirateCave3 $self_$46419;
		}
	}

	// Token: 0x02001EA9 RID: 7849
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$46421 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B761 RID: 46945 RVA: 0x013B7194 File Offset: 0x013B5394
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$46421(M973_PirateCave3 self_)
		{
			if (277673 - 218036 != 59638)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (78631 - 140207 != -61575)
				{
					base..ctor();
					if (213858 - 146020 != 67839)
					{
						this.$self_$46424 = self_;
						if (254004 - 374091 == -120087)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B762 RID: 46946 RVA: 0x013B722C File Offset: 0x013B542C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave3.$StartGame$46421.$(this.$self_$46424);
		}

		// Token: 0x0600B763 RID: 46947 RVA: 0x013B723C File Offset: 0x013B543C
		internal static bool e3rCCDtNXQjl2c1URWie()
		{
			return true;
		}

		// Token: 0x0600B764 RID: 46948 RVA: 0x013B7240 File Offset: 0x013B5440
		internal static bool QnvkU4tNQAvLgjlP5ERJ()
		{
			return false;
		}

		// Token: 0x04009E88 RID: 40584
		internal M973_PirateCave3 $self_$46424;

		// Token: 0x02001EAA RID: 7850
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B765 RID: 46949 RVA: 0x013B7244 File Offset: 0x013B5444
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave3 self_)
			{
				if (168797 - 185185 != -16387)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (166720 - 181239 == -14519)
					{
						base..ctor();
						if (214006 - 68305 != 145702)
						{
							this.$self_$46423 = self_;
							if (158055 - 456108 == -298053)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B766 RID: 46950 RVA: 0x013B72DC File Offset: 0x013B54DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (257479 - 503716 != -246237)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1B9;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (515 - 192349 == -191833)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (215292 - 117817 == 97476)
						{
							continue;
						}
						this.YieldDefault(1);
						if (177069 - 362036 != -184967)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (195347 - 459888 != -264541)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (69056 - 36101 != 32956)
					{
						Game.mGameState = eGameState.Start;
						if (143768 - 104612 != 39157)
						{
							Game.mStateTime = Time.time;
							if (90460 - 156810 != -66349)
							{
								this.$mGameGui$46422 = (GameGui)this.$self_$46423.GetComponent(typeof(GameGui));
								if (131950 - 428606 != -296655)
								{
									this.$mGameGui$46422.enabled = true;
									if (96394 - 538167 == -441773)
									{
										this.$self_$46423.SendMessage("fadeIn");
										if (79847 - 64873 == 14974)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x0600B767 RID: 46951 RVA: 0x013B74B4 File Offset: 0x013B56B4
			internal static bool wNUOrutNkEEQuAq3jUMG()
			{
				return true;
			}

			// Token: 0x0600B768 RID: 46952 RVA: 0x013B74B8 File Offset: 0x013B56B8
			internal static bool kUjhMZtNGW6gEcklvKnD()
			{
				return false;
			}

			// Token: 0x04009E89 RID: 40585
			internal GameGui $mGameGui$46422;

			// Token: 0x04009E8A RID: 40586
			internal M973_PirateCave3 $self_$46423;
		}
	}

	// Token: 0x02001EAB RID: 7851
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46425 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B769 RID: 46953 RVA: 0x013B74BC File Offset: 0x013B56BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46425(M973_PirateCave3 self_)
		{
			if (100359 - 477972 != -377613)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (91439 - 12663 == 78776)
				{
					base..ctor();
					if (237680 - 449198 == -211518)
					{
						this.$self_$46430 = self_;
						if (152686 - 507078 == -354392)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B76A RID: 46954 RVA: 0x013B7554 File Offset: 0x013B5754
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave3.$onDeadPlayer$46425.$(this.$self_$46430);
		}

		// Token: 0x0600B76B RID: 46955 RVA: 0x013B7564 File Offset: 0x013B5764
		internal static bool aUbaJItNHkuKlOu5HS1T()
		{
			return true;
		}

		// Token: 0x0600B76C RID: 46956 RVA: 0x013B7568 File Offset: 0x013B5768
		internal static bool eY9eGCtNWm6dulZrZxAQ()
		{
			return false;
		}

		// Token: 0x04009E8B RID: 40587
		internal M973_PirateCave3 $self_$46430;

		// Token: 0x02001EAC RID: 7852
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B76D RID: 46957 RVA: 0x013B756C File Offset: 0x013B576C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave3 self_)
			{
				if (259702 - 94334 != 165368)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (276178 - 488002 != -211823)
					{
						base..ctor();
						if (246792 - 210416 != 36377)
						{
							this.$self_$46429 = self_;
							if (127878 - 290113 != -162234)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B76E RID: 46958 RVA: 0x013B7604 File Offset: 0x013B5804
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (43069 - 59639 != -16570)
				{
				}
				for (;;)
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
							if (216989 - 58537 != 158452)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_159;
							}
							if (206122 - 164787 != 41335)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (118444 - 551869 != -433425)
						{
							continue;
						}
						this.$mStoryGui$46426 = (StoryGui)this.$self_$46429.GetComponent(typeof(StoryGui));
						if (97828 - 382434 != -284606)
						{
							continue;
						}
						if (this.$mStoryGui$46426)
						{
							if (153448 - 21149 != 132299)
							{
								continue;
							}
							this.$mStoryGui$46426.close();
							if (95200 - 209758 != -114558)
							{
								continue;
							}
						}
						this.$mChangeGui$46427 = (ChangeGui)this.$self_$46429.GetComponent(typeof(ChangeGui));
						if (78814 - 575467 == -496652)
						{
							continue;
						}
						if (this.$mChangeGui$46427)
						{
							if (238021 - 304438 == -66416)
							{
								continue;
							}
							this.$mChangeGui$46427.close();
							if (141698 - 202466 == -60767)
							{
								continue;
							}
						}
						this.$mGameGui$46428 = (GameGui)this.$self_$46429.GetComponent(typeof(GameGui));
						if (18582 - 85253 != -66671)
						{
							continue;
						}
						if (this.$mGameGui$46428)
						{
							if (61331 - 525277 == -463945)
							{
								continue;
							}
							if (!this.$mGameGui$46428.enabled)
							{
								if (91731 - 473752 == -382020)
								{
									continue;
								}
								this.$mGameGui$46428.enabled = true;
								if (174906 - 532825 != -357919)
								{
									continue;
								}
							}
							this.$mGameGui$46428.openDeadMenu();
							if (153601 - 40210 == 113392)
							{
								continue;
							}
						}
						IL_159:
						this.YieldDefault(1);
						if (168326 - 362243 != -193916)
						{
							goto Block_11;
						}
						continue;
					default:
						if (279660 - 487384 != -207724)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (2583 - 476488 != -473904)
					{
						goto Block_18;
					}
				}
				Block_11:
				goto IL_2F9;
				Block_18:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B76F RID: 46959 RVA: 0x013B791C File Offset: 0x013B5B1C
			internal static bool pDNgEJtNAKPr77GfpVor()
			{
				return true;
			}

			// Token: 0x0600B770 RID: 46960 RVA: 0x013B7920 File Offset: 0x013B5B20
			internal static bool rypmQitNlhWN334pJVlg()
			{
				return false;
			}

			// Token: 0x04009E8C RID: 40588
			internal StoryGui $mStoryGui$46426;

			// Token: 0x04009E8D RID: 40589
			internal ChangeGui $mChangeGui$46427;

			// Token: 0x04009E8E RID: 40590
			internal GameGui $mGameGui$46428;

			// Token: 0x04009E8F RID: 40591
			internal M973_PirateCave3 $self_$46429;
		}
	}

	// Token: 0x02001EAD RID: 7853
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46431 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B771 RID: 46961 RVA: 0x013B7924 File Offset: 0x013B5B24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46431(Hashtable data, M973_PirateCave3 self_)
		{
			if (299116 - 249511 != 49605)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (178899 - 373501 != -194601)
				{
					base..ctor();
					if (259816 - 37250 != 222567)
					{
						this.$data$46436 = data;
						if (2994 - 262653 != -259658)
						{
							this.$self_$46437 = self_;
							if (86919 - 132890 != -45970)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B772 RID: 46962 RVA: 0x013B79E0 File Offset: 0x013B5BE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave3.$onChangePlayer$46431.$(this.$data$46436, this.$self_$46437);
		}

		// Token: 0x0600B773 RID: 46963 RVA: 0x013B79F4 File Offset: 0x013B5BF4
		internal static bool AZAfIGtNyFsXgpuGvGi6()
		{
			return true;
		}

		// Token: 0x0600B774 RID: 46964 RVA: 0x013B79F8 File Offset: 0x013B5BF8
		internal static bool aLfA8ntNShOsgWbIRF4p()
		{
			return false;
		}

		// Token: 0x04009E90 RID: 40592
		internal Hashtable $data$46436;

		// Token: 0x04009E91 RID: 40593
		internal M973_PirateCave3 $self_$46437;

		// Token: 0x02001EAE RID: 7854
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B775 RID: 46965 RVA: 0x013B79FC File Offset: 0x013B5BFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave3 self_)
			{
				if (39317 - 259448 != -220131)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (220723 - 575024 != -354300)
					{
						base..ctor();
						if (29537 - 252755 != -223217)
						{
							this.$data$46434 = data;
							if (245287 - 255363 != -10075)
							{
								this.$self_$46435 = self_;
								if (187420 - 115847 == 71573)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B776 RID: 46966 RVA: 0x013B7AB8 File Offset: 0x013B5CB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (82657 - 191907 != -109249)
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
							if (262690 - 17070 != 245620)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (197551 - 11916 != 185635)
							{
								continue;
							}
							this.$mGameGui$46433 = (GameGui)this.$self_$46435.GetComponent(typeof(GameGui));
							if (240800 - 586126 == -345325)
							{
								continue;
							}
							this.$mGameGui$46433.enabled = true;
							if (162608 - 361893 == -199284)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (2100 - 357785 != -355685)
						{
							continue;
						}
						goto IL_205;
					default:
						if (86747 - 175886 == -89138)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (10045 - 264491 != -254445)
					{
						this.$self_$46435.SendMessage("onCreatePlayer", this.$data$46434);
						if (71090 - 390942 != -319851)
						{
							this.$mChangeGui$46432 = (ChangeGui)this.$self_$46435.GetComponent(typeof(ChangeGui));
							if (282488 - 369321 != -86832)
							{
								if (!this.$mChangeGui$46432.enabled)
								{
									break;
								}
								if (126019 - 561076 != -435056)
								{
									this.$mChangeGui$46432.close();
									if (83001 - 239851 == -156850)
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

			// Token: 0x0600B777 RID: 46967 RVA: 0x013B7CDC File Offset: 0x013B5EDC
			internal static bool PWkAxhtNopcsBpMY5M5R()
			{
				return true;
			}

			// Token: 0x0600B778 RID: 46968 RVA: 0x013B7CE0 File Offset: 0x013B5EE0
			internal static bool O1p2ohtNE7FESAGnnoLo()
			{
				return false;
			}

			// Token: 0x04009E92 RID: 40594
			internal ChangeGui $mChangeGui$46432;

			// Token: 0x04009E93 RID: 40595
			internal GameGui $mGameGui$46433;

			// Token: 0x04009E94 RID: 40596
			internal Hashtable $data$46434;

			// Token: 0x04009E95 RID: 40597
			internal M973_PirateCave3 $self_$46435;
		}
	}

	// Token: 0x02001EAF RID: 7855
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46438 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B779 RID: 46969 RVA: 0x013B7CE4 File Offset: 0x013B5EE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46438(Hashtable data, M973_PirateCave3 self_)
		{
			if (159501 - 343266 != -183765)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131059 - 136779 != -5719)
				{
					base..ctor();
					if (230305 - 59763 != 170543)
					{
						this.$data$46446 = data;
						if (124621 - 358752 == -234131)
						{
							this.$self_$46447 = self_;
							if (101399 - 308380 != -206980)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B77A RID: 46970 RVA: 0x013B7DA0 File Offset: 0x013B5FA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave3.$onGameComplete$46438.$(this.$data$46446, this.$self_$46447);
		}

		// Token: 0x0600B77B RID: 46971 RVA: 0x013B7DB4 File Offset: 0x013B5FB4
		internal static bool qldTK9tN2D6BOJpeELyB()
		{
			return true;
		}

		// Token: 0x0600B77C RID: 46972 RVA: 0x013B7DB8 File Offset: 0x013B5FB8
		internal static bool uYoPpItN8B91l2KCQJOp()
		{
			return false;
		}

		// Token: 0x04009E96 RID: 40598
		internal Hashtable $data$46446;

		// Token: 0x04009E97 RID: 40599
		internal M973_PirateCave3 $self_$46447;

		// Token: 0x02001EB0 RID: 7856
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B77D RID: 46973 RVA: 0x013B7DBC File Offset: 0x013B5FBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave3 self_)
			{
				if (25276 - 371080 != -345803)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (57806 - 400357 != -342550)
					{
						base..ctor();
						if (196494 - 19181 == 177313)
						{
							this.$data$46444 = data;
							if (146909 - 441705 != -294795)
							{
								this.$self_$46445 = self_;
								if (86826 - 488261 == -401435)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B77E RID: 46974 RVA: 0x013B7E78 File Offset: 0x013B6078
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (151168 - 36169 != 115000)
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
						this.$mCompleteGui$46440 = (CompleteGui)this.$self_$46445.GetComponent(typeof(CompleteGui));
						if (121072 - 217242 == -96169)
						{
							continue;
						}
						this.$mCompleteGui$46440.Init();
						if (177492 - 276301 == -98808)
						{
							continue;
						}
						this.$mCompleteGui$46440.readData(this.$data$46444);
						if (261168 - 542913 != -281745)
						{
							continue;
						}
						if (this.$result$46439 == 1)
						{
							if (17177 - 132714 != -115537)
							{
								continue;
							}
							this.$mCompleteGui$46440.displayResult(eCompleteType.Success);
							if (69033 - 263604 != -194571)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46440.displayResult(eCompleteType.Failed);
							if (84309 - 133508 != -49199)
							{
								continue;
							}
						}
						this.$mGameGui$46441 = (GameGui)this.$self_$46445.GetComponent(typeof(GameGui));
						if (41749 - 544472 != -502723)
						{
							continue;
						}
						this.$mStoryGui$46442 = (StoryGui)this.$self_$46445.GetComponent(typeof(StoryGui));
						if (79269 - 229788 == -150518)
						{
							continue;
						}
						this.$mChangeGui$46443 = (ChangeGui)this.$self_$46445.GetComponent(typeof(ChangeGui));
						if (148207 - 59187 != 89020)
						{
							continue;
						}
						if (this.$mGameGui$46441)
						{
							if (201654 - 37619 == 164036)
							{
								continue;
							}
							this.$mGameGui$46441.close();
							if (169688 - 366921 == -197232)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46442)
						{
							if (2559 - 587377 != -584818)
							{
								continue;
							}
							this.$mStoryGui$46442.close();
							if (91155 - 131080 == -39924)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46443)
						{
							if (52862 - 97382 == -44519)
							{
								continue;
							}
							this.$mChangeGui$46443.disable();
							if (140802 - 325952 == -185149)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (276018 - 387895 != -111877)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (233069 - 445715 != -212646)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46444[31]);
					if (206726 - 226307 == -19581)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (34054 - 556350 == -522296)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (190860 - 463057 == -272197)
							{
								this.$result$46439 = RuntimeServices.UnboxInt32(this.$data$46444[31]);
								if (67091 - 250916 != -183824)
								{
									goto Block_27;
								}
							}
						}
					}
				}
				goto IL_3DB;
				Block_27:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600B77F RID: 46975 RVA: 0x013B8274 File Offset: 0x013B6474
			internal static bool DJplMDtNZTQD4Spbi05S()
			{
				return true;
			}

			// Token: 0x0600B780 RID: 46976 RVA: 0x013B8278 File Offset: 0x013B6478
			internal static bool VOGN3XtNC8L6xATqwyfY()
			{
				return false;
			}

			// Token: 0x04009E98 RID: 40600
			internal int $result$46439;

			// Token: 0x04009E99 RID: 40601
			internal CompleteGui $mCompleteGui$46440;

			// Token: 0x04009E9A RID: 40602
			internal GameGui $mGameGui$46441;

			// Token: 0x04009E9B RID: 40603
			internal StoryGui $mStoryGui$46442;

			// Token: 0x04009E9C RID: 40604
			internal ChangeGui $mChangeGui$46443;

			// Token: 0x04009E9D RID: 40605
			internal Hashtable $data$46444;

			// Token: 0x04009E9E RID: 40606
			internal M973_PirateCave3 $self_$46445;
		}
	}

	// Token: 0x02001EB1 RID: 7857
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46448 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B781 RID: 46977 RVA: 0x013B827C File Offset: 0x013B647C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46448(M973_PirateCave3 self_)
		{
			if (66598 - 333228 != -266629)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (111255 - 454917 != -343661)
				{
					base..ctor();
					if (192006 - 293066 != -101059)
					{
						this.$self_$46452 = self_;
						if (144470 - 69261 != 75210)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B782 RID: 46978 RVA: 0x013B8314 File Offset: 0x013B6514
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave3.$ReturnToTown$46448.$(this.$self_$46452);
		}

		// Token: 0x0600B783 RID: 46979 RVA: 0x013B8324 File Offset: 0x013B6524
		internal static bool ltAxlmtNLA6gkot7YNwl()
		{
			return true;
		}

		// Token: 0x0600B784 RID: 46980 RVA: 0x013B8328 File Offset: 0x013B6528
		internal static bool akdLl4tNO9BLrUph4D5d()
		{
			return false;
		}

		// Token: 0x04009E9F RID: 40607
		internal M973_PirateCave3 $self_$46452;

		// Token: 0x02001EB2 RID: 7858
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B785 RID: 46981 RVA: 0x013B832C File Offset: 0x013B652C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave3 self_)
			{
				if (95027 - 549722 != -454694)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (220441 - 200919 != 19523)
					{
						base..ctor();
						if (9246 - 211686 == -202440)
						{
							this.$self_$46451 = self_;
							if (41351 - 138227 == -96876)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B786 RID: 46982 RVA: 0x013B83C4 File Offset: 0x013B65C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (103622 - 248176 != -144553)
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
						this.$self_$46451.LeaveGame();
						if (216301 - 557901 == -341599)
						{
							continue;
						}
						this.YieldDefault(1);
						if (244619 - 581102 != -336482)
						{
							goto Block_18;
						}
						continue;
					default:
						if (125994 - 205710 != -79716)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (136764 - 1649 != 135116)
					{
						Game.mStateTime = Time.time;
						if (155945 - 200746 != -44800)
						{
							this.$$switch$8664$46449 = PlayerData.SaveGuild;
							if (86840 - 210224 == -123384)
							{
								if (this.$$switch$8664$46449 == 1)
								{
									if (214288 - 97180 == 117109)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (245005 - 315260 != -70255)
									{
										continue;
									}
								}
								else if (this.$$switch$8664$46449 == 2)
								{
									if (57789 - 269625 == -211835)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (239175 - 299278 != -60103)
									{
										continue;
									}
								}
								else if (this.$$switch$8664$46449 == 3)
								{
									if (266924 - 551923 == -284998)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (97269 - 310703 == -213433)
									{
										continue;
									}
								}
								else if (this.$$switch$8664$46449 == 4)
								{
									if (167541 - 515517 != -347976)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (263551 - 408234 != -144683)
									{
										continue;
									}
								}
								else if (this.$$switch$8664$46449 == 5)
								{
									if (218007 - 276836 != -58829)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (140733 - 302636 != -161903)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (170157 - 199833 == -29675)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (8875 - 28603 == -19727)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (86764 - 515299 == -428534)
									{
										continue;
									}
								}
								this.$mGameGui$46450 = (GameGui)this.$self_$46451.GetComponent(typeof(GameGui));
								if (283543 - 549569 != -266025)
								{
									if (this.$mGameGui$46450)
									{
										if (284644 - 400230 != -115586)
										{
											continue;
										}
										this.$mGameGui$46450.close();
										if (148471 - 378459 != -229988)
										{
											continue;
										}
									}
									this.$self_$46451.SendMessage("fadeOut");
									if (244413 - 149567 != 94847)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_18:
				IL_3AD:
				return false;
			}

			// Token: 0x0600B787 RID: 46983 RVA: 0x013B8790 File Offset: 0x013B6990
			internal static bool ltQLMDtNmsxc5lwlh7Vl()
			{
				return true;
			}

			// Token: 0x0600B788 RID: 46984 RVA: 0x013B8794 File Offset: 0x013B6994
			internal static bool tAqHejtNFLcHEeFXX1Ii()
			{
				return false;
			}

			// Token: 0x04009EA0 RID: 40608
			internal int $$switch$8664$46449;

			// Token: 0x04009EA1 RID: 40609
			internal GameGui $mGameGui$46450;

			// Token: 0x04009EA2 RID: 40610
			internal M973_PirateCave3 $self_$46451;
		}
	}

	// Token: 0x02001EB3 RID: 7859
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46453 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B789 RID: 46985 RVA: 0x013B8798 File Offset: 0x013B6998
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46453(M973_PirateCave3 self_)
		{
			if (11785 - 383477 != -371691)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (83686 - 149603 != -65916)
				{
					base..ctor();
					if (132276 - 287369 != -155092)
					{
						this.$self_$46456 = self_;
						if (230707 - 423481 == -192774)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B78A RID: 46986 RVA: 0x013B8830 File Offset: 0x013B6A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave3.$ReturnToGuild$46453.$(this.$self_$46456);
		}

		// Token: 0x0600B78B RID: 46987 RVA: 0x013B8840 File Offset: 0x013B6A40
		internal static bool oT7eUFtNMIB3YehLHQ2S()
		{
			return true;
		}

		// Token: 0x0600B78C RID: 46988 RVA: 0x013B8844 File Offset: 0x013B6A44
		internal static bool cTFxCBtNxs2THNkPwe8U()
		{
			return false;
		}

		// Token: 0x04009EA3 RID: 40611
		internal M973_PirateCave3 $self_$46456;

		// Token: 0x02001EB4 RID: 7860
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B78D RID: 46989 RVA: 0x013B8848 File Offset: 0x013B6A48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave3 self_)
			{
				if (161947 - 87250 != 74698)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (185764 - 364098 == -178334)
					{
						base..ctor();
						if (207218 - 18836 != 188383)
						{
							this.$self_$46455 = self_;
							if (117779 - 172395 != -54615)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B78E RID: 46990 RVA: 0x013B88E0 File Offset: 0x013B6AE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91843 - 536872 != -445029)
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
						this.$self_$46455.LeaveGame();
						if (166907 - 540133 == -373225)
						{
							continue;
						}
						this.YieldDefault(1);
						if (32753 - 599024 != -566270)
						{
							goto IL_1BD;
						}
						continue;
					default:
						if (173744 - 78392 == 95353)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (25936 - 364118 != -338181)
					{
						Game.mStateTime = Time.time;
						if (265950 - 587752 != -321801)
						{
							Game.mNextGameCode = 31;
							if (199253 - 460130 == -260877)
							{
								this.$mGameGui$46454 = (GameGui)this.$self_$46455.GetComponent(typeof(GameGui));
								if (189210 - 127621 != 61590)
								{
									if (this.$mGameGui$46454)
									{
										if (9560 - 10254 == -693)
										{
											continue;
										}
										this.$mGameGui$46454.close();
										if (131282 - 139836 != -8554)
										{
											continue;
										}
									}
									this.$self_$46455.SendMessage("fadeOut");
									if (75023 - 20099 != 54925)
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

			// Token: 0x0600B78F RID: 46991 RVA: 0x013B8ABC File Offset: 0x013B6CBC
			internal static bool IyWyRZtNg9F8K3tDYbKY()
			{
				return true;
			}

			// Token: 0x0600B790 RID: 46992 RVA: 0x013B8AC0 File Offset: 0x013B6CC0
			internal static bool frtr9OtNf9NxrfmJYKOF()
			{
				return false;
			}

			// Token: 0x04009EA4 RID: 40612
			internal GameGui $mGameGui$46454;

			// Token: 0x04009EA5 RID: 40613
			internal M973_PirateCave3 $self_$46455;
		}
	}

	// Token: 0x02001EB5 RID: 7861
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46457 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B791 RID: 46993 RVA: 0x013B8AC4 File Offset: 0x013B6CC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46457(M973_PirateCave3 self_)
		{
			if (210136 - 98689 != 111448)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (223319 - 313325 == -90006)
				{
					base..ctor();
					if (4848 - 145227 != -140378)
					{
						this.$self_$46460 = self_;
						if (62519 - 97928 == -35409)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B792 RID: 46994 RVA: 0x013B8B5C File Offset: 0x013B6D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave3.$ReturnToCamp$46457.$(this.$self_$46460);
		}

		// Token: 0x0600B793 RID: 46995 RVA: 0x013B8B6C File Offset: 0x013B6D6C
		internal static bool pNd48UtNnUgLImlrQaNO()
		{
			return true;
		}

		// Token: 0x0600B794 RID: 46996 RVA: 0x013B8B70 File Offset: 0x013B6D70
		internal static bool ALKDUutN6ytV7aHi1tqd()
		{
			return false;
		}

		// Token: 0x04009EA6 RID: 40614
		internal M973_PirateCave3 $self_$46460;

		// Token: 0x02001EB6 RID: 7862
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B795 RID: 46997 RVA: 0x013B8B74 File Offset: 0x013B6D74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave3 self_)
			{
				if (209037 - 309034 != -99996)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (4613 - 430734 == -426121)
					{
						base..ctor();
						if (255357 - 387783 == -132426)
						{
							this.$self_$46459 = self_;
							if (259236 - 133372 != 125865)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B796 RID: 46998 RVA: 0x013B8C0C File Offset: 0x013B6E0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (122350 - 37403 != 84947)
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
						this.$self_$46459.LeaveGame();
						if (224108 - 511409 == -287300)
						{
							continue;
						}
						this.YieldDefault(1);
						if (230842 - 343987 != -113145)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (150641 - 502882 == -352240)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (42049 - 455090 != -413040)
					{
						Game.mStateTime = Time.time;
						if (222859 - 343655 == -120796)
						{
							Game.mNextGameCode = 33;
							if (90004 - 341325 != -251320)
							{
								this.$mGameGui$46458 = (GameGui)this.$self_$46459.GetComponent(typeof(GameGui));
								if (113736 - 154973 != -41236)
								{
									if (this.$mGameGui$46458)
									{
										if (37704 - 114926 != -77222)
										{
											continue;
										}
										this.$mGameGui$46458.close();
										if (78598 - 18312 != 60286)
										{
											continue;
										}
									}
									this.$self_$46459.SendMessage("fadeOut");
									if (140787 - 401909 != -261121)
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

			// Token: 0x0600B797 RID: 46999 RVA: 0x013B8DE8 File Offset: 0x013B6FE8
			internal static bool tsXVL9tNiAjfxLhscfau()
			{
				return true;
			}

			// Token: 0x0600B798 RID: 47000 RVA: 0x013B8DEC File Offset: 0x013B6FEC
			internal static bool DqmRxRtNKlooRcHBQ88p()
			{
				return false;
			}

			// Token: 0x04009EA7 RID: 40615
			internal GameGui $mGameGui$46458;

			// Token: 0x04009EA8 RID: 40616
			internal M973_PirateCave3 $self_$46459;
		}
	}
}
