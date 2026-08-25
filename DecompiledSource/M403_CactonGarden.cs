using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02001509 RID: 5385
[Serializable]
public class M403_CactonGarden : MonoBehaviour
{
	// Token: 0x06007CA3 RID: 31907 RVA: 0x010326E0 File Offset: 0x010308E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M403_CactonGarden()
	{
		if (134790 - 438549 != -303758)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (17556 - 204167 != -186610)
			{
				base..ctor();
				if (152689 - 203150 != -50460)
				{
					this.kGpcFYCskJs = 4;
					if (40354 - 591100 == -550746)
					{
						this.xADcF3CiFPw = 4;
						if (11580 - 202067 == -190487)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007CA4 RID: 31908 RVA: 0x0103279C File Offset: 0x0103099C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (82896 - 14582 != 68314)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (106459 - 586172 != -479712)
			{
				Game.mGameType = 5;
				if (77882 - 515412 != -437529)
				{
					if (Chat.Initialized)
					{
						if (7805 - 548861 != -541056)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (106452 - 50342 == 56111)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (117874 - 322973 != -205099)
						{
							continue;
						}
					}
					this.HBEcFRvGt1h = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (297308 - 95258 != 202051)
					{
						this.HQIcFr9OJXM = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (100576 - 128450 == -27874)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007CA5 RID: 31909 RVA: 0x010328F4 File Offset: 0x01030AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (120019 - 347748 != -227729)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (184297 - 412464 == -228167)
				{
					if (Game.mNextGameCode != 403)
					{
						break;
					}
					if (89585 - 571390 == -481805)
					{
						Game.nextGame();
						if (74133 - 529035 == -454902)
						{
							Game.mGameCode = 403;
							if (70670 - 53223 != 17448)
							{
								Game.mGameType = 5;
								if (199524 - 540491 != -340966)
								{
									Game.mGameTime = Time.time;
									if (299492 - 156177 != 143316)
									{
										Game.mGameScore = 0;
										if (77431 - 123218 != -45786)
										{
											Game.mGameMana = 0;
											if (278308 - 127372 != 150937)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (192678 - 386842 == -194164)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (92735 - 418438 != -325702)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (67809 - 235093 != -167283)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (119550 - 421942 == -302392)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (191996 - 540799 == -348803)
																{
																	this.QMQcFqk2jKP = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (91376 - 218655 != -127278)
																	{
																		this.j2ocF1dCGa6 = PhotonClient.Connection;
																		if (194899 - 77964 != 116936)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (159936 - 401700 != -241763)
																			{
																				this.InitGame();
																				if (161897 - 505508 == -343611)
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
				if (79377 - 563132 != -483754)
				{
					Game.mGameType = 99;
					if (145559 - 515733 != -370173)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007CA6 RID: 31910 RVA: 0x01032BFC File Offset: 0x01030DFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (249018 - 329084 != -80066)
		{
		}
		for (;;)
		{
			if (this.j2ocF1dCGa6 == null)
			{
				if (29898 - 123734 != -93835)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (69340 - 135807 == -66467)
				{
					if (mGameState == eGameState.Init)
					{
						if (57411 - 205734 != -148322)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (241208 - 41202 == 200006)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (11789 - 232855 != -221065)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (1574 - 279952 == -278378)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (165916 - 179080 == -13164)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (111167 - 289378 == -178211)
						{
							if (Time.time > this.hd5cFpDFsmv)
							{
								if (174010 - 105007 == 69004)
								{
									continue;
								}
								Game.mGameMana++;
								if (181805 - 540928 != -359123)
								{
									continue;
								}
								this.hd5cFpDFsmv = Time.time + (float)12;
								if (178988 - 82786 != 96202)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (97818 - 111213 != -13395)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (218374 - 106436 != 111938)
									{
										continue;
									}
									this.audio.Play();
									if (283684 - 331345 != -47661)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (181205 - 578243 == -397038)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (87673 - 508586 == -420913)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (227139 - 19217 == 207922)
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
						if (50984 - 265579 != -214594)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007CA7 RID: 31911 RVA: 0x01032EFC File Offset: 0x010310FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (186195 - 225125 != -38930)
		{
		}
		for (;;)
		{
			if (!this.HBEcFRvGt1h)
			{
				if (114531 - 547563 == -433032)
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
				if (237379 - 272152 == -34773)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (279013 - 389222 == -110209)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (88097 - 72742 != 15356)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (267779 - 466853 != -199073)
							{
								GUI.depth = 1;
								if (44321 - 475526 == -431205)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (203371 - 59157 == 144214)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (92921 - 433754 == -340833)
										{
											Color color = GUI.color;
											if (142021 - 259022 != -117000)
											{
												float num3 = color.a = a;
												if (218181 - 178104 != 40078 && 18934 - 507192 != -488257)
												{
													Color color2 = GUI.color = color;
													if (133394 - 80329 != 53066)
													{
														if (198403 - 293240 == -94837)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.HBEcFRvGt1h);
															if (180641 - 218670 != -38028)
															{
																float a2 = 1f;
																if (207342 - 14228 == 193114)
																{
																	Color color3 = GUI.color;
																	if (106431 - 370618 != -264186)
																	{
																		color3.a = a2;
																		if (23619 - 518243 != -494623 && 190033 - 325417 != -135383)
																		{
																			Color color4 = GUI.color = color3;
																			if (67446 - 491674 == -424228)
																			{
																				if (136200 - 83639 == 52561)
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

	// Token: 0x06007CA8 RID: 31912 RVA: 0x0103327C File Offset: 0x0103147C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToAlpaca()
	{
		return new M403_CactonGarden.$TalkToAlpaca$38735(this).GetEnumerator();
	}

	// Token: 0x06007CA9 RID: 31913 RVA: 0x0103328C File Offset: 0x0103148C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06007CAA RID: 31914 RVA: 0x01033290 File Offset: 0x01031490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (283035 - 174281 != 108755)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (46942 - 545935 == -498993)
			{
				if (!characterControl)
				{
					break;
				}
				if (284017 - 403311 != -119293)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (216792 - 411273 != -194480)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (76531 - 1181 == 75350)
						{
							string type = characterControl.Type;
							if (87664 - 281974 != -194309)
							{
								if (type == "SandBug_r")
								{
									if (289818 - 473106 != -183287)
									{
										Game.sendMissionEvent(4031, 0);
										if (25664 - 368055 == -342391)
										{
											break;
										}
									}
								}
								else if (type == "Cacton")
								{
									if (213332 - 342095 == -128763)
									{
										Game.sendMissionEvent(4032, 0);
										if (184048 - 266333 != -82284)
										{
											break;
										}
									}
								}
								else
								{
									if (!(type == "Cactun"))
									{
										break;
									}
									if (186982 - 269221 != -82238)
									{
										Game.sendMissionEvent(4033, 0);
										if (19526 - 581650 != -562123)
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

	// Token: 0x06007CAB RID: 31915 RVA: 0x01033484 File Offset: 0x01031684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (5693 - 279890 != -274197)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (239610 - 48135 != 191476)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (116516 - 42032 != 74485)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (187454 - 353534 != -166079)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (49837 - 12793 == 37044)
						{
							int num4 = num;
							if (149135 - 262068 != -112932)
							{
								if (num4 == 4031)
								{
									if (85407 - 107923 == -22516)
									{
										this.gy0cFTsEMA5++;
										if (14554 - 172669 == -158115)
										{
											Debug.Log("Mission Objective: Bug Eliminate:" + this.gy0cFTsEMA5 + "/30");
											if (54610 - 299223 != -244612)
											{
												this.SendMessage("newGameMessage", "Mission Objective: Bug Eliminate:" + this.gy0cFTsEMA5 + "/30");
												if (282523 - 38749 != 243775)
												{
													if (PlayerData.UID != num3)
													{
														break;
													}
													if (275487 - 399361 != -123873)
													{
														GameObject gameObject = GameObject.Find("SpawnPoint1");
														if (90735 - 35098 == 55637)
														{
															GameObject gameObject2 = GameObject.Find("SpawnPoint2");
															if (162603 - 402145 == -239542)
															{
																GameObject gameObject3 = GameObject.Find("SpawnPoint3");
																if (119606 - 537241 != -417634)
																{
																	GameObject gameObject4 = GameObject.Find("SpawnPoint4");
																	if (298776 - 64313 == 234463)
																	{
																		GameObject gameObject5 = GameObject.Find("SpawnPoint5");
																		if (74283 - 235818 != -161534)
																		{
																			int num5 = this.gy0cFTsEMA5;
																			if (223678 - 368383 == -144705)
																			{
																				if (num5 == 2)
																				{
																					if (248812 - 340462 != -91649)
																					{
																						this.createActor("SandBug_r", 6, gameObject.transform.position, gameObject.transform.forward);
																						if (62111 - 261643 != -199531)
																						{
																							this.createActor("SandBug_r", 6, gameObject2.transform.position, gameObject2.transform.forward);
																							if (28281 - 110427 == -82146)
																							{
																								break;
																							}
																						}
																					}
																				}
																				else if (num5 == 4)
																				{
																					if (285760 - 587606 != -301845)
																					{
																						this.createActor("SandBug_r", 6, gameObject2.transform.position, gameObject2.transform.forward);
																						if (272300 - 488709 != -216408)
																						{
																							this.createActor("SandBug_r", 6, gameObject3.transform.position, gameObject3.transform.forward);
																							if (51553 - 88809 == -37256)
																							{
																								this.createActor("SandBug_r", 6, gameObject4.transform.position, gameObject4.transform.forward);
																								if (134482 - 398336 == -263854)
																								{
																									break;
																								}
																							}
																						}
																					}
																				}
																				else if (num5 == 7)
																				{
																					if (145722 - 70110 == 75612)
																					{
																						this.createActor("SandBug_r", 6, gameObject2.transform.position, gameObject2.transform.forward);
																						if (248571 - 237229 != 11343)
																						{
																							this.createActor("SandBug_r", 6, gameObject3.transform.position, gameObject3.transform.forward);
																							if (74786 - 7572 != 67215)
																							{
																								this.createActor("SandBug_r", 6, gameObject4.transform.position, gameObject4.transform.forward);
																								if (228098 - 280472 == -52374)
																								{
																									break;
																								}
																							}
																						}
																					}
																				}
																				else if (num5 == 10)
																				{
																					if (215363 - 196419 == 18944)
																					{
																						this.createActor("SandBug_r", 6, gameObject.transform.position, gameObject.transform.forward);
																						if (183778 - 68779 != 115000)
																						{
																							this.createActor("SandBug_r", 6, gameObject2.transform.position, gameObject2.transform.forward);
																							if (158628 - 331574 != -172945)
																							{
																								this.createActor("SandBug_r", 6, gameObject3.transform.position, gameObject3.transform.forward);
																								if (25466 - 271989 != -246522)
																								{
																									this.createActor("SandBug_r", 6, gameObject4.transform.position, gameObject4.transform.forward);
																									if (27618 - 512171 != -484552)
																									{
																										break;
																									}
																								}
																							}
																						}
																					}
																				}
																				else if (num5 == 14)
																				{
																					if (92952 - 492581 == -399629)
																					{
																						this.createActor("SandBug_r", 6, gameObject.transform.position, gameObject.transform.forward);
																						if (11712 - 469481 != -457768)
																						{
																							this.createActor("SandBug_r", 6, gameObject3.transform.position, gameObject3.transform.forward);
																							if (193801 - 209898 != -16096)
																							{
																								this.createActor("SandBug_r", 6, gameObject4.transform.position, gameObject4.transform.forward);
																								if (186591 - 149683 == 36908)
																								{
																									break;
																								}
																							}
																						}
																					}
																				}
																				else if (num5 == 16)
																				{
																					if (117185 - 116345 != 841)
																					{
																						this.createActor("SandBug_r", 6, gameObject.transform.position, gameObject.transform.forward);
																						if (191576 - 140978 == 50598)
																						{
																							this.createActor("SandBug_r", 6, gameObject2.transform.position, gameObject2.transform.forward);
																							if (253624 - 408718 != -155093)
																							{
																								this.createActor("SandBug_r", 6, gameObject3.transform.position, gameObject3.transform.forward);
																								if (91953 - 597084 == -505131)
																								{
																									break;
																								}
																							}
																						}
																					}
																				}
																				else if (num5 == 20)
																				{
																					if (186977 - 253662 != -66684)
																					{
																						this.createActor("SandBug_r", 6, gameObject.transform.position, gameObject.transform.forward);
																						if (197948 - 207148 == -9200)
																						{
																							this.createActor("SandBug_r", 6, gameObject2.transform.position, gameObject2.transform.forward);
																							if (6262 - 597346 == -591084)
																							{
																								this.createActor("SandBug_r", 6, gameObject3.transform.position, gameObject3.transform.forward);
																								if (187436 - 214644 == -27208)
																								{
																									this.createActor("SandBug_r", 6, gameObject4.transform.position, gameObject4.transform.forward);
																									if (101695 - 208938 != -107242)
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
																					if (num5 != 25)
																					{
																						break;
																					}
																					if (235980 - 383446 == -147466)
																					{
																						this.createActor("SandBug_r", 6, gameObject.transform.position, gameObject.transform.forward);
																						if (23077 - 107879 == -84802)
																						{
																							this.createActor("SandBug_r", 6, gameObject2.transform.position, gameObject2.transform.forward);
																							if (267937 - 294636 != -26698)
																							{
																								this.createActor("SandBug_r", 6, gameObject3.transform.position, gameObject3.transform.forward);
																								if (41264 - 512561 != -471296)
																								{
																									this.createActor("SandBug_r", 6, gameObject4.transform.position, gameObject4.transform.forward);
																									if (47971 - 435921 != -387949)
																									{
																										this.createActor("SandBug_r", 6, gameObject5.transform.position, gameObject5.transform.forward);
																										if (164027 - 521036 == -357009)
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
								else if (num4 == 4032)
								{
									if (109305 - 49704 == 59601)
									{
										this.kGpcFYCskJs--;
										if (63041 - 207342 == -144301)
										{
											this.SendMessage("newGameMessage", "Warning : Cacton left: " + this.kGpcFYCskJs + "/4");
											if (69841 - 195154 == -125313)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (num4 != 4033)
									{
										break;
									}
									if (130969 - 367044 == -236075)
									{
										this.xADcF3CiFPw--;
										if (65235 - 186553 == -121318)
										{
											this.SendMessage("newGameMessage", "Cactun left: " + this.xADcF3CiFPw + "/4");
											if (109410 - 143879 != -34468)
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

	// Token: 0x06007CAC RID: 31916 RVA: 0x0103405C File Offset: 0x0103225C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M403_CactonGarden.$onGameComplete$38741(data, this).GetEnumerator();
	}

	// Token: 0x06007CAD RID: 31917 RVA: 0x0103406C File Offset: 0x0103226C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (238978 - 58049 != 180930)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (125754 - 479052 != -353297)
			{
				CharacterControl characterControl = null;
				if (179165 - 320334 == -141169)
				{
					if (mPlayer)
					{
						if (8502 - 309802 == -301299)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (162830 - 318182 == -155351)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (223739 - 382662 != -158922)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (3374 - 507216 != -503841)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (97504 - 206854 != -109349)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (253697 - 98254 != 155443)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (207988 - 300467 == -92478)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (32694 - 276775 != -244081)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (87545 - 228299 != -140753)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (237782 - 86522 == 151260)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (39809 - 395243 != -355433)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (93151 - 399583 == -306432)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (17279 - 399616 != -382336)
								{
									if (!changeGui)
									{
										break;
									}
									if (51580 - 505989 == -454409)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (192402 - 394664 == -202261)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (230640 - 53327 == 177314)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (264625 - 387000 == -122375)
										{
											gameGui.close();
											if (154490 - 525964 == -371474)
											{
												changeGui.enabled = true;
												if (44041 - 35845 == 8196)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (99256 - 507159 == -407903)
													{
														if (!gameObject)
														{
															break;
														}
														if (204864 - 256496 == -51632)
														{
															if (!mPlayer)
															{
																break;
															}
															if (241804 - 550032 == -308228)
															{
																Debug.Log("UseLifeAltar");
																if (145563 - 13783 != 131781)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (36926 - 498577 == -461651)
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

	// Token: 0x06007CAE RID: 31918 RVA: 0x010344CC File Offset: 0x010326CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(object mVar)
	{
		return new M403_CactonGarden.$UseSignPost$38750(this).GetEnumerator();
	}

	// Token: 0x06007CAF RID: 31919 RVA: 0x010344DC File Offset: 0x010326DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (157501 - 70600 != 86901)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (264731 - 190265 == 74466)
			{
				Hashtable customOpParameters = new Hashtable();
				if (6842 - 507138 == -500296)
				{
					this.j2ocF1dCGa6.OpCustom(52, customOpParameters, true);
					if (12336 - 433677 == -421341)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007CB0 RID: 31920 RVA: 0x01034584 File Offset: 0x01032784
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (193354 - 365787 != -172433)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (242361 - 369571 == -127210)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (118145 - 112096 == 6049)
				{
					Game.mGameState = eGameState.Setup;
					if (147448 - 343592 == -196144)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007CB1 RID: 31921 RVA: 0x01034628 File Offset: 0x01032828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (196624 - 368983 != -172358)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (76746 - 411704 == -334958)
			{
				if (num == PlayerData.UID)
				{
					if (111203 - 569320 != -458116)
					{
						this.SetupActors();
						if (198587 - 493826 != -295238)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (186111 - 316018 != -129906)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007CB2 RID: 31922 RVA: 0x010346F8 File Offset: 0x010328F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (17862 - 579149 != -561286)
		{
		}
		for (;;)
		{
			IL_103:
			Debug.Log("Creating Actors");
			if (250544 - 102655 == 147889)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (149933 - 474403 != -324469)
				{
					int i = 0;
					if (27853 - 537379 == -509526)
					{
						CharacterControl[] array2 = array;
						if (239343 - 594298 != -354954)
						{
							int length = array2.Length;
							if (151833 - 391471 != -239637)
							{
								while (i < length)
								{
									string type = array2[i].Type;
									if (152441 - 314940 != -162499)
									{
										goto IL_103;
									}
									if (type == "Cacton")
									{
										goto IL_1C5;
									}
									if (112838 - 170038 == -57199)
									{
										goto IL_103;
									}
									if (type == "Cactun")
									{
										goto IL_1C5;
									}
									if (230800 - 573625 == -342824)
									{
										goto IL_103;
									}
									if (type == "SandBug_r")
									{
										if (135266 - 110813 != 24453)
										{
											goto IL_103;
										}
										goto IL_1C5;
									}
									IL_6B:
									UnityEngine.Object.Destroy(array2[i].gameObject);
									if (252989 - 305481 != -52492)
									{
										goto IL_103;
									}
									this.rwqcFbTG807++;
									if (285271 - 128549 != 156722)
									{
										goto IL_103;
									}
									i++;
									if (92038 - 472404 != -380365)
									{
										continue;
									}
									goto IL_103;
									IL_1C5:
									this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
									if (285739 - 552194 != -266454)
									{
										goto IL_6B;
									}
									goto IL_103;
								}
								if (54300 - 116011 != -61710)
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

	// Token: 0x06007CB3 RID: 31923 RVA: 0x01034978 File Offset: 0x01032B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (95701 - 383740 != -288039)
		{
		}
		for (;;)
		{
			IL_68:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (230960 - 467648 == -236688)
			{
				int i = 0;
				if (161108 - 594606 == -433498)
				{
					CharacterControl[] array2 = array;
					if (62683 - 247590 != -184906)
					{
						int length = array2.Length;
						if (68 - 521333 != -521264)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (244839 - 393019 != -148180)
								{
									goto IL_68;
								}
								i++;
								if (156887 - 136682 == 20206)
								{
									goto IL_68;
								}
							}
							if (147142 - 592183 != -445040)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007CB4 RID: 31924 RVA: 0x01034AA8 File Offset: 0x01032CA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (46822 - 104392 != -57570)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (104592 - 513717 != -409124)
			{
				hashtable.Add(43, PlayerData.UID);
				if (161211 - 500251 == -339040)
				{
					hashtable.Add(73, nType);
					if (108238 - 219275 != -111036)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (54234 - 360986 != -306751)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (140282 - 237103 == -96821)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (14504 - 493647 == -479143)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (55651 - 93371 == -37720)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (173414 - 197118 != -23703)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (128217 - 98036 == 30181)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (279792 - 471329 == -191537)
												{
													this.j2ocF1dCGa6.OpCustom(63, hashtable, true);
													if (110948 - 443190 != -332241)
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

	// Token: 0x06007CB5 RID: 31925 RVA: 0x01034D60 File Offset: 0x01032F60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (177409 - 567641 != -390231)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (105838 - 488330 != -382491)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (281357 - 104919 == 176438)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (55448 - 232649 != -177200)
						{
							if (this.rwqcFbTG807 <= 0)
							{
								break;
							}
							if (171203 - 136498 != 34706)
							{
								this.rwqcFbTG807--;
								if (198616 - 586425 != -387808)
								{
									if (this.rwqcFbTG807 != 0)
									{
										break;
									}
									if (146143 - 116685 != 29459)
									{
										Game.setGameState(eGameState.Ready);
										if (171142 - 155284 != 15859)
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
						if (295631 - 136847 != 158785)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (104492 - 328047 != -223554)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007CB6 RID: 31926 RVA: 0x01034EF0 File Offset: 0x010330F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (117248 - 260959 != -143710)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (216749 - 431002 == -214253)
			{
				Game.mGameState = eGameState.Ready;
				if (186036 - 327023 != -140986)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (135283 - 554563 != -419279)
					{
						GameObject gameObject = null;
						if (46227 - 517118 != -470890)
						{
							GameObject gameObject2 = null;
							if (1746 - 417197 == -415451)
							{
								if (playerSlot > 1)
								{
									if (134676 - 371116 == -236439)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (235451 - 521273 == -285821)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (250932 - 168026 != 82906)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (98138 - 305962 != -207824)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (22180 - 424757 == -402576)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (143037 - 9114 == 133924)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (154136 - 335905 == -181768)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (135297 - 478637 != -343340)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (291333 - 99011 != 192322)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (52948 - 2641 == 50308)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (90397 - 48790 == 41607)
								{
									this.transform.position = gameObject2.transform.position;
									if (87987 - 61254 != 26734)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (139158 - 348700 == -209542)
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

	// Token: 0x06007CB7 RID: 31927 RVA: 0x010351EC File Offset: 0x010333EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M403_CactonGarden.$StartGame$38753(this).GetEnumerator();
	}

	// Token: 0x06007CB8 RID: 31928 RVA: 0x010351FC File Offset: 0x010333FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007CB9 RID: 31929 RVA: 0x01035200 File Offset: 0x01033400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (192980 - 188081 != 4899)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (158938 - 175137 == -16199)
			{
				hashtable.Add(71, CID);
				if (49807 - 395320 == -345513)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (64156 - 56673 != 7484)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (277757 - 84287 == 193470)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (200261 - 262279 != -62017)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (236396 - 293543 == -57147)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (180630 - 374304 != -193673)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (282621 - 264770 != 17852)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (39847 - 333250 != -293402)
											{
												this.j2ocF1dCGa6.OpCustom(61, hashtable, true);
												if (55001 - 26072 != 28930)
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

	// Token: 0x06007CBA RID: 31930 RVA: 0x0103548C File Offset: 0x0103368C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (161692 - 140932 != 20761)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (151156 - 507591 != -356434)
			{
				if (!gameObject)
				{
					break;
				}
				if (8595 - 232796 == -224201)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (14225 - 389478 != -375252)
					{
						playerCameraControl.target = gameObject;
						if (9059 - 53567 != -44507)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (30849 - 461626 == -430777)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007CBB RID: 31931 RVA: 0x01035584 File Offset: 0x01033784
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (46388 - 549572 != -503184)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (51184 - 383481 == -332297)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (26809 - 204682 == -177873)
				{
					gameGui.ResetTeamBar();
					if (12464 - 58937 != -46472)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007CBC RID: 31932 RVA: 0x01035630 File Offset: 0x01033830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (274201 - 33675 != 240526)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (58056 - 138659 != -80602)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (174898 - 564997 == -390099)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (136567 - 58987 == 77580)
					{
						Hashtable hashtable = new Hashtable();
						if (182777 - 381887 != -199109)
						{
							hashtable.Add(43, PlayerData.UID);
							if (46598 - 298143 == -251545)
							{
								hashtable.Add(71, nCID);
								if (26123 - 104542 != -78418)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (113166 - 76387 == 36779)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (273221 - 9891 == 263330)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (257011 - 7231 == 249780)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (56138 - 291372 == -235234)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (42565 - 128418 == -85853)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (206029 - 72692 == 133337)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (38580 - 563207 != -524626)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (14792 - 178472 == -163680)
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

	// Token: 0x06007CBD RID: 31933 RVA: 0x01035950 File Offset: 0x01033B50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M403_CactonGarden.$onChangePlayer$38757(data, this).GetEnumerator();
	}

	// Token: 0x06007CBE RID: 31934 RVA: 0x01035960 File Offset: 0x01033B60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M403_CactonGarden.$onDeadPlayer$38764(this).GetEnumerator();
	}

	// Token: 0x06007CBF RID: 31935 RVA: 0x01035970 File Offset: 0x01033B70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (294292 - 185295 != 108998)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (59462 - 454306 != -394843)
			{
				this.QMQcFqk2jKP.target = Game.mPlayer;
				if (102883 - 327608 == -224725)
				{
					this.QMQcFqk2jKP.enabled = true;
					if (252828 - 508979 == -256151)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (219003 - 351913 == -132909)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (274812 - 222801 == 52012)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (205022 - 175490 == 29532)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (239918 - 590700 != -350781)
							{
								if (!gameGui)
								{
									break;
								}
								if (102307 - 180522 == -78215)
								{
									gameGui.enabled = true;
									if (251213 - 555570 == -304357)
									{
										gameGui.closeDeadMenu();
										if (156723 - 390288 == -233565)
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

	// Token: 0x06007CC0 RID: 31936 RVA: 0x01035B1C File Offset: 0x01033D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (235284 - 169511 != 65773)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (125816 - 353791 == -227975)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (178841 - 51421 != 127421)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (180756 - 539429 != -358672)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007CC1 RID: 31937 RVA: 0x01035BE0 File Offset: 0x01033DE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007CC2 RID: 31938 RVA: 0x01035C0C File Offset: 0x01033E0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M403_CactonGarden.$ReturnToTown$38770(this).GetEnumerator();
	}

	// Token: 0x06007CC3 RID: 31939 RVA: 0x01035C1C File Offset: 0x01033E1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M403_CactonGarden.$ReturnToGuild$38775(this).GetEnumerator();
	}

	// Token: 0x06007CC4 RID: 31940 RVA: 0x01035C2C File Offset: 0x01033E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M403_CactonGarden.$ReturnToCamp$38779(this).GetEnumerator();
	}

	// Token: 0x06007CC5 RID: 31941 RVA: 0x01035C3C File Offset: 0x01033E3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (37025 - 34228 != 2798)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (145004 - 393736 == -248732)
			{
				Hashtable hashtable = new Hashtable();
				if (276392 - 272070 != 4323)
				{
					hashtable.Add(43, PlayerData.UID);
					if (256017 - 541379 != -285361)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (287601 - 340795 != -53193)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007CC6 RID: 31942 RVA: 0x01035D14 File Offset: 0x01033F14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007CC7 RID: 31943 RVA: 0x01035D28 File Offset: 0x01033F28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (215179 - 194264 != 20916)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (7752 - 164913 == -157161)
			{
				Hashtable hashtable = new Hashtable();
				if (106506 - 429859 != -323352)
				{
					if (Game.mNextGameCode == 30)
					{
						if (293466 - 422218 == -128751)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (272782 - 279206 == -6423)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (204790 - 277177 != -72387)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (259485 - 287429 == -27943)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (278283 - 214960 == 63324)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (107166 - 277024 == -169857)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (30630 - 502427 != -471797)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (196416 - 389770 == -193353)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (278941 - 353382 != -74441)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (43565 - 573563 == -529997)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (54509 - 231246 == -176736)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (268489 - 499587 == -231097)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (194870 - 379074 != -184204)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (147971 - 322160 == -174188)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (187233 - 467093 != -279860)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (115082 - 491795 != -376713)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (170740 - 194447 == -23706)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (46391 - 78413 == -32021)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (252206 - 155282 != 96924)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (146153 - 38114 != 108039)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (149760 - 447535 == -297774)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (38604 - 4753 != 33851)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (291443 - 195449 == 95995)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (283380 - 371763 == -88382)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (298351 - 311950 != -13599)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (102430 - 55118 != 47312)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (181006 - 332933 == -151926)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (120666 - 202422 != -81756)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (230215 - 230698 == -483)
					{
						this.j2ocF1dCGa6.OpCustom(42, hashtable, true);
						if (130756 - 120297 == 10459)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007CC8 RID: 31944 RVA: 0x010362DC File Offset: 0x010344DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007CC9 RID: 31945 RVA: 0x010362EC File Offset: 0x010344EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007CCA RID: 31946 RVA: 0x010362F0 File Offset: 0x010344F0
	internal static bool JOhS2jpbRsvfqgBV0hjl()
	{
		return true;
	}

	// Token: 0x06007CCB RID: 31947 RVA: 0x010362F4 File Offset: 0x010344F4
	internal static bool GbHfDUpbwrq6vSIcEj8f()
	{
		return false;
	}

	// Token: 0x04007D89 RID: 32137
	private LitePeer j2ocF1dCGa6;

	// Token: 0x04007D8A RID: 32138
	private PlayerCameraControl QMQcFqk2jKP;

	// Token: 0x04007D8B RID: 32139
	private float hd5cFpDFsmv;

	// Token: 0x04007D8C RID: 32140
	private Texture HBEcFRvGt1h;

	// Token: 0x04007D8D RID: 32141
	private AudioClip HQIcFr9OJXM;

	// Token: 0x04007D8E RID: 32142
	private int EYbcFxqysqF;

	// Token: 0x04007D8F RID: 32143
	private int gy0cFTsEMA5;

	// Token: 0x04007D90 RID: 32144
	private int kGpcFYCskJs;

	// Token: 0x04007D91 RID: 32145
	private int xADcF3CiFPw;

	// Token: 0x04007D92 RID: 32146
	private int rwqcFbTG807;

	// Token: 0x0200150A RID: 5386
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToAlpaca$38735 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007CCC RID: 31948 RVA: 0x010362F8 File Offset: 0x010344F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToAlpaca$38735(M403_CactonGarden self_)
		{
			if (102921 - 187259 != -84338)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (223143 - 270809 != -47665)
				{
					base..ctor();
					if (20846 - 592122 != -571275)
					{
						this.$self_$38740 = self_;
						if (11889 - 200641 == -188752)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007CCD RID: 31949 RVA: 0x01036390 File Offset: 0x01034590
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M403_CactonGarden.$TalkToAlpaca$38735.$(this.$self_$38740);
		}

		// Token: 0x06007CCE RID: 31950 RVA: 0x010363A0 File Offset: 0x010345A0
		internal static bool h1MktipbqTIYjcn4ENg5()
		{
			return true;
		}

		// Token: 0x06007CCF RID: 31951 RVA: 0x010363A4 File Offset: 0x010345A4
		internal static bool oJmLQcpb7tlJ5JfpirLi()
		{
			return false;
		}

		// Token: 0x04007D93 RID: 32147
		internal M403_CactonGarden $self_$38740;

		// Token: 0x0200150B RID: 5387
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007CD0 RID: 31952 RVA: 0x010363A8 File Offset: 0x010345A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M403_CactonGarden self_)
			{
				if (93271 - 11015 != 82257)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (6362 - 566652 == -560290)
					{
						base..ctor();
						if (128680 - 15812 != 112869)
						{
							this.$self_$38739 = self_;
							if (275491 - 568156 == -292665)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007CD1 RID: 31953 RVA: 0x01036440 File Offset: 0x01034640
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (65389 - 567747 != -502358)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_339;
					case 2:
						this.$mStoryGui$38738.newStoryMessage("Alpaca", "Yves", Language.getMessage("M403_CactonGarden", 4030 + UnityEngine.Random.Range(1, 4)), eTalkType.friend);
						if (268356 - 577407 != -309050)
						{
							goto Block_13;
						}
						continue;
					case 3:
						this.$mStoryGui$38738.close();
						if (77329 - 224292 != -146963)
						{
							continue;
						}
						this.$mGameGui$38737.enabled = true;
						if (167407 - 94748 != 72660)
						{
							goto Block_2;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (137472 - 106264 != 31208)
						{
							continue;
						}
						this.YieldDefault(1);
						if (134894 - 291271 != -156376)
						{
							goto Block_10;
						}
						continue;
					default:
						if (59266 - 228227 != -168961)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (42266 - 303788 != -261521)
						{
							goto Block_12;
						}
					}
					else
					{
						this.$mAlpaca$38736 = GameObject.Find("Alpaca");
						if (158903 - 94995 == 63908)
						{
							if (this.$mAlpaca$38736)
							{
								if (62097 - 287432 == -225334)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", this.$mAlpaca$38736.transform.position);
								if (127039 - 418855 == -291815)
								{
									continue;
								}
							}
							Game.mGameState = eGameState.Hold;
							if (58607 - 68713 == -10106)
							{
								this.$mGameGui$38737 = (GameGui)this.$self_$38739.GetComponent(typeof(GameGui));
								if (55399 - 12096 != 43304)
								{
									if (this.$mGameGui$38737)
									{
										if (244457 - 486964 != -242507)
										{
											continue;
										}
										this.$mGameGui$38737.close();
										if (117933 - 226298 != -108365)
										{
											continue;
										}
									}
									this.$mStoryGui$38738 = (StoryGui)this.$self_$38739.GetComponent(typeof(StoryGui));
									if (48109 - 198292 == -150183)
									{
										this.$mStoryGui$38738.startStoryMessage("Alpaca", "Yves", eTalkType.friend);
										if (277880 - 401552 != -123671)
										{
											goto Block_14;
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_10:
				Block_12:
				goto IL_339;
				Block_13:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_14:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_339:
				return false;
			}

			// Token: 0x06007CD2 RID: 31954 RVA: 0x01036798 File Offset: 0x01034998
			internal static bool FPh31LpbP67QeWAYBxEm()
			{
				return true;
			}

			// Token: 0x06007CD3 RID: 31955 RVA: 0x0103679C File Offset: 0x0103499C
			internal static bool Xy4EUnpb0Riiv4VSe18c()
			{
				return false;
			}

			// Token: 0x04007D94 RID: 32148
			internal GameObject $mAlpaca$38736;

			// Token: 0x04007D95 RID: 32149
			internal GameGui $mGameGui$38737;

			// Token: 0x04007D96 RID: 32150
			internal StoryGui $mStoryGui$38738;

			// Token: 0x04007D97 RID: 32151
			internal M403_CactonGarden $self_$38739;
		}
	}

	// Token: 0x0200150C RID: 5388
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38741 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007CD4 RID: 31956 RVA: 0x010367A0 File Offset: 0x010349A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38741(Hashtable data, M403_CactonGarden self_)
		{
			if (32588 - 202721 != -170132)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179188 - 574186 == -394998)
				{
					base..ctor();
					if (84008 - 369175 != -285166)
					{
						this.$data$38748 = data;
						if (123772 - 189115 == -65343)
						{
							this.$self_$38749 = self_;
							if (168056 - 44056 == 124000)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007CD5 RID: 31957 RVA: 0x0103685C File Offset: 0x01034A5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M403_CactonGarden.$onGameComplete$38741.$(this.$data$38748, this.$self_$38749);
		}

		// Token: 0x06007CD6 RID: 31958 RVA: 0x01036870 File Offset: 0x01034A70
		internal static bool o5hc2QpbbCJfReIJUNUZ()
		{
			return true;
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x01036874 File Offset: 0x01034A74
		internal static bool PB2LtQpbulLrCVEVRIlu()
		{
			return false;
		}

		// Token: 0x04007D98 RID: 32152
		internal Hashtable $data$38748;

		// Token: 0x04007D99 RID: 32153
		internal M403_CactonGarden $self_$38749;

		// Token: 0x0200150D RID: 5389
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007CD8 RID: 31960 RVA: 0x01036878 File Offset: 0x01034A78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M403_CactonGarden self_)
			{
				if (30666 - 122567 != -91900)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (50472 - 244816 == -194344)
					{
						base..ctor();
						if (184737 - 132089 != 52649)
						{
							this.$data$38746 = data;
							if (133873 - 478968 == -345095)
							{
								this.$self_$38747 = self_;
								if (69496 - 378422 != -308925)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007CD9 RID: 31961 RVA: 0x01036934 File Offset: 0x01034B34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (326 - 256873 != -256547)
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
						this.$mCompleteGui$38743 = (CompleteGui)this.$self_$38747.GetComponent(typeof(CompleteGui));
						if (283614 - 298544 != -14930)
						{
							continue;
						}
						this.$mCompleteGui$38743.Init();
						if (68815 - 553511 == -484695)
						{
							continue;
						}
						this.$mCompleteGui$38743.readData(this.$data$38746);
						if (245347 - 104245 != 141102)
						{
							continue;
						}
						if (this.$result$38742 == 1)
						{
							if (145648 - 163174 != -17526)
							{
								continue;
							}
							this.$mCompleteGui$38743.displayResult(eCompleteType.Success);
							if (202682 - 363560 != -160878)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38743.displayResult(eCompleteType.Failed);
							if (265252 - 552663 == -287410)
							{
								continue;
							}
						}
						this.$mGameGui$38744 = (GameGui)this.$self_$38747.GetComponent(typeof(GameGui));
						if (145719 - 198528 != -52809)
						{
							continue;
						}
						this.$mStoryGui$38745 = (StoryGui)this.$self_$38747.GetComponent(typeof(StoryGui));
						if (89088 - 579854 != -490766)
						{
							continue;
						}
						if (this.$mGameGui$38744)
						{
							if (231773 - 384996 == -153222)
							{
								continue;
							}
							this.$mGameGui$38744.close();
							if (111930 - 385757 == -273826)
							{
								continue;
							}
						}
						if (this.$mStoryGui$38745)
						{
							if (19397 - 193997 == -174599)
							{
								continue;
							}
							this.$mStoryGui$38745.close();
							if (143520 - 15586 == 127935)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (120737 - 510587 != -389849)
						{
							goto Block_16;
						}
						continue;
					default:
						if (185570 - 386632 == -201061)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$38746[31]);
					if (203501 - 526247 != -322745)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (164090 - 65709 == 98381)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (31784 - 392600 == -360816)
							{
								this.$result$38742 = RuntimeServices.UnboxInt32(this.$data$38746[31]);
								if (182822 - 290639 == -107817)
								{
									goto IL_28E;
								}
							}
						}
					}
				}
				Block_16:
				goto IL_352;
				IL_28E:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06007CDA RID: 31962 RVA: 0x01036CA8 File Offset: 0x01034EA8
			internal static bool UOrq7EpbIAPNhRJn2SP5()
			{
				return true;
			}

			// Token: 0x06007CDB RID: 31963 RVA: 0x01036CAC File Offset: 0x01034EAC
			internal static bool sAGGGxpbBYiD1DZPBhIX()
			{
				return false;
			}

			// Token: 0x04007D9A RID: 32154
			internal int $result$38742;

			// Token: 0x04007D9B RID: 32155
			internal CompleteGui $mCompleteGui$38743;

			// Token: 0x04007D9C RID: 32156
			internal GameGui $mGameGui$38744;

			// Token: 0x04007D9D RID: 32157
			internal StoryGui $mStoryGui$38745;

			// Token: 0x04007D9E RID: 32158
			internal Hashtable $data$38746;

			// Token: 0x04007D9F RID: 32159
			internal M403_CactonGarden $self_$38747;
		}
	}

	// Token: 0x0200150E RID: 5390
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$38750 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007CDC RID: 31964 RVA: 0x01036CB0 File Offset: 0x01034EB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$38750(M403_CactonGarden self_)
		{
			if (218125 - 80176 != 137950)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (92812 - 543557 != -450744)
				{
					base..ctor();
					if (100926 - 304248 != -203321)
					{
						this.$self_$38752 = self_;
						if (254655 - 270671 != -16015)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007CDD RID: 31965 RVA: 0x01036D48 File Offset: 0x01034F48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M403_CactonGarden.$UseSignPost$38750.$(this.$self_$38752);
		}

		// Token: 0x06007CDE RID: 31966 RVA: 0x01036D58 File Offset: 0x01034F58
		internal static bool x6HJ9lpbeGyIdodhbY1t()
		{
			return true;
		}

		// Token: 0x06007CDF RID: 31967 RVA: 0x01036D5C File Offset: 0x01034F5C
		internal static bool tePVprpbrsgWojk0OkDT()
		{
			return false;
		}

		// Token: 0x04007DA0 RID: 32160
		internal M403_CactonGarden $self_$38752;

		// Token: 0x0200150F RID: 5391
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007CE0 RID: 31968 RVA: 0x01036D60 File Offset: 0x01034F60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M403_CactonGarden self_)
			{
				if (171369 - 378570 != -207201)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (250570 - 386295 == -135725)
					{
						base..ctor();
						if (239920 - 351811 != -111890)
						{
							this.$self_$38751 = self_;
							if (182569 - 331991 == -149422)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007CE1 RID: 31969 RVA: 0x01036DF8 File Offset: 0x01034FF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (8373 - 5574 != 2799)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_16C;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (250999 - 355070 != -104071)
						{
							continue;
						}
						goto IL_A7;
					default:
						if (27300 - 137729 == -110428)
						{
							continue;
						}
						break;
					}
					if (PlayerData.QuestID == 28)
					{
						if (276086 - 383531 == -107444)
						{
							continue;
						}
						Q28_DesertPatrol.TalkToSignPost2(this.$self_$38751.gameObject);
						if (255846 - 332880 != -77034)
						{
							continue;
						}
					}
					else if (Game.mGameState == eGameState.Normal)
					{
						if (285067 - 443787 == -158719)
						{
							continue;
						}
						Game.mGameState = eGameState.Hold;
						if (214530 - 174201 == 40330)
						{
							continue;
						}
						this.$self_$38751.SendMessage("newNoticeBar", "Cacton Garden");
						if (105776 - 252060 != -146283)
						{
							break;
						}
						continue;
					}
					IL_A7:
					this.YieldDefault(1);
					if (246452 - 288230 == -41778)
					{
						goto IL_16C;
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_16C:
				return false;
			}

			// Token: 0x06007CE2 RID: 31970 RVA: 0x01036F84 File Offset: 0x01035184
			internal static bool MC7yPipbjfNad3ie6NdL()
			{
				return true;
			}

			// Token: 0x06007CE3 RID: 31971 RVA: 0x01036F88 File Offset: 0x01035188
			internal static bool S4EpWqpbhyCqgXpmckUG()
			{
				return false;
			}

			// Token: 0x04007DA1 RID: 32161
			internal M403_CactonGarden $self_$38751;
		}
	}

	// Token: 0x02001510 RID: 5392
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38753 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007CE4 RID: 31972 RVA: 0x01036F8C File Offset: 0x0103518C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38753(M403_CactonGarden self_)
		{
			if (119077 - 54768 != 64309)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (140453 - 574017 == -433564)
				{
					base..ctor();
					if (1816 - 380480 != -378663)
					{
						this.$self_$38756 = self_;
						if (150342 - 542095 != -391752)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007CE5 RID: 31973 RVA: 0x01037024 File Offset: 0x01035224
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M403_CactonGarden.$StartGame$38753.$(this.$self_$38756);
		}

		// Token: 0x06007CE6 RID: 31974 RVA: 0x01037034 File Offset: 0x01035234
		internal static bool URPOESpbssQbWU90P5Yl()
		{
			return true;
		}

		// Token: 0x06007CE7 RID: 31975 RVA: 0x01037038 File Offset: 0x01035238
		internal static bool cni6Tjpb9xZxBssaeBu9()
		{
			return false;
		}

		// Token: 0x04007DA2 RID: 32162
		internal M403_CactonGarden $self_$38756;

		// Token: 0x02001511 RID: 5393
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007CE8 RID: 31976 RVA: 0x0103703C File Offset: 0x0103523C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M403_CactonGarden self_)
			{
				if (81803 - 167823 != -86019)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (5290 - 116419 != -111128)
					{
						base..ctor();
						if (14336 - 50324 == -35988)
						{
							this.$self_$38755 = self_;
							if (229518 - 38229 != 191290)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007CE9 RID: 31977 RVA: 0x010370D4 File Offset: 0x010352D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (21430 - 277953 != -256522)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_241;
					case 2:
						this.$mGameGui$38754 = (GameGui)this.$self_$38755.GetComponent(typeof(GameGui));
						if (157245 - 92574 == 64672)
						{
							continue;
						}
						this.$mGameGui$38754.enabled = true;
						if (213214 - 159751 != 53463)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (63344 - 21219 != 42125)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (52028 - 273378 == -221349)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (273489 - 549670 == -276180)
						{
							continue;
						}
						if (this.$self_$38755.HQIcFr9OJXM)
						{
							if (74736 - 488264 != -413528)
							{
								continue;
							}
							this.$self_$38755.audio.PlayOneShot(this.$self_$38755.HQIcFr9OJXM);
							if (187146 - 346172 == -159025)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (73366 - 130280 != -56914)
						{
							continue;
						}
						goto IL_241;
					default:
						if (224418 - 526691 == -302272)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (65070 - 335144 != -270073)
					{
						Game.mGameState = eGameState.Start;
						if (76486 - 153413 == -76927)
						{
							Game.mStateTime = Time.time;
							if (229641 - 389136 != -159494)
							{
								this.$self_$38755.SendMessage("fadeIn");
								if (254805 - 423665 != -168859)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_241:
				return false;
			}

			// Token: 0x06007CEA RID: 31978 RVA: 0x01037334 File Offset: 0x01035534
			internal static bool nGoUUupb1kYpJ5qdeZ3W()
			{
				return true;
			}

			// Token: 0x06007CEB RID: 31979 RVA: 0x01037338 File Offset: 0x01035538
			internal static bool WA3mHYpb4axe3ERt2nS3()
			{
				return false;
			}

			// Token: 0x04007DA3 RID: 32163
			internal GameGui $mGameGui$38754;

			// Token: 0x04007DA4 RID: 32164
			internal M403_CactonGarden $self_$38755;
		}
	}

	// Token: 0x02001512 RID: 5394
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$38757 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007CEC RID: 31980 RVA: 0x0103733C File Offset: 0x0103553C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$38757(Hashtable data, M403_CactonGarden self_)
		{
			if (110940 - 554136 != -443195)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (123383 - 257476 == -134093)
				{
					base..ctor();
					if (33980 - 134200 == -100220)
					{
						this.$data$38762 = data;
						if (55355 - 474528 == -419173)
						{
							this.$self_$38763 = self_;
							if (188286 - 256683 == -68397)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007CED RID: 31981 RVA: 0x010373F8 File Offset: 0x010355F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M403_CactonGarden.$onChangePlayer$38757.$(this.$data$38762, this.$self_$38763);
		}

		// Token: 0x06007CEE RID: 31982 RVA: 0x0103740C File Offset: 0x0103560C
		internal static bool kLaeogpbzfqphLK8xbK7()
		{
			return true;
		}

		// Token: 0x06007CEF RID: 31983 RVA: 0x01037410 File Offset: 0x01035610
		internal static bool f7V0iepuaAHsygnVmXUP()
		{
			return false;
		}

		// Token: 0x04007DA5 RID: 32165
		internal Hashtable $data$38762;

		// Token: 0x04007DA6 RID: 32166
		internal M403_CactonGarden $self_$38763;

		// Token: 0x02001513 RID: 5395
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007CF0 RID: 31984 RVA: 0x01037414 File Offset: 0x01035614
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M403_CactonGarden self_)
			{
				if (61575 - 23388 != 38187)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (278587 - 307933 == -29346)
					{
						base..ctor();
						if (125523 - 201441 != -75917)
						{
							this.$data$38760 = data;
							if (241332 - 152423 == 88909)
							{
								this.$self_$38761 = self_;
								if (67384 - 324484 == -257100)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007CF1 RID: 31985 RVA: 0x010374D0 File Offset: 0x010356D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148249 - 64858 != 83391)
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
							if (283046 - 594226 == -311179)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (117340 - 503312 != -385972)
							{
								continue;
							}
							this.$mGameGui$38759 = (GameGui)this.$self_$38761.GetComponent(typeof(GameGui));
							if (258350 - 421160 == -162809)
							{
								continue;
							}
							this.$mGameGui$38759.enabled = true;
							if (288108 - 305696 != -17588)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (119676 - 157422 != -37746)
						{
							continue;
						}
						goto IL_205;
					default:
						if (160423 - 585970 != -425547)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (52398 - 307732 == -255334)
					{
						this.$self_$38761.SendMessage("onCreatePlayer", this.$data$38760);
						if (78261 - 511663 != -433401)
						{
							this.$mChangeGui$38758 = (ChangeGui)this.$self_$38761.GetComponent(typeof(ChangeGui));
							if (14606 - 30699 != -16092)
							{
								if (!this.$mChangeGui$38758.enabled)
								{
									break;
								}
								if (77034 - 589097 == -512063)
								{
									this.$mChangeGui$38758.close();
									if (241517 - 256130 != -14612)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_3C:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_3C;
				IL_205:
				return false;
			}

			// Token: 0x06007CF2 RID: 31986 RVA: 0x010376F4 File Offset: 0x010358F4
			internal static bool MyXiYGpu55fgXyvZhWwa()
			{
				return true;
			}

			// Token: 0x06007CF3 RID: 31987 RVA: 0x010376F8 File Offset: 0x010358F8
			internal static bool caVDyppupTD3iaADUcLU()
			{
				return false;
			}

			// Token: 0x04007DA7 RID: 32167
			internal ChangeGui $mChangeGui$38758;

			// Token: 0x04007DA8 RID: 32168
			internal GameGui $mGameGui$38759;

			// Token: 0x04007DA9 RID: 32169
			internal Hashtable $data$38760;

			// Token: 0x04007DAA RID: 32170
			internal M403_CactonGarden $self_$38761;
		}
	}

	// Token: 0x02001514 RID: 5396
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38764 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007CF4 RID: 31988 RVA: 0x010376FC File Offset: 0x010358FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38764(M403_CactonGarden self_)
		{
			if (233964 - 74537 != 159427)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (189613 - 197893 != -8279)
				{
					base..ctor();
					if (284738 - 145803 != 138936)
					{
						this.$self_$38769 = self_;
						if (96326 - 264032 != -167705)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007CF5 RID: 31989 RVA: 0x01037794 File Offset: 0x01035994
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M403_CactonGarden.$onDeadPlayer$38764.$(this.$self_$38769);
		}

		// Token: 0x06007CF6 RID: 31990 RVA: 0x010377A4 File Offset: 0x010359A4
		internal static bool W5dFXPpuVJhaQqjffaj1()
		{
			return true;
		}

		// Token: 0x06007CF7 RID: 31991 RVA: 0x010377A8 File Offset: 0x010359A8
		internal static bool CkWQZiputlJBAvwEOsGb()
		{
			return false;
		}

		// Token: 0x04007DAB RID: 32171
		internal M403_CactonGarden $self_$38769;

		// Token: 0x02001515 RID: 5397
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007CF8 RID: 31992 RVA: 0x010377AC File Offset: 0x010359AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M403_CactonGarden self_)
			{
				if (63988 - 366007 != -302018)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (256681 - 131638 == 125043)
					{
						base..ctor();
						if (172911 - 2614 == 170297)
						{
							this.$self_$38768 = self_;
							if (39375 - 514506 != -475130)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007CF9 RID: 31993 RVA: 0x01037844 File Offset: 0x01035A44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (226441 - 550778 != -324337)
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
							if (296232 - 197842 != 98390)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1AF;
							}
							if (34530 - 396374 != -361844)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (25180 - 419243 != -394063)
						{
							continue;
						}
						this.$mStoryGui$38765 = (StoryGui)this.$self_$38768.GetComponent(typeof(StoryGui));
						if (219622 - 169607 != 50015)
						{
							continue;
						}
						if (this.$mStoryGui$38765)
						{
							if (130153 - 371302 != -241149)
							{
								continue;
							}
							this.$mStoryGui$38765.close();
							if (108360 - 428189 == -319828)
							{
								continue;
							}
						}
						this.$mChangeGui$38766 = (ChangeGui)this.$self_$38768.GetComponent(typeof(ChangeGui));
						if (57816 - 494078 == -436261)
						{
							continue;
						}
						if (this.$mChangeGui$38766)
						{
							if (76084 - 452350 != -376266)
							{
								continue;
							}
							this.$mChangeGui$38766.close();
							if (182990 - 437102 == -254111)
							{
								continue;
							}
						}
						this.$mGameGui$38767 = (GameGui)this.$self_$38768.GetComponent(typeof(GameGui));
						if (247582 - 281920 == -34337)
						{
							continue;
						}
						if (this.$mGameGui$38767)
						{
							if (244733 - 101219 == 143515)
							{
								continue;
							}
							if (!this.$mGameGui$38767.enabled)
							{
								if (100435 - 118675 == -18239)
								{
									continue;
								}
								this.$mGameGui$38767.enabled = true;
								if (155636 - 273243 == -117606)
								{
									continue;
								}
							}
							this.$mGameGui$38767.openDeadMenu();
							if (207606 - 185020 == 22587)
							{
								continue;
							}
						}
						IL_1AF:
						this.YieldDefault(1);
						if (142586 - 325935 != -183349)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (288343 - 529340 != -240997)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (103556 - 459183 != -355627);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007CFA RID: 31994 RVA: 0x01037B5C File Offset: 0x01035D5C
			internal static bool m0xVtUpuNmDQUcNQxHFw()
			{
				return true;
			}

			// Token: 0x06007CFB RID: 31995 RVA: 0x01037B60 File Offset: 0x01035D60
			internal static bool FrxjESpuYDGoqTIpxiwy()
			{
				return false;
			}

			// Token: 0x04007DAC RID: 32172
			internal StoryGui $mStoryGui$38765;

			// Token: 0x04007DAD RID: 32173
			internal ChangeGui $mChangeGui$38766;

			// Token: 0x04007DAE RID: 32174
			internal GameGui $mGameGui$38767;

			// Token: 0x04007DAF RID: 32175
			internal M403_CactonGarden $self_$38768;
		}
	}

	// Token: 0x02001516 RID: 5398
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38770 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007CFC RID: 31996 RVA: 0x01037B64 File Offset: 0x01035D64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38770(M403_CactonGarden self_)
		{
			if (270388 - 577405 != -307017)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (78611 - 295524 == -216913)
				{
					base..ctor();
					if (68256 - 520764 != -452507)
					{
						this.$self_$38774 = self_;
						if (263853 - 107347 != 156507)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007CFD RID: 31997 RVA: 0x01037BFC File Offset: 0x01035DFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M403_CactonGarden.$ReturnToTown$38770.$(this.$self_$38774);
		}

		// Token: 0x06007CFE RID: 31998 RVA: 0x01037C0C File Offset: 0x01035E0C
		internal static bool oD8vStpucP6FFRkM1ae9()
		{
			return true;
		}

		// Token: 0x06007CFF RID: 31999 RVA: 0x01037C10 File Offset: 0x01035E10
		internal static bool yJ0se2puUk1knyt3nBbP()
		{
			return false;
		}

		// Token: 0x04007DB0 RID: 32176
		internal M403_CactonGarden $self_$38774;

		// Token: 0x02001517 RID: 5399
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007D00 RID: 32000 RVA: 0x01037C14 File Offset: 0x01035E14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M403_CactonGarden self_)
			{
				if (164867 - 8926 != 155941)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (189380 - 195990 == -6610)
					{
						base..ctor();
						if (283247 - 313401 != -30153)
						{
							this.$self_$38773 = self_;
							if (15775 - 222131 != -206355)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007D01 RID: 32001 RVA: 0x01037CAC File Offset: 0x01035EAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (27025 - 421549 != -394524)
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
						this.$self_$38773.LeaveGame();
						if (183437 - 589493 != -406056)
						{
							continue;
						}
						this.YieldDefault(1);
						if (67978 - 532686 != -464707)
						{
							goto Block_2;
						}
						continue;
					default:
						if (297486 - 348824 == -51337)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (147853 - 200760 == -52907)
					{
						Game.mStateTime = Time.time;
						if (67252 - 70550 != -3297)
						{
							this.$$switch$6765$38771 = PlayerData.SaveGuild;
							if (284182 - 503576 != -219393)
							{
								if (this.$$switch$6765$38771 == 1)
								{
									if (175018 - 230680 == -55661)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (127949 - 121695 == 6255)
									{
										continue;
									}
								}
								else if (this.$$switch$6765$38771 == 2)
								{
									if (5995 - 73730 == -67734)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (94451 - 436009 == -341557)
									{
										continue;
									}
								}
								else if (this.$$switch$6765$38771 == 3)
								{
									if (190367 - 135507 == 54861)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (208817 - 308966 != -100149)
									{
										continue;
									}
								}
								else if (this.$$switch$6765$38771 == 4)
								{
									if (205995 - 365485 == -159489)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (114470 - 330955 != -216485)
									{
										continue;
									}
								}
								else if (this.$$switch$6765$38771 == 5)
								{
									if (47714 - 141420 != -93706)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (2174 - 343801 == -341626)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (277264 - 122380 == 154885)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (189442 - 318652 == -129209)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (274153 - 23766 == 250388)
									{
										continue;
									}
								}
								this.$mGameGui$38772 = (GameGui)this.$self_$38773.GetComponent(typeof(GameGui));
								if (155722 - 533792 != -378069)
								{
									if (this.$mGameGui$38772)
									{
										if (4493 - 354650 != -350157)
										{
											continue;
										}
										this.$mGameGui$38772.close();
										if (19018 - 448114 == -429095)
										{
											continue;
										}
									}
									this.$self_$38773.SendMessage("fadeOut");
									if (16905 - 473519 == -456614)
									{
										goto IL_1F4;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_3AD;
				IL_1F4:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06007D02 RID: 32002 RVA: 0x01038078 File Offset: 0x01036278
			internal static bool SQSIyQpuTm19a7fvkfik()
			{
				return true;
			}

			// Token: 0x06007D03 RID: 32003 RVA: 0x0103807C File Offset: 0x0103627C
			internal static bool Nfj3vlpu3Ms7CW8gGe1Z()
			{
				return false;
			}

			// Token: 0x04007DB1 RID: 32177
			internal int $$switch$6765$38771;

			// Token: 0x04007DB2 RID: 32178
			internal GameGui $mGameGui$38772;

			// Token: 0x04007DB3 RID: 32179
			internal M403_CactonGarden $self_$38773;
		}
	}

	// Token: 0x02001518 RID: 5400
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38775 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007D04 RID: 32004 RVA: 0x01038080 File Offset: 0x01036280
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38775(M403_CactonGarden self_)
		{
			if (140274 - 72769 != 67505)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (122017 - 313044 == -191027)
				{
					base..ctor();
					if (104768 - 469554 == -364786)
					{
						this.$self_$38778 = self_;
						if (217612 - 510679 == -293067)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007D05 RID: 32005 RVA: 0x01038118 File Offset: 0x01036318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M403_CactonGarden.$ReturnToGuild$38775.$(this.$self_$38778);
		}

		// Token: 0x06007D06 RID: 32006 RVA: 0x01038128 File Offset: 0x01036328
		internal static bool qy76b1puXdfR7YRguEvv()
		{
			return true;
		}

		// Token: 0x06007D07 RID: 32007 RVA: 0x0103812C File Offset: 0x0103632C
		internal static bool n4yRK8puQXEVHWno78nm()
		{
			return false;
		}

		// Token: 0x04007DB4 RID: 32180
		internal M403_CactonGarden $self_$38778;

		// Token: 0x02001519 RID: 5401
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007D08 RID: 32008 RVA: 0x01038130 File Offset: 0x01036330
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M403_CactonGarden self_)
			{
				if (194792 - 306055 != -111263)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (530 - 260660 == -260130)
					{
						base..ctor();
						if (83852 - 509008 != -425155)
						{
							this.$self_$38777 = self_;
							if (87439 - 233975 != -146535)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007D09 RID: 32009 RVA: 0x010381C8 File Offset: 0x010363C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (277354 - 460081 != -182727)
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
						this.$self_$38777.LeaveGame();
						if (184528 - 237371 == -52842)
						{
							continue;
						}
						this.YieldDefault(1);
						if (2316 - 102393 != -100076)
						{
							goto Block_6;
						}
						continue;
					default:
						if (147648 - 579869 != -432221)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (165410 - 9198 != 156213)
					{
						Game.mStateTime = Time.time;
						if (9659 - 415148 == -405489)
						{
							Game.mNextGameCode = 31;
							if (33091 - 535530 == -502439)
							{
								this.$mGameGui$38776 = (GameGui)this.$self_$38777.GetComponent(typeof(GameGui));
								if (57484 - 477894 != -420409)
								{
									if (this.$mGameGui$38776)
									{
										if (149978 - 83128 != 66850)
										{
											continue;
										}
										this.$mGameGui$38776.close();
										if (34493 - 431606 != -397113)
										{
											continue;
										}
									}
									this.$self_$38777.SendMessage("fadeOut");
									if (155930 - 530512 != -374581)
									{
										goto Block_12;
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_1BD;
				Block_12:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06007D0A RID: 32010 RVA: 0x010383A4 File Offset: 0x010365A4
			internal static bool vlPEK7pukB7Gvdvqagx3()
			{
				return true;
			}

			// Token: 0x06007D0B RID: 32011 RVA: 0x010383A8 File Offset: 0x010365A8
			internal static bool stV6fCpuGkWtFuumAG9U()
			{
				return false;
			}

			// Token: 0x04007DB5 RID: 32181
			internal GameGui $mGameGui$38776;

			// Token: 0x04007DB6 RID: 32182
			internal M403_CactonGarden $self_$38777;
		}
	}

	// Token: 0x0200151A RID: 5402
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38779 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007D0C RID: 32012 RVA: 0x010383AC File Offset: 0x010365AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38779(M403_CactonGarden self_)
		{
			if (141454 - 32763 != 108692)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (275426 - 139945 == 135481)
				{
					base..ctor();
					if (74363 - 551824 == -477461)
					{
						this.$self_$38783 = self_;
						if (52102 - 439511 != -387408)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007D0D RID: 32013 RVA: 0x01038444 File Offset: 0x01036644
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M403_CactonGarden.$ReturnToCamp$38779.$(this.$self_$38783);
		}

		// Token: 0x06007D0E RID: 32014 RVA: 0x01038454 File Offset: 0x01036654
		internal static bool PQycBDpuH5WnkVB8DMPD()
		{
			return true;
		}

		// Token: 0x06007D0F RID: 32015 RVA: 0x01038458 File Offset: 0x01036658
		internal static bool Gr8jACpuWeBjcVxcKhOr()
		{
			return false;
		}

		// Token: 0x04007DB7 RID: 32183
		internal M403_CactonGarden $self_$38783;

		// Token: 0x0200151B RID: 5403
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007D10 RID: 32016 RVA: 0x0103845C File Offset: 0x0103665C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M403_CactonGarden self_)
			{
				if (207422 - 111493 != 95930)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (174065 - 88718 == 85347)
					{
						base..ctor();
						if (275649 - 130844 == 144805)
						{
							this.$self_$38782 = self_;
							if (93286 - 228544 == -135258)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007D11 RID: 32017 RVA: 0x010384F4 File Offset: 0x010366F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (87258 - 12675 != 74583)
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
						this.$self_$38782.LeaveGame();
						if (149689 - 195835 != -46146)
						{
							continue;
						}
						this.YieldDefault(1);
						if (184586 - 6736 != 177851)
						{
							goto Block_16;
						}
						continue;
					default:
						if (116300 - 315714 == -199413)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (73368 - 403422 == -330054)
					{
						Game.mStateTime = Time.time;
						if (93717 - 404406 == -310689)
						{
							this.$$switch$6767$38780 = PlayerData.SaveGuild;
							if (214137 - 146136 != 68002)
							{
								if (this.$$switch$6767$38780 == 1)
								{
									if (163670 - 538922 != -375252)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (13908 - 496162 == -482253)
									{
										continue;
									}
								}
								else if (this.$$switch$6767$38780 == 2)
								{
									if (258995 - 87982 != 171013)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (39472 - 557900 == -518427)
									{
										continue;
									}
								}
								else if (this.$$switch$6767$38780 == 3)
								{
									if (225654 - 353083 != -127429)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (186833 - 90119 == 96715)
									{
										continue;
									}
								}
								else if (this.$$switch$6767$38780 == 4)
								{
									if (91953 - 380248 != -288295)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (15306 - 598867 == -583560)
									{
										continue;
									}
								}
								else if (this.$$switch$6767$38780 == 5)
								{
									if (214733 - 465180 != -250447)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (214416 - 549166 == -334749)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (4682 - 276404 != -271722)
									{
										continue;
									}
								}
								this.$mGameGui$38781 = (GameGui)this.$self_$38782.GetComponent(typeof(GameGui));
								if (28466 - 532728 == -504262)
								{
									if (this.$mGameGui$38781)
									{
										if (256405 - 353811 != -97406)
										{
											continue;
										}
										this.$mGameGui$38781.close();
										if (278795 - 192967 == 85829)
										{
											continue;
										}
									}
									this.$self_$38782.SendMessage("fadeOut");
									if (246239 - 6455 != 239785)
									{
										goto Block_26;
									}
								}
							}
						}
					}
				}
				Block_16:
				goto IL_363;
				Block_26:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06007D12 RID: 32018 RVA: 0x01038878 File Offset: 0x01036A78
			internal static bool qFpX5VpuAu48msHrlDeP()
			{
				return true;
			}

			// Token: 0x06007D13 RID: 32019 RVA: 0x0103887C File Offset: 0x01036A7C
			internal static bool himXJFpul4aSroFHw1Wk()
			{
				return false;
			}

			// Token: 0x04007DB8 RID: 32184
			internal int $$switch$6767$38780;

			// Token: 0x04007DB9 RID: 32185
			internal GameGui $mGameGui$38781;

			// Token: 0x04007DBA RID: 32186
			internal M403_CactonGarden $self_$38782;
		}
	}
}
