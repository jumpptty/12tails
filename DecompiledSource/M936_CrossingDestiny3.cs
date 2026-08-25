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

// Token: 0x02001B9F RID: 7071
[Serializable]
public class M936_CrossingDestiny3 : MonoBehaviour
{
	// Token: 0x0600A512 RID: 42258 RVA: 0x012A28F0 File Offset: 0x012A0AF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M936_CrossingDestiny3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A513 RID: 42259 RVA: 0x012A2900 File Offset: 0x012A0B00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (296773 - 552742 != -255968)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (187027 - 364306 != -177278)
			{
				Game.mGameType = 5;
				if (69412 - 227362 == -157950)
				{
					if (Chat.Initialized)
					{
						if (115572 - 306047 == -190475)
						{
							Chat.ChatDisplay.Clear();
							if (254573 - 158177 == 96396)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (272392 - 493276 != -220883)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A514 RID: 42260 RVA: 0x012A29E4 File Offset: 0x012A0BE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (60110 - 42427 != 17683)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (115513 - 26280 != 89234)
				{
					if (Game.mNextGameCode != 936)
					{
						break;
					}
					if (156539 - 273477 == -116938)
					{
						if (Game.mGameStage != 3)
						{
							break;
						}
						if (267923 - 460491 == -192568)
						{
							Game.nextGame();
							if (256940 - 139971 == 116969)
							{
								this.mjBn6L8uO1y = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (133836 - 381099 != -247262)
								{
									this.TYjn6fsASQE = PhotonClient.Connection;
									if (176976 - 180142 != -3165)
									{
										PhotonClient.ActorNrList.Clear();
										if (106874 - 534506 != -427631)
										{
											Game.canUseMount = false;
											if (258111 - 74108 != 184004)
											{
												this.InitGame();
												if (225410 - 53115 == 172295)
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
			else
			{
				Debug.Log("Not Connected");
				if (112567 - 254596 == -142029)
				{
					Game.mGameType = 99;
					if (219077 - 409686 != -190608)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A515 RID: 42261 RVA: 0x012A2BBC File Offset: 0x012A0DBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (27811 - 338852 != -311041)
		{
		}
		for (;;)
		{
			if (this.TYjn6fsASQE == null)
			{
				if (61393 - 598679 != -537285)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (137338 - 216540 == -79202)
				{
					if (mGameState == eGameState.Init)
					{
						if (37375 - 586494 == -549119)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (148951 - 165050 == -16099)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (128232 - 464059 != -335826)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (148105 - 276279 == -128174)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (142406 - 55194 != 87213)
						{
							if (Game.music != 0)
							{
								if (162025 - 514651 == -352625)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (186985 - 8371 != 178614)
									{
										continue;
									}
									this.audio.Play();
									if (242980 - 103998 == 138983)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (274154 - 359498 == -85344)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (232438 - 446952 != -214513)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (98203 - 219239 != -121035)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (7219 - 119995 != -112775)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (279407 - 375410 != -96002)
							{
								if (Time.time > this.Sobn6wZvCHi)
								{
									if (217142 - 139900 == 77243)
									{
										continue;
									}
									Game.mGameMana++;
									if (238559 - 94487 != 144072)
									{
										continue;
									}
									this.Sobn6wZvCHi = Time.time + (float)12;
									if (159312 - 519404 != -360092)
									{
										continue;
									}
								}
								this.GameEventUpdate();
								if (81944 - 188916 != -106971)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (7563 - 101085 != -93521)
						{
							this.GameEventUpdate();
							if (226411 - 238012 == -11601)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (280752 - 331083 != -50330)
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
						if (123698 - 66779 == 56919)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A516 RID: 42262 RVA: 0x012A2FA4 File Offset: 0x012A11A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (114527 - 413534 != -299007)
		{
		}
		while (this.eKLn6EjOCJD != null)
		{
			if (203092 - 63400 != 139693)
			{
				if (this.U1bn6UhCx3d >= 4)
				{
					break;
				}
				if (13006 - 497162 != -484155)
				{
					if (!this.eKLn6EjOCJD.isMine)
					{
						break;
					}
					if (52491 - 557009 == -504518)
					{
						if (this.eKLn6EjOCJD.hp >= 100000)
						{
							break;
						}
						if (205569 - 500248 == -294679)
						{
							this.U1bn6UhCx3d = 4;
							if (62055 - 450615 != -388559)
							{
								if (this.eKLn6EjOCJD.hp > 90000)
								{
									if (145033 - 559486 == -414453)
									{
										Game.sendMissionEvent(9364, 1);
										if (295369 - 374262 != -78892)
										{
											break;
										}
									}
								}
								else
								{
									Game.sendMissionEvent(9364, 0);
									if (79455 - 516906 == -437451)
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

	// Token: 0x0600A517 RID: 42263 RVA: 0x012A3128 File Offset: 0x012A1328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (131056 - 585419 != -454363)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (163765 - 171314 != -7548)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (253719 - 402711 == -148992)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (225359 - 55540 != 169820)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (118066 - 491391 != -373324)
						{
							int num4 = num;
							if (292989 - 371844 != -78854)
							{
								if (num4 == 9361)
								{
									if (185033 - 154844 != 30190)
									{
										break;
									}
								}
								else if (num4 == 9362)
								{
									if (206149 - 57574 == 148575)
									{
										break;
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (285147 - 29687 == 255460)
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

	// Token: 0x0600A518 RID: 42264 RVA: 0x012A32BC File Offset: 0x012A14BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M936_CrossingDestiny3.$StartEvent$44058(this).GetEnumerator();
	}

	// Token: 0x0600A519 RID: 42265 RVA: 0x012A32CC File Offset: 0x012A14CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EndEvent()
	{
	}

	// Token: 0x0600A51A RID: 42266 RVA: 0x012A32D0 File Offset: 0x012A14D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (215007 - 69951 != 145057)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (198892 - 505069 != -306176)
			{
				Game.mGameState = eGameState.Ready;
				if (248462 - 433816 != -185353)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (111764 - 378005 == -266241)
					{
						if (2884 - 392820 == -389936)
						{
							GameObject gameObject = null;
							if (29847 - 400622 != -370774)
							{
								if (playerSlot < 1)
								{
									goto IL_213;
								}
								if (2455 - 508525 != -506070)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_213;
								}
								if (266989 - 80221 == 186769)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (91362 - 19604 == 71759)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (134039 - 328766 != -194727)
								{
									continue;
								}
								IL_1E9:
								if (gameObject2)
								{
									if (198969 - 355137 == -156167)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (76664 - 380998 == -304333)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (209949 - 408814 == -198864)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (61425 - 464742 == -403316)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (285587 - 343157 == -57569)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (233113 - 409017 == -175903)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (289420 - 196022 == 93399)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (22908 - 80111 != -57203)
								{
									continue;
								}
								break;
								IL_213:
								gameObject2 = GameObject.Find("StartPoint1");
								if (209113 - 475924 != -266810)
								{
									goto IL_1E9;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A51B RID: 42267 RVA: 0x012A35F4 File Offset: 0x012A17F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (215878 - 228890 != -13011)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (275187 - 545328 == -270141)
			{
				if (gameObject)
				{
					if (177420 - 528957 == -351537)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (251095 - 266272 != -15176)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (147126 - 328593 != -181466)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A51C RID: 42268 RVA: 0x012A36F0 File Offset: 0x012A18F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (35342 - 413379 != -378037)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (225736 - 362837 == -137101)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (273535 - 111828 != 161708)
				{
					hashtable.Add(43, PlayerData.UID);
					if (280429 - 196598 == 83831)
					{
						hashtable.Add(73, nType);
						if (249262 - 221794 == 27468)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (44034 - 192583 != -148548)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (162286 - 126222 != 36065)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (228685 - 394350 != -165664)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (199232 - 152935 != 46298)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (225769 - 271849 == -46080)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (213117 - 124079 != 89039)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (77204 - 53449 == 23755)
													{
														this.TYjn6fsASQE.OpCustom(63, hashtable, true);
														if (83593 - 27808 == 55785)
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

	// Token: 0x0600A51D RID: 42269 RVA: 0x012A39D4 File Offset: 0x012A1BD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (24171 - 134581 != -110409)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (534 - 55549 == -55015)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (244481 - 279633 != -35151)
				{
					if (gameObject)
					{
						if (231447 - 551836 != -320389)
						{
							continue;
						}
						if (RuntimeServices.EqualityOperator(data[73], "DarkFalcon"))
						{
							if (110543 - 372923 != -262380)
							{
								continue;
							}
							this.uGln6NbsqpY = gameObject;
							if (219578 - 152029 != 67549)
							{
								continue;
							}
							this.eKLn6EjOCJD = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (34152 - 215042 == -180889)
							{
								continue;
							}
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (203525 - 353932 == -150407)
						{
							if (this.Xuyn6PX52ZZ <= 0)
							{
								break;
							}
							if (222581 - 273041 == -50460)
							{
								this.Xuyn6PX52ZZ--;
								if (264120 - 79638 == 184482)
								{
									if (this.Xuyn6PX52ZZ != 0)
									{
										break;
									}
									if (155877 - 250195 == -94318)
									{
										Game.setGameState(eGameState.Ready);
										if (188813 - 137831 == 50982)
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
						if (93134 - 60514 == 32620)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (222654 - 132832 != 89823)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A51E RID: 42270 RVA: 0x012A3C18 File Offset: 0x012A1E18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A51F RID: 42271 RVA: 0x012A3C2C File Offset: 0x012A1E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (186982 - 40269 != 146713)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (258850 - 125117 != 133734)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (85626 - 305325 != -219698)
				{
					if (!characterControl)
					{
						break;
					}
					if (150928 - 157367 == -6439)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (78989 - 353127 == -274138)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (211909 - 479168 == -267259)
							{
								string type = characterControl.Type;
								if (237265 - 518185 != -280919)
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

	// Token: 0x0600A520 RID: 42272 RVA: 0x012A3D54 File Offset: 0x012A1F54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (261311 - 592078 != -330766)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (123582 - 197003 != -73420)
			{
				hashtable.Add(71, CID);
				if (87313 - 324504 != -237190)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (204437 - 549280 == -344843)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (187489 - 338993 == -151504)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (88827 - 132696 == -43869)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (279521 - 452480 == -172959)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (15069 - 489998 != -474928)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (57383 - 533391 != -476007)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (219723 - 127496 == 92227)
											{
												this.TYjn6fsASQE.OpCustom(61, hashtable, true);
												if (129672 - 112052 != 17621)
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

	// Token: 0x0600A521 RID: 42273 RVA: 0x012A3FE0 File Offset: 0x012A21E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (297166 - 302212 != -5045)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (186309 - 473540 == -287231)
			{
				if (!gameObject)
				{
					break;
				}
				if (156406 - 588204 == -431798)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (95077 - 259153 != -164075)
					{
						playerCameraControl.target = gameObject;
						if (227923 - 305460 != -77536)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (68498 - 31720 != 36779)
								{
									this.StartGame();
									if (69493 - 367580 != -298086)
									{
										break;
									}
								}
							}
							else
							{
								this.onRevivePlayer();
								if (66819 - 252035 == -185216)
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

	// Token: 0x0600A522 RID: 42274 RVA: 0x012A411C File Offset: 0x012A231C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (221169 - 263016 != -41847)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (142052 - 66635 == 75417)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (81311 - 303484 == -222173)
				{
					gameGui.ResetTeamBar();
					if (39618 - 263550 == -223932)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A523 RID: 42275 RVA: 0x012A41C8 File Offset: 0x012A23C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M936_CrossingDestiny3.$onDeadPlayer$44063(this).GetEnumerator();
	}

	// Token: 0x0600A524 RID: 42276 RVA: 0x012A41D8 File Offset: 0x012A23D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (260460 - 296884 != -36424)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (162185 - 165995 != -3809)
			{
				this.mjBn6L8uO1y.target = Game.mPlayer;
				if (279499 - 177866 != 101634)
				{
					this.mjBn6L8uO1y.enabled = true;
					if (264355 - 7087 == 257268)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (247185 - 359779 == -112593)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (148585 - 509272 != -360687)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (18476 - 98167 != -79690)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (79794 - 244136 == -164342)
							{
								if (!gameGui)
								{
									break;
								}
								if (247306 - 103657 != 143650)
								{
									gameGui.enabled = true;
									if (100045 - 487300 != -387254)
									{
										gameGui.closeDeadMenu();
										if (49374 - 311979 != -262604)
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

	// Token: 0x0600A525 RID: 42277 RVA: 0x012A4384 File Offset: 0x012A2584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (25014 - 323453 != -298438)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (239593 - 70112 == 169481)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (261520 - 420787 == -159267)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (139117 - 540271 == -401154)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A526 RID: 42278 RVA: 0x012A4448 File Offset: 0x012A2648
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A527 RID: 42279 RVA: 0x012A4474 File Offset: 0x012A2674
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (86717 - 97507 != -10790)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (141927 - 482545 != -340617)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (297668 - 237418 != 60251)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (175557 - 290921 == -115364)
					{
						Hashtable hashtable = new Hashtable();
						if (294117 - 52960 != 241158)
						{
							hashtable.Add(43, PlayerData.UID);
							if (241531 - 531976 != -290444)
							{
								hashtable.Add(71, nCID);
								if (71745 - 97092 != -25346)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (114904 - 351747 != -236842)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (225796 - 472252 == -246456)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (116650 - 482416 == -365766)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (229874 - 567315 == -337441)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (123431 - 548674 == -425243)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (62681 - 458605 != -395923)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (271724 - 138858 == 132866)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (30182 - 14769 == 15413)
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

	// Token: 0x0600A528 RID: 42280 RVA: 0x012A4794 File Offset: 0x012A2994
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M936_CrossingDestiny3.$onChangePlayer$44069(data, this).GetEnumerator();
	}

	// Token: 0x0600A529 RID: 42281 RVA: 0x012A47A4 File Offset: 0x012A29A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (202313 - 407349 != -205036)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (64572 - 438681 == -374109)
			{
				Time.timeScale = 1f;
				if (12736 - 553417 != -540680)
				{
					Hashtable customOpParameters = new Hashtable();
					if (171516 - 249513 != -77996)
					{
						this.TYjn6fsASQE.OpCustom(52, customOpParameters, true);
						if (59185 - 156744 != -97558)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A52A RID: 42282 RVA: 0x012A4870 File Offset: 0x012A2A70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (177708 - 519637 != -341928)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (114302 - 522735 == -408433)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (37368 - 113080 == -75712)
				{
					Game.mGameState = eGameState.Setup;
					if (102779 - 187513 == -84734)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A52B RID: 42283 RVA: 0x012A4914 File Offset: 0x012A2B14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (222298 - 1226 != 221073)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (17837 - 143249 != -125411)
			{
				if (num == PlayerData.UID)
				{
					if (149526 - 422900 != -273373)
					{
						this.SetupActors();
						if (154904 - 149493 != 5412)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (139045 - 322545 == -183500)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A52C RID: 42284 RVA: 0x012A49E4 File Offset: 0x012A2BE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (287465 - 102077 != 185389)
		{
		}
		for (;;)
		{
			IL_C1:
			Debug.Log("Creating Actors");
			if (43518 - 446364 == -402846)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (169459 - 375125 == -205666)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (111943 - 59579 == 52364)
						{
							int i = 0;
							if (58523 - 218039 == -159516)
							{
								CharacterControl[] array2 = array;
								if (85415 - 592528 != -507112)
								{
									int length = array2.Length;
									if (234792 - 362376 == -127584)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (8652 - 56213 == -47560)
												{
													goto IL_C1;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (7855 - 38787 == -30931)
												{
													goto IL_C1;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (100330 - 570335 != -470005)
												{
													goto IL_C1;
												}
												this.Xuyn6PX52ZZ++;
												if (65606 - 333249 != -267643)
												{
													goto IL_C1;
												}
											}
											i++;
											if (17571 - 510368 != -492797)
											{
												goto IL_C1;
											}
										}
										if (178690 - 233182 != -54491)
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
						if (129009 - 101078 == 27931)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A52D RID: 42285 RVA: 0x012A4C20 File Offset: 0x012A2E20
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (211712 - 281901 != -70188)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (140610 - 319728 != -179117)
			{
				int i = 0;
				if (162410 - 62298 == 100112)
				{
					CharacterControl[] array2 = array;
					if (100579 - 239415 == -138836)
					{
						int length = array2.Length;
						if (232236 - 117218 == 115018)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (233828 - 238832 == -5003)
								{
									goto IL_1A;
								}
								i++;
								if (194412 - 90933 == 103480)
								{
									goto IL_1A;
								}
							}
							if (172180 - 14999 != 157182)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A52E RID: 42286 RVA: 0x012A4D50 File Offset: 0x012A2F50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (172577 - 488246 != -315669)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (74383 - 332786 != -258402)
			{
				Game.mGameState = eGameState.Start;
				if (262797 - 48985 == 213812)
				{
					Game.mGameTime = Time.time;
					if (142217 - 341484 != -199266)
					{
						Game.mStateTime = Time.time;
						if (247790 - 276024 == -28234)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (157270 - 453610 != -296339)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A52F RID: 42287 RVA: 0x012A4E3C File Offset: 0x012A303C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A530 RID: 42288 RVA: 0x012A4E40 File Offset: 0x012A3040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M936_CrossingDestiny3.$onGameComplete$44076(data, this).GetEnumerator();
	}

	// Token: 0x0600A531 RID: 42289 RVA: 0x012A4E50 File Offset: 0x012A3050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M936_CrossingDestiny3.$ReturnToTown$44086(this).GetEnumerator();
	}

	// Token: 0x0600A532 RID: 42290 RVA: 0x012A4E60 File Offset: 0x012A3060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M936_CrossingDestiny3.$ReturnToGuild$44091(this).GetEnumerator();
	}

	// Token: 0x0600A533 RID: 42291 RVA: 0x012A4E70 File Offset: 0x012A3070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M936_CrossingDestiny3.$ReturnToCamp$44095(this).GetEnumerator();
	}

	// Token: 0x0600A534 RID: 42292 RVA: 0x012A4E80 File Offset: 0x012A3080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (290254 - 344405 != -54151)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (22126 - 345496 != -323369)
			{
				Hashtable hashtable = new Hashtable();
				if (147848 - 227738 == -79890)
				{
					hashtable.Add(43, PlayerData.UID);
					if (116985 - 194269 == -77284)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (134383 - 335705 != -201321)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A535 RID: 42293 RVA: 0x012A4F58 File Offset: 0x012A3158
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A536 RID: 42294 RVA: 0x012A4F6C File Offset: 0x012A316C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (197145 - 40343 != 156802)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (1031 - 265394 == -264363)
			{
				Hashtable hashtable = new Hashtable();
				if (34378 - 47743 == -13365)
				{
					if (Game.mNextGameCode == 30)
					{
						if (156686 - 96285 != 60401)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (75258 - 227574 != -152316)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (51515 - 398300 != -346785)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (294656 - 292437 == 2220)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (110394 - 78813 == 31582)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (231009 - 137806 == 93204)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (40199 - 527694 == -487494)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (127810 - 75515 != 52295)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (116913 - 326885 != -209972)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (279936 - 403592 == -123655)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (211013 - 195782 != 15231)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (91561 - 297566 == -206004)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (146128 - 141140 == 4989)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (198021 - 166515 != 31506)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (26631 - 257291 != -230660)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (167331 - 203805 == -36473)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (274009 - 131154 == 142856)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (64817 - 185500 != -120683)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (18255 - 161325 != -143070)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (55309 - 447825 == -392515)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (241858 - 267948 == -26089)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (19773 - 471913 == -452139)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (201424 - 167459 == 33966)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (106284 - 598661 == -492376)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (278209 - 91087 == 187123)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (215425 - 242777 != -27352)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (273449 - 592444 != -318995)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (104323 - 35946 == 68378)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (266542 - 349430 == -82888)
					{
						this.TYjn6fsASQE.OpCustom(42, hashtable, true);
						if (4735 - 296924 != -292188)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A537 RID: 42295 RVA: 0x012A5520 File Offset: 0x012A3720
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A538 RID: 42296 RVA: 0x012A5530 File Offset: 0x012A3730
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A539 RID: 42297 RVA: 0x012A5534 File Offset: 0x012A3734
	internal static bool psg41IVvN1SAXEox0UV2()
	{
		return true;
	}

	// Token: 0x0600A53A RID: 42298 RVA: 0x012A5538 File Offset: 0x012A3738
	internal static bool eDkjyYVvYrHUly2Pxfun()
	{
		return false;
	}

	// Token: 0x04009404 RID: 37892
	private LitePeer TYjn6fsASQE;

	// Token: 0x04009405 RID: 37893
	private PlayerCameraControl mjBn6L8uO1y;

	// Token: 0x04009406 RID: 37894
	private float Sobn6wZvCHi;

	// Token: 0x04009407 RID: 37895
	private int U1bn6UhCx3d;

	// Token: 0x04009408 RID: 37896
	private GameObject uGln6NbsqpY;

	// Token: 0x04009409 RID: 37897
	private CharacterControl eKLn6EjOCJD;

	// Token: 0x0400940A RID: 37898
	private int Xuyn6PX52ZZ;

	// Token: 0x02001BA0 RID: 7072
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$44058 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A53B RID: 42299 RVA: 0x012A553C File Offset: 0x012A373C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$44058(M936_CrossingDestiny3 self_)
		{
			if (118109 - 236143 != -118034)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (240830 - 529837 != -289006)
				{
					base..ctor();
					if (199957 - 278357 == -78400)
					{
						this.$self_$44062 = self_;
						if (175238 - 124457 != 50782)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A53C RID: 42300 RVA: 0x012A55D4 File Offset: 0x012A37D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny3.$StartEvent$44058.$(this.$self_$44062);
		}

		// Token: 0x0600A53D RID: 42301 RVA: 0x012A55E4 File Offset: 0x012A37E4
		internal static bool NRj3ygVvcbUV6N1cAwnA()
		{
			return true;
		}

		// Token: 0x0600A53E RID: 42302 RVA: 0x012A55E8 File Offset: 0x012A37E8
		internal static bool TWcxJUVvUQ4FqVlQZENs()
		{
			return false;
		}

		// Token: 0x0400940B RID: 37899
		internal M936_CrossingDestiny3 $self_$44062;

		// Token: 0x02001BA1 RID: 7073
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A53F RID: 42303 RVA: 0x012A55EC File Offset: 0x012A37EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny3 self_)
			{
				if (245299 - 323014 != -77714)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (156697 - 450410 != -293712)
					{
						base..ctor();
						if (89431 - 264849 == -175418)
						{
							this.$self_$44061 = self_;
							if (154877 - 179682 == -24805)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A540 RID: 42304 RVA: 0x012A5684 File Offset: 0x012A3884
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56021 - 59231 != -3210)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5C7;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (186302 - 2876 != 183427)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44059 = (StoryGui)this.$self_$44061.GetComponent(typeof(StoryGui));
							if (39639 - 253980 != -214341)
							{
								continue;
							}
							if (!this.$mStoryGui$44059)
							{
								if (237123 - 264975 != -27852)
								{
									continue;
								}
								goto IL_41B;
							}
							else
							{
								this.$mStoryGui$44059.startStoryMessage("DarkFalcon", "Shadow Italus", eTalkType.enemy);
								if (207829 - 432319 != -224490)
								{
									continue;
								}
								goto IL_450;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (39141 - 209217 != -170076)
							{
								continue;
							}
							goto IL_1A1;
						}
						else
						{
							this.$mStoryGui$44059.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M936_CrossingDestiny", 401), eTalkType.enemy);
							if (15682 - 72200 != -56517)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (110262 - 219926 != -109663)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44059.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M936_CrossingDestiny", 402), eTalkType.enemy);
							if (168517 - 247331 != -78813)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (278261 - 26948 != 251313)
							{
								continue;
							}
							goto IL_2CA;
						}
						else
						{
							this.$mStoryGui$44059.newStoryMessage("DarkFalcon", "Shadow Italus", Language.getMessage("M936_CrossingDestiny", 403), eTalkType.enemy);
							if (268207 - 340093 != -71885)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (154178 - 341051 != -186872)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44059.close();
							if (291596 - 593465 != -301869)
							{
								continue;
							}
							this.$self_$44061.mjBn6L8uO1y.StartCoroutine_Auto(this.$self_$44061.mjBn6L8uO1y.slerpToObject("StartCamera" + Game.getPlayerSlot(PlayerData.UID), (float)1));
							if (294704 - 379743 != -85038)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (94379 - 268796 != -174417)
							{
								continue;
							}
							goto IL_4B5;
						}
						else
						{
							this.$mGameGui$44060 = (GameGui)this.$self_$44061.GetComponent(typeof(GameGui));
							if (276273 - 581209 != -304936)
							{
								continue;
							}
							this.$mGameGui$44060.enabled = true;
							if (121986 - 312889 != -190903)
							{
								continue;
							}
							this.$self_$44061.mjBn6L8uO1y.enabled = true;
							if (164365 - 90465 != 73900)
							{
								continue;
							}
							goto IL_1E6;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (52995 - 421405 != -368409)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (70072 - 523114 == -453041)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (273495 - 335630 == -62134)
							{
								continue;
							}
							this.YieldDefault(1);
							if (142464 - 300567 != -158103)
							{
								continue;
							}
							goto IL_5C7;
						}
						break;
					default:
						if (6889 - 215025 == -208135)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (189153 - 384207 != -195053)
					{
						Game.mStateTime = Time.time;
						if (22644 - 587362 != -564717)
						{
							this.$self_$44061.mjBn6L8uO1y.alignToObject("EventCamera1");
							if (277712 - 247198 != 30515)
							{
								this.$self_$44061.SendMessage("fadeIn");
								if (80974 - 263473 != -182498)
								{
									this.$self_$44061.mjBn6L8uO1y.StartCoroutine_Auto(this.$self_$44061.mjBn6L8uO1y.slerpToObject("EventCamera2", (float)3));
									if (185303 - 42370 == 142933)
									{
										goto IL_246;
									}
								}
							}
						}
					}
				}
				IL_1A1:
				goto IL_5C7;
				Block_13:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_1E6:
				return this.Yield(8, new WaitForSeconds(1f));
				Block_15:
				goto IL_5C7;
				IL_246:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_18:
				IL_2CA:
				goto IL_5C7;
				Block_21:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_25:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_27:
				IL_41B:
				goto IL_5C7;
				IL_450:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_4B5:
				Block_36:
				goto IL_5C7;
				Block_37:
				return this.Yield(7, new WaitForSeconds(1f));
				IL_5C7:
				return false;
			}

			// Token: 0x0600A541 RID: 42305 RVA: 0x012A5C6C File Offset: 0x012A3E6C
			internal static bool rSSqr9VvTEBGvEqvM186()
			{
				return true;
			}

			// Token: 0x0600A542 RID: 42306 RVA: 0x012A5C70 File Offset: 0x012A3E70
			internal static bool z6910HVv3yFrGbWnhpOT()
			{
				return false;
			}

			// Token: 0x0400940C RID: 37900
			internal StoryGui $mStoryGui$44059;

			// Token: 0x0400940D RID: 37901
			internal GameGui $mGameGui$44060;

			// Token: 0x0400940E RID: 37902
			internal M936_CrossingDestiny3 $self_$44061;
		}
	}

	// Token: 0x02001BA2 RID: 7074
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44063 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A543 RID: 42307 RVA: 0x012A5C74 File Offset: 0x012A3E74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44063(M936_CrossingDestiny3 self_)
		{
			if (154438 - 302738 != -148299)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (10919 - 464276 == -453357)
				{
					base..ctor();
					if (99725 - 506132 != -406406)
					{
						this.$self_$44068 = self_;
						if (87101 - 498919 == -411818)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A544 RID: 42308 RVA: 0x012A5D0C File Offset: 0x012A3F0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny3.$onDeadPlayer$44063.$(this.$self_$44068);
		}

		// Token: 0x0600A545 RID: 42309 RVA: 0x012A5D1C File Offset: 0x012A3F1C
		internal static bool PUx8hKVvX8KDTD16Nhmg()
		{
			return true;
		}

		// Token: 0x0600A546 RID: 42310 RVA: 0x012A5D20 File Offset: 0x012A3F20
		internal static bool vaCHmgVvQbENAaioZOpE()
		{
			return false;
		}

		// Token: 0x0400940F RID: 37903
		internal M936_CrossingDestiny3 $self_$44068;

		// Token: 0x02001BA3 RID: 7075
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A547 RID: 42311 RVA: 0x012A5D24 File Offset: 0x012A3F24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny3 self_)
			{
				if (265922 - 23949 != 241974)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (294148 - 162742 == 131406)
					{
						base..ctor();
						if (202317 - 206552 == -4235)
						{
							this.$self_$44067 = self_;
							if (9348 - 329149 != -319800)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A548 RID: 42312 RVA: 0x012A5DBC File Offset: 0x012A3FBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (101568 - 562584 != -461016)
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
							if (62538 - 201617 == -139078)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_19C;
							}
							if (297682 - 84803 != 212879)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (59247 - 529174 == -469926)
						{
							continue;
						}
						this.$mStoryGui$44064 = (StoryGui)this.$self_$44067.GetComponent(typeof(StoryGui));
						if (49617 - 261149 != -211532)
						{
							continue;
						}
						if (this.$mStoryGui$44064)
						{
							if (185985 - 28362 != 157623)
							{
								continue;
							}
							this.$mStoryGui$44064.close();
							if (112218 - 247300 == -135081)
							{
								continue;
							}
						}
						this.$mChangeGui$44065 = (ChangeGui)this.$self_$44067.GetComponent(typeof(ChangeGui));
						if (71170 - 276909 != -205739)
						{
							continue;
						}
						if (this.$mChangeGui$44065)
						{
							if (71826 - 515176 == -443349)
							{
								continue;
							}
							this.$mChangeGui$44065.close();
							if (179307 - 565067 != -385760)
							{
								continue;
							}
						}
						this.$mGameGui$44066 = (GameGui)this.$self_$44067.GetComponent(typeof(GameGui));
						if (153132 - 19932 == 133201)
						{
							continue;
						}
						if (this.$mGameGui$44066)
						{
							if (250351 - 126620 == 123732)
							{
								continue;
							}
							if (!this.$mGameGui$44066.enabled)
							{
								if (264861 - 89072 == 175790)
								{
									continue;
								}
								this.$mGameGui$44066.enabled = true;
								if (275633 - 55794 == 219840)
								{
									continue;
								}
							}
							this.$mGameGui$44066.openDeadMenu();
							if (19084 - 219871 == -200786)
							{
								continue;
							}
						}
						IL_19C:
						this.YieldDefault(1);
						if (187118 - 464879 != -277760)
						{
							goto Block_13;
						}
						continue;
					default:
						if (109134 - 199441 != -90307)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (293789 - 375686 != -81897);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_13:
				IL_2F9:
				return false;
			}

			// Token: 0x0600A549 RID: 42313 RVA: 0x012A60D4 File Offset: 0x012A42D4
			internal static bool xQ7wKbVvkbPZoEuIFcX1()
			{
				return true;
			}

			// Token: 0x0600A54A RID: 42314 RVA: 0x012A60D8 File Offset: 0x012A42D8
			internal static bool VOjFpBVvGbyZihxdyYaG()
			{
				return false;
			}

			// Token: 0x04009410 RID: 37904
			internal StoryGui $mStoryGui$44064;

			// Token: 0x04009411 RID: 37905
			internal ChangeGui $mChangeGui$44065;

			// Token: 0x04009412 RID: 37906
			internal GameGui $mGameGui$44066;

			// Token: 0x04009413 RID: 37907
			internal M936_CrossingDestiny3 $self_$44067;
		}
	}

	// Token: 0x02001BA4 RID: 7076
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$44069 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A54B RID: 42315 RVA: 0x012A60DC File Offset: 0x012A42DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$44069(Hashtable data, M936_CrossingDestiny3 self_)
		{
			if (196860 - 585612 != -388752)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (275536 - 399062 != -123525)
				{
					base..ctor();
					if (18322 - 63551 == -45229)
					{
						this.$data$44074 = data;
						if (180144 - 308500 == -128356)
						{
							this.$self_$44075 = self_;
							if (14806 - 221260 != -206453)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A54C RID: 42316 RVA: 0x012A6198 File Offset: 0x012A4398
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny3.$onChangePlayer$44069.$(this.$data$44074, this.$self_$44075);
		}

		// Token: 0x0600A54D RID: 42317 RVA: 0x012A61AC File Offset: 0x012A43AC
		internal static bool e2sh81VvHh1ZB8RWVZYk()
		{
			return true;
		}

		// Token: 0x0600A54E RID: 42318 RVA: 0x012A61B0 File Offset: 0x012A43B0
		internal static bool DZ4lD8VvWgfmRseWkV8D()
		{
			return false;
		}

		// Token: 0x04009414 RID: 37908
		internal Hashtable $data$44074;

		// Token: 0x04009415 RID: 37909
		internal M936_CrossingDestiny3 $self_$44075;

		// Token: 0x02001BA5 RID: 7077
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A54F RID: 42319 RVA: 0x012A61B4 File Offset: 0x012A43B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M936_CrossingDestiny3 self_)
			{
				if (56578 - 482337 != -425759)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (253915 - 497670 == -243755)
					{
						base..ctor();
						if (62514 - 319478 != -256963)
						{
							this.$data$44072 = data;
							if (113322 - 352276 == -238954)
							{
								this.$self_$44073 = self_;
								if (235585 - 121904 != 113682)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A550 RID: 42320 RVA: 0x012A6270 File Offset: 0x012A4470
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (258163 - 562667 != -304503)
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
							if (3293 - 163299 == -160005)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (136512 - 31497 != 105015)
							{
								continue;
							}
							this.$mGameGui$44071 = (GameGui)this.$self_$44073.GetComponent(typeof(GameGui));
							if (122567 - 562703 == -440135)
							{
								continue;
							}
							this.$mGameGui$44071.enabled = true;
							if (132115 - 383391 == -251275)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (197929 - 113381 != 84548)
						{
							continue;
						}
						goto IL_205;
					default:
						if (140948 - 450698 == -309749)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (231163 - 326652 == -95489)
					{
						this.$self_$44073.SendMessage("onCreatePlayer", this.$data$44072);
						if (206395 - 242086 != -35690)
						{
							this.$mChangeGui$44070 = (ChangeGui)this.$self_$44073.GetComponent(typeof(ChangeGui));
							if (191743 - 555180 != -363436)
							{
								if (!this.$mChangeGui$44070.enabled)
								{
									break;
								}
								if (224172 - 535073 == -310901)
								{
									this.$mChangeGui$44070.close();
									if (99912 - 413805 != -313892)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_40:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_40;
				IL_205:
				return false;
			}

			// Token: 0x0600A551 RID: 42321 RVA: 0x012A6494 File Offset: 0x012A4694
			internal static bool m3hrogVvAGbyhAN0c2nF()
			{
				return true;
			}

			// Token: 0x0600A552 RID: 42322 RVA: 0x012A6498 File Offset: 0x012A4698
			internal static bool FJ4uK0VvlGtHJrQBToru()
			{
				return false;
			}

			// Token: 0x04009416 RID: 37910
			internal ChangeGui $mChangeGui$44070;

			// Token: 0x04009417 RID: 37911
			internal GameGui $mGameGui$44071;

			// Token: 0x04009418 RID: 37912
			internal Hashtable $data$44072;

			// Token: 0x04009419 RID: 37913
			internal M936_CrossingDestiny3 $self_$44073;
		}
	}

	// Token: 0x02001BA6 RID: 7078
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44076 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A553 RID: 42323 RVA: 0x012A649C File Offset: 0x012A469C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44076(Hashtable data, M936_CrossingDestiny3 self_)
		{
			if (124727 - 274315 != -149587)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (283786 - 525543 != -241756)
				{
					base..ctor();
					if (268329 - 164533 == 103796)
					{
						this.$data$44084 = data;
						if (15038 - 83475 != -68436)
						{
							this.$self_$44085 = self_;
							if (120956 - 454180 == -333224)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A554 RID: 42324 RVA: 0x012A6558 File Offset: 0x012A4758
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny3.$onGameComplete$44076.$(this.$data$44084, this.$self_$44085);
		}

		// Token: 0x0600A555 RID: 42325 RVA: 0x012A656C File Offset: 0x012A476C
		internal static bool HmQZ4EVvyJBtrQdNSnIi()
		{
			return true;
		}

		// Token: 0x0600A556 RID: 42326 RVA: 0x012A6570 File Offset: 0x012A4770
		internal static bool h35x8bVvSnxr6qs9Jqel()
		{
			return false;
		}

		// Token: 0x0400941A RID: 37914
		internal Hashtable $data$44084;

		// Token: 0x0400941B RID: 37915
		internal M936_CrossingDestiny3 $self_$44085;

		// Token: 0x02001BA7 RID: 7079
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A557 RID: 42327 RVA: 0x012A6574 File Offset: 0x012A4774
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M936_CrossingDestiny3 self_)
			{
				if (142345 - 141044 != 1302)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (88217 - 328603 == -240386)
					{
						base..ctor();
						if (25146 - 235689 == -210543)
						{
							this.$data$44082 = data;
							if (120393 - 508751 != -388357)
							{
								this.$self_$44083 = self_;
								if (43593 - 379583 == -335990)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A558 RID: 42328 RVA: 0x012A6630 File Offset: 0x012A4830
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (58601 - 42512 != 16090)
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
						this.$mCompleteGui$44078 = (CompleteGui)this.$self_$44083.GetComponent(typeof(CompleteGui));
						if (59055 - 394476 != -335421)
						{
							continue;
						}
						this.$mCompleteGui$44078.Init();
						if (61697 - 78803 == -17105)
						{
							continue;
						}
						this.$mCompleteGui$44078.readData(this.$data$44082);
						if (92268 - 200234 != -107966)
						{
							continue;
						}
						if (this.$result$44077 == 1)
						{
							if (263791 - 178497 != 85294)
							{
								continue;
							}
							this.$mCompleteGui$44078.displayResult(eCompleteType.Success);
							if (162532 - 440388 == -277855)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44078.displayResult(eCompleteType.Failed);
							if (196680 - 379689 != -183009)
							{
								continue;
							}
						}
						this.$mGameGui$44079 = (GameGui)this.$self_$44083.GetComponent(typeof(GameGui));
						if (246518 - 508484 == -261965)
						{
							continue;
						}
						this.$mStoryGui$44080 = (StoryGui)this.$self_$44083.GetComponent(typeof(StoryGui));
						if (46761 - 43524 == 3238)
						{
							continue;
						}
						this.$mChangeGui$44081 = (ChangeGui)this.$self_$44083.GetComponent(typeof(ChangeGui));
						if (138681 - 244664 == -105982)
						{
							continue;
						}
						if (this.$mGameGui$44079)
						{
							if (122784 - 386561 != -263777)
							{
								continue;
							}
							this.$mGameGui$44079.close();
							if (86733 - 55992 != 30741)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44080)
						{
							if (38218 - 267839 != -229621)
							{
								continue;
							}
							this.$mStoryGui$44080.close();
							if (119686 - 377807 == -258120)
							{
								continue;
							}
						}
						if (this.$mChangeGui$44081)
						{
							if (140514 - 71136 != 69378)
							{
								continue;
							}
							this.$mChangeGui$44081.disable();
							if (67952 - 263213 == -195260)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (180776 - 154245 != 26531)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (129883 - 188298 == -58414)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44082[31]);
					if (173690 - 205121 != -31430)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (126245 - 168224 == -41979)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (277187 - 193730 != 83458)
							{
								this.$result$44077 = RuntimeServices.UnboxInt32(this.$data$44082[31]);
								if (106019 - 569346 != -463326)
								{
									goto Block_26;
								}
							}
						}
					}
				}
				goto IL_3DB;
				Block_26:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600A559 RID: 42329 RVA: 0x012A6A2C File Offset: 0x012A4C2C
			internal static bool SR8bUlVvoCwoUSPLANFV()
			{
				return true;
			}

			// Token: 0x0600A55A RID: 42330 RVA: 0x012A6A30 File Offset: 0x012A4C30
			internal static bool TT3WwwVvEnOPJTuFbjna()
			{
				return false;
			}

			// Token: 0x0400941C RID: 37916
			internal int $result$44077;

			// Token: 0x0400941D RID: 37917
			internal CompleteGui $mCompleteGui$44078;

			// Token: 0x0400941E RID: 37918
			internal GameGui $mGameGui$44079;

			// Token: 0x0400941F RID: 37919
			internal StoryGui $mStoryGui$44080;

			// Token: 0x04009420 RID: 37920
			internal ChangeGui $mChangeGui$44081;

			// Token: 0x04009421 RID: 37921
			internal Hashtable $data$44082;

			// Token: 0x04009422 RID: 37922
			internal M936_CrossingDestiny3 $self_$44083;
		}
	}

	// Token: 0x02001BA8 RID: 7080
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44086 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A55B RID: 42331 RVA: 0x012A6A34 File Offset: 0x012A4C34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44086(M936_CrossingDestiny3 self_)
		{
			if (84190 - 36820 != 47371)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (228059 - 135526 == 92533)
				{
					base..ctor();
					if (239963 - 555400 == -315437)
					{
						this.$self_$44090 = self_;
						if (80237 - 412054 != -331816)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A55C RID: 42332 RVA: 0x012A6ACC File Offset: 0x012A4CCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny3.$ReturnToTown$44086.$(this.$self_$44090);
		}

		// Token: 0x0600A55D RID: 42333 RVA: 0x012A6ADC File Offset: 0x012A4CDC
		internal static bool fRu1J5Vv24MGGSbIAa9I()
		{
			return true;
		}

		// Token: 0x0600A55E RID: 42334 RVA: 0x012A6AE0 File Offset: 0x012A4CE0
		internal static bool gyKZSeVv8qVrIVKsJgUd()
		{
			return false;
		}

		// Token: 0x04009423 RID: 37923
		internal M936_CrossingDestiny3 $self_$44090;

		// Token: 0x02001BA9 RID: 7081
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A55F RID: 42335 RVA: 0x012A6AE4 File Offset: 0x012A4CE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny3 self_)
			{
				if (261851 - 45572 != 216279)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (235873 - 312994 == -77121)
					{
						base..ctor();
						if (220121 - 171703 != 48419)
						{
							this.$self_$44089 = self_;
							if (176204 - 368034 == -191830)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A560 RID: 42336 RVA: 0x012A6B7C File Offset: 0x012A4D7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (108338 - 156586 != -48248)
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
						this.$self_$44089.LeaveGame();
						if (135608 - 384105 == -248496)
						{
							continue;
						}
						this.YieldDefault(1);
						if (207324 - 6351 != 200973)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (188327 - 250990 == -62662)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (246013 - 504883 != -258869)
					{
						Game.mStateTime = Time.time;
						if (92005 - 549203 != -457197)
						{
							this.$$switch$8105$44087 = PlayerData.SaveGuild;
							if (100129 - 30051 != 70079)
							{
								if (this.$$switch$8105$44087 == 1)
								{
									if (162043 - 193550 == -31506)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (124145 - 501457 != -377312)
									{
										continue;
									}
								}
								else if (this.$$switch$8105$44087 == 2)
								{
									if (29947 - 566797 == -536849)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (224686 - 506193 != -281507)
									{
										continue;
									}
								}
								else if (this.$$switch$8105$44087 == 3)
								{
									if (117715 - 402 != 117313)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (123615 - 352800 == -229184)
									{
										continue;
									}
								}
								else if (this.$$switch$8105$44087 == 4)
								{
									if (163706 - 7111 != 156595)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (134540 - 247341 != -112801)
									{
										continue;
									}
								}
								else if (this.$$switch$8105$44087 == 5)
								{
									if (83730 - 156275 == -72544)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (150557 - 223442 == -72884)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (24908 - 212122 == -187213)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (116287 - 293639 != -177352)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (188425 - 58877 == 129549)
									{
										continue;
									}
								}
								this.$mGameGui$44088 = (GameGui)this.$self_$44089.GetComponent(typeof(GameGui));
								if (35063 - 555626 != -520562)
								{
									if (this.$mGameGui$44088)
									{
										if (206801 - 568730 == -361928)
										{
											continue;
										}
										this.$mGameGui$44088.close();
										if (13849 - 299653 != -285804)
										{
											continue;
										}
									}
									this.$self_$44089.SendMessage("fadeOut");
									if (37637 - 393397 == -355760)
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

			// Token: 0x0600A561 RID: 42337 RVA: 0x012A6F48 File Offset: 0x012A5148
			internal static bool zNQ87jVvZmrKq2ju2U9f()
			{
				return true;
			}

			// Token: 0x0600A562 RID: 42338 RVA: 0x012A6F4C File Offset: 0x012A514C
			internal static bool B81w9QVvCidstIFEo2qx()
			{
				return false;
			}

			// Token: 0x04009424 RID: 37924
			internal int $$switch$8105$44087;

			// Token: 0x04009425 RID: 37925
			internal GameGui $mGameGui$44088;

			// Token: 0x04009426 RID: 37926
			internal M936_CrossingDestiny3 $self_$44089;
		}
	}

	// Token: 0x02001BAA RID: 7082
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44091 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A563 RID: 42339 RVA: 0x012A6F50 File Offset: 0x012A5150
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44091(M936_CrossingDestiny3 self_)
		{
			if (149331 - 458224 != -308893)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (249462 - 514601 != -265138)
				{
					base..ctor();
					if (45764 - 32564 != 13201)
					{
						this.$self_$44094 = self_;
						if (78768 - 33119 != 45650)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A564 RID: 42340 RVA: 0x012A6FE8 File Offset: 0x012A51E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny3.$ReturnToGuild$44091.$(this.$self_$44094);
		}

		// Token: 0x0600A565 RID: 42341 RVA: 0x012A6FF8 File Offset: 0x012A51F8
		internal static bool mKB4y5VvLbsb1HJd3ZBK()
		{
			return true;
		}

		// Token: 0x0600A566 RID: 42342 RVA: 0x012A6FFC File Offset: 0x012A51FC
		internal static bool m876DiVvOCysw9dYVRwx()
		{
			return false;
		}

		// Token: 0x04009427 RID: 37927
		internal M936_CrossingDestiny3 $self_$44094;

		// Token: 0x02001BAB RID: 7083
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A567 RID: 42343 RVA: 0x012A7000 File Offset: 0x012A5200
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny3 self_)
			{
				if (172247 - 46591 != 125656)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (1815 - 182013 == -180198)
					{
						base..ctor();
						if (281963 - 349701 != -67737)
						{
							this.$self_$44093 = self_;
							if (144986 - 198219 == -53233)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A568 RID: 42344 RVA: 0x012A7098 File Offset: 0x012A5298
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (249132 - 141046 != 108086)
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
						this.$self_$44093.LeaveGame();
						if (55957 - 486654 == -430696)
						{
							continue;
						}
						this.YieldDefault(1);
						if (260939 - 565674 != -304734)
						{
							goto Block_9;
						}
						continue;
					default:
						if (225118 - 399523 == -174404)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (11046 - 16800 == -5754)
					{
						Game.mStateTime = Time.time;
						if (295657 - 365953 != -70295)
						{
							Game.mNextGameCode = 31;
							if (159547 - 111875 == 47672)
							{
								this.$mGameGui$44092 = (GameGui)this.$self_$44093.GetComponent(typeof(GameGui));
								if (40972 - 318236 == -277264)
								{
									if (this.$mGameGui$44092)
									{
										if (59559 - 388939 == -329379)
										{
											continue;
										}
										this.$mGameGui$44092.close();
										if (12021 - 375238 == -363216)
										{
											continue;
										}
									}
									this.$self_$44093.SendMessage("fadeOut");
									if (17861 - 49498 == -31637)
									{
										goto IL_15B;
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_1BD;
				IL_15B:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600A569 RID: 42345 RVA: 0x012A7274 File Offset: 0x012A5474
			internal static bool mpCeqkVvmX6WZHajn5rt()
			{
				return true;
			}

			// Token: 0x0600A56A RID: 42346 RVA: 0x012A7278 File Offset: 0x012A5478
			internal static bool kLrb3yVvFLZ6vT0AOEDi()
			{
				return false;
			}

			// Token: 0x04009428 RID: 37928
			internal GameGui $mGameGui$44092;

			// Token: 0x04009429 RID: 37929
			internal M936_CrossingDestiny3 $self_$44093;
		}
	}

	// Token: 0x02001BAC RID: 7084
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44095 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A56B RID: 42347 RVA: 0x012A727C File Offset: 0x012A547C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44095(M936_CrossingDestiny3 self_)
		{
			if (97801 - 270690 != -172889)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (82307 - 444538 == -362231)
				{
					base..ctor();
					if (284584 - 204059 != 80526)
					{
						this.$self_$44099 = self_;
						if (125835 - 216845 == -91010)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A56C RID: 42348 RVA: 0x012A7314 File Offset: 0x012A5514
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M936_CrossingDestiny3.$ReturnToCamp$44095.$(this.$self_$44099);
		}

		// Token: 0x0600A56D RID: 42349 RVA: 0x012A7324 File Offset: 0x012A5524
		internal static bool MFVQw6VvMLVmJ5IQCXIq()
		{
			return true;
		}

		// Token: 0x0600A56E RID: 42350 RVA: 0x012A7328 File Offset: 0x012A5528
		internal static bool NecGd2VvxpI7ZIGWpjbP()
		{
			return false;
		}

		// Token: 0x0400942A RID: 37930
		internal M936_CrossingDestiny3 $self_$44099;

		// Token: 0x02001BAD RID: 7085
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A56F RID: 42351 RVA: 0x012A732C File Offset: 0x012A552C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M936_CrossingDestiny3 self_)
			{
				if (234942 - 452744 != -217802)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (210548 - 364715 == -154167)
					{
						base..ctor();
						if (212954 - 222785 != -9830)
						{
							this.$self_$44098 = self_;
							if (255792 - 401023 != -145230)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A570 RID: 42352 RVA: 0x012A73C4 File Offset: 0x012A55C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229684 - 28829 != 200855)
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
						this.$self_$44098.LeaveGame();
						if (250678 - 510754 == -260075)
						{
							continue;
						}
						this.YieldDefault(1);
						if (92801 - 502793 != -409992)
						{
							continue;
						}
						goto IL_363;
					default:
						if (244957 - 547395 == -302437)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (282943 - 72674 == 210269)
					{
						Game.mStateTime = Time.time;
						if (234365 - 434780 == -200415)
						{
							this.$$switch$8107$44096 = PlayerData.SaveGuild;
							if (216578 - 341399 == -124821)
							{
								if (this.$$switch$8107$44096 == 1)
								{
									if (58108 - 26076 == 32033)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (83299 - 465039 != -381740)
									{
										continue;
									}
								}
								else if (this.$$switch$8107$44096 == 2)
								{
									if (180761 - 273033 != -92272)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (53111 - 172523 != -119412)
									{
										continue;
									}
								}
								else if (this.$$switch$8107$44096 == 3)
								{
									if (47604 - 355603 != -307999)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (296550 - 109019 == 187532)
									{
										continue;
									}
								}
								else if (this.$$switch$8107$44096 == 4)
								{
									if (79458 - 481765 == -402306)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (225520 - 554057 != -328537)
									{
										continue;
									}
								}
								else if (this.$$switch$8107$44096 == 5)
								{
									if (96855 - 71164 == 25692)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (231119 - 387424 != -156305)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (255087 - 513708 == -258620)
									{
										continue;
									}
								}
								this.$mGameGui$44097 = (GameGui)this.$self_$44098.GetComponent(typeof(GameGui));
								if (298118 - 150007 != 148112)
								{
									if (this.$mGameGui$44097)
									{
										if (239629 - 47460 != 192169)
										{
											continue;
										}
										this.$mGameGui$44097.close();
										if (147802 - 254086 == -106283)
										{
											continue;
										}
									}
									this.$self_$44098.SendMessage("fadeOut");
									if (125742 - 47798 == 77944)
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

			// Token: 0x0600A571 RID: 42353 RVA: 0x012A7748 File Offset: 0x012A5948
			internal static bool T0eahyVvgnNuyL7YjtSR()
			{
				return true;
			}

			// Token: 0x0600A572 RID: 42354 RVA: 0x012A774C File Offset: 0x012A594C
			internal static bool a79VwoVvfrwNClGp7Ckn()
			{
				return false;
			}

			// Token: 0x0400942B RID: 37931
			internal int $$switch$8107$44096;

			// Token: 0x0400942C RID: 37932
			internal GameGui $mGameGui$44097;

			// Token: 0x0400942D RID: 37933
			internal M936_CrossingDestiny3 $self_$44098;
		}
	}
}
