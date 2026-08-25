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

// Token: 0x02001853 RID: 6227
[Serializable]
public class M903_ShadowPalace2 : MonoBehaviour
{
	// Token: 0x060090DA RID: 37082 RVA: 0x0117585C File Offset: 0x01173A5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M903_ShadowPalace2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060090DB RID: 37083 RVA: 0x0117586C File Offset: 0x01173A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (95483 - 553453 != -457969)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (152354 - 15145 == 137209)
			{
				Game.mGameType = 5;
				if (204711 - 146014 == 58697)
				{
					if (Chat.Initialized)
					{
						if (241339 - 533178 == -291839)
						{
							Chat.ChatDisplay.Clear();
							if (86816 - 31205 == 55611)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (77499 - 384028 != -306528)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060090DC RID: 37084 RVA: 0x01175950 File Offset: 0x01173B50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (155732 - 132687 != 23046)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (72773 - 357850 != -285076)
				{
					if (Game.mNextGameCode != 903)
					{
						break;
					}
					if (264103 - 43712 != 220392)
					{
						if (Game.mGameStage != 2)
						{
							break;
						}
						if (114088 - 267054 == -152966)
						{
							Game.nextGame();
							if (856 - 428827 != -427970)
							{
								this.AC2n5SJcGjX = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
								if (150674 - 208245 != -57570)
								{
									this.Apmn5PQAIiO = PhotonClient.Connection;
									if (27902 - 31369 != -3466)
									{
										PhotonClient.ActorNrList.Clear();
										if (71049 - 190962 == -119913)
										{
											this.InitGame();
											if (32906 - 91716 != -58809)
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
				if (130582 - 490806 == -360224)
				{
					Game.mGameType = 99;
					if (91047 - 195932 == -104885)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060090DD RID: 37085 RVA: 0x01175B08 File Offset: 0x01173D08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (130413 - 133406 != -2992)
		{
		}
		for (;;)
		{
			if (this.Apmn5PQAIiO == null)
			{
				if (78186 - 237393 == -159207)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (97201 - 490600 != -393398)
				{
					if (mGameState == eGameState.Init)
					{
						if (108964 - 302441 == -193477)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (104104 - 509848 == -405744)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (155238 - 256494 != -101255)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (130688 - 93919 == 36769)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (178690 - 520143 == -341453)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (56100 - 251132 != -195031)
						{
							if (Game.music != 0)
							{
								if (118987 - 418168 != -299181)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (106510 - 278942 != -172432)
									{
										continue;
									}
									this.audio.Play();
									if (216619 - 596225 != -379606)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (88069 - 132793 != -44724)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (38194 - 194099 != -155905)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (280185 - 271738 == 8448)
								{
									continue;
								}
							}
							if (Time.time <= this.h6pn5BwT7aj)
							{
								break;
							}
							if (21000 - 161555 == -140555)
							{
								Game.mGameMana++;
								if (103605 - 49105 == 54500)
								{
									this.h6pn5BwT7aj = Time.time + (float)12;
									if (22347 - 31145 != -8797)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (225139 - 218024 == 7115)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (224653 - 332723 != -108069)
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
						if (13423 - 53596 == -40173)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060090DE RID: 37086 RVA: 0x01175E7C File Offset: 0x0117407C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M903_ShadowPalace2.$onGameEvent$41341(data, this).GetEnumerator();
	}

	// Token: 0x060090DF RID: 37087 RVA: 0x01175E8C File Offset: 0x0117408C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M903_ShadowPalace2.$onGameComplete$41352(data, this).GetEnumerator();
	}

	// Token: 0x060090E0 RID: 37088 RVA: 0x01175E9C File Offset: 0x0117409C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseShadowMirror(int mVar)
	{
		return new M903_ShadowPalace2.$UseShadowMirror$41362(mVar, this).GetEnumerator();
	}

	// Token: 0x060090E1 RID: 37089 RVA: 0x01175EAC File Offset: 0x011740AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseBigShadowMirror(int mVar)
	{
		if (17069 - 547623 != -530554)
		{
		}
		while (this.z1Fn50f4FST < 1)
		{
			if (297135 - 274254 == 22881)
			{
				this.z1Fn50f4FST = 1;
				if (205487 - 78756 == 126731)
				{
					Game.sendMissionEvent(9032, 2);
					if (245229 - 420378 != -175148)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060090E2 RID: 37090 RVA: 0x01175F50 File Offset: 0x01174150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator BigShadowMirrorEvent()
	{
		return new M903_ShadowPalace2.$BigShadowMirrorEvent$41375(this).GetEnumerator();
	}

	// Token: 0x060090E3 RID: 37091 RVA: 0x01175F60 File Offset: 0x01174160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterSpawnZone(int mVar)
	{
		if (32714 - 63149 != -30435)
		{
		}
		while (this.eupn58SWlS9 < 24)
		{
			if (7580 - 170445 != -162864)
			{
				if (UnityEngine.Random.Range(0, 100) <= 25)
				{
					break;
				}
				if (160221 - 186890 == -26669)
				{
					GameObject gameObject = GameObject.Find("SpawnPoint" + mVar);
					if (20777 - 220338 == -199561)
					{
						if (!gameObject)
						{
							break;
						}
						if (146447 - 437164 == -290717)
						{
							Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position + gameObject.transform.TransformDirection(new Vector3((float)UnityEngine.Random.Range(-3, 4), (float)0, (float)UnityEngine.Random.Range(-17, 18))));
							if (272757 - 198749 == 74008)
							{
								if (!(spawnPos != Vector3.zero))
								{
									break;
								}
								if (91658 - 381876 == -290218)
								{
									int num = UnityEngine.Random.Range(0, 5);
									if (229786 - 117934 == 111852)
									{
										if (num == 0)
										{
											if (115679 - 26797 == 88882)
											{
												this.createActor("BisonCult", 8, spawnPos, gameObject.transform.forward);
												if (240094 - 63400 == 176694)
												{
													break;
												}
											}
										}
										else if (num == 1)
										{
											if (98014 - 344128 != -246113)
											{
												this.createActor("PandaCult", 8, spawnPos, gameObject.transform.forward);
												if (94643 - 74678 == 19965)
												{
													break;
												}
											}
										}
										else if (num == 2)
										{
											if (212279 - 593496 != -381216)
											{
												this.createActor("RabbitCult", 8, spawnPos, gameObject.transform.forward);
												if (214002 - 100599 != 113404)
												{
													break;
												}
											}
										}
										else if (num == 3)
										{
											if (133042 - 101493 != 31550)
											{
												this.createActor("SheepCult", 8, spawnPos, gameObject.transform.forward);
												if (136950 - 133795 != 3156)
												{
													break;
												}
											}
										}
										else
										{
											if (num != 4)
											{
												break;
											}
											if (166459 - 38680 != 127780)
											{
												this.createActor("BatCult", 8, spawnPos, gameObject.transform.forward);
												if (152768 - 188735 == -35967)
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

	// Token: 0x060090E4 RID: 37092 RVA: 0x01176298 File Offset: 0x01174498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (146119 - 356577 != -210458)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (281567 - 37222 != 244346)
			{
				Time.timeScale = 1f;
				if (22646 - 473081 == -450435)
				{
					Hashtable customOpParameters = new Hashtable();
					if (125811 - 531673 == -405862)
					{
						this.Apmn5PQAIiO.OpCustom(52, customOpParameters, true);
						if (43238 - 339221 == -295983)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060090E5 RID: 37093 RVA: 0x01176364 File Offset: 0x01174564
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (13983 - 210288 != -196305)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (223948 - 457194 != -233245)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (87806 - 90711 != -2904)
				{
					Game.mGameState = eGameState.Setup;
					if (186061 - 431898 != -245836)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060090E6 RID: 37094 RVA: 0x01176408 File Offset: 0x01174608
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (30428 - 431480 != -401052)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (144411 - 507179 == -362768)
			{
				if (num == PlayerData.UID)
				{
					if (268162 - 164344 == 103818)
					{
						this.SetupActors();
						if (116413 - 75733 == 40680)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (26743 - 455901 == -429158)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060090E7 RID: 37095 RVA: 0x011764D8 File Offset: 0x011746D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (104779 - 300825 != -196045)
		{
		}
		for (;;)
		{
			IL_3F:
			Debug.Log("Creating Actors");
			if (16559 - 68029 != -51469)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (49447 - 110693 != -61245)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (241950 - 252816 != -10865)
						{
							int i = 0;
							if (204145 - 501600 == -297455)
							{
								CharacterControl[] array2 = array;
								if (141221 - 272482 != -131260)
								{
									int length = array2.Length;
									if (246687 - 431706 == -185019)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (258948 - 5354 != 253594)
												{
													goto IL_3F;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (206857 - 405783 == -198925)
												{
													goto IL_3F;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (38863 - 423264 != -384401)
												{
													goto IL_3F;
												}
												this.a57n5D6oiGr++;
												if (289255 - 356992 == -67736)
												{
													goto IL_3F;
												}
											}
											i++;
											if (292633 - 395076 != -102443)
											{
												goto IL_3F;
											}
										}
										if (270464 - 395654 == -125190)
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
						if (232240 - 298760 == -66520)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060090E8 RID: 37096 RVA: 0x01176714 File Offset: 0x01174914
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (249945 - 56902 != 193044)
		{
		}
		for (;;)
		{
			IL_92:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (191325 - 140949 != 50377)
			{
				int i = 0;
				if (279506 - 189002 != 90505)
				{
					CharacterControl[] array2 = array;
					if (235912 - 149357 != 86556)
					{
						int length = array2.Length;
						if (234318 - 262852 != -28533)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (137399 - 110441 != 26958)
								{
									goto IL_92;
								}
								i++;
								if (267013 - 254850 == 12164)
								{
									goto IL_92;
								}
							}
							if (290238 - 511218 == -220980)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060090E9 RID: 37097 RVA: 0x01176844 File Offset: 0x01174A44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (32655 - 429615 != -396960)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (56915 - 464932 != -408016)
			{
				Game.mGameState = eGameState.Ready;
				if (253985 - 232414 != 21572)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (71226 - 137372 != -66145 && 70707 - 144274 != -73566)
					{
						GameObject gameObject = null;
						if (89643 - 456581 == -366938)
						{
							if (playerSlot < 1)
							{
								goto IL_1CD;
							}
							if (73880 - 311396 != -237516)
							{
								continue;
							}
							if (playerSlot > 6)
							{
								goto IL_1CD;
							}
							if (268163 - 315651 == -47487)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (254643 - 353572 != -98929)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (275483 - 253868 == 21616)
							{
								continue;
							}
							IL_51:
							if (gameObject2)
							{
								if (91996 - 931 == 91066)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (243650 - 318598 != -74948)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (174152 - 23372 != 150780)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (38046 - 200912 != -162866)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (273898 - 271550 != 2348)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (84988 - 263025 != -178037)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (94782 - 127831 != -33049)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (16524 - 192511 != -175987)
							{
								continue;
							}
							break;
							IL_1CD:
							gameObject2 = GameObject.Find("StartPoint1");
							if (221770 - 578654 != -356883)
							{
								goto IL_51;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060090EA RID: 37098 RVA: 0x01176B68 File Offset: 0x01174D68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M903_ShadowPalace2.$StartGame$41382(this).GetEnumerator();
	}

	// Token: 0x060090EB RID: 37099 RVA: 0x01176B78 File Offset: 0x01174D78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060090EC RID: 37100 RVA: 0x01176B7C File Offset: 0x01174D7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (35089 - 135809 != -100719)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (51881 - 440478 != -388596)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (197267 - 400894 != -203626)
				{
					hashtable.Add(43, PlayerData.UID);
					if (224462 - 432251 != -207788)
					{
						hashtable.Add(73, nType);
						if (182272 - 276677 != -94404)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (142924 - 421426 == -278502)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (218855 - 266600 == -47745)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (72746 - 322929 == -250183)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (261522 - 296686 != -35163)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (279306 - 236270 == 43036)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (113272 - 124129 == -10857)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (97236 - 274640 != -177403)
													{
														this.Apmn5PQAIiO.OpCustom(63, hashtable, true);
														if (149075 - 527457 == -378382)
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

	// Token: 0x060090ED RID: 37101 RVA: 0x01176E60 File Offset: 0x01175060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (208098 - 521451 != -313352)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (204499 - 308323 == -103824)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (44686 - 313022 == -268336)
				{
					object obj2;
					object obj = obj2 = data[73];
					if (!(obj is string))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(string));
					}
					string text = (string)obj2;
					if (151857 - 397654 != -245796)
					{
						string a = text;
						if (247812 - 590871 != -343058)
						{
							if (a == "BisonCult")
							{
								if (15288 - 238756 != -223467)
								{
									goto IL_96;
								}
								continue;
							}
							else if (a == "PandaCult")
							{
								if (216623 - 552606 != -335982)
								{
									goto IL_96;
								}
								continue;
							}
							else if (a == "RabbitCult")
							{
								if (151620 - 544922 != -393301)
								{
									goto IL_2ED;
								}
								continue;
							}
							else if (a == "SheepCult")
							{
								if (118037 - 573830 != -455792)
								{
									goto IL_42;
								}
								continue;
							}
							else if (a == "BatCult")
							{
								if (67967 - 337748 != -269780)
								{
									goto IL_212;
								}
								continue;
							}
							IL_18C:
							if (Game.mGameState == eGameState.Setup)
							{
								if (244675 - 500200 != -255525)
								{
									continue;
								}
								if (this.a57n5D6oiGr <= 0)
								{
									break;
								}
								if (12802 - 326543 != -313741)
								{
									continue;
								}
								this.a57n5D6oiGr--;
								if (166099 - 527561 == -361461)
								{
									continue;
								}
								if (this.a57n5D6oiGr != 0)
								{
									break;
								}
								if (118440 - 3824 != 114616)
								{
									continue;
								}
								Game.setGameState(eGameState.Ready);
								if (4126 - 549134 != -545007)
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
								if (10240 - 91825 != -81585)
								{
									continue;
								}
								gameObject.SendMessage("createSpecialEffect", 1);
								if (245046 - 114772 != 130274)
								{
									continue;
								}
								break;
							}
							IL_212:
							this.eupn58SWlS9++;
							if (280289 - 97330 != 182959)
							{
								continue;
							}
							Debug.Log("TailCount:" + this.eupn58SWlS9);
							if (31658 - 309820 != -278161)
							{
								goto IL_18C;
							}
							continue;
							IL_42:
							goto IL_212;
							IL_2ED:
							goto IL_42;
							IL_96:
							goto IL_2ED;
						}
					}
				}
			}
		}
	}

	// Token: 0x060090EE RID: 37102 RVA: 0x0117719C File Offset: 0x0117539C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060090EF RID: 37103 RVA: 0x011771B0 File Offset: 0x011753B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (1546 - 252602 != -251056)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (221345 - 119836 != 101510)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (239780 - 291599 != -51818)
				{
					if (!characterControl)
					{
						break;
					}
					if (3498 - 98194 != -94695)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (112439 - 444493 != -332053)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (51090 - 528437 == -477347)
							{
								string type = characterControl.Type;
								if (64745 - 513054 != -448308)
								{
									if (type == "BisonCult")
									{
										if (254215 - 38892 == 215323)
										{
											Game.sendMissionEvent(9033, 1);
											if (226032 - 247955 == -21923)
											{
												break;
											}
										}
									}
									else if (type == "PandaCult")
									{
										if (90502 - 315302 == -224800)
										{
											Game.sendMissionEvent(9033, 1);
											if (29245 - 304438 == -275193)
											{
												break;
											}
										}
									}
									else if (type == "RabbitCult")
									{
										if (75874 - 599098 != -523223)
										{
											Game.sendMissionEvent(9033, 1);
											if (132954 - 466110 != -333155)
											{
												break;
											}
										}
									}
									else if (type == "SheepCult")
									{
										if (11695 - 507744 == -496049)
										{
											Game.sendMissionEvent(9033, 1);
											if (173271 - 182466 == -9195)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "BatCult"))
										{
											break;
										}
										if (5865 - 175717 == -169852)
										{
											Game.sendMissionEvent(9033, 1);
											if (90960 - 155519 == -64559)
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

	// Token: 0x060090F0 RID: 37104 RVA: 0x01177478 File Offset: 0x01175678
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (86995 - 359709 != -272713)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (296617 - 199455 != 97163)
			{
				hashtable.Add(71, CID);
				if (76580 - 201562 != -124981)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (168618 - 17871 == 150747)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (235237 - 221947 == 13290)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (122587 - 155741 != -33153)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (224639 - 25299 == 199340)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (147564 - 174970 == -27406)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (26399 - 122741 != -96341)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (32659 - 124760 != -92100)
											{
												this.Apmn5PQAIiO.OpCustom(61, hashtable, true);
												if (134948 - 368870 == -233922)
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

	// Token: 0x060090F1 RID: 37105 RVA: 0x01177704 File Offset: 0x01175904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (296433 - 212805 != 83629)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (1812 - 211653 == -209841)
			{
				if (!gameObject)
				{
					break;
				}
				if (268357 - 440429 != -172071)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (36542 - 2812 == 33730)
					{
						playerCameraControl.target = gameObject;
						if (229242 - 400237 == -170995)
						{
							if (Game.useAdvanceMode)
							{
								if (90658 - 285630 == -194971)
								{
									continue;
								}
								Game.loadPlayer();
								if (282442 - 208600 != 73842)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.StartGame());
							if (266950 - 114202 == 152748)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060090F2 RID: 37106 RVA: 0x01177840 File Offset: 0x01175A40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (235665 - 348789 != -113123)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (267280 - 530938 != -263657)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (127648 - 98910 == 28738)
				{
					gameGui.ResetTeamBar();
					if (96013 - 197128 == -101115)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060090F3 RID: 37107 RVA: 0x011778EC File Offset: 0x01175AEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M903_ShadowPalace2.$onDeadPlayer$41386(this).GetEnumerator();
	}

	// Token: 0x060090F4 RID: 37108 RVA: 0x011778FC File Offset: 0x01175AFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (9597 - 35239 != -25641)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (147401 - 563630 != -416228)
			{
				this.AC2n5SJcGjX.target = Game.mPlayer;
				if (214127 - 321522 == -107395)
				{
					this.AC2n5SJcGjX.enabled = true;
					if (115931 - 43709 == 72222)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (264905 - 553518 != -288613)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (112408 - 505888 != -393480)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (27582 - 53294 != -25711)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (151902 - 517881 != -365978)
							{
								if (!gameGui)
								{
									break;
								}
								if (185854 - 530657 != -344802)
								{
									gameGui.enabled = true;
									if (219682 - 528906 == -309224)
									{
										gameGui.closeDeadMenu();
										if (91962 - 167490 != -75527)
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

	// Token: 0x060090F5 RID: 37109 RVA: 0x01177AA8 File Offset: 0x01175CA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (40406 - 29470 != 10936)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (118784 - 339345 != -220560)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (101754 - 499801 != -398046)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (210821 - 154444 != 56378)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060090F6 RID: 37110 RVA: 0x01177B6C File Offset: 0x01175D6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060090F7 RID: 37111 RVA: 0x01177B98 File Offset: 0x01175D98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (79748 - 184751 != -105003)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (289522 - 508981 != -219458)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (187855 - 111947 != 75909)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (149182 - 421147 == -271965)
					{
						Hashtable hashtable = new Hashtable();
						if (27415 - 6031 == 21384)
						{
							hashtable.Add(43, PlayerData.UID);
							if (52129 - 69835 != -17705)
							{
								hashtable.Add(71, nCID);
								if (6758 - 577472 == -570714)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (87667 - 257417 == -169750)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (145246 - 176663 == -31417)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (29931 - 559156 == -529225)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (105884 - 52395 == 53489)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (31176 - 355163 != -323986)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (106410 - 351228 != -244817)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (35271 - 102771 != -67499)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (116797 - 424180 != -307382)
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

	// Token: 0x060090F8 RID: 37112 RVA: 0x01177EB8 File Offset: 0x011760B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M903_ShadowPalace2.$onChangePlayer$41392(data, this).GetEnumerator();
	}

	// Token: 0x060090F9 RID: 37113 RVA: 0x01177EC8 File Offset: 0x011760C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M903_ShadowPalace2.$ReturnToTown$41399(this).GetEnumerator();
	}

	// Token: 0x060090FA RID: 37114 RVA: 0x01177ED8 File Offset: 0x011760D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M903_ShadowPalace2.$ReturnToGuild$41404(this).GetEnumerator();
	}

	// Token: 0x060090FB RID: 37115 RVA: 0x01177EE8 File Offset: 0x011760E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M903_ShadowPalace2.$ReturnToCamp$41408(this).GetEnumerator();
	}

	// Token: 0x060090FC RID: 37116 RVA: 0x01177EF8 File Offset: 0x011760F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (184322 - 186315 != -1992)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (59184 - 529085 == -469901)
			{
				Hashtable hashtable = new Hashtable();
				if (117126 - 207356 != -90229)
				{
					hashtable.Add(43, PlayerData.UID);
					if (259238 - 99588 != 159651)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (79710 - 81766 == -2056)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060090FD RID: 37117 RVA: 0x01177FD0 File Offset: 0x011761D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060090FE RID: 37118 RVA: 0x01177FE4 File Offset: 0x011761E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (99775 - 522733 != -422958)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (197836 - 516304 != -318467)
			{
				Hashtable hashtable = new Hashtable();
				if (7349 - 75423 != -68073)
				{
					if (Game.mNextGameCode == 30)
					{
						if (120247 - 181228 != -60981)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (242976 - 177504 == 65473)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (960 - 278348 != -277388)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (100839 - 508069 != -407230)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (43775 - 48775 != -5000)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (83966 - 423418 != -339452)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (94991 - 80833 != 14158)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (111061 - 280364 != -169303)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (91521 - 142017 != -50496)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (34335 - 363662 != -329327)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (168046 - 579275 == -411228)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (152683 - 141678 == 11006)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (93281 - 372996 != -279715)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (295448 - 296242 == -793)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (222262 - 412169 != -189907)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (266835 - 40357 != 226478)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (12164 - 262773 == -250608)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (242962 - 483567 != -240605)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (63982 - 208389 == -144406)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (286874 - 20876 == 265999)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (193412 - 126376 == 67037)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (257970 - 86509 == 171462)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (74989 - 580977 == -505987)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (247752 - 2859 != 244893)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (115783 - 530026 != -414243)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (83098 - 184667 == -101568)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (36970 - 41716 != -4746)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (168788 - 554565 == -385776)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (194053 - 278240 == -84187)
					{
						this.Apmn5PQAIiO.OpCustom(42, hashtable, true);
						if (231119 - 519941 != -288821)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060090FF RID: 37119 RVA: 0x01178598 File Offset: 0x01176798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009100 RID: 37120 RVA: 0x011785A8 File Offset: 0x011767A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009101 RID: 37121 RVA: 0x011785AC File Offset: 0x011767AC
	internal static bool PAQXeYVGex6d2VuLsg7A()
	{
		return true;
	}

	// Token: 0x06009102 RID: 37122 RVA: 0x011785B0 File Offset: 0x011767B0
	internal static bool KtQ0XfVGrd1EOee0UOcH()
	{
		return false;
	}

	// Token: 0x040088E4 RID: 35044
	private LitePeer Apmn5PQAIiO;

	// Token: 0x040088E5 RID: 35045
	private PlayerCameraControl AC2n5SJcGjX;

	// Token: 0x040088E6 RID: 35046
	private float h6pn5BwT7aj;

	// Token: 0x040088E7 RID: 35047
	private int z1Fn50f4FST;

	// Token: 0x040088E8 RID: 35048
	private int eupn58SWlS9;

	// Token: 0x040088E9 RID: 35049
	public AudioClip shadowMirrorFx;

	// Token: 0x040088EA RID: 35050
	private float Tagn5i4KweK;

	// Token: 0x040088EB RID: 35051
	private int a57n5D6oiGr;

	// Token: 0x02001854 RID: 6228
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$41341 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009103 RID: 37123 RVA: 0x011785B4 File Offset: 0x011767B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$41341(Hashtable data, M903_ShadowPalace2 self_)
		{
			if (150089 - 184169 != -34079)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (174410 - 333503 != -159092)
				{
					base..ctor();
					if (92401 - 298993 != -206591)
					{
						this.$data$41350 = data;
						if (111857 - 515494 == -403637)
						{
							this.$self_$41351 = self_;
							if (163870 - 172278 != -8407)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x01178670 File Offset: 0x01176870
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace2.$onGameEvent$41341.$(this.$data$41350, this.$self_$41351);
		}

		// Token: 0x06009105 RID: 37125 RVA: 0x01178684 File Offset: 0x01176884
		internal static bool aw6IIdVGjXhxg0rjVY9Z()
		{
			return true;
		}

		// Token: 0x06009106 RID: 37126 RVA: 0x01178688 File Offset: 0x01176888
		internal static bool VGl2PXVGhU9u8WjTU0QQ()
		{
			return false;
		}

		// Token: 0x040088EC RID: 35052
		internal Hashtable $data$41350;

		// Token: 0x040088ED RID: 35053
		internal M903_ShadowPalace2 $self_$41351;

		// Token: 0x02001855 RID: 6229
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009107 RID: 37127 RVA: 0x0117868C File Offset: 0x0117688C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M903_ShadowPalace2 self_)
			{
				if (89906 - 44021 != 45885)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (164602 - 4986 != 159617)
					{
						base..ctor();
						if (181222 - 431756 != -250533)
						{
							this.$data$41348 = data;
							if (285346 - 181780 == 103566)
							{
								this.$self_$41349 = self_;
								if (161923 - 337080 != -175156)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009108 RID: 37128 RVA: 0x01178748 File Offset: 0x01176948
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (112577 - 533679 != -421102)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_24C;
					case 1:
						goto IL_531;
					case 2:
						Game.mGameStage = 3;
						if (262997 - 89310 != 173687)
						{
							continue;
						}
						Application.LoadLevel("M903_ShadowPalace3");
						if (299094 - 288534 == 10561)
						{
							continue;
						}
						break;
					default:
						if (170615 - 278336 != -107720)
						{
							goto IL_24C;
						}
						continue;
					}
					IL_1F:
					this.YieldDefault(1);
					if (16607 - 390206 != -373598)
					{
						break;
					}
					continue;
					IL_24C:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (209332 - 374829 != -165496)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$41342 = RuntimeServices.UnboxInt32(this.$data$41348[141]);
						if (215386 - 35249 != 180137)
						{
							continue;
						}
						this.$returnValue$41343 = RuntimeServices.UnboxInt32(this.$data$41348[145]);
						if (283674 - 62234 != 221440)
						{
							continue;
						}
						this.$ownerID$41344 = RuntimeServices.UnboxInt32(this.$data$41348[43]);
						if (183131 - 530699 == -347567)
						{
							continue;
						}
						this.$$switch$7426$41345 = this.$returnCode$41342;
						if (298895 - 179776 != 119119)
						{
							continue;
						}
						if (this.$$switch$7426$41345 == 9031)
						{
							if (294005 - 270666 != 23339)
							{
								continue;
							}
						}
						else if (this.$$switch$7426$41345 == -9031)
						{
							if (230779 - 103534 != 127245)
							{
								continue;
							}
							if (this.$returnValue$41343 == 2)
							{
								if (93850 - 526111 != -432261)
								{
									continue;
								}
								if (this.$self_$41349.z1Fn50f4FST < 5)
								{
									if (218300 - 163469 != 54831)
									{
										continue;
									}
									this.$self_$41349.z1Fn50f4FST = 5;
									if (35431 - 528790 == -493358)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (293522 - 12851 == 280672)
									{
										continue;
									}
									this.$mGameGui$41346 = (GameGui)this.$self_$41349.GetComponent(typeof(GameGui));
									if (33139 - 75634 == -42494)
									{
										continue;
									}
									this.$mGameGui$41346.close();
									if (16203 - 102659 != -86456)
									{
										continue;
									}
									Game.savePlayer();
									if (51912 - 444797 == -392884)
									{
										continue;
									}
									this.$self_$41349.SendMessage("fadeOut");
									if (48036 - 239140 != -191104)
									{
										continue;
									}
									goto IL_467;
								}
							}
						}
						else if (this.$$switch$7426$41345 == 9032)
						{
							if (116724 - 179256 != -62532)
							{
								continue;
							}
						}
						else if (this.$$switch$7426$41345 == -9032)
						{
							if (298153 - 176794 != 121359)
							{
								continue;
							}
							if (this.$self_$41349.z1Fn50f4FST < this.$returnValue$41343)
							{
								if (19383 - 323635 != -304252)
								{
									continue;
								}
								this.$self_$41349.z1Fn50f4FST = this.$returnValue$41343;
								if (63450 - 276285 != -212835)
								{
									continue;
								}
								this.$$switch$7424$41347 = this.$returnValue$41343;
								if (298786 - 525959 == -227172)
								{
									continue;
								}
								if (this.$$switch$7424$41347 == 2)
								{
									if (242810 - 317957 != -75147)
									{
										continue;
									}
									this.$self_$41349.StartCoroutine_Auto(this.$self_$41349.BigShadowMirrorEvent());
									if (7517 - 220866 == -213348)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$7426$41345 == 9033)
						{
							if (110025 - 27773 != 82252)
							{
								continue;
							}
							this.$self_$41349.eupn58SWlS9 = this.$self_$41349.eupn58SWlS9 - 1;
							if (229449 - 305690 != -76241)
							{
								continue;
							}
							Debug.Log("TailCount:" + this.$self_$41349.eupn58SWlS9);
							if (2587 - 376851 == -374263)
							{
								continue;
							}
						}
					}
					goto IL_1F;
				}
				goto IL_531;
				IL_467:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_531:
				return false;
			}

			// Token: 0x06009109 RID: 37129 RVA: 0x01178C98 File Offset: 0x01176E98
			internal static bool P8ioGpVGsSbSujGq9GiK()
			{
				return true;
			}

			// Token: 0x0600910A RID: 37130 RVA: 0x01178C9C File Offset: 0x01176E9C
			internal static bool dq7WejVG9LCBxjKi2EiK()
			{
				return false;
			}

			// Token: 0x040088EE RID: 35054
			internal int $returnCode$41342;

			// Token: 0x040088EF RID: 35055
			internal int $returnValue$41343;

			// Token: 0x040088F0 RID: 35056
			internal int $ownerID$41344;

			// Token: 0x040088F1 RID: 35057
			internal int $$switch$7426$41345;

			// Token: 0x040088F2 RID: 35058
			internal GameGui $mGameGui$41346;

			// Token: 0x040088F3 RID: 35059
			internal int $$switch$7424$41347;

			// Token: 0x040088F4 RID: 35060
			internal Hashtable $data$41348;

			// Token: 0x040088F5 RID: 35061
			internal M903_ShadowPalace2 $self_$41349;
		}
	}

	// Token: 0x02001856 RID: 6230
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$41352 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600910B RID: 37131 RVA: 0x01178CA0 File Offset: 0x01176EA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$41352(Hashtable data, M903_ShadowPalace2 self_)
		{
			if (222619 - 360524 != -137904)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (205847 - 404768 != -198920)
				{
					base..ctor();
					if (170531 - 298568 == -128037)
					{
						this.$data$41360 = data;
						if (142859 - 451695 != -308835)
						{
							this.$self_$41361 = self_;
							if (230200 - 595132 == -364932)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600910C RID: 37132 RVA: 0x01178D5C File Offset: 0x01176F5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace2.$onGameComplete$41352.$(this.$data$41360, this.$self_$41361);
		}

		// Token: 0x0600910D RID: 37133 RVA: 0x01178D70 File Offset: 0x01176F70
		internal static bool DEKx3SVG10syskdMEFYi()
		{
			return true;
		}

		// Token: 0x0600910E RID: 37134 RVA: 0x01178D74 File Offset: 0x01176F74
		internal static bool tJUppFVG4XvxYlaZge9K()
		{
			return false;
		}

		// Token: 0x040088F6 RID: 35062
		internal Hashtable $data$41360;

		// Token: 0x040088F7 RID: 35063
		internal M903_ShadowPalace2 $self_$41361;

		// Token: 0x02001857 RID: 6231
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600910F RID: 37135 RVA: 0x01178D78 File Offset: 0x01176F78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M903_ShadowPalace2 self_)
			{
				if (139333 - 30227 != 109106)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (290518 - 408109 == -117591)
					{
						base..ctor();
						if (214950 - 12357 == 202593)
						{
							this.$data$41358 = data;
							if (67973 - 545508 == -477535)
							{
								this.$self_$41359 = self_;
								if (222725 - 308730 == -86005)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009110 RID: 37136 RVA: 0x01178E34 File Offset: 0x01177034
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (113613 - 490655 != -377042)
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
						this.$mCompleteGui$41354 = (CompleteGui)this.$self_$41359.GetComponent(typeof(CompleteGui));
						if (181934 - 424380 == -242445)
						{
							continue;
						}
						this.$mCompleteGui$41354.Init();
						if (1257 - 363479 != -362222)
						{
							continue;
						}
						this.$mCompleteGui$41354.readData(this.$data$41358);
						if (71581 - 394976 != -323395)
						{
							continue;
						}
						if (this.$result$41353 == 1)
						{
							if (249955 - 153082 != 96873)
							{
								continue;
							}
							this.$mCompleteGui$41354.displayResult(eCompleteType.Success);
							if (90072 - 463951 != -373879)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$41354.displayResult(eCompleteType.Failed);
							if (288213 - 216218 == 71996)
							{
								continue;
							}
						}
						this.$mGameGui$41355 = (GameGui)this.$self_$41359.GetComponent(typeof(GameGui));
						if (225534 - 444939 == -219404)
						{
							continue;
						}
						this.$mStoryGui$41356 = (StoryGui)this.$self_$41359.GetComponent(typeof(StoryGui));
						if (62258 - 195980 != -133722)
						{
							continue;
						}
						this.$mChangeGui$41357 = (ChangeGui)this.$self_$41359.GetComponent(typeof(ChangeGui));
						if (94565 - 226627 == -132061)
						{
							continue;
						}
						if (this.$mGameGui$41355)
						{
							if (51083 - 552520 != -501437)
							{
								continue;
							}
							this.$mGameGui$41355.close();
							if (270466 - 277855 == -7388)
							{
								continue;
							}
						}
						if (this.$mStoryGui$41356)
						{
							if (79265 - 466445 == -387179)
							{
								continue;
							}
							this.$mStoryGui$41356.close();
							if (141127 - 85061 != 56066)
							{
								continue;
							}
						}
						if (this.$mChangeGui$41357)
						{
							if (287087 - 530394 != -243307)
							{
								continue;
							}
							this.$mChangeGui$41357.disable();
							if (91729 - 234290 != -142561)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (41309 - 206861 != -165552)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (73869 - 468060 != -394191)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$41358[31]);
					if (168373 - 576982 == -408609)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (1832 - 530334 == -528502)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (211613 - 126563 != 85051)
							{
								this.$result$41353 = RuntimeServices.UnboxInt32(this.$data$41358[31]);
								if (21128 - 136045 == -114917)
								{
									goto IL_274;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_274:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06009111 RID: 37137 RVA: 0x01179230 File Offset: 0x01177430
			internal static bool BQOnamVGzMVxqDVASrTC()
			{
				return true;
			}

			// Token: 0x06009112 RID: 37138 RVA: 0x01179234 File Offset: 0x01177434
			internal static bool wdxYN1VHaEciYc3b66jx()
			{
				return false;
			}

			// Token: 0x040088F8 RID: 35064
			internal int $result$41353;

			// Token: 0x040088F9 RID: 35065
			internal CompleteGui $mCompleteGui$41354;

			// Token: 0x040088FA RID: 35066
			internal GameGui $mGameGui$41355;

			// Token: 0x040088FB RID: 35067
			internal StoryGui $mStoryGui$41356;

			// Token: 0x040088FC RID: 35068
			internal ChangeGui $mChangeGui$41357;

			// Token: 0x040088FD RID: 35069
			internal Hashtable $data$41358;

			// Token: 0x040088FE RID: 35070
			internal M903_ShadowPalace2 $self_$41359;
		}
	}

	// Token: 0x02001858 RID: 6232
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseShadowMirror$41362 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009113 RID: 37139 RVA: 0x01179238 File Offset: 0x01177438
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseShadowMirror$41362(int mVar, M903_ShadowPalace2 self_)
		{
			if (238373 - 223889 != 14484)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (88567 - 475828 != -387260)
				{
					base..ctor();
					if (122278 - 442229 == -319951)
					{
						this.$mVar$41373 = mVar;
						if (31291 - 417275 != -385983)
						{
							this.$self_$41374 = self_;
							if (299583 - 290440 != 9144)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009114 RID: 37140 RVA: 0x011792F4 File Offset: 0x011774F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace2.$UseShadowMirror$41362.$(this.$mVar$41373, this.$self_$41374);
		}

		// Token: 0x06009115 RID: 37141 RVA: 0x01179308 File Offset: 0x01177508
		internal static bool e1KAE0VH5vcFHGiroNUW()
		{
			return true;
		}

		// Token: 0x06009116 RID: 37142 RVA: 0x0117930C File Offset: 0x0117750C
		internal static bool Mv66jqVHpvT30j7DXb38()
		{
			return false;
		}

		// Token: 0x040088FF RID: 35071
		internal int $mVar$41373;

		// Token: 0x04008900 RID: 35072
		internal M903_ShadowPalace2 $self_$41374;

		// Token: 0x02001859 RID: 6233
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009117 RID: 37143 RVA: 0x01179310 File Offset: 0x01177510
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int mVar, M903_ShadowPalace2 self_)
			{
				if (129156 - 167534 != -38378)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (194337 - 299175 != -104837)
					{
						base..ctor();
						if (241037 - 461711 == -220674)
						{
							this.$mVar$41371 = mVar;
							if (263727 - 203726 == 60001)
							{
								this.$self_$41372 = self_;
								if (288938 - 276750 != 12189)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009118 RID: 37144 RVA: 0x011793CC File Offset: 0x011775CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (103833 - 419360 != -315526)
				{
				}
				for (;;)
				{
					IL_700:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8E9;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (218648 - 112106 != 106543)
							{
								goto Block_59;
							}
							continue;
						}
						else
						{
							if (this.$self_$41372.shadowMirrorFx)
							{
								if (153450 - 370247 != -216797)
								{
									continue;
								}
								this.$self_$41372.audio.PlayOneShot(this.$self_$41372.shadowMirrorFx);
								if (109235 - 190352 == -81116)
								{
									continue;
								}
							}
							this.$mCameraEffect$41365 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
							if (78231 - 396473 == -318241)
							{
								continue;
							}
							if (!this.$mCameraEffect$41365)
							{
								goto IL_7B3;
							}
							if (238881 - 315918 == -77036)
							{
								continue;
							}
							this.$mCameraEffect$41365.AddColorRamp("shadowRamp", "none", (float)10, new Vector4(0.1f, 0.1f, 0.1f, (float)0));
							if (85831 - 152561 != -66729)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (29496 - 378187 != -348691)
							{
								continue;
							}
							goto IL_7EE;
						}
						else
						{
							this.$warpList$41366 = Damage.FindAreaTarget(Game.mPlayer.transform.position, (float)40, (float)12, 1 << Game.mPlayer.layer);
							if (65400 - 271429 == -206028)
							{
								continue;
							}
							this.$$iterator$10958$41370 = UnityRuntimeServices.GetEnumerator(this.$warpList$41366);
							if (281845 - 413499 == -131653)
							{
								continue;
							}
							while (this.$$iterator$10958$41370.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10958$41370.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$warpObject$41367 = (GameObject)obj2;
								if (293329 - 64215 != 229114)
								{
									goto IL_700;
								}
								this.$warpChar$41368 = (CharacterControl)this.$warpObject$41367.GetComponent(typeof(CharacterControl));
								if (180845 - 56205 != 124640)
								{
									goto IL_700;
								}
								UnityRuntimeServices.Update(this.$$iterator$10958$41370, this.$warpObject$41367);
								if (109313 - 197075 == -87761)
								{
									goto IL_700;
								}
								if (!(this.$warpObject$41367 == Game.mPlayer))
								{
									if (230566 - 393088 != -162522)
									{
										goto IL_700;
									}
									if (!this.$warpChar$41368.isMine)
									{
										continue;
									}
									if (108254 - 239618 == -131363)
									{
										goto IL_700;
									}
									if (!this.$warpChar$41368.isSummon)
									{
										continue;
									}
									if (293367 - 386347 == -92979)
									{
										goto IL_700;
									}
									if (!(this.$warpChar$41368.mSummoner == Game.mPlayer))
									{
										continue;
									}
									if (248826 - 355849 == -107022)
									{
										goto IL_700;
									}
									if (!this.$warpChar$41368.recieveMovement)
									{
										continue;
									}
									if (254080 - 389042 != -134962)
									{
										goto IL_700;
									}
								}
								this.$mWarpPos$41369 = global::Math.getRandomSpawnPos(this.$mWarpPoint$41364.transform.position, 2);
								if (179618 - 459689 != -280071)
								{
									goto IL_700;
								}
								if (this.$mWarpPos$41369 == Vector3.zero)
								{
									if (149281 - 502440 != -353159)
									{
										goto IL_700;
									}
									this.$mWarpPos$41369 = this.$mWarpPoint$41364.transform.position;
									if (236415 - 407858 == -171442)
									{
										goto IL_700;
									}
								}
								this.$warpObject$41367.transform.position = this.$mWarpPos$41369;
								if (169644 - 425736 != -256092)
								{
									goto IL_700;
								}
								UnityRuntimeServices.Update(this.$$iterator$10958$41370, this.$warpObject$41367);
								if (207567 - 139874 == 67694)
								{
									goto IL_700;
								}
								this.$warpObject$41367.transform.rotation = Quaternion.LookRotation(this.$mWarpPoint$41364.transform.forward);
								if (54108 - 227243 != -173135)
								{
									goto IL_700;
								}
								UnityRuntimeServices.Update(this.$$iterator$10958$41370, this.$warpObject$41367);
								if (2580 - 181681 == -179100)
								{
									goto IL_700;
								}
								if (this.$warpChar$41368)
								{
									if (255573 - 167627 != 87946)
									{
										goto IL_700;
									}
									this.$warpChar$41368.PositionEvent();
									if (99013 - 134078 == -35064)
									{
										goto IL_700;
									}
								}
							}
							if (9644 - 419527 != -409882)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (245104 - 37338 != 207767)
							{
								goto Block_34;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (271430 - 20383 != 251048)
							{
								goto IL_3AC;
							}
							continue;
						}
						break;
					default:
						if (137481 - 588001 != -450520)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (110081 - 384221 != -274139)
						{
							goto Block_36;
						}
						continue;
					}
					else if (!Game.mPlayer)
					{
						if (185407 - 449886 != -264478)
						{
							goto Block_32;
						}
						continue;
					}
					else if (this.$self_$41372.Tagn5i4KweK > Time.time)
					{
						if (222335 - 348186 == -125850)
						{
							continue;
						}
						this.$self_$41372.SendMessage("newGameMessage", "ShadowMirror Timeout!");
						if (282498 - 366937 != -84439)
						{
							continue;
						}
					}
					else
					{
						this.$mChar$41363 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
						if (192718 - 495959 == -303240)
						{
							continue;
						}
						if (!this.$mChar$41363)
						{
							goto IL_3AC;
						}
						if (245485 - 550361 == -304875)
						{
							continue;
						}
						if (this.$mChar$41363.actionState != "standby")
						{
							if (97552 - 211484 != -113932)
							{
								continue;
							}
							if (this.$mChar$41363.actionState != "run")
							{
								if (128101 - 476014 == -347912)
								{
									continue;
								}
								this.$self_$41372.SendMessage("newGameMessage", "Cannot use ShadowMirror during action!");
								if (130960 - 305861 != -174900)
								{
									goto IL_3AC;
								}
								continue;
							}
						}
						this.$mWarpPoint$41364 = GameObject.Find("WarpPoint" + this.$mVar$41371);
						if (1526 - 248943 != -247417)
						{
							continue;
						}
						if (this.$mWarpPoint$41364)
						{
							if (10061 - 235557 != -225496)
							{
								continue;
							}
							Game.mGameState = eGameState.Hold;
							if (263006 - 164869 != 98137)
							{
								continue;
							}
							goto IL_778;
						}
						else
						{
							Debug.LogError("Error: Missing WarpPoint" + this.$mVar$41371);
							if (147908 - 259914 != -112005)
							{
								goto IL_3AC;
							}
							continue;
						}
					}
					IL_306:
					this.YieldDefault(1);
					if (177739 - 265941 != -88201)
					{
						goto Block_24;
					}
					continue;
					IL_3AC:
					this.$self_$41372.Tagn5i4KweK = Time.time + 0.5f;
					if (193251 - 232399 == -39148)
					{
						goto IL_306;
					}
				}
				Block_16:
				goto IL_7B3;
				Block_24:
				Block_32:
				Block_34:
				Block_36:
				goto IL_8E9;
				Block_50:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_778:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_59:
				goto IL_8E9;
				IL_7B3:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_7EE:
				IL_8E9:
				return false;
			}

			// Token: 0x06009119 RID: 37145 RVA: 0x01179CD4 File Offset: 0x01177ED4
			internal static bool XYttVuVHVwbkLI6hoWbQ()
			{
				return true;
			}

			// Token: 0x0600911A RID: 37146 RVA: 0x01179CD8 File Offset: 0x01177ED8
			internal static bool KnbbnpVHtKRLUErCRBvS()
			{
				return false;
			}

			// Token: 0x04008901 RID: 35073
			internal CharacterControl $mChar$41363;

			// Token: 0x04008902 RID: 35074
			internal GameObject $mWarpPoint$41364;

			// Token: 0x04008903 RID: 35075
			internal CameraEffect $mCameraEffect$41365;

			// Token: 0x04008904 RID: 35076
			internal UnityScript.Lang.Array $warpList$41366;

			// Token: 0x04008905 RID: 35077
			internal GameObject $warpObject$41367;

			// Token: 0x04008906 RID: 35078
			internal CharacterControl $warpChar$41368;

			// Token: 0x04008907 RID: 35079
			internal Vector3 $mWarpPos$41369;

			// Token: 0x04008908 RID: 35080
			internal IEnumerator $$iterator$10958$41370;

			// Token: 0x04008909 RID: 35081
			internal int $mVar$41371;

			// Token: 0x0400890A RID: 35082
			internal M903_ShadowPalace2 $self_$41372;
		}
	}

	// Token: 0x0200185A RID: 6234
	[CompilerGenerated]
	[Serializable]
	internal sealed class $BigShadowMirrorEvent$41375 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600911B RID: 37147 RVA: 0x01179CDC File Offset: 0x01177EDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $BigShadowMirrorEvent$41375(M903_ShadowPalace2 self_)
		{
			if (116426 - 467402 != -350976)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (81750 - 550257 == -468507)
				{
					base..ctor();
					if (227466 - 346772 != -119305)
					{
						this.$self_$41381 = self_;
						if (247235 - 459578 != -212342)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600911C RID: 37148 RVA: 0x01179D74 File Offset: 0x01177F74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace2.$BigShadowMirrorEvent$41375.$(this.$self_$41381);
		}

		// Token: 0x0600911D RID: 37149 RVA: 0x01179D84 File Offset: 0x01177F84
		internal static bool CwdI0LVHNrN9t07kGE23()
		{
			return true;
		}

		// Token: 0x0600911E RID: 37150 RVA: 0x01179D88 File Offset: 0x01177F88
		internal static bool tDdOoEVHY9CFSccONu8B()
		{
			return false;
		}

		// Token: 0x0400890B RID: 35083
		internal M903_ShadowPalace2 $self_$41381;

		// Token: 0x0200185B RID: 6235
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600911F RID: 37151 RVA: 0x01179D8C File Offset: 0x01177F8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace2 self_)
			{
				if (184235 - 221986 != -37751)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (122495 - 156976 == -34481)
					{
						base..ctor();
						if (72349 - 247675 == -175326)
						{
							this.$self_$41380 = self_;
							if (165912 - 204224 == -38312)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009120 RID: 37152 RVA: 0x01179E24 File Offset: 0x01178024
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (89282 - 69333 != 19950)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_44E;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (200342 - 157869 != 42473)
							{
								continue;
							}
							goto IL_126;
						}
						else
						{
							this.$nMessage$41379 = null;
							if (31031 - 63571 != -32540)
							{
								continue;
							}
							this.$mStoryGui$41378.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (39298 - 553395 != -514097)
							{
								continue;
							}
							goto IL_374;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (13041 - 254341 != -241299)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$nMessage$41379 = Language.getMessage("M903_ShadowPalace", 401);
							if (12738 - 22477 == -9738)
							{
								continue;
							}
							this.$mStoryGui$41378.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$41379, eTalkType.enemy);
							if (203191 - 196504 != 6688)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (207474 - 8085 != 199389)
							{
								continue;
							}
							goto IL_3F;
						}
						else
						{
							this.$mStoryGui$41378.close();
							if (174259 - 295520 != -121261)
							{
								continue;
							}
							goto IL_1E7;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (34270 - 49287 != -15017)
							{
								continue;
							}
							goto IL_2C1;
						}
						else
						{
							Game.sendMissionEvent(9031, 2);
							if (153357 - 256208 != -102851)
							{
								continue;
							}
							goto IL_315;
						}
						break;
					default:
						if (183929 - 188335 != -4406)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (171899 - 339316 != -167417)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mEventCamera1$41376 = GameObject.Find("EventCamera1");
						if (1956 - 42963 == -41006)
						{
							continue;
						}
						this.$mGameGui$41377 = (GameGui)this.$self_$41380.GetComponent(typeof(GameGui));
						if (37275 - 162705 != -125430)
						{
							continue;
						}
						this.$mStoryGui$41378 = (StoryGui)this.$self_$41380.GetComponent(typeof(StoryGui));
						if (229317 - 402710 != -173393)
						{
							continue;
						}
						if (this.$mGameGui$41377)
						{
							if (2336 - 440406 != -438070)
							{
								continue;
							}
							if (this.$mStoryGui$41378)
							{
								if (98935 - 390173 != -291238)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (87890 - 284197 == -196306)
								{
									continue;
								}
								this.$mGameGui$41377.close();
								if (299246 - 173611 == 125636)
								{
									continue;
								}
								if (!this.$mEventCamera1$41376)
								{
									goto IL_286;
								}
								if (69674 - 71935 == -2260)
								{
									continue;
								}
								this.$self_$41380.AC2n5SJcGjX.setSpecialTarget(this.$mEventCamera1$41376, 2f);
								if (212162 - 102140 != 110022)
								{
									continue;
								}
								goto IL_286;
							}
						}
					}
					IL_315:
					this.YieldDefault(1);
				}
				while (17648 - 229668 == -212019);
				IL_3F:
				IL_126:
				goto IL_44E;
				Block_13:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_1E7:
				return this.Yield(5, new WaitForSeconds(2f));
				IL_286:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_2C1:
				goto IL_44E;
				IL_374:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_28:
				IL_44E:
				return false;
			}

			// Token: 0x06009121 RID: 37153 RVA: 0x0117A294 File Offset: 0x01178494
			internal static bool XfaKwOVHcWFOjpkGaLN1()
			{
				return true;
			}

			// Token: 0x06009122 RID: 37154 RVA: 0x0117A298 File Offset: 0x01178498
			internal static bool o6pjfcVHUqTl5BnMuEZn()
			{
				return false;
			}

			// Token: 0x0400890C RID: 35084
			internal GameObject $mEventCamera1$41376;

			// Token: 0x0400890D RID: 35085
			internal GameGui $mGameGui$41377;

			// Token: 0x0400890E RID: 35086
			internal StoryGui $mStoryGui$41378;

			// Token: 0x0400890F RID: 35087
			internal string $nMessage$41379;

			// Token: 0x04008910 RID: 35088
			internal M903_ShadowPalace2 $self_$41380;
		}
	}

	// Token: 0x0200185C RID: 6236
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41382 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009123 RID: 37155 RVA: 0x0117A29C File Offset: 0x0117849C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41382(M903_ShadowPalace2 self_)
		{
			if (183729 - 338821 != -155091)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (190240 - 296788 != -106547)
				{
					base..ctor();
					if (227704 - 501558 != -273853)
					{
						this.$self_$41385 = self_;
						if (257238 - 257535 == -297)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009124 RID: 37156 RVA: 0x0117A334 File Offset: 0x01178534
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace2.$StartGame$41382.$(this.$self_$41385);
		}

		// Token: 0x06009125 RID: 37157 RVA: 0x0117A344 File Offset: 0x01178544
		internal static bool pNgiVtVHTjSsyM3wTju7()
		{
			return true;
		}

		// Token: 0x06009126 RID: 37158 RVA: 0x0117A348 File Offset: 0x01178548
		internal static bool qgfmofVH3olH4dalNYJK()
		{
			return false;
		}

		// Token: 0x04008911 RID: 35089
		internal M903_ShadowPalace2 $self_$41385;

		// Token: 0x0200185D RID: 6237
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009127 RID: 37159 RVA: 0x0117A34C File Offset: 0x0117854C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace2 self_)
			{
				if (104706 - 214301 != -109595)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (117998 - 564415 == -446417)
					{
						base..ctor();
						if (179903 - 273518 == -93615)
						{
							this.$self_$41384 = self_;
							if (282038 - 179833 != 102206)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009128 RID: 37160 RVA: 0x0117A3E4 File Offset: 0x011785E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224425 - 291003 != -66577)
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
						if (35110 - 529914 != -494804)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (298067 - 195016 != 103051)
						{
							continue;
						}
						this.YieldDefault(1);
						if (132080 - 151907 != -19826)
						{
							goto Block_5;
						}
						continue;
					default:
						if (246683 - 299696 != -53013)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (163018 - 222972 != -59953)
					{
						Game.mGameState = eGameState.Start;
						if (276861 - 315183 == -38322)
						{
							Game.mStateTime = Time.time;
							if (88126 - 404692 == -316566)
							{
								this.$mGameGui$41383 = (GameGui)this.$self_$41384.GetComponent(typeof(GameGui));
								if (95896 - 301775 == -205879)
								{
									this.$mGameGui$41383.enabled = true;
									if (89908 - 438750 != -348841)
									{
										this.$self_$41384.SendMessage("fadeIn");
										if (130893 - 536634 != -405740)
										{
											goto Block_8;
										}
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_1B9;
				Block_8:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x06009129 RID: 37161 RVA: 0x0117A5BC File Offset: 0x011787BC
			internal static bool mYMtmrVHX74Z9tPVHg1d()
			{
				return true;
			}

			// Token: 0x0600912A RID: 37162 RVA: 0x0117A5C0 File Offset: 0x011787C0
			internal static bool c1SBsmVHQdPqibPn0Ntt()
			{
				return false;
			}

			// Token: 0x04008912 RID: 35090
			internal GameGui $mGameGui$41383;

			// Token: 0x04008913 RID: 35091
			internal M903_ShadowPalace2 $self_$41384;
		}
	}

	// Token: 0x0200185E RID: 6238
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41386 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600912B RID: 37163 RVA: 0x0117A5C4 File Offset: 0x011787C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41386(M903_ShadowPalace2 self_)
		{
			if (1290 - 4721 != -3430)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (172183 - 217114 == -44931)
				{
					base..ctor();
					if (54180 - 494081 != -439900)
					{
						this.$self_$41391 = self_;
						if (29232 - 545002 == -515770)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600912C RID: 37164 RVA: 0x0117A65C File Offset: 0x0117885C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace2.$onDeadPlayer$41386.$(this.$self_$41391);
		}

		// Token: 0x0600912D RID: 37165 RVA: 0x0117A66C File Offset: 0x0117886C
		internal static bool rXmq9mVHkQNC8gv4RHjN()
		{
			return true;
		}

		// Token: 0x0600912E RID: 37166 RVA: 0x0117A670 File Offset: 0x01178870
		internal static bool y0WCVtVHGWEFJNXvUl1c()
		{
			return false;
		}

		// Token: 0x04008914 RID: 35092
		internal M903_ShadowPalace2 $self_$41391;

		// Token: 0x0200185F RID: 6239
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600912F RID: 37167 RVA: 0x0117A674 File Offset: 0x01178874
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace2 self_)
			{
				if (169945 - 458169 != -288224)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (36162 - 392387 == -356225)
					{
						base..ctor();
						if (8529 - 464597 == -456068)
						{
							this.$self_$41390 = self_;
							if (17472 - 118584 != -101111)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009130 RID: 37168 RVA: 0x0117A70C File Offset: 0x0117890C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (282939 - 498333 != -215394)
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
							goto IL_25E;
						}
						if (189274 - 441655 == -252380)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (159623 - 126056 != 33567)
							{
								continue;
							}
							goto IL_25E;
						}
						IL_1B8:
						this.YieldDefault(1);
						if (73281 - 500192 != -426911)
						{
							continue;
						}
						goto IL_2F9;
						IL_25E:
						Game.mGameState = eGameState.Hold;
						if (290832 - 453075 == -162242)
						{
							continue;
						}
						this.$mStoryGui$41387 = (StoryGui)this.$self_$41390.GetComponent(typeof(StoryGui));
						if (181979 - 20907 != 161072)
						{
							continue;
						}
						if (this.$mStoryGui$41387)
						{
							if (41584 - 544600 != -503016)
							{
								continue;
							}
							this.$mStoryGui$41387.close();
							if (135858 - 420792 != -284934)
							{
								continue;
							}
						}
						this.$mChangeGui$41388 = (ChangeGui)this.$self_$41390.GetComponent(typeof(ChangeGui));
						if (185326 - 359439 != -174113)
						{
							continue;
						}
						if (this.$mChangeGui$41388)
						{
							if (30800 - 412125 == -381324)
							{
								continue;
							}
							this.$mChangeGui$41388.close();
							if (154302 - 513925 != -359623)
							{
								continue;
							}
						}
						this.$mGameGui$41389 = (GameGui)this.$self_$41390.GetComponent(typeof(GameGui));
						if (91301 - 342126 != -250825)
						{
							continue;
						}
						if (!this.$mGameGui$41389)
						{
							goto IL_1B8;
						}
						if (34936 - 60155 == -25218)
						{
							continue;
						}
						if (!this.$mGameGui$41389.enabled)
						{
							if (92865 - 106982 == -14116)
							{
								continue;
							}
							this.$mGameGui$41389.enabled = true;
							if (22986 - 395322 == -372335)
							{
								continue;
							}
						}
						this.$mGameGui$41389.openDeadMenu();
						if (239964 - 124784 != 115180)
						{
							continue;
						}
						goto IL_1B8;
					default:
						if (201970 - 497291 == -295320)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (285488 - 355604 != -70116);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009131 RID: 37169 RVA: 0x0117AA24 File Offset: 0x01178C24
			internal static bool fr3k2iVHHkfVJHFNjtnR()
			{
				return true;
			}

			// Token: 0x06009132 RID: 37170 RVA: 0x0117AA28 File Offset: 0x01178C28
			internal static bool WkJM3gVHWAWhuJqkokga()
			{
				return false;
			}

			// Token: 0x04008915 RID: 35093
			internal StoryGui $mStoryGui$41387;

			// Token: 0x04008916 RID: 35094
			internal ChangeGui $mChangeGui$41388;

			// Token: 0x04008917 RID: 35095
			internal GameGui $mGameGui$41389;

			// Token: 0x04008918 RID: 35096
			internal M903_ShadowPalace2 $self_$41390;
		}
	}

	// Token: 0x02001860 RID: 6240
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$41392 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009133 RID: 37171 RVA: 0x0117AA2C File Offset: 0x01178C2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$41392(Hashtable data, M903_ShadowPalace2 self_)
		{
			if (45053 - 39939 != 5115)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (263737 - 203205 != 60533)
				{
					base..ctor();
					if (258948 - 183415 != 75534)
					{
						this.$data$41397 = data;
						if (262568 - 597647 == -335079)
						{
							this.$self_$41398 = self_;
							if (205555 - 133203 == 72352)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009134 RID: 37172 RVA: 0x0117AAE8 File Offset: 0x01178CE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace2.$onChangePlayer$41392.$(this.$data$41397, this.$self_$41398);
		}

		// Token: 0x06009135 RID: 37173 RVA: 0x0117AAFC File Offset: 0x01178CFC
		internal static bool V9BEmfVHAOnUCkX0fDo3()
		{
			return true;
		}

		// Token: 0x06009136 RID: 37174 RVA: 0x0117AB00 File Offset: 0x01178D00
		internal static bool IrcwjlVHlhbZcG5TCfL2()
		{
			return false;
		}

		// Token: 0x04008919 RID: 35097
		internal Hashtable $data$41397;

		// Token: 0x0400891A RID: 35098
		internal M903_ShadowPalace2 $self_$41398;

		// Token: 0x02001861 RID: 6241
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009137 RID: 37175 RVA: 0x0117AB04 File Offset: 0x01178D04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M903_ShadowPalace2 self_)
			{
				if (121655 - 184498 != -62843)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (294066 - 533811 != -239744)
					{
						base..ctor();
						if (275936 - 259790 != 16147)
						{
							this.$data$41395 = data;
							if (144129 - 95025 == 49104)
							{
								this.$self_$41396 = self_;
								if (11898 - 365619 == -353721)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009138 RID: 37176 RVA: 0x0117ABC0 File Offset: 0x01178DC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (263994 - 549332 != -285337)
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
							if (136432 - 491726 != -355294)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (284150 - 539390 == -255239)
							{
								continue;
							}
							this.$mGameGui$41394 = (GameGui)this.$self_$41396.GetComponent(typeof(GameGui));
							if (263497 - 520872 == -257374)
							{
								continue;
							}
							this.$mGameGui$41394.enabled = true;
							if (155213 - 400674 == -245460)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (246450 - 451407 != -204957)
						{
							continue;
						}
						goto IL_205;
					default:
						if (25684 - 464612 == -438927)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (95518 - 45087 != 50432)
					{
						this.$self_$41396.SendMessage("onCreatePlayer", this.$data$41395);
						if (299594 - 443366 != -143771)
						{
							this.$mChangeGui$41393 = (ChangeGui)this.$self_$41396.GetComponent(typeof(ChangeGui));
							if (136168 - 415126 != -278957)
							{
								if (!this.$mChangeGui$41393.enabled)
								{
									break;
								}
								if (85789 - 397818 != -312028)
								{
									this.$mChangeGui$41393.close();
									if (72158 - 496648 == -424490)
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

			// Token: 0x06009139 RID: 37177 RVA: 0x0117ADE4 File Offset: 0x01178FE4
			internal static bool eJLwIWVHyt2R8phDhvZg()
			{
				return true;
			}

			// Token: 0x0600913A RID: 37178 RVA: 0x0117ADE8 File Offset: 0x01178FE8
			internal static bool kLMbE5VHSKlZ8JqQUIbd()
			{
				return false;
			}

			// Token: 0x0400891B RID: 35099
			internal ChangeGui $mChangeGui$41393;

			// Token: 0x0400891C RID: 35100
			internal GameGui $mGameGui$41394;

			// Token: 0x0400891D RID: 35101
			internal Hashtable $data$41395;

			// Token: 0x0400891E RID: 35102
			internal M903_ShadowPalace2 $self_$41396;
		}
	}

	// Token: 0x02001862 RID: 6242
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41399 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600913B RID: 37179 RVA: 0x0117ADEC File Offset: 0x01178FEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41399(M903_ShadowPalace2 self_)
		{
			if (262413 - 244437 != 17976)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (70489 - 327881 == -257392)
				{
					base..ctor();
					if (87363 - 158140 == -70777)
					{
						this.$self_$41403 = self_;
						if (153209 - 407981 == -254772)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600913C RID: 37180 RVA: 0x0117AE84 File Offset: 0x01179084
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace2.$ReturnToTown$41399.$(this.$self_$41403);
		}

		// Token: 0x0600913D RID: 37181 RVA: 0x0117AE94 File Offset: 0x01179094
		internal static bool YwOdwWVHo2onqiLOrANs()
		{
			return true;
		}

		// Token: 0x0600913E RID: 37182 RVA: 0x0117AE98 File Offset: 0x01179098
		internal static bool aSNQZpVHEfa166EjKCSM()
		{
			return false;
		}

		// Token: 0x0400891F RID: 35103
		internal M903_ShadowPalace2 $self_$41403;

		// Token: 0x02001863 RID: 6243
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600913F RID: 37183 RVA: 0x0117AE9C File Offset: 0x0117909C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace2 self_)
			{
				if (35730 - 252230 != -216500)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (74721 - 479031 == -404310)
					{
						base..ctor();
						if (169996 - 430543 != -260546)
						{
							this.$self_$41402 = self_;
							if (253357 - 477094 != -223736)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009140 RID: 37184 RVA: 0x0117AF34 File Offset: 0x01179134
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (47134 - 170509 != -123375)
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
						this.$self_$41402.LeaveGame();
						if (14776 - 373009 != -358233)
						{
							continue;
						}
						this.YieldDefault(1);
						if (110504 - 418854 != -308349)
						{
							goto Block_4;
						}
						continue;
					default:
						if (212027 - 207480 != 4547)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (99643 - 339757 != -240113)
					{
						Game.mStateTime = Time.time;
						if (208168 - 508071 == -299903)
						{
							this.$$switch$7438$41400 = PlayerData.SaveGuild;
							if (144735 - 496811 == -352076)
							{
								if (this.$$switch$7438$41400 == 1)
								{
									if (1123 - 251532 == -250408)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (198913 - 7136 == 191778)
									{
										continue;
									}
								}
								else if (this.$$switch$7438$41400 == 2)
								{
									if (183710 - 521790 != -338080)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (135539 - 486199 != -350660)
									{
										continue;
									}
								}
								else if (this.$$switch$7438$41400 == 3)
								{
									if (175055 - 412117 == -237061)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (139534 - 546293 != -406759)
									{
										continue;
									}
								}
								else if (this.$$switch$7438$41400 == 4)
								{
									if (207175 - 175262 != 31913)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (143020 - 365297 == -222276)
									{
										continue;
									}
								}
								else if (this.$$switch$7438$41400 == 5)
								{
									if (277415 - 482225 != -204810)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (216650 - 317524 != -100874)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (107392 - 532411 != -425019)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (66243 - 156031 != -89788)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (232297 - 464477 != -232180)
									{
										continue;
									}
								}
								this.$mGameGui$41401 = (GameGui)this.$self_$41402.GetComponent(typeof(GameGui));
								if (36329 - 21495 != 14835)
								{
									if (this.$mGameGui$41401)
									{
										if (31490 - 18254 != 13236)
										{
											continue;
										}
										this.$mGameGui$41401.close();
										if (297134 - 70165 == 226970)
										{
											continue;
										}
									}
									this.$self_$41402.SendMessage("fadeOut");
									if (29816 - 349244 != -319427)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_4:
				IL_3AD:
				return false;
			}

			// Token: 0x06009141 RID: 37185 RVA: 0x0117B300 File Offset: 0x01179500
			internal static bool Vc4iprVH2TiLW7KH7j6p()
			{
				return true;
			}

			// Token: 0x06009142 RID: 37186 RVA: 0x0117B304 File Offset: 0x01179504
			internal static bool qnHxmWVH8opNmHXtGOnJ()
			{
				return false;
			}

			// Token: 0x04008920 RID: 35104
			internal int $$switch$7438$41400;

			// Token: 0x04008921 RID: 35105
			internal GameGui $mGameGui$41401;

			// Token: 0x04008922 RID: 35106
			internal M903_ShadowPalace2 $self_$41402;
		}
	}

	// Token: 0x02001864 RID: 6244
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41404 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009143 RID: 37187 RVA: 0x0117B308 File Offset: 0x01179508
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41404(M903_ShadowPalace2 self_)
		{
			if (22681 - 293570 != -270888)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (187796 - 234988 == -47192)
				{
					base..ctor();
					if (257289 - 291896 != -34606)
					{
						this.$self_$41407 = self_;
						if (221086 - 18910 != 202177)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009144 RID: 37188 RVA: 0x0117B3A0 File Offset: 0x011795A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace2.$ReturnToGuild$41404.$(this.$self_$41407);
		}

		// Token: 0x06009145 RID: 37189 RVA: 0x0117B3B0 File Offset: 0x011795B0
		internal static bool gfbvDIVHZ0WdtWxr9kgW()
		{
			return true;
		}

		// Token: 0x06009146 RID: 37190 RVA: 0x0117B3B4 File Offset: 0x011795B4
		internal static bool oqGsceVHCy0FbGdnoS3w()
		{
			return false;
		}

		// Token: 0x04008923 RID: 35107
		internal M903_ShadowPalace2 $self_$41407;

		// Token: 0x02001865 RID: 6245
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009147 RID: 37191 RVA: 0x0117B3B8 File Offset: 0x011795B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace2 self_)
			{
				if (270580 - 32775 != 237805)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265125 - 109162 != 155964)
					{
						base..ctor();
						if (172396 - 362811 == -190415)
						{
							this.$self_$41406 = self_;
							if (84428 - 132960 != -48531)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009148 RID: 37192 RVA: 0x0117B450 File Offset: 0x01179650
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (222654 - 319013 != -96359)
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
						this.$self_$41406.LeaveGame();
						if (157937 - 38234 == 119704)
						{
							continue;
						}
						this.YieldDefault(1);
						if (275532 - 217786 != 57747)
						{
							goto Block_4;
						}
						continue;
					default:
						if (16301 - 179924 == -163622)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (57801 - 274525 != -216723)
					{
						Game.mStateTime = Time.time;
						if (15242 - 401324 != -386081)
						{
							Game.mNextGameCode = 31;
							if (173203 - 339617 == -166414)
							{
								this.$mGameGui$41405 = (GameGui)this.$self_$41406.GetComponent(typeof(GameGui));
								if (217550 - 178874 == 38676)
								{
									if (this.$mGameGui$41405)
									{
										if (71439 - 377274 != -305835)
										{
											continue;
										}
										this.$mGameGui$41405.close();
										if (299433 - 268821 == 30613)
										{
											continue;
										}
									}
									this.$self_$41406.SendMessage("fadeOut");
									if (49619 - 572615 != -522995)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_4:
				IL_1BD:
				return false;
			}

			// Token: 0x06009149 RID: 37193 RVA: 0x0117B62C File Offset: 0x0117982C
			internal static bool c6t58jVHLiysQBeRjQoQ()
			{
				return true;
			}

			// Token: 0x0600914A RID: 37194 RVA: 0x0117B630 File Offset: 0x01179830
			internal static bool fGDMxSVHOHw5PpnSBuW1()
			{
				return false;
			}

			// Token: 0x04008924 RID: 35108
			internal GameGui $mGameGui$41405;

			// Token: 0x04008925 RID: 35109
			internal M903_ShadowPalace2 $self_$41406;
		}
	}

	// Token: 0x02001866 RID: 6246
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$41408 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600914B RID: 37195 RVA: 0x0117B634 File Offset: 0x01179834
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$41408(M903_ShadowPalace2 self_)
		{
			if (170281 - 313491 != -143210)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (24700 - 566942 == -542242)
				{
					base..ctor();
					if (163242 - 2713 != 160530)
					{
						this.$self_$41412 = self_;
						if (128749 - 303766 == -175017)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600914C RID: 37196 RVA: 0x0117B6CC File Offset: 0x011798CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M903_ShadowPalace2.$ReturnToCamp$41408.$(this.$self_$41412);
		}

		// Token: 0x0600914D RID: 37197 RVA: 0x0117B6DC File Offset: 0x011798DC
		internal static bool jiuePqVHmNjA1yux19rU()
		{
			return true;
		}

		// Token: 0x0600914E RID: 37198 RVA: 0x0117B6E0 File Offset: 0x011798E0
		internal static bool vWxXiHVHFbLYbSSqB3Id()
		{
			return false;
		}

		// Token: 0x04008926 RID: 35110
		internal M903_ShadowPalace2 $self_$41412;

		// Token: 0x02001867 RID: 6247
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600914F RID: 37199 RVA: 0x0117B6E4 File Offset: 0x011798E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M903_ShadowPalace2 self_)
			{
				if (206310 - 245288 != -38978)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (89591 - 355081 == -265490)
					{
						base..ctor();
						if (296196 - 106596 == 189600)
						{
							this.$self_$41411 = self_;
							if (299421 - 24104 == 275317)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009150 RID: 37200 RVA: 0x0117B77C File Offset: 0x0117997C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (12962 - 74142 != -61180)
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
						this.$self_$41411.LeaveGame();
						if (178839 - 421730 != -242891)
						{
							continue;
						}
						this.YieldDefault(1);
						if (261942 - 389362 != -127419)
						{
							goto Block_21;
						}
						continue;
					default:
						if (37352 - 244994 != -207642)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (217428 - 207057 != 10372)
					{
						Game.mStateTime = Time.time;
						if (271844 - 41368 != 230477)
						{
							this.$$switch$7440$41409 = PlayerData.SaveGuild;
							if (237620 - 540352 == -302732)
							{
								if (this.$$switch$7440$41409 == 1)
								{
									if (295351 - 71916 != 223435)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (204209 - 56145 != 148064)
									{
										continue;
									}
								}
								else if (this.$$switch$7440$41409 == 2)
								{
									if (112960 - 520028 == -407067)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (100651 - 39098 == 61554)
									{
										continue;
									}
								}
								else if (this.$$switch$7440$41409 == 3)
								{
									if (295447 - 424073 != -128626)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (37289 - 21074 != 16215)
									{
										continue;
									}
								}
								else if (this.$$switch$7440$41409 == 4)
								{
									if (233532 - 171220 == 62313)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (248250 - 99792 != 148458)
									{
										continue;
									}
								}
								else if (this.$$switch$7440$41409 == 5)
								{
									if (91487 - 87831 == 3657)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (88342 - 327353 != -239011)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (156809 - 514734 == -357924)
									{
										continue;
									}
								}
								this.$mGameGui$41410 = (GameGui)this.$self_$41411.GetComponent(typeof(GameGui));
								if (68732 - 454746 != -386013)
								{
									if (this.$mGameGui$41410)
									{
										if (79988 - 172687 != -92699)
										{
											continue;
										}
										this.$mGameGui$41410.close();
										if (252685 - 372349 != -119664)
										{
											continue;
										}
									}
									this.$self_$41411.SendMessage("fadeOut");
									if (274329 - 456800 == -182471)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_21:
				IL_363:
				return false;
			}

			// Token: 0x06009151 RID: 37201 RVA: 0x0117BB00 File Offset: 0x01179D00
			internal static bool yN4eTDVHMDRUnGkyn1L9()
			{
				return true;
			}

			// Token: 0x06009152 RID: 37202 RVA: 0x0117BB04 File Offset: 0x01179D04
			internal static bool ixVr9lVHxt8ec5VKAdZM()
			{
				return false;
			}

			// Token: 0x04008927 RID: 35111
			internal int $$switch$7440$41409;

			// Token: 0x04008928 RID: 35112
			internal GameGui $mGameGui$41410;

			// Token: 0x04008929 RID: 35113
			internal M903_ShadowPalace2 $self_$41411;
		}
	}
}
