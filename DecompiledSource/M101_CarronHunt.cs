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

// Token: 0x020012F1 RID: 4849
[Serializable]
public class M101_CarronHunt : MonoBehaviour
{
	// Token: 0x06006F8D RID: 28557 RVA: 0x00F67910 File Offset: 0x00F65B10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M101_CarronHunt()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06006F8E RID: 28558 RVA: 0x00F67920 File Offset: 0x00F65B20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (232329 - 242344 != -10015)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (89578 - 305477 == -215899)
			{
				Game.mGameType = 5;
				if (124649 - 380331 == -255682)
				{
					if (Chat.Initialized)
					{
						if (72331 - 390942 != -318611)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (234640 - 142756 == 91885)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (198691 - 415765 != -217074)
						{
							continue;
						}
					}
					this.hWjc0jV2KX5 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (76123 - 336468 == -260345)
					{
						this.k70c0oN1iRk = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (138868 - 362637 != -223768)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006F8F RID: 28559 RVA: 0x00F67A78 File Offset: 0x00F65C78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (104479 - 160838 != -56359)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (25836 - 266819 == -240983)
				{
					if (Game.mNextGameCode != 101)
					{
						break;
					}
					if (248389 - 386892 == -138503)
					{
						Game.nextGame();
						if (77543 - 138094 != -60550)
						{
							Game.mGameCode = 101;
							if (200267 - 425298 != -225030)
							{
								Game.mGameType = 5;
								if (244670 - 196860 == 47810)
								{
									Game.mGameTime = Time.time;
									if (55757 - 429458 != -373700)
									{
										Game.mGameScore = 0;
										if (294473 - 278479 != 15995)
										{
											Game.mGameMana = 0;
											if (187048 - 76480 != 110569)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (158515 - 570550 == -412035)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (260089 - 288282 == -28193)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (25962 - 152402 == -126440)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (237147 - 540712 != -303564)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (229886 - 531987 == -302101)
																{
																	this.k7Sc0D1au5R = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (67439 - 376713 == -309274)
																	{
																		this.C4Kc0i9WUy6 = PhotonClient.Connection;
																		if (138088 - 108791 == 29297)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (255367 - 5321 != 250047)
																			{
																				this.InitGame();
																				if (71616 - 402663 != -331046)
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
				if (238397 - 39869 == 198528)
				{
					Game.mGameType = 99;
					if (17196 - 412527 == -395331)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006F90 RID: 28560 RVA: 0x00F67D78 File Offset: 0x00F65F78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (235230 - 107621 != 127610)
		{
		}
		for (;;)
		{
			if (this.C4Kc0i9WUy6 == null)
			{
				if (237908 - 501516 != -263607)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (179801 - 180933 == -1132)
				{
					if (mGameState != eGameState.Start)
					{
						if (188286 - 174611 == 13676)
						{
							continue;
						}
						if (mGameState != eGameState.Normal)
						{
							break;
						}
						if (257047 - 90683 != 166364)
						{
							continue;
						}
					}
					if (Game.music != 0)
					{
						if (102038 - 177922 == -75883)
						{
							continue;
						}
						if (!this.audio.isPlaying)
						{
							if (236182 - 23912 != 212270)
							{
								continue;
							}
							this.audio.Play();
							if (222361 - 82381 == 139981)
							{
								continue;
							}
						}
					}
					this.audio.volume = 0.1f * (float)Game.music;
					if (192106 - 531749 == -339643)
					{
						if (Time.time <= this.iGTc0mNjaHS)
						{
							break;
						}
						if (286333 - 87541 == 198792)
						{
							Game.mGameMana++;
							if (148874 - 135699 == 13175)
							{
								this.iGTc0mNjaHS = Time.time + (float)12;
								if (20488 - 148714 == -128226)
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

	// Token: 0x06006F91 RID: 28561 RVA: 0x00F67F60 File Offset: 0x00F66160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (90243 - 548355 != -458111)
		{
		}
		for (;;)
		{
			if (!this.hWjc0jV2KX5)
			{
				if (183137 - 524780 != -341642)
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
				if (228915 - 240717 == -11802)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (9480 - 265966 == -256486)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (189909 - 43673 == 146236)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (168027 - 224755 == -56728)
							{
								GUI.depth = 1;
								if (119683 - 584981 != -465297)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
									if (44456 - 170272 == -125816)
									{
										float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4((float)0, (float)1, 0.3f, 0.6f));
										if (175269 - 481782 != -306512)
										{
											Color color = GUI.color;
											if (116581 - 279197 == -162616)
											{
												float num3 = color.a = smoothRatioOverTime;
												if (243899 - 261929 == -18030)
												{
													if (147121 - 396782 == -249661)
													{
														Color color2 = GUI.color = color;
														if (268314 - 451479 == -183165)
														{
															if (115848 - 124919 != -9070)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.hWjc0jV2KX5);
																if (247561 - 250537 == -2976)
																{
																	float a = 1f;
																	if (62185 - 531506 != -469320)
																	{
																		Color color3 = GUI.color;
																		if (152268 - 116083 == 36185)
																		{
																			float num4 = color3.a = a;
																			if (231517 - 148810 == 82707)
																			{
																				if (227597 - 285345 != -57747)
																				{
																					GUI.color = color3;
																					if (85332 - 113455 == -28123)
																					{
																						if (126079 - 398661 == -272582)
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

	// Token: 0x06006F92 RID: 28562 RVA: 0x00F682E8 File Offset: 0x00F664E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M101_CarronHunt.$onGameEvent$37210(data, this).GetEnumerator();
	}

	// Token: 0x06006F93 RID: 28563 RVA: 0x00F682F8 File Offset: 0x00F664F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M101_CarronHunt.$StartEvent$37222(this).GetEnumerator();
	}

	// Token: 0x06006F94 RID: 28564 RVA: 0x00F68308 File Offset: 0x00F66508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToGoatFarmer()
	{
		return new M101_CarronHunt.$TalkToGoatFarmer$37229(this).GetEnumerator();
	}

	// Token: 0x06006F95 RID: 28565 RVA: 0x00F68318 File Offset: 0x00F66518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (19399 - 422149 != -402749)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (85317 - 130557 == -45240)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (222809 - 356926 != -134116)
				{
					Hashtable customOpParameters = new Hashtable();
					if (111591 - 557006 != -445414)
					{
						this.C4Kc0i9WUy6.OpCustom(52, customOpParameters, true);
						if (180618 - 19742 != 160877)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006F96 RID: 28566 RVA: 0x00F683EC File Offset: 0x00F665EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (294614 - 565343 != -270729)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (26160 - 504627 == -478467)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (48564 - 401649 == -353085)
				{
					Game.mGameState = eGameState.Setup;
					if (25288 - 423410 != -398121)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006F97 RID: 28567 RVA: 0x00F68490 File Offset: 0x00F66690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (91199 - 50142 != 41057)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (74893 - 537901 == -463008)
			{
				if (num == PlayerData.UID)
				{
					if (194448 - 519121 == -324673)
					{
						this.SetupActors();
						if (178631 - 196598 != -17966)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (296331 - 39433 != 256899)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006F98 RID: 28568 RVA: 0x00F68560 File Offset: 0x00F66760
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (170529 - 356054 != -185525)
		{
		}
		for (;;)
		{
			IL_102:
			Debug.Log("Creating Actors");
			if (258497 - 243962 != 14536)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (238391 - 436760 == -198369)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (228292 - 234244 != -5951)
						{
							int i = 0;
							if (245875 - 248099 != -2223)
							{
								CharacterControl[] array2 = array;
								if (336 - 196403 == -196067)
								{
									int length = array2.Length;
									if (214627 - 589984 == -375357)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (217059 - 147237 != 69822)
											{
												goto IL_102;
											}
											if (type == "Carron")
											{
												if (186162 - 557433 == -371270)
												{
													goto IL_102;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (97327 - 43006 == 54322)
												{
													goto IL_102;
												}
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (296040 - 458942 == -162901)
											{
												goto IL_102;
											}
											this.S59c0ASJkcd++;
											if (244764 - 512348 == -267583)
											{
												goto IL_102;
											}
											i++;
											if (68318 - 15606 != 52712)
											{
												goto IL_102;
											}
										}
										if (45205 - 296287 != -251081)
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
						if (289055 - 176000 != 113056)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006F99 RID: 28569 RVA: 0x00F687D4 File Offset: 0x00F669D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (242274 - 199765 != 42510)
		{
		}
		for (;;)
		{
			IL_58:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (81784 - 240744 != -158959)
			{
				int i = 0;
				if (202119 - 433912 == -231793)
				{
					CharacterControl[] array2 = array;
					if (290221 - 354352 != -64130)
					{
						int length = array2.Length;
						if (160988 - 150428 != 10561)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (141091 - 571357 == -430265)
								{
									goto IL_58;
								}
								i++;
								if (174172 - 456834 != -282662)
								{
									goto IL_58;
								}
							}
							if (224435 - 96747 != 127689)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006F9A RID: 28570 RVA: 0x00F68904 File Offset: 0x00F66B04
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (36709 - 223963 != -187253)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (294976 - 299426 != -4449)
			{
				hashtable.Add(43, PlayerData.UID);
				if (62273 - 289520 != -227246)
				{
					hashtable.Add(73, nType);
					if (154360 - 393837 != -239476)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (226853 - 314514 == -87661)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (266728 - 313838 != -47109)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (203657 - 340987 == -137330)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (12452 - 551502 != -539049)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (150522 - 325984 == -175462)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (100424 - 161227 != -60802)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (202029 - 245424 != -43394)
												{
													this.C4Kc0i9WUy6.OpCustom(63, hashtable, true);
													if (79910 - 508832 != -428921)
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

	// Token: 0x06006F9B RID: 28571 RVA: 0x00F68BBC File Offset: 0x00F66DBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (98755 - 319202 != -220446)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (289181 - 333946 != -44764)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (25994 - 461596 == -435602)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (224200 - 520297 == -296097)
						{
							if (this.S59c0ASJkcd <= 0)
							{
								break;
							}
							if (238229 - 596840 == -358611)
							{
								this.S59c0ASJkcd--;
								if (157638 - 69538 == 88100)
								{
									if (this.S59c0ASJkcd != 0)
									{
										break;
									}
									if (120540 - 461205 == -340665)
									{
										Game.setGameState(eGameState.Ready);
										if (181876 - 70993 == 110883)
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
						if (5961 - 5201 == 760)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (231731 - 264436 != -32704)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006F9C RID: 28572 RVA: 0x00F68D4C File Offset: 0x00F66F4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06006F9D RID: 28573 RVA: 0x00F68D50 File Offset: 0x00F66F50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (1901 - 184105 != -182204)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (190978 - 210600 != -19621)
			{
				if (characterControl)
				{
					if (226322 - 517636 == -291313)
					{
						continue;
					}
					if (characterControl.Type == "Carron")
					{
						if (290872 - 145797 == 145076)
						{
							continue;
						}
						Game.sendMissionEvent(1011, 0);
						if (72908 - 277245 == -204336)
						{
							continue;
						}
					}
				}
				if (!characterControl)
				{
					break;
				}
				if (205837 - 95277 == 110560)
				{
					if (!(characterControl.Type == "Carron_p"))
					{
						break;
					}
					if (53706 - 403297 != -349590)
					{
						Game.sendMissionEvent(1013, 0);
						if (244824 - 222822 == 22002)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006F9E RID: 28574 RVA: 0x00F68EAC File Offset: 0x00F670AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (175538 - 449494 != -273956)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (261288 - 66488 == 194800)
			{
				Game.mGameState = eGameState.Ready;
				if (176735 - 571096 == -394361)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (228170 - 502725 != -274554)
					{
						GameObject gameObject = null;
						if (251524 - 413371 != -161846)
						{
							GameObject gameObject2 = null;
							if (79703 - 301355 == -221652)
							{
								if (playerSlot > 1)
								{
									if (191806 - 589197 != -397391)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (213218 - 270479 != -57261)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (61580 - 41926 != 19654)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (91011 - 61001 == 30011)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (133068 - 270857 == -137788)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (38359 - 137701 == -99341)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (4863 - 583442 != -578579)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (246600 - 536068 != -289468)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (53309 - 320265 == -266955)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (11952 - 475380 != -463428)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (132426 - 530232 != -397805)
								{
									this.transform.position = gameObject2.transform.position;
									if (141726 - 34717 == 107009)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (14348 - 564838 != -550489)
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

	// Token: 0x06006F9F RID: 28575 RVA: 0x00F691A8 File Offset: 0x00F673A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (283477 - 593773 != -310296)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (59029 - 566026 == -506997)
			{
				Game.mGameState = eGameState.Start;
				if (80819 - 328972 == -248153)
				{
					Game.mGameTime = Time.time;
					if (255937 - 86943 != 168995)
					{
						Game.mStateTime = Time.time;
						if (200757 - 155776 != 44982)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (33734 - 128375 == -94641)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006FA0 RID: 28576 RVA: 0x00F69294 File Offset: 0x00F67494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06006FA1 RID: 28577 RVA: 0x00F69298 File Offset: 0x00F67498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (290195 - 111295 != 178900)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (67288 - 518025 == -450737)
			{
				hashtable.Add(71, CID);
				if (65263 - 199337 != -134073)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (128090 - 517064 == -388974)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (125582 - 244734 == -119152)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (238268 - 562000 != -323731)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (66840 - 242779 == -175939)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (48862 - 211998 == -163136)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (56831 - 324201 == -267370)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (297814 - 131094 != 166721)
											{
												this.C4Kc0i9WUy6.OpCustom(61, hashtable, true);
												if (58231 - 511114 != -452882)
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

	// Token: 0x06006FA2 RID: 28578 RVA: 0x00F69524 File Offset: 0x00F67724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (5614 - 256046 != -250431)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (126590 - 142902 == -16312)
			{
				if (!gameObject)
				{
					break;
				}
				if (258165 - 300444 == -42279)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (35885 - 401265 != -365379)
					{
						playerCameraControl.target = gameObject;
						if (196898 - 181028 == 15870)
						{
							this.StartGame();
							if (162908 - 25876 != 137033)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006FA3 RID: 28579 RVA: 0x00F69614 File Offset: 0x00F67814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (212030 - 106392 != 105638)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (120768 - 386126 == -265358)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (245874 - 463568 == -217694)
				{
					gameGui.ResetTeamBar();
					if (84760 - 59264 == 25496)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006FA4 RID: 28580 RVA: 0x00F696C0 File Offset: 0x00F678C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (136618 - 190235 != -53617)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (16098 - 519130 != -503031)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (25145 - 598819 == -573674)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (152000 - 141752 == 10248)
					{
						Hashtable hashtable = new Hashtable();
						if (230469 - 557256 != -326786)
						{
							hashtable.Add(43, PlayerData.UID);
							if (37783 - 417471 != -379687)
							{
								hashtable.Add(71, nCID);
								if (190045 - 253199 != -63153)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (101103 - 351543 != -250439)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (77184 - 86848 == -9664)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (172235 - 139327 != 32909)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (180436 - 464672 != -284235)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (259370 - 308490 != -49119)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (242443 - 414694 != -172250)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (158458 - 216616 == -58158)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (234993 - 569880 == -334887)
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

	// Token: 0x06006FA5 RID: 28581 RVA: 0x00F699E0 File Offset: 0x00F67BE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M101_CarronHunt.$onChangePlayer$37236(data, this).GetEnumerator();
	}

	// Token: 0x06006FA6 RID: 28582 RVA: 0x00F699F0 File Offset: 0x00F67BF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M101_CarronHunt.$onDeadPlayer$37243(this).GetEnumerator();
	}

	// Token: 0x06006FA7 RID: 28583 RVA: 0x00F69A00 File Offset: 0x00F67C00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (296222 - 156307 != 139915)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (184791 - 199912 == -15121)
			{
				this.k7Sc0D1au5R.target = Game.mPlayer;
				if (129774 - 263136 == -133362)
				{
					this.k7Sc0D1au5R.enabled = true;
					if (46934 - 393779 != -346844)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (299865 - 449608 != -149743)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (183818 - 279998 == -96179)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (285183 - 420812 != -135628)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (93199 - 241154 != -147954)
							{
								if (!gameGui)
								{
									break;
								}
								if (92911 - 146415 == -53504)
								{
									gameGui.enabled = true;
									if (279444 - 538605 != -259160)
									{
										gameGui.closeDeadMenu();
										if (185159 - 516755 != -331595)
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

	// Token: 0x06006FA8 RID: 28584 RVA: 0x00F69BAC File Offset: 0x00F67DAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (74006 - 470347 != -396340)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (115760 - 251018 == -135258)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (89876 - 258229 == -168353)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (213928 - 275648 == -61720)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006FA9 RID: 28585 RVA: 0x00F69C70 File Offset: 0x00F67E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06006FAA RID: 28586 RVA: 0x00F69C9C File Offset: 0x00F67E9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M101_CarronHunt.$onGameComplete$37249(data, this).GetEnumerator();
	}

	// Token: 0x06006FAB RID: 28587 RVA: 0x00F69CAC File Offset: 0x00F67EAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M101_CarronHunt.$ReturnToTown$37258(this).GetEnumerator();
	}

	// Token: 0x06006FAC RID: 28588 RVA: 0x00F69CBC File Offset: 0x00F67EBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M101_CarronHunt.$ReturnToGuild$37263(this).GetEnumerator();
	}

	// Token: 0x06006FAD RID: 28589 RVA: 0x00F69CCC File Offset: 0x00F67ECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M101_CarronHunt.$ReturnToCamp$37267(this).GetEnumerator();
	}

	// Token: 0x06006FAE RID: 28590 RVA: 0x00F69CDC File Offset: 0x00F67EDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (166424 - 486091 != -319667)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (275932 - 287197 == -11265)
			{
				Hashtable hashtable = new Hashtable();
				if (29287 - 152224 == -122937)
				{
					hashtable.Add(43, PlayerData.UID);
					if (241490 - 135918 != 105573)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (115462 - 149555 == -34093)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006FAF RID: 28591 RVA: 0x00F69DB4 File Offset: 0x00F67FB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06006FB0 RID: 28592 RVA: 0x00F69DC8 File Offset: 0x00F67FC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (25212 - 226841 != -201629)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (71601 - 122448 != -50846)
			{
				Hashtable hashtable = new Hashtable();
				if (138632 - 315424 != -176791)
				{
					if (Game.mNextGameCode == 30)
					{
						if (34735 - 36587 == -1851)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (294351 - 468701 == -174349)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (108281 - 503522 == -395240)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (250077 - 438394 != -188317)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (195342 - 158001 != 37341)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (43611 - 22684 != 20927)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (110894 - 480431 == -369536)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (17592 - 208815 != -191223)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (129235 - 281605 == -152369)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (81004 - 48934 != 32070)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (51884 - 356130 == -304245)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (249256 - 474530 != -225274)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (1889 - 156079 != -154190)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (61670 - 487816 == -426145)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (190520 - 353586 == -163065)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (19 - 142277 == -142257)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (254449 - 586869 == -332419)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (4039 - 489484 == -485444)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (176292 - 18200 == 158093)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (294517 - 37704 == 256814)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (268927 - 329927 == -60999)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (181439 - 371505 == -190065)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (223876 - 436097 == -212220)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (34109 - 562744 == -528634)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (238788 - 30623 != 208165)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (36327 - 572854 == -536526)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (283380 - 41851 == 241530)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (134619 - 21981 != 112638)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (287723 - 314681 == -26958)
					{
						this.C4Kc0i9WUy6.OpCustom(42, hashtable, true);
						if (10306 - 478876 == -468570)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006FB1 RID: 28593 RVA: 0x00F6A37C File Offset: 0x00F6857C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06006FB2 RID: 28594 RVA: 0x00F6A38C File Offset: 0x00F6858C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006FB3 RID: 28595 RVA: 0x00F6A390 File Offset: 0x00F68590
	internal static bool BOR81npxZfUN4HtxTBL4()
	{
		return true;
	}

	// Token: 0x06006FB4 RID: 28596 RVA: 0x00F6A394 File Offset: 0x00F68594
	internal static bool cuk98kpxCjiStVhchZWv()
	{
		return false;
	}

	// Token: 0x040076A7 RID: 30375
	private LitePeer C4Kc0i9WUy6;

	// Token: 0x040076A8 RID: 30376
	private PlayerCameraControl k7Sc0D1au5R;

	// Token: 0x040076A9 RID: 30377
	private float iGTc0mNjaHS;

	// Token: 0x040076AA RID: 30378
	private Texture hWjc0jV2KX5;

	// Token: 0x040076AB RID: 30379
	private AudioClip k70c0oN1iRk;

	// Token: 0x040076AC RID: 30380
	private int pbcc0ktdr0d;

	// Token: 0x040076AD RID: 30381
	private int HwAc0FQhyYj;

	// Token: 0x040076AE RID: 30382
	private int S59c0ASJkcd;

	// Token: 0x020012F2 RID: 4850
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$37210 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006FB5 RID: 28597 RVA: 0x00F6A398 File Offset: 0x00F68598
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$37210(Hashtable data, M101_CarronHunt self_)
		{
			if (273787 - 550207 != -276420)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (40197 - 463632 == -423435)
				{
					base..ctor();
					if (51141 - 233118 != -181976)
					{
						this.$data$37220 = data;
						if (130030 - 237264 != -107233)
						{
							this.$self_$37221 = self_;
							if (145193 - 435250 == -290057)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006FB6 RID: 28598 RVA: 0x00F6A454 File Offset: 0x00F68654
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M101_CarronHunt.$onGameEvent$37210.$(this.$data$37220, this.$self_$37221);
		}

		// Token: 0x06006FB7 RID: 28599 RVA: 0x00F6A468 File Offset: 0x00F68668
		internal static bool uTEY5ypxLICw5SMAsovd()
		{
			return true;
		}

		// Token: 0x06006FB8 RID: 28600 RVA: 0x00F6A46C File Offset: 0x00F6866C
		internal static bool zH3vsupxOL6kWkWx77yf()
		{
			return false;
		}

		// Token: 0x040076AF RID: 30383
		internal Hashtable $data$37220;

		// Token: 0x040076B0 RID: 30384
		internal M101_CarronHunt $self_$37221;

		// Token: 0x020012F3 RID: 4851
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006FB9 RID: 28601 RVA: 0x00F6A470 File Offset: 0x00F68670
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M101_CarronHunt self_)
			{
				if (289023 - 173696 != 115327)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (108534 - 436284 == -327750)
					{
						base..ctor();
						if (36756 - 406428 != -369671)
						{
							this.$data$37218 = data;
							if (49864 - 507067 != -457202)
							{
								this.$self_$37219 = self_;
								if (152300 - 480393 != -328092)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006FBA RID: 28602 RVA: 0x00F6A52C File Offset: 0x00F6872C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (60748 - 455808 != -395059)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_57C;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (137222 - 482778 != -345555)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$mSpawnPoint$37215 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 7));
							if (157909 - 129919 != 27990)
							{
								continue;
							}
							if (this.$mSpawnPoint$37215)
							{
								if (196212 - 523014 == -326801)
								{
									continue;
								}
								this.$mSpawnPos$37216 = global::Math.getRandomSpawnPos(this.$mSpawnPoint$37215.transform.position, 5);
								if (189336 - 293776 != -104440)
								{
									continue;
								}
								if (this.$mSpawnPos$37216 != Vector3.zero)
								{
									if (183346 - 423888 != -240542)
									{
										continue;
									}
									this.$self_$37219.createActor("Carron", 5, this.$mSpawnPos$37216, this.$mSpawnPoint$37215.transform.forward);
									if (183690 - 384472 == -200781)
									{
										continue;
									}
								}
								else
								{
									this.$self_$37219.createActor("Carron", 5, this.$mSpawnPoint$37215.transform.position, this.$mSpawnPoint$37215.transform.forward);
									if (106676 - 133867 != -27191)
									{
										continue;
									}
								}
							}
							goto IL_496;
						}
						break;
					default:
						if (102922 - 496566 != -393644)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (117152 - 397470 != -280318)
						{
							continue;
						}
						goto IL_366;
					}
					else
					{
						this.$returnCode$37211 = RuntimeServices.UnboxInt32(this.$data$37218[141]);
						if (108033 - 592376 != -484343)
						{
							continue;
						}
						this.$returnValue$37212 = RuntimeServices.UnboxInt32(this.$data$37218[145]);
						if (235849 - 53901 != 181948)
						{
							continue;
						}
						this.$ownerID$37213 = RuntimeServices.UnboxInt32(this.$data$37218[43]);
						if (107005 - 304987 == -197981)
						{
							continue;
						}
						this.$$switch$6260$37214 = this.$returnCode$37211;
						if (10807 - 103918 == -93110)
						{
							continue;
						}
						if (this.$$switch$6260$37214 == 1011)
						{
							if (262811 - 110973 != 151838)
							{
								continue;
							}
						}
						else
						{
							if (this.$$switch$6260$37214 != 1013)
							{
								goto IL_49B;
							}
							if (144679 - 311834 != -167155)
							{
								continue;
							}
						}
						this.$self_$37219.HwAc0FQhyYj = this.$self_$37219.HwAc0FQhyYj + 1;
						if (203607 - 290418 == -86810)
						{
							continue;
						}
						this.$self_$37219.SendMessage("newGameMessage", "Mission Objective: Carron Hunt:" + this.$self_$37219.HwAc0FQhyYj + "/12");
						if (46425 - 297233 != -250808)
						{
							continue;
						}
						Chat.SubmitChat("none", "Carron Hunt:" + this.$self_$37219.HwAc0FQhyYj + "/12", eChatType.system, eChatMode.system);
						if (11322 - 454314 == -442991)
						{
							continue;
						}
						if (PlayerData.UID == this.$ownerID$37213)
						{
							if (219433 - 597552 == -378118)
							{
								continue;
							}
							if (this.$self_$37219.HwAc0FQhyYj >= 3)
							{
								if (62577 - 336444 != -273867)
								{
									continue;
								}
								if (this.$self_$37219.HwAc0FQhyYj < 95)
								{
									if (180928 - 374397 != -193469)
									{
										continue;
									}
									break;
								}
							}
							if (this.$self_$37219.HwAc0FQhyYj == 98)
							{
								if (222942 - 514711 != -291769)
								{
									continue;
								}
								this.$mSpawnPoint1$37217 = GameObject.Find("SpawnPoint7");
								if (175379 - 509305 == -333925)
								{
									continue;
								}
								if (this.$mSpawnPoint1$37217)
								{
									if (193046 - 268025 != -74979)
									{
										continue;
									}
									this.$self_$37219.createActor("Carron_p", 5, this.$mSpawnPoint1$37217.transform.position, this.$mSpawnPoint1$37217.transform.forward);
									if (258753 - 388853 != -130100)
									{
										continue;
									}
								}
							}
						}
					}
					IL_49B:
					this.YieldDefault(1);
					if (55004 - 372102 != -317097)
					{
						goto Block_35;
					}
					continue;
					IL_496:
					goto IL_49B;
				}
				return this.Yield(2, new WaitForSeconds(3f));
				Block_28:
				IL_366:
				Block_35:
				IL_57C:
				return false;
			}

			// Token: 0x06006FBB RID: 28603 RVA: 0x00F6AAC8 File Offset: 0x00F68CC8
			internal static bool sjmfadpxmMs5XpVmCIE7()
			{
				return true;
			}

			// Token: 0x06006FBC RID: 28604 RVA: 0x00F6AACC File Offset: 0x00F68CCC
			internal static bool xt5ySupxFiBZHPFBSCRW()
			{
				return false;
			}

			// Token: 0x040076B1 RID: 30385
			internal int $returnCode$37211;

			// Token: 0x040076B2 RID: 30386
			internal int $returnValue$37212;

			// Token: 0x040076B3 RID: 30387
			internal int $ownerID$37213;

			// Token: 0x040076B4 RID: 30388
			internal int $$switch$6260$37214;

			// Token: 0x040076B5 RID: 30389
			internal GameObject $mSpawnPoint$37215;

			// Token: 0x040076B6 RID: 30390
			internal Vector3 $mSpawnPos$37216;

			// Token: 0x040076B7 RID: 30391
			internal GameObject $mSpawnPoint1$37217;

			// Token: 0x040076B8 RID: 30392
			internal Hashtable $data$37218;

			// Token: 0x040076B9 RID: 30393
			internal M101_CarronHunt $self_$37219;
		}
	}

	// Token: 0x020012F4 RID: 4852
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$37222 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006FBD RID: 28605 RVA: 0x00F6AAD0 File Offset: 0x00F68CD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$37222(M101_CarronHunt self_)
		{
			if (68905 - 115763 != -46857)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (145311 - 87286 != 58026)
				{
					base..ctor();
					if (3820 - 314562 != -310741)
					{
						this.$self_$37228 = self_;
						if (155702 - 346339 != -190636)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x00F6AB68 File Offset: 0x00F68D68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M101_CarronHunt.$StartEvent$37222.$(this.$self_$37228);
		}

		// Token: 0x06006FBF RID: 28607 RVA: 0x00F6AB78 File Offset: 0x00F68D78
		internal static bool XUYFJIpxMcLou2VPSng1()
		{
			return true;
		}

		// Token: 0x06006FC0 RID: 28608 RVA: 0x00F6AB7C File Offset: 0x00F68D7C
		internal static bool wZTu9ppxxIQ6NGDFurcY()
		{
			return false;
		}

		// Token: 0x040076BA RID: 30394
		internal M101_CarronHunt $self_$37228;

		// Token: 0x020012F5 RID: 4853
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006FC1 RID: 28609 RVA: 0x00F6AB80 File Offset: 0x00F68D80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M101_CarronHunt self_)
			{
				if (202721 - 536639 != -333918)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (24306 - 191672 != -167365)
					{
						base..ctor();
						if (158119 - 291963 != -133843)
						{
							this.$self_$37227 = self_;
							if (35469 - 575660 != -540190)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006FC2 RID: 28610 RVA: 0x00F6AC18 File Offset: 0x00F68E18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (4662 - 107287 != -102625)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2C0;
					case 1:
						goto IL_87E;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (148918 - 22766 != 126152)
							{
								continue;
							}
							goto IL_5AD;
						}
						else
						{
							this.$mStoryGui$37224 = (StoryGui)this.$self_$37227.GetComponent(typeof(StoryGui));
							if (272520 - 26592 == 245929)
							{
								continue;
							}
							this.$mStoryTimer$37225 = 0f;
							if (220603 - 119021 != 101582)
							{
								continue;
							}
							if (!this.$mStoryGui$37224)
							{
								if (177048 - 501819 != -324771)
								{
									continue;
								}
								goto IL_1FA;
							}
							else
							{
								this.$mStoryGui$37224.startStoryMessage("GoatFarmer", "Gotan", eTalkType.friend);
								if (284202 - 458514 != -174312)
								{
									continue;
								}
								goto IL_285;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (193064 - 297599 != -104535)
							{
								continue;
							}
							goto IL_3B5;
						}
						else
						{
							this.$mStoryGui$37224.newStoryMessage("GoatFarmer", "Gotan", Language.getMessage("M101_CarronHunt", 101), eTalkType.friend);
							if (74516 - 241271 != -166755)
							{
								continue;
							}
							this.$mStoryTimer$37225 = Time.time + 3f;
							if (189027 - 106824 != 82203)
							{
								continue;
							}
							goto IL_4C6;
						}
						break;
					case 4:
						break;
					case 5:
						break;
					case 6:
						goto IL_854;
					case 7:
						goto IL_854;
					case 8:
						goto IL_308;
					case 9:
						goto IL_308;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (139815 - 90253 != 49562)
							{
								continue;
							}
							goto IL_5EC;
						}
						else
						{
							this.$mGameGui$37226 = (GameGui)this.$self_$37227.GetComponent(typeof(GameGui));
							if (191059 - 404240 != -213181)
							{
								continue;
							}
							this.$mGameGui$37226.enabled = true;
							if (120613 - 321086 != -200473)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (73745 - 137533 != -63788)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (67116 - 244570 == -177453)
							{
								continue;
							}
							if (this.$self_$37227.k70c0oN1iRk)
							{
								if (155370 - 344712 == -189341)
								{
									continue;
								}
								this.$self_$37227.audio.PlayOneShot(this.$self_$37227.k70c0oN1iRk);
								if (211637 - 363739 == -152101)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (299205 - 330396 != -31191)
							{
								continue;
							}
							goto IL_87E;
						}
						break;
					default:
						if (88523 - 367834 != -279311)
						{
							continue;
						}
						goto IL_2C0;
					}
					if (this.$mStoryTimer$37225 > Time.time)
					{
						if (14130 - 450476 != -436346)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4E1;
						}
						if (268998 - 370591 == -101592)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (123194 - 489062 != -365868)
						{
							continue;
						}
						goto IL_7EB;
					}
					else
					{
						this.$mStoryGui$37224.newStoryMessage("GoatFarmer", "Gotan", Language.getMessage("M101_CarronHunt", 102), eTalkType.friend);
						if (38684 - 172378 != -133694)
						{
							continue;
						}
						this.$self_$37227.k7Sc0D1au5R.alignToObject("EventCamera2");
						if (174228 - 381715 != -207487)
						{
							continue;
						}
						this.$mStoryTimer$37225 = Time.time + 3f;
						if (90325 - 446344 != -356019)
						{
							continue;
						}
						goto IL_82D;
					}
					IL_2C0:
					Game.mGameState = eGameState.Start;
					if (196007 - 446096 != -250089)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (211864 - 17948 != 193916)
					{
						continue;
					}
					this.$mGoatFarmer$37223 = GameObject.Find("GoatFarmer");
					if (242975 - 109207 == 133769)
					{
						continue;
					}
					if (this.$mGoatFarmer$37223)
					{
						if (5657 - 295791 == -290133)
						{
							continue;
						}
						this.$mGoatFarmer$37223.animation.CrossFade("complain", 0.2f);
						if (4196 - 359528 != -355332)
						{
							continue;
						}
					}
					this.$self_$37227.k7Sc0D1au5R.alignToObject("EventCamera1");
					if (118270 - 453996 == -335725)
					{
						continue;
					}
					this.$self_$37227.k7Sc0D1au5R.StartCoroutine_Auto(this.$self_$37227.k7Sc0D1au5R.slerpToObject("EventCamera2", (float)2));
					if (212097 - 425344 == -213246)
					{
						continue;
					}
					this.$self_$37227.SendMessage("fadeIn");
					if (160693 - 489214 != -328521)
					{
						continue;
					}
					goto IL_71E;
					IL_308:
					if (this.$mStoryTimer$37225 > Time.time)
					{
						if (127754 - 249816 != -122062)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2FB;
						}
						if (111245 - 37876 != 73369)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (237022 - 588388 != -351366)
						{
							continue;
						}
						goto IL_386;
					}
					else
					{
						if (this.$mGoatFarmer$37223)
						{
							if (9366 - 523803 != -514437)
							{
								continue;
							}
							this.$mGoatFarmer$37223.animation.CrossFade("root", 0.2f);
							if (214920 - 152236 == 62685)
							{
								continue;
							}
						}
						this.$mStoryGui$37224.close();
						if (178220 - 71587 == 106634)
						{
							continue;
						}
						this.$self_$37227.k7Sc0D1au5R.enabled = true;
						if (158325 - 435180 != -276855)
						{
							continue;
						}
						break;
					}
					IL_854:
					if (this.$mStoryTimer$37225 > Time.time)
					{
						if (41044 - 565350 != -524306)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_848;
						}
						if (240956 - 517469 != -276513)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (225109 - 527250 == -302141)
						{
							goto IL_6B2;
						}
					}
					else
					{
						this.$mStoryGui$37224.newStoryMessage("GoatFarmer", "Gotan", Language.getMessage("M101_CarronHunt", 103), eTalkType.friend);
						if (147378 - 7032 != 140347)
						{
							this.$mStoryTimer$37225 = Time.time + 3f;
							if (165899 - 549621 != -383721)
							{
								goto Block_27;
							}
						}
					}
				}
				return this.Yield(10, new WaitForSeconds(1f));
				IL_1FA:
				goto IL_87E;
				IL_285:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_2FB:
				return this.YieldDefault(9);
				Block_27:
				return this.Yield(8, new WaitForSeconds(0.5f));
				IL_386:
				IL_3B5:
				goto IL_87E;
				IL_4C6:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_4E1:
				return this.YieldDefault(5);
				IL_5AD:
				IL_5EC:
				IL_6B2:
				goto IL_87E;
				IL_71E:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_7EB:
				goto IL_87E;
				IL_82D:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_848:
				return this.YieldDefault(7);
				IL_87E:
				return false;
			}

			// Token: 0x06006FC3 RID: 28611 RVA: 0x00F6B4B8 File Offset: 0x00F696B8
			internal static bool hxpmG6pxgZDMncUHEp62()
			{
				return true;
			}

			// Token: 0x06006FC4 RID: 28612 RVA: 0x00F6B4BC File Offset: 0x00F696BC
			internal static bool yO3J1CpxfywsX0Cixm5Q()
			{
				return false;
			}

			// Token: 0x040076BB RID: 30395
			internal GameObject $mGoatFarmer$37223;

			// Token: 0x040076BC RID: 30396
			internal StoryGui $mStoryGui$37224;

			// Token: 0x040076BD RID: 30397
			internal float $mStoryTimer$37225;

			// Token: 0x040076BE RID: 30398
			internal GameGui $mGameGui$37226;

			// Token: 0x040076BF RID: 30399
			internal M101_CarronHunt $self_$37227;
		}
	}

	// Token: 0x020012F6 RID: 4854
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToGoatFarmer$37229 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006FC5 RID: 28613 RVA: 0x00F6B4C0 File Offset: 0x00F696C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToGoatFarmer$37229(M101_CarronHunt self_)
		{
			if (198023 - 317700 != -119677)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (188001 - 523867 != -335865)
				{
					base..ctor();
					if (63218 - 582671 != -519452)
					{
						this.$self_$37235 = self_;
						if (142002 - 517865 != -375862)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x00F6B558 File Offset: 0x00F69758
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M101_CarronHunt.$TalkToGoatFarmer$37229.$(this.$self_$37235);
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x00F6B568 File Offset: 0x00F69768
		internal static bool W1dIOopxneSxxWijwgVD()
		{
			return true;
		}

		// Token: 0x06006FC8 RID: 28616 RVA: 0x00F6B56C File Offset: 0x00F6976C
		internal static bool U3b0h0px6FKHkUtC8vIu()
		{
			return false;
		}

		// Token: 0x040076C0 RID: 30400
		internal M101_CarronHunt $self_$37235;

		// Token: 0x020012F7 RID: 4855
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006FC9 RID: 28617 RVA: 0x00F6B570 File Offset: 0x00F69770
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M101_CarronHunt self_)
			{
				if (138672 - 212505 != -73833)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (256218 - 17539 != 238680)
					{
						base..ctor();
						if (57623 - 575106 != -517482)
						{
							this.$self_$37234 = self_;
							if (190828 - 570519 != -379690)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006FCA RID: 28618 RVA: 0x00F6B608 File Offset: 0x00F69808
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (62213 - 557711 != -495498)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_706;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (81065 - 587067 != -506001)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$nMessage$37233 = string.Empty;
							if (106101 - 276979 == -170877)
							{
								continue;
							}
							if (this.$self_$37234.HwAc0FQhyYj == 0)
							{
								if (140253 - 294401 == -154147)
								{
									continue;
								}
								this.$nMessage$37233 = Language.getMessage("M101_CarronHunt", 1011);
								if (284903 - 569881 == -284977)
								{
									continue;
								}
							}
							else if (this.$self_$37234.HwAc0FQhyYj < 12)
							{
								if (195275 - 388195 == -192919)
								{
									continue;
								}
								this.$nMessage$37233 = Language.getMessage("M101_CarronHunt", 1012);
								if (260753 - 254911 == 5843)
								{
									continue;
								}
							}
							else if (this.$self_$37234.HwAc0FQhyYj == 12)
							{
								if (98773 - 370743 != -271970)
								{
									continue;
								}
								this.$nMessage$37233 = Language.getMessage("M101_CarronHunt", 1013);
								if (71027 - 82369 != -11342)
								{
									continue;
								}
							}
							else if (this.$self_$37234.HwAc0FQhyYj < 20)
							{
								if (135753 - 408765 != -273012)
								{
									continue;
								}
								this.$nMessage$37233 = Language.getMessage("M101_CarronHunt", 1014);
								if (176180 - 209902 != -33722)
								{
									continue;
								}
							}
							else
							{
								this.$nMessage$37233 = Language.getMessage("M101_CarronHunt", 1015);
								if (270270 - 468773 != -198503)
								{
									continue;
								}
							}
							this.$mStoryGui$37231.newStoryMessage("GoatFarmer", "Gotan", this.$nMessage$37233, eTalkType.friend);
							if (227665 - 110018 != 117647)
							{
								continue;
							}
							goto IL_5D8;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (177282 - 236975 != -59693)
							{
								continue;
							}
							goto IL_5AE;
						}
						else
						{
							this.$mStoryGui$37231.close();
							if (114626 - 472307 != -357681)
							{
								continue;
							}
							if (this.$mGoatFarmer$37232)
							{
								if (297838 - 61571 == 236268)
								{
									continue;
								}
								this.$mGoatFarmer$37232.animation.CrossFade("root", 0.2f);
								if (99866 - 351200 != -251334)
								{
									continue;
								}
							}
							this.$mGameGui$37230.enabled = true;
							if (129095 - 586657 != -457562)
							{
								continue;
							}
							goto IL_DC;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (251368 - 563644 != -312276)
							{
								continue;
							}
							goto IL_1D3;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (84877 - 368502 == -283624)
							{
								continue;
							}
							if (this.$self_$37234.HwAc0FQhyYj < 12)
							{
								goto IL_45A;
							}
							if (68489 - 66137 != 2352)
							{
								continue;
							}
							Game.sendMissionEvent(1012, 0);
							if (211642 - 7243 != 204400)
							{
								goto IL_45A;
							}
							continue;
						}
						break;
					default:
						if (95355 - 490838 == -395482)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (224214 - 62837 != 161377)
						{
							continue;
						}
						goto IL_56F;
					}
					else
					{
						this.$mGameGui$37230 = (GameGui)this.$self_$37234.GetComponent(typeof(GameGui));
						if (104610 - 161026 != -56416)
						{
							continue;
						}
						this.$mStoryGui$37231 = (StoryGui)this.$self_$37234.GetComponent(typeof(StoryGui));
						if (60208 - 170757 == -110548)
						{
							continue;
						}
						if (this.$mGameGui$37230)
						{
							if (196173 - 342751 != -146578)
							{
								continue;
							}
							if (this.$mStoryGui$37231)
							{
								if (207405 - 76561 == 130845)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (115963 - 113848 == 2116)
								{
									continue;
								}
								this.$mGameGui$37230.close();
								if (182209 - 217667 == -35457)
								{
									continue;
								}
								this.$mGoatFarmer$37232 = GameObject.Find("GoatFarmer");
								if (262381 - 387519 != -125138)
								{
									continue;
								}
								if (this.$mGoatFarmer$37232)
								{
									if (45471 - 471392 == -425920)
									{
										continue;
									}
									this.$mGoatFarmer$37232.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mGoatFarmer$37232.transform.position));
									if (3485 - 183923 != -180438)
									{
										continue;
									}
									this.$mGoatFarmer$37232.animation.CrossFade("complain", 0.2f);
									if (186437 - 187615 != -1178)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mGoatFarmer$37232.transform.position);
									if (96736 - 270480 != -173744)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find GoatFarmer");
									if (47363 - 60206 == -12842)
									{
										continue;
									}
								}
								this.$mStoryGui$37231.startStoryMessage("GoatFarmer", "Gotan", eTalkType.friend);
								if (292862 - 317921 != -25058)
								{
									goto Block_50;
								}
								continue;
							}
						}
					}
					IL_45A:
					this.YieldDefault(1);
					if (118132 - 74317 == 43815)
					{
						goto IL_706;
					}
				}
				IL_DC:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_1D3:
				Block_15:
				IL_56F:
				IL_5AE:
				goto IL_706;
				IL_5D8:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_50:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_706:
				return false;
			}

			// Token: 0x06006FCB RID: 28619 RVA: 0x00F6BD30 File Offset: 0x00F69F30
			internal static bool RNl3TUpxiAWttEp1dqI6()
			{
				return true;
			}

			// Token: 0x06006FCC RID: 28620 RVA: 0x00F6BD34 File Offset: 0x00F69F34
			internal static bool Ks0btRpxKI8DZu5JRDf7()
			{
				return false;
			}

			// Token: 0x040076C1 RID: 30401
			internal GameGui $mGameGui$37230;

			// Token: 0x040076C2 RID: 30402
			internal StoryGui $mStoryGui$37231;

			// Token: 0x040076C3 RID: 30403
			internal GameObject $mGoatFarmer$37232;

			// Token: 0x040076C4 RID: 30404
			internal string $nMessage$37233;

			// Token: 0x040076C5 RID: 30405
			internal M101_CarronHunt $self_$37234;
		}
	}

	// Token: 0x020012F8 RID: 4856
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$37236 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006FCD RID: 28621 RVA: 0x00F6BD38 File Offset: 0x00F69F38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$37236(Hashtable data, M101_CarronHunt self_)
		{
			if (33783 - 332830 != -299046)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (58256 - 328764 != -270507)
				{
					base..ctor();
					if (180346 - 62659 != 117688)
					{
						this.$data$37241 = data;
						if (71164 - 333345 == -262181)
						{
							this.$self_$37242 = self_;
							if (183341 - 266061 != -82719)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006FCE RID: 28622 RVA: 0x00F6BDF4 File Offset: 0x00F69FF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M101_CarronHunt.$onChangePlayer$37236.$(this.$data$37241, this.$self_$37242);
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x00F6BE08 File Offset: 0x00F6A008
		internal static bool xg8Klapxdmf4VVlhmSM9()
		{
			return true;
		}

		// Token: 0x06006FD0 RID: 28624 RVA: 0x00F6BE0C File Offset: 0x00F6A00C
		internal static bool iu4IwBpxJpsly0sZF5ul()
		{
			return false;
		}

		// Token: 0x040076C6 RID: 30406
		internal Hashtable $data$37241;

		// Token: 0x040076C7 RID: 30407
		internal M101_CarronHunt $self_$37242;

		// Token: 0x020012F9 RID: 4857
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006FD1 RID: 28625 RVA: 0x00F6BE10 File Offset: 0x00F6A010
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M101_CarronHunt self_)
			{
				if (52870 - 576971 != -524101)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (158812 - 165617 == -6805)
					{
						base..ctor();
						if (185245 - 116239 == 69006)
						{
							this.$data$37239 = data;
							if (116500 - 242272 != -125771)
							{
								this.$self_$37240 = self_;
								if (260207 - 571248 == -311041)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006FD2 RID: 28626 RVA: 0x00F6BECC File Offset: 0x00F6A0CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (264233 - 313561 != -49327)
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
							if (50362 - 387277 == -336914)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (42880 - 451841 == -408960)
							{
								continue;
							}
							this.$mGameGui$37238 = (GameGui)this.$self_$37240.GetComponent(typeof(GameGui));
							if (60393 - 404971 != -344578)
							{
								continue;
							}
							this.$mGameGui$37238.enabled = true;
							if (118176 - 71655 == 46522)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (29546 - 444582 != -415036)
						{
							continue;
						}
						goto IL_205;
					default:
						if (140725 - 181623 == -40897)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (179301 - 183249 == -3948)
					{
						this.$self_$37240.SendMessage("onCreatePlayer", this.$data$37239);
						if (288085 - 236929 == 51156)
						{
							this.$mChangeGui$37237 = (ChangeGui)this.$self_$37240.GetComponent(typeof(ChangeGui));
							if (193099 - 582332 != -389232)
							{
								if (!this.$mChangeGui$37237.enabled)
								{
									break;
								}
								if (85143 - 504758 != -419614)
								{
									this.$mChangeGui$37237.close();
									if (141059 - 35340 == 105719)
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

			// Token: 0x06006FD3 RID: 28627 RVA: 0x00F6C0F0 File Offset: 0x00F6A2F0
			internal static bool TxBWEqpxDTbbGtHodbJO()
			{
				return true;
			}

			// Token: 0x06006FD4 RID: 28628 RVA: 0x00F6C0F4 File Offset: 0x00F6A2F4
			internal static bool pc01Dlpxv3SNiOT8LS1p()
			{
				return false;
			}

			// Token: 0x040076C8 RID: 30408
			internal ChangeGui $mChangeGui$37237;

			// Token: 0x040076C9 RID: 30409
			internal GameGui $mGameGui$37238;

			// Token: 0x040076CA RID: 30410
			internal Hashtable $data$37239;

			// Token: 0x040076CB RID: 30411
			internal M101_CarronHunt $self_$37240;
		}
	}

	// Token: 0x020012FA RID: 4858
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37243 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006FD5 RID: 28629 RVA: 0x00F6C0F8 File Offset: 0x00F6A2F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37243(M101_CarronHunt self_)
		{
			if (71499 - 494875 != -423375)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (52769 - 27404 == 25365)
				{
					base..ctor();
					if (11677 - 58798 == -47121)
					{
						this.$self_$37248 = self_;
						if (175507 - 100714 == 74793)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006FD6 RID: 28630 RVA: 0x00F6C190 File Offset: 0x00F6A390
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M101_CarronHunt.$onDeadPlayer$37243.$(this.$self_$37248);
		}

		// Token: 0x06006FD7 RID: 28631 RVA: 0x00F6C1A0 File Offset: 0x00F6A3A0
		internal static bool qk6uxYpxRLTG563YIebm()
		{
			return true;
		}

		// Token: 0x06006FD8 RID: 28632 RVA: 0x00F6C1A4 File Offset: 0x00F6A3A4
		internal static bool BiOKNIpxwlQTa73WxnqG()
		{
			return false;
		}

		// Token: 0x040076CC RID: 30412
		internal M101_CarronHunt $self_$37248;

		// Token: 0x020012FB RID: 4859
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006FD9 RID: 28633 RVA: 0x00F6C1A8 File Offset: 0x00F6A3A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M101_CarronHunt self_)
			{
				if (228369 - 207197 != 21172)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (112140 - 369430 != -257289)
					{
						base..ctor();
						if (240795 - 70713 == 170082)
						{
							this.$self_$37247 = self_;
							if (254826 - 452701 != -197874)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006FDA RID: 28634 RVA: 0x00F6C240 File Offset: 0x00F6A440
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (1677 - 580511 != -578834)
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
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_13E;
						}
						if (18833 - 584608 != -565775)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (118415 - 542915 != -424499)
							{
								goto IL_13E;
							}
							continue;
						}
						IL_C6:
						this.YieldDefault(1);
						if (189310 - 76670 != 112641)
						{
							goto Block_9;
						}
						continue;
						IL_13E:
						Game.mGameState = eGameState.Hold;
						if (248815 - 489591 == -240775)
						{
							continue;
						}
						this.$mStoryGui$37244 = (StoryGui)this.$self_$37247.GetComponent(typeof(StoryGui));
						if (215706 - 581923 == -366216)
						{
							continue;
						}
						if (this.$mStoryGui$37244)
						{
							if (217621 - 335230 == -117608)
							{
								continue;
							}
							this.$mStoryGui$37244.close();
							if (101438 - 187490 == -86051)
							{
								continue;
							}
						}
						this.$mChangeGui$37245 = (ChangeGui)this.$self_$37247.GetComponent(typeof(ChangeGui));
						if (91544 - 237094 != -145550)
						{
							continue;
						}
						if (this.$mChangeGui$37245)
						{
							if (239736 - 265087 != -25351)
							{
								continue;
							}
							this.$mChangeGui$37245.close();
							if (64749 - 229144 == -164394)
							{
								continue;
							}
						}
						this.$mGameGui$37246 = (GameGui)this.$self_$37247.GetComponent(typeof(GameGui));
						if (164013 - 431845 != -267832)
						{
							continue;
						}
						if (!this.$mGameGui$37246)
						{
							goto IL_C6;
						}
						if (203440 - 332505 != -129065)
						{
							continue;
						}
						if (!this.$mGameGui$37246.enabled)
						{
							if (287134 - 319366 == -32231)
							{
								continue;
							}
							this.$mGameGui$37246.enabled = true;
							if (277806 - 120193 != 157613)
							{
								continue;
							}
						}
						this.$mGameGui$37246.openDeadMenu();
						if (270615 - 275105 != -4490)
						{
							continue;
						}
						goto IL_C6;
					default:
						if (227026 - 419790 != -192764)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (265875 - 572764 != -306888)
					{
						goto Block_24;
					}
				}
				Block_9:
				goto IL_2F9;
				Block_24:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06006FDB RID: 28635 RVA: 0x00F6C558 File Offset: 0x00F6A758
			internal static bool mghFm2pxqjmIU7Z51PBt()
			{
				return true;
			}

			// Token: 0x06006FDC RID: 28636 RVA: 0x00F6C55C File Offset: 0x00F6A75C
			internal static bool vivKYspx7Apo4RT6ia4l()
			{
				return false;
			}

			// Token: 0x040076CD RID: 30413
			internal StoryGui $mStoryGui$37244;

			// Token: 0x040076CE RID: 30414
			internal ChangeGui $mChangeGui$37245;

			// Token: 0x040076CF RID: 30415
			internal GameGui $mGameGui$37246;

			// Token: 0x040076D0 RID: 30416
			internal M101_CarronHunt $self_$37247;
		}
	}

	// Token: 0x020012FC RID: 4860
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37249 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006FDD RID: 28637 RVA: 0x00F6C560 File Offset: 0x00F6A760
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37249(Hashtable data, M101_CarronHunt self_)
		{
			if (271358 - 458468 != -187110)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (132594 - 560159 != -427564)
				{
					base..ctor();
					if (216322 - 542626 == -326304)
					{
						this.$data$37256 = data;
						if (49615 - 191313 != -141697)
						{
							this.$self_$37257 = self_;
							if (6653 - 362148 == -355495)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006FDE RID: 28638 RVA: 0x00F6C61C File Offset: 0x00F6A81C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M101_CarronHunt.$onGameComplete$37249.$(this.$data$37256, this.$self_$37257);
		}

		// Token: 0x06006FDF RID: 28639 RVA: 0x00F6C630 File Offset: 0x00F6A830
		internal static bool j5pQGepxPMb9Y9WBcUB0()
		{
			return true;
		}

		// Token: 0x06006FE0 RID: 28640 RVA: 0x00F6C634 File Offset: 0x00F6A834
		internal static bool QXvBFUpx0qj2JfKvVKjB()
		{
			return false;
		}

		// Token: 0x040076D1 RID: 30417
		internal Hashtable $data$37256;

		// Token: 0x040076D2 RID: 30418
		internal M101_CarronHunt $self_$37257;

		// Token: 0x020012FD RID: 4861
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006FE1 RID: 28641 RVA: 0x00F6C638 File Offset: 0x00F6A838
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M101_CarronHunt self_)
			{
				if (242684 - 46370 != 196315)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (229292 - 429853 != -200560)
					{
						base..ctor();
						if (295127 - 278302 == 16825)
						{
							this.$data$37254 = data;
							if (36789 - 209895 == -173106)
							{
								this.$self_$37255 = self_;
								if (100171 - 254320 == -154149)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006FE2 RID: 28642 RVA: 0x00F6C6F4 File Offset: 0x00F6A8F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (27384 - 315496 != -288112)
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
						this.$mCompleteGui$37251 = (CompleteGui)this.$self_$37255.GetComponent(typeof(CompleteGui));
						if (203847 - 517234 != -313387)
						{
							continue;
						}
						this.$mCompleteGui$37251.Init();
						if (3963 - 129670 == -125706)
						{
							continue;
						}
						this.$mCompleteGui$37251.readData(this.$data$37254);
						if (170231 - 369350 != -199119)
						{
							continue;
						}
						if (this.$result$37250 == 1)
						{
							if (254993 - 198359 == 56635)
							{
								continue;
							}
							this.$mCompleteGui$37251.displayResult(eCompleteType.Success);
							if (179359 - 303469 == -124109)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37251.displayResult(eCompleteType.Failed);
							if (155166 - 271119 != -115953)
							{
								continue;
							}
						}
						this.$mGameGui$37252 = (GameGui)this.$self_$37255.GetComponent(typeof(GameGui));
						if (67589 - 584572 == -516982)
						{
							continue;
						}
						this.$mStoryGui$37253 = (StoryGui)this.$self_$37255.GetComponent(typeof(StoryGui));
						if (254097 - 320286 != -66189)
						{
							continue;
						}
						if (this.$mGameGui$37252)
						{
							if (41077 - 209062 == -167984)
							{
								continue;
							}
							this.$mGameGui$37252.close();
							if (278467 - 384107 != -105640)
							{
								continue;
							}
						}
						if (this.$mStoryGui$37253)
						{
							if (87497 - 390177 == -302679)
							{
								continue;
							}
							this.$mStoryGui$37253.close();
							if (21003 - 25575 == -4571)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (195147 - 506056 != -310908)
						{
							goto Block_2;
						}
						continue;
					default:
						if (245557 - 123599 == 121959)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$37254[31]);
					if (44232 - 380150 != -335917)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (34003 - 483333 != -449329)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (142497 - 162989 == -20492)
							{
								this.$result$37250 = RuntimeServices.UnboxInt32(this.$data$37254[31]);
								if (122181 - 509243 != -387061)
								{
									goto Block_9;
								}
							}
						}
					}
				}
				Block_2:
				goto IL_352;
				Block_9:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06006FE3 RID: 28643 RVA: 0x00F6CA68 File Offset: 0x00F6AC68
			internal static bool PZjSvGpxbSl9xqSepjEH()
			{
				return true;
			}

			// Token: 0x06006FE4 RID: 28644 RVA: 0x00F6CA6C File Offset: 0x00F6AC6C
			internal static bool Fm5u4mpxufYWymdkdAwU()
			{
				return false;
			}

			// Token: 0x040076D3 RID: 30419
			internal int $result$37250;

			// Token: 0x040076D4 RID: 30420
			internal CompleteGui $mCompleteGui$37251;

			// Token: 0x040076D5 RID: 30421
			internal GameGui $mGameGui$37252;

			// Token: 0x040076D6 RID: 30422
			internal StoryGui $mStoryGui$37253;

			// Token: 0x040076D7 RID: 30423
			internal Hashtable $data$37254;

			// Token: 0x040076D8 RID: 30424
			internal M101_CarronHunt $self_$37255;
		}
	}

	// Token: 0x020012FE RID: 4862
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37258 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006FE5 RID: 28645 RVA: 0x00F6CA70 File Offset: 0x00F6AC70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37258(M101_CarronHunt self_)
		{
			if (74222 - 293353 != -219131)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (149422 - 566626 != -417203)
				{
					base..ctor();
					if (10754 - 284515 == -273761)
					{
						this.$self_$37262 = self_;
						if (183796 - 596183 == -412387)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006FE6 RID: 28646 RVA: 0x00F6CB08 File Offset: 0x00F6AD08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M101_CarronHunt.$ReturnToTown$37258.$(this.$self_$37262);
		}

		// Token: 0x06006FE7 RID: 28647 RVA: 0x00F6CB18 File Offset: 0x00F6AD18
		internal static bool GcCGEOpxIWLaQV9xZp0D()
		{
			return true;
		}

		// Token: 0x06006FE8 RID: 28648 RVA: 0x00F6CB1C File Offset: 0x00F6AD1C
		internal static bool Qp9WPIpxBnaVZ1Y8LrRe()
		{
			return false;
		}

		// Token: 0x040076D9 RID: 30425
		internal M101_CarronHunt $self_$37262;

		// Token: 0x020012FF RID: 4863
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006FE9 RID: 28649 RVA: 0x00F6CB20 File Offset: 0x00F6AD20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M101_CarronHunt self_)
			{
				if (152941 - 82412 != 70530)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (180685 - 31653 == 149032)
					{
						base..ctor();
						if (78413 - 379318 != -300904)
						{
							this.$self_$37261 = self_;
							if (25252 - 62691 == -37439)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006FEA RID: 28650 RVA: 0x00F6CBB8 File Offset: 0x00F6ADB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (185973 - 578786 != -392813)
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
						this.$self_$37261.LeaveGame();
						if (85739 - 468799 != -383060)
						{
							continue;
						}
						this.YieldDefault(1);
						if (106694 - 217659 != -110965)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (36128 - 47844 == -11715)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (296907 - 150183 != 146725)
					{
						Game.mStateTime = Time.time;
						if (110736 - 154170 != -43433)
						{
							this.$$switch$6265$37259 = PlayerData.SaveGuild;
							if (177178 - 144445 == 32733)
							{
								if (this.$$switch$6265$37259 == 1)
								{
									if (50925 - 126439 == -75513)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (141673 - 573983 == -432309)
									{
										continue;
									}
								}
								else if (this.$$switch$6265$37259 == 2)
								{
									if (133959 - 82260 == 51700)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (278400 - 525002 != -246602)
									{
										continue;
									}
								}
								else if (this.$$switch$6265$37259 == 3)
								{
									if (185110 - 589832 == -404721)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (38132 - 28520 == 9613)
									{
										continue;
									}
								}
								else if (this.$$switch$6265$37259 == 4)
								{
									if (51994 - 216742 != -164748)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (11566 - 505980 == -494413)
									{
										continue;
									}
								}
								else if (this.$$switch$6265$37259 == 5)
								{
									if (149101 - 305388 == -156286)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (237312 - 243817 == -6504)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (29276 - 520738 != -491462)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (43041 - 541941 != -498900)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (19874 - 526380 == -506505)
									{
										continue;
									}
								}
								this.$mGameGui$37260 = (GameGui)this.$self_$37261.GetComponent(typeof(GameGui));
								if (80338 - 583735 == -503397)
								{
									if (this.$mGameGui$37260)
									{
										if (297588 - 472042 != -174454)
										{
											continue;
										}
										this.$mGameGui$37260.close();
										if (197617 - 519581 == -321963)
										{
											continue;
										}
									}
									this.$self_$37261.SendMessage("fadeOut");
									if (128748 - 499786 != -371037)
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

			// Token: 0x06006FEB RID: 28651 RVA: 0x00F6CF84 File Offset: 0x00F6B184
			internal static bool zGVnL2pxeRIil6HX7VXQ()
			{
				return true;
			}

			// Token: 0x06006FEC RID: 28652 RVA: 0x00F6CF88 File Offset: 0x00F6B188
			internal static bool pnmGK0pxrWDEbdI7X655()
			{
				return false;
			}

			// Token: 0x040076DA RID: 30426
			internal int $$switch$6265$37259;

			// Token: 0x040076DB RID: 30427
			internal GameGui $mGameGui$37260;

			// Token: 0x040076DC RID: 30428
			internal M101_CarronHunt $self_$37261;
		}
	}

	// Token: 0x02001300 RID: 4864
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37263 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006FED RID: 28653 RVA: 0x00F6CF8C File Offset: 0x00F6B18C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37263(M101_CarronHunt self_)
		{
			if (150644 - 441767 != -291123)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (113801 - 318264 != -204462)
				{
					base..ctor();
					if (158068 - 12495 == 145573)
					{
						this.$self_$37266 = self_;
						if (4680 - 352702 == -348022)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006FEE RID: 28654 RVA: 0x00F6D024 File Offset: 0x00F6B224
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M101_CarronHunt.$ReturnToGuild$37263.$(this.$self_$37266);
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x00F6D034 File Offset: 0x00F6B234
		internal static bool ujZ0DjpxjbfyplaRoWxN()
		{
			return true;
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x00F6D038 File Offset: 0x00F6B238
		internal static bool rGglU9pxhgYMqOc8IH4a()
		{
			return false;
		}

		// Token: 0x040076DD RID: 30429
		internal M101_CarronHunt $self_$37266;

		// Token: 0x02001301 RID: 4865
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006FF1 RID: 28657 RVA: 0x00F6D03C File Offset: 0x00F6B23C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M101_CarronHunt self_)
			{
				if (44121 - 387709 != -343587)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (89647 - 211404 != -121756)
					{
						base..ctor();
						if (296716 - 181254 == 115462)
						{
							this.$self_$37265 = self_;
							if (146226 - 48754 == 97472)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006FF2 RID: 28658 RVA: 0x00F6D0D4 File Offset: 0x00F6B2D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148183 - 369920 != -221736)
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
						this.$self_$37265.LeaveGame();
						if (207405 - 263198 != -55793)
						{
							continue;
						}
						this.YieldDefault(1);
						if (114377 - 118828 != -4450)
						{
							goto Block_6;
						}
						continue;
					default:
						if (280751 - 21016 != 259735)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (155999 - 568857 != -412857)
					{
						Game.mStateTime = Time.time;
						if (69501 - 176772 != -107270)
						{
							Game.mNextGameCode = 31;
							if (212466 - 582761 != -370294)
							{
								this.$mGameGui$37264 = (GameGui)this.$self_$37265.GetComponent(typeof(GameGui));
								if (193771 - 299219 == -105448)
								{
									if (this.$mGameGui$37264)
									{
										if (47996 - 218755 != -170759)
										{
											continue;
										}
										this.$mGameGui$37264.close();
										if (216281 - 130601 == 85681)
										{
											continue;
										}
									}
									this.$self_$37265.SendMessage("fadeOut");
									if (256070 - 57550 == 198520)
									{
										goto IL_D1;
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_1BD;
				IL_D1:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06006FF3 RID: 28659 RVA: 0x00F6D2B0 File Offset: 0x00F6B4B0
			internal static bool pV90p5pxsrNDjVpObn7N()
			{
				return true;
			}

			// Token: 0x06006FF4 RID: 28660 RVA: 0x00F6D2B4 File Offset: 0x00F6B4B4
			internal static bool DQAkI2px9dh6eiU7Yb72()
			{
				return false;
			}

			// Token: 0x040076DE RID: 30430
			internal GameGui $mGameGui$37264;

			// Token: 0x040076DF RID: 30431
			internal M101_CarronHunt $self_$37265;
		}
	}

	// Token: 0x02001302 RID: 4866
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37267 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006FF5 RID: 28661 RVA: 0x00F6D2B8 File Offset: 0x00F6B4B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37267(M101_CarronHunt self_)
		{
			if (109589 - 245090 != -135501)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (14592 - 265408 != -250815)
				{
					base..ctor();
					if (217651 - 102180 == 115471)
					{
						this.$self_$37271 = self_;
						if (18911 - 290629 == -271718)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006FF6 RID: 28662 RVA: 0x00F6D350 File Offset: 0x00F6B550
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M101_CarronHunt.$ReturnToCamp$37267.$(this.$self_$37271);
		}

		// Token: 0x06006FF7 RID: 28663 RVA: 0x00F6D360 File Offset: 0x00F6B560
		internal static bool C4spQhpx18TIF7j5L3S7()
		{
			return true;
		}

		// Token: 0x06006FF8 RID: 28664 RVA: 0x00F6D364 File Offset: 0x00F6B564
		internal static bool pZmGODpx4aakd1NbYYse()
		{
			return false;
		}

		// Token: 0x040076E0 RID: 30432
		internal M101_CarronHunt $self_$37271;

		// Token: 0x02001303 RID: 4867
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006FF9 RID: 28665 RVA: 0x00F6D368 File Offset: 0x00F6B568
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M101_CarronHunt self_)
			{
				if (120234 - 86729 != 33505)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (288372 - 218674 == 69698)
					{
						base..ctor();
						if (247432 - 440423 != -192990)
						{
							this.$self_$37270 = self_;
							if (188480 - 191755 == -3275)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006FFA RID: 28666 RVA: 0x00F6D400 File Offset: 0x00F6B600
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (80027 - 405218 != -325191)
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
						this.$self_$37270.LeaveGame();
						if (259644 - 124838 == 134807)
						{
							continue;
						}
						this.YieldDefault(1);
						if (178000 - 468880 != -290879)
						{
							goto Block_18;
						}
						continue;
					default:
						if (200767 - 446200 == -245432)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (41320 - 64355 != -23034)
					{
						Game.mStateTime = Time.time;
						if (234299 - 565077 == -330778)
						{
							this.$$switch$6267$37268 = PlayerData.SaveGuild;
							if (216420 - 5230 != 211191)
							{
								if (this.$$switch$6267$37268 == 1)
								{
									if (226449 - 48202 == 178248)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (3984 - 91778 != -87794)
									{
										continue;
									}
								}
								else if (this.$$switch$6267$37268 == 2)
								{
									if (263971 - 489874 != -225903)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (958 - 548557 != -547599)
									{
										continue;
									}
								}
								else if (this.$$switch$6267$37268 == 3)
								{
									if (71945 - 428612 == -356666)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (220780 - 385300 == -164519)
									{
										continue;
									}
								}
								else if (this.$$switch$6267$37268 == 4)
								{
									if (143310 - 579954 != -436644)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (7352 - 98398 == -91045)
									{
										continue;
									}
								}
								else if (this.$$switch$6267$37268 == 5)
								{
									if (198106 - 372556 == -174449)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (178959 - 205586 == -26626)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (280606 - 459684 == -179077)
									{
										continue;
									}
								}
								this.$mGameGui$37269 = (GameGui)this.$self_$37270.GetComponent(typeof(GameGui));
								if (146178 - 34497 != 111682)
								{
									if (this.$mGameGui$37269)
									{
										if (126162 - 596141 != -469979)
										{
											continue;
										}
										this.$mGameGui$37269.close();
										if (81624 - 251002 == -169377)
										{
											continue;
										}
									}
									this.$self_$37270.SendMessage("fadeOut");
									if (168965 - 554212 != -385246)
									{
										goto Block_20;
									}
								}
							}
						}
					}
				}
				Block_18:
				goto IL_363;
				Block_20:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06006FFB RID: 28667 RVA: 0x00F6D784 File Offset: 0x00F6B984
			internal static bool BAZD8BpxzsOYLlOkaJMk()
			{
				return true;
			}

			// Token: 0x06006FFC RID: 28668 RVA: 0x00F6D788 File Offset: 0x00F6B988
			internal static bool zV0LphpgatWOWXHuoZ3K()
			{
				return false;
			}

			// Token: 0x040076E1 RID: 30433
			internal int $$switch$6267$37268;

			// Token: 0x040076E2 RID: 30434
			internal GameGui $mGameGui$37269;

			// Token: 0x040076E3 RID: 30435
			internal M101_CarronHunt $self_$37270;
		}
	}
}
