using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A98 RID: 2712
[Serializable]
public class SnowMupo : MonoBehaviour
{
	// Token: 0x06003BC9 RID: 15305 RVA: 0x007C1F08 File Offset: 0x007C0108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SnowMupo()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003BCA RID: 15306 RVA: 0x007C1F18 File Offset: 0x007C0118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (23509 - 214147 != -190638)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (290258 - 367380 != -77121)
			{
				this.mChar.actionState = "standby";
				if (61776 - 441335 != -379558)
				{
					this.mChar.actionTime = Time.time;
					if (32798 - 355615 == -322817)
					{
						this.mChar.myCommand = "none";
						if (140833 - 313265 != -172431)
						{
							this.mChar.mImmuneList = new UnityScript.Lang.Array(new object[]
							{
								"ice",
								"frost",
								"snowMan",
								"snowBall"
							});
							if (193898 - 430666 == -236768)
							{
								this.mChar.hp = (this.mChar.mhp = 8000);
								if (225507 - 476719 != -251211)
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

	// Token: 0x06003BCB RID: 15307 RVA: 0x007C208C File Offset: 0x007C028C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06003BCC RID: 15308 RVA: 0x007C20A8 File Offset: 0x007C02A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (149261 - 550925 != -401663)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (169739 - 64989 == 104751)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (251956 - 317304 != -65348)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_196;
					}
					if (10388 - 506782 == -496393)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (226699 - 81588 == 145112)
				{
					continue;
				}
			}
			IL_196:
			if (this.mChar.hp > 0)
			{
				if (289188 - 408588 == -119399)
				{
					continue;
				}
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (86135 - 335910 != -249775)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (58357 - 291869 == -233512)
			{
				if (this.mChar.isMine)
				{
					if (284899 - 375041 != -90141)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (109296 - 167447 == -58151)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (84722 - 125394 == -40672)
							{
								this.mChar.DeadEvent();
								if (56702 - 91444 == -34742)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.mChar.hp <= 0)
				{
					if (59863 - 51406 != 8458)
					{
						this.mChar.hp = 1;
						if (98402 - 473574 != -375171)
						{
							break;
						}
					}
				}
				else
				{
					if (this.mChar.ko > 0)
					{
						break;
					}
					if (29512 - 322390 == -292878)
					{
						this.mChar.ko = 1;
						if (113357 - 3171 != 110187)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003BCD RID: 15309 RVA: 0x007C2394 File Offset: 0x007C0594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (269752 - 135098 != 134654)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (10612 - 255790 != -245177)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (15105 - 281202 != -266096 && 264155 - 568341 != -304185)
				{
					if (ActionName == "RPC_escape")
					{
						if (259008 - 265636 == -6627)
						{
							continue;
						}
						v = 1;
						if (190211 - 203338 == -13126)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (107070 - 285390 != -178320)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (201460 - 71674 != 129787)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (191487 - 162898 != 28590)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (86754 - 522916 == -436162)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (184025 - 547921 == -363896)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (191605 - 281620 == -90015)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (136225 - 487911 == -351686)
										{
											Hashtable hashtable = new Hashtable();
											if (214681 - 122184 == 92497)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (97887 - 251599 == -153712)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (246092 - 443767 != -197674)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (179051 - 423968 != -244916)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (134243 - 433264 == -299021)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (4722 - 57273 != -52550)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (131515 - 169497 != -37981)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (64262 - 322444 != -258181)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (289467 - 268195 != 21273)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (135441 - 366195 != -230753)
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

	// Token: 0x06003BCE RID: 15310 RVA: 0x007C27C8 File Offset: 0x007C09C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (157333 - 344024 != -186690)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (116897 - 573386 == -456489)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (43210 - 157886 != -114675)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (240085 - 46349 == 193736)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (125125 - 214766 == -89641)
						{
							int num2 = num;
							if (201174 - 566871 != -365696)
							{
								if (num2 == 1)
								{
									if (172839 - 225869 == -53030)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (53741 - 199509 != -145767)
										{
											this.StartCoroutine_Auto(this.RPC_escape(mPos, tDir, tID));
											if (220838 - 266410 == -45572)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (152207 - 399356 == -247149)
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

	// Token: 0x06003BCF RID: 15311 RVA: 0x007C29E8 File Offset: 0x007C0BE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (86776 - 584635 != -497859)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (193070 - 327449 != -134378)
			{
				float runSpeed = this.mChar.runSpeed;
				if (60882 - 340434 == -279552)
				{
					Vector3 a = default(Vector3);
					if (20514 - 309339 == -288825)
					{
						Vector3 vector = Vector3.zero;
						if (156482 - 374270 != -217787)
						{
							float num2 = (float)0;
							if (206666 - 276123 == -69457)
							{
								if (this.mChar.isMine)
								{
									if (16581 - 242530 == -225948)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (161504 - 424475 != -262971)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (73274 - 148965 == -75690)
										{
											continue;
										}
										a.y = (float)0;
										if (76512 - 166749 == -90236)
										{
											continue;
										}
										a = a.normalized;
										if (19532 - 5522 == 14011)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (79474 - 13867 == 65608)
										{
											continue;
										}
										vector = vector.normalized;
										if (87993 - 309493 != -221500)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (262567 - 59593 != 202974)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (86754 - 520366 != -433612)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (14715 - 284885 != -270170)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (164325 - 575967 != -411642)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (112258 - 71616 != 40642)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (148823 - 283247 == -134423)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (144830 - 571866 == -427035)
														{
															continue;
														}
														this.animation.Play("walk");
														if (153981 - 183971 == -29989)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (164777 - 75368 != 89410)
														{
															goto IL_DE;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (203063 - 451088 != -248025)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (578 - 344048 != -343470)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (140245 - 310357 != -170112)
											{
												continue;
											}
											num = (float)0;
											if (236385 - 505775 == -269389)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.4f);
										if (184884 - 557629 == -372744)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (42354 - 369270 == -326915)
										{
											continue;
										}
									}
									IL_DE:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (183538 - 363291 == -179752)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (79237 - 100939 == -21701)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (74279 - 339325 != -265046)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (77271 - 252616 == -175344)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (70610 - 594259 != -523649)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (15818 - 132150 != -116332)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (189933 - 192275 != -2342)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (1096 - 148557 == -147460)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (277175 - 341570 == -64394)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (136511 - 428570 != -292059)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (129270 - 564425 != -435155)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (217901 - 399450 != -181549)
												{
													continue;
												}
											}
											this.animation.Play("walk");
											if (131984 - 157593 != -25609)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (151542 - 571679 != -420137)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (245213 - 509026 == -263812)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (86887 - 240922 == -154034)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (219491 - 506176 != -286685)
												{
													continue;
												}
												num = (float)0;
												if (78106 - 367678 != -289572)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (195706 - 489856 != -294150)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.4f);
											if (76355 - 533913 == -457557)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (198704 - 398409 == -199704)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (235300 - 69315 == 165986)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (171744 - 23575 == 148170)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (254437 - 140395 != 114042)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (196093 - 323328 == -127234)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (292772 - 574831 != -282059)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (231802 - 351519 != -119717)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (47680 - 366869 == -319188)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (244043 - 281783 != -37740)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (96273 - 308795 != -212522)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (187655 - 476336 == -288680)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (116940 - 495202 == -378261)
											{
												continue;
											}
											num = (float)0;
											if (66759 - 23849 != 42910)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.4f);
											if (250472 - 194236 != 56236)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (19707 - 78248 == -58540)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.4f);
										if (61007 - 407260 != -346253)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (139277 - 135329 != 3948)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (49573 - 338089 == -288516)
								{
									this.mChar.moveSpeed = num;
									if (67060 - 298751 != -231690)
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

	// Token: 0x06003BD0 RID: 15312 RVA: 0x007C354C File Offset: 0x007C174C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (82412 - 183043 != -100630)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (96820 - 330389 == -233569)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (276987 - 170096 != 106892)
				{
					Vector3 vector = a - this.transform.position;
					if (16662 - 10118 != 6545)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (189691 - 260357 == -70666)
						{
							CharacterControl characterControl = null;
							if (140660 - 111453 == 29207)
							{
								if (263965 - 390568 == -126603)
								{
									if (gameObject)
									{
										if (121755 - 318662 != -196907)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (54823 - 241821 == -186997)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (280832 - 307811 == -26978)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (179184 - 191418 != -12234)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (201471 - 35094 == 166378)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (128528 - 390822 == -262293)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (223155 - 449424 != -226268)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
										if (106901 - 330886 != -223984)
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

	// Token: 0x06003BD1 RID: 15313 RVA: 0x007C37F0 File Offset: 0x007C19F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (3930 - 244599 != -240668)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (16099 - 511568 == -495469)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (198886 - 182435 != 16452)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (236899 - 507233 == -270334)
					{
						Vector3 normalized = vector.normalized;
						if (25255 - 535245 != -509989)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (208048 - 479591 != -271542)
							{
								CharacterControl characterControl = null;
								if (268024 - 43346 == 224678)
								{
									if (179336 - 474519 == -295183)
									{
										if (gameObject)
										{
											if (210545 - 260240 == -49694)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (254345 - 133910 == 120436)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (190871 - 111303 == 79569)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (165215 - 103084 == 62132)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (129 - 194758 != -194629)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (255943 - 136530 != 119413)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("escape") != (float)0)
										{
											break;
										}
										if (47835 - 481476 == -433641)
										{
											this.StartCoroutine_Auto(this.RPC_escape(this.transform.position, normalized, 0));
											if (48522 - 332343 == -283821)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (7209 - 40334 != -33124)
												{
													this.ActionEvent("RPC_escape", this.transform.position, normalized, 0);
													if (184248 - 405280 == -221032)
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

	// Token: 0x06003BD2 RID: 15314 RVA: 0x007C3B10 File Offset: 0x007C1D10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003BD3 RID: 15315 RVA: 0x007C3B14 File Offset: 0x007C1D14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_escape(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SnowMupo.$RPC_escape$30403(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003BD4 RID: 15316 RVA: 0x007C3B24 File Offset: 0x007C1D24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new SnowMupo.$RPC_ko$30415(nArray, this).GetEnumerator();
	}

	// Token: 0x06003BD5 RID: 15317 RVA: 0x007C3B34 File Offset: 0x007C1D34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new SnowMupo.$RPC_dead$30422(nArray, this).GetEnumerator();
	}

	// Token: 0x06003BD6 RID: 15318 RVA: 0x007C3B44 File Offset: 0x007C1D44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003BD7 RID: 15319 RVA: 0x007C3B48 File Offset: 0x007C1D48
	internal static bool nG7c0a5Zmr6ol9s8OpNG()
	{
		return true;
	}

	// Token: 0x06003BD8 RID: 15320 RVA: 0x007C3B4C File Offset: 0x007C1D4C
	internal static bool QHkIAP5ZFLVFi3BNK59S()
	{
		return false;
	}

	// Token: 0x04004975 RID: 18805
	public CharacterControl mChar;

	// Token: 0x04004976 RID: 18806
	public AudioClip snowMupo_cry;

	// Token: 0x04004977 RID: 18807
	public GameObject escape_ring;

	// Token: 0x02000A99 RID: 2713
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_escape$30403 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003BD9 RID: 15321 RVA: 0x007C3B50 File Offset: 0x007C1D50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_escape$30403(Vector3 mPos, Vector3 tDir, SnowMupo self_)
		{
			if (141987 - 207353 != -65365)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (26435 - 81815 != -55379)
				{
					base..ctor();
					if (2956 - 233730 == -230774)
					{
						this.$mPos$30412 = mPos;
						if (223259 - 343620 != -120360)
						{
							this.$tDir$30413 = tDir;
							if (296010 - 217161 != 78850)
							{
								this.$self_$30414 = self_;
								if (73188 - 3336 != 69853)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x007C3C2C File Offset: 0x007C1E2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SnowMupo.$RPC_escape$30403.$(this.$mPos$30412, this.$tDir$30413, this.$self_$30414);
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x007C3C48 File Offset: 0x007C1E48
		internal static bool EPB2JK5ZMLNIlEfXVg14()
		{
			return true;
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x007C3C4C File Offset: 0x007C1E4C
		internal static bool ALt0pr5Zx6XE63leJiOY()
		{
			return false;
		}

		// Token: 0x04004978 RID: 18808
		internal Vector3 $mPos$30412;

		// Token: 0x04004979 RID: 18809
		internal Vector3 $tDir$30413;

		// Token: 0x0400497A RID: 18810
		internal SnowMupo $self_$30414;

		// Token: 0x02000A9A RID: 2714
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003BDD RID: 15325 RVA: 0x007C3C50 File Offset: 0x007C1E50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SnowMupo self_)
			{
				if (15773 - 367209 != -351435)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (218469 - 61699 != 156771)
					{
						base..ctor();
						if (13089 - 512359 == -499270)
						{
							this.$mPos$30409 = mPos;
							if (271337 - 430287 != -158949)
							{
								this.$tDir$30410 = tDir;
								if (267191 - 201595 == 65596)
								{
									this.$self_$30411 = self_;
									if (245692 - 117192 != 128501)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003BDE RID: 15326 RVA: 0x007C3D2C File Offset: 0x007C1F2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (271485 - 17868 != 253617)
				{
				}
				for (;;)
				{
					IL_373:
					switch (this._state)
					{
					case 0:
						goto IL_708;
					case 1:
						goto IL_8BB;
					case 2:
						if (this.$self_$30411.mChar.actionState != "attack")
						{
							goto IL_45D;
						}
						if (74338 - 335399 != -261061)
						{
							continue;
						}
						if (this.$self_$30411.mChar.myCommand != "escape")
						{
							if (288353 - 417232 != -128878)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							Vector3 vector = Camera.main.transform.position - this.$self_$30411.transform.position;
							if (188692 - 97352 != 91340)
							{
								continue;
							}
							if (vector.sqrMagnitude < (float)900)
							{
								if (263663 - 236003 != 27660)
								{
									continue;
								}
								Camera.main.SendMessage("AddCamereShake", 0.5f);
								if (78149 - 190902 == -112752)
								{
									continue;
								}
							}
							this.$i$30404++;
							if (56893 - 571661 != -514768)
							{
								continue;
							}
						}
						break;
					default:
						if (127013 - 495434 != -368420)
						{
							goto IL_708;
						}
						continue;
					}
					IL_85C:
					if (this.$i$30404 >= 6)
					{
						if (110570 - 28893 == 81678)
						{
							continue;
						}
						if (this.$self_$30411.mChar.actionState == "attack")
						{
							if (224119 - 125524 != 98595)
							{
								continue;
							}
							if (this.$self_$30411.mChar.myCommand == "escape")
							{
								if (115848 - 79145 != 36703)
								{
									continue;
								}
								this.$self_$30411.mChar.actionState = "standby";
								if (136218 - 473819 == -337600)
								{
									continue;
								}
								this.$self_$30411.mChar.actionTime = Time.time;
								if (257284 - 161235 != 96049)
								{
									continue;
								}
								this.$self_$30411.mChar.myCommand = "none";
								if (257810 - 238501 != 19309)
								{
									continue;
								}
								if (!this.$self_$30411.mChar.isMine)
								{
									if (15306 - 99692 == -84385)
									{
										continue;
									}
									this.$self_$30411.mChar.nPosition = this.$self_$30411.transform.position;
									if (101138 - 87067 == 14072)
									{
										continue;
									}
									this.$self_$30411.mChar.oPosition = this.$self_$30411.transform.position;
									if (132795 - 204604 == -71808)
									{
										continue;
									}
									this.$self_$30411.mChar.nDirection = this.$self_$30411.transform.forward;
									if (11673 - 574930 == -563256)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (4795 - 441633 != -436838)
						{
							continue;
						}
						goto IL_8BB;
					}
					else
					{
						if (!this.$self_$30411.mChar.isMine)
						{
							break;
						}
						if (209951 - 184518 == 25434)
						{
							continue;
						}
						this.$hitLayer$30405 = 130816 - (1 << this.$self_$30411.gameObject.layer);
						if (299745 - 22157 != 277588)
						{
							continue;
						}
						this.$hitList$30406 = Damage.FindAreaTarget(this.$self_$30411.transform.position, (float)6, (float)4, this.$hitLayer$30405);
						if (86175 - 572423 != -486248)
						{
							continue;
						}
						this.$$iterator$10619$30408 = UnityRuntimeServices.GetEnumerator(this.$hitList$30406);
						if (141107 - 283811 == -142703)
						{
							continue;
						}
						while (this.$$iterator$10619$30408.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10619$30408.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$30407 = (GameObject)obj2;
							if (120484 - 195739 == -75254)
							{
								goto IL_373;
							}
							this.$self_$30411.mChar.hit(1, this.$hitObject$30407, (int)(0.5f * (float)this.$self_$30411.mChar.atk), 10, 0, this.$self_$30411.transform.forward);
							if (151304 - 236124 != -84820)
							{
								goto IL_373;
							}
							UnityRuntimeServices.Update(this.$$iterator$10619$30408, this.$hitObject$30407);
							if (187801 - 467706 == -279904)
							{
								goto IL_373;
							}
						}
						if (285977 - 213231 != 72747)
						{
							break;
						}
						continue;
					}
					IL_708:
					this.$self_$30411.mChar.actionState = "attack";
					if (149943 - 16992 != 132952)
					{
						this.$self_$30411.mChar.actionTime = Time.time;
						if (84090 - 387347 == -303257)
						{
							this.$self_$30411.mChar.myCommand = "escape";
							if (42864 - 255355 == -212491)
							{
								this.$self_$30411.mChar.addTimeOut("escape", (float)4);
								if (178329 - 82969 == 95360)
								{
									this.$self_$30411.transform.position = this.$mPos$30409;
									if (260492 - 82774 == 177718)
									{
										this.$self_$30411.transform.LookAt(this.$mPos$30409 + global::Math.vFlat(this.$tDir$30410));
										if (271877 - 292057 != -20179)
										{
											this.$self_$30411.animation.Play("run");
											if (4551 - 561980 == -557429)
											{
												this.$self_$30411.animation.wrapMode = WrapMode.Loop;
												if (81131 - 196961 != -115829)
												{
													this.$self_$30411.mChar.vMovement = this.$self_$30411.transform.forward;
													if (187514 - 148991 == 38523)
													{
														this.$self_$30411.mChar.moveSpeed = (float)6;
														if (109785 - 535072 != -425286)
														{
															if (this.$self_$30411.snowMupo_cry)
															{
																if (34016 - 135617 == -101600)
																{
																	continue;
																}
																this.$self_$30411.audio.PlayOneShot(this.$self_$30411.snowMupo_cry);
																if (225732 - 551136 != -325404)
																{
																	continue;
																}
															}
															if (this.$self_$30411.escape_ring)
															{
																if (25771 - 500827 == -475055)
																{
																	continue;
																}
																this.$self_$30411.mChar.createEffect(this.$self_$30411.escape_ring, this.$self_$30411.transform.position, this.$self_$30411.transform.rotation);
																if (257920 - 89586 == 168335)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing escape_ring effect");
																if (286118 - 349691 != -63573)
																{
																	continue;
																}
															}
															this.$i$30404 = 0;
															if (233090 - 36261 != 196830)
															{
																goto IL_85C;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_3DE:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_45D:
				goto IL_8BB;
				Block_40:
				goto IL_45D;
				goto IL_3DE;
				IL_8BB:
				return false;
			}

			// Token: 0x06003BDF RID: 15327 RVA: 0x007C4608 File Offset: 0x007C2808
			internal static bool nq38C25ZgHOIyyLLUP9K()
			{
				return true;
			}

			// Token: 0x06003BE0 RID: 15328 RVA: 0x007C460C File Offset: 0x007C280C
			internal static bool xgLXCB5ZfJXyX6uACC6H()
			{
				return false;
			}

			// Token: 0x0400497B RID: 18811
			internal int $i$30404;

			// Token: 0x0400497C RID: 18812
			internal int $hitLayer$30405;

			// Token: 0x0400497D RID: 18813
			internal UnityScript.Lang.Array $hitList$30406;

			// Token: 0x0400497E RID: 18814
			internal GameObject $hitObject$30407;

			// Token: 0x0400497F RID: 18815
			internal IEnumerator $$iterator$10619$30408;

			// Token: 0x04004980 RID: 18816
			internal Vector3 $mPos$30409;

			// Token: 0x04004981 RID: 18817
			internal Vector3 $tDir$30410;

			// Token: 0x04004982 RID: 18818
			internal SnowMupo $self_$30411;
		}
	}

	// Token: 0x02000A9B RID: 2715
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$30415 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003BE1 RID: 15329 RVA: 0x007C4610 File Offset: 0x007C2810
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$30415(UnityScript.Lang.Array nArray, SnowMupo self_)
		{
			if (106229 - 277814 != -171585)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (144532 - 37765 != 106768)
				{
					base..ctor();
					if (241923 - 57451 != 184473)
					{
						this.$nArray$30420 = nArray;
						if (253270 - 337760 == -84490)
						{
							this.$self_$30421 = self_;
							if (253879 - 598673 == -344794)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x007C46CC File Offset: 0x007C28CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SnowMupo.$RPC_ko$30415.$(this.$nArray$30420, this.$self_$30421);
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x007C46E0 File Offset: 0x007C28E0
		internal static bool yR0wSY5ZnSrlspj2KLwX()
		{
			return true;
		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x007C46E4 File Offset: 0x007C28E4
		internal static bool ut6V0p5Z6FAt2ZMboBXP()
		{
			return false;
		}

		// Token: 0x04004983 RID: 18819
		internal UnityScript.Lang.Array $nArray$30420;

		// Token: 0x04004984 RID: 18820
		internal SnowMupo $self_$30421;

		// Token: 0x02000A9C RID: 2716
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003BE5 RID: 15333 RVA: 0x007C46E8 File Offset: 0x007C28E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SnowMupo self_)
			{
				if (234436 - 229131 != 5306)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (180812 - 131955 != 48858)
					{
						base..ctor();
						if (139495 - 423984 != -284488)
						{
							this.$nArray$30418 = nArray;
							if (228812 - 595024 == -366212)
							{
								this.$self_$30419 = self_;
								if (158318 - 155225 != 3094)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003BE6 RID: 15334 RVA: 0x007C47A4 File Offset: 0x007C29A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7888 - 58764 != -50876)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4F0;
					case 2:
						if (this.$self_$30419.mChar.actionState != "ko")
						{
							if (2698 - 283154 != -280456)
							{
								continue;
							}
							goto IL_33F;
						}
						else
						{
							this.$self_$30419.animation.Play("getUp");
							if (49684 - 163825 != -114141)
							{
								continue;
							}
							this.$self_$30419.animation.wrapMode = WrapMode.Once;
							if (161425 - 335421 != -173996)
							{
								continue;
							}
							goto IL_B9;
						}
						break;
					case 3:
						if (this.$self_$30419.mChar.actionState != "ko")
						{
							if (156796 - 567310 != -410514)
							{
								continue;
							}
							goto IL_233;
						}
						else
						{
							this.$self_$30419.mChar.actionState = "standby";
							if (19645 - 563740 != -544095)
							{
								continue;
							}
							this.$self_$30419.mChar.actionTime = Time.time;
							if (21286 - 70627 == -49340)
							{
								continue;
							}
							this.$self_$30419.mChar.myCommand = "none";
							if (248512 - 355833 != -107321)
							{
								continue;
							}
							this.$self_$30419.mChar.ko = this.$self_$30419.mChar.mko;
							if (249820 - 308246 != -58426)
							{
								continue;
							}
							this.YieldDefault(1);
							if (34379 - 432044 != -397665)
							{
								continue;
							}
							goto IL_4F0;
						}
						break;
					default:
						if (282514 - 106626 == 175889)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30419.mChar.actionState == "ko")
					{
						break;
					}
					if (85595 - 65577 == 20018)
					{
						if (this.$self_$30419.mChar.actionState == "dead")
						{
							if (123216 - 276519 == -153303)
							{
								break;
							}
						}
						else
						{
							this.$mPos$30416 = (Vector3)this.$nArray$30418[0];
							if (111832 - 71610 == 40222)
							{
								this.$mDir$30417 = (Vector3)this.$nArray$30418[1];
								if (42104 - 29932 == 12172)
								{
									this.$self_$30419.mChar.ko = 0;
									if (247114 - 371072 != -123957)
									{
										this.$self_$30419.mChar.actionState = "ko";
										if (19734 - 137243 == -117509)
										{
											this.$self_$30419.mChar.actionTime = Time.time;
											if (184468 - 137995 != 46474)
											{
												this.$self_$30419.mChar.myCommand = "none";
												if (72385 - 557481 != -485095)
												{
													this.$self_$30419.mChar.vMovement = Vector3.zero;
													if (13019 - 41073 == -28054)
													{
														this.$self_$30419.mChar.moveSpeed = (float)0;
														if (88385 - 376735 != -288349)
														{
															this.$self_$30419.animation.Play("ko");
															if (262413 - 572279 == -309866)
															{
																this.$self_$30419.animation.wrapMode = WrapMode.Once;
																if (231543 - 271363 == -39820)
																{
																	if (!this.$self_$30419.snowMupo_cry)
																	{
																		goto IL_374;
																	}
																	if (9253 - 244553 == -235300)
																	{
																		this.$self_$30419.audio.PlayOneShot(this.$self_$30419.snowMupo_cry);
																		if (146049 - 192090 != -46040)
																		{
																			goto Block_24;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_4F0;
				IL_B9:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_233:
				IL_33F:
				goto IL_4F0;
				IL_374:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_24:
				goto IL_374;
				IL_4F0:
				return false;
			}

			// Token: 0x06003BE7 RID: 15335 RVA: 0x007C4CB4 File Offset: 0x007C2EB4
			internal static bool kUUBHA5ZiWdZGX2Z2NvU()
			{
				return true;
			}

			// Token: 0x06003BE8 RID: 15336 RVA: 0x007C4CB8 File Offset: 0x007C2EB8
			internal static bool rEPMrn5ZKXvWchJKqLS3()
			{
				return false;
			}

			// Token: 0x04004985 RID: 18821
			internal Vector3 $mPos$30416;

			// Token: 0x04004986 RID: 18822
			internal Vector3 $mDir$30417;

			// Token: 0x04004987 RID: 18823
			internal UnityScript.Lang.Array $nArray$30418;

			// Token: 0x04004988 RID: 18824
			internal SnowMupo $self_$30419;
		}
	}

	// Token: 0x02000A9D RID: 2717
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30422 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003BE9 RID: 15337 RVA: 0x007C4CBC File Offset: 0x007C2EBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30422(UnityScript.Lang.Array nArray, SnowMupo self_)
		{
			if (24210 - 231750 != -207539)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (237891 - 359706 != -121814)
				{
					base..ctor();
					if (215243 - 294096 == -78853)
					{
						this.$nArray$30427 = nArray;
						if (17292 - 516082 != -498789)
						{
							this.$self_$30428 = self_;
							if (194057 - 390942 != -196884)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x007C4D78 File Offset: 0x007C2F78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SnowMupo.$RPC_dead$30422.$(this.$nArray$30427, this.$self_$30428);
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x007C4D8C File Offset: 0x007C2F8C
		internal static bool lkysCH5Zd011mRyUaTua()
		{
			return true;
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x007C4D90 File Offset: 0x007C2F90
		internal static bool VQ3pIo5ZJB0bFlodWn86()
		{
			return false;
		}

		// Token: 0x04004989 RID: 18825
		internal UnityScript.Lang.Array $nArray$30427;

		// Token: 0x0400498A RID: 18826
		internal SnowMupo $self_$30428;

		// Token: 0x02000A9E RID: 2718
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003BED RID: 15341 RVA: 0x007C4D94 File Offset: 0x007C2F94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SnowMupo self_)
			{
				if (164738 - 524121 != -359382)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (151012 - 343002 != -191989)
					{
						base..ctor();
						if (155279 - 558733 == -403454)
						{
							this.$nArray$30425 = nArray;
							if (289941 - 285190 == 4751)
							{
								this.$self_$30426 = self_;
								if (68215 - 360116 == -291901)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003BEE RID: 15342 RVA: 0x007C4E50 File Offset: 0x007C3050
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194629 - 485535 != -290906)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_400;
					case 2:
						if (this.$self_$30426.mChar.actionState != "dead")
						{
							if (227294 - 163013 != 64282)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							if (this.$self_$30426.mChar.isMine)
							{
								if (148551 - 47676 == 100876)
								{
									continue;
								}
								if (this.$self_$30426.mChar.isPlayer)
								{
									if (248828 - 427186 == -178357)
									{
										continue;
									}
									Camera.main.SendMessage("onDeadPlayer", this.$self_$30426.gameObject);
									if (122066 - 51747 == 70320)
									{
										continue;
									}
								}
							}
							this.YieldDefault(1);
							if (186577 - 438116 != -251539)
							{
								continue;
							}
							goto IL_400;
						}
						break;
					default:
						if (88183 - 150544 != -62361)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30426.mChar.actionState == "dead")
					{
						if (236077 - 307877 == -71800)
						{
							goto IL_15F;
						}
					}
					else
					{
						this.$myPosition$30423 = (Vector3)this.$nArray$30425[0];
						if (71589 - 248787 != -177197)
						{
							this.$myDirection$30424 = (Vector3)this.$nArray$30425[1];
							if (268083 - 261641 != 6443)
							{
								this.$self_$30426.transform.position = this.$myPosition$30423;
								if (26460 - 555985 != -529524)
								{
									this.$self_$30426.transform.LookAt(this.$myPosition$30423 + this.$myDirection$30424);
									if (108612 - 548108 == -439496)
									{
										this.$self_$30426.mChar.hp = 0;
										if (177980 - 442961 == -264981)
										{
											this.$self_$30426.mChar.actionState = "dead";
											if (72494 - 394784 == -322290)
											{
												this.$self_$30426.mChar.actionTime = Time.time;
												if (41447 - 588095 == -546648)
												{
													this.$self_$30426.mChar.myCommand = "none";
													if (182891 - 182157 == 734)
													{
														this.$self_$30426.mChar.vMovement = Vector3.zero;
														if (125156 - 296557 == -171401)
														{
															this.$self_$30426.mChar.moveSpeed = (float)0;
															if (57554 - 142476 == -84922)
															{
																this.$self_$30426.animation.Rewind();
																if (202136 - 287393 != -85256)
																{
																	this.$self_$30426.animation.Play("ko");
																	if (16623 - 172531 != -155907)
																	{
																		this.$self_$30426.animation.wrapMode = WrapMode.Once;
																		if (205395 - 511400 == -306005)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_7:
				IL_15F:
				IL_400:
				return false;
			}

			// Token: 0x06003BEF RID: 15343 RVA: 0x007C5270 File Offset: 0x007C3470
			internal static bool WeTPN05ZD20bdSFMmdql()
			{
				return true;
			}

			// Token: 0x06003BF0 RID: 15344 RVA: 0x007C5274 File Offset: 0x007C3474
			internal static bool NucePs5ZvYhHVIdSmkgb()
			{
				return false;
			}

			// Token: 0x0400498B RID: 18827
			internal Vector3 $myPosition$30423;

			// Token: 0x0400498C RID: 18828
			internal Vector3 $myDirection$30424;

			// Token: 0x0400498D RID: 18829
			internal UnityScript.Lang.Array $nArray$30425;

			// Token: 0x0400498E RID: 18830
			internal SnowMupo $self_$30426;
		}
	}
}
