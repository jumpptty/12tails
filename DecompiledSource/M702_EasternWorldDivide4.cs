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

// Token: 0x02001706 RID: 5894
[Serializable]
public class M702_EasternWorldDivide4 : MonoBehaviour
{
	// Token: 0x060088E1 RID: 35041 RVA: 0x010E56C4 File Offset: 0x010E38C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M702_EasternWorldDivide4()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060088E2 RID: 35042 RVA: 0x010E56D4 File Offset: 0x010E38D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (144485 - 267550 != -123065)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (281316 - 491579 != -210262)
			{
				Game.mGameType = 5;
				if (75516 - 463046 == -387530)
				{
					if (Chat.Initialized)
					{
						if (167660 - 171366 == -3706)
						{
							Chat.ChatDisplay.Clear();
							if (237369 - 475905 != -238535)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (164913 - 131112 != 33802)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060088E3 RID: 35043 RVA: 0x010E57B8 File Offset: 0x010E39B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (54137 - 581382 != -527245)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (171165 - 111057 == 60108)
				{
					if (Game.mNextGameCode != 702)
					{
						break;
					}
					if (256636 - 129033 == 127603)
					{
						if (Game.mGameStage != 4)
						{
							break;
						}
						if (179223 - 438511 != -259287)
						{
							Game.nextGame();
							if (129676 - 277145 == -147469)
							{
								this.AI6cyaOJjsI = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (236465 - 536430 != -299964)
								{
									this.yHqcygAR5VR = PhotonClient.Connection;
									if (272599 - 237240 != 35360)
									{
										PhotonClient.ActorNrList.Clear();
										if (145001 - 225269 == -80268)
										{
											this.InitGame();
											if (214010 - 104448 == 109562)
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
				if (230707 - 321955 == -91248)
				{
					Game.mGameType = 99;
					if (298479 - 481073 != -182593)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060088E4 RID: 35044 RVA: 0x010E5970 File Offset: 0x010E3B70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (148125 - 259078 != -110952)
		{
		}
		for (;;)
		{
			if (this.yHqcygAR5VR == null)
			{
				if (100074 - 72589 == 27485)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (194360 - 516780 != -322419)
				{
					if (mGameState == eGameState.Init)
					{
						if (179937 - 544647 != -364709)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (61643 - 482621 == -420978)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (191104 - 167947 != 23158)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (7932 - 133437 == -125505)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (256532 - 586995 != -330462)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (60094 - 402946 == -342852)
						{
							if (Time.time > this.txicy42nhwo)
							{
								if (98463 - 208640 != -110177)
								{
									continue;
								}
								Game.mGameMana++;
								if (284671 - 327111 != -42440)
								{
									continue;
								}
								this.txicy42nhwo = Time.time + (float)12;
								if (251835 - 296015 != -44180)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (84724 - 406297 == -321572)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (7313 - 104141 != -96828)
									{
										continue;
									}
									this.audio.Play();
									if (50742 - 450709 == -399966)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (50754 - 240108 == -189354)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (213280 - 531685 == -318405)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (264347 - 401045 != -136697)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (107458 - 89983 == 17475)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (117277 - 402240 != -284962)
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
						if (103447 - 378480 == -275033)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060088E5 RID: 35045 RVA: 0x010E5CEC File Offset: 0x010E3EEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (180457 - 309245 != -128787)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (259923 - 394715 != -134791)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (262252 - 252643 == 9609)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (234913 - 210270 == 24643)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (184763 - 585808 != -401044)
						{
							int num4 = num;
							if (52606 - 525435 != -472828)
							{
								if (num4 == 7021)
								{
									if (155721 - 321910 == -166189)
									{
										break;
									}
								}
								else if (num4 == 7022)
								{
									if (200384 - 78900 != 121485)
									{
										break;
									}
								}
								else if (num4 == 7023)
								{
									if (87816 - 49781 != 38036)
									{
										break;
									}
								}
								else if (num4 == 7024)
								{
									if (262207 - 550269 != -288061)
									{
										break;
									}
								}
								else if (num4 == 7025)
								{
									if (198627 - 279637 != -81009)
									{
										break;
									}
								}
								else if (num4 == 7026)
								{
									if (160463 - 504891 == -344428)
									{
										break;
									}
								}
								else
								{
									if (num4 != -7026)
									{
										break;
									}
									if (137129 - 341053 == -203924)
									{
										if (this.pBacysMU7Al >= 2)
										{
											break;
										}
										if (97695 - 10348 != 87348)
										{
											this.pBacysMU7Al = 2;
											if (240583 - 266621 == -26038)
											{
												this.StartCoroutine_Auto(this.TalkToItalusEvent());
												if (278074 - 159007 != 119068)
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

	// Token: 0x060088E6 RID: 35046 RVA: 0x010E5F8C File Offset: 0x010E418C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToItalusEvent()
	{
		return new M702_EasternWorldDivide4.$TalkToItalusEvent$40264(this).GetEnumerator();
	}

	// Token: 0x060088E7 RID: 35047 RVA: 0x010E5F9C File Offset: 0x010E419C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToFalcon()
	{
		if (275139 - 44643 != 230496)
		{
		}
		for (;;)
		{
			Debug.Log("TalkToFalcon");
			if (226051 - 231191 == -5140)
			{
				if (this.pBacysMU7Al >= 1)
				{
					break;
				}
				if (137428 - 356570 != -219141)
				{
					this.pBacysMU7Al = 1;
					if (128640 - 126275 == 2365)
					{
						Game.sendMissionEvent(7026, 0);
						if (287515 - 429350 == -141835)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060088E8 RID: 35048 RVA: 0x010E6064 File Offset: 0x010E4264
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (202189 - 48434 != 153756)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (74354 - 499003 != -424648)
			{
				Time.timeScale = 1f;
				if (237908 - 233784 == 4124)
				{
					Hashtable customOpParameters = new Hashtable();
					if (137049 - 377224 == -240175)
					{
						this.yHqcygAR5VR.OpCustom(52, customOpParameters, true);
						if (286520 - 51694 != 234827)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060088E9 RID: 35049 RVA: 0x010E6130 File Offset: 0x010E4330
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (124813 - 516365 != -391551)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (158779 - 530252 != -371472)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (211169 - 517652 == -306483)
				{
					Game.mGameState = eGameState.Setup;
					if (11373 - 97931 == -86558)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060088EA RID: 35050 RVA: 0x010E61D4 File Offset: 0x010E43D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (258670 - 535796 != -277126)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (221592 - 438430 != -216837)
			{
				if (num == PlayerData.UID)
				{
					if (57241 - 114608 == -57367)
					{
						this.SetupActors();
						if (282041 - 8007 != 274035)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (62140 - 382366 != -320225)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060088EB RID: 35051 RVA: 0x010E62A4 File Offset: 0x010E44A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (88436 - 295304 != -206867)
		{
		}
		for (;;)
		{
			IL_1D4:
			Debug.Log("Creating Actors");
			if (188289 - 192215 == -3926)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (281302 - 121650 == 159652)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (25644 - 449295 != -423650)
						{
							int i = 0;
							if (211892 - 414876 == -202984)
							{
								CharacterControl[] array2 = array;
								if (20645 - 78424 == -57779)
								{
									int length = array2.Length;
									if (179631 - 284491 == -104860)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (21299 - 457505 != -436206)
												{
													goto IL_1D4;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (146149 - 22205 != 123944)
												{
													goto IL_1D4;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (181729 - 190994 == -9264)
												{
													goto IL_1D4;
												}
												this.kZYcy7y2aGP++;
												if (184776 - 366595 != -181819)
												{
													goto IL_1D4;
												}
											}
											i++;
											if (240606 - 134388 == 106219)
											{
												goto IL_1D4;
											}
										}
										if (132816 - 124200 == 8616)
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
						if (166169 - 181802 == -15633)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060088EC RID: 35052 RVA: 0x010E64E0 File Offset: 0x010E46E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (16226 - 76591 != -60365)
		{
		}
		for (;;)
		{
			IL_38:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (92846 - 309436 == -216590)
			{
				int i = 0;
				if (51935 - 429217 == -377282)
				{
					CharacterControl[] array2 = array;
					if (138254 - 495822 != -357567)
					{
						int length = array2.Length;
						if (197099 - 29799 != 167301)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (89656 - 232650 != -142994)
								{
									goto IL_38;
								}
								i++;
								if (65179 - 272256 != -207077)
								{
									goto IL_38;
								}
							}
							if (6595 - 466689 != -460093)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060088ED RID: 35053 RVA: 0x010E6610 File Offset: 0x010E4810
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (190042 - 453097 != -263055)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (256867 - 88615 == 168252)
			{
				Game.mGameState = eGameState.Ready;
				if (62835 - 233791 != -170955)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (142013 - 433654 != -291640)
					{
						if (26708 - 50950 == -24242)
						{
							GameObject gameObject = null;
							if (257565 - 373974 == -116409)
							{
								if (playerSlot < 1)
								{
									goto IL_12F;
								}
								if (265293 - 248426 == 16868)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_12F;
								}
								if (24281 - 539316 == -515034)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (254437 - 35849 == 218589)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (10754 - 85178 == -74423)
								{
									continue;
								}
								IL_257:
								if (gameObject2)
								{
									if (252596 - 65851 == 186746)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (180151 - 100882 == 79270)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (192795 - 545049 != -352254)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (241921 - 178487 != 63434)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (37349 - 198179 != -160830)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (166364 - 251707 == -85342)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (137190 - 185476 == -48285)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (7927 - 591276 != -583348)
								{
									break;
								}
								continue;
								IL_12F:
								gameObject2 = GameObject.Find("StartPoint1");
								if (256649 - 434662 != -178012)
								{
									goto IL_257;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060088EE RID: 35054 RVA: 0x010E6934 File Offset: 0x010E4B34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M702_EasternWorldDivide4.$StartGame$40280(this).GetEnumerator();
	}

	// Token: 0x060088EF RID: 35055 RVA: 0x010E6944 File Offset: 0x010E4B44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060088F0 RID: 35056 RVA: 0x010E6948 File Offset: 0x010E4B48
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (152068 - 240790 != -88721)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (121568 - 582510 == -460942)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (19477 - 373479 != -354001)
				{
					hashtable.Add(43, PlayerData.UID);
					if (27652 - 566375 != -538722)
					{
						hashtable.Add(73, nType);
						if (219858 - 251105 == -31247)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (136575 - 95130 == 41445)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (193969 - 327972 != -134002)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (101856 - 510056 != -408199)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (17468 - 34054 != -16585)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (211791 - 589127 != -377335)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (231972 - 388199 == -156227)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (247564 - 333387 == -85823)
													{
														this.yHqcygAR5VR.OpCustom(63, hashtable, true);
														if (87307 - 342597 != -255289)
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

	// Token: 0x060088F1 RID: 35057 RVA: 0x010E6C2C File Offset: 0x010E4E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (287899 - 461686 != -173787)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (133622 - 533749 != -400126)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (29269 - 212895 == -183626)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (138824 - 377909 != -239084)
						{
							if (this.kZYcy7y2aGP <= 0)
							{
								break;
							}
							if (92773 - 334275 != -241501)
							{
								this.kZYcy7y2aGP--;
								if (17919 - 48597 == -30678)
								{
									if (this.kZYcy7y2aGP != 0)
									{
										break;
									}
									if (128799 - 126969 != 1831)
									{
										Game.setGameState(eGameState.Ready);
										if (44102 - 32032 == 12070)
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
						if (14658 - 139057 != -124398)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (291091 - 543419 != -252327)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060088F2 RID: 35058 RVA: 0x010E6DBC File Offset: 0x010E4FBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060088F3 RID: 35059 RVA: 0x010E6DD0 File Offset: 0x010E4FD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (277662 - 131162 != 146501)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (101333 - 133039 == -31706)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (113644 - 569384 == -455740)
				{
					if (!characterControl)
					{
						break;
					}
					if (65636 - 319324 == -253688)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (236232 - 538387 != -302154)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (204185 - 469040 == -264855)
							{
								string type = characterControl.Type;
								if (183639 - 512439 == -328800)
								{
									if (type == "StingBug2_y")
									{
										if (239521 - 572759 == -333238)
										{
											Game.sendMissionEvent(7022, 0);
											if (90858 - 378699 != -287840)
											{
												break;
											}
										}
									}
									else if (type == "LionBug_y")
									{
										if (263192 - 559225 != -296032)
										{
											Game.sendMissionEvent(7023, 0);
											if (145100 - 83198 == 61902)
											{
												break;
											}
										}
									}
									else if (type == "BanditBug1")
									{
										if (146554 - 321636 != -175081)
										{
											Game.sendMissionEvent(7024, 1);
											if (75450 - 168638 != -93187)
											{
												break;
											}
										}
									}
									else if (type == "BanditBug2")
									{
										if (43082 - 279952 != -236869)
										{
											Game.sendMissionEvent(7024, 2);
											if (208689 - 325791 == -117102)
											{
												break;
											}
										}
									}
									else if (type == "BanditBug3")
									{
										if (78849 - 206051 != -127201)
										{
											Game.sendMissionEvent(7024, 3);
											if (171946 - 354522 == -182576)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "CamBot"))
										{
											break;
										}
										if (162327 - 476776 == -314449)
										{
											Game.sendMissionEvent(7025, 0);
											if (174303 - 135502 != 38802)
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

	// Token: 0x060088F4 RID: 35060 RVA: 0x010E70EC File Offset: 0x010E52EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (119017 - 206985 != -87967)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (189808 - 440236 != -250427)
			{
				hashtable.Add(71, CID);
				if (288647 - 352154 != -63506)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (174601 - 532113 == -357512)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (234893 - 410992 != -176098)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (275847 - 402244 != -126396)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (249735 - 75286 == 174449)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (180790 - 342234 != -161443)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (103205 - 567645 != -464439)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (284097 - 90466 != 193632)
											{
												this.yHqcygAR5VR.OpCustom(61, hashtable, true);
												if (232880 - 213033 != 19848)
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

	// Token: 0x060088F5 RID: 35061 RVA: 0x010E7378 File Offset: 0x010E5578
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (115782 - 237663 != -121881)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (166755 - 310332 == -143577)
			{
				if (!gameObject)
				{
					break;
				}
				if (253443 - 125973 == 127470)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (234056 - 120373 == 113683)
					{
						playerCameraControl.target = gameObject;
						if (222677 - 399585 == -176908)
						{
							if (Game.useAdvanceMode)
							{
								if (286205 - 259406 == 26800)
								{
									continue;
								}
								Game.loadPlayer();
								if (46586 - 15925 == 30662)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (251176 - 581671 != -330494)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060088F6 RID: 35062 RVA: 0x010E74B4 File Offset: 0x010E56B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (262644 - 126010 != 136635)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (64559 - 98440 == -33881)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (66100 - 428459 != -362358)
				{
					gameGui.ResetTeamBar();
					if (86586 - 183200 == -96614)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060088F7 RID: 35063 RVA: 0x010E7560 File Offset: 0x010E5760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M702_EasternWorldDivide4.$onDeadPlayer$40284(this).GetEnumerator();
	}

	// Token: 0x060088F8 RID: 35064 RVA: 0x010E7570 File Offset: 0x010E5770
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (175072 - 279439 != -104367)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (38993 - 374205 == -335212)
			{
				this.AI6cyaOJjsI.target = Game.mPlayer;
				if (30139 - 27303 != 2837)
				{
					this.AI6cyaOJjsI.enabled = true;
					if (208207 - 248295 == -40088)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (220759 - 188281 == 32479)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (154497 - 117386 != 37111)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (103591 - 260620 == -157029)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (82100 - 115754 == -33654)
							{
								if (!gameGui)
								{
									break;
								}
								if (107689 - 237538 == -129849)
								{
									gameGui.enabled = true;
									if (104954 - 102412 != 2543)
									{
										gameGui.closeDeadMenu();
										if (72510 - 57211 == 15299)
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

	// Token: 0x060088F9 RID: 35065 RVA: 0x010E771C File Offset: 0x010E591C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (192749 - 482430 != -289680)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (161599 - 583810 == -422211)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (41437 - 314005 == -272568)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (225841 - 5210 == 220631)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060088FA RID: 35066 RVA: 0x010E77E0 File Offset: 0x010E59E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060088FB RID: 35067 RVA: 0x010E780C File Offset: 0x010E5A0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (99691 - 343867 != -244176)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (233976 - 8022 != 225955)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (85023 - 465618 != -380594)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (165129 - 395977 == -230848)
					{
						Hashtable hashtable = new Hashtable();
						if (16781 - 474417 != -457635)
						{
							hashtable.Add(43, PlayerData.UID);
							if (142545 - 584416 == -441871)
							{
								hashtable.Add(71, nCID);
								if (24555 - 278624 != -254068)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (69023 - 330944 != -261920)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (13680 - 7576 == 6104)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (284977 - 367276 != -82298)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (261434 - 219739 != 41696)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (18861 - 273681 != -254819)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (288665 - 85587 != 203079)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (165246 - 538531 != -373284)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (103526 - 451804 == -348278)
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

	// Token: 0x060088FC RID: 35068 RVA: 0x010E7B2C File Offset: 0x010E5D2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M702_EasternWorldDivide4.$onChangePlayer$40290(data, this).GetEnumerator();
	}

	// Token: 0x060088FD RID: 35069 RVA: 0x010E7B3C File Offset: 0x010E5D3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M702_EasternWorldDivide4.$onGameComplete$40297(data, this).GetEnumerator();
	}

	// Token: 0x060088FE RID: 35070 RVA: 0x010E7B4C File Offset: 0x010E5D4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M702_EasternWorldDivide4.$ReturnToTown$40307(this).GetEnumerator();
	}

	// Token: 0x060088FF RID: 35071 RVA: 0x010E7B5C File Offset: 0x010E5D5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M702_EasternWorldDivide4.$ReturnToGuild$40312(this).GetEnumerator();
	}

	// Token: 0x06008900 RID: 35072 RVA: 0x010E7B6C File Offset: 0x010E5D6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M702_EasternWorldDivide4.$ReturnToCamp$40316(this).GetEnumerator();
	}

	// Token: 0x06008901 RID: 35073 RVA: 0x010E7B7C File Offset: 0x010E5D7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (121683 - 566491 != -444807)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (296524 - 98729 != 197796)
			{
				Hashtable hashtable = new Hashtable();
				if (297840 - 163298 != 134543)
				{
					hashtable.Add(43, PlayerData.UID);
					if (50080 - 355609 == -305529)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (156773 - 181487 == -24714)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008902 RID: 35074 RVA: 0x010E7C54 File Offset: 0x010E5E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008903 RID: 35075 RVA: 0x010E7C68 File Offset: 0x010E5E68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (139598 - 328680 != -189082)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (233614 - 180335 == 53279)
			{
				Hashtable hashtable = new Hashtable();
				if (291251 - 562594 != -271342)
				{
					if (Game.mNextGameCode == 30)
					{
						if (82276 - 582763 == -500486)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (120847 - 328217 == -207369)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (233127 - 212303 == 20825)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (170135 - 105792 != 64343)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (6552 - 528604 != -522052)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (162502 - 125239 != 37263)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (125471 - 438411 != -312940)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (101167 - 414745 != -313578)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (68941 - 485963 == -417021)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (67619 - 377673 != -310054)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (135103 - 501259 != -366156)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (75373 - 290628 == -215254)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (118910 - 397589 == -278678)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (236835 - 256513 != -19678)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (260949 - 510600 != -249651)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (243813 - 240077 == 3737)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (75769 - 598191 == -522421)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (89661 - 180674 != -91013)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (244979 - 325075 == -80095)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (266756 - 202498 == 64259)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (27187 - 589266 == -562078)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (282919 - 294681 != -11762)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (283032 - 236641 != 46391)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (266438 - 135576 != 130862)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (83974 - 167649 != -83675)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (125442 - 258793 != -133351)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (10083 - 131974 == -121890)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (259496 - 8245 == 251252)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (182098 - 133433 != 48666)
					{
						this.yHqcygAR5VR.OpCustom(42, hashtable, true);
						if (89242 - 470316 != -381073)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008904 RID: 35076 RVA: 0x010E821C File Offset: 0x010E641C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008905 RID: 35077 RVA: 0x010E822C File Offset: 0x010E642C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008906 RID: 35078 RVA: 0x010E8230 File Offset: 0x010E6430
	internal static bool UHVbQXVtcG7FiptAFhxo()
	{
		return true;
	}

	// Token: 0x06008907 RID: 35079 RVA: 0x010E8234 File Offset: 0x010E6434
	internal static bool t9UoGSVtUfroenjrLhnw()
	{
		return false;
	}

	// Token: 0x040083EE RID: 33774
	private LitePeer yHqcygAR5VR;

	// Token: 0x040083EF RID: 33775
	private PlayerCameraControl AI6cyaOJjsI;

	// Token: 0x040083F0 RID: 33776
	private float txicy42nhwo;

	// Token: 0x040083F1 RID: 33777
	private int pBacysMU7Al;

	// Token: 0x040083F2 RID: 33778
	private float E8XcyHvGchb;

	// Token: 0x040083F3 RID: 33779
	public GameObject mFakeCambot;

	// Token: 0x040083F4 RID: 33780
	public AudioClip mMissionMusic;

	// Token: 0x040083F5 RID: 33781
	private int kZYcy7y2aGP;

	// Token: 0x02001707 RID: 5895
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToItalusEvent$40264 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008908 RID: 35080 RVA: 0x010E8238 File Offset: 0x010E6438
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToItalusEvent$40264(M702_EasternWorldDivide4 self_)
		{
			if (216304 - 33016 != 183289)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (113027 - 295305 != -182277)
				{
					base..ctor();
					if (191991 - 208302 == -16311)
					{
						this.$self_$40279 = self_;
						if (132312 - 282304 == -149992)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008909 RID: 35081 RVA: 0x010E82D0 File Offset: 0x010E64D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide4.$TalkToItalusEvent$40264.$(this.$self_$40279);
		}

		// Token: 0x0600890A RID: 35082 RVA: 0x010E82E0 File Offset: 0x010E64E0
		internal static bool ni8EDMVtTLwqUyDknlcv()
		{
			return true;
		}

		// Token: 0x0600890B RID: 35083 RVA: 0x010E82E4 File Offset: 0x010E64E4
		internal static bool HVdGtFVt37e0hyOKyn9D()
		{
			return false;
		}

		// Token: 0x040083F6 RID: 33782
		internal M702_EasternWorldDivide4 $self_$40279;

		// Token: 0x02001708 RID: 5896
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600890C RID: 35084 RVA: 0x010E82E8 File Offset: 0x010E64E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide4 self_)
			{
				if (182950 - 121094 != 61857)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (33826 - 263965 == -230139)
					{
						base..ctor();
						if (253895 - 108829 != 145067)
						{
							this.$self_$40278 = self_;
							if (267222 - 296237 != -29014)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600890D RID: 35085 RVA: 0x010E8380 File Offset: 0x010E6580
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (89735 - 470037 != -380302)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_16EB;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (246732 - 430811 != -184078)
							{
								goto Block_71;
							}
							continue;
						}
						else
						{
							this.$self_$40278.SendMessage("fadeOut");
							if (183492 - 45724 != 137769)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (261337 - 542898 != -281560)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$self_$40278.SendMessage("alignToObject", "EventCamera1");
							if (75409 - 336338 != -260929)
							{
								continue;
							}
							this.$self_$40278.AI6cyaOJjsI.enabled = false;
							if (180368 - 50944 == 129425)
							{
								continue;
							}
							this.$mItalus$40266 = GameObject.Find("Falcon");
							if (22766 - 512164 != -489398)
							{
								continue;
							}
							this.$mPlayer$40267 = Game.mPlayer;
							if (134935 - 24751 == 110185)
							{
								continue;
							}
							this.$mSpawnPoint$40268 = GameObject.Find("SpawnPoint" + Game.getPlayerSlot(PlayerData.UID));
							if (183271 - 466726 != -283455)
							{
								continue;
							}
							if (this.$mPlayer$40267)
							{
								if (296448 - 155733 != 140715)
								{
									continue;
								}
								if (this.$mSpawnPoint$40268)
								{
									if (242048 - 571552 != -329504)
									{
										continue;
									}
									this.$mPlayer$40267.transform.position = this.$mSpawnPoint$40268.transform.position;
									if (67055 - 347207 == -280151)
									{
										continue;
									}
									this.$mPlayer$40267.transform.rotation = this.$mSpawnPoint$40268.transform.rotation;
									if (161406 - 267369 != -105963)
									{
										continue;
									}
									this.$mPlayer$40267.SendMessage("PositionEvent");
									if (54420 - 285438 != -231018)
									{
										continue;
									}
								}
							}
							if (this.$self_$40278.mMissionMusic)
							{
								if (6653 - 395886 != -389233)
								{
									continue;
								}
								this.$self_$40278.audio.clip = this.$self_$40278.mMissionMusic;
								if (173338 - 595249 != -421911)
								{
									continue;
								}
								this.$self_$40278.audio.Play();
								if (220560 - 291812 == -71251)
								{
									continue;
								}
							}
							this.$self_$40278.SendMessage("fadeIn");
							if (174642 - 360835 == -186192)
							{
								continue;
							}
							this.$mStoryGui$40269 = (StoryGui)this.$self_$40278.GetComponent(typeof(StoryGui));
							if (146898 - 488695 != -341797)
							{
								continue;
							}
							this.$mStoryGui$40269.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (247933 - 292141 != -44208)
							{
								continue;
							}
							goto IL_820;
						}
						break;
					case 4:
						this.$nMessage$40270 = Language.getMessage("M702_EasternWorldDivide", 401);
						if (205627 - 569142 != -363515)
						{
							continue;
						}
						this.$mStoryGui$40269.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$40270, eTalkType.friend);
						if (109627 - 120971 != -11344)
						{
							continue;
						}
						goto IL_22D;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (267510 - 510989 != -243478)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$nMessage$40270 = Language.getMessage("M702_EasternWorldDivide", 402);
							if (238583 - 63765 == 174819)
							{
								continue;
							}
							this.$mStoryGui$40269.newStoryMessage("Falcon", "Italus", this.$nMessage$40270, eTalkType.friend);
							if (39535 - 187657 != -148122)
							{
								continue;
							}
							if (this.$mItalus$40266)
							{
								if (115064 - 389401 != -274337)
								{
									continue;
								}
								this.$mItalus$40266.animation.CrossFade("talk");
								if (12455 - 547500 == -535044)
								{
									continue;
								}
							}
							this.$mItalusRotation$40271 = this.$mItalus$40266.transform.eulerAngles.y;
							if (22709 - 73196 == -50486)
							{
								continue;
							}
							this.$self_$40278.E8XcyHvGchb = Time.time;
							if (251390 - 481728 != -230337)
							{
								goto IL_441;
							}
							continue;
						}
						break;
					case 6:
						goto IL_441;
					case 7:
						if (Game.mGameState != eGameState.Hold)
						{
							if (27208 - 421481 != -394272)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$nMessage$40270 = Language.getMessage("M702_EasternWorldDivide", 403);
							if (124689 - 451136 == -326446)
							{
								continue;
							}
							this.$mStoryGui$40269.newStoryMessage("Falcon", "Italus", this.$nMessage$40270, eTalkType.friend);
							if (265652 - 441368 != -175716)
							{
								continue;
							}
							this.$self_$40278.SendMessage("alignToObject", "EventCamera2");
							if (102651 - 114625 != -11974)
							{
								continue;
							}
							if (this.$mItalus$40266)
							{
								if (104510 - 477552 == -373041)
								{
									continue;
								}
								this.$mItalus$40266.animation.CrossFade("root");
								if (215663 - 350693 != -135030)
								{
									continue;
								}
							}
							if (this.$self_$40278.mFakeCambot)
							{
								if (45739 - 517014 == -471274)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$40278.mFakeCambot, new Vector3((float)0, (float)54, (float)84), Quaternion.LookRotation(-Vector3.forward));
								if (163215 - 556077 == -392861)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$40278.mFakeCambot, new Vector3((float)12, (float)55, (float)92), Quaternion.LookRotation(-Vector3.forward));
								if (27327 - 399492 != -372165)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$40278.mFakeCambot, new Vector3((float)6, (float)55, (float)100), Quaternion.LookRotation(-Vector3.forward));
								if (82730 - 521069 == -438338)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$40278.mFakeCambot, new Vector3((float)16, (float)55, (float)106), Quaternion.LookRotation(-Vector3.forward));
								if (288799 - 277504 != 11295)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$40278.mFakeCambot, new Vector3((float)-3, (float)55, (float)112), Quaternion.LookRotation(-Vector3.forward));
								if (219476 - 461504 == -242027)
								{
									continue;
								}
							}
							this.$self_$40278.E8XcyHvGchb = Time.time;
							if (245582 - 76183 != 169399)
							{
								continue;
							}
							goto IL_959;
						}
						break;
					case 8:
						goto IL_959;
					case 9:
						if (Game.mGameState != eGameState.Hold)
						{
							if (142678 - 270481 != -127803)
							{
								continue;
							}
							goto IL_DE3;
						}
						else
						{
							this.$nMessage$40270 = Language.getMessage("M702_EasternWorldDivide", 404);
							if (47619 - 194484 == -146864)
							{
								continue;
							}
							this.$mStoryGui$40269.newStoryMessage("Falcon", "Italus", this.$nMessage$40270, eTalkType.friend);
							if (299507 - 457590 != -158082)
							{
								goto Block_102;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Hold)
						{
							if (194396 - 584211 != -389814)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$nMessage$40270 = Language.getMessage("M702_EasternWorldDivide", 405);
							if (293381 - 180467 != 112914)
							{
								continue;
							}
							this.$mStoryGui$40269.newStoryMessage("Falcon", "Italus", this.$nMessage$40270, eTalkType.friend);
							if (277055 - 459838 != -182783)
							{
								continue;
							}
							goto IL_CE1;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Hold)
						{
							if (213464 - 14457 != 199008)
							{
								goto Block_84;
							}
							continue;
						}
						else
						{
							this.$nMessage$40270 = Language.getMessage("M702_EasternWorldDivide", 406);
							if (69742 - 478478 == -408735)
							{
								continue;
							}
							this.$mStoryGui$40269.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$40270, eTalkType.friend);
							if (54013 - 19176 != 34837)
							{
								continue;
							}
							goto IL_9FF;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.Hold)
						{
							if (290260 - 229901 != 60359)
							{
								continue;
							}
							goto IL_F6C;
						}
						else
						{
							this.$nMessage$40270 = Language.getMessage("M702_EasternWorldDivide", 407);
							if (107804 - 108282 == -477)
							{
								continue;
							}
							this.$mStoryGui$40269.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$40270, eTalkType.friend);
							if (235682 - 233736 != 1946)
							{
								continue;
							}
							goto IL_710;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.Hold)
						{
							if (178443 - 443999 != -265556)
							{
								continue;
							}
							goto IL_F04;
						}
						else
						{
							this.$nMessage$40270 = Language.getMessage("M702_EasternWorldDivide", 408);
							if (82628 - 573572 == -490943)
							{
								continue;
							}
							this.$mStoryGui$40269.newStoryMessage("Falcon", "Italus", this.$nMessage$40270, eTalkType.friend);
							if (253331 - 330915 != -77584)
							{
								continue;
							}
							this.$self_$40278.SendMessage("alignToObject", "EventCamera1");
							if (77917 - 569399 != -491482)
							{
								continue;
							}
							if (this.$mItalus$40266)
							{
								if (245789 - 289641 != -43852)
								{
									continue;
								}
								this.$mItalus$40266.animation.CrossFade("talk");
								if (178188 - 386362 == -208173)
								{
									continue;
								}
							}
							this.$self_$40278.E8XcyHvGchb = Time.time;
							if (263886 - 54156 != 209731)
							{
								goto IL_1534;
							}
							continue;
						}
						break;
					case 14:
						goto IL_1534;
					case 15:
						if (Game.mGameState != eGameState.Hold)
						{
							if (175201 - 565642 != -390441)
							{
								continue;
							}
							goto IL_FD7;
						}
						else
						{
							this.$nMessage$40270 = Language.getMessage("M702_EasternWorldDivide", 409);
							if (40935 - 443339 == -402403)
							{
								continue;
							}
							this.$mStoryGui$40269.newStoryMessage("Falcon", "Italus", this.$nMessage$40270, eTalkType.friend);
							if (246244 - 305222 != -58978)
							{
								continue;
							}
							goto IL_B1D;
						}
						break;
					case 16:
						if (Game.mGameState != eGameState.Hold)
						{
							if (127776 - 434843 != -307066)
							{
								goto Block_74;
							}
							continue;
						}
						else
						{
							this.$nMessage$40270 = Language.getMessage("M702_EasternWorldDivide", 410);
							if (108799 - 281802 != -173003)
							{
								continue;
							}
							this.$mStoryGui$40269.newStoryMessage("Falcon", "Italus", this.$nMessage$40270, eTalkType.friend);
							if (186554 - 298927 != -112373)
							{
								continue;
							}
							goto IL_136E;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.Hold)
						{
							if (276748 - 582668 != -305920)
							{
								continue;
							}
							goto IL_E7;
						}
						else
						{
							this.$nMessage$40270 = Language.getMessage("M702_EasternWorldDivide", 411);
							if (38156 - 323308 != -285152)
							{
								continue;
							}
							this.$mStoryGui$40269.newStoryMessage("Falcon", "Italus", this.$nMessage$40270, eTalkType.friend);
							if (125724 - 114555 != 11169)
							{
								continue;
							}
							goto IL_1201;
						}
						break;
					case 18:
						if (Game.mGameState != eGameState.Hold)
						{
							if (55145 - 8612 != 46534)
							{
								goto Block_115;
							}
							continue;
						}
						else
						{
							this.$nMessage$40270 = Language.getMessage("M702_EasternWorldDivide", 412);
							if (58441 - 248893 == -190451)
							{
								continue;
							}
							this.$mStoryGui$40269.newStoryMessage("Falcon", "Italus", this.$nMessage$40270, eTalkType.friend);
							if (261667 - 59474 != 202194)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 19:
						if (Game.mGameState != eGameState.Hold)
						{
							if (20556 - 371645 != -351089)
							{
								continue;
							}
							goto IL_13AA;
						}
						else
						{
							this.$mStoryGui$40269.close();
							if (147769 - 137069 != 10700)
							{
								continue;
							}
							goto IL_12A2;
						}
						break;
					case 20:
						if (Game.mGameState != eGameState.Complete)
						{
							if (6154 - 442584 == -436429)
							{
								continue;
							}
							Game.sendMissionEvent(7026, 1);
							if (160466 - 333792 == -173325)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (149505 - 312448 != -162943)
						{
							continue;
						}
						goto IL_16EB;
					default:
						if (102773 - 330828 != -228055)
						{
							continue;
						}
						break;
					}
					Debug.Log("TalkToItalusEvent");
					if (78034 - 330127 == -252092)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (159048 - 271415 != -112366)
						{
							goto Block_93;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (106482 - 63470 == 43013)
						{
							continue;
						}
						this.$mGameGui$40265 = (GameGui)this.$self_$40278.GetComponent(typeof(GameGui));
						if (237257 - 290144 == -52886)
						{
							continue;
						}
						if (!this.$mGameGui$40265)
						{
							goto IL_AA4;
						}
						if (226116 - 392027 != -165911)
						{
							continue;
						}
						this.$mGameGui$40265.close();
						if (175039 - 474371 != -299332)
						{
							continue;
						}
						goto IL_AA4;
					}
					IL_441:
					if (Time.time >= this.$self_$40278.E8XcyHvGchb + 0.25f)
					{
						if (127410 - 125899 != 1512)
						{
							goto Block_31;
						}
						continue;
					}
					else
					{
						if (!this.$mItalus$40266)
						{
							goto IL_435;
						}
						if (105654 - 387545 == -281890)
						{
							continue;
						}
						this.$$14408$40272 = Mathf.SmoothStep(this.$mItalusRotation$40271, this.$mItalusRotation$40271 + (float)180, (float)4 * (Time.time - this.$self_$40278.E8XcyHvGchb));
						if (225479 - 524872 == -299392)
						{
							continue;
						}
						if (215433 - 115066 != 100367)
						{
							continue;
						}
						this.$$14409$40273 = this.$mItalus$40266.transform.eulerAngles;
						if (166566 - 321915 == -155348 || 100667 - 458091 == -357423)
						{
							continue;
						}
						this.$$14409$40273.y = this.$$14408$40272;
						if (167544 - 532670 != -365126)
						{
							continue;
						}
						if (21657 - 210326 != -188669)
						{
							continue;
						}
						Vector3 vector = this.$mItalus$40266.transform.eulerAngles = this.$$14409$40273;
						if (261622 - 48460 != 213162)
						{
							continue;
						}
						if (186148 - 158334 != 27814)
						{
							continue;
						}
						goto IL_435;
					}
					IL_959:
					if (Time.time >= this.$self_$40278.E8XcyHvGchb + 0.25f)
					{
						if (240787 - 421744 != -180957)
						{
							continue;
						}
						goto IL_C57;
					}
					else
					{
						if (!this.$mItalus$40266)
						{
							goto IL_94D;
						}
						if (61719 - 242928 != -181209)
						{
							continue;
						}
						this.$$14410$40274 = Mathf.SmoothStep(this.$mItalusRotation$40271 + (float)180, this.$mItalusRotation$40271, (float)4 * (Time.time - this.$self_$40278.E8XcyHvGchb));
						if (234296 - 386936 == -152639)
						{
							continue;
						}
						if (35416 - 410132 != -374716)
						{
							continue;
						}
						this.$$14411$40275 = this.$mItalus$40266.transform.eulerAngles;
						if (236510 - 38638 != 197872)
						{
							continue;
						}
						if (277280 - 428157 == -150876)
						{
							continue;
						}
						float num = this.$$14411$40275.y = this.$$14410$40274;
						if (108263 - 203864 == -95600)
						{
							continue;
						}
						if (267965 - 406947 != -138982)
						{
							continue;
						}
						Vector3 vector2 = this.$mItalus$40266.transform.eulerAngles = this.$$14411$40275;
						if (233775 - 267718 == -33942)
						{
							continue;
						}
						if (84407 - 239388 != -154981)
						{
							continue;
						}
						goto IL_94D;
					}
					IL_1534:
					if (Time.time >= this.$self_$40278.E8XcyHvGchb + 0.25f)
					{
						if (72855 - 188869 == -116014)
						{
							goto IL_14B7;
						}
					}
					else
					{
						if (!this.$mItalus$40266)
						{
							goto IL_1527;
						}
						if (264041 - 277905 != -13863)
						{
							float num2 = this.$$14412$40276 = Mathf.SmoothStep(this.$mItalusRotation$40271, this.$mItalusRotation$40271 + (float)180, (float)4 * (Time.time - this.$self_$40278.E8XcyHvGchb));
							if (278582 - 321947 == -43365)
							{
								if (152764 - 387134 != -234369)
								{
									Vector3 vector3 = this.$$14413$40277 = this.$mItalus$40266.transform.eulerAngles;
									if (157238 - 511823 == -354585)
									{
										if (236848 - 86069 != 150780)
										{
											float num3 = this.$$14413$40277.y = this.$$14412$40276;
											if (154977 - 405593 == -250616)
											{
												if (298440 - 304876 != -6435)
												{
													Vector3 vector4 = this.$mItalus$40266.transform.eulerAngles = this.$$14413$40277;
													if (19788 - 423983 != -404194)
													{
														if (78395 - 159850 == -81455)
														{
															goto IL_1527;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_4:
				return this.Yield(19, new WaitForSeconds(4f));
				Block_6:
				IL_E7:
				Block_13:
				goto IL_16EB;
				IL_22D:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_16:
				Block_29:
				goto IL_16EB;
				IL_435:
				return this.YieldDefault(6);
				Block_31:
				return this.Yield(7, new WaitForSeconds(2.7f));
				Block_36:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_710:
				return this.Yield(13, new WaitForSeconds(4f));
				IL_820:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_94D:
				return this.YieldDefault(8);
				IL_9FF:
				return this.Yield(12, new WaitForSeconds(2.5f));
				IL_AA4:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_71:
				goto IL_16EB;
				IL_B1D:
				return this.Yield(16, new WaitForSeconds(3f));
				Block_74:
				goto IL_16EB;
				IL_C57:
				return this.Yield(9, new WaitForSeconds(2.7f));
				IL_CE1:
				return this.Yield(11, new WaitForSeconds(3f));
				Block_84:
				IL_DE3:
				Block_93:
				IL_F04:
				IL_F6C:
				goto IL_16EB;
				Block_102:
				return this.Yield(10, new WaitForSeconds(2.5f));
				IL_FD7:
				goto IL_16EB;
				IL_1201:
				return this.Yield(18, new WaitForSeconds(4f));
				Block_115:
				goto IL_16EB;
				IL_12A2:
				return this.Yield(20, new WaitForSeconds(1f));
				IL_136E:
				return this.Yield(17, new WaitForSeconds(3f));
				IL_13AA:
				goto IL_16EB;
				IL_14B7:
				return this.Yield(15, new WaitForSeconds(3.7f));
				IL_1527:
				return this.YieldDefault(14);
				IL_16EB:
				return false;
			}

			// Token: 0x0600890E RID: 35086 RVA: 0x010E9A8C File Offset: 0x010E7C8C
			internal static bool JR4KrlVtXe88Hlvu3SoV()
			{
				return true;
			}

			// Token: 0x0600890F RID: 35087 RVA: 0x010E9A90 File Offset: 0x010E7C90
			internal static bool f5otDLVtQiR3JuDVktJd()
			{
				return false;
			}

			// Token: 0x040083F7 RID: 33783
			internal GameGui $mGameGui$40265;

			// Token: 0x040083F8 RID: 33784
			internal GameObject $mItalus$40266;

			// Token: 0x040083F9 RID: 33785
			internal GameObject $mPlayer$40267;

			// Token: 0x040083FA RID: 33786
			internal GameObject $mSpawnPoint$40268;

			// Token: 0x040083FB RID: 33787
			internal StoryGui $mStoryGui$40269;

			// Token: 0x040083FC RID: 33788
			internal string $nMessage$40270;

			// Token: 0x040083FD RID: 33789
			internal float $mItalusRotation$40271;

			// Token: 0x040083FE RID: 33790
			internal float $$14408$40272;

			// Token: 0x040083FF RID: 33791
			internal Vector3 $$14409$40273;

			// Token: 0x04008400 RID: 33792
			internal float $$14410$40274;

			// Token: 0x04008401 RID: 33793
			internal Vector3 $$14411$40275;

			// Token: 0x04008402 RID: 33794
			internal float $$14412$40276;

			// Token: 0x04008403 RID: 33795
			internal Vector3 $$14413$40277;

			// Token: 0x04008404 RID: 33796
			internal M702_EasternWorldDivide4 $self_$40278;
		}
	}

	// Token: 0x02001709 RID: 5897
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$40280 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008910 RID: 35088 RVA: 0x010E9A94 File Offset: 0x010E7C94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$40280(M702_EasternWorldDivide4 self_)
		{
			if (147366 - 277515 != -130149)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (151829 - 586638 == -434809)
				{
					base..ctor();
					if (108842 - 379462 == -270620)
					{
						this.$self_$40283 = self_;
						if (259301 - 317447 != -58145)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008911 RID: 35089 RVA: 0x010E9B2C File Offset: 0x010E7D2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide4.$StartGame$40280.$(this.$self_$40283);
		}

		// Token: 0x06008912 RID: 35090 RVA: 0x010E9B3C File Offset: 0x010E7D3C
		internal static bool avVPHeVtksnlb7srbMrX()
		{
			return true;
		}

		// Token: 0x06008913 RID: 35091 RVA: 0x010E9B40 File Offset: 0x010E7D40
		internal static bool m4CROGVtGbXY829YdhSb()
		{
			return false;
		}

		// Token: 0x04008405 RID: 33797
		internal M702_EasternWorldDivide4 $self_$40283;

		// Token: 0x0200170A RID: 5898
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008914 RID: 35092 RVA: 0x010E9B44 File Offset: 0x010E7D44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide4 self_)
			{
				if (196258 - 540330 != -344072)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (255791 - 425617 == -169826)
					{
						base..ctor();
						if (201650 - 156238 != 45413)
						{
							this.$self_$40282 = self_;
							if (146771 - 168893 != -22121)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008915 RID: 35093 RVA: 0x010E9BDC File Offset: 0x010E7DDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (14028 - 124708 != -110679)
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
						if (91788 - 507257 == -415468)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (66787 - 557195 == -490407)
						{
							continue;
						}
						this.YieldDefault(1);
						if (154003 - 197712 != -43708)
						{
							goto Block_6;
						}
						continue;
					default:
						if (124943 - 388902 == -263958)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (158678 - 74856 != 83823)
					{
						Game.mGameState = eGameState.Start;
						if (282021 - 169862 == 112159)
						{
							Game.mStateTime = Time.time;
							if (26976 - 383554 == -356578)
							{
								this.$self_$40282.SendMessage("fadeIn");
								if (147615 - 158391 != -10775)
								{
									this.$mGameGui$40281 = (GameGui)this.$self_$40282.GetComponent(typeof(GameGui));
									if (74328 - 589178 == -514850)
									{
										this.$mGameGui$40281.enabled = true;
										if (152941 - 502797 != -349855)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_6:
				IL_1B9:
				return false;
			}

			// Token: 0x06008916 RID: 35094 RVA: 0x010E9DB4 File Offset: 0x010E7FB4
			internal static bool YdLSatVtHHsM8sh63wRs()
			{
				return true;
			}

			// Token: 0x06008917 RID: 35095 RVA: 0x010E9DB8 File Offset: 0x010E7FB8
			internal static bool cuotuPVtWRU8ecRMsTpC()
			{
				return false;
			}

			// Token: 0x04008406 RID: 33798
			internal GameGui $mGameGui$40281;

			// Token: 0x04008407 RID: 33799
			internal M702_EasternWorldDivide4 $self_$40282;
		}
	}

	// Token: 0x0200170B RID: 5899
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40284 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008918 RID: 35096 RVA: 0x010E9DBC File Offset: 0x010E7FBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40284(M702_EasternWorldDivide4 self_)
		{
			if (220949 - 118977 != 101972)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (145169 - 369297 != -224127)
				{
					base..ctor();
					if (182706 - 534501 == -351795)
					{
						this.$self_$40289 = self_;
						if (88058 - 354432 == -266374)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008919 RID: 35097 RVA: 0x010E9E54 File Offset: 0x010E8054
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide4.$onDeadPlayer$40284.$(this.$self_$40289);
		}

		// Token: 0x0600891A RID: 35098 RVA: 0x010E9E64 File Offset: 0x010E8064
		internal static bool qY2r0KVtAjf9CtMmEa5G()
		{
			return true;
		}

		// Token: 0x0600891B RID: 35099 RVA: 0x010E9E68 File Offset: 0x010E8068
		internal static bool uaHOONVtlgK8SKa7qQIm()
		{
			return false;
		}

		// Token: 0x04008408 RID: 33800
		internal M702_EasternWorldDivide4 $self_$40289;

		// Token: 0x0200170C RID: 5900
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600891C RID: 35100 RVA: 0x010E9E6C File Offset: 0x010E806C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide4 self_)
			{
				if (80497 - 262706 != -182209)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (134416 - 416097 != -281680)
					{
						base..ctor();
						if (100926 - 431252 != -330325)
						{
							this.$self_$40288 = self_;
							if (25215 - 441023 != -415807)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600891D RID: 35101 RVA: 0x010E9F04 File Offset: 0x010E8104
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (145460 - 508370 != -362909)
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
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_275;
						}
						if (146234 - 292062 != -145828)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (273139 - 523442 != -250302)
							{
								goto IL_275;
							}
							continue;
						}
						IL_253:
						this.YieldDefault(1);
						if (281570 - 204365 != 77205)
						{
							continue;
						}
						goto IL_2F9;
						IL_275:
						Game.mGameState = eGameState.Hold;
						if (185005 - 503049 == -318043)
						{
							continue;
						}
						this.$mStoryGui$40285 = (StoryGui)this.$self_$40288.GetComponent(typeof(StoryGui));
						if (124533 - 2371 != 122162)
						{
							continue;
						}
						if (this.$mStoryGui$40285)
						{
							if (81452 - 21167 != 60285)
							{
								continue;
							}
							this.$mStoryGui$40285.close();
							if (135388 - 139176 == -3787)
							{
								continue;
							}
						}
						this.$mChangeGui$40286 = (ChangeGui)this.$self_$40288.GetComponent(typeof(ChangeGui));
						if (83047 - 273091 == -190043)
						{
							continue;
						}
						if (this.$mChangeGui$40286)
						{
							if (76139 - 548036 == -471896)
							{
								continue;
							}
							this.$mChangeGui$40286.close();
							if (277659 - 248499 != 29160)
							{
								continue;
							}
						}
						this.$mGameGui$40287 = (GameGui)this.$self_$40288.GetComponent(typeof(GameGui));
						if (292929 - 246860 == 46070)
						{
							continue;
						}
						if (!this.$mGameGui$40287)
						{
							goto IL_253;
						}
						if (271505 - 388021 == -116515)
						{
							continue;
						}
						if (!this.$mGameGui$40287.enabled)
						{
							if (204631 - 120095 == 84537)
							{
								continue;
							}
							this.$mGameGui$40287.enabled = true;
							if (60282 - 261304 != -201022)
							{
								continue;
							}
						}
						this.$mGameGui$40287.openDeadMenu();
						if (215487 - 9141 != 206346)
						{
							continue;
						}
						goto IL_253;
					default:
						if (26197 - 250679 == -224481)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (259843 - 43141 != 216702);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600891E RID: 35102 RVA: 0x010EA21C File Offset: 0x010E841C
			internal static bool iQgRtiVtyldxVqux0gmr()
			{
				return true;
			}

			// Token: 0x0600891F RID: 35103 RVA: 0x010EA220 File Offset: 0x010E8420
			internal static bool XQeG5fVtSYB1qZut4oeF()
			{
				return false;
			}

			// Token: 0x04008409 RID: 33801
			internal StoryGui $mStoryGui$40285;

			// Token: 0x0400840A RID: 33802
			internal ChangeGui $mChangeGui$40286;

			// Token: 0x0400840B RID: 33803
			internal GameGui $mGameGui$40287;

			// Token: 0x0400840C RID: 33804
			internal M702_EasternWorldDivide4 $self_$40288;
		}
	}

	// Token: 0x0200170D RID: 5901
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$40290 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008920 RID: 35104 RVA: 0x010EA224 File Offset: 0x010E8424
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$40290(Hashtable data, M702_EasternWorldDivide4 self_)
		{
			if (190395 - 553518 != -363123)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (23004 - 275859 == -252855)
				{
					base..ctor();
					if (77496 - 210983 == -133487)
					{
						this.$data$40295 = data;
						if (234994 - 304637 == -69643)
						{
							this.$self_$40296 = self_;
							if (163989 - 281866 == -117877)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008921 RID: 35105 RVA: 0x010EA2E0 File Offset: 0x010E84E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide4.$onChangePlayer$40290.$(this.$data$40295, this.$self_$40296);
		}

		// Token: 0x06008922 RID: 35106 RVA: 0x010EA2F4 File Offset: 0x010E84F4
		internal static bool QwvdSiVtoManZu8Z2LrF()
		{
			return true;
		}

		// Token: 0x06008923 RID: 35107 RVA: 0x010EA2F8 File Offset: 0x010E84F8
		internal static bool q7IfQmVtE6C3o5Llj90i()
		{
			return false;
		}

		// Token: 0x0400840D RID: 33805
		internal Hashtable $data$40295;

		// Token: 0x0400840E RID: 33806
		internal M702_EasternWorldDivide4 $self_$40296;

		// Token: 0x0200170E RID: 5902
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008924 RID: 35108 RVA: 0x010EA2FC File Offset: 0x010E84FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M702_EasternWorldDivide4 self_)
			{
				if (132017 - 461638 != -329620)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (217675 - 575750 != -358074)
					{
						base..ctor();
						if (222469 - 13866 == 208603)
						{
							this.$data$40293 = data;
							if (221491 - 431939 == -210448)
							{
								this.$self_$40294 = self_;
								if (128399 - 518471 == -390072)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008925 RID: 35109 RVA: 0x010EA3B8 File Offset: 0x010E85B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79263 - 409189 != -329925)
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
							if (11464 - 111288 != -99824)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (95700 - 65631 == 30070)
							{
								continue;
							}
							this.$mGameGui$40292 = (GameGui)this.$self_$40294.GetComponent(typeof(GameGui));
							if (143977 - 237985 != -94008)
							{
								continue;
							}
							this.$mGameGui$40292.enabled = true;
							if (236113 - 190896 == 45218)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (85375 - 221587 != -136211)
						{
							goto Block_3;
						}
						continue;
					default:
						if (274451 - 417512 != -143061)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (94549 - 105360 == -10811)
					{
						this.$self_$40294.SendMessage("onCreatePlayer", this.$data$40293);
						if (51837 - 23330 == 28507)
						{
							this.$mChangeGui$40291 = (ChangeGui)this.$self_$40294.GetComponent(typeof(ChangeGui));
							if (119568 - 399112 == -279544)
							{
								if (!this.$mChangeGui$40291.enabled)
								{
									goto IL_1CA;
								}
								if (73657 - 56533 != 17125)
								{
									this.$mChangeGui$40291.close();
									if (253856 - 121043 == 132813)
									{
										goto IL_1CA;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_205;
				IL_1CA:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x06008926 RID: 35110 RVA: 0x010EA5DC File Offset: 0x010E87DC
			internal static bool o2oO7jVt2T81RcK7BJXv()
			{
				return true;
			}

			// Token: 0x06008927 RID: 35111 RVA: 0x010EA5E0 File Offset: 0x010E87E0
			internal static bool Io99CcVt890S3oWAJpYi()
			{
				return false;
			}

			// Token: 0x0400840F RID: 33807
			internal ChangeGui $mChangeGui$40291;

			// Token: 0x04008410 RID: 33808
			internal GameGui $mGameGui$40292;

			// Token: 0x04008411 RID: 33809
			internal Hashtable $data$40293;

			// Token: 0x04008412 RID: 33810
			internal M702_EasternWorldDivide4 $self_$40294;
		}
	}

	// Token: 0x0200170F RID: 5903
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40297 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008928 RID: 35112 RVA: 0x010EA5E4 File Offset: 0x010E87E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40297(Hashtable data, M702_EasternWorldDivide4 self_)
		{
			if (112534 - 57637 != 54898)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (85521 - 43117 == 42404)
				{
					base..ctor();
					if (75288 - 513565 == -438277)
					{
						this.$data$40305 = data;
						if (133851 - 473506 == -339655)
						{
							this.$self_$40306 = self_;
							if (142133 - 470016 == -327883)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008929 RID: 35113 RVA: 0x010EA6A0 File Offset: 0x010E88A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide4.$onGameComplete$40297.$(this.$data$40305, this.$self_$40306);
		}

		// Token: 0x0600892A RID: 35114 RVA: 0x010EA6B4 File Offset: 0x010E88B4
		internal static bool uEk4k5VtZcl1U5WNeerg()
		{
			return true;
		}

		// Token: 0x0600892B RID: 35115 RVA: 0x010EA6B8 File Offset: 0x010E88B8
		internal static bool XV2ScWVtCZOgAo5mIbTS()
		{
			return false;
		}

		// Token: 0x04008413 RID: 33811
		internal Hashtable $data$40305;

		// Token: 0x04008414 RID: 33812
		internal M702_EasternWorldDivide4 $self_$40306;

		// Token: 0x02001710 RID: 5904
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600892C RID: 35116 RVA: 0x010EA6BC File Offset: 0x010E88BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M702_EasternWorldDivide4 self_)
			{
				if (62161 - 577147 != -514986)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (75200 - 111586 == -36386)
					{
						base..ctor();
						if (251402 - 471817 != -220414)
						{
							this.$data$40303 = data;
							if (197577 - 157260 != 40318)
							{
								this.$self_$40304 = self_;
								if (118052 - 18094 == 99958)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600892D RID: 35117 RVA: 0x010EA778 File Offset: 0x010E8978
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (50304 - 483505 != -433200)
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
						this.$mCompleteGui$40299 = (CompleteGui)this.$self_$40304.GetComponent(typeof(CompleteGui));
						if (13006 - 462661 != -449655)
						{
							continue;
						}
						this.$mCompleteGui$40299.Init();
						if (198893 - 245254 == -46360)
						{
							continue;
						}
						this.$mCompleteGui$40299.readData(this.$data$40303);
						if (105161 - 127519 != -22358)
						{
							continue;
						}
						if (this.$result$40298 == 1)
						{
							if (274153 - 205925 == 68229)
							{
								continue;
							}
							this.$mCompleteGui$40299.displayResult(eCompleteType.Success);
							if (90325 - 100194 == -9868)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40299.displayResult(eCompleteType.Failed);
							if (187018 - 180152 != 6866)
							{
								continue;
							}
						}
						this.$mGameGui$40300 = (GameGui)this.$self_$40304.GetComponent(typeof(GameGui));
						if (243998 - 581995 != -337997)
						{
							continue;
						}
						this.$mStoryGui$40301 = (StoryGui)this.$self_$40304.GetComponent(typeof(StoryGui));
						if (118991 - 17130 == 101862)
						{
							continue;
						}
						this.$mChangeGui$40302 = (ChangeGui)this.$self_$40304.GetComponent(typeof(ChangeGui));
						if (26742 - 82226 == -55483)
						{
							continue;
						}
						if (this.$mGameGui$40300)
						{
							if (32060 - 308945 == -276884)
							{
								continue;
							}
							this.$mGameGui$40300.close();
							if (270426 - 82097 == 188330)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40301)
						{
							if (45526 - 517299 == -471772)
							{
								continue;
							}
							this.$mStoryGui$40301.close();
							if (279581 - 5763 != 273818)
							{
								continue;
							}
						}
						if (this.$mChangeGui$40302)
						{
							if (240202 - 446288 == -206085)
							{
								continue;
							}
							this.$mChangeGui$40302.disable();
							if (117785 - 259320 == -141534)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (194661 - 505915 != -311254)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (1155 - 155965 != -154810)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40303[31]);
					if (39337 - 456105 == -416768)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (106689 - 564756 == -458067)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (22035 - 65743 == -43708)
							{
								this.$result$40298 = RuntimeServices.UnboxInt32(this.$data$40303[31]);
								if (286849 - 327938 != -41088)
								{
									goto Block_17;
								}
							}
						}
					}
				}
				goto IL_3DB;
				Block_17:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600892E RID: 35118 RVA: 0x010EAB74 File Offset: 0x010E8D74
			internal static bool uh3GSgVtLJs8S8mi5ygS()
			{
				return true;
			}

			// Token: 0x0600892F RID: 35119 RVA: 0x010EAB78 File Offset: 0x010E8D78
			internal static bool UgSP3lVtOthiNfPeYimU()
			{
				return false;
			}

			// Token: 0x04008415 RID: 33813
			internal int $result$40298;

			// Token: 0x04008416 RID: 33814
			internal CompleteGui $mCompleteGui$40299;

			// Token: 0x04008417 RID: 33815
			internal GameGui $mGameGui$40300;

			// Token: 0x04008418 RID: 33816
			internal StoryGui $mStoryGui$40301;

			// Token: 0x04008419 RID: 33817
			internal ChangeGui $mChangeGui$40302;

			// Token: 0x0400841A RID: 33818
			internal Hashtable $data$40303;

			// Token: 0x0400841B RID: 33819
			internal M702_EasternWorldDivide4 $self_$40304;
		}
	}

	// Token: 0x02001711 RID: 5905
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40307 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008930 RID: 35120 RVA: 0x010EAB7C File Offset: 0x010E8D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40307(M702_EasternWorldDivide4 self_)
		{
			if (172594 - 303046 != -130451)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (86277 - 535155 != -448877)
				{
					base..ctor();
					if (143228 - 483121 != -339892)
					{
						this.$self_$40311 = self_;
						if (142617 - 461020 == -318403)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008931 RID: 35121 RVA: 0x010EAC14 File Offset: 0x010E8E14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide4.$ReturnToTown$40307.$(this.$self_$40311);
		}

		// Token: 0x06008932 RID: 35122 RVA: 0x010EAC24 File Offset: 0x010E8E24
		internal static bool Ut4ikRVtmDqDJVKwHV2b()
		{
			return true;
		}

		// Token: 0x06008933 RID: 35123 RVA: 0x010EAC28 File Offset: 0x010E8E28
		internal static bool lrvFccVtFIDLlnRMvqcI()
		{
			return false;
		}

		// Token: 0x0400841C RID: 33820
		internal M702_EasternWorldDivide4 $self_$40311;

		// Token: 0x02001712 RID: 5906
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008934 RID: 35124 RVA: 0x010EAC2C File Offset: 0x010E8E2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide4 self_)
			{
				if (251776 - 214108 != 37669)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (202818 - 415720 == -212902)
					{
						base..ctor();
						if (241326 - 568371 != -327044)
						{
							this.$self_$40310 = self_;
							if (92148 - 562553 == -470405)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008935 RID: 35125 RVA: 0x010EACC4 File Offset: 0x010E8EC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (138122 - 52347 != 85775)
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
						this.$self_$40310.LeaveGame();
						if (133338 - 422007 == -288668)
						{
							continue;
						}
						this.YieldDefault(1);
						if (137259 - 168237 != -30977)
						{
							goto Block_27;
						}
						continue;
					default:
						if (259660 - 159178 != 100482)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (184194 - 518443 == -334249)
					{
						Game.mStateTime = Time.time;
						if (142349 - 325761 == -183412)
						{
							this.$$switch$7142$40308 = PlayerData.SaveGuild;
							if (179229 - 88500 == 90729)
							{
								if (this.$$switch$7142$40308 == 1)
								{
									if (47919 - 135155 == -87235)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (297447 - 573306 == -275858)
									{
										continue;
									}
								}
								else if (this.$$switch$7142$40308 == 2)
								{
									if (254799 - 426713 != -171914)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (59919 - 311273 != -251354)
									{
										continue;
									}
								}
								else if (this.$$switch$7142$40308 == 3)
								{
									if (199040 - 352536 != -153496)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (88402 - 99138 == -10735)
									{
										continue;
									}
								}
								else if (this.$$switch$7142$40308 == 4)
								{
									if (51438 - 73231 != -21793)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (118193 - 247410 == -129216)
									{
										continue;
									}
								}
								else if (this.$$switch$7142$40308 == 5)
								{
									if (62903 - 328995 != -266092)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (174350 - 473717 != -299367)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (96266 - 593533 != -497267)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (121917 - 54979 != 66938)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (154542 - 375238 == -220695)
									{
										continue;
									}
								}
								this.$mGameGui$40309 = (GameGui)this.$self_$40310.GetComponent(typeof(GameGui));
								if (29524 - 356497 != -326972)
								{
									if (this.$mGameGui$40309)
									{
										if (96259 - 461641 != -365382)
										{
											continue;
										}
										this.$mGameGui$40309.close();
										if (13436 - 285292 != -271856)
										{
											continue;
										}
									}
									this.$self_$40310.SendMessage("fadeOut");
									if (16522 - 446522 != -429999)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_27:
				IL_3AD:
				return false;
			}

			// Token: 0x06008936 RID: 35126 RVA: 0x010EB090 File Offset: 0x010E9290
			internal static bool v3PTHYVtMKiyb5dQbXur()
			{
				return true;
			}

			// Token: 0x06008937 RID: 35127 RVA: 0x010EB094 File Offset: 0x010E9294
			internal static bool kI4GfxVtxEYkadM7fjJc()
			{
				return false;
			}

			// Token: 0x0400841D RID: 33821
			internal int $$switch$7142$40308;

			// Token: 0x0400841E RID: 33822
			internal GameGui $mGameGui$40309;

			// Token: 0x0400841F RID: 33823
			internal M702_EasternWorldDivide4 $self_$40310;
		}
	}

	// Token: 0x02001713 RID: 5907
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40312 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008938 RID: 35128 RVA: 0x010EB098 File Offset: 0x010E9298
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40312(M702_EasternWorldDivide4 self_)
		{
			if (39060 - 61892 != -22832)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (1670 - 314082 != -312411)
				{
					base..ctor();
					if (131782 - 52496 == 79286)
					{
						this.$self_$40315 = self_;
						if (112264 - 331151 == -218887)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008939 RID: 35129 RVA: 0x010EB130 File Offset: 0x010E9330
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide4.$ReturnToGuild$40312.$(this.$self_$40315);
		}

		// Token: 0x0600893A RID: 35130 RVA: 0x010EB140 File Offset: 0x010E9340
		internal static bool m5KLFbVtgomqgDFXMtOk()
		{
			return true;
		}

		// Token: 0x0600893B RID: 35131 RVA: 0x010EB144 File Offset: 0x010E9344
		internal static bool yliCQOVtf9jCkODPue80()
		{
			return false;
		}

		// Token: 0x04008420 RID: 33824
		internal M702_EasternWorldDivide4 $self_$40315;

		// Token: 0x02001714 RID: 5908
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600893C RID: 35132 RVA: 0x010EB148 File Offset: 0x010E9348
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide4 self_)
			{
				if (277333 - 141924 != 135409)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (71988 - 343553 != -271564)
					{
						base..ctor();
						if (245820 - 366152 == -120332)
						{
							this.$self_$40314 = self_;
							if (143244 - 320344 == -177100)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600893D RID: 35133 RVA: 0x010EB1E0 File Offset: 0x010E93E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (187123 - 377762 != -190638)
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
						this.$self_$40314.LeaveGame();
						if (116289 - 160602 == -44312)
						{
							continue;
						}
						this.YieldDefault(1);
						if (208570 - 28849 != 179722)
						{
							goto Block_2;
						}
						continue;
					default:
						if (217038 - 175082 != 41956)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (112017 - 154255 == -42238)
					{
						Game.mStateTime = Time.time;
						if (281041 - 12776 == 268265)
						{
							Game.mNextGameCode = 31;
							if (246962 - 409605 == -162643)
							{
								this.$mGameGui$40313 = (GameGui)this.$self_$40314.GetComponent(typeof(GameGui));
								if (273230 - 501085 != -227854)
								{
									if (this.$mGameGui$40313)
									{
										if (202577 - 12327 == 190251)
										{
											continue;
										}
										this.$mGameGui$40313.close();
										if (189059 - 525866 != -336807)
										{
											continue;
										}
									}
									this.$self_$40314.SendMessage("fadeOut");
									if (3243 - 16835 == -13592)
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

			// Token: 0x0600893E RID: 35134 RVA: 0x010EB3BC File Offset: 0x010E95BC
			internal static bool MGTCBdVtnyUjob78RyYC()
			{
				return true;
			}

			// Token: 0x0600893F RID: 35135 RVA: 0x010EB3C0 File Offset: 0x010E95C0
			internal static bool AeXG1NVt6DsDXxohoRKO()
			{
				return false;
			}

			// Token: 0x04008421 RID: 33825
			internal GameGui $mGameGui$40313;

			// Token: 0x04008422 RID: 33826
			internal M702_EasternWorldDivide4 $self_$40314;
		}
	}

	// Token: 0x02001715 RID: 5909
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40316 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008940 RID: 35136 RVA: 0x010EB3C4 File Offset: 0x010E95C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40316(M702_EasternWorldDivide4 self_)
		{
			if (80872 - 480460 != -399588)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (130894 - 144666 == -13772)
				{
					base..ctor();
					if (27899 - 551977 != -524077)
					{
						this.$self_$40320 = self_;
						if (183269 - 599405 != -416135)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x010EB45C File Offset: 0x010E965C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M702_EasternWorldDivide4.$ReturnToCamp$40316.$(this.$self_$40320);
		}

		// Token: 0x06008942 RID: 35138 RVA: 0x010EB46C File Offset: 0x010E966C
		internal static bool eZXdixVtiDMNwlsSDGYm()
		{
			return true;
		}

		// Token: 0x06008943 RID: 35139 RVA: 0x010EB470 File Offset: 0x010E9670
		internal static bool RKjwWjVtKATMsaG8q2R6()
		{
			return false;
		}

		// Token: 0x04008423 RID: 33827
		internal M702_EasternWorldDivide4 $self_$40320;

		// Token: 0x02001716 RID: 5910
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008944 RID: 35140 RVA: 0x010EB474 File Offset: 0x010E9674
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M702_EasternWorldDivide4 self_)
			{
				if (55649 - 203661 != -148011)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (234674 - 7124 == 227550)
					{
						base..ctor();
						if (38899 - 529987 != -491087)
						{
							this.$self_$40319 = self_;
							if (85710 - 535025 == -449315)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008945 RID: 35141 RVA: 0x010EB50C File Offset: 0x010E970C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (195772 - 462536 != -266763)
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
						this.$self_$40319.LeaveGame();
						if (168925 - 352177 == -183251)
						{
							continue;
						}
						this.YieldDefault(1);
						if (262128 - 292273 != -30144)
						{
							goto Block_11;
						}
						continue;
					default:
						if (250846 - 19015 != 231831)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (106706 - 591539 != -484832)
					{
						Game.mStateTime = Time.time;
						if (155614 - 406875 != -251260)
						{
							this.$$switch$7144$40317 = PlayerData.SaveGuild;
							if (106608 - 326452 != -219843)
							{
								if (this.$$switch$7144$40317 == 1)
								{
									if (194025 - 134670 != 59355)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (182695 - 417695 != -235000)
									{
										continue;
									}
								}
								else if (this.$$switch$7144$40317 == 2)
								{
									if (231219 - 254387 == -23167)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (237221 - 285253 == -48031)
									{
										continue;
									}
								}
								else if (this.$$switch$7144$40317 == 3)
								{
									if (121427 - 458093 == -336665)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (53457 - 435218 == -381760)
									{
										continue;
									}
								}
								else if (this.$$switch$7144$40317 == 4)
								{
									if (230692 - 14774 != 215918)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (127 - 58414 == -58286)
									{
										continue;
									}
								}
								else if (this.$$switch$7144$40317 == 5)
								{
									if (117148 - 441292 == -324143)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (72505 - 538620 != -466115)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (240549 - 18974 == 221576)
									{
										continue;
									}
								}
								this.$mGameGui$40318 = (GameGui)this.$self_$40319.GetComponent(typeof(GameGui));
								if (116505 - 320271 == -203766)
								{
									if (this.$mGameGui$40318)
									{
										if (180630 - 410191 == -229560)
										{
											continue;
										}
										this.$mGameGui$40318.close();
										if (217323 - 134009 == 83315)
										{
											continue;
										}
									}
									this.$self_$40319.SendMessage("fadeOut");
									if (137614 - 197039 == -59425)
									{
										goto IL_32B;
									}
								}
							}
						}
					}
				}
				Block_11:
				goto IL_363;
				IL_32B:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06008946 RID: 35142 RVA: 0x010EB890 File Offset: 0x010E9A90
			internal static bool DCOhRDVtdYhoxZ3Ky1Zq()
			{
				return true;
			}

			// Token: 0x06008947 RID: 35143 RVA: 0x010EB894 File Offset: 0x010E9A94
			internal static bool Cvb0HYVtJiKZ2v7ZuHlk()
			{
				return false;
			}

			// Token: 0x04008424 RID: 33828
			internal int $$switch$7144$40317;

			// Token: 0x04008425 RID: 33829
			internal GameGui $mGameGui$40318;

			// Token: 0x04008426 RID: 33830
			internal M702_EasternWorldDivide4 $self_$40319;
		}
	}
}
