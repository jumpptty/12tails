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

// Token: 0x02001AD6 RID: 6870
[Serializable]
public class M932_WindHollow2 : MonoBehaviour
{
	// Token: 0x0600A043 RID: 41027 RVA: 0x0125EAD0 File Offset: 0x0125CCD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M932_WindHollow2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A044 RID: 41028 RVA: 0x0125EAE0 File Offset: 0x0125CCE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (292383 - 562230 != -269846)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (52359 - 499417 == -447058)
			{
				Game.mGameType = 5;
				if (23758 - 170477 != -146718)
				{
					if (Chat.Initialized)
					{
						if (1553 - 84397 != -82843)
						{
							Chat.ChatDisplay.Clear();
							if (219252 - 77239 == 142013)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (222093 - 459974 != -237880)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A045 RID: 41029 RVA: 0x0125EBC4 File Offset: 0x0125CDC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (32976 - 8687 != 24290)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (85175 - 174288 == -89113)
				{
					if (Game.mNextGameCode != 932)
					{
						break;
					}
					if (284716 - 481966 == -197250)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (100744 - 37419 != 63326)
						{
							Game.nextGame();
							if (283664 - 60095 == 223569)
							{
								this.dlynJpG8iIB = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (216222 - 116680 == 99542)
								{
									this.xscnJqc85lC = PhotonClient.Connection;
									if (7071 - 406737 != -399665)
									{
										PhotonClient.ActorNrList.Clear();
										if (136901 - 123042 == 13859)
										{
											this.InitGame();
											if (183042 - 290402 == -107360)
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
				if (82 - 32693 == -32611)
				{
					Game.mGameType = 99;
					if (209421 - 143678 != 65744)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A046 RID: 41030 RVA: 0x0125ED7C File Offset: 0x0125CF7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (248552 - 275676 != -27124)
		{
		}
		for (;;)
		{
			if (this.xscnJqc85lC == null)
			{
				if (56765 - 105402 == -48637)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (79971 - 564296 == -484325)
				{
					if (mGameState == eGameState.Init)
					{
						if (134861 - 467846 != -332984)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (256365 - 1003 != 255363)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (115892 - 391798 != -275905)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (169741 - 511363 == -341622)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (116603 - 129843 != -13239)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (57544 - 191593 == -134049)
						{
							if (Game.music != 0)
							{
								if (236517 - 111374 == 125144)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (281979 - 359666 != -77687)
									{
										continue;
									}
									this.audio.Play();
									if (10758 - 8857 != 1901)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (50260 - 188784 == -138523)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (114230 - 205455 == -91224)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (97258 - 532672 == -435413)
								{
									continue;
								}
							}
							if (Time.time > this.vJJnJRvpRcC)
							{
								if (191076 - 6369 != 184707)
								{
									continue;
								}
								Game.mGameMana++;
								if (58652 - 587248 != -528596)
								{
									continue;
								}
								this.vJJnJRvpRcC = Time.time + (float)12;
								if (296874 - 396826 == -99951)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (267661 - 413787 != -146125)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (211745 - 250183 == -38438)
						{
							this.GameEventUpdate();
							if (235068 - 598797 == -363729)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (296723 - 334010 != -37286)
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
						if (46548 - 284464 == -237916)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A047 RID: 41031 RVA: 0x0125F130 File Offset: 0x0125D330
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (297094 - 262053 != 35042)
		{
		}
		while (Time.time > Game.mStateTime + (float)53)
		{
			if (267859 - 121366 == 146493)
			{
				if (this.qVQnJrqAHOA >= 1)
				{
					break;
				}
				if (145592 - 35450 != 110143)
				{
					this.qVQnJrqAHOA = 1;
					if (86027 - 518421 != -432393)
					{
						Game.sendMissionEvent(9322, 1);
						if (188044 - 375522 == -187478)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A048 RID: 41032 RVA: 0x0125F204 File Offset: 0x0125D404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (39288 - 230651 != -191362)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (222191 - 397768 == -175577)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (7974 - 257972 == -249998)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (195193 - 488148 != -292954)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (281147 - 481697 != -200549)
						{
							int num4 = num;
							if (36809 - 440685 != -403875)
							{
								if (num4 == 9321)
								{
									if (239902 - 362810 != -122907)
									{
										break;
									}
								}
								else if (num4 == 9322)
								{
									if (136619 - 8926 != 127694)
									{
										break;
									}
								}
								else if (num4 == -9322)
								{
									if (100299 - 320270 == -219971)
									{
										int num5 = num2;
										if (14777 - 557832 == -543055)
										{
											if (num5 == 1)
											{
												if (242696 - 82545 != 160152)
												{
													if (this.qVQnJrqAHOA < 1)
													{
														if (95734 - 190744 != -95010)
														{
															continue;
														}
														this.qVQnJrqAHOA = 1;
														if (199481 - 264905 != -65424)
														{
															continue;
														}
													}
													this.StartCoroutine_Auto(this.WindCyrstalEvent());
													if (263667 - 302499 != -38831)
													{
														break;
													}
												}
											}
											else
											{
												if (num5 != 2)
												{
													break;
												}
												if (726 - 56501 == -55775)
												{
													if (num3 != PlayerData.UID)
													{
														break;
													}
													if (79956 - 414549 != -334592)
													{
														GameObject gameObject = GameObject.Find("SpawnPoint1");
														if (144860 - 546202 != -401341)
														{
															if (gameObject)
															{
																if (251371 - 167925 == 83446)
																{
																	this.createActor("SilverQueenBug", 7, gameObject.transform.position, gameObject.transform.forward);
																	if (49085 - 578781 == -529696)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Cannot find SpawnPoint1");
																if (274868 - 499072 == -224204)
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
								else if (num4 == 9323)
								{
									if (1626 - 313390 == -311764)
									{
										if (num2 != 2)
										{
											break;
										}
										if (286173 - 561446 == -275273)
										{
											this.StartCoroutine_Auto(this.EndEvent());
											if (160396 - 529095 == -368699)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (102463 - 92310 != 10154)
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

	// Token: 0x0600A049 RID: 41033 RVA: 0x0125F5E4 File Offset: 0x0125D7E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M932_WindHollow2.$StartEvent$43433(this).GetEnumerator();
	}

	// Token: 0x0600A04A RID: 41034 RVA: 0x0125F5F4 File Offset: 0x0125D7F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator WindCyrstalEvent()
	{
		return new M932_WindHollow2.$WindCyrstalEvent$43438(this).GetEnumerator();
	}

	// Token: 0x0600A04B RID: 41035 RVA: 0x0125F604 File Offset: 0x0125D804
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M932_WindHollow2.$EndEvent$43445(this).GetEnumerator();
	}

	// Token: 0x0600A04C RID: 41036 RVA: 0x0125F614 File Offset: 0x0125D814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSilverQueenBall(GameObject nEnterObject)
	{
		if (281205 - 301359 != -20154)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (28852 - 163040 == -134188)
				{
					break;
				}
			}
			else
			{
				if (!(Game.mPlayer == nEnterObject))
				{
					break;
				}
				if (293202 - 49159 != 244044)
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (35967 - 269712 == -233745)
					{
						if (!characterControl)
						{
							break;
						}
						if (232777 - 189893 == 42884)
						{
							characterControl.hp = 0;
							if (132771 - 378800 == -246029)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A04D RID: 41037 RVA: 0x0125F71C File Offset: 0x0125D91C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCameraTriggerEnter(GameObject nEnterObject)
	{
		if (123612 - 537908 != -414295)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (163011 - 148008 == 15003)
				{
					break;
				}
			}
			else
			{
				if (!(Game.mPlayer == nEnterObject))
				{
					break;
				}
				if (260843 - 316666 == -55823)
				{
					if (!this.WRYnJxeaXxc)
					{
						break;
					}
					if (52685 - 156927 == -104242)
					{
						if (!this.dlynJpG8iIB)
						{
							break;
						}
						if (293204 - 291357 != 1848)
						{
							Transform transform = this.WRYnJxeaXxc.transform.Find("SilverQueenBall_tri");
							if (10191 - 261314 == -251123)
							{
								if (!transform)
								{
									break;
								}
								if (53670 - 431104 != -377433)
								{
									this.dlynJpG8iIB.lockedTarget = transform.gameObject;
									if (22629 - 215224 != -192594)
									{
										this.dlynJpG8iIB.isLocked = true;
										if (97817 - 140420 != -42602)
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

	// Token: 0x0600A04E RID: 41038 RVA: 0x0125F8A4 File Offset: 0x0125DAA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCameraTriggerExit(GameObject nExitObject)
	{
		if (223850 - 453365 != -229515)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (154076 - 62777 == 91299)
				{
					break;
				}
			}
			else
			{
				if (!(Game.mPlayer == nExitObject))
				{
					break;
				}
				if (204316 - 584189 == -379873)
				{
					if (!this.dlynJpG8iIB)
					{
						break;
					}
					if (26771 - 274834 == -248063)
					{
						this.dlynJpG8iIB.lockedTarget = null;
						if (256765 - 36128 == 220637)
						{
							this.dlynJpG8iIB.isLocked = false;
							if (109967 - 219489 != -109521)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A04F RID: 41039 RVA: 0x0125F9A8 File Offset: 0x0125DBA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (287250 - 541813 != -254563)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (234798 - 470171 != -235372)
			{
				Time.timeScale = 1f;
				if (295533 - 488073 != -192539)
				{
					Hashtable customOpParameters = new Hashtable();
					if (227315 - 443779 == -216464)
					{
						this.xscnJqc85lC.OpCustom(52, customOpParameters, true);
						if (107251 - 205396 == -98145)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A050 RID: 41040 RVA: 0x0125FA74 File Offset: 0x0125DC74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (276107 - 23818 != 252290)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (295780 - 571486 == -275706)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (185969 - 193745 == -7776)
				{
					Game.mGameState = eGameState.Setup;
					if (91143 - 222871 != -131727)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A051 RID: 41041 RVA: 0x0125FB18 File Offset: 0x0125DD18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (239882 - 73327 != 166555)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (71984 - 246238 != -174253)
			{
				if (num == PlayerData.UID)
				{
					if (67662 - 256311 != -188648)
					{
						this.SetupActors();
						if (68956 - 552303 != -483346)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (234952 - 181625 != 53328)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A052 RID: 41042 RVA: 0x0125FBE8 File Offset: 0x0125DDE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (230372 - 582728 != -352356)
		{
		}
		for (;;)
		{
			IL_2BA:
			Debug.Log("Creating Actors");
			if (12519 - 232831 == -220312)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (79840 - 134937 == -55097)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (6989 - 173669 == -166680)
						{
							int i = 0;
							if (179565 - 103004 == 76561)
							{
								CharacterControl[] array2 = array;
								if (249411 - 358791 == -109380)
								{
									int length = array2.Length;
									if (184786 - 557869 != -373082)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (207424 - 197273 != 10151)
												{
													goto IL_2BA;
												}
												string type = array2[i].Type;
												if (64965 - 309362 != -244397)
												{
													goto IL_2BA;
												}
												if (type == "SilverBug")
												{
													goto IL_19B;
												}
												if (286876 - 157232 != 129644)
												{
													goto IL_2BA;
												}
												if (type == "Ja4")
												{
													goto IL_19B;
												}
												if (288857 - 253029 == 35829)
												{
													goto IL_2BA;
												}
												if (type == "Ja5")
												{
													goto IL_19B;
												}
												if (120048 - 297964 != -177916)
												{
													goto IL_2BA;
												}
												if (type == "Ja6")
												{
													if (45967 - 465215 != -419248)
													{
														goto IL_2BA;
													}
													goto IL_19B;
												}
												IL_239:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (48150 - 65248 != -17098)
												{
													goto IL_2BA;
												}
												this.OOcnJYXdj5X++;
												if (172057 - 33849 != 138208)
												{
													goto IL_2BA;
												}
												goto IL_2DE;
												IL_19B:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (111683 - 430989 != -319306)
												{
													goto IL_2BA;
												}
												goto IL_239;
											}
											IL_2DE:
											i++;
											if (242392 - 471281 != -228889)
											{
												goto IL_2BA;
											}
										}
										if (266801 - 338146 != -71344)
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
						if (44969 - 359924 == -314955)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A053 RID: 41043 RVA: 0x0125FF04 File Offset: 0x0125E104
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (248061 - 504748 != -256687)
		{
		}
		for (;;)
		{
			IL_A0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (204318 - 42268 != 162051)
			{
				int i = 0;
				if (69540 - 159575 != -90034)
				{
					CharacterControl[] array2 = array;
					if (201675 - 104594 != 97082)
					{
						int length = array2.Length;
						if (12664 - 231527 == -218863)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (232815 - 431624 == -198808)
								{
									goto IL_A0;
								}
								i++;
								if (148450 - 531602 != -383152)
								{
									goto IL_A0;
								}
							}
							if (28174 - 29113 != -938)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A054 RID: 41044 RVA: 0x01260034 File Offset: 0x0125E234
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (251659 - 300333 != -48674)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (285807 - 511991 != -226183)
			{
				Game.mGameState = eGameState.Ready;
				if (250238 - 136151 != 114088)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (8160 - 372131 != -363970 && 125487 - 510054 != -384566)
					{
						GameObject gameObject = null;
						if (287776 - 122810 != 164967)
						{
							if (playerSlot < 1)
							{
								goto IL_274;
							}
							if (259727 - 385396 == -125668)
							{
								continue;
							}
							if (playerSlot > 12)
							{
								goto IL_274;
							}
							if (104203 - 353706 != -249503)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (223855 - 437347 == -213491)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (45861 - 430167 == -384305)
							{
								continue;
							}
							IL_5B:
							if (gameObject2)
							{
								if (38200 - 467089 == -428888)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (238771 - 81349 != 157422)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (137682 - 444014 != -306332)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (106101 - 461866 == -355764)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (163391 - 300484 != -137093)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (274774 - 23962 != 250812)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (144761 - 213078 == -68316)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (196197 - 525298 != -329101)
							{
								continue;
							}
							break;
							IL_274:
							gameObject2 = GameObject.Find("StartPoint1");
							if (294011 - 483100 == -189089)
							{
								goto IL_5B;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A055 RID: 41045 RVA: 0x01260358 File Offset: 0x0125E558
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (175610 - 464897 != -289286)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (125400 - 100768 != 24633)
			{
				Game.mGameState = eGameState.Start;
				if (87284 - 117123 != -29838)
				{
					Game.mStateTime = Time.time;
					if (223199 - 98187 == 125012)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (77148 - 177077 == -99929)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A056 RID: 41046 RVA: 0x01260420 File Offset: 0x0125E620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A057 RID: 41047 RVA: 0x01260424 File Offset: 0x0125E624
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (187254 - 492169 != -304915)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (130682 - 382213 == -251531)
			{
				if (gameObject)
				{
					if (200712 - 537905 == -337193)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (208380 - 98377 == 110003)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (101872 - 253484 == -151612)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A058 RID: 41048 RVA: 0x01260520 File Offset: 0x0125E720
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (138388 - 559371 != -420983)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (172306 - 221342 != -49035)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (213675 - 231570 == -17895)
				{
					hashtable.Add(43, PlayerData.UID);
					if (126285 - 254674 == -128389)
					{
						hashtable.Add(73, nType);
						if (123440 - 60385 != 63056)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (187615 - 283235 != -95619)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (234089 - 409544 != -175454)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (230444 - 34037 != 196408)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (198053 - 166912 != 31142)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (210031 - 39644 != 170388)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (23065 - 264237 == -241172)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (182154 - 591301 != -409146)
													{
														this.xscnJqc85lC.OpCustom(63, hashtable, true);
														if (38496 - 135657 != -97160)
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

	// Token: 0x0600A059 RID: 41049 RVA: 0x01260804 File Offset: 0x0125EA04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (261630 - 195399 != 66231)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (189272 - 260869 != -71596)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (150189 - 136828 == 13361)
				{
					if (RuntimeServices.EqualityOperator(data[73], "SilverQueenBug"))
					{
						if (18688 - 461733 == -443044)
						{
							continue;
						}
						if (this.N7jnJTbMOB1)
						{
							if (107764 - 452464 != -344700)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.N7jnJTbMOB1);
							if (158388 - 264242 == -105853)
							{
								continue;
							}
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (160774 - 180545 == -19771)
						{
							if (this.OOcnJYXdj5X <= 0)
							{
								break;
							}
							if (226402 - 459813 == -233411)
							{
								this.OOcnJYXdj5X--;
								if (241754 - 366457 == -124703)
								{
									if (this.OOcnJYXdj5X != 0)
									{
										break;
									}
									if (84845 - 506268 != -421422)
									{
										Game.setGameState(eGameState.Ready);
										if (129979 - 41955 == 88024)
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
						if (878 - 141928 == -141050)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (287539 - 25465 != 262075)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A05A RID: 41050 RVA: 0x01260A1C File Offset: 0x0125EC1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A05B RID: 41051 RVA: 0x01260A30 File Offset: 0x0125EC30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (299681 - 123184 != 176497)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (149593 - 194435 == -44842)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (229541 - 314891 != -85349)
				{
					if (!characterControl)
					{
						break;
					}
					if (271147 - 88385 != 182763)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (71739 - 495356 != -423616)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (119779 - 543220 != -423440)
							{
								string type = characterControl.Type;
								if (273674 - 146475 == 127199)
								{
									if (type == "SilverBug")
									{
										if (209553 - 43353 == 166200)
										{
											Game.sendMissionEvent(9323, 1);
											if (266845 - 519315 == -252470)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "SilverQueenBug"))
										{
											break;
										}
										if (95287 - 59124 != 36164)
										{
											Game.sendMissionEvent(9323, 2);
											if (101206 - 281646 != -180439)
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

	// Token: 0x0600A05C RID: 41052 RVA: 0x01260BFC File Offset: 0x0125EDFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (192044 - 352736 != -160691)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (59004 - 351753 == -292749)
			{
				hashtable.Add(71, CID);
				if (241505 - 115256 != 126250)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (234392 - 396929 != -162536)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (222039 - 249787 == -27748)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (209607 - 467276 != -257668)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (12844 - 200375 != -187530)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (160702 - 107627 != 53076)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (49925 - 404724 == -354799)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (109880 - 385134 == -275254)
											{
												this.xscnJqc85lC.OpCustom(61, hashtable, true);
												if (242676 - 329627 != -86950)
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

	// Token: 0x0600A05D RID: 41053 RVA: 0x01260E88 File Offset: 0x0125F088
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (297414 - 586772 != -289357)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (227949 - 238388 == -10439)
			{
				if (!gameObject)
				{
					break;
				}
				if (20765 - 562708 != -541942)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (181860 - 171439 != 10422)
					{
						playerCameraControl.target = gameObject;
						if (85952 - 193352 != -107399)
						{
							if (Game.useAdvanceMode)
							{
								if (10032 - 310050 == -300017)
								{
									continue;
								}
								Game.loadPlayer();
								if (62223 - 152979 == -90755)
								{
									continue;
								}
							}
							if (Game.mGameState < eGameState.Start)
							{
								if (262354 - 107169 == 155185)
								{
									this.StartGame();
									if (175053 - 169830 != 5224)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (144486 - 547938 == -403452)
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

	// Token: 0x0600A05E RID: 41054 RVA: 0x01261004 File Offset: 0x0125F204
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (221023 - 517018 != -295994)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (142079 - 71793 != 70287)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (221913 - 97904 != 124010)
				{
					gameGui.ResetTeamBar();
					if (65876 - 248049 != -182172)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A05F RID: 41055 RVA: 0x012610B0 File Offset: 0x0125F2B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M932_WindHollow2.$onDeadPlayer$43450(this).GetEnumerator();
	}

	// Token: 0x0600A060 RID: 41056 RVA: 0x012610C0 File Offset: 0x0125F2C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (139878 - 421801 != -281922)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (225971 - 191116 != 34856)
			{
				this.dlynJpG8iIB.target = Game.mPlayer;
				if (281157 - 336989 != -55831)
				{
					this.dlynJpG8iIB.enabled = true;
					if (130128 - 523927 == -393799)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (32529 - 80637 == -48107)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (126702 - 240081 != -113379)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (205144 - 130984 != 74161)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (10101 - 499124 != -489022)
							{
								if (!gameGui)
								{
									break;
								}
								if (10900 - 572078 == -561178)
								{
									gameGui.enabled = true;
									if (33545 - 291314 == -257769)
									{
										gameGui.closeDeadMenu();
										if (225006 - 518511 != -293504)
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

	// Token: 0x0600A061 RID: 41057 RVA: 0x0126126C File Offset: 0x0125F46C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (177480 - 141330 != 36151)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (188333 - 408357 != -220023)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (198121 - 431400 == -233279)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (238874 - 529635 == -290761)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A062 RID: 41058 RVA: 0x01261330 File Offset: 0x0125F530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A063 RID: 41059 RVA: 0x0126135C File Offset: 0x0125F55C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (296091 - 427471 != -131380)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (278714 - 159251 != 119464)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (129638 - 119727 == 9911)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (244671 - 446181 == -201510)
					{
						Hashtable hashtable = new Hashtable();
						if (95644 - 477441 != -381796)
						{
							hashtable.Add(43, PlayerData.UID);
							if (19761 - 410355 == -390594)
							{
								hashtable.Add(71, nCID);
								if (185518 - 245136 == -59618)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (53356 - 474367 != -421010)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (216873 - 398788 != -181914)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (299877 - 450992 != -151114)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (11223 - 517811 != -506587)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (64751 - 383383 != -318631)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (133269 - 183958 != -50688)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (145169 - 455793 != -310623)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (279289 - 339959 != -60669)
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

	// Token: 0x0600A064 RID: 41060 RVA: 0x0126167C File Offset: 0x0125F87C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M932_WindHollow2.$onChangePlayer$43456(data, this).GetEnumerator();
	}

	// Token: 0x0600A065 RID: 41061 RVA: 0x0126168C File Offset: 0x0125F88C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M932_WindHollow2.$onGameComplete$43463(data, this).GetEnumerator();
	}

	// Token: 0x0600A066 RID: 41062 RVA: 0x0126169C File Offset: 0x0125F89C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M932_WindHollow2.$ReturnToTown$43473(this).GetEnumerator();
	}

	// Token: 0x0600A067 RID: 41063 RVA: 0x012616AC File Offset: 0x0125F8AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M932_WindHollow2.$ReturnToGuild$43478(this).GetEnumerator();
	}

	// Token: 0x0600A068 RID: 41064 RVA: 0x012616BC File Offset: 0x0125F8BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M932_WindHollow2.$ReturnToCamp$43482(this).GetEnumerator();
	}

	// Token: 0x0600A069 RID: 41065 RVA: 0x012616CC File Offset: 0x0125F8CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (50318 - 109262 != -58944)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (131214 - 468059 == -336845)
			{
				Hashtable hashtable = new Hashtable();
				if (149957 - 493526 != -343568)
				{
					hashtable.Add(43, PlayerData.UID);
					if (11317 - 456808 == -445491)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (89190 - 17883 == 71307)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A06A RID: 41066 RVA: 0x012617A4 File Offset: 0x0125F9A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A06B RID: 41067 RVA: 0x012617B8 File Offset: 0x0125F9B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (238760 - 127608 != 111152)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (293001 - 452390 != -159388)
			{
				Hashtable hashtable = new Hashtable();
				if (98684 - 352594 != -253909)
				{
					if (Game.mNextGameCode == 30)
					{
						if (261910 - 87235 == 174676)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (18067 - 98112 == -80044)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (71578 - 235672 != -164094)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (162519 - 43893 != 118626)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (56754 - 481277 == -424522)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (277217 - 411694 == -134476)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (90028 - 506974 != -416946)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (129233 - 438834 == -309600)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (65268 - 234725 == -169456)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (9790 - 408065 == -398274)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (172857 - 180610 != -7753)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (47649 - 415125 == -367475)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (175574 - 572285 != -396711)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (190022 - 376574 != -186552)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (35037 - 322574 == -287536)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (287959 - 509633 == -221673)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (68739 - 8978 == 59762)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (130132 - 55636 == 74497)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (8084 - 131173 != -123089)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (45147 - 34435 != 10712)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (40742 - 114748 != -74006)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (44338 - 86986 != -42648)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (143229 - 566844 != -423615)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (159839 - 124770 == 35070)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (173689 - 113416 == 60274)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (69903 - 56388 != 13515)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (205245 - 376140 == -170894)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (80327 - 473175 != -392848)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (270430 - 592678 == -322248)
					{
						this.xscnJqc85lC.OpCustom(42, hashtable, true);
						if (48002 - 552255 != -504252)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A06C RID: 41068 RVA: 0x01261D6C File Offset: 0x0125FF6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A06D RID: 41069 RVA: 0x01261D7C File Offset: 0x0125FF7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A06E RID: 41070 RVA: 0x01261D80 File Offset: 0x0125FF80
	internal static bool vsg3uXVnirUIDnKYWkuK()
	{
		return true;
	}

	// Token: 0x0600A06F RID: 41071 RVA: 0x01261D84 File Offset: 0x0125FF84
	internal static bool xYwoxRVnKBU1Yjsf0AjQ()
	{
		return false;
	}

	// Token: 0x04009193 RID: 37267
	private LitePeer xscnJqc85lC;

	// Token: 0x04009194 RID: 37268
	private PlayerCameraControl dlynJpG8iIB;

	// Token: 0x04009195 RID: 37269
	private float vJJnJRvpRcC;

	// Token: 0x04009196 RID: 37270
	private int qVQnJrqAHOA;

	// Token: 0x04009197 RID: 37271
	public GameObject silverQueenBall;

	// Token: 0x04009198 RID: 37272
	private GameObject WRYnJxeaXxc;

	// Token: 0x04009199 RID: 37273
	public GameObject fakeSilverQueen;

	// Token: 0x0400919A RID: 37274
	private GameObject N7jnJTbMOB1;

	// Token: 0x0400919B RID: 37275
	private int OOcnJYXdj5X;

	// Token: 0x02001AD7 RID: 6871
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43433 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A070 RID: 41072 RVA: 0x01261D88 File Offset: 0x0125FF88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43433(M932_WindHollow2 self_)
		{
			if (2610 - 598466 != -595856)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (83314 - 354033 == -270719)
				{
					base..ctor();
					if (297662 - 286022 == 11640)
					{
						this.$self_$43437 = self_;
						if (221032 - 172533 == 48499)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A071 RID: 41073 RVA: 0x01261E20 File Offset: 0x01260020
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow2.$StartEvent$43433.$(this.$self_$43437);
		}

		// Token: 0x0600A072 RID: 41074 RVA: 0x01261E30 File Offset: 0x01260030
		internal static bool U9LBXLVndAweqM6u1Afq()
		{
			return true;
		}

		// Token: 0x0600A073 RID: 41075 RVA: 0x01261E34 File Offset: 0x01260034
		internal static bool L1SMDBVnJvVWLhd8H67G()
		{
			return false;
		}

		// Token: 0x0400919C RID: 37276
		internal M932_WindHollow2 $self_$43437;

		// Token: 0x02001AD8 RID: 6872
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A074 RID: 41076 RVA: 0x01261E38 File Offset: 0x01260038
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow2 self_)
			{
				if (238087 - 440195 != -202108)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (150287 - 44897 != 105391)
					{
						base..ctor();
						if (282616 - 314578 != -31961)
						{
							this.$self_$43436 = self_;
							if (287551 - 189669 == 97882)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A075 RID: 41077 RVA: 0x01261ED0 File Offset: 0x012600D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (180959 - 19898 != 161062)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_67F;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (9164 - 325105 != -315940)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43434 = (StoryGui)this.$self_$43436.GetComponent(typeof(StoryGui));
							if (70958 - 400713 != -329755)
							{
								continue;
							}
							if (!this.$mStoryGui$43434)
							{
								goto IL_615;
							}
							if (267923 - 414875 != -146952)
							{
								continue;
							}
							this.$mStoryGui$43434.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (229415 - 82877 != 146538)
							{
								continue;
							}
							goto IL_BA;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (247731 - 124515 != 123216)
							{
								continue;
							}
							goto IL_359;
						}
						else
						{
							this.$mStoryGui$43434.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M932_WindHollow", 1101), eTalkType.friend);
							if (128134 - 339082 != -210948)
							{
								continue;
							}
							goto IL_3A8;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (65945 - 558473 != -492528)
							{
								continue;
							}
							goto IL_F5;
						}
						else
						{
							this.$mStoryGui$43434.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M932_WindHollow", 1102), eTalkType.friend);
							if (97605 - 213178 == -115572)
							{
								continue;
							}
							if (Game.mPlayer)
							{
								if (261963 - 518397 != -256434)
								{
									continue;
								}
								Game.mPlayer.transform.rotation = Quaternion.LookRotation(-Game.mPlayer.transform.forward);
								if (80708 - 479938 == -399229)
								{
									continue;
								}
							}
							if (!this.$self_$43436.silverQueenBall)
							{
								goto IL_5C4;
							}
							if (186432 - 107492 == 78941)
							{
								continue;
							}
							this.$self_$43436.WRYnJxeaXxc = (GameObject)UnityEngine.Object.Instantiate(this.$self_$43436.silverQueenBall, new Vector3((float)0, (float)50, (float)0), Quaternion.identity);
							if (88343 - 234083 != -145740)
							{
								continue;
							}
							if (!this.$self_$43436.WRYnJxeaXxc)
							{
								goto IL_5C4;
							}
							if (248339 - 333704 != -85365)
							{
								continue;
							}
							this.$self_$43436.WRYnJxeaXxc.animation.Play();
							if (165778 - 25536 != 140242)
							{
								continue;
							}
							goto IL_5C4;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (218664 - 303503 != -84839)
							{
								continue;
							}
							goto IL_50E;
						}
						else
						{
							Camera.main.SendMessage("AddCamereShake", 1f);
							if (39544 - 214732 != -175188)
							{
								continue;
							}
							goto IL_42C;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (211518 - 226568 != -15049)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43434.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M932_WindHollow", 1103), eTalkType.friend);
							if (241004 - 336650 != -95646)
							{
								continue;
							}
							goto IL_259;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (249171 - 209699 != 39472)
							{
								continue;
							}
							goto IL_294;
						}
						else
						{
							this.$mStoryGui$43434.close();
							if (45763 - 565230 != -519467)
							{
								continue;
							}
							goto IL_5FF;
						}
						break;
					case 8:
						goto IL_615;
					default:
						if (50170 - 545681 == -495510)
						{
							continue;
						}
						break;
					}
					Debug.Log("StartEvent");
					if (187546 - 575186 == -387639)
					{
						continue;
					}
					this.$self_$43436.dlynJpG8iIB.alignToObject("EventCamera1");
					if (79551 - 421472 != -341921)
					{
						continue;
					}
					this.$self_$43436.SendMessage("fadeIn");
					if (38624 - 263218 != -224593)
					{
						goto Block_14;
					}
					continue;
					IL_615:
					this.$mGameGui$43435 = (GameGui)this.$self_$43436.GetComponent(typeof(GameGui));
					if (269415 - 395158 != -125742)
					{
						this.$mGameGui$43435.enabled = true;
						if (286469 - 87757 != 198713)
						{
							this.$self_$43436.dlynJpG8iIB.enabled = true;
							if (213816 - 533240 != -319423)
							{
								Game.mGameState = eGameState.Normal;
								if (190502 - 417992 != -227489)
								{
									Game.mStateTime = Time.time;
									if (67026 - 538234 != -471207)
									{
										this.YieldDefault(1);
										if (181700 - 117733 == 63967)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_67F;
				IL_BA:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_F5:
				goto IL_67F;
				Block_14:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_259:
				return this.Yield(7, new WaitForSeconds(2f));
				IL_294:
				IL_359:
				goto IL_67F;
				IL_3A8:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_42C:
				return this.Yield(6, new WaitForSeconds(0.2f));
				Block_29:
				IL_50E:
				goto IL_67F;
				IL_5C4:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_5FF:
				return this.Yield(8, new WaitForSeconds(0.5f));
				IL_67F:
				return false;
			}

			// Token: 0x0600A076 RID: 41078 RVA: 0x01262570 File Offset: 0x01260770
			internal static bool TqWhihVnDLrHA70wcu7o()
			{
				return true;
			}

			// Token: 0x0600A077 RID: 41079 RVA: 0x01262574 File Offset: 0x01260774
			internal static bool uuKQ15Vnvd0lELBGlvrh()
			{
				return false;
			}

			// Token: 0x0400919D RID: 37277
			internal StoryGui $mStoryGui$43434;

			// Token: 0x0400919E RID: 37278
			internal GameGui $mGameGui$43435;

			// Token: 0x0400919F RID: 37279
			internal M932_WindHollow2 $self_$43436;
		}
	}

	// Token: 0x02001AD9 RID: 6873
	[CompilerGenerated]
	[Serializable]
	internal sealed class $WindCyrstalEvent$43438 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A078 RID: 41080 RVA: 0x01262578 File Offset: 0x01260778
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $WindCyrstalEvent$43438(M932_WindHollow2 self_)
		{
			if (5292 - 195439 != -190146)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (21191 - 125865 == -104674)
				{
					base..ctor();
					if (224592 - 14294 != 210299)
					{
						this.$self_$43444 = self_;
						if (185266 - 53289 == 131977)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A079 RID: 41081 RVA: 0x01262610 File Offset: 0x01260810
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow2.$WindCyrstalEvent$43438.$(this.$self_$43444);
		}

		// Token: 0x0600A07A RID: 41082 RVA: 0x01262620 File Offset: 0x01260820
		internal static bool yPCNQXVnRVbQh85l96WO()
		{
			return true;
		}

		// Token: 0x0600A07B RID: 41083 RVA: 0x01262624 File Offset: 0x01260824
		internal static bool hywlh2VnwRjnOvRYgfLM()
		{
			return false;
		}

		// Token: 0x040091A0 RID: 37280
		internal M932_WindHollow2 $self_$43444;

		// Token: 0x02001ADA RID: 6874
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A07C RID: 41084 RVA: 0x01262628 File Offset: 0x01260828
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow2 self_)
			{
				if (20503 - 399785 != -379282)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (112286 - 432513 != -320226)
					{
						base..ctor();
						if (105495 - 336760 == -231265)
						{
							this.$self_$43443 = self_;
							if (43374 - 191303 != -147928)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A07D RID: 41085 RVA: 0x012626C0 File Offset: 0x012608C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (90515 - 509682 != -419167)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_CE0;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (34443 - 92036 != -57593)
							{
								continue;
							}
							goto IL_8DA;
						}
						else
						{
							if (!Game.mPlayer)
							{
								goto IL_472;
							}
							if (172474 - 410122 == -237647)
							{
								continue;
							}
							this.$startPoint$43440 = GameObject.Find("StartPoint" + (Game.getPlayerSlot(PlayerData.UID) + 2));
							if (235673 - 130288 != 105385)
							{
								continue;
							}
							if (!this.$startPoint$43440)
							{
								goto IL_472;
							}
							if (86072 - 219997 == -133924)
							{
								continue;
							}
							Game.mPlayer.transform.position = this.$startPoint$43440.transform.position;
							if (295247 - 84881 != 210366)
							{
								continue;
							}
							Game.mPlayer.transform.rotation = this.$startPoint$43440.transform.rotation;
							if (38675 - 204108 != -165433)
							{
								continue;
							}
							Game.mPlayer.SendMessage("PositionEvent");
							if (117054 - 164465 != -47411)
							{
								continue;
							}
							goto IL_472;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (276243 - 337790 != -61547)
							{
								continue;
							}
							goto IL_994;
						}
						else
						{
							this.$self_$43443.dlynJpG8iIB.alignToObject("EventCamera2");
							if (30396 - 77197 != -46801)
							{
								continue;
							}
							this.$self_$43443.audio.Stop();
							if (9954 - 338465 == -328510)
							{
								continue;
							}
							this.$self_$43443.SendMessage("fadeInTimer", 0.2f);
							if (75768 - 440786 != -365017)
							{
								goto Block_55;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (292337 - 316441 != -24103)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							this.$mWindHollowBridge$43441 = GameObject.Find("WindHollowBridge");
							if (2968 - 174960 != -171992)
							{
								continue;
							}
							if (!this.$mWindHollowBridge$43441)
							{
								goto IL_A04;
							}
							if (60042 - 267538 != -207496)
							{
								continue;
							}
							this.$mWindHollowBridge$43441.animation.Play();
							if (197091 - 298728 != -101636)
							{
								goto Block_73;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (129949 - 443401 != -313451)
							{
								goto Block_69;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43442 = (StoryGui)this.$self_$43443.GetComponent(typeof(StoryGui));
							if (197398 - 507335 == -309936)
							{
								continue;
							}
							if (!this.$mStoryGui$43442)
							{
								if (42252 - 73367 != -31114)
								{
									goto Block_10;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$43442.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
								if (68692 - 257457 == -188764)
								{
									continue;
								}
								if (!this.$mWindHollowBridge$43441)
								{
									goto IL_A6A;
								}
								if (104693 - 344634 == -239940)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mWindHollowBridge$43441);
								if (286210 - 57922 != 228289)
								{
									goto Block_74;
								}
								continue;
							}
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (143400 - 193617 != -50217)
							{
								continue;
							}
							goto IL_6B1;
						}
						else
						{
							this.$mStoryGui$43442.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M932_WindHollow", 1201), eTalkType.friend);
							if (122779 - 528029 != -405250)
							{
								continue;
							}
							goto IL_B2E;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (96397 - 53056 != 43342)
							{
								goto Block_77;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43442.blank();
							if (198937 - 548297 != -349360)
							{
								continue;
							}
							this.$self_$43443.SendMessage("fadeOutTimer", 0.2f);
							if (279622 - 196484 != 83138)
							{
								continue;
							}
							goto IL_59D;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (105918 - 202515 != -96596)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							this.$self_$43443.dlynJpG8iIB.alignToObject("EventCamera3");
							if (62884 - 299502 != -236618)
							{
								continue;
							}
							if (Game.mPlayer)
							{
								if (225602 - 441886 == -216283)
								{
									continue;
								}
								Game.mPlayer.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(-Game.mPlayer.transform.position));
								if (248623 - 22305 != 226318)
								{
									continue;
								}
							}
							if (this.$self_$43443.WRYnJxeaXxc)
							{
								if (35034 - 330407 != -295373)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$43443.WRYnJxeaXxc);
								if (80192 - 269713 != -189521)
								{
									continue;
								}
							}
							this.$self_$43443.SendMessage("fadeInTimer", 0.3f);
							if (30248 - 108436 != -78187)
							{
								goto Block_86;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (86692 - 112078 != -25386)
							{
								continue;
							}
							goto IL_700;
						}
						else
						{
							this.$mStoryGui$43442.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M932_WindHollow", 1202), eTalkType.friend);
							if (15304 - 355006 == -339701)
							{
								continue;
							}
							this.$self_$43443.dlynJpG8iIB.StartCoroutine_Auto(this.$self_$43443.dlynJpG8iIB.slerpToObject("EventCamera4", (float)2));
							if (260640 - 402273 != -141632)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (19223 - 303578 != -284355)
							{
								continue;
							}
							goto IL_54;
						}
						else
						{
							this.$self_$43443.dlynJpG8iIB.StartCoroutine_Auto(this.$self_$43443.dlynJpG8iIB.slerpToObject("EventCamera5", (float)2));
							if (237158 - 527875 == -290716)
							{
								continue;
							}
							if (this.$self_$43443.fakeSilverQueen)
							{
								if (291760 - 120356 == 171405)
								{
									continue;
								}
								this.$self_$43443.N7jnJTbMOB1 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$43443.fakeSilverQueen, new Vector3((float)0, (float)50, (float)0), Quaternion.identity);
								if (150627 - 434047 == -283419)
								{
									continue;
								}
							}
							this.$mStoryGui$43442.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M932_WindHollow", 1203), eTalkType.friend);
							if (49456 - 531468 != -482011)
							{
								goto Block_85;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (170202 - 87486 != 82716)
							{
								continue;
							}
							goto IL_200;
						}
						else
						{
							this.$mStoryGui$43442.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M932_WindHollow", 1204), eTalkType.friend);
							if (134397 - 21029 != 113368)
							{
								continue;
							}
							goto IL_9C8;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (181242 - 350288 != -169046)
							{
								continue;
							}
							goto IL_DD;
						}
						else
						{
							this.$mStoryGui$43442.close();
							if (297643 - 111533 == 186111)
							{
								continue;
							}
							this.$self_$43443.audio.Play();
							if (218585 - 406613 != -188027)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					case 13:
						if (this.$mGameGui$43439)
						{
							if (186601 - 40614 == 145988)
							{
								continue;
							}
							this.$mGameGui$43439.enabled = true;
							if (29367 - 206745 == -177377)
							{
								continue;
							}
						}
						this.$self_$43443.dlynJpG8iIB.enabled = true;
						if (199752 - 470137 != -270385)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (157146 - 323160 == -166013)
						{
							continue;
						}
						Game.sendMissionEvent(9322, 2);
						if (69535 - 272678 != -203143)
						{
							continue;
						}
						this.YieldDefault(1);
						if (12198 - 301862 != -289664)
						{
							continue;
						}
						goto IL_CE0;
					default:
						if (257871 - 288014 == -30142)
						{
							continue;
						}
						break;
					}
					Debug.Log("WindCyrstalEvent");
					if (263332 - 214673 != 48660)
					{
						Game.mGameState = eGameState.AllHold;
						if (164533 - 458621 != -294087)
						{
							this.$mGameGui$43439 = (GameGui)this.$self_$43443.GetComponent(typeof(GameGui));
							if (23382 - 398267 != -374884)
							{
								if (this.$mGameGui$43439)
								{
									if (278213 - 223500 == 54714)
									{
										continue;
									}
									this.$mGameGui$43439.close();
									if (105079 - 564380 != -459301)
									{
										continue;
									}
								}
								if (this.$self_$43443.dlynJpG8iIB.isLocked)
								{
									if (254773 - 505479 == -250705)
									{
										continue;
									}
									this.$self_$43443.dlynJpG8iIB.lockedTarget = null;
									if (139366 - 560640 == -421273)
									{
										continue;
									}
									this.$self_$43443.dlynJpG8iIB.isLocked = false;
									if (253066 - 468398 == -215331)
									{
										continue;
									}
								}
								this.$self_$43443.SendMessage("fadeOutTimer", 0.5f);
								if (195499 - 548065 == -352566)
								{
									goto IL_2BD;
								}
							}
						}
					}
				}
				IL_54:
				goto IL_CE0;
				Block_4:
				return this.Yield(10, new WaitForSeconds(3f));
				IL_DD:
				goto IL_CE0;
				Block_7:
				return this.Yield(13, new WaitForSeconds(0.5f));
				Block_10:
				IL_200:
				goto IL_CE0;
				IL_2BD:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_472:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_36:
				goto IL_CE0;
				IL_59D:
				return this.Yield(8, new WaitForSeconds(0.3f));
				Block_40:
				IL_6B1:
				IL_700:
				goto IL_CE0;
				Block_55:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_8DA:
				IL_994:
				goto IL_CE0;
				IL_9C8:
				return this.Yield(12, new WaitForSeconds(3f));
				IL_A04:
				return this.Yield(5, new WaitForSeconds(2f));
				Block_69:
				goto IL_CE0;
				IL_A6A:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_73:
				goto IL_A04;
				Block_74:
				goto IL_A6A;
				IL_B2E:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_77:
				goto IL_CE0;
				Block_85:
				return this.Yield(11, new WaitForSeconds(3f));
				Block_86:
				return this.Yield(9, new WaitForSeconds(0.3f));
				IL_CE0:
				return false;
			}

			// Token: 0x0600A07E RID: 41086 RVA: 0x012633C0 File Offset: 0x012615C0
			internal static bool vE3ybDVnq43d4WAuTIo1()
			{
				return true;
			}

			// Token: 0x0600A07F RID: 41087 RVA: 0x012633C4 File Offset: 0x012615C4
			internal static bool FG1VQ7Vn7kQbWWUwo7oM()
			{
				return false;
			}

			// Token: 0x040091A1 RID: 37281
			internal GameGui $mGameGui$43439;

			// Token: 0x040091A2 RID: 37282
			internal GameObject $startPoint$43440;

			// Token: 0x040091A3 RID: 37283
			internal GameObject $mWindHollowBridge$43441;

			// Token: 0x040091A4 RID: 37284
			internal StoryGui $mStoryGui$43442;

			// Token: 0x040091A5 RID: 37285
			internal M932_WindHollow2 $self_$43443;
		}
	}

	// Token: 0x02001ADB RID: 6875
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$43445 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A080 RID: 41088 RVA: 0x012633C8 File Offset: 0x012615C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$43445(M932_WindHollow2 self_)
		{
			if (72269 - 161253 != -88984)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (286955 - 351489 == -64534)
				{
					base..ctor();
					if (268477 - 530622 == -262145)
					{
						this.$self_$43449 = self_;
						if (23231 - 136022 == -112791)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A081 RID: 41089 RVA: 0x01263460 File Offset: 0x01261660
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow2.$EndEvent$43445.$(this.$self_$43449);
		}

		// Token: 0x0600A082 RID: 41090 RVA: 0x01263470 File Offset: 0x01261670
		internal static bool sB9S4BVnPH9ImKeY5n7m()
		{
			return true;
		}

		// Token: 0x0600A083 RID: 41091 RVA: 0x01263474 File Offset: 0x01261674
		internal static bool B3ranDVn0AErQ45oG47R()
		{
			return false;
		}

		// Token: 0x040091A6 RID: 37286
		internal M932_WindHollow2 $self_$43449;

		// Token: 0x02001ADC RID: 6876
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A084 RID: 41092 RVA: 0x01263478 File Offset: 0x01261678
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow2 self_)
			{
				if (275840 - 177146 != 98694)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (259928 - 85771 == 174157)
					{
						base..ctor();
						if (76778 - 559591 == -482813)
						{
							this.$self_$43448 = self_;
							if (175665 - 564103 != -388437)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A085 RID: 41093 RVA: 0x01263510 File Offset: 0x01261710
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (145029 - 476778 != -331748)
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
						if (Game.mGameState != eGameState.AllHold)
						{
							if (223175 - 61393 != 161782)
							{
								continue;
							}
							goto IL_142;
						}
						else
						{
							this.$mGameGui$43446 = (GameGui)this.$self_$43448.GetComponent(typeof(GameGui));
							if (79657 - 277898 == -198240)
							{
								continue;
							}
							if (!this.$mGameGui$43446)
							{
								goto IL_1CB;
							}
							if (27449 - 358618 != -331169)
							{
								continue;
							}
							this.$mGameGui$43446.close();
							if (105912 - 111408 != -5495)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (113421 - 141414 != -27993)
							{
								continue;
							}
							goto IL_263;
						}
						else
						{
							this.$mStoryGui$43447 = (StoryGui)this.$self_$43448.GetComponent(typeof(StoryGui));
							if (133138 - 214705 == -81566)
							{
								continue;
							}
							if (!this.$mStoryGui$43447)
							{
								goto IL_3A0;
							}
							if (101935 - 462698 != -360763)
							{
								continue;
							}
							this.$mStoryGui$43447.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (15915 - 437202 == -421286)
							{
								continue;
							}
							this.$self_$43448.dlynJpG8iIB.alignToObject("EventCamera6");
							if (240158 - 239099 != 1060)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (254603 - 260612 != -6009)
							{
								continue;
							}
							goto IL_73;
						}
						else
						{
							this.$mStoryGui$43447.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M932_WindHollow", 1301), eTalkType.friend);
							if (296513 - 117551 != 178963)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (290589 - 133928 != 156661)
							{
								continue;
							}
							goto IL_2C7;
						}
						else
						{
							this.$mStoryGui$43447.close();
							if (174796 - 379736 != -204939)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 6:
						goto IL_3A0;
					case 7:
						Game.sendMissionEvent(9321, 3);
						if (16292 - 521494 != -505202)
						{
							continue;
						}
						this.YieldDefault(1);
						if (279981 - 512510 != -232528)
						{
							goto Block_16;
						}
						continue;
					default:
						if (241869 - 387459 != -145590)
						{
							continue;
						}
						break;
					}
					Debug.Log("End Event");
					if (170941 - 279728 != -108786)
					{
						Game.mGameState = eGameState.AllHold;
						if (68499 - 220910 != -152410)
						{
							goto Block_11;
						}
					}
				}
				Block_2:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_73:
				goto IL_3DB;
				Block_5:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_142:
				goto IL_3DB;
				Block_11:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_1CB:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_16:
				IL_263:
				goto IL_3DB;
				Block_20:
				goto IL_1CB;
				IL_2C7:
				goto IL_3DB;
				Block_21:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_3A0:
				return this.Yield(7, new WaitForSeconds(2f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600A086 RID: 41094 RVA: 0x0126390C File Offset: 0x01261B0C
			internal static bool tUZ9y4VnblVoxeaQjNn1()
			{
				return true;
			}

			// Token: 0x0600A087 RID: 41095 RVA: 0x01263910 File Offset: 0x01261B10
			internal static bool aQjKIUVnuKeiBibiLeoh()
			{
				return false;
			}

			// Token: 0x040091A7 RID: 37287
			internal GameGui $mGameGui$43446;

			// Token: 0x040091A8 RID: 37288
			internal StoryGui $mStoryGui$43447;

			// Token: 0x040091A9 RID: 37289
			internal M932_WindHollow2 $self_$43448;
		}
	}

	// Token: 0x02001ADD RID: 6877
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43450 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A088 RID: 41096 RVA: 0x01263914 File Offset: 0x01261B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43450(M932_WindHollow2 self_)
		{
			if (155002 - 60325 != 94677)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (31292 - 435577 == -404285)
				{
					base..ctor();
					if (77825 - 583709 != -505883)
					{
						this.$self_$43455 = self_;
						if (133080 - 283411 == -150331)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A089 RID: 41097 RVA: 0x012639AC File Offset: 0x01261BAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow2.$onDeadPlayer$43450.$(this.$self_$43455);
		}

		// Token: 0x0600A08A RID: 41098 RVA: 0x012639BC File Offset: 0x01261BBC
		internal static bool OsnPaJVnI1pyjmGgAxs1()
		{
			return true;
		}

		// Token: 0x0600A08B RID: 41099 RVA: 0x012639C0 File Offset: 0x01261BC0
		internal static bool oqbSwpVnBZP3LeFmTdnx()
		{
			return false;
		}

		// Token: 0x040091AA RID: 37290
		internal M932_WindHollow2 $self_$43455;

		// Token: 0x02001ADE RID: 6878
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A08C RID: 41100 RVA: 0x012639C4 File Offset: 0x01261BC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow2 self_)
			{
				if (112740 - 126914 != -14173)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (80608 - 302080 != -221471)
					{
						base..ctor();
						if (58326 - 143311 == -84985)
						{
							this.$self_$43454 = self_;
							if (188859 - 443570 == -254711)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A08D RID: 41101 RVA: 0x01263A5C File Offset: 0x01261C5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (92707 - 329035 != -236327)
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
							if (73320 - 46065 != 27255)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_6E;
							}
							if (13508 - 442829 == -429320)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (284026 - 451797 != -167771)
						{
							continue;
						}
						this.$mStoryGui$43451 = (StoryGui)this.$self_$43454.GetComponent(typeof(StoryGui));
						if (280251 - 561692 != -281441)
						{
							continue;
						}
						if (this.$mStoryGui$43451)
						{
							if (53627 - 554417 == -500789)
							{
								continue;
							}
							this.$mStoryGui$43451.close();
							if (103947 - 256644 == -152696)
							{
								continue;
							}
						}
						this.$mChangeGui$43452 = (ChangeGui)this.$self_$43454.GetComponent(typeof(ChangeGui));
						if (47786 - 554149 != -506363)
						{
							continue;
						}
						if (this.$mChangeGui$43452)
						{
							if (181821 - 325586 != -143765)
							{
								continue;
							}
							this.$mChangeGui$43452.close();
							if (72004 - 366555 == -294550)
							{
								continue;
							}
						}
						this.$mGameGui$43453 = (GameGui)this.$self_$43454.GetComponent(typeof(GameGui));
						if (271434 - 205972 == 65463)
						{
							continue;
						}
						if (this.$mGameGui$43453)
						{
							if (284690 - 551812 != -267122)
							{
								continue;
							}
							if (!this.$mGameGui$43453.enabled)
							{
								if (95240 - 520540 != -425300)
								{
									continue;
								}
								this.$mGameGui$43453.enabled = true;
								if (297367 - 300753 != -3386)
								{
									continue;
								}
							}
							this.$mGameGui$43453.openDeadMenu();
							if (12363 - 599138 != -586775)
							{
								continue;
							}
						}
						IL_6E:
						this.YieldDefault(1);
						if (56775 - 217379 != -160604)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (278141 - 152050 == 126092)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (38386 - 10659 != 27727);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600A08E RID: 41102 RVA: 0x01263D74 File Offset: 0x01261F74
			internal static bool a0oEHRVne0crx9Ny2ONX()
			{
				return true;
			}

			// Token: 0x0600A08F RID: 41103 RVA: 0x01263D78 File Offset: 0x01261F78
			internal static bool u8oj4dVnrp8VvbOoYJtH()
			{
				return false;
			}

			// Token: 0x040091AB RID: 37291
			internal StoryGui $mStoryGui$43451;

			// Token: 0x040091AC RID: 37292
			internal ChangeGui $mChangeGui$43452;

			// Token: 0x040091AD RID: 37293
			internal GameGui $mGameGui$43453;

			// Token: 0x040091AE RID: 37294
			internal M932_WindHollow2 $self_$43454;
		}
	}

	// Token: 0x02001ADF RID: 6879
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43456 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A090 RID: 41104 RVA: 0x01263D7C File Offset: 0x01261F7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43456(Hashtable data, M932_WindHollow2 self_)
		{
			if (286775 - 410351 != -123576)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (190249 - 560873 == -370624)
				{
					base..ctor();
					if (17770 - 247267 == -229497)
					{
						this.$data$43461 = data;
						if (23243 - 192478 == -169235)
						{
							this.$self_$43462 = self_;
							if (68957 - 313761 != -244803)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A091 RID: 41105 RVA: 0x01263E38 File Offset: 0x01262038
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow2.$onChangePlayer$43456.$(this.$data$43461, this.$self_$43462);
		}

		// Token: 0x0600A092 RID: 41106 RVA: 0x01263E4C File Offset: 0x0126204C
		internal static bool AY1gfdVnjTAB5AmKLRNB()
		{
			return true;
		}

		// Token: 0x0600A093 RID: 41107 RVA: 0x01263E50 File Offset: 0x01262050
		internal static bool uDEArgVnhHavA6wRJfVq()
		{
			return false;
		}

		// Token: 0x040091AF RID: 37295
		internal Hashtable $data$43461;

		// Token: 0x040091B0 RID: 37296
		internal M932_WindHollow2 $self_$43462;

		// Token: 0x02001AE0 RID: 6880
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A094 RID: 41108 RVA: 0x01263E54 File Offset: 0x01262054
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M932_WindHollow2 self_)
			{
				if (217792 - 570795 != -353003)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (272199 - 367572 != -95372)
					{
						base..ctor();
						if (186956 - 154513 != 32444)
						{
							this.$data$43459 = data;
							if (33902 - 475934 != -442031)
							{
								this.$self_$43460 = self_;
								if (50187 - 166169 == -115982)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A095 RID: 41109 RVA: 0x01263F10 File Offset: 0x01262110
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (243443 - 217823 != 25620)
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
							if (72834 - 342938 != -270104)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (116732 - 238352 != -121620)
							{
								continue;
							}
							this.$mGameGui$43458 = (GameGui)this.$self_$43460.GetComponent(typeof(GameGui));
							if (96969 - 498980 == -402010)
							{
								continue;
							}
							this.$mGameGui$43458.enabled = true;
							if (53640 - 309527 == -255886)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (4403 - 20 != 4384)
						{
							goto Block_2;
						}
						continue;
					default:
						if (58913 - 51429 != 7484)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (298158 - 532378 == -234220)
					{
						this.$self_$43460.SendMessage("onCreatePlayer", this.$data$43459);
						if (255088 - 173645 != 81444)
						{
							this.$mChangeGui$43457 = (ChangeGui)this.$self_$43460.GetComponent(typeof(ChangeGui));
							if (75543 - 596799 == -521256)
							{
								if (!this.$mChangeGui$43457.enabled)
								{
									goto IL_FB;
								}
								if (120887 - 340336 != -219448)
								{
									this.$mChangeGui$43457.close();
									if (191170 - 314055 != -122884)
									{
										goto Block_3;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_205;
				Block_3:
				IL_FB:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600A096 RID: 41110 RVA: 0x01264134 File Offset: 0x01262334
			internal static bool PFaKi9Vns61V3303jVtQ()
			{
				return true;
			}

			// Token: 0x0600A097 RID: 41111 RVA: 0x01264138 File Offset: 0x01262338
			internal static bool ELdP8NVn9D5S9ia4OxBh()
			{
				return false;
			}

			// Token: 0x040091B1 RID: 37297
			internal ChangeGui $mChangeGui$43457;

			// Token: 0x040091B2 RID: 37298
			internal GameGui $mGameGui$43458;

			// Token: 0x040091B3 RID: 37299
			internal Hashtable $data$43459;

			// Token: 0x040091B4 RID: 37300
			internal M932_WindHollow2 $self_$43460;
		}
	}

	// Token: 0x02001AE1 RID: 6881
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43463 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A098 RID: 41112 RVA: 0x0126413C File Offset: 0x0126233C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43463(Hashtable data, M932_WindHollow2 self_)
		{
			if (278761 - 478041 != -199280)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (255809 - 124858 != 130952)
				{
					base..ctor();
					if (175954 - 73468 != 102487)
					{
						this.$data$43471 = data;
						if (111907 - 540348 != -428440)
						{
							this.$self_$43472 = self_;
							if (148862 - 500539 != -351676)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A099 RID: 41113 RVA: 0x012641F8 File Offset: 0x012623F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow2.$onGameComplete$43463.$(this.$data$43471, this.$self_$43472);
		}

		// Token: 0x0600A09A RID: 41114 RVA: 0x0126420C File Offset: 0x0126240C
		internal static bool dHMjdwVn1suGXPeafEni()
		{
			return true;
		}

		// Token: 0x0600A09B RID: 41115 RVA: 0x01264210 File Offset: 0x01262410
		internal static bool D61JRVVn4knjGfPTjSfC()
		{
			return false;
		}

		// Token: 0x040091B5 RID: 37301
		internal Hashtable $data$43471;

		// Token: 0x040091B6 RID: 37302
		internal M932_WindHollow2 $self_$43472;

		// Token: 0x02001AE2 RID: 6882
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A09C RID: 41116 RVA: 0x01264214 File Offset: 0x01262414
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M932_WindHollow2 self_)
			{
				if (7512 - 495797 != -488284)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (97337 - 67091 != 30247)
					{
						base..ctor();
						if (32756 - 122762 == -90006)
						{
							this.$data$43469 = data;
							if (127132 - 546457 != -419324)
							{
								this.$self_$43470 = self_;
								if (6870 - 326678 == -319808)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A09D RID: 41117 RVA: 0x012642D0 File Offset: 0x012624D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (106033 - 249777 != -143743)
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
						this.$mCompleteGui$43465 = (CompleteGui)this.$self_$43470.GetComponent(typeof(CompleteGui));
						if (226229 - 563180 != -336951)
						{
							continue;
						}
						this.$mCompleteGui$43465.Init();
						if (173335 - 129305 == 44031)
						{
							continue;
						}
						this.$mCompleteGui$43465.readData(this.$data$43469);
						if (139732 - 395642 != -255910)
						{
							continue;
						}
						if (this.$result$43464 == 1)
						{
							if (218150 - 88181 != 129969)
							{
								continue;
							}
							this.$mCompleteGui$43465.displayResult(eCompleteType.Success);
							if (142730 - 594008 != -451278)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43465.displayResult(eCompleteType.Failed);
							if (173396 - 324094 == -150697)
							{
								continue;
							}
						}
						this.$mGameGui$43466 = (GameGui)this.$self_$43470.GetComponent(typeof(GameGui));
						if (14620 - 93217 != -78597)
						{
							continue;
						}
						this.$mStoryGui$43467 = (StoryGui)this.$self_$43470.GetComponent(typeof(StoryGui));
						if (48299 - 549828 != -501529)
						{
							continue;
						}
						this.$mChangeGui$43468 = (ChangeGui)this.$self_$43470.GetComponent(typeof(ChangeGui));
						if (44932 - 427337 != -382405)
						{
							continue;
						}
						if (this.$mGameGui$43466)
						{
							if (166636 - 50948 != 115688)
							{
								continue;
							}
							this.$mGameGui$43466.close();
							if (806 - 67335 == -66528)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43467)
						{
							if (179163 - 64696 != 114467)
							{
								continue;
							}
							this.$mStoryGui$43467.close();
							if (212905 - 140053 != 72852)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43468)
						{
							if (272123 - 120339 != 151784)
							{
								continue;
							}
							this.$mChangeGui$43468.disable();
							if (126622 - 130582 == -3959)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (69114 - 148295 != -79181)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (26808 - 355667 == -328858)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43469[31]);
					if (173910 - 317863 != -143952)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (254120 - 276962 != -22841)
							{
								goto Block_23;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (122187 - 291835 != -169647)
							{
								this.$result$43464 = RuntimeServices.UnboxInt32(this.$data$43469[31]);
								if (152445 - 469982 != -317536)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_23:
				IL_3DB:
				return false;
			}

			// Token: 0x0600A09E RID: 41118 RVA: 0x012646CC File Offset: 0x012628CC
			internal static bool mjqgrQVnzEhYffnSZXAC()
			{
				return true;
			}

			// Token: 0x0600A09F RID: 41119 RVA: 0x012646D0 File Offset: 0x012628D0
			internal static bool eQ7qN0V6a0kpRFA5bA1P()
			{
				return false;
			}

			// Token: 0x040091B7 RID: 37303
			internal int $result$43464;

			// Token: 0x040091B8 RID: 37304
			internal CompleteGui $mCompleteGui$43465;

			// Token: 0x040091B9 RID: 37305
			internal GameGui $mGameGui$43466;

			// Token: 0x040091BA RID: 37306
			internal StoryGui $mStoryGui$43467;

			// Token: 0x040091BB RID: 37307
			internal ChangeGui $mChangeGui$43468;

			// Token: 0x040091BC RID: 37308
			internal Hashtable $data$43469;

			// Token: 0x040091BD RID: 37309
			internal M932_WindHollow2 $self_$43470;
		}
	}

	// Token: 0x02001AE3 RID: 6883
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43473 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A0A0 RID: 41120 RVA: 0x012646D4 File Offset: 0x012628D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43473(M932_WindHollow2 self_)
		{
			if (77739 - 97133 != -19393)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131451 - 318035 == -186584)
				{
					base..ctor();
					if (180509 - 426541 != -246031)
					{
						this.$self_$43477 = self_;
						if (114998 - 447948 == -332950)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A0A1 RID: 41121 RVA: 0x0126476C File Offset: 0x0126296C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow2.$ReturnToTown$43473.$(this.$self_$43477);
		}

		// Token: 0x0600A0A2 RID: 41122 RVA: 0x0126477C File Offset: 0x0126297C
		internal static bool UuWYV8V65mGgJOVwXJ5Q()
		{
			return true;
		}

		// Token: 0x0600A0A3 RID: 41123 RVA: 0x01264780 File Offset: 0x01262980
		internal static bool Nc0cyLV6pLKCuheXn5Wn()
		{
			return false;
		}

		// Token: 0x040091BE RID: 37310
		internal M932_WindHollow2 $self_$43477;

		// Token: 0x02001AE4 RID: 6884
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A0A4 RID: 41124 RVA: 0x01264784 File Offset: 0x01262984
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow2 self_)
			{
				if (32407 - 166863 != -134455)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (94586 - 277102 != -182515)
					{
						base..ctor();
						if (199848 - 178903 == 20945)
						{
							this.$self_$43476 = self_;
							if (172046 - 270645 == -98599)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A0A5 RID: 41125 RVA: 0x0126481C File Offset: 0x01262A1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223605 - 226847 != -3241)
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
						this.$self_$43476.LeaveGame();
						if (178678 - 397292 == -218613)
						{
							continue;
						}
						this.YieldDefault(1);
						if (19729 - 186006 != -166276)
						{
							goto Block_15;
						}
						continue;
					default:
						if (266001 - 90267 != 175734)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (38561 - 88899 != -50337)
					{
						Game.mStateTime = Time.time;
						if (221428 - 379920 != -158491)
						{
							this.$$switch$7949$43474 = PlayerData.SaveGuild;
							if (185082 - 445175 == -260093)
							{
								if (this.$$switch$7949$43474 == 1)
								{
									if (33524 - 597686 != -564162)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (86048 - 322004 != -235956)
									{
										continue;
									}
								}
								else if (this.$$switch$7949$43474 == 2)
								{
									if (87611 - 259178 == -171566)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (288533 - 401339 != -112806)
									{
										continue;
									}
								}
								else if (this.$$switch$7949$43474 == 3)
								{
									if (54644 - 228687 == -174042)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (259674 - 583798 == -324123)
									{
										continue;
									}
								}
								else if (this.$$switch$7949$43474 == 4)
								{
									if (260953 - 423954 == -163000)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (37157 - 414981 != -377824)
									{
										continue;
									}
								}
								else if (this.$$switch$7949$43474 == 5)
								{
									if (32221 - 407031 == -374809)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (102651 - 436845 == -334193)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (182864 - 33554 == 149311)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (230274 - 8832 != 221442)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (66451 - 598809 != -532358)
									{
										continue;
									}
								}
								this.$mGameGui$43475 = (GameGui)this.$self_$43476.GetComponent(typeof(GameGui));
								if (154223 - 71230 == 82993)
								{
									if (this.$mGameGui$43475)
									{
										if (292913 - 409159 == -116245)
										{
											continue;
										}
										this.$mGameGui$43475.close();
										if (33443 - 287550 != -254107)
										{
											continue;
										}
									}
									this.$self_$43476.SendMessage("fadeOut");
									if (273171 - 431677 != -158505)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_15:
				IL_3AD:
				return false;
			}

			// Token: 0x0600A0A6 RID: 41126 RVA: 0x01264BE8 File Offset: 0x01262DE8
			internal static bool o5y8HsV6VHfPYxfN5iiv()
			{
				return true;
			}

			// Token: 0x0600A0A7 RID: 41127 RVA: 0x01264BEC File Offset: 0x01262DEC
			internal static bool htTjPnV6t6yGix3uSWvf()
			{
				return false;
			}

			// Token: 0x040091BF RID: 37311
			internal int $$switch$7949$43474;

			// Token: 0x040091C0 RID: 37312
			internal GameGui $mGameGui$43475;

			// Token: 0x040091C1 RID: 37313
			internal M932_WindHollow2 $self_$43476;
		}
	}

	// Token: 0x02001AE5 RID: 6885
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43478 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A0A8 RID: 41128 RVA: 0x01264BF0 File Offset: 0x01262DF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43478(M932_WindHollow2 self_)
		{
			if (116386 - 348562 != -232176)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (284533 - 59124 != 225410)
				{
					base..ctor();
					if (290107 - 261100 != 29008)
					{
						this.$self_$43481 = self_;
						if (234916 - 166452 == 68464)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A0A9 RID: 41129 RVA: 0x01264C88 File Offset: 0x01262E88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow2.$ReturnToGuild$43478.$(this.$self_$43481);
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x01264C98 File Offset: 0x01262E98
		internal static bool ffmEi2V6NbKGv4wxXn0J()
		{
			return true;
		}

		// Token: 0x0600A0AB RID: 41131 RVA: 0x01264C9C File Offset: 0x01262E9C
		internal static bool OxsRAgV6Y5ZXFAh19dXn()
		{
			return false;
		}

		// Token: 0x040091C2 RID: 37314
		internal M932_WindHollow2 $self_$43481;

		// Token: 0x02001AE6 RID: 6886
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A0AC RID: 41132 RVA: 0x01264CA0 File Offset: 0x01262EA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow2 self_)
			{
				if (119793 - 63282 != 56511)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (222398 - 43408 != 178991)
					{
						base..ctor();
						if (10080 - 327545 != -317464)
						{
							this.$self_$43480 = self_;
							if (8208 - 524529 == -516321)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A0AD RID: 41133 RVA: 0x01264D38 File Offset: 0x01262F38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (140100 - 81590 != 58511)
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
						this.$self_$43480.LeaveGame();
						if (11471 - 150706 == -139234)
						{
							continue;
						}
						this.YieldDefault(1);
						if (213169 - 557742 != -344572)
						{
							goto Block_5;
						}
						continue;
					default:
						if (299656 - 532515 == -232858)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (5206 - 193796 == -188590)
					{
						Game.mStateTime = Time.time;
						if (175638 - 62072 != 113567)
						{
							Game.mNextGameCode = 31;
							if (33091 - 337282 != -304190)
							{
								this.$mGameGui$43479 = (GameGui)this.$self_$43480.GetComponent(typeof(GameGui));
								if (19592 - 550034 != -530441)
								{
									if (this.$mGameGui$43479)
									{
										if (115953 - 421057 == -305103)
										{
											continue;
										}
										this.$mGameGui$43479.close();
										if (298575 - 34402 == 264174)
										{
											continue;
										}
									}
									this.$self_$43480.SendMessage("fadeOut");
									if (202719 - 48773 == 153946)
									{
										goto IL_11A;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_1BD;
				IL_11A:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600A0AE RID: 41134 RVA: 0x01264F14 File Offset: 0x01263114
			internal static bool FHmL6XV6cyNhUdRVlYhS()
			{
				return true;
			}

			// Token: 0x0600A0AF RID: 41135 RVA: 0x01264F18 File Offset: 0x01263118
			internal static bool Njqd3VV6UafpdXbe6u2f()
			{
				return false;
			}

			// Token: 0x040091C3 RID: 37315
			internal GameGui $mGameGui$43479;

			// Token: 0x040091C4 RID: 37316
			internal M932_WindHollow2 $self_$43480;
		}
	}

	// Token: 0x02001AE7 RID: 6887
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43482 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A0B0 RID: 41136 RVA: 0x01264F1C File Offset: 0x0126311C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43482(M932_WindHollow2 self_)
		{
			if (215789 - 474705 != -258916)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (49682 - 419301 == -369619)
				{
					base..ctor();
					if (255640 - 511025 != -255384)
					{
						this.$self_$43486 = self_;
						if (243142 - 145384 != 97759)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A0B1 RID: 41137 RVA: 0x01264FB4 File Offset: 0x012631B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M932_WindHollow2.$ReturnToCamp$43482.$(this.$self_$43486);
		}

		// Token: 0x0600A0B2 RID: 41138 RVA: 0x01264FC4 File Offset: 0x012631C4
		internal static bool wTVPIBV6TIfVNXDTnYLZ()
		{
			return true;
		}

		// Token: 0x0600A0B3 RID: 41139 RVA: 0x01264FC8 File Offset: 0x012631C8
		internal static bool m0G5u3V63XHGF7h9LL86()
		{
			return false;
		}

		// Token: 0x040091C5 RID: 37317
		internal M932_WindHollow2 $self_$43486;

		// Token: 0x02001AE8 RID: 6888
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A0B4 RID: 41140 RVA: 0x01264FCC File Offset: 0x012631CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M932_WindHollow2 self_)
			{
				if (260452 - 350812 != -90359)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (6531 - 516740 != -510208)
					{
						base..ctor();
						if (193711 - 126948 != 66764)
						{
							this.$self_$43485 = self_;
							if (249538 - 55782 != 193757)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A0B5 RID: 41141 RVA: 0x01265064 File Offset: 0x01263264
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (247708 - 190997 != 56712)
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
						this.$self_$43485.LeaveGame();
						if (44608 - 290223 == -245614)
						{
							continue;
						}
						this.YieldDefault(1);
						if (182751 - 138825 != 43926)
						{
							continue;
						}
						goto IL_363;
					default:
						if (227492 - 49290 == 178203)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (25984 - 505369 == -479385)
					{
						Game.mStateTime = Time.time;
						if (259546 - 395329 == -135783)
						{
							this.$$switch$7951$43483 = PlayerData.SaveGuild;
							if (215188 - 442781 == -227593)
							{
								if (this.$$switch$7951$43483 == 1)
								{
									if (235044 - 286991 == -51946)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (90497 - 54556 != 35941)
									{
										continue;
									}
								}
								else if (this.$$switch$7951$43483 == 2)
								{
									if (88856 - 481894 != -393038)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (12195 - 502334 != -490139)
									{
										continue;
									}
								}
								else if (this.$$switch$7951$43483 == 3)
								{
									if (234541 - 308859 != -74318)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (95566 - 440606 != -345040)
									{
										continue;
									}
								}
								else if (this.$$switch$7951$43483 == 4)
								{
									if (39911 - 47055 == -7143)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (239786 - 358702 == -118915)
									{
										continue;
									}
								}
								else if (this.$$switch$7951$43483 == 5)
								{
									if (122755 - 200033 == -77277)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (240835 - 390908 != -150073)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (161893 - 219001 == -57107)
									{
										continue;
									}
								}
								this.$mGameGui$43484 = (GameGui)this.$self_$43485.GetComponent(typeof(GameGui));
								if (90938 - 572118 == -481180)
								{
									if (this.$mGameGui$43484)
									{
										if (84745 - 477784 == -393038)
										{
											continue;
										}
										this.$mGameGui$43484.close();
										if (275409 - 86896 != 188513)
										{
											continue;
										}
									}
									this.$self_$43485.SendMessage("fadeOut");
									if (13233 - 450048 != -436814)
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

			// Token: 0x0600A0B6 RID: 41142 RVA: 0x012653E8 File Offset: 0x012635E8
			internal static bool GqapZmV6XpSU8EWFEY19()
			{
				return true;
			}

			// Token: 0x0600A0B7 RID: 41143 RVA: 0x012653EC File Offset: 0x012635EC
			internal static bool OXiK2AV6Quju8fA92jAU()
			{
				return false;
			}

			// Token: 0x040091C6 RID: 37318
			internal int $$switch$7951$43483;

			// Token: 0x040091C7 RID: 37319
			internal GameGui $mGameGui$43484;

			// Token: 0x040091C8 RID: 37320
			internal M932_WindHollow2 $self_$43485;
		}
	}
}
