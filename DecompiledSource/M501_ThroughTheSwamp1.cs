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

// Token: 0x0200157A RID: 5498
[Serializable]
public class M501_ThroughTheSwamp1 : MonoBehaviour
{
	// Token: 0x06007F61 RID: 32609 RVA: 0x0105C164 File Offset: 0x0105A364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M501_ThroughTheSwamp1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007F62 RID: 32610 RVA: 0x0105C174 File Offset: 0x0105A374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (226725 - 32079 != 194646)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (46179 - 78293 == -32114)
			{
				Game.mGameType = 5;
				if (17686 - 53205 != -35518)
				{
					if (Chat.Initialized)
					{
						if (223442 - 32404 != 191039)
						{
							Chat.ChatDisplay.Clear();
							if (87624 - 400743 == -313119)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (161929 - 559813 != -397883)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F63 RID: 32611 RVA: 0x0105C258 File Offset: 0x0105A458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (132499 - 178543 != -46043)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (255161 - 108889 != 146273)
				{
					if (Game.mNextGameCode != 501)
					{
						break;
					}
					if (188333 - 371204 != -182870)
					{
						Game.nextGame();
						if (1090 - 37879 != -36788)
						{
							Game.mGameCode = 501;
							if (267608 - 347129 == -79521)
							{
								Game.mGameType = 5;
								if (44854 - 65921 == -21067)
								{
									Game.mGameTime = Time.time;
									if (230573 - 505779 != -275205)
									{
										Game.mGameScore = 0;
										if (207565 - 281981 == -74416)
										{
											Game.mGameMana = 0;
											if (72364 - 277273 == -204909)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (182145 - 393534 != -211388)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (118255 - 330989 == -212734)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (75036 - 259824 != -184787)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (298955 - 598708 != -299752)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (74972 - 72469 != 2504)
																{
																	this.wxWcA3p59U0 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (21487 - 593141 != -571653)
																	{
																		this.QvwcAYrL4oh = PhotonClient.Connection;
																		if (212397 - 53731 == 158666)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (111821 - 69738 != 42084)
																			{
																				this.InitGame();
																				if (76265 - 151265 != -74999)
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
				if (274173 - 25312 != 248862)
				{
					Game.mGameType = 99;
					if (28655 - 152167 != -123511)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007F64 RID: 32612 RVA: 0x0105C560 File Offset: 0x0105A760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (145287 - 521990 != -376702)
		{
		}
		for (;;)
		{
			if (this.QvwcAYrL4oh == null)
			{
				if (84722 - 543442 != -458719)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (216865 - 412342 == -195477)
				{
					if (mGameState == eGameState.Init)
					{
						if (127873 - 407746 == -279873)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (272026 - 281203 != -9176)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (222012 - 216988 != 5025)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (221782 - 361454 == -139672)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (120253 - 496669 != -376415)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (3199 - 319423 == -316224)
						{
							if (Time.time > this.IEQcAbPlCmu)
							{
								if (257704 - 33138 == 224567)
								{
									continue;
								}
								Game.mGameMana++;
								if (275 - 360232 != -359957)
								{
									continue;
								}
								this.IEQcAbPlCmu = Time.time + (float)12;
								if (39642 - 453100 != -413458)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (275970 - 198171 != 77799)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (32299 - 10500 == 21800)
									{
										continue;
									}
									this.audio.Play();
									if (142810 - 66631 == 76180)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (253899 - 176311 == 77588)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (232915 - 204544 != 28372)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (55659 - 530547 == -474888)
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
						if (203422 - 272733 == -69311)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F65 RID: 32613 RVA: 0x0105C860 File Offset: 0x0105AA60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M501_ThroughTheSwamp1.$onGameEvent$39062(data, this).GetEnumerator();
	}

	// Token: 0x06007F66 RID: 32614 RVA: 0x0105C870 File Offset: 0x0105AA70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M501_ThroughTheSwamp1.$onGameComplete$39076(data, this).GetEnumerator();
	}

	// Token: 0x06007F67 RID: 32615 RVA: 0x0105C880 File Offset: 0x0105AA80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExit()
	{
		if (11509 - 8180 != 3330)
		{
		}
		while (this.g8rcAdfr8Q7 < 1)
		{
			if (217256 - 77325 != 139932)
			{
				this.g8rcAdfr8Q7 = 1;
				if (178384 - 9125 == 169259)
				{
					Game.sendMissionEvent(5011, 1);
					if (160286 - 498738 == -338452)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007F68 RID: 32616 RVA: 0x0105C924 File Offset: 0x0105AB24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseManaPillar(int nID)
	{
		if (45803 - 144244 != -98440)
		{
		}
		for (;;)
		{
			Debug.Log("UseManaPillar");
			if (158361 - 36352 != 122010)
			{
				if (!Game.mPlayer)
				{
					if (163256 - 57404 != 105853)
					{
						break;
					}
				}
				else if (this.HQOcAs49NMh == null)
				{
					if (229999 - 115092 != 114908)
					{
						break;
					}
				}
				else if (Extensions.get_length(this.HQOcAs49NMh) < nID)
				{
					if (66628 - 519097 == -452469)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (42135 - 457611 != -415475)
					{
						if (!characterControl)
						{
							goto IL_A8;
						}
						if (33670 - 364081 != -330411)
						{
							continue;
						}
						if (!(characterControl.actionState == "standby"))
						{
							if (141551 - 448080 != -306529)
							{
								continue;
							}
							goto IL_A8;
						}
						IL_D7:
						if (this.HQOcAs49NMh[nID - 1] > 0)
						{
							if (257470 - 135528 != 121942)
							{
								continue;
							}
							this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
							if (6125 - 276251 != -270125)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject gameObject = GameObject.Find("ManaPillar" + nID);
							if (7311 - 496160 != -488849)
							{
								continue;
							}
							if (gameObject)
							{
								if (100838 - 435781 == -334942)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (264032 - 500569 != -236537)
								{
									continue;
								}
								Game.mPlayer.SendMessage("activateIcon", nID);
								if (133620 - 539030 != -405409)
								{
									break;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find ManaPillar GameObject");
								if (95150 - 36359 != 58791)
								{
									continue;
								}
								break;
							}
						}
						IL_A8:
						if (characterControl.actionState == "run")
						{
							goto IL_D7;
						}
						if (119273 - 186972 == -67699)
						{
							if (!(characterControl.actionState == "emotion"))
							{
								break;
							}
							if (170720 - 473957 == -303237)
							{
								goto IL_D7;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F69 RID: 32617 RVA: 0x0105CC30 File Offset: 0x0105AE30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (225529 - 41151 != 184379)
		{
		}
		for (;;)
		{
			if (this.HQOcAs49NMh == null)
			{
				if (115131 - 149788 == -34657)
				{
					break;
				}
			}
			else if (Extensions.get_length(this.HQOcAs49NMh) < nID)
			{
				if (88672 - 523306 != -434633)
				{
					break;
				}
			}
			else if (this.HQOcAs49NMh[nID - 1] > 0)
			{
				if (57188 - 107353 == -50165)
				{
					this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
					if (173116 - 476860 == -303744)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(5014, nID);
				if (252958 - 325524 == -72566)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06007F6A RID: 32618 RVA: 0x0105CD40 File Offset: 0x0105AF40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateManaPillar(int nID)
	{
		if (13525 - 264037 != -250511)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("ManaPillar" + nID);
			if (74356 - 226962 != -152605)
			{
				if (!gameObject)
				{
					break;
				}
				if (13525 - 409601 != -396075)
				{
					if (!this.manaPillarEffect)
					{
						break;
					}
					if (27537 - 174615 != -147077)
					{
						UnityEngine.Object.Instantiate(this.manaPillarEffect, gameObject.transform.position, gameObject.transform.rotation);
						if (243048 - 91134 == 151914)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F6B RID: 32619 RVA: 0x0105CE34 File Offset: 0x0105B034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (83187 - 474461 != -391274)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (157975 - 84674 != 73302)
			{
				Hashtable customOpParameters = new Hashtable();
				if (57675 - 468229 == -410554)
				{
					this.QvwcAYrL4oh.OpCustom(52, customOpParameters, true);
					if (185344 - 49786 == 135558)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007F6C RID: 32620 RVA: 0x0105CEDC File Offset: 0x0105B0DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (42600 - 94154 != -51554)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (292074 - 29046 == 263028)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (37967 - 145967 != -107999)
				{
					Game.mGameState = eGameState.Setup;
					if (251574 - 465693 != -214118)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007F6D RID: 32621 RVA: 0x0105CF80 File Offset: 0x0105B180
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (77919 - 178483 != -100564)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (251945 - 290176 != -38230)
			{
				if (num == PlayerData.UID)
				{
					if (33345 - 131592 != -98246)
					{
						this.SetupActors();
						if (251744 - 246683 != 5062)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (169149 - 496674 != -327524)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007F6E RID: 32622 RVA: 0x0105D050 File Offset: 0x0105B250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (149894 - 69575 != 80320)
		{
		}
		for (;;)
		{
			IL_113:
			Debug.Log("Creating Actors");
			if (167384 - 431534 == -264150)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (252528 - 572156 == -319628)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (295583 - 467404 == -171821)
						{
							int i = 0;
							if (95510 - 275116 == -179606)
							{
								CharacterControl[] array2 = array;
								if (7801 - 200561 == -192760)
								{
									int length = array2.Length;
									if (132361 - 127588 != 4774)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (189182 - 164191 != 24991)
											{
												goto IL_113;
											}
											if (type == "FudaBug_b")
											{
												goto IL_1E8;
											}
											if (65243 - 557009 != -491766)
											{
												goto IL_113;
											}
											if (type == "FudaBug_r")
											{
												if (130861 - 145159 != -14298)
												{
													goto IL_113;
												}
												goto IL_1E8;
											}
											IL_24:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (252245 - 60280 == 191966)
											{
												goto IL_113;
											}
											this.RPHcAHDZcaP++;
											if (207769 - 358158 != -150389)
											{
												goto IL_113;
											}
											i++;
											if (105509 - 328046 != -222536)
											{
												continue;
											}
											goto IL_113;
											IL_1E8:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (21366 - 86323 != -64957)
											{
												goto IL_113;
											}
											goto IL_24;
										}
										if (18256 - 45420 == -27164)
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
						if (189126 - 31052 != 158075)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F6F RID: 32623 RVA: 0x0105D2F0 File Offset: 0x0105B4F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (62058 - 385650 != -323592)
		{
		}
		for (;;)
		{
			IL_B4:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (117773 - 580764 != -462990)
			{
				int i = 0;
				if (289853 - 344724 != -54870)
				{
					CharacterControl[] array2 = array;
					if (34681 - 188531 != -153849)
					{
						int length = array2.Length;
						if (170114 - 182030 != -11915)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (156736 - 163793 != -7057)
								{
									goto IL_B4;
								}
								i++;
								if (199153 - 488412 == -289258)
								{
									goto IL_B4;
								}
							}
							if (146818 - 207726 == -60908)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F70 RID: 32624 RVA: 0x0105D420 File Offset: 0x0105B620
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (126883 - 426756 != -299872)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (52706 - 263786 != -211079)
			{
				hashtable.Add(43, PlayerData.UID);
				if (242803 - 117711 != 125093)
				{
					hashtable.Add(73, nType);
					if (40578 - 242927 != -202348)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (43640 - 11294 == 32346)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (106414 - 351484 != -245069)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (113530 - 186714 != -73183)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (102115 - 148920 != -46804)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (237295 - 300861 != -63565)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (58877 - 51595 == 7282)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (205593 - 270632 != -65038)
												{
													this.QvwcAYrL4oh.OpCustom(63, hashtable, true);
													if (123907 - 157556 != -33648)
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

	// Token: 0x06007F71 RID: 32625 RVA: 0x0105D6D8 File Offset: 0x0105B8D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (84172 - 414639 != -330466)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createActor(data);
			if (44492 - 599313 != -554820)
			{
				if (Game.mGameState != eGameState.Setup)
				{
					break;
				}
				if (126898 - 568396 != -441497)
				{
					if (this.RPHcAHDZcaP <= 0)
					{
						break;
					}
					if (281804 - 505932 == -224128)
					{
						this.RPHcAHDZcaP--;
						if (281431 - 471643 != -190211)
						{
							if (this.RPHcAHDZcaP != 0)
							{
								break;
							}
							if (134738 - 447491 == -312753)
							{
								Game.setGameState(eGameState.Ready);
								if (142468 - 515452 == -372984)
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

	// Token: 0x06007F72 RID: 32626 RVA: 0x0105D7EC File Offset: 0x0105B9EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06007F73 RID: 32627 RVA: 0x0105D800 File Offset: 0x0105BA00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (282373 - 423097 != -140723)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (286677 - 409613 != -122935)
			{
				if (!characterControl)
				{
					break;
				}
				if (291717 - 2584 != 289134)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (179251 - 52811 == 126440)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (211011 - 305165 == -94154)
						{
							string type = characterControl.Type;
							if (70462 - 23164 == 47298)
							{
								if (type == "FudaBug_b")
								{
									if (132742 - 176235 == -43492)
									{
										continue;
									}
								}
								else if (type == "FudaBug_r")
								{
									if (216877 - 582835 == -365957)
									{
										continue;
									}
								}
								else
								{
									if (!(type == "WormBug"))
									{
										if (78787 - 43219 != 35568)
										{
											continue;
										}
										if (!(type == "WormBug_p"))
										{
											break;
										}
										if (35352 - 315858 == -280505)
										{
											continue;
										}
									}
									Game.sendMissionEvent(5013, 0);
									if (79200 - 24854 != 54347)
									{
										break;
									}
									continue;
								}
								Game.sendMissionEvent(5012, 0);
								if (84682 - 294742 != -210059)
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

	// Token: 0x06007F74 RID: 32628 RVA: 0x0105D9FC File Offset: 0x0105BBFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (55556 - 313636 != -258080)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (299613 - 343160 == -43547)
			{
				Game.mGameState = eGameState.Ready;
				if (33392 - 449934 == -416542)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (27871 - 596707 != -568835)
					{
						GameObject gameObject = null;
						if (184337 - 484663 == -300326)
						{
							GameObject gameObject2 = null;
							if (77370 - 427130 == -349760)
							{
								if (playerSlot > 1)
								{
									if (244949 - 441476 == -196526)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (272892 - 53110 != 219782)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (245649 - 472904 == -227254)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (152557 - 403109 != -250552)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (263598 - 53199 == 210400)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (100058 - 475950 == -375891)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (272116 - 404137 == -132020)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (67483 - 274424 != -206941)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (257017 - 195771 != 61246)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (173270 - 515236 != -341966)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (202329 - 530331 == -328002)
								{
									this.transform.position = gameObject2.transform.position;
									if (231286 - 194171 == 37115)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (139265 - 210053 == -70788)
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

	// Token: 0x06007F75 RID: 32629 RVA: 0x0105DCF8 File Offset: 0x0105BEF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (106830 - 110513 != -3682)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (261235 - 483248 != -222012)
			{
				Game.mGameState = eGameState.Normal;
				if (190534 - 82182 == 108352)
				{
					Time.timeScale = 1f;
					if (95816 - 159678 == -63862)
					{
						this.HQOcAs49NMh = new int[4];
						if (3201 - 183861 == -180660)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (214007 - 260904 != -46896)
							{
								gameGui.enabled = true;
								if (124625 - 96283 == 28342)
								{
									LoadingGui loadingGui = (LoadingGui)this.GetComponent(typeof(LoadingGui));
									if (263508 - 180611 == 82897)
									{
										loadingGui.fadeIn();
										if (279938 - 555749 == -275811)
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

	// Token: 0x06007F76 RID: 32630 RVA: 0x0105DE60 File Offset: 0x0105C060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007F77 RID: 32631 RVA: 0x0105DE64 File Offset: 0x0105C064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (139002 - 571257 != -432255)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (216364 - 83443 == 132921)
			{
				hashtable.Add(71, CID);
				if (239719 - 298729 != -59009)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (29689 - 397289 == -367600)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (18697 - 434355 != -415657)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (126234 - 450895 != -324660)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (265719 - 173528 == 92191)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (213403 - 412319 == -198916)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (289686 - 347577 == -57891)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (221215 - 516280 != -295064)
											{
												this.QvwcAYrL4oh.OpCustom(61, hashtable, true);
												if (184355 - 25289 != 159067)
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

	// Token: 0x06007F78 RID: 32632 RVA: 0x0105E0F0 File Offset: 0x0105C2F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (157764 - 415915 != -258150)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (243875 - 206222 == 37653)
			{
				if (!gameObject)
				{
					break;
				}
				if (213571 - 436440 != -222868)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (200215 - 543727 != -343511)
					{
						playerCameraControl.target = gameObject;
						if (75846 - 93304 == -17458)
						{
							this.StartGame();
							if (125343 - 556687 != -431343)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F79 RID: 32633 RVA: 0x0105E1E0 File Offset: 0x0105C3E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (152299 - 383520 != -231221)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (66982 - 24409 != 42574)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (284840 - 335868 == -51028)
				{
					gameGui.ResetTeamBar();
					if (228308 - 419341 == -191033)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007F7A RID: 32634 RVA: 0x0105E28C File Offset: 0x0105C48C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M501_ThroughTheSwamp1.$onDeadPlayer$39085(this).GetEnumerator();
	}

	// Token: 0x06007F7B RID: 32635 RVA: 0x0105E29C File Offset: 0x0105C49C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (244374 - 105082 != 139292)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (782 - 342863 != -342080)
			{
				this.wxWcA3p59U0.target = Game.mPlayer;
				if (84147 - 40666 != 43482)
				{
					this.wxWcA3p59U0.enabled = true;
					if (182869 - 397502 == -214633)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (27732 - 547552 == -519819)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (13035 - 181518 != -168483)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (138547 - 301247 != -162699)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (244645 - 281054 != -36408)
							{
								if (!gameGui)
								{
									break;
								}
								if (214280 - 288149 == -73869)
								{
									gameGui.enabled = true;
									if (115457 - 10759 != 104699)
									{
										gameGui.closeDeadMenu();
										if (165950 - 522771 == -356821)
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

	// Token: 0x06007F7C RID: 32636 RVA: 0x0105E448 File Offset: 0x0105C648
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (927 - 369799 != -368872)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (165712 - 508161 != -342448)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (269672 - 94459 != 175214)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (280987 - 597267 != -316279)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007F7D RID: 32637 RVA: 0x0105E50C File Offset: 0x0105C70C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007F7E RID: 32638 RVA: 0x0105E538 File Offset: 0x0105C738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M501_ThroughTheSwamp1.$ReturnToTown$39091(this).GetEnumerator();
	}

	// Token: 0x06007F7F RID: 32639 RVA: 0x0105E548 File Offset: 0x0105C748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M501_ThroughTheSwamp1.$ReturnToGuild$39096(this).GetEnumerator();
	}

	// Token: 0x06007F80 RID: 32640 RVA: 0x0105E558 File Offset: 0x0105C758
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M501_ThroughTheSwamp1.$ReturnToCamp$39100(this).GetEnumerator();
	}

	// Token: 0x06007F81 RID: 32641 RVA: 0x0105E568 File Offset: 0x0105C768
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (132735 - 233607 != -100871)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (219251 - 561948 != -342696)
			{
				Hashtable hashtable = new Hashtable();
				if (69508 - 151842 == -82334)
				{
					hashtable.Add(43, PlayerData.UID);
					if (188168 - 58605 == 129563)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (206919 - 374611 != -167691)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F82 RID: 32642 RVA: 0x0105E640 File Offset: 0x0105C840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007F83 RID: 32643 RVA: 0x0105E654 File Offset: 0x0105C854
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (170098 - 501290 != -331191)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (9117 - 379790 == -370673)
			{
				Hashtable hashtable = new Hashtable();
				if (278296 - 505886 != -227589)
				{
					if (Game.mNextGameCode == 30)
					{
						if (24775 - 111884 == -87108)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (259276 - 549562 == -290285)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (240997 - 562412 == -321414)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (178619 - 225950 != -47331)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (237993 - 120711 == 117283)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (141165 - 3516 == 137650)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (40011 - 552828 == -512816)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (15227 - 26746 != -11519)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (159419 - 266443 == -107023)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (135712 - 422288 == -286575)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (123282 - 257134 != -133852)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (252014 - 88114 != 163900)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (178957 - 86587 != 92370)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (106602 - 253475 != -146873)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (22469 - 575516 != -553047)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (78885 - 126060 != -47175)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (272378 - 111092 != 161286)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (151892 - 60494 == 91399)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (190139 - 473108 == -282968)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (64789 - 339563 != -274774)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (102246 - 106079 != -3833)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (885 - 204219 != -203334)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (263946 - 554704 == -290757)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (274792 - 550349 != -275557)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (239900 - 478222 == -238321)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (2596 - 283675 != -281079)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (47414 - 341069 != -293655)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (105758 - 517667 != -411909)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (26036 - 425207 != -399170)
					{
						this.QvwcAYrL4oh.OpCustom(42, hashtable, true);
						if (269239 - 182732 == 86507)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007F84 RID: 32644 RVA: 0x0105EC08 File Offset: 0x0105CE08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007F85 RID: 32645 RVA: 0x0105EC18 File Offset: 0x0105CE18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007F86 RID: 32646 RVA: 0x0105EC1C File Offset: 0x0105CE1C
	internal static bool ed9LbOpeovP39WIqcuyx()
	{
		return true;
	}

	// Token: 0x06007F87 RID: 32647 RVA: 0x0105EC20 File Offset: 0x0105CE20
	internal static bool FnDA8YpeEUf8T2hIpjH5()
	{
		return false;
	}

	// Token: 0x04007EE7 RID: 32487
	private LitePeer QvwcAYrL4oh;

	// Token: 0x04007EE8 RID: 32488
	private PlayerCameraControl wxWcA3p59U0;

	// Token: 0x04007EE9 RID: 32489
	private float IEQcAbPlCmu;

	// Token: 0x04007EEA RID: 32490
	private int g8rcAdfr8Q7;

	// Token: 0x04007EEB RID: 32491
	private int rS3cAgNAuwl;

	// Token: 0x04007EEC RID: 32492
	private int l7scAa5Lwq9;

	// Token: 0x04007EED RID: 32493
	private int UBtcA4gMNcc;

	// Token: 0x04007EEE RID: 32494
	private int[] HQOcAs49NMh;

	// Token: 0x04007EEF RID: 32495
	public GameObject manaPillarEffect;

	// Token: 0x04007EF0 RID: 32496
	private int RPHcAHDZcaP;

	// Token: 0x0200157B RID: 5499
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$39062 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007F88 RID: 32648 RVA: 0x0105EC24 File Offset: 0x0105CE24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$39062(Hashtable data, M501_ThroughTheSwamp1 self_)
		{
			if (159810 - 207698 != -47887)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (187716 - 490361 != -302644)
				{
					base..ctor();
					if (231735 - 74508 != 157228)
					{
						this.$data$39074 = data;
						if (69505 - 9701 != 59805)
						{
							this.$self_$39075 = self_;
							if (111516 - 63454 != 48063)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007F89 RID: 32649 RVA: 0x0105ECE0 File Offset: 0x0105CEE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp1.$onGameEvent$39062.$(this.$data$39074, this.$self_$39075);
		}

		// Token: 0x06007F8A RID: 32650 RVA: 0x0105ECF4 File Offset: 0x0105CEF4
		internal static bool aMShSRpe2Mq9l0Zo9uuU()
		{
			return true;
		}

		// Token: 0x06007F8B RID: 32651 RVA: 0x0105ECF8 File Offset: 0x0105CEF8
		internal static bool AmSK8spe8ZqB0FaXv2Nt()
		{
			return false;
		}

		// Token: 0x04007EF1 RID: 32497
		internal Hashtable $data$39074;

		// Token: 0x04007EF2 RID: 32498
		internal M501_ThroughTheSwamp1 $self_$39075;

		// Token: 0x0200157C RID: 5500
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007F8C RID: 32652 RVA: 0x0105ECFC File Offset: 0x0105CEFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M501_ThroughTheSwamp1 self_)
			{
				if (143247 - 480483 != -337236)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (170556 - 32573 != 137984)
					{
						base..ctor();
						if (115639 - 393488 == -277849)
						{
							this.$data$39072 = data;
							if (176290 - 362541 == -186251)
							{
								this.$self_$39073 = self_;
								if (172818 - 290736 != -117917)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007F8D RID: 32653 RVA: 0x0105EDB8 File Offset: 0x0105CFB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (222204 - 150503 != 71701)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8FA;
					case 2:
						Game.mGameStage = 2;
						if (51384 - 23530 == 27855)
						{
							continue;
						}
						Application.LoadLevel("M501_ThroughTheSwamp2");
						if (169763 - 268315 != -98551)
						{
							goto IL_304;
						}
						continue;
					default:
						if (6792 - 192552 == -185759)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (172717 - 468938 != -296221)
						{
							continue;
						}
						goto IL_830;
					}
					else
					{
						this.$returnCode$39063 = RuntimeServices.UnboxInt32(this.$data$39072[141]);
						if (296254 - 286184 != 10070)
						{
							continue;
						}
						this.$returnValue$39064 = RuntimeServices.UnboxInt32(this.$data$39072[145]);
						if (166535 - 72593 == 93943)
						{
							continue;
						}
						this.$ownerID$39065 = RuntimeServices.UnboxInt32(this.$data$39072[43]);
						if (236656 - 387116 != -150460)
						{
							continue;
						}
						this.$$switch$6844$39066 = this.$returnCode$39063;
						if (92307 - 47110 == 45198)
						{
							continue;
						}
						if (this.$$switch$6844$39066 == 5011)
						{
							if (79648 - 100390 != -20742)
							{
								continue;
							}
							if (this.$returnValue$39064 == 1)
							{
								if (217507 - 166503 != 51004)
								{
									continue;
								}
								if (this.$self_$39073.g8rcAdfr8Q7 < 2)
								{
									if (166885 - 554488 != -387603)
									{
										continue;
									}
									this.$self_$39073.g8rcAdfr8Q7 = 2;
									if (225026 - 26396 != 198630)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (97513 - 444907 == -347393)
									{
										continue;
									}
									this.$mGameGui$39067 = (GameGui)this.$self_$39073.GetComponent(typeof(GameGui));
									if (151849 - 233930 != -82081)
									{
										continue;
									}
									this.$mGameGui$39067.close();
									if (208179 - 339694 == -131514)
									{
										continue;
									}
									Game.savePlayer();
									if (94043 - 473576 != -379533)
									{
										continue;
									}
									this.$self_$39073.SendMessage("fadeOut");
									if (174712 - 460710 != -285997)
									{
										break;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$6844$39066 == 5012)
						{
							if (60589 - 172511 == -111921)
							{
								continue;
							}
							this.$self_$39073.rS3cAgNAuwl = this.$self_$39073.rS3cAgNAuwl + 1;
							if (214713 - 64647 != 150066)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$39065)
							{
								if (42745 - 200721 != -157976)
								{
									continue;
								}
								if (this.$self_$39073.rS3cAgNAuwl >= 4)
								{
									if (92951 - 387846 != -294895)
									{
										continue;
									}
									if (this.$self_$39073.rS3cAgNAuwl < 40)
									{
										if (248690 - 56121 != 192569)
										{
											continue;
										}
										this.$mSpawnPoint$39068 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 6));
										if (210177 - 516140 != -305962)
										{
											if (this.$mSpawnPoint$39068)
											{
												if (162556 - 579242 == -416685)
												{
													continue;
												}
												this.$mSpawnPos$39069 = global::Math.getRandomSpawnPos(this.$mSpawnPoint$39068.transform.position, 5);
												if (170746 - 380338 != -209592)
												{
													continue;
												}
												if (this.$mSpawnPos$39069 == Vector3.zero)
												{
													if (157010 - 426344 == -269333)
													{
														continue;
													}
													this.$mSpawnPos$39069 = this.$mSpawnPoint$39068.transform.position;
													if (95480 - 34717 == 60764)
													{
														continue;
													}
												}
												if (UnityEngine.Random.Range(0, 100) < 60)
												{
													if (166933 - 33022 != 133911)
													{
														continue;
													}
													this.$self_$39073.createActor("FudaBug_b", 6, this.$mSpawnPos$39069, this.$mSpawnPoint$39068.transform.forward);
													if (47257 - 146972 != -99715)
													{
														continue;
													}
												}
												else
												{
													this.$self_$39073.createActor("FudaBug_r", 6, this.$mSpawnPos$39069, this.$mSpawnPoint$39068.transform.forward);
													if (144847 - 486700 != -341853)
													{
														continue;
													}
												}
											}
											goto IL_632;
										}
										continue;
									}
								}
								if (this.$self_$39073.rS3cAgNAuwl == 40)
								{
									if (173187 - 136423 == 36765)
									{
										continue;
									}
									this.$mSpawnPoint3$39070 = GameObject.Find("SpawnPoint2");
									if (26278 - 483959 != -457681)
									{
										continue;
									}
									this.$mSpawnPoint4$39071 = GameObject.Find("SpawnPoint4");
									if (235810 - 440296 == -204485)
									{
										continue;
									}
									if (this.$mSpawnPoint3$39070)
									{
										if (289107 - 568594 != -279487)
										{
											continue;
										}
										this.$self_$39073.createActor("WormBug_p", 6, this.$mSpawnPoint3$39070.transform.position, this.$mSpawnPoint3$39070.transform.forward);
										if (74402 - 251877 != -177475)
										{
											continue;
										}
									}
									if (this.$mSpawnPoint4$39071)
									{
										if (247920 - 14398 == 233523)
										{
											continue;
										}
										this.$self_$39073.createActor("WormBug_p", 6, this.$mSpawnPoint4$39071.transform.position, this.$mSpawnPoint4$39071.transform.forward);
										if (94539 - 574877 != -480338)
										{
											continue;
										}
									}
								}
							}
							IL_632:;
						}
						else if (this.$$switch$6844$39066 == 5013)
						{
							if (139581 - 156926 != -17345)
							{
								continue;
							}
							this.$self_$39073.l7scAa5Lwq9 = this.$self_$39073.l7scAa5Lwq9 + 1;
							if (97538 - 461880 != -364342)
							{
								continue;
							}
						}
						else if (this.$$switch$6844$39066 == 5014)
						{
							if (193084 - 100110 == 92975)
							{
								continue;
							}
							if (this.$self_$39073.HQOcAs49NMh[this.$returnValue$39064 - 1] > 0)
							{
								if (136772 - 486980 == -350207)
								{
									continue;
								}
								this.$self_$39073.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
								if (211809 - 276076 == -64266)
								{
									continue;
								}
							}
							else
							{
								this.$self_$39073.HQOcAs49NMh[this.$returnValue$39064 - 1] = 1;
								if (123393 - 108094 != 15299)
								{
									continue;
								}
								this.$self_$39073.UBtcA4gMNcc = this.$self_$39073.UBtcA4gMNcc + 1;
								if (56266 - 11282 == 44985)
								{
									continue;
								}
								this.$self_$39073.ActivateManaPillar(this.$returnValue$39064);
								if (210512 - 374568 != -164056)
								{
									continue;
								}
								this.$self_$39073.SendMessage("newGameMessage", "ManaPillar activated :" + this.$self_$39073.UBtcA4gMNcc + "/4");
								if (192229 - 35323 == 156907)
								{
									continue;
								}
							}
						}
					}
					IL_597:
					this.YieldDefault(1);
					if (284660 - 74535 != 210126)
					{
						goto Block_39;
					}
					continue;
					IL_304:
					goto IL_597;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_39:
				IL_830:
				IL_8FA:
				return false;
			}

			// Token: 0x06007F8E RID: 32654 RVA: 0x0105F6D4 File Offset: 0x0105D8D4
			internal static bool X1gn5KpeZSDOpuTMiNxs()
			{
				return true;
			}

			// Token: 0x06007F8F RID: 32655 RVA: 0x0105F6D8 File Offset: 0x0105D8D8
			internal static bool Y5OAxwpeCd5I5iX7KYdm()
			{
				return false;
			}

			// Token: 0x04007EF3 RID: 32499
			internal int $returnCode$39063;

			// Token: 0x04007EF4 RID: 32500
			internal int $returnValue$39064;

			// Token: 0x04007EF5 RID: 32501
			internal int $ownerID$39065;

			// Token: 0x04007EF6 RID: 32502
			internal int $$switch$6844$39066;

			// Token: 0x04007EF7 RID: 32503
			internal GameGui $mGameGui$39067;

			// Token: 0x04007EF8 RID: 32504
			internal GameObject $mSpawnPoint$39068;

			// Token: 0x04007EF9 RID: 32505
			internal Vector3 $mSpawnPos$39069;

			// Token: 0x04007EFA RID: 32506
			internal GameObject $mSpawnPoint3$39070;

			// Token: 0x04007EFB RID: 32507
			internal GameObject $mSpawnPoint4$39071;

			// Token: 0x04007EFC RID: 32508
			internal Hashtable $data$39072;

			// Token: 0x04007EFD RID: 32509
			internal M501_ThroughTheSwamp1 $self_$39073;
		}
	}

	// Token: 0x0200157D RID: 5501
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39076 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007F90 RID: 32656 RVA: 0x0105F6DC File Offset: 0x0105D8DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39076(Hashtable data, M501_ThroughTheSwamp1 self_)
		{
			if (129662 - 558823 != -429161)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (213335 - 562801 != -349465)
				{
					base..ctor();
					if (240261 - 87766 != 152496)
					{
						this.$data$39083 = data;
						if (31073 - 581517 == -550444)
						{
							this.$self_$39084 = self_;
							if (215204 - 329615 != -114410)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007F91 RID: 32657 RVA: 0x0105F798 File Offset: 0x0105D998
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp1.$onGameComplete$39076.$(this.$data$39083, this.$self_$39084);
		}

		// Token: 0x06007F92 RID: 32658 RVA: 0x0105F7AC File Offset: 0x0105D9AC
		internal static bool GOpdORpeLX2ODPZNemV6()
		{
			return true;
		}

		// Token: 0x06007F93 RID: 32659 RVA: 0x0105F7B0 File Offset: 0x0105D9B0
		internal static bool TeuhL6peOhn6X3OaxOYn()
		{
			return false;
		}

		// Token: 0x04007EFE RID: 32510
		internal Hashtable $data$39083;

		// Token: 0x04007EFF RID: 32511
		internal M501_ThroughTheSwamp1 $self_$39084;

		// Token: 0x0200157E RID: 5502
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007F94 RID: 32660 RVA: 0x0105F7B4 File Offset: 0x0105D9B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M501_ThroughTheSwamp1 self_)
			{
				if (287491 - 254570 != 32922)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (7232 - 258069 != -250836)
					{
						base..ctor();
						if (164031 - 556018 == -391987)
						{
							this.$data$39081 = data;
							if (217808 - 583473 != -365664)
							{
								this.$self_$39082 = self_;
								if (193872 - 589648 == -395776)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007F95 RID: 32661 RVA: 0x0105F870 File Offset: 0x0105DA70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (258155 - 181532 != 76623)
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
						this.$mCompleteGui$39078 = (CompleteGui)this.$self_$39082.GetComponent(typeof(CompleteGui));
						if (84160 - 316332 == -232171)
						{
							continue;
						}
						this.$mCompleteGui$39078.Init();
						if (8181 - 472153 != -463972)
						{
							continue;
						}
						this.$mCompleteGui$39078.readData(this.$data$39081);
						if (126380 - 429218 != -302838)
						{
							continue;
						}
						if (this.$result$39077 == 1)
						{
							if (140997 - 495381 != -354384)
							{
								continue;
							}
							this.$mCompleteGui$39078.displayResult(eCompleteType.Success);
							if (61679 - 467300 == -405620)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39078.displayResult(eCompleteType.Failed);
							if (164846 - 430872 != -266026)
							{
								continue;
							}
						}
						this.$mGameGui$39079 = (GameGui)this.$self_$39082.GetComponent(typeof(GameGui));
						if (43806 - 568330 == -524523)
						{
							continue;
						}
						this.$mStoryGui$39080 = (StoryGui)this.$self_$39082.GetComponent(typeof(StoryGui));
						if (67934 - 39818 != 28116)
						{
							continue;
						}
						if (this.$mGameGui$39079)
						{
							if (80671 - 435207 == -354535)
							{
								continue;
							}
							this.$mGameGui$39079.close();
							if (90220 - 415643 == -325422)
							{
								continue;
							}
						}
						if (this.$mStoryGui$39080)
						{
							if (220146 - 72088 != 148058)
							{
								continue;
							}
							this.$mStoryGui$39080.close();
							if (298386 - 359587 == -61200)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (157578 - 304931 != -147353)
						{
							continue;
						}
						goto IL_352;
					default:
						if (195963 - 103813 == 92151)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$39081[31]);
					if (279550 - 333380 == -53830)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (167020 - 9511 == 157509)
							{
								goto IL_2BD;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (136379 - 473621 != -337241)
							{
								this.$result$39077 = RuntimeServices.UnboxInt32(this.$data$39081[31]);
								if (57266 - 152477 == -95211)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_2BD:
				IL_352:
				return false;
			}

			// Token: 0x06007F96 RID: 32662 RVA: 0x0105FBE4 File Offset: 0x0105DDE4
			internal static bool Pn0mPwpemH0mmXatei8J()
			{
				return true;
			}

			// Token: 0x06007F97 RID: 32663 RVA: 0x0105FBE8 File Offset: 0x0105DDE8
			internal static bool cNGxTXpeF9N4oecMPJeU()
			{
				return false;
			}

			// Token: 0x04007F00 RID: 32512
			internal int $result$39077;

			// Token: 0x04007F01 RID: 32513
			internal CompleteGui $mCompleteGui$39078;

			// Token: 0x04007F02 RID: 32514
			internal GameGui $mGameGui$39079;

			// Token: 0x04007F03 RID: 32515
			internal StoryGui $mStoryGui$39080;

			// Token: 0x04007F04 RID: 32516
			internal Hashtable $data$39081;

			// Token: 0x04007F05 RID: 32517
			internal M501_ThroughTheSwamp1 $self_$39082;
		}
	}

	// Token: 0x0200157F RID: 5503
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39085 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007F98 RID: 32664 RVA: 0x0105FBEC File Offset: 0x0105DDEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39085(M501_ThroughTheSwamp1 self_)
		{
			if (69946 - 411445 != -341498)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (21348 - 397396 == -376048)
				{
					base..ctor();
					if (291135 - 198976 != 92160)
					{
						this.$self_$39090 = self_;
						if (21164 - 353242 == -332078)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007F99 RID: 32665 RVA: 0x0105FC84 File Offset: 0x0105DE84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp1.$onDeadPlayer$39085.$(this.$self_$39090);
		}

		// Token: 0x06007F9A RID: 32666 RVA: 0x0105FC94 File Offset: 0x0105DE94
		internal static bool NRYibJpeM266sXlmHqPE()
		{
			return true;
		}

		// Token: 0x06007F9B RID: 32667 RVA: 0x0105FC98 File Offset: 0x0105DE98
		internal static bool DoEYXkpexAdnxeaEZGsT()
		{
			return false;
		}

		// Token: 0x04007F06 RID: 32518
		internal M501_ThroughTheSwamp1 $self_$39090;

		// Token: 0x02001580 RID: 5504
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007F9C RID: 32668 RVA: 0x0105FC9C File Offset: 0x0105DE9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M501_ThroughTheSwamp1 self_)
			{
				if (107356 - 183397 != -76040)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (223351 - 16788 != 206564)
					{
						base..ctor();
						if (213621 - 430447 == -216826)
						{
							this.$self_$39089 = self_;
							if (153030 - 240173 == -87143)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007F9D RID: 32669 RVA: 0x0105FD34 File Offset: 0x0105DF34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68922 - 51503 != 17420)
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
							if (263097 - 207646 != 55451)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_26C;
							}
							if (182489 - 261005 != -78516)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (77368 - 45030 != 32338)
						{
							continue;
						}
						this.$mStoryGui$39086 = (StoryGui)this.$self_$39089.GetComponent(typeof(StoryGui));
						if (236257 - 377581 != -141324)
						{
							continue;
						}
						if (this.$mStoryGui$39086)
						{
							if (140173 - 242196 == -102022)
							{
								continue;
							}
							this.$mStoryGui$39086.close();
							if (81768 - 507713 == -425944)
							{
								continue;
							}
						}
						this.$mChangeGui$39087 = (ChangeGui)this.$self_$39089.GetComponent(typeof(ChangeGui));
						if (264159 - 338129 == -73969)
						{
							continue;
						}
						if (this.$mChangeGui$39087)
						{
							if (261182 - 256960 != 4222)
							{
								continue;
							}
							this.$mChangeGui$39087.close();
							if (155346 - 211200 != -55854)
							{
								continue;
							}
						}
						this.$mGameGui$39088 = (GameGui)this.$self_$39089.GetComponent(typeof(GameGui));
						if (261363 - 515055 == -253691)
						{
							continue;
						}
						if (this.$mGameGui$39088)
						{
							if (252459 - 123115 == 129345)
							{
								continue;
							}
							if (!this.$mGameGui$39088.enabled)
							{
								if (78805 - 526787 != -447982)
								{
									continue;
								}
								this.$mGameGui$39088.enabled = true;
								if (72181 - 313166 != -240985)
								{
									continue;
								}
							}
							this.$mGameGui$39088.openDeadMenu();
							if (121292 - 358188 == -236895)
							{
								continue;
							}
						}
						IL_26C:
						this.YieldDefault(1);
						if (193081 - 460681 != -267600)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (126607 - 498520 == -371912)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (293738 - 510687 == -216948);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007F9E RID: 32670 RVA: 0x0106004C File Offset: 0x0105E24C
			internal static bool liVZSepegG3SHQsltbyT()
			{
				return true;
			}

			// Token: 0x06007F9F RID: 32671 RVA: 0x01060050 File Offset: 0x0105E250
			internal static bool XPfZjTpefjVTLfy4hFqu()
			{
				return false;
			}

			// Token: 0x04007F07 RID: 32519
			internal StoryGui $mStoryGui$39086;

			// Token: 0x04007F08 RID: 32520
			internal ChangeGui $mChangeGui$39087;

			// Token: 0x04007F09 RID: 32521
			internal GameGui $mGameGui$39088;

			// Token: 0x04007F0A RID: 32522
			internal M501_ThroughTheSwamp1 $self_$39089;
		}
	}

	// Token: 0x02001581 RID: 5505
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39091 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007FA0 RID: 32672 RVA: 0x01060054 File Offset: 0x0105E254
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39091(M501_ThroughTheSwamp1 self_)
		{
			if (33300 - 241174 != -207874)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (241069 - 310664 == -69595)
				{
					base..ctor();
					if (40826 - 220170 == -179344)
					{
						this.$self_$39095 = self_;
						if (280732 - 287712 == -6980)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007FA1 RID: 32673 RVA: 0x010600EC File Offset: 0x0105E2EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp1.$ReturnToTown$39091.$(this.$self_$39095);
		}

		// Token: 0x06007FA2 RID: 32674 RVA: 0x010600FC File Offset: 0x0105E2FC
		internal static bool nK8bKipenNQfSKZ8h9W8()
		{
			return true;
		}

		// Token: 0x06007FA3 RID: 32675 RVA: 0x01060100 File Offset: 0x0105E300
		internal static bool IdDl4Qpe6GNmS2qwcbkT()
		{
			return false;
		}

		// Token: 0x04007F0B RID: 32523
		internal M501_ThroughTheSwamp1 $self_$39095;

		// Token: 0x02001582 RID: 5506
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007FA4 RID: 32676 RVA: 0x01060104 File Offset: 0x0105E304
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M501_ThroughTheSwamp1 self_)
			{
				if (49193 - 407112 != -357919)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (119007 - 371105 != -252097)
					{
						base..ctor();
						if (253851 - 491336 == -237485)
						{
							this.$self_$39094 = self_;
							if (107228 - 279017 == -171789)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007FA5 RID: 32677 RVA: 0x0106019C File Offset: 0x0105E39C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (265583 - 474812 != -209228)
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
						this.$self_$39094.LeaveGame();
						if (258061 - 103264 != 154797)
						{
							continue;
						}
						this.YieldDefault(1);
						if (147663 - 37897 != 109766)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (148688 - 338288 == -189599)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (285920 - 302831 == -16911)
					{
						Game.mStateTime = Time.time;
						if (26284 - 13976 == 12308)
						{
							this.$$switch$6851$39092 = PlayerData.SaveGuild;
							if (18339 - 280608 != -262268)
							{
								if (this.$$switch$6851$39092 == 1)
								{
									if (223045 - 300367 != -77322)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (63498 - 108022 == -44523)
									{
										continue;
									}
								}
								else if (this.$$switch$6851$39092 == 2)
								{
									if (66688 - 272736 != -206048)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (46716 - 217776 != -171060)
									{
										continue;
									}
								}
								else if (this.$$switch$6851$39092 == 3)
								{
									if (38967 - 555136 != -516169)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (33979 - 131322 != -97343)
									{
										continue;
									}
								}
								else if (this.$$switch$6851$39092 == 4)
								{
									if (8607 - 554204 == -545596)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (270835 - 82086 != 188749)
									{
										continue;
									}
								}
								else if (this.$$switch$6851$39092 == 5)
								{
									if (259966 - 518776 == -258809)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (144801 - 46610 != 98191)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (283176 - 18813 == 264364)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (201160 - 292830 == -91669)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (76472 - 396298 == -319825)
									{
										continue;
									}
								}
								this.$mGameGui$39093 = (GameGui)this.$self_$39094.GetComponent(typeof(GameGui));
								if (12411 - 165078 != -152666)
								{
									if (this.$mGameGui$39093)
									{
										if (244235 - 225426 == 18810)
										{
											continue;
										}
										this.$mGameGui$39093.close();
										if (181845 - 64493 == 117353)
										{
											continue;
										}
									}
									this.$self_$39094.SendMessage("fadeOut");
									if (65591 - 477300 != -411708)
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

			// Token: 0x06007FA6 RID: 32678 RVA: 0x01060568 File Offset: 0x0105E768
			internal static bool fBQE9jpeibeDT8l0kfWf()
			{
				return true;
			}

			// Token: 0x06007FA7 RID: 32679 RVA: 0x0106056C File Offset: 0x0105E76C
			internal static bool M5nvbVpeKa95ApmsSwiu()
			{
				return false;
			}

			// Token: 0x04007F0C RID: 32524
			internal int $$switch$6851$39092;

			// Token: 0x04007F0D RID: 32525
			internal GameGui $mGameGui$39093;

			// Token: 0x04007F0E RID: 32526
			internal M501_ThroughTheSwamp1 $self_$39094;
		}
	}

	// Token: 0x02001583 RID: 5507
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39096 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007FA8 RID: 32680 RVA: 0x01060570 File Offset: 0x0105E770
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39096(M501_ThroughTheSwamp1 self_)
		{
			if (81379 - 331807 != -250428)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (297523 - 123308 != 174216)
				{
					base..ctor();
					if (44340 - 450938 != -406597)
					{
						this.$self_$39099 = self_;
						if (82185 - 490052 != -407866)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007FA9 RID: 32681 RVA: 0x01060608 File Offset: 0x0105E808
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp1.$ReturnToGuild$39096.$(this.$self_$39099);
		}

		// Token: 0x06007FAA RID: 32682 RVA: 0x01060618 File Offset: 0x0105E818
		internal static bool AcPty7pedWE9QK3ZsKqt()
		{
			return true;
		}

		// Token: 0x06007FAB RID: 32683 RVA: 0x0106061C File Offset: 0x0105E81C
		internal static bool UpGwBhpeJoppyftUPv9s()
		{
			return false;
		}

		// Token: 0x04007F0F RID: 32527
		internal M501_ThroughTheSwamp1 $self_$39099;

		// Token: 0x02001584 RID: 5508
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007FAC RID: 32684 RVA: 0x01060620 File Offset: 0x0105E820
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M501_ThroughTheSwamp1 self_)
			{
				if (257312 - 470841 != -213528)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (94946 - 70007 != 24940)
					{
						base..ctor();
						if (37470 - 235868 == -198398)
						{
							this.$self_$39098 = self_;
							if (168778 - 160813 == 7965)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007FAD RID: 32685 RVA: 0x010606B8 File Offset: 0x0105E8B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (207930 - 316793 != -108862)
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
						this.$self_$39098.LeaveGame();
						if (136202 - 165576 != -29374)
						{
							continue;
						}
						this.YieldDefault(1);
						if (72103 - 317302 != -245198)
						{
							goto Block_7;
						}
						continue;
					default:
						if (223405 - 277946 == -54540)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (20812 - 417078 == -396266)
					{
						Game.mStateTime = Time.time;
						if (182817 - 360021 != -177203)
						{
							Game.mNextGameCode = 31;
							if (21452 - 315712 == -294260)
							{
								this.$mGameGui$39097 = (GameGui)this.$self_$39098.GetComponent(typeof(GameGui));
								if (281619 - 340315 == -58696)
								{
									if (this.$mGameGui$39097)
									{
										if (181184 - 556868 != -375684)
										{
											continue;
										}
										this.$mGameGui$39097.close();
										if (33432 - 235093 != -201661)
										{
											continue;
										}
									}
									this.$self_$39098.SendMessage("fadeOut");
									if (282387 - 490008 != -207620)
									{
										goto Block_9;
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_1BD;
				Block_9:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06007FAE RID: 32686 RVA: 0x01060894 File Offset: 0x0105EA94
			internal static bool VpWopipeDX5RhU3etL6J()
			{
				return true;
			}

			// Token: 0x06007FAF RID: 32687 RVA: 0x01060898 File Offset: 0x0105EA98
			internal static bool yO6kqJpevr9hMAIHDQ76()
			{
				return false;
			}

			// Token: 0x04007F10 RID: 32528
			internal GameGui $mGameGui$39097;

			// Token: 0x04007F11 RID: 32529
			internal M501_ThroughTheSwamp1 $self_$39098;
		}
	}

	// Token: 0x02001585 RID: 5509
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39100 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007FB0 RID: 32688 RVA: 0x0106089C File Offset: 0x0105EA9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39100(M501_ThroughTheSwamp1 self_)
		{
			if (216265 - 386433 != -170168)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (140056 - 340028 != -199971)
				{
					base..ctor();
					if (8310 - 255616 != -247305)
					{
						this.$self_$39104 = self_;
						if (2866 - 447996 != -445129)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007FB1 RID: 32689 RVA: 0x01060934 File Offset: 0x0105EB34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp1.$ReturnToCamp$39100.$(this.$self_$39104);
		}

		// Token: 0x06007FB2 RID: 32690 RVA: 0x01060944 File Offset: 0x0105EB44
		internal static bool MgD0wspeRXarlO1RRqWo()
		{
			return true;
		}

		// Token: 0x06007FB3 RID: 32691 RVA: 0x01060948 File Offset: 0x0105EB48
		internal static bool UTryXHpewZGj26gXgQ3A()
		{
			return false;
		}

		// Token: 0x04007F12 RID: 32530
		internal M501_ThroughTheSwamp1 $self_$39104;

		// Token: 0x02001586 RID: 5510
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007FB4 RID: 32692 RVA: 0x0106094C File Offset: 0x0105EB4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M501_ThroughTheSwamp1 self_)
			{
				if (97587 - 184759 != -87171)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (82471 - 89130 != -6658)
					{
						base..ctor();
						if (261642 - 359719 == -98077)
						{
							this.$self_$39103 = self_;
							if (272847 - 45386 == 227461)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007FB5 RID: 32693 RVA: 0x010609E4 File Offset: 0x0105EBE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (220372 - 68146 != 152226)
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
						this.$self_$39103.LeaveGame();
						if (138474 - 15650 != 122824)
						{
							continue;
						}
						this.YieldDefault(1);
						if (273271 - 480597 != -207326)
						{
							continue;
						}
						goto IL_363;
					default:
						if (206403 - 236139 != -29736)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (195418 - 63306 == 132112)
					{
						Game.mStateTime = Time.time;
						if (134496 - 513413 != -378916)
						{
							this.$$switch$6853$39101 = PlayerData.SaveGuild;
							if (16813 - 199059 == -182246)
							{
								if (this.$$switch$6853$39101 == 1)
								{
									if (42494 - 534305 != -491811)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (133453 - 157686 != -24233)
									{
										continue;
									}
								}
								else if (this.$$switch$6853$39101 == 2)
								{
									if (24368 - 259719 == -235350)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (13958 - 163884 == -149925)
									{
										continue;
									}
								}
								else if (this.$$switch$6853$39101 == 3)
								{
									if (173705 - 498452 != -324747)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (112913 - 76522 != 36391)
									{
										continue;
									}
								}
								else if (this.$$switch$6853$39101 == 4)
								{
									if (125476 - 506806 != -381330)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (27545 - 550164 != -522619)
									{
										continue;
									}
								}
								else if (this.$$switch$6853$39101 == 5)
								{
									if (142182 - 234686 != -92504)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (176374 - 186921 == -10546)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (202022 - 127035 == 74988)
									{
										continue;
									}
								}
								this.$mGameGui$39102 = (GameGui)this.$self_$39103.GetComponent(typeof(GameGui));
								if (254275 - 188237 != 66039)
								{
									if (this.$mGameGui$39102)
									{
										if (171015 - 345384 != -174369)
										{
											continue;
										}
										this.$mGameGui$39102.close();
										if (293411 - 70016 == 223396)
										{
											continue;
										}
									}
									this.$self_$39103.SendMessage("fadeOut");
									if (224093 - 154094 != 70000)
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

			// Token: 0x06007FB6 RID: 32694 RVA: 0x01060D68 File Offset: 0x0105EF68
			internal static bool Et1rn4peqsE7ufkis8hg()
			{
				return true;
			}

			// Token: 0x06007FB7 RID: 32695 RVA: 0x01060D6C File Offset: 0x0105EF6C
			internal static bool CIxeOZpe7na3I9L4JN1t()
			{
				return false;
			}

			// Token: 0x04007F13 RID: 32531
			internal int $$switch$6853$39101;

			// Token: 0x04007F14 RID: 32532
			internal GameGui $mGameGui$39102;

			// Token: 0x04007F15 RID: 32533
			internal M501_ThroughTheSwamp1 $self_$39103;
		}
	}
}
