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

// Token: 0x02001587 RID: 5511
[Serializable]
public class M501_ThroughTheSwamp2 : MonoBehaviour
{
	// Token: 0x06007FB8 RID: 32696 RVA: 0x01060D70 File Offset: 0x0105EF70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M501_ThroughTheSwamp2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007FB9 RID: 32697 RVA: 0x01060D80 File Offset: 0x0105EF80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (81681 - 414006 != -332325)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (198112 - 264777 != -66664)
			{
				Game.mGameType = 5;
				if (24747 - 483426 == -458679)
				{
					if (Chat.Initialized)
					{
						if (74640 - 514914 != -440273)
						{
							Chat.ChatDisplay.Clear();
							if (105107 - 555601 != -450493)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (102109 - 318379 == -216270)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007FBA RID: 32698 RVA: 0x01060E64 File Offset: 0x0105F064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (212940 - 345350 != -132409)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (102835 - 185706 != -82870)
				{
					if (Game.mNextGameCode != 501)
					{
						break;
					}
					if (49795 - 284411 != -234615)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (212152 - 262915 == -50763)
						{
							Game.nextGame();
							if (255567 - 86945 == 168622)
							{
								this.RP8cAZiwdsr = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (147854 - 19108 != 128747)
								{
									this.KlKcA7tQslx = PhotonClient.Connection;
									if (93130 - 249139 == -156009)
									{
										PhotonClient.ActorNrList.Clear();
										if (242411 - 164102 != 78310)
										{
											this.InitGame();
											if (110462 - 182603 != -72140)
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
				if (171237 - 511889 != -340651)
				{
					Game.mGameType = 99;
					if (16429 - 239978 == -223549)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007FBB RID: 32699 RVA: 0x0106101C File Offset: 0x0105F21C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (295462 - 205495 != 89967)
		{
		}
		for (;;)
		{
			if (this.KlKcA7tQslx == null)
			{
				if (239990 - 129810 == 110180)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (131752 - 547530 != -415777)
				{
					if (mGameState == eGameState.Init)
					{
						if (134556 - 254692 == -120136)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (65825 - 509259 != -443433)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (177290 - 565226 == -387936)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (286467 - 108354 != 178114)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (166288 - 541589 == -375301)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (138187 - 471877 != -333689)
						{
							if (Time.time > this.RP4cAC4hhlg)
							{
								if (181891 - 425415 != -243524)
								{
									continue;
								}
								Game.mGameMana++;
								if (115574 - 180885 != -65311)
								{
									continue;
								}
								this.RP4cAC4hhlg = Time.time + (float)12;
								if (31520 - 310731 != -279211)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (169077 - 392056 != -222979)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (10954 - 388163 != -377209)
									{
										continue;
									}
									this.audio.Play();
									if (111922 - 371485 == -259562)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (84263 - 53830 == 30433)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (135544 - 21575 == 113969)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (100047 - 280368 == -180321)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (77522 - 545984 == -468462)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (101786 - 104772 != -2985)
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
						if (140132 - 592443 != -452310)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007FBC RID: 32700 RVA: 0x01061398 File Offset: 0x0105F598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M501_ThroughTheSwamp2.$onGameEvent$39105(data, this).GetEnumerator();
	}

	// Token: 0x06007FBD RID: 32701 RVA: 0x010613A8 File Offset: 0x0105F5A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M501_ThroughTheSwamp2.$onGameComplete$39121(data, this).GetEnumerator();
	}

	// Token: 0x06007FBE RID: 32702 RVA: 0x010613B8 File Offset: 0x0105F5B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExit()
	{
		if (109479 - 577671 != -468192)
		{
		}
		while (this.GN1cAMjnDhn < 1)
		{
			if (48907 - 48072 != 836)
			{
				Debug.Log("Swamp Exit");
				if (196790 - 260735 != -63944)
				{
					this.GN1cAMjnDhn = 1;
					if (196469 - 249020 != -52550)
					{
						Game.sendMissionEvent(5011, 2);
						if (174428 - 37346 == 137082)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007FBF RID: 32703 RVA: 0x01061480 File Offset: 0x0105F680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseManaPillar(int nID)
	{
		if (83565 - 2631 != 80935)
		{
		}
		for (;;)
		{
			Debug.Log("UseManaPillar");
			if (171344 - 407219 != -235874)
			{
				if (!Game.mPlayer)
				{
					if (101759 - 268204 != -166444)
					{
						break;
					}
				}
				else if (this.i0QcAEpD0cP == null)
				{
					if (251990 - 107897 != 144094)
					{
						break;
					}
				}
				else if (Extensions.get_length(this.i0QcAEpD0cP) < nID)
				{
					if (193228 - 118937 != 74292)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (36517 - 377229 != -340711)
					{
						if (!characterControl)
						{
							goto IL_73;
						}
						if (9283 - 196655 == -187371)
						{
							continue;
						}
						if (!(characterControl.actionState == "standby"))
						{
							if (173021 - 475272 != -302250)
							{
								goto IL_73;
							}
							continue;
						}
						IL_49:
						if (this.i0QcAEpD0cP[nID - 1] > 0)
						{
							if (66640 - 318262 == -251621)
							{
								continue;
							}
							this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
							if (77188 - 355128 != -277939)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject gameObject = GameObject.Find("ManaPillar" + nID);
							if (169526 - 78767 == 90760)
							{
								continue;
							}
							if (gameObject)
							{
								if (237119 - 53234 != 183885)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (70255 - 182702 != -112447)
								{
									continue;
								}
								Game.mPlayer.SendMessage("activateIcon", nID);
								if (276184 - 179709 != 96475)
								{
									continue;
								}
								break;
							}
							else
							{
								Debug.LogError("Cannot find ManaPillar GameObject");
								if (286265 - 272238 != 14027)
								{
									continue;
								}
								break;
							}
						}
						IL_73:
						if (characterControl.actionState == "run")
						{
							goto IL_49;
						}
						if (189321 - 62307 == 127014)
						{
							if (!(characterControl.actionState == "emotion"))
							{
								break;
							}
							if (146303 - 421360 == -275057)
							{
								goto IL_49;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007FC0 RID: 32704 RVA: 0x0106178C File Offset: 0x0105F98C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (261005 - 288744 != -27739)
		{
		}
		for (;;)
		{
			if (this.i0QcAEpD0cP == null)
			{
				if (256067 - 471178 != -215110)
				{
					break;
				}
			}
			else if (Extensions.get_length(this.i0QcAEpD0cP) < nID)
			{
				if (218409 - 273533 != -55123)
				{
					break;
				}
			}
			else if (this.i0QcAEpD0cP[nID - 1] > 0)
			{
				if (47165 - 339953 == -292788)
				{
					this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
					if (506 - 494609 != -494102)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(5016, nID);
				if (188990 - 504694 != -315703)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06007FC1 RID: 32705 RVA: 0x0106189C File Offset: 0x0105FA9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateManaPillar(int nID)
	{
		if (261522 - 419947 != -158424)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("ManaPillar" + nID);
			if (111774 - 501389 != -389614)
			{
				if (!gameObject)
				{
					break;
				}
				if (137746 - 91035 != 46712)
				{
					if (!this.manaPillarEffect)
					{
						break;
					}
					if (227829 - 557342 == -329513)
					{
						UnityEngine.Object.Instantiate(this.manaPillarEffect, gameObject.transform.position, gameObject.transform.rotation);
						if (255380 - 175119 != 80262)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007FC2 RID: 32706 RVA: 0x01061990 File Offset: 0x0105FB90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (253452 - 207001 != 46451)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (220433 - 220656 != -222)
			{
				Hashtable customOpParameters = new Hashtable();
				if (122169 - 16618 == 105551)
				{
					this.KlKcA7tQslx.OpCustom(52, customOpParameters, true);
					if (233033 - 405384 != -172350)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007FC3 RID: 32707 RVA: 0x01061A38 File Offset: 0x0105FC38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (6712 - 518290 != -511577)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (17112 - 507519 != -490406)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (116679 - 447526 != -330846)
				{
					Game.mGameState = eGameState.Setup;
					if (13688 - 558065 != -544376)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007FC4 RID: 32708 RVA: 0x01061ADC File Offset: 0x0105FCDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (261512 - 157139 != 104374)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (180013 - 11873 == 168140)
			{
				if (num == PlayerData.UID)
				{
					if (68714 - 167353 != -98638)
					{
						this.SetupActors();
						if (260192 - 594494 == -334302)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (185614 - 298193 == -112579)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007FC5 RID: 32709 RVA: 0x01061BAC File Offset: 0x0105FDAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (69944 - 535085 != -465141)
		{
		}
		for (;;)
		{
			IL_43:
			Debug.Log("Creating Actors");
			if (177097 - 491006 == -313909)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (150084 - 549461 != -399376)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (162564 - 357172 == -194608)
						{
							int i = 0;
							if (103445 - 49619 != 53827)
							{
								CharacterControl[] array2 = array;
								if (99006 - 142831 == -43825)
								{
									int length = array2.Length;
									if (183907 - 99138 != 84770)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (3646 - 543214 != -539568)
											{
												goto IL_43;
											}
											if (type == "FudaBug_b")
											{
												goto IL_263;
											}
											if (266327 - 9817 != 256510)
											{
												goto IL_43;
											}
											if (type == "FudaBug_r")
											{
												goto IL_263;
											}
											if (15150 - 484586 != -469436)
											{
												goto IL_43;
											}
											if (type == "FlowerBug_b")
											{
												goto IL_263;
											}
											if (226042 - 378650 == -152607)
											{
												goto IL_43;
											}
											if (type == "LionBug_b")
											{
												goto IL_263;
											}
											if (27864 - 469286 == -441421)
											{
												goto IL_43;
											}
											if (type == "Phoenix4")
											{
												if (182648 - 423243 != -240594)
												{
													goto IL_263;
												}
												goto IL_43;
											}
											IL_B7:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (269801 - 277969 != -8168)
											{
												goto IL_43;
											}
											this.aDbcAPOprXq++;
											if (214271 - 320978 == -106706)
											{
												goto IL_43;
											}
											i++;
											if (172361 - 542889 != -370527)
											{
												continue;
											}
											goto IL_43;
											IL_263:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (275900 - 341777 != -65877)
											{
												goto IL_43;
											}
											goto IL_B7;
										}
										if (86610 - 293098 == -206488)
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
						if (39284 - 102556 == -63272)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007FC6 RID: 32710 RVA: 0x01061EC8 File Offset: 0x010600C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (240604 - 199144 != 41461)
		{
		}
		for (;;)
		{
			IL_92:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (266250 - 394567 != -128316)
			{
				int i = 0;
				if (264748 - 357801 != -93052)
				{
					CharacterControl[] array2 = array;
					if (123811 - 488739 == -364928)
					{
						int length = array2.Length;
						if (283982 - 407239 != -123256)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (267345 - 445500 == -178154)
								{
									goto IL_92;
								}
								i++;
								if (238932 - 138081 == 100852)
								{
									goto IL_92;
								}
							}
							if (64022 - 526415 != -462392)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007FC7 RID: 32711 RVA: 0x01061FF8 File Offset: 0x010601F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (39393 - 584523 != -545130)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (67212 - 575396 == -508184)
			{
				hashtable.Add(43, PlayerData.UID);
				if (161446 - 239482 != -78035)
				{
					hashtable.Add(73, nType);
					if (92667 - 530353 == -437686)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (146669 - 410155 == -263486)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (43919 - 63535 != -19615)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (46582 - 490663 != -444080)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (62338 - 43009 != 19330)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (277419 - 170595 != 106825)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (144628 - 180152 == -35524)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (146699 - 194946 != -48246)
												{
													this.KlKcA7tQslx.OpCustom(63, hashtable, true);
													if (116049 - 246825 == -130776)
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

	// Token: 0x06007FC8 RID: 32712 RVA: 0x010622B0 File Offset: 0x010604B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (296027 - 442275 != -146248)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createActor(data);
			if (115234 - 299719 != -184484)
			{
				if (Game.mGameState != eGameState.Setup)
				{
					break;
				}
				if (227628 - 27240 != 200389)
				{
					if (this.aDbcAPOprXq <= 0)
					{
						break;
					}
					if (15987 - 148657 != -132669)
					{
						this.aDbcAPOprXq--;
						if (256796 - 574985 == -318189)
						{
							if (this.aDbcAPOprXq != 0)
							{
								break;
							}
							if (193890 - 265468 == -71578)
							{
								Game.setGameState(eGameState.Ready);
								if (185676 - 360999 != -175322)
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

	// Token: 0x06007FC9 RID: 32713 RVA: 0x010623C4 File Offset: 0x010605C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06007FCA RID: 32714 RVA: 0x010623D8 File Offset: 0x010605D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (99708 - 108724 != -9015)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (159556 - 262645 == -103089)
			{
				if (!characterControl)
				{
					break;
				}
				if (132844 - 461513 != -328668)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (143478 - 545049 == -401571)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (248077 - 492808 != -244730)
						{
							string type = characterControl.Type;
							if (223256 - 540192 != -316935)
							{
								if (type == "FudaBug_b")
								{
									if (110295 - 585156 == -474860)
									{
										continue;
									}
								}
								else if (type == "FudaBug_r")
								{
									if (50310 - 303194 != -252884)
									{
										continue;
									}
								}
								else if (type == "FlowerBug_b")
								{
									if (93482 - 404140 == -310657)
									{
										continue;
									}
									Game.sendMissionEvent(5013, 0);
									if (11860 - 247236 != -235376)
									{
										continue;
									}
									break;
								}
								else if (type == "LionBug_b")
								{
									if (119885 - 349107 != -229222)
									{
										continue;
									}
									Game.sendMissionEvent(5014, 0);
									if (26579 - 62467 != -35887)
									{
										break;
									}
									continue;
								}
								else
								{
									if (!(type == "WormBug_p"))
									{
										break;
									}
									if (260376 - 437707 == -177330)
									{
										continue;
									}
									Game.sendMissionEvent(5015, 0);
									if (205056 - 564776 != -359720)
									{
										continue;
									}
									break;
								}
								Game.sendMissionEvent(5012, 0);
								if (80515 - 66886 != 13630)
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

	// Token: 0x06007FCB RID: 32715 RVA: 0x01062650 File Offset: 0x01060850
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (164006 - 187308 != -23301)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (112793 - 277205 == -164412)
			{
				Game.mGameState = eGameState.Ready;
				if (295640 - 368286 != -72645)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (88494 - 326415 == -237921)
					{
						GameObject gameObject = null;
						if (296061 - 397815 != -101753)
						{
							GameObject gameObject2 = null;
							if (219534 - 213864 != 5671)
							{
								if (playerSlot > 1)
								{
									if (42021 - 97578 == -55556)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (236205 - 128808 != 107397)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (284567 - 163083 == 121485)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (172594 - 460795 != -288201)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (128681 - 450304 == -321622)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (259128 - 464122 != -204994)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (147308 - 210993 == -63684)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (95735 - 329945 != -234210)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (290093 - 95764 != 194329)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (77350 - 549883 != -472533)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (277355 - 386174 != -108818)
								{
									this.transform.position = gameObject2.transform.position;
									if (94575 - 499106 == -404531)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (180323 - 251997 != -71673)
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

	// Token: 0x06007FCC RID: 32716 RVA: 0x0106294C File Offset: 0x01060B4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (243412 - 202856 != 40557)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (145611 - 4512 != 141100)
			{
				Game.mGameState = eGameState.Normal;
				if (186504 - 546057 != -359552)
				{
					Time.timeScale = 1f;
					if (182308 - 116007 == 66301)
					{
						this.i0QcAEpD0cP = new int[2];
						if (205968 - 387487 != -181518)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (171510 - 111652 != 59859)
							{
								gameGui.enabled = true;
								if (96357 - 55879 != 40479)
								{
									LoadingGui loadingGui = (LoadingGui)this.GetComponent(typeof(LoadingGui));
									if (277148 - 268375 != 8774)
									{
										loadingGui.fadeIn();
										if (205771 - 441171 == -235400)
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

	// Token: 0x06007FCD RID: 32717 RVA: 0x01062AB4 File Offset: 0x01060CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007FCE RID: 32718 RVA: 0x01062AB8 File Offset: 0x01060CB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (218652 - 24233 != 194419)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (136787 - 234927 != -98139)
			{
				hashtable.Add(71, CID);
				if (192394 - 68261 == 124133)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (287665 - 139940 == 147725)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (223991 - 314569 != -90577)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (137428 - 504248 != -366819)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (197581 - 569276 == -371695)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (217305 - 456222 != -238916)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (231002 - 9726 != 221277)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (73377 - 7054 == 66323)
											{
												this.KlKcA7tQslx.OpCustom(61, hashtable, true);
												if (231267 - 54389 != 176879)
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

	// Token: 0x06007FCF RID: 32719 RVA: 0x01062D44 File Offset: 0x01060F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (284610 - 397062 != -112452)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (123048 - 252899 == -129851)
			{
				if (!gameObject)
				{
					break;
				}
				if (80042 - 108950 == -28908)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (156187 - 403763 != -247575)
					{
						playerCameraControl.target = gameObject;
						if (141260 - 453463 != -312202)
						{
							if (Game.useAdvanceMode)
							{
								if (274574 - 463554 == -188979)
								{
									continue;
								}
								Game.loadPlayer();
								if (161435 - 33907 != 127528)
								{
									continue;
								}
							}
							this.StartGame();
							if (252939 - 187482 == 65457)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007FD0 RID: 32720 RVA: 0x01062E78 File Offset: 0x01061078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (251482 - 159526 != 91957)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (48114 - 129407 == -81293)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (6524 - 211747 == -205223)
				{
					gameGui.ResetTeamBar();
					if (242552 - 154000 == 88552)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007FD1 RID: 32721 RVA: 0x01062F24 File Offset: 0x01061124
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M501_ThroughTheSwamp2.$onDeadPlayer$39130(this).GetEnumerator();
	}

	// Token: 0x06007FD2 RID: 32722 RVA: 0x01062F34 File Offset: 0x01061134
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (286371 - 449014 != -162642)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (240563 - 483856 != -243292)
			{
				this.RP8cAZiwdsr.target = Game.mPlayer;
				if (139485 - 309399 == -169914)
				{
					this.RP8cAZiwdsr.enabled = true;
					if (294378 - 439770 == -145392)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (253869 - 444035 == -190165)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (253422 - 48928 == 204495)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (248509 - 27714 != 220796)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (127120 - 459382 != -332261)
							{
								if (!gameGui)
								{
									break;
								}
								if (209017 - 39901 != 169117)
								{
									gameGui.enabled = true;
									if (42796 - 269794 == -226998)
									{
										gameGui.closeDeadMenu();
										if (3632 - 34406 != -30773)
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

	// Token: 0x06007FD3 RID: 32723 RVA: 0x010630E0 File Offset: 0x010612E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (252580 - 315121 != -62541)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (268109 - 287133 != -19023)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (108211 - 569522 != -461310)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (125592 - 335463 == -209871)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007FD4 RID: 32724 RVA: 0x010631A4 File Offset: 0x010613A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007FD5 RID: 32725 RVA: 0x010631D0 File Offset: 0x010613D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M501_ThroughTheSwamp2.$ReturnToTown$39136(this).GetEnumerator();
	}

	// Token: 0x06007FD6 RID: 32726 RVA: 0x010631E0 File Offset: 0x010613E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M501_ThroughTheSwamp2.$ReturnToGuild$39141(this).GetEnumerator();
	}

	// Token: 0x06007FD7 RID: 32727 RVA: 0x010631F0 File Offset: 0x010613F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M501_ThroughTheSwamp2.$ReturnToCamp$39145(this).GetEnumerator();
	}

	// Token: 0x06007FD8 RID: 32728 RVA: 0x01063200 File Offset: 0x01061400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (223423 - 457765 != -234341)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (67127 - 436288 != -369160)
			{
				Hashtable hashtable = new Hashtable();
				if (15558 - 276605 == -261047)
				{
					hashtable.Add(43, PlayerData.UID);
					if (19310 - 101378 == -82068)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (282819 - 117530 != 165290)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007FD9 RID: 32729 RVA: 0x010632D8 File Offset: 0x010614D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007FDA RID: 32730 RVA: 0x010632EC File Offset: 0x010614EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (104798 - 119559 != -14760)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (268473 - 488348 == -219875)
			{
				Hashtable hashtable = new Hashtable();
				if (72241 - 70943 == 1298)
				{
					if (Game.mNextGameCode == 30)
					{
						if (96438 - 160684 == -64245)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (42074 - 100523 == -58448)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (190052 - 431636 == -241583)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (268837 - 100252 != 168585)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (51839 - 327240 != -275401)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (208382 - 284038 != -75656)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (262763 - 522256 == -259492)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (2582 - 108329 == -105746)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (252799 - 274093 == -21293)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (28022 - 17350 != 10672)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (125124 - 114939 != 10185)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (7390 - 157573 == -150182)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (110828 - 101495 == 9334)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (109663 - 349807 != -240144)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (284787 - 29077 != 255710)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (21579 - 460221 != -438642)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (8413 - 160657 != -152244)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (118079 - 44478 == 73602)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (51978 - 223983 == -172004)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (119129 - 370913 != -251784)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (162172 - 411717 == -249544)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (275258 - 284894 == -9635)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (185105 - 260717 != -75612)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (255117 - 533476 == -278358)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (108060 - 70661 == 37400)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (259954 - 117380 == 142575)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (34541 - 221702 == -187160)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (264821 - 116590 != 148231)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (17760 - 129858 == -112098)
					{
						this.KlKcA7tQslx.OpCustom(42, hashtable, true);
						if (53643 - 67923 == -14280)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007FDB RID: 32731 RVA: 0x010638A0 File Offset: 0x01061AA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007FDC RID: 32732 RVA: 0x010638B0 File Offset: 0x01061AB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007FDD RID: 32733 RVA: 0x010638B4 File Offset: 0x01061AB4
	internal static bool Jts3tWpePGBrlkTXliIm()
	{
		return true;
	}

	// Token: 0x06007FDE RID: 32734 RVA: 0x010638B8 File Offset: 0x01061AB8
	internal static bool U0XmYKpe0LjSEpBAm15v()
	{
		return false;
	}

	// Token: 0x04007F16 RID: 32534
	private LitePeer KlKcA7tQslx;

	// Token: 0x04007F17 RID: 32535
	private PlayerCameraControl RP8cAZiwdsr;

	// Token: 0x04007F18 RID: 32536
	private float RP4cAC4hhlg;

	// Token: 0x04007F19 RID: 32537
	private int GN1cAMjnDhn;

	// Token: 0x04007F1A RID: 32538
	private int kilcAf8PxCq;

	// Token: 0x04007F1B RID: 32539
	private int CaicALxmECx;

	// Token: 0x04007F1C RID: 32540
	private int w9pcAwEvVO0;

	// Token: 0x04007F1D RID: 32541
	private int UsQcAUD52Uv;

	// Token: 0x04007F1E RID: 32542
	private int KShcANQA8iW;

	// Token: 0x04007F1F RID: 32543
	private int[] i0QcAEpD0cP;

	// Token: 0x04007F20 RID: 32544
	public GameObject manaPillarEffect;

	// Token: 0x04007F21 RID: 32545
	private int aDbcAPOprXq;

	// Token: 0x02001588 RID: 5512
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$39105 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007FDF RID: 32735 RVA: 0x010638BC File Offset: 0x01061ABC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$39105(Hashtable data, M501_ThroughTheSwamp2 self_)
		{
			if (284607 - 64669 != 219938)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (286967 - 553621 == -266654)
				{
					base..ctor();
					if (165072 - 265236 != -100163)
					{
						this.$data$39119 = data;
						if (286986 - 367398 != -80411)
						{
							this.$self_$39120 = self_;
							if (79018 - 374326 == -295308)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007FE0 RID: 32736 RVA: 0x01063978 File Offset: 0x01061B78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp2.$onGameEvent$39105.$(this.$data$39119, this.$self_$39120);
		}

		// Token: 0x06007FE1 RID: 32737 RVA: 0x0106398C File Offset: 0x01061B8C
		internal static bool WL2lVopebtNRABB4xpUC()
		{
			return true;
		}

		// Token: 0x06007FE2 RID: 32738 RVA: 0x01063990 File Offset: 0x01061B90
		internal static bool sTknGPpeugMcvIO72rqZ()
		{
			return false;
		}

		// Token: 0x04007F22 RID: 32546
		internal Hashtable $data$39119;

		// Token: 0x04007F23 RID: 32547
		internal M501_ThroughTheSwamp2 $self_$39120;

		// Token: 0x02001589 RID: 5513
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007FE3 RID: 32739 RVA: 0x01063994 File Offset: 0x01061B94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M501_ThroughTheSwamp2 self_)
			{
				if (227637 - 534369 != -306731)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (91152 - 331244 != -240091)
					{
						base..ctor();
						if (139606 - 298655 == -159049)
						{
							this.$data$39117 = data;
							if (219555 - 468029 != -248473)
							{
								this.$self_$39118 = self_;
								if (291507 - 352527 == -61020)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007FE4 RID: 32740 RVA: 0x01063A50 File Offset: 0x01061C50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (88228 - 493372 != -405143)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C67;
					case 2:
						Game.mGameStage = 3;
						if (246602 - 553929 != -307327)
						{
							continue;
						}
						Application.LoadLevel("M501_ThroughTheSwamp3");
						if (177723 - 143811 != 33913)
						{
							goto IL_94B;
						}
						continue;
					case 3:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (16483 - 407391 != -390907)
							{
								goto Block_72;
							}
							continue;
						}
						else
						{
							this.$mFudaSpawnPoint$39111 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 4));
							if (72286 - 423160 == -350873)
							{
								continue;
							}
							if (!this.$mFudaSpawnPoint$39111)
							{
								goto IL_1AA;
							}
							if (93211 - 26470 != 66741)
							{
								continue;
							}
							this.$mFudaSpawnPos$39112 = global::Math.getRandomSpawnPos(this.$mFudaSpawnPoint$39111.transform.position, 5);
							if (89927 - 188979 != -99052)
							{
								continue;
							}
							if (this.$mFudaSpawnPos$39112 == Vector3.zero)
							{
								if (152462 - 95871 == 56592)
								{
									continue;
								}
								this.$mFudaSpawnPos$39112 = this.$mFudaSpawnPoint$39111.transform.position;
								if (223778 - 571361 == -347582)
								{
									continue;
								}
							}
							if (UnityEngine.Random.Range(0, 100) < 60)
							{
								if (47037 - 148294 != -101257)
								{
									continue;
								}
								this.$self_$39118.createActor("FudaBug_b", 6, this.$mFudaSpawnPos$39112, this.$mFudaSpawnPoint$39111.transform.forward);
								if (260719 - 551419 != -290700)
								{
									continue;
								}
								goto IL_1AA;
							}
							else
							{
								this.$self_$39118.createActor("FudaBug_r", 6, this.$mFudaSpawnPos$39112, this.$mFudaSpawnPoint$39111.transform.forward);
								if (146922 - 288448 != -141526)
								{
									continue;
								}
								goto IL_1AA;
							}
						}
						break;
					case 4:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (294457 - 519007 != -224549)
							{
								goto Block_50;
							}
							continue;
						}
						else
						{
							this.$mFlowerSpawnPoint$39113 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(4, 6));
							if (120791 - 421979 != -301188)
							{
								continue;
							}
							if (!this.$mFlowerSpawnPoint$39113)
							{
								goto IL_8E5;
							}
							if (102732 - 400974 != -298242)
							{
								continue;
							}
							this.$mFlowerSpawnPos$39114 = global::Math.getRandomSpawnPos(this.$mFlowerSpawnPoint$39113.transform.position, 5);
							if (134626 - 275277 == -140650)
							{
								continue;
							}
							if (this.$mFlowerSpawnPos$39114 == Vector3.zero)
							{
								if (231031 - 436884 == -205852)
								{
									continue;
								}
								this.$mFlowerSpawnPos$39114 = this.$mFlowerSpawnPoint$39113.transform.position;
								if (97954 - 437613 == -339658)
								{
									continue;
								}
							}
							this.$self_$39118.createActor("FlowerBug_b", 6, this.$mFlowerSpawnPos$39114, this.$mFlowerSpawnPoint$39113.transform.forward);
							if (53597 - 475395 != -421797)
							{
								goto IL_8E5;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (12114 - 110732 != -98617)
							{
								goto Block_57;
							}
							continue;
						}
						else
						{
							this.$mLionSpawnPoint$39115 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(6, 9));
							if (41620 - 364043 != -322423)
							{
								continue;
							}
							if (!this.$mLionSpawnPoint$39115)
							{
								goto IL_ACD;
							}
							if (190982 - 376088 == -185105)
							{
								continue;
							}
							this.$mLionSpawnPos$39116 = global::Math.getRandomSpawnPos(this.$mLionSpawnPoint$39115.transform.position, 5);
							if (193460 - 459132 != -265672)
							{
								continue;
							}
							if (this.$mLionSpawnPos$39116 == Vector3.zero)
							{
								if (87314 - 223986 != -136672)
								{
									continue;
								}
								this.$mLionSpawnPos$39116 = this.$mLionSpawnPoint$39115.transform.position;
								if (77481 - 56289 != 21192)
								{
									continue;
								}
							}
							this.$self_$39118.createActor("LionBug_b", 6, this.$mLionSpawnPos$39116, this.$mLionSpawnPoint$39115.transform.forward);
							if (127147 - 522331 != -395184)
							{
								continue;
							}
							goto IL_ACD;
						}
						break;
					default:
						if (139155 - 271492 != -132337)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (189526 - 109759 != 79767)
						{
							continue;
						}
						goto IL_B22;
					}
					else
					{
						this.$returnCode$39106 = RuntimeServices.UnboxInt32(this.$data$39117[141]);
						if (84863 - 141300 != -56437)
						{
							continue;
						}
						this.$returnValue$39107 = RuntimeServices.UnboxInt32(this.$data$39117[145]);
						if (117944 - 288035 != -170091)
						{
							continue;
						}
						this.$ownerID$39108 = RuntimeServices.UnboxInt32(this.$data$39117[43]);
						if (192582 - 549560 == -356977)
						{
							continue;
						}
						this.$$switch$6857$39109 = this.$returnCode$39106;
						if (20941 - 14688 != 6253)
						{
							continue;
						}
						if (this.$$switch$6857$39109 == 5011)
						{
							if (259399 - 133919 == 125481)
							{
								continue;
							}
							if (this.$returnValue$39107 == 2)
							{
								if (91575 - 165524 == -73948)
								{
									continue;
								}
								if (this.$self_$39118.GN1cAMjnDhn < 2)
								{
									if (70659 - 198414 == -127754)
									{
										continue;
									}
									this.$self_$39118.GN1cAMjnDhn = 2;
									if (180915 - 589819 != -408904)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (186601 - 23303 != 163298)
									{
										continue;
									}
									this.$mGameGui$39110 = (GameGui)this.$self_$39118.GetComponent(typeof(GameGui));
									if (296536 - 440822 != -144286)
									{
										continue;
									}
									this.$mGameGui$39110.close();
									if (217293 - 74347 == 142947)
									{
										continue;
									}
									Game.savePlayer();
									if (2262 - 517460 == -515197)
									{
										continue;
									}
									this.$self_$39118.SendMessage("fadeOut");
									if (2086 - 271526 != -269439)
									{
										break;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$6857$39109 == 5012)
						{
							if (266073 - 129923 == 136151)
							{
								continue;
							}
							this.$self_$39118.kilcAf8PxCq = this.$self_$39118.kilcAf8PxCq + 1;
							if (180609 - 68453 != 112156)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$39108)
							{
								if (282777 - 374002 == -91224)
								{
									continue;
								}
								if (this.$self_$39118.kilcAf8PxCq >= 2)
								{
									if (287828 - 247297 == 40532)
									{
										continue;
									}
									if (this.$self_$39118.kilcAf8PxCq < 24)
									{
										if (132981 - 257394 != -124412)
										{
											goto Block_55;
										}
										continue;
									}
								}
							}
						}
						else if (this.$$switch$6857$39109 == 5013)
						{
							if (197708 - 95289 != 102419)
							{
								continue;
							}
							this.$self_$39118.CaicALxmECx = this.$self_$39118.CaicALxmECx + 1;
							if (125083 - 269685 != -144602)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$39108)
							{
								if (237289 - 164754 == 72536)
								{
									continue;
								}
								if (this.$self_$39118.CaicALxmECx >= 2)
								{
									if (245329 - 598700 != -353371)
									{
										continue;
									}
									if (this.$self_$39118.CaicALxmECx < 24)
									{
										if (131886 - 247598 != -115712)
										{
											continue;
										}
										goto IL_661;
									}
								}
							}
						}
						else if (this.$$switch$6857$39109 == 5014)
						{
							if (272473 - 78011 != 194462)
							{
								continue;
							}
							this.$self_$39118.w9pcAwEvVO0 = this.$self_$39118.w9pcAwEvVO0 + 1;
							if (204086 - 193488 == 10599)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$39108)
							{
								if (95945 - 463259 == -367313)
								{
									continue;
								}
								if (this.$self_$39118.w9pcAwEvVO0 < 24)
								{
									if (606 - 405592 != -404986)
									{
										continue;
									}
									goto IL_76F;
								}
							}
						}
						else if (this.$$switch$6857$39109 == 5015)
						{
							if (140592 - 535103 != -394511)
							{
								continue;
							}
							this.$self_$39118.UsQcAUD52Uv = this.$self_$39118.UsQcAUD52Uv + 1;
							if (33109 - 404410 != -371301)
							{
								continue;
							}
						}
						else if (this.$$switch$6857$39109 == 5016)
						{
							if (70761 - 91292 == -20530)
							{
								continue;
							}
							if (this.$self_$39118.i0QcAEpD0cP[this.$returnValue$39107 - 1] > 0)
							{
								if (33214 - 115790 != -82576)
								{
									continue;
								}
								this.$self_$39118.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
								if (16047 - 411097 != -395050)
								{
									continue;
								}
							}
							else
							{
								this.$self_$39118.i0QcAEpD0cP[this.$returnValue$39107 - 1] = 1;
								if (186258 - 72827 != 113431)
								{
									continue;
								}
								this.$self_$39118.KShcANQA8iW = this.$self_$39118.KShcANQA8iW + 1;
								if (96149 - 177408 != -81259)
								{
									continue;
								}
								this.$self_$39118.ActivateManaPillar(this.$returnValue$39107);
								if (162329 - 431672 != -269343)
								{
									continue;
								}
								this.$self_$39118.SendMessage("newGameMessage", "ManaPillar activated :" + this.$self_$39118.KShcANQA8iW + "/4");
								if (212851 - 47462 == 165390)
								{
									continue;
								}
							}
						}
					}
					IL_63F:
					this.YieldDefault(1);
					if (212666 - 41489 != 171177)
					{
						continue;
					}
					goto IL_C67;
					IL_ACD:
					IL_94B:
					IL_8E5:
					IL_1AA:
					goto IL_63F;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_661:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_50:
				goto IL_C67;
				Block_55:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_76F:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_57:
				Block_72:
				IL_B22:
				IL_C67:
				return false;
			}

			// Token: 0x06007FE5 RID: 32741 RVA: 0x010646D8 File Offset: 0x010628D8
			internal static bool OgPAKNpeIfWqXGcC5mP0()
			{
				return true;
			}

			// Token: 0x06007FE6 RID: 32742 RVA: 0x010646DC File Offset: 0x010628DC
			internal static bool BSnQBxpeBjMPiQ19NhmV()
			{
				return false;
			}

			// Token: 0x04007F24 RID: 32548
			internal int $returnCode$39106;

			// Token: 0x04007F25 RID: 32549
			internal int $returnValue$39107;

			// Token: 0x04007F26 RID: 32550
			internal int $ownerID$39108;

			// Token: 0x04007F27 RID: 32551
			internal int $$switch$6857$39109;

			// Token: 0x04007F28 RID: 32552
			internal GameGui $mGameGui$39110;

			// Token: 0x04007F29 RID: 32553
			internal GameObject $mFudaSpawnPoint$39111;

			// Token: 0x04007F2A RID: 32554
			internal Vector3 $mFudaSpawnPos$39112;

			// Token: 0x04007F2B RID: 32555
			internal GameObject $mFlowerSpawnPoint$39113;

			// Token: 0x04007F2C RID: 32556
			internal Vector3 $mFlowerSpawnPos$39114;

			// Token: 0x04007F2D RID: 32557
			internal GameObject $mLionSpawnPoint$39115;

			// Token: 0x04007F2E RID: 32558
			internal Vector3 $mLionSpawnPos$39116;

			// Token: 0x04007F2F RID: 32559
			internal Hashtable $data$39117;

			// Token: 0x04007F30 RID: 32560
			internal M501_ThroughTheSwamp2 $self_$39118;
		}
	}

	// Token: 0x0200158A RID: 5514
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39121 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007FE7 RID: 32743 RVA: 0x010646E0 File Offset: 0x010628E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39121(Hashtable data, M501_ThroughTheSwamp2 self_)
		{
			if (249716 - 155319 != 94397)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (200741 - 460248 == -259507)
				{
					base..ctor();
					if (177463 - 213052 == -35589)
					{
						this.$data$39128 = data;
						if (199439 - 168700 != 30740)
						{
							this.$self_$39129 = self_;
							if (87897 - 229610 != -141712)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007FE8 RID: 32744 RVA: 0x0106479C File Offset: 0x0106299C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp2.$onGameComplete$39121.$(this.$data$39128, this.$self_$39129);
		}

		// Token: 0x06007FE9 RID: 32745 RVA: 0x010647B0 File Offset: 0x010629B0
		internal static bool Lspc0apeedYDF5CsbrEm()
		{
			return true;
		}

		// Token: 0x06007FEA RID: 32746 RVA: 0x010647B4 File Offset: 0x010629B4
		internal static bool dj9deJperm6P95VXNs3c()
		{
			return false;
		}

		// Token: 0x04007F31 RID: 32561
		internal Hashtable $data$39128;

		// Token: 0x04007F32 RID: 32562
		internal M501_ThroughTheSwamp2 $self_$39129;

		// Token: 0x0200158B RID: 5515
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007FEB RID: 32747 RVA: 0x010647B8 File Offset: 0x010629B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M501_ThroughTheSwamp2 self_)
			{
				if (287409 - 155720 != 131689)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (238273 - 118326 != 119948)
					{
						base..ctor();
						if (198179 - 595939 == -397760)
						{
							this.$data$39126 = data;
							if (187661 - 561317 != -373655)
							{
								this.$self_$39127 = self_;
								if (261871 - 234838 != 27034)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007FEC RID: 32748 RVA: 0x01064874 File Offset: 0x01062A74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (264120 - 197122 != 66999)
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
						this.$mCompleteGui$39123 = (CompleteGui)this.$self_$39127.GetComponent(typeof(CompleteGui));
						if (28510 - 452498 != -423988)
						{
							continue;
						}
						this.$mCompleteGui$39123.Init();
						if (136004 - 487009 != -351005)
						{
							continue;
						}
						this.$mCompleteGui$39123.readData(this.$data$39126);
						if (198099 - 398086 != -199987)
						{
							continue;
						}
						if (this.$result$39122 == 1)
						{
							if (136178 - 301880 == -165701)
							{
								continue;
							}
							this.$mCompleteGui$39123.displayResult(eCompleteType.Success);
							if (35500 - 486308 != -450808)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39123.displayResult(eCompleteType.Failed);
							if (112562 - 93385 == 19178)
							{
								continue;
							}
						}
						this.$mGameGui$39124 = (GameGui)this.$self_$39127.GetComponent(typeof(GameGui));
						if (236166 - 462253 == -226086)
						{
							continue;
						}
						this.$mStoryGui$39125 = (StoryGui)this.$self_$39127.GetComponent(typeof(StoryGui));
						if (39713 - 496771 == -457057)
						{
							continue;
						}
						if (this.$mGameGui$39124)
						{
							if (39672 - 66449 != -26777)
							{
								continue;
							}
							this.$mGameGui$39124.close();
							if (283022 - 10769 == 272254)
							{
								continue;
							}
						}
						if (this.$mStoryGui$39125)
						{
							if (288001 - 67669 != 220332)
							{
								continue;
							}
							this.$mStoryGui$39125.close();
							if (139910 - 350420 != -210510)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (174854 - 593558 != -418703)
						{
							goto Block_18;
						}
						continue;
					default:
						if (40995 - 496496 == -455500)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$39126[31]);
					if (68749 - 461128 != -392378)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (80967 - 102781 == -21814)
							{
								goto IL_10A;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (174544 - 256468 != -81923)
							{
								this.$result$39122 = RuntimeServices.UnboxInt32(this.$data$39126[31]);
								if (241419 - 499482 == -258063)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_10A:
				Block_18:
				IL_352:
				return false;
			}

			// Token: 0x06007FED RID: 32749 RVA: 0x01064BE8 File Offset: 0x01062DE8
			internal static bool TWT5mKpejTMIjsphNTkU()
			{
				return true;
			}

			// Token: 0x06007FEE RID: 32750 RVA: 0x01064BEC File Offset: 0x01062DEC
			internal static bool J4joL6peh71vBgu4OVeV()
			{
				return false;
			}

			// Token: 0x04007F33 RID: 32563
			internal int $result$39122;

			// Token: 0x04007F34 RID: 32564
			internal CompleteGui $mCompleteGui$39123;

			// Token: 0x04007F35 RID: 32565
			internal GameGui $mGameGui$39124;

			// Token: 0x04007F36 RID: 32566
			internal StoryGui $mStoryGui$39125;

			// Token: 0x04007F37 RID: 32567
			internal Hashtable $data$39126;

			// Token: 0x04007F38 RID: 32568
			internal M501_ThroughTheSwamp2 $self_$39127;
		}
	}

	// Token: 0x0200158C RID: 5516
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39130 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007FEF RID: 32751 RVA: 0x01064BF0 File Offset: 0x01062DF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39130(M501_ThroughTheSwamp2 self_)
		{
			if (6427 - 39521 != -33093)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (189136 - 163814 != 25323)
				{
					base..ctor();
					if (275087 - 229203 == 45884)
					{
						this.$self_$39135 = self_;
						if (207307 - 430812 != -223504)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007FF0 RID: 32752 RVA: 0x01064C88 File Offset: 0x01062E88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp2.$onDeadPlayer$39130.$(this.$self_$39135);
		}

		// Token: 0x06007FF1 RID: 32753 RVA: 0x01064C98 File Offset: 0x01062E98
		internal static bool iJ8sFKpest0kXwsKmPyK()
		{
			return true;
		}

		// Token: 0x06007FF2 RID: 32754 RVA: 0x01064C9C File Offset: 0x01062E9C
		internal static bool DhUx7Ype9dE2MDunAxen()
		{
			return false;
		}

		// Token: 0x04007F39 RID: 32569
		internal M501_ThroughTheSwamp2 $self_$39135;

		// Token: 0x0200158D RID: 5517
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007FF3 RID: 32755 RVA: 0x01064CA0 File Offset: 0x01062EA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M501_ThroughTheSwamp2 self_)
			{
				if (21135 - 84776 != -63641)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (282478 - 399105 == -116627)
					{
						base..ctor();
						if (46334 - 425215 == -378881)
						{
							this.$self_$39134 = self_;
							if (141471 - 33489 != 107983)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007FF4 RID: 32756 RVA: 0x01064D38 File Offset: 0x01062F38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223719 - 584169 != -360449)
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
							if (221213 - 315338 == -94124)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1B9;
							}
							if (176151 - 30516 == 145636)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (156680 - 350113 != -193433)
						{
							continue;
						}
						this.$mStoryGui$39131 = (StoryGui)this.$self_$39134.GetComponent(typeof(StoryGui));
						if (11167 - 54634 != -43467)
						{
							continue;
						}
						if (this.$mStoryGui$39131)
						{
							if (154088 - 430957 != -276869)
							{
								continue;
							}
							this.$mStoryGui$39131.close();
							if (224222 - 498969 != -274747)
							{
								continue;
							}
						}
						this.$mChangeGui$39132 = (ChangeGui)this.$self_$39134.GetComponent(typeof(ChangeGui));
						if (134143 - 294960 == -160816)
						{
							continue;
						}
						if (this.$mChangeGui$39132)
						{
							if (33766 - 410689 != -376923)
							{
								continue;
							}
							this.$mChangeGui$39132.close();
							if (285596 - 254118 == 31479)
							{
								continue;
							}
						}
						this.$mGameGui$39133 = (GameGui)this.$self_$39134.GetComponent(typeof(GameGui));
						if (14151 - 194229 == -180077)
						{
							continue;
						}
						if (this.$mGameGui$39133)
						{
							if (94327 - 466765 == -372437)
							{
								continue;
							}
							if (!this.$mGameGui$39133.enabled)
							{
								if (45529 - 318671 == -273141)
								{
									continue;
								}
								this.$mGameGui$39133.enabled = true;
								if (228250 - 98841 == 129410)
								{
									continue;
								}
							}
							this.$mGameGui$39133.openDeadMenu();
							if (9255 - 575621 == -566365)
							{
								continue;
							}
						}
						IL_1B9:
						this.YieldDefault(1);
						if (141413 - 191116 != -49703)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (266931 - 74128 == 192804)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (274777 - 127919 == 146859);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007FF5 RID: 32757 RVA: 0x01065050 File Offset: 0x01063250
			internal static bool ODEcDGpe1fZ9ojNA6lHS()
			{
				return true;
			}

			// Token: 0x06007FF6 RID: 32758 RVA: 0x01065054 File Offset: 0x01063254
			internal static bool xGej6Kpe44Om6dXuTBVL()
			{
				return false;
			}

			// Token: 0x04007F3A RID: 32570
			internal StoryGui $mStoryGui$39131;

			// Token: 0x04007F3B RID: 32571
			internal ChangeGui $mChangeGui$39132;

			// Token: 0x04007F3C RID: 32572
			internal GameGui $mGameGui$39133;

			// Token: 0x04007F3D RID: 32573
			internal M501_ThroughTheSwamp2 $self_$39134;
		}
	}

	// Token: 0x0200158E RID: 5518
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39136 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007FF7 RID: 32759 RVA: 0x01065058 File Offset: 0x01063258
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39136(M501_ThroughTheSwamp2 self_)
		{
			if (31382 - 264761 != -233379)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (219914 - 367013 != -147098)
				{
					base..ctor();
					if (217030 - 176661 != 40370)
					{
						this.$self_$39140 = self_;
						if (183632 - 440649 != -257016)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007FF8 RID: 32760 RVA: 0x010650F0 File Offset: 0x010632F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp2.$ReturnToTown$39136.$(this.$self_$39140);
		}

		// Token: 0x06007FF9 RID: 32761 RVA: 0x01065100 File Offset: 0x01063300
		internal static bool chLidUpez1DS29n2aj67()
		{
			return true;
		}

		// Token: 0x06007FFA RID: 32762 RVA: 0x01065104 File Offset: 0x01063304
		internal static bool Hr87k0praImqx1R34pOR()
		{
			return false;
		}

		// Token: 0x04007F3E RID: 32574
		internal M501_ThroughTheSwamp2 $self_$39140;

		// Token: 0x0200158F RID: 5519
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007FFB RID: 32763 RVA: 0x01065108 File Offset: 0x01063308
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M501_ThroughTheSwamp2 self_)
			{
				if (265646 - 17579 != 248067)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (42511 - 440950 != -398438)
					{
						base..ctor();
						if (32908 - 33431 == -523)
						{
							this.$self_$39139 = self_;
							if (211837 - 33811 == 178026)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007FFC RID: 32764 RVA: 0x010651A0 File Offset: 0x010633A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (147690 - 377641 != -229951)
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
						this.$self_$39139.LeaveGame();
						if (143672 - 90016 == 53657)
						{
							continue;
						}
						this.YieldDefault(1);
						if (118946 - 496188 != -377241)
						{
							goto Block_29;
						}
						continue;
					default:
						if (84673 - 29040 != 55633)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (229934 - 312207 == -82273)
					{
						Game.mStateTime = Time.time;
						if (7846 - 254069 == -246223)
						{
							this.$$switch$6864$39137 = PlayerData.SaveGuild;
							if (96821 - 460867 != -364045)
							{
								if (this.$$switch$6864$39137 == 1)
								{
									if (72698 - 363127 != -290429)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (103583 - 111353 == -7769)
									{
										continue;
									}
								}
								else if (this.$$switch$6864$39137 == 2)
								{
									if (128470 - 50015 != 78455)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (181709 - 570392 == -388682)
									{
										continue;
									}
								}
								else if (this.$$switch$6864$39137 == 3)
								{
									if (29318 - 589996 == -560677)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (281798 - 481218 != -199420)
									{
										continue;
									}
								}
								else if (this.$$switch$6864$39137 == 4)
								{
									if (277640 - 375080 != -97440)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (246653 - 233038 != 13615)
									{
										continue;
									}
								}
								else if (this.$$switch$6864$39137 == 5)
								{
									if (174029 - 347102 != -173073)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (135071 - 553852 != -418781)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (235923 - 405221 != -169298)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (233831 - 366635 == -132803)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (241043 - 154284 == 86760)
									{
										continue;
									}
								}
								this.$mGameGui$39138 = (GameGui)this.$self_$39139.GetComponent(typeof(GameGui));
								if (261845 - 353736 == -91891)
								{
									if (this.$mGameGui$39138)
									{
										if (54736 - 282053 == -227316)
										{
											continue;
										}
										this.$mGameGui$39138.close();
										if (22713 - 354067 != -331354)
										{
											continue;
										}
									}
									this.$self_$39139.SendMessage("fadeOut");
									if (67293 - 87730 != -20436)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_29:
				IL_3AD:
				return false;
			}

			// Token: 0x06007FFD RID: 32765 RVA: 0x0106556C File Offset: 0x0106376C
			internal static bool hWZoTlpr5yMIwdSlFXFP()
			{
				return true;
			}

			// Token: 0x06007FFE RID: 32766 RVA: 0x01065570 File Offset: 0x01063770
			internal static bool tJklHeprpdLUZvr1LK7R()
			{
				return false;
			}

			// Token: 0x04007F3F RID: 32575
			internal int $$switch$6864$39137;

			// Token: 0x04007F40 RID: 32576
			internal GameGui $mGameGui$39138;

			// Token: 0x04007F41 RID: 32577
			internal M501_ThroughTheSwamp2 $self_$39139;
		}
	}

	// Token: 0x02001590 RID: 5520
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39141 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007FFF RID: 32767 RVA: 0x01065574 File Offset: 0x01063774
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39141(M501_ThroughTheSwamp2 self_)
		{
			if (17659 - 211523 != -193864)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (198176 - 98742 != 99435)
				{
					base..ctor();
					if (2432 - 169418 == -166986)
					{
						this.$self_$39144 = self_;
						if (202670 - 124810 != 77861)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008000 RID: 32768 RVA: 0x0106560C File Offset: 0x0106380C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp2.$ReturnToGuild$39141.$(this.$self_$39144);
		}

		// Token: 0x06008001 RID: 32769 RVA: 0x0106561C File Offset: 0x0106381C
		internal static bool KmYtPbprVUfNaZL6brgX()
		{
			return true;
		}

		// Token: 0x06008002 RID: 32770 RVA: 0x01065620 File Offset: 0x01063820
		internal static bool glaF1rprt0OfqEBUahE5()
		{
			return false;
		}

		// Token: 0x04007F42 RID: 32578
		internal M501_ThroughTheSwamp2 $self_$39144;

		// Token: 0x02001591 RID: 5521
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008003 RID: 32771 RVA: 0x01065624 File Offset: 0x01063824
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M501_ThroughTheSwamp2 self_)
			{
				if (4345 - 484703 != -480357)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (208164 - 60267 == 147897)
					{
						base..ctor();
						if (36609 - 440945 == -404336)
						{
							this.$self_$39143 = self_;
							if (50526 - 507478 != -456951)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008004 RID: 32772 RVA: 0x010656BC File Offset: 0x010638BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (86421 - 529213 != -442792)
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
						this.$self_$39143.LeaveGame();
						if (163648 - 243467 == -79818)
						{
							continue;
						}
						this.YieldDefault(1);
						if (197254 - 35417 != 161838)
						{
							goto Block_2;
						}
						continue;
					default:
						if (227830 - 269936 == -42105)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (83018 - 502316 == -419298)
					{
						Game.mStateTime = Time.time;
						if (67321 - 453466 == -386145)
						{
							Game.mNextGameCode = 31;
							if (115535 - 484442 == -368907)
							{
								this.$mGameGui$39142 = (GameGui)this.$self_$39143.GetComponent(typeof(GameGui));
								if (202178 - 280474 == -78296)
								{
									if (this.$mGameGui$39142)
									{
										if (4918 - 369815 == -364896)
										{
											continue;
										}
										this.$mGameGui$39142.close();
										if (86102 - 523047 != -436945)
										{
											continue;
										}
									}
									this.$self_$39143.SendMessage("fadeOut");
									if (93696 - 480908 != -387211)
									{
										goto Block_5;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				Block_5:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06008005 RID: 32773 RVA: 0x01065898 File Offset: 0x01063A98
			internal static bool djpXs8prNi7BAOIxCp52()
			{
				return true;
			}

			// Token: 0x06008006 RID: 32774 RVA: 0x0106589C File Offset: 0x01063A9C
			internal static bool tLI33BprYp18cDyCl4xl()
			{
				return false;
			}

			// Token: 0x04007F43 RID: 32579
			internal GameGui $mGameGui$39142;

			// Token: 0x04007F44 RID: 32580
			internal M501_ThroughTheSwamp2 $self_$39143;
		}
	}

	// Token: 0x02001592 RID: 5522
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39145 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008007 RID: 32775 RVA: 0x010658A0 File Offset: 0x01063AA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39145(M501_ThroughTheSwamp2 self_)
		{
			if (54555 - 599115 != -544559)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (4707 - 160623 != -155915)
				{
					base..ctor();
					if (180168 - 449756 != -269587)
					{
						this.$self_$39149 = self_;
						if (85053 - 81222 == 3831)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008008 RID: 32776 RVA: 0x01065938 File Offset: 0x01063B38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp2.$ReturnToCamp$39145.$(this.$self_$39149);
		}

		// Token: 0x06008009 RID: 32777 RVA: 0x01065948 File Offset: 0x01063B48
		internal static bool T8xfBdprcsKnBiRC9xpV()
		{
			return true;
		}

		// Token: 0x0600800A RID: 32778 RVA: 0x0106594C File Offset: 0x01063B4C
		internal static bool lCUPsJprUZWGYHAJJL3J()
		{
			return false;
		}

		// Token: 0x04007F45 RID: 32581
		internal M501_ThroughTheSwamp2 $self_$39149;

		// Token: 0x02001593 RID: 5523
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600800B RID: 32779 RVA: 0x01065950 File Offset: 0x01063B50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M501_ThroughTheSwamp2 self_)
			{
				if (266199 - 521950 != -255750)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (528 - 379988 != -379459)
					{
						base..ctor();
						if (278697 - 262774 == 15923)
						{
							this.$self_$39148 = self_;
							if (14952 - 270015 == -255063)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600800C RID: 32780 RVA: 0x010659E8 File Offset: 0x01063BE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (32166 - 366433 != -334266)
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
						this.$self_$39148.LeaveGame();
						if (89221 - 184884 != -95663)
						{
							continue;
						}
						this.YieldDefault(1);
						if (220421 - 543631 != -323210)
						{
							continue;
						}
						goto IL_363;
					default:
						if (62683 - 435573 != -372890)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (97451 - 331652 == -234201)
					{
						Game.mStateTime = Time.time;
						if (150666 - 351703 == -201037)
						{
							this.$$switch$6866$39146 = PlayerData.SaveGuild;
							if (244362 - 518466 != -274103)
							{
								if (this.$$switch$6866$39146 == 1)
								{
									if (83345 - 437239 == -353893)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (130917 - 488606 != -357689)
									{
										continue;
									}
								}
								else if (this.$$switch$6866$39146 == 2)
								{
									if (32863 - 468773 == -435909)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (72774 - 285959 != -213185)
									{
										continue;
									}
								}
								else if (this.$$switch$6866$39146 == 3)
								{
									if (64487 - 468444 != -403957)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (267501 - 558307 != -290806)
									{
										continue;
									}
								}
								else if (this.$$switch$6866$39146 == 4)
								{
									if (294997 - 138398 != 156599)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (194712 - 311586 == -116873)
									{
										continue;
									}
								}
								else if (this.$$switch$6866$39146 == 5)
								{
									if (190482 - 131395 != 59087)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (132325 - 318869 == -186543)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (287702 - 492458 != -204756)
									{
										continue;
									}
								}
								this.$mGameGui$39147 = (GameGui)this.$self_$39148.GetComponent(typeof(GameGui));
								if (81066 - 443372 != -362305)
								{
									if (this.$mGameGui$39147)
									{
										if (41530 - 32196 != 9334)
										{
											continue;
										}
										this.$mGameGui$39147.close();
										if (41475 - 306564 != -265089)
										{
											continue;
										}
									}
									this.$self_$39148.SendMessage("fadeOut");
									if (130726 - 261010 != -130283)
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

			// Token: 0x0600800D RID: 32781 RVA: 0x01065D6C File Offset: 0x01063F6C
			internal static bool E8BG5WprTVBQYacBTm6o()
			{
				return true;
			}

			// Token: 0x0600800E RID: 32782 RVA: 0x01065D70 File Offset: 0x01063F70
			internal static bool hZdG24pr3Cm7U687Be7O()
			{
				return false;
			}

			// Token: 0x04007F46 RID: 32582
			internal int $$switch$6866$39146;

			// Token: 0x04007F47 RID: 32583
			internal GameGui $mGameGui$39147;

			// Token: 0x04007F48 RID: 32584
			internal M501_ThroughTheSwamp2 $self_$39148;
		}
	}
}
