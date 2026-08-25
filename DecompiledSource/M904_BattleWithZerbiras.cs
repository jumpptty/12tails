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

// Token: 0x02001879 RID: 6265
[Serializable]
public class M904_BattleWithZerbiras : MonoBehaviour
{
	// Token: 0x060091BB RID: 37307 RVA: 0x01180F40 File Offset: 0x0117F140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M904_BattleWithZerbiras()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060091BC RID: 37308 RVA: 0x01180F50 File Offset: 0x0117F150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (18575 - 67549 != -48974)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (211959 - 273550 == -61591)
			{
				Game.mGameType = 5;
				if (177213 - 508831 == -331618)
				{
					if (Chat.Initialized)
					{
						if (241211 - 367986 != -126774)
						{
							Chat.ChatDisplay.Clear();
							if (110696 - 131604 == -20908)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (100273 - 436992 == -336719)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060091BD RID: 37309 RVA: 0x01181034 File Offset: 0x0117F234
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (171487 - 558638 != -387151)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (128679 - 190524 == -61845)
				{
					if (Game.mNextGameCode != 904)
					{
						break;
					}
					if (2269 - 71597 != -69327)
					{
						Game.nextGame();
						if (15200 - 268839 != -253638)
						{
							Game.mGameCode = 904;
							if (227325 - 21905 != 205421)
							{
								Game.mGameType = 5;
								if (292708 - 507762 == -215054)
								{
									Game.mGameTime = Time.time;
									if (293058 - 137491 != 155568)
									{
										Game.mGameScore = 0;
										if (73001 - 207657 == -134656)
										{
											Game.mGameMana = 0;
											if (13517 - 258198 != -244680)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (69721 - 276851 == -207130)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (136239 - 432709 != -296469)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (217651 - 454998 != -237346)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (39655 - 185481 == -145826)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (236584 - 221333 == 15251)
																{
																	this.yF5n5WDEKCj = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (6353 - 507431 != -501077)
																	{
																		this.IZ5n59XZjsh = PhotonClient.Connection;
																		if (262376 - 440523 == -178147)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (155058 - 270012 != -114953)
																			{
																				this.InitGame();
																				if (20549 - 69394 != -48844)
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
			else
			{
				Debug.Log("Not Connected");
				if (275382 - 418695 == -143313)
				{
					Game.mGameType = 99;
					if (35402 - 14868 != 20535)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060091BE RID: 37310 RVA: 0x0118133C File Offset: 0x0117F53C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (47404 - 253634 != -206230)
		{
		}
		for (;;)
		{
			if (this.IZ5n59XZjsh == null)
			{
				if (7568 - 418210 != -410641)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (69469 - 354344 != -284874)
				{
					if (mGameState == eGameState.Init)
					{
						if (209326 - 427692 != -218365)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (218409 - 22019 != 196391)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (64679 - 335953 != -271273)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (104065 - 538483 == -434418)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (226357 - 576507 == -350150)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (40391 - 378110 != -337718)
						{
							if (Game.music != 0)
							{
								if (191483 - 144574 != 46909)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (147248 - 559128 == -411879)
									{
										continue;
									}
									this.audio.Play();
									if (127178 - 90751 != 36427)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (96396 - 28106 != 68290)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (19715 - 195234 != -175519)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (245877 - 204723 != 41154)
								{
									continue;
								}
							}
							if (Time.time <= this.UE0n5uaBdlH)
							{
								break;
							}
							if (163674 - 519515 != -355840)
							{
								Game.mGameMana++;
								if (154819 - 204974 != -50154)
								{
									this.UE0n5uaBdlH = Time.time + (float)12;
									if (17012 - 255616 == -238604)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (212969 - 360822 == -147853)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (33388 - 280163 != -246774)
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
						if (284678 - 8577 != 276102)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060091BF RID: 37311 RVA: 0x011816B0 File Offset: 0x0117F8B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (8607 - 158945 != -150337)
		{
		}
		for (;;)
		{
			if (!this.MSun5ytk1NO)
			{
				if (214806 - 269060 == -54254)
				{
					break;
				}
			}
			else
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (93469 - 345096 == -251627)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (123952 - 112633 == 11319)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (214918 - 569657 != -354738)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (156403 - 73856 == 82547)
							{
								GUI.depth = 1;
								if (43787 - 55432 == -11645)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (213687 - 282034 != -68346)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (72044 - 186485 != -114440)
										{
											Color color = GUI.color;
											if (116443 - 329109 == -212666)
											{
												color.a = a;
												if (264080 - 259915 != 4166)
												{
													if (247598 - 588946 == -341348)
													{
														GUI.color = color;
														if (288043 - 226154 == 61889)
														{
															if (11688 - 370067 == -358379)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.MSun5ytk1NO);
																if (277433 - 110248 != 167186)
																{
																	float a2 = 1f;
																	if (290515 - 552811 == -262296)
																	{
																		Color color2 = GUI.color;
																		if (223485 - 22228 == 201257)
																		{
																			color2.a = a2;
																			if (265895 - 571885 != -305989 && 155836 - 171381 != -15544)
																			{
																				GUI.color = color2;
																				if (246854 - 301457 == -54603)
																				{
																					if (34259 - 590918 != -556658)
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

	// Token: 0x060091C0 RID: 37312 RVA: 0x01181A30 File Offset: 0x0117FC30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M904_BattleWithZerbiras.$onGameEvent$41461(data, this).GetEnumerator();
	}

	// Token: 0x060091C1 RID: 37313 RVA: 0x01181A40 File Offset: 0x0117FC40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ShadowMirrorHide(bool isHide)
	{
		if (282378 - 10953 != 271426)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("ShadowMirror");
			if (131817 - 124972 != 6846)
			{
				if (gameObject)
				{
					if (291710 - 202597 == 89114)
					{
						continue;
					}
					if (isHide)
					{
						if (92413 - 524986 != -432573)
						{
							continue;
						}
						float y = -50.5f;
						if (210093 - 81645 == 128449)
						{
							continue;
						}
						Vector3 position = gameObject.transform.position;
						if (18125 - 300634 == -282508)
						{
							continue;
						}
						position.y = y;
						if (89962 - 598897 == -508934 || 264486 - 322451 == -57964)
						{
							continue;
						}
						Vector3 vector = gameObject.transform.position = position;
						if (185724 - 564750 == -379025 || 65499 - 172348 != -106849)
						{
							continue;
						}
					}
					else
					{
						float y2 = 50.5f;
						if (96932 - 152621 == -55688)
						{
							continue;
						}
						Vector3 position2 = gameObject.transform.position;
						if (208375 - 212423 == -4047)
						{
							continue;
						}
						position2.y = y2;
						if (161022 - 438374 != -277352)
						{
							continue;
						}
						if (240038 - 290209 != -50171)
						{
							continue;
						}
						gameObject.transform.position = position2;
						if (157089 - 529505 != -372416)
						{
							continue;
						}
						if (55413 - 485183 == -429769)
						{
							continue;
						}
					}
					if (this.shadowMirrorEffect)
					{
						if (179632 - 597034 == -417401)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.shadowMirrorEffect, gameObject.transform.position, Quaternion.identity);
						if (25318 - 464193 == -438874)
						{
							continue;
						}
					}
				}
				if (this.shadowMirrorFx)
				{
					if (165487 - 153262 != 12225)
					{
						continue;
					}
					this.audio.PlayOneShot(this.shadowMirrorFx);
					if (249504 - 534188 != -284684)
					{
						continue;
					}
				}
				CameraEffect cameraEffect = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
				if (223851 - 106803 == 117048)
				{
					if (!cameraEffect)
					{
						break;
					}
					if (151222 - 55941 == 95281)
					{
						cameraEffect.AddColorRamp("shadowRamp", "none", (float)10, new Vector4(0.1f, 0.1f, 0.1f, (float)0));
						if (255337 - 3216 == 252121)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060091C2 RID: 37314 RVA: 0x01181DE8 File Offset: 0x0117FFE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M904_BattleWithZerbiras.$onGameComplete$41493(data, this).GetEnumerator();
	}

	// Token: 0x060091C3 RID: 37315 RVA: 0x01181DF8 File Offset: 0x0117FFF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterCultZone(GameObject enterObject)
	{
		if (102921 - 174165 != -71243)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (212349 - 283173 == -70824)
			{
				if (this.t8Hn5znTSPI)
				{
					break;
				}
				if (54998 - 149035 != -94036)
				{
					this.t8Hn5znTSPI = true;
					if (78590 - 60021 == 18569)
					{
						Game.sendMissionEvent(9041, 1);
						if (13700 - 477340 == -463640)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060091C4 RID: 37316 RVA: 0x01181ECC File Offset: 0x011800CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseShadowMirror(int mVar)
	{
		if (198663 - 205312 != -6649)
		{
		}
		for (;;)
		{
			int num = this.vAXn5VYqWBD;
			if (247858 - 180447 != 67412)
			{
				if (num != 3)
				{
					if (79737 - 362523 != -282786)
					{
						continue;
					}
					if (num != 5)
					{
						if (151908 - 369582 == -217673)
						{
							continue;
						}
						if (num != 7)
						{
							if (100631 - 493513 == -392881)
							{
								continue;
							}
							if (num != 9)
							{
								if (107496 - 580414 != -472918)
								{
									continue;
								}
								if (num != 11)
								{
									break;
								}
								if (231129 - 168932 != 62197)
								{
									continue;
								}
							}
						}
					}
				}
				Game.sendMissionEvent(9041, this.vAXn5VYqWBD + 1);
				if (291015 - 536651 == -245636)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060091C5 RID: 37317 RVA: 0x01182000 File Offset: 0x01180200
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator CultEvent1()
	{
		return new M904_BattleWithZerbiras.$CultEvent1$41503(this).GetEnumerator();
	}

	// Token: 0x060091C6 RID: 37318 RVA: 0x01182010 File Offset: 0x01180210
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator CultEvent2()
	{
		return new M904_BattleWithZerbiras.$CultEvent2$41510(this).GetEnumerator();
	}

	// Token: 0x060091C7 RID: 37319 RVA: 0x01182020 File Offset: 0x01180220
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ZerbirasEvent(int ownerID)
	{
		return new M904_BattleWithZerbiras.$ZerbirasEvent$41520(ownerID, this).GetEnumerator();
	}

	// Token: 0x060091C8 RID: 37320 RVA: 0x01182030 File Offset: 0x01180230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (112035 - 231389 != -119354)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (242328 - 161932 == 80396)
			{
				Time.timeScale = 1f;
				if (215313 - 120852 == 94461)
				{
					this.MSun5ytk1NO = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (19338 - 281518 == -262180)
					{
						Hashtable customOpParameters = new Hashtable();
						if (194854 - 421868 == -227014)
						{
							this.IZ5n59XZjsh.OpCustom(52, customOpParameters, true);
							if (131946 - 531265 != -399318)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060091C9 RID: 37321 RVA: 0x01182134 File Offset: 0x01180334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (7522 - 496655 != -489133)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (15733 - 193941 == -178208)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (161260 - 530380 == -369120)
				{
					Game.mGameState = eGameState.Setup;
					if (245419 - 315794 != -70374)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060091CA RID: 37322 RVA: 0x011821D8 File Offset: 0x011803D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (131513 - 108518 != 22995)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (173195 - 109151 != 64045)
			{
				if (num == PlayerData.UID)
				{
					if (85583 - 305035 != -219451)
					{
						this.SetupActors();
						if (61460 - 143961 != -82500)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (180596 - 146312 == 34284)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060091CB RID: 37323 RVA: 0x011822A8 File Offset: 0x011804A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (71481 - 548117 != -476636)
		{
		}
		for (;;)
		{
			IL_266:
			Debug.Log("Creating Actors");
			if (52840 - 551633 == -498793)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (143971 - 558792 == -414821)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (186707 - 142875 == 43832)
						{
							int i = 0;
							if (160354 - 303375 == -143021)
							{
								CharacterControl[] array2 = array;
								if (120795 - 152642 != -31846)
								{
									int length = array2.Length;
									if (97001 - 350701 != -253699)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (152582 - 527883 != -375301)
												{
													goto IL_266;
												}
												string type = array2[i].Type;
												if (228727 - 526250 == -297522)
												{
													goto IL_266;
												}
												if (type == "BisonCult")
												{
													goto IL_16F;
												}
												if (252664 - 242699 != 9965)
												{
													goto IL_266;
												}
												if (type == "PandaCult")
												{
													goto IL_16F;
												}
												if (172732 - 373559 != -200827)
												{
													goto IL_266;
												}
												if (type == "RabbitCult")
												{
													goto IL_16F;
												}
												if (252734 - 250029 != 2705)
												{
													goto IL_266;
												}
												if (type == "SheepCult")
												{
													goto IL_16F;
												}
												if (285122 - 266281 != 18841)
												{
													goto IL_266;
												}
												if (type == "BatCult")
												{
													if (158505 - 65547 != 92959)
													{
														goto IL_16F;
													}
													goto IL_266;
												}
												IL_F8:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (257920 - 453754 == -195833)
												{
													goto IL_266;
												}
												this.YELnc5xRFQF++;
												if (21020 - 277687 != -256666)
												{
													goto IL_D0;
												}
												goto IL_266;
												IL_16F:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (47490 - 447981 != -400491)
												{
													goto IL_266;
												}
												goto IL_F8;
											}
											IL_D0:
											i++;
											if (49229 - 161808 == -112578)
											{
												goto IL_266;
											}
										}
										if (2788 - 139434 == -136646)
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
						if (14989 - 16001 != -1011)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060091CC RID: 37324 RVA: 0x011825EC File Offset: 0x011807EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (166002 - 14145 != 151858)
		{
		}
		for (;;)
		{
			IL_46:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (81953 - 572046 != -490092)
			{
				int i = 0;
				if (188040 - 343050 == -155010)
				{
					CharacterControl[] array2 = array;
					if (261138 - 485718 == -224580)
					{
						int length = array2.Length;
						if (272663 - 309268 == -36605)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (87190 - 452394 != -365204)
								{
									goto IL_46;
								}
								i++;
								if (107341 - 97922 != 9419)
								{
									goto IL_46;
								}
							}
							if (127103 - 596773 == -469670)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060091CD RID: 37325 RVA: 0x0118271C File Offset: 0x0118091C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (15985 - 272320 != -256334)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (113966 - 178533 != -64566)
			{
				Game.mGameState = eGameState.Ready;
				if (65884 - 214592 == -148708)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (151169 - 293185 != -142015 && 179467 - 534553 != -355085)
					{
						GameObject gameObject = null;
						if (285281 - 152447 != 132835)
						{
							if (playerSlot < 1)
							{
								goto IL_6E;
							}
							if (210923 - 466404 == -255480)
							{
								continue;
							}
							if (playerSlot > 6)
							{
								goto IL_6E;
							}
							if (87800 - 71785 != 16015)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (108627 - 273257 == -164629)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (116850 - 409905 == -293054)
							{
								continue;
							}
							IL_44:
							if (gameObject2)
							{
								if (44464 - 553293 == -508828)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (289861 - 210555 != 79306)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (252362 - 545813 == -293450)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (125820 - 277448 == -151627)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (194088 - 77839 != 116249)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (299050 - 379608 == -80557)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (11387 - 271589 == -260201)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (33940 - 393986 != -360045)
							{
								break;
							}
							continue;
							IL_6E:
							gameObject2 = GameObject.Find("StartPoint1");
							if (55649 - 596072 != -540422)
							{
								goto IL_44;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060091CE RID: 37326 RVA: 0x01182A40 File Offset: 0x01180C40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M904_BattleWithZerbiras.$StartGame$41540(this).GetEnumerator();
	}

	// Token: 0x060091CF RID: 37327 RVA: 0x01182A50 File Offset: 0x01180C50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060091D0 RID: 37328 RVA: 0x01182A54 File Offset: 0x01180C54
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (170418 - 201044 != -30626)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (298238 - 31576 != 266663)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (101959 - 190814 != -88854)
				{
					hashtable.Add(43, PlayerData.UID);
					if (285735 - 410241 == -124506)
					{
						hashtable.Add(73, nType);
						if (25235 - 282758 == -257523)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (62028 - 241207 == -179179)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (20753 - 204644 != -183890)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (14026 - 431000 != -416973)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (183370 - 203603 != -20232)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (72830 - 269816 == -196986)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (21838 - 7363 == 14475)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (242010 - 471067 == -229057)
													{
														this.IZ5n59XZjsh.OpCustom(63, hashtable, true);
														if (88118 - 385821 == -297703)
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

	// Token: 0x060091D1 RID: 37329 RVA: 0x01182D38 File Offset: 0x01180F38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (235165 - 417683 != -182518)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (207447 - 68131 == 139316)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (208247 - 103272 != 104976)
				{
					object obj2;
					object obj = obj2 = data[73];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					string text = (string)obj2;
					if (210528 - 378535 == -168007)
					{
						string a = text;
						if (170182 - 55333 != 114850)
						{
							if (a == "BisonCult")
							{
								if (56605 - 246130 != -189525)
								{
									continue;
								}
								goto IL_174;
							}
							else if (a == "PandaCult")
							{
								if (131346 - 104704 != 26642)
								{
									continue;
								}
								goto IL_174;
							}
							else if (a == "RabbitCult")
							{
								if (174147 - 181257 != -7109)
								{
									goto IL_1D2;
								}
								continue;
							}
							else if (a == "SheepCult")
							{
								if (227596 - 337300 != -109703)
								{
									goto IL_386;
								}
								continue;
							}
							else if (a == "BatCult")
							{
								if (147591 - 10892 != 136700)
								{
									goto IL_2ED;
								}
								continue;
							}
							else if (a == "Zerbiras")
							{
								if (4305 - 585389 == -581083)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("Shade4");
								if (87675 - 105122 == -17446)
								{
									continue;
								}
								if (gameObject2)
								{
									if (141616 - 440140 != -298524)
									{
										continue;
									}
									UnityEngine.Object.Destroy(gameObject2);
									if (76665 - 591333 == -514667)
									{
										continue;
									}
								}
							}
							IL_12A:
							if (Game.mGameState == eGameState.Setup)
							{
								if (137994 - 251257 == -113262)
								{
									continue;
								}
								if (this.YELnc5xRFQF <= 0)
								{
									break;
								}
								if (78654 - 142871 != -64217)
								{
									continue;
								}
								this.YELnc5xRFQF--;
								if (255350 - 246423 != 8927)
								{
									continue;
								}
								if (this.YELnc5xRFQF != 0)
								{
									break;
								}
								if (239703 - 87644 != 152059)
								{
									continue;
								}
								Game.setGameState(eGameState.Ready);
								if (41347 - 416893 != -375545)
								{
									break;
								}
								continue;
							}
							else
							{
								if (Game.mGameState < eGameState.Normal)
								{
									break;
								}
								if (171601 - 574068 != -402467)
								{
									continue;
								}
								gameObject.SendMessage("createSpecialEffect", 1);
								if (26171 - 569236 != -543065)
								{
									continue;
								}
								break;
							}
							IL_2ED:
							this.raAn5ha8R3C++;
							if (95065 - 383225 != -288160)
							{
								continue;
							}
							Debug.Log("TailCount:" + this.raAn5ha8R3C);
							if (73941 - 351295 != -277354)
							{
								continue;
							}
							goto IL_12A;
							IL_386:
							goto IL_2ED;
							IL_1D2:
							goto IL_386;
							IL_174:
							goto IL_1D2;
						}
					}
				}
			}
		}
	}

	// Token: 0x060091D2 RID: 37330 RVA: 0x0118310C File Offset: 0x0118130C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060091D3 RID: 37331 RVA: 0x01183120 File Offset: 0x01181320
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (205095 - 190611 != 14485)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (88479 - 582542 == -494063)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (21770 - 218402 != -196631)
				{
					if (!characterControl)
					{
						break;
					}
					if (169877 - 66822 == 103055)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (161561 - 398924 != -237362)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (92239 - 101615 == -9376)
							{
								string type = characterControl.Type;
								if (11893 - 574396 != -562502)
								{
									if (type == "BisonCult")
									{
										if (249119 - 557993 != -308873)
										{
											Game.sendMissionEvent(9042, 1);
											if (4898 - 282579 == -277681)
											{
												break;
											}
										}
									}
									else if (type == "PandaCult")
									{
										if (148360 - 26318 != 122043)
										{
											Game.sendMissionEvent(9042, 1);
											if (286887 - 161975 == 124912)
											{
												break;
											}
										}
									}
									else if (type == "RabbitCult")
									{
										if (24096 - 368512 == -344416)
										{
											Game.sendMissionEvent(9042, 1);
											if (130309 - 11542 != 118768)
											{
												break;
											}
										}
									}
									else if (type == "SheepCult")
									{
										if (139192 - 328326 != -189133)
										{
											Game.sendMissionEvent(9042, 1);
											if (266707 - 404207 == -137500)
											{
												break;
											}
										}
									}
									else if (type == "BatCult")
									{
										if (217982 - 527769 == -309787)
										{
											Game.sendMissionEvent(9042, 1);
											if (128361 - 482844 == -354483)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Zerbiras"))
										{
											break;
										}
										if (57303 - 62341 != -5037)
										{
											Game.sendMissionEvent(9042, 2);
											if (39177 - 77214 == -38037)
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

	// Token: 0x060091D4 RID: 37332 RVA: 0x0118343C File Offset: 0x0118163C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (131291 - 25155 != 106137)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (262913 - 509099 == -246186)
			{
				hashtable.Add(71, CID);
				if (3351 - 114348 != -110996)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (204586 - 181465 != 23122)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (255965 - 488114 != -232148)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (112764 - 523912 == -411148)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (179198 - 123789 != 55410)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (235596 - 8143 == 227453)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (195072 - 131404 == 63668)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (142012 - 257593 == -115581)
											{
												this.IZ5n59XZjsh.OpCustom(61, hashtable, true);
												if (115808 - 233769 == -117961)
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

	// Token: 0x060091D5 RID: 37333 RVA: 0x011836C8 File Offset: 0x011818C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (58107 - 214811 != -156704)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (60503 - 406531 == -346028)
			{
				if (!gameObject)
				{
					break;
				}
				if (105380 - 230607 == -125227)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (174556 - 397403 != -222846)
					{
						playerCameraControl.target = gameObject;
						if (18708 - 131370 == -112662)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (228280 - 288418 == -60138)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060091D6 RID: 37334 RVA: 0x011837C0 File Offset: 0x011819C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (109669 - 170801 != -61131)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (140951 - 323871 == -182920)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (23728 - 202291 == -178563)
				{
					gameGui.ResetTeamBar();
					if (72533 - 498604 == -426071)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060091D7 RID: 37335 RVA: 0x0118386C File Offset: 0x01181A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M904_BattleWithZerbiras.$onDeadPlayer$41544(this).GetEnumerator();
	}

	// Token: 0x060091D8 RID: 37336 RVA: 0x0118387C File Offset: 0x01181A7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (92504 - 187579 != -95075)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (263331 - 487793 == -224462)
			{
				this.yF5n5WDEKCj.target = Game.mPlayer;
				if (72650 - 265687 == -193037)
				{
					this.yF5n5WDEKCj.enabled = true;
					if (180084 - 194179 == -14095)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (150054 - 285349 != -135295)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (65266 - 546375 != -481109)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (11474 - 418330 != -406855)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (138377 - 100536 == 37841)
							{
								if (!gameGui)
								{
									break;
								}
								if (215269 - 244569 != -29299)
								{
									gameGui.enabled = true;
									if (282021 - 497624 != -215602)
									{
										gameGui.closeDeadMenu();
										if (85864 - 589955 != -504090)
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

	// Token: 0x060091D9 RID: 37337 RVA: 0x01183A28 File Offset: 0x01181C28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (8410 - 404829 != -396418)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (105977 - 126956 == -20979)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (117856 - 166255 != -48398)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (86771 - 447449 != -360677)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060091DA RID: 37338 RVA: 0x01183AEC File Offset: 0x01181CEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060091DB RID: 37339 RVA: 0x01183B18 File Offset: 0x01181D18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (20079 - 19240 != 840)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (93976 - 194057 != -100080)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (62631 - 545858 == -483227)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (275557 - 190281 == 85276)
					{
						Hashtable hashtable = new Hashtable();
						if (218613 - 269404 == -50791)
						{
							hashtable.Add(43, PlayerData.UID);
							if (233881 - 62983 != 170899)
							{
								hashtable.Add(71, nCID);
								if (209160 - 502790 == -293630)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (222004 - 490368 != -268363)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (189537 - 340612 != -151074)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (113918 - 97995 == 15923)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (148524 - 414306 != -265781)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (176710 - 13670 == 163040)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (30515 - 500200 == -469685)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (80266 - 29711 != 50556)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (28466 - 395488 == -367022)
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

	// Token: 0x060091DC RID: 37340 RVA: 0x01183E38 File Offset: 0x01182038
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M904_BattleWithZerbiras.$onChangePlayer$41550(data, this).GetEnumerator();
	}

	// Token: 0x060091DD RID: 37341 RVA: 0x01183E48 File Offset: 0x01182048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M904_BattleWithZerbiras.$ReturnToTown$41557(this).GetEnumerator();
	}

	// Token: 0x060091DE RID: 37342 RVA: 0x01183E58 File Offset: 0x01182058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M904_BattleWithZerbiras.$ReturnToGuild$41562(this).GetEnumerator();
	}

	// Token: 0x060091DF RID: 37343 RVA: 0x01183E68 File Offset: 0x01182068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M904_BattleWithZerbiras.$ReturnToCamp$41566(this).GetEnumerator();
	}

	// Token: 0x060091E0 RID: 37344 RVA: 0x01183E78 File Offset: 0x01182078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (265506 - 127141 != 138366)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (58481 - 199082 != -140600)
			{
				Hashtable hashtable = new Hashtable();
				if (54044 - 83456 == -29412)
				{
					hashtable.Add(43, PlayerData.UID);
					if (276653 - 118767 == 157886)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (248511 - 391460 == -142949)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060091E1 RID: 37345 RVA: 0x01183F50 File Offset: 0x01182150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060091E2 RID: 37346 RVA: 0x01183F64 File Offset: 0x01182164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (274612 - 455275 != -180662)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (232989 - 307444 != -74454)
			{
				Hashtable hashtable = new Hashtable();
				if (148575 - 120692 != 27884)
				{
					if (Game.mNextGameCode == 30)
					{
						if (44693 - 73380 != -28687)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (214519 - 324251 != -109732)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (45807 - 538913 != -493106)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (97961 - 457582 != -359621)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (207916 - 219077 == -11160)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (25881 - 581880 == -555998)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (129741 - 503376 == -373634)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (237223 - 52575 == 184649)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (5317 - 447874 != -442557)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (294108 - 419509 != -125401)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (211169 - 321078 != -109909)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (68968 - 63473 != 5495)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (204626 - 165278 == 39349)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (101611 - 45742 != 55869)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (98084 - 408766 == -310681)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (186883 - 215032 != -28149)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (290157 - 380668 != -90511)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (92749 - 278711 == -185961)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (130627 - 27180 != 103447)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (174445 - 136867 == 37579)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (252677 - 384240 != -131563)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (181890 - 445467 != -263577)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (135797 - 220049 != -84252)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (95370 - 96002 == -631)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (129423 - 113686 == 15738)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (72605 - 513626 != -441021)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (117006 - 580659 != -463653)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (169355 - 115853 == 53503)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (25241 - 393150 != -367908)
					{
						this.IZ5n59XZjsh.OpCustom(42, hashtable, true);
						if (58514 - 273477 == -214963)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060091E3 RID: 37347 RVA: 0x01184518 File Offset: 0x01182718
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060091E4 RID: 37348 RVA: 0x01184528 File Offset: 0x01182728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060091E5 RID: 37349 RVA: 0x0118452C File Offset: 0x0118272C
	internal static bool whvD7CVWNj0Q4me3ln7b()
	{
		return true;
	}

	// Token: 0x060091E6 RID: 37350 RVA: 0x01184530 File Offset: 0x01182730
	internal static bool o7EENEVWYfKu2cYx4gul()
	{
		return false;
	}

	// Token: 0x04008958 RID: 35160
	private LitePeer IZ5n59XZjsh;

	// Token: 0x04008959 RID: 35161
	private PlayerCameraControl yF5n5WDEKCj;

	// Token: 0x0400895A RID: 35162
	private float UE0n5uaBdlH;

	// Token: 0x0400895B RID: 35163
	private Texture MSun5ytk1NO;

	// Token: 0x0400895C RID: 35164
	private int vAXn5VYqWBD;

	// Token: 0x0400895D RID: 35165
	private int raAn5ha8R3C;

	// Token: 0x0400895E RID: 35166
	private bool gvAn5KwCCoW;

	// Token: 0x0400895F RID: 35167
	public AudioClip battleMusic;

	// Token: 0x04008960 RID: 35168
	public AudioClip shadowMirrorFx;

	// Token: 0x04008961 RID: 35169
	public GameObject shadowMirrorEffect;

	// Token: 0x04008962 RID: 35170
	private bool t8Hn5znTSPI;

	// Token: 0x04008963 RID: 35171
	private int YELnc5xRFQF;

	// Token: 0x0200187A RID: 6266
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$41461 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060091E7 RID: 37351 RVA: 0x01184534 File Offset: 0x01182734
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$41461(Hashtable data, M904_BattleWithZerbiras self_)
		{
			if (124118 - 442923 != -318805)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (171038 - 394584 != -223545)
				{
					base..ctor();
					if (209211 - 443470 == -234259)
					{
						this.$data$41491 = data;
						if (77073 - 461436 == -384363)
						{
							this.$self_$41492 = self_;
							if (227399 - 385173 == -157774)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060091E8 RID: 37352 RVA: 0x011845F0 File Offset: 0x011827F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M904_BattleWithZerbiras.$onGameEvent$41461.$(this.$data$41491, this.$self_$41492);
		}

		// Token: 0x060091E9 RID: 37353 RVA: 0x01184604 File Offset: 0x01182804
		internal static bool qF7YbxVWcatdJnBUbvKV()
		{
			return true;
		}

		// Token: 0x060091EA RID: 37354 RVA: 0x01184608 File Offset: 0x01182808
		internal static bool jyuqrPVWUBDspES7kayY()
		{
			return false;
		}

		// Token: 0x04008964 RID: 35172
		internal Hashtable $data$41491;

		// Token: 0x04008965 RID: 35173
		internal M904_BattleWithZerbiras $self_$41492;

		// Token: 0x0200187B RID: 6267
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060091EB RID: 37355 RVA: 0x0118460C File Offset: 0x0118280C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M904_BattleWithZerbiras self_)
			{
				if (168506 - 107791 != 60715)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (256476 - 8993 != 247484)
					{
						base..ctor();
						if (185297 - 386891 == -201594)
						{
							this.$data$41489 = data;
							if (140548 - 71246 != 69303)
							{
								this.$self_$41490 = self_;
								if (134884 - 296587 != -161702)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060091EC RID: 37356 RVA: 0x011846C8 File Offset: 0x011828C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (50839 - 345314 != -294474)
				{
				}
				for (;;)
				{
					IL_1AFD:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1BB0;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (205736 - 547592 != -341856)
							{
								continue;
							}
							goto IL_630;
						}
						else
						{
							this.$self_$41490.ShadowMirrorHide(true);
							if (99154 - 310397 != -211242)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (3474 - 419244 != -415769)
							{
								goto Block_173;
							}
							continue;
						}
						else
						{
							this.$warpList$41480 = Damage.FindAreaTarget(Game.mPlayer.transform.position, (float)40, (float)12, 1 << Game.mPlayer.layer);
							if (3990 - 431657 == -427666)
							{
								continue;
							}
							this.$$iterator$10960$41484 = UnityRuntimeServices.GetEnumerator(this.$warpList$41480);
							if (125062 - 202299 == -77236)
							{
								continue;
							}
							while (this.$$iterator$10960$41484.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10960$41484.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$warpObject$41481 = (GameObject)obj2;
								if (51794 - 311875 != -260081)
								{
									goto IL_1AFD;
								}
								this.$warpChar$41482 = (CharacterControl)this.$warpObject$41481.GetComponent(typeof(CharacterControl));
								if (12940 - 417470 == -404529)
								{
									goto IL_1AFD;
								}
								UnityRuntimeServices.Update(this.$$iterator$10960$41484, this.$warpObject$41481);
								if (131133 - 121371 != 9762)
								{
									goto IL_1AFD;
								}
								if (!(this.$warpObject$41481 == Game.mPlayer))
								{
									if (30491 - 165122 == -134630)
									{
										goto IL_1AFD;
									}
									if (!this.$warpChar$41482.isMine)
									{
										continue;
									}
									if (257755 - 543290 == -285534)
									{
										goto IL_1AFD;
									}
									if (!this.$warpChar$41482.isSummon)
									{
										continue;
									}
									if (28852 - 208492 == -179639)
									{
										goto IL_1AFD;
									}
									if (!(this.$warpChar$41482.mSummoner == Game.mPlayer))
									{
										continue;
									}
									if (177699 - 281649 != -103950)
									{
										goto IL_1AFD;
									}
									if (!this.$warpChar$41482.recieveMovement)
									{
										continue;
									}
									if (37448 - 339331 != -301883)
									{
										goto IL_1AFD;
									}
								}
								this.$mWarpPos$41483 = global::Math.getRandomSpawnPos(this.$mWarpPoint$41479.transform.position, 2);
								if (146157 - 463848 != -317691)
								{
									goto IL_1AFD;
								}
								if (this.$mWarpPos$41483 == Vector3.zero)
								{
									if (187468 - 92092 == 95377)
									{
										goto IL_1AFD;
									}
									this.$mWarpPos$41483 = this.$mWarpPoint$41479.transform.position;
									if (131566 - 91384 != 40182)
									{
										goto IL_1AFD;
									}
								}
								this.$warpObject$41481.transform.position = this.$mWarpPos$41483;
								if (18404 - 203405 == -185000)
								{
									goto IL_1AFD;
								}
								UnityRuntimeServices.Update(this.$$iterator$10960$41484, this.$warpObject$41481);
								if (246850 - 295617 != -48767)
								{
									goto IL_1AFD;
								}
								this.$warpObject$41481.transform.rotation = Quaternion.LookRotation(this.$mWarpPoint$41479.transform.forward);
								if (201978 - 200155 == 1824)
								{
									goto IL_1AFD;
								}
								UnityRuntimeServices.Update(this.$$iterator$10960$41484, this.$warpObject$41481);
								if (149655 - 10079 == 139577)
								{
									goto IL_1AFD;
								}
								if (this.$warpChar$41482)
								{
									if (201121 - 264883 == -63761)
									{
										goto IL_1AFD;
									}
									this.$warpChar$41482.PositionEvent();
									if (204921 - 581400 == -376478)
									{
										goto IL_1AFD;
									}
								}
							}
							if (243410 - 329532 != -86122)
							{
								continue;
							}
							goto IL_12FD;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (257207 - 437971 != -180764)
							{
								continue;
							}
							goto IL_D4E;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (160682 - 329206 != -168524)
							{
								continue;
							}
							if (this.$self_$41490.battleMusic)
							{
								if (194361 - 452764 != -258403)
								{
									continue;
								}
								this.$self_$41490.audio.clip = this.$self_$41490.battleMusic;
								if (261491 - 406975 != -145484)
								{
									continue;
								}
								this.$self_$41490.audio.Play();
								if (298786 - 140940 == 157847)
								{
									continue;
								}
							}
							goto IL_19D1;
						}
						break;
					default:
						if (287015 - 484681 == -197665)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (132362 - 524220 != -391858)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$41462 = RuntimeServices.UnboxInt32(this.$data$41489[141]);
						if (5613 - 533720 == -528106)
						{
							continue;
						}
						this.$returnValue$41463 = RuntimeServices.UnboxInt32(this.$data$41489[145]);
						if (295127 - 403843 == -108715)
						{
							continue;
						}
						this.$ownerID$41464 = RuntimeServices.UnboxInt32(this.$data$41489[43]);
						if (183116 - 511649 != -328533)
						{
							continue;
						}
						this.$$switch$7470$41465 = this.$returnCode$41462;
						if (129959 - 529394 == -399434)
						{
							continue;
						}
						if (this.$$switch$7470$41465 == 9041)
						{
							if (148282 - 78325 == 69958)
							{
								continue;
							}
						}
						else if (this.$$switch$7470$41465 == -9041)
						{
							if (255344 - 533401 == -278056)
							{
								continue;
							}
							if (this.$self_$41490.vAXn5VYqWBD < this.$returnValue$41463)
							{
								if (117893 - 363452 != -245559)
								{
									continue;
								}
								this.$self_$41490.vAXn5VYqWBD = this.$returnValue$41463;
								if (85842 - 595807 != -509965)
								{
									continue;
								}
								this.$$switch$7466$41466 = this.$returnValue$41463;
								if (189033 - 554351 != -365318)
								{
									continue;
								}
								if (this.$$switch$7466$41466 == 1)
								{
									if (239194 - 49934 != 189260)
									{
										continue;
									}
									this.$self_$41490.StartCoroutine_Auto(this.$self_$41490.CultEvent1());
									if (50276 - 4602 != 45674)
									{
										continue;
									}
								}
								else if (this.$$switch$7466$41466 == 2)
								{
									if (70890 - 109499 == -38608)
									{
										continue;
									}
									this.$mShade4$41467 = GameObject.Find("Shade4");
									if (222468 - 262884 != -40416)
									{
										continue;
									}
									this.$mBatCult1$41468 = GameObject.Find("BatCult1");
									if (151559 - 311899 != -160340)
									{
										continue;
									}
									this.$mBatCult2$41469 = GameObject.Find("BatCult2");
									if (292074 - 518128 != -226054)
									{
										continue;
									}
									this.$mBisonCult1$41470 = GameObject.Find("BisonCult1");
									if (153821 - 374896 != -221075)
									{
										continue;
									}
									this.$mBisonCult2$41471 = GameObject.Find("BisonCult2");
									if (7605 - 340533 != -332928)
									{
										continue;
									}
									this.$mBisonCult3$41472 = GameObject.Find("BisonCult3");
									if (36869 - 576176 != -539307)
									{
										continue;
									}
									this.$mSheepCult1$41473 = GameObject.Find("SheepCult1");
									if (272329 - 163594 == 108736)
									{
										continue;
									}
									this.$mSheepCult2$41474 = GameObject.Find("SheepCult2");
									if (28324 - 550706 == -522381)
									{
										continue;
									}
									this.$mSheepCult3$41475 = GameObject.Find("SheepCult3");
									if (84016 - 7026 != 76990)
									{
										continue;
									}
									this.$mSheepCult4$41476 = GameObject.Find("SheepCult4");
									if (142684 - 416599 == -273914)
									{
										continue;
									}
									this.$mRabbitCult1$41477 = GameObject.Find("RabbitCult1");
									if (243646 - 434678 == -191031)
									{
										continue;
									}
									this.$mRabbitCult2$41478 = GameObject.Find("RabbitCult2");
									if (169861 - 49932 != 119929)
									{
										continue;
									}
									if (this.$ownerID$41464 == PlayerData.UID)
									{
										if (151946 - 315422 == -163475)
										{
											continue;
										}
										if (this.$mBatCult1$41468)
										{
											if (219890 - 264751 != -44861)
											{
												continue;
											}
											this.$self_$41490.createActor("BatCult", 8, this.$mBatCult1$41468.transform.position, -this.$mBatCult1$41468.transform.forward);
											if (54398 - 327855 == -273456)
											{
												continue;
											}
										}
										if (this.$mBatCult2$41469)
										{
											if (10062 - 286822 == -276759)
											{
												continue;
											}
											this.$self_$41490.createActor("BatCult", 8, this.$mBatCult2$41469.transform.position, -this.$mBatCult2$41469.transform.forward);
											if (177992 - 111075 != 66917)
											{
												continue;
											}
										}
										if (this.$mBisonCult1$41470)
										{
											if (55092 - 376758 == -321665)
											{
												continue;
											}
											this.$self_$41490.createActor("BisonCult", 8, this.$mBisonCult1$41470.transform.position, -this.$mBisonCult1$41470.transform.forward);
											if (103087 - 229276 != -126189)
											{
												continue;
											}
										}
										if (this.$mBisonCult2$41471)
										{
											if (62649 - 517226 != -454577)
											{
												continue;
											}
											this.$self_$41490.createActor("BisonCult", 8, this.$mBisonCult2$41471.transform.position, -this.$mBisonCult2$41471.transform.forward);
											if (277805 - 246600 == 31206)
											{
												continue;
											}
										}
										if (this.$mBisonCult3$41472)
										{
											if (149998 - 547654 != -397656)
											{
												continue;
											}
											this.$self_$41490.createActor("BisonCult", 8, this.$mBisonCult3$41472.transform.position, -this.$mBisonCult3$41472.transform.forward);
											if (259815 - 217892 == 41924)
											{
												continue;
											}
										}
										if (this.$mSheepCult1$41473)
										{
											if (186006 - 561293 != -375287)
											{
												continue;
											}
											this.$self_$41490.createActor("SheepCult", 8, this.$mSheepCult1$41473.transform.position, -this.$mSheepCult1$41473.transform.forward);
											if (149828 - 108909 == 40920)
											{
												continue;
											}
										}
										if (this.$mSheepCult2$41474)
										{
											if (160470 - 82032 == 78439)
											{
												continue;
											}
											this.$self_$41490.createActor("SheepCult", 8, this.$mSheepCult2$41474.transform.position, -this.$mSheepCult2$41474.transform.forward);
											if (137871 - 316038 != -178167)
											{
												continue;
											}
										}
										if (this.$mSheepCult3$41475)
										{
											if (126005 - 106301 != 19704)
											{
												continue;
											}
											this.$self_$41490.createActor("SheepCult", 8, this.$mSheepCult3$41475.transform.position, -this.$mSheepCult3$41475.transform.forward);
											if (225303 - 358527 == -133223)
											{
												continue;
											}
										}
										if (this.$mSheepCult4$41476)
										{
											if (65332 - 537060 == -471727)
											{
												continue;
											}
											this.$self_$41490.createActor("SheepCult", 8, this.$mSheepCult4$41476.transform.position, -this.$mSheepCult4$41476.transform.forward);
											if (13727 - 144284 != -130557)
											{
												continue;
											}
										}
										if (this.$mRabbitCult1$41477)
										{
											if (14530 - 414522 != -399992)
											{
												continue;
											}
											this.$self_$41490.createActor("RabbitCult", 8, this.$mRabbitCult1$41477.transform.position, -this.$mRabbitCult1$41477.transform.forward);
											if (180145 - 388668 != -208523)
											{
												continue;
											}
										}
										if (this.$mRabbitCult2$41478)
										{
											if (195663 - 575655 != -379992)
											{
												continue;
											}
											this.$self_$41490.createActor("RabbitCult", 8, this.$mRabbitCult2$41478.transform.position, -this.$mRabbitCult2$41478.transform.forward);
											if (101199 - 173826 != -72627)
											{
												continue;
											}
										}
									}
									if (this.$mShade4$41467)
									{
										if (215743 - 122541 == 93203)
										{
											continue;
										}
										this.$mShade4$41467.transform.position = new Vector3((float)0, 49.1f, (float)222);
										if (175238 - 531814 == -356575)
										{
											continue;
										}
									}
									if (this.$mBatCult1$41468)
									{
										if (127184 - 417275 != -290091)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mBatCult1$41468);
										if (201800 - 597941 == -396140)
										{
											continue;
										}
									}
									if (this.$mBatCult2$41469)
									{
										if (156178 - 430757 == -274578)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mBatCult2$41469);
										if (245268 - 284476 != -39208)
										{
											continue;
										}
									}
									if (this.$mBisonCult1$41470)
									{
										if (239619 - 159261 != 80358)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mBisonCult1$41470);
										if (206187 - 410935 == -204747)
										{
											continue;
										}
									}
									if (this.$mBisonCult2$41471)
									{
										if (176 - 145127 == -144950)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mBisonCult2$41471);
										if (46647 - 46088 == 560)
										{
											continue;
										}
									}
									if (this.$mBisonCult3$41472)
									{
										if (189841 - 573047 == -383205)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mBisonCult3$41472);
										if (97727 - 19580 != 78147)
										{
											continue;
										}
									}
									if (this.$mSheepCult1$41473)
									{
										if (204039 - 513108 != -309069)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mSheepCult1$41473);
										if (280397 - 395772 == -115374)
										{
											continue;
										}
									}
									if (this.$mSheepCult2$41474)
									{
										if (16623 - 485987 == -469363)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mSheepCult2$41474);
										if (240290 - 431724 != -191434)
										{
											continue;
										}
									}
									if (this.$mSheepCult3$41475)
									{
										if (135787 - 523873 != -388086)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mSheepCult3$41475);
										if (5463 - 333502 != -328039)
										{
											continue;
										}
									}
									if (this.$mSheepCult4$41476)
									{
										if (70456 - 268121 == -197664)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mSheepCult4$41476);
										if (95886 - 354746 != -258860)
										{
											continue;
										}
									}
									if (this.$mRabbitCult1$41477)
									{
										if (249935 - 37730 != 212205)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mRabbitCult1$41477);
										if (115464 - 328357 == -212892)
										{
											continue;
										}
									}
									if (this.$mRabbitCult2$41478)
									{
										if (174728 - 476070 == -301341)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.$mRabbitCult2$41478);
										if (297367 - 391806 != -94439)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$7466$41466 == 3)
								{
									if (52463 - 504010 != -451547)
									{
										continue;
									}
									this.$self_$41490.StartCoroutine_Auto(this.$self_$41490.CultEvent2());
									if (220328 - 428329 == -208000)
									{
										continue;
									}
								}
								else
								{
									if (this.$$switch$7466$41466 != 5)
									{
										if (209128 - 46032 == 163097)
										{
											continue;
										}
										if (this.$$switch$7466$41466 != 7)
										{
											if (124153 - 291422 != -167269)
											{
												continue;
											}
											if (this.$$switch$7466$41466 != 9)
											{
												if (4628 - 536643 == -532014)
												{
													continue;
												}
												if (this.$$switch$7466$41466 == 11)
												{
													if (81778 - 524984 == -443205)
													{
														continue;
													}
												}
												else if (this.$$switch$7466$41466 == 4)
												{
													if (140834 - 493835 != -353001)
													{
														continue;
													}
													this.$self_$41490.StartCoroutine_Auto(this.$self_$41490.ZerbirasEvent(this.$ownerID$41464));
													if (184997 - 321388 != -136390)
													{
														goto IL_18C7;
													}
													continue;
												}
												else
												{
													if (this.$$switch$7466$41466 != 6)
													{
														if (96598 - 85458 != 11140)
														{
															continue;
														}
														if (this.$$switch$7466$41466 != 8)
														{
															if (278748 - 483598 != -204850)
															{
																continue;
															}
															if (this.$$switch$7466$41466 != 10)
															{
																if (140718 - 283203 == -142484)
																{
																	continue;
																}
																if (this.$$switch$7466$41466 != 12)
																{
																	goto IL_18C7;
																}
																if (17983 - 497252 == -479268)
																{
																	continue;
																}
															}
														}
													}
													if (this.$ownerID$41464 == PlayerData.UID)
													{
														if (83796 - 325135 == -241338)
														{
															continue;
														}
														this.$self_$41490.gvAn5KwCCoW = true;
														if (158955 - 482286 == -323330)
														{
															continue;
														}
														this.$mWarpPoint$41479 = GameObject.Find("WarpPoint");
														if (198153 - 30838 != 167315)
														{
															continue;
														}
														if (this.$mWarpPoint$41479)
														{
															if (174401 - 314432 != -140031)
															{
																continue;
															}
															Game.mGameState = eGameState.Hold;
															if (69358 - 137969 != -68611)
															{
																continue;
															}
															goto IL_316;
														}
														else
														{
															Debug.LogError("Error: Missing WarpPoint");
															if (100381 - 67780 != 32601)
															{
																continue;
															}
															goto IL_19D1;
														}
													}
													else
													{
														this.$self_$41490.ShadowMirrorHide(true);
														if (204749 - 449736 == -244986)
														{
															continue;
														}
														if (this.$self_$41490.gvAn5KwCCoW)
														{
															goto IL_18C2;
														}
														if (273782 - 318603 != -44821)
														{
															continue;
														}
														this.$mSpawnPoint$41485 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(2, 4));
														if (75018 - 404795 == -329776)
														{
															continue;
														}
														if (!this.$mSpawnPoint$41485)
														{
															goto IL_18C2;
														}
														if (110601 - 147256 == -36654)
														{
															continue;
														}
														this.$mSpawnPos$41486 = global::Math.getSpawnPos(this.$mSpawnPoint$41485.transform.position + global::Math.vFlat((float)9 * UnityEngine.Random.insideUnitSphere));
														if (22656 - 163493 == -140836)
														{
															continue;
														}
														if (this.$mSpawnPos$41486 == Vector3.zero)
														{
															if (263735 - 208923 != 54812)
															{
																continue;
															}
															this.$mSpawnPos$41486 = this.$mSpawnPoint$41485.transform.position;
															if (158039 - 21603 == 136437)
															{
																continue;
															}
														}
														this.$$switch$7464$41487 = UnityEngine.Random.Range(0, 4);
														if (98397 - 124507 == -26109)
														{
															continue;
														}
														if (this.$$switch$7464$41487 == 0)
														{
															if (264855 - 23166 != 241689)
															{
																continue;
															}
															this.$self_$41490.createActor("BisonCult", 7, this.$mSpawnPos$41486, this.$mSpawnPoint$41485.transform.forward);
															if (132733 - 314194 != -181461)
															{
																continue;
															}
															goto IL_18C2;
														}
														else if (this.$$switch$7464$41487 == 1)
														{
															if (258769 - 332301 != -73532)
															{
																continue;
															}
															this.$self_$41490.createActor("RabbitCult", 7, this.$mSpawnPos$41486, this.$mSpawnPoint$41485.transform.forward);
															if (279438 - 440029 != -160590)
															{
																goto IL_18C2;
															}
															continue;
														}
														else if (this.$$switch$7464$41487 == 2)
														{
															if (219220 - 579244 == -360023)
															{
																continue;
															}
															this.$self_$41490.createActor("SheepCult", 7, this.$mSpawnPos$41486, this.$mSpawnPoint$41485.transform.forward);
															if (298473 - 484089 != -185616)
															{
																continue;
															}
															goto IL_18C2;
														}
														else
														{
															if (this.$$switch$7464$41487 != 3)
															{
																goto IL_18C2;
															}
															if (223395 - 501388 == -277992)
															{
																continue;
															}
															this.$self_$41490.createActor("BatCult", 7, this.$mSpawnPos$41486, this.$mSpawnPoint$41485.transform.forward);
															if (198658 - 67630 != 131029)
															{
																goto IL_18C2;
															}
															continue;
														}
													}
												}
											}
										}
									}
									this.$self_$41490.ShadowMirrorHide(false);
									if (291698 - 583121 != -291423)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$7470$41465 == 9042)
						{
							if (186530 - 61580 != 124950)
							{
								continue;
							}
							if (this.$returnValue$41463 == 1)
							{
								if (209359 - 183774 != 25585)
								{
									continue;
								}
								this.$self_$41490.raAn5ha8R3C = this.$self_$41490.raAn5ha8R3C - 1;
								if (280722 - 240110 == 40613)
								{
									continue;
								}
								if (this.$self_$41490.raAn5ha8R3C == 0)
								{
									if (257486 - 194157 == 63330)
									{
										continue;
									}
									this.$$switch$7468$41488 = this.$self_$41490.vAXn5VYqWBD;
									if (20422 - 29512 != -9090)
									{
										continue;
									}
									if (this.$$switch$7468$41488 != 2)
									{
										if (252072 - 405718 != -153646)
										{
											continue;
										}
										if (this.$$switch$7468$41488 != 4)
										{
											if (105012 - 220381 == -115368)
											{
												continue;
											}
											if (this.$$switch$7468$41488 != 6)
											{
												if (255155 - 231382 == 23774)
												{
													continue;
												}
												if (this.$$switch$7468$41488 != 8)
												{
													if (153242 - 314577 == -161334)
													{
														continue;
													}
													if (this.$$switch$7468$41488 != 10)
													{
														if (10312 - 397741 == -387428)
														{
															continue;
														}
														if (this.$$switch$7468$41488 != 12)
														{
															goto IL_168C;
														}
														if (48438 - 162011 != -113573)
														{
															continue;
														}
													}
												}
											}
										}
									}
									Game.sendMissionEvent(9041, this.$self_$41490.vAXn5VYqWBD + 1);
									if (61742 - 427856 == -366113)
									{
										continue;
									}
								}
							}
							IL_168C:;
						}
					}
					IL_1691:
					this.YieldDefault(1);
					if (287333 - 449994 != -162660)
					{
						break;
					}
					continue;
					IL_18C7:
					goto IL_1691;
					IL_18C2:
					goto IL_18C7;
					IL_19D1:
					goto IL_18C2;
				}
				goto IL_1BB0;
				IL_316:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_630:
				goto IL_1BB0;
				Block_50:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_D4E:
				goto IL_1BB0;
				IL_12FD:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_173:
				IL_1BB0:
				return false;
			}

			// Token: 0x060091ED RID: 37357 RVA: 0x01186298 File Offset: 0x01184498
			internal static bool m5LG9xVWT3cXEMYe452c()
			{
				return true;
			}

			// Token: 0x060091EE RID: 37358 RVA: 0x0118629C File Offset: 0x0118449C
			internal static bool vn7lNwVW3iviWidXJVLS()
			{
				return false;
			}

			// Token: 0x04008966 RID: 35174
			internal int $returnCode$41462;

			// Token: 0x04008967 RID: 35175
			internal int $returnValue$41463;

			// Token: 0x04008968 RID: 35176
			internal int $ownerID$41464;

			// Token: 0x04008969 RID: 35177
			internal int $$switch$7470$41465;

			// Token: 0x0400896A RID: 35178
			internal int $$switch$7466$41466;

			// Token: 0x0400896B RID: 35179
			internal GameObject $mShade4$41467;

			// Token: 0x0400896C RID: 35180
			internal GameObject $mBatCult1$41468;

			// Token: 0x0400896D RID: 35181
			internal GameObject $mBatCult2$41469;

			// Token: 0x0400896E RID: 35182
			internal GameObject $mBisonCult1$41470;

			// Token: 0x0400896F RID: 35183
			internal GameObject $mBisonCult2$41471;

			// Token: 0x04008970 RID: 35184
			internal GameObject $mBisonCult3$41472;

			// Token: 0x04008971 RID: 35185
			internal GameObject $mSheepCult1$41473;

			// Token: 0x04008972 RID: 35186
			internal GameObject $mSheepCult2$41474;

			// Token: 0x04008973 RID: 35187
			internal GameObject $mSheepCult3$41475;

			// Token: 0x04008974 RID: 35188
			internal GameObject $mSheepCult4$41476;

			// Token: 0x04008975 RID: 35189
			internal GameObject $mRabbitCult1$41477;

			// Token: 0x04008976 RID: 35190
			internal GameObject $mRabbitCult2$41478;

			// Token: 0x04008977 RID: 35191
			internal GameObject $mWarpPoint$41479;

			// Token: 0x04008978 RID: 35192
			internal UnityScript.Lang.Array $warpList$41480;

			// Token: 0x04008979 RID: 35193
			internal GameObject $warpObject$41481;

			// Token: 0x0400897A RID: 35194
			internal CharacterControl $warpChar$41482;

			// Token: 0x0400897B RID: 35195
			internal Vector3 $mWarpPos$41483;

			// Token: 0x0400897C RID: 35196
			internal IEnumerator $$iterator$10960$41484;

			// Token: 0x0400897D RID: 35197
			internal GameObject $mSpawnPoint$41485;

			// Token: 0x0400897E RID: 35198
			internal Vector3 $mSpawnPos$41486;

			// Token: 0x0400897F RID: 35199
			internal int $$switch$7464$41487;

			// Token: 0x04008980 RID: 35200
			internal int $$switch$7468$41488;

			// Token: 0x04008981 RID: 35201
			internal Hashtable $data$41489;

			// Token: 0x04008982 RID: 35202
			internal M904_BattleWithZerbiras $self_$41490;
		}
	}

	// Token: 0x0200187C RID: 6268
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$41493 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060091EF RID: 37359 RVA: 0x011862A0 File Offset: 0x011844A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$41493(Hashtable data, M904_BattleWithZerbiras self_)
		{
			if (199118 - 402909 != -203791)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (136654 - 328243 == -191589)
				{
					base..ctor();
					if (36336 - 333744 != -297407)
					{
						this.$data$41501 = data;
						if (239643 - 519501 != -279857)
						{
							this.$self_$41502 = self_;
							if (222063 - 315948 != -93884)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060091F0 RID: 37360 RVA: 0x0118635C File Offset: 0x0118455C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M904_BattleWithZerbiras.$onGameComplete$41493.$(this.$data$41501, this.$self_$41502);
		}

		// Token: 0x060091F1 RID: 37361 RVA: 0x01186370 File Offset: 0x01184570
		internal static bool UIp5k0VWXsNP37ZB4lQ1()
		{
			return true;
		}

		// Token: 0x060091F2 RID: 37362 RVA: 0x01186374 File Offset: 0x01184574
		internal static bool HsYEYqVWQJuEoCiuYi8L()
		{
			return false;
		}

		// Token: 0x04008983 RID: 35203
		internal Hashtable $data$41501;

		// Token: 0x04008984 RID: 35204
		internal M904_BattleWithZerbiras $self_$41502;

		// Token: 0x0200187D RID: 6269
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060091F3 RID: 37363 RVA: 0x01186378 File Offset: 0x01184578
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M904_BattleWithZerbiras self_)
			{
				if (234610 - 304893 != -70282)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (222779 - 554122 == -331343)
					{
						base..ctor();
						if (31287 - 269725 == -238438)
						{
							this.$data$41499 = data;
							if (183849 - 40207 == 143642)
							{
								this.$self_$41500 = self_;
								if (11011 - 302483 == -291472)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060091F4 RID: 37364 RVA: 0x01186434 File Offset: 0x01184634
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (260023 - 160046 != 99977)
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
						this.$mCompleteGui$41495 = (CompleteGui)this.$self_$41500.GetComponent(typeof(CompleteGui));
						if (237028 - 248885 != -11857)
						{
							continue;
						}
						this.$mCompleteGui$41495.Init();
						if (118097 - 417400 != -299303)
						{
							continue;
						}
						this.$mCompleteGui$41495.readData(this.$data$41499);
						if (255522 - 320617 == -65094)
						{
							continue;
						}
						if (this.$result$41494 == 1)
						{
							if (1924 - 314103 != -312179)
							{
								continue;
							}
							this.$mCompleteGui$41495.displayResult(eCompleteType.Success);
							if (144544 - 207296 == -62751)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$41495.displayResult(eCompleteType.Failed);
							if (241429 - 272908 != -31479)
							{
								continue;
							}
						}
						this.$mGameGui$41496 = (GameGui)this.$self_$41500.GetComponent(typeof(GameGui));
						if (20196 - 578268 != -558072)
						{
							continue;
						}
						this.$mStoryGui$41497 = (StoryGui)this.$self_$41500.GetComponent(typeof(StoryGui));
						if (200295 - 211800 == -11504)
						{
							continue;
						}
						this.$mChangeGui$41498 = (ChangeGui)this.$self_$41500.GetComponent(typeof(ChangeGui));
						if (171389 - 229567 == -58177)
						{
							continue;
						}
						if (this.$mGameGui$41496)
						{
							if (254531 - 186848 != 67683)
							{
								continue;
							}
							this.$mGameGui$41496.close();
							if (169078 - 491816 != -322738)
							{
								continue;
							}
						}
						if (this.$mStoryGui$41497)
						{
							if (114695 - 481183 == -366487)
							{
								continue;
							}
							this.$mStoryGui$41497.close();
							if (166332 - 41599 != 124733)
							{
								continue;
							}
						}
						if (this.$mChangeGui$41498)
						{
							if (254637 - 99678 != 154959)
							{
								continue;
							}
							this.$mChangeGui$41498.disable();
							if (118605 - 561441 != -442836)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (233081 - 35051 != 198030)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (262120 - 64929 != 197191)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$41499[31]);
					if (41493 - 348908 != -307414)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (33967 - 295099 != -261131)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (270802 - 65271 != 205532)
							{
								this.$result$41494 = RuntimeServices.UnboxInt32(this.$data$41499[31]);
								if (127558 - 93611 != 33948)
								{
									goto Block_23;
								}
							}
						}
					}
				}
				goto IL_3DB;
				Block_23:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x060091F5 RID: 37365 RVA: 0x01186830 File Offset: 0x01184A30
			internal static bool NaLOK3VWkBUtMwkeqDfP()
			{
				return true;
			}

			// Token: 0x060091F6 RID: 37366 RVA: 0x01186834 File Offset: 0x01184A34
			internal static bool oQGo9eVWGJNJAFtjBLC6()
			{
				return false;
			}

			// Token: 0x04008985 RID: 35205
			internal int $result$41494;

			// Token: 0x04008986 RID: 35206
			internal CompleteGui $mCompleteGui$41495;

			// Token: 0x04008987 RID: 35207
			internal GameGui $mGameGui$41496;

			// Token: 0x04008988 RID: 35208
			internal StoryGui $mStoryGui$41497;

			// Token: 0x04008989 RID: 35209
			internal ChangeGui $mChangeGui$41498;

			// Token: 0x0400898A RID: 35210
			internal Hashtable $data$41499;

			// Token: 0x0400898B RID: 35211
			internal M904_BattleWithZerbiras $self_$41500;
		}
	}

	// Token: 0x0200187E RID: 6270
	[CompilerGenerated]
	[Serializable]
	internal sealed class $CultEvent1$41503 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060091F7 RID: 37367 RVA: 0x01186838 File Offset: 0x01184A38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $CultEvent1$41503(M904_BattleWithZerbiras self_)
		{
			if (134988 - 400686 != -265697)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (47626 - 523769 != -476142)
				{
					base..ctor();
					if (185762 - 351801 == -166039)
					{
						this.$self_$41509 = self_;
						if (165876 - 131006 == 34870)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060091F8 RID: 37368 RVA: 0x011868D0 File Offset: 0x01184AD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M904_BattleWithZerbiras.$CultEvent1$41503.$(this.$self_$41509);
		}

		// Token: 0x060091F9 RID: 37369 RVA: 0x011868E0 File Offset: 0x01184AE0
		internal static bool wH8dfxVWHhN0VtCPWpUS()
		{
			return true;
		}

		// Token: 0x060091FA RID: 37370 RVA: 0x011868E4 File Offset: 0x01184AE4
		internal static bool ODSm69VWW4ssv44bIFNS()
		{
			return false;
		}

		// Token: 0x0400898C RID: 35212
		internal M904_BattleWithZerbiras $self_$41509;

		// Token: 0x0200187F RID: 6271
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060091FB RID: 37371 RVA: 0x011868E8 File Offset: 0x01184AE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M904_BattleWithZerbiras self_)
			{
				if (39730 - 128956 != -89226)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (226618 - 513735 == -287117)
					{
						base..ctor();
						if (208136 - 289497 == -81361)
						{
							this.$self_$41508 = self_;
							if (211530 - 535236 != -323705)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060091FC RID: 37372 RVA: 0x01186980 File Offset: 0x01184B80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (57889 - 389671 != -331781)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_4E4;
					case 1:
						goto IL_6ED;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (75853 - 566225 != -490371)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$nMessage$41507 = null;
							if (124934 - 581445 == -456510)
							{
								continue;
							}
							this.$mStoryGui$41506.startStoryMessage("none", "Shade Demon", eTalkType.enemy);
							if (244685 - 208398 != 36287)
							{
								continue;
							}
							goto IL_50E;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (167832 - 143372 != 24461)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$nMessage$41507 = Language.getMessage("M904_BattleWithZerbiras", 101);
							if (26904 - 82320 == -55415)
							{
								continue;
							}
							this.$mStoryGui$41506.newStoryMessage("none", "Shade Demon", this.$nMessage$41507, eTalkType.enemy);
							if (217574 - 13272 != 204303)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (224752 - 173072 != 51680)
							{
								continue;
							}
							goto IL_2FA;
						}
						else
						{
							this.$nMessage$41507 = Language.getMessage("M904_BattleWithZerbiras", 102);
							if (195392 - 202081 == -6688)
							{
								continue;
							}
							this.$mStoryGui$41506.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$41507, eTalkType.friend);
							if (168873 - 505197 != -336324)
							{
								continue;
							}
							goto IL_3FD;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (58332 - 281725 != -223392)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							this.$nMessage$41507 = Language.getMessage("M904_BattleWithZerbiras", 103);
							if (149155 - 281578 != -132423)
							{
								continue;
							}
							this.$mStoryGui$41506.newStoryMessage("none", "Shade Demon", this.$nMessage$41507, eTalkType.enemy);
							if (286124 - 428503 != -142379)
							{
								continue;
							}
							goto IL_615;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (737 - 420072 != -419335)
							{
								continue;
							}
							goto IL_549;
						}
						else
						{
							this.$nMessage$41507 = Language.getMessage("M904_BattleWithZerbiras", 104);
							if (52835 - 86657 != -33822)
							{
								continue;
							}
							this.$mStoryGui$41506.newStoryMessage("none", "Shade Demon", this.$nMessage$41507, eTalkType.enemy);
							if (175396 - 19633 != 155764)
							{
								goto Block_47;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (173601 - 221429 != -47828)
							{
								continue;
							}
							goto IL_175;
						}
						else
						{
							this.$mStoryGui$41506.close();
							if (210907 - 137391 != 73517)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (283895 - 329612 != -45717)
							{
								continue;
							}
							goto IL_380;
						}
						else
						{
							this.$self_$41508.yF5n5WDEKCj.enabled = true;
							if (123716 - 348854 == -225137)
							{
								continue;
							}
							this.$self_$41508.yF5n5WDEKCj.specialTarget = null;
							if (220517 - 166402 != 54116)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (72881 - 539741 != -466859)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (9955 - 446107 == -436151)
							{
								continue;
							}
							this.$mGameGui$41505.enabled = true;
							if (129052 - 340391 == -211338)
							{
								continue;
							}
							Game.sendMissionEvent(9041, 2);
							if (175148 - 12703 != 162445)
							{
								continue;
							}
						}
						break;
					default:
						if (193669 - 386918 != -193248)
						{
							goto IL_4E4;
						}
						continue;
					}
					IL_F3:
					this.YieldDefault(1);
					if (15145 - 124879 != -109733)
					{
						goto Block_8;
					}
					continue;
					IL_4E4:
					this.$mEventCamera1$41504 = GameObject.Find("EventCamera1");
					if (129574 - 505495 != -375920)
					{
						this.$mGameGui$41505 = (GameGui)this.$self_$41508.GetComponent(typeof(GameGui));
						if (23848 - 573341 == -549493)
						{
							this.$mStoryGui$41506 = (StoryGui)this.$self_$41508.GetComponent(typeof(StoryGui));
							if (36584 - 460521 != -423936)
							{
								if (!this.$mGameGui$41505)
								{
									goto IL_F3;
								}
								if (299927 - 77685 != 222243)
								{
									if (!this.$mStoryGui$41506)
									{
										goto IL_F3;
									}
									if (170420 - 561578 != -391157)
									{
										Game.mGameState = eGameState.AllHold;
										if (290227 - 101 == 290126)
										{
											this.$mGameGui$41505.close();
											if (79239 - 593378 != -514138)
											{
												if (!this.$mEventCamera1$41504)
												{
													goto IL_25B;
												}
												if (74555 - 331412 == -256857)
												{
													this.$self_$41508.yF5n5WDEKCj.setSpecialTarget(this.$mEventCamera1$41504, 2f);
													if (15049 - 459971 != -444921)
													{
														goto Block_46;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_3:
				return this.Yield(9, new WaitForSeconds(1f));
				Block_7:
				Block_8:
				IL_175:
				goto IL_6ED;
				Block_12:
				return this.Yield(8, new WaitForSeconds(1f));
				IL_25B:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_20:
				IL_2FA:
				IL_380:
				goto IL_6ED;
				IL_3FD:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_31:
				goto IL_6ED;
				IL_50E:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_38:
				IL_549:
				goto IL_6ED;
				IL_615:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_46:
				goto IL_25B;
				Block_47:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_6ED:
				return false;
			}

			// Token: 0x060091FD RID: 37373 RVA: 0x0118708C File Offset: 0x0118528C
			internal static bool cRwyIFVWArp4XW2bny5o()
			{
				return true;
			}

			// Token: 0x060091FE RID: 37374 RVA: 0x01187090 File Offset: 0x01185290
			internal static bool qQ838iVWlCgeWwjtIvff()
			{
				return false;
			}

			// Token: 0x0400898D RID: 35213
			internal GameObject $mEventCamera1$41504;

			// Token: 0x0400898E RID: 35214
			internal GameGui $mGameGui$41505;

			// Token: 0x0400898F RID: 35215
			internal StoryGui $mStoryGui$41506;

			// Token: 0x04008990 RID: 35216
			internal string $nMessage$41507;

			// Token: 0x04008991 RID: 35217
			internal M904_BattleWithZerbiras $self_$41508;
		}
	}

	// Token: 0x02001880 RID: 6272
	[CompilerGenerated]
	[Serializable]
	internal sealed class $CultEvent2$41510 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060091FF RID: 37375 RVA: 0x01187094 File Offset: 0x01185294
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $CultEvent2$41510(M904_BattleWithZerbiras self_)
		{
			if (148660 - 384561 != -235900)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (257657 - 299964 == -42307)
				{
					base..ctor();
					if (188987 - 325919 != -136931)
					{
						this.$self_$41519 = self_;
						if (20358 - 355621 != -335262)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009200 RID: 37376 RVA: 0x0118712C File Offset: 0x0118532C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M904_BattleWithZerbiras.$CultEvent2$41510.$(this.$self_$41519);
		}

		// Token: 0x06009201 RID: 37377 RVA: 0x0118713C File Offset: 0x0118533C
		internal static bool z7YrBdVWywxqe16yMhMx()
		{
			return true;
		}

		// Token: 0x06009202 RID: 37378 RVA: 0x01187140 File Offset: 0x01185340
		internal static bool LalenhVWSEk5oO5YOv2b()
		{
			return false;
		}

		// Token: 0x04008992 RID: 35218
		internal M904_BattleWithZerbiras $self_$41519;

		// Token: 0x02001881 RID: 6273
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009203 RID: 37379 RVA: 0x01187144 File Offset: 0x01185344
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M904_BattleWithZerbiras self_)
			{
				if (229902 - 437228 != -207326)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (155660 - 128904 == 26756)
					{
						base..ctor();
						if (217734 - 358051 == -140317)
						{
							this.$self_$41518 = self_;
							if (204588 - 266220 != -61631)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009204 RID: 37380 RVA: 0x011871DC File Offset: 0x011853DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229241 - 233857 != -4615)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_659;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (19492 - 250185 != -230692)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							if (this.$mEventCamera2$41511)
							{
								if (256784 - 511733 != -254949)
								{
									continue;
								}
								this.$self_$41518.yF5n5WDEKCj.setSpecialTarget(this.$mEventCamera2$41511, 2f);
								if (169086 - 416464 == -247377)
								{
									continue;
								}
							}
							if (this.$mShadowMirror$41512)
							{
								if (119235 - 431876 != -312641)
								{
									continue;
								}
								int num = this.$$14544$41516 = 50;
								if (240566 - 195929 != 44637)
								{
									continue;
								}
								if (291060 - 266775 != 24285)
								{
									continue;
								}
								this.$$14545$41517 = this.$mShadowMirror$41512.transform.position;
								if (17124 - 36727 != -19603)
								{
									continue;
								}
								if (214396 - 224552 != -10156)
								{
									continue;
								}
								this.$$14545$41517.y = (float)this.$$14544$41516;
								if (166565 - 386520 == -219954)
								{
									continue;
								}
								if (247899 - 170387 != 77512)
								{
									continue;
								}
								this.$mShadowMirror$41512.transform.position = this.$$14545$41517;
								if (17494 - 322388 != -304894)
								{
									continue;
								}
								if (202282 - 479759 == -277476)
								{
									continue;
								}
							}
							this.$nMessage$41515 = null;
							if (136477 - 117236 == 19242)
							{
								continue;
							}
							this.$mStoryGui$41514.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (149259 - 386798 != -237538)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (114202 - 562131 != -447929)
							{
								continue;
							}
							goto IL_AD;
						}
						else
						{
							this.$nMessage$41515 = Language.getMessage("M904_BattleWithZerbiras", 201);
							if (167279 - 263191 == -95911)
							{
								continue;
							}
							this.$mStoryGui$41514.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$41515, eTalkType.friend);
							if (75183 - 132395 != -57211)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (215376 - 428265 != -212888)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$41514.close();
							if (29494 - 533218 != -503723)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (106945 - 62155 != 44790)
							{
								continue;
							}
							goto IL_4CD;
						}
						else
						{
							this.$self_$41518.yF5n5WDEKCj.enabled = true;
							if (168650 - 450642 != -281992)
							{
								continue;
							}
							this.$self_$41518.yF5n5WDEKCj.specialTarget = null;
							if (13685 - 499327 != -485642)
							{
								continue;
							}
							goto IL_354;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (40011 - 160705 != -120693)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (30530 - 67279 != -36749)
							{
								continue;
							}
							this.$mGameGui$41513.enabled = true;
							if (192953 - 497523 != -304570)
							{
								continue;
							}
							goto IL_527;
						}
						break;
					default:
						if (211211 - 306466 == -95254)
						{
							continue;
						}
						break;
					}
					this.$mEventCamera2$41511 = GameObject.Find("EventCamera2");
					if (105623 - 112543 != -6920)
					{
						continue;
					}
					this.$mShadowMirror$41512 = GameObject.Find("ShadowMirror");
					if (165519 - 508077 != -342558)
					{
						continue;
					}
					this.$mGameGui$41513 = (GameGui)this.$self_$41518.GetComponent(typeof(GameGui));
					if (226392 - 444315 != -217923)
					{
						continue;
					}
					this.$mStoryGui$41514 = (StoryGui)this.$self_$41518.GetComponent(typeof(StoryGui));
					if (291656 - 439835 == -148178)
					{
						continue;
					}
					if (this.$mGameGui$41513)
					{
						if (16977 - 591011 != -574034)
						{
							continue;
						}
						if (this.$mStoryGui$41514)
						{
							if (110950 - 428973 == -318022)
							{
								continue;
							}
							Game.mGameState = eGameState.AllHold;
							if (148229 - 179448 == -31218)
							{
								continue;
							}
							this.$mGameGui$41513.close();
							if (112954 - 576646 != -463692)
							{
								continue;
							}
							goto IL_38F;
						}
					}
					IL_527:
					this.YieldDefault(1);
				}
				while (36610 - 301043 == -264432);
				IL_AD:
				goto IL_659;
				Block_12:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_354:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_25:
				goto IL_659;
				IL_38F:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_27:
				goto IL_659;
				Block_30:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_32:
				IL_4CD:
				goto IL_659;
				Block_36:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_659:
				return false;
			}

			// Token: 0x06009205 RID: 37381 RVA: 0x01187854 File Offset: 0x01185A54
			internal static bool YprbTdVWoNd0HsEuglGP()
			{
				return true;
			}

			// Token: 0x06009206 RID: 37382 RVA: 0x01187858 File Offset: 0x01185A58
			internal static bool gCiAbNVWENlKri1mUcUR()
			{
				return false;
			}

			// Token: 0x04008993 RID: 35219
			internal GameObject $mEventCamera2$41511;

			// Token: 0x04008994 RID: 35220
			internal GameObject $mShadowMirror$41512;

			// Token: 0x04008995 RID: 35221
			internal GameGui $mGameGui$41513;

			// Token: 0x04008996 RID: 35222
			internal StoryGui $mStoryGui$41514;

			// Token: 0x04008997 RID: 35223
			internal string $nMessage$41515;

			// Token: 0x04008998 RID: 35224
			internal int $$14544$41516;

			// Token: 0x04008999 RID: 35225
			internal Vector3 $$14545$41517;

			// Token: 0x0400899A RID: 35226
			internal M904_BattleWithZerbiras $self_$41518;
		}
	}

	// Token: 0x02001882 RID: 6274
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ZerbirasEvent$41520 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009207 RID: 37383 RVA: 0x0118785C File Offset: 0x01185A5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ZerbirasEvent$41520(int ownerID, M904_BattleWithZerbiras self_)
		{
			if (190551 - 565458 != -374907)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (130357 - 57383 == 72974)
				{
					base..ctor();
					if (4576 - 323817 == -319241)
					{
						this.$ownerID$41538 = ownerID;
						if (170152 - 404132 != -233979)
						{
							this.$self_$41539 = self_;
							if (148428 - 293562 != -145133)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009208 RID: 37384 RVA: 0x01187918 File Offset: 0x01185B18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M904_BattleWithZerbiras.$ZerbirasEvent$41520.$(this.$ownerID$41538, this.$self_$41539);
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x0118792C File Offset: 0x01185B2C
		internal static bool mr3StdVW2UoKvXH4mrvi()
		{
			return true;
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x01187930 File Offset: 0x01185B30
		internal static bool varjOsVW88RqBDd3cg7N()
		{
			return false;
		}

		// Token: 0x0400899B RID: 35227
		internal int $ownerID$41538;

		// Token: 0x0400899C RID: 35228
		internal M904_BattleWithZerbiras $self_$41539;

		// Token: 0x02001883 RID: 6275
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600920B RID: 37387 RVA: 0x01187934 File Offset: 0x01185B34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int ownerID, M904_BattleWithZerbiras self_)
			{
				if (52483 - 531374 != -478890)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35302 - 282479 == -247177)
					{
						base..ctor();
						if (173116 - 331703 != -158586)
						{
							this.$ownerID$41536 = ownerID;
							if (156867 - 510129 == -353262)
							{
								this.$self_$41537 = self_;
								if (124786 - 35534 != 89253)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600920C RID: 37388 RVA: 0x011879F0 File Offset: 0x01185BF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91392 - 145086 != -53694)
				{
				}
				for (;;)
				{
					IL_146:
					switch (this._state)
					{
					case 0:
						goto IL_81C;
					case 1:
						goto IL_10EE;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (162361 - 320137 != -157775)
							{
								goto Block_119;
							}
							continue;
						}
						else
						{
							this.$self_$41537.ShadowMirrorHide(true);
							if (215444 - 223262 == -7817)
							{
								continue;
							}
							if (this.$ownerID$41536 != PlayerData.UID)
							{
								goto IL_1A3;
							}
							if (190685 - 491406 == -300720)
							{
								continue;
							}
							this.$self_$41537.gvAn5KwCCoW = true;
							if (280987 - 569471 != -288484)
							{
								continue;
							}
							this.$mWarpPoint$41524 = GameObject.Find("WarpPoint");
							if (174151 - 187075 == -12923)
							{
								continue;
							}
							if (this.$mWarpPoint$41524)
							{
								if (74040 - 275440 == -201399)
								{
									continue;
								}
								this.$warpList$41525 = Damage.FindAreaTarget(Game.mPlayer.transform.position, (float)40, (float)12, 1 << Game.mPlayer.layer);
								if (252265 - 363324 != -111059)
								{
									continue;
								}
								this.$$iterator$10959$41529 = UnityRuntimeServices.GetEnumerator(this.$warpList$41525);
								if (64706 - 453942 != -389236)
								{
									continue;
								}
								while (this.$$iterator$10959$41529.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10959$41529.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$warpObject$41526 = (GameObject)obj2;
									if (82338 - 476640 == -394301)
									{
										goto IL_146;
									}
									this.$warpChar$41527 = (CharacterControl)this.$warpObject$41526.GetComponent(typeof(CharacterControl));
									if (137605 - 100820 == 36786)
									{
										goto IL_146;
									}
									UnityRuntimeServices.Update(this.$$iterator$10959$41529, this.$warpObject$41526);
									if (118701 - 271859 == -153157)
									{
										goto IL_146;
									}
									if (!(this.$warpObject$41526 == Game.mPlayer))
									{
										if (296091 - 478879 == -182787)
										{
											goto IL_146;
										}
										if (!this.$warpChar$41527.isMine)
										{
											continue;
										}
										if (110080 - 566392 == -456311)
										{
											goto IL_146;
										}
										if (!this.$warpChar$41527.isSummon)
										{
											continue;
										}
										if (28221 - 145476 != -117255)
										{
											goto IL_146;
										}
										if (!(this.$warpChar$41527.mSummoner == Game.mPlayer))
										{
											continue;
										}
										if (251695 - 240259 != 11436)
										{
											goto IL_146;
										}
										if (!this.$warpChar$41527.recieveMovement)
										{
											continue;
										}
										if (69530 - 492927 != -423397)
										{
											goto IL_146;
										}
									}
									this.$mWarpPos$41528 = global::Math.getRandomSpawnPos(this.$mWarpPoint$41524.transform.position, 2);
									if (143755 - 544071 != -400316)
									{
										goto IL_146;
									}
									if (this.$mWarpPos$41528 == Vector3.zero)
									{
										if (183301 - 435737 != -252436)
										{
											goto IL_146;
										}
										this.$mWarpPos$41528 = this.$mWarpPoint$41524.transform.position;
										if (144092 - 417111 == -273018)
										{
											goto IL_146;
										}
									}
									this.$warpObject$41526.transform.position = this.$mWarpPos$41528;
									if (210257 - 232467 == -22209)
									{
										goto IL_146;
									}
									UnityRuntimeServices.Update(this.$$iterator$10959$41529, this.$warpObject$41526);
									if (89902 - 386713 == -296810)
									{
										goto IL_146;
									}
									this.$warpObject$41526.transform.rotation = Quaternion.LookRotation(this.$mWarpPoint$41524.transform.forward);
									if (206299 - 153311 != 52988)
									{
										goto IL_146;
									}
									UnityRuntimeServices.Update(this.$$iterator$10959$41529, this.$warpObject$41526);
									if (83878 - 376478 == -292599)
									{
										goto IL_146;
									}
									if (this.$warpChar$41527)
									{
										if (224290 - 234959 != -10669)
										{
											goto IL_146;
										}
										this.$warpChar$41527.PositionEvent();
										if (266691 - 273718 != -7027)
										{
											goto IL_146;
										}
									}
								}
								if (258294 - 380623 != -122329)
								{
									continue;
								}
								goto IL_1030;
							}
							else
							{
								Debug.LogError("Error: Missing WarpPoint");
								if (115967 - 574674 != -458707)
								{
									continue;
								}
								goto IL_1A3;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (146073 - 422541 != -276467)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$mGameGui$41521.close();
							if (202466 - 528504 != -326038)
							{
								continue;
							}
							this.$self_$41537.SendMessage("fadeOut");
							if (49396 - 401024 != -351627)
							{
								goto Block_103;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (151914 - 366823 != -214909)
							{
								continue;
							}
							goto IL_F87;
						}
						else
						{
							this.$self_$41537.yF5n5WDEKCj.alignToObject("EventCamera3");
							if (91305 - 521656 != -430351)
							{
								continue;
							}
							this.$self_$41537.SendMessage("fadeIn");
							if (284072 - 563587 != -279514)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (257771 - 256047 != 1724)
							{
								continue;
							}
							goto IL_6B1;
						}
						else
						{
							this.$nMessage$41530 = null;
							if (110871 - 144140 == -33268)
							{
								continue;
							}
							this.$mStoryGui$41522.startStoryMessage("none", "Shade Demon", eTalkType.enemy);
							if (130468 - 491041 != -360573)
							{
								continue;
							}
							goto IL_3F7;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (98596 - 344574 != -245977)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$nMessage$41530 = Language.getMessage("M904_BattleWithZerbiras", 301);
							if (87597 - 25936 == 61662)
							{
								continue;
							}
							this.$mStoryGui$41522.newStoryMessage("none", "Shade Demon", this.$nMessage$41530, eTalkType.enemy);
							if (218847 - 33416 != 185431)
							{
								continue;
							}
							goto IL_C04;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (145287 - 147619 != -2332)
							{
								continue;
							}
							goto IL_72C;
						}
						else
						{
							this.$mEventCamera4$41531 = GameObject.Find("EventCamera4");
							if (148818 - 488516 == -339697)
							{
								continue;
							}
							if (this.$mEventCamera4$41531)
							{
								if (266134 - 270701 == -4566)
								{
									continue;
								}
								this.$self_$41537.yF5n5WDEKCj.setSpecialTarget(this.$mEventCamera4$41531, 2f);
								if (60195 - 71665 != -11470)
								{
									continue;
								}
							}
							this.$nMessage$41530 = Language.getMessage("M904_BattleWithZerbiras", 302);
							if (124448 - 428225 != -303777)
							{
								continue;
							}
							this.$mStoryGui$41522.newStoryMessage("none", "Shade Demon", this.$nMessage$41530, eTalkType.enemy);
							if (238178 - 119068 != 119111)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (189761 - 367904 != -178142)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$41537.SendMessage("fadeOut");
							if (214030 - 242068 != -28038)
							{
								continue;
							}
							goto IL_7B9;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (83000 - 555271 != -472270)
							{
								goto Block_59;
							}
							continue;
						}
						else
						{
							if (this.$ownerID$41536 == PlayerData.UID)
							{
								if (20888 - 475322 != -454434)
								{
									continue;
								}
								this.$mSpawnPoint1$41532 = GameObject.Find("SpawnPoint1");
								if (197803 - 77880 == 119924)
								{
									continue;
								}
								if (this.$mSpawnPoint1$41532)
								{
									if (197930 - 203388 != -5458)
									{
										continue;
									}
									this.$self_$41537.createActor("Zerbiras", 9, this.$mSpawnPoint1$41532.transform.position, this.$mSpawnPoint1$41532.transform.forward);
									if (175215 - 20697 != 154518)
									{
										continue;
									}
								}
							}
							else
							{
								this.$mSpawnPoint$41533 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(2, 4));
								if (144243 - 478929 == -334685)
								{
									continue;
								}
								if (this.$mSpawnPoint$41533)
								{
									if (237254 - 8791 == 228464)
									{
										continue;
									}
									this.$mSpawnPos$41534 = global::Math.getSpawnPos(this.$mSpawnPoint$41533.transform.position + global::Math.vFlat((float)9 * UnityEngine.Random.insideUnitSphere));
									if (819 - 232317 == -231497)
									{
										continue;
									}
									if (this.$mSpawnPos$41534 == Vector3.zero)
									{
										if (210200 - 100418 == 109783)
										{
											continue;
										}
										this.$mSpawnPos$41534 = this.$mSpawnPoint$41533.transform.position;
										if (223200 - 573949 != -350749)
										{
											continue;
										}
									}
									this.$$switch$7474$41535 = UnityEngine.Random.Range(0, 4);
									if (78649 - 175223 == -96573)
									{
										continue;
									}
									if (this.$$switch$7474$41535 == 0)
									{
										if (6607 - 406548 != -399941)
										{
											continue;
										}
										this.$self_$41537.createActor("BisonCult", 7, this.$mSpawnPos$41534, this.$mSpawnPoint$41533.transform.forward);
										if (90074 - 193847 != -103773)
										{
											continue;
										}
									}
									else if (this.$$switch$7474$41535 == 1)
									{
										if (53674 - 321743 == -268068)
										{
											continue;
										}
										this.$self_$41537.createActor("RabbitCult", 7, this.$mSpawnPos$41534, this.$mSpawnPoint$41533.transform.forward);
										if (108330 - 63803 == 44528)
										{
											continue;
										}
									}
									else if (this.$$switch$7474$41535 == 2)
									{
										if (25517 - 454056 != -428539)
										{
											continue;
										}
										this.$self_$41537.createActor("SheepCult", 7, this.$mSpawnPos$41534, this.$mSpawnPoint$41533.transform.forward);
										if (213969 - 338856 == -124886)
										{
											continue;
										}
									}
									else if (this.$$switch$7474$41535 == 3)
									{
										if (274756 - 558462 != -283706)
										{
											continue;
										}
										this.$self_$41537.createActor("BatCult", 7, this.$mSpawnPos$41534, this.$mSpawnPoint$41533.transform.forward);
										if (271448 - 376770 != -105322)
										{
											continue;
										}
									}
								}
							}
							this.$self_$41537.SendMessage("fadeIn");
							if (93404 - 445896 != -352491)
							{
								goto Block_113;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (252440 - 140864 != 111577)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$nMessage$41530 = Language.getMessage("M904_BattleWithZerbiras", 303);
							if (244593 - 199171 == 45423)
							{
								continue;
							}
							this.$mStoryGui$41522.newStoryMessage("none", "Shade Demon", this.$nMessage$41530, eTalkType.enemy);
							if (206226 - 441846 != -235620)
							{
								continue;
							}
							goto IL_880;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (212872 - 482523 != -269650)
							{
								goto Block_65;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$41522.close();
							if (102782 - 505675 != -402892)
							{
								goto Block_100;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (108647 - 380623 != -271975)
							{
								goto Block_69;
							}
							continue;
						}
						else
						{
							this.$self_$41537.yF5n5WDEKCj.enabled = true;
							if (299567 - 39518 == 260050)
							{
								continue;
							}
							this.$self_$41537.yF5n5WDEKCj.specialTarget = null;
							if (299763 - 24329 != 275434)
							{
								continue;
							}
							goto IL_EC0;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (287154 - 246848 != 40306)
							{
								continue;
							}
							goto IL_45;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (111489 - 538785 == -427295)
							{
								continue;
							}
							this.$mGameGui$41521.enabled = true;
							if (255911 - 367667 == -111755)
							{
								continue;
							}
						}
						break;
					default:
						if (262747 - 162596 != 100152)
						{
							goto IL_81C;
						}
						continue;
					}
					IL_26B:
					this.YieldDefault(1);
					if (226445 - 70614 != 155832)
					{
						break;
					}
					continue;
					IL_81C:
					this.$mGameGui$41521 = (GameGui)this.$self_$41537.GetComponent(typeof(GameGui));
					if (103689 - 22509 != 81181)
					{
						this.$mStoryGui$41522 = (StoryGui)this.$self_$41537.GetComponent(typeof(StoryGui));
						if (164068 - 28702 == 135366)
						{
							this.$mShade4$41523 = GameObject.Find("Shade4");
							if (40684 - 385051 == -344367)
							{
								if (!this.$mGameGui$41521)
								{
									goto IL_26B;
								}
								if (258086 - 158839 != 99248)
								{
									if (!this.$mStoryGui$41522)
									{
										goto IL_26B;
									}
									if (181022 - 357408 == -176386)
									{
										Game.mGameState = eGameState.AllHold;
										if (11869 - 202912 == -191043)
										{
											goto IL_1059;
										}
									}
								}
							}
						}
					}
				}
				IL_45:
				goto IL_10EE;
				IL_1A3:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_11:
				goto IL_10EE;
				Block_18:
				return this.Yield(5, new WaitForSeconds((float)1));
				Block_21:
				Block_23:
				goto IL_10EE;
				Block_27:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_3F7:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_29:
				IL_6B1:
				IL_72C:
				goto IL_10EE;
				IL_7B9:
				return this.Yield(9, new WaitForSeconds((float)1));
				Block_59:
				goto IL_10EE;
				IL_880:
				return this.Yield(11, new WaitForSeconds(3f));
				Block_65:
				Block_69:
				goto IL_10EE;
				IL_C04:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_100:
				return this.Yield(12, new WaitForSeconds(1f));
				Block_103:
				return this.Yield(4, new WaitForSeconds((float)1));
				IL_EC0:
				return this.Yield(13, new WaitForSeconds(1f));
				Block_113:
				return this.Yield(10, new WaitForSeconds((float)1));
				IL_F87:
				goto IL_10EE;
				IL_1030:
				goto IL_1A3;
				IL_1059:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_119:
				IL_10EE:
				return false;
			}

			// Token: 0x0600920D RID: 37389 RVA: 0x01188B00 File Offset: 0x01186D00
			internal static bool ycmnofVWZOSl6Wk0VMNZ()
			{
				return true;
			}

			// Token: 0x0600920E RID: 37390 RVA: 0x01188B04 File Offset: 0x01186D04
			internal static bool Inwc1UVWCXZpy4IX7n6X()
			{
				return false;
			}

			// Token: 0x0400899D RID: 35229
			internal GameGui $mGameGui$41521;

			// Token: 0x0400899E RID: 35230
			internal StoryGui $mStoryGui$41522;

			// Token: 0x0400899F RID: 35231
			internal GameObject $mShade4$41523;

			// Token: 0x040089A0 RID: 35232
			internal GameObject $mWarpPoint$41524;

			// Token: 0x040089A1 RID: 35233
			internal UnityScript.Lang.Array $warpList$41525;

			// Token: 0x040089A2 RID: 35234
			internal GameObject $warpObject$41526;

			// Token: 0x040089A3 RID: 35235
			internal CharacterControl $warpChar$41527;

			// Token: 0x040089A4 RID: 35236
			internal Vector3 $mWarpPos$41528;

			// Token: 0x040089A5 RID: 35237
			internal IEnumerator $$iterator$10959$41529;

			// Token: 0x040089A6 RID: 35238
			internal string $nMessage$41530;

			// Token: 0x040089A7 RID: 35239
			internal GameObject $mEventCamera4$41531;

			// Token: 0x040089A8 RID: 35240
			internal GameObject $mSpawnPoint1$41532;

			// Token: 0x040089A9 RID: 35241
			internal GameObject $mSpawnPoint$41533;

			// Token: 0x040089AA RID: 35242
			internal Vector3 $mSpawnPos$41534;

			// Token: 0x040089AB RID: 35243
			internal int $$switch$7474$41535;

			// Token: 0x040089AC RID: 35244
			internal int $ownerID$41536;

			// Token: 0x040089AD RID: 35245
			internal M904_BattleWithZerbiras $self_$41537;
		}
	}

	// Token: 0x02001884 RID: 6276
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41540 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600920F RID: 37391 RVA: 0x01188B08 File Offset: 0x01186D08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41540(M904_BattleWithZerbiras self_)
		{
			if (44404 - 579587 != -535183)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (111558 - 207733 == -96175)
				{
					base..ctor();
					if (88298 - 315791 == -227493)
					{
						this.$self_$41543 = self_;
						if (99081 - 503573 == -404492)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009210 RID: 37392 RVA: 0x01188BA0 File Offset: 0x01186DA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M904_BattleWithZerbiras.$StartGame$41540.$(this.$self_$41543);
		}

		// Token: 0x06009211 RID: 37393 RVA: 0x01188BB0 File Offset: 0x01186DB0
		internal static bool UxogBOVWLs6OC7iynH8e()
		{
			return true;
		}

		// Token: 0x06009212 RID: 37394 RVA: 0x01188BB4 File Offset: 0x01186DB4
		internal static bool f5ZUjIVWOp6uZr077ae5()
		{
			return false;
		}

		// Token: 0x040089AE RID: 35246
		internal M904_BattleWithZerbiras $self_$41543;

		// Token: 0x02001885 RID: 6277
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009213 RID: 37395 RVA: 0x01188BB8 File Offset: 0x01186DB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M904_BattleWithZerbiras self_)
			{
				if (169540 - 373496 != -203956)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (107106 - 403142 == -296036)
					{
						base..ctor();
						if (3849 - 279976 == -276127)
						{
							this.$self_$41542 = self_;
							if (295939 - 431712 == -135773)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009214 RID: 37396 RVA: 0x01188C50 File Offset: 0x01186E50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (5574 - 20683 != -15108)
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
						if (253449 - 418980 != -165531)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (78918 - 407768 == -328849)
						{
							continue;
						}
						this.YieldDefault(1);
						if (116892 - 371814 != -254921)
						{
							goto Block_7;
						}
						continue;
					default:
						if (37200 - 51777 != -14577)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (137966 - 371927 == -233961)
					{
						Game.mGameState = eGameState.Start;
						if (73825 - 341248 != -267422)
						{
							Game.mGameTime = Time.time;
							if (295884 - 131943 == 163941)
							{
								this.$mGameGui$41541 = (GameGui)this.$self_$41542.GetComponent(typeof(GameGui));
								if (283028 - 535847 != -252818)
								{
									this.$mGameGui$41541.enabled = true;
									if (247064 - 14549 == 232515)
									{
										this.$self_$41542.SendMessage("fadeIn");
										if (55849 - 220290 == -164441)
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
				Block_7:
				IL_1B9:
				return false;
			}

			// Token: 0x06009215 RID: 37397 RVA: 0x01188E28 File Offset: 0x01187028
			internal static bool z54J9yVWmq3Vi1RnSHNP()
			{
				return true;
			}

			// Token: 0x06009216 RID: 37398 RVA: 0x01188E2C File Offset: 0x0118702C
			internal static bool JXbK09VWFVjwpmwkxmtB()
			{
				return false;
			}

			// Token: 0x040089AF RID: 35247
			internal GameGui $mGameGui$41541;

			// Token: 0x040089B0 RID: 35248
			internal M904_BattleWithZerbiras $self_$41542;
		}
	}

	// Token: 0x02001886 RID: 6278
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41544 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009217 RID: 37399 RVA: 0x01188E30 File Offset: 0x01187030
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41544(M904_BattleWithZerbiras self_)
		{
			if (248714 - 113338 != 135376)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (107349 - 255212 != -147862)
				{
					base..ctor();
					if (86022 - 459856 == -373834)
					{
						this.$self_$41549 = self_;
						if (288761 - 303574 == -14813)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009218 RID: 37400 RVA: 0x01188EC8 File Offset: 0x011870C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M904_BattleWithZerbiras.$onDeadPlayer$41544.$(this.$self_$41549);
		}

		// Token: 0x06009219 RID: 37401 RVA: 0x01188ED8 File Offset: 0x011870D8
		internal static bool AE5VopVWMOnRNv5H4iYo()
		{
			return true;
		}

		// Token: 0x0600921A RID: 37402 RVA: 0x01188EDC File Offset: 0x011870DC
		internal static bool kxqYaHVWxEXnTpwVJTBp()
		{
			return false;
		}

		// Token: 0x040089B1 RID: 35249
		internal M904_BattleWithZerbiras $self_$41549;

		// Token: 0x02001887 RID: 6279
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600921B RID: 37403 RVA: 0x01188EE0 File Offset: 0x011870E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M904_BattleWithZerbiras self_)
			{
				if (138458 - 199346 != -60888)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (298110 - 442686 != -144575)
					{
						base..ctor();
						if (29726 - 599645 == -569919)
						{
							this.$self_$41548 = self_;
							if (271005 - 41793 != 229213)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600921C RID: 37404 RVA: 0x01188F78 File Offset: 0x01187178
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (217072 - 566346 != -349274)
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
							if (164133 - 237570 != -73437)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1DA;
							}
							if (112501 - 341157 == -228655)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (87990 - 99922 == -11931)
						{
							continue;
						}
						this.$mStoryGui$41545 = (StoryGui)this.$self_$41548.GetComponent(typeof(StoryGui));
						if (210329 - 200176 != 10153)
						{
							continue;
						}
						if (this.$mStoryGui$41545)
						{
							if (126695 - 12320 == 114376)
							{
								continue;
							}
							this.$mStoryGui$41545.close();
							if (164546 - 18820 == 145727)
							{
								continue;
							}
						}
						this.$mChangeGui$41546 = (ChangeGui)this.$self_$41548.GetComponent(typeof(ChangeGui));
						if (147549 - 448486 == -300936)
						{
							continue;
						}
						if (this.$mChangeGui$41546)
						{
							if (59563 - 25184 != 34379)
							{
								continue;
							}
							this.$mChangeGui$41546.close();
							if (27169 - 438574 == -411404)
							{
								continue;
							}
						}
						this.$mGameGui$41547 = (GameGui)this.$self_$41548.GetComponent(typeof(GameGui));
						if (161285 - 543136 == -381850)
						{
							continue;
						}
						if (this.$mGameGui$41547)
						{
							if (192618 - 92299 == 100320)
							{
								continue;
							}
							if (!this.$mGameGui$41547.enabled)
							{
								if (135349 - 89470 == 45880)
								{
									continue;
								}
								this.$mGameGui$41547.enabled = true;
								if (145552 - 572844 == -427291)
								{
									continue;
								}
							}
							this.$mGameGui$41547.openDeadMenu();
							if (158136 - 210236 != -52100)
							{
								continue;
							}
						}
						IL_1DA:
						this.YieldDefault(1);
						if (250780 - 508441 != -257661)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (268888 - 441405 != -172517)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (231325 - 437373 == -206047);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600921D RID: 37405 RVA: 0x01189290 File Offset: 0x01187490
			internal static bool UBQJOnVWgKnJdunGwnZu()
			{
				return true;
			}

			// Token: 0x0600921E RID: 37406 RVA: 0x01189294 File Offset: 0x01187494
			internal static bool T9yK9jVWf86QOqg9kkG9()
			{
				return false;
			}

			// Token: 0x040089B2 RID: 35250
			internal StoryGui $mStoryGui$41545;

			// Token: 0x040089B3 RID: 35251
			internal ChangeGui $mChangeGui$41546;

			// Token: 0x040089B4 RID: 35252
			internal GameGui $mGameGui$41547;

			// Token: 0x040089B5 RID: 35253
			internal M904_BattleWithZerbiras $self_$41548;
		}
	}

	// Token: 0x02001888 RID: 6280
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$41550 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600921F RID: 37407 RVA: 0x01189298 File Offset: 0x01187498
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$41550(Hashtable data, M904_BattleWithZerbiras self_)
		{
			if (99882 - 160804 != -60921)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (43193 - 404000 != -360806)
				{
					base..ctor();
					if (228253 - 136490 != 91764)
					{
						this.$data$41555 = data;
						if (126781 - 362908 != -236126)
						{
							this.$self_$41556 = self_;
							if (273304 - 586282 != -312977)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009220 RID: 37408 RVA: 0x01189354 File Offset: 0x01187554
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M904_BattleWithZerbiras.$onChangePlayer$41550.$(this.$data$41555, this.$self_$41556);
		}

		// Token: 0x06009221 RID: 37409 RVA: 0x01189368 File Offset: 0x01187568
		internal static bool enEPWNVWncuGSDI9vicg()
		{
			return true;
		}

		// Token: 0x06009222 RID: 37410 RVA: 0x0118936C File Offset: 0x0118756C
		internal static bool gDxsUjVW6r6jDYOelaT7()
		{
			return false;
		}

		// Token: 0x040089B6 RID: 35254
		internal Hashtable $data$41555;

		// Token: 0x040089B7 RID: 35255
		internal M904_BattleWithZerbiras $self_$41556;

		// Token: 0x02001889 RID: 6281
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009223 RID: 37411 RVA: 0x01189370 File Offset: 0x01187570
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M904_BattleWithZerbiras self_)
			{
				if (102626 - 296706 != -194079)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (104690 - 354126 != -249435)
					{
						base..ctor();
						if (45961 - 490025 != -444063)
						{
							this.$data$41553 = data;
							if (164528 - 261542 == -97014)
							{
								this.$self_$41554 = self_;
								if (175662 - 131108 != 44555)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009224 RID: 37412 RVA: 0x0118942C File Offset: 0x0118762C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (9289 - 180664 != -171374)
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
							if (17343 - 209515 == -192171)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (44942 - 182291 == -137348)
							{
								continue;
							}
							this.$mGameGui$41552 = (GameGui)this.$self_$41554.GetComponent(typeof(GameGui));
							if (67735 - 493407 == -425671)
							{
								continue;
							}
							this.$mGameGui$41552.enabled = true;
							if (121061 - 130986 != -9925)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (199049 - 447986 != -248937)
						{
							continue;
						}
						goto IL_205;
					default:
						if (206131 - 457551 == -251419)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (3379 - 368814 != -365434)
					{
						this.$self_$41554.SendMessage("onCreatePlayer", this.$data$41553);
						if (18408 - 69676 == -51268)
						{
							this.$mChangeGui$41551 = (ChangeGui)this.$self_$41554.GetComponent(typeof(ChangeGui));
							if (258048 - 281695 != -23646)
							{
								if (!this.$mChangeGui$41551.enabled)
								{
									break;
								}
								if (171745 - 497067 == -325322)
								{
									this.$mChangeGui$41551.close();
									if (197020 - 172864 != 24157)
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

			// Token: 0x06009225 RID: 37413 RVA: 0x01189650 File Offset: 0x01187850
			internal static bool sxscbjVWi45nmGSXxp8u()
			{
				return true;
			}

			// Token: 0x06009226 RID: 37414 RVA: 0x01189654 File Offset: 0x01187854
			internal static bool TsBSRXVWKFn70DreAsna()
			{
				return false;
			}

			// Token: 0x040089B8 RID: 35256
			internal ChangeGui $mChangeGui$41551;

			// Token: 0x040089B9 RID: 35257
			internal GameGui $mGameGui$41552;

			// Token: 0x040089BA RID: 35258
			internal Hashtable $data$41553;

			// Token: 0x040089BB RID: 35259
			internal M904_BattleWithZerbiras $self_$41554;
		}
	}

	// Token: 0x0200188A RID: 6282
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41557 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009227 RID: 37415 RVA: 0x01189658 File Offset: 0x01187858
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41557(M904_BattleWithZerbiras self_)
		{
			if (24419 - 305096 != -280677)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (200149 - 23676 == 176473)
				{
					base..ctor();
					if (193986 - 198368 == -4382)
					{
						this.$self_$41561 = self_;
						if (200648 - 166462 == 34186)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009228 RID: 37416 RVA: 0x011896F0 File Offset: 0x011878F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M904_BattleWithZerbiras.$ReturnToTown$41557.$(this.$self_$41561);
		}

		// Token: 0x06009229 RID: 37417 RVA: 0x01189700 File Offset: 0x01187900
		internal static bool LryhQDVWdmk4vnCeLVe4()
		{
			return true;
		}

		// Token: 0x0600922A RID: 37418 RVA: 0x01189704 File Offset: 0x01187904
		internal static bool hV5cTUVWJ61MxQQfQ3pN()
		{
			return false;
		}

		// Token: 0x040089BC RID: 35260
		internal M904_BattleWithZerbiras $self_$41561;

		// Token: 0x0200188B RID: 6283
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600922B RID: 37419 RVA: 0x01189708 File Offset: 0x01187908
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M904_BattleWithZerbiras self_)
			{
				if (153469 - 136896 != 16574)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (184435 - 415619 == -231184)
					{
						base..ctor();
						if (205628 - 75980 == 129648)
						{
							this.$self_$41560 = self_;
							if (255249 - 427119 != -171869)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600922C RID: 37420 RVA: 0x011897A0 File Offset: 0x011879A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (237672 - 10347 != 227326)
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
						this.$self_$41560.LeaveGame();
						if (234180 - 167304 != 66876)
						{
							continue;
						}
						this.YieldDefault(1);
						if (137173 - 74127 != 63046)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (279573 - 391767 != -112194)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (57771 - 190897 == -133126)
					{
						Game.mStateTime = Time.time;
						if (128963 - 141647 == -12684)
						{
							this.$$switch$7486$41558 = PlayerData.SaveGuild;
							if (251343 - 515481 == -264138)
							{
								if (this.$$switch$7486$41558 == 1)
								{
									if (34509 - 69311 != -34802)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (177747 - 72080 == 105668)
									{
										continue;
									}
								}
								else if (this.$$switch$7486$41558 == 2)
								{
									if (292845 - 9059 != 283786)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (275465 - 126371 == 149095)
									{
										continue;
									}
								}
								else if (this.$$switch$7486$41558 == 3)
								{
									if (281949 - 360227 != -78278)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (299588 - 477278 != -177690)
									{
										continue;
									}
								}
								else if (this.$$switch$7486$41558 == 4)
								{
									if (8460 - 472706 != -464246)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (211638 - 271683 == -60044)
									{
										continue;
									}
								}
								else if (this.$$switch$7486$41558 == 5)
								{
									if (187172 - 530954 == -343781)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (278391 - 427583 != -149192)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (234643 - 209232 == 25412)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (150554 - 373296 != -222742)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (280825 - 389858 != -109033)
									{
										continue;
									}
								}
								this.$mGameGui$41559 = (GameGui)this.$self_$41560.GetComponent(typeof(GameGui));
								if (135592 - 317712 != -182119)
								{
									if (this.$mGameGui$41559)
									{
										if (228998 - 47864 != 181134)
										{
											continue;
										}
										this.$mGameGui$41559.close();
										if (11949 - 305366 != -293417)
										{
											continue;
										}
									}
									this.$self_$41560.SendMessage("fadeOut");
									if (201294 - 120968 == 80326)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600922D RID: 37421 RVA: 0x01189B6C File Offset: 0x01187D6C
			internal static bool sphRsOVWDcbcFS1RtXnl()
			{
				return true;
			}

			// Token: 0x0600922E RID: 37422 RVA: 0x01189B70 File Offset: 0x01187D70
			internal static bool O9Cc3HVWviAl6P5IKFkb()
			{
				return false;
			}

			// Token: 0x040089BD RID: 35261
			internal int $$switch$7486$41558;

			// Token: 0x040089BE RID: 35262
			internal GameGui $mGameGui$41559;

			// Token: 0x040089BF RID: 35263
			internal M904_BattleWithZerbiras $self_$41560;
		}
	}

	// Token: 0x0200188C RID: 6284
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41562 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600922F RID: 37423 RVA: 0x01189B74 File Offset: 0x01187D74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41562(M904_BattleWithZerbiras self_)
		{
			if (101677 - 284047 != -182369)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217198 - 568079 == -350881)
				{
					base..ctor();
					if (226310 - 461837 != -235526)
					{
						this.$self_$41565 = self_;
						if (113542 - 196374 != -82831)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009230 RID: 37424 RVA: 0x01189C0C File Offset: 0x01187E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M904_BattleWithZerbiras.$ReturnToGuild$41562.$(this.$self_$41565);
		}

		// Token: 0x06009231 RID: 37425 RVA: 0x01189C1C File Offset: 0x01187E1C
		internal static bool n0QpLGVWRn5hZfHEthqr()
		{
			return true;
		}

		// Token: 0x06009232 RID: 37426 RVA: 0x01189C20 File Offset: 0x01187E20
		internal static bool iZi5OcVWwuGnsy1xvNNp()
		{
			return false;
		}

		// Token: 0x040089C0 RID: 35264
		internal M904_BattleWithZerbiras $self_$41565;

		// Token: 0x0200188D RID: 6285
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009233 RID: 37427 RVA: 0x01189C24 File Offset: 0x01187E24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M904_BattleWithZerbiras self_)
			{
				if (51535 - 573609 != -522074)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240227 - 130104 == 110123)
					{
						base..ctor();
						if (30961 - 85222 != -54260)
						{
							this.$self_$41564 = self_;
							if (192403 - 532088 != -339684)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009234 RID: 37428 RVA: 0x01189CBC File Offset: 0x01187EBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (26191 - 57943 != -31751)
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
						this.$self_$41564.LeaveGame();
						if (232257 - 74412 != 157845)
						{
							continue;
						}
						this.YieldDefault(1);
						if (280393 - 379947 != -99554)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (155048 - 222071 != -67023)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (272084 - 63138 == 208946)
					{
						Game.mStateTime = Time.time;
						if (145237 - 592068 != -446830)
						{
							Game.mNextGameCode = 31;
							if (140286 - 265886 != -125599)
							{
								this.$mGameGui$41563 = (GameGui)this.$self_$41564.GetComponent(typeof(GameGui));
								if (166071 - 174747 != -8675)
								{
									if (this.$mGameGui$41563)
									{
										if (121779 - 219800 != -98021)
										{
											continue;
										}
										this.$mGameGui$41563.close();
										if (110750 - 228711 == -117960)
										{
											continue;
										}
									}
									this.$self_$41564.SendMessage("fadeOut");
									if (125200 - 138176 != -12975)
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

			// Token: 0x06009235 RID: 37429 RVA: 0x01189E98 File Offset: 0x01188098
			internal static bool hFabvHVWqd61qjZI6pY3()
			{
				return true;
			}

			// Token: 0x06009236 RID: 37430 RVA: 0x01189E9C File Offset: 0x0118809C
			internal static bool ofDA1jVW70xAw6ghFkSk()
			{
				return false;
			}

			// Token: 0x040089C1 RID: 35265
			internal GameGui $mGameGui$41563;

			// Token: 0x040089C2 RID: 35266
			internal M904_BattleWithZerbiras $self_$41564;
		}
	}

	// Token: 0x0200188E RID: 6286
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$41566 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009237 RID: 37431 RVA: 0x01189EA0 File Offset: 0x011880A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$41566(M904_BattleWithZerbiras self_)
		{
			if (185759 - 328772 != -143012)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (297781 - 297888 == -107)
				{
					base..ctor();
					if (280323 - 476534 == -196211)
					{
						this.$self_$41570 = self_;
						if (65221 - 275307 != -210085)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009238 RID: 37432 RVA: 0x01189F38 File Offset: 0x01188138
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M904_BattleWithZerbiras.$ReturnToCamp$41566.$(this.$self_$41570);
		}

		// Token: 0x06009239 RID: 37433 RVA: 0x01189F48 File Offset: 0x01188148
		internal static bool jqTSFvVWPnHiLrqxd0Xm()
		{
			return true;
		}

		// Token: 0x0600923A RID: 37434 RVA: 0x01189F4C File Offset: 0x0118814C
		internal static bool aldL8eVW0T43IZrq4LMO()
		{
			return false;
		}

		// Token: 0x040089C3 RID: 35267
		internal M904_BattleWithZerbiras $self_$41570;

		// Token: 0x0200188F RID: 6287
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600923B RID: 37435 RVA: 0x01189F50 File Offset: 0x01188150
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M904_BattleWithZerbiras self_)
			{
				if (85752 - 4441 != 81312)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (259722 - 570438 != -310715)
					{
						base..ctor();
						if (121047 - 416398 == -295351)
						{
							this.$self_$41569 = self_;
							if (70860 - 6270 != 64591)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600923C RID: 37436 RVA: 0x01189FE8 File Offset: 0x011881E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79452 - 282861 != -203408)
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
						this.$self_$41569.LeaveGame();
						if (96828 - 341025 != -244197)
						{
							continue;
						}
						this.YieldDefault(1);
						if (216811 - 561330 != -344518)
						{
							goto Block_16;
						}
						continue;
					default:
						if (230580 - 532891 != -302311)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (86404 - 349608 != -263203)
					{
						Game.mStateTime = Time.time;
						if (157896 - 50272 == 107624)
						{
							this.$$switch$7488$41567 = PlayerData.SaveGuild;
							if (136370 - 47426 == 88944)
							{
								if (this.$$switch$7488$41567 == 1)
								{
									if (262537 - 241806 != 20731)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (226915 - 229145 != -2230)
									{
										continue;
									}
								}
								else if (this.$$switch$7488$41567 == 2)
								{
									if (156096 - 204769 == -48672)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (75322 - 211127 == -135804)
									{
										continue;
									}
								}
								else if (this.$$switch$7488$41567 == 3)
								{
									if (7312 - 267840 != -260528)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (246573 - 149704 != 96869)
									{
										continue;
									}
								}
								else if (this.$$switch$7488$41567 == 4)
								{
									if (101773 - 458489 == -356715)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (70487 - 406024 == -335536)
									{
										continue;
									}
								}
								else if (this.$$switch$7488$41567 == 5)
								{
									if (146706 - 270310 != -123604)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (112106 - 393332 == -281225)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (227777 - 478441 == -250663)
									{
										continue;
									}
								}
								this.$mGameGui$41568 = (GameGui)this.$self_$41569.GetComponent(typeof(GameGui));
								if (177600 - 382430 == -204830)
								{
									if (this.$mGameGui$41568)
									{
										if (113169 - 369412 == -256242)
										{
											continue;
										}
										this.$mGameGui$41568.close();
										if (266428 - 41432 == 224997)
										{
											continue;
										}
									}
									this.$self_$41569.SendMessage("fadeOut");
									if (285232 - 453934 != -168701)
									{
										goto Block_19;
									}
								}
							}
						}
					}
				}
				Block_16:
				goto IL_363;
				Block_19:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600923D RID: 37437 RVA: 0x0118A36C File Offset: 0x0118856C
			internal static bool NnnUBeVWbK9XHC1IiMWD()
			{
				return true;
			}

			// Token: 0x0600923E RID: 37438 RVA: 0x0118A370 File Offset: 0x01188570
			internal static bool MUq8txVWu97enjlSquwW()
			{
				return false;
			}

			// Token: 0x040089C4 RID: 35268
			internal int $$switch$7488$41567;

			// Token: 0x040089C5 RID: 35269
			internal GameGui $mGameGui$41568;

			// Token: 0x040089C6 RID: 35270
			internal M904_BattleWithZerbiras $self_$41569;
		}
	}
}
