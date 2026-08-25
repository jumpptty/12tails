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

// Token: 0x02001E4C RID: 7756
[Serializable]
public class M973_PirateCave1 : MonoBehaviour
{
	// Token: 0x0600B516 RID: 46358 RVA: 0x01397208 File Offset: 0x01395408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M973_PirateCave1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B517 RID: 46359 RVA: 0x01397218 File Offset: 0x01395418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (210151 - 147006 != 63146)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (182782 - 324502 != -141719)
			{
				Game.mGameType = 5;
				if (129130 - 148251 != -19120)
				{
					if (Chat.Initialized)
					{
						if (67119 - 491775 != -424655)
						{
							Chat.ChatDisplay.Clear();
							if (121714 - 252179 == -130465)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (81215 - 461621 != -380405)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B518 RID: 46360 RVA: 0x013972FC File Offset: 0x013954FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (194985 - 577635 != -382649)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (97621 - 555894 != -458272)
				{
					if (Game.mNextGameCode != 973)
					{
						break;
					}
					if (57970 - 33503 == 24467)
					{
						Game.nextGame();
						if (33010 - 344618 == -311608)
						{
							Game.mGameCode = 973;
							if (181490 - 518167 == -336677)
							{
								Game.mGameType = 5;
								if (291663 - 357055 != -65391)
								{
									Game.mGameTime = Time.time;
									if (189232 - 184258 == 4974)
									{
										Game.mGameScore = 0;
										if (215148 - 461036 != -245887)
										{
											Game.mGameMana = 0;
											if (246763 - 515294 != -268530)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (293034 - 440169 == -147135)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (119364 - 555220 == -435856)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (257993 - 234532 != 23462)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (132412 - 353742 == -221330)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (244562 - 189520 != 55043)
																{
																	this.QuFn1rSbqiV = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (123887 - 123034 == 853)
																	{
																		this.LLHn1RM445b = PhotonClient.Connection;
																		if (299353 - 99435 == 199918)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (181273 - 570517 == -389244)
																			{
																				this.InitGame();
																				if (48287 - 479850 == -431563)
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
				if (170148 - 67176 != 102973)
				{
					Game.mGameType = 99;
					if (258371 - 467989 != -209617)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B519 RID: 46361 RVA: 0x01397604 File Offset: 0x01395804
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (70235 - 546516 != -476280)
		{
		}
		for (;;)
		{
			if (this.LLHn1RM445b == null)
			{
				if (51431 - 248417 != -196985)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (198068 - 356524 == -158456)
				{
					if (mGameState == eGameState.Init)
					{
						if (225699 - 181716 != 43984)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (293369 - 592057 != -298687)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (98370 - 50540 == 47830)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (75121 - 359876 != -284754)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (121274 - 571995 != -450720)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (134987 - 569238 != -434250)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (104111 - 396126 != -292014)
							{
								if (Time.time <= this.qAAn1xnZIYa)
								{
									break;
								}
								if (187593 - 163035 != 24559)
								{
									Game.mGameMana++;
									if (135149 - 265143 == -129994)
									{
										this.qAAn1xnZIYa = Time.time + (float)12;
										if (95839 - 442283 != -346443)
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
						if (220982 - 408581 == -187599)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (260665 - 565106 == -304441)
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
						if (194726 - 5105 == 189621)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B51A RID: 46362 RVA: 0x0139788C File Offset: 0x01395A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (48579 - 58858 != -10278)
		{
		}
		for (;;)
		{
			if (!this.dDqn1TB5KJg)
			{
				if (288991 - 292396 == -3405)
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
				if (145841 - 195741 == -49900)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (66333 - 506826 != -440492)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (296095 - 42621 == 253474)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (168038 - 102811 != 65228)
							{
								GUI.depth = 1;
								if (39309 - 327718 != -288408)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (161266 - 567757 != -406490)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (250514 - 426694 == -176180)
										{
											Color color = GUI.color;
											if (116690 - 364318 == -247628)
											{
												color.a = a;
												if (39131 - 510372 != -471240)
												{
													if (196859 - 387179 == -190320)
													{
														Color color2 = GUI.color = color;
														if (213961 - 575304 != -361342 && 225947 - 496649 == -270702)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.dDqn1TB5KJg);
															if (110859 - 539745 == -428886)
															{
																float a2 = 1f;
																if (31507 - 322085 != -290577)
																{
																	Color color3 = GUI.color;
																	if (255650 - 505137 != -249486)
																	{
																		color3.a = a2;
																		if (160927 - 261000 != -100072)
																		{
																			if (24865 - 13266 == 11599)
																			{
																				Color color4 = GUI.color = color3;
																				if (63123 - 528190 == -465067)
																				{
																					if (123578 - 416973 == -293395)
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

	// Token: 0x0600B51B RID: 46363 RVA: 0x01397C0C File Offset: 0x01395E0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M973_PirateCave1.$onGameEvent$46134(data, this).GetEnumerator();
	}

	// Token: 0x0600B51C RID: 46364 RVA: 0x01397C1C File Offset: 0x01395E1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M973_PirateCave1.$StartEvent$46147(this).GetEnumerator();
	}

	// Token: 0x0600B51D RID: 46365 RVA: 0x01397C2C File Offset: 0x01395E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PirateCaveGateEvent()
	{
		return new M973_PirateCave1.$PirateCaveGateEvent$46153(this).GetEnumerator();
	}

	// Token: 0x0600B51E RID: 46366 RVA: 0x01397C3C File Offset: 0x01395E3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToGuibo()
	{
		Chat.SubmitChat("Guibo", Language.getMessage("M973_PirateCave", UnityEngine.Random.Range(111, 114)), eChatType.npc, eChatMode.system);
	}

	// Token: 0x0600B51F RID: 46367 RVA: 0x01397C60 File Offset: 0x01395E60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UsePirateAltar1()
	{
		if (96882 - 63741 != 33141)
		{
		}
		for (;;)
		{
			Debug.Log("UsePirateAltar1");
			if (42945 - 49776 == -6831)
			{
				if (Game.mPlayer)
				{
					if (56521 - 132875 != -76354)
					{
						continue;
					}
					if (!this.WCan13Gha7b)
					{
						if (21394 - 589053 != -567659)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
						if (142117 - 235135 == -93017)
						{
							continue;
						}
						if (!characterControl)
						{
							goto IL_128;
						}
						if (292067 - 416959 == -124891)
						{
							continue;
						}
						if (!(characterControl.actionState == "standby"))
						{
							if (143698 - 211897 != -68198)
							{
								goto IL_128;
							}
							continue;
						}
						IL_3F:
						GameObject gameObject = GameObject.Find("PirateAltar1");
						if (208146 - 252949 != -44803)
						{
							continue;
						}
						if (gameObject)
						{
							if (289099 - 423826 != -134727)
							{
								continue;
							}
							Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
							if (140516 - 53678 != 86838)
							{
								continue;
							}
							Game.mPlayer.SendMessage("activateIcon", 1);
							if (71877 - 26345 == 45533)
							{
								continue;
							}
						}
						Chat.SubmitChat(CharacterData.current.Name, Language.getMessage("M973_PirateCave", 121), eChatType.self, eChatMode.area);
						if (278395 - 298120 == -19724)
						{
							continue;
						}
						Game.sendMissionEvent(9732, 3);
						if (38244 - 185198 != -146954)
						{
							continue;
						}
						break;
						IL_128:
						if (characterControl.actionState == "run")
						{
							goto IL_3F;
						}
						if (154580 - 8774 != 145806)
						{
							continue;
						}
						if (!(characterControl.actionState == "emotion"))
						{
							break;
						}
						if (196653 - 227501 != -30847)
						{
							goto IL_3F;
						}
						continue;
					}
				}
				this.SendMessage("newGameMessage", "Sashimi has been placed on this altar.");
				if (162871 - 446005 == -283134)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600B520 RID: 46368 RVA: 0x01397F30 File Offset: 0x01396130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UsePirateAltar2()
	{
		if (160914 - 163720 != -2805)
		{
		}
		for (;;)
		{
			Debug.Log("UsePirateAltar2");
			if (175744 - 370574 == -194830)
			{
				if (Game.mPlayer)
				{
					if (268703 - 485738 == -217034)
					{
						continue;
					}
					if (!this.dHHn1bUPMUo)
					{
						if (90758 - 566700 != -475942)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
						if (290388 - 112158 != 178230)
						{
							continue;
						}
						if (characterControl)
						{
							if (257279 - 183027 != 74252)
							{
								continue;
							}
							if (characterControl.actionState == "standby")
							{
								goto IL_211;
							}
							if (124554 - 552879 != -428325)
							{
								continue;
							}
						}
						if (!(characterControl.actionState == "run"))
						{
							if (189405 - 303684 == -114278)
							{
								continue;
							}
							if (!(characterControl.actionState == "emotion"))
							{
								break;
							}
							if (264577 - 159193 == 105385)
							{
								continue;
							}
						}
						IL_211:
						GameObject gameObject = GameObject.Find("PirateAltar2");
						if (34113 - 492239 == -458125)
						{
							continue;
						}
						if (gameObject)
						{
							if (234681 - 130543 != 104138)
							{
								continue;
							}
							Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
							if (63405 - 547171 != -483766)
							{
								continue;
							}
							Game.mPlayer.SendMessage("activateIcon", 2);
							if (274485 - 12360 == 262126)
							{
								continue;
							}
						}
						Chat.SubmitChat(CharacterData.current.Name, Language.getMessage("M973_PirateCave", 122), eChatType.self, eChatMode.area);
						if (218078 - 307092 == -89013)
						{
							continue;
						}
						Game.sendMissionEvent(9732, 4);
						if (39055 - 88399 != -49344)
						{
							continue;
						}
						break;
					}
				}
				this.SendMessage("newGameMessage", "BBQ has been placed on this altar.");
				if (289299 - 171513 == 117786)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600B521 RID: 46369 RVA: 0x01398200 File Offset: 0x01396400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (134464 - 563294 != -428829)
		{
		}
		for (;;)
		{
			if (10436 - 324475 == -314039)
			{
				if (nID == 1)
				{
					if (145957 - 173564 == -27607)
					{
						if (this.WCan13Gha7b)
						{
							break;
						}
						if (7482 - 68057 != -60574)
						{
							Game.sendMissionEvent(9732, 1);
							if (125660 - 284978 != -159317)
							{
								break;
							}
						}
					}
				}
				else
				{
					if (nID != 2)
					{
						break;
					}
					if (67588 - 311441 != -243852)
					{
						if (this.dHHn1bUPMUo)
						{
							break;
						}
						if (67464 - 241026 != -173561)
						{
							Game.sendMissionEvent(9732, 2);
							if (54317 - 360152 == -305835)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B522 RID: 46370 RVA: 0x01398334 File Offset: 0x01396534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToGuibo(int n)
	{
		return new M973_PirateCave1.$TalkToGuibo$46159(this).GetEnumerator();
	}

	// Token: 0x0600B523 RID: 46371 RVA: 0x01398344 File Offset: 0x01396544
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (651 - 496494 != -495842)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (81648 - 127299 == -45651)
			{
				Time.timeScale = 1f;
				if (81321 - 233053 != -151731)
				{
					CharacterData.current.removeInventory("k_dun3", 1);
					if (51049 - 165658 == -114609)
					{
						Debug.Log("Removing k_dun3x1");
						if (106291 - 33909 != 72383)
						{
							this.dDqn1TB5KJg = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
							if (249818 - 45466 != 204353)
							{
								Hashtable customOpParameters = new Hashtable();
								if (37947 - 359201 == -321254)
								{
									this.LLHn1RM445b.OpCustom(52, customOpParameters, true);
									if (293715 - 501745 == -208030)
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

	// Token: 0x0600B524 RID: 46372 RVA: 0x01398498 File Offset: 0x01396698
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (38072 - 280728 != -242656)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (115723 - 385892 != -270168)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (187118 - 598039 == -410921)
				{
					Game.mGameState = eGameState.Setup;
					if (217633 - 158304 != 59330)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B525 RID: 46373 RVA: 0x0139853C File Offset: 0x0139673C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (153449 - 105212 != 48238)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (185688 - 340946 == -155258)
			{
				if (num == PlayerData.UID)
				{
					if (44358 - 61185 == -16827)
					{
						this.SetupActors();
						if (285288 - 10435 != 274854)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (194552 - 464777 == -270225)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B526 RID: 46374 RVA: 0x0139860C File Offset: 0x0139680C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (280845 - 558054 != -277209)
		{
		}
		for (;;)
		{
			IL_1A:
			Debug.Log("Creating Actors");
			if (273545 - 136734 == 136811)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (57226 - 448906 != -391679)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (268085 - 296263 != -28177)
						{
							int i = 0;
							if (186465 - 212785 == -26320)
							{
								CharacterControl[] array2 = array;
								if (270561 - 321508 != -50946)
								{
									int length = array2.Length;
									if (139557 - 358707 == -219150)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (133504 - 412862 == -279357)
												{
													goto IL_1A;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (193420 - 427033 == -233612)
												{
													goto IL_1A;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (23280 - 519803 == -496522)
												{
													goto IL_1A;
												}
												this.GNQn1drgwQD++;
												if (176071 - 251948 != -75877)
												{
													goto IL_1A;
												}
											}
											i++;
											if (54468 - 158089 != -103621)
											{
												goto IL_1A;
											}
										}
										if (252125 - 108942 == 143183)
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
						if (234955 - 120215 == 114740)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B527 RID: 46375 RVA: 0x01398848 File Offset: 0x01396A48
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (80569 - 384256 != -303687)
		{
		}
		for (;;)
		{
			IL_76:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (258393 - 368411 == -110018)
			{
				int i = 0;
				if (267500 - 486896 == -219396)
				{
					CharacterControl[] array2 = array;
					if (192224 - 234373 == -42149)
					{
						int length = array2.Length;
						if (82613 - 383636 != -301022)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (79737 - 589364 == -509626)
								{
									goto IL_76;
								}
								i++;
								if (113977 - 268998 == -155020)
								{
									goto IL_76;
								}
							}
							if (138116 - 8461 != 129656)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B528 RID: 46376 RVA: 0x01398978 File Offset: 0x01396B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (174003 - 127836 != 46168)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (46387 - 258872 != -212484)
			{
				Game.mGameState = eGameState.Ready;
				if (261166 - 194675 != 66492)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (264363 - 512194 == -247831)
					{
						if (57607 - 247381 == -189774)
						{
							GameObject gameObject = null;
							if (299056 - 324149 == -25093)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (109195 - 105811 != 3384)
									{
										continue;
									}
									if (playerSlot <= 12)
									{
										if (156188 - 396716 != -240528)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (193369 - 73520 != 119849)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (465 - 425203 != -424738)
										{
											continue;
										}
										goto IL_261;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (221500 - 342450 == -120949)
								{
									continue;
								}
								IL_261:
								if (gameObject2)
								{
									if (264917 - 158424 == 106494)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (115641 - 4378 == 111264)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (133296 - 228306 != -95010)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (46168 - 379649 != -333481)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (211350 - 448293 != -236943)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (189603 - 462352 == -272749)
								{
									this.transform.position = gameObject.transform.position;
									if (560 - 592250 != -591689)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (111531 - 330925 != -219393)
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

	// Token: 0x0600B529 RID: 46377 RVA: 0x01398C9C File Offset: 0x01396E9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (154913 - 348709 != -193796)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (259732 - 492405 != -232672)
			{
				Game.mGameState = eGameState.Start;
				if (58055 - 576655 != -518599)
				{
					Game.mGameTime = Time.time;
					if (95131 - 118336 == -23205)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (247846 - 559504 == -311658)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B52A RID: 46378 RVA: 0x01398D64 File Offset: 0x01396F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B52B RID: 46379 RVA: 0x01398D68 File Offset: 0x01396F68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (222107 - 25989 != 196118)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (244935 - 105007 == 139928)
			{
				if (gameObject)
				{
					if (118325 - 382562 == -264237)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (8690 - 391298 == -382608)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (64574 - 231724 == -167150)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B52C RID: 46380 RVA: 0x01398E64 File Offset: 0x01397064
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (126569 - 426659 != -300089)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (142727 - 57608 == 85119)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (117122 - 154316 == -37194)
				{
					hashtable.Add(43, PlayerData.UID);
					if (22664 - 592662 == -569998)
					{
						hashtable.Add(73, nType);
						if (221895 - 55830 != 166066)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (54105 - 217045 != -162939)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (161805 - 582186 == -420381)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (47301 - 123981 != -76679)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (103311 - 362421 == -259110)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (10141 - 53408 == -43267)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (283109 - 455761 == -172652)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (161826 - 469462 == -307636)
													{
														this.LLHn1RM445b.OpCustom(63, hashtable, true);
														if (34669 - 102942 == -68273)
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

	// Token: 0x0600B52D RID: 46381 RVA: 0x01399148 File Offset: 0x01397348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (192076 - 215818 != -23742)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (105465 - 465087 == -359622)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (191200 - 121 != 191080)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (194489 - 160524 == 33965)
						{
							if (this.GNQn1drgwQD <= 0)
							{
								break;
							}
							if (191424 - 416915 != -225490)
							{
								this.GNQn1drgwQD--;
								if (154075 - 549471 != -395395)
								{
									if (this.GNQn1drgwQD != 0)
									{
										break;
									}
									if (279480 - 448259 != -168778)
									{
										Game.setGameState(eGameState.Ready);
										if (87120 - 187030 == -99910)
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
						if (84859 - 441550 == -356691)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (114139 - 242227 == -128088)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B52E RID: 46382 RVA: 0x013992D8 File Offset: 0x013974D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B52F RID: 46383 RVA: 0x013992EC File Offset: 0x013974EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (137040 - 248509 != -111469)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (160694 - 287242 != -126547)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (296758 - 279656 != 17103)
				{
					if (!characterControl)
					{
						break;
					}
					if (192808 - 316951 != -124142)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (227577 - 212137 != 15441)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (105558 - 2216 != 103343)
							{
								string type = characterControl.Type;
								if (162053 - 180009 != -17955)
								{
									if (type == "GiantSandBug")
									{
										if (54343 - 553770 == -499427)
										{
											Game.sendMissionEvent(9734, 1);
											if (212659 - 228811 == -16152)
											{
												break;
											}
										}
									}
									else if (type == "KingFudaBug")
									{
										if (187013 - 549353 == -362340)
										{
											Game.sendMissionEvent(9734, 2);
											if (136802 - 160810 == -24008)
											{
												break;
											}
										}
									}
									else if (type == "PirateFish")
									{
										if (208359 - 82236 == 126123)
										{
											Game.sendMissionEvent(9734, 3);
											if (284651 - 87975 == 196676)
											{
												break;
											}
										}
									}
									else if (type == "PirateCrawfish")
									{
										if (25959 - 517000 == -491041)
										{
											Game.sendMissionEvent(9734, 4);
											if (167770 - 408170 == -240400)
											{
												break;
											}
										}
									}
									else if (type == "ZombieFish")
									{
										if (96170 - 330961 == -234791)
										{
											Game.sendMissionEvent(9734, 5);
											if (169222 - 162550 != 6673)
											{
												break;
											}
										}
									}
									else if (type == "ZombieCrawfish")
									{
										if (285686 - 211245 != 74442)
										{
											Game.sendMissionEvent(9734, 6);
											if (193111 - 69291 == 123820)
											{
												break;
											}
										}
									}
									else if (type == "PandoraBug")
									{
										if (287707 - 68750 != 218958)
										{
											Game.sendMissionEvent(9734, 7);
											if (131687 - 342089 == -210402)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "CaptainCrab"))
										{
											break;
										}
										if (203369 - 75428 != 127942)
										{
											Game.sendMissionEvent(9734, 8);
											if (130468 - 355379 != -224910)
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

	// Token: 0x0600B530 RID: 46384 RVA: 0x013996B0 File Offset: 0x013978B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (34486 - 479689 != -445203)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (151516 - 566089 != -414572)
			{
				hashtable.Add(71, CID);
				if (98313 - 322889 != -224575)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (227120 - 423424 != -196303)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (82797 - 597428 != -514630)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (98290 - 112251 != -13960)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (285089 - 222667 == 62422)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (63229 - 569058 != -505828)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (69947 - 402941 == -332994)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (130868 - 504936 != -374067)
											{
												this.LLHn1RM445b.OpCustom(61, hashtable, true);
												if (216336 - 417861 != -201524)
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

	// Token: 0x0600B531 RID: 46385 RVA: 0x0139993C File Offset: 0x01397B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (148597 - 433943 != -285346)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (185155 - 337259 == -152104)
			{
				if (!gameObject)
				{
					break;
				}
				if (132016 - 42486 != 89531)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (176154 - 517901 == -341747)
					{
						playerCameraControl.target = gameObject;
						if (5995 - 57502 == -51507)
						{
							this.StartGame();
							if (153283 - 247704 != -94420)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B532 RID: 46386 RVA: 0x01399A2C File Offset: 0x01397C2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (158375 - 313884 != -155508)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (26284 - 440891 == -414607)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (199965 - 496865 != -296899)
				{
					gameGui.ResetTeamBar();
					if (28280 - 398494 == -370214)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B533 RID: 46387 RVA: 0x01399AD8 File Offset: 0x01397CD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M973_PirateCave1.$onDeadPlayer$46166(this).GetEnumerator();
	}

	// Token: 0x0600B534 RID: 46388 RVA: 0x01399AE8 File Offset: 0x01397CE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (107745 - 273053 != -165307)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (67118 - 547241 != -480122)
			{
				this.QuFn1rSbqiV.target = Game.mPlayer;
				if (64105 - 143668 == -79563)
				{
					this.QuFn1rSbqiV.enabled = true;
					if (218176 - 45785 != 172392)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (169745 - 150228 == 19518)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (75224 - 63868 == 11357)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (93363 - 322779 == -229416)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (50977 - 147524 == -96547)
							{
								if (!gameGui)
								{
									break;
								}
								if (223168 - 347140 != -123971)
								{
									gameGui.enabled = true;
									if (97638 - 342435 != -244796)
									{
										gameGui.closeDeadMenu();
										if (187997 - 283575 == -95578)
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

	// Token: 0x0600B535 RID: 46389 RVA: 0x01399C94 File Offset: 0x01397E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (22993 - 338381 != -315388)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (272891 - 30750 != 242142)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (170880 - 319670 == -148790)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (10657 - 46116 != -35458)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B536 RID: 46390 RVA: 0x01399D58 File Offset: 0x01397F58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B537 RID: 46391 RVA: 0x01399D84 File Offset: 0x01397F84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (224025 - 78107 != 145918)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (220078 - 218388 != 1691)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (263273 - 142259 == 121014)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (269447 - 180091 != 89357)
					{
						Hashtable hashtable = new Hashtable();
						if (279307 - 241380 == 37927)
						{
							hashtable.Add(43, PlayerData.UID);
							if (84101 - 50140 == 33961)
							{
								hashtable.Add(71, nCID);
								if (293005 - 372428 == -79423)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (13991 - 486981 == -472990)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (157884 - 23230 != 134655)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (159306 - 495706 == -336400)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (193826 - 384910 == -191084)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (43477 - 414535 != -371057)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (48040 - 457715 == -409675)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (73827 - 530496 == -456669)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (10919 - 472675 != -461755)
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

	// Token: 0x0600B538 RID: 46392 RVA: 0x0139A0A4 File Offset: 0x013982A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M973_PirateCave1.$onChangePlayer$46172(data, this).GetEnumerator();
	}

	// Token: 0x0600B539 RID: 46393 RVA: 0x0139A0B4 File Offset: 0x013982B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M973_PirateCave1.$onGameComplete$46179(data, this).GetEnumerator();
	}

	// Token: 0x0600B53A RID: 46394 RVA: 0x0139A0C4 File Offset: 0x013982C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M973_PirateCave1.$ReturnToTown$46189(this).GetEnumerator();
	}

	// Token: 0x0600B53B RID: 46395 RVA: 0x0139A0D4 File Offset: 0x013982D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M973_PirateCave1.$ReturnToGuild$46194(this).GetEnumerator();
	}

	// Token: 0x0600B53C RID: 46396 RVA: 0x0139A0E4 File Offset: 0x013982E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M973_PirateCave1.$ReturnToCamp$46198(this).GetEnumerator();
	}

	// Token: 0x0600B53D RID: 46397 RVA: 0x0139A0F4 File Offset: 0x013982F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (152389 - 390024 != -237635)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (161280 - 160930 != 351)
			{
				Hashtable hashtable = new Hashtable();
				if (153365 - 20645 == 132720)
				{
					hashtable.Add(43, PlayerData.UID);
					if (290731 - 301426 != -10694)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (141088 - 140325 == 763)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B53E RID: 46398 RVA: 0x0139A1CC File Offset: 0x013983CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B53F RID: 46399 RVA: 0x0139A1E0 File Offset: 0x013983E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (295337 - 477338 != -182001)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (33745 - 478577 == -444832)
			{
				Hashtable hashtable = new Hashtable();
				if (108534 - 67558 != 40977)
				{
					if (Game.mNextGameCode == 30)
					{
						if (197953 - 62335 == 135619)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (267831 - 42028 != 225803)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (297115 - 291627 != 5488)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (197468 - 61179 == 136290)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (10751 - 406135 == -395383)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (217075 - 504266 == -287190)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (298066 - 377110 == -79043)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (204674 - 365718 == -161043)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (287548 - 236311 == 51238)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (138341 - 309014 != -170673)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (150418 - 370597 == -220178)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (98482 - 35806 != 62676)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (185415 - 313102 == -127686)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (43587 - 296148 != -252561)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (153085 - 96141 == 56945)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (101407 - 462441 != -361034)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (141334 - 244384 != -103050)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (86850 - 548803 != -461953)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (173514 - 139087 != 34427)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (20982 - 8093 != 12889)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (67094 - 50239 != 16855)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (283502 - 484946 != -201444)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (157521 - 54027 != 103494)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (269950 - 134615 != 135335)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (165385 - 428401 == -263015)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (80955 - 451118 != -370163)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (21735 - 566958 == -545222)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (68476 - 170485 != -102009)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (106325 - 53527 == 52798)
					{
						this.LLHn1RM445b.OpCustom(42, hashtable, true);
						if (259901 - 221338 == 38563)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B540 RID: 46400 RVA: 0x0139A794 File Offset: 0x01398994
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B541 RID: 46401 RVA: 0x0139A7A4 File Offset: 0x013989A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B542 RID: 46402 RVA: 0x0139A7A8 File Offset: 0x013989A8
	internal static bool wW8sqotpXF6G4HaVgQC9()
	{
		return true;
	}

	// Token: 0x0600B543 RID: 46403 RVA: 0x0139A7AC File Offset: 0x013989AC
	internal static bool lVrGORtpQWY3G5OE9YtO()
	{
		return false;
	}

	// Token: 0x04009D62 RID: 40290
	private LitePeer LLHn1RM445b;

	// Token: 0x04009D63 RID: 40291
	private PlayerCameraControl QuFn1rSbqiV;

	// Token: 0x04009D64 RID: 40292
	private float qAAn1xnZIYa;

	// Token: 0x04009D65 RID: 40293
	private Texture dDqn1TB5KJg;

	// Token: 0x04009D66 RID: 40294
	private int wJWn1YDB5M5;

	// Token: 0x04009D67 RID: 40295
	public GameObject sashimi;

	// Token: 0x04009D68 RID: 40296
	public GameObject bbq;

	// Token: 0x04009D69 RID: 40297
	public GameObject PirateCaveGateDust;

	// Token: 0x04009D6A RID: 40298
	private bool WCan13Gha7b;

	// Token: 0x04009D6B RID: 40299
	private bool dHHn1bUPMUo;

	// Token: 0x04009D6C RID: 40300
	private int GNQn1drgwQD;

	// Token: 0x02001E4D RID: 7757
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$46134 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B544 RID: 46404 RVA: 0x0139A7B0 File Offset: 0x013989B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$46134(Hashtable data, M973_PirateCave1 self_)
		{
			if (252983 - 457272 != -204289)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (59293 - 556015 != -496721)
				{
					base..ctor();
					if (18971 - 535147 == -516176)
					{
						this.$data$46145 = data;
						if (63494 - 386416 == -322922)
						{
							this.$self_$46146 = self_;
							if (292411 - 438132 == -145721)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B545 RID: 46405 RVA: 0x0139A86C File Offset: 0x01398A6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave1.$onGameEvent$46134.$(this.$data$46145, this.$self_$46146);
		}

		// Token: 0x0600B546 RID: 46406 RVA: 0x0139A880 File Offset: 0x01398A80
		internal static bool vm5GRutpkUjB68BBS8aO()
		{
			return true;
		}

		// Token: 0x0600B547 RID: 46407 RVA: 0x0139A884 File Offset: 0x01398A84
		internal static bool qOJ6hStpGyLCkeQt5Z9v()
		{
			return false;
		}

		// Token: 0x04009D6D RID: 40301
		internal Hashtable $data$46145;

		// Token: 0x04009D6E RID: 40302
		internal M973_PirateCave1 $self_$46146;

		// Token: 0x02001E4E RID: 7758
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B548 RID: 46408 RVA: 0x0139A888 File Offset: 0x01398A88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave1 self_)
			{
				if (286415 - 92524 != 193892)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (220044 - 31140 == 188904)
					{
						base..ctor();
						if (225889 - 189793 == 36096)
						{
							this.$data$46143 = data;
							if (30166 - 478078 != -447911)
							{
								this.$self_$46144 = self_;
								if (26801 - 529112 != -502310)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B549 RID: 46409 RVA: 0x0139A944 File Offset: 0x01398B44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91691 - 581142 != -489450)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8CE;
					case 2:
						Game.savePlayer();
						if (101416 - 11189 == 90228)
						{
							continue;
						}
						Game.mGameStage = 2;
						if (73073 - 146701 != -73628)
						{
							continue;
						}
						Application.LoadLevel("M973_PirateCave2");
						if (137929 - 343404 != -205474)
						{
							goto IL_236;
						}
						continue;
					default:
						if (191183 - 73038 == 118146)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (146486 - 588182 != -441695)
						{
							goto Block_59;
						}
						continue;
					}
					else
					{
						this.$returnCode$46135 = RuntimeServices.UnboxInt32(this.$data$46143[141]);
						if (278534 - 348602 != -70068)
						{
							continue;
						}
						this.$returnValue$46136 = RuntimeServices.UnboxInt32(this.$data$46143[145]);
						if (203876 - 124227 != 79649)
						{
							continue;
						}
						this.$ownerID$46137 = RuntimeServices.UnboxInt32(this.$data$46143[43]);
						if (198604 - 472813 == -274208)
						{
							continue;
						}
						this.$$switch$8614$46138 = this.$returnCode$46135;
						if (90524 - 100450 != -9926)
						{
							continue;
						}
						if (this.$$switch$8614$46138 == 9731)
						{
							if (11754 - 442848 == -431093)
							{
								continue;
							}
						}
						else if (this.$$switch$8614$46138 == -9731)
						{
							if (119950 - 193844 == -73893)
							{
								continue;
							}
							if (this.$self_$46144.wJWn1YDB5M5 < 1)
							{
								if (84900 - 570827 == -485926)
								{
									continue;
								}
								this.$self_$46144.wJWn1YDB5M5 = 1;
								if (249018 - 25341 == 223678)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (62859 - 54946 != 7913)
								{
									continue;
								}
								this.$mGameGui$46139 = (GameGui)this.$self_$46144.GetComponent(typeof(GameGui));
								if (1800 - 99193 == -97392)
								{
									continue;
								}
								this.$mGameGui$46139.close();
								if (49372 - 232295 != -182923)
								{
									continue;
								}
								this.$self_$46144.SendMessage("fadeOut");
								if (162428 - 403822 != -241394)
								{
									continue;
								}
								break;
							}
						}
						else if (this.$$switch$8614$46138 == 9732)
						{
							if (50191 - 467418 == -417226)
							{
								continue;
							}
						}
						else if (this.$$switch$8614$46138 == -9732)
						{
							if (120038 - 560397 == -440358)
							{
								continue;
							}
							this.$$switch$8612$46140 = this.$returnValue$46136;
							if (85478 - 210384 == -124905)
							{
								continue;
							}
							if (this.$$switch$8612$46140 == 1)
							{
								if (247119 - 43829 == 203291)
								{
									continue;
								}
								this.$self_$46144.WCan13Gha7b = true;
								if (107364 - 280537 == -173172)
								{
									continue;
								}
								if (this.$self_$46144.sashimi)
								{
									if (53079 - 316407 != -263328)
									{
										continue;
									}
									this.$mPirateAltar1$46141 = GameObject.Find("PirateAltar1");
									if (31683 - 254747 == -223063)
									{
										continue;
									}
									if (this.$mPirateAltar1$46141)
									{
										if (207652 - 527185 != -319533)
										{
											continue;
										}
										UnityEngine.Object.Instantiate(this.$self_$46144.sashimi, this.$mPirateAltar1$46141.transform.position, this.$mPirateAltar1$46141.transform.rotation);
										if (236999 - 546729 == -309729)
										{
											continue;
										}
									}
								}
								this.$self_$46144.SendMessage("newGameMessage", "Mission Objective: Sashimi has been placed.");
								if (180153 - 433826 == -253672)
								{
									continue;
								}
								if (this.$self_$46144.dHHn1bUPMUo)
								{
									if (88133 - 24306 == 63828)
									{
										continue;
									}
									this.$self_$46144.StartCoroutine_Auto(this.$self_$46144.PirateCaveGateEvent());
									if (159606 - 250570 == -90963)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8612$46140 == 2)
							{
								if (81346 - 209587 != -128241)
								{
									continue;
								}
								this.$self_$46144.dHHn1bUPMUo = true;
								if (296129 - 552716 == -256586)
								{
									continue;
								}
								if (this.$self_$46144.bbq)
								{
									if (173486 - 593714 != -420228)
									{
										continue;
									}
									this.$mPirateAltar2$46142 = GameObject.Find("PirateAltar2");
									if (72335 - 592204 != -519869)
									{
										continue;
									}
									if (this.$mPirateAltar2$46142)
									{
										if (140074 - 312766 != -172692)
										{
											continue;
										}
										UnityEngine.Object.Instantiate(this.$self_$46144.bbq, this.$mPirateAltar2$46142.transform.position, this.$mPirateAltar2$46142.transform.rotation);
										if (114181 - 103118 == 11064)
										{
											continue;
										}
									}
								}
								this.$self_$46144.SendMessage("newGameMessage", "Mission Objective: BBQ has been placed.");
								if (168959 - 320215 == -151255)
								{
									continue;
								}
								if (this.$self_$46144.WCan13Gha7b)
								{
									if (275753 - 56133 == 219621)
									{
										continue;
									}
									this.$self_$46144.StartCoroutine_Auto(this.$self_$46144.PirateCaveGateEvent());
									if (40501 - 417208 != -376707)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8612$46140 == 3)
							{
								if (2858 - 217439 == -214580)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$46137)
								{
									if (254201 - 209159 != 45042)
									{
										continue;
									}
									this.$self_$46144.spawnActor("GiantSandBug", 6, 1);
									if (121729 - 543462 == -421732)
									{
										continue;
									}
									this.$self_$46144.spawnActor("GiantSandBug", 6, 2);
									if (201076 - 480456 == -279379)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8612$46140 == 4)
							{
								if (128431 - 243833 == -115401)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$46137)
								{
									if (254554 - 280340 == -25785)
									{
										continue;
									}
									this.$self_$46144.spawnActor("GiantSandBug", 6, 3);
									if (24910 - 30235 == -5324)
									{
										continue;
									}
									this.$self_$46144.spawnActor("GiantSandBug", 6, 4);
									if (193497 - 447279 != -253782)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8614$46138 == 9734)
						{
							if (246470 - 318406 != -71936)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$46135);
							if (209157 - 568420 != -359263)
							{
								continue;
							}
						}
					}
					IL_460:
					this.YieldDefault(1);
					if (115516 - 27029 != 88487)
					{
						continue;
					}
					goto IL_8CE;
					IL_236:
					goto IL_460;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_59:
				IL_8CE:
				return false;
			}

			// Token: 0x0600B54A RID: 46410 RVA: 0x0139B234 File Offset: 0x01399434
			internal static bool DWFwGRtpHt5JJnig0WXQ()
			{
				return true;
			}

			// Token: 0x0600B54B RID: 46411 RVA: 0x0139B238 File Offset: 0x01399438
			internal static bool YjpwO9tpWBSqVcMFycDE()
			{
				return false;
			}

			// Token: 0x04009D6F RID: 40303
			internal int $returnCode$46135;

			// Token: 0x04009D70 RID: 40304
			internal int $returnValue$46136;

			// Token: 0x04009D71 RID: 40305
			internal int $ownerID$46137;

			// Token: 0x04009D72 RID: 40306
			internal int $$switch$8614$46138;

			// Token: 0x04009D73 RID: 40307
			internal GameGui $mGameGui$46139;

			// Token: 0x04009D74 RID: 40308
			internal int $$switch$8612$46140;

			// Token: 0x04009D75 RID: 40309
			internal GameObject $mPirateAltar1$46141;

			// Token: 0x04009D76 RID: 40310
			internal GameObject $mPirateAltar2$46142;

			// Token: 0x04009D77 RID: 40311
			internal Hashtable $data$46143;

			// Token: 0x04009D78 RID: 40312
			internal M973_PirateCave1 $self_$46144;
		}
	}

	// Token: 0x02001E4F RID: 7759
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$46147 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B54C RID: 46412 RVA: 0x0139B23C File Offset: 0x0139943C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$46147(M973_PirateCave1 self_)
		{
			if (25156 - 457462 != -432305)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (151746 - 108886 != 42861)
				{
					base..ctor();
					if (115071 - 34287 == 80784)
					{
						this.$self_$46152 = self_;
						if (121224 - 319766 == -198542)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B54D RID: 46413 RVA: 0x0139B2D4 File Offset: 0x013994D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave1.$StartEvent$46147.$(this.$self_$46152);
		}

		// Token: 0x0600B54E RID: 46414 RVA: 0x0139B2E4 File Offset: 0x013994E4
		internal static bool eQcsU9tpAs9RHYVRPXYE()
		{
			return true;
		}

		// Token: 0x0600B54F RID: 46415 RVA: 0x0139B2E8 File Offset: 0x013994E8
		internal static bool DAyNAltpl2yYcwly8CtG()
		{
			return false;
		}

		// Token: 0x04009D79 RID: 40313
		internal M973_PirateCave1 $self_$46152;

		// Token: 0x02001E50 RID: 7760
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B550 RID: 46416 RVA: 0x0139B2EC File Offset: 0x013994EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave1 self_)
			{
				if (285337 - 97577 != 187760)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161232 - 366017 != -204784)
					{
						base..ctor();
						if (157351 - 378902 == -221551)
						{
							this.$self_$46151 = self_;
							if (220148 - 44264 != 175885)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B551 RID: 46417 RVA: 0x0139B384 File Offset: 0x01399584
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (237981 - 431986 != -194004)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_8DF;
					case 1:
						goto IL_942;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (231093 - 392756 != -161662)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							this.$self_$46151.QuFn1rSbqiV.StartCoroutine_Auto(this.$self_$46151.QuFn1rSbqiV.slerpToObject("EventCamera2", (float)2));
							if (117608 - 135462 != -17854)
							{
								continue;
							}
							goto IL_3C;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (76963 - 586568 != -509604)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46148 = (StoryGui)this.$self_$46151.GetComponent(typeof(StoryGui));
							if (103752 - 298003 != -194251)
							{
								continue;
							}
							this.$mStoryTimer$46149 = 0f;
							if (271701 - 576918 != -305217)
							{
								continue;
							}
							if (!this.$mStoryGui$46148)
							{
								goto IL_791;
							}
							if (89612 - 287207 != -197595)
							{
								continue;
							}
							this.$mStoryGui$46148.startStoryMessage("Turtle1", "Guibo", eTalkType.friend);
							if (242429 - 156214 != 86215)
							{
								continue;
							}
							goto IL_5C0;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (108333 - 258937 != -150603)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46148.newStoryMessage("Turtle1", "Guibo", Language.getMessage("M973_PirateCave", 101), eTalkType.friend);
							if (238245 - 60608 == 177638)
							{
								continue;
							}
							this.$mStoryTimer$46149 = Time.time + 4f;
							if (221127 - 68501 != 152626)
							{
								continue;
							}
							goto IL_7CB;
						}
						break;
					case 5:
						goto IL_7F2;
					case 6:
						goto IL_7F2;
					case 7:
						goto IL_69C;
					case 8:
						goto IL_69C;
					case 9:
						goto IL_56C;
					case 10:
						goto IL_56C;
					case 11:
						break;
					case 12:
						break;
					case 13:
						goto IL_435;
					case 14:
						goto IL_435;
					case 15:
						goto IL_791;
					case 16:
						Game.mGameState = eGameState.Normal;
						if (152177 - 234432 != -82255)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (134533 - 111050 == 23484)
						{
							continue;
						}
						this.YieldDefault(1);
						if (223291 - 386645 != -163353)
						{
							goto Block_2;
						}
						continue;
					default:
						if (6336 - 196502 != -190166)
						{
							continue;
						}
						goto IL_8DF;
					}
					if (this.$mStoryTimer$46149 > Time.time)
					{
						if (54910 - 480257 != -425347)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_93;
						}
						if (15044 - 581989 != -566945)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (131191 - 503493 != -372301)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46148.newStoryMessage("Turtle1", "Guibo", Language.getMessage("M973_PirateCave", 105), eTalkType.friend);
						if (83314 - 417000 != -333686)
						{
							continue;
						}
						this.$mStoryTimer$46149 = Time.time + 4f;
						if (45832 - 383547 != -337715)
						{
							continue;
						}
						goto IL_40C;
					}
					IL_69C:
					if (this.$mStoryTimer$46149 > Time.time)
					{
						if (126787 - 74071 != 52716)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_690;
						}
						if (108911 - 433901 != -324990)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (75964 - 367290 != -291325)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46148.newStoryMessage("Turtle1", "Guibo", Language.getMessage("M973_PirateCave", 103), eTalkType.friend);
						if (289805 - 80915 == 208891)
						{
							continue;
						}
						this.$mStoryTimer$46149 = Time.time + 4f;
						if (161845 - 65195 != 96651)
						{
							goto Block_21;
						}
						continue;
					}
					IL_56C:
					if (this.$mStoryTimer$46149 > Time.time)
					{
						if (181486 - 479967 == -298480)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_55F;
						}
						if (274544 - 304952 == -30407)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (159496 - 213452 != -53955)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46148.newStoryMessage("Turtle1", "Guibo", Language.getMessage("M973_PirateCave", 104), eTalkType.friend);
						if (253050 - 328341 == -75290)
						{
							continue;
						}
						this.$mStoryTimer$46149 = Time.time + 4f;
						if (7601 - 408276 != -400674)
						{
							goto Block_12;
						}
						continue;
					}
					IL_7F2:
					if (this.$mStoryTimer$46149 > Time.time)
					{
						if (212829 - 318698 != -105869)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_7E6;
						}
						if (128838 - 121549 == 7290)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (87923 - 405588 != -317664)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46148.newStoryMessage("Turtle1", "Guibo", Language.getMessage("M973_PirateCave", 102), eTalkType.friend);
						if (116472 - 41940 == 74533)
						{
							continue;
						}
						this.$mStoryTimer$46149 = Time.time + 4f;
						if (225102 - 442987 != -217885)
						{
							continue;
						}
						goto IL_675;
					}
					IL_435:
					if (this.$mStoryTimer$46149 > Time.time)
					{
						if (177868 - 191843 == -13974)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_428;
						}
						if (99012 - 307473 != -208461)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (130892 - 504781 != -373888)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46148.close();
						if (247345 - 120071 != 127274)
						{
							continue;
						}
						goto IL_77A;
					}
					IL_791:
					this.$mGameGui$46150 = (GameGui)this.$self_$46151.GetComponent(typeof(GameGui));
					if (75987 - 57415 == 18573)
					{
						continue;
					}
					this.$mGameGui$46150.enabled = true;
					if (191309 - 221455 != -30146)
					{
						continue;
					}
					this.$self_$46151.QuFn1rSbqiV.enabled = true;
					if (260190 - 291577 != -31387)
					{
						continue;
					}
					goto IL_21B;
					IL_8DF:
					Debug.Log("StartEvent");
					if (81821 - 1141 != 80681)
					{
						this.$self_$46151.QuFn1rSbqiV.alignToObject("EventCamera1");
						if (244511 - 11776 == 232735)
						{
							this.$self_$46151.SendMessage("fadeIn");
							if (177093 - 273925 == -96832)
							{
								goto IL_45F;
							}
						}
					}
				}
				Block_2:
				goto IL_942;
				IL_3C:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_4:
				goto IL_942;
				IL_93:
				return this.YieldDefault(12);
				Block_12:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_21B:
				return this.Yield(16, new WaitForSeconds(0.5f));
				Block_21:
				return this.Yield(9, new WaitForSeconds(0.5f));
				goto IL_942;
				IL_40C:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_428:
				return this.YieldDefault(14);
				IL_45F:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_33:
				goto IL_942;
				IL_55F:
				return this.YieldDefault(10);
				IL_5C0:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_42:
				goto IL_942;
				IL_675:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_690:
				return this.YieldDefault(8);
				IL_77A:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_7CB:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_7E6:
				return this.YieldDefault(6);
				IL_942:
				return false;
			}

			// Token: 0x0600B552 RID: 46418 RVA: 0x0139BCE8 File Offset: 0x01399EE8
			internal static bool vXbn04tpymdOuVd3ZxeZ()
			{
				return true;
			}

			// Token: 0x0600B553 RID: 46419 RVA: 0x0139BCEC File Offset: 0x01399EEC
			internal static bool A7j29jtpS1Wc7hkbZdnq()
			{
				return false;
			}

			// Token: 0x04009D7A RID: 40314
			internal StoryGui $mStoryGui$46148;

			// Token: 0x04009D7B RID: 40315
			internal float $mStoryTimer$46149;

			// Token: 0x04009D7C RID: 40316
			internal GameGui $mGameGui$46150;

			// Token: 0x04009D7D RID: 40317
			internal M973_PirateCave1 $self_$46151;
		}
	}

	// Token: 0x02001E51 RID: 7761
	[CompilerGenerated]
	[Serializable]
	internal sealed class $PirateCaveGateEvent$46153 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B554 RID: 46420 RVA: 0x0139BCF0 File Offset: 0x01399EF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $PirateCaveGateEvent$46153(M973_PirateCave1 self_)
		{
			if (259314 - 296807 != -37493)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (189811 - 145075 == 44736)
				{
					base..ctor();
					if (118572 - 5354 != 113219)
					{
						this.$self_$46158 = self_;
						if (159314 - 351617 != -192302)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B555 RID: 46421 RVA: 0x0139BD88 File Offset: 0x01399F88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave1.$PirateCaveGateEvent$46153.$(this.$self_$46158);
		}

		// Token: 0x0600B556 RID: 46422 RVA: 0x0139BD98 File Offset: 0x01399F98
		internal static bool pyTsdFtpoovVcq0DaqrD()
		{
			return true;
		}

		// Token: 0x0600B557 RID: 46423 RVA: 0x0139BD9C File Offset: 0x01399F9C
		internal static bool lviHmutpEmK4I0YP7Q8L()
		{
			return false;
		}

		// Token: 0x04009D7E RID: 40318
		internal M973_PirateCave1 $self_$46158;

		// Token: 0x02001E52 RID: 7762
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B558 RID: 46424 RVA: 0x0139BDA0 File Offset: 0x01399FA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave1 self_)
			{
				if (18267 - 428806 != -410538)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (13947 - 413268 != -399320)
					{
						base..ctor();
						if (150543 - 445307 == -294764)
						{
							this.$self_$46157 = self_;
							if (54830 - 64533 == -9703)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B559 RID: 46425 RVA: 0x0139BE38 File Offset: 0x0139A038
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (32184 - 591847 != -559662)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2BB;
					case 1:
						goto IL_4C7;
					case 2:
						Game.mGameState = eGameState.AllHold;
						if (54364 - 38854 == 15510)
						{
							this.$self_$46157.QuFn1rSbqiV.StartCoroutine_Auto(this.$self_$46157.QuFn1rSbqiV.slerpToObject("EventCamera3", (float)2));
							if (7584 - 21238 != -13653)
							{
								this.$mGameGui$46154 = (GameGui)this.$self_$46157.GetComponent(typeof(GameGui));
								if (97538 - 342495 == -244957)
								{
									if (!this.$mGameGui$46154)
									{
										goto IL_5B;
									}
									if (174334 - 61457 == 112877)
									{
										this.$mGameGui$46154.close();
										if (133146 - 461346 == -328200)
										{
											goto IL_5B;
										}
									}
								}
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (247971 - 192901 != 55071)
							{
								goto Block_4;
							}
						}
						else
						{
							this.$mPirateCoveGate$46155 = GameObject.Find("PirateCoveGate");
							if (48997 - 98945 != -49947)
							{
								if (this.$mPirateCoveGate$46155)
								{
									if (149155 - 95562 == 53594)
									{
										break;
									}
									this.$mPirateCoveGate$46155.animation.Play();
									if (201925 - 547791 != -345866)
									{
										break;
									}
									this.$mPirateCoveGate$46155.audio.Play();
									if (77444 - 348997 != -271553)
									{
										break;
									}
									if (this.$self_$46157.PirateCaveGateDust)
									{
										if (107156 - 396674 != -289518)
										{
											break;
										}
										UnityEngine.Object.Instantiate(this.$self_$46157.PirateCaveGateDust, this.$mPirateCoveGate$46155.transform.position, Quaternion.identity);
										if (148272 - 378114 == -229841)
										{
											break;
										}
									}
									else
									{
										Debug.LogError("Missing mPirateCoveGate effect");
										if (172619 - 507141 != -334522)
										{
											break;
										}
									}
								}
								this.$mStoryGui$46156 = (StoryGui)this.$self_$46157.GetComponent(typeof(StoryGui));
								if (262409 - 88026 == 174383)
								{
									if (!this.$mStoryGui$46156)
									{
										goto IL_3CA;
									}
									if (208034 - 31928 == 176106)
									{
										this.$mStoryGui$46156.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
										if (285117 - 255947 != 29171)
										{
											goto Block_7;
										}
									}
								}
							}
						}
						break;
					case 4:
						this.$mStoryGui$46156.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 131), eTalkType.friend);
						if (255680 - 183776 == 71904)
						{
							goto IL_355;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (283810 - 208576 == 75234)
							{
								goto IL_242;
							}
						}
						else
						{
							this.$mStoryGui$46156.close();
							if (191573 - 101807 != 89767)
							{
								goto Block_15;
							}
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (42663 - 171037 == -128374)
							{
								goto IL_32B;
							}
						}
						else
						{
							Game.sendMissionEvent(9731, 2);
							if (172710 - 319978 == -147268)
							{
								this.YieldDefault(1);
								if (181498 - 4201 != 177298)
								{
									goto Block_12;
								}
							}
						}
						break;
					default:
						if (233785 - 251484 == -17699)
						{
							goto IL_2BB;
						}
						break;
					}
				}
				IL_5B:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_4:
				goto IL_4C7;
				Block_7:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_12:
				IL_242:
				goto IL_4C7;
				Block_15:
				goto IL_3CA;
				IL_2BB:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_32B:
				goto IL_4C7;
				IL_355:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_3CA:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_4C7:
				return false;
			}

			// Token: 0x0600B55A RID: 46426 RVA: 0x0139C320 File Offset: 0x0139A520
			internal static bool yUxHCrtp2MgTOAiqyrdL()
			{
				return true;
			}

			// Token: 0x0600B55B RID: 46427 RVA: 0x0139C324 File Offset: 0x0139A524
			internal static bool XX7kLttp8LqFieE7dGbG()
			{
				return false;
			}

			// Token: 0x04009D7F RID: 40319
			internal GameGui $mGameGui$46154;

			// Token: 0x04009D80 RID: 40320
			internal GameObject $mPirateCoveGate$46155;

			// Token: 0x04009D81 RID: 40321
			internal StoryGui $mStoryGui$46156;

			// Token: 0x04009D82 RID: 40322
			internal M973_PirateCave1 $self_$46157;
		}
	}

	// Token: 0x02001E53 RID: 7763
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToGuibo$46159 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B55C RID: 46428 RVA: 0x0139C328 File Offset: 0x0139A528
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToGuibo$46159(M973_PirateCave1 self_)
		{
			if (162496 - 137997 != 24499)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (259288 - 59373 != 199916)
				{
					base..ctor();
					if (262805 - 108783 != 154023)
					{
						this.$self_$46165 = self_;
						if (161748 - 297866 == -136118)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B55D RID: 46429 RVA: 0x0139C3C0 File Offset: 0x0139A5C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave1.$TalkToGuibo$46159.$(this.$self_$46165);
		}

		// Token: 0x0600B55E RID: 46430 RVA: 0x0139C3D0 File Offset: 0x0139A5D0
		internal static bool aQXbk0tpZGZ6Z59poI4Y()
		{
			return true;
		}

		// Token: 0x0600B55F RID: 46431 RVA: 0x0139C3D4 File Offset: 0x0139A5D4
		internal static bool Mur9aUtpCHeUqphpWdLw()
		{
			return false;
		}

		// Token: 0x04009D83 RID: 40323
		internal M973_PirateCave1 $self_$46165;

		// Token: 0x02001E54 RID: 7764
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B560 RID: 46432 RVA: 0x0139C3D8 File Offset: 0x0139A5D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave1 self_)
			{
				if (117599 - 558880 != -441280)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (286978 - 224846 != 62133)
					{
						base..ctor();
						if (272979 - 17471 != 255509)
						{
							this.$self_$46164 = self_;
							if (87351 - 100208 != -12856)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B561 RID: 46433 RVA: 0x0139C470 File Offset: 0x0139A670
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (265986 - 355651 != -89665)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4E9;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (89775 - 200195 != -110419)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46161.newStoryMessage("Turtle1", "Guibo", Language.getMessage("M973_PirateCave", 111 + UnityEngine.Random.Range(0, 3)), eTalkType.friend);
							if (30947 - 325950 == -295002)
							{
								continue;
							}
							this.$mStoryTimer$46162 = Time.time + 4f;
							if (203923 - 564973 != -361050)
							{
								continue;
							}
							goto IL_2CA;
						}
						break;
					case 3:
						goto IL_2F1;
					case 4:
						goto IL_2F1;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (148196 - 313832 != -165636)
							{
								continue;
							}
							goto IL_4A4;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (107892 - 346247 != -238355)
							{
								continue;
							}
							goto IL_2A8;
						}
						break;
					default:
						if (242609 - 527603 == -284993)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (251385 - 109918 != 141467)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mGameGui$46160 = (GameGui)this.$self_$46164.GetComponent(typeof(GameGui));
						if (119151 - 345161 == -226009)
						{
							continue;
						}
						this.$mStoryGui$46161 = (StoryGui)this.$self_$46164.GetComponent(typeof(StoryGui));
						if (223129 - 419938 != -196809)
						{
							continue;
						}
						this.$mStoryTimer$46162 = 0f;
						if (82830 - 456876 == -374045)
						{
							continue;
						}
						if (!this.$mGameGui$46160)
						{
							goto IL_2A8;
						}
						if (197683 - 361925 == -164241)
						{
							continue;
						}
						if (!this.$mStoryGui$46161)
						{
							goto IL_2A8;
						}
						if (159384 - 386176 == -226791)
						{
							continue;
						}
						Game.mGameState = eGameState.Hold;
						if (211979 - 105872 == 106108)
						{
							continue;
						}
						this.$mGameGui$46160.close();
						if (31401 - 417796 != -386395)
						{
							continue;
						}
						this.$mTurtle1$46163 = GameObject.Find("Turtle1");
						if (287852 - 421287 != -133435)
						{
							continue;
						}
						if (!Game.mPlayer)
						{
							goto IL_320;
						}
						if (34281 - 589491 == -555209)
						{
							continue;
						}
						if (!this.$mTurtle1$46163)
						{
							goto IL_320;
						}
						if (63594 - 106976 != -43382)
						{
							continue;
						}
						Game.mPlayer.SendMessage("turnToPos", this.$mTurtle1$46163.transform.position);
						if (128380 - 282233 != -153853)
						{
							continue;
						}
						IL_118:
						this.$mStoryGui$46161.startStoryMessage("Turtle1", "Guibo", eTalkType.friend);
						if (280512 - 533099 != -252587)
						{
							continue;
						}
						goto IL_1D1;
						IL_320:
						Debug.LogError("Cannot find Turtle1");
						if (180554 - 370947 != -190392)
						{
							goto IL_118;
						}
						continue;
					}
					IL_2F1:
					if (this.$mStoryTimer$46162 > Time.time)
					{
						if (156351 - 124565 != 31786)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2E5;
						}
						if (69743 - 537727 != -467984)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (289266 - 488124 != -198858)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$46161.close();
						if (193761 - 551011 == -357249)
						{
							continue;
						}
						this.$mGameGui$46160.enabled = true;
						if (274814 - 565638 != -290823)
						{
							goto Block_29;
						}
						continue;
					}
					IL_2A8:
					this.YieldDefault(1);
				}
				while (80076 - 348129 == -268052);
				goto IL_4E9;
				IL_1D1:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_17:
				goto IL_4E9;
				IL_2CA:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_2E5:
				return this.YieldDefault(4);
				goto IL_4E9;
				Block_29:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_4A4:
				IL_4E9:
				return false;
			}

			// Token: 0x0600B562 RID: 46434 RVA: 0x0139C978 File Offset: 0x0139AB78
			internal static bool Q2TOE1tpLGFeRoH65OfI()
			{
				return true;
			}

			// Token: 0x0600B563 RID: 46435 RVA: 0x0139C97C File Offset: 0x0139AB7C
			internal static bool OLamLntpOK1oX4LRK2av()
			{
				return false;
			}

			// Token: 0x04009D84 RID: 40324
			internal GameGui $mGameGui$46160;

			// Token: 0x04009D85 RID: 40325
			internal StoryGui $mStoryGui$46161;

			// Token: 0x04009D86 RID: 40326
			internal float $mStoryTimer$46162;

			// Token: 0x04009D87 RID: 40327
			internal GameObject $mTurtle1$46163;

			// Token: 0x04009D88 RID: 40328
			internal M973_PirateCave1 $self_$46164;
		}
	}

	// Token: 0x02001E55 RID: 7765
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46166 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B564 RID: 46436 RVA: 0x0139C980 File Offset: 0x0139AB80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46166(M973_PirateCave1 self_)
		{
			if (123500 - 16351 != 107149)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (149485 - 32963 != 116523)
				{
					base..ctor();
					if (279750 - 553311 == -273561)
					{
						this.$self_$46171 = self_;
						if (226368 - 554064 != -327695)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B565 RID: 46437 RVA: 0x0139CA18 File Offset: 0x0139AC18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave1.$onDeadPlayer$46166.$(this.$self_$46171);
		}

		// Token: 0x0600B566 RID: 46438 RVA: 0x0139CA28 File Offset: 0x0139AC28
		internal static bool dwDIZktpmIorXWALCGAk()
		{
			return true;
		}

		// Token: 0x0600B567 RID: 46439 RVA: 0x0139CA2C File Offset: 0x0139AC2C
		internal static bool XTYH06tpFu4r1O8AblK4()
		{
			return false;
		}

		// Token: 0x04009D89 RID: 40329
		internal M973_PirateCave1 $self_$46171;

		// Token: 0x02001E56 RID: 7766
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B568 RID: 46440 RVA: 0x0139CA30 File Offset: 0x0139AC30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave1 self_)
			{
				if (107407 - 250639 != -143231)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (318 - 240495 == -240177)
					{
						base..ctor();
						if (69010 - 52426 == 16584)
						{
							this.$self_$46170 = self_;
							if (147336 - 219529 == -72193)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B569 RID: 46441 RVA: 0x0139CAC8 File Offset: 0x0139ACC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (103943 - 265193 != -161250)
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
							goto IL_25D;
						}
						if (160390 - 139955 == 20436)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (259045 - 438130 != -179084)
							{
								goto IL_25D;
							}
							continue;
						}
						IL_23B:
						this.YieldDefault(1);
						if (240050 - 105110 != 134941)
						{
							goto Block_18;
						}
						continue;
						IL_25D:
						Game.mGameState = eGameState.Hold;
						if (184954 - 101874 == 83081)
						{
							continue;
						}
						this.$mStoryGui$46167 = (StoryGui)this.$self_$46170.GetComponent(typeof(StoryGui));
						if (97411 - 187777 != -90366)
						{
							continue;
						}
						if (this.$mStoryGui$46167)
						{
							if (20420 - 442648 != -422228)
							{
								continue;
							}
							this.$mStoryGui$46167.close();
							if (123612 - 74578 == 49035)
							{
								continue;
							}
						}
						this.$mChangeGui$46168 = (ChangeGui)this.$self_$46170.GetComponent(typeof(ChangeGui));
						if (282864 - 161850 == 121015)
						{
							continue;
						}
						if (this.$mChangeGui$46168)
						{
							if (52834 - 512709 != -459875)
							{
								continue;
							}
							this.$mChangeGui$46168.close();
							if (284370 - 263331 != 21039)
							{
								continue;
							}
						}
						this.$mGameGui$46169 = (GameGui)this.$self_$46170.GetComponent(typeof(GameGui));
						if (232257 - 285057 != -52800)
						{
							continue;
						}
						if (!this.$mGameGui$46169)
						{
							goto IL_23B;
						}
						if (184680 - 503488 != -318808)
						{
							continue;
						}
						if (!this.$mGameGui$46169.enabled)
						{
							if (279796 - 419756 == -139959)
							{
								continue;
							}
							this.$mGameGui$46169.enabled = true;
							if (174497 - 248119 != -73622)
							{
								continue;
							}
						}
						this.$mGameGui$46169.openDeadMenu();
						if (25335 - 436167 != -410831)
						{
							goto IL_23B;
						}
						continue;
					default:
						if (243455 - 7571 == 235885)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (272366 - 512061 == -239694);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_18:
				IL_2F9:
				return false;
			}

			// Token: 0x0600B56A RID: 46442 RVA: 0x0139CDE0 File Offset: 0x0139AFE0
			internal static bool iMwZyAtpMZUfIpttfhEj()
			{
				return true;
			}

			// Token: 0x0600B56B RID: 46443 RVA: 0x0139CDE4 File Offset: 0x0139AFE4
			internal static bool LfVty3tpxOErpxOAkjAI()
			{
				return false;
			}

			// Token: 0x04009D8A RID: 40330
			internal StoryGui $mStoryGui$46167;

			// Token: 0x04009D8B RID: 40331
			internal ChangeGui $mChangeGui$46168;

			// Token: 0x04009D8C RID: 40332
			internal GameGui $mGameGui$46169;

			// Token: 0x04009D8D RID: 40333
			internal M973_PirateCave1 $self_$46170;
		}
	}

	// Token: 0x02001E57 RID: 7767
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46172 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B56C RID: 46444 RVA: 0x0139CDE8 File Offset: 0x0139AFE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46172(Hashtable data, M973_PirateCave1 self_)
		{
			if (236063 - 418609 != -182545)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (250242 - 364958 != -114715)
				{
					base..ctor();
					if (7680 - 304194 == -296514)
					{
						this.$data$46177 = data;
						if (227968 - 402726 == -174758)
						{
							this.$self_$46178 = self_;
							if (6974 - 310939 != -303964)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B56D RID: 46445 RVA: 0x0139CEA4 File Offset: 0x0139B0A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave1.$onChangePlayer$46172.$(this.$data$46177, this.$self_$46178);
		}

		// Token: 0x0600B56E RID: 46446 RVA: 0x0139CEB8 File Offset: 0x0139B0B8
		internal static bool OOfNVFtpgfoqbSa6NJ2U()
		{
			return true;
		}

		// Token: 0x0600B56F RID: 46447 RVA: 0x0139CEBC File Offset: 0x0139B0BC
		internal static bool idqo7rtpfAe1AMMna88p()
		{
			return false;
		}

		// Token: 0x04009D8E RID: 40334
		internal Hashtable $data$46177;

		// Token: 0x04009D8F RID: 40335
		internal M973_PirateCave1 $self_$46178;

		// Token: 0x02001E58 RID: 7768
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B570 RID: 46448 RVA: 0x0139CEC0 File Offset: 0x0139B0C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave1 self_)
			{
				if (231655 - 417811 != -186156)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (157343 - 105354 != 51990)
					{
						base..ctor();
						if (12449 - 408016 == -395567)
						{
							this.$data$46175 = data;
							if (70195 - 479142 != -408946)
							{
								this.$self_$46176 = self_;
								if (273292 - 543242 == -269950)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B571 RID: 46449 RVA: 0x0139CF7C File Offset: 0x0139B17C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (130408 - 112934 != 17474)
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
							if (181429 - 257646 == -76216)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (132641 - 235588 != -102947)
							{
								continue;
							}
							this.$mGameGui$46174 = (GameGui)this.$self_$46176.GetComponent(typeof(GameGui));
							if (16428 - 596023 == -579594)
							{
								continue;
							}
							this.$mGameGui$46174.enabled = true;
							if (216049 - 340602 != -124553)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (224624 - 527079 != -302454)
						{
							goto Block_13;
						}
						continue;
					default:
						if (262610 - 483416 != -220806)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (34115 - 142174 == -108059)
					{
						this.$self_$46176.SendMessage("onCreatePlayer", this.$data$46175);
						if (279594 - 52868 == 226726)
						{
							this.$mChangeGui$46173 = (ChangeGui)this.$self_$46176.GetComponent(typeof(ChangeGui));
							if (189840 - 591009 != -401168)
							{
								if (!this.$mChangeGui$46173.enabled)
								{
									break;
								}
								if (13178 - 189795 == -176617)
								{
									this.$mChangeGui$46173.close();
									if (131912 - 332328 == -200416)
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

			// Token: 0x0600B572 RID: 46450 RVA: 0x0139D1A0 File Offset: 0x0139B3A0
			internal static bool AqxxgMtpnJAI4mE81E2L()
			{
				return true;
			}

			// Token: 0x0600B573 RID: 46451 RVA: 0x0139D1A4 File Offset: 0x0139B3A4
			internal static bool lrworBtp6D2FoKbWXE36()
			{
				return false;
			}

			// Token: 0x04009D90 RID: 40336
			internal ChangeGui $mChangeGui$46173;

			// Token: 0x04009D91 RID: 40337
			internal GameGui $mGameGui$46174;

			// Token: 0x04009D92 RID: 40338
			internal Hashtable $data$46175;

			// Token: 0x04009D93 RID: 40339
			internal M973_PirateCave1 $self_$46176;
		}
	}

	// Token: 0x02001E59 RID: 7769
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46179 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B574 RID: 46452 RVA: 0x0139D1A8 File Offset: 0x0139B3A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46179(Hashtable data, M973_PirateCave1 self_)
		{
			if (294506 - 521847 != -227340)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (1725 - 310794 != -309068)
				{
					base..ctor();
					if (79087 - 311077 != -231989)
					{
						this.$data$46187 = data;
						if (203917 - 24012 == 179905)
						{
							this.$self_$46188 = self_;
							if (37240 - 379998 != -342757)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B575 RID: 46453 RVA: 0x0139D264 File Offset: 0x0139B464
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave1.$onGameComplete$46179.$(this.$data$46187, this.$self_$46188);
		}

		// Token: 0x0600B576 RID: 46454 RVA: 0x0139D278 File Offset: 0x0139B478
		internal static bool ngTlSPtpiokrZXW5uPrF()
		{
			return true;
		}

		// Token: 0x0600B577 RID: 46455 RVA: 0x0139D27C File Offset: 0x0139B47C
		internal static bool p4Cc6YtpKJOkOBA4Af1B()
		{
			return false;
		}

		// Token: 0x04009D94 RID: 40340
		internal Hashtable $data$46187;

		// Token: 0x04009D95 RID: 40341
		internal M973_PirateCave1 $self_$46188;

		// Token: 0x02001E5A RID: 7770
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B578 RID: 46456 RVA: 0x0139D280 File Offset: 0x0139B480
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave1 self_)
			{
				if (110075 - 21848 != 88228)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (196493 - 319613 != -123119)
					{
						base..ctor();
						if (260998 - 67727 != 193272)
						{
							this.$data$46185 = data;
							if (129416 - 266319 != -136902)
							{
								this.$self_$46186 = self_;
								if (98100 - 152993 != -54892)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B579 RID: 46457 RVA: 0x0139D33C File Offset: 0x0139B53C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (3174 - 556244 != -553069)
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
						this.$mCompleteGui$46181 = (CompleteGui)this.$self_$46186.GetComponent(typeof(CompleteGui));
						if (194297 - 542481 != -348184)
						{
							continue;
						}
						this.$mCompleteGui$46181.Init();
						if (129027 - 404926 != -275899)
						{
							continue;
						}
						this.$mCompleteGui$46181.readData(this.$data$46185);
						if (171787 - 94209 != 77578)
						{
							continue;
						}
						if (this.$result$46180 == 1)
						{
							if (64504 - 56646 != 7858)
							{
								continue;
							}
							this.$mCompleteGui$46181.displayResult(eCompleteType.Success);
							if (116690 - 35108 != 81582)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46181.displayResult(eCompleteType.Failed);
							if (140767 - 317205 == -176437)
							{
								continue;
							}
						}
						this.$mGameGui$46182 = (GameGui)this.$self_$46186.GetComponent(typeof(GameGui));
						if (3375 - 305123 == -301747)
						{
							continue;
						}
						this.$mStoryGui$46183 = (StoryGui)this.$self_$46186.GetComponent(typeof(StoryGui));
						if (34032 - 47022 != -12990)
						{
							continue;
						}
						this.$mChangeGui$46184 = (ChangeGui)this.$self_$46186.GetComponent(typeof(ChangeGui));
						if (266815 - 398766 != -131951)
						{
							continue;
						}
						if (this.$mGameGui$46182)
						{
							if (58457 - 388543 == -330085)
							{
								continue;
							}
							this.$mGameGui$46182.close();
							if (214861 - 351799 == -136937)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46183)
						{
							if (61186 - 169521 == -108334)
							{
								continue;
							}
							this.$mStoryGui$46183.close();
							if (87284 - 482366 == -395081)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46184)
						{
							if (60743 - 384081 == -323337)
							{
								continue;
							}
							this.$mChangeGui$46184.disable();
							if (232106 - 207416 == 24691)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (177723 - 498354 != -320630)
						{
							goto Block_4;
						}
						continue;
					default:
						if (147096 - 493774 == -346677)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46185[31]);
					if (22756 - 155493 == -132737)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (264967 - 395470 == -130503)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (130776 - 198998 != -68221)
							{
								this.$result$46180 = RuntimeServices.UnboxInt32(this.$data$46185[31]);
								if (146520 - 501822 != -355301)
								{
									goto Block_16;
								}
							}
						}
					}
				}
				Block_4:
				goto IL_3DB;
				Block_16:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600B57A RID: 46458 RVA: 0x0139D738 File Offset: 0x0139B938
			internal static bool Fvn5smtpdsKRJNYl8Zsa()
			{
				return true;
			}

			// Token: 0x0600B57B RID: 46459 RVA: 0x0139D73C File Offset: 0x0139B93C
			internal static bool PVPOvttpJhXVq5v1d5e0()
			{
				return false;
			}

			// Token: 0x04009D96 RID: 40342
			internal int $result$46180;

			// Token: 0x04009D97 RID: 40343
			internal CompleteGui $mCompleteGui$46181;

			// Token: 0x04009D98 RID: 40344
			internal GameGui $mGameGui$46182;

			// Token: 0x04009D99 RID: 40345
			internal StoryGui $mStoryGui$46183;

			// Token: 0x04009D9A RID: 40346
			internal ChangeGui $mChangeGui$46184;

			// Token: 0x04009D9B RID: 40347
			internal Hashtable $data$46185;

			// Token: 0x04009D9C RID: 40348
			internal M973_PirateCave1 $self_$46186;
		}
	}

	// Token: 0x02001E5B RID: 7771
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46189 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B57C RID: 46460 RVA: 0x0139D740 File Offset: 0x0139B940
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46189(M973_PirateCave1 self_)
		{
			if (264817 - 442801 != -177983)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (50651 - 58507 != -7855)
				{
					base..ctor();
					if (21772 - 597110 == -575338)
					{
						this.$self_$46193 = self_;
						if (75175 - 566955 != -491779)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B57D RID: 46461 RVA: 0x0139D7D8 File Offset: 0x0139B9D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave1.$ReturnToTown$46189.$(this.$self_$46193);
		}

		// Token: 0x0600B57E RID: 46462 RVA: 0x0139D7E8 File Offset: 0x0139B9E8
		internal static bool OxIBFotpDsm80wgH0IYP()
		{
			return true;
		}

		// Token: 0x0600B57F RID: 46463 RVA: 0x0139D7EC File Offset: 0x0139B9EC
		internal static bool HcIAd6tpv1TiPUbJ4UZE()
		{
			return false;
		}

		// Token: 0x04009D9D RID: 40349
		internal M973_PirateCave1 $self_$46193;

		// Token: 0x02001E5C RID: 7772
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B580 RID: 46464 RVA: 0x0139D7F0 File Offset: 0x0139B9F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave1 self_)
			{
				if (290565 - 488286 != -197720)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (194676 - 464194 != -269517)
					{
						base..ctor();
						if (144465 - 83218 == 61247)
						{
							this.$self_$46192 = self_;
							if (265931 - 375668 == -109737)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B581 RID: 46465 RVA: 0x0139D888 File Offset: 0x0139BA88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211683 - 128595 != 83088)
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
						this.$self_$46192.LeaveGame();
						if (257740 - 462610 != -204870)
						{
							continue;
						}
						this.YieldDefault(1);
						if (84617 - 40612 != 44006)
						{
							goto Block_26;
						}
						continue;
					default:
						if (96768 - 596597 == -499828)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (100512 - 368423 != -267910)
					{
						Game.mStateTime = Time.time;
						if (215784 - 459993 != -244208)
						{
							this.$$switch$8620$46190 = PlayerData.SaveGuild;
							if (106279 - 574138 == -467859)
							{
								if (this.$$switch$8620$46190 == 1)
								{
									if (243757 - 6605 == 237153)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (12483 - 505958 == -493474)
									{
										continue;
									}
								}
								else if (this.$$switch$8620$46190 == 2)
								{
									if (116588 - 188963 == -72374)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (38460 - 402343 != -363883)
									{
										continue;
									}
								}
								else if (this.$$switch$8620$46190 == 3)
								{
									if (98039 - 596267 == -498227)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (33545 - 16478 == 17068)
									{
										continue;
									}
								}
								else if (this.$$switch$8620$46190 == 4)
								{
									if (267365 - 583943 != -316578)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (74607 - 553517 != -478910)
									{
										continue;
									}
								}
								else if (this.$$switch$8620$46190 == 5)
								{
									if (169438 - 592888 == -423449)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (20485 - 120319 == -99833)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (180283 - 189527 == -9243)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (277353 - 469455 != -192102)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (280474 - 234466 == 46009)
									{
										continue;
									}
								}
								this.$mGameGui$46191 = (GameGui)this.$self_$46192.GetComponent(typeof(GameGui));
								if (286259 - 407984 == -121725)
								{
									if (this.$mGameGui$46191)
									{
										if (97541 - 348334 != -250793)
										{
											continue;
										}
										this.$mGameGui$46191.close();
										if (217269 - 22708 != 194561)
										{
											continue;
										}
									}
									this.$self_$46192.SendMessage("fadeOut");
									if (208547 - 119770 != 88778)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_26:
				IL_3AD:
				return false;
			}

			// Token: 0x0600B582 RID: 46466 RVA: 0x0139DC54 File Offset: 0x0139BE54
			internal static bool gHkjZOtpRRHS68X61ntU()
			{
				return true;
			}

			// Token: 0x0600B583 RID: 46467 RVA: 0x0139DC58 File Offset: 0x0139BE58
			internal static bool UTwAgDtpwXhyxrZyh7S2()
			{
				return false;
			}

			// Token: 0x04009D9E RID: 40350
			internal int $$switch$8620$46190;

			// Token: 0x04009D9F RID: 40351
			internal GameGui $mGameGui$46191;

			// Token: 0x04009DA0 RID: 40352
			internal M973_PirateCave1 $self_$46192;
		}
	}

	// Token: 0x02001E5D RID: 7773
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46194 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B584 RID: 46468 RVA: 0x0139DC5C File Offset: 0x0139BE5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46194(M973_PirateCave1 self_)
		{
			if (106473 - 128688 != -22215)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (271305 - 241814 != 29492)
				{
					base..ctor();
					if (142562 - 307636 != -165073)
					{
						this.$self_$46197 = self_;
						if (48536 - 248088 == -199552)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B585 RID: 46469 RVA: 0x0139DCF4 File Offset: 0x0139BEF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave1.$ReturnToGuild$46194.$(this.$self_$46197);
		}

		// Token: 0x0600B586 RID: 46470 RVA: 0x0139DD04 File Offset: 0x0139BF04
		internal static bool ndiAbBtpqtHwxC9tf2tq()
		{
			return true;
		}

		// Token: 0x0600B587 RID: 46471 RVA: 0x0139DD08 File Offset: 0x0139BF08
		internal static bool AsYUn2tp7MhKl0epgGqV()
		{
			return false;
		}

		// Token: 0x04009DA1 RID: 40353
		internal M973_PirateCave1 $self_$46197;

		// Token: 0x02001E5E RID: 7774
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B588 RID: 46472 RVA: 0x0139DD0C File Offset: 0x0139BF0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave1 self_)
			{
				if (34741 - 25449 != 9292)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (228766 - 575081 == -346315)
					{
						base..ctor();
						if (83135 - 118877 != -35741)
						{
							this.$self_$46196 = self_;
							if (92199 - 307528 != -215328)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B589 RID: 46473 RVA: 0x0139DDA4 File Offset: 0x0139BFA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66052 - 315803 != -249751)
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
						this.$self_$46196.LeaveGame();
						if (205696 - 442596 != -236900)
						{
							continue;
						}
						this.YieldDefault(1);
						if (274567 - 292350 != -17783)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (35139 - 483974 == -448834)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (80924 - 439577 == -358653)
					{
						Game.mStateTime = Time.time;
						if (13775 - 149087 == -135312)
						{
							Game.mNextGameCode = 31;
							if (239166 - 483468 == -244302)
							{
								this.$mGameGui$46195 = (GameGui)this.$self_$46196.GetComponent(typeof(GameGui));
								if (274576 - 343704 != -69127)
								{
									if (this.$mGameGui$46195)
									{
										if (284307 - 244972 == 39336)
										{
											continue;
										}
										this.$mGameGui$46195.close();
										if (61857 - 59548 != 2309)
										{
											continue;
										}
									}
									this.$self_$46196.SendMessage("fadeOut");
									if (257634 - 394298 != -136663)
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

			// Token: 0x0600B58A RID: 46474 RVA: 0x0139DF80 File Offset: 0x0139C180
			internal static bool c3fro3tpPqLeelGFJjn3()
			{
				return true;
			}

			// Token: 0x0600B58B RID: 46475 RVA: 0x0139DF84 File Offset: 0x0139C184
			internal static bool DaO4WKtp0TFDpqYxG53B()
			{
				return false;
			}

			// Token: 0x04009DA2 RID: 40354
			internal GameGui $mGameGui$46195;

			// Token: 0x04009DA3 RID: 40355
			internal M973_PirateCave1 $self_$46196;
		}
	}

	// Token: 0x02001E5F RID: 7775
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46198 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B58C RID: 46476 RVA: 0x0139DF88 File Offset: 0x0139C188
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46198(M973_PirateCave1 self_)
		{
			if (130905 - 483259 != -352354)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (124782 - 375579 == -250797)
				{
					base..ctor();
					if (234503 - 286145 == -51642)
					{
						this.$self_$46201 = self_;
						if (183107 - 424928 != -241820)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B58D RID: 46477 RVA: 0x0139E020 File Offset: 0x0139C220
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave1.$ReturnToCamp$46198.$(this.$self_$46201);
		}

		// Token: 0x0600B58E RID: 46478 RVA: 0x0139E030 File Offset: 0x0139C230
		internal static bool FmwZ1wtpbiC3WTXIqMTO()
		{
			return true;
		}

		// Token: 0x0600B58F RID: 46479 RVA: 0x0139E034 File Offset: 0x0139C234
		internal static bool fYIFN8tpuZohpbl6hgcm()
		{
			return false;
		}

		// Token: 0x04009DA4 RID: 40356
		internal M973_PirateCave1 $self_$46201;

		// Token: 0x02001E60 RID: 7776
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B590 RID: 46480 RVA: 0x0139E038 File Offset: 0x0139C238
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave1 self_)
			{
				if (247638 - 391186 != -143547)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60790 - 252698 == -191908)
					{
						base..ctor();
						if (93245 - 309317 == -216072)
						{
							this.$self_$46200 = self_;
							if (21376 - 488989 != -467612)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B591 RID: 46481 RVA: 0x0139E0D0 File Offset: 0x0139C2D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (218514 - 434631 != -216117)
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
						this.$self_$46200.LeaveGame();
						if (200330 - 202727 == -2396)
						{
							continue;
						}
						this.YieldDefault(1);
						if (49453 - 55403 != -5949)
						{
							goto Block_2;
						}
						continue;
					default:
						if (275357 - 552060 == -276702)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (203619 - 302214 == -98595)
					{
						Game.mStateTime = Time.time;
						if (162832 - 104932 != 57901)
						{
							Game.mNextGameCode = 33;
							if (267053 - 571016 != -303962)
							{
								this.$mGameGui$46199 = (GameGui)this.$self_$46200.GetComponent(typeof(GameGui));
								if (280674 - 59506 == 221168)
								{
									if (this.$mGameGui$46199)
									{
										if (275263 - 52622 != 222641)
										{
											continue;
										}
										this.$mGameGui$46199.close();
										if (118770 - 405955 == -287184)
										{
											continue;
										}
									}
									this.$self_$46200.SendMessage("fadeOut");
									if (281696 - 211918 != 69779)
									{
										goto Block_7;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				Block_7:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600B592 RID: 46482 RVA: 0x0139E2AC File Offset: 0x0139C4AC
			internal static bool vla56ftpITabdLJwT4O5()
			{
				return true;
			}

			// Token: 0x0600B593 RID: 46483 RVA: 0x0139E2B0 File Offset: 0x0139C4B0
			internal static bool UKZgOMtpBeWZcqgrZdUu()
			{
				return false;
			}

			// Token: 0x04009DA5 RID: 40357
			internal GameGui $mGameGui$46199;

			// Token: 0x04009DA6 RID: 40358
			internal M973_PirateCave1 $self_$46200;
		}
	}
}
