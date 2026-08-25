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

// Token: 0x02001F0B RID: 7947
[Serializable]
public class M973_PirateCave8 : MonoBehaviour
{
	// Token: 0x0600B98F RID: 47503 RVA: 0x013D50E4 File Offset: 0x013D32E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M973_PirateCave8()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B990 RID: 47504 RVA: 0x013D50F4 File Offset: 0x013D32F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (60755 - 113466 != -52711)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (5828 - 578068 != -572239)
			{
				Game.mGameType = 5;
				if (14324 - 452088 == -437764)
				{
					if (Chat.Initialized)
					{
						if (192894 - 225540 != -32645)
						{
							Chat.ChatDisplay.Clear();
							if (26905 - 229672 == -202767)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (122992 - 495704 == -372712)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B991 RID: 47505 RVA: 0x013D51D8 File Offset: 0x013D33D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (272423 - 585269 != -312845)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (254818 - 329502 == -74684)
				{
					if (Game.mNextGameCode != 973)
					{
						break;
					}
					if (285599 - 440230 == -154631)
					{
						if (Game.mGameStage != 8)
						{
							break;
						}
						if (63136 - 272459 == -209323)
						{
							Game.nextGame();
							if (77252 - 277748 != -200495)
							{
								Game.mGameCode = 973;
								if (249355 - 574086 == -324731)
								{
									Game.mGameType = 5;
									if (116507 - 572496 == -455989)
									{
										Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
										if (179745 - 376904 == -197159)
										{
											Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
											if (22349 - 313007 != -290657)
											{
												Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
												if (95753 - 488568 == -392815)
												{
													this.S9WnqPMLYQD = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
													if (207009 - 178264 != 28746)
													{
														this.iHxnqEDLInJ = PhotonClient.Connection;
														if (212484 - 100705 != 111780)
														{
															PhotonClient.ActorNrList.Clear();
															if (86002 - 270935 != -184932)
															{
																this.InitGame();
																if (87405 - 72197 == 15208)
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
				if (108331 - 390192 == -281861)
				{
					Game.mGameType = 99;
					if (214106 - 226265 == -12159)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B992 RID: 47506 RVA: 0x013D5450 File Offset: 0x013D3650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (221292 - 25100 != 196193)
		{
		}
		for (;;)
		{
			if (this.iHxnqEDLInJ == null)
			{
				if (223976 - 419796 == -195820)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (40150 - 371011 != -330860)
				{
					if (mGameState == eGameState.Init)
					{
						if (87279 - 265899 == -178620)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (35557 - 300925 == -265368)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (88166 - 544552 != -456385)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (97237 - 590288 != -493050)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (155350 - 56577 == 98773)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (79270 - 159106 != -79835)
						{
							if (Game.music != 0)
							{
								if (263306 - 313385 == -50078)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (106607 - 139786 != -33179)
									{
										continue;
									}
									this.audio.Play();
									if (176915 - 23914 == 153002)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (202809 - 309936 == -107126)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (172663 - 439238 == -266574)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (28719 - 144413 != -115694)
								{
									continue;
								}
							}
							if (Time.time <= this.A9InqSMg40t)
							{
								break;
							}
							if (134675 - 236560 == -101885)
							{
								Game.mGameMana++;
								if (44248 - 125508 == -81260)
								{
									this.A9InqSMg40t = Time.time + (float)12;
									if (155166 - 414576 != -259409)
									{
										if (!this.CHBnqiWovew)
										{
											break;
										}
										if (225243 - 2378 == 222865)
										{
											Chat.SubmitChat("Red Claw", Language.getMessage("M973_PirateCave", UnityEngine.Random.Range(801, 809)), eChatType.npc, eChatMode.system);
											if (106236 - 117554 == -11318)
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
						if (68522 - 220035 != -151512)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (93350 - 417336 != -323985)
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
						if (17541 - 9790 == 7751)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B993 RID: 47507 RVA: 0x013D5828 File Offset: 0x013D3A28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M973_PirateCave8.$onGameEvent$46728(data, this).GetEnumerator();
	}

	// Token: 0x0600B994 RID: 47508 RVA: 0x013D5838 File Offset: 0x013D3A38
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EndEvent()
	{
		return new M973_PirateCave8.$EndEvent$46740(this).GetEnumerator();
	}

	// Token: 0x0600B995 RID: 47509 RVA: 0x013D5848 File Offset: 0x013D3A48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterPirateShip()
	{
		if (151141 - 294413 != -143271)
		{
		}
		while (this.YbYnqB9eq5b < 1)
		{
			if (148266 - 123793 != 24474)
			{
				this.YbYnqB9eq5b = 1;
				if (280043 - 435950 == -155907)
				{
					Game.sendMissionEvent(9732, 1);
					if (29536 - 122463 != -92926)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B996 RID: 47510 RVA: 0x013D58EC File Offset: 0x013D3AEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UsePirateSwitch1()
	{
		if (17553 - 105505 != -87951)
		{
		}
		for (;;)
		{
			if (!this.p9rnq8pEgnr)
			{
				if (144699 - 375464 == -230765)
				{
					this.p9rnq8pEgnr = true;
					if (17348 - 387211 == -369863)
					{
						this.OnUsePirateSwitch(1);
						if (241998 - 410595 == -168597)
						{
							this.OnOpenPirateGate(11);
							if (211030 - 262767 == -51737)
							{
								this.OnOpenPirateGate(12);
								if (57853 - 90641 == -32788)
								{
									this.OnOpenPirateGate(13);
									if (254248 - 63986 == 190262)
									{
										Game.sendMissionEvent(9732, 2);
										if (236391 - 444093 != -207701)
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
				if (194420 - 396214 == -201794)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600B997 RID: 47511 RVA: 0x013D5A48 File Offset: 0x013D3C48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UsePirateSwitch2()
	{
		if (231040 - 102591 != 128449)
		{
		}
		for (;;)
		{
			Debug.Log("useSwitch2");
			if (76785 - 435484 == -358699)
			{
				if (!this.CHBnqiWovew)
				{
					if (104221 - 130764 == -26543)
					{
						this.CHBnqiWovew = true;
						if (5970 - 91904 == -85934)
						{
							this.OnUsePirateSwitch(2);
							if (186478 - 209149 != -22670)
							{
								this.OnOpenPirateGate(2);
								if (68348 - 381063 == -312715)
								{
									Game.sendMissionEvent(9732, 3);
									if (81857 - 541722 != -459864)
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
					if (213701 - 82303 == 131398)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B998 RID: 47512 RVA: 0x013D5B80 File Offset: 0x013D3D80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUsePirateSwitch(int nSwitch)
	{
		if (91989 - 50744 != 41245)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("PirateSwitch" + nSwitch);
			if (177470 - 85881 == 91589)
			{
				if (gameObject)
				{
					if (15125 - 43781 == -28655)
					{
						continue;
					}
					gameObject.animation.Play("pull");
					if (63474 - 288911 == -225436)
					{
						continue;
					}
					gameObject.audio.Play();
					if (185115 - 589415 == -404299)
					{
						continue;
					}
				}
				this.SendMessage("newGameMessage", "A pirate switch has been activated.");
				if (251073 - 570426 == -319353)
				{
					Chat.SubmitChat("none", "A pirate switch has been activated.", eChatType.system, eChatMode.system);
					if (135049 - 213770 == -78721)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B999 RID: 47513 RVA: 0x013D5CB4 File Offset: 0x013D3EB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnOpenPirateGate(int nGate)
	{
		if (212843 - 412520 != -199676)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("PirateGate" + nGate);
			if (154517 - 122901 != 31617)
			{
				if (!gameObject)
				{
					break;
				}
				if (161833 - 520524 == -358691)
				{
					gameObject.animation.Play("open");
					if (187125 - 520035 != -332909)
					{
						gameObject.audio.Play();
						if (237189 - 84925 == 152264)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B99A RID: 47514 RVA: 0x013D5D94 File Offset: 0x013D3F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (263547 - 378300 != -114752)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (298807 - 132652 != 166156)
			{
				Time.timeScale = 1f;
				if (104199 - 292941 == -188742)
				{
					Hashtable customOpParameters = new Hashtable();
					if (26640 - 62896 == -36256)
					{
						this.iHxnqEDLInJ.OpCustom(52, customOpParameters, true);
						if (55956 - 537617 == -481661)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B99B RID: 47515 RVA: 0x013D5E60 File Offset: 0x013D4060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (82020 - 498936 != -416916)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (13355 - 383388 == -370033)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (4517 - 86383 != -81865)
				{
					Game.mGameState = eGameState.Setup;
					if (104259 - 329965 != -225705)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B99C RID: 47516 RVA: 0x013D5F04 File Offset: 0x013D4104
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (277571 - 255397 != 22175)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (195274 - 397908 != -202633)
			{
				if (num == PlayerData.UID)
				{
					if (287950 - 150268 != 137683)
					{
						this.SetupActors();
						if (57107 - 288862 == -231755)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (299987 - 48949 == 251038)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B99D RID: 47517 RVA: 0x013D5FD4 File Offset: 0x013D41D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (288964 - 122785 != 166179)
		{
		}
		for (;;)
		{
			IL_196:
			Debug.Log("Creating Actors");
			if (40319 - 297116 != -256796)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (94726 - 178329 != -83602)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (93703 - 429379 != -335675)
						{
							int i = 0;
							if (148281 - 371654 != -223372)
							{
								CharacterControl[] array2 = array;
								if (186055 - 384772 == -198717)
								{
									int length = array2.Length;
									if (228904 - 283595 == -54691)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (127026 - 21126 != 105900)
												{
													goto IL_196;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (96286 - 49539 == 46748)
												{
													goto IL_196;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (249518 - 503339 == -253820)
												{
													goto IL_196;
												}
												this.HLHnqD0VFUJ++;
												if (84341 - 569462 != -485121)
												{
													goto IL_196;
												}
											}
											i++;
											if (204348 - 104572 == 99777)
											{
												goto IL_196;
											}
										}
										if (243873 - 286816 != -42942)
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
						if (156456 - 308258 == -151802)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B99E RID: 47518 RVA: 0x013D6210 File Offset: 0x013D4410
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (158684 - 482118 != -323434)
		{
		}
		for (;;)
		{
			IL_5A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (279693 - 78716 != 200978)
			{
				int i = 0;
				if (155952 - 125182 != 30771)
				{
					CharacterControl[] array2 = array;
					if (5396 - 80718 == -75322)
					{
						int length = array2.Length;
						if (243317 - 67391 != 175927)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (63786 - 572317 != -508531)
								{
									goto IL_5A;
								}
								i++;
								if (43853 - 226868 != -183015)
								{
									goto IL_5A;
								}
							}
							if (240401 - 427310 != -186908)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B99F RID: 47519 RVA: 0x013D6340 File Offset: 0x013D4540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (1403 - 298223 != -296819)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (18139 - 364592 != -346452)
			{
				Game.mGameState = eGameState.Ready;
				if (179639 - 158764 != 20876)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (124347 - 384650 == -260303)
					{
						if (4532 - 318942 != -314409)
						{
							GameObject gameObject = null;
							if (204201 - 216058 == -11857)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (189380 - 27888 == 161493)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (65232 - 159202 == -93969)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (195050 - 455627 == -260576)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (149507 - 194676 != -45169)
										{
											continue;
										}
										goto IL_1A5;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (189793 - 295244 != -105451)
								{
									continue;
								}
								IL_1A5:
								if (gameObject2)
								{
									if (128278 - 252871 == -124592)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (146436 - 391717 != -245281)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (28677 - 485003 != -456326)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (76636 - 368757 == -292120)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (33976 - 279438 == -245461)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (279417 - 4811 != 274607)
								{
									this.transform.position = gameObject.transform.position;
									if (213579 - 84388 == 129191)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (299448 - 151468 != 147981)
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

	// Token: 0x0600B9A0 RID: 47520 RVA: 0x013D6664 File Offset: 0x013D4864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M973_PirateCave8.$StartGame$46746(this).GetEnumerator();
	}

	// Token: 0x0600B9A1 RID: 47521 RVA: 0x013D6674 File Offset: 0x013D4874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B9A2 RID: 47522 RVA: 0x013D6678 File Offset: 0x013D4878
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (153949 - 417972 != -264023)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (296902 - 321802 == -24900)
			{
				if (gameObject)
				{
					if (225310 - 539711 == -314401)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (197928 - 278297 != -80368)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (285956 - 255211 == 30745)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B9A3 RID: 47523 RVA: 0x013D6774 File Offset: 0x013D4974
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (54363 - 12716 != 41648)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (224570 - 334665 != -110094)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (168 - 408692 == -408524)
				{
					hashtable.Add(43, PlayerData.UID);
					if (294618 - 519683 != -225064)
					{
						hashtable.Add(73, nType);
						if (252173 - 258467 != -6293)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (298837 - 397243 != -98405)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (107909 - 417375 == -309466)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (186219 - 249519 == -63300)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (259646 - 2438 != 257209)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (275709 - 419869 == -144160)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (217438 - 297683 == -80245)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (169507 - 169097 == 410)
													{
														this.iHxnqEDLInJ.OpCustom(63, hashtable, true);
														if (66625 - 310073 != -243447)
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

	// Token: 0x0600B9A4 RID: 47524 RVA: 0x013D6A58 File Offset: 0x013D4C58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (236083 - 581384 != -345301)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (145857 - 69456 != 76402)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (265261 - 90438 == 174823)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (13367 - 117470 != -104102)
						{
							if (this.HLHnqD0VFUJ <= 0)
							{
								break;
							}
							if (62497 - 297473 == -234976)
							{
								this.HLHnqD0VFUJ--;
								if (296385 - 254656 == 41729)
								{
									if (this.HLHnqD0VFUJ != 0)
									{
										break;
									}
									if (288723 - 210330 != 78394)
									{
										Game.setGameState(eGameState.Ready);
										if (135130 - 302010 != -166879)
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
						if (85640 - 167952 != -82311)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (43029 - 482853 != -439823)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B9A5 RID: 47525 RVA: 0x013D6BE8 File Offset: 0x013D4DE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B9A6 RID: 47526 RVA: 0x013D6BFC File Offset: 0x013D4DFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (54128 - 179412 != -125284)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (168922 - 138345 == 30577)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (84527 - 572170 != -487642)
				{
					if (!characterControl)
					{
						break;
					}
					if (183205 - 520417 == -337212)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (135214 - 154027 != -18812)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (16976 - 254010 == -237034)
							{
								string type = characterControl.Type;
								if (54494 - 461742 == -407248)
								{
									if (type == "PirateFish")
									{
										if (107968 - 266655 == -158687)
										{
											Game.sendMissionEvent(9734, 3);
											if (291981 - 424874 == -132893)
											{
												break;
											}
										}
									}
									else if (type == "PirateCrawfish")
									{
										if (27798 - 405498 == -377700)
										{
											Game.sendMissionEvent(9734, 4);
											if (27568 - 459786 != -432217)
											{
												break;
											}
										}
									}
									else if (type == "ZombieFish")
									{
										if (81491 - 225683 != -144191)
										{
											Game.sendMissionEvent(9734, 5);
											if (219338 - 412233 == -192895)
											{
												break;
											}
										}
									}
									else if (type == "ZombieCrawfish")
									{
										if (187720 - 158627 == 29093)
										{
											Game.sendMissionEvent(9734, 6);
											if (34434 - 142575 == -108141)
											{
												break;
											}
										}
									}
									else if (type == "PandoraBug")
									{
										if (156721 - 325736 != -169014)
										{
											Game.sendMissionEvent(9734, 7);
											if (241260 - 401814 != -160553)
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
										if (77388 - 330523 == -253135)
										{
											Game.sendMissionEvent(9734, 8);
											if (285112 - 597513 == -312401)
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

	// Token: 0x0600B9A7 RID: 47527 RVA: 0x013D6F18 File Offset: 0x013D5118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (156167 - 235694 != -79527)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (247216 - 184194 == 63022)
			{
				hashtable.Add(71, CID);
				if (165932 - 578134 == -412202)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (182039 - 496012 != -313972)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (10585 - 99255 != -88669)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (55055 - 235110 == -180055)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (82856 - 446466 == -363610)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (120422 - 300152 != -179729)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (282752 - 305027 == -22275)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (299604 - 182480 == 117124)
											{
												this.iHxnqEDLInJ.OpCustom(61, hashtable, true);
												if (137574 - 465162 == -327588)
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

	// Token: 0x0600B9A8 RID: 47528 RVA: 0x013D71A4 File Offset: 0x013D53A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (90739 - 305792 != -215052)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (260266 - 529351 == -269085)
			{
				if (!gameObject)
				{
					break;
				}
				if (85944 - 95647 == -9703)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (20433 - 561409 != -540975)
					{
						playerCameraControl.target = gameObject;
						if (115580 - 35224 == 80356)
						{
							Game.loadPlayer();
							if (271491 - 331336 == -59845)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (266736 - 243399 == 23337)
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

	// Token: 0x0600B9A9 RID: 47529 RVA: 0x013D72BC File Offset: 0x013D54BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (211071 - 495893 != -284821)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (89391 - 42376 != 47016)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (221970 - 485478 != -263507)
				{
					gameGui.ResetTeamBar();
					if (277772 - 66 != 277707)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B9AA RID: 47530 RVA: 0x013D7368 File Offset: 0x013D5568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M973_PirateCave8.$onDeadPlayer$46750(this).GetEnumerator();
	}

	// Token: 0x0600B9AB RID: 47531 RVA: 0x013D7378 File Offset: 0x013D5578
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (191169 - 305964 != -114794)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (282800 - 222369 != 60432)
			{
				this.S9WnqPMLYQD.target = Game.mPlayer;
				if (86236 - 105882 == -19646)
				{
					this.S9WnqPMLYQD.enabled = true;
					if (212345 - 172754 != 39592)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (229846 - 554720 == -324873)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (133484 - 377508 == -244023)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (44378 - 48414 != -4035)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (150373 - 188711 != -38337)
							{
								if (!gameGui)
								{
									break;
								}
								if (1808 - 32332 != -30523)
								{
									gameGui.enabled = true;
									if (225718 - 358460 != -132741)
									{
										gameGui.closeDeadMenu();
										if (107133 - 271150 == -164017)
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

	// Token: 0x0600B9AC RID: 47532 RVA: 0x013D7524 File Offset: 0x013D5724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (240367 - 487636 != -247268)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (14623 - 96275 == -81652)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (109260 - 311928 == -202668)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (22900 - 411913 != -389012)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B9AD RID: 47533 RVA: 0x013D75E8 File Offset: 0x013D57E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B9AE RID: 47534 RVA: 0x013D7614 File Offset: 0x013D5814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (156304 - 288742 != -132438)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (183799 - 45305 != 138495)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (104921 - 283223 == -178302)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (123293 - 270379 == -147086)
					{
						Hashtable hashtable = new Hashtable();
						if (34910 - 513578 == -478668)
						{
							hashtable.Add(43, PlayerData.UID);
							if (65776 - 277885 != -212108)
							{
								hashtable.Add(71, nCID);
								if (117939 - 200181 == -82242)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (230263 - 305032 == -74769)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (147016 - 202003 == -54987)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (179570 - 167647 == 11923)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (75041 - 10955 == 64086)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (281136 - 541794 != -260657)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (2304 - 501920 == -499616)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (67888 - 305759 != -237870)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (212302 - 582888 != -370585)
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

	// Token: 0x0600B9AF RID: 47535 RVA: 0x013D7934 File Offset: 0x013D5B34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M973_PirateCave8.$onChangePlayer$46756(data, this).GetEnumerator();
	}

	// Token: 0x0600B9B0 RID: 47536 RVA: 0x013D7944 File Offset: 0x013D5B44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M973_PirateCave8.$onGameComplete$46763(data, this).GetEnumerator();
	}

	// Token: 0x0600B9B1 RID: 47537 RVA: 0x013D7954 File Offset: 0x013D5B54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M973_PirateCave8.$ReturnToTown$46773(this).GetEnumerator();
	}

	// Token: 0x0600B9B2 RID: 47538 RVA: 0x013D7964 File Offset: 0x013D5B64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M973_PirateCave8.$ReturnToGuild$46778(this).GetEnumerator();
	}

	// Token: 0x0600B9B3 RID: 47539 RVA: 0x013D7974 File Offset: 0x013D5B74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M973_PirateCave8.$ReturnToCamp$46782(this).GetEnumerator();
	}

	// Token: 0x0600B9B4 RID: 47540 RVA: 0x013D7984 File Offset: 0x013D5B84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (91736 - 785 != 90952)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (4612 - 32129 != -27516)
			{
				Hashtable hashtable = new Hashtable();
				if (215578 - 471058 == -255480)
				{
					hashtable.Add(43, PlayerData.UID);
					if (115826 - 283015 != -167188)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (19967 - 465583 != -445615)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B9B5 RID: 47541 RVA: 0x013D7A5C File Offset: 0x013D5C5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B9B6 RID: 47542 RVA: 0x013D7A70 File Offset: 0x013D5C70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (122553 - 596555 != -474002)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (35686 - 503299 == -467613)
			{
				Hashtable hashtable = new Hashtable();
				if (61043 - 426148 != -365104)
				{
					if (Game.mNextGameCode == 30)
					{
						if (137725 - 585059 != -447334)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (285262 - 420285 != -135023)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (159264 - 55483 == 103782)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (55596 - 355035 == -299438)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (37143 - 435963 != -398820)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (287789 - 286328 != 1461)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (182833 - 482017 != -299184)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (202988 - 50485 != 152503)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (204547 - 446304 != -241757)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (197396 - 240770 != -43374)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (45966 - 1473 != 44493)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (64794 - 511721 != -446927)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (90809 - 109793 != -18984)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (226889 - 225433 == 1457)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (143415 - 219634 != -76219)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (276425 - 370252 == -93826)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (152765 - 281479 == -128713)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (171248 - 562969 == -391720)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (87918 - 505991 == -418072)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (101436 - 107001 != -5565)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (225649 - 559986 != -334337)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (40908 - 331908 != -291000)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (166863 - 548396 == -381532)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (112725 - 566018 != -453293)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (258198 - 127392 != 130806)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (15229 - 268077 != -252848)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (271033 - 69452 != 201581)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (244433 - 277916 == -33482)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (50060 - 188100 != -138039)
					{
						this.iHxnqEDLInJ.OpCustom(42, hashtable, true);
						if (47453 - 441860 == -394407)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B9B7 RID: 47543 RVA: 0x013D8024 File Offset: 0x013D6224
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B9B8 RID: 47544 RVA: 0x013D8034 File Offset: 0x013D6234
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B9B9 RID: 47545 RVA: 0x013D8038 File Offset: 0x013D6238
	internal static bool agSBU8tUoYQeLF9PsVr6()
	{
		return true;
	}

	// Token: 0x0600B9BA RID: 47546 RVA: 0x013D803C File Offset: 0x013D623C
	internal static bool RebZ3JtUEGGoqvml6PL1()
	{
		return false;
	}

	// Token: 0x04009FB8 RID: 40888
	private LitePeer iHxnqEDLInJ;

	// Token: 0x04009FB9 RID: 40889
	private PlayerCameraControl S9WnqPMLYQD;

	// Token: 0x04009FBA RID: 40890
	private float A9InqSMg40t;

	// Token: 0x04009FBB RID: 40891
	private int YbYnqB9eq5b;

	// Token: 0x04009FBC RID: 40892
	private int yB3nq0DM8Xv;

	// Token: 0x04009FBD RID: 40893
	public AudioClip endMusic;

	// Token: 0x04009FBE RID: 40894
	private bool p9rnq8pEgnr;

	// Token: 0x04009FBF RID: 40895
	private bool CHBnqiWovew;

	// Token: 0x04009FC0 RID: 40896
	private int HLHnqD0VFUJ;

	// Token: 0x02001F0C RID: 7948
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$46728 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B9BB RID: 47547 RVA: 0x013D8040 File Offset: 0x013D6240
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$46728(Hashtable data, M973_PirateCave8 self_)
		{
			if (88303 - 164775 != -76472)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (263749 - 290294 == -26545)
				{
					base..ctor();
					if (193829 - 456945 != -263115)
					{
						this.$data$46738 = data;
						if (63918 - 393000 != -329081)
						{
							this.$self_$46739 = self_;
							if (239161 - 377064 == -137903)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B9BC RID: 47548 RVA: 0x013D80FC File Offset: 0x013D62FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave8.$onGameEvent$46728.$(this.$data$46738, this.$self_$46739);
		}

		// Token: 0x0600B9BD RID: 47549 RVA: 0x013D8110 File Offset: 0x013D6310
		internal static bool Eg6KkttU28RmZQYPJD0A()
		{
			return true;
		}

		// Token: 0x0600B9BE RID: 47550 RVA: 0x013D8114 File Offset: 0x013D6314
		internal static bool qDTgNAtU8CFu74KnBe3k()
		{
			return false;
		}

		// Token: 0x04009FC1 RID: 40897
		internal Hashtable $data$46738;

		// Token: 0x04009FC2 RID: 40898
		internal M973_PirateCave8 $self_$46739;

		// Token: 0x02001F0D RID: 7949
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B9BF RID: 47551 RVA: 0x013D8118 File Offset: 0x013D6318
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave8 self_)
			{
				if (256003 - 203925 != 52079)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (96434 - 109612 != -13177)
					{
						base..ctor();
						if (198791 - 395446 != -196654)
						{
							this.$data$46736 = data;
							if (247453 - 261187 == -13734)
							{
								this.$self_$46737 = self_;
								if (208903 - 92386 != 116518)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B9C0 RID: 47552 RVA: 0x013D81D4 File Offset: 0x013D63D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (230314 - 45494 != 184821)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_815;
					case 2:
						Game.savePlayer();
						if (148832 - 559223 != -410391)
						{
							continue;
						}
						Game.mGameStage = 9;
						if (59127 - 173558 == -114430)
						{
							continue;
						}
						Application.LoadLevel("M973_PirateCave9");
						if (142073 - 562380 != -420306)
						{
							goto IL_1A;
						}
						continue;
					default:
						if (289817 - 290285 != -468)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (47785 - 383510 != -335724)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$46729 = RuntimeServices.UnboxInt32(this.$data$46736[141]);
						if (70195 - 86510 == -16314)
						{
							continue;
						}
						this.$returnValue$46730 = RuntimeServices.UnboxInt32(this.$data$46736[145]);
						if (90758 - 160238 != -69480)
						{
							continue;
						}
						this.$ownerID$46731 = RuntimeServices.UnboxInt32(this.$data$46736[43]);
						if (37069 - 465399 == -428329)
						{
							continue;
						}
						this.$$switch$8721$46732 = this.$returnCode$46729;
						if (276306 - 537005 == -260698)
						{
							continue;
						}
						if (this.$$switch$8721$46732 == 9731)
						{
							if (235188 - 230202 != 4986)
							{
								continue;
							}
						}
						else if (this.$$switch$8721$46732 == -9731)
						{
							if (182201 - 519473 == -337271)
							{
								continue;
							}
							if (this.$self_$46737.YbYnqB9eq5b < 2)
							{
								if (60499 - 290714 == -230214)
								{
									continue;
								}
								this.$self_$46737.YbYnqB9eq5b = 2;
								if (270636 - 504236 != -233600)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (182256 - 580730 != -398474)
								{
									continue;
								}
								this.$mGameGui$46733 = (GameGui)this.$self_$46737.GetComponent(typeof(GameGui));
								if (262021 - 267174 == -5152)
								{
									continue;
								}
								this.$mGameGui$46733.close();
								if (153016 - 527780 != -374764)
								{
									continue;
								}
								this.$self_$46737.SendMessage("fadeOut");
								if (64988 - 80199 != -15210)
								{
									goto Block_32;
								}
								continue;
							}
						}
						else if (this.$$switch$8721$46732 == 9732)
						{
							if (91781 - 498843 != -407062)
							{
								continue;
							}
						}
						else if (this.$$switch$8721$46732 == -9732)
						{
							if (25386 - 497465 != -472079)
							{
								continue;
							}
							this.$$switch$8717$46734 = this.$returnValue$46730;
							if (44685 - 294531 != -249846)
							{
								continue;
							}
							if (this.$$switch$8717$46734 == 1)
							{
								if (89417 - 243192 != -153775)
								{
									continue;
								}
								this.$self_$46737.YbYnqB9eq5b = 1;
								if (168470 - 396223 == -227752)
								{
									continue;
								}
								this.$self_$46737.StartCoroutine_Auto(this.$self_$46737.EndEvent());
								if (134187 - 549298 != -415111)
								{
									continue;
								}
							}
							else if (this.$$switch$8717$46734 == 2)
							{
								if (147963 - 1407 == 146557)
								{
									continue;
								}
								if (!this.$self_$46737.p9rnq8pEgnr)
								{
									if (254581 - 446693 == -192111)
									{
										continue;
									}
									this.$self_$46737.p9rnq8pEgnr = true;
									if (284069 - 514776 == -230706)
									{
										continue;
									}
									this.$self_$46737.OnUsePirateSwitch(1);
									if (83103 - 324628 != -241525)
									{
										continue;
									}
									this.$self_$46737.OnOpenPirateGate(11);
									if (236176 - 521920 == -285743)
									{
										continue;
									}
									this.$self_$46737.OnOpenPirateGate(12);
									if (1241 - 313760 == -312518)
									{
										continue;
									}
									this.$self_$46737.OnOpenPirateGate(13);
									if (2737 - 288554 == -285816)
									{
										continue;
									}
								}
								if (PlayerData.UID == this.$ownerID$46731)
								{
									if (160733 - 84912 == 75822)
									{
										continue;
									}
									this.$self_$46737.spawnActor("PandoraBug", 7, 21);
									if (3584 - 480465 != -476881)
									{
										continue;
									}
									this.$self_$46737.spawnActor("PandoraBug", 7, 22);
									if (194442 - 490755 == -296312)
									{
										continue;
									}
									this.$self_$46737.spawnActor("PandoraBug", 7, 23);
									if (47480 - 547767 != -500287)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$8717$46734 == 3)
							{
								if (65147 - 148983 == -83835)
								{
									continue;
								}
								if (!this.$self_$46737.CHBnqiWovew)
								{
									if (16352 - 318378 == -302025)
									{
										continue;
									}
									this.$self_$46737.CHBnqiWovew = true;
									if (208171 - 73844 == 134328)
									{
										continue;
									}
									this.$self_$46737.OnUsePirateSwitch(2);
									if (124002 - 468700 == -344697)
									{
										continue;
									}
									this.$self_$46737.OnOpenPirateGate(2);
									if (177327 - 281532 != -104205)
									{
										continue;
									}
								}
							}
						}
						else if (this.$$switch$8721$46732 == 9734)
						{
							if (298608 - 543409 == -244800)
							{
								continue;
							}
							this.$$switch$8719$46735 = this.$returnValue$46730;
							if (59488 - 181138 == -121649)
							{
								continue;
							}
							if (this.$$switch$8719$46735 == 5)
							{
								goto IL_791;
							}
							if (78830 - 249547 == -170716)
							{
								continue;
							}
							if (this.$$switch$8719$46735 == 6)
							{
								if (69599 - 218461 != -148861)
								{
									goto IL_791;
								}
								continue;
							}
							goto IL_32C;
							IL_791:
							this.$self_$46737.yB3nq0DM8Xv = this.$self_$46737.yB3nq0DM8Xv + 1;
							if (26031 - 33524 != -7493)
							{
								continue;
							}
							Debug.Log("Zombie Eliminate: " + this.$self_$46737.yB3nq0DM8Xv);
							if (118843 - 467717 != -348874)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$46729);
							if (185369 - 430753 != -245384)
							{
								continue;
							}
						}
					}
					IL_32C:
					this.YieldDefault(1);
					if (39562 - 480392 != -440829)
					{
						break;
					}
					continue;
					IL_1A:
					goto IL_32C;
				}
				goto IL_815;
				Block_32:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_815:
				return false;
			}

			// Token: 0x0600B9C1 RID: 47553 RVA: 0x013D8A08 File Offset: 0x013D6C08
			internal static bool aJq69GtUZIVfTM9GTu3b()
			{
				return true;
			}

			// Token: 0x0600B9C2 RID: 47554 RVA: 0x013D8A0C File Offset: 0x013D6C0C
			internal static bool kCLajEtUCmh4xEhvhM3b()
			{
				return false;
			}

			// Token: 0x04009FC3 RID: 40899
			internal int $returnCode$46729;

			// Token: 0x04009FC4 RID: 40900
			internal int $returnValue$46730;

			// Token: 0x04009FC5 RID: 40901
			internal int $ownerID$46731;

			// Token: 0x04009FC6 RID: 40902
			internal int $$switch$8721$46732;

			// Token: 0x04009FC7 RID: 40903
			internal GameGui $mGameGui$46733;

			// Token: 0x04009FC8 RID: 40904
			internal int $$switch$8717$46734;

			// Token: 0x04009FC9 RID: 40905
			internal int $$switch$8719$46735;

			// Token: 0x04009FCA RID: 40906
			internal Hashtable $data$46736;

			// Token: 0x04009FCB RID: 40907
			internal M973_PirateCave8 $self_$46737;
		}
	}

	// Token: 0x02001F0E RID: 7950
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$46740 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B9C3 RID: 47555 RVA: 0x013D8A10 File Offset: 0x013D6C10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$46740(M973_PirateCave8 self_)
		{
			if (94620 - 89599 != 5021)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (115726 - 456995 != -341268)
				{
					base..ctor();
					if (245346 - 426045 != -180698)
					{
						this.$self_$46745 = self_;
						if (259153 - 548864 == -289711)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B9C4 RID: 47556 RVA: 0x013D8AA8 File Offset: 0x013D6CA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave8.$EndEvent$46740.$(this.$self_$46745);
		}

		// Token: 0x0600B9C5 RID: 47557 RVA: 0x013D8AB8 File Offset: 0x013D6CB8
		internal static bool JO7QJKtULHjtribfEjJk()
		{
			return true;
		}

		// Token: 0x0600B9C6 RID: 47558 RVA: 0x013D8ABC File Offset: 0x013D6CBC
		internal static bool QFqBjUtUOQ1o6XjKY3N3()
		{
			return false;
		}

		// Token: 0x04009FCC RID: 40908
		internal M973_PirateCave8 $self_$46745;

		// Token: 0x02001F0F RID: 7951
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B9C7 RID: 47559 RVA: 0x013D8AC0 File Offset: 0x013D6CC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave8 self_)
			{
				if (282533 - 411202 != -128668)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (26523 - 85285 != -58761)
					{
						base..ctor();
						if (32445 - 68096 != -35650)
						{
							this.$self_$46744 = self_;
							if (198287 - 482767 != -284479)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B9C8 RID: 47560 RVA: 0x013D8B58 File Offset: 0x013D6D58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (137382 - 575173 != -437790)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A6F;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (87960 - 341347 != -253386)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$self_$46744.SendMessage("fadeOut");
							if (7862 - 122609 != -114747)
							{
								continue;
							}
							goto IL_8D7;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (27672 - 445127 != -417455)
							{
								continue;
							}
							goto IL_57B;
						}
						else
						{
							if (Game.mPlayer)
							{
								if (181527 - 237671 == -56143)
								{
									continue;
								}
								this.$startPoint$46742 = GameObject.Find("StartPoint" + (Game.getPlayerSlot(PlayerData.UID) + 4));
								if (184233 - 141364 != 42869)
								{
									continue;
								}
								if (this.$startPoint$46742)
								{
									if (93467 - 227621 == -134153)
									{
										continue;
									}
									Game.mPlayer.transform.position = this.$startPoint$46742.transform.position;
									if (169788 - 478159 != -308371)
									{
										continue;
									}
									Game.mPlayer.transform.rotation = this.$startPoint$46742.transform.rotation;
									if (137562 - 569936 == -432373)
									{
										continue;
									}
									Game.mPlayer.SendMessage("PositionEvent");
									if (21559 - 296193 == -274633)
									{
										continue;
									}
								}
							}
							this.$self_$46744.S9WnqPMLYQD.alignToObject("EventCamera1");
							if (40437 - 68239 != -27802)
							{
								continue;
							}
							goto IL_81F;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (264580 - 481109 != -216528)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							if (this.$self_$46744.endMusic)
							{
								if (153838 - 204542 == -50703)
								{
									continue;
								}
								this.$self_$46744.audio.clip = this.$self_$46744.endMusic;
								if (128458 - 518161 != -389703)
								{
									continue;
								}
								if (!this.$self_$46744.audio.isPlaying)
								{
									if (5933 - 360833 != -354900)
									{
										continue;
									}
									if (Game.volume > 0)
									{
										if (275634 - 259647 != 15987)
										{
											continue;
										}
										this.$self_$46744.audio.Play();
										if (122958 - 97055 == 25904)
										{
											continue;
										}
									}
								}
							}
							this.$self_$46744.SendMessage("fadeIn");
							if (64558 - 136012 != -71453)
							{
								goto Block_63;
							}
							continue;
						}
						break;
					case 5:
						this.$mStoryGui$46743 = (StoryGui)this.$self_$46744.GetComponent(typeof(StoryGui));
						if (299444 - 298987 == 458)
						{
							continue;
						}
						if (!this.$mStoryGui$46743)
						{
							goto IL_68C;
						}
						if (136868 - 447511 == -310642)
						{
							continue;
						}
						this.$mStoryGui$46743.startStoryMessage("CaptainCrab", "Red Claw", eTalkType.enemy);
						if (199645 - 310393 == -110747)
						{
							continue;
						}
						this.$self_$46744.S9WnqPMLYQD.StartCoroutine_Auto(this.$self_$46744.S9WnqPMLYQD.slerpToObject("EventCamera2", (float)2));
						if (241871 - 329361 != -87490)
						{
							continue;
						}
						goto IL_A34;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (79174 - 379231 != -300056)
							{
								goto Block_68;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46743.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 811), eTalkType.enemy);
							if (234800 - 571987 != -337186)
							{
								goto Block_49;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (56891 - 71264 != -14372)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46743.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 812), eTalkType.enemy);
							if (175598 - 463280 != -287682)
							{
								continue;
							}
							goto IL_85A;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (129011 - 140265 != -11254)
							{
								continue;
							}
							goto IL_5D8;
						}
						else
						{
							this.$mStoryGui$46743.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 813), eTalkType.enemy);
							if (33934 - 463086 != -429152)
							{
								continue;
							}
							goto IL_6AE;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (195771 - 42670 != 153102)
							{
								goto Block_41;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46743.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 814), eTalkType.enemy);
							if (132833 - 377593 != -244759)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (53236 - 342962 != -289725)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46743.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 815), eTalkType.enemy);
							if (227913 - 300166 != -72253)
							{
								continue;
							}
							goto IL_3A2;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (277469 - 481390 != -203921)
							{
								continue;
							}
							goto IL_472;
						}
						else
						{
							this.$mStoryGui$46743.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 816), eTalkType.enemy);
							if (235597 - 48182 != 187415)
							{
								continue;
							}
							goto IL_56;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (200794 - 137301 != 63493)
							{
								continue;
							}
							goto IL_2F6;
						}
						else
						{
							this.$mStoryGui$46743.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 817), eTalkType.enemy);
							if (111488 - 129019 != -17530)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (112107 - 54954 != 57153)
							{
								continue;
							}
							goto IL_112;
						}
						else
						{
							this.$mStoryGui$46743.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 818), eTalkType.enemy);
							if (275068 - 542281 != -267212)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (30376 - 145363 != -114986)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46743.close();
							if (90486 - 25965 != 64522)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (20687 - 536184 != -515496)
							{
								goto Block_58;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9731, 9);
							if (27385 - 144495 != -117109)
							{
								goto IL_68C;
							}
							continue;
						}
						break;
					default:
						if (34561 - 428781 == -394219)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (93497 - 379746 == -286248)
					{
						continue;
					}
					this.$mGameGui$46741 = (GameGui)this.$self_$46744.GetComponent(typeof(GameGui));
					if (121152 - 258430 != -137278)
					{
						continue;
					}
					if (!this.$mGameGui$46741)
					{
						goto IL_92;
					}
					if (232264 - 414969 != -182705)
					{
						continue;
					}
					this.$mGameGui$46741.close();
					if (189768 - 597234 != -407466)
					{
						continue;
					}
					goto IL_92;
					IL_68C:
					this.YieldDefault(1);
					if (46333 - 458126 == -411793)
					{
						goto IL_A6F;
					}
				}
				IL_56:
				return this.Yield(12, new WaitForSeconds(3f));
				IL_92:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_7:
				IL_112:
				goto IL_A6F;
				Block_9:
				return this.Yield(14, new WaitForSeconds(3f));
				Block_12:
				return this.Yield(15, new WaitForSeconds(1f));
				IL_2F6:
				goto IL_A6F;
				Block_18:
				return this.Yield(13, new WaitForSeconds(3f));
				Block_21:
				goto IL_A6F;
				IL_3A2:
				return this.Yield(11, new WaitForSeconds(3f));
				IL_472:
				IL_57B:
				IL_5D8:
				goto IL_A6F;
				IL_6AE:
				return this.Yield(9, new WaitForSeconds(3f));
				Block_41:
				goto IL_A6F;
				Block_42:
				return this.Yield(10, new WaitForSeconds(3f));
				Block_44:
				Block_46:
				goto IL_A6F;
				Block_49:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_81F:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_51:
				goto IL_A6F;
				IL_85A:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_8D7:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_58:
				goto IL_A6F;
				Block_63:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_A34:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_68:
				IL_A6F:
				return false;
			}

			// Token: 0x0600B9C9 RID: 47561 RVA: 0x013D95E8 File Offset: 0x013D77E8
			internal static bool JFYTLKtUmv4sKPBum0Sm()
			{
				return true;
			}

			// Token: 0x0600B9CA RID: 47562 RVA: 0x013D95EC File Offset: 0x013D77EC
			internal static bool MNis9StUFpfNjXWZRX6c()
			{
				return false;
			}

			// Token: 0x04009FCD RID: 40909
			internal GameGui $mGameGui$46741;

			// Token: 0x04009FCE RID: 40910
			internal GameObject $startPoint$46742;

			// Token: 0x04009FCF RID: 40911
			internal StoryGui $mStoryGui$46743;

			// Token: 0x04009FD0 RID: 40912
			internal M973_PirateCave8 $self_$46744;
		}
	}

	// Token: 0x02001F10 RID: 7952
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$46746 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B9CB RID: 47563 RVA: 0x013D95F0 File Offset: 0x013D77F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$46746(M973_PirateCave8 self_)
		{
			if (140371 - 159376 != -19004)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (269407 - 503201 == -233794)
				{
					base..ctor();
					if (105176 - 363169 == -257993)
					{
						this.$self_$46749 = self_;
						if (196891 - 565905 == -369014)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B9CC RID: 47564 RVA: 0x013D9688 File Offset: 0x013D7888
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave8.$StartGame$46746.$(this.$self_$46749);
		}

		// Token: 0x0600B9CD RID: 47565 RVA: 0x013D9698 File Offset: 0x013D7898
		internal static bool XNrvV0tUMNcVrWidoPyd()
		{
			return true;
		}

		// Token: 0x0600B9CE RID: 47566 RVA: 0x013D969C File Offset: 0x013D789C
		internal static bool Y903AEtUxM9qwSB1cYrW()
		{
			return false;
		}

		// Token: 0x04009FD1 RID: 40913
		internal M973_PirateCave8 $self_$46749;

		// Token: 0x02001F11 RID: 7953
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B9CF RID: 47567 RVA: 0x013D96A0 File Offset: 0x013D78A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave8 self_)
			{
				if (151145 - 180151 != -29005)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (49270 - 281547 != -232276)
					{
						base..ctor();
						if (172548 - 533497 == -360949)
						{
							this.$self_$46748 = self_;
							if (244574 - 408831 == -164257)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B9D0 RID: 47568 RVA: 0x013D9738 File Offset: 0x013D7938
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229188 - 58235 != 170953)
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
						if (9992 - 361311 == -351318)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (111705 - 228274 != -116569)
						{
							continue;
						}
						this.YieldDefault(1);
						if (56567 - 593442 != -536875)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (262392 - 323487 != -61095)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (54927 - 421364 != -366436)
					{
						Game.mGameState = eGameState.Start;
						if (227813 - 47898 != 179916)
						{
							Game.mStateTime = Time.time;
							if (80085 - 420831 == -340746)
							{
								this.$mGameGui$46747 = (GameGui)this.$self_$46748.GetComponent(typeof(GameGui));
								if (30305 - 548837 == -518532)
								{
									this.$mGameGui$46747.enabled = true;
									if (104565 - 376858 != -272292)
									{
										this.$self_$46748.SendMessage("fadeIn");
										if (8434 - 320372 != -311937)
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

			// Token: 0x0600B9D1 RID: 47569 RVA: 0x013D9910 File Offset: 0x013D7B10
			internal static bool wRx4TntUg8nCGkFdF5XL()
			{
				return true;
			}

			// Token: 0x0600B9D2 RID: 47570 RVA: 0x013D9914 File Offset: 0x013D7B14
			internal static bool zbJHMDtUfy4LOVGJ5dZW()
			{
				return false;
			}

			// Token: 0x04009FD2 RID: 40914
			internal GameGui $mGameGui$46747;

			// Token: 0x04009FD3 RID: 40915
			internal M973_PirateCave8 $self_$46748;
		}
	}

	// Token: 0x02001F12 RID: 7954
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46750 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B9D3 RID: 47571 RVA: 0x013D9918 File Offset: 0x013D7B18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46750(M973_PirateCave8 self_)
		{
			if (203297 - 473814 != -270516)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193321 - 488116 == -294795)
				{
					base..ctor();
					if (160893 - 346416 != -185522)
					{
						this.$self_$46755 = self_;
						if (791 - 504997 != -504205)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B9D4 RID: 47572 RVA: 0x013D99B0 File Offset: 0x013D7BB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave8.$onDeadPlayer$46750.$(this.$self_$46755);
		}

		// Token: 0x0600B9D5 RID: 47573 RVA: 0x013D99C0 File Offset: 0x013D7BC0
		internal static bool hVwfuYtUnwC9PdMxnXgJ()
		{
			return true;
		}

		// Token: 0x0600B9D6 RID: 47574 RVA: 0x013D99C4 File Offset: 0x013D7BC4
		internal static bool QUpy59tU68gtng6W2tLw()
		{
			return false;
		}

		// Token: 0x04009FD4 RID: 40916
		internal M973_PirateCave8 $self_$46755;

		// Token: 0x02001F13 RID: 7955
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B9D7 RID: 47575 RVA: 0x013D99C8 File Offset: 0x013D7BC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave8 self_)
			{
				if (238227 - 264630 != -26402)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (74746 - 434687 == -359941)
					{
						base..ctor();
						if (200310 - 491736 == -291426)
						{
							this.$self_$46754 = self_;
							if (64053 - 546878 == -482825)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B9D8 RID: 47576 RVA: 0x013D9A60 File Offset: 0x013D7C60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (169798 - 569838 != -400040)
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
							if (112131 - 25987 == 86145)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1DA;
							}
							if (121838 - 159656 == -37817)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (250158 - 268612 != -18454)
						{
							continue;
						}
						this.$mStoryGui$46751 = (StoryGui)this.$self_$46754.GetComponent(typeof(StoryGui));
						if (189324 - 476233 != -286909)
						{
							continue;
						}
						if (this.$mStoryGui$46751)
						{
							if (191371 - 276677 == -85305)
							{
								continue;
							}
							this.$mStoryGui$46751.close();
							if (173590 - 212588 == -38997)
							{
								continue;
							}
						}
						this.$mChangeGui$46752 = (ChangeGui)this.$self_$46754.GetComponent(typeof(ChangeGui));
						if (23373 - 330699 == -307325)
						{
							continue;
						}
						if (this.$mChangeGui$46752)
						{
							if (73074 - 443058 == -369983)
							{
								continue;
							}
							this.$mChangeGui$46752.close();
							if (81372 - 378735 != -297363)
							{
								continue;
							}
						}
						this.$mGameGui$46753 = (GameGui)this.$self_$46754.GetComponent(typeof(GameGui));
						if (71622 - 585770 == -514147)
						{
							continue;
						}
						if (this.$mGameGui$46753)
						{
							if (255315 - 47117 != 208198)
							{
								continue;
							}
							if (!this.$mGameGui$46753.enabled)
							{
								if (24566 - 134889 != -110323)
								{
									continue;
								}
								this.$mGameGui$46753.enabled = true;
								if (268104 - 159964 != 108140)
								{
									continue;
								}
							}
							this.$mGameGui$46753.openDeadMenu();
							if (122911 - 478771 == -355859)
							{
								continue;
							}
						}
						IL_1DA:
						this.YieldDefault(1);
						if (258547 - 393697 != -135150)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (272822 - 223334 == 49489)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (232993 - 201964 != 31029);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600B9D9 RID: 47577 RVA: 0x013D9D78 File Offset: 0x013D7F78
			internal static bool mvFYL0tUi3R79RVDe2il()
			{
				return true;
			}

			// Token: 0x0600B9DA RID: 47578 RVA: 0x013D9D7C File Offset: 0x013D7F7C
			internal static bool sU264utUKmGJyWxgUfvB()
			{
				return false;
			}

			// Token: 0x04009FD5 RID: 40917
			internal StoryGui $mStoryGui$46751;

			// Token: 0x04009FD6 RID: 40918
			internal ChangeGui $mChangeGui$46752;

			// Token: 0x04009FD7 RID: 40919
			internal GameGui $mGameGui$46753;

			// Token: 0x04009FD8 RID: 40920
			internal M973_PirateCave8 $self_$46754;
		}
	}

	// Token: 0x02001F14 RID: 7956
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46756 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B9DB RID: 47579 RVA: 0x013D9D80 File Offset: 0x013D7F80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46756(Hashtable data, M973_PirateCave8 self_)
		{
			if (203918 - 102 != 203817)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (157528 - 149656 != 7873)
				{
					base..ctor();
					if (141563 - 361505 != -219941)
					{
						this.$data$46761 = data;
						if (221778 - 404478 != -182699)
						{
							this.$self_$46762 = self_;
							if (291269 - 162933 == 128336)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B9DC RID: 47580 RVA: 0x013D9E3C File Offset: 0x013D803C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave8.$onChangePlayer$46756.$(this.$data$46761, this.$self_$46762);
		}

		// Token: 0x0600B9DD RID: 47581 RVA: 0x013D9E50 File Offset: 0x013D8050
		internal static bool TEZ0b7tUdn2l0Xbtdjab()
		{
			return true;
		}

		// Token: 0x0600B9DE RID: 47582 RVA: 0x013D9E54 File Offset: 0x013D8054
		internal static bool ymSQmCtUJOg27dGBXC6b()
		{
			return false;
		}

		// Token: 0x04009FD9 RID: 40921
		internal Hashtable $data$46761;

		// Token: 0x04009FDA RID: 40922
		internal M973_PirateCave8 $self_$46762;

		// Token: 0x02001F15 RID: 7957
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B9DF RID: 47583 RVA: 0x013D9E58 File Offset: 0x013D8058
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave8 self_)
			{
				if (214014 - 333556 != -119542)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (29319 - 409361 != -380041)
					{
						base..ctor();
						if (103652 - 239857 == -136205)
						{
							this.$data$46759 = data;
							if (107279 - 357343 == -250064)
							{
								this.$self_$46760 = self_;
								if (103727 - 220862 != -117134)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B9E0 RID: 47584 RVA: 0x013D9F14 File Offset: 0x013D8114
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (170245 - 351363 != -181118)
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
							if (196385 - 225009 != -28624)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (272660 - 545522 == -272861)
							{
								continue;
							}
							this.$mGameGui$46758 = (GameGui)this.$self_$46760.GetComponent(typeof(GameGui));
							if (118709 - 490252 != -371543)
							{
								continue;
							}
							this.$mGameGui$46758.enabled = true;
							if (75615 - 151276 == -75660)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (106293 - 95306 != 10987)
						{
							continue;
						}
						goto IL_205;
					default:
						if (35343 - 435308 == -399964)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (24411 - 182587 != -158175)
					{
						this.$self_$46760.SendMessage("onCreatePlayer", this.$data$46759);
						if (240859 - 297353 != -56493)
						{
							this.$mChangeGui$46757 = (ChangeGui)this.$self_$46760.GetComponent(typeof(ChangeGui));
							if (157273 - 33261 != 124013)
							{
								if (!this.$mChangeGui$46757.enabled)
								{
									break;
								}
								if (143696 - 211964 == -68268)
								{
									this.$mChangeGui$46757.close();
									if (156922 - 18259 == 138663)
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

			// Token: 0x0600B9E1 RID: 47585 RVA: 0x013DA138 File Offset: 0x013D8338
			internal static bool wr71NstUDBVHnJgjEfFE()
			{
				return true;
			}

			// Token: 0x0600B9E2 RID: 47586 RVA: 0x013DA13C File Offset: 0x013D833C
			internal static bool ITYH1ytUvhaCtWkUaq5i()
			{
				return false;
			}

			// Token: 0x04009FDB RID: 40923
			internal ChangeGui $mChangeGui$46757;

			// Token: 0x04009FDC RID: 40924
			internal GameGui $mGameGui$46758;

			// Token: 0x04009FDD RID: 40925
			internal Hashtable $data$46759;

			// Token: 0x04009FDE RID: 40926
			internal M973_PirateCave8 $self_$46760;
		}
	}

	// Token: 0x02001F16 RID: 7958
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46763 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B9E3 RID: 47587 RVA: 0x013DA140 File Offset: 0x013D8340
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46763(Hashtable data, M973_PirateCave8 self_)
		{
			if (92399 - 543808 != -451409)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (205753 - 90360 == 115393)
				{
					base..ctor();
					if (7103 - 117561 == -110458)
					{
						this.$data$46771 = data;
						if (286368 - 333672 != -47303)
						{
							this.$self_$46772 = self_;
							if (40017 - 91231 == -51214)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B9E4 RID: 47588 RVA: 0x013DA1FC File Offset: 0x013D83FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave8.$onGameComplete$46763.$(this.$data$46771, this.$self_$46772);
		}

		// Token: 0x0600B9E5 RID: 47589 RVA: 0x013DA210 File Offset: 0x013D8410
		internal static bool W8mkMEtURCltmYpu6Jvn()
		{
			return true;
		}

		// Token: 0x0600B9E6 RID: 47590 RVA: 0x013DA214 File Offset: 0x013D8414
		internal static bool FpZwxVtUw6wDnq4jU7D5()
		{
			return false;
		}

		// Token: 0x04009FDF RID: 40927
		internal Hashtable $data$46771;

		// Token: 0x04009FE0 RID: 40928
		internal M973_PirateCave8 $self_$46772;

		// Token: 0x02001F17 RID: 7959
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B9E7 RID: 47591 RVA: 0x013DA218 File Offset: 0x013D8418
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave8 self_)
			{
				if (234494 - 246421 != -11927)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (153585 - 362862 == -209277)
					{
						base..ctor();
						if (298175 - 16475 == 281700)
						{
							this.$data$46769 = data;
							if (227372 - 412885 != -185512)
							{
								this.$self_$46770 = self_;
								if (296165 - 28953 == 267212)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B9E8 RID: 47592 RVA: 0x013DA2D4 File Offset: 0x013D84D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (35191 - 198796 != -163604)
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
						this.$mCompleteGui$46765 = (CompleteGui)this.$self_$46770.GetComponent(typeof(CompleteGui));
						if (102859 - 522713 != -419854)
						{
							continue;
						}
						this.$mCompleteGui$46765.Init();
						if (145537 - 64054 == 81484)
						{
							continue;
						}
						this.$mCompleteGui$46765.readData(this.$data$46769);
						if (8556 - 571487 != -562931)
						{
							continue;
						}
						if (this.$result$46764 == 1)
						{
							if (53601 - 154930 == -101328)
							{
								continue;
							}
							this.$mCompleteGui$46765.displayResult(eCompleteType.Success);
							if (45668 - 528016 == -482347)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46765.displayResult(eCompleteType.Failed);
							if (46496 - 459114 == -412617)
							{
								continue;
							}
						}
						this.$mGameGui$46766 = (GameGui)this.$self_$46770.GetComponent(typeof(GameGui));
						if (119722 - 102781 == 16942)
						{
							continue;
						}
						this.$mStoryGui$46767 = (StoryGui)this.$self_$46770.GetComponent(typeof(StoryGui));
						if (223512 - 347115 != -123603)
						{
							continue;
						}
						this.$mChangeGui$46768 = (ChangeGui)this.$self_$46770.GetComponent(typeof(ChangeGui));
						if (82237 - 79074 == 3164)
						{
							continue;
						}
						if (this.$mGameGui$46766)
						{
							if (271517 - 468861 == -197343)
							{
								continue;
							}
							this.$mGameGui$46766.close();
							if (104898 - 116042 == -11143)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46767)
						{
							if (88760 - 18931 != 69829)
							{
								continue;
							}
							this.$mStoryGui$46767.close();
							if (105923 - 525880 == -419956)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46768)
						{
							if (291064 - 433627 == -142562)
							{
								continue;
							}
							this.$mChangeGui$46768.disable();
							if (225906 - 468704 == -242797)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (7229 - 577627 != -570397)
						{
							goto Block_9;
						}
						continue;
					default:
						if (247483 - 563204 == -315720)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46769[31]);
					if (33223 - 420133 != -386909)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (294415 - 94716 != 199700)
							{
								goto Block_23;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (6042 - 73233 == -67191)
							{
								this.$result$46764 = RuntimeServices.UnboxInt32(this.$data$46769[31]);
								if (132125 - 123265 != 8861)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_9:
				Block_23:
				IL_3DB:
				return false;
			}

			// Token: 0x0600B9E9 RID: 47593 RVA: 0x013DA6D0 File Offset: 0x013D88D0
			internal static bool NUrcvgtUqNkRpy1gIsFZ()
			{
				return true;
			}

			// Token: 0x0600B9EA RID: 47594 RVA: 0x013DA6D4 File Offset: 0x013D88D4
			internal static bool vJNHwItU7hfmAXGsCRnM()
			{
				return false;
			}

			// Token: 0x04009FE1 RID: 40929
			internal int $result$46764;

			// Token: 0x04009FE2 RID: 40930
			internal CompleteGui $mCompleteGui$46765;

			// Token: 0x04009FE3 RID: 40931
			internal GameGui $mGameGui$46766;

			// Token: 0x04009FE4 RID: 40932
			internal StoryGui $mStoryGui$46767;

			// Token: 0x04009FE5 RID: 40933
			internal ChangeGui $mChangeGui$46768;

			// Token: 0x04009FE6 RID: 40934
			internal Hashtable $data$46769;

			// Token: 0x04009FE7 RID: 40935
			internal M973_PirateCave8 $self_$46770;
		}
	}

	// Token: 0x02001F18 RID: 7960
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46773 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B9EB RID: 47595 RVA: 0x013DA6D8 File Offset: 0x013D88D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46773(M973_PirateCave8 self_)
		{
			if (214026 - 275827 != -61801)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (19464 - 417123 != -397658)
				{
					base..ctor();
					if (184793 - 255468 == -70675)
					{
						this.$self_$46777 = self_;
						if (44807 - 149196 != -104388)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B9EC RID: 47596 RVA: 0x013DA770 File Offset: 0x013D8970
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave8.$ReturnToTown$46773.$(this.$self_$46777);
		}

		// Token: 0x0600B9ED RID: 47597 RVA: 0x013DA780 File Offset: 0x013D8980
		internal static bool OnERnTtUPLOr7AwdJNCq()
		{
			return true;
		}

		// Token: 0x0600B9EE RID: 47598 RVA: 0x013DA784 File Offset: 0x013D8984
		internal static bool MsFokJtU0JNaXiP5NQxM()
		{
			return false;
		}

		// Token: 0x04009FE8 RID: 40936
		internal M973_PirateCave8 $self_$46777;

		// Token: 0x02001F19 RID: 7961
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B9EF RID: 47599 RVA: 0x013DA788 File Offset: 0x013D8988
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave8 self_)
			{
				if (278086 - 537818 != -259732)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (160638 - 7693 != 152946)
					{
						base..ctor();
						if (121366 - 265408 != -144041)
						{
							this.$self_$46776 = self_;
							if (151062 - 226009 != -74946)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B9F0 RID: 47600 RVA: 0x013DA820 File Offset: 0x013D8A20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (186762 - 92917 != 93845)
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
						this.$self_$46776.LeaveGame();
						if (270738 - 250684 == 20055)
						{
							continue;
						}
						this.YieldDefault(1);
						if (125448 - 418976 != -293528)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (78020 - 98684 == -20663)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (224524 - 229791 != -5266)
					{
						Game.mStateTime = Time.time;
						if (101339 - 96717 == 4622)
						{
							this.$$switch$8725$46774 = PlayerData.SaveGuild;
							if (172473 - 51301 != 121173)
							{
								if (this.$$switch$8725$46774 == 1)
								{
									if (205714 - 203523 == 2192)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (240569 - 136898 == 103672)
									{
										continue;
									}
								}
								else if (this.$$switch$8725$46774 == 2)
								{
									if (18371 - 325625 != -307254)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (36616 - 286615 != -249999)
									{
										continue;
									}
								}
								else if (this.$$switch$8725$46774 == 3)
								{
									if (249934 - 119273 != 130661)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (120834 - 311879 == -191044)
									{
										continue;
									}
								}
								else if (this.$$switch$8725$46774 == 4)
								{
									if (106315 - 509752 != -403437)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (37478 - 305598 != -268120)
									{
										continue;
									}
								}
								else if (this.$$switch$8725$46774 == 5)
								{
									if (2203 - 463501 != -461298)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (161507 - 306964 == -145456)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (138483 - 266901 == -128417)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (10696 - 72149 == -61452)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (215589 - 433585 == -217995)
									{
										continue;
									}
								}
								this.$mGameGui$46775 = (GameGui)this.$self_$46776.GetComponent(typeof(GameGui));
								if (87581 - 142736 == -55155)
								{
									if (this.$mGameGui$46775)
									{
										if (152088 - 96781 == 55308)
										{
											continue;
										}
										this.$mGameGui$46775.close();
										if (236165 - 20506 == 215660)
										{
											continue;
										}
									}
									this.$self_$46776.SendMessage("fadeOut");
									if (7257 - 579581 != -572323)
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

			// Token: 0x0600B9F1 RID: 47601 RVA: 0x013DABEC File Offset: 0x013D8DEC
			internal static bool PyeLbetUbOtEyGkWhvsc()
			{
				return true;
			}

			// Token: 0x0600B9F2 RID: 47602 RVA: 0x013DABF0 File Offset: 0x013D8DF0
			internal static bool FQuOVctUunKE23QduDvF()
			{
				return false;
			}

			// Token: 0x04009FE9 RID: 40937
			internal int $$switch$8725$46774;

			// Token: 0x04009FEA RID: 40938
			internal GameGui $mGameGui$46775;

			// Token: 0x04009FEB RID: 40939
			internal M973_PirateCave8 $self_$46776;
		}
	}

	// Token: 0x02001F1A RID: 7962
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46778 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B9F3 RID: 47603 RVA: 0x013DABF4 File Offset: 0x013D8DF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46778(M973_PirateCave8 self_)
		{
			if (176190 - 119386 != 56805)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292367 - 386413 == -94046)
				{
					base..ctor();
					if (237941 - 503344 != -265402)
					{
						this.$self_$46781 = self_;
						if (168210 - 66669 == 101541)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B9F4 RID: 47604 RVA: 0x013DAC8C File Offset: 0x013D8E8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave8.$ReturnToGuild$46778.$(this.$self_$46781);
		}

		// Token: 0x0600B9F5 RID: 47605 RVA: 0x013DAC9C File Offset: 0x013D8E9C
		internal static bool ttkD11tUIe8jZpbE2Tqd()
		{
			return true;
		}

		// Token: 0x0600B9F6 RID: 47606 RVA: 0x013DACA0 File Offset: 0x013D8EA0
		internal static bool sCGHs7tUBkk7qImnWfgQ()
		{
			return false;
		}

		// Token: 0x04009FEC RID: 40940
		internal M973_PirateCave8 $self_$46781;

		// Token: 0x02001F1B RID: 7963
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B9F7 RID: 47607 RVA: 0x013DACA4 File Offset: 0x013D8EA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave8 self_)
			{
				if (242169 - 213200 != 28969)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (275172 - 39469 != 235704)
					{
						base..ctor();
						if (258703 - 425458 == -166755)
						{
							this.$self_$46780 = self_;
							if (10524 - 451359 != -440834)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B9F8 RID: 47608 RVA: 0x013DAD3C File Offset: 0x013D8F3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (154029 - 591560 != -437530)
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
						this.$self_$46780.LeaveGame();
						if (204978 - 428924 != -223946)
						{
							continue;
						}
						this.YieldDefault(1);
						if (111692 - 378760 != -267068)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (224898 - 443448 == -218549)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (294475 - 23529 != 270947)
					{
						Game.mStateTime = Time.time;
						if (235236 - 281954 != -46717)
						{
							Game.mNextGameCode = 31;
							if (207438 - 357440 != -150001)
							{
								this.$mGameGui$46779 = (GameGui)this.$self_$46780.GetComponent(typeof(GameGui));
								if (296056 - 190269 == 105787)
								{
									if (this.$mGameGui$46779)
									{
										if (1793 - 560394 != -558601)
										{
											continue;
										}
										this.$mGameGui$46779.close();
										if (19862 - 108796 != -88934)
										{
											continue;
										}
									}
									this.$self_$46780.SendMessage("fadeOut");
									if (1186 - 323094 != -321907)
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

			// Token: 0x0600B9F9 RID: 47609 RVA: 0x013DAF18 File Offset: 0x013D9118
			internal static bool AnCoH2tUeMviFCDJMFtA()
			{
				return true;
			}

			// Token: 0x0600B9FA RID: 47610 RVA: 0x013DAF1C File Offset: 0x013D911C
			internal static bool BmwDDXtUrUHhaeR6P6QF()
			{
				return false;
			}

			// Token: 0x04009FED RID: 40941
			internal GameGui $mGameGui$46779;

			// Token: 0x04009FEE RID: 40942
			internal M973_PirateCave8 $self_$46780;
		}
	}

	// Token: 0x02001F1C RID: 7964
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46782 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B9FB RID: 47611 RVA: 0x013DAF20 File Offset: 0x013D9120
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46782(M973_PirateCave8 self_)
		{
			if (108997 - 463986 != -354988)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (262603 - 400819 != -138215)
				{
					base..ctor();
					if (58365 - 237024 == -178659)
					{
						this.$self_$46785 = self_;
						if (16698 - 185240 == -168542)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B9FC RID: 47612 RVA: 0x013DAFB8 File Offset: 0x013D91B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave8.$ReturnToCamp$46782.$(this.$self_$46785);
		}

		// Token: 0x0600B9FD RID: 47613 RVA: 0x013DAFC8 File Offset: 0x013D91C8
		internal static bool DF1OfLtUjNiq2Nr2fJp3()
		{
			return true;
		}

		// Token: 0x0600B9FE RID: 47614 RVA: 0x013DAFCC File Offset: 0x013D91CC
		internal static bool MeUfVNtUh5FpDgsIvsvg()
		{
			return false;
		}

		// Token: 0x04009FEF RID: 40943
		internal M973_PirateCave8 $self_$46785;

		// Token: 0x02001F1D RID: 7965
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B9FF RID: 47615 RVA: 0x013DAFD0 File Offset: 0x013D91D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave8 self_)
			{
				if (264444 - 220377 != 44067)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (68347 - 367806 != -299458)
					{
						base..ctor();
						if (108016 - 566539 == -458523)
						{
							this.$self_$46784 = self_;
							if (275465 - 495113 != -219647)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BA00 RID: 47616 RVA: 0x013DB068 File Offset: 0x013D9268
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (267125 - 517068 != -249943)
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
						this.$self_$46784.LeaveGame();
						if (288327 - 387991 != -99664)
						{
							continue;
						}
						this.YieldDefault(1);
						if (249589 - 267852 != -18262)
						{
							goto Block_12;
						}
						continue;
					default:
						if (20276 - 243108 != -222832)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (16436 - 273814 != -257377)
					{
						Game.mStateTime = Time.time;
						if (167161 - 425303 == -258142)
						{
							Game.mNextGameCode = 33;
							if (78513 - 549226 != -470712)
							{
								this.$mGameGui$46783 = (GameGui)this.$self_$46784.GetComponent(typeof(GameGui));
								if (47925 - 341678 == -293753)
								{
									if (this.$mGameGui$46783)
									{
										if (52587 - 94948 != -42361)
										{
											continue;
										}
										this.$mGameGui$46783.close();
										if (124338 - 434958 != -310620)
										{
											continue;
										}
									}
									this.$self_$46784.SendMessage("fadeOut");
									if (101809 - 556082 == -454273)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_12:
				IL_1BD:
				return false;
			}

			// Token: 0x0600BA01 RID: 47617 RVA: 0x013DB244 File Offset: 0x013D9444
			internal static bool Qv0AREtUs6bSfPOwBtBT()
			{
				return true;
			}

			// Token: 0x0600BA02 RID: 47618 RVA: 0x013DB248 File Offset: 0x013D9448
			internal static bool qHUqubtU9Fre8kymeKbX()
			{
				return false;
			}

			// Token: 0x04009FF0 RID: 40944
			internal GameGui $mGameGui$46783;

			// Token: 0x04009FF1 RID: 40945
			internal M973_PirateCave8 $self_$46784;
		}
	}
}
