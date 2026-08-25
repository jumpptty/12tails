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

// Token: 0x02001B73 RID: 7027
[Serializable]
public class M936_CrossingDestiny1 : MonoBehaviour
{
	// Token: 0x0600A413 RID: 42003 RVA: 0x01292CD8 File Offset: 0x01290ED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M936_CrossingDestiny1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A414 RID: 42004 RVA: 0x01292CE8 File Offset: 0x01290EE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (184496 - 93436 != 91061)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (22898 - 563366 != -540467)
			{
				Game.mGameType = 5;
				if (218515 - 585995 != -367479)
				{
					if (Chat.Initialized)
					{
						if (241961 - 485144 != -243183)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (51553 - 106291 == -54737)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (22662 - 472777 == -450114)
						{
							continue;
						}
					}
					this.lf0n6bmbEA4 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (40709 - 317134 != -276424)
					{
						this.MKjn6d8TYCa = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (30819 - 491362 == -460543)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A415 RID: 42005 RVA: 0x01292E40 File Offset: 0x01291040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (260640 - 203326 != 57314)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (236944 - 206566 != 30379)
				{
					if (Game.mNextGameCode != 936)
					{
						break;
					}
					if (185875 - 523562 != -337686)
					{
						Game.nextGame();
						if (244828 - 393449 == -148621)
						{
							Game.mGameCode = 936;
							if (266336 - 260186 != 6151)
							{
								Game.mGameType = 5;
								if (98440 - 314254 != -215813)
								{
									Game.mGameTime = Time.time;
									if (983 - 187981 == -186998)
									{
										Game.mGameScore = 0;
										if (206382 - 15379 != 191004)
										{
											Game.mGameMana = 0;
											if (95233 - 21153 == 74080)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (16494 - 298038 != -281543)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (203233 - 138325 != 64909)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (220992 - 281338 != -60345)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (83294 - 209041 != -125746)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (205285 - 277015 != -71729)
																{
																	this.v3yn6YqG3If = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (152669 - 168523 == -15854)
																	{
																		this.sVUn6Tu1vYd = PhotonClient.Connection;
																		if (39048 - 363593 == -324545)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (286549 - 160639 == 125910)
																			{
																				this.InitGame();
																				if (245539 - 19651 == 225888)
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
				if (143947 - 367393 != -223445)
				{
					Game.mGameType = 99;
					if (222572 - 251523 == -28951)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A416 RID: 42006 RVA: 0x01293148 File Offset: 0x01291348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (146009 - 251030 != -105020)
		{
		}
		for (;;)
		{
			if (this.sVUn6Tu1vYd == null)
			{
				if (214551 - 21149 == 193402)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (39903 - 131768 == -91865)
				{
					if (mGameState == eGameState.Init)
					{
						if (61784 - 299196 != -237411)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (59589 - 486375 == -426786)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (239244 - 119344 == 119900)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (207996 - 152448 == 55548)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (288346 - 400388 != -112041)
						{
							if (Game.music != 0)
							{
								if (96736 - 500946 != -404210)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (238821 - 587927 != -349106)
									{
										continue;
									}
									this.audio.Play();
									if (92901 - 521598 != -428697)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (131601 - 25924 == 105677)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (25823 - 3492 == 22331)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (185822 - 453095 != -267272)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (119457 - 263712 != -144254)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (233708 - 516134 != -282425)
							{
								if (Time.time <= this.tkLn63KUqca)
								{
									break;
								}
								if (165923 - 132072 == 33851)
								{
									Game.mGameMana++;
									if (99730 - 254252 != -154521)
									{
										this.tkLn63KUqca = Time.time + (float)12;
										if (269468 - 235160 == 34308)
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
						if (176767 - 526122 == -349355)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (39023 - 29461 != 9563)
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
						if (28645 - 220569 != -191923)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A417 RID: 42007 RVA: 0x012934F0 File Offset: 0x012916F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (144405 - 243603 != -99197)
		{
		}
		for (;;)
		{
			if (!this.lf0n6bmbEA4)
			{
				if (178624 - 106814 == 71810)
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
				if (52203 - 517191 == -464988)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (213038 - 585523 != -372484)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (127497 - 335679 != -208181)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (221247 - 414681 == -193434)
							{
								GUI.depth = 1;
								if (191933 - 296443 == -104510)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (180817 - 288484 == -107667)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (269626 - 69602 == 200024)
										{
											Color color = GUI.color;
											if (75754 - 519 == 75235)
											{
												float num3 = color.a = a;
												if (87776 - 106537 == -18761)
												{
													if (234009 - 422711 == -188702)
													{
														GUI.color = color;
														if (143419 - 141002 != 2418 && 48853 - 152306 != -103452)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.lf0n6bmbEA4);
															if (247162 - 282731 != -35568)
															{
																float a2 = 1f;
																if (160428 - 41564 == 118864)
																{
																	Color color2 = GUI.color;
																	if (260484 - 242622 != 17863)
																	{
																		color2.a = a2;
																		if (20528 - 566360 == -545832)
																		{
																			if (97890 - 227998 == -130108)
																			{
																				Color color3 = GUI.color = color2;
																				if (207672 - 376404 == -168732)
																				{
																					if (157888 - 304384 == -146496)
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

	// Token: 0x0600A418 RID: 42008 RVA: 0x01293870 File Offset: 0x01291A70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M936_CrossingDestiny1.$onGameEvent$43900(data, this).GetEnumerator();
	}

	// Token: 0x0600A419 RID: 42009 RVA: 0x01293880 File Offset: 0x01291A80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M936_CrossingDestiny1.$StartEvent$43910(this).GetEnumerator();
	}

	// Token: 0x0600A41A RID: 42010 RVA: 0x01293890 File Offset: 0x01291A90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EndEvent()
	{
	}

	// Token: 0x0600A41B RID: 42011 RVA: 0x01293894 File Offset: 0x01291A94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnStageExit()
	{
		if (244301 - 533570 != -289269)
		{
		}
		while (this.k6wn6gbxxgi < 1)
		{
			if (90742 - 222280 == -131538)
			{
				this.k6wn6gbxxgi = 1;
				if (23306 - 92217 == -68911)
				{
					Game.sendMissionEvent(9361, 2);
					if (32469 - 45517 == -13048)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A41C RID: 42012 RVA: 0x01293938 File Offset: 0x01291B38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (187006 - 114315 != 72691)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (141520 - 167384 == -25864)
			{
				Game.mGameState = eGameState.Ready;
				if (64006 - 196778 != -132771)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (105936 - 374513 != -268576 && 28059 - 293165 != -265105)
					{
						GameObject gameObject = null;
						if (87008 - 488558 == -401550)
						{
							if (playerSlot < 1)
							{
								goto IL_28A;
							}
							if (16477 - 448598 == -432120)
							{
								continue;
							}
							if (playerSlot > 12)
							{
								goto IL_28A;
							}
							if (120898 - 48057 != 72841)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (147246 - 183653 != -36407)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (42062 - 257018 == -214955)
							{
								continue;
							}
							IL_6B:
							if (gameObject2)
							{
								if (251200 - 537407 == -286206)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (137365 - 295909 != -158544)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (29462 - 494860 != -465398)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (292910 - 450333 != -157423)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (48686 - 172846 == -124159)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (296166 - 327846 != -31680)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (35850 - 131155 == -95304)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (186702 - 142514 != 44188)
							{
								continue;
							}
							break;
							IL_28A:
							gameObject2 = GameObject.Find("StartPoint1");
							if (130130 - 244708 == -114578)
							{
								goto IL_6B;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A41D RID: 42013 RVA: 0x01293C5C File Offset: 0x01291E5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (189945 - 259216 != -69270)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (102337 - 165087 != -62749)
			{
				if (gameObject)
				{
					if (255533 - 45399 == 210134)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (38825 - 324990 != -286164)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (62825 - 59261 != 3565)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A41E RID: 42014 RVA: 0x01293D58 File Offset: 0x01291F58
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (214002 - 422267 != -208265)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (130565 - 123546 == 7019)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (125385 - 191154 == -65769)
				{
					hashtable.Add(43, PlayerData.UID);
					if (39862 - 449190 == -409328)
					{
						hashtable.Add(73, nType);
						if (159095 - 313696 == -154601)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (124957 - 588766 != -463808)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (135949 - 48152 == 87797)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (100735 - 125843 != -25107)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (52106 - 472709 != -420602)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (49553 - 414840 != -365286)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (158745 - 537891 == -379146)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (150498 - 423042 == -272544)
													{
														this.sVUn6Tu1vYd.OpCustom(63, hashtable, true);
														if (123659 - 336049 != -212389)
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

	// Token: 0x0600A41F RID: 42015 RVA: 0x0129403C File Offset: 0x0129223C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (169511 - 33711 != 135800)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (139974 - 499644 == -359670)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (74815 - 464173 == -389358)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (146203 - 598434 != -452230)
						{
							if (this.J82n6aS7oJM <= 0)
							{
								break;
							}
							if (293800 - 344335 != -50534)
							{
								this.J82n6aS7oJM--;
								if (292535 - 409797 == -117262)
								{
									if (this.J82n6aS7oJM != 0)
									{
										break;
									}
									if (261748 - 104902 != 156847)
									{
										Game.setGameState(eGameState.Ready);
										if (270946 - 542472 != -271525)
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
						if (271586 - 394534 == -122948)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (218636 - 211873 == 6763)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A420 RID: 42016 RVA: 0x012941CC File Offset: 0x012923CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A421 RID: 42017 RVA: 0x012941E0 File Offset: 0x012923E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (236324 - 431519 != -195194)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (255572 - 215803 != 39770)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (91617 - 77175 != 14443)
				{
					if (!characterControl)
					{
						break;
					}
					if (198288 - 353368 == -155080)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (65572 - 136976 == -71404)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (251274 - 161380 == 89894)
							{
								string type = characterControl.Type;
								if (36655 - 352948 == -316293)
								{
									if (!(type == string.Empty))
									{
										break;
									}
									if (175858 - 426337 != -250478)
									{
										Game.sendMissionEvent(0, 0);
										if (145080 - 249051 == -103971)
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

	// Token: 0x0600A422 RID: 42018 RVA: 0x01294354 File Offset: 0x01292554
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (158549 - 437258 != -278709)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (271756 - 142471 != 129286)
			{
				hashtable.Add(71, CID);
				if (48766 - 597818 != -549051)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (29183 - 512888 == -483705)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (98343 - 265351 == -167008)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (71379 - 126326 != -54946)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (132215 - 10900 == 121315)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (193903 - 158746 != 35158)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (22740 - 2875 != 19866)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (181423 - 427918 == -246495)
											{
												this.sVUn6Tu1vYd.OpCustom(61, hashtable, true);
												if (222563 - 386561 != -163997)
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

	// Token: 0x0600A423 RID: 42019 RVA: 0x012945E0 File Offset: 0x012927E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (48851 - 330996 != -282145)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (58390 - 235427 != -177036)
			{
				if (!gameObject)
				{
					break;
				}
				if (56362 - 368586 != -312223)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (165308 - 284181 != -118872)
					{
						playerCameraControl.target = gameObject;
						if (176619 - 364983 == -188364)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (295350 - 496039 == -200689)
								{
									this.StartGame();
									if (93922 - 554218 == -460296)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (269794 - 358953 != -89158)
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

	// Token: 0x0600A424 RID: 42020 RVA: 0x0129471C File Offset: 0x0129291C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (157201 - 228385 != -71184)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (172994 - 145163 != 27832)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (233730 - 405889 == -172159)
				{
					gameGui.ResetTeamBar();
					if (20041 - 185583 == -165542)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A425 RID: 42021 RVA: 0x012947C8 File Offset: 0x012929C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M936_CrossingDestiny1.$onDeadPlayer$43916(this).GetEnumerator();
	}

	// Token: 0x0600A426 RID: 42022 RVA: 0x012947D8 File Offset: 0x012929D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (290991 - 58525 != 232467)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (9270 - 296939 == -287669)
			{
				this.v3yn6YqG3If.target = Game.mPlayer;
				if (138684 - 131831 == 6853)
				{
					this.v3yn6YqG3If.enabled = true;
					if (187923 - 246427 == -58504)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (115083 - 76976 != 38107)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (29438 - 510160 == -480721)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (99583 - 439376 != -339792)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (179337 - 72763 != 106575)
							{
								if (!gameGui)
								{
									break;
								}
								if (226898 - 70693 != 156206)
								{
									gameGui.enabled = true;
									if (234365 - 569040 != -334674)
									{
										gameGui.closeDeadMenu();
										if (293897 - 496789 == -202892)
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

	// Token: 0x0600A427 RID: 42023 RVA: 0x01294984 File Offset: 0x01292B84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (90216 - 423460 != -333244)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (81568 - 544512 == -462944)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (265466 - 298938 != -33471)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (103295 - 311365 != -208069)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A428 RID: 42024 RVA: 0x01294A48 File Offset: 0x01292C48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A429 RID: 42025 RVA: 0x01294A74 File Offset: 0x01292C74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (225024 - 362735 != -137711)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (115603 - 321671 == -206068)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (110077 - 40087 != 69991)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (279613 - 462243 != -182629)
					{
						Hashtable hashtable = new Hashtable();
						if (215728 - 309766 != -94037)
						{
							hashtable.Add(43, PlayerData.UID);
							if (289853 - 587927 == -298074)
							{
								hashtable.Add(71, nCID);
								if (294267 - 415940 != -121672)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (75193 - 235440 == -160247)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (34066 - 29957 != 4110)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (103289 - 498468 == -395179)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (75499 - 16564 == 58935)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (271159 - 483916 == -212757)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (184533 - 238218 != -53684)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (264896 - 453132 != -188235)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (68110 - 311788 == -243678)
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

	// Token: 0x0600A42A RID: 42026 RVA: 0x01294D94 File Offset: 0x01292F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M936_CrossingDestiny1.$onChangePlayer$43922(data, this).GetEnumerator();
	}

	// Token: 0x0600A42B RID: 42027 RVA: 0x01294DA4 File Offset: 0x01292FA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (237293 - 463352 != -226059)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (258183 - 588518 != -330334)
			{
				Time.timeScale = 1f;
				if (141857 - 83587 == 58270)
				{
					Hashtable customOpParameters = new Hashtable();
					if (214252 - 389101 != -174848)
					{
						this.sVUn6Tu1vYd.OpCustom(52, customOpParameters, true);
						if (129629 - 286997 == -157368)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A42C RID: 42028 RVA: 0x01294E70 File Offset: 0x01293070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (80022 - 554065 != -474042)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (1294 - 30332 == -29038)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (239618 - 58737 == 180881)
				{
					Game.mGameState = eGameState.Setup;
					if (81107 - 155116 == -74009)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A42D RID: 42029 RVA: 0x01294F14 File Offset: 0x01293114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (297380 - 290241 != 7140)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (73187 - 515990 != -442802)
			{
				if (num == PlayerData.UID)
				{
					if (130588 - 564332 != -433743)
					{
						this.SetupActors();
						if (272555 - 589943 != -317387)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (41581 - 257835 != -216253)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A42E RID: 42030 RVA: 0x01294FE4 File Offset: 0x012931E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (143981 - 240699 != -96717)
		{
		}
		for (;;)
		{
			IL_2B2:
			Debug.Log("Creating Actors");
			if (72805 - 408647 == -335842)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (101966 - 253551 != -151584)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (197702 - 544072 != -346369)
						{
							int i = 0;
							if (244523 - 523273 == -278750)
							{
								CharacterControl[] array2 = array;
								if (4455 - 348255 != -343799)
								{
									int length = array2.Length;
									if (103592 - 117234 != -13641)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (211462 - 518991 == -307528)
												{
													goto IL_2B2;
												}
												string type = array2[i].Type;
												if (85971 - 251587 != -165616)
												{
													goto IL_2B2;
												}
												if (type == "Leopard")
												{
													goto IL_125;
												}
												if (218365 - 49318 != 169047)
												{
													goto IL_2B2;
												}
												if (type == "Panther")
												{
													goto IL_125;
												}
												if (97334 - 216868 != -119534)
												{
													goto IL_2B2;
												}
												if (type == "CamBot")
												{
													goto IL_125;
												}
												if (77442 - 244923 == -167480)
												{
													goto IL_2B2;
												}
												if (type == "CarryBot")
												{
													goto IL_125;
												}
												if (202487 - 155618 == 46870)
												{
													goto IL_2B2;
												}
												if (type == "CutBot")
												{
													goto IL_125;
												}
												if (3620 - 529584 == -525963)
												{
													goto IL_2B2;
												}
												if (type == "SiegeBot")
												{
													if (130628 - 511710 != -381082)
													{
														goto IL_2B2;
													}
													goto IL_125;
												}
												IL_26E:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (195031 - 159838 == 35194)
												{
													goto IL_2B2;
												}
												this.J82n6aS7oJM++;
												if (135644 - 447522 != -311878)
												{
													goto IL_2B2;
												}
												goto IL_21C;
												IL_125:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (220513 - 44527 != 175986)
												{
													goto IL_2B2;
												}
												goto IL_26E;
											}
											IL_21C:
											i++;
											if (20792 - 369684 == -348891)
											{
												goto IL_2B2;
											}
										}
										if (207710 - 194594 == 13116)
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
						if (183736 - 498524 != -314787)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A42F RID: 42031 RVA: 0x01295354 File Offset: 0x01293554
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (45320 - 207765 != -162445)
		{
		}
		for (;;)
		{
			IL_3C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (90163 - 20650 == 69513)
			{
				int i = 0;
				if (248829 - 64494 != 184336)
				{
					CharacterControl[] array2 = array;
					if (68011 - 157991 != -89979)
					{
						int length = array2.Length;
						if (269091 - 347094 != -78002)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (76330 - 212298 != -135968)
								{
									goto IL_3C;
								}
								i++;
								if (95846 - 12998 == 82849)
								{
									goto IL_3C;
								}
							}
							if (223137 - 378576 == -155439)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A430 RID: 42032 RVA: 0x01295484 File Offset: 0x01293684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (98471 - 434318 != -335847)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (150626 - 561113 == -410487)
			{
				Game.mGameState = eGameState.Start;
				if (145923 - 439437 != -293513)
				{
					Game.mGameTime = Time.time;
					if (230702 - 345102 != -114399)
					{
						Game.mStateTime = Time.time;
						if (58840 - 61965 == -3125)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (127549 - 565231 != -437681)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A431 RID: 42033 RVA: 0x01295570 File Offset: 0x01293770
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A432 RID: 42034 RVA: 0x01295574 File Offset: 0x01293774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M936_CrossingDestiny1.$onGameComplete$43929(data, this).GetEnumerator();
	}

	// Token: 0x0600A433 RID: 42035 RVA: 0x01295584 File Offset: 0x01293784
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M936_CrossingDestiny1.$ReturnToTown$43939(this).GetEnumerator();
	}

	// Token: 0x0600A434 RID: 42036 RVA: 0x01295594 File Offset: 0x01293794
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M936_CrossingDestiny1.$ReturnToGuild$43944(this).GetEnumerator();
	}

	// Token: 0x0600A435 RID: 42037 RVA: 0x012955A4 File Offset: 0x012937A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M936_CrossingDestiny1.$ReturnToCamp$43948(this).GetEnumerator();
	}

	// Token: 0x0600A436 RID: 42038 RVA: 0x012955B4 File Offset: 0x012937B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (185402 - 308083 != -122680)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (115834 - 195400 == -79566)
			{
				Hashtable hashtable = new Hashtable();
				if (18541 - 408283 != -389741)
				{
					hashtable.Add(43, PlayerData.UID);
					if (28356 - 307320 != -278963)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (223602 - 118530 == 105072)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A437 RID: 42039 RVA: 0x0129568C File Offset: 0x0129388C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A438 RID: 42040 RVA: 0x012956A0 File Offset: 0x012938A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (82840 - 82402 != 439)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (138528 - 424681 != -286152)
			{
				Hashtable hashtable = new Hashtable();
				if (127141 - 425073 == -297932)
				{
					if (Game.mNextGameCode == 30)
					{
						if (114819 - 598479 != -483660)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (16792 - 440530 != -423738)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (85132 - 538489 != -453357)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (269698 - 309412 != -39714)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (33552 - 509081 == -475528)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (194557 - 429781 == -235223)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (144894 - 566911 != -422017)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (242577 - 339634 != -97057)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (172388 - 384004 == -211615)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (280451 - 402292 == -121840)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (259144 - 445863 != -186719)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (28408 - 494660 == -466251)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (126027 - 366928 != -240901)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (266720 - 489063 == -222342)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (72853 - 30541 == 42313)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (129079 - 18803 != 110276)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (40525 - 231498 == -190972)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (224832 - 123777 == 101056)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (42318 - 150751 == -108432)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (183112 - 218230 == -35117)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (180784 - 25651 != 155133)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (234927 - 272076 != -37149)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (92886 - 150772 != -57886)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (135891 - 91241 != 44650)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (111801 - 308819 != -197018)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (157200 - 531547 != -374347)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (3004 - 379863 == -376858)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (13468 - 322518 == -309049)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (90435 - 429457 == -339022)
					{
						this.sVUn6Tu1vYd.OpCustom(42, hashtable, true);
						if (261885 - 567691 == -305806)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A439 RID: 42041 RVA: 0x01295C54 File Offset: 0x01293E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A43A RID: 42042 RVA: 0x01295C64 File Offset: 0x01293E64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A43B RID: 42043 RVA: 0x01295C68 File Offset: 0x01293E68
	internal static bool mvHSPEVJDy2rl2wjEIM5()
	{
		return true;
	}

	// Token: 0x0600A43C RID: 42044 RVA: 0x01295C6C File Offset: 0x01293E6C
	internal static bool sBqw34VJvGuOQDs6Kxhu()
	{
		return false;
	}

	// Token: 0x04009366 RID: 37734
	private LitePeer sVUn6Tu1vYd;

	// Token: 0x04009367 RID: 37735
	private PlayerCameraControl v3yn6YqG3If;

	// Token: 0x04009368 RID: 37736
	private float tkLn63KUqca;

	// Token: 0x04009369 RID: 37737
	private Texture lf0n6bmbEA4;

	// Token: 0x0400936A RID: 37738
	private AudioClip MKjn6d8TYCa;

	// Token: 0x0400936B RID: 37739
	private int k6wn6gbxxgi;

	// Token: 0x0400936C RID: 37740
	private int J82n6aS7oJM;

	// Token: 0x02001B74 RID: 7028
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$43900 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A43D RID: 42045 RVA: 0x01295C70 File Offset: 0x01293E70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$43900(Hashtable data, M936_CrossingDestiny1 self_)
		{
			if (126684 - 172143 != -45458)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292017 - 150645 != 141373)
				{
					base..ctor();
					if (20553 - 244842 == -224289)
					{
						this.$data$43908 = data;
						if (154280 - 519551 != -365270)
						{
							this.$self_$43909 = self_;
							if (141959 - 482577 != -340617)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A43E RID: 42046 RVA: 0x01295D2C File Offset: 0x01293F2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny1.$onGameEvent$43900.$(this.$data$43908, this.$self_$43909);
		}

		// Token: 0x0600A43F RID: 42047 RVA: 0x01295D40 File Offset: 0x01293F40
		internal static bool pudT0PVJRa4whKvE3qkH()
		{
			return true;
		}

		// Token: 0x0600A440 RID: 42048 RVA: 0x01295D44 File Offset: 0x01293F44
		internal static bool we18vUVJw9oyid3oN6WJ()
		{
			return false;
		}

		// Token: 0x0400936D RID: 37741
		internal Hashtable $data$43908;

		// Token: 0x0400936E RID: 37742
		internal M936_CrossingDestiny1 $self_$43909;

		// Token: 0x02001B75 RID: 7029
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A441 RID: 42049 RVA: 0x01295D48 File Offset: 0x01293F48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M936_CrossingDestiny1 self_)
			{
				if (87608 - 243677 != -156068)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (213052 - 555706 == -342654)
					{
						base..ctor();
						if (67353 - 593373 != -526019)
						{
							this.$data$43906 = data;
							if (111920 - 407544 == -295624)
							{
								this.$self_$43907 = self_;
								if (211037 - 527923 != -316885)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A442 RID: 42050 RVA: 0x01295E04 File Offset: 0x01294004
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (33262 - 441159 != -407896)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3EE;
					case 2:
						Game.savePlayer();
						if (276791 - 270781 == 6011)
						{
							continue;
						}
						this.$self_$43907.SendMessage("fadeOut");
						if (287252 - 320124 != -32872)
						{
							continue;
						}
						goto IL_151;
					case 3:
						Game.mGameStage = 2;
						if (13250 - 16503 != -3253)
						{
							continue;
						}
						Application.LoadLevel("M936_CrossingDestiny2");
						if (263326 - 372613 != -109286)
						{
							goto IL_1A;
						}
						continue;
					default:
						if (279271 - 528391 != -249120)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (229687 - 193306 != 36381)
						{
							continue;
						}
						goto IL_312;
					}
					else
					{
						this.$returnCode$43901 = RuntimeServices.UnboxInt32(this.$data$43906[141]);
						if (20337 - 104836 == -84498)
						{
							continue;
						}
						this.$returnValue$43902 = RuntimeServices.UnboxInt32(this.$data$43906[145]);
						if (181121 - 216057 != -34936)
						{
							continue;
						}
						this.$ownerID$43903 = RuntimeServices.UnboxInt32(this.$data$43906[43]);
						if (207304 - 222660 != -15356)
						{
							continue;
						}
						this.$$switch$8075$43904 = this.$returnCode$43901;
						if (274496 - 248133 == 26364)
						{
							continue;
						}
						if (this.$$switch$8075$43904 == 9361)
						{
							if (202163 - 379759 == -177595)
							{
								continue;
							}
						}
						else if (this.$$switch$8075$43904 == -9361)
						{
							if (261367 - 244911 == 16457)
							{
								continue;
							}
							if (this.$returnValue$43902 == 2)
							{
								if (42183 - 431807 != -389624)
								{
									continue;
								}
								if (this.$self_$43907.k6wn6gbxxgi < 2)
								{
									if (283281 - 101393 == 181889)
									{
										continue;
									}
									this.$self_$43907.k6wn6gbxxgi = 2;
									if (294710 - 502070 == -207359)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (162704 - 347348 != -184644)
									{
										continue;
									}
									this.$self_$43907.v3yn6YqG3If.StartCoroutine_Auto(this.$self_$43907.v3yn6YqG3If.slerpToObject("ExitCamera1", (float)2));
									if (13806 - 136687 != -122881)
									{
										continue;
									}
									this.$mGameGui$43905 = (GameGui)this.$self_$43907.GetComponent(typeof(GameGui));
									if (114395 - 198067 == -83671)
									{
										continue;
									}
									this.$mGameGui$43905.close();
									if (203056 - 140856 != 62200)
									{
										continue;
									}
									goto IL_1AA;
								}
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$43901);
							if (168336 - 482275 != -313939)
							{
								continue;
							}
						}
					}
					IL_1E1:
					this.YieldDefault(1);
					if (101085 - 574808 != -473723)
					{
						continue;
					}
					goto IL_3EE;
					IL_1A:
					goto IL_1E1;
				}
				IL_151:
				return this.Yield(3, new WaitForSeconds((float)1));
				IL_1AA:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_312:
				IL_3EE:
				return false;
			}

			// Token: 0x0600A443 RID: 42051 RVA: 0x01296214 File Offset: 0x01294414
			internal static bool wiPvCdVJqXdi8KvcqmUi()
			{
				return true;
			}

			// Token: 0x0600A444 RID: 42052 RVA: 0x01296218 File Offset: 0x01294418
			internal static bool XGeBmvVJ7K5c8vSsMW1V()
			{
				return false;
			}

			// Token: 0x0400936F RID: 37743
			internal int $returnCode$43901;

			// Token: 0x04009370 RID: 37744
			internal int $returnValue$43902;

			// Token: 0x04009371 RID: 37745
			internal int $ownerID$43903;

			// Token: 0x04009372 RID: 37746
			internal int $$switch$8075$43904;

			// Token: 0x04009373 RID: 37747
			internal GameGui $mGameGui$43905;

			// Token: 0x04009374 RID: 37748
			internal Hashtable $data$43906;

			// Token: 0x04009375 RID: 37749
			internal M936_CrossingDestiny1 $self_$43907;
		}
	}

	// Token: 0x02001B76 RID: 7030
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43910 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A445 RID: 42053 RVA: 0x0129621C File Offset: 0x0129441C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43910(M936_CrossingDestiny1 self_)
		{
			if (88532 - 552390 != -463857)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (161123 - 382471 != -221347)
				{
					base..ctor();
					if (124942 - 29431 != 95512)
					{
						this.$self_$43915 = self_;
						if (174814 - 35966 != 138849)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A446 RID: 42054 RVA: 0x012962B4 File Offset: 0x012944B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny1.$StartEvent$43910.$(this.$self_$43915);
		}

		// Token: 0x0600A447 RID: 42055 RVA: 0x012962C4 File Offset: 0x012944C4
		internal static bool QtXEGAVJPGIZOAVatoCU()
		{
			return true;
		}

		// Token: 0x0600A448 RID: 42056 RVA: 0x012962C8 File Offset: 0x012944C8
		internal static bool lR9NYTVJ0eS8AQdJdgpE()
		{
			return false;
		}

		// Token: 0x04009376 RID: 37750
		internal M936_CrossingDestiny1 $self_$43915;

		// Token: 0x02001B77 RID: 7031
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A449 RID: 42057 RVA: 0x012962CC File Offset: 0x012944CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny1 self_)
			{
				if (235151 - 309574 != -74423)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (58025 - 424508 != -366482)
					{
						base..ctor();
						if (240940 - 533566 == -292626)
						{
							this.$self_$43914 = self_;
							if (18564 - 37558 == -18994)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A44A RID: 42058 RVA: 0x01296364 File Offset: 0x01294564
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (251489 - 103999 != 147491)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2E9;
					case 1:
						goto IL_671;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (107203 - 126232 != -19029)
							{
								continue;
							}
							goto IL_363;
						}
						else
						{
							this.$mStoryGui$43911 = (StoryGui)this.$self_$43914.GetComponent(typeof(StoryGui));
							if (154564 - 127 == 154438)
							{
								continue;
							}
							this.$mStoryTimer$43912 = 0f;
							if (162589 - 78594 != 83995)
							{
								continue;
							}
							if (!this.$mStoryGui$43911)
							{
								if (206252 - 473127 != -266874)
								{
									goto Block_9;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$43911.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
								if (14716 - 431566 != -416850)
								{
									continue;
								}
								goto IL_454;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (295067 - 303969 != -8902)
							{
								continue;
							}
							goto IL_4DA;
						}
						else
						{
							this.$mStoryGui$43911.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M936_CrossingDestiny", 101), eTalkType.friend);
							if (158884 - 107922 == 50963)
							{
								continue;
							}
							this.$mStoryTimer$43912 = Time.time + 3f;
							if (139793 - 201584 != -61790)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 4:
						break;
					case 5:
						break;
					case 6:
						goto IL_27D;
					case 7:
						goto IL_27D;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (161087 - 332758 != -171670)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							this.$mGameGui$43913 = (GameGui)this.$self_$43914.GetComponent(typeof(GameGui));
							if (125355 - 196458 == -71102)
							{
								continue;
							}
							this.$mGameGui$43913.enabled = true;
							if (102156 - 596059 == -493902)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (47534 - 69048 == -21513)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (250081 - 292712 == -42630)
							{
								continue;
							}
							if (this.$self_$43914.MKjn6d8TYCa)
							{
								if (38906 - 478188 != -439282)
								{
									continue;
								}
								this.$self_$43914.audio.PlayOneShot(this.$self_$43914.MKjn6d8TYCa);
								if (70435 - 312817 != -242382)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (109821 - 430216 != -320394)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					default:
						if (298630 - 596273 != -297642)
						{
							goto IL_2E9;
						}
						continue;
					}
					if (this.$mStoryTimer$43912 > Time.time)
					{
						if (158740 - 382425 == -223684)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1FA;
						}
						if (291776 - 500413 != -208637)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (53944 - 28739 != 25206)
						{
							goto Block_38;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43911.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M936_CrossingDestiny", 102), eTalkType.friend);
						if (5161 - 244535 != -239374)
						{
							continue;
						}
						this.$mStoryTimer$43912 = Time.time + 3f;
						if (152825 - 439563 != -286737)
						{
							break;
						}
						continue;
					}
					IL_27D:
					if (this.$mStoryTimer$43912 > Time.time)
					{
						if (90240 - 314985 == -224744)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_271;
						}
						if (98720 - 46832 == 51889)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (291982 - 156618 != 135364)
						{
							continue;
						}
						goto IL_5A4;
					}
					else
					{
						this.$mStoryGui$43911.close();
						if (18917 - 406728 != -387811)
						{
							continue;
						}
						this.$self_$43914.v3yn6YqG3If.enabled = true;
						if (213236 - 301531 != -88294)
						{
							goto Block_23;
						}
						continue;
					}
					IL_2E9:
					Game.mGameState = eGameState.Start;
					if (165905 - 499843 != -333937)
					{
						Game.mStateTime = Time.time;
						if (127021 - 272737 != -145715)
						{
							this.$self_$43914.v3yn6YqG3If.alignToObject("EventCamera1");
							if (143186 - 124738 == 18448)
							{
								this.$self_$43914.v3yn6YqG3If.StartCoroutine_Auto(this.$self_$43914.v3yn6YqG3If.slerpToObject("EventCamera2", (float)2));
								if (222892 - 433971 == -211079)
								{
									this.$self_$43914.SendMessage("fadeIn");
									if (59671 - 41928 != 17744)
									{
										goto Block_36;
									}
								}
							}
						}
					}
				}
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_9:
				goto IL_671;
				IL_1FA:
				return this.YieldDefault(5);
				IL_271:
				return this.YieldDefault(7);
				Block_19:
				goto IL_671;
				Block_23:
				return this.Yield(8, new WaitForSeconds(1f));
				IL_363:
				goto IL_671;
				Block_28:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_454:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_4DA:
				goto IL_671;
				Block_36:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_38:
				IL_5A4:
				Block_43:
				IL_671:
				return false;
			}

			// Token: 0x0600A44B RID: 42059 RVA: 0x012969F4 File Offset: 0x01294BF4
			internal static bool QBE3TAVJbwm7QluSmZQ3()
			{
				return true;
			}

			// Token: 0x0600A44C RID: 42060 RVA: 0x012969F8 File Offset: 0x01294BF8
			internal static bool aWoVeHVJu9EYL5bCLoEW()
			{
				return false;
			}

			// Token: 0x04009377 RID: 37751
			internal StoryGui $mStoryGui$43911;

			// Token: 0x04009378 RID: 37752
			internal float $mStoryTimer$43912;

			// Token: 0x04009379 RID: 37753
			internal GameGui $mGameGui$43913;

			// Token: 0x0400937A RID: 37754
			internal M936_CrossingDestiny1 $self_$43914;
		}
	}

	// Token: 0x02001B78 RID: 7032
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43916 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A44D RID: 42061 RVA: 0x012969FC File Offset: 0x01294BFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43916(M936_CrossingDestiny1 self_)
		{
			if (168550 - 49775 != 118775)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (92319 - 237234 != -144914)
				{
					base..ctor();
					if (48502 - 218405 == -169903)
					{
						this.$self_$43921 = self_;
						if (126478 - 207398 == -80920)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A44E RID: 42062 RVA: 0x01296A94 File Offset: 0x01294C94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny1.$onDeadPlayer$43916.$(this.$self_$43921);
		}

		// Token: 0x0600A44F RID: 42063 RVA: 0x01296AA4 File Offset: 0x01294CA4
		internal static bool UftbcLVJI76wBAxEftD8()
		{
			return true;
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x01296AA8 File Offset: 0x01294CA8
		internal static bool E61YO5VJBw5aMTnE021Z()
		{
			return false;
		}

		// Token: 0x0400937B RID: 37755
		internal M936_CrossingDestiny1 $self_$43921;

		// Token: 0x02001B79 RID: 7033
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A451 RID: 42065 RVA: 0x01296AAC File Offset: 0x01294CAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny1 self_)
			{
				if (175636 - 538744 != -363108)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (22410 - 313581 == -291171)
					{
						base..ctor();
						if (93904 - 449360 == -355456)
						{
							this.$self_$43920 = self_;
							if (109583 - 8613 != 100971)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A452 RID: 42066 RVA: 0x01296B44 File Offset: 0x01294D44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (140625 - 253336 != -112710)
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
						if (Game.mGameState != eGameState.Normal)
						{
							if (275157 - 3072 != 272085)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_103;
							}
							if (79415 - 453421 != -374006)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (197790 - 485560 != -287770)
						{
							continue;
						}
						this.$mStoryGui$43917 = (StoryGui)this.$self_$43920.GetComponent(typeof(StoryGui));
						if (77693 - 501502 != -423809)
						{
							continue;
						}
						if (this.$mStoryGui$43917)
						{
							if (22424 - 120296 == -97871)
							{
								continue;
							}
							this.$mStoryGui$43917.close();
							if (295116 - 592921 == -297804)
							{
								continue;
							}
						}
						this.$mChangeGui$43918 = (ChangeGui)this.$self_$43920.GetComponent(typeof(ChangeGui));
						if (152084 - 493413 == -341328)
						{
							continue;
						}
						if (this.$mChangeGui$43918)
						{
							if (193764 - 74958 != 118806)
							{
								continue;
							}
							this.$mChangeGui$43918.close();
							if (130695 - 19966 != 110729)
							{
								continue;
							}
						}
						this.$mGameGui$43919 = (GameGui)this.$self_$43920.GetComponent(typeof(GameGui));
						if (150547 - 507568 != -357021)
						{
							continue;
						}
						if (this.$mGameGui$43919)
						{
							if (257527 - 539749 != -282222)
							{
								continue;
							}
							if (!this.$mGameGui$43919.enabled)
							{
								if (247726 - 16777 != 230949)
								{
									continue;
								}
								this.$mGameGui$43919.enabled = true;
								if (107957 - 397268 != -289311)
								{
									continue;
								}
							}
							this.$mGameGui$43919.openDeadMenu();
							if (72350 - 368416 != -296066)
							{
								continue;
							}
						}
						IL_103:
						this.YieldDefault(1);
						if (246872 - 14851 != 232022)
						{
							goto Block_8;
						}
						continue;
					default:
						if (299060 - 316508 != -17448)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (36468 - 274161 != -237692)
					{
						goto Block_23;
					}
				}
				Block_8:
				goto IL_2F9;
				Block_23:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600A453 RID: 42067 RVA: 0x01296E5C File Offset: 0x0129505C
			internal static bool SqNtjPVJey8jvWUniVXT()
			{
				return true;
			}

			// Token: 0x0600A454 RID: 42068 RVA: 0x01296E60 File Offset: 0x01295060
			internal static bool vckAuIVJr1uJBr19ttLA()
			{
				return false;
			}

			// Token: 0x0400937C RID: 37756
			internal StoryGui $mStoryGui$43917;

			// Token: 0x0400937D RID: 37757
			internal ChangeGui $mChangeGui$43918;

			// Token: 0x0400937E RID: 37758
			internal GameGui $mGameGui$43919;

			// Token: 0x0400937F RID: 37759
			internal M936_CrossingDestiny1 $self_$43920;
		}
	}

	// Token: 0x02001B7A RID: 7034
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43922 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A455 RID: 42069 RVA: 0x01296E64 File Offset: 0x01295064
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43922(Hashtable data, M936_CrossingDestiny1 self_)
		{
			if (192106 - 133817 != 58290)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (23286 - 456479 == -433193)
				{
					base..ctor();
					if (193579 - 151354 != 42226)
					{
						this.$data$43927 = data;
						if (122586 - 182189 == -59603)
						{
							this.$self_$43928 = self_;
							if (34864 - 411588 == -376724)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A456 RID: 42070 RVA: 0x01296F20 File Offset: 0x01295120
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny1.$onChangePlayer$43922.$(this.$data$43927, this.$self_$43928);
		}

		// Token: 0x0600A457 RID: 42071 RVA: 0x01296F34 File Offset: 0x01295134
		internal static bool qqXflhVJj1PHakIHoGsp()
		{
			return true;
		}

		// Token: 0x0600A458 RID: 42072 RVA: 0x01296F38 File Offset: 0x01295138
		internal static bool kq7WKDVJhpLr21TyPklk()
		{
			return false;
		}

		// Token: 0x04009380 RID: 37760
		internal Hashtable $data$43927;

		// Token: 0x04009381 RID: 37761
		internal M936_CrossingDestiny1 $self_$43928;

		// Token: 0x02001B7B RID: 7035
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A459 RID: 42073 RVA: 0x01296F3C File Offset: 0x0129513C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M936_CrossingDestiny1 self_)
			{
				if (21732 - 337736 != -316003)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (254924 - 356186 != -101261)
					{
						base..ctor();
						if (192418 - 122277 == 70141)
						{
							this.$data$43925 = data;
							if (288095 - 456402 != -168306)
							{
								this.$self_$43926 = self_;
								if (88518 - 12967 == 75551)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A45A RID: 42074 RVA: 0x01296FF8 File Offset: 0x012951F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79540 - 579136 != -499595)
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
							if (15223 - 8558 == 6666)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (213934 - 204605 == 9330)
							{
								continue;
							}
							this.$mGameGui$43924 = (GameGui)this.$self_$43926.GetComponent(typeof(GameGui));
							if (134330 - 419509 == -285178)
							{
								continue;
							}
							this.$mGameGui$43924.enabled = true;
							if (242749 - 438886 != -196137)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (72785 - 519972 != -447187)
						{
							continue;
						}
						goto IL_205;
					default:
						if (256434 - 241630 == 14805)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (291285 - 437177 != -145891)
					{
						this.$self_$43926.SendMessage("onCreatePlayer", this.$data$43925);
						if (255498 - 379929 != -124430)
						{
							this.$mChangeGui$43923 = (ChangeGui)this.$self_$43926.GetComponent(typeof(ChangeGui));
							if (152481 - 253960 != -101478)
							{
								if (!this.$mChangeGui$43923.enabled)
								{
									break;
								}
								if (243709 - 444747 != -201037)
								{
									this.$mChangeGui$43923.close();
									if (264541 - 347368 != -82826)
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

			// Token: 0x0600A45B RID: 42075 RVA: 0x0129721C File Offset: 0x0129541C
			internal static bool qPJGicVJsq9HREIfH228()
			{
				return true;
			}

			// Token: 0x0600A45C RID: 42076 RVA: 0x01297220 File Offset: 0x01295420
			internal static bool SxO5lPVJ9D6fcgmlqRTJ()
			{
				return false;
			}

			// Token: 0x04009382 RID: 37762
			internal ChangeGui $mChangeGui$43923;

			// Token: 0x04009383 RID: 37763
			internal GameGui $mGameGui$43924;

			// Token: 0x04009384 RID: 37764
			internal Hashtable $data$43925;

			// Token: 0x04009385 RID: 37765
			internal M936_CrossingDestiny1 $self_$43926;
		}
	}

	// Token: 0x02001B7C RID: 7036
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43929 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A45D RID: 42077 RVA: 0x01297224 File Offset: 0x01295424
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43929(Hashtable data, M936_CrossingDestiny1 self_)
		{
			if (156115 - 554120 != -398004)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (276655 - 503679 != -227023)
				{
					base..ctor();
					if (230926 - 326772 != -95845)
					{
						this.$data$43937 = data;
						if (142988 - 474066 != -331077)
						{
							this.$self_$43938 = self_;
							if (107014 - 7595 != 99420)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A45E RID: 42078 RVA: 0x012972E0 File Offset: 0x012954E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny1.$onGameComplete$43929.$(this.$data$43937, this.$self_$43938);
		}

		// Token: 0x0600A45F RID: 42079 RVA: 0x012972F4 File Offset: 0x012954F4
		internal static bool tVDAdcVJ12HgLmiMYMEY()
		{
			return true;
		}

		// Token: 0x0600A460 RID: 42080 RVA: 0x012972F8 File Offset: 0x012954F8
		internal static bool RHj9NoVJ4CYDorFaGYgq()
		{
			return false;
		}

		// Token: 0x04009386 RID: 37766
		internal Hashtable $data$43937;

		// Token: 0x04009387 RID: 37767
		internal M936_CrossingDestiny1 $self_$43938;

		// Token: 0x02001B7D RID: 7037
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A461 RID: 42081 RVA: 0x012972FC File Offset: 0x012954FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M936_CrossingDestiny1 self_)
			{
				if (82717 - 599366 != -516648)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (8606 - 559430 != -550823)
					{
						base..ctor();
						if (264275 - 90710 == 173565)
						{
							this.$data$43935 = data;
							if (103323 - 391199 != -287875)
							{
								this.$self_$43936 = self_;
								if (250461 - 503706 != -253244)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A462 RID: 42082 RVA: 0x012973B8 File Offset: 0x012955B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (217909 - 405770 != -187861)
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
						this.$mCompleteGui$43931 = (CompleteGui)this.$self_$43936.GetComponent(typeof(CompleteGui));
						if (185255 - 201848 == -16592)
						{
							continue;
						}
						this.$mCompleteGui$43931.Init();
						if (146882 - 181563 != -34681)
						{
							continue;
						}
						this.$mCompleteGui$43931.readData(this.$data$43935);
						if (208264 - 286586 != -78322)
						{
							continue;
						}
						if (this.$result$43930 == 1)
						{
							if (15768 - 291504 != -275736)
							{
								continue;
							}
							this.$mCompleteGui$43931.displayResult(eCompleteType.Success);
							if (57286 - 360210 == -302923)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43931.displayResult(eCompleteType.Failed);
							if (231891 - 541857 != -309966)
							{
								continue;
							}
						}
						this.$mGameGui$43932 = (GameGui)this.$self_$43936.GetComponent(typeof(GameGui));
						if (297256 - 117898 != 179358)
						{
							continue;
						}
						this.$mStoryGui$43933 = (StoryGui)this.$self_$43936.GetComponent(typeof(StoryGui));
						if (224934 - 17658 == 207277)
						{
							continue;
						}
						this.$mChangeGui$43934 = (ChangeGui)this.$self_$43936.GetComponent(typeof(ChangeGui));
						if (165097 - 449128 == -284030)
						{
							continue;
						}
						if (this.$mGameGui$43932)
						{
							if (83280 - 512982 != -429702)
							{
								continue;
							}
							this.$mGameGui$43932.close();
							if (8090 - 468310 == -460219)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43933)
						{
							if (141662 - 161425 != -19763)
							{
								continue;
							}
							this.$mStoryGui$43933.close();
							if (267498 - 319009 == -51510)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43934)
						{
							if (195372 - 230044 == -34671)
							{
								continue;
							}
							this.$mChangeGui$43934.disable();
							if (202924 - 425869 == -222944)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (39398 - 452278 != -412880)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (193660 - 311917 != -118257)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43935[31]);
					if (32571 - 421125 != -388553)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (228937 - 307649 == -78712)
							{
								goto IL_1DC;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (116755 - 157008 != -40252)
							{
								this.$result$43930 = RuntimeServices.UnboxInt32(this.$data$43935[31]);
								if (172024 - 591635 == -419611)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_1DC:
				IL_3DB:
				return false;
			}

			// Token: 0x0600A463 RID: 42083 RVA: 0x012977B4 File Offset: 0x012959B4
			internal static bool stxmGUVJzPo1w8y7IWOb()
			{
				return true;
			}

			// Token: 0x0600A464 RID: 42084 RVA: 0x012977B8 File Offset: 0x012959B8
			internal static bool rKsGoUVDapHClG9fytYI()
			{
				return false;
			}

			// Token: 0x04009388 RID: 37768
			internal int $result$43930;

			// Token: 0x04009389 RID: 37769
			internal CompleteGui $mCompleteGui$43931;

			// Token: 0x0400938A RID: 37770
			internal GameGui $mGameGui$43932;

			// Token: 0x0400938B RID: 37771
			internal StoryGui $mStoryGui$43933;

			// Token: 0x0400938C RID: 37772
			internal ChangeGui $mChangeGui$43934;

			// Token: 0x0400938D RID: 37773
			internal Hashtable $data$43935;

			// Token: 0x0400938E RID: 37774
			internal M936_CrossingDestiny1 $self_$43936;
		}
	}

	// Token: 0x02001B7E RID: 7038
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43939 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A465 RID: 42085 RVA: 0x012977BC File Offset: 0x012959BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43939(M936_CrossingDestiny1 self_)
		{
			if (103248 - 556797 != -453549)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179352 - 53356 == 125996)
				{
					base..ctor();
					if (29999 - 529171 != -499171)
					{
						this.$self_$43943 = self_;
						if (169812 - 156680 == 13132)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A466 RID: 42086 RVA: 0x01297854 File Offset: 0x01295A54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny1.$ReturnToTown$43939.$(this.$self_$43943);
		}

		// Token: 0x0600A467 RID: 42087 RVA: 0x01297864 File Offset: 0x01295A64
		internal static bool NOwh2GVD5AHcnLDtVCJg()
		{
			return true;
		}

		// Token: 0x0600A468 RID: 42088 RVA: 0x01297868 File Offset: 0x01295A68
		internal static bool zGErYqVDpEHVpMEE7NwZ()
		{
			return false;
		}

		// Token: 0x0400938F RID: 37775
		internal M936_CrossingDestiny1 $self_$43943;

		// Token: 0x02001B7F RID: 7039
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A469 RID: 42089 RVA: 0x0129786C File Offset: 0x01295A6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny1 self_)
			{
				if (290717 - 257054 != 33663)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (183105 - 461072 == -277967)
					{
						base..ctor();
						if (222042 - 77571 == 144471)
						{
							this.$self_$43942 = self_;
							if (51350 - 207165 != -155814)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A46A RID: 42090 RVA: 0x01297904 File Offset: 0x01295B04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (117673 - 36447 != 81226)
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
						this.$self_$43942.LeaveGame();
						if (260752 - 114055 == 146698)
						{
							continue;
						}
						this.YieldDefault(1);
						if (115484 - 408001 != -292516)
						{
							goto Block_8;
						}
						continue;
					default:
						if (9405 - 144606 == -135200)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (31574 - 92221 != -60646)
					{
						Game.mStateTime = Time.time;
						if (221850 - 102946 == 118904)
						{
							this.$$switch$8081$43940 = PlayerData.SaveGuild;
							if (221644 - 303061 == -81417)
							{
								if (this.$$switch$8081$43940 == 1)
								{
									if (88202 - 562262 != -474060)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (48963 - 156355 == -107391)
									{
										continue;
									}
								}
								else if (this.$$switch$8081$43940 == 2)
								{
									if (169336 - 582220 != -412884)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (246922 - 156003 == 90920)
									{
										continue;
									}
								}
								else if (this.$$switch$8081$43940 == 3)
								{
									if (411 - 288026 != -287615)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (276618 - 83245 == 193374)
									{
										continue;
									}
								}
								else if (this.$$switch$8081$43940 == 4)
								{
									if (16458 - 305292 == -288833)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (155092 - 491033 != -335941)
									{
										continue;
									}
								}
								else if (this.$$switch$8081$43940 == 5)
								{
									if (275612 - 405123 == -129510)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (151577 - 544564 == -392986)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (127707 - 97035 != 30672)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (123809 - 500012 == -376202)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (161540 - 498328 != -336788)
									{
										continue;
									}
								}
								this.$mGameGui$43941 = (GameGui)this.$self_$43942.GetComponent(typeof(GameGui));
								if (262291 - 371445 == -109154)
								{
									if (this.$mGameGui$43941)
									{
										if (75581 - 28788 != 46793)
										{
											continue;
										}
										this.$mGameGui$43941.close();
										if (104142 - 559009 == -454866)
										{
											continue;
										}
									}
									this.$self_$43942.SendMessage("fadeOut");
									if (98398 - 590286 == -491888)
									{
										goto IL_13D;
									}
								}
							}
						}
					}
				}
				Block_8:
				goto IL_3AD;
				IL_13D:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600A46B RID: 42091 RVA: 0x01297CD0 File Offset: 0x01295ED0
			internal static bool EqPnYIVDVu4oAvZVEC8l()
			{
				return true;
			}

			// Token: 0x0600A46C RID: 42092 RVA: 0x01297CD4 File Offset: 0x01295ED4
			internal static bool Vlq2QxVDtCCTmRLwETjB()
			{
				return false;
			}

			// Token: 0x04009390 RID: 37776
			internal int $$switch$8081$43940;

			// Token: 0x04009391 RID: 37777
			internal GameGui $mGameGui$43941;

			// Token: 0x04009392 RID: 37778
			internal M936_CrossingDestiny1 $self_$43942;
		}
	}

	// Token: 0x02001B80 RID: 7040
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43944 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A46D RID: 42093 RVA: 0x01297CD8 File Offset: 0x01295ED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43944(M936_CrossingDestiny1 self_)
		{
			if (201121 - 513659 != -312537)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179208 - 486677 == -307469)
				{
					base..ctor();
					if (295559 - 2071 != 293489)
					{
						this.$self_$43947 = self_;
						if (137744 - 93524 == 44220)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A46E RID: 42094 RVA: 0x01297D70 File Offset: 0x01295F70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny1.$ReturnToGuild$43944.$(this.$self_$43947);
		}

		// Token: 0x0600A46F RID: 42095 RVA: 0x01297D80 File Offset: 0x01295F80
		internal static bool d56BYeVDNbxDAqnb7Ckq()
		{
			return true;
		}

		// Token: 0x0600A470 RID: 42096 RVA: 0x01297D84 File Offset: 0x01295F84
		internal static bool mwcIcSVDY7n6kawMecGE()
		{
			return false;
		}

		// Token: 0x04009393 RID: 37779
		internal M936_CrossingDestiny1 $self_$43947;

		// Token: 0x02001B81 RID: 7041
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A471 RID: 42097 RVA: 0x01297D88 File Offset: 0x01295F88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny1 self_)
			{
				if (13868 - 316381 != -302512)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (2714 - 385615 != -382900)
					{
						base..ctor();
						if (38760 - 399250 == -360490)
						{
							this.$self_$43946 = self_;
							if (132875 - 476408 != -343532)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A472 RID: 42098 RVA: 0x01297E20 File Offset: 0x01296020
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (269653 - 161603 != 108050)
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
						this.$self_$43946.LeaveGame();
						if (122760 - 96431 == 26330)
						{
							continue;
						}
						this.YieldDefault(1);
						if (64807 - 199808 != -135001)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (62949 - 17077 != 45872)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (116841 - 550433 == -433592)
					{
						Game.mStateTime = Time.time;
						if (123428 - 397582 == -274154)
						{
							Game.mNextGameCode = 31;
							if (34478 - 559431 == -524953)
							{
								this.$mGameGui$43945 = (GameGui)this.$self_$43946.GetComponent(typeof(GameGui));
								if (164137 - 563293 != -399155)
								{
									if (this.$mGameGui$43945)
									{
										if (87296 - 159802 != -72506)
										{
											continue;
										}
										this.$mGameGui$43945.close();
										if (195892 - 69770 == 126123)
										{
											continue;
										}
									}
									this.$self_$43946.SendMessage("fadeOut");
									if (184550 - 267157 != -82606)
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

			// Token: 0x0600A473 RID: 42099 RVA: 0x01297FFC File Offset: 0x012961FC
			internal static bool gAna37VDcI3yHbDtIXvT()
			{
				return true;
			}

			// Token: 0x0600A474 RID: 42100 RVA: 0x01298000 File Offset: 0x01296200
			internal static bool HlmhDoVDUpmQ5rKJluXl()
			{
				return false;
			}

			// Token: 0x04009394 RID: 37780
			internal GameGui $mGameGui$43945;

			// Token: 0x04009395 RID: 37781
			internal M936_CrossingDestiny1 $self_$43946;
		}
	}

	// Token: 0x02001B82 RID: 7042
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43948 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A475 RID: 42101 RVA: 0x01298004 File Offset: 0x01296204
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43948(M936_CrossingDestiny1 self_)
		{
			if (159422 - 476929 != -317507)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (1791 - 511429 == -509638)
				{
					base..ctor();
					if (14123 - 130500 == -116377)
					{
						this.$self_$43952 = self_;
						if (99063 - 121784 != -22720)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A476 RID: 42102 RVA: 0x0129809C File Offset: 0x0129629C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny1.$ReturnToCamp$43948.$(this.$self_$43952);
		}

		// Token: 0x0600A477 RID: 42103 RVA: 0x012980AC File Offset: 0x012962AC
		internal static bool INFO6HVDTY4hdnxPC83c()
		{
			return true;
		}

		// Token: 0x0600A478 RID: 42104 RVA: 0x012980B0 File Offset: 0x012962B0
		internal static bool A3hTd8VD31YX60t3b8X4()
		{
			return false;
		}

		// Token: 0x04009396 RID: 37782
		internal M936_CrossingDestiny1 $self_$43952;

		// Token: 0x02001B83 RID: 7043
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A479 RID: 42105 RVA: 0x012980B4 File Offset: 0x012962B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny1 self_)
			{
				if (133661 - 393446 != -259784)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (65560 - 115855 == -50295)
					{
						base..ctor();
						if (279185 - 202306 != 76880)
						{
							this.$self_$43951 = self_;
							if (276223 - 533896 != -257672)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A47A RID: 42106 RVA: 0x0129814C File Offset: 0x0129634C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (50354 - 450306 != -399951)
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
						this.$self_$43951.LeaveGame();
						if (131768 - 120344 == 11425)
						{
							continue;
						}
						this.YieldDefault(1);
						if (150050 - 288799 != -138748)
						{
							goto Block_9;
						}
						continue;
					default:
						if (76206 - 400938 != -324732)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (262943 - 362404 != -99460)
					{
						Game.mStateTime = Time.time;
						if (9906 - 560559 == -550653)
						{
							this.$$switch$8083$43949 = PlayerData.SaveGuild;
							if (215874 - 41662 != 174213)
							{
								if (this.$$switch$8083$43949 == 1)
								{
									if (245303 - 515496 != -270193)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (138528 - 144128 != -5600)
									{
										continue;
									}
								}
								else if (this.$$switch$8083$43949 == 2)
								{
									if (70052 - 531637 == -461584)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (66467 - 139618 == -73150)
									{
										continue;
									}
								}
								else if (this.$$switch$8083$43949 == 3)
								{
									if (232393 - 145973 == 86421)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (45187 - 359005 != -313818)
									{
										continue;
									}
								}
								else if (this.$$switch$8083$43949 == 4)
								{
									if (146897 - 77985 != 68912)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (168662 - 80519 != 88143)
									{
										continue;
									}
								}
								else if (this.$$switch$8083$43949 == 5)
								{
									if (210498 - 213459 == -2960)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (135331 - 453253 != -317922)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (8517 - 396839 == -388321)
									{
										continue;
									}
								}
								this.$mGameGui$43950 = (GameGui)this.$self_$43951.GetComponent(typeof(GameGui));
								if (86139 - 248754 != -162614)
								{
									if (this.$mGameGui$43950)
									{
										if (37746 - 231528 == -193781)
										{
											continue;
										}
										this.$mGameGui$43950.close();
										if (30918 - 354237 == -323318)
										{
											continue;
										}
									}
									this.$self_$43951.SendMessage("fadeOut");
									if (242073 - 466269 == -224196)
									{
										goto IL_149;
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_363;
				IL_149:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600A47B RID: 42107 RVA: 0x012984D0 File Offset: 0x012966D0
			internal static bool udEFQAVDXEYljAoLkvTu()
			{
				return true;
			}

			// Token: 0x0600A47C RID: 42108 RVA: 0x012984D4 File Offset: 0x012966D4
			internal static bool KpufGIVDQOx5iHyXK0WI()
			{
				return false;
			}

			// Token: 0x04009397 RID: 37783
			internal int $$switch$8083$43949;

			// Token: 0x04009398 RID: 37784
			internal GameGui $mGameGui$43950;

			// Token: 0x04009399 RID: 37785
			internal M936_CrossingDestiny1 $self_$43951;
		}
	}
}
