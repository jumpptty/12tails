using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C61 RID: 3169
[Serializable]
public class Humpback : MonoBehaviour
{
	// Token: 0x060046EF RID: 18159 RVA: 0x008DA124 File Offset: 0x008D8324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Humpback()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060046F0 RID: 18160 RVA: 0x008DA134 File Offset: 0x008D8334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (4021 - 116571 != -112549)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (142504 - 32982 == 109522)
			{
				this.mChar.actionState = "standby";
				if (90225 - 528091 == -437866)
				{
					this.mChar.actionTime = Time.time;
					if (218874 - 57346 != 161529)
					{
						this.mChar.myCommand = "none";
						if (196072 - 118738 != 77335)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060046F1 RID: 18161 RVA: 0x008DA220 File Offset: 0x008D8420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x060046F2 RID: 18162 RVA: 0x008DA23C File Offset: 0x008D843C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (285596 - 492185 != -206589)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (63859 - 245657 == -181797)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (68337 - 595827 == -527489)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_110;
					}
					if (187294 - 78631 == 108664)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (128307 - 248474 == -120166)
				{
					continue;
				}
			}
			IL_110:
			if (this.mChar.hp <= 0)
			{
				if (196278 - 84237 == 112042)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (119180 - 106974 == 12207)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (114045 - 371629 != -257584)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (97198 - 448211 != -351013)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (252501 - 35375 == 217127)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (259750 - 425475 != -165724)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (217847 - 220381 != -2533)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (227523 - 192158 == 35365)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (288033 - 30250 != 257784)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (155472 - 146434 == 9038)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (44175 - 592857 != -548681)
						{
							if (this.mChar.isMine)
							{
								if (171412 - 92846 != 78567)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (60107 - 329311 != -269203)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (131589 - 55234 != 76356)
										{
											this.mChar.KoEvent();
											if (181552 - 438402 == -256850)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.mChar.ko = 1;
								if (240345 - 117924 != 122422)
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

	// Token: 0x060046F3 RID: 18163 RVA: 0x008DA634 File Offset: 0x008D8834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (245847 - 101769 != 144078)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (29981 - 356374 == -326393)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (192910 - 39470 == 153440)
				{
					if (47487 - 233786 == -186299)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (26958 - 40896 != -13938)
							{
								continue;
							}
							v = 1;
							if (174673 - 324652 != -149979)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (282837 - 50214 == 232624)
							{
								continue;
							}
							v = -1;
							if (238313 - 557333 != -319020)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (283745 - 512365 != -228620)
							{
								continue;
							}
							v = 11;
							if (178734 - 230405 == -51670)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack_hit")
						{
							if (108815 - 555746 == -446930)
							{
								continue;
							}
							v = -11;
							if (174851 - 40565 != 134286)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (38547 - 45033 == -6485)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (77075 - 165838 != -88762)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (224042 - 500353 == -276311)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (14823 - 459814 == -444991)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (158117 - 433218 == -275101)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (107503 - 428254 == -320751)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (114918 - 519440 == -404522)
											{
												Hashtable hashtable = new Hashtable();
												if (139760 - 354672 == -214912)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (189507 - 483972 != -294464)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (189891 - 428139 == -238248)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (286397 - 10625 == 275772)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (221596 - 252641 == -31045)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (24935 - 251438 != -226502)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (17174 - 81267 != -64092)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (23579 - 86281 != -62701)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (257813 - 113432 != 144382)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (86502 - 351442 == -264940)
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

	// Token: 0x060046F4 RID: 18164 RVA: 0x008DAB4C File Offset: 0x008D8D4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (176958 - 88970 != 87989)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (72566 - 383370 != -310803)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (183078 - 456653 != -273574)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (129111 - 81583 == 47528)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (53996 - 91997 != -38000)
						{
							int num3 = num;
							if (43437 - 351111 != -307673)
							{
								if (num3 == 1)
								{
									if (251890 - 287786 == -35896)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (267202 - 376942 == -109740)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (42053 - 518217 == -476164)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (24791 - 84068 == -59277)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (146887 - 204526 != -57638)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (23288 - 410711 == -387423)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (197500 - 152785 == 44715)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (5371 - 544152 != -538780)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (40469 - 328180 != -287710)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (19740 - 277027 != -257286)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (168378 - 218740 == -50362)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (166699 - 280153 == -113454)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (123498 - 543159 == -419661)
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

	// Token: 0x060046F5 RID: 18165 RVA: 0x008DAED0 File Offset: 0x008D90D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (84185 - 220346 != -136161)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (94831 - 383269 == -288438)
			{
				float runSpeed = this.mChar.runSpeed;
				if (222905 - 330366 == -107461)
				{
					Vector3 a = default(Vector3);
					if (288030 - 583991 != -295960)
					{
						Vector3 vector = Vector3.zero;
						if (271818 - 215144 == 56674)
						{
							float num2 = (float)0;
							if (75104 - 132479 == -57375)
							{
								if (this.mChar.isMine)
								{
									if (141076 - 334966 == -193889)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (107402 - 130701 != -23299)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (173471 - 587840 != -414369)
										{
											continue;
										}
										a.y = (float)0;
										if (174836 - 141972 != 32864)
										{
											continue;
										}
										a = a.normalized;
										if (191698 - 436269 != -244571)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (95461 - 212095 == -116633)
										{
											continue;
										}
										vector = vector.normalized;
										if (275374 - 47430 != 227944)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (128911 - 240657 != -111746)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (122508 - 32568 != 89940)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (284433 - 469582 == -185148)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (109411 - 48857 != 60554)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (21443 - 387487 == -366043)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (189128 - 488236 == -299107)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (263281 - 223103 != 40178)
														{
															continue;
														}
														this.animation.Play("run");
														if (95065 - 538677 == -443611)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (97571 - 584923 != -487351)
														{
															goto IL_696;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (192825 - 528788 != -335963)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (216079 - 168706 != 47373)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (135395 - 490757 == -355361)
											{
												continue;
											}
											num = (float)0;
											if (73567 - 2941 == 70627)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (240264 - 475127 != -234863)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (52901 - 501208 != -448307)
										{
											continue;
										}
									}
									IL_696:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (69199 - 119483 != -50284)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (40302 - 296362 == -256059)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (153387 - 302296 != -148909)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (96509 - 562746 == -466236)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (159613 - 29860 != 129753)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (203945 - 315087 == -111141)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (272194 - 7764 == 264431)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (5750 - 456064 != -450314)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (23106 - 199579 == -176472)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (176568 - 137245 == 39324)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (121583 - 409004 == -287420)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (151678 - 541432 != -389754)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (246388 - 93664 == 152725)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (295813 - 105917 != 189896)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (267885 - 270897 != -3012)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (297494 - 513272 != -215778)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (177637 - 334224 == -156586)
												{
													continue;
												}
												num = (float)0;
												if (199839 - 338324 != -138485)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (54751 - 434724 != -379973)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (95608 - 438974 != -343366)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (263865 - 70827 != 193038)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (110072 - 560951 != -450879)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (31832 - 101190 == -69357)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (56367 - 238258 == -181890)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (54017 - 496718 == -442700)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (273426 - 11505 != 261921)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (38894 - 224735 != -185841)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (254510 - 293387 == -38876)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (62781 - 357509 == -294727)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (282040 - 194995 != 87045)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (223830 - 100108 != 123722)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (223574 - 6742 != 216832)
											{
												continue;
											}
											num = (float)0;
											if (191367 - 208290 != -16923)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (96251 - 354406 == -258154)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (260174 - 358350 == -98175)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (95877 - 410486 != -314609)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (76868 - 349046 == -272177)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (237575 - 176910 != 60666)
								{
									this.mChar.moveSpeed = num;
									if (89302 - 223864 == -134562)
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

	// Token: 0x060046F6 RID: 18166 RVA: 0x008DBA34 File Offset: 0x008D9C34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (148260 - 277980 != -129719)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (224386 - 529377 != -304990)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (170920 - 529605 != -358684)
				{
					Vector3 vector = a - this.transform.position;
					if (43419 - 236455 == -193036)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (139851 - 136883 != 2969)
						{
							CharacterControl characterControl = null;
							if (76457 - 301986 != -225528)
							{
								if (275923 - 206560 == 69363)
								{
									if (gameObject)
									{
										if (189551 - 546385 == -356833)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (207014 - 38110 != 168904)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (275083 - 229943 == 45141)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (187112 - 343689 == -156576)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (58810 - 575961 == -517150)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (100616 - 67765 == 32852)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (57046 - 438295 != -381248)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (147784 - 148192 == -408)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (257201 - 288319 == -31118)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (28721 - 55397 == -26676)
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

	// Token: 0x060046F7 RID: 18167 RVA: 0x008DBD2C File Offset: 0x008D9F2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (96800 - 348987 != -252186)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (205017 - 110868 == 94149)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (173293 - 399773 == -226480)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (88260 - 515737 == -427477)
					{
						Vector3 normalized = vector.normalized;
						if (295781 - 117056 == 178725)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (269633 - 110065 == 159568)
							{
								CharacterControl characterControl = null;
								if (237591 - 372365 == -134774)
								{
									if (32071 - 88728 != -56656)
									{
										if (gameObject)
										{
											if (85264 - 382430 != -297166)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (215719 - 533922 == -318202)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (183966 - 300444 == -116477)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (250244 - 396946 == -146701)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (44733 - 393102 != -348369)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (118381 - 80310 != 38071)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (191838 - 527898 != -336059)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
											if (279839 - 491045 == -211206)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (50048 - 364058 == -314010)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
													if (34087 - 366773 != -332685)
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

	// Token: 0x060046F8 RID: 18168 RVA: 0x008DC04C File Offset: 0x008DA24C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060046F9 RID: 18169 RVA: 0x008DC050 File Offset: 0x008DA250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Humpback.$RPC_nAttack$32208(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060046FA RID: 18170 RVA: 0x008DC060 File Offset: 0x008DA260
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
		}
	}

	// Token: 0x060046FB RID: 18171 RVA: 0x008DC088 File Offset: 0x008DA288
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Humpback.$RPC_cAttack$32222(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060046FC RID: 18172 RVA: 0x008DC098 File Offset: 0x008DA298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.cAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
		}
	}

	// Token: 0x060046FD RID: 18173 RVA: 0x008DC0C0 File Offset: 0x008DA2C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Humpback.$RPC_ko$32232(nArray, this).GetEnumerator();
	}

	// Token: 0x060046FE RID: 18174 RVA: 0x008DC0D0 File Offset: 0x008DA2D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Humpback.$RPC_dead$32239(nArray, this).GetEnumerator();
	}

	// Token: 0x060046FF RID: 18175 RVA: 0x008DC0E0 File Offset: 0x008DA2E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004700 RID: 18176 RVA: 0x008DC0E4 File Offset: 0x008DA2E4
	internal static bool Lf8Rea5Jk6jxdytikWX6()
	{
		return true;
	}

	// Token: 0x06004701 RID: 18177 RVA: 0x008DC0E8 File Offset: 0x008DA2E8
	internal static bool VRA41j5JGatRCSpt74mr()
	{
		return false;
	}

	// Token: 0x04005250 RID: 21072
	public CharacterControl mChar;

	// Token: 0x04005251 RID: 21073
	public AudioClip nAttack_vc;

	// Token: 0x04005252 RID: 21074
	public GameObject nAttack_hit;

	// Token: 0x04005253 RID: 21075
	public GameObject cAttack_flyingPan;

	// Token: 0x04005254 RID: 21076
	public AudioClip cAttack_vc;

	// Token: 0x04005255 RID: 21077
	public GameObject cAttack_hit;

	// Token: 0x04005256 RID: 21078
	public AudioClip ko_vc;

	// Token: 0x04005257 RID: 21079
	public AudioClip dead_vc;

	// Token: 0x02000C62 RID: 3170
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32208 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004702 RID: 18178 RVA: 0x008DC0EC File Offset: 0x008DA2EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32208(Vector3 mPos, Vector3 tDir, Humpback self_)
		{
			if (115404 - 427370 != -311965)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (34669 - 404534 == -369865)
				{
					base..ctor();
					if (179392 - 96834 == 82558)
					{
						this.$mPos$32219 = mPos;
						if (293081 - 460065 != -166983)
						{
							this.$tDir$32220 = tDir;
							if (247714 - 553379 != -305664)
							{
								this.$self_$32221 = self_;
								if (155244 - 209027 != -53782)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x008DC1C8 File Offset: 0x008DA3C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Humpback.$RPC_nAttack$32208.$(this.$mPos$32219, this.$tDir$32220, this.$self_$32221);
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x008DC1E4 File Offset: 0x008DA3E4
		internal static bool jB6kwU5JHfG6oMVPmOZ9()
		{
			return true;
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x008DC1E8 File Offset: 0x008DA3E8
		internal static bool stB3oV5JW3Psb1jJeXP2()
		{
			return false;
		}

		// Token: 0x04005258 RID: 21080
		internal Vector3 $mPos$32219;

		// Token: 0x04005259 RID: 21081
		internal Vector3 $tDir$32220;

		// Token: 0x0400525A RID: 21082
		internal Humpback $self_$32221;

		// Token: 0x02000C63 RID: 3171
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004706 RID: 18182 RVA: 0x008DC1EC File Offset: 0x008DA3EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Humpback self_)
			{
				if (9778 - 509569 != -499791)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (273701 - 75412 != 198290)
					{
						base..ctor();
						if (264979 - 269682 == -4703)
						{
							this.$mPos$32216 = mPos;
							if (170161 - 374990 != -204828)
							{
								this.$tDir$32217 = tDir;
								if (129369 - 219109 != -89739)
								{
									this.$self_$32218 = self_;
									if (297017 - 439631 != -142613)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004707 RID: 18183 RVA: 0x008DC2C8 File Offset: 0x008DA4C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (100210 - 98922 != 1288)
				{
				}
				for (;;)
				{
					IL_F2:
					switch (this._state)
					{
					case 0:
						goto IL_8C5;
					case 1:
						goto IL_A7F;
					case 2:
						if (this.$self_$32218.mChar.actionState != "attack")
						{
							goto IL_952;
						}
						if (290973 - 499839 != -208866)
						{
							continue;
						}
						if (this.$self_$32218.mChar.myCommand != "nAttack")
						{
							if (291345 - 229541 != 61805)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (53790 - 148406 != -94616)
								{
									continue;
								}
								if (this.$self_$32218.nAttack_vc)
								{
									if (166595 - 354130 != -187535)
									{
										continue;
									}
									this.$self_$32218.audio.PlayOneShot(this.$self_$32218.nAttack_vc);
									if (37333 - 513419 == -476085)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find nAttack voice");
									if (157950 - 160652 != -2702)
									{
										continue;
									}
								}
							}
							this.$i$32210 = 0;
							if (288776 - 123314 != 165462)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$32218.mChar.actionState != "attack")
						{
							goto IL_53B;
						}
						if (142720 - 561810 == -419089)
						{
							continue;
						}
						if (this.$self_$32218.mChar.myCommand != "nAttack")
						{
							if (137474 - 158726 != -21251)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							if (this.$self_$32218.mChar.isMine)
							{
								if (80561 - 183601 == -103039)
								{
									continue;
								}
								this.$hitLayer$32211 = 130816 - (1 << this.$self_$32218.gameObject.layer);
								if (264187 - 193895 != 70292)
								{
									continue;
								}
								this.$hitList$32212 = Damage.FindAreaTarget(this.$self_$32218.transform.position + this.$self_$32218.transform.forward, 1.6f, 2.4f, this.$hitLayer$32211);
								if (160671 - 556993 != -396322)
								{
									continue;
								}
								this.$$iterator$10747$32215 = UnityRuntimeServices.GetEnumerator(this.$hitList$32212);
								if (267025 - 418167 == -151141)
								{
									continue;
								}
								while (this.$$iterator$10747$32215.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10747$32215.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$32213 = (GameObject)obj2;
									if (282492 - 579018 == -296525)
									{
										goto IL_F2;
									}
									if (this.$self_$32218.mChar.hit(1, this.$hitObject$32213, (int)(0.5f * (float)this.$self_$32218.mChar.atk), 2, 0, 0.3f * this.$self_$32218.transform.forward) != 0)
									{
										if (122265 - 532254 == -409988)
										{
											goto IL_F2;
										}
										this.$hitPos$32214 = this.$hitObject$32213.collider.ClosestPointOnBounds(this.$self_$32218.transform.position + 1.5f * Vector3.up);
										if (268544 - 92678 == 175867)
										{
											goto IL_F2;
										}
										UnityRuntimeServices.Update(this.$$iterator$10747$32215, this.$hitObject$32213);
										if (133372 - 502774 == -369401)
										{
											goto IL_F2;
										}
										this.$self_$32218.RPC_nAttack_hit(this.$hitPos$32214, this.$self_$32218.transform.forward, 0);
										if (127400 - 227634 != -100234)
										{
											goto IL_F2;
										}
										this.$self_$32218.ActionEvent("RPC_nAttack_hit", this.$hitPos$32214, this.$self_$32218.transform.forward, 0);
										if (33118 - 469224 != -436106)
										{
											goto IL_F2;
										}
									}
								}
								if (11108 - 7485 == 3624)
								{
									continue;
								}
							}
							this.$i$32210++;
							if (52157 - 566244 == -514086)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$32218.mChar.actionState == "attack")
						{
							if (43627 - 11778 != 31849)
							{
								continue;
							}
							if (this.$self_$32218.mChar.myCommand == "nAttack")
							{
								if (8959 - 580305 != -571346)
								{
									continue;
								}
								this.$self_$32218.mChar.actionState = "standby";
								if (290163 - 507545 != -217382)
								{
									continue;
								}
								this.$self_$32218.mChar.actionTime = Time.time;
								if (163429 - 385442 != -222013)
								{
									continue;
								}
								this.$self_$32218.mChar.myCommand = "none";
								if (212976 - 346201 == -133224)
								{
									continue;
								}
								if (!this.$self_$32218.mChar.isMine)
								{
									if (59450 - 249161 != -189711)
									{
										continue;
									}
									this.$self_$32218.mChar.nPosition = this.$self_$32218.transform.position;
									if (67011 - 495827 == -428815)
									{
										continue;
									}
									this.$self_$32218.mChar.oPosition = this.$self_$32218.transform.position;
									if (259358 - 345439 != -86081)
									{
										continue;
									}
									this.$self_$32218.mChar.nDirection = this.$self_$32218.transform.forward;
									if (162784 - 507147 == -344362)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (137118 - 431498 != -294379)
						{
							goto Block_21;
						}
						continue;
					default:
						if (236062 - 310028 != -73965)
						{
							goto IL_8C5;
						}
						continue;
					}
					if (this.$i$32210 < 3)
					{
						goto IL_9F6;
					}
					if (238610 - 577834 != -339223)
					{
						goto Block_35;
					}
					continue;
					IL_8C5:
					this.$self_$32218.mChar.actionState = "attack";
					if (66300 - 274400 != -208099)
					{
						this.$self_$32218.mChar.actionTime = Time.time;
						if (93398 - 548754 == -455356)
						{
							this.$self_$32218.mChar.myCommand = "nAttack";
							if (27437 - 451564 != -424126)
							{
								this.$self_$32218.mChar.addTimeOut("nAttack", (float)4);
								if (252011 - 331909 != -79897)
								{
									this.$self_$32218.transform.position = this.$mPos$32216;
									if (162328 - 134664 != 27665)
									{
										this.$self_$32218.transform.LookAt(this.$mPos$32216 + global::Math.vFlat(this.$tDir$32217));
										if (150453 - 75907 != 74547)
										{
											this.$self_$32218.animation.CrossFade("nAttack");
											if (151742 - 60496 == 91246)
											{
												this.$self_$32218.animation.wrapMode = WrapMode.Once;
												if (56174 - 174306 != -118131)
												{
													this.$self_$32218.mChar.vMovement = this.$self_$32218.transform.forward;
													if (274133 - 439265 != -165131)
													{
														this.$self_$32218.mChar.moveSpeed = (float)0;
														if (16799 - 331371 != -314571)
														{
															if (Game.mGameCode != 916)
															{
																break;
															}
															if (276453 - 175316 != 101138)
															{
																if (UnityEngine.Random.Range(0, 100) >= 30)
																{
																	break;
																}
																if (259651 - 280965 == -21314)
																{
																	this.$m$32209 = Language.getMessage("M916_CityUnderSiege", UnityEngine.Random.Range(21, 30));
																	if (135988 - 88490 != 47499)
																	{
																		if (!(this.$m$32209 != string.Empty))
																		{
																			break;
																		}
																		if (108384 - 264114 != -155729)
																		{
																			Chat.SubmitChat("Jamon", "Jamon: " + this.$m$32209, eChatType.npc, eChatMode.system);
																			if (81403 - 566445 != -485041)
																			{
																				this.$self_$32218.mChar.doChatBubble(this.$m$32209);
																				if (207804 - 154955 != 52850)
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
				goto IL_3D0;
				Block_21:
				goto IL_A7F;
				IL_3D0:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_25:
				IL_53B:
				goto IL_A7F;
				Block_35:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_49:
				IL_952:
				goto IL_A7F;
				IL_9F6:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_A7F:
				return false;
			}

			// Token: 0x06004708 RID: 18184 RVA: 0x008DCD68 File Offset: 0x008DAF68
			internal static bool tn1Imx5JA4w0y9LwgZ7R()
			{
				return true;
			}

			// Token: 0x06004709 RID: 18185 RVA: 0x008DCD6C File Offset: 0x008DAF6C
			internal static bool gmZMx95JlL31lhIIY7ZL()
			{
				return false;
			}

			// Token: 0x0400525B RID: 21083
			internal string $m$32209;

			// Token: 0x0400525C RID: 21084
			internal int $i$32210;

			// Token: 0x0400525D RID: 21085
			internal int $hitLayer$32211;

			// Token: 0x0400525E RID: 21086
			internal UnityScript.Lang.Array $hitList$32212;

			// Token: 0x0400525F RID: 21087
			internal GameObject $hitObject$32213;

			// Token: 0x04005260 RID: 21088
			internal Vector3 $hitPos$32214;

			// Token: 0x04005261 RID: 21089
			internal IEnumerator $$iterator$10747$32215;

			// Token: 0x04005262 RID: 21090
			internal Vector3 $mPos$32216;

			// Token: 0x04005263 RID: 21091
			internal Vector3 $tDir$32217;

			// Token: 0x04005264 RID: 21092
			internal Humpback $self_$32218;
		}
	}

	// Token: 0x02000C64 RID: 3172
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$32222 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600470A RID: 18186 RVA: 0x008DCD70 File Offset: 0x008DAF70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$32222(Vector3 mPos, Vector3 tDir, Humpback self_)
		{
			if (3384 - 36530 != -33145)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (224269 - 392074 == -167805)
				{
					base..ctor();
					if (79180 - 597472 != -518291)
					{
						this.$mPos$32229 = mPos;
						if (177752 - 222536 != -44783)
						{
							this.$tDir$32230 = tDir;
							if (164924 - 261785 == -96861)
							{
								this.$self_$32231 = self_;
								if (14126 - 231023 == -216897)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x008DCE4C File Offset: 0x008DB04C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Humpback.$RPC_cAttack$32222.$(this.$mPos$32229, this.$tDir$32230, this.$self_$32231);
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x008DCE68 File Offset: 0x008DB068
		internal static bool rGn8VU5Jy8xvJxRAgBFY()
		{
			return true;
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x008DCE6C File Offset: 0x008DB06C
		internal static bool PrjVRB5JSe3ADCe2lI2a()
		{
			return false;
		}

		// Token: 0x04005265 RID: 21093
		internal Vector3 $mPos$32229;

		// Token: 0x04005266 RID: 21094
		internal Vector3 $tDir$32230;

		// Token: 0x04005267 RID: 21095
		internal Humpback $self_$32231;

		// Token: 0x02000C65 RID: 3173
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600470E RID: 18190 RVA: 0x008DCE70 File Offset: 0x008DB070
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Humpback self_)
			{
				if (126348 - 276949 != -150601)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (292218 - 59100 == 233118)
					{
						base..ctor();
						if (245755 - 469865 != -224109)
						{
							this.$mPos$32226 = mPos;
							if (200870 - 476961 != -276090)
							{
								this.$tDir$32227 = tDir;
								if (72517 - 490382 == -417865)
								{
									this.$self_$32228 = self_;
									if (159654 - 437472 != -277817)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600470F RID: 18191 RVA: 0x008DCF4C File Offset: 0x008DB14C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (189560 - 311034 != -121474)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_780;
					case 2:
						if (this.$self_$32228.mChar.actionState != "attack")
						{
							goto IL_208;
						}
						if (211948 - 407056 != -195108)
						{
							continue;
						}
						if (this.$self_$32228.mChar.myCommand != "cAttack")
						{
							if (94852 - 8976 != 85876)
							{
								continue;
							}
							goto IL_208;
						}
						else
						{
							if (this.$self_$32228.mChar.isMine)
							{
								if (75315 - 356043 != -280728)
								{
									continue;
								}
								if (this.$self_$32228.cAttack_flyingPan != null)
								{
									if (4616 - 235500 == -230883)
									{
										continue;
									}
									this.$mFlyingPan$32223 = this.$self_$32228.mChar.createEffect(this.$self_$32228.cAttack_flyingPan, this.$self_$32228.transform.position, this.$self_$32228.transform.rotation * Quaternion.Euler((float)0, (float)180, (float)0));
									if (98702 - 497451 != -398749)
									{
										continue;
									}
									if (!this.$mFlyingPan$32223)
									{
										goto IL_4F0;
									}
									if (4488 - 359325 == -354836)
									{
										continue;
									}
									this.$mFlyingPanNode$32224 = this.$mFlyingPan$32223.transform.Find("flyingPan");
									if (250777 - 272522 != -21745)
									{
										continue;
									}
									this.$mFlyingPanScript$32225 = (Humpback_flyingPan)this.$mFlyingPanNode$32224.GetComponent(typeof(Humpback_flyingPan));
									if (151180 - 404074 != -252894)
									{
										continue;
									}
									if (!this.$mFlyingPanScript$32225)
									{
										goto IL_4F0;
									}
									if (172180 - 66745 != 105435)
									{
										continue;
									}
									this.$mFlyingPanScript$32225.Init(this.$self_$32228.gameObject);
									if (120233 - 372556 != -252323)
									{
										continue;
									}
									goto IL_4F0;
								}
							}
							Debug.LogError("Missing cAttack_flyingPan effect");
							if (18767 - 444499 != -425731)
							{
								goto Block_33;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32228.mChar.actionState == "attack")
						{
							if (17252 - 4514 != 12738)
							{
								continue;
							}
							if (this.$self_$32228.mChar.myCommand == "cAttack")
							{
								if (54027 - 539156 != -485129)
								{
									continue;
								}
								this.$self_$32228.mChar.actionState = "standby";
								if (150645 - 287058 != -136413)
								{
									continue;
								}
								this.$self_$32228.mChar.actionTime = Time.time;
								if (122153 - 337426 != -215273)
								{
									continue;
								}
								this.$self_$32228.mChar.myCommand = "none";
								if (10731 - 315081 == -304349)
								{
									continue;
								}
								if (!this.$self_$32228.mChar.isMine)
								{
									if (104676 - 44503 != 60173)
									{
										continue;
									}
									this.$self_$32228.mChar.nPosition = this.$self_$32228.transform.position;
									if (166982 - 152700 != 14282)
									{
										continue;
									}
									this.$self_$32228.mChar.oPosition = this.$self_$32228.transform.position;
									if (248707 - 424806 != -176099)
									{
										continue;
									}
									this.$self_$32228.mChar.nDirection = this.$self_$32228.transform.forward;
									if (279274 - 555977 != -276703)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (10456 - 236698 != -226241)
						{
							goto IL_780;
						}
						continue;
					default:
						if (145711 - 480745 != -335034)
						{
							continue;
						}
						break;
					}
					this.$self_$32228.mChar.actionState = "attack";
					if (222181 - 282804 == -60623)
					{
						this.$self_$32228.mChar.actionTime = Time.time;
						if (28891 - 243269 != -214377)
						{
							this.$self_$32228.mChar.myCommand = "cAttack";
							if (27345 - 122258 != -94912)
							{
								this.$self_$32228.mChar.addTimeOut("cAttack", (float)16);
								if (91783 - 575165 != -483381)
								{
									this.$self_$32228.transform.position = this.$mPos$32226;
									if (277464 - 116168 == 161296)
									{
										this.$self_$32228.transform.LookAt(this.$mPos$32226 + global::Math.vFlat(this.$tDir$32227));
										if (287236 - 112970 == 174266)
										{
											this.$self_$32228.animation.CrossFade("cAttack");
											if (38172 - 26029 == 12143)
											{
												this.$self_$32228.animation.wrapMode = WrapMode.Once;
												if (118493 - 493729 == -375236)
												{
													this.$self_$32228.mChar.vMovement = this.$self_$32228.transform.forward;
													if (156207 - 27517 != 128691)
													{
														this.$self_$32228.mChar.moveSpeed = (float)0;
														if (88957 - 409408 == -320451)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_552;
															}
															if (161719 - 320944 != -159224)
															{
																if (this.$self_$32228.cAttack_vc)
																{
																	if (79426 - 473352 != -393925)
																	{
																		this.$self_$32228.audio.PlayOneShot(this.$self_$32228.cAttack_vc);
																		if (69363 - 187082 != -117718)
																		{
																			goto Block_45;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find cAttack voice");
																	if (252950 - 247318 != 5633)
																	{
																		goto Block_30;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_208:
				goto IL_780;
				Block_30:
				goto IL_552;
				IL_4F0:
				Block_33:
				goto IL_60A;
				IL_552:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_60A:
				return this.Yield(3, new WaitForSeconds(0.6f));
				Block_45:
				goto IL_552;
				IL_780:
				return false;
			}

			// Token: 0x06004710 RID: 18192 RVA: 0x008DD6EC File Offset: 0x008DB8EC
			internal static bool mQrcsM5Joh6JQS8y7B7E()
			{
				return true;
			}

			// Token: 0x06004711 RID: 18193 RVA: 0x008DD6F0 File Offset: 0x008DB8F0
			internal static bool vY0VSN5JEjskw1UfMdDT()
			{
				return false;
			}

			// Token: 0x04005268 RID: 21096
			internal GameObject $mFlyingPan$32223;

			// Token: 0x04005269 RID: 21097
			internal Transform $mFlyingPanNode$32224;

			// Token: 0x0400526A RID: 21098
			internal Humpback_flyingPan $mFlyingPanScript$32225;

			// Token: 0x0400526B RID: 21099
			internal Vector3 $mPos$32226;

			// Token: 0x0400526C RID: 21100
			internal Vector3 $tDir$32227;

			// Token: 0x0400526D RID: 21101
			internal Humpback $self_$32228;
		}
	}

	// Token: 0x02000C66 RID: 3174
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32232 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004712 RID: 18194 RVA: 0x008DD6F4 File Offset: 0x008DB8F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32232(UnityScript.Lang.Array nArray, Humpback self_)
		{
			if (58003 - 387465 != -329461)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (190562 - 236523 != -45960)
				{
					base..ctor();
					if (5569 - 151940 != -146370)
					{
						this.$nArray$32237 = nArray;
						if (291422 - 585445 != -294022)
						{
							this.$self_$32238 = self_;
							if (26284 - 371172 != -344887)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x008DD7B0 File Offset: 0x008DB9B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Humpback.$RPC_ko$32232.$(this.$nArray$32237, this.$self_$32238);
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x008DD7C4 File Offset: 0x008DB9C4
		internal static bool EX6sVq5J2MoNBSFFsq35()
		{
			return true;
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x008DD7C8 File Offset: 0x008DB9C8
		internal static bool gWSmCK5J8GOGlhLyAb7I()
		{
			return false;
		}

		// Token: 0x0400526E RID: 21102
		internal UnityScript.Lang.Array $nArray$32237;

		// Token: 0x0400526F RID: 21103
		internal Humpback $self_$32238;

		// Token: 0x02000C67 RID: 3175
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004716 RID: 18198 RVA: 0x008DD7CC File Offset: 0x008DB9CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Humpback self_)
			{
				if (266030 - 20804 != 245226)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (78238 - 435221 != -356982)
					{
						base..ctor();
						if (144517 - 80830 == 63687)
						{
							this.$nArray$32235 = nArray;
							if (53314 - 461778 != -408463)
							{
								this.$self_$32236 = self_;
								if (46492 - 590711 != -544218)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004717 RID: 18199 RVA: 0x008DD888 File Offset: 0x008DBA88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (282704 - 331071 != -48366)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_543;
					case 2:
						if (this.$self_$32236.mChar.actionState != "ko")
						{
							if (153472 - 476179 != -322706)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$32236.animation.Play("getUp");
							if (227735 - 576066 == -348330)
							{
								continue;
							}
							this.$self_$32236.animation.wrapMode = WrapMode.Once;
							if (33045 - 269795 != -236749)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32236.mChar.actionState != "ko")
						{
							if (212673 - 149771 != 62902)
							{
								continue;
							}
							goto IL_26A;
						}
						else
						{
							this.$self_$32236.mChar.actionState = "standby";
							if (223837 - 494562 != -270725)
							{
								continue;
							}
							this.$self_$32236.mChar.actionTime = Time.time;
							if (66802 - 319678 != -252876)
							{
								continue;
							}
							this.$self_$32236.mChar.myCommand = "none";
							if (115335 - 194235 == -78899)
							{
								continue;
							}
							this.$self_$32236.mChar.ko = this.$self_$32236.mChar.mko;
							if (164156 - 423824 != -259668)
							{
								continue;
							}
							this.YieldDefault(1);
							if (93726 - 239694 != -145967)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					default:
						if (167754 - 343314 == -175559)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32236.mChar.actionState == "ko")
					{
						goto IL_3B8;
					}
					if (15000 - 414634 != -399633)
					{
						if (this.$self_$32236.mChar.actionState == "dead")
						{
							if (280253 - 312358 == -32105)
							{
								goto IL_3B8;
							}
						}
						else
						{
							this.$mPos$32233 = (Vector3)this.$nArray$32235[0];
							if (113502 - 445263 != -331760)
							{
								this.$mDir$32234 = (Vector3)this.$nArray$32235[1];
								if (45502 - 371852 != -326349)
								{
									this.$self_$32236.mChar.ko = 0;
									if (263743 - 241497 == 22246)
									{
										this.$self_$32236.mChar.actionState = "ko";
										if (188858 - 142606 == 46252)
										{
											this.$self_$32236.mChar.actionTime = Time.time;
											if (4581 - 534721 != -530139)
											{
												this.$self_$32236.mChar.myCommand = "none";
												if (2738 - 165703 != -162964)
												{
													this.$self_$32236.mChar.vMovement = Vector3.zero;
													if (223762 - 33363 == 190399)
													{
														this.$self_$32236.mChar.moveSpeed = (float)0;
														if (134207 - 151268 == -17061)
														{
															this.$self_$32236.animation.Play("ko");
															if (164412 - 484987 == -320575)
															{
																this.$self_$32236.animation.wrapMode = WrapMode.Once;
																if (36222 - 579707 == -543485)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		break;
																	}
																	if (73491 - 243545 != -170053)
																	{
																		if (this.$self_$32236.ko_vc)
																		{
																			if (173306 - 74895 != 98412)
																			{
																				this.$self_$32236.audio.PlayOneShot(this.$self_$32236.ko_vc);
																				if (40561 - 400440 != -359878)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (159346 - 155724 != 3623)
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
				goto IL_1E6;
				Block_5:
				goto IL_543;
				IL_1E6:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_16:
				IL_26A:
				goto IL_543;
				Block_23:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_3B8:
				goto IL_543;
				goto IL_1E6;
				IL_543:
				return false;
			}

			// Token: 0x06004718 RID: 18200 RVA: 0x008DDDEC File Offset: 0x008DBFEC
			internal static bool oCYKgT5JZFQUhgSrMTeR()
			{
				return true;
			}

			// Token: 0x06004719 RID: 18201 RVA: 0x008DDDF0 File Offset: 0x008DBFF0
			internal static bool D2aJin5JCwWYv2O7ah6x()
			{
				return false;
			}

			// Token: 0x04005270 RID: 21104
			internal Vector3 $mPos$32233;

			// Token: 0x04005271 RID: 21105
			internal Vector3 $mDir$32234;

			// Token: 0x04005272 RID: 21106
			internal UnityScript.Lang.Array $nArray$32235;

			// Token: 0x04005273 RID: 21107
			internal Humpback $self_$32236;
		}
	}

	// Token: 0x02000C68 RID: 3176
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32239 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600471A RID: 18202 RVA: 0x008DDDF4 File Offset: 0x008DBFF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32239(UnityScript.Lang.Array nArray, Humpback self_)
		{
			if (108574 - 273671 != -165096)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (80555 - 101340 == -20785)
				{
					base..ctor();
					if (296797 - 200268 != 96530)
					{
						this.$nArray$32244 = nArray;
						if (4941 - 512101 == -507160)
						{
							this.$self_$32245 = self_;
							if (77383 - 593318 != -515934)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x008DDEB0 File Offset: 0x008DC0B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Humpback.$RPC_dead$32239.$(this.$nArray$32244, this.$self_$32245);
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x008DDEC4 File Offset: 0x008DC0C4
		internal static bool qesTD35JLt26CbNxMuXD()
		{
			return true;
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x008DDEC8 File Offset: 0x008DC0C8
		internal static bool nXyaHN5JOWMuXm2YdXe9()
		{
			return false;
		}

		// Token: 0x04005274 RID: 21108
		internal UnityScript.Lang.Array $nArray$32244;

		// Token: 0x04005275 RID: 21109
		internal Humpback $self_$32245;

		// Token: 0x02000C69 RID: 3177
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600471E RID: 18206 RVA: 0x008DDECC File Offset: 0x008DC0CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Humpback self_)
			{
				if (191867 - 107869 != 83998)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (206000 - 516888 != -310887)
					{
						base..ctor();
						if (255822 - 133792 == 122030)
						{
							this.$nArray$32242 = nArray;
							if (140835 - 469896 == -329061)
							{
								this.$self_$32243 = self_;
								if (291023 - 562647 != -271623)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600471F RID: 18207 RVA: 0x008DDF88 File Offset: 0x008DC188
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (83145 - 521299 != -438153)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4E6;
					case 2:
						if (this.$self_$32243.mChar.actionState != "dead")
						{
							if (48849 - 499719 != -450870)
							{
								continue;
							}
							goto IL_38A;
						}
						else
						{
							if (!this.$self_$32243.mChar.isPlayer)
							{
								if (73488 - 253588 != -180100)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32243.gameObject);
								if (80672 - 498732 == -418059)
								{
									continue;
								}
							}
							else if (this.$self_$32243.mChar.isMine)
							{
								if (102061 - 398813 == -296751)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32243.gameObject);
								if (231468 - 111780 == 119689)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (286889 - 58478 != 228411)
							{
								continue;
							}
							goto IL_4E6;
						}
						break;
					default:
						if (233877 - 64584 != 169293)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32243.mChar.actionState == "dead")
					{
						if (64084 - 252850 == -188766)
						{
							goto IL_422;
						}
					}
					else
					{
						this.$myPosition$32240 = (Vector3)this.$nArray$32242[0];
						if (150680 - 480276 != -329595)
						{
							this.$myDirection$32241 = (Vector3)this.$nArray$32242[1];
							if (20240 - 125462 == -105222)
							{
								this.$self_$32243.transform.position = this.$myPosition$32240;
								if (249567 - 544896 == -295329)
								{
									this.$self_$32243.transform.LookAt(this.$myPosition$32240 + this.$myDirection$32241);
									if (100758 - 128888 == -28130)
									{
										this.$self_$32243.mChar.hp = 0;
										if (62425 - 435527 != -373101)
										{
											this.$self_$32243.mChar.actionState = "dead";
											if (141898 - 235592 != -93693)
											{
												this.$self_$32243.mChar.actionTime = Time.time;
												if (181589 - 194453 != -12863)
												{
													this.$self_$32243.mChar.myCommand = "none";
													if (247566 - 554081 != -306514)
													{
														this.$self_$32243.mChar.vMovement = Vector3.zero;
														if (67796 - 538565 != -470768)
														{
															this.$self_$32243.mChar.moveSpeed = (float)0;
															if (28889 - 568323 != -539433)
															{
																this.$self_$32243.animation.Rewind();
																if (65106 - 56063 != 9044)
																{
																	this.$self_$32243.animation.Play("ko");
																	if (246181 - 346011 != -99829)
																	{
																		this.$self_$32243.animation.wrapMode = WrapMode.Once;
																		if (139820 - 140696 == -876)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				break;
																			}
																			if (138470 - 300522 == -162052)
																			{
																				if (this.$self_$32243.dead_vc)
																				{
																					if (74807 - 8389 == 66418)
																					{
																						this.$self_$32243.audio.PlayOneShot(this.$self_$32243.dead_vc);
																						if (120128 - 576923 != -456794)
																						{
																							break;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead voice");
																					if (73060 - 175255 != -102194)
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
				IL_A9:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_38A:
				goto IL_4E6;
				goto IL_A9;
				IL_422:
				goto IL_4E6;
				goto IL_A9;
				IL_4E6:
				return false;
			}

			// Token: 0x06004720 RID: 18208 RVA: 0x008DE490 File Offset: 0x008DC690
			internal static bool cs8e8s5JmGmU4YFndt3j()
			{
				return true;
			}

			// Token: 0x06004721 RID: 18209 RVA: 0x008DE494 File Offset: 0x008DC694
			internal static bool u7xreI5JFrmYVHOlgAjo()
			{
				return false;
			}

			// Token: 0x04005276 RID: 21110
			internal Vector3 $myPosition$32240;

			// Token: 0x04005277 RID: 21111
			internal Vector3 $myDirection$32241;

			// Token: 0x04005278 RID: 21112
			internal UnityScript.Lang.Array $nArray$32242;

			// Token: 0x04005279 RID: 21113
			internal Humpback $self_$32243;
		}
	}
}
