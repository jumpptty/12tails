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

// Token: 0x02001542 RID: 5442
[Serializable]
public class M405_WindValleyEntrance2 : MonoBehaviour
{
	// Token: 0x06007DF7 RID: 32247 RVA: 0x01044A6C File Offset: 0x01042C6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M405_WindValleyEntrance2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007DF8 RID: 32248 RVA: 0x01044A7C File Offset: 0x01042C7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (236393 - 569786 != -333392)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (245848 - 524260 == -278412)
			{
				Game.mGameType = 5;
				if (275024 - 259643 == 15381)
				{
					if (Chat.Initialized)
					{
						if (251286 - 441914 == -190628)
						{
							Chat.ChatDisplay.Clear();
							if (8184 - 379714 == -371530)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (268949 - 142619 != 126331)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007DF9 RID: 32249 RVA: 0x01044B60 File Offset: 0x01042D60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (144298 - 225628 != -81329)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (296006 - 343066 != -47059)
				{
					if (Game.mNextGameCode != 405)
					{
						break;
					}
					if (50351 - 251492 == -201141)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (197100 - 132864 == 64236)
						{
							Game.nextGame();
							if (129692 - 185292 != -55599)
							{
								this.hQNcFik4Kga = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (183742 - 410414 == -226672)
								{
									this.WxscF8JpITB = PhotonClient.Connection;
									if (152003 - 163257 == -11254)
									{
										PhotonClient.ActorNrList.Clear();
										if (96408 - 294869 != -198460)
										{
											this.InitGame();
											if (172709 - 538936 != -366226)
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
				if (179941 - 32283 == 147658)
				{
					Game.mGameType = 99;
					if (80153 - 438953 != -358799)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007DFA RID: 32250 RVA: 0x01044D18 File Offset: 0x01042F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (93490 - 277620 != -184130)
		{
		}
		for (;;)
		{
			if (this.WxscF8JpITB == null)
			{
				if (258350 - 394134 != -135783)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (188252 - 491908 != -303655)
				{
					if (mGameState == eGameState.Init)
					{
						if (273541 - 249465 != 24077)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (69382 - 418988 == -349606)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (47015 - 425559 != -378543)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (96771 - 333842 != -237070)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (259244 - 41376 == 217868)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (154172 - 357596 != -203423)
						{
							if (Time.time > this.DDwcFDJxUnj)
							{
								if (81608 - 444381 != -362773)
								{
									continue;
								}
								Game.mGameMana++;
								if (110671 - 17251 != 93420)
								{
									continue;
								}
								this.DDwcFDJxUnj = Time.time + (float)12;
								if (187449 - 160519 == 26931)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (45259 - 72257 != -26998)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (8066 - 506880 != -498814)
									{
										continue;
									}
									this.audio.Play();
									if (227656 - 497248 == -269591)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (244691 - 115589 != 129103)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (286205 - 174196 == 112009)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (197873 - 322466 == -124593)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (230739 - 443609 != -212869)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (121239 - 331782 == -210543)
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
						if (54015 - 525709 != -471693)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007DFB RID: 32251 RVA: 0x01045094 File Offset: 0x01043294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (182300 - 211344 != -29044)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (123040 - 267910 == -144870)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (181390 - 14599 != 166792)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (80458 - 347470 != -267011)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (131083 - 247615 != -116531)
						{
							int num4 = num;
							if (150096 - 118820 == 31276)
							{
								if (num4 == 4051)
								{
									if (46858 - 34265 != 12594)
									{
										break;
									}
								}
								else if (num4 == 4052)
								{
									if (155028 - 150964 == 4064)
									{
										break;
									}
								}
								else
								{
									if (num4 != 4053)
									{
										break;
									}
									if (206073 - 283980 == -77907)
									{
										this.YWQcFjlnIMI++;
										if (100969 - 117591 != -16621)
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

	// Token: 0x06007DFC RID: 32252 RVA: 0x01045248 File Offset: 0x01043448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M405_WindValleyEntrance2.$StartEvent$38899(this).GetEnumerator();
	}

	// Token: 0x06007DFD RID: 32253 RVA: 0x01045258 File Offset: 0x01043458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (102138 - 10509 != 91630)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (51328 - 148217 == -96889)
			{
				CharacterControl characterControl = null;
				if (126696 - 76083 == 50613)
				{
					if (mPlayer)
					{
						if (74915 - 438169 != -363254)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (28454 - 179297 == -150842)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (126963 - 174191 != -47227)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (53664 - 595121 != -541456)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (28420 - 254971 != -226550)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (40046 - 146472 != -106426)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (135147 - 117470 == 17678)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (42041 - 475947 != -433906)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (115440 - 151875 != -36434)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (205897 - 521597 != -315699)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (146556 - 177340 == -30784)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (21700 - 45246 == -23546)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (284059 - 460586 != -176526)
								{
									if (!changeGui)
									{
										break;
									}
									if (35688 - 450246 == -414558)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (148302 - 457410 == -309107)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (99455 - 158364 != -58909)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (88989 - 553991 == -465002)
										{
											gameGui.close();
											if (90769 - 317226 != -226456)
											{
												changeGui.enabled = true;
												if (119957 - 330933 == -210976)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (260368 - 190883 == 69485)
													{
														if (!gameObject)
														{
															break;
														}
														if (132989 - 516171 != -383181)
														{
															if (!mPlayer)
															{
																break;
															}
															if (87434 - 536027 != -448592)
															{
																Debug.Log("UseLifeAltar");
																if (260119 - 275631 == -15512)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (217132 - 514732 != -297599)
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

	// Token: 0x06007DFE RID: 32254 RVA: 0x010456B8 File Offset: 0x010438B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (262584 - 48887 != 213697)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (214942 - 458319 != -243376)
			{
				Time.timeScale = 1f;
				if (107921 - 441218 != -333296)
				{
					Hashtable customOpParameters = new Hashtable();
					if (45742 - 460462 != -414719)
					{
						this.WxscF8JpITB.OpCustom(52, customOpParameters, true);
						if (251301 - 424574 != -173272)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007DFF RID: 32255 RVA: 0x01045784 File Offset: 0x01043984
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (30514 - 328271 != -297756)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (26084 - 155093 != -129008)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (120340 - 234238 != -113897)
				{
					Game.mGameState = eGameState.Setup;
					if (144434 - 362518 != -218083)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007E00 RID: 32256 RVA: 0x01045828 File Offset: 0x01043A28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (520 - 291887 != -291366)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (91817 - 457535 != -365717)
			{
				if (num == PlayerData.UID)
				{
					if (59660 - 417888 == -358228)
					{
						this.SetupActors();
						if (114371 - 61329 == 53042)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (230819 - 231374 == -555)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007E01 RID: 32257 RVA: 0x010458F8 File Offset: 0x01043AF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (87475 - 377466 != -289990)
		{
		}
		for (;;)
		{
			IL_109:
			Debug.Log("Creating Actors");
			if (264080 - 303330 == -39250)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (156738 - 409455 != -252716)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (270565 - 367216 != -96650)
						{
							int i = 0;
							if (24078 - 594801 == -570723)
							{
								CharacterControl[] array2 = array;
								if (163227 - 596989 != -433761)
								{
									int length = array2.Length;
									if (117731 - 383761 != -266029)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (53229 - 595747 != -542518)
												{
													goto IL_109;
												}
												string type = array2[i].Type;
												if (216228 - 574570 != -358342)
												{
													goto IL_109;
												}
												if (type == "LeoBug_g")
												{
													if (13738 - 407362 == -393623)
													{
														goto IL_109;
													}
													this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
													if (137729 - 429909 == -292179)
													{
														goto IL_109;
													}
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (101181 - 60752 == 40430)
												{
													goto IL_109;
												}
												this.kvtcFo15lTB++;
												if (46046 - 476249 != -430203)
												{
													goto IL_109;
												}
											}
											i++;
											if (27682 - 247737 != -220055)
											{
												goto IL_109;
											}
										}
										if (247476 - 146142 != 101335)
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
						if (189396 - 4837 == 184559)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E02 RID: 32258 RVA: 0x01045B94 File Offset: 0x01043D94
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (105026 - 531516 != -426490)
		{
		}
		for (;;)
		{
			IL_5A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (55528 - 329438 != -273909)
			{
				int i = 0;
				if (42377 - 56655 != -14277)
				{
					CharacterControl[] array2 = array;
					if (144150 - 48867 == 95283)
					{
						int length = array2.Length;
						if (174558 - 595488 != -420929)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (127727 - 221249 == -93521)
								{
									goto IL_5A;
								}
								i++;
								if (239064 - 197879 == 41186)
								{
									goto IL_5A;
								}
							}
							if (192188 - 252710 != -60521)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E03 RID: 32259 RVA: 0x01045CC4 File Offset: 0x01043EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (143982 - 390380 != -246397)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (163137 - 61868 == 101269)
			{
				Game.mGameState = eGameState.Ready;
				if (9414 - 103671 == -94257)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (237768 - 317944 != -80175 && 265279 - 1593 != 263687)
					{
						GameObject gameObject = null;
						if (135490 - 250742 == -115252)
						{
							if (playerSlot <= 1)
							{
								goto IL_2DE;
							}
							if (132341 - 563824 == -431482)
							{
								continue;
							}
							if (playerSlot > 6)
							{
								goto IL_2DE;
							}
							if (97051 - 190309 == -93257)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (123184 - 417836 == -294651)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (248624 - 195683 == 52942)
							{
								continue;
							}
							IL_51:
							if (gameObject2)
							{
								if (225843 - 347957 == -122113)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (294885 - 582498 == -287612)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (2323 - 558680 != -556357)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (222646 - 226844 == -4197)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (124737 - 135267 == -10529)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (3293 - 532214 == -528920)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (289125 - 335037 == -45911)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (297495 - 472647 != -175152)
							{
								continue;
							}
							break;
							IL_2DE:
							gameObject2 = GameObject.Find("StartPoint1");
							if (96390 - 450050 == -353660)
							{
								goto IL_51;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E04 RID: 32260 RVA: 0x01045FE8 File Offset: 0x010441E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (233228 - 229557 != 3672)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (242790 - 79867 == 162923)
			{
				Game.mGameState = eGameState.Start;
				if (55875 - 346084 == -290209)
				{
					Game.mStateTime = Time.time;
					if (258986 - 306700 != -47713)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (120297 - 434597 != -314299)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E05 RID: 32261 RVA: 0x010460B0 File Offset: 0x010442B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007E06 RID: 32262 RVA: 0x010460B4 File Offset: 0x010442B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (170971 - 382530 != -211559)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (166814 - 124016 != 42799)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (197731 - 559446 != -361714)
				{
					hashtable.Add(43, PlayerData.UID);
					if (88732 - 136991 == -48259)
					{
						hashtable.Add(73, nType);
						if (170727 - 234754 != -64026)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (120458 - 319156 == -198698)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (298445 - 480370 == -181925)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (207031 - 105779 != 101253)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (228045 - 88746 != 139300)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (52366 - 93465 != -41098)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (153462 - 493745 == -340283)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (153073 - 384325 == -231252)
													{
														this.WxscF8JpITB.OpCustom(63, hashtable, true);
														if (14999 - 273526 != -258526)
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

	// Token: 0x06007E07 RID: 32263 RVA: 0x01046398 File Offset: 0x01044598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (289424 - 417071 != -127646)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (13392 - 114584 != -101191)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (268536 - 309223 != -40686)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (63227 - 538085 == -474858)
						{
							if (this.kvtcFo15lTB <= 0)
							{
								break;
							}
							if (286646 - 225699 != 60948)
							{
								this.kvtcFo15lTB--;
								if (132452 - 195349 != -62896)
								{
									if (this.kvtcFo15lTB != 0)
									{
										break;
									}
									if (20879 - 200869 != -179989)
									{
										Game.setGameState(eGameState.Ready);
										if (224051 - 91261 == 132790)
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
						if (101647 - 260059 == -158412)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (44943 - 359368 == -314425)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E08 RID: 32264 RVA: 0x01046528 File Offset: 0x01044728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06007E09 RID: 32265 RVA: 0x0104653C File Offset: 0x0104473C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (50128 - 190155 != -140027)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (48042 - 129603 != -81560)
			{
				if (!characterControl)
				{
					break;
				}
				if (91970 - 341241 != -249270)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (62138 - 377584 == -315446)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (142942 - 297111 == -154169)
						{
							string type = characterControl.Type;
							if (166249 - 87708 != 78542)
							{
								if (!(type == "LeoBug_g"))
								{
									break;
								}
								if (297751 - 367626 != -69874)
								{
									Game.sendMissionEvent(4053, 0);
									if (67891 - 230387 == -162496)
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

	// Token: 0x06007E0A RID: 32266 RVA: 0x01046688 File Offset: 0x01044888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (47519 - 157844 != -110324)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (155329 - 474442 != -319112)
			{
				hashtable.Add(71, CID);
				if (294591 - 74284 != 220308)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (161779 - 233872 == -72093)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (221019 - 224484 == -3465)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (18878 - 282739 != -263860)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (292253 - 22821 != 269433)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (297729 - 56529 != 241201)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (277583 - 343216 == -65633)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (49457 - 149849 != -100391)
											{
												this.WxscF8JpITB.OpCustom(61, hashtable, true);
												if (212700 - 146649 != 66052)
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

	// Token: 0x06007E0B RID: 32267 RVA: 0x01046914 File Offset: 0x01044B14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (261824 - 245973 != 15851)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (4987 - 434249 != -429261)
			{
				if (!gameObject)
				{
					break;
				}
				if (100552 - 216958 != -116405)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (278520 - 505278 == -226758)
					{
						playerCameraControl.target = gameObject;
						if (246247 - 228597 != 17651)
						{
							if (Game.useAdvanceMode)
							{
								if (211845 - 251323 == -39477)
								{
									continue;
								}
								Game.loadPlayer();
								if (248489 - 196090 == 52400)
								{
									continue;
								}
							}
							this.StartGame();
							if (175763 - 61400 == 114363)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E0C RID: 32268 RVA: 0x01046A48 File Offset: 0x01044C48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (14015 - 266578 != -252563)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (151154 - 90927 == 60227)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (20890 - 266173 == -245283)
				{
					gameGui.ResetTeamBar();
					if (166816 - 7147 != 159670)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007E0D RID: 32269 RVA: 0x01046AF4 File Offset: 0x01044CF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M405_WindValleyEntrance2.$onDeadPlayer$38905(this).GetEnumerator();
	}

	// Token: 0x06007E0E RID: 32270 RVA: 0x01046B04 File Offset: 0x01044D04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (3019 - 528069 != -525049)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (69486 - 389025 != -319538)
			{
				this.hQNcFik4Kga.target = Game.mPlayer;
				if (230112 - 380379 != -150266)
				{
					this.hQNcFik4Kga.enabled = true;
					if (252516 - 578791 == -326275)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (287101 - 590396 == -303294)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (280231 - 544028 != -263797)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (143852 - 372523 != -228670)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (94201 - 83689 == 10512)
							{
								if (!gameGui)
								{
									break;
								}
								if (224305 - 588091 != -363785)
								{
									gameGui.enabled = true;
									if (208212 - 181155 != 27058)
									{
										gameGui.closeDeadMenu();
										if (297445 - 96586 == 200859)
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

	// Token: 0x06007E0F RID: 32271 RVA: 0x01046CB0 File Offset: 0x01044EB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (61852 - 286182 != -224330)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (59821 - 134801 != -74979)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (228985 - 340783 == -111798)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (48305 - 522622 == -474317)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007E10 RID: 32272 RVA: 0x01046D74 File Offset: 0x01044F74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007E11 RID: 32273 RVA: 0x01046DA0 File Offset: 0x01044FA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (2708 - 439161 != -436452)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (124037 - 55569 == 68468)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (8992 - 405536 == -396544)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (171249 - 578727 != -407477)
					{
						Hashtable hashtable = new Hashtable();
						if (275554 - 248301 != 27254)
						{
							hashtable.Add(43, PlayerData.UID);
							if (299114 - 19800 == 279314)
							{
								hashtable.Add(71, nCID);
								if (261754 - 496033 == -234279)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (162154 - 444949 != -282794)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (191695 - 490682 != -298986)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (50214 - 100538 == -50324)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (132544 - 356062 != -223517)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (148193 - 509320 == -361127)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (203956 - 289895 != -85938)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (192598 - 218108 == -25510)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (270302 - 330387 == -60085)
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

	// Token: 0x06007E12 RID: 32274 RVA: 0x010470C0 File Offset: 0x010452C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M405_WindValleyEntrance2.$onChangePlayer$38911(data, this).GetEnumerator();
	}

	// Token: 0x06007E13 RID: 32275 RVA: 0x010470D0 File Offset: 0x010452D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M405_WindValleyEntrance2.$onGameComplete$38918(data, this).GetEnumerator();
	}

	// Token: 0x06007E14 RID: 32276 RVA: 0x010470E0 File Offset: 0x010452E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M405_WindValleyEntrance2.$ReturnToTown$38928(this).GetEnumerator();
	}

	// Token: 0x06007E15 RID: 32277 RVA: 0x010470F0 File Offset: 0x010452F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M405_WindValleyEntrance2.$ReturnToGuild$38933(this).GetEnumerator();
	}

	// Token: 0x06007E16 RID: 32278 RVA: 0x01047100 File Offset: 0x01045300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M405_WindValleyEntrance2.$ReturnToCamp$38937(this).GetEnumerator();
	}

	// Token: 0x06007E17 RID: 32279 RVA: 0x01047110 File Offset: 0x01045310
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (299067 - 419969 != -120901)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (23704 - 174694 != -150989)
			{
				Hashtable hashtable = new Hashtable();
				if (228764 - 14170 == 214594)
				{
					hashtable.Add(43, PlayerData.UID);
					if (56317 - 150032 != -93714)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (33451 - 210264 != -176812)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E18 RID: 32280 RVA: 0x010471E8 File Offset: 0x010453E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007E19 RID: 32281 RVA: 0x010471FC File Offset: 0x010453FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (15083 - 298545 != -283462)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (122379 - 368045 != -245665)
			{
				Hashtable hashtable = new Hashtable();
				if (127910 - 274831 == -146921)
				{
					if (Game.mNextGameCode == 30)
					{
						if (161147 - 505015 != -343868)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (223191 - 110460 != 112731)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (254478 - 451085 == -196606)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (197241 - 178496 != 18745)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (67948 - 37638 == 30311)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (172960 - 265966 == -93005)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (160568 - 386211 == -225642)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (262497 - 268878 == -6380)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (132748 - 196412 != -63664)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (2313 - 174737 != -172424)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (17405 - 462084 == -444678)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (242447 - 40206 != 202241)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (40744 - 564204 != -523460)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (25607 - 43997 != -18390)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (191013 - 284442 == -93428)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (33962 - 155915 == -121952)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (39569 - 536147 != -496578)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (249865 - 497841 != -247976)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (22384 - 16606 == 5779)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (228874 - 70478 != 158396)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (71746 - 330385 != -258639)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (255112 - 109980 == 145133)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (47505 - 229386 == -181880)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (51977 - 176086 == -124108)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (105374 - 376780 != -271406)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (65124 - 123371 != -58247)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (180660 - 134786 != 45874)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (122253 - 443608 == -321354)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (192940 - 210913 == -17973)
					{
						this.WxscF8JpITB.OpCustom(42, hashtable, true);
						if (17115 - 321531 == -304416)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E1A RID: 32282 RVA: 0x010477B0 File Offset: 0x010459B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007E1B RID: 32283 RVA: 0x010477C0 File Offset: 0x010459C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007E1C RID: 32284 RVA: 0x010477C4 File Offset: 0x010459C4
	internal static bool WTNLAopIgERGcxU3QDVb()
	{
		return true;
	}

	// Token: 0x06007E1D RID: 32285 RVA: 0x010477C8 File Offset: 0x010459C8
	internal static bool WNUUY0pIflBs5nD9jEkU()
	{
		return false;
	}

	// Token: 0x04007E31 RID: 32305
	private LitePeer WxscF8JpITB;

	// Token: 0x04007E32 RID: 32306
	private PlayerCameraControl hQNcFik4Kga;

	// Token: 0x04007E33 RID: 32307
	private float DDwcFDJxUnj;

	// Token: 0x04007E34 RID: 32308
	private int vfycFmDM2AC;

	// Token: 0x04007E35 RID: 32309
	private int YWQcFjlnIMI;

	// Token: 0x04007E36 RID: 32310
	private int kvtcFo15lTB;

	// Token: 0x02001543 RID: 5443
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$38899 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007E1E RID: 32286 RVA: 0x010477CC File Offset: 0x010459CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$38899(M405_WindValleyEntrance2 self_)
		{
			if (201362 - 249128 != -47765)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (277549 - 536175 == -258626)
				{
					base..ctor();
					if (112541 - 115558 == -3017)
					{
						this.$self_$38904 = self_;
						if (274016 - 451373 == -177357)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007E1F RID: 32287 RVA: 0x01047864 File Offset: 0x01045A64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance2.$StartEvent$38899.$(this.$self_$38904);
		}

		// Token: 0x06007E20 RID: 32288 RVA: 0x01047874 File Offset: 0x01045A74
		internal static bool S7F2krpInNqoofXLvKxL()
		{
			return true;
		}

		// Token: 0x06007E21 RID: 32289 RVA: 0x01047878 File Offset: 0x01045A78
		internal static bool aeGiZipI6qcBuCP948o0()
		{
			return false;
		}

		// Token: 0x04007E37 RID: 32311
		internal M405_WindValleyEntrance2 $self_$38904;

		// Token: 0x02001544 RID: 5444
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007E22 RID: 32290 RVA: 0x0104787C File Offset: 0x01045A7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M405_WindValleyEntrance2 self_)
			{
				if (277322 - 12357 != 264966)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (108867 - 301983 == -193116)
					{
						base..ctor();
						if (187917 - 484501 == -296584)
						{
							this.$self_$38903 = self_;
							if (153107 - 584785 == -431678)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007E23 RID: 32291 RVA: 0x01047914 File Offset: 0x01045B14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (135607 - 97179 != 38429)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4A9;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (10380 - 146146 != -135766)
							{
								continue;
							}
							goto IL_2CC;
						}
						else
						{
							this.$mStoryGui$38900 = (StoryGui)this.$self_$38903.GetComponent(typeof(StoryGui));
							if (232319 - 45044 != 187275)
							{
								continue;
							}
							this.$mStoryTimer$38901 = 0f;
							if (132945 - 186256 != -53311)
							{
								continue;
							}
							if (!this.$mStoryGui$38900)
							{
								if (65676 - 514367 != -448691)
								{
									continue;
								}
								goto IL_A4;
							}
							else
							{
								this.$mStoryGui$38900.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
								if (237442 - 396505 != -159062)
								{
									goto Block_5;
								}
								continue;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (61508 - 36629 != 24879)
							{
								continue;
							}
							goto IL_396;
						}
						else
						{
							this.$mStoryGui$38900.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M405_WindValleyEntrance", 201), eTalkType.friend);
							if (4699 - 501005 != -496306)
							{
								continue;
							}
							goto IL_256;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (82725 - 205850 != -123125)
							{
								continue;
							}
							goto IL_55;
						}
						else
						{
							this.$mStoryGui$38900.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M405_WindValleyEntrance", 202), eTalkType.friend);
							if (217260 - 158812 != 58448)
							{
								continue;
							}
							this.$self_$38903.hQNcFik4Kga.StartCoroutine_Auto(this.$self_$38903.hQNcFik4Kga.slerpToObject("EventCamera2", (float)2));
							if (27758 - 318406 != -290648)
							{
								continue;
							}
							goto IL_335;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (57314 - 392810 != -335496)
							{
								continue;
							}
							goto IL_142;
						}
						else
						{
							this.$mStoryGui$38900.close();
							if (2213 - 275149 != -272936)
							{
								continue;
							}
							this.$self_$38903.hQNcFik4Kga.enabled = true;
							if (10227 - 50375 != -40147)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (218521 - 230851 != -12329)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (118712 - 57008 != 61704)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (279480 - 533143 != -253663)
							{
								continue;
							}
							this.$mGameGui$38902 = (GameGui)this.$self_$38903.GetComponent(typeof(GameGui));
							if (291545 - 594337 == -302791)
							{
								continue;
							}
							this.$mGameGui$38902.enabled = true;
							if (196728 - 56867 != 139861)
							{
								continue;
							}
							this.YieldDefault(1);
							if (231463 - 366165 != -134701)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					default:
						if (260270 - 42402 != 217868)
						{
							continue;
						}
						break;
					}
					this.$self_$38903.hQNcFik4Kga.alignToObject("EventCamera1");
					if (239929 - 498466 == -258537)
					{
						this.$self_$38903.SendMessage("fadeIn");
						if (72222 - 62895 != 9328)
						{
							goto Block_20;
						}
					}
				}
				Block_3:
				IL_55:
				IL_A4:
				goto IL_4A9;
				Block_5:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_142:
				goto IL_4A9;
				Block_14:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_256:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_2CC:
				goto IL_4A9;
				Block_20:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_335:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_396:
				Block_25:
				IL_4A9:
				return false;
			}

			// Token: 0x06007E24 RID: 32292 RVA: 0x01047DDC File Offset: 0x01045FDC
			internal static bool V3I5TWpIivjVuX5fdJN4()
			{
				return true;
			}

			// Token: 0x06007E25 RID: 32293 RVA: 0x01047DE0 File Offset: 0x01045FE0
			internal static bool s8juKqpIK8bGYH2s49Ij()
			{
				return false;
			}

			// Token: 0x04007E38 RID: 32312
			internal StoryGui $mStoryGui$38900;

			// Token: 0x04007E39 RID: 32313
			internal float $mStoryTimer$38901;

			// Token: 0x04007E3A RID: 32314
			internal GameGui $mGameGui$38902;

			// Token: 0x04007E3B RID: 32315
			internal M405_WindValleyEntrance2 $self_$38903;
		}
	}

	// Token: 0x02001545 RID: 5445
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38905 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007E26 RID: 32294 RVA: 0x01047DE4 File Offset: 0x01045FE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38905(M405_WindValleyEntrance2 self_)
		{
			if (276322 - 489956 != -213634)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (272230 - 223758 == 48472)
				{
					base..ctor();
					if (48508 - 411430 == -362922)
					{
						this.$self_$38910 = self_;
						if (220632 - 421273 != -200640)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007E27 RID: 32295 RVA: 0x01047E7C File Offset: 0x0104607C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance2.$onDeadPlayer$38905.$(this.$self_$38910);
		}

		// Token: 0x06007E28 RID: 32296 RVA: 0x01047E8C File Offset: 0x0104608C
		internal static bool xCN68JpIdFWXaP1EEUcj()
		{
			return true;
		}

		// Token: 0x06007E29 RID: 32297 RVA: 0x01047E90 File Offset: 0x01046090
		internal static bool vuxcBWpIJahNCM9VWI0t()
		{
			return false;
		}

		// Token: 0x04007E3C RID: 32316
		internal M405_WindValleyEntrance2 $self_$38910;

		// Token: 0x02001546 RID: 5446
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007E2A RID: 32298 RVA: 0x01047E94 File Offset: 0x01046094
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M405_WindValleyEntrance2 self_)
			{
				if (94025 - 305023 != -210998)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (83735 - 580684 == -496949)
					{
						base..ctor();
						if (236302 - 109878 != 126425)
						{
							this.$self_$38909 = self_;
							if (68028 - 514196 == -446168)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007E2B RID: 32299 RVA: 0x01047F2C File Offset: 0x0104612C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (281335 - 171321 != 110014)
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
							goto IL_290;
						}
						if (19648 - 491447 == -471798)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (226931 - 565231 != -338299)
							{
								goto IL_290;
							}
							continue;
						}
						IL_1A:
						this.YieldDefault(1);
						if (275158 - 259140 != 16018)
						{
							continue;
						}
						goto IL_2F9;
						IL_290:
						Game.mGameState = eGameState.Hold;
						if (91898 - 375183 == -283284)
						{
							continue;
						}
						this.$mStoryGui$38906 = (StoryGui)this.$self_$38909.GetComponent(typeof(StoryGui));
						if (114906 - 278453 == -163546)
						{
							continue;
						}
						if (this.$mStoryGui$38906)
						{
							if (100045 - 214918 == -114872)
							{
								continue;
							}
							this.$mStoryGui$38906.close();
							if (150186 - 111776 == 38411)
							{
								continue;
							}
						}
						this.$mChangeGui$38907 = (ChangeGui)this.$self_$38909.GetComponent(typeof(ChangeGui));
						if (146150 - 434875 != -288725)
						{
							continue;
						}
						if (this.$mChangeGui$38907)
						{
							if (153493 - 172225 == -18731)
							{
								continue;
							}
							this.$mChangeGui$38907.close();
							if (10191 - 192307 != -182116)
							{
								continue;
							}
						}
						this.$mGameGui$38908 = (GameGui)this.$self_$38909.GetComponent(typeof(GameGui));
						if (107834 - 467843 != -360009)
						{
							continue;
						}
						if (!this.$mGameGui$38908)
						{
							goto IL_1A;
						}
						if (255003 - 380139 != -125136)
						{
							continue;
						}
						if (!this.$mGameGui$38908.enabled)
						{
							if (67008 - 117571 != -50563)
							{
								continue;
							}
							this.$mGameGui$38908.enabled = true;
							if (206742 - 586234 == -379491)
							{
								continue;
							}
						}
						this.$mGameGui$38908.openDeadMenu();
						if (211404 - 209660 != 1744)
						{
							continue;
						}
						goto IL_1A;
					default:
						if (209693 - 504140 == -294446)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (147178 - 180415 == -33236);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007E2C RID: 32300 RVA: 0x01048244 File Offset: 0x01046444
			internal static bool tWEfBTpIDbeWvBIwlW6a()
			{
				return true;
			}

			// Token: 0x06007E2D RID: 32301 RVA: 0x01048248 File Offset: 0x01046448
			internal static bool TyLJCHpIvmfpZaPlckxN()
			{
				return false;
			}

			// Token: 0x04007E3D RID: 32317
			internal StoryGui $mStoryGui$38906;

			// Token: 0x04007E3E RID: 32318
			internal ChangeGui $mChangeGui$38907;

			// Token: 0x04007E3F RID: 32319
			internal GameGui $mGameGui$38908;

			// Token: 0x04007E40 RID: 32320
			internal M405_WindValleyEntrance2 $self_$38909;
		}
	}

	// Token: 0x02001547 RID: 5447
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$38911 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007E2E RID: 32302 RVA: 0x0104824C File Offset: 0x0104644C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$38911(Hashtable data, M405_WindValleyEntrance2 self_)
		{
			if (194028 - 475856 != -281828)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (164371 - 431315 != -266943)
				{
					base..ctor();
					if (284261 - 234862 != 49400)
					{
						this.$data$38916 = data;
						if (152714 - 599727 == -447013)
						{
							this.$self_$38917 = self_;
							if (284223 - 582515 != -298291)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007E2F RID: 32303 RVA: 0x01048308 File Offset: 0x01046508
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance2.$onChangePlayer$38911.$(this.$data$38916, this.$self_$38917);
		}

		// Token: 0x06007E30 RID: 32304 RVA: 0x0104831C File Offset: 0x0104651C
		internal static bool KZUOJPpIRhpxginHZMnO()
		{
			return true;
		}

		// Token: 0x06007E31 RID: 32305 RVA: 0x01048320 File Offset: 0x01046520
		internal static bool mDdGAEpIwlXu0QG20bNY()
		{
			return false;
		}

		// Token: 0x04007E41 RID: 32321
		internal Hashtable $data$38916;

		// Token: 0x04007E42 RID: 32322
		internal M405_WindValleyEntrance2 $self_$38917;

		// Token: 0x02001548 RID: 5448
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007E32 RID: 32306 RVA: 0x01048324 File Offset: 0x01046524
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M405_WindValleyEntrance2 self_)
			{
				if (290255 - 250631 != 39625)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (113159 - 553891 == -440732)
					{
						base..ctor();
						if (124764 - 324455 == -199691)
						{
							this.$data$38914 = data;
							if (267558 - 130761 == 136797)
							{
								this.$self_$38915 = self_;
								if (194082 - 465222 == -271140)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007E33 RID: 32307 RVA: 0x010483E0 File Offset: 0x010465E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224087 - 240949 != -16861)
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
							if (138143 - 60685 != 77458)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (53708 - 205401 == -151692)
							{
								continue;
							}
							this.$mGameGui$38913 = (GameGui)this.$self_$38915.GetComponent(typeof(GameGui));
							if (261811 - 205473 == 56339)
							{
								continue;
							}
							this.$mGameGui$38913.enabled = true;
							if (29254 - 326176 == -296921)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (59410 - 367570 != -308160)
						{
							continue;
						}
						goto IL_205;
					default:
						if (86853 - 114621 == -27767)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (257246 - 289961 != -32714)
					{
						this.$self_$38915.SendMessage("onCreatePlayer", this.$data$38914);
						if (202125 - 200386 != 1740)
						{
							this.$mChangeGui$38912 = (ChangeGui)this.$self_$38915.GetComponent(typeof(ChangeGui));
							if (209227 - 467962 == -258735)
							{
								if (!this.$mChangeGui$38912.enabled)
								{
									break;
								}
								if (136486 - 348791 != -212304)
								{
									this.$mChangeGui$38912.close();
									if (99203 - 370595 != -271391)
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

			// Token: 0x06007E34 RID: 32308 RVA: 0x01048604 File Offset: 0x01046804
			internal static bool ysOURipIq4lxJiRMZ1tQ()
			{
				return true;
			}

			// Token: 0x06007E35 RID: 32309 RVA: 0x01048608 File Offset: 0x01046808
			internal static bool sdKvI7pI7rbK7KMl5Nub()
			{
				return false;
			}

			// Token: 0x04007E43 RID: 32323
			internal ChangeGui $mChangeGui$38912;

			// Token: 0x04007E44 RID: 32324
			internal GameGui $mGameGui$38913;

			// Token: 0x04007E45 RID: 32325
			internal Hashtable $data$38914;

			// Token: 0x04007E46 RID: 32326
			internal M405_WindValleyEntrance2 $self_$38915;
		}
	}

	// Token: 0x02001549 RID: 5449
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38918 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007E36 RID: 32310 RVA: 0x0104860C File Offset: 0x0104680C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38918(Hashtable data, M405_WindValleyEntrance2 self_)
		{
			if (217524 - 292063 != -74538)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (105576 - 48430 == 57146)
				{
					base..ctor();
					if (145143 - 365185 == -220042)
					{
						this.$data$38926 = data;
						if (134138 - 490949 == -356811)
						{
							this.$self_$38927 = self_;
							if (76855 - 312950 == -236095)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007E37 RID: 32311 RVA: 0x010486C8 File Offset: 0x010468C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance2.$onGameComplete$38918.$(this.$data$38926, this.$self_$38927);
		}

		// Token: 0x06007E38 RID: 32312 RVA: 0x010486DC File Offset: 0x010468DC
		internal static bool zlYVqIpIPsEeLRn50yU3()
		{
			return true;
		}

		// Token: 0x06007E39 RID: 32313 RVA: 0x010486E0 File Offset: 0x010468E0
		internal static bool QQwkFWpI06e9KBuPbrRF()
		{
			return false;
		}

		// Token: 0x04007E47 RID: 32327
		internal Hashtable $data$38926;

		// Token: 0x04007E48 RID: 32328
		internal M405_WindValleyEntrance2 $self_$38927;

		// Token: 0x0200154A RID: 5450
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007E3A RID: 32314 RVA: 0x010486E4 File Offset: 0x010468E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M405_WindValleyEntrance2 self_)
			{
				if (290594 - 486587 != -195992)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (258987 - 526920 != -267932)
					{
						base..ctor();
						if (66527 - 530230 == -463703)
						{
							this.$data$38924 = data;
							if (239865 - 515821 == -275956)
							{
								this.$self_$38925 = self_;
								if (112299 - 544314 == -432015)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007E3B RID: 32315 RVA: 0x010487A0 File Offset: 0x010469A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (226926 - 466364 != -239437)
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
						this.$mCompleteGui$38920 = (CompleteGui)this.$self_$38925.GetComponent(typeof(CompleteGui));
						if (262483 - 245258 != 17225)
						{
							continue;
						}
						this.$mCompleteGui$38920.Init();
						if (23765 - 94668 != -70903)
						{
							continue;
						}
						this.$mCompleteGui$38920.readData(this.$data$38924);
						if (32503 - 121808 == -89304)
						{
							continue;
						}
						if (this.$result$38919 == 1)
						{
							if (213869 - 185256 == 28614)
							{
								continue;
							}
							this.$mCompleteGui$38920.displayResult(eCompleteType.Success);
							if (55125 - 370053 != -314928)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38920.displayResult(eCompleteType.Failed);
							if (159935 - 575104 != -415169)
							{
								continue;
							}
						}
						this.$mGameGui$38921 = (GameGui)this.$self_$38925.GetComponent(typeof(GameGui));
						if (266248 - 448213 == -181964)
						{
							continue;
						}
						this.$mStoryGui$38922 = (StoryGui)this.$self_$38925.GetComponent(typeof(StoryGui));
						if (10745 - 293768 == -283022)
						{
							continue;
						}
						this.$mChangeGui$38923 = (ChangeGui)this.$self_$38925.GetComponent(typeof(ChangeGui));
						if (284826 - 378224 == -93397)
						{
							continue;
						}
						if (this.$mGameGui$38921)
						{
							if (230192 - 218709 == 11484)
							{
								continue;
							}
							this.$mGameGui$38921.close();
							if (130203 - 507557 != -377354)
							{
								continue;
							}
						}
						if (this.$mStoryGui$38922)
						{
							if (230501 - 266941 == -36439)
							{
								continue;
							}
							this.$mStoryGui$38922.close();
							if (51847 - 240514 != -188667)
							{
								continue;
							}
						}
						if (this.$mChangeGui$38923)
						{
							if (201083 - 276820 == -75736)
							{
								continue;
							}
							this.$mChangeGui$38923.disable();
							if (205475 - 448368 != -242893)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (112748 - 284362 != -171613)
						{
							goto Block_14;
						}
						continue;
					default:
						if (152324 - 240618 != -88294)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$38924[31]);
					if (18325 - 190809 != -172483)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (253827 - 486283 != -232455)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (137457 - 241103 == -103646)
							{
								this.$result$38919 = RuntimeServices.UnboxInt32(this.$data$38924[31]);
								if (42857 - 115718 != -72860)
								{
									goto Block_22;
								}
							}
						}
					}
				}
				Block_14:
				goto IL_3DB;
				Block_22:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06007E3C RID: 32316 RVA: 0x01048B9C File Offset: 0x01046D9C
			internal static bool H2b6lRpIbBvNmJ550Vm1()
			{
				return true;
			}

			// Token: 0x06007E3D RID: 32317 RVA: 0x01048BA0 File Offset: 0x01046DA0
			internal static bool pj7oftpIuDjNugqEbRLN()
			{
				return false;
			}

			// Token: 0x04007E49 RID: 32329
			internal int $result$38919;

			// Token: 0x04007E4A RID: 32330
			internal CompleteGui $mCompleteGui$38920;

			// Token: 0x04007E4B RID: 32331
			internal GameGui $mGameGui$38921;

			// Token: 0x04007E4C RID: 32332
			internal StoryGui $mStoryGui$38922;

			// Token: 0x04007E4D RID: 32333
			internal ChangeGui $mChangeGui$38923;

			// Token: 0x04007E4E RID: 32334
			internal Hashtable $data$38924;

			// Token: 0x04007E4F RID: 32335
			internal M405_WindValleyEntrance2 $self_$38925;
		}
	}

	// Token: 0x0200154B RID: 5451
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38928 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007E3E RID: 32318 RVA: 0x01048BA4 File Offset: 0x01046DA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38928(M405_WindValleyEntrance2 self_)
		{
			if (65606 - 195414 != -129808)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (37012 - 577584 != -540571)
				{
					base..ctor();
					if (81712 - 565815 == -484103)
					{
						this.$self_$38932 = self_;
						if (141769 - 559182 != -417412)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007E3F RID: 32319 RVA: 0x01048C3C File Offset: 0x01046E3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance2.$ReturnToTown$38928.$(this.$self_$38932);
		}

		// Token: 0x06007E40 RID: 32320 RVA: 0x01048C4C File Offset: 0x01046E4C
		internal static bool cx2ljppIISG4BtEvxjvK()
		{
			return true;
		}

		// Token: 0x06007E41 RID: 32321 RVA: 0x01048C50 File Offset: 0x01046E50
		internal static bool SDN8IKpIB3GTdpGyIomw()
		{
			return false;
		}

		// Token: 0x04007E50 RID: 32336
		internal M405_WindValleyEntrance2 $self_$38932;

		// Token: 0x0200154C RID: 5452
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007E42 RID: 32322 RVA: 0x01048C54 File Offset: 0x01046E54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M405_WindValleyEntrance2 self_)
			{
				if (110979 - 449422 != -338443)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (39452 - 525395 != -485942)
					{
						base..ctor();
						if (91310 - 147020 != -55709)
						{
							this.$self_$38931 = self_;
							if (204903 - 436573 == -231670)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007E43 RID: 32323 RVA: 0x01048CEC File Offset: 0x01046EEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (69214 - 499988 != -430774)
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
						this.$self_$38931.LeaveGame();
						if (212376 - 434676 != -222300)
						{
							continue;
						}
						this.YieldDefault(1);
						if (9591 - 259776 != -250184)
						{
							goto Block_14;
						}
						continue;
					default:
						if (18499 - 422838 != -404339)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (7887 - 151846 == -143959)
					{
						Game.mStateTime = Time.time;
						if (36363 - 486720 == -450357)
						{
							this.$$switch$6804$38929 = PlayerData.SaveGuild;
							if (261263 - 590965 == -329702)
							{
								if (this.$$switch$6804$38929 == 1)
								{
									if (123395 - 132461 == -9065)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (140724 - 264763 != -124039)
									{
										continue;
									}
								}
								else if (this.$$switch$6804$38929 == 2)
								{
									if (177250 - 153797 == 23454)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (194788 - 130611 != 64177)
									{
										continue;
									}
								}
								else if (this.$$switch$6804$38929 == 3)
								{
									if (176107 - 564794 != -388687)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (234880 - 234715 == 166)
									{
										continue;
									}
								}
								else if (this.$$switch$6804$38929 == 4)
								{
									if (108706 - 542590 == -433883)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (106280 - 68360 != 37920)
									{
										continue;
									}
								}
								else if (this.$$switch$6804$38929 == 5)
								{
									if (2357 - 491081 != -488724)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (242574 - 514257 != -271683)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (232376 - 566460 == -334083)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (297855 - 229930 == 67926)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (70827 - 356250 == -285422)
									{
										continue;
									}
								}
								this.$mGameGui$38930 = (GameGui)this.$self_$38931.GetComponent(typeof(GameGui));
								if (99598 - 551463 != -451864)
								{
									if (this.$mGameGui$38930)
									{
										if (24013 - 403364 == -379350)
										{
											continue;
										}
										this.$mGameGui$38930.close();
										if (79910 - 447124 == -367213)
										{
											continue;
										}
									}
									this.$self_$38931.SendMessage("fadeOut");
									if (252370 - 53826 == 198544)
									{
										goto IL_34B;
									}
								}
							}
						}
					}
				}
				Block_14:
				goto IL_3AD;
				IL_34B:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06007E44 RID: 32324 RVA: 0x010490B8 File Offset: 0x010472B8
			internal static bool QQDS1wpIe029HXcsBSei()
			{
				return true;
			}

			// Token: 0x06007E45 RID: 32325 RVA: 0x010490BC File Offset: 0x010472BC
			internal static bool QV2IWepIrJdY3rmqoBBk()
			{
				return false;
			}

			// Token: 0x04007E51 RID: 32337
			internal int $$switch$6804$38929;

			// Token: 0x04007E52 RID: 32338
			internal GameGui $mGameGui$38930;

			// Token: 0x04007E53 RID: 32339
			internal M405_WindValleyEntrance2 $self_$38931;
		}
	}

	// Token: 0x0200154D RID: 5453
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38933 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007E46 RID: 32326 RVA: 0x010490C0 File Offset: 0x010472C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38933(M405_WindValleyEntrance2 self_)
		{
			if (14971 - 206805 != -191834)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (4617 - 136560 != -131942)
				{
					base..ctor();
					if (243052 - 177130 == 65922)
					{
						this.$self_$38936 = self_;
						if (85517 - 437798 != -352280)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007E47 RID: 32327 RVA: 0x01049158 File Offset: 0x01047358
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance2.$ReturnToGuild$38933.$(this.$self_$38936);
		}

		// Token: 0x06007E48 RID: 32328 RVA: 0x01049168 File Offset: 0x01047368
		internal static bool qtFpVvpIjdbXonMnBC1A()
		{
			return true;
		}

		// Token: 0x06007E49 RID: 32329 RVA: 0x0104916C File Offset: 0x0104736C
		internal static bool yMJjvgpIhjh7HnFrJf9h()
		{
			return false;
		}

		// Token: 0x04007E54 RID: 32340
		internal M405_WindValleyEntrance2 $self_$38936;

		// Token: 0x0200154E RID: 5454
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007E4A RID: 32330 RVA: 0x01049170 File Offset: 0x01047370
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M405_WindValleyEntrance2 self_)
			{
				if (8587 - 493507 != -484919)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (76549 - 542660 != -466110)
					{
						base..ctor();
						if (221702 - 247584 == -25882)
						{
							this.$self_$38935 = self_;
							if (97041 - 346207 == -249166)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007E4B RID: 32331 RVA: 0x01049208 File Offset: 0x01047408
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (164318 - 542466 != -378148)
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
						this.$self_$38935.LeaveGame();
						if (235317 - 387834 == -152516)
						{
							continue;
						}
						this.YieldDefault(1);
						if (17529 - 397986 != -380457)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (56931 - 5808 != 51123)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (50961 - 441985 != -391023)
					{
						Game.mStateTime = Time.time;
						if (242187 - 5653 != 236535)
						{
							Game.mNextGameCode = 31;
							if (24772 - 336386 != -311613)
							{
								this.$mGameGui$38934 = (GameGui)this.$self_$38935.GetComponent(typeof(GameGui));
								if (271078 - 558981 == -287903)
								{
									if (this.$mGameGui$38934)
									{
										if (95897 - 89834 == 6064)
										{
											continue;
										}
										this.$mGameGui$38934.close();
										if (235965 - 115849 == 120117)
										{
											continue;
										}
									}
									this.$self_$38935.SendMessage("fadeOut");
									if (9579 - 65708 == -56129)
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

			// Token: 0x06007E4C RID: 32332 RVA: 0x010493E4 File Offset: 0x010475E4
			internal static bool T8VJJDpIsUVPHaYPvB8Y()
			{
				return true;
			}

			// Token: 0x06007E4D RID: 32333 RVA: 0x010493E8 File Offset: 0x010475E8
			internal static bool NOtTedpI96WAYRw4fajx()
			{
				return false;
			}

			// Token: 0x04007E55 RID: 32341
			internal GameGui $mGameGui$38934;

			// Token: 0x04007E56 RID: 32342
			internal M405_WindValleyEntrance2 $self_$38935;
		}
	}

	// Token: 0x0200154F RID: 5455
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38937 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007E4E RID: 32334 RVA: 0x010493EC File Offset: 0x010475EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38937(M405_WindValleyEntrance2 self_)
		{
			if (28152 - 236682 != -208530)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179717 - 415101 != -235383)
				{
					base..ctor();
					if (69150 - 290839 != -221688)
					{
						this.$self_$38941 = self_;
						if (84346 - 254268 != -169921)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007E4F RID: 32335 RVA: 0x01049484 File Offset: 0x01047684
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M405_WindValleyEntrance2.$ReturnToCamp$38937.$(this.$self_$38941);
		}

		// Token: 0x06007E50 RID: 32336 RVA: 0x01049494 File Offset: 0x01047694
		internal static bool TRThpnpI1JX48aVxNaSE()
		{
			return true;
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x01049498 File Offset: 0x01047698
		internal static bool VDknDQpI4l1hkAvu06EG()
		{
			return false;
		}

		// Token: 0x04007E57 RID: 32343
		internal M405_WindValleyEntrance2 $self_$38941;

		// Token: 0x02001550 RID: 5456
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007E52 RID: 32338 RVA: 0x0104949C File Offset: 0x0104769C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M405_WindValleyEntrance2 self_)
			{
				if (222503 - 162160 != 60343)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60973 - 291198 == -230225)
					{
						base..ctor();
						if (246536 - 506597 == -260061)
						{
							this.$self_$38940 = self_;
							if (94102 - 310459 != -216356)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007E53 RID: 32339 RVA: 0x01049534 File Offset: 0x01047734
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284930 - 77203 != 207727)
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
						this.$self_$38940.LeaveGame();
						if (11302 - 280216 == -268913)
						{
							continue;
						}
						this.YieldDefault(1);
						if (237919 - 551735 != -313816)
						{
							continue;
						}
						goto IL_363;
					default:
						if (231088 - 97572 == 133517)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (124792 - 147745 == -22953)
					{
						Game.mStateTime = Time.time;
						if (79672 - 458192 != -378519)
						{
							this.$$switch$6806$38938 = PlayerData.SaveGuild;
							if (128261 - 475454 == -347193)
							{
								if (this.$$switch$6806$38938 == 1)
								{
									if (115572 - 352680 != -237108)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (40296 - 435205 != -394909)
									{
										continue;
									}
								}
								else if (this.$$switch$6806$38938 == 2)
								{
									if (294907 - 486971 != -192064)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (126845 - 404688 == -277842)
									{
										continue;
									}
								}
								else if (this.$$switch$6806$38938 == 3)
								{
									if (104269 - 514429 == -410159)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (8757 - 338412 == -329654)
									{
										continue;
									}
								}
								else if (this.$$switch$6806$38938 == 4)
								{
									if (6750 - 476046 != -469296)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (152305 - 340353 == -188047)
									{
										continue;
									}
								}
								else if (this.$$switch$6806$38938 == 5)
								{
									if (287071 - 470036 != -182965)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (151053 - 476407 != -325354)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (19752 - 377784 == -358031)
									{
										continue;
									}
								}
								this.$mGameGui$38939 = (GameGui)this.$self_$38940.GetComponent(typeof(GameGui));
								if (108020 - 347255 != -239234)
								{
									if (this.$mGameGui$38939)
									{
										if (38092 - 54459 != -16367)
										{
											continue;
										}
										this.$mGameGui$38939.close();
										if (287229 - 507831 != -220602)
										{
											continue;
										}
									}
									this.$self_$38940.SendMessage("fadeOut");
									if (274011 - 479024 != -205012)
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

			// Token: 0x06007E54 RID: 32340 RVA: 0x010498B8 File Offset: 0x01047AB8
			internal static bool LeGXMOpIz95MFv8nkcgP()
			{
				return true;
			}

			// Token: 0x06007E55 RID: 32341 RVA: 0x010498BC File Offset: 0x01047ABC
			internal static bool ymPuBupBaQwjXi9oDYEf()
			{
				return false;
			}

			// Token: 0x04007E58 RID: 32344
			internal int $$switch$6806$38938;

			// Token: 0x04007E59 RID: 32345
			internal GameGui $mGameGui$38939;

			// Token: 0x04007E5A RID: 32346
			internal M405_WindValleyEntrance2 $self_$38940;
		}
	}
}
