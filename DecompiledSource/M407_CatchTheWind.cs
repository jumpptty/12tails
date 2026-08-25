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

// Token: 0x0200155E RID: 5470
[Serializable]
public class M407_CatchTheWind : MonoBehaviour
{
	// Token: 0x06007EB0 RID: 32432 RVA: 0x0104E92C File Offset: 0x0104CB2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M407_CatchTheWind()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007EB1 RID: 32433 RVA: 0x0104E93C File Offset: 0x0104CB3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (72660 - 575455 != -502795)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (88234 - 268107 == -179873)
			{
				Game.mGameType = 4;
				if (166953 - 366617 == -199664)
				{
					if (Chat.Initialized)
					{
						if (142368 - 176312 != -33944)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (261092 - 153335 != 107757)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (51804 - 352265 != -300461)
						{
							continue;
						}
					}
					this.daucFzPS7ZM = (Texture)Resources.Load("GameGui/Title/chapterComplete", typeof(Texture));
					if (265335 - 245222 == 20113)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007EB2 RID: 32434 RVA: 0x0104EA5C File Offset: 0x0104CC5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (264520 - 134645 != 129876)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (211967 - 374606 != -162638)
				{
					if (Game.mNextGameCode != 407)
					{
						break;
					}
					if (167794 - 121354 != 46441)
					{
						Game.nextGame();
						if (15654 - 586922 != -571267)
						{
							Game.mGameCode = 407;
							if (115070 - 415990 == -300920)
							{
								Game.mGameType = 4;
								if (109662 - 425950 != -316287)
								{
									Game.mGameTime = Time.time;
									if (259992 - 77662 == 182330)
									{
										Game.mGameScore = 0;
										if (33605 - 75444 != -41838)
										{
											Game.mGameMana = 0;
											if (180215 - 556064 != -375848)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (58591 - 562457 != -503865)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (46891 - 538912 != -492020)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (291698 - 481507 == -189809)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (187829 - 30892 != 156938)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (223554 - 221305 != 2250)
																{
																	this.wcycFh60VKE = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (181178 - 11432 != 169747)
																	{
																		this.wcycFh60VKE.enabled = false;
																		if (100095 - 55175 != 44921)
																		{
																			this.OcwcFVpwIUK = PhotonClient.Connection;
																			if (103764 - 222625 != -118860)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (99030 - 188249 != -89218)
																				{
																					this.InitGame();
																					if (66300 - 227524 == -161224)
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
				if (19197 - 423742 == -404545)
				{
					Game.mGameType = 99;
					if (271362 - 582109 != -310746)
					{
						this.wcycFh60VKE = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
						if (191614 - 138104 != 53511)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007EB3 RID: 32435 RVA: 0x0104EDB8 File Offset: 0x0104CFB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (174885 - 390678 != -215793)
		{
		}
		for (;;)
		{
			if (this.OcwcFVpwIUK == null)
			{
				if (166220 - 582200 == -415980)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (233797 - 563218 == -329421)
				{
					if (mGameState == eGameState.Init)
					{
						if (239147 - 10538 == 228610)
						{
							continue;
						}
						AudioListener.volume = 0.1f * (float)Game.volume;
						if (422 - 207939 != -207517)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (157989 - 238564 != -80575)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (299479 - 569637 != -270158)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (34631 - 343113 != -308482)
						{
							continue;
						}
						this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
						if (289546 - 300322 == -10775)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (64781 - 231656 == -166874)
						{
							continue;
						}
						if (Game.music != 0)
						{
							if (116511 - 247437 != -130926)
							{
								continue;
							}
							if (!this.audio.isPlaying)
							{
								if (59316 - 121117 != -61801)
								{
									continue;
								}
								this.audio.Play();
								if (72983 - 532818 != -459835)
								{
									continue;
								}
							}
						}
						this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
						if (1215 - 10969 != -9754)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (59967 - 298248 == -238280)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (54423 - 291242 == -236818)
						{
							continue;
						}
					}
					else if (mGameState == eGameState.Ended)
					{
						if (73464 - 354615 == -281150)
						{
							continue;
						}
					}
					if (!this.peLcAnPJQAi)
					{
						break;
					}
					if (270869 - 218344 == 52525)
					{
						if (!this.jl2cAQDDU60)
						{
							break;
						}
						if (33132 - 506928 == -473796)
						{
							if (this.yxgcA5dbk6k != 1)
							{
								if (126838 - 221785 != -94947)
								{
									continue;
								}
								if (this.yxgcA5dbk6k != 3)
								{
									break;
								}
								if (130063 - 526885 != -396822)
								{
									continue;
								}
							}
							Vector3 vector = Vector3.zero;
							if (57502 - 433774 == -376272)
							{
								int num = this.yxgcA5dbk6k;
								if (158279 - 136879 != 21401)
								{
									if (num == 1)
									{
										if (170409 - 346647 == -176237)
										{
											continue;
										}
										if (this.dvTcAepy56R)
										{
											if (90711 - 333402 != -242691)
											{
												continue;
											}
											vector = this.dvTcAepy56R.transform.position;
											if (54341 - 80668 == -26326)
											{
												continue;
											}
										}
									}
									else if (num == 3)
									{
										if (115264 - 421919 != -306655)
										{
											continue;
										}
										if (this.v4YcAJ7CQQK)
										{
											if (36978 - 380320 != -343342)
											{
												continue;
											}
											vector = this.v4YcAJ7CQQK.transform.position;
											if (34294 - 267544 == -233249)
											{
												continue;
											}
										}
									}
									if (!(vector != Vector3.zero))
									{
										break;
									}
									if (286629 - 580769 == -294140)
									{
										Vector3 vector2 = global::Math.vFlat(vector - this.peLcAnPJQAi.transform.position);
										if (39414 - 254131 == -214717)
										{
											if (vector2.sqrMagnitude < (float)4)
											{
												if (179807 - 402477 == -222670)
												{
													if (this.yxgcA5dbk6k == 1)
													{
														if (26074 - 575386 == -549312)
														{
															this.yxgcA5dbk6k = 2;
															if (170073 - 316930 == -146857)
															{
																this.peLcAnPJQAi.transform.position = this.VFQcAINdror.transform.position;
																if (64430 - 410824 == -346394)
																{
																	this.peLcAnPJQAi.transform.rotation = this.VFQcAINdror.transform.rotation;
																	if (25191 - 586430 == -561239)
																	{
																		this.peLcAnPJQAi.animation.Play("sleep");
																		if (46636 - 477397 != -430760)
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
														if (this.yxgcA5dbk6k != 3)
														{
															break;
														}
														if (239967 - 424200 == -184233)
														{
															this.yxgcA5dbk6k = 4;
															if (280848 - 32486 == 248362)
															{
																this.peLcAnPJQAi.transform.position = this.w8VcA6VDHEW.transform.position;
																if (57600 - 367752 != -310151)
																{
																	this.peLcAnPJQAi.transform.rotation = this.w8VcA6VDHEW.transform.rotation;
																	if (99885 - 195424 != -95538)
																	{
																		this.peLcAnPJQAi.animation.Play("sleep");
																		if (63691 - 304404 == -240713)
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
											else
											{
												this.peLcAnPJQAi.animation.CrossFade("walk", 0.5f);
												if (55244 - 498860 == -443616)
												{
													this.peLcAnPJQAi.transform.rotation = Quaternion.Slerp(this.peLcAnPJQAi.transform.rotation, Quaternion.LookRotation(vector2.normalized), Time.deltaTime);
													if (90547 - 155860 != -65312)
													{
														this.jl2cAQDDU60.Move(((float)7 * vector2.normalized - Vector3.up) * Time.deltaTime);
														if (209759 - 518385 != -308625)
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

	// Token: 0x06007EB4 RID: 32436 RVA: 0x0104F580 File Offset: 0x0104D780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (115310 - 153946 != -38635)
		{
		}
		for (;;)
		{
			eGameState mGameState = Game.mGameState;
			if (108408 - 41629 != 66780)
			{
				if (mGameState != eGameState.Complete)
				{
					break;
				}
				if (46706 - 243821 != -197114)
				{
					if (!this.daucFzPS7ZM)
					{
						break;
					}
					if (171621 - 254461 != -82839)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (2887 - 23156 != -20268)
						{
							int num = 1024 * Screen.width / Screen.height;
							if (238737 - 294593 == -55856)
							{
								float num2 = (float)Screen.height / 1024f;
								if (270933 - 538649 != -267715)
								{
									GUI.depth = 1;
									if (242978 - 435446 != -192467)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, (float)2 * (Time.time - this.wU1cAcSKoeR));
										if (77428 - 128463 == -51035)
										{
											Color color = GUI.color;
											if (190069 - 276321 == -86252)
											{
												float num3 = color.a = a;
												if (41908 - 19216 != 22693 && 129880 - 201070 != -71189)
												{
													Color color2 = GUI.color = color;
													if (155747 - 179852 == -24105)
													{
														if (81592 - 591639 != -510046)
														{
															float num4 = Mathf.SmoothStep(1.5f, (float)1, Time.time - this.wU1cAcSKoeR);
															if (156195 - 452382 != -296186)
															{
																GUI.DrawTexture(new Rect(0.5f * (float)num - 0.5f * (float)this.daucFzPS7ZM.width * num4, (float)530 - 0.5f * (float)this.daucFzPS7ZM.height * num4, (float)this.daucFzPS7ZM.width * num4, (float)this.daucFzPS7ZM.height * num4), this.daucFzPS7ZM);
																if (217447 - 277509 != -60061)
																{
																	int num5 = 1;
																	if (184102 - 197850 == -13748)
																	{
																		Color color3 = GUI.color;
																		if (254425 - 328116 != -73690)
																		{
																			float num6 = color3.a = (float)num5;
																			if (103879 - 226973 == -123094)
																			{
																				if (156700 - 590618 != -433917)
																				{
																					GUI.color = color3;
																					if (297635 - 462515 != -164879)
																					{
																						if (50530 - 31949 == 18581)
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

	// Token: 0x06007EB5 RID: 32437 RVA: 0x0104F940 File Offset: 0x0104DB40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (90454 - 54807 != 35647)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (268039 - 96435 != 171605)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (289077 - 457799 != -168721)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (211225 - 120111 == 91114)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (45426 - 238738 != -193311)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007EB6 RID: 32438 RVA: 0x0104FA30 File Offset: 0x0104DC30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (145372 - 558818 != -413446)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (250523 - 451613 != -201089)
			{
				Time.timeScale = 1f;
				if (205130 - 160438 != 44693)
				{
					this.peLcAnPJQAi = GameObject.Find("WindGod");
					if (297496 - 36326 != 261171)
					{
						if (this.peLcAnPJQAi)
						{
							if (116017 - 276710 != -160693)
							{
								continue;
							}
							this.peLcAnPJQAi.animation.Play("root");
							if (51879 - 173959 != -122080)
							{
								continue;
							}
							this.jl2cAQDDU60 = (CharacterController)this.peLcAnPJQAi.GetComponent(typeof(CharacterController));
							if (95785 - 200099 != -104314)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find windGod");
							if (290072 - 151326 != 138746)
							{
								continue;
							}
						}
						this.dvTcAepy56R = GameObject.Find("WindPoint1");
						if (159460 - 163577 != -4116)
						{
							this.VFQcAINdror = GameObject.Find("WindPoint2");
							if (146835 - 226657 == -79822)
							{
								this.v4YcAJ7CQQK = GameObject.Find("WindPoint3");
								if (249402 - 479039 != -229636)
								{
									this.w8VcA6VDHEW = GameObject.Find("WindPoint4");
									if (46109 - 236594 != -190484)
									{
										this.zgwcAtKMhqr = GameObject.Find("SpawnPoint1");
										if (114009 - 305188 == -191179)
										{
											this.GUqcAXDXE7G = GameObject.Find("SpawnPoint2");
											if (198217 - 314046 != -115828)
											{
												this.PQBcAOq7loS = GameObject.Find("SpawnPoint3");
												if (186554 - 69357 == 117197)
												{
													this.lb3cA2fArhS = GameObject.Find("SpawnPoint4");
													if (174753 - 301852 != -127098)
													{
														Hashtable customOpParameters = new Hashtable();
														if (289504 - 358002 != -68497)
														{
															this.OcwcFVpwIUK.OpCustom(52, customOpParameters, true);
															if (236933 - 238294 != -1360)
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

	// Token: 0x06007EB7 RID: 32439 RVA: 0x0104FD34 File Offset: 0x0104DF34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (268546 - 443906 != -175360)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (1719 - 382274 != -380554)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (254837 - 236936 != 17902)
				{
					Game.mGameState = eGameState.Setup;
					if (219885 - 495399 != -275513)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007EB8 RID: 32440 RVA: 0x0104FDD8 File Offset: 0x0104DFD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (218902 - 47125 != 171777)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (159599 - 257650 != -98050)
			{
				if (num == PlayerData.UID)
				{
					if (225708 - 451749 == -226041)
					{
						this.SetupActors();
						if (3151 - 47227 == -44076)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (149350 - 599971 != -450620)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007EB9 RID: 32441 RVA: 0x0104FEA8 File Offset: 0x0104E0A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (220320 - 146455 != 73865)
		{
		}
		for (;;)
		{
			IL_41:
			Debug.Log("Creating Actors");
			if (30858 - 399959 == -369101)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (10071 - 439517 != -429445)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (22364 - 513153 != -490788)
						{
							int i = 0;
							if (68807 - 310671 != -241863)
							{
								CharacterControl[] array2 = array;
								if (67145 - 436488 == -369343)
								{
									int length = array2.Length;
									if (66924 - 229027 != -162102)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (174973 - 271795 == -96821)
											{
												goto IL_41;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (237821 - 85860 != 151961)
											{
												goto IL_41;
											}
											this.xVBcAvntiJa++;
											if (267316 - 396880 != -129564)
											{
												goto IL_41;
											}
											i++;
											if (25560 - 38073 != -12513)
											{
												goto IL_41;
											}
										}
										if (266016 - 320414 != -54397)
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
						if (280377 - 37386 != 242992)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007EBA RID: 32442 RVA: 0x010500C0 File Offset: 0x0104E2C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (176469 - 465395 != -288926)
		{
		}
		for (;;)
		{
			IL_54:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (76781 - 236924 == -160143)
			{
				int i = 0;
				if (42794 - 185906 != -143111)
				{
					CharacterControl[] array2 = array;
					if (15189 - 28411 == -13222)
					{
						int length = array2.Length;
						if (197411 - 48131 == 149280)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (138078 - 275106 != -137028)
								{
									goto IL_54;
								}
								i++;
								if (107646 - 418854 == -311207)
								{
									goto IL_54;
								}
							}
							if (177103 - 38924 == 138179)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007EBB RID: 32443 RVA: 0x010501F0 File Offset: 0x0104E3F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (65108 - 548186 != -483078)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (237587 - 310568 == -72981)
			{
				Game.mGameState = eGameState.Ready;
				if (76918 - 234815 != -157896)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (94614 - 21164 == 73450)
					{
						if (219565 - 32401 == 187164)
						{
							if (213586 - 545286 != -331699)
							{
								GameObject gameObject;
								if (playerSlot > 1)
								{
									if (79727 - 543429 == -463701)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (190198 - 380348 == -190149)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (45963 - 546188 != -500225)
										{
											continue;
										}
										GameObject gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (51603 - 482767 != -431163)
										{
											goto IL_116;
										}
										continue;
									}
								}
								gameObject = GameObject.Find("StartPoint1");
								if (188381 - 463943 == -275561)
								{
									continue;
								}
								IL_116:
								if (!gameObject)
								{
									break;
								}
								if (4008 - 391448 == -387440)
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (154770 - 512615 == -357845)
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

	// Token: 0x06007EBC RID: 32444 RVA: 0x010503FC File Offset: 0x0104E5FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M407_CatchTheWind.$StartGame$38974(this).GetEnumerator();
	}

	// Token: 0x06007EBD RID: 32445 RVA: 0x0105040C File Offset: 0x0104E60C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007EBE RID: 32446 RVA: 0x01050410 File Offset: 0x0104E610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWindGod()
	{
		return new M407_CatchTheWind.$TalkToWindGod$38990(this).GetEnumerator();
	}

	// Token: 0x06007EBF RID: 32447 RVA: 0x01050420 File Offset: 0x0104E620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (237339 - 279022 != -41683)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (270406 - 41301 == 229105)
			{
				hashtable.Add(71, CID);
				if (276284 - 572915 != -296630)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (128318 - 374331 != -246012)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (27673 - 314445 == -286772)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (282435 - 28933 == 253502)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (138668 - 340084 == -201416)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (236122 - 64840 != 171283)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (188174 - 315675 != -127500)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (143179 - 154324 == -11145)
											{
												this.OcwcFVpwIUK.OpCustom(61, hashtable, true);
												if (146770 - 279140 != -132369)
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

	// Token: 0x06007EC0 RID: 32448 RVA: 0x010506AC File Offset: 0x0104E8AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (178157 - 521394 != -343237)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (197487 - 19388 == 178099)
			{
				if (!gameObject)
				{
					break;
				}
				if (20843 - 351910 != -331066)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (31798 - 150600 == -118802)
					{
						playerCameraControl.target = gameObject;
						if (135047 - 291918 == -156871)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (286933 - 250966 != 35968)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007EC1 RID: 32449 RVA: 0x010507A4 File Offset: 0x0104E9A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (288685 - 153105 != 135580)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (199523 - 370719 == -171196)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (257 - 431377 != -431119)
				{
					gameGui.ResetTeamBar();
					if (129516 - 410484 != -280967)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007EC2 RID: 32450 RVA: 0x01050850 File Offset: 0x0104EA50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M407_CatchTheWind.$onDeadPlayer$39004(this).GetEnumerator();
	}

	// Token: 0x06007EC3 RID: 32451 RVA: 0x01050860 File Offset: 0x0104EA60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (133491 - 491370 != -357878)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (276409 - 505256 != -228846)
			{
				this.wcycFh60VKE.target = Game.mPlayer;
				if (240343 - 494697 != -254353)
				{
					this.wcycFh60VKE.enabled = true;
					if (33830 - 261799 == -227969)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (14153 - 531570 == -517416)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (175406 - 18343 == 157064)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (259148 - 134165 == 124983)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (13542 - 474771 == -461229)
							{
								if (!gameGui)
								{
									break;
								}
								if (72812 - 164580 != -91767)
								{
									gameGui.enabled = true;
									if (250330 - 586577 != -336246)
									{
										gameGui.closeDeadMenu();
										if (30074 - 90436 != -60361)
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

	// Token: 0x06007EC4 RID: 32452 RVA: 0x01050A0C File Offset: 0x0104EC0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (91986 - 153012 != -61025)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (173090 - 98547 == 74543)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (242063 - 595027 != -352963)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (153277 - 129008 == 24269)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007EC5 RID: 32453 RVA: 0x01050AD0 File Offset: 0x0104ECD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007EC6 RID: 32454 RVA: 0x01050AFC File Offset: 0x0104ECFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (34741 - 71769 != -37027)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (94416 - 241294 == -146878)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (69434 - 542065 == -472631)
				{
					hashtable.Add(43, PlayerData.UID);
					if (99619 - 260115 != -160495)
					{
						hashtable.Add(73, nType);
						if (270328 - 382903 == -112575)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (275104 - 299675 != -24570)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (104500 - 449396 != -344895)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (13872 - 128837 != -114964)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (62402 - 325029 != -262626)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (270552 - 496551 != -225998)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (63306 - 97396 != -34089)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (36705 - 13419 != 23287)
													{
														this.OcwcFVpwIUK.OpCustom(63, hashtable, true);
														if (19304 - 362302 != -342997)
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

	// Token: 0x06007EC7 RID: 32455 RVA: 0x01050DE0 File Offset: 0x0104EFE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (249601 - 482807 != -233206)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (256283 - 591814 != -335530)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (254413 - 329962 == -75549)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (178706 - 324272 != -145565)
						{
							if (this.xVBcAvntiJa <= 0)
							{
								break;
							}
							if (107587 - 136788 != -29200)
							{
								this.xVBcAvntiJa--;
								if (283388 - 518839 != -235450)
								{
									if (this.xVBcAvntiJa != 0)
									{
										break;
									}
									if (187063 - 581100 != -394036)
									{
										Game.setGameState(eGameState.Ready);
										if (94342 - 475398 == -381056)
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
						if (379 - 217347 != -216967)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (85907 - 524506 != -438598)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007EC8 RID: 32456 RVA: 0x01050F70 File Offset: 0x0104F170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06007EC9 RID: 32457 RVA: 0x01050F84 File Offset: 0x0104F184
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06007ECA RID: 32458 RVA: 0x01050F98 File Offset: 0x0104F198
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M407_CatchTheWind.$onGameComplete$39010(data, this).GetEnumerator();
	}

	// Token: 0x06007ECB RID: 32459 RVA: 0x01050FA8 File Offset: 0x0104F1A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M407_CatchTheWind.$ReturnToTown$39015(this).GetEnumerator();
	}

	// Token: 0x06007ECC RID: 32460 RVA: 0x01050FB8 File Offset: 0x0104F1B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M407_CatchTheWind.$ReturnToGuild$39020(this).GetEnumerator();
	}

	// Token: 0x06007ECD RID: 32461 RVA: 0x01050FC8 File Offset: 0x0104F1C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M407_CatchTheWind.$ReturnToCamp$39024(this).GetEnumerator();
	}

	// Token: 0x06007ECE RID: 32462 RVA: 0x01050FD8 File Offset: 0x0104F1D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (49692 - 236913 != -187221)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (24883 - 5573 == 19310)
			{
				Hashtable hashtable = new Hashtable();
				if (90856 - 318671 == -227815)
				{
					hashtable.Add(43, PlayerData.UID);
					if (263806 - 342239 == -78433)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (26801 - 69238 == -42437)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007ECF RID: 32463 RVA: 0x010510B0 File Offset: 0x0104F2B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007ED0 RID: 32464 RVA: 0x010510C4 File Offset: 0x0104F2C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (256623 - 289091 != -32468)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (85849 - 267194 != -181344)
			{
				Hashtable hashtable = new Hashtable();
				if (47666 - 266813 == -219147)
				{
					if (Game.mNextGameCode == 30)
					{
						if (143815 - 123172 == 20644)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (274524 - 204930 != 69594)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (40184 - 524839 == -484654)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (238449 - 437227 != -198778)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (84890 - 193440 == -108549)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (98724 - 359588 != -260864)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (275821 - 170984 != 104837)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (204823 - 422686 != -217863)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (26448 - 586380 == -559931)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (207662 - 96475 != 111187)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (145367 - 248098 == -102730)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (97889 - 187247 == -89357)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (210363 - 383483 != -173120)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (89061 - 557209 != -468148)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (161857 - 149552 != 12305)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (290083 - 334935 == -44851)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (268376 - 222884 != 45492)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (185020 - 236465 != -51445)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (366 - 335080 != -334714)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (262858 - 229009 != 33849)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (261833 - 182815 == 79019)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (148904 - 494469 != -345565)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (293493 - 8521 != 284972)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (286615 - 365364 == -78748)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (175623 - 454256 != -278633)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (148569 - 16367 == 132203)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (29161 - 217565 == -188403)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (273295 - 532432 != -259137)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (295643 - 390869 != -95225)
					{
						this.OcwcFVpwIUK.OpCustom(42, hashtable, true);
						if (40909 - 366489 != -325579)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007ED1 RID: 32465 RVA: 0x01051678 File Offset: 0x0104F878
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007ED2 RID: 32466 RVA: 0x01051688 File Offset: 0x0104F888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007ED3 RID: 32467 RVA: 0x0105168C File Offset: 0x0104F88C
	internal static bool Eg5TexpBLUQR51mpiAUO()
	{
		return true;
	}

	// Token: 0x06007ED4 RID: 32468 RVA: 0x01051690 File Offset: 0x0104F890
	internal static bool a6xtj8pBOkkJM743YwEG()
	{
		return false;
	}

	// Token: 0x04007E7C RID: 32380
	private LitePeer OcwcFVpwIUK;

	// Token: 0x04007E7D RID: 32381
	private PlayerCameraControl wcycFh60VKE;

	// Token: 0x04007E7E RID: 32382
	private float wBjcFKrUlbc;

	// Token: 0x04007E7F RID: 32383
	private Texture daucFzPS7ZM;

	// Token: 0x04007E80 RID: 32384
	private int yxgcA5dbk6k;

	// Token: 0x04007E81 RID: 32385
	private float wU1cAcSKoeR;

	// Token: 0x04007E82 RID: 32386
	private GameObject peLcAnPJQAi;

	// Token: 0x04007E83 RID: 32387
	private CharacterController jl2cAQDDU60;

	// Token: 0x04007E84 RID: 32388
	private GameObject dvTcAepy56R;

	// Token: 0x04007E85 RID: 32389
	private GameObject VFQcAINdror;

	// Token: 0x04007E86 RID: 32390
	private GameObject v4YcAJ7CQQK;

	// Token: 0x04007E87 RID: 32391
	private GameObject w8VcA6VDHEW;

	// Token: 0x04007E88 RID: 32392
	private GameObject zgwcAtKMhqr;

	// Token: 0x04007E89 RID: 32393
	private GameObject GUqcAXDXE7G;

	// Token: 0x04007E8A RID: 32394
	private GameObject PQBcAOq7loS;

	// Token: 0x04007E8B RID: 32395
	private GameObject lb3cA2fArhS;

	// Token: 0x04007E8C RID: 32396
	private int xVBcAvntiJa;

	// Token: 0x04007E8D RID: 32397
	public GameObject cyclone;

	// Token: 0x04007E8E RID: 32398
	public GameObject spiritOfWind;

	// Token: 0x04007E8F RID: 32399
	public AudioClip talk_vc;

	// Token: 0x04007E90 RID: 32400
	public AudioClip play_vc;

	// Token: 0x04007E91 RID: 32401
	public AudioClip nAttack_vc;

	// Token: 0x04007E92 RID: 32402
	public AudioClip cAttack_vc;

	// Token: 0x0200155F RID: 5471
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38974 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007ED5 RID: 32469 RVA: 0x01051694 File Offset: 0x0104F894
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38974(M407_CatchTheWind self_)
		{
			if (89267 - 507082 != -417814)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (111964 - 273156 != -161191)
				{
					base..ctor();
					if (87197 - 181661 != -94463)
					{
						this.$self_$38989 = self_;
						if (137507 - 286182 != -148674)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007ED6 RID: 32470 RVA: 0x0105172C File Offset: 0x0104F92C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M407_CatchTheWind.$StartGame$38974.$(this.$self_$38989);
		}

		// Token: 0x06007ED7 RID: 32471 RVA: 0x0105173C File Offset: 0x0104F93C
		internal static bool w2OouspBmwJ6LgbZGCUt()
		{
			return true;
		}

		// Token: 0x06007ED8 RID: 32472 RVA: 0x01051740 File Offset: 0x0104F940
		internal static bool ja4LyTpBFUo5Gf6K9qhS()
		{
			return false;
		}

		// Token: 0x04007E93 RID: 32403
		internal M407_CatchTheWind $self_$38989;

		// Token: 0x02001560 RID: 5472
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007ED9 RID: 32473 RVA: 0x01051744 File Offset: 0x0104F944
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M407_CatchTheWind self_)
			{
				if (231974 - 51968 != 180007)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (118736 - 140797 != -22060)
					{
						base..ctor();
						if (57931 - 464953 != -407021)
						{
							this.$self_$38988 = self_;
							if (193765 - 559844 != -366078)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007EDA RID: 32474 RVA: 0x010517DC File Offset: 0x0104F9DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (142761 - 292558 != -149797)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_26F;
					case 1:
						goto IL_1F02;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (272920 - 236156 != 36765)
							{
								goto Block_173;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Hold;
							if (281497 - 137067 != 144430)
							{
								continue;
							}
							this.$self_$38988.SendMessage("fadeIn");
							if (27919 - 202901 != -174981)
							{
								goto Block_146;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (23314 - 370024 != -346710)
							{
								continue;
							}
							goto IL_11DD;
						}
						else
						{
							this.$mStoryGui$38983 = (StoryGui)this.$self_$38988.GetComponent(typeof(StoryGui));
							if (140349 - 178211 == -37861)
							{
								continue;
							}
							this.$mStoryTimer$38984 = 0f;
							if (201254 - 455446 != -254192)
							{
								continue;
							}
							this.$mHeroType$38985 = CharacterData.current.Type;
							if (271512 - 400967 != -129455)
							{
								continue;
							}
							this.$mHeroName$38986 = CharacterData.current.Name;
							if (297527 - 366108 != -68581)
							{
								continue;
							}
							this.$mStoryGui$38983.startStoryMessage(this.$mHeroType$38985, this.$mHeroName$38986, eTalkType.friend);
							if (234848 - 99159 != 135689)
							{
								continue;
							}
							goto IL_234;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (74456 - 482311 != -407854)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$38983.newStoryMessage(this.$mHeroType$38985, this.$mHeroName$38986, Language.getMessage("M407_CatchTheWind", 101), eTalkType.friend);
							if (218578 - 485302 != -266724)
							{
								continue;
							}
							this.$mStoryTimer$38984 = Time.time + 5f;
							if (63176 - 385945 != -322768)
							{
								goto Block_200;
							}
							continue;
						}
						break;
					case 5:
						goto IL_111D;
					case 6:
						goto IL_111D;
					case 7:
						if (Game.mGameState != eGameState.Hold)
						{
							if (90750 - 199638 != -108887)
							{
								goto Block_53;
							}
							continue;
						}
						else
						{
							this.$self_$38988.wcycFh60VKE.enabled = false;
							if (244108 - 60235 != 183873)
							{
								continue;
							}
							this.$self_$38988.wcycFh60VKE.specialTarget = null;
							if (139120 - 498725 == -359604)
							{
								continue;
							}
							this.$mStoryGui$38983.newStoryMessage(this.$mHeroType$38985, this.$mHeroName$38986, Language.getMessage("M407_CatchTheWind", 103), eTalkType.friend);
							if (271438 - 99127 == 172312)
							{
								continue;
							}
							this.$mStoryTimer$38984 = Time.time + 5f;
							if (75825 - 380946 != -305121)
							{
								continue;
							}
							goto IL_143B;
						}
						break;
					case 8:
						goto IL_1463;
					case 9:
						goto IL_1463;
					case 10:
						goto IL_12E8;
					case 11:
						goto IL_12E8;
					case 12:
						goto IL_18FF;
					case 13:
						goto IL_18FF;
					case 14:
						goto IL_1EAD;
					case 15:
						goto IL_1EAD;
					case 16:
						goto IL_13E7;
					case 17:
						goto IL_13E7;
					case 18:
						break;
					case 19:
						break;
					case 20:
						goto IL_8DA;
					case 21:
						goto IL_8DA;
					case 22:
						goto IL_B0A;
					case 23:
						goto IL_B0A;
					case 24:
						goto IL_15C2;
					case 25:
						goto IL_15C2;
					case 26:
						goto IL_B82;
					case 27:
						goto IL_B82;
					case 28:
						goto IL_D05;
					case 29:
						goto IL_D05;
					case 30:
						goto IL_887;
					case 31:
						goto IL_887;
					case 32:
						goto IL_1295;
					case 33:
						goto IL_1295;
					case 34:
						this.$self_$38988.SendMessage("fadeOut");
						if (247151 - 569378 != -322227)
						{
							continue;
						}
						goto IL_1534;
					case 35:
						if (Game.mGameState != eGameState.Hold)
						{
							if (27331 - 568412 != -541081)
							{
								continue;
							}
							goto IL_17D4;
						}
						else
						{
							if (this.$mPlayer2$38979)
							{
								if (43071 - 391960 == -348888)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mPlayer2$38979);
								if (235430 - 538577 == -303146)
								{
									continue;
								}
							}
							if (this.$mPlayer3$38980)
							{
								if (32292 - 543110 != -510818)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mPlayer3$38980);
								if (274212 - 301685 == -27472)
								{
									continue;
								}
							}
							this.$self_$38988.wcycFh60VKE.alignToObject("StartCamera1");
							if (187479 - 304995 != -117516)
							{
								continue;
							}
							this.$self_$38988.wcycFh60VKE.enabled = true;
							if (100400 - 52164 != 48236)
							{
								continue;
							}
							this.$self_$38988.SendMessage("fadeIn");
							if (212086 - 314640 != -102554)
							{
								continue;
							}
							goto IL_1745;
						}
						break;
					case 36:
						if (Game.mGameState != eGameState.Hold)
						{
							if (26889 - 276331 != -249442)
							{
								continue;
							}
							goto IL_1BB5;
						}
						else
						{
							this.$mGameGui$38987 = (GameGui)this.$self_$38988.GetComponent(typeof(GameGui));
							if (244202 - 203986 == 40217)
							{
								continue;
							}
							this.$mGameGui$38987.enabled = true;
							if (299657 - 133669 != 165989)
							{
								goto Block_113;
							}
							continue;
						}
						break;
					case 37:
						if (Game.mGameState != eGameState.Hold)
						{
							if (174202 - 456073 != -281870)
							{
								goto Block_80;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (179508 - 126176 != 53332)
							{
								continue;
							}
							this.YieldDefault(1);
							if (293965 - 41598 != 252368)
							{
								goto Block_110;
							}
							continue;
						}
						break;
					default:
						if (155258 - 249201 != -93943)
						{
							continue;
						}
						goto IL_26F;
					}
					if (this.$mStoryTimer$38984 > Time.time)
					{
						if (27608 - 548723 == -521114)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1FD;
						}
						if (242703 - 381947 == -139243)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (117461 - 263440 != -145979)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$38983.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 109), eTalkType.friend);
						if (108715 - 540452 == -431736)
						{
							continue;
						}
						this.$mStoryTimer$38984 = Time.time + 5f;
						if (148527 - 22619 != 125908)
						{
							continue;
						}
						goto IL_8B1;
					}
					IL_26F:
					Debug.Log("Start Game");
					if (154711 - 535324 != -380613)
					{
						continue;
					}
					Game.mGameState = eGameState.Start;
					if (292902 - 202501 == 90402)
					{
						continue;
					}
					this.$mCDat2$38975 = null;
					if (299841 - 325065 != -25224)
					{
						continue;
					}
					this.$mCDat3$38976 = null;
					if (122205 - 295264 != -173059)
					{
						continue;
					}
					this.$$switch$6826$38977 = CharacterData.mSlot;
					if (22275 - 131272 == -108996)
					{
						continue;
					}
					if (this.$$switch$6826$38977 == 1)
					{
						if (169256 - 343211 != -173955)
						{
							continue;
						}
						this.$mCDat2$38975 = CharacterData.getCDat(2);
						if (216725 - 216819 != -94)
						{
							continue;
						}
						this.$mCDat3$38976 = CharacterData.getCDat(3);
						if (42549 - 73472 != -30923)
						{
							continue;
						}
					}
					else if (this.$$switch$6826$38977 == 2)
					{
						if (144791 - 90826 == 53966)
						{
							continue;
						}
						this.$mCDat2$38975 = CharacterData.getCDat(1);
						if (88588 - 150650 != -62062)
						{
							continue;
						}
						this.$mCDat3$38976 = CharacterData.getCDat(3);
						if (235588 - 154265 == 81324)
						{
							continue;
						}
					}
					else if (this.$$switch$6826$38977 == 3)
					{
						if (64215 - 429212 == -364996)
						{
							continue;
						}
						this.$mCDat2$38975 = CharacterData.getCDat(1);
						if (182934 - 476178 == -293243)
						{
							continue;
						}
						this.$mCDat3$38976 = CharacterData.getCDat(2);
						if (218206 - 571699 == -353492)
						{
							continue;
						}
					}
					this.$mPlayer1$38978 = Game.mPlayer;
					if (122328 - 269754 == -147425)
					{
						continue;
					}
					this.$mPlayer2$38979 = null;
					if (69442 - 177132 != -107690)
					{
						continue;
					}
					this.$mPlayer3$38980 = null;
					if (49973 - 70525 != -20552)
					{
						continue;
					}
					this.$mStartPoint2$38981 = GameObject.Find("StartPoint2");
					if (81771 - 168874 != -87103)
					{
						continue;
					}
					if (this.$mStartPoint2$38981)
					{
						if (276220 - 356022 != -79802)
						{
							continue;
						}
						if (this.$mCDat2$38975 != null)
						{
							if (33511 - 222868 != -189357)
							{
								continue;
							}
							if (this.$mCDat2$38975.Type != "none")
							{
								if (253927 - 174 != 253753)
								{
									continue;
								}
								this.$mPlayer2$38979 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat2$38975.Type, typeof(GameObject)), this.$mStartPoint2$38981.transform.position, this.$mStartPoint2$38981.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
								if (217202 - 62256 != 154946)
								{
									continue;
								}
								if (this.$mPlayer2$38979)
								{
									if (274465 - 355341 != -80876)
									{
										continue;
									}
									this.$mPlayer2$38979.SendMessage("EquipCDat", this.$mCDat2$38975.slot);
									if (98232 - 52574 == 45659)
									{
										continue;
									}
								}
							}
						}
					}
					this.$mStartPoint3$38982 = GameObject.Find("StartPoint3");
					if (279164 - 91744 == 187421)
					{
						continue;
					}
					if (!this.$mStartPoint3$38982)
					{
						goto IL_1803;
					}
					if (30628 - 128675 == -98046)
					{
						continue;
					}
					if (this.$mCDat3$38976 == null)
					{
						goto IL_1803;
					}
					if (292394 - 572684 == -280289)
					{
						continue;
					}
					if (!(this.$mCDat3$38976.Type != "none"))
					{
						goto IL_1803;
					}
					if (79467 - 394791 != -315324)
					{
						continue;
					}
					this.$mPlayer3$38980 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat3$38976.Type, typeof(GameObject)), this.$mStartPoint3$38982.transform.position, this.$mStartPoint3$38982.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
					if (94218 - 257552 != -163334)
					{
						continue;
					}
					if (!this.$mPlayer3$38980)
					{
						goto IL_1803;
					}
					if (76349 - 76973 == -623)
					{
						continue;
					}
					this.$mPlayer3$38980.SendMessage("EquipCDat", this.$mCDat3$38976.slot);
					if (212581 - 451589 != -239007)
					{
						goto Block_104;
					}
					continue;
					IL_111D:
					if (this.$mStoryTimer$38984 > Time.time)
					{
						if (97356 - 112351 == -14994)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1111;
						}
						if (118683 - 396694 != -278011)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (8809 - 204249 != -195440)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$38983.newStoryMessage(this.$mHeroType$38985, this.$mHeroName$38986, Language.getMessage("M407_CatchTheWind", 102), eTalkType.friend);
						if (230799 - 541777 != -310978)
						{
							continue;
						}
						this.$self_$38988.wcycFh60VKE.StartCoroutine_Auto(this.$self_$38988.wcycFh60VKE.slerpToObject("EventCamera1", 2f));
						if (150087 - 495488 != -345401)
						{
							continue;
						}
						goto IL_7C4;
					}
					IL_1295:
					if (this.$mStoryTimer$38984 > Time.time)
					{
						if (295067 - 210487 != 84580)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1288;
						}
						if (2071 - 398102 != -396031)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (33907 - 135397 != -101490)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$38983.close();
						if (280489 - 322482 != -41992)
						{
							goto Block_41;
						}
						continue;
					}
					IL_15C2:
					if (this.$mStoryTimer$38984 > Time.time)
					{
						if (20844 - 52769 != -31925)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_15B5;
						}
						if (70288 - 242934 == -172645)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (263778 - 31692 != 232087)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38983.newStoryMessage(this.$mHeroType$38985, this.$mHeroName$38986, Language.getMessage("M407_CatchTheWind", 112), eTalkType.friend);
						if (251574 - 332834 == -81259)
						{
							continue;
						}
						this.$mStoryTimer$38984 = Time.time + 5f;
						if (171252 - 105189 != 66063)
						{
							continue;
						}
						goto IL_B59;
					}
					IL_B82:
					if (this.$mStoryTimer$38984 > Time.time)
					{
						if (298738 - 285657 != 13081)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_B75;
						}
						if (236319 - 199785 == 36535)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (59928 - 449392 != -389463)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$self_$38988.yxgcA5dbk6k = 1;
						if (53400 - 8881 == 44520)
						{
							continue;
						}
						this.$mStoryGui$38983.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 113), eTalkType.friend);
						if (45804 - 318581 == -272776)
						{
							continue;
						}
						this.$mStoryTimer$38984 = Time.time + 5f;
						if (249357 - 159167 != 90190)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) == 0)
						{
							goto IL_CDC;
						}
						if (113903 - 593619 != -479716)
						{
							continue;
						}
						if (this.$self_$38988.play_vc)
						{
							if (284409 - 18194 != 266215)
							{
								continue;
							}
							this.$self_$38988.audio.PlayOneShot(this.$self_$38988.play_vc);
							if (21803 - 270177 != -248374)
							{
								continue;
							}
							goto IL_1882;
						}
						else
						{
							Debug.LogError("Cannot find play voice");
							if (87507 - 336188 != -248680)
							{
								goto Block_175;
							}
							continue;
						}
					}
					IL_D05:
					if (this.$mStoryTimer$38984 > Time.time)
					{
						if (20693 - 135315 != -114622)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_CF8;
						}
						if (218907 - 560573 == -341665)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (159611 - 201010 != -41398)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38983.newStoryMessage(this.$mHeroType$38985, this.$mHeroName$38986, Language.getMessage("M407_CatchTheWind", 114), eTalkType.friend);
						if (121136 - 270981 != -149845)
						{
							continue;
						}
						this.$mStoryTimer$38984 = Time.time + 5f;
						if (226743 - 192368 != 34376)
						{
							goto Block_38;
						}
						continue;
					}
					IL_1EAD:
					if (this.$mStoryTimer$38984 > Time.time)
					{
						if (51041 - 161784 != -110743)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1EA0;
						}
						if (163209 - 489977 != -326768)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (85506 - 561732 != -476226)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$38983.newStoryMessage(this.$mHeroType$38985, this.$mHeroName$38986, Language.getMessage("M407_CatchTheWind", 107), eTalkType.friend);
						if (143109 - 324336 == -181226)
						{
							continue;
						}
						this.$mStoryTimer$38984 = Time.time + 5f;
						if (101578 - 507649 != -406070)
						{
							goto Block_64;
						}
						continue;
					}
					IL_8DA:
					if (this.$mStoryTimer$38984 > Time.time)
					{
						if (68597 - 424960 == -356362)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_8CD;
						}
						if (193421 - 498221 != -304800)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (129373 - 391567 != -262194)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$38983.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 110), eTalkType.friend);
						if (181027 - 460772 != -279745)
						{
							continue;
						}
						this.$mStoryTimer$38984 = Time.time + 5f;
						if (50159 - 228067 != -177908)
						{
							continue;
						}
						goto IL_AE1;
					}
					IL_887:
					if (this.$mStoryTimer$38984 > Time.time)
					{
						if (135235 - 201409 != -66174)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_87A;
						}
						if (149589 - 135431 != 14158)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (284107 - 447992 != -163884)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38983.newStoryMessage(this.$mHeroType$38985, this.$mHeroName$38986, Language.getMessage("M407_CatchTheWind", 115), eTalkType.friend);
						if (141859 - 22302 != 119557)
						{
							continue;
						}
						this.$mStoryTimer$38984 = Time.time + 5f;
						if (244401 - 465672 != -221271)
						{
							continue;
						}
						goto IL_126C;
					}
					IL_13E7:
					if (this.$mStoryTimer$38984 > Time.time)
					{
						if (123380 - 184199 == -60818)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_13DA;
						}
						if (128860 - 157691 == -28830)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (11049 - 474865 != -463816)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$38983.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 108), eTalkType.friend);
						if (28010 - 269576 != -241566)
						{
							continue;
						}
						this.$self_$38988.wcycFh60VKE.alignToObject("EventCamera3");
						if (89774 - 257217 == -167442)
						{
							continue;
						}
						this.$mStoryTimer$38984 = Time.time + 5f;
						if (7613 - 354523 != -346909)
						{
							goto Block_199;
						}
						continue;
					}
					IL_1463:
					if (this.$mStoryTimer$38984 > Time.time)
					{
						if (16727 - 555535 != -538808)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1456;
						}
						if (287002 - 469936 == -182933)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (259074 - 254224 != 4851)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38983.newStoryMessage(this.$mHeroType$38985, this.$mHeroName$38986, Language.getMessage("M407_CatchTheWind", 104), eTalkType.friend);
						if (239126 - 332748 != -93622)
						{
							continue;
						}
						this.$mStoryTimer$38984 = Time.time + 5f;
						if (181890 - 93659 != 88232)
						{
							goto Block_127;
						}
						continue;
					}
					IL_B0A:
					if (this.$mStoryTimer$38984 > Time.time)
					{
						if (41898 - 238487 == -196588)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_AFD;
						}
						if (69973 - 71195 == -1221)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (65071 - 381864 != -316792)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38983.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 111), eTalkType.friend);
						if (152719 - 332252 != -179533)
						{
							continue;
						}
						this.$mStoryTimer$38984 = Time.time + 5f;
						if (113584 - 256147 != -142562)
						{
							goto Block_176;
						}
						continue;
					}
					IL_18FF:
					if (this.$mStoryTimer$38984 > Time.time)
					{
						if (49066 - 329741 == -280674)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_18F2;
						}
						if (204074 - 270148 == -66073)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (64632 - 449672 != -385039)
						{
							break;
						}
						continue;
					}
					else
					{
						if (this.$mPlayer1$38978)
						{
							if (227192 - 482936 != -255744)
							{
								continue;
							}
							this.$mPlayer1$38978.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$self_$38988.peLcAnPJQAi.transform.position - this.$mPlayer1$38978.transform.position));
							if (249851 - 530077 != -280226)
							{
								continue;
							}
						}
						if (this.$mPlayer2$38979)
						{
							if (199620 - 510228 == -310607)
							{
								continue;
							}
							this.$mPlayer2$38979.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$self_$38988.peLcAnPJQAi.transform.position - this.$mPlayer2$38979.transform.position)) * Quaternion.Euler((float)270, (float)90, (float)0);
							if (91760 - 210821 == -119060)
							{
								continue;
							}
						}
						if (this.$mPlayer3$38980)
						{
							if (109822 - 282426 == -172603)
							{
								continue;
							}
							this.$mPlayer3$38980.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$self_$38988.peLcAnPJQAi.transform.position - this.$mPlayer3$38980.transform.position)) * Quaternion.Euler((float)270, (float)90, (float)0);
							if (246705 - 130513 != 116192)
							{
								continue;
							}
						}
						this.$self_$38988.wcycFh60VKE.alignToObject("EventCamera2");
						if (123923 - 352799 == -228875)
						{
							continue;
						}
						this.$mStoryGui$38983.newStoryMessage(this.$mHeroType$38985, this.$mHeroName$38986, Language.getMessage("M407_CatchTheWind", 106), eTalkType.friend);
						if (146387 - 560188 != -413801)
						{
							continue;
						}
						this.$mStoryTimer$38984 = Time.time + 5f;
						if (133464 - 213480 != -80015)
						{
							goto Block_203;
						}
						continue;
					}
					IL_12E8:
					if (this.$mStoryTimer$38984 > Time.time)
					{
						if (276442 - 463691 == -187248)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_12DB;
						}
						if (19512 - 499263 == -479750)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (120706 - 157397 == -36691)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$38983.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 105), eTalkType.friend);
						if (2834 - 232495 == -229661)
						{
							this.$mStoryTimer$38984 = Time.time + 5f;
							if (99484 - 34294 != 65191)
							{
								if (PlayerPrefs.GetInt("nvoice", 1) == 0)
								{
									goto IL_18D6;
								}
								if (209189 - 453437 == -244248)
								{
									if (this.$self_$38988.talk_vc)
									{
										if (80136 - 539868 == -459732)
										{
											this.$self_$38988.audio.PlayOneShot(this.$self_$38988.talk_vc);
											if (147312 - 97620 == 49692)
											{
												goto IL_16AD;
											}
										}
									}
									else
									{
										Debug.LogError("Cannot find talk voice");
										if (178007 - 178384 != -376)
										{
											goto Block_160;
										}
									}
								}
							}
						}
					}
				}
				goto IL_1F02;
				IL_1FD:
				return this.YieldDefault(19);
				IL_234:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_14:
				goto IL_1F02;
				Block_38:
				return this.Yield(30, new WaitForSeconds(1f));
				goto IL_1F02;
				Block_41:
				return this.Yield(34, new WaitForSeconds(0.5f));
				IL_7C4:
				return this.Yield(7, new WaitForSeconds(4f));
				Block_53:
				goto IL_1F02;
				IL_87A:
				return this.YieldDefault(31);
				IL_8B1:
				return this.Yield(20, new WaitForSeconds(1f));
				IL_8CD:
				return this.YieldDefault(21);
				Block_64:
				return this.Yield(16, new WaitForSeconds(1f));
				goto IL_1F02;
				IL_AE1:
				return this.Yield(22, new WaitForSeconds(1f));
				IL_AFD:
				return this.YieldDefault(23);
				IL_B59:
				return this.Yield(26, new WaitForSeconds(1f));
				IL_B75:
				return this.YieldDefault(27);
				Block_80:
				goto IL_1F02;
				IL_CDC:
				return this.Yield(28, new WaitForSeconds(1f));
				IL_CF8:
				return this.YieldDefault(29);
				Block_104:
				goto IL_1803;
				Block_110:
				goto IL_1F02;
				Block_113:
				return this.Yield(37, new WaitForSeconds(1f));
				goto IL_1F02;
				IL_1111:
				return this.YieldDefault(6);
				IL_11DD:
				goto IL_1F02;
				Block_127:
				return this.Yield(10, new WaitForSeconds(1f));
				IL_126C:
				return this.Yield(32, new WaitForSeconds(1f));
				IL_1288:
				return this.YieldDefault(33);
				IL_12DB:
				return this.YieldDefault(11);
				goto IL_1F02;
				IL_13DA:
				return this.YieldDefault(17);
				IL_143B:
				return this.Yield(8, new WaitForSeconds(1f));
				IL_1456:
				return this.YieldDefault(9);
				goto IL_1F02;
				Block_146:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_1534:
				return this.Yield(35, new WaitForSeconds(1f));
				IL_15B5:
				return this.YieldDefault(25);
				goto IL_1F02;
				IL_16AD:
				Block_160:
				goto IL_18D6;
				IL_1745:
				return this.Yield(36, new WaitForSeconds(1f));
				IL_17D4:
				goto IL_1F02;
				IL_1803:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_173:
				goto IL_1F02;
				IL_1882:
				Block_175:
				goto IL_CDC;
				Block_176:
				return this.Yield(24, new WaitForSeconds(1f));
				IL_18D6:
				return this.Yield(12, new WaitForSeconds(1f));
				IL_18F2:
				return this.YieldDefault(13);
				IL_1BB5:
				goto IL_1F02;
				Block_199:
				return this.Yield(18, new WaitForSeconds(1f));
				Block_200:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_203:
				return this.Yield(14, new WaitForSeconds(1f));
				goto IL_1F02;
				IL_1EA0:
				return this.YieldDefault(15);
				IL_1F02:
				return false;
			}

			// Token: 0x06007EDB RID: 32475 RVA: 0x01053700 File Offset: 0x01051900
			internal static bool dW23gapBMB094jZxpJIN()
			{
				return true;
			}

			// Token: 0x06007EDC RID: 32476 RVA: 0x01053704 File Offset: 0x01051904
			internal static bool jNpyvppBxpYf7sECrZYu()
			{
				return false;
			}

			// Token: 0x04007E94 RID: 32404
			internal CharacterDataClass $mCDat2$38975;

			// Token: 0x04007E95 RID: 32405
			internal CharacterDataClass $mCDat3$38976;

			// Token: 0x04007E96 RID: 32406
			internal int $$switch$6826$38977;

			// Token: 0x04007E97 RID: 32407
			internal GameObject $mPlayer1$38978;

			// Token: 0x04007E98 RID: 32408
			internal GameObject $mPlayer2$38979;

			// Token: 0x04007E99 RID: 32409
			internal GameObject $mPlayer3$38980;

			// Token: 0x04007E9A RID: 32410
			internal GameObject $mStartPoint2$38981;

			// Token: 0x04007E9B RID: 32411
			internal GameObject $mStartPoint3$38982;

			// Token: 0x04007E9C RID: 32412
			internal StoryGui $mStoryGui$38983;

			// Token: 0x04007E9D RID: 32413
			internal float $mStoryTimer$38984;

			// Token: 0x04007E9E RID: 32414
			internal string $mHeroType$38985;

			// Token: 0x04007E9F RID: 32415
			internal string $mHeroName$38986;

			// Token: 0x04007EA0 RID: 32416
			internal GameGui $mGameGui$38987;

			// Token: 0x04007EA1 RID: 32417
			internal M407_CatchTheWind $self_$38988;
		}
	}

	// Token: 0x02001561 RID: 5473
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWindGod$38990 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007EDD RID: 32477 RVA: 0x01053708 File Offset: 0x01051908
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWindGod$38990(M407_CatchTheWind self_)
		{
			if (205245 - 80865 != 124381)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (51608 - 392190 == -340582)
				{
					base..ctor();
					if (111190 - 80640 == 30550)
					{
						this.$self_$39003 = self_;
						if (241936 - 373623 != -131686)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007EDE RID: 32478 RVA: 0x010537A0 File Offset: 0x010519A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M407_CatchTheWind.$TalkToWindGod$38990.$(this.$self_$39003);
		}

		// Token: 0x06007EDF RID: 32479 RVA: 0x010537B0 File Offset: 0x010519B0
		internal static bool pLMyqxpBgHy6xBixuLZQ()
		{
			return true;
		}

		// Token: 0x06007EE0 RID: 32480 RVA: 0x010537B4 File Offset: 0x010519B4
		internal static bool dGqfKMpBfFOY75OHvWqr()
		{
			return false;
		}

		// Token: 0x04007EA2 RID: 32418
		internal M407_CatchTheWind $self_$39003;

		// Token: 0x02001562 RID: 5474
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007EE1 RID: 32481 RVA: 0x010537B8 File Offset: 0x010519B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M407_CatchTheWind self_)
			{
				if (131535 - 510360 != -378824)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (217472 - 137035 == 80437)
					{
						base..ctor();
						if (1934 - 86137 == -84203)
						{
							this.$self_$39002 = self_;
							if (231193 - 564756 == -333563)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007EE2 RID: 32482 RVA: 0x01053850 File Offset: 0x01051A50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (128313 - 280891 != -152578)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1522;
					case 1:
						goto IL_2C92;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (140288 - 474469 != -334181)
							{
								continue;
							}
							goto IL_2BA8;
						}
						else
						{
							this.$self_$39002.SendMessage("fadeOut");
							if (163625 - 186184 != -22558)
							{
								goto Block_309;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (7399 - 334802 != -327402)
							{
								goto Block_217;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$38992 = (StoryGui)this.$self_$39002.GetComponent(typeof(StoryGui));
							if (253825 - 218769 == 35057)
							{
								continue;
							}
							this.$mStoryTimer$38993 = 0f;
							if (66538 - 90759 == -24220)
							{
								continue;
							}
							this.$mHeroType$38994 = CharacterData.current.Type;
							if (50478 - 96550 != -46072)
							{
								continue;
							}
							this.$mHeroName$38995 = CharacterData.current.Name;
							if (38013 - 344850 != -306837)
							{
								continue;
							}
							this.$mPlayer1$38996 = Game.mPlayer;
							if (207274 - 39948 == 167327)
							{
								continue;
							}
							if (this.$self_$39002.yxgcA5dbk6k < 3)
							{
								if (162984 - 460880 != -297896)
								{
									continue;
								}
								if (this.$self_$39002.zgwcAtKMhqr)
								{
									if (227589 - 555994 != -328405)
									{
										continue;
									}
									if (this.$mPlayer1$38996)
									{
										if (144321 - 50522 == 93800)
										{
											continue;
										}
										this.$mPlayer1$38996.transform.position = this.$self_$39002.zgwcAtKMhqr.transform.position;
										if (238440 - 328995 == -90554)
										{
											continue;
										}
										this.$mPlayer1$38996.transform.rotation = this.$self_$39002.zgwcAtKMhqr.transform.rotation;
										if (186638 - 348383 != -161745)
										{
											continue;
										}
									}
								}
								this.$self_$39002.SendMessage("alignToObject", "EventCamera4");
								if (92128 - 483667 != -391539)
								{
									continue;
								}
								goto IL_FBF;
							}
							else
							{
								this.$mCDat2$38997 = null;
								if (96665 - 321696 != -225031)
								{
									continue;
								}
								this.$mCDat3$38998 = null;
								if (146585 - 471347 == -324761)
								{
									continue;
								}
								this.$$switch$6828$38999 = CharacterData.mSlot;
								if (205968 - 230708 == -24739)
								{
									continue;
								}
								if (this.$$switch$6828$38999 == 1)
								{
									if (12715 - 413604 == -400888)
									{
										continue;
									}
									this.$mCDat2$38997 = CharacterData.getCDat(2);
									if (191188 - 243617 != -52429)
									{
										continue;
									}
									this.$mCDat3$38998 = CharacterData.getCDat(3);
									if (281069 - 226325 == 54745)
									{
										continue;
									}
								}
								else if (this.$$switch$6828$38999 == 2)
								{
									if (70505 - 52612 != 17893)
									{
										continue;
									}
									this.$mCDat2$38997 = CharacterData.getCDat(1);
									if (129775 - 7186 != 122589)
									{
										continue;
									}
									this.$mCDat3$38998 = CharacterData.getCDat(3);
									if (225180 - 151281 != 73899)
									{
										continue;
									}
								}
								else if (this.$$switch$6828$38999 == 3)
								{
									if (107083 - 390470 != -283387)
									{
										continue;
									}
									this.$mCDat2$38997 = CharacterData.getCDat(1);
									if (115929 - 141007 != -25078)
									{
										continue;
									}
									this.$mCDat3$38998 = CharacterData.getCDat(2);
									if (140660 - 268027 == -127366)
									{
										continue;
									}
								}
								if (this.$self_$39002.GUqcAXDXE7G)
								{
									if (259253 - 365327 == -106073)
									{
										continue;
									}
									if (this.$mPlayer1$38996)
									{
										if (214500 - 445311 == -230810)
										{
											continue;
										}
										this.$mPlayer1$38996.transform.position = this.$self_$39002.GUqcAXDXE7G.transform.position;
										if (3953 - 541809 != -537856)
										{
											continue;
										}
										this.$mPlayer1$38996.transform.rotation = this.$self_$39002.GUqcAXDXE7G.transform.rotation;
										if (94691 - 410960 != -316269)
										{
											continue;
										}
									}
								}
								if (this.$self_$39002.PQBcAOq7loS)
								{
									if (268769 - 506291 == -237521)
									{
										continue;
									}
									if (this.$mCDat2$38997 != null)
									{
										if (196573 - 337304 != -140731)
										{
											continue;
										}
										if (this.$mCDat2$38997.Type != "none")
										{
											if (178601 - 484409 == -305807)
											{
												continue;
											}
											this.$mPlayer2$39000 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat2$38997.Type, typeof(GameObject)), this.$self_$39002.PQBcAOq7loS.transform.position, this.$self_$39002.PQBcAOq7loS.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
											if (157942 - 223426 == -65483)
											{
												continue;
											}
											if (this.$mPlayer2$39000)
											{
												if (34169 - 381268 != -347099)
												{
													continue;
												}
												this.$mPlayer2$39000.SendMessage("EquipCDat", this.$mCDat2$38997.slot);
												if (27198 - 169354 == -142155)
												{
													continue;
												}
											}
										}
									}
								}
								if (this.$self_$39002.lb3cA2fArhS)
								{
									if (290365 - 181101 != 109264)
									{
										continue;
									}
									if (this.$mCDat3$38998 != null)
									{
										if (119058 - 395608 == -276549)
										{
											continue;
										}
										if (this.$mCDat3$38998.Type != "none")
										{
											if (179319 - 132567 != 46752)
											{
												continue;
											}
											this.$mPlayer3$39001 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat3$38998.Type, typeof(GameObject)), this.$self_$39002.lb3cA2fArhS.transform.position, this.$self_$39002.lb3cA2fArhS.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
											if (29661 - 395258 != -365597)
											{
												continue;
											}
											if (this.$mPlayer3$39001)
											{
												if (146117 - 60833 != 85284)
												{
													continue;
												}
												this.$mPlayer3$39001.SendMessage("EquipCDat", this.$mCDat3$38998.slot);
												if (10452 - 24713 != -14261)
												{
													continue;
												}
											}
										}
									}
								}
								this.$self_$39002.SendMessage("alignToObject", "EventCamera5");
								if (278744 - 449492 != -170748)
								{
									continue;
								}
								goto IL_1D47;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (67016 - 363179 != -296162)
							{
								goto Block_108;
							}
							continue;
						}
						else
						{
							this.$self_$39002.SendMessage("fadeIn");
							if (199841 - 43340 != 156501)
							{
								continue;
							}
							goto IL_4CF;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (44077 - 486335 != -442257)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$38992.startStoryMessage("WindGod", "Sunsun", eTalkType.friend);
							if (193404 - 241518 != -48113)
							{
								goto Block_147;
							}
							continue;
						}
						break;
					case 6:
						this.$mStoryGui$38992.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 201), eTalkType.friend);
						if (286907 - 73297 != 213610)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (54978 - 161249 != -106270)
						{
							goto Block_127;
						}
						continue;
					case 7:
						goto IL_426;
					case 8:
						goto IL_426;
					case 9:
						goto IL_1A6B;
					case 10:
						goto IL_1A6B;
					case 11:
						goto IL_3D5;
					case 12:
						goto IL_3D5;
					case 13:
						goto IL_15A4;
					case 14:
						goto IL_15A4;
					case 15:
						goto IL_1EAF;
					case 16:
						goto IL_1EAF;
					case 17:
						goto IL_1A18;
					case 18:
						goto IL_1A18;
					case 19:
						goto IL_7F8;
					case 20:
						goto IL_7F8;
					case 21:
						goto IL_710;
					case 22:
						goto IL_710;
					case 23:
						if (Game.mGameState != eGameState.Hold)
						{
							if (169301 - 459621 != -290319)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$mGameGui$38991.enabled = true;
							if (184645 - 469975 == -285329)
							{
								continue;
							}
							this.$self_$39002.wcycFh60VKE.enabled = true;
							if (171481 - 332803 != -161322)
							{
								continue;
							}
							goto IL_2AF0;
						}
						break;
					case 24:
						if (Game.mGameState != eGameState.Hold)
						{
							if (155503 - 421332 != -265828)
							{
								goto Block_303;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (65027 - 82281 != -17254)
							{
								continue;
							}
							goto IL_2018;
						}
						break;
					case 25:
						if (Game.mGameState != eGameState.Hold)
						{
							if (259942 - 500883 != -240941)
							{
								continue;
							}
							goto IL_145B;
						}
						else
						{
							this.$self_$39002.SendMessage("fadeIn");
							if (165834 - 508034 != -342199)
							{
								goto Block_140;
							}
							continue;
						}
						break;
					case 26:
						if (Game.mGameState != eGameState.Hold)
						{
							if (193390 - 113943 != 79447)
							{
								continue;
							}
							goto IL_21C7;
						}
						else
						{
							this.$mStoryGui$38992.startStoryMessage(this.$mHeroType$38994, this.$mHeroName$38995, eTalkType.friend);
							if (105687 - 476144 != -370457)
							{
								continue;
							}
							goto IL_23E0;
						}
						break;
					case 27:
						this.$mStoryGui$38992.newStoryMessage(this.$mHeroType$38994, this.$mHeroName$38995, Language.getMessage("M407_CatchTheWind", 301), eTalkType.friend);
						if (68721 - 74275 == -5553)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (208639 - 401922 != -193283)
						{
							continue;
						}
						goto IL_1CF4;
					case 28:
						break;
					case 29:
						break;
					case 30:
						goto IL_28B3;
					case 31:
						goto IL_28B3;
					case 32:
						goto IL_1C1D;
					case 33:
						goto IL_1C1D;
					case 34:
						if (Game.mGameState != eGameState.Hold)
						{
							if (235601 - 101619 != 133982)
							{
								continue;
							}
							goto IL_DFE;
						}
						else
						{
							this.$mStoryGui$38992.newStoryMessage(this.$mHeroType$38994, this.$mHeroName$38995, Language.getMessage("M407_CatchTheWind", 305), eTalkType.friend);
							if (83244 - 561591 != -478346)
							{
								goto Block_97;
							}
							continue;
						}
						break;
					case 35:
						if (Game.mGameState != eGameState.Hold)
						{
							if (10590 - 20719 != -10128)
							{
								goto Block_198;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$38992.newStoryMessage(this.$mHeroType$38994, this.$mHeroName$38995, Language.getMessage("M407_CatchTheWind", 306), eTalkType.friend);
							if (128146 - 94579 != 33568)
							{
								goto Block_115;
							}
							continue;
						}
						break;
					case 36:
						if (Game.mGameState != eGameState.Hold)
						{
							if (231451 - 282304 != -50853)
							{
								continue;
							}
							goto IL_B26;
						}
						else
						{
							this.$mStoryGui$38992.newStoryMessage(this.$mHeroType$38994, this.$mHeroName$38995, Language.getMessage("M407_CatchTheWind", 307), eTalkType.friend);
							if (297131 - 112989 != 184142)
							{
								continue;
							}
							goto IL_1E0B;
						}
						break;
					case 37:
						if (Game.mGameState != eGameState.Hold)
						{
							if (42114 - 425223 != -383109)
							{
								continue;
							}
							goto IL_2793;
						}
						else
						{
							this.$mStoryGui$38992.newStoryMessage(this.$mHeroType$38994, this.$mHeroName$38995, Language.getMessage("M407_CatchTheWind", 308), eTalkType.friend);
							if (140800 - 514220 != -373419)
							{
								goto Block_280;
							}
							continue;
						}
						break;
					case 38:
						if (Game.mGameState != eGameState.Hold)
						{
							if (99876 - 73444 != 26433)
							{
								goto Block_56;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$38992.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 309), eTalkType.friend);
							if (144898 - 595184 != -450286)
							{
								continue;
							}
							this.$mStoryTimer$38993 = Time.time + 5f;
							if (159314 - 490011 != -330696)
							{
								goto Block_296;
							}
							continue;
						}
						break;
					case 39:
						goto IL_1DE1;
					case 40:
						goto IL_1DE1;
					case 41:
						goto IL_2673;
					case 42:
						goto IL_2673;
					case 43:
						goto IL_18B0;
					case 44:
						goto IL_18B0;
					case 45:
						goto IL_29A6;
					case 46:
						goto IL_29A6;
					case 47:
						if (Game.mGameState != eGameState.Hold)
						{
							if (113977 - 579539 != -465562)
							{
								continue;
							}
							goto IL_4A0;
						}
						else
						{
							if (this.$mPlayer1$38996)
							{
								if (63279 - 159043 == -95763)
								{
									continue;
								}
								this.$mPlayer1$38996.transform.position = this.$mPlayer1$38996.transform.position - (float)2 * this.$mPlayer1$38996.transform.forward;
								if (244708 - 60048 != 184660)
								{
									continue;
								}
							}
							if (this.$mPlayer2$39000)
							{
								if (260030 - 315660 != -55630)
								{
									continue;
								}
								this.$mPlayer2$39000.transform.position = this.$mPlayer2$39000.transform.position - (float)2 * this.$self_$39002.PQBcAOq7loS.transform.forward;
								if (9962 - 579957 == -569994)
								{
									continue;
								}
							}
							if (!this.$mPlayer3$39001)
							{
								goto IL_50A;
							}
							if (96170 - 207846 == -111675)
							{
								continue;
							}
							this.$mPlayer3$39001.transform.position = this.$mPlayer3$39001.transform.position - (float)2 * this.$self_$39002.lb3cA2fArhS.transform.forward;
							if (184999 - 172317 != 12683)
							{
								goto Block_175;
							}
							continue;
						}
						break;
					case 48:
						if (Game.mGameState != eGameState.Hold)
						{
							if (65194 - 159564 != -94369)
							{
								goto Block_41;
							}
							continue;
						}
						else
						{
							this.$self_$39002.peLcAnPJQAi.animation.CrossFade("root", 0.2f);
							if (168958 - 395529 != -226570)
							{
								goto Block_235;
							}
							continue;
						}
						break;
					case 49:
						this.$mStoryGui$38992.newStoryMessage(this.$mHeroType$38994, this.$mHeroName$38995, Language.getMessage("M407_CatchTheWind", 314), eTalkType.friend);
						if (54094 - 494896 == -440801)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (267283 - 308517 != -41233)
						{
							goto Block_157;
						}
						continue;
					case 50:
						goto IL_2717;
					case 51:
						goto IL_2717;
					case 52:
						goto IL_2C68;
					case 53:
						goto IL_2C68;
					case 54:
						if (Game.mGameState != eGameState.Hold)
						{
							if (193378 - 396057 != -202679)
							{
								continue;
							}
							goto IL_1378;
						}
						else
						{
							if (this.$self_$39002.peLcAnPJQAi)
							{
								if (185358 - 61068 == 124291)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$39002.peLcAnPJQAi);
								if (236608 - 129489 == 107120)
								{
									continue;
								}
							}
							this.$mStoryTimer$38993 = Time.time + 3f;
							if (129962 - 358082 != -228119)
							{
								goto IL_1C9;
							}
							continue;
						}
						break;
					case 55:
						goto IL_1C9;
					case 56:
						goto IL_874;
					case 57:
						goto IL_874;
					case 58:
						if (Game.mGameState != eGameState.Hold)
						{
							if (23308 - 341740 != -318431)
							{
								goto Block_110;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(4071, 0);
							if (219564 - 427671 != -208107)
							{
								continue;
							}
							goto IL_2018;
						}
						break;
					default:
						if (132127 - 560470 != -428342)
						{
							goto IL_1522;
						}
						continue;
					}
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (61453 - 469048 == -407594)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1D10;
						}
						if (100131 - 538735 != -438604)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (157737 - 216857 != -59119)
						{
							goto Block_291;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38992.newStoryMessage(this.$mHeroType$38994, this.$mHeroName$38995, Language.getMessage("M407_CatchTheWind", 302), eTalkType.friend);
						if (139628 - 81575 == 58054)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (205583 - 552059 != -346475)
						{
							goto Block_104;
						}
						continue;
					}
					IL_3D5:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (21306 - 383310 != -362004)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3C8;
						}
						if (68042 - 218361 == -150318)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (100733 - 558378 != -457645)
						{
							continue;
						}
						goto IL_27DA;
					}
					else
					{
						this.$mStoryGui$38992.newStoryMessage(this.$mHeroType$38994, this.$mHeroName$38995, Language.getMessage("M407_CatchTheWind", 204), eTalkType.friend);
						if (146600 - 311610 != -165010)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (286973 - 154780 != 132193)
						{
							continue;
						}
						goto IL_157B;
					}
					IL_2C68:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (204913 - 121064 != 83849)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2C5B;
						}
						if (25587 - 236767 == -211179)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (220628 - 10471 != 210158)
						{
							goto Block_181;
						}
						continue;
					}
					else
					{
						this.$self_$39002.peLcAnPJQAi.animation.Play("nAttack");
						if (28455 - 329902 == -301446)
						{
							continue;
						}
						if (this.$self_$39002.spiritOfWind)
						{
							if (82304 - 65772 == 16533)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$39002.spiritOfWind, this.$self_$39002.peLcAnPJQAi.transform.position, Quaternion.identity);
							if (180152 - 6954 != 173198)
							{
								continue;
							}
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (49545 - 236170 != -186625)
							{
								continue;
							}
							if (this.$self_$39002.nAttack_vc)
							{
								if (146132 - 254984 != -108852)
								{
									continue;
								}
								this.$self_$39002.audio.PlayOneShot(this.$self_$39002.nAttack_vc);
								if (119141 - 303093 == -183951)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find nAttack voice");
								if (132836 - 156743 != -23907)
								{
									continue;
								}
							}
						}
						this.$mStoryGui$38992.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 316), eTalkType.friend);
						if (38698 - 313807 != -275108)
						{
							goto Block_163;
						}
						continue;
					}
					IL_1C9:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (152582 - 506903 == -354320)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1BC;
						}
						if (150835 - 382114 == -231278)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (31442 - 108925 != -77482)
						{
							goto Block_223;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38992.newStoryMessage(this.$mHeroType$38994, this.$mHeroName$38995, Language.getMessage("M407_CatchTheWind", 317), eTalkType.friend);
						if (243785 - 254139 != -10354)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (275475 - 17345 != 258130)
						{
							continue;
						}
						goto IL_84B;
					}
					IL_7F8:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (163072 - 498108 != -335036)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_7EB;
						}
						if (234027 - 265505 != -31478)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (229221 - 389044 != -159823)
						{
							continue;
						}
						goto IL_1F3;
					}
					else
					{
						this.$mStoryGui$38992.newStoryMessage(this.$mHeroType$38994, this.$mHeroName$38995, Language.getMessage("M407_CatchTheWind", 208), eTalkType.friend);
						if (14196 - 67155 != -52959)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (183188 - 289736 != -106547)
						{
							goto Block_289;
						}
						continue;
					}
					IL_29A6:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (20026 - 317759 == -297732)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2999;
						}
						if (263493 - 165013 != 98480)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (297518 - 512434 != -214915)
						{
							goto Block_266;
						}
						continue;
					}
					else
					{
						this.$self_$39002.peLcAnPJQAi.animation.Play("nAttack");
						if (249895 - 90275 != 159620)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (56775 - 42115 != 14660)
							{
								continue;
							}
							if (this.$self_$39002.cAttack_vc)
							{
								if (282183 - 201815 == 80369)
								{
									continue;
								}
								this.$self_$39002.audio.PlayOneShot(this.$self_$39002.cAttack_vc);
								if (64579 - 360647 != -296068)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find cAttack voice");
								if (251710 - 144061 == 107650)
								{
									continue;
								}
							}
						}
						if (this.$self_$39002.cyclone)
						{
							if (204118 - 109495 != 94623)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$39002.cyclone, this.$self_$39002.peLcAnPJQAi.transform.position, Quaternion.identity);
							if (54744 - 568277 != -513533)
							{
								continue;
							}
						}
						this.$mStoryGui$38992.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 313), eTalkType.friend);
						if (18251 - 359865 != -341613)
						{
							goto Block_95;
						}
						continue;
					}
					IL_2717:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (283504 - 444570 == -161065)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_270A;
						}
						if (230759 - 204777 == 25983)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (2662 - 356242 != -353580)
						{
							continue;
						}
						goto IL_2BF;
					}
					else
					{
						this.$mStoryGui$38992.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 315), eTalkType.friend);
						if (249983 - 585964 == -335980)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (82888 - 67171 != 15717)
						{
							continue;
						}
						goto IL_2C3F;
					}
					IL_1EAF:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (289276 - 546003 != -256727)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1EA2;
						}
						if (164595 - 415216 != -250621)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (148551 - 188258 != -39707)
						{
							continue;
						}
						goto IL_333;
					}
					else
					{
						this.$self_$39002.yxgcA5dbk6k = 3;
						if (200214 - 470878 != -270664)
						{
							continue;
						}
						this.$mStoryGui$38992.newStoryMessage(this.$mHeroType$38994, this.$mHeroName$38995, Language.getMessage("M407_CatchTheWind", 206), eTalkType.friend);
						if (88138 - 101093 == -12954)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (182287 - 227567 != -45280)
						{
							continue;
						}
						goto IL_19EF;
					}
					IL_426:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (157521 - 583878 == -426356)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_41A;
						}
						if (163016 - 201153 != -38137)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (278236 - 437212 != -158975)
						{
							goto Block_190;
						}
						continue;
					}
					else
					{
						this.$self_$39002.peLcAnPJQAi.animation.CrossFade("root", 0.2f);
						if (106998 - 514777 == -407778)
						{
							continue;
						}
						this.$mStoryGui$38992.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 202), eTalkType.friend);
						if (276797 - 466536 == -189738)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) != 0)
						{
							if (32633 - 257694 == -225060)
							{
								continue;
							}
							if (this.$self_$39002.talk_vc)
							{
								if (267266 - 133149 != 134117)
								{
									continue;
								}
								this.$self_$39002.audio.PlayOneShot(this.$self_$39002.talk_vc);
								if (78640 - 109382 != -30742)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find talk voice");
								if (292130 - 232818 == 59313)
								{
									continue;
								}
							}
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (81633 - 587689 != -506055)
						{
							goto Block_225;
						}
						continue;
					}
					IL_1DE1:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (180223 - 320682 != -140459)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1DD4;
						}
						if (33541 - 504543 != -471002)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (280378 - 23533 != 256845)
						{
							continue;
						}
						goto IL_148A;
					}
					else
					{
						this.$mStoryGui$38992.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 310), eTalkType.friend);
						if (253178 - 137264 != 115914)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (190444 - 92733 != 97712)
						{
							goto Block_236;
						}
						continue;
					}
					IL_710:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (156812 - 319758 == -162945)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_703;
						}
						if (21223 - 52072 == -30848)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (276269 - 64133 != 212136)
						{
							continue;
						}
						goto IL_5A9;
					}
					else
					{
						this.$mStoryGui$38992.close();
						if (42109 - 470063 != -427954)
						{
							continue;
						}
						break;
					}
					IL_2673:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (90145 - 578148 != -488003)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2666;
						}
						if (159315 - 410342 == -251026)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (46235 - 127023 != -80787)
						{
							goto Block_301;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38992.newStoryMessage(this.$mHeroType$38994, this.$mHeroName$38995, Language.getMessage("M407_CatchTheWind", 311), eTalkType.friend);
						if (32565 - 370798 == -338232)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (242542 - 313525 != -70982)
						{
							goto Block_122;
						}
						continue;
					}
					IL_874:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (274694 - 345998 == -71303)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_867;
						}
						if (63398 - 532709 != -469311)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (280810 - 51010 != 229801)
						{
							goto Block_238;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38992.close();
						if (293623 - 50697 != 242926)
						{
							continue;
						}
						goto IL_FFA;
					}
					IL_1A18:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (183093 - 254175 == -71081)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1A0B;
						}
						if (67878 - 187277 != -119399)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (42222 - 293130 != -250908)
						{
							continue;
						}
						goto IL_105E;
					}
					else
					{
						this.$mStoryGui$38992.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 207), eTalkType.friend);
						if (72063 - 86216 == -14152)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (111621 - 339994 != -228373)
						{
							continue;
						}
						goto IL_7CF;
					}
					IL_15A4:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (250420 - 115997 == 134424)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1597;
						}
						if (105372 - 9577 == 95796)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (225224 - 486681 != -261457)
						{
							continue;
						}
						goto IL_90D;
					}
					else
					{
						this.$mStoryGui$38992.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 205), eTalkType.friend);
						if (11330 - 152000 == -140669)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (55838 - 293848 != -238010)
						{
							continue;
						}
						goto IL_1E86;
					}
					IL_1A6B:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (152168 - 331331 == -179162)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1A5E;
						}
						if (87991 - 13746 != 74245)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (288193 - 35072 != 253122)
						{
							goto Block_73;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38992.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 203), eTalkType.friend);
						if (16754 - 368437 != -351683)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (255676 - 327050 != -71373)
						{
							goto Block_100;
						}
						continue;
					}
					IL_1C1D:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (204900 - 353826 == -148925)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1C10;
						}
						if (85416 - 111724 != -26308)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (60511 - 228497 != -167985)
						{
							goto Block_102;
						}
						continue;
					}
					else
					{
						this.$self_$39002.peLcAnPJQAi.animation.CrossFade("root", 0.2f);
						if (242304 - 550650 == -308345)
						{
							continue;
						}
						this.$mStoryGui$38992.newStoryMessage(this.$mHeroType$38994, this.$mHeroName$38995, Language.getMessage("M407_CatchTheWind", 304), eTalkType.friend);
						if (136024 - 361156 != -225131)
						{
							goto Block_299;
						}
						continue;
					}
					IL_28B3:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (227208 - 67882 != 159326)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_28A6;
						}
						if (51893 - 581777 != -529884)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (225120 - 408378 != -183257)
						{
							goto Block_201;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38992.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 303), eTalkType.friend);
						if (243107 - 516633 != -273526)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (241253 - 373218 != -131965)
						{
							continue;
						}
						goto IL_1BF4;
					}
					IL_1522:
					Debug.Log("OnTalkToWindGod");
					if (208827 - 149474 == 59354)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (130652 - 159812 != -29160)
						{
							continue;
						}
						goto IL_169;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (268199 - 227702 == 40498)
						{
							continue;
						}
						this.$self_$39002.wcycFh60VKE.enabled = false;
						if (230845 - 468854 == -238008)
						{
							continue;
						}
						this.$mGameGui$38991 = (GameGui)this.$self_$39002.GetComponent(typeof(GameGui));
						if (33502 - 116000 != -82498)
						{
							continue;
						}
						if (!this.$mGameGui$38991)
						{
							goto IL_129E;
						}
						if (13262 - 376843 != -363581)
						{
							continue;
						}
						this.$mGameGui$38991.close();
						if (234881 - 171015 != 63867)
						{
							goto Block_166;
						}
						continue;
					}
					IL_18B0:
					if (this.$mStoryTimer$38993 > Time.time)
					{
						if (114607 - 256558 != -141951)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_18A3;
						}
						if (174540 - 353154 != -178614)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (25778 - 21710 != 4069)
						{
							goto Block_151;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$38992.newStoryMessage("WindGod", "Sunsun", Language.getMessage("M407_CatchTheWind", 312), eTalkType.friend);
						if (243810 - 148512 != 95298)
						{
							continue;
						}
						this.$mStoryTimer$38993 = Time.time + 5f;
						if (57078 - 323372 != -266293)
						{
							goto Block_298;
						}
						continue;
					}
					IL_2018:
					this.YieldDefault(1);
					if (267797 - 441586 != -173788)
					{
						goto Block_226;
					}
				}
				return this.Yield(23, new WaitForSeconds(0.5f));
				Block_9:
				IL_169:
				goto IL_2C92;
				IL_1BC:
				return this.YieldDefault(55);
				IL_1F3:
				IL_2BF:
				IL_333:
				goto IL_2C92;
				IL_3C8:
				return this.YieldDefault(12);
				IL_41A:
				return this.YieldDefault(8);
				IL_4A0:
				goto IL_2C92;
				IL_4CF:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_39:
				goto IL_2C92;
				IL_50A:
				return this.Yield(48, new WaitForSeconds(0.6f));
				Block_41:
				IL_5A9:
				goto IL_2C92;
				IL_703:
				return this.YieldDefault(22);
				Block_56:
				goto IL_2C92;
				IL_7CF:
				return this.Yield(19, new WaitForSeconds(0.5f));
				IL_7EB:
				return this.YieldDefault(20);
				IL_84B:
				return this.Yield(56, new WaitForSeconds(0.5f));
				IL_867:
				return this.YieldDefault(57);
				IL_90D:
				Block_73:
				IL_B26:
				goto IL_2C92;
				Block_95:
				return this.Yield(47, new WaitForSeconds(0.6f));
				IL_DFE:
				goto IL_2C92;
				Block_97:
				return this.Yield(35, new WaitForSeconds(1.5f));
				Block_100:
				return this.Yield(11, new WaitForSeconds(0.5f));
				Block_102:
				goto IL_2C92;
				Block_104:
				return this.Yield(30, new WaitForSeconds(0.5f));
				IL_FBF:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_108:
				goto IL_2C92;
				IL_FFA:
				return this.Yield(58, new WaitForSeconds(2f));
				Block_110:
				IL_105E:
				goto IL_2C92;
				Block_115:
				return this.Yield(36, new WaitForSeconds(1.5f));
				Block_122:
				return this.Yield(43, new WaitForSeconds(0.5f));
				Block_127:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_129E:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1378:
				IL_145B:
				goto IL_2C92;
				Block_140:
				return this.Yield(26, new WaitForSeconds(1f));
				IL_148A:
				goto IL_2C92;
				Block_147:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_157B:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_1597:
				return this.YieldDefault(14);
				Block_151:
				goto IL_2C92;
				Block_157:
				return this.Yield(50, new WaitForSeconds(0.5f));
				Block_163:
				return this.Yield(54, new WaitForSeconds(0.8f));
				Block_166:
				goto IL_129E;
				IL_18A3:
				return this.YieldDefault(44);
				Block_175:
				goto IL_50A;
				Block_181:
				goto IL_2C92;
				IL_19EF:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_1A0B:
				return this.YieldDefault(18);
				IL_1A5E:
				return this.YieldDefault(10);
				Block_190:
				goto IL_2C92;
				IL_1BF4:
				return this.Yield(32, new WaitForSeconds(0.5f));
				IL_1C10:
				return this.YieldDefault(33);
				Block_198:
				Block_201:
				goto IL_2C92;
				IL_1CF4:
				return this.Yield(28, new WaitForSeconds(0.5f));
				IL_1D10:
				return this.YieldDefault(29);
				IL_1D47:
				return this.Yield(25, new WaitForSeconds(0.1f));
				IL_1DD4:
				return this.YieldDefault(40);
				IL_1E0B:
				return this.Yield(37, new WaitForSeconds(1.5f));
				IL_1E86:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_1EA2:
				return this.YieldDefault(16);
				Block_217:
				Block_223:
				goto IL_2C92;
				Block_225:
				return this.Yield(9, new WaitForSeconds(0.5f));
				Block_226:
				goto IL_2C92;
				Block_235:
				return this.Yield(49, new WaitForSeconds(1.3f));
				Block_236:
				return this.Yield(41, new WaitForSeconds(0.5f));
				Block_238:
				IL_21C7:
				goto IL_2C92;
				IL_23E0:
				return this.Yield(27, new WaitForSeconds(0.5f));
				Block_266:
				goto IL_2C92;
				IL_2666:
				return this.YieldDefault(42);
				IL_270A:
				return this.YieldDefault(51);
				IL_2793:
				goto IL_2C92;
				Block_280:
				return this.Yield(38, new WaitForSeconds(1.5f));
				IL_27DA:
				goto IL_2C92;
				IL_28A6:
				return this.YieldDefault(31);
				Block_289:
				return this.Yield(21, new WaitForSeconds(0.5f));
				Block_291:
				goto IL_2C92;
				IL_2999:
				return this.YieldDefault(46);
				Block_296:
				return this.Yield(39, new WaitForSeconds(0.5f));
				Block_298:
				return this.Yield(45, new WaitForSeconds(0.5f));
				Block_299:
				return this.Yield(34, new WaitForSeconds(1.5f));
				Block_301:
				goto IL_2C92;
				IL_2AF0:
				return this.Yield(24, new WaitForSeconds(1f));
				Block_303:
				IL_2BA8:
				goto IL_2C92;
				Block_309:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_2C3F:
				return this.Yield(52, new WaitForSeconds(0.5f));
				IL_2C5B:
				return this.YieldDefault(53);
				IL_2C92:
				return false;
			}

			// Token: 0x06007EE3 RID: 32483 RVA: 0x01056504 File Offset: 0x01054704
			internal static bool OSJgKRpBnA6K9mDpnLRB()
			{
				return true;
			}

			// Token: 0x06007EE4 RID: 32484 RVA: 0x01056508 File Offset: 0x01054708
			internal static bool sanym2pB69ojQehFvIye()
			{
				return false;
			}

			// Token: 0x04007EA3 RID: 32419
			internal GameGui $mGameGui$38991;

			// Token: 0x04007EA4 RID: 32420
			internal StoryGui $mStoryGui$38992;

			// Token: 0x04007EA5 RID: 32421
			internal float $mStoryTimer$38993;

			// Token: 0x04007EA6 RID: 32422
			internal string $mHeroType$38994;

			// Token: 0x04007EA7 RID: 32423
			internal string $mHeroName$38995;

			// Token: 0x04007EA8 RID: 32424
			internal GameObject $mPlayer1$38996;

			// Token: 0x04007EA9 RID: 32425
			internal CharacterDataClass $mCDat2$38997;

			// Token: 0x04007EAA RID: 32426
			internal CharacterDataClass $mCDat3$38998;

			// Token: 0x04007EAB RID: 32427
			internal int $$switch$6828$38999;

			// Token: 0x04007EAC RID: 32428
			internal GameObject $mPlayer2$39000;

			// Token: 0x04007EAD RID: 32429
			internal GameObject $mPlayer3$39001;

			// Token: 0x04007EAE RID: 32430
			internal M407_CatchTheWind $self_$39002;
		}
	}

	// Token: 0x02001563 RID: 5475
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39004 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007EE5 RID: 32485 RVA: 0x0105650C File Offset: 0x0105470C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39004(M407_CatchTheWind self_)
		{
			if (121286 - 115241 != 6045)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (203904 - 126983 != 76922)
				{
					base..ctor();
					if (113965 - 114767 != -801)
					{
						this.$self_$39009 = self_;
						if (39530 - 154266 != -114735)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007EE6 RID: 32486 RVA: 0x010565A4 File Offset: 0x010547A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M407_CatchTheWind.$onDeadPlayer$39004.$(this.$self_$39009);
		}

		// Token: 0x06007EE7 RID: 32487 RVA: 0x010565B4 File Offset: 0x010547B4
		internal static bool UV2j7LpBihiQAOE0ThjR()
		{
			return true;
		}

		// Token: 0x06007EE8 RID: 32488 RVA: 0x010565B8 File Offset: 0x010547B8
		internal static bool gPb5bkpBKF9u7WqFvnrB()
		{
			return false;
		}

		// Token: 0x04007EAF RID: 32431
		internal M407_CatchTheWind $self_$39009;

		// Token: 0x02001564 RID: 5476
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007EE9 RID: 32489 RVA: 0x010565BC File Offset: 0x010547BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M407_CatchTheWind self_)
			{
				if (113245 - 166050 != -52804)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (193996 - 492335 == -298339)
					{
						base..ctor();
						if (53099 - 492383 != -439283)
						{
							this.$self_$39008 = self_;
							if (260077 - 328671 == -68594)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007EEA RID: 32490 RVA: 0x01056654 File Offset: 0x01054854
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (113295 - 267922 != -154626)
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
							if (190362 - 300081 == -109718)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_175;
							}
							if (156017 - 403387 != -247370)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (37068 - 334807 == -297738)
						{
							continue;
						}
						this.$mStoryGui$39005 = (StoryGui)this.$self_$39008.GetComponent(typeof(StoryGui));
						if (241135 - 523670 != -282535)
						{
							continue;
						}
						if (this.$mStoryGui$39005)
						{
							if (224652 - 199648 != 25004)
							{
								continue;
							}
							this.$mStoryGui$39005.close();
							if (255643 - 461250 != -205607)
							{
								continue;
							}
						}
						this.$mChangeGui$39006 = (ChangeGui)this.$self_$39008.GetComponent(typeof(ChangeGui));
						if (140902 - 344997 != -204095)
						{
							continue;
						}
						if (this.$mChangeGui$39006)
						{
							if (276317 - 280072 == -3754)
							{
								continue;
							}
							this.$mChangeGui$39006.close();
							if (42432 - 368310 == -325877)
							{
								continue;
							}
						}
						this.$mGameGui$39007 = (GameGui)this.$self_$39008.GetComponent(typeof(GameGui));
						if (137994 - 588029 == -450034)
						{
							continue;
						}
						if (this.$mGameGui$39007)
						{
							if (5158 - 287262 == -282103)
							{
								continue;
							}
							if (!this.$mGameGui$39007.enabled)
							{
								if (223767 - 332393 != -108626)
								{
									continue;
								}
								this.$mGameGui$39007.enabled = true;
								if (1429 - 100465 == -99035)
								{
									continue;
								}
							}
							this.$mGameGui$39007.openDeadMenu();
							if (28393 - 506915 == -478521)
							{
								continue;
							}
						}
						IL_175:
						this.YieldDefault(1);
						if (264046 - 103384 != 160663)
						{
							goto Block_13;
						}
						continue;
					default:
						if (46747 - 97193 != -50446)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (176764 - 341203 == -164439)
					{
						goto IL_237;
					}
				}
				Block_13:
				goto IL_2F9;
				IL_237:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007EEB RID: 32491 RVA: 0x0105696C File Offset: 0x01054B6C
			internal static bool rXWntXpBd0hpFRpgXQAr()
			{
				return true;
			}

			// Token: 0x06007EEC RID: 32492 RVA: 0x01056970 File Offset: 0x01054B70
			internal static bool JxNiBipBJ3r7ptGxmZvj()
			{
				return false;
			}

			// Token: 0x04007EB0 RID: 32432
			internal StoryGui $mStoryGui$39005;

			// Token: 0x04007EB1 RID: 32433
			internal ChangeGui $mChangeGui$39006;

			// Token: 0x04007EB2 RID: 32434
			internal GameGui $mGameGui$39007;

			// Token: 0x04007EB3 RID: 32435
			internal M407_CatchTheWind $self_$39008;
		}
	}

	// Token: 0x02001565 RID: 5477
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39010 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007EED RID: 32493 RVA: 0x01056974 File Offset: 0x01054B74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39010(Hashtable data, M407_CatchTheWind self_)
		{
			if (206069 - 434032 != -227963)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (64905 - 219841 == -154936)
				{
					base..ctor();
					if (235281 - 546932 == -311651)
					{
						this.$data$39013 = data;
						if (228038 - 136920 == 91118)
						{
							this.$self_$39014 = self_;
							if (49840 - 204332 != -154491)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007EEE RID: 32494 RVA: 0x01056A30 File Offset: 0x01054C30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M407_CatchTheWind.$onGameComplete$39010.$(this.$data$39013, this.$self_$39014);
		}

		// Token: 0x06007EEF RID: 32495 RVA: 0x01056A44 File Offset: 0x01054C44
		internal static bool wl6oMdpBDBKcX3RvPsPL()
		{
			return true;
		}

		// Token: 0x06007EF0 RID: 32496 RVA: 0x01056A48 File Offset: 0x01054C48
		internal static bool rtm8lspBvnQn3bW8PmSs()
		{
			return false;
		}

		// Token: 0x04007EB4 RID: 32436
		internal Hashtable $data$39013;

		// Token: 0x04007EB5 RID: 32437
		internal M407_CatchTheWind $self_$39014;

		// Token: 0x02001566 RID: 5478
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007EF1 RID: 32497 RVA: 0x01056A4C File Offset: 0x01054C4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M407_CatchTheWind self_)
			{
				if (135774 - 314961 != -179186)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (225643 - 190339 != 35305)
					{
						base..ctor();
						if (111495 - 589018 == -477523)
						{
							this.$data$39011 = data;
							if (85985 - 119614 != -33628)
							{
								this.$self_$39012 = self_;
								if (258716 - 248946 != 9771)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007EF2 RID: 32498 RVA: 0x01056B08 File Offset: 0x01054D08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (44884 - 126768 != -81883)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_18D;
					case 2:
						this.$self_$39012.SendMessage("fadeOut");
						if (164162 - 431243 == -267080)
						{
							continue;
						}
						this.$self_$39012.StartCoroutine_Auto(this.$self_$39012.ReturnToTown());
						if (86248 - 250919 == -164670)
						{
							continue;
						}
						this.YieldDefault(1);
						if (176128 - 54267 != 121862)
						{
							goto Block_3;
						}
						continue;
					default:
						if (288324 - 432590 != -144266)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Event Complete:" + this.$data$39011[31]);
					if (237506 - 278343 != -40836)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (284750 - 210603 != 74148)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (45567 - 116669 != -71101)
							{
								this.$self_$39012.wU1cAcSKoeR = Time.time;
								if (79463 - 280833 == -201370)
								{
									goto IL_97;
								}
							}
						}
					}
				}
				Block_3:
				goto IL_18D;
				IL_97:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_18D:
				return false;
			}

			// Token: 0x06007EF3 RID: 32499 RVA: 0x01056CB4 File Offset: 0x01054EB4
			internal static bool C80cAhpBRwstQral6Cbb()
			{
				return true;
			}

			// Token: 0x06007EF4 RID: 32500 RVA: 0x01056CB8 File Offset: 0x01054EB8
			internal static bool gx4eADpBwUjk1KlOZomD()
			{
				return false;
			}

			// Token: 0x04007EB6 RID: 32438
			internal Hashtable $data$39011;

			// Token: 0x04007EB7 RID: 32439
			internal M407_CatchTheWind $self_$39012;
		}
	}

	// Token: 0x02001567 RID: 5479
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39015 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007EF5 RID: 32501 RVA: 0x01056CBC File Offset: 0x01054EBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39015(M407_CatchTheWind self_)
		{
			if (212610 - 36227 != 176384)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (80698 - 361819 == -281121)
				{
					base..ctor();
					if (167644 - 103461 != 64184)
					{
						this.$self_$39019 = self_;
						if (50322 - 504440 == -454118)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007EF6 RID: 32502 RVA: 0x01056D54 File Offset: 0x01054F54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M407_CatchTheWind.$ReturnToTown$39015.$(this.$self_$39019);
		}

		// Token: 0x06007EF7 RID: 32503 RVA: 0x01056D64 File Offset: 0x01054F64
		internal static bool rVy707pBqFDby1W9ZGX1()
		{
			return true;
		}

		// Token: 0x06007EF8 RID: 32504 RVA: 0x01056D68 File Offset: 0x01054F68
		internal static bool NYk30ZpB7rTnVwWrK461()
		{
			return false;
		}

		// Token: 0x04007EB8 RID: 32440
		internal M407_CatchTheWind $self_$39019;

		// Token: 0x02001568 RID: 5480
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007EF9 RID: 32505 RVA: 0x01056D6C File Offset: 0x01054F6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M407_CatchTheWind self_)
			{
				if (200393 - 47242 != 153151)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (250976 - 285664 == -34688)
					{
						base..ctor();
						if (57247 - 421239 != -363991)
						{
							this.$self_$39018 = self_;
							if (198343 - 203686 == -5343)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007EFA RID: 32506 RVA: 0x01056E04 File Offset: 0x01055004
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (269098 - 403940 != -134842)
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
						this.$self_$39018.LeaveGame();
						if (173793 - 300346 == -126552)
						{
							continue;
						}
						this.YieldDefault(1);
						if (162422 - 268374 != -105951)
						{
							goto Block_3;
						}
						continue;
					default:
						if (189322 - 172753 == 16570)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (120556 - 426926 != -306369)
					{
						Game.mStateTime = Time.time;
						if (180576 - 592826 != -412249)
						{
							this.$$switch$6830$39016 = PlayerData.SaveGuild;
							if (98937 - 273429 != -174491)
							{
								if (this.$$switch$6830$39016 == 1)
								{
									if (226971 - 593987 == -367015)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (255547 - 260752 != -5205)
									{
										continue;
									}
								}
								else if (this.$$switch$6830$39016 == 2)
								{
									if (58309 - 230494 != -172185)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (132277 - 183612 == -51334)
									{
										continue;
									}
								}
								else if (this.$$switch$6830$39016 == 3)
								{
									if (142127 - 26154 != 115973)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (205276 - 351251 != -145975)
									{
										continue;
									}
								}
								else if (this.$$switch$6830$39016 == 4)
								{
									if (79870 - 416132 != -336262)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (22089 - 53079 != -30990)
									{
										continue;
									}
								}
								else if (this.$$switch$6830$39016 == 5)
								{
									if (169776 - 186032 != -16256)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (22244 - 305059 == -282814)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (158330 - 186619 == -28288)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (217716 - 526206 != -308490)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (241245 - 118899 == 122347)
									{
										continue;
									}
								}
								this.$mGameGui$39017 = (GameGui)this.$self_$39018.GetComponent(typeof(GameGui));
								if (115207 - 173258 == -58051)
								{
									if (this.$mGameGui$39017)
									{
										if (260989 - 453233 != -192244)
										{
											continue;
										}
										this.$mGameGui$39017.close();
										if (222336 - 494102 != -271766)
										{
											continue;
										}
									}
									this.$self_$39018.SendMessage("fadeOut");
									if (108586 - 116532 != -7945)
									{
										goto Block_29;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_3AD;
				Block_29:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06007EFB RID: 32507 RVA: 0x010571D0 File Offset: 0x010553D0
			internal static bool I1B1ZhpBP8KR7Do7MDlT()
			{
				return true;
			}

			// Token: 0x06007EFC RID: 32508 RVA: 0x010571D4 File Offset: 0x010553D4
			internal static bool iTW84WpB0BvR0IRcIPDP()
			{
				return false;
			}

			// Token: 0x04007EB9 RID: 32441
			internal int $$switch$6830$39016;

			// Token: 0x04007EBA RID: 32442
			internal GameGui $mGameGui$39017;

			// Token: 0x04007EBB RID: 32443
			internal M407_CatchTheWind $self_$39018;
		}
	}

	// Token: 0x02001569 RID: 5481
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39020 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007EFD RID: 32509 RVA: 0x010571D8 File Offset: 0x010553D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39020(M407_CatchTheWind self_)
		{
			if (272170 - 540235 != -268065)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (48237 - 462809 == -414572)
				{
					base..ctor();
					if (123232 - 28139 != 95094)
					{
						this.$self_$39023 = self_;
						if (138227 - 209846 != -71618)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007EFE RID: 32510 RVA: 0x01057270 File Offset: 0x01055470
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M407_CatchTheWind.$ReturnToGuild$39020.$(this.$self_$39023);
		}

		// Token: 0x06007EFF RID: 32511 RVA: 0x01057280 File Offset: 0x01055480
		internal static bool frQ3uNpBbIQxX7Z4ShyS()
		{
			return true;
		}

		// Token: 0x06007F00 RID: 32512 RVA: 0x01057284 File Offset: 0x01055484
		internal static bool Pi7u9lpBuU5uO3Nx4RLa()
		{
			return false;
		}

		// Token: 0x04007EBC RID: 32444
		internal M407_CatchTheWind $self_$39023;

		// Token: 0x0200156A RID: 5482
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007F01 RID: 32513 RVA: 0x01057288 File Offset: 0x01055488
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M407_CatchTheWind self_)
			{
				if (173112 - 63715 != 109397)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (73925 - 251108 != -177182)
					{
						base..ctor();
						if (268311 - 266793 != 1519)
						{
							this.$self_$39022 = self_;
							if (194637 - 559145 != -364507)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007F02 RID: 32514 RVA: 0x01057320 File Offset: 0x01055520
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (10642 - 469038 != -458396)
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
						this.$self_$39022.LeaveGame();
						if (35127 - 368426 != -333299)
						{
							continue;
						}
						this.YieldDefault(1);
						if (12487 - 512062 != -499574)
						{
							goto Block_8;
						}
						continue;
					default:
						if (87191 - 535654 != -448463)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (238358 - 439442 == -201084)
					{
						Game.mStateTime = Time.time;
						if (48803 - 487656 != -438852)
						{
							Game.mNextGameCode = 31;
							if (240188 - 480063 == -239875)
							{
								this.$mGameGui$39021 = (GameGui)this.$self_$39022.GetComponent(typeof(GameGui));
								if (37057 - 293366 == -256309)
								{
									if (this.$mGameGui$39021)
									{
										if (62919 - 492651 == -429731)
										{
											continue;
										}
										this.$mGameGui$39021.close();
										if (114351 - 494159 != -379808)
										{
											continue;
										}
									}
									this.$self_$39022.SendMessage("fadeOut");
									if (78041 - 300308 == -222267)
									{
										goto IL_13A;
									}
								}
							}
						}
					}
				}
				Block_8:
				goto IL_1BD;
				IL_13A:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06007F03 RID: 32515 RVA: 0x010574FC File Offset: 0x010556FC
			internal static bool anfs7ApBIWOrXlAFO9p0()
			{
				return true;
			}

			// Token: 0x06007F04 RID: 32516 RVA: 0x01057500 File Offset: 0x01055700
			internal static bool axewnQpBBVQdFSyuqvHm()
			{
				return false;
			}

			// Token: 0x04007EBD RID: 32445
			internal GameGui $mGameGui$39021;

			// Token: 0x04007EBE RID: 32446
			internal M407_CatchTheWind $self_$39022;
		}
	}

	// Token: 0x0200156B RID: 5483
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39024 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007F05 RID: 32517 RVA: 0x01057504 File Offset: 0x01055704
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39024(M407_CatchTheWind self_)
		{
			if (180206 - 428955 != -248748)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (148507 - 493353 != -344845)
				{
					base..ctor();
					if (251197 - 243010 != 8188)
					{
						this.$self_$39028 = self_;
						if (189366 - 378166 != -188799)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007F06 RID: 32518 RVA: 0x0105759C File Offset: 0x0105579C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M407_CatchTheWind.$ReturnToCamp$39024.$(this.$self_$39028);
		}

		// Token: 0x06007F07 RID: 32519 RVA: 0x010575AC File Offset: 0x010557AC
		internal static bool p492SspBegdLTLSm6gDW()
		{
			return true;
		}

		// Token: 0x06007F08 RID: 32520 RVA: 0x010575B0 File Offset: 0x010557B0
		internal static bool M8MS5hpBrDJNS6oGiY1S()
		{
			return false;
		}

		// Token: 0x04007EBF RID: 32447
		internal M407_CatchTheWind $self_$39028;

		// Token: 0x0200156C RID: 5484
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007F09 RID: 32521 RVA: 0x010575B4 File Offset: 0x010557B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M407_CatchTheWind self_)
			{
				if (9803 - 549188 != -539384)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (283709 - 56180 == 227529)
					{
						base..ctor();
						if (150371 - 433268 != -282896)
						{
							this.$self_$39027 = self_;
							if (83452 - 187366 != -103913)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007F0A RID: 32522 RVA: 0x0105764C File Offset: 0x0105584C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (247045 - 180619 != 66426)
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
						this.$self_$39027.LeaveGame();
						if (134033 - 96990 != 37043)
						{
							continue;
						}
						this.YieldDefault(1);
						if (19758 - 232851 != -213092)
						{
							goto Block_15;
						}
						continue;
					default:
						if (15173 - 378468 == -363294)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (118245 - 592248 != -474002)
					{
						Game.mStateTime = Time.time;
						if (137655 - 96061 == 41594)
						{
							this.$$switch$6832$39025 = PlayerData.SaveGuild;
							if (282162 - 141802 != 140361)
							{
								if (this.$$switch$6832$39025 == 1)
								{
									if (253896 - 46492 != 207404)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (83135 - 518755 == -435619)
									{
										continue;
									}
								}
								else if (this.$$switch$6832$39025 == 2)
								{
									if (616 - 482305 == -481688)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (31995 - 112287 != -80292)
									{
										continue;
									}
								}
								else if (this.$$switch$6832$39025 == 3)
								{
									if (170965 - 542462 != -371497)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (278161 - 216723 != 61438)
									{
										continue;
									}
								}
								else if (this.$$switch$6832$39025 == 4)
								{
									if (6095 - 9334 == -3238)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (64696 - 408795 != -344099)
									{
										continue;
									}
								}
								else if (this.$$switch$6832$39025 == 5)
								{
									if (50990 - 425966 == -374975)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (198122 - 347745 == -149622)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (255050 - 567558 != -312508)
									{
										continue;
									}
								}
								this.$mGameGui$39026 = (GameGui)this.$self_$39027.GetComponent(typeof(GameGui));
								if (180568 - 242578 == -62010)
								{
									if (this.$mGameGui$39026)
									{
										if (52481 - 59209 != -6728)
										{
											continue;
										}
										this.$mGameGui$39026.close();
										if (263347 - 326480 == -63132)
										{
											continue;
										}
									}
									this.$self_$39027.SendMessage("fadeOut");
									if (26264 - 146920 == -120656)
									{
										goto IL_2E0;
									}
								}
							}
						}
					}
				}
				Block_15:
				goto IL_363;
				IL_2E0:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06007F0B RID: 32523 RVA: 0x010579D0 File Offset: 0x01055BD0
			internal static bool PZOvFApBjj0RRDs0XmJT()
			{
				return true;
			}

			// Token: 0x06007F0C RID: 32524 RVA: 0x010579D4 File Offset: 0x01055BD4
			internal static bool axSslVpBhkLsEss9kRga()
			{
				return false;
			}

			// Token: 0x04007EC0 RID: 32448
			internal int $$switch$6832$39025;

			// Token: 0x04007EC1 RID: 32449
			internal GameGui $mGameGui$39026;

			// Token: 0x04007EC2 RID: 32450
			internal M407_CatchTheWind $self_$39027;
		}
	}
}
