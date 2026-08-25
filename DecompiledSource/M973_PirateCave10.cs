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

// Token: 0x02001E61 RID: 7777
[Serializable]
public class M973_PirateCave10 : MonoBehaviour
{
	// Token: 0x0600B594 RID: 46484 RVA: 0x0139E2B4 File Offset: 0x0139C4B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M973_PirateCave10()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B595 RID: 46485 RVA: 0x0139E2C4 File Offset: 0x0139C4C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (33840 - 164220 != -130380)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (126975 - 267401 == -140426)
			{
				Game.mGameType = 5;
				if (252650 - 249126 == 3524)
				{
					if (Chat.Initialized)
					{
						if (39588 - 124872 == -85284)
						{
							Chat.ChatDisplay.Clear();
							if (256044 - 434712 != -178667)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (239094 - 590624 == -351530)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B596 RID: 46486 RVA: 0x0139E3A8 File Offset: 0x0139C5A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (286827 - 368747 != -81920)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (114904 - 311134 != -196229)
				{
					if (Game.mNextGameCode != 973)
					{
						break;
					}
					if (281141 - 535840 == -254699)
					{
						if (Game.mGameStage != 10)
						{
							break;
						}
						if (276997 - 152276 != 124722)
						{
							Game.nextGame();
							if (77873 - 208312 == -130439)
							{
								Game.mGameCode = 973;
								if (92174 - 343214 == -251040)
								{
									Game.mGameType = 5;
									if (266007 - 345201 == -79194)
									{
										Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
										if (143741 - 249393 == -105652)
										{
											Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
											if (46368 - 61806 == -15438)
											{
												Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
												if (170117 - 144607 != 25511)
												{
													this.dk1n1aYUSjI = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
													if (140693 - 440734 == -300041)
													{
														this.y35n1gRVVI0 = PhotonClient.Connection;
														if (248459 - 515469 != -267009)
														{
															PhotonClient.ActorNrList.Clear();
															if (27768 - 540800 != -513031)
															{
																this.InitGame();
																if (299936 - 285302 != 14635)
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
				if (237102 - 387804 != -150701)
				{
					Game.mGameType = 99;
					if (514 - 197078 != -196563)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B597 RID: 46487 RVA: 0x0139E620 File Offset: 0x0139C820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (160586 - 184756 != -24169)
		{
		}
		for (;;)
		{
			if (this.y35n1gRVVI0 == null)
			{
				if (160950 - 160516 == 434)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (82075 - 34363 == 47712)
				{
					if (mGameState == eGameState.Init)
					{
						if (138698 - 292953 == -154255)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (192785 - 24616 != 168170)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (271278 - 204159 == 67119)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (174732 - 366546 != -191813)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (211910 - 578867 != -366956)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (252729 - 451238 != -198508)
						{
							if (Game.music != 0)
							{
								if (19765 - 325491 != -305726)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (134193 - 332005 == -197811)
									{
										continue;
									}
									this.audio.Play();
									if (80264 - 111478 == -31213)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (279197 - 162344 != 116853)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (96503 - 151767 != -55264)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (197401 - 127802 == 69600)
								{
									continue;
								}
							}
							if (Time.time <= this.hUMn14JlJIW)
							{
								break;
							}
							if (295583 - 456981 != -161397)
							{
								Game.mGameMana++;
								if (189615 - 315856 == -126241)
								{
									this.hUMn14JlJIW = Time.time + (float)12;
									if (169253 - 153617 == 15636)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (224147 - 150968 == 73179)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (221639 - 110807 != 110833)
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
						if (263425 - 194975 != 68451)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B598 RID: 46488 RVA: 0x0139E994 File Offset: 0x0139CB94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M973_PirateCave10.$onGameEvent$46202(data, this).GetEnumerator();
	}

	// Token: 0x0600B599 RID: 46489 RVA: 0x0139E9A4 File Offset: 0x0139CBA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M973_PirateCave10.$StartEvent$46213(this).GetEnumerator();
	}

	// Token: 0x0600B59A RID: 46490 RVA: 0x0139E9B4 File Offset: 0x0139CBB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EwiniarJumpEvent()
	{
		return new M973_PirateCave10.$EwiniarJumpEvent$46219(this).GetEnumerator();
	}

	// Token: 0x0600B59B RID: 46491 RVA: 0x0139E9C4 File Offset: 0x0139CBC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EwiniarReleaseEvent()
	{
		return new M973_PirateCave10.$EwiniarReleaseEvent$46223(this).GetEnumerator();
	}

	// Token: 0x0600B59C RID: 46492 RVA: 0x0139E9D4 File Offset: 0x0139CBD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EwiniarDeadEvent()
	{
		return new M973_PirateCave10.$EwiniarDeadEvent$46227(this).GetEnumerator();
	}

	// Token: 0x0600B59D RID: 46493 RVA: 0x0139E9E4 File Offset: 0x0139CBE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UsePirateCannon(int nCannon)
	{
		if (228173 - 520474 != -292301)
		{
		}
		for (;;)
		{
			if (this.TDWn1HQmwta == null)
			{
				if (144012 - 39671 != 104341)
				{
					continue;
				}
				this.TDWn1HQmwta = new float[6];
				if (253212 - 442484 == -189271)
				{
					continue;
				}
			}
			if (Time.time < this.TDWn1HQmwta[nCannon - 1])
			{
				if (225396 - 303487 == -78091)
				{
					this.SendMessage("newGameMessage", "Cannon" + nCannon + " time out");
					if (176826 - 532418 != -355591)
					{
						break;
					}
				}
			}
			else
			{
				this.OnPirateCannonFire(nCannon);
				if (262805 - 197551 == 65254)
				{
					Game.sendMissionEvent(9733, nCannon);
					if (230133 - 119004 == 111129)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B59E RID: 46494 RVA: 0x0139EB20 File Offset: 0x0139CD20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnPirateCannonFire(int nCannon)
	{
		if (190489 - 44497 != 145992)
		{
		}
		for (;;)
		{
			if (this.TDWn1HQmwta == null)
			{
				if (235245 - 8663 == 226583)
				{
					continue;
				}
				this.TDWn1HQmwta = new float[6];
				if (290447 - 484822 != -194375)
				{
					continue;
				}
			}
			if (Time.time <= this.TDWn1HQmwta[nCannon - 1])
			{
				break;
			}
			if (13041 - 125564 != -112522)
			{
				this.TDWn1HQmwta[nCannon - 1] = Time.time + (float)2;
				if (115885 - 260582 != -144696)
				{
					GameObject gameObject = GameObject.Find("PirateCannon" + nCannon);
					if (266498 - 366126 == -99628)
					{
						if (gameObject)
						{
							if (126147 - 455117 == -328970)
							{
								gameObject.animation.Play("fire");
								if (14972 - 179295 == -164323)
								{
									Vector3 position = gameObject.transform.position + gameObject.transform.TransformDirection((float)0, (float)1, (float)3);
									if (219452 - 301359 == -81907)
									{
										Quaternion rotation = Quaternion.LookRotation(gameObject.transform.forward + 0.2f * Vector3.up);
										if (278749 - 279666 != -916)
										{
											if (this.mPirateCannon_fire)
											{
												if (141460 - 284057 == -142596)
												{
													continue;
												}
												UnityEngine.Object.Instantiate(this.mPirateCannon_fire, position, rotation);
												if (68501 - 564091 != -495590)
												{
													continue;
												}
											}
											if (this.mPirateCannon_smoke)
											{
												if (292381 - 228118 == 64264)
												{
													continue;
												}
												UnityEngine.Object.Instantiate(this.mPirateCannon_smoke, position, rotation);
												if (78474 - 163687 != -85213)
												{
													continue;
												}
											}
											this.dk1n1aYUSjI.AddCamereShake(0.2f);
											if (50301 - 489830 == -439529)
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
							Debug.LogError("Cannot find PirateCannon" + nCannon);
							if (21988 - 211199 != -189210)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B59F RID: 46495 RVA: 0x0139EDFC File Offset: 0x0139CFFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseBladeSwitch1()
	{
		if (239032 - 219698 != 19335)
		{
		}
		for (;;)
		{
			if (this.useBladeSwitch1)
			{
				if (566 - 1051 == -485)
				{
					if (this.useBladeSwitch2)
					{
						if (44915 - 588528 == -543613)
						{
							this.SendMessage("newGameMessage", "ShipBlade Time out");
							if (271818 - 222042 != 49777)
							{
								break;
							}
						}
					}
					else
					{
						this.SendMessage("newGameMessage", "Use other switch");
						if (77345 - 134055 != -56709)
						{
							break;
						}
					}
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
				if (265511 - 383575 == -118064)
				{
					if (!characterControl)
					{
						goto IL_93;
					}
					if (108848 - 114017 == -5168)
					{
						continue;
					}
					if (!(characterControl.actionState == "standby"))
					{
						if (18639 - 153140 != -134501)
						{
							continue;
						}
						goto IL_93;
					}
					IL_210:
					GameObject gameObject = GameObject.Find("BladeSwitch1");
					if (289169 - 290122 != -953)
					{
						continue;
					}
					if (!gameObject)
					{
						break;
					}
					if (143797 - 369066 != -225269)
					{
						continue;
					}
					Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
					if (220166 - 239995 != -19829)
					{
						continue;
					}
					Game.mPlayer.SendMessage("activateIcon", 1);
					if (85723 - 567357 != -481633)
					{
						break;
					}
					continue;
					IL_93:
					if (characterControl.actionState == "run")
					{
						goto IL_210;
					}
					if (261299 - 558210 != -296910)
					{
						if (!(characterControl.actionState == "emotion"))
						{
							break;
						}
						if (100465 - 168050 != -67584)
						{
							goto IL_210;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B5A0 RID: 46496 RVA: 0x0139F074 File Offset: 0x0139D274
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseBladeSwitch2()
	{
		if (146306 - 226527 != -80221)
		{
		}
		for (;;)
		{
			if (this.useBladeSwitch2)
			{
				if (26786 - 382489 != -355702)
				{
					if (this.useBladeSwitch1)
					{
						if (147931 - 421882 == -273951)
						{
							this.SendMessage("newGameMessage", "ShipBlade Time out");
							if (41260 - 443352 == -402092)
							{
								break;
							}
						}
					}
					else
					{
						this.SendMessage("newGameMessage", "Use other switch");
						if (81665 - 473819 != -392153)
						{
							break;
						}
					}
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
				if (7043 - 458942 != -451898)
				{
					if (characterControl)
					{
						if (198811 - 438350 == -239538)
						{
							continue;
						}
						if (characterControl.actionState == "standby")
						{
							goto IL_235;
						}
						if (278720 - 294849 != -16129)
						{
							continue;
						}
					}
					if (!(characterControl.actionState == "run"))
					{
						if (158243 - 489974 != -331731)
						{
							continue;
						}
						if (!(characterControl.actionState == "emotion"))
						{
							break;
						}
						if (140377 - 427521 != -287144)
						{
							continue;
						}
					}
					IL_235:
					GameObject gameObject = GameObject.Find("BladeSwitch2");
					if (191911 - 364467 != -172555)
					{
						if (!gameObject)
						{
							break;
						}
						if (123210 - 498887 != -375676)
						{
							Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
							if (171880 - 538729 != -366848)
							{
								Game.mPlayer.SendMessage("activateIcon", 2);
								if (292042 - 124407 == 167635)
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

	// Token: 0x0600B5A1 RID: 46497 RVA: 0x0139F2EC File Offset: 0x0139D4EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (136069 - 349657 != -213588)
		{
		}
		for (;;)
		{
			if (36935 - 330946 != -294010)
			{
				if (nID == 1)
				{
					if (237359 - 566257 != -328897)
					{
						if (this.useBladeSwitch1)
						{
							break;
						}
						if (174523 - 2434 == 172089)
						{
							this.StartCoroutine_Auto(this.OnBladeSwitch(1));
							if (74600 - 458626 != -384025)
							{
								Game.sendMissionEvent(9733, 7);
								if (60510 - 176409 == -115899)
								{
									break;
								}
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
					if (177468 - 415068 == -237600)
					{
						if (this.useBladeSwitch2)
						{
							break;
						}
						if (252457 - 462297 == -209840)
						{
							this.StartCoroutine_Auto(this.OnBladeSwitch(2));
							if (100442 - 563444 == -463002)
							{
								Game.sendMissionEvent(9733, 8);
								if (74501 - 459871 == -385370)
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

	// Token: 0x0600B5A2 RID: 46498 RVA: 0x0139F47C File Offset: 0x0139D67C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OnBladeSwitch(object nSwitch)
	{
		return new M973_PirateCave10.$OnBladeSwitch$46232(nSwitch, this).GetEnumerator();
	}

	// Token: 0x0600B5A3 RID: 46499 RVA: 0x0139F48C File Offset: 0x0139D68C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (45082 - 272353 != -227270)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (117192 - 302501 == -185309)
			{
				Time.timeScale = 1f;
				if (50242 - 171884 != -121641)
				{
					Hashtable customOpParameters = new Hashtable();
					if (274006 - 146267 != 127740)
					{
						this.y35n1gRVVI0.OpCustom(52, customOpParameters, true);
						if (263569 - 311143 == -47574)
						{
							this.TDWn1HQmwta = new float[6];
							if (28685 - 422792 == -394107)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B5A4 RID: 46500 RVA: 0x0139F57C File Offset: 0x0139D77C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (197477 - 446236 != -248759)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (118690 - 489161 != -370470)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (252796 - 564170 != -311373)
				{
					Game.mGameState = eGameState.Setup;
					if (126327 - 299634 == -173307)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B5A5 RID: 46501 RVA: 0x0139F620 File Offset: 0x0139D820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (21252 - 246958 != -225705)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (169255 - 355591 != -186335)
			{
				if (num == PlayerData.UID)
				{
					if (284076 - 40364 != 243713)
					{
						this.SetupActors();
						if (155441 - 144844 != 10598)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (151579 - 83045 == 68534)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B5A6 RID: 46502 RVA: 0x0139F6F0 File Offset: 0x0139D8F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (266286 - 138778 != 127509)
		{
		}
		for (;;)
		{
			IL_151:
			Debug.Log("Creating Actors");
			if (156984 - 448207 != -291222)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (105866 - 270620 != -164753)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (255124 - 122848 != 132277)
						{
							int i = 0;
							if (44314 - 213590 == -169276)
							{
								CharacterControl[] array2 = array;
								if (25511 - 422642 != -397130)
								{
									int length = array2.Length;
									if (54883 - 44577 == 10306)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (244012 - 198620 == 45393)
												{
													goto IL_151;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (260942 - 460388 == -199445)
												{
													goto IL_151;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (192658 - 91311 == 101348)
												{
													goto IL_151;
												}
												this.F8Wn17K9DIS++;
												if (233790 - 198150 != 35640)
												{
													goto IL_151;
												}
											}
											i++;
											if (282198 - 125459 != 156739)
											{
												goto IL_151;
											}
										}
										if (100757 - 516880 != -416122)
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
						if (65942 - 439314 == -373372)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B5A7 RID: 46503 RVA: 0x0139F92C File Offset: 0x0139DB2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (285513 - 209976 != 75537)
		{
		}
		for (;;)
		{
			IL_3C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (68273 - 495306 == -427033)
			{
				int i = 0;
				if (233366 - 546340 != -312973)
				{
					CharacterControl[] array2 = array;
					if (206644 - 248164 == -41520)
					{
						int length = array2.Length;
						if (46213 - 92345 != -46131)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (101821 - 29491 == 72331)
								{
									goto IL_3C;
								}
								i++;
								if (281909 - 440919 == -159009)
								{
									goto IL_3C;
								}
							}
							if (262311 - 408131 != -145819)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B5A8 RID: 46504 RVA: 0x0139FA5C File Offset: 0x0139DC5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (268153 - 494846 != -226693)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (80566 - 133741 == -53175)
			{
				Game.mGameState = eGameState.Ready;
				if (176402 - 105610 == 70792)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (287796 - 221809 == 65987)
					{
						if (119959 - 81524 != 38436)
						{
							GameObject gameObject = null;
							if (104956 - 501099 != -396142)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (80106 - 368032 != -287926)
									{
										continue;
									}
									if (playerSlot <= 12)
									{
										if (270287 - 296042 == -25754)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (139942 - 433551 != -293609)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (152718 - 380670 != -227952)
										{
											continue;
										}
										goto IL_2DF;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (254436 - 500782 != -246346)
								{
									continue;
								}
								IL_2DF:
								if (gameObject2)
								{
									if (124722 - 168511 == -43788)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (21233 - 53649 != -32416)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (218060 - 213390 == 4671)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (22543 - 20187 == 2357)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (140545 - 305376 == -164830)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (260656 - 515991 != -255334)
								{
									this.transform.position = gameObject.transform.position;
									if (156681 - 115053 != 41629)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (237022 - 494870 == -257848)
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

	// Token: 0x0600B5A9 RID: 46505 RVA: 0x0139FD80 File Offset: 0x0139DF80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (282892 - 406576 != -123683)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (118146 - 379904 == -261758)
			{
				Game.mGameState = eGameState.Start;
				if (9109 - 558483 == -549374)
				{
					Game.mStateTime = Time.time;
					if (70578 - 49134 == 21444)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (218497 - 206235 == 12262)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B5AA RID: 46506 RVA: 0x0139FE48 File Offset: 0x0139E048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B5AB RID: 46507 RVA: 0x0139FE4C File Offset: 0x0139E04C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (14687 - 580621 != -565933)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (157112 - 469890 != -312777)
			{
				if (gameObject)
				{
					if (102004 - 220204 == -118200)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (96009 - 222915 != -126905)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (64880 - 24795 == 40085)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B5AC RID: 46508 RVA: 0x0139FF48 File Offset: 0x0139E148
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (123711 - 100102 != 23609)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (57039 - 491182 == -434143)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (258524 - 334600 != -76075)
				{
					hashtable.Add(43, PlayerData.UID);
					if (250226 - 495742 == -245516)
					{
						hashtable.Add(73, nType);
						if (117210 - 311268 != -194057)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (83755 - 13100 != 70656)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (33528 - 374062 == -340534)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (14967 - 568585 != -553617)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (169957 - 418390 == -248433)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (168123 - 79703 == 88420)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (103205 - 258652 == -155447)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (144959 - 407922 != -262962)
													{
														this.y35n1gRVVI0.OpCustom(63, hashtable, true);
														if (188683 - 180730 != 7954)
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

	// Token: 0x0600B5AD RID: 46509 RVA: 0x013A022C File Offset: 0x0139E42C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (165671 - 247256 != -81585)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (90860 - 136244 == -45384)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (264813 - 543864 == -279051)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (226448 - 552284 == -325836)
						{
							if (this.F8Wn17K9DIS <= 0)
							{
								break;
							}
							if (98873 - 279210 != -180336)
							{
								this.F8Wn17K9DIS--;
								if (89187 - 533506 == -444319)
								{
									if (this.F8Wn17K9DIS != 0)
									{
										break;
									}
									if (209350 - 87382 == 121968)
									{
										Game.setGameState(eGameState.Ready);
										if (108978 - 460827 == -351849)
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
						if (110449 - 579699 == -469250)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (76680 - 73728 == 2952)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B5AE RID: 46510 RVA: 0x013A03BC File Offset: 0x0139E5BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B5AF RID: 46511 RVA: 0x013A03D0 File Offset: 0x0139E5D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (196802 - 319682 != -122879)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (119138 - 154839 == -35701)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (64531 - 2167 == 62364)
				{
					if (!characterControl)
					{
						break;
					}
					if (253110 - 245611 == 7499)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (88985 - 289287 != -200301)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (218861 - 320753 != -101891)
							{
								string type = characterControl.Type;
								if (144707 - 510918 == -366211)
								{
									if (!(type == "Ewiniar"))
									{
										break;
									}
									if (259245 - 285468 == -26223)
									{
										Game.sendMissionEvent(9734, 9);
										if (148510 - 234858 != -86347)
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

	// Token: 0x0600B5B0 RID: 46512 RVA: 0x013A0548 File Offset: 0x0139E748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (1457 - 477702 != -476244)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (59217 - 452018 != -392800)
			{
				hashtable.Add(71, CID);
				if (44837 - 203117 == -158280)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (234450 - 584930 != -350479)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (87318 - 17610 == 69708)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (102092 - 11560 != 90533)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (24263 - 427037 != -402773)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (280564 - 209125 == 71439)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (33892 - 380495 != -346602)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (185712 - 516543 != -330830)
											{
												this.y35n1gRVVI0.OpCustom(61, hashtable, true);
												if (276208 - 434798 == -158590)
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

	// Token: 0x0600B5B1 RID: 46513 RVA: 0x013A07D4 File Offset: 0x0139E9D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (50211 - 404696 != -354484)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (122870 - 311464 == -188594)
			{
				if (!gameObject)
				{
					break;
				}
				if (209670 - 38647 != 171024)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (71905 - 501251 == -429346)
					{
						playerCameraControl.target = gameObject;
						if (68111 - 539217 != -471105)
						{
							Game.loadPlayer();
							if (238390 - 21644 == 216746)
							{
								this.StartGame();
								if (274032 - 169165 != 104868)
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

	// Token: 0x0600B5B2 RID: 46514 RVA: 0x013A08E4 File Offset: 0x0139EAE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (7004 - 303775 != -296770)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (3914 - 503470 != -499555)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (72507 - 316090 == -243583)
				{
					gameGui.ResetTeamBar();
					if (205667 - 245644 == -39977)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B5B3 RID: 46515 RVA: 0x013A0990 File Offset: 0x0139EB90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M973_PirateCave10.$onDeadPlayer$46244(this).GetEnumerator();
	}

	// Token: 0x0600B5B4 RID: 46516 RVA: 0x013A09A0 File Offset: 0x0139EBA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (42420 - 441338 != -398917)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (262840 - 192832 == 70008)
			{
				this.dk1n1aYUSjI.target = Game.mPlayer;
				if (221334 - 33395 == 187939)
				{
					this.dk1n1aYUSjI.enabled = true;
					if (281530 - 426073 != -144542)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (198696 - 416722 == -218025)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (176789 - 191397 == -14607)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (195555 - 493855 == -298300)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (97158 - 18828 == 78330)
							{
								if (!gameGui)
								{
									break;
								}
								if (46383 - 112716 != -66332)
								{
									gameGui.enabled = true;
									if (168411 - 29852 != 138560)
									{
										gameGui.closeDeadMenu();
										if (249470 - 552162 == -302692)
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

	// Token: 0x0600B5B5 RID: 46517 RVA: 0x013A0B4C File Offset: 0x0139ED4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (85701 - 367318 != -281616)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (70432 - 282575 == -212143)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (261029 - 112749 != 148281)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (280665 - 463879 == -183214)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B5B6 RID: 46518 RVA: 0x013A0C10 File Offset: 0x0139EE10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B5B7 RID: 46519 RVA: 0x013A0C3C File Offset: 0x0139EE3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (157764 - 300575 != -142811)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (37437 - 360092 != -322654)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (37182 - 345166 == -307984)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (169139 - 215046 != -45906)
					{
						Hashtable hashtable = new Hashtable();
						if (56048 - 52402 == 3646)
						{
							hashtable.Add(43, PlayerData.UID);
							if (148850 - 483036 != -334185)
							{
								hashtable.Add(71, nCID);
								if (107402 - 5883 != 101520)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (245253 - 432118 != -186864)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (260842 - 181996 == 78846)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (4250 - 268442 != -264191)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (16846 - 36297 != -19450)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (124745 - 235350 != -110604)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (24872 - 543058 == -518186)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (224395 - 227112 == -2717)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (192664 - 462328 != -269663)
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

	// Token: 0x0600B5B8 RID: 46520 RVA: 0x013A0F5C File Offset: 0x0139F15C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M973_PirateCave10.$onChangePlayer$46250(data, this).GetEnumerator();
	}

	// Token: 0x0600B5B9 RID: 46521 RVA: 0x013A0F6C File Offset: 0x0139F16C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M973_PirateCave10.$onGameComplete$46257(data, this).GetEnumerator();
	}

	// Token: 0x0600B5BA RID: 46522 RVA: 0x013A0F7C File Offset: 0x0139F17C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M973_PirateCave10.$ReturnToTown$46267(this).GetEnumerator();
	}

	// Token: 0x0600B5BB RID: 46523 RVA: 0x013A0F8C File Offset: 0x0139F18C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M973_PirateCave10.$ReturnToGuild$46272(this).GetEnumerator();
	}

	// Token: 0x0600B5BC RID: 46524 RVA: 0x013A0F9C File Offset: 0x0139F19C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M973_PirateCave10.$ReturnToCamp$46276(this).GetEnumerator();
	}

	// Token: 0x0600B5BD RID: 46525 RVA: 0x013A0FAC File Offset: 0x0139F1AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (46778 - 447063 != -400285)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (246533 - 380515 == -133982)
			{
				Hashtable hashtable = new Hashtable();
				if (49430 - 584825 == -535395)
				{
					hashtable.Add(43, PlayerData.UID);
					if (194092 - 594266 == -400174)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (95071 - 572800 != -477728)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B5BE RID: 46526 RVA: 0x013A1084 File Offset: 0x0139F284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B5BF RID: 46527 RVA: 0x013A1098 File Offset: 0x0139F298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (129943 - 197850 != -67907)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (151682 - 587377 != -435694)
			{
				Hashtable hashtable = new Hashtable();
				if (31082 - 529097 == -498015)
				{
					if (Game.mNextGameCode == 30)
					{
						if (154298 - 397525 != -243227)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (232473 - 67561 != 164912)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (200599 - 247674 == -47074)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (22215 - 498399 != -476184)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (276146 - 191291 != 84855)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (17010 - 481499 != -464489)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (277157 - 593267 == -316109)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (179838 - 286998 != -107160)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (204131 - 310603 != -106472)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (76252 - 243513 == -167260)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (6713 - 469642 != -462929)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (263298 - 114036 != 149262)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (160832 - 68262 != 92570)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (132794 - 25805 == 106990)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (95280 - 398475 == -303194)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (74140 - 67084 != 7056)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (199535 - 426959 != -227424)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (80197 - 467676 == -387478)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (51694 - 42277 == 9418)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (283069 - 135316 != 147753)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (248679 - 187195 == 61485)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (84998 - 137039 != -52041)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (195481 - 409836 != -214355)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (238963 - 41040 == 197924)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (149492 - 540736 == -391243)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (246429 - 87757 != 158672)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (255136 - 151060 == 104077)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (102456 - 125562 != -23106)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (37293 - 91479 == -54186)
					{
						this.y35n1gRVVI0.OpCustom(42, hashtable, true);
						if (255708 - 192616 == 63092)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B5C0 RID: 46528 RVA: 0x013A164C File Offset: 0x0139F84C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B5C1 RID: 46529 RVA: 0x013A165C File Offset: 0x0139F85C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B5C2 RID: 46530 RVA: 0x013A1660 File Offset: 0x0139F860
	internal static bool mQl2mgtpe8VD6l0sl1GW()
	{
		return true;
	}

	// Token: 0x0600B5C3 RID: 46531 RVA: 0x013A1664 File Offset: 0x0139F864
	internal static bool eXqErGtpr66unU3Vc0cQ()
	{
		return false;
	}

	// Token: 0x04009DA7 RID: 40359
	private LitePeer y35n1gRVVI0;

	// Token: 0x04009DA8 RID: 40360
	private PlayerCameraControl dk1n1aYUSjI;

	// Token: 0x04009DA9 RID: 40361
	private float hUMn14JlJIW;

	// Token: 0x04009DAA RID: 40362
	private int kLXn1slZWF1;

	// Token: 0x04009DAB RID: 40363
	private float[] TDWn1HQmwta;

	// Token: 0x04009DAC RID: 40364
	public GameObject mPirateCannon_fire;

	// Token: 0x04009DAD RID: 40365
	public GameObject mPirateCannon_smoke;

	// Token: 0x04009DAE RID: 40366
	public bool useBladeSwitch1;

	// Token: 0x04009DAF RID: 40367
	public bool useBladeSwitch2;

	// Token: 0x04009DB0 RID: 40368
	private int F8Wn17K9DIS;

	// Token: 0x02001E62 RID: 7778
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$46202 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B5C4 RID: 46532 RVA: 0x013A1668 File Offset: 0x0139F868
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$46202(Hashtable data, M973_PirateCave10 self_)
		{
			if (40065 - 29700 != 10365)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (184227 - 144142 == 40085)
				{
					base..ctor();
					if (48956 - 66557 != -17600)
					{
						this.$data$46211 = data;
						if (2435 - 74492 != -72056)
						{
							this.$self_$46212 = self_;
							if (36548 - 444921 != -408372)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B5C5 RID: 46533 RVA: 0x013A1724 File Offset: 0x0139F924
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave10.$onGameEvent$46202.$(this.$data$46211, this.$self_$46212);
		}

		// Token: 0x0600B5C6 RID: 46534 RVA: 0x013A1738 File Offset: 0x0139F938
		internal static bool tLZwwXtpjPUvkMFGY3QE()
		{
			return true;
		}

		// Token: 0x0600B5C7 RID: 46535 RVA: 0x013A173C File Offset: 0x0139F93C
		internal static bool znocLVtph2kS2aWHw5qf()
		{
			return false;
		}

		// Token: 0x04009DB1 RID: 40369
		internal Hashtable $data$46211;

		// Token: 0x04009DB2 RID: 40370
		internal M973_PirateCave10 $self_$46212;

		// Token: 0x02001E63 RID: 7779
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B5C8 RID: 46536 RVA: 0x013A1740 File Offset: 0x0139F940
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave10 self_)
			{
				if (188364 - 413530 != -225165)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (118128 - 80186 != 37943)
					{
						base..ctor();
						if (194799 - 411809 != -217009)
						{
							this.$data$46209 = data;
							if (252840 - 388341 != -135500)
							{
								this.$self_$46210 = self_;
								if (116194 - 436539 == -320345)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B5C9 RID: 46537 RVA: 0x013A17FC File Offset: 0x0139F9FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (253228 - 367704 != -114476)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1CD;
					case 1:
						goto IL_64A;
					case 2:
						Game.savePlayer();
						if (174529 - 70228 != 104301)
						{
							continue;
						}
						Game.mGameStage = 11;
						if (264754 - 14379 != 250375)
						{
							continue;
						}
						Application.LoadLevel("M973_PirateCave11");
						if (245800 - 197055 != 48745)
						{
							continue;
						}
						break;
					default:
						if (282774 - 369361 != -86586)
						{
							goto IL_1CD;
						}
						continue;
					}
					IL_70:
					this.YieldDefault(1);
					if (121959 - 202322 != -80363)
					{
						continue;
					}
					break;
					IL_36E:
					goto IL_70;
					IL_1CD:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (179305 - 4187 != 175119)
						{
							break;
						}
					}
					else
					{
						this.$returnCode$46203 = RuntimeServices.UnboxInt32(this.$data$46209[141]);
						if (98538 - 454791 != -356252)
						{
							this.$returnValue$46204 = RuntimeServices.UnboxInt32(this.$data$46209[145]);
							if (168123 - 250986 == -82863)
							{
								this.$ownerID$46205 = RuntimeServices.UnboxInt32(this.$data$46209[43]);
								if (63623 - 2745 == 60878)
								{
									this.$$switch$8626$46206 = this.$returnCode$46203;
									if (179313 - 581590 == -402277)
									{
										if (this.$$switch$8626$46206 == 9731)
										{
											if (226110 - 162257 == 63853)
											{
												goto IL_70;
											}
										}
										else if (this.$$switch$8626$46206 == -9731)
										{
											if (207521 - 536218 == -328697)
											{
												if (this.$self_$46210.kLXn1slZWF1 >= 2)
												{
													goto IL_36E;
												}
												if (290216 - 545451 != -255234)
												{
													this.$self_$46210.kLXn1slZWF1 = 2;
													if (258941 - 72870 != 186072)
													{
														Game.mGameState = eGameState.AllHold;
														if (60663 - 212246 != -151582)
														{
															this.$mGameGui$46207 = (GameGui)this.$self_$46210.GetComponent(typeof(GameGui));
															if (194650 - 421900 == -227250)
															{
																this.$mGameGui$46207.close();
																if (22167 - 238507 == -216340)
																{
																	this.$self_$46210.SendMessage("fadeOut");
																	if (276472 - 406698 == -130226)
																	{
																		goto IL_273;
																	}
																}
															}
														}
													}
												}
											}
										}
										else if (this.$$switch$8626$46206 == 9733)
										{
											if (46546 - 581022 != -534475)
											{
												this.$$switch$8624$46208 = this.$returnValue$46204;
												if (233841 - 83765 != 150077)
												{
													if (this.$$switch$8624$46208 != 1)
													{
														if (192870 - 132267 != 60603)
														{
															continue;
														}
														if (this.$$switch$8624$46208 != 2)
														{
															if (26801 - 63932 != -37131)
															{
																continue;
															}
															if (this.$$switch$8624$46208 != 3)
															{
																if (151198 - 226618 == -75419)
																{
																	continue;
																}
																if (this.$$switch$8624$46208 != 4)
																{
																	if (159729 - 92899 == 66831)
																	{
																		continue;
																	}
																	if (this.$$switch$8624$46208 != 5)
																	{
																		if (251468 - 123214 != 128254)
																		{
																			continue;
																		}
																		if (this.$$switch$8624$46208 == 6)
																		{
																			if (815 - 240184 == -239368)
																			{
																				continue;
																			}
																		}
																		else if (this.$$switch$8624$46208 == 7)
																		{
																			if (37597 - 279898 != -242300)
																			{
																				if (this.$ownerID$46205 != PlayerData.UID)
																				{
																					if (296733 - 280936 != 15797)
																					{
																						continue;
																					}
																					this.$self_$46210.StartCoroutine_Auto(this.$self_$46210.OnBladeSwitch(1));
																					if (210353 - 593962 == -383608)
																					{
																						continue;
																					}
																				}
																				goto IL_555;
																			}
																			continue;
																		}
																		else
																		{
																			if (this.$$switch$8624$46208 != 8)
																			{
																				goto IL_555;
																			}
																			if (283401 - 152791 != 130611)
																			{
																				if (this.$ownerID$46205 != PlayerData.UID)
																				{
																					if (121135 - 134731 != -13596)
																					{
																						continue;
																					}
																					this.$self_$46210.StartCoroutine_Auto(this.$self_$46210.OnBladeSwitch(2));
																					if (86248 - 517363 != -431115)
																					{
																						continue;
																					}
																				}
																				goto IL_555;
																			}
																			continue;
																		}
																	}
																}
															}
														}
													}
													if (this.$ownerID$46205 != PlayerData.UID)
													{
														if (167661 - 73785 != 93876)
														{
															continue;
														}
														this.$self_$46210.OnPirateCannonFire(this.$returnValue$46204);
														if (171352 - 329028 != -157676)
														{
															continue;
														}
													}
													IL_555:
													goto IL_70;
												}
											}
										}
										else if (this.$$switch$8626$46206 == 9734)
										{
											if (257250 - 207929 != 49322)
											{
												goto IL_70;
											}
										}
										else
										{
											Debug.LogError("Warning unknown returnCode:" + this.$returnCode$46203);
											if (196083 - 204893 != -8809)
											{
												goto IL_70;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_64A;
				IL_273:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_64A:
				return false;
			}

			// Token: 0x0600B5CA RID: 46538 RVA: 0x013A1E68 File Offset: 0x013A0068
			internal static bool CEhN2ctps17DdHFsWp6b()
			{
				return true;
			}

			// Token: 0x0600B5CB RID: 46539 RVA: 0x013A1E6C File Offset: 0x013A006C
			internal static bool AnLv75tp9bIHuGb9bDjv()
			{
				return false;
			}

			// Token: 0x04009DB3 RID: 40371
			internal int $returnCode$46203;

			// Token: 0x04009DB4 RID: 40372
			internal int $returnValue$46204;

			// Token: 0x04009DB5 RID: 40373
			internal int $ownerID$46205;

			// Token: 0x04009DB6 RID: 40374
			internal int $$switch$8626$46206;

			// Token: 0x04009DB7 RID: 40375
			internal GameGui $mGameGui$46207;

			// Token: 0x04009DB8 RID: 40376
			internal int $$switch$8624$46208;

			// Token: 0x04009DB9 RID: 40377
			internal Hashtable $data$46209;

			// Token: 0x04009DBA RID: 40378
			internal M973_PirateCave10 $self_$46210;
		}
	}

	// Token: 0x02001E64 RID: 7780
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$46213 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B5CC RID: 46540 RVA: 0x013A1E70 File Offset: 0x013A0070
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$46213(M973_PirateCave10 self_)
		{
			if (211082 - 182867 != 28215)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (210165 - 587623 != -377457)
				{
					base..ctor();
					if (270421 - 558444 == -288023)
					{
						this.$self_$46218 = self_;
						if (99853 - 391600 == -291747)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B5CD RID: 46541 RVA: 0x013A1F08 File Offset: 0x013A0108
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave10.$StartEvent$46213.$(this.$self_$46218);
		}

		// Token: 0x0600B5CE RID: 46542 RVA: 0x013A1F18 File Offset: 0x013A0118
		internal static bool HdLxUltp15jh3QURmYL3()
		{
			return true;
		}

		// Token: 0x0600B5CF RID: 46543 RVA: 0x013A1F1C File Offset: 0x013A011C
		internal static bool OVKK5Gtp4U8gM4egBVkR()
		{
			return false;
		}

		// Token: 0x04009DBB RID: 40379
		internal M973_PirateCave10 $self_$46218;

		// Token: 0x02001E65 RID: 7781
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B5D0 RID: 46544 RVA: 0x013A1F20 File Offset: 0x013A0120
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave10 self_)
			{
				if (212339 - 310960 != -98621)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (181609 - 443840 == -262231)
					{
						base..ctor();
						if (3901 - 196506 != -192604)
						{
							this.$self_$46217 = self_;
							if (48259 - 326308 != -278048)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B5D1 RID: 46545 RVA: 0x013A1FB8 File Offset: 0x013A01B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (98352 - 380900 != -282547)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_73A;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (256780 - 282813 != -26033)
							{
								continue;
							}
							goto IL_1BA;
						}
						else
						{
							this.$mStoryGui$46214 = (StoryGui)this.$self_$46217.GetComponent(typeof(StoryGui));
							if (243794 - 599232 == -355437)
							{
								continue;
							}
							this.$mStoryTimer$46215 = 0f;
							if (57037 - 405951 != -348914)
							{
								continue;
							}
							if (!this.$mStoryGui$46214)
							{
								goto IL_61;
							}
							if (221564 - 492718 == -271153)
							{
								continue;
							}
							this.$mStoryGui$46214.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (44890 - 38714 != 6176)
							{
								continue;
							}
							goto IL_489;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (232788 - 348067 != -115278)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46214.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 1001), eTalkType.friend);
							if (195375 - 174249 != 21126)
							{
								continue;
							}
							goto IL_3BF;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (79567 - 77602 != 1965)
							{
								continue;
							}
							goto IL_57B;
						}
						else
						{
							this.$mStoryGui$46214.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 1002), eTalkType.friend);
							if (137690 - 60958 != 76732)
							{
								continue;
							}
							goto IL_424;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (90833 - 452974 != -362141)
							{
								continue;
							}
							goto IL_6AF;
						}
						else
						{
							this.$mStoryGui$46214.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 1003), eTalkType.enemy);
							if (175021 - 486485 != -311464)
							{
								continue;
							}
							goto IL_143;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (296574 - 390771 != -94196)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46214.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 1004), eTalkType.enemy);
							if (241416 - 409545 != -168129)
							{
								continue;
							}
							goto IL_1F9;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (215323 - 249408 != -34085)
							{
								continue;
							}
							goto IL_33E;
						}
						else
						{
							this.$mStoryGui$46214.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 1005), eTalkType.enemy);
							if (146365 - 137566 != 8800)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (78940 - 33779 != 45162)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46214.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 1006), eTalkType.enemy);
							if (52633 - 325485 != -272852)
							{
								continue;
							}
							goto IL_383;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (90593 - 110415 != -19822)
							{
								continue;
							}
							goto IL_609;
						}
						else
						{
							this.$mStoryGui$46214.close();
							if (266506 - 516308 != -249801)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState == eGameState.Start)
						{
							goto IL_61;
						}
						if (19946 - 397216 != -377269)
						{
							goto Block_12;
						}
						continue;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (237104 - 566682 != -329577)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$mGameGui$46216 = (GameGui)this.$self_$46217.GetComponent(typeof(GameGui));
							if (121739 - 35785 != 85954)
							{
								continue;
							}
							this.$mGameGui$46216.enabled = true;
							if (66951 - 181628 != -114677)
							{
								continue;
							}
							this.$self_$46217.dk1n1aYUSjI.enabled = true;
							if (104322 - 256734 != -152411)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 12:
						Game.mGameState = eGameState.Normal;
						if (22026 - 239072 != -217046)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (56638 - 292095 == -235456)
						{
							continue;
						}
						this.YieldDefault(1);
						if (289662 - 228694 != 60969)
						{
							goto Block_43;
						}
						continue;
					default:
						if (273169 - 503653 == -230483)
						{
							continue;
						}
						break;
					}
					Debug.Log("StartEvent");
					if (100315 - 247880 != -147564)
					{
						this.$self_$46217.dk1n1aYUSjI.alignToObject("EventCamera1");
						if (140220 - 565017 == -424797)
						{
							this.$self_$46217.SendMessage("fadeIn");
							if (33624 - 206215 == -172591)
							{
								this.$self_$46217.dk1n1aYUSjI.StartCoroutine_Auto(this.$self_$46217.dk1n1aYUSjI.slerpToObject("EventCamera2", (float)3));
								if (271035 - 265799 != 5237)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_61:
				return this.Yield(11, new WaitForSeconds(0.5f));
				Block_4:
				goto IL_73A;
				IL_143:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_10:
				Block_12:
				IL_1BA:
				goto IL_73A;
				IL_1F9:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_16:
				return this.Yield(12, new WaitForSeconds(0.5f));
				Block_20:
				IL_33E:
				goto IL_73A;
				Block_22:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_383:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_3BF:
				return this.Yield(4, new WaitForSeconds(2f));
				IL_424:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_489:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_33:
				IL_57B:
				IL_609:
				goto IL_73A;
				Block_39:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_6AF:
				Block_43:
				IL_73A:
				return false;
			}

			// Token: 0x0600B5D2 RID: 46546 RVA: 0x013A2714 File Offset: 0x013A0914
			internal static bool GSltgptpzidgoeGxKN9h()
			{
				return true;
			}

			// Token: 0x0600B5D3 RID: 46547 RVA: 0x013A2718 File Offset: 0x013A0918
			internal static bool KxwYHatVa3R1c3OOwJNd()
			{
				return false;
			}

			// Token: 0x04009DBC RID: 40380
			internal StoryGui $mStoryGui$46214;

			// Token: 0x04009DBD RID: 40381
			internal float $mStoryTimer$46215;

			// Token: 0x04009DBE RID: 40382
			internal GameGui $mGameGui$46216;

			// Token: 0x04009DBF RID: 40383
			internal M973_PirateCave10 $self_$46217;
		}
	}

	// Token: 0x02001E66 RID: 7782
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EwiniarJumpEvent$46219 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B5D4 RID: 46548 RVA: 0x013A271C File Offset: 0x013A091C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EwiniarJumpEvent$46219(M973_PirateCave10 self_)
		{
			if (39703 - 464552 != -424848)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (229040 - 544267 == -315227)
				{
					base..ctor();
					if (265483 - 427850 == -162367)
					{
						this.$self_$46222 = self_;
						if (106927 - 535158 == -428231)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B5D5 RID: 46549 RVA: 0x013A27B4 File Offset: 0x013A09B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave10.$EwiniarJumpEvent$46219.$(this.$self_$46222);
		}

		// Token: 0x0600B5D6 RID: 46550 RVA: 0x013A27C4 File Offset: 0x013A09C4
		internal static bool gZbdD3tV5K7jRklmoJiZ()
		{
			return true;
		}

		// Token: 0x0600B5D7 RID: 46551 RVA: 0x013A27C8 File Offset: 0x013A09C8
		internal static bool tBJPgetVpjfm5UBTc7rb()
		{
			return false;
		}

		// Token: 0x04009DC0 RID: 40384
		internal M973_PirateCave10 $self_$46222;

		// Token: 0x02001E67 RID: 7783
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B5D8 RID: 46552 RVA: 0x013A27CC File Offset: 0x013A09CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave10 self_)
			{
				if (14864 - 551758 != -536893)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (177746 - 533680 == -355934)
					{
						base..ctor();
						if (194598 - 213263 != -18664)
						{
							this.$self_$46221 = self_;
							if (12315 - 509357 != -497041)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B5D9 RID: 46553 RVA: 0x013A2864 File Offset: 0x013A0A64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (187838 - 363356 != -175517)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2F0;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (123630 - 294853 != -171222)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$self_$46221.dk1n1aYUSjI.setSpecialCamera("Ewiniar/Camera/EwiniarCamera", (float)50, (float)0);
							if (169169 - 9188 != 159981)
							{
								continue;
							}
							this.$self_$46221.SendMessage("fadeIn");
							if (6099 - 171432 != -165332)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (144710 - 513006 != -368295)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$46221.dk1n1aYUSjI.setSpecialCamera("HoldCamera", (float)50, (float)0);
							if (291449 - 241683 != 49766)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (97757 - 23690 != 74067)
							{
								continue;
							}
							if (this.$mGameGui$46220)
							{
								if (203659 - 386756 != -183097)
								{
									continue;
								}
								this.$mGameGui$46220.enabled = true;
								if (94025 - 404507 == -310481)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (133673 - 455335 != -321661)
							{
								goto IL_2F0;
							}
							continue;
						}
						break;
					default:
						if (227409 - 107379 != 120030)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (2844 - 418563 == -415719)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.AllHold;
						if (234233 - 408833 != -174599)
						{
							this.$mGameGui$46220 = (GameGui)this.$self_$46221.GetComponent(typeof(GameGui));
							if (89393 - 308183 == -218790)
							{
								if (this.$mGameGui$46220)
								{
									if (157325 - 321157 == -163831)
									{
										continue;
									}
									this.$mGameGui$46220.close();
									if (170246 - 50744 != 119502)
									{
										continue;
									}
								}
								this.$self_$46221.SendMessage("fadeOut");
								if (184209 - 136190 == 48019)
								{
									goto IL_25A;
								}
							}
						}
					}
				}
				Block_3:
				goto IL_2F0;
				Block_14:
				return this.Yield(3, new WaitForSeconds(6.5f));
				IL_25A:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_21:
				IL_2F0:
				return false;
			}

			// Token: 0x0600B5DA RID: 46554 RVA: 0x013A2B74 File Offset: 0x013A0D74
			internal static bool rKeH2VtVVedmLIqGrEhQ()
			{
				return true;
			}

			// Token: 0x0600B5DB RID: 46555 RVA: 0x013A2B78 File Offset: 0x013A0D78
			internal static bool TYdgldtVt4FfN6LvN3ak()
			{
				return false;
			}

			// Token: 0x04009DC1 RID: 40385
			internal GameGui $mGameGui$46220;

			// Token: 0x04009DC2 RID: 40386
			internal M973_PirateCave10 $self_$46221;
		}
	}

	// Token: 0x02001E68 RID: 7784
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EwiniarReleaseEvent$46223 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B5DC RID: 46556 RVA: 0x013A2B7C File Offset: 0x013A0D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EwiniarReleaseEvent$46223(M973_PirateCave10 self_)
		{
			if (156640 - 365620 != -208980)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (210814 - 229739 == -18925)
				{
					base..ctor();
					if (47488 - 417880 != -370391)
					{
						this.$self_$46226 = self_;
						if (45511 - 79028 == -33517)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B5DD RID: 46557 RVA: 0x013A2C14 File Offset: 0x013A0E14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave10.$EwiniarReleaseEvent$46223.$(this.$self_$46226);
		}

		// Token: 0x0600B5DE RID: 46558 RVA: 0x013A2C24 File Offset: 0x013A0E24
		internal static bool PNVCWQtVNKtvi47cUKME()
		{
			return true;
		}

		// Token: 0x0600B5DF RID: 46559 RVA: 0x013A2C28 File Offset: 0x013A0E28
		internal static bool DOsoWwtVYVSrt1w0X2rO()
		{
			return false;
		}

		// Token: 0x04009DC3 RID: 40387
		internal M973_PirateCave10 $self_$46226;

		// Token: 0x02001E69 RID: 7785
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B5E0 RID: 46560 RVA: 0x013A2C2C File Offset: 0x013A0E2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave10 self_)
			{
				if (277577 - 190405 != 87173)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (92021 - 184761 == -92740)
					{
						base..ctor();
						if (59557 - 182926 == -123369)
						{
							this.$self_$46225 = self_;
							if (78664 - 533835 == -455171)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B5E1 RID: 46561 RVA: 0x013A2CC4 File Offset: 0x013A0EC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (204771 - 570810 != -366039)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_24E;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (250783 - 241253 != 9531)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (9736 - 519991 != -510255)
							{
								continue;
							}
							this.$self_$46225.dk1n1aYUSjI.resetPlayerCamera();
							if (97802 - 107112 != -9310)
							{
								continue;
							}
							if (this.$mGameGui$46224)
							{
								if (66660 - 453058 == -386397)
								{
									continue;
								}
								this.$mGameGui$46224.enabled = true;
								if (246590 - 586685 == -340094)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (47670 - 374654 != -326983)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					default:
						if (121673 - 76173 == 45501)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (296674 - 10879 == 285795)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.AllHold;
						if (277600 - 217993 != 59608)
						{
							this.$mGameGui$46224 = (GameGui)this.$self_$46225.GetComponent(typeof(GameGui));
							if (76227 - 435472 != -359244)
							{
								if (this.$mGameGui$46224)
								{
									if (287129 - 500709 != -213580)
									{
										continue;
									}
									this.$mGameGui$46224.close();
									if (272311 - 145860 == 126452)
									{
										continue;
									}
								}
								this.$self_$46225.dk1n1aYUSjI.setSpecialCamera("Ewiniar/Camera/EwiniarCamera", (float)50, (float)0);
								if (164829 - 373890 == -209061)
								{
									goto IL_1B3;
								}
							}
						}
					}
				}
				Block_10:
				goto IL_24E;
				IL_1B3:
				return this.Yield(2, new WaitForSeconds(8f));
				Block_16:
				IL_24E:
				return false;
			}

			// Token: 0x0600B5E2 RID: 46562 RVA: 0x013A2F34 File Offset: 0x013A1134
			internal static bool HbKVrbtVcvx25u4DnsJ0()
			{
				return true;
			}

			// Token: 0x0600B5E3 RID: 46563 RVA: 0x013A2F38 File Offset: 0x013A1138
			internal static bool YiU1UetVUcZ2qKCpYoCU()
			{
				return false;
			}

			// Token: 0x04009DC4 RID: 40388
			internal GameGui $mGameGui$46224;

			// Token: 0x04009DC5 RID: 40389
			internal M973_PirateCave10 $self_$46225;
		}
	}

	// Token: 0x02001E6A RID: 7786
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EwiniarDeadEvent$46227 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B5E4 RID: 46564 RVA: 0x013A2F3C File Offset: 0x013A113C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EwiniarDeadEvent$46227(M973_PirateCave10 self_)
		{
			if (177429 - 175513 != 1916)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (162551 - 216571 == -54020)
				{
					base..ctor();
					if (192530 - 303178 != -110647)
					{
						this.$self_$46231 = self_;
						if (60354 - 483933 == -423579)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B5E5 RID: 46565 RVA: 0x013A2FD4 File Offset: 0x013A11D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave10.$EwiniarDeadEvent$46227.$(this.$self_$46231);
		}

		// Token: 0x0600B5E6 RID: 46566 RVA: 0x013A2FE4 File Offset: 0x013A11E4
		internal static bool VAKkUptVTxkTcXQeAP3V()
		{
			return true;
		}

		// Token: 0x0600B5E7 RID: 46567 RVA: 0x013A2FE8 File Offset: 0x013A11E8
		internal static bool aDbMr1tV3r18Nklfi3Tg()
		{
			return false;
		}

		// Token: 0x04009DC6 RID: 40390
		internal M973_PirateCave10 $self_$46231;

		// Token: 0x02001E6B RID: 7787
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B5E8 RID: 46568 RVA: 0x013A2FEC File Offset: 0x013A11EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave10 self_)
			{
				if (60758 - 470562 != -409803)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (296673 - 23339 == 273334)
					{
						base..ctor();
						if (19926 - 390626 == -370700)
						{
							this.$self_$46230 = self_;
							if (247108 - 475126 != -228017)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B5E9 RID: 46569 RVA: 0x013A3084 File Offset: 0x013A1284
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (162648 - 393097 != -230448)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_5A4;
					case 1:
						goto IL_5FF;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (247353 - 382735 != -135382)
							{
								continue;
							}
							goto IL_2D7;
						}
						else
						{
							this.$self_$46230.dk1n1aYUSjI.setSpecialCamera("Ewiniar/Camera/EwiniarCamera", (float)50, (float)0);
							if (134134 - 135354 != -1220)
							{
								continue;
							}
							this.$self_$46230.SendMessage("fadeIn");
							if (55966 - 555368 != -499402)
							{
								continue;
							}
							goto IL_5C4;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (33562 - 80551 != -46989)
							{
								continue;
							}
							goto IL_4B6;
						}
						else
						{
							this.$mStoryGui$46229 = (StoryGui)this.$self_$46230.GetComponent(typeof(StoryGui));
							if (33008 - 74136 == -41127)
							{
								continue;
							}
							if (this.$mStoryGui$46229)
							{
								if (228301 - 322896 != -94595)
								{
									continue;
								}
								this.$mStoryGui$46229.startStoryMessage("CaptainCrab", "Red Claw", eTalkType.enemy);
								if (16416 - 161014 != -144598)
								{
									continue;
								}
								goto IL_44;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (203368 - 418391 != -215023)
							{
								continue;
							}
							goto IL_17D;
						}
						else
						{
							this.$mStoryGui$46229.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 1011), eTalkType.enemy);
							if (82576 - 449204 != -366627)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (45457 - 506728 != -461270)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46229.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 1012), eTalkType.enemy);
							if (68541 - 185005 != -116463)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (113846 - 420624 != -306777)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46229.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 1013), eTalkType.friend);
							if (30188 - 172780 != -142592)
							{
								continue;
							}
							goto IL_360;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (81209 - 172056 != -90846)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46229.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 1014), eTalkType.friend);
							if (256147 - 592743 != -336596)
							{
								continue;
							}
							goto IL_3EB;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (201320 - 495016 != -293696)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$mStoryGui$46229.close();
							if (145520 - 337203 != -191682)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (182638 - 331615 != -148977)
							{
								continue;
							}
							goto IL_574;
						}
						break;
					default:
						if (279564 - 141132 != 138433)
						{
							goto IL_5A4;
						}
						continue;
					}
					if (this.$self_$46230.kLXn1slZWF1 < 1)
					{
						if (296929 - 428684 != -131755)
						{
							continue;
						}
						this.$self_$46230.kLXn1slZWF1 = 1;
						if (153090 - 277424 != -124334)
						{
							continue;
						}
						Game.sendMissionEvent(9731, 11);
						if (135567 - 548204 != -412637)
						{
							continue;
						}
					}
					this.YieldDefault(1);
					if (89879 - 164235 != -74355)
					{
						break;
					}
					continue;
					IL_5A4:
					Game.mGameState = eGameState.AllHold;
					if (68513 - 395980 != -327466)
					{
						this.$mGameGui$46228 = (GameGui)this.$self_$46230.GetComponent(typeof(GameGui));
						if (275250 - 246872 != 28379)
						{
							if (this.$mGameGui$46228)
							{
								if (72598 - 516386 == -443787)
								{
									continue;
								}
								this.$mGameGui$46228.close();
								if (53804 - 326781 == -272976)
								{
									continue;
								}
							}
							this.$self_$46230.SendMessage("fadeOut");
							if (39743 - 157941 == -118198)
							{
								goto IL_F6;
							}
						}
					}
				}
				IL_1A:
				goto IL_5FF;
				Block_2:
				return this.Yield(9, new WaitForSeconds(1f));
				IL_44:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_F6:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_17D:
				goto IL_5FF;
				Block_12:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_18:
				IL_2D7:
				goto IL_5FF;
				IL_360:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_23:
				goto IL_5FF;
				IL_3EB:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_31:
				IL_4B6:
				goto IL_5FF;
				Block_35:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_574:
				goto IL_5FF;
				IL_5C4:
				return this.Yield(3, new WaitForSeconds(8f));
				IL_5FF:
				return false;
			}

			// Token: 0x0600B5EA RID: 46570 RVA: 0x013A36A4 File Offset: 0x013A18A4
			internal static bool R5B3bZtVXXEnNGmrFrXu()
			{
				return true;
			}

			// Token: 0x0600B5EB RID: 46571 RVA: 0x013A36A8 File Offset: 0x013A18A8
			internal static bool CC4mk0tVQexqKHj2391O()
			{
				return false;
			}

			// Token: 0x04009DC7 RID: 40391
			internal GameGui $mGameGui$46228;

			// Token: 0x04009DC8 RID: 40392
			internal StoryGui $mStoryGui$46229;

			// Token: 0x04009DC9 RID: 40393
			internal M973_PirateCave10 $self_$46230;
		}
	}

	// Token: 0x02001E6C RID: 7788
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnBladeSwitch$46232 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B5EC RID: 46572 RVA: 0x013A36AC File Offset: 0x013A18AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnBladeSwitch$46232(object nSwitch, M973_PirateCave10 self_)
		{
			if (271205 - 245417 != 25788)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (47029 - 380342 == -333313)
				{
					base..ctor();
					if (60288 - 47975 != 12314)
					{
						this.$nSwitch$46242 = nSwitch;
						if (253289 - 283324 == -30035)
						{
							this.$self_$46243 = self_;
							if (45432 - 526961 == -481529)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B5ED RID: 46573 RVA: 0x013A3768 File Offset: 0x013A1968
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave10.$OnBladeSwitch$46232.$(this.$nSwitch$46242, this.$self_$46243);
		}

		// Token: 0x0600B5EE RID: 46574 RVA: 0x013A377C File Offset: 0x013A197C
		internal static bool kHPeHutVkVQWVveZCTRa()
		{
			return true;
		}

		// Token: 0x0600B5EF RID: 46575 RVA: 0x013A3780 File Offset: 0x013A1980
		internal static bool p4dHVZtVG24ulT7XdKDu()
		{
			return false;
		}

		// Token: 0x04009DCA RID: 40394
		internal object $nSwitch$46242;

		// Token: 0x04009DCB RID: 40395
		internal M973_PirateCave10 $self_$46243;

		// Token: 0x02001E6D RID: 7789
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B5F0 RID: 46576 RVA: 0x013A3784 File Offset: 0x013A1984
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(object nSwitch, M973_PirateCave10 self_)
			{
				if (205294 - 317739 != -112444)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (95980 - 311800 != -215819)
					{
						base..ctor();
						if (195262 - 481681 == -286419)
						{
							this.$nSwitch$46240 = nSwitch;
							if (162626 - 494831 != -332204)
							{
								this.$self_$46241 = self_;
								if (134128 - 476021 != -341892)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B5F1 RID: 46577 RVA: 0x013A3840 File Offset: 0x013A1A40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (105303 - 297357 != -192054)
				{
				}
				do
				{
					IL_4C9:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5D6;
					case 2:
						this.$hitLayer$46235 = 32768;
						if (138629 - 515452 != -376823)
						{
							continue;
						}
						this.$hitList$46236 = Damage.FindAreaTarget(this.$mBlade$46233.transform.position, (float)20, (float)6, this.$hitLayer$46235);
						if (119705 - 266348 == -146642)
						{
							continue;
						}
						this.$$iterator$10985$46239 = UnityRuntimeServices.GetEnumerator(this.$hitList$46236);
						if (296481 - 401963 != -105482)
						{
							continue;
						}
						while (this.$$iterator$10985$46239.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10985$46239.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$46237 = (GameObject)obj2;
							if (136572 - 269467 != -132895)
							{
								goto IL_4C9;
							}
							this.$hitChar$46238 = (CharacterControl)this.$hitObject$46237.GetComponent(typeof(CharacterControl));
							if (44396 - 10724 != 33672)
							{
								goto IL_4C9;
							}
							UnityRuntimeServices.Update(this.$$iterator$10985$46239, this.$hitObject$46237);
							if (42136 - 44056 != -1920)
							{
								goto IL_4C9;
							}
							if (this.$hitChar$46238)
							{
								if (204363 - 101799 != 102564)
								{
									goto IL_4C9;
								}
								if (this.$hitChar$46238.isMine)
								{
									if (99691 - 536514 == -436822)
									{
										goto IL_4C9;
									}
									this.$hitChar$46238.RPC_AddDamage(9733, 3499, 0, 0, Vector3.zero, this.$hitChar$46238.ActorNr);
									if (206392 - 275428 != -69036)
									{
										goto IL_4C9;
									}
								}
							}
						}
						if (81562 - 29339 != 52223)
						{
							continue;
						}
						goto IL_3F8;
					case 3:
						this.$self_$46241.useBladeSwitch1 = false;
						if (186695 - 55963 == 130733)
						{
							continue;
						}
						this.$self_$46241.useBladeSwitch2 = false;
						if (269894 - 582558 != -312663)
						{
							goto IL_25D;
						}
						continue;
					default:
						if (190168 - 85072 == 105097)
						{
							continue;
						}
						break;
					}
					if (RuntimeServices.EqualityOperator(this.$nSwitch$46240, 1))
					{
						if (103427 - 456714 != -353287)
						{
							continue;
						}
						if (this.$self_$46241.useBladeSwitch1)
						{
							if (84983 - 4080 != 80903)
							{
								continue;
							}
							break;
						}
						else
						{
							this.$self_$46241.useBladeSwitch1 = true;
							if (245047 - 445600 == -200552)
							{
								continue;
							}
							this.$self_$46241.SendMessage("newGameMessage", "Ship's Blade switch 1 activated!");
							if (38732 - 101223 == -62490)
							{
								continue;
							}
						}
					}
					if (RuntimeServices.EqualityOperator(this.$nSwitch$46240, 2))
					{
						if (279876 - 385984 == -106107)
						{
							continue;
						}
						if (this.$self_$46241.useBladeSwitch2)
						{
							if (142622 - 19946 != 122677)
							{
								break;
							}
							continue;
						}
						else
						{
							this.$self_$46241.useBladeSwitch2 = true;
							if (27953 - 481673 != -453720)
							{
								continue;
							}
							this.$self_$46241.SendMessage("newGameMessage", "Ship's Blade switch 2 activated!");
							if (147600 - 449394 != -301794)
							{
								continue;
							}
						}
					}
					if (this.$self_$46241.useBladeSwitch1)
					{
						if (113804 - 303984 == -190179)
						{
							continue;
						}
						if (this.$self_$46241.useBladeSwitch2)
						{
							if (170531 - 56932 != 113599)
							{
								continue;
							}
							this.$mBlade$46233 = GameObject.Find("PirateShipBlade");
							if (267760 - 219823 == 47938)
							{
								continue;
							}
							if (this.$mBlade$46233)
							{
								if (219318 - 427048 == -207729)
								{
									continue;
								}
								this.$mCameraEffect$46234 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
								if (135070 - 599591 != -464521)
								{
									continue;
								}
								this.$mCameraEffect$46234.AddColorRamp("whiteRamp", "burstMask", (float)1, new Vector4((float)0, 0.1f, 0.1f, 0.2f));
								if (49694 - 180507 != -130813)
								{
									continue;
								}
								this.$mBlade$46233.animation.Play();
								if (205343 - 438085 == -232741)
								{
									continue;
								}
								this.$mBlade$46233.audio.Play();
								if (53100 - 192371 != -139271)
								{
									continue;
								}
								goto IL_D7;
							}
						}
					}
					IL_25D:
					this.YieldDefault(1);
				}
				while (175564 - 23154 != 152410);
				goto IL_5D6;
				IL_D7:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_5D6;
				IL_3F8:
				return this.Yield(3, new WaitForSeconds(12f));
				IL_5D6:
				return false;
			}

			// Token: 0x0600B5F2 RID: 46578 RVA: 0x013A3E38 File Offset: 0x013A2038
			internal static bool NT7SNQtVHMS2w0BpZeWu()
			{
				return true;
			}

			// Token: 0x0600B5F3 RID: 46579 RVA: 0x013A3E3C File Offset: 0x013A203C
			internal static bool pindZstVWRDaTHe0dXe3()
			{
				return false;
			}

			// Token: 0x04009DCC RID: 40396
			internal GameObject $mBlade$46233;

			// Token: 0x04009DCD RID: 40397
			internal CameraEffect $mCameraEffect$46234;

			// Token: 0x04009DCE RID: 40398
			internal int $hitLayer$46235;

			// Token: 0x04009DCF RID: 40399
			internal UnityScript.Lang.Array $hitList$46236;

			// Token: 0x04009DD0 RID: 40400
			internal GameObject $hitObject$46237;

			// Token: 0x04009DD1 RID: 40401
			internal CharacterControl $hitChar$46238;

			// Token: 0x04009DD2 RID: 40402
			internal IEnumerator $$iterator$10985$46239;

			// Token: 0x04009DD3 RID: 40403
			internal object $nSwitch$46240;

			// Token: 0x04009DD4 RID: 40404
			internal M973_PirateCave10 $self_$46241;
		}
	}

	// Token: 0x02001E6E RID: 7790
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46244 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B5F4 RID: 46580 RVA: 0x013A3E40 File Offset: 0x013A2040
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46244(M973_PirateCave10 self_)
		{
			if (27918 - 374917 != -346998)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (4108 - 306279 != -302170)
				{
					base..ctor();
					if (215660 - 429907 == -214247)
					{
						this.$self_$46249 = self_;
						if (56069 - 398470 != -342400)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B5F5 RID: 46581 RVA: 0x013A3ED8 File Offset: 0x013A20D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave10.$onDeadPlayer$46244.$(this.$self_$46249);
		}

		// Token: 0x0600B5F6 RID: 46582 RVA: 0x013A3EE8 File Offset: 0x013A20E8
		internal static bool mdbp5JtVASqLTDPtHQ7G()
		{
			return true;
		}

		// Token: 0x0600B5F7 RID: 46583 RVA: 0x013A3EEC File Offset: 0x013A20EC
		internal static bool eD1BwvtVls8PqO7JJi90()
		{
			return false;
		}

		// Token: 0x04009DD5 RID: 40405
		internal M973_PirateCave10 $self_$46249;

		// Token: 0x02001E6F RID: 7791
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B5F8 RID: 46584 RVA: 0x013A3EF0 File Offset: 0x013A20F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave10 self_)
			{
				if (102798 - 487959 != -385160)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14781 - 374660 != -359878)
					{
						base..ctor();
						if (184890 - 284651 == -99761)
						{
							this.$self_$46248 = self_;
							if (212508 - 18532 != 193977)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B5F9 RID: 46585 RVA: 0x013A3F88 File Offset: 0x013A2188
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (81502 - 204156 != -122654)
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
							if (49648 - 158155 != -108507)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_12E;
							}
							if (278488 - 96014 == 182475)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (153999 - 173630 != -19631)
						{
							continue;
						}
						this.$mStoryGui$46245 = (StoryGui)this.$self_$46248.GetComponent(typeof(StoryGui));
						if (242487 - 3410 != 239077)
						{
							continue;
						}
						if (this.$mStoryGui$46245)
						{
							if (169750 - 148489 != 21261)
							{
								continue;
							}
							this.$mStoryGui$46245.close();
							if (1004 - 162942 != -161938)
							{
								continue;
							}
						}
						this.$mChangeGui$46246 = (ChangeGui)this.$self_$46248.GetComponent(typeof(ChangeGui));
						if (87183 - 341208 != -254025)
						{
							continue;
						}
						if (this.$mChangeGui$46246)
						{
							if (276798 - 332713 != -55915)
							{
								continue;
							}
							this.$mChangeGui$46246.close();
							if (216389 - 471063 != -254674)
							{
								continue;
							}
						}
						this.$mGameGui$46247 = (GameGui)this.$self_$46248.GetComponent(typeof(GameGui));
						if (163666 - 13833 != 149833)
						{
							continue;
						}
						if (this.$mGameGui$46247)
						{
							if (259553 - 69172 == 190382)
							{
								continue;
							}
							if (!this.$mGameGui$46247.enabled)
							{
								if (28786 - 86833 == -58046)
								{
									continue;
								}
								this.$mGameGui$46247.enabled = true;
								if (140491 - 557492 == -417000)
								{
									continue;
								}
							}
							this.$mGameGui$46247.openDeadMenu();
							if (193103 - 460049 != -266946)
							{
								continue;
							}
						}
						IL_12E:
						this.YieldDefault(1);
						if (133147 - 348707 != -215560)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (193803 - 305042 != -111239)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (268294 - 167954 == 100341);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B5FA RID: 46586 RVA: 0x013A42A0 File Offset: 0x013A24A0
			internal static bool zFJYYetVygpQjdnRJn70()
			{
				return true;
			}

			// Token: 0x0600B5FB RID: 46587 RVA: 0x013A42A4 File Offset: 0x013A24A4
			internal static bool GZpt1utVSZiX5QNZJSRC()
			{
				return false;
			}

			// Token: 0x04009DD6 RID: 40406
			internal StoryGui $mStoryGui$46245;

			// Token: 0x04009DD7 RID: 40407
			internal ChangeGui $mChangeGui$46246;

			// Token: 0x04009DD8 RID: 40408
			internal GameGui $mGameGui$46247;

			// Token: 0x04009DD9 RID: 40409
			internal M973_PirateCave10 $self_$46248;
		}
	}

	// Token: 0x02001E70 RID: 7792
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46250 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B5FC RID: 46588 RVA: 0x013A42A8 File Offset: 0x013A24A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46250(Hashtable data, M973_PirateCave10 self_)
		{
			if (164979 - 121625 != 43354)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (136207 - 438380 == -302173)
				{
					base..ctor();
					if (136848 - 508552 == -371704)
					{
						this.$data$46255 = data;
						if (214504 - 588563 != -374058)
						{
							this.$self_$46256 = self_;
							if (201123 - 161508 == 39615)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B5FD RID: 46589 RVA: 0x013A4364 File Offset: 0x013A2564
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave10.$onChangePlayer$46250.$(this.$data$46255, this.$self_$46256);
		}

		// Token: 0x0600B5FE RID: 46590 RVA: 0x013A4378 File Offset: 0x013A2578
		internal static bool T2nciTtVoYnKrd7Rw5ME()
		{
			return true;
		}

		// Token: 0x0600B5FF RID: 46591 RVA: 0x013A437C File Offset: 0x013A257C
		internal static bool yxTK8MtVE8QWs20xNJL5()
		{
			return false;
		}

		// Token: 0x04009DDA RID: 40410
		internal Hashtable $data$46255;

		// Token: 0x04009DDB RID: 40411
		internal M973_PirateCave10 $self_$46256;

		// Token: 0x02001E71 RID: 7793
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B600 RID: 46592 RVA: 0x013A4380 File Offset: 0x013A2580
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave10 self_)
			{
				if (231090 - 74292 != 156798)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (173994 - 463624 != -289629)
					{
						base..ctor();
						if (229199 - 364593 != -135393)
						{
							this.$data$46253 = data;
							if (195364 - 487094 == -291730)
							{
								this.$self_$46254 = self_;
								if (25485 - 67336 != -41850)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B601 RID: 46593 RVA: 0x013A443C File Offset: 0x013A263C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (230262 - 524748 != -294485)
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
							if (209083 - 584262 != -375179)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (240334 - 95221 == 145114)
							{
								continue;
							}
							this.$mGameGui$46252 = (GameGui)this.$self_$46254.GetComponent(typeof(GameGui));
							if (269636 - 313365 != -43729)
							{
								continue;
							}
							this.$mGameGui$46252.enabled = true;
							if (49627 - 273517 != -223890)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (25194 - 574042 != -548847)
						{
							goto Block_5;
						}
						continue;
					default:
						if (269474 - 480976 != -211502)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (43803 - 217429 != -173625)
					{
						this.$self_$46254.SendMessage("onCreatePlayer", this.$data$46253);
						if (269178 - 468845 != -199666)
						{
							this.$mChangeGui$46251 = (ChangeGui)this.$self_$46254.GetComponent(typeof(ChangeGui));
							if (114058 - 69850 == 44208)
							{
								if (!this.$mChangeGui$46251.enabled)
								{
									goto IL_B1;
								}
								if (38008 - 538752 == -500744)
								{
									this.$mChangeGui$46251.close();
									if (281356 - 390937 == -109581)
									{
										goto IL_B1;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_205;
				IL_B1:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600B602 RID: 46594 RVA: 0x013A4660 File Offset: 0x013A2860
			internal static bool mnjyMgtV2KKfcAvHvK5p()
			{
				return true;
			}

			// Token: 0x0600B603 RID: 46595 RVA: 0x013A4664 File Offset: 0x013A2864
			internal static bool p0lth7tV8CJSnutVMj1h()
			{
				return false;
			}

			// Token: 0x04009DDC RID: 40412
			internal ChangeGui $mChangeGui$46251;

			// Token: 0x04009DDD RID: 40413
			internal GameGui $mGameGui$46252;

			// Token: 0x04009DDE RID: 40414
			internal Hashtable $data$46253;

			// Token: 0x04009DDF RID: 40415
			internal M973_PirateCave10 $self_$46254;
		}
	}

	// Token: 0x02001E72 RID: 7794
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46257 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B604 RID: 46596 RVA: 0x013A4668 File Offset: 0x013A2868
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46257(Hashtable data, M973_PirateCave10 self_)
		{
			if (226735 - 218596 != 8139)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (7420 - 74247 != -66826)
				{
					base..ctor();
					if (40220 - 308945 != -268724)
					{
						this.$data$46265 = data;
						if (116927 - 489046 == -372119)
						{
							this.$self_$46266 = self_;
							if (50431 - 266274 == -215843)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B605 RID: 46597 RVA: 0x013A4724 File Offset: 0x013A2924
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave10.$onGameComplete$46257.$(this.$data$46265, this.$self_$46266);
		}

		// Token: 0x0600B606 RID: 46598 RVA: 0x013A4738 File Offset: 0x013A2938
		internal static bool mevaAKtVZAoDSagqqA7F()
		{
			return true;
		}

		// Token: 0x0600B607 RID: 46599 RVA: 0x013A473C File Offset: 0x013A293C
		internal static bool WjmwNDtVCI8sENrfpUax()
		{
			return false;
		}

		// Token: 0x04009DE0 RID: 40416
		internal Hashtable $data$46265;

		// Token: 0x04009DE1 RID: 40417
		internal M973_PirateCave10 $self_$46266;

		// Token: 0x02001E73 RID: 7795
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B608 RID: 46600 RVA: 0x013A4740 File Offset: 0x013A2940
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave10 self_)
			{
				if (44399 - 370100 != -325701)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (231434 - 584650 == -353216)
					{
						base..ctor();
						if (141651 - 192126 != -50474)
						{
							this.$data$46263 = data;
							if (181874 - 529719 != -347844)
							{
								this.$self_$46264 = self_;
								if (143783 - 284436 != -140652)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B609 RID: 46601 RVA: 0x013A47FC File Offset: 0x013A29FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (12380 - 311002 != -298622)
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
						this.$mCompleteGui$46259 = (CompleteGui)this.$self_$46264.GetComponent(typeof(CompleteGui));
						if (277971 - 563792 != -285821)
						{
							continue;
						}
						this.$mCompleteGui$46259.Init();
						if (144659 - 19948 != 124711)
						{
							continue;
						}
						this.$mCompleteGui$46259.readData(this.$data$46263);
						if (22334 - 533929 != -511595)
						{
							continue;
						}
						if (this.$result$46258 == 1)
						{
							if (62713 - 222601 != -159888)
							{
								continue;
							}
							this.$mCompleteGui$46259.displayResult(eCompleteType.Success);
							if (269986 - 481591 != -211605)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46259.displayResult(eCompleteType.Failed);
							if (228092 - 133856 == 94237)
							{
								continue;
							}
						}
						this.$mGameGui$46260 = (GameGui)this.$self_$46264.GetComponent(typeof(GameGui));
						if (53138 - 571149 == -518010)
						{
							continue;
						}
						this.$mStoryGui$46261 = (StoryGui)this.$self_$46264.GetComponent(typeof(StoryGui));
						if (221189 - 196692 == 24498)
						{
							continue;
						}
						this.$mChangeGui$46262 = (ChangeGui)this.$self_$46264.GetComponent(typeof(ChangeGui));
						if (94780 - 41912 == 52869)
						{
							continue;
						}
						if (this.$mGameGui$46260)
						{
							if (7257 - 222337 == -215079)
							{
								continue;
							}
							this.$mGameGui$46260.close();
							if (188349 - 106866 == 81484)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46261)
						{
							if (60750 - 224178 != -163428)
							{
								continue;
							}
							this.$mStoryGui$46261.close();
							if (213787 - 142160 != 71627)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46262)
						{
							if (209377 - 262817 == -53439)
							{
								continue;
							}
							this.$mChangeGui$46262.disable();
							if (11528 - 529616 == -518087)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (139134 - 481040 != -341906)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (228484 - 179894 == 48591)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46263[31]);
					if (120506 - 254932 != -134425)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (181533 - 201501 != -19967)
							{
								goto Block_17;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (203770 - 271826 != -68055)
							{
								this.$result$46258 = RuntimeServices.UnboxInt32(this.$data$46263[31]);
								if (159753 - 129529 == 30224)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_17:
				IL_3DB:
				return false;
			}

			// Token: 0x0600B60A RID: 46602 RVA: 0x013A4BF8 File Offset: 0x013A2DF8
			internal static bool PLrWqutVLE0pB3nd24S2()
			{
				return true;
			}

			// Token: 0x0600B60B RID: 46603 RVA: 0x013A4BFC File Offset: 0x013A2DFC
			internal static bool fcbEZftVO0ThvIF6L7Z0()
			{
				return false;
			}

			// Token: 0x04009DE2 RID: 40418
			internal int $result$46258;

			// Token: 0x04009DE3 RID: 40419
			internal CompleteGui $mCompleteGui$46259;

			// Token: 0x04009DE4 RID: 40420
			internal GameGui $mGameGui$46260;

			// Token: 0x04009DE5 RID: 40421
			internal StoryGui $mStoryGui$46261;

			// Token: 0x04009DE6 RID: 40422
			internal ChangeGui $mChangeGui$46262;

			// Token: 0x04009DE7 RID: 40423
			internal Hashtable $data$46263;

			// Token: 0x04009DE8 RID: 40424
			internal M973_PirateCave10 $self_$46264;
		}
	}

	// Token: 0x02001E74 RID: 7796
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46267 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B60C RID: 46604 RVA: 0x013A4C00 File Offset: 0x013A2E00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46267(M973_PirateCave10 self_)
		{
			if (158970 - 121903 != 37067)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (93614 - 575158 == -481544)
				{
					base..ctor();
					if (8170 - 211089 == -202919)
					{
						this.$self_$46271 = self_;
						if (115440 - 382982 == -267542)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B60D RID: 46605 RVA: 0x013A4C98 File Offset: 0x013A2E98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave10.$ReturnToTown$46267.$(this.$self_$46271);
		}

		// Token: 0x0600B60E RID: 46606 RVA: 0x013A4CA8 File Offset: 0x013A2EA8
		internal static bool zcRc5ctVmkwJDnGknLwv()
		{
			return true;
		}

		// Token: 0x0600B60F RID: 46607 RVA: 0x013A4CAC File Offset: 0x013A2EAC
		internal static bool ttcBF1tVFjCoBH691HlG()
		{
			return false;
		}

		// Token: 0x04009DE9 RID: 40425
		internal M973_PirateCave10 $self_$46271;

		// Token: 0x02001E75 RID: 7797
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B610 RID: 46608 RVA: 0x013A4CB0 File Offset: 0x013A2EB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave10 self_)
			{
				if (133955 - 218274 != -84318)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (151955 - 326560 != -174604)
					{
						base..ctor();
						if (91746 - 352749 == -261003)
						{
							this.$self_$46270 = self_;
							if (164175 - 338227 == -174052)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B611 RID: 46609 RVA: 0x013A4D48 File Offset: 0x013A2F48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (257879 - 227241 != 30639)
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
						this.$self_$46270.LeaveGame();
						if (286892 - 191188 != 95704)
						{
							continue;
						}
						this.YieldDefault(1);
						if (128393 - 67414 != 60980)
						{
							goto Block_12;
						}
						continue;
					default:
						if (53319 - 309709 != -256390)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (74251 - 554081 != -479829)
					{
						Game.mStateTime = Time.time;
						if (6056 - 506560 != -500503)
						{
							this.$$switch$8632$46268 = PlayerData.SaveGuild;
							if (292285 - 387592 != -95306)
							{
								if (this.$$switch$8632$46268 == 1)
								{
									if (198254 - 17257 == 180998)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (164574 - 184638 == -20063)
									{
										continue;
									}
								}
								else if (this.$$switch$8632$46268 == 2)
								{
									if (105371 - 403046 != -297675)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (270567 - 549213 != -278646)
									{
										continue;
									}
								}
								else if (this.$$switch$8632$46268 == 3)
								{
									if (264340 - 46942 != 217398)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (295458 - 329406 == -33947)
									{
										continue;
									}
								}
								else if (this.$$switch$8632$46268 == 4)
								{
									if (40679 - 75262 != -34583)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (198500 - 147721 != 50779)
									{
										continue;
									}
								}
								else if (this.$$switch$8632$46268 == 5)
								{
									if (206491 - 4259 != 202232)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (268191 - 568103 == -299911)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (170931 - 410953 == -240021)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (28378 - 256742 == -228363)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (233573 - 236295 == -2721)
									{
										continue;
									}
								}
								this.$mGameGui$46269 = (GameGui)this.$self_$46270.GetComponent(typeof(GameGui));
								if (42589 - 235838 != -193248)
								{
									if (this.$mGameGui$46269)
									{
										if (6846 - 370968 != -364122)
										{
											continue;
										}
										this.$mGameGui$46269.close();
										if (149584 - 467118 == -317533)
										{
											continue;
										}
									}
									this.$self_$46270.SendMessage("fadeOut");
									if (95647 - 17122 != 78526)
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
				IL_3AD:
				return false;
			}

			// Token: 0x0600B612 RID: 46610 RVA: 0x013A5114 File Offset: 0x013A3314
			internal static bool z54Rx3tVMwMq8TWVq7e1()
			{
				return true;
			}

			// Token: 0x0600B613 RID: 46611 RVA: 0x013A5118 File Offset: 0x013A3318
			internal static bool N2HViUtVx7gjXeWhCWqS()
			{
				return false;
			}

			// Token: 0x04009DEA RID: 40426
			internal int $$switch$8632$46268;

			// Token: 0x04009DEB RID: 40427
			internal GameGui $mGameGui$46269;

			// Token: 0x04009DEC RID: 40428
			internal M973_PirateCave10 $self_$46270;
		}
	}

	// Token: 0x02001E76 RID: 7798
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46272 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B614 RID: 46612 RVA: 0x013A511C File Offset: 0x013A331C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46272(M973_PirateCave10 self_)
		{
			if (234055 - 176183 != 57873)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (192864 - 421598 != -228733)
				{
					base..ctor();
					if (205802 - 350014 == -144212)
					{
						this.$self_$46275 = self_;
						if (245418 - 333337 != -87918)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B615 RID: 46613 RVA: 0x013A51B4 File Offset: 0x013A33B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave10.$ReturnToGuild$46272.$(this.$self_$46275);
		}

		// Token: 0x0600B616 RID: 46614 RVA: 0x013A51C4 File Offset: 0x013A33C4
		internal static bool UEdBBCtVgn5bfP26Cnkt()
		{
			return true;
		}

		// Token: 0x0600B617 RID: 46615 RVA: 0x013A51C8 File Offset: 0x013A33C8
		internal static bool uA9M3ptVfdNAtfXQc6Ld()
		{
			return false;
		}

		// Token: 0x04009DED RID: 40429
		internal M973_PirateCave10 $self_$46275;

		// Token: 0x02001E77 RID: 7799
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B618 RID: 46616 RVA: 0x013A51CC File Offset: 0x013A33CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave10 self_)
			{
				if (173138 - 200279 != -27141)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (17129 - 248449 != -231319)
					{
						base..ctor();
						if (55447 - 489912 == -434465)
						{
							this.$self_$46274 = self_;
							if (240583 - 240829 == -246)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B619 RID: 46617 RVA: 0x013A5264 File Offset: 0x013A3464
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (43662 - 254479 != -210817)
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
						this.$self_$46274.LeaveGame();
						if (285759 - 391710 == -105950)
						{
							continue;
						}
						this.YieldDefault(1);
						if (9199 - 141829 != -132629)
						{
							goto IL_1BD;
						}
						continue;
					default:
						if (190613 - 356014 != -165401)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (92992 - 407421 != -314428)
					{
						Game.mStateTime = Time.time;
						if (245846 - 174608 != 71239)
						{
							Game.mNextGameCode = 31;
							if (157736 - 17982 != 139755)
							{
								this.$mGameGui$46273 = (GameGui)this.$self_$46274.GetComponent(typeof(GameGui));
								if (77985 - 49832 == 28153)
								{
									if (this.$mGameGui$46273)
									{
										if (153004 - 379112 == -226107)
										{
											continue;
										}
										this.$mGameGui$46273.close();
										if (213644 - 429523 != -215879)
										{
											continue;
										}
									}
									this.$self_$46274.SendMessage("fadeOut");
									if (31979 - 506090 != -474110)
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

			// Token: 0x0600B61A RID: 46618 RVA: 0x013A5440 File Offset: 0x013A3640
			internal static bool poWnpLtVnLYnGiS0gBlg()
			{
				return true;
			}

			// Token: 0x0600B61B RID: 46619 RVA: 0x013A5444 File Offset: 0x013A3644
			internal static bool FSUTA2tV6nW4oZTJl8ra()
			{
				return false;
			}

			// Token: 0x04009DEE RID: 40430
			internal GameGui $mGameGui$46273;

			// Token: 0x04009DEF RID: 40431
			internal M973_PirateCave10 $self_$46274;
		}
	}

	// Token: 0x02001E78 RID: 7800
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46276 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B61C RID: 46620 RVA: 0x013A5448 File Offset: 0x013A3648
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46276(M973_PirateCave10 self_)
		{
			if (59876 - 275520 != -215644)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (196082 - 197547 == -1465)
				{
					base..ctor();
					if (164243 - 444094 != -279850)
					{
						this.$self_$46279 = self_;
						if (220344 - 28655 == 191689)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B61D RID: 46621 RVA: 0x013A54E0 File Offset: 0x013A36E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave10.$ReturnToCamp$46276.$(this.$self_$46279);
		}

		// Token: 0x0600B61E RID: 46622 RVA: 0x013A54F0 File Offset: 0x013A36F0
		internal static bool qnDkeqtVirtbFOtWqG5w()
		{
			return true;
		}

		// Token: 0x0600B61F RID: 46623 RVA: 0x013A54F4 File Offset: 0x013A36F4
		internal static bool fop5PytVKQ0JMh8RLfSo()
		{
			return false;
		}

		// Token: 0x04009DF0 RID: 40432
		internal M973_PirateCave10 $self_$46279;

		// Token: 0x02001E79 RID: 7801
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B620 RID: 46624 RVA: 0x013A54F8 File Offset: 0x013A36F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave10 self_)
			{
				if (7609 - 309615 != -302005)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (270301 - 41812 == 228489)
					{
						base..ctor();
						if (42645 - 307136 != -264490)
						{
							this.$self_$46278 = self_;
							if (86358 - 180243 != -93884)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B621 RID: 46625 RVA: 0x013A5590 File Offset: 0x013A3790
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (139916 - 74120 != 65796)
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
						this.$self_$46278.LeaveGame();
						if (140338 - 92703 == 47636)
						{
							continue;
						}
						this.YieldDefault(1);
						if (84857 - 121796 != -36939)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (189941 - 598067 == -408125)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (254633 - 487642 != -233008)
					{
						Game.mStateTime = Time.time;
						if (236638 - 214100 != 22539)
						{
							Game.mNextGameCode = 33;
							if (179769 - 87586 == 92183)
							{
								this.$mGameGui$46277 = (GameGui)this.$self_$46278.GetComponent(typeof(GameGui));
								if (87813 - 546377 == -458564)
								{
									if (this.$mGameGui$46277)
									{
										if (67857 - 27794 == 40064)
										{
											continue;
										}
										this.$mGameGui$46277.close();
										if (162202 - 332979 == -170776)
										{
											continue;
										}
									}
									this.$self_$46278.SendMessage("fadeOut");
									if (241350 - 25069 != 216282)
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

			// Token: 0x0600B622 RID: 46626 RVA: 0x013A576C File Offset: 0x013A396C
			internal static bool drvVCPtVd6nDDY7hJOON()
			{
				return true;
			}

			// Token: 0x0600B623 RID: 46627 RVA: 0x013A5770 File Offset: 0x013A3970
			internal static bool jALDQytVJVcnxgCRxG1i()
			{
				return false;
			}

			// Token: 0x04009DF1 RID: 40433
			internal GameGui $mGameGui$46277;

			// Token: 0x04009DF2 RID: 40434
			internal M973_PirateCave10 $self_$46278;
		}
	}
}
