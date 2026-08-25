using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02001217 RID: 4631
[Serializable]
public class G32_SnowCamp : MonoBehaviour
{
	// Token: 0x06006A97 RID: 27287 RVA: 0x00F12490 File Offset: 0x00F10690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public G32_SnowCamp()
	{
		if (43967 - 93836 != -49869)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (207569 - 419737 == -212168)
			{
				base..ctor();
				if (39560 - 342813 == -303253)
				{
					this.rjTcSPnevct = "none";
					if (271742 - 506136 == -234394)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006A98 RID: 27288 RVA: 0x00F1252C File Offset: 0x00F1072C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (142437 - 65611 != 76826)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (91234 - 197617 != -106382)
			{
				Game.mStateTime = Time.time;
				if (89641 - 497537 == -407896)
				{
					if (Chat.Initialized)
					{
						if (49382 - 350627 == -301244)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (179272 - 411264 == -231991)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (57566 - 291706 != -234140)
						{
							continue;
						}
					}
					this.ajQcSNTa2Y1 = (Texture)Resources.Load("GameGui/Title/stage_snow", typeof(Texture));
					if (106182 - 352012 != -245829)
					{
						if (this.ajQcSNTa2Y1)
						{
							break;
						}
						if (161652 - 30550 != 131103)
						{
							Debug.LogError("Cannot find start title");
							if (150657 - 311769 != -161111)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006A99 RID: 27289 RVA: 0x00F1269C File Offset: 0x00F1089C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (227152 - 411376 != -184223)
		{
		}
		for (;;)
		{
			Time.timeScale = 1f;
			if (11165 - 283504 != -272338)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (109923 - 254305 == -144382)
				{
					if (PhotonClient.IsInitialized())
					{
						if (251142 - 529995 == -278853)
						{
							Game.mLastGameCode = Game.mGameCode;
							if (209108 - 43822 == 165286)
							{
								Game.mGameCode = 32;
								if (151828 - 412540 == -260712)
								{
									Game.mGameType = 2;
									if (227652 - 133471 != 94182)
									{
										Game.mGameTime = Time.time;
										if (97576 - 324339 == -226763)
										{
											Game.mGameScore = 0;
											if (60063 - 298387 != -238323)
											{
												Game.mGameMana = 0;
												if (124621 - 187824 == -63203)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (78283 - 353058 != -274774)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (193006 - 337302 == -144296)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (137130 - 168314 != -31183)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (231589 - 350864 == -119275)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (144722 - 156234 != -11511)
																	{
																		this.j9xcSUBhkKi = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (48989 - 399717 != -350727)
																		{
																			this.VjvcSw5G1W4 = PhotonClient.Connection;
																			if (15413 - 174431 == -159018)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (38987 - 49062 == -10075)
																				{
																					this.LoadTown();
																					if (213909 - 449060 != -235150)
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
						if (11237 - 576842 == -565605)
						{
							this.enabled = false;
							if (13282 - 426361 == -413079)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006A9A RID: 27290 RVA: 0x00F129CC File Offset: 0x00F10BCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (206771 - 557689 != -350917)
		{
		}
		for (;;)
		{
			if (this.VjvcSw5G1W4 == null)
			{
				if (181933 - 385306 != -203372)
				{
					break;
				}
			}
			else
			{
				float t = Time.time - Game.mStateTime;
				if (73165 - 213213 == -140048)
				{
					eGameState mGameState = Game.mGameState;
					if (251819 - 345797 == -93978)
					{
						if (mGameState != eGameState.Start)
						{
							if (46845 - 536755 == -489909)
							{
								continue;
							}
							if (mGameState == eGameState.Normal)
							{
								if (17713 - 536188 == -518474)
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
								if (241012 - 349259 != -108247)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, t);
								if (186676 - 9010 != 177667)
								{
									break;
								}
								continue;
							}
						}
						if (Game.music != 0)
						{
							if (3686 - 528403 == -524716)
							{
								continue;
							}
							if (!this.audio.isPlaying)
							{
								if (31897 - 119176 == -87278)
								{
									continue;
								}
								this.audio.Play();
								if (42618 - 598191 == -555572)
								{
									continue;
								}
							}
						}
						if (Time.time - Game.mGameTime < (float)2)
						{
							if (177551 - 156202 != 21350)
							{
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (31463 - 363076 != -331612)
								{
									break;
								}
							}
						}
						else
						{
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (236655 - 64129 == 172526)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006A9B RID: 27291 RVA: 0x00F12C40 File Offset: 0x00F10E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (22530 - 591614 != -569083)
		{
		}
		for (;;)
		{
			if (!this.ajQcSNTa2Y1)
			{
				if (248457 - 20065 == 228392)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Start)
			{
				if (104033 - 408575 == -304542)
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
				if (213648 - 511984 == -298336)
				{
					if (Time.time - Game.mStateTime >= (float)3)
					{
						break;
					}
					if (68523 - 32382 == 36141)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (31633 - 551712 != -520078)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (135777 - 361357 != -225579)
							{
								GUI.depth = 1;
								if (137959 - 528138 != -390178)
								{
									float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4(0.7f, 0.8f, (float)1, 0.4f));
									if (205803 - 52191 != 153613)
									{
										Color color = GUI.color;
										if (214671 - 556413 != -341741)
										{
											color.a = smoothRatioOverTime;
											if (67528 - 565882 == -498354)
											{
												if (51874 - 548657 != -496782)
												{
													Color color2 = GUI.color = color;
													if (239832 - 453636 == -213804)
													{
														if (195414 - 98974 == 96440)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)256, (float)416, (float)512, (float)128), this.ajQcSNTa2Y1);
															if (109825 - 571192 == -461367)
															{
																float a = 1f;
																if (158597 - 236766 != -78168)
																{
																	Color color3 = GUI.color;
																	if (267414 - 488104 != -220689)
																	{
																		color3.a = a;
																		if (106422 - 121181 == -14759)
																		{
																			if (159980 - 190715 == -30735)
																			{
																				Color color4 = GUI.color = color3;
																				if (148455 - 498310 == -349855)
																				{
																					if (230760 - 487067 != -256306)
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

	// Token: 0x06006A9C RID: 27292 RVA: 0x00F12FC0 File Offset: 0x00F111C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTown()
	{
		if (57490 - 334075 != -276584)
		{
		}
		for (;;)
		{
			Debug.Log("Loading Town ");
			if (225973 - 316829 != -90855)
			{
				Hashtable customOpParameters = new Hashtable();
				if (222352 - 509807 != -287454)
				{
					this.VjvcSw5G1W4.OpCustom(43, customOpParameters, true);
					if (230850 - 351051 != -120200)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006A9D RID: 27293 RVA: 0x00F13068 File Offset: 0x00F11268
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadTown(Hashtable data)
	{
		if (262683 - 37029 != 225654)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadTown ");
			if (272166 - 168770 != 103397)
			{
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (265688 - 579935 == -314246)
					{
						continue;
					}
					Chat.SubmitChat("none", "You have joined " + data[31], eChatType.system, eChatMode.system);
					if (112707 - 168270 != -55563)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (145834 - 279690 == -133855)
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
					if (268090 - 51959 == 216132)
					{
						continue;
					}
				}
				if (Game.mLastGameCode != 0)
				{
					if (104065 - 352042 != -247977)
					{
						continue;
					}
					if (Game.mLastGameCode < 100)
					{
						if (145513 - 185687 != -40174)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.SnowCampStartEvent());
						if (202658 - 336092 != -133433)
						{
							break;
						}
						continue;
					}
				}
				GameObject gameObject = GameObject.Find("StartPoint1");
				if (103372 - 333535 != -230162)
				{
					GameObject gameObject2 = GameObject.Find("StartCamera1");
					if (95539 - 432954 != -337414)
					{
						if (gameObject2)
						{
							if (109834 - 122856 == -13021)
							{
								continue;
							}
							this.transform.position = gameObject2.transform.position;
							if (142764 - 545118 == -402353)
							{
								continue;
							}
							this.transform.rotation = gameObject2.transform.rotation;
							if (19736 - 568854 != -549118)
							{
								continue;
							}
						}
						if (gameObject)
						{
							if (23862 - 431629 == -407767)
							{
								this.CreatePlayer(CharacterData.current.CID, gameObject.transform.position, gameObject.transform.forward);
								if (243530 - 142618 == 100912)
								{
									break;
								}
							}
						}
						else
						{
							Debug.Log("Error: Startpoint not found");
							if (122772 - 89517 == 33255)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006A9E RID: 27294 RVA: 0x00F13384 File Offset: 0x00F11584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator SnowCampStartEvent()
	{
		return new G32_SnowCamp.$SnowCampStartEvent$36457(this).GetEnumerator();
	}

	// Token: 0x06006A9F RID: 27295 RVA: 0x00F13394 File Offset: 0x00F11594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new G32_SnowCamp.$TalkToRedPanda$36465(this).GetEnumerator();
	}

	// Token: 0x06006AA0 RID: 27296 RVA: 0x00F133A4 File Offset: 0x00F115A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToIcePenguin(int n)
	{
		return new G32_SnowCamp.$TalkToIcePenguin$36474(this).GetEnumerator();
	}

	// Token: 0x06006AA1 RID: 27297 RVA: 0x00F133B4 File Offset: 0x00F115B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToOwl2()
	{
		if (57131 - 477178 != -420047)
		{
		}
		for (;;)
		{
			if (PlayerData.QuestID == 2)
			{
				if (159397 - 444547 != -285149)
				{
					Q2_HungryXinfu.TalkToLinLin(this.gameObject);
					if (111846 - 563564 == -451718)
					{
						break;
					}
				}
			}
			else if (PlayerData.QuestID == -2)
			{
				if (192956 - 266490 != -73533)
				{
					Q2_HungryXinfu.TalkToLinLinRepeat(this.gameObject);
					if (263229 - 286123 != -22893)
					{
						break;
					}
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (291815 - 530324 == -238509)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (160492 - 262260 != -101767)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (132238 - 208647 == -76409)
					{
						gameGui.close();
						if (284588 - 141372 != 143217)
						{
							ShopGui shopGui = (ShopGui)this.GetComponent(typeof(ShopGui));
							if (12176 - 112650 != -100473)
							{
								shopGui.mType = eShopType.Owl2;
								if (93846 - 289664 == -195818)
								{
									shopGui.enabled = true;
									if (170507 - 247377 == -76870)
									{
										GameObject mPlayer = Game.mPlayer;
										if (164038 - 534743 == -370705)
										{
											GameObject gameObject = GameObject.Find("Owl2");
											if (220063 - 537998 == -317935)
											{
												if (!gameObject)
												{
													break;
												}
												if (104588 - 411477 != -306888)
												{
													if (!mPlayer)
													{
														break;
													}
													if (21032 - 423621 != -402588)
													{
														mPlayer.SendMessage("turnToPos", gameObject.transform.position);
														if (284484 - 279227 == 5257)
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

	// Token: 0x06006AA2 RID: 27298 RVA: 0x00F1365C File Offset: 0x00F1185C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToPilotMole(int n)
	{
		if (266075 - 4334 != 261741)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (148857 - 576507 != -427649)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (267556 - 396453 != -128896)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (149824 - 72446 == 77378)
					{
						if (gameGui)
						{
							if (157128 - 123267 != 33861)
							{
								continue;
							}
							gameGui.close();
							if (67662 - 51804 == 15859)
							{
								continue;
							}
						}
						GameObject gameObject = GameObject.Find("PilotMole");
						if (83752 - 351757 == -268005)
						{
							if (gameObject)
							{
								if (115699 - 538720 == -423020)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (230261 - 296316 != -66055)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find PilotMole");
								if (298794 - 488086 == -189291)
								{
									continue;
								}
							}
							TransportGui transportGui = (TransportGui)this.GetComponent(typeof(TransportGui));
							if (81301 - 297339 == -216038)
							{
								transportGui.enabled = true;
								if (285884 - 421190 == -135306)
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

	// Token: 0x06006AA3 RID: 27299 RVA: 0x00F13850 File Offset: 0x00F11A50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseIceMixer(object mVar)
	{
		return new G32_SnowCamp.$UseIceMixer$36485(this).GetEnumerator();
	}

	// Token: 0x06006AA4 RID: 27300 RVA: 0x00F13860 File Offset: 0x00F11A60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (159349 - 375035 != -215686)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (132679 - 88449 == 44230)
			{
				CharacterControl characterControl = null;
				if (294633 - 175194 == 119439)
				{
					if (mPlayer)
					{
						if (62563 - 346326 != -283763)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (173289 - 449938 == -276648)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (59746 - 220303 != -160556)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (190571 - 183273 != 7299)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (180733 - 483420 == -302687)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (284337 - 391361 == -107023)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (140551 - 338838 == -198286)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (274894 - 533406 != -258512)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (54502 - 207917 != -153415)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (138044 - 175311 != -37266)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (185239 - 321684 == -136445)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (34510 - 45919 == -11409)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (256244 - 189044 == 67200)
								{
									if (!changeGui)
									{
										break;
									}
									if (206918 - 79580 == 127338)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (85277 - 244878 == -159600)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (193777 - 463669 != -269892)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (18551 - 265974 != -247422)
										{
											gameGui.close();
											if (3910 - 396855 != -392944)
											{
												changeGui.enabled = true;
												if (238618 - 281460 != -42841)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (279109 - 519931 != -240821)
													{
														if (!gameObject)
														{
															break;
														}
														if (220298 - 126941 != 93358)
														{
															if (!mPlayer)
															{
																break;
															}
															if (75145 - 66457 != 8689)
															{
																Debug.Log("UseLifeAltar");
																if (201331 - 53603 != 147729)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (201039 - 248927 == -47888)
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

	// Token: 0x06006AA5 RID: 27301 RVA: 0x00F13CC0 File Offset: 0x00F11EC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseMailBox(object mVar)
	{
		if (168569 - 332972 != -164403)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (115550 - 94592 != 20959)
				{
					break;
				}
			}
			else
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (270784 - 203714 != 67071)
				{
					MailBoxGui mailBoxGui = (MailBoxGui)this.GetComponent(typeof(MailBoxGui));
					if (103702 - 113659 == -9957)
					{
						if (!gameGui)
						{
							break;
						}
						if (109218 - 572687 != -463468)
						{
							if (!mailBoxGui)
							{
								break;
							}
							if (89593 - 320931 != -231337)
							{
								Game.mGameState = eGameState.Hold;
								if (7969 - 549074 == -541105)
								{
									gameGui.close();
									if (120242 - 18552 != 101691)
									{
										mailBoxGui.enabled = true;
										if (36594 - 382585 == -345991)
										{
											GameObject mPlayer = Game.mPlayer;
											if (118116 - 394286 == -276170)
											{
												GameObject gameObject = GameObject.Find("MailBox");
												if (248243 - 529186 == -280943)
												{
													if (!gameObject)
													{
														break;
													}
													if (116427 - 67390 == 49037)
													{
														if (!mPlayer)
														{
															break;
														}
														if (57997 - 304937 == -246940)
														{
															mPlayer.SendMessage("turnToPos", gameObject.transform.position);
															if (219816 - 243390 == -23574)
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

	// Token: 0x06006AA6 RID: 27302 RVA: 0x00F13EF4 File Offset: 0x00F120F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseAlchemistLab()
	{
		if (169243 - 68549 != 100694)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (55048 - 525828 != -470779)
				{
					break;
				}
			}
			else if (!Game.mPlayer)
			{
				if (123009 - 328340 != -205330)
				{
					break;
				}
			}
			else
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (256018 - 29272 == 226746)
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (167621 - 351406 != -183784)
					{
						if (characterControl.Type != "Rabbit")
						{
							if (93097 - 324588 != -231490)
							{
								gameGui.newNoticeBar(Language.getMessage("G31_GuildPlain", 601));
								if (225740 - 13004 != 212737)
								{
									break;
								}
							}
						}
						else if (!characterControl.hasSkill(231))
						{
							if (228490 - 32784 != 195707)
							{
								gameGui.newNoticeBar(Language.getMessage("G31_GuildPlain", 602));
								if (10221 - 71112 != -60890)
								{
									break;
								}
							}
						}
						else
						{
							CompoundGui compoundGui = (CompoundGui)this.GetComponent(typeof(CompoundGui));
							if (288721 - 132664 == 156057)
							{
								if (!compoundGui)
								{
									break;
								}
								if (4878 - 571021 == -566143)
								{
									Game.mGameState = eGameState.Hold;
									if (200286 - 530704 != -330417)
									{
										gameGui.close();
										if (274641 - 24756 != 249886)
										{
											compoundGui.mType = eCompoundType.Rabbit;
											if (43343 - 106466 == -63123)
											{
												compoundGui.enabled = true;
												if (218377 - 292845 == -74468)
												{
													Game.mPlayer.SendMessage("turnToPos", new Vector3(-37.5f, (float)51, 31.3f));
													if (123777 - 61434 != 62344)
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

	// Token: 0x06006AA7 RID: 27303 RVA: 0x00F141C0 File Offset: 0x00F123C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseEngineerLab()
	{
		if (221613 - 340383 != -118770)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (211375 - 543950 == -332575)
				{
					break;
				}
			}
			else if (!Game.mPlayer)
			{
				if (83351 - 33681 == 49670)
				{
					break;
				}
			}
			else
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (244038 - 349628 != -105589)
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (119589 - 183746 != -64156)
					{
						if (characterControl.Type != "Mole")
						{
							if (189717 - 383242 == -193525)
							{
								gameGui.newNoticeBar(Language.getMessage("G31_GuildPlain", 701));
								if (176349 - 51088 == 125261)
								{
									break;
								}
							}
						}
						else if (!characterControl.hasSkill(121))
						{
							if (216765 - 483023 == -266258)
							{
								gameGui.newNoticeBar(Language.getMessage("G31_GuildPlain", 702));
								if (143033 - 25979 == 117054)
								{
									break;
								}
							}
						}
						else
						{
							CompoundGui compoundGui = (CompoundGui)this.GetComponent(typeof(CompoundGui));
							if (95108 - 211223 != -116114)
							{
								if (!compoundGui)
								{
									break;
								}
								if (63537 - 75366 == -11829)
								{
									Game.mGameState = eGameState.Hold;
									if (144541 - 568074 == -423533)
									{
										gameGui.close();
										if (180773 - 215909 == -35136)
										{
											compoundGui.mType = eCompoundType.Mole;
											if (208915 - 144436 == 64479)
											{
												compoundGui.enabled = true;
												if (38916 - 376708 == -337792)
												{
													Game.mPlayer.SendMessage("turnToPos", new Vector3(-33.8f, (float)51, (float)34));
													if (223522 - 123455 == 100067)
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

	// Token: 0x06006AA8 RID: 27304 RVA: 0x00F14488 File Offset: 0x00F12688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseStorageBox(object mVar)
	{
		return new G32_SnowCamp.$UseStorageBox$36492(this).GetEnumerator();
	}

	// Token: 0x06006AA9 RID: 27305 RVA: 0x00F14498 File Offset: 0x00F12698
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(int nVar)
	{
		return new G32_SnowCamp.$UseSignPost$36499(this).GetEnumerator();
	}

	// Token: 0x06006AAA RID: 27306 RVA: 0x00F144A8 File Offset: 0x00F126A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseTrashBin(object mVar)
	{
		return new G32_SnowCamp.$UseTrashBin$36502(this).GetEnumerator();
	}

	// Token: 0x06006AAB RID: 27307 RVA: 0x00F144B8 File Offset: 0x00F126B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetTrash()
	{
		if (188086 - 88894 != 99193)
		{
		}
		for (;;)
		{
			Debug.Log("GetTrash");
			if (209993 - 43577 == 166416)
			{
				this.OeQcSS2SrNl = false;
				if (38503 - 68558 != -30054)
				{
					this.rjTcSPnevct = "none";
					if (81432 - 444922 == -363490)
					{
						Hashtable customOpParameters = new Hashtable();
						if (97551 - 592145 == -494594)
						{
							this.VjvcSw5G1W4.OpCustom(224, customOpParameters, true);
							if (87507 - 550040 == -462533)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006AAC RID: 27308 RVA: 0x00F145A8 File Offset: 0x00F127A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGetTrash(Hashtable data)
	{
		if (59445 - 536862 != -477416)
		{
		}
		while (RuntimeServices.EqualityOperator(data[31], 1))
		{
			if (118095 - 317597 == -199502)
			{
				this.OeQcSS2SrNl = true;
				if (23019 - 159733 != -136713)
				{
					object obj2;
					object obj = obj2 = data[32];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					this.rjTcSPnevct = ItemData.getName((string)obj2);
					if (255371 - 554062 == -298691)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006AAD RID: 27309 RVA: 0x00F1468C File Offset: 0x00F1288C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseMessageBoard(object mVar)
	{
		return new G32_SnowCamp.$UseMessageBoard$36507(this).GetEnumerator();
	}

	// Token: 0x06006AAE RID: 27310 RVA: 0x00F1469C File Offset: 0x00F1289C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, Vector3 pos, Vector3 dir)
	{
		if (142250 - 202013 != -59762)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (147382 - 66503 != 80880)
			{
				hashtable.Add(71, CID);
				if (65225 - 246903 == -181678)
				{
					hashtable.Add(75, PhotonClient.cInt16(1));
					if (43463 - 201746 == -158283)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (208859 - 75059 == 133800)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (265836 - 301380 == -35544)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (120217 - 155877 == -35660)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (271402 - 110776 != 160627)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (220010 - 359982 != -139971)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (281621 - 385495 == -103874)
											{
												this.VjvcSw5G1W4.OpCustom(61, hashtable, true);
												if (97506 - 100984 == -3478)
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

	// Token: 0x06006AAF RID: 27311 RVA: 0x00F14928 File Offset: 0x00F12B28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePlayer(Hashtable data)
	{
		return new G32_SnowCamp.$onCreatePlayer$36514(data, this).GetEnumerator();
	}

	// Token: 0x06006AB0 RID: 27312 RVA: 0x00F14938 File Offset: 0x00F12B38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (106948 - 197161 != -90213)
		{
		}
		for (;;)
		{
			IL_3C:
			GameObject gameObject = Game.createPeer(data);
			if (20842 - 188286 == -167444)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (263296 - 431337 == -168041)
				{
					int i = 0;
					if (131499 - 599805 != -468305)
					{
						GameObject[] array2 = array;
						if (238468 - 22125 != 216344)
						{
							int length = array2.Length;
							if (52297 - 55381 == -3084)
							{
								while (i < length)
								{
									if (gameObject != array2[i])
									{
										if (286607 - 519792 != -233185)
										{
											goto IL_3C;
										}
										Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
										if (92316 - 97652 != -5336)
										{
											goto IL_3C;
										}
									}
									i++;
									if (166608 - 578302 != -411694)
									{
										goto IL_3C;
									}
								}
								if (243093 - 75045 == 168048)
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

	// Token: 0x06006AB1 RID: 27313 RVA: 0x00F14AB0 File Offset: 0x00F12CB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPlayer()
	{
		Game.mPlayerID = 0;
	}

	// Token: 0x06006AB2 RID: 27314 RVA: 0x00F14AB8 File Offset: 0x00F12CB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
	}

	// Token: 0x06006AB3 RID: 27315 RVA: 0x00F14ABC File Offset: 0x00F12CBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (225817 - 310128 != -84310)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (123331 - 141237 == -17906)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (189722 - 133561 != 56162)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (226922 - 182655 != 44268)
					{
						Hashtable hashtable = new Hashtable();
						if (132195 - 407832 == -275637)
						{
							hashtable.Add(43, PlayerData.UID);
							if (240626 - 469972 == -229346)
							{
								hashtable.Add(71, nCID);
								if (230992 - 388723 != -157730)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (152854 - 410966 != -258111)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (27969 - 546943 == -518974)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (166144 - 275166 == -109022)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (269597 - 224437 != 45161)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (87991 - 524181 != -436189)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (128716 - 353411 == -224695)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (78578 - 367945 != -289366)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (269625 - 471840 != -202214)
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

	// Token: 0x06006AB4 RID: 27316 RVA: 0x00F14DDC File Offset: 0x00F12FDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onChangePlayer(Hashtable data)
	{
		if (246492 - 482671 != -236178)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Destroy(Game.mPlayer);
			if (116300 - 21440 == 94860)
			{
				this.SendMessage("onCreatePlayer", data);
				if (249204 - 167941 != 81264)
				{
					ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
					if (31146 - 574654 != -543507)
					{
						if (!changeGui.enabled)
						{
							break;
						}
						if (273040 - 196478 == 76562)
						{
							changeGui.close();
							if (9166 - 62809 == -53643)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006AB5 RID: 27317 RVA: 0x00F14ED4 File Offset: 0x00F130D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(GameObject nMount)
	{
		if (166212 - 522135 != -355923)
		{
		}
		for (;;)
		{
			IL_10F:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
			if (143658 - 213534 != -69875)
			{
				int i = 0;
				if (48795 - 541410 == -492615)
				{
					GameObject[] array2 = array;
					if (139661 - 163521 != -23859)
					{
						int length = array2.Length;
						if (162928 - 340798 == -177870)
						{
							while (i < length)
							{
								if (nMount != array2[i])
								{
									if (30539 - 496145 != -465606)
									{
										goto IL_10F;
									}
									Physics.IgnoreCollision(nMount.collider, array2[i].collider, true);
									if (193313 - 462128 == -268814)
									{
										goto IL_10F;
									}
								}
								i++;
								if (12394 - 72243 != -59849)
								{
									goto IL_10F;
								}
							}
							if (98060 - 459691 == -361631)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006AB6 RID: 27318 RVA: 0x00F15028 File Offset: 0x00F13228
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveTown()
	{
		if (179418 - 525286 != -345868)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (105603 - 55308 == 50295)
			{
				hashtable.Add(43, PlayerData.UID);
				if (99016 - 534005 != -434988)
				{
					PhotonClient.Connection.OpCustom(44, hashtable, true);
					if (16476 - 409016 != -392539)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006AB7 RID: 27319 RVA: 0x00F150DC File Offset: 0x00F132DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveTown()
	{
		if (49853 - 147338 != -97485)
		{
		}
		for (;;)
		{
			Debug.Log("onLeaveTown");
			if (59149 - 180961 == -121812)
			{
				if (Game.mNextGameCode > 100)
				{
					if (43336 - 517050 == -473714)
					{
						this.JoinGame();
						if (57027 - 454720 != -397692)
						{
							break;
						}
					}
				}
				else
				{
					this.JoinTown();
					if (115968 - 66545 == 49423)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006AB8 RID: 27320 RVA: 0x00F151A4 File Offset: 0x00F133A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (60722 - 456797 != -396074)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (149526 - 460218 == -310692)
			{
				Hashtable hashtable = new Hashtable();
				if (205515 - 48962 != 156554)
				{
					if (Game.mNextGameCode == 30)
					{
						if (19690 - 154733 == -135042)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (27446 - 256258 == -228811)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (128122 - 91201 == 36922)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (74784 - 573425 != -498641)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (235246 - 263425 != -28179)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (99803 - 258843 != -159040)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (216626 - 435773 == -219146)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (273205 - 316778 == -43572)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (11973 - 577153 == -565179)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (211391 - 6939 == 204453)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (133834 - 520667 != -386833)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (295263 - 103318 == 191946)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (233581 - 353019 != -119438)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (252299 - 313910 == -61610)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (246996 - 208026 != 38970)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (274999 - 40657 != 234342)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (1890 - 447220 == -445329)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (83503 - 375300 == -291796)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (202688 - 542316 != -339628)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (57415 - 118205 == -60789)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (94455 - 348197 != -253742)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (147832 - 598645 != -450813)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (51322 - 239532 != -188210)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (128792 - 61116 != 67676)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (102398 - 7030 != 95368)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (94555 - 29844 != 64711)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (267912 - 123058 != 144854)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (54610 - 134496 != -79886)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (234931 - 96821 != 138111)
					{
						this.VjvcSw5G1W4.OpCustom(42, hashtable, true);
						if (96106 - 202292 != -106185)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006AB9 RID: 27321 RVA: 0x00F15758 File Offset: 0x00F13958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06006ABA RID: 27322 RVA: 0x00F15768 File Offset: 0x00F13968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinGame()
	{
		if (70172 - 550765 != -480592)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Game : " + Game.mNextGameId);
			if (97618 - 231166 != -133547)
			{
				Hashtable hashtable = new Hashtable();
				if (86405 - 270938 != -184532)
				{
					hashtable.Add(4, Game.mNextGameId);
					if (124520 - 596009 != -471488)
					{
						hashtable.Add(5, PhotonClient.cInt16(Game.mNextGameCode));
						if (53214 - 172795 != -119580)
						{
							this.VjvcSw5G1W4.OpCustom(51, hashtable, true);
							if (57021 - 213817 == -156796)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006ABB RID: 27323 RVA: 0x00F15884 File Offset: 0x00F13A84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinGame(Hashtable data)
	{
		Game.loadNextLevel();
	}

	// Token: 0x06006ABC RID: 27324 RVA: 0x00F1588C File Offset: 0x00F13A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006ABD RID: 27325 RVA: 0x00F15890 File Offset: 0x00F13A90
	internal static bool QKCvkRpZ2ey7Yfv7g73O()
	{
		return true;
	}

	// Token: 0x06006ABE RID: 27326 RVA: 0x00F15894 File Offset: 0x00F13A94
	internal static bool UT4bWIpZ8Nf2CtPamXJ5()
	{
		return false;
	}

	// Token: 0x04007393 RID: 29587
	private LitePeer VjvcSw5G1W4;

	// Token: 0x04007394 RID: 29588
	private PlayerCameraControl j9xcSUBhkKi;

	// Token: 0x04007395 RID: 29589
	private Texture ajQcSNTa2Y1;

	// Token: 0x04007396 RID: 29590
	private AudioClip BiZcSEQ63JH;

	// Token: 0x04007397 RID: 29591
	private string rjTcSPnevct;

	// Token: 0x04007398 RID: 29592
	private bool OeQcSS2SrNl;

	// Token: 0x02001218 RID: 4632
	[CompilerGenerated]
	[Serializable]
	internal sealed class $SnowCampStartEvent$36457 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006ABF RID: 27327 RVA: 0x00F15898 File Offset: 0x00F13A98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $SnowCampStartEvent$36457(G32_SnowCamp self_)
		{
			if (112637 - 554290 != -441653)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (104204 - 469611 != -365406)
				{
					base..ctor();
					if (600 - 15066 == -14466)
					{
						this.$self_$36464 = self_;
						if (90159 - 198861 != -108701)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006AC0 RID: 27328 RVA: 0x00F15930 File Offset: 0x00F13B30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G32_SnowCamp.$SnowCampStartEvent$36457.$(this.$self_$36464);
		}

		// Token: 0x06006AC1 RID: 27329 RVA: 0x00F15940 File Offset: 0x00F13B40
		internal static bool xSk7HfpZZWUqATgc7jXj()
		{
			return true;
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x00F15944 File Offset: 0x00F13B44
		internal static bool tKt0bmpZCduYnmdaGWbH()
		{
			return false;
		}

		// Token: 0x04007399 RID: 29593
		internal G32_SnowCamp $self_$36464;

		// Token: 0x02001219 RID: 4633
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006AC3 RID: 27331 RVA: 0x00F15948 File Offset: 0x00F13B48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G32_SnowCamp self_)
			{
				if (274074 - 292266 != -18191)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (226748 - 102780 != 123969)
					{
						base..ctor();
						if (195255 - 356196 == -160941)
						{
							this.$self_$36463 = self_;
							if (297472 - 399778 != -102305)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006AC4 RID: 27332 RVA: 0x00F159E0 File Offset: 0x00F13BE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (196141 - 233106 != -36965)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_501;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (8149 - 179450 != -171300)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$self_$36463.SendMessage("fadeOut");
							if (120118 - 454765 != -334646)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState == eGameState.Start)
						{
							goto IL_25D;
						}
						if (34160 - 284578 != -250417)
						{
							goto Block_20;
						}
						continue;
					default:
						if (273086 - 413317 == -140230)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (96702 - 599322 == -502619)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (113906 - 62685 != 51221)
					{
						continue;
					}
					this.$mEventCamera1$36458 = GameObject.Find("EventCamera1");
					if (10876 - 568817 == -557940)
					{
						continue;
					}
					this.$mEventCamera2$36459 = GameObject.Find("EventCamera2");
					if (124078 - 76658 == 47421)
					{
						continue;
					}
					if (this.$mEventCamera1$36458)
					{
						if (150665 - 531222 == -380556)
						{
							continue;
						}
						if (this.$mEventCamera2$36459)
						{
							if (62273 - 148498 == -86224)
							{
								continue;
							}
							this.$self_$36463.transform.position = this.$mEventCamera1$36458.transform.position;
							if (77118 - 249037 != -171919)
							{
								continue;
							}
							this.$self_$36463.transform.rotation = this.$mEventCamera1$36458.transform.rotation;
							if (273825 - 519482 != -245657)
							{
								continue;
							}
							this.$mPlayerCameraControl$36460 = (PlayerCameraControl)this.$self_$36463.GetComponent(typeof(PlayerCameraControl));
							if (293049 - 155432 != 137617)
							{
								continue;
							}
							if (this.$mPlayerCameraControl$36460)
							{
								if (278878 - 361152 != -82274)
								{
									continue;
								}
								this.$mPlayerCameraControl$36460.StartCoroutine_Auto(this.$mPlayerCameraControl$36460.slerpToObject("EventCamera2", 2f));
								if (106953 - 242593 == -135639)
								{
									continue;
								}
							}
							this.$self_$36463.SendMessage("fadeIn");
							if (66862 - 152431 != -85568)
							{
								goto Block_21;
							}
							continue;
						}
					}
					Debug.LogError("Cannot find EventCamera1 or EventCamera2");
					if (63759 - 71429 != -7670)
					{
						continue;
					}
					IL_25D:
					this.$startPoint$36461 = GameObject.Find("StartPoint2");
					if (128355 - 73906 != 54450)
					{
						this.$startCamera$36462 = GameObject.Find("StartCamera2");
						if (97651 - 4213 == 93438)
						{
							if (this.$startCamera$36462)
							{
								if (115020 - 340292 == -225271)
								{
									continue;
								}
								this.$self_$36463.transform.position = this.$startCamera$36462.transform.position;
								if (213170 - 531174 != -318004)
								{
									continue;
								}
								this.$self_$36463.transform.rotation = this.$startCamera$36462.transform.rotation;
								if (123606 - 529394 != -405788)
								{
									continue;
								}
							}
							if (this.$startPoint$36461)
							{
								if (256967 - 225795 == 31173)
								{
									continue;
								}
								this.$self_$36463.CreatePlayer(CharacterData.current.CID, this.$startPoint$36461.transform.position, this.$startPoint$36461.transform.forward);
								if (276689 - 31684 == 245006)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Error: Startpoint not found");
								if (277483 - 517640 != -240157)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (28414 - 444277 == -415863)
							{
								goto IL_501;
							}
						}
					}
				}
				Block_16:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_20:
				goto IL_501;
				Block_21:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_24:
				IL_501:
				return false;
			}

			// Token: 0x06006AC5 RID: 27333 RVA: 0x00F15F00 File Offset: 0x00F14100
			internal static bool ICrJ9spZLitdXYyOXRi0()
			{
				return true;
			}

			// Token: 0x06006AC6 RID: 27334 RVA: 0x00F15F04 File Offset: 0x00F14104
			internal static bool hQ080DpZOnF8mYIRv6wk()
			{
				return false;
			}

			// Token: 0x0400739A RID: 29594
			internal GameObject $mEventCamera1$36458;

			// Token: 0x0400739B RID: 29595
			internal GameObject $mEventCamera2$36459;

			// Token: 0x0400739C RID: 29596
			internal PlayerCameraControl $mPlayerCameraControl$36460;

			// Token: 0x0400739D RID: 29597
			internal GameObject $startPoint$36461;

			// Token: 0x0400739E RID: 29598
			internal GameObject $startCamera$36462;

			// Token: 0x0400739F RID: 29599
			internal G32_SnowCamp $self_$36463;
		}
	}

	// Token: 0x0200121A RID: 4634
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$36465 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006AC7 RID: 27335 RVA: 0x00F15F08 File Offset: 0x00F14108
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$36465(G32_SnowCamp self_)
		{
			if (119823 - 432332 != -312508)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (284816 - 248737 != 36080)
				{
					base..ctor();
					if (24909 - 446223 != -421313)
					{
						this.$self_$36473 = self_;
						if (294374 - 530446 == -236072)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x00F15FA0 File Offset: 0x00F141A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G32_SnowCamp.$TalkToRedPanda$36465.$(this.$self_$36473);
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x00F15FB0 File Offset: 0x00F141B0
		internal static bool rE7kpUpZmI5sb46pi8BS()
		{
			return true;
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x00F15FB4 File Offset: 0x00F141B4
		internal static bool FY2DufpZFPe9HbeFZOOA()
		{
			return false;
		}

		// Token: 0x040073A0 RID: 29600
		internal G32_SnowCamp $self_$36473;

		// Token: 0x0200121B RID: 4635
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006ACB RID: 27339 RVA: 0x00F15FB8 File Offset: 0x00F141B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G32_SnowCamp self_)
			{
				if (274055 - 511874 != -237819)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (173826 - 372042 == -198216)
					{
						base..ctor();
						if (293940 - 467939 != -173998)
						{
							this.$self_$36472 = self_;
							if (201095 - 571555 == -370460)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006ACC RID: 27340 RVA: 0x00F16050 File Offset: 0x00F14250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (200544 - 344089 != -143544)
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
						this.$mStoryGui$36470.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("MissionGui", 306 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
						if (199144 - 231216 == -32071)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) == 0)
						{
							goto IL_2CC;
						}
						if (64201 - 528316 != -464115)
						{
							continue;
						}
						if (!this.$self_$36472.BiZcSEQ63JH)
						{
							if (22042 - 231848 != -209806)
							{
								continue;
							}
							this.$self_$36472.BiZcSEQ63JH = (AudioClip)Resources.Load("Sound/Voice/mission306_vc", typeof(AudioClip));
							if (63863 - 215906 != -152043)
							{
								continue;
							}
						}
						if (this.$self_$36472.BiZcSEQ63JH)
						{
							if (276622 - 81526 == 195097)
							{
								continue;
							}
							this.$self_$36472.audio.PlayOneShot(this.$self_$36472.BiZcSEQ63JH);
							if (197960 - 106200 != 91760)
							{
								continue;
							}
							goto IL_2A3;
						}
						else
						{
							Debug.LogError("Missing mission306 voice");
							if (200537 - 249966 != -49428)
							{
								goto IL_2CC;
							}
							continue;
						}
						break;
					case 3:
						this.$mStoryGui$36470.close();
						if (78967 - 545710 == -466742)
						{
							continue;
						}
						this.$mGameGui$36466.enabled = true;
						if (202610 - 588867 != -386257)
						{
							continue;
						}
						goto IL_3CA;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (54618 - 389047 != -334429)
						{
							continue;
						}
						goto IL_1A;
					default:
						if (96169 - 574679 == -478509)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (38975 - 577858 != -538882)
						{
							goto Block_32;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (283363 - 450972 != -167609)
						{
							continue;
						}
						this.$mGameGui$36466 = (GameGui)this.$self_$36472.GetComponent(typeof(GameGui));
						if (264351 - 291458 == -27106)
						{
							continue;
						}
						this.$mChangeGui$36467 = (ChangeGui)this.$self_$36472.GetComponent(typeof(ChangeGui));
						if (252847 - 347296 != -94449)
						{
							continue;
						}
						if (this.$mGameGui$36466)
						{
							if (225781 - 31470 == 194312)
							{
								continue;
							}
							this.$mGameGui$36466.close();
							if (212120 - 79485 != 132635)
							{
								continue;
							}
						}
						if (this.$mChangeGui$36467)
						{
							if (86031 - 561109 == -475077)
							{
								continue;
							}
							this.$mChangeGui$36467.disable();
							if (225085 - 466692 != -241607)
							{
								continue;
							}
						}
						this.$mPlayer$36468 = Game.mPlayer;
						if (15159 - 206266 == -191106)
						{
							continue;
						}
						this.$mRedPanda$36469 = GameObject.Find("RedPanda");
						if (131031 - 74828 == 56204)
						{
							continue;
						}
						if (!this.$mRedPanda$36469)
						{
							goto IL_5B3;
						}
						if (173150 - 296984 == -123833)
						{
							continue;
						}
						if (!this.$mPlayer$36468)
						{
							goto IL_5B3;
						}
						if (34128 - 312074 == -277945)
						{
							continue;
						}
						this.$mPlayer$36468.SendMessage("turnToPos", this.$mRedPanda$36469.transform.position);
						if (25214 - 569504 == -544289)
						{
							continue;
						}
						IL_27D:
						if (PlayerData.SLv <= 14)
						{
							if (80915 - 151114 != -70199)
							{
								continue;
							}
							this.$mStoryGui$36470 = (StoryGui)this.$self_$36472.GetComponent(typeof(StoryGui));
							if (22152 - 122846 != -100694)
							{
								continue;
							}
							if (!this.$mStoryGui$36470)
							{
								goto IL_1A;
							}
							if (15378 - 86978 != -71600)
							{
								continue;
							}
							this.$mStoryGui$36470.startStoryMessage("RedPandaSit", "RedPanda", eTalkType.friend);
							if (72358 - 480529 != -408170)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							this.$mMissionGui$36471 = (MissionGui)this.$self_$36472.GetComponent(typeof(MissionGui));
							if (1893 - 571876 == -569982)
							{
								continue;
							}
							if (!this.$mMissionGui$36471)
							{
								goto IL_4D9;
							}
							if (280346 - 6887 != 273459)
							{
								continue;
							}
							this.$mMissionGui$36471.mType = eMissionGuiType.guild;
							if (24377 - 109325 != -84948)
							{
								continue;
							}
							this.$mMissionGui$36471.enabled = true;
							if (7082 - 282983 != -275901)
							{
								continue;
							}
							goto IL_4D9;
						}
						IL_5B3:
						Debug.LogError("Cannot find RedPanda");
						if (156519 - 414329 != -257809)
						{
							goto IL_27D;
						}
						continue;
					}
					IL_4D9:
					this.YieldDefault(1);
					if (120564 - 139650 != -19085)
					{
						goto Block_37;
					}
					continue;
					IL_1A:
					goto IL_4D9;
				}
				IL_2A3:
				IL_2CC:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_3CA:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_32:
				Block_37:
				goto IL_664;
				Block_39:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_664:
				return false;
			}

			// Token: 0x06006ACD RID: 27341 RVA: 0x00F166D4 File Offset: 0x00F148D4
			internal static bool BXBuZ7pZMebtapMCVXcy()
			{
				return true;
			}

			// Token: 0x06006ACE RID: 27342 RVA: 0x00F166D8 File Offset: 0x00F148D8
			internal static bool zaJh77pZx6jHmHGsgZZw()
			{
				return false;
			}

			// Token: 0x040073A1 RID: 29601
			internal GameGui $mGameGui$36466;

			// Token: 0x040073A2 RID: 29602
			internal ChangeGui $mChangeGui$36467;

			// Token: 0x040073A3 RID: 29603
			internal GameObject $mPlayer$36468;

			// Token: 0x040073A4 RID: 29604
			internal GameObject $mRedPanda$36469;

			// Token: 0x040073A5 RID: 29605
			internal StoryGui $mStoryGui$36470;

			// Token: 0x040073A6 RID: 29606
			internal MissionGui $mMissionGui$36471;

			// Token: 0x040073A7 RID: 29607
			internal G32_SnowCamp $self_$36472;
		}
	}

	// Token: 0x0200121C RID: 4636
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToIcePenguin$36474 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006ACF RID: 27343 RVA: 0x00F166DC File Offset: 0x00F148DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToIcePenguin$36474(G32_SnowCamp self_)
		{
			if (259935 - 454391 != -194456)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (10969 - 402641 != -391671)
				{
					base..ctor();
					if (160309 - 231869 == -71560)
					{
						this.$self_$36484 = self_;
						if (9929 - 529351 == -519422)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x00F16774 File Offset: 0x00F14974
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G32_SnowCamp.$TalkToIcePenguin$36474.$(this.$self_$36484);
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x00F16784 File Offset: 0x00F14984
		internal static bool cMGyrXpZgDSXVxIhGXy8()
		{
			return true;
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x00F16788 File Offset: 0x00F14988
		internal static bool hEvTbdpZfPiOO3u4rXSc()
		{
			return false;
		}

		// Token: 0x040073A8 RID: 29608
		internal G32_SnowCamp $self_$36484;

		// Token: 0x0200121D RID: 4637
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006AD3 RID: 27347 RVA: 0x00F1678C File Offset: 0x00F1498C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G32_SnowCamp self_)
			{
				if (161635 - 99676 != 61960)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (196484 - 155692 != 40793)
					{
						base..ctor();
						if (92087 - 449890 != -357802)
						{
							this.$self_$36483 = self_;
							if (207649 - 209866 == -2217)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006AD4 RID: 27348 RVA: 0x00F16824 File Offset: 0x00F14A24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (539 - 379294 != -378755)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_634;
					case 1:
						goto IL_765;
					case 2:
						this.$mStoryGui$36480.newStoryMessage("IcePenguin", "IcePenguin", Language.getMessage("MissionGui", 1231 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
						if (204497 - 270019 != -65522)
						{
							continue;
						}
						this.$mStoryTimer$36481 = Time.time + 4f;
						if (260243 - 285082 != -24838)
						{
							goto Block_23;
						}
						continue;
					case 3:
						goto IL_3AF;
					case 4:
						goto IL_3AF;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (298162 - 556755 != -258593)
							{
								continue;
							}
							goto IL_22A;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (87711 - 452751 == -365039)
							{
								continue;
							}
						}
						break;
					default:
						if (13838 - 386723 != -372885)
						{
							continue;
						}
						goto IL_634;
					}
					IL_73:
					this.YieldDefault(1);
					if (132164 - 385128 != -252963)
					{
						break;
					}
					continue;
					IL_3AF:
					if (this.$mStoryTimer$36481 > Time.time)
					{
						if (232805 - 304003 != -71198)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3A3;
						}
						if (94573 - 521081 != -426508)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (130777 - 376943 != -246166)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$36480.close();
						if (295769 - 206243 != 89526)
						{
							continue;
						}
						this.$mGameGui$36475.enabled = true;
						if (50980 - 468948 == -417967)
						{
							continue;
						}
						if (!this.$mIcePenguin$36478)
						{
							goto IL_1B2;
						}
						if (38227 - 29455 == 8773)
						{
							continue;
						}
						this.$mIcePenguin$36478.animation.CrossFade("root", 0.2f);
						if (187895 - 278568 != -90672)
						{
							goto Block_51;
						}
						continue;
					}
					IL_634:
					if (Game.mGameState != eGameState.Normal)
					{
						if (62852 - 164564 == -101712)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (271941 - 484610 == -212669)
						{
							this.$mGameGui$36475 = (GameGui)this.$self_$36483.GetComponent(typeof(GameGui));
							if (187747 - 145298 != 42450)
							{
								this.$mChangeGui$36476 = (ChangeGui)this.$self_$36483.GetComponent(typeof(ChangeGui));
								if (220905 - 404667 == -183762)
								{
									if (this.$mGameGui$36475)
									{
										if (268646 - 199498 == 69149)
										{
											continue;
										}
										this.$mGameGui$36475.close();
										if (211217 - 391735 != -180518)
										{
											continue;
										}
									}
									if (this.$mChangeGui$36476)
									{
										if (32977 - 157823 == -124845)
										{
											continue;
										}
										this.$mChangeGui$36476.disable();
										if (100074 - 246923 != -146849)
										{
											continue;
										}
									}
									this.$mPlayer$36477 = Game.mPlayer;
									if (248992 - 405183 == -156191)
									{
										this.$mIcePenguin$36478 = GameObject.Find("IcePenguin");
										if (39140 - 141983 != -102842)
										{
											this.$mIcePenguinOriginalDir$36479 = default(Vector3);
											if (241423 - 516104 == -274681)
											{
												if (this.$mIcePenguin$36478)
												{
													if (109835 - 336329 == -226493)
													{
														continue;
													}
													if (this.$mPlayer$36477)
													{
														if (26608 - 313316 != -286708)
														{
															continue;
														}
														this.$mIcePenguin$36478.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$36477.transform.position - this.$mIcePenguin$36478.transform.position));
														if (217246 - 21198 == 196049)
														{
															continue;
														}
														this.$mIcePenguin$36478.animation.CrossFade("talk", 0.2f);
														if (98388 - 587825 != -489437)
														{
															continue;
														}
														this.$mPlayer$36477.SendMessage("turnToPos", this.$mIcePenguin$36478.transform.position);
														if (184443 - 238203 != -53760)
														{
															continue;
														}
													}
												}
												this.$mStoryGui$36480 = (StoryGui)this.$self_$36483.GetComponent(typeof(StoryGui));
												if (224125 - 709 == 223416)
												{
													this.$mStoryTimer$36481 = 0f;
													if (99900 - 531971 != -432070)
													{
														if (PlayerData.SLv >= 55)
														{
															if (292311 - 192170 != 100141)
															{
																continue;
															}
															if (CharacterData.current.lv >= 50)
															{
																if (66853 - 159872 == -93018)
																{
																	continue;
																}
																if (CharacterData.current.getItemTotalNum("k_dun2") < 1)
																{
																	if (125188 - 116995 != 8193)
																	{
																		continue;
																	}
																}
																else
																{
																	this.$mMissionGui$36482 = (MissionGui)this.$self_$36483.GetComponent(typeof(MissionGui));
																	if (101851 - 514446 == -412594)
																	{
																		continue;
																	}
																	if (!this.$mMissionGui$36482)
																	{
																		goto IL_73;
																	}
																	if (89638 - 201066 == -111427)
																	{
																		continue;
																	}
																	this.$mMissionGui$36482.mType = eMissionGuiType.dungeon;
																	if (282025 - 193723 == 88303)
																	{
																		continue;
																	}
																	this.$mMissionGui$36482.enabled = true;
																	if (274840 - 205135 != 69706)
																	{
																		goto IL_73;
																	}
																	continue;
																}
															}
														}
														this.$mStoryGui$36480.startStoryMessage("IcePenguin", "IcePenguin", eTalkType.friend);
														if (136327 - 302792 == -166465)
														{
															goto IL_49D;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_765;
				IL_1B2:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_22A:
				goto IL_765;
				Block_23:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_3A3:
				return this.YieldDefault(4);
				IL_49D:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_765;
				Block_51:
				goto IL_1B2;
				IL_765:
				return false;
			}

			// Token: 0x06006AD5 RID: 27349 RVA: 0x00F16FA8 File Offset: 0x00F151A8
			internal static bool DfiqHapZnX29GRZaHAJk()
			{
				return true;
			}

			// Token: 0x06006AD6 RID: 27350 RVA: 0x00F16FAC File Offset: 0x00F151AC
			internal static bool N6dG5vpZ6dqQeNvpfLG0()
			{
				return false;
			}

			// Token: 0x040073A9 RID: 29609
			internal GameGui $mGameGui$36475;

			// Token: 0x040073AA RID: 29610
			internal ChangeGui $mChangeGui$36476;

			// Token: 0x040073AB RID: 29611
			internal GameObject $mPlayer$36477;

			// Token: 0x040073AC RID: 29612
			internal GameObject $mIcePenguin$36478;

			// Token: 0x040073AD RID: 29613
			internal Vector3 $mIcePenguinOriginalDir$36479;

			// Token: 0x040073AE RID: 29614
			internal StoryGui $mStoryGui$36480;

			// Token: 0x040073AF RID: 29615
			internal float $mStoryTimer$36481;

			// Token: 0x040073B0 RID: 29616
			internal MissionGui $mMissionGui$36482;

			// Token: 0x040073B1 RID: 29617
			internal G32_SnowCamp $self_$36483;
		}
	}

	// Token: 0x0200121E RID: 4638
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseIceMixer$36485 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006AD7 RID: 27351 RVA: 0x00F16FB0 File Offset: 0x00F151B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseIceMixer$36485(G32_SnowCamp self_)
		{
			if (181347 - 493328 != -311981)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (130002 - 23963 != 106040)
				{
					base..ctor();
					if (46133 - 122276 != -76142)
					{
						this.$self_$36491 = self_;
						if (261786 - 21182 == 240604)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x00F17048 File Offset: 0x00F15248
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G32_SnowCamp.$UseIceMixer$36485.$(this.$self_$36491);
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x00F17058 File Offset: 0x00F15258
		internal static bool ejkTlLpZiqq355SjV4Sm()
		{
			return true;
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x00F1705C File Offset: 0x00F1525C
		internal static bool x0af0WpZKZdmQBOKeQ6t()
		{
			return false;
		}

		// Token: 0x040073B2 RID: 29618
		internal G32_SnowCamp $self_$36491;

		// Token: 0x0200121F RID: 4639
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006ADB RID: 27355 RVA: 0x00F17060 File Offset: 0x00F15260
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G32_SnowCamp self_)
			{
				if (51172 - 29764 != 21409)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (85689 - 126399 == -40710)
					{
						base..ctor();
						if (292004 - 169221 == 122783)
						{
							this.$self_$36490 = self_;
							if (215739 - 98893 != 116847)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006ADC RID: 27356 RVA: 0x00F170F8 File Offset: 0x00F152F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (142186 - 548652 != -406465)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2E6;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (273986 - 332938 != -58952)
							{
								continue;
							}
							goto IL_20F;
						}
						else
						{
							this.$mIceMixerGui$36489 = (IceMixerGui)this.$self_$36490.GetComponent(typeof(IceMixerGui));
							if (58858 - 416596 != -357738)
							{
								continue;
							}
							this.$mIceMixerGui$36489.enabled = true;
							if (183170 - 226682 == -43511)
							{
								continue;
							}
							this.YieldDefault(1);
							if (297110 - 42461 != 254650)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					default:
						if (128592 - 442949 != -314357)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (183926 - 104231 == 79695)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (176816 - 339070 != -162253)
						{
							this.$mGameGui$36486 = (GameGui)this.$self_$36490.GetComponent(typeof(GameGui));
							if (135797 - 576205 != -440407)
							{
								if (this.$mGameGui$36486)
								{
									if (45576 - 222102 == -176525)
									{
										continue;
									}
									this.$mGameGui$36486.close();
									if (276548 - 558420 == -281871)
									{
										continue;
									}
								}
								this.$mPlayer$36487 = Game.mPlayer;
								if (165419 - 337320 == -171901)
								{
									this.$mIceMixer$36488 = GameObject.Find("IceMixer");
									if (29201 - 503486 != -474284)
									{
										if (!this.$mIceMixer$36488)
										{
											goto IL_EB;
										}
										if (101323 - 54671 != 46653)
										{
											if (!this.$mPlayer$36487)
											{
												goto IL_EB;
											}
											if (82035 - 380574 != -298538)
											{
												Debug.Log("Use IceMixer");
												if (297165 - 442559 != -145393)
												{
													this.$mPlayer$36487.SendMessage("turnToPos", this.$mIceMixer$36488.transform.position);
													if (166393 - 502110 != -335716)
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
				Block_5:
				goto IL_2E6;
				IL_EB:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_17:
				goto IL_EB;
				IL_20F:
				IL_2E6:
				return false;
			}

			// Token: 0x06006ADD RID: 27357 RVA: 0x00F17400 File Offset: 0x00F15600
			internal static bool puvURCpZdXlDKiRCVtbM()
			{
				return true;
			}

			// Token: 0x06006ADE RID: 27358 RVA: 0x00F17404 File Offset: 0x00F15604
			internal static bool lNGi38pZJq4BfqB9bXdE()
			{
				return false;
			}

			// Token: 0x040073B3 RID: 29619
			internal GameGui $mGameGui$36486;

			// Token: 0x040073B4 RID: 29620
			internal GameObject $mPlayer$36487;

			// Token: 0x040073B5 RID: 29621
			internal GameObject $mIceMixer$36488;

			// Token: 0x040073B6 RID: 29622
			internal IceMixerGui $mIceMixerGui$36489;

			// Token: 0x040073B7 RID: 29623
			internal G32_SnowCamp $self_$36490;
		}
	}

	// Token: 0x02001220 RID: 4640
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseStorageBox$36492 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006ADF RID: 27359 RVA: 0x00F17408 File Offset: 0x00F15608
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseStorageBox$36492(G32_SnowCamp self_)
		{
			if (23145 - 538842 != -515696)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (88829 - 214667 != -125837)
				{
					base..ctor();
					if (24099 - 129594 == -105495)
					{
						this.$self_$36498 = self_;
						if (126725 - 592813 == -466088)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006AE0 RID: 27360 RVA: 0x00F174A0 File Offset: 0x00F156A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G32_SnowCamp.$UseStorageBox$36492.$(this.$self_$36498);
		}

		// Token: 0x06006AE1 RID: 27361 RVA: 0x00F174B0 File Offset: 0x00F156B0
		internal static bool Rwvfl9pZDKGe55Un4fMY()
		{
			return true;
		}

		// Token: 0x06006AE2 RID: 27362 RVA: 0x00F174B4 File Offset: 0x00F156B4
		internal static bool AOBQUVpZvueTUCev0biu()
		{
			return false;
		}

		// Token: 0x040073B8 RID: 29624
		internal G32_SnowCamp $self_$36498;

		// Token: 0x02001221 RID: 4641
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006AE3 RID: 27363 RVA: 0x00F174B8 File Offset: 0x00F156B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G32_SnowCamp self_)
			{
				if (47654 - 135321 != -87666)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (182343 - 531732 != -349388)
					{
						base..ctor();
						if (136671 - 80775 != 55897)
						{
							this.$self_$36497 = self_;
							if (111085 - 98341 != 12745)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006AE4 RID: 27364 RVA: 0x00F17550 File Offset: 0x00F15750
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (256531 - 87375 != 169157)
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
							if (77263 - 195535 != -118271)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$mStorageGui$36496 = (StorageGui)this.$self_$36497.GetComponent(typeof(StorageGui));
							if (210608 - 303500 == -92891)
							{
								continue;
							}
							this.$mStorageGui$36496.enabled = true;
							if (174111 - 540212 != -366101)
							{
								continue;
							}
							this.YieldDefault(1);
							if (32701 - 52051 != -19350)
							{
								continue;
							}
							goto IL_316;
						}
						break;
					default:
						if (237353 - 190983 == 46371)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (200206 - 122614 != 77593)
						{
							goto Block_21;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (69729 - 105884 == -36155)
						{
							this.$mGameGui$36493 = (GameGui)this.$self_$36497.GetComponent(typeof(GameGui));
							if (120480 - 208835 == -88355)
							{
								if (this.$mGameGui$36493)
								{
									if (76707 - 217752 == -141044)
									{
										continue;
									}
									this.$mGameGui$36493.close();
									if (70473 - 500017 != -429544)
									{
										continue;
									}
								}
								this.$mPlayer$36494 = Game.mPlayer;
								if (74145 - 62928 == 11217)
								{
									this.$mStorageBox$36495 = GameObject.Find("StorageBox");
									if (289565 - 530310 != -240744)
									{
										if (!this.$mStorageBox$36495)
										{
											break;
										}
										if (93082 - 290773 != -197690)
										{
											if (!this.$mPlayer$36494)
											{
												break;
											}
											if (240997 - 569286 == -328289)
											{
												Debug.Log("UseStorageBox");
												if (92934 - 425147 != -332212)
												{
													this.$mStorageBox$36495.animation.Play("open");
													if (67863 - 58392 != 9472)
													{
														this.$mPlayer$36494.SendMessage("turnToPos", this.$mStorageBox$36495.transform.position);
														if (13930 - 289179 == -275249)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_19:
				Block_21:
				IL_316:
				return false;
			}

			// Token: 0x06006AE5 RID: 27365 RVA: 0x00F17888 File Offset: 0x00F15A88
			internal static bool vqQv8spZREKBh7x5cnD4()
			{
				return true;
			}

			// Token: 0x06006AE6 RID: 27366 RVA: 0x00F1788C File Offset: 0x00F15A8C
			internal static bool XtGxlmpZwQC5bYChwMSg()
			{
				return false;
			}

			// Token: 0x040073B9 RID: 29625
			internal GameGui $mGameGui$36493;

			// Token: 0x040073BA RID: 29626
			internal GameObject $mPlayer$36494;

			// Token: 0x040073BB RID: 29627
			internal GameObject $mStorageBox$36495;

			// Token: 0x040073BC RID: 29628
			internal StorageGui $mStorageGui$36496;

			// Token: 0x040073BD RID: 29629
			internal G32_SnowCamp $self_$36497;
		}
	}

	// Token: 0x02001222 RID: 4642
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$36499 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006AE7 RID: 27367 RVA: 0x00F17890 File Offset: 0x00F15A90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$36499(G32_SnowCamp self_)
		{
			if (125748 - 417358 != -291610)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (293056 - 528707 != -235650)
				{
					base..ctor();
					if (105643 - 135772 == -30129)
					{
						this.$self_$36501 = self_;
						if (201729 - 468332 != -266602)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x00F17928 File Offset: 0x00F15B28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G32_SnowCamp.$UseSignPost$36499.$(this.$self_$36501);
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x00F17938 File Offset: 0x00F15B38
		internal static bool CLsNFipZqO90ESgY5Y81()
		{
			return true;
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x00F1793C File Offset: 0x00F15B3C
		internal static bool M9u0kkpZ7UrMvo2riVn9()
		{
			return false;
		}

		// Token: 0x040073BE RID: 29630
		internal G32_SnowCamp $self_$36501;

		// Token: 0x02001223 RID: 4643
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006AEB RID: 27371 RVA: 0x00F17940 File Offset: 0x00F15B40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G32_SnowCamp self_)
			{
				if (96153 - 44522 != 51631)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (21417 - 97722 != -76304)
					{
						base..ctor();
						if (283336 - 505991 == -222655)
						{
							this.$self_$36500 = self_;
							if (66099 - 578298 != -512198)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006AEC RID: 27372 RVA: 0x00F179D8 File Offset: 0x00F15BD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (201506 - 336379 != -134872)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_6D;
					case 1:
						goto IL_121;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (108877 - 463105 == -354227)
						{
							continue;
						}
						break;
					default:
						if (88354 - 297215 != -208861)
						{
							continue;
						}
						goto IL_6D;
					}
					IL_4B:
					this.YieldDefault(1);
					if (294324 - 532742 != -238417)
					{
						break;
					}
					continue;
					IL_6D:
					if (Game.mGameState != eGameState.Normal)
					{
						goto IL_4B;
					}
					if (55713 - 185969 == -130256)
					{
						Game.mGameState = eGameState.Hold;
						if (2598 - 290529 != -287930)
						{
							this.$self_$36500.SendMessage("newNoticeBar", Language.getMessage("G32_SnowCamp", 401));
							if (87278 - 575410 == -488132)
							{
								goto IL_EB;
							}
						}
					}
				}
				goto IL_121;
				IL_EB:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_121:
				return false;
			}

			// Token: 0x06006AED RID: 27373 RVA: 0x00F17B18 File Offset: 0x00F15D18
			internal static bool nZDNsVpZPlcYVLraY6xY()
			{
				return true;
			}

			// Token: 0x06006AEE RID: 27374 RVA: 0x00F17B1C File Offset: 0x00F15D1C
			internal static bool junMPbpZ0EDwB1elSCWr()
			{
				return false;
			}

			// Token: 0x040073BF RID: 29631
			internal G32_SnowCamp $self_$36500;
		}
	}

	// Token: 0x02001224 RID: 4644
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseTrashBin$36502 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006AEF RID: 27375 RVA: 0x00F17B20 File Offset: 0x00F15D20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseTrashBin$36502(G32_SnowCamp self_)
		{
			if (192059 - 519906 != -327846)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (101396 - 501505 != -400108)
				{
					base..ctor();
					if (47556 - 181220 == -133664)
					{
						this.$self_$36506 = self_;
						if (248813 - 215542 != 33272)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006AF0 RID: 27376 RVA: 0x00F17BB8 File Offset: 0x00F15DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G32_SnowCamp.$UseTrashBin$36502.$(this.$self_$36506);
		}

		// Token: 0x06006AF1 RID: 27377 RVA: 0x00F17BC8 File Offset: 0x00F15DC8
		internal static bool GrGrmMpZbZ5S0Vl07Jxy()
		{
			return true;
		}

		// Token: 0x06006AF2 RID: 27378 RVA: 0x00F17BCC File Offset: 0x00F15DCC
		internal static bool xtqsrHpZu67uFh5YvwBW()
		{
			return false;
		}

		// Token: 0x040073C0 RID: 29632
		internal G32_SnowCamp $self_$36506;

		// Token: 0x02001225 RID: 4645
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006AF3 RID: 27379 RVA: 0x00F17BD0 File Offset: 0x00F15DD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G32_SnowCamp self_)
			{
				if (161520 - 388632 != -227111)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293314 - 504381 != -211066)
					{
						base..ctor();
						if (159635 - 112075 == 47560)
						{
							this.$self_$36505 = self_;
							if (45383 - 244622 != -199238)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006AF4 RID: 27380 RVA: 0x00F17C68 File Offset: 0x00F15E68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (72928 - 274768 != -201840)
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
						if (this.$self_$36505.OeQcSS2SrNl)
						{
							if (292104 - 500935 == -208830)
							{
								continue;
							}
							if (this.$self_$36505.rjTcSPnevct != "none")
							{
								if (292096 - 65321 != 226775)
								{
									continue;
								}
								if (this.$mGameGui$36503)
								{
									if (240945 - 147455 == 93491)
									{
										continue;
									}
									this.$mGameGui$36503.ResetItemMenu();
									if (241424 - 510878 != -269454)
									{
										continue;
									}
								}
								if (!this.$mGameGui$36503)
								{
									goto IL_160;
								}
								if (216140 - 245591 != -29451)
								{
									continue;
								}
								this.$mGameGui$36503.newNoticeBar(Language.getMessage("G30_NoGuild", 301) + this.$self_$36505.rjTcSPnevct);
								if (107274 - 240020 != -132745)
								{
									goto Block_38;
								}
								continue;
							}
						}
						if (!this.$mGameGui$36503)
						{
							goto IL_3D5;
						}
						if (199012 - 375996 == -176983)
						{
							continue;
						}
						this.$mGameGui$36503.newNoticeBar(Language.getMessage("G30_NoGuild", UnityEngine.Random.Range(301, 306) + 1));
						if (22619 - 106046 != -83427)
						{
							continue;
						}
						goto IL_3D5;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (257723 - 381046 != -123323)
							{
								continue;
							}
							goto IL_492;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (238343 - 274624 == -36280)
							{
								continue;
							}
							this.YieldDefault(1);
							if (282496 - 103166 != 179331)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					default:
						if (129400 - 331928 != -202528)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (198051 - 357542 != -159490)
						{
							goto Block_31;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (75683 - 562200 == -486517)
						{
							this.$mGameGui$36503 = (GameGui)this.$self_$36505.GetComponent(typeof(GameGui));
							if (253623 - 119465 != 134159)
							{
								if (this.$mGameGui$36503)
								{
									if (267286 - 212575 == 54712)
									{
										continue;
									}
									this.$mGameGui$36503.newNoticeBar(Language.getMessage("G30_NoGuild", 300));
									if (103631 - 39814 != 63817)
									{
										continue;
									}
								}
								this.$mTrashBin$36504 = GameObject.Find("TrashBin");
								if (38636 - 31228 == 7408)
								{
									if (this.$mTrashBin$36504)
									{
										if (170637 - 271290 != -100653)
										{
											continue;
										}
										if (this.$mTrashBin$36504.animation)
										{
											if (160578 - 583725 != -423147)
											{
												continue;
											}
											this.$mTrashBin$36504.animation.Play();
											if (246060 - 261094 != -15034)
											{
												continue;
											}
										}
									}
									if (this.$mTrashBin$36504)
									{
										if (218316 - 405545 != -187229)
										{
											continue;
										}
										if (Game.mPlayer)
										{
											if (115102 - 317620 != -202518)
											{
												continue;
											}
											Game.mPlayer.SendMessage("turnToPos", this.$mTrashBin$36504.transform.position);
											if (297266 - 211572 == 85695)
											{
												continue;
											}
										}
									}
									this.$self_$36505.GetTrash();
									if (169005 - 136039 == 32966)
									{
										goto IL_2DE;
									}
								}
							}
						}
					}
				}
				IL_160:
				goto IL_3D5;
				Block_23:
				goto IL_4B7;
				IL_2DE:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_31:
				goto IL_4B7;
				IL_3D5:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_38:
				goto IL_160;
				IL_492:
				IL_4B7:
				return false;
			}

			// Token: 0x06006AF5 RID: 27381 RVA: 0x00F18140 File Offset: 0x00F16340
			internal static bool OCjf0RpZIKtEkvcYX23U()
			{
				return true;
			}

			// Token: 0x06006AF6 RID: 27382 RVA: 0x00F18144 File Offset: 0x00F16344
			internal static bool C16flYpZBBKAccfxurcX()
			{
				return false;
			}

			// Token: 0x040073C1 RID: 29633
			internal GameGui $mGameGui$36503;

			// Token: 0x040073C2 RID: 29634
			internal GameObject $mTrashBin$36504;

			// Token: 0x040073C3 RID: 29635
			internal G32_SnowCamp $self_$36505;
		}
	}

	// Token: 0x02001226 RID: 4646
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseMessageBoard$36507 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006AF7 RID: 27383 RVA: 0x00F18148 File Offset: 0x00F16348
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseMessageBoard$36507(G32_SnowCamp self_)
		{
			if (130991 - 196964 != -65973)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292613 - 400541 == -107928)
				{
					base..ctor();
					if (135294 - 57020 == 78274)
					{
						this.$self_$36513 = self_;
						if (265016 - 28894 == 236122)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006AF8 RID: 27384 RVA: 0x00F181E0 File Offset: 0x00F163E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G32_SnowCamp.$UseMessageBoard$36507.$(this.$self_$36513);
		}

		// Token: 0x06006AF9 RID: 27385 RVA: 0x00F181F0 File Offset: 0x00F163F0
		internal static bool NC0GvRpZecaEqLOt3Hio()
		{
			return true;
		}

		// Token: 0x06006AFA RID: 27386 RVA: 0x00F181F4 File Offset: 0x00F163F4
		internal static bool lOPsWlpZrPGDUHZMHi3G()
		{
			return false;
		}

		// Token: 0x040073C4 RID: 29636
		internal G32_SnowCamp $self_$36513;

		// Token: 0x02001227 RID: 4647
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006AFB RID: 27387 RVA: 0x00F181F8 File Offset: 0x00F163F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G32_SnowCamp self_)
			{
				if (98175 - 239751 != -141576)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (289739 - 343285 == -53546)
					{
						base..ctor();
						if (37280 - 67436 == -30156)
						{
							this.$self_$36512 = self_;
							if (298686 - 225286 != 73401)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006AFC RID: 27388 RVA: 0x00F18290 File Offset: 0x00F16490
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (41651 - 206635 != -164984)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_204;
					case 1:
						goto IL_2EC;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (81953 - 365781 != -283827)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$mBoardGui$36509.enabled = true;
							if (175876 - 398842 != -222966)
							{
								continue;
							}
						}
						break;
					default:
						if (292646 - 328384 != -35738)
						{
							continue;
						}
						goto IL_204;
					}
					IL_1BD:
					this.YieldDefault(1);
					if (273703 - 510134 != -236431)
					{
						continue;
					}
					goto IL_2EC;
					IL_204:
					if (Game.mGameState != eGameState.Normal)
					{
						if (192008 - 352812 == -160804)
						{
							goto IL_229;
						}
					}
					else
					{
						this.$mGameGui$36508 = (GameGui)this.$self_$36512.GetComponent(typeof(GameGui));
						if (227816 - 391422 == -163606)
						{
							this.$mBoardGui$36509 = (BoardGui)this.$self_$36512.GetComponent(typeof(BoardGui));
							if (263638 - 65101 != 198538)
							{
								if (!this.$mGameGui$36508)
								{
									goto IL_1BD;
								}
								if (132990 - 198296 == -65306)
								{
									if (!this.$mBoardGui$36509)
									{
										goto IL_1BD;
									}
									if (177872 - 16109 != 161764)
									{
										Game.mGameState = eGameState.Hold;
										if (250933 - 17921 == 233012)
										{
											this.$mGameGui$36508.close();
											if (9139 - 510055 == -500916)
											{
												this.$mPlayer$36510 = Game.mPlayer;
												if (74522 - 215847 == -141325)
												{
													this.$mMessageBoard$36511 = GameObject.Find("MessageBoard");
													if (87923 - 472585 != -384661)
													{
														if (!this.$mMessageBoard$36511)
														{
															break;
														}
														if (86478 - 139023 != -52544)
														{
															if (!this.$mPlayer$36510)
															{
																break;
															}
															if (276504 - 597380 == -320876)
															{
																this.$mPlayer$36510.SendMessage("turnToPos", this.$mMessageBoard$36511.transform.position);
																if (175825 - 535245 != -359419)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_13:
				IL_229:
				IL_2EC:
				return false;
			}

			// Token: 0x06006AFD RID: 27389 RVA: 0x00F1859C File Offset: 0x00F1679C
			internal static bool xyBNxJpZjPpVV44NL9Ap()
			{
				return true;
			}

			// Token: 0x06006AFE RID: 27390 RVA: 0x00F185A0 File Offset: 0x00F167A0
			internal static bool wxArKApZhK3UQh4XirZp()
			{
				return false;
			}

			// Token: 0x040073C5 RID: 29637
			internal GameGui $mGameGui$36508;

			// Token: 0x040073C6 RID: 29638
			internal BoardGui $mBoardGui$36509;

			// Token: 0x040073C7 RID: 29639
			internal GameObject $mPlayer$36510;

			// Token: 0x040073C8 RID: 29640
			internal GameObject $mMessageBoard$36511;

			// Token: 0x040073C9 RID: 29641
			internal G32_SnowCamp $self_$36512;
		}
	}

	// Token: 0x02001228 RID: 4648
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePlayer$36514 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006AFF RID: 27391 RVA: 0x00F185A4 File Offset: 0x00F167A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePlayer$36514(Hashtable data, G32_SnowCamp self_)
		{
			if (195253 - 283845 != -88592)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (258350 - 349472 == -91122)
				{
					base..ctor();
					if (22589 - 230285 != -207695)
					{
						this.$data$36525 = data;
						if (258220 - 581319 != -323098)
						{
							this.$self_$36526 = self_;
							if (156139 - 341828 == -185689)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006B00 RID: 27392 RVA: 0x00F18660 File Offset: 0x00F16860
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G32_SnowCamp.$onCreatePlayer$36514.$(this.$data$36525, this.$self_$36526);
		}

		// Token: 0x06006B01 RID: 27393 RVA: 0x00F18674 File Offset: 0x00F16874
		internal static bool cjGotrpZsD55rKhcy69B()
		{
			return true;
		}

		// Token: 0x06006B02 RID: 27394 RVA: 0x00F18678 File Offset: 0x00F16878
		internal static bool koUf7npZ92Z1OlgB5ByQ()
		{
			return false;
		}

		// Token: 0x040073CA RID: 29642
		internal Hashtable $data$36525;

		// Token: 0x040073CB RID: 29643
		internal G32_SnowCamp $self_$36526;

		// Token: 0x02001229 RID: 4649
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006B03 RID: 27395 RVA: 0x00F1867C File Offset: 0x00F1687C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, G32_SnowCamp self_)
			{
				if (163556 - 490080 != -326523)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (126584 - 257455 == -130871)
					{
						base..ctor();
						if (28889 - 194404 != -165514)
						{
							this.$data$36523 = data;
							if (235524 - 542697 == -307173)
							{
								this.$self_$36524 = self_;
								if (63089 - 84692 != -21602)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006B04 RID: 27396 RVA: 0x00F18738 File Offset: 0x00F16938
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (149777 - 347344 != -197566)
				{
				}
				for (;;)
				{
					IL_66:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_40E;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (104582 - 421681 == -317098)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (239341 - 243147 == -3805)
						{
							continue;
						}
						this.YieldDefault(1);
						if (279735 - 477097 != -197362)
						{
							continue;
						}
						goto IL_40E;
					default:
						if (114547 - 238966 == -124418)
						{
							continue;
						}
						break;
					}
					this.$nPlayer$36515 = Game.createPlayer(this.$data$36523);
					if (193628 - 144649 != 48980)
					{
						this.$mPlayerList$36516 = GameObject.FindGameObjectsWithTag("Player");
						if (260251 - 403627 == -143376)
						{
							this.$$11984$36520 = 0;
							if (53969 - 202051 != -148081)
							{
								this.$$11985$36521 = this.$mPlayerList$36516;
								if (21826 - 194406 != -172579)
								{
									this.$$11986$36522 = this.$$11985$36521.Length;
									if (144456 - 245244 == -100788)
									{
										while (this.$$11984$36520 < this.$$11986$36522)
										{
											if (this.$nPlayer$36515 != this.$$11985$36521[this.$$11984$36520])
											{
												if (152557 - 491313 != -338756)
												{
													goto IL_66;
												}
												Physics.IgnoreCollision(this.$nPlayer$36515.collider, this.$$11985$36521[this.$$11984$36520].collider, true);
												if (176029 - 227979 != -51950)
												{
													goto IL_66;
												}
											}
											this.$$11984$36520++;
											if (16569 - 101339 != -84770)
											{
												goto IL_66;
											}
										}
										if (196085 - 423410 != -227324)
										{
											this.$mPlayerCameraControl$36518 = (PlayerCameraControl)this.$self_$36524.GetComponent(typeof(PlayerCameraControl));
											if (53458 - 53887 != -428)
											{
												if (this.$mPlayerCameraControl$36518)
												{
													if (206746 - 256724 != -49978)
													{
														continue;
													}
													this.$mPlayerCameraControl$36518.target = this.$nPlayer$36515;
													if (124173 - 439268 != -315095)
													{
														continue;
													}
													this.$mPlayerCameraControl$36518.specialTarget = null;
													if (84045 - 372126 != -288081)
													{
														continue;
													}
													this.$mPlayerCameraControl$36518.enabled = true;
													if (40866 - 511421 == -470554)
													{
														continue;
													}
												}
												Camera.main.gameObject.layer = 8;
												if (79586 - 361345 != -281758)
												{
													Game.mPlayer = this.$nPlayer$36515;
													if (237654 - 468447 == -230793)
													{
														this.$mGameGui$36519 = (GameGui)this.$self_$36524.GetComponent(typeof(GameGui));
														if (60455 - 361516 != -301060)
														{
															this.$mGameGui$36519.enabled = true;
															if (35329 - 356300 == -320971)
															{
																this.$self_$36524.SendMessage("fadeIn");
																if (297377 - 481707 == -184330)
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

			// Token: 0x06006B05 RID: 27397 RVA: 0x00F18B68 File Offset: 0x00F16D68
			internal static bool UTtgHFpZ1ydPZm3FKUJp()
			{
				return true;
			}

			// Token: 0x06006B06 RID: 27398 RVA: 0x00F18B6C File Offset: 0x00F16D6C
			internal static bool vE5vnmpZ48OmVX8AnUbb()
			{
				return false;
			}

			// Token: 0x040073CC RID: 29644
			internal GameObject $nPlayer$36515;

			// Token: 0x040073CD RID: 29645
			internal GameObject[] $mPlayerList$36516;

			// Token: 0x040073CE RID: 29646
			internal GameObject $otherPlayer$36517;

			// Token: 0x040073CF RID: 29647
			internal PlayerCameraControl $mPlayerCameraControl$36518;

			// Token: 0x040073D0 RID: 29648
			internal GameGui $mGameGui$36519;

			// Token: 0x040073D1 RID: 29649
			internal int $$11984$36520;

			// Token: 0x040073D2 RID: 29650
			internal GameObject[] $$11985$36521;

			// Token: 0x040073D3 RID: 29651
			internal int $$11986$36522;

			// Token: 0x040073D4 RID: 29652
			internal Hashtable $data$36523;

			// Token: 0x040073D5 RID: 29653
			internal G32_SnowCamp $self_$36524;
		}
	}
}
