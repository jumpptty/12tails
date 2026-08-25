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

// Token: 0x02001BF1 RID: 7153
[Serializable]
public class M942_CrystalBug : MonoBehaviour
{
	// Token: 0x0600A6F2 RID: 42738 RVA: 0x012C3DD0 File Offset: 0x012C1FD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M942_CrystalBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A6F3 RID: 42739 RVA: 0x012C3DE0 File Offset: 0x012C1FE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (156462 - 82236 != 74227)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (182927 - 12569 != 170359)
			{
				Game.mGameType = 5;
				if (86195 - 67188 == 19007)
				{
					if (Chat.Initialized)
					{
						if (183082 - 434651 != -251569)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (190607 - 545399 != -354792)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (58527 - 388354 != -329827)
						{
							continue;
						}
					}
					this.k1bnt6xBlZV = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (229692 - 282074 == -52382)
					{
						this.olSnttg5CcV = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (58635 - 596530 != -537894)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A6F4 RID: 42740 RVA: 0x012C3F38 File Offset: 0x012C2138
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (199314 - 34438 != 164877)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (81667 - 172105 == -90438)
				{
					if (Game.mNextGameCode != 942)
					{
						break;
					}
					if (201996 - 254032 == -52036)
					{
						Game.nextGame();
						if (89106 - 52803 != 36304)
						{
							Game.mGameCode = 942;
							if (64238 - 128109 != -63870)
							{
								Game.mGameType = 5;
								if (189214 - 70884 != 118331)
								{
									Game.mGameTime = Time.time;
									if (254131 - 476104 != -221972)
									{
										Game.mGameScore = 0;
										if (35288 - 58886 != -23597)
										{
											Game.mGameMana = 0;
											if (92612 - 427842 == -335230)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (214737 - 456618 != -241880)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (271651 - 375980 != -104328)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (264714 - 298627 == -33913)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (198300 - 206159 == -7859)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (248013 - 454191 != -206177)
																{
																	this.qKMntIEM2nf = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (24064 - 519646 != -495581)
																	{
																		this.uwinteZhs9k = PhotonClient.Connection;
																		if (286194 - 389474 != -103279)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (122182 - 219617 == -97435)
																			{
																				this.InitGame();
																				if (24631 - 236246 == -211615)
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
				if (37864 - 42382 == -4518)
				{
					Game.mGameType = 99;
					if (106852 - 15054 != 91799)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A6F5 RID: 42741 RVA: 0x012C4240 File Offset: 0x012C2440
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (250491 - 492115 != -241623)
		{
		}
		for (;;)
		{
			if (this.uwinteZhs9k == null)
			{
				if (251671 - 14697 == 236974)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (282777 - 125818 != 156960)
				{
					if (mGameState == eGameState.Init)
					{
						if (64266 - 402146 != -337879)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (59775 - 441057 == -381282)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (74076 - 69017 == 5059)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (174328 - 65193 == 109135)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (71282 - 441437 == -370155)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (186293 - 141300 != 44994)
						{
							if (Time.time > this.cNKntJT5PRw)
							{
								if (87663 - 40406 == 47258)
								{
									continue;
								}
								Game.mGameMana++;
								if (110842 - 241779 == -130936)
								{
									continue;
								}
								this.cNKntJT5PRw = Time.time + (float)12;
								if (120006 - 352723 != -232717)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (207192 - 548075 != -340883)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (271220 - 134443 != 136777)
									{
										continue;
									}
									this.audio.Play();
									if (110496 - 112817 == -2320)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (169424 - 367599 != -198175)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (194240 - 408362 != -214122)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (35954 - 447033 != -411079)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (208927 - 522790 == -313863)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (56786 - 462938 == -406152)
						{
							this.GameEventUpdate();
							if (8110 - 372787 != -364676)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (95014 - 21123 != 73892)
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
						if (77910 - 417870 == -339960)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A6F6 RID: 42742 RVA: 0x012C45F4 File Offset: 0x012C27F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (202267 - 96564 != 105704)
		{
		}
		for (;;)
		{
			if (!this.k1bnt6xBlZV)
			{
				if (200612 - 503259 != -302646)
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
				if (107233 - 273791 != -166557)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (41755 - 275199 != -233443)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (108719 - 267232 == -158513)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (98823 - 135253 != -36429)
							{
								GUI.depth = 1;
								if (288646 - 953 != 287694)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (5240 - 330044 == -324804)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (182694 - 206262 == -23568)
										{
											Color color = GUI.color;
											if (289963 - 223041 != 66923)
											{
												float num3 = color.a = a;
												if (64662 - 441448 != -376785)
												{
													if (104377 - 8918 == 95459)
													{
														GUI.color = color;
														if (112105 - 327886 != -215780)
														{
															if (59944 - 80745 == -20801)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.k1bnt6xBlZV);
																if (70474 - 133501 == -63027)
																{
																	float a2 = 1f;
																	if (42857 - 8046 == 34811)
																	{
																		Color color2 = GUI.color;
																		if (158587 - 114771 == 43816)
																		{
																			color2.a = a2;
																			if (197119 - 415604 != -218484 && 107420 - 221761 != -114340)
																			{
																				Color color3 = GUI.color = color2;
																				if (211334 - 443928 != -232593 && 293742 - 586914 != -293171)
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

	// Token: 0x0600A6F7 RID: 42743 RVA: 0x012C4974 File Offset: 0x012C2B74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GameEventUpdate()
	{
		if (243289 - 594546 != -351256)
		{
		}
		for (;;)
		{
			int num = this.zIZntXR6wki;
			if (268363 - 564680 != -296316)
			{
				if (num == 0)
				{
					if (55968 - 482301 != -426332)
					{
						if (Time.time - Game.mGameTime <= (float)60)
						{
							break;
						}
						if (144040 - 153455 != -9414)
						{
							this.zIZntXR6wki = 1;
							if (35545 - 124568 == -89023)
							{
								Game.sendMissionEvent(9421, 1);
								if (270459 - 192125 == 78334)
								{
									break;
								}
							}
						}
					}
				}
				else if (num == 1)
				{
					if (122334 - 511531 != -389196)
					{
						if (Time.time - Game.mGameTime <= (float)80)
						{
							break;
						}
						if (136024 - 149771 != -13746)
						{
							this.zIZntXR6wki = 2;
							if (221596 - 222980 == -1384)
							{
								Game.sendMissionEvent(9421, 2);
								if (253386 - 375316 != -121929)
								{
									break;
								}
							}
						}
					}
				}
				else if (num == 2)
				{
					if (33569 - 30462 == 3107)
					{
						if (Time.time - Game.mGameTime <= (float)100)
						{
							break;
						}
						if (37352 - 95699 == -58347)
						{
							this.zIZntXR6wki = 3;
							if (34388 - 597607 == -563219)
							{
								Game.sendMissionEvent(9421, 3);
								if (42313 - 581776 != -539462)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					if (num != 3)
					{
						break;
					}
					if (66723 - 467414 == -400691)
					{
						if (Time.time - Game.mGameTime <= (float)120)
						{
							break;
						}
						if (133825 - 125712 == 8113)
						{
							this.zIZntXR6wki = 4;
							if (251937 - 116797 == 135140)
							{
								Game.sendMissionEvent(9421, 4);
								if (232313 - 569671 != -337357)
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

	// Token: 0x0600A6F8 RID: 42744 RVA: 0x012C4C30 File Offset: 0x012C2E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (130459 - 169589 != -39130)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (20719 - 541298 == -520579)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (267537 - 317850 != -50312)
				{
					int nColor = RuntimeServices.UnboxInt32(data[145]);
					if (177589 - 40315 == 137274)
					{
						int num2 = RuntimeServices.UnboxInt32(data[43]);
						if (117168 - 380011 != -262842)
						{
							int num3 = num;
							if (207874 - 28152 != 179723)
							{
								if (num3 == -9421)
								{
									if (99018 - 568494 == -469476)
									{
										if (PlayerData.UID != num2)
										{
											break;
										}
										if (11611 - 403034 == -391423)
										{
											this.SpawnCrystalBug(nColor);
											if (97670 - 72778 != 24893)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (num3 != 9422)
									{
										break;
									}
									if (86194 - 523037 != -436842)
									{
										this.ucEntOdqw5g++;
										if (57520 - 48821 == 8699)
										{
											this.SendMessage("newGameMessage", "Mission Objective: CrystalBug eliminated: " + this.ucEntOdqw5g);
											if (253323 - 162811 == 90512)
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

	// Token: 0x0600A6F9 RID: 42745 RVA: 0x012C4E38 File Offset: 0x012C3038
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SpawnCrystalBug(int nColor)
	{
		if (24146 - 564783 != -540636)
		{
		}
		for (;;)
		{
			Debug.Log("SpawnCrystalBug: " + nColor);
			if (105989 - 359376 != -253386)
			{
				GameObject gameObject = GameObject.Find("SpawnPoint" + nColor);
				if (103762 - 337264 == -233502)
				{
					if (!gameObject)
					{
						break;
					}
					if (95928 - 192698 == -96770)
					{
						if (!Game.useAdvanceMode)
						{
							if (206802 - 149928 == 56874)
							{
								if (86291 - 144038 == -57747)
								{
									if (nColor == 1)
									{
										if (216907 - 538993 == -322086)
										{
											this.createActor("CrystalBug_b", 6, gameObject.transform.position, gameObject.transform.forward);
											if (139198 - 34280 != 104919)
											{
												break;
											}
										}
									}
									else if (nColor == 2)
									{
										if (73692 - 27463 != 46230)
										{
											this.createActor("CrystalBug_y", 6, gameObject.transform.position, gameObject.transform.forward);
											if (178660 - 423845 != -245184)
											{
												break;
											}
										}
									}
									else if (nColor == 3)
									{
										if (126682 - 194279 != -67596)
										{
											this.createActor("CrystalBug_r", 6, gameObject.transform.position, gameObject.transform.forward);
											if (112298 - 527860 != -415561)
											{
												break;
											}
										}
									}
									else
									{
										if (nColor != 4)
										{
											break;
										}
										if (191999 - 217454 == -25455)
										{
											this.createActor("CrystalBug_g", 6, gameObject.transform.position, gameObject.transform.forward);
											if (135689 - 242309 != -106619)
											{
												break;
											}
										}
									}
								}
							}
						}
						else if (133700 - 184901 != -51200)
						{
							if (nColor == 1)
							{
								if (57232 - 583106 != -525873)
								{
									this.createActor("CrystalBug2_b", 6, gameObject.transform.position, gameObject.transform.forward);
									if (25742 - 341278 == -315536)
									{
										break;
									}
								}
							}
							else if (nColor == 2)
							{
								if (285322 - 212117 != 73206)
								{
									this.createActor("CrystalBug2_y", 6, gameObject.transform.position, gameObject.transform.forward);
									if (201194 - 349879 != -148684)
									{
										break;
									}
								}
							}
							else if (nColor == 3)
							{
								if (91590 - 357353 == -265763)
								{
									this.createActor("CrystalBug2_r", 6, gameObject.transform.position, gameObject.transform.forward);
									if (150070 - 333829 != -183758)
									{
										break;
									}
								}
							}
							else
							{
								if (nColor != 4)
								{
									break;
								}
								if (297213 - 17840 == 279373)
								{
									this.createActor("CrystalBug2_g", 6, gameObject.transform.position, gameObject.transform.forward);
									if (216255 - 443884 == -227629)
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

	// Token: 0x0600A6FA RID: 42746 RVA: 0x012C5268 File Offset: 0x012C3468
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M942_CrystalBug.$onGameComplete$44283(data, this).GetEnumerator();
	}

	// Token: 0x0600A6FB RID: 42747 RVA: 0x012C5278 File Offset: 0x012C3478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (230808 - 327129 != -96321)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (87163 - 93839 != -6675)
			{
				Hashtable customOpParameters = new Hashtable();
				if (239735 - 332175 != -92439)
				{
					this.uwinteZhs9k.OpCustom(52, customOpParameters, true);
					if (55747 - 287154 == -231407)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A6FC RID: 42748 RVA: 0x012C5320 File Offset: 0x012C3520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (217312 - 434227 != -216915)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (241179 - 564970 != -323790)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (31041 - 385002 != -353960)
				{
					Game.mGameState = eGameState.Setup;
					if (29787 - 551139 != -521351)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A6FD RID: 42749 RVA: 0x012C53C4 File Offset: 0x012C35C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (93286 - 176009 != -82722)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (109345 - 459410 != -350064)
			{
				if (num == PlayerData.UID)
				{
					if (273062 - 458002 != -184939)
					{
						this.SetupActors();
						if (119343 - 355934 != -236590)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (86448 - 364349 != -277900)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A6FE RID: 42750 RVA: 0x012C5494 File Offset: 0x012C3694
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (168563 - 57030 != 111534)
		{
		}
		for (;;)
		{
			IL_D4:
			Debug.Log("Creating Actors");
			if (16731 - 134157 != -117425)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (212958 - 308047 == -95089)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (161809 - 570738 != -408928)
						{
							int i = 0;
							if (227449 - 502246 != -274796)
							{
								CharacterControl[] array2 = array;
								if (165299 - 578736 != -413436)
								{
									int length = array2.Length;
									if (35589 - 525361 != -489771)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (198061 - 156709 == 41353)
											{
												goto IL_D4;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (54166 - 367510 != -313344)
											{
												goto IL_D4;
											}
											this.aWqnt2jfyeU++;
											if (257566 - 119737 == 137830)
											{
												goto IL_D4;
											}
											i++;
											if (15774 - 311016 != -295242)
											{
												goto IL_D4;
											}
										}
										if (47853 - 326689 != -278835)
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
						if (51520 - 412000 == -360480)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A6FF RID: 42751 RVA: 0x012C56AC File Offset: 0x012C38AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (188364 - 519055 != -330691)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (196638 - 528669 == -332031)
			{
				int i = 0;
				if (68515 - 596783 == -528268)
				{
					CharacterControl[] array2 = array;
					if (63217 - 419869 == -356652)
					{
						int length = array2.Length;
						if (137048 - 483981 != -346932)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (129143 - 333849 == -204705)
								{
									goto IL_E0;
								}
								i++;
								if (290902 - 20464 != 270438)
								{
									goto IL_E0;
								}
							}
							if (167368 - 342656 != -175287)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A700 RID: 42752 RVA: 0x012C57DC File Offset: 0x012C39DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (29689 - 557925 != -528235)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (13525 - 443000 != -429474)
			{
				Game.mGameState = eGameState.Ready;
				if (289925 - 396736 != -106810)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (162989 - 160764 != 2226)
					{
						if (256109 - 592808 == -336699)
						{
							GameObject gameObject = null;
							if (4285 - 318614 != -314328)
							{
								if (playerSlot <= 1)
								{
									goto IL_1EC;
								}
								if (196042 - 543578 == -347535)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_1EC;
								}
								if (12017 - 591204 != -579187)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (282844 - 570514 == -287669)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (153024 - 344975 != -191951)
								{
									continue;
								}
								IL_211:
								if (gameObject2)
								{
									if (120738 - 347611 != -226873)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (246651 - 318901 != -72250)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (296988 - 534231 != -237243)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (31159 - 352434 != -321275)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (92341 - 534083 != -441742)
								{
									continue;
								}
								break;
								IL_1EC:
								gameObject2 = GameObject.Find("StartPoint1");
								if (152116 - 384959 != -232842)
								{
									goto IL_211;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A701 RID: 42753 RVA: 0x012C5A70 File Offset: 0x012C3C70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M942_CrystalBug.$StartGame$44292(this).GetEnumerator();
	}

	// Token: 0x0600A702 RID: 42754 RVA: 0x012C5A80 File Offset: 0x012C3C80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A703 RID: 42755 RVA: 0x012C5A84 File Offset: 0x012C3C84
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (181872 - 405402 != -223530)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (145749 - 267317 == -121568)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (155885 - 12440 != 143446)
				{
					hashtable.Add(43, PlayerData.UID);
					if (235066 - 227425 != 7642)
					{
						hashtable.Add(73, nType);
						if (171791 - 554630 != -382838)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (151845 - 489158 == -337313)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (131708 - 245466 != -113757)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (125643 - 136077 != -10433)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (53462 - 598235 == -544773)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (203497 - 285426 == -81929)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (21856 - 319998 != -298141)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (213156 - 343700 == -130544)
													{
														this.uwinteZhs9k.OpCustom(63, hashtable, true);
														if (119093 - 574776 != -455682)
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

	// Token: 0x0600A704 RID: 42756 RVA: 0x012C5D68 File Offset: 0x012C3F68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreateActor(Hashtable data)
	{
		return new M942_CrystalBug.$onCreateActor$44296(data, this).GetEnumerator();
	}

	// Token: 0x0600A705 RID: 42757 RVA: 0x012C5D78 File Offset: 0x012C3F78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A706 RID: 42758 RVA: 0x012C5D8C File Offset: 0x012C3F8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (162508 - 22196 != 140312)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (27986 - 598721 == -570735)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (230716 - 523359 != -292642)
				{
					if (!characterControl)
					{
						break;
					}
					if (161842 - 169138 == -7296)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (291128 - 401986 == -110858)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (29651 - 333369 == -303718)
							{
								string type = characterControl.Type;
								if (9255 - 272272 != -263016)
								{
									if (type == "CrystalBug_r")
									{
										if (298331 - 503834 == -205502)
										{
											continue;
										}
									}
									else if (type == "CrystalBug_g")
									{
										if (172789 - 577590 != -404801)
										{
											continue;
										}
									}
									else if (type == "CrystalBug_b")
									{
										if (69094 - 142185 != -73091)
										{
											continue;
										}
									}
									else if (type == "CrystalBug_y")
									{
										if (218109 - 109306 == 108804)
										{
											continue;
										}
									}
									else if (type == "CrystalBug2_r")
									{
										if (294524 - 426646 == -132121)
										{
											continue;
										}
									}
									else if (type == "CrystalBug2_g")
									{
										if (201510 - 485103 != -283593)
										{
											continue;
										}
									}
									else if (type == "CrystalBug2_b")
									{
										if (31438 - 47599 == -16160)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "CrystalBug2_y"))
										{
											break;
										}
										if (217966 - 148433 == 69534)
										{
											continue;
										}
									}
									IL_183:
									Game.sendMissionEvent(9422, 0);
									if (98279 - 37746 != 60534)
									{
										break;
									}
									continue;
									IL_D6:
									goto IL_183;
									IL_12A:
									goto IL_D6;
									IL_1A:
									goto IL_12A;
									IL_26D:
									goto IL_1A;
									IL_78:
									goto IL_26D;
									goto IL_78;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A707 RID: 42759 RVA: 0x012C604C File Offset: 0x012C424C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (2891 - 18099 != -15207)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (76489 - 596606 == -520117)
			{
				hashtable.Add(71, CID);
				if (73921 - 197191 != -123269)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (283477 - 255436 == 28041)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (49248 - 561472 != -512223)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (63602 - 95597 != -31994)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (191172 - 384958 == -193786)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (58111 - 301289 == -243178)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (48968 - 406967 == -357999)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (230061 - 391219 != -161157)
											{
												this.uwinteZhs9k.OpCustom(61, hashtable, true);
												if (280055 - 393138 != -113082)
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

	// Token: 0x0600A708 RID: 42760 RVA: 0x012C62D8 File Offset: 0x012C44D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (291666 - 363343 != -71676)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (271491 - 10413 != 261079)
			{
				if (!gameObject)
				{
					break;
				}
				if (241403 - 175452 == 65951)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (289093 - 452162 == -163069)
					{
						playerCameraControl.target = gameObject;
						if (221703 - 450412 != -228708)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (44388 - 541715 != -497326)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A709 RID: 42761 RVA: 0x012C63D0 File Offset: 0x012C45D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (190865 - 106966 != 83900)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (195313 - 592453 != -397139)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (283466 - 4333 == 279133)
				{
					gameGui.ResetTeamBar();
					if (107286 - 324328 == -217042)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A70A RID: 42762 RVA: 0x012C647C File Offset: 0x012C467C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M942_CrystalBug.$onDeadPlayer$44307(this).GetEnumerator();
	}

	// Token: 0x0600A70B RID: 42763 RVA: 0x012C648C File Offset: 0x012C468C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (22059 - 413330 != -391271)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (277945 - 239544 != 38402)
			{
				this.qKMntIEM2nf.target = Game.mPlayer;
				if (10176 - 348243 != -338066)
				{
					this.qKMntIEM2nf.enabled = true;
					if (46907 - 210924 != -164016)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (36069 - 33519 == 2551)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (269502 - 452760 != -183258)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (45345 - 30951 == 14394)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (113695 - 473009 == -359314)
							{
								if (!gameGui)
								{
									break;
								}
								if (37629 - 245557 != -207927)
								{
									gameGui.enabled = true;
									if (145305 - 435552 != -290246)
									{
										gameGui.closeDeadMenu();
										if (192700 - 101350 == 91350)
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

	// Token: 0x0600A70C RID: 42764 RVA: 0x012C6638 File Offset: 0x012C4838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
		this.StartCoroutine_Auto(this.ReturnToTown());
	}

	// Token: 0x0600A70D RID: 42765 RVA: 0x012C6654 File Offset: 0x012C4854
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A70E RID: 42766 RVA: 0x012C6680 File Offset: 0x012C4880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M942_CrystalBug.$ReturnToTown$44313(this).GetEnumerator();
	}

	// Token: 0x0600A70F RID: 42767 RVA: 0x012C6690 File Offset: 0x012C4890
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M942_CrystalBug.$ReturnToGuild$44318(this).GetEnumerator();
	}

	// Token: 0x0600A710 RID: 42768 RVA: 0x012C66A0 File Offset: 0x012C48A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M942_CrystalBug.$ReturnToCamp$44322(this).GetEnumerator();
	}

	// Token: 0x0600A711 RID: 42769 RVA: 0x012C66B0 File Offset: 0x012C48B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (226202 - 236815 != -10613)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (215877 - 181278 != 34600)
			{
				Hashtable hashtable = new Hashtable();
				if (111041 - 221800 != -110758)
				{
					hashtable.Add(43, PlayerData.UID);
					if (197939 - 592249 == -394310)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (210081 - 222547 == -12466)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A712 RID: 42770 RVA: 0x012C6788 File Offset: 0x012C4988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A713 RID: 42771 RVA: 0x012C679C File Offset: 0x012C499C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (134860 - 76874 != 57986)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (62695 - 528853 == -466158)
			{
				Hashtable hashtable = new Hashtable();
				if (191216 - 244373 == -53157)
				{
					if (Game.mNextGameCode == 30)
					{
						if (139886 - 326017 != -186131)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (134645 - 563957 != -429312)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (233889 - 363724 != -129835)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (158743 - 560976 != -402233)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (93845 - 283267 != -189422)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (40722 - 498353 == -457630)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (133126 - 192280 == -59153)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (252921 - 244678 != 8243)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (59677 - 296561 == -236883)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (280022 - 438108 == -158085)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (44398 - 197272 != -152874)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (172797 - 409055 != -236258)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (56408 - 1047 != 55361)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (83249 - 231683 != -148434)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (152178 - 352274 != -200096)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (299751 - 375801 == -76049)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (291273 - 170574 == 120700)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (216687 - 105692 == 110996)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (282309 - 22521 == 259789)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (14613 - 467745 != -453132)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (149356 - 416620 == -267263)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (170123 - 273790 != -103667)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (136948 - 312237 != -175289)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (42790 - 426621 == -383830)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (136105 - 181705 != -45600)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (278383 - 441124 != -162741)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (121691 - 541510 != -419819)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (171799 - 175624 != -3825)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (253684 - 363867 == -110183)
					{
						this.uwinteZhs9k.OpCustom(42, hashtable, true);
						if (238922 - 452167 == -213245)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A714 RID: 42772 RVA: 0x012C6D50 File Offset: 0x012C4F50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A715 RID: 42773 RVA: 0x012C6D60 File Offset: 0x012C4F60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A716 RID: 42774 RVA: 0x012C6D64 File Offset: 0x012C4F64
	internal static bool QSAmEyVwqeeYDXXkokbA()
	{
		return true;
	}

	// Token: 0x0600A717 RID: 42775 RVA: 0x012C6D68 File Offset: 0x012C4F68
	internal static bool cMelWoVw7Ajxwsjq9cwX()
	{
		return false;
	}

	// Token: 0x0400952A RID: 38186
	private LitePeer uwinteZhs9k;

	// Token: 0x0400952B RID: 38187
	private PlayerCameraControl qKMntIEM2nf;

	// Token: 0x0400952C RID: 38188
	private float cNKntJT5PRw;

	// Token: 0x0400952D RID: 38189
	private Texture k1bnt6xBlZV;

	// Token: 0x0400952E RID: 38190
	private AudioClip olSnttg5CcV;

	// Token: 0x0400952F RID: 38191
	private int zIZntXR6wki;

	// Token: 0x04009530 RID: 38192
	private int ucEntOdqw5g;

	// Token: 0x04009531 RID: 38193
	private int aWqnt2jfyeU;

	// Token: 0x04009532 RID: 38194
	public AudioClip ShatterSound;

	// Token: 0x02001BF2 RID: 7154
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44283 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A718 RID: 42776 RVA: 0x012C6D6C File Offset: 0x012C4F6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44283(Hashtable data, M942_CrystalBug self_)
		{
			if (31747 - 484219 != -452471)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (26570 - 423955 == -397385)
				{
					base..ctor();
					if (18329 - 291443 == -273114)
					{
						this.$data$44290 = data;
						if (257144 - 572779 == -315635)
						{
							this.$self_$44291 = self_;
							if (1273 - 400565 != -399291)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A719 RID: 42777 RVA: 0x012C6E28 File Offset: 0x012C5028
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M942_CrystalBug.$onGameComplete$44283.$(this.$data$44290, this.$self_$44291);
		}

		// Token: 0x0600A71A RID: 42778 RVA: 0x012C6E3C File Offset: 0x012C503C
		internal static bool H9qdrVVwPkSrLxfftJHS()
		{
			return true;
		}

		// Token: 0x0600A71B RID: 42779 RVA: 0x012C6E40 File Offset: 0x012C5040
		internal static bool avUhWSVw0RQahip5wxmh()
		{
			return false;
		}

		// Token: 0x04009533 RID: 38195
		internal Hashtable $data$44290;

		// Token: 0x04009534 RID: 38196
		internal M942_CrystalBug $self_$44291;

		// Token: 0x02001BF3 RID: 7155
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A71C RID: 42780 RVA: 0x012C6E44 File Offset: 0x012C5044
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M942_CrystalBug self_)
			{
				if (254168 - 157075 != 97094)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246620 - 101939 == 144681)
					{
						base..ctor();
						if (33662 - 205672 != -172009)
						{
							this.$data$44288 = data;
							if (226478 - 39269 == 187209)
							{
								this.$self_$44289 = self_;
								if (153017 - 198265 != -45247)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A71D RID: 42781 RVA: 0x012C6F00 File Offset: 0x012C5100
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (248153 - 384061 != -135908)
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
						this.$mCompleteGui$44285 = (CompleteGui)this.$self_$44289.GetComponent(typeof(CompleteGui));
						if (19308 - 530467 != -511159)
						{
							continue;
						}
						this.$mCompleteGui$44285.Init();
						if (15672 - 492871 == -477198)
						{
							continue;
						}
						this.$mCompleteGui$44285.readData(this.$data$44288);
						if (141878 - 321950 != -180072)
						{
							continue;
						}
						if (this.$result$44284 == 1)
						{
							if (146509 - 324531 == -178021)
							{
								continue;
							}
							this.$mCompleteGui$44285.displayResult(eCompleteType.Success);
							if (62214 - 237533 != -175319)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44285.displayResult(eCompleteType.Failed);
							if (225760 - 155679 == 70082)
							{
								continue;
							}
						}
						this.$mGameGui$44286 = (GameGui)this.$self_$44289.GetComponent(typeof(GameGui));
						if (159898 - 283117 != -123219)
						{
							continue;
						}
						this.$mStoryGui$44287 = (StoryGui)this.$self_$44289.GetComponent(typeof(StoryGui));
						if (75321 - 214014 == -138692)
						{
							continue;
						}
						if (this.$mGameGui$44286)
						{
							if (174326 - 536492 == -362165)
							{
								continue;
							}
							this.$mGameGui$44286.close();
							if (105240 - 516006 == -410765)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44287)
						{
							if (72366 - 47996 == 24371)
							{
								continue;
							}
							this.$mStoryGui$44287.close();
							if (68807 - 8623 != 60184)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (240950 - 183695 != 57255)
						{
							continue;
						}
						goto IL_352;
					default:
						if (106619 - 314712 != -208093)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44288[31]);
					if (256153 - 213972 == 42181)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (128177 - 63415 == 64762)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (179753 - 566732 != -386978)
							{
								this.$result$44284 = RuntimeServices.UnboxInt32(this.$data$44288[31]);
								if (258571 - 214364 == 44207)
								{
									goto IL_302;
								}
							}
						}
					}
				}
				goto IL_352;
				IL_302:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x0600A71E RID: 42782 RVA: 0x012C7274 File Offset: 0x012C5474
			internal static bool qDbqMIVwbbBT9LwlMvwV()
			{
				return true;
			}

			// Token: 0x0600A71F RID: 42783 RVA: 0x012C7278 File Offset: 0x012C5478
			internal static bool PjZluxVwuvTDoe83H0vW()
			{
				return false;
			}

			// Token: 0x04009535 RID: 38197
			internal int $result$44284;

			// Token: 0x04009536 RID: 38198
			internal CompleteGui $mCompleteGui$44285;

			// Token: 0x04009537 RID: 38199
			internal GameGui $mGameGui$44286;

			// Token: 0x04009538 RID: 38200
			internal StoryGui $mStoryGui$44287;

			// Token: 0x04009539 RID: 38201
			internal Hashtable $data$44288;

			// Token: 0x0400953A RID: 38202
			internal M942_CrystalBug $self_$44289;
		}
	}

	// Token: 0x02001BF4 RID: 7156
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$44292 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A720 RID: 42784 RVA: 0x012C727C File Offset: 0x012C547C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$44292(M942_CrystalBug self_)
		{
			if (236255 - 74881 != 161374)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (79680 - 216288 == -136608)
				{
					base..ctor();
					if (30637 - 402711 == -372074)
					{
						this.$self_$44295 = self_;
						if (285656 - 486191 == -200535)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A721 RID: 42785 RVA: 0x012C7314 File Offset: 0x012C5514
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M942_CrystalBug.$StartGame$44292.$(this.$self_$44295);
		}

		// Token: 0x0600A722 RID: 42786 RVA: 0x012C7324 File Offset: 0x012C5524
		internal static bool NgWOUCVwIqycJs850Cqc()
		{
			return true;
		}

		// Token: 0x0600A723 RID: 42787 RVA: 0x012C7328 File Offset: 0x012C5528
		internal static bool tYQKFdVwBg17pT0K8bWc()
		{
			return false;
		}

		// Token: 0x0400953B RID: 38203
		internal M942_CrystalBug $self_$44295;

		// Token: 0x02001BF5 RID: 7157
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A724 RID: 42788 RVA: 0x012C732C File Offset: 0x012C552C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M942_CrystalBug self_)
			{
				if (128848 - 408379 != -279531)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (16758 - 585101 == -568343)
					{
						base..ctor();
						if (21135 - 287653 == -266518)
						{
							this.$self_$44294 = self_;
							if (25742 - 183813 == -158071)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A725 RID: 42789 RVA: 0x012C73C4 File Offset: 0x012C55C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (190566 - 373622 != -183055)
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
						this.$mGameGui$44293 = (GameGui)this.$self_$44294.GetComponent(typeof(GameGui));
						if (131493 - 382695 == -251201)
						{
							continue;
						}
						this.$mGameGui$44293.enabled = true;
						if (179999 - 152001 == 27999)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (206311 - 536587 != -330276)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (46597 - 594383 == -547785)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (241445 - 567940 != -326495)
						{
							continue;
						}
						if (this.$self_$44294.olSnttg5CcV)
						{
							if (136606 - 597350 != -460744)
							{
								continue;
							}
							this.$self_$44294.audio.PlayOneShot(this.$self_$44294.olSnttg5CcV);
							if (208573 - 198334 != 10239)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (130280 - 9076 != 121205)
						{
							goto Block_2;
						}
						continue;
					default:
						if (83093 - 26991 != 56102)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (113339 - 240523 == -127184)
					{
						Game.mGameState = eGameState.Start;
						if (224280 - 234879 != -10598)
						{
							Game.mStateTime = Time.time;
							if (169355 - 133700 == 35655)
							{
								this.$self_$44294.SendMessage("fadeIn");
								if (235709 - 290221 == -54512)
								{
									goto IL_1AD;
								}
							}
						}
					}
				}
				Block_2:
				goto IL_241;
				IL_1AD:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_241:
				return false;
			}

			// Token: 0x0600A726 RID: 42790 RVA: 0x012C7624 File Offset: 0x012C5824
			internal static bool pdJ9bbVweJ0MGOqWcSyi()
			{
				return true;
			}

			// Token: 0x0600A727 RID: 42791 RVA: 0x012C7628 File Offset: 0x012C5828
			internal static bool x6qT4BVwr29K8bIEpq6e()
			{
				return false;
			}

			// Token: 0x0400953C RID: 38204
			internal GameGui $mGameGui$44293;

			// Token: 0x0400953D RID: 38205
			internal M942_CrystalBug $self_$44294;
		}
	}

	// Token: 0x02001BF6 RID: 7158
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreateActor$44296 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A728 RID: 42792 RVA: 0x012C762C File Offset: 0x012C582C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreateActor$44296(Hashtable data, M942_CrystalBug self_)
		{
			if (82907 - 234276 != -151368)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (23690 - 396375 != -372684)
				{
					base..ctor();
					if (268727 - 177108 != 91620)
					{
						this.$data$44305 = data;
						if (124225 - 30296 != 93930)
						{
							this.$self_$44306 = self_;
							if (119250 - 12021 == 107229)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A729 RID: 42793 RVA: 0x012C76E8 File Offset: 0x012C58E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M942_CrystalBug.$onCreateActor$44296.$(this.$data$44305, this.$self_$44306);
		}

		// Token: 0x0600A72A RID: 42794 RVA: 0x012C76FC File Offset: 0x012C58FC
		internal static bool zTUqTAVwjct2llbmTpAM()
		{
			return true;
		}

		// Token: 0x0600A72B RID: 42795 RVA: 0x012C7700 File Offset: 0x012C5900
		internal static bool hE1waEVwhQsPrfCR4YP5()
		{
			return false;
		}

		// Token: 0x0400953E RID: 38206
		internal Hashtable $data$44305;

		// Token: 0x0400953F RID: 38207
		internal M942_CrystalBug $self_$44306;

		// Token: 0x02001BF7 RID: 7159
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A72C RID: 42796 RVA: 0x012C7704 File Offset: 0x012C5904
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M942_CrystalBug self_)
			{
				if (82813 - 486925 != -404112)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (42285 - 125926 != -83640)
					{
						base..ctor();
						if (56813 - 447658 == -390845)
						{
							this.$data$44303 = data;
							if (203725 - 163335 != 40391)
							{
								this.$self_$44304 = self_;
								if (129773 - 14383 == 115390)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A72D RID: 42797 RVA: 0x012C77C0 File Offset: 0x012C59C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56745 - 259472 != -202726)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_725;
					case 2:
						if (this.$mCrystal$44298)
						{
							if (125688 - 21173 != 104515)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$mCrystal$44298);
							if (5214 - 245313 == -240098)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (45185 - 436321 != -391135)
						{
							goto Block_4;
						}
						continue;
					default:
						if (285200 - 382419 == -97218)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (268270 - 558168 != -289897)
						{
							break;
						}
					}
					else
					{
						object obj2;
						object obj = obj2 = this.$data$44303[73];
						if (!(obj is string))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(string));
						}
						this.$mType$44297 = (string)obj2;
						if (22342 - 346827 != -324484)
						{
							this.$mCrystal$44298 = null;
							if (157909 - 42850 != 115060)
							{
								this.$$switch$8153$44299 = this.$mType$44297;
								if (218809 - 456024 != -237214)
								{
									if (this.$$switch$8153$44299 == "CrystalBug_r")
									{
										if (180276 - 373287 != -193011)
										{
											continue;
										}
									}
									else if (this.$$switch$8153$44299 == "CrystalBug2_r")
									{
										if (10843 - 146676 != -135833)
										{
											continue;
										}
									}
									else
									{
										if (this.$$switch$8153$44299 == "CrystalBug_g")
										{
											if (98498 - 561869 == -463370)
											{
												continue;
											}
										}
										else if (this.$$switch$8153$44299 == "CrystalBug2_g")
										{
											if (265175 - 518973 != -253798)
											{
												continue;
											}
										}
										else
										{
											if (this.$$switch$8153$44299 == "CrystalBug_b")
											{
												if (245943 - 556486 == -310542)
												{
													continue;
												}
											}
											else if (this.$$switch$8153$44299 == "CrystalBug2_b")
											{
												if (209235 - 362165 == -152929)
												{
													continue;
												}
											}
											else
											{
												if (this.$$switch$8153$44299 == "CrystalBug_y")
												{
													if (1436 - 260398 != -258962)
													{
														continue;
													}
												}
												else
												{
													if (!(this.$$switch$8153$44299 == "CrystalBug2_y"))
													{
														goto IL_492;
													}
													if (29271 - 505156 == -475884)
													{
														continue;
													}
												}
												this.$mCrystal$44298 = GameObject.Find("Crystal_y");
												if (165054 - 154506 != 10549)
												{
													goto IL_492;
												}
												continue;
											}
											this.$mCrystal$44298 = GameObject.Find("Crystal_b");
											if (273856 - 135777 != 138080)
											{
												goto IL_492;
											}
											continue;
										}
										this.$mCrystal$44298 = GameObject.Find("Crystal_g");
										if (47912 - 319926 != -272014)
										{
											continue;
										}
										goto IL_492;
									}
									this.$mCrystal$44298 = GameObject.Find("Crystal_r");
									if (261385 - 487988 != -226603)
									{
										continue;
									}
									IL_492:
									if (this.$mCrystal$44298)
									{
										if (58912 - 288304 != -229392)
										{
											continue;
										}
										this.$mAlphaTimerScript$44300 = (AlphaTimer)this.$mCrystal$44298.GetComponent(typeof(AlphaTimer));
										if (203708 - 418942 == -215233)
										{
											continue;
										}
										this.$mShatterScript$44301 = (ShatterMesh)this.$mCrystal$44298.GetComponent(typeof(ShatterMesh));
										if (42967 - 109230 != -66263)
										{
											continue;
										}
										if (this.$mAlphaTimerScript$44300)
										{
											if (89462 - 139383 == -49920)
											{
												continue;
											}
											if (!this.$mAlphaTimerScript$44300.enabled)
											{
												if (51081 - 519240 != -468159)
												{
													continue;
												}
												this.$mAlphaTimerScript$44300.enabled = true;
												if (19795 - 309233 == -289437)
												{
													continue;
												}
											}
										}
										if (this.$mShatterScript$44301)
										{
											if (134278 - 151989 == -17710)
											{
												continue;
											}
											if (!this.$mShatterScript$44301.enabled)
											{
												if (65070 - 545212 == -480141)
												{
													continue;
												}
												this.$mShatterScript$44301.enabled = true;
												if (96754 - 196630 == -99875)
												{
													continue;
												}
											}
										}
										if (this.$self_$44304.ShatterSound)
										{
											if (144749 - 402286 == -257536)
											{
												continue;
											}
											this.$self_$44304.audio.PlayOneShot(this.$self_$44304.ShatterSound, 2f);
											if (218978 - 546999 != -328021)
											{
												continue;
											}
										}
									}
									this.$nActor$44302 = Game.createActor(this.$data$44303);
									if (121150 - 134485 != -13334)
									{
										if (Game.mGameState == eGameState.Setup)
										{
											if (43853 - 182317 == -138464)
											{
												if (this.$self_$44304.aWqnt2jfyeU <= 0)
												{
													goto IL_56B;
												}
												if (213159 - 485849 != -272689)
												{
													this.$self_$44304.aWqnt2jfyeU = this.$self_$44304.aWqnt2jfyeU - 1;
													if (192721 - 138319 == 54402)
													{
														if (this.$self_$44304.aWqnt2jfyeU != 0)
														{
															goto IL_56B;
														}
														if (30576 - 61787 == -31211)
														{
															Game.setGameState(eGameState.Ready);
															if (93432 - 560013 != -466580)
															{
																goto Block_55;
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
												goto IL_1F5;
											}
											if (21959 - 323037 != -301077)
											{
												this.$nActor$44302.SendMessage("createSpecialEffect", 1);
												if (14712 - 577360 == -562648)
												{
													goto IL_1F5;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_725;
				IL_1F5:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_56B:
				goto IL_1F5;
				Block_55:
				goto IL_56B;
				IL_725:
				return false;
			}

			// Token: 0x0600A72E RID: 42798 RVA: 0x012C7F04 File Offset: 0x012C6104
			internal static bool fffwBxVwssjqjDsFQnJX()
			{
				return true;
			}

			// Token: 0x0600A72F RID: 42799 RVA: 0x012C7F08 File Offset: 0x012C6108
			internal static bool MuURNnVw9av19YVxnf0i()
			{
				return false;
			}

			// Token: 0x04009540 RID: 38208
			internal string $mType$44297;

			// Token: 0x04009541 RID: 38209
			internal GameObject $mCrystal$44298;

			// Token: 0x04009542 RID: 38210
			internal string $$switch$8153$44299;

			// Token: 0x04009543 RID: 38211
			internal AlphaTimer $mAlphaTimerScript$44300;

			// Token: 0x04009544 RID: 38212
			internal ShatterMesh $mShatterScript$44301;

			// Token: 0x04009545 RID: 38213
			internal GameObject $nActor$44302;

			// Token: 0x04009546 RID: 38214
			internal Hashtable $data$44303;

			// Token: 0x04009547 RID: 38215
			internal M942_CrystalBug $self_$44304;
		}
	}

	// Token: 0x02001BF8 RID: 7160
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44307 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A730 RID: 42800 RVA: 0x012C7F0C File Offset: 0x012C610C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44307(M942_CrystalBug self_)
		{
			if (129227 - 565566 != -436339)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (7630 - 212428 == -204798)
				{
					base..ctor();
					if (123750 - 284860 == -161110)
					{
						this.$self_$44312 = self_;
						if (201748 - 19055 != 182694)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A731 RID: 42801 RVA: 0x012C7FA4 File Offset: 0x012C61A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M942_CrystalBug.$onDeadPlayer$44307.$(this.$self_$44312);
		}

		// Token: 0x0600A732 RID: 42802 RVA: 0x012C7FB4 File Offset: 0x012C61B4
		internal static bool aWK4bsVw1pM3qiFA75SM()
		{
			return true;
		}

		// Token: 0x0600A733 RID: 42803 RVA: 0x012C7FB8 File Offset: 0x012C61B8
		internal static bool cYhnBGVw4SuwCvFegkOB()
		{
			return false;
		}

		// Token: 0x04009548 RID: 38216
		internal M942_CrystalBug $self_$44312;

		// Token: 0x02001BF9 RID: 7161
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A734 RID: 42804 RVA: 0x012C7FBC File Offset: 0x012C61BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M942_CrystalBug self_)
			{
				if (23690 - 75723 != -52033)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (220800 - 41350 != 179451)
					{
						base..ctor();
						if (117011 - 326800 != -209788)
						{
							this.$self_$44311 = self_;
							if (186841 - 116436 == 70405)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A735 RID: 42805 RVA: 0x012C8054 File Offset: 0x012C6254
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (192516 - 343264 != -150747)
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
							if (187489 - 226084 != -38595)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_110;
							}
							if (56027 - 215642 == -159614)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (27116 - 156466 != -129350)
						{
							continue;
						}
						this.$mStoryGui$44308 = (StoryGui)this.$self_$44311.GetComponent(typeof(StoryGui));
						if (17539 - 17811 == -271)
						{
							continue;
						}
						if (this.$mStoryGui$44308)
						{
							if (129259 - 518749 == -389489)
							{
								continue;
							}
							this.$mStoryGui$44308.close();
							if (104969 - 224627 == -119657)
							{
								continue;
							}
						}
						this.$mChangeGui$44309 = (ChangeGui)this.$self_$44311.GetComponent(typeof(ChangeGui));
						if (127506 - 381925 == -254418)
						{
							continue;
						}
						if (this.$mChangeGui$44309)
						{
							if (244753 - 478969 == -234215)
							{
								continue;
							}
							this.$mChangeGui$44309.close();
							if (155282 - 329766 != -174484)
							{
								continue;
							}
						}
						this.$mGameGui$44310 = (GameGui)this.$self_$44311.GetComponent(typeof(GameGui));
						if (288898 - 229958 != 58940)
						{
							continue;
						}
						if (this.$mGameGui$44310)
						{
							if (104588 - 360434 == -255845)
							{
								continue;
							}
							if (!this.$mGameGui$44310.enabled)
							{
								if (190053 - 15328 == 174726)
								{
									continue;
								}
								this.$mGameGui$44310.enabled = true;
								if (179838 - 204668 != -24830)
								{
									continue;
								}
							}
							this.$mGameGui$44310.openDeadMenu();
							if (83881 - 253246 == -169364)
							{
								continue;
							}
						}
						IL_110:
						this.YieldDefault(1);
						if (298783 - 56386 != 242397)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (32791 - 301052 != -268261)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (62811 - 574129 != -511318);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600A736 RID: 42806 RVA: 0x012C836C File Offset: 0x012C656C
			internal static bool f0p5dEVwzwiZcLaWye5g()
			{
				return true;
			}

			// Token: 0x0600A737 RID: 42807 RVA: 0x012C8370 File Offset: 0x012C6570
			internal static bool NuFx0WVqabwXkFB24us7()
			{
				return false;
			}

			// Token: 0x04009549 RID: 38217
			internal StoryGui $mStoryGui$44308;

			// Token: 0x0400954A RID: 38218
			internal ChangeGui $mChangeGui$44309;

			// Token: 0x0400954B RID: 38219
			internal GameGui $mGameGui$44310;

			// Token: 0x0400954C RID: 38220
			internal M942_CrystalBug $self_$44311;
		}
	}

	// Token: 0x02001BFA RID: 7162
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44313 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A738 RID: 42808 RVA: 0x012C8374 File Offset: 0x012C6574
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44313(M942_CrystalBug self_)
		{
			if (142142 - 290731 != -148589)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (297993 - 516771 == -218778)
				{
					base..ctor();
					if (45531 - 351286 == -305755)
					{
						this.$self_$44317 = self_;
						if (52438 - 510936 == -458498)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A739 RID: 42809 RVA: 0x012C840C File Offset: 0x012C660C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M942_CrystalBug.$ReturnToTown$44313.$(this.$self_$44317);
		}

		// Token: 0x0600A73A RID: 42810 RVA: 0x012C841C File Offset: 0x012C661C
		internal static bool p3wI70Vq5Usb2yhQYxX8()
		{
			return true;
		}

		// Token: 0x0600A73B RID: 42811 RVA: 0x012C8420 File Offset: 0x012C6620
		internal static bool XBZKn6VqpJ5uQEORTE3N()
		{
			return false;
		}

		// Token: 0x0400954D RID: 38221
		internal M942_CrystalBug $self_$44317;

		// Token: 0x02001BFB RID: 7163
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A73C RID: 42812 RVA: 0x012C8424 File Offset: 0x012C6624
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M942_CrystalBug self_)
			{
				if (19492 - 15963 != 3529)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14251 - 29171 != -14919)
					{
						base..ctor();
						if (71045 - 290130 != -219084)
						{
							this.$self_$44316 = self_;
							if (117575 - 206375 == -88800)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A73D RID: 42813 RVA: 0x012C84BC File Offset: 0x012C66BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (169155 - 366167 != -197012)
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
						this.$self_$44316.LeaveGame();
						if (138154 - 111939 != 26215)
						{
							continue;
						}
						this.YieldDefault(1);
						if (249797 - 305856 != -56058)
						{
							goto Block_17;
						}
						continue;
					default:
						if (255529 - 323415 == -67885)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (17960 - 445758 == -427798)
					{
						Game.mStateTime = Time.time;
						if (83995 - 500203 == -416208)
						{
							this.$$switch$8168$44314 = PlayerData.SaveGuild;
							if (111328 - 265976 == -154648)
							{
								if (this.$$switch$8168$44314 == 1)
								{
									if (111626 - 1584 != 110042)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (53878 - 286366 != -232488)
									{
										continue;
									}
								}
								else if (this.$$switch$8168$44314 == 2)
								{
									if (293185 - 60677 == 232509)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (262446 - 222449 == 39998)
									{
										continue;
									}
								}
								else if (this.$$switch$8168$44314 == 3)
								{
									if (216461 - 462889 == -246427)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (297577 - 570695 != -273118)
									{
										continue;
									}
								}
								else if (this.$$switch$8168$44314 == 4)
								{
									if (7592 - 331898 != -324306)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (136873 - 393064 != -256191)
									{
										continue;
									}
								}
								else if (this.$$switch$8168$44314 == 5)
								{
									if (122541 - 299164 != -176623)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (78515 - 392829 == -314313)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (249195 - 247138 != 2057)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (283743 - 26715 == 257029)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (137071 - 302672 != -165601)
									{
										continue;
									}
								}
								this.$mGameGui$44315 = (GameGui)this.$self_$44316.GetComponent(typeof(GameGui));
								if (80372 - 335050 == -254678)
								{
									if (this.$mGameGui$44315)
									{
										if (232953 - 112011 == 120943)
										{
											continue;
										}
										this.$mGameGui$44315.close();
										if (22938 - 373658 == -350719)
										{
											continue;
										}
									}
									this.$self_$44316.SendMessage("fadeOut");
									if (178529 - 66592 == 111937)
									{
										goto IL_277;
									}
								}
							}
						}
					}
				}
				Block_17:
				goto IL_3AD;
				IL_277:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600A73E RID: 42814 RVA: 0x012C8888 File Offset: 0x012C6A88
			internal static bool Bc77OrVqVJy5MMC6f0ct()
			{
				return true;
			}

			// Token: 0x0600A73F RID: 42815 RVA: 0x012C888C File Offset: 0x012C6A8C
			internal static bool MpUs2fVqt1ZQRi1vGI8F()
			{
				return false;
			}

			// Token: 0x0400954E RID: 38222
			internal int $$switch$8168$44314;

			// Token: 0x0400954F RID: 38223
			internal GameGui $mGameGui$44315;

			// Token: 0x04009550 RID: 38224
			internal M942_CrystalBug $self_$44316;
		}
	}

	// Token: 0x02001BFC RID: 7164
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44318 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A740 RID: 42816 RVA: 0x012C8890 File Offset: 0x012C6A90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44318(M942_CrystalBug self_)
		{
			if (282318 - 404038 != -121720)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (71872 - 315412 == -243540)
				{
					base..ctor();
					if (208849 - 99340 != 109510)
					{
						this.$self_$44321 = self_;
						if (77419 - 183293 != -105873)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A741 RID: 42817 RVA: 0x012C8928 File Offset: 0x012C6B28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M942_CrystalBug.$ReturnToGuild$44318.$(this.$self_$44321);
		}

		// Token: 0x0600A742 RID: 42818 RVA: 0x012C8938 File Offset: 0x012C6B38
		internal static bool XVZArfVqN7G6HelXcoZG()
		{
			return true;
		}

		// Token: 0x0600A743 RID: 42819 RVA: 0x012C893C File Offset: 0x012C6B3C
		internal static bool acXJqwVqYUZNdKTbi0oo()
		{
			return false;
		}

		// Token: 0x04009551 RID: 38225
		internal M942_CrystalBug $self_$44321;

		// Token: 0x02001BFD RID: 7165
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A744 RID: 42820 RVA: 0x012C8940 File Offset: 0x012C6B40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M942_CrystalBug self_)
			{
				if (268864 - 993 != 267871)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (31089 - 329800 == -298711)
					{
						base..ctor();
						if (291431 - 523170 == -231739)
						{
							this.$self_$44320 = self_;
							if (267767 - 367776 == -100009)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A745 RID: 42821 RVA: 0x012C89D8 File Offset: 0x012C6BD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (157315 - 259703 != -102387)
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
						this.$self_$44320.LeaveGame();
						if (110544 - 443960 == -333415)
						{
							continue;
						}
						this.YieldDefault(1);
						if (141115 - 300643 != -159528)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (143558 - 28405 != 115153)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (247557 - 411338 != -163780)
					{
						Game.mStateTime = Time.time;
						if (173544 - 435340 != -261795)
						{
							Game.mNextGameCode = 31;
							if (39583 - 34814 != 4770)
							{
								this.$mGameGui$44319 = (GameGui)this.$self_$44320.GetComponent(typeof(GameGui));
								if (16802 - 54285 != -37482)
								{
									if (this.$mGameGui$44319)
									{
										if (159249 - 140645 != 18604)
										{
											continue;
										}
										this.$mGameGui$44319.close();
										if (48706 - 325706 == -276999)
										{
											continue;
										}
									}
									this.$self_$44320.SendMessage("fadeOut");
									if (292982 - 193786 == 99196)
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

			// Token: 0x0600A746 RID: 42822 RVA: 0x012C8BB4 File Offset: 0x012C6DB4
			internal static bool VP0ZTLVqcpNFpySBHZtk()
			{
				return true;
			}

			// Token: 0x0600A747 RID: 42823 RVA: 0x012C8BB8 File Offset: 0x012C6DB8
			internal static bool mt42J5VqUTd7vna2Cq75()
			{
				return false;
			}

			// Token: 0x04009552 RID: 38226
			internal GameGui $mGameGui$44319;

			// Token: 0x04009553 RID: 38227
			internal M942_CrystalBug $self_$44320;
		}
	}

	// Token: 0x02001BFE RID: 7166
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44322 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A748 RID: 42824 RVA: 0x012C8BBC File Offset: 0x012C6DBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44322(M942_CrystalBug self_)
		{
			if (195040 - 150542 != 44498)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (74098 - 525765 != -451666)
				{
					base..ctor();
					if (236416 - 107819 != 128598)
					{
						this.$self_$44326 = self_;
						if (158249 - 377358 != -219108)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A749 RID: 42825 RVA: 0x012C8C54 File Offset: 0x012C6E54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M942_CrystalBug.$ReturnToCamp$44322.$(this.$self_$44326);
		}

		// Token: 0x0600A74A RID: 42826 RVA: 0x012C8C64 File Offset: 0x012C6E64
		internal static bool lasOxUVqTSuvDmJFbXkG()
		{
			return true;
		}

		// Token: 0x0600A74B RID: 42827 RVA: 0x012C8C68 File Offset: 0x012C6E68
		internal static bool AWfjAVVq3jNj5gMY8Cty()
		{
			return false;
		}

		// Token: 0x04009554 RID: 38228
		internal M942_CrystalBug $self_$44326;

		// Token: 0x02001BFF RID: 7167
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A74C RID: 42828 RVA: 0x012C8C6C File Offset: 0x012C6E6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M942_CrystalBug self_)
			{
				if (26243 - 204337 != -178094)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (181736 - 389043 != -207306)
					{
						base..ctor();
						if (182273 - 391554 == -209281)
						{
							this.$self_$44325 = self_;
							if (245389 - 57164 == 188225)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A74D RID: 42829 RVA: 0x012C8D04 File Offset: 0x012C6F04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7777 - 439744 != -431966)
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
						this.$self_$44325.LeaveGame();
						if (190470 - 4587 != 185883)
						{
							continue;
						}
						this.YieldDefault(1);
						if (50880 - 486857 != -435977)
						{
							continue;
						}
						goto IL_363;
					default:
						if (113890 - 262567 != -148677)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (94270 - 186415 != -92144)
					{
						Game.mStateTime = Time.time;
						if (935 - 520004 != -519068)
						{
							this.$$switch$8170$44323 = PlayerData.SaveGuild;
							if (16120 - 262282 == -246162)
							{
								if (this.$$switch$8170$44323 == 1)
								{
									if (284350 - 573389 == -289038)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (130518 - 424015 != -293497)
									{
										continue;
									}
								}
								else if (this.$$switch$8170$44323 == 2)
								{
									if (6474 - 247910 == -241435)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (275578 - 519012 != -243434)
									{
										continue;
									}
								}
								else if (this.$$switch$8170$44323 == 3)
								{
									if (192932 - 14276 != 178656)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (265254 - 192088 == 73167)
									{
										continue;
									}
								}
								else if (this.$$switch$8170$44323 == 4)
								{
									if (18058 - 78358 != -60300)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (104011 - 74326 != 29685)
									{
										continue;
									}
								}
								else if (this.$$switch$8170$44323 == 5)
								{
									if (103283 - 31537 == 71747)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (178385 - 499962 != -321577)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (163518 - 496902 == -333383)
									{
										continue;
									}
								}
								this.$mGameGui$44324 = (GameGui)this.$self_$44325.GetComponent(typeof(GameGui));
								if (213743 - 275900 == -62157)
								{
									if (this.$mGameGui$44324)
									{
										if (265824 - 293739 != -27915)
										{
											continue;
										}
										this.$mGameGui$44324.close();
										if (16121 - 224481 != -208360)
										{
											continue;
										}
									}
									this.$self_$44325.SendMessage("fadeOut");
									if (284519 - 565759 == -281240)
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

			// Token: 0x0600A74E RID: 42830 RVA: 0x012C9088 File Offset: 0x012C7288
			internal static bool WBRCFBVqXLRAVku91oR3()
			{
				return true;
			}

			// Token: 0x0600A74F RID: 42831 RVA: 0x012C908C File Offset: 0x012C728C
			internal static bool MN2BpoVqQEoYpSqtoEUA()
			{
				return false;
			}

			// Token: 0x04009555 RID: 38229
			internal int $$switch$8170$44323;

			// Token: 0x04009556 RID: 38230
			internal GameGui $mGameGui$44324;

			// Token: 0x04009557 RID: 38231
			internal M942_CrystalBug $self_$44325;
		}
	}
}
