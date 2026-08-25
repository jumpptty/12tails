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

// Token: 0x02001BE0 RID: 7136
[Serializable]
public class M941_SkyBug : MonoBehaviour
{
	// Token: 0x0600A68B RID: 42635 RVA: 0x012BE5C8 File Offset: 0x012BC7C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M941_SkyBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A68C RID: 42636 RVA: 0x012BE5D8 File Offset: 0x012BC7D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (230390 - 283447 != -53057)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (113869 - 247811 != -133941)
			{
				Game.mGameType = 5;
				if (159106 - 447298 == -288192)
				{
					if (Chat.Initialized)
					{
						if (237907 - 240121 == -2213)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (177388 - 151858 == 25531)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (255740 - 425619 != -169879)
						{
							continue;
						}
					}
					this.MfRnt5ELtQZ = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (279435 - 558508 == -279073)
					{
						this.G2LntcRqSPi = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (252601 - 386661 == -134060)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A68D RID: 42637 RVA: 0x012BE730 File Offset: 0x012BC930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (252031 - 527108 != -275077)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (277323 - 418885 != -141561)
				{
					if (Game.mNextGameCode != 941)
					{
						break;
					}
					if (80338 - 357137 != -276798)
					{
						Game.nextGame();
						if (100949 - 226236 == -125287)
						{
							Game.mGameCode = 941;
							if (108908 - 106944 == 1964)
							{
								Game.mGameType = 5;
								if (291632 - 522385 != -230752)
								{
									Game.mGameTime = Time.time;
									if (169405 - 322538 == -153133)
									{
										Game.mGameScore = 0;
										if (169069 - 286079 != -117009)
										{
											Game.mGameMana = 0;
											if (26417 - 394926 != -368508)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (289889 - 430391 == -140502)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (207673 - 441435 != -233761)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (227967 - 462450 != -234482)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (184557 - 70880 == 113677)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (149269 - 24156 == 125113)
																{
																	this.nYHn6hth8Jf = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (265202 - 373996 == -108794)
																	{
																		this.rInn6K0Fjno = (GameGui)this.GetComponent(typeof(GameGui));
																		if (78124 - 493158 == -415034)
																		{
																			this.cTfn6VEXpNd = PhotonClient.Connection;
																			if (85894 - 222221 == -136327)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (50927 - 142427 == -91500)
																				{
																					this.InitGame();
																					if (20368 - 341141 == -320773)
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
			else
			{
				Debug.Log("Not Connected");
				if (140865 - 231222 == -90357)
				{
					Game.mGameType = 99;
					if (207579 - 255255 == -47676)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A68E RID: 42638 RVA: 0x012BEA6C File Offset: 0x012BCC6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (59781 - 574769 != -514988)
		{
		}
		for (;;)
		{
			if (this.cTfn6VEXpNd == null)
			{
				if (274750 - 460061 == -185311)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (245050 - 364253 == -119203)
				{
					if (mGameState == eGameState.Init)
					{
						if (274471 - 513368 != -238896)
						{
							this.audio.volume = (float)0;
							if (135031 - 82620 != 52412)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (287256 - 203439 == 83817)
						{
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (279913 - 61116 == 218798)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (133636 - 158183 == -24546)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (186762 - 385705 != -198943)
								{
									continue;
								}
							}
							if (Game.music == 0)
							{
								break;
							}
							if (296437 - 347876 != -51438)
							{
								if (this.audio.isPlaying)
								{
									break;
								}
								if (104691 - 19781 == 84910)
								{
									this.audio.Play();
									if (190447 - 175542 == 14905)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						if (mGameState != eGameState.Hold)
						{
							if (272409 - 198639 != 73770)
							{
								continue;
							}
							if (mGameState != eGameState.Normal)
							{
								break;
							}
							if (247944 - 374556 == -126611)
							{
								continue;
							}
						}
						if (Time.time > this.BcIn6zTjdoK)
						{
							if (251736 - 389304 != -137568)
							{
								continue;
							}
							Game.mGameMana++;
							if (72425 - 259781 == -187355)
							{
								continue;
							}
							this.BcIn6zTjdoK = Time.time + (float)12;
							if (199373 - 589645 == -390271)
							{
								continue;
							}
						}
						this.audio.volume = 0.1f * (float)Game.music;
						if (127501 - 469624 != -342122)
						{
							if (Game.music != 0)
							{
								if (81162 - 150051 != -68889)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (239322 - 359555 == -120232)
									{
										continue;
									}
									this.audio.Play();
									if (212597 - 442279 != -229682)
									{
										continue;
									}
								}
							}
							if (this.audio.volume < 0.1f * (float)Game.music)
							{
								if (15527 - 553326 != -537798)
								{
									this.audio.volume = this.audio.volume + Time.deltaTime;
									if (217744 - 422934 == -205190)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (12760 - 460416 == -447656)
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

	// Token: 0x0600A68F RID: 42639 RVA: 0x012BEE8C File Offset: 0x012BD08C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (20828 - 577616 != -556787)
		{
		}
		for (;;)
		{
			if (!this.MfRnt5ELtQZ)
			{
				if (157122 - 389710 != -232587)
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
				if (237363 - 493187 == -255824)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (43136 - 326050 != -282913)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (82713 - 62722 != 19992)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (229573 - 106893 != 122681)
							{
								GUI.depth = 1;
								if (114927 - 357173 != -242245)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
									if (149868 - 334573 != -184704)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
										if (178471 - 596334 != -417862)
										{
											Color color = GUI.color;
											if (258983 - 60710 != 198274)
											{
												color.a = a;
												if (272714 - 474654 == -201940)
												{
													if (227822 - 341332 == -113510)
													{
														Color color2 = GUI.color = color;
														if (273686 - 260087 != 13600)
														{
															if (265454 - 202103 == 63351)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.MfRnt5ELtQZ);
																if (9171 - 483952 == -474781)
																{
																	float a2 = 1f;
																	if (54180 - 421718 != -367537)
																	{
																		Color color3 = GUI.color;
																		if (15713 - 594066 == -578353)
																		{
																			color3.a = a2;
																			if (70116 - 269379 != -199262 && 206670 - 77881 != 128790)
																			{
																				GUI.color = color3;
																				if (68764 - 196929 != -128164)
																				{
																					if (256660 - 334142 == -77482)
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

	// Token: 0x0600A690 RID: 42640 RVA: 0x012BF20C File Offset: 0x012BD40C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (2756 - 590237 != -587480)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (10207 - 514812 != -504604)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (255597 - 292027 == -36430)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (40004 - 60413 == -20409)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (219216 - 301074 == -81858)
						{
							int num4 = num;
							if (278743 - 493853 == -215110)
							{
								if (num4 == 9411)
								{
									if (261992 - 491679 == -229687)
									{
										Debug.Log("On SkyBug Dead");
										if (210032 - 534704 == -324672)
										{
											this.StartCoroutine_Auto(this.EndEvent());
											if (72442 - 217817 != -145374)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (num4 != 9412)
									{
										break;
									}
									if (166780 - 140577 == 26203)
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

	// Token: 0x0600A691 RID: 42641 RVA: 0x012BF3B8 File Offset: 0x012BD5B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M941_SkyBug.$StartEvent$44239(this).GetEnumerator();
	}

	// Token: 0x0600A692 RID: 42642 RVA: 0x012BF3C8 File Offset: 0x012BD5C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M941_SkyBug.$EndEvent$44244(this).GetEnumerator();
	}

	// Token: 0x0600A693 RID: 42643 RVA: 0x012BF3D8 File Offset: 0x012BD5D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther()
	{
		return new M941_SkyBug.$TalkToPanther$44249(this).GetEnumerator();
	}

	// Token: 0x0600A694 RID: 42644 RVA: 0x012BF3E8 File Offset: 0x012BD5E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (115003 - 505904 != -390900)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (168374 - 589762 != -421387)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (24313 - 572286 == -547973)
				{
					Hashtable customOpParameters = new Hashtable();
					if (51709 - 456881 != -405171)
					{
						this.cTfn6VEXpNd.OpCustom(52, customOpParameters, true);
						if (245600 - 592755 != -347154)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A695 RID: 42645 RVA: 0x012BF4BC File Offset: 0x012BD6BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (79304 - 27077 != 52227)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (277121 - 479950 == -202829)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (291935 - 462611 == -170676)
				{
					Game.mGameState = eGameState.Setup;
					if (247967 - 509975 != -262007)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A696 RID: 42646 RVA: 0x012BF560 File Offset: 0x012BD760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (152144 - 331723 != -179578)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (225766 - 533395 == -307629)
			{
				if (num == PlayerData.UID)
				{
					if (78374 - 432023 != -353648)
					{
						this.SetupActors();
						if (288384 - 443839 == -155455)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (149035 - 144664 == 4371)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A697 RID: 42647 RVA: 0x012BF630 File Offset: 0x012BD830
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (126734 - 484741 != -358006)
		{
		}
		for (;;)
		{
			IL_225:
			Debug.Log("Creating Actors");
			if (156347 - 461153 == -304806)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (213502 - 240946 == -27444)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (208607 - 316265 == -107658)
						{
							int i = 0;
							if (158192 - 106258 == 51934)
							{
								CharacterControl[] array2 = array;
								if (111056 - 124468 != -13411)
								{
									int length = array2.Length;
									if (83600 - 143981 == -60381)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (285891 - 6334 != 279557)
												{
													goto IL_225;
												}
												if (!(array2[i].Type == "SkyBug"))
												{
													goto IL_24E;
												}
												if (255379 - 310372 == -54992)
												{
													goto IL_225;
												}
												if (!Game.useAdvanceMode)
												{
													goto IL_24E;
												}
												if (135660 - 470447 == -334786)
												{
													goto IL_225;
												}
												this.createActor("SkyBug2", array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (25082 - 295165 == -270082)
												{
													goto IL_225;
												}
												IL_29F:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (74323 - 326722 == -252398)
												{
													goto IL_225;
												}
												this.RWontQaWl1K++;
												if (24779 - 177648 != -152868)
												{
													goto IL_D3;
												}
												goto IL_225;
												IL_24E:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (25580 - 139964 != -114383)
												{
													goto IL_29F;
												}
												goto IL_225;
											}
											IL_D3:
											i++;
											if (187344 - 380778 != -193434)
											{
												goto IL_225;
											}
										}
										if (29531 - 280133 == -250602)
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
						if (15581 - 332245 != -316663)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A698 RID: 42648 RVA: 0x012BF914 File Offset: 0x012BDB14
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (92538 - 543320 != -450782)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (206707 - 160432 != 46276)
			{
				int i = 0;
				if (189255 - 33575 != 155681)
				{
					CharacterControl[] array2 = array;
					if (120393 - 136730 == -16337)
					{
						int length = array2.Length;
						if (234771 - 180915 == 53856)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (60287 - 183174 != -122887)
								{
									goto IL_1A;
								}
								i++;
								if (102872 - 572879 != -470007)
								{
									goto IL_1A;
								}
							}
							if (92915 - 224920 == -132005)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A699 RID: 42649 RVA: 0x012BFA44 File Offset: 0x012BDC44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (49529 - 243542 != -194012)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (69918 - 37435 == 32483)
			{
				Game.mGameState = eGameState.Ready;
				if (39340 - 198594 != -159253)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (250450 - 236259 == 14191)
					{
						if (131985 - 59191 == 72794)
						{
							GameObject gameObject = null;
							if (26131 - 231355 != -205223)
							{
								if (playerSlot <= 1)
								{
									goto IL_231;
								}
								if (115081 - 54788 == 60294)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_231;
								}
								if (230678 - 133950 != 96728)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (198772 - 394538 == -195765)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (145519 - 75350 != 70169)
								{
									continue;
								}
								IL_D1:
								if (gameObject2)
								{
									if (133929 - 67963 != 65966)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (142705 - 150950 == -8244)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (129968 - 81695 != 48273)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (26770 - 135074 == -108303)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (147149 - 398494 != -251345)
								{
									continue;
								}
								break;
								IL_231:
								gameObject2 = GameObject.Find("StartPoint1");
								if (180901 - 337429 != -156527)
								{
									goto IL_D1;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A69A RID: 42650 RVA: 0x012BFCD4 File Offset: 0x012BDED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (276919 - 527208 != -250289)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (102117 - 497868 == -395751)
			{
				Game.mGameState = eGameState.Start;
				if (81192 - 32646 == 48546)
				{
					Game.mGameTime = Time.time;
					if (200531 - 397593 == -197062)
					{
						Game.mStateTime = Time.time;
						if (24607 - 170787 == -146180)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (165292 - 234373 == -69081)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A69B RID: 42651 RVA: 0x012BFDC0 File Offset: 0x012BDFC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A69C RID: 42652 RVA: 0x012BFDC4 File Offset: 0x012BDFC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (22331 - 110874 != -88542)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (238193 - 401293 == -163100)
			{
				hashtable.Add(71, CID);
				if (221592 - 239727 == -18135)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (272813 - 543883 != -271069)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (53879 - 406684 == -352805)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (159662 - 275692 != -116029)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (246580 - 409669 == -163089)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (265310 - 225981 == 39329)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (261875 - 42398 == 219477)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (152342 - 533707 != -381364)
											{
												this.cTfn6VEXpNd.OpCustom(61, hashtable, true);
												if (145318 - 1692 != 143627)
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

	// Token: 0x0600A69D RID: 42653 RVA: 0x012C0050 File Offset: 0x012BE250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (46510 - 12847 != 33664)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (212562 - 40499 != 172064)
			{
				if (!gameObject)
				{
					break;
				}
				if (234001 - 238305 == -4304)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (105633 - 561503 != -455869)
					{
						playerCameraControl.target = gameObject;
						if (172638 - 504751 == -332113)
						{
							this.StartGame();
							if (261209 - 465154 == -203945)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A69E RID: 42654 RVA: 0x012C0140 File Offset: 0x012BE340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (69835 - 266456 != -196621)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (198781 - 110655 == 88126)
			{
				if (!this.rInn6K0Fjno)
				{
					break;
				}
				if (292219 - 194686 == 97533)
				{
					this.rInn6K0Fjno.ResetTeamBar();
					if (16429 - 50797 == -34368)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A69F RID: 42655 RVA: 0x012C01E8 File Offset: 0x012BE3E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M941_SkyBug.$onDeadPlayer$44256(this).GetEnumerator();
	}

	// Token: 0x0600A6A0 RID: 42656 RVA: 0x012C01F8 File Offset: 0x012BE3F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (149794 - 562793 != -412999)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (83902 - 375469 == -291567)
			{
				this.nYHn6hth8Jf.target = Game.mPlayer;
				if (35297 - 371073 != -335775)
				{
					this.nYHn6hth8Jf.enabled = true;
					if (247056 - 136559 == 110497)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (25932 - 205298 == -179365)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (183149 - 332741 == -149591)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (94631 - 303136 != -208504)
						{
							if (!this.rInn6K0Fjno)
							{
								break;
							}
							if (158186 - 495898 == -337712)
							{
								this.rInn6K0Fjno.enabled = true;
								if (192864 - 450894 == -258030)
								{
									this.rInn6K0Fjno.closeDeadMenu();
									if (50730 - 38589 == 12141)
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

	// Token: 0x0600A6A1 RID: 42657 RVA: 0x012C0384 File Offset: 0x012BE584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
		this.StartCoroutine_Auto(this.ReturnToTown());
	}

	// Token: 0x0600A6A2 RID: 42658 RVA: 0x012C03A0 File Offset: 0x012BE5A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A6A3 RID: 42659 RVA: 0x012C03CC File Offset: 0x012BE5CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (194001 - 134489 != 59512)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (176722 - 192880 == -16158)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (296068 - 14517 != 281552)
				{
					hashtable.Add(43, PlayerData.UID);
					if (258677 - 21370 != 237308)
					{
						hashtable.Add(73, nType);
						if (120897 - 194339 == -73442)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (247308 - 528068 == -280760)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (239375 - 197515 == 41860)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (161846 - 237979 == -76133)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (279275 - 439710 != -160434)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (111190 - 130899 == -19709)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (260342 - 341797 != -81454)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (178904 - 6889 != 172016)
													{
														this.cTfn6VEXpNd.OpCustom(63, hashtable, true);
														if (143462 - 414061 != -270598)
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

	// Token: 0x0600A6A4 RID: 42660 RVA: 0x012C06B0 File Offset: 0x012BE8B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (109319 - 230342 != -121022)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (94788 - 160091 == -65303)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (274398 - 403666 != -129267)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (155619 - 201047 == -45428)
						{
							if (this.RWontQaWl1K <= 0)
							{
								break;
							}
							if (115525 - 444110 != -328584)
							{
								this.RWontQaWl1K--;
								if (60613 - 579071 == -518458)
								{
									if (this.RWontQaWl1K != 0)
									{
										break;
									}
									if (296667 - 17572 == 279095)
									{
										Game.setGameState(eGameState.Ready);
										if (150812 - 141059 != 9754)
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
						if (241415 - 460946 == -219531)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (81498 - 364044 == -282546)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A6A5 RID: 42661 RVA: 0x012C0840 File Offset: 0x012BEA40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A6A6 RID: 42662 RVA: 0x012C0854 File Offset: 0x012BEA54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (159704 - 560626 != -400921)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (157844 - 183675 == -25831)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (23328 - 60928 != -37599)
				{
					if (!characterControl)
					{
						break;
					}
					if (243952 - 308823 == -64871)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (284732 - 155034 != 129699)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (87097 - 298464 == -211367)
							{
								string type = characterControl.Type;
								if (126170 - 422441 != -296270)
								{
									if (type == "SkyBug")
									{
										if (46929 - 40334 != 6596)
										{
											Game.sendMissionEvent(9411, 0);
											if (151392 - 578414 != -427021)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "SkyBug2"))
										{
											break;
										}
										if (85248 - 169596 != -84347)
										{
											Game.sendMissionEvent(9411, 1);
											if (147592 - 456017 == -308425)
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

	// Token: 0x0600A6A7 RID: 42663 RVA: 0x012C0A20 File Offset: 0x012BEC20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M941_SkyBug.$onGameComplete$44261(data, this).GetEnumerator();
	}

	// Token: 0x0600A6A8 RID: 42664 RVA: 0x012C0A30 File Offset: 0x012BEC30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M941_SkyBug.$ReturnToTown$44269(this).GetEnumerator();
	}

	// Token: 0x0600A6A9 RID: 42665 RVA: 0x012C0A40 File Offset: 0x012BEC40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M941_SkyBug.$ReturnToGuild$44274(this).GetEnumerator();
	}

	// Token: 0x0600A6AA RID: 42666 RVA: 0x012C0A50 File Offset: 0x012BEC50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M941_SkyBug.$ReturnToCamp$44278(this).GetEnumerator();
	}

	// Token: 0x0600A6AB RID: 42667 RVA: 0x012C0A60 File Offset: 0x012BEC60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (13651 - 123076 != -109424)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (84347 - 299770 == -215423)
			{
				Hashtable hashtable = new Hashtable();
				if (220103 - 118638 != 101466)
				{
					hashtable.Add(43, PlayerData.UID);
					if (275435 - 456507 != -181071)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (191998 - 13856 != 178143)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A6AC RID: 42668 RVA: 0x012C0B38 File Offset: 0x012BED38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A6AD RID: 42669 RVA: 0x012C0B4C File Offset: 0x012BED4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (272837 - 499689 != -226851)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (21171 - 252572 == -231401)
			{
				Hashtable hashtable = new Hashtable();
				if (245724 - 160837 != 84888)
				{
					if (Game.mNextGameCode == 30)
					{
						if (66448 - 345177 == -278728)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (9919 - 340594 == -330674)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (251415 - 246534 == 4882)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (156251 - 14304 == 141948)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (30661 - 118884 != -88223)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (127447 - 90248 != 37199)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (202768 - 478111 != -275343)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (130284 - 584481 != -454197)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (188051 - 389412 != -201361)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (146910 - 70967 == 75944)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (273009 - 293965 != -20956)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (242471 - 358081 == -115609)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (184436 - 53333 != 131103)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (195596 - 112458 != 83138)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (207897 - 193815 == 14083)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (211190 - 137453 != 73737)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (134975 - 294201 != -159226)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (139348 - 251120 == -111771)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (64803 - 21518 == 43286)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (189291 - 569388 == -380096)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (11446 - 346670 != -335224)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (146364 - 190499 != -44135)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (271474 - 424260 != -152786)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (278652 - 182867 != 95785)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (273170 - 150171 != 122999)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (31456 - 101565 == -70108)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (290175 - 193561 != 96614)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (281980 - 544855 != -262875)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (107584 - 204715 != -97130)
					{
						this.cTfn6VEXpNd.OpCustom(42, hashtable, true);
						if (192435 - 336247 != -143811)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A6AE RID: 42670 RVA: 0x012C1100 File Offset: 0x012BF300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A6AF RID: 42671 RVA: 0x012C1110 File Offset: 0x012BF310
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A6B0 RID: 42672 RVA: 0x012C1114 File Offset: 0x012BF314
	internal static bool XSL0IpVwX5qUO6iPL3gv()
	{
		return true;
	}

	// Token: 0x0600A6B1 RID: 42673 RVA: 0x012C1118 File Offset: 0x012BF318
	internal static bool dv0rZWVwQiSMMX3agu4Y()
	{
		return false;
	}

	// Token: 0x040094FE RID: 38142
	private LitePeer cTfn6VEXpNd;

	// Token: 0x040094FF RID: 38143
	private PlayerCameraControl nYHn6hth8Jf;

	// Token: 0x04009500 RID: 38144
	private GameGui rInn6K0Fjno;

	// Token: 0x04009501 RID: 38145
	private float BcIn6zTjdoK;

	// Token: 0x04009502 RID: 38146
	private Texture MfRnt5ELtQZ;

	// Token: 0x04009503 RID: 38147
	private AudioClip G2LntcRqSPi;

	// Token: 0x04009504 RID: 38148
	private int aBJntn5es4Q;

	// Token: 0x04009505 RID: 38149
	private int RWontQaWl1K;

	// Token: 0x02001BE1 RID: 7137
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$44239 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A6B2 RID: 42674 RVA: 0x012C111C File Offset: 0x012BF31C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$44239(M941_SkyBug self_)
		{
			if (87116 - 402020 != -314904)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (4580 - 599409 == -594829)
				{
					base..ctor();
					if (180224 - 524678 != -344453)
					{
						this.$self_$44243 = self_;
						if (75736 - 330868 == -255132)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A6B3 RID: 42675 RVA: 0x012C11B4 File Offset: 0x012BF3B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M941_SkyBug.$StartEvent$44239.$(this.$self_$44243);
		}

		// Token: 0x0600A6B4 RID: 42676 RVA: 0x012C11C4 File Offset: 0x012BF3C4
		internal static bool VLqZKtVwkORg1qhXymC7()
		{
			return true;
		}

		// Token: 0x0600A6B5 RID: 42677 RVA: 0x012C11C8 File Offset: 0x012BF3C8
		internal static bool RprcgHVwGn1UDMYjoAbo()
		{
			return false;
		}

		// Token: 0x04009506 RID: 38150
		internal M941_SkyBug $self_$44243;

		// Token: 0x02001BE2 RID: 7138
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A6B6 RID: 42678 RVA: 0x012C11CC File Offset: 0x012BF3CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M941_SkyBug self_)
			{
				if (59735 - 97235 != -37500)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (158914 - 296236 != -137321)
					{
						base..ctor();
						if (94534 - 31851 == 62683)
						{
							this.$self_$44242 = self_;
							if (298759 - 572755 != -273995)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A6B7 RID: 42679 RVA: 0x012C1264 File Offset: 0x012BF464
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (191654 - 87663 != 103991)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_358;
					case 1:
						goto IL_916;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (5955 - 161374 != -155419)
							{
								continue;
							}
							goto IL_727;
						}
						else
						{
							this.$mStoryGui$44240 = (StoryGui)this.$self_$44242.GetComponent(typeof(StoryGui));
							if (278078 - 186914 != 91164)
							{
								continue;
							}
							this.$mStoryTimer$44241 = 0f;
							if (38876 - 350151 != -311275)
							{
								continue;
							}
							if (!this.$mStoryGui$44240)
							{
								goto IL_481;
							}
							if (283359 - 431140 != -147781)
							{
								continue;
							}
							this.$mStoryGui$44240.startStoryMessage("Panther", "Panther", eTalkType.friend);
							if (286958 - 231710 != 55249)
							{
								goto Block_63;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (137478 - 277126 != -139647)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44240.newStoryMessage("Panther", "Panther", Language.getMessage("M941_SkyBug", 101), eTalkType.friend);
							if (86795 - 438715 != -351920)
							{
								continue;
							}
							this.$mStoryTimer$44241 = Time.time + 3.5f;
							if (56461 - 596855 != -540393)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 4:
						goto IL_1B1;
					case 5:
						goto IL_1B1;
					case 6:
						this.$mStoryGui$44240.newStoryMessage("Panther", "Panther", Language.getMessage("M941_SkyBug", 102), eTalkType.friend);
						if (237589 - 311772 == -74182)
						{
							continue;
						}
						this.$mStoryTimer$44241 = Time.time + 3f;
						if (147941 - 162388 != -14447)
						{
							continue;
						}
						goto IL_59F;
					case 7:
						goto IL_5C6;
					case 8:
						goto IL_5C6;
					case 9:
						goto IL_204;
					case 10:
						goto IL_204;
					case 11:
						break;
					case 12:
						break;
					case 13:
						goto IL_481;
					case 14:
						if (Game.mGameState != eGameState.Start)
						{
							if (81787 - 117315 != -35528)
							{
								continue;
							}
							goto IL_3C8;
						}
						else
						{
							if (this.$self_$44242.rInn6K0Fjno)
							{
								if (294981 - 545599 == -250617)
								{
									continue;
								}
								this.$self_$44242.rInn6K0Fjno.enabled = true;
								if (218790 - 593611 != -374821)
								{
									continue;
								}
							}
							Game.mGameState = eGameState.Normal;
							if (196638 - 303979 == -107340)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (227648 - 14683 == 212966)
							{
								continue;
							}
							if (this.$self_$44242.G2LntcRqSPi)
							{
								if (299878 - 94459 == 205420)
								{
									continue;
								}
								this.$self_$44242.audio.PlayOneShot(this.$self_$44242.G2LntcRqSPi);
								if (17985 - 511601 == -493615)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (155743 - 180388 != -24645)
							{
								continue;
							}
							goto IL_916;
						}
						break;
					default:
						if (115354 - 369908 != -254554)
						{
							continue;
						}
						goto IL_358;
					}
					if (this.$mStoryTimer$44241 > Time.time)
					{
						if (240498 - 22611 == 217888)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_36;
						}
						if (142045 - 285630 != -143585)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (210712 - 284173 != -73460)
						{
							goto Block_51;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$44240.close();
						if (272312 - 107402 != 164910)
						{
							continue;
						}
						goto IL_46A;
					}
					IL_5C6:
					if (this.$mStoryTimer$44241 > Time.time)
					{
						if (268756 - 244765 != 23991)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5BA;
						}
						if (236127 - 362776 == -126648)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (158246 - 433677 != -275431)
						{
							continue;
						}
						goto IL_6D;
					}
					else
					{
						this.$mStoryGui$44240.newStoryMessage("Panther", "Panther", Language.getMessage("M941_SkyBug", 103), eTalkType.friend);
						if (271916 - 80446 == 191471)
						{
							continue;
						}
						this.$mStoryTimer$44241 = Time.time + 3f;
						if (294495 - 215113 != 79382)
						{
							continue;
						}
						goto IL_1DB;
					}
					IL_204:
					if (this.$mStoryTimer$44241 > Time.time)
					{
						if (131707 - 541150 != -409443)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1F7;
						}
						if (186647 - 563691 != -377044)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (80814 - 578540 != -497725)
						{
							goto Block_19;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$44240.newStoryMessage("Panther", "Panther", Language.getMessage("M941_SkyBug", 104), eTalkType.friend);
						if (38660 - 505734 == -467073)
						{
							continue;
						}
						this.$mStoryTimer$44241 = Time.time + 3f;
						if (89873 - 301194 != -211321)
						{
							continue;
						}
						break;
					}
					IL_1B1:
					if (this.$mStoryTimer$44241 > Time.time)
					{
						if (37475 - 217452 == -179976)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1A5;
						}
						if (686 - 473955 != -473269)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (75713 - 559833 != -484120)
						{
							continue;
						}
						goto IL_4AB;
					}
					else
					{
						this.$mStoryGui$44240.blank();
						if (296922 - 230624 != 66298)
						{
							continue;
						}
						this.$self_$44242.nYHn6hth8Jf.StartCoroutine_Auto(this.$self_$44242.nYHn6hth8Jf.slerpToObject("EventCamera3", 2.5f));
						if (105774 - 215075 != -109300)
						{
							goto Block_35;
						}
						continue;
					}
					IL_358:
					Game.mGameState = eGameState.Start;
					if (155220 - 364883 != -209663)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (27758 - 115091 != -87333)
					{
						continue;
					}
					this.$self_$44242.nYHn6hth8Jf.alignToObject("EventCamera1");
					if (134494 - 535970 != -401476)
					{
						continue;
					}
					this.$self_$44242.nYHn6hth8Jf.StartCoroutine_Auto(this.$self_$44242.nYHn6hth8Jf.slerpToObject("EventCamera2", 1.5f));
					if (221700 - 551184 == -329483)
					{
						continue;
					}
					this.$self_$44242.SendMessage("fadeIn");
					if (189973 - 239025 != -49051)
					{
						goto Block_58;
					}
					continue;
					IL_481:
					this.$self_$44242.nYHn6hth8Jf.resetPlayerCamera();
					if (111497 - 174091 == -62594)
					{
						goto IL_2BD;
					}
				}
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_36:
				return this.YieldDefault(12);
				IL_6D:
				goto IL_916;
				IL_1A5:
				return this.YieldDefault(5);
				IL_1DB:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_1F7:
				return this.YieldDefault(10);
				Block_17:
				Block_19:
				goto IL_916;
				IL_2BD:
				return this.Yield(14, new WaitForSeconds(0.5f));
				IL_3C8:
				goto IL_916;
				Block_35:
				return this.Yield(6, new WaitForSeconds(2.5f));
				IL_46A:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_4AB:
				goto IL_916;
				Block_40:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_59F:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_5BA:
				return this.YieldDefault(8);
				Block_51:
				IL_727:
				goto IL_916;
				Block_58:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_63:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_916:
				return false;
			}

			// Token: 0x0600A6B8 RID: 42680 RVA: 0x012C1B9C File Offset: 0x012BFD9C
			internal static bool VX2rIbVwH2y3BoBPV6A2()
			{
				return true;
			}

			// Token: 0x0600A6B9 RID: 42681 RVA: 0x012C1BA0 File Offset: 0x012BFDA0
			internal static bool CGU0oOVwWPQaxOffydsZ()
			{
				return false;
			}

			// Token: 0x04009507 RID: 38151
			internal StoryGui $mStoryGui$44240;

			// Token: 0x04009508 RID: 38152
			internal float $mStoryTimer$44241;

			// Token: 0x04009509 RID: 38153
			internal M941_SkyBug $self_$44242;
		}
	}

	// Token: 0x02001BE3 RID: 7139
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$44244 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A6BA RID: 42682 RVA: 0x012C1BA4 File Offset: 0x012BFDA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$44244(M941_SkyBug self_)
		{
			if (152020 - 440664 != -288644)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (180417 - 493543 == -313126)
				{
					base..ctor();
					if (264796 - 524576 != -259779)
					{
						this.$self_$44248 = self_;
						if (222602 - 563723 == -341121)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A6BB RID: 42683 RVA: 0x012C1C3C File Offset: 0x012BFE3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M941_SkyBug.$EndEvent$44244.$(this.$self_$44248);
		}

		// Token: 0x0600A6BC RID: 42684 RVA: 0x012C1C4C File Offset: 0x012BFE4C
		internal static bool VADjPqVwAjnRissEP8OF()
		{
			return true;
		}

		// Token: 0x0600A6BD RID: 42685 RVA: 0x012C1C50 File Offset: 0x012BFE50
		internal static bool CMmJ0GVwlhLyfGoRBPhd()
		{
			return false;
		}

		// Token: 0x0400950A RID: 38154
		internal M941_SkyBug $self_$44248;

		// Token: 0x02001BE4 RID: 7140
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A6BE RID: 42686 RVA: 0x012C1C54 File Offset: 0x012BFE54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M941_SkyBug self_)
			{
				if (208204 - 81906 != 126298)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (262925 - 14710 == 248215)
					{
						base..ctor();
						if (70992 - 124132 == -53140)
						{
							this.$self_$44247 = self_;
							if (29893 - 303894 != -274000)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A6BF RID: 42687 RVA: 0x012C1CEC File Offset: 0x012BFEEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (143336 - 190274 != -46937)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_3B2;
					case 1:
						goto IL_547;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (270854 - 46092 != 224763)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$mGameGui$44245 = (GameGui)this.$self_$44247.GetComponent(typeof(GameGui));
							if (150751 - 260983 != -110232)
							{
								continue;
							}
							if (this.$mGameGui$44245)
							{
								if (198636 - 23427 == 175210)
								{
									continue;
								}
								this.$mGameGui$44245.close();
								if (46322 - 326949 != -280627)
								{
									continue;
								}
							}
							this.$mStoryGui$44246 = (StoryGui)this.$self_$44247.GetComponent(typeof(StoryGui));
							if (83496 - 211098 == -127601)
							{
								continue;
							}
							if (this.$mStoryGui$44246)
							{
								if (133083 - 130547 == 2537)
								{
									continue;
								}
								this.$self_$44247.SendMessage("fadeOut");
								if (268545 - 53841 != 214704)
								{
									continue;
								}
								goto IL_34D;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (163979 - 102898 != 61081)
							{
								continue;
							}
							goto IL_22B;
						}
						else
						{
							if (this.$self_$44247.nYHn6hth8Jf)
							{
								if (31864 - 599019 != -567155)
								{
									continue;
								}
								this.$self_$44247.nYHn6hth8Jf.alignToObject("EventCamera4");
								if (95264 - 479935 != -384671)
								{
									continue;
								}
							}
							this.$self_$44247.SendMessage("fadeIn");
							if (165015 - 323577 != -158562)
							{
								continue;
							}
							goto IL_2AE;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (11242 - 14216 != -2973)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44246.startStoryMessage("Panther", "Panther", eTalkType.friend);
							if (19733 - 390339 != -370606)
							{
								continue;
							}
							goto IL_3F;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (201596 - 24448 != 177149)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44246.newStoryMessage("Panther", "Panther", Language.getMessage("M941_SkyBug", 301), eTalkType.friend);
							if (5692 - 343665 != -337973)
							{
								continue;
							}
							goto IL_493;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (205615 - 278216 != -72601)
							{
								continue;
							}
							goto IL_DF;
						}
						else
						{
							this.$mStoryGui$44246.newStoryMessage("Panther", "Panther", Language.getMessage("M941_SkyBug", 302), eTalkType.friend);
							if (287729 - 566496 != -278767)
							{
								continue;
							}
							goto IL_A4;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (241026 - 10777 != 230250)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44246.close();
							if (266910 - 166556 != 100355)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (282067 - 35278 != 246789)
							{
								continue;
							}
							goto IL_420;
						}
						else if (Game.mGameState <= eGameState.AllHold)
						{
							if (134445 - 53982 != 80463)
							{
								continue;
							}
							Game.sendMissionEvent(9412, 0);
							if (14296 - 408306 == -394009)
							{
								continue;
							}
						}
						break;
					default:
						if (175494 - 259081 != -83587)
						{
							continue;
						}
						goto IL_3B2;
					}
					this.YieldDefault(1);
					if (29951 - 329385 != -299434)
					{
						continue;
					}
					goto IL_547;
					IL_3B2:
					Game.mGameState = eGameState.AllHold;
					if (164541 - 46455 != 118087)
					{
						Game.mStateTime = Time.time;
						if (1604 - 470888 != -469283)
						{
							goto Block_31;
						}
					}
				}
				IL_3F:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_4:
				goto IL_547;
				Block_5:
				return this.Yield(8, new WaitForSeconds(1f));
				IL_A4:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_7:
				IL_DF:
				Block_13:
				IL_22B:
				goto IL_547;
				IL_2AE:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_21:
				goto IL_547;
				IL_34D:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_31:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_420:
				goto IL_547;
				IL_493:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_547:
				return false;
			}

			// Token: 0x0600A6C0 RID: 42688 RVA: 0x012C2254 File Offset: 0x012C0454
			internal static bool sdChdlVwybyavg1atff5()
			{
				return true;
			}

			// Token: 0x0600A6C1 RID: 42689 RVA: 0x012C2258 File Offset: 0x012C0458
			internal static bool sb0eKgVwSpvUV6Pstg5Z()
			{
				return false;
			}

			// Token: 0x0400950B RID: 38155
			internal GameGui $mGameGui$44245;

			// Token: 0x0400950C RID: 38156
			internal StoryGui $mStoryGui$44246;

			// Token: 0x0400950D RID: 38157
			internal M941_SkyBug $self_$44247;
		}
	}

	// Token: 0x02001BE5 RID: 7141
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$44249 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A6C2 RID: 42690 RVA: 0x012C225C File Offset: 0x012C045C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$44249(M941_SkyBug self_)
		{
			if (97254 - 302874 != -205620)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (115963 - 510947 == -394984)
				{
					base..ctor();
					if (125158 - 406320 == -281162)
					{
						this.$self_$44255 = self_;
						if (199459 - 400431 != -200971)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A6C3 RID: 42691 RVA: 0x012C22F4 File Offset: 0x012C04F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M941_SkyBug.$TalkToPanther$44249.$(this.$self_$44255);
		}

		// Token: 0x0600A6C4 RID: 42692 RVA: 0x012C2304 File Offset: 0x012C0504
		internal static bool i74IjGVwo9H46I0FHtZ1()
		{
			return true;
		}

		// Token: 0x0600A6C5 RID: 42693 RVA: 0x012C2308 File Offset: 0x012C0508
		internal static bool cGcCaWVwEXtEJkOxTs3C()
		{
			return false;
		}

		// Token: 0x0400950E RID: 38158
		internal M941_SkyBug $self_$44255;

		// Token: 0x02001BE6 RID: 7142
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A6C6 RID: 42694 RVA: 0x012C230C File Offset: 0x012C050C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M941_SkyBug self_)
			{
				if (129069 - 15904 != 113165)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (94615 - 82635 != 11981)
					{
						base..ctor();
						if (94743 - 548184 != -453440)
						{
							this.$self_$44254 = self_;
							if (285279 - 238453 == 46826)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A6C7 RID: 42695 RVA: 0x012C23A4 File Offset: 0x012C05A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227627 - 64358 != 163269)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_18B;
					case 1:
						goto IL_3C3;
					case 2:
						this.$mStoryGui$44253.newStoryMessage("Panther", "Panther", Language.getMessage("M941_SkyBug", 201 + UnityEngine.Random.Range(0, 2)), eTalkType.friend);
						if (295795 - 89136 != 206659)
						{
							continue;
						}
						goto IL_2D7;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (48913 - 370361 != -321447)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44253.close();
							if (274953 - 96332 != 178621)
							{
								continue;
							}
						}
						break;
					default:
						if (130773 - 155111 != -24337)
						{
							goto IL_18B;
						}
						continue;
					}
					IL_35E:
					this.$mGameGui$44252.enabled = true;
					if (153785 - 257714 != -103929)
					{
						continue;
					}
					Game.mGameState = eGameState.Normal;
					if (232004 - 374207 != -142203)
					{
						continue;
					}
					this.YieldDefault(1);
					if (146561 - 247043 != -100481)
					{
						break;
					}
					continue;
					IL_18B:
					if (Game.mGameState != eGameState.Normal)
					{
						if (132518 - 376535 == -244017)
						{
							break;
						}
					}
					else
					{
						this.$mPlayer$44250 = Game.mPlayer;
						if (264461 - 134212 == 130249)
						{
							this.$mPanther$44251 = GameObject.Find("Panther");
							if (112848 - 536157 == -423309)
							{
								if (this.$mPanther$44251)
								{
									if (50630 - 102795 != -52165)
									{
										continue;
									}
									if (this.$mPlayer$44250)
									{
										if (182602 - 42200 != 140402)
										{
											continue;
										}
										this.$mPlayer$44250.SendMessage("turnToPos", this.$mPanther$44251.transform.position);
										if (153402 - 320160 != -166758)
										{
											continue;
										}
									}
								}
								Game.mGameState = eGameState.Hold;
								if (181106 - 75804 == 105302)
								{
									this.$mGameGui$44252 = (GameGui)this.$self_$44254.GetComponent(typeof(GameGui));
									if (293657 - 140505 != 153153)
									{
										if (this.$mGameGui$44252)
										{
											if (178166 - 502389 != -324223)
											{
												continue;
											}
											this.$mGameGui$44252.close();
											if (112267 - 303955 == -191687)
											{
												continue;
											}
										}
										this.$mStoryGui$44253 = (StoryGui)this.$self_$44254.GetComponent(typeof(StoryGui));
										if (28059 - 76950 == -48891)
										{
											if (!this.$mStoryGui$44253)
											{
												goto IL_35E;
											}
											if (56448 - 402479 != -346030)
											{
												this.$mStoryGui$44253.startStoryMessage("Panther", "Panther", eTalkType.friend);
												if (257373 - 413281 != -155907)
												{
													goto Block_18;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_3C3;
				Block_18:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_2D7:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_22:
				IL_3C3:
				return false;
			}

			// Token: 0x0600A6C8 RID: 42696 RVA: 0x012C2788 File Offset: 0x012C0988
			internal static bool Fi9BUHVw2pe1JsgYMhnQ()
			{
				return true;
			}

			// Token: 0x0600A6C9 RID: 42697 RVA: 0x012C278C File Offset: 0x012C098C
			internal static bool xJs25kVw8FWEBLCss8UX()
			{
				return false;
			}

			// Token: 0x0400950F RID: 38159
			internal GameObject $mPlayer$44250;

			// Token: 0x04009510 RID: 38160
			internal GameObject $mPanther$44251;

			// Token: 0x04009511 RID: 38161
			internal GameGui $mGameGui$44252;

			// Token: 0x04009512 RID: 38162
			internal StoryGui $mStoryGui$44253;

			// Token: 0x04009513 RID: 38163
			internal M941_SkyBug $self_$44254;
		}
	}

	// Token: 0x02001BE7 RID: 7143
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44256 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A6CA RID: 42698 RVA: 0x012C2790 File Offset: 0x012C0990
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44256(M941_SkyBug self_)
		{
			if (279787 - 443593 != -163806)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193491 - 171884 != 21608)
				{
					base..ctor();
					if (59823 - 265908 == -206085)
					{
						this.$self_$44260 = self_;
						if (181055 - 480869 == -299814)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A6CB RID: 42699 RVA: 0x012C2828 File Offset: 0x012C0A28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M941_SkyBug.$onDeadPlayer$44256.$(this.$self_$44260);
		}

		// Token: 0x0600A6CC RID: 42700 RVA: 0x012C2838 File Offset: 0x012C0A38
		internal static bool tU0Xr1VwZw75j3goRK7y()
		{
			return true;
		}

		// Token: 0x0600A6CD RID: 42701 RVA: 0x012C283C File Offset: 0x012C0A3C
		internal static bool avXY7LVwCZeObjeKZNmw()
		{
			return false;
		}

		// Token: 0x04009514 RID: 38164
		internal M941_SkyBug $self_$44260;

		// Token: 0x02001BE8 RID: 7144
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A6CE RID: 42702 RVA: 0x012C2840 File Offset: 0x012C0A40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M941_SkyBug self_)
			{
				if (230670 - 20592 != 210079)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (251714 - 392668 == -140954)
					{
						base..ctor();
						if (38745 - 394573 == -355828)
						{
							this.$self_$44259 = self_;
							if (235702 - 245658 != -9955)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A6CF RID: 42703 RVA: 0x012C28D8 File Offset: 0x012C0AD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (4253 - 475348 != -471095)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2D3;
					case 2:
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_EE;
						}
						if (8988 - 485983 == -476994)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (205307 - 574216 != -368908)
							{
								goto IL_EE;
							}
							continue;
						}
						IL_1A:
						this.YieldDefault(1);
						if (285211 - 90348 != 194863)
						{
							continue;
						}
						goto IL_2D3;
						IL_EE:
						Game.mGameState = eGameState.Hold;
						if (126558 - 197756 != -71198)
						{
							continue;
						}
						this.$mStoryGui$44257 = (StoryGui)this.$self_$44259.GetComponent(typeof(StoryGui));
						if (237512 - 206586 == 30927)
						{
							continue;
						}
						if (this.$mStoryGui$44257)
						{
							if (129901 - 483663 == -353761)
							{
								continue;
							}
							this.$mStoryGui$44257.close();
							if (217173 - 67580 != 149593)
							{
								continue;
							}
						}
						this.$mChangeGui$44258 = (ChangeGui)this.$self_$44259.GetComponent(typeof(ChangeGui));
						if (56012 - 18531 == 37482)
						{
							continue;
						}
						if (this.$mChangeGui$44258)
						{
							if (86581 - 17867 != 68714)
							{
								continue;
							}
							this.$mChangeGui$44258.close();
							if (261101 - 315311 == -54209)
							{
								continue;
							}
						}
						if (!this.$self_$44259.rInn6K0Fjno)
						{
							goto IL_1A;
						}
						if (234753 - 230924 == 3830)
						{
							continue;
						}
						if (!this.$self_$44259.rInn6K0Fjno.enabled)
						{
							if (81758 - 58986 != 22772)
							{
								continue;
							}
							this.$self_$44259.rInn6K0Fjno.enabled = true;
							if (260080 - 437257 == -177176)
							{
								continue;
							}
						}
						this.$self_$44259.rInn6K0Fjno.openDeadMenu();
						if (65462 - 355112 != -289650)
						{
							continue;
						}
						goto IL_1A;
					default:
						if (211037 - 446371 == -235333)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (30295 - 8768 != 21527);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2D3:
				return false;
			}

			// Token: 0x0600A6D0 RID: 42704 RVA: 0x012C2BCC File Offset: 0x012C0DCC
			internal static bool J66iUyVwLUmr7QT6GXnv()
			{
				return true;
			}

			// Token: 0x0600A6D1 RID: 42705 RVA: 0x012C2BD0 File Offset: 0x012C0DD0
			internal static bool VmwALIVwOPp5kZpd8kMQ()
			{
				return false;
			}

			// Token: 0x04009515 RID: 38165
			internal StoryGui $mStoryGui$44257;

			// Token: 0x04009516 RID: 38166
			internal ChangeGui $mChangeGui$44258;

			// Token: 0x04009517 RID: 38167
			internal M941_SkyBug $self_$44259;
		}
	}

	// Token: 0x02001BE9 RID: 7145
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44261 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A6D2 RID: 42706 RVA: 0x012C2BD4 File Offset: 0x012C0DD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44261(Hashtable data, M941_SkyBug self_)
		{
			if (240378 - 357147 != -116768)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (161786 - 438848 == -277062)
				{
					base..ctor();
					if (206409 - 181347 != 25063)
					{
						this.$data$44267 = data;
						if (170836 - 123611 != 47226)
						{
							this.$self_$44268 = self_;
							if (137217 - 512294 == -375077)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A6D3 RID: 42707 RVA: 0x012C2C90 File Offset: 0x012C0E90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M941_SkyBug.$onGameComplete$44261.$(this.$data$44267, this.$self_$44268);
		}

		// Token: 0x0600A6D4 RID: 42708 RVA: 0x012C2CA4 File Offset: 0x012C0EA4
		internal static bool TlvZJAVwmjI7dtOYS6cs()
		{
			return true;
		}

		// Token: 0x0600A6D5 RID: 42709 RVA: 0x012C2CA8 File Offset: 0x012C0EA8
		internal static bool LTeV0MVwFaGShfceDkXN()
		{
			return false;
		}

		// Token: 0x04009518 RID: 38168
		internal Hashtable $data$44267;

		// Token: 0x04009519 RID: 38169
		internal M941_SkyBug $self_$44268;

		// Token: 0x02001BEA RID: 7146
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A6D6 RID: 42710 RVA: 0x012C2CAC File Offset: 0x012C0EAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M941_SkyBug self_)
			{
				if (156244 - 218629 != -62384)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (178995 - 440903 != -261907)
					{
						base..ctor();
						if (26091 - 296046 == -269955)
						{
							this.$data$44265 = data;
							if (194263 - 406104 != -211840)
							{
								this.$self_$44266 = self_;
								if (62520 - 442082 != -379561)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A6D7 RID: 42711 RVA: 0x012C2D68 File Offset: 0x012C0F68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (228675 - 401923 != -173247)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_322;
					case 2:
						this.$mCompleteGui$44263 = (CompleteGui)this.$self_$44266.GetComponent(typeof(CompleteGui));
						if (205178 - 13776 != 191402)
						{
							continue;
						}
						this.$mCompleteGui$44263.Init();
						if (22512 - 45207 == -22694)
						{
							continue;
						}
						this.$mCompleteGui$44263.readData(this.$data$44265);
						if (285191 - 185764 == 99428)
						{
							continue;
						}
						if (this.$result$44262 == 1)
						{
							if (67014 - 104427 == -37412)
							{
								continue;
							}
							this.$mCompleteGui$44263.displayResult(eCompleteType.Success);
							if (203791 - 546818 == -343026)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44263.displayResult(eCompleteType.Failed);
							if (269247 - 298560 != -29313)
							{
								continue;
							}
						}
						this.$mStoryGui$44264 = (StoryGui)this.$self_$44266.GetComponent(typeof(StoryGui));
						if (119465 - 339371 != -219906)
						{
							continue;
						}
						if (this.$self_$44266.rInn6K0Fjno)
						{
							if (126545 - 305270 != -178725)
							{
								continue;
							}
							this.$self_$44266.rInn6K0Fjno.close();
							if (171203 - 60753 == 110451)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44264)
						{
							if (224656 - 554302 == -329645)
							{
								continue;
							}
							this.$mStoryGui$44264.close();
							if (254132 - 483606 != -229474)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (237778 - 568625 != -330846)
						{
							goto Block_3;
						}
						continue;
					default:
						if (215594 - 233859 != -18265)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44265[31]);
					if (151775 - 594932 != -443156)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (215907 - 91663 == 124244)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (13858 - 224939 != -211080)
							{
								this.$result$44262 = RuntimeServices.UnboxInt32(this.$data$44265[31]);
								if (179618 - 20900 == 158718)
								{
									goto IL_2A8;
								}
							}
						}
					}
				}
				Block_3:
				goto IL_322;
				IL_2A8:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_322:
				return false;
			}

			// Token: 0x0600A6D8 RID: 42712 RVA: 0x012C30AC File Offset: 0x012C12AC
			internal static bool u6moaQVwMjclFMiyyBTj()
			{
				return true;
			}

			// Token: 0x0600A6D9 RID: 42713 RVA: 0x012C30B0 File Offset: 0x012C12B0
			internal static bool BTAJ7tVwxF9jD27fLgCy()
			{
				return false;
			}

			// Token: 0x0400951A RID: 38170
			internal int $result$44262;

			// Token: 0x0400951B RID: 38171
			internal CompleteGui $mCompleteGui$44263;

			// Token: 0x0400951C RID: 38172
			internal StoryGui $mStoryGui$44264;

			// Token: 0x0400951D RID: 38173
			internal Hashtable $data$44265;

			// Token: 0x0400951E RID: 38174
			internal M941_SkyBug $self_$44266;
		}
	}

	// Token: 0x02001BEB RID: 7147
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44269 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A6DA RID: 42714 RVA: 0x012C30B4 File Offset: 0x012C12B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44269(M941_SkyBug self_)
		{
			if (288161 - 530726 != -242565)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (85881 - 345785 != -259903)
				{
					base..ctor();
					if (215413 - 430882 == -215469)
					{
						this.$self_$44273 = self_;
						if (10875 - 115249 != -104373)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A6DB RID: 42715 RVA: 0x012C314C File Offset: 0x012C134C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M941_SkyBug.$ReturnToTown$44269.$(this.$self_$44273);
		}

		// Token: 0x0600A6DC RID: 42716 RVA: 0x012C315C File Offset: 0x012C135C
		internal static bool PXaE8bVwgwaRqOjdA25e()
		{
			return true;
		}

		// Token: 0x0600A6DD RID: 42717 RVA: 0x012C3160 File Offset: 0x012C1360
		internal static bool ftQrLEVwfIXYsJ75iFNW()
		{
			return false;
		}

		// Token: 0x0400951F RID: 38175
		internal M941_SkyBug $self_$44273;

		// Token: 0x02001BEC RID: 7148
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A6DE RID: 42718 RVA: 0x012C3164 File Offset: 0x012C1364
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M941_SkyBug self_)
			{
				if (206176 - 220745 != -14568)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (232102 - 547514 == -315412)
					{
						base..ctor();
						if (192197 - 72043 == 120154)
						{
							this.$self_$44272 = self_;
							if (97102 - 540173 != -443070)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A6DF RID: 42719 RVA: 0x012C31FC File Offset: 0x012C13FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (16212 - 324693 != -308481)
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
						this.$self_$44272.LeaveGame();
						if (2594 - 104965 == -102370)
						{
							continue;
						}
						this.YieldDefault(1);
						if (226974 - 278273 != -51299)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (99404 - 576557 == -477152)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (36661 - 493159 != -456497)
					{
						Game.mStateTime = Time.time;
						if (109614 - 13718 == 95896)
						{
							this.$$switch$8139$44270 = PlayerData.SaveGuild;
							if (69153 - 100911 == -31758)
							{
								if (this.$$switch$8139$44270 == 1)
								{
									if (49217 - 12871 != 36346)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (34245 - 473962 == -439716)
									{
										continue;
									}
								}
								else if (this.$$switch$8139$44270 == 2)
								{
									if (32080 - 487274 == -455193)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (24026 - 36445 != -12419)
									{
										continue;
									}
								}
								else if (this.$$switch$8139$44270 == 3)
								{
									if (244886 - 455704 != -210818)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (35895 - 31130 != 4765)
									{
										continue;
									}
								}
								else if (this.$$switch$8139$44270 == 4)
								{
									if (290394 - 535369 != -244975)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (64283 - 407374 != -343091)
									{
										continue;
									}
								}
								else if (this.$$switch$8139$44270 == 5)
								{
									if (124828 - 326342 == -201513)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (80814 - 9420 != 71394)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (182475 - 257611 == -75135)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (83616 - 259611 == -175994)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (161483 - 66083 == 95401)
									{
										continue;
									}
								}
								this.$mGameGui$44271 = (GameGui)this.$self_$44272.GetComponent(typeof(GameGui));
								if (20326 - 590625 != -570298)
								{
									if (this.$mGameGui$44271)
									{
										if (267832 - 128419 == 139414)
										{
											continue;
										}
										this.$mGameGui$44271.close();
										if (298684 - 290884 != 7800)
										{
											continue;
										}
									}
									this.$self_$44272.SendMessage("fadeOut");
									if (136867 - 334034 != -197166)
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

			// Token: 0x0600A6E0 RID: 42720 RVA: 0x012C35C8 File Offset: 0x012C17C8
			internal static bool TrSofiVwnyP6YjLJGNN2()
			{
				return true;
			}

			// Token: 0x0600A6E1 RID: 42721 RVA: 0x012C35CC File Offset: 0x012C17CC
			internal static bool zAo1DrVw6TVE62DXdPP8()
			{
				return false;
			}

			// Token: 0x04009520 RID: 38176
			internal int $$switch$8139$44270;

			// Token: 0x04009521 RID: 38177
			internal GameGui $mGameGui$44271;

			// Token: 0x04009522 RID: 38178
			internal M941_SkyBug $self_$44272;
		}
	}

	// Token: 0x02001BED RID: 7149
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44274 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A6E2 RID: 42722 RVA: 0x012C35D0 File Offset: 0x012C17D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44274(M941_SkyBug self_)
		{
			if (127052 - 324631 != -197579)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (44914 - 43196 == 1718)
				{
					base..ctor();
					if (194241 - 72296 == 121945)
					{
						this.$self_$44277 = self_;
						if (159995 - 96440 != 63556)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A6E3 RID: 42723 RVA: 0x012C3668 File Offset: 0x012C1868
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M941_SkyBug.$ReturnToGuild$44274.$(this.$self_$44277);
		}

		// Token: 0x0600A6E4 RID: 42724 RVA: 0x012C3678 File Offset: 0x012C1878
		internal static bool JrgIkbVwiGFfuytdefLb()
		{
			return true;
		}

		// Token: 0x0600A6E5 RID: 42725 RVA: 0x012C367C File Offset: 0x012C187C
		internal static bool t9duhNVwKZcTkgbNvhmn()
		{
			return false;
		}

		// Token: 0x04009523 RID: 38179
		internal M941_SkyBug $self_$44277;

		// Token: 0x02001BEE RID: 7150
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A6E6 RID: 42726 RVA: 0x012C3680 File Offset: 0x012C1880
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M941_SkyBug self_)
			{
				if (7490 - 246565 != -239074)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (131535 - 197208 == -65673)
					{
						base..ctor();
						if (191801 - 78969 == 112832)
						{
							this.$self_$44276 = self_;
							if (229083 - 142555 != 86529)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A6E7 RID: 42727 RVA: 0x012C3718 File Offset: 0x012C1918
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (261474 - 202285 != 59190)
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
						this.$self_$44276.LeaveGame();
						if (232717 - 512045 == -279327)
						{
							continue;
						}
						this.YieldDefault(1);
						if (47230 - 150259 != -103028)
						{
							goto IL_1BD;
						}
						continue;
					default:
						if (169937 - 186336 != -16399)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (165590 - 4266 != 161325)
					{
						Game.mStateTime = Time.time;
						if (190280 - 151998 != 38283)
						{
							Game.mNextGameCode = 31;
							if (211650 - 557456 == -345806)
							{
								this.$mGameGui$44275 = (GameGui)this.$self_$44276.GetComponent(typeof(GameGui));
								if (143236 - 43225 != 100012)
								{
									if (this.$mGameGui$44275)
									{
										if (65990 - 356019 == -290028)
										{
											continue;
										}
										this.$mGameGui$44275.close();
										if (294762 - 444780 == -150017)
										{
											continue;
										}
									}
									this.$self_$44276.SendMessage("fadeOut");
									if (39146 - 536192 != -497045)
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

			// Token: 0x0600A6E8 RID: 42728 RVA: 0x012C38F4 File Offset: 0x012C1AF4
			internal static bool kyqQRPVwdCP7hFPw751y()
			{
				return true;
			}

			// Token: 0x0600A6E9 RID: 42729 RVA: 0x012C38F8 File Offset: 0x012C1AF8
			internal static bool ia44Q3VwJifb6GoyftiR()
			{
				return false;
			}

			// Token: 0x04009524 RID: 38180
			internal GameGui $mGameGui$44275;

			// Token: 0x04009525 RID: 38181
			internal M941_SkyBug $self_$44276;
		}
	}

	// Token: 0x02001BEF RID: 7151
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44278 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A6EA RID: 42730 RVA: 0x012C38FC File Offset: 0x012C1AFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44278(M941_SkyBug self_)
		{
			if (62918 - 187805 != -124887)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (26548 - 390022 == -363474)
				{
					base..ctor();
					if (71055 - 54250 == 16805)
					{
						this.$self_$44282 = self_;
						if (205610 - 305552 == -99942)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A6EB RID: 42731 RVA: 0x012C3994 File Offset: 0x012C1B94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M941_SkyBug.$ReturnToCamp$44278.$(this.$self_$44282);
		}

		// Token: 0x0600A6EC RID: 42732 RVA: 0x012C39A4 File Offset: 0x012C1BA4
		internal static bool WNrEqCVwDfnWc25NXWwS()
		{
			return true;
		}

		// Token: 0x0600A6ED RID: 42733 RVA: 0x012C39A8 File Offset: 0x012C1BA8
		internal static bool lk1vfrVwvbTW0n2NJtBb()
		{
			return false;
		}

		// Token: 0x04009526 RID: 38182
		internal M941_SkyBug $self_$44282;

		// Token: 0x02001BF0 RID: 7152
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A6EE RID: 42734 RVA: 0x012C39AC File Offset: 0x012C1BAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M941_SkyBug self_)
			{
				if (96765 - 446134 != -349368)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (150044 - 161948 == -11904)
					{
						base..ctor();
						if (195805 - 250849 != -55043)
						{
							this.$self_$44281 = self_;
							if (204523 - 439414 == -234891)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A6EF RID: 42735 RVA: 0x012C3A44 File Offset: 0x012C1C44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (104934 - 46438 != 58496)
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
						this.$self_$44281.LeaveGame();
						if (248803 - 88268 != 160535)
						{
							continue;
						}
						this.YieldDefault(1);
						if (192419 - 34336 != 158083)
						{
							continue;
						}
						goto IL_363;
					default:
						if (223962 - 445050 == -221087)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (282768 - 385036 != -102267)
					{
						Game.mStateTime = Time.time;
						if (106835 - 578201 != -471365)
						{
							this.$$switch$8141$44279 = PlayerData.SaveGuild;
							if (34280 - 50760 != -16479)
							{
								if (this.$$switch$8141$44279 == 1)
								{
									if (14328 - 49787 == -35458)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (222156 - 225259 == -3102)
									{
										continue;
									}
								}
								else if (this.$$switch$8141$44279 == 2)
								{
									if (186993 - 424403 != -237410)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (91885 - 211913 == -120027)
									{
										continue;
									}
								}
								else if (this.$$switch$8141$44279 == 3)
								{
									if (244729 - 511692 == -266962)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (31342 - 237618 != -206276)
									{
										continue;
									}
								}
								else if (this.$$switch$8141$44279 == 4)
								{
									if (205835 - 157701 == 48135)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (231505 - 165715 == 65791)
									{
										continue;
									}
								}
								else if (this.$$switch$8141$44279 == 5)
								{
									if (239289 - 226236 == 13054)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (43664 - 236855 != -193191)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (252297 - 542871 == -290573)
									{
										continue;
									}
								}
								this.$mGameGui$44280 = (GameGui)this.$self_$44281.GetComponent(typeof(GameGui));
								if (169348 - 73765 == 95583)
								{
									if (this.$mGameGui$44280)
									{
										if (294758 - 290937 != 3821)
										{
											continue;
										}
										this.$mGameGui$44280.close();
										if (180636 - 205240 != -24604)
										{
											continue;
										}
									}
									this.$self_$44281.SendMessage("fadeOut");
									if (271449 - 209470 != 61980)
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

			// Token: 0x0600A6F0 RID: 42736 RVA: 0x012C3DC8 File Offset: 0x012C1FC8
			internal static bool YlIuZiVwRkkBNFs0l0Wn()
			{
				return true;
			}

			// Token: 0x0600A6F1 RID: 42737 RVA: 0x012C3DCC File Offset: 0x012C1FCC
			internal static bool lJl3cAVwwwLYF6OJqLOJ()
			{
				return false;
			}

			// Token: 0x04009527 RID: 38183
			internal int $$switch$8141$44279;

			// Token: 0x04009528 RID: 38184
			internal GameGui $mGameGui$44280;

			// Token: 0x04009529 RID: 38185
			internal M941_SkyBug $self_$44281;
		}
	}
}
