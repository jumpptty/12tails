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

// Token: 0x020014F6 RID: 5366
[Serializable]
public class M402_DesertPath3 : MonoBehaviour
{
	// Token: 0x06007C32 RID: 31794 RVA: 0x0102D154 File Offset: 0x0102B354
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M402_DesertPath3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007C33 RID: 31795 RVA: 0x0102D164 File Offset: 0x0102B364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (277179 - 269223 != 7956)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (94843 - 320779 != -225935)
			{
				Game.mGameType = 5;
				if (20501 - 130711 != -110209)
				{
					if (Chat.Initialized)
					{
						if (225671 - 87401 != 138271)
						{
							Chat.ChatDisplay.Clear();
							if (95560 - 17347 != 78214)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (161663 - 313121 != -151457)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007C34 RID: 31796 RVA: 0x0102D248 File Offset: 0x0102B448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (226951 - 501745 != -274794)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (99295 - 464664 == -365369)
				{
					if (Game.mNextGameCode != 402)
					{
						break;
					}
					if (80936 - 474374 == -393438)
					{
						if (Game.mGameStage != 3)
						{
							break;
						}
						if (39869 - 528538 != -488668)
						{
							Game.nextGame();
							if (214797 - 434058 != -219260)
							{
								this.c8dcF6gbwG4 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (137638 - 365602 != -227963)
								{
									this.MY5cFJd8sq0 = PhotonClient.Connection;
									if (269346 - 28137 == 241209)
									{
										PhotonClient.ActorNrList.Clear();
										if (111106 - 17231 != 93876)
										{
											this.InitGame();
											if (189357 - 306986 != -117628)
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
			else
			{
				Debug.Log("Not Connected");
				if (258725 - 491687 != -232961)
				{
					Game.mGameType = 99;
					if (4259 - 537292 == -533033)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007C35 RID: 31797 RVA: 0x0102D400 File Offset: 0x0102B600
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (49122 - 10716 != 38406)
		{
		}
		for (;;)
		{
			if (this.MY5cFJd8sq0 == null)
			{
				if (14288 - 270737 == -256449)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (234277 - 154663 == 79614)
				{
					if (mGameState == eGameState.Init)
					{
						if (38850 - 421533 != -382682)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (278222 - 574882 != -296659)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (264693 - 209679 == 55014)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (276457 - 568854 == -292397)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (22939 - 416779 != -393839)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (292037 - 270215 == 21822)
						{
							if (Time.time > this.a0pcFtSkjrd)
							{
								if (237151 - 355880 == -118728)
								{
									continue;
								}
								Game.mGameMana++;
								if (42934 - 68619 != -25685)
								{
									continue;
								}
								this.a0pcFtSkjrd = Time.time + (float)12;
								if (172482 - 408843 == -236360)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (40340 - 475626 != -435286)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (207612 - 577189 != -369577)
									{
										continue;
									}
									this.audio.Play();
									if (98606 - 396335 == -297728)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (92663 - 144622 != -51958)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (135682 - 395392 != -259709)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (68298 - 24769 != 43530)
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
						if (198945 - 403357 != -204411)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007C36 RID: 31798 RVA: 0x0102D700 File Offset: 0x0102B900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M402_DesertPath3.$onGameEvent$38682(data, this).GetEnumerator();
	}

	// Token: 0x06007C37 RID: 31799 RVA: 0x0102D710 File Offset: 0x0102B910
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M402_DesertPath3.$onGameComplete$38692(data, this).GetEnumerator();
	}

	// Token: 0x06007C38 RID: 31800 RVA: 0x0102D720 File Offset: 0x0102B920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DesertExit2()
	{
		if (80181 - 73304 != 6878)
		{
		}
		while (this.apXcFXmHdqj < 1)
		{
			if (23820 - 35231 == -11411)
			{
				Debug.Log("Desert Exit");
				if (212598 - 146556 != 66043)
				{
					this.apXcFXmHdqj = 1;
					if (28158 - 589608 != -561449)
					{
						Game.sendMissionEvent(4021, 2);
						if (293918 - 510037 == -216119)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007C39 RID: 31801 RVA: 0x0102D7E8 File Offset: 0x0102B9E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (290066 - 248176 != 41890)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (258759 - 12159 == 246600)
			{
				CharacterControl characterControl = null;
				if (285006 - 207338 != 77669)
				{
					if (mPlayer)
					{
						if (255475 - 330069 != -74594)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (257364 - 28832 == 228533)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (22034 - 133085 != -111050)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (33257 - 234110 != -200852)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (143145 - 259442 != -116296)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (198347 - 542881 == -344533)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (4082 - 388417 == -384334)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (279023 - 120228 == 158796)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (105757 - 284664 != -178906)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (134241 - 487883 != -353641)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (19389 - 33605 != -14215)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (63901 - 290406 == -226505)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (205918 - 381074 == -175156)
								{
									if (!changeGui)
									{
										break;
									}
									if (68477 - 97382 == -28905)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (213947 - 574935 == -360987)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (293226 - 454520 != -161294)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (199702 - 344367 != -144664)
										{
											gameGui.close();
											if (250603 - 118278 != 132326)
											{
												changeGui.enabled = true;
												if (75533 - 219147 == -143614)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (146841 - 358490 == -211649)
													{
														if (!gameObject)
														{
															break;
														}
														if (162309 - 360313 == -198004)
														{
															if (!mPlayer)
															{
																break;
															}
															if (291662 - 286632 == 5030)
															{
																Debug.Log("UseLifeAltar");
																if (156217 - 247880 != -91662)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (255149 - 111315 != 143835)
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

	// Token: 0x06007C3A RID: 31802 RVA: 0x0102DC48 File Offset: 0x0102BE48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseSignPost(object mVar)
	{
		return new M402_DesertPath3.$UseSignPost$38701(this).GetEnumerator();
	}

	// Token: 0x06007C3B RID: 31803 RVA: 0x0102DC58 File Offset: 0x0102BE58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (77211 - 428158 != -350946)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (249739 - 330842 != -81102)
			{
				Hashtable customOpParameters = new Hashtable();
				if (82613 - 262505 != -179891)
				{
					this.MY5cFJd8sq0.OpCustom(52, customOpParameters, true);
					if (95532 - 560677 == -465145)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007C3C RID: 31804 RVA: 0x0102DD00 File Offset: 0x0102BF00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (160857 - 502816 != -341958)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (230366 - 192695 != 37672)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (1220 - 242806 == -241586)
				{
					Game.mGameState = eGameState.Setup;
					if (43105 - 264200 == -221095)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007C3D RID: 31805 RVA: 0x0102DDA4 File Offset: 0x0102BFA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (228122 - 471549 != -243427)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (45629 - 422125 == -376496)
			{
				if (num == PlayerData.UID)
				{
					if (227219 - 240649 == -13430)
					{
						this.SetupActors();
						if (68048 - 518381 != -450332)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (86885 - 589054 == -502169)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007C3E RID: 31806 RVA: 0x0102DE74 File Offset: 0x0102C074
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (215718 - 583393 != -367674)
		{
		}
		for (;;)
		{
			IL_9D:
			Debug.Log("Creating Actors");
			if (119094 - 296164 == -177070)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (50292 - 173782 == -123490)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (250774 - 407436 == -156662)
						{
							int i = 0;
							if (131793 - 206210 == -74417)
							{
								CharacterControl[] array2 = array;
								if (17912 - 469601 != -451688)
								{
									int length = array2.Length;
									if (32860 - 211810 != -178949)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (205342 - 542472 == -337129)
											{
												goto IL_9D;
											}
											if (type == "Alpaca")
											{
												goto IL_159;
											}
											if (28775 - 281345 == -252569)
											{
												goto IL_9D;
											}
											if (type == "Cacton")
											{
												goto IL_159;
											}
											if (246346 - 437296 == -190949)
											{
												goto IL_9D;
											}
											if (type == "BanditBug1")
											{
												goto IL_159;
											}
											if (289128 - 368006 != -78878)
											{
												goto IL_9D;
											}
											if (type == "BanditBug2")
											{
												goto IL_159;
											}
											if (248938 - 550514 != -301576)
											{
												goto IL_9D;
											}
											if (type == "BanditBug3")
											{
												if (230433 - 286879 != -56445)
												{
													goto IL_159;
												}
												goto IL_9D;
											}
											IL_2AE:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (150185 - 334076 != -183891)
											{
												goto IL_9D;
											}
											this.IcccFGcQfMT++;
											if (286634 - 116489 != 170145)
											{
												goto IL_9D;
											}
											i++;
											if (230772 - 566303 != -335531)
											{
												goto IL_9D;
											}
											continue;
											IL_159:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (91883 - 366483 != -274600)
											{
												goto IL_9D;
											}
											goto IL_2AE;
										}
										if (252351 - 287011 != -34659)
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
						if (173778 - 589982 != -416203)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007C3F RID: 31807 RVA: 0x0102E190 File Offset: 0x0102C390
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (51776 - 591230 != -539453)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (121551 - 140839 != -19287)
			{
				int i = 0;
				if (236114 - 236424 == -310)
				{
					CharacterControl[] array2 = array;
					if (208339 - 359132 == -150793)
					{
						int length = array2.Length;
						if (289985 - 13628 != 276358)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (238791 - 373220 == -134428)
								{
									goto IL_1A;
								}
								i++;
								if (266591 - 36210 == 230382)
								{
									goto IL_1A;
								}
							}
							if (48880 - 92335 != -43454)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007C40 RID: 31808 RVA: 0x0102E2C0 File Offset: 0x0102C4C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (98868 - 251055 != -152186)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (234216 - 234306 == -90)
			{
				hashtable.Add(43, PlayerData.UID);
				if (202816 - 304650 == -101834)
				{
					hashtable.Add(73, nType);
					if (161286 - 423440 != -262153)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (291102 - 293047 == -1945)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (241649 - 272473 == -30824)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (15878 - 249357 != -233478)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (90619 - 87117 != 3503)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (187457 - 271364 != -83906)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (199534 - 303456 != -103921)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (8106 - 325073 == -316967)
												{
													this.MY5cFJd8sq0.OpCustom(63, hashtable, true);
													if (69627 - 250883 == -181256)
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

	// Token: 0x06007C41 RID: 31809 RVA: 0x0102E578 File Offset: 0x0102C778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (133586 - 532610 != -399024)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (104172 - 512829 == -408657)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (184183 - 531968 == -347785)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (187302 - 220857 != -33554)
						{
							if (this.IcccFGcQfMT <= 0)
							{
								break;
							}
							if (287026 - 481127 != -194100)
							{
								this.IcccFGcQfMT--;
								if (214153 - 107096 != 107058)
								{
									if (this.IcccFGcQfMT != 0)
									{
										break;
									}
									if (25593 - 201641 == -176048)
									{
										Game.setGameState(eGameState.Ready);
										if (220855 - 72740 == 148115)
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
						if (58527 - 133935 != -75407)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (114422 - 519593 != -405170)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007C42 RID: 31810 RVA: 0x0102E708 File Offset: 0x0102C908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06007C43 RID: 31811 RVA: 0x0102E71C File Offset: 0x0102C91C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (114751 - 112921 != 1831)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (191323 - 368009 == -176686)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (264736 - 206805 == 57931)
				{
					if (!characterControl)
					{
						break;
					}
					if (63328 - 342633 == -279305)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (97992 - 127275 != -29282)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (21153 - 427701 != -406547)
							{
								string type = characterControl.Type;
								if (203147 - 502097 == -298950)
								{
									if (type == "Ja1")
									{
										if (270756 - 358374 != -87618)
										{
											continue;
										}
									}
									else if (type == "Ja2")
									{
										if (257109 - 228854 != 28255)
										{
											continue;
										}
									}
									else if (type == "Ja3")
									{
										if (283806 - 65597 != 218209)
										{
											continue;
										}
									}
									else if (type == "Ja4")
									{
										if (254534 - 224343 == 30192)
										{
											continue;
										}
									}
									else if (type == "Ja5")
									{
										if (255223 - 372200 != -116977)
										{
											continue;
										}
									}
									else if (type == "Ja6")
									{
										if (185085 - 51991 == 133095)
										{
											continue;
										}
									}
									else if (type == "FatBug_y")
									{
										if (109058 - 595187 != -486129)
										{
											continue;
										}
										Game.sendMissionEvent(4023, 0);
										if (99987 - 322182 != -222195)
										{
											continue;
										}
										break;
									}
									else
									{
										if (!(type == "SandBug_r"))
										{
											if (type == "BanditBug1")
											{
												if (234498 - 126724 == 107775)
												{
													continue;
												}
											}
											else if (type == "BanditBug2")
											{
												if (226361 - 488233 == -261871)
												{
													continue;
												}
											}
											else if (type == "BanditBug3")
											{
												if (269571 - 253399 == 16173)
												{
													continue;
												}
											}
											else
											{
												if (!(type == "Alpaca"))
												{
													break;
												}
												if (224538 - 372311 == -147772)
												{
													continue;
												}
												Game.sendMissionEvent(4026, 0);
												if (214240 - 491866 != -277625)
												{
													break;
												}
												continue;
											}
											IL_C2:
											Game.sendMissionEvent(4025, 0);
											if (50396 - 327391 != -276994)
											{
												break;
											}
											continue;
											goto IL_C2;
										}
										if (68912 - 590296 != -521384)
										{
											continue;
										}
										Game.sendMissionEvent(4024, 0);
										if (138067 - 149816 != -11749)
										{
											continue;
										}
										break;
									}
									IL_2C9:
									Game.sendMissionEvent(4022, 0);
									if (175079 - 323900 != -148821)
									{
										continue;
									}
									break;
									IL_165:
									goto IL_2C9;
									IL_6E:
									goto IL_165;
									IL_33E:
									goto IL_6E;
									goto IL_33E;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007C44 RID: 31812 RVA: 0x0102EB2C File Offset: 0x0102CD2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJaSuicide()
	{
		Game.sendMissionEvent(4022, 0);
	}

	// Token: 0x06007C45 RID: 31813 RVA: 0x0102EB3C File Offset: 0x0102CD3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (144499 - 513946 != -369446)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (57340 - 131255 != -73914)
			{
				Game.mGameState = eGameState.Ready;
				if (67096 - 285802 == -218706)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (130064 - 219627 != -89562)
					{
						GameObject gameObject = null;
						if (53510 - 399723 == -346213)
						{
							GameObject gameObject2 = null;
							if (258686 - 443835 != -185148)
							{
								if (playerSlot > 1)
								{
									if (168027 - 402476 == -234448)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (82338 - 507727 != -425389)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (164758 - 495182 != -330424)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (23106 - 79282 == -56175)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (234079 - 247997 != -13918)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (141743 - 161166 != -19423)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (159392 - 196543 == -37150)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (242452 - 208624 == 33829)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (211955 - 222883 != -10928)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (155209 - 455447 == -300237)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (4201 - 22069 != -17867)
								{
									this.transform.position = gameObject2.transform.position;
									if (156997 - 97912 != 59086)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (232391 - 314698 != -82306)
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

	// Token: 0x06007C46 RID: 31814 RVA: 0x0102EE38 File Offset: 0x0102D038
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M402_DesertPath3.$StartGame$38704(this).GetEnumerator();
	}

	// Token: 0x06007C47 RID: 31815 RVA: 0x0102EE48 File Offset: 0x0102D048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007C48 RID: 31816 RVA: 0x0102EE4C File Offset: 0x0102D04C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (97883 - 30775 != 67109)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (273047 - 330271 != -57223)
			{
				hashtable.Add(71, CID);
				if (298150 - 52491 == 245659)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (145033 - 511419 == -366386)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (44776 - 163241 == -118465)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (932 - 326607 != -325674)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (206674 - 553491 == -346817)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (150236 - 499251 == -349015)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (70767 - 76349 != -5581)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (192184 - 313925 == -121741)
											{
												this.MY5cFJd8sq0.OpCustom(61, hashtable, true);
												if (138398 - 110256 != 28143)
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

	// Token: 0x06007C49 RID: 31817 RVA: 0x0102F0D8 File Offset: 0x0102D2D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (128231 - 194988 != -66757)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (21509 - 61637 == -40128)
			{
				if (!gameObject)
				{
					break;
				}
				if (116081 - 391277 == -275196)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (171966 - 305219 == -133253)
					{
						playerCameraControl.target = gameObject;
						if (223356 - 507733 == -284377)
						{
							if (Game.useAdvanceMode)
							{
								if (95053 - 95391 != -338)
								{
									continue;
								}
								Game.loadPlayer();
								if (115753 - 504765 != -389012)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (282500 - 387296 != -104795)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007C4A RID: 31818 RVA: 0x0102F214 File Offset: 0x0102D414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (219081 - 319041 != -99959)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (217947 - 363470 != -145522)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (224347 - 518928 == -294581)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (252942 - 530246 == -277304)
					{
						Hashtable hashtable = new Hashtable();
						if (217417 - 408037 != -190619)
						{
							hashtable.Add(43, PlayerData.UID);
							if (278682 - 246840 == 31842)
							{
								hashtable.Add(71, nCID);
								if (184660 - 21063 != 163598)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (71907 - 143372 == -71465)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (215459 - 248112 == -32653)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (202104 - 461273 != -259168)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (159253 - 359135 != -199881)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (60295 - 371840 != -311544)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (100264 - 588501 == -488237)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (48911 - 12742 != 36170)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (224996 - 266258 != -41261)
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

	// Token: 0x06007C4B RID: 31819 RVA: 0x0102F534 File Offset: 0x0102D734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M402_DesertPath3.$onChangePlayer$38708(data, this).GetEnumerator();
	}

	// Token: 0x06007C4C RID: 31820 RVA: 0x0102F544 File Offset: 0x0102D744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (271806 - 578325 != -306518)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (40375 - 181564 == -141189)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (22470 - 339012 == -316542)
				{
					gameGui.ResetTeamBar();
					if (171351 - 539868 != -368516)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007C4D RID: 31821 RVA: 0x0102F5F0 File Offset: 0x0102D7F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M402_DesertPath3.$onDeadPlayer$38715(this).GetEnumerator();
	}

	// Token: 0x06007C4E RID: 31822 RVA: 0x0102F600 File Offset: 0x0102D800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (215846 - 17578 != 198268)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (78094 - 282816 != -204721)
			{
				this.c8dcF6gbwG4.target = Game.mPlayer;
				if (220446 - 525158 != -304711)
				{
					this.c8dcF6gbwG4.enabled = true;
					if (155671 - 493963 == -338292)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (227365 - 564075 != -336710)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (178415 - 291783 == -113367)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (200220 - 472183 == -271963)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (36495 - 233438 != -196942)
							{
								if (!gameGui)
								{
									break;
								}
								if (82992 - 288495 != -205502)
								{
									gameGui.enabled = true;
									if (221524 - 251086 == -29562)
									{
										gameGui.closeDeadMenu();
										if (284419 - 19260 == 265159)
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

	// Token: 0x06007C4F RID: 31823 RVA: 0x0102F7AC File Offset: 0x0102D9AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (133322 - 56809 != 76514)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (95313 - 13234 != 82080)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (188106 - 215697 == -27591)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (184241 - 58989 != 125253)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007C50 RID: 31824 RVA: 0x0102F870 File Offset: 0x0102DA70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007C51 RID: 31825 RVA: 0x0102F89C File Offset: 0x0102DA9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M402_DesertPath3.$ReturnToTown$38721(this).GetEnumerator();
	}

	// Token: 0x06007C52 RID: 31826 RVA: 0x0102F8AC File Offset: 0x0102DAAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M402_DesertPath3.$ReturnToGuild$38726(this).GetEnumerator();
	}

	// Token: 0x06007C53 RID: 31827 RVA: 0x0102F8BC File Offset: 0x0102DABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M402_DesertPath3.$ReturnToCamp$38730(this).GetEnumerator();
	}

	// Token: 0x06007C54 RID: 31828 RVA: 0x0102F8CC File Offset: 0x0102DACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (156129 - 576516 != -420386)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (54413 - 270901 != -216487)
			{
				Hashtable hashtable = new Hashtable();
				if (153176 - 509012 != -355835)
				{
					hashtable.Add(43, PlayerData.UID);
					if (4442 - 109933 != -105490)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (292236 - 411843 == -119607)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007C55 RID: 31829 RVA: 0x0102F9A4 File Offset: 0x0102DBA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007C56 RID: 31830 RVA: 0x0102F9B8 File Offset: 0x0102DBB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (91160 - 2931 != 88230)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (181110 - 311850 == -130740)
			{
				Hashtable hashtable = new Hashtable();
				if (102780 - 411543 == -308763)
				{
					if (Game.mNextGameCode == 30)
					{
						if (262900 - 42192 == 220709)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (244475 - 324534 == -80058)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (229598 - 542095 != -312497)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (221415 - 62313 != 159102)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (241572 - 574163 != -332591)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (208303 - 217030 == -8726)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (115134 - 501807 == -386672)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (44420 - 436668 == -392247)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (150619 - 359994 != -209375)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (195289 - 71057 == 124233)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (139617 - 592781 == -453163)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (66925 - 190700 == -123774)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (244742 - 22175 != 222567)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (194888 - 416466 != -221578)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (192239 - 271823 == -79583)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (14062 - 572238 == -558175)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (81116 - 416548 == -335431)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (861 - 312477 == -311615)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (185783 - 297001 != -111218)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (195738 - 265732 == -69993)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (70682 - 393058 != -322376)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (77545 - 582853 != -505308)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (135522 - 260891 != -125369)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (11421 - 190276 != -178855)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (54378 - 524052 != -469674)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (4059 - 47548 != -43489)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (248291 - 239463 == 8829)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (82352 - 348952 == -266599)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (134812 - 11400 == 123412)
					{
						this.MY5cFJd8sq0.OpCustom(42, hashtable, true);
						if (130254 - 182407 == -52153)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007C57 RID: 31831 RVA: 0x0102FF6C File Offset: 0x0102E16C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007C58 RID: 31832 RVA: 0x0102FF7C File Offset: 0x0102E17C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007C59 RID: 31833 RVA: 0x0102FF80 File Offset: 0x0102E180
	internal static bool VkQwoKpbNj2kk8eiLuoT()
	{
		return true;
	}

	// Token: 0x06007C5A RID: 31834 RVA: 0x0102FF84 File Offset: 0x0102E184
	internal static bool G8M938pbYeepiZ0a00ew()
	{
		return false;
	}

	// Token: 0x04007D54 RID: 32084
	private LitePeer MY5cFJd8sq0;

	// Token: 0x04007D55 RID: 32085
	private PlayerCameraControl c8dcF6gbwG4;

	// Token: 0x04007D56 RID: 32086
	private float a0pcFtSkjrd;

	// Token: 0x04007D57 RID: 32087
	private int apXcFXmHdqj;

	// Token: 0x04007D58 RID: 32088
	private int kQxcFO1NqiR;

	// Token: 0x04007D59 RID: 32089
	private int MQlcF2A7ROj;

	// Token: 0x04007D5A RID: 32090
	private int cfEcFvZinAX;

	// Token: 0x04007D5B RID: 32091
	private int A1OcFlFV0L8;

	// Token: 0x04007D5C RID: 32092
	private int IcccFGcQfMT;

	// Token: 0x020014F7 RID: 5367
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$38682 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C5B RID: 31835 RVA: 0x0102FF88 File Offset: 0x0102E188
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$38682(Hashtable data, M402_DesertPath3 self_)
		{
			if (33970 - 91499 != -57528)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (132157 - 326152 == -193995)
				{
					base..ctor();
					if (30294 - 211528 == -181234)
					{
						this.$data$38690 = data;
						if (151694 - 205021 == -53327)
						{
							this.$self_$38691 = self_;
							if (209142 - 377507 != -168364)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007C5C RID: 31836 RVA: 0x01030044 File Offset: 0x0102E244
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath3.$onGameEvent$38682.$(this.$data$38690, this.$self_$38691);
		}

		// Token: 0x06007C5D RID: 31837 RVA: 0x01030058 File Offset: 0x0102E258
		internal static bool N572D8pbcui76xmkS20E()
		{
			return true;
		}

		// Token: 0x06007C5E RID: 31838 RVA: 0x0103005C File Offset: 0x0102E25C
		internal static bool itATR2pbU0adRGvxAZoa()
		{
			return false;
		}

		// Token: 0x04007D5D RID: 32093
		internal Hashtable $data$38690;

		// Token: 0x04007D5E RID: 32094
		internal M402_DesertPath3 $self_$38691;

		// Token: 0x020014F8 RID: 5368
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C5F RID: 31839 RVA: 0x01030060 File Offset: 0x0102E260
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M402_DesertPath3 self_)
			{
				if (32073 - 545999 != -513925)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (66650 - 505729 != -439078)
					{
						base..ctor();
						if (160239 - 185055 == -24816)
						{
							this.$data$38688 = data;
							if (241392 - 382960 == -141568)
							{
								this.$self_$38689 = self_;
								if (228043 - 541481 != -313437)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007C60 RID: 31840 RVA: 0x0103011C File Offset: 0x0102E31C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (240103 - 515552 != -275448)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1EB;
					case 1:
						goto IL_4EF;
					case 2:
						Application.LoadLevel("M402_DesertPath3");
						if (57208 - 74850 == -17641)
						{
							continue;
						}
						break;
					default:
						if (260571 - 20828 != 239743)
						{
							continue;
						}
						goto IL_1EB;
					}
					IL_18F:
					this.YieldDefault(1);
					if (189091 - 92603 != 96488)
					{
						continue;
					}
					goto IL_4EF;
					IL_44F:
					goto IL_18F;
					IL_1EB:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (78715 - 175947 != -97231)
						{
							goto Block_12;
						}
					}
					else
					{
						this.$returnCode$38683 = RuntimeServices.UnboxInt32(this.$data$38688[141]);
						if (251072 - 471761 != -220688)
						{
							this.$returnValue$38684 = RuntimeServices.UnboxInt32(this.$data$38688[145]);
							if (123161 - 159353 != -36191)
							{
								this.$ownerID$38685 = RuntimeServices.UnboxInt32(this.$data$38688[43]);
								if (265985 - 158138 == 107847)
								{
									this.$$switch$6738$38686 = this.$returnCode$38683;
									if (179883 - 414007 == -234124)
									{
										if (this.$$switch$6738$38686 == 4021)
										{
											if (26238 - 333194 != -306955)
											{
												if (this.$self_$38689.apXcFXmHdqj >= 2)
												{
													goto IL_44F;
												}
												if (209488 - 439735 != -230246)
												{
													if (this.$returnValue$38684 != 2)
													{
														goto IL_44F;
													}
													if (71025 - 347344 != -276318)
													{
														this.$self_$38689.apXcFXmHdqj = 2;
														if (57707 - 493523 == -435816)
														{
															Game.mGameState = eGameState.AllHold;
															if (13994 - 468800 == -454806)
															{
																this.$mGameGui$38687 = (GameGui)this.$self_$38689.GetComponent(typeof(GameGui));
																if (1831 - 306271 == -304440)
																{
																	this.$mGameGui$38687.close();
																	if (206964 - 114869 != 92096)
																	{
																		this.$self_$38689.SendMessage("fadeOut");
																		if (24789 - 162650 == -137861)
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
										else if (this.$$switch$6738$38686 == 4022)
										{
											if (44615 - 367587 != -322971)
											{
												this.$self_$38689.kQxcFO1NqiR = this.$self_$38689.kQxcFO1NqiR + 1;
												if (83747 - 567438 == -483691)
												{
													goto IL_18F;
												}
											}
										}
										else if (this.$$switch$6738$38686 == 4023)
										{
											if (236113 - 134072 == 102041)
											{
												this.$self_$38689.MQlcF2A7ROj = this.$self_$38689.MQlcF2A7ROj + 1;
												if (107147 - 186375 != -79227)
												{
													goto IL_18F;
												}
											}
										}
										else if (this.$$switch$6738$38686 == 4024)
										{
											if (234868 - 537400 == -302532)
											{
												this.$self_$38689.cfEcFvZinAX = this.$self_$38689.cfEcFvZinAX + 1;
												if (294043 - 262141 == 31902)
												{
													goto IL_18F;
												}
											}
										}
										else if (this.$$switch$6738$38686 == 4025)
										{
											if (59812 - 373207 == -313395)
											{
												this.$self_$38689.A1OcFlFV0L8 = this.$self_$38689.A1OcFlFV0L8 + 1;
												if (233293 - 385353 != -152059)
												{
													this.$self_$38689.SendMessage("newGameMessage", "Bandit Bug elimiated :" + this.$self_$38689.A1OcFlFV0L8 + "/3");
													if (99481 - 29795 == 69686)
													{
														goto IL_18F;
													}
												}
											}
										}
										else
										{
											if (this.$$switch$6738$38686 != 4026)
											{
												goto IL_18F;
											}
											if (111159 - 101179 == 9980)
											{
												goto IL_18F;
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_12:
				IL_4EF:
				return false;
			}

			// Token: 0x06007C61 RID: 31841 RVA: 0x0103062C File Offset: 0x0102E82C
			internal static bool XIVfNRpbTthrnuWqI2Zt()
			{
				return true;
			}

			// Token: 0x06007C62 RID: 31842 RVA: 0x01030630 File Offset: 0x0102E830
			internal static bool FCNhsLpb3ue518q9pfEF()
			{
				return false;
			}

			// Token: 0x04007D5F RID: 32095
			internal int $returnCode$38683;

			// Token: 0x04007D60 RID: 32096
			internal int $returnValue$38684;

			// Token: 0x04007D61 RID: 32097
			internal int $ownerID$38685;

			// Token: 0x04007D62 RID: 32098
			internal int $$switch$6738$38686;

			// Token: 0x04007D63 RID: 32099
			internal GameGui $mGameGui$38687;

			// Token: 0x04007D64 RID: 32100
			internal Hashtable $data$38688;

			// Token: 0x04007D65 RID: 32101
			internal M402_DesertPath3 $self_$38689;
		}
	}

	// Token: 0x020014F9 RID: 5369
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38692 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C63 RID: 31843 RVA: 0x01030634 File Offset: 0x0102E834
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38692(Hashtable data, M402_DesertPath3 self_)
		{
			if (32279 - 552126 != -519847)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (125508 - 106934 == 18574)
				{
					base..ctor();
					if (152389 - 87998 != 64392)
					{
						this.$data$38699 = data;
						if (143949 - 428509 != -284559)
						{
							this.$self_$38700 = self_;
							if (131523 - 436631 == -305108)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007C64 RID: 31844 RVA: 0x010306F0 File Offset: 0x0102E8F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath3.$onGameComplete$38692.$(this.$data$38699, this.$self_$38700);
		}

		// Token: 0x06007C65 RID: 31845 RVA: 0x01030704 File Offset: 0x0102E904
		internal static bool TE3QiMpbXjsNQnXbwSm5()
		{
			return true;
		}

		// Token: 0x06007C66 RID: 31846 RVA: 0x01030708 File Offset: 0x0102E908
		internal static bool vC7Gf7pbQsvTfuaq8caw()
		{
			return false;
		}

		// Token: 0x04007D66 RID: 32102
		internal Hashtable $data$38699;

		// Token: 0x04007D67 RID: 32103
		internal M402_DesertPath3 $self_$38700;

		// Token: 0x020014FA RID: 5370
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C67 RID: 31847 RVA: 0x0103070C File Offset: 0x0102E90C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M402_DesertPath3 self_)
			{
				if (16254 - 537142 != -520888)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (166316 - 280228 == -113912)
					{
						base..ctor();
						if (219395 - 199735 == 19660)
						{
							this.$data$38697 = data;
							if (98176 - 197871 == -99695)
							{
								this.$self_$38698 = self_;
								if (192840 - 486512 == -293672)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007C68 RID: 31848 RVA: 0x010307C8 File Offset: 0x0102E9C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (112551 - 391295 != -278743)
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
						this.$mCompleteGui$38694 = (CompleteGui)this.$self_$38698.GetComponent(typeof(CompleteGui));
						if (133748 - 16709 == 117040)
						{
							continue;
						}
						this.$mCompleteGui$38694.Init();
						if (198306 - 497681 == -299374)
						{
							continue;
						}
						this.$mCompleteGui$38694.readData(this.$data$38697);
						if (57047 - 215689 != -158642)
						{
							continue;
						}
						if (this.$result$38693 == 1)
						{
							if (232683 - 317809 == -85125)
							{
								continue;
							}
							this.$mCompleteGui$38694.displayResult(eCompleteType.Success);
							if (248712 - 227900 != 20812)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38694.displayResult(eCompleteType.Failed);
							if (233923 - 478737 == -244813)
							{
								continue;
							}
						}
						this.$mGameGui$38695 = (GameGui)this.$self_$38698.GetComponent(typeof(GameGui));
						if (203717 - 304637 == -100919)
						{
							continue;
						}
						this.$mStoryGui$38696 = (StoryGui)this.$self_$38698.GetComponent(typeof(StoryGui));
						if (91654 - 201247 == -109592)
						{
							continue;
						}
						if (this.$mGameGui$38695)
						{
							if (286835 - 25683 == 261153)
							{
								continue;
							}
							this.$mGameGui$38695.close();
							if (238994 - 67614 != 171380)
							{
								continue;
							}
						}
						if (this.$mStoryGui$38696)
						{
							if (23752 - 202404 != -178652)
							{
								continue;
							}
							this.$mStoryGui$38696.close();
							if (95167 - 230994 != -135827)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (207090 - 178217 != 28873)
						{
							continue;
						}
						goto IL_352;
					default:
						if (286927 - 483171 == -196243)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$38697[31]);
					if (267669 - 492128 == -224459)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (26411 - 434221 != -407809)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (152989 - 508932 == -355943)
							{
								this.$result$38693 = RuntimeServices.UnboxInt32(this.$data$38697[31]);
								if (39306 - 477739 != -438432)
								{
									goto Block_11;
								}
							}
						}
					}
				}
				goto IL_352;
				Block_11:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06007C69 RID: 31849 RVA: 0x01030B3C File Offset: 0x0102ED3C
			internal static bool XpNLMnpbkGiWLeI0gaUB()
			{
				return true;
			}

			// Token: 0x06007C6A RID: 31850 RVA: 0x01030B40 File Offset: 0x0102ED40
			internal static bool XXr1YtpbG3kWHiIbDCXY()
			{
				return false;
			}

			// Token: 0x04007D68 RID: 32104
			internal int $result$38693;

			// Token: 0x04007D69 RID: 32105
			internal CompleteGui $mCompleteGui$38694;

			// Token: 0x04007D6A RID: 32106
			internal GameGui $mGameGui$38695;

			// Token: 0x04007D6B RID: 32107
			internal StoryGui $mStoryGui$38696;

			// Token: 0x04007D6C RID: 32108
			internal Hashtable $data$38697;

			// Token: 0x04007D6D RID: 32109
			internal M402_DesertPath3 $self_$38698;
		}
	}

	// Token: 0x020014FB RID: 5371
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseSignPost$38701 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C6B RID: 31851 RVA: 0x01030B44 File Offset: 0x0102ED44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseSignPost$38701(M402_DesertPath3 self_)
		{
			if (275656 - 340383 != -64727)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (144170 - 152799 == -8629)
				{
					base..ctor();
					if (180949 - 493669 != -312719)
					{
						this.$self_$38703 = self_;
						if (63778 - 538665 != -474886)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007C6C RID: 31852 RVA: 0x01030BDC File Offset: 0x0102EDDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath3.$UseSignPost$38701.$(this.$self_$38703);
		}

		// Token: 0x06007C6D RID: 31853 RVA: 0x01030BEC File Offset: 0x0102EDEC
		internal static bool EiEByfpbH6CVLonDxoo8()
		{
			return true;
		}

		// Token: 0x06007C6E RID: 31854 RVA: 0x01030BF0 File Offset: 0x0102EDF0
		internal static bool ppowpJpbWmji70nII1k0()
		{
			return false;
		}

		// Token: 0x04007D6E RID: 32110
		internal M402_DesertPath3 $self_$38703;

		// Token: 0x020014FC RID: 5372
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C6F RID: 31855 RVA: 0x01030BF4 File Offset: 0x0102EDF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath3 self_)
			{
				if (237685 - 42704 != 194982)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (283642 - 375629 == -91987)
					{
						base..ctor();
						if (193887 - 1928 != 191960)
						{
							this.$self_$38702 = self_;
							if (115172 - 219123 == -103951)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007C70 RID: 31856 RVA: 0x01030C8C File Offset: 0x0102EE8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (161757 - 82244 != 79513)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1C1;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (237281 - 140072 != 97209)
						{
							continue;
						}
						goto IL_11A;
					default:
						if (261335 - 55564 == 205772)
						{
							continue;
						}
						break;
					}
					if (PlayerData.QuestID == 28)
					{
						if (19006 - 456337 != -437331)
						{
							continue;
						}
						Q28_DesertPatrol.TalkToSignPost1(this.$self_$38702.gameObject);
						if (78972 - 344997 == -266024)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == -28)
					{
						if (200086 - 572395 != -372309)
						{
							continue;
						}
						Q28_DesertPatrol.TalkToSignPost1Repeat(this.$self_$38702.gameObject);
						if (78637 - 7811 != 70826)
						{
							continue;
						}
					}
					else if (Game.mGameState == eGameState.Normal)
					{
						if (259793 - 175011 == 84783)
						{
							continue;
						}
						Game.mGameState = eGameState.Hold;
						if (296517 - 389904 != -93387)
						{
							continue;
						}
						this.$self_$38702.SendMessage("newNoticeBar", "Desert Path");
						if (117858 - 382902 != -265044)
						{
							continue;
						}
						break;
					}
					IL_11A:
					this.YieldDefault(1);
					if (156407 - 357501 != -201093)
					{
						goto Block_11;
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				Block_11:
				IL_1C1:
				return false;
			}

			// Token: 0x06007C71 RID: 31857 RVA: 0x01030E6C File Offset: 0x0102F06C
			internal static bool BRGtNLpbAY2DhpOUsnSb()
			{
				return true;
			}

			// Token: 0x06007C72 RID: 31858 RVA: 0x01030E70 File Offset: 0x0102F070
			internal static bool d0hpNppblZAKfMwoS4je()
			{
				return false;
			}

			// Token: 0x04007D6F RID: 32111
			internal M402_DesertPath3 $self_$38702;
		}
	}

	// Token: 0x020014FD RID: 5373
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38704 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C73 RID: 31859 RVA: 0x01030E74 File Offset: 0x0102F074
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38704(M402_DesertPath3 self_)
		{
			if (142902 - 94467 != 48435)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (231771 - 129266 != 102506)
				{
					base..ctor();
					if (136024 - 323496 != -187471)
					{
						this.$self_$38707 = self_;
						if (220485 - 192162 == 28323)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007C74 RID: 31860 RVA: 0x01030F0C File Offset: 0x0102F10C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath3.$StartGame$38704.$(this.$self_$38707);
		}

		// Token: 0x06007C75 RID: 31861 RVA: 0x01030F1C File Offset: 0x0102F11C
		internal static bool Snkt9MpbyP07GU2v4IFr()
		{
			return true;
		}

		// Token: 0x06007C76 RID: 31862 RVA: 0x01030F20 File Offset: 0x0102F120
		internal static bool pnwtyEpbSFTLUiZ0PxXy()
		{
			return false;
		}

		// Token: 0x04007D70 RID: 32112
		internal M402_DesertPath3 $self_$38707;

		// Token: 0x020014FE RID: 5374
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C77 RID: 31863 RVA: 0x01030F24 File Offset: 0x0102F124
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath3 self_)
			{
				if (57856 - 440626 != -382769)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (77295 - 316075 == -238780)
					{
						base..ctor();
						if (62702 - 523084 != -460381)
						{
							this.$self_$38706 = self_;
							if (67107 - 1344 == 65763)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007C78 RID: 31864 RVA: 0x01030FBC File Offset: 0x0102F1BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (104634 - 212498 != -107864)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1B9;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (181615 - 546110 != -364495)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (253898 - 356069 != -102171)
						{
							continue;
						}
						this.YieldDefault(1);
						if (126574 - 591366 != -464791)
						{
							goto Block_3;
						}
						continue;
					default:
						if (135307 - 240862 != -105555)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (150721 - 153101 != -2379)
					{
						Game.mGameState = eGameState.Start;
						if (128214 - 946 != 127269)
						{
							Game.mStateTime = Time.time;
							if (233144 - 557277 == -324133)
							{
								this.$mGameGui$38705 = (GameGui)this.$self_$38706.GetComponent(typeof(GameGui));
								if (218204 - 535846 == -317642)
								{
									this.$mGameGui$38705.enabled = true;
									if (287636 - 494239 != -206602)
									{
										this.$self_$38706.SendMessage("fadeIn");
										if (69475 - 203969 != -134493)
										{
											goto Block_10;
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_1B9;
				Block_10:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x06007C79 RID: 31865 RVA: 0x01031194 File Offset: 0x0102F394
			internal static bool Q3CXKKpbo3KaeYXrggfC()
			{
				return true;
			}

			// Token: 0x06007C7A RID: 31866 RVA: 0x01031198 File Offset: 0x0102F398
			internal static bool XNTx1RpbEtnYULyMXpvq()
			{
				return false;
			}

			// Token: 0x04007D71 RID: 32113
			internal GameGui $mGameGui$38705;

			// Token: 0x04007D72 RID: 32114
			internal M402_DesertPath3 $self_$38706;
		}
	}

	// Token: 0x020014FF RID: 5375
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$38708 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C7B RID: 31867 RVA: 0x0103119C File Offset: 0x0102F39C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$38708(Hashtable data, M402_DesertPath3 self_)
		{
			if (66505 - 160746 != -94240)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (10849 - 113234 == -102385)
				{
					base..ctor();
					if (83043 - 224624 == -141581)
					{
						this.$data$38713 = data;
						if (198211 - 18303 == 179908)
						{
							this.$self_$38714 = self_;
							if (280430 - 242294 == 38136)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007C7C RID: 31868 RVA: 0x01031258 File Offset: 0x0102F458
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath3.$onChangePlayer$38708.$(this.$data$38713, this.$self_$38714);
		}

		// Token: 0x06007C7D RID: 31869 RVA: 0x0103126C File Offset: 0x0102F46C
		internal static bool P3WYZOpb22il10L1qOoh()
		{
			return true;
		}

		// Token: 0x06007C7E RID: 31870 RVA: 0x01031270 File Offset: 0x0102F470
		internal static bool Jq1wropb81NLQSGAdCLn()
		{
			return false;
		}

		// Token: 0x04007D73 RID: 32115
		internal Hashtable $data$38713;

		// Token: 0x04007D74 RID: 32116
		internal M402_DesertPath3 $self_$38714;

		// Token: 0x02001500 RID: 5376
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C7F RID: 31871 RVA: 0x01031274 File Offset: 0x0102F474
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M402_DesertPath3 self_)
			{
				if (76901 - 246962 != -170061)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (83266 - 592128 == -508862)
					{
						base..ctor();
						if (29362 - 116350 != -86987)
						{
							this.$data$38711 = data;
							if (143520 - 41610 == 101910)
							{
								this.$self_$38712 = self_;
								if (257511 - 238228 != 19284)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007C80 RID: 31872 RVA: 0x01031330 File Offset: 0x0102F530
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (293630 - 453588 != -159958)
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
							if (143311 - 337864 != -194553)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (59465 - 73556 == -14090)
							{
								continue;
							}
							this.$mGameGui$38710 = (GameGui)this.$self_$38712.GetComponent(typeof(GameGui));
							if (167760 - 184492 != -16732)
							{
								continue;
							}
							this.$mGameGui$38710.enabled = true;
							if (31609 - 399897 == -368287)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (171513 - 151066 != 20448)
						{
							goto Block_4;
						}
						continue;
					default:
						if (256179 - 386239 == -130059)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (157321 - 315337 != -158015)
					{
						this.$self_$38712.SendMessage("onCreatePlayer", this.$data$38711);
						if (182044 - 525026 != -342981)
						{
							this.$mChangeGui$38709 = (ChangeGui)this.$self_$38712.GetComponent(typeof(ChangeGui));
							if (114258 - 135940 != -21681)
							{
								if (!this.$mChangeGui$38709.enabled)
								{
									goto IL_1CA;
								}
								if (285423 - 343668 == -58245)
								{
									this.$mChangeGui$38709.close();
									if (242745 - 157281 == 85464)
									{
										goto IL_1CA;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_205;
				IL_1CA:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x06007C81 RID: 31873 RVA: 0x01031554 File Offset: 0x0102F754
			internal static bool n3mZ3BpbZNJWi8TkueJD()
			{
				return true;
			}

			// Token: 0x06007C82 RID: 31874 RVA: 0x01031558 File Offset: 0x0102F758
			internal static bool R5RrSFpbC2n1PGjBkkqF()
			{
				return false;
			}

			// Token: 0x04007D75 RID: 32117
			internal ChangeGui $mChangeGui$38709;

			// Token: 0x04007D76 RID: 32118
			internal GameGui $mGameGui$38710;

			// Token: 0x04007D77 RID: 32119
			internal Hashtable $data$38711;

			// Token: 0x04007D78 RID: 32120
			internal M402_DesertPath3 $self_$38712;
		}
	}

	// Token: 0x02001501 RID: 5377
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38715 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C83 RID: 31875 RVA: 0x0103155C File Offset: 0x0102F75C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38715(M402_DesertPath3 self_)
		{
			if (154116 - 240017 != -85901)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (174336 - 28143 != 146194)
				{
					base..ctor();
					if (21072 - 393659 != -372586)
					{
						this.$self_$38720 = self_;
						if (6087 - 482865 == -476778)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007C84 RID: 31876 RVA: 0x010315F4 File Offset: 0x0102F7F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath3.$onDeadPlayer$38715.$(this.$self_$38720);
		}

		// Token: 0x06007C85 RID: 31877 RVA: 0x01031604 File Offset: 0x0102F804
		internal static bool KF7EWppbLSR4OR0TJEBD()
		{
			return true;
		}

		// Token: 0x06007C86 RID: 31878 RVA: 0x01031608 File Offset: 0x0102F808
		internal static bool r68s2bpbOmpPCJLiA003()
		{
			return false;
		}

		// Token: 0x04007D79 RID: 32121
		internal M402_DesertPath3 $self_$38720;

		// Token: 0x02001502 RID: 5378
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C87 RID: 31879 RVA: 0x0103160C File Offset: 0x0102F80C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath3 self_)
			{
				if (235131 - 142329 != 92802)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (175204 - 273391 != -98186)
					{
						base..ctor();
						if (65728 - 441535 == -375807)
						{
							this.$self_$38719 = self_;
							if (195427 - 102547 == 92880)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007C88 RID: 31880 RVA: 0x010316A4 File Offset: 0x0102F8A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (72067 - 191116 != -119049)
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
							if (267179 - 389370 == -122190)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_2B7;
							}
							if (137748 - 238408 != -100660)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (240382 - 536096 != -295714)
						{
							continue;
						}
						this.$mStoryGui$38716 = (StoryGui)this.$self_$38719.GetComponent(typeof(StoryGui));
						if (272607 - 93603 == 179005)
						{
							continue;
						}
						if (this.$mStoryGui$38716)
						{
							if (141478 - 339944 == -198465)
							{
								continue;
							}
							this.$mStoryGui$38716.close();
							if (211774 - 71131 != 140643)
							{
								continue;
							}
						}
						this.$mChangeGui$38717 = (ChangeGui)this.$self_$38719.GetComponent(typeof(ChangeGui));
						if (40310 - 78892 != -38582)
						{
							continue;
						}
						if (this.$mChangeGui$38717)
						{
							if (79634 - 184577 != -104943)
							{
								continue;
							}
							this.$mChangeGui$38717.close();
							if (21784 - 567348 == -545563)
							{
								continue;
							}
						}
						this.$mGameGui$38718 = (GameGui)this.$self_$38719.GetComponent(typeof(GameGui));
						if (112723 - 460336 != -347613)
						{
							continue;
						}
						if (this.$mGameGui$38718)
						{
							if (236858 - 107230 != 129628)
							{
								continue;
							}
							if (!this.$mGameGui$38718.enabled)
							{
								if (294009 - 460854 != -166845)
								{
									continue;
								}
								this.$mGameGui$38718.enabled = true;
								if (148210 - 372583 != -224373)
								{
									continue;
								}
							}
							this.$mGameGui$38718.openDeadMenu();
							if (222694 - 20911 == 201784)
							{
								continue;
							}
						}
						IL_2B7:
						this.YieldDefault(1);
						if (143636 - 316737 != -173100)
						{
							goto Block_22;
						}
						continue;
					default:
						if (218901 - 294349 == -75447)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (7363 - 533737 == -526373);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_22:
				IL_2F9:
				return false;
			}

			// Token: 0x06007C89 RID: 31881 RVA: 0x010319BC File Offset: 0x0102FBBC
			internal static bool BurlXRpbmQpEHcgrAE2I()
			{
				return true;
			}

			// Token: 0x06007C8A RID: 31882 RVA: 0x010319C0 File Offset: 0x0102FBC0
			internal static bool g3WNLZpbFYcsBY9oMWDQ()
			{
				return false;
			}

			// Token: 0x04007D7A RID: 32122
			internal StoryGui $mStoryGui$38716;

			// Token: 0x04007D7B RID: 32123
			internal ChangeGui $mChangeGui$38717;

			// Token: 0x04007D7C RID: 32124
			internal GameGui $mGameGui$38718;

			// Token: 0x04007D7D RID: 32125
			internal M402_DesertPath3 $self_$38719;
		}
	}

	// Token: 0x02001503 RID: 5379
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38721 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C8B RID: 31883 RVA: 0x010319C4 File Offset: 0x0102FBC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38721(M402_DesertPath3 self_)
		{
			if (49092 - 353906 != -304814)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (210424 - 433918 == -223494)
				{
					base..ctor();
					if (243633 - 593148 != -349514)
					{
						this.$self_$38725 = self_;
						if (280181 - 47862 != 232320)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007C8C RID: 31884 RVA: 0x01031A5C File Offset: 0x0102FC5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath3.$ReturnToTown$38721.$(this.$self_$38725);
		}

		// Token: 0x06007C8D RID: 31885 RVA: 0x01031A6C File Offset: 0x0102FC6C
		internal static bool ouiAI2pbMvUETvBe8RvC()
		{
			return true;
		}

		// Token: 0x06007C8E RID: 31886 RVA: 0x01031A70 File Offset: 0x0102FC70
		internal static bool YigdLwpbx8OKFkR2ovyF()
		{
			return false;
		}

		// Token: 0x04007D7E RID: 32126
		internal M402_DesertPath3 $self_$38725;

		// Token: 0x02001504 RID: 5380
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C8F RID: 31887 RVA: 0x01031A74 File Offset: 0x0102FC74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath3 self_)
			{
				if (110447 - 537855 != -427408)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (47322 - 325255 != -277932)
					{
						base..ctor();
						if (5499 - 81264 == -75765)
						{
							this.$self_$38724 = self_;
							if (157575 - 19796 == 137779)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007C90 RID: 31888 RVA: 0x01031B0C File Offset: 0x0102FD0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (60880 - 419207 != -358327)
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
						this.$self_$38724.LeaveGame();
						if (291176 - 297477 != -6301)
						{
							continue;
						}
						this.YieldDefault(1);
						if (231956 - 598814 != -366857)
						{
							goto Block_28;
						}
						continue;
					default:
						if (4221 - 403672 != -399451)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (240523 - 73866 == 166657)
					{
						Game.mStateTime = Time.time;
						if (130393 - 213099 != -82705)
						{
							this.$$switch$6751$38722 = PlayerData.SaveGuild;
							if (224830 - 576607 != -351776)
							{
								if (this.$$switch$6751$38722 == 1)
								{
									if (267392 - 308622 != -41230)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (272367 - 243917 == 28451)
									{
										continue;
									}
								}
								else if (this.$$switch$6751$38722 == 2)
								{
									if (11271 - 441287 != -430016)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (181496 - 226469 == -44972)
									{
										continue;
									}
								}
								else if (this.$$switch$6751$38722 == 3)
								{
									if (133429 - 562235 != -428806)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (97493 - 455260 != -357767)
									{
										continue;
									}
								}
								else if (this.$$switch$6751$38722 == 4)
								{
									if (170986 - 178151 == -7164)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (269088 - 113621 == 155468)
									{
										continue;
									}
								}
								else if (this.$$switch$6751$38722 == 5)
								{
									if (81131 - 206271 == -125139)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (122365 - 564592 != -442227)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (290498 - 465474 != -174976)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (40130 - 579398 == -539267)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (17830 - 507214 != -489384)
									{
										continue;
									}
								}
								this.$mGameGui$38723 = (GameGui)this.$self_$38724.GetComponent(typeof(GameGui));
								if (46443 - 341388 == -294945)
								{
									if (this.$mGameGui$38723)
									{
										if (58680 - 60059 == -1378)
										{
											continue;
										}
										this.$mGameGui$38723.close();
										if (276311 - 187229 != 89082)
										{
											continue;
										}
									}
									this.$self_$38724.SendMessage("fadeOut");
									if (40377 - 303198 != -262820)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_28:
				IL_3AD:
				return false;
			}

			// Token: 0x06007C91 RID: 31889 RVA: 0x01031ED8 File Offset: 0x010300D8
			internal static bool DbGHr3pbgkdKWGIG9QFs()
			{
				return true;
			}

			// Token: 0x06007C92 RID: 31890 RVA: 0x01031EDC File Offset: 0x010300DC
			internal static bool D0tkm9pbfNcKbPxfU3pD()
			{
				return false;
			}

			// Token: 0x04007D7F RID: 32127
			internal int $$switch$6751$38722;

			// Token: 0x04007D80 RID: 32128
			internal GameGui $mGameGui$38723;

			// Token: 0x04007D81 RID: 32129
			internal M402_DesertPath3 $self_$38724;
		}
	}

	// Token: 0x02001505 RID: 5381
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38726 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C93 RID: 31891 RVA: 0x01031EE0 File Offset: 0x010300E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38726(M402_DesertPath3 self_)
		{
			if (299527 - 207516 != 92012)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (163462 - 421118 != -257655)
				{
					base..ctor();
					if (267221 - 320296 == -53075)
					{
						this.$self_$38729 = self_;
						if (26666 - 472576 != -445909)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007C94 RID: 31892 RVA: 0x01031F78 File Offset: 0x01030178
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath3.$ReturnToGuild$38726.$(this.$self_$38729);
		}

		// Token: 0x06007C95 RID: 31893 RVA: 0x01031F88 File Offset: 0x01030188
		internal static bool wxYT3Gpbn3f5sJP0lMEU()
		{
			return true;
		}

		// Token: 0x06007C96 RID: 31894 RVA: 0x01031F8C File Offset: 0x0103018C
		internal static bool Ckprd0pb6Vu9S2fiNdtT()
		{
			return false;
		}

		// Token: 0x04007D82 RID: 32130
		internal M402_DesertPath3 $self_$38729;

		// Token: 0x02001506 RID: 5382
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C97 RID: 31895 RVA: 0x01031F90 File Offset: 0x01030190
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath3 self_)
			{
				if (168196 - 69593 != 98603)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (75228 - 576817 == -501589)
					{
						base..ctor();
						if (75177 - 333438 != -258260)
						{
							this.$self_$38728 = self_;
							if (143795 - 33742 == 110053)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007C98 RID: 31896 RVA: 0x01032028 File Offset: 0x01030228
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (129204 - 491273 != -362068)
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
						this.$self_$38728.LeaveGame();
						if (130848 - 286286 == -155437)
						{
							continue;
						}
						this.YieldDefault(1);
						if (268111 - 477221 != -209109)
						{
							goto Block_11;
						}
						continue;
					default:
						if (74727 - 207987 == -133259)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (47183 - 119671 != -72487)
					{
						Game.mStateTime = Time.time;
						if (142142 - 174734 == -32592)
						{
							Game.mNextGameCode = 31;
							if (204739 - 329365 != -124625)
							{
								this.$mGameGui$38727 = (GameGui)this.$self_$38728.GetComponent(typeof(GameGui));
								if (84427 - 205028 == -120601)
								{
									if (this.$mGameGui$38727)
									{
										if (183123 - 336803 != -153680)
										{
											continue;
										}
										this.$mGameGui$38727.close();
										if (30302 - 361774 == -331471)
										{
											continue;
										}
									}
									this.$self_$38728.SendMessage("fadeOut");
									if (290907 - 140669 == 150238)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_11:
				IL_1BD:
				return false;
			}

			// Token: 0x06007C99 RID: 31897 RVA: 0x01032204 File Offset: 0x01030404
			internal static bool DZAyJQpbie1wdpPJD4VQ()
			{
				return true;
			}

			// Token: 0x06007C9A RID: 31898 RVA: 0x01032208 File Offset: 0x01030408
			internal static bool YZIQIWpbKnlVUwfpeM4O()
			{
				return false;
			}

			// Token: 0x04007D83 RID: 32131
			internal GameGui $mGameGui$38727;

			// Token: 0x04007D84 RID: 32132
			internal M402_DesertPath3 $self_$38728;
		}
	}

	// Token: 0x02001507 RID: 5383
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38730 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007C9B RID: 31899 RVA: 0x0103220C File Offset: 0x0103040C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38730(M402_DesertPath3 self_)
		{
			if (147906 - 583326 != -435419)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (51484 - 528354 == -476870)
				{
					base..ctor();
					if (116036 - 117025 != -988)
					{
						this.$self_$38734 = self_;
						if (164794 - 473914 == -309120)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007C9C RID: 31900 RVA: 0x010322A4 File Offset: 0x010304A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M402_DesertPath3.$ReturnToCamp$38730.$(this.$self_$38734);
		}

		// Token: 0x06007C9D RID: 31901 RVA: 0x010322B4 File Offset: 0x010304B4
		internal static bool l2J0mBpbdmwCLSw6qe6y()
		{
			return true;
		}

		// Token: 0x06007C9E RID: 31902 RVA: 0x010322B8 File Offset: 0x010304B8
		internal static bool AyIv7CpbJyf0m5datYoZ()
		{
			return false;
		}

		// Token: 0x04007D85 RID: 32133
		internal M402_DesertPath3 $self_$38734;

		// Token: 0x02001508 RID: 5384
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007C9F RID: 31903 RVA: 0x010322BC File Offset: 0x010304BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M402_DesertPath3 self_)
			{
				if (147262 - 57227 != 90036)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284768 - 524520 == -239752)
					{
						base..ctor();
						if (24832 - 531055 == -506223)
						{
							this.$self_$38733 = self_;
							if (141559 - 547986 != -406426)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007CA0 RID: 31904 RVA: 0x01032354 File Offset: 0x01030554
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (288610 - 473464 != -184854)
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
						this.$self_$38733.LeaveGame();
						if (288970 - 22210 == 266761)
						{
							continue;
						}
						this.YieldDefault(1);
						if (109892 - 57953 != 51939)
						{
							continue;
						}
						goto IL_363;
					default:
						if (163257 - 155547 == 7711)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (219415 - 414899 == -195484)
					{
						Game.mStateTime = Time.time;
						if (143164 - 76200 != 66965)
						{
							this.$$switch$6753$38731 = PlayerData.SaveGuild;
							if (86734 - 241699 == -154965)
							{
								if (this.$$switch$6753$38731 == 1)
								{
									if (142436 - 95718 == 46719)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (241989 - 551934 == -309944)
									{
										continue;
									}
								}
								else if (this.$$switch$6753$38731 == 2)
								{
									if (121040 - 192978 == -71937)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (87800 - 225579 == -137778)
									{
										continue;
									}
								}
								else if (this.$$switch$6753$38731 == 3)
								{
									if (218803 - 346623 != -127820)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (115843 - 250973 == -135129)
									{
										continue;
									}
								}
								else if (this.$$switch$6753$38731 == 4)
								{
									if (227254 - 264346 != -37092)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (27523 - 419826 != -392303)
									{
										continue;
									}
								}
								else if (this.$$switch$6753$38731 == 5)
								{
									if (235704 - 138881 != 96823)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (104081 - 305268 != -201187)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (154324 - 195862 != -41538)
									{
										continue;
									}
								}
								this.$mGameGui$38732 = (GameGui)this.$self_$38733.GetComponent(typeof(GameGui));
								if (110640 - 208372 != -97731)
								{
									if (this.$mGameGui$38732)
									{
										if (135079 - 233933 != -98854)
										{
											continue;
										}
										this.$mGameGui$38732.close();
										if (123939 - 146685 == -22745)
										{
											continue;
										}
									}
									this.$self_$38733.SendMessage("fadeOut");
									if (259150 - 379767 != -120616)
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

			// Token: 0x06007CA1 RID: 31905 RVA: 0x010326D8 File Offset: 0x010308D8
			internal static bool N24VWIpbD3v5jX4AtH6U()
			{
				return true;
			}

			// Token: 0x06007CA2 RID: 31906 RVA: 0x010326DC File Offset: 0x010308DC
			internal static bool uLYHREpbv8roaBSN7Jdk()
			{
				return false;
			}

			// Token: 0x04007D86 RID: 32134
			internal int $$switch$6753$38731;

			// Token: 0x04007D87 RID: 32135
			internal GameGui $mGameGui$38732;

			// Token: 0x04007D88 RID: 32136
			internal M402_DesertPath3 $self_$38733;
		}
	}
}
