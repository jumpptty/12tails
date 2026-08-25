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

// Token: 0x020013E7 RID: 5095
[Serializable]
public class M206_GrandTheftMupo2 : MonoBehaviour
{
	// Token: 0x060075A6 RID: 30118 RVA: 0x00FD00E0 File Offset: 0x00FCE2E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M206_GrandTheftMupo2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060075A7 RID: 30119 RVA: 0x00FD00F0 File Offset: 0x00FCE2F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (11206 - 42390 != -31183)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (237936 - 158616 == 79320)
			{
				Game.mGameType = 5;
				if (22465 - 323176 == -300711)
				{
					if (Chat.Initialized)
					{
						if (181825 - 498049 == -316224)
						{
							Chat.ChatDisplay.Clear();
							if (54435 - 579735 != -525299)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (59487 - 302875 != -243387)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060075A8 RID: 30120 RVA: 0x00FD01D4 File Offset: 0x00FCE3D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (100530 - 530686 != -430155)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (126220 - 280866 == -154646)
				{
					if (Game.mNextGameCode != 206)
					{
						break;
					}
					if (113920 - 378939 == -265019)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (248359 - 319 != 248041)
						{
							Game.nextGame();
							if (18076 - 403034 == -384958)
							{
								this.vmHcj7xXndh = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (262822 - 320744 == -57922)
								{
									this.nlFcjHNRSUp = PhotonClient.Connection;
									if (267071 - 129815 == 137256)
									{
										PhotonClient.ActorNrList.Clear();
										if (245247 - 18003 != 227245)
										{
											this.InitGame();
											if (145241 - 346228 != -200986)
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
				if (228165 - 144128 == 84037)
				{
					Game.mGameType = 99;
					if (64318 - 246818 != -182499)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060075A9 RID: 30121 RVA: 0x00FD038C File Offset: 0x00FCE58C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (99333 - 398403 != -299069)
		{
		}
		for (;;)
		{
			if (this.nlFcjHNRSUp == null)
			{
				if (269002 - 408805 == -139803)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (113504 - 540246 == -426742)
				{
					if (mGameState == eGameState.Init)
					{
						if (1800 - 437188 != -435387)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (63069 - 299447 != -236377)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (84487 - 563081 == -478594)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (200074 - 93470 == 106604)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (80599 - 129858 != -49258)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (15899 - 271184 != -255284)
						{
							if (Time.time > this.TIXcjZuaYYx)
							{
								if (159965 - 30909 == 129057)
								{
									continue;
								}
								Game.mGameMana++;
								if (27628 - 355675 != -328047)
								{
									continue;
								}
								this.TIXcjZuaYYx = Time.time + (float)12;
								if (2654 - 337279 == -334624)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (107382 - 166951 == -59568)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (140155 - 143370 != -3215)
									{
										continue;
									}
									this.audio.Play();
									if (232087 - 290142 != -58055)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (250298 - 269528 != -19229)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (67088 - 209114 != -142025)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (175835 - 195367 == -19532)
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
						if (247885 - 65328 == 182557)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060075AA RID: 30122 RVA: 0x00FD068C File Offset: 0x00FCE88C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M206_GrandTheftMupo2.$onGameEvent$37927(data, this).GetEnumerator();
	}

	// Token: 0x060075AB RID: 30123 RVA: 0x00FD069C File Offset: 0x00FCE89C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M206_GrandTheftMupo2.$onGameComplete$37938(data, this).GetEnumerator();
	}

	// Token: 0x060075AC RID: 30124 RVA: 0x00FD06AC File Offset: 0x00FCE8AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (24332 - 138796 != -114463)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (271792 - 545598 == -273806)
			{
				Hashtable customOpParameters = new Hashtable();
				if (100225 - 517652 != -417426)
				{
					this.nlFcjHNRSUp.OpCustom(52, customOpParameters, true);
					if (203058 - 478617 != -275558)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060075AD RID: 30125 RVA: 0x00FD0754 File Offset: 0x00FCE954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (28903 - 25814 != 3090)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (178591 - 490996 == -312405)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (19102 - 391374 == -372272)
				{
					Game.mGameState = eGameState.Setup;
					if (134848 - 10614 == 124234)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060075AE RID: 30126 RVA: 0x00FD07F8 File Offset: 0x00FCE9F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (18742 - 381429 != -362687)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (153041 - 295463 == -142422)
			{
				if (num == PlayerData.UID)
				{
					if (65377 - 280837 != -215459)
					{
						this.SetupActors();
						if (62782 - 181490 == -118708)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (170394 - 144580 == 25814)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060075AF RID: 30127 RVA: 0x00FD08C8 File Offset: 0x00FCEAC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (139016 - 518538 != -379522)
		{
		}
		for (;;)
		{
			IL_163:
			Debug.Log("Creating Actors");
			if (90698 - 145448 == -54750)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (164434 - 548966 != -384531)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (228943 - 467888 == -238945)
						{
							int i = 0;
							if (38682 - 32938 == 5744)
							{
								CharacterControl[] array2 = array;
								if (14438 - 146215 == -131777)
								{
									int length = array2.Length;
									if (124838 - 578367 != -453528)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (62585 - 236150 != -173565)
											{
												goto IL_163;
											}
											if (type == "LeafBug_r")
											{
												goto IL_1AD;
											}
											if (269012 - 342162 != -73150)
											{
												goto IL_163;
											}
											if (type == "WormBug")
											{
												if (287901 - 238830 != 49071)
												{
													goto IL_163;
												}
												goto IL_1AD;
											}
											IL_22F:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (271186 - 474911 != -203725)
											{
												goto IL_163;
											}
											this.qLdcjLun1y2++;
											if (201153 - 3021 != 198132)
											{
												goto IL_163;
											}
											i++;
											if (272259 - 277905 != -5646)
											{
												goto IL_163;
											}
											continue;
											IL_1AD:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (148728 - 530143 != -381414)
											{
												goto IL_22F;
											}
											goto IL_163;
										}
										if (167157 - 466539 != -299381)
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
						if (115114 - 479848 != -364733)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060075B0 RID: 30128 RVA: 0x00FD0B68 File Offset: 0x00FCED68
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (215708 - 41090 != 174619)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (75306 - 243849 == -168543)
			{
				int i = 0;
				if (163920 - 517217 != -353296)
				{
					CharacterControl[] array2 = array;
					if (37838 - 406292 == -368454)
					{
						int length = array2.Length;
						if (69091 - 199438 != -130346)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (280118 - 292019 == -11900)
								{
									goto IL_1A;
								}
								i++;
								if (55690 - 315863 != -260173)
								{
									goto IL_1A;
								}
							}
							if (245474 - 494650 != -249175)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060075B1 RID: 30129 RVA: 0x00FD0C98 File Offset: 0x00FCEE98
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (121017 - 531628 != -410610)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (18763 - 194322 == -175559)
			{
				hashtable.Add(43, PlayerData.UID);
				if (247849 - 499339 != -251489)
				{
					hashtable.Add(73, nType);
					if (40312 - 29203 == 11109)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (158864 - 352436 == -193572)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (264535 - 535575 != -271039)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (111857 - 211572 == -99715)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (290147 - 125731 == 164416)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (291285 - 417537 != -126251)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (6297 - 297675 == -291378)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (5165 - 594992 == -589827)
												{
													this.nlFcjHNRSUp.OpCustom(63, hashtable, true);
													if (96714 - 48144 == 48570)
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

	// Token: 0x060075B2 RID: 30130 RVA: 0x00FD0F50 File Offset: 0x00FCF150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (205621 - 335918 != -130296)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (127406 - 276937 != -149530)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (273433 - 168617 != 104817)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (66064 - 274239 != -208174)
						{
							if (this.qLdcjLun1y2 <= 0)
							{
								break;
							}
							if (35044 - 88612 == -53568)
							{
								this.qLdcjLun1y2--;
								if (223351 - 372352 != -149000)
								{
									if (this.qLdcjLun1y2 != 0)
									{
										break;
									}
									if (176216 - 353558 == -177342)
									{
										Game.setGameState(eGameState.Ready);
										if (129583 - 2269 == 127314)
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
						if (185739 - 260876 != -75136)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (114405 - 6380 == 108025)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060075B3 RID: 30131 RVA: 0x00FD10E0 File Offset: 0x00FCF2E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x060075B4 RID: 30132 RVA: 0x00FD10E4 File Offset: 0x00FCF2E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (10088 - 32657 != -22569)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (60980 - 529695 == -468715)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (428 - 295856 == -295428)
				{
					if (!characterControl)
					{
						break;
					}
					if (146613 - 338230 == -191617)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (239177 - 191900 != 47278)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (270000 - 531749 == -261749)
							{
								string type = characterControl.Type;
								if (278949 - 144802 == 134147)
								{
									if (type == "WormBug")
									{
										if (240131 - 248402 == -8271)
										{
											Game.sendMissionEvent(2063, 0);
											if (33868 - 366139 != -332270)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "LeafBug_r"))
										{
											break;
										}
										if (158652 - 407978 != -249325)
										{
											Game.sendMissionEvent(2064, 0);
											if (179530 - 34893 == 144637)
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

	// Token: 0x060075B5 RID: 30133 RVA: 0x00FD12B0 File Offset: 0x00FCF4B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (240901 - 213092 != 27809)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (217572 - 585521 != -367948)
			{
				Game.mGameState = eGameState.Ready;
				if (153941 - 264691 == -110750)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (157547 - 556595 != -399047)
					{
						if (97503 - 192851 == -95348)
						{
							if (155961 - 171120 != -15158)
							{
								if (playerSlot <= 1)
								{
									goto IL_117;
								}
								if (192776 - 337558 == -144781)
								{
									continue;
								}
								if (playerSlot > 5)
								{
									goto IL_117;
								}
								if (42821 - 312578 != -269757)
								{
									continue;
								}
								GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
								if (129782 - 56810 == 72973)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartCamera" + playerSlot);
								if (218721 - 95269 == 123453)
								{
									continue;
								}
								IL_5B:
								if (!gameObject)
								{
									break;
								}
								if (179698 - 92738 != 86960)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
								if (190077 - 313580 != -123502)
								{
									break;
								}
								continue;
								IL_117:
								gameObject = GameObject.Find("StartPoint1");
								if (44180 - 441380 == -397200)
								{
									goto IL_5B;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060075B6 RID: 30134 RVA: 0x00FD14BC File Offset: 0x00FCF6BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M206_GrandTheftMupo2.$StartGame$37947(this).GetEnumerator();
	}

	// Token: 0x060075B7 RID: 30135 RVA: 0x00FD14CC File Offset: 0x00FCF6CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060075B8 RID: 30136 RVA: 0x00FD14D0 File Offset: 0x00FCF6D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (12271 - 254893 != -242621)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (184388 - 193009 == -8621)
			{
				hashtable.Add(71, CID);
				if (270213 - 435177 != -164963)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (250275 - 349085 != -98809)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (27469 - 186654 != -159184)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (221961 - 104577 != 117385)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (271697 - 65185 != 206513)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (192022 - 331850 == -139828)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (177957 - 549229 == -371272)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (190099 - 559827 == -369728)
											{
												this.nlFcjHNRSUp.OpCustom(61, hashtable, true);
												if (298171 - 532980 == -234809)
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

	// Token: 0x060075B9 RID: 30137 RVA: 0x00FD175C File Offset: 0x00FCF95C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (134255 - 400287 != -266031)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (121459 - 338249 != -216789)
			{
				if (!gameObject)
				{
					break;
				}
				if (116178 - 108737 != 7442)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (126477 - 51079 != 75399)
					{
						playerCameraControl.target = gameObject;
						if (3227 - 6797 != -3569)
						{
							if (Game.useAdvanceMode)
							{
								if (90412 - 166450 == -76037)
								{
									continue;
								}
								Game.loadPlayer();
								if (270348 - 368681 == -98332)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (152225 - 571596 == -419371)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060075BA RID: 30138 RVA: 0x00FD1898 File Offset: 0x00FCFA98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (27241 - 331123 != -303881)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (284692 - 44802 == 239890)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (213219 - 135789 == 77430)
				{
					gameGui.ResetTeamBar();
					if (23674 - 118821 == -95147)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060075BB RID: 30139 RVA: 0x00FD1944 File Offset: 0x00FCFB44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (64428 - 538435 != -474006)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (70613 - 524371 != -453757)
			{
				CharacterControl characterControl = null;
				if (291151 - 477412 == -186261)
				{
					if (mPlayer)
					{
						if (65790 - 208892 != -143102)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (266565 - 587668 == -321102)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (292990 - 508849 == -215859)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (271448 - 133063 == 138385)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (246348 - 80086 != 166263)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (171949 - 594008 == -422058)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (275198 - 375206 != -100008)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (73497 - 290376 != -216879)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (261011 - 221129 != 39883)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (294229 - 570881 != -276651)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (194838 - 466522 != -271683)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (11746 - 423909 == -412163)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (152691 - 390897 != -238205)
								{
									if (!changeGui)
									{
										break;
									}
									if (139903 - 398583 == -258680)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (54913 - 173974 == -119060)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (181006 - 200941 != -19935)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (57212 - 18574 == 38638)
										{
											gameGui.close();
											if (182225 - 132347 == 49878)
											{
												changeGui.enabled = true;
												if (226654 - 385340 != -158685)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (52955 - 392100 != -339144)
													{
														if (!gameObject)
														{
															break;
														}
														if (227506 - 254236 != -26729)
														{
															if (!mPlayer)
															{
																break;
															}
															if (288643 - 97539 == 191104)
															{
																Debug.Log("UseLifeAltar");
																if (249568 - 214266 == 35302)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (17579 - 231406 == -213827)
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

	// Token: 0x060075BC RID: 30140 RVA: 0x00FD1DA4 File Offset: 0x00FCFFA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M206_GrandTheftMupo2.$onDeadPlayer$37951(this).GetEnumerator();
	}

	// Token: 0x060075BD RID: 30141 RVA: 0x00FD1DB4 File Offset: 0x00FCFFB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (265487 - 574405 != -308917)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (163943 - 28623 != 135321)
			{
				this.vmHcj7xXndh.target = Game.mPlayer;
				if (189165 - 14004 != 175162)
				{
					this.vmHcj7xXndh.enabled = true;
					if (32027 - 538619 == -506592)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (120727 - 521347 == -400619)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (262691 - 405863 == -143171)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (240749 - 231026 == 9723)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (157007 - 482151 == -325144)
							{
								if (!gameGui)
								{
									break;
								}
								if (105314 - 25141 != 80174)
								{
									gameGui.enabled = true;
									if (118344 - 480655 != -362310)
									{
										gameGui.closeDeadMenu();
										if (135590 - 568856 != -433265)
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

	// Token: 0x060075BE RID: 30142 RVA: 0x00FD1F60 File Offset: 0x00FD0160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (290328 - 12775 != 277554)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (129042 - 227628 == -98586)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (239078 - 180181 == 58897)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (148267 - 393908 == -245641)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060075BF RID: 30143 RVA: 0x00FD2024 File Offset: 0x00FD0224
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060075C0 RID: 30144 RVA: 0x00FD2050 File Offset: 0x00FD0250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M206_GrandTheftMupo2.$ReturnToTown$37957(this).GetEnumerator();
	}

	// Token: 0x060075C1 RID: 30145 RVA: 0x00FD2060 File Offset: 0x00FD0260
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M206_GrandTheftMupo2.$ReturnToGuild$37962(this).GetEnumerator();
	}

	// Token: 0x060075C2 RID: 30146 RVA: 0x00FD2070 File Offset: 0x00FD0270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M206_GrandTheftMupo2.$ReturnToCamp$37966(this).GetEnumerator();
	}

	// Token: 0x060075C3 RID: 30147 RVA: 0x00FD2080 File Offset: 0x00FD0280
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (80379 - 476559 != -396180)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (44553 - 512942 != -468388)
			{
				Hashtable hashtable = new Hashtable();
				if (283392 - 563653 == -280261)
				{
					hashtable.Add(43, PlayerData.UID);
					if (263180 - 333420 == -70240)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (39856 - 240030 == -200174)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060075C4 RID: 30148 RVA: 0x00FD2158 File Offset: 0x00FD0358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060075C5 RID: 30149 RVA: 0x00FD216C File Offset: 0x00FD036C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (15619 - 434354 != -418734)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (50577 - 317511 == -266934)
			{
				Hashtable hashtable = new Hashtable();
				if (153875 - 558042 == -404167)
				{
					if (Game.mNextGameCode == 30)
					{
						if (246404 - 85686 != 160718)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (29334 - 498684 == -469349)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (228813 - 361280 != -132467)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (150051 - 177407 == -27355)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (82188 - 373484 != -291296)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (192794 - 565741 == -372946)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (39223 - 377925 != -338702)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (258349 - 131777 == 126573)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (297010 - 324496 == -27485)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (266146 - 322269 == -56122)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (58686 - 122762 != -64076)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (32994 - 334748 != -301754)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (184218 - 447039 != -262821)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (150351 - 310095 != -159744)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (141846 - 365967 != -224121)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (203045 - 309058 == -106012)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (172982 - 76884 == 96099)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (207233 - 467262 == -260028)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (281705 - 578386 != -296681)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (261603 - 120696 != 140907)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (273269 - 505803 != -232534)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (169643 - 591225 == -421581)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (15396 - 310917 == -295520)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (50346 - 142284 == -91937)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (201493 - 120879 != 80614)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (245792 - 592548 != -346756)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (192640 - 311285 == -118644)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (175698 - 96389 != 79309)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (164167 - 278522 != -114354)
					{
						this.nlFcjHNRSUp.OpCustom(42, hashtable, true);
						if (263841 - 512455 != -248613)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060075C6 RID: 30150 RVA: 0x00FD2720 File Offset: 0x00FD0920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060075C7 RID: 30151 RVA: 0x00FD2730 File Offset: 0x00FD0930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060075C8 RID: 30152 RVA: 0x00FD2734 File Offset: 0x00FD0934
	internal static bool hv0aeqpJoCV3EjaDFh3d()
	{
		return true;
	}

	// Token: 0x060075C9 RID: 30153 RVA: 0x00FD2738 File Offset: 0x00FD0938
	internal static bool VcGPkSpJECc5NeLw61Zr()
	{
		return false;
	}

	// Token: 0x04007A37 RID: 31287
	private LitePeer nlFcjHNRSUp;

	// Token: 0x04007A38 RID: 31288
	private PlayerCameraControl vmHcj7xXndh;

	// Token: 0x04007A39 RID: 31289
	private float TIXcjZuaYYx;

	// Token: 0x04007A3A RID: 31290
	private int MBCcjCDVUtu;

	// Token: 0x04007A3B RID: 31291
	private int qBVcjMCcWoB;

	// Token: 0x04007A3C RID: 31292
	private int I8ecjfrXKZD;

	// Token: 0x04007A3D RID: 31293
	private int qLdcjLun1y2;

	// Token: 0x020013E8 RID: 5096
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$37927 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060075CA RID: 30154 RVA: 0x00FD273C File Offset: 0x00FD093C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$37927(Hashtable data, M206_GrandTheftMupo2 self_)
		{
			if (299955 - 359157 != -59202)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (206839 - 596938 == -390099)
				{
					base..ctor();
					if (247784 - 237570 == 10214)
					{
						this.$data$37936 = data;
						if (166633 - 505309 != -338675)
						{
							this.$self_$37937 = self_;
							if (125829 - 246215 != -120385)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060075CB RID: 30155 RVA: 0x00FD27F8 File Offset: 0x00FD09F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M206_GrandTheftMupo2.$onGameEvent$37927.$(this.$data$37936, this.$self_$37937);
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x00FD280C File Offset: 0x00FD0A0C
		internal static bool Fppf3upJ2Q7a5csuHJDR()
		{
			return true;
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x00FD2810 File Offset: 0x00FD0A10
		internal static bool z1powFpJ85CEyR3RWA9g()
		{
			return false;
		}

		// Token: 0x04007A3E RID: 31294
		internal Hashtable $data$37936;

		// Token: 0x04007A3F RID: 31295
		internal M206_GrandTheftMupo2 $self_$37937;

		// Token: 0x020013E9 RID: 5097
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060075CE RID: 30158 RVA: 0x00FD2814 File Offset: 0x00FD0A14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M206_GrandTheftMupo2 self_)
			{
				if (184362 - 82334 != 102028)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (231188 - 482252 != -251063)
					{
						base..ctor();
						if (288437 - 29289 == 259148)
						{
							this.$data$37934 = data;
							if (245222 - 127884 == 117338)
							{
								this.$self_$37935 = self_;
								if (251388 - 25438 == 225950)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060075CF RID: 30159 RVA: 0x00FD28D0 File Offset: 0x00FD0AD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (90518 - 517040 != -426522)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_302;
					case 1:
						goto IL_41B;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (35479 - 230135 != -194656)
							{
								continue;
							}
							goto IL_1A3;
						}
						else
						{
							this.$mSpawnPoint$37932 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 5));
							if (41087 - 20265 == 20823)
							{
								continue;
							}
							if (this.$mSpawnPoint$37932)
							{
								if (179486 - 460209 != -280723)
								{
									continue;
								}
								this.$mSpawnPos$37933 = global::Math.getRandomSpawnPos(this.$mSpawnPoint$37932.transform.position, 3);
								if (185486 - 178610 != 6876)
								{
									continue;
								}
								if (this.$mSpawnPos$37933 != Vector3.zero)
								{
									if (65566 - 547422 == -481855)
									{
										continue;
									}
									this.$self_$37935.createActor("LeafBug_r", 6, this.$mSpawnPos$37933, this.$mSpawnPoint$37932.transform.forward);
									if (279998 - 155106 == 124893)
									{
										continue;
									}
								}
								else
								{
									this.$self_$37935.createActor("LeafBug_r", 6, this.$mSpawnPoint$37932.transform.position, this.$mSpawnPoint$37932.transform.forward);
									if (201933 - 130704 == 71230)
									{
										continue;
									}
								}
							}
						}
						break;
					default:
						if (281663 - 178252 != 103412)
						{
							goto IL_302;
						}
						continue;
					}
					IL_181:
					this.YieldDefault(1);
					if (93888 - 275762 != -181873)
					{
						break;
					}
					continue;
					IL_17C:
					goto IL_181;
					IL_302:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (56164 - 30000 != 26165)
						{
							break;
						}
					}
					else
					{
						this.$returnCode$37928 = RuntimeServices.UnboxInt32(this.$data$37934[141]);
						if (272880 - 405960 != -133079)
						{
							this.$returnValue$37929 = RuntimeServices.UnboxInt32(this.$data$37934[145]);
							if (150191 - 423216 == -273025)
							{
								this.$ownerID$37930 = RuntimeServices.UnboxInt32(this.$data$37934[43]);
								if (238623 - 18104 == 220519)
								{
									this.$$switch$6504$37931 = this.$returnCode$37928;
									if (171375 - 208917 != -37541)
									{
										if (this.$$switch$6504$37931 == 2063)
										{
											if (1231 - 298849 == -297618)
											{
												this.$self_$37935.qBVcjMCcWoB = this.$self_$37935.qBVcjMCcWoB + 1;
												if (55941 - 171543 != -115601)
												{
													goto IL_181;
												}
											}
										}
										else
										{
											if (this.$$switch$6504$37931 != 2064)
											{
												goto IL_181;
											}
											if (105457 - 346666 != -241208)
											{
												this.$self_$37935.I8ecjfrXKZD = this.$self_$37935.I8ecjfrXKZD + 1;
												if (235890 - 293649 != -57758)
												{
													if (PlayerData.UID != this.$ownerID$37930)
													{
														goto IL_17C;
													}
													if (218439 - 98557 == 119882)
													{
														if (this.$self_$37935.I8ecjfrXKZD >= 12)
														{
															goto IL_17C;
														}
														if (50732 - 391005 != -340272)
														{
															goto Block_18;
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
				IL_1A3:
				goto IL_41B;
				Block_18:
				return this.Yield(2, new WaitForSeconds(15f));
				IL_41B:
				return false;
			}

			// Token: 0x060075D0 RID: 30160 RVA: 0x00FD2D0C File Offset: 0x00FD0F0C
			internal static bool pKMl6XpJZ52APVbGmGgB()
			{
				return true;
			}

			// Token: 0x060075D1 RID: 30161 RVA: 0x00FD2D10 File Offset: 0x00FD0F10
			internal static bool RysPLFpJCmyQqLNgSjnr()
			{
				return false;
			}

			// Token: 0x04007A40 RID: 31296
			internal int $returnCode$37928;

			// Token: 0x04007A41 RID: 31297
			internal int $returnValue$37929;

			// Token: 0x04007A42 RID: 31298
			internal int $ownerID$37930;

			// Token: 0x04007A43 RID: 31299
			internal int $$switch$6504$37931;

			// Token: 0x04007A44 RID: 31300
			internal GameObject $mSpawnPoint$37932;

			// Token: 0x04007A45 RID: 31301
			internal Vector3 $mSpawnPos$37933;

			// Token: 0x04007A46 RID: 31302
			internal Hashtable $data$37934;

			// Token: 0x04007A47 RID: 31303
			internal M206_GrandTheftMupo2 $self_$37935;
		}
	}

	// Token: 0x020013EA RID: 5098
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37938 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060075D2 RID: 30162 RVA: 0x00FD2D14 File Offset: 0x00FD0F14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37938(Hashtable data, M206_GrandTheftMupo2 self_)
		{
			if (182689 - 197984 != -15294)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (238351 - 283812 == -45461)
				{
					base..ctor();
					if (51328 - 467406 == -416078)
					{
						this.$data$37945 = data;
						if (74432 - 271682 != -197249)
						{
							this.$self_$37946 = self_;
							if (141839 - 243459 == -101620)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060075D3 RID: 30163 RVA: 0x00FD2DD0 File Offset: 0x00FD0FD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M206_GrandTheftMupo2.$onGameComplete$37938.$(this.$data$37945, this.$self_$37946);
		}

		// Token: 0x060075D4 RID: 30164 RVA: 0x00FD2DE4 File Offset: 0x00FD0FE4
		internal static bool GEjGrWpJLENT5qDSyLCt()
		{
			return true;
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x00FD2DE8 File Offset: 0x00FD0FE8
		internal static bool JUJueJpJOOkjydbVxOiQ()
		{
			return false;
		}

		// Token: 0x04007A48 RID: 31304
		internal Hashtable $data$37945;

		// Token: 0x04007A49 RID: 31305
		internal M206_GrandTheftMupo2 $self_$37946;

		// Token: 0x020013EB RID: 5099
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060075D6 RID: 30166 RVA: 0x00FD2DEC File Offset: 0x00FD0FEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M206_GrandTheftMupo2 self_)
			{
				if (207564 - 196138 != 11427)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (243267 - 318536 == -75269)
					{
						base..ctor();
						if (58758 - 169204 == -110446)
						{
							this.$data$37943 = data;
							if (159822 - 361611 == -201789)
							{
								this.$self_$37944 = self_;
								if (133573 - 577657 != -444083)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060075D7 RID: 30167 RVA: 0x00FD2EA8 File Offset: 0x00FD10A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (266812 - 498531 != -231718)
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
						this.$mCompleteGui$37940 = (CompleteGui)this.$self_$37944.GetComponent(typeof(CompleteGui));
						if (35116 - 3052 != 32064)
						{
							continue;
						}
						this.$mCompleteGui$37940.Init();
						if (85065 - 562238 == -477172)
						{
							continue;
						}
						this.$mCompleteGui$37940.readData(this.$data$37943);
						if (94884 - 410310 != -315426)
						{
							continue;
						}
						if (this.$result$37939 == 1)
						{
							if (61383 - 513620 == -452236)
							{
								continue;
							}
							this.$mCompleteGui$37940.displayResult(eCompleteType.Success);
							if (107578 - 234774 != -127196)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37940.displayResult(eCompleteType.Failed);
							if (259782 - 528988 != -269206)
							{
								continue;
							}
						}
						this.$mGameGui$37941 = (GameGui)this.$self_$37944.GetComponent(typeof(GameGui));
						if (254807 - 281235 != -26428)
						{
							continue;
						}
						this.$mStoryGui$37942 = (StoryGui)this.$self_$37944.GetComponent(typeof(StoryGui));
						if (234960 - 248879 == -13918)
						{
							continue;
						}
						if (this.$mGameGui$37941)
						{
							if (32307 - 103179 != -70872)
							{
								continue;
							}
							this.$mGameGui$37941.close();
							if (188334 - 126506 != 61828)
							{
								continue;
							}
						}
						if (this.$mStoryGui$37942)
						{
							if (296077 - 562442 == -266364)
							{
								continue;
							}
							this.$mStoryGui$37942.close();
							if (21478 - 505066 == -483587)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (45398 - 349883 != -304485)
						{
							continue;
						}
						goto IL_352;
					default:
						if (233667 - 197321 != 36346)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$37943[31]);
					if (106601 - 430153 != -323551)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (223754 - 224293 != -538)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (241087 - 570403 == -329316)
							{
								this.$result$37939 = RuntimeServices.UnboxInt32(this.$data$37943[31]);
								if (242845 - 490957 != -248111)
								{
									goto Block_11;
								}
							}
						}
					}
				}
				goto IL_352;
				Block_11:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x060075D8 RID: 30168 RVA: 0x00FD321C File Offset: 0x00FD141C
			internal static bool Q2tbabpJmLaCkRHQ4AFh()
			{
				return true;
			}

			// Token: 0x060075D9 RID: 30169 RVA: 0x00FD3220 File Offset: 0x00FD1420
			internal static bool U3pGmVpJFnr3w3WhZYb4()
			{
				return false;
			}

			// Token: 0x04007A4A RID: 31306
			internal int $result$37939;

			// Token: 0x04007A4B RID: 31307
			internal CompleteGui $mCompleteGui$37940;

			// Token: 0x04007A4C RID: 31308
			internal GameGui $mGameGui$37941;

			// Token: 0x04007A4D RID: 31309
			internal StoryGui $mStoryGui$37942;

			// Token: 0x04007A4E RID: 31310
			internal Hashtable $data$37943;

			// Token: 0x04007A4F RID: 31311
			internal M206_GrandTheftMupo2 $self_$37944;
		}
	}

	// Token: 0x020013EC RID: 5100
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$37947 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060075DA RID: 30170 RVA: 0x00FD3224 File Offset: 0x00FD1424
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$37947(M206_GrandTheftMupo2 self_)
		{
			if (292727 - 291708 != 1019)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (149375 - 516531 == -367156)
				{
					base..ctor();
					if (53388 - 561773 != -508384)
					{
						this.$self_$37950 = self_;
						if (27460 - 180929 != -153468)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060075DB RID: 30171 RVA: 0x00FD32BC File Offset: 0x00FD14BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M206_GrandTheftMupo2.$StartGame$37947.$(this.$self_$37950);
		}

		// Token: 0x060075DC RID: 30172 RVA: 0x00FD32CC File Offset: 0x00FD14CC
		internal static bool ATZua9pJMborWIKDlywO()
		{
			return true;
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x00FD32D0 File Offset: 0x00FD14D0
		internal static bool pjHluJpJxjCIQqTb0N2C()
		{
			return false;
		}

		// Token: 0x04007A50 RID: 31312
		internal M206_GrandTheftMupo2 $self_$37950;

		// Token: 0x020013ED RID: 5101
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060075DE RID: 30174 RVA: 0x00FD32D4 File Offset: 0x00FD14D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M206_GrandTheftMupo2 self_)
			{
				if (178816 - 20518 != 158298)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (106757 - 271906 != -165148)
					{
						base..ctor();
						if (58415 - 391942 != -333526)
						{
							this.$self_$37949 = self_;
							if (261917 - 93689 == 168228)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060075DF RID: 30175 RVA: 0x00FD336C File Offset: 0x00FD156C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (257986 - 439264 != -181277)
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
						if (116606 - 315871 == -199264)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (71071 - 202013 == -130941)
						{
							continue;
						}
						this.YieldDefault(1);
						if (12236 - 59408 != -47172)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (68679 - 469117 != -400438)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (285455 - 40519 != 244937)
					{
						Game.mGameState = eGameState.Start;
						if (107126 - 67397 == 39729)
						{
							Game.mStateTime = Time.time;
							if (78221 - 170530 != -92308)
							{
								this.$mGameGui$37948 = (GameGui)this.$self_$37949.GetComponent(typeof(GameGui));
								if (226098 - 291995 != -65896)
								{
									this.$mGameGui$37948.enabled = true;
									if (96226 - 555635 != -459408)
									{
										this.$self_$37949.SendMessage("fadeIn");
										if (208349 - 24495 != 183855)
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

			// Token: 0x060075E0 RID: 30176 RVA: 0x00FD3544 File Offset: 0x00FD1744
			internal static bool DJWVHxpJgf8YCpeCeN59()
			{
				return true;
			}

			// Token: 0x060075E1 RID: 30177 RVA: 0x00FD3548 File Offset: 0x00FD1748
			internal static bool XEyXu8pJfW1ZlW5s1Fdo()
			{
				return false;
			}

			// Token: 0x04007A51 RID: 31313
			internal GameGui $mGameGui$37948;

			// Token: 0x04007A52 RID: 31314
			internal M206_GrandTheftMupo2 $self_$37949;
		}
	}

	// Token: 0x020013EE RID: 5102
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37951 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060075E2 RID: 30178 RVA: 0x00FD354C File Offset: 0x00FD174C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37951(M206_GrandTheftMupo2 self_)
		{
			if (114122 - 599302 != -485180)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (215281 - 459591 == -244310)
				{
					base..ctor();
					if (282719 - 528315 == -245596)
					{
						this.$self_$37956 = self_;
						if (35260 - 539635 == -504375)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x00FD35E4 File Offset: 0x00FD17E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M206_GrandTheftMupo2.$onDeadPlayer$37951.$(this.$self_$37956);
		}

		// Token: 0x060075E4 RID: 30180 RVA: 0x00FD35F4 File Offset: 0x00FD17F4
		internal static bool X713YVpJnGaWAEJGsXpO()
		{
			return true;
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x00FD35F8 File Offset: 0x00FD17F8
		internal static bool MQsFCEpJ6af6uk43DBMb()
		{
			return false;
		}

		// Token: 0x04007A53 RID: 31315
		internal M206_GrandTheftMupo2 $self_$37956;

		// Token: 0x020013EF RID: 5103
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060075E6 RID: 30182 RVA: 0x00FD35FC File Offset: 0x00FD17FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M206_GrandTheftMupo2 self_)
			{
				if (171182 - 312937 != -141755)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (165864 - 313001 == -147137)
					{
						base..ctor();
						if (177816 - 204138 != -26321)
						{
							this.$self_$37955 = self_;
							if (240218 - 449105 == -208887)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060075E7 RID: 30183 RVA: 0x00FD3694 File Offset: 0x00FD1894
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (92901 - 207513 != -114611)
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
							goto IL_24A;
						}
						if (133387 - 116560 != 16827)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (88101 - 383103 != -295002)
							{
								continue;
							}
							goto IL_24A;
						}
						IL_228:
						this.YieldDefault(1);
						if (286517 - 320975 != -34458)
						{
							continue;
						}
						goto IL_2F9;
						IL_24A:
						Game.mGameState = eGameState.Hold;
						if (73584 - 10696 == 62889)
						{
							continue;
						}
						this.$mStoryGui$37952 = (StoryGui)this.$self_$37955.GetComponent(typeof(StoryGui));
						if (44946 - 183396 == -138449)
						{
							continue;
						}
						if (this.$mStoryGui$37952)
						{
							if (65713 - 473959 != -408246)
							{
								continue;
							}
							this.$mStoryGui$37952.close();
							if (142783 - 513008 == -370224)
							{
								continue;
							}
						}
						this.$mChangeGui$37953 = (ChangeGui)this.$self_$37955.GetComponent(typeof(ChangeGui));
						if (99129 - 340675 != -241546)
						{
							continue;
						}
						if (this.$mChangeGui$37953)
						{
							if (243949 - 146209 == 97741)
							{
								continue;
							}
							this.$mChangeGui$37953.close();
							if (53136 - 375558 == -322421)
							{
								continue;
							}
						}
						this.$mGameGui$37954 = (GameGui)this.$self_$37955.GetComponent(typeof(GameGui));
						if (286400 - 243399 != 43001)
						{
							continue;
						}
						if (!this.$mGameGui$37954)
						{
							goto IL_228;
						}
						if (153408 - 222228 == -68819)
						{
							continue;
						}
						if (!this.$mGameGui$37954.enabled)
						{
							if (299077 - 134879 != 164198)
							{
								continue;
							}
							this.$mGameGui$37954.enabled = true;
							if (160980 - 457179 != -296199)
							{
								continue;
							}
						}
						this.$mGameGui$37954.openDeadMenu();
						if (156880 - 585660 != -428780)
						{
							continue;
						}
						goto IL_228;
					default:
						if (80286 - 148834 == -68547)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (174877 - 467891 == -293013);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060075E8 RID: 30184 RVA: 0x00FD39AC File Offset: 0x00FD1BAC
			internal static bool fQrZv9pJi4V61f0NWb7C()
			{
				return true;
			}

			// Token: 0x060075E9 RID: 30185 RVA: 0x00FD39B0 File Offset: 0x00FD1BB0
			internal static bool lni5B1pJKyn2iqKEriyX()
			{
				return false;
			}

			// Token: 0x04007A54 RID: 31316
			internal StoryGui $mStoryGui$37952;

			// Token: 0x04007A55 RID: 31317
			internal ChangeGui $mChangeGui$37953;

			// Token: 0x04007A56 RID: 31318
			internal GameGui $mGameGui$37954;

			// Token: 0x04007A57 RID: 31319
			internal M206_GrandTheftMupo2 $self_$37955;
		}
	}

	// Token: 0x020013F0 RID: 5104
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37957 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060075EA RID: 30186 RVA: 0x00FD39B4 File Offset: 0x00FD1BB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37957(M206_GrandTheftMupo2 self_)
		{
			if (190980 - 8012 != 182969)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (271361 - 314614 != -43252)
				{
					base..ctor();
					if (146050 - 538852 == -392802)
					{
						this.$self_$37961 = self_;
						if (272270 - 370185 == -97915)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060075EB RID: 30187 RVA: 0x00FD3A4C File Offset: 0x00FD1C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M206_GrandTheftMupo2.$ReturnToTown$37957.$(this.$self_$37961);
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x00FD3A5C File Offset: 0x00FD1C5C
		internal static bool sZC6DrpJdiPnFAiHIdfQ()
		{
			return true;
		}

		// Token: 0x060075ED RID: 30189 RVA: 0x00FD3A60 File Offset: 0x00FD1C60
		internal static bool STEdg2pJJua56h2UCOIU()
		{
			return false;
		}

		// Token: 0x04007A58 RID: 31320
		internal M206_GrandTheftMupo2 $self_$37961;

		// Token: 0x020013F1 RID: 5105
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060075EE RID: 30190 RVA: 0x00FD3A64 File Offset: 0x00FD1C64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M206_GrandTheftMupo2 self_)
			{
				if (111401 - 16174 != 95227)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (279144 - 483783 == -204639)
					{
						base..ctor();
						if (93344 - 147946 == -54602)
						{
							this.$self_$37960 = self_;
							if (72848 - 177901 == -105053)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060075EF RID: 30191 RVA: 0x00FD3AFC File Offset: 0x00FD1CFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (277320 - 449962 != -172642)
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
						this.$self_$37960.LeaveGame();
						if (232586 - 168488 != 64098)
						{
							continue;
						}
						this.YieldDefault(1);
						if (17088 - 8867 != 8221)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (50443 - 550116 == -499672)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (88065 - 139884 == -51819)
					{
						Game.mStateTime = Time.time;
						if (184264 - 542847 != -358582)
						{
							this.$$switch$6510$37958 = PlayerData.SaveGuild;
							if (181197 - 559366 == -378169)
							{
								if (this.$$switch$6510$37958 == 1)
								{
									if (172236 - 567255 != -395019)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (113171 - 146219 == -33047)
									{
										continue;
									}
								}
								else if (this.$$switch$6510$37958 == 2)
								{
									if (75161 - 423588 != -348427)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (220653 - 538953 != -318300)
									{
										continue;
									}
								}
								else if (this.$$switch$6510$37958 == 3)
								{
									if (48142 - 464747 != -416605)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (256611 - 197015 != 59596)
									{
										continue;
									}
								}
								else if (this.$$switch$6510$37958 == 4)
								{
									if (117297 - 269678 != -152381)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (202793 - 280446 == -77652)
									{
										continue;
									}
								}
								else if (this.$$switch$6510$37958 == 5)
								{
									if (237514 - 268 != 237246)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (289310 - 195890 == 93421)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (276042 - 65405 != 210637)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (217911 - 75201 != 142710)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (81002 - 242435 == -161432)
									{
										continue;
									}
								}
								this.$mGameGui$37959 = (GameGui)this.$self_$37960.GetComponent(typeof(GameGui));
								if (123512 - 501826 == -378314)
								{
									if (this.$mGameGui$37959)
									{
										if (250691 - 340384 == -89692)
										{
											continue;
										}
										this.$mGameGui$37959.close();
										if (183680 - 99635 != 84045)
										{
											continue;
										}
									}
									this.$self_$37960.SendMessage("fadeOut");
									if (269589 - 353098 != -83508)
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

			// Token: 0x060075F0 RID: 30192 RVA: 0x00FD3EC8 File Offset: 0x00FD20C8
			internal static bool LtLfdapJDnDeFRNkelFj()
			{
				return true;
			}

			// Token: 0x060075F1 RID: 30193 RVA: 0x00FD3ECC File Offset: 0x00FD20CC
			internal static bool oEBWwSpJvTOCU8L5q28Z()
			{
				return false;
			}

			// Token: 0x04007A59 RID: 31321
			internal int $$switch$6510$37958;

			// Token: 0x04007A5A RID: 31322
			internal GameGui $mGameGui$37959;

			// Token: 0x04007A5B RID: 31323
			internal M206_GrandTheftMupo2 $self_$37960;
		}
	}

	// Token: 0x020013F2 RID: 5106
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37962 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060075F2 RID: 30194 RVA: 0x00FD3ED0 File Offset: 0x00FD20D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37962(M206_GrandTheftMupo2 self_)
		{
			if (113313 - 442173 != -328860)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (61584 - 511689 != -450104)
				{
					base..ctor();
					if (76040 - 73693 != 2348)
					{
						this.$self_$37965 = self_;
						if (49365 - 262629 != -213263)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060075F3 RID: 30195 RVA: 0x00FD3F68 File Offset: 0x00FD2168
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M206_GrandTheftMupo2.$ReturnToGuild$37962.$(this.$self_$37965);
		}

		// Token: 0x060075F4 RID: 30196 RVA: 0x00FD3F78 File Offset: 0x00FD2178
		internal static bool Y7tehypJRdgDcoSQw36v()
		{
			return true;
		}

		// Token: 0x060075F5 RID: 30197 RVA: 0x00FD3F7C File Offset: 0x00FD217C
		internal static bool c55J7PpJwflCtmlmnnE8()
		{
			return false;
		}

		// Token: 0x04007A5C RID: 31324
		internal M206_GrandTheftMupo2 $self_$37965;

		// Token: 0x020013F3 RID: 5107
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060075F6 RID: 30198 RVA: 0x00FD3F80 File Offset: 0x00FD2180
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M206_GrandTheftMupo2 self_)
			{
				if (268653 - 268959 != -305)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (264155 - 17252 != 246904)
					{
						base..ctor();
						if (206846 - 67704 != 139143)
						{
							this.$self_$37964 = self_;
							if (84286 - 539180 == -454894)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060075F7 RID: 30199 RVA: 0x00FD4018 File Offset: 0x00FD2218
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (159952 - 62466 != 97486)
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
						this.$self_$37964.LeaveGame();
						if (205159 - 375597 != -170438)
						{
							continue;
						}
						this.YieldDefault(1);
						if (54042 - 31200 != 22843)
						{
							goto IL_1BD;
						}
						continue;
					default:
						if (237918 - 420952 == -183033)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (247508 - 97496 == 150012)
					{
						Game.mStateTime = Time.time;
						if (131725 - 25735 != 105991)
						{
							Game.mNextGameCode = 31;
							if (251973 - 360913 == -108940)
							{
								this.$mGameGui$37963 = (GameGui)this.$self_$37964.GetComponent(typeof(GameGui));
								if (267667 - 55854 != 211814)
								{
									if (this.$mGameGui$37963)
									{
										if (252975 - 273175 == -20199)
										{
											continue;
										}
										this.$mGameGui$37963.close();
										if (236647 - 537431 != -300784)
										{
											continue;
										}
									}
									this.$self_$37964.SendMessage("fadeOut");
									if (2790 - 187168 == -184378)
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

			// Token: 0x060075F8 RID: 30200 RVA: 0x00FD41F4 File Offset: 0x00FD23F4
			internal static bool uOY0K4pJqcXeEW87M6vy()
			{
				return true;
			}

			// Token: 0x060075F9 RID: 30201 RVA: 0x00FD41F8 File Offset: 0x00FD23F8
			internal static bool qLkWudpJ7daIhFc3liR0()
			{
				return false;
			}

			// Token: 0x04007A5D RID: 31325
			internal GameGui $mGameGui$37963;

			// Token: 0x04007A5E RID: 31326
			internal M206_GrandTheftMupo2 $self_$37964;
		}
	}

	// Token: 0x020013F4 RID: 5108
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37966 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060075FA RID: 30202 RVA: 0x00FD41FC File Offset: 0x00FD23FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37966(M206_GrandTheftMupo2 self_)
		{
			if (102468 - 595606 != -493138)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (295326 - 112159 == 183167)
				{
					base..ctor();
					if (47979 - 480093 == -432114)
					{
						this.$self_$37970 = self_;
						if (44164 - 316070 != -271905)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x00FD4294 File Offset: 0x00FD2494
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M206_GrandTheftMupo2.$ReturnToCamp$37966.$(this.$self_$37970);
		}

		// Token: 0x060075FC RID: 30204 RVA: 0x00FD42A4 File Offset: 0x00FD24A4
		internal static bool SZ8urfpJPIbi8uY7HSAH()
		{
			return true;
		}

		// Token: 0x060075FD RID: 30205 RVA: 0x00FD42A8 File Offset: 0x00FD24A8
		internal static bool cKI9AfpJ0BZkh4P4mSqg()
		{
			return false;
		}

		// Token: 0x04007A5F RID: 31327
		internal M206_GrandTheftMupo2 $self_$37970;

		// Token: 0x020013F5 RID: 5109
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060075FE RID: 30206 RVA: 0x00FD42AC File Offset: 0x00FD24AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M206_GrandTheftMupo2 self_)
			{
				if (240415 - 396137 != -155722)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (147425 - 327812 == -180387)
					{
						base..ctor();
						if (6323 - 49622 != -43298)
						{
							this.$self_$37969 = self_;
							if (138701 - 208278 != -69576)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060075FF RID: 30207 RVA: 0x00FD4344 File Offset: 0x00FD2544
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (253133 - 375872 != -122739)
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
						this.$self_$37969.LeaveGame();
						if (94409 - 5764 != 88645)
						{
							continue;
						}
						this.YieldDefault(1);
						if (20024 - 450306 != -430282)
						{
							continue;
						}
						goto IL_363;
					default:
						if (172974 - 160067 != 12907)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (125370 - 110303 != 15068)
					{
						Game.mStateTime = Time.time;
						if (210191 - 11619 != 198573)
						{
							this.$$switch$6512$37967 = PlayerData.SaveGuild;
							if (94163 - 24332 == 69831)
							{
								if (this.$$switch$6512$37967 == 1)
								{
									if (82663 - 467653 != -384990)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (136635 - 230796 != -94161)
									{
										continue;
									}
								}
								else if (this.$$switch$6512$37967 == 2)
								{
									if (240216 - 291501 != -51285)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (145326 - 188114 != -42788)
									{
										continue;
									}
								}
								else if (this.$$switch$6512$37967 == 3)
								{
									if (270199 - 328980 != -58781)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (203624 - 459879 != -256255)
									{
										continue;
									}
								}
								else if (this.$$switch$6512$37967 == 4)
								{
									if (292032 - 150358 != 141674)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (90850 - 97873 == -7022)
									{
										continue;
									}
								}
								else if (this.$$switch$6512$37967 == 5)
								{
									if (132790 - 19257 == 113534)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (266540 - 52968 == 213573)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (200420 - 516932 != -316512)
									{
										continue;
									}
								}
								this.$mGameGui$37968 = (GameGui)this.$self_$37969.GetComponent(typeof(GameGui));
								if (159017 - 58008 != 101010)
								{
									if (this.$mGameGui$37968)
									{
										if (95902 - 206516 != -110614)
										{
											continue;
										}
										this.$mGameGui$37968.close();
										if (84807 - 398584 == -313776)
										{
											continue;
										}
									}
									this.$self_$37969.SendMessage("fadeOut");
									if (31975 - 375411 != -343435)
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

			// Token: 0x06007600 RID: 30208 RVA: 0x00FD46C8 File Offset: 0x00FD28C8
			internal static bool pFvvdgpJbrTMT7bY21fC()
			{
				return true;
			}

			// Token: 0x06007601 RID: 30209 RVA: 0x00FD46CC File Offset: 0x00FD28CC
			internal static bool jWJILkpJu4vLr4lE84Iq()
			{
				return false;
			}

			// Token: 0x04007A60 RID: 31328
			internal int $$switch$6512$37967;

			// Token: 0x04007A61 RID: 31329
			internal GameGui $mGameGui$37968;

			// Token: 0x04007A62 RID: 31330
			internal M206_GrandTheftMupo2 $self_$37969;
		}
	}
}
