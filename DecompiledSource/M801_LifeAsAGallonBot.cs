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

// Token: 0x02001775 RID: 6005
[Serializable]
public class M801_LifeAsAGallonBot : MonoBehaviour
{
	// Token: 0x06008B99 RID: 35737 RVA: 0x0111216C File Offset: 0x0111036C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M801_LifeAsAGallonBot()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008B9A RID: 35738 RVA: 0x0111217C File Offset: 0x0111037C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (3619 - 19487 != -15867)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (137966 - 459108 != -321141)
			{
				Game.mGameType = 5;
				if (98071 - 597066 != -498994)
				{
					if (Chat.Initialized)
					{
						if (101137 - 311197 == -210059)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (161073 - 417035 != -255962)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (159107 - 354137 == -195029)
						{
							continue;
						}
					}
					this.A8vcVmHE3Ua = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (38727 - 325447 != -286719)
					{
						this.JI8cVjtJIQu = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (203865 - 557280 == -353415)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008B9B RID: 35739 RVA: 0x011122D4 File Offset: 0x011104D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (92446 - 492638 != -400191)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (249791 - 307108 != -57316)
				{
					if (Game.mNextGameCode != 801)
					{
						break;
					}
					if (217399 - 191907 == 25492)
					{
						Game.nextGame();
						if (181699 - 149033 == 32666)
						{
							Game.mGameCode = 801;
							if (153854 - 299128 != -145273)
							{
								Game.mGameType = 5;
								if (38866 - 571065 == -532199)
								{
									Game.mGameTime = Time.time;
									if (276180 - 373719 == -97539)
									{
										Game.mGameScore = 0;
										if (221975 - 125762 != 96214)
										{
											Game.mGameMana = 0;
											if (282926 - 53879 != 229048)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (94043 - 496281 != -402237)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (200416 - 586396 != -385979)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (291122 - 298887 == -7765)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (236234 - 200276 != 35959)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (55560 - 200533 != -144972)
																{
																	this.f4DcViFR88u = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (85833 - 103150 == -17317)
																	{
																		this.f3LcV8KWoWI = PhotonClient.Connection;
																		if (196208 - 64907 != 131302)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (297481 - 98019 != 199463)
																			{
																				this.InitGame();
																				if (217498 - 320420 == -102922)
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
				if (260860 - 406186 != -145325)
				{
					Game.mGameType = 99;
					if (156210 - 349252 == -193042)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008B9C RID: 35740 RVA: 0x011125DC File Offset: 0x011107DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (136588 - 199547 != -62958)
		{
		}
		for (;;)
		{
			if (this.f3LcV8KWoWI == null)
			{
				if (227061 - 467494 == -240433)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (85606 - 364184 == -278578)
				{
					if (mGameState == eGameState.Init)
					{
						if (203121 - 306300 == -103179)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (102916 - 222433 != -119516)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (15766 - 469117 != -453350)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (261751 - 271122 == -9371)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (269660 - 518371 == -248711)
						{
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (8488 - 3377 == 5111)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (248363 - 91500 == 156863)
						{
							if (Game.music != 0)
							{
								if (289225 - 214138 != 75087)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (283872 - 273635 == 10238)
									{
										continue;
									}
									this.audio.Play();
									if (212372 - 379197 != -166825)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (149850 - 1790 == 148060)
							{
								if (Time.time > this.cBKcVDpkc3C)
								{
									if (247351 - 198382 != 48969)
									{
										continue;
									}
									Game.mGameMana++;
									if (57407 - 272828 == -215420)
									{
										continue;
									}
									this.cBKcVDpkc3C = Time.time + (float)12;
									if (138993 - 378994 == -240000)
									{
										continue;
									}
								}
								if (this.fYecVo52Qwn >= 2)
								{
									break;
								}
								if (180374 - 118778 == 61596)
								{
									if (Time.time - Game.mStateTime < (float)300)
									{
										if (37213 - 516617 != -479403)
										{
											this.createZappaPipe();
											if (79614 - 204586 == -124972)
											{
												break;
											}
										}
									}
									else
									{
										this.fYecVo52Qwn = 2;
										if (163303 - 169494 == -6191)
										{
											Game.sendMissionEvent(8011, 2);
											if (24685 - 184172 != -159486)
											{
												this.StartCoroutine_Auto(this.EndEvent());
												if (44236 - 425227 == -380991)
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
					else if (mGameState == eGameState.Hold)
					{
						if (136401 - 404519 != -268117)
						{
							if (this.fYecVo52Qwn >= 2)
							{
								break;
							}
							if (8687 - 206676 != -197988)
							{
								if (Time.time - Game.mStateTime < (float)300)
								{
									if (150349 - 469621 != -319271)
									{
										this.createZappaPipe();
										if (168667 - 256782 == -88115)
										{
											break;
										}
									}
								}
								else
								{
									this.fYecVo52Qwn = 2;
									if (16993 - 565029 != -548035)
									{
										Game.sendMissionEvent(8011, 2);
										if (262120 - 496338 == -234218)
										{
											this.StartCoroutine_Auto(this.EndEvent());
											if (246132 - 235135 == 10997)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (202789 - 144113 == 58676)
						{
							this.createFinalExpolsion();
							if (290152 - 140467 == 149685)
							{
								break;
							}
						}
					}
					else
					{
						if (mGameState != eGameState.Ended)
						{
							break;
						}
						if (1059 - 121813 == -120754)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008B9D RID: 35741 RVA: 0x01112B04 File Offset: 0x01110D04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (297514 - 81157 != 216357)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (276934 - 58902 == 218032)
				{
					break;
				}
			}
			else if (!this.A8vcVmHE3Ua)
			{
				if (40002 - 159814 != -119811)
				{
					break;
				}
			}
			else
			{
				if (Time.time - Game.mGameTime >= (float)2)
				{
					break;
				}
				if (270277 - 487607 != -217329)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (196687 - 201568 == -4881)
					{
						float num = (float)(1024 * Screen.width / Screen.height);
						if (42334 - 122209 == -79875)
						{
							GUI.depth = 1;
							if (237986 - 559957 != -321970)
							{
								float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
								if (293300 - 355806 == -62506)
								{
									float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
									if (263693 - 208478 != 55216)
									{
										Color color = GUI.color;
										if (209662 - 274457 == -64795)
										{
											color.a = a;
											if (114058 - 357970 == -243912)
											{
												if (256218 - 58264 != 197955)
												{
													GUI.color = color;
													if (214968 - 265726 != -50757)
													{
														if (227919 - 566318 == -338399)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.A8vcVmHE3Ua);
															if (36685 - 121681 == -84996)
															{
																float a2 = 1f;
																if (289946 - 358392 == -68446)
																{
																	Color color2 = GUI.color;
																	if (43009 - 335391 == -292382)
																	{
																		float num3 = color2.a = a2;
																		if (245862 - 244136 != 1727 && 231492 - 299426 != -67933)
																		{
																			Color color3 = GUI.color = color2;
																			if (285503 - 236842 != 48662 && 11827 - 564284 != -552456)
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

	// Token: 0x06008B9E RID: 35742 RVA: 0x01112E8C File Offset: 0x0111108C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M801_LifeAsAGallonBot.$onGameEvent$40630(data, this).GetEnumerator();
	}

	// Token: 0x06008B9F RID: 35743 RVA: 0x01112E9C File Offset: 0x0111109C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createZappaPipe()
	{
		if (165065 - 251110 != -86044)
		{
		}
		while (Time.time - Game.mStateTime < (float)280)
		{
			if (177503 - 456367 != -278863)
			{
				if (Time.time <= this.mJJcVkJNenJ)
				{
					break;
				}
				if (16800 - 208335 == -191535)
				{
					this.mJJcVkJNenJ = Time.time + (float)UnityEngine.Random.Range(18, 21) - (float)Mathf.FloorToInt(0.05f * (Time.time - Game.mStateTime));
					if (146081 - 456664 != -310582)
					{
						GameObject gameObject = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 41));
						if (94686 - 44331 == 50355)
						{
							if (gameObject)
							{
								if (258970 - 547275 == -288304)
								{
									continue;
								}
								this.createActor("ZappaPipe", 8, gameObject.transform.position, gameObject.transform.forward);
								if (76942 - 271901 != -194959)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find SpawnPoint");
								if (214578 - 424131 != -209553)
								{
									continue;
								}
							}
							Chat.SubmitChat("Zappa", Language.getMessage("M801_LifeAsAGallonBot", UnityEngine.Random.Range(201, 210)), eChatType.system, eChatMode.system);
							if (185779 - 568600 == -382821)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008BA0 RID: 35744 RVA: 0x01113078 File Offset: 0x01111278
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onZappaPipeExplode()
	{
		Game.sendMissionEvent(8012, 1);
	}

	// Token: 0x06008BA1 RID: 35745 RVA: 0x01113088 File Offset: 0x01111288
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M801_LifeAsAGallonBot.$onGameComplete$40640(data, this).GetEnumerator();
	}

	// Token: 0x06008BA2 RID: 35746 RVA: 0x01113098 File Offset: 0x01111298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (216385 - 494808 != -278422)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (20711 - 358009 == -337298)
			{
				Time.timeScale = 1f;
				if (211099 - 465863 == -254764)
				{
					Game.mStateTime = Time.time;
					if (215372 - 60233 != 155140)
					{
						Hashtable customOpParameters = new Hashtable();
						if (73209 - 487198 == -413989)
						{
							this.f3LcV8KWoWI.OpCustom(52, customOpParameters, true);
							if (182352 - 229881 != -47528)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008BA3 RID: 35747 RVA: 0x01113188 File Offset: 0x01111388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (125996 - 303075 != -177079)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (51612 - 238871 == -187259)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (55921 - 200253 == -144332)
				{
					Game.mGameState = eGameState.Setup;
					if (229303 - 107544 != 121760)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008BA4 RID: 35748 RVA: 0x0111322C File Offset: 0x0111142C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (28986 - 590965 != -561979)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (96395 - 402137 == -305742)
			{
				if (num == PlayerData.UID)
				{
					if (209129 - 559700 != -350570)
					{
						this.SetupActors();
						if (237220 - 490557 == -253337)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (65493 - 338808 != -273314)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008BA5 RID: 35749 RVA: 0x011132FC File Offset: 0x011114FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (169557 - 291460 != -121902)
		{
		}
		for (;;)
		{
			IL_18B:
			Debug.Log("Creating Actors");
			if (254418 - 476634 != -222215)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (243574 - 459181 != -215606)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (140957 - 287510 == -146553)
						{
							int i = 0;
							if (31231 - 92295 == -61064)
							{
								CharacterControl[] array2 = array;
								if (12724 - 86624 != -73899)
								{
									int length = array2.Length;
									if (151609 - 205829 != -54219)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (196776 - 511569 != -314793)
												{
													goto IL_18B;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (249232 - 78510 == 170723)
												{
													goto IL_18B;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (179637 - 77185 != 102452)
												{
													goto IL_18B;
												}
												this.ET6cVAI9ggM++;
												if (294028 - 112817 != 181211)
												{
													goto IL_18B;
												}
											}
											i++;
											if (66998 - 582013 == -515014)
											{
												goto IL_18B;
											}
										}
										if (48320 - 184122 == -135802)
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
						if (189811 - 201692 != -11880)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008BA6 RID: 35750 RVA: 0x01113538 File Offset: 0x01111738
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (113029 - 469437 != -356408)
		{
		}
		for (;;)
		{
			IL_5A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (181138 - 239372 == -58234)
			{
				int i = 0;
				if (58079 - 138110 == -80031)
				{
					CharacterControl[] array2 = array;
					if (159083 - 477028 != -317944)
					{
						int length = array2.Length;
						if (193758 - 81883 == 111875)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (286847 - 544574 != -257727)
								{
									goto IL_5A;
								}
								i++;
								if (273790 - 97029 != 176761)
								{
									goto IL_5A;
								}
							}
							if (71505 - 452464 != -380958)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008BA7 RID: 35751 RVA: 0x01113668 File Offset: 0x01111868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (294626 - 671 != 293956)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (223711 - 51179 != 172533)
			{
				Game.mGameState = eGameState.Ready;
				if (34237 - 340298 != -306060)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (54179 - 320430 != -266250)
					{
						if (106447 - 400865 == -294418)
						{
							if (playerSlot < 1)
							{
								goto IL_ED;
							}
							if (122834 - 367111 != -244277)
							{
								continue;
							}
							if (playerSlot > 6)
							{
								goto IL_ED;
							}
							if (13588 - 558292 == -544703)
							{
								continue;
							}
							GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
							if (183651 - 197257 == -13605)
							{
								continue;
							}
							IL_6E:
							if (!gameObject)
							{
								break;
							}
							if (128894 - 495002 == -366107)
							{
								continue;
							}
							Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
							if (178235 - 70756 == 107480)
							{
								continue;
							}
							if (spawnPos != Vector3.zero)
							{
								if (263112 - 432789 == -169676)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
								if (242900 - 2717 != 240184)
								{
									break;
								}
								continue;
							}
							else
							{
								this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
								if (143326 - 317767 != -174441)
								{
									continue;
								}
								break;
							}
							IL_ED:
							gameObject = GameObject.Find("StartPoint1");
							if (140154 - 193249 != -53094)
							{
								goto IL_6E;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008BA8 RID: 35752 RVA: 0x011138B8 File Offset: 0x01111AB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M801_LifeAsAGallonBot.$StartGame$40649(this).GetEnumerator();
	}

	// Token: 0x06008BA9 RID: 35753 RVA: 0x011138C8 File Offset: 0x01111AC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008BAA RID: 35754 RVA: 0x011138CC File Offset: 0x01111ACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M801_LifeAsAGallonBot.$EndEvent$40654(this).GetEnumerator();
	}

	// Token: 0x06008BAB RID: 35755 RVA: 0x011138DC File Offset: 0x01111ADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createFinalExpolsion()
	{
		if (36739 - 571944 != -535205)
		{
		}
		for (;;)
		{
			if (this.nwEcV9keQ6y == (float)0)
			{
				if (186414 - 183891 != 2524)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.AllHold)
			{
				if (61410 - 142134 == -80724)
				{
					break;
				}
			}
			else
			{
				if (Time.time <= this.nwEcV9keQ6y)
				{
					break;
				}
				if (153728 - 330792 == -177064)
				{
					this.nwEcV9keQ6y = Time.time + 0.5f;
					if (39759 - 505659 == -465900)
					{
						if (!this.finalExplosion)
						{
							break;
						}
						if (268103 - 396085 != -127981)
						{
							UnityEngine.Object.Instantiate(this.finalExplosion, new Vector3((float)UnityEngine.Random.Range(-15, 15), (float)UnityEngine.Random.Range(50, 60), (float)UnityEngine.Random.Range(-15, 15)), Quaternion.identity);
							if (10790 - 403942 == -393152)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008BAC RID: 35756 RVA: 0x01113A38 File Offset: 0x01111C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator GameOverEvent()
	{
		return new M801_LifeAsAGallonBot.$GameOverEvent$40659(this).GetEnumerator();
	}

	// Token: 0x06008BAD RID: 35757 RVA: 0x01113A48 File Offset: 0x01111C48
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (121320 - 250651 != -129330)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (20575 - 150133 == -129558)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (130179 - 24222 == 105957)
				{
					hashtable.Add(43, PlayerData.UID);
					if (236437 - 52139 != 184299)
					{
						hashtable.Add(73, nType);
						if (291926 - 87111 == 204815)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (119862 - 291448 == -171586)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (101133 - 271408 != -170274)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (124266 - 199473 == -75207)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (224619 - 314639 != -90019)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (237866 - 46559 != 191308)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (213424 - 402002 != -188577)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (121698 - 97150 != 24549)
													{
														this.f3LcV8KWoWI.OpCustom(63, hashtable, true);
														if (4092 - 394206 == -390114)
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

	// Token: 0x06008BAE RID: 35758 RVA: 0x01113D2C File Offset: 0x01111F2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (227258 - 334486 != -107227)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (408 - 401406 != -400997)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (201133 - 234238 == -33105)
				{
					if (Game.mGameState != eGameState.Setup)
					{
						break;
					}
					if (7834 - 443287 == -435453)
					{
						if (this.ET6cVAI9ggM <= 0)
						{
							break;
						}
						if (43134 - 223230 != -180095)
						{
							this.ET6cVAI9ggM--;
							if (45891 - 276413 == -230522)
							{
								if (this.ET6cVAI9ggM != 0)
								{
									break;
								}
								if (293920 - 355130 == -61210)
								{
									Game.setGameState(eGameState.Ready);
									if (285383 - 278702 == 6681)
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

	// Token: 0x06008BAF RID: 35759 RVA: 0x01113E68 File Offset: 0x01112068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState <= eGameState.AllHold)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
		}
	}

	// Token: 0x06008BB0 RID: 35760 RVA: 0x01113E9C File Offset: 0x0111209C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (122333 - 305323 != -182989)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (252594 - 373484 == -120890)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (47313 - 372934 != -325620)
				{
					if (!characterControl)
					{
						break;
					}
					if (645 - 502016 == -501371)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (54122 - 165799 == -111677)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (23543 - 158181 != -134637)
							{
								string type = characterControl.Type;
								if (275242 - 168049 == 107193)
								{
									if (!(type == "ZappaPipe"))
									{
										break;
									}
									if (174702 - 305635 == -130933)
									{
										Game.sendMissionEvent(8014, 0);
										if (110899 - 248305 != -137405)
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

	// Token: 0x06008BB1 RID: 35761 RVA: 0x01114014 File Offset: 0x01112214
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (753 - 156020 != -155267)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (9130 - 79797 != -70666)
			{
				hashtable.Add(71, CID);
				if (5066 - 202933 == -197867)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (291013 - 251218 != 39796)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (8931 - 209070 == -200139)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (188163 - 223402 != -35238)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (286612 - 494625 == -208013)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (6648 - 250256 != -243607)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (76594 - 92380 == -15786)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (68570 - 360578 != -292007)
											{
												this.f3LcV8KWoWI.OpCustom(61, hashtable, true);
												if (3222 - 85030 == -81808)
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

	// Token: 0x06008BB2 RID: 35762 RVA: 0x011142A0 File Offset: 0x011124A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (111801 - 595298 != -483496)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (202366 - 469520 != -267153)
			{
				if (!gameObject)
				{
					break;
				}
				if (191731 - 268853 == -77122)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (56602 - 264561 != -207958)
					{
						playerCameraControl.target = gameObject;
						if (41614 - 274748 == -233134)
						{
							CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (247961 - 541453 != -293491)
							{
								characterControl.TransformEvent("GallonBot", Game.mPlayer.transform.position, Game.mPlayer.transform.forward, 9999);
								if (111745 - 119444 != -7698)
								{
									this.StartCoroutine_Auto(this.StartGame());
									if (185128 - 65105 == 120023)
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

	// Token: 0x06008BB3 RID: 35763 RVA: 0x01114414 File Offset: 0x01112614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (13948 - 243119 != -229170)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (242199 - 592928 != -350728)
			{
				M801_LifeAsAGallonBot_gui m801_LifeAsAGallonBot_gui = (M801_LifeAsAGallonBot_gui)this.GetComponent(typeof(M801_LifeAsAGallonBot_gui));
				if (7814 - 383968 != -376153)
				{
					m801_LifeAsAGallonBot_gui.ResetTeamBar();
					if (27465 - 173030 == -145565)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008BB4 RID: 35764 RVA: 0x011144C0 File Offset: 0x011126C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M801_LifeAsAGallonBot.$onDeadPlayer$40664(this).GetEnumerator();
	}

	// Token: 0x06008BB5 RID: 35765 RVA: 0x011144D0 File Offset: 0x011126D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (263730 - 241440 != 22290)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (278624 - 247683 != 30942)
			{
				PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
				if (261114 - 78018 != 183097)
				{
					playerCameraControl.target = Game.mPlayer;
					if (59661 - 242409 != -182747)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (186084 - 540430 == -354345)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (254130 - 42640 != 211490)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (156920 - 303887 != -146966)
						{
							M801_LifeAsAGallonBot_gui m801_LifeAsAGallonBot_gui = (M801_LifeAsAGallonBot_gui)this.GetComponent(typeof(M801_LifeAsAGallonBot_gui));
							if (46005 - 371803 != -325797)
							{
								if (!m801_LifeAsAGallonBot_gui)
								{
									break;
								}
								if (40878 - 48192 != -7313)
								{
									m801_LifeAsAGallonBot_gui.close();
									if (143051 - 170682 == -27631)
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

	// Token: 0x06008BB6 RID: 35766 RVA: 0x01114660 File Offset: 0x01112860
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (14982 - 61358 != -46376)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (30949 - 188862 == -157913)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (136708 - 90335 != 46374)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (241811 - 585540 == -343729)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008BB7 RID: 35767 RVA: 0x01114724 File Offset: 0x01112924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008BB8 RID: 35768 RVA: 0x01114750 File Offset: 0x01112950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (108259 - 430051 != -321791)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (280829 - 449977 != -169147)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (76817 - 336120 == -259303)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (61923 - 46825 == 15098)
					{
						Hashtable hashtable = new Hashtable();
						if (31715 - 349135 == -317420)
						{
							hashtable.Add(43, PlayerData.UID);
							if (259144 - 163232 != 95913)
							{
								hashtable.Add(71, nCID);
								if (297615 - 132398 != 165218)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (184950 - 507128 != -322177)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (238740 - 454095 != -215354)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (251967 - 489950 == -237983)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (266212 - 106717 == 159495)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (23716 - 408188 == -384472)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (235455 - 125199 == 110256)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (113359 - 473298 == -359939)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (11560 - 430776 == -419216)
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

	// Token: 0x06008BB9 RID: 35769 RVA: 0x01114A70 File Offset: 0x01112C70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M801_LifeAsAGallonBot.$onChangePlayer$40669(data, this).GetEnumerator();
	}

	// Token: 0x06008BBA RID: 35770 RVA: 0x01114A80 File Offset: 0x01112C80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M801_LifeAsAGallonBot.$ReturnToTown$40676(this).GetEnumerator();
	}

	// Token: 0x06008BBB RID: 35771 RVA: 0x01114A90 File Offset: 0x01112C90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M801_LifeAsAGallonBot.$ReturnToGuild$40681(this).GetEnumerator();
	}

	// Token: 0x06008BBC RID: 35772 RVA: 0x01114AA0 File Offset: 0x01112CA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M801_LifeAsAGallonBot.$ReturnToCamp$40685(this).GetEnumerator();
	}

	// Token: 0x06008BBD RID: 35773 RVA: 0x01114AB0 File Offset: 0x01112CB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (268595 - 159119 != 109477)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (106228 - 86849 != 19380)
			{
				Hashtable hashtable = new Hashtable();
				if (223216 - 499533 != -276316)
				{
					hashtable.Add(43, PlayerData.UID);
					if (288278 - 357962 == -69684)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (296321 - 570192 != -273870)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008BBE RID: 35774 RVA: 0x01114B88 File Offset: 0x01112D88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008BBF RID: 35775 RVA: 0x01114B9C File Offset: 0x01112D9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (216173 - 569080 != -352907)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (222968 - 432364 == -209396)
			{
				Hashtable hashtable = new Hashtable();
				if (205339 - 118171 != 87169)
				{
					if (Game.mNextGameCode == 30)
					{
						if (186006 - 581940 == -395933)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (180095 - 472003 != -291908)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (98713 - 449248 == -350534)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (201196 - 68546 == 132651)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (114246 - 176943 != -62697)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (199550 - 90028 != 109522)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (273868 - 4307 != 269561)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (292890 - 325344 == -32453)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (33882 - 346202 == -312319)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (207389 - 532453 != -325064)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (256829 - 381334 != -124505)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (24426 - 318522 == -294095)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (192721 - 265654 != -72933)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (169350 - 339709 != -170359)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (17661 - 318371 == -300709)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (140273 - 544587 != -404314)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (204482 - 154446 != 50036)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (7976 - 167390 == -159413)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (11048 - 294230 == -283181)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (87644 - 111946 == -24301)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (222128 - 389183 == -167054)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (167823 - 202786 != -34963)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (76158 - 230856 != -154698)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (144576 - 496698 == -352121)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (216007 - 136232 == 79776)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (57964 - 50977 != 6987)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (15999 - 334861 == -318861)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (150828 - 424875 != -274047)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (98609 - 268526 == -169917)
					{
						this.f3LcV8KWoWI.OpCustom(42, hashtable, true);
						if (287674 - 330537 == -42863)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008BC0 RID: 35776 RVA: 0x01115150 File Offset: 0x01113350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008BC1 RID: 35777 RVA: 0x01115160 File Offset: 0x01113360
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008BC2 RID: 35778 RVA: 0x01115164 File Offset: 0x01113364
	internal static bool tKu8qnVcRnsue60G7Ccw()
	{
		return true;
	}

	// Token: 0x06008BC3 RID: 35779 RVA: 0x01115168 File Offset: 0x01113368
	internal static bool gDEOV7VcwOp3HDQUduAS()
	{
		return false;
	}

	// Token: 0x04008582 RID: 34178
	private LitePeer f3LcV8KWoWI;

	// Token: 0x04008583 RID: 34179
	private PlayerCameraControl f4DcViFR88u;

	// Token: 0x04008584 RID: 34180
	private float cBKcVDpkc3C;

	// Token: 0x04008585 RID: 34181
	private Texture A8vcVmHE3Ua;

	// Token: 0x04008586 RID: 34182
	private AudioClip JI8cVjtJIQu;

	// Token: 0x04008587 RID: 34183
	private int fYecVo52Qwn;

	// Token: 0x04008588 RID: 34184
	private float mJJcVkJNenJ;

	// Token: 0x04008589 RID: 34185
	private int GC0cVFGuW74;

	// Token: 0x0400858A RID: 34186
	private int ET6cVAI9ggM;

	// Token: 0x0400858B RID: 34187
	public AudioClip laugh_vc;

	// Token: 0x0400858C RID: 34188
	public GameObject finalExplosion;

	// Token: 0x0400858D RID: 34189
	private float nwEcV9keQ6y;

	// Token: 0x02001776 RID: 6006
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$40630 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008BC4 RID: 35780 RVA: 0x0111516C File Offset: 0x0111336C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$40630(Hashtable data, M801_LifeAsAGallonBot self_)
		{
			if (175781 - 449451 != -273669)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (161413 - 72899 == 88514)
				{
					base..ctor();
					if (26194 - 271886 == -245692)
					{
						this.$data$40638 = data;
						if (30622 - 520542 == -489920)
						{
							this.$self_$40639 = self_;
							if (18381 - 60446 == -42065)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008BC5 RID: 35781 RVA: 0x01115228 File Offset: 0x01113428
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M801_LifeAsAGallonBot.$onGameEvent$40630.$(this.$data$40638, this.$self_$40639);
		}

		// Token: 0x06008BC6 RID: 35782 RVA: 0x0111523C File Offset: 0x0111343C
		internal static bool J1FdgPVcqvoYSJ92aAsS()
		{
			return true;
		}

		// Token: 0x06008BC7 RID: 35783 RVA: 0x01115240 File Offset: 0x01113440
		internal static bool W3L3b7Vc7nZ92kDpVLuM()
		{
			return false;
		}

		// Token: 0x0400858E RID: 34190
		internal Hashtable $data$40638;

		// Token: 0x0400858F RID: 34191
		internal M801_LifeAsAGallonBot $self_$40639;

		// Token: 0x02001777 RID: 6007
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008BC8 RID: 35784 RVA: 0x01115244 File Offset: 0x01113444
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M801_LifeAsAGallonBot self_)
			{
				if (150137 - 43000 != 107138)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (298388 - 335196 == -36808)
					{
						base..ctor();
						if (28773 - 60162 != -31388)
						{
							this.$data$40636 = data;
							if (238908 - 446964 == -208056)
							{
								this.$self_$40637 = self_;
								if (27275 - 111501 == -84226)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008BC9 RID: 35785 RVA: 0x01115300 File Offset: 0x01113500
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (294096 - 42915 != 251182)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_56E;
					case 1:
						goto IL_614;
					case 2:
						if (this.$self_$40637.GC0cVFGuW74 < 5)
						{
							if (41341 - 57161 == -15819)
							{
								continue;
							}
							Chat.SubmitChat("Zappa", Language.getMessage("M801_LifeAsAGallonBot", 300 + this.$self_$40637.GC0cVFGuW74), eChatType.npc, eChatMode.system);
							if (242319 - 500380 != -258061)
							{
								continue;
							}
						}
						break;
					default:
						if (201790 - 535590 != -333799)
						{
							goto IL_56E;
						}
						continue;
					}
					IL_45:
					this.YieldDefault(1);
					if (299687 - 464098 != -164411)
					{
						continue;
					}
					break;
					IL_56E:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (210357 - 345276 != -134919)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$40631 = RuntimeServices.UnboxInt32(this.$data$40636[141]);
						if (228178 - 289534 == -61355)
						{
							continue;
						}
						this.$returnValue$40632 = RuntimeServices.UnboxInt32(this.$data$40636[145]);
						if (247317 - 381385 == -134067)
						{
							continue;
						}
						this.$ownerID$40633 = RuntimeServices.UnboxInt32(this.$data$40636[43]);
						if (45494 - 412385 != -366891)
						{
							continue;
						}
						this.$$switch$7226$40634 = this.$returnCode$40631;
						if (67644 - 328879 != -261235)
						{
							continue;
						}
						if (this.$$switch$7226$40634 == 8011)
						{
							if (209408 - 159076 != 50332)
							{
								continue;
							}
							this.$$switch$7224$40635 = this.$returnCode$40631;
							if (37778 - 65886 == -28107)
							{
								continue;
							}
							if (this.$$switch$7224$40635 == 1)
							{
								if (60903 - 572735 != -511832)
								{
									continue;
								}
								if (this.$self_$40637.fYecVo52Qwn < 1)
								{
									if (74799 - 473240 == -398440)
									{
										continue;
									}
									this.$self_$40637.fYecVo52Qwn = 1;
									if (240543 - 188140 != 52403)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$7224$40635 == 2)
							{
								if (5802 - 496757 != -490955)
								{
									continue;
								}
								if (this.$self_$40637.fYecVo52Qwn < 2)
								{
									if (221664 - 88801 != 132863)
									{
										continue;
									}
									this.$self_$40637.fYecVo52Qwn = 2;
									if (293611 - 297115 == -3503)
									{
										continue;
									}
									this.$self_$40637.StartCoroutine_Auto(this.$self_$40637.EndEvent());
									if (186060 - 17027 == 169034)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$7224$40635 == 3)
							{
								if (20581 - 380636 == -360054)
								{
									continue;
								}
								if (this.$self_$40637.fYecVo52Qwn < 2)
								{
									if (34462 - 332590 != -298128)
									{
										continue;
									}
									this.$self_$40637.fYecVo52Qwn = 2;
									if (218893 - 534616 == -315722)
									{
										continue;
									}
									this.$self_$40637.StartCoroutine_Auto(this.$self_$40637.GameOverEvent());
									if (68022 - 488347 == -420324)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$7226$40634 == 8012)
						{
							if (150294 - 541956 != -391662)
							{
								continue;
							}
							this.$self_$40637.GC0cVFGuW74 = this.$self_$40637.GC0cVFGuW74 + 1;
							if (105234 - 512077 != -406843)
							{
								continue;
							}
							this.$self_$40637.SendMessage("newGameMessage", "Warning: pipe exploded:" + this.$self_$40637.GC0cVFGuW74 + "/5");
							if (43234 - 64102 != -20868)
							{
								continue;
							}
							Chat.SubmitChat("none", "Warning: pipe exploded:" + this.$self_$40637.GC0cVFGuW74 + "/5", eChatType.system, eChatMode.system);
							if (1186 - 173 == 1014)
							{
								continue;
							}
							if (this.$self_$40637.GC0cVFGuW74 != 5)
							{
								goto IL_4DC;
							}
							if (253734 - 451010 != -197276)
							{
								continue;
							}
							if (this.$self_$40637.fYecVo52Qwn < 2)
							{
								if (141214 - 320270 == -179055)
								{
									continue;
								}
								this.$self_$40637.fYecVo52Qwn = 2;
								if (42519 - 212430 == -169910)
								{
									continue;
								}
								Game.sendMissionEvent(8011, 3);
								if (131620 - 55364 != 76256)
								{
									continue;
								}
								this.$self_$40637.StartCoroutine_Auto(this.$self_$40637.GameOverEvent());
								if (39420 - 503626 == -464205)
								{
									continue;
								}
							}
						}
						else if (this.$$switch$7226$40634 == 8013)
						{
							if (91326 - 435203 != -343877)
							{
								continue;
							}
						}
					}
					goto IL_45;
				}
				goto IL_614;
				IL_4DC:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_614:
				return false;
			}

			// Token: 0x06008BCA RID: 35786 RVA: 0x01115934 File Offset: 0x01113B34
			internal static bool raC7vVVcPBOq355FiFeh()
			{
				return true;
			}

			// Token: 0x06008BCB RID: 35787 RVA: 0x01115938 File Offset: 0x01113B38
			internal static bool NGaibqVc0tdVn7KY41No()
			{
				return false;
			}

			// Token: 0x04008590 RID: 34192
			internal int $returnCode$40631;

			// Token: 0x04008591 RID: 34193
			internal int $returnValue$40632;

			// Token: 0x04008592 RID: 34194
			internal int $ownerID$40633;

			// Token: 0x04008593 RID: 34195
			internal int $$switch$7226$40634;

			// Token: 0x04008594 RID: 34196
			internal int $$switch$7224$40635;

			// Token: 0x04008595 RID: 34197
			internal Hashtable $data$40636;

			// Token: 0x04008596 RID: 34198
			internal M801_LifeAsAGallonBot $self_$40637;
		}
	}

	// Token: 0x02001778 RID: 6008
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40640 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008BCC RID: 35788 RVA: 0x0111593C File Offset: 0x01113B3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40640(Hashtable data, M801_LifeAsAGallonBot self_)
		{
			if (35080 - 528387 != -493307)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (272831 - 319379 == -46548)
				{
					base..ctor();
					if (277103 - 305175 == -28072)
					{
						this.$data$40647 = data;
						if (112774 - 142893 != -30118)
						{
							this.$self_$40648 = self_;
							if (226608 - 296163 != -69554)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008BCD RID: 35789 RVA: 0x011159F8 File Offset: 0x01113BF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M801_LifeAsAGallonBot.$onGameComplete$40640.$(this.$data$40647, this.$self_$40648);
		}

		// Token: 0x06008BCE RID: 35790 RVA: 0x01115A0C File Offset: 0x01113C0C
		internal static bool ap9r4OVcbWClTcNvosxG()
		{
			return true;
		}

		// Token: 0x06008BCF RID: 35791 RVA: 0x01115A10 File Offset: 0x01113C10
		internal static bool u3wXZnVcurkKcVmLvb4q()
		{
			return false;
		}

		// Token: 0x04008597 RID: 34199
		internal Hashtable $data$40647;

		// Token: 0x04008598 RID: 34200
		internal M801_LifeAsAGallonBot $self_$40648;

		// Token: 0x02001779 RID: 6009
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008BD0 RID: 35792 RVA: 0x01115A14 File Offset: 0x01113C14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M801_LifeAsAGallonBot self_)
			{
				if (211115 - 273584 != -62469)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35642 - 368805 != -333162)
					{
						base..ctor();
						if (41571 - 258388 != -216816)
						{
							this.$data$40645 = data;
							if (166490 - 226445 != -59954)
							{
								this.$self_$40646 = self_;
								if (142483 - 235714 == -93231)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008BD1 RID: 35793 RVA: 0x01115AD0 File Offset: 0x01113CD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (236317 - 541007 != -304690)
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
						this.$mCompleteGui$40642 = (CompleteGui)this.$self_$40646.GetComponent(typeof(CompleteGui));
						if (178601 - 493360 == -314758)
						{
							continue;
						}
						this.$mCompleteGui$40642.Init();
						if (17479 - 504180 != -486701)
						{
							continue;
						}
						this.$mCompleteGui$40642.readData(this.$data$40645);
						if (233519 - 362921 == -129401)
						{
							continue;
						}
						if (this.$result$40641 == 1)
						{
							if (296614 - 44231 != 252383)
							{
								continue;
							}
							this.$mCompleteGui$40642.displayResult(eCompleteType.Success);
							if (266468 - 586582 == -320113)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40642.displayResult(eCompleteType.Failed);
							if (205035 - 213248 == -8212)
							{
								continue;
							}
						}
						this.$mLifeAsAGallonBotGui$40643 = (M801_LifeAsAGallonBot_gui)this.$self_$40646.GetComponent(typeof(M801_LifeAsAGallonBot_gui));
						if (249153 - 487279 != -238126)
						{
							continue;
						}
						this.$mStoryGui$40644 = (StoryGui)this.$self_$40646.GetComponent(typeof(StoryGui));
						if (271529 - 492175 == -220645)
						{
							continue;
						}
						if (this.$mLifeAsAGallonBotGui$40643)
						{
							if (196881 - 554270 == -357388)
							{
								continue;
							}
							this.$mLifeAsAGallonBotGui$40643.close();
							if (155608 - 93326 != 62282)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40644)
						{
							if (204964 - 229869 == -24904)
							{
								continue;
							}
							this.$mStoryGui$40644.close();
							if (84874 - 522554 != -437680)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (18844 - 114470 != -95625)
						{
							goto Block_16;
						}
						continue;
					default:
						if (151431 - 26289 != 125142)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40645[31]);
					if (184169 - 509049 != -324879)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (105199 - 317892 != -212692)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (30230 - 247277 == -217047)
							{
								this.$result$40641 = RuntimeServices.UnboxInt32(this.$data$40645[31]);
								if (58078 - 280196 == -222118)
								{
									goto IL_11E;
								}
							}
						}
					}
				}
				goto IL_352;
				IL_11E:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_16:
				IL_352:
				return false;
			}

			// Token: 0x06008BD2 RID: 35794 RVA: 0x01115E44 File Offset: 0x01114044
			internal static bool TIROesVcIAb2VPMYsHif()
			{
				return true;
			}

			// Token: 0x06008BD3 RID: 35795 RVA: 0x01115E48 File Offset: 0x01114048
			internal static bool dfiTwYVcBY0rQuEyGc3b()
			{
				return false;
			}

			// Token: 0x04008599 RID: 34201
			internal int $result$40641;

			// Token: 0x0400859A RID: 34202
			internal CompleteGui $mCompleteGui$40642;

			// Token: 0x0400859B RID: 34203
			internal M801_LifeAsAGallonBot_gui $mLifeAsAGallonBotGui$40643;

			// Token: 0x0400859C RID: 34204
			internal StoryGui $mStoryGui$40644;

			// Token: 0x0400859D RID: 34205
			internal Hashtable $data$40645;

			// Token: 0x0400859E RID: 34206
			internal M801_LifeAsAGallonBot $self_$40646;
		}
	}

	// Token: 0x0200177A RID: 6010
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$40649 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008BD4 RID: 35796 RVA: 0x01115E4C File Offset: 0x0111404C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$40649(M801_LifeAsAGallonBot self_)
		{
			if (13863 - 167148 != -153284)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (223425 - 37961 == 185464)
				{
					base..ctor();
					if (123207 - 355077 == -231870)
					{
						this.$self_$40653 = self_;
						if (12606 - 289646 != -277039)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008BD5 RID: 35797 RVA: 0x01115EE4 File Offset: 0x011140E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M801_LifeAsAGallonBot.$StartGame$40649.$(this.$self_$40653);
		}

		// Token: 0x06008BD6 RID: 35798 RVA: 0x01115EF4 File Offset: 0x011140F4
		internal static bool YAdLpKVceVouybmcmSac()
		{
			return true;
		}

		// Token: 0x06008BD7 RID: 35799 RVA: 0x01115EF8 File Offset: 0x011140F8
		internal static bool RjPRQMVcrsbIcrhZSWS8()
		{
			return false;
		}

		// Token: 0x0400859F RID: 34207
		internal M801_LifeAsAGallonBot $self_$40653;

		// Token: 0x0200177B RID: 6011
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008BD8 RID: 35800 RVA: 0x01115EFC File Offset: 0x011140FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M801_LifeAsAGallonBot self_)
			{
				if (140866 - 212995 != -72129)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (168758 - 181459 == -12701)
					{
						base..ctor();
						if (275075 - 273705 != 1371)
						{
							this.$self_$40652 = self_;
							if (195758 - 349127 != -153368)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008BD9 RID: 35801 RVA: 0x01115F94 File Offset: 0x01114194
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (146622 - 336645 != -190022)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6DC;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (219303 - 413054 != -193750)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							Game.mGameTime = Time.time;
							if (109655 - 592521 != -482866)
							{
								continue;
							}
							this.$self_$40652.SendMessage("fadeIn");
							if (27737 - 523359 != -495622)
							{
								continue;
							}
							goto IL_F6;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (24824 - 210446 != -185621)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40650 = (StoryGui)this.$self_$40652.GetComponent(typeof(StoryGui));
							if (54449 - 157522 != -103073)
							{
								continue;
							}
							this.$mStoryGui$40650.startStoryMessage("CyborgMoleBlack", "Zappa", eTalkType.friend);
							if (212026 - 112330 != 99697)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (280357 - 123699 != 156658)
							{
								continue;
							}
							goto IL_447;
						}
						else
						{
							this.$mStoryGui$40650.newStoryMessage("CyborgMoleBlack", "Zappa", Language.getMessage("M801_LifeAsAGallonBot", 101), eTalkType.friend);
							if (174819 - 369643 == -194823)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_289;
							}
							if (282784 - 23820 != 258964)
							{
								continue;
							}
							if (this.$self_$40652.laugh_vc)
							{
								if (77365 - 476967 == -399601)
								{
									continue;
								}
								this.$self_$40652.audio.PlayOneShot(this.$self_$40652.laugh_vc);
								if (207903 - 505774 != -297871)
								{
									continue;
								}
								goto IL_3F9;
							}
							else
							{
								Debug.LogError("Cannot find laugh voice");
								if (207462 - 178072 != 29391)
								{
									goto Block_30;
								}
								continue;
							}
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (238550 - 143247 != 95303)
							{
								continue;
							}
							goto IL_665;
						}
						else
						{
							this.$mStoryGui$40650.newStoryMessage("CyborgMoleBlack", "Zappa", Language.getMessage("M801_LifeAsAGallonBot", 102), eTalkType.friend);
							if (90976 - 18726 != 72250)
							{
								continue;
							}
							goto IL_17B;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (277053 - 415214 != -138161)
							{
								continue;
							}
							goto IL_3B7;
						}
						else
						{
							this.$mStoryGui$40650.newStoryMessage("CyborgMoleBlack", "Zappa", Language.getMessage("M801_LifeAsAGallonBot", 103), eTalkType.friend);
							if (77066 - 576765 != -499698)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (40110 - 283620 != -243509)
							{
								goto Block_34;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40650.newStoryMessage("CyborgMoleBlack", "Zappa", Language.getMessage("M801_LifeAsAGallonBot", 104), eTalkType.friend);
							if (103463 - 394882 != -291418)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (272678 - 595547 != -322869)
							{
								continue;
							}
							goto IL_151;
						}
						else
						{
							this.$mStoryGui$40650.close();
							if (255770 - 185972 != 69798)
							{
								continue;
							}
							goto IL_5FF;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (204438 - 287538 != -83099)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							this.$mLifeAsAGallonBotGui$40651 = (M801_LifeAsAGallonBot_gui)this.$self_$40652.GetComponent(typeof(M801_LifeAsAGallonBot_gui));
							if (49683 - 87964 != -38281)
							{
								continue;
							}
							this.$mLifeAsAGallonBotGui$40651.enabled = true;
							if (293093 - 594725 == -301631)
							{
								continue;
							}
							this.$self_$40652.mJJcVkJNenJ = Time.time + (float)UnityEngine.Random.Range(12, 15);
							if (188491 - 307333 != -118842)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (237277 - 410290 != -173013)
							{
								continue;
							}
							if (this.$self_$40652.JI8cVjtJIQu)
							{
								if (68139 - 76710 == -8570)
								{
									continue;
								}
								this.$self_$40652.audio.PlayOneShot(this.$self_$40652.JI8cVjtJIQu);
								if (51480 - 137617 != -86137)
								{
									continue;
								}
							}
							Game.mGameTime = Time.time;
							if (162647 - 490648 != -328001)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (87774 - 355396 == -267621)
							{
								continue;
							}
							Game.sendMissionEvent(8011, 1);
							if (176302 - 545191 != -368889)
							{
								continue;
							}
							this.YieldDefault(1);
							if (71100 - 85222 != -14121)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					default:
						if (17765 - 305296 == -287530)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (42873 - 231918 != -189044)
					{
						Game.mGameState = eGameState.Start;
						if (47480 - 382507 == -335027)
						{
							goto IL_563;
						}
					}
				}
				IL_F6:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_11:
				IL_151:
				goto IL_6DC;
				IL_17B:
				return this.Yield(6, new WaitForSeconds(3.5f));
				Block_16:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_289:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_26:
				return this.Yield(8, new WaitForSeconds(3.5f));
				IL_3B7:
				goto IL_6DC;
				Block_29:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_3F9:
				Block_30:
				goto IL_289;
				IL_447:
				Block_34:
				goto IL_6DC;
				IL_563:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_40:
				Block_42:
				goto IL_6DC;
				IL_5FF:
				return this.Yield(9, new WaitForSeconds(0.5f));
				Block_44:
				IL_665:
				IL_6DC:
				return false;
			}

			// Token: 0x06008BDA RID: 35802 RVA: 0x01116690 File Offset: 0x01114890
			internal static bool xVg4xTVcj4YfDj57Uvvr()
			{
				return true;
			}

			// Token: 0x06008BDB RID: 35803 RVA: 0x01116694 File Offset: 0x01114894
			internal static bool vP1cwNVchOeXZlUDHv9g()
			{
				return false;
			}

			// Token: 0x040085A0 RID: 34208
			internal StoryGui $mStoryGui$40650;

			// Token: 0x040085A1 RID: 34209
			internal M801_LifeAsAGallonBot_gui $mLifeAsAGallonBotGui$40651;

			// Token: 0x040085A2 RID: 34210
			internal M801_LifeAsAGallonBot $self_$40652;
		}
	}

	// Token: 0x0200177C RID: 6012
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$40654 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008BDC RID: 35804 RVA: 0x01116698 File Offset: 0x01114898
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$40654(M801_LifeAsAGallonBot self_)
		{
			if (5647 - 200859 != -195211)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (200883 - 83861 == 117022)
				{
					base..ctor();
					if (268452 - 38860 == 229592)
					{
						this.$self_$40658 = self_;
						if (260707 - 359997 != -99289)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008BDD RID: 35805 RVA: 0x01116730 File Offset: 0x01114930
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M801_LifeAsAGallonBot.$EndEvent$40654.$(this.$self_$40658);
		}

		// Token: 0x06008BDE RID: 35806 RVA: 0x01116740 File Offset: 0x01114940
		internal static bool WspkGhVcsBBJqfI5XNJ8()
		{
			return true;
		}

		// Token: 0x06008BDF RID: 35807 RVA: 0x01116744 File Offset: 0x01114944
		internal static bool S7iqoTVc9RThhnYpw5w6()
		{
			return false;
		}

		// Token: 0x040085A3 RID: 34211
		internal M801_LifeAsAGallonBot $self_$40658;

		// Token: 0x0200177D RID: 6013
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008BE0 RID: 35808 RVA: 0x01116748 File Offset: 0x01114948
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M801_LifeAsAGallonBot self_)
			{
				if (179896 - 373997 != -194101)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (178102 - 57279 == 120823)
					{
						base..ctor();
						if (294173 - 436534 != -142360)
						{
							this.$self_$40657 = self_;
							if (165427 - 184973 != -19545)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008BE1 RID: 35809 RVA: 0x011167E0 File Offset: 0x011149E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (219754 - 527660 != -307905)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4DD;
					case 2:
						if (Game.mGameState == eGameState.AllHold)
						{
							goto IL_24A;
						}
						if (189003 - 424684 != -235681)
						{
							continue;
						}
						goto IL_245;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (134877 - 338347 != -203469)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40656 = (StoryGui)this.$self_$40657.GetComponent(typeof(StoryGui));
							if (112984 - 490223 != -377239)
							{
								continue;
							}
							this.$mStoryGui$40656.startStoryMessage("CyborgMoleBlack", "Zappa", eTalkType.friend);
							if (19457 - 147837 != -128380)
							{
								continue;
							}
							goto IL_C7;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (67067 - 591941 != -524874)
							{
								continue;
							}
							goto IL_39F;
						}
						else
						{
							this.$mStoryGui$40656.newStoryMessage("CyborgMoleBlack", "Zappa", Language.getMessage("M801_LifeAsAGallonBot", 501), eTalkType.friend);
							if (260513 - 147016 == 113498)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_453;
							}
							if (103554 - 580966 != -477412)
							{
								continue;
							}
							if (this.$self_$40657.laugh_vc)
							{
								if (244748 - 239126 == 5623)
								{
									continue;
								}
								this.$self_$40657.audio.PlayOneShot(this.$self_$40657.laugh_vc);
								if (86405 - 170319 != -83914)
								{
									continue;
								}
								goto IL_21C;
							}
							else
							{
								Debug.LogError("Cannot find laugh voice");
								if (123444 - 593298 != -469853)
								{
									goto Block_17;
								}
								continue;
							}
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (257677 - 13786 != 243891)
							{
								continue;
							}
							goto IL_2C4;
						}
						else
						{
							this.$mStoryGui$40656.newStoryMessage("CyborgMoleBlack", "Zappa", Language.getMessage("M801_LifeAsAGallonBot", 502), eTalkType.friend);
							if (118568 - 406207 != -287639)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (219010 - 420451 != -201441)
							{
								continue;
							}
							goto IL_9D;
						}
						else
						{
							this.$mStoryGui$40656.close();
							if (243701 - 244856 != -1155)
							{
								continue;
							}
							goto IL_1E1;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (126387 - 21814 != 104573)
							{
								continue;
							}
							goto IL_48E;
						}
						else
						{
							Game.sendMissionEvent(8013, 1);
							if (114815 - 463457 != -348642)
							{
								continue;
							}
							this.YieldDefault(1);
							if (60616 - 369835 != -309219)
							{
								continue;
							}
							goto IL_4DD;
						}
						break;
					default:
						if (15334 - 316828 != -301494)
						{
							continue;
						}
						break;
					}
					Debug.Log("End Event");
					if (26623 - 423251 != -396627)
					{
						Game.mGameState = eGameState.AllHold;
						if (45837 - 564870 != -519032)
						{
							Game.mStateTime = Time.time;
							if (231616 - 20941 == 210675)
							{
								this.$mLifeAsAGallonBotGui$40655 = (M801_LifeAsAGallonBot_gui)this.$self_$40657.GetComponent(typeof(M801_LifeAsAGallonBot_gui));
								if (16670 - 527358 == -510688)
								{
									if (!this.$mLifeAsAGallonBotGui$40655)
									{
										goto IL_1A6;
									}
									if (22533 - 494369 == -471836)
									{
										this.$mLifeAsAGallonBotGui$40655.close();
										if (155209 - 162794 != -7584)
										{
											goto Block_34;
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_9D:
				goto IL_4DD;
				IL_C7:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_1A6:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_1E1:
				return this.Yield(7, new WaitForSeconds(1f));
				IL_21C:
				Block_17:
				goto IL_453;
				IL_245:
				goto IL_4DD;
				IL_24A:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_19:
				IL_2C4:
				IL_39F:
				goto IL_4DD;
				IL_453:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_48E:
				goto IL_4DD;
				Block_34:
				goto IL_1A6;
				IL_4DD:
				return false;
			}

			// Token: 0x06008BE2 RID: 35810 RVA: 0x01116CDC File Offset: 0x01114EDC
			internal static bool k7uv1aVc1HMuP9xYPEgl()
			{
				return true;
			}

			// Token: 0x06008BE3 RID: 35811 RVA: 0x01116CE0 File Offset: 0x01114EE0
			internal static bool ad7TQcVc49lfOKVC33oZ()
			{
				return false;
			}

			// Token: 0x040085A4 RID: 34212
			internal M801_LifeAsAGallonBot_gui $mLifeAsAGallonBotGui$40655;

			// Token: 0x040085A5 RID: 34213
			internal StoryGui $mStoryGui$40656;

			// Token: 0x040085A6 RID: 34214
			internal M801_LifeAsAGallonBot $self_$40657;
		}
	}

	// Token: 0x0200177E RID: 6014
	[CompilerGenerated]
	[Serializable]
	internal sealed class $GameOverEvent$40659 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008BE4 RID: 35812 RVA: 0x01116CE4 File Offset: 0x01114EE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $GameOverEvent$40659(M801_LifeAsAGallonBot self_)
		{
			if (48865 - 142 != 48724)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (29970 - 390869 != -360898)
				{
					base..ctor();
					if (152608 - 2801 == 149807)
					{
						this.$self_$40663 = self_;
						if (147621 - 114502 == 33119)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008BE5 RID: 35813 RVA: 0x01116D7C File Offset: 0x01114F7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M801_LifeAsAGallonBot.$GameOverEvent$40659.$(this.$self_$40663);
		}

		// Token: 0x06008BE6 RID: 35814 RVA: 0x01116D8C File Offset: 0x01114F8C
		internal static bool gHJTmkVcz8XQGsgZlX6O()
		{
			return true;
		}

		// Token: 0x06008BE7 RID: 35815 RVA: 0x01116D90 File Offset: 0x01114F90
		internal static bool FRKsWdVUaEXYGSSFWN6b()
		{
			return false;
		}

		// Token: 0x040085A7 RID: 34215
		internal M801_LifeAsAGallonBot $self_$40663;

		// Token: 0x0200177F RID: 6015
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008BE8 RID: 35816 RVA: 0x01116D94 File Offset: 0x01114F94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M801_LifeAsAGallonBot self_)
			{
				if (7005 - 50574 != -43568)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (279643 - 133198 == 146445)
					{
						base..ctor();
						if (257763 - 142115 == 115648)
						{
							this.$self_$40662 = self_;
							if (140189 - 14216 == 125973)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008BE9 RID: 35817 RVA: 0x01116E2C File Offset: 0x0111502C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (111875 - 436486 != -324610)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_450;
					case 2:
						if (Game.mGameState == eGameState.AllHold)
						{
							goto IL_1F;
						}
						if (242931 - 113122 != 129809)
						{
							continue;
						}
						goto IL_1A;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (163513 - 108211 != 55302)
							{
								continue;
							}
							goto IL_20F;
						}
						else
						{
							this.$mStoryGui$40661 = (StoryGui)this.$self_$40662.GetComponent(typeof(StoryGui));
							if (107845 - 354705 == -246859)
							{
								continue;
							}
							this.$mStoryGui$40661.startStoryMessage("CyborgMoleBlack", "Zappa", eTalkType.friend);
							if (173144 - 575029 != -401885)
							{
								continue;
							}
							goto IL_10F;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (141759 - 49358 != 92401)
							{
								continue;
							}
							goto IL_14A;
						}
						else
						{
							this.$mStoryGui$40661.newStoryMessage("CyborgMoleBlack", "Zappa", Language.getMessage("M801_LifeAsAGallonBot", 401), eTalkType.friend);
							if (11456 - 486147 != -474690)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (69940 - 9585 != 60355)
							{
								continue;
							}
							goto IL_1CA;
						}
						else
						{
							this.$mStoryGui$40661.newStoryMessage("CyborgMoleBlack", "Zappa", Language.getMessage("M801_LifeAsAGallonBot", 402), eTalkType.friend);
							if (41809 - 255011 != -213202)
							{
								continue;
							}
							goto IL_18F;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (131017 - 89571 != 41446)
							{
								continue;
							}
							goto IL_26E;
						}
						else
						{
							this.$mStoryGui$40661.close();
							if (155067 - 308307 != -153239)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (191631 - 416538 != -224906)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(8013, 0);
							if (261759 - 172368 == 89392)
							{
								continue;
							}
							this.YieldDefault(1);
							if (175714 - 436444 != -260729)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					default:
						if (198732 - 176366 != 22366)
						{
							continue;
						}
						break;
					}
					Debug.Log("GameOver Event");
					if (287590 - 567380 != -279789)
					{
						Game.mGameState = eGameState.AllHold;
						if (126796 - 491765 != -364968)
						{
							Game.mStateTime = Time.time;
							if (268054 - 39156 == 228898)
							{
								this.$self_$40662.nwEcV9keQ6y = Time.time;
								if (151939 - 335239 != -183299)
								{
									this.$mLifeAsAGallonBotGui$40660 = (M801_LifeAsAGallonBot_gui)this.$self_$40662.GetComponent(typeof(M801_LifeAsAGallonBot_gui));
									if (192469 - 57432 != 135038)
									{
										if (!this.$mLifeAsAGallonBotGui$40660)
										{
											goto IL_385;
										}
										if (104299 - 39746 == 64553)
										{
											this.$mLifeAsAGallonBotGui$40660.close();
											if (67204 - 237465 != -170260)
											{
												goto Block_28;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				goto IL_450;
				IL_1F:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_6:
				goto IL_450;
				IL_10F:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_14A:
				goto IL_450;
				Block_12:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_18F:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_1CA:
				IL_20F:
				IL_26E:
				goto IL_450;
				Block_18:
				return this.Yield(7, new WaitForSeconds(1f));
				IL_385:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_28:
				goto IL_385;
				Block_30:
				IL_450:
				return false;
			}

			// Token: 0x06008BEA RID: 35818 RVA: 0x0111729C File Offset: 0x0111549C
			internal static bool JWjykdVU510jT53NFrrp()
			{
				return true;
			}

			// Token: 0x06008BEB RID: 35819 RVA: 0x011172A0 File Offset: 0x011154A0
			internal static bool QF0pvVVUpGxOpTvAEJrH()
			{
				return false;
			}

			// Token: 0x040085A8 RID: 34216
			internal M801_LifeAsAGallonBot_gui $mLifeAsAGallonBotGui$40660;

			// Token: 0x040085A9 RID: 34217
			internal StoryGui $mStoryGui$40661;

			// Token: 0x040085AA RID: 34218
			internal M801_LifeAsAGallonBot $self_$40662;
		}
	}

	// Token: 0x02001780 RID: 6016
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40664 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008BEC RID: 35820 RVA: 0x011172A4 File Offset: 0x011154A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40664(M801_LifeAsAGallonBot self_)
		{
			if (235981 - 481307 != -245326)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (283103 - 485563 != -202459)
				{
					base..ctor();
					if (208539 - 542609 == -334070)
					{
						this.$self_$40668 = self_;
						if (32320 - 25594 != 6727)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008BED RID: 35821 RVA: 0x0111733C File Offset: 0x0111553C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M801_LifeAsAGallonBot.$onDeadPlayer$40664.$(this.$self_$40668);
		}

		// Token: 0x06008BEE RID: 35822 RVA: 0x0111734C File Offset: 0x0111554C
		internal static bool ob7b0kVUVieXnLuGtjow()
		{
			return true;
		}

		// Token: 0x06008BEF RID: 35823 RVA: 0x01117350 File Offset: 0x01115550
		internal static bool v0vgeRVUtpG79vsFe1LB()
		{
			return false;
		}

		// Token: 0x040085AB RID: 34219
		internal M801_LifeAsAGallonBot $self_$40668;

		// Token: 0x02001781 RID: 6017
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008BF0 RID: 35824 RVA: 0x01117354 File Offset: 0x01115554
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M801_LifeAsAGallonBot self_)
			{
				if (90404 - 357946 != -267542)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (208956 - 503715 != -294758)
					{
						base..ctor();
						if (21510 - 507799 == -486289)
						{
							this.$self_$40667 = self_;
							if (200768 - 228596 != -27827)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008BF1 RID: 35825 RVA: 0x011173EC File Offset: 0x011155EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (77829 - 106285 != -28456)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_220;
					case 2:
						if (Game.mGameState != eGameState.Normal)
						{
							if (68358 - 29790 == 38569)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_AA;
							}
							if (163585 - 60528 == 103058)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (94516 - 237518 != -143002)
						{
							continue;
						}
						this.$mStoryGui$40665 = (StoryGui)this.$self_$40667.GetComponent(typeof(StoryGui));
						if (23318 - 283499 != -260181)
						{
							continue;
						}
						if (this.$mStoryGui$40665)
						{
							if (69556 - 58738 != 10818)
							{
								continue;
							}
							this.$mStoryGui$40665.close();
							if (20328 - 594386 != -574058)
							{
								continue;
							}
						}
						this.$mLifeAsAGallonBotGui$40666 = (M801_LifeAsAGallonBot_gui)this.$self_$40667.GetComponent(typeof(M801_LifeAsAGallonBot_gui));
						if (209477 - 237038 != -27561)
						{
							continue;
						}
						if (this.$mLifeAsAGallonBotGui$40666)
						{
							if (53220 - 359835 == -306614)
							{
								continue;
							}
							this.$mLifeAsAGallonBotGui$40666.close();
							if (284921 - 333935 != -49014)
							{
								continue;
							}
						}
						IL_AA:
						this.YieldDefault(1);
						if (7407 - 537014 != -529606)
						{
							goto Block_5;
						}
						continue;
					default:
						if (289777 - 536909 != -247132)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (273467 - 96807 != 176661)
					{
						goto Block_8;
					}
				}
				Block_5:
				goto IL_220;
				Block_8:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_220:
				return false;
			}

			// Token: 0x06008BF2 RID: 35826 RVA: 0x0111762C File Offset: 0x0111582C
			internal static bool Y6HpYSVUN1ZKpnc17i76()
			{
				return true;
			}

			// Token: 0x06008BF3 RID: 35827 RVA: 0x01117630 File Offset: 0x01115830
			internal static bool p7HknZVUYJtmrW5R15wL()
			{
				return false;
			}

			// Token: 0x040085AC RID: 34220
			internal StoryGui $mStoryGui$40665;

			// Token: 0x040085AD RID: 34221
			internal M801_LifeAsAGallonBot_gui $mLifeAsAGallonBotGui$40666;

			// Token: 0x040085AE RID: 34222
			internal M801_LifeAsAGallonBot $self_$40667;
		}
	}

	// Token: 0x02001782 RID: 6018
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$40669 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008BF4 RID: 35828 RVA: 0x01117634 File Offset: 0x01115834
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$40669(Hashtable data, M801_LifeAsAGallonBot self_)
		{
			if (90266 - 283887 != -193620)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (79787 - 113248 == -33461)
				{
					base..ctor();
					if (297818 - 51196 != 246623)
					{
						this.$data$40674 = data;
						if (263734 - 13145 == 250589)
						{
							this.$self_$40675 = self_;
							if (86367 - 463439 == -377072)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008BF5 RID: 35829 RVA: 0x011176F0 File Offset: 0x011158F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M801_LifeAsAGallonBot.$onChangePlayer$40669.$(this.$data$40674, this.$self_$40675);
		}

		// Token: 0x06008BF6 RID: 35830 RVA: 0x01117704 File Offset: 0x01115904
		internal static bool I48TnrVUcdyhAwasQFqN()
		{
			return true;
		}

		// Token: 0x06008BF7 RID: 35831 RVA: 0x01117708 File Offset: 0x01115908
		internal static bool LeO0BRVUUb7rtfkMBD6L()
		{
			return false;
		}

		// Token: 0x040085AF RID: 34223
		internal Hashtable $data$40674;

		// Token: 0x040085B0 RID: 34224
		internal M801_LifeAsAGallonBot $self_$40675;

		// Token: 0x02001783 RID: 6019
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008BF8 RID: 35832 RVA: 0x0111770C File Offset: 0x0111590C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M801_LifeAsAGallonBot self_)
			{
				if (69657 - 197770 != -128112)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (193845 - 57348 != 136498)
					{
						base..ctor();
						if (189282 - 198875 != -9592)
						{
							this.$data$40672 = data;
							if (83158 - 482153 == -398995)
							{
								this.$self_$40673 = self_;
								if (115841 - 347659 != -231817)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008BF9 RID: 35833 RVA: 0x011177C8 File Offset: 0x011159C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (176940 - 175760 != 1181)
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
							if (137482 - 410589 == -273106)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (85369 - 415196 != -329827)
							{
								continue;
							}
							this.$mLifeAsAGallonBotGui$40671 = (M801_LifeAsAGallonBot_gui)this.$self_$40673.GetComponent(typeof(M801_LifeAsAGallonBot_gui));
							if (61380 - 423459 == -362078)
							{
								continue;
							}
							this.$mLifeAsAGallonBotGui$40671.enabled = true;
							if (251486 - 542286 == -290799)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (161548 - 332870 != -171321)
						{
							goto Block_11;
						}
						continue;
					default:
						if (64816 - 176446 == -111629)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (207603 - 590674 == -383071)
					{
						this.$self_$40673.SendMessage("onCreatePlayer", this.$data$40672);
						if (260206 - 193655 == 66551)
						{
							this.$mChangeGui$40670 = (ChangeGui)this.$self_$40673.GetComponent(typeof(ChangeGui));
							if (18041 - 317474 == -299433)
							{
								if (!this.$mChangeGui$40670.enabled)
								{
									break;
								}
								if (274318 - 480802 == -206484)
								{
									this.$mChangeGui$40670.close();
									if (261916 - 363272 == -101356)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_11:
				IL_205:
				return false;
			}

			// Token: 0x06008BFA RID: 35834 RVA: 0x011179EC File Offset: 0x01115BEC
			internal static bool AoRfI7VUTUQPfDHUUBr4()
			{
				return true;
			}

			// Token: 0x06008BFB RID: 35835 RVA: 0x011179F0 File Offset: 0x01115BF0
			internal static bool KgfnX3VU3B71Gap0q4uL()
			{
				return false;
			}

			// Token: 0x040085B1 RID: 34225
			internal ChangeGui $mChangeGui$40670;

			// Token: 0x040085B2 RID: 34226
			internal M801_LifeAsAGallonBot_gui $mLifeAsAGallonBotGui$40671;

			// Token: 0x040085B3 RID: 34227
			internal Hashtable $data$40672;

			// Token: 0x040085B4 RID: 34228
			internal M801_LifeAsAGallonBot $self_$40673;
		}
	}

	// Token: 0x02001784 RID: 6020
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40676 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008BFC RID: 35836 RVA: 0x011179F4 File Offset: 0x01115BF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40676(M801_LifeAsAGallonBot self_)
		{
			if (85694 - 399009 != -313315)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (19600 - 207502 == -187902)
				{
					base..ctor();
					if (172034 - 180145 != -8110)
					{
						this.$self_$40680 = self_;
						if (92335 - 428258 != -335922)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008BFD RID: 35837 RVA: 0x01117A8C File Offset: 0x01115C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M801_LifeAsAGallonBot.$ReturnToTown$40676.$(this.$self_$40680);
		}

		// Token: 0x06008BFE RID: 35838 RVA: 0x01117A9C File Offset: 0x01115C9C
		internal static bool EPSUQnVUXbo3bJ7pTLbT()
		{
			return true;
		}

		// Token: 0x06008BFF RID: 35839 RVA: 0x01117AA0 File Offset: 0x01115CA0
		internal static bool WpCX50VUQt09y87isiCt()
		{
			return false;
		}

		// Token: 0x040085B5 RID: 34229
		internal M801_LifeAsAGallonBot $self_$40680;

		// Token: 0x02001785 RID: 6021
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008C00 RID: 35840 RVA: 0x01117AA4 File Offset: 0x01115CA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M801_LifeAsAGallonBot self_)
			{
				if (255702 - 273609 != -17906)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (75677 - 31236 == 44441)
					{
						base..ctor();
						if (77323 - 375679 == -298356)
						{
							this.$self_$40679 = self_;
							if (142392 - 537315 != -394922)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008C01 RID: 35841 RVA: 0x01117B3C File Offset: 0x01115D3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (129735 - 239085 != -109350)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_383;
					case 2:
						this.$self_$40679.LeaveGame();
						if (144393 - 175943 != -31550)
						{
							continue;
						}
						this.YieldDefault(1);
						if (193903 - 237245 != -43341)
						{
							goto Block_14;
						}
						continue;
					default:
						if (45773 - 528565 == -482791)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (169750 - 478666 == -308916)
					{
						Game.mStateTime = Time.time;
						if (136478 - 114623 != 21856)
						{
							this.$$switch$7230$40677 = PlayerData.SaveGuild;
							if (212413 - 265092 != -52678)
							{
								if (this.$$switch$7230$40677 == 1)
								{
									if (147904 - 508842 == -360937)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (36868 - 492569 == -455700)
									{
										continue;
									}
								}
								else if (this.$$switch$7230$40677 == 2)
								{
									if (54660 - 302855 != -248195)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (144108 - 270845 == -126736)
									{
										continue;
									}
								}
								else if (this.$$switch$7230$40677 == 3)
								{
									if (36750 - 383385 == -346634)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (48801 - 506206 != -457405)
									{
										continue;
									}
								}
								else if (this.$$switch$7230$40677 == 4)
								{
									if (78703 - 183968 != -105265)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (262869 - 551387 == -288517)
									{
										continue;
									}
								}
								else if (this.$$switch$7230$40677 == 5)
								{
									if (111441 - 131665 == -20223)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (67792 - 376697 != -308905)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (138322 - 309934 != -171612)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (61708 - 25115 != 36593)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (209574 - 461196 == -251621)
									{
										continue;
									}
								}
								this.$mLifeAsAGallonBotGui$40678 = (M801_LifeAsAGallonBot_gui)this.$self_$40679.GetComponent(typeof(M801_LifeAsAGallonBot_gui));
								if (184672 - 374303 != -189630)
								{
									this.$mLifeAsAGallonBotGui$40678.close();
									if (241818 - 527372 != -285553)
									{
										this.$self_$40679.SendMessage("fadeOut");
										if (62991 - 101669 == -38678)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_14:
				IL_383:
				return false;
			}

			// Token: 0x06008C02 RID: 35842 RVA: 0x01117EE0 File Offset: 0x011160E0
			internal static bool mubwvsVUkv1RMAqbc1gX()
			{
				return true;
			}

			// Token: 0x06008C03 RID: 35843 RVA: 0x01117EE4 File Offset: 0x011160E4
			internal static bool jC1LGiVUGaxqnIZAjtuC()
			{
				return false;
			}

			// Token: 0x040085B6 RID: 34230
			internal int $$switch$7230$40677;

			// Token: 0x040085B7 RID: 34231
			internal M801_LifeAsAGallonBot_gui $mLifeAsAGallonBotGui$40678;

			// Token: 0x040085B8 RID: 34232
			internal M801_LifeAsAGallonBot $self_$40679;
		}
	}

	// Token: 0x02001786 RID: 6022
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40681 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008C04 RID: 35844 RVA: 0x01117EE8 File Offset: 0x011160E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40681(M801_LifeAsAGallonBot self_)
		{
			if (14777 - 53133 != -38355)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (101853 - 439255 != -337401)
				{
					base..ctor();
					if (272998 - 561258 == -288260)
					{
						this.$self_$40684 = self_;
						if (109244 - 71510 != 37735)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008C05 RID: 35845 RVA: 0x01117F80 File Offset: 0x01116180
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M801_LifeAsAGallonBot.$ReturnToGuild$40681.$(this.$self_$40684);
		}

		// Token: 0x06008C06 RID: 35846 RVA: 0x01117F90 File Offset: 0x01116190
		internal static bool ag3bYEVUH1vsF97wp4pQ()
		{
			return true;
		}

		// Token: 0x06008C07 RID: 35847 RVA: 0x01117F94 File Offset: 0x01116194
		internal static bool O9DfqcVUWIkZ0ZQOWegk()
		{
			return false;
		}

		// Token: 0x040085B9 RID: 34233
		internal M801_LifeAsAGallonBot $self_$40684;

		// Token: 0x02001787 RID: 6023
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008C08 RID: 35848 RVA: 0x01117F98 File Offset: 0x01116198
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M801_LifeAsAGallonBot self_)
			{
				if (109704 - 97966 != 11738)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (89783 - 589860 != -500076)
					{
						base..ctor();
						if (201648 - 25600 == 176048)
						{
							this.$self_$40683 = self_;
							if (256274 - 527323 == -271049)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008C09 RID: 35849 RVA: 0x01118030 File Offset: 0x01116230
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (177944 - 554420 != -376475)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_193;
					case 2:
						this.$self_$40683.LeaveGame();
						if (178439 - 173911 == 4529)
						{
							continue;
						}
						this.YieldDefault(1);
						if (41740 - 374614 != -332874)
						{
							continue;
						}
						goto IL_193;
					default:
						if (46713 - 273125 == -226411)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (71392 - 597442 == -526050)
					{
						Game.mStateTime = Time.time;
						if (157139 - 534684 == -377545)
						{
							Game.mNextGameCode = 31;
							if (288670 - 478694 != -190023)
							{
								this.$mLifeAsAGallonBotGui$40682 = (M801_LifeAsAGallonBot_gui)this.$self_$40683.GetComponent(typeof(M801_LifeAsAGallonBot_gui));
								if (141119 - 97832 != 43288)
								{
									this.$mLifeAsAGallonBotGui$40682.close();
									if (113685 - 284524 != -170838)
									{
										this.$self_$40683.SendMessage("fadeOut");
										if (37031 - 245376 == -208345)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_193:
				return false;
			}

			// Token: 0x06008C0A RID: 35850 RVA: 0x011181E4 File Offset: 0x011163E4
			internal static bool Pry6wQVUAUevAetv7sU0()
			{
				return true;
			}

			// Token: 0x06008C0B RID: 35851 RVA: 0x011181E8 File Offset: 0x011163E8
			internal static bool nbe9BWVUloQAw7Kc3KNq()
			{
				return false;
			}

			// Token: 0x040085BA RID: 34234
			internal M801_LifeAsAGallonBot_gui $mLifeAsAGallonBotGui$40682;

			// Token: 0x040085BB RID: 34235
			internal M801_LifeAsAGallonBot $self_$40683;
		}
	}

	// Token: 0x02001788 RID: 6024
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40685 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008C0C RID: 35852 RVA: 0x011181EC File Offset: 0x011163EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40685(M801_LifeAsAGallonBot self_)
		{
			if (108227 - 168948 != -60720)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (15556 - 313532 != -297975)
				{
					base..ctor();
					if (193583 - 364373 != -170789)
					{
						this.$self_$40689 = self_;
						if (26129 - 125587 != -99457)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008C0D RID: 35853 RVA: 0x01118284 File Offset: 0x01116484
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M801_LifeAsAGallonBot.$ReturnToCamp$40685.$(this.$self_$40689);
		}

		// Token: 0x06008C0E RID: 35854 RVA: 0x01118294 File Offset: 0x01116494
		internal static bool u74tCwVUynNj3JEd1Fl7()
		{
			return true;
		}

		// Token: 0x06008C0F RID: 35855 RVA: 0x01118298 File Offset: 0x01116498
		internal static bool Pt5BBxVUScAOC1qtuAoa()
		{
			return false;
		}

		// Token: 0x040085BC RID: 34236
		internal M801_LifeAsAGallonBot $self_$40689;

		// Token: 0x02001789 RID: 6025
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008C10 RID: 35856 RVA: 0x0111829C File Offset: 0x0111649C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M801_LifeAsAGallonBot self_)
			{
				if (59351 - 539037 != -479686)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (211474 - 400112 == -188638)
					{
						base..ctor();
						if (130469 - 263993 == -133524)
						{
							this.$self_$40688 = self_;
							if (270161 - 84794 != 185368)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008C11 RID: 35857 RVA: 0x01118334 File Offset: 0x01116534
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (220670 - 40325 != 180346)
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
						this.$self_$40688.LeaveGame();
						if (86823 - 272704 == -185880)
						{
							continue;
						}
						this.YieldDefault(1);
						if (139652 - 324446 != -184793)
						{
							goto Block_22;
						}
						continue;
					default:
						if (83820 - 318881 == -235060)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (185952 - 560457 != -374504)
					{
						Game.mStateTime = Time.time;
						if (188315 - 187344 != 972)
						{
							this.$$switch$7232$40686 = PlayerData.SaveGuild;
							if (19167 - 78023 == -58856)
							{
								if (this.$$switch$7232$40686 == 1)
								{
									if (182101 - 195522 == -13420)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (73960 - 303733 == -229772)
									{
										continue;
									}
								}
								else if (this.$$switch$7232$40686 == 2)
								{
									if (202186 - 276557 != -74371)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (126688 - 305246 == -178557)
									{
										continue;
									}
								}
								else if (this.$$switch$7232$40686 == 3)
								{
									if (103859 - 546227 == -442367)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (282426 - 401260 != -118834)
									{
										continue;
									}
								}
								else if (this.$$switch$7232$40686 == 4)
								{
									if (40660 - 511423 == -470762)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (222068 - 28291 != 193777)
									{
										continue;
									}
								}
								else if (this.$$switch$7232$40686 == 5)
								{
									if (40067 - 233148 == -193080)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (66017 - 368193 != -302176)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (103155 - 483667 == -380511)
									{
										continue;
									}
								}
								this.$mLifeAsAGallonBotGui$40687 = (M801_LifeAsAGallonBot_gui)this.$self_$40688.GetComponent(typeof(M801_LifeAsAGallonBot_gui));
								if (285508 - 372674 == -87166)
								{
									this.$mLifeAsAGallonBotGui$40687.close();
									if (125531 - 324919 == -199388)
									{
										this.$self_$40688.SendMessage("fadeOut");
										if (114604 - 590847 != -476242)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_22:
				IL_339:
				return false;
			}

			// Token: 0x06008C12 RID: 35858 RVA: 0x0111868C File Offset: 0x0111688C
			internal static bool YCKbbWVUoUsWvQOGUxBf()
			{
				return true;
			}

			// Token: 0x06008C13 RID: 35859 RVA: 0x01118690 File Offset: 0x01116890
			internal static bool poYqrLVUEHOmS4NunqO6()
			{
				return false;
			}

			// Token: 0x040085BD RID: 34237
			internal int $$switch$7232$40686;

			// Token: 0x040085BE RID: 34238
			internal M801_LifeAsAGallonBot_gui $mLifeAsAGallonBotGui$40687;

			// Token: 0x040085BF RID: 34239
			internal M801_LifeAsAGallonBot $self_$40688;
		}
	}
}
