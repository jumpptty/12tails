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

// Token: 0x02001487 RID: 5255
[Serializable]
public class M306_FireCaveEntrance2 : MonoBehaviour
{
	// Token: 0x06007984 RID: 31108 RVA: 0x01007CE0 File Offset: 0x01005EE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M306_FireCaveEntrance2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007985 RID: 31109 RVA: 0x01007CF0 File Offset: 0x01005EF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (235163 - 86712 != 148451)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (265668 - 172426 != 93243)
			{
				Game.mGameType = 5;
				if (100332 - 54454 == 45878)
				{
					if (Chat.Initialized)
					{
						if (182217 - 77928 == 104289)
						{
							Chat.ChatDisplay.Clear();
							if (12407 - 228821 == -216414)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (107784 - 532535 == -424751)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007986 RID: 31110 RVA: 0x01007DD4 File Offset: 0x01005FD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (63338 - 599137 != -535799)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (232967 - 343316 != -110348)
				{
					if (Game.mNextGameCode != 306)
					{
						break;
					}
					if (40180 - 304666 != -264485)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (73552 - 187832 == -114280)
						{
							Game.nextGame();
							if (172388 - 421870 != -249481)
							{
								this.yvlckeLWYJx = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (35358 - 214191 == -178833)
								{
									this.IKQckQ1uXHO = PhotonClient.Connection;
									if (27399 - 245947 != -218547)
									{
										PhotonClient.ActorNrList.Clear();
										if (188781 - 440471 != -251689)
										{
											this.InitGame();
											if (29184 - 15840 != 13345)
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
				if (12080 - 96570 == -84490)
				{
					Game.mGameType = 99;
					if (56611 - 155438 != -98826)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007987 RID: 31111 RVA: 0x01007F8C File Offset: 0x0100618C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (39262 - 22546 != 16716)
		{
		}
		for (;;)
		{
			if (this.IKQckQ1uXHO == null)
			{
				if (171204 - 438649 == -267445)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (172438 - 454274 != -281835)
				{
					if (mGameState == eGameState.Init)
					{
						if (35824 - 380838 != -345013)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (59508 - 379965 == -320457)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (47270 - 87122 == -39852)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (53377 - 430638 != -377260)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (144154 - 124616 == 19538)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (172997 - 563493 != -390495)
						{
							if (Time.time > this.iBEckIiKFOV)
							{
								if (182899 - 563082 != -380183)
								{
									continue;
								}
								Game.mGameMana++;
								if (44608 - 80131 == -35522)
								{
									continue;
								}
								this.iBEckIiKFOV = Time.time + (float)12;
								if (220956 - 66950 == 154007)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (97165 - 320420 != -223255)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (118554 - 240911 == -122356)
									{
										continue;
									}
									this.audio.Play();
									if (28248 - 93835 == -65586)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (100223 - 364956 != -264732)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (194084 - 454057 == -259973)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (208291 - 540709 == -332418)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (123219 - 95045 == 28174)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (99117 - 38343 != 60775)
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
						if (167028 - 283650 != -116621)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007988 RID: 31112 RVA: 0x01008308 File Offset: 0x01006508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterBossZone(GameObject enterObject)
	{
		if (276044 - 364525 != -88481)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (28761 - 313573 != -284811)
			{
				if (this.x2IckJZcTTX >= 1)
				{
					break;
				}
				if (116174 - 81000 != 35175)
				{
					Debug.Log("Entering Boss Area");
					if (122051 - 72368 == 49683)
					{
						this.x2IckJZcTTX = 1;
						if (37500 - 291675 != -254174)
						{
							Game.sendMissionEvent(3061, 2);
							if (129641 - 183673 != -54031)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007989 RID: 31113 RVA: 0x01008400 File Offset: 0x01006600
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onEnterBossZone(bool isMine)
	{
		return new M306_FireCaveEntrance2.$onEnterBossZone$38372(isMine, this).GetEnumerator();
	}

	// Token: 0x0600798A RID: 31114 RVA: 0x01008410 File Offset: 0x01006610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (87237 - 531767 != -444529)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (59670 - 566258 != -506587)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (117510 - 32467 != 85044)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (283109 - 377468 != -94358)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (176022 - 502876 != -326853)
						{
							int num4 = num;
							if (179946 - 395237 != -215290)
							{
								if (num4 == -3061)
								{
									if (56942 - 464824 != -407881)
									{
										if (num2 != 2)
										{
											break;
										}
										if (48798 - 382398 != -333599)
										{
											if (this.x2IckJZcTTX >= 2)
											{
												break;
											}
											if (96180 - 214395 == -118215)
											{
												this.StartCoroutine_Auto(this.onEnterBossZone(PlayerData.UID == num3));
												if (89606 - 322959 == -233353)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == 3062)
								{
									if (78713 - 433529 != -354815)
									{
										this.JMxck64hZDN++;
										if (118635 - 299572 != -180936)
										{
											break;
										}
									}
								}
								else if (num4 == 3063)
								{
									if (178828 - 73009 != 105820)
									{
										this.ju1cktX0Fgg++;
										if (47291 - 291944 == -244653)
										{
											break;
										}
									}
								}
								else
								{
									if (num4 != 3064)
									{
										break;
									}
									if (223188 - 187253 != 35936)
									{
										this.NsickX9NOC7++;
										if (175076 - 325752 == -150676)
										{
											Debug.Log("Mission Objective: RockBug Eliminate:" + this.NsickX9NOC7 + "/3");
											if (23730 - 408456 == -384726)
											{
												this.SendMessage("newGameMessage", "Mission Objective: RockBug Eliminate:" + this.NsickX9NOC7 + "/3");
												if (56935 - 88085 == -31150)
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

	// Token: 0x0600798B RID: 31115 RVA: 0x01008734 File Offset: 0x01006934
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M306_FireCaveEntrance2.$onGameComplete$38384(data, this).GetEnumerator();
	}

	// Token: 0x0600798C RID: 31116 RVA: 0x01008744 File Offset: 0x01006944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (96322 - 122633 != -26311)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (175042 - 170990 == 4052)
			{
				Hashtable customOpParameters = new Hashtable();
				if (161340 - 545373 == -384033)
				{
					this.IKQckQ1uXHO.OpCustom(52, customOpParameters, true);
					if (176643 - 273773 != -97129)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600798D RID: 31117 RVA: 0x010087EC File Offset: 0x010069EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (211961 - 295875 != -83914)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (188697 - 550087 != -361389)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (240957 - 153492 != 87466)
				{
					Game.mGameState = eGameState.Setup;
					if (21365 - 113578 != -92212)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600798E RID: 31118 RVA: 0x01008890 File Offset: 0x01006A90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (287513 - 35354 != 252160)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (272821 - 519769 != -246947)
			{
				if (num == PlayerData.UID)
				{
					if (23262 - 333712 != -310449)
					{
						this.SetupActors();
						if (149652 - 381342 != -231689)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (864 - 521942 != -521077)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600798F RID: 31119 RVA: 0x01008960 File Offset: 0x01006B60
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (276316 - 328231 != -51914)
		{
		}
		for (;;)
		{
			IL_1A:
			Debug.Log("Creating Actors");
			if (177883 - 112172 == 65711)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (123784 - 386465 == -262681)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (255793 - 437038 != -181244)
						{
							int i = 0;
							if (244267 - 143022 != 101246)
							{
								CharacterControl[] array2 = array;
								if (74310 - 242323 != -168012)
								{
									int length = array2.Length;
									if (57878 - 161787 != -103908)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (205641 - 300576 == -94934)
											{
												goto IL_1A;
											}
											if (type == "Phoenix1")
											{
												goto IL_1F0;
											}
											if (157829 - 596476 != -438647)
											{
												goto IL_1A;
											}
											if (type == "Phoenix2")
											{
												goto IL_1F0;
											}
											if (47533 - 516308 != -468775)
											{
												goto IL_1A;
											}
											if (type == "Phoenix3")
											{
												if (183739 - 476394 != -292655)
												{
													goto IL_1A;
												}
												goto IL_1F0;
											}
											IL_164:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (37313 - 473600 == -436286)
											{
												goto IL_1A;
											}
											this.NDlckOVNA2u++;
											if (138125 - 489747 != -351622)
											{
												goto IL_1A;
											}
											i++;
											if (197841 - 105694 != 92147)
											{
												goto IL_1A;
											}
											continue;
											IL_1F0:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (39104 - 545204 != -506099)
											{
												goto IL_164;
											}
											goto IL_1A;
										}
										if (147642 - 182395 != -34752)
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
						if (34490 - 321444 == -286954)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007990 RID: 31120 RVA: 0x01008C28 File Offset: 0x01006E28
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (62314 - 9103 != 53212)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (113728 - 114438 == -710)
			{
				int i = 0;
				if (184350 - 370942 != -186591)
				{
					CharacterControl[] array2 = array;
					if (266678 - 2402 != 264277)
					{
						int length = array2.Length;
						if (218123 - 518208 == -300085)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (249143 - 225523 != 23620)
								{
									goto IL_E0;
								}
								i++;
								if (145267 - 299234 == -153966)
								{
									goto IL_E0;
								}
							}
							if (204156 - 236489 == -32333)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007991 RID: 31121 RVA: 0x01008D58 File Offset: 0x01006F58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (5515 - 245323 != -239807)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (100088 - 581242 != -481153)
			{
				Game.mGameState = eGameState.Ready;
				if (201553 - 438115 == -236562)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (67974 - 225876 == -157902)
					{
						this.g5jck2uPi8h = playerSlot;
						if (139351 - 162668 == -23317)
						{
							if (133327 - 169529 == -36202)
							{
								GameObject gameObject = null;
								if (92281 - 40742 != 51540)
								{
									GameObject gameObject2;
									if (playerSlot > 1)
									{
										if (212150 - 7800 != 204350)
										{
											continue;
										}
										if (playerSlot <= 6)
										{
											if (199914 - 207439 == -7524)
											{
												continue;
											}
											gameObject2 = GameObject.Find("StartPoint" + playerSlot);
											if (90676 - 207506 != -116830)
											{
												continue;
											}
											gameObject = GameObject.Find("StartCamera" + playerSlot);
											if (273176 - 377123 != -103946)
											{
												goto IL_167;
											}
											continue;
										}
									}
									gameObject2 = GameObject.Find("StartPoint1");
									if (21697 - 58448 != -36751)
									{
										continue;
									}
									IL_167:
									if (gameObject2)
									{
										if (136311 - 284147 != -147836)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (98723 - 405409 != -306686)
										{
											continue;
										}
									}
									if (!gameObject)
									{
										break;
									}
									if (284987 - 194949 != 90039)
									{
										this.transform.position = gameObject.transform.position;
										if (95408 - 92333 != 3076)
										{
											this.transform.rotation = gameObject.transform.rotation;
											if (241954 - 478415 != -236460)
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

	// Token: 0x06007992 RID: 31122 RVA: 0x0100900C File Offset: 0x0100720C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M306_FireCaveEntrance2.$StartGame$38393(this).GetEnumerator();
	}

	// Token: 0x06007993 RID: 31123 RVA: 0x0100901C File Offset: 0x0100721C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007994 RID: 31124 RVA: 0x01009020 File Offset: 0x01007220
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (96202 - 177274 != -81072)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (121510 - 325303 != -203792)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (77958 - 389526 == -311568)
				{
					hashtable.Add(43, PlayerData.UID);
					if (81466 - 124269 != -42802)
					{
						hashtable.Add(73, nType);
						if (276908 - 328815 != -51906)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (141607 - 471804 == -330197)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (295967 - 112696 != 183272)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (42403 - 377807 == -335404)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (86585 - 47482 != 39104)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (46478 - 283565 != -237086)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (144724 - 55933 != 88792)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (295684 - 287062 == 8622)
													{
														this.IKQckQ1uXHO.OpCustom(63, hashtable, true);
														if (19195 - 242430 == -223235)
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

	// Token: 0x06007995 RID: 31125 RVA: 0x01009304 File Offset: 0x01007504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (255074 - 24793 != 230282)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (233351 - 191855 == 41496)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (31469 - 521905 == -490436)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (192436 - 250467 != -58030)
						{
							if (this.NDlckOVNA2u <= 0)
							{
								break;
							}
							if (209438 - 386549 == -177111)
							{
								this.NDlckOVNA2u--;
								if (299560 - 322678 != -23117)
								{
									if (this.NDlckOVNA2u != 0)
									{
										break;
									}
									if (257752 - 86516 != 171237)
									{
										Game.setGameState(eGameState.Ready);
										if (138621 - 136286 == 2335)
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
						if (197654 - 331712 != -134057)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (199242 - 190589 == 8653)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007996 RID: 31126 RVA: 0x01009494 File Offset: 0x01007694
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06007997 RID: 31127 RVA: 0x010094A8 File Offset: 0x010076A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (157517 - 118350 != 39167)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (181085 - 178149 != 2937)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (294730 - 205440 == 89290)
				{
					if (!characterControl)
					{
						break;
					}
					if (196006 - 210990 != -14983)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (114973 - 502049 != -387075)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (87437 - 477473 == -390036)
							{
								string type = characterControl.Type;
								if (203074 - 34290 == 168784)
								{
									if (type == "Phoenix1")
									{
										if (70481 - 450489 == -380007)
										{
											continue;
										}
									}
									else if (type == "Phoenix2")
									{
										if (17461 - 47796 != -30335)
										{
											continue;
										}
									}
									else if (type == "Phoenix3")
									{
										if (156654 - 446359 == -289704)
										{
											continue;
										}
									}
									else if (type == "Phoenix4")
									{
										if (75631 - 394806 != -319175)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "RockBug"))
										{
											break;
										}
										if (162344 - 298235 != -135891)
										{
											continue;
										}
										Game.sendMissionEvent(3064, 0);
										if (238841 - 12901 != 225941)
										{
											break;
										}
										continue;
									}
									IL_E7:
									Game.sendMissionEvent(3063, 0);
									if (178333 - 354431 != -176098)
									{
										continue;
									}
									break;
									IL_136:
									goto IL_E7;
									goto IL_136;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007998 RID: 31128 RVA: 0x01009700 File Offset: 0x01007900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (217803 - 119229 != 98574)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (106087 - 142014 != -35926)
			{
				hashtable.Add(71, CID);
				if (76179 - 79658 == -3479)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (249361 - 360644 == -111283)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (53159 - 430589 != -377429)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (42109 - 546338 != -504228)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (176968 - 458466 == -281498)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (251407 - 211220 == 40187)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (265719 - 267579 != -1859)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (26804 - 31934 == -5130)
											{
												this.IKQckQ1uXHO.OpCustom(61, hashtable, true);
												if (277295 - 3482 != 273814)
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

	// Token: 0x06007999 RID: 31129 RVA: 0x0100998C File Offset: 0x01007B8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (258637 - 413077 != -154440)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (266347 - 369156 == -102809)
			{
				if (!gameObject)
				{
					break;
				}
				if (199461 - 23920 == 175541)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (291579 - 575144 == -283565)
					{
						playerCameraControl.target = gameObject;
						if (139978 - 30665 != 109314)
						{
							if (Game.useAdvanceMode)
							{
								if (67631 - 510669 != -443038)
								{
									continue;
								}
								Game.loadPlayer();
								if (67839 - 418094 == -350254)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (80395 - 227881 != -147485)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600799A RID: 31130 RVA: 0x01009AC8 File Offset: 0x01007CC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (276877 - 162313 != 114565)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (148641 - 425692 != -277050)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (118755 - 381051 == -262296)
				{
					gameGui.ResetTeamBar();
					if (158134 - 203149 != -45014)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600799B RID: 31131 RVA: 0x01009B74 File Offset: 0x01007D74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M306_FireCaveEntrance2.$onDeadPlayer$38397(this).GetEnumerator();
	}

	// Token: 0x0600799C RID: 31132 RVA: 0x01009B84 File Offset: 0x01007D84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (294398 - 102507 != 191891)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (88554 - 269457 == -180903)
			{
				this.yvlckeLWYJx.target = Game.mPlayer;
				if (156766 - 170998 == -14232)
				{
					this.yvlckeLWYJx.enabled = true;
					if (123962 - 516734 == -392772)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (91592 - 60840 == 30753)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (186881 - 349985 == -163103)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (23572 - 181446 != -157873)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (76258 - 446304 != -370045)
							{
								if (!gameGui)
								{
									break;
								}
								if (131498 - 389290 == -257792)
								{
									gameGui.enabled = true;
									if (55185 - 557576 != -502390)
									{
										gameGui.closeDeadMenu();
										if (88236 - 510101 == -421865)
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

	// Token: 0x0600799D RID: 31133 RVA: 0x01009D30 File Offset: 0x01007F30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (41678 - 296331 != -254652)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (177777 - 119359 == 58418)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (220292 - 331636 != -111343)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (31075 - 290680 == -259605)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600799E RID: 31134 RVA: 0x01009DF4 File Offset: 0x01007FF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600799F RID: 31135 RVA: 0x01009E20 File Offset: 0x01008020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M306_FireCaveEntrance2.$ReturnToTown$38403(this).GetEnumerator();
	}

	// Token: 0x060079A0 RID: 31136 RVA: 0x01009E30 File Offset: 0x01008030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M306_FireCaveEntrance2.$ReturnToGuild$38408(this).GetEnumerator();
	}

	// Token: 0x060079A1 RID: 31137 RVA: 0x01009E40 File Offset: 0x01008040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M306_FireCaveEntrance2.$ReturnToCamp$38412(this).GetEnumerator();
	}

	// Token: 0x060079A2 RID: 31138 RVA: 0x01009E50 File Offset: 0x01008050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (181200 - 212370 != -31169)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (2358 - 241963 == -239605)
			{
				Hashtable hashtable = new Hashtable();
				if (292679 - 530502 == -237823)
				{
					hashtable.Add(43, PlayerData.UID);
					if (158101 - 284897 != -126795)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (230116 - 37294 != 192823)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060079A3 RID: 31139 RVA: 0x01009F28 File Offset: 0x01008128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060079A4 RID: 31140 RVA: 0x01009F3C File Offset: 0x0100813C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (104300 - 337531 != -233230)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (81578 - 64930 == 16648)
			{
				Hashtable hashtable = new Hashtable();
				if (102666 - 574992 == -472326)
				{
					if (Game.mNextGameCode == 30)
					{
						if (274883 - 233851 == 41033)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (108240 - 149171 == -40930)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (26477 - 391499 == -365021)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (239495 - 63410 != 176085)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (34069 - 86765 != -52696)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (4260 - 327693 == -323432)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (102151 - 153798 != -51647)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (226164 - 478266 == -252101)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (187450 - 404808 == -217357)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (175562 - 378204 == -202641)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (54814 - 134756 != -79942)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (230816 - 510123 == -279306)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (50134 - 212300 == -162165)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (7934 - 257429 != -249495)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (40579 - 36232 != 4347)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (163337 - 405616 != -242279)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (69910 - 445163 == -375252)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (246281 - 395332 != -149051)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (65494 - 381171 == -315676)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (54955 - 6742 == 48214)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (192912 - 381768 != -188856)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (219576 - 554143 != -334567)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (115020 - 78775 == 36246)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (243538 - 358406 != -114868)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (126604 - 110687 == 15918)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (124408 - 180534 != -56126)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (166875 - 408038 != -241163)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (97361 - 560623 != -463262)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (297931 - 24952 == 272979)
					{
						this.IKQckQ1uXHO.OpCustom(42, hashtable, true);
						if (71527 - 79754 != -8226)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060079A5 RID: 31141 RVA: 0x0100A4F0 File Offset: 0x010086F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060079A6 RID: 31142 RVA: 0x0100A500 File Offset: 0x01008700
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060079A7 RID: 31143 RVA: 0x0100A504 File Offset: 0x01008704
	internal static bool GRnwJQpqMKkukFgCbZOj()
	{
		return true;
	}

	// Token: 0x060079A8 RID: 31144 RVA: 0x0100A508 File Offset: 0x01008708
	internal static bool Ok5ajspqx9DRuwp11U1T()
	{
		return false;
	}

	// Token: 0x04007C0D RID: 31757
	private LitePeer IKQckQ1uXHO;

	// Token: 0x04007C0E RID: 31758
	private PlayerCameraControl yvlckeLWYJx;

	// Token: 0x04007C0F RID: 31759
	private float iBEckIiKFOV;

	// Token: 0x04007C10 RID: 31760
	private int x2IckJZcTTX;

	// Token: 0x04007C11 RID: 31761
	private int JMxck64hZDN;

	// Token: 0x04007C12 RID: 31762
	private int ju1cktX0Fgg;

	// Token: 0x04007C13 RID: 31763
	private int NsickX9NOC7;

	// Token: 0x04007C14 RID: 31764
	public AudioClip battleMusic;

	// Token: 0x04007C15 RID: 31765
	private int NDlckOVNA2u;

	// Token: 0x04007C16 RID: 31766
	private int g5jck2uPi8h;

	// Token: 0x02001488 RID: 5256
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onEnterBossZone$38372 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060079A9 RID: 31145 RVA: 0x0100A50C File Offset: 0x0100870C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onEnterBossZone$38372(bool isMine, M306_FireCaveEntrance2 self_)
		{
			if (95616 - 229757 != -134141)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (70783 - 488066 == -417283)
				{
					base..ctor();
					if (113121 - 252959 == -139838)
					{
						this.$isMine$38382 = isMine;
						if (183135 - 455131 != -271995)
						{
							this.$self_$38383 = self_;
							if (245648 - 282239 == -36591)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060079AA RID: 31146 RVA: 0x0100A5C8 File Offset: 0x010087C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance2.$onEnterBossZone$38372.$(this.$isMine$38382, this.$self_$38383);
		}

		// Token: 0x060079AB RID: 31147 RVA: 0x0100A5DC File Offset: 0x010087DC
		internal static bool HPtnjhpqgGmGBeCY3LBx()
		{
			return true;
		}

		// Token: 0x060079AC RID: 31148 RVA: 0x0100A5E0 File Offset: 0x010087E0
		internal static bool ia8ImppqfIlhSAaa4P7s()
		{
			return false;
		}

		// Token: 0x04007C17 RID: 31767
		internal bool $isMine$38382;

		// Token: 0x04007C18 RID: 31768
		internal M306_FireCaveEntrance2 $self_$38383;

		// Token: 0x02001489 RID: 5257
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060079AD RID: 31149 RVA: 0x0100A5E4 File Offset: 0x010087E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(bool isMine, M306_FireCaveEntrance2 self_)
			{
				if (172752 - 64777 != 107975)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (10520 - 471783 == -461263)
					{
						base..ctor();
						if (103150 - 300838 == -197688)
						{
							this.$isMine$38380 = isMine;
							if (277391 - 370732 != -93340)
							{
								this.$self_$38381 = self_;
								if (295873 - 432417 == -136544)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060079AE RID: 31150 RVA: 0x0100A6A0 File Offset: 0x010088A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (297547 - 286570 != 10977)
				{
				}
				for (;;)
				{
					IL_116:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_99B;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (100800 - 407630 != -306830)
							{
								continue;
							}
							goto IL_72C;
						}
						else
						{
							this.$startPoint$38375 = GameObject.Find("StartPoint" + (this.$self_$38381.g5jck2uPi8h + 4));
							if (283816 - 316947 != -33131)
							{
								continue;
							}
							if (this.$startPoint$38375)
							{
								if (247857 - 385516 == -137658)
								{
									continue;
								}
								if (Game.mPlayer)
								{
									if (212101 - 254478 != -42377)
									{
										continue;
									}
									Game.mPlayer.transform.position = this.$startPoint$38375.transform.position;
									if (146478 - 138032 == 8447)
									{
										continue;
									}
									Game.mPlayer.transform.rotation = this.$startPoint$38375.transform.rotation;
									if (188058 - 101840 != 86218)
									{
										continue;
									}
									Game.mPlayer.SendMessage("PositionEvent");
									if (153257 - 569377 == -416119)
									{
										continue;
									}
								}
							}
							this.$startCamera$38376 = GameObject.Find("StartCamera" + (this.$self_$38381.g5jck2uPi8h + 4));
							if (37814 - 372299 == -334484)
							{
								continue;
							}
							if (this.$startCamera$38376)
							{
								if (67884 - 142003 == -74118)
								{
									continue;
								}
								if (Game.mPlayer)
								{
									if (164342 - 506883 == -342540)
									{
										continue;
									}
									this.$self_$38381.transform.position = this.$startCamera$38376.transform.position;
									if (268455 - 301265 == -32809)
									{
										continue;
									}
									this.$self_$38381.transform.rotation = this.$startCamera$38376.transform.rotation;
									if (146505 - 114455 == 32051)
									{
										continue;
									}
								}
							}
							if (!this.$isMine$38380)
							{
								goto IL_8A1;
							}
							if (133124 - 93859 != 39265)
							{
								continue;
							}
							this.$i$38377 = 1;
							if (152632 - 134030 != 18602)
							{
								continue;
							}
							while (this.$i$38377 <= 3)
							{
								this.$SpawnPoint$38378 = GameObject.Find("SpawnPoint" + this.$i$38377);
								if (27794 - 257762 == -229967)
								{
									goto IL_116;
								}
								if (this.$SpawnPoint$38378)
								{
									if (91368 - 537604 == -446235)
									{
										goto IL_116;
									}
									this.$self_$38381.createActor("RockBug", 6, this.$SpawnPoint$38378.transform.position, this.$SpawnPoint$38378.transform.forward);
									if (219753 - 172308 == 47446)
									{
										goto IL_116;
									}
								}
								this.$i$38377++;
								if (150959 - 49551 != 101408)
								{
									goto IL_116;
								}
							}
							if (130711 - 231884 != -101172)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (62807 - 20677 != 42131)
							{
								goto Block_63;
							}
							continue;
						}
						else
						{
							this.$self_$38381.SendMessage("fadeIn");
							if (125000 - 369337 != -244336)
							{
								goto Block_33;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (64013 - 22725 != 41289)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$38374.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (232175 - 35460 != 196716)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (131486 - 174111 != -42625)
							{
								continue;
							}
							goto IL_57D;
						}
						else
						{
							this.$mStoryGui$38374.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M306_FireCaveEntrance", 3061), eTalkType.friend);
							if (1405 - 553971 == -552565)
							{
								continue;
							}
							this.$mGameVolume$38379 = this.$self_$38381.audio.volume;
							if (161849 - 43947 != 117902)
							{
								continue;
							}
							this.$self_$38381.audio.volume = (float)0;
							if (160393 - 527405 != -367011)
							{
								goto Block_57;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (297899 - 306142 != -8243)
							{
								continue;
							}
							goto IL_702;
						}
						else
						{
							this.$mStoryGui$38374.close();
							if (229265 - 348570 == -119304)
							{
								continue;
							}
							this.$mGameGui$38373.enabled = true;
							if (247284 - 33239 != 214045)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (178767 - 251533 == -72765)
							{
								continue;
							}
							this.$self_$38381.x2IckJZcTTX = 3;
							if (86196 - 420607 == -334410)
							{
								continue;
							}
							if (!this.$self_$38381.battleMusic)
							{
								goto IL_666;
							}
							if (159855 - 410432 == -250576)
							{
								continue;
							}
							this.$self_$38381.audio.clip = this.$self_$38381.battleMusic;
							if (209395 - 294566 != -85171)
							{
								continue;
							}
							this.$self_$38381.audio.volume = this.$mGameVolume$38379;
							if (63913 - 592340 == -528426)
							{
								continue;
							}
							if (this.$self_$38381.audio.isPlaying)
							{
								goto IL_666;
							}
							if (106823 - 144914 != -38091)
							{
								continue;
							}
							if (Game.volume <= 0)
							{
								goto IL_666;
							}
							if (175536 - 564776 == -389239)
							{
								continue;
							}
							this.$self_$38381.audio.Play();
							if (67748 - 583441 != -515692)
							{
								goto IL_666;
							}
							continue;
						}
						break;
					default:
						if (122677 - 498707 != -376030)
						{
							continue;
						}
						break;
					}
					if (this.$self_$38381.x2IckJZcTTX >= 3)
					{
						goto IL_627;
					}
					if (3861 - 41945 != -38084)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (279940 - 429628 != -149688)
						{
							continue;
						}
						goto IL_627;
					}
					else
					{
						this.$mGameGui$38373 = (GameGui)this.$self_$38381.GetComponent(typeof(GameGui));
						if (112780 - 303711 != -190931)
						{
							continue;
						}
						this.$mStoryGui$38374 = (StoryGui)this.$self_$38381.GetComponent(typeof(StoryGui));
						if (88692 - 450413 == -361720)
						{
							continue;
						}
						if (this.$mGameGui$38373)
						{
							if (100115 - 243515 != -143400)
							{
								continue;
							}
							if (this.$mStoryGui$38374)
							{
								if (5158 - 83264 != -78106)
								{
									continue;
								}
								this.$self_$38381.x2IckJZcTTX = 1;
								if (292390 - 476237 == -183846)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (266393 - 52912 != 213481)
								{
									continue;
								}
								this.$mGameGui$38373.close();
								if (126474 - 69105 == 57370)
								{
									continue;
								}
								this.$self_$38381.SendMessage("fadeOut");
								if (87259 - 164987 != -77728)
								{
									continue;
								}
								break;
							}
						}
					}
					IL_666:
					this.YieldDefault(1);
					if (258984 - 365280 == -106296)
					{
						goto IL_99B;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_25:
				goto IL_99B;
				Block_33:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_36:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_39:
				goto IL_8A1;
				IL_57D:
				IL_627:
				IL_702:
				IL_72C:
				goto IL_99B;
				Block_57:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_8A1:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_63:
				IL_99B:
				return false;
			}

			// Token: 0x060079AF RID: 31151 RVA: 0x0100B05C File Offset: 0x0100925C
			internal static bool hjZ2XfpqnLsbRIGYB3Nj()
			{
				return true;
			}

			// Token: 0x060079B0 RID: 31152 RVA: 0x0100B060 File Offset: 0x01009260
			internal static bool hqOsU5pq6IjYA55wh5n6()
			{
				return false;
			}

			// Token: 0x04007C19 RID: 31769
			internal GameGui $mGameGui$38373;

			// Token: 0x04007C1A RID: 31770
			internal StoryGui $mStoryGui$38374;

			// Token: 0x04007C1B RID: 31771
			internal GameObject $startPoint$38375;

			// Token: 0x04007C1C RID: 31772
			internal GameObject $startCamera$38376;

			// Token: 0x04007C1D RID: 31773
			internal int $i$38377;

			// Token: 0x04007C1E RID: 31774
			internal GameObject $SpawnPoint$38378;

			// Token: 0x04007C1F RID: 31775
			internal float $mGameVolume$38379;

			// Token: 0x04007C20 RID: 31776
			internal bool $isMine$38380;

			// Token: 0x04007C21 RID: 31777
			internal M306_FireCaveEntrance2 $self_$38381;
		}
	}

	// Token: 0x0200148A RID: 5258
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38384 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060079B1 RID: 31153 RVA: 0x0100B064 File Offset: 0x01009264
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38384(Hashtable data, M306_FireCaveEntrance2 self_)
		{
			if (48468 - 116097 != -67628)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (278111 - 87594 != 190518)
				{
					base..ctor();
					if (250117 - 398705 != -148587)
					{
						this.$data$38391 = data;
						if (35173 - 418499 != -383325)
						{
							this.$self_$38392 = self_;
							if (88148 - 177382 == -89234)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060079B2 RID: 31154 RVA: 0x0100B120 File Offset: 0x01009320
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance2.$onGameComplete$38384.$(this.$data$38391, this.$self_$38392);
		}

		// Token: 0x060079B3 RID: 31155 RVA: 0x0100B134 File Offset: 0x01009334
		internal static bool TZFYASpqiSALV5HfDbDQ()
		{
			return true;
		}

		// Token: 0x060079B4 RID: 31156 RVA: 0x0100B138 File Offset: 0x01009338
		internal static bool XGlGcDpqKJstAJKjNi96()
		{
			return false;
		}

		// Token: 0x04007C22 RID: 31778
		internal Hashtable $data$38391;

		// Token: 0x04007C23 RID: 31779
		internal M306_FireCaveEntrance2 $self_$38392;

		// Token: 0x0200148B RID: 5259
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060079B5 RID: 31157 RVA: 0x0100B13C File Offset: 0x0100933C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M306_FireCaveEntrance2 self_)
			{
				if (81424 - 29102 != 52323)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (190379 - 141672 == 48707)
					{
						base..ctor();
						if (39648 - 102743 != -63094)
						{
							this.$data$38389 = data;
							if (74768 - 425134 == -350366)
							{
								this.$self_$38390 = self_;
								if (119257 - 116437 != 2821)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060079B6 RID: 31158 RVA: 0x0100B1F8 File Offset: 0x010093F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150277 - 50534 != 99744)
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
						this.$mCompleteGui$38386 = (CompleteGui)this.$self_$38390.GetComponent(typeof(CompleteGui));
						if (209030 - 352751 == -143720)
						{
							continue;
						}
						this.$mCompleteGui$38386.Init();
						if (255484 - 344514 != -89030)
						{
							continue;
						}
						this.$mCompleteGui$38386.readData(this.$data$38389);
						if (18980 - 491831 == -472850)
						{
							continue;
						}
						if (this.$result$38385 == 1)
						{
							if (30521 - 359100 != -328579)
							{
								continue;
							}
							this.$mCompleteGui$38386.displayResult(eCompleteType.Success);
							if (191026 - 538159 != -347133)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38386.displayResult(eCompleteType.Failed);
							if (230369 - 276246 != -45877)
							{
								continue;
							}
						}
						this.$mGameGui$38387 = (GameGui)this.$self_$38390.GetComponent(typeof(GameGui));
						if (7114 - 250277 == -243162)
						{
							continue;
						}
						this.$mStoryGui$38388 = (StoryGui)this.$self_$38390.GetComponent(typeof(StoryGui));
						if (247078 - 162855 != 84223)
						{
							continue;
						}
						if (this.$mGameGui$38387)
						{
							if (86403 - 84189 == 2215)
							{
								continue;
							}
							this.$mGameGui$38387.close();
							if (280006 - 296625 != -16619)
							{
								continue;
							}
						}
						if (this.$mStoryGui$38388)
						{
							if (173956 - 583216 == -409259)
							{
								continue;
							}
							this.$mStoryGui$38388.close();
							if (4916 - 63960 != -59044)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (299504 - 275897 != 23608)
						{
							goto Block_10;
						}
						continue;
					default:
						if (141971 - 68187 == 73785)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$38389[31]);
					if (99336 - 65736 != 33601)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (129802 - 60160 == 69642)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (225220 - 413842 != -188621)
							{
								this.$result$38385 = RuntimeServices.UnboxInt32(this.$data$38389[31]);
								if (146388 - 143589 == 2799)
								{
									goto IL_1D0;
								}
							}
						}
					}
				}
				Block_10:
				goto IL_352;
				IL_1D0:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x060079B7 RID: 31159 RVA: 0x0100B56C File Offset: 0x0100976C
			internal static bool oa259opqdpkjo9bQQtLC()
			{
				return true;
			}

			// Token: 0x060079B8 RID: 31160 RVA: 0x0100B570 File Offset: 0x01009770
			internal static bool tRbWGqpqJNfB74lEU2O1()
			{
				return false;
			}

			// Token: 0x04007C24 RID: 31780
			internal int $result$38385;

			// Token: 0x04007C25 RID: 31781
			internal CompleteGui $mCompleteGui$38386;

			// Token: 0x04007C26 RID: 31782
			internal GameGui $mGameGui$38387;

			// Token: 0x04007C27 RID: 31783
			internal StoryGui $mStoryGui$38388;

			// Token: 0x04007C28 RID: 31784
			internal Hashtable $data$38389;

			// Token: 0x04007C29 RID: 31785
			internal M306_FireCaveEntrance2 $self_$38390;
		}
	}

	// Token: 0x0200148C RID: 5260
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38393 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060079B9 RID: 31161 RVA: 0x0100B574 File Offset: 0x01009774
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38393(M306_FireCaveEntrance2 self_)
		{
			if (222040 - 475906 != -253866)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (101096 - 91347 == 9749)
				{
					base..ctor();
					if (254921 - 396926 == -142005)
					{
						this.$self_$38396 = self_;
						if (201876 - 130248 != 71629)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x0100B60C File Offset: 0x0100980C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance2.$StartGame$38393.$(this.$self_$38396);
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x0100B61C File Offset: 0x0100981C
		internal static bool j0o3afpqDMLqxD0hWicJ()
		{
			return true;
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x0100B620 File Offset: 0x01009820
		internal static bool W8SI7mpqv53qHPjk1ZFs()
		{
			return false;
		}

		// Token: 0x04007C2A RID: 31786
		internal M306_FireCaveEntrance2 $self_$38396;

		// Token: 0x0200148D RID: 5261
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060079BD RID: 31165 RVA: 0x0100B624 File Offset: 0x01009824
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M306_FireCaveEntrance2 self_)
			{
				if (71170 - 549993 != -478823)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (120288 - 303703 == -183415)
					{
						base..ctor();
						if (45439 - 251116 != -205676)
						{
							this.$self_$38395 = self_;
							if (8958 - 44824 != -35865)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060079BE RID: 31166 RVA: 0x0100B6BC File Offset: 0x010098BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (105016 - 435400 != -330383)
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
						if (42066 - 572321 == -530254)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (231350 - 474959 == -243608)
						{
							continue;
						}
						this.YieldDefault(1);
						if (57027 - 404431 != -347404)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (67761 - 324725 != -256964)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (47751 - 310077 != -262325)
					{
						Game.mGameState = eGameState.Start;
						if (259668 - 35276 != 224393)
						{
							Game.mStateTime = Time.time;
							if (195687 - 487853 == -292166)
							{
								this.$mGameGui$38394 = (GameGui)this.$self_$38395.GetComponent(typeof(GameGui));
								if (59141 - 264154 == -205013)
								{
									this.$mGameGui$38394.enabled = true;
									if (13895 - 313881 == -299986)
									{
										this.$self_$38395.SendMessage("fadeIn");
										if (78014 - 345410 != -267395)
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

			// Token: 0x060079BF RID: 31167 RVA: 0x0100B894 File Offset: 0x01009A94
			internal static bool uddS7UpqRS1rsauuG4XV()
			{
				return true;
			}

			// Token: 0x060079C0 RID: 31168 RVA: 0x0100B898 File Offset: 0x01009A98
			internal static bool zSlVompqwaA8NHeNM960()
			{
				return false;
			}

			// Token: 0x04007C2B RID: 31787
			internal GameGui $mGameGui$38394;

			// Token: 0x04007C2C RID: 31788
			internal M306_FireCaveEntrance2 $self_$38395;
		}
	}

	// Token: 0x0200148E RID: 5262
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38397 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060079C1 RID: 31169 RVA: 0x0100B89C File Offset: 0x01009A9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38397(M306_FireCaveEntrance2 self_)
		{
			if (119959 - 562270 != -442310)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (138162 - 598053 == -459891)
				{
					base..ctor();
					if (61992 - 263183 != -201190)
					{
						this.$self_$38402 = self_;
						if (128999 - 246064 == -117065)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060079C2 RID: 31170 RVA: 0x0100B934 File Offset: 0x01009B34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance2.$onDeadPlayer$38397.$(this.$self_$38402);
		}

		// Token: 0x060079C3 RID: 31171 RVA: 0x0100B944 File Offset: 0x01009B44
		internal static bool gmuisepqq82TQeDpTjdr()
		{
			return true;
		}

		// Token: 0x060079C4 RID: 31172 RVA: 0x0100B948 File Offset: 0x01009B48
		internal static bool HOxXqRpq7S4eJU9UwZV2()
		{
			return false;
		}

		// Token: 0x04007C2D RID: 31789
		internal M306_FireCaveEntrance2 $self_$38402;

		// Token: 0x0200148F RID: 5263
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060079C5 RID: 31173 RVA: 0x0100B94C File Offset: 0x01009B4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M306_FireCaveEntrance2 self_)
			{
				if (287420 - 511416 != -223995)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (171736 - 281406 == -109670)
					{
						base..ctor();
						if (146589 - 332132 != -185542)
						{
							this.$self_$38401 = self_;
							if (54194 - 549906 != -495711)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060079C6 RID: 31174 RVA: 0x0100B9E4 File Offset: 0x01009BE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (63721 - 26619 != 37103)
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
							goto IL_19E;
						}
						if (220744 - 206899 == 13846)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (242874 - 300108 != -57233)
							{
								goto IL_19E;
							}
							continue;
						}
						IL_11D:
						this.YieldDefault(1);
						if (198212 - 82 != 198130)
						{
							continue;
						}
						goto IL_2F9;
						IL_19E:
						Game.mGameState = eGameState.Hold;
						if (17754 - 466910 != -449156)
						{
							continue;
						}
						this.$mStoryGui$38398 = (StoryGui)this.$self_$38401.GetComponent(typeof(StoryGui));
						if (109041 - 242537 == -133495)
						{
							continue;
						}
						if (this.$mStoryGui$38398)
						{
							if (132780 - 169671 == -36890)
							{
								continue;
							}
							this.$mStoryGui$38398.close();
							if (159712 - 325675 != -165963)
							{
								continue;
							}
						}
						this.$mChangeGui$38399 = (ChangeGui)this.$self_$38401.GetComponent(typeof(ChangeGui));
						if (114971 - 392146 != -277175)
						{
							continue;
						}
						if (this.$mChangeGui$38399)
						{
							if (155055 - 134530 != 20525)
							{
								continue;
							}
							this.$mChangeGui$38399.close();
							if (182799 - 370209 == -187409)
							{
								continue;
							}
						}
						this.$mGameGui$38400 = (GameGui)this.$self_$38401.GetComponent(typeof(GameGui));
						if (73904 - 179914 != -106010)
						{
							continue;
						}
						if (!this.$mGameGui$38400)
						{
							goto IL_11D;
						}
						if (250670 - 260002 == -9331)
						{
							continue;
						}
						if (!this.$mGameGui$38400.enabled)
						{
							if (107336 - 417912 == -310575)
							{
								continue;
							}
							this.$mGameGui$38400.enabled = true;
							if (31475 - 595966 != -564491)
							{
								continue;
							}
						}
						this.$mGameGui$38400.openDeadMenu();
						if (191168 - 243238 != -52069)
						{
							goto IL_11D;
						}
						continue;
					default:
						if (234534 - 599926 != -365392)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (260776 - 629 == 260148);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060079C7 RID: 31175 RVA: 0x0100BCFC File Offset: 0x01009EFC
			internal static bool qrQPdnpqPvylbwg78ciG()
			{
				return true;
			}

			// Token: 0x060079C8 RID: 31176 RVA: 0x0100BD00 File Offset: 0x01009F00
			internal static bool pD46DXpq0LHIkkr0xo3j()
			{
				return false;
			}

			// Token: 0x04007C2E RID: 31790
			internal StoryGui $mStoryGui$38398;

			// Token: 0x04007C2F RID: 31791
			internal ChangeGui $mChangeGui$38399;

			// Token: 0x04007C30 RID: 31792
			internal GameGui $mGameGui$38400;

			// Token: 0x04007C31 RID: 31793
			internal M306_FireCaveEntrance2 $self_$38401;
		}
	}

	// Token: 0x02001490 RID: 5264
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38403 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060079C9 RID: 31177 RVA: 0x0100BD04 File Offset: 0x01009F04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38403(M306_FireCaveEntrance2 self_)
		{
			if (278319 - 390059 != -111740)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (106011 - 169246 == -63235)
				{
					base..ctor();
					if (92982 - 378690 == -285708)
					{
						this.$self_$38407 = self_;
						if (225845 - 182423 != 43423)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060079CA RID: 31178 RVA: 0x0100BD9C File Offset: 0x01009F9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance2.$ReturnToTown$38403.$(this.$self_$38407);
		}

		// Token: 0x060079CB RID: 31179 RVA: 0x0100BDAC File Offset: 0x01009FAC
		internal static bool dNdN1jpqb0e59NFGJSIA()
		{
			return true;
		}

		// Token: 0x060079CC RID: 31180 RVA: 0x0100BDB0 File Offset: 0x01009FB0
		internal static bool aEhlFSpquQUSTPHWa4f5()
		{
			return false;
		}

		// Token: 0x04007C32 RID: 31794
		internal M306_FireCaveEntrance2 $self_$38407;

		// Token: 0x02001491 RID: 5265
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060079CD RID: 31181 RVA: 0x0100BDB4 File Offset: 0x01009FB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M306_FireCaveEntrance2 self_)
			{
				if (45563 - 129793 != -84229)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (217239 - 342626 == -125387)
					{
						base..ctor();
						if (108085 - 525429 == -417344)
						{
							this.$self_$38406 = self_;
							if (158621 - 14658 != 143964)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060079CE RID: 31182 RVA: 0x0100BE4C File Offset: 0x0100A04C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (215721 - 444101 != -228380)
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
						this.$self_$38406.LeaveGame();
						if (236201 - 181520 == 54682)
						{
							continue;
						}
						this.YieldDefault(1);
						if (216448 - 21006 != 195442)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (245246 - 450553 != -205307)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (70858 - 501506 == -430648)
					{
						Game.mStateTime = Time.time;
						if (116331 - 539029 == -422698)
						{
							this.$$switch$6646$38404 = PlayerData.SaveGuild;
							if (154739 - 486359 == -331620)
							{
								if (this.$$switch$6646$38404 == 1)
								{
									if (173176 - 180959 != -7783)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (40131 - 321651 != -281520)
									{
										continue;
									}
								}
								else if (this.$$switch$6646$38404 == 2)
								{
									if (64836 - 533734 == -468897)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (111362 - 579244 != -467882)
									{
										continue;
									}
								}
								else if (this.$$switch$6646$38404 == 3)
								{
									if (19994 - 268153 != -248159)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (112197 - 115497 != -3300)
									{
										continue;
									}
								}
								else if (this.$$switch$6646$38404 == 4)
								{
									if (253815 - 246892 == 6924)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (288271 - 363875 == -75603)
									{
										continue;
									}
								}
								else if (this.$$switch$6646$38404 == 5)
								{
									if (210044 - 397122 == -187077)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (270282 - 417264 == -146981)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (265442 - 84449 != 180993)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (229204 - 129171 != 100033)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (67061 - 169306 == -102244)
									{
										continue;
									}
								}
								this.$mGameGui$38405 = (GameGui)this.$self_$38406.GetComponent(typeof(GameGui));
								if (245702 - 91830 == 153872)
								{
									if (this.$mGameGui$38405)
									{
										if (240829 - 184670 != 56159)
										{
											continue;
										}
										this.$mGameGui$38405.close();
										if (202297 - 263972 == -61674)
										{
											continue;
										}
									}
									this.$self_$38406.SendMessage("fadeOut");
									if (288199 - 220297 != 67903)
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

			// Token: 0x060079CF RID: 31183 RVA: 0x0100C218 File Offset: 0x0100A418
			internal static bool zMAXEfpqIvB3lIb3sQO0()
			{
				return true;
			}

			// Token: 0x060079D0 RID: 31184 RVA: 0x0100C21C File Offset: 0x0100A41C
			internal static bool KM5hmrpqB8GH3KbvIjsU()
			{
				return false;
			}

			// Token: 0x04007C33 RID: 31795
			internal int $$switch$6646$38404;

			// Token: 0x04007C34 RID: 31796
			internal GameGui $mGameGui$38405;

			// Token: 0x04007C35 RID: 31797
			internal M306_FireCaveEntrance2 $self_$38406;
		}
	}

	// Token: 0x02001492 RID: 5266
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38408 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060079D1 RID: 31185 RVA: 0x0100C220 File Offset: 0x0100A420
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38408(M306_FireCaveEntrance2 self_)
		{
			if (141922 - 375769 != -233847)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (98591 - 566849 == -468258)
				{
					base..ctor();
					if (226198 - 359539 == -133341)
					{
						this.$self_$38411 = self_;
						if (245220 - 148639 == 96581)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060079D2 RID: 31186 RVA: 0x0100C2B8 File Offset: 0x0100A4B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance2.$ReturnToGuild$38408.$(this.$self_$38411);
		}

		// Token: 0x060079D3 RID: 31187 RVA: 0x0100C2C8 File Offset: 0x0100A4C8
		internal static bool hErGTPpqeN82Aaq8AQBf()
		{
			return true;
		}

		// Token: 0x060079D4 RID: 31188 RVA: 0x0100C2CC File Offset: 0x0100A4CC
		internal static bool Of4eTrpqr7NGNp2gRrRl()
		{
			return false;
		}

		// Token: 0x04007C36 RID: 31798
		internal M306_FireCaveEntrance2 $self_$38411;

		// Token: 0x02001493 RID: 5267
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060079D5 RID: 31189 RVA: 0x0100C2D0 File Offset: 0x0100A4D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M306_FireCaveEntrance2 self_)
			{
				if (100110 - 130223 != -30113)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (102724 - 248006 == -145282)
					{
						base..ctor();
						if (266947 - 564051 != -297103)
						{
							this.$self_$38410 = self_;
							if (60372 - 331025 != -270652)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060079D6 RID: 31190 RVA: 0x0100C368 File Offset: 0x0100A568
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (64428 - 277996 != -213567)
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
						this.$self_$38410.LeaveGame();
						if (182619 - 596674 == -414054)
						{
							continue;
						}
						this.YieldDefault(1);
						if (5638 - 112607 != -106969)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (88010 - 397740 != -309730)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (199419 - 113693 != 85727)
					{
						Game.mStateTime = Time.time;
						if (281445 - 10752 != 270694)
						{
							Game.mNextGameCode = 31;
							if (53528 - 323282 != -269753)
							{
								this.$mGameGui$38409 = (GameGui)this.$self_$38410.GetComponent(typeof(GameGui));
								if (93155 - 21509 != 71647)
								{
									if (this.$mGameGui$38409)
									{
										if (130326 - 491197 != -360871)
										{
											continue;
										}
										this.$mGameGui$38409.close();
										if (215612 - 253000 != -37388)
										{
											continue;
										}
									}
									this.$self_$38410.SendMessage("fadeOut");
									if (206371 - 562102 != -355730)
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

			// Token: 0x060079D7 RID: 31191 RVA: 0x0100C544 File Offset: 0x0100A744
			internal static bool idAVPRpqj9wKO8vo931q()
			{
				return true;
			}

			// Token: 0x060079D8 RID: 31192 RVA: 0x0100C548 File Offset: 0x0100A748
			internal static bool ak6UXZpqhla8EKSoQyNV()
			{
				return false;
			}

			// Token: 0x04007C37 RID: 31799
			internal GameGui $mGameGui$38409;

			// Token: 0x04007C38 RID: 31800
			internal M306_FireCaveEntrance2 $self_$38410;
		}
	}

	// Token: 0x02001494 RID: 5268
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38412 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060079D9 RID: 31193 RVA: 0x0100C54C File Offset: 0x0100A74C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38412(M306_FireCaveEntrance2 self_)
		{
			if (81414 - 442289 != -360874)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (45533 - 397477 == -351944)
				{
					base..ctor();
					if (140655 - 320961 == -180306)
					{
						this.$self_$38416 = self_;
						if (202724 - 526541 == -323817)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060079DA RID: 31194 RVA: 0x0100C5E4 File Offset: 0x0100A7E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M306_FireCaveEntrance2.$ReturnToCamp$38412.$(this.$self_$38416);
		}

		// Token: 0x060079DB RID: 31195 RVA: 0x0100C5F4 File Offset: 0x0100A7F4
		internal static bool iO6EbGpqs2rYXjO1POHH()
		{
			return true;
		}

		// Token: 0x060079DC RID: 31196 RVA: 0x0100C5F8 File Offset: 0x0100A7F8
		internal static bool aUPw3tpq95OpWrfsZUqk()
		{
			return false;
		}

		// Token: 0x04007C39 RID: 31801
		internal M306_FireCaveEntrance2 $self_$38416;

		// Token: 0x02001495 RID: 5269
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060079DD RID: 31197 RVA: 0x0100C5FC File Offset: 0x0100A7FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M306_FireCaveEntrance2 self_)
			{
				if (111760 - 437179 != -325418)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (118431 - 487020 == -368589)
					{
						base..ctor();
						if (225130 - 513351 != -288220)
						{
							this.$self_$38415 = self_;
							if (96622 - 267160 != -170537)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060079DE RID: 31198 RVA: 0x0100C694 File Offset: 0x0100A894
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (289195 - 526930 != -237735)
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
						this.$self_$38415.LeaveGame();
						if (262178 - 359239 == -97060)
						{
							continue;
						}
						this.YieldDefault(1);
						if (45136 - 130933 != -85797)
						{
							continue;
						}
						goto IL_363;
					default:
						if (27730 - 524711 != -496981)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (186395 - 467592 == -281197)
					{
						Game.mStateTime = Time.time;
						if (136799 - 366188 != -229388)
						{
							this.$$switch$6648$38413 = PlayerData.SaveGuild;
							if (186297 - 18906 != 167392)
							{
								if (this.$$switch$6648$38413 == 1)
								{
									if (10937 - 219758 == -208820)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (267131 - 151166 != 115965)
									{
										continue;
									}
								}
								else if (this.$$switch$6648$38413 == 2)
								{
									if (283842 - 335817 == -51974)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (35719 - 224890 == -189170)
									{
										continue;
									}
								}
								else if (this.$$switch$6648$38413 == 3)
								{
									if (115279 - 399215 != -283936)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (103948 - 453268 == -349319)
									{
										continue;
									}
								}
								else if (this.$$switch$6648$38413 == 4)
								{
									if (32546 - 519763 != -487217)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (251060 - 530956 == -279895)
									{
										continue;
									}
								}
								else if (this.$$switch$6648$38413 == 5)
								{
									if (55056 - 39596 == 15461)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (204675 - 209443 != -4768)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (271855 - 19961 == 251895)
									{
										continue;
									}
								}
								this.$mGameGui$38414 = (GameGui)this.$self_$38415.GetComponent(typeof(GameGui));
								if (161700 - 417331 == -255631)
								{
									if (this.$mGameGui$38414)
									{
										if (174789 - 594728 != -419939)
										{
											continue;
										}
										this.$mGameGui$38414.close();
										if (246847 - 291636 == -44788)
										{
											continue;
										}
									}
									this.$self_$38415.SendMessage("fadeOut");
									if (196271 - 188422 == 7849)
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

			// Token: 0x060079DF RID: 31199 RVA: 0x0100CA18 File Offset: 0x0100AC18
			internal static bool gjMuBJpq1ykLZFpRQuHe()
			{
				return true;
			}

			// Token: 0x060079E0 RID: 31200 RVA: 0x0100CA1C File Offset: 0x0100AC1C
			internal static bool fmSdk6pq4uDYDEZvMJPI()
			{
				return false;
			}

			// Token: 0x04007C3A RID: 31802
			internal int $$switch$6648$38413;

			// Token: 0x04007C3B RID: 31803
			internal GameGui $mGameGui$38414;

			// Token: 0x04007C3C RID: 31804
			internal M306_FireCaveEntrance2 $self_$38415;
		}
	}
}
