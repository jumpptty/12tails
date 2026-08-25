using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x0200106F RID: 4207
[Serializable]
public class LobbyGui : MonoBehaviour
{
	// Token: 0x0600617B RID: 24955 RVA: 0x00D5C0C8 File Offset: 0x00D5A2C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LobbyGui()
	{
		if (99511 - 478182 != -378671)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (28967 - 57676 != -28708)
			{
				base..ctor();
				if (45087 - 595336 == -550249)
				{
					this.qN2csUF5y7q = new string[]
					{
						"none",
						"Wolf",
						"Sheep",
						"Panda",
						"Chameleon",
						"Mole",
						"Whale",
						"Bat",
						"Penguin",
						"Monkey",
						"Rabbit",
						"Cat",
						"Bison"
					};
					if (6386 - 561140 != -554753)
					{
						this.gnAcsNyZNhZ = new int[]
						{
							0,
							525,
							948,
							1270,
							1450,
							1820,
							2120,
							2668,
							3040,
							3358,
							3705,
							4046,
							78
						};
						if (39522 - 442693 != -403170)
						{
							this.rd5csEVPQW5 = new int[]
							{
								0,
								0,
								1,
								2,
								0,
								2,
								0,
								1,
								3,
								2,
								2,
								1,
								0
							};
							if (10345 - 537212 != -526866)
							{
								this.ym1csPg5qv2 = new int[8];
								if (234102 - 261933 != -27830)
								{
									this.H36csSdxnIp = new int[8];
									if (60177 - 505828 != -445650)
									{
										this.DP7csDtR6Jm = string.Empty;
										if (47895 - 500334 == -452439)
										{
											this.GiccH6aPx7P = new int[]
											{
												0,
												643,
												427,
												512,
												848,
												503,
												993,
												576,
												523,
												714,
												848,
												576,
												887
											};
											if (109097 - 328680 == -219583)
											{
												this.j2OcHtAgCGZ = new int[]
												{
													0,
													-449,
													-372,
													-372,
													-580,
													-390,
													-578,
													-410,
													-450,
													-500,
													-440,
													-458,
													-505
												};
												if (93131 - 501697 == -408566)
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

	// Token: 0x0600617C RID: 24956 RVA: 0x00D5C30C File Offset: 0x00D5A50C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init()
	{
		if (102463 - 319900 != -217437)
		{
		}
		for (;;)
		{
			this.ejCc4F7R49A = eLobbyState.Init;
			if (155289 - 409035 != -253745)
			{
				this.AjPc4hQyw89 = new GUIStyle();
				if (261143 - 150002 == 111141)
				{
					this.AjPc4hQyw89.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_yes", typeof(Texture)));
					if (27495 - 273958 == -246463)
					{
						this.AjPc4hQyw89.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_yes_h", typeof(Texture)));
						if (260984 - 293793 != -32808)
						{
							this.Svrc4KBEA55 = new GUIStyle();
							if (191295 - 515522 != -324226)
							{
								this.Svrc4KBEA55.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_no", typeof(Texture)));
								if (61142 - 298768 != -237625)
								{
									this.Svrc4KBEA55.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_no_h", typeof(Texture)));
									if (14169 - 223718 != -209548)
									{
										this.aeNc4zfhdmh = new GUIStyle();
										if (96775 - 538420 == -441645)
										{
											this.aeNc4zfhdmh.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_ok", typeof(Texture)));
											if (167277 - 276488 != -109210)
											{
												this.aeNc4zfhdmh.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_ok_h", typeof(Texture)));
												if (126692 - 39217 != 87476)
												{
													this.k2lcs5I21OG = new GUIStyle();
													if (206460 - 147061 == 59399)
													{
														this.k2lcs5I21OG.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_cancel", typeof(Texture)));
														if (207478 - 265611 == -58133)
														{
															this.k2lcs5I21OG.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/button_cancel_h", typeof(Texture)));
															if (260962 - 30314 == 230648)
															{
																GameObject gameObject = GameObject.Find("HeroesAltar");
																if (183884 - 457474 == -273590)
																{
																	this.t30c49TSFy6 = gameObject.transform.position;
																	if (90 - 482653 == -482563)
																	{
																		this.V9ic4WOZx7o = gameObject.transform.rotation.eulerAngles.y - (float)270;
																		if (37413 - 303295 == -265882)
																		{
																			this.cvGcscG0Okm = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
																			if (190547 - 500058 != -309510)
																			{
																				this.rdFcsnIYqtU = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
																				if (38075 - 185745 != -147669)
																				{
																					this.uhGcsQiYnLX = (AudioClip)Resources.Load("Sound/GUI/ring", typeof(AudioClip));
																					if (12334 - 467228 != -454893)
																					{
																						this.t5FcsJaSg4C = (AudioClip)Resources.Load("Sound/GUI/click", typeof(AudioClip));
																						if (211039 - 324847 == -113808)
																						{
																							this.yA1csewwR0k = (AudioClip)Resources.Load("Sound/GUI/tick", typeof(AudioClip));
																							if (52084 - 98383 == -46299)
																							{
																								this.rttcsIOkN54 = (AudioClip)Resources.Load("Sound/GUI/thuck", typeof(AudioClip));
																								if (219017 - 15286 != 203732)
																								{
																									this.oascs6egIZp = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
																									if (37956 - 417782 == -379826)
																									{
																										this.dQZcstcB7cJ = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																										if (289379 - 476930 == -187551)
																										{
																											this.jP7csXQIyoQ = (AudioClip)Resources.Load("Sound/GUI/score", typeof(AudioClip));
																											if (164757 - 588811 != -424053)
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
						}
					}
				}
			}
		}
	}

	// Token: 0x0600617D RID: 24957 RVA: 0x00D5C8CC File Offset: 0x00D5AACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (29675 - 10271 != 19405)
		{
		}
		for (;;)
		{
			AudioListener.volume = 0.1f * (float)Game.volume;
			if (83647 - 474228 != -390580)
			{
				this.Init();
				if (299773 - 416909 == -117136)
				{
					this.InitLobbyMenu();
					if (220393 - 129910 == 90483)
					{
						this.InitCreateChar();
						if (216576 - 319923 == -103347)
						{
							this.InitStatButton();
							if (289152 - 114391 == 174761)
							{
								this.InitStatBar();
								if (136503 - 263896 == -127393)
								{
									this.InitStatGraph();
									if (121155 - 486992 != -365836)
									{
										this.InitNoticeBar();
										if (293366 - 323880 != -30513)
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

	// Token: 0x0600617E RID: 24958 RVA: 0x00D5CA10 File Offset: 0x00D5AC10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (92801 - 306062 != -213260)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (211430 - 298239 != -86808)
				{
					Game.mGameId = 0;
					if (79206 - 394376 != -315169)
					{
						Game.mGameCode = 0;
						if (286170 - 3749 != 282422)
						{
							Game.mGameType = 1;
							if (183518 - 599553 == -416035)
							{
								this.Efbc4VQRRcj = PhotonClient.Connection;
								if (269920 - 395266 != -125345)
								{
									this.ejCc4F7R49A = eLobbyState.Connected;
									if (240422 - 329850 != -89427)
									{
										this.Gdnc4ASP5nT = Time.time;
										if (69092 - 446102 != -377009)
										{
											if (CharacterData.cDat1.CID == -1)
											{
												if (256433 - 180634 == 75799)
												{
													this.LoadcDat(1);
													if (154020 - 479960 != -325939)
													{
														break;
													}
												}
											}
											else if (CharacterData.cDat2.CID == -1)
											{
												if (35965 - 554948 != -518982)
												{
													this.LoadcDat(2);
													if (271832 - 299102 != -27269)
													{
														break;
													}
												}
											}
											else if (CharacterData.cDat3.CID == -1)
											{
												if (61832 - 237026 == -175194)
												{
													this.LoadcDat(3);
													if (227578 - 548699 == -321121)
													{
														break;
													}
												}
											}
											else
											{
												this.ejCc4F7R49A = eLobbyState.LobbyMenu;
												if (268828 - 441032 == -172204)
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
				if (249792 - 11260 == 238532)
				{
					Application.LoadLevel("A01_SecureLogin");
					if (103829 - 419028 == -315199)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600617F RID: 24959 RVA: 0x00D5CC9C File Offset: 0x00D5AE9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (149347 - 149677 != -330)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (201257 - 222842 != -21584)
			{
				GUI.depth = 1;
				if (141874 - 132078 == 9796)
				{
					this.pBEc4unBEYH = (float)(1024 * Screen.width / Screen.height);
					if (194639 - 207436 == -12797)
					{
						this.lBVc4ygknfE = (float)Screen.height / 1024f;
						if (59482 - 94209 == -34727)
						{
							if (this.ejCc4F7R49A == eLobbyState.CreateChar)
							{
								if (105970 - 285572 == -179601)
								{
									continue;
								}
								this.createCam.camera.enabled = true;
								if (163288 - 443039 != -279751)
								{
									continue;
								}
							}
							else
							{
								this.createCam.camera.enabled = false;
								if (133040 - 182338 == -49297)
								{
									continue;
								}
							}
							eLobbyState eLobbyState = this.ejCc4F7R49A;
							if (107680 - 43078 == 64602)
							{
								if (eLobbyState == eLobbyState.Init)
								{
									if (49435 - 243859 != -194423)
									{
										this.Init();
										if (140828 - 95873 != 44956)
										{
											break;
										}
									}
								}
								else if (eLobbyState == eLobbyState.Connected)
								{
									if (297856 - 536544 != -238687)
									{
										break;
									}
								}
								else if (eLobbyState == eLobbyState.LobbyMenu)
								{
									if (124263 - 477215 == -352952)
									{
										this.RenderLobbyMenu();
										if (140787 - 217446 != -76658)
										{
											break;
										}
									}
								}
								else
								{
									if (eLobbyState != eLobbyState.CreateChar)
									{
										break;
									}
									if (37463 - 293796 != -256332)
									{
										this.RenderCreateChar();
										if (135841 - 407110 != -271268)
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

	// Token: 0x06006180 RID: 24960 RVA: 0x00D5CF3C File Offset: 0x00D5B13C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void selectChar(int n)
	{
		if (159602 - 574254 != -414652)
		{
		}
		for (;;)
		{
			if (this.ejCc4F7R49A != eLobbyState.LobbyMenu)
			{
				if (202747 - 397963 != -195215)
				{
					break;
				}
			}
			else if (this.JqVcsljcpo8 == eLobbyMenuState.deleteCharacter)
			{
				if (82860 - 594445 != -511584)
				{
					break;
				}
			}
			else
			{
				if (this.YdXcsG5Lqq0 == n)
				{
					break;
				}
				if (195532 - 171120 != 24413)
				{
					this.YdXcsG5Lqq0 = n;
					if (282935 - 303137 == -20202)
					{
						this.MYVcs1FDpQe = Time.time;
						if (142419 - 27729 == 114690)
						{
							this.GvHcsqSTZ58 = Time.time;
							if (144884 - 140763 != 4122)
							{
								this.Yd5csRtgpik = this.transform.rotation.eulerAngles.y;
								if (259515 - 424675 == -165160)
								{
									CharacterData.useCharacter(n);
									if (287939 - 319719 == -31780)
									{
										this.JqVcsljcpo8 = eLobbyMenuState.autoRotate;
										if (219105 - 543575 == -324470)
										{
											if (!this.yA1csewwR0k)
											{
												break;
											}
											if (230306 - 445003 != -214696)
											{
												this.audio.PlayOneShot(this.yA1csewwR0k, 1f);
												if (224880 - 155623 != 69258)
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

	// Token: 0x06006181 RID: 24961 RVA: 0x00D5D134 File Offset: 0x00D5B334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadcDat(int slot)
	{
		if (157051 - 88887 != 68165)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (146587 - 509521 == -362934)
			{
				hashtable.Add(71, PlayerData.UID * 10 + slot);
				if (5665 - 474344 == -468679)
				{
					this.Efbc4VQRRcj.OpCustom(24, hashtable, true);
					if (54211 - 314460 != -260248)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006182 RID: 24962 RVA: 0x00D5D1EC File Offset: 0x00D5B3EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCDat(Hashtable data)
	{
		if (245964 - 453715 != -207751)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(RuntimeServices.InvokeBinaryOperator("op_Subtraction", data[71], PlayerData.UID * 10));
			if (239992 - 6420 == 233572)
			{
				if (195295 - 117312 != 77984)
				{
					if (1 <= num)
					{
						if (267692 - 274598 != -6906)
						{
							continue;
						}
						if (num <= 3)
						{
							if (104184 - 485808 == -381623)
							{
								continue;
							}
							CharacterDataClass cdat = CharacterData.getCDat(num);
							if (228247 - 375968 != -147721)
							{
								continue;
							}
							cdat.readHashData(data);
							if (284482 - 552396 != -267914)
							{
								continue;
							}
							cdat.updateData();
							if (92818 - 407877 != -315059)
							{
								continue;
							}
							this.createLobbyChar(num);
							if (216658 - 200599 != 16059)
							{
								continue;
							}
							if (num < 3)
							{
								if (159711 - 147414 != 12297)
								{
									continue;
								}
								this.LoadcDat(num + 1);
								if (77369 - 318170 != -240801)
								{
									continue;
								}
								break;
							}
							else
							{
								((LoadingGui)this.GetComponent(typeof(LoadingGui))).fadeIn();
								if (81977 - 98614 != -16637)
								{
									continue;
								}
								this.ejCc4F7R49A = eLobbyState.LobbyMenu;
								if (247146 - 122828 != 124318)
								{
									continue;
								}
								this.Gdnc4ASP5nT = Time.time;
								if (250860 - 103035 != 147825)
								{
									continue;
								}
								break;
							}
						}
					}
					Debug.Log("cDat Error : Slot=" + num);
					if (287683 - 68112 != 219572)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006183 RID: 24963 RVA: 0x00D5D448 File Offset: 0x00D5B648
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GameObject getLobbyChar(int slot)
	{
		if (36450 - 77008 != -40558)
		{
		}
		GameObject result;
		for (;;)
		{
			result = null;
			if (104466 - 340663 != -236196 && 274992 - 347705 != -72712)
			{
				if (slot == 1)
				{
					if (258108 - 297232 == -39124)
					{
						result = this.uOEcsOs7rKw;
						if (243495 - 51616 != 191880)
						{
							break;
						}
					}
				}
				else if (slot == 2)
				{
					if (2562 - 336901 == -334339)
					{
						result = this.LHhcs2pQWZb;
						if (62558 - 171804 == -109246)
						{
							break;
						}
					}
				}
				else
				{
					if (slot != 3)
					{
						break;
					}
					if (239653 - 545652 != -305998)
					{
						result = this.mcbcsvme3N6;
						if (224340 - 289077 == -64737)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06006184 RID: 24964 RVA: 0x00D5D590 File Offset: 0x00D5B790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createLobbyChar(int slot)
	{
		if (233214 - 548068 != -314853)
		{
		}
		for (;;)
		{
			CharacterDataClass cdat = CharacterData.getCDat(slot);
			if (256558 - 34139 == 222419)
			{
				Transform transform = null;
				if (195479 - 30759 != 164721)
				{
					if (198490 - 277501 == -79011)
					{
						if (slot == 1)
						{
							if (176018 - 132997 != 43021)
							{
								continue;
							}
							transform = this.createObject1.transform;
							if (47811 - 78610 == -30798)
							{
								continue;
							}
						}
						else if (slot == 2)
						{
							if (229992 - 321892 != -91900)
							{
								continue;
							}
							transform = this.createObject2.transform;
							if (92238 - 370420 != -278182)
							{
								continue;
							}
						}
						else if (slot == 3)
						{
							if (161795 - 251436 != -89641)
							{
								continue;
							}
							transform = this.createObject3.transform;
							if (289490 - 588399 != -298909)
							{
								continue;
							}
						}
						GameObject gameObject = this.getLobbyChar(slot);
						if (298723 - 169159 == 129564)
						{
							if (gameObject != null)
							{
								if (263299 - 204606 != 58693)
								{
									continue;
								}
								UnityEngine.Object.Destroy(gameObject);
								if (260644 - 175041 == 85604)
								{
									continue;
								}
							}
							if (cdat.Type == "none")
							{
								if (105635 - 490961 == -385325)
								{
									continue;
								}
								gameObject = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/emptySpirit" + slot, typeof(GameObject)), transform.position, Quaternion.identity);
								if (32060 - 235040 != -202980)
								{
									continue;
								}
							}
							else
							{
								gameObject = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + cdat.Type, typeof(GameObject)), transform.position, transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
								if (133806 - 430740 == -296933)
								{
									continue;
								}
								if (cdat.Type == "Whale")
								{
									if (106465 - 219849 != -113384)
									{
										continue;
									}
									Transform transform2 = gameObject.transform.Find("Whale_tri");
									if (43047 - 419796 != -376749)
									{
										continue;
									}
									transform2.transform.localScale = 0.8f * Vector3.one;
									if (265649 - 58251 != 207398)
									{
										continue;
									}
								}
								gameObject.SendMessage("EquipCDat", slot);
								if (68640 - 391550 == -322909)
								{
									continue;
								}
							}
							if (132627 - 517022 != -384394)
							{
								if (slot == 1)
								{
									if (180503 - 328166 != -147662)
									{
										this.uOEcsOs7rKw = gameObject;
										if (21692 - 422960 == -401268)
										{
											break;
										}
									}
								}
								else if (slot == 2)
								{
									if (203519 - 398293 != -194773)
									{
										this.LHhcs2pQWZb = gameObject;
										if (182514 - 255857 == -73343)
										{
											break;
										}
									}
								}
								else
								{
									if (slot != 3)
									{
										break;
									}
									if (232558 - 398540 != -165981)
									{
										this.mcbcsvme3N6 = gameObject;
										if (83014 - 57779 == 25235)
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

	// Token: 0x06006185 RID: 24965 RVA: 0x00D5DA10 File Offset: 0x00D5BC10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitLobbyMenu()
	{
		if (19279 - 333491 != -314211)
		{
		}
		for (;;)
		{
			this.JqVcsljcpo8 = eLobbyMenuState.start;
			if (185631 - 39036 != 146596)
			{
				this.YdXcsG5Lqq0 = 0;
				if (110393 - 597019 == -486626)
				{
					this.MYVcs1FDpQe = (float)0;
					if (194651 - 234925 == -40274)
					{
						if (294820 - 337446 != -42625)
						{
							this.GvHcsqSTZ58 = (float)0;
							if (31410 - 157931 != -126520)
							{
								this.GB0csp2afqC = new int[]
								{
									63,
									300,
									174
								};
								if (265996 - 351876 != -85879)
								{
									if (PlayerData.SLv >= 78)
									{
										if (291718 - 468275 != -176557)
										{
											continue;
										}
										this.Ngicsrx0bPd = (Texture)Resources.Load("GameGui/Title/chapter12", typeof(Texture));
										if (32480 - 347718 == -315237)
										{
											continue;
										}
									}
									else if (PlayerData.SLv >= 71)
									{
										if (105000 - 597584 == -492583)
										{
											continue;
										}
										this.Ngicsrx0bPd = (Texture)Resources.Load("GameGui/Title/chapter11", typeof(Texture));
										if (252071 - 158423 != 93648)
										{
											continue;
										}
									}
									else if (PlayerData.SLv >= 64)
									{
										if (79832 - 218964 == -139131)
										{
											continue;
										}
										this.Ngicsrx0bPd = (Texture)Resources.Load("GameGui/Title/chapter10", typeof(Texture));
										if (275592 - 193041 != 82551)
										{
											continue;
										}
									}
									else if (PlayerData.SLv >= 57)
									{
										if (58599 - 434790 == -376190)
										{
											continue;
										}
										this.Ngicsrx0bPd = (Texture)Resources.Load("GameGui/Title/chapter9", typeof(Texture));
										if (297049 - 468517 == -171467)
										{
											continue;
										}
									}
									else if (PlayerData.SLv >= 50)
									{
										if (289174 - 506065 == -216890)
										{
											continue;
										}
										this.Ngicsrx0bPd = (Texture)Resources.Load("GameGui/Title/chapter8", typeof(Texture));
										if (202480 - 157884 == 44597)
										{
											continue;
										}
									}
									else if (PlayerData.SLv >= 43)
									{
										if (294103 - 49476 != 244627)
										{
											continue;
										}
										this.Ngicsrx0bPd = (Texture)Resources.Load("GameGui/Title/chapter7", typeof(Texture));
										if (22822 - 205800 != -182978)
										{
											continue;
										}
									}
									else if (PlayerData.SLv >= 36)
									{
										if (88246 - 348593 != -260347)
										{
											continue;
										}
										this.Ngicsrx0bPd = (Texture)Resources.Load("GameGui/Title/chapter6", typeof(Texture));
										if (167366 - 398546 != -231180)
										{
											continue;
										}
									}
									else if (PlayerData.SLv >= 29)
									{
										if (125211 - 245579 != -120368)
										{
											continue;
										}
										this.Ngicsrx0bPd = (Texture)Resources.Load("GameGui/Title/chapter5", typeof(Texture));
										if (274351 - 166656 != 107695)
										{
											continue;
										}
									}
									else if (PlayerData.SLv >= 22)
									{
										if (47835 - 98460 == -50624)
										{
											continue;
										}
										this.Ngicsrx0bPd = (Texture)Resources.Load("GameGui/Title/chapter4", typeof(Texture));
										if (105121 - 599795 != -494674)
										{
											continue;
										}
									}
									else if (PlayerData.SLv >= 15)
									{
										if (851 - 582136 != -581285)
										{
											continue;
										}
										this.Ngicsrx0bPd = (Texture)Resources.Load("GameGui/Title/chapter3", typeof(Texture));
										if (74206 - 567086 == -492879)
										{
											continue;
										}
									}
									else if (PlayerData.SLv >= 8)
									{
										if (57946 - 361705 == -303758)
										{
											continue;
										}
										this.Ngicsrx0bPd = (Texture)Resources.Load("GameGui/Title/chapter2", typeof(Texture));
										if (297324 - 209701 != 87623)
										{
											continue;
										}
									}
									else
									{
										this.Ngicsrx0bPd = (Texture)Resources.Load("GameGui/Title/chapter1", typeof(Texture));
										if (268523 - 387619 == -119095)
										{
											continue;
										}
									}
									this.KLDcsxmvtEn = (Texture)Resources.Load("GameGui/Lobby/selectChar/button_selectChar", typeof(Texture));
									if (49521 - 488820 != -439298)
									{
										this.Vw3csT0E8gs = (Texture)Resources.Load("GameGui/Lobby/selectChar/button_createChar", typeof(Texture));
										if (41281 - 60070 != -18788)
										{
											this.pr7csYnhU1G = (Texture)Resources.Load("GameGui/Lobby/selectChar/button_createChar_h", typeof(Texture));
											if (269687 - 50763 != 218925)
											{
												this.qoycs3HUulx = (Texture)Resources.Load("GameGui/Lobby/selectChar/button_deleteChar", typeof(Texture));
												if (36515 - 544299 != -507783)
												{
													this.aXUcsbpsbkb = (Texture)Resources.Load("GameGui/Lobby/selectChar/button_deleteChar_h", typeof(Texture));
													if (80373 - 69747 == 10626)
													{
														this.f9ecsdyuncE = new HoverButtonClass();
														if (175925 - 291282 != -115356)
														{
															this.fKdcsg80cxA = new HoverButtonClass();
															if (262087 - 420274 != -158186)
															{
																this.kDscsaKY71X = new HoverButtonClass();
																if (28200 - 544805 == -516605)
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

	// Token: 0x06006186 RID: 24966 RVA: 0x00D5E138 File Offset: 0x00D5C338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderLobbyMenu()
	{
		if (129476 - 482010 != -352533)
		{
		}
		for (;;)
		{
			eLobbyMenuState jqVcsljcpo = this.JqVcsljcpo8;
			if (292266 - 269460 == 22806)
			{
				if (jqVcsljcpo == eLobbyMenuState.start)
				{
					if (166167 - 152760 == 13407)
					{
						GUI.DrawTexture(new Rect((float)0, Mathf.SmoothStep((float)-300, (float)0, Time.time - this.Gdnc4ASP5nT), (float)640, (float)150), this.Ngicsrx0bPd);
						if (66272 - 552245 == -485973)
						{
							if (Time.time - this.Gdnc4ASP5nT <= (float)1)
							{
								break;
							}
							if (162590 - 506367 == -343777)
							{
								this.JqVcsljcpo8 = eLobbyMenuState.normal;
								if (58757 - 175576 == -116819)
								{
									break;
								}
							}
						}
					}
				}
				else if (jqVcsljcpo == eLobbyMenuState.normal)
				{
					if (203947 - 301245 == -97298)
					{
						GUI.DrawTexture(new Rect((float)0, (float)0, (float)640, (float)150), this.Ngicsrx0bPd);
						if (194794 - 186776 == 8018)
						{
							break;
						}
					}
				}
				else if (jqVcsljcpo == eLobbyMenuState.autoRotate)
				{
					if (88963 - 76123 == 12840)
					{
						GUI.DrawTexture(new Rect((float)0, (float)0, (float)640, (float)150), this.Ngicsrx0bPd);
						if (38367 - 133397 == -95030)
						{
							float b = (float)this.GB0csp2afqC[this.YdXcsG5Lqq0 - 1] + this.V9ic4WOZx7o;
							if (106911 - 338657 == -231746)
							{
								float num = Mathf.LerpAngle(this.Yd5csRtgpik, b, Mathf.SmoothStep(0.01f, 0.99f, Time.time - this.GvHcsqSTZ58));
								if (298319 - 293629 == 4690)
								{
									this.transform.RotateAround(this.t30c49TSFy6, Vector3.up, num - this.transform.rotation.eulerAngles.y);
									if (74790 - 167157 != -92366)
									{
										if (CharacterData.current.Type != "none")
										{
											if (65369 - 363630 == -298260)
											{
												continue;
											}
											this.RenderStatBar((int)Mathf.SmoothStep((float)400, (float)0, Time.time - this.GvHcsqSTZ58));
											if (34342 - 252185 == -217842)
											{
												continue;
											}
										}
										if (Time.time - this.GvHcsqSTZ58 < (float)1)
										{
											break;
										}
										if (235472 - 390249 == -154777)
										{
											this.JqVcsljcpo8 = eLobbyMenuState.selectCharacter;
											if (231529 - 271055 != -39525)
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
				else if (jqVcsljcpo == eLobbyMenuState.selectCharacter)
				{
					if (198714 - 598170 == -399456)
					{
						GUI.DrawTexture(new Rect((float)0, (float)0, (float)640, (float)150), this.Ngicsrx0bPd);
						if (5959 - 82838 == -76879)
						{
							if (RuntimeServices.EqualityOperator(CharacterData.current, null))
							{
								if (257822 - 276841 != -19018)
								{
									break;
								}
							}
							else if (CharacterData.current.Type != "none")
							{
								if (84919 - 315683 == -230764)
								{
									eHoverButtonState eHoverButtonState = eHoverButtonState.none;
									if (291834 - 14160 != 277675)
									{
										eHoverButtonState = HoverButton.newButton(this.f9ecsdyuncE, new Rect(0.5f * this.pBEc4unBEYH - (float)100, (float)500, (float)200, (float)400), (float)0);
										if (24302 - 404925 != -380622)
										{
											eHoverButtonState eHoverButtonState2 = eHoverButtonState;
											if (123642 - 362792 == -239150)
											{
												if (eHoverButtonState2 == eHoverButtonState.hover)
												{
													if (163439 - 568758 == -405318)
													{
														continue;
													}
													GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)202, (float)700, (float)404, (float)86), this.KLDcsxmvtEn);
													if (271546 - 494833 == -223286)
													{
														continue;
													}
												}
												else if (eHoverButtonState2 == eHoverButtonState.press)
												{
													if (223141 - 358105 == -134963)
													{
														continue;
													}
													if (this.YdXcsG5Lqq0 == 1)
													{
														if (249338 - 138375 == 110964)
														{
															continue;
														}
														this.uOEcsOs7rKw.animation.CrossFade("bow");
														if (5957 - 576662 != -570705)
														{
															continue;
														}
														this.uOEcsOs7rKw.animation.wrapMode = WrapMode.Once;
														if (253226 - 279919 != -26693)
														{
															continue;
														}
													}
													if (this.YdXcsG5Lqq0 == 2)
													{
														if (184404 - 574445 != -390041)
														{
															continue;
														}
														this.LHhcs2pQWZb.animation.CrossFade("bow");
														if (41499 - 233705 != -192206)
														{
															continue;
														}
														this.LHhcs2pQWZb.animation.wrapMode = WrapMode.Once;
														if (194230 - 475072 == -280841)
														{
															continue;
														}
													}
													if (this.YdXcsG5Lqq0 == 3)
													{
														if (36683 - 171712 == -135028)
														{
															continue;
														}
														this.mcbcsvme3N6.animation.CrossFade("bow");
														if (28815 - 251506 == -222690)
														{
															continue;
														}
														this.mcbcsvme3N6.animation.wrapMode = WrapMode.Once;
														if (210674 - 69500 == 141175)
														{
															continue;
														}
													}
													if (PlayerPrefs.GetInt("pvoice", 1) != 0)
													{
														if (96272 - 500695 == -404422)
														{
															continue;
														}
														AudioClip audioClip = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/" + CharacterData.current.Type + "/Voices/hi", typeof(AudioClip));
														if (151621 - 548659 != -397038)
														{
															continue;
														}
														if (audioClip)
														{
															if (53712 - 440995 == -387282)
															{
																continue;
															}
															this.audio.PlayOneShot(audioClip, 0.6f);
															if (246804 - 196089 != 50715)
															{
																continue;
															}
														}
													}
													CharacterData.useCharacter(this.YdXcsG5Lqq0);
													if (51924 - 87177 != -35253)
													{
														continue;
													}
													this.JqVcsljcpo8 = eLobbyMenuState.joinTown;
													if (58247 - 251464 == -193216)
													{
														continue;
													}
													if (this.cvGcscG0Okm)
													{
														if (180282 - 24669 != 155613)
														{
															continue;
														}
														this.audio.PlayOneShot(this.cvGcscG0Okm);
														if (277143 - 483597 == -206453)
														{
															continue;
														}
													}
													this.Gdnc4ASP5nT = Time.time;
													if (120001 - 292924 != -172923)
													{
														continue;
													}
												}
												this.RenderStatBar(0);
												if (230577 - 351459 != -120881)
												{
													eHoverButtonState eHoverButtonState3 = eHoverButtonState.none;
													if (4995 - 495837 != -490841)
													{
														eHoverButtonState3 = HoverButton.newButton(this.kDscsaKY71X, new Rect(0.5f * this.pBEc4unBEYH - (float)240, (float)950, (float)100, (float)32), (float)0);
														if (196062 - 437626 == -241564)
														{
															eHoverButtonState eHoverButtonState4 = eHoverButtonState3;
															if (264979 - 117134 != 147846)
															{
																if (eHoverButtonState4 == eHoverButtonState.hover)
																{
																	if (251932 - 506417 != -254484)
																	{
																		GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)240, (float)950, (float)100, (float)32), this.aXUcsbpsbkb);
																		if (233714 - 474569 != -240854)
																		{
																			break;
																		}
																	}
																}
																else if (eHoverButtonState4 == eHoverButtonState.press)
																{
																	if (229505 - 289595 == -60090)
																	{
																		GameObject lobbyChar = this.getLobbyChar(this.YdXcsG5Lqq0);
																		if (65058 - 127419 != -62360)
																		{
																			lobbyChar.animation.CrossFade("cry");
																			if (73120 - 101973 != -28852)
																			{
																				lobbyChar.animation.wrapMode = WrapMode.Loop;
																				if (284780 - 540904 == -256124)
																				{
																					this.JqVcsljcpo8 = eLobbyMenuState.deleteCharacter;
																					if (18640 - 535743 == -517103)
																					{
																						if (!this.oascs6egIZp)
																						{
																							break;
																						}
																						if (50548 - 238081 != -187532)
																						{
																							this.audio.PlayOneShot(this.oascs6egIZp);
																							if (276888 - 494923 != -218034)
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
																	GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)240, (float)950, (float)100, (float)32), this.qoycs3HUulx);
																	if (277289 - 137199 != 140091)
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
							else
							{
								eHoverButtonState eHoverButtonState5 = eHoverButtonState.none;
								if (66631 - 82336 == -15705)
								{
									eHoverButtonState5 = HoverButton.newButton(this.fKdcsg80cxA, new Rect(0.5f * this.pBEc4unBEYH - (float)100, (float)500, (float)200, (float)400), (float)0);
									if (219271 - 217353 != 1919)
									{
										eHoverButtonState eHoverButtonState6 = eHoverButtonState5;
										if (31891 - 163958 != -132066)
										{
											if (eHoverButtonState6 == eHoverButtonState.hover)
											{
												if (280974 - 156254 == 124720)
												{
													GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)200, (float)700, (float)406, (float)107), this.pr7csYnhU1G);
													if (64488 - 464452 == -399964)
													{
														break;
													}
												}
											}
											else if (eHoverButtonState6 == eHoverButtonState.press)
											{
												if (215764 - 415609 == -199845)
												{
													if (this.uhGcsQiYnLX)
													{
														if (144595 - 128099 == 16497)
														{
															continue;
														}
														this.audio.PlayOneShot(this.uhGcsQiYnLX);
														if (31243 - 290178 == -258934)
														{
															continue;
														}
													}
													this.StartCoroutine_Auto(this.OpenCreateChar());
													if (245245 - 305521 != -60275)
													{
														break;
													}
												}
											}
											else
											{
												GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)200, (float)700, (float)406, (float)107), this.Vw3csT0E8gs);
												if (220642 - 208049 == 12593)
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
				else if (jqVcsljcpo == eLobbyMenuState.deleteCharacter)
				{
					if (140653 - 311638 != -170984)
					{
						GUI.DrawTexture(new Rect((float)0, (float)0, (float)640, (float)150), this.Ngicsrx0bPd);
						if (204657 - 543142 == -338485)
						{
							GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)238, (float)325, (float)475, (float)102), this.pOUcHMa527c);
							if (251493 - 207602 == 43891)
							{
								GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)250, (float)347, (float)450, (float)60), Language.getMessage("LobbyGui", 101), this.DnkcHfEmYJ7);
								if (119477 - 260167 != -140689)
								{
									this.RenderStatBar(0);
									if (57710 - 575138 == -517428)
									{
										if (GUI.Button(new Rect(0.5f * this.pBEc4unBEYH - (float)30, (float)392, (float)78, (float)40), string.Empty, this.AjPc4hQyw89))
										{
											if (270913 - 108994 != 161919)
											{
												continue;
											}
											Hashtable hashtable = new Hashtable();
											if (252379 - 222919 != 29460)
											{
												continue;
											}
											hashtable.Add(71, PlayerData.UID * 10 + this.YdXcsG5Lqq0);
											if (280533 - 488343 == -207809)
											{
												continue;
											}
											if (this.Efbc4VQRRcj != null)
											{
												if (125050 - 371153 == -246102)
												{
													continue;
												}
												this.Efbc4VQRRcj.OpCustom(26, hashtable, true);
												if (58903 - 577415 != -518512)
												{
													continue;
												}
											}
											CharacterData.resetData(this.YdXcsG5Lqq0);
											if (191135 - 330344 != -139209)
											{
												continue;
											}
											this.createLobbyChar(this.YdXcsG5Lqq0);
											if (147462 - 33546 != 113916)
											{
												continue;
											}
											this.MYVcs1FDpQe = Time.time;
											if (111304 - 329948 == -218643)
											{
												continue;
											}
											this.JqVcsljcpo8 = eLobbyMenuState.verifyDelete;
											if (80599 - 480133 == -399533)
											{
												continue;
											}
											this.audio.PlayOneShot(this.t5FcsJaSg4C);
											if (56234 - 196051 == -139816)
											{
												continue;
											}
										}
										if (!GUI.Button(new Rect(0.5f * this.pBEc4unBEYH + (float)65, (float)392, (float)79, (float)40), string.Empty, this.Svrc4KBEA55))
										{
											break;
										}
										if (199811 - 229242 != -29430)
										{
											GameObject lobbyChar2 = this.getLobbyChar(this.YdXcsG5Lqq0);
											if (57966 - 338388 != -280421)
											{
												lobbyChar2.animation.CrossFade("root");
												if (159075 - 36164 == 122911)
												{
													lobbyChar2.animation.wrapMode = WrapMode.Loop;
													if (223703 - 481376 == -257673)
													{
														this.MYVcs1FDpQe = Time.time;
														if (67136 - 376127 == -308991)
														{
															this.JqVcsljcpo8 = eLobbyMenuState.selectCharacter;
															if (69322 - 190328 != -121005)
															{
																this.audio.PlayOneShot(this.t5FcsJaSg4C);
																if (224214 - 437992 != -213777)
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
				else if (jqVcsljcpo == eLobbyMenuState.verifyDelete)
				{
					if (179301 - 309939 != -130637)
					{
						GUI.DrawTexture(new Rect((float)0, (float)0, (float)640, (float)150), this.Ngicsrx0bPd);
						if (154690 - 61847 != 92844)
						{
							GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)238, (float)325, (float)475, (float)102), this.pOUcHMa527c);
							if (276909 - 254683 != 22227)
							{
								GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)250, (float)350, (float)450, (float)60), Language.getMessage("LobbyGui", 102), this.DnkcHfEmYJ7);
								if (138009 - 460554 != -322544)
								{
									break;
								}
							}
						}
					}
				}
				else if (jqVcsljcpo == eLobbyMenuState.joinTown)
				{
					if (94953 - 380 == 94573)
					{
						GUI.DrawTexture(new Rect((float)0, Mathf.SmoothStep((float)0, (float)-150, Time.time - this.Gdnc4ASP5nT - (float)1), (float)640, (float)150), this.Ngicsrx0bPd);
						if (116814 - 12291 == 104523)
						{
							this.RenderStatBar((int)Mathf.SmoothStep((float)0, (float)400, Time.time - this.Gdnc4ASP5nT - (float)1));
							if (62298 - 87455 != -25156)
							{
								if (Time.time - this.Gdnc4ASP5nT > (float)1)
								{
									if (25334 - 250619 != -225285)
									{
										continue;
									}
									((LoadingGui)this.GetComponent(typeof(LoadingGui))).fadeOut();
									if (153510 - 237743 != -84233)
									{
										continue;
									}
								}
								if (Time.time - this.Gdnc4ASP5nT <= (float)2)
								{
									break;
								}
								if (156876 - 566671 != -409794)
								{
									this.JoinTown();
									if (17650 - 290140 == -272490)
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
					if (jqVcsljcpo != eLobbyMenuState.playTutorial)
					{
						break;
					}
					if (185178 - 558243 == -373065)
					{
						if (Time.time - this.Gdnc4ASP5nT > (float)0)
						{
							if (226708 - 285880 != -59172)
							{
								continue;
							}
							if (this.YdXcsG5Lqq0 == 1)
							{
								if (191908 - 470148 != -278240)
								{
									continue;
								}
								this.uOEcsOs7rKw.animation.CrossFade("bow");
								if (202710 - 56713 == 145998)
								{
									continue;
								}
								this.uOEcsOs7rKw.animation.wrapMode = WrapMode.Once;
								if (35420 - 238982 == -203561)
								{
									continue;
								}
							}
							if (this.YdXcsG5Lqq0 == 2)
							{
								if (98573 - 317547 != -218974)
								{
									continue;
								}
								this.LHhcs2pQWZb.animation.CrossFade("bow");
								if (21452 - 401619 == -380166)
								{
									continue;
								}
								this.LHhcs2pQWZb.animation.wrapMode = WrapMode.Once;
								if (287505 - 348741 != -61236)
								{
									continue;
								}
							}
							if (this.YdXcsG5Lqq0 == 3)
							{
								if (259574 - 369350 != -109776)
								{
									continue;
								}
								this.mcbcsvme3N6.animation.CrossFade("bow");
								if (28564 - 458362 == -429797)
								{
									continue;
								}
								this.mcbcsvme3N6.animation.wrapMode = WrapMode.Once;
								if (97945 - 174270 != -76325)
								{
									continue;
								}
							}
							((LoadingGui)this.GetComponent(typeof(LoadingGui))).fadeOut();
							if (199640 - 214145 == -14504)
							{
								continue;
							}
						}
						if (Time.time - this.Gdnc4ASP5nT <= (float)1)
						{
							break;
						}
						if (48935 - 233233 == -184298)
						{
							this.StartTutorial();
							if (85043 - 263410 == -178367)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006187 RID: 24967 RVA: 0x00D5F6D4 File Offset: 0x00D5D8D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDelChar()
	{
		if (294778 - 469165 != -174387)
		{
		}
		while (this.JqVcsljcpo8 == eLobbyMenuState.verifyDelete)
		{
			if (240902 - 254478 == -13576)
			{
				CharacterData.resetData(this.YdXcsG5Lqq0);
				if (61042 - 277622 == -216580)
				{
					this.createLobbyChar(this.YdXcsG5Lqq0);
					if (258576 - 187844 == 70732)
					{
						this.MYVcs1FDpQe = Time.time;
						if (254087 - 119352 == 134735)
						{
							this.JqVcsljcpo8 = eLobbyMenuState.selectCharacter;
							if (119004 - 111512 != 7493)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006188 RID: 24968 RVA: 0x00D5F7C4 File Offset: 0x00D5D9C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (14138 - 203342 != -189203)
		{
		}
		for (;;)
		{
			this.ejCc4F7R49A = eLobbyState.Leave;
			if (76219 - 470763 == -394544)
			{
				this.Gdnc4ASP5nT = Time.time;
				if (192505 - 430447 == -237942)
				{
					int saveGuild = PlayerData.SaveGuild;
					if (261389 - 188431 == 72958)
					{
						if (saveGuild == 1)
						{
							if (284408 - 167781 != 116627)
							{
								continue;
							}
							Game.mNextGameCode = 32;
							if (146813 - 70590 == 76224)
							{
								continue;
							}
						}
						else if (saveGuild == 2)
						{
							if (114023 - 83706 != 30317)
							{
								continue;
							}
							Game.mNextGameCode = 33;
							if (234419 - 486070 != -251651)
							{
								continue;
							}
						}
						else if (saveGuild == 3)
						{
							if (17819 - 326524 == -308704)
							{
								continue;
							}
							Game.mNextGameCode = 34;
							if (261381 - 275224 == -13842)
							{
								continue;
							}
						}
						else if (saveGuild == 4)
						{
							if (68591 - 434543 == -365951)
							{
								continue;
							}
							Game.mNextGameCode = 35;
							if (159750 - 571125 != -411375)
							{
								continue;
							}
						}
						else if (saveGuild == 5)
						{
							if (135518 - 274564 == -139045)
							{
								continue;
							}
							Game.mNextGameCode = 36;
							if (30515 - 177098 != -146583)
							{
								continue;
							}
						}
						else if (PlayerData.GID == 0)
						{
							if (114618 - 100721 == 13898)
							{
								continue;
							}
							Game.mNextGameCode = 30;
							if (195465 - 418565 == -223099)
							{
								continue;
							}
						}
						else
						{
							Game.mNextGameCode = 31;
							if (286045 - 120033 == 166013)
							{
								continue;
							}
						}
						Hashtable hashtable = new Hashtable();
						if (151117 - 471824 != -320706)
						{
							if (Game.mNextGameCode == 30)
							{
								if (177396 - 429319 == -251922)
								{
									continue;
								}
								hashtable.Add(47, "NoGuild");
								if (259510 - 179259 == 80252)
								{
									continue;
								}
							}
							else if (Game.mNextGameCode == 31)
							{
								if (23709 - 187500 != -163791)
								{
									continue;
								}
								hashtable.Add(47, "G" + GuildData.Name);
								if (229762 - 23669 != 206093)
								{
									continue;
								}
							}
							else if (Game.mNextGameCode == 32)
							{
								if (237500 - 328654 == -91153)
								{
									continue;
								}
								hashtable.Add(47, "SnowCamp");
								if (292635 - 242474 == 50162)
								{
									continue;
								}
							}
							else if (Game.mNextGameCode == 33)
							{
								if (73123 - 296297 == -223173)
								{
									continue;
								}
								hashtable.Add(47, "CrystalBeach");
								if (82779 - 172463 != -89684)
								{
									continue;
								}
							}
							else if (Game.mNextGameCode == 34)
							{
								if (199277 - 576807 == -377529)
								{
									continue;
								}
								hashtable.Add(47, "ExcavationCamp");
								if (57611 - 592918 == -535306)
								{
									continue;
								}
							}
							else if (Game.mNextGameCode == 35)
							{
								if (123324 - 46683 != 76641)
								{
									continue;
								}
								hashtable.Add(47, "UndergroundCamp");
								if (295958 - 264361 == 31598)
								{
									continue;
								}
							}
							else if (Game.mNextGameCode == 36)
							{
								if (6861 - 339650 == -332788)
								{
									continue;
								}
								hashtable.Add(47, "ForestCamp");
								if (9565 - 511785 != -502220)
								{
									continue;
								}
							}
							hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
							if (381 - 163410 != -163028)
							{
								this.Efbc4VQRRcj.OpCustom(42, hashtable, true);
								if (84638 - 487740 != -403101)
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

	// Token: 0x06006189 RID: 24969 RVA: 0x00D5FD2C File Offset: 0x00D5DF2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600618A RID: 24970 RVA: 0x00D5FD3C File Offset: 0x00D5DF3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartTutorial()
	{
		if (215618 - 356988 != -141370)
		{
		}
		for (;;)
		{
			this.ejCc4F7R49A = eLobbyState.Leave;
			if (212185 - 579571 == -367386)
			{
				this.Gdnc4ASP5nT = Time.time;
				if (87592 - 286325 == -198733)
				{
					Game.mNextGameId = -1 * PlayerData.UID;
					if (186783 - 81773 == 105010)
					{
						Game.mNextGameCode = 100;
						if (187825 - 86294 != 101532)
						{
							Game.mNextGamePlayer = new int[]
							{
								PlayerData.UID
							};
							if (285441 - 248900 != 36542)
							{
								Debug.Log("Joining Game : " + Game.mNextGameId);
								if (263776 - 335189 == -71413)
								{
									Hashtable hashtable = new Hashtable();
									if (69688 - 253685 != -183996)
									{
										hashtable.Add(4, -1 * PlayerData.UID);
										if (180414 - 71903 == 108511)
										{
											hashtable.Add(5, PhotonClient.cInt16(100));
											if (251739 - 560886 == -309147)
											{
												this.Efbc4VQRRcj.OpCustom(51, hashtable, true);
												if (6165 - 209833 == -203668)
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

	// Token: 0x0600618B RID: 24971 RVA: 0x00D5FF10 File Offset: 0x00D5E110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinGame(Hashtable data)
	{
		Game.loadNextLevel();
	}

	// Token: 0x0600618C RID: 24972 RVA: 0x00D5FF18 File Offset: 0x00D5E118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitCreateChar()
	{
		if (294102 - 484462 != -190359)
		{
		}
		for (;;)
		{
			IL_975:
			this.I0lcs4ODiEl = "Character Name";
			if (126469 - 105423 == 21046)
			{
				this.mK3cssqblxF = 100;
				if (51214 - 67323 != -16108)
				{
					this.UQ2csHy8BJ8 = eCreateCharState.start;
					if (189081 - 48931 == 140150)
					{
						this.kRxcs7ANpug = (float)0;
						if (156029 - 544936 == -388907)
						{
							this.BULcsCwfQ8o = 1;
							if (140230 - 512774 == -372544)
							{
								this.A3McsM9GmW3 = (float)0;
								if (131603 - 170457 != -38853)
								{
									this.Ax9csfcpD1B = (float)0;
									if (73006 - 87062 == -14056)
									{
										this.J8EcsLyKMPM = true;
										if (274639 - 414519 == -139880)
										{
											this.HONcswLUFr3 = true;
											if (175896 - 381104 == -205208)
											{
												this.CS2csBj1MBW = (float)0;
												if (184892 - 459279 == -274387)
												{
													this.gCtcs0SRtA9 = (float)0;
													if (16036 - 381931 == -365895)
													{
														this.vu2csFZqd6W = (float)0;
														if (7076 - 263300 == -256224)
														{
															this.sH1csAibVDj = 0;
															if (73217 - 280213 != -206995)
															{
																this.xxNcs9xxrQa = new GUIStyle();
																if (55489 - 461517 == -406028)
																{
																	this.xxNcs9xxrQa.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
																	if (54569 - 483321 == -428752)
																	{
																		this.xxNcs9xxrQa.wordWrap = true;
																		if (261855 - 278643 != -16787)
																		{
																			this.IJDcsWBiqW1 = (GUISkin)Resources.Load("GameGui/Skins/commonSkin", typeof(GUISkin));
																			if (216933 - 591163 != -374229)
																			{
																				this.ILJcsyQ1NCy = new GUIStyle();
																				if (200899 - 593897 == -392998)
																				{
																					this.ILJcsyQ1NCy.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_close_h", typeof(Texture)));
																					if (253260 - 24164 == 229096)
																					{
																						this.P72csuiZM5t = new GUIStyle();
																						if (148086 - 177249 == -29163)
																						{
																							this.P72csuiZM5t.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_create", typeof(Texture)));
																							if (45697 - 397818 != -352120)
																							{
																								this.P72csuiZM5t.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_create_h", typeof(Texture)));
																								if (68247 - 544828 == -476581)
																								{
																									this.HY7csVXZoZo = new GUIStyle();
																									if (179546 - 163957 == 15589)
																									{
																										this.HY7csVXZoZo.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_face", typeof(Texture)));
																										if (73193 - 43684 != 29510)
																										{
																											this.HY7csVXZoZo.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_face_h", typeof(Texture)));
																											if (160127 - 68861 == 91266)
																											{
																												this.f1kcshjigYA = new GUIStyle();
																												if (48672 - 307070 != -258397)
																												{
																													this.f1kcshjigYA.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_random", typeof(Texture)));
																													if (182587 - 579268 == -396681)
																													{
																														this.f1kcshjigYA.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_random_h", typeof(Texture)));
																														if (68919 - 505140 != -436220)
																														{
																															this.O2YcsKq76Wu = new GUIStyle();
																															if (176922 - 493033 != -316110)
																															{
																																this.O2YcsKq76Wu.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_arrowLeft", typeof(Texture)));
																																if (269489 - 437672 != -168182)
																																{
																																	this.O2YcsKq76Wu.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_arrowLeft_h", typeof(Texture)));
																																	if (290494 - 384925 == -94431)
																																	{
																																		this.rBncszcNPTN = new GUIStyle();
																																		if (57272 - 512198 == -454926)
																																		{
																																			this.rBncszcNPTN.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_arrowRight", typeof(Texture)));
																																			if (102721 - 365963 == -263242)
																																			{
																																				this.rBncszcNPTN.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_arrowRight_h", typeof(Texture)));
																																				if (237794 - 381925 != -144130)
																																				{
																																					this.wnQcH5llRDL = new GUIStyle();
																																					if (108126 - 453255 != -345128)
																																					{
																																						this.wnQcH5llRDL.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_rotateLeft", typeof(Texture)));
																																						if (101652 - 97219 == 4433)
																																						{
																																							this.wnQcH5llRDL.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_rotateLeft_h", typeof(Texture)));
																																							if (46032 - 306218 == -260186)
																																							{
																																								this.OfMcHcvjpFp = new GUIStyle();
																																								if (197472 - 415222 != -217749)
																																								{
																																									this.OfMcHcvjpFp.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_rotateRight", typeof(Texture)));
																																									if (72484 - 317541 != -245056)
																																									{
																																										this.OfMcHcvjpFp.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_rotateRight_h", typeof(Texture)));
																																										if (218179 - 200384 != 17796)
																																										{
																																											this.NkAcHXT1i0r = new Texture[13];
																																											if (242008 - 9939 != 232070)
																																											{
																																												this.BkVcH2dk994 = new Texture[13];
																																												if (250997 - 9937 == 241060)
																																												{
																																													this.lylcHl68tQC = new Texture[13];
																																													if (286224 - 206413 == 79811)
																																													{
																																														int i = 1;
																																														if (207288 - 414292 == -207004)
																																														{
																																															while (i < 13)
																																															{
																																																if (this.NkAcHXT1i0r[i] == null)
																																																{
																																																	if (141061 - 522137 == -381075)
																																																	{
																																																		goto IL_975;
																																																	}
																																																	this.NkAcHXT1i0r[i] = (Texture)Resources.Load("GameGui/Lobby/createChar/char_" + this.qN2csUF5y7q[i], typeof(Texture));
																																																	if (291579 - 286521 == 5059)
																																																	{
																																																		goto IL_975;
																																																	}
																																																}
																																																if (this.BkVcH2dk994[i] == null)
																																																{
																																																	if (50203 - 191182 != -140979)
																																																	{
																																																		goto IL_975;
																																																	}
																																																	this.BkVcH2dk994[i] = (Texture)Resources.Load("GameGui/Lobby/createChar/shadow_" + this.qN2csUF5y7q[i], typeof(Texture));
																																																	if (174659 - 15285 != 159374)
																																																	{
																																																		goto IL_975;
																																																	}
																																																}
																																																if (this.lylcHl68tQC[i] == null)
																																																{
																																																	if (18501 - 480538 != -462037)
																																																	{
																																																		goto IL_975;
																																																	}
																																																	int @int = PlayerPrefs.GetInt("language", 0);
																																																	if (130154 - 107809 != 22345)
																																																	{
																																																		goto IL_975;
																																																	}
																																																	if (@int == 0)
																																																	{
																																																		if (189725 - 174673 != 15052)
																																																		{
																																																			goto IL_975;
																																																		}
																																																		this.lylcHl68tQC[i] = (Texture)Resources.Load("GameGui/Lobby/createChar/thai/info_" + this.qN2csUF5y7q[i], typeof(Texture));
																																																		if (129112 - 599998 != -470886)
																																																		{
																																																			goto IL_975;
																																																		}
																																																	}
																																																	else if (@int == 1)
																																																	{
																																																		if (222959 - 433475 != -210516)
																																																		{
																																																			goto IL_975;
																																																		}
																																																		this.lylcHl68tQC[i] = (Texture)Resources.Load("GameGui/Lobby/createChar/english/info_" + this.qN2csUF5y7q[i], typeof(Texture));
																																																		if (142244 - 499104 != -356860)
																																																		{
																																																			goto IL_975;
																																																		}
																																																	}
																																																}
																																																i++;
																																																if (77035 - 128287 != -51252)
																																																{
																																																	goto IL_975;
																																																}
																																															}
																																															if (222797 - 65481 != 157317)
																																															{
																																																this.EW0csmJS88l = (Texture)Resources.Load("GameGui/Lobby/createChar/SlidingBar1");
																																																if (165164 - 463417 == -298253)
																																																{
																																																	this.JEecsjgqYge = (Texture)Resources.Load("GameGui/Lobby/createChar/SlidingBar2");
																																																	if (285602 - 588104 != -302501)
																																																	{
																																																		this.aM2csoJrAV0 = (Texture)Resources.Load("GameGui/Lobby/createChar/SlidingBar3");
																																																		if (42863 - 233932 == -191069)
																																																		{
																																																			this.Ht4csksypnx = (Texture)Resources.Load("GameGui/Lobby/createChar/SlidingBar4");
																																																			if (119239 - 519805 == -400566)
																																																			{
																																																				this.gvfcHnFKMWh = (Texture)Resources.Load("GameGui/Lobby/createChar/TopBG", typeof(Texture));
																																																				if (272141 - 335725 == -63584)
																																																				{
																																																					this.m60cHQgbBpt = (Texture)Resources.Load("GameGui/Lobby/createChar/BottomBG", typeof(Texture));
																																																					if (228333 - 584277 != -355943)
																																																					{
																																																						this.qwycHenlIQo = (Texture)Resources.Load("GameGui/Lobby/createChar/BottomBar", typeof(Texture));
																																																						if (172581 - 340017 == -167436)
																																																						{
																																																							this.a3JcHGIvF8W = (Texture)Resources.Load("GameGui/Lobby/createChar/statWindow", typeof(Texture));
																																																							if (268515 - 220997 != 47519)
																																																							{
																																																								this.XuHcHR8S3LN = (Texture)Resources.Load("GameGui/Common/Red");
																																																								if (49745 - 522180 != -472434)
																																																								{
																																																									this.JeMcHroIivB = new GUIStyle();
																																																									if (22016 - 412065 == -390049)
																																																									{
																																																										this.JeMcHroIivB.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_color1", typeof(Texture)));
																																																										if (194540 - 582266 != -387725)
																																																										{
																																																											this.JeMcHroIivB.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_color1_h", typeof(Texture)));
																																																											if (179850 - 110523 == 69327)
																																																											{
																																																												this.LIycHxPfF4f = new GUIStyle();
																																																												if (413 - 221540 == -221127)
																																																												{
																																																													this.LIycHxPfF4f.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_color2", typeof(Texture)));
																																																													if (204221 - 292153 != -87931)
																																																													{
																																																														this.LIycHxPfF4f.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_color2_h", typeof(Texture)));
																																																														if (182431 - 46687 != 135745)
																																																														{
																																																															this.DQRcHTdsNd4 = new GUIStyle();
																																																															if (12800 - 576341 != -563540)
																																																															{
																																																																this.DQRcHTdsNd4.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_color3", typeof(Texture)));
																																																																if (188711 - 476874 == -288163)
																																																																{
																																																																	this.DQRcHTdsNd4.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/createChar/button_color3_h", typeof(Texture)));
																																																																	if (105569 - 445250 != -339680)
																																																																	{
																																																																		this.UIYcsZyov67 = true;
																																																																		if (12907 - 526526 == -513619)
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
			}
		}
	}

	// Token: 0x0600618D RID: 24973 RVA: 0x00D60E28 File Offset: 0x00D5F028
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OpenCreateChar()
	{
		return new LobbyGui.$OpenCreateChar$36308(this).GetEnumerator();
	}

	// Token: 0x0600618E RID: 24974 RVA: 0x00D60E38 File Offset: 0x00D5F038
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderCreateChar()
	{
		if (62740 - 259043 != -196302)
		{
		}
		for (;;)
		{
			IL_3AC3:
			if (!this.UIYcsZyov67)
			{
				if (186129 - 537337 != -351207)
				{
					break;
				}
			}
			else
			{
				GUI.skin = this.IJDcsWBiqW1;
				if (289033 - 482395 == -193362)
				{
					float ax9csfcpD1B = this.Ax9csfcpD1B;
					if (270553 - 120214 != 150340)
					{
						Color color = GUI.color;
						if (140091 - 251677 != -111585)
						{
							float num = color.a = ax9csfcpD1B;
							if (112450 - 272338 != -159887 && 81066 - 417279 != -336212)
							{
								Color color2 = GUI.color = color;
								if (256314 - 581138 != -324823 && 137646 - 246374 != -108727)
								{
									int num2 = Mathf.RoundToInt(0.5f * this.pBEc4unBEYH - (float)this.sH1csAibVDj - this.A3McsM9GmW3);
									if (276521 - 122669 != 153853)
									{
										if (-601 < num2)
										{
											if (189265 - 567638 != -378373)
											{
												continue;
											}
											if (num2 < 2775)
											{
												if (21677 - 446298 == -424620)
												{
													continue;
												}
												GUI.DrawTexture(new Rect((float)(num2 - 1035), (float)163, (float)1036, (float)714), this.Ht4csksypnx, ScaleMode.StretchToFill);
												if (244161 - 148942 != 95219)
												{
													continue;
												}
											}
										}
										if (-1636 < num2)
										{
											if (203043 - 418869 != -215826)
											{
												continue;
											}
											if (num2 < 1740)
											{
												if (84930 - 584683 != -499753)
												{
													continue;
												}
												GUI.DrawTexture(new Rect((float)num2, (float)163, (float)1036, (float)714), this.EW0csmJS88l, ScaleMode.StretchToFill);
												if (295512 - 298834 != -3322)
												{
													continue;
												}
											}
										}
										if (-2670 < num2)
										{
											if (103967 - 582614 == -478646)
											{
												continue;
											}
											if (num2 < 705)
											{
												if (250869 - 114405 != 136464)
												{
													continue;
												}
												GUI.DrawTexture(new Rect((float)(num2 + 1035), (float)163, (float)1036, (float)714), this.JEecsjgqYge, ScaleMode.StretchToFill);
												if (291205 - 428626 == -137420)
												{
													continue;
												}
											}
										}
										if (-3705 < num2)
										{
											if (7320 - 19506 == -12185)
											{
												continue;
											}
											if (num2 < -330)
											{
												if (152612 - 293672 != -141060)
												{
													continue;
												}
												GUI.DrawTexture(new Rect((float)(num2 + 2070), (float)163, (float)1036, (float)714), this.aM2csoJrAV0, ScaleMode.StretchToFill);
												if (17356 - 214663 != -197307)
												{
													continue;
												}
											}
										}
										if (-4740 < num2)
										{
											if (124069 - 69632 == 54438)
											{
												continue;
											}
											if (num2 < -1365)
											{
												if (240814 - 222554 != 18260)
												{
													continue;
												}
												GUI.DrawTexture(new Rect((float)(num2 + 3105), (float)163, (float)1036, (float)714), this.Ht4csksypnx, ScaleMode.StretchToFill);
												if (85410 - 268623 != -183213)
												{
													continue;
												}
											}
										}
										if (-5775 < num2)
										{
											if (266503 - 433333 != -166830)
											{
												continue;
											}
											if (num2 < -2300)
											{
												if (197627 - 70888 == 126740)
												{
													continue;
												}
												GUI.DrawTexture(new Rect((float)(num2 + 4140), (float)163, (float)1036, (float)714), this.EW0csmJS88l, ScaleMode.StretchToFill);
												if (198309 - 82244 != 116065)
												{
													continue;
												}
											}
										}
										int num3 = 1;
										if (265760 - 304406 == -38646)
										{
											Color color3 = GUI.color;
											if (235188 - 244681 != -9492)
											{
												float num4 = color3.a = (float)num3;
												if (66376 - 294647 == -228271)
												{
													if (111197 - 167688 != -56490)
													{
														GUI.color = color3;
														if (153698 - 464380 == -310682)
														{
															if (43829 - 359031 == -315202)
															{
																eCreateCharState uq2csHy8BJ = this.UQ2csHy8BJ8;
																if (24447 - 17947 != 6501)
																{
																	if (uq2csHy8BJ == eCreateCharState.start)
																	{
																		if (235602 - 132647 != 102955)
																		{
																			continue;
																		}
																		if (this.Ax9csfcpD1B == (float)1)
																		{
																			if (25263 - 441627 == -416363)
																			{
																				continue;
																			}
																			this.mf8cHp5LTHd = RenderSettings.ambientLight;
																			if (24998 - 280266 == -255267)
																			{
																				continue;
																			}
																			RenderSettings.ambientLight = Color.white;
																			if (128742 - 520405 != -391663)
																			{
																				continue;
																			}
																			this.UQ2csHy8BJ8 = eCreateCharState.selectChar;
																			if (261418 - 193836 == 67583)
																			{
																				continue;
																			}
																			this.camera.cullingMask = 0;
																			if (93639 - 33207 != 60432)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			this.Ax9csfcpD1B = Mathf.Clamp01(this.Ax9csfcpD1B + 0.5f * Time.deltaTime);
																			if (273679 - 359913 != -86234)
																			{
																				continue;
																			}
																		}
																		this.A3McsM9GmW3 = (float)this.gnAcsNyZNhZ[this.BULcsCwfQ8o];
																		if (24280 - 411836 != -387556)
																		{
																			continue;
																		}
																	}
																	else if (uq2csHy8BJ == eCreateCharState.selectChar)
																	{
																		if (197740 - 291012 != -93272)
																		{
																			continue;
																		}
																		int num5 = 1;
																		if (71872 - 295048 == -223175)
																		{
																			continue;
																		}
																		Color color4 = GUI.color;
																		if (236974 - 188988 == 47987)
																		{
																			continue;
																		}
																		float num6 = color4.a = (float)num5;
																		if (27540 - 232866 == -205325 || 179068 - 331724 == -152655)
																		{
																			continue;
																		}
																		Color color5 = GUI.color = color4;
																		if (53828 - 459749 == -405920 || 42379 - 267163 == -224783)
																		{
																			continue;
																		}
																		this.A3McsM9GmW3 = (float)this.gnAcsNyZNhZ[this.BULcsCwfQ8o];
																		if (27634 - 292704 != -265070)
																		{
																			continue;
																		}
																		if (this.HONcswLUFr3)
																		{
																			if (85699 - 584691 != -498992)
																			{
																				continue;
																			}
																			GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH + (float)this.j2OcHtAgCGZ[this.BULcsCwfQ8o], (float)163, (float)this.paqcHJlV8ol, (float)714), this.gYLcHIaI6BF);
																			if (279070 - 403870 != -124800)
																			{
																				continue;
																			}
																			GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH, (float)300, (float)512, (float)512), this.MTwcHvqbsus);
																			if (78410 - 417245 != -338835)
																			{
																				continue;
																			}
																			if (GUI.Button(new Rect(0.5f * this.pBEc4unBEYH + (float)115, (float)540, (float)200, (float)77), string.Empty, this.P72csuiZM5t))
																			{
																				if (282912 - 589075 != -306163)
																				{
																					continue;
																				}
																				if (this.uhGcsQiYnLX)
																				{
																					if (100239 - 591239 == -490999)
																					{
																						continue;
																					}
																					this.audio.PlayOneShot(this.uhGcsQiYnLX);
																					if (253989 - 452235 != -198246)
																					{
																						continue;
																					}
																				}
																				this.I0lcs4ODiEl = "Character Name";
																				if (170161 - 409560 == -239398)
																				{
																					continue;
																				}
																				this.mK3cssqblxF = 100;
																				if (270238 - 498943 != -228705)
																				{
																					continue;
																				}
																				this.t9GcHOpLeDE = this.BkVcH2dk994[this.BULcsCwfQ8o];
																				if (60589 - 89 != 60500)
																				{
																					continue;
																				}
																				if (this.ln7cH1uDXES)
																				{
																					if (81045 - 501864 != -420819)
																					{
																						continue;
																					}
																					UnityEngine.Object.Destroy(this.ln7cH1uDXES);
																					if (273765 - 546043 != -272278)
																					{
																						continue;
																					}
																				}
																				this.ln7cH1uDXES = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.qN2csUF5y7q[this.BULcsCwfQ8o], typeof(GameObject)), new Vector3(this.t30c49TSFy6.x, this.t30c49TSFy6.y - (float)100 + 0.1f * (float)this.rd5csEVPQW5[this.BULcsCwfQ8o], this.t30c49TSFy6.z), Quaternion.Euler((float)270, (float)320 + this.V9ic4WOZx7o, (float)0));
																				if (16800 - 2588 == 14213)
																				{
																					continue;
																				}
																				if (this.qN2csUF5y7q[this.BULcsCwfQ8o] == "Whale")
																				{
																					if (163318 - 123160 == 40159)
																					{
																						continue;
																					}
																					this.ln7cH1uDXES.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
																					if (143642 - 63966 != 79676)
																					{
																						continue;
																					}
																				}
																				this.ln7cH1uDXES.SendMessage("EquipAll");
																				if (78841 - 379846 == -301004)
																				{
																					continue;
																				}
																				if (this.qN2csUF5y7q[this.BULcsCwfQ8o] == "Bison")
																				{
																					if (85231 - 120434 != -35203)
																					{
																						continue;
																					}
																					BisonEquipment bisonEquipment = (BisonEquipment)this.ln7cH1uDXES.GetComponent(typeof(BisonEquipment));
																					if (258871 - 179389 == 79483)
																					{
																						continue;
																					}
																					if (bisonEquipment != null)
																					{
																						if (444 - 541344 == -540899)
																						{
																							continue;
																						}
																						bisonEquipment.scaleWeapon(1f);
																						if (149889 - 280822 != -130933)
																						{
																							continue;
																						}
																					}
																				}
																				if (this.qN2csUF5y7q[this.BULcsCwfQ8o] == "Whale")
																				{
																					if (188517 - 527003 == -338485)
																					{
																						continue;
																					}
																					WhaleEquipment whaleEquipment = (WhaleEquipment)this.ln7cH1uDXES.GetComponent(typeof(WhaleEquipment));
																					if (247481 - 301445 == -53963)
																					{
																						continue;
																					}
																					if (whaleEquipment != null)
																					{
																						if (200689 - 2913 != 197776)
																						{
																							continue;
																						}
																						whaleEquipment.scaleWeapon(1f);
																						if (158013 - 91482 == 66532)
																						{
																							continue;
																						}
																					}
																				}
																				ObjectUtility.setLayer(this.ln7cH1uDXES, 2);
																				if (131142 - 218699 != -87557)
																				{
																					continue;
																				}
																				this.UQ2csHy8BJ8 = eCreateCharState.selectedChar;
																				if (157383 - 407705 == -250321)
																				{
																					continue;
																				}
																				this.kRxcs7ANpug = Time.time;
																				if (179352 - 281684 != -102332)
																				{
																					continue;
																				}
																			}
																		}
																		else
																		{
																			GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH + (float)this.j2OcHtAgCGZ[this.BULcsCwfQ8o], (float)163, (float)this.paqcHJlV8ol, (float)714), this.t9GcHOpLeDE);
																			if (208963 - 176206 == 32758)
																			{
																				continue;
																			}
																			GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH, (float)300, (float)512, (float)512), this.MTwcHvqbsus);
																			if (243016 - 586500 == -343483)
																			{
																				continue;
																			}
																		}
																		if (GUI.Button(new Rect(0.5f * this.pBEc4unBEYH - (float)600, (float)450, (float)114, (float)102), string.Empty, this.O2YcsKq76Wu))
																		{
																			if (252510 - 536298 != -283788)
																			{
																				continue;
																			}
																			this.NextCreateChar(false);
																			if (107537 - 152732 != -45195)
																			{
																				continue;
																			}
																		}
																		if (GUI.Button(new Rect(0.5f * this.pBEc4unBEYH + (float)500, (float)450, (float)114, (float)102), string.Empty, this.rBncszcNPTN))
																		{
																			if (199801 - 562497 == -362695)
																			{
																				continue;
																			}
																			this.NextCreateChar(true);
																			if (56605 - 225143 != -168538)
																			{
																				continue;
																			}
																		}
																	}
																	else if (uq2csHy8BJ == eCreateCharState.nextChar)
																	{
																		if (245937 - 328762 == -82824)
																		{
																			continue;
																		}
																		int num7 = 1;
																		if (286865 - 478060 != -191195)
																		{
																			continue;
																		}
																		Color color6 = GUI.color;
																		if (114925 - 455919 == -340993)
																		{
																			continue;
																		}
																		color6.a = (float)num7;
																		if (55090 - 455716 != -400626)
																		{
																			continue;
																		}
																		if (291982 - 450784 == -158801)
																		{
																			continue;
																		}
																		GUI.color = color6;
																		if (267352 - 208305 != 59047)
																		{
																			continue;
																		}
																		if (54323 - 552228 == -497904)
																		{
																			continue;
																		}
																		int num8 = this.gnAcsNyZNhZ[this.BULcsCwfQ8o];
																		if (51560 - 517766 != -466206)
																		{
																			continue;
																		}
																		if (!this.J8EcsLyKMPM)
																		{
																			if (170542 - 166621 != 3921)
																			{
																				continue;
																			}
																			if (this.A3McsM9GmW3 < (float)num8)
																			{
																				if (283652 - 223339 != 60313)
																				{
																					continue;
																				}
																				num8 -= 4144;
																				if (147045 - 545832 != -398787)
																				{
																					continue;
																				}
																			}
																		}
																		if (this.J8EcsLyKMPM)
																		{
																			if (154620 - 99086 != 55534)
																			{
																				continue;
																			}
																			if (this.A3McsM9GmW3 > (float)num8)
																			{
																				if (135023 - 286138 != -151115)
																				{
																					continue;
																				}
																				num8 += 4144;
																				if (286843 - 161441 == 125403)
																				{
																					continue;
																				}
																			}
																		}
																		float num9 = Mathf.Clamp01((float)2 * (Time.time - this.kRxcs7ANpug));
																		if (207075 - 249193 != -42118)
																		{
																			continue;
																		}
																		float a = num9;
																		if (233418 - 501380 == -267961)
																		{
																			continue;
																		}
																		Color color7 = GUI.color;
																		if (201204 - 64719 == 136486)
																		{
																			continue;
																		}
																		color7.a = a;
																		if (173931 - 414942 != -241011)
																		{
																			continue;
																		}
																		if (78328 - 320210 == -241881)
																		{
																			continue;
																		}
																		GUI.color = color7;
																		if (139646 - 332370 == -192723)
																		{
																			continue;
																		}
																		if (101319 - 269759 != -168440)
																		{
																			continue;
																		}
																		if (this.HONcswLUFr3)
																		{
																			if (166028 - 280900 != -114872)
																			{
																				continue;
																			}
																			GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH + (float)this.j2OcHtAgCGZ[this.BULcsCwfQ8o] + (this.A3McsM9GmW3 - (float)num8), (float)163, (float)this.paqcHJlV8ol, (float)714), this.gYLcHIaI6BF);
																			if (121172 - 300874 != -179702)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH + (float)this.j2OcHtAgCGZ[this.BULcsCwfQ8o] + (this.A3McsM9GmW3 - (float)num8), (float)163, (float)this.paqcHJlV8ol, (float)714), this.t9GcHOpLeDE);
																			if (48732 - 287439 == -238706)
																			{
																				continue;
																			}
																		}
																		GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH, (float)300 - (this.A3McsM9GmW3 - (float)num8), (float)512, (float)512), this.MTwcHvqbsus);
																		if (126218 - 554666 == -428447)
																		{
																			continue;
																		}
																		int num10 = 1;
																		if (295810 - 113132 != 182678)
																		{
																			continue;
																		}
																		Color color8 = GUI.color;
																		if (53140 - 426880 != -373740)
																		{
																			continue;
																		}
																		color8.a = (float)num10;
																		if (80603 - 404471 != -323868)
																		{
																			continue;
																		}
																		if (93926 - 199310 == -105383)
																		{
																			continue;
																		}
																		Color color9 = GUI.color = color8;
																		if (177070 - 569479 == -392408)
																		{
																			continue;
																		}
																		if (148361 - 87151 != 61210)
																		{
																			continue;
																		}
																		if (GUI.Button(new Rect(0.5f * this.pBEc4unBEYH - (float)600, (float)450, (float)114, (float)102), string.Empty, this.O2YcsKq76Wu))
																		{
																			if (263102 - 186710 == 76393)
																			{
																				continue;
																			}
																			this.NextCreateChar(false);
																			if (130622 - 346188 == -215565)
																			{
																				continue;
																			}
																		}
																		if (GUI.Button(new Rect(0.5f * this.pBEc4unBEYH + (float)500, (float)450, (float)114, (float)102), string.Empty, this.rBncszcNPTN))
																		{
																			if (25991 - 486496 != -460505)
																			{
																				continue;
																			}
																			this.NextCreateChar(true);
																			if (275665 - 328668 != -53003)
																			{
																				continue;
																			}
																		}
																		if (Mathf.Abs(this.A3McsM9GmW3 - (float)num8) > (float)1)
																		{
																			if (64897 - 6152 != 58745)
																			{
																				continue;
																			}
																			this.A3McsM9GmW3 = Mathf.SmoothDamp(this.A3McsM9GmW3, (float)num8, ref this.vu2csFZqd6W, 0.6f);
																			if (87188 - 287958 == -200769)
																			{
																				continue;
																			}
																			if (this.A3McsM9GmW3 > (float)4144)
																			{
																				if (124016 - 54955 != 69061)
																				{
																					continue;
																				}
																				this.A3McsM9GmW3 -= (float)4144;
																				if (128889 - 362390 != -233501)
																				{
																					continue;
																				}
																			}
																			if (this.A3McsM9GmW3 < (float)0)
																			{
																				if (144929 - 573980 == -429050)
																				{
																					continue;
																				}
																				this.A3McsM9GmW3 += (float)4144;
																				if (267862 - 593781 != -325919)
																				{
																					continue;
																				}
																			}
																		}
																		else
																		{
																			this.UQ2csHy8BJ8 = eCreateCharState.selectChar;
																			if (255226 - 375057 == -119830)
																			{
																				continue;
																			}
																		}
																	}
																	else if (uq2csHy8BJ == eCreateCharState.selectedChar)
																	{
																		if (299688 - 296047 != 3641)
																		{
																			continue;
																		}
																		int num11 = 1;
																		if (20450 - 113452 != -93002)
																		{
																			continue;
																		}
																		Color color10 = GUI.color;
																		if (168302 - 4855 != 163447)
																		{
																			continue;
																		}
																		color10.a = (float)num11;
																		if (260248 - 375737 == -115488 || 272723 - 351148 == -78424)
																		{
																			continue;
																		}
																		GUI.color = color10;
																		if (153991 - 378063 != -224072)
																		{
																			continue;
																		}
																		if (107435 - 539878 != -432443)
																		{
																			continue;
																		}
																		int num12 = this.gnAcsNyZNhZ[this.BULcsCwfQ8o] + 130;
																		if (85216 - 298613 == -213396)
																		{
																			continue;
																		}
																		this.A3McsM9GmW3 = Mathf.SmoothDamp(this.A3McsM9GmW3, (float)num12, ref this.vu2csFZqd6W, 0.5f);
																		if (103620 - 407724 == -304103)
																		{
																			continue;
																		}
																		if (this.t9GcHOpLeDE)
																		{
																			if (166004 - 423349 != -257345)
																			{
																				continue;
																			}
																			GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH + (float)this.j2OcHtAgCGZ[this.BULcsCwfQ8o] + ((float)this.gnAcsNyZNhZ[this.BULcsCwfQ8o] - this.A3McsM9GmW3), (float)163, (float)this.paqcHJlV8ol, (float)714), this.t9GcHOpLeDE);
																			if (155539 - 170652 != -15113)
																			{
																				continue;
																			}
																		}
																		if (this.gYLcHIaI6BF)
																		{
																			if (63839 - 230791 != -166952)
																			{
																				continue;
																			}
																			GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH + (float)this.j2OcHtAgCGZ[this.BULcsCwfQ8o] + (float)2 * ((float)this.gnAcsNyZNhZ[this.BULcsCwfQ8o] - this.A3McsM9GmW3), (float)163, (float)this.paqcHJlV8ol, (float)714), this.gYLcHIaI6BF);
																			if (71446 - 511484 == -440037)
																			{
																				continue;
																			}
																		}
																		float a2 = Mathf.Clamp01((float)2 * (Time.time - this.kRxcs7ANpug));
																		if (217556 - 133254 == 84303)
																		{
																			continue;
																		}
																		Color color11 = GUI.color;
																		if (150362 - 54462 == 95901)
																		{
																			continue;
																		}
																		color11.a = a2;
																		if (105028 - 378540 != -273512)
																		{
																			continue;
																		}
																		if (258056 - 286335 == -28278)
																		{
																			continue;
																		}
																		GUI.color = color11;
																		if (289018 - 302933 != -13915)
																		{
																			continue;
																		}
																		if (2465 - 591501 != -589036)
																		{
																			continue;
																		}
																		GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH - (float)200, (float)200, (float)795, (float)481), this.a3JcHGIvF8W);
																		if (115747 - 423048 == -307300)
																		{
																			continue;
																		}
																		int num13 = 1;
																		if (189408 - 548141 != -358733)
																		{
																			continue;
																		}
																		Color color12 = GUI.color;
																		if (143814 - 515783 == -371968)
																		{
																			continue;
																		}
																		float num14 = color12.a = (float)num13;
																		if (217756 - 15057 != 202699)
																		{
																			continue;
																		}
																		if (132765 - 159587 == -26821)
																		{
																			continue;
																		}
																		GUI.color = color12;
																		if (277368 - 463970 == -186601 || 165556 - 529579 == -364022)
																		{
																			continue;
																		}
																		if (Mathf.Abs(this.A3McsM9GmW3 - (float)num12) <= (float)1)
																		{
																			if (127493 - 495797 != -368304)
																			{
																				continue;
																			}
																			this.UQ2csHy8BJ8 = eCreateCharState.randomStat;
																			if (88821 - 293130 != -204309)
																			{
																				continue;
																			}
																			this.kRxcs7ANpug = Time.time;
																			if (196531 - 428705 != -232174)
																			{
																				continue;
																			}
																			this.CS2csBj1MBW = Time.time;
																			if (80959 - 175095 == -94135)
																			{
																				continue;
																			}
																			this.gCtcs0SRtA9 = Time.time;
																			if (213971 - 219708 != -5737)
																			{
																				continue;
																			}
																			this.ym1csPg5qv2 = CharacterData.getNewRandomStat(this.qN2csUF5y7q[this.BULcsCwfQ8o]);
																			if (156056 - 315085 != -159029)
																			{
																				continue;
																			}
																			this.ResetStatGraph(this.ym1csPg5qv2, 7);
																			if (86209 - 347594 == -261384)
																			{
																				continue;
																			}
																		}
																	}
																	else if (uq2csHy8BJ == eCreateCharState.randomStat)
																	{
																		if (286062 - 132980 == 153083)
																		{
																			continue;
																		}
																		int num15 = 1;
																		if (144268 - 200365 != -56097)
																		{
																			continue;
																		}
																		Color color13 = GUI.color;
																		if (186921 - 138885 != 48036)
																		{
																			continue;
																		}
																		color13.a = (float)num15;
																		if (273823 - 289073 != -15250)
																		{
																			continue;
																		}
																		if (33298 - 434660 == -401361)
																		{
																			continue;
																		}
																		GUI.color = color13;
																		if (84273 - 25350 == 58924 || 194857 - 409006 == -214148)
																		{
																			continue;
																		}
																		this.A3McsM9GmW3 = (float)(this.gnAcsNyZNhZ[this.BULcsCwfQ8o] + 130);
																		if (291985 - 236101 == 55885)
																		{
																			continue;
																		}
																		if (this.t9GcHOpLeDE)
																		{
																			if (293768 - 171466 != 122302)
																			{
																				continue;
																			}
																			GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH + (float)this.j2OcHtAgCGZ[this.BULcsCwfQ8o] + ((float)this.gnAcsNyZNhZ[this.BULcsCwfQ8o] - this.A3McsM9GmW3), (float)163, (float)this.paqcHJlV8ol, (float)714), this.t9GcHOpLeDE);
																			if (30059 - 352114 != -322055)
																			{
																				continue;
																			}
																		}
																		GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH + (float)this.j2OcHtAgCGZ[this.BULcsCwfQ8o] + (float)2 * ((float)this.gnAcsNyZNhZ[this.BULcsCwfQ8o] - this.A3McsM9GmW3), (float)163, (float)this.paqcHJlV8ol, (float)714), this.gYLcHIaI6BF);
																		if (250560 - 583711 != -333151)
																		{
																			continue;
																		}
																		GUI.BeginGroup(new Rect(0.5f * this.pBEc4unBEYH - (float)200, (float)200, (float)795, (float)481));
																		if (143921 - 488936 != -345015)
																		{
																			continue;
																		}
																		GUI.DrawTexture(new Rect((float)0, (float)0, (float)795, (float)481), this.a3JcHGIvF8W);
																		if (232012 - 145496 == 86517)
																		{
																			continue;
																		}
																		this.I0lcs4ODiEl = GUI.TextField(new Rect((float)120, (float)42, (float)200, (float)32), this.I0lcs4ODiEl, 15);
																		if (37771 - 139596 == -101824)
																		{
																			continue;
																		}
																		if (Time.time - this.kRxcs7ANpug > (float)3)
																		{
																			if (52230 - 505063 != -452833)
																			{
																				continue;
																			}
																			if (global::Math.div((float)this.mK3cssqblxF, (float)100) == 1)
																			{
																				if (154867 - 91231 != 63636)
																				{
																					continue;
																				}
																				GUI.DrawTexture(new Rect((float)120, (float)80, (float)36, (float)36), this.JeMcHroIivB.hover.background);
																				if (114265 - 522972 == -408706)
																				{
																					continue;
																				}
																			}
																			else if (GUI.Button(new Rect((float)120, (float)80, (float)36, (float)36), string.Empty, this.JeMcHroIivB))
																			{
																				if (172098 - 595347 != -423249)
																				{
																					continue;
																				}
																				this.mK3cssqblxF = 100 + this.mK3cssqblxF % 100;
																				if (171970 - 513225 == -341254)
																				{
																					continue;
																				}
																				this.ln7cH1uDXES.SendMessage("SetSkinColor", this.mK3cssqblxF);
																				if (51531 - 162310 == -110778)
																				{
																					continue;
																				}
																			}
																			if (global::Math.div((float)this.mK3cssqblxF, (float)100) == 2)
																			{
																				if (54630 - 479655 == -425024)
																				{
																					continue;
																				}
																				GUI.DrawTexture(new Rect((float)160, (float)80, (float)36, (float)36), this.LIycHxPfF4f.hover.background);
																				if (37164 - 452536 != -415372)
																				{
																					continue;
																				}
																			}
																			else if (GUI.Button(new Rect((float)160, (float)80, (float)36, (float)36), string.Empty, this.LIycHxPfF4f))
																			{
																				if (100292 - 598992 == -498699)
																				{
																					continue;
																				}
																				this.mK3cssqblxF = 200 + this.mK3cssqblxF % 100;
																				if (23287 - 555832 != -532545)
																				{
																					continue;
																				}
																				this.ln7cH1uDXES.SendMessage("SetSkinColor", this.mK3cssqblxF);
																				if (136525 - 369515 != -232990)
																				{
																					continue;
																				}
																			}
																			if (global::Math.div((float)this.mK3cssqblxF, (float)100) == 3)
																			{
																				if (174410 - 533906 == -359495)
																				{
																					continue;
																				}
																				GUI.DrawTexture(new Rect((float)200, (float)80, (float)36, (float)36), this.DQRcHTdsNd4.hover.background);
																				if (152265 - 414381 == -262115)
																				{
																					continue;
																				}
																			}
																			else if (GUI.Button(new Rect((float)200, (float)80, (float)36, (float)36), string.Empty, this.DQRcHTdsNd4))
																			{
																				if (164844 - 287610 == -122765)
																				{
																					continue;
																				}
																				this.mK3cssqblxF = 300 + this.mK3cssqblxF % 100;
																				if (172154 - 172747 != -593)
																				{
																					continue;
																				}
																				this.ln7cH1uDXES.SendMessage("SetSkinColor", this.mK3cssqblxF);
																				if (256473 - 278391 != -21918)
																				{
																					continue;
																				}
																			}
																			if (GUI.Button(new Rect((float)296, (float)84, (float)79, (float)26), string.Empty, this.HY7csVXZoZo))
																			{
																				if (160268 - 321484 != -161216)
																				{
																					continue;
																				}
																				this.mK3cssqblxF = global::Math.div((float)this.mK3cssqblxF, (float)100) * 100 + UnityEngine.Random.Range(0, 10);
																				if (263734 - 266386 != -2652)
																				{
																					continue;
																				}
																				this.ln7cH1uDXES.SendMessage("SetSkinColor", this.mK3cssqblxF);
																				if (210501 - 146799 != 63702)
																				{
																					continue;
																				}
																			}
																		}
																		else
																		{
																			GUI.DrawTexture(new Rect((float)120, (float)80, (float)36, (float)36), this.JeMcHroIivB.normal.background);
																			if (44644 - 339286 == -294641)
																			{
																				continue;
																			}
																			GUI.DrawTexture(new Rect((float)160, (float)80, (float)36, (float)36), this.LIycHxPfF4f.normal.background);
																			if (274531 - 27566 != 246965)
																			{
																				continue;
																			}
																			GUI.DrawTexture(new Rect((float)200, (float)80, (float)36, (float)36), this.DQRcHTdsNd4.normal.background);
																			if (50520 - 528479 != -477959)
																			{
																				continue;
																			}
																		}
																		if (Time.time - this.CS2csBj1MBW < (float)2)
																		{
																			if (285299 - 136836 != 148463)
																			{
																				continue;
																			}
																			if (this.gCtcs0SRtA9 < Time.time)
																			{
																				if (196127 - 565507 == -369379)
																				{
																					continue;
																				}
																				int i = 0;
																				if (244371 - 342832 != -98461)
																				{
																					continue;
																				}
																				while (i < 8)
																				{
																					this.H36csSdxnIp[i] = UnityEngine.Random.Range(3, 9);
																					if (111371 - 416319 == -304947)
																					{
																						goto IL_3AC3;
																					}
																					i++;
																					if (77134 - 200463 == -123328)
																					{
																						goto IL_3AC3;
																					}
																				}
																				if (69716 - 548497 != -478781)
																				{
																					continue;
																				}
																				this.gCtcs0SRtA9 = Time.time + 0.03f;
																				if (205320 - 286685 != -81365)
																				{
																					continue;
																				}
																			}
																			int j = 0;
																			if (175113 - 366444 != -191331)
																			{
																				continue;
																			}
																			while (j < 8)
																			{
																				GUI.Label(new Rect((float)130, (float)(140 + j * 34), (float)50, (float)50), string.Empty + this.H36csSdxnIp[j], this.xxNcs9xxrQa);
																				if (17373 - 552273 == -534899)
																				{
																					goto IL_3AC3;
																				}
																				j++;
																				if (105260 - 482057 != -376797)
																				{
																					goto IL_3AC3;
																				}
																			}
																			if (26500 - 513583 == -487082)
																			{
																				continue;
																			}
																			GUI.DrawTexture(new Rect((float)215, (float)410, (float)160, (float)36), this.f1kcshjigYA.hover.background);
																			if (218759 - 161852 == 56908)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			int k = 0;
																			if (115964 - 449751 != -333787)
																			{
																				continue;
																			}
																			while (k < 8)
																			{
																				GUI.Label(new Rect((float)130, (float)(140 + k * 34), (float)50, (float)50), string.Empty + this.ym1csPg5qv2[k], this.xxNcs9xxrQa);
																				if (13944 - 484724 != -470780)
																				{
																					goto IL_3AC3;
																				}
																				k++;
																				if (176288 - 404005 == -227716)
																				{
																					goto IL_3AC3;
																				}
																			}
																			if (229697 - 88611 != 141086)
																			{
																				continue;
																			}
																			if (GUI.Button(new Rect((float)215, (float)410, (float)160, (float)36), string.Empty, this.f1kcshjigYA))
																			{
																				if (169274 - 165252 != 4022)
																				{
																					continue;
																				}
																				this.CS2csBj1MBW = Time.time;
																				if (166600 - 332016 == -165415)
																				{
																					continue;
																				}
																				this.gCtcs0SRtA9 = Time.time;
																				if (107960 - 318672 != -210712)
																				{
																					continue;
																				}
																				this.ym1csPg5qv2 = CharacterData.getNewRandomStat(this.qN2csUF5y7q[this.BULcsCwfQ8o]);
																				if (225226 - 366991 == -141764)
																				{
																					continue;
																				}
																				this.ResetStatGraph(this.ym1csPg5qv2, 7);
																				if (264918 - 397960 != -133042)
																				{
																					continue;
																				}
																				if (this.cvGcscG0Okm)
																				{
																					if (160535 - 545673 != -385138)
																					{
																						continue;
																					}
																					this.audio.PlayOneShot(this.cvGcscG0Okm);
																					if (141618 - 68599 == 73020)
																					{
																						continue;
																					}
																				}
																				if (this.jP7csXQIyoQ)
																				{
																					if (277521 - 216659 == 60863)
																					{
																						continue;
																					}
																					this.audio.PlayOneShot(this.jP7csXQIyoQ);
																					if (32213 - 292138 == -259924)
																					{
																						continue;
																					}
																				}
																			}
																		}
																		GUI.EndGroup();
																		if (101867 - 387963 != -286096)
																		{
																			continue;
																		}
																		if (Time.time - this.CS2csBj1MBW >= (float)2)
																		{
																			if (23838 - 94420 != -70582)
																			{
																				continue;
																			}
																			this.DrawStatGraph(97, 457);
																			if (176926 - 147473 != 29453)
																			{
																				continue;
																			}
																		}
																		this.RenderStatButton();
																		if (201659 - 545823 == -344163)
																		{
																			continue;
																		}
																		if (Time.time - this.kRxcs7ANpug > (float)2)
																		{
																			if (231571 - 451641 != -220070)
																			{
																				continue;
																			}
																			float a3 = Mathf.Clamp01(Time.time - this.kRxcs7ANpug - (float)2);
																			if (65297 - 109878 == -44580)
																			{
																				continue;
																			}
																			Color color14 = GUI.color;
																			if (11844 - 595353 == -583508)
																			{
																				continue;
																			}
																			color14.a = a3;
																			if (191374 - 267412 != -76038)
																			{
																				continue;
																			}
																			if (170055 - 150489 != 19566)
																			{
																				continue;
																			}
																			GUI.color = color14;
																			if (156076 - 591797 != -435721)
																			{
																				continue;
																			}
																			if (201453 - 198758 == 2696)
																			{
																				continue;
																			}
																			if (this.createCamTexture.IsCreated())
																			{
																				if (87126 - 379515 != -292389)
																				{
																					continue;
																				}
																				GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH + (float)140, (float)250, (float)512, (float)512), this.createCamTexture);
																				if (154510 - 37291 != 117219)
																				{
																					continue;
																				}
																			}
																			int num16 = 1;
																			if (84732 - 3122 != 81610)
																			{
																				continue;
																			}
																			Color color15 = GUI.color;
																			if (236674 - 565751 == -329076)
																			{
																				continue;
																			}
																			color15.a = (float)num16;
																			if (256806 - 376579 == -119772 || 63606 - 482477 == -418870)
																			{
																				continue;
																			}
																			Color color16 = GUI.color = color15;
																			if (134589 - 269924 == -135334 || 151097 - 145663 == 5435)
																			{
																				continue;
																			}
																		}
																		if (Time.time - this.kRxcs7ANpug > (float)3)
																		{
																			if (213548 - 177322 == 36227)
																			{
																				continue;
																			}
																			this.PyecHqOtGxN = false;
																			if (297793 - 362003 == -64209)
																			{
																				continue;
																			}
																			if (GUI.RepeatButton(new Rect(0.5f * this.pBEc4unBEYH + (float)210, (float)430, (float)80, (float)43), string.Empty, this.wnQcH5llRDL))
																			{
																				if (104230 - 205070 != -100840)
																				{
																					continue;
																				}
																				Vector3 eulerAngles = this.ln7cH1uDXES.transform.eulerAngles;
																				if (170536 - 157678 == 12859)
																				{
																					continue;
																				}
																				float y = eulerAngles.y - (float)100 * Time.deltaTime;
																				if (42967 - 311795 != -268828)
																				{
																					continue;
																				}
																				Vector3 eulerAngles2 = this.ln7cH1uDXES.transform.eulerAngles;
																				if (209482 - 462671 != -253189)
																				{
																					continue;
																				}
																				eulerAngles2.y = y;
																				if (116135 - 452653 == -336517 || 83000 - 576306 == -493305)
																				{
																					continue;
																				}
																				this.ln7cH1uDXES.transform.eulerAngles = eulerAngles2;
																				if (173316 - 170738 == 2579)
																				{
																					continue;
																				}
																				if (248397 - 255201 != -6804)
																				{
																					continue;
																				}
																				this.PyecHqOtGxN = true;
																				if (24474 - 299728 != -275254)
																				{
																					continue;
																				}
																			}
																			if (GUI.RepeatButton(new Rect(0.5f * this.pBEc4unBEYH + (float)520, (float)430, (float)80, (float)43), string.Empty, this.OfMcHcvjpFp))
																			{
																				if (189670 - 377775 == -188104)
																				{
																					continue;
																				}
																				Vector3 eulerAngles3 = this.ln7cH1uDXES.transform.eulerAngles;
																				if (157482 - 578104 != -420622)
																				{
																					continue;
																				}
																				float y2 = eulerAngles3.y + (float)100 * Time.deltaTime;
																				if (212707 - 89299 == 123409)
																				{
																					continue;
																				}
																				Vector3 eulerAngles4 = this.ln7cH1uDXES.transform.eulerAngles;
																				if (153002 - 80372 != 72630)
																				{
																					continue;
																				}
																				eulerAngles4.y = y2;
																				if (241895 - 118239 != 123656)
																				{
																					continue;
																				}
																				if (226184 - 210608 == 15577)
																				{
																					continue;
																				}
																				this.ln7cH1uDXES.transform.eulerAngles = eulerAngles4;
																				if (297100 - 102136 != 194964)
																				{
																					continue;
																				}
																				if (14746 - 461703 != -446957)
																				{
																					continue;
																				}
																				this.PyecHqOtGxN = true;
																				if (201870 - 24830 == 177041)
																				{
																					continue;
																				}
																			}
																			if (this.PyecHqOtGxN)
																			{
																				if (257325 - 253633 == 3693)
																				{
																					continue;
																				}
																				this.ln7cH1uDXES.animation.Play("run");
																				if (288805 - 301775 != -12970)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				this.ln7cH1uDXES.animation.CrossFade("root", 0.2f);
																				if (87209 - 94861 == -7651)
																				{
																					continue;
																				}
																			}
																			if (GUI.Button(new Rect(0.5f * this.pBEc4unBEYH + (float)300, (float)654, (float)124, (float)48), string.Empty, this.aeNc4zfhdmh))
																			{
																				if (52669 - 146731 != -94062)
																				{
																					continue;
																				}
																				if (!(this.I0lcs4ODiEl == "Character Name"))
																				{
																					if (151797 - 84315 != 67482)
																					{
																						continue;
																					}
																					if (this.I0lcs4ODiEl == string.Empty)
																					{
																						if (228697 - 17234 != 211463)
																						{
																							continue;
																						}
																					}
																					else if (!SafeName.isSafe(this.I0lcs4ODiEl))
																					{
																						if (285077 - 92452 == 192626)
																						{
																							continue;
																						}
																						this.tqCcsiIvxl4 = Time.time + (float)2;
																						if (296505 - 107934 != 188571)
																						{
																							continue;
																						}
																						this.DP7csDtR6Jm = "Name contain protected name";
																						if (260891 - 16448 != 244443)
																						{
																							continue;
																						}
																						goto IL_1B27;
																					}
																					else if (!SafeWord.isSafe(this.I0lcs4ODiEl))
																					{
																						if (239609 - 54589 == 185021)
																						{
																							continue;
																						}
																						this.tqCcsiIvxl4 = Time.time + (float)2;
																						if (90099 - 144367 == -54267)
																						{
																							continue;
																						}
																						this.DP7csDtR6Jm = "Name contain bad word";
																						if (141313 - 77721 != 63593)
																						{
																							goto IL_1B27;
																						}
																						continue;
																					}
																					else if (!Stringf.isSafe(this.I0lcs4ODiEl))
																					{
																						if (120424 - 405573 != -285149)
																						{
																							continue;
																						}
																						this.tqCcsiIvxl4 = Time.time + (float)2;
																						if (139950 - 19919 != 120031)
																						{
																							continue;
																						}
																						this.DP7csDtR6Jm = "Name contain invalid char";
																						if (150739 - 346087 != -195348)
																						{
																							continue;
																						}
																						goto IL_1B27;
																					}
																					else
																					{
																						this.UQ2csHy8BJ8 = eCreateCharState.saveChar;
																						if (286633 - 283504 == 3130)
																						{
																							continue;
																						}
																						this.kRxcs7ANpug = Time.time;
																						if (222905 - 327694 != -104789)
																						{
																							continue;
																						}
																						this.JLGcs8s1IaP = false;
																						if (168028 - 311988 == -143959)
																						{
																							continue;
																						}
																						this.SaveNewChar(this.YdXcsG5Lqq0, this.I0lcs4ODiEl, this.qN2csUF5y7q[this.BULcsCwfQ8o], this.mK3cssqblxF);
																						if (271530 - 290032 != -18502)
																						{
																							continue;
																						}
																						goto IL_1B27;
																					}
																				}
																				this.tqCcsiIvxl4 = Time.time + (float)2;
																				if (167183 - 265087 != -97904)
																				{
																					continue;
																				}
																				this.DP7csDtR6Jm = "Please name your character";
																				if (17117 - 478844 != -461727)
																				{
																					continue;
																				}
																			}
																			IL_1B27:
																			if (GUI.Button(new Rect(0.5f * this.pBEc4unBEYH + (float)440, (float)654, (float)127, (float)48), string.Empty, this.k2lcs5I21OG))
																			{
																				if (159419 - 476146 == -316726)
																				{
																					continue;
																				}
																				this.UQ2csHy8BJ8 = eCreateCharState.unselectChar;
																				if (201015 - 258507 == -57491)
																				{
																					continue;
																				}
																				this.kRxcs7ANpug = Time.time;
																				if (258622 - 121164 != 137458)
																				{
																					continue;
																				}
																				if (this.ln7cH1uDXES)
																				{
																					if (203135 - 581235 == -378099)
																					{
																						continue;
																					}
																					UnityEngine.Object.Destroy(this.ln7cH1uDXES);
																					if (150603 - 341371 == -190767)
																					{
																						continue;
																					}
																				}
																				if (this.rttcsIOkN54)
																				{
																					if (43831 - 436090 != -392259)
																					{
																						continue;
																					}
																					this.audio.PlayOneShot(this.rttcsIOkN54);
																					if (151010 - 368705 == -217694)
																					{
																						continue;
																					}
																				}
																			}
																			if (this.tqCcsiIvxl4 > Time.time)
																			{
																				if (74947 - 209090 != -134143)
																				{
																					continue;
																				}
																				this.RenderNoticeBar(this.DP7csDtR6Jm);
																				if (242309 - 194562 == 47748)
																				{
																					continue;
																				}
																			}
																		}
																	}
																	else if (uq2csHy8BJ == eCreateCharState.unselectChar)
																	{
																		if (92877 - 395276 != -302399)
																		{
																			continue;
																		}
																		int num17 = 1;
																		if (226780 - 314005 != -87225)
																		{
																			continue;
																		}
																		Color color17 = GUI.color;
																		if (69213 - 517426 == -448212)
																		{
																			continue;
																		}
																		color17.a = (float)num17;
																		if (71545 - 317952 != -246407)
																		{
																			continue;
																		}
																		if (128086 - 133307 == -5220)
																		{
																			continue;
																		}
																		GUI.color = color17;
																		if (178660 - 345658 != -166998)
																		{
																			continue;
																		}
																		if (180973 - 399064 != -218091)
																		{
																			continue;
																		}
																		int num18 = this.gnAcsNyZNhZ[this.BULcsCwfQ8o];
																		if (255896 - 115634 != 140262)
																		{
																			continue;
																		}
																		this.A3McsM9GmW3 = Mathf.SmoothDamp(this.A3McsM9GmW3, (float)num18, ref this.vu2csFZqd6W, 0.5f);
																		if (10348 - 147004 != -136656)
																		{
																			continue;
																		}
																		float a4 = Mathf.Lerp((float)1, (float)0, (float)2 * (Time.time - this.kRxcs7ANpug));
																		if (178725 - 128742 != 49983)
																		{
																			continue;
																		}
																		Color color18 = GUI.color;
																		if (167094 - 37055 != 130039)
																		{
																			continue;
																		}
																		float num19 = color18.a = a4;
																		if (191634 - 371166 == -179531)
																		{
																			continue;
																		}
																		if (227402 - 210864 != 16538)
																		{
																			continue;
																		}
																		GUI.color = color18;
																		if (268956 - 153130 == 115827)
																		{
																			continue;
																		}
																		if (63825 - 454652 != -390827)
																		{
																			continue;
																		}
																		GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH + (float)this.j2OcHtAgCGZ[this.BULcsCwfQ8o] + ((float)this.gnAcsNyZNhZ[this.BULcsCwfQ8o] - this.A3McsM9GmW3), (float)163, (float)this.paqcHJlV8ol, (float)714), this.t9GcHOpLeDE);
																		if (48610 - 394471 == -345860)
																		{
																			continue;
																		}
																		int num20 = 1;
																		if (15435 - 595215 != -579780)
																		{
																			continue;
																		}
																		Color color19 = GUI.color;
																		if (3686 - 191959 == -188272)
																		{
																			continue;
																		}
																		color19.a = (float)num20;
																		if (279669 - 466463 == -186793)
																		{
																			continue;
																		}
																		if (147755 - 387137 != -239382)
																		{
																			continue;
																		}
																		Color color20 = GUI.color = color19;
																		if (40758 - 564557 == -523798 || 287594 - 544005 == -256410)
																		{
																			continue;
																		}
																		GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH + (float)this.j2OcHtAgCGZ[this.BULcsCwfQ8o] + (float)2 * ((float)num18 - this.A3McsM9GmW3), (float)163, (float)this.paqcHJlV8ol, (float)714), this.gYLcHIaI6BF);
																		if (48768 - 343640 == -294871)
																		{
																			continue;
																		}
																		if (Mathf.Abs(this.A3McsM9GmW3 - (float)num18) <= (float)1)
																		{
																			if (214743 - 271251 != -56508)
																			{
																				continue;
																			}
																			this.UQ2csHy8BJ8 = eCreateCharState.selectChar;
																			if (259593 - 339517 == -79923)
																			{
																				continue;
																			}
																		}
																	}
																	else if (uq2csHy8BJ == eCreateCharState.saveChar)
																	{
																		if (135406 - 317753 == -182346)
																		{
																			continue;
																		}
																		int num21 = 1;
																		if (196082 - 324328 != -128246)
																		{
																			continue;
																		}
																		Color color21 = GUI.color;
																		if (47630 - 57161 != -9531)
																		{
																			continue;
																		}
																		color21.a = (float)num21;
																		if (94930 - 188940 != -94010)
																		{
																			continue;
																		}
																		if (153371 - 515942 == -362570)
																		{
																			continue;
																		}
																		GUI.color = color21;
																		if (181894 - 65827 == 116068)
																		{
																			continue;
																		}
																		if (69169 - 66076 != 3093)
																		{
																			continue;
																		}
																		int num22 = this.gnAcsNyZNhZ[this.BULcsCwfQ8o];
																		if (113409 - 247233 != -133824)
																		{
																			continue;
																		}
																		this.A3McsM9GmW3 = Mathf.SmoothDamp(this.A3McsM9GmW3, (float)num22, ref this.vu2csFZqd6W, 0.5f);
																		if (9504 - 223865 != -214361)
																		{
																			continue;
																		}
																		GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH + (float)this.j2OcHtAgCGZ[this.BULcsCwfQ8o] + (float)2 * ((float)num22 - this.A3McsM9GmW3), (float)163, (float)this.paqcHJlV8ol, (float)714), this.gYLcHIaI6BF);
																		if (221393 - 202009 != 19384)
																		{
																			continue;
																		}
																		this.RenderNoticeBar("Verifying new character...");
																		if (89388 - 339730 == -250341)
																		{
																			continue;
																		}
																		if (this.JLGcs8s1IaP)
																		{
																			if (232463 - 418469 == -186005)
																			{
																				continue;
																			}
																			if (Time.time - this.kRxcs7ANpug >= (float)1)
																			{
																				if (91012 - 284638 != -193626)
																				{
																					continue;
																				}
																				this.CloseCreateChar();
																				if (220162 - 432626 != -212464)
																				{
																					continue;
																				}
																			}
																		}
																	}
																	else if (uq2csHy8BJ == eCreateCharState.close)
																	{
																		if (257188 - 358263 == -101074)
																		{
																			continue;
																		}
																		this.Ax9csfcpD1B = Mathf.Lerp((float)1, (float)0, (float)2 * (Time.time - this.kRxcs7ANpug));
																		if (183236 - 589341 != -406105)
																		{
																			continue;
																		}
																		if (this.Ax9csfcpD1B == (float)0)
																		{
																			if (174764 - 553839 != -379075)
																			{
																				continue;
																			}
																			if (this.JLGcs8s1IaP)
																			{
																				if (80643 - 524904 != -444261)
																				{
																					continue;
																				}
																				this.UQ2csHy8BJ8 = eCreateCharState.viewTutorial;
																				if (18480 - 482672 == -464191)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				this.ejCc4F7R49A = eLobbyState.LobbyMenu;
																				if (61526 - 45999 != 15527)
																				{
																					continue;
																				}
																			}
																		}
																		else
																		{
																			float ax9csfcpD1B2 = this.Ax9csfcpD1B;
																			if (14073 - 141655 == -127581)
																			{
																				continue;
																			}
																			Color color22 = GUI.color;
																			if (56629 - 112150 == -55520)
																			{
																				continue;
																			}
																			float num23 = color22.a = ax9csfcpD1B2;
																			if (276862 - 174211 != 102651)
																			{
																				continue;
																			}
																			if (177901 - 280121 != -102220)
																			{
																				continue;
																			}
																			Color color23 = GUI.color = color22;
																			if (79807 - 400381 != -320574)
																			{
																				continue;
																			}
																			if (15499 - 364471 != -348972)
																			{
																				continue;
																			}
																			GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH + (float)this.j2OcHtAgCGZ[this.BULcsCwfQ8o] + (float)2 * ((float)this.gnAcsNyZNhZ[this.BULcsCwfQ8o] - this.A3McsM9GmW3), (float)163, (float)this.paqcHJlV8ol, (float)714), this.gYLcHIaI6BF);
																			if (51255 - 579759 != -528504)
																			{
																				continue;
																			}
																			int num24 = 1;
																			if (221325 - 298860 == -77534)
																			{
																				continue;
																			}
																			Color color24 = GUI.color;
																			if (262315 - 319872 == -57556)
																			{
																				continue;
																			}
																			color24.a = (float)num24;
																			if (193563 - 463500 != -269937)
																			{
																				continue;
																			}
																			if (56058 - 558202 != -502144)
																			{
																				continue;
																			}
																			GUI.color = color24;
																			if (127076 - 567847 == -440770 || 62027 - 512786 == -450758)
																			{
																				continue;
																			}
																		}
																	}
																	else if (uq2csHy8BJ == eCreateCharState.viewTutorial)
																	{
																		if (283342 - 425778 == -142435)
																		{
																			continue;
																		}
																		GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)238, (float)745, (float)475, (float)102), this.pOUcHMa527c);
																		if (90976 - 574607 == -483630)
																		{
																			continue;
																		}
																		GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)250, (float)767, (float)447, (float)60), "Play " + this.qN2csUF5y7q[this.BULcsCwfQ8o] + " Tutorial?", this.DnkcHfEmYJ7);
																		if (265997 - 448684 == -182686)
																		{
																			continue;
																		}
																		if (GUI.Button(new Rect(0.5f * this.pBEc4unBEYH - (float)30, (float)825, (float)78, (float)40), string.Empty, this.AjPc4hQyw89))
																		{
																			if (263184 - 530457 == -267272)
																			{
																				continue;
																			}
																			this.JqVcsljcpo8 = eLobbyMenuState.playTutorial;
																			if (86673 - 12864 != 73809)
																			{
																				continue;
																			}
																			this.ejCc4F7R49A = eLobbyState.LobbyMenu;
																			if (86743 - 419907 == -333163)
																			{
																				continue;
																			}
																			this.Gdnc4ASP5nT = Time.time;
																			if (294649 - 361269 == -66619)
																			{
																				continue;
																			}
																			CharacterData.useCharacter(this.YdXcsG5Lqq0);
																			if (241451 - 179568 == 61884)
																			{
																				continue;
																			}
																			if (this.cvGcscG0Okm)
																			{
																				if (146437 - 593788 != -447351)
																				{
																					continue;
																				}
																				this.audio.PlayOneShot(this.cvGcscG0Okm);
																				if (105411 - 327869 == -222457)
																				{
																					continue;
																				}
																			}
																		}
																		if (GUI.Button(new Rect(0.5f * this.pBEc4unBEYH + (float)65, (float)825, (float)79, (float)40), string.Empty, this.Svrc4KBEA55))
																		{
																			if (168223 - 181691 != -13468)
																			{
																				continue;
																			}
																			this.ejCc4F7R49A = eLobbyState.LobbyMenu;
																			if (50819 - 479014 != -428195)
																			{
																				continue;
																			}
																			if (this.rdFcsnIYqtU)
																			{
																				if (299508 - 135260 != 164248)
																				{
																					continue;
																				}
																				this.audio.PlayOneShot(this.rdFcsnIYqtU);
																				if (275934 - 416098 != -140164)
																				{
																					continue;
																				}
																			}
																		}
																	}
																	float ax9csfcpD1B3 = this.Ax9csfcpD1B;
																	if (192163 - 596650 != -404486)
																	{
																		Color color25 = GUI.color;
																		if (48461 - 221927 != -173465)
																		{
																			color25.a = ax9csfcpD1B3;
																			if (283054 - 31637 != 251418)
																			{
																				if (251142 - 274266 == -23124)
																				{
																					Color color26 = GUI.color = color25;
																					if (71312 - 365682 == -294370)
																					{
																						if (37548 - 469225 == -431677)
																						{
																							GUI.DrawTexture(new Rect((float)0, (float)0, this.pBEc4unBEYH, (float)162), this.gvfcHnFKMWh);
																							if (116949 - 54468 != 62482)
																							{
																								GUI.DrawTexture(new Rect((float)0, (float)874, this.pBEc4unBEYH, (float)150), this.m60cHQgbBpt);
																								if (207422 - 418789 != -211366)
																								{
																									GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH - (float)225, (float)884, (float)450, (float)123), this.qwycHenlIQo);
																									if (150230 - 114719 != 35512)
																									{
																										if (GUI.Button(new Rect(0.5f * (this.pBEc4unBEYH - (float)204), (float)884, (float)204, (float)78), string.Empty, this.ILJcsyQ1NCy))
																										{
																											if (175897 - 310811 != -134914)
																											{
																												continue;
																											}
																											if (this.UQ2csHy8BJ8 != eCreateCharState.selectChar)
																											{
																												if (86524 - 49895 == 36630)
																												{
																													continue;
																												}
																												if (this.UQ2csHy8BJ8 != eCreateCharState.randomStat)
																												{
																													goto IL_1624;
																												}
																												if (157210 - 233021 == -75810)
																												{
																													continue;
																												}
																											}
																											if (this.rdFcsnIYqtU)
																											{
																												if (38647 - 374979 == -336331)
																												{
																													continue;
																												}
																												this.audio.PlayOneShot(this.rdFcsnIYqtU);
																												if (113118 - 352948 != -239830)
																												{
																													continue;
																												}
																											}
																											this.CloseCreateChar();
																											if (105426 - 275 != 105151)
																											{
																												continue;
																											}
																										}
																										IL_1624:
																										int num25 = 1;
																										if (120667 - 320585 != -199917)
																										{
																											Color color27 = GUI.color;
																											if (164284 - 100562 != 63723)
																											{
																												color27.a = (float)num25;
																												if (231432 - 481277 == -249845)
																												{
																													if (224249 - 346101 == -121852)
																													{
																														Color color28 = GUI.color = color27;
																														if (203166 - 571458 == -368292)
																														{
																															if (274711 - 426130 != -151418)
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

	// Token: 0x0600618F RID: 24975 RVA: 0x00D65164 File Offset: 0x00D63364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void NextCreateChar(bool forward)
	{
		if (139213 - 121890 != 17324)
		{
		}
		for (;;)
		{
			if (forward)
			{
				if (155412 - 406452 == -251039)
				{
					continue;
				}
				this.BULcsCwfQ8o = this.BULcsCwfQ8o % 12 + 1;
				if (66057 - 183736 != -117679)
				{
					continue;
				}
			}
			else
			{
				this.BULcsCwfQ8o = (this.BULcsCwfQ8o + 10) % 12 + 1;
				if (185173 - 194692 != -9519)
				{
					continue;
				}
			}
			this.UQ2csHy8BJ8 = eCreateCharState.nextChar;
			if (65053 - 423372 != -358318)
			{
				this.kRxcs7ANpug = Time.time;
				if (268204 - 476187 != -207982)
				{
					this.J8EcsLyKMPM = forward;
					if (48023 - 144081 != -96057)
					{
						this.HONcswLUFr3 = true;
						if (87117 - 424093 == -336976)
						{
							if (CharacterData.cDat1.Type == this.qN2csUF5y7q[this.BULcsCwfQ8o])
							{
								if (243375 - 143129 == 100247)
								{
									continue;
								}
								this.HONcswLUFr3 = false;
								if (70203 - 315616 == -245412)
								{
									continue;
								}
							}
							if (CharacterData.cDat2.Type == this.qN2csUF5y7q[this.BULcsCwfQ8o])
							{
								if (85346 - 121809 == -36462)
								{
									continue;
								}
								this.HONcswLUFr3 = false;
								if (244213 - 133687 != 110526)
								{
									continue;
								}
							}
							if (CharacterData.cDat3.Type == this.qN2csUF5y7q[this.BULcsCwfQ8o])
							{
								if (77675 - 436591 != -358916)
								{
									continue;
								}
								this.HONcswLUFr3 = false;
								if (201769 - 406875 != -205106)
								{
									continue;
								}
							}
							if (this.HONcswLUFr3)
							{
								if (299910 - 140549 == 159362)
								{
									continue;
								}
								this.gYLcHIaI6BF = this.NkAcHXT1i0r[this.BULcsCwfQ8o];
								if (109673 - 454050 == -344376)
								{
									continue;
								}
								this.paqcHJlV8ol = this.GiccH6aPx7P[this.BULcsCwfQ8o];
								if (145429 - 351030 == -205600)
								{
									continue;
								}
							}
							else
							{
								this.paqcHJlV8ol = this.GiccH6aPx7P[this.BULcsCwfQ8o];
								if (174902 - 87574 != 87328)
								{
									continue;
								}
								this.t9GcHOpLeDE = this.BkVcH2dk994[this.BULcsCwfQ8o];
								if (132309 - 535750 != -403441)
								{
									continue;
								}
							}
							this.MTwcHvqbsus = this.lylcHl68tQC[this.BULcsCwfQ8o];
							if (197090 - 538511 != -341420)
							{
								if (!this.t5FcsJaSg4C)
								{
									break;
								}
								if (266673 - 119273 == 147400)
								{
									this.audio.PlayOneShot(this.t5FcsJaSg4C);
									if (281514 - 261042 == 20472)
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

	// Token: 0x06006190 RID: 24976 RVA: 0x00D65518 File Offset: 0x00D63718
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CloseCreateChar()
	{
		if (94691 - 54396 != 40295)
		{
		}
		for (;;)
		{
			this.kRxcs7ANpug = Time.time;
			if (123636 - 198566 == -74930)
			{
				this.UQ2csHy8BJ8 = eCreateCharState.close;
				if (26838 - 287676 == -260838)
				{
					this.camera.cullingMask = LayerMask.NameToLayer("Everything");
					if (162312 - 401979 == -239667)
					{
						if (this.ln7cH1uDXES)
						{
							if (154487 - 9640 == 144848)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.ln7cH1uDXES);
							if (73392 - 70936 != 2456)
							{
								continue;
							}
						}
						if (this.createCamTexture.IsCreated())
						{
							if (226350 - 589225 != -362875)
							{
								continue;
							}
							this.createCamTexture.Release();
							if (213252 - 156793 != 56459)
							{
								continue;
							}
						}
						RenderSettings.ambientLight = this.mf8cHp5LTHd;
						if (23584 - 259141 == -235557)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006191 RID: 24977 RVA: 0x00D65688 File Offset: 0x00D63888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SaveNewChar(int slot, string nName, string nRace, int nSkin)
	{
		if (156851 - 315953 != -159101)
		{
		}
		for (;;)
		{
			Debug.Log("Saving new Character :" + slot + " Name =" + nName + ", Race = " + nRace + ", Skin = " + nSkin);
			if (84138 - 14078 == 70060)
			{
				Hashtable hashtable = new Hashtable();
				if (203130 - 321663 == -118533)
				{
					hashtable.Add(71, PlayerData.UID * 10 + slot);
					if (231313 - 518606 == -287293)
					{
						hashtable.Add(72, nName);
						if (85630 - 349839 == -264209)
						{
							hashtable.Add(73, NetworkUtility.EncodeRace(nRace));
							if (156412 - 221098 != -64685)
							{
								hashtable.Add(74, PhotonClient.cInt16(nSkin));
								if (296514 - 446338 == -149824)
								{
									hashtable.Add(105, PhotonClient.cInt16(this.ym1csPg5qv2[0]));
									if (116245 - 399853 != -283607)
									{
										hashtable.Add(106, PhotonClient.cInt16(this.ym1csPg5qv2[1]));
										if (188040 - 189148 == -1108)
										{
											hashtable.Add(107, PhotonClient.cInt16(this.ym1csPg5qv2[2]));
											if (241549 - 524167 != -282617)
											{
												hashtable.Add(108, PhotonClient.cInt16(this.ym1csPg5qv2[3]));
												if (225689 - 574330 != -348640)
												{
													hashtable.Add(109, PhotonClient.cInt16(this.ym1csPg5qv2[4]));
													if (1048 - 274640 != -273591)
													{
														hashtable.Add(110, PhotonClient.cInt16(this.ym1csPg5qv2[5]));
														if (218854 - 342248 == -123394)
														{
															hashtable.Add(111, PhotonClient.cInt16(this.ym1csPg5qv2[6]));
															if (166233 - 140375 == 25858)
															{
																hashtable.Add(112, PhotonClient.cInt16(this.ym1csPg5qv2[7]));
																if (178650 - 464277 == -285627)
																{
																	if (this.Efbc4VQRRcj == null)
																	{
																		break;
																	}
																	if (100284 - 213920 == -113636)
																	{
																		this.Efbc4VQRRcj.OpCustom(25, hashtable, true);
																		if (190483 - 250310 != -59826)
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

	// Token: 0x06006192 RID: 24978 RVA: 0x00D65A20 File Offset: 0x00D63C20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onNewChar(Hashtable data)
	{
		if (122357 - 327522 != -205165)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(RuntimeServices.InvokeBinaryOperator("op_Subtraction", data[71], PlayerData.UID * 10));
			if (227346 - 529063 != -301716)
			{
				CharacterDataClass characterDataClass = null;
				if (204312 - 243977 == -39665)
				{
					if (num != this.YdXcsG5Lqq0)
					{
						if (18269 - 241973 != -223703)
						{
							Debug.Log("NewChar Error : slot=" + num);
							if (274297 - 216605 == 57692)
							{
								break;
							}
						}
					}
					else
					{
						if (num == 1)
						{
							if (66121 - 213824 != -147703)
							{
								continue;
							}
							characterDataClass = CharacterData.cDat1;
							if (152472 - 520560 == -368087)
							{
								continue;
							}
						}
						else if (num == 2)
						{
							if (137177 - 51716 == 85462)
							{
								continue;
							}
							characterDataClass = CharacterData.cDat2;
							if (40981 - 76500 == -35518)
							{
								continue;
							}
						}
						else if (num == 3)
						{
							if (208696 - 196009 != 12687)
							{
								continue;
							}
							characterDataClass = CharacterData.cDat3;
							if (160039 - 318847 == -158807)
							{
								continue;
							}
						}
						characterDataClass.readHashData(data);
						if (283036 - 569788 == -286752)
						{
							characterDataClass.updateData();
							if (142916 - 433320 != -290403)
							{
								if (this.UQ2csHy8BJ8 != eCreateCharState.saveChar)
								{
									break;
								}
								if (48033 - 573735 == -525702)
								{
									this.createLobbyChar(num);
									if (297005 - 141005 != 156001)
									{
										this.CloseCreateChar();
										if (273577 - 359925 == -86348)
										{
											this.JLGcs8s1IaP = true;
											if (38748 - 246650 == -207902)
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

	// Token: 0x06006193 RID: 24979 RVA: 0x00D65CA8 File Offset: 0x00D63EA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitStatBar()
	{
		if (132129 - 337964 != -205835)
		{
		}
		for (;;)
		{
			this.tyZcHYZ0BII = (Texture)Resources.Load("GameGui/Lobby/selectChar/bar_statusWindow", typeof(Texture));
			if (3365 - 269993 != -266627)
			{
				this.zDtcH30eHAh = new GUIStyle();
				if (285317 - 24447 != 260871)
				{
					this.zDtcH30eHAh.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/selectChar/button_arrowLeft", typeof(Texture)));
					if (1188 - 127401 == -126213)
					{
						this.uhqcHb1YOCq = new GUIStyle();
						if (100026 - 172171 != -72144)
						{
							this.uhqcHb1YOCq.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Lobby/selectChar/button_arrowRight", typeof(Texture)));
							if (200897 - 89579 == 111318)
							{
								this.fFvcHd1M53L = new GUIStyle();
								if (205018 - 264518 == -59500)
								{
									this.fFvcHd1M53L.font = (Font)Resources.Load("GameGui/Fonts/Berlin28");
									if (171312 - 386326 == -215014)
									{
										this.fFvcHd1M53L.alignment = TextAnchor.MiddleLeft;
										if (160198 - 237633 != -77434)
										{
											this.RRFcHgpNNYW = new GUIStyle();
											if (171955 - 310438 != -138482)
											{
												this.RRFcHgpNNYW.font = (Font)Resources.Load("GameGui/Fonts/Berlin24");
												if (214642 - 466035 == -251393)
												{
													this.RRFcHgpNNYW.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
													if (227226 - 143856 == 83370)
													{
														this.RRFcHgpNNYW.alignment = TextAnchor.MiddleLeft;
														if (35727 - 556405 != -520677)
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

	// Token: 0x06006194 RID: 24980 RVA: 0x00D65F30 File Offset: 0x00D64130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderStatBar(int offset)
	{
		if (211260 - 534742 != -323482)
		{
		}
		for (;;)
		{
			IL_1DF:
			GUI.BeginGroup(new Rect(0.5f * this.pBEc4unBEYH - (float)500, (float)(800 + offset), (float)1000, (float)200));
			if (224140 - 148924 == 75216)
			{
				GUI.Label(new Rect((float)60, (float)0, (float)885, (float)190), this.tyZcHYZ0BII);
				if (255433 - 159654 == 95779)
				{
					this.fFvcHd1M53L.normal.textColor = new Color(0.06f, 0.23f, 0.43f, (float)1);
					if (268572 - 593746 != -325173)
					{
						GUI.Label(new Rect((float)275, (float)56, (float)150, (float)30), string.Empty + CharacterData.current.Name, this.fFvcHd1M53L);
						if (141175 - 545705 != -404529)
						{
							this.fFvcHd1M53L.normal.textColor = new Color(0.6f, 0.15f, 0.15f, (float)1);
							if (59435 - 326416 == -266981)
							{
								GUI.Label(new Rect((float)430, (float)56, (float)100, (float)30), "lv." + CharacterData.current.lv, this.fFvcHd1M53L);
								if (78719 - 486356 == -407637)
								{
									this.fFvcHd1M53L.normal.textColor = new Color(0.06f, 0.43f, 0.11f, (float)1);
									if (198042 - 333134 != -135091)
									{
										GUI.Label(new Rect((float)550, (float)56, (float)60, (float)30), string.Empty + CharacterData.current.getStat(3) * 10, this.fFvcHd1M53L);
										if (95090 - 4337 != 90754)
										{
											GUI.Label(new Rect((float)660, (float)56, (float)60, (float)30), string.Empty + CharacterData.current.getStat(4) * 3, this.fFvcHd1M53L);
											if (252453 - 376509 == -124056)
											{
												int i = 0;
												if (6079 - 435349 != -429269)
												{
													while (i < 8)
													{
														GUI.Label(new Rect((float)(348 + 110 * global::Math.div((float)i, (float)2)), (float)89 + (float)26 * global::Math.mod((float)i, (float)2), (float)40, (float)20), string.Empty + CharacterData.current.getStat(i), this.RRFcHgpNNYW);
														if (125568 - 558523 == -432954)
														{
															goto IL_1DF;
														}
														i++;
														if (113543 - 145302 != -31759)
														{
															goto IL_1DF;
														}
													}
													if (49894 - 199257 == -149363)
													{
														if (this.JqVcsljcpo8 == eLobbyMenuState.selectCharacter)
														{
															if (182719 - 104389 != 78330)
															{
																continue;
															}
															if (GUI.Button(new Rect((float)57, (float)28, (float)212, (float)144), string.Empty, this.zDtcH30eHAh))
															{
																if (145274 - 445275 == -300000)
																{
																	continue;
																}
																this.selectChar((this.YdXcsG5Lqq0 + 1) % 3 + 1);
																if (140584 - 416478 != -275894)
																{
																	continue;
																}
															}
															if (GUI.Button(new Rect((float)702, (float)28, (float)212, (float)144), string.Empty, this.uhqcHb1YOCq))
															{
																if (20982 - 521419 != -500437)
																{
																	continue;
																}
																this.selectChar(this.YdXcsG5Lqq0 % 3 + 1);
																if (203500 - 304283 != -100783)
																{
																	continue;
																}
															}
														}
														GUI.EndGroup();
														if (283111 - 242987 == 40124)
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

	// Token: 0x06006195 RID: 24981 RVA: 0x00D663F4 File Offset: 0x00D645F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitStatGraph()
	{
		if (159605 - 524321 != -364716)
		{
		}
		for (;;)
		{
			this.zyycHa01lu4 = new Vector3[8];
			if (33463 - 15130 != 18334)
			{
				this.RT5cH4xJnDb = new int[8];
				if (166861 - 528970 != -362108)
				{
					this.WRicHs5vBce = new int[8];
					if (2954 - 353210 != -350255)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006196 RID: 24982 RVA: 0x00D664A0 File Offset: 0x00D646A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetStatGraph(int[] nStat, int nScale)
	{
		if (287189 - 234208 != 52982)
		{
		}
		for (;;)
		{
			IL_CB:
			if (284004 - 327448 == -43444)
			{
				int i = 0;
				if (157915 - 437470 == -279555)
				{
					while (i < 8)
					{
						this.zyycHa01lu4[i] = global::Math.rotateH(new Vector3((float)0, (float)0, (float)(nScale * nStat[i])), (float)(180 - i * 45));
						if (169541 - 70489 != 99052)
						{
							goto IL_CB;
						}
						i++;
						if (122213 - 372777 != -250564)
						{
							goto IL_CB;
						}
					}
					if (9635 - 110568 != -100932)
					{
						i = 0;
						if (154720 - 174258 == -19538)
						{
							while (i < 8)
							{
								this.RT5cH4xJnDb[i] = (int)Vector3.Distance(this.zyycHa01lu4[i], this.zyycHa01lu4[(i + 1) % 8]);
								if (260516 - 228872 == 31645)
								{
									goto IL_CB;
								}
								this.WRicHs5vBce[i] = (int)Vector3.Angle(new Vector3((float)-1, (float)0, (float)0), this.zyycHa01lu4[i] - this.zyycHa01lu4[(i + 1) % 8]);
								if (31034 - 413346 != -382312)
								{
									goto IL_CB;
								}
								if (this.zyycHa01lu4[i].z > this.zyycHa01lu4[(i + 1) % 8].z)
								{
									if (71912 - 589787 != -517875)
									{
										goto IL_CB;
									}
									this.WRicHs5vBce[i] = this.WRicHs5vBce[i] * -1;
									if (230881 - 48983 != 181898)
									{
										goto IL_CB;
									}
								}
								i++;
								if (160973 - 250592 != -89619)
								{
									goto IL_CB;
								}
							}
							if (93859 - 120694 != -26834)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006197 RID: 24983 RVA: 0x00D6671C File Offset: 0x00D6491C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawStatGraph(int posx, int posy)
	{
		if (242263 - 445815 != -203551)
		{
		}
		for (;;)
		{
			IL_1A:
			Matrix4x4 matrix = GUI.matrix;
			if (212244 - 376275 == -164031)
			{
				int i = 0;
				if (83212 - 59986 == 23226)
				{
					while (i < 8)
					{
						GUIUtility.RotateAroundPivot((float)this.WRicHs5vBce[i], new Vector2((0.5f * this.pBEc4unBEYH + (float)posx + this.zyycHa01lu4[i].x) * this.lBVc4ygknfE, (this.zyycHa01lu4[i].z + (float)posy) * this.lBVc4ygknfE));
						if (33721 - 177102 != -143381)
						{
							goto IL_1A;
						}
						GUI.DrawTexture(new Rect(0.5f * this.pBEc4unBEYH + (float)posx + this.zyycHa01lu4[i].x, this.zyycHa01lu4[i].z + (float)posy, (float)(this.RT5cH4xJnDb[i] + 2), (float)2), this.XuHcHR8S3LN, ScaleMode.StretchToFill, true, (float)0);
						if (74780 - 52327 != 22453)
						{
							goto IL_1A;
						}
						GUI.matrix = matrix;
						if (21412 - 405771 != -384359)
						{
							goto IL_1A;
						}
						i++;
						if (6925 - 139851 == -132925)
						{
							goto IL_1A;
						}
					}
					if (72102 - 295499 == -223397)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006198 RID: 24984 RVA: 0x00D668D4 File Offset: 0x00D64AD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitStatButton()
	{
		if (151026 - 122557 != 28470)
		{
		}
		for (;;)
		{
			IL_36:
			this.oM4cH7OjvHX = (Texture)Resources.Load("GameGui/Common/toolTip_common", typeof(Texture));
			if (160898 - 24973 != 135926)
			{
				this.vCdcHHfC1q4 = new HoverButtonClass[8];
				if (12396 - 536504 != -524107)
				{
					int i = 0;
					if (185375 - 122249 == 63126)
					{
						while (i < 8)
						{
							this.vCdcHHfC1q4[i] = new HoverButtonClass();
							if (64227 - 505525 != -441298)
							{
								goto IL_36;
							}
							i++;
							if (178039 - 497953 != -319914)
							{
								goto IL_36;
							}
						}
						if (195778 - 210603 == -14825)
						{
							this.tjlcHCERajc = new GUIStyle();
							if (120947 - 160186 != -39238)
							{
								this.tjlcHCERajc.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
								if (99770 - 360915 == -261145)
								{
									this.tjlcHCERajc.wordWrap = true;
									if (201897 - 526102 != -324204)
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

	// Token: 0x06006199 RID: 24985 RVA: 0x00D66A7C File Offset: 0x00D64C7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderStatButton()
	{
		if (248014 - 11423 != 236591)
		{
		}
		for (;;)
		{
			IL_BD:
			Rect rect = new Rect(0.5f * (this.pBEc4unBEYH - (float)304), (float)319, (float)100, (float)32);
			if (220724 - 267627 == -46903)
			{
				int i = 0;
				if (27669 - 235421 == -207752)
				{
					while (i < 8)
					{
						rect.y += (float)34;
						if (260199 - 99091 != 161108)
						{
							goto IL_BD;
						}
						eHoverButtonState eHoverButtonState = HoverButton.newButton(this.vCdcHHfC1q4[i], rect, 0.2f);
						if (295335 - 261588 != 33747)
						{
							goto IL_BD;
						}
						eHoverButtonState eHoverButtonState2 = eHoverButtonState;
						if (142913 - 406083 == -263169)
						{
							goto IL_BD;
						}
						if (eHoverButtonState2 == eHoverButtonState.hover)
						{
							if (77805 - 386788 == -308982)
							{
								goto IL_BD;
							}
							GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)380, rect.y - (float)22, (float)240, (float)150), this.oM4cH7OjvHX);
							if (163867 - 562247 == -398379)
							{
								goto IL_BD;
							}
							string message = Language.getMessage("LobbyGui", 201 + i);
							if (219942 - 364500 == -144557)
							{
								goto IL_BD;
							}
							GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)356, rect.y, (float)180, (float)400), message, this.tjlcHCERajc);
							if (200593 - 245650 == -45056)
							{
								goto IL_BD;
							}
						}
						else
						{
							GUI.Label(rect, this.X5lcHZ7yNOW);
							if (251152 - 70614 != 180538)
							{
								goto IL_BD;
							}
						}
						i++;
						if (228922 - 365851 == -136928)
						{
							goto IL_BD;
						}
					}
					if (200293 - 409939 == -209646)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600619A RID: 24986 RVA: 0x00D66CE8 File Offset: 0x00D64EE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNoticeBar()
	{
		if (203790 - 257785 != -53995)
		{
		}
		for (;;)
		{
			this.pOUcHMa527c = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
			if (216944 - 77802 == 139142)
			{
				this.DnkcHfEmYJ7 = new GUIStyle();
				if (181556 - 82503 == 99053)
				{
					this.DnkcHfEmYJ7.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
					if (147367 - 324017 == -176650)
					{
						this.DnkcHfEmYJ7.alignment = TextAnchor.MiddleCenter;
						if (24176 - 259429 != -235252)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600619B RID: 24987 RVA: 0x00D66DE4 File Offset: 0x00D64FE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNoticeBar(string s)
	{
		GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)238, (float)525, (float)475, (float)102), this.pOUcHMa527c);
		GUI.Label(new Rect(0.5f * this.pBEc4unBEYH - (float)250, (float)550, (float)450, (float)60), s, this.DnkcHfEmYJ7);
	}

	// Token: 0x0600619C RID: 24988 RVA: 0x00D66E58 File Offset: 0x00D65058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600619D RID: 24989 RVA: 0x00D66E5C File Offset: 0x00D6505C
	internal static bool cR485mpXRld4Vtr7IGXJ()
	{
		return true;
	}

	// Token: 0x0600619E RID: 24990 RVA: 0x00D66E60 File Offset: 0x00D65060
	internal static bool agdc2hpXwO6GEsHX4gH7()
	{
		return false;
	}

	// Token: 0x04006ED2 RID: 28370
	private eLobbyState ejCc4F7R49A;

	// Token: 0x04006ED3 RID: 28371
	private float Gdnc4ASP5nT;

	// Token: 0x04006ED4 RID: 28372
	public int posx;

	// Token: 0x04006ED5 RID: 28373
	public int posy;

	// Token: 0x04006ED6 RID: 28374
	public int divx;

	// Token: 0x04006ED7 RID: 28375
	public int divy;

	// Token: 0x04006ED8 RID: 28376
	public int posa;

	// Token: 0x04006ED9 RID: 28377
	public int posb;

	// Token: 0x04006EDA RID: 28378
	public int diva;

	// Token: 0x04006EDB RID: 28379
	public int divb;

	// Token: 0x04006EDC RID: 28380
	private Vector3 t30c49TSFy6;

	// Token: 0x04006EDD RID: 28381
	private float V9ic4WOZx7o;

	// Token: 0x04006EDE RID: 28382
	private float pBEc4unBEYH;

	// Token: 0x04006EDF RID: 28383
	private float lBVc4ygknfE;

	// Token: 0x04006EE0 RID: 28384
	public GameObject createObject1;

	// Token: 0x04006EE1 RID: 28385
	public GameObject createObject2;

	// Token: 0x04006EE2 RID: 28386
	public GameObject createObject3;

	// Token: 0x04006EE3 RID: 28387
	private LitePeer Efbc4VQRRcj;

	// Token: 0x04006EE4 RID: 28388
	private GUIStyle AjPc4hQyw89;

	// Token: 0x04006EE5 RID: 28389
	private GUIStyle Svrc4KBEA55;

	// Token: 0x04006EE6 RID: 28390
	private GUIStyle aeNc4zfhdmh;

	// Token: 0x04006EE7 RID: 28391
	private GUIStyle k2lcs5I21OG;

	// Token: 0x04006EE8 RID: 28392
	private AudioClip cvGcscG0Okm;

	// Token: 0x04006EE9 RID: 28393
	private AudioClip rdFcsnIYqtU;

	// Token: 0x04006EEA RID: 28394
	private AudioClip uhGcsQiYnLX;

	// Token: 0x04006EEB RID: 28395
	private AudioClip yA1csewwR0k;

	// Token: 0x04006EEC RID: 28396
	private AudioClip rttcsIOkN54;

	// Token: 0x04006EED RID: 28397
	private AudioClip t5FcsJaSg4C;

	// Token: 0x04006EEE RID: 28398
	private AudioClip oascs6egIZp;

	// Token: 0x04006EEF RID: 28399
	private AudioClip dQZcstcB7cJ;

	// Token: 0x04006EF0 RID: 28400
	private AudioClip jP7csXQIyoQ;

	// Token: 0x04006EF1 RID: 28401
	private GameObject uOEcsOs7rKw;

	// Token: 0x04006EF2 RID: 28402
	private GameObject LHhcs2pQWZb;

	// Token: 0x04006EF3 RID: 28403
	private GameObject mcbcsvme3N6;

	// Token: 0x04006EF4 RID: 28404
	private eLobbyMenuState JqVcsljcpo8;

	// Token: 0x04006EF5 RID: 28405
	private int YdXcsG5Lqq0;

	// Token: 0x04006EF6 RID: 28406
	private float MYVcs1FDpQe;

	// Token: 0x04006EF7 RID: 28407
	private float GvHcsqSTZ58;

	// Token: 0x04006EF8 RID: 28408
	private int[] GB0csp2afqC;

	// Token: 0x04006EF9 RID: 28409
	private float Yd5csRtgpik;

	// Token: 0x04006EFA RID: 28410
	private Texture Ngicsrx0bPd;

	// Token: 0x04006EFB RID: 28411
	private Texture KLDcsxmvtEn;

	// Token: 0x04006EFC RID: 28412
	private Texture Vw3csT0E8gs;

	// Token: 0x04006EFD RID: 28413
	private Texture pr7csYnhU1G;

	// Token: 0x04006EFE RID: 28414
	private Texture qoycs3HUulx;

	// Token: 0x04006EFF RID: 28415
	private Texture aXUcsbpsbkb;

	// Token: 0x04006F00 RID: 28416
	private HoverButtonClass f9ecsdyuncE;

	// Token: 0x04006F01 RID: 28417
	private HoverButtonClass fKdcsg80cxA;

	// Token: 0x04006F02 RID: 28418
	private HoverButtonClass kDscsaKY71X;

	// Token: 0x04006F03 RID: 28419
	private string I0lcs4ODiEl;

	// Token: 0x04006F04 RID: 28420
	private int mK3cssqblxF;

	// Token: 0x04006F05 RID: 28421
	private eCreateCharState UQ2csHy8BJ8;

	// Token: 0x04006F06 RID: 28422
	private float kRxcs7ANpug;

	// Token: 0x04006F07 RID: 28423
	private bool UIYcsZyov67;

	// Token: 0x04006F08 RID: 28424
	private int BULcsCwfQ8o;

	// Token: 0x04006F09 RID: 28425
	private float A3McsM9GmW3;

	// Token: 0x04006F0A RID: 28426
	private float Ax9csfcpD1B;

	// Token: 0x04006F0B RID: 28427
	private bool J8EcsLyKMPM;

	// Token: 0x04006F0C RID: 28428
	private bool HONcswLUFr3;

	// Token: 0x04006F0D RID: 28429
	private string[] qN2csUF5y7q;

	// Token: 0x04006F0E RID: 28430
	private int[] gnAcsNyZNhZ;

	// Token: 0x04006F0F RID: 28431
	private int[] rd5csEVPQW5;

	// Token: 0x04006F10 RID: 28432
	private int[] ym1csPg5qv2;

	// Token: 0x04006F11 RID: 28433
	private int[] H36csSdxnIp;

	// Token: 0x04006F12 RID: 28434
	private float CS2csBj1MBW;

	// Token: 0x04006F13 RID: 28435
	private float gCtcs0SRtA9;

	// Token: 0x04006F14 RID: 28436
	private bool JLGcs8s1IaP;

	// Token: 0x04006F15 RID: 28437
	private float tqCcsiIvxl4;

	// Token: 0x04006F16 RID: 28438
	private string DP7csDtR6Jm;

	// Token: 0x04006F17 RID: 28439
	private Texture EW0csmJS88l;

	// Token: 0x04006F18 RID: 28440
	private Texture JEecsjgqYge;

	// Token: 0x04006F19 RID: 28441
	private Texture aM2csoJrAV0;

	// Token: 0x04006F1A RID: 28442
	private Texture Ht4csksypnx;

	// Token: 0x04006F1B RID: 28443
	private float vu2csFZqd6W;

	// Token: 0x04006F1C RID: 28444
	private int sH1csAibVDj;

	// Token: 0x04006F1D RID: 28445
	private GUIStyle xxNcs9xxrQa;

	// Token: 0x04006F1E RID: 28446
	private GUISkin IJDcsWBiqW1;

	// Token: 0x04006F1F RID: 28447
	private GUIStyle P72csuiZM5t;

	// Token: 0x04006F20 RID: 28448
	private GUIStyle ILJcsyQ1NCy;

	// Token: 0x04006F21 RID: 28449
	private GUIStyle HY7csVXZoZo;

	// Token: 0x04006F22 RID: 28450
	private GUIStyle f1kcshjigYA;

	// Token: 0x04006F23 RID: 28451
	private GUIStyle O2YcsKq76Wu;

	// Token: 0x04006F24 RID: 28452
	private GUIStyle rBncszcNPTN;

	// Token: 0x04006F25 RID: 28453
	private GUIStyle wnQcH5llRDL;

	// Token: 0x04006F26 RID: 28454
	private GUIStyle OfMcHcvjpFp;

	// Token: 0x04006F27 RID: 28455
	private Texture gvfcHnFKMWh;

	// Token: 0x04006F28 RID: 28456
	private Texture m60cHQgbBpt;

	// Token: 0x04006F29 RID: 28457
	private Texture qwycHenlIQo;

	// Token: 0x04006F2A RID: 28458
	private Texture gYLcHIaI6BF;

	// Token: 0x04006F2B RID: 28459
	private int paqcHJlV8ol;

	// Token: 0x04006F2C RID: 28460
	private int[] GiccH6aPx7P;

	// Token: 0x04006F2D RID: 28461
	private int[] j2OcHtAgCGZ;

	// Token: 0x04006F2E RID: 28462
	private Texture[] NkAcHXT1i0r;

	// Token: 0x04006F2F RID: 28463
	private Texture t9GcHOpLeDE;

	// Token: 0x04006F30 RID: 28464
	private Texture[] BkVcH2dk994;

	// Token: 0x04006F31 RID: 28465
	private Texture MTwcHvqbsus;

	// Token: 0x04006F32 RID: 28466
	private Texture[] lylcHl68tQC;

	// Token: 0x04006F33 RID: 28467
	private Texture a3JcHGIvF8W;

	// Token: 0x04006F34 RID: 28468
	public GameObject createCam;

	// Token: 0x04006F35 RID: 28469
	public RenderTexture createCamTexture;

	// Token: 0x04006F36 RID: 28470
	private GameObject ln7cH1uDXES;

	// Token: 0x04006F37 RID: 28471
	private bool PyecHqOtGxN;

	// Token: 0x04006F38 RID: 28472
	private Color mf8cHp5LTHd;

	// Token: 0x04006F39 RID: 28473
	private Texture XuHcHR8S3LN;

	// Token: 0x04006F3A RID: 28474
	private GUIStyle JeMcHroIivB;

	// Token: 0x04006F3B RID: 28475
	private GUIStyle LIycHxPfF4f;

	// Token: 0x04006F3C RID: 28476
	private GUIStyle DQRcHTdsNd4;

	// Token: 0x04006F3D RID: 28477
	private Texture tyZcHYZ0BII;

	// Token: 0x04006F3E RID: 28478
	private GUIStyle zDtcH30eHAh;

	// Token: 0x04006F3F RID: 28479
	private GUIStyle uhqcHb1YOCq;

	// Token: 0x04006F40 RID: 28480
	private GUIStyle fFvcHd1M53L;

	// Token: 0x04006F41 RID: 28481
	private GUIStyle RRFcHgpNNYW;

	// Token: 0x04006F42 RID: 28482
	private Vector3[] zyycHa01lu4;

	// Token: 0x04006F43 RID: 28483
	private int[] RT5cH4xJnDb;

	// Token: 0x04006F44 RID: 28484
	private int[] WRicHs5vBce;

	// Token: 0x04006F45 RID: 28485
	private HoverButtonClass[] vCdcHHfC1q4;

	// Token: 0x04006F46 RID: 28486
	private Texture oM4cH7OjvHX;

	// Token: 0x04006F47 RID: 28487
	private Texture X5lcHZ7yNOW;

	// Token: 0x04006F48 RID: 28488
	private GUIStyle tjlcHCERajc;

	// Token: 0x04006F49 RID: 28489
	private Texture pOUcHMa527c;

	// Token: 0x04006F4A RID: 28490
	private GUIStyle DnkcHfEmYJ7;

	// Token: 0x02001070 RID: 4208
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OpenCreateChar$36308 : GenericGenerator<object>
	{
		// Token: 0x0600619F RID: 24991 RVA: 0x00D66E64 File Offset: 0x00D65064
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OpenCreateChar$36308(LobbyGui self_)
		{
			if (92088 - 167515 != -75426)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (102079 - 445506 == -343427)
				{
					base..ctor();
					if (201896 - 90038 != 111859)
					{
						this.$self_$36310 = self_;
						if (238259 - 77590 != 160670)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060061A0 RID: 24992 RVA: 0x00D66EFC File Offset: 0x00D650FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new LobbyGui.$OpenCreateChar$36308.$(this.$self_$36310);
		}

		// Token: 0x060061A1 RID: 24993 RVA: 0x00D66F0C File Offset: 0x00D6510C
		internal static bool hJBeAQpXqUsNsVYs59aC()
		{
			return true;
		}

		// Token: 0x060061A2 RID: 24994 RVA: 0x00D66F10 File Offset: 0x00D65110
		internal static bool Fu6L1FpX7dJoBXyyIy6a()
		{
			return false;
		}

		// Token: 0x04006F4B RID: 28491
		internal LobbyGui $self_$36310;

		// Token: 0x02001071 RID: 4209
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x060061A3 RID: 24995 RVA: 0x00D66F14 File Offset: 0x00D65114
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(LobbyGui self_)
			{
				if (227739 - 52495 != 175244)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (200818 - 518215 == -317397)
					{
						base..ctor();
						if (167957 - 471236 == -303279)
						{
							this.$self_$36309 = self_;
							if (290031 - 559762 == -269731)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060061A4 RID: 24996 RVA: 0x00D66FAC File Offset: 0x00D651AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (239485 - 102320 != 137166)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5A7;
					case 2:
						this.$self_$36309.ejCc4F7R49A = eLobbyState.CreateChar;
						if (290808 - 384023 != -93215)
						{
							continue;
						}
						if (!this.$self_$36309.audio.isPlaying)
						{
							if (96863 - 550976 == -454112)
							{
								continue;
							}
							this.$self_$36309.audio.volume = 0.1f * (float)Game.music;
							if (280684 - 591831 != -311147)
							{
								continue;
							}
							this.$self_$36309.audio.Play();
							if (228843 - 32873 != 195970)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (190874 - 217417 != -26543)
						{
							continue;
						}
						goto IL_5A7;
					default:
						if (282839 - 522322 == -239482)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$36309.UIYcsZyov67)
					{
						if (137572 - 223259 != -85687)
						{
							continue;
						}
						this.$self_$36309.InitCreateChar();
						if (270557 - 438856 == -168298)
						{
							continue;
						}
					}
					this.$self_$36309.I0lcs4ODiEl = "Character Name";
					if (21304 - 573907 == -552603)
					{
						this.$self_$36309.mK3cssqblxF = 100;
						if (276142 - 352386 == -76244)
						{
							this.$self_$36309.UQ2csHy8BJ8 = eCreateCharState.start;
							if (124211 - 380466 == -256255)
							{
								this.$self_$36309.kRxcs7ANpug = (float)0;
								if (31381 - 302798 == -271417)
								{
									this.$self_$36309.BULcsCwfQ8o = 1;
									if (239036 - 552332 == -313296)
									{
										this.$self_$36309.A3McsM9GmW3 = (float)0;
										if (202931 - 429061 == -226130)
										{
											this.$self_$36309.Ax9csfcpD1B = (float)0;
											if (171865 - 245645 != -73779)
											{
												this.$self_$36309.J8EcsLyKMPM = true;
												if (129276 - 447224 != -317947)
												{
													this.$self_$36309.HONcswLUFr3 = true;
													if (159590 - 228461 == -68871)
													{
														this.$self_$36309.CS2csBj1MBW = (float)0;
														if (26992 - 543378 != -516385)
														{
															this.$self_$36309.gCtcs0SRtA9 = (float)0;
															if (25939 - 161828 != -135888)
															{
																this.$self_$36309.vu2csFZqd6W = (float)0;
																if (273775 - 549912 != -276136)
																{
																	this.$self_$36309.sH1csAibVDj = 0;
																	if (82989 - 202935 == -119946)
																	{
																		this.$self_$36309.gYLcHIaI6BF = this.$self_$36309.NkAcHXT1i0r[this.$self_$36309.BULcsCwfQ8o];
																		if (191433 - 258037 == -66604)
																		{
																			this.$self_$36309.paqcHJlV8ol = this.$self_$36309.GiccH6aPx7P[this.$self_$36309.BULcsCwfQ8o];
																			if (58580 - 171364 == -112784)
																			{
																				this.$self_$36309.t9GcHOpLeDE = this.$self_$36309.BkVcH2dk994[this.$self_$36309.BULcsCwfQ8o];
																				if (74604 - 540873 == -466269)
																				{
																					this.$self_$36309.MTwcHvqbsus = this.$self_$36309.lylcHl68tQC[this.$self_$36309.BULcsCwfQ8o];
																					if (206575 - 455946 != -249370)
																					{
																						if (CharacterData.cDat1.Type == this.$self_$36309.qN2csUF5y7q[this.$self_$36309.BULcsCwfQ8o])
																						{
																							if (61362 - 443994 == -382631)
																							{
																								continue;
																							}
																							this.$self_$36309.HONcswLUFr3 = false;
																							if (140291 - 387064 == -246772)
																							{
																								continue;
																							}
																						}
																						if (CharacterData.cDat2.Type == this.$self_$36309.qN2csUF5y7q[this.$self_$36309.BULcsCwfQ8o])
																						{
																							if (42064 - 553913 != -511849)
																							{
																								continue;
																							}
																							this.$self_$36309.HONcswLUFr3 = false;
																							if (285253 - 581891 == -296637)
																							{
																								continue;
																							}
																						}
																						if (!(CharacterData.cDat3.Type == this.$self_$36309.qN2csUF5y7q[this.$self_$36309.BULcsCwfQ8o]))
																						{
																							break;
																						}
																						if (119873 - 467253 == -347380)
																						{
																							this.$self_$36309.HONcswLUFr3 = false;
																							if (158329 - 429872 != -271542)
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
				return this.YieldDefault(2);
				IL_5A7:
				return false;
			}

			// Token: 0x060061A5 RID: 24997 RVA: 0x00D67574 File Offset: 0x00D65774
			internal static bool N3MlfVpXPvwgf6I6Yh47()
			{
				return true;
			}

			// Token: 0x060061A6 RID: 24998 RVA: 0x00D67578 File Offset: 0x00D65778
			internal static bool hxSO6PpX0ZMvSt6c0xSY()
			{
				return false;
			}

			// Token: 0x04006F4C RID: 28492
			internal LobbyGui $self_$36309;
		}
	}
}
