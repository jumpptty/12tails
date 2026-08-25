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

// Token: 0x02001E8B RID: 7819
[Serializable]
public class M973_PirateCave2 : MonoBehaviour
{
	// Token: 0x0600B68F RID: 46735 RVA: 0x013AAD78 File Offset: 0x013A8F78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M973_PirateCave2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B690 RID: 46736 RVA: 0x013AAD88 File Offset: 0x013A8F88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (113560 - 565082 != -451521)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (224134 - 532522 == -308388)
			{
				Game.mGameType = 5;
				if (232564 - 226178 == 6386)
				{
					if (Chat.Initialized)
					{
						if (125922 - 36544 != 89379)
						{
							Chat.ChatDisplay.Clear();
							if (43009 - 553889 != -510879)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (115969 - 512903 != -396933)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B691 RID: 46737 RVA: 0x013AAE6C File Offset: 0x013A906C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (21084 - 214266 != -193181)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (213947 - 202929 == 11018)
				{
					if (Game.mNextGameCode != 973)
					{
						break;
					}
					if (229360 - 598894 != -369533)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (289489 - 567144 != -277654)
						{
							Game.nextGame();
							if (240768 - 290091 != -49322)
							{
								Game.mGameCode = 973;
								if (296037 - 348181 != -52143)
								{
									Game.mGameType = 5;
									if (208374 - 449790 == -241416)
									{
										Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
										if (157086 - 427247 != -270160)
										{
											Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
											if (241348 - 102330 != 139019)
											{
												Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
												if (101665 - 3713 == 97952)
												{
													this.oAnn1Np72XO = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
													if (181601 - 463605 != -282003)
													{
														this.Rekn1U4e6la = PhotonClient.Connection;
														if (190360 - 305712 != -115351)
														{
															PhotonClient.ActorNrList.Clear();
															if (75420 - 236346 != -160925)
															{
																this.InitGame();
																if (39511 - 449721 == -410210)
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
			else
			{
				Debug.Log("Not Connected");
				if (164675 - 51990 != 112686)
				{
					Game.mGameType = 99;
					if (255723 - 239125 == 16598)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B692 RID: 46738 RVA: 0x013AB0E4 File Offset: 0x013A92E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (294743 - 110742 != 184002)
		{
		}
		for (;;)
		{
			if (this.Rekn1U4e6la == null)
			{
				if (119845 - 300744 == -180899)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (49691 - 245956 == -196265)
				{
					if (mGameState == eGameState.Init)
					{
						if (150331 - 338310 != -187978)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (224643 - 291898 != -67254)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (247775 - 591603 != -343827)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (98948 - 592422 == -493474)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (288357 - 524028 != -235670)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (267606 - 349700 != -82093)
						{
							if (Game.music != 0)
							{
								if (221311 - 306625 != -85314)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (127558 - 9193 != 118365)
									{
										continue;
									}
									this.audio.Play();
									if (257032 - 285960 == -28927)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (71702 - 176050 == -104347)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (212827 - 573796 == -360968)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (50205 - 283015 == -232809)
								{
									continue;
								}
							}
							if (Time.time <= this.hRVn1EIDonn)
							{
								break;
							}
							if (119716 - 580714 != -460997)
							{
								Game.mGameMana++;
								if (269232 - 468498 == -199266)
								{
									this.hRVn1EIDonn = Time.time + (float)12;
									if (221072 - 411686 != -190613)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (146211 - 566806 != -420594)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (267463 - 439863 != -172399)
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
						if (131024 - 248500 == -117476)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B693 RID: 46739 RVA: 0x013AB458 File Offset: 0x013A9658
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M973_PirateCave2.$onGameEvent$46327(data, this).GetEnumerator();
	}

	// Token: 0x0600B694 RID: 46740 RVA: 0x013AB468 File Offset: 0x013A9668
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void replaceActor(string nType, int nID, bool isCreate)
	{
		if (242346 - 500527 != -258180)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find(nType + nID);
			if (195487 - 8159 == 187328)
			{
				if (gameObject)
				{
					if (270069 - 464819 == -194750)
					{
						if (isCreate)
						{
							if (294475 - 415047 == -120571)
							{
								continue;
							}
							this.createActor(nType, 7, gameObject.transform.position, gameObject.transform.forward);
							if (82025 - 579781 != -497756)
							{
								continue;
							}
						}
						UnityEngine.Object.Destroy(gameObject);
						if (205835 - 74462 == 131373)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Missing " + nType + nID);
					if (262656 - 238937 != 23720)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B695 RID: 46741 RVA: 0x013AB5A4 File Offset: 0x013A97A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PirateEvent1()
	{
		return new M973_PirateCave2.$PirateEvent1$46339(this).GetEnumerator();
	}

	// Token: 0x0600B696 RID: 46742 RVA: 0x013AB5B4 File Offset: 0x013A97B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PirateEvent2()
	{
		return new M973_PirateCave2.$PirateEvent2$46351(this).GetEnumerator();
	}

	// Token: 0x0600B697 RID: 46743 RVA: 0x013AB5C4 File Offset: 0x013A97C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone1(GameObject enterObject)
	{
		if (21219 - 13019 != 8200)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (107420 - 344240 != -236819)
			{
				if (this.oEhn1Bc2DiA)
				{
					break;
				}
				if (175056 - 369057 == -194001)
				{
					Debug.Log("Entering Zone1");
					if (289780 - 255459 != 34322)
					{
						this.oEhn1Bc2DiA = true;
						if (43481 - 548057 != -504575)
						{
							Game.sendMissionEvent(9732, 1);
							if (211057 - 166231 != 44827)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B698 RID: 46744 RVA: 0x013AB6BC File Offset: 0x013A98BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone2(GameObject enterObject)
	{
		if (166688 - 122010 != 44678)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (50761 - 168911 == -118150)
			{
				if (this.gSdn10yWLXb)
				{
					break;
				}
				if (135948 - 504760 != -368811)
				{
					Debug.Log("Entering Zone2");
					if (259624 - 440088 != -180463)
					{
						this.gSdn10yWLXb = true;
						if (293765 - 282438 == 11327)
						{
							Game.sendMissionEvent(9732, 2);
							if (272499 - 231198 == 41301)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B699 RID: 46745 RVA: 0x013AB7B4 File Offset: 0x013A99B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone3(GameObject enterObject)
	{
		if (288152 - 329903 != -41751)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (44583 - 481753 == -437170)
			{
				if (this.T3Rn18iuE89)
				{
					break;
				}
				if (165445 - 563747 != -398301)
				{
					Debug.Log("Entering Zone3");
					if (190360 - 220488 != -30127)
					{
						this.T3Rn18iuE89 = true;
						if (141312 - 217660 == -76348)
						{
							Game.sendMissionEvent(9732, 3);
							if (208722 - 283624 == -74902)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B69A RID: 46746 RVA: 0x013AB8AC File Offset: 0x013A9AAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone4(GameObject enterObject)
	{
		if (195417 - 195401 != 16)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (196177 - 30520 != 165658)
			{
				if (this.dgvn1iQP64O)
				{
					break;
				}
				if (51956 - 429591 == -377635)
				{
					Debug.Log("Entering Zone4");
					if (109874 - 521905 == -412031)
					{
						this.T3Rn18iuE89 = true;
						if (161842 - 461364 != -299521)
						{
							Game.sendMissionEvent(9732, 4);
							if (265145 - 448805 != -183659)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B69B RID: 46747 RVA: 0x013AB9A4 File Offset: 0x013A9BA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone5(GameObject enterObject)
	{
		if (208487 - 157105 != 51383)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (189864 - 197330 != -7465)
			{
				if (this.pCBn1DSVyI6)
				{
					break;
				}
				if (144865 - 591514 != -446648)
				{
					Debug.Log("Entering Zone5");
					if (187074 - 52692 != 134383)
					{
						this.T3Rn18iuE89 = true;
						if (256517 - 216378 == 40139)
						{
							Game.sendMissionEvent(9732, 5);
							if (3583 - 564616 == -561033)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B69C RID: 46748 RVA: 0x013ABA9C File Offset: 0x013A9C9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone6(GameObject enterObject)
	{
		if (9113 - 261478 != -252365)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (244684 - 529524 != -284839)
			{
				if (this.xMQn1mjawnM)
				{
					break;
				}
				if (261482 - 260683 != 800)
				{
					Debug.Log("Entering Zone6");
					if (183587 - 186829 == -3242)
					{
						this.T3Rn18iuE89 = true;
						if (277966 - 137876 == 140090)
						{
							Game.sendMissionEvent(9732, 6);
							if (249280 - 407358 == -158078)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B69D RID: 46749 RVA: 0x013ABB94 File Offset: 0x013A9D94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UsePirateSwitch(int nSwitch)
	{
		if (191893 - 324741 != -132847)
		{
		}
		for (;;)
		{
			Debug.Log("useSwitch1");
			if (49301 - 272438 == -223137)
			{
				if (!this.qNDn1jtfYoP)
				{
					if (296443 - 166057 == 130386)
					{
						this.qNDn1jtfYoP = true;
						if (143458 - 146609 == -3151)
						{
							this.OnUsePirateSwitch(1);
							if (265089 - 450627 == -185538)
							{
								this.OnOpenPirateGate(1);
								if (203219 - 531039 == -327820)
								{
									Game.sendMissionEvent(9732, 7);
									if (68865 - 508069 != -439203)
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
					this.SendMessage("newGameMessage", "This switch has already been used.");
					if (72384 - 58191 == 14193)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B69E RID: 46750 RVA: 0x013ABCCC File Offset: 0x013A9ECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterPirateEvent(GameObject enterObject)
	{
		if (204353 - 590131 != -385777)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (243772 - 266579 != -22806)
			{
				if (this.tQ0n1PNBvde >= 2)
				{
					break;
				}
				if (169723 - 244311 == -74588)
				{
					Debug.Log("Entering PirateEvent");
					if (98812 - 225143 == -126331)
					{
						this.tQ0n1PNBvde = 2;
						if (56474 - 550191 == -493717)
						{
							Game.sendMissionEvent(9732, 8);
							if (60893 - 310583 == -249690)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B69F RID: 46751 RVA: 0x013ABDC4 File Offset: 0x013A9FC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnOpenPirateGate(int nGate)
	{
		if (245002 - 182364 != 62639)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("PirateGate" + nGate);
			if (28085 - 177980 != -149894)
			{
				if (!gameObject)
				{
					break;
				}
				if (134885 - 521770 != -386884)
				{
					gameObject.animation.Play("open");
					if (146725 - 522964 != -376238)
					{
						gameObject.audio.Play();
						if (19749 - 476178 == -456429)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B6A0 RID: 46752 RVA: 0x013ABEA4 File Offset: 0x013AA0A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUsePirateSwitch(int nSwitch)
	{
		if (95259 - 520920 != -425660)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("PirateSwitch" + nSwitch);
			if (169316 - 328789 != -159472)
			{
				if (!gameObject)
				{
					break;
				}
				if (121841 - 95915 != 25927)
				{
					gameObject.animation.Play("pull");
					if (102292 - 573019 == -470727)
					{
						gameObject.audio.Play();
						if (108226 - 215363 == -107137)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B6A1 RID: 46753 RVA: 0x013ABF84 File Offset: 0x013AA184
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (39297 - 274364 != -235066)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (245298 - 422374 == -177076)
			{
				Time.timeScale = 1f;
				if (264821 - 379963 == -115142)
				{
					Hashtable customOpParameters = new Hashtable();
					if (26887 - 109171 == -82284)
					{
						this.Rekn1U4e6la.OpCustom(52, customOpParameters, true);
						if (230862 - 224925 != 5938)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B6A2 RID: 46754 RVA: 0x013AC050 File Offset: 0x013AA250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (217106 - 226051 != -8944)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (81612 - 528509 == -446897)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (115163 - 7268 != 107896)
				{
					Game.mGameState = eGameState.Setup;
					if (50093 - 240272 != -190178)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B6A3 RID: 46755 RVA: 0x013AC0F4 File Offset: 0x013AA2F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (39427 - 436410 != -396983)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (176068 - 370640 != -194571)
			{
				if (num == PlayerData.UID)
				{
					if (214758 - 505014 == -290256)
					{
						this.SetupActors();
						if (280578 - 180685 != 99894)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (236006 - 183903 != 52104)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B6A4 RID: 46756 RVA: 0x013AC1C4 File Offset: 0x013AA3C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (107207 - 53982 != 53225)
		{
		}
		for (;;)
		{
			IL_193:
			Debug.Log("Creating Actors");
			if (256776 - 215700 != 41077)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (88207 - 291577 != -203369)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (122551 - 25489 != 97063)
						{
							int i = 0;
							if (262373 - 99397 != 162977)
							{
								CharacterControl[] array2 = array;
								if (206741 - 180403 != 26339)
								{
									int length = array2.Length;
									if (237814 - 78089 != 159726)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (268435 - 200258 != 68177)
												{
													goto IL_193;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (185713 - 599270 != -413557)
												{
													goto IL_193;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (164520 - 522342 == -357821)
												{
													goto IL_193;
												}
												this.awOn1o12EL9++;
												if (52287 - 301046 != -248759)
												{
													goto IL_193;
												}
											}
											i++;
											if (50350 - 572657 != -522307)
											{
												goto IL_193;
											}
										}
										if (287789 - 238522 == 49267)
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
						if (73037 - 262127 != -189089)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B6A5 RID: 46757 RVA: 0x013AC400 File Offset: 0x013AA600
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (89356 - 17068 != 72289)
		{
		}
		for (;;)
		{
			IL_92:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (230776 - 327481 != -96704)
			{
				int i = 0;
				if (218302 - 39241 == 179061)
				{
					CharacterControl[] array2 = array;
					if (193148 - 209658 != -16509)
					{
						int length = array2.Length;
						if (18082 - 85407 == -67325)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (227472 - 444985 != -217513)
								{
									goto IL_92;
								}
								i++;
								if (156243 - 391355 == -235111)
								{
									goto IL_92;
								}
							}
							if (61675 - 109410 == -47735)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B6A6 RID: 46758 RVA: 0x013AC530 File Offset: 0x013AA730
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (272841 - 524522 != -251681)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (224847 - 483895 != -259047)
			{
				Game.mGameState = eGameState.Ready;
				if (64100 - 292310 != -228209)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (221152 - 65908 != 155245)
					{
						if (39210 - 77235 == -38025)
						{
							GameObject gameObject = null;
							if (6673 - 320011 == -313338)
							{
								if (playerSlot < 1)
								{
									goto IL_6F;
								}
								if (103021 - 519373 == -416351)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_6F;
								}
								if (13369 - 55001 == -41631)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (206944 - 596228 == -389283)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (179731 - 351327 == -171595)
								{
									continue;
								}
								IL_1D8:
								if (gameObject2)
								{
									if (196369 - 428930 == -232560)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (108151 - 280372 != -172221)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (105390 - 200784 != -95394)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (108107 - 267330 == -159222)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (299772 - 379080 == -79307)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (100251 - 507493 != -407242)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (91780 - 281283 != -189503)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (106655 - 358328 != -251673)
								{
									continue;
								}
								break;
								IL_6F:
								gameObject2 = GameObject.Find("StartPoint1");
								if (294422 - 348259 != -53836)
								{
									goto IL_1D8;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B6A7 RID: 46759 RVA: 0x013AC854 File Offset: 0x013AAA54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M973_PirateCave2.$StartGame$46355(this).GetEnumerator();
	}

	// Token: 0x0600B6A8 RID: 46760 RVA: 0x013AC864 File Offset: 0x013AAA64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B6A9 RID: 46761 RVA: 0x013AC868 File Offset: 0x013AAA68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (79993 - 54522 != 25472)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (244287 - 307358 != -63070)
			{
				if (gameObject)
				{
					if (29231 - 232928 == -203697)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (178469 - 36906 == 141563)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (25828 - 499764 != -473935)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B6AA RID: 46762 RVA: 0x013AC964 File Offset: 0x013AAB64
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (282468 - 587808 != -305340)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (272511 - 171651 != 100861)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (133121 - 450108 == -316987)
				{
					hashtable.Add(43, PlayerData.UID);
					if (257519 - 253350 != 4170)
					{
						hashtable.Add(73, nType);
						if (85065 - 342375 == -257310)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (30516 - 534906 != -504389)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (176326 - 524666 == -348340)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (297182 - 493608 == -196426)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (29115 - 89700 == -60585)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (198449 - 271152 != -72702)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (16806 - 59580 != -42773)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (160547 - 142068 == 18479)
													{
														this.Rekn1U4e6la.OpCustom(63, hashtable, true);
														if (53829 - 386609 != -332779)
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

	// Token: 0x0600B6AB RID: 46763 RVA: 0x013ACC48 File Offset: 0x013AAE48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (162971 - 49554 != 113418)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (32137 - 67089 == -34952)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (200123 - 499172 != -299048)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (156747 - 7991 != 148757)
						{
							if (this.awOn1o12EL9 <= 0)
							{
								break;
							}
							if (281515 - 238878 != 42638)
							{
								this.awOn1o12EL9--;
								if (182865 - 382592 != -199726)
								{
									if (this.awOn1o12EL9 != 0)
									{
										break;
									}
									if (214536 - 278160 == -63624)
									{
										Game.setGameState(eGameState.Ready);
										if (57126 - 52496 != 4631)
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
						if (107692 - 341891 != -234198)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (199146 - 524655 == -325509)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B6AC RID: 46764 RVA: 0x013ACDD8 File Offset: 0x013AAFD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B6AD RID: 46765 RVA: 0x013ACDEC File Offset: 0x013AAFEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (205801 - 2133 != 203669)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (12370 - 197635 == -185265)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (97230 - 100132 != -2901)
				{
					if (!characterControl)
					{
						break;
					}
					if (241686 - 220876 == 20810)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (250940 - 564965 == -314025)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (297620 - 141538 != 156083)
							{
								string type = characterControl.Type;
								if (46559 - 62574 == -16015)
								{
									if (type == "GiantSandBug")
									{
										if (229513 - 144915 != 84599)
										{
											Game.sendMissionEvent(9734, 1);
											if (224699 - 417511 == -192812)
											{
												break;
											}
										}
									}
									else if (type == "KingFudaBug")
									{
										if (278084 - 377580 != -99495)
										{
											Game.sendMissionEvent(9734, 2);
											if (191268 - 105929 != 85340)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "PirateFish"))
										{
											break;
										}
										if (60327 - 95871 != -35543)
										{
											Game.sendMissionEvent(9734, 3);
											if (222861 - 213001 == 9860)
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

	// Token: 0x0600B6AE RID: 46766 RVA: 0x013AD00C File Offset: 0x013AB20C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (56254 - 536927 != -480672)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (170973 - 395024 != -224050)
			{
				hashtable.Add(71, CID);
				if (204865 - 42617 == 162248)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (83829 - 236022 == -152193)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (292555 - 584841 != -292285)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (8118 - 491996 != -483877)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (134759 - 58778 != 75982)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (93841 - 500185 == -406344)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (264096 - 108631 != 155466)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (26203 - 38070 == -11867)
											{
												this.Rekn1U4e6la.OpCustom(61, hashtable, true);
												if (266823 - 49729 == 217094)
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

	// Token: 0x0600B6AF RID: 46767 RVA: 0x013AD298 File Offset: 0x013AB498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (244444 - 252468 != -8023)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (26364 - 290083 == -263719)
			{
				if (!gameObject)
				{
					break;
				}
				if (153125 - 261642 == -108517)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (194161 - 266610 != -72448)
					{
						playerCameraControl.target = gameObject;
						if (29309 - 459609 != -430299)
						{
							Game.loadPlayer();
							if (107968 - 191642 == -83674)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (279559 - 384306 != -104746)
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

	// Token: 0x0600B6B0 RID: 46768 RVA: 0x013AD3B0 File Offset: 0x013AB5B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (128536 - 341442 != -212905)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (52591 - 139420 == -86829)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (40120 - 25985 == 14135)
				{
					gameGui.ResetTeamBar();
					if (146080 - 444666 == -298586)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B6B1 RID: 46769 RVA: 0x013AD45C File Offset: 0x013AB65C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M973_PirateCave2.$onDeadPlayer$46359(this).GetEnumerator();
	}

	// Token: 0x0600B6B2 RID: 46770 RVA: 0x013AD46C File Offset: 0x013AB66C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (8153 - 93105 != -84952)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (182704 - 122279 == 60425)
			{
				this.oAnn1Np72XO.target = Game.mPlayer;
				if (275837 - 118365 == 157472)
				{
					this.oAnn1Np72XO.enabled = true;
					if (145697 - 361753 != -216055)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (124712 - 427602 != -302890)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (298041 - 474919 != -176878)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (30859 - 159739 == -128880)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (27303 - 392642 == -365339)
							{
								if (!gameGui)
								{
									break;
								}
								if (42497 - 204549 == -162052)
								{
									gameGui.enabled = true;
									if (154795 - 446440 == -291645)
									{
										gameGui.closeDeadMenu();
										if (11320 - 114393 == -103073)
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

	// Token: 0x0600B6B3 RID: 46771 RVA: 0x013AD618 File Offset: 0x013AB818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (210728 - 102456 != 108272)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (138116 - 197150 != -59033)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (260087 - 172184 == 87903)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (287067 - 411502 == -124435)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B6B4 RID: 46772 RVA: 0x013AD6DC File Offset: 0x013AB8DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B6B5 RID: 46773 RVA: 0x013AD708 File Offset: 0x013AB908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (97300 - 3532 != 93769)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (25040 - 287734 != -262693)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (294575 - 74551 != 220025)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (240004 - 486700 != -246695)
					{
						Hashtable hashtable = new Hashtable();
						if (146677 - 520589 == -373912)
						{
							hashtable.Add(43, PlayerData.UID);
							if (193520 - 319011 != -125490)
							{
								hashtable.Add(71, nCID);
								if (273920 - 204188 == 69732)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (197944 - 427016 != -229071)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (200514 - 183908 != 16607)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (211894 - 468415 != -256520)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (250177 - 547445 != -297267)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (137979 - 150067 == -12088)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (167973 - 24835 != 143139)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (267695 - 507115 != -239419)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (281280 - 257719 != 23562)
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

	// Token: 0x0600B6B6 RID: 46774 RVA: 0x013ADA28 File Offset: 0x013ABC28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M973_PirateCave2.$onChangePlayer$46365(data, this).GetEnumerator();
	}

	// Token: 0x0600B6B7 RID: 46775 RVA: 0x013ADA38 File Offset: 0x013ABC38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M973_PirateCave2.$onGameComplete$46372(data, this).GetEnumerator();
	}

	// Token: 0x0600B6B8 RID: 46776 RVA: 0x013ADA48 File Offset: 0x013ABC48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M973_PirateCave2.$ReturnToTown$46382(this).GetEnumerator();
	}

	// Token: 0x0600B6B9 RID: 46777 RVA: 0x013ADA58 File Offset: 0x013ABC58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M973_PirateCave2.$ReturnToGuild$46387(this).GetEnumerator();
	}

	// Token: 0x0600B6BA RID: 46778 RVA: 0x013ADA68 File Offset: 0x013ABC68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M973_PirateCave2.$ReturnToCamp$46391(this).GetEnumerator();
	}

	// Token: 0x0600B6BB RID: 46779 RVA: 0x013ADA78 File Offset: 0x013ABC78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (287682 - 89992 != 197691)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (47685 - 124999 == -77314)
			{
				Hashtable hashtable = new Hashtable();
				if (119720 - 466848 != -347127)
				{
					hashtable.Add(43, PlayerData.UID);
					if (119770 - 174313 != -54542)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (157274 - 155000 != 2275)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B6BC RID: 46780 RVA: 0x013ADB50 File Offset: 0x013ABD50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B6BD RID: 46781 RVA: 0x013ADB64 File Offset: 0x013ABD64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (104563 - 457654 != -353091)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (283759 - 286993 == -3234)
			{
				Hashtable hashtable = new Hashtable();
				if (96716 - 303969 == -207253)
				{
					if (Game.mNextGameCode == 30)
					{
						if (278401 - 596810 == -318408)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (196704 - 461885 != -265181)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (93997 - 81976 == 12022)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (45180 - 465212 == -420031)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (217866 - 569066 == -351199)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (117895 - 340582 != -222687)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (93798 - 527023 == -433224)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (109389 - 208678 != -99289)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (257366 - 157818 == 99549)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (231548 - 551371 == -319822)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (36979 - 261730 == -224750)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (118422 - 26685 != 91737)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (276617 - 540862 == -264244)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (217254 - 26322 != 190932)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (220704 - 62587 != 158117)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (271189 - 580217 != -309028)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (79979 - 568084 == -488104)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (16864 - 427515 == -410650)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (131704 - 220594 == -88889)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (19740 - 282170 != -262430)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (157491 - 197173 != -39682)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (55688 - 330863 == -275174)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (29863 - 66355 != -36492)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (49101 - 554360 != -505259)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (80409 - 223511 != -143102)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (175699 - 144295 != 31404)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (98545 - 414266 != -315721)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (93752 - 433278 == -339525)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (158981 - 497670 != -338688)
					{
						this.Rekn1U4e6la.OpCustom(42, hashtable, true);
						if (25268 - 516106 == -490838)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B6BE RID: 46782 RVA: 0x013AE118 File Offset: 0x013AC318
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B6BF RID: 46783 RVA: 0x013AE128 File Offset: 0x013AC328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B6C0 RID: 46784 RVA: 0x013AE12C File Offset: 0x013AC32C
	internal static bool drBGS8ttkPMKXASpsECE()
	{
		return true;
	}

	// Token: 0x0600B6C1 RID: 46785 RVA: 0x013AE130 File Offset: 0x013AC330
	internal static bool pRIJqQttGDsW72YV4aXg()
	{
		return false;
	}

	// Token: 0x04009E20 RID: 40480
	private LitePeer Rekn1U4e6la;

	// Token: 0x04009E21 RID: 40481
	private PlayerCameraControl oAnn1Np72XO;

	// Token: 0x04009E22 RID: 40482
	private float hRVn1EIDonn;

	// Token: 0x04009E23 RID: 40483
	private int tQ0n1PNBvde;

	// Token: 0x04009E24 RID: 40484
	private int SHxn1SWJYt2;

	// Token: 0x04009E25 RID: 40485
	public AudioClip pirateMusic;

	// Token: 0x04009E26 RID: 40486
	private bool oEhn1Bc2DiA;

	// Token: 0x04009E27 RID: 40487
	private bool gSdn10yWLXb;

	// Token: 0x04009E28 RID: 40488
	private bool T3Rn18iuE89;

	// Token: 0x04009E29 RID: 40489
	private bool dgvn1iQP64O;

	// Token: 0x04009E2A RID: 40490
	private bool pCBn1DSVyI6;

	// Token: 0x04009E2B RID: 40491
	private bool xMQn1mjawnM;

	// Token: 0x04009E2C RID: 40492
	private bool qNDn1jtfYoP;

	// Token: 0x04009E2D RID: 40493
	private int awOn1o12EL9;

	// Token: 0x02001E8C RID: 7820
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$46327 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B6C2 RID: 46786 RVA: 0x013AE134 File Offset: 0x013AC334
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$46327(Hashtable data, M973_PirateCave2 self_)
		{
			if (286966 - 307446 != -20479)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (115214 - 339274 == -224060)
				{
					base..ctor();
					if (14633 - 542958 != -528324)
					{
						this.$data$46337 = data;
						if (156250 - 253499 != -97248)
						{
							this.$self_$46338 = self_;
							if (258970 - 571860 == -312890)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B6C3 RID: 46787 RVA: 0x013AE1F0 File Offset: 0x013AC3F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave2.$onGameEvent$46327.$(this.$data$46337, this.$self_$46338);
		}

		// Token: 0x0600B6C4 RID: 46788 RVA: 0x013AE204 File Offset: 0x013AC404
		internal static bool Iv9s7NttHVm4gkE3Li2B()
		{
			return true;
		}

		// Token: 0x0600B6C5 RID: 46789 RVA: 0x013AE208 File Offset: 0x013AC408
		internal static bool dyXWotttWDM6cXkkapIn()
		{
			return false;
		}

		// Token: 0x04009E2E RID: 40494
		internal Hashtable $data$46337;

		// Token: 0x04009E2F RID: 40495
		internal M973_PirateCave2 $self_$46338;

		// Token: 0x02001E8D RID: 7821
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B6C6 RID: 46790 RVA: 0x013AE20C File Offset: 0x013AC40C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave2 self_)
			{
				if (224048 - 201391 != 22657)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (85132 - 280057 != -194924)
					{
						base..ctor();
						if (206543 - 493281 != -286737)
						{
							this.$data$46335 = data;
							if (61628 - 310801 != -249172)
							{
								this.$self_$46336 = self_;
								if (180456 - 50428 == 130028)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B6C7 RID: 46791 RVA: 0x013AE2C8 File Offset: 0x013AC4C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (219823 - 445502 != -225679)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_FA0;
					case 2:
						Game.savePlayer();
						if (163978 - 190055 == -26076)
						{
							continue;
						}
						Game.mGameStage = 3;
						if (46528 - 450620 == -404091)
						{
							continue;
						}
						Application.LoadLevel("M973_PirateCave3");
						if (155097 - 1914 != 153184)
						{
							goto IL_4A1;
						}
						continue;
					default:
						if (202641 - 447006 == -244364)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (81188 - 430932 != -349744)
						{
							continue;
						}
						goto IL_ABB;
					}
					else
					{
						this.$returnCode$46328 = RuntimeServices.UnboxInt32(this.$data$46335[141]);
						if (93355 - 125333 != -31978)
						{
							continue;
						}
						this.$returnValue$46329 = RuntimeServices.UnboxInt32(this.$data$46335[145]);
						if (230568 - 462411 == -231842)
						{
							continue;
						}
						this.$ownerID$46330 = RuntimeServices.UnboxInt32(this.$data$46335[43]);
						if (290983 - 132418 == 158566)
						{
							continue;
						}
						this.$$switch$8646$46331 = this.$returnCode$46328;
						if (65658 - 419855 != -354197)
						{
							continue;
						}
						if (this.$$switch$8646$46331 == 9731)
						{
							if (263773 - 531522 == -267748)
							{
								continue;
							}
						}
						else if (this.$$switch$8646$46331 == -9731)
						{
							if (287321 - 386333 == -99011)
							{
								continue;
							}
							if (this.$self_$46336.tQ0n1PNBvde < 3)
							{
								if (266416 - 238640 == 27777)
								{
									continue;
								}
								this.$self_$46336.tQ0n1PNBvde = 3;
								if (182451 - 461010 == -278558)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (227767 - 488363 == -260595)
								{
									continue;
								}
								this.$mGameGui$46332 = (GameGui)this.$self_$46336.GetComponent(typeof(GameGui));
								if (164204 - 401067 != -236863)
								{
									continue;
								}
								this.$mGameGui$46332.close();
								if (24016 - 259824 != -235808)
								{
									continue;
								}
								this.$self_$46336.SendMessage("fadeOut");
								if (28968 - 599016 != -570047)
								{
									break;
								}
								continue;
							}
						}
						else if (this.$$switch$8646$46331 == 9732)
						{
							if (88223 - 7862 != 80361)
							{
								continue;
							}
						}
						else if (this.$$switch$8646$46331 == -9732)
						{
							if (13372 - 14059 != -687)
							{
								continue;
							}
							this.$$switch$8642$46333 = this.$returnValue$46329;
							if (248878 - 353004 != -104126)
							{
								continue;
							}
							if (this.$$switch$8642$46333 == 1)
							{
								if (140529 - 377321 == -236791)
								{
									continue;
								}
								this.$self_$46336.oEhn1Bc2DiA = true;
								if (958 - 112184 != -111226)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$46330)
								{
									if (195171 - 106838 == 88334)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 11);
									if (8956 - 599025 != -590069)
									{
										continue;
									}
									this.$self_$46336.spawnActor("GiantSandBug", 6, 12);
									if (29293 - 140288 == -110994)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8642$46333 == 2)
							{
								if (48877 - 474424 == -425546)
								{
									continue;
								}
								this.$self_$46336.gSdn10yWLXb = true;
								if (204329 - 99507 == 104823)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$46330)
								{
									if (31531 - 201954 != -170423)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 21);
									if (207756 - 549301 != -341545)
									{
										continue;
									}
									this.$self_$46336.spawnActor("GiantSandBug", 6, 22);
									if (239170 - 126458 != 112712)
									{
										continue;
									}
									this.$self_$46336.spawnActor("GiantSandBug", 6, 23);
									if (182466 - 548616 == -366149)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 24);
									if (212345 - 329396 == -117050)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 21);
									if (14152 - 84769 != -70617)
									{
										continue;
									}
									this.$self_$46336.spawnActor("GiantSandBug", 6, 22);
									if (228546 - 193201 != 35345)
									{
										continue;
									}
									this.$self_$46336.spawnActor("GiantSandBug", 6, 23);
									if (124880 - 373473 == -248592)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 24);
									if (30208 - 580356 != -550148)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8642$46333 == 3)
							{
								if (56047 - 35880 != 20167)
								{
									continue;
								}
								this.$self_$46336.T3Rn18iuE89 = true;
								if (207179 - 403 == 206777)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$46330)
								{
									if (87407 - 381931 == -294523)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 31);
									if (164106 - 272553 != -108447)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 32);
									if (87022 - 327702 == -240679)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 33);
									if (224421 - 539543 != -315122)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 34);
									if (272840 - 211368 != 61472)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 35);
									if (208240 - 487015 == -278774)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 36);
									if (208248 - 355908 != -147660)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 37);
									if (263836 - 573731 == -309894)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 38);
									if (232239 - 135610 != 96629)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8642$46333 == 4)
							{
								if (287576 - 206873 != 80703)
								{
									continue;
								}
								this.$self_$46336.dgvn1iQP64O = true;
								if (278026 - 95094 != 182932)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$46330)
								{
									if (92908 - 216051 == -123142)
									{
										continue;
									}
									this.$self_$46336.spawnActor("GiantSandBug", 6, 41);
									if (268379 - 550134 != -281755)
									{
										continue;
									}
									this.$self_$46336.spawnActor("GiantSandBug", 6, 42);
									if (114864 - 386074 != -271210)
									{
										continue;
									}
									this.$self_$46336.spawnActor("GiantSandBug", 6, 41);
									if (147948 - 134665 != 13283)
									{
										continue;
									}
									this.$self_$46336.spawnActor("GiantSandBug", 6, 42);
									if (60838 - 420352 == -359513)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8642$46333 == 5)
							{
								if (127857 - 28585 == 99273)
								{
									continue;
								}
								this.$self_$46336.pCBn1DSVyI6 = true;
								if (25191 - 411621 == -386429)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$46330)
								{
									if (210947 - 210032 == 916)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 51);
									if (27479 - 414474 != -386995)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 52);
									if (89455 - 480041 == -390585)
									{
										continue;
									}
									this.$self_$46336.spawnActor("GiantSandBug", 6, 53);
									if (19324 - 567820 != -548496)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 54);
									if (290331 - 32473 != 257858)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 55);
									if (143877 - 271159 != -127282)
									{
										continue;
									}
									this.$self_$46336.spawnActor("KingFudaBug", 6, 56);
									if (21251 - 216555 != -195304)
									{
										continue;
									}
									this.$self_$46336.spawnActor("GiantSandBug", 6, 57);
									if (153379 - 311277 != -157898)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8642$46333 == 7)
							{
								if (61282 - 389981 != -328699)
								{
									continue;
								}
								if (!this.$self_$46336.qNDn1jtfYoP)
								{
									if (174087 - 589456 == -415368)
									{
										continue;
									}
									this.$self_$46336.qNDn1jtfYoP = true;
									if (286210 - 37740 == 248471)
									{
										continue;
									}
									this.$self_$46336.OnUsePirateSwitch(1);
									if (223991 - 355973 != -131982)
									{
										continue;
									}
									this.$self_$46336.OnOpenPirateGate(1);
									if (13164 - 394744 == -381579)
									{
										continue;
									}
								}
								this.$self_$46336.SendMessage("newGameMessage", "A pirate switch has been used.");
								if (180981 - 185935 == -4953)
								{
									continue;
								}
							}
							else if (this.$$switch$8642$46333 == 8)
							{
								if (63650 - 495215 != -431565)
								{
									continue;
								}
								this.$self_$46336.tQ0n1PNBvde = 2;
								if (145325 - 485198 == -339872)
								{
									continue;
								}
								this.$self_$46336.StartCoroutine_Auto(this.$self_$46336.PirateEvent1());
								if (155494 - 558592 == -403097)
								{
									continue;
								}
							}
							else if (this.$$switch$8642$46333 == 9)
							{
								if (279379 - 548347 == -268967)
								{
									continue;
								}
								this.$self_$46336.replaceActor("PirateFish", 1, PlayerData.UID == this.$ownerID$46330);
								if (196052 - 269796 != -73744)
								{
									continue;
								}
								this.$self_$46336.replaceActor("PirateFish", 2, PlayerData.UID == this.$ownerID$46330);
								if (37635 - 539756 == -502120)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$46330)
								{
									if (49848 - 539604 == -489755)
									{
										continue;
									}
									this.$self_$46336.spawnActor("PirateFish", 7, 61);
									if (200269 - 478802 == -278532)
									{
										continue;
									}
									this.$self_$46336.spawnActor("PirateFish", 7, 62);
									if (40589 - 388454 != -347865)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8646$46331 == 9734)
						{
							if (103954 - 255646 == -151691)
							{
								continue;
							}
							this.$$switch$8644$46334 = this.$returnValue$46329;
							if (220180 - 177272 == 42909)
							{
								continue;
							}
							if (this.$$switch$8644$46334 == 3)
							{
								if (200077 - 25477 != 174600)
								{
									continue;
								}
								this.$self_$46336.SHxn1SWJYt2 = this.$self_$46336.SHxn1SWJYt2 + 1;
								if (79946 - 118315 == -38368)
								{
									continue;
								}
								Debug.Log("Pirate Eliminate: " + this.$self_$46336.SHxn1SWJYt2);
								if (99863 - 498159 != -398296)
								{
									continue;
								}
								this.$self_$46336.SendMessage("newGameMessage", "Pirate Eliminated : " + this.$self_$46336.SHxn1SWJYt2 + "/4");
								if (4132 - 550347 == -546214)
								{
									continue;
								}
								if (this.$self_$46336.SHxn1SWJYt2 >= 4)
								{
									if (280241 - 512784 == -232542)
									{
										continue;
									}
									this.$self_$46336.StartCoroutine_Auto(this.$self_$46336.PirateEvent2());
									if (285471 - 4519 != 280952)
									{
										continue;
									}
								}
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$46328);
							if (290152 - 502141 != -211989)
							{
								continue;
							}
						}
					}
					IL_EA4:
					this.YieldDefault(1);
					if (226536 - 568557 != -342021)
					{
						continue;
					}
					goto IL_FA0;
					IL_4A1:
					goto IL_EA4;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_ABB:
				IL_FA0:
				return false;
			}

			// Token: 0x0600B6C8 RID: 46792 RVA: 0x013AF288 File Offset: 0x013AD488
			internal static bool sxAmN4ttADTLXjrDSkyw()
			{
				return true;
			}

			// Token: 0x0600B6C9 RID: 46793 RVA: 0x013AF28C File Offset: 0x013AD48C
			internal static bool lGKPvFttlbx0F10F6aAq()
			{
				return false;
			}

			// Token: 0x04009E30 RID: 40496
			internal int $returnCode$46328;

			// Token: 0x04009E31 RID: 40497
			internal int $returnValue$46329;

			// Token: 0x04009E32 RID: 40498
			internal int $ownerID$46330;

			// Token: 0x04009E33 RID: 40499
			internal int $$switch$8646$46331;

			// Token: 0x04009E34 RID: 40500
			internal GameGui $mGameGui$46332;

			// Token: 0x04009E35 RID: 40501
			internal int $$switch$8642$46333;

			// Token: 0x04009E36 RID: 40502
			internal int $$switch$8644$46334;

			// Token: 0x04009E37 RID: 40503
			internal Hashtable $data$46335;

			// Token: 0x04009E38 RID: 40504
			internal M973_PirateCave2 $self_$46336;
		}
	}

	// Token: 0x02001E8E RID: 7822
	[CompilerGenerated]
	[Serializable]
	internal sealed class $PirateEvent1$46339 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B6CA RID: 46794 RVA: 0x013AF290 File Offset: 0x013AD490
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $PirateEvent1$46339(M973_PirateCave2 self_)
		{
			if (56453 - 365820 != -309367)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (49947 - 284283 != -234335)
				{
					base..ctor();
					if (54382 - 592677 != -538294)
					{
						this.$self_$46350 = self_;
						if (245781 - 448534 == -202753)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B6CB RID: 46795 RVA: 0x013AF328 File Offset: 0x013AD528
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave2.$PirateEvent1$46339.$(this.$self_$46350);
		}

		// Token: 0x0600B6CC RID: 46796 RVA: 0x013AF338 File Offset: 0x013AD538
		internal static bool Woy1kTtty1NRKtm9ajjW()
		{
			return true;
		}

		// Token: 0x0600B6CD RID: 46797 RVA: 0x013AF33C File Offset: 0x013AD53C
		internal static bool C9eb8NttS13bQxD7Phvd()
		{
			return false;
		}

		// Token: 0x04009E39 RID: 40505
		internal M973_PirateCave2 $self_$46350;

		// Token: 0x02001E8F RID: 7823
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B6CE RID: 46798 RVA: 0x013AF340 File Offset: 0x013AD540
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave2 self_)
			{
				if (90842 - 525445 != -434602)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (285594 - 359761 == -74167)
					{
						base..ctor();
						if (64244 - 257625 == -193381)
						{
							this.$self_$46349 = self_;
							if (93085 - 550131 != -457045)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B6CF RID: 46799 RVA: 0x013AF3D8 File Offset: 0x013AD5D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (51985 - 531014 != -479028)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						goto IL_1C5;
					case 1:
						goto IL_B1A;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (283841 - 300623 != -16782)
							{
								continue;
							}
							goto IL_355;
						}
						else
						{
							this.$mPirateFish1$46341 = GameObject.Find("PirateFish1");
							if (100792 - 49285 == 51508)
							{
								continue;
							}
							this.$mPirateFish2$46342 = GameObject.Find("PirateFish2");
							if (154619 - 468710 != -314091)
							{
								continue;
							}
							this.$mStoryGui$46343 = (StoryGui)this.$self_$46349.GetComponent(typeof(StoryGui));
							if (188872 - 401428 != -212556)
							{
								continue;
							}
							this.$mStoryTimer$46344 = 0f;
							if (10529 - 577003 != -566474)
							{
								continue;
							}
							if (!this.$mStoryGui$46343)
							{
								goto IL_493;
							}
							if (252189 - 145372 == 106818)
							{
								continue;
							}
							this.$mStoryGui$46343.startStoryMessage("none", "Pirate Fish", eTalkType.enemy);
							if (173737 - 522641 == -348903)
							{
								continue;
							}
							this.$mStoryTimer$46344 = Time.time;
							if (247621 - 175709 != 71912)
							{
								continue;
							}
							if (!this.$self_$46349.pirateMusic)
							{
								goto IL_92D;
							}
							if (169290 - 105936 != 63355)
							{
								goto IL_8F8;
							}
							continue;
						}
						break;
					case 3:
						goto IL_8F8;
					case 4:
						goto IL_943;
					case 5:
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (129294 - 163050 != -33756)
							{
								continue;
							}
							goto IL_164;
						}
						else
						{
							this.$mStoryGui$46343.newStoryMessage("none", "Pirate Fish", Language.getMessage("M973_PirateCave", 202), eTalkType.enemy);
							if (265163 - 101578 != 163586)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (37483 - 494202 != -456719)
							{
								continue;
							}
							goto IL_4E2;
						}
						else
						{
							this.$mStoryGui$46343.newStoryMessage("none", "Pirate Fish", Language.getMessage("M973_PirateCave", 203), eTalkType.enemy);
							if (40510 - 520403 != -479892)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (239787 - 232343 != 7444)
							{
								continue;
							}
							goto IL_79F;
						}
						else
						{
							this.$mStoryGui$46343.newStoryMessage("none", "Pirate Fish", Language.getMessage("M973_PirateCave", 204), eTalkType.enemy);
							if (147882 - 154165 != -6283)
							{
								continue;
							}
							goto IL_6FC;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (246828 - 90655 != 156174)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9732, 9);
							if (159748 - 220722 == -60973)
							{
								continue;
							}
							this.$mStoryGui$46343.close();
							if (263687 - 535274 == -271586)
							{
								continue;
							}
							this.$self_$46349.oAnn1Np72XO.enabled = true;
							if (134350 - 319738 != -185388)
							{
								continue;
							}
							goto IL_9B5;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (101939 - 32976 != 68964)
							{
								goto Block_68;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (100593 - 536440 != -435847)
							{
								continue;
							}
							this.$mGameGui$46340.enabled = true;
							if (99872 - 429920 == -330047)
							{
								continue;
							}
							if (!this.$self_$46349.pirateMusic)
							{
								goto IL_493;
							}
							if (61608 - 401137 == -339528)
							{
								continue;
							}
							this.$self_$46349.audio.clip = this.$self_$46349.pirateMusic;
							if (243977 - 265806 == -21828)
							{
								continue;
							}
							this.$self_$46349.audio.volume = 0.1f * (float)Game.music;
							if (194121 - 584564 != -390443)
							{
								continue;
							}
							if (this.$self_$46349.audio.isPlaying)
							{
								goto IL_493;
							}
							if (75423 - 491698 != -416275)
							{
								continue;
							}
							if (Game.volume <= 0)
							{
								goto IL_493;
							}
							if (201688 - 19093 == 182596)
							{
								continue;
							}
							this.$self_$46349.audio.Play();
							if (247636 - 382739 != -135103)
							{
								continue;
							}
							goto IL_493;
						}
						break;
					default:
						if (209506 - 295143 != -85637)
						{
							continue;
						}
						goto IL_1C5;
					}
					IL_1F1:
					if (Time.time >= this.$mStoryTimer$46344 + 0.2f)
					{
						if (1342 - 375236 != -373894)
						{
							continue;
						}
						goto IL_527;
					}
					else
					{
						if (this.$mPirateFish1$46341)
						{
							if (34672 - 538668 == -503995)
							{
								continue;
							}
							this.$$14896$46345 = Mathf.SmoothStep((float)38, (float)164, (float)5 * (Time.time - this.$mStoryTimer$46344));
							if (266194 - 179167 == 87028 || 193415 - 262986 == -69570)
							{
								continue;
							}
							this.$$14897$46346 = this.$mPirateFish1$46341.transform.eulerAngles;
							if (131532 - 426950 != -295418)
							{
								continue;
							}
							if (273274 - 278115 == -4840)
							{
								continue;
							}
							float num = this.$$14897$46346.y = this.$$14896$46345;
							if (61384 - 189059 != -127675)
							{
								continue;
							}
							if (130516 - 202615 == -72098)
							{
								continue;
							}
							this.$mPirateFish1$46341.transform.eulerAngles = this.$$14897$46346;
							if (27942 - 315916 == -287973 || 275567 - 140857 == 134711)
							{
								continue;
							}
						}
						if (!this.$mPirateFish2$46342)
						{
							goto IL_1E5;
						}
						if (20951 - 484457 != -463506)
						{
							continue;
						}
						this.$$14898$46347 = Mathf.SmoothStep((float)-24, (float)-150, (float)5 * (Time.time - this.$mStoryTimer$46344));
						if (242947 - 509537 == -266589)
						{
							continue;
						}
						if (185196 - 501552 != -316356)
						{
							continue;
						}
						Vector3 vector = this.$$14899$46348 = this.$mPirateFish2$46342.transform.eulerAngles;
						if (43417 - 591375 == -547957)
						{
							continue;
						}
						if (111233 - 74278 != 36955)
						{
							continue;
						}
						this.$$14899$46348.y = this.$$14898$46347;
						if (78095 - 167115 == -89019)
						{
							continue;
						}
						if (204623 - 481498 != -276875)
						{
							continue;
						}
						this.$mPirateFish2$46342.transform.eulerAngles = this.$$14899$46348;
						if (162557 - 453963 != -291406)
						{
							continue;
						}
						if (295805 - 482511 != -186706)
						{
							continue;
						}
						goto IL_1E5;
					}
					IL_1C5:
					Game.mGameState = eGameState.AllHold;
					if (43889 - 403927 == -360037)
					{
						continue;
					}
					this.$mGameGui$46340 = (GameGui)this.$self_$46349.GetComponent(typeof(GameGui));
					if (233869 - 299232 != -65363)
					{
						continue;
					}
					if (this.$mGameGui$46340)
					{
						if (150463 - 476244 == -325780)
						{
							continue;
						}
						this.$mGameGui$46340.close();
						if (10101 - 376000 != -365899)
						{
							continue;
						}
					}
					this.$self_$46349.oAnn1Np72XO.StartCoroutine_Auto(this.$self_$46349.oAnn1Np72XO.slerpToObject("EventCamera1", (float)2));
					if (151750 - 292631 != -140881)
					{
						continue;
					}
					goto IL_A73;
					IL_943:
					this.$mStoryGui$46343.newStoryMessage("none", "Pirate Fish", Language.getMessage("M973_PirateCave", 201), eTalkType.enemy);
					if (281239 - 16675 != 264564)
					{
						continue;
					}
					this.$mStoryTimer$46344 = Time.time;
					if (168671 - 331786 != -163114)
					{
						goto IL_1F1;
					}
					continue;
					IL_8F8:
					if (Time.time >= this.$mStoryTimer$46344 + 0.5f)
					{
						if (149207 - 194865 != -45658)
						{
							continue;
						}
						goto IL_943;
					}
					else
					{
						this.$self_$46349.audio.volume = Mathf.Lerp(0.1f * (float)Game.music, (float)0, (float)2 * (Time.time - this.$mStoryTimer$46344));
						if (124698 - 176609 != -51911)
						{
							continue;
						}
						goto IL_8EC;
					}
					IL_493:
					this.YieldDefault(1);
				}
				while (195308 - 593763 != -398455);
				IL_164:
				goto IL_B1A;
				Block_12:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_1E5:
				return this.YieldDefault(5);
				IL_355:
				IL_4E2:
				goto IL_B1A;
				Block_36:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_527:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_6FC:
				return this.Yield(9, new WaitForSeconds(2f));
				Block_51:
				IL_79F:
				goto IL_B1A;
				IL_8EC:
				return this.YieldDefault(3);
				IL_92D:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_9B5:
				return this.Yield(10, new WaitForSeconds(0.5f));
				Block_68:
				goto IL_B1A;
				IL_A73:
				return this.Yield(2, new WaitForSeconds(1.5f));
				IL_B1A:
				return false;
			}

			// Token: 0x0600B6D0 RID: 46800 RVA: 0x013AFF14 File Offset: 0x013AE114
			internal static bool GSb6XStto6itU9Z5eOEu()
			{
				return true;
			}

			// Token: 0x0600B6D1 RID: 46801 RVA: 0x013AFF18 File Offset: 0x013AE118
			internal static bool k85pTjttE3IRvuxOUEmB()
			{
				return false;
			}

			// Token: 0x04009E3A RID: 40506
			internal GameGui $mGameGui$46340;

			// Token: 0x04009E3B RID: 40507
			internal GameObject $mPirateFish1$46341;

			// Token: 0x04009E3C RID: 40508
			internal GameObject $mPirateFish2$46342;

			// Token: 0x04009E3D RID: 40509
			internal StoryGui $mStoryGui$46343;

			// Token: 0x04009E3E RID: 40510
			internal float $mStoryTimer$46344;

			// Token: 0x04009E3F RID: 40511
			internal float $$14896$46345;

			// Token: 0x04009E40 RID: 40512
			internal Vector3 $$14897$46346;

			// Token: 0x04009E41 RID: 40513
			internal float $$14898$46347;

			// Token: 0x04009E42 RID: 40514
			internal Vector3 $$14899$46348;

			// Token: 0x04009E43 RID: 40515
			internal M973_PirateCave2 $self_$46349;
		}
	}

	// Token: 0x02001E90 RID: 7824
	[CompilerGenerated]
	[Serializable]
	internal sealed class $PirateEvent2$46351 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B6D2 RID: 46802 RVA: 0x013AFF1C File Offset: 0x013AE11C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $PirateEvent2$46351(M973_PirateCave2 self_)
		{
			if (50943 - 3385 != 47559)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131871 - 371662 != -239790)
				{
					base..ctor();
					if (278973 - 379496 != -100522)
					{
						this.$self_$46354 = self_;
						if (8780 - 365640 == -356860)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B6D3 RID: 46803 RVA: 0x013AFFB4 File Offset: 0x013AE1B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave2.$PirateEvent2$46351.$(this.$self_$46354);
		}

		// Token: 0x0600B6D4 RID: 46804 RVA: 0x013AFFC4 File Offset: 0x013AE1C4
		internal static bool OoHvhxtt2S107xD0HRm9()
		{
			return true;
		}

		// Token: 0x0600B6D5 RID: 46805 RVA: 0x013AFFC8 File Offset: 0x013AE1C8
		internal static bool afjAJYtt8Wm37cBJQeXx()
		{
			return false;
		}

		// Token: 0x04009E44 RID: 40516
		internal M973_PirateCave2 $self_$46354;

		// Token: 0x02001E91 RID: 7825
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B6D6 RID: 46806 RVA: 0x013AFFCC File Offset: 0x013AE1CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave2 self_)
			{
				if (174345 - 113120 != 61225)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (128331 - 477602 == -349271)
					{
						base..ctor();
						if (169932 - 545381 == -375449)
						{
							this.$self_$46353 = self_;
							if (251704 - 205517 != 46188)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B6D7 RID: 46807 RVA: 0x013B0064 File Offset: 0x013AE264
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (271306 - 94305 != 177001)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_152;
					case 1:
						goto IL_211;
					case 2:
						Game.mGameState = eGameState.AllHold;
						if (88709 - 122704 != -33994)
						{
							this.$mGameGui$46352 = (GameGui)this.$self_$46353.GetComponent(typeof(GameGui));
							if (104163 - 311978 != -207814)
							{
								if (this.$mGameGui$46352)
								{
									if (64724 - 282062 == -217337)
									{
										break;
									}
									this.$mGameGui$46352.close();
									if (220905 - 190210 == 30696)
									{
										break;
									}
								}
								this.$self_$46353.oAnn1Np72XO.StartCoroutine_Auto(this.$self_$46353.oAnn1Np72XO.slerpToObject("EventCamera2", (float)2));
								if (147003 - 474022 == -327019)
								{
									goto IL_5C;
								}
							}
						}
						break;
					case 3:
						this.$self_$46353.OnOpenPirateGate(2);
						if (31471 - 557368 == -525897)
						{
							goto IL_95;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (268529 - 92428 == 176101)
							{
								goto IL_1E7;
							}
						}
						else
						{
							Game.sendMissionEvent(9731, 3);
							if (198753 - 238745 == -39992)
							{
								this.YieldDefault(1);
								if (90847 - 130833 != -39985)
								{
									goto Block_7;
								}
							}
						}
						break;
					default:
						if (27891 - 558393 == -530502)
						{
							goto IL_152;
						}
						break;
					}
				}
				IL_5C:
				return this.Yield(3, new WaitForSeconds((float)2));
				IL_95:
				return this.Yield(4, new WaitForSeconds((float)3));
				Block_7:
				goto IL_211;
				IL_152:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_1E7:
				IL_211:
				return false;
			}

			// Token: 0x0600B6D8 RID: 46808 RVA: 0x013B0294 File Offset: 0x013AE494
			internal static bool cyXty3ttZU2BwD31UhTW()
			{
				return true;
			}

			// Token: 0x0600B6D9 RID: 46809 RVA: 0x013B0298 File Offset: 0x013AE498
			internal static bool pBRp4xttCwL7oojqX5Kd()
			{
				return false;
			}

			// Token: 0x04009E45 RID: 40517
			internal GameGui $mGameGui$46352;

			// Token: 0x04009E46 RID: 40518
			internal M973_PirateCave2 $self_$46353;
		}
	}

	// Token: 0x02001E92 RID: 7826
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$46355 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B6DA RID: 46810 RVA: 0x013B029C File Offset: 0x013AE49C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$46355(M973_PirateCave2 self_)
		{
			if (53658 - 406131 != -352473)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (129777 - 29951 == 99826)
				{
					base..ctor();
					if (8914 - 363038 == -354124)
					{
						this.$self_$46358 = self_;
						if (50784 - 579815 == -529031)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B6DB RID: 46811 RVA: 0x013B0334 File Offset: 0x013AE534
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave2.$StartGame$46355.$(this.$self_$46358);
		}

		// Token: 0x0600B6DC RID: 46812 RVA: 0x013B0344 File Offset: 0x013AE544
		internal static bool qNIhHdttLuqOgkri0n41()
		{
			return true;
		}

		// Token: 0x0600B6DD RID: 46813 RVA: 0x013B0348 File Offset: 0x013AE548
		internal static bool MsjqNBttOHwOGK9uE6Md()
		{
			return false;
		}

		// Token: 0x04009E47 RID: 40519
		internal M973_PirateCave2 $self_$46358;

		// Token: 0x02001E93 RID: 7827
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B6DE RID: 46814 RVA: 0x013B034C File Offset: 0x013AE54C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave2 self_)
			{
				if (230552 - 411584 != -181031)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (274113 - 473805 != -199691)
					{
						base..ctor();
						if (187779 - 1098 == 186681)
						{
							this.$self_$46357 = self_;
							if (267611 - 405151 == -137540)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B6DF RID: 46815 RVA: 0x013B03E4 File Offset: 0x013AE5E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284225 - 440192 != -155967)
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
						if (169076 - 352624 == -183547)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (66041 - 340440 != -274399)
						{
							continue;
						}
						this.YieldDefault(1);
						if (11294 - 542789 != -531495)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (74312 - 306733 == -232420)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (13993 - 284109 == -270116)
					{
						Game.mGameState = eGameState.Start;
						if (99042 - 506035 != -406992)
						{
							Game.mStateTime = Time.time;
							if (28387 - 256232 != -227844)
							{
								this.$mGameGui$46356 = (GameGui)this.$self_$46357.GetComponent(typeof(GameGui));
								if (5129 - 506077 == -500948)
								{
									this.$mGameGui$46356.enabled = true;
									if (239607 - 478162 != -238554)
									{
										this.$self_$46357.SendMessage("fadeIn");
										if (218223 - 485306 != -267082)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x0600B6E0 RID: 46816 RVA: 0x013B05BC File Offset: 0x013AE7BC
			internal static bool c7Nly0ttmAd9VTX5nIsX()
			{
				return true;
			}

			// Token: 0x0600B6E1 RID: 46817 RVA: 0x013B05C0 File Offset: 0x013AE7C0
			internal static bool kc10TMttFoxA040i6pVF()
			{
				return false;
			}

			// Token: 0x04009E48 RID: 40520
			internal GameGui $mGameGui$46356;

			// Token: 0x04009E49 RID: 40521
			internal M973_PirateCave2 $self_$46357;
		}
	}

	// Token: 0x02001E94 RID: 7828
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46359 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B6E2 RID: 46818 RVA: 0x013B05C4 File Offset: 0x013AE7C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46359(M973_PirateCave2 self_)
		{
			if (113030 - 558505 != -445474)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (104084 - 391373 == -287289)
				{
					base..ctor();
					if (93043 - 361447 != -268403)
					{
						this.$self_$46364 = self_;
						if (249351 - 428070 == -178719)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B6E3 RID: 46819 RVA: 0x013B065C File Offset: 0x013AE85C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave2.$onDeadPlayer$46359.$(this.$self_$46364);
		}

		// Token: 0x0600B6E4 RID: 46820 RVA: 0x013B066C File Offset: 0x013AE86C
		internal static bool OS9hVYttM1t5EcMRZ1dd()
		{
			return true;
		}

		// Token: 0x0600B6E5 RID: 46821 RVA: 0x013B0670 File Offset: 0x013AE870
		internal static bool MV50xKttxvC08BHIEBBc()
		{
			return false;
		}

		// Token: 0x04009E4A RID: 40522
		internal M973_PirateCave2 $self_$46364;

		// Token: 0x02001E95 RID: 7829
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B6E6 RID: 46822 RVA: 0x013B0674 File Offset: 0x013AE874
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave2 self_)
			{
				if (244062 - 327170 != -83107)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (198845 - 214011 == -15166)
					{
						base..ctor();
						if (207842 - 249459 != -41616)
						{
							this.$self_$46363 = self_;
							if (37566 - 183625 != -146058)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B6E7 RID: 46823 RVA: 0x013B070C File Offset: 0x013AE90C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (133836 - 478426 != -344590)
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
							if (228034 - 78317 == 149718)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_252;
							}
							if (66450 - 181258 == -114807)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (153211 - 57776 == 95436)
						{
							continue;
						}
						this.$mStoryGui$46360 = (StoryGui)this.$self_$46363.GetComponent(typeof(StoryGui));
						if (126116 - 10143 != 115973)
						{
							continue;
						}
						if (this.$mStoryGui$46360)
						{
							if (70783 - 385591 == -314807)
							{
								continue;
							}
							this.$mStoryGui$46360.close();
							if (292760 - 569279 == -276518)
							{
								continue;
							}
						}
						this.$mChangeGui$46361 = (ChangeGui)this.$self_$46363.GetComponent(typeof(ChangeGui));
						if (39022 - 176499 == -137476)
						{
							continue;
						}
						if (this.$mChangeGui$46361)
						{
							if (144926 - 149405 != -4479)
							{
								continue;
							}
							this.$mChangeGui$46361.close();
							if (235661 - 561670 == -326008)
							{
								continue;
							}
						}
						this.$mGameGui$46362 = (GameGui)this.$self_$46363.GetComponent(typeof(GameGui));
						if (133693 - 271826 == -138132)
						{
							continue;
						}
						if (this.$mGameGui$46362)
						{
							if (284845 - 108359 != 176486)
							{
								continue;
							}
							if (!this.$mGameGui$46362.enabled)
							{
								if (43681 - 220156 != -176475)
								{
									continue;
								}
								this.$mGameGui$46362.enabled = true;
								if (155898 - 344278 != -188380)
								{
									continue;
								}
							}
							this.$mGameGui$46362.openDeadMenu();
							if (45251 - 541401 != -496150)
							{
								continue;
							}
						}
						IL_252:
						this.YieldDefault(1);
						if (61332 - 582254 != -520921)
						{
							goto Block_19;
						}
						continue;
					default:
						if (262027 - 9693 == 252335)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (123126 - 270491 != -147365);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_19:
				IL_2F9:
				return false;
			}

			// Token: 0x0600B6E8 RID: 46824 RVA: 0x013B0A24 File Offset: 0x013AEC24
			internal static bool dcFBtFttgmKRfghRTLCd()
			{
				return true;
			}

			// Token: 0x0600B6E9 RID: 46825 RVA: 0x013B0A28 File Offset: 0x013AEC28
			internal static bool eAtKtNttf3ksHNuaDnUf()
			{
				return false;
			}

			// Token: 0x04009E4B RID: 40523
			internal StoryGui $mStoryGui$46360;

			// Token: 0x04009E4C RID: 40524
			internal ChangeGui $mChangeGui$46361;

			// Token: 0x04009E4D RID: 40525
			internal GameGui $mGameGui$46362;

			// Token: 0x04009E4E RID: 40526
			internal M973_PirateCave2 $self_$46363;
		}
	}

	// Token: 0x02001E96 RID: 7830
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46365 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B6EA RID: 46826 RVA: 0x013B0A2C File Offset: 0x013AEC2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46365(Hashtable data, M973_PirateCave2 self_)
		{
			if (112262 - 108826 != 3436)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (27975 - 95638 == -67663)
				{
					base..ctor();
					if (256642 - 130074 != 126569)
					{
						this.$data$46370 = data;
						if (239033 - 45260 != 193774)
						{
							this.$self_$46371 = self_;
							if (198045 - 412269 == -214224)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B6EB RID: 46827 RVA: 0x013B0AE8 File Offset: 0x013AECE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave2.$onChangePlayer$46365.$(this.$data$46370, this.$self_$46371);
		}

		// Token: 0x0600B6EC RID: 46828 RVA: 0x013B0AFC File Offset: 0x013AECFC
		internal static bool XUnpvxttnl5kiScwVJP6()
		{
			return true;
		}

		// Token: 0x0600B6ED RID: 46829 RVA: 0x013B0B00 File Offset: 0x013AED00
		internal static bool vV0t14tt6gCdpLmjFcAF()
		{
			return false;
		}

		// Token: 0x04009E4F RID: 40527
		internal Hashtable $data$46370;

		// Token: 0x04009E50 RID: 40528
		internal M973_PirateCave2 $self_$46371;

		// Token: 0x02001E97 RID: 7831
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B6EE RID: 46830 RVA: 0x013B0B04 File Offset: 0x013AED04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave2 self_)
			{
				if (115222 - 485510 != -370287)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (321 - 575151 != -574829)
					{
						base..ctor();
						if (239964 - 593173 != -353208)
						{
							this.$data$46368 = data;
							if (296564 - 53785 != 242780)
							{
								this.$self_$46369 = self_;
								if (288546 - 317235 != -28688)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B6EF RID: 46831 RVA: 0x013B0BC0 File Offset: 0x013AEDC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (294247 - 493343 != -199095)
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
							if (40744 - 438863 == -398118)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (292902 - 599976 == -307073)
							{
								continue;
							}
							this.$mGameGui$46367 = (GameGui)this.$self_$46369.GetComponent(typeof(GameGui));
							if (73581 - 176641 != -103060)
							{
								continue;
							}
							this.$mGameGui$46367.enabled = true;
							if (43510 - 177786 == -134275)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (234124 - 550663 != -316539)
						{
							continue;
						}
						goto IL_205;
					default:
						if (4419 - 153282 != -148863)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (198005 - 302937 != -104931)
					{
						this.$self_$46369.SendMessage("onCreatePlayer", this.$data$46368);
						if (214447 - 394566 == -180119)
						{
							this.$mChangeGui$46366 = (ChangeGui)this.$self_$46369.GetComponent(typeof(ChangeGui));
							if (140703 - 137953 != 2751)
							{
								if (!this.$mChangeGui$46366.enabled)
								{
									break;
								}
								if (233243 - 129562 != 103682)
								{
									this.$mChangeGui$46366.close();
									if (258584 - 220186 == 38398)
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

			// Token: 0x0600B6F0 RID: 46832 RVA: 0x013B0DE4 File Offset: 0x013AEFE4
			internal static bool lZbakytti9ROTBeLOnX8()
			{
				return true;
			}

			// Token: 0x0600B6F1 RID: 46833 RVA: 0x013B0DE8 File Offset: 0x013AEFE8
			internal static bool MX93AattK3YJyVm7VaHI()
			{
				return false;
			}

			// Token: 0x04009E51 RID: 40529
			internal ChangeGui $mChangeGui$46366;

			// Token: 0x04009E52 RID: 40530
			internal GameGui $mGameGui$46367;

			// Token: 0x04009E53 RID: 40531
			internal Hashtable $data$46368;

			// Token: 0x04009E54 RID: 40532
			internal M973_PirateCave2 $self_$46369;
		}
	}

	// Token: 0x02001E98 RID: 7832
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46372 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B6F2 RID: 46834 RVA: 0x013B0DEC File Offset: 0x013AEFEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46372(Hashtable data, M973_PirateCave2 self_)
		{
			if (202788 - 86132 != 116656)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (272739 - 61090 == 211649)
				{
					base..ctor();
					if (128869 - 233700 == -104831)
					{
						this.$data$46380 = data;
						if (73576 - 553267 == -479691)
						{
							this.$self_$46381 = self_;
							if (293560 - 328223 != -34662)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B6F3 RID: 46835 RVA: 0x013B0EA8 File Offset: 0x013AF0A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave2.$onGameComplete$46372.$(this.$data$46380, this.$self_$46381);
		}

		// Token: 0x0600B6F4 RID: 46836 RVA: 0x013B0EBC File Offset: 0x013AF0BC
		internal static bool OSsTn9ttdlfkSAagKnx6()
		{
			return true;
		}

		// Token: 0x0600B6F5 RID: 46837 RVA: 0x013B0EC0 File Offset: 0x013AF0C0
		internal static bool XQsEL1ttJsRyLZL3CHb4()
		{
			return false;
		}

		// Token: 0x04009E55 RID: 40533
		internal Hashtable $data$46380;

		// Token: 0x04009E56 RID: 40534
		internal M973_PirateCave2 $self_$46381;

		// Token: 0x02001E99 RID: 7833
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B6F6 RID: 46838 RVA: 0x013B0EC4 File Offset: 0x013AF0C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave2 self_)
			{
				if (131262 - 388042 != -256780)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (178778 - 593345 == -414567)
					{
						base..ctor();
						if (194808 - 169627 == 25181)
						{
							this.$data$46378 = data;
							if (22544 - 191225 == -168681)
							{
								this.$self_$46379 = self_;
								if (105269 - 404371 == -299102)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B6F7 RID: 46839 RVA: 0x013B0F80 File Offset: 0x013AF180
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (123853 - 462878 != -339025)
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
						this.$mCompleteGui$46374 = (CompleteGui)this.$self_$46379.GetComponent(typeof(CompleteGui));
						if (147240 - 111944 == 35297)
						{
							continue;
						}
						this.$mCompleteGui$46374.Init();
						if (264010 - 422280 != -158270)
						{
							continue;
						}
						this.$mCompleteGui$46374.readData(this.$data$46378);
						if (58103 - 374118 != -316015)
						{
							continue;
						}
						if (this.$result$46373 == 1)
						{
							if (299128 - 246328 == 52801)
							{
								continue;
							}
							this.$mCompleteGui$46374.displayResult(eCompleteType.Success);
							if (241551 - 141162 == 100390)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46374.displayResult(eCompleteType.Failed);
							if (217812 - 320119 != -102307)
							{
								continue;
							}
						}
						this.$mGameGui$46375 = (GameGui)this.$self_$46379.GetComponent(typeof(GameGui));
						if (265572 - 425661 == -160088)
						{
							continue;
						}
						this.$mStoryGui$46376 = (StoryGui)this.$self_$46379.GetComponent(typeof(StoryGui));
						if (176821 - 332884 != -156063)
						{
							continue;
						}
						this.$mChangeGui$46377 = (ChangeGui)this.$self_$46379.GetComponent(typeof(ChangeGui));
						if (175829 - 63406 != 112423)
						{
							continue;
						}
						if (this.$mGameGui$46375)
						{
							if (5668 - 451541 != -445873)
							{
								continue;
							}
							this.$mGameGui$46375.close();
							if (67620 - 335109 != -267489)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46376)
						{
							if (151788 - 89334 == 62455)
							{
								continue;
							}
							this.$mStoryGui$46376.close();
							if (290795 - 180337 == 110459)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46377)
						{
							if (77790 - 346749 != -268959)
							{
								continue;
							}
							this.$mChangeGui$46377.disable();
							if (190294 - 555132 == -364837)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (99866 - 536717 != -436851)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (115331 - 326384 != -211053)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46378[31]);
					if (283286 - 450442 == -167156)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (88193 - 218755 != -130561)
							{
								goto Block_27;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (31025 - 154285 != -123259)
							{
								this.$result$46373 = RuntimeServices.UnboxInt32(this.$data$46378[31]);
								if (4294 - 500687 == -496393)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_27:
				IL_3DB:
				return false;
			}

			// Token: 0x0600B6F8 RID: 46840 RVA: 0x013B137C File Offset: 0x013AF57C
			internal static bool I3r5vGttDb6eorLgHfEu()
			{
				return true;
			}

			// Token: 0x0600B6F9 RID: 46841 RVA: 0x013B1380 File Offset: 0x013AF580
			internal static bool pBJZFCttv2qld6DwxIsf()
			{
				return false;
			}

			// Token: 0x04009E57 RID: 40535
			internal int $result$46373;

			// Token: 0x04009E58 RID: 40536
			internal CompleteGui $mCompleteGui$46374;

			// Token: 0x04009E59 RID: 40537
			internal GameGui $mGameGui$46375;

			// Token: 0x04009E5A RID: 40538
			internal StoryGui $mStoryGui$46376;

			// Token: 0x04009E5B RID: 40539
			internal ChangeGui $mChangeGui$46377;

			// Token: 0x04009E5C RID: 40540
			internal Hashtable $data$46378;

			// Token: 0x04009E5D RID: 40541
			internal M973_PirateCave2 $self_$46379;
		}
	}

	// Token: 0x02001E9A RID: 7834
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46382 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B6FA RID: 46842 RVA: 0x013B1384 File Offset: 0x013AF584
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46382(M973_PirateCave2 self_)
		{
			if (225510 - 247194 != -21683)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (88880 - 563459 == -474579)
				{
					base..ctor();
					if (11715 - 305811 != -294095)
					{
						this.$self_$46386 = self_;
						if (204735 - 223027 != -18291)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B6FB RID: 46843 RVA: 0x013B141C File Offset: 0x013AF61C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave2.$ReturnToTown$46382.$(this.$self_$46386);
		}

		// Token: 0x0600B6FC RID: 46844 RVA: 0x013B142C File Offset: 0x013AF62C
		internal static bool RSeZPFttRlShJoTjHulN()
		{
			return true;
		}

		// Token: 0x0600B6FD RID: 46845 RVA: 0x013B1430 File Offset: 0x013AF630
		internal static bool Uu3fgZttwao1jwABXmpX()
		{
			return false;
		}

		// Token: 0x04009E5E RID: 40542
		internal M973_PirateCave2 $self_$46386;

		// Token: 0x02001E9B RID: 7835
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B6FE RID: 46846 RVA: 0x013B1434 File Offset: 0x013AF634
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave2 self_)
			{
				if (45603 - 297588 != -251984)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (13798 - 298021 != -284222)
					{
						base..ctor();
						if (133762 - 174848 == -41086)
						{
							this.$self_$46385 = self_;
							if (24331 - 151546 != -127214)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B6FF RID: 46847 RVA: 0x013B14CC File Offset: 0x013AF6CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (174324 - 311977 != -137653)
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
						this.$self_$46385.LeaveGame();
						if (202825 - 198909 != 3916)
						{
							continue;
						}
						this.YieldDefault(1);
						if (44383 - 51920 != -7536)
						{
							goto Block_25;
						}
						continue;
					default:
						if (104531 - 453870 != -349339)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (170758 - 188716 == -17958)
					{
						Game.mStateTime = Time.time;
						if (50251 - 35234 == 15017)
						{
							this.$$switch$8650$46383 = PlayerData.SaveGuild;
							if (266326 - 461225 != -194898)
							{
								if (this.$$switch$8650$46383 == 1)
								{
									if (255456 - 87219 != 168237)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (281985 - 457501 != -175516)
									{
										continue;
									}
								}
								else if (this.$$switch$8650$46383 == 2)
								{
									if (294671 - 36541 == 258131)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (173895 - 564249 == -390353)
									{
										continue;
									}
								}
								else if (this.$$switch$8650$46383 == 3)
								{
									if (81750 - 562511 == -480760)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (7961 - 204240 != -196279)
									{
										continue;
									}
								}
								else if (this.$$switch$8650$46383 == 4)
								{
									if (108595 - 5478 != 103117)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (245294 - 498657 == -253362)
									{
										continue;
									}
								}
								else if (this.$$switch$8650$46383 == 5)
								{
									if (14054 - 188729 == -174674)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (51030 - 488288 != -437258)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (125756 - 72528 != 53228)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (229930 - 491283 == -261352)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (136958 - 59397 == 77562)
									{
										continue;
									}
								}
								this.$mGameGui$46384 = (GameGui)this.$self_$46385.GetComponent(typeof(GameGui));
								if (199247 - 93092 != 106156)
								{
									if (this.$mGameGui$46384)
									{
										if (44393 - 441100 != -396707)
										{
											continue;
										}
										this.$mGameGui$46384.close();
										if (261890 - 572300 == -310409)
										{
											continue;
										}
									}
									this.$self_$46385.SendMessage("fadeOut");
									if (45830 - 108474 == -62644)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_25:
				IL_3AD:
				return false;
			}

			// Token: 0x0600B700 RID: 46848 RVA: 0x013B1898 File Offset: 0x013AFA98
			internal static bool gJhml6ttqvKVc2uEaGst()
			{
				return true;
			}

			// Token: 0x0600B701 RID: 46849 RVA: 0x013B189C File Offset: 0x013AFA9C
			internal static bool N8yaVBtt7FWeaJHG9l01()
			{
				return false;
			}

			// Token: 0x04009E5F RID: 40543
			internal int $$switch$8650$46383;

			// Token: 0x04009E60 RID: 40544
			internal GameGui $mGameGui$46384;

			// Token: 0x04009E61 RID: 40545
			internal M973_PirateCave2 $self_$46385;
		}
	}

	// Token: 0x02001E9C RID: 7836
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46387 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B702 RID: 46850 RVA: 0x013B18A0 File Offset: 0x013AFAA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46387(M973_PirateCave2 self_)
		{
			if (138954 - 563007 != -424053)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (212307 - 200504 != 11804)
				{
					base..ctor();
					if (228331 - 112461 != 115871)
					{
						this.$self_$46390 = self_;
						if (266321 - 371467 != -105145)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B703 RID: 46851 RVA: 0x013B1938 File Offset: 0x013AFB38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave2.$ReturnToGuild$46387.$(this.$self_$46390);
		}

		// Token: 0x0600B704 RID: 46852 RVA: 0x013B1948 File Offset: 0x013AFB48
		internal static bool F2wBIRttPyIVwYyhhqcN()
		{
			return true;
		}

		// Token: 0x0600B705 RID: 46853 RVA: 0x013B194C File Offset: 0x013AFB4C
		internal static bool asnn2jtt01yZfXXvi6b4()
		{
			return false;
		}

		// Token: 0x04009E62 RID: 40546
		internal M973_PirateCave2 $self_$46390;

		// Token: 0x02001E9D RID: 7837
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B706 RID: 46854 RVA: 0x013B1950 File Offset: 0x013AFB50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave2 self_)
			{
				if (71625 - 263664 != -192038)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (158389 - 181118 != -22728)
					{
						base..ctor();
						if (97216 - 343082 == -245866)
						{
							this.$self_$46389 = self_;
							if (246821 - 100350 == 146471)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B707 RID: 46855 RVA: 0x013B19E8 File Offset: 0x013AFBE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (143417 - 142807 != 611)
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
						this.$self_$46389.LeaveGame();
						if (172903 - 533040 != -360137)
						{
							continue;
						}
						this.YieldDefault(1);
						if (130342 - 392179 != -261836)
						{
							goto Block_6;
						}
						continue;
					default:
						if (250748 - 376225 != -125477)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (257327 - 472577 == -215250)
					{
						Game.mStateTime = Time.time;
						if (287182 - 372027 != -84844)
						{
							Game.mNextGameCode = 31;
							if (102573 - 83676 != 18898)
							{
								this.$mGameGui$46388 = (GameGui)this.$self_$46389.GetComponent(typeof(GameGui));
								if (147364 - 41007 != 106358)
								{
									if (this.$mGameGui$46388)
									{
										if (27249 - 250106 != -222857)
										{
											continue;
										}
										this.$mGameGui$46388.close();
										if (85411 - 207556 != -122145)
										{
											continue;
										}
									}
									this.$self_$46389.SendMessage("fadeOut");
									if (278117 - 429245 == -151128)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_6:
				IL_1BD:
				return false;
			}

			// Token: 0x0600B708 RID: 46856 RVA: 0x013B1BC4 File Offset: 0x013AFDC4
			internal static bool laDUfhttbllILJVaAmMq()
			{
				return true;
			}

			// Token: 0x0600B709 RID: 46857 RVA: 0x013B1BC8 File Offset: 0x013AFDC8
			internal static bool UGRmoTttubKCy2pjfqHK()
			{
				return false;
			}

			// Token: 0x04009E63 RID: 40547
			internal GameGui $mGameGui$46388;

			// Token: 0x04009E64 RID: 40548
			internal M973_PirateCave2 $self_$46389;
		}
	}

	// Token: 0x02001E9E RID: 7838
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46391 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B70A RID: 46858 RVA: 0x013B1BCC File Offset: 0x013AFDCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46391(M973_PirateCave2 self_)
		{
			if (38746 - 90059 != -51312)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (246620 - 263769 == -17149)
				{
					base..ctor();
					if (276885 - 391013 != -114127)
					{
						this.$self_$46394 = self_;
						if (194252 - 294219 == -99967)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B70B RID: 46859 RVA: 0x013B1C64 File Offset: 0x013AFE64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave2.$ReturnToCamp$46391.$(this.$self_$46394);
		}

		// Token: 0x0600B70C RID: 46860 RVA: 0x013B1C74 File Offset: 0x013AFE74
		internal static bool j3HpAfttIXKU0scLTRGU()
		{
			return true;
		}

		// Token: 0x0600B70D RID: 46861 RVA: 0x013B1C78 File Offset: 0x013AFE78
		internal static bool GwK7ewttBYaW9rFx55XK()
		{
			return false;
		}

		// Token: 0x04009E65 RID: 40549
		internal M973_PirateCave2 $self_$46394;

		// Token: 0x02001E9F RID: 7839
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B70E RID: 46862 RVA: 0x013B1C7C File Offset: 0x013AFE7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave2 self_)
			{
				if (61451 - 342857 != -281405)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265981 - 203825 != 62157)
					{
						base..ctor();
						if (146222 - 212005 == -65783)
						{
							this.$self_$46393 = self_;
							if (78153 - 21474 == 56679)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B70F RID: 46863 RVA: 0x013B1D14 File Offset: 0x013AFF14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (206264 - 521893 != -315628)
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
						this.$self_$46393.LeaveGame();
						if (148689 - 268628 == -119938)
						{
							continue;
						}
						this.YieldDefault(1);
						if (139997 - 10688 != 129310)
						{
							goto Block_9;
						}
						continue;
					default:
						if (286138 - 218966 != 67172)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (198448 - 4929 == 193519)
					{
						Game.mStateTime = Time.time;
						if (245149 - 463274 != -218124)
						{
							Game.mNextGameCode = 33;
							if (94415 - 34535 != 59881)
							{
								this.$mGameGui$46392 = (GameGui)this.$self_$46393.GetComponent(typeof(GameGui));
								if (220212 - 228337 == -8125)
								{
									if (this.$mGameGui$46392)
									{
										if (168895 - 289183 != -120288)
										{
											continue;
										}
										this.$mGameGui$46392.close();
										if (141526 - 47206 == 94321)
										{
											continue;
										}
									}
									this.$self_$46393.SendMessage("fadeOut");
									if (74003 - 225972 != -151968)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_9:
				IL_1BD:
				return false;
			}

			// Token: 0x0600B710 RID: 46864 RVA: 0x013B1EF0 File Offset: 0x013B00F0
			internal static bool CJh1ybtteYirlS2fxNYC()
			{
				return true;
			}

			// Token: 0x0600B711 RID: 46865 RVA: 0x013B1EF4 File Offset: 0x013B00F4
			internal static bool FdPCe7ttrBflQh9UEhkx()
			{
				return false;
			}

			// Token: 0x04009E66 RID: 40550
			internal GameGui $mGameGui$46392;

			// Token: 0x04009E67 RID: 40551
			internal M973_PirateCave2 $self_$46393;
		}
	}
}
