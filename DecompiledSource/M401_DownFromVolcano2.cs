using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x020014C1 RID: 5313
[Serializable]
public class M401_DownFromVolcano2 : MonoBehaviour
{
	// Token: 0x06007AF1 RID: 31473 RVA: 0x0101D4F0 File Offset: 0x0101B6F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M401_DownFromVolcano2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007AF2 RID: 31474 RVA: 0x0101D500 File Offset: 0x0101B700
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (3158 - 204262 != -201103)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (214538 - 137599 == 76939)
			{
				Game.mGameType = 5;
				if (170635 - 417445 != -246809)
				{
					if (Chat.Initialized)
					{
						if (9378 - 165413 != -156034)
						{
							Chat.ChatDisplay.Clear();
							if (171257 - 367073 != -195815)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (199047 - 88070 != 110978)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007AF3 RID: 31475 RVA: 0x0101D5E4 File Offset: 0x0101B7E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (212514 - 57304 != 155210)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (110156 - 95424 == 14732)
				{
					if (Game.mNextGameCode != 401)
					{
						break;
					}
					if (233966 - 357279 == -123313)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (272056 - 65027 != 207030)
						{
							Game.nextGame();
							if (216077 - 256362 != -40284)
							{
								this.yS7ck0YYu7A = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (52546 - 305632 == -253086)
								{
									this.uh7ckBm4Ac5 = PhotonClient.Connection;
									if (169650 - 27087 == 142563)
									{
										PhotonClient.ActorNrList.Clear();
										if (43230 - 346189 == -302959)
										{
											this.InitGame();
											if (225028 - 585949 == -360921)
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
				if (299890 - 35569 == 264321)
				{
					Game.mGameType = 99;
					if (210615 - 31321 == 179294)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007AF4 RID: 31476 RVA: 0x0101D79C File Offset: 0x0101B99C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (140451 - 44754 != 95697)
		{
		}
		for (;;)
		{
			if (this.uh7ckBm4Ac5 == null)
			{
				if (146703 - 463460 == -316757)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (173600 - 355000 != -181399)
				{
					if (mGameState == eGameState.Init)
					{
						if (68168 - 420018 == -351850)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (6723 - 231362 == -224639)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (209379 - 189549 != 19831)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (281686 - 74012 == 207674)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (157795 - 330352 == -172557)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (278669 - 216139 != 62531)
						{
							if (Time.time > this.a2Ock8SLf0J)
							{
								if (103526 - 501019 == -397492)
								{
									continue;
								}
								Game.mGameMana++;
								if (64864 - 492789 == -427924)
								{
									continue;
								}
								this.a2Ock8SLf0J = Time.time + (float)12;
								if (250520 - 106233 == 144288)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (215353 - 210942 != 4411)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (107871 - 484918 != -377047)
									{
										continue;
									}
									this.audio.Play();
									if (44415 - 73385 != -28970)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (254243 - 473114 == -218871)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (40807 - 214967 == -174160)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (173013 - 88845 != 84169)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (192263 - 106579 == 85684)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (37148 - 147436 != -110287)
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
						if (189342 - 88224 == 101118)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007AF5 RID: 31477 RVA: 0x0101DB18 File Offset: 0x0101BD18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExitFireCave2()
	{
		if (255013 - 79854 != 175159)
		{
		}
		while (this.axZckiBbegY == 0)
		{
			if (14152 - 112801 == -98649)
			{
				this.axZckiBbegY = 1;
				if (150237 - 40401 == 109836)
				{
					Game.sendMissionEvent(4011, 2);
					if (268952 - 588049 != -319096)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007AF6 RID: 31478 RVA: 0x0101DBBC File Offset: 0x0101BDBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (92284 - 381681 != -289396)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (71835 - 329858 == -258023)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (245400 - 325938 == -80538)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (90409 - 508580 == -418171)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (135891 - 29641 == 106250)
						{
							int num4 = num;
							if (273016 - 123060 != 149957)
							{
								if (num4 == 4012)
								{
									if (274297 - 470668 != -196370)
									{
										this.j64ckDqrRE6++;
										if (77060 - 84294 == -7234)
										{
											break;
										}
									}
								}
								else
								{
									if (num4 != 4013)
									{
										break;
									}
									if (251928 - 318564 != -66635)
									{
										this.RgickmI6bku++;
										if (82888 - 162182 != -79293)
										{
											if (PlayerData.UID != num3)
											{
												break;
											}
											if (7106 - 362478 == -355372)
											{
												if (this.RgickmI6bku < 3)
												{
													break;
												}
												if (213611 - 117852 != 95760)
												{
													if (this.RgickmI6bku >= 8)
													{
														break;
													}
													if (115351 - 348291 == -232940)
													{
														GameObject gameObject = GameObject.Find("SpawnPoint" + (UnityEngine.Random.Range(0, 5) + 1));
														if (196602 - 418288 == -221686)
														{
															if (!gameObject)
															{
																break;
															}
															if (65170 - 419559 == -354389)
															{
																this.createActor("RockBug", 6, gameObject.transform.position, gameObject.transform.forward);
																if (156593 - 201039 == -44446)
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

	// Token: 0x06007AF7 RID: 31479 RVA: 0x0101DE7C File Offset: 0x0101C07C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M401_DownFromVolcano2.$onGameComplete$38533(data, this).GetEnumerator();
	}

	// Token: 0x06007AF8 RID: 31480 RVA: 0x0101DE8C File Offset: 0x0101C08C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (147187 - 505550 != -358363)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (97304 - 533258 != -435953)
			{
				Hashtable customOpParameters = new Hashtable();
				if (288671 - 540877 == -252206)
				{
					this.uh7ckBm4Ac5.OpCustom(52, customOpParameters, true);
					if (26135 - 174738 != -148602)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007AF9 RID: 31481 RVA: 0x0101DF34 File Offset: 0x0101C134
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (281211 - 500102 != -218890)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (48983 - 292010 != -243026)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (182549 - 502499 == -319950)
				{
					Game.mGameState = eGameState.Setup;
					if (189206 - 35468 != 153739)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007AFA RID: 31482 RVA: 0x0101DFD8 File Offset: 0x0101C1D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (230300 - 261263 != -30962)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (290430 - 65660 == 224770)
			{
				if (num == PlayerData.UID)
				{
					if (61554 - 260869 == -199315)
					{
						this.SetupActors();
						if (48527 - 95177 != -46649)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (54401 - 185229 != -130827)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007AFB RID: 31483 RVA: 0x0101E0A8 File Offset: 0x0101C2A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (7489 - 150268 != -142778)
		{
		}
		for (;;)
		{
			IL_15C:
			Debug.Log("Creating Actors");
			if (269902 - 452094 != -182191)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (255374 - 428165 != -172790)
				{
					int i = 0;
					if (228667 - 150567 != 78101)
					{
						CharacterControl[] array2 = array;
						if (65364 - 595557 == -530193)
						{
							int length = array2.Length;
							if (99652 - 212993 != -113340)
							{
								while (i < length)
								{
									string type = array2[i].Type;
									if (211358 - 399582 == -188223)
									{
										goto IL_15C;
									}
									if (type == "RockBug")
									{
										goto IL_1D2;
									}
									if (59149 - 239126 != -179977)
									{
										goto IL_15C;
									}
									if (type == "Phoenix1")
									{
										goto IL_1D2;
									}
									if (21963 - 555791 == -533827)
									{
										goto IL_15C;
									}
									if (type == "Phoenix2")
									{
										goto IL_1D2;
									}
									if (67597 - 462585 != -394988)
									{
										goto IL_15C;
									}
									if (type == "Phoenix3")
									{
										goto IL_1D2;
									}
									if (25512 - 215351 == -189838)
									{
										goto IL_15C;
									}
									if (type == "Phoenix4")
									{
										if (262778 - 522244 != -259465)
										{
											goto IL_1D2;
										}
										goto IL_15C;
									}
									IL_10A:
									UnityEngine.Object.Destroy(array2[i].gameObject);
									if (225669 - 518065 != -292396)
									{
										goto IL_15C;
									}
									this.sdmckjOdqu2++;
									if (130489 - 141161 != -10672)
									{
										goto IL_15C;
									}
									i++;
									if (63742 - 353615 != -289873)
									{
										goto IL_15C;
									}
									continue;
									IL_1D2:
									this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
									if (208986 - 425329 != -216343)
									{
										goto IL_15C;
									}
									goto IL_10A;
								}
								if (160087 - 359896 != -199808)
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

	// Token: 0x06007AFC RID: 31484 RVA: 0x0101E37C File Offset: 0x0101C57C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (62296 - 175069 != -112772)
		{
		}
		for (;;)
		{
			IL_38:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (195799 - 497561 != -301761)
			{
				int i = 0;
				if (50805 - 88116 != -37310)
				{
					CharacterControl[] array2 = array;
					if (277411 - 46869 == 230542)
					{
						int length = array2.Length;
						if (145838 - 211203 == -65365)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (153006 - 247186 != -94180)
								{
									goto IL_38;
								}
								i++;
								if (187595 - 391787 != -204192)
								{
									goto IL_38;
								}
							}
							if (256972 - 518108 != -261135)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007AFD RID: 31485 RVA: 0x0101E4AC File Offset: 0x0101C6AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (237939 - 124788 != 113152)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (107768 - 461579 != -353810)
			{
				hashtable.Add(43, PlayerData.UID);
				if (155726 - 254126 != -98399)
				{
					hashtable.Add(73, nType);
					if (8423 - 361142 != -352718)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (151302 - 14472 == 136830)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (222522 - 506608 != -284085)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (141777 - 488367 == -346590)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (292582 - 218778 != 73805)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (291968 - 216538 != 75431)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (57770 - 533203 == -475433)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (18687 - 224029 == -205342)
												{
													this.uh7ckBm4Ac5.OpCustom(63, hashtable, true);
													if (182251 - 17907 == 164344)
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

	// Token: 0x06007AFE RID: 31486 RVA: 0x0101E764 File Offset: 0x0101C964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (120135 - 401561 != -281425)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (108447 - 63519 == 44928)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (1315 - 27391 != -26075)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (254251 - 79919 == 174332)
						{
							if (this.sdmckjOdqu2 <= 0)
							{
								break;
							}
							if (24397 - 293969 != -269571)
							{
								this.sdmckjOdqu2--;
								if (152672 - 63222 == 89450)
								{
									if (this.sdmckjOdqu2 != 0)
									{
										break;
									}
									if (203150 - 41956 != 161195)
									{
										Game.setGameState(eGameState.Ready);
										if (249230 - 378574 == -129344)
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
						if (81873 - 589648 == -507775)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (247791 - 294583 != -46791)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007AFF RID: 31487 RVA: 0x0101E8F4 File Offset: 0x0101CAF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06007B00 RID: 31488 RVA: 0x0101E8F8 File Offset: 0x0101CAF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (208075 - 394170 != -186095)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (99336 - 343511 != -244174)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (286331 - 307064 != -20732)
				{
					if (!characterControl)
					{
						break;
					}
					if (227962 - 318379 == -90417)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (6979 - 597996 != -591016)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (198483 - 20019 == 178464)
							{
								string type = characterControl.Type;
								if (106019 - 22683 == 83336)
								{
									if (type == "Phoenix1")
									{
										if (276207 - 267480 == 8728)
										{
											continue;
										}
									}
									else if (type == "Phoenix2")
									{
										if (143496 - 7057 == 136440)
										{
											continue;
										}
									}
									else if (type == "Phoenix3")
									{
										if (227906 - 78491 != 149415)
										{
											continue;
										}
									}
									else if (type == "Phoenix4")
									{
										if (210413 - 391987 == -181573)
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
										if (142991 - 60978 == 82014)
										{
											continue;
										}
										Game.sendMissionEvent(4013, 0);
										if (189549 - 593041 != -403491)
										{
											break;
										}
										continue;
									}
									IL_7E:
									Game.sendMissionEvent(4012, 0);
									if (154964 - 215737 != -60772)
									{
										break;
									}
									continue;
									IL_4F:
									goto IL_7E;
									goto IL_4F;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B01 RID: 31489 RVA: 0x0101EB50 File Offset: 0x0101CD50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (94312 - 141026 != -46714)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (160177 - 34529 != 125649)
			{
				Game.mGameState = eGameState.Ready;
				if (78240 - 416775 != -338534)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (233057 - 365213 != -132155)
					{
						GameObject gameObject = null;
						if (207771 - 278448 == -70677)
						{
							GameObject gameObject2 = null;
							if (37250 - 480538 != -443287)
							{
								if (playerSlot > 1)
								{
									if (191296 - 579055 != -387759)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (251543 - 373470 == -121926)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (96848 - 414359 != -317511)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (137598 - 3166 != 134432)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (29248 - 138007 != -108759)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (81945 - 564664 != -482719)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (26311 - 134754 != -108443)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (9025 - 334775 != -325750)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (259710 - 165233 == 94478)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (215583 - 373568 == -157984)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (71597 - 145026 != -73428)
								{
									this.transform.position = gameObject2.transform.position;
									if (238228 - 121079 == 117149)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (32131 - 374623 != -342491)
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

	// Token: 0x06007B02 RID: 31490 RVA: 0x0101EE4C File Offset: 0x0101D04C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M401_DownFromVolcano2.$StartGame$38541(this).GetEnumerator();
	}

	// Token: 0x06007B03 RID: 31491 RVA: 0x0101EE5C File Offset: 0x0101D05C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007B04 RID: 31492 RVA: 0x0101EE60 File Offset: 0x0101D060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (258966 - 39924 != 219043)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (72929 - 143306 != -70376)
			{
				hashtable.Add(71, CID);
				if (54864 - 481539 != -426674)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (249012 - 265160 == -16148)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (195235 - 372605 != -177369)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (141427 - 38217 == 103210)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (136317 - 278058 != -141740)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (207594 - 196566 != 11029)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (183925 - 5614 != 178312)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (258939 - 508201 == -249262)
											{
												this.uh7ckBm4Ac5.OpCustom(61, hashtable, true);
												if (28161 - 271953 == -243792)
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

	// Token: 0x06007B05 RID: 31493 RVA: 0x0101F0EC File Offset: 0x0101D2EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (108495 - 451785 != -343290)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (155527 - 263031 == -107504)
			{
				if (!gameObject)
				{
					break;
				}
				if (71111 - 9427 == 61684)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (187564 - 558802 == -371238)
					{
						playerCameraControl.target = gameObject;
						if (225394 - 38907 == 186487)
						{
							if (Game.useAdvanceMode)
							{
								if (99310 - 87369 != 11941)
								{
									continue;
								}
								Game.loadPlayer();
								if (123356 - 469815 != -346459)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (277896 - 357618 == -79722)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B06 RID: 31494 RVA: 0x0101F228 File Offset: 0x0101D428
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (87071 - 525423 != -438352)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (257591 - 583150 == -325559)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (296647 - 211972 != 84676)
				{
					gameGui.ResetTeamBar();
					if (69390 - 514698 == -445308)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007B07 RID: 31495 RVA: 0x0101F2D4 File Offset: 0x0101D4D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (228013 - 49146 != 178868)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (62982 - 237105 == -174123)
			{
				CharacterControl characterControl = null;
				if (19617 - 495752 == -476135)
				{
					if (mPlayer)
					{
						if (266288 - 70323 != 195965)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (275688 - 498974 != -223286)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (131490 - 343120 == -211630)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (123714 - 440260 != -316545)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (280513 - 21181 != 259333)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (173128 - 313519 == -140390)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (92882 - 146985 != -54103)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (277814 - 427983 != -150169)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (5733 - 235704 != -229970)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (12650 - 101590 != -88939)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (127554 - 137661 == -10107)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (203219 - 9892 == 193327)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (184663 - 297711 == -113048)
								{
									if (!changeGui)
									{
										break;
									}
									if (183391 - 383800 == -200409)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (54169 - 154584 != -100415)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (235145 - 100973 != 134172)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (84107 - 479078 == -394971)
										{
											gameGui.close();
											if (195742 - 474587 != -278844)
											{
												changeGui.enabled = true;
												if (68858 - 508057 != -439198)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (17049 - 90823 == -73774)
													{
														if (!gameObject)
														{
															break;
														}
														if (50765 - 167290 == -116525)
														{
															if (!mPlayer)
															{
																break;
															}
															if (217526 - 66163 != 151364)
															{
																Debug.Log("UseLifeAltar");
																if (165367 - 484655 != -319287)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (240443 - 394339 != -153895)
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

	// Token: 0x06007B08 RID: 31496 RVA: 0x0101F734 File Offset: 0x0101D934
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M401_DownFromVolcano2.$onDeadPlayer$38545(this).GetEnumerator();
	}

	// Token: 0x06007B09 RID: 31497 RVA: 0x0101F744 File Offset: 0x0101D944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (197209 - 99658 != 97552)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (251317 - 130900 == 120417)
			{
				this.yS7ck0YYu7A.target = Game.mPlayer;
				if (67446 - 166928 != -99481)
				{
					this.yS7ck0YYu7A.enabled = true;
					if (262532 - 428102 == -165570)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (1161 - 506768 == -505606)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (285113 - 68599 == 216515)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (99659 - 585824 != -486164)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (266828 - 527225 == -260397)
							{
								if (!gameGui)
								{
									break;
								}
								if (257950 - 417188 == -159238)
								{
									gameGui.enabled = true;
									if (54144 - 6610 == 47534)
									{
										gameGui.closeDeadMenu();
										if (112312 - 491133 == -378821)
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

	// Token: 0x06007B0A RID: 31498 RVA: 0x0101F8F0 File Offset: 0x0101DAF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (121513 - 331341 != -209827)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (123332 - 320491 == -197159)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (83500 - 518065 == -434565)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (28572 - 204300 == -175728)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007B0B RID: 31499 RVA: 0x0101F9B4 File Offset: 0x0101DBB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007B0C RID: 31500 RVA: 0x0101F9E0 File Offset: 0x0101DBE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M401_DownFromVolcano2.$ReturnToTown$38551(this).GetEnumerator();
	}

	// Token: 0x06007B0D RID: 31501 RVA: 0x0101F9F0 File Offset: 0x0101DBF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M401_DownFromVolcano2.$ReturnToGuild$38556(this).GetEnumerator();
	}

	// Token: 0x06007B0E RID: 31502 RVA: 0x0101FA00 File Offset: 0x0101DC00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M401_DownFromVolcano2.$ReturnToCamp$38560(this).GetEnumerator();
	}

	// Token: 0x06007B0F RID: 31503 RVA: 0x0101FA10 File Offset: 0x0101DC10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (271897 - 557605 != -285708)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (209361 - 295121 == -85760)
			{
				Hashtable hashtable = new Hashtable();
				if (277741 - 233695 == 44046)
				{
					hashtable.Add(43, PlayerData.UID);
					if (160077 - 261617 != -101539)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (286806 - 413331 == -126525)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B10 RID: 31504 RVA: 0x0101FAE8 File Offset: 0x0101DCE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007B11 RID: 31505 RVA: 0x0101FAFC File Offset: 0x0101DCFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (182021 - 340225 != -158203)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (294883 - 584619 != -289735)
			{
				Hashtable hashtable = new Hashtable();
				if (30698 - 566536 != -535837)
				{
					if (Game.mNextGameCode == 30)
					{
						if (180546 - 46128 != 134418)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (234837 - 511889 == -277051)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (77294 - 379196 != -301902)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (280369 - 10891 == 269479)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (44230 - 125435 != -81205)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (11561 - 518298 == -506736)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (53303 - 471992 != -418689)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (207627 - 298321 == -90693)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (296728 - 102845 != 193883)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (130343 - 131396 == -1052)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (45266 - 359245 == -313978)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (272025 - 477180 == -205154)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (87090 - 387796 == -300705)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (285331 - 121055 != 164276)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (286454 - 514027 == -227572)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (252320 - 384627 != -132307)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (213754 - 529635 != -315881)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (110782 - 495517 != -384735)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (221881 - 389928 != -168047)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (12810 - 6657 == 6154)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (112414 - 93498 == 18917)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (245693 - 536339 != -290646)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (298221 - 251126 != 47095)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (85803 - 248899 == -163095)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (140671 - 566582 == -425910)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (124541 - 158901 == -34359)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (19065 - 185443 == -166377)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (17068 - 132382 == -115313)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (277675 - 239230 == 38445)
					{
						this.uh7ckBm4Ac5.OpCustom(42, hashtable, true);
						if (211061 - 452110 == -241049)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B12 RID: 31506 RVA: 0x010200B0 File Offset: 0x0101E2B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007B13 RID: 31507 RVA: 0x010200C0 File Offset: 0x0101E2C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007B14 RID: 31508 RVA: 0x010200C4 File Offset: 0x0101E2C4
	internal static bool EhFbiJpP2GjZTIbKy9Ib()
	{
		return true;
	}

	// Token: 0x06007B15 RID: 31509 RVA: 0x010200C8 File Offset: 0x0101E2C8
	internal static bool jTnqf7pP8DmTTGeuwc8L()
	{
		return false;
	}

	// Token: 0x04007CBF RID: 31935
	private LitePeer uh7ckBm4Ac5;

	// Token: 0x04007CC0 RID: 31936
	private PlayerCameraControl yS7ck0YYu7A;

	// Token: 0x04007CC1 RID: 31937
	private float a2Ock8SLf0J;

	// Token: 0x04007CC2 RID: 31938
	private int axZckiBbegY;

	// Token: 0x04007CC3 RID: 31939
	private int j64ckDqrRE6;

	// Token: 0x04007CC4 RID: 31940
	private int RgickmI6bku;

	// Token: 0x04007CC5 RID: 31941
	private int sdmckjOdqu2;

	// Token: 0x020014C2 RID: 5314
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38533 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007B16 RID: 31510 RVA: 0x010200CC File Offset: 0x0101E2CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38533(Hashtable data, M401_DownFromVolcano2 self_)
		{
			if (29844 - 435211 != -405366)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (259301 - 285754 != -26452)
				{
					base..ctor();
					if (102779 - 375662 != -272882)
					{
						this.$data$38539 = data;
						if (49087 - 512717 == -463630)
						{
							this.$self_$38540 = self_;
							if (5541 - 123135 != -117593)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007B17 RID: 31511 RVA: 0x01020188 File Offset: 0x0101E388
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M401_DownFromVolcano2.$onGameComplete$38533.$(this.$data$38539, this.$self_$38540);
		}

		// Token: 0x06007B18 RID: 31512 RVA: 0x0102019C File Offset: 0x0101E39C
		internal static bool z7Ye12pPZeK8EdvQSq3I()
		{
			return true;
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x010201A0 File Offset: 0x0101E3A0
		internal static bool R8dDLGpPCuDbu0W3M5bq()
		{
			return false;
		}

		// Token: 0x04007CC6 RID: 31942
		internal Hashtable $data$38539;

		// Token: 0x04007CC7 RID: 31943
		internal M401_DownFromVolcano2 $self_$38540;

		// Token: 0x020014C3 RID: 5315
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007B1A RID: 31514 RVA: 0x010201A4 File Offset: 0x0101E3A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M401_DownFromVolcano2 self_)
			{
				if (282967 - 458629 != -175661)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (215616 - 595445 != -379828)
					{
						base..ctor();
						if (242793 - 319524 != -76730)
						{
							this.$data$38537 = data;
							if (269802 - 223666 != 46137)
							{
								this.$self_$38538 = self_;
								if (44567 - 58559 != -13991)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007B1B RID: 31515 RVA: 0x01020260 File Offset: 0x0101E460
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (166912 - 166516 != 396)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_28E;
					case 2:
						this.$mCompleteGui$38535 = (CompleteGui)this.$self_$38538.GetComponent(typeof(CompleteGui));
						if (187369 - 440390 == -253020)
						{
							continue;
						}
						this.$mCompleteGui$38535.Init();
						if (275382 - 243878 != 31504)
						{
							continue;
						}
						this.$mCompleteGui$38535.readData(this.$data$38537);
						if (48445 - 117721 != -69276)
						{
							continue;
						}
						if (this.$result$38534 == 1)
						{
							if (152278 - 41933 == 110346)
							{
								continue;
							}
							this.$mCompleteGui$38535.displayResult(eCompleteType.Success);
							if (272338 - 538619 != -266281)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38535.displayResult(eCompleteType.Failed);
							if (233065 - 15951 != 217114)
							{
								continue;
							}
						}
						this.$mGameGui$38536 = (GameGui)this.$self_$38538.GetComponent(typeof(GameGui));
						if (221248 - 250024 != -28776)
						{
							continue;
						}
						if (this.$mGameGui$38536)
						{
							if (142547 - 392244 == -249696)
							{
								continue;
							}
							this.$mGameGui$38536.close();
							if (223679 - 509704 != -286025)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (87242 - 22490 != 64752)
						{
							continue;
						}
						goto IL_28E;
					default:
						if (70972 - 452185 != -381213)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (106012 - 543592 == -437580)
						{
							goto IL_D3;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (96804 - 448300 != -351495)
						{
							this.$result$38534 = RuntimeServices.UnboxInt32(this.$data$38537[31]);
							if (69012 - 421261 != -352248)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_D3:
				IL_28E:
				return false;
			}

			// Token: 0x06007B1C RID: 31516 RVA: 0x01020510 File Offset: 0x0101E710
			internal static bool D8IUotpPLASTulWWd1yP()
			{
				return true;
			}

			// Token: 0x06007B1D RID: 31517 RVA: 0x01020514 File Offset: 0x0101E714
			internal static bool hR7hZspPO2vZbeCylYXS()
			{
				return false;
			}

			// Token: 0x04007CC8 RID: 31944
			internal int $result$38534;

			// Token: 0x04007CC9 RID: 31945
			internal CompleteGui $mCompleteGui$38535;

			// Token: 0x04007CCA RID: 31946
			internal GameGui $mGameGui$38536;

			// Token: 0x04007CCB RID: 31947
			internal Hashtable $data$38537;

			// Token: 0x04007CCC RID: 31948
			internal M401_DownFromVolcano2 $self_$38538;
		}
	}

	// Token: 0x020014C4 RID: 5316
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38541 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007B1E RID: 31518 RVA: 0x01020518 File Offset: 0x0101E718
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38541(M401_DownFromVolcano2 self_)
		{
			if (219143 - 438775 != -219631)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (250889 - 244172 == 6717)
				{
					base..ctor();
					if (273031 - 304861 != -31829)
					{
						this.$self_$38544 = self_;
						if (76089 - 179329 == -103240)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007B1F RID: 31519 RVA: 0x010205B0 File Offset: 0x0101E7B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M401_DownFromVolcano2.$StartGame$38541.$(this.$self_$38544);
		}

		// Token: 0x06007B20 RID: 31520 RVA: 0x010205C0 File Offset: 0x0101E7C0
		internal static bool CUAHS1pPmPKrI9VdKXUw()
		{
			return true;
		}

		// Token: 0x06007B21 RID: 31521 RVA: 0x010205C4 File Offset: 0x0101E7C4
		internal static bool B65bakpPFxXiQPc5yCR6()
		{
			return false;
		}

		// Token: 0x04007CCD RID: 31949
		internal M401_DownFromVolcano2 $self_$38544;

		// Token: 0x020014C5 RID: 5317
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007B22 RID: 31522 RVA: 0x010205C8 File Offset: 0x0101E7C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M401_DownFromVolcano2 self_)
			{
				if (21171 - 245113 != -223942)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162305 - 71862 == 90443)
					{
						base..ctor();
						if (167428 - 10158 == 157270)
						{
							this.$self_$38543 = self_;
							if (223417 - 471089 != -247671)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007B23 RID: 31523 RVA: 0x01020660 File Offset: 0x0101E860
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7531 - 213027 != -205496)
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
						if (208209 - 194992 == 13218)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (191855 - 180496 == 11360)
						{
							continue;
						}
						this.YieldDefault(1);
						if (75193 - 209554 != -134361)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (167816 - 528135 == -360318)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (148666 - 190371 == -41705)
					{
						Game.mGameState = eGameState.Start;
						if (174020 - 30717 != 143304)
						{
							Game.mStateTime = Time.time;
							if (187537 - 484133 == -296596)
							{
								this.$mGameGui$38542 = (GameGui)this.$self_$38543.GetComponent(typeof(GameGui));
								if (261648 - 148450 != 113199)
								{
									this.$mGameGui$38542.enabled = true;
									if (97413 - 443135 != -345721)
									{
										this.$self_$38543.SendMessage("fadeIn");
										if (74833 - 259076 != -184242)
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

			// Token: 0x06007B24 RID: 31524 RVA: 0x01020838 File Offset: 0x0101EA38
			internal static bool uGQG9spPMIQtTMLpOn1g()
			{
				return true;
			}

			// Token: 0x06007B25 RID: 31525 RVA: 0x0102083C File Offset: 0x0101EA3C
			internal static bool u2QtMTpPxZo7WVcvCP2u()
			{
				return false;
			}

			// Token: 0x04007CCE RID: 31950
			internal GameGui $mGameGui$38542;

			// Token: 0x04007CCF RID: 31951
			internal M401_DownFromVolcano2 $self_$38543;
		}
	}

	// Token: 0x020014C6 RID: 5318
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38545 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007B26 RID: 31526 RVA: 0x01020840 File Offset: 0x0101EA40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38545(M401_DownFromVolcano2 self_)
		{
			if (293485 - 70938 != 222547)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (277902 - 340787 == -62885)
				{
					base..ctor();
					if (120663 - 412225 == -291562)
					{
						this.$self_$38550 = self_;
						if (93546 - 346543 != -252996)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007B27 RID: 31527 RVA: 0x010208D8 File Offset: 0x0101EAD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M401_DownFromVolcano2.$onDeadPlayer$38545.$(this.$self_$38550);
		}

		// Token: 0x06007B28 RID: 31528 RVA: 0x010208E8 File Offset: 0x0101EAE8
		internal static bool twTCo7pPgD3Xc8dIBSVR()
		{
			return true;
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x010208EC File Offset: 0x0101EAEC
		internal static bool hlvnE5pPfpTRmTigRkiv()
		{
			return false;
		}

		// Token: 0x04007CD0 RID: 31952
		internal M401_DownFromVolcano2 $self_$38550;

		// Token: 0x020014C7 RID: 5319
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007B2A RID: 31530 RVA: 0x010208F0 File Offset: 0x0101EAF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M401_DownFromVolcano2 self_)
			{
				if (204044 - 594479 != -390434)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (107573 - 13254 == 94319)
					{
						base..ctor();
						if (211600 - 421581 == -209981)
						{
							this.$self_$38549 = self_;
							if (189465 - 339507 == -150042)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007B2B RID: 31531 RVA: 0x01020988 File Offset: 0x0101EB88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (245371 - 497757 != -252385)
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
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_2D9;
						}
						if (59425 - 317150 == -257724)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (74997 - 376370 != -301372)
							{
								goto IL_2D9;
							}
							continue;
						}
						IL_40:
						this.YieldDefault(1);
						if (105691 - 31761 != 73931)
						{
							goto Block_3;
						}
						continue;
						IL_2D9:
						Game.mGameState = eGameState.Hold;
						if (186622 - 211911 != -25289)
						{
							continue;
						}
						this.$mStoryGui$38546 = (StoryGui)this.$self_$38549.GetComponent(typeof(StoryGui));
						if (277083 - 264064 == 13020)
						{
							continue;
						}
						if (this.$mStoryGui$38546)
						{
							if (158275 - 536390 == -378114)
							{
								continue;
							}
							this.$mStoryGui$38546.close();
							if (14712 - 574131 != -559419)
							{
								continue;
							}
						}
						this.$mChangeGui$38547 = (ChangeGui)this.$self_$38549.GetComponent(typeof(ChangeGui));
						if (138308 - 26746 != 111562)
						{
							continue;
						}
						if (this.$mChangeGui$38547)
						{
							if (252454 - 334685 == -82230)
							{
								continue;
							}
							this.$mChangeGui$38547.close();
							if (251028 - 255939 != -4911)
							{
								continue;
							}
						}
						this.$mGameGui$38548 = (GameGui)this.$self_$38549.GetComponent(typeof(GameGui));
						if (272254 - 334991 != -62737)
						{
							continue;
						}
						if (!this.$mGameGui$38548)
						{
							goto IL_40;
						}
						if (197586 - 502070 == -304483)
						{
							continue;
						}
						if (!this.$mGameGui$38548.enabled)
						{
							if (264528 - 344931 == -80402)
							{
								continue;
							}
							this.$mGameGui$38548.enabled = true;
							if (100310 - 255470 != -155160)
							{
								continue;
							}
						}
						this.$mGameGui$38548.openDeadMenu();
						if (272424 - 274506 != -2082)
						{
							continue;
						}
						goto IL_40;
					default:
						if (257260 - 58931 == 198330)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (174627 - 276472 == -101845)
					{
						goto IL_1F3;
					}
				}
				Block_3:
				goto IL_2F9;
				IL_1F3:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007B2C RID: 31532 RVA: 0x01020CA0 File Offset: 0x0101EEA0
			internal static bool OKXrKqpPnRNG9SRGO7TZ()
			{
				return true;
			}

			// Token: 0x06007B2D RID: 31533 RVA: 0x01020CA4 File Offset: 0x0101EEA4
			internal static bool TCIs17pP6fDuSVVZk0HH()
			{
				return false;
			}

			// Token: 0x04007CD1 RID: 31953
			internal StoryGui $mStoryGui$38546;

			// Token: 0x04007CD2 RID: 31954
			internal ChangeGui $mChangeGui$38547;

			// Token: 0x04007CD3 RID: 31955
			internal GameGui $mGameGui$38548;

			// Token: 0x04007CD4 RID: 31956
			internal M401_DownFromVolcano2 $self_$38549;
		}
	}

	// Token: 0x020014C8 RID: 5320
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38551 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007B2E RID: 31534 RVA: 0x01020CA8 File Offset: 0x0101EEA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38551(M401_DownFromVolcano2 self_)
		{
			if (192404 - 310083 != -117678)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (36660 - 451197 != -414536)
				{
					base..ctor();
					if (106753 - 230 != 106524)
					{
						this.$self_$38555 = self_;
						if (57345 - 412161 == -354816)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x01020D40 File Offset: 0x0101EF40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M401_DownFromVolcano2.$ReturnToTown$38551.$(this.$self_$38555);
		}

		// Token: 0x06007B30 RID: 31536 RVA: 0x01020D50 File Offset: 0x0101EF50
		internal static bool gxTur9pPitasTlrr2iTs()
		{
			return true;
		}

		// Token: 0x06007B31 RID: 31537 RVA: 0x01020D54 File Offset: 0x0101EF54
		internal static bool u0YupjpPKWmgZWi6tWas()
		{
			return false;
		}

		// Token: 0x04007CD5 RID: 31957
		internal M401_DownFromVolcano2 $self_$38555;

		// Token: 0x020014C9 RID: 5321
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007B32 RID: 31538 RVA: 0x01020D58 File Offset: 0x0101EF58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M401_DownFromVolcano2 self_)
			{
				if (54414 - 83878 != -29464)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (9524 - 222861 == -213337)
					{
						base..ctor();
						if (275467 - 543299 != -267831)
						{
							this.$self_$38554 = self_;
							if (276810 - 301112 != -24301)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007B33 RID: 31539 RVA: 0x01020DF0 File Offset: 0x0101EFF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75622 - 568797 != -493174)
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
						this.$self_$38554.LeaveGame();
						if (142575 - 430725 != -288150)
						{
							continue;
						}
						this.YieldDefault(1);
						if (149639 - 201657 != -52017)
						{
							goto Block_22;
						}
						continue;
					default:
						if (155354 - 310378 != -155024)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (225909 - 473752 != -247842)
					{
						Game.mStateTime = Time.time;
						if (36835 - 548467 != -511631)
						{
							this.$$switch$6696$38552 = PlayerData.SaveGuild;
							if (143416 - 44645 != 98772)
							{
								if (this.$$switch$6696$38552 == 1)
								{
									if (170551 - 539365 != -368814)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (259197 - 765 != 258432)
									{
										continue;
									}
								}
								else if (this.$$switch$6696$38552 == 2)
								{
									if (255163 - 265340 != -10177)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (18036 - 140750 != -122714)
									{
										continue;
									}
								}
								else if (this.$$switch$6696$38552 == 3)
								{
									if (146245 - 196386 != -50141)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (54311 - 29413 == 24899)
									{
										continue;
									}
								}
								else if (this.$$switch$6696$38552 == 4)
								{
									if (29120 - 567309 == -538188)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (96033 - 308939 != -212906)
									{
										continue;
									}
								}
								else if (this.$$switch$6696$38552 == 5)
								{
									if (170471 - 202870 == -32398)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (103437 - 19986 == 83452)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (4132 - 286778 == -282645)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (169122 - 390676 == -221553)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (22038 - 19586 == 2453)
									{
										continue;
									}
								}
								this.$mGameGui$38553 = (GameGui)this.$self_$38554.GetComponent(typeof(GameGui));
								if (283595 - 342839 != -59243)
								{
									if (this.$mGameGui$38553)
									{
										if (29125 - 545156 == -516030)
										{
											continue;
										}
										this.$mGameGui$38553.close();
										if (224733 - 267310 == -42576)
										{
											continue;
										}
									}
									this.$self_$38554.SendMessage("fadeOut");
									if (46862 - 427469 != -380606)
									{
										goto Block_31;
									}
								}
							}
						}
					}
				}
				Block_22:
				goto IL_3AD;
				Block_31:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06007B34 RID: 31540 RVA: 0x010211BC File Offset: 0x0101F3BC
			internal static bool cAV33WpPdd1sYe03OC7w()
			{
				return true;
			}

			// Token: 0x06007B35 RID: 31541 RVA: 0x010211C0 File Offset: 0x0101F3C0
			internal static bool PH4xrepPJvdOWtRLmt4F()
			{
				return false;
			}

			// Token: 0x04007CD6 RID: 31958
			internal int $$switch$6696$38552;

			// Token: 0x04007CD7 RID: 31959
			internal GameGui $mGameGui$38553;

			// Token: 0x04007CD8 RID: 31960
			internal M401_DownFromVolcano2 $self_$38554;
		}
	}

	// Token: 0x020014CA RID: 5322
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38556 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007B36 RID: 31542 RVA: 0x010211C4 File Offset: 0x0101F3C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38556(M401_DownFromVolcano2 self_)
		{
			if (112053 - 592294 != -480240)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227085 - 252096 != -25010)
				{
					base..ctor();
					if (168323 - 268869 != -100545)
					{
						this.$self_$38559 = self_;
						if (197597 - 114552 != 83046)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x0102125C File Offset: 0x0101F45C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M401_DownFromVolcano2.$ReturnToGuild$38556.$(this.$self_$38559);
		}

		// Token: 0x06007B38 RID: 31544 RVA: 0x0102126C File Offset: 0x0101F46C
		internal static bool Ya31VYpPDae8LmoNIL3a()
		{
			return true;
		}

		// Token: 0x06007B39 RID: 31545 RVA: 0x01021270 File Offset: 0x0101F470
		internal static bool Lp0jnEpPvsRvxTSyuL2w()
		{
			return false;
		}

		// Token: 0x04007CD9 RID: 31961
		internal M401_DownFromVolcano2 $self_$38559;

		// Token: 0x020014CB RID: 5323
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007B3A RID: 31546 RVA: 0x01021274 File Offset: 0x0101F474
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M401_DownFromVolcano2 self_)
			{
				if (82351 - 330441 != -248089)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (74837 - 202509 != -127671)
					{
						base..ctor();
						if (62839 - 544729 != -481889)
						{
							this.$self_$38558 = self_;
							if (61408 - 592223 == -530815)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007B3B RID: 31547 RVA: 0x0102130C File Offset: 0x0101F50C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (219404 - 6078 != 213327)
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
						this.$self_$38558.LeaveGame();
						if (166501 - 212109 == -45607)
						{
							continue;
						}
						this.YieldDefault(1);
						if (197822 - 300880 != -103057)
						{
							goto Block_4;
						}
						continue;
					default:
						if (58784 - 159907 != -101123)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (24435 - 252856 == -228421)
					{
						Game.mStateTime = Time.time;
						if (23865 - 489447 == -465582)
						{
							Game.mNextGameCode = 31;
							if (91612 - 427002 == -335390)
							{
								this.$mGameGui$38557 = (GameGui)this.$self_$38558.GetComponent(typeof(GameGui));
								if (216752 - 372764 == -156012)
								{
									if (this.$mGameGui$38557)
									{
										if (118092 - 258187 != -140095)
										{
											continue;
										}
										this.$mGameGui$38557.close();
										if (25445 - 217820 != -192375)
										{
											continue;
										}
									}
									this.$self_$38558.SendMessage("fadeOut");
									if (274840 - 175023 != 99818)
									{
										goto Block_10;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_1BD;
				Block_10:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06007B3C RID: 31548 RVA: 0x010214E8 File Offset: 0x0101F6E8
			internal static bool rQUUxYpPRRkC6d9Zb1vv()
			{
				return true;
			}

			// Token: 0x06007B3D RID: 31549 RVA: 0x010214EC File Offset: 0x0101F6EC
			internal static bool rIvancpPwkJ3GslxpV63()
			{
				return false;
			}

			// Token: 0x04007CDA RID: 31962
			internal GameGui $mGameGui$38557;

			// Token: 0x04007CDB RID: 31963
			internal M401_DownFromVolcano2 $self_$38558;
		}
	}

	// Token: 0x020014CC RID: 5324
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38560 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007B3E RID: 31550 RVA: 0x010214F0 File Offset: 0x0101F6F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38560(M401_DownFromVolcano2 self_)
		{
			if (113343 - 521774 != -408431)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (84678 - 546544 == -461866)
				{
					base..ctor();
					if (228489 - 360666 == -132177)
					{
						this.$self_$38564 = self_;
						if (24072 - 14289 == 9783)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007B3F RID: 31551 RVA: 0x01021588 File Offset: 0x0101F788
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M401_DownFromVolcano2.$ReturnToCamp$38560.$(this.$self_$38564);
		}

		// Token: 0x06007B40 RID: 31552 RVA: 0x01021598 File Offset: 0x0101F798
		internal static bool AX1YgcpPq6h4dqfQdLtM()
		{
			return true;
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x0102159C File Offset: 0x0101F79C
		internal static bool Gd4PQcpP7YNFakvm0Bpx()
		{
			return false;
		}

		// Token: 0x04007CDC RID: 31964
		internal M401_DownFromVolcano2 $self_$38564;

		// Token: 0x020014CD RID: 5325
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007B42 RID: 31554 RVA: 0x010215A0 File Offset: 0x0101F7A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M401_DownFromVolcano2 self_)
			{
				if (276532 - 404510 != -127977)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (232114 - 543383 == -311269)
					{
						base..ctor();
						if (71365 - 249906 == -178541)
						{
							this.$self_$38563 = self_;
							if (257675 - 503411 != -245735)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007B43 RID: 31555 RVA: 0x01021638 File Offset: 0x0101F838
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (19292 - 404112 != -384820)
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
						this.$self_$38563.LeaveGame();
						if (187871 - 264376 == -76504)
						{
							continue;
						}
						this.YieldDefault(1);
						if (276829 - 461305 != -184476)
						{
							continue;
						}
						goto IL_363;
					default:
						if (184508 - 133740 == 50769)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (54103 - 78839 == -24736)
					{
						Game.mStateTime = Time.time;
						if (275857 - 369067 == -93210)
						{
							this.$$switch$6698$38561 = PlayerData.SaveGuild;
							if (9388 - 479741 == -470353)
							{
								if (this.$$switch$6698$38561 == 1)
								{
									if (105863 - 161205 != -55342)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (35275 - 580368 == -545092)
									{
										continue;
									}
								}
								else if (this.$$switch$6698$38561 == 2)
								{
									if (91622 - 300755 != -209133)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (285046 - 467939 != -182893)
									{
										continue;
									}
								}
								else if (this.$$switch$6698$38561 == 3)
								{
									if (135273 - 251803 != -116530)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (205548 - 387531 != -181983)
									{
										continue;
									}
								}
								else if (this.$$switch$6698$38561 == 4)
								{
									if (174943 - 29507 != 145436)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (250698 - 18209 == 232490)
									{
										continue;
									}
								}
								else if (this.$$switch$6698$38561 == 5)
								{
									if (109083 - 540460 != -431377)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (255255 - 98436 != 156819)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (74836 - 253869 == -179032)
									{
										continue;
									}
								}
								this.$mGameGui$38562 = (GameGui)this.$self_$38563.GetComponent(typeof(GameGui));
								if (148800 - 380059 == -231259)
								{
									if (this.$mGameGui$38562)
									{
										if (10558 - 391746 == -381187)
										{
											continue;
										}
										this.$mGameGui$38562.close();
										if (25636 - 33852 == -8215)
										{
											continue;
										}
									}
									this.$self_$38563.SendMessage("fadeOut");
									if (151510 - 354008 == -202498)
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

			// Token: 0x06007B44 RID: 31556 RVA: 0x010219BC File Offset: 0x0101FBBC
			internal static bool RxKQ1VpPP8ZyUQnv9rEC()
			{
				return true;
			}

			// Token: 0x06007B45 RID: 31557 RVA: 0x010219C0 File Offset: 0x0101FBC0
			internal static bool xb78fQpP0F4YCHQbHDPm()
			{
				return false;
			}

			// Token: 0x04007CDD RID: 31965
			internal int $$switch$6698$38561;

			// Token: 0x04007CDE RID: 31966
			internal GameGui $mGameGui$38562;

			// Token: 0x04007CDF RID: 31967
			internal M401_DownFromVolcano2 $self_$38563;
		}
	}
}
