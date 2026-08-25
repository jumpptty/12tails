using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x0200123F RID: 4671
[Serializable]
public class G34_ExcavationCamp : MonoBehaviour
{
	// Token: 0x06006B80 RID: 27520 RVA: 0x00F1F2F8 File Offset: 0x00F1D4F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public G34_ExcavationCamp()
	{
		if (125887 - 48776 != 77111)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (41357 - 103146 != -61788)
			{
				base..ctor();
				if (235564 - 447543 != -211978)
				{
					this.YD2cSuUbRUa = "none";
					if (151008 - 201866 == -50858)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006B81 RID: 27521 RVA: 0x00F1F394 File Offset: 0x00F1D594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (58397 - 63872 != -5474)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (243175 - 205829 != 37347)
			{
				Game.mStateTime = Time.time;
				if (43071 - 596183 != -553111)
				{
					if (Chat.Initialized)
					{
						if (44183 - 21293 == 22891)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (246119 - 202355 == 43765)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (210037 - 180430 != 29607)
						{
							continue;
						}
					}
					this.OaecSk7onpX = (Texture)Resources.Load("GameGui/Title/stage_desert", typeof(Texture));
					if (135969 - 66369 == 69600)
					{
						if (this.OaecSk7onpX)
						{
							break;
						}
						if (221324 - 564208 == -342884)
						{
							Debug.LogError("Cannot find start title");
							if (273964 - 418903 != -144938)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B82 RID: 27522 RVA: 0x00F1F504 File Offset: 0x00F1D704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (222683 - 148572 != 74111)
		{
		}
		for (;;)
		{
			Time.timeScale = 1f;
			if (220301 - 122926 != 97376)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (286647 - 382588 != -95940)
				{
					if (PhotonClient.IsInitialized())
					{
						if (243828 - 592936 != -349107)
						{
							Game.mLastGameCode = Game.mGameCode;
							if (16675 - 203881 == -187206)
							{
								Game.mGameCode = 34;
								if (235039 - 40473 != 194567)
								{
									Game.mGameType = 2;
									if (99709 - 48431 == 51278)
									{
										Game.mGameTime = Time.time;
										if (180050 - 232883 != -52832)
										{
											Game.mGameScore = 0;
											if (130849 - 495162 != -364312)
											{
												Game.mGameMana = 0;
												if (97070 - 284395 != -187324)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (131837 - 318920 == -187083)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (112537 - 43943 != 68595)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (135111 - 196252 != -61140)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (160385 - 392563 == -232178)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (145243 - 47600 != 97644)
																	{
																		this.IE2cSohiIxV = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (114483 - 368713 != -254229)
																		{
																			this.LHhcSj2yxYs = PhotonClient.Connection;
																			if (226284 - 100838 == 125446)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (225761 - 460099 != -234337)
																				{
																					this.LoadTown();
																					if (268413 - 52006 == 216407)
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
						if (68232 - 301180 == -232948)
						{
							this.enabled = false;
							if (96331 - 386182 != -289850)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B83 RID: 27523 RVA: 0x00F1F834 File Offset: 0x00F1DA34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (142551 - 342641 != -200090)
		{
		}
		for (;;)
		{
			if (this.LHhcSj2yxYs == null)
			{
				if (241743 - 342876 != -101132)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (287638 - 278236 == 9402)
				{
					if (mGameState != eGameState.Start)
					{
						if (17487 - 239874 != -222387)
						{
							continue;
						}
						if (mGameState == eGameState.Normal)
						{
							if (225173 - 410406 != -185233)
							{
								continue;
							}
						}
						else if (mGameState == eGameState.Hold)
						{
							if (213582 - 175973 != 37609)
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
							if (239920 - 273548 != -33628)
							{
								continue;
							}
							this.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, Time.time - Game.mStateTime);
							if (6954 - 45505 != -38551)
							{
								continue;
							}
							break;
						}
					}
					if (Game.music != 0)
					{
						if (298593 - 39797 == 258797)
						{
							continue;
						}
						if (!this.audio.isPlaying)
						{
							if (254975 - 150589 == 104387)
							{
								continue;
							}
							this.audio.Play();
							if (61427 - 178548 != -117121)
							{
								continue;
							}
						}
					}
					if (Time.time - Game.mGameTime < (float)2)
					{
						if (8979 - 250111 != -241131)
						{
							this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
							if (209917 - 582891 != -372973)
							{
								break;
							}
						}
					}
					else
					{
						this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
						if (57539 - 325568 != -268028)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B84 RID: 27524 RVA: 0x00F1FAB0 File Offset: 0x00F1DCB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (127330 - 144669 != -17338)
		{
		}
		for (;;)
		{
			if (!this.OaecSk7onpX)
			{
				if (206070 - 599753 == -393683)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Start)
			{
				if (156862 - 562158 != -405295)
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
				if (47019 - 274553 != -227533)
				{
					if (Time.time - Game.mStateTime >= (float)3)
					{
						break;
					}
					if (215720 - 249331 != -33610)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (291353 - 541747 != -250393)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (251835 - 501784 == -249949)
							{
								GUI.depth = 1;
								if (210518 - 204622 != 5897)
								{
									float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4(0.7f, 0.8f, (float)1, 0.4f));
									if (196660 - 126782 != 69879)
									{
										Color color = GUI.color;
										if (82582 - 247799 != -165216)
										{
											float num2 = color.a = smoothRatioOverTime;
											if (262457 - 215033 == 47424)
											{
												if (153588 - 550008 == -396420)
												{
													Color color2 = GUI.color = color;
													if (25882 - 551960 != -526077 && 42558 - 304962 != -262403)
													{
														GUI.DrawTexture(new Rect(0.5f * num - (float)256, (float)416, (float)512, (float)128), this.OaecSk7onpX);
														if (94792 - 594631 != -499838)
														{
															float a = 1f;
															if (210195 - 599616 == -389421)
															{
																Color color3 = GUI.color;
																if (30047 - 162846 == -132799)
																{
																	float num3 = color3.a = a;
																	if (137933 - 179097 != -41163)
																	{
																		if (12325 - 524701 == -512376)
																		{
																			GUI.color = color3;
																			if (281303 - 508723 == -227420)
																			{
																				if (264595 - 179973 == 84622)
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

	// Token: 0x06006B85 RID: 27525 RVA: 0x00F1FE30 File Offset: 0x00F1E030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTown()
	{
		if (266348 - 197251 != 69097)
		{
		}
		for (;;)
		{
			Debug.Log("Loading Town ");
			if (63415 - 343563 != -280147)
			{
				Hashtable customOpParameters = new Hashtable();
				if (259255 - 5144 == 254111)
				{
					this.LHhcSj2yxYs.OpCustom(43, customOpParameters, true);
					if (269402 - 527212 != -257809)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006B86 RID: 27526 RVA: 0x00F1FED8 File Offset: 0x00F1E0D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadTown(Hashtable data)
	{
		if (78843 - 43258 != 35585)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadTown ");
			if (253925 - 393519 == -139594)
			{
				if (!RuntimeServices.EqualityOperator(data[31], null))
				{
					if (168122 - 77914 == 90209)
					{
						continue;
					}
					Chat.SubmitChat("none", "You have joined " + data[31], eChatType.system, eChatMode.system);
					if (179011 - 375016 != -196005)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(data[32], null))
				{
					if (91160 - 512175 == -421014)
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
					if (212705 - 399564 == -186858)
					{
						continue;
					}
				}
				if (Game.mLastGameCode != 0)
				{
					if (56040 - 321853 == -265812)
					{
						continue;
					}
					if (Game.mLastGameCode < 100)
					{
						if (143530 - 464862 != -321332)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.ExcavationCampStartEvent());
						if (218254 - 50698 != 167556)
						{
							continue;
						}
						break;
					}
				}
				GameObject gameObject = GameObject.Find("StartPoint1");
				if (229984 - 332564 != -102579)
				{
					GameObject gameObject2 = GameObject.Find("StartCamera1");
					if (51871 - 558064 == -506193)
					{
						if (gameObject2)
						{
							if (36852 - 94600 == -57747)
							{
								continue;
							}
							this.transform.position = gameObject2.transform.position;
							if (202149 - 92404 == 109746)
							{
								continue;
							}
							this.transform.rotation = gameObject2.transform.rotation;
							if (277663 - 153623 != 124040)
							{
								continue;
							}
						}
						if (gameObject)
						{
							if (226243 - 410699 != -184455)
							{
								this.CreatePlayer(CharacterData.current.CID, gameObject.transform.position, gameObject.transform.forward);
								if (110073 - 527625 == -417552)
								{
									break;
								}
							}
						}
						else
						{
							Debug.Log("Error: Startpoint not found");
							if (85283 - 234493 == -149210)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B87 RID: 27527 RVA: 0x00F201F4 File Offset: 0x00F1E3F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ExcavationCampStartEvent()
	{
		return new G34_ExcavationCamp.$ExcavationCampStartEvent$36596(this).GetEnumerator();
	}

	// Token: 0x06006B88 RID: 27528 RVA: 0x00F20204 File Offset: 0x00F1E404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new G34_ExcavationCamp.$TalkToRedPanda$36604(this).GetEnumerator();
	}

	// Token: 0x06006B89 RID: 27529 RVA: 0x00F20214 File Offset: 0x00F1E414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLizard(int n)
	{
		return new G34_ExcavationCamp.$TalkToLizard$36613(this).GetEnumerator();
	}

	// Token: 0x06006B8A RID: 27530 RVA: 0x00F20224 File Offset: 0x00F1E424
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToJerboa(int n)
	{
		return new G34_ExcavationCamp.$TalkToJerboa$36624(n, this).GetEnumerator();
	}

	// Token: 0x06006B8B RID: 27531 RVA: 0x00F20234 File Offset: 0x00F1E434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToOwl2()
	{
		if (172307 - 543607 != -371300)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (94096 - 328029 == -233933)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (202541 - 383809 == -181268)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (281373 - 569105 == -287732)
					{
						gameGui.close();
						if (73515 - 56121 != 17395)
						{
							ShopGui shopGui = (ShopGui)this.GetComponent(typeof(ShopGui));
							if (86488 - 401944 != -315455)
							{
								shopGui.mType = eShopType.Owl2;
								if (77697 - 240906 != -163208)
								{
									shopGui.enabled = true;
									if (75217 - 247210 != -171992)
									{
										GameObject mPlayer = Game.mPlayer;
										if (29854 - 84927 != -55072)
										{
											GameObject gameObject = GameObject.Find("Owl2");
											if (271246 - 120028 == 151218)
											{
												if (!gameObject)
												{
													break;
												}
												if (230705 - 354019 == -123314)
												{
													if (!mPlayer)
													{
														break;
													}
													if (299049 - 471501 != -172451)
													{
														mPlayer.SendMessage("turnToPos", gameObject.transform.position);
														if (11748 - 280982 != -269233)
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

	// Token: 0x06006B8C RID: 27532 RVA: 0x00F2043C File Offset: 0x00F1E63C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMouse(int n)
	{
		return new G34_ExcavationCamp.$TalkToMouse$36641(this).GetEnumerator();
	}

	// Token: 0x06006B8D RID: 27533 RVA: 0x00F2044C File Offset: 0x00F1E64C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToPilotMole(int n)
	{
		if (88844 - 590202 != -501358)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (76576 - 322746 == -246170)
				{
					break;
				}
			}
			else
			{
				Game.mGameState = eGameState.Hold;
				if (131048 - 554772 == -423724)
				{
					GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
					if (190140 - 196617 == -6477)
					{
						if (gameGui)
						{
							if (218347 - 70735 == 147613)
							{
								continue;
							}
							gameGui.close();
							if (140413 - 210627 == -70213)
							{
								continue;
							}
						}
						GameObject gameObject = GameObject.Find("PilotMole");
						if (116934 - 358756 != -241821)
						{
							if (gameObject)
							{
								if (113207 - 168006 == -54798)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (242197 - 288968 == -46770)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find PilotMole");
								if (255150 - 266166 == -11015)
								{
									continue;
								}
							}
							TransportGui transportGui = (TransportGui)this.GetComponent(typeof(TransportGui));
							if (219537 - 415921 != -196383)
							{
								transportGui.enabled = true;
								if (138088 - 286618 != -148529)
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

	// Token: 0x06006B8E RID: 27534 RVA: 0x00F20640 File Offset: 0x00F1E840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (49187 - 27193 != 21995)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (74314 - 521891 != -447576)
			{
				CharacterControl characterControl = null;
				if (141592 - 47966 != 93627)
				{
					if (mPlayer)
					{
						if (91981 - 403255 != -311274)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (9197 - 387903 == -378705)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (142635 - 427690 != -285054)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (266166 - 77912 != 188255)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (231427 - 78259 != 153169)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (57144 - 49180 != 7964)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (95967 - 288408 == -192440)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (193890 - 503976 != -310086)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (66012 - 8500 != 57512)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (255886 - 165478 == 90408)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (239397 - 486472 != -247074)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (53814 - 398936 != -345121)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (43938 - 203847 != -159908)
								{
									if (!changeGui)
									{
										break;
									}
									if (89424 - 370171 != -280746)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (4532 - 128103 == -123570)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (182373 - 245929 == -63555)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (4552 - 243589 != -239036)
										{
											gameGui.close();
											if (276021 - 592276 != -316254)
											{
												changeGui.enabled = true;
												if (7026 - 382220 == -375194)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (198221 - 212051 == -13830)
													{
														if (!gameObject)
														{
															break;
														}
														if (246766 - 174605 != 72162)
														{
															if (!mPlayer)
															{
																break;
															}
															if (80873 - 36863 == 44010)
															{
																Debug.Log("UseLifeAltar");
																if (266260 - 446984 == -180724)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (56779 - 298847 != -242067)
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

	// Token: 0x06006B8F RID: 27535 RVA: 0x00F20AA0 File Offset: 0x00F1ECA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseMailBox(object mVar)
	{
		if (139518 - 595443 != -455925)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (167307 - 327591 == -160284)
				{
					break;
				}
			}
			else
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (18276 - 392085 != -373808)
				{
					MailBoxGui mailBoxGui = (MailBoxGui)this.GetComponent(typeof(MailBoxGui));
					if (227541 - 19401 != 208141)
					{
						if (!gameGui)
						{
							break;
						}
						if (134286 - 545508 == -411222)
						{
							if (!mailBoxGui)
							{
								break;
							}
							if (139688 - 442266 == -302578)
							{
								Game.mGameState = eGameState.Hold;
								if (84476 - 388399 != -303922)
								{
									gameGui.close();
									if (145368 - 310587 == -165219)
									{
										mailBoxGui.enabled = true;
										if (132581 - 255109 == -122528)
										{
											GameObject mPlayer = Game.mPlayer;
											if (210508 - 497620 == -287112)
											{
												GameObject gameObject = GameObject.Find("MailBox");
												if (190461 - 8536 != 181926)
												{
													if (!gameObject)
													{
														break;
													}
													if (199799 - 148212 != 51588)
													{
														if (!mPlayer)
														{
															break;
														}
														if (24710 - 169180 != -144469)
														{
															mPlayer.SendMessage("turnToPos", gameObject.transform.position);
															if (35385 - 387868 == -352483)
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

	// Token: 0x06006B90 RID: 27536 RVA: 0x00F20CD4 File Offset: 0x00F1EED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseMessageBoard(object mVar)
	{
		return new G34_ExcavationCamp.$UseMessageBoard$36648(this).GetEnumerator();
	}

	// Token: 0x06006B91 RID: 27537 RVA: 0x00F20CE4 File Offset: 0x00F1EEE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseTrashBin(object mVar)
	{
		return new G34_ExcavationCamp.$UseTrashBin$36655(this).GetEnumerator();
	}

	// Token: 0x06006B92 RID: 27538 RVA: 0x00F20CF4 File Offset: 0x00F1EEF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetTrash()
	{
		if (30789 - 465477 != -434687)
		{
		}
		for (;;)
		{
			Debug.Log("GetTrash");
			if (117536 - 186379 != -68842)
			{
				this.puRcSyCcOBU = false;
				if (283189 - 580148 != -296958)
				{
					this.YD2cSuUbRUa = "none";
					if (259310 - 41231 == 218079)
					{
						Hashtable customOpParameters = new Hashtable();
						if (247199 - 124507 == 122692)
						{
							this.LHhcSj2yxYs.OpCustom(224, customOpParameters, true);
							if (30289 - 164494 == -134205)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B93 RID: 27539 RVA: 0x00F20DE4 File Offset: 0x00F1EFE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGetTrash(Hashtable data)
	{
		if (118176 - 216194 != -98018)
		{
		}
		while (RuntimeServices.EqualityOperator(data[31], 1))
		{
			if (119850 - 458348 != -338497)
			{
				this.puRcSyCcOBU = true;
				if (161219 - 452326 != -291106)
				{
					object obj2;
					object obj = obj2 = data[32];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					this.YD2cSuUbRUa = ItemData.getName((string)obj2);
					if (139931 - 248276 != -108344)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006B94 RID: 27540 RVA: 0x00F20EC8 File Offset: 0x00F1F0C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseStorageBox(object mVar)
	{
		return new G34_ExcavationCamp.$UseStorageBox$36660(this).GetEnumerator();
	}

	// Token: 0x06006B95 RID: 27541 RVA: 0x00F20ED8 File Offset: 0x00F1F0D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, Vector3 pos, Vector3 dir)
	{
		if (246396 - 597119 != -350722)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (4840 - 466463 == -461623)
			{
				hashtable.Add(71, CID);
				if (293171 - 576474 != -283302)
				{
					hashtable.Add(75, PhotonClient.cInt16(1));
					if (151580 - 61044 != 90537)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (215985 - 562696 != -346710)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (87605 - 315768 == -228163)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (159352 - 454209 == -294857)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (81472 - 64857 == 16615)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (152885 - 546118 == -393233)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (243938 - 527533 == -283595)
											{
												this.LHhcSj2yxYs.OpCustom(61, hashtable, true);
												if (109012 - 459482 != -350469)
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

	// Token: 0x06006B96 RID: 27542 RVA: 0x00F21164 File Offset: 0x00F1F364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePlayer(Hashtable data)
	{
		return new G34_ExcavationCamp.$onCreatePlayer$36667(data, this).GetEnumerator();
	}

	// Token: 0x06006B97 RID: 27543 RVA: 0x00F21174 File Offset: 0x00F1F374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (133702 - 395162 != -261460)
		{
		}
		for (;;)
		{
			IL_F9:
			GameObject gameObject = Game.createPeer(data);
			if (187219 - 189439 != -2219)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
				if (25708 - 369472 != -343763)
				{
					int i = 0;
					if (1925 - 349926 != -348000)
					{
						GameObject[] array2 = array;
						if (82544 - 229898 != -147353)
						{
							int length = array2.Length;
							if (94740 - 353671 == -258931)
							{
								while (i < length)
								{
									if (gameObject != array2[i])
									{
										if (157285 - 51212 == 106074)
										{
											goto IL_F9;
										}
										Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
										if (68010 - 149 != 67861)
										{
											goto IL_F9;
										}
									}
									i++;
									if (48343 - 212622 != -164279)
									{
										goto IL_F9;
									}
								}
								if (43506 - 27897 == 15609)
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

	// Token: 0x06006B98 RID: 27544 RVA: 0x00F212EC File Offset: 0x00F1F4EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DestroyPlayer()
	{
		Game.mPlayerID = 0;
	}

	// Token: 0x06006B99 RID: 27545 RVA: 0x00F212F4 File Offset: 0x00F1F4F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
	}

	// Token: 0x06006B9A RID: 27546 RVA: 0x00F212F8 File Offset: 0x00F1F4F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (16595 - 461831 != -445236)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (267434 - 378426 == -110992)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (220249 - 566300 != -346050)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (78584 - 251951 == -173367)
					{
						Hashtable hashtable = new Hashtable();
						if (72510 - 15876 != 56635)
						{
							hashtable.Add(43, PlayerData.UID);
							if (73216 - 6090 == 67126)
							{
								hashtable.Add(71, nCID);
								if (140991 - 348573 != -207581)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (198927 - 410669 != -211741)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (24526 - 448532 == -424006)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (133242 - 27134 == 106108)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (62592 - 524426 != -461833)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (289468 - 322724 != -33255)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (47268 - 463541 != -416272)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (146055 - 586894 == -440839)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (57241 - 223547 != -166305)
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

	// Token: 0x06006B9B RID: 27547 RVA: 0x00F21618 File Offset: 0x00F1F818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onChangePlayer(Hashtable data)
	{
		if (54503 - 19436 != 35067)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Destroy(Game.mPlayer);
			if (178886 - 380168 != -201281)
			{
				this.SendMessage("onCreatePlayer", data);
				if (160158 - 83757 == 76401)
				{
					ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
					if (50579 - 587647 != -537067)
					{
						if (!changeGui.enabled)
						{
							break;
						}
						if (63420 - 199140 != -135719)
						{
							changeGui.close();
							if (186958 - 213486 != -26527)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B9C RID: 27548 RVA: 0x00F21710 File Offset: 0x00F1F910
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(GameObject nMount)
	{
		if (110145 - 205826 != -95680)
		{
		}
		for (;;)
		{
			IL_A4:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
			if (23525 - 384832 == -361307)
			{
				int i = 0;
				if (269876 - 248856 != 21021)
				{
					GameObject[] array2 = array;
					if (11171 - 423541 != -412369)
					{
						int length = array2.Length;
						if (158436 - 480386 == -321950)
						{
							while (i < length)
							{
								if (nMount != array2[i])
								{
									if (299189 - 527840 != -228651)
									{
										goto IL_A4;
									}
									Physics.IgnoreCollision(nMount.collider, array2[i].collider, true);
									if (188769 - 97556 != 91213)
									{
										goto IL_A4;
									}
								}
								i++;
								if (89275 - 167642 == -78366)
								{
									goto IL_A4;
								}
							}
							if (287254 - 482345 == -195091)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006B9D RID: 27549 RVA: 0x00F21864 File Offset: 0x00F1FA64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveTown()
	{
		if (118294 - 126527 != -8232)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (30907 - 562764 == -531857)
			{
				hashtable.Add(43, PlayerData.UID);
				if (233578 - 82950 != 150629)
				{
					PhotonClient.Connection.OpCustom(44, hashtable, true);
					if (14420 - 213186 != -198765)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006B9E RID: 27550 RVA: 0x00F21918 File Offset: 0x00F1FB18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveTown()
	{
		if (185077 - 106741 != 78336)
		{
		}
		for (;;)
		{
			Debug.Log("onLeaveTown");
			if (132151 - 359544 != -227392)
			{
				if (Game.mNextGameCode > 100)
				{
					if (39841 - 280228 == -240387)
					{
						this.JoinGame();
						if (120900 - 441170 == -320270)
						{
							break;
						}
					}
				}
				else
				{
					this.JoinTown();
					if (168272 - 412691 != -244418)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006B9F RID: 27551 RVA: 0x00F219E0 File Offset: 0x00F1FBE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (111596 - 440054 != -328457)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (205692 - 88759 != 116934)
			{
				Hashtable hashtable = new Hashtable();
				if (131538 - 560621 == -429083)
				{
					if (Game.mNextGameCode == 30)
					{
						if (189726 - 96825 == 92902)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (234862 - 213147 == 21716)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (145477 - 525736 == -380258)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (186867 - 458102 == -271234)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (86004 - 285823 != -199819)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (173408 - 590142 == -416733)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (272329 - 429230 == -156900)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (77948 - 421348 == -343399)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (297902 - 369348 == -71445)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (121761 - 128585 == -6823)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (226205 - 371835 == -145629)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (5575 - 595660 == -590084)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (194445 - 407846 == -213400)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (224081 - 268455 == -44373)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (99538 - 189988 != -90450)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (251822 - 17736 == 234087)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (96392 - 359507 == -263114)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (76273 - 64121 == 12153)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (172534 - 231867 != -59333)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (219920 - 595162 != -375242)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (104279 - 413958 != -309679)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (205168 - 47935 == 157234)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (2537 - 121307 == -118769)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (153067 - 495282 != -342215)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (39576 - 192827 != -153251)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (289695 - 590201 == -300505)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (258155 - 332168 != -74013)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (179167 - 44897 != 134270)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (33226 - 360785 != -327558)
					{
						this.LHhcSj2yxYs.OpCustom(42, hashtable, true);
						if (268082 - 99424 == 168658)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006BA0 RID: 27552 RVA: 0x00F21F94 File Offset: 0x00F20194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06006BA1 RID: 27553 RVA: 0x00F21FA4 File Offset: 0x00F201A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinGame()
	{
		if (76149 - 301665 != -225515)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Game : " + Game.mNextGameId);
			if (293905 - 231247 == 62658)
			{
				Hashtable hashtable = new Hashtable();
				if (295806 - 230771 != 65036)
				{
					hashtable.Add(4, Game.mNextGameId);
					if (46725 - 310949 != -264223)
					{
						hashtable.Add(5, PhotonClient.cInt16(Game.mNextGameCode));
						if (41512 - 595744 != -554231)
						{
							this.LHhcSj2yxYs.OpCustom(51, hashtable, true);
							if (204869 - 548315 != -343445)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006BA2 RID: 27554 RVA: 0x00F220C0 File Offset: 0x00F202C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinGame(Hashtable data)
	{
		Game.loadNextLevel();
	}

	// Token: 0x06006BA3 RID: 27555 RVA: 0x00F220C8 File Offset: 0x00F202C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006BA4 RID: 27556 RVA: 0x00F220CC File Offset: 0x00F202CC
	internal static bool BisTskpCDVrIl9WGhm0V()
	{
		return true;
	}

	// Token: 0x06006BA5 RID: 27557 RVA: 0x00F220D0 File Offset: 0x00F202D0
	internal static bool AXwhO2pCvFRHbkh79MYp()
	{
		return false;
	}

	// Token: 0x04007417 RID: 29719
	private LitePeer LHhcSj2yxYs;

	// Token: 0x04007418 RID: 29720
	private PlayerCameraControl IE2cSohiIxV;

	// Token: 0x04007419 RID: 29721
	private Texture OaecSk7onpX;

	// Token: 0x0400741A RID: 29722
	private AudioClip Co7cSFW7nkM;

	// Token: 0x0400741B RID: 29723
	private int In1cSATpg3G;

	// Token: 0x0400741C RID: 29724
	private int R8HcS9cGPlU;

	// Token: 0x0400741D RID: 29725
	private int i6ScSWn23fr;

	// Token: 0x0400741E RID: 29726
	private string YD2cSuUbRUa;

	// Token: 0x0400741F RID: 29727
	private bool puRcSyCcOBU;

	// Token: 0x02001240 RID: 4672
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ExcavationCampStartEvent$36596 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006BA6 RID: 27558 RVA: 0x00F220D4 File Offset: 0x00F202D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ExcavationCampStartEvent$36596(G34_ExcavationCamp self_)
		{
			if (94029 - 209542 != -115513)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (85110 - 562767 != -477656)
				{
					base..ctor();
					if (278829 - 376833 == -98004)
					{
						this.$self_$36603 = self_;
						if (241979 - 207810 == 34169)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x00F2216C File Offset: 0x00F2036C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G34_ExcavationCamp.$ExcavationCampStartEvent$36596.$(this.$self_$36603);
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x00F2217C File Offset: 0x00F2037C
		internal static bool j7I9NXpCRp9LDiHkKwR9()
		{
			return true;
		}

		// Token: 0x06006BA9 RID: 27561 RVA: 0x00F22180 File Offset: 0x00F20380
		internal static bool sAK05LpCwIK7RfnL4pgP()
		{
			return false;
		}

		// Token: 0x04007420 RID: 29728
		internal G34_ExcavationCamp $self_$36603;

		// Token: 0x02001241 RID: 4673
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006BAA RID: 27562 RVA: 0x00F22184 File Offset: 0x00F20384
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G34_ExcavationCamp self_)
			{
				if (246199 - 430263 != -184063)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (44175 - 183099 != -138923)
					{
						base..ctor();
						if (196665 - 45502 != 151164)
						{
							this.$self_$36602 = self_;
							if (82754 - 265314 == -182560)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006BAB RID: 27563 RVA: 0x00F2221C File Offset: 0x00F2041C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (245050 - 376639 != -131588)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_407;
					case 1:
						goto IL_501;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (105866 - 458243 != -352376)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$self_$36602.SendMessage("fadeOut");
							if (227794 - 109680 != 118114)
							{
								continue;
							}
							goto IL_3CC;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (167877 - 220487 != -52610)
							{
								continue;
							}
							goto IL_4D3;
						}
						break;
					default:
						if (138547 - 164738 != -26191)
						{
							continue;
						}
						goto IL_407;
					}
					IL_32A:
					this.$startPoint$36600 = GameObject.Find("StartPoint2");
					if (174328 - 155840 == 18489)
					{
						continue;
					}
					this.$startCamera$36601 = GameObject.Find("StartCamera2");
					if (34440 - 366615 != -332175)
					{
						continue;
					}
					if (this.$startCamera$36601)
					{
						if (129264 - 260908 == -131643)
						{
							continue;
						}
						this.$self_$36602.transform.position = this.$startCamera$36601.transform.position;
						if (55514 - 116652 != -61138)
						{
							continue;
						}
						this.$self_$36602.transform.rotation = this.$startCamera$36601.transform.rotation;
						if (221113 - 252709 != -31596)
						{
							continue;
						}
					}
					if (this.$startPoint$36600)
					{
						if (115757 - 394865 == -279107)
						{
							continue;
						}
						this.$self_$36602.CreatePlayer(CharacterData.current.CID, this.$startPoint$36600.transform.position, this.$startPoint$36600.transform.forward);
						if (222350 - 533409 == -311058)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Error: Startpoint not found");
						if (97963 - 14328 != 83635)
						{
							continue;
						}
					}
					this.YieldDefault(1);
					if (164342 - 63814 != 100529)
					{
						goto Block_33;
					}
					continue;
					IL_407:
					Game.mGameState = eGameState.Start;
					if (134599 - 498214 != -363614)
					{
						Game.mStateTime = Time.time;
						if (242727 - 228397 == 14330)
						{
							this.$mEventCamera1$36597 = GameObject.Find("EventCamera1");
							if (44158 - 559445 != -515286)
							{
								this.$mEventCamera2$36598 = GameObject.Find("EventCamera2");
								if (233162 - 354512 != -121349)
								{
									if (this.$mEventCamera1$36597)
									{
										if (245012 - 411142 != -166130)
										{
											continue;
										}
										if (this.$mEventCamera2$36598)
										{
											if (197039 - 540307 == -343267)
											{
												continue;
											}
											this.$self_$36602.transform.position = this.$mEventCamera1$36597.transform.position;
											if (173851 - 80749 == 93103)
											{
												continue;
											}
											this.$self_$36602.transform.rotation = this.$mEventCamera1$36597.transform.rotation;
											if (91331 - 24495 != 66836)
											{
												continue;
											}
											this.$mPlayerCameraControl$36599 = (PlayerCameraControl)this.$self_$36602.GetComponent(typeof(PlayerCameraControl));
											if (212253 - 318357 != -106104)
											{
												continue;
											}
											if (this.$mPlayerCameraControl$36599)
											{
												if (163190 - 463011 == -299820)
												{
													continue;
												}
												this.$mPlayerCameraControl$36599.StartCoroutine_Auto(this.$mPlayerCameraControl$36599.slerpToObject("EventCamera2", 2.5f));
												if (88837 - 474922 != -386085)
												{
													continue;
												}
											}
											this.$self_$36602.SendMessage("fadeIn");
											if (190169 - 371348 != -181178)
											{
												break;
											}
											continue;
										}
									}
									Debug.LogError("Cannot find EventCamera1 or EventCamera2");
									if (57700 - 425753 != -368052)
									{
										goto IL_32A;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				Block_22:
				goto IL_501;
				IL_3CC:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_33:
				IL_4D3:
				IL_501:
				return false;
			}

			// Token: 0x06006BAC RID: 27564 RVA: 0x00F2273C File Offset: 0x00F2093C
			internal static bool RjpeCUpCqA74Dxd74XTW()
			{
				return true;
			}

			// Token: 0x06006BAD RID: 27565 RVA: 0x00F22740 File Offset: 0x00F20940
			internal static bool XkrXGBpC7YZU09dJ4Orn()
			{
				return false;
			}

			// Token: 0x04007421 RID: 29729
			internal GameObject $mEventCamera1$36597;

			// Token: 0x04007422 RID: 29730
			internal GameObject $mEventCamera2$36598;

			// Token: 0x04007423 RID: 29731
			internal PlayerCameraControl $mPlayerCameraControl$36599;

			// Token: 0x04007424 RID: 29732
			internal GameObject $startPoint$36600;

			// Token: 0x04007425 RID: 29733
			internal GameObject $startCamera$36601;

			// Token: 0x04007426 RID: 29734
			internal G34_ExcavationCamp $self_$36602;
		}
	}

	// Token: 0x02001242 RID: 4674
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$36604 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006BAE RID: 27566 RVA: 0x00F22744 File Offset: 0x00F20944
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$36604(G34_ExcavationCamp self_)
		{
			if (106519 - 285262 != -178743)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (262008 - 393859 == -131851)
				{
					base..ctor();
					if (191946 - 510336 != -318389)
					{
						this.$self_$36612 = self_;
						if (186912 - 240928 != -54015)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006BAF RID: 27567 RVA: 0x00F227DC File Offset: 0x00F209DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G34_ExcavationCamp.$TalkToRedPanda$36604.$(this.$self_$36612);
		}

		// Token: 0x06006BB0 RID: 27568 RVA: 0x00F227EC File Offset: 0x00F209EC
		internal static bool Ol0172pCP9Jm9TNX4NlW()
		{
			return true;
		}

		// Token: 0x06006BB1 RID: 27569 RVA: 0x00F227F0 File Offset: 0x00F209F0
		internal static bool FA7Xs6pC0UaBx1p2oH38()
		{
			return false;
		}

		// Token: 0x04007427 RID: 29735
		internal G34_ExcavationCamp $self_$36612;

		// Token: 0x02001243 RID: 4675
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006BB2 RID: 27570 RVA: 0x00F227F4 File Offset: 0x00F209F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G34_ExcavationCamp self_)
			{
				if (4829 - 343620 != -338791)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (212170 - 167635 != 44536)
					{
						base..ctor();
						if (167741 - 191483 != -23741)
						{
							this.$self_$36611 = self_;
							if (298107 - 254736 != 43372)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006BB3 RID: 27571 RVA: 0x00F2288C File Offset: 0x00F20A8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211943 - 53645 != 158299)
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
						this.$mStoryGui$36609.newStoryMessage("RedPandaSit", "RedPanda", Language.getMessage("MissionGui", 306 + UnityEngine.Random.Range(0, 5)), eTalkType.friend);
						if (290778 - 142627 == 148152)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("nvoice", 1) == 0)
						{
							goto IL_55C;
						}
						if (174229 - 229381 != -55152)
						{
							continue;
						}
						if (!this.$self_$36611.Co7cSFW7nkM)
						{
							if (105625 - 398323 != -292698)
							{
								continue;
							}
							this.$self_$36611.Co7cSFW7nkM = (AudioClip)Resources.Load("Sound/Voice/mission306_vc", typeof(AudioClip));
							if (94931 - 56275 == 38657)
							{
								continue;
							}
						}
						if (this.$self_$36611.Co7cSFW7nkM)
						{
							if (160981 - 469761 == -308779)
							{
								continue;
							}
							this.$self_$36611.audio.PlayOneShot(this.$self_$36611.Co7cSFW7nkM);
							if (151950 - 564421 != -412471)
							{
								continue;
							}
							goto IL_4B5;
						}
						else
						{
							Debug.LogError("Missing mission306 voice");
							if (297559 - 104787 != 192773)
							{
								goto Block_33;
							}
							continue;
						}
						break;
					case 3:
						this.$mStoryGui$36609.close();
						if (1117 - 401205 == -400087)
						{
							continue;
						}
						this.$mGameGui$36605.enabled = true;
						if (177744 - 130767 != 46978)
						{
							goto Block_7;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (207815 - 153293 != 54522)
						{
							continue;
						}
						goto IL_3EC;
					default:
						if (220078 - 490705 == -270626)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (140178 - 398790 != -258612)
						{
							continue;
						}
						break;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (152645 - 16450 != 136195)
						{
							continue;
						}
						this.$mGameGui$36605 = (GameGui)this.$self_$36611.GetComponent(typeof(GameGui));
						if (96076 - 517148 != -421072)
						{
							continue;
						}
						this.$mChangeGui$36606 = (ChangeGui)this.$self_$36611.GetComponent(typeof(ChangeGui));
						if (202091 - 69711 != 132380)
						{
							continue;
						}
						if (this.$mGameGui$36605)
						{
							if (64352 - 3322 != 61030)
							{
								continue;
							}
							this.$mGameGui$36605.close();
							if (136734 - 29698 != 107036)
							{
								continue;
							}
						}
						if (this.$mChangeGui$36606)
						{
							if (121787 - 231744 == -109956)
							{
								continue;
							}
							this.$mChangeGui$36606.disable();
							if (257481 - 514989 == -257507)
							{
								continue;
							}
						}
						this.$mPlayer$36607 = Game.mPlayer;
						if (101233 - 121649 != -20416)
						{
							continue;
						}
						this.$mRedPanda$36608 = GameObject.Find("RedPanda");
						if (142826 - 132539 == 10288)
						{
							continue;
						}
						if (!this.$mRedPanda$36608)
						{
							goto IL_1AE;
						}
						if (267705 - 364193 == -96487)
						{
							continue;
						}
						if (!this.$mPlayer$36607)
						{
							goto IL_1AE;
						}
						if (157562 - 550034 != -392472)
						{
							continue;
						}
						this.$mPlayer$36607.SendMessage("turnToPos", this.$mRedPanda$36608.transform.position);
						if (283957 - 501550 == -217592)
						{
							continue;
						}
						IL_3A1:
						if (PlayerData.SLv <= 42)
						{
							if (72177 - 262561 != -190384)
							{
								continue;
							}
							this.$mStoryGui$36609 = (StoryGui)this.$self_$36611.GetComponent(typeof(StoryGui));
							if (254362 - 206477 != 47885)
							{
								continue;
							}
							if (!this.$mStoryGui$36609)
							{
								goto IL_3EC;
							}
							if (62832 - 374570 == -311737)
							{
								continue;
							}
							this.$mStoryGui$36609.startStoryMessage("RedPandaSit", "RedPanda", eTalkType.friend);
							if (226906 - 61697 != 165210)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$mMissionGui$36610 = (MissionGui)this.$self_$36611.GetComponent(typeof(MissionGui));
							if (53027 - 120784 == -67756)
							{
								continue;
							}
							if (!this.$mMissionGui$36610)
							{
								goto IL_8F;
							}
							if (190353 - 262649 == -72295)
							{
								continue;
							}
							this.$mMissionGui$36610.mType = eMissionGuiType.guild;
							if (123334 - 415782 == -292447)
							{
								continue;
							}
							this.$mMissionGui$36610.enabled = true;
							if (103978 - 468698 != -364719)
							{
								goto IL_8F;
							}
							continue;
						}
						IL_1AE:
						Debug.LogError("Cannot find RedPanda");
						if (143879 - 574565 != -430685)
						{
							goto IL_3A1;
						}
						continue;
					}
					IL_8F:
					this.YieldDefault(1);
					if (218893 - 112509 != 106385)
					{
						break;
					}
					continue;
					IL_3EC:
					goto IL_8F;
				}
				goto IL_664;
				Block_7:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_12:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_664;
				IL_4B5:
				Block_33:
				IL_55C:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_664:
				return false;
			}

			// Token: 0x06006BB4 RID: 27572 RVA: 0x00F22F10 File Offset: 0x00F21110
			internal static bool Kw72SrpCbRw3naEMgquL()
			{
				return true;
			}

			// Token: 0x06006BB5 RID: 27573 RVA: 0x00F22F14 File Offset: 0x00F21114
			internal static bool wxXm48pCuLFhf6Y3xTUT()
			{
				return false;
			}

			// Token: 0x04007428 RID: 29736
			internal GameGui $mGameGui$36605;

			// Token: 0x04007429 RID: 29737
			internal ChangeGui $mChangeGui$36606;

			// Token: 0x0400742A RID: 29738
			internal GameObject $mPlayer$36607;

			// Token: 0x0400742B RID: 29739
			internal GameObject $mRedPanda$36608;

			// Token: 0x0400742C RID: 29740
			internal StoryGui $mStoryGui$36609;

			// Token: 0x0400742D RID: 29741
			internal MissionGui $mMissionGui$36610;

			// Token: 0x0400742E RID: 29742
			internal G34_ExcavationCamp $self_$36611;
		}
	}

	// Token: 0x02001244 RID: 4676
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLizard$36613 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006BB6 RID: 27574 RVA: 0x00F22F18 File Offset: 0x00F21118
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLizard$36613(G34_ExcavationCamp self_)
		{
			if (9824 - 199612 != -189787)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131980 - 253086 != -121105)
				{
					base..ctor();
					if (244342 - 219951 != 24392)
					{
						this.$self_$36623 = self_;
						if (80792 - 371329 == -290537)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006BB7 RID: 27575 RVA: 0x00F22FB0 File Offset: 0x00F211B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G34_ExcavationCamp.$TalkToLizard$36613.$(this.$self_$36623);
		}

		// Token: 0x06006BB8 RID: 27576 RVA: 0x00F22FC0 File Offset: 0x00F211C0
		internal static bool MQcLL0pCIt9kl35eu5O3()
		{
			return true;
		}

		// Token: 0x06006BB9 RID: 27577 RVA: 0x00F22FC4 File Offset: 0x00F211C4
		internal static bool IZkGaKpCBwF2bZyf3Ga1()
		{
			return false;
		}

		// Token: 0x0400742F RID: 29743
		internal G34_ExcavationCamp $self_$36623;

		// Token: 0x02001245 RID: 4677
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006BBA RID: 27578 RVA: 0x00F22FC8 File Offset: 0x00F211C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G34_ExcavationCamp self_)
			{
				if (295781 - 43680 != 252101)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (56088 - 528566 == -472478)
					{
						base..ctor();
						if (282193 - 138768 == 143425)
						{
							this.$self_$36622 = self_;
							if (228678 - 155488 == 73190)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006BBB RID: 27579 RVA: 0x00F23060 File Offset: 0x00F21260
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (270269 - 54355 != 215915)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						goto IL_B20;
					case 1:
						goto IL_C3E;
					case 2:
						this.$mStoryGui$36619.newStoryMessage("Lizard", "Liza", Language.getMessage("MissionGui", 1131), eTalkType.friend);
						if (243119 - 229352 != 13767)
						{
							continue;
						}
						this.$mStoryTimer$36620 = Time.time + 4f;
						if (143014 - 16477 != 126538)
						{
							goto Block_37;
						}
						continue;
					case 3:
						break;
					case 4:
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (299903 - 261693 != 38211)
							{
								goto Block_47;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (215138 - 71384 != 143754)
							{
								continue;
							}
							goto IL_45B;
						}
						break;
					case 6:
						this.$mStoryGui$36619.newStoryMessage("Lizard", "Liza", Language.getMessage("MissionGui", 1132), eTalkType.friend);
						if (7404 - 278031 != -270627)
						{
							continue;
						}
						this.$mStoryTimer$36620 = Time.time + 4f;
						if (291853 - 270829 != 21025)
						{
							goto Block_24;
						}
						continue;
					case 7:
						goto IL_92F;
					case 8:
						goto IL_92F;
					case 9:
						goto IL_6EF;
					case 10:
						goto IL_6EF;
					case 11:
						if (Game.mGameState != eGameState.Hold)
						{
							if (178955 - 90494 != 88462)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (88106 - 285225 != -197119)
							{
								continue;
							}
							goto IL_45B;
						}
						break;
					default:
						if (182930 - 263528 != -80598)
						{
							continue;
						}
						goto IL_B20;
					}
					if (this.$mStoryTimer$36620 > Time.time)
					{
						if (193420 - 339655 != -146235)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3FF;
						}
						if (231315 - 27481 != 203834)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (70787 - 538443 != -467656)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$36619.close();
						if (272464 - 548655 == -276190)
						{
							continue;
						}
						this.$mGameGui$36614.enabled = true;
						if (71465 - 492229 != -420764)
						{
							continue;
						}
						if (!this.$mLizard$36617)
						{
							goto IL_5AB;
						}
						if (260037 - 146181 != 113856)
						{
							continue;
						}
						this.$mLizard$36617.animation.CrossFade("root", 0.2f);
						if (85231 - 386471 != -301240)
						{
							continue;
						}
						goto IL_5AB;
					}
					IL_92F:
					if (this.$mStoryTimer$36620 > Time.time)
					{
						if (134623 - 547933 == -413309)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_923;
						}
						if (2997 - 278680 != -275683)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (279976 - 363725 != -83749)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$36619.newStoryMessage("Lizard", "Liza", Language.getMessage("MissionGui", 1133), eTalkType.friend);
						if (121255 - 468315 != -347060)
						{
							continue;
						}
						this.$mStoryTimer$36620 = Time.time + 4f;
						if (29662 - 440114 != -410452)
						{
							continue;
						}
						goto IL_6C6;
					}
					IL_B20:
					if (PlayerData.QuestID == 54)
					{
						if (24619 - 164217 != -139598)
						{
							continue;
						}
						Q54_LizaResearch.TalkToLizard(this.$self_$36622.gameObject);
						if (161938 - 334965 != -173027)
						{
							continue;
						}
						goto IL_45B;
					}
					else if (PlayerData.QuestID == -54)
					{
						if (49552 - 520942 == -471389)
						{
							continue;
						}
						Q54_LizaResearch.TalkToLizardRepeat(this.$self_$36622.gameObject);
						if (231241 - 392242 != -161000)
						{
							goto IL_45B;
						}
						continue;
					}
					else if (PlayerData.QuestID == 73)
					{
						if (124592 - 123485 == 1108)
						{
							continue;
						}
						Q73_GeologyStudy.TalkToLizard(this.$self_$36622.gameObject);
						if (245580 - 130919 != 114662)
						{
							goto IL_45B;
						}
						continue;
					}
					else if (PlayerData.QuestID == -73)
					{
						if (81265 - 551224 == -469958)
						{
							continue;
						}
						Q73_GeologyStudy.TalkToLizardRepeat(this.$self_$36622.gameObject);
						if (114805 - 525276 != -410470)
						{
							goto IL_45B;
						}
						continue;
					}
					else if (Game.mGameState != eGameState.Normal)
					{
						if (265312 - 147879 != 117433)
						{
							continue;
						}
						break;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (281288 - 75980 == 205309)
						{
							continue;
						}
						this.$mGameGui$36614 = (GameGui)this.$self_$36622.GetComponent(typeof(GameGui));
						if (36628 - 406436 != -369808)
						{
							continue;
						}
						this.$mChangeGui$36615 = (ChangeGui)this.$self_$36622.GetComponent(typeof(ChangeGui));
						if (239346 - 524526 != -285180)
						{
							continue;
						}
						if (this.$mGameGui$36614)
						{
							if (142148 - 163753 == -21604)
							{
								continue;
							}
							this.$mGameGui$36614.close();
							if (44423 - 136030 != -91607)
							{
								continue;
							}
						}
						if (this.$mChangeGui$36615)
						{
							if (225507 - 378300 != -152793)
							{
								continue;
							}
							this.$mChangeGui$36615.disable();
							if (18979 - 392067 != -373088)
							{
								continue;
							}
						}
						this.$mPlayer$36616 = Game.mPlayer;
						if (82874 - 464688 == -381813)
						{
							continue;
						}
						this.$mLizard$36617 = GameObject.Find("Lizard");
						if (267332 - 231593 == 35740)
						{
							continue;
						}
						this.$mLizardOriginalDir$36618 = default(Vector3);
						if (128273 - 279813 != -151540)
						{
							continue;
						}
						if (this.$mLizard$36617)
						{
							if (96014 - 342721 != -246707)
							{
								continue;
							}
							if (this.$mPlayer$36616)
							{
								if (298247 - 506411 != -208164)
								{
									continue;
								}
								this.$mLizard$36617.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$36616.transform.position - this.$mLizard$36617.transform.position));
								if (16518 - 584290 != -567772)
								{
									continue;
								}
								this.$mLizard$36617.animation.CrossFade("talk", 0.2f);
								if (259193 - 54761 != 204432)
								{
									continue;
								}
								this.$mPlayer$36616.SendMessage("turnToPos", this.$mLizard$36617.transform.position);
								if (157751 - 128951 != 28800)
								{
									continue;
								}
							}
						}
						this.$mStoryGui$36619 = (StoryGui)this.$self_$36622.GetComponent(typeof(StoryGui));
						if (222738 - 493244 != -270506)
						{
							continue;
						}
						this.$mStoryTimer$36620 = 0f;
						if (114255 - 191640 != -77385)
						{
							continue;
						}
						if (PlayerData.SLv >= 45)
						{
							if (17672 - 350183 == -332510)
							{
								continue;
							}
							if (CharacterData.current.lv < 40)
							{
								if (18761 - 438271 != -419510)
								{
									continue;
								}
							}
							else if (CharacterData.current.getItemTotalNum("k_dun1") < 1)
							{
								if (197931 - 413484 == -215552)
								{
									continue;
								}
								this.$mStoryGui$36619.startStoryMessage("Lizard", "Liza", eTalkType.friend);
								if (221894 - 76509 != 145386)
								{
									goto Block_40;
								}
								continue;
							}
							else
							{
								this.$mMissionGui$36621 = (MissionGui)this.$self_$36622.GetComponent(typeof(MissionGui));
								if (247466 - 529415 != -281949)
								{
									continue;
								}
								if (!this.$mMissionGui$36621)
								{
									goto IL_45B;
								}
								if (215252 - 137613 == 77640)
								{
									continue;
								}
								this.$mMissionGui$36621.mType = eMissionGuiType.dungeon;
								if (164808 - 186203 != -21395)
								{
									continue;
								}
								this.$mMissionGui$36621.enabled = true;
								if (123885 - 568245 != -444360)
								{
									continue;
								}
								goto IL_45B;
							}
						}
						this.$mStoryGui$36619.startStoryMessage("Lizard", "Liza", eTalkType.friend);
						if (226968 - 456670 != -229701)
						{
							goto Block_91;
						}
						continue;
					}
					IL_6EF:
					if (this.$mStoryTimer$36620 > Time.time)
					{
						if (156416 - 529771 != -373355)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6E2;
						}
						if (268326 - 409310 == -140983)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (106961 - 282800 != -175838)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$36619.close();
						if (251745 - 441674 != -189929)
						{
							continue;
						}
						this.$mGameGui$36614.enabled = true;
						if (99263 - 53367 != 45896)
						{
							continue;
						}
						if (!this.$mLizard$36617)
						{
							goto IL_31E;
						}
						if (150295 - 265208 == -114912)
						{
							continue;
						}
						this.$mLizard$36617.animation.CrossFade("root", 0.2f);
						if (276610 - 248421 != 28190)
						{
							goto Block_36;
						}
						continue;
					}
					IL_45B:
					this.YieldDefault(1);
				}
				while (134321 - 380037 == -245715);
				goto IL_C3E;
				Block_24:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_31E:
				return this.Yield(11, new WaitForSeconds(1f));
				Block_26:
				goto IL_C3E;
				IL_3FF:
				return this.YieldDefault(4);
				goto IL_C3E;
				Block_36:
				goto IL_31E;
				Block_37:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_40:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_5AB:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_47:
				goto IL_C3E;
				IL_6C6:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_6E2:
				return this.YieldDefault(10);
				IL_923:
				return this.YieldDefault(8);
				Block_91:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_C3E:
				return false;
			}

			// Token: 0x06006BBC RID: 27580 RVA: 0x00F23CC0 File Offset: 0x00F21EC0
			internal static bool zVOhXBpCe8gyXhnAc5u0()
			{
				return true;
			}

			// Token: 0x06006BBD RID: 27581 RVA: 0x00F23CC4 File Offset: 0x00F21EC4
			internal static bool LIq1BNpCrfcCkcPQMBOm()
			{
				return false;
			}

			// Token: 0x04007430 RID: 29744
			internal GameGui $mGameGui$36614;

			// Token: 0x04007431 RID: 29745
			internal ChangeGui $mChangeGui$36615;

			// Token: 0x04007432 RID: 29746
			internal GameObject $mPlayer$36616;

			// Token: 0x04007433 RID: 29747
			internal GameObject $mLizard$36617;

			// Token: 0x04007434 RID: 29748
			internal Vector3 $mLizardOriginalDir$36618;

			// Token: 0x04007435 RID: 29749
			internal StoryGui $mStoryGui$36619;

			// Token: 0x04007436 RID: 29750
			internal float $mStoryTimer$36620;

			// Token: 0x04007437 RID: 29751
			internal MissionGui $mMissionGui$36621;

			// Token: 0x04007438 RID: 29752
			internal G34_ExcavationCamp $self_$36622;
		}
	}

	// Token: 0x02001246 RID: 4678
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToJerboa$36624 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006BBE RID: 27582 RVA: 0x00F23CC8 File Offset: 0x00F21EC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToJerboa$36624(int n, G34_ExcavationCamp self_)
		{
			if (96511 - 212912 != -116400)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (55874 - 391748 != -335873)
				{
					base..ctor();
					if (299900 - 375539 != -75638)
					{
						this.$n$36639 = n;
						if (92519 - 525287 != -432767)
						{
							this.$self_$36640 = self_;
							if (75551 - 351686 == -276135)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006BBF RID: 27583 RVA: 0x00F23D84 File Offset: 0x00F21F84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G34_ExcavationCamp.$TalkToJerboa$36624.$(this.$n$36639, this.$self_$36640);
		}

		// Token: 0x06006BC0 RID: 27584 RVA: 0x00F23D98 File Offset: 0x00F21F98
		internal static bool dfhXeYpCj1qhO8IgyDWg()
		{
			return true;
		}

		// Token: 0x06006BC1 RID: 27585 RVA: 0x00F23D9C File Offset: 0x00F21F9C
		internal static bool f9Vk11pCh36xLAiD69QO()
		{
			return false;
		}

		// Token: 0x04007439 RID: 29753
		internal int $n$36639;

		// Token: 0x0400743A RID: 29754
		internal G34_ExcavationCamp $self_$36640;

		// Token: 0x02001247 RID: 4679
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006BC2 RID: 27586 RVA: 0x00F23DA0 File Offset: 0x00F21FA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, G34_ExcavationCamp self_)
			{
				if (268200 - 171200 != 97000)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (53308 - 83589 == -30281)
					{
						base..ctor();
						if (143643 - 441907 != -298263)
						{
							this.$n$36637 = n;
							if (221519 - 216120 == 5399)
							{
								this.$self_$36638 = self_;
								if (265664 - 230123 == 35541)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006BC3 RID: 27587 RVA: 0x00F23E5C File Offset: 0x00F2205C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (166730 - 532400 != -365669)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_92E;
					case 2:
						this.$nMessage$36630 = string.Empty;
						if (11500 - 273711 == -262210)
						{
							continue;
						}
						if (this.$n$36637 == 1)
						{
							if (264753 - 250356 == 14398)
							{
								continue;
							}
							int num = this.$self_$36638.In1cSATpg3G = (this.$$10937$36631 = this.$self_$36638.In1cSATpg3G) + 1;
							this.$$switch$6174$36632 = this.$$10937$36631;
							if (88905 - 473703 == -384797)
							{
								continue;
							}
							if (this.$$switch$6174$36632 == 0)
							{
								if (123857 - 483105 == -359247)
								{
									continue;
								}
								this.$nMessage$36630 = Language.getMessage("G34_ExcavationCamp", 211);
								if (91451 - 408327 != -316876)
								{
									continue;
								}
							}
							else if (this.$$switch$6174$36632 == 1)
							{
								if (53299 - 106182 == -52882)
								{
									continue;
								}
								this.$nMessage$36630 = Language.getMessage("G34_ExcavationCamp", 212);
								if (82252 - 416189 == -333936)
								{
									continue;
								}
							}
							else if (this.$$switch$6174$36632 == 2)
							{
								if (200364 - 258898 != -58534)
								{
									continue;
								}
								this.$nMessage$36630 = Language.getMessage("G34_ExcavationCamp", 213);
								if (102087 - 106141 == -4053)
								{
									continue;
								}
							}
							else
							{
								this.$nMessage$36630 = Language.getMessage("G34_ExcavationCamp", UnityEngine.Random.Range(211, 216));
								if (32781 - 392438 != -359657)
								{
									continue;
								}
							}
						}
						else if (this.$n$36637 == 2)
						{
							if (30411 - 475507 != -445096)
							{
								continue;
							}
							int num2 = this.$self_$36638.R8HcS9cGPlU = (this.$$10938$36633 = this.$self_$36638.R8HcS9cGPlU) + 1;
							this.$$switch$6176$36634 = this.$$10938$36633;
							if (77019 - 458767 != -381748)
							{
								continue;
							}
							if (this.$$switch$6176$36634 == 0)
							{
								if (33461 - 347945 == -314483)
								{
									continue;
								}
								this.$nMessage$36630 = Language.getMessage("G34_ExcavationCamp", 221);
								if (256073 - 402037 != -145964)
								{
									continue;
								}
							}
							else if (this.$$switch$6176$36634 == 1)
							{
								if (139855 - 329495 != -189640)
								{
									continue;
								}
								this.$nMessage$36630 = Language.getMessage("G34_ExcavationCamp", 222);
								if (266993 - 102601 == 164393)
								{
									continue;
								}
							}
							else if (this.$$switch$6176$36634 == 2)
							{
								if (66013 - 279178 == -213164)
								{
									continue;
								}
								this.$nMessage$36630 = Language.getMessage("G34_ExcavationCamp", 223);
								if (183597 - 7503 == 176095)
								{
									continue;
								}
							}
							else
							{
								this.$nMessage$36630 = Language.getMessage("G34_ExcavationCamp", UnityEngine.Random.Range(221, 226));
								if (225508 - 17775 != 207733)
								{
									continue;
								}
							}
						}
						else
						{
							int num3 = this.$self_$36638.i6ScSWn23fr = (this.$$10939$36635 = this.$self_$36638.i6ScSWn23fr) + 1;
							this.$$switch$6178$36636 = this.$$10939$36635;
							if (287413 - 179868 != 107545)
							{
								continue;
							}
							if (this.$$switch$6178$36636 == 0)
							{
								if (166352 - 252776 != -86424)
								{
									continue;
								}
								this.$nMessage$36630 = Language.getMessage("G34_ExcavationCamp", 231);
								if (214879 - 358056 != -143177)
								{
									continue;
								}
							}
							else if (this.$$switch$6178$36636 == 1)
							{
								if (152853 - 517874 == -365020)
								{
									continue;
								}
								this.$nMessage$36630 = Language.getMessage("G34_ExcavationCamp", 232);
								if (147764 - 318155 == -170390)
								{
									continue;
								}
							}
							else if (this.$$switch$6178$36636 == 2)
							{
								if (23086 - 489730 != -466644)
								{
									continue;
								}
								this.$nMessage$36630 = Language.getMessage("G34_ExcavationCamp", 233);
								if (188726 - 98233 != 90493)
								{
									continue;
								}
							}
							else
							{
								this.$nMessage$36630 = Language.getMessage("G34_ExcavationCamp", UnityEngine.Random.Range(231, 236));
								if (152897 - 295245 == -142347)
								{
									continue;
								}
							}
						}
						this.$mStoryGui$36629.newStoryMessage("none", "Jerboa", this.$nMessage$36630, eTalkType.friend);
						if (203097 - 546316 != -343218)
						{
							goto Block_35;
						}
						continue;
					case 3:
						this.$mStoryGui$36629.close();
						if (82222 - 340065 == -257842)
						{
							continue;
						}
						this.$mGameGui$36628.enabled = true;
						if (86482 - 151371 != -64889)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (2646 - 98174 == -95527)
						{
							continue;
						}
						this.YieldDefault(1);
						if (3215 - 40410 != -37195)
						{
							continue;
						}
						goto IL_92E;
					default:
						if (141314 - 452860 == -311545)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (206434 - 295256 != -88821)
						{
							goto Block_27;
						}
					}
					else
					{
						this.$mPlayer$36625 = Game.mPlayer;
						if (232758 - 124862 != 107897)
						{
							this.$mJerboa$36626 = GameObject.Find("Jerboa" + this.$n$36637);
							if (12998 - 137324 == -124326)
							{
								this.$mJerboaOriginalDir$36627 = default(Vector3);
								if (72434 - 326571 != -254136)
								{
									if (this.$mJerboa$36626)
									{
										if (133083 - 113039 == 20045)
										{
											continue;
										}
										if (this.$mPlayer$36625)
										{
											if (284854 - 1202 == 283653)
											{
												continue;
											}
											this.$mJerboa$36626.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$36625.transform.position - this.$mJerboa$36626.transform.position));
											if (208210 - 510160 != -301950)
											{
												continue;
											}
											this.$mPlayer$36625.SendMessage("turnToPos", this.$mJerboa$36626.transform.position);
											if (70489 - 557832 != -487343)
											{
												continue;
											}
										}
									}
									Game.mGameState = eGameState.Hold;
									if (80339 - 178889 != -98549)
									{
										this.$mGameGui$36628 = (GameGui)this.$self_$36638.GetComponent(typeof(GameGui));
										if (264980 - 497845 == -232865)
										{
											if (this.$mGameGui$36628)
											{
												if (221897 - 414390 == -192492)
												{
													continue;
												}
												this.$mGameGui$36628.close();
												if (270450 - 319440 == -48989)
												{
													continue;
												}
											}
											this.$mStoryGui$36629 = (StoryGui)this.$self_$36638.GetComponent(typeof(StoryGui));
											if (91758 - 557685 != -465926)
											{
												this.$mStoryGui$36629.startStoryMessage("none", "Jerboa", eTalkType.friend);
												if (27160 - 149850 != -122689)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_27:
				goto IL_92E;
				Block_35:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_92E:
				return false;
			}

			// Token: 0x06006BC4 RID: 27588 RVA: 0x00F247AC File Offset: 0x00F229AC
			internal static bool DDKAl6pCsnpjktRuWYXH()
			{
				return true;
			}

			// Token: 0x06006BC5 RID: 27589 RVA: 0x00F247B0 File Offset: 0x00F229B0
			internal static bool ap5EyQpC978dnE4aPghx()
			{
				return false;
			}

			// Token: 0x0400743B RID: 29755
			internal GameObject $mPlayer$36625;

			// Token: 0x0400743C RID: 29756
			internal GameObject $mJerboa$36626;

			// Token: 0x0400743D RID: 29757
			internal Vector3 $mJerboaOriginalDir$36627;

			// Token: 0x0400743E RID: 29758
			internal GameGui $mGameGui$36628;

			// Token: 0x0400743F RID: 29759
			internal StoryGui $mStoryGui$36629;

			// Token: 0x04007440 RID: 29760
			internal string $nMessage$36630;

			// Token: 0x04007441 RID: 29761
			internal int $$10937$36631;

			// Token: 0x04007442 RID: 29762
			internal int $$switch$6174$36632;

			// Token: 0x04007443 RID: 29763
			internal int $$10938$36633;

			// Token: 0x04007444 RID: 29764
			internal int $$switch$6176$36634;

			// Token: 0x04007445 RID: 29765
			internal int $$10939$36635;

			// Token: 0x04007446 RID: 29766
			internal int $$switch$6178$36636;

			// Token: 0x04007447 RID: 29767
			internal int $n$36637;

			// Token: 0x04007448 RID: 29768
			internal G34_ExcavationCamp $self_$36638;
		}
	}

	// Token: 0x02001248 RID: 4680
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMouse$36641 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006BC6 RID: 27590 RVA: 0x00F247B4 File Offset: 0x00F229B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMouse$36641(G34_ExcavationCamp self_)
		{
			if (88690 - 472985 != -384295)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (69736 - 15541 == 54195)
				{
					base..ctor();
					if (248205 - 582632 == -334427)
					{
						this.$self_$36647 = self_;
						if (282105 - 170456 == 111649)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006BC7 RID: 27591 RVA: 0x00F2484C File Offset: 0x00F22A4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G34_ExcavationCamp.$TalkToMouse$36641.$(this.$self_$36647);
		}

		// Token: 0x06006BC8 RID: 27592 RVA: 0x00F2485C File Offset: 0x00F22A5C
		internal static bool OS7DrkpC15msAN2Z3FGJ()
		{
			return true;
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x00F24860 File Offset: 0x00F22A60
		internal static bool avoHY6pC4ka2kTtkviu1()
		{
			return false;
		}

		// Token: 0x04007449 RID: 29769
		internal G34_ExcavationCamp $self_$36647;

		// Token: 0x02001249 RID: 4681
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006BCA RID: 27594 RVA: 0x00F24864 File Offset: 0x00F22A64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G34_ExcavationCamp self_)
			{
				if (61999 - 9460 != 52539)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (82819 - 120626 != -37806)
					{
						base..ctor();
						if (167447 - 396609 != -229161)
						{
							this.$self_$36646 = self_;
							if (73176 - 401821 != -328644)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006BCB RID: 27595 RVA: 0x00F248FC File Offset: 0x00F22AFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (231141 - 182220 != 48922)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_292;
					case 1:
						goto IL_54B;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (164003 - 162019 != 1984)
							{
								continue;
							}
							goto IL_422;
						}
						else
						{
							this.$mStoryGui$36643.newStoryMessage("Mouse", "Abette", Language.getMessage("G34_ExcavationCamp", UnityEngine.Random.Range(301, 306)), eTalkType.friend);
							if (23670 - 14822 != 8848)
							{
								continue;
							}
							goto IL_4AC;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (182676 - 59031 != 123646)
							{
								goto Block_34;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$36643.close();
							if (121390 - 560234 != -438844)
							{
								continue;
							}
							this.$mGameGui$36642.enabled = true;
							if (299775 - 94064 != 205711)
							{
								continue;
							}
							this.$mMouse$36644.animation.CrossFade("root", 0.2f);
							if (48450 - 377715 != -329265)
							{
								continue;
							}
							goto IL_72;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (2737 - 548378 != -545641)
							{
								continue;
							}
							goto IL_39F;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (184198 - 116442 == 67757)
							{
								continue;
							}
						}
						break;
					default:
						if (12822 - 84369 != -71546)
						{
							goto IL_292;
						}
						continue;
					}
					IL_23C:
					this.YieldDefault(1);
					if (206600 - 212519 != -5918)
					{
						goto Block_18;
					}
					continue;
					IL_292:
					if (Game.mGameState != eGameState.Normal)
					{
						if (44110 - 392692 == -348582)
						{
							goto IL_4E7;
						}
					}
					else
					{
						this.$mGameGui$36642 = (GameGui)this.$self_$36646.GetComponent(typeof(GameGui));
						if (30664 - 74325 != -43660)
						{
							this.$mStoryGui$36643 = (StoryGui)this.$self_$36646.GetComponent(typeof(StoryGui));
							if (74011 - 269851 == -195840)
							{
								if (!this.$mGameGui$36642)
								{
									goto IL_23C;
								}
								if (18830 - 41172 == -22342)
								{
									if (!this.$mStoryGui$36643)
									{
										goto IL_23C;
									}
									if (91040 - 490253 != -399212)
									{
										Game.mGameState = eGameState.Hold;
										if (328 - 481561 != -481232)
										{
											this.$mGameGui$36642.close();
											if (53845 - 44715 != 9131)
											{
												this.$mMouse$36644 = GameObject.Find("Mouse");
												if (157385 - 147421 != 9965)
												{
													this.$mMouseRot$36645 = default(Quaternion);
													if (158423 - 249197 == -90774)
													{
														if (!Game.mPlayer)
														{
															goto IL_162;
														}
														if (129951 - 244798 == -114846)
														{
															continue;
														}
														if (!this.$mMouse$36644)
														{
															goto IL_162;
														}
														if (261406 - 345108 != -83702)
														{
															continue;
														}
														this.$mMouseRot$36645 = this.$mMouse$36644.transform.rotation;
														if (267296 - 421369 == -154072)
														{
															continue;
														}
														this.$mMouse$36644.animation.CrossFade("talk", 0.2f);
														if (45454 - 292313 != -246859)
														{
															continue;
														}
														this.$mMouse$36644.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mMouse$36644.transform.position));
														if (113009 - 27804 != 85205)
														{
															continue;
														}
														Game.mPlayer.SendMessage("turnToPos", this.$mMouse$36644.transform.position);
														if (72984 - 86797 != -13813)
														{
															continue;
														}
														IL_AD:
														this.$mStoryGui$36643.startStoryMessage("Mouse", "Abette", eTalkType.friend);
														if (48911 - 108947 != -60035)
														{
															goto Block_5;
														}
														continue;
														IL_162:
														Debug.LogError("Cannot find Mouse");
														if (11434 - 27785 == -16351)
														{
															goto IL_AD;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_72:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_5:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_18:
				IL_39F:
				IL_422:
				goto IL_54B;
				IL_4AC:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_34:
				IL_4E7:
				IL_54B:
				return false;
			}

			// Token: 0x06006BCC RID: 27596 RVA: 0x00F24E68 File Offset: 0x00F23068
			internal static bool qIQ6yjpCzqMTYiFg6ZpL()
			{
				return true;
			}

			// Token: 0x06006BCD RID: 27597 RVA: 0x00F24E6C File Offset: 0x00F2306C
			internal static bool Yyj6YcpLabHK5eAGff8Y()
			{
				return false;
			}

			// Token: 0x0400744A RID: 29770
			internal GameGui $mGameGui$36642;

			// Token: 0x0400744B RID: 29771
			internal StoryGui $mStoryGui$36643;

			// Token: 0x0400744C RID: 29772
			internal GameObject $mMouse$36644;

			// Token: 0x0400744D RID: 29773
			internal Quaternion $mMouseRot$36645;

			// Token: 0x0400744E RID: 29774
			internal G34_ExcavationCamp $self_$36646;
		}
	}

	// Token: 0x0200124A RID: 4682
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseMessageBoard$36648 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006BCE RID: 27598 RVA: 0x00F24E70 File Offset: 0x00F23070
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseMessageBoard$36648(G34_ExcavationCamp self_)
		{
			if (97082 - 440980 != -343898)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (56984 - 517213 != -460228)
				{
					base..ctor();
					if (188142 - 347445 != -159302)
					{
						this.$self_$36654 = self_;
						if (235632 - 25648 != 209985)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006BCF RID: 27599 RVA: 0x00F24F08 File Offset: 0x00F23108
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G34_ExcavationCamp.$UseMessageBoard$36648.$(this.$self_$36654);
		}

		// Token: 0x06006BD0 RID: 27600 RVA: 0x00F24F18 File Offset: 0x00F23118
		internal static bool yFSp2cpL55dWrUCZ5O9G()
		{
			return true;
		}

		// Token: 0x06006BD1 RID: 27601 RVA: 0x00F24F1C File Offset: 0x00F2311C
		internal static bool Ar3WCEpLpsJs96V85r8g()
		{
			return false;
		}

		// Token: 0x0400744F RID: 29775
		internal G34_ExcavationCamp $self_$36654;

		// Token: 0x0200124B RID: 4683
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006BD2 RID: 27602 RVA: 0x00F24F20 File Offset: 0x00F23120
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G34_ExcavationCamp self_)
			{
				if (65694 - 224914 != -159219)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (136035 - 125187 == 10848)
					{
						base..ctor();
						if (245339 - 22471 == 222868)
						{
							this.$self_$36653 = self_;
							if (2357 - 24542 != -22184)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006BD3 RID: 27603 RVA: 0x00F24FB8 File Offset: 0x00F231B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (242031 - 167498 != 74533)
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
							if (17161 - 110170 != -93008)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$mBoardGui$36650.enabled = true;
							if (71813 - 65416 != 6397)
							{
								continue;
							}
							goto IL_28B;
						}
						break;
					default:
						if (148331 - 573930 != -425599)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (164209 - 246081 != -81871)
						{
							goto Block_7;
						}
						continue;
					}
					else
					{
						this.$mGameGui$36649 = (GameGui)this.$self_$36653.GetComponent(typeof(GameGui));
						if (154178 - 36167 != 118011)
						{
							continue;
						}
						this.$mBoardGui$36650 = (BoardGui)this.$self_$36653.GetComponent(typeof(BoardGui));
						if (80709 - 154670 != -73961)
						{
							continue;
						}
						if (this.$mGameGui$36649)
						{
							if (187375 - 77791 == 109585)
							{
								continue;
							}
							if (this.$mBoardGui$36650)
							{
								if (101342 - 561556 != -460214)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (25559 - 354994 == -329434)
								{
									continue;
								}
								this.$mGameGui$36649.close();
								if (212820 - 515635 != -302815)
								{
									continue;
								}
								this.$mPlayer$36651 = Game.mPlayer;
								if (283930 - 367402 != -83472)
								{
									continue;
								}
								this.$mMessageBoard$36652 = GameObject.Find("MessageBoard");
								if (177420 - 110845 == 66576)
								{
									continue;
								}
								if (!this.$mMessageBoard$36652)
								{
									break;
								}
								if (87293 - 554611 != -467318)
								{
									continue;
								}
								if (!this.$mPlayer$36651)
								{
									break;
								}
								if (222226 - 64370 != 157856)
								{
									continue;
								}
								this.$mPlayer$36651.SendMessage("turnToPos", this.$mMessageBoard$36652.transform.position);
								if (8665 - 402844 != -394179)
								{
									continue;
								}
								break;
							}
						}
					}
					IL_28B:
					this.YieldDefault(1);
					if (284920 - 566358 != -281437)
					{
						goto Block_22;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_3:
				Block_7:
				Block_22:
				IL_2EC:
				return false;
			}

			// Token: 0x06006BD4 RID: 27604 RVA: 0x00F252C4 File Offset: 0x00F234C4
			internal static bool LQt3xnpLVFeVBOqDXdhc()
			{
				return true;
			}

			// Token: 0x06006BD5 RID: 27605 RVA: 0x00F252C8 File Offset: 0x00F234C8
			internal static bool ByFqXSpLtWXhWWDCga2k()
			{
				return false;
			}

			// Token: 0x04007450 RID: 29776
			internal GameGui $mGameGui$36649;

			// Token: 0x04007451 RID: 29777
			internal BoardGui $mBoardGui$36650;

			// Token: 0x04007452 RID: 29778
			internal GameObject $mPlayer$36651;

			// Token: 0x04007453 RID: 29779
			internal GameObject $mMessageBoard$36652;

			// Token: 0x04007454 RID: 29780
			internal G34_ExcavationCamp $self_$36653;
		}
	}

	// Token: 0x0200124C RID: 4684
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseTrashBin$36655 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006BD6 RID: 27606 RVA: 0x00F252CC File Offset: 0x00F234CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseTrashBin$36655(G34_ExcavationCamp self_)
		{
			if (105239 - 75245 != 29994)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (94017 - 242431 != -148413)
				{
					base..ctor();
					if (2049 - 307973 == -305924)
					{
						this.$self_$36659 = self_;
						if (49402 - 503556 == -454154)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006BD7 RID: 27607 RVA: 0x00F25364 File Offset: 0x00F23564
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G34_ExcavationCamp.$UseTrashBin$36655.$(this.$self_$36659);
		}

		// Token: 0x06006BD8 RID: 27608 RVA: 0x00F25374 File Offset: 0x00F23574
		internal static bool cpfEbGpLNvuNbtqQcAqK()
		{
			return true;
		}

		// Token: 0x06006BD9 RID: 27609 RVA: 0x00F25378 File Offset: 0x00F23578
		internal static bool LfuVw2pLYgUgTemT9vZM()
		{
			return false;
		}

		// Token: 0x04007455 RID: 29781
		internal G34_ExcavationCamp $self_$36659;

		// Token: 0x0200124D RID: 4685
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006BDA RID: 27610 RVA: 0x00F2537C File Offset: 0x00F2357C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G34_ExcavationCamp self_)
			{
				if (221414 - 56015 != 165400)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (158420 - 444681 != -286260)
					{
						base..ctor();
						if (275173 - 37501 == 237672)
						{
							this.$self_$36658 = self_;
							if (95448 - 148994 != -53545)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006BDB RID: 27611 RVA: 0x00F25414 File Offset: 0x00F23614
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194091 - 301811 != -107720)
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
						if (this.$self_$36658.puRcSyCcOBU)
						{
							if (100741 - 23173 != 77568)
							{
								continue;
							}
							if (this.$self_$36658.YD2cSuUbRUa != "none")
							{
								if (213025 - 212486 == 540)
								{
									continue;
								}
								if (this.$mGameGui$36656)
								{
									if (201840 - 210812 == -8971)
									{
										continue;
									}
									this.$mGameGui$36656.ResetItemMenu();
									if (34287 - 198715 == -164427)
									{
										continue;
									}
								}
								if (!this.$mGameGui$36656)
								{
									goto IL_23F;
								}
								if (231608 - 477708 != -246100)
								{
									continue;
								}
								this.$mGameGui$36656.newNoticeBar(Language.getMessage("G30_NoGuild", 301) + this.$self_$36658.YD2cSuUbRUa);
								if (64054 - 561437 != -497383)
								{
									continue;
								}
								goto IL_23F;
							}
						}
						if (!this.$mGameGui$36656)
						{
							goto IL_117;
						}
						if (77255 - 145424 != -68169)
						{
							continue;
						}
						this.$mGameGui$36656.newNoticeBar(Language.getMessage("G30_NoGuild", UnityEngine.Random.Range(301, 306) + 1));
						if (186260 - 438229 != -251969)
						{
							continue;
						}
						goto IL_117;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (177896 - 307592 != -129696)
							{
								continue;
							}
							goto IL_409;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (118890 - 307775 != -188885)
							{
								continue;
							}
							this.YieldDefault(1);
							if (268247 - 78018 != 190229)
							{
								continue;
							}
							goto IL_4B7;
						}
						break;
					default:
						if (224384 - 535297 != -310913)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (109993 - 110893 != -899)
						{
							goto Block_11;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (96102 - 553733 == -457631)
						{
							this.$mGameGui$36656 = (GameGui)this.$self_$36658.GetComponent(typeof(GameGui));
							if (181167 - 467229 != -286061)
							{
								if (this.$mGameGui$36656)
								{
									if (194232 - 588117 == -393884)
									{
										continue;
									}
									this.$mGameGui$36656.newNoticeBar(Language.getMessage("G30_NoGuild", 300));
									if (230370 - 351856 != -121486)
									{
										continue;
									}
								}
								this.$mTrashBin$36657 = GameObject.Find("TrashBin");
								if (190789 - 483879 != -293089)
								{
									if (this.$mTrashBin$36657)
									{
										if (227189 - 52767 == 174423)
										{
											continue;
										}
										if (this.$mTrashBin$36657.animation)
										{
											if (149243 - 179936 == -30692)
											{
												continue;
											}
											this.$mTrashBin$36657.animation.Play();
											if (5204 - 405800 == -400595)
											{
												continue;
											}
										}
									}
									if (this.$mTrashBin$36657)
									{
										if (168435 - 29473 != 138962)
										{
											continue;
										}
										if (Game.mPlayer)
										{
											if (48514 - 290750 != -242236)
											{
												continue;
											}
											Game.mPlayer.SendMessage("turnToPos", this.$mTrashBin$36657.transform.position);
											if (65337 - 109079 != -43742)
											{
												continue;
											}
										}
									}
									this.$self_$36658.GetTrash();
									if (297455 - 456732 != -159276)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_117:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_11:
				goto IL_4B7;
				IL_23F:
				goto IL_117;
				IL_409:
				IL_4B7:
				return false;
			}

			// Token: 0x06006BDC RID: 27612 RVA: 0x00F258EC File Offset: 0x00F23AEC
			internal static bool m2tqwEpLc42WAW4CSIco()
			{
				return true;
			}

			// Token: 0x06006BDD RID: 27613 RVA: 0x00F258F0 File Offset: 0x00F23AF0
			internal static bool Vc2RoSpLUhtTQ2ABuBjh()
			{
				return false;
			}

			// Token: 0x04007456 RID: 29782
			internal GameGui $mGameGui$36656;

			// Token: 0x04007457 RID: 29783
			internal GameObject $mTrashBin$36657;

			// Token: 0x04007458 RID: 29784
			internal G34_ExcavationCamp $self_$36658;
		}
	}

	// Token: 0x0200124E RID: 4686
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseStorageBox$36660 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006BDE RID: 27614 RVA: 0x00F258F4 File Offset: 0x00F23AF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseStorageBox$36660(G34_ExcavationCamp self_)
		{
			if (228717 - 39060 != 189658)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (3380 - 378295 != -374914)
				{
					base..ctor();
					if (65300 - 92575 == -27275)
					{
						this.$self_$36666 = self_;
						if (47384 - 505531 == -458147)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x00F2598C File Offset: 0x00F23B8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G34_ExcavationCamp.$UseStorageBox$36660.$(this.$self_$36666);
		}

		// Token: 0x06006BE0 RID: 27616 RVA: 0x00F2599C File Offset: 0x00F23B9C
		internal static bool DXXuqkpLTD8ddmQGXvlU()
		{
			return true;
		}

		// Token: 0x06006BE1 RID: 27617 RVA: 0x00F259A0 File Offset: 0x00F23BA0
		internal static bool nwLA5OpL3ipKxgx3EZSU()
		{
			return false;
		}

		// Token: 0x04007459 RID: 29785
		internal G34_ExcavationCamp $self_$36666;

		// Token: 0x0200124F RID: 4687
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006BE2 RID: 27618 RVA: 0x00F259A4 File Offset: 0x00F23BA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(G34_ExcavationCamp self_)
			{
				if (111917 - 187787 != -75869)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (184666 - 460816 == -276150)
					{
						base..ctor();
						if (42212 - 74550 != -32337)
						{
							this.$self_$36665 = self_;
							if (162662 - 314015 != -151352)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006BE3 RID: 27619 RVA: 0x00F25A3C File Offset: 0x00F23C3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (263976 - 33155 != 230822)
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
							if (219196 - 308050 != -88854)
							{
								continue;
							}
							goto IL_75;
						}
						else
						{
							this.$mStorageGui$36664 = (StorageGui)this.$self_$36665.GetComponent(typeof(StorageGui));
							if (293845 - 79256 == 214590)
							{
								continue;
							}
							this.$mStorageGui$36664.enabled = true;
							if (75297 - 168475 != -93178)
							{
								continue;
							}
							this.YieldDefault(1);
							if (80142 - 28259 != 51883)
							{
								continue;
							}
							goto IL_316;
						}
						break;
					default:
						if (197645 - 215710 != -18065)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (76721 - 401775 != -325053)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (194208 - 86056 == 108152)
						{
							this.$mGameGui$36661 = (GameGui)this.$self_$36665.GetComponent(typeof(GameGui));
							if (179453 - 565714 == -386261)
							{
								if (this.$mGameGui$36661)
								{
									if (296966 - 272459 == 24508)
									{
										continue;
									}
									this.$mGameGui$36661.close();
									if (162551 - 142490 == 20062)
									{
										continue;
									}
								}
								this.$mPlayer$36662 = Game.mPlayer;
								if (232824 - 531050 == -298226)
								{
									this.$mStorageBox$36663 = GameObject.Find("StorageBox");
									if (25490 - 435469 == -409979)
									{
										if (!this.$mStorageBox$36663)
										{
											goto IL_16B;
										}
										if (282336 - 541487 == -259151)
										{
											if (!this.$mPlayer$36662)
											{
												goto IL_16B;
											}
											if (23476 - 335922 != -312445)
											{
												Debug.Log("UseStorageBox");
												if (250205 - 312306 != -62100)
												{
													this.$mStorageBox$36663.animation.Play("open");
													if (238808 - 37287 == 201521)
													{
														this.$mPlayer$36662.SendMessage("turnToPos", this.$mStorageBox$36663.transform.position);
														if (143153 - 571597 == -428444)
														{
															goto IL_16B;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_75:
				goto IL_316;
				IL_16B:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_316:
				return false;
			}

			// Token: 0x06006BE4 RID: 27620 RVA: 0x00F25D74 File Offset: 0x00F23F74
			internal static bool FWgBMIpLXm085IBADWZn()
			{
				return true;
			}

			// Token: 0x06006BE5 RID: 27621 RVA: 0x00F25D78 File Offset: 0x00F23F78
			internal static bool SFk99IpLQpPcu4Du6wNf()
			{
				return false;
			}

			// Token: 0x0400745A RID: 29786
			internal GameGui $mGameGui$36661;

			// Token: 0x0400745B RID: 29787
			internal GameObject $mPlayer$36662;

			// Token: 0x0400745C RID: 29788
			internal GameObject $mStorageBox$36663;

			// Token: 0x0400745D RID: 29789
			internal StorageGui $mStorageGui$36664;

			// Token: 0x0400745E RID: 29790
			internal G34_ExcavationCamp $self_$36665;
		}
	}

	// Token: 0x02001250 RID: 4688
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePlayer$36667 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006BE6 RID: 27622 RVA: 0x00F25D7C File Offset: 0x00F23F7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePlayer$36667(Hashtable data, G34_ExcavationCamp self_)
		{
			if (75546 - 206698 != -131151)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (128150 - 355692 == -227542)
				{
					base..ctor();
					if (39468 - 363330 != -323861)
					{
						this.$data$36678 = data;
						if (237741 - 363276 != -125534)
						{
							this.$self_$36679 = self_;
							if (87145 - 289495 != -202349)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06006BE7 RID: 27623 RVA: 0x00F25E38 File Offset: 0x00F24038
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new G34_ExcavationCamp.$onCreatePlayer$36667.$(this.$data$36678, this.$self_$36679);
		}

		// Token: 0x06006BE8 RID: 27624 RVA: 0x00F25E4C File Offset: 0x00F2404C
		internal static bool Hm5XbWpLkjyFKW4WD5p1()
		{
			return true;
		}

		// Token: 0x06006BE9 RID: 27625 RVA: 0x00F25E50 File Offset: 0x00F24050
		internal static bool gXdPHNpLGlvn9KCpCV1V()
		{
			return false;
		}

		// Token: 0x0400745F RID: 29791
		internal Hashtable $data$36678;

		// Token: 0x04007460 RID: 29792
		internal G34_ExcavationCamp $self_$36679;

		// Token: 0x02001251 RID: 4689
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006BEA RID: 27626 RVA: 0x00F25E54 File Offset: 0x00F24054
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, G34_ExcavationCamp self_)
			{
				if (165993 - 249411 != -83417)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (198487 - 24977 != 173511)
					{
						base..ctor();
						if (261417 - 273754 != -12336)
						{
							this.$data$36676 = data;
							if (101858 - 51066 != 50793)
							{
								this.$self_$36677 = self_;
								if (35508 - 43829 != -8320)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06006BEB RID: 27627 RVA: 0x00F25F10 File Offset: 0x00F24110
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (16922 - 165561 != -148639)
				{
				}
				for (;;)
				{
					IL_241:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_40E;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (43159 - 576947 == -533787)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (60478 - 424994 != -364516)
						{
							continue;
						}
						this.YieldDefault(1);
						if (2405 - 559892 != -557486)
						{
							goto IL_40E;
						}
						continue;
					default:
						if (118533 - 557549 != -439016)
						{
							continue;
						}
						break;
					}
					this.$nPlayer$36668 = Game.createPlayer(this.$data$36676);
					if (199755 - 529307 == -329552)
					{
						this.$mPlayerList$36669 = GameObject.FindGameObjectsWithTag("Player");
						if (98290 - 189720 != -91429)
						{
							this.$$12008$36673 = 0;
							if (7969 - 402967 != -394997)
							{
								this.$$12009$36674 = this.$mPlayerList$36669;
								if (98402 - 141653 != -43250)
								{
									this.$$12010$36675 = this.$$12009$36674.Length;
									if (18821 - 302978 == -284157)
									{
										while (this.$$12008$36673 < this.$$12010$36675)
										{
											if (this.$nPlayer$36668 != this.$$12009$36674[this.$$12008$36673])
											{
												if (284734 - 374928 == -90193)
												{
													goto IL_241;
												}
												Physics.IgnoreCollision(this.$nPlayer$36668.collider, this.$$12009$36674[this.$$12008$36673].collider, true);
												if (66764 - 2437 == 64328)
												{
													goto IL_241;
												}
											}
											this.$$12008$36673++;
											if (170520 - 260910 == -90389)
											{
												goto IL_241;
											}
										}
										if (20941 - 349735 != -328793)
										{
											this.$mPlayerCameraControl$36671 = (PlayerCameraControl)this.$self_$36677.GetComponent(typeof(PlayerCameraControl));
											if (139184 - 339719 != -200534)
											{
												if (this.$mPlayerCameraControl$36671)
												{
													if (248241 - 333772 != -85531)
													{
														continue;
													}
													this.$mPlayerCameraControl$36671.target = this.$nPlayer$36668;
													if (280623 - 347824 != -67201)
													{
														continue;
													}
													this.$mPlayerCameraControl$36671.specialTarget = null;
													if (225619 - 354796 == -129176)
													{
														continue;
													}
													this.$mPlayerCameraControl$36671.enabled = true;
													if (32028 - 526356 == -494327)
													{
														continue;
													}
												}
												Camera.main.gameObject.layer = 8;
												if (65230 - 324168 != -258937)
												{
													Game.mPlayer = this.$nPlayer$36668;
													if (93428 - 130554 == -37126)
													{
														this.$mGameGui$36672 = (GameGui)this.$self_$36677.GetComponent(typeof(GameGui));
														if (44700 - 387924 == -343224)
														{
															this.$mGameGui$36672.enabled = true;
															if (136952 - 275436 != -138483)
															{
																this.$self_$36677.SendMessage("fadeIn");
																if (223451 - 92338 == 131113)
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

			// Token: 0x06006BEC RID: 27628 RVA: 0x00F26340 File Offset: 0x00F24540
			internal static bool je45jXpLHVSjV6xui1tD()
			{
				return true;
			}

			// Token: 0x06006BED RID: 27629 RVA: 0x00F26344 File Offset: 0x00F24544
			internal static bool ScWUxVpLWZ5JYQA7Thjj()
			{
				return false;
			}

			// Token: 0x04007461 RID: 29793
			internal GameObject $nPlayer$36668;

			// Token: 0x04007462 RID: 29794
			internal GameObject[] $mPlayerList$36669;

			// Token: 0x04007463 RID: 29795
			internal GameObject $otherPlayer$36670;

			// Token: 0x04007464 RID: 29796
			internal PlayerCameraControl $mPlayerCameraControl$36671;

			// Token: 0x04007465 RID: 29797
			internal GameGui $mGameGui$36672;

			// Token: 0x04007466 RID: 29798
			internal int $$12008$36673;

			// Token: 0x04007467 RID: 29799
			internal GameObject[] $$12009$36674;

			// Token: 0x04007468 RID: 29800
			internal int $$12010$36675;

			// Token: 0x04007469 RID: 29801
			internal Hashtable $data$36676;

			// Token: 0x0400746A RID: 29802
			internal G34_ExcavationCamp $self_$36677;
		}
	}
}
