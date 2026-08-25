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

// Token: 0x02001EF4 RID: 7924
[Serializable]
public class M973_PirateCave7 : MonoBehaviour
{
	// Token: 0x0600B907 RID: 47367 RVA: 0x013CCF6C File Offset: 0x013CB16C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M973_PirateCave7()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B908 RID: 47368 RVA: 0x013CCF7C File Offset: 0x013CB17C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (156655 - 182297 != -25642)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (125524 - 371194 != -245669)
			{
				Game.mGameType = 5;
				if (203092 - 104470 == 98622)
				{
					if (Chat.Initialized)
					{
						if (90624 - 346139 == -255515)
						{
							Chat.ChatDisplay.Clear();
							if (193975 - 152027 != 41949)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (283044 - 225231 == 57813)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B909 RID: 47369 RVA: 0x013CD060 File Offset: 0x013CB260
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (286642 - 304078 != -17436)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (183604 - 435466 == -251862)
				{
					if (Game.mNextGameCode != 973)
					{
						break;
					}
					if (38177 - 512293 == -474116)
					{
						if (Game.mGameStage != 7)
						{
							break;
						}
						if (104012 - 509370 != -405357)
						{
							Game.nextGame();
							if (53522 - 286722 == -233200)
							{
								Game.mGameCode = 973;
								if (60688 - 298856 != -238167)
								{
									Game.mGameType = 5;
									if (199011 - 502068 == -303057)
									{
										Game.mStateTime = Time.time;
										if (175941 - 395945 == -220004)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (111354 - 520627 == -409273)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (141639 - 22338 != 119302)
												{
													Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
													if (72095 - 395172 == -323077)
													{
														this.PB8nqauwAY7 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
														if (65457 - 79189 == -13732)
														{
															this.hw0nqgSoLiH = PhotonClient.Connection;
															if (90036 - 378240 != -288203)
															{
																PhotonClient.ActorNrList.Clear();
																if (125711 - 307066 == -181355)
																{
																	this.InitGame();
																	if (104352 - 5505 != 98848)
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
			else
			{
				Debug.Log("Not Connected");
				if (51920 - 47233 == 4687)
				{
					Game.mGameType = 99;
					if (209522 - 557094 == -347572)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B90A RID: 47370 RVA: 0x013CD2FC File Offset: 0x013CB4FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (254968 - 43601 != 211367)
		{
		}
		for (;;)
		{
			if (this.hw0nqgSoLiH == null)
			{
				if (231364 - 322578 != -91213)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (271338 - 191406 != 79933)
				{
					if (mGameState == eGameState.Init)
					{
						if (127372 - 515777 == -388405)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (258556 - 129056 == 129500)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (179038 - 188680 != -9641)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (279410 - 173739 == 105671)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (140935 - 542376 != -401440)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (62806 - 194620 == -131814)
						{
							if (Game.music != 0)
							{
								if (65778 - 478636 != -412858)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (293899 - 485839 != -191940)
									{
										continue;
									}
									this.audio.Play();
									if (127614 - 483272 != -355658)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (168534 - 479930 == -311395)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (31775 - 44940 != -13165)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (14282 - 591182 != -576900)
								{
									continue;
								}
							}
							if (Time.time <= this.qLxnq4nINs5)
							{
								break;
							}
							if (108134 - 488639 == -380505)
							{
								Game.mGameMana++;
								if (168895 - 595341 == -426446)
								{
									this.qLxnq4nINs5 = Time.time + (float)12;
									if (167225 - 528975 == -361750)
									{
										if (this.p0enqfkcOKg)
										{
											break;
										}
										if (145503 - 234634 != -89130)
										{
											Chat.SubmitChat("Pirates", Language.getMessage("M973_PirateCave", UnityEngine.Random.Range(701, 709)), eChatType.npc, eChatMode.system);
											if (194242 - 350439 != -156196)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (99404 - 580782 != -481377)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (126516 - 388356 != -261839)
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
						if (259240 - 17395 != 241846)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B90B RID: 47371 RVA: 0x013CD6D4 File Offset: 0x013CB8D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M973_PirateCave7.$onGameEvent$46654(data, this).GetEnumerator();
	}

	// Token: 0x0600B90C RID: 47372 RVA: 0x013CD6E4 File Offset: 0x013CB8E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void replaceZombie(string nType, int nID, bool isCreate)
	{
		if (77886 - 32114 != 45772)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("Fake" + nType + nID);
			if (7803 - 580345 == -572542)
			{
				if (gameObject)
				{
					if (267827 - 392573 != -124745)
					{
						if (isCreate)
						{
							if (114425 - 513572 != -399147)
							{
								continue;
							}
							this.createActor("Zombie" + nType, 7, gameObject.transform.position, gameObject.transform.forward);
							if (179684 - 519089 != -339405)
							{
								continue;
							}
						}
						UnityEngine.Object.Destroy(gameObject);
						if (248118 - 559867 == -311749)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Missing " + nType + nID);
					if (123685 - 250768 == -127083)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B90D RID: 47373 RVA: 0x013CD834 File Offset: 0x013CBA34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator LeopardEvent()
	{
		return new M973_PirateCave7.$LeopardEvent$46668(this).GetEnumerator();
	}

	// Token: 0x0600B90E RID: 47374 RVA: 0x013CD844 File Offset: 0x013CBA44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToLeopard()
	{
		if (69251 - 76750 != -7499)
		{
		}
		do
		{
			if (this.FhWnqCn9kU3)
			{
				if (99454 - 403923 == -304468)
				{
					continue;
				}
				if (!this.T7CnqM8ngMc)
				{
					if (17944 - 399551 == -381606)
					{
						continue;
					}
				}
				else
				{
					if (this.sLGnqZDxKPs)
					{
						break;
					}
					if (5549 - 481477 != -475928)
					{
						continue;
					}
					this.sLGnqZDxKPs = true;
					if (37783 - 460671 == -422887)
					{
						continue;
					}
					Game.sendMissionEvent(9732, 7);
					if (229854 - 49167 != 180688)
					{
						break;
					}
					continue;
				}
			}
			Chat.SubmitChat("Leopard", Language.getMessage("M973_PirateCave", 730), eChatType.system, eChatMode.system);
		}
		while (270290 - 356037 != -85747);
	}

	// Token: 0x0600B90F RID: 47375 RVA: 0x013CD96C File Offset: 0x013CBB6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther()
	{
		return new M973_PirateCave7.$TalkToPanther$46674(this).GetEnumerator();
	}

	// Token: 0x0600B910 RID: 47376 RVA: 0x013CD97C File Offset: 0x013CBB7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToHippo()
	{
		return new M973_PirateCave7.$TalkToHippo$46681(this).GetEnumerator();
	}

	// Token: 0x0600B911 RID: 47377 RVA: 0x013CD98C File Offset: 0x013CBB8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UsePirateSwitch(int nSwitch)
	{
		if (7393 - 14648 != -7254)
		{
		}
		for (;;)
		{
			if (10964 - 279318 == -268354)
			{
				if (nSwitch == 1)
				{
					if (52998 - 591532 != -538533)
					{
						Debug.Log("useSwitch1");
						if (8077 - 534419 == -526342)
						{
							if (!this.p0enqfkcOKg)
							{
								if (245888 - 567448 != -321559)
								{
									this.p0enqfkcOKg = true;
									if (160822 - 454643 != -293820)
									{
										this.OnUsePirateSwitch(1);
										if (75698 - 98425 == -22727)
										{
											this.OnOpenPirateGate(11);
											if (95585 - 498200 != -402614)
											{
												this.OnOpenPirateGate(12);
												if (9961 - 523834 != -513872)
												{
													this.OnOpenPirateGate(13);
													if (267537 - 555203 == -287666)
													{
														Game.sendMissionEvent(9732, 1);
														if (250452 - 196961 != 53492)
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
								this.SendMessage("newGameMessage", "This switch has already been used.");
								if (162542 - 374629 == -212087)
								{
									break;
								}
							}
						}
					}
				}
				else if (nSwitch == 2)
				{
					if (268679 - 565330 == -296651)
					{
						Debug.Log("useSwitch2");
						if (2765 - 503674 == -500909)
						{
							if (!this.iABnqLIoDka)
							{
								if (272314 - 25435 == 246879)
								{
									this.iABnqLIoDka = true;
									if (127120 - 287961 == -160841)
									{
										this.OnUsePirateSwitch(2);
										if (228135 - 229003 == -868)
										{
											this.OnOpenPirateGate(21);
											if (202531 - 21616 == 180915)
											{
												Game.sendMissionEvent(9732, 2);
												if (52831 - 67128 == -14297)
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
								if (297371 - 286298 == 11073)
								{
									break;
								}
							}
						}
					}
				}
				else if (nSwitch == 3)
				{
					if (50430 - 507608 != -457177)
					{
						Debug.Log("useSwitch3");
						if (81602 - 101458 == -19856)
						{
							if (!this.T0vnqwJa4F8)
							{
								if (23125 - 160697 != -137571)
								{
									this.T0vnqwJa4F8 = true;
									if (273564 - 84604 != 188961)
									{
										this.OnUsePirateSwitch(3);
										if (259803 - 443595 == -183792)
										{
											this.OnOpenPirateGate(31);
											if (122226 - 82284 != 39943)
											{
												this.OnOpenPirateGate(32);
												if (242407 - 450053 == -207646)
												{
													this.OnOpenPirateGate(33);
													if (271972 - 564837 != -292864)
													{
														this.OnOpenPirateGate(34);
														if (203707 - 561363 != -357655)
														{
															Game.sendMissionEvent(9732, 4);
															if (285376 - 589446 == -304070)
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
								this.SendMessage("newGameMessage", "This switch has already been used.");
								if (270383 - 147928 != 122456)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					Debug.LogError("Warning unknown switchID:" + nSwitch);
					if (94782 - 239230 != -144447)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B912 RID: 47378 RVA: 0x013CDE34 File Offset: 0x013CC034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUsePirateSwitch(int nSwitch)
	{
		if (205039 - 304350 != -99310)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("PirateSwitch" + nSwitch);
			if (180367 - 327028 == -146661)
			{
				if (gameObject)
				{
					if (114177 - 426860 != -312683)
					{
						continue;
					}
					gameObject.animation.Play("pull");
					if (126794 - 298772 == -171977)
					{
						continue;
					}
					gameObject.audio.Play();
					if (39355 - 507269 != -467914)
					{
						continue;
					}
				}
				this.SendMessage("newGameMessage", "A pirate switch has been activated.");
				if (175942 - 66181 != 109762)
				{
					Chat.SubmitChat("none", "A pirate switch has been activated.", eChatType.system, eChatMode.system);
					if (293109 - 272802 == 20307)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B913 RID: 47379 RVA: 0x013CDF68 File Offset: 0x013CC168
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnOpenPirateGate(int nGate)
	{
		if (81254 - 32367 != 48887)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("PirateGate" + nGate);
			if (25502 - 530576 == -505074)
			{
				if (!gameObject)
				{
					break;
				}
				if (145661 - 263137 == -117476)
				{
					gameObject.animation.Play("open");
					if (66580 - 84474 == -17894)
					{
						gameObject.audio.Play();
						if (81206 - 581377 != -500170)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B914 RID: 47380 RVA: 0x013CE048 File Offset: 0x013CC248
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone1(GameObject enterObject)
	{
		if (30583 - 237709 != -207126)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (209292 - 226177 == -16885)
			{
				if (this.CGgnqUKYoYL)
				{
					break;
				}
				if (144599 - 28772 != 115828)
				{
					Debug.Log("Entering Zone1");
					if (172754 - 472824 != -300069)
					{
						this.CGgnqUKYoYL = true;
						if (98544 - 340012 == -241468)
						{
							Game.sendMissionEvent(9732, 3);
							if (249408 - 136495 == 112913)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B915 RID: 47381 RVA: 0x013CE140 File Offset: 0x013CC340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitPirateCave7()
	{
		if (184220 - 137953 != 46268)
		{
		}
		while (this.PRlnqsRsUiJ < 3)
		{
			if (195954 - 392047 != -196092)
			{
				this.PRlnqsRsUiJ = 3;
				if (164227 - 367838 != -203610)
				{
					Game.sendMissionEvent(9731, 8);
					if (12109 - 393327 != -381217)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B916 RID: 47382 RVA: 0x013CE1E4 File Offset: 0x013CC3E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (148755 - 354859 != -206104)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (106475 - 387342 == -280867)
			{
				Time.timeScale = 1f;
				if (58082 - 426219 != -368136)
				{
					Hashtable customOpParameters = new Hashtable();
					if (150182 - 118643 != 31540)
					{
						this.hw0nqgSoLiH.OpCustom(52, customOpParameters, true);
						if (115206 - 517495 != -402288)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B917 RID: 47383 RVA: 0x013CE2B0 File Offset: 0x013CC4B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (115531 - 398287 != -282755)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (154617 - 187699 != -33081)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (273673 - 555432 == -281759)
				{
					Game.mGameState = eGameState.Setup;
					if (211427 - 62114 != 149314)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B918 RID: 47384 RVA: 0x013CE354 File Offset: 0x013CC554
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (154096 - 231483 != -77386)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (66998 - 179679 == -112681)
			{
				if (num == PlayerData.UID)
				{
					if (278214 - 327252 != -49037)
					{
						this.SetupActors();
						if (168394 - 86623 == 81771)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (53042 - 115623 == -62581)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B919 RID: 47385 RVA: 0x013CE424 File Offset: 0x013CC624
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (180616 - 562607 != -381991)
		{
		}
		for (;;)
		{
			IL_92:
			Debug.Log("Creating Actors");
			if (39421 - 434065 != -394643)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (191310 - 367590 != -176279)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (80310 - 536357 == -456047)
						{
							int i = 0;
							if (138706 - 267463 == -128757)
							{
								CharacterControl[] array2 = array;
								if (61965 - 387438 != -325472)
								{
									int length = array2.Length;
									if (167446 - 446786 != -279339)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (202793 - 134046 == 68748)
												{
													goto IL_92;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (290398 - 117569 != 172829)
												{
													goto IL_92;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (14042 - 319009 != -304967)
												{
													goto IL_92;
												}
												this.Ev7nqNgJ2PV++;
												if (105520 - 328296 != -222776)
												{
													goto IL_92;
												}
											}
											i++;
											if (96444 - 193135 != -96691)
											{
												goto IL_92;
											}
										}
										if (212 - 129362 != -129149)
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
						if (165513 - 597049 != -431535)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B91A RID: 47386 RVA: 0x013CE660 File Offset: 0x013CC860
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (111133 - 169951 != -58818)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (251973 - 84142 == 167831)
			{
				int i = 0;
				if (173419 - 240443 != -67023)
				{
					CharacterControl[] array2 = array;
					if (85829 - 9997 != 75833)
					{
						int length = array2.Length;
						if (53315 - 320735 == -267420)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (6199 - 522439 != -516240)
								{
									goto IL_1A;
								}
								i++;
								if (103155 - 35407 != 67748)
								{
									goto IL_1A;
								}
							}
							if (255977 - 427318 == -171341)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B91B RID: 47387 RVA: 0x013CE790 File Offset: 0x013CC990
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (229450 - 409915 != -180464)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (7590 - 388914 == -381324)
			{
				Game.mGameState = eGameState.Ready;
				if (188720 - 278017 != -89296)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (53033 - 509833 == -456800)
					{
						if (143875 - 217282 != -73406)
						{
							GameObject gameObject = null;
							if (280073 - 387557 == -107484)
							{
								if (playerSlot < 1)
								{
									goto IL_1EF;
								}
								if (191679 - 422899 == -231219)
								{
									continue;
								}
								if (playerSlot > 5)
								{
									goto IL_1EF;
								}
								if (56067 - 12743 != 43324)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (60124 - 517072 != -456948)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (293764 - 440375 != -146611)
								{
									continue;
								}
								IL_6E:
								if (gameObject2)
								{
									if (65635 - 102970 == -37334)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (70220 - 45544 != 24676)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (100866 - 118162 == -17295)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (136527 - 428999 == -292471)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (218416 - 471151 != -252735)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (102928 - 531461 == -428532)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (186549 - 226292 == -39742)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (116837 - 297877 != -181040)
								{
									continue;
								}
								break;
								IL_1EF:
								gameObject2 = GameObject.Find("StartPoint1");
								if (31645 - 333448 == -301803)
								{
									goto IL_6E;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B91C RID: 47388 RVA: 0x013CEAB4 File Offset: 0x013CCCB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M973_PirateCave7.$StartGame$46688(this).GetEnumerator();
	}

	// Token: 0x0600B91D RID: 47389 RVA: 0x013CEAC4 File Offset: 0x013CCCC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B91E RID: 47390 RVA: 0x013CEAC8 File Offset: 0x013CCCC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (286208 - 211848 != 74361)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (108852 - 263017 != -154164)
			{
				if (gameObject)
				{
					if (110774 - 63407 != 47368)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (229320 - 388331 == -159011)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (7853 - 438742 == -430889)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B91F RID: 47391 RVA: 0x013CEBC4 File Offset: 0x013CCDC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (193165 - 509328 != -316162)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (17588 - 13760 != 3829)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (204071 - 419917 != -215845)
				{
					hashtable.Add(43, PlayerData.UID);
					if (116192 - 554298 != -438105)
					{
						hashtable.Add(73, nType);
						if (3531 - 201002 != -197470)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (188751 - 446465 == -257714)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (278029 - 466586 == -188557)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (126517 - 310203 == -183686)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (158121 - 218365 == -60244)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (23358 - 537299 != -513940)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (111596 - 133353 == -21757)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (218654 - 114343 != 104312)
													{
														this.hw0nqgSoLiH.OpCustom(63, hashtable, true);
														if (296758 - 547431 != -250672)
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

	// Token: 0x0600B920 RID: 47392 RVA: 0x013CEEA8 File Offset: 0x013CD0A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (68496 - 239273 != -170776)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (24567 - 423918 != -399350)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (31003 - 434753 != -403749)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (114477 - 516409 == -401932)
						{
							if (this.Ev7nqNgJ2PV <= 0)
							{
								break;
							}
							if (244771 - 484724 == -239953)
							{
								this.Ev7nqNgJ2PV--;
								if (256135 - 568739 == -312604)
								{
									if (this.Ev7nqNgJ2PV != 0)
									{
										break;
									}
									if (76437 - 52413 == 24024)
									{
										Game.setGameState(eGameState.Ready);
										if (268052 - 273618 == -5566)
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
						if (257175 - 509828 == -252653)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (72229 - 150319 != -78089)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B921 RID: 47393 RVA: 0x013CF038 File Offset: 0x013CD238
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B922 RID: 47394 RVA: 0x013CF04C File Offset: 0x013CD24C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (14679 - 242154 != -227474)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (83154 - 291256 == -208102)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (220784 - 189593 == 31191)
				{
					if (!characterControl)
					{
						break;
					}
					if (8927 - 304775 != -295847)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (117498 - 342216 == -224718)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (87645 - 115043 != -27397)
							{
								string type = characterControl.Type;
								if (222015 - 385239 == -163224)
								{
									if (type == "PirateFish")
									{
										if (197114 - 422304 != -225189)
										{
											Game.sendMissionEvent(9734, 3);
											if (253584 - 489075 == -235491)
											{
												break;
											}
										}
									}
									else if (type == "PirateCrawfish")
									{
										if (188635 - 215076 != -26440)
										{
											Game.sendMissionEvent(9734, 4);
											if (139611 - 52319 == 87292)
											{
												break;
											}
										}
									}
									else if (type == "ZombieFish")
									{
										if (106814 - 134515 != -27700)
										{
											Game.sendMissionEvent(9734, 5);
											if (110056 - 96460 == 13596)
											{
												break;
											}
										}
									}
									else if (type == "ZombieCrawfish")
									{
										if (249445 - 512639 != -263193)
										{
											Game.sendMissionEvent(9734, 6);
											if (244411 - 534614 == -290203)
											{
												break;
											}
										}
									}
									else if (type == "PandoraBug")
									{
										if (93327 - 65539 == 27788)
										{
											Game.sendMissionEvent(9734, 7);
											if (134204 - 75048 != 59157)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "CaptainCrab"))
										{
											break;
										}
										if (215783 - 528280 == -312497)
										{
											Game.sendMissionEvent(9734, 8);
											if (224720 - 45402 == 179318)
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

	// Token: 0x0600B923 RID: 47395 RVA: 0x013CF368 File Offset: 0x013CD568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (141330 - 315723 != -174393)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (279642 - 167973 != 111670)
			{
				hashtable.Add(71, CID);
				if (201351 - 156020 != 45332)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (98484 - 266539 != -168054)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (275554 - 555127 == -279573)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (235306 - 147551 != 87756)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (84261 - 494270 != -410008)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (187850 - 524337 != -336486)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (159094 - 158166 != 929)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (31682 - 319532 != -287849)
											{
												this.hw0nqgSoLiH.OpCustom(61, hashtable, true);
												if (163146 - 508481 != -345334)
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

	// Token: 0x0600B924 RID: 47396 RVA: 0x013CF5F4 File Offset: 0x013CD7F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (2965 - 395190 != -392224)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (228444 - 597607 == -369163)
			{
				if (!gameObject)
				{
					break;
				}
				if (150360 - 453550 == -303190)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (271813 - 40505 == 231308)
					{
						playerCameraControl.target = gameObject;
						if (142591 - 24234 == 118357)
						{
							Game.loadPlayer();
							if (270980 - 569880 != -298899)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (195103 - 385625 != -190521)
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

	// Token: 0x0600B925 RID: 47397 RVA: 0x013CF70C File Offset: 0x013CD90C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (241248 - 54073 != 187175)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (107154 - 294118 == -186964)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (249716 - 31716 == 218000)
				{
					gameGui.ResetTeamBar();
					if (102324 - 134426 == -32102)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B926 RID: 47398 RVA: 0x013CF7B8 File Offset: 0x013CD9B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M973_PirateCave7.$onDeadPlayer$46692(this).GetEnumerator();
	}

	// Token: 0x0600B927 RID: 47399 RVA: 0x013CF7C8 File Offset: 0x013CD9C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (120359 - 277556 != -157197)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (31773 - 513152 != -481378)
			{
				this.PB8nqauwAY7.target = Game.mPlayer;
				if (174718 - 247151 == -72433)
				{
					this.PB8nqauwAY7.enabled = true;
					if (47830 - 170 != 47661)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (82212 - 548007 != -465795)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (117812 - 73927 == 43886)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (290446 - 504881 != -214434)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (163665 - 425758 == -262093)
							{
								if (!gameGui)
								{
									break;
								}
								if (271574 - 92636 != 178939)
								{
									gameGui.enabled = true;
									if (65345 - 80671 == -15326)
									{
										gameGui.closeDeadMenu();
										if (77079 - 225394 != -148314)
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

	// Token: 0x0600B928 RID: 47400 RVA: 0x013CF974 File Offset: 0x013CDB74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (131581 - 570096 != -438514)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (53718 - 72951 == -19233)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (20120 - 311599 != -291478)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (231028 - 337282 == -106254)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B929 RID: 47401 RVA: 0x013CFA38 File Offset: 0x013CDC38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B92A RID: 47402 RVA: 0x013CFA64 File Offset: 0x013CDC64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (76004 - 592295 != -516290)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (112052 - 461460 == -349408)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (108769 - 571560 == -462791)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (3901 - 502607 != -498705)
					{
						Hashtable hashtable = new Hashtable();
						if (217050 - 58092 == 158958)
						{
							hashtable.Add(43, PlayerData.UID);
							if (155539 - 316484 != -160944)
							{
								hashtable.Add(71, nCID);
								if (244135 - 313342 == -69207)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (73144 - 184649 != -111504)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (254121 - 420637 != -166515)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (186311 - 325211 == -138900)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (206130 - 492756 == -286626)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (46165 - 392067 != -345901)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (152340 - 300261 == -147921)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (137245 - 35402 != 101844)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (241963 - 202192 != 39772)
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

	// Token: 0x0600B92B RID: 47403 RVA: 0x013CFD84 File Offset: 0x013CDF84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M973_PirateCave7.$onChangePlayer$46698(data, this).GetEnumerator();
	}

	// Token: 0x0600B92C RID: 47404 RVA: 0x013CFD94 File Offset: 0x013CDF94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M973_PirateCave7.$onGameComplete$46705(data, this).GetEnumerator();
	}

	// Token: 0x0600B92D RID: 47405 RVA: 0x013CFDA4 File Offset: 0x013CDFA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M973_PirateCave7.$ReturnToTown$46715(this).GetEnumerator();
	}

	// Token: 0x0600B92E RID: 47406 RVA: 0x013CFDB4 File Offset: 0x013CDFB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M973_PirateCave7.$ReturnToGuild$46720(this).GetEnumerator();
	}

	// Token: 0x0600B92F RID: 47407 RVA: 0x013CFDC4 File Offset: 0x013CDFC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M973_PirateCave7.$ReturnToCamp$46724(this).GetEnumerator();
	}

	// Token: 0x0600B930 RID: 47408 RVA: 0x013CFDD4 File Offset: 0x013CDFD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (42695 - 234616 != -191920)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (150183 - 493309 != -343125)
			{
				Hashtable hashtable = new Hashtable();
				if (76654 - 597778 != -521123)
				{
					hashtable.Add(43, PlayerData.UID);
					if (40374 - 96648 == -56274)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (210976 - 22192 == 188784)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B931 RID: 47409 RVA: 0x013CFEAC File Offset: 0x013CE0AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B932 RID: 47410 RVA: 0x013CFEC0 File Offset: 0x013CE0C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (287585 - 524341 != -236756)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (221755 - 22045 == 199710)
			{
				Hashtable hashtable = new Hashtable();
				if (296446 - 358452 != -62005)
				{
					if (Game.mNextGameCode == 30)
					{
						if (87006 - 21197 != 65809)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (251090 - 252870 == -1779)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (292944 - 120544 == 172401)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (54587 - 2635 == 51953)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (271994 - 228113 == 43882)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (59233 - 28065 != 31168)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (233769 - 402488 != -168719)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (42099 - 131350 == -89250)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (271117 - 381620 == -110502)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (195324 - 342290 != -146966)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (238902 - 17192 != 221710)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (46603 - 25530 != 21073)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (81045 - 167027 != -85982)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (227770 - 454985 == -227214)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (128306 - 165800 != -37494)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (46222 - 403262 != -357040)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (53741 - 302193 == -248451)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (187731 - 193370 == -5638)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (75209 - 272799 != -197590)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (171933 - 444862 == -272928)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (268219 - 482021 != -213802)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (249110 - 137415 == 111696)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (260103 - 342088 != -81985)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (76683 - 149097 != -72414)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (100376 - 250504 == -150127)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (204388 - 465954 != -261566)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (40572 - 464811 != -424239)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (182608 - 151439 == 31170)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (288323 - 580353 != -292029)
					{
						this.hw0nqgSoLiH.OpCustom(42, hashtable, true);
						if (185490 - 78440 != 107051)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B933 RID: 47411 RVA: 0x013D0474 File Offset: 0x013CE674
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B934 RID: 47412 RVA: 0x013D0484 File Offset: 0x013CE684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B935 RID: 47413 RVA: 0x013D0488 File Offset: 0x013CE688
	internal static bool VYGu0QtciApOSshaPO38()
	{
		return true;
	}

	// Token: 0x0600B936 RID: 47414 RVA: 0x013D048C File Offset: 0x013CE68C
	internal static bool EUaR7etcKuCy6kU1s9kT()
	{
		return false;
	}

	// Token: 0x04009F6B RID: 40811
	private LitePeer hw0nqgSoLiH;

	// Token: 0x04009F6C RID: 40812
	private PlayerCameraControl PB8nqauwAY7;

	// Token: 0x04009F6D RID: 40813
	private float qLxnq4nINs5;

	// Token: 0x04009F6E RID: 40814
	private int PRlnqsRsUiJ;

	// Token: 0x04009F6F RID: 40815
	private int n2FnqHTpkYo;

	// Token: 0x04009F70 RID: 40816
	private int y0vnq7bqQnY;

	// Token: 0x04009F71 RID: 40817
	private bool sLGnqZDxKPs;

	// Token: 0x04009F72 RID: 40818
	private bool FhWnqCn9kU3;

	// Token: 0x04009F73 RID: 40819
	private bool T7CnqM8ngMc;

	// Token: 0x04009F74 RID: 40820
	private bool p0enqfkcOKg;

	// Token: 0x04009F75 RID: 40821
	private bool iABnqLIoDka;

	// Token: 0x04009F76 RID: 40822
	private bool T0vnqwJa4F8;

	// Token: 0x04009F77 RID: 40823
	private bool CGgnqUKYoYL;

	// Token: 0x04009F78 RID: 40824
	private int Ev7nqNgJ2PV;

	// Token: 0x02001EF5 RID: 7925
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$46654 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B937 RID: 47415 RVA: 0x013D0490 File Offset: 0x013CE690
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$46654(Hashtable data, M973_PirateCave7 self_)
		{
			if (102671 - 344468 != -241796)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (171999 - 107750 != 64250)
				{
					base..ctor();
					if (221164 - 3513 != 217652)
					{
						this.$data$46666 = data;
						if (132384 - 70007 == 62377)
						{
							this.$self_$46667 = self_;
							if (87330 - 311873 == -224543)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B938 RID: 47416 RVA: 0x013D054C File Offset: 0x013CE74C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave7.$onGameEvent$46654.$(this.$data$46666, this.$self_$46667);
		}

		// Token: 0x0600B939 RID: 47417 RVA: 0x013D0560 File Offset: 0x013CE760
		internal static bool n7bJ0vtcdCgb3JUJn4DV()
		{
			return true;
		}

		// Token: 0x0600B93A RID: 47418 RVA: 0x013D0564 File Offset: 0x013CE764
		internal static bool J8YDZbtcJ1J21ZcSSP9Z()
		{
			return false;
		}

		// Token: 0x04009F79 RID: 40825
		internal Hashtable $data$46666;

		// Token: 0x04009F7A RID: 40826
		internal M973_PirateCave7 $self_$46667;

		// Token: 0x02001EF6 RID: 7926
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B93B RID: 47419 RVA: 0x013D0568 File Offset: 0x013CE768
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave7 self_)
			{
				if (260450 - 309325 != -48874)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (256320 - 13108 == 243212)
					{
						base..ctor();
						if (12579 - 72318 != -59738)
						{
							this.$data$46664 = data;
							if (151282 - 253050 == -101768)
							{
								this.$self_$46665 = self_;
								if (226353 - 304474 == -78121)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B93C RID: 47420 RVA: 0x013D0624 File Offset: 0x013CE824
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (92613 - 45388 != 47226)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1157;
					case 2:
						this.$self_$46665.SendMessage("fadeOut");
						if (232515 - 529378 != -296862)
						{
							goto Block_101;
						}
						continue;
					case 3:
						Game.savePlayer();
						if (116820 - 550132 == -433311)
						{
							continue;
						}
						Game.mGameStage = 8;
						if (121004 - 290298 != -169294)
						{
							continue;
						}
						Application.LoadLevel("M973_PirateCave8");
						if (214403 - 521657 != -307253)
						{
							goto IL_A2F;
						}
						continue;
					default:
						if (157577 - 575576 == -417998)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (203394 - 340711 != -137316)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$46655 = RuntimeServices.UnboxInt32(this.$data$46664[141]);
						if (118387 - 172365 != -53978)
						{
							continue;
						}
						this.$returnValue$46656 = RuntimeServices.UnboxInt32(this.$data$46664[145]);
						if (231698 - 341276 == -109577)
						{
							continue;
						}
						this.$ownerID$46657 = RuntimeServices.UnboxInt32(this.$data$46664[43]);
						if (148481 - 3144 != 145337)
						{
							continue;
						}
						this.$$switch$8707$46658 = this.$returnCode$46655;
						if (238754 - 56099 == 182656)
						{
							continue;
						}
						if (this.$$switch$8707$46658 == 9731)
						{
							if (71323 - 42529 != 28794)
							{
								continue;
							}
						}
						else if (this.$$switch$8707$46658 == -9731)
						{
							if (170158 - 175133 == -4974)
							{
								continue;
							}
							if (this.$self_$46665.PRlnqsRsUiJ < 4)
							{
								if (67519 - 126423 == -58903)
								{
									continue;
								}
								this.$self_$46665.PRlnqsRsUiJ = 4;
								if (269354 - 119269 != 150085)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (40909 - 32309 != 8600)
								{
									continue;
								}
								this.$mGameGui$46659 = (GameGui)this.$self_$46665.GetComponent(typeof(GameGui));
								if (55158 - 177536 == -122377)
								{
									continue;
								}
								this.$mGameGui$46659.close();
								if (35293 - 442665 == -407371)
								{
									continue;
								}
								this.$self_$46665.PB8nqauwAY7.StartCoroutine_Auto(this.$self_$46665.PB8nqauwAY7.slerpToObject("EventCamera3", (float)2));
								if (185702 - 264505 != -78802)
								{
									goto Block_120;
								}
								continue;
							}
						}
						else if (this.$$switch$8707$46658 == 9732)
						{
							if (126282 - 272667 == -146384)
							{
								continue;
							}
						}
						else if (this.$$switch$8707$46658 == -9732)
						{
							if (296625 - 303150 == -6524)
							{
								continue;
							}
							this.$$switch$8703$46660 = this.$returnValue$46656;
							if (260732 - 500584 == -239851)
							{
								continue;
							}
							if (this.$$switch$8703$46660 == 1)
							{
								if (72388 - 31378 != 41010)
								{
									continue;
								}
								if (!this.$self_$46665.p0enqfkcOKg)
								{
									if (214955 - 392480 == -177524)
									{
										continue;
									}
									this.$self_$46665.p0enqfkcOKg = true;
									if (36380 - 463482 != -427102)
									{
										continue;
									}
									this.$self_$46665.OnUsePirateSwitch(1);
									if (67631 - 295165 != -227534)
									{
										continue;
									}
									this.$self_$46665.OnOpenPirateGate(11);
									if (297891 - 275356 != 22535)
									{
										continue;
									}
									this.$self_$46665.OnOpenPirateGate(12);
									if (130390 - 25654 == 104737)
									{
										continue;
									}
									this.$self_$46665.OnOpenPirateGate(13);
									if (267178 - 410073 != -142895)
									{
										continue;
									}
								}
								this.$self_$46665.replaceZombie("Fish", 1, PlayerData.UID == this.$ownerID$46657);
								if (133850 - 226829 == -92978)
								{
									continue;
								}
								this.$self_$46665.replaceZombie("Fish", 2, PlayerData.UID == this.$ownerID$46657);
								if (113984 - 494945 == -380960)
								{
									continue;
								}
								this.$self_$46665.replaceZombie("Crawfish", 1, PlayerData.UID == this.$ownerID$46657);
								if (110098 - 74763 != 35335)
								{
									continue;
								}
								this.$self_$46665.replaceZombie("Crawfish", 2, PlayerData.UID == this.$ownerID$46657);
								if (168760 - 205733 != -36973)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$46657)
								{
									if (64739 - 422551 == -357811)
									{
										continue;
									}
									this.$self_$46665.spawnActor("ZombieFish", 7, 12);
									if (201632 - 260918 != -59286)
									{
										continue;
									}
									this.$self_$46665.spawnActor("ZombieCrawfish", 7, 13);
									if (131209 - 440466 != -309257)
									{
										continue;
									}
								}
								Chat.SubmitChat("Pirates", Language.getMessage("M973_PirateCave", 709), eChatType.npc, eChatMode.system);
								if (209846 - 238662 == -28815)
								{
									continue;
								}
							}
							else if (this.$$switch$8703$46660 == 2)
							{
								if (45752 - 58073 != -12321)
								{
									continue;
								}
								if (!this.$self_$46665.iABnqLIoDka)
								{
									if (159644 - 581902 != -422258)
									{
										continue;
									}
									this.$self_$46665.iABnqLIoDka = true;
									if (298464 - 379204 != -80740)
									{
										continue;
									}
									this.$self_$46665.OnUsePirateSwitch(2);
									if (131219 - 47300 == 83920)
									{
										continue;
									}
									this.$self_$46665.OnOpenPirateGate(21);
									if (30783 - 445720 != -414937)
									{
										continue;
									}
								}
								if (PlayerData.UID == this.$ownerID$46657)
								{
									if (110387 - 233598 != -123211)
									{
										continue;
									}
									this.$self_$46665.spawnActor("PandoraBug", 7, 11);
									if (20194 - 514180 != -493986)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8703$46660 == 3)
							{
								if (276533 - 77206 != 199327)
								{
									continue;
								}
								this.$self_$46665.CGgnqUKYoYL = true;
								if (53107 - 25314 != 27793)
								{
									continue;
								}
								if (PlayerData.UID == this.$ownerID$46657)
								{
									if (63110 - 349809 != -286699)
									{
										continue;
									}
									this.$self_$46665.spawnActor("ZombieFish", 7, 21);
									if (274822 - 24244 != 250578)
									{
										continue;
									}
									this.$self_$46665.spawnActor("ZombieFish", 7, 22);
									if (207519 - 163245 != 44274)
									{
										continue;
									}
									this.$self_$46665.spawnActor("ZombieFish", 7, 23);
									if (126442 - 263331 != -136889)
									{
										continue;
									}
									this.$self_$46665.spawnActor("ZombieFish", 7, 24);
									if (191151 - 539547 == -348395)
									{
										continue;
									}
									this.$self_$46665.spawnActor("ZombieCrawfish", 7, 25);
									if (192048 - 556752 == -364703)
									{
										continue;
									}
									this.$self_$46665.spawnActor("ZombieCrawfish", 7, 26);
									if (27542 - 435108 != -407566)
									{
										continue;
									}
									this.$self_$46665.spawnActor("ZombieCrawfish", 7, 27);
									if (298199 - 561411 == -263211)
									{
										continue;
									}
									this.$self_$46665.spawnActor("PandoraBug", 7, 28);
									if (70141 - 263948 == -193806)
									{
										continue;
									}
									this.$self_$46665.spawnActor("PandoraBug", 7, 29);
									if (9685 - 542965 != -533280)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8703$46660 == 4)
							{
								if (269437 - 567273 == -297835)
								{
									continue;
								}
								if (!this.$self_$46665.T0vnqwJa4F8)
								{
									if (184544 - 88158 == 96387)
									{
										continue;
									}
									this.$self_$46665.T0vnqwJa4F8 = true;
									if (176856 - 509007 != -332151)
									{
										continue;
									}
									this.$self_$46665.OnUsePirateSwitch(3);
									if (256980 - 61814 == 195167)
									{
										continue;
									}
									this.$self_$46665.OnOpenPirateGate(31);
									if (12776 - 304176 != -291400)
									{
										continue;
									}
									this.$self_$46665.OnOpenPirateGate(32);
									if (26345 - 85962 == -59616)
									{
										continue;
									}
									this.$self_$46665.OnOpenPirateGate(33);
									if (85348 - 310102 != -224754)
									{
										continue;
									}
									this.$self_$46665.OnOpenPirateGate(34);
									if (102109 - 439300 != -337191)
									{
										continue;
									}
									this.$self_$46665.spawnActor("ZombieFish", 7, 31);
									if (103415 - 74376 == 29040)
									{
										continue;
									}
									this.$self_$46665.spawnActor("ZombieCrawfish", 7, 32);
									if (17214 - 406166 != -388952)
									{
										continue;
									}
									this.$self_$46665.spawnActor("ZombieCrawfish", 7, 33);
									if (58252 - 440267 == -382014)
									{
										continue;
									}
									this.$self_$46665.spawnActor("PandoraBug", 7, 34);
									if (297993 - 237446 == 60548)
									{
										continue;
									}
									this.$self_$46665.spawnActor("PandoraBug", 7, 35);
									if (169160 - 82869 == 86292)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8703$46660 == 5)
							{
								if (259598 - 300065 == -40466)
								{
									continue;
								}
								if (!this.$self_$46665.FhWnqCn9kU3)
								{
									if (143693 - 351308 == -207614)
									{
										continue;
									}
									this.$mPanther$46661 = GameObject.Find("Panther");
									if (78836 - 473282 == -394445)
									{
										continue;
									}
									if (this.$mPanther$46661)
									{
										if (284424 - 300751 == -16326)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mPanther$46661);
										if (134030 - 107255 == 26776)
										{
											continue;
										}
									}
								}
								this.$self_$46665.FhWnqCn9kU3 = true;
								if (155433 - 31789 == 123645)
								{
									continue;
								}
								this.$self_$46665.n2FnqHTpkYo = this.$self_$46665.n2FnqHTpkYo + 1;
								if (209083 - 79298 == 129786)
								{
									continue;
								}
								this.$self_$46665.SendMessage("newGameMessage", "Mission Objective - NPC Saved: " + this.$self_$46665.n2FnqHTpkYo + "/3");
								if (6091 - 525885 != -519794)
								{
									continue;
								}
								Chat.SubmitChat("none", "Mission Objective - NPC Saved: " + this.$self_$46665.n2FnqHTpkYo + "/3", eChatType.system, eChatMode.system);
								if (55887 - 449515 == -393627)
								{
									continue;
								}
							}
							else if (this.$$switch$8703$46660 == 6)
							{
								if (267265 - 179203 == 88063)
								{
									continue;
								}
								if (!this.$self_$46665.T7CnqM8ngMc)
								{
									if (116620 - 36560 != 80060)
									{
										continue;
									}
									this.$mHippo$46662 = GameObject.Find("Hippo");
									if (93924 - 42187 != 51737)
									{
										continue;
									}
									if (this.$mHippo$46662)
									{
										if (231942 - 385987 != -154045)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mHippo$46662);
										if (245000 - 267117 != -22117)
										{
											continue;
										}
									}
								}
								this.$self_$46665.T7CnqM8ngMc = true;
								if (299764 - 392040 == -92275)
								{
									continue;
								}
								this.$self_$46665.n2FnqHTpkYo = this.$self_$46665.n2FnqHTpkYo + 1;
								if (183003 - 4296 == 178708)
								{
									continue;
								}
								this.$self_$46665.SendMessage("newGameMessage", "Mission Objective - NPC Saved: " + this.$self_$46665.n2FnqHTpkYo + "/3");
								if (92684 - 367103 != -274419)
								{
									continue;
								}
								Chat.SubmitChat("none", "Mission Objective - NPC Saved: " + this.$self_$46665.n2FnqHTpkYo + "/3", eChatType.system, eChatMode.system);
								if (215694 - 182263 == 33432)
								{
									continue;
								}
							}
							else if (this.$$switch$8703$46660 == 7)
							{
								if (225352 - 6186 != 219166)
								{
									continue;
								}
								this.$self_$46665.sLGnqZDxKPs = true;
								if (124558 - 480088 == -355529)
								{
									continue;
								}
								this.$self_$46665.StartCoroutine_Auto(this.$self_$46665.LeopardEvent());
								if (278895 - 500693 != -221798)
								{
									continue;
								}
							}
						}
						else if (this.$$switch$8707$46658 == 9734)
						{
							if (244561 - 491054 != -246493)
							{
								continue;
							}
							this.$$switch$8705$46663 = this.$returnValue$46656;
							if (223242 - 538424 == -315181)
							{
								continue;
							}
							if (this.$$switch$8705$46663 == 5)
							{
								goto IL_967;
							}
							if (210510 - 569829 == -359318)
							{
								continue;
							}
							if (this.$$switch$8705$46663 == 6)
							{
								if (82459 - 528774 != -446315)
								{
									continue;
								}
								goto IL_967;
							}
							goto IL_2E5;
							IL_967:
							this.$self_$46665.y0vnq7bqQnY = this.$self_$46665.y0vnq7bqQnY + 1;
							if (28032 - 440845 == -412812)
							{
								continue;
							}
							Debug.Log("Zombie Eliminate: " + this.$self_$46665.y0vnq7bqQnY);
							if (105334 - 44215 != 61119)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$46655);
							if (61382 - 283434 == -222051)
							{
								continue;
							}
						}
					}
					IL_2E5:
					this.YieldDefault(1);
					if (62713 - 27030 != 35683)
					{
						continue;
					}
					break;
					IL_A2F:
					goto IL_2E5;
				}
				goto IL_1157;
				Block_101:
				return this.Yield(3, new WaitForSeconds((float)1));
				Block_120:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_1157:
				return false;
			}

			// Token: 0x0600B93D RID: 47421 RVA: 0x013D179C File Offset: 0x013CF99C
			internal static bool AYyOittcD0GdJyb8BDXv()
			{
				return true;
			}

			// Token: 0x0600B93E RID: 47422 RVA: 0x013D17A0 File Offset: 0x013CF9A0
			internal static bool zxgwOItcvihqUhQwiHFo()
			{
				return false;
			}

			// Token: 0x04009F7B RID: 40827
			internal int $returnCode$46655;

			// Token: 0x04009F7C RID: 40828
			internal int $returnValue$46656;

			// Token: 0x04009F7D RID: 40829
			internal int $ownerID$46657;

			// Token: 0x04009F7E RID: 40830
			internal int $$switch$8707$46658;

			// Token: 0x04009F7F RID: 40831
			internal GameGui $mGameGui$46659;

			// Token: 0x04009F80 RID: 40832
			internal int $$switch$8703$46660;

			// Token: 0x04009F81 RID: 40833
			internal GameObject $mPanther$46661;

			// Token: 0x04009F82 RID: 40834
			internal GameObject $mHippo$46662;

			// Token: 0x04009F83 RID: 40835
			internal int $$switch$8705$46663;

			// Token: 0x04009F84 RID: 40836
			internal Hashtable $data$46664;

			// Token: 0x04009F85 RID: 40837
			internal M973_PirateCave7 $self_$46665;
		}
	}

	// Token: 0x02001EF7 RID: 7927
	[CompilerGenerated]
	[Serializable]
	internal sealed class $LeopardEvent$46668 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B93F RID: 47423 RVA: 0x013D17A4 File Offset: 0x013CF9A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $LeopardEvent$46668(M973_PirateCave7 self_)
		{
			if (13122 - 375488 != -362366)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (299689 - 228906 != 70784)
				{
					base..ctor();
					if (139840 - 244468 != -104627)
					{
						this.$self_$46673 = self_;
						if (120422 - 423735 != -303312)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B940 RID: 47424 RVA: 0x013D183C File Offset: 0x013CFA3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave7.$LeopardEvent$46668.$(this.$self_$46673);
		}

		// Token: 0x0600B941 RID: 47425 RVA: 0x013D184C File Offset: 0x013CFA4C
		internal static bool IEOI9rtcR5kuDEh6a2M3()
		{
			return true;
		}

		// Token: 0x0600B942 RID: 47426 RVA: 0x013D1850 File Offset: 0x013CFA50
		internal static bool e9KQ4otcwyngdumwJywJ()
		{
			return false;
		}

		// Token: 0x04009F86 RID: 40838
		internal M973_PirateCave7 $self_$46673;

		// Token: 0x02001EF8 RID: 7928
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B943 RID: 47427 RVA: 0x013D1854 File Offset: 0x013CFA54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave7 self_)
			{
				if (123475 - 442519 != -319043)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (182289 - 74359 != 107931)
					{
						base..ctor();
						if (222292 - 171812 == 50480)
						{
							this.$self_$46672 = self_;
							if (299711 - 466463 == -166752)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B944 RID: 47428 RVA: 0x013D18EC File Offset: 0x013CFAEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (247368 - 344587 != -97219)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_94B;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (259430 - 53830 != 205601)
							{
								goto Block_61;
							}
							continue;
						}
						else
						{
							this.$self_$46672.SendMessage("fadeOut");
							if (195062 - 263235 != -68172)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (241461 - 469455 != -227994)
							{
								continue;
							}
							goto IL_2D8;
						}
						else
						{
							this.$self_$46672.PB8nqauwAY7.alignToObject("EventCamera1");
							if (174099 - 138412 != 35688)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (93170 - 223820 != -130650)
							{
								continue;
							}
							goto IL_774;
						}
						else
						{
							this.$self_$46672.SendMessage("fadeIn");
							if (91442 - 23732 != 67711)
							{
								goto Block_51;
							}
							continue;
						}
						break;
					case 5:
						this.$mStoryGui$46670 = (StoryGui)this.$self_$46672.GetComponent(typeof(StoryGui));
						if (217655 - 430369 != -212714)
						{
							continue;
						}
						this.$mStoryGui$46670.startStoryMessage("Leopard", "Leopard", eTalkType.friend);
						if (169747 - 573499 != -403752)
						{
							continue;
						}
						goto IL_617;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (222626 - 529846 != -307220)
							{
								continue;
							}
							goto IL_8AB;
						}
						else
						{
							this.$mStoryGui$46670.newStoryMessage("Leopard", "Leopard", Language.getMessage("M973_PirateCave", 731), eTalkType.friend);
							if (277956 - 361175 != -83219)
							{
								continue;
							}
							goto IL_67C;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (208837 - 513588 != -304751)
							{
								continue;
							}
							goto IL_7A3;
						}
						else
						{
							this.$mStoryGui$46670.newStoryMessage("Leopard", "Leopard", Language.getMessage("M973_PirateCave", 732), eTalkType.friend);
							if (52005 - 123273 != -71268)
							{
								continue;
							}
							goto IL_5DC;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (273687 - 456947 != -183260)
							{
								continue;
							}
							goto IL_6F3;
						}
						else
						{
							this.$mStoryGui$46670.newStoryMessage("Leopard", "Leopard", Language.getMessage("M973_PirateCave", 733), eTalkType.friend);
							if (171496 - 87828 != 83669)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (241012 - 371749 != -130736)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46670.newStoryMessage("Leopard", "Leopard", Language.getMessage("M973_PirateCave", 734), eTalkType.friend);
							if (69645 - 434558 != -364912)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (173913 - 516411 != -342498)
							{
								continue;
							}
							goto IL_4A0;
						}
						else
						{
							this.$mStoryGui$46670.newStoryMessage("Leopard", "Leopard", Language.getMessage("M973_PirateCave", 735), eTalkType.friend);
							if (203005 - 284780 == -81774)
							{
								continue;
							}
							this.$self_$46672.PB8nqauwAY7.alignToObject("EventCamera2");
							if (98620 - 80488 != 18133)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (15107 - 242194 != -227086)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46670.blank();
							if (187938 - 330925 != -142987)
							{
								continue;
							}
							this.$self_$46672.OnOpenPirateGate(41);
							if (56776 - 257431 != -200654)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (42476 - 332610 != -290133)
							{
								goto Block_55;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46670.newStoryMessage("Leopard", "Leopard", Language.getMessage("M973_PirateCave", 736), eTalkType.friend);
							if (246262 - 36758 == 209505)
							{
								continue;
							}
							this.$self_$46672.PB8nqauwAY7.alignToObject("EventCamera1");
							if (119002 - 340305 != -221303)
							{
								continue;
							}
							goto IL_6B7;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (197182 - 410649 != -213467)
							{
								continue;
							}
							goto IL_33B;
						}
						else
						{
							this.$mLeopard$46671 = GameObject.Find("Leopard");
							if (97597 - 530792 != -433195)
							{
								continue;
							}
							if (this.$mLeopard$46671)
							{
								if (12238 - 68046 != -55808)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mLeopard$46671);
								if (51938 - 400538 == -348599)
								{
									continue;
								}
							}
							this.$mStoryGui$46670.close();
							if (196558 - 63191 != 133367)
							{
								continue;
							}
							goto IL_738;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (69295 - 174176 != -104881)
							{
								continue;
							}
							goto IL_183;
						}
						else
						{
							this.$mGameGui$46669.enabled = true;
							if (238657 - 598870 != -360213)
							{
								continue;
							}
							this.$self_$46672.PB8nqauwAY7.enabled = true;
							if (17464 - 581884 != -564419)
							{
								goto Block_38;
							}
							continue;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (41112 - 47658 != -6545)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (166341 - 16547 != 149794)
							{
								continue;
							}
							this.$self_$46672.SendMessage("newGameMessage", "Mission Objective - NPC Saved: 3/3");
							if (75945 - 157585 != -81640)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mission Objective - NPC Saved 3/3", eChatType.system, eChatMode.system);
							if (218766 - 333478 == -114711)
							{
								continue;
							}
							this.YieldDefault(1);
							if (66681 - 569680 != -502998)
							{
								goto Block_53;
							}
							continue;
						}
						break;
					default:
						if (295823 - 361231 != -65408)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Talk To Leopard");
					if (126476 - 552741 != -426264)
					{
						Game.mGameState = eGameState.AllHold;
						if (255887 - 509869 != -253981)
						{
							this.$mGameGui$46669 = (GameGui)this.$self_$46672.GetComponent(typeof(GameGui));
							if (12425 - 30021 == -17596)
							{
								if (!this.$mGameGui$46669)
								{
									goto IL_910;
								}
								if (172962 - 176445 == -3483)
								{
									this.$mGameGui$46669.close();
									if (116405 - 114350 != 2056)
									{
										goto Block_24;
									}
								}
							}
						}
					}
				}
				IL_183:
				Block_16:
				goto IL_94B;
				Block_19:
				return this.Yield(10, new WaitForSeconds(3f));
				IL_2D8:
				goto IL_94B;
				Block_20:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_33B:
				goto IL_94B;
				Block_23:
				return this.Yield(11, new WaitForSeconds(3f));
				Block_24:
				goto IL_910;
				Block_25:
				return this.Yield(12, new WaitForSeconds(3f));
				Block_27:
				goto IL_94B;
				Block_29:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_4A0:
				Block_32:
				goto IL_94B;
				Block_38:
				return this.Yield(15, new WaitForSeconds(1f));
				IL_5DC:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_617:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_67C:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_6B7:
				return this.Yield(13, new WaitForSeconds(3f));
				IL_6F3:
				goto IL_94B;
				Block_48:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_738:
				return this.Yield(14, new WaitForSeconds(0.5f));
				IL_774:
				goto IL_94B;
				Block_51:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_7A3:
				Block_53:
				Block_55:
				IL_8AB:
				goto IL_94B;
				IL_910:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_61:
				IL_94B:
				return false;
			}

			// Token: 0x0600B945 RID: 47429 RVA: 0x013D2258 File Offset: 0x013D0458
			internal static bool UkSSIhtcqZlb13N6sZc7()
			{
				return true;
			}

			// Token: 0x0600B946 RID: 47430 RVA: 0x013D225C File Offset: 0x013D045C
			internal static bool JLS0o7tc7mWYAMuEDPHQ()
			{
				return false;
			}

			// Token: 0x04009F87 RID: 40839
			internal GameGui $mGameGui$46669;

			// Token: 0x04009F88 RID: 40840
			internal StoryGui $mStoryGui$46670;

			// Token: 0x04009F89 RID: 40841
			internal GameObject $mLeopard$46671;

			// Token: 0x04009F8A RID: 40842
			internal M973_PirateCave7 $self_$46672;
		}
	}

	// Token: 0x02001EF9 RID: 7929
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$46674 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B947 RID: 47431 RVA: 0x013D2260 File Offset: 0x013D0460
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$46674(M973_PirateCave7 self_)
		{
			if (74480 - 333873 != -259392)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (286104 - 447198 == -161094)
				{
					base..ctor();
					if (180048 - 184915 == -4867)
					{
						this.$self_$46680 = self_;
						if (33021 - 389064 == -356043)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B948 RID: 47432 RVA: 0x013D22F8 File Offset: 0x013D04F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave7.$TalkToPanther$46674.$(this.$self_$46680);
		}

		// Token: 0x0600B949 RID: 47433 RVA: 0x013D2308 File Offset: 0x013D0508
		internal static bool jb6r55tcPbpgYBNK507A()
		{
			return true;
		}

		// Token: 0x0600B94A RID: 47434 RVA: 0x013D230C File Offset: 0x013D050C
		internal static bool NPIZfAtc0IVXdsp7tP2W()
		{
			return false;
		}

		// Token: 0x04009F8B RID: 40843
		internal M973_PirateCave7 $self_$46680;

		// Token: 0x02001EFA RID: 7930
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B94B RID: 47435 RVA: 0x013D2310 File Offset: 0x013D0510
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave7 self_)
			{
				if (202184 - 475339 != -273154)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (11978 - 359253 == -347275)
					{
						base..ctor();
						if (292605 - 130394 != 162212)
						{
							this.$self_$46679 = self_;
							if (245882 - 407050 == -161168)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B94C RID: 47436 RVA: 0x013D23A8 File Offset: 0x013D05A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (1590 - 176016 != -174425)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_58A;
					case 1:
						goto IL_7A2;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (254219 - 288106 != -33887)
							{
								continue;
							}
							goto IL_5B4;
						}
						else
						{
							this.$mStoryGui$46676 = (StoryGui)this.$self_$46679.GetComponent(typeof(StoryGui));
							if (202155 - 32772 != 169383)
							{
								continue;
							}
							this.$mStoryTimer$46677 = 0f;
							if (67581 - 359606 == -292024)
							{
								continue;
							}
							this.$mStoryGui$46676.startStoryMessage("Panther", "Panther", eTalkType.friend);
							if (220754 - 521568 != -300813)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (87219 - 572251 != -485031)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46676.newStoryMessage("Panther", "Panther", Language.getMessage("M973_PirateCave", 711), eTalkType.friend);
							if (157566 - 391370 == -233803)
							{
								continue;
							}
							this.$mStoryTimer$46677 = Time.time + 3f;
							if (17851 - 111799 != -93947)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 4:
						goto IL_560;
					case 5:
						goto IL_560;
					case 6:
						break;
					case 7:
						break;
					case 8:
						goto IL_4C4;
					case 9:
						goto IL_4C4;
					case 10:
						if (Game.mGameState != eGameState.Hold)
						{
							if (144748 - 533612 != -388864)
							{
								continue;
							}
							goto IL_427;
						}
						else
						{
							this.$mGameGui$46675.enabled = true;
							if (25150 - 170119 != -144969)
							{
								continue;
							}
							this.$self_$46679.PB8nqauwAY7.enabled = true;
							if (22277 - 428169 != -405892)
							{
								continue;
							}
							goto IL_766;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Hold)
						{
							if (280066 - 547778 != -267711)
							{
								goto Block_57;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (156714 - 314697 == -157982)
							{
								continue;
							}
							Game.sendMissionEvent(9732, 5);
							if (91796 - 66923 != 24873)
							{
								continue;
							}
							goto IL_102;
						}
						break;
					default:
						if (218564 - 228715 != -10151)
						{
							continue;
						}
						goto IL_58A;
					}
					if (this.$mStoryTimer$46677 > Time.time)
					{
						if (131420 - 389068 != -257648)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_688;
						}
						if (95177 - 24675 != 70502)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (252334 - 135588 != 116746)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$46676.newStoryMessage("Panther", "Panther", Language.getMessage("M973_PirateCave", 713), eTalkType.friend);
						if (5593 - 169617 == -164023)
						{
							continue;
						}
						this.$mStoryTimer$46677 = Time.time + 3f;
						if (70779 - 52288 != 18491)
						{
							continue;
						}
						goto IL_49C;
					}
					IL_560:
					if (this.$mStoryTimer$46677 > Time.time)
					{
						if (147466 - 405484 == -258017)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_554;
						}
						if (262368 - 40429 == 221940)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (188978 - 235383 != -46405)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$46676.newStoryMessage("Panther", "Panther", Language.getMessage("M973_PirateCave", 712), eTalkType.friend);
						if (191565 - 62425 == 129141)
						{
							continue;
						}
						this.$mStoryTimer$46677 = Time.time + 3f;
						if (220374 - 521428 != -301053)
						{
							goto Block_17;
						}
						continue;
					}
					IL_4C4:
					if (this.$mStoryTimer$46677 > Time.time)
					{
						if (271183 - 573105 != -301922)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4B7;
						}
						if (261489 - 299618 != -38129)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (41071 - 542123 != -501052)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mPanther$46678 = GameObject.Find("Panther");
						if (127217 - 104484 == 22734)
						{
							continue;
						}
						if (this.$mPanther$46678)
						{
							if (105214 - 178140 != -72926)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$mPanther$46678);
							if (120482 - 288713 != -168231)
							{
								continue;
							}
						}
						this.$mStoryGui$46676.close();
						if (268430 - 592836 != -324405)
						{
							goto Block_23;
						}
						continue;
					}
					IL_102:
					this.YieldDefault(1);
					if (62692 - 496125 != -433433)
					{
						continue;
					}
					break;
					IL_58A:
					if (this.$self_$46679.FhWnqCn9kU3)
					{
						goto IL_102;
					}
					if (167538 - 87360 == 80178)
					{
						this.$self_$46679.FhWnqCn9kU3 = true;
						if (70374 - 19610 == 50764)
						{
							Debug.Log("On Talk To Panther");
							if (294219 - 405182 != -110962)
							{
								Game.mGameState = eGameState.Hold;
								if (152943 - 563869 != -410925)
								{
									this.$mGameGui$46675 = (GameGui)this.$self_$46679.GetComponent(typeof(GameGui));
									if (165405 - 56152 != 109254)
									{
										if (!this.$mGameGui$46675)
										{
											goto IL_319;
										}
										if (102190 - 565420 != -463229)
										{
											this.$mGameGui$46675.close();
											if (55452 - 542691 != -487238)
											{
												goto Block_33;
											}
										}
									}
								}
							}
						}
					}
				}
				Block_13:
				goto IL_7A2;
				Block_14:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_16:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_17:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_319:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_23:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_427:
				goto IL_7A2;
				Block_33:
				goto IL_319;
				IL_49C:
				return this.Yield(8, new WaitForSeconds(0.5f));
				IL_4B7:
				return this.YieldDefault(9);
				IL_554:
				return this.YieldDefault(5);
				IL_5B4:
				goto IL_7A2;
				IL_688:
				return this.YieldDefault(7);
				goto IL_7A2;
				IL_766:
				return this.Yield(11, new WaitForSeconds(1f));
				Block_57:
				IL_7A2:
				return false;
			}

			// Token: 0x0600B94D RID: 47437 RVA: 0x013D2B6C File Offset: 0x013D0D6C
			internal static bool EVnPw6tcbLGTinsrYjSO()
			{
				return true;
			}

			// Token: 0x0600B94E RID: 47438 RVA: 0x013D2B70 File Offset: 0x013D0D70
			internal static bool VcDwLGtcuRj1welqKoBT()
			{
				return false;
			}

			// Token: 0x04009F8C RID: 40844
			internal GameGui $mGameGui$46675;

			// Token: 0x04009F8D RID: 40845
			internal StoryGui $mStoryGui$46676;

			// Token: 0x04009F8E RID: 40846
			internal float $mStoryTimer$46677;

			// Token: 0x04009F8F RID: 40847
			internal GameObject $mPanther$46678;

			// Token: 0x04009F90 RID: 40848
			internal M973_PirateCave7 $self_$46679;
		}
	}

	// Token: 0x02001EFB RID: 7931
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToHippo$46681 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B94F RID: 47439 RVA: 0x013D2B74 File Offset: 0x013D0D74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToHippo$46681(M973_PirateCave7 self_)
		{
			if (195300 - 153316 != 41984)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (83147 - 523798 == -440651)
				{
					base..ctor();
					if (36684 - 467013 == -430329)
					{
						this.$self_$46687 = self_;
						if (141122 - 21352 == 119770)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B950 RID: 47440 RVA: 0x013D2C0C File Offset: 0x013D0E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave7.$TalkToHippo$46681.$(this.$self_$46687);
		}

		// Token: 0x0600B951 RID: 47441 RVA: 0x013D2C1C File Offset: 0x013D0E1C
		internal static bool V16dd7tcIW0lgDbXfgMZ()
		{
			return true;
		}

		// Token: 0x0600B952 RID: 47442 RVA: 0x013D2C20 File Offset: 0x013D0E20
		internal static bool y1Ce6FtcB6x0TDqAIGBN()
		{
			return false;
		}

		// Token: 0x04009F91 RID: 40849
		internal M973_PirateCave7 $self_$46687;

		// Token: 0x02001EFC RID: 7932
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B953 RID: 47443 RVA: 0x013D2C24 File Offset: 0x013D0E24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave7 self_)
			{
				if (226317 - 466088 != -239771)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (176688 - 398061 != -221372)
					{
						base..ctor();
						if (281461 - 201699 == 79762)
						{
							this.$self_$46686 = self_;
							if (25899 - 348874 != -322974)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B954 RID: 47444 RVA: 0x013D2CBC File Offset: 0x013D0EBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (10692 - 259434 != -248742)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_367;
					case 1:
						goto IL_7A2;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (164352 - 431011 != -266659)
							{
								continue;
							}
							goto IL_109;
						}
						else
						{
							this.$mStoryGui$46683 = (StoryGui)this.$self_$46686.GetComponent(typeof(StoryGui));
							if (107216 - 105977 != 1239)
							{
								continue;
							}
							this.$mStoryTimer$46684 = 0f;
							if (9317 - 420592 != -411275)
							{
								continue;
							}
							this.$mStoryGui$46683.startStoryMessage("Hippo", "Hippo", eTalkType.friend);
							if (168145 - 46977 != 121169)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (38694 - 264288 != -225593)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46683.newStoryMessage("Hippo", "Hippo", Language.getMessage("M973_PirateCave", 721), eTalkType.friend);
							if (13222 - 31607 == -18384)
							{
								continue;
							}
							this.$mStoryTimer$46684 = Time.time + 3f;
							if (113598 - 111815 != 1784)
							{
								goto Block_57;
							}
							continue;
						}
						break;
					case 4:
						goto IL_3B8;
					case 5:
						goto IL_3B8;
					case 6:
						break;
					case 7:
						break;
					case 8:
						goto IL_1FB;
					case 9:
						goto IL_1FB;
					case 10:
						if (Game.mGameState != eGameState.Hold)
						{
							if (165730 - 133953 != 31777)
							{
								continue;
							}
							goto IL_317;
						}
						else
						{
							this.$mGameGui$46682.enabled = true;
							if (226570 - 108849 == 117722)
							{
								continue;
							}
							this.$self_$46686.PB8nqauwAY7.enabled = true;
							if (239540 - 421945 != -182404)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Hold)
						{
							if (22348 - 368985 != -346636)
							{
								goto Block_47;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (251476 - 198337 == 53140)
							{
								continue;
							}
							Game.sendMissionEvent(9732, 6);
							if (196620 - 484329 != -287709)
							{
								continue;
							}
							goto IL_69C;
						}
						break;
					default:
						if (41032 - 498683 != -457651)
						{
							continue;
						}
						goto IL_367;
					}
					if (this.$mStoryTimer$46684 > Time.time)
					{
						if (141261 - 261932 == -120670)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_456;
						}
						if (278795 - 479259 == -200463)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (85460 - 363574 != -278114)
						{
							continue;
						}
						goto IL_581;
					}
					else
					{
						this.$mStoryGui$46683.newStoryMessage("Hippo", "Hippo", Language.getMessage("M973_PirateCave", 723), eTalkType.friend);
						if (43569 - 12182 != 31387)
						{
							continue;
						}
						this.$mStoryTimer$46684 = Time.time + 3f;
						if (114596 - 100698 != 13898)
						{
							continue;
						}
						goto IL_1D3;
					}
					IL_1FB:
					if (this.$mStoryTimer$46684 > Time.time)
					{
						if (283062 - 452120 != -169058)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1EE;
						}
						if (217900 - 54922 == 162979)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (98669 - 234883 != -136214)
						{
							continue;
						}
						goto IL_40C;
					}
					else
					{
						this.$mHippo$46685 = GameObject.Find("Hippo");
						if (276142 - 101930 == 174213)
						{
							continue;
						}
						if (this.$mHippo$46685)
						{
							if (149937 - 425835 != -275898)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$mHippo$46685);
							if (243081 - 81590 == 161492)
							{
								continue;
							}
						}
						this.$mStoryGui$46683.close();
						if (145573 - 519092 != -373518)
						{
							goto Block_21;
						}
						continue;
					}
					IL_3B8:
					if (this.$mStoryTimer$46684 > Time.time)
					{
						if (30662 - 12068 != 18594)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3AC;
						}
						if (240844 - 313919 != -73075)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (280018 - 20319 != 259699)
						{
							continue;
						}
						goto IL_6E9;
					}
					else
					{
						this.$mStoryGui$46683.newStoryMessage("Hippo", "Hippo", Language.getMessage("M973_PirateCave", 722), eTalkType.friend);
						if (290255 - 303249 == -12993)
						{
							continue;
						}
						this.$mStoryTimer$46684 = Time.time + 3f;
						if (140834 - 574802 != -433968)
						{
							continue;
						}
						goto IL_43B;
					}
					IL_367:
					if (!this.$self_$46686.T7CnqM8ngMc)
					{
						if (192744 - 363152 == -170407)
						{
							continue;
						}
						this.$self_$46686.T7CnqM8ngMc = true;
						if (34173 - 275051 == -240877)
						{
							continue;
						}
						Debug.Log("On Talk To Hippo");
						if (275694 - 441628 == -165933)
						{
							continue;
						}
						Game.mGameState = eGameState.Hold;
						if (276295 - 46030 == 230266)
						{
							continue;
						}
						this.$mGameGui$46682 = (GameGui)this.$self_$46686.GetComponent(typeof(GameGui));
						if (194897 - 227290 != -32393)
						{
							continue;
						}
						if (!this.$mGameGui$46682)
						{
							goto IL_4C6;
						}
						if (2356 - 88367 == -86010)
						{
							continue;
						}
						this.$mGameGui$46682.close();
						if (19360 - 13905 != 5455)
						{
							continue;
						}
						goto IL_4C6;
					}
					IL_69C:
					this.YieldDefault(1);
					if (77589 - 389936 != -312346)
					{
						goto Block_51;
					}
				}
				Block_3:
				return this.Yield(11, new WaitForSeconds(1f));
				IL_109:
				goto IL_7A2;
				IL_1D3:
				return this.Yield(8, new WaitForSeconds(0.5f));
				IL_1EE:
				return this.YieldDefault(9);
				Block_21:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_317:
				goto IL_7A2;
				IL_3AC:
				return this.YieldDefault(5);
				IL_40C:
				goto IL_7A2;
				IL_43B:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_456:
				return this.YieldDefault(7);
				IL_4C6:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_44:
				IL_581:
				Block_47:
				goto IL_7A2;
				Block_48:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_51:
				IL_6E9:
				goto IL_7A2;
				Block_57:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_7A2:
				return false;
			}

			// Token: 0x0600B955 RID: 47445 RVA: 0x013D3480 File Offset: 0x013D1680
			internal static bool qxlTCHtceWbGNwjwBviC()
			{
				return true;
			}

			// Token: 0x0600B956 RID: 47446 RVA: 0x013D3484 File Offset: 0x013D1684
			internal static bool JT54GDtcrMfT0eTbr91F()
			{
				return false;
			}

			// Token: 0x04009F92 RID: 40850
			internal GameGui $mGameGui$46682;

			// Token: 0x04009F93 RID: 40851
			internal StoryGui $mStoryGui$46683;

			// Token: 0x04009F94 RID: 40852
			internal float $mStoryTimer$46684;

			// Token: 0x04009F95 RID: 40853
			internal GameObject $mHippo$46685;

			// Token: 0x04009F96 RID: 40854
			internal M973_PirateCave7 $self_$46686;
		}
	}

	// Token: 0x02001EFD RID: 7933
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$46688 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B957 RID: 47447 RVA: 0x013D3488 File Offset: 0x013D1688
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$46688(M973_PirateCave7 self_)
		{
			if (163753 - 393423 != -229669)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (201860 - 455984 != -254123)
				{
					base..ctor();
					if (203863 - 20433 == 183430)
					{
						this.$self_$46691 = self_;
						if (285955 - 555595 == -269640)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B958 RID: 47448 RVA: 0x013D3520 File Offset: 0x013D1720
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave7.$StartGame$46688.$(this.$self_$46691);
		}

		// Token: 0x0600B959 RID: 47449 RVA: 0x013D3530 File Offset: 0x013D1730
		internal static bool SCcoxbtcjfnuLGlW5BBD()
		{
			return true;
		}

		// Token: 0x0600B95A RID: 47450 RVA: 0x013D3534 File Offset: 0x013D1734
		internal static bool yY4RMMtchbkWPRHs0eVF()
		{
			return false;
		}

		// Token: 0x04009F97 RID: 40855
		internal M973_PirateCave7 $self_$46691;

		// Token: 0x02001EFE RID: 7934
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B95B RID: 47451 RVA: 0x013D3538 File Offset: 0x013D1738
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave7 self_)
			{
				if (133526 - 134061 != -535)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240201 - 130410 == 109791)
					{
						base..ctor();
						if (176181 - 366548 == -190367)
						{
							this.$self_$46690 = self_;
							if (162164 - 392577 == -230413)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B95C RID: 47452 RVA: 0x013D35D0 File Offset: 0x013D17D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (180449 - 310388 != -129938)
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
						if (79623 - 65643 != 13980)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (23087 - 454229 != -431142)
						{
							continue;
						}
						this.YieldDefault(1);
						if (183789 - 48019 != 135770)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (196860 - 525819 != -328959)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (189134 - 525878 != -336743)
					{
						Game.mGameState = eGameState.Start;
						if (141649 - 565123 == -423474)
						{
							Game.mStateTime = Time.time;
							if (34296 - 363757 == -329461)
							{
								this.$mGameGui$46689 = (GameGui)this.$self_$46690.GetComponent(typeof(GameGui));
								if (59645 - 35003 == 24642)
								{
									this.$mGameGui$46689.enabled = true;
									if (9097 - 60687 != -51589)
									{
										this.$self_$46690.SendMessage("fadeIn");
										if (205069 - 418678 != -213608)
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

			// Token: 0x0600B95D RID: 47453 RVA: 0x013D37A8 File Offset: 0x013D19A8
			internal static bool hQpkyUtcslbyQpEGNwMq()
			{
				return true;
			}

			// Token: 0x0600B95E RID: 47454 RVA: 0x013D37AC File Offset: 0x013D19AC
			internal static bool BDxckytc9XPltscKFYFS()
			{
				return false;
			}

			// Token: 0x04009F98 RID: 40856
			internal GameGui $mGameGui$46689;

			// Token: 0x04009F99 RID: 40857
			internal M973_PirateCave7 $self_$46690;
		}
	}

	// Token: 0x02001EFF RID: 7935
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46692 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B95F RID: 47455 RVA: 0x013D37B0 File Offset: 0x013D19B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46692(M973_PirateCave7 self_)
		{
			if (175837 - 374608 != -198771)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (202215 - 212682 == -10467)
				{
					base..ctor();
					if (32210 - 456375 != -424164)
					{
						this.$self_$46697 = self_;
						if (23549 - 557468 != -533918)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B960 RID: 47456 RVA: 0x013D3848 File Offset: 0x013D1A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave7.$onDeadPlayer$46692.$(this.$self_$46697);
		}

		// Token: 0x0600B961 RID: 47457 RVA: 0x013D3858 File Offset: 0x013D1A58
		internal static bool LM8Pudtc1leBQmUnJukd()
		{
			return true;
		}

		// Token: 0x0600B962 RID: 47458 RVA: 0x013D385C File Offset: 0x013D1A5C
		internal static bool SbNZ2Jtc4RylGiptQ5NB()
		{
			return false;
		}

		// Token: 0x04009F9A RID: 40858
		internal M973_PirateCave7 $self_$46697;

		// Token: 0x02001F00 RID: 7936
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B963 RID: 47459 RVA: 0x013D3860 File Offset: 0x013D1A60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave7 self_)
			{
				if (85781 - 231073 != -145291)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (136128 - 389708 != -253579)
					{
						base..ctor();
						if (280428 - 503512 != -223083)
						{
							this.$self_$46696 = self_;
							if (164841 - 4281 != 160561)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B964 RID: 47460 RVA: 0x013D38F8 File Offset: 0x013D1AF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (135193 - 5266 != 129927)
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
							goto IL_100;
						}
						if (204463 - 105131 != 99332)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (118841 - 12014 != 106827)
							{
								continue;
							}
							goto IL_100;
						}
						IL_B9:
						this.YieldDefault(1);
						if (161306 - 163492 != -2185)
						{
							goto Block_9;
						}
						continue;
						IL_100:
						Game.mGameState = eGameState.Hold;
						if (122686 - 167896 != -45210)
						{
							continue;
						}
						this.$mStoryGui$46693 = (StoryGui)this.$self_$46696.GetComponent(typeof(StoryGui));
						if (97646 - 414156 == -316509)
						{
							continue;
						}
						if (this.$mStoryGui$46693)
						{
							if (241915 - 13817 != 228098)
							{
								continue;
							}
							this.$mStoryGui$46693.close();
							if (199678 - 66102 == 133577)
							{
								continue;
							}
						}
						this.$mChangeGui$46694 = (ChangeGui)this.$self_$46696.GetComponent(typeof(ChangeGui));
						if (241673 - 154358 == 87316)
						{
							continue;
						}
						if (this.$mChangeGui$46694)
						{
							if (181959 - 314302 != -132343)
							{
								continue;
							}
							this.$mChangeGui$46694.close();
							if (246121 - 237755 == 8367)
							{
								continue;
							}
						}
						this.$mGameGui$46695 = (GameGui)this.$self_$46696.GetComponent(typeof(GameGui));
						if (287869 - 51599 == 236271)
						{
							continue;
						}
						if (!this.$mGameGui$46695)
						{
							goto IL_B9;
						}
						if (193671 - 225261 != -31590)
						{
							continue;
						}
						if (!this.$mGameGui$46695.enabled)
						{
							if (246228 - 202534 == 43695)
							{
								continue;
							}
							this.$mGameGui$46695.enabled = true;
							if (272160 - 488224 != -216064)
							{
								continue;
							}
						}
						this.$mGameGui$46695.openDeadMenu();
						if (245670 - 476076 != -230406)
						{
							continue;
						}
						goto IL_B9;
					default:
						if (218592 - 81929 == 136664)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (169054 - 245462 == -76408)
					{
						goto IL_228;
					}
				}
				Block_9:
				goto IL_2F9;
				IL_228:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B965 RID: 47461 RVA: 0x013D3C10 File Offset: 0x013D1E10
			internal static bool mt1gvxtczSD6Ch9tAPo9()
			{
				return true;
			}

			// Token: 0x0600B966 RID: 47462 RVA: 0x013D3C14 File Offset: 0x013D1E14
			internal static bool u2B0AjtUa8RHyCicZMfX()
			{
				return false;
			}

			// Token: 0x04009F9B RID: 40859
			internal StoryGui $mStoryGui$46693;

			// Token: 0x04009F9C RID: 40860
			internal ChangeGui $mChangeGui$46694;

			// Token: 0x04009F9D RID: 40861
			internal GameGui $mGameGui$46695;

			// Token: 0x04009F9E RID: 40862
			internal M973_PirateCave7 $self_$46696;
		}
	}

	// Token: 0x02001F01 RID: 7937
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46698 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B967 RID: 47463 RVA: 0x013D3C18 File Offset: 0x013D1E18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46698(Hashtable data, M973_PirateCave7 self_)
		{
			if (190077 - 476109 != -286032)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193761 - 373360 != -179598)
				{
					base..ctor();
					if (230983 - 522319 != -291335)
					{
						this.$data$46703 = data;
						if (156801 - 359965 != -203163)
						{
							this.$self_$46704 = self_;
							if (27248 - 592819 == -565571)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B968 RID: 47464 RVA: 0x013D3CD4 File Offset: 0x013D1ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave7.$onChangePlayer$46698.$(this.$data$46703, this.$self_$46704);
		}

		// Token: 0x0600B969 RID: 47465 RVA: 0x013D3CE8 File Offset: 0x013D1EE8
		internal static bool pOYpCdtU5BjwftDZ08aj()
		{
			return true;
		}

		// Token: 0x0600B96A RID: 47466 RVA: 0x013D3CEC File Offset: 0x013D1EEC
		internal static bool S6IGd5tUptkTeTYpZrsv()
		{
			return false;
		}

		// Token: 0x04009F9F RID: 40863
		internal Hashtable $data$46703;

		// Token: 0x04009FA0 RID: 40864
		internal M973_PirateCave7 $self_$46704;

		// Token: 0x02001F02 RID: 7938
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B96B RID: 47467 RVA: 0x013D3CF0 File Offset: 0x013D1EF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave7 self_)
			{
				if (98921 - 29392 != 69530)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14913 - 49063 == -34150)
					{
						base..ctor();
						if (268799 - 90157 != 178643)
						{
							this.$data$46701 = data;
							if (18259 - 549240 != -530980)
							{
								this.$self_$46702 = self_;
								if (85533 - 529043 != -443509)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B96C RID: 47468 RVA: 0x013D3DAC File Offset: 0x013D1FAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (141049 - 331101 != -190052)
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
							if (9064 - 271152 != -262088)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (28582 - 595727 != -567145)
							{
								continue;
							}
							this.$mGameGui$46700 = (GameGui)this.$self_$46702.GetComponent(typeof(GameGui));
							if (152582 - 436327 == -283744)
							{
								continue;
							}
							this.$mGameGui$46700.enabled = true;
							if (219995 - 362658 == -142662)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (148884 - 40175 != 108710)
						{
							goto Block_12;
						}
						continue;
					default:
						if (99449 - 474255 != -374806)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (180222 - 86048 != 94175)
					{
						this.$self_$46702.SendMessage("onCreatePlayer", this.$data$46701);
						if (85638 - 301575 != -215936)
						{
							this.$mChangeGui$46699 = (ChangeGui)this.$self_$46702.GetComponent(typeof(ChangeGui));
							if (196658 - 186513 != 10146)
							{
								if (!this.$mChangeGui$46699.enabled)
								{
									break;
								}
								if (78764 - 231135 == -152371)
								{
									this.$mChangeGui$46699.close();
									if (192746 - 198594 == -5848)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_12:
				IL_205:
				return false;
			}

			// Token: 0x0600B96D RID: 47469 RVA: 0x013D3FD0 File Offset: 0x013D21D0
			internal static bool Xa3cwQtUVSqdHGo5MQL0()
			{
				return true;
			}

			// Token: 0x0600B96E RID: 47470 RVA: 0x013D3FD4 File Offset: 0x013D21D4
			internal static bool w4AoNqtUtVwF1scAjufw()
			{
				return false;
			}

			// Token: 0x04009FA1 RID: 40865
			internal ChangeGui $mChangeGui$46699;

			// Token: 0x04009FA2 RID: 40866
			internal GameGui $mGameGui$46700;

			// Token: 0x04009FA3 RID: 40867
			internal Hashtable $data$46701;

			// Token: 0x04009FA4 RID: 40868
			internal M973_PirateCave7 $self_$46702;
		}
	}

	// Token: 0x02001F03 RID: 7939
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46705 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B96F RID: 47471 RVA: 0x013D3FD8 File Offset: 0x013D21D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46705(Hashtable data, M973_PirateCave7 self_)
		{
			if (100720 - 463332 != -362611)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (31881 - 514442 != -482560)
				{
					base..ctor();
					if (232126 - 283912 == -51786)
					{
						this.$data$46713 = data;
						if (120067 - 15525 != 104543)
						{
							this.$self_$46714 = self_;
							if (284728 - 143317 != 141412)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B970 RID: 47472 RVA: 0x013D4094 File Offset: 0x013D2294
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave7.$onGameComplete$46705.$(this.$data$46713, this.$self_$46714);
		}

		// Token: 0x0600B971 RID: 47473 RVA: 0x013D40A8 File Offset: 0x013D22A8
		internal static bool GXwYwstUNN2SNp34Op2k()
		{
			return true;
		}

		// Token: 0x0600B972 RID: 47474 RVA: 0x013D40AC File Offset: 0x013D22AC
		internal static bool JmpeWgtUYyUgQVlWoAFd()
		{
			return false;
		}

		// Token: 0x04009FA5 RID: 40869
		internal Hashtable $data$46713;

		// Token: 0x04009FA6 RID: 40870
		internal M973_PirateCave7 $self_$46714;

		// Token: 0x02001F04 RID: 7940
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B973 RID: 47475 RVA: 0x013D40B0 File Offset: 0x013D22B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave7 self_)
			{
				if (149184 - 433789 != -284604)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60627 - 83019 != -22391)
					{
						base..ctor();
						if (189107 - 265813 != -76705)
						{
							this.$data$46711 = data;
							if (159739 - 489302 != -329562)
							{
								this.$self_$46712 = self_;
								if (169018 - 234416 == -65398)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B974 RID: 47476 RVA: 0x013D416C File Offset: 0x013D236C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (8933 - 252272 != -243338)
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
						this.$mCompleteGui$46707 = (CompleteGui)this.$self_$46712.GetComponent(typeof(CompleteGui));
						if (287693 - 415437 != -127744)
						{
							continue;
						}
						this.$mCompleteGui$46707.Init();
						if (28192 - 41163 != -12971)
						{
							continue;
						}
						this.$mCompleteGui$46707.readData(this.$data$46711);
						if (250362 - 439184 != -188822)
						{
							continue;
						}
						if (this.$result$46706 == 1)
						{
							if (289518 - 17598 == 271921)
							{
								continue;
							}
							this.$mCompleteGui$46707.displayResult(eCompleteType.Success);
							if (297815 - 283147 != 14668)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46707.displayResult(eCompleteType.Failed);
							if (229497 - 97006 == 132492)
							{
								continue;
							}
						}
						this.$mGameGui$46708 = (GameGui)this.$self_$46712.GetComponent(typeof(GameGui));
						if (180657 - 555963 == -375305)
						{
							continue;
						}
						this.$mStoryGui$46709 = (StoryGui)this.$self_$46712.GetComponent(typeof(StoryGui));
						if (112237 - 328804 != -216567)
						{
							continue;
						}
						this.$mChangeGui$46710 = (ChangeGui)this.$self_$46712.GetComponent(typeof(ChangeGui));
						if (175075 - 595962 != -420887)
						{
							continue;
						}
						if (this.$mGameGui$46708)
						{
							if (138946 - 481405 == -342458)
							{
								continue;
							}
							this.$mGameGui$46708.close();
							if (128611 - 341423 == -212811)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46709)
						{
							if (190336 - 118837 == 71500)
							{
								continue;
							}
							this.$mStoryGui$46709.close();
							if (31346 - 538810 != -507464)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46710)
						{
							if (61903 - 494471 == -432567)
							{
								continue;
							}
							this.$mChangeGui$46710.disable();
							if (51214 - 315945 == -264730)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (68304 - 334621 != -266317)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (16892 - 573225 != -556333)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46711[31]);
					if (67939 - 243711 == -175772)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (65957 - 478934 != -412976)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (285158 - 336476 != -51317)
							{
								this.$result$46706 = RuntimeServices.UnboxInt32(this.$data$46711[31]);
								if (282964 - 403975 == -121011)
								{
									goto IL_24B;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_24B:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600B975 RID: 47477 RVA: 0x013D4568 File Offset: 0x013D2768
			internal static bool mKHgtgtUcwLEnlOwtBRH()
			{
				return true;
			}

			// Token: 0x0600B976 RID: 47478 RVA: 0x013D456C File Offset: 0x013D276C
			internal static bool PYDQa7tUUC83mEoe2exw()
			{
				return false;
			}

			// Token: 0x04009FA7 RID: 40871
			internal int $result$46706;

			// Token: 0x04009FA8 RID: 40872
			internal CompleteGui $mCompleteGui$46707;

			// Token: 0x04009FA9 RID: 40873
			internal GameGui $mGameGui$46708;

			// Token: 0x04009FAA RID: 40874
			internal StoryGui $mStoryGui$46709;

			// Token: 0x04009FAB RID: 40875
			internal ChangeGui $mChangeGui$46710;

			// Token: 0x04009FAC RID: 40876
			internal Hashtable $data$46711;

			// Token: 0x04009FAD RID: 40877
			internal M973_PirateCave7 $self_$46712;
		}
	}

	// Token: 0x02001F05 RID: 7941
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46715 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B977 RID: 47479 RVA: 0x013D4570 File Offset: 0x013D2770
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46715(M973_PirateCave7 self_)
		{
			if (13366 - 104528 != -91162)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227099 - 325497 != -98397)
				{
					base..ctor();
					if (95991 - 462597 != -366605)
					{
						this.$self_$46719 = self_;
						if (18632 - 45446 != -26813)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B978 RID: 47480 RVA: 0x013D4608 File Offset: 0x013D2808
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave7.$ReturnToTown$46715.$(this.$self_$46719);
		}

		// Token: 0x0600B979 RID: 47481 RVA: 0x013D4618 File Offset: 0x013D2818
		internal static bool vYTD4JtUTptU26KaQMY4()
		{
			return true;
		}

		// Token: 0x0600B97A RID: 47482 RVA: 0x013D461C File Offset: 0x013D281C
		internal static bool CrRorytU3SHXE4I4HsEU()
		{
			return false;
		}

		// Token: 0x04009FAE RID: 40878
		internal M973_PirateCave7 $self_$46719;

		// Token: 0x02001F06 RID: 7942
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B97B RID: 47483 RVA: 0x013D4620 File Offset: 0x013D2820
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave7 self_)
			{
				if (13077 - 566794 != -553717)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (155098 - 469038 == -313940)
					{
						base..ctor();
						if (232936 - 336664 == -103728)
						{
							this.$self_$46718 = self_;
							if (86082 - 382557 == -296475)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B97C RID: 47484 RVA: 0x013D46B8 File Offset: 0x013D28B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (23052 - 111944 != -88891)
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
						this.$self_$46718.LeaveGame();
						if (81973 - 498380 == -416406)
						{
							continue;
						}
						this.YieldDefault(1);
						if (192028 - 294406 != -102377)
						{
							goto Block_20;
						}
						continue;
					default:
						if (121385 - 100753 != 20632)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (54320 - 526524 != -472203)
					{
						Game.mStateTime = Time.time;
						if (203196 - 188348 != 14849)
						{
							this.$$switch$8713$46716 = PlayerData.SaveGuild;
							if (103899 - 493552 == -389653)
							{
								if (this.$$switch$8713$46716 == 1)
								{
									if (259891 - 483187 == -223295)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (96731 - 445832 != -349101)
									{
										continue;
									}
								}
								else if (this.$$switch$8713$46716 == 2)
								{
									if (210593 - 433173 == -222579)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (219790 - 410124 != -190334)
									{
										continue;
									}
								}
								else if (this.$$switch$8713$46716 == 3)
								{
									if (102827 - 369398 != -266571)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (59333 - 366462 != -307129)
									{
										continue;
									}
								}
								else if (this.$$switch$8713$46716 == 4)
								{
									if (264156 - 524375 != -260219)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (91824 - 528361 != -436537)
									{
										continue;
									}
								}
								else if (this.$$switch$8713$46716 == 5)
								{
									if (153320 - 52580 != 100740)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (91681 - 241175 != -149494)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (283419 - 224132 == 59288)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (38482 - 74416 == -35933)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (119530 - 566836 == -447305)
									{
										continue;
									}
								}
								this.$mGameGui$46717 = (GameGui)this.$self_$46718.GetComponent(typeof(GameGui));
								if (229489 - 207006 == 22483)
								{
									if (this.$mGameGui$46717)
									{
										if (65122 - 194825 == -129702)
										{
											continue;
										}
										this.$mGameGui$46717.close();
										if (201880 - 25675 != 176205)
										{
											continue;
										}
									}
									this.$self_$46718.SendMessage("fadeOut");
									if (143689 - 588954 != -445264)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_20:
				IL_3AD:
				return false;
			}

			// Token: 0x0600B97D RID: 47485 RVA: 0x013D4A84 File Offset: 0x013D2C84
			internal static bool MoEui3tUXdndUwKWj1Kk()
			{
				return true;
			}

			// Token: 0x0600B97E RID: 47486 RVA: 0x013D4A88 File Offset: 0x013D2C88
			internal static bool hJrLyltUQF065jMUy9RE()
			{
				return false;
			}

			// Token: 0x04009FAF RID: 40879
			internal int $$switch$8713$46716;

			// Token: 0x04009FB0 RID: 40880
			internal GameGui $mGameGui$46717;

			// Token: 0x04009FB1 RID: 40881
			internal M973_PirateCave7 $self_$46718;
		}
	}

	// Token: 0x02001F07 RID: 7943
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46720 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B97F RID: 47487 RVA: 0x013D4A8C File Offset: 0x013D2C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46720(M973_PirateCave7 self_)
		{
			if (206329 - 316226 != -109896)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (83790 - 291146 == -207356)
				{
					base..ctor();
					if (84550 - 28880 == 55670)
					{
						this.$self_$46723 = self_;
						if (63733 - 180916 == -117183)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B980 RID: 47488 RVA: 0x013D4B24 File Offset: 0x013D2D24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave7.$ReturnToGuild$46720.$(this.$self_$46723);
		}

		// Token: 0x0600B981 RID: 47489 RVA: 0x013D4B34 File Offset: 0x013D2D34
		internal static bool KjxQt5tUkC6KpdT9vnNd()
		{
			return true;
		}

		// Token: 0x0600B982 RID: 47490 RVA: 0x013D4B38 File Offset: 0x013D2D38
		internal static bool pw03natUGYwthkykbQIS()
		{
			return false;
		}

		// Token: 0x04009FB2 RID: 40882
		internal M973_PirateCave7 $self_$46723;

		// Token: 0x02001F08 RID: 7944
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B983 RID: 47491 RVA: 0x013D4B3C File Offset: 0x013D2D3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave7 self_)
			{
				if (150531 - 86085 != 64447)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (16875 - 109393 == -92518)
					{
						base..ctor();
						if (282589 - 477044 == -194455)
						{
							this.$self_$46722 = self_;
							if (250212 - 4591 == 245621)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B984 RID: 47492 RVA: 0x013D4BD4 File Offset: 0x013D2DD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (85807 - 417994 != -332186)
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
						this.$self_$46722.LeaveGame();
						if (225563 - 490104 == -264540)
						{
							continue;
						}
						this.YieldDefault(1);
						if (252318 - 485066 != -232747)
						{
							goto IL_1BD;
						}
						continue;
					default:
						if (185226 - 37891 == 147336)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (243013 - 100576 != 142438)
					{
						Game.mStateTime = Time.time;
						if (268606 - 495397 != -226790)
						{
							Game.mNextGameCode = 31;
							if (212035 - 598095 == -386060)
							{
								this.$mGameGui$46721 = (GameGui)this.$self_$46722.GetComponent(typeof(GameGui));
								if (252735 - 66502 == 186233)
								{
									if (this.$mGameGui$46721)
									{
										if (59535 - 417332 != -357797)
										{
											continue;
										}
										this.$mGameGui$46721.close();
										if (73502 - 227777 == -154274)
										{
											continue;
										}
									}
									this.$self_$46722.SendMessage("fadeOut");
									if (250600 - 107722 == 142878)
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

			// Token: 0x0600B985 RID: 47493 RVA: 0x013D4DB0 File Offset: 0x013D2FB0
			internal static bool Enl0w9tUH8Cw3G7QanaQ()
			{
				return true;
			}

			// Token: 0x0600B986 RID: 47494 RVA: 0x013D4DB4 File Offset: 0x013D2FB4
			internal static bool muRvgUtUWgJcS17taaRQ()
			{
				return false;
			}

			// Token: 0x04009FB3 RID: 40883
			internal GameGui $mGameGui$46721;

			// Token: 0x04009FB4 RID: 40884
			internal M973_PirateCave7 $self_$46722;
		}
	}

	// Token: 0x02001F09 RID: 7945
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46724 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B987 RID: 47495 RVA: 0x013D4DB8 File Offset: 0x013D2FB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46724(M973_PirateCave7 self_)
		{
			if (53567 - 400587 != -347020)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (236736 - 203746 != 32991)
				{
					base..ctor();
					if (191100 - 279684 == -88584)
					{
						this.$self_$46727 = self_;
						if (238527 - 594780 != -356252)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B988 RID: 47496 RVA: 0x013D4E50 File Offset: 0x013D3050
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave7.$ReturnToCamp$46724.$(this.$self_$46727);
		}

		// Token: 0x0600B989 RID: 47497 RVA: 0x013D4E60 File Offset: 0x013D3060
		internal static bool yPhMmOtUA8NqjK6XkJiu()
		{
			return true;
		}

		// Token: 0x0600B98A RID: 47498 RVA: 0x013D4E64 File Offset: 0x013D3064
		internal static bool GGxHurtUlHMXlumVdotp()
		{
			return false;
		}

		// Token: 0x04009FB5 RID: 40885
		internal M973_PirateCave7 $self_$46727;

		// Token: 0x02001F0A RID: 7946
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B98B RID: 47499 RVA: 0x013D4E68 File Offset: 0x013D3068
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave7 self_)
			{
				if (224996 - 96069 != 128927)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (42788 - 229901 == -187113)
					{
						base..ctor();
						if (27673 - 97279 == -69606)
						{
							this.$self_$46726 = self_;
							if (80277 - 434003 == -353726)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B98C RID: 47500 RVA: 0x013D4F00 File Offset: 0x013D3100
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (169668 - 143782 != 25886)
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
						this.$self_$46726.LeaveGame();
						if (52168 - 553032 == -500863)
						{
							continue;
						}
						this.YieldDefault(1);
						if (203840 - 381568 != -177727)
						{
							goto Block_2;
						}
						continue;
					default:
						if (41680 - 579733 != -538053)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (291449 - 187975 != 103475)
					{
						Game.mStateTime = Time.time;
						if (28482 - 154308 != -125825)
						{
							Game.mNextGameCode = 33;
							if (77928 - 98704 == -20776)
							{
								this.$mGameGui$46725 = (GameGui)this.$self_$46726.GetComponent(typeof(GameGui));
								if (45795 - 356281 == -310486)
								{
									if (this.$mGameGui$46725)
									{
										if (114668 - 541829 == -427160)
										{
											continue;
										}
										this.$mGameGui$46725.close();
										if (223496 - 45483 == 178014)
										{
											continue;
										}
									}
									this.$self_$46726.SendMessage("fadeOut");
									if (4799 - 17742 == -12943)
									{
										goto IL_13B;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				IL_13B:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600B98D RID: 47501 RVA: 0x013D50DC File Offset: 0x013D32DC
			internal static bool ticQWctUyDnoVebBKRYn()
			{
				return true;
			}

			// Token: 0x0600B98E RID: 47502 RVA: 0x013D50E0 File Offset: 0x013D32E0
			internal static bool KjTrXatUSSyYEnjLenbW()
			{
				return false;
			}

			// Token: 0x04009FB6 RID: 40886
			internal GameGui $mGameGui$46725;

			// Token: 0x04009FB7 RID: 40887
			internal M973_PirateCave7 $self_$46726;
		}
	}
}
