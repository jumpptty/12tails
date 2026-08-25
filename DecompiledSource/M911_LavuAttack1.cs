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

// Token: 0x020018E7 RID: 6375
[Serializable]
public class M911_LavuAttack1 : MonoBehaviour
{
	// Token: 0x0600944C RID: 37964 RVA: 0x011AC76C File Offset: 0x011AA96C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M911_LavuAttack1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600944D RID: 37965 RVA: 0x011AC77C File Offset: 0x011AA97C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (230237 - 346693 != -116455)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (239299 - 470646 != -231346)
			{
				Game.mGameType = 5;
				if (53522 - 295600 != -242077)
				{
					if (Chat.Initialized)
					{
						if (110343 - 43930 == 66413)
						{
							Chat.ChatDisplay.Clear();
							if (272527 - 565303 == -292776)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (161217 - 45130 != 116088)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600944E RID: 37966 RVA: 0x011AC860 File Offset: 0x011AAA60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (4671 - 519053 != -514382)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (140589 - 351821 == -211232)
				{
					if (Game.mNextGameCode != 911)
					{
						break;
					}
					if (261540 - 246488 == 15052)
					{
						Game.nextGame();
						if (226180 - 256989 != -30808)
						{
							Game.mGameCode = 911;
							if (124136 - 392538 != -268401)
							{
								Game.mGameType = 5;
								if (63506 - 115337 == -51831)
								{
									Game.mGameTime = Time.time;
									if (193210 - 56687 != 136524)
									{
										Game.mGameScore = 0;
										if (174863 - 476783 == -301920)
										{
											Game.mGameMana = 0;
											if (166058 - 380837 == -214779)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (188921 - 329442 != -140520)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (296223 - 545337 == -249114)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (18348 - 477082 != -458733)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (274759 - 389064 != -114304)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (24556 - 187373 != -162816)
																{
																	this.mYmncVJeCVj = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (72670 - 335754 == -263084)
																	{
																		this.mYmncVJeCVj.enabled = false;
																		if (83432 - 226123 != -142690)
																		{
																			this.VCTncys2hnX = PhotonClient.Connection;
																			if (129449 - 431958 == -302509)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (33113 - 464161 != -431047)
																				{
																					this.InitGame();
																					if (100083 - 160138 != -60054)
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
			else
			{
				Debug.Log("Not Connected");
				if (253490 - 415547 == -162057)
				{
					Game.mGameType = 99;
					if (68587 - 368593 != -300005)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600944F RID: 37967 RVA: 0x011ACB8C File Offset: 0x011AAD8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (295037 - 582388 != -287350)
		{
		}
		for (;;)
		{
			if (this.VCTncys2hnX == null)
			{
				if (146130 - 356275 != -210144)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (140873 - 342803 == -201930)
				{
					if (mGameState == eGameState.Init)
					{
						if (254256 - 43505 != 210752)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (184503 - 593613 == -409110)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (91774 - 209252 == -117478)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (109990 - 337970 == -227980)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (190797 - 78165 == 112632)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (131542 - 189444 != -57901)
						{
							if (Game.music != 0)
							{
								if (64587 - 434645 != -370058)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (9967 - 501557 == -491589)
									{
										continue;
									}
									this.audio.Play();
									if (47532 - 100681 != -53149)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (17740 - 211260 == -193519)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (123649 - 287624 != -163975)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (128957 - 64582 == 64376)
								{
									continue;
								}
							}
							if (Time.time <= this.gecnchV1XLY)
							{
								break;
							}
							if (175580 - 379302 == -203722)
							{
								Game.mGameMana++;
								if (198250 - 367261 == -169011)
								{
									this.gecnchV1XLY = Time.time + (float)12;
									if (273951 - 86925 == 187026)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (51773 - 545519 != -493745)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (212121 - 544076 != -331954)
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
						if (130453 - 484622 != -354168)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009450 RID: 37968 RVA: 0x011ACF00 File Offset: 0x011AB100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (259169 - 272316 != -13146)
		{
		}
		for (;;)
		{
			if (!this.rNFncK4CYEa)
			{
				if (284028 - 253241 != 30788)
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
				if (155883 - 304386 == -148503)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (142003 - 501263 == -359260)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (52862 - 141459 == -88597)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (134873 - 447660 != -312786)
							{
								GUI.depth = 1;
								if (104410 - 354686 != -250275)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (253247 - 167258 != 85990)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (182998 - 338793 != -155794)
										{
											Color color = GUI.color;
											if (11670 - 491636 != -479965)
											{
												float num3 = color.a = a;
												if (200330 - 21639 != 178692)
												{
													if (34799 - 77771 == -42972)
													{
														Color color2 = GUI.color = color;
														if (171806 - 72629 == 99177)
														{
															if (85886 - 17112 != 68775)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.rNFncK4CYEa);
																if (61348 - 108141 == -46793)
																{
																	float a2 = 1f;
																	if (185072 - 243130 != -58057)
																	{
																		Color color3 = GUI.color;
																		if (184203 - 254139 != -69935)
																		{
																			color3.a = a2;
																			if (284329 - 38092 == 246237)
																			{
																				if (24311 - 528825 != -504513)
																				{
																					Color color4 = GUI.color = color3;
																					if (105515 - 432908 == -327393)
																					{
																						if (139135 - 291345 != -152209)
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
	}

	// Token: 0x06009451 RID: 37969 RVA: 0x011AD280 File Offset: 0x011AB480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M911_LavuAttack1.$onGameEvent$41898(data, this).GetEnumerator();
	}

	// Token: 0x06009452 RID: 37970 RVA: 0x011AD290 File Offset: 0x011AB490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M911_LavuAttack1.$StartEvent$41910(this).GetEnumerator();
	}

	// Token: 0x06009453 RID: 37971 RVA: 0x011AD2A0 File Offset: 0x011AB4A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RedPandaChat(int nMessageCode)
	{
		if (97001 - 221127 != -124126)
		{
		}
		for (;;)
		{
			string message = Language.getMessage("M911_LavuAttack", nMessageCode);
			if (227783 - 383197 != -155413)
			{
				Chat.SubmitChat("RedPanda", message, eChatType.npc, eChatMode.system);
				if (119563 - 387905 != -268341)
				{
					GameObject gameObject = GameObject.Find("EnlagearCart");
					if (145651 - 82964 == 62687)
					{
						if (!gameObject)
						{
							break;
						}
						if (147643 - 190719 == -43076)
						{
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (40083 - 428324 != -388240)
							{
								if (!characterControl)
								{
									break;
								}
								if (262592 - 226360 != 36233)
								{
									characterControl.doChatBubble(message);
									if (296615 - 446145 == -149530)
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

	// Token: 0x06009454 RID: 37972 RVA: 0x011AD3E8 File Offset: 0x011AB5E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnlagearCartEnter1(GameObject enterObject)
	{
		if (291889 - 234208 != 57682)
		{
		}
		while (this.ucZncz8xRqo < 1)
		{
			if (121569 - 143761 == -22192)
			{
				CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
				if (218978 - 130477 != 88502)
				{
					if (!(characterControl.Type == "EnlagearCart"))
					{
						break;
					}
					if (97948 - 27812 == 70136)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (93163 - 422402 != -329238)
						{
							Debug.Log("EnlagearCartEnterZone1");
							if (247576 - 230488 != 17089)
							{
								Game.sendMissionEvent(9112, 1);
								if (166520 - 155773 != 10748)
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

	// Token: 0x06009455 RID: 37973 RVA: 0x011AD514 File Offset: 0x011AB714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnlagearCartEnter2(GameObject enterObject)
	{
		if (255127 - 197481 != 57647)
		{
		}
		while (this.ucZncz8xRqo < 2)
		{
			if (294388 - 322507 == -28119)
			{
				CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
				if (79962 - 36977 == 42985)
				{
					if (!(characterControl.Type == "EnlagearCart"))
					{
						break;
					}
					if (121572 - 595240 != -473667)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (166676 - 15304 == 151372)
						{
							Debug.Log("EnlagearCartEnterZone1");
							if (42753 - 269058 != -226304)
							{
								Game.sendMissionEvent(9112, 2);
								if (217798 - 150794 != 67005)
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

	// Token: 0x06009456 RID: 37974 RVA: 0x011AD640 File Offset: 0x011AB840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnlagearCartEnter3(GameObject enterObject)
	{
		if (60970 - 106307 != -45337)
		{
		}
		while (this.ucZncz8xRqo < 3)
		{
			if (8813 - 22809 == -13996)
			{
				CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
				if (114709 - 178752 == -64043)
				{
					if (!(characterControl.Type == "EnlagearCart"))
					{
						break;
					}
					if (180591 - 560885 == -380294)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (158990 - 477788 == -318798)
						{
							Debug.Log("EnlagearCartEnterZone1");
							if (81083 - 380610 != -299526)
							{
								Game.sendMissionEvent(9112, 3);
								if (3499 - 452058 == -448559)
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

	// Token: 0x06009457 RID: 37975 RVA: 0x011AD76C File Offset: 0x011AB96C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnlagearCartEnter4(GameObject exitObject)
	{
		if (81109 - 500034 != -418924)
		{
		}
		while (this.ucZncz8xRqo < 4)
		{
			if (267300 - 50343 == 216957)
			{
				CharacterControl characterControl = (CharacterControl)exitObject.GetComponent(typeof(CharacterControl));
				if (100105 - 276529 != -176423)
				{
					if (!(characterControl.Type == "EnlagearCart"))
					{
						break;
					}
					if (285778 - 463309 == -177531)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (74098 - 93228 != -19129)
						{
							Debug.Log("EnlagearCartExit");
							if (147998 - 357646 == -209648)
							{
								Game.sendMissionEvent(9111, 1);
								if (210725 - 363216 == -152491)
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

	// Token: 0x06009458 RID: 37976 RVA: 0x011AD898 File Offset: 0x011ABA98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (187416 - 153806 != 33611)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (259918 - 107601 == 152317)
			{
				Time.timeScale = 1f;
				if (115263 - 523206 == -407943)
				{
					this.rNFncK4CYEa = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (40948 - 366767 == -325819)
					{
						Hashtable customOpParameters = new Hashtable();
						if (74556 - 349668 == -275112)
						{
							this.VCTncys2hnX.OpCustom(52, customOpParameters, true);
							if (158121 - 152821 == 5300)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009459 RID: 37977 RVA: 0x011AD99C File Offset: 0x011ABB9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (206926 - 96627 != 110300)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (38695 - 36012 != 2684)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (193113 - 409899 == -216786)
				{
					Game.mGameState = eGameState.Setup;
					if (190499 - 200593 != -10093)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600945A RID: 37978 RVA: 0x011ADA40 File Offset: 0x011ABC40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (275059 - 162725 != 112334)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (87182 - 69224 != 17959)
			{
				if (num == PlayerData.UID)
				{
					if (152993 - 529733 != -376739)
					{
						this.SetupActors();
						if (193512 - 172987 == 20525)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (97859 - 594846 == -496987)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600945B RID: 37979 RVA: 0x011ADB10 File Offset: 0x011ABD10
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (198829 - 147717 != 51112)
		{
		}
		for (;;)
		{
			IL_204:
			Debug.Log("Creating Actors");
			if (157380 - 284128 == -126748)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (33412 - 584846 != -551433)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (146639 - 281549 != -134909)
						{
							int i = 0;
							if (84602 - 136209 == -51607)
							{
								CharacterControl[] array2 = array;
								if (62800 - 567203 != -504402)
								{
									int length = array2.Length;
									if (28080 - 351396 != -323315)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (124511 - 483019 == -358507)
												{
													goto IL_204;
												}
												string type = array2[i].Type;
												if (101226 - 457594 == -356367)
												{
													goto IL_204;
												}
												if (type == "EnlagearCart")
												{
													goto IL_A3;
												}
												if (255195 - 313414 != -58219)
												{
													goto IL_204;
												}
												if (type == "NinjaBug_r")
												{
													goto IL_A3;
												}
												if (176613 - 255687 != -79074)
												{
													goto IL_204;
												}
												if (type == "NinjaBug_g")
												{
													goto IL_A3;
												}
												if (248247 - 551873 == -303625)
												{
													goto IL_204;
												}
												if (type == "NinjaBug_b")
												{
													goto IL_A3;
												}
												if (146335 - 65559 == 80777)
												{
													goto IL_204;
												}
												if (type == "NinjaBug_y")
												{
													goto IL_A3;
												}
												if (154809 - 11787 == 143023)
												{
													goto IL_204;
												}
												if (type == "NinjaBug_k")
												{
													goto IL_A3;
												}
												if (64894 - 243515 != -178621)
												{
													goto IL_204;
												}
												if (type == "WormBug")
												{
													if (260727 - 552893 != -292165)
													{
														goto IL_A3;
													}
													goto IL_204;
												}
												IL_328:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (291896 - 235971 != 55925)
												{
													goto IL_204;
												}
												this.Ti8nncqT8UZ++;
												if (133683 - 85148 != 48535)
												{
													goto IL_204;
												}
												goto IL_85;
												IL_A3:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (28058 - 111867 != -83809)
												{
													goto IL_204;
												}
												goto IL_328;
											}
											IL_85:
											i++;
											if (80625 - 399523 == -318897)
											{
												goto IL_204;
											}
										}
										if (237018 - 544182 != -307163)
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
						if (91915 - 335302 == -243387)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600945C RID: 37980 RVA: 0x011ADEA8 File Offset: 0x011AC0A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (107653 - 62040 != 45614)
		{
		}
		for (;;)
		{
			IL_A2:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (188498 - 39741 == 148757)
			{
				int i = 0;
				if (191628 - 496791 == -305163)
				{
					CharacterControl[] array2 = array;
					if (200788 - 93426 != 107363)
					{
						int length = array2.Length;
						if (152707 - 373977 != -221269)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (42086 - 512604 == -470517)
								{
									goto IL_A2;
								}
								i++;
								if (260040 - 413347 != -153307)
								{
									goto IL_A2;
								}
							}
							if (154070 - 252731 == -98661)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600945D RID: 37981 RVA: 0x011ADFD8 File Offset: 0x011AC1D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (217033 - 523740 != -306707)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (50842 - 33406 == 17436)
			{
				Game.mGameState = eGameState.Ready;
				if (27209 - 98503 != -71293)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (296038 - 198276 != 97763 && 34253 - 51390 != -17136)
					{
						if (261486 - 47302 == 214184)
						{
							GameObject gameObject;
							if (playerSlot >= 1)
							{
								if (91121 - 316096 == -224974)
								{
									continue;
								}
								if (playerSlot <= 5)
								{
									if (283312 - 418427 != -135115)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint" + playerSlot);
									if (293727 - 72101 != 221626)
									{
										continue;
									}
									goto IL_229;
								}
							}
							gameObject = GameObject.Find("StartPoint1");
							if (239731 - 59230 != 180501)
							{
								continue;
							}
							IL_229:
							if (!gameObject)
							{
								break;
							}
							if (273150 - 424694 != -151543)
							{
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
								if (193066 - 585762 == -392696)
								{
									if (spawnPos != Vector3.zero)
									{
										if (182461 - 147573 == 34888)
										{
											this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
											if (166492 - 329016 == -162524)
											{
												break;
											}
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
										if (295659 - 536547 != -240887)
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

	// Token: 0x0600945E RID: 37982 RVA: 0x011AE244 File Offset: 0x011AC444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M911_LavuAttack1.$StartGame$41915(this).GetEnumerator();
	}

	// Token: 0x0600945F RID: 37983 RVA: 0x011AE254 File Offset: 0x011AC454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009460 RID: 37984 RVA: 0x011AE258 File Offset: 0x011AC458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (79364 - 102934 != -23569)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (99838 - 519886 == -420048)
			{
				if (gameObject)
				{
					if (31606 - 523866 == -492260)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (281994 - 96356 == 185638)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Missing SpawnPoint" + nSpawnID);
					if (274396 - 37145 == 237251)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009461 RID: 37985 RVA: 0x011AE354 File Offset: 0x011AC554
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (222439 - 134939 != 87500)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (115371 - 213801 == -98430)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (64479 - 480683 == -416204)
				{
					hashtable.Add(43, PlayerData.UID);
					if (83414 - 219675 != -136260)
					{
						hashtable.Add(73, nType);
						if (251536 - 525944 != -274407)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (263809 - 70405 != 193405)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (72247 - 105465 == -33218)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (50167 - 83696 != -33528)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (74319 - 260425 == -186106)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (128086 - 22566 == 105520)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (78640 - 172878 == -94238)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (45645 - 446220 != -400574)
													{
														this.VCTncys2hnX.OpCustom(63, hashtable, true);
														if (45637 - 365189 == -319552)
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

	// Token: 0x06009462 RID: 37986 RVA: 0x011AE638 File Offset: 0x011AC838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (141364 - 133147 != 8218)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (53682 - 207375 != -153692)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (252285 - 305373 != -53087)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (119862 - 572841 != -452978)
						{
							if (this.Ti8nncqT8UZ <= 0)
							{
								break;
							}
							if (67277 - 65988 != 1290)
							{
								this.Ti8nncqT8UZ--;
								if (24844 - 237578 == -212734)
								{
									if (this.Ti8nncqT8UZ != 0)
									{
										break;
									}
									if (62030 - 439970 != -377939)
									{
										Game.setGameState(eGameState.Ready);
										if (137634 - 127765 != 9870)
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
						if (200062 - 172262 != 27801)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (136593 - 66715 != 69879)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009463 RID: 37987 RVA: 0x011AE7C8 File Offset: 0x011AC9C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009464 RID: 37988 RVA: 0x011AE7DC File Offset: 0x011AC9DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (212130 - 399533 != -187403)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (154856 - 49295 != 105562)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (190394 - 35085 != 155310)
				{
					if (!characterControl)
					{
						break;
					}
					if (92148 - 109984 != -17835)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (32048 - 159706 == -127658)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (235626 - 63856 != 171771)
							{
								string type = characterControl.Type;
								if (11345 - 175217 != -163871)
								{
									if (type == "EnlagearCart")
									{
										if (23218 - 257823 == -234605)
										{
											Game.sendMissionEvent(9113, 1);
											if (180582 - 18751 != 161832)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Lavu"))
										{
											break;
										}
										if (177412 - 473890 != -296477)
										{
											Game.sendMissionEvent(9113, 2);
											if (273052 - 217479 == 55573)
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

	// Token: 0x06009465 RID: 37989 RVA: 0x011AE9A8 File Offset: 0x011ACBA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (222642 - 205311 != 17332)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (4850 - 189050 != -184199)
			{
				hashtable.Add(71, CID);
				if (7174 - 71101 == -63927)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (28108 - 545918 != -517809)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (16437 - 587077 != -570639)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (187757 - 359077 != -171319)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (132821 - 46114 == 86707)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (245539 - 60448 != 185092)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (233871 - 110037 != 123835)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (253571 - 340623 != -87051)
											{
												this.VCTncys2hnX.OpCustom(61, hashtable, true);
												if (245340 - 9429 != 235912)
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

	// Token: 0x06009466 RID: 37990 RVA: 0x011AEC34 File Offset: 0x011ACE34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (54376 - 343827 != -289451)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (232082 - 524777 != -292694)
			{
				if (!gameObject)
				{
					break;
				}
				if (38539 - 445441 == -406902)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (275038 - 492536 != -217497)
					{
						playerCameraControl.target = gameObject;
						if (117689 - 56102 != 61588)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (289794 - 599983 == -310189)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009467 RID: 37991 RVA: 0x011AED2C File Offset: 0x011ACF2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (269903 - 219556 != 50347)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (258593 - 414766 == -156173)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (232570 - 186751 == 45819)
				{
					gameGui.ResetTeamBar();
					if (121910 - 8260 != 113651)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009468 RID: 37992 RVA: 0x011AEDD8 File Offset: 0x011ACFD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M911_LavuAttack1.$onDeadPlayer$41918(this).GetEnumerator();
	}

	// Token: 0x06009469 RID: 37993 RVA: 0x011AEDE8 File Offset: 0x011ACFE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (75679 - 257360 != -181680)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (111487 - 436857 != -325369)
			{
				this.mYmncVJeCVj.target = Game.mPlayer;
				if (80348 - 30962 == 49386)
				{
					this.mYmncVJeCVj.enabled = true;
					if (206862 - 277590 == -70728)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (213189 - 100382 != 112807)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (118967 - 335968 != -217001)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (92145 - 30261 != 61885)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (91968 - 24125 != 67844)
							{
								if (!gameGui)
								{
									break;
								}
								if (293892 - 234148 != 59745)
								{
									gameGui.enabled = true;
									if (143230 - 485173 != -341942)
									{
										gameGui.closeDeadMenu();
										if (229970 - 275903 == -45933)
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

	// Token: 0x0600946A RID: 37994 RVA: 0x011AEF94 File Offset: 0x011AD194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (114584 - 45561 != 69024)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (2094 - 213010 != -210915)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (123209 - 85731 == 37478)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (101052 - 84826 != 16227)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600946B RID: 37995 RVA: 0x011AF058 File Offset: 0x011AD258
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600946C RID: 37996 RVA: 0x011AF084 File Offset: 0x011AD284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (235421 - 404835 != -169414)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (109234 - 412670 == -303436)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (29572 - 565179 == -535607)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (103676 - 376428 == -272752)
					{
						Hashtable hashtable = new Hashtable();
						if (294544 - 241743 != 52802)
						{
							hashtable.Add(43, PlayerData.UID);
							if (169986 - 402111 != -232124)
							{
								hashtable.Add(71, nCID);
								if (43865 - 461569 == -417704)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (97123 - 8420 == 88703)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (157976 - 495699 == -337723)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (248846 - 77044 != 171803)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (294045 - 535514 != -241468)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (220683 - 65660 != 155024)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (294063 - 486877 != -192813)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (279370 - 257737 == 21633)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (144298 - 449274 != -304975)
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

	// Token: 0x0600946D RID: 37997 RVA: 0x011AF3A4 File Offset: 0x011AD5A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M911_LavuAttack1.$onChangePlayer$41924(data, this).GetEnumerator();
	}

	// Token: 0x0600946E RID: 37998 RVA: 0x011AF3B4 File Offset: 0x011AD5B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M911_LavuAttack1.$onGameComplete$41931(data, this).GetEnumerator();
	}

	// Token: 0x0600946F RID: 37999 RVA: 0x011AF3C4 File Offset: 0x011AD5C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M911_LavuAttack1.$ReturnToTown$41941(this).GetEnumerator();
	}

	// Token: 0x06009470 RID: 38000 RVA: 0x011AF3D4 File Offset: 0x011AD5D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M911_LavuAttack1.$ReturnToGuild$41946(this).GetEnumerator();
	}

	// Token: 0x06009471 RID: 38001 RVA: 0x011AF3E4 File Offset: 0x011AD5E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M911_LavuAttack1.$ReturnToCamp$41950(this).GetEnumerator();
	}

	// Token: 0x06009472 RID: 38002 RVA: 0x011AF3F4 File Offset: 0x011AD5F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (27 - 124586 != -124559)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (287850 - 459394 == -171544)
			{
				Hashtable hashtable = new Hashtable();
				if (9389 - 569269 == -559880)
				{
					hashtable.Add(43, PlayerData.UID);
					if (100980 - 165281 != -64300)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (46086 - 106938 == -60852)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009473 RID: 38003 RVA: 0x011AF4CC File Offset: 0x011AD6CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009474 RID: 38004 RVA: 0x011AF4E0 File Offset: 0x011AD6E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (177689 - 497757 != -320067)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (125630 - 590163 == -464533)
			{
				Hashtable hashtable = new Hashtable();
				if (246194 - 63324 != 182871)
				{
					if (Game.mNextGameCode == 30)
					{
						if (4276 - 296525 != -292249)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (115890 - 189381 == -73490)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (70750 - 285976 == -215225)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (150020 - 158768 == -8747)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (17958 - 403589 == -385630)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (132079 - 539386 == -407306)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (55384 - 577337 != -521953)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (244102 - 545150 == -301047)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (61716 - 332638 != -270922)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (251714 - 420501 != -168787)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (13497 - 305694 == -292196)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (168606 - 378297 == -209690)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (155739 - 37231 == 118509)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (283301 - 213968 != 69333)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (74032 - 486364 == -412331)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (15720 - 203354 != -187634)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (6269 - 211277 != -205008)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (43875 - 557501 == -513625)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (218101 - 61620 != 156481)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (205190 - 567681 == -362490)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (201704 - 465142 != -263438)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (163754 - 524665 != -360911)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (19053 - 295550 != -276497)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (12872 - 23903 == -11030)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (139693 - 368081 != -228388)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (218637 - 246901 == -28263)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (16481 - 87205 != -70724)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (38866 - 402325 != -363459)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (169398 - 538680 != -369281)
					{
						this.VCTncys2hnX.OpCustom(42, hashtable, true);
						if (21862 - 561286 != -539423)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009475 RID: 38005 RVA: 0x011AFA94 File Offset: 0x011ADC94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009476 RID: 38006 RVA: 0x011AFAA4 File Offset: 0x011ADCA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009477 RID: 38007 RVA: 0x011AFAA8 File Offset: 0x011ADCA8
	internal static bool pCAlwZVydW5JJdCrcK78()
	{
		return true;
	}

	// Token: 0x06009478 RID: 38008 RVA: 0x011AFAAC File Offset: 0x011ADCAC
	internal static bool EpaE7FVyJxNn4PYZ4pcS()
	{
		return false;
	}

	// Token: 0x04008B29 RID: 35625
	private LitePeer VCTncys2hnX;

	// Token: 0x04008B2A RID: 35626
	private PlayerCameraControl mYmncVJeCVj;

	// Token: 0x04008B2B RID: 35627
	private float gecnchV1XLY;

	// Token: 0x04008B2C RID: 35628
	private Texture rNFncK4CYEa;

	// Token: 0x04008B2D RID: 35629
	private int ucZncz8xRqo;

	// Token: 0x04008B2E RID: 35630
	private int eBxnn52QpYN;

	// Token: 0x04008B2F RID: 35631
	private int Ti8nncqT8UZ;

	// Token: 0x020018E8 RID: 6376
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$41898 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009479 RID: 38009 RVA: 0x011AFAB0 File Offset: 0x011ADCB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$41898(Hashtable data, M911_LavuAttack1 self_)
		{
			if (185958 - 106899 != 79060)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (147364 - 361685 != -214320)
				{
					base..ctor();
					if (287367 - 323506 != -36138)
					{
						this.$data$41908 = data;
						if (111326 - 244498 == -133172)
						{
							this.$self_$41909 = self_;
							if (241652 - 257522 == -15870)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600947A RID: 38010 RVA: 0x011AFB6C File Offset: 0x011ADD6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack1.$onGameEvent$41898.$(this.$data$41908, this.$self_$41909);
		}

		// Token: 0x0600947B RID: 38011 RVA: 0x011AFB80 File Offset: 0x011ADD80
		internal static bool O1NinRVyDmURQ83GEsCP()
		{
			return true;
		}

		// Token: 0x0600947C RID: 38012 RVA: 0x011AFB84 File Offset: 0x011ADD84
		internal static bool i6LG1WVyvhUorxDqgBwe()
		{
			return false;
		}

		// Token: 0x04008B30 RID: 35632
		internal Hashtable $data$41908;

		// Token: 0x04008B31 RID: 35633
		internal M911_LavuAttack1 $self_$41909;

		// Token: 0x020018E9 RID: 6377
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600947D RID: 38013 RVA: 0x011AFB88 File Offset: 0x011ADD88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M911_LavuAttack1 self_)
			{
				if (71811 - 7122 != 64690)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109786 - 212768 != -102981)
					{
						base..ctor();
						if (27424 - 113614 != -86189)
						{
							this.$data$41906 = data;
							if (267546 - 460782 != -193235)
							{
								this.$self_$41907 = self_;
								if (23756 - 305890 != -282133)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600947E RID: 38014 RVA: 0x011AFC44 File Offset: 0x011ADE44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91535 - 104791 != -13256)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_808;
					case 2:
						Application.LoadLevel("M911_LavuAttack2");
						if (59046 - 339372 != -280326)
						{
							continue;
						}
						goto IL_ED;
					case 3:
						this.$self_$41907.RedPandaChat(106);
						if (196075 - 275404 != -79329)
						{
							continue;
						}
						goto IL_598;
					default:
						if (10828 - 392030 != -381202)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (116361 - 303166 != -186804)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$41899 = RuntimeServices.UnboxInt32(this.$data$41906[141]);
						if (9559 - 129597 == -120037)
						{
							continue;
						}
						this.$returnValue$41900 = RuntimeServices.UnboxInt32(this.$data$41906[145]);
						if (144991 - 114779 == 30213)
						{
							continue;
						}
						this.$ownerID$41901 = RuntimeServices.UnboxInt32(this.$data$41906[43]);
						if (54387 - 362799 == -308411)
						{
							continue;
						}
						this.$$switch$7558$41902 = this.$returnCode$41899;
						if (62494 - 194074 == -131579)
						{
							continue;
						}
						if (this.$$switch$7558$41902 == 9111)
						{
							if (200495 - 149462 != 51033)
							{
								continue;
							}
						}
						else if (this.$$switch$7558$41902 == -9111)
						{
							if (180844 - 315926 == -135081)
							{
								continue;
							}
							if (this.$self_$41907.ucZncz8xRqo < 4)
							{
								if (44728 - 103800 != -59072)
								{
									continue;
								}
								this.$self_$41907.ucZncz8xRqo = 4;
								if (34132 - 254351 != -220219)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (279187 - 565238 == -286050)
								{
									continue;
								}
								this.$mGameGui$41903 = (GameGui)this.$self_$41907.GetComponent(typeof(GameGui));
								if (165954 - 320608 != -154654)
								{
									continue;
								}
								this.$mGameGui$41903.close();
								if (216376 - 524800 == -308423)
								{
									continue;
								}
								Game.savePlayer();
								if (143003 - 530475 == -387471)
								{
									continue;
								}
								this.$self_$41907.SendMessage("fadeOut");
								if (174933 - 492425 != -317491)
								{
									goto Block_28;
								}
								continue;
							}
						}
						else if (this.$$switch$7558$41902 == 9112)
						{
							if (223067 - 362756 != -139689)
							{
								continue;
							}
						}
						else if (this.$$switch$7558$41902 == -9112)
						{
							if (274376 - 364439 == -90062)
							{
								continue;
							}
							if (this.$self_$41907.ucZncz8xRqo < this.$returnValue$41900)
							{
								if (213927 - 173052 == 40876)
								{
									continue;
								}
								this.$self_$41907.ucZncz8xRqo = this.$returnValue$41900;
								if (159325 - 210100 == -50774)
								{
									continue;
								}
							}
							this.$$switch$7554$41904 = this.$returnValue$41900;
							if (44926 - 21877 != 23049)
							{
								continue;
							}
							if (this.$$switch$7554$41904 == 1)
							{
								if (122950 - 595077 == -472126)
								{
									continue;
								}
								this.$self_$41907.RedPandaChat(103);
								if (38835 - 72138 == -33302)
								{
									continue;
								}
								if (this.$ownerID$41901 == PlayerData.UID)
								{
									if (242885 - 570757 != -327872)
									{
										continue;
									}
									this.$self_$41907.spawnActor("Lavu", 8, 1);
									if (241425 - 57605 != 183820)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$7554$41904 == 2)
							{
								if (201029 - 160900 != 40129)
								{
									continue;
								}
								this.$self_$41907.RedPandaChat(104);
								if (84197 - 414774 != -330577)
								{
									continue;
								}
								if (this.$ownerID$41901 == PlayerData.UID)
								{
									if (179778 - 54215 != 125563)
									{
										continue;
									}
									this.$self_$41907.spawnActor("Lavu", 8, 2);
									if (265697 - 112929 == 152769)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$7554$41904 == 3)
							{
								if (173851 - 385108 == -211256)
								{
									continue;
								}
								this.$self_$41907.RedPandaChat(105);
								if (201031 - 549783 != -348752)
								{
									continue;
								}
								if (this.$ownerID$41901 != PlayerData.UID)
								{
									goto IL_74C;
								}
								if (149632 - 423169 != -273537)
								{
									continue;
								}
								this.$self_$41907.spawnActor("Lavu", 8, 3);
								if (96235 - 190691 != -94456)
								{
									continue;
								}
								this.$self_$41907.spawnActor("Lavu", 8, 4);
								if (192694 - 4554 != 188140)
								{
									continue;
								}
								goto IL_74C;
							}
						}
						else if (this.$$switch$7558$41902 == 9113)
						{
							if (2870 - 109824 != -106954)
							{
								continue;
							}
							this.$$switch$7556$41905 = this.$returnValue$41900;
							if (207479 - 98985 == 108495)
							{
								continue;
							}
							if (this.$$switch$7556$41905 == 1)
							{
								if (247689 - 17766 != 229923)
								{
									continue;
								}
							}
							else if (this.$$switch$7556$41905 == 2)
							{
								if (221939 - 325642 != -103703)
								{
									continue;
								}
								this.$self_$41907.eBxnn52QpYN = this.$self_$41907.eBxnn52QpYN + 1;
								if (155754 - 81249 == 74506)
								{
									continue;
								}
								this.$self_$41907.SendMessage("newGameMessage", "Lavu Defeated:" + this.$self_$41907.eBxnn52QpYN + "/4");
								if (202935 - 225449 == -22513)
								{
									continue;
								}
								Chat.SubmitChat("none", "Lavu Defeated:" + this.$self_$41907.eBxnn52QpYN + "/4", eChatType.system, eChatMode.system);
								if (172279 - 225749 == -53469)
								{
									continue;
								}
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$41899);
							if (4869 - 302651 != -297782)
							{
								continue;
							}
						}
					}
					IL_253:
					this.YieldDefault(1);
					if (195364 - 367063 != -171698)
					{
						break;
					}
					continue;
					IL_598:
					IL_ED:
					goto IL_253;
				}
				goto IL_808;
				Block_28:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_74C:
				return this.Yield(3, new WaitForSeconds(5f));
				IL_808:
				return false;
			}

			// Token: 0x0600947F RID: 38015 RVA: 0x011B046C File Offset: 0x011AE66C
			internal static bool LPQfE1VyR3svpYg25Ncu()
			{
				return true;
			}

			// Token: 0x06009480 RID: 38016 RVA: 0x011B0470 File Offset: 0x011AE670
			internal static bool iZhWi7VywGfosXXCYyWR()
			{
				return false;
			}

			// Token: 0x04008B32 RID: 35634
			internal int $returnCode$41899;

			// Token: 0x04008B33 RID: 35635
			internal int $returnValue$41900;

			// Token: 0x04008B34 RID: 35636
			internal int $ownerID$41901;

			// Token: 0x04008B35 RID: 35637
			internal int $$switch$7558$41902;

			// Token: 0x04008B36 RID: 35638
			internal GameGui $mGameGui$41903;

			// Token: 0x04008B37 RID: 35639
			internal int $$switch$7554$41904;

			// Token: 0x04008B38 RID: 35640
			internal int $$switch$7556$41905;

			// Token: 0x04008B39 RID: 35641
			internal Hashtable $data$41906;

			// Token: 0x04008B3A RID: 35642
			internal M911_LavuAttack1 $self_$41907;
		}
	}

	// Token: 0x020018EA RID: 6378
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$41910 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009481 RID: 38017 RVA: 0x011B0474 File Offset: 0x011AE674
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$41910(M911_LavuAttack1 self_)
		{
			if (3486 - 57544 != -54057)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (30223 - 504719 != -474495)
				{
					base..ctor();
					if (686 - 174656 == -173970)
					{
						this.$self_$41914 = self_;
						if (215394 - 59758 != 155637)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009482 RID: 38018 RVA: 0x011B050C File Offset: 0x011AE70C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack1.$StartEvent$41910.$(this.$self_$41914);
		}

		// Token: 0x06009483 RID: 38019 RVA: 0x011B051C File Offset: 0x011AE71C
		internal static bool RFvRGoVyqmT0Y6wQyHdZ()
		{
			return true;
		}

		// Token: 0x06009484 RID: 38020 RVA: 0x011B0520 File Offset: 0x011AE720
		internal static bool NjPJkRVy7de0yvFC2B1U()
		{
			return false;
		}

		// Token: 0x04008B3B RID: 35643
		internal M911_LavuAttack1 $self_$41914;

		// Token: 0x020018EB RID: 6379
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009485 RID: 38021 RVA: 0x011B0524 File Offset: 0x011AE724
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M911_LavuAttack1 self_)
			{
				if (81984 - 148253 != -66268)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (69597 - 488289 != -418691)
					{
						base..ctor();
						if (48086 - 34069 == 14017)
						{
							this.$self_$41913 = self_;
							if (238099 - 390384 != -152284)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009486 RID: 38022 RVA: 0x011B05BC File Offset: 0x011AE7BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (237994 - 513181 != -275186)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_380;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (28709 - 42359 != -13650)
							{
								continue;
							}
							goto IL_291;
						}
						else
						{
							this.$mStoryGui$41911.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M911_LavuAttack", 101), eTalkType.friend);
							if (253046 - 115342 != 137705)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (185896 - 149150 != 36746)
							{
								continue;
							}
							goto IL_17B;
						}
						else
						{
							this.$mStoryGui$41911.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M911_LavuAttack", 102), eTalkType.friend);
							if (194107 - 123317 != 70790)
							{
								continue;
							}
							goto IL_C8;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (113364 - 523661 != -410296)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$41911.close();
							if (268695 - 233275 == 35421)
							{
								continue;
							}
							this.$self_$41913.mYmncVJeCVj.enabled = true;
							if (59785 - 368488 != -308703)
							{
								continue;
							}
							goto IL_1BD;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (256311 - 474619 != -218308)
							{
								continue;
							}
							goto IL_26C;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (45682 - 144961 != -99279)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (174542 - 244756 != -70214)
							{
								continue;
							}
							this.$mGameGui$41912 = (GameGui)this.$self_$41913.GetComponent(typeof(GameGui));
							if (93462 - 187824 != -94362)
							{
								continue;
							}
							this.$mGameGui$41912.enabled = true;
							if (146610 - 140150 == 6461)
							{
								continue;
							}
							this.YieldDefault(1);
							if (11496 - 412326 != -400829)
							{
								goto IL_380;
							}
							continue;
						}
						break;
					default:
						if (215010 - 472449 == -257438)
						{
							continue;
						}
						break;
					}
					this.$mStoryGui$41911 = (StoryGui)this.$self_$41913.GetComponent(typeof(StoryGui));
					if (275241 - 340108 == -64867)
					{
						if (!this.$mStoryGui$41911)
						{
							if (6150 - 47057 == -40907)
							{
								break;
							}
						}
						else
						{
							this.$mStoryGui$41911.startStoryMessage("RedPanda", "RedPanda", eTalkType.friend);
							if (239469 - 124838 != 114632)
							{
								goto Block_3;
							}
						}
					}
				}
				goto IL_380;
				Block_3:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_C8:
				return this.Yield(4, new WaitForSeconds(4f));
				Block_7:
				IL_17B:
				goto IL_380;
				IL_1BD:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_26C:
				IL_291:
				goto IL_380;
				Block_17:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_380:
				return false;
			}

			// Token: 0x06009487 RID: 38023 RVA: 0x011B095C File Offset: 0x011AEB5C
			internal static bool h4wVR1VyP3bhddCE15Cq()
			{
				return true;
			}

			// Token: 0x06009488 RID: 38024 RVA: 0x011B0960 File Offset: 0x011AEB60
			internal static bool qq15sHVy0oBPCHNGtyXw()
			{
				return false;
			}

			// Token: 0x04008B3C RID: 35644
			internal StoryGui $mStoryGui$41911;

			// Token: 0x04008B3D RID: 35645
			internal GameGui $mGameGui$41912;

			// Token: 0x04008B3E RID: 35646
			internal M911_LavuAttack1 $self_$41913;
		}
	}

	// Token: 0x020018EC RID: 6380
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41915 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009489 RID: 38025 RVA: 0x011B0964 File Offset: 0x011AEB64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41915(M911_LavuAttack1 self_)
		{
			if (14271 - 140183 != -125912)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (281087 - 335905 == -54818)
				{
					base..ctor();
					if (42390 - 94814 == -52424)
					{
						this.$self_$41917 = self_;
						if (202173 - 552275 != -350101)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600948A RID: 38026 RVA: 0x011B09FC File Offset: 0x011AEBFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack1.$StartGame$41915.$(this.$self_$41917);
		}

		// Token: 0x0600948B RID: 38027 RVA: 0x011B0A0C File Offset: 0x011AEC0C
		internal static bool Stp9FEVybnQE08nQfStv()
		{
			return true;
		}

		// Token: 0x0600948C RID: 38028 RVA: 0x011B0A10 File Offset: 0x011AEC10
		internal static bool y6srZgVyuoCF9ISsgTtM()
		{
			return false;
		}

		// Token: 0x04008B3F RID: 35647
		internal M911_LavuAttack1 $self_$41917;

		// Token: 0x020018ED RID: 6381
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600948D RID: 38029 RVA: 0x011B0A14 File Offset: 0x011AEC14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M911_LavuAttack1 self_)
			{
				if (87416 - 539945 != -452529)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (214668 - 145771 != 68898)
					{
						base..ctor();
						if (60135 - 592067 == -531932)
						{
							this.$self_$41916 = self_;
							if (196200 - 43648 != 152553)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600948E RID: 38030 RVA: 0x011B0AAC File Offset: 0x011AECAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (193159 - 393159 != -200000)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_146;
					case 2:
						this.$self_$41916.StartCoroutine_Auto(this.$self_$41916.StartEvent());
						if (253894 - 250415 == 3480)
						{
							continue;
						}
						this.YieldDefault(1);
						if (48337 - 484051 != -435714)
						{
							continue;
						}
						goto IL_146;
					default:
						if (54031 - 94842 != -40811)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (259290 - 93932 != 165359)
					{
						Game.mGameState = eGameState.Start;
						if (185630 - 198609 == -12979)
						{
							Game.mGameTime = Time.time;
							if (16928 - 405349 == -388421)
							{
								this.$self_$41916.SendMessage("fadeIn");
								if (247906 - 179180 != 68727)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_146:
				return false;
			}

			// Token: 0x0600948F RID: 38031 RVA: 0x011B0C14 File Offset: 0x011AEE14
			internal static bool VvTnr0VyIfxrxhAr2jy7()
			{
				return true;
			}

			// Token: 0x06009490 RID: 38032 RVA: 0x011B0C18 File Offset: 0x011AEE18
			internal static bool tmuv5dVyBH3rlpLYCTJ6()
			{
				return false;
			}

			// Token: 0x04008B40 RID: 35648
			internal M911_LavuAttack1 $self_$41916;
		}
	}

	// Token: 0x020018EE RID: 6382
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41918 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009491 RID: 38033 RVA: 0x011B0C1C File Offset: 0x011AEE1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41918(M911_LavuAttack1 self_)
		{
			if (284474 - 73661 != 210813)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (95572 - 378268 == -282696)
				{
					base..ctor();
					if (137059 - 197611 == -60552)
					{
						this.$self_$41923 = self_;
						if (247363 - 35123 == 212240)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009492 RID: 38034 RVA: 0x011B0CB4 File Offset: 0x011AEEB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack1.$onDeadPlayer$41918.$(this.$self_$41923);
		}

		// Token: 0x06009493 RID: 38035 RVA: 0x011B0CC4 File Offset: 0x011AEEC4
		internal static bool yKsDPiVyeFhpU47NGUou()
		{
			return true;
		}

		// Token: 0x06009494 RID: 38036 RVA: 0x011B0CC8 File Offset: 0x011AEEC8
		internal static bool GI9qXyVyrpHCNwGlfV19()
		{
			return false;
		}

		// Token: 0x04008B41 RID: 35649
		internal M911_LavuAttack1 $self_$41923;

		// Token: 0x020018EF RID: 6383
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009495 RID: 38037 RVA: 0x011B0CCC File Offset: 0x011AEECC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M911_LavuAttack1 self_)
			{
				if (80388 - 585808 != -505419)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (258870 - 188336 == 70534)
					{
						base..ctor();
						if (265504 - 16953 != 248552)
						{
							this.$self_$41922 = self_;
							if (110314 - 145540 == -35226)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009496 RID: 38038 RVA: 0x011B0D64 File Offset: 0x011AEF64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (240480 - 376914 != -136434)
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
							if (123230 - 469020 == -345789)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_28D;
							}
							if (119335 - 178534 == -59198)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (136354 - 434872 == -298517)
						{
							continue;
						}
						this.$mStoryGui$41919 = (StoryGui)this.$self_$41922.GetComponent(typeof(StoryGui));
						if (193923 - 22222 != 171701)
						{
							continue;
						}
						if (this.$mStoryGui$41919)
						{
							if (212256 - 477250 != -264994)
							{
								continue;
							}
							this.$mStoryGui$41919.close();
							if (54522 - 365155 == -310632)
							{
								continue;
							}
						}
						this.$mChangeGui$41920 = (ChangeGui)this.$self_$41922.GetComponent(typeof(ChangeGui));
						if (173905 - 336701 == -162795)
						{
							continue;
						}
						if (this.$mChangeGui$41920)
						{
							if (172190 - 128114 == 44077)
							{
								continue;
							}
							this.$mChangeGui$41920.close();
							if (290771 - 42061 != 248710)
							{
								continue;
							}
						}
						this.$mGameGui$41921 = (GameGui)this.$self_$41922.GetComponent(typeof(GameGui));
						if (166569 - 321766 == -155196)
						{
							continue;
						}
						if (this.$mGameGui$41921)
						{
							if (81568 - 505471 == -423902)
							{
								continue;
							}
							if (!this.$mGameGui$41921.enabled)
							{
								if (294515 - 245188 == 49328)
								{
									continue;
								}
								this.$mGameGui$41921.enabled = true;
								if (146581 - 22804 != 123777)
								{
									continue;
								}
							}
							this.$mGameGui$41921.openDeadMenu();
							if (139472 - 380644 != -241172)
							{
								continue;
							}
						}
						IL_28D:
						this.YieldDefault(1);
						if (230852 - 345281 != -114428)
						{
							goto Block_21;
						}
						continue;
					default:
						if (261374 - 444225 == -182850)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (138404 - 581304 != -442900);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_21:
				IL_2F9:
				return false;
			}

			// Token: 0x06009497 RID: 38039 RVA: 0x011B107C File Offset: 0x011AF27C
			internal static bool HX26TwVyjw1RmiArvmnF()
			{
				return true;
			}

			// Token: 0x06009498 RID: 38040 RVA: 0x011B1080 File Offset: 0x011AF280
			internal static bool xXkDa4VyhN85YAK7LicB()
			{
				return false;
			}

			// Token: 0x04008B42 RID: 35650
			internal StoryGui $mStoryGui$41919;

			// Token: 0x04008B43 RID: 35651
			internal ChangeGui $mChangeGui$41920;

			// Token: 0x04008B44 RID: 35652
			internal GameGui $mGameGui$41921;

			// Token: 0x04008B45 RID: 35653
			internal M911_LavuAttack1 $self_$41922;
		}
	}

	// Token: 0x020018F0 RID: 6384
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$41924 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009499 RID: 38041 RVA: 0x011B1084 File Offset: 0x011AF284
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$41924(Hashtable data, M911_LavuAttack1 self_)
		{
			if (97067 - 132239 != -35171)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (87950 - 441663 != -353712)
				{
					base..ctor();
					if (33472 - 149019 == -115547)
					{
						this.$data$41929 = data;
						if (123662 - 574290 != -450627)
						{
							this.$self_$41930 = self_;
							if (299366 - 384315 != -84948)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600949A RID: 38042 RVA: 0x011B1140 File Offset: 0x011AF340
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack1.$onChangePlayer$41924.$(this.$data$41929, this.$self_$41930);
		}

		// Token: 0x0600949B RID: 38043 RVA: 0x011B1154 File Offset: 0x011AF354
		internal static bool BlsRprVysOJdJOwdSLx7()
		{
			return true;
		}

		// Token: 0x0600949C RID: 38044 RVA: 0x011B1158 File Offset: 0x011AF358
		internal static bool Ah45gqVy9PThLvfBr9Cs()
		{
			return false;
		}

		// Token: 0x04008B46 RID: 35654
		internal Hashtable $data$41929;

		// Token: 0x04008B47 RID: 35655
		internal M911_LavuAttack1 $self_$41930;

		// Token: 0x020018F1 RID: 6385
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600949D RID: 38045 RVA: 0x011B115C File Offset: 0x011AF35C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M911_LavuAttack1 self_)
			{
				if (89572 - 229382 != -139809)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27927 - 79625 != -51697)
					{
						base..ctor();
						if (75127 - 563973 == -488846)
						{
							this.$data$41927 = data;
							if (218524 - 86110 != 132415)
							{
								this.$self_$41928 = self_;
								if (111867 - 109593 == 2274)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600949E RID: 38046 RVA: 0x011B1218 File Offset: 0x011AF418
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (99072 - 506243 != -407171)
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
							if (127073 - 566940 != -439867)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (59116 - 82745 == -23628)
							{
								continue;
							}
							this.$mGameGui$41926 = (GameGui)this.$self_$41928.GetComponent(typeof(GameGui));
							if (178347 - 132783 != 45564)
							{
								continue;
							}
							this.$mGameGui$41926.enabled = true;
							if (39460 - 140989 == -101528)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (52399 - 254625 != -202225)
						{
							goto Block_8;
						}
						continue;
					default:
						if (10588 - 21793 != -11205)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (33917 - 216556 != -182638)
					{
						this.$self_$41928.SendMessage("onCreatePlayer", this.$data$41927);
						if (62666 - 381174 != -318507)
						{
							this.$mChangeGui$41925 = (ChangeGui)this.$self_$41928.GetComponent(typeof(ChangeGui));
							if (39119 - 511828 == -472709)
							{
								if (!this.$mChangeGui$41925.enabled)
								{
									break;
								}
								if (202401 - 308767 != -106365)
								{
									this.$mChangeGui$41925.close();
									if (235302 - 523937 != -288634)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_8:
				IL_205:
				return false;
			}

			// Token: 0x0600949F RID: 38047 RVA: 0x011B143C File Offset: 0x011AF63C
			internal static bool qpjH8qVy1DyIc5FP8l2w()
			{
				return true;
			}

			// Token: 0x060094A0 RID: 38048 RVA: 0x011B1440 File Offset: 0x011AF640
			internal static bool x9nENhVy4MBjiyiujdtT()
			{
				return false;
			}

			// Token: 0x04008B48 RID: 35656
			internal ChangeGui $mChangeGui$41925;

			// Token: 0x04008B49 RID: 35657
			internal GameGui $mGameGui$41926;

			// Token: 0x04008B4A RID: 35658
			internal Hashtable $data$41927;

			// Token: 0x04008B4B RID: 35659
			internal M911_LavuAttack1 $self_$41928;
		}
	}

	// Token: 0x020018F2 RID: 6386
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$41931 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060094A1 RID: 38049 RVA: 0x011B1444 File Offset: 0x011AF644
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$41931(Hashtable data, M911_LavuAttack1 self_)
		{
			if (249303 - 546965 != -297661)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (185707 - 381226 != -195518)
				{
					base..ctor();
					if (117062 - 146223 == -29161)
					{
						this.$data$41939 = data;
						if (138987 - 115855 == 23132)
						{
							this.$self_$41940 = self_;
							if (158077 - 80353 != 77725)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060094A2 RID: 38050 RVA: 0x011B1500 File Offset: 0x011AF700
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack1.$onGameComplete$41931.$(this.$data$41939, this.$self_$41940);
		}

		// Token: 0x060094A3 RID: 38051 RVA: 0x011B1514 File Offset: 0x011AF714
		internal static bool vx71mSVyzb687emnCsUA()
		{
			return true;
		}

		// Token: 0x060094A4 RID: 38052 RVA: 0x011B1518 File Offset: 0x011AF718
		internal static bool svwbMKVSah8Rh1o9t24T()
		{
			return false;
		}

		// Token: 0x04008B4C RID: 35660
		internal Hashtable $data$41939;

		// Token: 0x04008B4D RID: 35661
		internal M911_LavuAttack1 $self_$41940;

		// Token: 0x020018F3 RID: 6387
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060094A5 RID: 38053 RVA: 0x011B151C File Offset: 0x011AF71C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M911_LavuAttack1 self_)
			{
				if (295682 - 158370 != 137312)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (170417 - 545206 != -374788)
					{
						base..ctor();
						if (188947 - 193855 != -4907)
						{
							this.$data$41937 = data;
							if (244052 - 342067 != -98014)
							{
								this.$self_$41938 = self_;
								if (208825 - 270606 != -61780)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060094A6 RID: 38054 RVA: 0x011B15D8 File Offset: 0x011AF7D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (289823 - 361301 != -71477)
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
						this.$mCompleteGui$41933 = (CompleteGui)this.$self_$41938.GetComponent(typeof(CompleteGui));
						if (54873 - 99589 != -44716)
						{
							continue;
						}
						this.$mCompleteGui$41933.Init();
						if (94160 - 535094 == -440933)
						{
							continue;
						}
						this.$mCompleteGui$41933.readData(this.$data$41937);
						if (289072 - 251841 == 37232)
						{
							continue;
						}
						if (this.$result$41932 == 1)
						{
							if (251702 - 167327 != 84375)
							{
								continue;
							}
							this.$mCompleteGui$41933.displayResult(eCompleteType.Success);
							if (28454 - 318314 != -289860)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$41933.displayResult(eCompleteType.Failed);
							if (70663 - 62905 != 7758)
							{
								continue;
							}
						}
						this.$mGameGui$41934 = (GameGui)this.$self_$41938.GetComponent(typeof(GameGui));
						if (103314 - 4113 == 99202)
						{
							continue;
						}
						this.$mStoryGui$41935 = (StoryGui)this.$self_$41938.GetComponent(typeof(StoryGui));
						if (172477 - 302235 != -129758)
						{
							continue;
						}
						this.$mChangeGui$41936 = (ChangeGui)this.$self_$41938.GetComponent(typeof(ChangeGui));
						if (102885 - 428368 != -325483)
						{
							continue;
						}
						if (this.$mGameGui$41934)
						{
							if (204327 - 385368 != -181041)
							{
								continue;
							}
							this.$mGameGui$41934.close();
							if (260374 - 338736 == -78361)
							{
								continue;
							}
						}
						if (this.$mStoryGui$41935)
						{
							if (58598 - 340968 == -282369)
							{
								continue;
							}
							this.$mStoryGui$41935.close();
							if (291229 - 478314 == -187084)
							{
								continue;
							}
						}
						if (this.$mChangeGui$41936)
						{
							if (29021 - 453894 != -424873)
							{
								continue;
							}
							this.$mChangeGui$41936.disable();
							if (107967 - 213201 != -105234)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (227840 - 342130 != -114290)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (31738 - 249810 == -218071)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$41937[31]);
					if (92422 - 598189 == -505767)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (19733 - 407815 != -388081)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (115730 - 460419 == -344689)
							{
								this.$result$41932 = RuntimeServices.UnboxInt32(this.$data$41937[31]);
								if (179387 - 577607 != -398219)
								{
									goto Block_27;
								}
							}
						}
					}
				}
				goto IL_3DB;
				Block_27:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x060094A7 RID: 38055 RVA: 0x011B19D4 File Offset: 0x011AFBD4
			internal static bool HoAd0GVS5R0YftIbFkTK()
			{
				return true;
			}

			// Token: 0x060094A8 RID: 38056 RVA: 0x011B19D8 File Offset: 0x011AFBD8
			internal static bool O6JL0bVSpBAXmjdCaynG()
			{
				return false;
			}

			// Token: 0x04008B4E RID: 35662
			internal int $result$41932;

			// Token: 0x04008B4F RID: 35663
			internal CompleteGui $mCompleteGui$41933;

			// Token: 0x04008B50 RID: 35664
			internal GameGui $mGameGui$41934;

			// Token: 0x04008B51 RID: 35665
			internal StoryGui $mStoryGui$41935;

			// Token: 0x04008B52 RID: 35666
			internal ChangeGui $mChangeGui$41936;

			// Token: 0x04008B53 RID: 35667
			internal Hashtable $data$41937;

			// Token: 0x04008B54 RID: 35668
			internal M911_LavuAttack1 $self_$41938;
		}
	}

	// Token: 0x020018F4 RID: 6388
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41941 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060094A9 RID: 38057 RVA: 0x011B19DC File Offset: 0x011AFBDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41941(M911_LavuAttack1 self_)
		{
			if (129017 - 198920 != -69902)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (249008 - 282405 != -33396)
				{
					base..ctor();
					if (135785 - 154013 == -18228)
					{
						this.$self_$41945 = self_;
						if (254740 - 224034 == 30706)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060094AA RID: 38058 RVA: 0x011B1A74 File Offset: 0x011AFC74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack1.$ReturnToTown$41941.$(this.$self_$41945);
		}

		// Token: 0x060094AB RID: 38059 RVA: 0x011B1A84 File Offset: 0x011AFC84
		internal static bool CjWZZSVSViHGFnTaHrM5()
		{
			return true;
		}

		// Token: 0x060094AC RID: 38060 RVA: 0x011B1A88 File Offset: 0x011AFC88
		internal static bool GI1vW9VStTgboWfUw9u3()
		{
			return false;
		}

		// Token: 0x04008B55 RID: 35669
		internal M911_LavuAttack1 $self_$41945;

		// Token: 0x020018F5 RID: 6389
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060094AD RID: 38061 RVA: 0x011B1A8C File Offset: 0x011AFC8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M911_LavuAttack1 self_)
			{
				if (276725 - 160954 != 115771)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (188437 - 192138 == -3701)
					{
						base..ctor();
						if (264650 - 91328 != 173323)
						{
							this.$self_$41944 = self_;
							if (66277 - 275805 == -209528)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060094AE RID: 38062 RVA: 0x011B1B24 File Offset: 0x011AFD24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (144769 - 122129 != 22640)
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
						this.$self_$41944.LeaveGame();
						if (126459 - 315575 != -189116)
						{
							continue;
						}
						this.YieldDefault(1);
						if (30480 - 142943 != -112463)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (138404 - 168417 != -30013)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (276512 - 176010 == 100502)
					{
						Game.mStateTime = Time.time;
						if (45210 - 238822 == -193612)
						{
							this.$$switch$7564$41942 = PlayerData.SaveGuild;
							if (23019 - 353931 == -330912)
							{
								if (this.$$switch$7564$41942 == 1)
								{
									if (77233 - 280488 != -203255)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (101966 - 93960 != 8006)
									{
										continue;
									}
								}
								else if (this.$$switch$7564$41942 == 2)
								{
									if (160496 - 473117 == -312620)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (167391 - 408421 == -241029)
									{
										continue;
									}
								}
								else if (this.$$switch$7564$41942 == 3)
								{
									if (44398 - 44761 != -363)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (246560 - 562438 != -315878)
									{
										continue;
									}
								}
								else if (this.$$switch$7564$41942 == 4)
								{
									if (144108 - 358596 == -214487)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (260920 - 234301 != 26619)
									{
										continue;
									}
								}
								else if (this.$$switch$7564$41942 == 5)
								{
									if (117377 - 332089 != -214712)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (155311 - 406276 == -250964)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (152574 - 166066 != -13492)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (233096 - 504611 == -271514)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (205264 - 105657 == 99608)
									{
										continue;
									}
								}
								this.$mGameGui$41943 = (GameGui)this.$self_$41944.GetComponent(typeof(GameGui));
								if (160647 - 228549 == -67902)
								{
									if (this.$mGameGui$41943)
									{
										if (285470 - 497539 != -212069)
										{
											continue;
										}
										this.$mGameGui$41943.close();
										if (63273 - 22526 != 40747)
										{
											continue;
										}
									}
									this.$self_$41944.SendMessage("fadeOut");
									if (202917 - 248803 == -45886)
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

			// Token: 0x060094AF RID: 38063 RVA: 0x011B1EF0 File Offset: 0x011B00F0
			internal static bool fkbeU6VSN0aKsu5hSkbg()
			{
				return true;
			}

			// Token: 0x060094B0 RID: 38064 RVA: 0x011B1EF4 File Offset: 0x011B00F4
			internal static bool FDaj0IVSYwk6nCg84hwn()
			{
				return false;
			}

			// Token: 0x04008B56 RID: 35670
			internal int $$switch$7564$41942;

			// Token: 0x04008B57 RID: 35671
			internal GameGui $mGameGui$41943;

			// Token: 0x04008B58 RID: 35672
			internal M911_LavuAttack1 $self_$41944;
		}
	}

	// Token: 0x020018F6 RID: 6390
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41946 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060094B1 RID: 38065 RVA: 0x011B1EF8 File Offset: 0x011B00F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41946(M911_LavuAttack1 self_)
		{
			if (452 - 222430 != -221978)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (251752 - 453639 != -201886)
				{
					base..ctor();
					if (191503 - 500234 == -308731)
					{
						this.$self_$41949 = self_;
						if (272959 - 72331 != 200629)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060094B2 RID: 38066 RVA: 0x011B1F90 File Offset: 0x011B0190
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack1.$ReturnToGuild$41946.$(this.$self_$41949);
		}

		// Token: 0x060094B3 RID: 38067 RVA: 0x011B1FA0 File Offset: 0x011B01A0
		internal static bool deYCg6VScjPxHUdGLTW7()
		{
			return true;
		}

		// Token: 0x060094B4 RID: 38068 RVA: 0x011B1FA4 File Offset: 0x011B01A4
		internal static bool NkHJ17VSUdt17PPooF1C()
		{
			return false;
		}

		// Token: 0x04008B59 RID: 35673
		internal M911_LavuAttack1 $self_$41949;

		// Token: 0x020018F7 RID: 6391
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060094B5 RID: 38069 RVA: 0x011B1FA8 File Offset: 0x011B01A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M911_LavuAttack1 self_)
			{
				if (26692 - 509339 != -482646)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (205343 - 302287 == -96944)
					{
						base..ctor();
						if (176944 - 579620 == -402676)
						{
							this.$self_$41948 = self_;
							if (15292 - 248821 == -233529)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060094B6 RID: 38070 RVA: 0x011B2040 File Offset: 0x011B0240
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (184980 - 372483 != -187503)
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
						this.$self_$41948.LeaveGame();
						if (169276 - 120905 == 48372)
						{
							continue;
						}
						this.YieldDefault(1);
						if (104045 - 189215 != -85169)
						{
							goto Block_3;
						}
						continue;
					default:
						if (192291 - 571879 != -379588)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (86534 - 210756 != -124221)
					{
						Game.mStateTime = Time.time;
						if (251696 - 83529 == 168167)
						{
							Game.mNextGameCode = 31;
							if (213261 - 220038 != -6776)
							{
								this.$mGameGui$41947 = (GameGui)this.$self_$41948.GetComponent(typeof(GameGui));
								if (287608 - 366966 != -79357)
								{
									if (this.$mGameGui$41947)
									{
										if (75112 - 493570 != -418458)
										{
											continue;
										}
										this.$mGameGui$41947.close();
										if (162896 - 35957 != 126939)
										{
											continue;
										}
									}
									this.$self_$41948.SendMessage("fadeOut");
									if (53108 - 410734 != -357625)
									{
										goto Block_11;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_1BD;
				Block_11:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x060094B7 RID: 38071 RVA: 0x011B221C File Offset: 0x011B041C
			internal static bool iibMKBVST6UhU6MSD6FM()
			{
				return true;
			}

			// Token: 0x060094B8 RID: 38072 RVA: 0x011B2220 File Offset: 0x011B0420
			internal static bool ILk1DZVS3E0yiw0OYpJJ()
			{
				return false;
			}

			// Token: 0x04008B5A RID: 35674
			internal GameGui $mGameGui$41947;

			// Token: 0x04008B5B RID: 35675
			internal M911_LavuAttack1 $self_$41948;
		}
	}

	// Token: 0x020018F8 RID: 6392
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$41950 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060094B9 RID: 38073 RVA: 0x011B2224 File Offset: 0x011B0424
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$41950(M911_LavuAttack1 self_)
		{
			if (24468 - 8787 != 15681)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (83377 - 212210 != -128832)
				{
					base..ctor();
					if (97528 - 88497 == 9031)
					{
						this.$self_$41954 = self_;
						if (247569 - 175284 != 72286)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060094BA RID: 38074 RVA: 0x011B22BC File Offset: 0x011B04BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M911_LavuAttack1.$ReturnToCamp$41950.$(this.$self_$41954);
		}

		// Token: 0x060094BB RID: 38075 RVA: 0x011B22CC File Offset: 0x011B04CC
		internal static bool hS1RAmVSXB3Ut40vE6I2()
		{
			return true;
		}

		// Token: 0x060094BC RID: 38076 RVA: 0x011B22D0 File Offset: 0x011B04D0
		internal static bool IEiOPHVSQLpipRhaiEXO()
		{
			return false;
		}

		// Token: 0x04008B5C RID: 35676
		internal M911_LavuAttack1 $self_$41954;

		// Token: 0x020018F9 RID: 6393
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060094BD RID: 38077 RVA: 0x011B22D4 File Offset: 0x011B04D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M911_LavuAttack1 self_)
			{
				if (120103 - 435259 != -315155)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (164521 - 4718 == 159803)
					{
						base..ctor();
						if (231535 - 245897 != -14361)
						{
							this.$self_$41953 = self_;
							if (270008 - 449537 != -179528)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060094BE RID: 38078 RVA: 0x011B236C File Offset: 0x011B056C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (103888 - 447351 != -343462)
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
						this.$self_$41953.LeaveGame();
						if (145917 - 393307 == -247389)
						{
							continue;
						}
						this.YieldDefault(1);
						if (229871 - 358826 != -128954)
						{
							goto Block_9;
						}
						continue;
					default:
						if (17014 - 229489 == -212474)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (49931 - 5668 != 44264)
					{
						Game.mStateTime = Time.time;
						if (41058 - 504007 != -462948)
						{
							this.$$switch$7566$41951 = PlayerData.SaveGuild;
							if (201543 - 455322 == -253779)
							{
								if (this.$$switch$7566$41951 == 1)
								{
									if (241559 - 437399 == -195839)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (71094 - 585937 == -514842)
									{
										continue;
									}
								}
								else if (this.$$switch$7566$41951 == 2)
								{
									if (160279 - 534294 != -374015)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (184757 - 135323 != 49434)
									{
										continue;
									}
								}
								else if (this.$$switch$7566$41951 == 3)
								{
									if (46367 - 594840 == -548472)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (159184 - 96969 == 62216)
									{
										continue;
									}
								}
								else if (this.$$switch$7566$41951 == 4)
								{
									if (207902 - 313657 != -105755)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (151488 - 284504 == -133015)
									{
										continue;
									}
								}
								else if (this.$$switch$7566$41951 == 5)
								{
									if (5970 - 407502 == -401531)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (246292 - 48964 != 197328)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (143843 - 570710 == -426866)
									{
										continue;
									}
								}
								this.$mGameGui$41952 = (GameGui)this.$self_$41953.GetComponent(typeof(GameGui));
								if (226391 - 155053 == 71338)
								{
									if (this.$mGameGui$41952)
									{
										if (31673 - 386612 != -354939)
										{
											continue;
										}
										this.$mGameGui$41952.close();
										if (296008 - 524889 != -228881)
										{
											continue;
										}
									}
									this.$self_$41953.SendMessage("fadeOut");
									if (48186 - 47049 == 1137)
									{
										goto IL_2EA;
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_363;
				IL_2EA:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x060094BF RID: 38079 RVA: 0x011B26F0 File Offset: 0x011B08F0
			internal static bool JVa8gLVSkhhMd5KQCKSH()
			{
				return true;
			}

			// Token: 0x060094C0 RID: 38080 RVA: 0x011B26F4 File Offset: 0x011B08F4
			internal static bool VfMa8VVSGS1uU275b246()
			{
				return false;
			}

			// Token: 0x04008B5D RID: 35677
			internal int $$switch$7566$41951;

			// Token: 0x04008B5E RID: 35678
			internal GameGui $mGameGui$41952;

			// Token: 0x04008B5F RID: 35679
			internal M911_LavuAttack1 $self_$41953;
		}
	}
}
