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

// Token: 0x0200197E RID: 6526
[Serializable]
public class M917_WarRepose2 : MonoBehaviour
{
	// Token: 0x060097F7 RID: 38903 RVA: 0x011E2824 File Offset: 0x011E0A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M917_WarRepose2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060097F8 RID: 38904 RVA: 0x011E2834 File Offset: 0x011E0A34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (155813 - 523350 != -367536)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (144345 - 191803 == -47458)
			{
				Game.mGameType = 4;
				if (167625 - 341309 == -173684)
				{
					if (Chat.Initialized)
					{
						if (213516 - 251678 == -38161)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (103929 - 274911 != -170982)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (239673 - 551410 == -311736)
						{
							continue;
						}
					}
					this.wx2nQQipUJZ = (Texture)Resources.Load("GameGui/Title/chapterComplete", typeof(Texture));
					if (120079 - 317732 == -197653)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060097F9 RID: 38905 RVA: 0x011E2954 File Offset: 0x011E0B54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (293902 - 588319 != -294417)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (248707 - 264858 == -16151)
				{
					Game.nextGame();
					if (251873 - 513227 == -261354)
					{
						Game.mGameCode = 917;
						if (141055 - 512777 == -371722)
						{
							Game.mGameType = 4;
							if (169911 - 59230 == 110681)
							{
								Game.mGameTime = Time.time;
								if (229358 - 444069 == -214711)
								{
									Game.mGameScore = 0;
									if (251097 - 500061 == -248964)
									{
										Game.mGameMana = 0;
										if (181125 - 234492 == -53367)
										{
											this.CucnQc18IGX = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
											if (160274 - 262418 != -102143)
											{
												this.CucnQc18IGX.enabled = false;
												if (218999 - 40872 != 178128)
												{
													this.jE8nQ5xynuh = PhotonClient.Connection;
													if (262535 - 194443 == 68092)
													{
														PhotonClient.ActorNrList.Clear();
														if (162498 - 197327 == -34829)
														{
															this.InitGame();
															if (142442 - 379637 == -237195)
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
			else
			{
				Debug.Log("Not Connected");
				if (4500 - 45741 != -41240)
				{
					Game.mGameType = 99;
					if (152267 - 136830 != 15438)
					{
						this.CucnQc18IGX = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
						if (129659 - 351014 != -221354)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060097FA RID: 38906 RVA: 0x011E2BBC File Offset: 0x011E0DBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (284466 - 160704 != 123762)
		{
		}
		for (;;)
		{
			if (this.jE8nQ5xynuh == null)
			{
				if (299844 - 581352 != -281507)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (18368 - 861 != 17508)
				{
					if (mGameState == eGameState.Init)
					{
						if (97091 - 133177 == -36086)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (220703 - 77324 == 143379)
							{
								break;
							}
						}
					}
					else
					{
						if (mGameState != eGameState.Setup)
						{
							if (mGameState == eGameState.Ready)
							{
								if (51977 - 145999 == -94021)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.Start)
							{
								if (20087 - 546052 != -525965)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.Normal)
							{
								if (132024 - 151077 != -19053)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.Hold)
							{
								if (181528 - 379934 == -198405)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.AllHold)
							{
								if (57249 - 254314 != -197065)
								{
									continue;
								}
								break;
							}
							else if (mGameState == eGameState.Complete)
							{
								if (117172 - 302041 != -184869)
								{
									continue;
								}
								break;
							}
							else
							{
								if (mGameState != eGameState.Ended)
								{
									break;
								}
								if (105656 - 521078 != -415422)
								{
									continue;
								}
								break;
							}
							IL_71:
							if (Game.music != 0)
							{
								if (114285 - 451620 == -337334)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (25256 - 163828 != -138572)
									{
										continue;
									}
									this.audio.Play();
									if (126637 - 45748 == 80890)
									{
										continue;
									}
								}
							}
							if (this.audio.volume < 0.1f * (float)Game.music)
							{
								if (94088 - 447693 == -353604)
								{
									continue;
								}
								this.audio.volume = this.audio.volume + Time.deltaTime;
								if (211263 - 400990 != -189727)
								{
									continue;
								}
								break;
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (9423 - 317712 != -308288)
								{
									break;
								}
								continue;
							}
							IL_252:
							goto IL_71;
							goto IL_252;
						}
						if (292517 - 560864 == -268347)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060097FB RID: 38907 RVA: 0x011E2EDC File Offset: 0x011E10DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (134288 - 356468 != -222180)
		{
		}
		for (;;)
		{
			eGameState mGameState = Game.mGameState;
			if (182567 - 204486 == -21919)
			{
				if (mGameState != eGameState.Complete)
				{
					break;
				}
				if (122102 - 376305 != -254202)
				{
					if (!this.wx2nQQipUJZ)
					{
						break;
					}
					if (53858 - 471250 != -417391)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (282331 - 264549 != 17783)
						{
							int num = 1024 * Screen.width / Screen.height;
							if (162010 - 63216 != 98795)
							{
								float num2 = (float)Screen.height / 1024f;
								if (122584 - 67384 == 55200)
								{
									GUI.depth = 1;
									if (270660 - 205819 == 64841)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, (float)2 * (Time.time - this.T5tnQIkPvoH));
										if (63699 - 236196 != -172496)
										{
											Color color = GUI.color;
											if (284468 - 74999 == 209469)
											{
												float num3 = color.a = a;
												if (265209 - 547109 != -281899 && 88687 - 505335 != -416647)
												{
													Color color2 = GUI.color = color;
													if (106127 - 299632 != -193504 && 85101 - 255986 != -170884)
													{
														float num4 = Mathf.SmoothStep(1.5f, (float)1, Time.time - this.T5tnQIkPvoH);
														if (174528 - 95269 == 79259)
														{
															GUI.DrawTexture(new Rect(0.5f * (float)num - 0.5f * (float)this.wx2nQQipUJZ.width * num4, (float)530 - 0.5f * (float)this.wx2nQQipUJZ.height * num4, (float)this.wx2nQQipUJZ.width * num4, (float)this.wx2nQQipUJZ.height * num4), this.wx2nQQipUJZ);
															if (138382 - 341161 == -202779)
															{
																int num5 = 1;
																if (61332 - 569594 == -508262)
																{
																	Color color3 = GUI.color;
																	if (34029 - 359678 != -325648)
																	{
																		color3.a = (float)num5;
																		if (198608 - 589437 != -390828 && 136252 - 25960 == 110292)
																		{
																			GUI.color = color3;
																			if (38625 - 271073 != -232447)
																			{
																				if (27053 - 356348 == -329295)
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

	// Token: 0x060097FC RID: 38908 RVA: 0x011E329C File Offset: 0x011E149C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (227056 - 21385 != 205672)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (45895 - 562382 != -516486)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (217193 - 490987 != -273793)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (30109 - 47347 == -17238)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (11882 - 360152 != -348269)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060097FD RID: 38909 RVA: 0x011E338C File Offset: 0x011E158C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M917_WarRepose2.$StartEvent$42338(this).GetEnumerator();
	}

	// Token: 0x060097FE RID: 38910 RVA: 0x011E339C File Offset: 0x011E159C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M917_WarRepose2.$onGameComplete$42346(data, this).GetEnumerator();
	}

	// Token: 0x060097FF RID: 38911 RVA: 0x011E33AC File Offset: 0x011E15AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void talkToNewNPC()
	{
		if (285096 - 483662 != -198565)
		{
		}
		for (;;)
		{
			this.JJ5nQJ87WKT = Mathf.Clamp(this.JJ5nQJ87WKT + 1, 0, 10);
			if (28281 - 397215 == -368934)
			{
				this.SendMessage("newGameMessage", "Mission Objective: Talk To NPC:" + this.JJ5nQJ87WKT + "/10");
				if (246921 - 515279 == -268358)
				{
					Chat.SubmitChat("none", "Talk To NPC:" + this.JJ5nQJ87WKT + "/10", eChatType.system, eChatMode.system);
					if (274141 - 366856 == -92715)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009800 RID: 38912 RVA: 0x011E34A0 File Offset: 0x011E16A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToBoldas()
	{
		return new M917_WarRepose2.$TalkToBoldas$42351(this).GetEnumerator();
	}

	// Token: 0x06009801 RID: 38913 RVA: 0x011E34B0 File Offset: 0x011E16B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToFalcon()
	{
		return new M917_WarRepose2.$TalkToFalcon$42359(this).GetEnumerator();
	}

	// Token: 0x06009802 RID: 38914 RVA: 0x011E34C0 File Offset: 0x011E16C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToFireGod()
	{
		return new M917_WarRepose2.$TalkToFireGod$42369(this).GetEnumerator();
	}

	// Token: 0x06009803 RID: 38915 RVA: 0x011E34D0 File Offset: 0x011E16D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWaterGod()
	{
		return new M917_WarRepose2.$TalkToWaterGod$42377(this).GetEnumerator();
	}

	// Token: 0x06009804 RID: 38916 RVA: 0x011E34E0 File Offset: 0x011E16E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToOwl2()
	{
		return new M917_WarRepose2.$TalkToOwl2$42385(this).GetEnumerator();
	}

	// Token: 0x06009805 RID: 38917 RVA: 0x011E34F0 File Offset: 0x011E16F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new M917_WarRepose2.$TalkToRedPanda$42393(this).GetEnumerator();
	}

	// Token: 0x06009806 RID: 38918 RVA: 0x011E3500 File Offset: 0x011E1700
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMouse()
	{
		return new M917_WarRepose2.$TalkToMouse$42401(this).GetEnumerator();
	}

	// Token: 0x06009807 RID: 38919 RVA: 0x011E3510 File Offset: 0x011E1710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWarthog()
	{
		return new M917_WarRepose2.$TalkToWarthog$42409(this).GetEnumerator();
	}

	// Token: 0x06009808 RID: 38920 RVA: 0x011E3520 File Offset: 0x011E1720
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToHumpback()
	{
		return new M917_WarRepose2.$TalkToHumpback$42417(this).GetEnumerator();
	}

	// Token: 0x06009809 RID: 38921 RVA: 0x011E3530 File Offset: 0x011E1730
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLeopard(int nLeopard)
	{
		return new M917_WarRepose2.$TalkToLeopard$42425(nLeopard, this).GetEnumerator();
	}

	// Token: 0x0600980A RID: 38922 RVA: 0x011E3540 File Offset: 0x011E1740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther(int nPanther)
	{
		return new M917_WarRepose2.$TalkToPanther$42433(nPanther, this).GetEnumerator();
	}

	// Token: 0x0600980B RID: 38923 RVA: 0x011E3550 File Offset: 0x011E1750
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (73508 - 334562 != -261054)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (223765 - 188670 != 35096)
			{
				Hashtable customOpParameters = new Hashtable();
				if (151044 - 404165 != -253120)
				{
					this.jE8nQ5xynuh.OpCustom(52, customOpParameters, true);
					if (76907 - 525244 != -448336)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600980C RID: 38924 RVA: 0x011E35F8 File Offset: 0x011E17F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (34 - 558907 != -558873)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (43548 - 58649 == -15101)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (172251 - 596176 != -423924)
				{
					Game.mGameState = eGameState.Setup;
					if (187665 - 499096 == -311431)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600980D RID: 38925 RVA: 0x011E369C File Offset: 0x011E189C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (33894 - 166432 != -132538)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (127366 - 44635 == 82731)
			{
				if (num == PlayerData.UID)
				{
					if (228078 - 496505 != -268426)
					{
						this.SetupActors();
						if (164390 - 176823 == -12433)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (4594 - 421340 != -416745)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600980E RID: 38926 RVA: 0x011E376C File Offset: 0x011E196C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (287437 - 539118 != -251680)
		{
		}
		for (;;)
		{
			IL_15D:
			Debug.Log("Creating Actors");
			if (8410 - 483030 == -474620)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (24272 - 286019 != -261746)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (150546 - 91640 != 58907)
						{
							int i = 0;
							if (184529 - 392282 != -207752)
							{
								CharacterControl[] array2 = array;
								if (185292 - 440392 != -255099)
								{
									int length = array2.Length;
									if (100810 - 88621 == 12189)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (63866 - 195510 != -131644)
											{
												goto IL_15D;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (200193 - 231562 == -31368)
											{
												goto IL_15D;
											}
											this.VgKnQxVlXcx++;
											if (49262 - 97463 == -48200)
											{
												goto IL_15D;
											}
											i++;
											if (147352 - 64966 == 82387)
											{
												goto IL_15D;
											}
										}
										if (123034 - 585268 == -462234)
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
						if (7700 - 316456 != -308755)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600980F RID: 38927 RVA: 0x011E3984 File Offset: 0x011E1B84
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (54942 - 277947 != -223005)
		{
		}
		for (;;)
		{
			IL_84:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (229594 - 598894 != -369299)
			{
				int i = 0;
				if (293689 - 243105 != 50585)
				{
					CharacterControl[] array2 = array;
					if (181301 - 331608 == -150307)
					{
						int length = array2.Length;
						if (149638 - 199314 != -49675)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (78416 - 423606 == -345189)
								{
									goto IL_84;
								}
								i++;
								if (162168 - 362765 != -200597)
								{
									goto IL_84;
								}
							}
							if (240580 - 201145 == 39435)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009810 RID: 38928 RVA: 0x011E3AB4 File Offset: 0x011E1CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (76910 - 445099 != -368188)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (285423 - 431844 == -146421)
			{
				Game.mGameState = eGameState.Ready;
				if (130996 - 529580 != -398583)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (248998 - 598444 != -349445)
					{
						if (249678 - 499699 == -250021)
						{
							GameObject gameObject = null;
							if (107395 - 577597 == -470202)
							{
								if (playerSlot <= 1)
								{
									goto IL_22C;
								}
								if (89712 - 117068 != -27356)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_22C;
								}
								if (181311 - 389424 == -208112)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (240925 - 355909 == -114983)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (160268 - 568978 == -408709)
								{
									continue;
								}
								IL_202:
								if (gameObject2)
								{
									if (131634 - 483698 != -352064)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (229435 - 45051 == 184385)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (68718 - 416354 != -347636)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (268412 - 453269 == -184856)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (173739 - 104683 != 69057)
								{
									break;
								}
								continue;
								IL_22C:
								gameObject2 = GameObject.Find("StartPoint1");
								if (160725 - 57344 == 103381)
								{
									goto IL_202;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009811 RID: 38929 RVA: 0x011E3D44 File Offset: 0x011E1F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		Debug.Log("Start Game");
		this.StartCoroutine_Auto(this.StartEvent());
	}

	// Token: 0x06009812 RID: 38930 RVA: 0x011E3D60 File Offset: 0x011E1F60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009813 RID: 38931 RVA: 0x011E3D64 File Offset: 0x011E1F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (297958 - 319604 != -21645)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (180676 - 274664 != -93987)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (244033 - 76807 != 167227)
				{
					hashtable.Add(43, PlayerData.UID);
					if (148783 - 154474 == -5691)
					{
						hashtable.Add(73, nType);
						if (3503 - 482187 != -478683)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (179174 - 263370 == -84196)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (180781 - 96627 != 84155)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (189188 - 57662 == 131526)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (107420 - 291483 == -184063)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (179448 - 338162 == -158714)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (257785 - 177928 != 79858)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (73482 - 124894 == -51412)
													{
														this.jE8nQ5xynuh.OpCustom(63, hashtable, true);
														if (267605 - 285559 != -17953)
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

	// Token: 0x06009814 RID: 38932 RVA: 0x011E4048 File Offset: 0x011E2248
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (255318 - 313430 != -58112)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (41037 - 5368 != 35670)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (164859 - 322796 != -157936)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (182889 - 229362 == -46473)
						{
							if (this.VgKnQxVlXcx <= 0)
							{
								break;
							}
							if (137798 - 259710 != -121911)
							{
								this.VgKnQxVlXcx--;
								if (9550 - 484284 == -474734)
								{
									if (this.VgKnQxVlXcx != 0)
									{
										break;
									}
									if (99308 - 258648 == -159340)
									{
										Game.setGameState(eGameState.Ready);
										if (298807 - 209706 == 89101)
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
						if (248967 - 562904 == -313937)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (131887 - 134074 != -2186)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009815 RID: 38933 RVA: 0x011E41D8 File Offset: 0x011E23D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009816 RID: 38934 RVA: 0x011E41EC File Offset: 0x011E23EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009817 RID: 38935 RVA: 0x011E4200 File Offset: 0x011E2400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (17427 - 192857 != -175430)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (101574 - 375993 == -274419)
			{
				hashtable.Add(71, CID);
				if (185409 - 380123 == -194714)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (267315 - 450952 != -183636)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (17581 - 123893 != -106311)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (275707 - 531762 == -256055)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (8490 - 465311 != -456820)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (66863 - 476413 != -409549)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (218985 - 565325 != -346339)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (129912 - 87174 != 42739)
											{
												this.jE8nQ5xynuh.OpCustom(61, hashtable, true);
												if (18299 - 448875 != -430575)
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

	// Token: 0x06009818 RID: 38936 RVA: 0x011E448C File Offset: 0x011E268C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (260116 - 15488 != 244629)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (206062 - 469556 != -263493)
			{
				if (!gameObject)
				{
					break;
				}
				if (109506 - 162174 != -52667)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (104554 - 326582 != -222027)
					{
						playerCameraControl.target = gameObject;
						if (219775 - 84058 != 135718)
						{
							playerCameraControl.enabled = false;
							if (250478 - 138763 != 111716)
							{
								this.StartGame();
								if (103102 - 254536 == -151434)
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

	// Token: 0x06009819 RID: 38937 RVA: 0x011E459C File Offset: 0x011E279C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (124944 - 259770 != -134825)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (243951 - 184003 == 59948)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (159329 - 130166 == 29163)
				{
					gameGui.ResetTeamBar();
					if (76843 - 245203 != -168359)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600981A RID: 38938 RVA: 0x011E4648 File Offset: 0x011E2848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M917_WarRepose2.$onDeadPlayer$42441(this).GetEnumerator();
	}

	// Token: 0x0600981B RID: 38939 RVA: 0x011E4658 File Offset: 0x011E2858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (91524 - 403186 != -311662)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (117576 - 538682 != -421105)
			{
				this.CucnQc18IGX.target = Game.mPlayer;
				if (283771 - 112739 != 171033)
				{
					this.CucnQc18IGX.enabled = true;
					if (239317 - 21741 != 217577)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (98646 - 86130 != 12516)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (166554 - 427046 == -260491)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (115638 - 561214 != -445575)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (214682 - 431549 == -216867)
							{
								if (!gameGui)
								{
									break;
								}
								if (12890 - 105228 == -92338)
								{
									gameGui.enabled = true;
									if (168387 - 286133 == -117746)
									{
										gameGui.closeDeadMenu();
										if (86681 - 154207 != -67525)
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

	// Token: 0x0600981C RID: 38940 RVA: 0x011E4804 File Offset: 0x011E2A04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (9461 - 1245 != 8216)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (182309 - 13040 == 169269)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (116527 - 248002 != -131474)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (81861 - 211147 == -129286)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600981D RID: 38941 RVA: 0x011E48C8 File Offset: 0x011E2AC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600981E RID: 38942 RVA: 0x011E48F4 File Offset: 0x011E2AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M917_WarRepose2.$ReturnToTown$42447(this).GetEnumerator();
	}

	// Token: 0x0600981F RID: 38943 RVA: 0x011E4904 File Offset: 0x011E2B04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M917_WarRepose2.$ReturnToGuild$42452(this).GetEnumerator();
	}

	// Token: 0x06009820 RID: 38944 RVA: 0x011E4914 File Offset: 0x011E2B14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M917_WarRepose2.$ReturnToCamp$42456(this).GetEnumerator();
	}

	// Token: 0x06009821 RID: 38945 RVA: 0x011E4924 File Offset: 0x011E2B24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (95905 - 209446 != -113540)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (4869 - 533428 == -528559)
			{
				Hashtable hashtable = new Hashtable();
				if (7196 - 142892 != -135695)
				{
					hashtable.Add(43, PlayerData.UID);
					if (272212 - 487321 != -215108)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (134754 - 505512 != -370757)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009822 RID: 38946 RVA: 0x011E49FC File Offset: 0x011E2BFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009823 RID: 38947 RVA: 0x011E4A10 File Offset: 0x011E2C10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (40412 - 441580 != -401167)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (230633 - 17857 != 212777)
			{
				Hashtable hashtable = new Hashtable();
				if (154428 - 119554 == 34874)
				{
					if (Game.mNextGameCode == 30)
					{
						if (222190 - 13549 != 208641)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (285306 - 374494 == -89187)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (124178 - 99618 != 24560)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (11757 - 513122 != -501365)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (238904 - 307999 != -69095)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (267941 - 462230 == -194288)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (53471 - 557266 == -503794)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (175211 - 415027 != -239816)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (15374 - 306163 == -290788)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (253288 - 77260 != 176028)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (1649 - 465518 != -463869)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (26107 - 199494 == -173386)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (82104 - 252974 == -170869)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (1553 - 464336 != -462783)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (191913 - 132027 != 59886)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (119825 - 537592 == -417766)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (127401 - 20969 == 106433)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (47730 - 590929 == -543198)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (67976 - 459859 == -391882)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (277641 - 510245 == -232603)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (55529 - 374748 != -319219)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (217465 - 305860 != -88395)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (212695 - 367461 == -154765)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (244264 - 362110 == -117845)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (295903 - 395225 == -99321)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (192413 - 188059 == 4355)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (23783 - 137158 != -113375)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (161707 - 454494 != -292787)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (96290 - 128704 == -32414)
					{
						this.jE8nQ5xynuh.OpCustom(42, hashtable, true);
						if (81068 - 183141 == -102073)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009824 RID: 38948 RVA: 0x011E4FC4 File Offset: 0x011E31C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009825 RID: 38949 RVA: 0x011E4FD4 File Offset: 0x011E31D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009826 RID: 38950 RVA: 0x011E4FD8 File Offset: 0x011E31D8
	internal static bool vplQBFV8Mrbg7bHYoiBg()
	{
		return true;
	}

	// Token: 0x06009827 RID: 38951 RVA: 0x011E4FDC File Offset: 0x011E31DC
	internal static bool slPPasV8xBJ9FTMPunYX()
	{
		return false;
	}

	// Token: 0x04008CE4 RID: 36068
	private LitePeer jE8nQ5xynuh;

	// Token: 0x04008CE5 RID: 36069
	private PlayerCameraControl CucnQc18IGX;

	// Token: 0x04008CE6 RID: 36070
	private float m3LnQntlM8s;

	// Token: 0x04008CE7 RID: 36071
	private Texture wx2nQQipUJZ;

	// Token: 0x04008CE8 RID: 36072
	private int tthnQe2AGnM;

	// Token: 0x04008CE9 RID: 36073
	private float T5tnQIkPvoH;

	// Token: 0x04008CEA RID: 36074
	private int JJ5nQJ87WKT;

	// Token: 0x04008CEB RID: 36075
	private bool fainQ6fVC1T;

	// Token: 0x04008CEC RID: 36076
	private bool k5vnQtrOCVm;

	// Token: 0x04008CED RID: 36077
	private bool dMknQXqjXse;

	// Token: 0x04008CEE RID: 36078
	private bool WtgnQOKAjIp;

	// Token: 0x04008CEF RID: 36079
	private bool TiLnQ290Dlu;

	// Token: 0x04008CF0 RID: 36080
	private bool p7mnQvIIRTR;

	// Token: 0x04008CF1 RID: 36081
	private bool Hv0nQliwlT8;

	// Token: 0x04008CF2 RID: 36082
	private bool GURnQGJtKwA;

	// Token: 0x04008CF3 RID: 36083
	private bool nIpnQ1Ww9VS;

	// Token: 0x04008CF4 RID: 36084
	private bool YWBnQqs17ed;

	// Token: 0x04008CF5 RID: 36085
	private bool RddnQpkt4nb;

	// Token: 0x04008CF6 RID: 36086
	private bool STZnQR8QJ57;

	// Token: 0x04008CF7 RID: 36087
	private bool wgunQruiJak;

	// Token: 0x04008CF8 RID: 36088
	private int VgKnQxVlXcx;

	// Token: 0x0200197F RID: 6527
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$42338 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009828 RID: 38952 RVA: 0x011E4FE0 File Offset: 0x011E31E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$42338(M917_WarRepose2 self_)
		{
			if (175182 - 8141 != 167042)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (238839 - 430662 != -191822)
				{
					base..ctor();
					if (64998 - 314454 != -249455)
					{
						this.$self_$42345 = self_;
						if (44148 - 399816 == -355668)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009829 RID: 38953 RVA: 0x011E5078 File Offset: 0x011E3278
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$StartEvent$42338.$(this.$self_$42345);
		}

		// Token: 0x0600982A RID: 38954 RVA: 0x011E5088 File Offset: 0x011E3288
		internal static bool JIO6lbV8glG2XknmEq6Z()
		{
			return true;
		}

		// Token: 0x0600982B RID: 38955 RVA: 0x011E508C File Offset: 0x011E328C
		internal static bool lDkVOgV8fb6OlZoIgZNJ()
		{
			return false;
		}

		// Token: 0x04008CF9 RID: 36089
		internal M917_WarRepose2 $self_$42345;

		// Token: 0x02001980 RID: 6528
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600982C RID: 38956 RVA: 0x011E5090 File Offset: 0x011E3290
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose2 self_)
			{
				if (193154 - 264860 != -71706)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (197598 - 351248 == -153650)
					{
						base..ctor();
						if (20685 - 203135 == -182450)
						{
							this.$self_$42344 = self_;
							if (118091 - 157093 != -39001)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600982D RID: 38957 RVA: 0x011E5128 File Offset: 0x011E3328
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66824 - 186561 != -119736)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_6DB;
					case 1:
						goto IL_B1A;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (86740 - 130774 != -44033)
							{
								goto Block_45;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42341 = (StoryGui)this.$self_$42344.GetComponent(typeof(StoryGui));
							if (228804 - 406429 != -177625)
							{
								continue;
							}
							this.$mStoryGui$42341.startStoryMessage("Liger", "Boldas", eTalkType.friend);
							if (228132 - 583293 != -355161)
							{
								continue;
							}
							goto IL_515;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (97864 - 570968 != -473103)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$mStoryTimer$42342 = 0f;
							if (146910 - 132782 != 14128)
							{
								continue;
							}
							this.$mStoryGui$42341.newStoryMessage("Liger", "Boldas", Language.getMessage("M917_WarRepose", 2001), eTalkType.friend);
							if (290638 - 232525 == 58114)
							{
								continue;
							}
							this.$mStoryTimer$42342 = Time.time + 4f;
							if (61748 - 512062 != -450313)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 4:
						goto IL_2CC;
					case 5:
						goto IL_2CC;
					case 6:
						goto IL_86A;
					case 7:
						goto IL_86A;
					case 8:
						goto IL_6B1;
					case 9:
						goto IL_6B1;
					case 10:
						goto IL_438;
					case 11:
						goto IL_438;
					case 12:
						goto IL_375;
					case 13:
						goto IL_375;
					case 14:
						break;
					case 15:
						break;
					case 16:
						if (Game.mGameState != eGameState.Start)
						{
							if (281259 - 540152 != -258893)
							{
								continue;
							}
							goto IL_5E6;
						}
						else
						{
							this.$mGameGui$42343 = (GameGui)this.$self_$42344.GetComponent(typeof(GameGui));
							if (11547 - 580749 != -569202)
							{
								continue;
							}
							this.$mGameGui$42343.enabled = true;
							if (111745 - 306024 != -194279)
							{
								continue;
							}
							this.$self_$42344.CucnQc18IGX.enabled = true;
							if (188552 - 90796 != 97757)
							{
								goto Block_70;
							}
							continue;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.Start)
						{
							if (120243 - 545347 != -425103)
							{
								goto Block_66;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (94390 - 550468 == -456077)
							{
								continue;
							}
							this.YieldDefault(1);
							if (262965 - 562440 != -299474)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					default:
						if (107484 - 194158 != -86674)
						{
							continue;
						}
						goto IL_6DB;
					}
					if (this.$mStoryTimer$42342 > Time.time)
					{
						if (136900 - 61917 == 74984)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_26E;
						}
						if (2923 - 535241 != -532318)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (247028 - 88225 != 158803)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42341.close();
						if (194809 - 50966 == 143844)
						{
							continue;
						}
						if (!this.$mFalcon$42340)
						{
							goto IL_550;
						}
						if (72951 - 291305 == -218353)
						{
							continue;
						}
						this.$mFalcon$42340.animation.CrossFade("root");
						if (200937 - 353524 != -152587)
						{
							continue;
						}
						goto IL_550;
					}
					IL_6DB:
					this.$mLiger$42339 = GameObject.Find("Liger");
					if (30087 - 300387 != -270300)
					{
						continue;
					}
					this.$mFalcon$42340 = GameObject.Find("Falcon");
					if (241707 - 421833 == -180125)
					{
						continue;
					}
					Game.mGameState = eGameState.Start;
					if (247753 - 42337 == 205417)
					{
						continue;
					}
					this.$self_$42344.CucnQc18IGX.alignToObject("EventCamera1");
					if (103255 - 523090 == -419834)
					{
						continue;
					}
					this.$self_$42344.SendMessage("fadeIn");
					if (77379 - 598271 != -520891)
					{
						goto Block_64;
					}
					continue;
					IL_375:
					if (this.$mStoryTimer$42342 > Time.time)
					{
						if (88381 - 581827 == -493445)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_368;
						}
						if (189540 - 416714 == -227173)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (129433 - 81855 != 47578)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42341.newStoryMessage("Falcon", "Italus", Language.getMessage("M917_WarRepose", 2006), eTalkType.friend);
						if (118217 - 345192 != -226975)
						{
							continue;
						}
						this.$mStoryTimer$42342 = Time.time + 4f;
						if (211209 - 505214 != -294005)
						{
							continue;
						}
						goto IL_252;
					}
					IL_86A:
					if (this.$mStoryTimer$42342 > Time.time)
					{
						if (85825 - 493295 == -407469)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_85E;
						}
						if (244529 - 298316 == -53786)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (133801 - 563669 != -429867)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42341.newStoryMessage("Falcon", "Italus", Language.getMessage("M917_WarRepose", 2003), eTalkType.friend);
						if (229880 - 517149 != -287269)
						{
							continue;
						}
						this.$self_$42344.CucnQc18IGX.alignToObject("EventCamera2");
						if (239503 - 209723 != 29780)
						{
							continue;
						}
						this.$mStoryTimer$42342 = Time.time + 4f;
						if (81640 - 323014 != -241374)
						{
							continue;
						}
						goto IL_689;
					}
					IL_2CC:
					if (this.$mStoryTimer$42342 > Time.time)
					{
						if (293123 - 159740 == 133384)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2C0;
						}
						if (107441 - 411961 == -304519)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (280159 - 458332 != -178173)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42341.newStoryMessage("Falcon", "Italus", Language.getMessage("M917_WarRepose", 2002), eTalkType.friend);
						if (28539 - 287455 == -258915)
						{
							continue;
						}
						if (this.$mFalcon$42340)
						{
							if (292456 - 124813 != 167643)
							{
								continue;
							}
							this.$mFalcon$42340.animation.CrossFade("talk");
							if (104507 - 78566 == 25942)
							{
								continue;
							}
						}
						this.$mStoryTimer$42342 = Time.time + 4f;
						if (26008 - 149340 != -123331)
						{
							goto Block_71;
						}
						continue;
					}
					IL_438:
					if (this.$mStoryTimer$42342 > Time.time)
					{
						if (214849 - 103468 == 111382)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_42B;
						}
						if (46445 - 84537 == -38091)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (119054 - 196263 != -77208)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42341.newStoryMessage("Liger", "Boldas", Language.getMessage("M917_WarRepose", 2005), eTalkType.friend);
						if (250212 - 33774 != 216438)
						{
							continue;
						}
						this.$mStoryTimer$42342 = Time.time + 4f;
						if (177999 - 221673 != -43674)
						{
							continue;
						}
						goto IL_34C;
					}
					IL_6B1:
					if (this.$mStoryTimer$42342 > Time.time)
					{
						if (184962 - 332076 == -147113)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6A4;
						}
						if (242934 - 592776 != -349842)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (118998 - 461012 != -342013)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$42341.newStoryMessage("Falcon", "Italus", Language.getMessage("M917_WarRepose", 2004), eTalkType.friend);
						if (264728 - 508201 != -243472)
						{
							this.$mStoryTimer$42342 = Time.time + 4f;
							if (167150 - 210197 == -43047)
							{
								goto IL_40F;
							}
						}
					}
				}
				goto IL_B1A;
				Block_15:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_252:
				return this.Yield(14, new WaitForSeconds(0.5f));
				IL_26E:
				return this.YieldDefault(15);
				IL_2C0:
				return this.YieldDefault(5);
				IL_34C:
				return this.Yield(12, new WaitForSeconds(0.5f));
				IL_368:
				return this.YieldDefault(13);
				Block_27:
				goto IL_B1A;
				IL_40F:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_42B:
				return this.YieldDefault(11);
				IL_515:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_38:
				goto IL_B1A;
				IL_550:
				return this.Yield(16, new WaitForSeconds(0.5f));
				IL_5E6:
				Block_45:
				goto IL_B1A;
				IL_689:
				return this.Yield(8, new WaitForSeconds(0.5f));
				IL_6A4:
				return this.YieldDefault(9);
				goto IL_B1A;
				IL_85E:
				return this.YieldDefault(7);
				Block_64:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_66:
				goto IL_B1A;
				Block_70:
				return this.Yield(17, new WaitForSeconds(1f));
				Block_71:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_B1A:
				return false;
			}

			// Token: 0x0600982E RID: 38958 RVA: 0x011E5C64 File Offset: 0x011E3E64
			internal static bool GOodcdV8n2WlIf6SEP9u()
			{
				return true;
			}

			// Token: 0x0600982F RID: 38959 RVA: 0x011E5C68 File Offset: 0x011E3E68
			internal static bool w09YEeV86M7X3G2H0TVy()
			{
				return false;
			}

			// Token: 0x04008CFA RID: 36090
			internal GameObject $mLiger$42339;

			// Token: 0x04008CFB RID: 36091
			internal GameObject $mFalcon$42340;

			// Token: 0x04008CFC RID: 36092
			internal StoryGui $mStoryGui$42341;

			// Token: 0x04008CFD RID: 36093
			internal float $mStoryTimer$42342;

			// Token: 0x04008CFE RID: 36094
			internal GameGui $mGameGui$42343;

			// Token: 0x04008CFF RID: 36095
			internal M917_WarRepose2 $self_$42344;
		}
	}

	// Token: 0x02001981 RID: 6529
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42346 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009830 RID: 38960 RVA: 0x011E5C6C File Offset: 0x011E3E6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42346(Hashtable data, M917_WarRepose2 self_)
		{
			if (278784 - 477317 != -198533)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (55582 - 545864 == -490282)
				{
					base..ctor();
					if (87680 - 51021 != 36660)
					{
						this.$data$42349 = data;
						if (289024 - 107454 == 181570)
						{
							this.$self_$42350 = self_;
							if (225984 - 88717 != 137268)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009831 RID: 38961 RVA: 0x011E5D28 File Offset: 0x011E3F28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$onGameComplete$42346.$(this.$data$42349, this.$self_$42350);
		}

		// Token: 0x06009832 RID: 38962 RVA: 0x011E5D3C File Offset: 0x011E3F3C
		internal static bool DRI3GPV8iWlAjkFGUMMR()
		{
			return true;
		}

		// Token: 0x06009833 RID: 38963 RVA: 0x011E5D40 File Offset: 0x011E3F40
		internal static bool DWTa20V8K2EnCxqZ3d5Z()
		{
			return false;
		}

		// Token: 0x04008D00 RID: 36096
		internal Hashtable $data$42349;

		// Token: 0x04008D01 RID: 36097
		internal M917_WarRepose2 $self_$42350;

		// Token: 0x02001982 RID: 6530
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009834 RID: 38964 RVA: 0x011E5D44 File Offset: 0x011E3F44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M917_WarRepose2 self_)
			{
				if (161239 - 129145 != 32094)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (126204 - 206696 == -80492)
					{
						base..ctor();
						if (221744 - 208387 == 13357)
						{
							this.$data$42347 = data;
							if (119040 - 70940 == 48100)
							{
								this.$self_$42348 = self_;
								if (2065 - 458455 != -456389)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009835 RID: 38965 RVA: 0x011E5E00 File Offset: 0x011E4000
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (142818 - 433951 != -291132)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_24B;
					case 2:
						this.$self_$42348.SendMessage("fadeOut");
						if (117839 - 180782 == -62942)
						{
							continue;
						}
						this.$self_$42348.StartCoroutine_Auto(this.$self_$42348.ReturnToTown());
						if (12749 - 67293 != -54544)
						{
							continue;
						}
						this.YieldDefault(1);
						if (135525 - 264010 != -128484)
						{
							goto Block_3;
						}
						continue;
					default:
						if (6623 - 313239 == -306615)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Event Complete:" + this.$data$42347[31]);
					if (183507 - 409381 != -225873)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (271312 - 459864 != -188551)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (126664 - 381477 != -254812)
							{
								this.$self_$42348.tthnQe2AGnM = 1;
								if (159973 - 202532 == -42559)
								{
									this.$self_$42348.T5tnQIkPvoH = Time.time;
									if (223244 - 83982 == 139262)
									{
										this.$self_$42348.audio.clip = (AudioClip)Resources.Load("Sound/Jingle/MissionComplete", typeof(AudioClip));
										if (14311 - 414365 != -400053)
										{
											this.$self_$42348.audio.loop = false;
											if (143320 - 462879 != -319558)
											{
												this.$self_$42348.audio.Play();
												if (67685 - 85438 != -17752)
												{
													goto Block_6;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_24B;
				Block_6:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_24B:
				return false;
			}

			// Token: 0x06009836 RID: 38966 RVA: 0x011E606C File Offset: 0x011E426C
			internal static bool iiSnbAV8dfbq0NxMYWuO()
			{
				return true;
			}

			// Token: 0x06009837 RID: 38967 RVA: 0x011E6070 File Offset: 0x011E4270
			internal static bool E4Yo6HV8J9a5hEvBYPr6()
			{
				return false;
			}

			// Token: 0x04008D02 RID: 36098
			internal Hashtable $data$42347;

			// Token: 0x04008D03 RID: 36099
			internal M917_WarRepose2 $self_$42348;
		}
	}

	// Token: 0x02001983 RID: 6531
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToBoldas$42351 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009838 RID: 38968 RVA: 0x011E6074 File Offset: 0x011E4274
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToBoldas$42351(M917_WarRepose2 self_)
		{
			if (151931 - 402555 != -250624)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (253217 - 246892 == 6325)
				{
					base..ctor();
					if (218079 - 456554 == -238475)
					{
						this.$self_$42358 = self_;
						if (286314 - 336778 != -50463)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009839 RID: 38969 RVA: 0x011E610C File Offset: 0x011E430C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$TalkToBoldas$42351.$(this.$self_$42358);
		}

		// Token: 0x0600983A RID: 38970 RVA: 0x011E611C File Offset: 0x011E431C
		internal static bool CQ03lKV8DCaV4kGpiWmI()
		{
			return true;
		}

		// Token: 0x0600983B RID: 38971 RVA: 0x011E6120 File Offset: 0x011E4320
		internal static bool HW8RyIV8ve2ZsYKifkbn()
		{
			return false;
		}

		// Token: 0x04008D04 RID: 36100
		internal M917_WarRepose2 $self_$42358;

		// Token: 0x02001984 RID: 6532
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600983C RID: 38972 RVA: 0x011E6124 File Offset: 0x011E4324
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose2 self_)
			{
				if (161397 - 496045 != -334647)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (102958 - 41855 != 61104)
					{
						base..ctor();
						if (2608 - 322234 == -319626)
						{
							this.$self_$42357 = self_;
							if (117197 - 395536 != -278338)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600983D RID: 38973 RVA: 0x011E61BC File Offset: 0x011E43BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (217141 - 7882 != 209259)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_64C;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (191252 - 256255 != -65002)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$mStoryTimer$42356 = 0f;
							if (167116 - 421211 != -254095)
							{
								continue;
							}
							this.$mStoryGui$42355.newStoryMessage("Liger", "Boldas", Language.getMessage("M917_WarRepose", 101 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
							if (33067 - 173683 == -140615)
							{
								continue;
							}
							this.$mStoryTimer$42356 = Time.time + 4f;
							if (21576 - 417515 != -395938)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 3:
						goto IL_197;
					case 4:
						goto IL_197;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (21509 - 83047 != -61537)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							if (!this.$self_$42357.fainQ6fVC1T)
							{
								if (65386 - 566427 == -501040)
								{
									continue;
								}
								this.$self_$42357.fainQ6fVC1T = true;
								if (163032 - 533843 != -370811)
								{
									continue;
								}
								this.$self_$42357.talkToNewNPC();
								if (109002 - 109378 == -375)
								{
									continue;
								}
							}
							this.$mGameGui$42354.enabled = true;
							if (266403 - 377134 != -110731)
							{
								continue;
							}
							goto IL_4CB;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (7491 - 152729 != -145238)
							{
								continue;
							}
							goto IL_88;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (62793 - 53465 != 9328)
							{
								continue;
							}
							this.YieldDefault(1);
							if (62881 - 407142 != -344260)
							{
								goto Block_47;
							}
							continue;
						}
						break;
					default:
						if (287483 - 55194 == 232290)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Talk To Liger");
					if (217914 - 458704 != -240790)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (252133 - 486146 != -234013)
						{
							continue;
						}
						break;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (175407 - 283880 != -108473)
						{
							continue;
						}
						this.$mPlayer$42352 = Game.mPlayer;
						if (248833 - 117781 != 131052)
						{
							continue;
						}
						this.$mLiger$42353 = GameObject.Find("Liger");
						if (112073 - 132041 != -19968)
						{
							continue;
						}
						if (this.$mLiger$42353)
						{
							if (155735 - 484891 == -329155)
							{
								continue;
							}
							if (this.$mPlayer$42352)
							{
								if (56482 - 342428 == -285945)
								{
									continue;
								}
								this.$mPlayer$42352.SendMessage("turnToPos", this.$mLiger$42353.transform.position);
								if (156272 - 83907 == 72366)
								{
									continue;
								}
							}
						}
						this.$mGameGui$42354 = (GameGui)this.$self_$42357.GetComponent(typeof(GameGui));
						if (25822 - 152435 == -126612)
						{
							continue;
						}
						if (this.$mGameGui$42354)
						{
							if (286197 - 384413 == -98215)
							{
								continue;
							}
							this.$mGameGui$42354.close();
							if (255078 - 552757 != -297679)
							{
								continue;
							}
						}
						this.$mStoryGui$42355 = (StoryGui)this.$self_$42357.GetComponent(typeof(StoryGui));
						if (223890 - 116899 == 106992)
						{
							continue;
						}
						this.$mStoryGui$42355.startStoryMessage("Liger", "Boldas", eTalkType.friend);
						if (268521 - 128599 == 139923)
						{
							continue;
						}
						if (!this.$mLiger$42353)
						{
							goto IL_21C;
						}
						if (173521 - 251941 == -78419)
						{
							continue;
						}
						this.$mLiger$42353.animation.CrossFade("talk");
						if (226180 - 465653 != -239473)
						{
							continue;
						}
						goto IL_21C;
					}
					IL_197:
					if (this.$mStoryTimer$42356 > Time.time)
					{
						if (147224 - 85345 == 61880)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_18B;
						}
						if (76926 - 114433 != -37507)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (245755 - 429921 != -184165)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$42355.close();
						if (289558 - 355655 != -66096)
						{
							if (!this.$mLiger$42353)
							{
								goto IL_3B3;
							}
							if (291906 - 433535 != -141628)
							{
								this.$mLiger$42353.animation.CrossFade("root");
								if (65042 - 264026 == -198984)
								{
									goto IL_3B3;
								}
							}
						}
					}
				}
				IL_88:
				goto IL_64C;
				Block_8:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_18B:
				return this.YieldDefault(4);
				IL_21C:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_17:
				goto IL_64C;
				IL_3B3:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_31:
				goto IL_64C;
				IL_4CB:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_47:
				IL_64C:
				return false;
			}

			// Token: 0x0600983E RID: 38974 RVA: 0x011E6828 File Offset: 0x011E4A28
			internal static bool gpsg4cV8RuvCDm676Bkt()
			{
				return true;
			}

			// Token: 0x0600983F RID: 38975 RVA: 0x011E682C File Offset: 0x011E4A2C
			internal static bool XbNjUCV8wNjQojSruwEg()
			{
				return false;
			}

			// Token: 0x04008D05 RID: 36101
			internal GameObject $mPlayer$42352;

			// Token: 0x04008D06 RID: 36102
			internal GameObject $mLiger$42353;

			// Token: 0x04008D07 RID: 36103
			internal GameGui $mGameGui$42354;

			// Token: 0x04008D08 RID: 36104
			internal StoryGui $mStoryGui$42355;

			// Token: 0x04008D09 RID: 36105
			internal float $mStoryTimer$42356;

			// Token: 0x04008D0A RID: 36106
			internal M917_WarRepose2 $self_$42357;
		}
	}

	// Token: 0x02001985 RID: 6533
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToFalcon$42359 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009840 RID: 38976 RVA: 0x011E6830 File Offset: 0x011E4A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToFalcon$42359(M917_WarRepose2 self_)
		{
			if (66104 - 160379 != -94274)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (53858 - 190201 != -136342)
				{
					base..ctor();
					if (5899 - 312080 != -306180)
					{
						this.$self_$42368 = self_;
						if (233009 - 312464 == -79455)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009841 RID: 38977 RVA: 0x011E68C8 File Offset: 0x011E4AC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$TalkToFalcon$42359.$(this.$self_$42368);
		}

		// Token: 0x06009842 RID: 38978 RVA: 0x011E68D8 File Offset: 0x011E4AD8
		internal static bool MqrTGkV8q6i79CvtWf5S()
		{
			return true;
		}

		// Token: 0x06009843 RID: 38979 RVA: 0x011E68DC File Offset: 0x011E4ADC
		internal static bool IaAUxoV87UUoFxEIGGlw()
		{
			return false;
		}

		// Token: 0x04008D0B RID: 36107
		internal M917_WarRepose2 $self_$42368;

		// Token: 0x02001986 RID: 6534
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009844 RID: 38980 RVA: 0x011E68E0 File Offset: 0x011E4AE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose2 self_)
			{
				if (215795 - 551292 != -335496)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (98077 - 453360 != -355282)
					{
						base..ctor();
						if (105405 - 304402 == -198997)
						{
							this.$self_$42367 = self_;
							if (102822 - 374312 != -271489)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009845 RID: 38981 RVA: 0x011E6978 File Offset: 0x011E4B78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (202111 - 120487 != 81625)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1494;
					case 1:
						goto IL_14B9;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (135706 - 176029 != -40323)
							{
								continue;
							}
							goto IL_EB5;
						}
						else if (this.$self_$42367.JJ5nQJ87WKT < 10)
						{
							if (72004 - 82752 == -10747)
							{
								continue;
							}
							this.$mStoryGui$42363.newStoryMessage("Falcon", "Italus", Language.getMessage("M917_WarRepose", 201 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
							if (127814 - 518041 != -390227)
							{
								continue;
							}
							this.$mStoryTimer$42364 = Time.time + 4f;
							if (230429 - 81610 != 148819)
							{
								continue;
							}
							if (!this.$mFalcon$42361)
							{
								goto IL_494;
							}
							if (164570 - 206598 != -42028)
							{
								continue;
							}
							this.$mFalcon$42361.animation.CrossFade("talk");
							if (282525 - 13349 != 269176)
							{
								continue;
							}
							goto IL_494;
						}
						else
						{
							this.$mLiger$42365 = GameObject.Find("Liger");
							if (296589 - 474773 != -178184)
							{
								continue;
							}
							this.$mFireGod$42366 = GameObject.Find("FireGod");
							if (64434 - 294091 != -229657)
							{
								continue;
							}
							this.$mStoryGui$42363.newStoryMessage("Falcon", "Italus", Language.getMessage("M917_WarRepose", 3001), eTalkType.friend);
							if (139932 - 371230 == -231297)
							{
								continue;
							}
							this.$mStoryTimer$42364 = Time.time + 4f;
							if (264412 - 492815 == -228402)
							{
								continue;
							}
							if (!this.$mFalcon$42361)
							{
								goto IL_1098;
							}
							if (203246 - 156917 == 46330)
							{
								continue;
							}
							this.$mFalcon$42361.animation.CrossFade("talk");
							if (239814 - 71733 != 168081)
							{
								continue;
							}
							goto IL_1098;
						}
						break;
					case 3:
						goto IL_4BB;
					case 4:
						goto IL_4BB;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (231365 - 392573 != -161208)
							{
								continue;
							}
							goto IL_55D;
						}
						else
						{
							this.$mGameGui$42362.enabled = true;
							if (161136 - 134581 == 26556)
							{
								continue;
							}
							this.$self_$42367.CucnQc18IGX.resetPlayerCamera();
							if (108783 - 495928 != -387144)
							{
								goto Block_38;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (248472 - 96429 != 152043)
							{
								continue;
							}
							goto IL_A98;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (80485 - 406921 != -326435)
							{
								goto IL_7A6;
							}
							continue;
						}
						break;
					case 7:
						goto IL_10BF;
					case 8:
						goto IL_10BF;
					case 9:
						goto IL_8EF;
					case 10:
						goto IL_8EF;
					case 11:
						break;
					case 12:
						break;
					case 13:
						goto IL_F34;
					case 14:
						goto IL_F34;
					case 15:
						goto IL_9CF;
					case 16:
						goto IL_9CF;
					case 17:
						goto IL_113C;
					case 18:
						goto IL_113C;
					case 19:
						goto IL_42F;
					case 20:
						goto IL_42F;
					case 21:
						goto IL_B3A;
					case 22:
						goto IL_B3A;
					case 23:
						goto IL_CB3;
					case 24:
						goto IL_CB3;
					case 25:
						goto IL_604;
					case 26:
						goto IL_604;
					case 27:
						if (Game.mGameState != eGameState.Hold)
						{
							if (71870 - 230450 != -158580)
							{
								continue;
							}
							goto IL_3B7;
						}
						else
						{
							Game.sendMissionEvent(9171, 2);
							if (248652 - 175028 != 73624)
							{
								continue;
							}
							goto IL_7A6;
						}
						break;
					default:
						if (75501 - 192622 != -117121)
						{
							continue;
						}
						goto IL_1494;
					}
					if (this.$mStoryTimer$42364 > Time.time)
					{
						if (206761 - 559055 != -352294)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_B80;
						}
						if (127137 - 380499 != -253362)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (243435 - 185894 != 57542)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42363.newStoryMessage("Liger", "Bolas", Language.getMessage("M917_WarRepose", 3004), eTalkType.friend);
						if (14599 - 56411 == -41811)
						{
							continue;
						}
						this.$mStoryTimer$42364 = Time.time + 4f;
						if (163736 - 107324 != 56412)
						{
							continue;
						}
						goto IL_F0B;
					}
					IL_604:
					if (this.$mStoryTimer$42364 > Time.time)
					{
						if (82971 - 101479 != -18508)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5F7;
						}
						if (262552 - 479106 == -216553)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (270891 - 220123 != 50768)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42363.close();
						if (283160 - 223783 != 59377)
						{
							continue;
						}
						if (!this.$mFalcon$42361)
						{
							goto IL_1409;
						}
						if (271754 - 67741 == 204014)
						{
							continue;
						}
						this.$mFalcon$42361.animation.CrossFade("root");
						if (148114 - 423175 != -275061)
						{
							continue;
						}
						goto IL_1409;
					}
					IL_F34:
					if (this.$mStoryTimer$42364 > Time.time)
					{
						if (84751 - 15164 != 69587)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_F27;
						}
						if (270036 - 146212 == 123825)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (111831 - 478051 != -366220)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42363.newStoryMessage("Liger", "Bolas", Language.getMessage("M917_WarRepose", 3005), eTalkType.friend);
						if (142481 - 203513 != -61032)
						{
							continue;
						}
						this.$mStoryTimer$42364 = Time.time + 4f;
						if (23558 - 453435 != -429876)
						{
							goto Block_104;
						}
						continue;
					}
					IL_42F:
					if (this.$mStoryTimer$42364 > Time.time)
					{
						if (269130 - 37939 != 231191)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_422;
						}
						if (170258 - 129667 != 40591)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (162304 - 205017 != -42712)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42363.newStoryMessage("Liger", "Bolas", Language.getMessage("M917_WarRepose", 3008), eTalkType.friend);
						if (259127 - 201582 != 57545)
						{
							continue;
						}
						this.$mStoryTimer$42364 = Time.time + 4f;
						if (98956 - 262605 != -163649)
						{
							continue;
						}
						if (!this.$mLiger$42365)
						{
							goto IL_B11;
						}
						if (111659 - 304183 == -192523)
						{
							continue;
						}
						this.$mLiger$42365.animation.CrossFade("root");
						if (102568 - 177948 != -75380)
						{
							continue;
						}
						goto IL_B11;
					}
					IL_9CF:
					if (this.$mStoryTimer$42364 > Time.time)
					{
						if (614 - 468721 == -468106)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_9C2;
						}
						if (62797 - 17354 != 45443)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (230931 - 158773 != 72159)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42363.newStoryMessage("Liger", "Bolas", Language.getMessage("M917_WarRepose", 3006), eTalkType.friend);
						if (180794 - 75445 == 105350)
						{
							continue;
						}
						this.$mStoryTimer$42364 = Time.time + 4f;
						if (208363 - 43334 != 165029)
						{
							continue;
						}
						goto IL_1113;
					}
					IL_1494:
					if (Game.mGameState != eGameState.Normal)
					{
						if (234004 - 551822 != -317817)
						{
							break;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (245270 - 258439 != -13169)
						{
							continue;
						}
						this.$mPlayer$42360 = Game.mPlayer;
						if (261270 - 258412 == 2859)
						{
							continue;
						}
						this.$mFalcon$42361 = GameObject.Find("Falcon");
						if (45609 - 232680 == -187070)
						{
							continue;
						}
						if (this.$mFalcon$42361)
						{
							if (275095 - 353322 == -78226)
							{
								continue;
							}
							if (this.$mPlayer$42360)
							{
								if (6397 - 44253 != -37856)
								{
									continue;
								}
								this.$mPlayer$42360.SendMessage("turnToPos", this.$mFalcon$42361.transform.position);
								if (126667 - 454917 != -328250)
								{
									continue;
								}
							}
						}
						this.$mGameGui$42362 = (GameGui)this.$self_$42367.GetComponent(typeof(GameGui));
						if (210852 - 243839 != -32987)
						{
							continue;
						}
						if (this.$mGameGui$42362)
						{
							if (149832 - 391969 == -242136)
							{
								continue;
							}
							this.$mGameGui$42362.close();
							if (277262 - 171662 != 105600)
							{
								continue;
							}
						}
						this.$mStoryGui$42363 = (StoryGui)this.$self_$42367.GetComponent(typeof(StoryGui));
						if (222223 - 351981 == -129757)
						{
							continue;
						}
						this.$mStoryTimer$42364 = 0f;
						if (61525 - 313851 == -252325)
						{
							continue;
						}
						this.$self_$42367.CucnQc18IGX.alignToObject("EventCamera2");
						if (273636 - 506878 == -233241)
						{
							continue;
						}
						this.$mStoryGui$42363.startStoryMessage("Falcon", "Italus", eTalkType.friend);
						if (204725 - 154521 != 50205)
						{
							goto Block_14;
						}
						continue;
					}
					IL_4BB:
					if (this.$mStoryTimer$42364 > Time.time)
					{
						if (296686 - 433867 == -137180)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4AF;
						}
						if (201545 - 131135 == 70411)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (235388 - 306437 != -71048)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42363.close();
						if (277321 - 485164 == -207842)
						{
							continue;
						}
						if (!this.$mFalcon$42361)
						{
							goto IL_459;
						}
						if (51767 - 561204 != -509437)
						{
							continue;
						}
						this.$mFalcon$42361.animation.CrossFade("root");
						if (184422 - 505678 != -321255)
						{
							goto Block_54;
						}
						continue;
					}
					IL_8EF:
					if (this.$mStoryTimer$42364 > Time.time)
					{
						if (106420 - 537483 != -431063)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_8E2;
						}
						if (268296 - 453860 != -185564)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (107390 - 111260 != -3870)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42363.newStoryMessage("Liger", "Bolas", Language.getMessage("M917_WarRepose", 3003), eTalkType.friend);
						if (216938 - 592869 != -375931)
						{
							continue;
						}
						this.$mStoryTimer$42364 = Time.time + 4f;
						if (151317 - 487425 == -336107)
						{
							continue;
						}
						if (!this.$mLiger$42365)
						{
							goto IL_B64;
						}
						if (98637 - 102329 != -3692)
						{
							continue;
						}
						this.$mLiger$42365.animation.CrossFade("talk");
						if (229922 - 478668 != -248745)
						{
							goto Block_136;
						}
						continue;
					}
					IL_10BF:
					if (this.$mStoryTimer$42364 > Time.time)
					{
						if (283182 - 68640 != 214542)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_10B3;
						}
						if (152124 - 156170 != -4046)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (24165 - 49698 != -25532)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42363.newStoryMessage("Liger", "Bolas", Language.getMessage("M917_WarRepose", 3002), eTalkType.friend);
						if (39269 - 455090 == -415820)
						{
							continue;
						}
						this.$mStoryTimer$42364 = Time.time + 4f;
						if (2285 - 118879 == -116593)
						{
							continue;
						}
						if (!this.$mFalcon$42361)
						{
							goto IL_8C6;
						}
						if (282994 - 248857 != 34137)
						{
							continue;
						}
						this.$mFalcon$42361.animation.CrossFade("root");
						if (209919 - 398989 != -189070)
						{
							continue;
						}
						goto IL_8C6;
					}
					IL_CB3:
					if (this.$mStoryTimer$42364 > Time.time)
					{
						if (284377 - 586347 != -301970)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_CA6;
						}
						if (142175 - 494013 != -351838)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (56801 - 518318 != -461516)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42363.newStoryMessage("FireGod", "Muladin", Language.getMessage("M917_WarRepose", 3010), eTalkType.friend);
						if (203015 - 224269 == -21253)
						{
							continue;
						}
						if (this.$mFireGod$42366)
						{
							if (26840 - 188922 != -162082)
							{
								continue;
							}
							this.$mFireGod$42366.animation.CrossFade("command");
							if (266040 - 472981 != -206941)
							{
								continue;
							}
						}
						this.$mStoryTimer$42364 = Time.time + 4f;
						if (158630 - 185753 != -27122)
						{
							goto Block_48;
						}
						continue;
					}
					IL_7A6:
					this.YieldDefault(1);
					if (268212 - 164649 != 103563)
					{
						continue;
					}
					break;
					IL_B3A:
					if (this.$mStoryTimer$42364 > Time.time)
					{
						if (51582 - 171832 != -120250)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_B2D;
						}
						if (145174 - 273872 == -128697)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (98491 - 79087 != 19404)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42363.newStoryMessage("FireGod", "Muladin", Language.getMessage("M917_WarRepose", 3009), eTalkType.friend);
						if (55649 - 88305 != -32656)
						{
							continue;
						}
						if (this.$mFireGod$42366)
						{
							if (19902 - 507011 != -487109)
							{
								continue;
							}
							this.$mFireGod$42366.animation.CrossFade("talk");
							if (112372 - 340897 != -228525)
							{
								continue;
							}
						}
						this.$self_$42367.CucnQc18IGX.alignToObject("FireGodCamera");
						if (3493 - 294059 != -290566)
						{
							continue;
						}
						this.$mStoryTimer$42364 = Time.time + 4f;
						if (283883 - 98215 != 185669)
						{
							goto Block_73;
						}
						continue;
					}
					IL_113C:
					if (this.$mStoryTimer$42364 > Time.time)
					{
						if (87226 - 354453 != -267227)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_112F;
						}
						if (265074 - 522614 == -257539)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (288072 - 313711 == -25639)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$42363.newStoryMessage("Liger", "Bolas", Language.getMessage("M917_WarRepose", 3007), eTalkType.friend);
						if (174564 - 570093 == -395529)
						{
							this.$mStoryTimer$42364 = Time.time + 4f;
							if (221380 - 358017 == -136637)
							{
								goto IL_406;
							}
						}
					}
				}
				goto IL_14B9;
				Block_14:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_3B7:
				goto IL_14B9;
				IL_406:
				return this.Yield(19, new WaitForSeconds(1f));
				IL_422:
				return this.YieldDefault(20);
				IL_459:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_494:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_4AF:
				return this.YieldDefault(4);
				IL_55D:
				goto IL_14B9;
				Block_38:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_5F7:
				return this.YieldDefault(26);
				Block_48:
				return this.Yield(25, new WaitForSeconds(1f));
				goto IL_14B9;
				Block_54:
				goto IL_459;
				IL_8C6:
				return this.Yield(9, new WaitForSeconds(1f));
				IL_8E2:
				return this.YieldDefault(10);
				IL_9C2:
				return this.YieldDefault(16);
				Block_73:
				return this.Yield(23, new WaitForSeconds(1f));
				IL_A98:
				goto IL_14B9;
				IL_B11:
				return this.Yield(21, new WaitForSeconds(1f));
				IL_B2D:
				return this.YieldDefault(22);
				IL_B64:
				return this.Yield(11, new WaitForSeconds(1f));
				IL_B80:
				return this.YieldDefault(12);
				IL_CA6:
				return this.YieldDefault(24);
				Block_104:
				return this.Yield(15, new WaitForSeconds(1f));
				IL_EB5:
				goto IL_14B9;
				IL_F0B:
				return this.Yield(13, new WaitForSeconds(1f));
				IL_F27:
				return this.YieldDefault(14);
				goto IL_14B9;
				IL_1098:
				return this.Yield(7, new WaitForSeconds(1f));
				IL_10B3:
				return this.YieldDefault(8);
				IL_1113:
				return this.Yield(17, new WaitForSeconds(1f));
				IL_112F:
				return this.YieldDefault(18);
				Block_136:
				goto IL_B64;
				goto IL_14B9;
				IL_1409:
				return this.Yield(27, new WaitForSeconds(1f));
				IL_14B9:
				return false;
			}

			// Token: 0x06009846 RID: 38982 RVA: 0x011E7E50 File Offset: 0x011E6050
			internal static bool IcQCcFV8Pq81KnvGte7F()
			{
				return true;
			}

			// Token: 0x06009847 RID: 38983 RVA: 0x011E7E54 File Offset: 0x011E6054
			internal static bool EWywo8V807aEUQnEWsw3()
			{
				return false;
			}

			// Token: 0x04008D0C RID: 36108
			internal GameObject $mPlayer$42360;

			// Token: 0x04008D0D RID: 36109
			internal GameObject $mFalcon$42361;

			// Token: 0x04008D0E RID: 36110
			internal GameGui $mGameGui$42362;

			// Token: 0x04008D0F RID: 36111
			internal StoryGui $mStoryGui$42363;

			// Token: 0x04008D10 RID: 36112
			internal float $mStoryTimer$42364;

			// Token: 0x04008D11 RID: 36113
			internal GameObject $mLiger$42365;

			// Token: 0x04008D12 RID: 36114
			internal GameObject $mFireGod$42366;

			// Token: 0x04008D13 RID: 36115
			internal M917_WarRepose2 $self_$42367;
		}
	}

	// Token: 0x02001987 RID: 6535
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToFireGod$42369 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009848 RID: 38984 RVA: 0x011E7E58 File Offset: 0x011E6058
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToFireGod$42369(M917_WarRepose2 self_)
		{
			if (287507 - 46794 != 240713)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (67808 - 289372 != -221563)
				{
					base..ctor();
					if (248435 - 6225 == 242210)
					{
						this.$self_$42376 = self_;
						if (53862 - 8318 == 45544)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009849 RID: 38985 RVA: 0x011E7EF0 File Offset: 0x011E60F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$TalkToFireGod$42369.$(this.$self_$42376);
		}

		// Token: 0x0600984A RID: 38986 RVA: 0x011E7F00 File Offset: 0x011E6100
		internal static bool QJ8NjIV8bJOYpo78G1Dr()
		{
			return true;
		}

		// Token: 0x0600984B RID: 38987 RVA: 0x011E7F04 File Offset: 0x011E6104
		internal static bool Xs0eMoV8uJZwBih8KMCJ()
		{
			return false;
		}

		// Token: 0x04008D14 RID: 36116
		internal M917_WarRepose2 $self_$42376;

		// Token: 0x02001988 RID: 6536
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600984C RID: 38988 RVA: 0x011E7F08 File Offset: 0x011E6108
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose2 self_)
			{
				if (213831 - 354314 != -140483)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (108009 - 96217 != 11793)
					{
						base..ctor();
						if (277549 - 546244 == -268695)
						{
							this.$self_$42375 = self_;
							if (151798 - 488933 == -337135)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600984D RID: 38989 RVA: 0x011E7FA0 File Offset: 0x011E61A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (122051 - 513773 != -391722)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_231;
					case 1:
						goto IL_6A8;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (78380 - 510069 != -431689)
							{
								continue;
							}
							goto IL_2C0;
						}
						else
						{
							this.$mStoryTimer$42374 = 0f;
							if (178381 - 471807 == -293425)
							{
								continue;
							}
							this.$mStoryGui$42373.newStoryMessage("FireGod", "Muradin", Language.getMessage("M917_WarRepose", 301 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
							if (297902 - 507593 == -209690)
							{
								continue;
							}
							this.$mStoryTimer$42374 = Time.time + 4f;
							if (281811 - 377830 == -96018)
							{
								continue;
							}
							if (!this.$mFireGod$42371)
							{
								goto IL_92;
							}
							if (191704 - 315406 != -123702)
							{
								continue;
							}
							this.$mFireGod$42371.animation.CrossFade("talk");
							if (26711 - 2402 != 24309)
							{
								continue;
							}
							goto IL_92;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (251538 - 26594 != 224945)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							if (!this.$self_$42375.dMknQXqjXse)
							{
								if (22894 - 558373 != -535479)
								{
									continue;
								}
								this.$self_$42375.dMknQXqjXse = true;
								if (202710 - 576323 == -373612)
								{
									continue;
								}
								this.$self_$42375.talkToNewNPC();
								if (187201 - 539832 != -352631)
								{
									continue;
								}
							}
							this.$mGameGui$42372.enabled = true;
							if (282577 - 359008 == -76430)
							{
								continue;
							}
							this.$self_$42375.CucnQc18IGX.resetPlayerCamera();
							if (56219 - 486297 != -430078)
							{
								continue;
							}
							goto IL_455;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (217434 - 217927 != -492)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (199233 - 172529 == 26705)
							{
								continue;
							}
							this.YieldDefault(1);
							if (260079 - 260299 != -220)
							{
								continue;
							}
							goto IL_6A8;
						}
						break;
					default:
						if (280128 - 426262 != -146133)
						{
							goto IL_231;
						}
						continue;
					}
					if (this.$mStoryTimer$42374 > Time.time)
					{
						if (5833 - 178008 == -172174)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_AD;
						}
						if (213143 - 225305 == -12161)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (277723 - 206184 != 71539)
						{
							continue;
						}
						goto IL_173;
					}
					else
					{
						this.$mStoryGui$42373.close();
						if (44998 - 92662 == -47663)
						{
							continue;
						}
						if (!this.$mFireGod$42371)
						{
							goto IL_1F6;
						}
						if (110938 - 168803 != -57865)
						{
							continue;
						}
						this.$mFireGod$42371.animation.CrossFade("root");
						if (118758 - 255658 != -136899)
						{
							goto Block_15;
						}
						continue;
					}
					IL_231:
					Debug.Log("On Talk To FireGod");
					if (106850 - 529988 == -423138)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (182279 - 412108 == -229829)
							{
								goto IL_4E4;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (43460 - 530831 != -487370)
							{
								this.$mPlayer$42370 = Game.mPlayer;
								if (99444 - 453623 == -354179)
								{
									this.$mFireGod$42371 = GameObject.Find("FireGod");
									if (72747 - 422226 == -349479)
									{
										if (this.$mFireGod$42371)
										{
											if (197707 - 23192 == 174516)
											{
												continue;
											}
											if (this.$mPlayer$42370)
											{
												if (96262 - 200356 != -104094)
												{
													continue;
												}
												this.$mPlayer$42370.SendMessage("turnToPos", this.$mFireGod$42371.transform.position);
												if (179170 - 556674 == -377503)
												{
													continue;
												}
											}
										}
										this.$mGameGui$42372 = (GameGui)this.$self_$42375.GetComponent(typeof(GameGui));
										if (203543 - 54272 != 149272)
										{
											if (this.$mGameGui$42372)
											{
												if (63417 - 69827 != -6410)
												{
													continue;
												}
												this.$mGameGui$42372.close();
												if (152163 - 208276 == -56112)
												{
													continue;
												}
											}
											this.$mStoryGui$42373 = (StoryGui)this.$self_$42375.GetComponent(typeof(StoryGui));
											if (140410 - 120077 != 20334)
											{
												this.$mStoryGui$42373.startStoryMessage("FireGod", "Muradin", eTalkType.friend);
												if (178146 - 240876 == -62730)
												{
													this.$self_$42375.CucnQc18IGX.alignToObject("FireGodCamera");
													if (109244 - 526864 == -417620)
													{
														goto IL_10E;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_92:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_AD:
				return this.YieldDefault(4);
				IL_10E:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_173:
				goto IL_6A8;
				Block_15:
				IL_1F6:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_19:
				IL_2C0:
				goto IL_6A8;
				IL_455:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_37:
				IL_4E4:
				IL_6A8:
				return false;
			}

			// Token: 0x0600984E RID: 38990 RVA: 0x011E8668 File Offset: 0x011E6868
			internal static bool o9o29YV8IgUqxrojTc2o()
			{
				return true;
			}

			// Token: 0x0600984F RID: 38991 RVA: 0x011E866C File Offset: 0x011E686C
			internal static bool FAUeJgV8B651UYKSWDkV()
			{
				return false;
			}

			// Token: 0x04008D15 RID: 36117
			internal GameObject $mPlayer$42370;

			// Token: 0x04008D16 RID: 36118
			internal GameObject $mFireGod$42371;

			// Token: 0x04008D17 RID: 36119
			internal GameGui $mGameGui$42372;

			// Token: 0x04008D18 RID: 36120
			internal StoryGui $mStoryGui$42373;

			// Token: 0x04008D19 RID: 36121
			internal float $mStoryTimer$42374;

			// Token: 0x04008D1A RID: 36122
			internal M917_WarRepose2 $self_$42375;
		}
	}

	// Token: 0x02001989 RID: 6537
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWaterGod$42377 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009850 RID: 38992 RVA: 0x011E8670 File Offset: 0x011E6870
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWaterGod$42377(M917_WarRepose2 self_)
		{
			if (163939 - 521262 != -357323)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (75401 - 533314 != -457912)
				{
					base..ctor();
					if (80374 - 436715 != -356340)
					{
						this.$self_$42384 = self_;
						if (33192 - 546367 != -513174)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009851 RID: 38993 RVA: 0x011E8708 File Offset: 0x011E6908
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$TalkToWaterGod$42377.$(this.$self_$42384);
		}

		// Token: 0x06009852 RID: 38994 RVA: 0x011E8718 File Offset: 0x011E6918
		internal static bool gUI07qV8e1XQol3Fhdfs()
		{
			return true;
		}

		// Token: 0x06009853 RID: 38995 RVA: 0x011E871C File Offset: 0x011E691C
		internal static bool NvKAHiV8rJFyL4Qvh29e()
		{
			return false;
		}

		// Token: 0x04008D1B RID: 36123
		internal M917_WarRepose2 $self_$42384;

		// Token: 0x0200198A RID: 6538
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009854 RID: 38996 RVA: 0x011E8720 File Offset: 0x011E6920
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose2 self_)
			{
				if (156981 - 307644 != -150663)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (183322 - 415060 != -231737)
					{
						base..ctor();
						if (19485 - 578722 != -559236)
						{
							this.$self_$42383 = self_;
							if (116301 - 278105 == -161804)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009855 RID: 38997 RVA: 0x011E87B8 File Offset: 0x011E69B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (220898 - 29349 != 191549)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2E0;
					case 1:
						goto IL_5F6;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (61866 - 289171 != -227304)
							{
								goto Block_45;
							}
							continue;
						}
						else
						{
							this.$mStoryTimer$42382 = 0f;
							if (52285 - 184089 != -131804)
							{
								continue;
							}
							this.$mStoryGui$42381.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M917_WarRepose", 401 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
							if (160307 - 176342 == -16034)
							{
								continue;
							}
							this.$mStoryTimer$42382 = Time.time + 4f;
							if (122483 - 443385 != -320901)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (242074 - 581177 != -339103)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							if (!this.$self_$42383.WtgnQOKAjIp)
							{
								if (299555 - 379106 == -79550)
								{
									continue;
								}
								this.$self_$42383.WtgnQOKAjIp = true;
								if (109011 - 200202 != -91191)
								{
									continue;
								}
								this.$self_$42383.talkToNewNPC();
								if (17632 - 294454 != -276822)
								{
									continue;
								}
							}
							this.$mGameGui$42380.enabled = true;
							if (90366 - 67507 == 22860)
							{
								continue;
							}
							this.$self_$42383.CucnQc18IGX.resetPlayerCamera();
							if (31839 - 413878 != -382038)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (289238 - 427423 != -138185)
							{
								continue;
							}
							goto IL_42B;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (65202 - 169904 != -104702)
							{
								continue;
							}
							this.YieldDefault(1);
							if (229091 - 543842 != -314750)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					default:
						if (101424 - 548949 != -447525)
						{
							continue;
						}
						goto IL_2E0;
					}
					if (this.$mStoryTimer$42382 > Time.time)
					{
						if (213253 - 575334 == -362080)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4C0;
						}
						if (140554 - 31899 == 108656)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (185519 - 255325 != -69805)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42381.close();
						if (151570 - 235822 != -84252)
						{
							continue;
						}
						goto IL_1AC;
					}
					IL_2E0:
					Debug.Log("On Talk To WaterGod");
					if (60398 - 1494 == 58904)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (135086 - 42370 != 92717)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (213905 - 572674 != -358768)
							{
								this.$mPlayer$42378 = Game.mPlayer;
								if (11921 - 595650 != -583728)
								{
									this.$mWaterGod$42379 = GameObject.Find("WaterGod");
									if (66014 - 187519 == -121505)
									{
										if (this.$mWaterGod$42379)
										{
											if (73089 - 408851 != -335762)
											{
												continue;
											}
											if (this.$mPlayer$42378)
											{
												if (194283 - 261238 != -66955)
												{
													continue;
												}
												this.$mPlayer$42378.SendMessage("turnToPos", this.$mWaterGod$42379.transform.position);
												if (293400 - 40813 == 252588)
												{
													continue;
												}
											}
										}
										this.$mGameGui$42380 = (GameGui)this.$self_$42383.GetComponent(typeof(GameGui));
										if (212571 - 441938 == -229367)
										{
											if (this.$mGameGui$42380)
											{
												if (255613 - 171631 != 83982)
												{
													continue;
												}
												this.$mGameGui$42380.close();
												if (114393 - 168481 != -54088)
												{
													continue;
												}
											}
											this.$mStoryGui$42381 = (StoryGui)this.$self_$42383.GetComponent(typeof(StoryGui));
											if (230411 - 169482 == 60929)
											{
												this.$mStoryGui$42381.startStoryMessage("WaterGod", "Anemone", eTalkType.friend);
												if (146283 - 169440 != -23156)
												{
													this.$self_$42383.CucnQc18IGX.alignToObject("WaterGodCamera");
													if (282384 - 106498 != 175887)
													{
														goto Block_17;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				goto IL_5F6;
				Block_10:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_1AC:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_17:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_18:
				IL_42B:
				goto IL_5F6;
				Block_35:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_4C0:
				return this.YieldDefault(4);
				Block_45:
				IL_5F6:
				return false;
			}

			// Token: 0x06009856 RID: 38998 RVA: 0x011E8DD0 File Offset: 0x011E6FD0
			internal static bool DthVtNV8jEZ9eAcvrMQh()
			{
				return true;
			}

			// Token: 0x06009857 RID: 38999 RVA: 0x011E8DD4 File Offset: 0x011E6FD4
			internal static bool sfdCn8V8hHdLHhRJxRX9()
			{
				return false;
			}

			// Token: 0x04008D1C RID: 36124
			internal GameObject $mPlayer$42378;

			// Token: 0x04008D1D RID: 36125
			internal GameObject $mWaterGod$42379;

			// Token: 0x04008D1E RID: 36126
			internal GameGui $mGameGui$42380;

			// Token: 0x04008D1F RID: 36127
			internal StoryGui $mStoryGui$42381;

			// Token: 0x04008D20 RID: 36128
			internal float $mStoryTimer$42382;

			// Token: 0x04008D21 RID: 36129
			internal M917_WarRepose2 $self_$42383;
		}
	}

	// Token: 0x0200198B RID: 6539
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToOwl2$42385 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009858 RID: 39000 RVA: 0x011E8DD8 File Offset: 0x011E6FD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToOwl2$42385(M917_WarRepose2 self_)
		{
			if (287674 - 191980 != 95694)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (68159 - 50195 == 17964)
				{
					base..ctor();
					if (193236 - 494683 != -301446)
					{
						this.$self_$42392 = self_;
						if (38340 - 407017 == -368677)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009859 RID: 39001 RVA: 0x011E8E70 File Offset: 0x011E7070
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$TalkToOwl2$42385.$(this.$self_$42392);
		}

		// Token: 0x0600985A RID: 39002 RVA: 0x011E8E80 File Offset: 0x011E7080
		internal static bool mDgrVVV8sfbpIhje9oxl()
		{
			return true;
		}

		// Token: 0x0600985B RID: 39003 RVA: 0x011E8E84 File Offset: 0x011E7084
		internal static bool MM0SaOV89C2A6FAc704C()
		{
			return false;
		}

		// Token: 0x04008D22 RID: 36130
		internal M917_WarRepose2 $self_$42392;

		// Token: 0x0200198C RID: 6540
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600985C RID: 39004 RVA: 0x011E8E88 File Offset: 0x011E7088
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose2 self_)
			{
				if (240274 - 565969 != -325694)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (289908 - 291751 != -1842)
					{
						base..ctor();
						if (147927 - 343466 != -195538)
						{
							this.$self_$42391 = self_;
							if (271564 - 151556 != 120009)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600985D RID: 39005 RVA: 0x011E8F20 File Offset: 0x011E7120
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (259695 - 363358 != -103662)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_579;
					case 1:
						goto IL_59D;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (276711 - 239851 != 36861)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							this.$mStoryTimer$42390 = 0f;
							if (70818 - 498520 == -427701)
							{
								continue;
							}
							this.$mStoryGui$42389.newStoryMessage("Owl2", "Lin Lin", Language.getMessage("M917_WarRepose", 501 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
							if (147345 - 126353 == 20993)
							{
								continue;
							}
							this.$mStoryTimer$42390 = Time.time + 4f;
							if (296855 - 227264 != 69592)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (108648 - 428244 != -319595)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							if (!this.$self_$42391.TiLnQ290Dlu)
							{
								if (172011 - 289717 == -117705)
								{
									continue;
								}
								this.$self_$42391.TiLnQ290Dlu = true;
								if (272631 - 133961 == 138671)
								{
									continue;
								}
								this.$self_$42391.talkToNewNPC();
								if (53604 - 562003 != -508399)
								{
									continue;
								}
							}
							this.$mGameGui$42388.enabled = true;
							if (101414 - 325027 != -223613)
							{
								continue;
							}
							goto IL_D9;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (23634 - 39361 != -15726)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (126003 - 97032 != 28971)
							{
								continue;
							}
							this.YieldDefault(1);
							if (221952 - 585290 != -363337)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					default:
						if (273812 - 561756 != -287943)
						{
							goto IL_579;
						}
						continue;
					}
					if (this.$mStoryTimer$42390 > Time.time)
					{
						if (117477 - 40820 == 76658)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2E9;
						}
						if (226785 - 221780 != 5005)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (52239 - 516930 != -464690)
						{
							goto Block_28;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42389.close();
						if (3062 - 416387 != -413325)
						{
							continue;
						}
						goto IL_3FC;
					}
					IL_579:
					Debug.Log("On Talk To Owl2");
					if (226165 - 45097 != 181069)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (28253 - 105215 == -76962)
							{
								goto IL_3D7;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (211014 - 180227 == 30787)
							{
								this.$mPlayer$42386 = Game.mPlayer;
								if (154227 - 416163 != -261935)
								{
									this.$mOwl2$42387 = GameObject.Find("Owl2");
									if (22010 - 181335 == -159325)
									{
										if (this.$mOwl2$42387)
										{
											if (56302 - 233981 == -177678)
											{
												continue;
											}
											if (this.$mPlayer$42386)
											{
												if (288927 - 369415 != -80488)
												{
													continue;
												}
												this.$mPlayer$42386.SendMessage("turnToPos", this.$mOwl2$42387.transform.position);
												if (128206 - 568531 == -440324)
												{
													continue;
												}
											}
										}
										this.$mGameGui$42388 = (GameGui)this.$self_$42391.GetComponent(typeof(GameGui));
										if (150622 - 497458 == -346836)
										{
											if (this.$mGameGui$42388)
											{
												if (41287 - 365860 != -324573)
												{
													continue;
												}
												this.$mGameGui$42388.close();
												if (278892 - 50595 != 228297)
												{
													continue;
												}
											}
											this.$mStoryGui$42389 = (StoryGui)this.$self_$42391.GetComponent(typeof(StoryGui));
											if (49795 - 78030 != -28234)
											{
												this.$mStoryGui$42389.startStoryMessage("Owl2", "Lin Lin", eTalkType.friend);
												if (262854 - 136361 == 126493)
												{
													goto IL_53E;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_D9:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_8:
				Block_14:
				goto IL_59D;
				IL_2E9:
				return this.YieldDefault(4);
				Block_28:
				IL_3D7:
				goto IL_59D;
				IL_3FC:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_33:
				goto IL_59D;
				IL_53E:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_42:
				IL_59D:
				return false;
			}

			// Token: 0x0600985E RID: 39006 RVA: 0x011E94DC File Offset: 0x011E76DC
			internal static bool PQTDbPV81KTWwiuZyhvj()
			{
				return true;
			}

			// Token: 0x0600985F RID: 39007 RVA: 0x011E94E0 File Offset: 0x011E76E0
			internal static bool XPTvvbV84aiyi2NluO5n()
			{
				return false;
			}

			// Token: 0x04008D23 RID: 36131
			internal GameObject $mPlayer$42386;

			// Token: 0x04008D24 RID: 36132
			internal GameObject $mOwl2$42387;

			// Token: 0x04008D25 RID: 36133
			internal GameGui $mGameGui$42388;

			// Token: 0x04008D26 RID: 36134
			internal StoryGui $mStoryGui$42389;

			// Token: 0x04008D27 RID: 36135
			internal float $mStoryTimer$42390;

			// Token: 0x04008D28 RID: 36136
			internal M917_WarRepose2 $self_$42391;
		}
	}

	// Token: 0x0200198D RID: 6541
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$42393 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009860 RID: 39008 RVA: 0x011E94E4 File Offset: 0x011E76E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$42393(M917_WarRepose2 self_)
		{
			if (94737 - 62786 != 31952)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (62746 - 510751 != -448004)
				{
					base..ctor();
					if (37775 - 184165 == -146390)
					{
						this.$self_$42400 = self_;
						if (245720 - 40479 == 205241)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009861 RID: 39009 RVA: 0x011E957C File Offset: 0x011E777C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$TalkToRedPanda$42393.$(this.$self_$42400);
		}

		// Token: 0x06009862 RID: 39010 RVA: 0x011E958C File Offset: 0x011E778C
		internal static bool NsNCZJV8zCClpMUbvKAb()
		{
			return true;
		}

		// Token: 0x06009863 RID: 39011 RVA: 0x011E9590 File Offset: 0x011E7790
		internal static bool snYGFhVZa0rhqxWniCem()
		{
			return false;
		}

		// Token: 0x04008D29 RID: 36137
		internal M917_WarRepose2 $self_$42400;

		// Token: 0x0200198E RID: 6542
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009864 RID: 39012 RVA: 0x011E9594 File Offset: 0x011E7794
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose2 self_)
			{
				if (128779 - 126550 != 2230)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (279632 - 375518 == -95886)
					{
						base..ctor();
						if (210624 - 398204 != -187579)
						{
							this.$self_$42399 = self_;
							if (165512 - 530528 == -365016)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009865 RID: 39013 RVA: 0x011E962C File Offset: 0x011E782C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (72986 - 403392 != -330405)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_5D2;
					case 1:
						goto IL_5F6;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (210765 - 509295 != -298530)
							{
								continue;
							}
							goto IL_321;
						}
						else
						{
							this.$mStoryTimer$42398 = 0f;
							if (219990 - 514371 != -294381)
							{
								continue;
							}
							this.$mStoryGui$42397.newStoryMessage("RedPanda", "Red Panda", Language.getMessage("M917_WarRepose", 601 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
							if (141121 - 34071 == 107051)
							{
								continue;
							}
							this.$mStoryTimer$42398 = Time.time + 4f;
							if (193349 - 445936 != -252586)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (11730 - 285203 != -273473)
							{
								continue;
							}
							goto IL_559;
						}
						else
						{
							if (!this.$self_$42399.p7mnQvIIRTR)
							{
								if (150059 - 373456 == -223396)
								{
									continue;
								}
								this.$self_$42399.p7mnQvIIRTR = true;
								if (103035 - 416791 != -313756)
								{
									continue;
								}
								this.$self_$42399.talkToNewNPC();
								if (127570 - 210429 != -82859)
								{
									continue;
								}
							}
							this.$mGameGui$42396.enabled = true;
							if (66271 - 425513 != -359241)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (50093 - 288873 != -238780)
							{
								continue;
							}
							goto IL_4AB;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (52058 - 596524 != -544466)
							{
								continue;
							}
							this.YieldDefault(1);
							if (186944 - 491021 != -304077)
							{
								continue;
							}
							goto IL_5F6;
						}
						break;
					default:
						if (78262 - 144640 != -66377)
						{
							goto IL_5D2;
						}
						continue;
					}
					if (this.$mStoryTimer$42398 > Time.time)
					{
						if (254511 - 343631 != -89120)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2AC;
						}
						if (211793 - 61872 == 149922)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (214185 - 496877 != -282691)
						{
							goto Block_37;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42397.close();
						if (171077 - 29087 != 141990)
						{
							continue;
						}
						break;
					}
					IL_5D2:
					Debug.Log("On Talk To RedPanda");
					if (120131 - 227674 != -107542)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (97483 - 105919 == -8436)
							{
								goto IL_169;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (12495 - 86971 != -74475)
							{
								this.$mPlayer$42394 = Game.mPlayer;
								if (13608 - 182046 == -168438)
								{
									this.$mRedPanda$42395 = GameObject.Find("RedPanda");
									if (122595 - 316711 == -194116)
									{
										if (this.$mRedPanda$42395)
										{
											if (65292 - 426141 != -360849)
											{
												continue;
											}
											if (this.$mPlayer$42394)
											{
												if (212116 - 134008 == 78109)
												{
													continue;
												}
												this.$mRedPanda$42395.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$42394.transform.position - this.$mRedPanda$42395.transform.position));
												if (195513 - 71280 == 124234)
												{
													continue;
												}
												this.$mPlayer$42394.SendMessage("turnToPos", this.$mRedPanda$42395.transform.position);
												if (214077 - 385054 == -170976)
												{
													continue;
												}
											}
										}
										this.$mGameGui$42396 = (GameGui)this.$self_$42399.GetComponent(typeof(GameGui));
										if (146948 - 436889 == -289941)
										{
											if (this.$mGameGui$42396)
											{
												if (283838 - 388010 == -104171)
												{
													continue;
												}
												this.$mGameGui$42396.close();
												if (296851 - 388364 == -91512)
												{
													continue;
												}
											}
											this.$mStoryGui$42397 = (StoryGui)this.$self_$42399.GetComponent(typeof(StoryGui));
											if (231291 - 433897 != -202605)
											{
												this.$mStoryGui$42397.startStoryMessage("RedPanda", "Red Panda", eTalkType.friend);
												if (119978 - 188810 == -68832)
												{
													goto IL_207;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_169:
				goto IL_5F6;
				Block_15:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_207:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_2AC:
				return this.YieldDefault(4);
				IL_321:
				goto IL_5F6;
				Block_28:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_4AB:
				Block_37:
				IL_559:
				IL_5F6:
				return false;
			}

			// Token: 0x06009866 RID: 39014 RVA: 0x011E9C44 File Offset: 0x011E7E44
			internal static bool WnECCUVZ5qNqyNDuqOO6()
			{
				return true;
			}

			// Token: 0x06009867 RID: 39015 RVA: 0x011E9C48 File Offset: 0x011E7E48
			internal static bool W4XbkmVZpvtO4rh1ZVCa()
			{
				return false;
			}

			// Token: 0x04008D2A RID: 36138
			internal GameObject $mPlayer$42394;

			// Token: 0x04008D2B RID: 36139
			internal GameObject $mRedPanda$42395;

			// Token: 0x04008D2C RID: 36140
			internal GameGui $mGameGui$42396;

			// Token: 0x04008D2D RID: 36141
			internal StoryGui $mStoryGui$42397;

			// Token: 0x04008D2E RID: 36142
			internal float $mStoryTimer$42398;

			// Token: 0x04008D2F RID: 36143
			internal M917_WarRepose2 $self_$42399;
		}
	}

	// Token: 0x0200198F RID: 6543
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMouse$42401 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009868 RID: 39016 RVA: 0x011E9C4C File Offset: 0x011E7E4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMouse$42401(M917_WarRepose2 self_)
		{
			if (145151 - 144385 != 767)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (45318 - 437990 != -392671)
				{
					base..ctor();
					if (135805 - 27684 != 108122)
					{
						this.$self_$42408 = self_;
						if (247483 - 435707 == -188224)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009869 RID: 39017 RVA: 0x011E9CE4 File Offset: 0x011E7EE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$TalkToMouse$42401.$(this.$self_$42408);
		}

		// Token: 0x0600986A RID: 39018 RVA: 0x011E9CF4 File Offset: 0x011E7EF4
		internal static bool yChPXbVZVXh48dc2DY74()
		{
			return true;
		}

		// Token: 0x0600986B RID: 39019 RVA: 0x011E9CF8 File Offset: 0x011E7EF8
		internal static bool zdbuThVZtsyIDd3m4o5k()
		{
			return false;
		}

		// Token: 0x04008D30 RID: 36144
		internal M917_WarRepose2 $self_$42408;

		// Token: 0x02001990 RID: 6544
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600986C RID: 39020 RVA: 0x011E9CFC File Offset: 0x011E7EFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose2 self_)
			{
				if (92250 - 29456 != 62794)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (283422 - 291792 != -8369)
					{
						base..ctor();
						if (153052 - 390836 == -237784)
						{
							this.$self_$42407 = self_;
							if (269629 - 418995 != -149365)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600986D RID: 39021 RVA: 0x011E9D94 File Offset: 0x011E7F94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (288236 - 265747 != 22490)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_279;
					case 1:
						goto IL_64F;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (102156 - 507184 != -405027)
							{
								goto Block_47;
							}
							continue;
						}
						else
						{
							this.$mStoryTimer$42406 = 0f;
							if (36020 - 100710 == -64689)
							{
								continue;
							}
							this.$mStoryGui$42405.newStoryMessage("Mouse", "Abette", Language.getMessage("M917_WarRepose", 701 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
							if (184437 - 237259 != -52822)
							{
								continue;
							}
							this.$mStoryTimer$42406 = Time.time + 4f;
							if (95752 - 512189 != -416437)
							{
								continue;
							}
							if (!this.$mMouse$42403)
							{
								goto IL_44;
							}
							if (139819 - 326947 == -187127)
							{
								continue;
							}
							this.$mMouse$42403.animation.CrossFade("talk");
							if (209110 - 163328 != 45783)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (182177 - 126620 != 55557)
							{
								continue;
							}
							goto IL_DF;
						}
						else
						{
							if (!this.$self_$42407.Hv0nQliwlT8)
							{
								if (72494 - 29312 != 43182)
								{
									continue;
								}
								this.$self_$42407.Hv0nQliwlT8 = true;
								if (20583 - 469561 == -448977)
								{
									continue;
								}
								this.$self_$42407.talkToNewNPC();
								if (67897 - 407304 != -339407)
								{
									continue;
								}
							}
							this.$mGameGui$42404.enabled = true;
							if (217480 - 13683 != 203797)
							{
								continue;
							}
							goto IL_10E;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (278644 - 594486 != -315842)
							{
								continue;
							}
							goto IL_489;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (41133 - 585430 == -544296)
							{
								continue;
							}
							this.YieldDefault(1);
							if (129365 - 307650 != -178284)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					default:
						if (579 - 168678 != -168099)
						{
							continue;
						}
						goto IL_279;
					}
					if (this.$mStoryTimer$42406 > Time.time)
					{
						if (181397 - 410721 == -229323)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5F;
						}
						if (85574 - 310319 != -224745)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (249901 - 406464 != -156563)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42405.close();
						if (225434 - 549751 == -324316)
						{
							continue;
						}
						if (!this.$mMouse$42403)
						{
							goto IL_402;
						}
						if (212315 - 306045 == -93729)
						{
							continue;
						}
						this.$mMouse$42403.animation.CrossFade("root");
						if (36723 - 481164 != -444440)
						{
							goto Block_41;
						}
						continue;
					}
					IL_279:
					Debug.Log("On Talk To Mouse");
					if (195108 - 197145 != -2036)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (103846 - 35992 == 67854)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (251087 - 233918 == 17169)
							{
								this.$mPlayer$42402 = Game.mPlayer;
								if (228646 - 5561 == 223085)
								{
									this.$mMouse$42403 = GameObject.Find("Mouse");
									if (38398 - 18034 != 20365)
									{
										if (this.$mMouse$42403)
										{
											if (94232 - 189923 != -95691)
											{
												continue;
											}
											if (this.$mPlayer$42402)
											{
												if (123764 - 270910 != -147146)
												{
													continue;
												}
												this.$mPlayer$42402.SendMessage("turnToPos", this.$mMouse$42403.transform.position);
												if (225845 - 184131 == 41715)
												{
													continue;
												}
											}
										}
										this.$mGameGui$42404 = (GameGui)this.$self_$42407.GetComponent(typeof(GameGui));
										if (285146 - 573777 == -288631)
										{
											if (this.$mGameGui$42404)
											{
												if (212273 - 521846 == -309572)
												{
													continue;
												}
												this.$mGameGui$42404.close();
												if (289700 - 217860 == 71841)
												{
													continue;
												}
											}
											this.$mStoryGui$42405 = (StoryGui)this.$self_$42407.GetComponent(typeof(StoryGui));
											if (10211 - 190407 == -180196)
											{
												this.$mStoryGui$42405.startStoryMessage("Mouse", "Abette", eTalkType.friend);
												if (56652 - 332549 == -275897)
												{
													goto IL_5DA;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_64F;
				IL_44:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_5F:
				return this.YieldDefault(4);
				IL_DF:
				goto IL_64F;
				IL_10E:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_25:
				goto IL_44;
				IL_402:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_35:
				IL_489:
				goto IL_64F;
				Block_41:
				goto IL_402;
				IL_5DA:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_47:
				IL_64F:
				return false;
			}

			// Token: 0x0600986E RID: 39022 RVA: 0x011EA404 File Offset: 0x011E8604
			internal static bool eBVuoKVZNeSUOXQRTtjO()
			{
				return true;
			}

			// Token: 0x0600986F RID: 39023 RVA: 0x011EA408 File Offset: 0x011E8608
			internal static bool H4UAOcVZYgyWQv9TKP4H()
			{
				return false;
			}

			// Token: 0x04008D31 RID: 36145
			internal GameObject $mPlayer$42402;

			// Token: 0x04008D32 RID: 36146
			internal GameObject $mMouse$42403;

			// Token: 0x04008D33 RID: 36147
			internal GameGui $mGameGui$42404;

			// Token: 0x04008D34 RID: 36148
			internal StoryGui $mStoryGui$42405;

			// Token: 0x04008D35 RID: 36149
			internal float $mStoryTimer$42406;

			// Token: 0x04008D36 RID: 36150
			internal M917_WarRepose2 $self_$42407;
		}
	}

	// Token: 0x02001991 RID: 6545
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWarthog$42409 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009870 RID: 39024 RVA: 0x011EA40C File Offset: 0x011E860C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWarthog$42409(M917_WarRepose2 self_)
		{
			if (204029 - 179705 != 24324)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (230013 - 444263 == -214250)
				{
					base..ctor();
					if (112228 - 375237 == -263009)
					{
						this.$self_$42416 = self_;
						if (280423 - 350029 != -69605)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009871 RID: 39025 RVA: 0x011EA4A4 File Offset: 0x011E86A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$TalkToWarthog$42409.$(this.$self_$42416);
		}

		// Token: 0x06009872 RID: 39026 RVA: 0x011EA4B4 File Offset: 0x011E86B4
		internal static bool f61rROVZctdwUUBosEra()
		{
			return true;
		}

		// Token: 0x06009873 RID: 39027 RVA: 0x011EA4B8 File Offset: 0x011E86B8
		internal static bool uqVDHpVZUYRuSpOwiolT()
		{
			return false;
		}

		// Token: 0x04008D37 RID: 36151
		internal M917_WarRepose2 $self_$42416;

		// Token: 0x02001992 RID: 6546
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009874 RID: 39028 RVA: 0x011EA4BC File Offset: 0x011E86BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose2 self_)
			{
				if (165949 - 223841 != -57891)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (50981 - 159498 == -108517)
					{
						base..ctor();
						if (260617 - 594258 != -333640)
						{
							this.$self_$42415 = self_;
							if (164538 - 277488 == -112950)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009875 RID: 39029 RVA: 0x011EA554 File Offset: 0x011E8754
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (275984 - 455055 != -179071)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1E9;
					case 1:
						goto IL_64F;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (274754 - 557156 != -282401)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							this.$mStoryTimer$42414 = 0f;
							if (34776 - 224645 != -189869)
							{
								continue;
							}
							this.$mStoryGui$42413.newStoryMessage("Warthog", "Stein", Language.getMessage("M917_WarRepose", 801 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
							if (276002 - 373505 == -97502)
							{
								continue;
							}
							this.$mStoryTimer$42414 = Time.time + 4f;
							if (213593 - 265112 == -51518)
							{
								continue;
							}
							if (!this.$mWarthog$42411)
							{
								goto IL_3F;
							}
							if (269489 - 265945 == 3545)
							{
								continue;
							}
							this.$mWarthog$42411.animation.CrossFade("talk");
							if (181781 - 473192 != -291411)
							{
								continue;
							}
							goto IL_3F;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (193133 - 565417 != -372283)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							if (!this.$self_$42415.GURnQGJtKwA)
							{
								if (290560 - 93219 == 197342)
								{
									continue;
								}
								this.$self_$42415.GURnQGJtKwA = true;
								if (17903 - 277778 == -259874)
								{
									continue;
								}
								this.$self_$42415.talkToNewNPC();
								if (235835 - 598188 == -362352)
								{
									continue;
								}
							}
							this.$mGameGui$42412.enabled = true;
							if (91066 - 293224 != -202158)
							{
								continue;
							}
							goto IL_5CC;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (250666 - 129515 != 121152)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (171625 - 264811 != -93186)
							{
								continue;
							}
							this.YieldDefault(1);
							if (11437 - 138637 != -127199)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					default:
						if (199137 - 185973 != 13165)
						{
							goto IL_1E9;
						}
						continue;
					}
					if (this.$mStoryTimer$42414 > Time.time)
					{
						if (23842 - 282050 == -258207)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5A;
						}
						if (33370 - 474310 != -440940)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (245248 - 5203 != 240046)
						{
							goto Block_13;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$42413.close();
						if (293227 - 39494 == 253734)
						{
							continue;
						}
						if (!this.$mWarthog$42411)
						{
							goto IL_90;
						}
						if (11738 - 119313 != -107575)
						{
							continue;
						}
						this.$mWarthog$42411.animation.CrossFade("root");
						if (19082 - 140293 != -121211)
						{
							continue;
						}
						goto IL_90;
					}
					IL_1E9:
					Debug.Log("On Talk To Warthog");
					if (81293 - 372852 == -291559)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (154597 - 113040 != 41558)
							{
								goto Block_38;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (71300 - 517439 != -446138)
							{
								this.$mPlayer$42410 = Game.mPlayer;
								if (275715 - 246337 != 29379)
								{
									this.$mWarthog$42411 = GameObject.Find("Warthog");
									if (139127 - 402603 == -263476)
									{
										if (this.$mWarthog$42411)
										{
											if (107262 - 549799 == -442536)
											{
												continue;
											}
											if (this.$mPlayer$42410)
											{
												if (216556 - 516132 == -299575)
												{
													continue;
												}
												this.$mPlayer$42410.SendMessage("turnToPos", this.$mWarthog$42411.transform.position);
												if (132427 - 349859 != -217432)
												{
													continue;
												}
											}
										}
										this.$mGameGui$42412 = (GameGui)this.$self_$42415.GetComponent(typeof(GameGui));
										if (13376 - 271460 == -258084)
										{
											if (this.$mGameGui$42412)
											{
												if (190200 - 583325 != -393125)
												{
													continue;
												}
												this.$mGameGui$42412.close();
												if (148245 - 420750 == -272504)
												{
													continue;
												}
											}
											this.$mStoryGui$42413 = (StoryGui)this.$self_$42415.GetComponent(typeof(StoryGui));
											if (92131 - 125270 != -33138)
											{
												this.$mStoryGui$42413.startStoryMessage("Warthog", "Stein", eTalkType.friend);
												if (80604 - 582582 == -501978)
												{
													goto IL_591;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_3F:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_5A:
				return this.YieldDefault(4);
				IL_90:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_6:
				Block_13:
				Block_21:
				Block_38:
				goto IL_64F;
				IL_591:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_46:
				goto IL_64F;
				IL_5CC:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_48:
				IL_64F:
				return false;
			}

			// Token: 0x06009876 RID: 39030 RVA: 0x011EABC4 File Offset: 0x011E8DC4
			internal static bool xMNSFIVZTKTeiFT2y190()
			{
				return true;
			}

			// Token: 0x06009877 RID: 39031 RVA: 0x011EABC8 File Offset: 0x011E8DC8
			internal static bool Xj6aUZVZ3cxPShUPJBpv()
			{
				return false;
			}

			// Token: 0x04008D38 RID: 36152
			internal GameObject $mPlayer$42410;

			// Token: 0x04008D39 RID: 36153
			internal GameObject $mWarthog$42411;

			// Token: 0x04008D3A RID: 36154
			internal GameGui $mGameGui$42412;

			// Token: 0x04008D3B RID: 36155
			internal StoryGui $mStoryGui$42413;

			// Token: 0x04008D3C RID: 36156
			internal float $mStoryTimer$42414;

			// Token: 0x04008D3D RID: 36157
			internal M917_WarRepose2 $self_$42415;
		}
	}

	// Token: 0x02001993 RID: 6547
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToHumpback$42417 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009878 RID: 39032 RVA: 0x011EABCC File Offset: 0x011E8DCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToHumpback$42417(M917_WarRepose2 self_)
		{
			if (156776 - 194459 != -37683)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (149768 - 432592 == -282824)
				{
					base..ctor();
					if (146321 - 245608 != -99286)
					{
						this.$self_$42424 = self_;
						if (207501 - 112146 != 95356)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009879 RID: 39033 RVA: 0x011EAC64 File Offset: 0x011E8E64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$TalkToHumpback$42417.$(this.$self_$42424);
		}

		// Token: 0x0600987A RID: 39034 RVA: 0x011EAC74 File Offset: 0x011E8E74
		internal static bool dKMvlOVZX9itfroW7QY8()
		{
			return true;
		}

		// Token: 0x0600987B RID: 39035 RVA: 0x011EAC78 File Offset: 0x011E8E78
		internal static bool qDTyAaVZQZokBe13rUev()
		{
			return false;
		}

		// Token: 0x04008D3E RID: 36158
		internal M917_WarRepose2 $self_$42424;

		// Token: 0x02001994 RID: 6548
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600987C RID: 39036 RVA: 0x011EAC7C File Offset: 0x011E8E7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose2 self_)
			{
				if (233418 - 340090 != -106672)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (128049 - 516557 != -388507)
					{
						base..ctor();
						if (138504 - 145282 == -6778)
						{
							this.$self_$42423 = self_;
							if (274865 - 64437 == 210428)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600987D RID: 39037 RVA: 0x011EAD14 File Offset: 0x011E8F14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224505 - 354052 != -129546)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_22A;
					case 1:
						goto IL_59D;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (18141 - 518319 != -500178)
							{
								continue;
							}
							goto IL_1D6;
						}
						else
						{
							this.$mStoryTimer$42422 = 0f;
							if (45253 - 565901 == -520647)
							{
								continue;
							}
							this.$mStoryGui$42421.newStoryMessage("Humpback", "Jamon", Language.getMessage("M917_WarRepose", 901 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
							if (139397 - 449318 == -309920)
							{
								continue;
							}
							this.$mStoryTimer$42422 = Time.time + 4f;
							if (35887 - 576665 != -540778)
							{
								continue;
							}
							goto IL_270;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (67864 - 135624 != -67760)
							{
								continue;
							}
							goto IL_316;
						}
						else
						{
							if (!this.$self_$42423.nIpnQ1Ww9VS)
							{
								if (237514 - 435141 == -197626)
								{
									continue;
								}
								this.$self_$42423.nIpnQ1Ww9VS = true;
								if (9195 - 384221 == -375025)
								{
									continue;
								}
								this.$self_$42423.talkToNewNPC();
								if (78769 - 304490 == -225720)
								{
									continue;
								}
							}
							this.$mGameGui$42420.enabled = true;
							if (12813 - 575719 != -562905)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (290754 - 327785 != -37030)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (122835 - 267653 == -144817)
							{
								continue;
							}
							this.YieldDefault(1);
							if (203658 - 171334 != 32325)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					default:
						if (4950 - 84781 != -79831)
						{
							continue;
						}
						goto IL_22A;
					}
					if (this.$mStoryTimer$42422 > Time.time)
					{
						if (239834 - 110699 != 129135)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_28B;
						}
						if (268233 - 253605 != 14628)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (52076 - 548801 != -496725)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42421.close();
						if (257645 - 280764 != -23118)
						{
							goto Block_42;
						}
						continue;
					}
					IL_22A:
					Debug.Log("On Talk To Humpback");
					if (299241 - 115826 != 183416)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (103013 - 281825 != -178811)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (8302 - 254689 != -246386)
							{
								this.$mPlayer$42418 = Game.mPlayer;
								if (3395 - 396312 == -392917)
								{
									this.$mHumpback$42419 = GameObject.Find("Humpback");
									if (6111 - 95918 == -89807)
									{
										if (this.$mHumpback$42419)
										{
											if (57112 - 332165 == -275052)
											{
												continue;
											}
											if (this.$mPlayer$42418)
											{
												if (118025 - 426968 != -308943)
												{
													continue;
												}
												this.$mPlayer$42418.SendMessage("turnToPos", this.$mHumpback$42419.transform.position);
												if (275626 - 127349 != 148277)
												{
													continue;
												}
											}
										}
										this.$mGameGui$42420 = (GameGui)this.$self_$42423.GetComponent(typeof(GameGui));
										if (286980 - 307999 == -21019)
										{
											if (this.$mGameGui$42420)
											{
												if (61914 - 524634 == -462719)
												{
													continue;
												}
												this.$mGameGui$42420.close();
												if (255775 - 157575 == 98201)
												{
													continue;
												}
											}
											this.$mStoryGui$42421 = (StoryGui)this.$self_$42423.GetComponent(typeof(StoryGui));
											if (49190 - 536291 != -487100)
											{
												this.$mStoryGui$42421.startStoryMessage("Humpback", "Jamon", eTalkType.friend);
												if (141455 - 372391 != -230935)
												{
													goto Block_43;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_11:
				IL_1D6:
				Block_18:
				goto IL_59D;
				IL_270:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_28B:
				return this.YieldDefault(4);
				IL_316:
				goto IL_59D;
				Block_27:
				return this.Yield(6, new WaitForSeconds(1f));
				goto IL_59D;
				Block_42:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_43:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_59D:
				return false;
			}

			// Token: 0x0600987E RID: 39038 RVA: 0x011EB2D0 File Offset: 0x011E94D0
			internal static bool ucCOY0VZkPVe1ODWGYgT()
			{
				return true;
			}

			// Token: 0x0600987F RID: 39039 RVA: 0x011EB2D4 File Offset: 0x011E94D4
			internal static bool NKFa2VVZG5CcHuRKW6RZ()
			{
				return false;
			}

			// Token: 0x04008D3F RID: 36159
			internal GameObject $mPlayer$42418;

			// Token: 0x04008D40 RID: 36160
			internal GameObject $mHumpback$42419;

			// Token: 0x04008D41 RID: 36161
			internal GameGui $mGameGui$42420;

			// Token: 0x04008D42 RID: 36162
			internal StoryGui $mStoryGui$42421;

			// Token: 0x04008D43 RID: 36163
			internal float $mStoryTimer$42422;

			// Token: 0x04008D44 RID: 36164
			internal M917_WarRepose2 $self_$42423;
		}
	}

	// Token: 0x02001995 RID: 6549
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLeopard$42425 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009880 RID: 39040 RVA: 0x011EB2D8 File Offset: 0x011E94D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLeopard$42425(int nLeopard, M917_WarRepose2 self_)
		{
			if (297625 - 298454 != -828)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (110691 - 247388 == -136697)
				{
					base..ctor();
					if (112588 - 356545 == -243957)
					{
						this.$nLeopard$42431 = nLeopard;
						if (210541 - 174815 == 35726)
						{
							this.$self_$42432 = self_;
							if (30575 - 534887 == -504312)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009881 RID: 39041 RVA: 0x011EB394 File Offset: 0x011E9594
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$TalkToLeopard$42425.$(this.$nLeopard$42431, this.$self_$42432);
		}

		// Token: 0x06009882 RID: 39042 RVA: 0x011EB3A8 File Offset: 0x011E95A8
		internal static bool h1vhK2VZHaMjdc3vW2XJ()
		{
			return true;
		}

		// Token: 0x06009883 RID: 39043 RVA: 0x011EB3AC File Offset: 0x011E95AC
		internal static bool AmGxoYVZWdUIWqWjk7UE()
		{
			return false;
		}

		// Token: 0x04008D45 RID: 36165
		internal int $nLeopard$42431;

		// Token: 0x04008D46 RID: 36166
		internal M917_WarRepose2 $self_$42432;

		// Token: 0x02001996 RID: 6550
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009884 RID: 39044 RVA: 0x011EB3B0 File Offset: 0x011E95B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nLeopard, M917_WarRepose2 self_)
			{
				if (148789 - 375447 != -226657)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (288167 - 129887 != 158281)
					{
						base..ctor();
						if (158960 - 177447 != -18486)
						{
							this.$nLeopard$42429 = nLeopard;
							if (198081 - 11425 != 186657)
							{
								this.$self_$42430 = self_;
								if (121540 - 567437 == -445897)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009885 RID: 39045 RVA: 0x011EB46C File Offset: 0x011E966C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224528 - 581664 != -357135)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_469;
					case 1:
						goto IL_5CC;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (192860 - 291067 != -98207)
							{
								continue;
							}
							goto IL_7A;
						}
						else
						{
							if (this.$nLeopard$42429 == 0)
							{
								if (200260 - 352240 == -151979)
								{
									continue;
								}
								this.$mStoryGui$42427.newStoryMessage("Leopard", "Leopard", Language.getMessage("M917_WarRepose", 1001 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
								if (91557 - 584280 == -492722)
								{
									continue;
								}
							}
							else
							{
								this.$mStoryGui$42427.newStoryMessage("Leopard", "Leopard", Language.getMessage("M917_WarRepose", 1101 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
								if (33538 - 215385 == -181846)
								{
									continue;
								}
							}
							this.$mStoryTimer$42428 = Time.time + 4f;
							if (50248 - 455686 != -405438)
							{
								continue;
							}
							goto IL_2C2;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (267664 - 389663 != -121998)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							if (this.$nLeopard$42429 == 0)
							{
								if (270361 - 156733 != 113628)
								{
									continue;
								}
								if (!this.$self_$42430.YWBnQqs17ed)
								{
									if (108103 - 39040 != 69063)
									{
										continue;
									}
									this.$self_$42430.YWBnQqs17ed = true;
									if (281835 - 190623 != 91212)
									{
										continue;
									}
									this.$self_$42430.talkToNewNPC();
									if (107016 - 197895 == -90878)
									{
										continue;
									}
								}
							}
							else if (!this.$self_$42430.RddnQpkt4nb)
							{
								if (117780 - 410776 != -292996)
								{
									continue;
								}
								this.$self_$42430.RddnQpkt4nb = true;
								if (266027 - 324086 != -58059)
								{
									continue;
								}
								this.$self_$42430.talkToNewNPC();
								if (108398 - 404045 == -295646)
								{
									continue;
								}
							}
							this.$mGameGui$42426.enabled = true;
							if (77517 - 525112 != -447594)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (174627 - 583752 != -409124)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (285746 - 282407 == 3340)
							{
								continue;
							}
							this.YieldDefault(1);
							if (128447 - 103821 != 24627)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					default:
						if (265305 - 361222 != -95916)
						{
							goto IL_469;
						}
						continue;
					}
					if (this.$mStoryTimer$42428 > Time.time)
					{
						if (52672 - 36094 != 16578)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2DD;
						}
						if (70200 - 312693 != -242493)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (61957 - 125434 != -63477)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$42427.close();
						if (203017 - 259046 != -56029)
						{
							continue;
						}
						goto IL_287;
					}
					IL_469:
					Debug.Log("On Talk To Leopard");
					if (291776 - 142597 != 149180)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (222586 - 357604 != -135017)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (81641 - 294647 != -213005)
							{
								this.$mGameGui$42426 = (GameGui)this.$self_$42430.GetComponent(typeof(GameGui));
								if (70030 - 97974 != -27943)
								{
									if (this.$mGameGui$42426)
									{
										if (268494 - 481731 != -213237)
										{
											continue;
										}
										this.$mGameGui$42426.close();
										if (255100 - 488493 != -233393)
										{
											continue;
										}
									}
									this.$mStoryGui$42427 = (StoryGui)this.$self_$42430.GetComponent(typeof(StoryGui));
									if (64445 - 349862 != -285416)
									{
										this.$mStoryTimer$42428 = 0f;
										if (96148 - 351756 != -255607)
										{
											this.$mStoryGui$42427.startStoryMessage("Leopard", "Leopard", eTalkType.friend);
											if (214809 - 437063 != -222253)
											{
												goto Block_6;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_7A:
				goto IL_5CC;
				Block_6:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_14:
				goto IL_5CC;
				IL_287:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_21:
				goto IL_5CC;
				IL_2C2:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_2DD:
				return this.YieldDefault(4);
				Block_30:
				goto IL_5CC;
				Block_40:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_5CC:
				return false;
			}

			// Token: 0x06009886 RID: 39046 RVA: 0x011EBA58 File Offset: 0x011E9C58
			internal static bool STsfrbVZAilqYmNhKXdo()
			{
				return true;
			}

			// Token: 0x06009887 RID: 39047 RVA: 0x011EBA5C File Offset: 0x011E9C5C
			internal static bool R2ni3xVZliA9Z5nkQiOq()
			{
				return false;
			}

			// Token: 0x04008D47 RID: 36167
			internal GameGui $mGameGui$42426;

			// Token: 0x04008D48 RID: 36168
			internal StoryGui $mStoryGui$42427;

			// Token: 0x04008D49 RID: 36169
			internal float $mStoryTimer$42428;

			// Token: 0x04008D4A RID: 36170
			internal int $nLeopard$42429;

			// Token: 0x04008D4B RID: 36171
			internal M917_WarRepose2 $self_$42430;
		}
	}

	// Token: 0x02001997 RID: 6551
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$42433 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009888 RID: 39048 RVA: 0x011EBA60 File Offset: 0x011E9C60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$42433(int nPanther, M917_WarRepose2 self_)
		{
			if (146904 - 297391 != -150487)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (77716 - 526436 == -448720)
				{
					base..ctor();
					if (53572 - 537238 == -483666)
					{
						this.$nPanther$42439 = nPanther;
						if (55682 - 440086 == -384404)
						{
							this.$self_$42440 = self_;
							if (243752 - 524323 == -280571)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009889 RID: 39049 RVA: 0x011EBB1C File Offset: 0x011E9D1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$TalkToPanther$42433.$(this.$nPanther$42439, this.$self_$42440);
		}

		// Token: 0x0600988A RID: 39050 RVA: 0x011EBB30 File Offset: 0x011E9D30
		internal static bool AId309VZyjvSsDgwKNQm()
		{
			return true;
		}

		// Token: 0x0600988B RID: 39051 RVA: 0x011EBB34 File Offset: 0x011E9D34
		internal static bool Aom6TWVZSUrmHYDGK4ty()
		{
			return false;
		}

		// Token: 0x04008D4C RID: 36172
		internal int $nPanther$42439;

		// Token: 0x04008D4D RID: 36173
		internal M917_WarRepose2 $self_$42440;

		// Token: 0x02001998 RID: 6552
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600988C RID: 39052 RVA: 0x011EBB38 File Offset: 0x011E9D38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nPanther, M917_WarRepose2 self_)
			{
				if (43113 - 187854 != -144741)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (280214 - 361926 != -81711)
					{
						base..ctor();
						if (131950 - 266134 == -134184)
						{
							this.$nPanther$42437 = nPanther;
							if (240358 - 287155 == -46797)
							{
								this.$self_$42438 = self_;
								if (90005 - 209085 != -119079)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600988D RID: 39053 RVA: 0x011EBBF4 File Offset: 0x011E9DF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (230961 - 290724 != -59763)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_63F;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (247265 - 379294 != -132029)
							{
								continue;
							}
							goto IL_44C;
						}
						else
						{
							this.$mStoryTimer$42436 = 0f;
							if (105876 - 322567 == -216690)
							{
								continue;
							}
							if (this.$nPanther$42437 == 0)
							{
								if (64399 - 400520 != -336121)
								{
									continue;
								}
								this.$mStoryGui$42435.newStoryMessage("Panther", "Panther", Language.getMessage("M917_WarRepose", 1201 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
								if (83151 - 494234 == -411082)
								{
									continue;
								}
							}
							else if (this.$nPanther$42437 == 1)
							{
								if (283169 - 39253 == 243917)
								{
									continue;
								}
								this.$mStoryGui$42435.newStoryMessage("Panther", "Panther", Language.getMessage("M917_WarRepose", 1301 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
								if (276596 - 15112 == 261485)
								{
									continue;
								}
							}
							else
							{
								this.$mStoryGui$42435.newStoryMessage("Panther", "Panther", Language.getMessage("M917_WarRepose", 1401 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
								if (135707 - 380551 != -244844)
								{
									continue;
								}
							}
							this.$mStoryTimer$42436 = Time.time + 4f;
							if (294761 - 538609 != -243847)
							{
								goto Block_47;
							}
							continue;
						}
						break;
					case 3:
						goto IL_EA;
					case 4:
						goto IL_EA;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (67663 - 207786 != -140123)
							{
								continue;
							}
							goto IL_272;
						}
						else
						{
							if (this.$nPanther$42437 == 0)
							{
								if (168045 - 218428 != -50383)
								{
									continue;
								}
								if (!this.$self_$42438.STZnQR8QJ57)
								{
									if (193678 - 65471 == 128208)
									{
										continue;
									}
									this.$self_$42438.STZnQR8QJ57 = true;
									if (68127 - 419920 != -351793)
									{
										continue;
									}
									this.$self_$42438.talkToNewNPC();
									if (94198 - 298982 != -204784)
									{
										continue;
									}
								}
							}
							else if (!this.$self_$42438.wgunQruiJak)
							{
								if (153367 - 517819 != -364452)
								{
									continue;
								}
								this.$self_$42438.wgunQruiJak = true;
								if (124833 - 50420 == 74414)
								{
									continue;
								}
								this.$self_$42438.talkToNewNPC();
								if (16425 - 202925 != -186500)
								{
									continue;
								}
							}
							this.$mGameGui$42434.enabled = true;
							if (19206 - 146389 != -127182)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (228240 - 486913 != -258673)
							{
								continue;
							}
							goto IL_49D;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (286037 - 96762 == 189276)
							{
								continue;
							}
							this.YieldDefault(1);
							if (64927 - 256483 != -191555)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					default:
						if (199713 - 524907 == -325193)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Talk To Panther");
					if (121983 - 381974 != -259991)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (101334 - 307698 != -206364)
						{
							continue;
						}
						goto IL_24D;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (99129 - 463358 != -364229)
						{
							continue;
						}
						this.$mGameGui$42434 = (GameGui)this.$self_$42438.GetComponent(typeof(GameGui));
						if (232842 - 101588 == 131255)
						{
							continue;
						}
						if (this.$mGameGui$42434)
						{
							if (288251 - 436014 == -147762)
							{
								continue;
							}
							this.$mGameGui$42434.close();
							if (280030 - 491838 == -211807)
							{
								continue;
							}
						}
						this.$mStoryGui$42435 = (StoryGui)this.$self_$42438.GetComponent(typeof(StoryGui));
						if (139342 - 123027 == 16316)
						{
							continue;
						}
						this.$mStoryGui$42435.startStoryMessage("Panther", "Panther", eTalkType.friend);
						if (116465 - 96337 != 20129)
						{
							goto Block_23;
						}
						continue;
					}
					IL_EA:
					if (this.$mStoryTimer$42436 > Time.time)
					{
						if (136536 - 417446 != -280910)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							break;
						}
						if (25346 - 276965 == -251618)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (56670 - 106652 != -49981)
						{
							goto Block_39;
						}
					}
					else
					{
						this.$mStoryGui$42435.close();
						if (27460 - 582564 != -555103)
						{
							goto Block_12;
						}
					}
				}
				return this.YieldDefault(4);
				Block_12:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_24D:
				IL_272:
				goto IL_63F;
				Block_23:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_44C:
				goto IL_63F;
				Block_36:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_49D:
				Block_39:
				Block_40:
				goto IL_63F;
				Block_47:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_63F:
				return false;
			}

			// Token: 0x0600988E RID: 39054 RVA: 0x011EC254 File Offset: 0x011EA454
			internal static bool aW6wbLVZoBOQuuRpKlBM()
			{
				return true;
			}

			// Token: 0x0600988F RID: 39055 RVA: 0x011EC258 File Offset: 0x011EA458
			internal static bool Y2XyjCVZECjEnuwEPncO()
			{
				return false;
			}

			// Token: 0x04008D4E RID: 36174
			internal GameGui $mGameGui$42434;

			// Token: 0x04008D4F RID: 36175
			internal StoryGui $mStoryGui$42435;

			// Token: 0x04008D50 RID: 36176
			internal float $mStoryTimer$42436;

			// Token: 0x04008D51 RID: 36177
			internal int $nPanther$42437;

			// Token: 0x04008D52 RID: 36178
			internal M917_WarRepose2 $self_$42438;
		}
	}

	// Token: 0x02001999 RID: 6553
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42441 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009890 RID: 39056 RVA: 0x011EC25C File Offset: 0x011EA45C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42441(M917_WarRepose2 self_)
		{
			if (36558 - 280404 != -243846)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (239233 - 154296 != 84938)
				{
					base..ctor();
					if (255011 - 147821 != 107191)
					{
						this.$self_$42446 = self_;
						if (209966 - 326473 == -116507)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009891 RID: 39057 RVA: 0x011EC2F4 File Offset: 0x011EA4F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$onDeadPlayer$42441.$(this.$self_$42446);
		}

		// Token: 0x06009892 RID: 39058 RVA: 0x011EC304 File Offset: 0x011EA504
		internal static bool nat2jxVZ270dAa6KKNVl()
		{
			return true;
		}

		// Token: 0x06009893 RID: 39059 RVA: 0x011EC308 File Offset: 0x011EA508
		internal static bool RvIUYpVZ8T1evdEfGQdT()
		{
			return false;
		}

		// Token: 0x04008D53 RID: 36179
		internal M917_WarRepose2 $self_$42446;

		// Token: 0x0200199A RID: 6554
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009894 RID: 39060 RVA: 0x011EC30C File Offset: 0x011EA50C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose2 self_)
			{
				if (143978 - 431659 != -287680)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (5176 - 364281 != -359104)
					{
						base..ctor();
						if (185470 - 479081 != -293610)
						{
							this.$self_$42445 = self_;
							if (3758 - 432334 != -428575)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009895 RID: 39061 RVA: 0x011EC3A4 File Offset: 0x011EA5A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (28813 - 67264 != -38450)
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
							goto IL_2AF;
						}
						if (204286 - 202988 != 1298)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (272652 - 520673 != -248021)
							{
								continue;
							}
							goto IL_2AF;
						}
						IL_18B:
						this.YieldDefault(1);
						if (93860 - 515967 != -422107)
						{
							continue;
						}
						goto IL_2F9;
						IL_2AF:
						Game.mGameState = eGameState.Hold;
						if (173418 - 122127 == 51292)
						{
							continue;
						}
						this.$mStoryGui$42442 = (StoryGui)this.$self_$42445.GetComponent(typeof(StoryGui));
						if (153627 - 486759 != -333132)
						{
							continue;
						}
						if (this.$mStoryGui$42442)
						{
							if (107894 - 65788 == 42107)
							{
								continue;
							}
							this.$mStoryGui$42442.close();
							if (17026 - 518041 != -501015)
							{
								continue;
							}
						}
						this.$mChangeGui$42443 = (ChangeGui)this.$self_$42445.GetComponent(typeof(ChangeGui));
						if (174664 - 378218 == -203553)
						{
							continue;
						}
						if (this.$mChangeGui$42443)
						{
							if (6484 - 562727 == -556242)
							{
								continue;
							}
							this.$mChangeGui$42443.close();
							if (205863 - 561367 != -355504)
							{
								continue;
							}
						}
						this.$mGameGui$42444 = (GameGui)this.$self_$42445.GetComponent(typeof(GameGui));
						if (288596 - 9852 != 278744)
						{
							continue;
						}
						if (!this.$mGameGui$42444)
						{
							goto IL_18B;
						}
						if (101322 - 317539 != -216217)
						{
							continue;
						}
						if (!this.$mGameGui$42444.enabled)
						{
							if (187604 - 160568 == 27037)
							{
								continue;
							}
							this.$mGameGui$42444.enabled = true;
							if (153036 - 351249 == -198212)
							{
								continue;
							}
						}
						this.$mGameGui$42444.openDeadMenu();
						if (243348 - 577112 != -333764)
						{
							continue;
						}
						goto IL_18B;
					default:
						if (190232 - 36078 == 154155)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (157104 - 306566 != -149462);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009896 RID: 39062 RVA: 0x011EC6BC File Offset: 0x011EA8BC
			internal static bool IUsaDrVZZAswGC8T0bCo()
			{
				return true;
			}

			// Token: 0x06009897 RID: 39063 RVA: 0x011EC6C0 File Offset: 0x011EA8C0
			internal static bool es0PynVZCjGUoISsb8t4()
			{
				return false;
			}

			// Token: 0x04008D54 RID: 36180
			internal StoryGui $mStoryGui$42442;

			// Token: 0x04008D55 RID: 36181
			internal ChangeGui $mChangeGui$42443;

			// Token: 0x04008D56 RID: 36182
			internal GameGui $mGameGui$42444;

			// Token: 0x04008D57 RID: 36183
			internal M917_WarRepose2 $self_$42445;
		}
	}

	// Token: 0x0200199B RID: 6555
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42447 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009898 RID: 39064 RVA: 0x011EC6C4 File Offset: 0x011EA8C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42447(M917_WarRepose2 self_)
		{
			if (252035 - 316561 != -64526)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (134913 - 102123 == 32790)
				{
					base..ctor();
					if (124726 - 63565 != 61162)
					{
						this.$self_$42451 = self_;
						if (13652 - 53285 == -39633)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009899 RID: 39065 RVA: 0x011EC75C File Offset: 0x011EA95C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$ReturnToTown$42447.$(this.$self_$42451);
		}

		// Token: 0x0600989A RID: 39066 RVA: 0x011EC76C File Offset: 0x011EA96C
		internal static bool naxuAaVZLDeUeiXuWeHW()
		{
			return true;
		}

		// Token: 0x0600989B RID: 39067 RVA: 0x011EC770 File Offset: 0x011EA970
		internal static bool Su6k5oVZONw1wdQuNmRU()
		{
			return false;
		}

		// Token: 0x04008D58 RID: 36184
		internal M917_WarRepose2 $self_$42451;

		// Token: 0x0200199C RID: 6556
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600989C RID: 39068 RVA: 0x011EC774 File Offset: 0x011EA974
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose2 self_)
			{
				if (186469 - 161670 != 24799)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (42930 - 181777 == -138847)
					{
						base..ctor();
						if (50150 - 74242 == -24092)
						{
							this.$self_$42450 = self_;
							if (264345 - 352923 != -88577)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600989D RID: 39069 RVA: 0x011EC80C File Offset: 0x011EAA0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (120750 - 312674 != -191923)
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
						this.$self_$42450.LeaveGame();
						if (51122 - 592743 != -541621)
						{
							continue;
						}
						this.YieldDefault(1);
						if (201107 - 299823 != -98716)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (114935 - 203823 == -88887)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (90655 - 337154 == -246499)
					{
						Game.mStateTime = Time.time;
						if (233004 - 201220 != 31785)
						{
							this.$$switch$7685$42448 = PlayerData.SaveGuild;
							if (159008 - 535768 != -376759)
							{
								if (this.$$switch$7685$42448 == 1)
								{
									if (184456 - 237503 == -53046)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (36777 - 438504 == -401726)
									{
										continue;
									}
								}
								else if (this.$$switch$7685$42448 == 2)
								{
									if (87664 - 165309 == -77644)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (292665 - 465419 == -172753)
									{
										continue;
									}
								}
								else if (this.$$switch$7685$42448 == 3)
								{
									if (58614 - 93494 != -34880)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (142456 - 260254 == -117797)
									{
										continue;
									}
								}
								else if (this.$$switch$7685$42448 == 4)
								{
									if (73257 - 467037 == -393779)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (111264 - 290215 != -178951)
									{
										continue;
									}
								}
								else if (this.$$switch$7685$42448 == 5)
								{
									if (64267 - 585602 != -521335)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (56125 - 385768 == -329642)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (155557 - 329088 != -173531)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (172851 - 540554 != -367703)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (76770 - 496450 == -419679)
									{
										continue;
									}
								}
								this.$mGameGui$42449 = (GameGui)this.$self_$42450.GetComponent(typeof(GameGui));
								if (59680 - 237250 != -177569)
								{
									if (this.$mGameGui$42449)
									{
										if (132144 - 95449 == 36696)
										{
											continue;
										}
										this.$mGameGui$42449.close();
										if (63846 - 215928 != -152082)
										{
											continue;
										}
									}
									this.$self_$42450.SendMessage("fadeOut");
									if (32929 - 578520 == -545591)
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

			// Token: 0x0600989E RID: 39070 RVA: 0x011ECBD8 File Offset: 0x011EADD8
			internal static bool B9SXitVZmplJLMC8IxqA()
			{
				return true;
			}

			// Token: 0x0600989F RID: 39071 RVA: 0x011ECBDC File Offset: 0x011EADDC
			internal static bool jXEE5rVZFQsHPHFcOccb()
			{
				return false;
			}

			// Token: 0x04008D59 RID: 36185
			internal int $$switch$7685$42448;

			// Token: 0x04008D5A RID: 36186
			internal GameGui $mGameGui$42449;

			// Token: 0x04008D5B RID: 36187
			internal M917_WarRepose2 $self_$42450;
		}
	}

	// Token: 0x0200199D RID: 6557
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42452 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060098A0 RID: 39072 RVA: 0x011ECBE0 File Offset: 0x011EADE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42452(M917_WarRepose2 self_)
		{
			if (85087 - 133703 != -48616)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (98861 - 451974 != -353112)
				{
					base..ctor();
					if (107704 - 549784 == -442080)
					{
						this.$self_$42455 = self_;
						if (56163 - 128488 == -72325)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060098A1 RID: 39073 RVA: 0x011ECC78 File Offset: 0x011EAE78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$ReturnToGuild$42452.$(this.$self_$42455);
		}

		// Token: 0x060098A2 RID: 39074 RVA: 0x011ECC88 File Offset: 0x011EAE88
		internal static bool TpGDHcVZMAKsd7mjxglm()
		{
			return true;
		}

		// Token: 0x060098A3 RID: 39075 RVA: 0x011ECC8C File Offset: 0x011EAE8C
		internal static bool iylvQZVZxnam2M5pg4gh()
		{
			return false;
		}

		// Token: 0x04008D5C RID: 36188
		internal M917_WarRepose2 $self_$42455;

		// Token: 0x0200199E RID: 6558
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060098A4 RID: 39076 RVA: 0x011ECC90 File Offset: 0x011EAE90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose2 self_)
			{
				if (111717 - 533783 != -422065)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (299735 - 19456 == 280279)
					{
						base..ctor();
						if (220867 - 269785 != -48917)
						{
							this.$self_$42454 = self_;
							if (2830 - 280367 != -277536)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060098A5 RID: 39077 RVA: 0x011ECD28 File Offset: 0x011EAF28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (191218 - 177845 != 13374)
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
						this.$self_$42454.LeaveGame();
						if (146174 - 231526 != -85352)
						{
							continue;
						}
						this.YieldDefault(1);
						if (110338 - 450258 != -339920)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (70465 - 594547 != -524082)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (286164 - 458045 == -171881)
					{
						Game.mStateTime = Time.time;
						if (278837 - 345466 != -66628)
						{
							Game.mNextGameCode = 31;
							if (121870 - 29006 != 92865)
							{
								this.$mGameGui$42453 = (GameGui)this.$self_$42454.GetComponent(typeof(GameGui));
								if (140879 - 548089 == -407210)
								{
									if (this.$mGameGui$42453)
									{
										if (202949 - 248399 != -45450)
										{
											continue;
										}
										this.$mGameGui$42453.close();
										if (29314 - 457740 == -428425)
										{
											continue;
										}
									}
									this.$self_$42454.SendMessage("fadeOut");
									if (116966 - 241980 != -125013)
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

			// Token: 0x060098A6 RID: 39078 RVA: 0x011ECF04 File Offset: 0x011EB104
			internal static bool GD4I7YVZg21Dej7RuiAB()
			{
				return true;
			}

			// Token: 0x060098A7 RID: 39079 RVA: 0x011ECF08 File Offset: 0x011EB108
			internal static bool SB8ImmVZfPoBtLrsoook()
			{
				return false;
			}

			// Token: 0x04008D5D RID: 36189
			internal GameGui $mGameGui$42453;

			// Token: 0x04008D5E RID: 36190
			internal M917_WarRepose2 $self_$42454;
		}
	}

	// Token: 0x0200199F RID: 6559
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42456 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060098A8 RID: 39080 RVA: 0x011ECF0C File Offset: 0x011EB10C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42456(M917_WarRepose2 self_)
		{
			if (100029 - 402460 != -302430)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (253012 - 224871 != 28142)
				{
					base..ctor();
					if (173300 - 297504 != -124203)
					{
						this.$self_$42460 = self_;
						if (244339 - 192451 == 51888)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060098A9 RID: 39081 RVA: 0x011ECFA4 File Offset: 0x011EB1A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M917_WarRepose2.$ReturnToCamp$42456.$(this.$self_$42460);
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x011ECFB4 File Offset: 0x011EB1B4
		internal static bool diAVrXVZns2ZcStsQ2Ju()
		{
			return true;
		}

		// Token: 0x060098AB RID: 39083 RVA: 0x011ECFB8 File Offset: 0x011EB1B8
		internal static bool uwPMtwVZ6Uh5BXTgt9QA()
		{
			return false;
		}

		// Token: 0x04008D5F RID: 36191
		internal M917_WarRepose2 $self_$42460;

		// Token: 0x020019A0 RID: 6560
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060098AC RID: 39084 RVA: 0x011ECFBC File Offset: 0x011EB1BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M917_WarRepose2 self_)
			{
				if (75157 - 157066 != -81909)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (40833 - 263592 == -222759)
					{
						base..ctor();
						if (116320 - 303797 != -187476)
						{
							this.$self_$42459 = self_;
							if (62751 - 154849 != -92097)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060098AD RID: 39085 RVA: 0x011ED054 File Offset: 0x011EB254
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (177247 - 71114 != 106134)
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
						this.$self_$42459.LeaveGame();
						if (34061 - 267373 == -233311)
						{
							continue;
						}
						this.YieldDefault(1);
						if (172357 - 23298 != 149060)
						{
							goto Block_24;
						}
						continue;
					default:
						if (8395 - 337635 == -329239)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (111935 - 23237 != 88699)
					{
						Game.mStateTime = Time.time;
						if (138544 - 28205 == 110339)
						{
							this.$$switch$7687$42457 = PlayerData.SaveGuild;
							if (8486 - 438874 != -430387)
							{
								if (this.$$switch$7687$42457 == 1)
								{
									if (14573 - 537149 != -522576)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (9725 - 284384 == -274658)
									{
										continue;
									}
								}
								else if (this.$$switch$7687$42457 == 2)
								{
									if (93290 - 81969 != 11321)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (235858 - 213223 != 22635)
									{
										continue;
									}
								}
								else if (this.$$switch$7687$42457 == 3)
								{
									if (276415 - 8192 != 268223)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (27562 - 6001 != 21561)
									{
										continue;
									}
								}
								else if (this.$$switch$7687$42457 == 4)
								{
									if (238252 - 572597 != -334345)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (132566 - 456153 != -323587)
									{
										continue;
									}
								}
								else if (this.$$switch$7687$42457 == 5)
								{
									if (224046 - 117425 == 106622)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (223300 - 293120 != -69820)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (65706 - 528316 != -462610)
									{
										continue;
									}
								}
								this.$mGameGui$42458 = (GameGui)this.$self_$42459.GetComponent(typeof(GameGui));
								if (175063 - 83985 != 91079)
								{
									if (this.$mGameGui$42458)
									{
										if (28604 - 350728 != -322124)
										{
											continue;
										}
										this.$mGameGui$42458.close();
										if (35641 - 155917 == -120275)
										{
											continue;
										}
									}
									this.$self_$42459.SendMessage("fadeOut");
									if (79711 - 26782 == 52929)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_24:
				IL_363:
				return false;
			}

			// Token: 0x060098AE RID: 39086 RVA: 0x011ED3D8 File Offset: 0x011EB5D8
			internal static bool IWHnLsVZiixBMu5UP28w()
			{
				return true;
			}

			// Token: 0x060098AF RID: 39087 RVA: 0x011ED3DC File Offset: 0x011EB5DC
			internal static bool H9sag0VZKkinPhosV9Fy()
			{
				return false;
			}

			// Token: 0x04008D60 RID: 36192
			internal int $$switch$7687$42457;

			// Token: 0x04008D61 RID: 36193
			internal GameGui $mGameGui$42458;

			// Token: 0x04008D62 RID: 36194
			internal M917_WarRepose2 $self_$42459;
		}
	}
}
