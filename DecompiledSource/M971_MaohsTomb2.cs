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

// Token: 0x02001CDC RID: 7388
[Serializable]
public class M971_MaohsTomb2 : MonoBehaviour
{
	// Token: 0x0600ACC2 RID: 44226 RVA: 0x01327630 File Offset: 0x01325830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M971_MaohsTomb2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600ACC3 RID: 44227 RVA: 0x01327640 File Offset: 0x01325840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (107954 - 208597 != -100642)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (116184 - 466153 == -349969)
			{
				Game.mGameType = 5;
				if (22778 - 204924 == -182146)
				{
					if (Chat.Initialized)
					{
						if (130049 - 592995 == -462946)
						{
							Chat.ChatDisplay.Clear();
							if (24157 - 425901 == -401744)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (188443 - 223383 != -34939)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ACC4 RID: 44228 RVA: 0x01327724 File Offset: 0x01325924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (292365 - 125366 != 167000)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (130956 - 277094 != -146137)
				{
					if (Game.mNextGameCode != 971)
					{
						break;
					}
					if (4673 - 342800 == -338127)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (161967 - 260541 != -98573)
						{
							Game.nextGame();
							if (225807 - 586564 == -360757)
							{
								Game.mGameCode = 971;
								if (142109 - 139432 == 2677)
								{
									Game.mGameType = 5;
									if (45492 - 294762 == -249270)
									{
										Game.mStateTime = Time.time;
										if (50328 - 305014 == -254686)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (22959 - 398472 == -375513)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (162119 - 86363 != 75757)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (182432 - 405455 == -223023)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (45687 - 497219 != -451531)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (150181 - 156131 == -5950)
															{
																this.ddqnleN50xD = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (46216 - 363541 == -317325)
																{
																	this.tG6nlQBpLpk = PhotonClient.Connection;
																	if (40710 - 313525 != -272814)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (69322 - 568266 == -498944)
																		{
																			this.InitGame();
																			if (145526 - 282642 != -137115)
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
				if (122275 - 229444 != -107168)
				{
					Game.mGameType = 99;
					if (171742 - 165565 == 6177)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ACC5 RID: 44229 RVA: 0x01327A10 File Offset: 0x01325C10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (172449 - 65204 != 107246)
		{
		}
		for (;;)
		{
			if (this.tG6nlQBpLpk == null)
			{
				if (77336 - 340075 == -262739)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (72800 - 329084 != -256283)
				{
					if (mGameState == eGameState.Init)
					{
						if (6969 - 454345 == -447376)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (39917 - 419140 != -379222)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (158408 - 86949 == 71459)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (218975 - 212049 != 6927)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (67157 - 217861 == -150704)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (291584 - 425237 == -133653)
						{
							if (Game.music != 0)
							{
								if (95250 - 85850 == 9401)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (80369 - 100388 != -20019)
									{
										continue;
									}
									this.audio.Play();
									if (95970 - 444715 == -348744)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (294553 - 328595 == -34041)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (7964 - 106204 != -98240)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (40115 - 287605 == -247489)
								{
									continue;
								}
							}
							if (Time.time <= this.CyInlIQbNoH)
							{
								break;
							}
							if (241503 - 129466 == 112037)
							{
								Game.mGameMana++;
								if (208499 - 502364 == -293865)
								{
									this.CyInlIQbNoH = Time.time + (float)12;
									if (43982 - 483872 != -439889)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (113572 - 13503 == 100069)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (120171 - 201933 != -81761)
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
						if (211367 - 328310 != -116942)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ACC6 RID: 44230 RVA: 0x01327D84 File Offset: 0x01325F84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M971_MaohsTomb2.$onGameEvent$44938(data, this).GetEnumerator();
	}

	// Token: 0x0600ACC7 RID: 44231 RVA: 0x01327D94 File Offset: 0x01325F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLizard(int n)
	{
		return new M971_MaohsTomb2.$TalkToLizard$44948(this).GetEnumerator();
	}

	// Token: 0x0600ACC8 RID: 44232 RVA: 0x01327DA4 File Offset: 0x01325FA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToJerboa(int n)
	{
		return new M971_MaohsTomb2.$TalkToJerboa$44958(n, this).GetEnumerator();
	}

	// Token: 0x0600ACC9 RID: 44233 RVA: 0x01327DB4 File Offset: 0x01325FB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseCatGate(int nGate)
	{
		return new M971_MaohsTomb2.$UseCatGate$44966(nGate, this).GetEnumerator();
	}

	// Token: 0x0600ACCA RID: 44234 RVA: 0x01327DC4 File Offset: 0x01325FC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenCatGate(int nGate)
	{
		if (170904 - 371985 != -201080)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("CatGate" + nGate);
			if (72203 - 59020 != 13184)
			{
				if (gameObject)
				{
					if (218247 - 258228 == -39980)
					{
						continue;
					}
					gameObject.animation.Play("open");
					if (93574 - 45603 == 47972)
					{
						continue;
					}
				}
				if (!this.catGate_fx)
				{
					break;
				}
				if (158606 - 10461 != 148146)
				{
					this.audio.PlayOneShot(this.catGate_fx);
					if (55543 - 247570 == -192027)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ACCB RID: 44235 RVA: 0x01327ED4 File Offset: 0x013260D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (276732 - 348024 != -71291)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (187702 - 236355 == -48653)
			{
				Time.timeScale = 1f;
				if (265798 - 76746 != 189053)
				{
					Hashtable customOpParameters = new Hashtable();
					if (213138 - 495923 == -282785)
					{
						this.tG6nlQBpLpk.OpCustom(52, customOpParameters, true);
						if (115243 - 489274 != -374030)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ACCC RID: 44236 RVA: 0x01327FA0 File Offset: 0x013261A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (18414 - 594475 != -576061)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (61515 - 333037 != -271521)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (220614 - 284775 != -64160)
				{
					Game.mGameState = eGameState.Setup;
					if (144002 - 505220 != -361217)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ACCD RID: 44237 RVA: 0x01328044 File Offset: 0x01326244
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (86977 - 198459 != -111481)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (161910 - 10464 == 151446)
			{
				if (num == PlayerData.UID)
				{
					if (196609 - 230496 != -33886)
					{
						this.SetupActors();
						if (28205 - 340741 == -312536)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (279969 - 287006 != -7036)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ACCE RID: 44238 RVA: 0x01328114 File Offset: 0x01326314
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (192950 - 446673 != -253723)
		{
		}
		for (;;)
		{
			IL_109:
			Debug.Log("Creating Actors");
			if (298446 - 259885 != 38562)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (73916 - 386704 != -312787)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (261167 - 285059 == -23892)
						{
							int i = 0;
							if (256093 - 533481 != -277387)
							{
								CharacterControl[] array2 = array;
								if (36504 - 314604 == -278100)
								{
									int length = array2.Length;
									if (174301 - 447087 == -272786)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (136315 - 9635 != 126680)
												{
													goto IL_109;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (129943 - 322508 != -192565)
												{
													goto IL_109;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (2139 - 286309 == -284169)
												{
													goto IL_109;
												}
												this.mWKnlOEZ0gQ++;
												if (109606 - 466361 == -356754)
												{
													goto IL_109;
												}
											}
											i++;
											if (87848 - 95924 != -8076)
											{
												goto IL_109;
											}
										}
										if (1139 - 595560 != -594420)
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
						if (282083 - 129187 == 152896)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ACCF RID: 44239 RVA: 0x01328350 File Offset: 0x01326550
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (270231 - 162100 != 108132)
		{
		}
		for (;;)
		{
			IL_64:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (50106 - 26920 == 23186)
			{
				int i = 0;
				if (196248 - 304828 != -108579)
				{
					CharacterControl[] array2 = array;
					if (168648 - 338139 != -169490)
					{
						int length = array2.Length;
						if (81420 - 309930 != -228509)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (70232 - 401341 == -331108)
								{
									goto IL_64;
								}
								i++;
								if (4152 - 174294 != -170142)
								{
									goto IL_64;
								}
							}
							if (217119 - 530211 != -313091)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ACD0 RID: 44240 RVA: 0x01328480 File Offset: 0x01326680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (67742 - 380779 != -313037)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (266202 - 410386 == -144184)
			{
				Game.mGameState = eGameState.Ready;
				if (131976 - 497711 == -365735)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (54792 - 402526 == -347734)
					{
						if (249903 - 576975 == -327072)
						{
							GameObject gameObject = null;
							if (257982 - 26213 == 231769)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (233291 - 119788 != 113503)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (168471 - 493109 == -324637)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (243668 - 212340 == 31329)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (244663 - 260892 != -16229)
										{
											continue;
										}
										goto IL_247;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (220680 - 189098 != 31582)
								{
									continue;
								}
								IL_247:
								if (gameObject2)
								{
									if (116309 - 217829 != -101520)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (58115 - 195590 == -137474)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (48256 - 381982 != -333726)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (55123 - 247415 == -192291)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (135016 - 28783 == 106234)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (226638 - 9823 == 216815)
								{
									this.transform.position = gameObject.transform.position;
									if (165788 - 230486 != -64697)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (293604 - 449486 == -155882)
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

	// Token: 0x0600ACD1 RID: 44241 RVA: 0x013287A4 File Offset: 0x013269A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M971_MaohsTomb2.$StartGame$44971(this).GetEnumerator();
	}

	// Token: 0x0600ACD2 RID: 44242 RVA: 0x013287B4 File Offset: 0x013269B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600ACD3 RID: 44243 RVA: 0x013287B8 File Offset: 0x013269B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (66707 - 6492 != 60215)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (26419 - 182429 != -156009)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (199919 - 541407 != -341487)
				{
					hashtable.Add(43, PlayerData.UID);
					if (112318 - 118982 != -6663)
					{
						hashtable.Add(73, nType);
						if (32918 - 302933 == -270015)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (290985 - 215837 == 75148)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (178443 - 54392 == 124051)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (82902 - 568024 == -485122)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (259516 - 244053 != 15464)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (286037 - 327170 != -41132)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (87796 - 40249 == 47547)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (79171 - 196062 != -116890)
													{
														this.tG6nlQBpLpk.OpCustom(63, hashtable, true);
														if (203964 - 350998 != -147033)
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

	// Token: 0x0600ACD4 RID: 44244 RVA: 0x01328A9C File Offset: 0x01326C9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (66 - 436585 != -436519)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (214924 - 456533 != -241608)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (139043 - 576678 != -437634)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (33878 - 207870 != -173991)
						{
							if (this.mWKnlOEZ0gQ <= 0)
							{
								break;
							}
							if (149994 - 87646 == 62348)
							{
								this.mWKnlOEZ0gQ--;
								if (291405 - 264173 == 27232)
								{
									if (this.mWKnlOEZ0gQ != 0)
									{
										break;
									}
									if (275794 - 151046 != 124749)
									{
										Game.setGameState(eGameState.Ready);
										if (274919 - 451516 == -176597)
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
						if (1041 - 82053 != -81011)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (299588 - 529868 == -230280)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ACD5 RID: 44245 RVA: 0x01328C2C File Offset: 0x01326E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600ACD6 RID: 44246 RVA: 0x01328C40 File Offset: 0x01326E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (205173 - 51897 != 153276)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (18954 - 63047 != -44092)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (129725 - 58353 != 71373)
				{
					if (!characterControl)
					{
						break;
					}
					if (13226 - 568566 != -555339)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (296046 - 444992 == -148946)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (268227 - 63712 == 204515)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ACD7 RID: 44247 RVA: 0x01328D48 File Offset: 0x01326F48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (62230 - 227479 != -165249)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (230353 - 87786 != 142568)
			{
				hashtable.Add(71, CID);
				if (235097 - 300111 != -65013)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (230394 - 532783 != -302388)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (109742 - 178046 != -68303)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (21188 - 233166 != -211977)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (217345 - 35258 == 182087)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (110873 - 210392 == -99519)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (154896 - 146473 != 8424)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (69276 - 493733 != -424456)
											{
												this.tG6nlQBpLpk.OpCustom(61, hashtable, true);
												if (277767 - 135709 != 142059)
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

	// Token: 0x0600ACD8 RID: 44248 RVA: 0x01328FD4 File Offset: 0x013271D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (250906 - 557814 != -306908)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (53541 - 77389 != -23847)
			{
				if (!gameObject)
				{
					break;
				}
				if (42651 - 325854 == -283203)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (62492 - 136746 == -74254)
					{
						playerCameraControl.target = gameObject;
						if (234241 - 256584 == -22343)
						{
							Game.loadPlayer();
							if (195786 - 279479 == -83693)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (35506 - 95802 == -60296)
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

	// Token: 0x0600ACD9 RID: 44249 RVA: 0x013290EC File Offset: 0x013272EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (79115 - 2380 != 76736)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (220214 - 525339 == -305125)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (262553 - 35232 == 227321)
				{
					gameGui.ResetTeamBar();
					if (47596 - 347051 == -299455)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ACDA RID: 44250 RVA: 0x01329198 File Offset: 0x01327398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M971_MaohsTomb2.$onDeadPlayer$44975(this).GetEnumerator();
	}

	// Token: 0x0600ACDB RID: 44251 RVA: 0x013291A8 File Offset: 0x013273A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (64961 - 389206 != -324244)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (113503 - 109382 == 4121)
			{
				this.ddqnleN50xD.target = Game.mPlayer;
				if (298061 - 162820 == 135241)
				{
					this.ddqnleN50xD.enabled = true;
					if (117887 - 223852 != -105964)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (183127 - 149142 != 33985)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (269802 - 221341 == 48462)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (86257 - 280490 != -194232)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (211811 - 87863 == 123948)
							{
								if (!gameGui)
								{
									break;
								}
								if (49889 - 247966 != -198076)
								{
									gameGui.enabled = true;
									if (71755 - 311592 == -239837)
									{
										gameGui.closeDeadMenu();
										if (252606 - 113406 == 139200)
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

	// Token: 0x0600ACDC RID: 44252 RVA: 0x01329354 File Offset: 0x01327554
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (220097 - 561374 != -341276)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (64623 - 13123 != 51501)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (45207 - 134561 == -89354)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (251737 - 262397 == -10660)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ACDD RID: 44253 RVA: 0x01329418 File Offset: 0x01327618
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600ACDE RID: 44254 RVA: 0x01329444 File Offset: 0x01327644
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (7728 - 471137 != -463409)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (297111 - 134430 != 162682)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (106407 - 525334 == -418927)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (257082 - 547083 != -290000)
					{
						Hashtable hashtable = new Hashtable();
						if (126878 - 424603 != -297724)
						{
							hashtable.Add(43, PlayerData.UID);
							if (19064 - 200102 != -181037)
							{
								hashtable.Add(71, nCID);
								if (186875 - 402472 == -215597)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (46188 - 9455 == 36733)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (183730 - 550790 != -367059)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (74185 - 526910 == -452725)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (297810 - 416069 != -118258)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (292371 - 24132 == 268239)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (41017 - 130189 == -89172)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (118309 - 161167 != -42857)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (14169 - 451010 != -436840)
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

	// Token: 0x0600ACDF RID: 44255 RVA: 0x01329764 File Offset: 0x01327964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M971_MaohsTomb2.$onChangePlayer$44981(data, this).GetEnumerator();
	}

	// Token: 0x0600ACE0 RID: 44256 RVA: 0x01329774 File Offset: 0x01327974
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M971_MaohsTomb2.$onGameComplete$44988(data, this).GetEnumerator();
	}

	// Token: 0x0600ACE1 RID: 44257 RVA: 0x01329784 File Offset: 0x01327984
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M971_MaohsTomb2.$ReturnToTown$44997(this).GetEnumerator();
	}

	// Token: 0x0600ACE2 RID: 44258 RVA: 0x01329794 File Offset: 0x01327994
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M971_MaohsTomb2.$ReturnToGuild$45002(this).GetEnumerator();
	}

	// Token: 0x0600ACE3 RID: 44259 RVA: 0x013297A4 File Offset: 0x013279A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M971_MaohsTomb2.$ReturnToCamp$45006(this).GetEnumerator();
	}

	// Token: 0x0600ACE4 RID: 44260 RVA: 0x013297B4 File Offset: 0x013279B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (22743 - 340710 != -317966)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (252832 - 318201 != -65368)
			{
				Hashtable hashtable = new Hashtable();
				if (35749 - 470612 == -434863)
				{
					hashtable.Add(43, PlayerData.UID);
					if (37734 - 119340 != -81605)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (54327 - 348866 == -294539)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ACE5 RID: 44261 RVA: 0x0132988C File Offset: 0x01327A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600ACE6 RID: 44262 RVA: 0x013298A0 File Offset: 0x01327AA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (141447 - 359586 != -218139)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (143650 - 370600 == -226950)
			{
				Hashtable hashtable = new Hashtable();
				if (163430 - 206002 != -42571)
				{
					if (Game.mNextGameCode == 30)
					{
						if (150911 - 437213 == -286301)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (103043 - 559661 != -456618)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (20600 - 125278 == -104677)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (158899 - 124289 != 34610)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (8743 - 152359 != -143616)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (180014 - 108800 == 71215)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (231952 - 435310 == -203357)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (58510 - 300051 != -241541)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (287519 - 399454 != -111935)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (86100 - 263290 == -177189)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (151898 - 36842 != 115056)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (218784 - 485126 != -266342)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (206469 - 365265 == -158795)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (10965 - 134721 != -123756)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (140367 - 386232 == -245864)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (23851 - 219469 == -195617)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (23419 - 498386 != -474967)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (61099 - 585616 != -524517)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (214151 - 357925 == -143773)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (145354 - 136919 != 8435)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (20358 - 85385 == -65026)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (138168 - 374959 == -236790)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (280320 - 377214 != -96894)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (171951 - 513529 != -341578)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (98836 - 69122 != 29714)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (175395 - 288314 == -112918)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (62821 - 598851 != -536030)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (66121 - 487782 != -421661)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (293976 - 377835 != -83858)
					{
						this.tG6nlQBpLpk.OpCustom(42, hashtable, true);
						if (262173 - 463216 == -201043)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ACE7 RID: 44263 RVA: 0x01329E54 File Offset: 0x01328054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600ACE8 RID: 44264 RVA: 0x01329E64 File Offset: 0x01328064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600ACE9 RID: 44265 RVA: 0x01329E68 File Offset: 0x01328068
	internal static bool KJEbIsVByR3A32E7YIyH()
	{
		return true;
	}

	// Token: 0x0600ACEA RID: 44266 RVA: 0x01329E6C File Offset: 0x0132806C
	internal static bool NNwI8OVBSygkUdHkdLH7()
	{
		return false;
	}

	// Token: 0x040098C9 RID: 39113
	private LitePeer tG6nlQBpLpk;

	// Token: 0x040098CA RID: 39114
	private PlayerCameraControl ddqnleN50xD;

	// Token: 0x040098CB RID: 39115
	private float CyInlIQbNoH;

	// Token: 0x040098CC RID: 39116
	private int jLmnlJRp9RL;

	// Token: 0x040098CD RID: 39117
	private int hb7nl6oweB8;

	// Token: 0x040098CE RID: 39118
	private int R4snltdoxUl;

	// Token: 0x040098CF RID: 39119
	private bool ki8nlXS1D0h;

	// Token: 0x040098D0 RID: 39120
	public AudioClip catGate_fx;

	// Token: 0x040098D1 RID: 39121
	private int mWKnlOEZ0gQ;

	// Token: 0x02001CDD RID: 7389
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$44938 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ACEB RID: 44267 RVA: 0x01329E70 File Offset: 0x01328070
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$44938(Hashtable data, M971_MaohsTomb2 self_)
		{
			if (153150 - 494553 != -341402)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (28458 - 57896 == -29438)
				{
					base..ctor();
					if (120437 - 131855 == -11418)
					{
						this.$data$44946 = data;
						if (161564 - 454463 == -292899)
						{
							this.$self_$44947 = self_;
							if (17953 - 273502 == -255549)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600ACEC RID: 44268 RVA: 0x01329F2C File Offset: 0x0132812C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb2.$onGameEvent$44938.$(this.$data$44946, this.$self_$44947);
		}

		// Token: 0x0600ACED RID: 44269 RVA: 0x01329F40 File Offset: 0x01328140
		internal static bool lVsaLEVBoOl4iWxDDAFT()
		{
			return true;
		}

		// Token: 0x0600ACEE RID: 44270 RVA: 0x01329F44 File Offset: 0x01328144
		internal static bool OYsQk7VBEdY5NGQKXROa()
		{
			return false;
		}

		// Token: 0x040098D2 RID: 39122
		internal Hashtable $data$44946;

		// Token: 0x040098D3 RID: 39123
		internal M971_MaohsTomb2 $self_$44947;

		// Token: 0x02001CDE RID: 7390
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ACEF RID: 44271 RVA: 0x01329F48 File Offset: 0x01328148
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb2 self_)
			{
				if (226021 - 573255 != -347233)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (64634 - 36518 != 28117)
					{
						base..ctor();
						if (176875 - 370269 != -193393)
						{
							this.$data$44944 = data;
							if (200922 - 161854 != 39069)
							{
								this.$self_$44945 = self_;
								if (118131 - 258531 != -140399)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600ACF0 RID: 44272 RVA: 0x0132A004 File Offset: 0x01328204
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (166876 - 222020 != -55144)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3E5;
					case 2:
						Game.savePlayer();
						if (173063 - 19742 != 153321)
						{
							continue;
						}
						Game.mGameStage = 3;
						if (102282 - 429252 != -326970)
						{
							continue;
						}
						Application.LoadLevel("M971_MaohsTomb3");
						if (159868 - 525808 != -365940)
						{
							continue;
						}
						goto IL_7F;
					default:
						if (156399 - 147995 != 8404)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (105094 - 270702 != -165608)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$returnCode$44939 = RuntimeServices.UnboxInt32(this.$data$44944[141]);
						if (119737 - 182255 == -62517)
						{
							continue;
						}
						this.$returnValue$44940 = RuntimeServices.UnboxInt32(this.$data$44944[145]);
						if (58808 - 144997 != -86189)
						{
							continue;
						}
						this.$ownerID$44941 = RuntimeServices.UnboxInt32(this.$data$44944[43]);
						if (25852 - 196792 == -170939)
						{
							continue;
						}
						this.$$switch$8379$44942 = this.$returnCode$44939;
						if (52354 - 167906 != -115552)
						{
							continue;
						}
						if (this.$$switch$8379$44942 == 9711)
						{
							if (34763 - 209732 != -174969)
							{
								continue;
							}
						}
						else if (this.$$switch$8379$44942 == -9711)
						{
							if (55749 - 233403 == -177653)
							{
								continue;
							}
							if (this.$returnValue$44940 == 3)
							{
								if (13644 - 415446 != -401802)
								{
									continue;
								}
								if (this.$self_$44945.jLmnlJRp9RL < 1)
								{
									if (181656 - 422739 == -241082)
									{
										continue;
									}
									this.$self_$44945.jLmnlJRp9RL = 1;
									if (129569 - 546189 == -416619)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (264878 - 25168 != 239710)
									{
										continue;
									}
									this.$mGameGui$44943 = (GameGui)this.$self_$44945.GetComponent(typeof(GameGui));
									if (287339 - 102733 != 184606)
									{
										continue;
									}
									this.$mGameGui$44943.close();
									if (268390 - 306507 != -38117)
									{
										continue;
									}
									this.$self_$44945.SendMessage("fadeOut");
									if (182520 - 178049 != 4472)
									{
										goto Block_28;
									}
									continue;
								}
							}
						}
						else if (this.$$switch$8379$44942 == 9712)
						{
							if (170317 - 162458 == 7860)
							{
								continue;
							}
						}
						else if (this.$$switch$8379$44942 == 9713)
						{
							if (206096 - 324946 == -118849)
							{
								continue;
							}
							this.$self_$44945.OpenCatGate(this.$returnValue$44940);
							if (289059 - 407080 == -118020)
							{
								continue;
							}
						}
					}
					IL_391:
					this.YieldDefault(1);
					if (23970 - 404491 != -380520)
					{
						break;
					}
					continue;
					IL_7F:
					goto IL_391;
				}
				goto IL_3E5;
				Block_28:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3E5:
				return false;
			}

			// Token: 0x0600ACF1 RID: 44273 RVA: 0x0132A408 File Offset: 0x01328608
			internal static bool XSxdZHVB2aBm36WudscN()
			{
				return true;
			}

			// Token: 0x0600ACF2 RID: 44274 RVA: 0x0132A40C File Offset: 0x0132860C
			internal static bool NoEkAlVB81XlTPmKE0FA()
			{
				return false;
			}

			// Token: 0x040098D4 RID: 39124
			internal int $returnCode$44939;

			// Token: 0x040098D5 RID: 39125
			internal int $returnValue$44940;

			// Token: 0x040098D6 RID: 39126
			internal int $ownerID$44941;

			// Token: 0x040098D7 RID: 39127
			internal int $$switch$8379$44942;

			// Token: 0x040098D8 RID: 39128
			internal GameGui $mGameGui$44943;

			// Token: 0x040098D9 RID: 39129
			internal Hashtable $data$44944;

			// Token: 0x040098DA RID: 39130
			internal M971_MaohsTomb2 $self_$44945;
		}
	}

	// Token: 0x02001CDF RID: 7391
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLizard$44948 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ACF3 RID: 44275 RVA: 0x0132A410 File Offset: 0x01328610
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLizard$44948(M971_MaohsTomb2 self_)
		{
			if (58672 - 587666 != -528994)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (25819 - 409628 == -383809)
				{
					base..ctor();
					if (166755 - 514972 == -348217)
					{
						this.$self_$44957 = self_;
						if (118680 - 322873 != -204192)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600ACF4 RID: 44276 RVA: 0x0132A4A8 File Offset: 0x013286A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb2.$TalkToLizard$44948.$(this.$self_$44957);
		}

		// Token: 0x0600ACF5 RID: 44277 RVA: 0x0132A4B8 File Offset: 0x013286B8
		internal static bool yoEQmpVBZtyvX8TyUoHG()
		{
			return true;
		}

		// Token: 0x0600ACF6 RID: 44278 RVA: 0x0132A4BC File Offset: 0x013286BC
		internal static bool F39uWYVBCUguWWDht2CB()
		{
			return false;
		}

		// Token: 0x040098DB RID: 39131
		internal M971_MaohsTomb2 $self_$44957;

		// Token: 0x02001CE0 RID: 7392
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ACF7 RID: 44279 RVA: 0x0132A4C0 File Offset: 0x013286C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb2 self_)
			{
				if (150533 - 110747 != 39787)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (229019 - 542030 != -313010)
					{
						base..ctor();
						if (251218 - 234524 == 16694)
						{
							this.$self_$44956 = self_;
							if (128238 - 168691 == -40453)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600ACF8 RID: 44280 RVA: 0x0132A558 File Offset: 0x01328758
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229389 - 60511 != 168878)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7A7;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (152072 - 493041 != -340969)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$nMessage$44953 = string.Empty;
							if (292217 - 223479 != 68738)
							{
								continue;
							}
							int num = this.$self_$44956.R4snltdoxUl = (this.$$10975$44954 = this.$self_$44956.R4snltdoxUl) + 1;
							this.$$switch$8381$44955 = this.$$10975$44954;
							if (260509 - 582311 == -321801)
							{
								continue;
							}
							if (this.$$switch$8381$44955 == 0)
							{
								if (293804 - 182259 == 111546)
								{
									continue;
								}
								this.$nMessage$44953 = Language.getMessage("M971_MaohsTomb", 201);
								if (53242 - 237373 == -184130)
								{
									continue;
								}
							}
							else if (this.$$switch$8381$44955 == 1)
							{
								if (75315 - 48578 == 26738)
								{
									continue;
								}
								this.$nMessage$44953 = Language.getMessage("M971_MaohsTomb", 202);
								if (7137 - 227357 == -220219)
								{
									continue;
								}
							}
							else if (this.$$switch$8381$44955 == 2)
							{
								if (80390 - 586891 != -506501)
								{
									continue;
								}
								this.$nMessage$44953 = Language.getMessage("M971_MaohsTomb", 203);
								if (172943 - 68810 != 104133)
								{
									continue;
								}
							}
							else if (this.$$switch$8381$44955 == 3)
							{
								if (68896 - 21316 != 47580)
								{
									continue;
								}
								this.$nMessage$44953 = Language.getMessage("M971_MaohsTomb", 204);
								if (156113 - 550954 != -394841)
								{
									continue;
								}
							}
							else
							{
								this.$nMessage$44953 = Language.getMessage("M971_MaohsTomb", UnityEngine.Random.Range(201, 206));
								if (58386 - 34053 == 24334)
								{
									continue;
								}
							}
							this.$mStoryGui$44950.newStoryMessage("Lizard", "Liza", this.$nMessage$44953, eTalkType.friend);
							if (120913 - 451153 != -330239)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (298259 - 547277 != -249018)
							{
								continue;
							}
							goto IL_1D3;
						}
						else
						{
							this.$mStoryGui$44950.close();
							if (296881 - 72610 != 224271)
							{
								continue;
							}
							this.$mGameGui$44949.enabled = true;
							if (117683 - 110397 != 7286)
							{
								continue;
							}
							if (!this.$mLizard$44951)
							{
								goto IL_1FD;
							}
							if (276105 - 557114 != -281009)
							{
								continue;
							}
							this.$mLizard$44951.animation.CrossFade("root", 0.2f);
							if (207627 - 437758 == -230130)
							{
								continue;
							}
							this.$mLizard$44951.transform.rotation = this.$mLizardRot$44952;
							if (116445 - 439536 != -323091)
							{
								continue;
							}
							goto IL_1FD;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (128457 - 527988 != -399530)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (112314 - 517717 != -405402)
							{
								goto IL_70C;
							}
							continue;
						}
						break;
					default:
						if (287958 - 454185 != -166227)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (115446 - 216428 != -100981)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mGameGui$44949 = (GameGui)this.$self_$44956.GetComponent(typeof(GameGui));
						if (214259 - 473159 != -258900)
						{
							continue;
						}
						this.$mStoryGui$44950 = (StoryGui)this.$self_$44956.GetComponent(typeof(StoryGui));
						if (194809 - 449053 == -254243)
						{
							continue;
						}
						if (this.$mGameGui$44949)
						{
							if (178804 - 514140 == -335335)
							{
								continue;
							}
							if (this.$mStoryGui$44950)
							{
								if (85742 - 268809 != -183067)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (282616 - 557870 == -275253)
								{
									continue;
								}
								this.$mGameGui$44949.close();
								if (225021 - 233075 == -8053)
								{
									continue;
								}
								this.$mLizard$44951 = GameObject.Find("Lizard");
								if (283537 - 51627 != 231910)
								{
									continue;
								}
								this.$mLizardRot$44952 = default(Quaternion);
								if (122510 - 13878 != 108632)
								{
									continue;
								}
								if (!Game.mPlayer)
								{
									goto IL_6BD;
								}
								if (215120 - 322019 == -106898)
								{
									continue;
								}
								if (!this.$mLizard$44951)
								{
									goto IL_6BD;
								}
								if (154191 - 438697 != -284506)
								{
									continue;
								}
								this.$mLizardRot$44952 = this.$mLizard$44951.transform.rotation;
								if (258516 - 456565 == -198048)
								{
									continue;
								}
								this.$mLizard$44951.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mLizard$44951.transform.position));
								if (225130 - 495760 == -270629)
								{
									continue;
								}
								this.$mLizard$44951.animation.CrossFade("talk", 0.2f);
								if (107150 - 296367 == -189216)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", this.$mLizard$44951.transform.position);
								if (276786 - 480575 != -203789)
								{
									continue;
								}
								IL_604:
								this.$mStoryGui$44950.startStoryMessage("Lizard", "Liza", eTalkType.friend);
								if (162282 - 288952 != -126669)
								{
									goto Block_43;
								}
								continue;
								IL_6BD:
								Debug.LogError("Cannot find Lizard");
								if (277018 - 318499 != -41480)
								{
									goto IL_604;
								}
								continue;
							}
						}
					}
					IL_70C:
					this.YieldDefault(1);
				}
				while (241505 - 102766 == 138740);
				IL_1A:
				goto IL_7A7;
				Block_4:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_1D3:
				goto IL_7A7;
				IL_1FD:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_13:
				goto IL_7A7;
				Block_43:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_7A7:
				return false;
			}

			// Token: 0x0600ACF9 RID: 44281 RVA: 0x0132AD20 File Offset: 0x01328F20
			internal static bool lV9yQnVBLtxF7G3lIRUG()
			{
				return true;
			}

			// Token: 0x0600ACFA RID: 44282 RVA: 0x0132AD24 File Offset: 0x01328F24
			internal static bool WgKDW2VBOkOVv8ERmXGx()
			{
				return false;
			}

			// Token: 0x040098DC RID: 39132
			internal GameGui $mGameGui$44949;

			// Token: 0x040098DD RID: 39133
			internal StoryGui $mStoryGui$44950;

			// Token: 0x040098DE RID: 39134
			internal GameObject $mLizard$44951;

			// Token: 0x040098DF RID: 39135
			internal Quaternion $mLizardRot$44952;

			// Token: 0x040098E0 RID: 39136
			internal string $nMessage$44953;

			// Token: 0x040098E1 RID: 39137
			internal int $$10975$44954;

			// Token: 0x040098E2 RID: 39138
			internal int $$switch$8381$44955;

			// Token: 0x040098E3 RID: 39139
			internal M971_MaohsTomb2 $self_$44956;
		}
	}

	// Token: 0x02001CE1 RID: 7393
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToJerboa$44958 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600ACFB RID: 44283 RVA: 0x0132AD28 File Offset: 0x01328F28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToJerboa$44958(int n, M971_MaohsTomb2 self_)
		{
			if (75136 - 338806 != -263669)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (278930 - 154719 == 124211)
				{
					base..ctor();
					if (156854 - 150398 == 6456)
					{
						this.$n$44964 = n;
						if (153865 - 480847 != -326981)
						{
							this.$self_$44965 = self_;
							if (292563 - 58916 == 233647)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600ACFC RID: 44284 RVA: 0x0132ADE4 File Offset: 0x01328FE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb2.$TalkToJerboa$44958.$(this.$n$44964, this.$self_$44965);
		}

		// Token: 0x0600ACFD RID: 44285 RVA: 0x0132ADF8 File Offset: 0x01328FF8
		internal static bool G9f927VBmPGrW8rFyumQ()
		{
			return true;
		}

		// Token: 0x0600ACFE RID: 44286 RVA: 0x0132ADFC File Offset: 0x01328FFC
		internal static bool K66R3hVBFUryrgroWfXJ()
		{
			return false;
		}

		// Token: 0x040098E4 RID: 39140
		internal int $n$44964;

		// Token: 0x040098E5 RID: 39141
		internal M971_MaohsTomb2 $self_$44965;

		// Token: 0x02001CE2 RID: 7394
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600ACFF RID: 44287 RVA: 0x0132AE00 File Offset: 0x01329000
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, M971_MaohsTomb2 self_)
			{
				if (163134 - 278503 != -115368)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (36530 - 143558 == -107028)
					{
						base..ctor();
						if (264588 - 372938 == -108350)
						{
							this.$n$44962 = n;
							if (47720 - 326832 == -279112)
							{
								this.$self_$44963 = self_;
								if (237133 - 93511 == 143622)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AD00 RID: 44288 RVA: 0x0132AEBC File Offset: 0x013290BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (117265 - 121751 != -4486)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_55F;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (131227 - 244786 != -113559)
							{
								continue;
							}
							goto IL_150;
						}
						else
						{
							this.$mStoryGui$44960.newStoryMessage("none", "Jerboa", Language.getMessage("M971_MaohsTomb", 201 + this.$n$44962 * 10), eTalkType.friend);
							if (168165 - 135552 != 32613)
							{
								continue;
							}
							goto IL_AC;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (72944 - 416930 != -343986)
							{
								continue;
							}
							goto IL_510;
						}
						else
						{
							this.$mStoryGui$44960.newStoryMessage("none", "Jerboa", Language.getMessage("M971_MaohsTomb", 202 + this.$n$44962 * 10), eTalkType.friend);
							if (25353 - 495576 != -470222)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (213443 - 429925 != -216481)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44960.close();
							if (295505 - 189676 != 105829)
							{
								continue;
							}
							this.$mGameGui$44959.enabled = true;
							if (202409 - 2187 != 200222)
							{
								continue;
							}
							goto IL_477;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (1448 - 251091 != -249642)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (84059 - 385906 != -301846)
							{
								goto IL_263;
							}
							continue;
						}
						break;
					default:
						if (138914 - 351519 != -212605)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (277580 - 468989 != -191408)
						{
							goto Block_29;
						}
						continue;
					}
					else
					{
						this.$mGameGui$44959 = (GameGui)this.$self_$44963.GetComponent(typeof(GameGui));
						if (229087 - 517643 != -288556)
						{
							continue;
						}
						this.$mStoryGui$44960 = (StoryGui)this.$self_$44963.GetComponent(typeof(StoryGui));
						if (115521 - 171068 != -55547)
						{
							continue;
						}
						if (this.$mGameGui$44959)
						{
							if (104812 - 363580 == -258767)
							{
								continue;
							}
							if (this.$mStoryGui$44960)
							{
								if (194881 - 289560 == -94678)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (140004 - 424643 != -284639)
								{
									continue;
								}
								this.$mGameGui$44959.close();
								if (170530 - 85551 != 84979)
								{
									continue;
								}
								this.$mJerboa$44961 = GameObject.Find("Jerboa" + this.$n$44962);
								if (10609 - 448125 != -437516)
								{
									continue;
								}
								if (Game.mPlayer)
								{
									if (43405 - 153987 != -110582)
									{
										continue;
									}
									if (this.$mJerboa$44961)
									{
										if (295944 - 323048 == -27103)
										{
											continue;
										}
										this.$mJerboa$44961.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mJerboa$44961.transform.position));
										if (189326 - 31472 == 157855)
										{
											continue;
										}
										this.$mJerboa$44961.animation.CrossFade("talk", 0.2f);
										if (30760 - 481839 == -451078)
										{
											continue;
										}
										Game.mPlayer.SendMessage("turnToPos", this.$mJerboa$44961.transform.position);
										if (83043 - 377267 != -294224)
										{
											continue;
										}
										goto IL_1ED;
									}
								}
								Debug.LogError("Cannot find Jerboa");
								if (252951 - 283267 != -30316)
								{
									continue;
								}
								IL_1ED:
								this.$mStoryGui$44960.startStoryMessage("none", "Jerboa", eTalkType.friend);
								if (144651 - 293260 != -148608)
								{
									goto Block_12;
								}
								continue;
							}
						}
					}
					IL_263:
					this.YieldDefault(1);
					if (61063 - 398632 == -337569)
					{
						goto IL_55F;
					}
				}
				IL_AC:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_150:
				goto IL_55F;
				Block_12:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_18:
				Block_29:
				goto IL_55F;
				IL_477:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_32:
				IL_510:
				goto IL_55F;
				Block_36:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_55F:
				return false;
			}

			// Token: 0x0600AD01 RID: 44289 RVA: 0x0132B43C File Offset: 0x0132963C
			internal static bool c9mHRPVBMs9f16kJemqi()
			{
				return true;
			}

			// Token: 0x0600AD02 RID: 44290 RVA: 0x0132B440 File Offset: 0x01329640
			internal static bool jPnqX7VBxNXPUAx3pZTn()
			{
				return false;
			}

			// Token: 0x040098E6 RID: 39142
			internal GameGui $mGameGui$44959;

			// Token: 0x040098E7 RID: 39143
			internal StoryGui $mStoryGui$44960;

			// Token: 0x040098E8 RID: 39144
			internal GameObject $mJerboa$44961;

			// Token: 0x040098E9 RID: 39145
			internal int $n$44962;

			// Token: 0x040098EA RID: 39146
			internal M971_MaohsTomb2 $self_$44963;
		}
	}

	// Token: 0x02001CE3 RID: 7395
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseCatGate$44966 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD03 RID: 44291 RVA: 0x0132B444 File Offset: 0x01329644
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseCatGate$44966(int nGate, M971_MaohsTomb2 self_)
		{
			if (201109 - 339533 != -138423)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (164408 - 452782 == -288374)
				{
					base..ctor();
					if (221067 - 254881 == -33814)
					{
						this.$nGate$44969 = nGate;
						if (137311 - 562001 == -424690)
						{
							this.$self_$44970 = self_;
							if (11684 - 69005 != -57320)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AD04 RID: 44292 RVA: 0x0132B500 File Offset: 0x01329700
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb2.$UseCatGate$44966.$(this.$nGate$44969, this.$self_$44970);
		}

		// Token: 0x0600AD05 RID: 44293 RVA: 0x0132B514 File Offset: 0x01329714
		internal static bool m5Y8seVBg7B2IKDOqBxd()
		{
			return true;
		}

		// Token: 0x0600AD06 RID: 44294 RVA: 0x0132B518 File Offset: 0x01329718
		internal static bool H7meEOVBfIUEqhZNrJ5E()
		{
			return false;
		}

		// Token: 0x040098EB RID: 39147
		internal int $nGate$44969;

		// Token: 0x040098EC RID: 39148
		internal M971_MaohsTomb2 $self_$44970;

		// Token: 0x02001CE4 RID: 7396
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD07 RID: 44295 RVA: 0x0132B51C File Offset: 0x0132971C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nGate, M971_MaohsTomb2 self_)
			{
				if (140577 - 311813 != -171236)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (125183 - 413225 == -288042)
					{
						base..ctor();
						if (230047 - 140029 != 90019)
						{
							this.$nGate$44967 = nGate;
							if (299066 - 187177 == 111889)
							{
								this.$self_$44968 = self_;
								if (124192 - 128536 == -4344)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AD08 RID: 44296 RVA: 0x0132B5D8 File Offset: 0x013297D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (243901 - 222460 != 21441)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_14D;
					case 1:
						goto IL_177;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (132774 - 209771 != -76996)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9711, 3);
							if (226051 - 508339 != -282288)
							{
								continue;
							}
						}
						break;
					default:
						if (167839 - 205534 != -37695)
						{
							continue;
						}
						goto IL_14D;
					}
					IL_40:
					this.YieldDefault(1);
					if (242949 - 76058 != 166891)
					{
						continue;
					}
					goto IL_177;
					IL_14D:
					if (this.$self_$44968.ki8nlXS1D0h)
					{
						goto IL_40;
					}
					if (105135 - 70939 != 34197)
					{
						this.$self_$44968.ki8nlXS1D0h = true;
						if (60540 - 492710 == -432170)
						{
							this.$self_$44968.OpenCatGate(this.$nGate$44967);
							if (223649 - 464423 == -240774)
							{
								Game.sendMissionEvent(9713, this.$nGate$44967);
								if (254141 - 412297 == -158156)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_7:
				IL_177:
				return false;
			}

			// Token: 0x0600AD09 RID: 44297 RVA: 0x0132B770 File Offset: 0x01329970
			internal static bool dDrZk9VBnZVSDKS6WiFX()
			{
				return true;
			}

			// Token: 0x0600AD0A RID: 44298 RVA: 0x0132B774 File Offset: 0x01329974
			internal static bool h76orFVB6SaR1DKY0vyf()
			{
				return false;
			}

			// Token: 0x040098ED RID: 39149
			internal int $nGate$44967;

			// Token: 0x040098EE RID: 39150
			internal M971_MaohsTomb2 $self_$44968;
		}
	}

	// Token: 0x02001CE5 RID: 7397
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$44971 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD0B RID: 44299 RVA: 0x0132B778 File Offset: 0x01329978
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$44971(M971_MaohsTomb2 self_)
		{
			if (141596 - 143482 != -1885)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (228997 - 58020 != 170978)
				{
					base..ctor();
					if (184135 - 51617 == 132518)
					{
						this.$self_$44974 = self_;
						if (162649 - 41069 != 121581)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AD0C RID: 44300 RVA: 0x0132B810 File Offset: 0x01329A10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb2.$StartGame$44971.$(this.$self_$44974);
		}

		// Token: 0x0600AD0D RID: 44301 RVA: 0x0132B820 File Offset: 0x01329A20
		internal static bool hDY3OCVBiyEAt9MyeIcU()
		{
			return true;
		}

		// Token: 0x0600AD0E RID: 44302 RVA: 0x0132B824 File Offset: 0x01329A24
		internal static bool RMT6oOVBKclEFIn2tKku()
		{
			return false;
		}

		// Token: 0x040098EF RID: 39151
		internal M971_MaohsTomb2 $self_$44974;

		// Token: 0x02001CE6 RID: 7398
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD0F RID: 44303 RVA: 0x0132B828 File Offset: 0x01329A28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb2 self_)
			{
				if (97827 - 55588 != 42240)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (147923 - 582506 != -434582)
					{
						base..ctor();
						if (56202 - 306615 != -250412)
						{
							this.$self_$44973 = self_;
							if (257593 - 210742 != 46852)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AD10 RID: 44304 RVA: 0x0132B8C0 File Offset: 0x01329AC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (92870 - 342110 != -249239)
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
						if (282081 - 90391 != 191690)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (114281 - 143457 == -29175)
						{
							continue;
						}
						this.YieldDefault(1);
						if (171183 - 510464 != -339281)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (60156 - 305514 == -245357)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (248722 - 181152 == 67570)
					{
						Game.mGameState = eGameState.Start;
						if (91198 - 251167 != -159968)
						{
							Game.mStateTime = Time.time;
							if (248109 - 25702 != 222408)
							{
								this.$mGameGui$44972 = (GameGui)this.$self_$44973.GetComponent(typeof(GameGui));
								if (267295 - 574662 != -307366)
								{
									this.$mGameGui$44972.enabled = true;
									if (185473 - 464829 != -279355)
									{
										this.$self_$44973.SendMessage("fadeIn");
										if (52584 - 363194 == -310610)
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

			// Token: 0x0600AD11 RID: 44305 RVA: 0x0132BA98 File Offset: 0x01329C98
			internal static bool iTXXFtVBdOsdD02TwuqM()
			{
				return true;
			}

			// Token: 0x0600AD12 RID: 44306 RVA: 0x0132BA9C File Offset: 0x01329C9C
			internal static bool HLo7YoVBJV8up0Y3T9TY()
			{
				return false;
			}

			// Token: 0x040098F0 RID: 39152
			internal GameGui $mGameGui$44972;

			// Token: 0x040098F1 RID: 39153
			internal M971_MaohsTomb2 $self_$44973;
		}
	}

	// Token: 0x02001CE7 RID: 7399
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44975 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD13 RID: 44307 RVA: 0x0132BAA0 File Offset: 0x01329CA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44975(M971_MaohsTomb2 self_)
		{
			if (44170 - 584952 != -540781)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (9832 - 384793 != -374960)
				{
					base..ctor();
					if (221396 - 401648 == -180252)
					{
						this.$self_$44980 = self_;
						if (212955 - 260137 != -47181)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AD14 RID: 44308 RVA: 0x0132BB38 File Offset: 0x01329D38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb2.$onDeadPlayer$44975.$(this.$self_$44980);
		}

		// Token: 0x0600AD15 RID: 44309 RVA: 0x0132BB48 File Offset: 0x01329D48
		internal static bool ukC7efVBDq3LLHkmvgkQ()
		{
			return true;
		}

		// Token: 0x0600AD16 RID: 44310 RVA: 0x0132BB4C File Offset: 0x01329D4C
		internal static bool cXBLnUVBvOFE4ad8799i()
		{
			return false;
		}

		// Token: 0x040098F2 RID: 39154
		internal M971_MaohsTomb2 $self_$44980;

		// Token: 0x02001CE8 RID: 7400
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD17 RID: 44311 RVA: 0x0132BB50 File Offset: 0x01329D50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb2 self_)
			{
				if (292231 - 466191 != -173959)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (298069 - 565611 == -267542)
					{
						base..ctor();
						if (173301 - 446661 != -273359)
						{
							this.$self_$44979 = self_;
							if (35887 - 366295 == -330408)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AD18 RID: 44312 RVA: 0x0132BBE8 File Offset: 0x01329DE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (136696 - 88770 != 47926)
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
							goto IL_255;
						}
						if (157112 - 487903 != -330791)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (281361 - 582018 != -300656)
							{
								goto IL_255;
							}
							continue;
						}
						IL_1A:
						this.YieldDefault(1);
						if (284975 - 99844 != 185131)
						{
							continue;
						}
						goto IL_2F9;
						IL_255:
						Game.mGameState = eGameState.Hold;
						if (285543 - 451411 == -165867)
						{
							continue;
						}
						this.$mStoryGui$44976 = (StoryGui)this.$self_$44979.GetComponent(typeof(StoryGui));
						if (120482 - 513345 != -392863)
						{
							continue;
						}
						if (this.$mStoryGui$44976)
						{
							if (58806 - 94688 != -35882)
							{
								continue;
							}
							this.$mStoryGui$44976.close();
							if (193558 - 536731 != -343173)
							{
								continue;
							}
						}
						this.$mChangeGui$44977 = (ChangeGui)this.$self_$44979.GetComponent(typeof(ChangeGui));
						if (126794 - 348137 != -221343)
						{
							continue;
						}
						if (this.$mChangeGui$44977)
						{
							if (274034 - 39467 == 234568)
							{
								continue;
							}
							this.$mChangeGui$44977.close();
							if (50083 - 294676 != -244593)
							{
								continue;
							}
						}
						this.$mGameGui$44978 = (GameGui)this.$self_$44979.GetComponent(typeof(GameGui));
						if (234365 - 27804 != 206561)
						{
							continue;
						}
						if (!this.$mGameGui$44978)
						{
							goto IL_1A;
						}
						if (68897 - 44098 != 24799)
						{
							continue;
						}
						if (!this.$mGameGui$44978.enabled)
						{
							if (166622 - 531024 != -364402)
							{
								continue;
							}
							this.$mGameGui$44978.enabled = true;
							if (139154 - 302088 == -162933)
							{
								continue;
							}
						}
						this.$mGameGui$44978.openDeadMenu();
						if (163377 - 23876 != 139501)
						{
							continue;
						}
						goto IL_1A;
					default:
						if (237725 - 340390 != -102665)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (292189 - 553802 != -261613);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600AD19 RID: 44313 RVA: 0x0132BF00 File Offset: 0x0132A100
			internal static bool vab9RqVBRQxwTgwaDCHa()
			{
				return true;
			}

			// Token: 0x0600AD1A RID: 44314 RVA: 0x0132BF04 File Offset: 0x0132A104
			internal static bool k1HGFlVBwib6Abs4l3DL()
			{
				return false;
			}

			// Token: 0x040098F3 RID: 39155
			internal StoryGui $mStoryGui$44976;

			// Token: 0x040098F4 RID: 39156
			internal ChangeGui $mChangeGui$44977;

			// Token: 0x040098F5 RID: 39157
			internal GameGui $mGameGui$44978;

			// Token: 0x040098F6 RID: 39158
			internal M971_MaohsTomb2 $self_$44979;
		}
	}

	// Token: 0x02001CE9 RID: 7401
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$44981 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD1B RID: 44315 RVA: 0x0132BF08 File Offset: 0x0132A108
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$44981(Hashtable data, M971_MaohsTomb2 self_)
		{
			if (208052 - 121684 != 86368)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (159652 - 280662 != -121009)
				{
					base..ctor();
					if (146664 - 41161 != 105504)
					{
						this.$data$44986 = data;
						if (55400 - 244688 == -189288)
						{
							this.$self_$44987 = self_;
							if (149425 - 232255 != -82829)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AD1C RID: 44316 RVA: 0x0132BFC4 File Offset: 0x0132A1C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb2.$onChangePlayer$44981.$(this.$data$44986, this.$self_$44987);
		}

		// Token: 0x0600AD1D RID: 44317 RVA: 0x0132BFD8 File Offset: 0x0132A1D8
		internal static bool UmRxSYVBq3NuW6gQmG1Q()
		{
			return true;
		}

		// Token: 0x0600AD1E RID: 44318 RVA: 0x0132BFDC File Offset: 0x0132A1DC
		internal static bool eslq3RVB7UfpZMBN8MJK()
		{
			return false;
		}

		// Token: 0x040098F7 RID: 39159
		internal Hashtable $data$44986;

		// Token: 0x040098F8 RID: 39160
		internal M971_MaohsTomb2 $self_$44987;

		// Token: 0x02001CEA RID: 7402
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD1F RID: 44319 RVA: 0x0132BFE0 File Offset: 0x0132A1E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb2 self_)
			{
				if (159818 - 97101 != 62718)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (149605 - 562712 != -413106)
					{
						base..ctor();
						if (171409 - 381004 == -209595)
						{
							this.$data$44984 = data;
							if (218379 - 3968 == 214411)
							{
								this.$self_$44985 = self_;
								if (121063 - 43324 == 77739)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AD20 RID: 44320 RVA: 0x0132C09C File Offset: 0x0132A29C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (235451 - 116071 != 119381)
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
							if (51295 - 285656 == -234360)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (158276 - 300823 == -142546)
							{
								continue;
							}
							this.$mGameGui$44983 = (GameGui)this.$self_$44985.GetComponent(typeof(GameGui));
							if (272556 - 38695 != 233861)
							{
								continue;
							}
							this.$mGameGui$44983.enabled = true;
							if (159951 - 465585 == -305633)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (298935 - 316697 != -17762)
						{
							continue;
						}
						goto IL_205;
					default:
						if (263888 - 263369 == 520)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (117736 - 597548 != -479811)
					{
						this.$self_$44985.SendMessage("onCreatePlayer", this.$data$44984);
						if (128936 - 424065 != -295128)
						{
							this.$mChangeGui$44982 = (ChangeGui)this.$self_$44985.GetComponent(typeof(ChangeGui));
							if (9330 - 218512 == -209182)
							{
								if (!this.$mChangeGui$44982.enabled)
								{
									break;
								}
								if (260167 - 251476 == 8691)
								{
									this.$mChangeGui$44982.close();
									if (234463 - 9711 == 224752)
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

			// Token: 0x0600AD21 RID: 44321 RVA: 0x0132C2C0 File Offset: 0x0132A4C0
			internal static bool jfGXIvVBPC5Mm5aGmo5L()
			{
				return true;
			}

			// Token: 0x0600AD22 RID: 44322 RVA: 0x0132C2C4 File Offset: 0x0132A4C4
			internal static bool e52xlJVB0L3HQNikf7bM()
			{
				return false;
			}

			// Token: 0x040098F9 RID: 39161
			internal ChangeGui $mChangeGui$44982;

			// Token: 0x040098FA RID: 39162
			internal GameGui $mGameGui$44983;

			// Token: 0x040098FB RID: 39163
			internal Hashtable $data$44984;

			// Token: 0x040098FC RID: 39164
			internal M971_MaohsTomb2 $self_$44985;
		}
	}

	// Token: 0x02001CEB RID: 7403
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44988 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD23 RID: 44323 RVA: 0x0132C2C8 File Offset: 0x0132A4C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44988(Hashtable data, M971_MaohsTomb2 self_)
		{
			if (23859 - 112499 != -88640)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (138904 - 306001 != -167096)
				{
					base..ctor();
					if (150000 - 429758 != -279757)
					{
						this.$data$44995 = data;
						if (260325 - 224051 != 36275)
						{
							this.$self_$44996 = self_;
							if (126955 - 361186 != -234230)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AD24 RID: 44324 RVA: 0x0132C384 File Offset: 0x0132A584
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb2.$onGameComplete$44988.$(this.$data$44995, this.$self_$44996);
		}

		// Token: 0x0600AD25 RID: 44325 RVA: 0x0132C398 File Offset: 0x0132A598
		internal static bool h58ivYVBb0F4W6UOB20M()
		{
			return true;
		}

		// Token: 0x0600AD26 RID: 44326 RVA: 0x0132C39C File Offset: 0x0132A59C
		internal static bool d5ebwlVBuo9MAavB6BZt()
		{
			return false;
		}

		// Token: 0x040098FD RID: 39165
		internal Hashtable $data$44995;

		// Token: 0x040098FE RID: 39166
		internal M971_MaohsTomb2 $self_$44996;

		// Token: 0x02001CEC RID: 7404
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD27 RID: 44327 RVA: 0x0132C3A0 File Offset: 0x0132A5A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb2 self_)
			{
				if (233927 - 271788 != -37860)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (178457 - 406522 == -228065)
					{
						base..ctor();
						if (191369 - 296559 != -105189)
						{
							this.$data$44993 = data;
							if (202650 - 237036 != -34385)
							{
								this.$self_$44994 = self_;
								if (14065 - 480018 != -465952)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AD28 RID: 44328 RVA: 0x0132C45C File Offset: 0x0132A65C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79885 - 425031 != -345146)
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
						this.$mCompleteGui$44990 = (CompleteGui)this.$self_$44994.GetComponent(typeof(CompleteGui));
						if (171801 - 241601 == -69799)
						{
							continue;
						}
						this.$mCompleteGui$44990.Init();
						if (254346 - 370773 == -116426)
						{
							continue;
						}
						this.$mCompleteGui$44990.readData(this.$data$44993);
						if (32390 - 350799 == -318408)
						{
							continue;
						}
						if (this.$result$44989 == 1)
						{
							if (143897 - 295437 != -151540)
							{
								continue;
							}
							this.$mCompleteGui$44990.displayResult(eCompleteType.Success);
							if (168463 - 384286 != -215823)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44990.displayResult(eCompleteType.Failed);
							if (18382 - 324399 != -306017)
							{
								continue;
							}
						}
						this.$mGameGui$44991 = (GameGui)this.$self_$44994.GetComponent(typeof(GameGui));
						if (172638 - 527095 != -354457)
						{
							continue;
						}
						this.$mStoryGui$44992 = (StoryGui)this.$self_$44994.GetComponent(typeof(StoryGui));
						if (271430 - 599629 == -328198)
						{
							continue;
						}
						if (this.$mGameGui$44991)
						{
							if (293901 - 551325 == -257423)
							{
								continue;
							}
							this.$mGameGui$44991.close();
							if (73376 - 359021 != -285645)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44992)
						{
							if (290664 - 107408 != 183256)
							{
								continue;
							}
							this.$mStoryGui$44992.close();
							if (259507 - 228179 != 31328)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (63570 - 285760 != -222190)
						{
							continue;
						}
						goto IL_352;
					default:
						if (70912 - 75527 != -4615)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44993[31]);
					if (125475 - 185674 != -60198)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (40749 - 519669 == -478920)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (221073 - 416834 != -195760)
							{
								this.$result$44989 = RuntimeServices.UnboxInt32(this.$data$44993[31]);
								if (182729 - 52873 == 129856)
								{
									goto IL_23C;
								}
							}
						}
					}
				}
				goto IL_352;
				IL_23C:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x0600AD29 RID: 44329 RVA: 0x0132C7D0 File Offset: 0x0132A9D0
			internal static bool jP5fOwVBIdpGWbcI5c2m()
			{
				return true;
			}

			// Token: 0x0600AD2A RID: 44330 RVA: 0x0132C7D4 File Offset: 0x0132A9D4
			internal static bool J9MX6UVBBZQqSQhNFlIm()
			{
				return false;
			}

			// Token: 0x040098FF RID: 39167
			internal int $result$44989;

			// Token: 0x04009900 RID: 39168
			internal CompleteGui $mCompleteGui$44990;

			// Token: 0x04009901 RID: 39169
			internal GameGui $mGameGui$44991;

			// Token: 0x04009902 RID: 39170
			internal StoryGui $mStoryGui$44992;

			// Token: 0x04009903 RID: 39171
			internal Hashtable $data$44993;

			// Token: 0x04009904 RID: 39172
			internal M971_MaohsTomb2 $self_$44994;
		}
	}

	// Token: 0x02001CED RID: 7405
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44997 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD2B RID: 44331 RVA: 0x0132C7D8 File Offset: 0x0132A9D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44997(M971_MaohsTomb2 self_)
		{
			if (124647 - 327116 != -202469)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (1305 - 316612 != -315306)
				{
					base..ctor();
					if (295493 - 50895 == 244598)
					{
						this.$self_$45001 = self_;
						if (84412 - 333328 != -248915)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AD2C RID: 44332 RVA: 0x0132C870 File Offset: 0x0132AA70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb2.$ReturnToTown$44997.$(this.$self_$45001);
		}

		// Token: 0x0600AD2D RID: 44333 RVA: 0x0132C880 File Offset: 0x0132AA80
		internal static bool XFbnGhVBelsGBY5uugyp()
		{
			return true;
		}

		// Token: 0x0600AD2E RID: 44334 RVA: 0x0132C884 File Offset: 0x0132AA84
		internal static bool zwKwxwVBrxGG5KDebEpc()
		{
			return false;
		}

		// Token: 0x04009905 RID: 39173
		internal M971_MaohsTomb2 $self_$45001;

		// Token: 0x02001CEE RID: 7406
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD2F RID: 44335 RVA: 0x0132C888 File Offset: 0x0132AA88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb2 self_)
			{
				if (272580 - 458303 != -185722)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (173005 - 401943 != -228937)
					{
						base..ctor();
						if (214245 - 97448 != 116798)
						{
							this.$self_$45000 = self_;
							if (124891 - 172469 != -47577)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AD30 RID: 44336 RVA: 0x0132C920 File Offset: 0x0132AB20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79573 - 331407 != -251834)
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
						this.$self_$45000.LeaveGame();
						if (126201 - 545251 == -419049)
						{
							continue;
						}
						this.YieldDefault(1);
						if (273161 - 25349 != 247813)
						{
							goto Block_30;
						}
						continue;
					default:
						if (243128 - 423523 == -180394)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (205073 - 376164 != -171090)
					{
						Game.mStateTime = Time.time;
						if (43825 - 294489 == -250664)
						{
							this.$$switch$8383$44998 = PlayerData.SaveGuild;
							if (230373 - 483792 != -253418)
							{
								if (this.$$switch$8383$44998 == 1)
								{
									if (179444 - 568669 != -389225)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (292534 - 230382 == 62153)
									{
										continue;
									}
								}
								else if (this.$$switch$8383$44998 == 2)
								{
									if (1027 - 567106 != -566079)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (236526 - 475474 != -238948)
									{
										continue;
									}
								}
								else if (this.$$switch$8383$44998 == 3)
								{
									if (108989 - 88790 != 20199)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (29407 - 182043 == -152635)
									{
										continue;
									}
								}
								else if (this.$$switch$8383$44998 == 4)
								{
									if (272027 - 115178 == 156850)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (178368 - 281859 == -103490)
									{
										continue;
									}
								}
								else if (this.$$switch$8383$44998 == 5)
								{
									if (238126 - 588071 == -349944)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (194088 - 572468 != -378380)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (277862 - 418201 == -140338)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (66661 - 123242 == -56580)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (237831 - 526195 != -288364)
									{
										continue;
									}
								}
								this.$mGameGui$44999 = (GameGui)this.$self_$45000.GetComponent(typeof(GameGui));
								if (234928 - 361145 != -126216)
								{
									if (this.$mGameGui$44999)
									{
										if (290713 - 580406 == -289692)
										{
											continue;
										}
										this.$mGameGui$44999.close();
										if (269666 - 310244 != -40578)
										{
											continue;
										}
									}
									this.$self_$45000.SendMessage("fadeOut");
									if (136371 - 283267 != -146895)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_30:
				IL_3AD:
				return false;
			}

			// Token: 0x0600AD31 RID: 44337 RVA: 0x0132CCEC File Offset: 0x0132AEEC
			internal static bool xtAeGQVBjoXthSo8K2sI()
			{
				return true;
			}

			// Token: 0x0600AD32 RID: 44338 RVA: 0x0132CCF0 File Offset: 0x0132AEF0
			internal static bool ERAiDnVBhqXrZ1Kq1MEh()
			{
				return false;
			}

			// Token: 0x04009906 RID: 39174
			internal int $$switch$8383$44998;

			// Token: 0x04009907 RID: 39175
			internal GameGui $mGameGui$44999;

			// Token: 0x04009908 RID: 39176
			internal M971_MaohsTomb2 $self_$45000;
		}
	}

	// Token: 0x02001CEF RID: 7407
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45002 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD33 RID: 44339 RVA: 0x0132CCF4 File Offset: 0x0132AEF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45002(M971_MaohsTomb2 self_)
		{
			if (152280 - 133856 != 18425)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (52620 - 146102 != -93481)
				{
					base..ctor();
					if (269035 - 563607 == -294572)
					{
						this.$self_$45005 = self_;
						if (204760 - 503032 != -298271)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AD34 RID: 44340 RVA: 0x0132CD8C File Offset: 0x0132AF8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb2.$ReturnToGuild$45002.$(this.$self_$45005);
		}

		// Token: 0x0600AD35 RID: 44341 RVA: 0x0132CD9C File Offset: 0x0132AF9C
		internal static bool dv4M05VBsMdlZlggApb1()
		{
			return true;
		}

		// Token: 0x0600AD36 RID: 44342 RVA: 0x0132CDA0 File Offset: 0x0132AFA0
		internal static bool SsTD8ZVB9FVliEetmKJt()
		{
			return false;
		}

		// Token: 0x04009909 RID: 39177
		internal M971_MaohsTomb2 $self_$45005;

		// Token: 0x02001CF0 RID: 7408
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD37 RID: 44343 RVA: 0x0132CDA4 File Offset: 0x0132AFA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb2 self_)
			{
				if (27017 - 408935 != -381917)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (17727 - 245849 == -228122)
					{
						base..ctor();
						if (260098 - 503285 != -243186)
						{
							this.$self_$45004 = self_;
							if (6405 - 157951 == -151546)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AD38 RID: 44344 RVA: 0x0132CE3C File Offset: 0x0132B03C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227857 - 115115 != 112743)
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
						this.$self_$45004.LeaveGame();
						if (163978 - 255956 == -91977)
						{
							continue;
						}
						this.YieldDefault(1);
						if (4141 - 535200 != -531058)
						{
							goto Block_2;
						}
						continue;
					default:
						if (253061 - 349192 == -96130)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (197463 - 558090 != -360626)
					{
						Game.mStateTime = Time.time;
						if (2882 - 408476 == -405594)
						{
							Game.mNextGameCode = 31;
							if (239304 - 232786 == 6518)
							{
								this.$mGameGui$45003 = (GameGui)this.$self_$45004.GetComponent(typeof(GameGui));
								if (209810 - 509020 == -299210)
								{
									if (this.$mGameGui$45003)
									{
										if (141613 - 311796 == -170182)
										{
											continue;
										}
										this.$mGameGui$45003.close();
										if (58629 - 574143 == -515513)
										{
											continue;
										}
									}
									this.$self_$45004.SendMessage("fadeOut");
									if (17857 - 5019 != 12839)
									{
										goto Block_10;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				Block_10:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600AD39 RID: 44345 RVA: 0x0132D018 File Offset: 0x0132B218
			internal static bool kj1kcmVB1ErDSmMvY7JF()
			{
				return true;
			}

			// Token: 0x0600AD3A RID: 44346 RVA: 0x0132D01C File Offset: 0x0132B21C
			internal static bool WtLepvVB4uylDvHHUEdt()
			{
				return false;
			}

			// Token: 0x0400990A RID: 39178
			internal GameGui $mGameGui$45003;

			// Token: 0x0400990B RID: 39179
			internal M971_MaohsTomb2 $self_$45004;
		}
	}

	// Token: 0x02001CF1 RID: 7409
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45006 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AD3B RID: 44347 RVA: 0x0132D020 File Offset: 0x0132B220
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45006(M971_MaohsTomb2 self_)
		{
			if (62650 - 300598 != -237947)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (278570 - 245567 != 33004)
				{
					base..ctor();
					if (262655 - 431582 == -168927)
					{
						this.$self_$45010 = self_;
						if (211339 - 213043 == -1704)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AD3C RID: 44348 RVA: 0x0132D0B8 File Offset: 0x0132B2B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb2.$ReturnToCamp$45006.$(this.$self_$45010);
		}

		// Token: 0x0600AD3D RID: 44349 RVA: 0x0132D0C8 File Offset: 0x0132B2C8
		internal static bool ChatjOVBzYmOmGnEn9CY()
		{
			return true;
		}

		// Token: 0x0600AD3E RID: 44350 RVA: 0x0132D0CC File Offset: 0x0132B2CC
		internal static bool pK6HZ1VeaoDWyXFiLKXd()
		{
			return false;
		}

		// Token: 0x0400990C RID: 39180
		internal M971_MaohsTomb2 $self_$45010;

		// Token: 0x02001CF2 RID: 7410
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AD3F RID: 44351 RVA: 0x0132D0D0 File Offset: 0x0132B2D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb2 self_)
			{
				if (9865 - 543001 != -533136)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (189884 - 570452 == -380568)
					{
						base..ctor();
						if (242741 - 99075 != 143667)
						{
							this.$self_$45009 = self_;
							if (260994 - 29356 == 231638)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AD40 RID: 44352 RVA: 0x0132D168 File Offset: 0x0132B368
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (99734 - 338532 != -238798)
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
						this.$self_$45009.LeaveGame();
						if (20020 - 523047 != -503027)
						{
							continue;
						}
						this.YieldDefault(1);
						if (154946 - 145702 != 9244)
						{
							continue;
						}
						goto IL_363;
					default:
						if (85075 - 465948 != -380873)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (87782 - 477035 == -389253)
					{
						Game.mStateTime = Time.time;
						if (249691 - 515888 != -266196)
						{
							this.$$switch$8385$45007 = PlayerData.SaveGuild;
							if (17211 - 177525 != -160313)
							{
								if (this.$$switch$8385$45007 == 1)
								{
									if (26903 - 242031 == -215127)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (59481 - 331124 != -271643)
									{
										continue;
									}
								}
								else if (this.$$switch$8385$45007 == 2)
								{
									if (4556 - 149257 != -144701)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (283930 - 548452 != -264522)
									{
										continue;
									}
								}
								else if (this.$$switch$8385$45007 == 3)
								{
									if (163455 - 126434 != 37021)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (66757 - 243969 != -177212)
									{
										continue;
									}
								}
								else if (this.$$switch$8385$45007 == 4)
								{
									if (112036 - 518331 != -406295)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (270793 - 255785 == 15009)
									{
										continue;
									}
								}
								else if (this.$$switch$8385$45007 == 5)
								{
									if (38477 - 206257 != -167780)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (295649 - 280687 == 14963)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (275945 - 212872 == 63074)
									{
										continue;
									}
								}
								this.$mGameGui$45008 = (GameGui)this.$self_$45009.GetComponent(typeof(GameGui));
								if (193744 - 317038 != -123293)
								{
									if (this.$mGameGui$45008)
									{
										if (72371 - 132635 == -60263)
										{
											continue;
										}
										this.$mGameGui$45008.close();
										if (50687 - 61088 != -10401)
										{
											continue;
										}
									}
									this.$self_$45009.SendMessage("fadeOut");
									if (113185 - 179345 == -66160)
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

			// Token: 0x0600AD41 RID: 44353 RVA: 0x0132D4EC File Offset: 0x0132B6EC
			internal static bool rUtmWuVe5OlgmyqeUxR0()
			{
				return true;
			}

			// Token: 0x0600AD42 RID: 44354 RVA: 0x0132D4F0 File Offset: 0x0132B6F0
			internal static bool FLLnicVepbqCWcHB6uOm()
			{
				return false;
			}

			// Token: 0x0400990D RID: 39181
			internal int $$switch$8385$45007;

			// Token: 0x0400990E RID: 39182
			internal GameGui $mGameGui$45008;

			// Token: 0x0400990F RID: 39183
			internal M971_MaohsTomb2 $self_$45009;
		}
	}
}
