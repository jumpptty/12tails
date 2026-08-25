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

// Token: 0x02001594 RID: 5524
[Serializable]
public class M501_ThroughTheSwamp3 : MonoBehaviour
{
	// Token: 0x0600800F RID: 32783 RVA: 0x01065D74 File Offset: 0x01063F74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M501_ThroughTheSwamp3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008010 RID: 32784 RVA: 0x01065D84 File Offset: 0x01063F84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (5707 - 355862 != -350154)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (296482 - 34660 == 261822)
			{
				Game.mGameType = 5;
				if (229468 - 458252 != -228783)
				{
					if (Chat.Initialized)
					{
						if (124847 - 95845 == 29002)
						{
							Chat.ChatDisplay.Clear();
							if (40916 - 6514 == 34402)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (147867 - 33919 != 113949)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008011 RID: 32785 RVA: 0x01065E68 File Offset: 0x01064068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (76120 - 459464 != -383343)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (30561 - 591623 == -561062)
				{
					if (Game.mNextGameCode != 501)
					{
						break;
					}
					if (180330 - 75209 != 105122)
					{
						if (Game.mGameStage != 3)
						{
							break;
						}
						if (164902 - 63218 == 101684)
						{
							Game.nextGame();
							if (273730 - 522489 == -248759)
							{
								this.dA1cABryIiQ = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (81266 - 16005 != 65262)
								{
									this.TeYcASZoVD9 = PhotonClient.Connection;
									if (231336 - 164170 == 67166)
									{
										PhotonClient.ActorNrList.Clear();
										if (209068 - 126074 == 82994)
										{
											this.InitGame();
											if (296343 - 269863 != 26481)
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
				if (33837 - 543855 != -510017)
				{
					Game.mGameType = 99;
					if (207650 - 196201 == 11449)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008012 RID: 32786 RVA: 0x01066020 File Offset: 0x01064220
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (211591 - 487710 != -276119)
		{
		}
		for (;;)
		{
			if (this.TeYcASZoVD9 == null)
			{
				if (141630 - 438654 == -297024)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (259639 - 288121 == -28482)
				{
					if (mGameState == eGameState.Init)
					{
						if (287102 - 191438 == 95664)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (247313 - 499709 != -252395)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (244324 - 189905 == 54419)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (55056 - 46799 != 8258)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (28507 - 559909 != -531401)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (77732 - 465373 != -387640)
						{
							if (Time.time > this.QE9cA0dlcnH)
							{
								if (77812 - 391281 == -313468)
								{
									continue;
								}
								Game.mGameMana++;
								if (143439 - 24906 == 118534)
								{
									continue;
								}
								this.QE9cA0dlcnH = Time.time + (float)12;
								if (153443 - 487111 == -333667)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (39853 - 83012 != -43159)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (234731 - 586463 == -351731)
									{
										continue;
									}
									this.audio.Play();
									if (268151 - 159287 != 108864)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (24852 - 234687 != -209834)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (298058 - 156921 == 141137)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (199097 - 545742 != -346644)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (192269 - 89488 != 102782)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (136092 - 222679 != -86586)
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
						if (123422 - 44573 != 78850)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008013 RID: 32787 RVA: 0x0106639C File Offset: 0x0106459C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M501_ThroughTheSwamp3.$onGameEvent$39150(data, this).GetEnumerator();
	}

	// Token: 0x06008014 RID: 32788 RVA: 0x010663AC File Offset: 0x010645AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M501_ThroughTheSwamp3.$onGameComplete$39163(data, this).GetEnumerator();
	}

	// Token: 0x06008015 RID: 32789 RVA: 0x010663BC File Offset: 0x010645BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExit()
	{
		if (245178 - 241983 != 3195)
		{
		}
		while (this.eUocA8obyDN < 1)
		{
			if (160171 - 539796 == -379625)
			{
				Debug.Log("Swamp Exit");
				if (85125 - 413967 != -328841)
				{
					this.eUocA8obyDN = 1;
					if (123059 - 145945 == -22886)
					{
						Game.sendMissionEvent(5011, 3);
						if (25854 - 252118 == -226264)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008016 RID: 32790 RVA: 0x01066484 File Offset: 0x01064684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (167051 - 491288 != -324236)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (183407 - 289896 != -106488)
			{
				Hashtable customOpParameters = new Hashtable();
				if (179248 - 51307 != 127942)
				{
					this.TeYcASZoVD9.OpCustom(52, customOpParameters, true);
					if (185706 - 402332 == -216626)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008017 RID: 32791 RVA: 0x0106652C File Offset: 0x0106472C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (124191 - 387639 != -263447)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (100928 - 557876 == -456948)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (126325 - 142174 != -15848)
				{
					Game.mGameState = eGameState.Setup;
					if (122662 - 231612 == -108950)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008018 RID: 32792 RVA: 0x010665D0 File Offset: 0x010647D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (134746 - 323517 != -188770)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (216125 - 47094 == 169031)
			{
				if (num == PlayerData.UID)
				{
					if (76774 - 346158 == -269384)
					{
						this.SetupActors();
						if (276915 - 417148 != -140232)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (264419 - 234504 == 29915)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008019 RID: 32793 RVA: 0x010666A0 File Offset: 0x010648A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (217543 - 21525 != 196018)
		{
		}
		for (;;)
		{
			IL_1D8:
			Debug.Log("Creating Actors");
			if (250770 - 272629 == -21859)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (44325 - 69169 != -24843)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (283430 - 182428 == 101002)
						{
							int i = 0;
							if (258560 - 484594 != -226033)
							{
								CharacterControl[] array2 = array;
								if (205 - 464487 != -464281)
								{
									int length = array2.Length;
									if (89483 - 99178 != -9694)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (66862 - 348603 != -281741)
											{
												goto IL_1D8;
											}
											if (type == "FlowerBug_b")
											{
												goto IL_1FC;
											}
											if (276068 - 375691 == -99622)
											{
												goto IL_1D8;
											}
											if (type == "LionBug_b")
											{
												if (82493 - 32748 != 49745)
												{
													goto IL_1D8;
												}
												goto IL_1FC;
											}
											IL_145:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (22050 - 144323 == -122272)
											{
												goto IL_1D8;
											}
											this.dmZcAFAnNBc++;
											if (174579 - 32887 == 141693)
											{
												goto IL_1D8;
											}
											i++;
											if (47844 - 278273 != -230429)
											{
												goto IL_1D8;
											}
											continue;
											IL_1FC:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (188021 - 453373 != -265352)
											{
												goto IL_1D8;
											}
											goto IL_145;
										}
										if (183059 - 99201 != 83859)
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
						if (179669 - 401686 == -222017)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600801A RID: 32794 RVA: 0x01066940 File Offset: 0x01064B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (134603 - 411248 != -276644)
		{
		}
		for (;;)
		{
			IL_84:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (21131 - 309749 != -288617)
			{
				int i = 0;
				if (12539 - 213850 == -201311)
				{
					CharacterControl[] array2 = array;
					if (287585 - 243386 == 44199)
					{
						int length = array2.Length;
						if (95154 - 365436 == -270282)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (269983 - 75058 == 194926)
								{
									goto IL_84;
								}
								i++;
								if (210245 - 157206 != 53039)
								{
									goto IL_84;
								}
							}
							if (170341 - 236866 != -66524)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600801B RID: 32795 RVA: 0x01066A70 File Offset: 0x01064C70
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (208124 - 343995 != -135870)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (5372 - 299390 == -294018)
			{
				hashtable.Add(43, PlayerData.UID);
				if (91433 - 540573 == -449140)
				{
					hashtable.Add(73, nType);
					if (29675 - 281582 != -251906)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (181475 - 54756 == 126719)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (214399 - 478935 != -264535)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (68246 - 109044 != -40797)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (281349 - 111947 != 169403)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (32180 - 165816 != -133635)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (221790 - 22378 != 199413)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (243285 - 238781 == 4504)
												{
													this.TeYcASZoVD9.OpCustom(63, hashtable, true);
													if (208622 - 409980 != -201357)
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

	// Token: 0x0600801C RID: 32796 RVA: 0x01066D28 File Offset: 0x01064F28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (105862 - 200252 != -94390)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createActor(data);
			if (163093 - 297832 != -134738)
			{
				if (Game.mGameState != eGameState.Setup)
				{
					break;
				}
				if (36055 - 577681 == -541626)
				{
					if (this.dmZcAFAnNBc <= 0)
					{
						break;
					}
					if (11608 - 124696 != -113087)
					{
						this.dmZcAFAnNBc--;
						if (205540 - 357127 != -151586)
						{
							if (this.dmZcAFAnNBc != 0)
							{
								break;
							}
							if (270893 - 225062 != 45832)
							{
								Game.setGameState(eGameState.Ready);
								if (62762 - 371698 != -308935)
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

	// Token: 0x0600801D RID: 32797 RVA: 0x01066E3C File Offset: 0x0106503C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600801E RID: 32798 RVA: 0x01066E50 File Offset: 0x01065050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (41144 - 413211 != -372066)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (260519 - 68550 != 191970)
			{
				if (!characterControl)
				{
					break;
				}
				if (244832 - 272164 == -27332)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (62858 - 301720 == -238862)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (84695 - 228376 != -143680)
						{
							string type = characterControl.Type;
							if (226953 - 432472 != -205518)
							{
								if (type == "FudaBug_b")
								{
									if (213463 - 82860 == 130604)
									{
										continue;
									}
								}
								else if (type == "FudaBug_r")
								{
									if (205283 - 87349 != 117934)
									{
										continue;
									}
								}
								else if (type == "FlowerBug_b")
								{
									if (250378 - 427434 != -177056)
									{
										continue;
									}
									Game.sendMissionEvent(5013, 0);
									if (130886 - 586053 != -455166)
									{
										break;
									}
									continue;
								}
								else if (type == "LionBug_b")
								{
									if (146175 - 356229 != -210054)
									{
										continue;
									}
									Game.sendMissionEvent(5014, 0);
									if (112769 - 584781 != -472011)
									{
										break;
									}
									continue;
								}
								else if (type == "WormBug_p")
								{
									if (33262 - 402692 != -369430)
									{
										continue;
									}
									Game.sendMissionEvent(5015, 0);
									if (242115 - 450608 != -208492)
									{
										break;
									}
									continue;
								}
								else
								{
									if (!(type == "LeoBug_p"))
									{
										break;
									}
									if (87064 - 193321 != -106257)
									{
										continue;
									}
									Game.sendMissionEvent(5017, 0);
									if (78542 - 198491 != -119949)
									{
										continue;
									}
									break;
								}
								Game.sendMissionEvent(5012, 0);
								if (146794 - 422892 == -276098)
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

	// Token: 0x0600801F RID: 32799 RVA: 0x0106711C File Offset: 0x0106531C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (4425 - 244731 != -240305)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (125187 - 216517 == -91330)
			{
				Game.mGameState = eGameState.Ready;
				if (109742 - 402336 != -292593)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (240898 - 444555 == -203657)
					{
						GameObject gameObject = null;
						if (75404 - 12770 != 62635)
						{
							GameObject gameObject2 = null;
							if (150936 - 7299 == 143637)
							{
								if (playerSlot > 1)
								{
									if (186385 - 289058 != -102673)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (222895 - 154919 != 67976)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (74657 - 79691 != -5034)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (130624 - 585266 != -454642)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (148001 - 402823 != -254822)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (294352 - 521865 != -227513)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (70059 - 417198 != -347139)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (161864 - 573720 == -411855)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (242871 - 438789 == -195917)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (88619 - 311536 == -222916)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (74255 - 334982 == -260727)
								{
									this.transform.position = gameObject2.transform.position;
									if (175026 - 151222 != 23805)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (170247 - 515644 == -345397)
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

	// Token: 0x06008020 RID: 32800 RVA: 0x01067418 File Offset: 0x01065618
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M501_ThroughTheSwamp3.$StartGame$39172(this).GetEnumerator();
	}

	// Token: 0x06008021 RID: 32801 RVA: 0x01067428 File Offset: 0x01065628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008022 RID: 32802 RVA: 0x0106742C File Offset: 0x0106562C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (7374 - 56075 != -48701)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (133264 - 77194 == 56070)
			{
				hashtable.Add(71, CID);
				if (9659 - 431437 != -421777)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (256492 - 75087 == 181405)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (224660 - 360257 != -135596)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (179732 - 320074 == -140342)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (86016 - 98294 == -12278)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (277645 - 338234 != -60588)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (135944 - 590849 != -454904)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (73981 - 168596 == -94615)
											{
												this.TeYcASZoVD9.OpCustom(61, hashtable, true);
												if (218924 - 319654 != -100729)
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

	// Token: 0x06008023 RID: 32803 RVA: 0x010676B8 File Offset: 0x010658B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (75720 - 450960 != -375240)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (122006 - 458350 != -336343)
			{
				if (!gameObject)
				{
					break;
				}
				if (265591 - 253763 != 11829)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (71287 - 464970 != -393682)
					{
						playerCameraControl.target = gameObject;
						if (185203 - 23576 == 161627)
						{
							if (Game.useAdvanceMode)
							{
								if (172993 - 220515 != -47522)
								{
									continue;
								}
								Game.loadPlayer();
								if (160579 - 553765 == -393185)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (192815 - 50878 != 141938)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008024 RID: 32804 RVA: 0x010677F4 File Offset: 0x010659F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (20707 - 16894 != 3814)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (31642 - 203460 != -171817)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (215605 - 408867 == -193262)
				{
					gameGui.ResetTeamBar();
					if (218552 - 493924 == -275372)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008025 RID: 32805 RVA: 0x010678A0 File Offset: 0x01065AA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M501_ThroughTheSwamp3.$onDeadPlayer$39176(this).GetEnumerator();
	}

	// Token: 0x06008026 RID: 32806 RVA: 0x010678B0 File Offset: 0x01065AB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (170514 - 471546 != -301031)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (118665 - 595332 != -476666)
			{
				this.dA1cABryIiQ.target = Game.mPlayer;
				if (34538 - 261402 == -226864)
				{
					this.dA1cABryIiQ.enabled = true;
					if (57810 - 535270 == -477460)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (21613 - 312213 != -290600)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (33020 - 306649 == -273628)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (112960 - 55577 == 57383)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (147871 - 136943 != 10929)
							{
								if (!gameGui)
								{
									break;
								}
								if (115626 - 235304 == -119678)
								{
									gameGui.enabled = true;
									if (96040 - 234764 != -138723)
									{
										gameGui.closeDeadMenu();
										if (260789 - 106391 != 154399)
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

	// Token: 0x06008027 RID: 32807 RVA: 0x01067A5C File Offset: 0x01065C5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (127524 - 396060 != -268535)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (172653 - 258259 != -85605)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (209973 - 312471 != -102497)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (208681 - 248480 != -39798)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008028 RID: 32808 RVA: 0x01067B20 File Offset: 0x01065D20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008029 RID: 32809 RVA: 0x01067B4C File Offset: 0x01065D4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M501_ThroughTheSwamp3.$ReturnToTown$39182(this).GetEnumerator();
	}

	// Token: 0x0600802A RID: 32810 RVA: 0x01067B5C File Offset: 0x01065D5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M501_ThroughTheSwamp3.$ReturnToGuild$39187(this).GetEnumerator();
	}

	// Token: 0x0600802B RID: 32811 RVA: 0x01067B6C File Offset: 0x01065D6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M501_ThroughTheSwamp3.$ReturnToCamp$39191(this).GetEnumerator();
	}

	// Token: 0x0600802C RID: 32812 RVA: 0x01067B7C File Offset: 0x01065D7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (62145 - 282662 != -220517)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (203257 - 390279 != -187021)
			{
				Hashtable hashtable = new Hashtable();
				if (74872 - 6942 != 67931)
				{
					hashtable.Add(43, PlayerData.UID);
					if (175341 - 325898 == -150557)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (64472 - 216832 != -152359)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600802D RID: 32813 RVA: 0x01067C54 File Offset: 0x01065E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600802E RID: 32814 RVA: 0x01067C68 File Offset: 0x01065E68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (225996 - 67959 != 158038)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (180504 - 351635 != -171130)
			{
				Hashtable hashtable = new Hashtable();
				if (229197 - 243726 != -14528)
				{
					if (Game.mNextGameCode == 30)
					{
						if (188905 - 475473 != -286568)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (134714 - 176800 == -42085)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (223519 - 251489 == -27969)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (225692 - 364418 == -138725)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (76130 - 138132 != -62002)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (66454 - 452728 == -386273)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (137382 - 539722 != -402340)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (147366 - 500159 == -352792)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (209919 - 474718 == -264798)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (266754 - 218962 == 47793)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (246512 - 140487 != 106025)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (121325 - 246884 == -125558)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (227680 - 535604 != -307924)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (43950 - 407751 == -363800)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (95619 - 292146 == -196526)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (232301 - 200624 == 31678)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (260332 - 452482 == -192149)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (31138 - 567087 == -535948)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (95957 - 508088 == -412130)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (282953 - 415843 != -132890)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (284810 - 383132 == -98321)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (166926 - 115688 == 51239)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (271685 - 538641 == -266955)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (250873 - 313714 == -62840)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (264813 - 354682 != -89869)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (281466 - 515031 != -233565)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (30626 - 338167 != -307541)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (73573 - 114823 != -41250)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (191321 - 521675 == -330354)
					{
						this.TeYcASZoVD9.OpCustom(42, hashtable, true);
						if (220111 - 29500 != 190612)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600802F RID: 32815 RVA: 0x0106821C File Offset: 0x0106641C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008030 RID: 32816 RVA: 0x0106822C File Offset: 0x0106642C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008031 RID: 32817 RVA: 0x01068230 File Offset: 0x01066430
	internal static bool yXE66SprXHxh4lgQDdPA()
	{
		return true;
	}

	// Token: 0x06008032 RID: 32818 RVA: 0x01068234 File Offset: 0x01066434
	internal static bool cgR2GcprQ3Q4JBTJho2Q()
	{
		return false;
	}

	// Token: 0x04007F49 RID: 32585
	private LitePeer TeYcASZoVD9;

	// Token: 0x04007F4A RID: 32586
	private PlayerCameraControl dA1cABryIiQ;

	// Token: 0x04007F4B RID: 32587
	private float QE9cA0dlcnH;

	// Token: 0x04007F4C RID: 32588
	private int eUocA8obyDN;

	// Token: 0x04007F4D RID: 32589
	private int CATcAitq8aI;

	// Token: 0x04007F4E RID: 32590
	private int ficcADMD5GR;

	// Token: 0x04007F4F RID: 32591
	private int sYkcAmVWB2n;

	// Token: 0x04007F50 RID: 32592
	private int dejcAjnObKb;

	// Token: 0x04007F51 RID: 32593
	private int U7qcAoXfwWq;

	// Token: 0x04007F52 RID: 32594
	private int fg7cAk2ko7g;

	// Token: 0x04007F53 RID: 32595
	private int dmZcAFAnNBc;

	// Token: 0x02001595 RID: 5525
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$39150 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008033 RID: 32819 RVA: 0x01068238 File Offset: 0x01066438
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$39150(Hashtable data, M501_ThroughTheSwamp3 self_)
		{
			if (161369 - 548270 != -386900)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (100885 - 153926 != -53040)
				{
					base..ctor();
					if (221130 - 220819 == 311)
					{
						this.$data$39161 = data;
						if (170675 - 439024 != -268348)
						{
							this.$self_$39162 = self_;
							if (148353 - 474104 != -325750)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008034 RID: 32820 RVA: 0x010682F4 File Offset: 0x010664F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp3.$onGameEvent$39150.$(this.$data$39161, this.$self_$39162);
		}

		// Token: 0x06008035 RID: 32821 RVA: 0x01068308 File Offset: 0x01066508
		internal static bool oPAElMprkQCkTNbFBi2K()
		{
			return true;
		}

		// Token: 0x06008036 RID: 32822 RVA: 0x0106830C File Offset: 0x0106650C
		internal static bool zNaneHprGUG1xb4Mtdlv()
		{
			return false;
		}

		// Token: 0x04007F54 RID: 32596
		internal Hashtable $data$39161;

		// Token: 0x04007F55 RID: 32597
		internal M501_ThroughTheSwamp3 $self_$39162;

		// Token: 0x02001596 RID: 5526
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008037 RID: 32823 RVA: 0x01068310 File Offset: 0x01066510
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M501_ThroughTheSwamp3 self_)
			{
				if (20213 - 218431 != -198218)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (159939 - 237306 == -77367)
					{
						base..ctor();
						if (272094 - 438522 == -166428)
						{
							this.$data$39159 = data;
							if (174044 - 6766 == 167278)
							{
								this.$self_$39160 = self_;
								if (13735 - 436410 != -422674)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008038 RID: 32824 RVA: 0x010683CC File Offset: 0x010665CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (192901 - 151146 != 41756)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_62C;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (290563 - 40528 != 250035)
							{
								continue;
							}
							goto IL_537;
						}
						else
						{
							this.$mLionSpawnPoint$39155 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 6));
							if (140963 - 64982 != 75981)
							{
								continue;
							}
							if (this.$mLionSpawnPoint$39155)
							{
								if (147932 - 171974 == -24041)
								{
									continue;
								}
								this.$mLionSpawnPos$39156 = global::Math.getRandomSpawnPos(this.$mLionSpawnPoint$39155.transform.position, 5);
								if (196342 - 139156 != 57186)
								{
									continue;
								}
								if (this.$mLionSpawnPos$39156 == Vector3.zero)
								{
									if (224447 - 160384 == 64064)
									{
										continue;
									}
									this.$mLionSpawnPos$39156 = this.$mLionSpawnPoint$39155.transform.position;
									if (229031 - 165900 != 63131)
									{
										continue;
									}
								}
								this.$self_$39160.createActor("LionBug_b", 6, this.$mLionSpawnPos$39156, this.$mLionSpawnPoint$39155.transform.forward);
								if (15680 - 169034 == -153353)
								{
									continue;
								}
							}
							goto IL_577;
						}
						break;
					default:
						if (179793 - 531140 == -351346)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (37549 - 514031 != -476481)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$39151 = RuntimeServices.UnboxInt32(this.$data$39159[141]);
						if (84508 - 142627 != -58119)
						{
							continue;
						}
						this.$returnValue$39152 = RuntimeServices.UnboxInt32(this.$data$39159[145]);
						if (1936 - 379021 == -377084)
						{
							continue;
						}
						this.$ownerID$39153 = RuntimeServices.UnboxInt32(this.$data$39159[43]);
						if (7027 - 142336 == -135308)
						{
							continue;
						}
						this.$$switch$6870$39154 = this.$returnCode$39151;
						if (44573 - 509223 == -464649)
						{
							continue;
						}
						if (this.$$switch$6870$39154 == 5012)
						{
							if (49878 - 160594 == -110715)
							{
								continue;
							}
							this.$self_$39160.CATcAitq8aI = this.$self_$39160.CATcAitq8aI + 1;
							if (152022 - 99965 != 52057)
							{
								continue;
							}
						}
						else if (this.$$switch$6870$39154 == 5013)
						{
							if (100017 - 61838 == 38180)
							{
								continue;
							}
							this.$self_$39160.ficcADMD5GR = this.$self_$39160.ficcADMD5GR + 1;
							if (92160 - 490965 == -398804)
							{
								continue;
							}
						}
						else if (this.$$switch$6870$39154 == 5014)
						{
							if (62274 - 215797 != -153523)
							{
								continue;
							}
							this.$self_$39160.sYkcAmVWB2n = this.$self_$39160.sYkcAmVWB2n + 1;
							if (35660 - 24373 == 11288)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$39153)
							{
								if (245993 - 448580 != -202587)
								{
									continue;
								}
								if (this.$self_$39160.sYkcAmVWB2n < 24)
								{
									if (195301 - 90154 != 105147)
									{
										continue;
									}
									goto IL_25E;
								}
								else if (this.$self_$39160.sYkcAmVWB2n == 24)
								{
									if (171119 - 350161 == -179041)
									{
										continue;
									}
									this.$mSpawnPoint3$39157 = GameObject.Find("SpawnPoint3");
									if (1169 - 449419 == -448249)
									{
										continue;
									}
									this.$mSpawnPoint5$39158 = GameObject.Find("SpawnPoint5");
									if (211302 - 171556 == 39747)
									{
										continue;
									}
									if (this.$mSpawnPoint3$39157)
									{
										if (33386 - 504430 != -471044)
										{
											continue;
										}
										this.$self_$39160.createActor("LeoBug_p", 6, this.$mSpawnPoint3$39157.transform.position, this.$mSpawnPoint3$39157.transform.forward);
										if (84859 - 446248 == -361388)
										{
											continue;
										}
									}
									if (this.$mSpawnPoint5$39158)
									{
										if (73164 - 135353 != -62189)
										{
											continue;
										}
										this.$self_$39160.createActor("LeoBug_p", 6, this.$mSpawnPoint5$39158.transform.position, this.$mSpawnPoint5$39158.transform.forward);
										if (115055 - 88926 != 26129)
										{
											continue;
										}
									}
								}
							}
						}
						else if (this.$$switch$6870$39154 == 5017)
						{
							if (226553 - 496253 == -269699)
							{
								continue;
							}
							this.$self_$39160.fg7cAk2ko7g = this.$self_$39160.fg7cAk2ko7g + 1;
							if (15352 - 202679 == -187326)
							{
								continue;
							}
						}
					}
					IL_356:
					this.YieldDefault(1);
					if (83463 - 313579 != -230115)
					{
						break;
					}
					continue;
					IL_577:
					goto IL_356;
				}
				goto IL_62C;
				IL_25E:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_537:
				IL_62C:
				return false;
			}

			// Token: 0x06008039 RID: 32825 RVA: 0x01068A18 File Offset: 0x01066C18
			internal static bool ELlP0DprHWhdCchQuIyl()
			{
				return true;
			}

			// Token: 0x0600803A RID: 32826 RVA: 0x01068A1C File Offset: 0x01066C1C
			internal static bool ftvjtuprW1f0jeJLl5da()
			{
				return false;
			}

			// Token: 0x04007F56 RID: 32598
			internal int $returnCode$39151;

			// Token: 0x04007F57 RID: 32599
			internal int $returnValue$39152;

			// Token: 0x04007F58 RID: 32600
			internal int $ownerID$39153;

			// Token: 0x04007F59 RID: 32601
			internal int $$switch$6870$39154;

			// Token: 0x04007F5A RID: 32602
			internal GameObject $mLionSpawnPoint$39155;

			// Token: 0x04007F5B RID: 32603
			internal Vector3 $mLionSpawnPos$39156;

			// Token: 0x04007F5C RID: 32604
			internal GameObject $mSpawnPoint3$39157;

			// Token: 0x04007F5D RID: 32605
			internal GameObject $mSpawnPoint5$39158;

			// Token: 0x04007F5E RID: 32606
			internal Hashtable $data$39159;

			// Token: 0x04007F5F RID: 32607
			internal M501_ThroughTheSwamp3 $self_$39160;
		}
	}

	// Token: 0x02001597 RID: 5527
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39163 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600803B RID: 32827 RVA: 0x01068A20 File Offset: 0x01066C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39163(Hashtable data, M501_ThroughTheSwamp3 self_)
		{
			if (70665 - 580854 != -510189)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (209884 - 542707 == -332823)
				{
					base..ctor();
					if (214969 - 476863 == -261894)
					{
						this.$data$39170 = data;
						if (210106 - 307648 != -97541)
						{
							this.$self_$39171 = self_;
							if (202373 - 178457 == 23916)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600803C RID: 32828 RVA: 0x01068ADC File Offset: 0x01066CDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp3.$onGameComplete$39163.$(this.$data$39170, this.$self_$39171);
		}

		// Token: 0x0600803D RID: 32829 RVA: 0x01068AF0 File Offset: 0x01066CF0
		internal static bool lMwuAvprAikhwWJtGfwI()
		{
			return true;
		}

		// Token: 0x0600803E RID: 32830 RVA: 0x01068AF4 File Offset: 0x01066CF4
		internal static bool H8O7MFprlQPI3tjRr0mQ()
		{
			return false;
		}

		// Token: 0x04007F60 RID: 32608
		internal Hashtable $data$39170;

		// Token: 0x04007F61 RID: 32609
		internal M501_ThroughTheSwamp3 $self_$39171;

		// Token: 0x02001598 RID: 5528
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600803F RID: 32831 RVA: 0x01068AF8 File Offset: 0x01066CF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M501_ThroughTheSwamp3 self_)
			{
				if (138793 - 239919 != -101126)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (233775 - 484967 == -251192)
					{
						base..ctor();
						if (84667 - 245678 != -161010)
						{
							this.$data$39168 = data;
							if (126101 - 518113 == -392012)
							{
								this.$self_$39169 = self_;
								if (16554 - 446355 != -429800)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008040 RID: 32832 RVA: 0x01068BB4 File Offset: 0x01066DB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (149297 - 275889 != -126591)
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
						this.$mCompleteGui$39165 = (CompleteGui)this.$self_$39169.GetComponent(typeof(CompleteGui));
						if (90659 - 571923 != -481264)
						{
							continue;
						}
						this.$mCompleteGui$39165.Init();
						if (225574 - 251211 == -25636)
						{
							continue;
						}
						this.$mCompleteGui$39165.readData(this.$data$39168);
						if (160682 - 386329 != -225647)
						{
							continue;
						}
						if (this.$result$39164 == 1)
						{
							if (253472 - 444233 != -190761)
							{
								continue;
							}
							this.$mCompleteGui$39165.displayResult(eCompleteType.Success);
							if (215498 - 113818 != 101680)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39165.displayResult(eCompleteType.Failed);
							if (198645 - 142456 != 56189)
							{
								continue;
							}
						}
						this.$mGameGui$39166 = (GameGui)this.$self_$39169.GetComponent(typeof(GameGui));
						if (132534 - 479112 != -346578)
						{
							continue;
						}
						this.$mStoryGui$39167 = (StoryGui)this.$self_$39169.GetComponent(typeof(StoryGui));
						if (146205 - 472443 != -326238)
						{
							continue;
						}
						if (this.$mGameGui$39166)
						{
							if (140577 - 42819 == 97759)
							{
								continue;
							}
							this.$mGameGui$39166.close();
							if (192171 - 283556 == -91384)
							{
								continue;
							}
						}
						if (this.$mStoryGui$39167)
						{
							if (296410 - 445131 == -148720)
							{
								continue;
							}
							this.$mStoryGui$39167.close();
							if (120685 - 538149 == -417463)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (96562 - 497771 != -401208)
						{
							goto Block_15;
						}
						continue;
					default:
						if (260007 - 340115 != -80108)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$39168[31]);
					if (213989 - 351952 != -137962)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (142398 - 61837 == 80561)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (24067 - 278089 == -254022)
							{
								this.$result$39164 = RuntimeServices.UnboxInt32(this.$data$39168[31]);
								if (184005 - 463033 != -279027)
								{
									goto Block_23;
								}
							}
						}
					}
				}
				Block_15:
				goto IL_352;
				Block_23:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06008041 RID: 32833 RVA: 0x01068F28 File Offset: 0x01067128
			internal static bool z8nHAupryJ4p2k5MXBUn()
			{
				return true;
			}

			// Token: 0x06008042 RID: 32834 RVA: 0x01068F2C File Offset: 0x0106712C
			internal static bool S3shlQprStF3JbLB9YmI()
			{
				return false;
			}

			// Token: 0x04007F62 RID: 32610
			internal int $result$39164;

			// Token: 0x04007F63 RID: 32611
			internal CompleteGui $mCompleteGui$39165;

			// Token: 0x04007F64 RID: 32612
			internal GameGui $mGameGui$39166;

			// Token: 0x04007F65 RID: 32613
			internal StoryGui $mStoryGui$39167;

			// Token: 0x04007F66 RID: 32614
			internal Hashtable $data$39168;

			// Token: 0x04007F67 RID: 32615
			internal M501_ThroughTheSwamp3 $self_$39169;
		}
	}

	// Token: 0x02001599 RID: 5529
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$39172 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008043 RID: 32835 RVA: 0x01068F30 File Offset: 0x01067130
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$39172(M501_ThroughTheSwamp3 self_)
		{
			if (39213 - 362566 != -323352)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (95694 - 451657 == -355963)
				{
					base..ctor();
					if (270957 - 565786 == -294829)
					{
						this.$self_$39175 = self_;
						if (132680 - 102910 == 29770)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008044 RID: 32836 RVA: 0x01068FC8 File Offset: 0x010671C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp3.$StartGame$39172.$(this.$self_$39175);
		}

		// Token: 0x06008045 RID: 32837 RVA: 0x01068FD8 File Offset: 0x010671D8
		internal static bool uTDPv7progRE5XHgSmXY()
		{
			return true;
		}

		// Token: 0x06008046 RID: 32838 RVA: 0x01068FDC File Offset: 0x010671DC
		internal static bool Q6nfmUprEegQcmJKMV0J()
		{
			return false;
		}

		// Token: 0x04007F68 RID: 32616
		internal M501_ThroughTheSwamp3 $self_$39175;

		// Token: 0x0200159A RID: 5530
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008047 RID: 32839 RVA: 0x01068FE0 File Offset: 0x010671E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M501_ThroughTheSwamp3 self_)
			{
				if (218421 - 345239 != -126818)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (248507 - 284507 == -36000)
					{
						base..ctor();
						if (135637 - 521831 == -386194)
						{
							this.$self_$39174 = self_;
							if (62546 - 425270 == -362724)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008048 RID: 32840 RVA: 0x01069078 File Offset: 0x01067278
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (201335 - 526955 != -325620)
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
						if (271324 - 476138 != -204814)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (121785 - 441577 != -319792)
						{
							continue;
						}
						this.YieldDefault(1);
						if (180609 - 371490 != -190880)
						{
							goto Block_2;
						}
						continue;
					default:
						if (223502 - 241620 != -18118)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (291912 - 304683 != -12770)
					{
						Game.mGameState = eGameState.Start;
						if (288484 - 459856 != -171371)
						{
							Game.mStateTime = Time.time;
							if (215346 - 83059 == 132287)
							{
								this.$mGameGui$39173 = (GameGui)this.$self_$39174.GetComponent(typeof(GameGui));
								if (220483 - 45314 != 175170)
								{
									this.$mGameGui$39173.enabled = true;
									if (101693 - 450066 == -348373)
									{
										this.$self_$39174.SendMessage("fadeIn");
										if (135259 - 68929 != 66331)
										{
											goto Block_10;
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1B9;
				Block_10:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x06008049 RID: 32841 RVA: 0x01069250 File Offset: 0x01067450
			internal static bool XU0jN5pr2eTJx5vuZbQG()
			{
				return true;
			}

			// Token: 0x0600804A RID: 32842 RVA: 0x01069254 File Offset: 0x01067454
			internal static bool at1PU9pr8ApRpdFpelwh()
			{
				return false;
			}

			// Token: 0x04007F69 RID: 32617
			internal GameGui $mGameGui$39173;

			// Token: 0x04007F6A RID: 32618
			internal M501_ThroughTheSwamp3 $self_$39174;
		}
	}

	// Token: 0x0200159B RID: 5531
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39176 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600804B RID: 32843 RVA: 0x01069258 File Offset: 0x01067458
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39176(M501_ThroughTheSwamp3 self_)
		{
			if (83931 - 347677 != -263745)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (293738 - 160530 != 133209)
				{
					base..ctor();
					if (87805 - 563900 != -476094)
					{
						this.$self_$39181 = self_;
						if (14959 - 104935 != -89975)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600804C RID: 32844 RVA: 0x010692F0 File Offset: 0x010674F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp3.$onDeadPlayer$39176.$(this.$self_$39181);
		}

		// Token: 0x0600804D RID: 32845 RVA: 0x01069300 File Offset: 0x01067500
		internal static bool QQ4pG8prZXaUooJ31jWF()
		{
			return true;
		}

		// Token: 0x0600804E RID: 32846 RVA: 0x01069304 File Offset: 0x01067504
		internal static bool VPuWhfprCthfmMpYai8M()
		{
			return false;
		}

		// Token: 0x04007F6B RID: 32619
		internal M501_ThroughTheSwamp3 $self_$39181;

		// Token: 0x0200159C RID: 5532
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600804F RID: 32847 RVA: 0x01069308 File Offset: 0x01067508
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M501_ThroughTheSwamp3 self_)
			{
				if (29405 - 291557 != -262152)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (148176 - 507061 != -358884)
					{
						base..ctor();
						if (178390 - 251004 == -72614)
						{
							this.$self_$39180 = self_;
							if (253935 - 341580 != -87644)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008050 RID: 32848 RVA: 0x010693A0 File Offset: 0x010675A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (238703 - 39445 != 199258)
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
							goto IL_202;
						}
						if (206792 - 163210 == 43583)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (43103 - 92241 != -49137)
							{
								goto IL_202;
							}
							continue;
						}
						IL_1E0:
						this.YieldDefault(1);
						if (279987 - 123680 != 156307)
						{
							continue;
						}
						goto IL_2F9;
						IL_202:
						Game.mGameState = eGameState.Hold;
						if (239403 - 397328 == -157924)
						{
							continue;
						}
						this.$mStoryGui$39177 = (StoryGui)this.$self_$39180.GetComponent(typeof(StoryGui));
						if (193436 - 140453 == 52984)
						{
							continue;
						}
						if (this.$mStoryGui$39177)
						{
							if (246629 - 562750 != -316121)
							{
								continue;
							}
							this.$mStoryGui$39177.close();
							if (233571 - 441765 != -208194)
							{
								continue;
							}
						}
						this.$mChangeGui$39178 = (ChangeGui)this.$self_$39180.GetComponent(typeof(ChangeGui));
						if (63194 - 278085 != -214891)
						{
							continue;
						}
						if (this.$mChangeGui$39178)
						{
							if (211918 - 544683 == -332764)
							{
								continue;
							}
							this.$mChangeGui$39178.close();
							if (197644 - 412128 != -214484)
							{
								continue;
							}
						}
						this.$mGameGui$39179 = (GameGui)this.$self_$39180.GetComponent(typeof(GameGui));
						if (173678 - 290827 == -117148)
						{
							continue;
						}
						if (!this.$mGameGui$39179)
						{
							goto IL_1E0;
						}
						if (220185 - 326635 == -106449)
						{
							continue;
						}
						if (!this.$mGameGui$39179.enabled)
						{
							if (271662 - 298819 == -27156)
							{
								continue;
							}
							this.$mGameGui$39179.enabled = true;
							if (201028 - 452153 == -251124)
							{
								continue;
							}
						}
						this.$mGameGui$39179.openDeadMenu();
						if (227065 - 115832 != 111234)
						{
							goto IL_1E0;
						}
						continue;
					default:
						if (197728 - 562280 == -364551)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (283156 - 328926 == -45769);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008051 RID: 32849 RVA: 0x010696B8 File Offset: 0x010678B8
			internal static bool UFt4UdprL4eKhjFbbXvX()
			{
				return true;
			}

			// Token: 0x06008052 RID: 32850 RVA: 0x010696BC File Offset: 0x010678BC
			internal static bool Xj5OaAprOy00RQCEbLil()
			{
				return false;
			}

			// Token: 0x04007F6C RID: 32620
			internal StoryGui $mStoryGui$39177;

			// Token: 0x04007F6D RID: 32621
			internal ChangeGui $mChangeGui$39178;

			// Token: 0x04007F6E RID: 32622
			internal GameGui $mGameGui$39179;

			// Token: 0x04007F6F RID: 32623
			internal M501_ThroughTheSwamp3 $self_$39180;
		}
	}

	// Token: 0x0200159D RID: 5533
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39182 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008053 RID: 32851 RVA: 0x010696C0 File Offset: 0x010678C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39182(M501_ThroughTheSwamp3 self_)
		{
			if (250248 - 12412 != 237836)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (88257 - 456601 != -368343)
				{
					base..ctor();
					if (61028 - 595593 == -534565)
					{
						this.$self_$39186 = self_;
						if (58974 - 357717 == -298743)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008054 RID: 32852 RVA: 0x01069758 File Offset: 0x01067958
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp3.$ReturnToTown$39182.$(this.$self_$39186);
		}

		// Token: 0x06008055 RID: 32853 RVA: 0x01069768 File Offset: 0x01067968
		internal static bool ttZECaprmJUCpt55oL7w()
		{
			return true;
		}

		// Token: 0x06008056 RID: 32854 RVA: 0x0106976C File Offset: 0x0106796C
		internal static bool SjfMwhprF5IFxDA21NZi()
		{
			return false;
		}

		// Token: 0x04007F70 RID: 32624
		internal M501_ThroughTheSwamp3 $self_$39186;

		// Token: 0x0200159E RID: 5534
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008057 RID: 32855 RVA: 0x01069770 File Offset: 0x01067970
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M501_ThroughTheSwamp3 self_)
			{
				if (132088 - 320660 != -188571)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14277 - 463605 == -449328)
					{
						base..ctor();
						if (59619 - 173124 == -113505)
						{
							this.$self_$39185 = self_;
							if (23013 - 78018 == -55005)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008058 RID: 32856 RVA: 0x01069808 File Offset: 0x01067A08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (97582 - 91454 != 6128)
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
						this.$self_$39185.LeaveGame();
						if (166356 - 80058 != 86298)
						{
							continue;
						}
						this.YieldDefault(1);
						if (12260 - 111530 != -99270)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (159158 - 598981 == -439822)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (59104 - 121330 == -62226)
					{
						Game.mStateTime = Time.time;
						if (152678 - 480032 != -327353)
						{
							this.$$switch$6877$39183 = PlayerData.SaveGuild;
							if (218122 - 265603 == -47481)
							{
								if (this.$$switch$6877$39183 == 1)
								{
									if (255914 - 256733 == -818)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (128169 - 445235 != -317066)
									{
										continue;
									}
								}
								else if (this.$$switch$6877$39183 == 2)
								{
									if (62078 - 375234 != -313156)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (247601 - 107977 != 139624)
									{
										continue;
									}
								}
								else if (this.$$switch$6877$39183 == 3)
								{
									if (29658 - 300341 == -270682)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (142329 - 60655 == 81675)
									{
										continue;
									}
								}
								else if (this.$$switch$6877$39183 == 4)
								{
									if (242608 - 48975 != 193633)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (267815 - 74826 == 192990)
									{
										continue;
									}
								}
								else if (this.$$switch$6877$39183 == 5)
								{
									if (252683 - 282566 == -29882)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (66274 - 44562 == 21713)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (30085 - 187381 == -157295)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (121709 - 71510 == 50200)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (138931 - 484199 != -345268)
									{
										continue;
									}
								}
								this.$mGameGui$39184 = (GameGui)this.$self_$39185.GetComponent(typeof(GameGui));
								if (284502 - 574045 == -289543)
								{
									if (this.$mGameGui$39184)
									{
										if (121730 - 375551 != -253821)
										{
											continue;
										}
										this.$mGameGui$39184.close();
										if (153269 - 542941 == -389671)
										{
											continue;
										}
									}
									this.$self_$39185.SendMessage("fadeOut");
									if (292433 - 95504 == 196929)
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

			// Token: 0x06008059 RID: 32857 RVA: 0x01069BD4 File Offset: 0x01067DD4
			internal static bool yKZq2cprM1CM1h70GCMu()
			{
				return true;
			}

			// Token: 0x0600805A RID: 32858 RVA: 0x01069BD8 File Offset: 0x01067DD8
			internal static bool xYUWLcprxNWGk5whmGeE()
			{
				return false;
			}

			// Token: 0x04007F71 RID: 32625
			internal int $$switch$6877$39183;

			// Token: 0x04007F72 RID: 32626
			internal GameGui $mGameGui$39184;

			// Token: 0x04007F73 RID: 32627
			internal M501_ThroughTheSwamp3 $self_$39185;
		}
	}

	// Token: 0x0200159F RID: 5535
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39187 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600805B RID: 32859 RVA: 0x01069BDC File Offset: 0x01067DDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39187(M501_ThroughTheSwamp3 self_)
		{
			if (212996 - 589596 != -376600)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (170321 - 95444 == 74877)
				{
					base..ctor();
					if (87855 - 227842 == -139987)
					{
						this.$self_$39190 = self_;
						if (294895 - 262834 == 32061)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600805C RID: 32860 RVA: 0x01069C74 File Offset: 0x01067E74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp3.$ReturnToGuild$39187.$(this.$self_$39190);
		}

		// Token: 0x0600805D RID: 32861 RVA: 0x01069C84 File Offset: 0x01067E84
		internal static bool AYmBP8prg2uNYJtAhati()
		{
			return true;
		}

		// Token: 0x0600805E RID: 32862 RVA: 0x01069C88 File Offset: 0x01067E88
		internal static bool xcSUCHprfhuf3WaNW9tF()
		{
			return false;
		}

		// Token: 0x04007F74 RID: 32628
		internal M501_ThroughTheSwamp3 $self_$39190;

		// Token: 0x020015A0 RID: 5536
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600805F RID: 32863 RVA: 0x01069C8C File Offset: 0x01067E8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M501_ThroughTheSwamp3 self_)
			{
				if (279311 - 361229 != -81918)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (74989 - 43357 == 31632)
					{
						base..ctor();
						if (79305 - 345988 != -266682)
						{
							this.$self_$39189 = self_;
							if (289118 - 490518 != -201399)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008060 RID: 32864 RVA: 0x01069D24 File Offset: 0x01067F24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (9980 - 171587 != -161606)
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
						this.$self_$39189.LeaveGame();
						if (239197 - 116821 == 122377)
						{
							continue;
						}
						this.YieldDefault(1);
						if (180330 - 432882 != -252551)
						{
							goto Block_2;
						}
						continue;
					default:
						if (197587 - 305391 != -107804)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (3234 - 276581 != -273346)
					{
						Game.mStateTime = Time.time;
						if (253745 - 484773 == -231028)
						{
							Game.mNextGameCode = 31;
							if (294450 - 74374 == 220076)
							{
								this.$mGameGui$39188 = (GameGui)this.$self_$39189.GetComponent(typeof(GameGui));
								if (95283 - 428678 != -333394)
								{
									if (this.$mGameGui$39188)
									{
										if (9191 - 79152 == -69960)
										{
											continue;
										}
										this.$mGameGui$39188.close();
										if (80677 - 591696 != -511019)
										{
											continue;
										}
									}
									this.$self_$39189.SendMessage("fadeOut");
									if (273937 - 257367 == 16570)
									{
										goto IL_15B;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				IL_15B:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06008061 RID: 32865 RVA: 0x01069F00 File Offset: 0x01068100
			internal static bool ajdSLfprnpGRJHVjZQQr()
			{
				return true;
			}

			// Token: 0x06008062 RID: 32866 RVA: 0x01069F04 File Offset: 0x01068104
			internal static bool Odi80Ypr6mgCQMCsk6V2()
			{
				return false;
			}

			// Token: 0x04007F75 RID: 32629
			internal GameGui $mGameGui$39188;

			// Token: 0x04007F76 RID: 32630
			internal M501_ThroughTheSwamp3 $self_$39189;
		}
	}

	// Token: 0x020015A1 RID: 5537
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39191 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008063 RID: 32867 RVA: 0x01069F08 File Offset: 0x01068108
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39191(M501_ThroughTheSwamp3 self_)
		{
			if (139784 - 319886 != -180101)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (220004 - 335442 != -115437)
				{
					base..ctor();
					if (123855 - 124592 == -737)
					{
						this.$self_$39195 = self_;
						if (19995 - 595047 != -575051)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008064 RID: 32868 RVA: 0x01069FA0 File Offset: 0x010681A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M501_ThroughTheSwamp3.$ReturnToCamp$39191.$(this.$self_$39195);
		}

		// Token: 0x06008065 RID: 32869 RVA: 0x01069FB0 File Offset: 0x010681B0
		internal static bool HA7yt1priOdWPT6oUKNl()
		{
			return true;
		}

		// Token: 0x06008066 RID: 32870 RVA: 0x01069FB4 File Offset: 0x010681B4
		internal static bool BR07xCprK5mc4qfkkB00()
		{
			return false;
		}

		// Token: 0x04007F77 RID: 32631
		internal M501_ThroughTheSwamp3 $self_$39195;

		// Token: 0x020015A2 RID: 5538
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008067 RID: 32871 RVA: 0x01069FB8 File Offset: 0x010681B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M501_ThroughTheSwamp3 self_)
			{
				if (18901 - 16576 != 2326)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (222717 - 393602 == -170885)
					{
						base..ctor();
						if (63049 - 529551 != -466501)
						{
							this.$self_$39194 = self_;
							if (224231 - 528214 != -303982)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008068 RID: 32872 RVA: 0x0106A050 File Offset: 0x01068250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (5632 - 145757 != -140124)
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
						this.$self_$39194.LeaveGame();
						if (126657 - 50470 == 76188)
						{
							continue;
						}
						this.YieldDefault(1);
						if (38049 - 550990 != -512941)
						{
							continue;
						}
						goto IL_363;
					default:
						if (225218 - 427169 == -201950)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (20963 - 404619 != -383655)
					{
						Game.mStateTime = Time.time;
						if (216741 - 420959 != -204217)
						{
							this.$$switch$6879$39192 = PlayerData.SaveGuild;
							if (196104 - 301649 != -105544)
							{
								if (this.$$switch$6879$39192 == 1)
								{
									if (298322 - 538085 != -239763)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (250707 - 391769 != -141062)
									{
										continue;
									}
								}
								else if (this.$$switch$6879$39192 == 2)
								{
									if (292330 - 194580 != 97750)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (176696 - 477482 != -300786)
									{
										continue;
									}
								}
								else if (this.$$switch$6879$39192 == 3)
								{
									if (26496 - 451521 != -425025)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (74006 - 469123 != -395117)
									{
										continue;
									}
								}
								else if (this.$$switch$6879$39192 == 4)
								{
									if (79074 - 163641 == -84566)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (152592 - 35421 != 117171)
									{
										continue;
									}
								}
								else if (this.$$switch$6879$39192 == 5)
								{
									if (39261 - 41336 != -2075)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (89858 - 248686 != -158828)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (124586 - 168762 == -44175)
									{
										continue;
									}
								}
								this.$mGameGui$39193 = (GameGui)this.$self_$39194.GetComponent(typeof(GameGui));
								if (92597 - 392744 == -300147)
								{
									if (this.$mGameGui$39193)
									{
										if (106353 - 130394 != -24041)
										{
											continue;
										}
										this.$mGameGui$39193.close();
										if (42323 - 273387 == -231063)
										{
											continue;
										}
									}
									this.$self_$39194.SendMessage("fadeOut");
									if (286750 - 146181 != 140570)
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

			// Token: 0x06008069 RID: 32873 RVA: 0x0106A3D4 File Offset: 0x010685D4
			internal static bool w4C2MMprdZ0LJ2oryAvG()
			{
				return true;
			}

			// Token: 0x0600806A RID: 32874 RVA: 0x0106A3D8 File Offset: 0x010685D8
			internal static bool Bsu6d4prJWrg1OJCVyNV()
			{
				return false;
			}

			// Token: 0x04007F78 RID: 32632
			internal int $$switch$6879$39192;

			// Token: 0x04007F79 RID: 32633
			internal GameGui $mGameGui$39193;

			// Token: 0x04007F7A RID: 32634
			internal M501_ThroughTheSwamp3 $self_$39194;
		}
	}
}
