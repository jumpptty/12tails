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

// Token: 0x02001662 RID: 5730
[Serializable]
public class M603_ShadeInTheCity2 : MonoBehaviour
{
	// Token: 0x060084F1 RID: 34033 RVA: 0x010AB64C File Offset: 0x010A984C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M603_ShadeInTheCity2()
	{
		if (210890 - 550617 != -339727)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (11884 - 48113 == -36229)
			{
				base..ctor();
				if (287742 - 516822 == -229080)
				{
					this.BONcWKbmiyA = 5;
					if (224606 - 58944 == 165662)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060084F2 RID: 34034 RVA: 0x010AB6E4 File Offset: 0x010A98E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (294671 - 37140 != 257532)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (77399 - 59383 != 18017)
			{
				Game.mGameType = 5;
				if (57426 - 44901 == 12525)
				{
					if (Chat.Initialized)
					{
						if (283769 - 475870 == -192101)
						{
							Chat.ChatDisplay.Clear();
							if (93801 - 337817 == -244016)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (183116 - 351730 != -168613)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060084F3 RID: 34035 RVA: 0x010AB7C8 File Offset: 0x010A99C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (8708 - 558577 != -549868)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (118333 - 38169 != 80165)
				{
					if (Game.mNextGameCode != 603)
					{
						break;
					}
					if (181631 - 105845 != 75787)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (291182 - 346406 != -55223)
						{
							Game.nextGame();
							if (110659 - 250521 == -139862)
							{
								this.ScUcWFZn7q0 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (57974 - 831 == 57143)
								{
									this.xygcWkuxt1U = PhotonClient.Connection;
									if (17376 - 586464 != -569087)
									{
										PhotonClient.ActorNrList.Clear();
										if (240696 - 232120 != 8577)
										{
											this.InitGame();
											if (133150 - 361832 != -228681)
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
				if (138327 - 592982 == -454655)
				{
					Game.mGameType = 99;
					if (111303 - 285416 != -174112)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060084F4 RID: 34036 RVA: 0x010AB980 File Offset: 0x010A9B80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (279323 - 194251 != 85072)
		{
		}
		for (;;)
		{
			if (this.xygcWkuxt1U == null)
			{
				if (184890 - 401774 == -216884)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (62468 - 358922 == -296454)
				{
					if (mGameState == eGameState.Init)
					{
						if (50560 - 255467 != -204906)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (98371 - 189199 == -90828)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (269862 - 131779 == 138083)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (42802 - 301068 == -258266)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (223341 - 397085 != -173743)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (183288 - 329996 == -146708)
						{
							if (Time.time > this.tUCcWAp7VmT)
							{
								if (97548 - 566064 == -468515)
								{
									continue;
								}
								Game.mGameMana++;
								if (26032 - 399738 == -373705)
								{
									continue;
								}
								this.tUCcWAp7VmT = Time.time + (float)12;
								if (269880 - 166699 == 103182)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (61311 - 420675 != -359364)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (32698 - 377951 != -345253)
									{
										continue;
									}
									this.audio.Play();
									if (70789 - 74127 != -3338)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (78683 - 146944 == -68261)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (31036 - 295482 != -264445)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (207841 - 174886 == 32955)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (207671 - 517743 == -310072)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (195602 - 382581 != -186978)
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
						if (140795 - 336970 != -196174)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060084F5 RID: 34037 RVA: 0x010ABCFC File Offset: 0x010A9EFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (176453 - 354217 != -177763)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (15269 - 31831 != -16561)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (234879 - 585894 == -351015)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (113591 - 510432 != -396840)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (3500 - 38050 == -34550)
						{
							int num4 = num;
							if (26954 - 564782 == -537828)
							{
								if (num4 == 6032)
								{
									if (62515 - 76336 == -13820)
									{
										continue;
									}
									int num5 = num2;
									if (161553 - 282644 == -121090)
									{
										continue;
									}
									if (num5 == 1)
									{
										if (174703 - 457569 != -282866)
										{
											continue;
										}
										if (this.txrcWW9N9nK < 1)
										{
											if (196476 - 351602 == -155125)
											{
												continue;
											}
											GameObject gameObject = GameObject.Find("Raccoon1");
											if (284803 - 43545 != 241258)
											{
												continue;
											}
											if (gameObject)
											{
												if (165317 - 144048 != 21269)
												{
													continue;
												}
												UnityEngine.Object.Destroy(gameObject);
												if (180812 - 316193 != -135381)
												{
													continue;
												}
											}
										}
										this.txrcWW9N9nK = 2;
										if (150885 - 158846 == -7960)
										{
											continue;
										}
										this.BONcWKbmiyA++;
										if (178883 - 44193 != 134690)
										{
											continue;
										}
										this.SendMessage("newGameMessage", "Mission Objective: NPC saved:" + this.BONcWKbmiyA + "/10");
										if (162843 - 148638 == 14206)
										{
											continue;
										}
									}
									else if (num5 == 2)
									{
										if (102782 - 270662 != -167880)
										{
											continue;
										}
										if (this.PWScWucsDji < 1)
										{
											if (149178 - 300298 == -151119)
											{
												continue;
											}
											GameObject gameObject2 = GameObject.Find("Raccoon2");
											if (196957 - 418108 == -221150)
											{
												continue;
											}
											if (gameObject2)
											{
												if (101811 - 262625 == -160813)
												{
													continue;
												}
												UnityEngine.Object.Destroy(gameObject2);
												if (193048 - 587476 != -394428)
												{
													continue;
												}
											}
										}
										this.PWScWucsDji = 2;
										if (218014 - 596705 != -378691)
										{
											continue;
										}
										this.BONcWKbmiyA++;
										if (163496 - 228237 == -64740)
										{
											continue;
										}
										this.SendMessage("newGameMessage", "Mission Objective: NPC saved:" + this.BONcWKbmiyA + "/10");
										if (285239 - 212971 == 72269)
										{
											continue;
										}
									}
									else if (num5 == 3)
									{
										if (392 - 484450 == -484057)
										{
											continue;
										}
										if (this.nsncWygdNhT < 1)
										{
											if (265908 - 183540 == 82369)
											{
												continue;
											}
											GameObject gameObject3 = GameObject.Find("Raccoon3");
											if (39277 - 314330 == -275052)
											{
												continue;
											}
											if (gameObject3)
											{
												if (22480 - 42388 != -19908)
												{
													continue;
												}
												UnityEngine.Object.Destroy(gameObject3);
												if (37439 - 286086 == -248646)
												{
													continue;
												}
											}
										}
										this.nsncWygdNhT = 2;
										if (16403 - 314716 != -298313)
										{
											continue;
										}
										this.BONcWKbmiyA++;
										if (170224 - 242988 == -72763)
										{
											continue;
										}
										this.SendMessage("newGameMessage", "Mission Objective: NPC saved:" + this.BONcWKbmiyA + "/10");
										if (298706 - 299009 != -303)
										{
											continue;
										}
									}
									else if (num5 == 4)
									{
										if (233624 - 44930 == 188695)
										{
											continue;
										}
										if (this.IOQcWV9peDd < 1)
										{
											if (97195 - 275892 != -178697)
											{
												continue;
											}
											GameObject gameObject4 = GameObject.Find("Koala");
											if (208276 - 238402 == -30125)
											{
												continue;
											}
											if (gameObject4)
											{
												if (124332 - 31763 != 92569)
												{
													continue;
												}
												UnityEngine.Object.Destroy(gameObject4);
												if (3828 - 408411 != -404583)
												{
													continue;
												}
											}
										}
										this.IOQcWV9peDd = 2;
										if (280277 - 483657 != -203380)
										{
											continue;
										}
										this.BONcWKbmiyA++;
										if (283941 - 151964 == 131978)
										{
											continue;
										}
										this.SendMessage("newGameMessage", "Mission Objective: NPC saved:" + this.BONcWKbmiyA + "/10");
										if (188606 - 30202 == 158405)
										{
											continue;
										}
									}
									else if (num5 == 5)
									{
										if (227469 - 558717 != -331248)
										{
											continue;
										}
										if (this.UTCcWhmmjUM < 1)
										{
											if (167689 - 338376 != -170687)
											{
												continue;
											}
											GameObject gameObject5 = GameObject.Find("MiniSheep");
											if (63912 - 289159 == -225246)
											{
												continue;
											}
											if (gameObject5)
											{
												if (132307 - 22065 == 110243)
												{
													continue;
												}
												UnityEngine.Object.Destroy(gameObject5);
												if (263367 - 396968 != -133601)
												{
													continue;
												}
											}
										}
										this.UTCcWhmmjUM = 2;
										if (37127 - 48182 != -11055)
										{
											continue;
										}
										this.BONcWKbmiyA++;
										if (278906 - 311190 == -32283)
										{
											continue;
										}
										this.SendMessage("newGameMessage", "Mission Objective: NPC saved:" + this.BONcWKbmiyA + "/10");
										if (225172 - 109592 != 115580)
										{
											continue;
										}
									}
								}
								else if (num4 == 6033)
								{
									if (199655 - 166419 != 33236)
									{
										continue;
									}
								}
								else
								{
									if (num4 != 6034)
									{
										break;
									}
									if (26655 - 335217 == -308561)
									{
										continue;
									}
									this.wkUcWzshWwO++;
									if (51874 - 454915 == -403040)
									{
										continue;
									}
									if (PlayerData.UID != num3)
									{
										break;
									}
									if (210745 - 449982 == -239236)
									{
										continue;
									}
									if (this.wkUcWzshWwO < 3)
									{
										break;
									}
									if (197972 - 400013 != -202041)
									{
										continue;
									}
									if (this.wkUcWzshWwO >= 24)
									{
										break;
									}
									if (251572 - 9240 != 242332)
									{
										continue;
									}
									GameObject gameObject6 = GameObject.Find("SpawnPoint" + (UnityEngine.Random.Range(0, 4) + 1));
									if (190267 - 44677 != 145590)
									{
										continue;
									}
									if (!gameObject6)
									{
										break;
									}
									if (26309 - 190155 != -163846)
									{
										continue;
									}
									this.createActor("Shade2", 8, gameObject6.transform.position, gameObject6.transform.forward);
									if (263738 - 256106 != 7633)
									{
										break;
									}
									continue;
								}
								this.wkUcWzshWwO++;
								if (117619 - 122126 != -4506)
								{
									if (PlayerData.UID != num3)
									{
										break;
									}
									if (135300 - 536863 != -401562)
									{
										if (this.wkUcWzshWwO < 3)
										{
											break;
										}
										if (178535 - 179390 != -854)
										{
											if (this.wkUcWzshWwO >= 24)
											{
												break;
											}
											if (280121 - 438004 == -157883)
											{
												GameObject gameObject7 = GameObject.Find("SpawnPoint" + (UnityEngine.Random.Range(0, 4) + 1));
												if (113657 - 460796 == -347139)
												{
													if (!gameObject7)
													{
														break;
													}
													if (285657 - 272435 != 13223)
													{
														this.createActor("Shade1", 8, gameObject7.transform.position, gameObject7.transform.forward);
														if (126262 - 333145 != -206882)
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

	// Token: 0x060084F6 RID: 34038 RVA: 0x010AC774 File Offset: 0x010AA974
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M603_ShadeInTheCity2.$onGameComplete$39775(data, this).GetEnumerator();
	}

	// Token: 0x060084F7 RID: 34039 RVA: 0x010AC784 File Offset: 0x010AA984
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRaccoon(int nRaccoonNum)
	{
		return new M603_ShadeInTheCity2.$TalkToRaccoon$39784(nRaccoonNum, this).GetEnumerator();
	}

	// Token: 0x060084F8 RID: 34040 RVA: 0x010AC794 File Offset: 0x010AA994
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToKoala()
	{
		return new M603_ShadeInTheCity2.$TalkToKoala$39795(this).GetEnumerator();
	}

	// Token: 0x060084F9 RID: 34041 RVA: 0x010AC7A4 File Offset: 0x010AA9A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMiniSheep()
	{
		return new M603_ShadeInTheCity2.$TalkToMiniSheep$39802(this).GetEnumerator();
	}

	// Token: 0x060084FA RID: 34042 RVA: 0x010AC7B4 File Offset: 0x010AA9B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther()
	{
		return new M603_ShadeInTheCity2.$TalkToPanther$39809(this).GetEnumerator();
	}

	// Token: 0x060084FB RID: 34043 RVA: 0x010AC7C4 File Offset: 0x010AA9C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToHumpback()
	{
		return new M603_ShadeInTheCity2.$TalkToHumpback$39816(this).GetEnumerator();
	}

	// Token: 0x060084FC RID: 34044 RVA: 0x010AC7D4 File Offset: 0x010AA9D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (43574 - 454323 != -410749)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (166580 - 520252 == -353672)
			{
				Hashtable customOpParameters = new Hashtable();
				if (13934 - 425332 == -411398)
				{
					this.xygcWkuxt1U.OpCustom(52, customOpParameters, true);
					if (188665 - 327451 == -138786)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060084FD RID: 34045 RVA: 0x010AC87C File Offset: 0x010AAA7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (223827 - 412850 != -189022)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (287853 - 423408 == -135555)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (196040 - 165424 != 30617)
				{
					Game.mGameState = eGameState.Setup;
					if (115532 - 323376 == -207844)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060084FE RID: 34046 RVA: 0x010AC920 File Offset: 0x010AAB20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (88939 - 301356 != -212416)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (260380 - 442410 == -182030)
			{
				if (num == PlayerData.UID)
				{
					if (173348 - 461768 == -288420)
					{
						this.SetupActors();
						if (68704 - 481235 != -412530)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (101306 - 251911 != -150604)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060084FF RID: 34047 RVA: 0x010AC9F0 File Offset: 0x010AABF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (199899 - 165720 != 34179)
		{
		}
		for (;;)
		{
			IL_C6:
			Debug.Log("Creating Actors");
			if (13058 - 12338 == 720)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (49715 - 11634 == 38081)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (49446 - 230288 != -180841)
						{
							int i = 0;
							if (234670 - 254490 == -19820)
							{
								CharacterControl[] array2 = array;
								if (243241 - 5439 != 237803)
								{
									int length = array2.Length;
									if (223881 - 578641 == -354760)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (298660 - 69549 == 229112)
											{
												goto IL_C6;
											}
											if (type == "Shade1")
											{
												goto IL_1D7;
											}
											if (206916 - 349945 != -143029)
											{
												goto IL_C6;
											}
											if (type == "Shade2")
											{
												if (184344 - 376149 != -191805)
												{
													goto IL_C6;
												}
												goto IL_1D7;
											}
											IL_F4:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (256357 - 462012 != -205655)
											{
												goto IL_C6;
											}
											this.l3qcu5wqPkJ++;
											if (69371 - 566225 != -496854)
											{
												goto IL_C6;
											}
											i++;
											if (283761 - 213423 != 70339)
											{
												continue;
											}
											goto IL_C6;
											IL_1D7:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (113744 - 323122 != -209377)
											{
												goto IL_F4;
											}
											goto IL_C6;
										}
										if (265944 - 125805 != 140140)
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
						if (73053 - 220350 != -147296)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008500 RID: 34048 RVA: 0x010ACC90 File Offset: 0x010AAE90
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (34679 - 55947 != -21267)
		{
		}
		for (;;)
		{
			IL_58:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (101804 - 576370 != -474565)
			{
				int i = 0;
				if (76889 - 550341 != -473451)
				{
					CharacterControl[] array2 = array;
					if (285346 - 199492 != 85855)
					{
						int length = array2.Length;
						if (62625 - 115476 != -52850)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (15340 - 448903 != -433563)
								{
									goto IL_58;
								}
								i++;
								if (52105 - 359621 != -307516)
								{
									goto IL_58;
								}
							}
							if (116936 - 590149 != -473212)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008501 RID: 34049 RVA: 0x010ACDC0 File Offset: 0x010AAFC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (69677 - 21584 != 48093)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (159302 - 47837 == 111465)
			{
				Game.mGameState = eGameState.Ready;
				if (271453 - 527643 == -256190)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (152490 - 289077 == -136587)
					{
						if (38335 - 382301 == -343966)
						{
							GameObject gameObject = null;
							if (190879 - 131223 != 59657)
							{
								if (playerSlot <= 1)
								{
									goto IL_44;
								}
								if (155184 - 130041 == 25144)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_44;
								}
								if (3136 - 531129 != -527993)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (67001 - 194679 == -127677)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (248100 - 332361 == -84260)
								{
									continue;
								}
								IL_1A:
								if (gameObject2)
								{
									if (55713 - 429275 != -373562)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (278893 - 355717 != -76824)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (112521 - 240044 == -127522)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (253098 - 339464 != -86366)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (292084 - 599170 != -307086)
								{
									continue;
								}
								break;
								IL_44:
								gameObject2 = GameObject.Find("StartPoint1");
								if (46251 - 166453 != -120201)
								{
									goto IL_1A;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008502 RID: 34050 RVA: 0x010AD050 File Offset: 0x010AB250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M603_ShadeInTheCity2.$StartGame$39823(this).GetEnumerator();
	}

	// Token: 0x06008503 RID: 34051 RVA: 0x010AD060 File Offset: 0x010AB260
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008504 RID: 34052 RVA: 0x010AD064 File Offset: 0x010AB264
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (271458 - 565587 != -294129)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (163387 - 160451 != 2937)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (64840 - 509725 != -444884)
				{
					hashtable.Add(43, PlayerData.UID);
					if (17825 - 366105 != -348279)
					{
						hashtable.Add(73, nType);
						if (161536 - 96571 == 64965)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (1112 - 172391 != -171278)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (41514 - 438141 == -396627)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (74189 - 274702 == -200513)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (146183 - 125637 != 20547)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (103096 - 508987 == -405891)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (135597 - 548940 != -413342)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (29746 - 467351 != -437604)
													{
														this.xygcWkuxt1U.OpCustom(63, hashtable, true);
														if (157992 - 336732 == -178740)
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

	// Token: 0x06008505 RID: 34053 RVA: 0x010AD348 File Offset: 0x010AB548
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (191513 - 239204 != -47690)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (102993 - 339730 != -236736)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (224652 - 570893 == -346241)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (20983 - 33199 == -12216)
						{
							if (this.l3qcu5wqPkJ <= 0)
							{
								break;
							}
							if (121612 - 170088 != -48475)
							{
								this.l3qcu5wqPkJ--;
								if (229255 - 338927 != -109671)
								{
									if (this.l3qcu5wqPkJ != 0)
									{
										break;
									}
									if (292505 - 129281 != 163225)
									{
										Game.setGameState(eGameState.Ready);
										if (199799 - 313514 != -113714)
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
						if (194053 - 585713 == -391660)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (10312 - 40205 != -29892)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008506 RID: 34054 RVA: 0x010AD4D8 File Offset: 0x010AB6D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008507 RID: 34055 RVA: 0x010AD4EC File Offset: 0x010AB6EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (168522 - 353350 != -184828)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (183775 - 227068 == -43293)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (103146 - 201881 == -98735)
				{
					if (!characterControl)
					{
						break;
					}
					if (204961 - 493333 != -288371)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (116255 - 585258 == -469003)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (214219 - 277416 == -63197)
							{
								string type = characterControl.Type;
								if (128356 - 445103 != -316746)
								{
									if (type == "Shade1")
									{
										if (237392 - 357875 != -120482)
										{
											Game.sendMissionEvent(6033, 0);
											if (58259 - 231606 != -173346)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Shade2"))
										{
											break;
										}
										if (266027 - 237648 != 28380)
										{
											Game.sendMissionEvent(6034, 0);
											if (292467 - 37206 == 255261)
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

	// Token: 0x06008508 RID: 34056 RVA: 0x010AD6B8 File Offset: 0x010AB8B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (14762 - 44993 != -30231)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (198818 - 230983 == -32165)
			{
				hashtable.Add(71, CID);
				if (189620 - 174397 == 15223)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (209471 - 251782 != -42310)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (113496 - 109717 != 3780)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (123888 - 459614 != -335725)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (128710 - 439197 != -310486)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (104316 - 367278 == -262962)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (232318 - 441639 != -209320)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (203068 - 371737 == -168669)
											{
												this.xygcWkuxt1U.OpCustom(61, hashtable, true);
												if (108768 - 432278 != -323509)
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

	// Token: 0x06008509 RID: 34057 RVA: 0x010AD944 File Offset: 0x010ABB44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (274017 - 590092 != -316074)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (18457 - 282546 == -264089)
			{
				if (!gameObject)
				{
					break;
				}
				if (189824 - 408815 == -218991)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (19883 - 255180 == -235297)
					{
						playerCameraControl.target = gameObject;
						if (202004 - 34 == 201970)
						{
							if (Game.useAdvanceMode)
							{
								if (186406 - 129504 == 56903)
								{
									continue;
								}
								Game.loadPlayer();
								if (16281 - 63498 == -47216)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (112852 - 172676 != -59823)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600850A RID: 34058 RVA: 0x010ADA80 File Offset: 0x010ABC80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (62374 - 151627 != -89252)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (227223 - 84593 != 142631)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (212347 - 211656 == 691)
				{
					gameGui.ResetTeamBar();
					if (24816 - 1675 == 23141)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600850B RID: 34059 RVA: 0x010ADB2C File Offset: 0x010ABD2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M603_ShadeInTheCity2.$onDeadPlayer$39827(this).GetEnumerator();
	}

	// Token: 0x0600850C RID: 34060 RVA: 0x010ADB3C File Offset: 0x010ABD3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (92243 - 542441 != -450198)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (93993 - 396994 != -303000)
			{
				this.ScUcWFZn7q0.target = Game.mPlayer;
				if (237859 - 121736 == 116123)
				{
					this.ScUcWFZn7q0.enabled = true;
					if (40229 - 77335 == -37106)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (157025 - 11990 != 145035)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (124092 - 64327 != 59765)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (263412 - 402364 == -138952)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (121781 - 440843 != -319061)
							{
								if (!gameGui)
								{
									break;
								}
								if (46899 - 44643 != 2257)
								{
									gameGui.enabled = true;
									if (259550 - 520389 != -260838)
									{
										gameGui.closeDeadMenu();
										if (33524 - 66028 == -32504)
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

	// Token: 0x0600850D RID: 34061 RVA: 0x010ADCE8 File Offset: 0x010ABEE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (201100 - 265311 != -64211)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (162067 - 585050 != -422982)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (282225 - 59521 != 222705)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (110619 - 17850 != 92770)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600850E RID: 34062 RVA: 0x010ADDAC File Offset: 0x010ABFAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600850F RID: 34063 RVA: 0x010ADDD8 File Offset: 0x010ABFD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M603_ShadeInTheCity2.$ReturnToTown$39833(this).GetEnumerator();
	}

	// Token: 0x06008510 RID: 34064 RVA: 0x010ADDE8 File Offset: 0x010ABFE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M603_ShadeInTheCity2.$ReturnToGuild$39838(this).GetEnumerator();
	}

	// Token: 0x06008511 RID: 34065 RVA: 0x010ADDF8 File Offset: 0x010ABFF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M603_ShadeInTheCity2.$ReturnToCamp$39842(this).GetEnumerator();
	}

	// Token: 0x06008512 RID: 34066 RVA: 0x010ADE08 File Offset: 0x010AC008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (137600 - 322617 != -185017)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (249462 - 587160 == -337698)
			{
				Hashtable hashtable = new Hashtable();
				if (50833 - 138 != 50696)
				{
					hashtable.Add(43, PlayerData.UID);
					if (240258 - 528245 == -287987)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (54274 - 477600 == -423326)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008513 RID: 34067 RVA: 0x010ADEE0 File Offset: 0x010AC0E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008514 RID: 34068 RVA: 0x010ADEF4 File Offset: 0x010AC0F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (171202 - 440230 != -269027)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (153427 - 404331 == -250904)
			{
				Hashtable hashtable = new Hashtable();
				if (295316 - 65337 == 229979)
				{
					if (Game.mNextGameCode == 30)
					{
						if (145294 - 300360 != -155066)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (93361 - 548524 != -455163)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (108544 - 178101 == -69556)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (216091 - 61861 != 154230)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (14748 - 365453 != -350705)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (103187 - 588642 != -485455)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (252186 - 533556 == -281369)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (292074 - 426957 == -134882)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (20995 - 31444 == -10448)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (259294 - 359434 != -100140)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (295347 - 148521 != 146826)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (274666 - 101770 == 172897)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (75814 - 385977 != -310163)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (29882 - 505429 != -475547)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (149668 - 241618 == -91949)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (216839 - 286111 != -69272)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (43335 - 505963 != -462628)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (80248 - 423457 == -343208)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (9992 - 357926 == -347933)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (124163 - 202233 == -78069)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (206757 - 167802 == 38956)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (17558 - 471166 == -453607)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (296991 - 106499 == 190493)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (244611 - 210271 != 34340)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (187104 - 411785 != -224681)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (107038 - 319689 == -212650)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (127015 - 300525 != -173510)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (120115 - 44971 == 75145)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (111559 - 460993 != -349433)
					{
						this.xygcWkuxt1U.OpCustom(42, hashtable, true);
						if (18512 - 463953 != -445440)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008515 RID: 34069 RVA: 0x010AE4A8 File Offset: 0x010AC6A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008516 RID: 34070 RVA: 0x010AE4B8 File Offset: 0x010AC6B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008517 RID: 34071 RVA: 0x010AE4BC File Offset: 0x010AC6BC
	internal static bool Sla7C8p4IEy0FyF15KN9()
	{
		return true;
	}

	// Token: 0x06008518 RID: 34072 RVA: 0x010AE4C0 File Offset: 0x010AC6C0
	internal static bool ASjrvYp4ByfvyJU6XE0O()
	{
		return false;
	}

	// Token: 0x040081E7 RID: 33255
	private LitePeer xygcWkuxt1U;

	// Token: 0x040081E8 RID: 33256
	private PlayerCameraControl ScUcWFZn7q0;

	// Token: 0x040081E9 RID: 33257
	private float tUCcWAp7VmT;

	// Token: 0x040081EA RID: 33258
	private int W5XcW9f02XM;

	// Token: 0x040081EB RID: 33259
	private int txrcWW9N9nK;

	// Token: 0x040081EC RID: 33260
	private int PWScWucsDji;

	// Token: 0x040081ED RID: 33261
	private int nsncWygdNhT;

	// Token: 0x040081EE RID: 33262
	private int IOQcWV9peDd;

	// Token: 0x040081EF RID: 33263
	private int UTCcWhmmjUM;

	// Token: 0x040081F0 RID: 33264
	private int BONcWKbmiyA;

	// Token: 0x040081F1 RID: 33265
	private int wkUcWzshWwO;

	// Token: 0x040081F2 RID: 33266
	private int l3qcu5wqPkJ;

	// Token: 0x02001663 RID: 5731
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39775 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008519 RID: 34073 RVA: 0x010AE4C4 File Offset: 0x010AC6C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39775(Hashtable data, M603_ShadeInTheCity2 self_)
		{
			if (193974 - 516915 != -322941)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (59094 - 387570 == -328476)
				{
					base..ctor();
					if (165443 - 499942 != -334498)
					{
						this.$data$39782 = data;
						if (156747 - 236038 == -79291)
						{
							this.$self_$39783 = self_;
							if (65229 - 380930 == -315701)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600851A RID: 34074 RVA: 0x010AE580 File Offset: 0x010AC780
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity2.$onGameComplete$39775.$(this.$data$39782, this.$self_$39783);
		}

		// Token: 0x0600851B RID: 34075 RVA: 0x010AE594 File Offset: 0x010AC794
		internal static bool l8I59gp4evBC50JQ4dCF()
		{
			return true;
		}

		// Token: 0x0600851C RID: 34076 RVA: 0x010AE598 File Offset: 0x010AC798
		internal static bool PelRKvp4r4nPn9xZ6elk()
		{
			return false;
		}

		// Token: 0x040081F3 RID: 33267
		internal Hashtable $data$39782;

		// Token: 0x040081F4 RID: 33268
		internal M603_ShadeInTheCity2 $self_$39783;

		// Token: 0x02001664 RID: 5732
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600851D RID: 34077 RVA: 0x010AE59C File Offset: 0x010AC79C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M603_ShadeInTheCity2 self_)
			{
				if (105231 - 597661 != -492429)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (273931 - 488839 != -214907)
					{
						base..ctor();
						if (258399 - 140832 != 117568)
						{
							this.$data$39780 = data;
							if (216339 - 238908 != -22568)
							{
								this.$self_$39781 = self_;
								if (199006 - 563247 == -364241)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600851E RID: 34078 RVA: 0x010AE658 File Offset: 0x010AC858
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (32571 - 75598 != -43026)
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
						this.$mCompleteGui$39777 = (CompleteGui)this.$self_$39781.GetComponent(typeof(CompleteGui));
						if (243770 - 26350 != 217420)
						{
							continue;
						}
						this.$mCompleteGui$39777.Init();
						if (266394 - 40711 == 225684)
						{
							continue;
						}
						this.$mCompleteGui$39777.readData(this.$data$39780);
						if (172268 - 541874 != -369606)
						{
							continue;
						}
						if (this.$result$39776 == 1)
						{
							if (159740 - 70472 == 89269)
							{
								continue;
							}
							this.$mCompleteGui$39777.displayResult(eCompleteType.Success);
							if (191089 - 200473 == -9383)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39777.displayResult(eCompleteType.Failed);
							if (161531 - 399993 != -238462)
							{
								continue;
							}
						}
						this.$mGameGui$39778 = (GameGui)this.$self_$39781.GetComponent(typeof(GameGui));
						if (15809 - 144424 != -128615)
						{
							continue;
						}
						this.$mStoryGui$39779 = (StoryGui)this.$self_$39781.GetComponent(typeof(StoryGui));
						if (122266 - 319299 != -197033)
						{
							continue;
						}
						if (this.$mGameGui$39778)
						{
							if (43948 - 528122 == -484173)
							{
								continue;
							}
							this.$mGameGui$39778.close();
							if (232533 - 536467 != -303934)
							{
								continue;
							}
						}
						if (this.$mStoryGui$39779)
						{
							if (265985 - 170631 != 95354)
							{
								continue;
							}
							this.$mStoryGui$39779.close();
							if (227570 - 550582 != -323012)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (100499 - 65633 != 34866)
						{
							continue;
						}
						goto IL_352;
					default:
						if (289747 - 430651 != -140904)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$39780[31]);
					if (208453 - 162506 == 45947)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (3489 - 431758 != -428268)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (228911 - 44472 != 184440)
							{
								this.$result$39776 = RuntimeServices.UnboxInt32(this.$data$39780[31]);
								if (26044 - 241457 != -215412)
								{
									goto Block_17;
								}
							}
						}
					}
				}
				goto IL_352;
				Block_17:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x0600851F RID: 34079 RVA: 0x010AE9CC File Offset: 0x010ACBCC
			internal static bool Mu0I1Yp4j4TfpSTVUleT()
			{
				return true;
			}

			// Token: 0x06008520 RID: 34080 RVA: 0x010AE9D0 File Offset: 0x010ACBD0
			internal static bool Ea4rg0p4h4sOr2N36dpn()
			{
				return false;
			}

			// Token: 0x040081F5 RID: 33269
			internal int $result$39776;

			// Token: 0x040081F6 RID: 33270
			internal CompleteGui $mCompleteGui$39777;

			// Token: 0x040081F7 RID: 33271
			internal GameGui $mGameGui$39778;

			// Token: 0x040081F8 RID: 33272
			internal StoryGui $mStoryGui$39779;

			// Token: 0x040081F9 RID: 33273
			internal Hashtable $data$39780;

			// Token: 0x040081FA RID: 33274
			internal M603_ShadeInTheCity2 $self_$39781;
		}
	}

	// Token: 0x02001665 RID: 5733
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRaccoon$39784 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008521 RID: 34081 RVA: 0x010AE9D4 File Offset: 0x010ACBD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRaccoon$39784(int nRaccoonNum, M603_ShadeInTheCity2 self_)
		{
			if (220075 - 577188 != -357113)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (38138 - 584899 == -546761)
				{
					base..ctor();
					if (31824 - 229228 != -197403)
					{
						this.$nRaccoonNum$39793 = nRaccoonNum;
						if (62516 - 260755 == -198239)
						{
							this.$self_$39794 = self_;
							if (246998 - 110834 != 136165)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008522 RID: 34082 RVA: 0x010AEA90 File Offset: 0x010ACC90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity2.$TalkToRaccoon$39784.$(this.$nRaccoonNum$39793, this.$self_$39794);
		}

		// Token: 0x06008523 RID: 34083 RVA: 0x010AEAA4 File Offset: 0x010ACCA4
		internal static bool LcHIgap4sFst75Kl2cPf()
		{
			return true;
		}

		// Token: 0x06008524 RID: 34084 RVA: 0x010AEAA8 File Offset: 0x010ACCA8
		internal static bool sD1tXnp49GgjOMO5bg6l()
		{
			return false;
		}

		// Token: 0x040081FB RID: 33275
		internal int $nRaccoonNum$39793;

		// Token: 0x040081FC RID: 33276
		internal M603_ShadeInTheCity2 $self_$39794;

		// Token: 0x02001666 RID: 5734
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008525 RID: 34085 RVA: 0x010AEAAC File Offset: 0x010ACCAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nRaccoonNum, M603_ShadeInTheCity2 self_)
			{
				if (151169 - 129782 != 21388)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (50299 - 202094 == -151795)
					{
						base..ctor();
						if (55051 - 235018 == -179967)
						{
							this.$nRaccoonNum$39791 = nRaccoonNum;
							if (178239 - 241406 == -63167)
							{
								this.$self_$39792 = self_;
								if (152232 - 489915 != -337682)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008526 RID: 34086 RVA: 0x010AEB68 File Offset: 0x010ACD68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (125737 - 377328 != -251590)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_215;
					case 1:
						goto IL_826;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (198592 - 250493 != -51900)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$nMessage$39789 = Language.getMessage("M603_ShadeInTheCity", 6037 + this.$nRaccoonNum$39791);
							if (146267 - 254215 == -107947)
							{
								continue;
							}
							this.$mStoryGui$39787.newStoryMessage("none", "Raccoon", this.$nMessage$39789, eTalkType.friend);
							if (267734 - 67963 != 199772)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (67399 - 227865 != -160466)
							{
								continue;
							}
							goto IL_25F;
						}
						else
						{
							this.$mStoryGui$39787.close();
							if (153482 - 391804 != -238322)
							{
								continue;
							}
							this.$mGameGui$39786.enabled = true;
							if (45154 - 228844 != -183689)
							{
								goto Block_62;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (31596 - 292078 != -260482)
							{
								continue;
							}
							goto IL_552;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (191668 - 26834 == 164835)
							{
								continue;
							}
							if (this.$mRaccoon$39788)
							{
								if (20924 - 465311 != -444387)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mRaccoon$39788);
								if (297997 - 133195 == 164803)
								{
									continue;
								}
							}
							this.$$switch$7016$39790 = this.$nRaccoonNum$39791;
							if (231425 - 260786 != -29361)
							{
								continue;
							}
							if (this.$$switch$7016$39790 == 1)
							{
								if (93000 - 204774 != -111774)
								{
									continue;
								}
								if (this.$self_$39792.txrcWW9N9nK < 2)
								{
									if (153521 - 111183 == 42339)
									{
										continue;
									}
									Game.sendMissionEvent(6032, 1);
									if (190645 - 101716 != 88929)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$7016$39790 == 2)
							{
								if (199338 - 264786 != -65448)
								{
									continue;
								}
								if (this.$self_$39792.PWScWucsDji < 2)
								{
									if (21482 - 244794 == -223311)
									{
										continue;
									}
									Game.sendMissionEvent(6032, 2);
									if (37761 - 347446 != -309685)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$7016$39790 == 3)
							{
								if (295039 - 43208 == 251832)
								{
									continue;
								}
								if (this.$self_$39792.nsncWygdNhT < 2)
								{
									if (84144 - 374428 == -290283)
									{
										continue;
									}
									Game.sendMissionEvent(6032, 3);
									if (123415 - 157620 != -34205)
									{
										continue;
									}
								}
							}
						}
						break;
					default:
						if (53466 - 58337 != -4870)
						{
							goto IL_215;
						}
						continue;
					}
					IL_19E:
					this.YieldDefault(1);
					if (12027 - 527863 != -515836)
					{
						continue;
					}
					goto IL_826;
					IL_215:
					if (Game.mGameState != eGameState.Normal)
					{
						if (176451 - 163752 != 12700)
						{
							goto Block_21;
						}
					}
					else
					{
						this.$$switch$7014$39785 = this.$nRaccoonNum$39791;
						if (297260 - 585061 != -287800)
						{
							if (this.$$switch$7014$39785 == 1)
							{
								if (287983 - 161045 == 126939)
								{
									continue;
								}
								if (this.$self_$39792.txrcWW9N9nK > 0)
								{
									if (103364 - 200746 != -97382)
									{
										continue;
									}
									goto IL_4C7;
								}
								else
								{
									this.$self_$39792.txrcWW9N9nK = 1;
									if (168889 - 250481 != -81592)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$7014$39785 == 2)
							{
								if (161979 - 548288 == -386308)
								{
									continue;
								}
								if (this.$self_$39792.PWScWucsDji > 0)
								{
									if (258063 - 370869 != -112805)
									{
										goto Block_51;
									}
									continue;
								}
								else
								{
									this.$self_$39792.PWScWucsDji = 1;
									if (111417 - 124054 == -12636)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$7014$39785 == 3)
							{
								if (208296 - 267229 == -58932)
								{
									continue;
								}
								if (this.$self_$39792.nsncWygdNhT > 0)
								{
									if (104073 - 40108 != 63966)
									{
										goto Block_17;
									}
									continue;
								}
								else
								{
									this.$self_$39792.nsncWygdNhT = 1;
									if (126158 - 171939 == -45780)
									{
										continue;
									}
								}
							}
							this.$mGameGui$39786 = (GameGui)this.$self_$39792.GetComponent(typeof(GameGui));
							if (83191 - 43750 == 39441)
							{
								this.$mStoryGui$39787 = (StoryGui)this.$self_$39792.GetComponent(typeof(StoryGui));
								if (114015 - 480028 == -366013)
								{
									if (!this.$mGameGui$39786)
									{
										goto IL_19E;
									}
									if (85925 - 297600 == -211675)
									{
										if (!this.$mStoryGui$39787)
										{
											goto IL_19E;
										}
										if (96364 - 330299 == -233935)
										{
											Game.mGameState = eGameState.Hold;
											if (162612 - 1716 != 160897)
											{
												this.$mGameGui$39786.close();
												if (220628 - 105645 == 114983)
												{
													this.$mRaccoon$39788 = GameObject.Find("Raccoon" + this.$nRaccoonNum$39791);
													if (230244 - 222982 == 7262)
													{
														if (this.$mRaccoon$39788)
														{
															if (88981 - 155517 != -66536)
															{
																continue;
															}
															this.$mRaccoon$39788.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mRaccoon$39788.transform.position));
															if (267969 - 522449 == -254479)
															{
																continue;
															}
															Game.mPlayer.SendMessage("turnToPos", this.$mRaccoon$39788.transform.position);
															if (232144 - 281175 == -49030)
															{
																continue;
															}
														}
														else
														{
															Debug.LogError("Cannot find Raccoon");
															if (10888 - 21818 != -10930)
															{
																continue;
															}
														}
														this.$mStoryGui$39787.startStoryMessage("none", "Raccoon", eTalkType.friend);
														if (38655 - 292393 == -253738)
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
				Block_6:
				Block_17:
				Block_21:
				IL_25F:
				goto IL_826;
				Block_25:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_4C7:
				IL_552:
				Block_51:
				goto IL_826;
				Block_62:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_826:
				return false;
			}

			// Token: 0x06008527 RID: 34087 RVA: 0x010AF3B0 File Offset: 0x010AD5B0
			internal static bool D7j3qjp41x3veu7TrxMT()
			{
				return true;
			}

			// Token: 0x06008528 RID: 34088 RVA: 0x010AF3B4 File Offset: 0x010AD5B4
			internal static bool Rr94NIp44qpJlre4M9Tf()
			{
				return false;
			}

			// Token: 0x040081FD RID: 33277
			internal int $$switch$7014$39785;

			// Token: 0x040081FE RID: 33278
			internal GameGui $mGameGui$39786;

			// Token: 0x040081FF RID: 33279
			internal StoryGui $mStoryGui$39787;

			// Token: 0x04008200 RID: 33280
			internal GameObject $mRaccoon$39788;

			// Token: 0x04008201 RID: 33281
			internal string $nMessage$39789;

			// Token: 0x04008202 RID: 33282
			internal int $$switch$7016$39790;

			// Token: 0x04008203 RID: 33283
			internal int $nRaccoonNum$39791;

			// Token: 0x04008204 RID: 33284
			internal M603_ShadeInTheCity2 $self_$39792;
		}
	}

	// Token: 0x02001667 RID: 5735
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToKoala$39795 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008529 RID: 34089 RVA: 0x010AF3B8 File Offset: 0x010AD5B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToKoala$39795(M603_ShadeInTheCity2 self_)
		{
			if (227425 - 246632 != -19206)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (187440 - 492678 == -305238)
				{
					base..ctor();
					if (280839 - 540536 != -259696)
					{
						this.$self_$39801 = self_;
						if (23679 - 472799 == -449120)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600852A RID: 34090 RVA: 0x010AF450 File Offset: 0x010AD650
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity2.$TalkToKoala$39795.$(this.$self_$39801);
		}

		// Token: 0x0600852B RID: 34091 RVA: 0x010AF460 File Offset: 0x010AD660
		internal static bool UHXL6Gp4zKZYX8yQvmOX()
		{
			return true;
		}

		// Token: 0x0600852C RID: 34092 RVA: 0x010AF464 File Offset: 0x010AD664
		internal static bool ObA4jspzaWOJmErEq4gC()
		{
			return false;
		}

		// Token: 0x04008205 RID: 33285
		internal M603_ShadeInTheCity2 $self_$39801;

		// Token: 0x02001668 RID: 5736
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600852D RID: 34093 RVA: 0x010AF468 File Offset: 0x010AD668
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity2 self_)
			{
				if (177698 - 199204 != -21506)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (103646 - 509572 == -405926)
					{
						base..ctor();
						if (274649 - 141505 != 133145)
						{
							this.$self_$39800 = self_;
							if (18154 - 27829 == -9675)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600852E RID: 34094 RVA: 0x010AF500 File Offset: 0x010AD700
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (76026 - 365006 != -288980)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_534;
					case 1:
						goto IL_5A9;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (31128 - 136389 != -105260)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$nMessage$39799 = Language.getMessage("M603_ShadeInTheCity", 6041);
							if (141237 - 533345 != -392108)
							{
								continue;
							}
							this.$mStoryGui$39797.newStoryMessage("Koala", "Akola", this.$nMessage$39799, eTalkType.friend);
							if (85889 - 68178 != 17712)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (224130 - 378629 != -154499)
							{
								continue;
							}
							goto IL_20A;
						}
						else
						{
							this.$mStoryGui$39797.close();
							if (139874 - 464804 == -324929)
							{
								continue;
							}
							this.$mGameGui$39796.enabled = true;
							if (42436 - 421324 != -378887)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (80396 - 493756 != -413360)
							{
								continue;
							}
							goto IL_362;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (193030 - 129483 == 63548)
							{
								continue;
							}
							if (this.$mKoala$39798)
							{
								if (12057 - 259729 != -247672)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mKoala$39798);
								if (205149 - 551154 != -346005)
								{
									continue;
								}
							}
							if (this.$self_$39800.IOQcWV9peDd < 2)
							{
								if (251381 - 12229 == 239153)
								{
									continue;
								}
								Game.sendMissionEvent(6032, 4);
								if (61094 - 586941 != -525847)
								{
									continue;
								}
							}
						}
						break;
					default:
						if (44849 - 238519 != -193669)
						{
							goto IL_534;
						}
						continue;
					}
					IL_1BF:
					this.YieldDefault(1);
					if (170120 - 428178 != -258057)
					{
						goto Block_13;
					}
					continue;
					IL_534:
					if (Game.mGameState != eGameState.Normal)
					{
						if (49134 - 84862 != -35727)
						{
							goto Block_39;
						}
					}
					else if (this.$self_$39800.IOQcWV9peDd > 0)
					{
						if (133797 - 130126 != 3672)
						{
							goto Block_25;
						}
					}
					else
					{
						this.$self_$39800.IOQcWV9peDd = 1;
						if (67857 - 94577 == -26720)
						{
							this.$mGameGui$39796 = (GameGui)this.$self_$39800.GetComponent(typeof(GameGui));
							if (286177 - 569000 != -282822)
							{
								this.$mStoryGui$39797 = (StoryGui)this.$self_$39800.GetComponent(typeof(StoryGui));
								if (165832 - 512580 != -346747)
								{
									if (!this.$mGameGui$39796)
									{
										goto IL_1BF;
									}
									if (138058 - 555070 != -417011)
									{
										if (!this.$mStoryGui$39797)
										{
											goto IL_1BF;
										}
										if (230708 - 473660 == -242952)
										{
											Game.mGameState = eGameState.Hold;
											if (88241 - 276895 == -188654)
											{
												this.$mGameGui$39796.close();
												if (177846 - 431382 != -253535)
												{
													this.$mKoala$39798 = GameObject.Find("Koala");
													if (25971 - 364215 == -338244)
													{
														if (this.$mKoala$39798)
														{
															if (25570 - 171231 == -145660)
															{
																continue;
															}
															this.$mKoala$39798.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mKoala$39798.transform.position));
															if (170484 - 27189 != 143295)
															{
																continue;
															}
															this.$mKoala$39798.animation.CrossFade("talk", 0.2f);
															if (160456 - 483571 == -323114)
															{
																continue;
															}
															Game.mPlayer.SendMessage("turnToPos", this.$mKoala$39798.transform.position);
															if (122288 - 305247 == -182958)
															{
																continue;
															}
														}
														else
														{
															Debug.LogError("Cannot find Koala");
															if (37801 - 364754 != -326953)
															{
																continue;
															}
														}
														this.$mStoryGui$39797.startStoryMessage("Koala", "Akola", eTalkType.friend);
														if (255171 - 579900 == -324729)
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
				Block_7:
				Block_13:
				IL_20A:
				Block_25:
				IL_362:
				goto IL_5A9;
				Block_28:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_37:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_39:
				IL_5A9:
				return false;
			}

			// Token: 0x0600852F RID: 34095 RVA: 0x010AFAC8 File Offset: 0x010ADCC8
			internal static bool FgFAVBpz5IYrnc7NnQsf()
			{
				return true;
			}

			// Token: 0x06008530 RID: 34096 RVA: 0x010AFACC File Offset: 0x010ADCCC
			internal static bool jjkZuWpzppqEthET9apb()
			{
				return false;
			}

			// Token: 0x04008206 RID: 33286
			internal GameGui $mGameGui$39796;

			// Token: 0x04008207 RID: 33287
			internal StoryGui $mStoryGui$39797;

			// Token: 0x04008208 RID: 33288
			internal GameObject $mKoala$39798;

			// Token: 0x04008209 RID: 33289
			internal string $nMessage$39799;

			// Token: 0x0400820A RID: 33290
			internal M603_ShadeInTheCity2 $self_$39800;
		}
	}

	// Token: 0x02001669 RID: 5737
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMiniSheep$39802 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008531 RID: 34097 RVA: 0x010AFAD0 File Offset: 0x010ADCD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMiniSheep$39802(M603_ShadeInTheCity2 self_)
		{
			if (10252 - 327568 != -317315)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (6000 - 567672 != -561671)
				{
					base..ctor();
					if (73665 - 478132 != -404466)
					{
						this.$self_$39808 = self_;
						if (85121 - 349923 == -264802)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008532 RID: 34098 RVA: 0x010AFB68 File Offset: 0x010ADD68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity2.$TalkToMiniSheep$39802.$(this.$self_$39808);
		}

		// Token: 0x06008533 RID: 34099 RVA: 0x010AFB78 File Offset: 0x010ADD78
		internal static bool U04FJwpzVsHuaSXU3mnS()
		{
			return true;
		}

		// Token: 0x06008534 RID: 34100 RVA: 0x010AFB7C File Offset: 0x010ADD7C
		internal static bool TPET81pztgOQ5oo6wx6d()
		{
			return false;
		}

		// Token: 0x0400820B RID: 33291
		internal M603_ShadeInTheCity2 $self_$39808;

		// Token: 0x0200166A RID: 5738
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008535 RID: 34101 RVA: 0x010AFB80 File Offset: 0x010ADD80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity2 self_)
			{
				if (295366 - 48035 != 247331)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (110737 - 591789 == -481052)
					{
						base..ctor();
						if (42317 - 306632 != -264314)
						{
							this.$self_$39807 = self_;
							if (54234 - 548202 == -493968)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008536 RID: 34102 RVA: 0x010AFC18 File Offset: 0x010ADE18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211196 - 426343 != -215147)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_4AF;
					case 1:
						goto IL_5A9;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (186624 - 306681 != -120056)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$nMessage$39806 = Language.getMessage("M603_ShadeInTheCity", 6042);
							if (290297 - 260086 != 30211)
							{
								continue;
							}
							this.$mStoryGui$39804.newStoryMessage("none", "MiniSheep", this.$nMessage$39806, eTalkType.friend);
							if (279956 - 513810 != -233853)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (39748 - 534829 != -495080)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39804.close();
							if (116015 - 63204 != 52811)
							{
								continue;
							}
							this.$mGameGui$39803.enabled = true;
							if (97866 - 483728 != -385861)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (159404 - 450305 != -290900)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (7807 - 444612 == -436804)
							{
								continue;
							}
							if (this.$mMiniSheep$39805)
							{
								if (104764 - 43987 == 60778)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mMiniSheep$39805);
								if (1760 - 248413 == -246652)
								{
									continue;
								}
							}
							if (this.$self_$39807.UTCcWhmmjUM < 2)
							{
								if (208516 - 422630 == -214113)
								{
									continue;
								}
								Game.sendMissionEvent(6032, 5);
								if (95273 - 357066 == -261792)
								{
									continue;
								}
							}
						}
						break;
					default:
						if (38524 - 191901 != -153377)
						{
							continue;
						}
						goto IL_4AF;
					}
					IL_15A:
					this.YieldDefault(1);
					if (239089 - 587071 != -347982)
					{
						continue;
					}
					break;
					IL_4AF:
					if (Game.mGameState != eGameState.Normal)
					{
						if (290365 - 101876 == 188489)
						{
							break;
						}
					}
					else if (this.$self_$39807.UTCcWhmmjUM > 0)
					{
						if (95973 - 373204 != -277230)
						{
							break;
						}
					}
					else
					{
						this.$self_$39807.UTCcWhmmjUM = 1;
						if (251726 - 394725 != -142998)
						{
							this.$mGameGui$39803 = (GameGui)this.$self_$39807.GetComponent(typeof(GameGui));
							if (260441 - 293082 == -32641)
							{
								this.$mStoryGui$39804 = (StoryGui)this.$self_$39807.GetComponent(typeof(StoryGui));
								if (51059 - 15249 == 35810)
								{
									if (!this.$mGameGui$39803)
									{
										goto IL_15A;
									}
									if (1714 - 438003 != -436288)
									{
										if (!this.$mStoryGui$39804)
										{
											goto IL_15A;
										}
										if (22408 - 390557 == -368149)
										{
											Game.mGameState = eGameState.Hold;
											if (222417 - 203646 != 18772)
											{
												this.$mGameGui$39803.close();
												if (110882 - 442871 == -331989)
												{
													this.$mMiniSheep$39805 = GameObject.Find("MiniSheep");
													if (49108 - 308065 == -258957)
													{
														if (this.$mMiniSheep$39805)
														{
															if (134162 - 235343 != -101181)
															{
																continue;
															}
															this.$mMiniSheep$39805.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mMiniSheep$39805.transform.position));
															if (226974 - 190609 == 36366)
															{
																continue;
															}
															this.$mMiniSheep$39805.animation.CrossFade("talk", 0.2f);
															if (158921 - 141683 == 17239)
															{
																continue;
															}
															Game.mPlayer.SendMessage("turnToPos", this.$mMiniSheep$39805.transform.position);
															if (252675 - 434014 != -181339)
															{
																continue;
															}
														}
														else
														{
															Debug.LogError("Cannot find MiniSheep");
															if (298983 - 466823 == -167839)
															{
																continue;
															}
														}
														this.$mStoryGui$39804.startStoryMessage("none", "MiniSheep", eTalkType.friend);
														if (146979 - 343618 != -196638)
														{
															goto Block_30;
														}
													}
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
				goto IL_5A9;
				Block_6:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_7:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_17:
				Block_29:
				goto IL_5A9;
				Block_30:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_5A9:
				return false;
			}

			// Token: 0x06008537 RID: 34103 RVA: 0x010B01E0 File Offset: 0x010AE3E0
			internal static bool g7LqZTpzNnWn67sC3DL3()
			{
				return true;
			}

			// Token: 0x06008538 RID: 34104 RVA: 0x010B01E4 File Offset: 0x010AE3E4
			internal static bool zSbeXppzYaBJ1YpkOod8()
			{
				return false;
			}

			// Token: 0x0400820C RID: 33292
			internal GameGui $mGameGui$39803;

			// Token: 0x0400820D RID: 33293
			internal StoryGui $mStoryGui$39804;

			// Token: 0x0400820E RID: 33294
			internal GameObject $mMiniSheep$39805;

			// Token: 0x0400820F RID: 33295
			internal string $nMessage$39806;

			// Token: 0x04008210 RID: 33296
			internal M603_ShadeInTheCity2 $self_$39807;
		}
	}

	// Token: 0x0200166B RID: 5739
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$39809 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008539 RID: 34105 RVA: 0x010B01E8 File Offset: 0x010AE3E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$39809(M603_ShadeInTheCity2 self_)
		{
			if (180736 - 589389 != -408652)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (161676 - 454464 != -292787)
				{
					base..ctor();
					if (193133 - 358324 == -165191)
					{
						this.$self_$39815 = self_;
						if (46585 - 578205 != -531619)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600853A RID: 34106 RVA: 0x010B0280 File Offset: 0x010AE480
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity2.$TalkToPanther$39809.$(this.$self_$39815);
		}

		// Token: 0x0600853B RID: 34107 RVA: 0x010B0290 File Offset: 0x010AE490
		internal static bool V9i7bypzcMNF7JvuswBu()
		{
			return true;
		}

		// Token: 0x0600853C RID: 34108 RVA: 0x010B0294 File Offset: 0x010AE494
		internal static bool suWjYRpzUj1h1GvkQ7cQ()
		{
			return false;
		}

		// Token: 0x04008211 RID: 33297
		internal M603_ShadeInTheCity2 $self_$39815;

		// Token: 0x0200166C RID: 5740
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600853D RID: 34109 RVA: 0x010B0298 File Offset: 0x010AE498
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity2 self_)
			{
				if (260301 - 532561 != -272259)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109624 - 295332 != -185707)
					{
						base..ctor();
						if (84379 - 173870 != -89490)
						{
							this.$self_$39814 = self_;
							if (121337 - 93352 != 27986)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600853E RID: 34110 RVA: 0x010B0330 File Offset: 0x010AE530
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (86301 - 355228 != -268926)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_428;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (9575 - 321059 != -311484)
							{
								continue;
							}
							goto IL_351;
						}
						else
						{
							this.$nMessage$39813 = Language.getMessage("M603_ShadeInTheCity", 6043);
							if (249349 - 306665 != -57316)
							{
								continue;
							}
							this.$mStoryGui$39811.newStoryMessage("none", "Panther", this.$nMessage$39813, eTalkType.friend);
							if (269911 - 25406 != 244505)
							{
								continue;
							}
							goto IL_200;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (154553 - 592197 != -437643)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39811.close();
							if (292296 - 259767 == 32530)
							{
								continue;
							}
							this.$mGameGui$39810.enabled = true;
							if (241895 - 223010 != 18885)
							{
								continue;
							}
							goto IL_265;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (137072 - 553644 != -416572)
							{
								continue;
							}
							goto IL_17B;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (31818 - 490433 != -458615)
							{
								continue;
							}
							goto IL_1DE;
						}
						break;
					default:
						if (2264 - 262204 != -259940)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (156995 - 570656 != -413660)
						{
							goto Block_7;
						}
						continue;
					}
					else
					{
						this.$mGameGui$39810 = (GameGui)this.$self_$39814.GetComponent(typeof(GameGui));
						if (92148 - 23445 == 68704)
						{
							continue;
						}
						this.$mStoryGui$39811 = (StoryGui)this.$self_$39814.GetComponent(typeof(StoryGui));
						if (141958 - 92236 == 49723)
						{
							continue;
						}
						if (this.$mGameGui$39810)
						{
							if (214498 - 498141 == -283642)
							{
								continue;
							}
							if (this.$mStoryGui$39811)
							{
								if (181397 - 229904 == -48506)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (184639 - 188034 != -3395)
								{
									continue;
								}
								this.$mGameGui$39810.close();
								if (114721 - 313686 != -198965)
								{
									continue;
								}
								this.$mPanther$39812 = GameObject.Find("Panther");
								if (125280 - 78302 == 46979)
								{
									continue;
								}
								if (this.$mPanther$39812)
								{
									if (170280 - 439710 == -269429)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mPanther$39812.transform.position);
									if (227327 - 82748 != 144579)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Panther");
									if (95104 - 267894 == -172789)
									{
										continue;
									}
								}
								this.$mStoryGui$39811.startStoryMessage("none", "Panther", eTalkType.friend);
								if (226942 - 410445 != -183502)
								{
									break;
								}
								continue;
							}
						}
					}
					IL_1DE:
					this.YieldDefault(1);
					if (193203 - 319613 == -126410)
					{
						goto IL_428;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_7:
				IL_17B:
				goto IL_428;
				IL_200:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_15:
				goto IL_428;
				IL_265:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_351:
				IL_428:
				return false;
			}

			// Token: 0x0600853F RID: 34111 RVA: 0x010B0778 File Offset: 0x010AE978
			internal static bool yMmu6opzTufZsr5ZRXkr()
			{
				return true;
			}

			// Token: 0x06008540 RID: 34112 RVA: 0x010B077C File Offset: 0x010AE97C
			internal static bool rRnR65pz3n0J8LTe5No8()
			{
				return false;
			}

			// Token: 0x04008212 RID: 33298
			internal GameGui $mGameGui$39810;

			// Token: 0x04008213 RID: 33299
			internal StoryGui $mStoryGui$39811;

			// Token: 0x04008214 RID: 33300
			internal GameObject $mPanther$39812;

			// Token: 0x04008215 RID: 33301
			internal string $nMessage$39813;

			// Token: 0x04008216 RID: 33302
			internal M603_ShadeInTheCity2 $self_$39814;
		}
	}

	// Token: 0x0200166D RID: 5741
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToHumpback$39816 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008541 RID: 34113 RVA: 0x010B0780 File Offset: 0x010AE980
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToHumpback$39816(M603_ShadeInTheCity2 self_)
		{
			if (260101 - 427550 != -167448)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (97800 - 112372 == -14572)
				{
					base..ctor();
					if (48363 - 519664 == -471301)
					{
						this.$self_$39822 = self_;
						if (43009 - 88054 != -45044)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008542 RID: 34114 RVA: 0x010B0818 File Offset: 0x010AEA18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity2.$TalkToHumpback$39816.$(this.$self_$39822);
		}

		// Token: 0x06008543 RID: 34115 RVA: 0x010B0828 File Offset: 0x010AEA28
		internal static bool X3tdUBpzXvpYoEIE75li()
		{
			return true;
		}

		// Token: 0x06008544 RID: 34116 RVA: 0x010B082C File Offset: 0x010AEA2C
		internal static bool qujvTmpzQh3WtJ5cc1Y0()
		{
			return false;
		}

		// Token: 0x04008217 RID: 33303
		internal M603_ShadeInTheCity2 $self_$39822;

		// Token: 0x0200166E RID: 5742
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008545 RID: 34117 RVA: 0x010B0830 File Offset: 0x010AEA30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity2 self_)
			{
				if (99676 - 138727 != -39051)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (248271 - 569757 == -321486)
					{
						base..ctor();
						if (295375 - 564786 != -269410)
						{
							this.$self_$39821 = self_;
							if (131016 - 591660 == -460644)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008546 RID: 34118 RVA: 0x010B08C8 File Offset: 0x010AEAC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (119256 - 80277 != 38980)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_428;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (282876 - 136912 != 145965)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$nMessage$39820 = Language.getMessage("M603_ShadeInTheCity", 6037);
							if (21827 - 581757 != -559930)
							{
								continue;
							}
							this.$mStoryGui$39818.newStoryMessage("Humpback", "Jamon", this.$nMessage$39820, eTalkType.friend);
							if (70413 - 104604 != -34191)
							{
								continue;
							}
							goto IL_32D;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (49202 - 385255 != -336052)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39818.close();
							if (80736 - 334108 != -253372)
							{
								continue;
							}
							this.$mGameGui$39817.enabled = true;
							if (157057 - 550906 != -393848)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (222394 - 49933 != 172462)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (248719 - 221163 != 27556)
							{
								continue;
							}
							goto IL_A4;
						}
						break;
					default:
						if (66926 - 295048 != -228122)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (39367 - 587048 != -547680)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mGameGui$39817 = (GameGui)this.$self_$39821.GetComponent(typeof(GameGui));
						if (15588 - 553712 != -538124)
						{
							continue;
						}
						this.$mStoryGui$39818 = (StoryGui)this.$self_$39821.GetComponent(typeof(StoryGui));
						if (7596 - 229646 != -222050)
						{
							continue;
						}
						if (this.$mGameGui$39817)
						{
							if (99507 - 321437 != -221930)
							{
								continue;
							}
							if (this.$mStoryGui$39818)
							{
								if (222575 - 392463 == -169887)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (180969 - 198618 == -17648)
								{
									continue;
								}
								this.$mGameGui$39817.close();
								if (49911 - 514971 == -465059)
								{
									continue;
								}
								this.$mPanther$39819 = GameObject.Find("Humpback");
								if (147384 - 555359 == -407974)
								{
									continue;
								}
								if (this.$mPanther$39819)
								{
									if (104487 - 174 != 104313)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mPanther$39819.transform.position);
									if (174306 - 302268 == -127961)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Panther");
									if (115898 - 60777 == 55122)
									{
										continue;
									}
								}
								this.$mStoryGui$39818.startStoryMessage("Humpback", "Jamon", eTalkType.friend);
								if (43056 - 272982 != -229925)
								{
									goto Block_7;
								}
								continue;
							}
						}
					}
					IL_A4:
					this.YieldDefault(1);
				}
				while (254835 - 525036 == -270200);
				goto IL_428;
				Block_7:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_428;
				Block_11:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_32D:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_24:
				Block_26:
				Block_28:
				IL_428:
				return false;
			}

			// Token: 0x06008547 RID: 34119 RVA: 0x010B0D10 File Offset: 0x010AEF10
			internal static bool NNOd1ppzkcitXdSVc7dj()
			{
				return true;
			}

			// Token: 0x06008548 RID: 34120 RVA: 0x010B0D14 File Offset: 0x010AEF14
			internal static bool ATAxKXpzGT5qkKdQ2gRV()
			{
				return false;
			}

			// Token: 0x04008218 RID: 33304
			internal GameGui $mGameGui$39817;

			// Token: 0x04008219 RID: 33305
			internal StoryGui $mStoryGui$39818;

			// Token: 0x0400821A RID: 33306
			internal GameObject $mPanther$39819;

			// Token: 0x0400821B RID: 33307
			internal string $nMessage$39820;

			// Token: 0x0400821C RID: 33308
			internal M603_ShadeInTheCity2 $self_$39821;
		}
	}

	// Token: 0x0200166F RID: 5743
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$39823 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008549 RID: 34121 RVA: 0x010B0D18 File Offset: 0x010AEF18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$39823(M603_ShadeInTheCity2 self_)
		{
			if (81155 - 126969 != -45813)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (247941 - 342239 != -94297)
				{
					base..ctor();
					if (220795 - 570537 == -349742)
					{
						this.$self_$39826 = self_;
						if (203310 - 218034 != -14723)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600854A RID: 34122 RVA: 0x010B0DB0 File Offset: 0x010AEFB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity2.$StartGame$39823.$(this.$self_$39826);
		}

		// Token: 0x0600854B RID: 34123 RVA: 0x010B0DC0 File Offset: 0x010AEFC0
		internal static bool jtIq9EpzH5GeItn4nuOS()
		{
			return true;
		}

		// Token: 0x0600854C RID: 34124 RVA: 0x010B0DC4 File Offset: 0x010AEFC4
		internal static bool A8tpLvpzWOuJbTaGTEgm()
		{
			return false;
		}

		// Token: 0x0400821D RID: 33309
		internal M603_ShadeInTheCity2 $self_$39826;

		// Token: 0x02001670 RID: 5744
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600854D RID: 34125 RVA: 0x010B0DC8 File Offset: 0x010AEFC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity2 self_)
			{
				if (212945 - 194097 != 18848)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (223738 - 446546 != -222807)
					{
						base..ctor();
						if (180190 - 160319 != 19872)
						{
							this.$self_$39825 = self_;
							if (24862 - 351528 == -326666)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600854E RID: 34126 RVA: 0x010B0E60 File Offset: 0x010AF060
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (21448 - 213502 != -192054)
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
						if (93121 - 284208 == -191086)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (299288 - 11837 == 287452)
						{
							continue;
						}
						this.YieldDefault(1);
						if (7346 - 519561 != -512214)
						{
							goto Block_10;
						}
						continue;
					default:
						if (62085 - 180061 == -117975)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (284416 - 41514 == 242902)
					{
						Game.mGameState = eGameState.Start;
						if (159606 - 539230 == -379624)
						{
							Game.mStateTime = Time.time;
							if (163287 - 356184 != -192896)
							{
								this.$mGameGui$39824 = (GameGui)this.$self_$39825.GetComponent(typeof(GameGui));
								if (235217 - 576881 == -341664)
								{
									this.$mGameGui$39824.enabled = true;
									if (206319 - 433539 == -227220)
									{
										this.$self_$39825.SendMessage("fadeIn");
										if (245493 - 59603 != 185891)
										{
											goto Block_11;
										}
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_1B9;
				Block_11:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x0600854F RID: 34127 RVA: 0x010B1038 File Offset: 0x010AF238
			internal static bool Q9jduEpzA4MqjKDgO69T()
			{
				return true;
			}

			// Token: 0x06008550 RID: 34128 RVA: 0x010B103C File Offset: 0x010AF23C
			internal static bool gaDcKOpzlp806LyTJ0f3()
			{
				return false;
			}

			// Token: 0x0400821E RID: 33310
			internal GameGui $mGameGui$39824;

			// Token: 0x0400821F RID: 33311
			internal M603_ShadeInTheCity2 $self_$39825;
		}
	}

	// Token: 0x02001671 RID: 5745
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39827 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008551 RID: 34129 RVA: 0x010B1040 File Offset: 0x010AF240
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39827(M603_ShadeInTheCity2 self_)
		{
			if (191602 - 456417 != -264814)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (281398 - 196862 == 84536)
				{
					base..ctor();
					if (167255 - 293226 != -125970)
					{
						this.$self_$39832 = self_;
						if (263266 - 384341 == -121075)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008552 RID: 34130 RVA: 0x010B10D8 File Offset: 0x010AF2D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity2.$onDeadPlayer$39827.$(this.$self_$39832);
		}

		// Token: 0x06008553 RID: 34131 RVA: 0x010B10E8 File Offset: 0x010AF2E8
		internal static bool tDnwbGpzyWcNlpMuv74m()
		{
			return true;
		}

		// Token: 0x06008554 RID: 34132 RVA: 0x010B10EC File Offset: 0x010AF2EC
		internal static bool w4USjKpzS10YKF7xIPj7()
		{
			return false;
		}

		// Token: 0x04008220 RID: 33312
		internal M603_ShadeInTheCity2 $self_$39832;

		// Token: 0x02001672 RID: 5746
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008555 RID: 34133 RVA: 0x010B10F0 File Offset: 0x010AF2F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity2 self_)
			{
				if (176425 - 187770 != -11345)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (276902 - 65992 != 210911)
					{
						base..ctor();
						if (45241 - 360838 == -315597)
						{
							this.$self_$39831 = self_;
							if (181719 - 238732 == -57013)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008556 RID: 34134 RVA: 0x010B1188 File Offset: 0x010AF388
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (216273 - 538528 != -322255)
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
							if (213851 - 49743 == 164109)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1C3;
							}
							if (63090 - 240323 == -177232)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (141239 - 595721 != -454482)
						{
							continue;
						}
						this.$mStoryGui$39828 = (StoryGui)this.$self_$39831.GetComponent(typeof(StoryGui));
						if (86198 - 9037 != 77161)
						{
							continue;
						}
						if (this.$mStoryGui$39828)
						{
							if (297614 - 468562 != -170948)
							{
								continue;
							}
							this.$mStoryGui$39828.close();
							if (81590 - 34088 == 47503)
							{
								continue;
							}
						}
						this.$mChangeGui$39829 = (ChangeGui)this.$self_$39831.GetComponent(typeof(ChangeGui));
						if (242890 - 281146 != -38256)
						{
							continue;
						}
						if (this.$mChangeGui$39829)
						{
							if (28477 - 573166 == -544688)
							{
								continue;
							}
							this.$mChangeGui$39829.close();
							if (125815 - 61165 == 64651)
							{
								continue;
							}
						}
						this.$mGameGui$39830 = (GameGui)this.$self_$39831.GetComponent(typeof(GameGui));
						if (82657 - 473518 != -390861)
						{
							continue;
						}
						if (this.$mGameGui$39830)
						{
							if (256023 - 514351 == -258327)
							{
								continue;
							}
							if (!this.$mGameGui$39830.enabled)
							{
								if (57723 - 83354 == -25630)
								{
									continue;
								}
								this.$mGameGui$39830.enabled = true;
								if (35323 - 79347 == -44023)
								{
									continue;
								}
							}
							this.$mGameGui$39830.openDeadMenu();
							if (93082 - 273340 != -180258)
							{
								continue;
							}
						}
						IL_1C3:
						this.YieldDefault(1);
						if (173056 - 406869 != -233813)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (71004 - 545006 == -474001)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (140307 - 568546 == -428238);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008557 RID: 34135 RVA: 0x010B14A0 File Offset: 0x010AF6A0
			internal static bool keIpp1pzoseds75cVV0I()
			{
				return true;
			}

			// Token: 0x06008558 RID: 34136 RVA: 0x010B14A4 File Offset: 0x010AF6A4
			internal static bool OOg966pzEwYyZTIjIAIj()
			{
				return false;
			}

			// Token: 0x04008221 RID: 33313
			internal StoryGui $mStoryGui$39828;

			// Token: 0x04008222 RID: 33314
			internal ChangeGui $mChangeGui$39829;

			// Token: 0x04008223 RID: 33315
			internal GameGui $mGameGui$39830;

			// Token: 0x04008224 RID: 33316
			internal M603_ShadeInTheCity2 $self_$39831;
		}
	}

	// Token: 0x02001673 RID: 5747
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39833 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008559 RID: 34137 RVA: 0x010B14A8 File Offset: 0x010AF6A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39833(M603_ShadeInTheCity2 self_)
		{
			if (297989 - 379845 != -81855)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (54083 - 350304 != -296220)
				{
					base..ctor();
					if (210994 - 405695 == -194701)
					{
						this.$self_$39837 = self_;
						if (269253 - 118002 == 151251)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600855A RID: 34138 RVA: 0x010B1540 File Offset: 0x010AF740
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity2.$ReturnToTown$39833.$(this.$self_$39837);
		}

		// Token: 0x0600855B RID: 34139 RVA: 0x010B1550 File Offset: 0x010AF750
		internal static bool uF75eDpz2J6FpOf4Ned2()
		{
			return true;
		}

		// Token: 0x0600855C RID: 34140 RVA: 0x010B1554 File Offset: 0x010AF754
		internal static bool OD6UHDpz8XBgKHgUJ7tu()
		{
			return false;
		}

		// Token: 0x04008225 RID: 33317
		internal M603_ShadeInTheCity2 $self_$39837;

		// Token: 0x02001674 RID: 5748
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600855D RID: 34141 RVA: 0x010B1558 File Offset: 0x010AF758
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity2 self_)
			{
				if (13643 - 108065 != -94422)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14287 - 81921 == -67634)
					{
						base..ctor();
						if (258957 - 208516 == 50441)
						{
							this.$self_$39836 = self_;
							if (111713 - 194364 == -82651)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600855E RID: 34142 RVA: 0x010B15F0 File Offset: 0x010AF7F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (288351 - 464952 != -176600)
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
						this.$self_$39836.LeaveGame();
						if (289177 - 26962 != 262215)
						{
							continue;
						}
						this.YieldDefault(1);
						if (250329 - 142055 != 108275)
						{
							goto Block_14;
						}
						continue;
					default:
						if (279934 - 233071 != 46863)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (129703 - 310463 == -180760)
					{
						Game.mStateTime = Time.time;
						if (2970 - 68498 != -65527)
						{
							this.$$switch$7022$39834 = PlayerData.SaveGuild;
							if (62978 - 298667 != -235688)
							{
								if (this.$$switch$7022$39834 == 1)
								{
									if (134317 - 397729 != -263412)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (122950 - 549502 != -426552)
									{
										continue;
									}
								}
								else if (this.$$switch$7022$39834 == 2)
								{
									if (227734 - 571517 != -343783)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (298686 - 355624 != -56938)
									{
										continue;
									}
								}
								else if (this.$$switch$7022$39834 == 3)
								{
									if (156411 - 267566 != -111155)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (281568 - 416513 == -134944)
									{
										continue;
									}
								}
								else if (this.$$switch$7022$39834 == 4)
								{
									if (48231 - 575761 != -527530)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (256021 - 413002 != -156981)
									{
										continue;
									}
								}
								else if (this.$$switch$7022$39834 == 5)
								{
									if (175108 - 322222 == -147113)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (135721 - 302248 != -166527)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (121227 - 342833 != -221606)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (150760 - 273764 != -123004)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (223006 - 33250 != 189756)
									{
										continue;
									}
								}
								this.$mGameGui$39835 = (GameGui)this.$self_$39836.GetComponent(typeof(GameGui));
								if (49438 - 563331 != -513892)
								{
									if (this.$mGameGui$39835)
									{
										if (102128 - 8451 != 93677)
										{
											continue;
										}
										this.$mGameGui$39835.close();
										if (53036 - 175095 == -122058)
										{
											continue;
										}
									}
									this.$self_$39836.SendMessage("fadeOut");
									if (33820 - 149452 == -115632)
									{
										goto IL_1D8;
									}
								}
							}
						}
					}
				}
				Block_14:
				goto IL_3AD;
				IL_1D8:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600855F RID: 34143 RVA: 0x010B19BC File Offset: 0x010AFBBC
			internal static bool EJ1je1pzZmQv2g5n2aem()
			{
				return true;
			}

			// Token: 0x06008560 RID: 34144 RVA: 0x010B19C0 File Offset: 0x010AFBC0
			internal static bool OKsUyspzCQTJSVIoNHWA()
			{
				return false;
			}

			// Token: 0x04008226 RID: 33318
			internal int $$switch$7022$39834;

			// Token: 0x04008227 RID: 33319
			internal GameGui $mGameGui$39835;

			// Token: 0x04008228 RID: 33320
			internal M603_ShadeInTheCity2 $self_$39836;
		}
	}

	// Token: 0x02001675 RID: 5749
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39838 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008561 RID: 34145 RVA: 0x010B19C4 File Offset: 0x010AFBC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39838(M603_ShadeInTheCity2 self_)
		{
			if (92968 - 503174 != -410205)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (161174 - 254194 == -93020)
				{
					base..ctor();
					if (21939 - 495938 != -473998)
					{
						this.$self_$39841 = self_;
						if (134122 - 392690 != -258567)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008562 RID: 34146 RVA: 0x010B1A5C File Offset: 0x010AFC5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity2.$ReturnToGuild$39838.$(this.$self_$39841);
		}

		// Token: 0x06008563 RID: 34147 RVA: 0x010B1A6C File Offset: 0x010AFC6C
		internal static bool xFU84xpzL4vUceLVoOg2()
		{
			return true;
		}

		// Token: 0x06008564 RID: 34148 RVA: 0x010B1A70 File Offset: 0x010AFC70
		internal static bool RxYgsFpzOr7PjJN9OFfZ()
		{
			return false;
		}

		// Token: 0x04008229 RID: 33321
		internal M603_ShadeInTheCity2 $self_$39841;

		// Token: 0x02001676 RID: 5750
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008565 RID: 34149 RVA: 0x010B1A74 File Offset: 0x010AFC74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity2 self_)
			{
				if (35104 - 432709 != -397604)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (155168 - 140672 != 14497)
					{
						base..ctor();
						if (188588 - 233788 != -45199)
						{
							this.$self_$39840 = self_;
							if (161203 - 164672 != -3468)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008566 RID: 34150 RVA: 0x010B1B0C File Offset: 0x010AFD0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (248738 - 154503 != 94236)
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
						this.$self_$39840.LeaveGame();
						if (180057 - 34250 == 145808)
						{
							continue;
						}
						this.YieldDefault(1);
						if (133512 - 510881 != -377369)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (161641 - 191069 != -29428)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (228738 - 118219 != 110520)
					{
						Game.mStateTime = Time.time;
						if (181900 - 523415 != -341514)
						{
							Game.mNextGameCode = 31;
							if (165952 - 492345 != -326392)
							{
								this.$mGameGui$39839 = (GameGui)this.$self_$39840.GetComponent(typeof(GameGui));
								if (67517 - 194448 == -126931)
								{
									if (this.$mGameGui$39839)
									{
										if (127375 - 445977 == -318601)
										{
											continue;
										}
										this.$mGameGui$39839.close();
										if (189590 - 152132 == 37459)
										{
											continue;
										}
									}
									this.$self_$39840.SendMessage("fadeOut");
									if (230906 - 79635 == 151271)
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

			// Token: 0x06008567 RID: 34151 RVA: 0x010B1CE8 File Offset: 0x010AFEE8
			internal static bool hEs2O6pzmTyPVfY9YJ6S()
			{
				return true;
			}

			// Token: 0x06008568 RID: 34152 RVA: 0x010B1CEC File Offset: 0x010AFEEC
			internal static bool lJ3ck7pzFk6sfpaj1MSY()
			{
				return false;
			}

			// Token: 0x0400822A RID: 33322
			internal GameGui $mGameGui$39839;

			// Token: 0x0400822B RID: 33323
			internal M603_ShadeInTheCity2 $self_$39840;
		}
	}

	// Token: 0x02001677 RID: 5751
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39842 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008569 RID: 34153 RVA: 0x010B1CF0 File Offset: 0x010AFEF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39842(M603_ShadeInTheCity2 self_)
		{
			if (29317 - 501549 != -472231)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (145171 - 164352 != -19180)
				{
					base..ctor();
					if (186957 - 557304 != -370346)
					{
						this.$self_$39846 = self_;
						if (254271 - 30875 != 223397)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600856A RID: 34154 RVA: 0x010B1D88 File Offset: 0x010AFF88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M603_ShadeInTheCity2.$ReturnToCamp$39842.$(this.$self_$39846);
		}

		// Token: 0x0600856B RID: 34155 RVA: 0x010B1D98 File Offset: 0x010AFF98
		internal static bool nBvEE8pzMmWa1QB7xsa1()
		{
			return true;
		}

		// Token: 0x0600856C RID: 34156 RVA: 0x010B1D9C File Offset: 0x010AFF9C
		internal static bool VeM646pzxFvQ7i66m5rR()
		{
			return false;
		}

		// Token: 0x0400822C RID: 33324
		internal M603_ShadeInTheCity2 $self_$39846;

		// Token: 0x02001678 RID: 5752
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600856D RID: 34157 RVA: 0x010B1DA0 File Offset: 0x010AFFA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M603_ShadeInTheCity2 self_)
			{
				if (95230 - 384374 != -289144)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (1396 - 175410 != -174013)
					{
						base..ctor();
						if (279959 - 239591 != 40369)
						{
							this.$self_$39845 = self_;
							if (284686 - 103344 == 181342)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600856E RID: 34158 RVA: 0x010B1E38 File Offset: 0x010B0038
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (208572 - 442665 != -234092)
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
						this.$self_$39845.LeaveGame();
						if (138253 - 172819 == -34565)
						{
							continue;
						}
						this.YieldDefault(1);
						if (266679 - 165985 != 100695)
						{
							goto Block_22;
						}
						continue;
					default:
						if (198204 - 454773 != -256569)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (49265 - 340434 == -291169)
					{
						Game.mStateTime = Time.time;
						if (5275 - 293998 != -288722)
						{
							this.$$switch$7024$39843 = PlayerData.SaveGuild;
							if (269687 - 529594 == -259907)
							{
								if (this.$$switch$7024$39843 == 1)
								{
									if (16846 - 582326 == -565479)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (271372 - 547240 != -275868)
									{
										continue;
									}
								}
								else if (this.$$switch$7024$39843 == 2)
								{
									if (228570 - 424995 != -196425)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (81343 - 541428 != -460085)
									{
										continue;
									}
								}
								else if (this.$$switch$7024$39843 == 3)
								{
									if (275164 - 530183 != -255019)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (187631 - 146248 == 41384)
									{
										continue;
									}
								}
								else if (this.$$switch$7024$39843 == 4)
								{
									if (207008 - 577717 == -370708)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (107136 - 465532 != -358396)
									{
										continue;
									}
								}
								else if (this.$$switch$7024$39843 == 5)
								{
									if (170865 - 394471 != -223606)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (13811 - 552247 == -538435)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (237594 - 323146 == -85551)
									{
										continue;
									}
								}
								this.$mGameGui$39844 = (GameGui)this.$self_$39845.GetComponent(typeof(GameGui));
								if (179517 - 395924 != -216406)
								{
									if (this.$mGameGui$39844)
									{
										if (216935 - 377101 == -160165)
										{
											continue;
										}
										this.$mGameGui$39844.close();
										if (101897 - 67262 == 34636)
										{
											continue;
										}
									}
									this.$self_$39845.SendMessage("fadeOut");
									if (13947 - 457855 == -443908)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_22:
				IL_363:
				return false;
			}

			// Token: 0x0600856F RID: 34159 RVA: 0x010B21BC File Offset: 0x010B03BC
			internal static bool Gb1ZeMpzgqjsKYeRGabh()
			{
				return true;
			}

			// Token: 0x06008570 RID: 34160 RVA: 0x010B21C0 File Offset: 0x010B03C0
			internal static bool csUcdtpzfA02aLEPexWg()
			{
				return false;
			}

			// Token: 0x0400822D RID: 33325
			internal int $$switch$7024$39843;

			// Token: 0x0400822E RID: 33326
			internal GameGui $mGameGui$39844;

			// Token: 0x0400822F RID: 33327
			internal M603_ShadeInTheCity2 $self_$39845;
		}
	}
}
