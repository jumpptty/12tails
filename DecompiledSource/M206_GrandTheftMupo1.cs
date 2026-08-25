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

// Token: 0x020013D8 RID: 5080
[Serializable]
public class M206_GrandTheftMupo1 : MonoBehaviour
{
	// Token: 0x06007549 RID: 30025 RVA: 0x00FCAE80 File Offset: 0x00FC9080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M206_GrandTheftMupo1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600754A RID: 30026 RVA: 0x00FCAE90 File Offset: 0x00FC9090
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (283053 - 506784 != -223731)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (52895 - 345965 == -293070)
			{
				Game.mGameType = 5;
				if (205119 - 363707 == -158588)
				{
					if (Chat.Initialized)
					{
						if (77711 - 401736 == -324025)
						{
							Chat.ChatDisplay.Clear();
							if (80709 - 312997 != -232287)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (229622 - 297209 != -67586)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600754B RID: 30027 RVA: 0x00FCAF74 File Offset: 0x00FC9174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (156058 - 3811 != 152248)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (15914 - 494961 != -479046)
				{
					if (Game.mNextGameCode != 206)
					{
						break;
					}
					if (276812 - 159612 == 117200)
					{
						Game.nextGame();
						if (298186 - 389232 == -91046)
						{
							Game.mGameCode = 206;
							if (253557 - 435774 != -182216)
							{
								Game.mGameType = 5;
								if (186396 - 425964 == -239568)
								{
									Game.mGameTime = Time.time;
									if (85552 - 409682 != -324129)
									{
										Game.mGameScore = 0;
										if (157403 - 465477 == -308074)
										{
											Game.mGameMana = 0;
											if (17040 - 8626 != 8415)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (127580 - 130373 != -2792)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (25991 - 322799 != -296807)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (299062 - 318263 == -19201)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (211300 - 496333 == -285033)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (162452 - 165991 != -3538)
																{
																	this.TQHcjYatGPZ = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (58944 - 439084 == -380140)
																	{
																		this.VfecjTn9xa5 = PhotonClient.Connection;
																		if (111903 - 18752 != 93152)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (87262 - 582234 != -494971)
																			{
																				this.InitGame();
																				if (199244 - 199421 == -177)
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
				if (279653 - 245225 == 34428)
				{
					Game.mGameType = 99;
					if (90830 - 434617 == -343787)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600754C RID: 30028 RVA: 0x00FCB27C File Offset: 0x00FC947C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (296044 - 211712 != 84332)
		{
		}
		for (;;)
		{
			if (this.VfecjTn9xa5 == null)
			{
				if (212274 - 429230 != -216955)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (289799 - 215742 != 74058)
				{
					if (mGameState == eGameState.Init)
					{
						if (64559 - 366672 == -302113)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (169844 - 68376 == 101468)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (23360 - 589786 != -566425)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (209418 - 513326 == -303908)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (174721 - 314751 != -140029)
						{
							if (!this.NHNcjdp0rAB)
							{
								if (94275 - 1750 == 92526)
								{
									continue;
								}
								this.NHNcjdp0rAB = GameObject.Find("SpawnPoint0");
								if (286944 - 118141 != 168803)
								{
									continue;
								}
							}
							if (this.vOucjbkOJUp)
							{
								if (98741 - 150029 != -51288)
								{
									continue;
								}
								if (this.NHNcjdp0rAB)
								{
									if (56560 - 276588 == -220027)
									{
										continue;
									}
									Vector3 vector = global::Math.vFlat(this.NHNcjdp0rAB.transform.position - this.vOucjbkOJUp.transform.position);
									if (274455 - 461313 == -186857)
									{
										continue;
									}
									if (vector.sqrMagnitude > (float)1)
									{
										if (236037 - 447738 != -211701)
										{
											continue;
										}
										CharacterController characterController = (CharacterController)this.vOucjbkOJUp.GetComponent(typeof(CharacterController));
										if (157383 - 48255 != 109128)
										{
											continue;
										}
										this.vOucjbkOJUp.transform.rotation = Quaternion.Slerp(this.vOucjbkOJUp.transform.rotation, Quaternion.LookRotation(vector.normalized), Time.deltaTime);
										if (198251 - 165370 != 32881)
										{
											continue;
										}
										characterController.Move(((float)2 * vector.normalized - 0.3f * Vector3.up) * Time.deltaTime);
										if (146284 - 412836 != -266552)
										{
											continue;
										}
									}
								}
							}
							if (Game.music != 0)
							{
								if (217381 - 243697 != -26316)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (116948 - 92139 != 24809)
									{
										continue;
									}
									this.audio.Play();
									if (34143 - 77258 != -43115)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (286645 - 596902 == -310257)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (46799 - 18585 != 28215)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (206011 - 572921 == -366910)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (29613 - 547425 == -517812)
						{
							if (Time.time > this.yKPcj3eLpOc)
							{
								if (216454 - 325576 != -109122)
								{
									continue;
								}
								Game.mGameMana++;
								if (216538 - 394132 != -177594)
								{
									continue;
								}
								this.yKPcj3eLpOc = Time.time + (float)12;
								if (286673 - 265008 == 21666)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (297575 - 31598 != 265977)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (137190 - 586188 != -448998)
									{
										continue;
									}
									this.audio.Play();
									if (59115 - 474907 == -415791)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (291928 - 161057 == 130871)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (247775 - 487056 == -239281)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (76589 - 546833 != -470243)
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
						if (24010 - 330761 != -306750)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600754D RID: 30029 RVA: 0x00FCB888 File Offset: 0x00FC9A88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (144407 - 85136 != 59271)
		{
		}
		while (this.UxfcjgVm12u)
		{
			if (262238 - 275502 != -13263)
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (176035 - 298334 == -122299)
				{
					if (Time.time - Game.mGameTime <= 0.5f)
					{
						break;
					}
					if (9980 - 82545 != -72564)
					{
						if (Time.time - Game.mGameTime >= 2.5f)
						{
							break;
						}
						if (93062 - 235402 != -142339)
						{
							GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
							if (86596 - 170124 == -83528)
							{
								float num = (float)(1024 * Screen.width / Screen.height);
								if (67210 - 214640 == -147430)
								{
									GUI.depth = 1;
									if (294749 - 40897 == 253852)
									{
										float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime - 0.5f);
										if (168107 - 218788 == -50681)
										{
											float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime - 0.5f, (float)1));
											if (33518 - 34362 == -844)
											{
												Color color = GUI.color;
												if (37230 - 492997 == -455767)
												{
													color.a = a;
													if (148858 - 172676 == -23818)
													{
														if (104819 - 45080 != 59740)
														{
															GUI.color = color;
															if (51087 - 533614 != -482526 && 289344 - 69105 != 220240)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.UxfcjgVm12u);
																if (2063 - 423935 == -421872)
																{
																	float a2 = 1f;
																	if (130028 - 284107 != -154078)
																	{
																		Color color2 = GUI.color;
																		if (144225 - 448118 == -303893)
																		{
																			color2.a = a2;
																			if (15007 - 531584 != -516576)
																			{
																				if (226214 - 445348 == -219134)
																				{
																					Color color3 = GUI.color = color2;
																					if (260411 - 198826 != 61586 && 175779 - 577370 == -401591)
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

	// Token: 0x0600754E RID: 30030 RVA: 0x00FCBC44 File Offset: 0x00FC9E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M206_GrandTheftMupo1.$onGameEvent$37881(data, this).GetEnumerator();
	}

	// Token: 0x0600754F RID: 30031 RVA: 0x00FCBC54 File Offset: 0x00FC9E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RunDestination(GameObject enterObject)
	{
		if (57930 - 84171 != -26241)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (196564 - 562374 != -365810)
				{
					continue;
				}
				if (this.vbvcjaxsdCn > 1)
				{
					if (266762 - 388116 != -121354)
					{
						continue;
					}
					break;
				}
			}
			Debug.Log("RunDestination");
			if (53845 - 502011 == -448166)
			{
				CharacterControl characterControl = (CharacterControl)enterObject.GetComponent(typeof(CharacterControl));
				if (70351 - 309979 == -239628)
				{
					if (!(characterControl.Type == "RunAwayBug"))
					{
						break;
					}
					if (178754 - 525251 == -346497)
					{
						this.vbvcjaxsdCn = 2;
						if (89215 - 357741 != -268525)
						{
							Game.sendMissionEvent(2062, 0);
							if (235986 - 337462 == -101476)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007550 RID: 30032 RVA: 0x00FCBDA8 File Offset: 0x00FC9FA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (138046 - 258338 != -120291)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (281332 - 533301 != -251968)
			{
				if (!this.UxfcjgVm12u)
				{
					if (59405 - 195418 == -136012)
					{
						continue;
					}
					this.UxfcjgVm12u = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (151263 - 134996 != 16267)
					{
						continue;
					}
				}
				Hashtable customOpParameters = new Hashtable();
				if (13986 - 99993 != -86006)
				{
					this.VfecjTn9xa5.OpCustom(52, customOpParameters, true);
					if (71273 - 181235 == -109962)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007551 RID: 30033 RVA: 0x00FCBEB4 File Offset: 0x00FCA0B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (257871 - 168858 != 89014)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (146183 - 468625 != -322441)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (55015 - 379008 == -323993)
				{
					Game.mGameState = eGameState.Setup;
					if (39615 - 373675 == -334060)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007552 RID: 30034 RVA: 0x00FCBF58 File Offset: 0x00FCA158
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (249390 - 522566 != -273176)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (215004 - 533235 == -318231)
			{
				if (num == PlayerData.UID)
				{
					if (291151 - 330031 == -38880)
					{
						this.SetupActors();
						if (125678 - 10101 != 115578)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (220009 - 92846 != 127164)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007553 RID: 30035 RVA: 0x00FCC028 File Offset: 0x00FCA228
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (188490 - 455480 != -266989)
		{
		}
		for (;;)
		{
			IL_DE:
			Debug.Log("Creating Actors");
			if (73964 - 218748 == -144784)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (90640 - 370771 != -280130)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (61595 - 442523 != -380927)
						{
							int i = 0;
							if (194711 - 558368 == -363657)
							{
								CharacterControl[] array2 = array;
								if (228276 - 220824 != 7453)
								{
									int length = array2.Length;
									if (31828 - 314233 != -282404)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (142605 - 100993 == 41613)
											{
												goto IL_DE;
											}
											if (type == "LeafBug_r")
											{
												goto IL_2FD;
											}
											if (113873 - 367331 == -253457)
											{
												goto IL_DE;
											}
											if (type == "NinjaBug_r")
											{
												goto IL_2FD;
											}
											if (20062 - 41478 == -21415)
											{
												goto IL_DE;
											}
											if (type == "NinjaBug_g")
											{
												goto IL_2FD;
											}
											if (85763 - 410967 == -325203)
											{
												goto IL_DE;
											}
											if (type == "NinjaBug_b")
											{
												goto IL_2FD;
											}
											if (95511 - 231062 == -135550)
											{
												goto IL_DE;
											}
											if (type == "NinjaBug_y")
											{
												goto IL_2FD;
											}
											if (255642 - 329763 == -74120)
											{
												goto IL_DE;
											}
											if (type == "NinjaBug_k")
											{
												goto IL_2FD;
											}
											if (8022 - 571339 == -563316)
											{
												goto IL_DE;
											}
											if (type == "RunAwayBug")
											{
												if (278041 - 95604 != 182437)
												{
													goto IL_DE;
												}
												goto IL_2FD;
											}
											IL_10C:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (286952 - 552610 == -265657)
											{
												goto IL_DE;
											}
											this.nQ6cjsxT37R++;
											if (206416 - 395845 != -189429)
											{
												goto IL_DE;
											}
											i++;
											if (214154 - 87320 != 126835)
											{
												continue;
											}
											goto IL_DE;
											IL_2FD:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (223040 - 177672 != 45368)
											{
												goto IL_DE;
											}
											goto IL_10C;
										}
										if (135941 - 128319 == 7622)
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
						if (111334 - 103420 != 7915)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007554 RID: 30036 RVA: 0x00FCC398 File Offset: 0x00FCA598
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (298128 - 151648 != 146480)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (212193 - 269810 == -57617)
			{
				int i = 0;
				if (166488 - 395956 == -229468)
				{
					CharacterControl[] array2 = array;
					if (76407 - 221083 != -144675)
					{
						int length = array2.Length;
						if (271176 - 135973 != 135204)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (141410 - 379728 != -238318)
								{
									goto IL_1A;
								}
								i++;
								if (143056 - 221794 != -78738)
								{
									goto IL_1A;
								}
							}
							if (239264 - 107778 == 131486)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007555 RID: 30037 RVA: 0x00FCC4C8 File Offset: 0x00FCA6C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (194294 - 451917 != -257622)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (69391 - 591107 != -521715)
			{
				hashtable.Add(43, PlayerData.UID);
				if (25749 - 356329 == -330580)
				{
					hashtable.Add(73, nType);
					if (52143 - 566324 == -514181)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (113414 - 437565 != -324150)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (252129 - 321230 != -69100)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (38031 - 458451 == -420420)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (275417 - 250126 != 25292)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (292999 - 146449 != 146551)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (59564 - 593326 == -533762)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (70818 - 411625 != -340806)
												{
													this.VfecjTn9xa5.OpCustom(63, hashtable, true);
													if (132858 - 133395 != -536)
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

	// Token: 0x06007556 RID: 30038 RVA: 0x00FCC780 File Offset: 0x00FCA980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (133822 - 343152 != -209330)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createActor(data);
			if (178021 - 272787 == -94766)
			{
				if (Game.mGameState != eGameState.Setup)
				{
					break;
				}
				if (60168 - 558134 == -497966)
				{
					if (this.nQ6cjsxT37R <= 0)
					{
						break;
					}
					if (189216 - 105927 == 83289)
					{
						this.nQ6cjsxT37R--;
						if (100155 - 156512 == -56357)
						{
							if (this.nQ6cjsxT37R != 0)
							{
								break;
							}
							if (56179 - 451591 == -395412)
							{
								Game.setGameState(eGameState.Ready);
								if (145002 - 490597 == -345595)
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

	// Token: 0x06007557 RID: 30039 RVA: 0x00FCC894 File Offset: 0x00FCAA94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (55120 - 83653 != -28532)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (171726 - 579831 == -408105)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (281189 - 105871 != 175319)
				{
					if (!characterControl)
					{
						break;
					}
					if (140311 - 33500 == 106811)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (200382 - 17912 != 182471)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (36436 - 168025 != -131588)
							{
								if (!(characterControl.Type == "RunAwayBug"))
								{
									break;
								}
								if (166727 - 105479 != 61249)
								{
									Game.sendMissionEvent(2061, 0);
									if (155263 - 136854 == 18409)
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

	// Token: 0x06007558 RID: 30040 RVA: 0x00FCC9EC File Offset: 0x00FCABEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (131118 - 86647 != 44471)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (269570 - 345655 == -76085)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (104346 - 587570 != -483223)
				{
					if (!characterControl)
					{
						break;
					}
					if (66734 - 129709 == -62975)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (253678 - 268078 != -14399)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (140812 - 241305 == -100493)
							{
								if (!(characterControl.Type == "RunAwayBug"))
								{
									break;
								}
								if (106673 - 248672 != -141998)
								{
									Game.sendMissionEvent(2061, 0);
									if (77754 - 79558 == -1804)
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

	// Token: 0x06007559 RID: 30041 RVA: 0x00FCCB44 File Offset: 0x00FCAD44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (211410 - 20900 != 190511)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (197643 - 89193 != 108451)
			{
				Game.mGameState = eGameState.Ready;
				if (51617 - 440506 != -388888)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (278093 - 378269 == -100176)
					{
						GameObject gameObject = null;
						if (285304 - 254115 == 31189)
						{
							GameObject gameObject2 = null;
							if (174765 - 469346 == -294581)
							{
								if (playerSlot > 1)
								{
									if (178729 - 69010 != 109719)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (13165 - 418029 != -404864)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (172333 - 281634 == -109300)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (33912 - 590513 == -556600)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (271551 - 287079 != -15528)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (247340 - 593573 == -346232)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (178581 - 469010 == -290428)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (43801 - 378107 == -334305)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (146727 - 217180 != -70453)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (190961 - 280419 == -89457)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (288271 - 579506 != -291234)
								{
									this.transform.position = gameObject2.transform.position;
									if (267834 - 598688 == -330854)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (187288 - 42629 != 144660)
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

	// Token: 0x0600755A RID: 30042 RVA: 0x00FCCE40 File Offset: 0x00FCB040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M206_GrandTheftMupo1.$StartGame$37891(this).GetEnumerator();
	}

	// Token: 0x0600755B RID: 30043 RVA: 0x00FCCE50 File Offset: 0x00FCB050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600755C RID: 30044 RVA: 0x00FCCE54 File Offset: 0x00FCB054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (268053 - 473131 != -205078)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (170215 - 366223 == -196008)
			{
				hashtable.Add(71, CID);
				if (116618 - 568938 == -452320)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (3612 - 293422 != -289809)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (47137 - 304963 != -257825)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (260852 - 140909 != 119944)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (130228 - 265608 != -135379)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (70812 - 201262 == -130450)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (267881 - 419312 == -151431)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (268360 - 444813 != -176452)
											{
												this.VfecjTn9xa5.OpCustom(61, hashtable, true);
												if (136841 - 337665 != -200823)
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

	// Token: 0x0600755D RID: 30045 RVA: 0x00FCD0E0 File Offset: 0x00FCB2E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (218151 - 472756 != -254604)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (147155 - 584785 == -437630)
			{
				if (!gameObject)
				{
					break;
				}
				if (169941 - 282929 == -112988)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (263462 - 194157 == 69305)
					{
						playerCameraControl.target = gameObject;
						if (180946 - 553088 == -372142)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (76173 - 358897 != -282723)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600755E RID: 30046 RVA: 0x00FCD1D8 File Offset: 0x00FCB3D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (271010 - 476229 != -205219)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (190945 - 219439 == -28494)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (4725 - 82527 != -77801)
				{
					gameGui.ResetTeamBar();
					if (276845 - 395109 != -118263)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600755F RID: 30047 RVA: 0x00FCD284 File Offset: 0x00FCB484
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M206_GrandTheftMupo1.$onDeadPlayer$37898(this).GetEnumerator();
	}

	// Token: 0x06007560 RID: 30048 RVA: 0x00FCD294 File Offset: 0x00FCB494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (121788 - 208742 != -86953)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (150141 - 333828 != -183686)
			{
				this.TQHcjYatGPZ.target = Game.mPlayer;
				if (233704 - 414228 != -180523)
				{
					this.TQHcjYatGPZ.enabled = true;
					if (6423 - 395530 != -389106)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (131038 - 418539 != -287501)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (82865 - 385215 == -302349)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (83133 - 417533 == -334400)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (145821 - 447103 == -301282)
							{
								if (!gameGui)
								{
									break;
								}
								if (104273 - 218231 != -113957)
								{
									gameGui.enabled = true;
									if (52613 - 380603 == -327990)
									{
										gameGui.closeDeadMenu();
										if (163961 - 326093 != -162131)
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

	// Token: 0x06007561 RID: 30049 RVA: 0x00FCD440 File Offset: 0x00FCB640
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (208596 - 372412 != -163815)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (101996 - 526402 == -424406)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (235326 - 498053 != -262726)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (44140 - 346803 == -302663)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007562 RID: 30050 RVA: 0x00FCD504 File Offset: 0x00FCB704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007563 RID: 30051 RVA: 0x00FCD530 File Offset: 0x00FCB730
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M206_GrandTheftMupo1.$onGameComplete$37904(data, this).GetEnumerator();
	}

	// Token: 0x06007564 RID: 30052 RVA: 0x00FCD540 File Offset: 0x00FCB740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M206_GrandTheftMupo1.$ReturnToTown$37913(this).GetEnumerator();
	}

	// Token: 0x06007565 RID: 30053 RVA: 0x00FCD550 File Offset: 0x00FCB750
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M206_GrandTheftMupo1.$ReturnToGuild$37918(this).GetEnumerator();
	}

	// Token: 0x06007566 RID: 30054 RVA: 0x00FCD560 File Offset: 0x00FCB760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M206_GrandTheftMupo1.$ReturnToCamp$37922(this).GetEnumerator();
	}

	// Token: 0x06007567 RID: 30055 RVA: 0x00FCD570 File Offset: 0x00FCB770
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (125253 - 59405 != 65848)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (75739 - 139126 != -63386)
			{
				Hashtable hashtable = new Hashtable();
				if (59819 - 297103 == -237284)
				{
					hashtable.Add(43, PlayerData.UID);
					if (289746 - 363899 == -74153)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (222287 - 173807 == 48480)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007568 RID: 30056 RVA: 0x00FCD648 File Offset: 0x00FCB848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007569 RID: 30057 RVA: 0x00FCD65C File Offset: 0x00FCB85C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (92773 - 223507 != -130733)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (150348 - 365189 != -214840)
			{
				Hashtable hashtable = new Hashtable();
				if (42049 - 456952 != -414902)
				{
					if (Game.mNextGameCode == 30)
					{
						if (238524 - 539414 != -300890)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (282947 - 260698 != 22249)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (61995 - 195218 != -133223)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (286120 - 585400 != -299280)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (8904 - 419632 != -410728)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (30916 - 500041 == -469124)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (140854 - 255518 == -114663)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (73250 - 504288 == -431037)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (262275 - 558815 != -296540)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (55122 - 314411 == -259288)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (62943 - 201097 == -138153)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (59991 - 425546 != -365555)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (285760 - 177490 != 108270)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (257390 - 530042 == -272651)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (54580 - 549010 == -494429)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (61610 - 305513 == -243902)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (79918 - 542464 != -462546)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (160822 - 221867 != -61045)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (276600 - 316637 == -40036)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (20984 - 449486 != -428502)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (43238 - 275965 != -232727)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (35080 - 50052 != -14972)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (46147 - 168650 != -122503)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (18478 - 78004 != -59526)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (273921 - 450103 != -176182)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (142565 - 245066 != -102501)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (70318 - 287503 != -217185)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (189984 - 347754 == -157769)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (188830 - 578666 == -389836)
					{
						this.VfecjTn9xa5.OpCustom(42, hashtable, true);
						if (91757 - 588265 != -496507)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600756A RID: 30058 RVA: 0x00FCDC10 File Offset: 0x00FCBE10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600756B RID: 30059 RVA: 0x00FCDC20 File Offset: 0x00FCBE20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600756C RID: 30060 RVA: 0x00FCDC24 File Offset: 0x00FCBE24
	internal static bool eJwG0RpdeZuwIFxIl6em()
	{
		return true;
	}

	// Token: 0x0600756D RID: 30061 RVA: 0x00FCDC28 File Offset: 0x00FCBE28
	internal static bool KfGISQpdr6yZe5E8Xh6i()
	{
		return false;
	}

	// Token: 0x04007A07 RID: 31239
	private LitePeer VfecjTn9xa5;

	// Token: 0x04007A08 RID: 31240
	private PlayerCameraControl TQHcjYatGPZ;

	// Token: 0x04007A09 RID: 31241
	private float yKPcj3eLpOc;

	// Token: 0x04007A0A RID: 31242
	private GameObject vOucjbkOJUp;

	// Token: 0x04007A0B RID: 31243
	private GameObject NHNcjdp0rAB;

	// Token: 0x04007A0C RID: 31244
	private Texture UxfcjgVm12u;

	// Token: 0x04007A0D RID: 31245
	private int vbvcjaxsdCn;

	// Token: 0x04007A0E RID: 31246
	private int rYFcj4AtLQe;

	// Token: 0x04007A0F RID: 31247
	private int nQ6cjsxT37R;

	// Token: 0x020013D9 RID: 5081
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$37881 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600756E RID: 30062 RVA: 0x00FCDC2C File Offset: 0x00FCBE2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$37881(Hashtable data, M206_GrandTheftMupo1 self_)
		{
			if (42419 - 559697 != -517278)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (256407 - 253040 == 3367)
				{
					base..ctor();
					if (168908 - 81679 == 87229)
					{
						this.$data$37889 = data;
						if (38016 - 385943 == -347927)
						{
							this.$self_$37890 = self_;
							if (152420 - 84573 != 67848)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x00FCDCE8 File Offset: 0x00FCBEE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M206_GrandTheftMupo1.$onGameEvent$37881.$(this.$data$37889, this.$self_$37890);
		}

		// Token: 0x06007570 RID: 30064 RVA: 0x00FCDCFC File Offset: 0x00FCBEFC
		internal static bool xD9jfmpdjQS4VAmDtdw9()
		{
			return true;
		}

		// Token: 0x06007571 RID: 30065 RVA: 0x00FCDD00 File Offset: 0x00FCBF00
		internal static bool hrMdOjpdhvEIVOYYqXZ6()
		{
			return false;
		}

		// Token: 0x04007A10 RID: 31248
		internal Hashtable $data$37889;

		// Token: 0x04007A11 RID: 31249
		internal M206_GrandTheftMupo1 $self_$37890;

		// Token: 0x020013DA RID: 5082
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007572 RID: 30066 RVA: 0x00FCDD04 File Offset: 0x00FCBF04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M206_GrandTheftMupo1 self_)
			{
				if (100882 - 181969 != -81086)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (163800 - 254667 == -90867)
					{
						base..ctor();
						if (35291 - 383573 != -348281)
						{
							this.$data$37887 = data;
							if (93091 - 436783 == -343692)
							{
								this.$self_$37888 = self_;
								if (59984 - 592704 != -532719)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007573 RID: 30067 RVA: 0x00FCDDC0 File Offset: 0x00FCBFC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (233303 - 61623 != 171680)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_377;
					case 2:
						this.$mGameGui$37886 = (GameGui)this.$self_$37888.GetComponent(typeof(GameGui));
						if (6891 - 427900 != -421009)
						{
							continue;
						}
						this.$mGameGui$37886.close();
						if (221006 - 420076 != -199070)
						{
							continue;
						}
						Game.savePlayer();
						if (127963 - 254499 != -126536)
						{
							continue;
						}
						this.$self_$37888.SendMessage("fadeOut");
						if (41628 - 452080 != -410451)
						{
							goto Block_19;
						}
						continue;
					case 3:
						Game.mGameStage = 2;
						if (256417 - 504262 == -247844)
						{
							continue;
						}
						Application.LoadLevel("M206_GrandTheftMupo2");
						if (154190 - 78500 != 75691)
						{
							goto IL_228;
						}
						continue;
					default:
						if (87179 - 143220 != -56041)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (212605 - 512753 != -300147)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$37882 = RuntimeServices.UnboxInt32(this.$data$37887[141]);
						if (217801 - 262080 == -44278)
						{
							continue;
						}
						this.$returnValue$37883 = RuntimeServices.UnboxInt32(this.$data$37887[145]);
						if (289577 - 346690 != -57113)
						{
							continue;
						}
						this.$ownerID$37884 = RuntimeServices.UnboxInt32(this.$data$37887[43]);
						if (93167 - 227261 == -134093)
						{
							continue;
						}
						this.$$switch$6494$37885 = this.$returnCode$37882;
						if (76472 - 23461 != 53011)
						{
							continue;
						}
						if (this.$$switch$6494$37885 == 2061)
						{
							if (148690 - 119226 != 29464)
							{
								continue;
							}
							if (this.$self_$37888.vbvcjaxsdCn < 2)
							{
								if (228399 - 421308 == -192908)
								{
									continue;
								}
								this.$self_$37888.vbvcjaxsdCn = 2;
								if (247301 - 87924 == 159378)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (47256 - 459542 != -412286)
								{
									continue;
								}
								goto IL_D5;
							}
						}
						else if (this.$$switch$6494$37885 == 2062)
						{
							if (163489 - 346155 != -182666)
							{
								continue;
							}
							Debug.Log("WormBug has escaped!");
							if (173675 - 19951 == 153725)
							{
								continue;
							}
						}
					}
					IL_B3:
					this.YieldDefault(1);
					if (282359 - 586235 != -303875)
					{
						break;
					}
					continue;
					IL_228:
					goto IL_B3;
				}
				goto IL_377;
				IL_D5:
				return this.Yield(2, new WaitForSeconds(3f));
				goto IL_377;
				Block_19:
				return this.Yield(3, new WaitForSeconds(1.5f));
				IL_377:
				return false;
			}

			// Token: 0x06007574 RID: 30068 RVA: 0x00FCE158 File Offset: 0x00FCC358
			internal static bool a7vSrApdsUYr6cPtY7n2()
			{
				return true;
			}

			// Token: 0x06007575 RID: 30069 RVA: 0x00FCE15C File Offset: 0x00FCC35C
			internal static bool L122Ybpd9usSHggcNBjx()
			{
				return false;
			}

			// Token: 0x04007A12 RID: 31250
			internal int $returnCode$37882;

			// Token: 0x04007A13 RID: 31251
			internal int $returnValue$37883;

			// Token: 0x04007A14 RID: 31252
			internal int $ownerID$37884;

			// Token: 0x04007A15 RID: 31253
			internal int $$switch$6494$37885;

			// Token: 0x04007A16 RID: 31254
			internal GameGui $mGameGui$37886;

			// Token: 0x04007A17 RID: 31255
			internal Hashtable $data$37887;

			// Token: 0x04007A18 RID: 31256
			internal M206_GrandTheftMupo1 $self_$37888;
		}
	}

	// Token: 0x020013DB RID: 5083
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$37891 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007576 RID: 30070 RVA: 0x00FCE160 File Offset: 0x00FCC360
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$37891(M206_GrandTheftMupo1 self_)
		{
			if (260256 - 300552 != -40295)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (177369 - 540450 != -363080)
				{
					base..ctor();
					if (131518 - 114338 == 17180)
					{
						this.$self_$37897 = self_;
						if (275414 - 179321 != 96094)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x00FCE1F8 File Offset: 0x00FCC3F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M206_GrandTheftMupo1.$StartGame$37891.$(this.$self_$37897);
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x00FCE208 File Offset: 0x00FCC408
		internal static bool oSRALLpd1gtHkKB8fHTE()
		{
			return true;
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x00FCE20C File Offset: 0x00FCC40C
		internal static bool eSARJ8pd4eunM5PS0tu0()
		{
			return false;
		}

		// Token: 0x04007A19 RID: 31257
		internal M206_GrandTheftMupo1 $self_$37897;

		// Token: 0x020013DC RID: 5084
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600757A RID: 30074 RVA: 0x00FCE210 File Offset: 0x00FCC410
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M206_GrandTheftMupo1 self_)
			{
				if (209404 - 523845 != -314441)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (173910 - 410967 == -237057)
					{
						base..ctor();
						if (35965 - 415648 != -379682)
						{
							this.$self_$37896 = self_;
							if (24608 - 332004 == -307396)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600757B RID: 30075 RVA: 0x00FCE2A8 File Offset: 0x00FCC4A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (77244 - 90911 != -13667)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_77D;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (299484 - 167959 != 131525)
							{
								continue;
							}
							goto IL_5B6;
						}
						else
						{
							this.$mStoryGui$37893 = (StoryGui)this.$self_$37896.GetComponent(typeof(StoryGui));
							if (59309 - 427741 != -368432)
							{
								continue;
							}
							this.$mStoryGui$37893.startStoryMessage("GoatFarmer", "Gotan", eTalkType.friend);
							if (165041 - 215809 != -50768)
							{
								continue;
							}
							goto IL_4CD;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (61357 - 53368 != 7989)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$mStoryGui$37893.newStoryMessage("GoatFarmer", "Gotan", Language.getMessage("M206_GrandTheftMupo", 2061), eTalkType.friend);
							if (120713 - 334741 != -214028)
							{
								continue;
							}
							goto IL_68E;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (5525 - 267723 != -262198)
							{
								continue;
							}
							goto IL_32C;
						}
						else
						{
							this.$mStoryGui$37893.newStoryMessage("GoatFarmer", "Gotan", Language.getMessage("M206_GrandTheftMupo", 2062), eTalkType.friend);
							if (125432 - 501776 != -376343)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (18643 - 107159 != -88515)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$37893.close();
							if (283452 - 439662 != -156209)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (180196 - 227419 != -47222)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$self_$37896.SendMessage("fadeOut");
							if (258152 - 242188 != 15965)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (88800 - 466128 != -377327)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							this.$self_$37896.SendMessage("fadeIn");
							if (175888 - 546661 == -370772)
							{
								continue;
							}
							this.$mGameGui$37894 = (GameGui)this.$self_$37896.GetComponent(typeof(GameGui));
							if (149160 - 200123 == -50962)
							{
								continue;
							}
							this.$mGameGui$37894.enabled = true;
							if (217635 - 308587 == -90951)
							{
								continue;
							}
							this.$self_$37896.TQHcjYatGPZ.enabled = true;
							if (252005 - 505233 != -253228)
							{
								continue;
							}
							this.$self_$37896.TQHcjYatGPZ.specialTarget = null;
							if (205583 - 82479 == 123105)
							{
								continue;
							}
							this.$startCamera$37895 = GameObject.Find("StartCamera" + Game.getPlayerSlot(PlayerData.UID));
							if (139656 - 398883 == -259226)
							{
								continue;
							}
							if (this.$startCamera$37895)
							{
								if (55102 - 138535 == -83432)
								{
									continue;
								}
								this.$self_$37896.transform.position = this.$startCamera$37895.transform.position;
								if (118542 - 228422 == -109879)
								{
									continue;
								}
								this.$self_$37896.transform.rotation = this.$startCamera$37895.transform.rotation;
								if (15254 - 203815 != -188561)
								{
									continue;
								}
							}
							Game.mGameState = eGameState.Normal;
							if (69876 - 50283 != 19593)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (108587 - 230533 != -121946)
							{
								continue;
							}
							this.YieldDefault(1);
							if (260800 - 471422 != -210622)
							{
								continue;
							}
							goto IL_77D;
						}
						break;
					default:
						if (3207 - 38238 == -35030)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (17043 - 548178 != -531134)
					{
						Game.mGameState = eGameState.Start;
						if (234308 - 341199 != -106890)
						{
							Game.mGameTime = Time.time;
							if (206272 - 593069 != -386796)
							{
								this.$self_$37896.SendMessage("fadeIn");
								if (110565 - 465859 == -355294)
								{
									this.$self_$37896.vOucjbkOJUp = GameObject.Find("RunAwayBug");
									if (54656 - 437853 != -383196)
									{
										this.$mEventCamera$37892 = GameObject.Find("EventCamera");
										if (278653 - 517279 != -238625)
										{
											if (!this.$self_$37896.vOucjbkOJUp)
											{
												goto IL_266;
											}
											if (132339 - 506573 == -374234)
											{
												if (!this.$mEventCamera$37892)
												{
													goto IL_266;
												}
												if (163090 - 324874 == -161784)
												{
													this.$self_$37896.vOucjbkOJUp.animation.Play("run");
													if (286208 - 82483 != 203726)
													{
														this.$self_$37896.vOucjbkOJUp.animation.wrapMode = WrapMode.Loop;
														if (157679 - 400371 != -242691)
														{
															this.$mEventCamera$37892.transform.parent = this.$self_$37896.vOucjbkOJUp.transform;
															if (174631 - 295861 != -121229)
															{
																this.$self_$37896.TQHcjYatGPZ.setSpecialTarget(this.$mEventCamera$37892, 2f);
																if (47909 - 360315 != -312405)
																{
																	this.$self_$37896.TQHcjYatGPZ.enabled = true;
																	if (268412 - 458502 != -190089)
																	{
																		goto Block_32;
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
				IL_1A:
				goto IL_77D;
				IL_266:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_20:
				IL_32C:
				goto IL_77D;
				Block_21:
				return this.Yield(5, new WaitForSeconds(2.5f));
				Block_26:
				goto IL_77D;
				IL_4CD:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_32:
				goto IL_266;
				Block_34:
				return this.Yield(7, new WaitForSeconds(1f));
				IL_5B6:
				goto IL_77D;
				Block_40:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_68E:
				return this.Yield(4, new WaitForSeconds(2.5f));
				Block_46:
				IL_77D:
				return false;
			}

			// Token: 0x0600757C RID: 30076 RVA: 0x00FCEA44 File Offset: 0x00FCCC44
			internal static bool H7Sr3cpdzVhQ7elOGms7()
			{
				return true;
			}

			// Token: 0x0600757D RID: 30077 RVA: 0x00FCEA48 File Offset: 0x00FCCC48
			internal static bool aJn8kmpJa5wP4A7aU2h2()
			{
				return false;
			}

			// Token: 0x04007A1A RID: 31258
			internal GameObject $mEventCamera$37892;

			// Token: 0x04007A1B RID: 31259
			internal StoryGui $mStoryGui$37893;

			// Token: 0x04007A1C RID: 31260
			internal GameGui $mGameGui$37894;

			// Token: 0x04007A1D RID: 31261
			internal GameObject $startCamera$37895;

			// Token: 0x04007A1E RID: 31262
			internal M206_GrandTheftMupo1 $self_$37896;
		}
	}

	// Token: 0x020013DD RID: 5085
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37898 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600757E RID: 30078 RVA: 0x00FCEA4C File Offset: 0x00FCCC4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37898(M206_GrandTheftMupo1 self_)
		{
			if (163060 - 538027 != -374966)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (259313 - 298316 == -39003)
				{
					base..ctor();
					if (59197 - 488880 == -429683)
					{
						this.$self_$37903 = self_;
						if (248963 - 582705 == -333742)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600757F RID: 30079 RVA: 0x00FCEAE4 File Offset: 0x00FCCCE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M206_GrandTheftMupo1.$onDeadPlayer$37898.$(this.$self_$37903);
		}

		// Token: 0x06007580 RID: 30080 RVA: 0x00FCEAF4 File Offset: 0x00FCCCF4
		internal static bool sAufc3pJ5KCjaMrxVrJY()
		{
			return true;
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x00FCEAF8 File Offset: 0x00FCCCF8
		internal static bool J1MwPZpJp50rsRWEI1oQ()
		{
			return false;
		}

		// Token: 0x04007A1F RID: 31263
		internal M206_GrandTheftMupo1 $self_$37903;

		// Token: 0x020013DE RID: 5086
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007582 RID: 30082 RVA: 0x00FCEAFC File Offset: 0x00FCCCFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M206_GrandTheftMupo1 self_)
			{
				if (187686 - 428365 != -240678)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (145515 - 357436 != -211920)
					{
						base..ctor();
						if (196349 - 432771 != -236421)
						{
							this.$self_$37902 = self_;
							if (251908 - 56818 != 195091)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007583 RID: 30083 RVA: 0x00FCEB94 File Offset: 0x00FCCD94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (151299 - 589092 != -437792)
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
							if (15844 - 532546 == -516701)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_23D;
							}
							if (214647 - 337879 != -123232)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (74786 - 516181 != -441395)
						{
							continue;
						}
						this.$mStoryGui$37899 = (StoryGui)this.$self_$37902.GetComponent(typeof(StoryGui));
						if (1903 - 426522 == -424618)
						{
							continue;
						}
						if (this.$mStoryGui$37899)
						{
							if (101747 - 401632 != -299885)
							{
								continue;
							}
							this.$mStoryGui$37899.close();
							if (259696 - 46095 != 213601)
							{
								continue;
							}
						}
						this.$mChangeGui$37900 = (ChangeGui)this.$self_$37902.GetComponent(typeof(ChangeGui));
						if (218203 - 437368 == -219164)
						{
							continue;
						}
						if (this.$mChangeGui$37900)
						{
							if (44777 - 16611 != 28166)
							{
								continue;
							}
							this.$mChangeGui$37900.close();
							if (292599 - 263877 == 28723)
							{
								continue;
							}
						}
						this.$mGameGui$37901 = (GameGui)this.$self_$37902.GetComponent(typeof(GameGui));
						if (111672 - 515879 != -404207)
						{
							continue;
						}
						if (this.$mGameGui$37901)
						{
							if (6263 - 5397 == 867)
							{
								continue;
							}
							if (!this.$mGameGui$37901.enabled)
							{
								if (14222 - 472238 == -458015)
								{
									continue;
								}
								this.$mGameGui$37901.enabled = true;
								if (35111 - 18743 != 16368)
								{
									continue;
								}
							}
							this.$mGameGui$37901.openDeadMenu();
							if (112556 - 486935 == -374378)
							{
								continue;
							}
						}
						IL_23D:
						this.YieldDefault(1);
						if (54741 - 105861 != -51119)
						{
							goto Block_18;
						}
						continue;
					default:
						if (236694 - 353952 == -117257)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (283756 - 561854 != -278098);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_18:
				IL_2F9:
				return false;
			}

			// Token: 0x06007584 RID: 30084 RVA: 0x00FCEEAC File Offset: 0x00FCD0AC
			internal static bool HY8uHgpJVlqWQlLW01cv()
			{
				return true;
			}

			// Token: 0x06007585 RID: 30085 RVA: 0x00FCEEB0 File Offset: 0x00FCD0B0
			internal static bool Y7LvEFpJttmu3asAxZRt()
			{
				return false;
			}

			// Token: 0x04007A20 RID: 31264
			internal StoryGui $mStoryGui$37899;

			// Token: 0x04007A21 RID: 31265
			internal ChangeGui $mChangeGui$37900;

			// Token: 0x04007A22 RID: 31266
			internal GameGui $mGameGui$37901;

			// Token: 0x04007A23 RID: 31267
			internal M206_GrandTheftMupo1 $self_$37902;
		}
	}

	// Token: 0x020013DF RID: 5087
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37904 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007586 RID: 30086 RVA: 0x00FCEEB4 File Offset: 0x00FCD0B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37904(Hashtable data, M206_GrandTheftMupo1 self_)
		{
			if (44256 - 364149 != -319892)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (162499 - 416061 == -253562)
				{
					base..ctor();
					if (137924 - 404006 == -266082)
					{
						this.$data$37911 = data;
						if (51426 - 486857 != -435430)
						{
							this.$self_$37912 = self_;
							if (749 - 131511 != -130761)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007587 RID: 30087 RVA: 0x00FCEF70 File Offset: 0x00FCD170
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M206_GrandTheftMupo1.$onGameComplete$37904.$(this.$data$37911, this.$self_$37912);
		}

		// Token: 0x06007588 RID: 30088 RVA: 0x00FCEF84 File Offset: 0x00FCD184
		internal static bool M8jlcjpJNn0Oqwy0GcWR()
		{
			return true;
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x00FCEF88 File Offset: 0x00FCD188
		internal static bool jIdlAxpJYPZdmL6wHLaI()
		{
			return false;
		}

		// Token: 0x04007A24 RID: 31268
		internal Hashtable $data$37911;

		// Token: 0x04007A25 RID: 31269
		internal M206_GrandTheftMupo1 $self_$37912;

		// Token: 0x020013E0 RID: 5088
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600758A RID: 30090 RVA: 0x00FCEF8C File Offset: 0x00FCD18C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M206_GrandTheftMupo1 self_)
			{
				if (172704 - 256565 != -83860)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (206667 - 518581 != -311913)
					{
						base..ctor();
						if (224055 - 497782 != -273726)
						{
							this.$data$37909 = data;
							if (217180 - 324336 != -107155)
							{
								this.$self_$37910 = self_;
								if (209917 - 353202 != -143284)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600758B RID: 30091 RVA: 0x00FCF048 File Offset: 0x00FCD248
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (214150 - 508945 != -294794)
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
						this.$mCompleteGui$37906 = (CompleteGui)this.$self_$37910.GetComponent(typeof(CompleteGui));
						if (181510 - 7061 != 174449)
						{
							continue;
						}
						this.$mCompleteGui$37906.Init();
						if (167320 - 22049 == 145272)
						{
							continue;
						}
						this.$mCompleteGui$37906.readData(this.$data$37909);
						if (201498 - 60252 == 141247)
						{
							continue;
						}
						if (this.$result$37905 == 1)
						{
							if (200341 - 336873 == -136531)
							{
								continue;
							}
							this.$mCompleteGui$37906.displayResult(eCompleteType.Success);
							if (2437 - 5941 == -3503)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37906.displayResult(eCompleteType.Failed);
							if (98089 - 572158 == -474068)
							{
								continue;
							}
						}
						this.$mGameGui$37907 = (GameGui)this.$self_$37910.GetComponent(typeof(GameGui));
						if (165518 - 150116 != 15402)
						{
							continue;
						}
						this.$mStoryGui$37908 = (StoryGui)this.$self_$37910.GetComponent(typeof(StoryGui));
						if (290211 - 324654 == -34442)
						{
							continue;
						}
						if (this.$mGameGui$37907)
						{
							if (198950 - 271438 != -72488)
							{
								continue;
							}
							this.$mGameGui$37907.close();
							if (177508 - 49779 != 127729)
							{
								continue;
							}
						}
						if (this.$mStoryGui$37908)
						{
							if (8382 - 210418 != -202036)
							{
								continue;
							}
							this.$mStoryGui$37908.close();
							if (107284 - 235543 != -128259)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (210334 - 331542 != -121207)
						{
							goto Block_15;
						}
						continue;
					default:
						if (37826 - 284067 == -246240)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$37909[31]);
					if (105111 - 159280 == -54169)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (59740 - 588203 == -528463)
							{
								goto IL_EC;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (233352 - 76152 != 157201)
							{
								this.$result$37905 = RuntimeServices.UnboxInt32(this.$data$37909[31]);
								if (164074 - 186360 != -22285)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_EC:
				Block_15:
				IL_352:
				return false;
			}

			// Token: 0x0600758C RID: 30092 RVA: 0x00FCF3BC File Offset: 0x00FCD5BC
			internal static bool Px9ULYpJcfZNYJNPlASQ()
			{
				return true;
			}

			// Token: 0x0600758D RID: 30093 RVA: 0x00FCF3C0 File Offset: 0x00FCD5C0
			internal static bool nDxQR9pJU72MeM6Ocp3o()
			{
				return false;
			}

			// Token: 0x04007A26 RID: 31270
			internal int $result$37905;

			// Token: 0x04007A27 RID: 31271
			internal CompleteGui $mCompleteGui$37906;

			// Token: 0x04007A28 RID: 31272
			internal GameGui $mGameGui$37907;

			// Token: 0x04007A29 RID: 31273
			internal StoryGui $mStoryGui$37908;

			// Token: 0x04007A2A RID: 31274
			internal Hashtable $data$37909;

			// Token: 0x04007A2B RID: 31275
			internal M206_GrandTheftMupo1 $self_$37910;
		}
	}

	// Token: 0x020013E1 RID: 5089
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37913 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600758E RID: 30094 RVA: 0x00FCF3C4 File Offset: 0x00FCD5C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37913(M206_GrandTheftMupo1 self_)
		{
			if (197343 - 76815 != 120529)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (154352 - 59287 != 95066)
				{
					base..ctor();
					if (14493 - 133428 != -118934)
					{
						this.$self_$37917 = self_;
						if (268527 - 57127 != 211401)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x00FCF45C File Offset: 0x00FCD65C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M206_GrandTheftMupo1.$ReturnToTown$37913.$(this.$self_$37917);
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x00FCF46C File Offset: 0x00FCD66C
		internal static bool dVfMhSpJTABVQQcsIlWn()
		{
			return true;
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x00FCF470 File Offset: 0x00FCD670
		internal static bool TnKv2BpJ3DCfgcXJhYOB()
		{
			return false;
		}

		// Token: 0x04007A2C RID: 31276
		internal M206_GrandTheftMupo1 $self_$37917;

		// Token: 0x020013E2 RID: 5090
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007592 RID: 30098 RVA: 0x00FCF474 File Offset: 0x00FCD674
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M206_GrandTheftMupo1 self_)
			{
				if (268371 - 257001 != 11370)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (50462 - 514254 == -463792)
					{
						base..ctor();
						if (268300 - 419832 == -151532)
						{
							this.$self_$37916 = self_;
							if (160444 - 573363 != -412918)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007593 RID: 30099 RVA: 0x00FCF50C File Offset: 0x00FCD70C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (171592 - 477825 != -306232)
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
						this.$self_$37916.LeaveGame();
						if (186866 - 60824 == 126043)
						{
							continue;
						}
						this.YieldDefault(1);
						if (230836 - 576818 != -345982)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (183741 - 247746 != -64005)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (280791 - 85776 != 195016)
					{
						Game.mStateTime = Time.time;
						if (184742 - 407274 == -222532)
						{
							this.$$switch$6498$37914 = PlayerData.SaveGuild;
							if (261586 - 258568 != 3019)
							{
								if (this.$$switch$6498$37914 == 1)
								{
									if (98440 - 172935 != -74495)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (295155 - 402310 != -107155)
									{
										continue;
									}
								}
								else if (this.$$switch$6498$37914 == 2)
								{
									if (221973 - 397507 != -175534)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (49804 - 453510 == -403705)
									{
										continue;
									}
								}
								else if (this.$$switch$6498$37914 == 3)
								{
									if (79597 - 352318 != -272721)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (169178 - 413936 != -244758)
									{
										continue;
									}
								}
								else if (this.$$switch$6498$37914 == 4)
								{
									if (164216 - 564132 != -399916)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (84134 - 467328 != -383194)
									{
										continue;
									}
								}
								else if (this.$$switch$6498$37914 == 5)
								{
									if (182468 - 316578 != -134110)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (51510 - 52399 == -888)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (208799 - 143325 == 65475)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (289649 - 83617 != 206032)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (51724 - 328407 == -276682)
									{
										continue;
									}
								}
								this.$mGameGui$37915 = (GameGui)this.$self_$37916.GetComponent(typeof(GameGui));
								if (48866 - 73749 == -24883)
								{
									if (this.$mGameGui$37915)
									{
										if (66924 - 315322 == -248397)
										{
											continue;
										}
										this.$mGameGui$37915.close();
										if (165664 - 253114 == -87449)
										{
											continue;
										}
									}
									this.$self_$37916.SendMessage("fadeOut");
									if (297871 - 369834 == -71963)
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

			// Token: 0x06007594 RID: 30100 RVA: 0x00FCF8D8 File Offset: 0x00FCDAD8
			internal static bool fWrvgLpJXfjT70IGa7RH()
			{
				return true;
			}

			// Token: 0x06007595 RID: 30101 RVA: 0x00FCF8DC File Offset: 0x00FCDADC
			internal static bool eOCtujpJQBenql7jLBDv()
			{
				return false;
			}

			// Token: 0x04007A2D RID: 31277
			internal int $$switch$6498$37914;

			// Token: 0x04007A2E RID: 31278
			internal GameGui $mGameGui$37915;

			// Token: 0x04007A2F RID: 31279
			internal M206_GrandTheftMupo1 $self_$37916;
		}
	}

	// Token: 0x020013E3 RID: 5091
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37918 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007596 RID: 30102 RVA: 0x00FCF8E0 File Offset: 0x00FCDAE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37918(M206_GrandTheftMupo1 self_)
		{
			if (138335 - 122143 != 16192)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (37192 - 128813 == -91621)
				{
					base..ctor();
					if (119203 - 366952 == -247749)
					{
						this.$self_$37921 = self_;
						if (259345 - 288392 != -29046)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x00FCF978 File Offset: 0x00FCDB78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M206_GrandTheftMupo1.$ReturnToGuild$37918.$(this.$self_$37921);
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x00FCF988 File Offset: 0x00FCDB88
		internal static bool Im7vcBpJkCr38fEWt5es()
		{
			return true;
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x00FCF98C File Offset: 0x00FCDB8C
		internal static bool KPuojhpJGKZ1yiw17pYH()
		{
			return false;
		}

		// Token: 0x04007A30 RID: 31280
		internal M206_GrandTheftMupo1 $self_$37921;

		// Token: 0x020013E4 RID: 5092
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600759A RID: 30106 RVA: 0x00FCF990 File Offset: 0x00FCDB90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M206_GrandTheftMupo1 self_)
			{
				if (92522 - 244385 != -151863)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (38170 - 570213 != -532042)
					{
						base..ctor();
						if (236181 - 286035 == -49854)
						{
							this.$self_$37920 = self_;
							if (280846 - 269136 == 11710)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600759B RID: 30107 RVA: 0x00FCFA28 File Offset: 0x00FCDC28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (6674 - 490606 != -483932)
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
						this.$self_$37920.LeaveGame();
						if (188320 - 325210 != -136890)
						{
							continue;
						}
						this.YieldDefault(1);
						if (127094 - 199512 != -72418)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (251849 - 157009 == 94841)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (63968 - 399696 != -335727)
					{
						Game.mStateTime = Time.time;
						if (112220 - 510681 != -398460)
						{
							Game.mNextGameCode = 31;
							if (168508 - 465060 != -296551)
							{
								this.$mGameGui$37919 = (GameGui)this.$self_$37920.GetComponent(typeof(GameGui));
								if (218018 - 262085 != -44066)
								{
									if (this.$mGameGui$37919)
									{
										if (134502 - 371868 != -237366)
										{
											continue;
										}
										this.$mGameGui$37919.close();
										if (201965 - 549494 == -347528)
										{
											continue;
										}
									}
									this.$self_$37920.SendMessage("fadeOut");
									if (192119 - 486277 != -294157)
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

			// Token: 0x0600759C RID: 30108 RVA: 0x00FCFC04 File Offset: 0x00FCDE04
			internal static bool yRdotKpJH133uDkRUNQI()
			{
				return true;
			}

			// Token: 0x0600759D RID: 30109 RVA: 0x00FCFC08 File Offset: 0x00FCDE08
			internal static bool WIVvb9pJWrp99w6BNTj7()
			{
				return false;
			}

			// Token: 0x04007A31 RID: 31281
			internal GameGui $mGameGui$37919;

			// Token: 0x04007A32 RID: 31282
			internal M206_GrandTheftMupo1 $self_$37920;
		}
	}

	// Token: 0x020013E5 RID: 5093
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37922 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600759E RID: 30110 RVA: 0x00FCFC0C File Offset: 0x00FCDE0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37922(M206_GrandTheftMupo1 self_)
		{
			if (237568 - 35629 != 201940)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (76015 - 168371 != -92355)
				{
					base..ctor();
					if (234874 - 241592 == -6718)
					{
						this.$self_$37926 = self_;
						if (191533 - 7583 == 183950)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600759F RID: 30111 RVA: 0x00FCFCA4 File Offset: 0x00FCDEA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M206_GrandTheftMupo1.$ReturnToCamp$37922.$(this.$self_$37926);
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x00FCFCB4 File Offset: 0x00FCDEB4
		internal static bool FDH2mjpJASZa10VG5DpQ()
		{
			return true;
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x00FCFCB8 File Offset: 0x00FCDEB8
		internal static bool haD7h1pJlZaRPR6mSiwO()
		{
			return false;
		}

		// Token: 0x04007A33 RID: 31283
		internal M206_GrandTheftMupo1 $self_$37926;

		// Token: 0x020013E6 RID: 5094
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060075A2 RID: 30114 RVA: 0x00FCFCBC File Offset: 0x00FCDEBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M206_GrandTheftMupo1 self_)
			{
				if (208737 - 516642 != -307905)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (95068 - 59962 != 35107)
					{
						base..ctor();
						if (111779 - 34755 == 77024)
						{
							this.$self_$37925 = self_;
							if (90855 - 14643 == 76212)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060075A3 RID: 30115 RVA: 0x00FCFD54 File Offset: 0x00FCDF54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (34220 - 481518 != -447297)
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
						this.$self_$37925.LeaveGame();
						if (70064 - 261958 != -191894)
						{
							continue;
						}
						this.YieldDefault(1);
						if (241098 - 434650 != -193552)
						{
							continue;
						}
						goto IL_363;
					default:
						if (37531 - 379180 == -341648)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (31883 - 30293 == 1590)
					{
						Game.mStateTime = Time.time;
						if (228452 - 263538 == -35086)
						{
							this.$$switch$6500$37923 = PlayerData.SaveGuild;
							if (178261 - 475676 != -297414)
							{
								if (this.$$switch$6500$37923 == 1)
								{
									if (269801 - 338254 == -68452)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (19588 - 111594 != -92006)
									{
										continue;
									}
								}
								else if (this.$$switch$6500$37923 == 2)
								{
									if (210399 - 57511 == 152889)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (110079 - 437757 != -327678)
									{
										continue;
									}
								}
								else if (this.$$switch$6500$37923 == 3)
								{
									if (214413 - 341102 != -126689)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (17065 - 8188 == 8878)
									{
										continue;
									}
								}
								else if (this.$$switch$6500$37923 == 4)
								{
									if (68906 - 176581 != -107675)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (4169 - 220348 != -216179)
									{
										continue;
									}
								}
								else if (this.$$switch$6500$37923 == 5)
								{
									if (163723 - 596815 != -433092)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (215239 - 346325 != -131086)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (95152 - 431892 == -336739)
									{
										continue;
									}
								}
								this.$mGameGui$37924 = (GameGui)this.$self_$37925.GetComponent(typeof(GameGui));
								if (128377 - 409342 != -280964)
								{
									if (this.$mGameGui$37924)
									{
										if (293871 - 573141 == -279269)
										{
											continue;
										}
										this.$mGameGui$37924.close();
										if (181839 - 172998 == 8842)
										{
											continue;
										}
									}
									this.$self_$37925.SendMessage("fadeOut");
									if (193643 - 238452 == -44809)
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

			// Token: 0x060075A4 RID: 30116 RVA: 0x00FD00D8 File Offset: 0x00FCE2D8
			internal static bool WqpHq6pJy8kG8Ua0Djof()
			{
				return true;
			}

			// Token: 0x060075A5 RID: 30117 RVA: 0x00FD00DC File Offset: 0x00FCE2DC
			internal static bool kWn2TOpJSUBWlgcWXBoO()
			{
				return false;
			}

			// Token: 0x04007A34 RID: 31284
			internal int $$switch$6500$37923;

			// Token: 0x04007A35 RID: 31285
			internal GameGui $mGameGui$37924;

			// Token: 0x04007A36 RID: 31286
			internal M206_GrandTheftMupo1 $self_$37925;
		}
	}
}
