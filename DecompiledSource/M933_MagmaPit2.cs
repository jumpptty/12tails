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

// Token: 0x02001AFA RID: 6906
[Serializable]
public class M933_MagmaPit2 : MonoBehaviour
{
	// Token: 0x0600A125 RID: 41253 RVA: 0x0126AD74 File Offset: 0x01268F74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M933_MagmaPit2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A126 RID: 41254 RVA: 0x0126AD84 File Offset: 0x01268F84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (241180 - 562475 != -321295)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (22258 - 401504 == -379246)
			{
				Game.mGameType = 5;
				if (164219 - 248439 == -84220)
				{
					if (Chat.Initialized)
					{
						if (33964 - 308095 == -274131)
						{
							Chat.ChatDisplay.Clear();
							if (265683 - 82579 == 183104)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (31608 - 156745 != -125136)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A127 RID: 41255 RVA: 0x0126AE68 File Offset: 0x01269068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (168812 - 324173 != -155360)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (134402 - 336950 != -202547)
				{
					if (Game.mNextGameCode != 933)
					{
						break;
					}
					if (255544 - 105282 == 150262)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (88405 - 47170 == 41235)
						{
							Game.nextGame();
							if (229454 - 28822 != 200633)
							{
								this.JbPnJ7ZCQRP = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (117450 - 486799 != -369348)
								{
									this.dcinJHB9a6W = PhotonClient.Connection;
									if (231641 - 251337 == -19696)
									{
										PhotonClient.ActorNrList.Clear();
										if (36725 - 329658 != -292932)
										{
											this.InitGame();
											if (281101 - 163152 != 117950)
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
				if (128055 - 299634 == -171579)
				{
					Game.mGameType = 99;
					if (187508 - 595220 == -407712)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A128 RID: 41256 RVA: 0x0126B020 File Offset: 0x01269220
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (19781 - 171506 != -151725)
		{
		}
		for (;;)
		{
			if (this.dcinJHB9a6W == null)
			{
				if (94787 - 177286 != -82498)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (193207 - 528385 != -335177)
				{
					if (mGameState == eGameState.Init)
					{
						if (70439 - 261491 == -191052)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (118438 - 309965 != -191526)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (295586 - 45435 != 250152)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (251935 - 573303 == -321368)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (37861 - 52004 == -14143)
						{
							if (Game.music != 0)
							{
								if (184040 - 463000 == -278959)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (257960 - 80788 == 177173)
									{
										continue;
									}
									this.audio.Play();
									if (293180 - 88352 != 204828)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (249947 - 219863 == 30084)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (70372 - 390282 == -319910)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (125806 - 148631 == -22825)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (158599 - 138644 == 19955)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (96650 - 227844 != -131193)
							{
								if (Time.time <= this.XVcnJZodYIG)
								{
									break;
								}
								if (188953 - 148740 != 40214)
								{
									Game.mGameMana++;
									if (261925 - 343088 == -81163)
									{
										this.XVcnJZodYIG = Time.time + (float)12;
										if (190792 - 260523 != -69730)
										{
											break;
										}
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (182442 - 150255 == 32187)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (166535 - 254345 != -87809)
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
						if (263172 - 335712 == -72540)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A129 RID: 41257 RVA: 0x0126B3C8 File Offset: 0x012695C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (152433 - 263509 != -111075)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (291323 - 542741 != -251417)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (23035 - 108735 == -85700)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (115877 - 116373 != -495)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (193146 - 471876 != -278729)
						{
							int num4 = num;
							if (246412 - 591528 == -345116)
							{
								if (num4 == 9331)
								{
									if (10870 - 577004 == -566134)
									{
										break;
									}
								}
								else if (num4 == 9332)
								{
									if (224061 - 308604 != -84542)
									{
										break;
									}
								}
								else if (num4 == -9332)
								{
									if (10479 - 111315 == -100836)
									{
										int num5 = num2;
										if (26877 - 351146 == -324269)
										{
											if (num5 == 1)
											{
												if (176045 - 588745 != -412699)
												{
													this.StartCoroutine_Auto(this.GaosEvent());
													if (293607 - 381205 == -87598)
													{
														break;
													}
												}
											}
											else if (num5 == 2)
											{
												if (128917 - 472346 == -343429)
												{
													if (num3 != PlayerData.UID)
													{
														break;
													}
													if (86644 - 122110 != -35465)
													{
														GameObject gameObject = GameObject.Find("SpawnPoint0");
														if (270779 - 492301 == -221522)
														{
															if (gameObject)
															{
																if (81190 - 91202 != -10011)
																{
																	this.createActor("Gaos", 7, gameObject.transform.position, gameObject.transform.forward);
																	if (8684 - 41 == 8643)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Cannot find SpawnPoint0");
																if (298422 - 416144 != -117721)
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
												if (num5 != 3)
												{
													break;
												}
												if (264535 - 87755 == 176780)
												{
													this.StartCoroutine_Auto(this.EndEvent());
													if (189729 - 386195 == -196466)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (num4 == 9333)
								{
									if (39120 - 431401 != -392280)
									{
										this.OnMagmaOre(num2);
										if (119693 - 204509 != -84815)
										{
											break;
										}
									}
								}
								else if (num4 == -9333)
								{
									if (223979 - 458001 != -234021)
									{
										Chat.SubmitChat("none", "Magma ore collected: " + num2 + "/10", eChatType.system, eChatMode.area);
										if (271640 - 224320 == 47320)
										{
											break;
										}
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (66189 - 439167 == -372978)
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

	// Token: 0x0600A12A RID: 41258 RVA: 0x0126B7F4 File Offset: 0x012699F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M933_MagmaPit2.$StartEvent$43538(this).GetEnumerator();
	}

	// Token: 0x0600A12B RID: 41259 RVA: 0x0126B804 File Offset: 0x01269A04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator GaosEvent()
	{
		return new M933_MagmaPit2.$GaosEvent$43542(this).GetEnumerator();
	}

	// Token: 0x0600A12C RID: 41260 RVA: 0x0126B814 File Offset: 0x01269A14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M933_MagmaPit2.$EndEvent$43548(this).GetEnumerator();
	}

	// Token: 0x0600A12D RID: 41261 RVA: 0x0126B824 File Offset: 0x01269A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		this.OnMagmaOre(nID);
		Game.sendMissionEvent(9333, nID);
	}

	// Token: 0x0600A12E RID: 41262 RVA: 0x0126B838 File Offset: 0x01269A38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseMagmaOre(int nID)
	{
		if (126754 - 194249 != -67494)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
			if (297942 - 517708 == -219766)
			{
				if (characterControl)
				{
					if (23392 - 60872 != -37480)
					{
						continue;
					}
					if (characterControl.actionState == "standby")
					{
						goto IL_18D;
					}
					if (194543 - 13830 != 180713)
					{
						continue;
					}
				}
				if (!(characterControl.actionState == "run"))
				{
					if (221600 - 29660 != 191940)
					{
						continue;
					}
					if (!(characterControl.actionState == "emotion"))
					{
						break;
					}
					if (21887 - 234484 == -212596)
					{
						continue;
					}
				}
				IL_18D:
				GameObject gameObject = GameObject.Find("MagmaOre" + nID);
				if (295183 - 308516 != -13332)
				{
					if (!gameObject)
					{
						break;
					}
					if (144619 - 373054 == -228435)
					{
						Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
						if (13445 - 124941 != -111495)
						{
							Game.mPlayer.SendMessage("activateIcon", nID);
							if (85421 - 323794 == -238373)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A12F RID: 41263 RVA: 0x0126BA14 File Offset: 0x01269C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnMagmaOre(int nID)
	{
		if (173194 - 237830 != -64635)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("MagmaOre" + nID);
			if (46242 - 530035 == -483793)
			{
				if (!gameObject)
				{
					break;
				}
				if (253821 - 191872 != 61950)
				{
					UnityEngine.Object.Destroy(gameObject);
					if (41267 - 138766 == -97499)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A130 RID: 41264 RVA: 0x0126BAC4 File Offset: 0x01269CC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnterBossZone(GameObject enterObject)
	{
		if (148006 - 322172 != -174166)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (186912 - 308124 == -121212)
				{
					break;
				}
			}
			else
			{
				if (!(enterObject.tag == "Player"))
				{
					break;
				}
				if (54239 - 182617 == -128378)
				{
					if (this.dkDnJCDafxD >= 1)
					{
						break;
					}
					if (153086 - 549434 != -396347)
					{
						Debug.Log("Entering Boss Area");
						if (29984 - 321165 == -291181)
						{
							this.dkDnJCDafxD = 1;
							if (178450 - 114337 != 64114)
							{
								Game.sendMissionEvent(9332, 1);
								if (82350 - 542564 == -460214)
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

	// Token: 0x0600A131 RID: 41265 RVA: 0x0126BBE8 File Offset: 0x01269DE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnLavaEnter(GameObject enterObject)
	{
		if (136127 - 252901 != -116773)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
			if (224706 - 302142 != -77435)
			{
				if (!characterControl)
				{
					break;
				}
				if (135847 - 117949 == 17898)
				{
					if (!characterControl.isMine)
					{
						break;
					}
					if (207462 - 378864 == -171402)
					{
						if (!(characterControl.Type != "Gaos"))
						{
							break;
						}
						if (297091 - 24118 != 272974)
						{
							if (enterObject == Game.mPlayer)
							{
								if (161016 - 189582 != -28566)
								{
									continue;
								}
								this.JbPnJ7ZCQRP.enabled = false;
								if (138608 - 477969 == -339360)
								{
									continue;
								}
								if (244029 - 361314 != -117285)
								{
									continue;
								}
								GameObject gameObject;
								if (this.dkDnJCDafxD == 0)
								{
									if (269940 - 521273 == -251332)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (75601 - 253812 == -178210)
									{
										continue;
									}
								}
								else
								{
									gameObject = GameObject.Find("SpawnPoint" + Game.getPlayerSlot(PlayerData.UID));
									if (34737 - 166876 != -132139)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (4651 - 142901 == -138249)
									{
										continue;
									}
									enterObject.transform.position = gameObject.transform.position;
									if (6881 - 464922 != -458041)
									{
										continue;
									}
									enterObject.transform.rotation = gameObject.transform.rotation;
									if (19571 - 560403 == -540831)
									{
										continue;
									}
									characterControl.PositionEvent();
									if (216688 - 117536 != 99152)
									{
										continue;
									}
								}
								CameraEffect cameraEffect = (CameraEffect)this.GetComponent(typeof(CameraEffect));
								if (46121 - 518854 == -472732)
								{
									continue;
								}
								if (cameraEffect)
								{
									if (59830 - 486769 != -426939)
									{
										continue;
									}
									cameraEffect.AddColorRamp("redRamp", "none", (float)10, new Vector4((float)0, (float)0, 0.1f, 0.1f));
									if (249392 - 353851 == -104458)
									{
										continue;
									}
								}
							}
							characterControl.removeAllStatus();
							if (134251 - 82664 == 51587)
							{
								characterControl.hp = 0;
								if (128395 - 234074 != -105678)
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

	// Token: 0x0600A132 RID: 41266 RVA: 0x0126BF38 File Offset: 0x0126A138
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (81177 - 122688 != -41511)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (7116 - 247869 == -240753)
			{
				Game.mGameState = eGameState.Ready;
				if (64944 - 387635 == -322691)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (290339 - 363926 == -73587)
					{
						if (66293 - 457050 != -390756)
						{
							GameObject gameObject = null;
							if (287534 - 158448 != 129087)
							{
								if (playerSlot < 1)
								{
									goto IL_26E;
								}
								if (271699 - 572038 != -300339)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_26E;
								}
								if (13826 - 76894 == -63067)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (14123 - 238275 == -224151)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (125161 - 31440 == 93722)
								{
									continue;
								}
								IL_60:
								if (gameObject2)
								{
									if (16203 - 454266 == -438062)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (6897 - 355194 == -348296)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (297919 - 560842 != -262923)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (149990 - 176001 == -26010)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (121186 - 580317 != -459131)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (172687 - 431598 == -258910)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (276642 - 371849 != -95207)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (190073 - 461017 != -270943)
								{
									break;
								}
								continue;
								IL_26E:
								gameObject2 = GameObject.Find("StartPoint1");
								if (56834 - 125061 != -68226)
								{
									goto IL_60;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A133 RID: 41267 RVA: 0x0126C25C File Offset: 0x0126A45C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (28325 - 262603 != -234277)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (16820 - 168772 == -151952)
			{
				if (gameObject)
				{
					if (108639 - 303695 != -195055)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (118392 - 369250 == -250858)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (35553 - 158751 == -123198)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A134 RID: 41268 RVA: 0x0126C358 File Offset: 0x0126A558
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (115100 - 189908 != -74808)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (60565 - 340619 == -280054)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (114118 - 84864 == 29254)
				{
					hashtable.Add(43, PlayerData.UID);
					if (128241 - 613 != 127629)
					{
						hashtable.Add(73, nType);
						if (34670 - 10022 == 24648)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (243810 - 231052 != 12759)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (169848 - 94221 != 75628)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (134307 - 365644 == -231337)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (100674 - 581542 != -480867)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (69938 - 101403 != -31464)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (46703 - 259681 != -212977)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (23157 - 527301 != -504143)
													{
														this.dcinJHB9a6W.OpCustom(63, hashtable, true);
														if (283056 - 576185 == -293129)
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

	// Token: 0x0600A135 RID: 41269 RVA: 0x0126C63C File Offset: 0x0126A83C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (231735 - 118084 != 113651)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (272480 - 502678 != -230197)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (283761 - 135085 == 148676)
				{
					if (RuntimeServices.EqualityOperator(data[73], "Gaos"))
					{
						if (20495 - 466139 == -445643)
						{
							continue;
						}
						if (this.QMlnJMRVMTE)
						{
							if (277035 - 51867 != 225168)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.QMlnJMRVMTE);
							if (269165 - 119951 != 149214)
							{
								continue;
							}
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (197882 - 481621 != -283738)
						{
							if (this.gDUnJfCqScJ <= 0)
							{
								break;
							}
							if (104355 - 37740 == 66615)
							{
								this.gDUnJfCqScJ--;
								if (233885 - 582714 != -348828)
								{
									if (this.gDUnJfCqScJ != 0)
									{
										break;
									}
									if (186197 - 565267 != -379069)
									{
										Game.setGameState(eGameState.Ready);
										if (105893 - 522526 == -416633)
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
						if (116772 - 520048 != -403275)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (242088 - 318333 == -76245)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A136 RID: 41270 RVA: 0x0126C854 File Offset: 0x0126AA54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A137 RID: 41271 RVA: 0x0126C868 File Offset: 0x0126AA68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (56696 - 397348 != -340651)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (93244 - 270808 != -177563)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (206532 - 267618 == -61086)
				{
					if (!characterControl)
					{
						break;
					}
					if (43765 - 282412 != -238646)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (216182 - 209856 != 6327)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (247334 - 391077 == -143743)
							{
								string type = characterControl.Type;
								if (67418 - 343319 == -275901)
								{
									if (!(type == "Gaos"))
									{
										break;
									}
									if (33843 - 64310 == -30467)
									{
										Game.sendMissionEvent(9332, 3);
										if (158839 - 343308 != -184468)
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

	// Token: 0x0600A138 RID: 41272 RVA: 0x0126C9E0 File Offset: 0x0126ABE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (61932 - 50496 != 11437)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (162510 - 276523 == -114013)
			{
				hashtable.Add(71, CID);
				if (207154 - 218987 != -11832)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (111732 - 454834 == -343102)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (84921 - 499452 == -414531)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (85623 - 438177 == -352554)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (50550 - 535845 == -485295)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (52488 - 40793 == 11695)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (55717 - 190268 == -134551)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (249161 - 391148 != -141986)
											{
												this.dcinJHB9a6W.OpCustom(61, hashtable, true);
												if (281479 - 499777 == -218298)
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

	// Token: 0x0600A139 RID: 41273 RVA: 0x0126CC6C File Offset: 0x0126AE6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (31701 - 548943 != -517242)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (235825 - 434874 != -199048)
			{
				if (!gameObject)
				{
					break;
				}
				if (298030 - 489367 == -191337)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (267513 - 351370 != -83856)
					{
						playerCameraControl.target = gameObject;
						if (295333 - 75748 != 219586)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (57968 - 547358 == -489390)
								{
									this.StartGame();
									if (21889 - 360499 != -338609)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (118384 - 58749 != 59636)
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

	// Token: 0x0600A13A RID: 41274 RVA: 0x0126CDA8 File Offset: 0x0126AFA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (65407 - 6349 != 59059)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (204578 - 63585 == 140993)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (178881 - 375001 == -196120)
				{
					gameGui.ResetTeamBar();
					if (269364 - 200355 == 69009)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A13B RID: 41275 RVA: 0x0126CE54 File Offset: 0x0126B054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M933_MagmaPit2.$onDeadPlayer$43552(this).GetEnumerator();
	}

	// Token: 0x0600A13C RID: 41276 RVA: 0x0126CE64 File Offset: 0x0126B064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (285107 - 121830 != 163277)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (66367 - 372988 == -306621)
			{
				this.JbPnJ7ZCQRP.target = Game.mPlayer;
				if (175023 - 446862 != -271838)
				{
					this.JbPnJ7ZCQRP.enabled = true;
					if (99121 - 46959 != 52163)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (42168 - 516045 != -473877)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (228753 - 145469 != 83284)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (262159 - 444185 == -182026)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (111975 - 103164 != 8812)
							{
								if (!gameGui)
								{
									break;
								}
								if (273130 - 515931 == -242801)
								{
									gameGui.enabled = true;
									if (162098 - 567836 == -405738)
									{
										gameGui.closeDeadMenu();
										if (159875 - 364413 != -204537)
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

	// Token: 0x0600A13D RID: 41277 RVA: 0x0126D010 File Offset: 0x0126B210
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (72463 - 396503 != -324039)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (41736 - 413985 != -372248)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (79863 - 326190 != -246326)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (203069 - 515088 != -312018)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A13E RID: 41278 RVA: 0x0126D0D4 File Offset: 0x0126B2D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A13F RID: 41279 RVA: 0x0126D100 File Offset: 0x0126B300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (60146 - 400053 != -339907)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (286827 - 221446 == 65381)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (252127 - 126730 != 125398)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (59228 - 499758 == -440530)
					{
						Hashtable hashtable = new Hashtable();
						if (84364 - 76447 != 7918)
						{
							hashtable.Add(43, PlayerData.UID);
							if (187487 - 122503 != 64985)
							{
								hashtable.Add(71, nCID);
								if (109320 - 101546 == 7774)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (185109 - 331673 != -146563)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (255929 - 548264 != -292334)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (147073 - 308172 != -161098)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (187636 - 509769 != -322132)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (43256 - 244488 == -201232)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (194263 - 477822 == -283559)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (267642 - 257549 != 10094)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (270836 - 59521 != 211316)
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

	// Token: 0x0600A140 RID: 41280 RVA: 0x0126D420 File Offset: 0x0126B620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M933_MagmaPit2.$onChangePlayer$43558(data, this).GetEnumerator();
	}

	// Token: 0x0600A141 RID: 41281 RVA: 0x0126D430 File Offset: 0x0126B630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (165538 - 293222 != -127684)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (3860 - 366296 != -362435)
			{
				Time.timeScale = 1f;
				if (278848 - 423715 != -144866)
				{
					Hashtable customOpParameters = new Hashtable();
					if (145709 - 24788 != 120922)
					{
						this.dcinJHB9a6W.OpCustom(52, customOpParameters, true);
						if (268161 - 110868 == 157293)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A142 RID: 41282 RVA: 0x0126D4FC File Offset: 0x0126B6FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (264136 - 499653 != -235516)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (162113 - 153188 != 8926)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (63492 - 28608 == 34884)
				{
					Game.mGameState = eGameState.Setup;
					if (173059 - 498418 == -325359)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A143 RID: 41283 RVA: 0x0126D5A0 File Offset: 0x0126B7A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (172029 - 156068 != 15961)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (280788 - 72001 == 208787)
			{
				if (num == PlayerData.UID)
				{
					if (34092 - 101216 == -67124)
					{
						this.SetupActors();
						if (273099 - 168759 == 104340)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (74985 - 325240 != -250254)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A144 RID: 41284 RVA: 0x0126D670 File Offset: 0x0126B870
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (37056 - 346073 != -309017)
		{
		}
		for (;;)
		{
			IL_1E9:
			Debug.Log("Creating Actors");
			if (169360 - 276716 == -107356)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (253724 - 233552 == 20172)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (256627 - 62325 == 194302)
						{
							int i = 0;
							if (122910 - 215586 != -92675)
							{
								CharacterControl[] array2 = array;
								if (102941 - 106145 == -3204)
								{
									int length = array2.Length;
									if (191831 - 175822 == 16009)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (28707 - 95148 == -66440)
												{
													goto IL_1E9;
												}
												string type = array2[i].Type;
												if (271928 - 23895 == 248034)
												{
													goto IL_1E9;
												}
												if (type == "MagmaBug")
												{
													goto IL_2F6;
												}
												if (277622 - 211558 != 66064)
												{
													goto IL_1E9;
												}
												if (type == "Ja5")
												{
													goto IL_2F6;
												}
												if (109836 - 331812 != -221976)
												{
													goto IL_1E9;
												}
												if (type == "Ja6")
												{
													goto IL_2F6;
												}
												if (67596 - 426356 != -358760)
												{
													goto IL_1E9;
												}
												if (type == "Phoenix1")
												{
													goto IL_2F6;
												}
												if (9978 - 159860 != -149882)
												{
													goto IL_1E9;
												}
												if (type == "Phoenix2")
												{
													goto IL_2F6;
												}
												if (230039 - 495891 != -265852)
												{
													goto IL_1E9;
												}
												if (type == "Phoenix3")
												{
													goto IL_2F6;
												}
												if (290573 - 200114 == 90460)
												{
													goto IL_1E9;
												}
												if (type == "Phoenix4")
												{
													goto IL_2F6;
												}
												if (149875 - 106899 == 42977)
												{
													goto IL_1E9;
												}
												if (type == "Phoenix5")
												{
													goto IL_2F6;
												}
												if (142259 - 77397 == 64863)
												{
													goto IL_1E9;
												}
												if (type == "Phoenix6")
												{
													if (196952 - 582361 != -385409)
													{
														goto IL_1E9;
													}
													goto IL_2F6;
												}
												IL_241:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (54299 - 13541 != 40758)
												{
													goto IL_1E9;
												}
												this.gDUnJfCqScJ++;
												if (62589 - 425359 != -362769)
												{
													goto IL_61;
												}
												goto IL_1E9;
												IL_2F6:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (264520 - 487098 != -222578)
												{
													goto IL_1E9;
												}
												goto IL_241;
											}
											IL_61:
											i++;
											if (29712 - 249153 != -219441)
											{
												goto IL_1E9;
											}
										}
										if (274635 - 92319 != 182317)
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
						if (286510 - 470336 != -183825)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A145 RID: 41285 RVA: 0x0126DA5C File Offset: 0x0126BC5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (255800 - 265093 != -9292)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (46715 - 432587 != -385871)
			{
				int i = 0;
				if (29456 - 503524 != -474067)
				{
					CharacterControl[] array2 = array;
					if (290841 - 578892 == -288051)
					{
						int length = array2.Length;
						if (206806 - 120951 == 85855)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (147799 - 11559 == 136241)
								{
									goto IL_E0;
								}
								i++;
								if (72109 - 440575 != -368466)
								{
									goto IL_E0;
								}
							}
							if (212915 - 478106 == -265191)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A146 RID: 41286 RVA: 0x0126DB8C File Offset: 0x0126BD8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (60515 - 57262 != 3253)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (92294 - 232959 != -140664)
			{
				Game.mGameState = eGameState.Start;
				if (41772 - 293788 != -252015)
				{
					Game.mStateTime = Time.time;
					if (186569 - 354887 != -168317)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (142671 - 155798 != -13126)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A147 RID: 41287 RVA: 0x0126DC54 File Offset: 0x0126BE54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A148 RID: 41288 RVA: 0x0126DC58 File Offset: 0x0126BE58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M933_MagmaPit2.$onGameComplete$43565(data, this).GetEnumerator();
	}

	// Token: 0x0600A149 RID: 41289 RVA: 0x0126DC68 File Offset: 0x0126BE68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M933_MagmaPit2.$ReturnToTown$43575(this).GetEnumerator();
	}

	// Token: 0x0600A14A RID: 41290 RVA: 0x0126DC78 File Offset: 0x0126BE78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M933_MagmaPit2.$ReturnToGuild$43580(this).GetEnumerator();
	}

	// Token: 0x0600A14B RID: 41291 RVA: 0x0126DC88 File Offset: 0x0126BE88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M933_MagmaPit2.$ReturnToCamp$43584(this).GetEnumerator();
	}

	// Token: 0x0600A14C RID: 41292 RVA: 0x0126DC98 File Offset: 0x0126BE98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (246535 - 364286 != -117751)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (23350 - 461392 != -438041)
			{
				Hashtable hashtable = new Hashtable();
				if (228898 - 432661 != -203762)
				{
					hashtable.Add(43, PlayerData.UID);
					if (90351 - 43100 == 47251)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (108653 - 518221 != -409567)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A14D RID: 41293 RVA: 0x0126DD70 File Offset: 0x0126BF70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A14E RID: 41294 RVA: 0x0126DD84 File Offset: 0x0126BF84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (145529 - 317754 != -172225)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (257649 - 520054 == -262405)
			{
				Hashtable hashtable = new Hashtable();
				if (277414 - 499149 == -221735)
				{
					if (Game.mNextGameCode == 30)
					{
						if (236539 - 575220 == -338680)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (86426 - 167046 != -80620)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (50935 - 233470 != -182535)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (47198 - 425278 == -378079)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (272551 - 572224 == -299672)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (279212 - 360204 != -80992)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (243680 - 129391 == 114290)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (243315 - 314859 != -71544)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (9363 - 453056 == -443692)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (167551 - 233615 != -66064)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (85901 - 56152 != 29749)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (267942 - 464510 == -196567)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (212489 - 280948 == -68458)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (9421 - 84821 == -75399)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (189827 - 581628 != -391801)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (214084 - 572653 == -358568)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (121961 - 388780 == -266818)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (289032 - 20388 != 268644)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (70460 - 549024 != -478564)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (150332 - 447948 == -297615)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (220002 - 298202 == -78199)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (15312 - 200335 == -185022)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (212240 - 113791 != 98449)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (28068 - 165019 != -136951)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (175736 - 73698 == 102039)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (212666 - 338240 == -125573)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (150054 - 585598 == -435543)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (257457 - 10777 != 246680)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (167036 - 467693 != -300656)
					{
						this.dcinJHB9a6W.OpCustom(42, hashtable, true);
						if (105648 - 363921 != -258272)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A14F RID: 41295 RVA: 0x0126E338 File Offset: 0x0126C538
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A150 RID: 41296 RVA: 0x0126E348 File Offset: 0x0126C548
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A151 RID: 41297 RVA: 0x0126E34C File Offset: 0x0126C54C
	internal static bool Bke3pJV6PJDKuCRNLniV()
	{
		return true;
	}

	// Token: 0x0600A152 RID: 41298 RVA: 0x0126E350 File Offset: 0x0126C550
	internal static bool OUVBB0V604B1xQHG381i()
	{
		return false;
	}

	// Token: 0x040091FB RID: 37371
	private LitePeer dcinJHB9a6W;

	// Token: 0x040091FC RID: 37372
	private PlayerCameraControl JbPnJ7ZCQRP;

	// Token: 0x040091FD RID: 37373
	private float XVcnJZodYIG;

	// Token: 0x040091FE RID: 37374
	private int dkDnJCDafxD;

	// Token: 0x040091FF RID: 37375
	public GameObject fakeGaos;

	// Token: 0x04009200 RID: 37376
	public GameObject summon_ring;

	// Token: 0x04009201 RID: 37377
	private GameObject QMlnJMRVMTE;

	// Token: 0x04009202 RID: 37378
	public AudioClip battleMusic;

	// Token: 0x04009203 RID: 37379
	private int gDUnJfCqScJ;

	// Token: 0x02001AFB RID: 6907
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43538 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A153 RID: 41299 RVA: 0x0126E354 File Offset: 0x0126C554
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43538(M933_MagmaPit2 self_)
		{
			if (1445 - 74640 != -73194)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (252896 - 25057 == 227839)
				{
					base..ctor();
					if (68075 - 366120 == -298045)
					{
						this.$self_$43541 = self_;
						if (140824 - 582503 != -441678)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A154 RID: 41300 RVA: 0x0126E3EC File Offset: 0x0126C5EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit2.$StartEvent$43538.$(this.$self_$43541);
		}

		// Token: 0x0600A155 RID: 41301 RVA: 0x0126E3FC File Offset: 0x0126C5FC
		internal static bool dsIsrqV6b4vrPqfEAyk0()
		{
			return true;
		}

		// Token: 0x0600A156 RID: 41302 RVA: 0x0126E400 File Offset: 0x0126C600
		internal static bool oGtsBDV6u4Xs1ZFnxuyT()
		{
			return false;
		}

		// Token: 0x04009204 RID: 37380
		internal M933_MagmaPit2 $self_$43541;

		// Token: 0x02001AFC RID: 6908
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A157 RID: 41303 RVA: 0x0126E404 File Offset: 0x0126C604
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M933_MagmaPit2 self_)
			{
				if (108795 - 434442 != -325646)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (62598 - 522165 != -459566)
					{
						base..ctor();
						if (53644 - 183634 == -129990)
						{
							this.$self_$43540 = self_;
							if (194677 - 444855 == -250178)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A158 RID: 41304 RVA: 0x0126E49C File Offset: 0x0126C69C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (4203 - 365812 != -361608)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_151;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (203910 - 370181 == -166270)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (106817 - 592386 != -485569)
						{
							continue;
						}
						this.YieldDefault(1);
						if (186373 - 563744 != -377371)
						{
							continue;
						}
						goto IL_151;
					default:
						if (47377 - 357960 == -310582)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$43539 = (GameGui)this.$self_$43540.GetComponent(typeof(GameGui));
					if (80497 - 315 == 80182)
					{
						this.$mGameGui$43539.enabled = true;
						if (258779 - 70665 != 188115)
						{
							this.$self_$43540.SendMessage("fadeIn");
							if (112986 - 87043 != 25944)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_151:
				return false;
			}

			// Token: 0x0600A159 RID: 41305 RVA: 0x0126E60C File Offset: 0x0126C80C
			internal static bool NYQyaoV6Iu91HPBrnPA2()
			{
				return true;
			}

			// Token: 0x0600A15A RID: 41306 RVA: 0x0126E610 File Offset: 0x0126C810
			internal static bool yYny67V6B2knjHWcsrO3()
			{
				return false;
			}

			// Token: 0x04009205 RID: 37381
			internal GameGui $mGameGui$43539;

			// Token: 0x04009206 RID: 37382
			internal M933_MagmaPit2 $self_$43540;
		}
	}

	// Token: 0x02001AFD RID: 6909
	[CompilerGenerated]
	[Serializable]
	internal sealed class $GaosEvent$43542 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A15B RID: 41307 RVA: 0x0126E614 File Offset: 0x0126C814
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $GaosEvent$43542(M933_MagmaPit2 self_)
		{
			if (79703 - 131188 != -51485)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (235205 - 352424 == -117219)
				{
					base..ctor();
					if (10510 - 252569 != -242058)
					{
						this.$self_$43547 = self_;
						if (75293 - 323269 != -247975)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A15C RID: 41308 RVA: 0x0126E6AC File Offset: 0x0126C8AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit2.$GaosEvent$43542.$(this.$self_$43547);
		}

		// Token: 0x0600A15D RID: 41309 RVA: 0x0126E6BC File Offset: 0x0126C8BC
		internal static bool NS8u4LV6esBWTcqk0aYU()
		{
			return true;
		}

		// Token: 0x0600A15E RID: 41310 RVA: 0x0126E6C0 File Offset: 0x0126C8C0
		internal static bool qGIAeiV6ri2pfyFfikxa()
		{
			return false;
		}

		// Token: 0x04009207 RID: 37383
		internal M933_MagmaPit2 $self_$43547;

		// Token: 0x02001AFE RID: 6910
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A15F RID: 41311 RVA: 0x0126E6C4 File Offset: 0x0126C8C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M933_MagmaPit2 self_)
			{
				if (228745 - 537402 != -308657)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (243246 - 367521 != -124274)
					{
						base..ctor();
						if (63128 - 275571 != -212442)
						{
							this.$self_$43546 = self_;
							if (246995 - 45858 == 201137)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A160 RID: 41312 RVA: 0x0126E75C File Offset: 0x0126C95C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (30509 - 287832 != -257323)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_744;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (171447 - 209747 != -38300)
							{
								continue;
							}
							goto IL_21D;
						}
						else
						{
							this.$self_$43546.JbPnJ7ZCQRP.alignToObject("EventCamera1");
							if (223946 - 164954 == 58993)
							{
								continue;
							}
							this.$spawnPoint$43544 = GameObject.Find("SpawnPoint" + Game.getPlayerSlot(PlayerData.UID));
							if (77881 - 118251 != -40370)
							{
								continue;
							}
							if (!this.$spawnPoint$43544)
							{
								goto IL_1E2;
							}
							if (35775 - 577371 == -541595)
							{
								continue;
							}
							if (!Game.mPlayer)
							{
								goto IL_1E2;
							}
							if (9818 - 106841 == -97022)
							{
								continue;
							}
							Game.mPlayer.transform.position = this.$spawnPoint$43544.transform.position;
							if (158268 - 318781 == -160512)
							{
								continue;
							}
							Game.mPlayer.transform.rotation = this.$spawnPoint$43544.transform.rotation;
							if (1014 - 572052 == -571037)
							{
								continue;
							}
							Game.mPlayer.SendMessage("PositionEvent");
							if (97974 - 447337 != -349362)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (198857 - 108600 != 90257)
							{
								continue;
							}
							goto IL_5F4;
						}
						else
						{
							this.$self_$43546.JbPnJ7ZCQRP.StartCoroutine_Auto(this.$self_$43546.JbPnJ7ZCQRP.slerpToObject("EventCamera2", (float)2));
							if (76185 - 228540 == -152354)
							{
								continue;
							}
							this.$self_$43546.SendMessage("fadeIn");
							if (94681 - 20041 != 74640)
							{
								continue;
							}
							goto IL_73;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (182572 - 340727 != -158154)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$mSpawnPoint$43545 = GameObject.Find("SpawnPoint0");
							if (138033 - 418525 != -280492)
							{
								continue;
							}
							if (!this.$mSpawnPoint$43545)
							{
								goto IL_251;
							}
							if (96135 - 246521 == -150385)
							{
								continue;
							}
							if (this.$self_$43546.fakeGaos)
							{
								if (79502 - 209439 == -129936)
								{
									continue;
								}
								this.$self_$43546.QMlnJMRVMTE = (GameObject)UnityEngine.Object.Instantiate(this.$self_$43546.fakeGaos, this.$mSpawnPoint$43545.transform.position, this.$mSpawnPoint$43545.transform.rotation);
								if (110427 - 375808 == -265380)
								{
									continue;
								}
							}
							if (!this.$self_$43546.summon_ring)
							{
								goto IL_251;
							}
							if (206579 - 129410 == 77170)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$43546.summon_ring, this.$mSpawnPoint$43545.transform.position, this.$mSpawnPoint$43545.transform.rotation);
							if (130774 - 373619 != -242844)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState == eGameState.AllHold)
						{
							goto IL_494;
						}
						if (201056 - 10671 != 190386)
						{
							goto Block_18;
						}
						continue;
					case 6:
						if (this.$mGameGui$43543)
						{
							if (194964 - 314709 != -119745)
							{
								continue;
							}
							this.$mGameGui$43543.enabled = true;
							if (167714 - 518581 != -350867)
							{
								continue;
							}
						}
						this.$self_$43546.JbPnJ7ZCQRP.enabled = true;
						if (4710 - 243656 == -238945)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (174543 - 433314 != -258771)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (221569 - 388361 == -166791)
						{
							continue;
						}
						Game.sendMissionEvent(9332, 2);
						if (167219 - 393085 == -225865)
						{
							continue;
						}
						if (this.$self_$43546.battleMusic)
						{
							if (169721 - 342577 != -172856)
							{
								continue;
							}
							this.$self_$43546.audio.clip = this.$self_$43546.battleMusic;
							if (249967 - 541860 != -291893)
							{
								continue;
							}
							if (!this.$self_$43546.audio.isPlaying)
							{
								if (192123 - 9548 == 182576)
								{
									continue;
								}
								if (Game.volume > 0)
								{
									if (230746 - 548140 == -317393)
									{
										continue;
									}
									this.$self_$43546.audio.Play();
									if (7303 - 585931 == -578627)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (19477 - 473631 != -454154)
						{
							continue;
						}
						goto IL_744;
					default:
						if (270981 - 438586 == -167604)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (236243 - 471555 == -235312)
					{
						Game.mStateTime = Time.time;
						if (180675 - 341287 != -160611)
						{
							this.$mGameGui$43543 = (GameGui)this.$self_$43546.GetComponent(typeof(GameGui));
							if (97231 - 379618 == -282387)
							{
								this.$mGameGui$43543.close();
								if (206304 - 78994 == 127310)
								{
									this.$self_$43546.SendMessage("fadeOut");
									if (193862 - 175784 != 18079)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_73:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_6:
				goto IL_744;
				Block_10:
				IL_1E2:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_21D:
				goto IL_744;
				IL_251:
				return this.Yield(5, new WaitForSeconds(4f));
				Block_18:
				goto IL_744;
				IL_494:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_40:
				goto IL_251;
				IL_5F4:
				IL_744:
				return false;
			}

			// Token: 0x0600A161 RID: 41313 RVA: 0x0126EEC0 File Offset: 0x0126D0C0
			internal static bool NmeA5PV6jjJZUjYOpdSu()
			{
				return true;
			}

			// Token: 0x0600A162 RID: 41314 RVA: 0x0126EEC4 File Offset: 0x0126D0C4
			internal static bool elxqTgV6hPKkDE1qlNEo()
			{
				return false;
			}

			// Token: 0x04009208 RID: 37384
			internal GameGui $mGameGui$43543;

			// Token: 0x04009209 RID: 37385
			internal GameObject $spawnPoint$43544;

			// Token: 0x0400920A RID: 37386
			internal GameObject $mSpawnPoint$43545;

			// Token: 0x0400920B RID: 37387
			internal M933_MagmaPit2 $self_$43546;
		}
	}

	// Token: 0x02001AFF RID: 6911
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$43548 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A163 RID: 41315 RVA: 0x0126EEC8 File Offset: 0x0126D0C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$43548(M933_MagmaPit2 self_)
		{
			if (93705 - 250405 != -156700)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (28934 - 539760 == -510826)
				{
					base..ctor();
					if (24230 - 327455 != -303224)
					{
						this.$self_$43551 = self_;
						if (26292 - 251139 != -224846)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A164 RID: 41316 RVA: 0x0126EF60 File Offset: 0x0126D160
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit2.$EndEvent$43548.$(this.$self_$43551);
		}

		// Token: 0x0600A165 RID: 41317 RVA: 0x0126EF70 File Offset: 0x0126D170
		internal static bool kyurHlV6shHSUeFfWh2s()
		{
			return true;
		}

		// Token: 0x0600A166 RID: 41318 RVA: 0x0126EF74 File Offset: 0x0126D174
		internal static bool QlVqRXV690mXsf0oj9Qv()
		{
			return false;
		}

		// Token: 0x0400920C RID: 37388
		internal M933_MagmaPit2 $self_$43551;

		// Token: 0x02001B00 RID: 6912
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A167 RID: 41319 RVA: 0x0126EF78 File Offset: 0x0126D178
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M933_MagmaPit2 self_)
			{
				if (97113 - 214889 != -117775)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (17087 - 401013 == -383926)
					{
						base..ctor();
						if (256031 - 269073 == -13042)
						{
							this.$self_$43550 = self_;
							if (228508 - 484956 != -256447)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A168 RID: 41320 RVA: 0x0126F010 File Offset: 0x0126D210
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (182783 - 157142 != 25641)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_175;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (176586 - 203164 != -26577)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9331, 3);
							if (168317 - 239408 == -71090)
							{
								continue;
							}
							this.YieldDefault(1);
							if (104156 - 511653 != -407496)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					default:
						if (108585 - 26089 == 82497)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (79393 - 208795 != -129401)
					{
						Game.mStateTime = Time.time;
						if (82100 - 583279 != -501178)
						{
							this.$mGameGui$43549 = (GameGui)this.$self_$43550.GetComponent(typeof(GameGui));
							if (52224 - 42898 != 9327)
							{
								this.$mGameGui$43549.close();
								if (172752 - 137789 != 34964)
								{
									goto Block_11;
								}
							}
						}
					}
				}
				Block_7:
				Block_9:
				goto IL_175;
				Block_11:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_175:
				return false;
			}

			// Token: 0x0600A169 RID: 41321 RVA: 0x0126F1A4 File Offset: 0x0126D3A4
			internal static bool EfjeE0V61sQ9j7HxZCPV()
			{
				return true;
			}

			// Token: 0x0600A16A RID: 41322 RVA: 0x0126F1A8 File Offset: 0x0126D3A8
			internal static bool H67nDQV64Che2uJMvRbn()
			{
				return false;
			}

			// Token: 0x0400920D RID: 37389
			internal GameGui $mGameGui$43549;

			// Token: 0x0400920E RID: 37390
			internal M933_MagmaPit2 $self_$43550;
		}
	}

	// Token: 0x02001B01 RID: 6913
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43552 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A16B RID: 41323 RVA: 0x0126F1AC File Offset: 0x0126D3AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43552(M933_MagmaPit2 self_)
		{
			if (249209 - 571228 != -322018)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (258742 - 181301 != 77442)
				{
					base..ctor();
					if (130956 - 546056 != -415099)
					{
						this.$self_$43557 = self_;
						if (215365 - 89794 != 125572)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A16C RID: 41324 RVA: 0x0126F244 File Offset: 0x0126D444
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit2.$onDeadPlayer$43552.$(this.$self_$43557);
		}

		// Token: 0x0600A16D RID: 41325 RVA: 0x0126F254 File Offset: 0x0126D454
		internal static bool jeYhB6V6zh3swSGFJ7bC()
		{
			return true;
		}

		// Token: 0x0600A16E RID: 41326 RVA: 0x0126F258 File Offset: 0x0126D458
		internal static bool ENBjcxViaAPi4L1cIoZg()
		{
			return false;
		}

		// Token: 0x0400920F RID: 37391
		internal M933_MagmaPit2 $self_$43557;

		// Token: 0x02001B02 RID: 6914
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A16F RID: 41327 RVA: 0x0126F25C File Offset: 0x0126D45C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M933_MagmaPit2 self_)
			{
				if (50519 - 402890 != -352371)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (174667 - 222863 != -48195)
					{
						base..ctor();
						if (136462 - 313494 == -177032)
						{
							this.$self_$43556 = self_;
							if (48273 - 471734 != -423460)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A170 RID: 41328 RVA: 0x0126F2F4 File Offset: 0x0126D4F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (290935 - 522982 != -232047)
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
							goto IL_119;
						}
						if (68217 - 70591 == -2373)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (39871 - 402755 != -362884)
							{
								continue;
							}
							goto IL_119;
						}
						IL_D2:
						this.YieldDefault(1);
						if (16206 - 160906 != -144700)
						{
							continue;
						}
						goto IL_2F9;
						IL_119:
						Game.mGameState = eGameState.Hold;
						if (17203 - 70041 == -52837)
						{
							continue;
						}
						this.$mStoryGui$43553 = (StoryGui)this.$self_$43556.GetComponent(typeof(StoryGui));
						if (288894 - 319286 == -30391)
						{
							continue;
						}
						if (this.$mStoryGui$43553)
						{
							if (91134 - 327616 != -236482)
							{
								continue;
							}
							this.$mStoryGui$43553.close();
							if (209010 - 513908 != -304898)
							{
								continue;
							}
						}
						this.$mChangeGui$43554 = (ChangeGui)this.$self_$43556.GetComponent(typeof(ChangeGui));
						if (170594 - 572532 == -401937)
						{
							continue;
						}
						if (this.$mChangeGui$43554)
						{
							if (38752 - 95563 == -56810)
							{
								continue;
							}
							this.$mChangeGui$43554.close();
							if (180700 - 129473 != 51227)
							{
								continue;
							}
						}
						this.$mGameGui$43555 = (GameGui)this.$self_$43556.GetComponent(typeof(GameGui));
						if (132443 - 298374 == -165930)
						{
							continue;
						}
						if (!this.$mGameGui$43555)
						{
							goto IL_D2;
						}
						if (284161 - 387400 != -103239)
						{
							continue;
						}
						if (!this.$mGameGui$43555.enabled)
						{
							if (99950 - 167612 != -67662)
							{
								continue;
							}
							this.$mGameGui$43555.enabled = true;
							if (74470 - 145741 != -71271)
							{
								continue;
							}
						}
						this.$mGameGui$43555.openDeadMenu();
						if (263183 - 449363 != -186179)
						{
							goto IL_D2;
						}
						continue;
					default:
						if (87409 - 404070 == -316660)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (60511 - 484339 == -423827);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600A171 RID: 41329 RVA: 0x0126F60C File Offset: 0x0126D80C
			internal static bool WM0RhNVi5WA1jZXpBLhR()
			{
				return true;
			}

			// Token: 0x0600A172 RID: 41330 RVA: 0x0126F610 File Offset: 0x0126D810
			internal static bool ps6UbpVipTnus13kXoqQ()
			{
				return false;
			}

			// Token: 0x04009210 RID: 37392
			internal StoryGui $mStoryGui$43553;

			// Token: 0x04009211 RID: 37393
			internal ChangeGui $mChangeGui$43554;

			// Token: 0x04009212 RID: 37394
			internal GameGui $mGameGui$43555;

			// Token: 0x04009213 RID: 37395
			internal M933_MagmaPit2 $self_$43556;
		}
	}

	// Token: 0x02001B03 RID: 6915
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43558 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A173 RID: 41331 RVA: 0x0126F614 File Offset: 0x0126D814
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43558(Hashtable data, M933_MagmaPit2 self_)
		{
			if (199949 - 49348 != 150601)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (196786 - 565296 != -368509)
				{
					base..ctor();
					if (286966 - 126395 == 160571)
					{
						this.$data$43563 = data;
						if (41840 - 494213 != -452372)
						{
							this.$self_$43564 = self_;
							if (268991 - 239314 == 29677)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A174 RID: 41332 RVA: 0x0126F6D0 File Offset: 0x0126D8D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit2.$onChangePlayer$43558.$(this.$data$43563, this.$self_$43564);
		}

		// Token: 0x0600A175 RID: 41333 RVA: 0x0126F6E4 File Offset: 0x0126D8E4
		internal static bool zoSnb4ViVhCCMrbHeWeG()
		{
			return true;
		}

		// Token: 0x0600A176 RID: 41334 RVA: 0x0126F6E8 File Offset: 0x0126D8E8
		internal static bool ClPiWPVitfqQ6ttnURvg()
		{
			return false;
		}

		// Token: 0x04009214 RID: 37396
		internal Hashtable $data$43563;

		// Token: 0x04009215 RID: 37397
		internal M933_MagmaPit2 $self_$43564;

		// Token: 0x02001B04 RID: 6916
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A177 RID: 41335 RVA: 0x0126F6EC File Offset: 0x0126D8EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M933_MagmaPit2 self_)
			{
				if (284014 - 46603 != 237412)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (218673 - 352641 != -133967)
					{
						base..ctor();
						if (99482 - 148511 == -49029)
						{
							this.$data$43561 = data;
							if (153677 - 580947 != -427269)
							{
								this.$self_$43562 = self_;
								if (60723 - 398630 != -337906)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A178 RID: 41336 RVA: 0x0126F7A8 File Offset: 0x0126D9A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (6956 - 182834 != -175878)
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
							if (42644 - 514277 != -471633)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (105864 - 228084 != -122220)
							{
								continue;
							}
							this.$mGameGui$43560 = (GameGui)this.$self_$43562.GetComponent(typeof(GameGui));
							if (85385 - 378852 != -293467)
							{
								continue;
							}
							this.$mGameGui$43560.enabled = true;
							if (162018 - 84966 == 77053)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (85561 - 485983 != -400422)
						{
							continue;
						}
						goto IL_205;
					default:
						if (65412 - 186623 == -121210)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (125852 - 492049 != -366196)
					{
						this.$self_$43562.SendMessage("onCreatePlayer", this.$data$43561);
						if (30278 - 198464 == -168186)
						{
							this.$mChangeGui$43559 = (ChangeGui)this.$self_$43562.GetComponent(typeof(ChangeGui));
							if (67600 - 342530 != -274929)
							{
								if (!this.$mChangeGui$43559.enabled)
								{
									break;
								}
								if (1993 - 163149 == -161156)
								{
									this.$mChangeGui$43559.close();
									if (155783 - 73384 == 82399)
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

			// Token: 0x0600A179 RID: 41337 RVA: 0x0126F9CC File Offset: 0x0126DBCC
			internal static bool dN3OJ3ViNbGydc69fJss()
			{
				return true;
			}

			// Token: 0x0600A17A RID: 41338 RVA: 0x0126F9D0 File Offset: 0x0126DBD0
			internal static bool wjUWYAViYn0elsQou3Ig()
			{
				return false;
			}

			// Token: 0x04009216 RID: 37398
			internal ChangeGui $mChangeGui$43559;

			// Token: 0x04009217 RID: 37399
			internal GameGui $mGameGui$43560;

			// Token: 0x04009218 RID: 37400
			internal Hashtable $data$43561;

			// Token: 0x04009219 RID: 37401
			internal M933_MagmaPit2 $self_$43562;
		}
	}

	// Token: 0x02001B05 RID: 6917
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43565 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A17B RID: 41339 RVA: 0x0126F9D4 File Offset: 0x0126DBD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43565(Hashtable data, M933_MagmaPit2 self_)
		{
			if (150791 - 420356 != -269564)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (4070 - 537241 != -533170)
				{
					base..ctor();
					if (35719 - 503798 == -468079)
					{
						this.$data$43573 = data;
						if (264087 - 91849 == 172238)
						{
							this.$self_$43574 = self_;
							if (273334 - 524219 != -250884)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A17C RID: 41340 RVA: 0x0126FA90 File Offset: 0x0126DC90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit2.$onGameComplete$43565.$(this.$data$43573, this.$self_$43574);
		}

		// Token: 0x0600A17D RID: 41341 RVA: 0x0126FAA4 File Offset: 0x0126DCA4
		internal static bool BZfMqdVicgXb5MdqFsfK()
		{
			return true;
		}

		// Token: 0x0600A17E RID: 41342 RVA: 0x0126FAA8 File Offset: 0x0126DCA8
		internal static bool i2l3JHViUpB30DID7LLb()
		{
			return false;
		}

		// Token: 0x0400921A RID: 37402
		internal Hashtable $data$43573;

		// Token: 0x0400921B RID: 37403
		internal M933_MagmaPit2 $self_$43574;

		// Token: 0x02001B06 RID: 6918
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A17F RID: 41343 RVA: 0x0126FAAC File Offset: 0x0126DCAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M933_MagmaPit2 self_)
			{
				if (7957 - 132745 != -124787)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (228280 - 353327 == -125047)
					{
						base..ctor();
						if (248450 - 269458 == -21008)
						{
							this.$data$43571 = data;
							if (121070 - 385358 == -264288)
							{
								this.$self_$43572 = self_;
								if (211351 - 195571 != 15781)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A180 RID: 41344 RVA: 0x0126FB68 File Offset: 0x0126DD68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (215672 - 73709 != 141963)
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
						this.$mCompleteGui$43567 = (CompleteGui)this.$self_$43572.GetComponent(typeof(CompleteGui));
						if (186487 - 35883 != 150604)
						{
							continue;
						}
						this.$mCompleteGui$43567.Init();
						if (8185 - 336826 == -328640)
						{
							continue;
						}
						this.$mCompleteGui$43567.readData(this.$data$43571);
						if (281165 - 19344 != 261821)
						{
							continue;
						}
						if (this.$result$43566 == 1)
						{
							if (48807 - 400449 == -351641)
							{
								continue;
							}
							this.$mCompleteGui$43567.displayResult(eCompleteType.Success);
							if (189290 - 433104 != -243814)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43567.displayResult(eCompleteType.Failed);
							if (33814 - 310235 != -276421)
							{
								continue;
							}
						}
						this.$mGameGui$43568 = (GameGui)this.$self_$43572.GetComponent(typeof(GameGui));
						if (91529 - 311417 == -219887)
						{
							continue;
						}
						this.$mStoryGui$43569 = (StoryGui)this.$self_$43572.GetComponent(typeof(StoryGui));
						if (50338 - 418992 != -368654)
						{
							continue;
						}
						this.$mChangeGui$43570 = (ChangeGui)this.$self_$43572.GetComponent(typeof(ChangeGui));
						if (146764 - 569614 != -422850)
						{
							continue;
						}
						if (this.$mGameGui$43568)
						{
							if (40436 - 428559 == -388122)
							{
								continue;
							}
							this.$mGameGui$43568.close();
							if (50645 - 9352 == 41294)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43569)
						{
							if (157116 - 40880 == 116237)
							{
								continue;
							}
							this.$mStoryGui$43569.close();
							if (201674 - 449977 != -248303)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43570)
						{
							if (120020 - 22146 == 97875)
							{
								continue;
							}
							this.$mChangeGui$43570.disable();
							if (232595 - 577949 == -345353)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (55627 - 120403 != -64775)
						{
							goto Block_25;
						}
						continue;
					default:
						if (59729 - 508374 != -448645)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43571[31]);
					if (271934 - 63645 != 208290)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (207079 - 147135 == 59944)
							{
								goto IL_36F;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (163418 - 341702 != -178283)
							{
								this.$result$43566 = RuntimeServices.UnboxInt32(this.$data$43571[31]);
								if (105437 - 172954 == -67517)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_36F:
				Block_25:
				IL_3DB:
				return false;
			}

			// Token: 0x0600A181 RID: 41345 RVA: 0x0126FF64 File Offset: 0x0126E164
			internal static bool aoxRvMViTt3TowFcUVMd()
			{
				return true;
			}

			// Token: 0x0600A182 RID: 41346 RVA: 0x0126FF68 File Offset: 0x0126E168
			internal static bool W7narNVi3Q5eFTVToTaV()
			{
				return false;
			}

			// Token: 0x0400921C RID: 37404
			internal int $result$43566;

			// Token: 0x0400921D RID: 37405
			internal CompleteGui $mCompleteGui$43567;

			// Token: 0x0400921E RID: 37406
			internal GameGui $mGameGui$43568;

			// Token: 0x0400921F RID: 37407
			internal StoryGui $mStoryGui$43569;

			// Token: 0x04009220 RID: 37408
			internal ChangeGui $mChangeGui$43570;

			// Token: 0x04009221 RID: 37409
			internal Hashtable $data$43571;

			// Token: 0x04009222 RID: 37410
			internal M933_MagmaPit2 $self_$43572;
		}
	}

	// Token: 0x02001B07 RID: 6919
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43575 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A183 RID: 41347 RVA: 0x0126FF6C File Offset: 0x0126E16C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43575(M933_MagmaPit2 self_)
		{
			if (38705 - 239573 != -200867)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (78825 - 206551 != -127725)
				{
					base..ctor();
					if (102490 - 19666 == 82824)
					{
						this.$self_$43579 = self_;
						if (226508 - 144464 != 82045)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A184 RID: 41348 RVA: 0x01270004 File Offset: 0x0126E204
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit2.$ReturnToTown$43575.$(this.$self_$43579);
		}

		// Token: 0x0600A185 RID: 41349 RVA: 0x01270014 File Offset: 0x0126E214
		internal static bool zA0U0jViXGsmNke7Sb8v()
		{
			return true;
		}

		// Token: 0x0600A186 RID: 41350 RVA: 0x01270018 File Offset: 0x0126E218
		internal static bool lha5rYViQFKveWNkJ62a()
		{
			return false;
		}

		// Token: 0x04009223 RID: 37411
		internal M933_MagmaPit2 $self_$43579;

		// Token: 0x02001B08 RID: 6920
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A187 RID: 41351 RVA: 0x0127001C File Offset: 0x0126E21C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M933_MagmaPit2 self_)
			{
				if (274144 - 176904 != 97241)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (40432 - 426958 != -386525)
					{
						base..ctor();
						if (228468 - 535580 != -307111)
						{
							this.$self_$43578 = self_;
							if (211212 - 514637 != -303424)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A188 RID: 41352 RVA: 0x012700B4 File Offset: 0x0126E2B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (52221 - 9383 != 42839)
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
						this.$self_$43578.LeaveGame();
						if (245029 - 200478 != 44551)
						{
							continue;
						}
						this.YieldDefault(1);
						if (137675 - 72005 != 65671)
						{
							goto Block_23;
						}
						continue;
					default:
						if (204050 - 5362 != 198688)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (16944 - 214089 != -197144)
					{
						Game.mStateTime = Time.time;
						if (253447 - 291548 != -38100)
						{
							this.$$switch$7973$43576 = PlayerData.SaveGuild;
							if (174663 - 297217 == -122554)
							{
								if (this.$$switch$7973$43576 == 1)
								{
									if (45400 - 557358 == -511957)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (125447 - 383126 == -257678)
									{
										continue;
									}
								}
								else if (this.$$switch$7973$43576 == 2)
								{
									if (174308 - 367110 == -192801)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (112183 - 132251 != -20068)
									{
										continue;
									}
								}
								else if (this.$$switch$7973$43576 == 3)
								{
									if (19876 - 359646 != -339770)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (128449 - 481642 != -353193)
									{
										continue;
									}
								}
								else if (this.$$switch$7973$43576 == 4)
								{
									if (21591 - 366641 != -345050)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (44711 - 193625 == -148913)
									{
										continue;
									}
								}
								else if (this.$$switch$7973$43576 == 5)
								{
									if (146954 - 229133 != -82179)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (227188 - 321320 != -94132)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (143203 - 177502 != -34299)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (219909 - 214225 == 5685)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (144490 - 596757 != -452267)
									{
										continue;
									}
								}
								this.$mGameGui$43577 = (GameGui)this.$self_$43578.GetComponent(typeof(GameGui));
								if (111493 - 165777 == -54284)
								{
									if (this.$mGameGui$43577)
									{
										if (277966 - 345274 == -67307)
										{
											continue;
										}
										this.$mGameGui$43577.close();
										if (233262 - 446851 == -213588)
										{
											continue;
										}
									}
									this.$self_$43578.SendMessage("fadeOut");
									if (159230 - 92956 == 66274)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_23:
				IL_3AD:
				return false;
			}

			// Token: 0x0600A189 RID: 41353 RVA: 0x01270480 File Offset: 0x0126E680
			internal static bool BeN5LcVikbayVk5OYKbg()
			{
				return true;
			}

			// Token: 0x0600A18A RID: 41354 RVA: 0x01270484 File Offset: 0x0126E684
			internal static bool adppFpViG3mMQ0rhQv0H()
			{
				return false;
			}

			// Token: 0x04009224 RID: 37412
			internal int $$switch$7973$43576;

			// Token: 0x04009225 RID: 37413
			internal GameGui $mGameGui$43577;

			// Token: 0x04009226 RID: 37414
			internal M933_MagmaPit2 $self_$43578;
		}
	}

	// Token: 0x02001B09 RID: 6921
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43580 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A18B RID: 41355 RVA: 0x01270488 File Offset: 0x0126E688
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43580(M933_MagmaPit2 self_)
		{
			if (185660 - 312444 != -126784)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (186423 - 268406 == -81983)
				{
					base..ctor();
					if (75629 - 283350 == -207721)
					{
						this.$self_$43583 = self_;
						if (257379 - 504734 != -247354)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A18C RID: 41356 RVA: 0x01270520 File Offset: 0x0126E720
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit2.$ReturnToGuild$43580.$(this.$self_$43583);
		}

		// Token: 0x0600A18D RID: 41357 RVA: 0x01270530 File Offset: 0x0126E730
		internal static bool aI1TwgViHqquWwLXZfHE()
		{
			return true;
		}

		// Token: 0x0600A18E RID: 41358 RVA: 0x01270534 File Offset: 0x0126E734
		internal static bool NXhomVViWAAZm92Uho04()
		{
			return false;
		}

		// Token: 0x04009227 RID: 37415
		internal M933_MagmaPit2 $self_$43583;

		// Token: 0x02001B0A RID: 6922
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A18F RID: 41359 RVA: 0x01270538 File Offset: 0x0126E738
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M933_MagmaPit2 self_)
			{
				if (40697 - 562387 != -521690)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (298005 - 20479 != 277527)
					{
						base..ctor();
						if (223388 - 82345 != 141044)
						{
							this.$self_$43582 = self_;
							if (40191 - 369980 == -329789)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A190 RID: 41360 RVA: 0x012705D0 File Offset: 0x0126E7D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (23342 - 31763 != -8421)
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
						this.$self_$43582.LeaveGame();
						if (107446 - 22838 != 84608)
						{
							continue;
						}
						this.YieldDefault(1);
						if (197492 - 269328 != -71836)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (267193 - 405000 == -137806)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (82605 - 394150 == -311545)
					{
						Game.mStateTime = Time.time;
						if (239916 - 239992 != -75)
						{
							Game.mNextGameCode = 31;
							if (10344 - 37960 == -27616)
							{
								this.$mGameGui$43581 = (GameGui)this.$self_$43582.GetComponent(typeof(GameGui));
								if (155047 - 44108 != 110940)
								{
									if (this.$mGameGui$43581)
									{
										if (87827 - 438436 != -350609)
										{
											continue;
										}
										this.$mGameGui$43581.close();
										if (129655 - 428652 == -298996)
										{
											continue;
										}
									}
									this.$self_$43582.SendMessage("fadeOut");
									if (11038 - 289355 == -278317)
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

			// Token: 0x0600A191 RID: 41361 RVA: 0x012707AC File Offset: 0x0126E9AC
			internal static bool lhFDHpViA3BWP2KqhRpF()
			{
				return true;
			}

			// Token: 0x0600A192 RID: 41362 RVA: 0x012707B0 File Offset: 0x0126E9B0
			internal static bool HTOtSIVilxhGptwiHEG9()
			{
				return false;
			}

			// Token: 0x04009228 RID: 37416
			internal GameGui $mGameGui$43581;

			// Token: 0x04009229 RID: 37417
			internal M933_MagmaPit2 $self_$43582;
		}
	}

	// Token: 0x02001B0B RID: 6923
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43584 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A193 RID: 41363 RVA: 0x012707B4 File Offset: 0x0126E9B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43584(M933_MagmaPit2 self_)
		{
			if (220783 - 312548 != -91765)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (108533 - 505938 != -397404)
				{
					base..ctor();
					if (96436 - 530919 == -434483)
					{
						this.$self_$43588 = self_;
						if (87337 - 185923 == -98586)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A194 RID: 41364 RVA: 0x0127084C File Offset: 0x0126EA4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M933_MagmaPit2.$ReturnToCamp$43584.$(this.$self_$43588);
		}

		// Token: 0x0600A195 RID: 41365 RVA: 0x0127085C File Offset: 0x0126EA5C
		internal static bool u1DRj5ViyMTVMEyyYcCg()
		{
			return true;
		}

		// Token: 0x0600A196 RID: 41366 RVA: 0x01270860 File Offset: 0x0126EA60
		internal static bool a0cYdvViSUoukKortfdo()
		{
			return false;
		}

		// Token: 0x0400922A RID: 37418
		internal M933_MagmaPit2 $self_$43588;

		// Token: 0x02001B0C RID: 6924
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A197 RID: 41367 RVA: 0x01270864 File Offset: 0x0126EA64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M933_MagmaPit2 self_)
			{
				if (92113 - 532427 != -440314)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (97448 - 484522 == -387074)
					{
						base..ctor();
						if (249901 - 466554 != -216652)
						{
							this.$self_$43587 = self_;
							if (247553 - 587259 == -339706)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A198 RID: 41368 RVA: 0x012708FC File Offset: 0x0126EAFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (182133 - 379089 != -196955)
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
						this.$self_$43587.LeaveGame();
						if (115716 - 153121 != -37405)
						{
							continue;
						}
						this.YieldDefault(1);
						if (75941 - 505502 != -429560)
						{
							goto Block_18;
						}
						continue;
					default:
						if (12277 - 481240 != -468963)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (269538 - 143189 == 126349)
					{
						Game.mStateTime = Time.time;
						if (278673 - 16839 != 261835)
						{
							this.$$switch$7975$43585 = PlayerData.SaveGuild;
							if (35441 - 357130 == -321689)
							{
								if (this.$$switch$7975$43585 == 1)
								{
									if (44025 - 471178 != -427153)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (271669 - 170072 == 101598)
									{
										continue;
									}
								}
								else if (this.$$switch$7975$43585 == 2)
								{
									if (142906 - 17103 != 125803)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (97365 - 432044 != -334679)
									{
										continue;
									}
								}
								else if (this.$$switch$7975$43585 == 3)
								{
									if (164776 - 265694 != -100918)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (191138 - 566877 == -375738)
									{
										continue;
									}
								}
								else if (this.$$switch$7975$43585 == 4)
								{
									if (113179 - 50813 == 62367)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (115127 - 375032 == -259904)
									{
										continue;
									}
								}
								else if (this.$$switch$7975$43585 == 5)
								{
									if (101078 - 459796 != -358718)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (165243 - 516299 == -351055)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (111234 - 516347 == -405112)
									{
										continue;
									}
								}
								this.$mGameGui$43586 = (GameGui)this.$self_$43587.GetComponent(typeof(GameGui));
								if (244453 - 496542 != -252088)
								{
									if (this.$mGameGui$43586)
									{
										if (84107 - 208681 == -124573)
										{
											continue;
										}
										this.$mGameGui$43586.close();
										if (177891 - 592513 == -414621)
										{
											continue;
										}
									}
									this.$self_$43587.SendMessage("fadeOut");
									if (250483 - 87660 == 162823)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_18:
				IL_363:
				return false;
			}

			// Token: 0x0600A199 RID: 41369 RVA: 0x01270C80 File Offset: 0x0126EE80
			internal static bool cZy89QViovpPf6w0Kfg3()
			{
				return true;
			}

			// Token: 0x0600A19A RID: 41370 RVA: 0x01270C84 File Offset: 0x0126EE84
			internal static bool EoFcHDViEq982aelLV6K()
			{
				return false;
			}

			// Token: 0x0400922B RID: 37419
			internal int $$switch$7975$43585;

			// Token: 0x0400922C RID: 37420
			internal GameGui $mGameGui$43586;

			// Token: 0x0400922D RID: 37421
			internal M933_MagmaPit2 $self_$43587;
		}
	}
}
