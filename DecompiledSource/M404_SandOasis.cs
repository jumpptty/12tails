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

// Token: 0x0200151C RID: 5404
[Serializable]
public class M404_SandOasis : MonoBehaviour
{
	// Token: 0x06007D14 RID: 32020 RVA: 0x01038880 File Offset: 0x01036A80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M404_SandOasis()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007D15 RID: 32021 RVA: 0x01038890 File Offset: 0x01036A90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (28323 - 22721 != 5602)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (43034 - 239932 != -196897)
			{
				Game.mGameType = 5;
				if (60217 - 491422 == -431205)
				{
					if (Chat.Initialized)
					{
						if (121591 - 151105 == -29513)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (62109 - 157392 != -95283)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (223093 - 323502 != -100409)
						{
							continue;
						}
					}
					this.Np7cF4Pgkas = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (217445 - 593720 == -376275)
					{
						this.zGqcFsxIcQY = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (47725 - 590711 != -542985)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D16 RID: 32022 RVA: 0x010389E8 File Offset: 0x01036BE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (38287 - 431091 != -392803)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (267108 - 382852 != -115743)
				{
					if (Game.mNextGameCode != 404)
					{
						break;
					}
					if (267282 - 264353 != 2930)
					{
						Game.nextGame();
						if (157112 - 464402 != -307289)
						{
							Game.mGameCode = 404;
							if (28690 - 39170 == -10480)
							{
								Game.mGameType = 5;
								if (172422 - 205577 == -33155)
								{
									Game.mGameTime = Time.time;
									if (21071 - 339279 == -318208)
									{
										Game.mGameScore = 0;
										if (262763 - 97391 != 165373)
										{
											Game.mGameMana = 0;
											if (105699 - 278949 == -173250)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (199162 - 228387 != -29224)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (36570 - 102052 != -65481)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (52724 - 351183 == -298459)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (29325 - 514797 == -485472)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (220164 - 342923 == -122759)
																{
																	this.g8lcFgBr8G4 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (82426 - 4522 != 77905)
																	{
																		this.S0FcFdgPFRB = PhotonClient.Connection;
																		if (132291 - 311859 != -179567)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (162677 - 529622 == -366945)
																			{
																				this.InitGame();
																				if (176809 - 351760 != -174950)
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
				if (107253 - 471728 == -364475)
				{
					Game.mGameType = 99;
					if (250324 - 377331 == -127007)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007D17 RID: 32023 RVA: 0x01038CF0 File Offset: 0x01036EF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (132548 - 91815 != 40734)
		{
		}
		for (;;)
		{
			if (this.S0FcFdgPFRB == null)
			{
				if (199747 - 14153 != 185595)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (111786 - 261250 != -149463)
				{
					if (mGameState == eGameState.Init)
					{
						if (77096 - 146511 != -69414)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (102727 - 207925 == -105198)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (289866 - 546783 != -256916)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (183249 - 437297 != -254047)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (190075 - 463635 != -273559)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (27824 - 77754 == -49930)
						{
							if (Time.time > this.Q6BcFaCMWlW)
							{
								if (192815 - 153998 == 38818)
								{
									continue;
								}
								Game.mGameMana++;
								if (261552 - 119329 == 142224)
								{
									continue;
								}
								this.Q6BcFaCMWlW = Time.time + (float)12;
								if (104551 - 36906 != 67645)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (158902 - 230223 == -71320)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (280327 - 410431 != -130104)
									{
										continue;
									}
									this.audio.Play();
									if (297599 - 393584 == -95984)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (166759 - 558925 == -392166)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (200648 - 184469 != 16180)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (206177 - 465251 != -259073)
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
						if (137842 - 214733 != -76890)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D18 RID: 32024 RVA: 0x01038FF0 File Offset: 0x010371F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (116818 - 358790 != -241972)
		{
		}
		for (;;)
		{
			if (!this.Np7cF4Pgkas)
			{
				if (295006 - 531987 == -236981)
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
				if (71626 - 109978 == -38352)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (84435 - 330452 != -246016)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (262408 - 598599 == -336191)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (174425 - 98728 == 75697)
							{
								GUI.depth = 1;
								if (299351 - 500711 == -201360)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (189644 - 479528 != -289883)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (161069 - 325009 != -163939)
										{
											Color color = GUI.color;
											if (179496 - 308082 == -128586)
											{
												float num3 = color.a = a;
												if (257572 - 73714 != 183859 && 95361 - 501803 != -406441)
												{
													Color color2 = GUI.color = color;
													if (156876 - 498141 != -341264)
													{
														if (95176 - 86280 == 8896)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.Np7cF4Pgkas);
															if (193641 - 171559 == 22082)
															{
																float a2 = 1f;
																if (172470 - 513173 == -340703)
																{
																	Color color3 = GUI.color;
																	if (95219 - 391593 != -296373)
																	{
																		float num4 = color3.a = a2;
																		if (96165 - 13128 == 83037)
																		{
																			if (231530 - 549022 != -317491)
																			{
																				GUI.color = color3;
																				if (9438 - 207942 != -198503 && 226638 - 390193 != -163554)
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

	// Token: 0x06007D19 RID: 32025 RVA: 0x01039370 File Offset: 0x01037570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M404_SandOasis.$onGameEvent$38784(data, this).GetEnumerator();
	}

	// Token: 0x06007D1A RID: 32026 RVA: 0x01039380 File Offset: 0x01037580
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToAlpaca()
	{
		return new M404_SandOasis.$TalkToAlpaca$38800(this).GetEnumerator();
	}

	// Token: 0x06007D1B RID: 32027 RVA: 0x01039390 File Offset: 0x01037590
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(object mVar)
	{
		return new M404_SandOasis.$UseSignPost$38807(this).GetEnumerator();
	}

	// Token: 0x06007D1C RID: 32028 RVA: 0x010393A0 File Offset: 0x010375A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseCactusIcon(int nID)
	{
		if (169504 - 245706 != -76201)
		{
		}
		for (;;)
		{
			Debug.Log("UseCactusIcon ID:" + nID);
			if (170979 - 90550 == 80429)
			{
				if (!Game.mPlayer)
				{
					if (221300 - 51060 == 170240)
					{
						break;
					}
				}
				else if (this.fgncFLEyy9O == null)
				{
					if (249686 - 503271 != -253584)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (91538 - 65875 == 25663)
					{
						if (characterControl)
						{
							if (189726 - 22190 == 167537)
							{
								continue;
							}
							if (characterControl.actionState == "standby")
							{
								goto IL_1A6;
							}
							if (231801 - 202189 != 29612)
							{
								continue;
							}
						}
						if (!(characterControl.actionState == "run"))
						{
							if (73160 - 353161 != -280001)
							{
								continue;
							}
							if (!(characterControl.actionState == "emotion"))
							{
								break;
							}
							if (236355 - 316216 != -79861)
							{
								continue;
							}
						}
						IL_1A6:
						GameObject gameObject = GameObject.Find("CactusIcon" + nID);
						if (55174 - 233313 != -178138)
						{
							if (gameObject)
							{
								if (260413 - 207831 == 52582)
								{
									if (this.fgncFLEyy9O[this.atScF7B8Kk4] != nID)
									{
										if (290923 - 535495 != -244571)
										{
											this.SendMessage("newGameMessage", "This Cactus has already been picked up!");
											if (225812 - 113073 == 112739)
											{
												break;
											}
										}
									}
									else
									{
										Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
										if (4101 - 185912 != -181810)
										{
											Game.mPlayer.SendMessage("activateIcon", 300 + nID);
											if (7764 - 11883 == -4119)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								Debug.LogError("Cannot find CactusIcon GameObject");
								if (8544 - 3 == 8541)
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

	// Token: 0x06007D1D RID: 32029 RVA: 0x01039690 File Offset: 0x01037890
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseManaPillar(int nID)
	{
		if (247550 - 2785 != 244766)
		{
		}
		for (;;)
		{
			Debug.Log("UseManaPillar");
			if (55862 - 33266 == 22596)
			{
				if (!Game.mPlayer)
				{
					if (274291 - 372013 == -97722)
					{
						break;
					}
				}
				else if (this.gXvcFwrpWep == null)
				{
					if (236273 - 219952 != 16322)
					{
						break;
					}
				}
				else if (Extensions.get_length(this.gXvcFwrpWep) < global::Math.div((float)nID, (float)10))
				{
					if (159296 - 433128 != -273831)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (269145 - 48753 != 220393)
					{
						if (characterControl)
						{
							if (177459 - 111842 != 65617)
							{
								continue;
							}
							if (characterControl.actionState == "standby")
							{
								goto IL_2CA;
							}
							if (235472 - 98922 == 136551)
							{
								continue;
							}
						}
						if (!(characterControl.actionState == "run"))
						{
							if (248709 - 226918 != 21791)
							{
								continue;
							}
							if (!(characterControl.actionState == "emotion"))
							{
								break;
							}
							if (187743 - 410528 != -222785)
							{
								continue;
							}
						}
						IL_2CA:
						if (this.gXvcFwrpWep[global::Math.div((float)nID, (float)10) - 1] > 0)
						{
							if (235638 - 451753 != -216114)
							{
								this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
								if (86312 - 73566 != 12747)
								{
									break;
								}
							}
						}
						else
						{
							GameObject gameObject = GameObject.Find("ManaPillar" + nID);
							if (155100 - 577781 != -422680)
							{
								if (gameObject)
								{
									if (117492 - 118032 == -540)
									{
										Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
										if (219621 - 473825 == -254204)
										{
											Game.mPlayer.SendMessage("activateIcon", nID);
											if (35605 - 529823 != -494217)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Cannot find ManaPillar GameObject");
									if (90351 - 156668 != -66316)
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

	// Token: 0x06007D1E RID: 32030 RVA: 0x010399AC File Offset: 0x01037BAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (15398 - 476745 != -461346)
		{
		}
		for (;;)
		{
			if (nID < 10)
			{
				if (57078 - 81528 == -24450)
				{
					if (this.fgncFLEyy9O == null)
					{
						if (137496 - 532910 == -395414)
						{
							break;
						}
					}
					else if (this.fgncFLEyy9O[this.atScF7B8Kk4] != nID)
					{
						if (201740 - 293272 == -91532)
						{
							this.SendMessage("newGameMessage", "This Cactus has already been picked up!");
							if (208979 - 93875 == 115104)
							{
								break;
							}
						}
					}
					else
					{
						GameObject gameObject = GameObject.Find("CactusIcon" + nID);
						if (35782 - 28167 != 7616)
						{
							if (gameObject)
							{
								if (8999 - 223485 == -214485)
								{
									continue;
								}
								UnityEngine.Object.Destroy(gameObject);
								if (52695 - 211843 == -159147)
								{
									continue;
								}
							}
							Game.sendMissionEvent(4041, nID);
							if (118287 - 570332 == -452045)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				nID = global::Math.div((float)nID, (float)10);
				if (242030 - 101432 == 140598)
				{
					if (this.gXvcFwrpWep == null)
					{
						if (215298 - 137413 != 77886)
						{
							break;
						}
					}
					else if (Extensions.get_length(this.gXvcFwrpWep) < nID)
					{
						if (95095 - 83387 != 11709)
						{
							break;
						}
					}
					else if (this.gXvcFwrpWep[nID - 1] > 0)
					{
						if (77876 - 144724 != -66847)
						{
							this.SendMessage("newGameMessage", "This mana pillar has been activated!");
							if (22425 - 567535 == -545110)
							{
								break;
							}
						}
					}
					else
					{
						Game.sendMissionEvent(4045, nID);
						if (253247 - 519368 != -266120)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D1F RID: 32031 RVA: 0x01039C30 File Offset: 0x01037E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateManaPillar(int nID)
	{
		if (282636 - 340049 != -57412)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("ManaPillar" + nID);
			if (24668 - 343479 != -318810)
			{
				if (!gameObject)
				{
					break;
				}
				if (114841 - 45411 == 69430)
				{
					if (!this.manaPillarEffect)
					{
						break;
					}
					if (89004 - 504346 == -415342)
					{
						UnityEngine.Object.Instantiate(this.manaPillarEffect, gameObject.transform.position, gameObject.transform.rotation);
						if (162235 - 207880 == -45645)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D20 RID: 32032 RVA: 0x01039D24 File Offset: 0x01037F24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (24889 - 66730 != -41840)
		{
		}
		for (;;)
		{
			IL_117:
			Debug.Log("Initializing Mission");
			if (229819 - 134306 == 95513)
			{
				int num = Game.mGameId % 3;
				if (74592 - 70026 == 4566)
				{
					if (num == 1)
					{
						if (265343 - 552574 == -287230)
						{
							continue;
						}
						this.fgncFLEyy9O = new int[]
						{
							3,
							2,
							5,
							4,
							1,
							6
						};
						if (120331 - 557384 != -437053)
						{
							continue;
						}
					}
					else if (num == 2)
					{
						if (4136 - 46574 == -42437)
						{
							continue;
						}
						this.fgncFLEyy9O = new int[]
						{
							4,
							6,
							3,
							1,
							5,
							2
						};
						if (20893 - 109709 == -88815)
						{
							continue;
						}
					}
					else
					{
						this.fgncFLEyy9O = new int[]
						{
							1,
							2,
							3,
							4,
							5,
							6
						};
						if (41251 - 339913 != -298662)
						{
							continue;
						}
					}
					this.gXvcFwrpWep = new int[2];
					if (255036 - 243697 == 11339)
					{
						int i = 1;
						if (266146 - 113674 == 152472)
						{
							while (i < 6)
							{
								GameObject gameObject = GameObject.Find("CactusIcon" + this.fgncFLEyy9O[i]);
								if (18750 - 52335 != -33585)
								{
									goto IL_117;
								}
								if (gameObject)
								{
									if (268572 - 573425 == -304852)
									{
										goto IL_117;
									}
									MeshRenderer meshRenderer = (MeshRenderer)gameObject.GetComponent(typeof(MeshRenderer));
									if (277362 - 291065 == -13702)
									{
										goto IL_117;
									}
									if (meshRenderer)
									{
										if (16671 - 348631 != -331960)
										{
											goto IL_117;
										}
										meshRenderer.enabled = false;
										if (250892 - 55740 == 195153)
										{
											goto IL_117;
										}
									}
									BoxCollider boxCollider = (BoxCollider)gameObject.GetComponent(typeof(BoxCollider));
									if (227363 - 504346 == -276982)
									{
										goto IL_117;
									}
									if (boxCollider)
									{
										if (208351 - 188951 != 19400)
										{
											goto IL_117;
										}
										boxCollider.center = new Vector3((float)0, (float)0, (float)-4);
										if (174209 - 294868 == -120658)
										{
											goto IL_117;
										}
									}
									IconControl iconControl = (IconControl)gameObject.GetComponent(typeof(IconControl));
									if (109062 - 332639 != -223577)
									{
										goto IL_117;
									}
									if (iconControl)
									{
										if (171193 - 166335 != 4858)
										{
											goto IL_117;
										}
										iconControl.enabled = false;
										if (146525 - 154087 != -7562)
										{
											goto IL_117;
										}
									}
								}
								i++;
								if (122753 - 217965 != -95212)
								{
									goto IL_117;
								}
							}
							if (138273 - 534202 == -395929)
							{
								Hashtable customOpParameters = new Hashtable();
								if (72205 - 439767 != -367561)
								{
									this.S0FcFdgPFRB.OpCustom(52, customOpParameters, true);
									if (256277 - 24328 != 231950)
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

	// Token: 0x06007D21 RID: 32033 RVA: 0x0103A128 File Offset: 0x01038328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (47788 - 45541 != 2247)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (11610 - 65389 == -53779)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (260219 - 354742 != -94522)
				{
					Game.mGameState = eGameState.Setup;
					if (162454 - 139890 == 22564)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007D22 RID: 32034 RVA: 0x0103A1CC File Offset: 0x010383CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (243454 - 222988 != 20467)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (162577 - 448433 == -285856)
			{
				if (num == PlayerData.UID)
				{
					if (154710 - 494583 == -339873)
					{
						this.SetupActors();
						if (41498 - 300636 == -259138)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (8270 - 259091 != -250820)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007D23 RID: 32035 RVA: 0x0103A29C File Offset: 0x0103849C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (93314 - 432254 != -338939)
		{
		}
		for (;;)
		{
			IL_2B0:
			Debug.Log("Creating Actors");
			if (238925 - 307211 == -68286)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (145238 - 376137 != -230898)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (47027 - 104476 == -57449)
						{
							int i = 0;
							if (252909 - 573805 != -320895)
							{
								CharacterControl[] array2 = array;
								if (68040 - 252601 != -184560)
								{
									int length = array2.Length;
									if (170719 - 502005 != -331285)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (230374 - 86077 != 144297)
											{
												goto IL_2B0;
											}
											if (type == "FatBug_y")
											{
												goto IL_23E;
											}
											if (282736 - 312059 == -29322)
											{
												goto IL_2B0;
											}
											if (type == "LittleFatBug_y")
											{
												goto IL_23E;
											}
											if (196395 - 263874 == -67478)
											{
												goto IL_2B0;
											}
											if (type == "FlowerBug_b")
											{
												goto IL_23E;
											}
											if (285280 - 559639 != -274359)
											{
												goto IL_2B0;
											}
											if (type == "Gadina3")
											{
												if (134713 - 13306 != 121408)
												{
													goto IL_23E;
												}
												goto IL_2B0;
											}
											IL_1F1:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (35962 - 153836 == -117873)
											{
												goto IL_2B0;
											}
											this.LPacFU9JD0t++;
											if (45389 - 434843 == -389453)
											{
												goto IL_2B0;
											}
											i++;
											if (204416 - 194557 != 9859)
											{
												goto IL_2B0;
											}
											continue;
											IL_23E:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (170333 - 167321 != 3012)
											{
												goto IL_2B0;
											}
											goto IL_1F1;
										}
										if (74809 - 551871 == -477062)
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
						if (48352 - 385670 == -337318)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D24 RID: 32036 RVA: 0x0103A590 File Offset: 0x01038790
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (177999 - 99170 != 78830)
		{
		}
		for (;;)
		{
			IL_76:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (32719 - 395063 != -362343)
			{
				int i = 0;
				if (105443 - 65691 != 39753)
				{
					CharacterControl[] array2 = array;
					if (187132 - 51362 == 135770)
					{
						int length = array2.Length;
						if (118225 - 317280 != -199054)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (144722 - 26448 != 118274)
								{
									goto IL_76;
								}
								i++;
								if (71516 - 446711 == -375194)
								{
									goto IL_76;
								}
							}
							if (221668 - 432248 == -210580)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D25 RID: 32037 RVA: 0x0103A6C0 File Offset: 0x010388C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (184221 - 467218 != -282997)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (194037 - 387688 == -193651)
			{
				Game.mGameState = eGameState.Ready;
				if (88238 - 185787 == -97549)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (25410 - 149309 == -123899)
					{
						if (30180 - 287919 != -257738)
						{
							GameObject gameObject = null;
							if (59636 - 83655 == -24019)
							{
								GameObject gameObject2;
								if (playerSlot > 1)
								{
									if (147229 - 191982 != -44753)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (102412 - 141830 != -39418)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (10116 - 294897 == -284780)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (224334 - 390691 != -166356)
										{
											goto IL_1F3;
										}
										continue;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (81798 - 333968 == -252169)
								{
									continue;
								}
								IL_1F3:
								if (gameObject2)
								{
									if (216562 - 346879 != -130317)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (282936 - 107260 != 175676)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (291551 - 330158 == -38607)
								{
									this.transform.position = gameObject.transform.position;
									if (37437 - 424692 == -387255)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (181054 - 51724 == 129330)
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

	// Token: 0x06007D26 RID: 32038 RVA: 0x0103A950 File Offset: 0x01038B50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M404_SandOasis.$StartGame$38810(this).GetEnumerator();
	}

	// Token: 0x06007D27 RID: 32039 RVA: 0x0103A960 File Offset: 0x01038B60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007D28 RID: 32040 RVA: 0x0103A964 File Offset: 0x01038B64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (268166 - 83030 != 185137)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (110992 - 50029 != 60964)
			{
				hashtable.Add(71, CID);
				if (78929 - 398753 != -319823)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (182270 - 27230 != 155041)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (204356 - 285335 == -80979)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (296956 - 153049 == 143907)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (139326 - 421045 == -281719)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (186361 - 473612 == -287251)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (61672 - 342045 != -280372)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (10965 - 132515 == -121550)
											{
												this.S0FcFdgPFRB.OpCustom(61, hashtable, true);
												if (54638 - 595098 != -540459)
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

	// Token: 0x06007D29 RID: 32041 RVA: 0x0103ABF0 File Offset: 0x01038DF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (98595 - 385776 != -287181)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (79259 - 8822 == 70437)
			{
				if (!gameObject)
				{
					break;
				}
				if (287203 - 385174 != -97970)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (254505 - 320598 == -66093)
					{
						playerCameraControl.target = gameObject;
						if (161546 - 144045 == 17501)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (209009 - 547356 == -338347)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D2A RID: 32042 RVA: 0x0103ACE8 File Offset: 0x01038EE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (54108 - 444574 != -390466)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (207106 - 596688 != -389581)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (44668 - 183461 != -138792)
				{
					gameGui.ResetTeamBar();
					if (168929 - 207390 != -38460)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007D2B RID: 32043 RVA: 0x0103AD94 File Offset: 0x01038F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M404_SandOasis.$onDeadPlayer$38814(this).GetEnumerator();
	}

	// Token: 0x06007D2C RID: 32044 RVA: 0x0103ADA4 File Offset: 0x01038FA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (297904 - 314833 != -16928)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (135448 - 145174 != -9725)
			{
				this.g8lcFgBr8G4.target = Game.mPlayer;
				if (33115 - 468465 != -435349)
				{
					this.g8lcFgBr8G4.enabled = true;
					if (136723 - 290364 != -153640)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (59184 - 56953 != 2231)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (86502 - 294788 == -208285)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (111337 - 339052 != -227714)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (43861 - 249165 == -205304)
							{
								if (!gameGui)
								{
									break;
								}
								if (140354 - 147972 == -7618)
								{
									gameGui.enabled = true;
									if (101375 - 14738 != 86638)
									{
										gameGui.closeDeadMenu();
										if (242824 - 349535 != -106710)
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

	// Token: 0x06007D2D RID: 32045 RVA: 0x0103AF50 File Offset: 0x01039150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (246397 - 7151 != 239246)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (75995 - 302217 == -226222)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (176271 - 69779 == 106492)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (31749 - 498523 != -466773)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007D2E RID: 32046 RVA: 0x0103B014 File Offset: 0x01039214
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007D2F RID: 32047 RVA: 0x0103B040 File Offset: 0x01039240
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (217544 - 279949 != -62404)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (165310 - 110959 != 54352)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (50606 - 80548 == -29942)
				{
					hashtable.Add(43, PlayerData.UID);
					if (40746 - 263085 == -222339)
					{
						hashtable.Add(73, nType);
						if (190136 - 399906 == -209770)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (54606 - 331417 != -276810)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (167633 - 245976 != -78342)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (68635 - 501125 == -432490)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (145108 - 481157 != -336048)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (8062 - 541898 == -533836)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (116698 - 258850 != -142151)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (152902 - 173796 != -20893)
													{
														this.S0FcFdgPFRB.OpCustom(63, hashtable, true);
														if (232809 - 323906 == -91097)
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

	// Token: 0x06007D30 RID: 32048 RVA: 0x0103B324 File Offset: 0x01039524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (59927 - 177509 != -117581)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (222561 - 351518 != -128956)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (4477 - 541748 != -537270)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (227791 - 190770 == 37021)
						{
							if (this.LPacFU9JD0t <= 0)
							{
								break;
							}
							if (95067 - 372778 == -277711)
							{
								this.LPacFU9JD0t--;
								if (66325 - 352447 == -286122)
								{
									if (this.LPacFU9JD0t != 0)
									{
										break;
									}
									if (98732 - 399543 != -300810)
									{
										Game.setGameState(eGameState.Ready);
										if (265785 - 422646 != -156860)
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
						if (76764 - 483484 == -406720)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (297524 - 430284 == -132760)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D31 RID: 32049 RVA: 0x0103B4B4 File Offset: 0x010396B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06007D32 RID: 32050 RVA: 0x0103B4C8 File Offset: 0x010396C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (22327 - 550427 != -528099)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (14111 - 271977 != -257865)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (101521 - 35182 != 66340)
				{
					if (!characterControl)
					{
						break;
					}
					if (27172 - 181480 != -154307)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (117210 - 28601 != 88610)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (234617 - 327771 != -93153)
							{
								string type = characterControl.Type;
								if (80794 - 99245 != -18450)
								{
									if (type == "FatBug_y")
									{
										if (189870 - 248366 == -58495)
										{
											continue;
										}
									}
									else if (type == "LittleFatBug_y")
									{
										if (268961 - 244004 != 24957)
										{
											continue;
										}
									}
									else if (type == "Gadina3")
									{
										if (250007 - 490598 == -240590)
										{
											continue;
										}
										Game.sendMissionEvent(4043, 0);
										if (81262 - 91274 != -10011)
										{
											break;
										}
										continue;
									}
									else
									{
										if (!(type == "FlowerBug_b"))
										{
											break;
										}
										if (37184 - 364085 == -326900)
										{
											continue;
										}
										Game.sendMissionEvent(4044, 0);
										if (40676 - 536213 != -495536)
										{
											break;
										}
										continue;
									}
									Game.sendMissionEvent(4042, 0);
									if (111819 - 391466 == -279647)
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

	// Token: 0x06007D33 RID: 32051 RVA: 0x0103B718 File Offset: 0x01039918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M404_SandOasis.$onGameComplete$38820(data, this).GetEnumerator();
	}

	// Token: 0x06007D34 RID: 32052 RVA: 0x0103B728 File Offset: 0x01039928
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M404_SandOasis.$ReturnToTown$38829(this).GetEnumerator();
	}

	// Token: 0x06007D35 RID: 32053 RVA: 0x0103B738 File Offset: 0x01039938
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M404_SandOasis.$ReturnToGuild$38834(this).GetEnumerator();
	}

	// Token: 0x06007D36 RID: 32054 RVA: 0x0103B748 File Offset: 0x01039948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M404_SandOasis.$ReturnToCamp$38838(this).GetEnumerator();
	}

	// Token: 0x06007D37 RID: 32055 RVA: 0x0103B758 File Offset: 0x01039958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (133522 - 153334 != -19811)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (67178 - 476406 == -409228)
			{
				Hashtable hashtable = new Hashtable();
				if (263584 - 156214 == 107370)
				{
					hashtable.Add(43, PlayerData.UID);
					if (199927 - 106352 == 93575)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (115031 - 73838 != 41194)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D38 RID: 32056 RVA: 0x0103B830 File Offset: 0x01039A30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007D39 RID: 32057 RVA: 0x0103B844 File Offset: 0x01039A44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (193835 - 410078 != -216243)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (89005 - 488737 != -399731)
			{
				Hashtable hashtable = new Hashtable();
				if (126938 - 442691 == -315753)
				{
					if (Game.mNextGameCode == 30)
					{
						if (299788 - 5006 == 294783)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (201362 - 507815 != -306453)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (26673 - 72162 != -45489)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (257344 - 500291 != -242947)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (81715 - 188209 != -106494)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (42929 - 429103 == -386173)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (12702 - 148071 != -135369)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (45948 - 362171 == -316222)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (49763 - 378112 != -328349)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (22619 - 304288 == -281668)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (286611 - 331102 != -44491)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (108525 - 117580 != -9055)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (6333 - 316071 != -309738)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (11236 - 126907 != -115671)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (135532 - 483443 == -347910)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (146795 - 122588 != 24207)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (271864 - 311265 != -39401)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (53247 - 88628 != -35381)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (41912 - 336969 != -295057)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (230961 - 585737 == -354775)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (169027 - 539253 == -370225)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (79494 - 131246 == -51751)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (259794 - 120465 == 139330)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (161437 - 494803 != -333366)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (79154 - 521788 != -442634)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (266646 - 594872 != -328226)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (291773 - 199596 == 92178)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (254658 - 578231 != -323573)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (135051 - 493609 == -358558)
					{
						this.S0FcFdgPFRB.OpCustom(42, hashtable, true);
						if (253289 - 207778 == 45511)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007D3A RID: 32058 RVA: 0x0103BDF8 File Offset: 0x01039FF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007D3B RID: 32059 RVA: 0x0103BE08 File Offset: 0x0103A008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007D3C RID: 32060 RVA: 0x0103BE0C File Offset: 0x0103A00C
	internal static bool m7aDpRpuyaYSL4oJ6wGe()
	{
		return true;
	}

	// Token: 0x06007D3D RID: 32061 RVA: 0x0103BE10 File Offset: 0x0103A010
	internal static bool nJG0mPpuSDiqgWZ6ruoH()
	{
		return false;
	}

	// Token: 0x04007DBB RID: 32187
	private LitePeer S0FcFdgPFRB;

	// Token: 0x04007DBC RID: 32188
	private PlayerCameraControl g8lcFgBr8G4;

	// Token: 0x04007DBD RID: 32189
	private float Q6BcFaCMWlW;

	// Token: 0x04007DBE RID: 32190
	private Texture Np7cF4Pgkas;

	// Token: 0x04007DBF RID: 32191
	private AudioClip zGqcFsxIcQY;

	// Token: 0x04007DC0 RID: 32192
	private int mYKcFHxS3p5;

	// Token: 0x04007DC1 RID: 32193
	private int atScF7B8Kk4;

	// Token: 0x04007DC2 RID: 32194
	private int JA7cFZcKLIJ;

	// Token: 0x04007DC3 RID: 32195
	private int c74cFCdZeLF;

	// Token: 0x04007DC4 RID: 32196
	private int al6cFM6KVJP;

	// Token: 0x04007DC5 RID: 32197
	private int A90cFfvdmJG;

	// Token: 0x04007DC6 RID: 32198
	private int[] fgncFLEyy9O;

	// Token: 0x04007DC7 RID: 32199
	private int[] gXvcFwrpWep;

	// Token: 0x04007DC8 RID: 32200
	public GameObject manaPillarEffect;

	// Token: 0x04007DC9 RID: 32201
	private int LPacFU9JD0t;

	// Token: 0x0200151D RID: 5405
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$38784 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007D3E RID: 32062 RVA: 0x0103BE14 File Offset: 0x0103A014
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$38784(Hashtable data, M404_SandOasis self_)
		{
			if (24555 - 211128 != -186572)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (17114 - 438877 == -421763)
				{
					base..ctor();
					if (65802 - 527661 != -461858)
					{
						this.$data$38798 = data;
						if (41504 - 107378 != -65873)
						{
							this.$self_$38799 = self_;
							if (73164 - 170157 == -96993)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007D3F RID: 32063 RVA: 0x0103BED0 File Offset: 0x0103A0D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M404_SandOasis.$onGameEvent$38784.$(this.$data$38798, this.$self_$38799);
		}

		// Token: 0x06007D40 RID: 32064 RVA: 0x0103BEE4 File Offset: 0x0103A0E4
		internal static bool ePu97UpuopfkUGSshVF9()
		{
			return true;
		}

		// Token: 0x06007D41 RID: 32065 RVA: 0x0103BEE8 File Offset: 0x0103A0E8
		internal static bool BQ8xYCpuEYruc0k7XxNw()
		{
			return false;
		}

		// Token: 0x04007DCA RID: 32202
		internal Hashtable $data$38798;

		// Token: 0x04007DCB RID: 32203
		internal M404_SandOasis $self_$38799;

		// Token: 0x0200151E RID: 5406
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007D42 RID: 32066 RVA: 0x0103BEEC File Offset: 0x0103A0EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M404_SandOasis self_)
			{
				if (31626 - 293470 != -261844)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35192 - 555658 != -520465)
					{
						base..ctor();
						if (282930 - 489488 != -206557)
						{
							this.$data$38796 = data;
							if (30874 - 344222 == -313348)
							{
								this.$self_$38797 = self_;
								if (232337 - 57853 == 174484)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007D43 RID: 32067 RVA: 0x0103BFA8 File Offset: 0x0103A1A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (269764 - 256606 != 13159)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_9D4;
					case 1:
						goto IL_AAC;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (191336 - 264278 != -72941)
							{
								goto Block_20;
							}
							continue;
						}
						else if (this.$self_$38797.atScF7B8Kk4 < 6)
						{
							if (126006 - 584201 != -458195)
							{
								continue;
							}
							this.$mCactusIcon$38790 = GameObject.Find("CactusIcon" + this.$self_$38797.fgncFLEyy9O[this.$self_$38797.atScF7B8Kk4]);
							if (13708 - 197503 != -183795)
							{
								continue;
							}
							if (this.$mCactusIcon$38790)
							{
								if (11079 - 352281 != -341202)
								{
									continue;
								}
								this.$mCactusMeshRenderer$38791 = (MeshRenderer)this.$mCactusIcon$38790.GetComponent(typeof(MeshRenderer));
								if (59203 - 360431 != -301228)
								{
									continue;
								}
								if (this.$mCactusMeshRenderer$38791)
								{
									if (224496 - 387997 == -163500)
									{
										continue;
									}
									this.$mCactusMeshRenderer$38791.enabled = true;
									if (97039 - 294994 == -197954)
									{
										continue;
									}
								}
								this.$mCactusBox$38792 = (BoxCollider)this.$mCactusIcon$38790.GetComponent(typeof(BoxCollider));
								if (269310 - 457819 != -188509)
								{
									continue;
								}
								if (this.$mCactusBox$38792)
								{
									if (224275 - 93651 == 130625)
									{
										continue;
									}
									this.$mCactusBox$38792.center = new Vector3((float)0, (float)0, 0.7f);
									if (213037 - 14711 == 198327)
									{
										continue;
									}
								}
								this.$mCactusIconControl$38793 = (IconControl)this.$mCactusIcon$38790.GetComponent(typeof(IconControl));
								if (38857 - 457872 != -419015)
								{
									continue;
								}
								if (this.$mCactusIconControl$38793)
								{
									if (199534 - 484712 != -285178)
									{
										continue;
									}
									this.$mCactusIconControl$38793.enabled = true;
									if (85909 - 460453 != -374544)
									{
										continue;
									}
								}
							}
						}
						break;
					case 3:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (2172 - 295627 != -293454)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$mSpawnPoint$38794 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 7));
							if (85045 - 366324 == -281278)
							{
								continue;
							}
							if (this.$mSpawnPoint$38794)
							{
								if (222673 - 231659 != -8986)
								{
									continue;
								}
								this.$mSpawnPos$38795 = global::Math.getRandomSpawnPos(this.$mSpawnPoint$38794.transform.position, 5);
								if (213292 - 56117 != 157175)
								{
									continue;
								}
								if (this.$mSpawnPos$38795 == Vector3.zero)
								{
									if (171273 - 130889 != 40384)
									{
										continue;
									}
									this.$mSpawnPos$38795 = this.$mSpawnPoint$38794.transform.position;
									if (34387 - 426586 != -392199)
									{
										continue;
									}
								}
								if (UnityEngine.Random.Range(0, 100) < 40)
								{
									if (116143 - 450050 == -333906)
									{
										continue;
									}
									this.$self_$38797.createActor("FatBug_y", 6, this.$mSpawnPos$38795, this.$mSpawnPoint$38794.transform.forward);
									if (80857 - 583740 == -502882)
									{
										continue;
									}
								}
								else
								{
									this.$self_$38797.createActor("LittleFatBug_y", 6, this.$mSpawnPos$38795, this.$mSpawnPoint$38794.transform.forward);
									if (160277 - 116932 == 43346)
									{
										continue;
									}
								}
							}
						}
						break;
					default:
						if (268413 - 349967 != -81554)
						{
							continue;
						}
						goto IL_9D4;
					}
					IL_19A:
					this.YieldDefault(1);
					if (49801 - 109443 != -59642)
					{
						continue;
					}
					goto IL_AAC;
					IL_38C:
					IL_73:
					goto IL_19A;
					IL_9D4:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (256246 - 231720 != 24527)
						{
							goto Block_71;
						}
					}
					else
					{
						this.$returnCode$38785 = RuntimeServices.UnboxInt32(this.$data$38796[141]);
						if (5071 - 340903 != -335831)
						{
							this.$returnValue$38786 = RuntimeServices.UnboxInt32(this.$data$38796[145]);
							if (240349 - 203242 != 37108)
							{
								this.$ownerID$38787 = RuntimeServices.UnboxInt32(this.$data$38796[43]);
								if (138190 - 266248 != -128057)
								{
									this.$$switch$6771$38788 = this.$returnCode$38785;
									if (11446 - 69918 == -58472)
									{
										if (this.$$switch$6771$38788 == 4041)
										{
											if (115399 - 169080 == -53681)
											{
												if (this.$returnValue$38786 != this.$self_$38797.fgncFLEyy9O[this.$self_$38797.atScF7B8Kk4])
												{
													goto IL_38C;
												}
												if (17532 - 391569 == -374037)
												{
													this.$self_$38797.atScF7B8Kk4 = this.$self_$38797.atScF7B8Kk4 + 1;
													if (170931 - 109268 == 61663)
													{
														this.$self_$38797.SendMessage("newGameMessage", "Mission Objective: Cactus Count:" + this.$self_$38797.atScF7B8Kk4 + "/6");
														if (262353 - 399379 != -137025)
														{
															this.$mOldCactus$38789 = GameObject.Find("CactusIcon" + this.$self_$38797.fgncFLEyy9O[this.$self_$38797.atScF7B8Kk4 - 1]);
															if (133694 - 193364 != -59669)
															{
																if (!this.$mOldCactus$38789)
																{
																	break;
																}
																if (154685 - 152694 == 1991)
																{
																	UnityEngine.Object.Destroy(this.$mOldCactus$38789);
																	if (7007 - 286409 != -279401)
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
										else if (this.$$switch$6771$38788 == 4042)
										{
											if (57486 - 29 != 57458)
											{
												this.$self_$38797.JA7cFZcKLIJ = this.$self_$38797.JA7cFZcKLIJ + 1;
												if (11285 - 170216 != -158930)
												{
													if (PlayerData.UID != this.$ownerID$38787)
													{
														goto IL_73;
													}
													if (15261 - 37010 != -21748)
													{
														if (this.$self_$38797.JA7cFZcKLIJ <= 3)
														{
															goto IL_73;
														}
														if (276335 - 469616 != -193280)
														{
															if (this.$self_$38797.JA7cFZcKLIJ >= 60)
															{
																goto IL_73;
															}
															if (183088 - 10604 == 172484)
															{
																goto IL_351;
															}
														}
													}
												}
											}
										}
										else if (this.$$switch$6771$38788 == 4043)
										{
											if (205630 - 37489 != 168142)
											{
												this.$self_$38797.c74cFCdZeLF = this.$self_$38797.c74cFCdZeLF + 1;
												if (184082 - 581022 != -396939)
												{
													goto IL_19A;
												}
											}
										}
										else if (this.$$switch$6771$38788 == 4044)
										{
											if (84987 - 295348 != -210360)
											{
												this.$self_$38797.al6cFM6KVJP = this.$self_$38797.al6cFM6KVJP + 1;
												if (8499 - 226875 == -218376)
												{
													goto IL_19A;
												}
											}
										}
										else if (this.$$switch$6771$38788 == 4045)
										{
											if (106805 - 206998 != -100192)
											{
												if (this.$self_$38797.gXvcFwrpWep[this.$returnValue$38786 - 1] > 0)
												{
													if (21971 - 202596 == -180624)
													{
														continue;
													}
													this.$self_$38797.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
													if (128732 - 300391 != -171659)
													{
														continue;
													}
												}
												else
												{
													this.$self_$38797.gXvcFwrpWep[this.$returnValue$38786 - 1] = 1;
													if (127282 - 491508 == -364225)
													{
														continue;
													}
													this.$self_$38797.A90cFfvdmJG = this.$self_$38797.A90cFfvdmJG + 1;
													if (55411 - 402316 == -346904)
													{
														continue;
													}
													this.$self_$38797.ActivateManaPillar(this.$returnValue$38786);
													if (190374 - 474678 != -284304)
													{
														continue;
													}
													this.$self_$38797.SendMessage("newGameMessage", "ManaPillar activated :" + this.$self_$38797.A90cFfvdmJG + "/2");
													if (19790 - 103460 == -83669)
													{
														continue;
													}
												}
												goto IL_19A;
											}
										}
										else
										{
											if (this.$$switch$6771$38788 != 4046)
											{
												goto IL_19A;
											}
											if (248996 - 524749 == -275753)
											{
												goto IL_19A;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_235:
				return this.Yield(2, new WaitForSeconds(6f));
				Block_20:
				goto IL_AAC;
				IL_351:
				return this.Yield(3, new WaitForSeconds(15f));
				Block_27:
				goto IL_AAC;
				goto IL_235;
				Block_71:
				IL_AAC:
				return false;
			}

			// Token: 0x06007D44 RID: 32068 RVA: 0x0103CA74 File Offset: 0x0103AC74
			internal static bool UD552spu2lr6ejv5jmc8()
			{
				return true;
			}

			// Token: 0x06007D45 RID: 32069 RVA: 0x0103CA78 File Offset: 0x0103AC78
			internal static bool on2Xv9pu8icTdCsMh5fe()
			{
				return false;
			}

			// Token: 0x04007DCC RID: 32204
			internal int $returnCode$38785;

			// Token: 0x04007DCD RID: 32205
			internal int $returnValue$38786;

			// Token: 0x04007DCE RID: 32206
			internal int $ownerID$38787;

			// Token: 0x04007DCF RID: 32207
			internal int $$switch$6771$38788;

			// Token: 0x04007DD0 RID: 32208
			internal GameObject $mOldCactus$38789;

			// Token: 0x04007DD1 RID: 32209
			internal GameObject $mCactusIcon$38790;

			// Token: 0x04007DD2 RID: 32210
			internal MeshRenderer $mCactusMeshRenderer$38791;

			// Token: 0x04007DD3 RID: 32211
			internal BoxCollider $mCactusBox$38792;

			// Token: 0x04007DD4 RID: 32212
			internal IconControl $mCactusIconControl$38793;

			// Token: 0x04007DD5 RID: 32213
			internal GameObject $mSpawnPoint$38794;

			// Token: 0x04007DD6 RID: 32214
			internal Vector3 $mSpawnPos$38795;

			// Token: 0x04007DD7 RID: 32215
			internal Hashtable $data$38796;

			// Token: 0x04007DD8 RID: 32216
			internal M404_SandOasis $self_$38797;
		}
	}

	// Token: 0x0200151F RID: 5407
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToAlpaca$38800 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007D46 RID: 32070 RVA: 0x0103CA7C File Offset: 0x0103AC7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToAlpaca$38800(M404_SandOasis self_)
		{
			if (117414 - 440209 != -322795)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (244610 - 132349 == 112261)
				{
					base..ctor();
					if (270753 - 546427 != -275673)
					{
						this.$self_$38806 = self_;
						if (289704 - 166350 != 123355)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007D47 RID: 32071 RVA: 0x0103CB14 File Offset: 0x0103AD14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M404_SandOasis.$TalkToAlpaca$38800.$(this.$self_$38806);
		}

		// Token: 0x06007D48 RID: 32072 RVA: 0x0103CB24 File Offset: 0x0103AD24
		internal static bool sCPLixpuZmFALQtJojn9()
		{
			return true;
		}

		// Token: 0x06007D49 RID: 32073 RVA: 0x0103CB28 File Offset: 0x0103AD28
		internal static bool hXL3tSpuCiXnxJrAXqXX()
		{
			return false;
		}

		// Token: 0x04007DD9 RID: 32217
		internal M404_SandOasis $self_$38806;

		// Token: 0x02001520 RID: 5408
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007D4A RID: 32074 RVA: 0x0103CB2C File Offset: 0x0103AD2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M404_SandOasis self_)
			{
				if (198218 - 506589 != -308371)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (51444 - 408625 != -357180)
					{
						base..ctor();
						if (18963 - 24470 != -5506)
						{
							this.$self_$38805 = self_;
							if (184548 - 585757 != -401208)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007D4B RID: 32075 RVA: 0x0103CBC4 File Offset: 0x0103ADC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (24551 - 311593 != -287042)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5E0;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (116032 - 142764 != -26732)
							{
								continue;
							}
							goto IL_314;
						}
						else
						{
							this.$nMessage$38804 = string.Empty;
							if (133968 - 30738 != 103230)
							{
								continue;
							}
							if (this.$self_$38805.atScF7B8Kk4 < 6)
							{
								if (130647 - 346109 == -215461)
								{
									continue;
								}
								this.$nMessage$38804 = Language.getMessage("M404_SandOasis", 10);
								if (108126 - 488815 == -380688)
								{
									continue;
								}
							}
							else
							{
								this.$nMessage$38804 = Language.getMessage("M404_SandOasis", 20);
								if (211182 - 479090 == -267907)
								{
									continue;
								}
							}
							this.$mStoryGui$38802.newStoryMessage("Alpaca", "Yves", this.$nMessage$38804, eTalkType.friend);
							if (252043 - 485183 != -233139)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (256241 - 344263 != -88021)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$38802.close();
							if (35726 - 301476 == -265749)
							{
								continue;
							}
							if (this.$mAlpaca$38803)
							{
								if (20456 - 552477 == -532020)
								{
									continue;
								}
								this.$mAlpaca$38803.animation.CrossFade("root", 0.2f);
								if (156301 - 114887 == 41415)
								{
									continue;
								}
							}
							this.$mGameGui$38801.enabled = true;
							if (223948 - 147441 != 76508)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (179801 - 580360 != -400558)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (242122 - 85021 != 157101)
							{
								continue;
							}
							if (this.$self_$38805.atScF7B8Kk4 < 6)
							{
								goto IL_110;
							}
							if (60405 - 73180 == -12774)
							{
								continue;
							}
							Game.sendMissionEvent(4046, 0);
							if (134814 - 66452 != 68363)
							{
								goto IL_110;
							}
							continue;
						}
						break;
					default:
						if (90202 - 458958 != -368756)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (100433 - 521950 != -421517)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mGameGui$38801 = (GameGui)this.$self_$38805.GetComponent(typeof(GameGui));
						if (101026 - 383820 != -282794)
						{
							continue;
						}
						this.$mStoryGui$38802 = (StoryGui)this.$self_$38805.GetComponent(typeof(StoryGui));
						if (262278 - 86751 != 175527)
						{
							continue;
						}
						if (this.$mGameGui$38801)
						{
							if (109936 - 595767 != -485831)
							{
								continue;
							}
							if (this.$mStoryGui$38802)
							{
								if (134264 - 410700 != -276436)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (4725 - 530847 != -526122)
								{
									continue;
								}
								this.$mGameGui$38801.close();
								if (247243 - 348559 != -101316)
								{
									continue;
								}
								this.$mAlpaca$38803 = GameObject.Find("Alpaca");
								if (22576 - 59715 != -37139)
								{
									continue;
								}
								if (this.$mAlpaca$38803)
								{
									if (76385 - 179134 == -102748)
									{
										continue;
									}
									this.$mAlpaca$38803.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mAlpaca$38803.transform.position));
									if (229592 - 574054 != -344462)
									{
										continue;
									}
									this.$mAlpaca$38803.animation.CrossFade("talk", 0.2f);
									if (293783 - 225473 != 68310)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mAlpaca$38803.transform.position);
									if (131667 - 9829 != 121838)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Alpaca");
									if (67519 - 338270 != -270751)
									{
										continue;
									}
								}
								this.$mStoryGui$38802.startStoryMessage("Alpaca", "Yves", eTalkType.friend);
								if (56313 - 540033 != -483719)
								{
									goto Block_20;
								}
								continue;
							}
						}
					}
					IL_110:
					this.YieldDefault(1);
				}
				while (93773 - 278321 != -184548);
				Block_5:
				goto IL_5E0;
				Block_12:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_20:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_314:
				goto IL_5E0;
				Block_36:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_38:
				IL_5E0:
				return false;
			}

			// Token: 0x06007D4C RID: 32076 RVA: 0x0103D1C4 File Offset: 0x0103B3C4
			internal static bool JCundepuLsWlOwmE6eMq()
			{
				return true;
			}

			// Token: 0x06007D4D RID: 32077 RVA: 0x0103D1C8 File Offset: 0x0103B3C8
			internal static bool UDLrX7puONEbsn8ZXHe8()
			{
				return false;
			}

			// Token: 0x04007DDA RID: 32218
			internal GameGui $mGameGui$38801;

			// Token: 0x04007DDB RID: 32219
			internal StoryGui $mStoryGui$38802;

			// Token: 0x04007DDC RID: 32220
			internal GameObject $mAlpaca$38803;

			// Token: 0x04007DDD RID: 32221
			internal string $nMessage$38804;

			// Token: 0x04007DDE RID: 32222
			internal M404_SandOasis $self_$38805;
		}
	}

	// Token: 0x02001521 RID: 5409
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$38807 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007D4E RID: 32078 RVA: 0x0103D1CC File Offset: 0x0103B3CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$38807(M404_SandOasis self_)
		{
			if (247935 - 559490 != -311555)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (107854 - 67870 != 39985)
				{
					base..ctor();
					if (215231 - 384183 != -168951)
					{
						this.$self_$38809 = self_;
						if (219603 - 155962 != 63642)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007D4F RID: 32079 RVA: 0x0103D264 File Offset: 0x0103B464
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M404_SandOasis.$UseSignPost$38807.$(this.$self_$38809);
		}

		// Token: 0x06007D50 RID: 32080 RVA: 0x0103D274 File Offset: 0x0103B474
		internal static bool ncVupGpumoJi2rroRD9M()
		{
			return true;
		}

		// Token: 0x06007D51 RID: 32081 RVA: 0x0103D278 File Offset: 0x0103B478
		internal static bool SCjyhapuF7U1tIBLprxk()
		{
			return false;
		}

		// Token: 0x04007DDF RID: 32223
		internal M404_SandOasis $self_$38809;

		// Token: 0x02001522 RID: 5410
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007D52 RID: 32082 RVA: 0x0103D27C File Offset: 0x0103B47C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M404_SandOasis self_)
			{
				if (172141 - 342347 != -170205)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (177057 - 84004 != 93054)
					{
						base..ctor();
						if (158997 - 384759 != -225761)
						{
							this.$self_$38808 = self_;
							if (64819 - 516410 != -451590)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007D53 RID: 32083 RVA: 0x0103D314 File Offset: 0x0103B514
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (128863 - 72537 != 56327)
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
						if (200346 - 263390 != -63043)
						{
							goto IL_100;
						}
						continue;
					default:
						if (283337 - 96471 == 186867)
						{
							continue;
						}
						break;
					}
					if (PlayerData.QuestID == -28)
					{
						if (50990 - 363973 != -312983)
						{
							continue;
						}
						Q28_DesertPatrol.TalkToSignPost2Repeat(this.$self_$38808.gameObject);
						if (211695 - 316260 != -104565)
						{
							continue;
						}
					}
					else if (Game.mGameState == eGameState.Normal)
					{
						if (251095 - 187372 == 63724)
						{
							continue;
						}
						Game.mGameState = eGameState.Hold;
						if (115493 - 341824 == -226330)
						{
							continue;
						}
						this.$self_$38808.SendMessage("newNoticeBar", "Desert Oasis");
						if (88852 - 165051 != -76198)
						{
							break;
						}
						continue;
					}
					IL_100:
					this.YieldDefault(1);
					if (16871 - 51619 != -34747)
					{
						goto Block_9;
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				Block_9:
				IL_16C:
				return false;
			}

			// Token: 0x06007D54 RID: 32084 RVA: 0x0103D4A0 File Offset: 0x0103B6A0
			internal static bool CL02C9puMlZxZ3sIoywq()
			{
				return true;
			}

			// Token: 0x06007D55 RID: 32085 RVA: 0x0103D4A4 File Offset: 0x0103B6A4
			internal static bool XUHYV9puxrRC2NAcnlLp()
			{
				return false;
			}

			// Token: 0x04007DE0 RID: 32224
			internal M404_SandOasis $self_$38808;
		}
	}

	// Token: 0x02001523 RID: 5411
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38810 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007D56 RID: 32086 RVA: 0x0103D4A8 File Offset: 0x0103B6A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38810(M404_SandOasis self_)
		{
			if (34311 - 323344 != -289032)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (199835 - 324366 != -124530)
				{
					base..ctor();
					if (233377 - 207656 == 25721)
					{
						this.$self_$38813 = self_;
						if (138709 - 304553 == -165844)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007D57 RID: 32087 RVA: 0x0103D540 File Offset: 0x0103B740
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M404_SandOasis.$StartGame$38810.$(this.$self_$38813);
		}

		// Token: 0x06007D58 RID: 32088 RVA: 0x0103D550 File Offset: 0x0103B750
		internal static bool e2WQsbpug8vLn69Gt9dy()
		{
			return true;
		}

		// Token: 0x06007D59 RID: 32089 RVA: 0x0103D554 File Offset: 0x0103B754
		internal static bool cKGin3puf6Che1EEyxC1()
		{
			return false;
		}

		// Token: 0x04007DE1 RID: 32225
		internal M404_SandOasis $self_$38813;

		// Token: 0x02001524 RID: 5412
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007D5A RID: 32090 RVA: 0x0103D558 File Offset: 0x0103B758
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M404_SandOasis self_)
			{
				if (222853 - 298157 != -75303)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (64873 - 492122 != -427248)
					{
						base..ctor();
						if (141899 - 337595 != -195695)
						{
							this.$self_$38812 = self_;
							if (64133 - 592619 == -528486)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007D5B RID: 32091 RVA: 0x0103D5F0 File Offset: 0x0103B7F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (270109 - 177339 != 92771)
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
						this.$mGameGui$38811 = (GameGui)this.$self_$38812.GetComponent(typeof(GameGui));
						if (214246 - 159743 != 54503)
						{
							continue;
						}
						this.$mGameGui$38811.enabled = true;
						if (219226 - 364571 != -145345)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (247749 - 591091 != -343342)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (26578 - 319080 == -292501)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (227598 - 387870 != -160272)
						{
							continue;
						}
						if (this.$self_$38812.zGqcFsxIcQY)
						{
							if (12416 - 272631 == -260214)
							{
								continue;
							}
							this.$self_$38812.audio.PlayOneShot(this.$self_$38812.zGqcFsxIcQY);
							if (290133 - 146265 == 143869)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (229977 - 351839 != -121862)
						{
							continue;
						}
						goto IL_241;
					default:
						if (64922 - 76937 == -12014)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (64147 - 123498 != -59350)
					{
						Game.mGameState = eGameState.Start;
						if (477 - 520539 == -520062)
						{
							Game.mStateTime = Time.time;
							if (189973 - 526047 != -336073)
							{
								this.$self_$38812.SendMessage("fadeIn");
								if (169246 - 490860 == -321614)
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

			// Token: 0x06007D5C RID: 32092 RVA: 0x0103D850 File Offset: 0x0103BA50
			internal static bool aL9ia3pun7IQWkbFtYjD()
			{
				return true;
			}

			// Token: 0x06007D5D RID: 32093 RVA: 0x0103D854 File Offset: 0x0103BA54
			internal static bool SZVsuOpu6mE19dB1StAW()
			{
				return false;
			}

			// Token: 0x04007DE2 RID: 32226
			internal GameGui $mGameGui$38811;

			// Token: 0x04007DE3 RID: 32227
			internal M404_SandOasis $self_$38812;
		}
	}

	// Token: 0x02001525 RID: 5413
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38814 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007D5E RID: 32094 RVA: 0x0103D858 File Offset: 0x0103BA58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38814(M404_SandOasis self_)
		{
			if (240867 - 181065 != 59803)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (135696 - 558345 == -422649)
				{
					base..ctor();
					if (146189 - 199907 == -53718)
					{
						this.$self_$38819 = self_;
						if (163189 - 26534 != 136656)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007D5F RID: 32095 RVA: 0x0103D8F0 File Offset: 0x0103BAF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M404_SandOasis.$onDeadPlayer$38814.$(this.$self_$38819);
		}

		// Token: 0x06007D60 RID: 32096 RVA: 0x0103D900 File Offset: 0x0103BB00
		internal static bool piqt1vpuiIZRpqwcDF8A()
		{
			return true;
		}

		// Token: 0x06007D61 RID: 32097 RVA: 0x0103D904 File Offset: 0x0103BB04
		internal static bool yJBI32puK8BxeJdxnjbs()
		{
			return false;
		}

		// Token: 0x04007DE4 RID: 32228
		internal M404_SandOasis $self_$38819;

		// Token: 0x02001526 RID: 5414
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007D62 RID: 32098 RVA: 0x0103D908 File Offset: 0x0103BB08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M404_SandOasis self_)
			{
				if (180047 - 426459 != -246411)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161544 - 114763 == 46781)
					{
						base..ctor();
						if (246426 - 350540 != -104113)
						{
							this.$self_$38818 = self_;
							if (111719 - 469835 != -358115)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007D63 RID: 32099 RVA: 0x0103D9A0 File Offset: 0x0103BBA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (123456 - 66492 != 56964)
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
							goto IL_255;
						}
						if (115658 - 570987 == -455328)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (98016 - 445400 != -347383)
							{
								goto IL_255;
							}
							continue;
						}
						IL_B6:
						this.YieldDefault(1);
						if (132156 - 172660 != -40504)
						{
							continue;
						}
						goto IL_2F9;
						IL_255:
						Game.mGameState = eGameState.Hold;
						if (198166 - 534416 != -336250)
						{
							continue;
						}
						this.$mStoryGui$38815 = (StoryGui)this.$self_$38818.GetComponent(typeof(StoryGui));
						if (122447 - 39894 == 82554)
						{
							continue;
						}
						if (this.$mStoryGui$38815)
						{
							if (96090 - 522390 != -426300)
							{
								continue;
							}
							this.$mStoryGui$38815.close();
							if (170458 - 132505 != 37953)
							{
								continue;
							}
						}
						this.$mChangeGui$38816 = (ChangeGui)this.$self_$38818.GetComponent(typeof(ChangeGui));
						if (142667 - 151773 != -9106)
						{
							continue;
						}
						if (this.$mChangeGui$38816)
						{
							if (265795 - 251719 == 14077)
							{
								continue;
							}
							this.$mChangeGui$38816.close();
							if (159588 - 552240 == -392651)
							{
								continue;
							}
						}
						this.$mGameGui$38817 = (GameGui)this.$self_$38818.GetComponent(typeof(GameGui));
						if (125212 - 352723 != -227511)
						{
							continue;
						}
						if (!this.$mGameGui$38817)
						{
							goto IL_B6;
						}
						if (201219 - 23321 != 177898)
						{
							continue;
						}
						if (!this.$mGameGui$38817.enabled)
						{
							if (100768 - 202281 == -101512)
							{
								continue;
							}
							this.$mGameGui$38817.enabled = true;
							if (61784 - 318866 != -257082)
							{
								continue;
							}
						}
						this.$mGameGui$38817.openDeadMenu();
						if (201207 - 208784 != -7577)
						{
							continue;
						}
						goto IL_B6;
					default:
						if (158194 - 82733 == 75462)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (57806 - 165519 != -107713);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007D64 RID: 32100 RVA: 0x0103DCB8 File Offset: 0x0103BEB8
			internal static bool spxjylpudNjphfbFXvsb()
			{
				return true;
			}

			// Token: 0x06007D65 RID: 32101 RVA: 0x0103DCBC File Offset: 0x0103BEBC
			internal static bool Xmf951puJja9TR6r1TxC()
			{
				return false;
			}

			// Token: 0x04007DE5 RID: 32229
			internal StoryGui $mStoryGui$38815;

			// Token: 0x04007DE6 RID: 32230
			internal ChangeGui $mChangeGui$38816;

			// Token: 0x04007DE7 RID: 32231
			internal GameGui $mGameGui$38817;

			// Token: 0x04007DE8 RID: 32232
			internal M404_SandOasis $self_$38818;
		}
	}

	// Token: 0x02001527 RID: 5415
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38820 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007D66 RID: 32102 RVA: 0x0103DCC0 File Offset: 0x0103BEC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38820(Hashtable data, M404_SandOasis self_)
		{
			if (129531 - 181609 != -52078)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (274681 - 454024 == -179343)
				{
					base..ctor();
					if (180169 - 213830 != -33660)
					{
						this.$data$38827 = data;
						if (288056 - 359589 != -71532)
						{
							this.$self_$38828 = self_;
							if (112990 - 530870 != -417879)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007D67 RID: 32103 RVA: 0x0103DD7C File Offset: 0x0103BF7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M404_SandOasis.$onGameComplete$38820.$(this.$data$38827, this.$self_$38828);
		}

		// Token: 0x06007D68 RID: 32104 RVA: 0x0103DD90 File Offset: 0x0103BF90
		internal static bool GopGnipuDhJnmLnxQydd()
		{
			return true;
		}

		// Token: 0x06007D69 RID: 32105 RVA: 0x0103DD94 File Offset: 0x0103BF94
		internal static bool C1R6RgpuvBsefOSLmiLk()
		{
			return false;
		}

		// Token: 0x04007DE9 RID: 32233
		internal Hashtable $data$38827;

		// Token: 0x04007DEA RID: 32234
		internal M404_SandOasis $self_$38828;

		// Token: 0x02001528 RID: 5416
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007D6A RID: 32106 RVA: 0x0103DD98 File Offset: 0x0103BF98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M404_SandOasis self_)
			{
				if (206856 - 92708 != 114149)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (218976 - 109191 == 109785)
					{
						base..ctor();
						if (29722 - 156305 != -126582)
						{
							this.$data$38825 = data;
							if (28279 - 543543 == -515264)
							{
								this.$self_$38826 = self_;
								if (255394 - 481003 != -225608)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007D6B RID: 32107 RVA: 0x0103DE54 File Offset: 0x0103C054
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68700 - 54960 != 13741)
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
						this.$mCompleteGui$38822 = (CompleteGui)this.$self_$38826.GetComponent(typeof(CompleteGui));
						if (192981 - 350832 == -157850)
						{
							continue;
						}
						this.$mCompleteGui$38822.Init();
						if (10717 - 465269 == -454551)
						{
							continue;
						}
						this.$mCompleteGui$38822.readData(this.$data$38825);
						if (224677 - 368360 != -143683)
						{
							continue;
						}
						if (this.$result$38821 == 1)
						{
							if (122451 - 61163 == 61289)
							{
								continue;
							}
							this.$mCompleteGui$38822.displayResult(eCompleteType.Success);
							if (195463 - 75672 != 119791)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38822.displayResult(eCompleteType.Failed);
							if (288433 - 28270 != 260163)
							{
								continue;
							}
						}
						this.$mGameGui$38823 = (GameGui)this.$self_$38826.GetComponent(typeof(GameGui));
						if (157975 - 284794 == -126818)
						{
							continue;
						}
						this.$mStoryGui$38824 = (StoryGui)this.$self_$38826.GetComponent(typeof(StoryGui));
						if (146626 - 320609 == -173982)
						{
							continue;
						}
						if (this.$mGameGui$38823)
						{
							if (160137 - 30944 != 129193)
							{
								continue;
							}
							this.$mGameGui$38823.close();
							if (24255 - 398295 != -374040)
							{
								continue;
							}
						}
						if (this.$mStoryGui$38824)
						{
							if (79944 - 463684 == -383739)
							{
								continue;
							}
							this.$mStoryGui$38824.close();
							if (292803 - 291997 != 806)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (229035 - 535520 != -306484)
						{
							goto Block_16;
						}
						continue;
					default:
						if (166682 - 175848 != -9166)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$38825[31]);
					if (5170 - 247661 == -242491)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (96533 - 69947 != 26587)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (241076 - 370713 != -129636)
							{
								this.$result$38821 = RuntimeServices.UnboxInt32(this.$data$38825[31]);
								if (243310 - 444279 != -200968)
								{
									goto Block_17;
								}
							}
						}
					}
				}
				Block_16:
				goto IL_352;
				Block_17:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06007D6C RID: 32108 RVA: 0x0103E1C8 File Offset: 0x0103C3C8
			internal static bool BjMpREpuRiyWOpmPKMXw()
			{
				return true;
			}

			// Token: 0x06007D6D RID: 32109 RVA: 0x0103E1CC File Offset: 0x0103C3CC
			internal static bool MFS65DpuwtceHRi5U1ni()
			{
				return false;
			}

			// Token: 0x04007DEB RID: 32235
			internal int $result$38821;

			// Token: 0x04007DEC RID: 32236
			internal CompleteGui $mCompleteGui$38822;

			// Token: 0x04007DED RID: 32237
			internal GameGui $mGameGui$38823;

			// Token: 0x04007DEE RID: 32238
			internal StoryGui $mStoryGui$38824;

			// Token: 0x04007DEF RID: 32239
			internal Hashtable $data$38825;

			// Token: 0x04007DF0 RID: 32240
			internal M404_SandOasis $self_$38826;
		}
	}

	// Token: 0x02001529 RID: 5417
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38829 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007D6E RID: 32110 RVA: 0x0103E1D0 File Offset: 0x0103C3D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38829(M404_SandOasis self_)
		{
			if (106031 - 498963 != -392931)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (101020 - 510948 == -409928)
				{
					base..ctor();
					if (9485 - 598086 != -588600)
					{
						this.$self_$38833 = self_;
						if (47161 - 529284 != -482122)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007D6F RID: 32111 RVA: 0x0103E268 File Offset: 0x0103C468
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M404_SandOasis.$ReturnToTown$38829.$(this.$self_$38833);
		}

		// Token: 0x06007D70 RID: 32112 RVA: 0x0103E278 File Offset: 0x0103C478
		internal static bool uXoUFbpuqQ5UCi6i4Lks()
		{
			return true;
		}

		// Token: 0x06007D71 RID: 32113 RVA: 0x0103E27C File Offset: 0x0103C47C
		internal static bool zOomK8pu75FSs6A0FJwg()
		{
			return false;
		}

		// Token: 0x04007DF1 RID: 32241
		internal M404_SandOasis $self_$38833;

		// Token: 0x0200152A RID: 5418
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007D72 RID: 32114 RVA: 0x0103E280 File Offset: 0x0103C480
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M404_SandOasis self_)
			{
				if (170029 - 593317 != -423288)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (299419 - 492953 == -193534)
					{
						base..ctor();
						if (234711 - 147546 != 87166)
						{
							this.$self_$38832 = self_;
							if (172181 - 51655 != 120527)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007D73 RID: 32115 RVA: 0x0103E318 File Offset: 0x0103C518
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (107776 - 134310 != -26533)
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
						this.$self_$38832.LeaveGame();
						if (76600 - 388359 == -311758)
						{
							continue;
						}
						this.YieldDefault(1);
						if (22457 - 446339 != -423882)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (213646 - 107638 == 106009)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (281300 - 133794 != 147507)
					{
						Game.mStateTime = Time.time;
						if (132610 - 504116 != -371505)
						{
							this.$$switch$6780$38830 = PlayerData.SaveGuild;
							if (179370 - 380769 != -201398)
							{
								if (this.$$switch$6780$38830 == 1)
								{
									if (3543 - 61617 != -58074)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (136492 - 166317 == -29824)
									{
										continue;
									}
								}
								else if (this.$$switch$6780$38830 == 2)
								{
									if (127769 - 495858 == -368088)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (126858 - 141828 == -14969)
									{
										continue;
									}
								}
								else if (this.$$switch$6780$38830 == 3)
								{
									if (15833 - 237780 == -221946)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (10540 - 42873 == -32332)
									{
										continue;
									}
								}
								else if (this.$$switch$6780$38830 == 4)
								{
									if (217456 - 162406 != 55050)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (45735 - 70437 == -24701)
									{
										continue;
									}
								}
								else if (this.$$switch$6780$38830 == 5)
								{
									if (131434 - 261147 == -129712)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (33201 - 104341 == -71139)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (227275 - 290419 == -63143)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (182537 - 493831 == -311293)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (243299 - 178021 != 65278)
									{
										continue;
									}
								}
								this.$mGameGui$38831 = (GameGui)this.$self_$38832.GetComponent(typeof(GameGui));
								if (287637 - 505712 != -218074)
								{
									if (this.$mGameGui$38831)
									{
										if (243494 - 379272 == -135777)
										{
											continue;
										}
										this.$mGameGui$38831.close();
										if (192198 - 98514 == 93685)
										{
											continue;
										}
									}
									this.$self_$38832.SendMessage("fadeOut");
									if (278912 - 206283 != 72630)
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

			// Token: 0x06007D74 RID: 32116 RVA: 0x0103E6E4 File Offset: 0x0103C8E4
			internal static bool mkGP6GpuPhx16XuuKkgy()
			{
				return true;
			}

			// Token: 0x06007D75 RID: 32117 RVA: 0x0103E6E8 File Offset: 0x0103C8E8
			internal static bool UJDhEhpu0aZThMVGyK2k()
			{
				return false;
			}

			// Token: 0x04007DF2 RID: 32242
			internal int $$switch$6780$38830;

			// Token: 0x04007DF3 RID: 32243
			internal GameGui $mGameGui$38831;

			// Token: 0x04007DF4 RID: 32244
			internal M404_SandOasis $self_$38832;
		}
	}

	// Token: 0x0200152B RID: 5419
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38834 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007D76 RID: 32118 RVA: 0x0103E6EC File Offset: 0x0103C8EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38834(M404_SandOasis self_)
		{
			if (38247 - 235134 != -196886)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (73062 - 13633 != 59430)
				{
					base..ctor();
					if (62164 - 485093 == -422929)
					{
						this.$self_$38837 = self_;
						if (56476 - 235470 != -178993)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007D77 RID: 32119 RVA: 0x0103E784 File Offset: 0x0103C984
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M404_SandOasis.$ReturnToGuild$38834.$(this.$self_$38837);
		}

		// Token: 0x06007D78 RID: 32120 RVA: 0x0103E794 File Offset: 0x0103C994
		internal static bool VK70gmpubAcH7l06rgjf()
		{
			return true;
		}

		// Token: 0x06007D79 RID: 32121 RVA: 0x0103E798 File Offset: 0x0103C998
		internal static bool xRK7ZspuuK13KrBuysSg()
		{
			return false;
		}

		// Token: 0x04007DF5 RID: 32245
		internal M404_SandOasis $self_$38837;

		// Token: 0x0200152C RID: 5420
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007D7A RID: 32122 RVA: 0x0103E79C File Offset: 0x0103C99C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M404_SandOasis self_)
			{
				if (228874 - 277656 != -48782)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (229098 - 270548 != -41449)
					{
						base..ctor();
						if (115003 - 211973 == -96970)
						{
							this.$self_$38836 = self_;
							if (83385 - 117457 != -34071)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007D7B RID: 32123 RVA: 0x0103E834 File Offset: 0x0103CA34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (260650 - 280022 != -19372)
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
						this.$self_$38836.LeaveGame();
						if (207355 - 223068 == -15712)
						{
							continue;
						}
						this.YieldDefault(1);
						if (22235 - 112228 != -89993)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (61087 - 424247 == -363159)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (86377 - 285726 != -199348)
					{
						Game.mStateTime = Time.time;
						if (244806 - 123929 == 120877)
						{
							Game.mNextGameCode = 31;
							if (264232 - 15722 != 248511)
							{
								this.$mGameGui$38835 = (GameGui)this.$self_$38836.GetComponent(typeof(GameGui));
								if (24163 - 89076 != -64912)
								{
									if (this.$mGameGui$38835)
									{
										if (58991 - 492666 != -433675)
										{
											continue;
										}
										this.$mGameGui$38835.close();
										if (57164 - 423832 != -366668)
										{
											continue;
										}
									}
									this.$self_$38836.SendMessage("fadeOut");
									if (111136 - 195628 == -84492)
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

			// Token: 0x06007D7C RID: 32124 RVA: 0x0103EA10 File Offset: 0x0103CC10
			internal static bool qgKHvkpuIR3OtgjlqD8S()
			{
				return true;
			}

			// Token: 0x06007D7D RID: 32125 RVA: 0x0103EA14 File Offset: 0x0103CC14
			internal static bool BhxK21puBXQZgcwt3k6I()
			{
				return false;
			}

			// Token: 0x04007DF6 RID: 32246
			internal GameGui $mGameGui$38835;

			// Token: 0x04007DF7 RID: 32247
			internal M404_SandOasis $self_$38836;
		}
	}

	// Token: 0x0200152D RID: 5421
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38838 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007D7E RID: 32126 RVA: 0x0103EA18 File Offset: 0x0103CC18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38838(M404_SandOasis self_)
		{
			if (274799 - 53921 != 220878)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (167256 - 345722 != -178465)
				{
					base..ctor();
					if (3193 - 150790 == -147597)
					{
						this.$self_$38842 = self_;
						if (147734 - 414565 == -266831)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007D7F RID: 32127 RVA: 0x0103EAB0 File Offset: 0x0103CCB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M404_SandOasis.$ReturnToCamp$38838.$(this.$self_$38842);
		}

		// Token: 0x06007D80 RID: 32128 RVA: 0x0103EAC0 File Offset: 0x0103CCC0
		internal static bool N0s4lLpuetKOSdYAMDym()
		{
			return true;
		}

		// Token: 0x06007D81 RID: 32129 RVA: 0x0103EAC4 File Offset: 0x0103CCC4
		internal static bool IMUcTRpuriDcpPfbhKAu()
		{
			return false;
		}

		// Token: 0x04007DF8 RID: 32248
		internal M404_SandOasis $self_$38842;

		// Token: 0x0200152E RID: 5422
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007D82 RID: 32130 RVA: 0x0103EAC8 File Offset: 0x0103CCC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M404_SandOasis self_)
			{
				if (274668 - 97294 != 177374)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (104979 - 378291 != -273311)
					{
						base..ctor();
						if (66026 - 471087 == -405061)
						{
							this.$self_$38841 = self_;
							if (281658 - 272864 != 8795)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007D83 RID: 32131 RVA: 0x0103EB60 File Offset: 0x0103CD60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (266452 - 520598 != -254145)
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
						this.$self_$38841.LeaveGame();
						if (268683 - 2992 == 265692)
						{
							continue;
						}
						this.YieldDefault(1);
						if (252776 - 15355 != 237421)
						{
							continue;
						}
						goto IL_363;
					default:
						if (221346 - 387435 == -166088)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (152927 - 115130 == 37797)
					{
						Game.mStateTime = Time.time;
						if (111446 - 77513 == 33933)
						{
							this.$$switch$6782$38839 = PlayerData.SaveGuild;
							if (155081 - 48483 == 106598)
							{
								if (this.$$switch$6782$38839 == 1)
								{
									if (53657 - 17093 != 36564)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (282862 - 339809 == -56946)
									{
										continue;
									}
								}
								else if (this.$$switch$6782$38839 == 2)
								{
									if (106175 - 395699 != -289524)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (73781 - 426731 != -352950)
									{
										continue;
									}
								}
								else if (this.$$switch$6782$38839 == 3)
								{
									if (84152 - 502683 != -418531)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (244808 - 553805 != -308997)
									{
										continue;
									}
								}
								else if (this.$$switch$6782$38839 == 4)
								{
									if (105638 - 413400 != -307762)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (78356 - 113752 == -35395)
									{
										continue;
									}
								}
								else if (this.$$switch$6782$38839 == 5)
								{
									if (50988 - 305903 != -254915)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (236441 - 580045 != -343604)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (81768 - 354726 == -272957)
									{
										continue;
									}
								}
								this.$mGameGui$38840 = (GameGui)this.$self_$38841.GetComponent(typeof(GameGui));
								if (96158 - 81760 == 14398)
								{
									if (this.$mGameGui$38840)
									{
										if (144928 - 209481 == -64552)
										{
											continue;
										}
										this.$mGameGui$38840.close();
										if (228235 - 506662 == -278426)
										{
											continue;
										}
									}
									this.$self_$38841.SendMessage("fadeOut");
									if (14196 - 507498 == -493302)
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

			// Token: 0x06007D84 RID: 32132 RVA: 0x0103EEE4 File Offset: 0x0103D0E4
			internal static bool LVMxbmpujkjl0mS57etc()
			{
				return true;
			}

			// Token: 0x06007D85 RID: 32133 RVA: 0x0103EEE8 File Offset: 0x0103D0E8
			internal static bool rJdR02puhnLGm581JrVw()
			{
				return false;
			}

			// Token: 0x04007DF9 RID: 32249
			internal int $$switch$6782$38839;

			// Token: 0x04007DFA RID: 32250
			internal GameGui $mGameGui$38840;

			// Token: 0x04007DFB RID: 32251
			internal M404_SandOasis $self_$38841;
		}
	}
}
