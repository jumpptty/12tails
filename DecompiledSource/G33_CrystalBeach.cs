using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x0200122A RID: 4650
[Serializable]
public class G33_CrystalBeach : MonoBehaviour
{
	// Token: 0x06006B07 RID: 27399 RVA: 0x00F18B70 File Offset: 0x00F16D70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public G33_CrystalBeach()
	{
		if (62946 - 410891 != -347945)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (18856 - 342400 != -323543)
			{
				base..ctor();
				if (105020 - 571066 == -466046)
				{
					this.DIncSDjEO8U = "none";
					if (134241 - 512955 == -378714)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006B08 RID: 27400 RVA: 0x00F18C0C File Offset: 0x00F16E0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (35795 - 289744 != -253948)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (42428 - 241694 == -199266)
			{
				Game.mStateTime = Time.time;
				if (188243 - 76701 == 111542)
				{
					if (Chat.Initialized)
					{
						if (16307 - 445595 != -429288)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (21406 - 179401 == -157994)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (236118 - 581560 == -345441)
						{
							continue;
						}
					}
					this.vRVcS8Aromt = (Texture)Resources.Load("GameGui/Title/stage_beach", typeof(Texture));
					if (38370 - 33778 == 4592)
					{
						if (this.vRVcS8Aromt)
						{
							break;
						}
						if (176540 - 163727 == 12813)
						{
							Debug.LogError("Cannot find start title");
							if (63633 - 336299 != -272665)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B09 RID: 27401 RVA: 0x00F18D7C File Offset: 0x00F16F7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (110963 - 449445 != -338482)
		{
		}
		for (;;)
		{
			Time.timeScale = 1f;
			if (266224 - 149084 == 117140)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (76176 - 486264 == -410088)
				{
					if (PhotonClient.IsInitialized())
					{
						if (59330 - 289145 != -229814)
						{
							Game.mLastGameCode = Game.mGameCode;
							if (277077 - 505456 != -228378)
							{
								Game.mGameCode = 33;
								if (286603 - 367501 != -80897)
								{
									Game.mGameType = 2;
									if (48066 - 203242 != -155175)
									{
										Game.mGameTime = Time.time;
										if (285851 - 585967 == -300116)
										{
											Game.mGameScore = 0;
											if (210062 - 94809 != 115254)
											{
												Game.mGameMana = 0;
												if (166213 - 134889 == 31324)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (236889 - 544041 == -307152)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (242551 - 109113 == 133438)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (295633 - 526293 != -230659)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (41085 - 560125 == -519040)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (182672 - 458916 != -276243)
																	{
																		this.fBOcS0agbIe = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (258983 - 178885 == 80098)
																		{
																			this.qfMcSBo9SaH = PhotonClient.Connection;
																			if (3743 - 76564 == -72821)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (33148 - 342433 == -309285)
																				{
																					this.LoadTown();
																					if (63040 - 230138 == -167098)
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
					else
					{
						Debug.Log("Not Connected");
						if (227023 - 412431 != -185407)
						{
							this.enabled = false;
							if (271468 - 580699 != -309230)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B0A RID: 27402 RVA: 0x00F190AC File Offset: 0x00F172AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (278863 - 330089 != -51226)
		{
		}
		for (;;)
		{
			if (this.qfMcSBo9SaH == null)
			{
				if (146913 - 84551 != 62363)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (147495 - 558163 != -410667)
				{
					if (mGameState != eGameState.Start)
					{
						if (667 - 364806 == -364138)
						{
							continue;
						}
						if (mGameState == eGameState.Normal)
						{
							if (276172 - 235414 == 40759)
							{
								continue;
							}
						}
						else
						{
							if (mGameState != eGameState.Ended)
							{
								break;
							}
							if (75069 - 20647 != 54422)
							{
								continue;
							}
							this.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, Time.time - Game.mStateTime);
							if (80184 - 293615 != -213431)
							{
								continue;
							}
							break;
						}
					}
					if (Game.music != 0)
					{
						if (252733 - 246309 != 6424)
						{
							continue;
						}
						if (!this.audio.isPlaying)
						{
							if (97483 - 490169 != -392686)
							{
								continue;
							}
							this.audio.Play();
							if (174592 - 440906 == -266313)
							{
								continue;
							}
						}
					}
					if (Time.time - Game.mGameTime < (float)2)
					{
						if (117712 - 43883 != 73830)
						{
							this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
							if (263422 - 42099 != 221324)
							{
								break;
							}
						}
					}
					else
					{
						this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
						if (279148 - 155823 == 123325)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B0B RID: 27403 RVA: 0x00F19304 File Offset: 0x00F17504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (146575 - 293571 != -146995)
		{
		}
		for (;;)
		{
			if (!this.vRVcS8Aromt)
			{
				if (293000 - 58426 == 234574)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Start)
			{
				if (51030 - 544702 != -493671)
				{
					break;
				}
			}
			else
			{
				if (Time.time - Game.mStateTime <= 0.5f)
				{
					break;
				}
				if (171285 - 537362 == -366077)
				{
					if (Time.time - Game.mStateTime >= (float)3)
					{
						break;
					}
					if (84852 - 348920 != -264067)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (199317 - 375781 != -176463)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (162564 - 329386 == -166822)
							{
								GUI.depth = 1;
								if (215085 - 585989 == -370904)
								{
									float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4(0.7f, 0.8f, (float)1, 0.4f));
									if (285982 - 42709 != 243274)
									{
										Color color = GUI.color;
										if (174450 - 106858 == 67592)
										{
											float num2 = color.a = smoothRatioOverTime;
											if (72353 - 156979 == -84626)
											{
												if (241700 - 69951 == 171749)
												{
													GUI.color = color;
													if (51655 - 534123 == -482468)
													{
														if (70909 - 417424 != -346514)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)256, (float)416, (float)512, (float)128), this.vRVcS8Aromt);
															if (190326 - 328735 != -138408)
															{
																float a = 1f;
																if (65236 - 508705 == -443469)
																{
																	Color color2 = GUI.color;
																	if (135284 - 66058 != 69227)
																	{
																		float num3 = color2.a = a;
																		if (57421 - 471623 == -414202)
																		{
																			if (277638 - 81197 == 196441)
																			{
																				GUI.color = color2;
																				if (135896 - 467687 != -331790)
																				{
																					if (284397 - 132029 == 152368)
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

	// Token: 0x06006B0C RID: 27404 RVA: 0x00F19684 File Offset: 0x00F17884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTown()
	{
		if (59212 - 564902 != -505690)
		{
		}
		for (;;)
		{
			Debug.Log("Loading Town ");
			if (285606 - 582983 == -297377)
			{
				Hashtable customOpParameters = new Hashtable();
				if (226604 - 329793 != -103188)
				{
					this.qfMcSBo9SaH.OpCustom(43, customOpParameters, true);
					if (118189 - 201804 == -83615)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006B0D RID: 27405 RVA: 0x00F1972C File Offset: 0x00F1792C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadTown(Hashtable data)
	{
		if (47491 - 377645 != -330154)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadTown ");
			if (41369 - 145464 == -104095)
			{
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (76875 - 19682 != 57193)
					{
						continue;
					}
					Chat.SubmitChat("none", "You have joined " + data[31], eChatType.system, eChatMode.system);
					if (173671 - 56760 != 116911)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (140581 - 290345 == -149763)
					{
						continue;
					}
					object obj2;
					object obj = obj2 = data[32];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					Chat.newAnnouncement((string)obj2);
					if (132603 - 418876 != -286273)
					{
						continue;
					}
				}
				if (Game.mLastGameCode != 0)
				{
					if (278647 - 375599 != -96952)
					{
						continue;
					}
					if (Game.mLastGameCode < 100)
					{
						if (5347 - 496774 != -491427)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.CrystalBeachStartEvent());
						if (146366 - 584325 != -437958)
						{
							break;
						}
						continue;
					}
				}
				GameObject gameObject = GameObject.Find("StartPoint1");
				if (20517 - 222887 == -202370)
				{
					GameObject gameObject2 = GameObject.Find("StartCamera1");
					if (247504 - 495992 == -248488)
					{
						if (gameObject2)
						{
							if (268035 - 353090 == -85054)
							{
								continue;
							}
							this.transform.position = gameObject2.transform.position;
							if (101681 - 290528 != -188847)
							{
								continue;
							}
							this.transform.rotation = gameObject2.transform.rotation;
							if (8239 - 275367 != -267128)
							{
								continue;
							}
						}
						if (gameObject)
						{
							if (84586 - 265626 == -181040)
							{
								this.CreatePlayer(CharacterData.current.CID, gameObject.transform.position, gameObject.transform.forward);
								if (93533 - 277076 == -183543)
								{
									break;
								}
							}
						}
						else
						{
							Debug.Log("Error: Startpoint not found");
							if (196583 - 255935 == -59352)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B0E RID: 27406 RVA: 0x00F19A48 File Offset: 0x00F17C48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator CrystalBeachStartEvent()
	{
		return new G33_CrystalBeach.$CrystalBeachStartEvent$36527(this).GetEnumerator();
	}

	// Token: 0x06006B0F RID: 27407 RVA: 0x00F19A58 File Offset: 0x00F17C58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new G33_CrystalBeach.$TalkToRedPanda$36535(this).GetEnumerator();
	}

	// Token: 0x06006B10 RID: 27408 RVA: 0x00F19A68 File Offset: 0x00F17C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToGuibo()
	{
		return new G33_CrystalBeach.$TalkToGuibo$36544(this).GetEnumerator();
	}

	// Token: 0x06006B11 RID: 27409 RVA: 0x00F19A78 File Offset: 0x00F17C78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToHumpback()
	{
		if (80638 - 202697 != -122058)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (55687 - 51566 == 4121)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (113959 - 243472 == -129513)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (52452 - 438759 != -386306)
					{
						if (gameGui)
						{
							if (60336 - 31482 != 28854)
							{
								continue;
							}
							gameGui.close();
							if (9850 - 519235 == -509384)
							{
								continue;
							}
						}
						CompoundGui compoundGui = (CompoundGui)this.GetComponent(typeof(CompoundGui));
						if (95980 - 242848 == -146868)
						{
							compoundGui.mType = eCompoundType.Humpback;
							if (142871 - 43150 == 99721)
							{
								compoundGui.enabled = true;
								if (196222 - 326723 == -130501)
								{
									GameObject gameObject = GameObject.Find("Humpback");
									if (147310 - 188487 == -41177)
									{
										if (gameObject)
										{
											if (208397 - 247879 == -39482)
											{
												Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
												if (87978 - 194666 != -106687)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Cannot find Humpback");
											if (222048 - 261978 != -39929)
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

	// Token: 0x06006B12 RID: 27410 RVA: 0x00F19C90 File Offset: 0x00F17E90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToKoala()
	{
		if (177096 - 403660 != -226564)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (291002 - 355876 != -64873)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (143794 - 39773 == 104021)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (124996 - 418993 != -293996)
					{
						if (gameGui)
						{
							if (141725 - 216453 == -74727)
							{
								continue;
							}
							gameGui.close();
							if (129524 - 351328 != -221804)
							{
								continue;
							}
						}
						ShopGui shopGui = (ShopGui)this.GetComponent(typeof(ShopGui));
						if (243346 - 360168 != -116821)
						{
							shopGui.mType = eShopType.Koala;
							if (283758 - 5951 != 277808)
							{
								shopGui.enabled = true;
								if (244663 - 8112 == 236551)
								{
									GameObject mPlayer = Game.mPlayer;
									if (117110 - 335350 != -218239)
									{
										GameObject gameObject = GameObject.Find("Koala");
										if (188735 - 436170 != -247434)
										{
											if (!gameObject)
											{
												break;
											}
											if (281236 - 76175 == 205061)
											{
												if (!mPlayer)
												{
													break;
												}
												if (150702 - 315052 != -164349)
												{
													mPlayer.SendMessage("turnToPos", gameObject.transform.position);
													if (266423 - 396304 == -129881)
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

	// Token: 0x06006B13 RID: 27411 RVA: 0x00F19EC0 File Offset: 0x00F180C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToCrocodile()
	{
		if (173771 - 433278 != -259507)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (169555 - 155555 == 14000)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (90501 - 382783 != -292281)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (89570 - 493683 != -404112)
					{
						gameGui.close();
						if (43936 - 72526 == -28590)
						{
							CompoundGui compoundGui = (CompoundGui)this.GetComponent(typeof(CompoundGui));
							if (219010 - 260775 == -41765)
							{
								compoundGui.mType = eCompoundType.Crocodile;
								if (218251 - 66184 == 152067)
								{
									compoundGui.enabled = true;
									if (70492 - 253046 != -182553)
									{
										GameObject gameObject = GameObject.Find("Crocodile");
										if (43034 - 80287 == -37253)
										{
											if (gameObject)
											{
												if (69948 - 502943 == -432995)
												{
													Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
													if (40757 - 362094 == -321337)
													{
														break;
													}
												}
											}
											else
											{
												Debug.LogError("Cannot find Crocodile");
												if (44698 - 135219 == -90521)
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

	// Token: 0x06006B14 RID: 27412 RVA: 0x00F1A0B0 File Offset: 0x00F182B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToPilotMole(int n)
	{
		if (180146 - 330987 != -150841)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (15586 - 207954 == -192368)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (108728 - 128166 != -19437)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (96146 - 184546 == -88400)
					{
						if (gameGui)
						{
							if (144725 - 269345 == -124619)
							{
								continue;
							}
							gameGui.close();
							if (158142 - 3650 != 154492)
							{
								continue;
							}
						}
						GameObject gameObject = GameObject.Find("PilotMole");
						if (214323 - 388758 != -174434)
						{
							if (gameObject)
							{
								if (168543 - 85188 != 83355)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (240006 - 500316 == -260309)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find PilotMole");
								if (60425 - 337417 == -276991)
								{
									continue;
								}
							}
							TransportGui transportGui = (TransportGui)this.GetComponent(typeof(TransportGui));
							if (11632 - 439055 == -427423)
							{
								transportGui.enabled = true;
								if (131834 - 38730 == 93104)
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

	// Token: 0x06006B15 RID: 27413 RVA: 0x00F1A2A4 File Offset: 0x00F184A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (146845 - 533507 != -386661)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (34009 - 55241 == -21232)
			{
				CharacterControl characterControl = null;
				if (73930 - 22469 == 51461)
				{
					if (mPlayer)
					{
						if (40928 - 411106 != -370178)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (17248 - 177264 == -160015)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (252264 - 239580 == 12684)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (205791 - 210576 != -4784)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (212392 - 463677 == -251285)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (1319 - 212990 == -211670)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (61011 - 124033 == -63021)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (87531 - 590644 == -503112)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (134256 - 422923 != -288667)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (258634 - 96630 != 162005)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (166880 - 484178 != -317297)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (70076 - 321808 != -251731)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (184374 - 463597 == -279223)
								{
									if (!changeGui)
									{
										break;
									}
									if (145799 - 173255 != -27455)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (30668 - 123497 != -92829)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (33186 - 211257 == -178070)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (228802 - 189249 == 39553)
										{
											gameGui.close();
											if (107499 - 257467 != -149967)
											{
												changeGui.enabled = true;
												if (109877 - 515068 == -405191)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (127526 - 96479 != 31048)
													{
														if (!gameObject)
														{
															break;
														}
														if (48433 - 502951 == -454518)
														{
															if (!mPlayer)
															{
																break;
															}
															if (2852 - 334434 == -331582)
															{
																Debug.Log("UseLifeAltar");
																if (212757 - 483131 == -270374)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (93745 - 352923 == -259178)
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

	// Token: 0x06006B16 RID: 27414 RVA: 0x00F1A704 File Offset: 0x00F18904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseMailBox(object mVar)
	{
		if (214486 - 78420 != 136067)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (170176 - 70160 == 100016)
				{
					break;
				}
			}
			else
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (29007 - 121882 == -92875)
				{
					MailBoxGui mailBoxGui = (MailBoxGui)this.GetComponent(typeof(MailBoxGui));
					if (12326 - 47195 != -34868)
					{
						if (!gameGui)
						{
							break;
						}
						if (174380 - 432470 != -258089)
						{
							if (!mailBoxGui)
							{
								break;
							}
							if (294741 - 73781 == 220960)
							{
								Game.mGameState = eGameState.Hold;
								if (219720 - 213372 == 6348)
								{
									gameGui.close();
									if (178149 - 505428 == -327279)
									{
										mailBoxGui.enabled = true;
										if (29619 - 402072 == -372453)
										{
											GameObject mPlayer = Game.mPlayer;
											if (36953 - 122549 != -85595)
											{
												GameObject gameObject = GameObject.Find("MailBox");
												if (78999 - 58461 == 20538)
												{
													if (!gameObject)
													{
														break;
													}
													if (188458 - 411083 != -222624)
													{
														if (!mPlayer)
														{
															break;
														}
														if (115426 - 171511 != -56084)
														{
															mPlayer.SendMessage("turnToPos", gameObject.transform.position);
															if (173229 - 20744 == 152485)
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

	// Token: 0x06006B17 RID: 27415 RVA: 0x00F1A938 File Offset: 0x00F18B38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseStorageBox(object mVar)
	{
		return new G33_CrystalBeach.$UseStorageBox$36553(this).GetEnumerator();
	}

	// Token: 0x06006B18 RID: 27416 RVA: 0x00F1A948 File Offset: 0x00F18B48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseMessageBoard(object mVar)
	{
		return new G33_CrystalBeach.$UseMessageBoard$36560(this).GetEnumerator();
	}

	// Token: 0x06006B19 RID: 27417 RVA: 0x00F1A958 File Offset: 0x00F18B58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(object mVar)
	{
		return new G33_CrystalBeach.$UseSignPost$36567(this).GetEnumerator();
	}

	// Token: 0x06006B1A RID: 27418 RVA: 0x00F1A968 File Offset: 0x00F18B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseTrashBin(object mVar)
	{
		return new G33_CrystalBeach.$UseTrashBin$36570(this).GetEnumerator();
	}

	// Token: 0x06006B1B RID: 27419 RVA: 0x00F1A978 File Offset: 0x00F18B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetTrash()
	{
		if (66086 - 311588 != -245501)
		{
		}
		for (;;)
		{
			Debug.Log("GetTrash");
			if (142236 - 241502 != -99265)
			{
				this.kmKcSmi3Pfq = false;
				if (100628 - 495689 != -395060)
				{
					this.DIncSDjEO8U = "none";
					if (101520 - 578618 == -477098)
					{
						Hashtable customOpParameters = new Hashtable();
						if (215786 - 532848 == -317062)
						{
							this.qfMcSBo9SaH.OpCustom(224, customOpParameters, true);
							if (32713 - 434858 != -402144)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B1C RID: 27420 RVA: 0x00F1AA68 File Offset: 0x00F18C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGetTrash(Hashtable data)
	{
		if (92895 - 499497 != -406601)
		{
		}
		while (RuntimeServices.EqualityOperator(data[31], 1))
		{
			if (183513 - 583417 == -399904)
			{
				this.kmKcSmi3Pfq = true;
				if (112319 - 25012 == 87307)
				{
					object obj2;
					object obj = obj2 = data[32];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					this.DIncSDjEO8U = ItemData.getName((string)obj2);
					if (210323 - 95471 == 114852)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006B1D RID: 27421 RVA: 0x00F1AB4C File Offset: 0x00F18D4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, Vector3 pos, Vector3 dir)
	{
		if (169972 - 333099 != -163127)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (222888 - 283756 != -60867)
			{
				hashtable.Add(71, CID);
				if (96046 - 289355 != -193308)
				{
					hashtable.Add(75, PhotonClient.cInt16(1));
					if (181884 - 242856 == -60972)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (150382 - 418690 == -268308)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (227602 - 524199 != -296596)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (248649 - 500629 != -251979)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (252506 - 264954 != -12447)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (263285 - 562573 != -299287)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (96417 - 560003 == -463586)
											{
												this.qfMcSBo9SaH.OpCustom(61, hashtable, true);
												if (184114 - 582963 != -398848)
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

	// Token: 0x06006B1E RID: 27422 RVA: 0x00F1ADD8 File Offset: 0x00F18FD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePlayer(Hashtable data)
	{
		return new G33_CrystalBeach.$onCreatePlayer$36575(data, this).GetEnumerator();
	}

	// Token: 0x06006B1F RID: 27423 RVA: 0x00F1ADE8 File Offset: 0x00F18FE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (92806 - 339010 != -246203)
		{
		}
		for (;;)
		{
			IL_109:
			GameObject gameObject = Game.createPeer(data);
			if (164604 - 180722 == -16118)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (89212 - 267823 == -178611)
				{
					int i = 0;
					if (92089 - 12002 == 80087)
					{
						GameObject[] array2 = array;
						if (136457 - 339441 != -202983)
						{
							int length = array2.Length;
							if (181478 - 232660 != -51181)
							{
								while (i < length)
								{
									if (gameObject != array2[i])
									{
										if (140464 - 22032 == 118433)
										{
											goto IL_109;
										}
										Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
										if (269928 - 279545 == -9616)
										{
											goto IL_109;
										}
									}
									i++;
									if (188244 - 563710 == -375465)
									{
										goto IL_109;
									}
								}
								if (299405 - 174475 == 124930)
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

	// Token: 0x06006B20 RID: 27424 RVA: 0x00F1AF60 File Offset: 0x00F19160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPlayer()
	{
		Game.mPlayerID = 0;
	}

	// Token: 0x06006B21 RID: 27425 RVA: 0x00F1AF68 File Offset: 0x00F19168
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
	}

	// Token: 0x06006B22 RID: 27426 RVA: 0x00F1AF6C File Offset: 0x00F1916C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (13623 - 519568 != -505945)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (167351 - 310749 == -143398)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (89152 - 430297 != -341144)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (57406 - 527202 == -469796)
					{
						Hashtable hashtable = new Hashtable();
						if (95451 - 309668 == -214217)
						{
							hashtable.Add(43, PlayerData.UID);
							if (115523 - 410332 == -294809)
							{
								hashtable.Add(71, nCID);
								if (61847 - 573652 != -511804)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (12786 - 19253 == -6467)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (155253 - 463532 == -308279)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (205817 - 580537 != -374719)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (68843 - 373404 != -304560)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (197792 - 234998 == -37206)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (156263 - 259710 != -103446)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (260645 - 365377 != -104731)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (158709 - 35298 == 123411)
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

	// Token: 0x06006B23 RID: 27427 RVA: 0x00F1B28C File Offset: 0x00F1948C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onChangePlayer(Hashtable data)
	{
		if (129158 - 534123 != -404965)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Destroy(Game.mPlayer);
			if (275603 - 144917 != 130687)
			{
				this.SendMessage("onCreatePlayer", data);
				if (60399 - 398493 == -338094)
				{
					ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
					if (145769 - 64553 != 81217)
					{
						if (!changeGui.enabled)
						{
							break;
						}
						if (168324 - 558938 == -390614)
						{
							changeGui.close();
							if (255169 - 151131 == 104038)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B24 RID: 27428 RVA: 0x00F1B384 File Offset: 0x00F19584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(GameObject nMount)
	{
		if (116991 - 425938 != -308947)
		{
		}
		for (;;)
		{
			IL_5A:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
			if (281749 - 139260 != 142490)
			{
				int i = 0;
				if (135702 - 550009 != -414306)
				{
					GameObject[] array2 = array;
					if (112444 - 170178 == -57734)
					{
						int length = array2.Length;
						if (163511 - 175853 == -12342)
						{
							while (i < length)
							{
								if (nMount != array2[i])
								{
									if (15657 - 440055 != -424398)
									{
										goto IL_5A;
									}
									Physics.IgnoreCollision(nMount.collider, array2[i].collider, true);
									if (110536 - 413842 != -303306)
									{
										goto IL_5A;
									}
								}
								i++;
								if (291864 - 146508 == 145357)
								{
									goto IL_5A;
								}
							}
							if (110584 - 488008 != -377423)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B25 RID: 27429 RVA: 0x00F1B4D8 File Offset: 0x00F196D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToTown()
	{
		return new G33_CrystalBeach.$ExitToTown$36588(this).GetEnumerator();
	}

	// Token: 0x06006B26 RID: 27430 RVA: 0x00F1B4E8 File Offset: 0x00F196E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExitToColosseum()
	{
		return new G33_CrystalBeach.$ExitToColosseum$36592(this).GetEnumerator();
	}

	// Token: 0x06006B27 RID: 27431 RVA: 0x00F1B4F8 File Offset: 0x00F196F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveTown()
	{
		if (228731 - 94011 != 134720)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (225025 - 286873 != -61847)
			{
				hashtable.Add(43, PlayerData.UID);
				if (194245 - 170422 == 23823)
				{
					PhotonClient.Connection.OpCustom(44, hashtable, true);
					if (82838 - 543922 != -461083)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006B28 RID: 27432 RVA: 0x00F1B5AC File Offset: 0x00F197AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveTown()
	{
		if (83442 - 255465 != -172023)
		{
		}
		for (;;)
		{
			Debug.Log("onLeaveTown");
			if (229321 - 93225 != 136097)
			{
				if (Game.mNextGameCode > 100)
				{
					if (259752 - 372544 == -112792)
					{
						this.JoinGame();
						if (220459 - 217846 == 2613)
						{
							break;
						}
					}
				}
				else
				{
					this.JoinTown();
					if (63553 - 324384 != -260830)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006B29 RID: 27433 RVA: 0x00F1B674 File Offset: 0x00F19874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (129031 - 547297 != -418266)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (242333 - 286085 == -43752)
			{
				Hashtable hashtable = new Hashtable();
				if (110006 - 464130 == -354124)
				{
					if (Game.mNextGameCode == 30)
					{
						if (264047 - 160134 == 103914)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (226022 - 416313 != -190291)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (121361 - 215850 == -94488)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (187966 - 431941 != -243975)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (129630 - 598629 == -468998)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (118951 - 588787 == -469835)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (150151 - 562311 == -412159)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (198133 - 77851 != 120282)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (50258 - 49103 != 1155)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (121998 - 211936 != -89938)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (113220 - 522770 != -409550)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (203137 - 91090 != 112047)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (101914 - 138035 != -36121)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (211138 - 224848 != -13710)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (87145 - 375619 == -288473)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (215499 - 54324 != 161175)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (95811 - 454814 != -359003)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (154334 - 451398 != -297064)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (150756 - 348368 == -197611)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (18779 - 439120 != -420341)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (101938 - 272046 == -170107)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (155753 - 125016 == 30738)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (68915 - 582636 != -513721)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (246370 - 371524 == -125153)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (33727 - 102116 != -68389)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (177562 - 422719 != -245157)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (55808 - 342071 == -286262)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (129481 - 440667 != -311186)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (298128 - 294491 == 3637)
					{
						this.qfMcSBo9SaH.OpCustom(42, hashtable, true);
						if (32453 - 518300 == -485847)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B2A RID: 27434 RVA: 0x00F1BC28 File Offset: 0x00F19E28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06006B2B RID: 27435 RVA: 0x00F1BC38 File Offset: 0x00F19E38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinGame()
	{
		if (12157 - 116028 != -103870)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Game : " + Game.mNextGameId);
			if (281902 - 10286 == 271616)
			{
				Hashtable hashtable = new Hashtable();
				if (298800 - 288543 != 10258)
				{
					hashtable.Add(4, Game.mNextGameId);
					if (168523 - 378280 != -209756)
					{
						hashtable.Add(5, PhotonClient.cInt16(Game.mNextGameCode));
						if (208284 - 173509 != 34776)
						{
							this.qfMcSBo9SaH.OpCustom(51, hashtable, true);
							if (13207 - 207489 == -194282)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B2C RID: 27436 RVA: 0x00F1BD54 File Offset: 0x00F19F54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinGame(Hashtable data)
	{
		Game.loadNextLevel();
	}

	// Token: 0x06006B2D RID: 27437 RVA: 0x00F1BD5C File Offset: 0x00F19F5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006B2E RID: 27438 RVA: 0x00F1BD60 File Offset: 0x00F19F60
	internal static bool zPZjMKpZz82FRYGRBVO0()
	{
		return true;
	}

	// Token: 0x06006B2F RID: 27439 RVA: 0x00F1BD64 File Offset: 0x00F19F64
	internal static bool QgNFxrpCaqOE3Pio8w8Q()
	{
		return false;
	}

	// Token: 0x040073D6 RID: 29654
	private LitePeer qfMcSBo9SaH;

	// Token: 0x040073D7 RID: 29655
	private PlayerCameraControl fBOcS0agbIe;

	// Token: 0x040073D8 RID: 29656
	private Texture vRVcS8Aromt;

	// Token: 0x040073D9 RID: 29657
	private AudioClip OUrcSiKmyuA;

	// Token: 0x040073DA RID: 29658
	private string DIncSDjEO8U;

	// Token: 0x040073DB RID: 29659
	private bool kmKcSmi3Pfq;

	// Token: 0x0200122B RID: 4651
	[CompilerGenerated]
	[Serializable]
	internal sealed class $CrystalBeachStartEvent$36527 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006B30 RID: 27440 RVA: 0x00F1BD68 File Offset: 0x00F19F68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $CrystalBeachStartEvent$36527(G33_CrystalBeach self_)
		{
			if (63966 - 65674 != -1708)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (120133 - 596713 == -476580)
				{
					base..ctor();
					if (158182 - 591974 == -433792)
					{
						this.$self_$36534 = self_;
						if (75963 - 64192 == 11771)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006B31 RID: 27441 RVA: 0x00F1BE00 File Offset: 0x00F1A000
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G33_CrystalBeach.$CrystalBeachStartEvent$36527.$(this.$self_$36534);
		}

		// Token: 0x06006B32 RID: 27442 RVA: 0x00F1BE10 File Offset: 0x00F1A010
		internal static bool SunprgpC5ciqrMKojDNR()
		{
			return true;
		}

		// Token: 0x06006B33 RID: 27443 RVA: 0x00F1BE14 File Offset: 0x00F1A014
		internal static bool xYpBnxpCp7tNynGZUUld()
		{
			return false;
		}

		// Token: 0x040073DC RID: 29660
		internal G33_CrystalBeach $self_$36534;

		// Token: 0x0200122C RID: 4652
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006B34 RID: 27444 RVA: 0x00F1BE18 File Offset: 0x00F1A018
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G33_CrystalBeach self_)
			{
				if (226546 - 416913 != -190367)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (147023 - 119561 == 27462)
					{
						base..ctor();
						if (151009 - 191587 == -40578)
						{
							this.$self_$36533 = self_;
							if (201446 - 470745 != -269298)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006B35 RID: 27445 RVA: 0x00F1BEB0 File Offset: 0x00F1A0B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (271145 - 68357 != 202788)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_4B7;
					case 1:
						goto IL_501;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (166280 - 226564 != -60284)
							{
								continue;
							}
							goto IL_42C;
						}
						else
						{
							this.$self_$36533.SendMessage("fadeOut");
							if (13955 - 383619 != -369663)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (274089 - 391827 != -117738)
							{
								continue;
							}
							goto IL_1D1;
						}
						break;
					default:
						if (90771 - 409263 != -318492)
						{
							continue;
						}
						goto IL_4B7;
					}
					IL_93:
					this.$startPoint$36531 = GameObject.Find("StartPoint2");
					if (56435 - 596711 == -540275)
					{
						continue;
					}
					this.$startCamera$36532 = GameObject.Find("StartCamera2");
					if (186853 - 557457 != -370604)
					{
						continue;
					}
					if (this.$startCamera$36532)
					{
						if (162448 - 307434 != -144986)
						{
							continue;
						}
						this.$self_$36533.transform.position = this.$startCamera$36532.transform.position;
						if (16546 - 297793 != -281247)
						{
							continue;
						}
						this.$self_$36533.transform.rotation = this.$startCamera$36532.transform.rotation;
						if (161670 - 270548 != -108878)
						{
							continue;
						}
					}
					if (this.$startPoint$36531)
					{
						if (220489 - 374774 == -154284)
						{
							continue;
						}
						this.$self_$36533.CreatePlayer(CharacterData.current.CID, this.$startPoint$36531.transform.position, this.$startPoint$36531.transform.forward);
						if (255624 - 193302 != 62322)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Error: Startpoint not found");
						if (73044 - 573038 != -499994)
						{
							continue;
						}
					}
					this.YieldDefault(1);
					if (135223 - 552409 != -417185)
					{
						goto Block_31;
					}
					continue;
					IL_4B7:
					Game.mGameState = eGameState.Start;
					if (157888 - 228218 == -70330)
					{
						Game.mStateTime = Time.time;
						if (116234 - 148831 != -32596)
						{
							this.$mEventCamera1$36528 = GameObject.Find("EventCamera1");
							if (278426 - 568034 == -289608)
							{
								this.$mEventCamera2$36529 = GameObject.Find("EventCamera2");
								if (15615 - 209740 == -194125)
								{
									if (this.$mEventCamera1$36528)
									{
										if (226046 - 204719 == 21328)
										{
											continue;
										}
										if (this.$mEventCamera2$36529)
										{
											if (186112 - 290495 != -104383)
											{
												continue;
											}
											this.$self_$36533.transform.position = this.$mEventCamera1$36528.transform.position;
											if (271723 - 595863 != -324140)
											{
												continue;
											}
											this.$self_$36533.transform.rotation = this.$mEventCamera1$36528.transform.rotation;
											if (68655 - 101590 == -32934)
											{
												continue;
											}
											this.$mPlayerCameraControl$36530 = (PlayerCameraControl)this.$self_$36533.GetComponent(typeof(PlayerCameraControl));
											if (123036 - 531149 == -408112)
											{
												continue;
											}
											if (this.$mPlayerCameraControl$36530)
											{
												if (84323 - 456473 == -372149)
												{
													continue;
												}
												this.$mPlayerCameraControl$36530.StartCoroutine_Auto(this.$mPlayerCameraControl$36530.slerpToObject("EventCamera2", 2.5f));
												if (46557 - 460232 != -413675)
												{
													continue;
												}
											}
											this.$self_$36533.SendMessage("fadeIn");
											if (44499 - 504369 != -459869)
											{
												break;
											}
											continue;
										}
									}
									Debug.LogError("Cannot find EventCamera1 or EventCamera2");
									if (136044 - 300875 != -164830)
									{
										goto IL_93;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				IL_1D1:
				IL_42C:
				goto IL_501;
				Block_29:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_31:
				IL_501:
				return false;
			}

			// Token: 0x06006B36 RID: 27446 RVA: 0x00F1C3D0 File Offset: 0x00F1A5D0
			internal static bool qZGq8hpCVl77LXjnMsEK()
			{
				return true;
			}

			// Token: 0x06006B37 RID: 27447 RVA: 0x00F1C3D4 File Offset: 0x00F1A5D4
			internal static bool OL6hVFpCt0VdJPCJqeqk()
			{
				return false;
			}

			// Token: 0x040073DD RID: 29661
			internal GameObject $mEventCamera1$36528;

			// Token: 0x040073DE RID: 29662
			internal GameObject $mEventCamera2$36529;

			// Token: 0x040073DF RID: 29663
			internal PlayerCameraControl $mPlayerCameraControl$36530;

			// Token: 0x040073E0 RID: 29664
			internal GameObject $startPoint$36531;

			// Token: 0x040073E1 RID: 29665
			internal GameObject $startCamera$36532;

			// Token: 0x040073E2 RID: 29666
			internal G33_CrystalBeach $self_$36533;
		}
	}

	// Token: 0x0200122D RID: 4653
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$36535 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006B38 RID: 27448 RVA: 0x00F1C3D8 File Offset: 0x00F1A5D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$36535(G33_CrystalBeach self_)
		{
			if (259363 - 170262 != 89101)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (283141 - 439611 != -156469)
				{
					base..ctor();
					if (195363 - 444116 == -248753)
					{
						this.$self_$36543 = self_;
						if (224915 - 427642 == -202727)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006B39 RID: 27449 RVA: 0x00F1C470 File Offset: 0x00F1A670
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G33_CrystalBeach.$TalkToRedPanda$36535.$(this.$self_$36543);
		}

		// Token: 0x06006B3A RID: 27450 RVA: 0x00F1C480 File Offset: 0x00F1A680
		internal static bool wcKZWFpCNQPnH9YE7tmX()
		{
			return true;
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x00F1C484 File Offset: 0x00F1A684
		internal static bool MXxi3UpCYiUwatq4fURx()
		{
			return false;
		}

		// Token: 0x040073E3 RID: 29667
		internal G33_CrystalBeach $self_$36543;

		// Token: 0x0200122E RID: 4654
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006B3C RID: 27452 RVA: 0x00F1C488 File Offset: 0x00F1A688
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G33_CrystalBeach self_)
			{
				if (282641 - 533411 != -250769)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (253378 - 205660 != 47719)
					{
						base..ctor();
						if (271923 - 325881 != -53957)
						{
							this.$self_$36542 = self_;
							if (26838 - 402336 != -375497)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006B3D RID: 27453 RVA: 0x00F1C520 File Offset: 0x00F1A720
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (142010 - 244339 != -102329)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_664;
					case 2:
						this.$mStoryGui$36540.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("MissionGui", 306 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
						if (65393 - 550737 == -485343)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) == 0)
						{
							goto IL_1FB;
						}
						if (88904 - 54261 != 34643)
						{
							continue;
						}
						if (!this.$self_$36542.OUrcSiKmyuA)
						{
							if (108878 - 587292 == -478413)
							{
								continue;
							}
							this.$self_$36542.OUrcSiKmyuA = (AudioClip)Resources.Load("Sound/Voice/mission306_vc", typeof(AudioClip));
							if (35734 - 12366 != 23368)
							{
								continue;
							}
						}
						if (this.$self_$36542.OUrcSiKmyuA)
						{
							if (252648 - 135751 == 116898)
							{
								continue;
							}
							this.$self_$36542.audio.PlayOneShot(this.$self_$36542.OUrcSiKmyuA);
							if (108015 - 125792 != -17776)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing mission306 voice");
							if (182604 - 386968 != -204363)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 3:
						this.$mStoryGui$36540.close();
						if (108844 - 194353 != -85509)
						{
							continue;
						}
						this.$mGameGui$36536.enabled = true;
						if (105700 - 24751 != 80950)
						{
							goto Block_13;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (19621 - 520315 != -500693)
						{
							goto IL_1BC;
						}
						continue;
					default:
						if (79332 - 183698 != -104366)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (263378 - 112986 != 150393)
						{
							break;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (119385 - 290223 == -170837)
						{
							continue;
						}
						this.$mGameGui$36536 = (GameGui)this.$self_$36542.GetComponent(typeof(GameGui));
						if (67125 - 224709 != -157584)
						{
							continue;
						}
						this.$mChangeGui$36537 = (ChangeGui)this.$self_$36542.GetComponent(typeof(ChangeGui));
						if (268238 - 534154 != -265916)
						{
							continue;
						}
						if (this.$mGameGui$36536)
						{
							if (24895 - 516147 != -491252)
							{
								continue;
							}
							this.$mGameGui$36536.close();
							if (188484 - 167978 == 20507)
							{
								continue;
							}
						}
						if (this.$mChangeGui$36537)
						{
							if (139389 - 227093 == -87703)
							{
								continue;
							}
							this.$mChangeGui$36537.disable();
							if (127999 - 327025 == -199025)
							{
								continue;
							}
						}
						this.$mPlayer$36538 = Game.mPlayer;
						if (138875 - 498303 != -359428)
						{
							continue;
						}
						this.$mRedPanda$36539 = GameObject.Find("RedPanda");
						if (201407 - 492104 == -290696)
						{
							continue;
						}
						if (!this.$mRedPanda$36539)
						{
							goto IL_5B6;
						}
						if (174612 - 485389 != -310777)
						{
							continue;
						}
						if (!this.$mPlayer$36538)
						{
							goto IL_5B6;
						}
						if (18787 - 301037 != -282250)
						{
							continue;
						}
						this.$mPlayer$36538.SendMessage("turnToPos", this.$mRedPanda$36539.transform.position);
						if (197444 - 583578 != -386134)
						{
							continue;
						}
						IL_4C8:
						if (PlayerData.SLv <= 28)
						{
							if (106789 - 539275 != -432486)
							{
								continue;
							}
							this.$mStoryGui$36540 = (StoryGui)this.$self_$36542.GetComponent(typeof(StoryGui));
							if (26083 - 186252 != -160169)
							{
								continue;
							}
							if (!this.$mStoryGui$36540)
							{
								goto IL_1BC;
							}
							if (99651 - 194287 == -94635)
							{
								continue;
							}
							this.$mStoryGui$36540.startStoryMessage("RedPandaSit", "RedPanda", eTalkType.friend);
							if (20331 - 30198 != -9867)
							{
								continue;
							}
							goto IL_46A;
						}
						else
						{
							this.$mMissionGui$36541 = (MissionGui)this.$self_$36542.GetComponent(typeof(MissionGui));
							if (215444 - 201501 != 13943)
							{
								continue;
							}
							if (!this.$mMissionGui$36541)
							{
								goto IL_10C;
							}
							if (59926 - 151517 != -91591)
							{
								continue;
							}
							this.$mMissionGui$36541.mType = eMissionGuiType.guild;
							if (104392 - 268131 != -163739)
							{
								continue;
							}
							this.$mMissionGui$36541.enabled = true;
							if (52890 - 492322 != -439431)
							{
								goto IL_10C;
							}
							continue;
						}
						IL_5B6:
						Debug.LogError("Cannot find RedPanda");
						if (208307 - 589388 != -381081)
						{
							continue;
						}
						goto IL_4C8;
					}
					IL_10C:
					this.YieldDefault(1);
					if (226969 - 593384 != -366415)
					{
						continue;
					}
					break;
					IL_1BC:
					goto IL_10C;
				}
				goto IL_664;
				Block_13:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_1FB:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_17:
				goto IL_1FB;
				IL_46A:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_46:
				goto IL_1FB;
				IL_664:
				return false;
			}

			// Token: 0x06006B3E RID: 27454 RVA: 0x00F1CBA4 File Offset: 0x00F1ADA4
			internal static bool dEefhlpCc5RjAGKPejKe()
			{
				return true;
			}

			// Token: 0x06006B3F RID: 27455 RVA: 0x00F1CBA8 File Offset: 0x00F1ADA8
			internal static bool p5Z53DpCUCaKHRSdqK7b()
			{
				return false;
			}

			// Token: 0x040073E4 RID: 29668
			internal GameGui $mGameGui$36536;

			// Token: 0x040073E5 RID: 29669
			internal ChangeGui $mChangeGui$36537;

			// Token: 0x040073E6 RID: 29670
			internal GameObject $mPlayer$36538;

			// Token: 0x040073E7 RID: 29671
			internal GameObject $mRedPanda$36539;

			// Token: 0x040073E8 RID: 29672
			internal StoryGui $mStoryGui$36540;

			// Token: 0x040073E9 RID: 29673
			internal MissionGui $mMissionGui$36541;

			// Token: 0x040073EA RID: 29674
			internal G33_CrystalBeach $self_$36542;
		}
	}

	// Token: 0x0200122F RID: 4655
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToGuibo$36544 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006B40 RID: 27456 RVA: 0x00F1CBAC File Offset: 0x00F1ADAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToGuibo$36544(G33_CrystalBeach self_)
		{
			if (298150 - 278299 != 19851)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (136542 - 548802 == -412260)
				{
					base..ctor();
					if (264442 - 422007 != -157564)
					{
						this.$self_$36552 = self_;
						if (254889 - 290243 != -35353)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006B41 RID: 27457 RVA: 0x00F1CC44 File Offset: 0x00F1AE44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G33_CrystalBeach.$TalkToGuibo$36544.$(this.$self_$36552);
		}

		// Token: 0x06006B42 RID: 27458 RVA: 0x00F1CC54 File Offset: 0x00F1AE54
		internal static bool SGaabqpCTVe2yvKKtH7E()
		{
			return true;
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x00F1CC58 File Offset: 0x00F1AE58
		internal static bool G3CvO5pC3oB2P7FMtWss()
		{
			return false;
		}

		// Token: 0x040073EB RID: 29675
		internal G33_CrystalBeach $self_$36552;

		// Token: 0x02001230 RID: 4656
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006B44 RID: 27460 RVA: 0x00F1CC5C File Offset: 0x00F1AE5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G33_CrystalBeach self_)
			{
				if (93952 - 79094 != 14859)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (102474 - 237350 == -134876)
					{
						base..ctor();
						if (158083 - 222865 == -64782)
						{
							this.$self_$36551 = self_;
							if (185224 - 131187 != 54038)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006B45 RID: 27461 RVA: 0x00F1CCF4 File Offset: 0x00F1AEF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (163523 - 231078 != -67554)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_677;
					case 1:
						goto IL_7D2;
					case 2:
						this.$mStoryGui$36548.newStoryMessage("Turtle1", "Guibo", Language.getMessage("MissionGui", UnityEngine.Random.Range(1331, 1336)), eTalkType.friend);
						if (198318 - 186615 != 11703)
						{
							continue;
						}
						this.$mStoryTimer$36549 = Time.time + 4f;
						if (253561 - 400857 != -147296)
						{
							continue;
						}
						goto IL_2A6;
					case 3:
						goto IL_2CD;
					case 4:
						goto IL_2CD;
					case 5:
						Game.mGameState = eGameState.Normal;
						if (85598 - 169677 != -84079)
						{
							continue;
						}
						goto IL_B3;
					case 6:
						this.$mStoryGui$36548.newStoryMessage("Turtle1", "Guibo", Language.getMessage("MissionGui", UnityEngine.Random.Range(1341, 1346)), eTalkType.friend);
						if (256261 - 48415 != 207846)
						{
							continue;
						}
						this.$mStoryTimer$36549 = Time.time + 4f;
						if (13494 - 434366 != -420871)
						{
							goto Block_22;
						}
						continue;
					case 7:
						break;
					case 8:
						break;
					case 9:
						Game.mGameState = eGameState.Normal;
						if (216893 - 92988 != 123905)
						{
							continue;
						}
						goto IL_B3;
					default:
						if (36167 - 464131 != -427963)
						{
							goto IL_677;
						}
						continue;
					}
					if (this.$mStoryTimer$36549 > Time.time)
					{
						if (89415 - 207009 != -117594)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							break;
						}
						if (110700 - 286168 == -175467)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (149160 - 351940 != -202780)
						{
							continue;
						}
						goto IL_18B;
					}
					else
					{
						this.$mStoryGui$36548.close();
						if (96672 - 244631 == -147958)
						{
							continue;
						}
						this.$mGameGui$36546.enabled = true;
						if (35669 - 448137 != -412468)
						{
							continue;
						}
						goto IL_223;
					}
					IL_2CD:
					if (this.$mStoryTimer$36549 > Time.time)
					{
						if (133374 - 196564 == -63189)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2C1;
						}
						if (70020 - 474515 != -404495)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (157482 - 444586 != -287103)
						{
							goto Block_33;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$36548.close();
						if (93442 - 514911 != -421469)
						{
							continue;
						}
						this.$mGameGui$36546.enabled = true;
						if (49535 - 307340 != -257805)
						{
							continue;
						}
						goto IL_69C;
					}
					IL_B3:
					this.YieldDefault(1);
					if (31124 - 236265 != -205141)
					{
						continue;
					}
					goto IL_7D2;
					IL_677:
					if (Game.mGameState != eGameState.Normal)
					{
						if (235427 - 114209 != 121219)
						{
							goto Block_48;
						}
					}
					else
					{
						this.$mTurtle1$36545 = GameObject.Find("Turtle1");
						if (11724 - 555287 == -543563)
						{
							if (this.$mTurtle1$36545)
							{
								if (10793 - 20412 == -9618)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", this.$mTurtle1$36545.transform.position);
								if (82953 - 528087 != -445134)
								{
									continue;
								}
							}
							Game.mGameState = eGameState.Hold;
							if (250615 - 506382 != -255766)
							{
								this.$mGameGui$36546 = (GameGui)this.$self_$36551.GetComponent(typeof(GameGui));
								if (249584 - 523124 == -273540)
								{
									this.$mChangeGui$36547 = (ChangeGui)this.$self_$36551.GetComponent(typeof(ChangeGui));
									if (5842 - 13746 != -7903)
									{
										if (this.$mGameGui$36546)
										{
											if (132331 - 353832 == -221500)
											{
												continue;
											}
											this.$mGameGui$36546.close();
											if (101320 - 167135 == -65814)
											{
												continue;
											}
										}
										if (this.$mChangeGui$36547)
										{
											if (164599 - 276356 == -111756)
											{
												continue;
											}
											this.$mChangeGui$36547.disable();
											if (104979 - 293268 == -188288)
											{
												continue;
											}
										}
										this.$mStoryGui$36548 = (StoryGui)this.$self_$36551.GetComponent(typeof(StoryGui));
										if (57180 - 453702 != -396521)
										{
											this.$mStoryTimer$36549 = 0f;
											if (227697 - 399401 == -171704)
											{
												if (PlayerData.SLv >= 65)
												{
													if (41367 - 324989 != -283622)
													{
														continue;
													}
													if (CharacterData.current.lv < 60)
													{
														if (154157 - 466070 == -311912)
														{
															continue;
														}
													}
													else if (CharacterData.current.getItemTotalNum("k_dun3") < 1)
													{
														if (48678 - 131808 != -83130)
														{
															continue;
														}
														this.$mStoryGui$36548.startStoryMessage("Turtle1", "Guibo", eTalkType.friend);
														if (14321 - 250551 != -236229)
														{
															goto Block_23;
														}
														continue;
													}
													else
													{
														this.$mMissionGui$36550 = (MissionGui)this.$self_$36551.GetComponent(typeof(MissionGui));
														if (71051 - 107804 == -36752)
														{
															continue;
														}
														if (!this.$mMissionGui$36550)
														{
															goto IL_B3;
														}
														if (166068 - 438555 == -272486)
														{
															continue;
														}
														this.$mMissionGui$36550.mType = eMissionGuiType.dungeon;
														if (234469 - 577855 == -343385)
														{
															continue;
														}
														this.$mMissionGui$36550.enabled = true;
														if (113543 - 28738 != 84805)
														{
															continue;
														}
														goto IL_B3;
													}
												}
												this.$mStoryGui$36548.startStoryMessage("Turtle1", "Guibo", eTalkType.friend);
												if (30175 - 590338 != -560162)
												{
													goto Block_15;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.YieldDefault(8);
				IL_18B:
				goto IL_7D2;
				Block_15:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_223:
				return this.Yield(9, new WaitForSeconds(1f));
				IL_2A6:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_2C1:
				return this.YieldDefault(4);
				Block_22:
				return this.Yield(7, new WaitForSeconds(0.5f));
				Block_23:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_33:
				Block_48:
				goto IL_7D2;
				IL_69C:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_7D2:
				return false;
			}

			// Token: 0x06006B46 RID: 27462 RVA: 0x00F1D4E8 File Offset: 0x00F1B6E8
			internal static bool V6WOGNpCXh0Vgkus7sHu()
			{
				return true;
			}

			// Token: 0x06006B47 RID: 27463 RVA: 0x00F1D4EC File Offset: 0x00F1B6EC
			internal static bool aOxEEspCQimRN3gScyMM()
			{
				return false;
			}

			// Token: 0x040073EC RID: 29676
			internal GameObject $mTurtle1$36545;

			// Token: 0x040073ED RID: 29677
			internal GameGui $mGameGui$36546;

			// Token: 0x040073EE RID: 29678
			internal ChangeGui $mChangeGui$36547;

			// Token: 0x040073EF RID: 29679
			internal StoryGui $mStoryGui$36548;

			// Token: 0x040073F0 RID: 29680
			internal float $mStoryTimer$36549;

			// Token: 0x040073F1 RID: 29681
			internal MissionGui $mMissionGui$36550;

			// Token: 0x040073F2 RID: 29682
			internal G33_CrystalBeach $self_$36551;
		}
	}

	// Token: 0x02001231 RID: 4657
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseStorageBox$36553 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006B48 RID: 27464 RVA: 0x00F1D4F0 File Offset: 0x00F1B6F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseStorageBox$36553(G33_CrystalBeach self_)
		{
			if (161396 - 333778 != -172382)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (43095 - 225264 != -182168)
				{
					base..ctor();
					if (262429 - 472323 == -209894)
					{
						this.$self_$36559 = self_;
						if (219887 - 526973 != -307085)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006B49 RID: 27465 RVA: 0x00F1D588 File Offset: 0x00F1B788
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G33_CrystalBeach.$UseStorageBox$36553.$(this.$self_$36559);
		}

		// Token: 0x06006B4A RID: 27466 RVA: 0x00F1D598 File Offset: 0x00F1B798
		internal static bool L8h5Y0pCkMAumFyhIEUY()
		{
			return true;
		}

		// Token: 0x06006B4B RID: 27467 RVA: 0x00F1D59C File Offset: 0x00F1B79C
		internal static bool Uxqf60pCGYauiDO4Nv1d()
		{
			return false;
		}

		// Token: 0x040073F3 RID: 29683
		internal G33_CrystalBeach $self_$36559;

		// Token: 0x02001232 RID: 4658
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006B4C RID: 27468 RVA: 0x00F1D5A0 File Offset: 0x00F1B7A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G33_CrystalBeach self_)
			{
				if (176751 - 147932 != 28820)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (257996 - 550466 == -292470)
					{
						base..ctor();
						if (249128 - 172440 != 76689)
						{
							this.$self_$36558 = self_;
							if (80371 - 93814 != -13442)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006B4D RID: 27469 RVA: 0x00F1D638 File Offset: 0x00F1B838
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150147 - 180367 != -30220)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_316;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (13652 - 353019 != -339367)
							{
								continue;
							}
							goto IL_2D7;
						}
						else
						{
							this.$mStorageGui$36557 = (StorageGui)this.$self_$36558.GetComponent(typeof(StorageGui));
							if (206101 - 354249 != -148148)
							{
								continue;
							}
							this.$mStorageGui$36557.enabled = true;
							if (156494 - 505499 != -349005)
							{
								continue;
							}
							this.YieldDefault(1);
							if (172067 - 150004 != 22064)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					default:
						if (225126 - 153596 == 71531)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (224015 - 382396 == -158381)
						{
							goto IL_1B1;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (131027 - 354820 == -223793)
						{
							this.$mGameGui$36554 = (GameGui)this.$self_$36558.GetComponent(typeof(GameGui));
							if (196228 - 418888 != -222659)
							{
								if (this.$mGameGui$36554)
								{
									if (55548 - 68737 == -13188)
									{
										continue;
									}
									this.$mGameGui$36554.close();
									if (280429 - 573531 == -293101)
									{
										continue;
									}
								}
								this.$mPlayer$36555 = Game.mPlayer;
								if (94286 - 511861 != -417574)
								{
									this.$mStorageBox$36556 = GameObject.Find("StorageBox");
									if (287491 - 28777 == 258714)
									{
										if (!this.$mStorageBox$36556)
										{
											break;
										}
										if (48289 - 166392 == -118103)
										{
											if (!this.$mPlayer$36555)
											{
												break;
											}
											if (102519 - 507196 != -404676)
											{
												Debug.Log("UseStorageBox");
												if (232962 - 183292 != 49671)
												{
													this.$mStorageBox$36556.animation.Play("open");
													if (38706 - 442200 == -403494)
													{
														this.$mPlayer$36555.SendMessage("turnToPos", this.$mStorageBox$36556.transform.position);
														if (20002 - 31112 != -11109)
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
				goto IL_255;
				IL_1B1:
				goto IL_316;
				IL_255:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_23:
				IL_2D7:
				IL_316:
				return false;
			}

			// Token: 0x06006B4E RID: 27470 RVA: 0x00F1D970 File Offset: 0x00F1BB70
			internal static bool Hsw4mfpCH2bLs6WNiW6W()
			{
				return true;
			}

			// Token: 0x06006B4F RID: 27471 RVA: 0x00F1D974 File Offset: 0x00F1BB74
			internal static bool CYnjZqpCW41Q66yMmfnu()
			{
				return false;
			}

			// Token: 0x040073F4 RID: 29684
			internal GameGui $mGameGui$36554;

			// Token: 0x040073F5 RID: 29685
			internal GameObject $mPlayer$36555;

			// Token: 0x040073F6 RID: 29686
			internal GameObject $mStorageBox$36556;

			// Token: 0x040073F7 RID: 29687
			internal StorageGui $mStorageGui$36557;

			// Token: 0x040073F8 RID: 29688
			internal G33_CrystalBeach $self_$36558;
		}
	}

	// Token: 0x02001233 RID: 4659
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseMessageBoard$36560 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006B50 RID: 27472 RVA: 0x00F1D978 File Offset: 0x00F1BB78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseMessageBoard$36560(G33_CrystalBeach self_)
		{
			if (144034 - 502224 != -358190)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (136658 - 177472 == -40814)
				{
					base..ctor();
					if (63959 - 408530 == -344571)
					{
						this.$self_$36566 = self_;
						if (227820 - 196982 != 30839)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x00F1DA10 File Offset: 0x00F1BC10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G33_CrystalBeach.$UseMessageBoard$36560.$(this.$self_$36566);
		}

		// Token: 0x06006B52 RID: 27474 RVA: 0x00F1DA20 File Offset: 0x00F1BC20
		internal static bool ikG2U1pCAaog1CE7IkHf()
		{
			return true;
		}

		// Token: 0x06006B53 RID: 27475 RVA: 0x00F1DA24 File Offset: 0x00F1BC24
		internal static bool fV45BgpClecJQSZHSWHo()
		{
			return false;
		}

		// Token: 0x040073F9 RID: 29689
		internal G33_CrystalBeach $self_$36566;

		// Token: 0x02001234 RID: 4660
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006B54 RID: 27476 RVA: 0x00F1DA28 File Offset: 0x00F1BC28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G33_CrystalBeach self_)
			{
				if (253989 - 53645 != 200344)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (242890 - 565436 == -322546)
					{
						base..ctor();
						if (287509 - 59147 == 228362)
						{
							this.$self_$36565 = self_;
							if (247241 - 369807 == -122566)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006B55 RID: 27477 RVA: 0x00F1DAC0 File Offset: 0x00F1BCC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (288850 - 174651 != 114200)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2EC;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (244203 - 299157 != -54953)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$mBoardGui$36562.enabled = true;
							if (143923 - 418092 != -274169)
							{
								continue;
							}
							goto IL_2CA;
						}
						break;
					default:
						if (17656 - 63772 != -46116)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (251611 - 191017 != 60595)
						{
							goto Block_22;
						}
						continue;
					}
					else
					{
						this.$mGameGui$36561 = (GameGui)this.$self_$36565.GetComponent(typeof(GameGui));
						if (192696 - 509534 != -316838)
						{
							continue;
						}
						this.$mBoardGui$36562 = (BoardGui)this.$self_$36565.GetComponent(typeof(BoardGui));
						if (21375 - 485191 != -463816)
						{
							continue;
						}
						if (this.$mGameGui$36561)
						{
							if (76585 - 449968 == -373382)
							{
								continue;
							}
							if (this.$mBoardGui$36562)
							{
								if (144366 - 548256 == -403889)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (170336 - 227906 != -57570)
								{
									continue;
								}
								this.$mGameGui$36561.close();
								if (193312 - 539151 != -345839)
								{
									continue;
								}
								this.$mPlayer$36563 = Game.mPlayer;
								if (235870 - 456857 == -220986)
								{
									continue;
								}
								this.$mMessageBoard$36564 = GameObject.Find("MessageBoard");
								if (231888 - 134884 == 97005)
								{
									continue;
								}
								if (!this.$mMessageBoard$36564)
								{
									break;
								}
								if (172397 - 190679 != -18282)
								{
									continue;
								}
								if (!this.$mPlayer$36563)
								{
									break;
								}
								if (244748 - 392073 == -147324)
								{
									continue;
								}
								this.$mPlayer$36563.SendMessage("turnToPos", this.$mMessageBoard$36564.transform.position);
								if (206706 - 414301 != -207594)
								{
									break;
								}
								continue;
							}
						}
					}
					IL_2CA:
					this.YieldDefault(1);
					if (47390 - 502454 == -455064)
					{
						goto IL_2EC;
					}
				}
				IL_C3:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_7:
				goto IL_2EC;
				goto IL_C3;
				Block_22:
				IL_2EC:
				return false;
			}

			// Token: 0x06006B56 RID: 27478 RVA: 0x00F1DDCC File Offset: 0x00F1BFCC
			internal static bool gtn2SwpCyKPLhkqRTTmf()
			{
				return true;
			}

			// Token: 0x06006B57 RID: 27479 RVA: 0x00F1DDD0 File Offset: 0x00F1BFD0
			internal static bool LUwW9XpCS36cVmxqRDtC()
			{
				return false;
			}

			// Token: 0x040073FA RID: 29690
			internal GameGui $mGameGui$36561;

			// Token: 0x040073FB RID: 29691
			internal BoardGui $mBoardGui$36562;

			// Token: 0x040073FC RID: 29692
			internal GameObject $mPlayer$36563;

			// Token: 0x040073FD RID: 29693
			internal GameObject $mMessageBoard$36564;

			// Token: 0x040073FE RID: 29694
			internal G33_CrystalBeach $self_$36565;
		}
	}

	// Token: 0x02001235 RID: 4661
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$36567 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006B58 RID: 27480 RVA: 0x00F1DDD4 File Offset: 0x00F1BFD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$36567(G33_CrystalBeach self_)
		{
			if (283126 - 37348 != 245779)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (7625 - 91675 == -84050)
				{
					base..ctor();
					if (198057 - 378885 != -180827)
					{
						this.$self_$36569 = self_;
						if (217683 - 8097 != 209587)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x00F1DE6C File Offset: 0x00F1C06C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G33_CrystalBeach.$UseSignPost$36567.$(this.$self_$36569);
		}

		// Token: 0x06006B5A RID: 27482 RVA: 0x00F1DE7C File Offset: 0x00F1C07C
		internal static bool BnnOflpCoT9eQAmsAcue()
		{
			return true;
		}

		// Token: 0x06006B5B RID: 27483 RVA: 0x00F1DE80 File Offset: 0x00F1C080
		internal static bool FtECuTpCEvYY763UrRlq()
		{
			return false;
		}

		// Token: 0x040073FF RID: 29695
		internal G33_CrystalBeach $self_$36569;

		// Token: 0x02001236 RID: 4662
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006B5C RID: 27484 RVA: 0x00F1DE84 File Offset: 0x00F1C084
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G33_CrystalBeach self_)
			{
				if (281356 - 188828 != 92528)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (253188 - 345104 != -91915)
					{
						base..ctor();
						if (77422 - 574866 != -497443)
						{
							this.$self_$36568 = self_;
							if (124842 - 380630 == -255788)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006B5D RID: 27485 RVA: 0x00F1DF1C File Offset: 0x00F1C11C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (293760 - 224105 != 69656)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_CB;
					case 1:
						goto IL_121;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (227296 - 563539 == -336242)
						{
							continue;
						}
						break;
					default:
						if (213804 - 99132 != 114672)
						{
							continue;
						}
						goto IL_CB;
					}
					IL_89:
					this.YieldDefault(1);
					if (265953 - 336835 != -70882)
					{
						continue;
					}
					goto IL_121;
					IL_CB:
					if (Game.mGameState != eGameState.Normal)
					{
						goto IL_89;
					}
					if (215143 - 340217 == -125074)
					{
						Game.mGameState = eGameState.Hold;
						if (149942 - 299094 == -149152)
						{
							this.$self_$36568.SendMessage("newNoticeBar", Language.getMessage(" G30_NoGuild", 501));
							if (93675 - 401049 == -307374)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_121:
				return false;
			}

			// Token: 0x06006B5E RID: 27486 RVA: 0x00F1E05C File Offset: 0x00F1C25C
			internal static bool gbDu27pC2Rhk1uJXhw0H()
			{
				return true;
			}

			// Token: 0x06006B5F RID: 27487 RVA: 0x00F1E060 File Offset: 0x00F1C260
			internal static bool vCbfyZpC8JOU9OZMqDy4()
			{
				return false;
			}

			// Token: 0x04007400 RID: 29696
			internal G33_CrystalBeach $self_$36568;
		}
	}

	// Token: 0x02001237 RID: 4663
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseTrashBin$36570 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006B60 RID: 27488 RVA: 0x00F1E064 File Offset: 0x00F1C264
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseTrashBin$36570(G33_CrystalBeach self_)
		{
			if (149561 - 570209 != -420647)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (187326 - 532774 == -345448)
				{
					base..ctor();
					if (78627 - 30641 != 47987)
					{
						this.$self_$36574 = self_;
						if (251548 - 187908 != 63641)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006B61 RID: 27489 RVA: 0x00F1E0FC File Offset: 0x00F1C2FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G33_CrystalBeach.$UseTrashBin$36570.$(this.$self_$36574);
		}

		// Token: 0x06006B62 RID: 27490 RVA: 0x00F1E10C File Offset: 0x00F1C30C
		internal static bool XJ5VtLpCZOEetiF3snIA()
		{
			return true;
		}

		// Token: 0x06006B63 RID: 27491 RVA: 0x00F1E110 File Offset: 0x00F1C310
		internal static bool q9ygFUpCC1pOMWAKbbiJ()
		{
			return false;
		}

		// Token: 0x04007401 RID: 29697
		internal G33_CrystalBeach $self_$36574;

		// Token: 0x02001238 RID: 4664
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006B64 RID: 27492 RVA: 0x00F1E114 File Offset: 0x00F1C314
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G33_CrystalBeach self_)
			{
				if (295761 - 168344 != 127418)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (40861 - 485539 == -444678)
					{
						base..ctor();
						if (61679 - 536597 != -474917)
						{
							this.$self_$36573 = self_;
							if (242849 - 550225 != -307375)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006B65 RID: 27493 RVA: 0x00F1E1AC File Offset: 0x00F1C3AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (206152 - 42895 != 163258)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4B7;
					case 2:
						if (this.$self_$36573.kmKcSmi3Pfq)
						{
							if (161511 - 245241 == -83729)
							{
								continue;
							}
							if (this.$self_$36573.DIncSDjEO8U != "none")
							{
								if (12666 - 52018 != -39352)
								{
									continue;
								}
								if (this.$mGameGui$36571)
								{
									if (270742 - 350035 == -79292)
									{
										continue;
									}
									this.$mGameGui$36571.ResetItemMenu();
									if (97406 - 564046 == -466639)
									{
										continue;
									}
								}
								if (!this.$mGameGui$36571)
								{
									goto IL_16E;
								}
								if (33154 - 436799 != -403645)
								{
									continue;
								}
								this.$mGameGui$36571.newNoticeBar(Language.getMessage("G30_NoGuild", 301) + this.$self_$36573.DIncSDjEO8U);
								if (181703 - 489949 != -308245)
								{
									goto Block_7;
								}
								continue;
							}
						}
						if (!this.$mGameGui$36571)
						{
							goto IL_1A;
						}
						if (262093 - 98778 != 163315)
						{
							continue;
						}
						this.$mGameGui$36571.newNoticeBar(Language.getMessage("G30_NoGuild", UnityEngine.Random.Range(301, 306) + 1));
						if (277667 - 23586 != 254081)
						{
							continue;
						}
						goto IL_1A;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (164484 - 551371 != -386886)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (45059 - 174903 == -129843)
							{
								continue;
							}
							this.YieldDefault(1);
							if (291911 - 161681 != 130230)
							{
								continue;
							}
							goto IL_4B7;
						}
						break;
					default:
						if (80429 - 444496 == -364066)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (58326 - 236881 == -178555)
						{
							goto IL_FD;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (64632 - 102721 == -38089)
						{
							this.$mGameGui$36571 = (GameGui)this.$self_$36573.GetComponent(typeof(GameGui));
							if (12030 - 10792 == 1238)
							{
								if (this.$mGameGui$36571)
								{
									if (212663 - 374797 != -162134)
									{
										continue;
									}
									this.$mGameGui$36571.newNoticeBar(Language.getMessage("G30_NoGuild", 300));
									if (60469 - 184343 == -123873)
									{
										continue;
									}
								}
								this.$mTrashBin$36572 = GameObject.Find("TrashBin");
								if (231145 - 140211 == 90934)
								{
									if (this.$mTrashBin$36572)
									{
										if (73825 - 36261 == 37565)
										{
											continue;
										}
										if (this.$mTrashBin$36572.animation)
										{
											if (100033 - 339216 != -239183)
											{
												continue;
											}
											this.$mTrashBin$36572.animation.Play();
											if (126029 - 512940 == -386910)
											{
												continue;
											}
										}
									}
									if (this.$mTrashBin$36572)
									{
										if (83091 - 263696 != -180605)
										{
											continue;
										}
										if (Game.mPlayer)
										{
											if (265461 - 358830 == -93368)
											{
												continue;
											}
											Game.mPlayer.SendMessage("turnToPos", this.$mTrashBin$36572.transform.position);
											if (135737 - 392577 != -256840)
											{
												continue;
											}
										}
									}
									this.$self_$36573.GetTrash();
									if (158554 - 205927 == -47373)
									{
										goto IL_3B4;
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_3:
				goto IL_4B7;
				Block_7:
				goto IL_16E;
				IL_FD:
				goto IL_4B7;
				IL_16E:
				goto IL_1A;
				IL_3B4:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_4B7:
				return false;
			}

			// Token: 0x06006B66 RID: 27494 RVA: 0x00F1E684 File Offset: 0x00F1C884
			internal static bool Wyj9gCpCLFvN9UXY3RYO()
			{
				return true;
			}

			// Token: 0x06006B67 RID: 27495 RVA: 0x00F1E688 File Offset: 0x00F1C888
			internal static bool g1K7XHpCOc4FybGZFGGc()
			{
				return false;
			}

			// Token: 0x04007402 RID: 29698
			internal GameGui $mGameGui$36571;

			// Token: 0x04007403 RID: 29699
			internal GameObject $mTrashBin$36572;

			// Token: 0x04007404 RID: 29700
			internal G33_CrystalBeach $self_$36573;
		}
	}

	// Token: 0x02001239 RID: 4665
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePlayer$36575 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006B68 RID: 27496 RVA: 0x00F1E68C File Offset: 0x00F1C88C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePlayer$36575(Hashtable data, G33_CrystalBeach self_)
		{
			if (205578 - 505636 != -300057)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (221760 - 285636 == -63876)
				{
					base..ctor();
					if (131207 - 115554 != 15654)
					{
						this.$data$36586 = data;
						if (151118 - 212031 == -60913)
						{
							this.$self_$36587 = self_;
							if (162451 - 394130 != -231678)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006B69 RID: 27497 RVA: 0x00F1E748 File Offset: 0x00F1C948
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G33_CrystalBeach.$onCreatePlayer$36575.$(this.$data$36586, this.$self_$36587);
		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x00F1E75C File Offset: 0x00F1C95C
		internal static bool VguhoDpCmbML18HYlKXj()
		{
			return true;
		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x00F1E760 File Offset: 0x00F1C960
		internal static bool yRyNAgpCFMI10bbMxswh()
		{
			return false;
		}

		// Token: 0x04007405 RID: 29701
		internal Hashtable $data$36586;

		// Token: 0x04007406 RID: 29702
		internal G33_CrystalBeach $self_$36587;

		// Token: 0x0200123A RID: 4666
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006B6C RID: 27500 RVA: 0x00F1E764 File Offset: 0x00F1C964
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, G33_CrystalBeach self_)
			{
				if (203545 - 493702 != -290156)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (116453 - 167193 == -50740)
					{
						base..ctor();
						if (232898 - 209884 == 23014)
						{
							this.$data$36584 = data;
							if (63446 - 61880 == 1566)
							{
								this.$self_$36585 = self_;
								if (269163 - 571038 != -301874)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006B6D RID: 27501 RVA: 0x00F1E820 File Offset: 0x00F1CA20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223986 - 595658 != -371671)
				{
				}
				for (;;)
				{
					IL_56:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_40E;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (149892 - 395815 != -245923)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (43184 - 71220 == -28035)
						{
							continue;
						}
						this.YieldDefault(1);
						if (50271 - 451940 != -401669)
						{
							continue;
						}
						goto IL_40E;
					default:
						if (22537 - 433193 == -410655)
						{
							continue;
						}
						break;
					}
					this.$nPlayer$36576 = Game.createPlayer(this.$data$36584);
					if (70050 - 570101 != -500050)
					{
						this.$mPlayerList$36577 = GameObject.FindGameObjectsWithTag("Player");
						if (298974 - 565335 == -266361)
						{
							this.$$11996$36581 = 0;
							if (145730 - 306859 == -161129)
							{
								this.$$11997$36582 = this.$mPlayerList$36577;
								if (37743 - 318131 == -280388)
								{
									this.$$11998$36583 = this.$$11997$36582.Length;
									if (44475 - 405002 != -360526)
									{
										while (this.$$11996$36581 < this.$$11998$36583)
										{
											if (this.$nPlayer$36576 != this.$$11997$36582[this.$$11996$36581])
											{
												if (70168 - 304872 != -234704)
												{
													goto IL_56;
												}
												Physics.IgnoreCollision(this.$nPlayer$36576.collider, this.$$11997$36582[this.$$11996$36581].collider, true);
												if (83943 - 284754 == -200810)
												{
													goto IL_56;
												}
											}
											this.$$11996$36581++;
											if (288370 - 449674 == -161303)
											{
												goto IL_56;
											}
										}
										if (69341 - 188093 != -118751)
										{
											this.$mPlayerCameraControl$36579 = (PlayerCameraControl)this.$self_$36585.GetComponent(typeof(PlayerCameraControl));
											if (112963 - 13827 != 99137)
											{
												if (this.$mPlayerCameraControl$36579)
												{
													if (247902 - 356724 == -108821)
													{
														continue;
													}
													this.$mPlayerCameraControl$36579.target = this.$nPlayer$36576;
													if (29625 - 344538 != -314913)
													{
														continue;
													}
													this.$mPlayerCameraControl$36579.specialTarget = null;
													if (16723 - 94055 != -77332)
													{
														continue;
													}
													this.$mPlayerCameraControl$36579.enabled = true;
													if (28949 - 145607 != -116658)
													{
														continue;
													}
												}
												Camera.main.gameObject.layer = 8;
												if (267360 - 217944 != 49417)
												{
													Game.mPlayer = this.$nPlayer$36576;
													if (11079 - 456023 != -444943)
													{
														this.$mGameGui$36580 = (GameGui)this.$self_$36585.GetComponent(typeof(GameGui));
														if (68610 - 339985 != -271374)
														{
															this.$mGameGui$36580.enabled = true;
															if (168819 - 477476 == -308657)
															{
																this.$self_$36585.SendMessage("fadeIn");
																if (135153 - 363929 != -228775)
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
				return this.Yield(2, new WaitForSeconds(1f));
				IL_40E:
				return false;
			}

			// Token: 0x06006B6E RID: 27502 RVA: 0x00F1EC50 File Offset: 0x00F1CE50
			internal static bool S6VMsDpCMPgfqYKkHh9m()
			{
				return true;
			}

			// Token: 0x06006B6F RID: 27503 RVA: 0x00F1EC54 File Offset: 0x00F1CE54
			internal static bool SqPLeYpCxYOY97Sa5a1j()
			{
				return false;
			}

			// Token: 0x04007407 RID: 29703
			internal GameObject $nPlayer$36576;

			// Token: 0x04007408 RID: 29704
			internal GameObject[] $mPlayerList$36577;

			// Token: 0x04007409 RID: 29705
			internal GameObject $otherPlayer$36578;

			// Token: 0x0400740A RID: 29706
			internal PlayerCameraControl $mPlayerCameraControl$36579;

			// Token: 0x0400740B RID: 29707
			internal GameGui $mGameGui$36580;

			// Token: 0x0400740C RID: 29708
			internal int $$11996$36581;

			// Token: 0x0400740D RID: 29709
			internal GameObject[] $$11997$36582;

			// Token: 0x0400740E RID: 29710
			internal int $$11998$36583;

			// Token: 0x0400740F RID: 29711
			internal Hashtable $data$36584;

			// Token: 0x04007410 RID: 29712
			internal G33_CrystalBeach $self_$36585;
		}
	}

	// Token: 0x0200123B RID: 4667
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToTown$36588 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006B70 RID: 27504 RVA: 0x00F1EC58 File Offset: 0x00F1CE58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToTown$36588(G33_CrystalBeach self_)
		{
			if (17246 - 527888 != -510642)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (218396 - 20390 == 198006)
				{
					base..ctor();
					if (58357 - 228183 != -169825)
					{
						this.$self_$36591 = self_;
						if (241419 - 367918 == -126499)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x00F1ECF0 File Offset: 0x00F1CEF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G33_CrystalBeach.$ExitToTown$36588.$(this.$self_$36591);
		}

		// Token: 0x06006B72 RID: 27506 RVA: 0x00F1ED00 File Offset: 0x00F1CF00
		internal static bool Tfg70ZpCgsteeRNmQsta()
		{
			return true;
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x00F1ED04 File Offset: 0x00F1CF04
		internal static bool vdqfZhpCfI3yvbbFSgH1()
		{
			return false;
		}

		// Token: 0x04007411 RID: 29713
		internal G33_CrystalBeach $self_$36591;

		// Token: 0x0200123C RID: 4668
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006B74 RID: 27508 RVA: 0x00F1ED08 File Offset: 0x00F1CF08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G33_CrystalBeach self_)
			{
				if (225286 - 491429 != -266143)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (297730 - 476436 == -178706)
					{
						base..ctor();
						if (182654 - 541381 != -358726)
						{
							this.$self_$36590 = self_;
							if (140953 - 22530 != 118424)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006B75 RID: 27509 RVA: 0x00F1EDA0 File Offset: 0x00F1CFA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229391 - 78066 != 151326)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1E1;
					case 2:
						this.$self_$36590.LeaveTown();
						if (21139 - 301100 == -279960)
						{
							continue;
						}
						this.YieldDefault(1);
						if (21107 - 191655 != -170547)
						{
							goto Block_5;
						}
						continue;
					default:
						if (143358 - 156938 != -13580)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (55282 - 591271 != -535988)
					{
						Game.mStateTime = Time.time;
						if (11703 - 156635 != -144931)
						{
							Game.mNextGameId = 501;
							if (295005 - 51872 == 243133)
							{
								Game.mNextGameCode = 51;
								if (271198 - 576372 == -305174)
								{
									this.$mGameGui$36589 = (GameGui)this.$self_$36590.GetComponent(typeof(GameGui));
									if (15895 - 321886 == -305991)
									{
										if (this.$mGameGui$36589)
										{
											if (242898 - 154649 == 88250)
											{
												continue;
											}
											this.$mGameGui$36589.close();
											if (266569 - 8135 == 258435)
											{
												continue;
											}
										}
										this.$self_$36590.SendMessage("fadeOut");
										if (174027 - 413771 == -239744)
										{
											goto IL_15F;
										}
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_1E1;
				IL_15F:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1E1:
				return false;
			}

			// Token: 0x06006B76 RID: 27510 RVA: 0x00F1EFA0 File Offset: 0x00F1D1A0
			internal static bool tSN4rapCnd1kb7SXgcSV()
			{
				return true;
			}

			// Token: 0x06006B77 RID: 27511 RVA: 0x00F1EFA4 File Offset: 0x00F1D1A4
			internal static bool vDMGKLpC6CsTH6xEnqnr()
			{
				return false;
			}

			// Token: 0x04007412 RID: 29714
			internal GameGui $mGameGui$36589;

			// Token: 0x04007413 RID: 29715
			internal G33_CrystalBeach $self_$36590;
		}
	}

	// Token: 0x0200123D RID: 4669
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExitToColosseum$36592 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006B78 RID: 27512 RVA: 0x00F1EFA8 File Offset: 0x00F1D1A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExitToColosseum$36592(G33_CrystalBeach self_)
		{
			if (117887 - 88995 != 28892)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (288939 - 197991 == 90948)
				{
					base..ctor();
					if (260242 - 204158 == 56084)
					{
						this.$self_$36595 = self_;
						if (88720 - 8712 == 80008)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006B79 RID: 27513 RVA: 0x00F1F040 File Offset: 0x00F1D240
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G33_CrystalBeach.$ExitToColosseum$36592.$(this.$self_$36595);
		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x00F1F050 File Offset: 0x00F1D250
		internal static bool kqZZyNpCiLhDboFimjXi()
		{
			return true;
		}

		// Token: 0x06006B7B RID: 27515 RVA: 0x00F1F054 File Offset: 0x00F1D254
		internal static bool xCwdZIpCKSxFRX4svFQx()
		{
			return false;
		}

		// Token: 0x04007414 RID: 29716
		internal G33_CrystalBeach $self_$36595;

		// Token: 0x0200123E RID: 4670
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006B7C RID: 27516 RVA: 0x00F1F058 File Offset: 0x00F1D258
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G33_CrystalBeach self_)
			{
				if (75830 - 9775 != 66055)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (17372 - 538425 != -521052)
					{
						base..ctor();
						if (570 - 354447 == -353877)
						{
							this.$self_$36594 = self_;
							if (160718 - 257335 == -96617)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006B7D RID: 27517 RVA: 0x00F1F0F0 File Offset: 0x00F1D2F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (169709 - 58457 != 111253)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1E1;
					case 2:
						this.$self_$36594.LeaveTown();
						if (134954 - 431435 != -296481)
						{
							continue;
						}
						this.YieldDefault(1);
						if (72220 - 14671 != 57550)
						{
							goto IL_1E1;
						}
						continue;
					default:
						if (53135 - 114389 != -61254)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (116324 - 571813 == -455489)
					{
						Game.mStateTime = Time.time;
						if (76435 - 148562 == -72127)
						{
							Game.mNextGameId = 506;
							if (53084 - 379674 != -326589)
							{
								Game.mNextGameCode = 56;
								if (281191 - 378963 == -97772)
								{
									this.$mGameGui$36593 = (GameGui)this.$self_$36594.GetComponent(typeof(GameGui));
									if (231778 - 418994 == -187216)
									{
										if (this.$mGameGui$36593)
										{
											if (33626 - 374584 != -340958)
											{
												continue;
											}
											this.$mGameGui$36593.close();
											if (93034 - 517697 == -424662)
											{
												continue;
											}
										}
										this.$self_$36594.SendMessage("fadeOut");
										if (144681 - 99477 == 45204)
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
				IL_1E1:
				return false;
			}

			// Token: 0x06006B7E RID: 27518 RVA: 0x00F1F2F0 File Offset: 0x00F1D4F0
			internal static bool DkwJCcpCdYQSWA51Po6m()
			{
				return true;
			}

			// Token: 0x06006B7F RID: 27519 RVA: 0x00F1F2F4 File Offset: 0x00F1D4F4
			internal static bool yC1eqApCJhYi8l8kesQ8()
			{
				return false;
			}

			// Token: 0x04007415 RID: 29717
			internal GameGui $mGameGui$36593;

			// Token: 0x04007416 RID: 29718
			internal G33_CrystalBeach $self_$36594;
		}
	}
}
