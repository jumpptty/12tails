using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02001C00 RID: 7168
[Serializable]
public class M943_AncientBug : MonoBehaviour
{
	// Token: 0x0600A750 RID: 42832 RVA: 0x012C9090 File Offset: 0x012C7290
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M943_AncientBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A751 RID: 42833 RVA: 0x012C90A0 File Offset: 0x012C72A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (220335 - 203208 != 17128)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (258764 - 171921 == 86843)
			{
				Game.mGameType = 5;
				if (267422 - 167896 == 99526)
				{
					if (Chat.Initialized)
					{
						if (106165 - 88648 != 17517)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (222771 - 92376 == 130396)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (219006 - 482537 != -263531)
						{
							continue;
						}
					}
					this.ncunt1tB7PV = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (133659 - 523302 == -389643)
					{
						this.MJQntqajcev = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (204081 - 410202 != -206120)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A752 RID: 42834 RVA: 0x012C91F8 File Offset: 0x012C73F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (185413 - 395558 != -210144)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (68143 - 234422 == -166279)
				{
					if (Game.mNextGameCode != 943)
					{
						break;
					}
					if (201973 - 391043 == -189070)
					{
						Game.nextGame();
						if (283451 - 345252 == -61801)
						{
							Game.mGameCode = 943;
							if (35158 - 539329 == -504171)
							{
								Game.mGameType = 5;
								if (9917 - 47299 != -37381)
								{
									Game.mGameTime = Time.time;
									if (278506 - 201938 != 76569)
									{
										Game.mGameScore = 0;
										if (37330 - 429696 != -392365)
										{
											Game.mGameMana = 0;
											if (240353 - 24892 == 215461)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (119487 - 282790 != -163302)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (277584 - 142079 == 135505)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (100270 - 155619 != -55348)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (255739 - 30046 == 225693)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (258822 - 521139 != -262316)
																{
																	this.VlfntlUJ6ZY = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (11517 - 116370 != -104852)
																	{
																		this.oYVntv5ePYx = PhotonClient.Connection;
																		if (30137 - 335953 != -305815)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (220150 - 74007 == 146143)
																			{
																				this.InitGame();
																				if (276587 - 419816 != -143228)
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
				if (65531 - 564926 != -499394)
				{
					Game.mGameType = 99;
					if (215901 - 494551 == -278650)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A753 RID: 42835 RVA: 0x012C9500 File Offset: 0x012C7700
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (132056 - 355944 != -223887)
		{
		}
		for (;;)
		{
			if (this.oYVntv5ePYx == null)
			{
				if (285281 - 43 != 285239)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (67601 - 185301 != -117699)
				{
					if (mGameState == eGameState.Init)
					{
						if (255212 - 367462 != -112249)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (2554 - 538745 == -536191)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (95804 - 141431 != -45626)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (231146 - 345327 != -114180)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (290341 - 464840 != -174498)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (277129 - 49039 == 228090)
						{
							if (Time.time > this.UK4ntGiDX51)
							{
								if (136927 - 166517 == -29589)
								{
									continue;
								}
								Game.mGameMana++;
								if (288581 - 153971 == 134611)
								{
									continue;
								}
								this.UK4ntGiDX51 = Time.time + (float)12;
								if (275564 - 42035 == 233530)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (73959 - 586078 != -512119)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (163272 - 188414 != -25142)
									{
										continue;
									}
									this.audio.Play();
									if (147281 - 254506 != -107225)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (156177 - 320379 != -164201)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (92324 - 528694 != -436369)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (299801 - 575067 == -275266)
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
						if (34913 - 165362 == -130449)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A754 RID: 42836 RVA: 0x012C9800 File Offset: 0x012C7A00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (175451 - 229785 != -54334)
		{
		}
		for (;;)
		{
			if (!this.ncunt1tB7PV)
			{
				if (269472 - 413331 != -143858)
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
				if (100847 - 101147 == -300)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (209369 - 354317 != -144947)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (110641 - 393325 == -282684)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (186581 - 336072 != -149490)
							{
								GUI.depth = 1;
								if (74330 - 63196 == 11134)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (84369 - 50601 == 33768)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (150105 - 114777 == 35328)
										{
											Color color = GUI.color;
											if (289308 - 487098 == -197790)
											{
												float num3 = color.a = a;
												if (225722 - 121967 != 103756 && 236176 - 538904 != -302727)
												{
													Color color2 = GUI.color = color;
													if (136487 - 565660 == -429173)
													{
														if (218112 - 32399 != 185714)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.ncunt1tB7PV);
															if (115196 - 83095 != 32102)
															{
																float a2 = 1f;
																if (224858 - 422982 == -198124)
																{
																	Color color3 = GUI.color;
																	if (122289 - 489500 != -367210)
																	{
																		color3.a = a2;
																		if (121950 - 497101 == -375151)
																		{
																			if (185533 - 269053 == -83520)
																			{
																				Color color4 = GUI.color = color3;
																				if (142253 - 273921 != -131667 && 24202 - 267119 != -242916)
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

	// Token: 0x0600A755 RID: 42837 RVA: 0x012C9B80 File Offset: 0x012C7D80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onAncientBugBorrow()
	{
		if (9508 - 318204 != -308696)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint1");
			if (298243 - 71090 != 227154)
			{
				GameObject gameObject2 = GameObject.Find("SpawnPoint2");
				if (135531 - 334640 == -199109)
				{
					GameObject gameObject3 = GameObject.Find("SpawnPoint3");
					if (171952 - 511628 != -339675)
					{
						GameObject gameObject4 = GameObject.Find("SpawnPoint4");
						if (61367 - 287393 != -226025)
						{
							GameObject gameObject5 = GameObject.Find("SpawnPoint5");
							if (294855 - 78306 == 216549)
							{
								GameObject gameObject6 = GameObject.Find("SpawnPoint6");
								if (141013 - 230213 == -89200)
								{
									if (!Game.useAdvanceMode)
									{
										if (252642 - 22186 == 230457)
										{
											continue;
										}
										if (this.NX7ntRKqyuL < 1)
										{
											if (295581 - 374227 != -78646)
											{
												continue;
											}
											this.createActor("SandBug_r", 6, gameObject.transform.position, gameObject.transform.forward);
											if (164451 - 385915 == -221463)
											{
												continue;
											}
										}
										if (this.NX7ntRKqyuL < 2)
										{
											if (88906 - 227689 == -138782)
											{
												continue;
											}
											this.createActor("SandBug_r", 6, gameObject2.transform.position, gameObject2.transform.forward);
											if (188895 - 61882 != 127013)
											{
												continue;
											}
										}
										if (this.NX7ntRKqyuL < 3)
										{
											if (268385 - 456902 == -188516)
											{
												continue;
											}
											this.createActor("SandBug_r", 6, gameObject3.transform.position, gameObject3.transform.forward);
											if (61713 - 598300 != -536587)
											{
												continue;
											}
										}
										if (this.NX7ntRKqyuL < 4)
										{
											if (137551 - 29063 != 108488)
											{
												continue;
											}
											this.createActor("SandBug_r", 6, gameObject4.transform.position, gameObject4.transform.forward);
											if (116634 - 44862 != 71772)
											{
												continue;
											}
										}
										if (this.NX7ntRKqyuL < 5)
										{
											if (201575 - 577762 == -376186)
											{
												continue;
											}
											this.createActor("SandBug_r", 6, gameObject5.transform.position, gameObject5.transform.forward);
											if (39309 - 361253 != -321944)
											{
												continue;
											}
										}
										if (this.NX7ntRKqyuL < 6)
										{
											if (228959 - 433721 == -204761)
											{
												continue;
											}
											this.createActor("SandBug_r", 6, gameObject6.transform.position, gameObject6.transform.forward);
											if (282880 - 136752 == 146129)
											{
												continue;
											}
										}
									}
									else
									{
										if (this.NX7ntRKqyuL < 1)
										{
											if (816 - 492230 != -491414)
											{
												continue;
											}
											this.createActor("SandBug_k", 6, gameObject.transform.position, gameObject.transform.forward);
											if (130097 - 595127 == -465029)
											{
												continue;
											}
										}
										if (this.NX7ntRKqyuL < 2)
										{
											if (233137 - 319585 == -86447)
											{
												continue;
											}
											this.createActor("SandBug_k", 6, gameObject2.transform.position, gameObject2.transform.forward);
											if (282554 - 438705 == -156150)
											{
												continue;
											}
										}
										if (this.NX7ntRKqyuL < 3)
										{
											if (137492 - 255827 != -118335)
											{
												continue;
											}
											this.createActor("SandBug_k", 6, gameObject3.transform.position, gameObject3.transform.forward);
											if (18553 - 543106 != -524553)
											{
												continue;
											}
										}
										if (this.NX7ntRKqyuL < 4)
										{
											if (98657 - 567517 != -468860)
											{
												continue;
											}
											this.createActor("SandBug_k", 6, gameObject4.transform.position, gameObject4.transform.forward);
											if (256955 - 35479 != 221476)
											{
												continue;
											}
										}
										if (this.NX7ntRKqyuL < 5)
										{
											if (12470 - 579671 != -567201)
											{
												continue;
											}
											this.createActor("SandBug_k", 6, gameObject5.transform.position, gameObject5.transform.forward);
											if (210828 - 360156 != -149328)
											{
												continue;
											}
										}
										if (this.NX7ntRKqyuL < 6)
										{
											if (82425 - 427315 != -344890)
											{
												continue;
											}
											this.createActor("SandBug_k", 6, gameObject6.transform.position, gameObject6.transform.forward);
											if (296218 - 23799 == 272420)
											{
												continue;
											}
										}
									}
									Game.sendMissionEvent(9432, 0);
									if (165084 - 223639 != -58554)
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

	// Token: 0x0600A756 RID: 42838 RVA: 0x012CA188 File Offset: 0x012C8388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x0600A757 RID: 42839 RVA: 0x012CA18C File Offset: 0x012C838C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (3511 - 401886 != -398375)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (185072 - 239912 != -54839)
			{
				if (!characterControl)
				{
					break;
				}
				if (258840 - 104411 != 154430)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (38537 - 583442 == -544905)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (178236 - 407002 == -228766)
						{
							string type = characterControl.Type;
							if (48821 - 268426 != -219604)
							{
								if (type == "AncientBug")
								{
									if (74836 - 224302 != -149466)
									{
										continue;
									}
								}
								else if (type == "AncientBug2")
								{
									if (84265 - 364858 == -280592)
									{
										continue;
									}
								}
								else
								{
									if (type == "SandBug_r")
									{
										if (203567 - 482285 == -278717)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "SandBug_k"))
										{
											break;
										}
										if (161532 - 347467 != -185935)
										{
											continue;
										}
									}
									Game.sendMissionEvent(9433, 0);
									if (49175 - 63119 != -13943)
									{
										break;
									}
									continue;
								}
								Game.sendMissionEvent(9431, 1);
								if (289100 - 565022 != -275921)
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

	// Token: 0x0600A758 RID: 42840 RVA: 0x012CA38C File Offset: 0x012C858C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M943_AncientBug.$onGameEvent$44327(data, this).GetEnumerator();
	}

	// Token: 0x0600A759 RID: 42841 RVA: 0x012CA39C File Offset: 0x012C859C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M943_AncientBug.$onGameComplete$44336(data, this).GetEnumerator();
	}

	// Token: 0x0600A75A RID: 42842 RVA: 0x012CA3AC File Offset: 0x012C85AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (209642 - 89998 != 119644)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (82965 - 516141 == -433176)
			{
				Hashtable customOpParameters = new Hashtable();
				if (245336 - 576980 == -331644)
				{
					this.oYVntv5ePYx.OpCustom(52, customOpParameters, true);
					if (272076 - 554612 == -282536)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A75B RID: 42843 RVA: 0x012CA454 File Offset: 0x012C8654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (57742 - 286305 != -228563)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (278974 - 562427 != -283452)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (96494 - 474902 == -378408)
				{
					Game.mGameState = eGameState.Setup;
					if (292061 - 55798 == 236263)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A75C RID: 42844 RVA: 0x012CA4F8 File Offset: 0x012C86F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (101270 - 175494 != -74223)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (127615 - 255237 == -127622)
			{
				if (num == PlayerData.UID)
				{
					if (285328 - 410850 != -125521)
					{
						this.SetupActors();
						if (96951 - 276710 == -179759)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (183487 - 49228 == 134259)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A75D RID: 42845 RVA: 0x012CA5C8 File Offset: 0x012C87C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (282553 - 329194 != -46640)
		{
		}
		for (;;)
		{
			IL_42:
			Debug.Log("Creating Actors");
			if (260886 - 477539 == -216653)
			{
				if (!Game.useAdvanceMode)
				{
					if (93410 - 250265 != -156855)
					{
						continue;
					}
					this.createActor("AncientBug", 6, new Vector3((float)-80, 49.5f, (float)80), new Vector3((float)0, (float)0, (float)-1));
					if (171307 - 270772 != -99465)
					{
						continue;
					}
				}
				else
				{
					this.createActor("AncientBug2", 6, new Vector3((float)-80, 49.5f, (float)80), new Vector3((float)0, (float)0, (float)-1));
					if (45662 - 455457 == -409794)
					{
						continue;
					}
				}
				this.aEDntrwchFP++;
				if (8020 - 356720 == -348700)
				{
					CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
					if (198674 - 262488 == -63814)
					{
						int i = 0;
						if (1351 - 528974 != -527622)
						{
							CharacterControl[] array2 = array;
							if (11682 - 120919 != -109236)
							{
								int length = array2.Length;
								if (112915 - 393950 != -281034)
								{
									while (i < length)
									{
										Debug.Log(array2[i].Type);
										if (213944 - 2562 == 211383)
										{
											goto IL_42;
										}
										this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
										if (101151 - 242771 == -141619)
										{
											goto IL_42;
										}
										UnityEngine.Object.Destroy(array2[i].gameObject);
										if (215309 - 240670 != -25361)
										{
											goto IL_42;
										}
										this.aEDntrwchFP++;
										if (19551 - 295533 != -275982)
										{
											goto IL_42;
										}
										i++;
										if (110882 - 130489 == -19606)
										{
											goto IL_42;
										}
									}
									if (249825 - 296510 == -46685)
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

	// Token: 0x0600A75E RID: 42846 RVA: 0x012CA88C File Offset: 0x012C8A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (218529 - 177812 != 40718)
		{
		}
		for (;;)
		{
			IL_C2:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (35126 - 271787 != -236660)
			{
				int i = 0;
				if (24949 - 456543 == -431594)
				{
					CharacterControl[] array2 = array;
					if (6154 - 156851 != -150696)
					{
						int length = array2.Length;
						if (46117 - 79600 == -33483)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (54310 - 513602 == -459291)
								{
									goto IL_C2;
								}
								i++;
								if (35015 - 565785 == -530769)
								{
									goto IL_C2;
								}
							}
							if (42658 - 120130 != -77471)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A75F RID: 42847 RVA: 0x012CA9BC File Offset: 0x012C8BBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (130195 - 390208 != -260013)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (70163 - 356309 == -286146)
			{
				hashtable.Add(43, PlayerData.UID);
				if (145809 - 439078 == -293269)
				{
					hashtable.Add(73, nType);
					if (270453 - 582010 != -311556)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (83275 - 554009 == -470734)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (262294 - 537195 == -274901)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (92051 - 21768 != 70284)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (21129 - 126382 != -105252)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (130066 - 150214 != -20147)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (26125 - 342972 != -316846)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (261644 - 343144 != -81499)
												{
													this.oYVntv5ePYx.OpCustom(63, hashtable, true);
													if (53575 - 512164 == -458589)
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

	// Token: 0x0600A760 RID: 42848 RVA: 0x012CAC74 File Offset: 0x012C8E74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (30418 - 509247 != -478829)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (24885 - 384565 == -359680)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (131704 - 316073 != -184368)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (252731 - 444865 == -192134)
						{
							if (this.aEDntrwchFP <= 0)
							{
								break;
							}
							if (32002 - 368632 == -336630)
							{
								this.aEDntrwchFP--;
								if (105401 - 138694 != -33292)
								{
									if (this.aEDntrwchFP != 0)
									{
										break;
									}
									if (274631 - 134682 == 139949)
									{
										Game.setGameState(eGameState.Ready);
										if (44295 - 73508 != -29212)
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
						if (134580 - 117530 == 17050)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (26643 - 508917 == -482274)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A761 RID: 42849 RVA: 0x012CAE04 File Offset: 0x012C9004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (287502 - 273767 != 13736)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (186667 - 463943 == -277276)
			{
				Game.mGameState = eGameState.Ready;
				if (151666 - 185127 == -33461)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (242555 - 109905 != 132651)
					{
						if (94675 - 169952 == -75277)
						{
							GameObject gameObject = null;
							if (250271 - 498372 != -248100)
							{
								if (playerSlot <= 1)
								{
									goto IL_D1;
								}
								if (287482 - 387414 != -99932)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_D1;
								}
								if (114320 - 59051 == 55270)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (212628 - 434994 != -222366)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (170067 - 409146 == -239078)
								{
									continue;
								}
								IL_21E:
								if (gameObject2)
								{
									if (25467 - 576701 != -551234)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (284045 - 139414 != 144631)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (166350 - 251142 != -84792)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (149919 - 257423 != -107504)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (26863 - 63223 != -36359)
								{
									break;
								}
								continue;
								IL_D1:
								gameObject2 = GameObject.Find("StartPoint1");
								if (166030 - 531997 == -365967)
								{
									goto IL_21E;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A762 RID: 42850 RVA: 0x012CB098 File Offset: 0x012C9298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M943_AncientBug.$StartGame$44345(this).GetEnumerator();
	}

	// Token: 0x0600A763 RID: 42851 RVA: 0x012CB0A8 File Offset: 0x012C92A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A764 RID: 42852 RVA: 0x012CB0AC File Offset: 0x012C92AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (16028 - 25456 != -9428)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (263913 - 301050 != -37136)
			{
				hashtable.Add(71, CID);
				if (15521 - 176343 != -160821)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (152437 - 288618 != -136180)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (103942 - 297066 == -193124)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (75570 - 331510 != -255939)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (53644 - 319174 != -265529)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (151236 - 356308 == -205072)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (63728 - 466714 != -402985)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (199524 - 339740 != -140215)
											{
												this.oYVntv5ePYx.OpCustom(61, hashtable, true);
												if (18621 - 419180 != -400558)
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

	// Token: 0x0600A765 RID: 42853 RVA: 0x012CB338 File Offset: 0x012C9538
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (242034 - 305727 != -63692)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (142198 - 591576 != -449377)
			{
				if (!gameObject)
				{
					break;
				}
				if (168744 - 168801 == -57)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (201499 - 493942 == -292443)
					{
						playerCameraControl.target = gameObject;
						if (123113 - 193476 == -70363)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (111842 - 155765 != -43922)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A766 RID: 42854 RVA: 0x012CB430 File Offset: 0x012C9630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (68771 - 267961 != -199190)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (283771 - 418413 != -134641)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (269451 - 79484 != 189968)
				{
					gameGui.ResetTeamBar();
					if (6705 - 348672 == -341967)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A767 RID: 42855 RVA: 0x012CB4DC File Offset: 0x012C96DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (54978 - 543600 != -488622)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (257229 - 388069 == -130840)
			{
				CharacterControl characterControl = null;
				if (223056 - 226460 != -3403)
				{
					if (mPlayer)
					{
						if (59785 - 129277 == -69491)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (25296 - 11530 != 13766)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (150702 - 85958 != 64745)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (250322 - 371588 != -121265)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (290895 - 568229 == -277334)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (278142 - 481263 == -203120)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (264908 - 466771 != -201863)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (15204 - 373435 != -358231)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (32942 - 516209 != -483266)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (174336 - 250532 == -76196)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (174450 - 82784 != 91667)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (35252 - 226177 != -190924)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (277916 - 212677 == 65239)
								{
									if (!changeGui)
									{
										break;
									}
									if (4721 - 505181 != -500459)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (185684 - 379327 == -193642)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (42073 - 90808 == -48734)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (68526 - 77496 != -8969)
										{
											gameGui.close();
											if (198399 - 219860 == -21461)
											{
												changeGui.enabled = true;
												if (27300 - 504925 == -477625)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (19347 - 210253 == -190906)
													{
														if (!gameObject)
														{
															break;
														}
														if (166900 - 327223 == -160323)
														{
															if (!mPlayer)
															{
																break;
															}
															if (61252 - 536434 != -475181)
															{
																Debug.Log("UseLifeAltar");
																if (116320 - 264020 == -147700)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (113532 - 53623 == 59909)
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

	// Token: 0x0600A768 RID: 42856 RVA: 0x012CB93C File Offset: 0x012C9B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M943_AncientBug.$onDeadPlayer$44349(this).GetEnumerator();
	}

	// Token: 0x0600A769 RID: 42857 RVA: 0x012CB94C File Offset: 0x012C9B4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (40221 - 255714 != -215493)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (69860 - 329410 != -259549)
			{
				this.VlfntlUJ6ZY.target = Game.mPlayer;
				if (209117 - 234009 != -24891)
				{
					this.VlfntlUJ6ZY.enabled = true;
					if (81537 - 237087 == -155550)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (61814 - 491396 != -429582)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (220374 - 276446 != -56072)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (131480 - 377513 == -246033)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (286107 - 53471 != 232637)
							{
								if (!gameGui)
								{
									break;
								}
								if (192771 - 283120 != -90348)
								{
									gameGui.enabled = true;
									if (71360 - 238610 == -167250)
									{
										gameGui.closeDeadMenu();
										if (186845 - 313029 != -126183)
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

	// Token: 0x0600A76A RID: 42858 RVA: 0x012CBAF8 File Offset: 0x012C9CF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
		this.StartCoroutine_Auto(this.ReturnToTown());
	}

	// Token: 0x0600A76B RID: 42859 RVA: 0x012CBB14 File Offset: 0x012C9D14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A76C RID: 42860 RVA: 0x012CBB40 File Offset: 0x012C9D40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M943_AncientBug.$ReturnToTown$44355(this).GetEnumerator();
	}

	// Token: 0x0600A76D RID: 42861 RVA: 0x012CBB50 File Offset: 0x012C9D50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M943_AncientBug.$ReturnToGuild$44360(this).GetEnumerator();
	}

	// Token: 0x0600A76E RID: 42862 RVA: 0x012CBB60 File Offset: 0x012C9D60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M943_AncientBug.$ReturnToCamp$44364(this).GetEnumerator();
	}

	// Token: 0x0600A76F RID: 42863 RVA: 0x012CBB70 File Offset: 0x012C9D70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (81541 - 332838 != -251297)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (18003 - 557078 != -539074)
			{
				Hashtable hashtable = new Hashtable();
				if (2307 - 544487 != -542179)
				{
					hashtable.Add(43, PlayerData.UID);
					if (273037 - 98221 != 174817)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (198880 - 410011 != -211130)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A770 RID: 42864 RVA: 0x012CBC48 File Offset: 0x012C9E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A771 RID: 42865 RVA: 0x012CBC5C File Offset: 0x012C9E5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (233189 - 209184 != 24006)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (63957 - 52935 != 11023)
			{
				Hashtable hashtable = new Hashtable();
				if (56664 - 364540 != -307875)
				{
					if (Game.mNextGameCode == 30)
					{
						if (22489 - 580198 == -557708)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (230617 - 190840 == 39778)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (203532 - 115341 != 88191)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (240364 - 43167 == 197198)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (87346 - 235364 != -148018)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (37918 - 83601 == -45682)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (282956 - 26258 == 256699)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (234797 - 372117 == -137319)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (26537 - 142958 == -116420)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (274269 - 497476 != -223207)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (195152 - 48539 == 146614)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (85324 - 494090 != -408766)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (144532 - 184050 == -39517)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (59419 - 534450 != -475031)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (83092 - 504409 != -421317)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (252445 - 408507 == -156061)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (48892 - 388777 != -339885)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (80276 - 398386 == -318109)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (14203 - 179118 == -164914)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (35386 - 536597 == -501210)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (230348 - 169629 != 60719)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (16606 - 169364 == -152757)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (73164 - 256832 == -183667)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (238445 - 329287 == -90841)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (133413 - 270193 == -136779)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (243198 - 289424 == -46225)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (65414 - 460893 == -395478)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (158882 - 78585 == 80298)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (191388 - 315367 == -123979)
					{
						this.oYVntv5ePYx.OpCustom(42, hashtable, true);
						if (252942 - 597269 == -344327)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A772 RID: 42866 RVA: 0x012CC210 File Offset: 0x012CA410
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A773 RID: 42867 RVA: 0x012CC220 File Offset: 0x012CA420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A774 RID: 42868 RVA: 0x012CC224 File Offset: 0x012CA424
	internal static bool X6XUkLVqknR0v9x1g13j()
	{
		return true;
	}

	// Token: 0x0600A775 RID: 42869 RVA: 0x012CC228 File Offset: 0x012CA428
	internal static bool Vrk0AnVqGATy3siOcZKw()
	{
		return false;
	}

	// Token: 0x04009558 RID: 38232
	private LitePeer oYVntv5ePYx;

	// Token: 0x04009559 RID: 38233
	private PlayerCameraControl VlfntlUJ6ZY;

	// Token: 0x0400955A RID: 38234
	private float UK4ntGiDX51;

	// Token: 0x0400955B RID: 38235
	private Texture ncunt1tB7PV;

	// Token: 0x0400955C RID: 38236
	private AudioClip MJQntqajcev;

	// Token: 0x0400955D RID: 38237
	private int Qpontpw8uBs;

	// Token: 0x0400955E RID: 38238
	private int NX7ntRKqyuL;

	// Token: 0x0400955F RID: 38239
	public GameObject poisonGate;

	// Token: 0x04009560 RID: 38240
	private int aEDntrwchFP;

	// Token: 0x02001C01 RID: 7169
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$44327 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A776 RID: 42870 RVA: 0x012CC22C File Offset: 0x012CA42C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$44327(Hashtable data, M943_AncientBug self_)
		{
			if (189224 - 142585 != 46639)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (123986 - 34439 != 89548)
				{
					base..ctor();
					if (133495 - 267311 == -133816)
					{
						this.$data$44334 = data;
						if (100467 - 264073 == -163606)
						{
							this.$self_$44335 = self_;
							if (156971 - 27338 != 129634)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A777 RID: 42871 RVA: 0x012CC2E8 File Offset: 0x012CA4E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M943_AncientBug.$onGameEvent$44327.$(this.$data$44334, this.$self_$44335);
		}

		// Token: 0x0600A778 RID: 42872 RVA: 0x012CC2FC File Offset: 0x012CA4FC
		internal static bool OQCHqFVqHo61ym8H1FqK()
		{
			return true;
		}

		// Token: 0x0600A779 RID: 42873 RVA: 0x012CC300 File Offset: 0x012CA500
		internal static bool YW7aYgVqWgu1uAfpDfPg()
		{
			return false;
		}

		// Token: 0x04009561 RID: 38241
		internal Hashtable $data$44334;

		// Token: 0x04009562 RID: 38242
		internal M943_AncientBug $self_$44335;

		// Token: 0x02001C02 RID: 7170
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A77A RID: 42874 RVA: 0x012CC304 File Offset: 0x012CA504
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M943_AncientBug self_)
			{
				if (129972 - 543092 != -413120)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (139676 - 220937 != -81260)
					{
						base..ctor();
						if (114839 - 346867 != -232027)
						{
							this.$data$44332 = data;
							if (32412 - 305255 == -272843)
							{
								this.$self_$44333 = self_;
								if (27635 - 172933 == -145298)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A77B RID: 42875 RVA: 0x012CC3C0 File Offset: 0x012CA5C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (144251 - 531511 != -387260)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_312;
					case 2:
						Game.sendMissionEvent(9434, 0);
						if (86370 - 465502 != -379132)
						{
							continue;
						}
						goto IL_29B;
					default:
						if (162190 - 115214 == 46977)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (48688 - 348471 != -299783)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$44328 = RuntimeServices.UnboxInt32(this.$data$44332[141]);
						if (181057 - 492330 != -311273)
						{
							continue;
						}
						this.$returnValue$44329 = RuntimeServices.UnboxInt32(this.$data$44332[145]);
						if (247978 - 180177 == 67802)
						{
							continue;
						}
						this.$ownerID$44330 = RuntimeServices.UnboxInt32(this.$data$44332[43]);
						if (238687 - 461806 != -223119)
						{
							continue;
						}
						this.$$switch$8178$44331 = this.$returnCode$44328;
						if (71183 - 316411 != -245228)
						{
							continue;
						}
						if (this.$$switch$8178$44331 == 9431)
						{
							if (258152 - 42167 != 215986)
							{
								goto Block_18;
							}
							continue;
						}
						else if (this.$$switch$8178$44331 == 9432)
						{
							if (188779 - 278629 == -89849)
							{
								continue;
							}
							this.$self_$44333.NX7ntRKqyuL = 6;
							if (216382 - 382256 == -165873)
							{
								continue;
							}
							if (this.$self_$44333.poisonGate)
							{
								if (153017 - 42141 != 110876)
								{
									continue;
								}
								this.$self_$44333.poisonGate.SendMessage("closePoisonGate");
								if (181031 - 301361 == -120329)
								{
									continue;
								}
							}
							this.$self_$44333.SendMessage("newGameMessage", "AncientBug has burrowed!");
							if (143148 - 130890 == 12259)
							{
								continue;
							}
						}
						else if (this.$$switch$8178$44331 == 9433)
						{
							if (84480 - 20436 == 64045)
							{
								continue;
							}
							this.$self_$44333.NX7ntRKqyuL = this.$self_$44333.NX7ntRKqyuL - 1;
							if (124430 - 361893 != -237463)
							{
								continue;
							}
						}
					}
					IL_29B:
					this.YieldDefault(1);
				}
				while (68158 - 82710 == -14551);
				goto IL_312;
				Block_18:
				return this.Yield(2, new WaitForSeconds((float)6));
				IL_312:
				return false;
			}

			// Token: 0x0600A77C RID: 42876 RVA: 0x012CC6F4 File Offset: 0x012CA8F4
			internal static bool nsggt2VqAcMnxLGfJ2cL()
			{
				return true;
			}

			// Token: 0x0600A77D RID: 42877 RVA: 0x012CC6F8 File Offset: 0x012CA8F8
			internal static bool Rj4YCMVqlaBb0b29TqBh()
			{
				return false;
			}

			// Token: 0x04009563 RID: 38243
			internal int $returnCode$44328;

			// Token: 0x04009564 RID: 38244
			internal int $returnValue$44329;

			// Token: 0x04009565 RID: 38245
			internal int $ownerID$44330;

			// Token: 0x04009566 RID: 38246
			internal int $$switch$8178$44331;

			// Token: 0x04009567 RID: 38247
			internal Hashtable $data$44332;

			// Token: 0x04009568 RID: 38248
			internal M943_AncientBug $self_$44333;
		}
	}

	// Token: 0x02001C03 RID: 7171
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44336 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A77E RID: 42878 RVA: 0x012CC6FC File Offset: 0x012CA8FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44336(Hashtable data, M943_AncientBug self_)
		{
			if (40697 - 337044 != -296347)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (109412 - 404207 == -294795)
				{
					base..ctor();
					if (281484 - 166577 != 114908)
					{
						this.$data$44343 = data;
						if (282565 - 357567 != -75001)
						{
							this.$self_$44344 = self_;
							if (235310 - 455696 != -220385)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A77F RID: 42879 RVA: 0x012CC7B8 File Offset: 0x012CA9B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M943_AncientBug.$onGameComplete$44336.$(this.$data$44343, this.$self_$44344);
		}

		// Token: 0x0600A780 RID: 42880 RVA: 0x012CC7CC File Offset: 0x012CA9CC
		internal static bool aqMSU1VqyrbeBhtKIqrp()
		{
			return true;
		}

		// Token: 0x0600A781 RID: 42881 RVA: 0x012CC7D0 File Offset: 0x012CA9D0
		internal static bool T710shVqStuq0NXv6HZU()
		{
			return false;
		}

		// Token: 0x04009569 RID: 38249
		internal Hashtable $data$44343;

		// Token: 0x0400956A RID: 38250
		internal M943_AncientBug $self_$44344;

		// Token: 0x02001C04 RID: 7172
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A782 RID: 42882 RVA: 0x012CC7D4 File Offset: 0x012CA9D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M943_AncientBug self_)
			{
				if (30664 - 509982 != -479318)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (247060 - 374164 == -127104)
					{
						base..ctor();
						if (73696 - 275998 == -202302)
						{
							this.$data$44341 = data;
							if (188575 - 310941 == -122366)
							{
								this.$self_$44342 = self_;
								if (296684 - 9871 == 286813)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A783 RID: 42883 RVA: 0x012CC890 File Offset: 0x012CAA90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (122503 - 584286 != -461782)
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
						this.$mCompleteGui$44338 = (CompleteGui)this.$self_$44342.GetComponent(typeof(CompleteGui));
						if (151892 - 501296 == -349403)
						{
							continue;
						}
						this.$mCompleteGui$44338.Init();
						if (167447 - 537663 != -370216)
						{
							continue;
						}
						this.$mCompleteGui$44338.readData(this.$data$44341);
						if (249593 - 152723 == 96871)
						{
							continue;
						}
						if (this.$result$44337 == 1)
						{
							if (79953 - 276348 != -196395)
							{
								continue;
							}
							this.$mCompleteGui$44338.displayResult(eCompleteType.Success);
							if (45911 - 421711 == -375799)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44338.displayResult(eCompleteType.Failed);
							if (228390 - 335445 != -107055)
							{
								continue;
							}
						}
						this.$mGameGui$44339 = (GameGui)this.$self_$44342.GetComponent(typeof(GameGui));
						if (98158 - 428789 == -330630)
						{
							continue;
						}
						this.$mStoryGui$44340 = (StoryGui)this.$self_$44342.GetComponent(typeof(StoryGui));
						if (36947 - 199021 != -162074)
						{
							continue;
						}
						if (this.$mGameGui$44339)
						{
							if (291053 - 516360 == -225306)
							{
								continue;
							}
							this.$mGameGui$44339.close();
							if (28199 - 30307 != -2108)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44340)
						{
							if (79563 - 513532 == -433968)
							{
								continue;
							}
							this.$mStoryGui$44340.close();
							if (227563 - 391486 != -163923)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (135087 - 114703 != 20384)
						{
							continue;
						}
						goto IL_352;
					default:
						if (211377 - 349532 == -138154)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44341[31]);
					if (46137 - 344781 != -298643)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (11598 - 506687 != -495088)
							{
								goto Block_24;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (240404 - 552798 == -312394)
							{
								this.$result$44337 = RuntimeServices.UnboxInt32(this.$data$44341[31]);
								if (283395 - 51344 != 232052)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_24:
				IL_352:
				return false;
			}

			// Token: 0x0600A784 RID: 42884 RVA: 0x012CCC04 File Offset: 0x012CAE04
			internal static bool NyVc3yVqoeptxwsgESLn()
			{
				return true;
			}

			// Token: 0x0600A785 RID: 42885 RVA: 0x012CCC08 File Offset: 0x012CAE08
			internal static bool lauVDdVqEhcw0ILNKhry()
			{
				return false;
			}

			// Token: 0x0400956B RID: 38251
			internal int $result$44337;

			// Token: 0x0400956C RID: 38252
			internal CompleteGui $mCompleteGui$44338;

			// Token: 0x0400956D RID: 38253
			internal GameGui $mGameGui$44339;

			// Token: 0x0400956E RID: 38254
			internal StoryGui $mStoryGui$44340;

			// Token: 0x0400956F RID: 38255
			internal Hashtable $data$44341;

			// Token: 0x04009570 RID: 38256
			internal M943_AncientBug $self_$44342;
		}
	}

	// Token: 0x02001C05 RID: 7173
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$44345 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A786 RID: 42886 RVA: 0x012CCC0C File Offset: 0x012CAE0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$44345(M943_AncientBug self_)
		{
			if (163711 - 75281 != 88431)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (142167 - 248060 == -105893)
				{
					base..ctor();
					if (134377 - 329452 == -195075)
					{
						this.$self_$44348 = self_;
						if (194334 - 336824 != -142489)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A787 RID: 42887 RVA: 0x012CCCA4 File Offset: 0x012CAEA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M943_AncientBug.$StartGame$44345.$(this.$self_$44348);
		}

		// Token: 0x0600A788 RID: 42888 RVA: 0x012CCCB4 File Offset: 0x012CAEB4
		internal static bool wI1ld4Vq2XJ9yDYT3pAC()
		{
			return true;
		}

		// Token: 0x0600A789 RID: 42889 RVA: 0x012CCCB8 File Offset: 0x012CAEB8
		internal static bool SRY5KXVq8mui5LxuYWTO()
		{
			return false;
		}

		// Token: 0x04009571 RID: 38257
		internal M943_AncientBug $self_$44348;

		// Token: 0x02001C06 RID: 7174
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A78A RID: 42890 RVA: 0x012CCCBC File Offset: 0x012CAEBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M943_AncientBug self_)
			{
				if (230117 - 114106 != 116012)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (105805 - 263902 == -158097)
					{
						base..ctor();
						if (102098 - 151518 != -49419)
						{
							this.$self_$44347 = self_;
							if (68109 - 345048 == -276939)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A78B RID: 42891 RVA: 0x012CCD54 File Offset: 0x012CAF54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (136202 - 64953 != 71249)
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
						this.$mGameGui$44346 = (GameGui)this.$self_$44347.GetComponent(typeof(GameGui));
						if (44686 - 269443 != -224757)
						{
							continue;
						}
						this.$mGameGui$44346.enabled = true;
						if (28095 - 147532 != -119437)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (204966 - 273636 != -68670)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (59777 - 375787 != -316010)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (231472 - 530822 != -299350)
						{
							continue;
						}
						if (this.$self_$44347.MJQntqajcev)
						{
							if (37705 - 474875 != -437170)
							{
								continue;
							}
							this.$self_$44347.audio.PlayOneShot(this.$self_$44347.MJQntqajcev);
							if (105870 - 66459 != 39411)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (104292 - 448237 != -343944)
						{
							goto Block_6;
						}
						continue;
					default:
						if (37333 - 386134 != -348801)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (146086 - 448634 != -302547)
					{
						Game.mGameState = eGameState.Start;
						if (284189 - 467824 != -183634)
						{
							Game.mStateTime = Time.time;
							if (264007 - 6701 != 257307)
							{
								this.$self_$44347.SendMessage("fadeIn");
								if (170767 - 135336 != 35432)
								{
									goto Block_13;
								}
							}
						}
					}
				}
				Block_6:
				goto IL_241;
				Block_13:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_241:
				return false;
			}

			// Token: 0x0600A78C RID: 42892 RVA: 0x012CCFB4 File Offset: 0x012CB1B4
			internal static bool NltdsJVqZhbRLhlfa23S()
			{
				return true;
			}

			// Token: 0x0600A78D RID: 42893 RVA: 0x012CCFB8 File Offset: 0x012CB1B8
			internal static bool hBxnyRVqCZ9yLx5rDWxG()
			{
				return false;
			}

			// Token: 0x04009572 RID: 38258
			internal GameGui $mGameGui$44346;

			// Token: 0x04009573 RID: 38259
			internal M943_AncientBug $self_$44347;
		}
	}

	// Token: 0x02001C07 RID: 7175
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44349 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A78E RID: 42894 RVA: 0x012CCFBC File Offset: 0x012CB1BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44349(M943_AncientBug self_)
		{
			if (191106 - 521199 != -330092)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (66952 - 12073 == 54879)
				{
					base..ctor();
					if (286292 - 455778 == -169486)
					{
						this.$self_$44354 = self_;
						if (26201 - 337043 == -310842)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A78F RID: 42895 RVA: 0x012CD054 File Offset: 0x012CB254
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M943_AncientBug.$onDeadPlayer$44349.$(this.$self_$44354);
		}

		// Token: 0x0600A790 RID: 42896 RVA: 0x012CD064 File Offset: 0x012CB264
		internal static bool AgbMAwVqL3OFfWjPZ1v1()
		{
			return true;
		}

		// Token: 0x0600A791 RID: 42897 RVA: 0x012CD068 File Offset: 0x012CB268
		internal static bool ajSD4JVqOMf7Ng6KHmCa()
		{
			return false;
		}

		// Token: 0x04009574 RID: 38260
		internal M943_AncientBug $self_$44354;

		// Token: 0x02001C08 RID: 7176
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A792 RID: 42898 RVA: 0x012CD06C File Offset: 0x012CB26C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M943_AncientBug self_)
			{
				if (28255 - 144555 != -116300)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (45790 - 514930 == -469140)
					{
						base..ctor();
						if (277284 - 193100 == 84184)
						{
							this.$self_$44353 = self_;
							if (79882 - 159596 != -79713)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A793 RID: 42899 RVA: 0x012CD104 File Offset: 0x012CB304
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (123466 - 573695 != -450229)
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
							goto IL_250;
						}
						if (71774 - 377728 != -305954)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (169247 - 204741 != -35493)
							{
								goto IL_250;
							}
							continue;
						}
						IL_16C:
						this.YieldDefault(1);
						if (17811 - 230015 != -212203)
						{
							goto Block_13;
						}
						continue;
						IL_250:
						Game.mGameState = eGameState.Hold;
						if (70781 - 469238 != -398457)
						{
							continue;
						}
						this.$mStoryGui$44350 = (StoryGui)this.$self_$44353.GetComponent(typeof(StoryGui));
						if (58287 - 132898 == -74610)
						{
							continue;
						}
						if (this.$mStoryGui$44350)
						{
							if (205444 - 279596 == -74151)
							{
								continue;
							}
							this.$mStoryGui$44350.close();
							if (222507 - 345201 != -122694)
							{
								continue;
							}
						}
						this.$mChangeGui$44351 = (ChangeGui)this.$self_$44353.GetComponent(typeof(ChangeGui));
						if (114615 - 89528 != 25087)
						{
							continue;
						}
						if (this.$mChangeGui$44351)
						{
							if (104339 - 173066 != -68727)
							{
								continue;
							}
							this.$mChangeGui$44351.close();
							if (282312 - 531649 != -249337)
							{
								continue;
							}
						}
						this.$mGameGui$44352 = (GameGui)this.$self_$44353.GetComponent(typeof(GameGui));
						if (281431 - 153673 == 127759)
						{
							continue;
						}
						if (!this.$mGameGui$44352)
						{
							goto IL_16C;
						}
						if (225247 - 32382 == 192866)
						{
							continue;
						}
						if (!this.$mGameGui$44352.enabled)
						{
							if (265164 - 345258 != -80094)
							{
								continue;
							}
							this.$mGameGui$44352.enabled = true;
							if (203386 - 296258 == -92871)
							{
								continue;
							}
						}
						this.$mGameGui$44352.openDeadMenu();
						if (235494 - 39258 != 196236)
						{
							continue;
						}
						goto IL_16C;
					default:
						if (21829 - 389897 != -368068)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (282777 - 542135 == -259357);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_13:
				IL_2F9:
				return false;
			}

			// Token: 0x0600A794 RID: 42900 RVA: 0x012CD41C File Offset: 0x012CB61C
			internal static bool uhoa8XVqmvDJm2jn5NrC()
			{
				return true;
			}

			// Token: 0x0600A795 RID: 42901 RVA: 0x012CD420 File Offset: 0x012CB620
			internal static bool wCDx9pVqFMq2cT6fu9Tx()
			{
				return false;
			}

			// Token: 0x04009575 RID: 38261
			internal StoryGui $mStoryGui$44350;

			// Token: 0x04009576 RID: 38262
			internal ChangeGui $mChangeGui$44351;

			// Token: 0x04009577 RID: 38263
			internal GameGui $mGameGui$44352;

			// Token: 0x04009578 RID: 38264
			internal M943_AncientBug $self_$44353;
		}
	}

	// Token: 0x02001C09 RID: 7177
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44355 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A796 RID: 42902 RVA: 0x012CD424 File Offset: 0x012CB624
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44355(M943_AncientBug self_)
		{
			if (293276 - 459485 != -166208)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (152336 - 225970 != -73633)
				{
					base..ctor();
					if (119517 - 55245 == 64272)
					{
						this.$self_$44359 = self_;
						if (259412 - 223311 != 36102)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A797 RID: 42903 RVA: 0x012CD4BC File Offset: 0x012CB6BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M943_AncientBug.$ReturnToTown$44355.$(this.$self_$44359);
		}

		// Token: 0x0600A798 RID: 42904 RVA: 0x012CD4CC File Offset: 0x012CB6CC
		internal static bool zuK8FSVqMuwdhaVNEMHg()
		{
			return true;
		}

		// Token: 0x0600A799 RID: 42905 RVA: 0x012CD4D0 File Offset: 0x012CB6D0
		internal static bool S1VN8FVqx3cSUoTWSkvk()
		{
			return false;
		}

		// Token: 0x04009579 RID: 38265
		internal M943_AncientBug $self_$44359;

		// Token: 0x02001C0A RID: 7178
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A79A RID: 42906 RVA: 0x012CD4D4 File Offset: 0x012CB6D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M943_AncientBug self_)
			{
				if (191078 - 308232 != -117154)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (258051 - 42855 != 215197)
					{
						base..ctor();
						if (278966 - 340830 == -61864)
						{
							this.$self_$44358 = self_;
							if (28312 - 369611 == -341299)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A79B RID: 42907 RVA: 0x012CD56C File Offset: 0x012CB76C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (88740 - 389269 != -300529)
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
						this.$self_$44358.LeaveGame();
						if (298145 - 99139 == 199007)
						{
							continue;
						}
						this.YieldDefault(1);
						if (85338 - 529345 != -444006)
						{
							goto Block_11;
						}
						continue;
					default:
						if (208149 - 127208 != 80941)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (76337 - 16562 != 59776)
					{
						Game.mStateTime = Time.time;
						if (237481 - 402036 != -164554)
						{
							this.$$switch$8180$44356 = PlayerData.SaveGuild;
							if (185562 - 228521 != -42958)
							{
								if (this.$$switch$8180$44356 == 1)
								{
									if (217680 - 532863 != -315183)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (191204 - 43565 != 147639)
									{
										continue;
									}
								}
								else if (this.$$switch$8180$44356 == 2)
								{
									if (203742 - 161762 == 41981)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (145221 - 127219 != 18002)
									{
										continue;
									}
								}
								else if (this.$$switch$8180$44356 == 3)
								{
									if (6005 - 72938 == -66932)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (84595 - 180585 == -95989)
									{
										continue;
									}
								}
								else if (this.$$switch$8180$44356 == 4)
								{
									if (212799 - 293693 != -80894)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (216605 - 437291 == -220685)
									{
										continue;
									}
								}
								else if (this.$$switch$8180$44356 == 5)
								{
									if (95104 - 210070 != -114966)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (30414 - 278909 == -248494)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (229558 - 289313 == -59754)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (255733 - 14378 == 241356)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (299952 - 550379 != -250427)
									{
										continue;
									}
								}
								this.$mGameGui$44357 = (GameGui)this.$self_$44358.GetComponent(typeof(GameGui));
								if (133935 - 78094 == 55841)
								{
									if (this.$mGameGui$44357)
									{
										if (226218 - 539651 == -313432)
										{
											continue;
										}
										this.$mGameGui$44357.close();
										if (81320 - 498151 == -416830)
										{
											continue;
										}
									}
									this.$self_$44358.SendMessage("fadeOut");
									if (166163 - 558644 != -392480)
									{
										goto Block_20;
									}
								}
							}
						}
					}
				}
				Block_11:
				goto IL_3AD;
				Block_20:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600A79C RID: 42908 RVA: 0x012CD938 File Offset: 0x012CBB38
			internal static bool knFbcJVqgHOn6a0w5eWN()
			{
				return true;
			}

			// Token: 0x0600A79D RID: 42909 RVA: 0x012CD93C File Offset: 0x012CBB3C
			internal static bool gmi8MUVqfuxpJw9BLAiI()
			{
				return false;
			}

			// Token: 0x0400957A RID: 38266
			internal int $$switch$8180$44356;

			// Token: 0x0400957B RID: 38267
			internal GameGui $mGameGui$44357;

			// Token: 0x0400957C RID: 38268
			internal M943_AncientBug $self_$44358;
		}
	}

	// Token: 0x02001C0B RID: 7179
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44360 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A79E RID: 42910 RVA: 0x012CD940 File Offset: 0x012CBB40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44360(M943_AncientBug self_)
		{
			if (273241 - 499327 != -226085)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (238343 - 279252 == -40909)
				{
					base..ctor();
					if (218676 - 240684 == -22008)
					{
						this.$self_$44363 = self_;
						if (137841 - 62195 != 75647)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A79F RID: 42911 RVA: 0x012CD9D8 File Offset: 0x012CBBD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M943_AncientBug.$ReturnToGuild$44360.$(this.$self_$44363);
		}

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x012CD9E8 File Offset: 0x012CBBE8
		internal static bool ggCTxZVqnTJ84w1A4UGu()
		{
			return true;
		}

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x012CD9EC File Offset: 0x012CBBEC
		internal static bool dq4TheVq6MKV92fe3G32()
		{
			return false;
		}

		// Token: 0x0400957D RID: 38269
		internal M943_AncientBug $self_$44363;

		// Token: 0x02001C0C RID: 7180
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A7A2 RID: 42914 RVA: 0x012CD9F0 File Offset: 0x012CBBF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M943_AncientBug self_)
			{
				if (14799 - 356094 != -341295)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (101626 - 219007 != -117380)
					{
						base..ctor();
						if (285939 - 239577 == 46362)
						{
							this.$self_$44362 = self_;
							if (197508 - 209674 == -12166)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A7A3 RID: 42915 RVA: 0x012CDA88 File Offset: 0x012CBC88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (169741 - 521408 != -351666)
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
						this.$self_$44362.LeaveGame();
						if (159353 - 373924 != -214571)
						{
							continue;
						}
						this.YieldDefault(1);
						if (198952 - 573919 != -374967)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (215422 - 531842 == -316419)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (50376 - 806 == 49570)
					{
						Game.mStateTime = Time.time;
						if (94138 - 366749 == -272611)
						{
							Game.mNextGameCode = 31;
							if (128703 - 363624 != -234920)
							{
								this.$mGameGui$44361 = (GameGui)this.$self_$44362.GetComponent(typeof(GameGui));
								if (78421 - 414749 == -336328)
								{
									if (this.$mGameGui$44361)
									{
										if (101726 - 187070 == -85343)
										{
											continue;
										}
										this.$mGameGui$44361.close();
										if (6746 - 78244 == -71497)
										{
											continue;
										}
									}
									this.$self_$44362.SendMessage("fadeOut");
									if (217035 - 419999 == -202964)
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

			// Token: 0x0600A7A4 RID: 42916 RVA: 0x012CDC64 File Offset: 0x012CBE64
			internal static bool OMEa5NVqi054wEMeadmw()
			{
				return true;
			}

			// Token: 0x0600A7A5 RID: 42917 RVA: 0x012CDC68 File Offset: 0x012CBE68
			internal static bool hVOssDVqKNuMrp6WF745()
			{
				return false;
			}

			// Token: 0x0400957E RID: 38270
			internal GameGui $mGameGui$44361;

			// Token: 0x0400957F RID: 38271
			internal M943_AncientBug $self_$44362;
		}
	}

	// Token: 0x02001C0D RID: 7181
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44364 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A7A6 RID: 42918 RVA: 0x012CDC6C File Offset: 0x012CBE6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44364(M943_AncientBug self_)
		{
			if (210784 - 368701 != -157916)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (203295 - 550649 != -347353)
				{
					base..ctor();
					if (268339 - 363768 == -95429)
					{
						this.$self_$44368 = self_;
						if (115887 - 212381 == -96494)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A7A7 RID: 42919 RVA: 0x012CDD04 File Offset: 0x012CBF04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M943_AncientBug.$ReturnToCamp$44364.$(this.$self_$44368);
		}

		// Token: 0x0600A7A8 RID: 42920 RVA: 0x012CDD14 File Offset: 0x012CBF14
		internal static bool zd7CoAVqdI1NeJQVI6UH()
		{
			return true;
		}

		// Token: 0x0600A7A9 RID: 42921 RVA: 0x012CDD18 File Offset: 0x012CBF18
		internal static bool AEivnpVqJWgh8flU2yJV()
		{
			return false;
		}

		// Token: 0x04009580 RID: 38272
		internal M943_AncientBug $self_$44368;

		// Token: 0x02001C0E RID: 7182
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A7AA RID: 42922 RVA: 0x012CDD1C File Offset: 0x012CBF1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M943_AncientBug self_)
			{
				if (246399 - 366870 != -120470)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (177552 - 191032 == -13480)
					{
						base..ctor();
						if (52532 - 404260 == -351728)
						{
							this.$self_$44367 = self_;
							if (94643 - 517034 == -422391)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A7AB RID: 42923 RVA: 0x012CDDB4 File Offset: 0x012CBFB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (171627 - 424808 != -253181)
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
						this.$self_$44367.LeaveGame();
						if (282288 - 499240 == -216951)
						{
							continue;
						}
						this.YieldDefault(1);
						if (233710 - 76792 != 156918)
						{
							continue;
						}
						goto IL_363;
					default:
						if (26304 - 76839 != -50535)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (281242 - 249095 == 32147)
					{
						Game.mStateTime = Time.time;
						if (136614 - 246440 != -109825)
						{
							this.$$switch$8182$44365 = PlayerData.SaveGuild;
							if (149093 - 350653 != -201559)
							{
								if (this.$$switch$8182$44365 == 1)
								{
									if (243867 - 299658 != -55791)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (142215 - 237424 == -95208)
									{
										continue;
									}
								}
								else if (this.$$switch$8182$44365 == 2)
								{
									if (288511 - 200936 != 87575)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (239432 - 393974 == -154541)
									{
										continue;
									}
								}
								else if (this.$$switch$8182$44365 == 3)
								{
									if (202648 - 539813 == -337164)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (233242 - 5396 != 227846)
									{
										continue;
									}
								}
								else if (this.$$switch$8182$44365 == 4)
								{
									if (73622 - 440985 == -367362)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (197138 - 33228 != 163910)
									{
										continue;
									}
								}
								else if (this.$$switch$8182$44365 == 5)
								{
									if (286010 - 339916 != -53906)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (181744 - 558739 != -376995)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (76122 - 258808 == -182685)
									{
										continue;
									}
								}
								this.$mGameGui$44366 = (GameGui)this.$self_$44367.GetComponent(typeof(GameGui));
								if (50929 - 457704 == -406775)
								{
									if (this.$mGameGui$44366)
									{
										if (183845 - 56377 != 127468)
										{
											continue;
										}
										this.$mGameGui$44366.close();
										if (277141 - 294846 != -17705)
										{
											continue;
										}
									}
									this.$self_$44367.SendMessage("fadeOut");
									if (29185 - 14453 != 14733)
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

			// Token: 0x0600A7AC RID: 42924 RVA: 0x012CE138 File Offset: 0x012CC338
			internal static bool a3f62rVqDX31ry7Zvyqc()
			{
				return true;
			}

			// Token: 0x0600A7AD RID: 42925 RVA: 0x012CE13C File Offset: 0x012CC33C
			internal static bool TgHbvFVqvWwNR4NNnwYf()
			{
				return false;
			}

			// Token: 0x04009581 RID: 38273
			internal int $$switch$8182$44365;

			// Token: 0x04009582 RID: 38274
			internal GameGui $mGameGui$44366;

			// Token: 0x04009583 RID: 38275
			internal M943_AncientBug $self_$44367;
		}
	}
}
