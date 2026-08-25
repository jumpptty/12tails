using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000AA0 RID: 2720
[Serializable]
public class CamBot : MonoBehaviour
{
	// Token: 0x06003BFC RID: 15356 RVA: 0x007C6664 File Offset: 0x007C4864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CamBot()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003BFD RID: 15357 RVA: 0x007C6674 File Offset: 0x007C4874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (116641 - 537829 != -421188)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (188428 - 312159 == -123731)
			{
				this.mChar.actionState = "standby";
				if (71038 - 475377 == -404339)
				{
					this.mChar.actionTime = Time.time;
					if (286305 - 141636 == 144669)
					{
						this.mChar.myCommand = "none";
						if (114505 - 54729 != 59777)
						{
							this.mChar.hp = (this.mChar.mhp = 550);
							if (189378 - 266410 != -77031)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003BFE RID: 15358 RVA: 0x007C6798 File Offset: 0x007C4998
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06003BFF RID: 15359 RVA: 0x007C67B4 File Offset: 0x007C49B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (237448 - 72435 != 165013)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (112008 - 262484 != -150476)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (292273 - 5862 == 286412)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_2C5;
					}
					if (96132 - 553003 != -456871)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (45571 - 129070 != -83499)
				{
					continue;
				}
			}
			IL_2C5:
			if (this.mChar.hp <= 0)
			{
				if (76143 - 295893 == -219749)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (21189 - 369044 != -347855)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (32630 - 411807 == -379176)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (230892 - 67120 != 163772)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (269469 - 63686 == 205784)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (63141 - 162539 != -99397)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (13845 - 117254 != -103408)
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
			if (109830 - 496032 == -386202)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (205098 - 123986 == 81112)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (240188 - 152600 == 87588)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (104774 - 85433 != 19342)
						{
							if (this.mChar.isMine)
							{
								if (34974 - 18027 == 16947)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (54511 - 564573 == -510062)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (114048 - 253879 != -139830)
										{
											this.mChar.KoEvent();
											if (275892 - 63916 == 211976)
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
								if (194314 - 84113 == 110201)
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

	// Token: 0x06003C00 RID: 15360 RVA: 0x007C6BAC File Offset: 0x007C4DAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (202710 - 220379 != -17668)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (72712 - 163285 != -90572)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (145979 - 79658 != 66322 && 135471 - 305014 != -169542)
				{
					if (ActionName == "RPC_laser")
					{
						if (121062 - 462938 == -341875)
						{
							continue;
						}
						v = 1;
						if (89944 - 207344 == -117399)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_laserBackward")
					{
						if (254209 - 338134 != -83925)
						{
							continue;
						}
						v = 2;
						if (208466 - 3870 == 204597)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_laser_fire")
					{
						if (169199 - 5335 != 163864)
						{
							continue;
						}
						v = 3;
						if (22649 - 345875 == -323225)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_emp")
					{
						if (103162 - 498149 != -394987)
						{
							continue;
						}
						v = 10;
						if (202144 - 425592 != -223448)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_escape")
					{
						if (138860 - 83471 == 55390)
						{
							continue;
						}
						v = 20;
						if (286285 - 262865 == 23421)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (72945 - 347542 != -274597)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (30949 - 519148 == -488199)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (6785 - 206197 != -199411)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (176934 - 450242 == -273308)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (149516 - 129121 != 20396)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (134 - 481995 != -481860)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (250873 - 143716 != 107158)
										{
											Hashtable hashtable = new Hashtable();
											if (59550 - 161412 == -101862)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (144263 - 453408 == -309145)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (222567 - 39565 != 183003)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (149379 - 389714 != -240334)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (91673 - 567491 == -475818)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (81463 - 508321 != -426857)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (74604 - 212830 != -138225)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (18646 - 292076 == -273430)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (79624 - 17025 != 62600)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (3625 - 489190 == -485565)
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

	// Token: 0x06003C01 RID: 15361 RVA: 0x007C710C File Offset: 0x007C530C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (92796 - 122138 != -29342)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (266012 - 494085 != -228072)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (269498 - 599808 != -330309)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (219973 - 360787 != -140813)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (160677 - 306118 != -145440)
						{
							int num3 = num;
							if (284561 - 371385 != -86823)
							{
								if (num3 == 1)
								{
									if (220594 - 499282 == -278688)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (168751 - 451408 == -282657)
										{
											this.StartCoroutine_Auto(this.RPC_laser(vector, vector2, num2));
											if (48653 - 435651 != -386997)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (296727 - 577563 == -280836)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (166089 - 509361 != -343271)
										{
											this.StartCoroutine_Auto(this.RPC_laserBackward(vector, vector2, num2));
											if (170187 - 477808 != -307620)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (82689 - 18379 == 64310)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (186282 - 390703 != -204420)
										{
											this.RPC_laser_fire(vector, vector2, num2);
											if (221377 - 346430 != -125052)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 10)
								{
									if (193794 - 217694 == -23900)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (243420 - 368096 == -124676)
										{
											this.StartCoroutine_Auto(this.RPC_emp(vector, vector2, num2));
											if (87733 - 162651 == -74918)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 20)
								{
									if (246664 - 273577 == -26913)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (145177 - 178895 != -33717)
										{
											this.RPC_escape(vector, vector2, num2);
											if (136049 - 65019 == 71030)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (290699 - 186806 == 103893)
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

	// Token: 0x06003C02 RID: 15362 RVA: 0x007C750C File Offset: 0x007C570C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (195723 - 569240 != -373516)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (84841 - 477170 == -392329)
			{
				float runSpeed = this.mChar.runSpeed;
				if (172662 - 576185 != -403522)
				{
					Vector3 a = default(Vector3);
					if (134654 - 200459 == -65805)
					{
						Vector3 vector = Vector3.zero;
						if (186658 - 487632 != -300973)
						{
							float num2 = (float)0;
							if (253227 - 16427 == 236800)
							{
								if (this.mChar.isMine)
								{
									if (277847 - 316457 != -38610)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (157694 - 411970 != -254276)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (47377 - 96299 == -48921)
										{
											continue;
										}
										a.y = (float)0;
										if (64909 - 266349 != -201440)
										{
											continue;
										}
										a = a.normalized;
										if (244620 - 583241 != -338621)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (240128 - 555045 != -314917)
										{
											continue;
										}
										vector = vector.normalized;
										if (286647 - 299687 != -13040)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (80048 - 246137 == -166088)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (275084 - 510379 != -235295)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (3515 - 1186 != 2329)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (101520 - 402996 != -301476)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (130951 - 118234 != 12717)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (181925 - 4392 == 177534)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (129181 - 15023 != 114158)
														{
															continue;
														}
														this.animation.Play("run");
														if (207499 - 146250 != 61249)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (248753 - 532413 != -283659)
														{
															goto IL_74;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (246615 - 75814 != 170801)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (168975 - 492306 != -323331)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (169861 - 325642 == -155780)
											{
												continue;
											}
											num = (float)0;
											if (229358 - 462627 == -233268)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (279748 - 557393 != -277645)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (211538 - 536211 == -324672)
										{
											continue;
										}
									}
									IL_74:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (128020 - 451226 != -323206)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (159728 - 41330 == 118399)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (67577 - 508887 != -441310)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (139804 - 61280 != 78524)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (204242 - 441246 != -237004)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (246928 - 126648 != 120280)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (296615 - 366896 != -70281)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (105930 - 157036 != -51106)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (15812 - 263370 != -247558)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (293304 - 11583 == 281722)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (115717 - 492691 != -376974)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (150191 - 47557 == 102635)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (46303 - 548286 == -501982)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (166525 - 415865 != -249340)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (101137 - 56152 == 44986)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (267803 - 519430 != -251627)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (39909 - 573156 == -533246)
												{
													continue;
												}
												num = (float)0;
												if (164979 - 519486 != -354507)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (173773 - 210956 == -37182)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (118427 - 438986 != -320559)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (82246 - 198530 != -116284)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (13294 - 138247 != -124953)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (282407 - 137697 != 144710)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (90087 - 211273 != -121186)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (51730 - 370850 == -319119)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (164636 - 310414 != -145778)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (67025 - 224303 != -157278)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (10903 - 448990 == -438086)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (202114 - 477033 == -274918)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (56268 - 206950 != -150682)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (218573 - 348796 != -130223)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (230767 - 222346 != 8421)
											{
												continue;
											}
											num = (float)0;
											if (228976 - 239579 == -10602)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (287005 - 43415 != 243590)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (286838 - 174449 != 112389)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (256561 - 22715 == 233847)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (29736 - 424499 == -394762)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (35201 - 17086 != 18116)
								{
									this.mChar.moveSpeed = num;
									if (123965 - 135833 != -11867)
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

	// Token: 0x06003C03 RID: 15363 RVA: 0x007C8070 File Offset: 0x007C6270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (115481 - 187792 != -72310)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (292310 - 454804 == -162494)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (175639 - 562252 != -386612)
				{
					Vector3 vector = a - this.transform.position;
					if (134496 - 529127 != -394630)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (37503 - 290319 != -252815)
						{
							CharacterControl characterControl = null;
							if (132536 - 205418 == -72882)
							{
								int num = 0;
								if (123215 - 491470 == -368255)
								{
									if (gameObject)
									{
										if (136236 - 136476 != -240)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (241088 - 415210 == -174121)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (289193 - 559664 == -270470)
										{
											continue;
										}
										num = characterControl.ActorNr;
										if (260940 - 39471 == 221470)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (178259 - 69560 != 108699)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (113181 - 46524 != 66657)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (23731 - 496139 != -472407)
									{
										if (this.mChar.moveSpeed > (float)1)
										{
											if (99044 - 151445 == -52400)
											{
												continue;
											}
											if (num != 0)
											{
												if (228389 - 420631 != -192242)
												{
													continue;
												}
												this.StartCoroutine_Auto(this.RPC_laserBackward(this.transform.position, this.transform.forward, num));
												if (26822 - 577598 == -550775)
												{
													continue;
												}
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (110316 - 200083 != -89767)
												{
													continue;
												}
												this.ActionEvent("RPC_laserBackward", this.transform.position, this.transform.forward, num);
												if (213576 - 597293 != -383716)
												{
													break;
												}
												continue;
											}
										}
										this.StartCoroutine_Auto(this.RPC_laser(this.transform.position, vector, num));
										if (191614 - 39327 != 152288)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (12088 - 448879 != -436790)
											{
												this.ActionEvent("RPC_laser", this.transform.position, vector, num);
												if (148448 - 569697 == -421249)
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

	// Token: 0x06003C04 RID: 15364 RVA: 0x007C845C File Offset: 0x007C665C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (42594 - 424417 != -381822)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (195143 - 160737 != 34407)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (149236 - 573181 != -423944)
				{
					Vector3 vector = a - this.transform.position;
					if (2480 - 425079 != -422598)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (280283 - 5379 != 274905 && 171676 - 62282 != 109395)
						{
							if (gameObject)
							{
								if (16280 - 238370 == -222089)
								{
									continue;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (199311 - 305551 != -106240)
								{
									continue;
								}
							}
							if (!(this.mChar.actionState == "standby"))
							{
								if (128054 - 238410 == -110355)
								{
									continue;
								}
								if (!(this.mChar.actionState == "run"))
								{
									break;
								}
								if (125094 - 98028 == 27067)
								{
									continue;
								}
							}
							if (this.mChar.isTimeOut("emp") != (float)0)
							{
								break;
							}
							if (169193 - 616 == 168577)
							{
								this.StartCoroutine_Auto(this.RPC_emp(this.transform.position, this.transform.forward, 0));
								if (71838 - 402566 == -330728)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (286560 - 383535 == -96975)
									{
										this.ActionEvent("RPC_emp", this.transform.position, this.transform.forward, 0);
										if (170638 - 88287 != 82352)
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

	// Token: 0x06003C05 RID: 15365 RVA: 0x007C8704 File Offset: 0x007C6904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003C06 RID: 15366 RVA: 0x007C8708 File Offset: 0x007C6908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_laser(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CamBot.$RPC_laser$30429(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06003C07 RID: 15367 RVA: 0x007C8718 File Offset: 0x007C6918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_laserBackward(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CamBot.$RPC_laserBackward$30442(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06003C08 RID: 15368 RVA: 0x007C8728 File Offset: 0x007C6928
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_laser_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (59484 - 366038 != -306554)
		{
		}
		for (;;)
		{
			if (this.laser_fire)
			{
				if (88531 - 255606 == -167075)
				{
					Quaternion rotation = Quaternion.LookRotation(fireDir);
					if (138271 - 226240 == -87969)
					{
						GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.laser_fire, firePos, rotation);
						if (299313 - 237832 != 61482)
						{
							ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
							if (91685 - 526111 != -434425)
							{
								projectileControl.Init(this.mChar.ActorNr);
								if (232341 - 258027 != -25685)
								{
									projectileControl.life = (float)1 * this.mChar.rangeMod;
									if (26671 - 482992 != -456320)
									{
										CamBot_laser camBot_laser = (CamBot_laser)gameObject.GetComponent(typeof(CamBot_laser));
										if (175619 - 341723 != -166103)
										{
											camBot_laser.Init(this.gameObject);
											if (124482 - 65000 == 59482)
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
				Debug.Log("Cannot find Laser Effect");
				if (116760 - 462167 == -345407)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003C09 RID: 15369 RVA: 0x007C88E0 File Offset: 0x007C6AE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_emp(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CamBot.$RPC_emp$30455(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003C0A RID: 15370 RVA: 0x007C88F0 File Offset: 0x007C6AF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_escape(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (120230 - 67636 != 52595)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Destroy(this.gameObject);
			if (121362 - 462809 == -341447)
			{
				if (!this.mChar.isMine)
				{
					break;
				}
				if (176846 - 262749 != -85902)
				{
					Camera.main.SendMessage("onComBotEscape", this.gameObject);
					if (66266 - 552768 != -486501)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003C0B RID: 15371 RVA: 0x007C89A8 File Offset: 0x007C6BA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new CamBot.$RPC_ko$30467(nArray, this).GetEnumerator();
	}

	// Token: 0x06003C0C RID: 15372 RVA: 0x007C89B8 File Offset: 0x007C6BB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new CamBot.$RPC_dead$30474(nArray, this).GetEnumerator();
	}

	// Token: 0x06003C0D RID: 15373 RVA: 0x007C89C8 File Offset: 0x007C6BC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003C0E RID: 15374 RVA: 0x007C89CC File Offset: 0x007C6BCC
	internal static bool GyJB0b5ZqqrwhqcV1tdB()
	{
		return true;
	}

	// Token: 0x06003C0F RID: 15375 RVA: 0x007C89D0 File Offset: 0x007C6BD0
	internal static bool jCT3Jt5Z7E8H7I9mFefi()
	{
		return false;
	}

	// Token: 0x04004994 RID: 18836
	public CharacterControl mChar;

	// Token: 0x04004995 RID: 18837
	public GameObject laser_fire;

	// Token: 0x04004996 RID: 18838
	public GameObject emp;

	// Token: 0x04004997 RID: 18839
	public GameObject deadEffect;

	// Token: 0x02000AA1 RID: 2721
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_laser$30429 : GenericGenerator<object>
	{
		// Token: 0x06003C10 RID: 15376 RVA: 0x007C89D4 File Offset: 0x007C6BD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_laser$30429(Vector3 mPos, Vector3 tDir, int tID, CamBot self_)
		{
			if (284165 - 403778 != -119612)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (239244 - 510546 != -271301)
				{
					base..ctor();
					if (139681 - 314178 != -174496)
					{
						this.$mPos$30438 = mPos;
						if (51149 - 495441 == -444292)
						{
							this.$tDir$30439 = tDir;
							if (285567 - 579527 != -293959)
							{
								this.$tID$30440 = tID;
								if (256104 - 190974 != 65131)
								{
									this.$self_$30441 = self_;
									if (42981 - 395088 == -352107)
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

		// Token: 0x06003C11 RID: 15377 RVA: 0x007C8AD4 File Offset: 0x007C6CD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new CamBot.$RPC_laser$30429.$(this.$mPos$30438, this.$tDir$30439, this.$tID$30440, this.$self_$30441);
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x007C8AF4 File Offset: 0x007C6CF4
		internal static bool ANptme5ZP4bVquUGXwK3()
		{
			return true;
		}

		// Token: 0x06003C13 RID: 15379 RVA: 0x007C8AF8 File Offset: 0x007C6CF8
		internal static bool v05JCN5Z0RugRUjcNZyo()
		{
			return false;
		}

		// Token: 0x04004998 RID: 18840
		internal Vector3 $mPos$30438;

		// Token: 0x04004999 RID: 18841
		internal Vector3 $tDir$30439;

		// Token: 0x0400499A RID: 18842
		internal int $tID$30440;

		// Token: 0x0400499B RID: 18843
		internal CamBot $self_$30441;

		// Token: 0x02000AA2 RID: 2722
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x06003C14 RID: 15380 RVA: 0x007C8AFC File Offset: 0x007C6CFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, CamBot self_)
			{
				if (265119 - 273241 != -8121)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (10027 - 25357 != -15329)
					{
						base..ctor();
						if (106083 - 92462 == 13621)
						{
							this.$mPos$30434 = mPos;
							if (105584 - 119521 == -13937)
							{
								this.$tDir$30435 = tDir;
								if (127946 - 591289 == -463343)
								{
									this.$tID$30436 = tID;
									if (299889 - 529796 != -229906)
									{
										this.$self_$30437 = self_;
										if (171849 - 193916 != -22066)
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

			// Token: 0x06003C15 RID: 15381 RVA: 0x007C8BFC File Offset: 0x007C6DFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (214100 - 569940 != -355839)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_744;
					case 1:
						goto IL_87C;
					case 2:
						IL_235:
						if (Time.time >= this.$self_$30437.mChar.actionTime + 0.2f * (float)this.$i$30430)
						{
							if (207932 - 122423 == 85510)
							{
								continue;
							}
							if (this.$self_$30437.mChar.isMine)
							{
								if (271502 - 106973 == 164530)
								{
									continue;
								}
								this.$firePos$30432 = this.$self_$30437.transform.position + this.$self_$30437.transform.TransformDirection(new Vector3((float)0, (float)1, 0.5f));
								if (182088 - 22948 != 159140)
								{
									continue;
								}
								this.$fireDir$30433 = this.$tDir$30435 - this.$self_$30437.transform.TransformDirection(new Vector3((float)0, (float)1, 0.5f));
								if (55104 - 439600 == -384495)
								{
									continue;
								}
								if (this.$tObject$30431)
								{
									if (29618 - 61225 != -31607)
									{
										continue;
									}
									this.$fireDir$30433 = this.$tObject$30431.collider.bounds.center - this.$firePos$30432;
									if (154122 - 393751 == -239628)
									{
										continue;
									}
								}
								this.$self_$30437.RPC_laser_fire(this.$firePos$30432, this.$fireDir$30433, 0);
								if (122255 - 485334 == -363078)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (135552 - 306167 == -170614)
									{
										continue;
									}
									this.$self_$30437.ActionEvent("RPC_laser_fire", this.$firePos$30432, this.$fireDir$30433, 0);
									if (270288 - 476352 != -206064)
									{
										continue;
									}
								}
							}
							this.$i$30430++;
							if (31305 - 504223 == -472917)
							{
								continue;
							}
						}
						else
						{
							if (this.$self_$30437.mChar.actionState != "attack")
							{
								goto IL_277;
							}
							if (254560 - 499380 == -244819)
							{
								continue;
							}
							if (this.$self_$30437.mChar.myCommand != "laser")
							{
								if (219790 - 410799 != -191008)
								{
									goto Block_7;
								}
								continue;
							}
							else
							{
								if (!this.$tObject$30431)
								{
									goto IL_21F;
								}
								if (89199 - 314623 != -225424)
								{
									continue;
								}
								this.$self_$30437.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$tObject$30431.transform.position - this.$self_$30437.transform.position));
								if (273401 - 177608 != 95794)
								{
									goto Block_41;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$30437.mChar.actionState == "attack")
						{
							if (161688 - 567267 != -405579)
							{
								continue;
							}
							if (this.$self_$30437.mChar.myCommand == "laser")
							{
								if (174486 - 501852 == -327365)
								{
									continue;
								}
								this.$self_$30437.mChar.actionState = "standby";
								if (56276 - 329930 == -273653)
								{
									continue;
								}
								this.$self_$30437.mChar.actionTime = Time.time;
								if (236992 - 499947 != -262955)
								{
									continue;
								}
								this.$self_$30437.mChar.myCommand = "none";
								if (72092 - 97917 == -25824)
								{
									continue;
								}
								if (!this.$self_$30437.mChar.isMine)
								{
									if (258967 - 464851 != -205884)
									{
										continue;
									}
									this.$self_$30437.mChar.nPosition = this.$self_$30437.transform.position;
									if (172848 - 406032 != -233184)
									{
										continue;
									}
									this.$self_$30437.mChar.oPosition = this.$self_$30437.transform.position;
									if (225850 - 397739 != -171889)
									{
										continue;
									}
									this.$self_$30437.mChar.nDirection = this.$self_$30437.transform.forward;
									if (265945 - 556579 != -290634)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (26252 - 263125 != -236873)
						{
							continue;
						}
						goto IL_87C;
					default:
						if (171756 - 441484 != -269728)
						{
							continue;
						}
						goto IL_744;
					}
					IL_832:
					if (this.$i$30430 > 3)
					{
						if (297879 - 190583 != 107296)
						{
							continue;
						}
						goto IL_3F6;
					}
					else
					{
						this.$tObject$30431 = null;
						if (253755 - 36919 != 216836)
						{
							continue;
						}
						if (this.$tID$30436 != 0)
						{
							if (280284 - 290129 != -9845)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30436];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$30431 = (GameObject)obj2;
							if (289889 - 264489 == 25401)
							{
								continue;
							}
						}
						goto IL_235;
					}
					IL_744:
					this.$self_$30437.mChar.actionState = "attack";
					if (12650 - 69278 != -56627)
					{
						this.$self_$30437.mChar.actionTime = Time.time;
						if (38858 - 280179 != -241320)
						{
							this.$self_$30437.mChar.myCommand = "laser";
							if (206676 - 505557 != -298880)
							{
								this.$self_$30437.mChar.addTimeOut("nAttack", (float)5);
								if (200861 - 567448 == -366587)
								{
									this.$self_$30437.transform.position = this.$mPos$30434;
									if (136783 - 544175 == -407392)
									{
										this.$self_$30437.transform.LookAt(this.$mPos$30434 + global::Math.vFlat(this.$tDir$30435));
										if (113387 - 495861 == -382474)
										{
											this.$self_$30437.animation.Play("nAttack");
											if (238954 - 386202 != -147247)
											{
												this.$self_$30437.animation.wrapMode = WrapMode.Once;
												if (53209 - 387802 == -334593)
												{
													this.$self_$30437.mChar.vMovement = this.$self_$30437.transform.forward;
													if (286595 - 539912 != -253316)
													{
														this.$self_$30437.mChar.moveSpeed = (float)0;
														if (140555 - 591488 == -450933)
														{
															this.$i$30430 = 1;
															if (57994 - 451545 == -393551)
															{
																goto IL_832;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_277;
				IL_21F:
				return this.Yield(2, typeof(WaitForFixedUpdate));
				IL_277:
				goto IL_87C;
				IL_3F6:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_41:
				goto IL_21F;
				IL_87C:
				return false;
			}

			// Token: 0x06003C16 RID: 15382 RVA: 0x007C9498 File Offset: 0x007C7698
			internal static bool cx1qEe5ZbuX4scQa5baD()
			{
				return true;
			}

			// Token: 0x06003C17 RID: 15383 RVA: 0x007C949C File Offset: 0x007C769C
			internal static bool sxEoXQ5ZuIBwRnOSg5A4()
			{
				return false;
			}

			// Token: 0x0400499C RID: 18844
			internal int $i$30430;

			// Token: 0x0400499D RID: 18845
			internal GameObject $tObject$30431;

			// Token: 0x0400499E RID: 18846
			internal Vector3 $firePos$30432;

			// Token: 0x0400499F RID: 18847
			internal Vector3 $fireDir$30433;

			// Token: 0x040049A0 RID: 18848
			internal Vector3 $mPos$30434;

			// Token: 0x040049A1 RID: 18849
			internal Vector3 $tDir$30435;

			// Token: 0x040049A2 RID: 18850
			internal int $tID$30436;

			// Token: 0x040049A3 RID: 18851
			internal CamBot $self_$30437;
		}
	}

	// Token: 0x02000AA3 RID: 2723
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_laserBackward$30442 : GenericGenerator<object>
	{
		// Token: 0x06003C18 RID: 15384 RVA: 0x007C94A0 File Offset: 0x007C76A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_laserBackward$30442(Vector3 mPos, Vector3 tDir, int tID, CamBot self_)
		{
			if (43085 - 391948 != -348862)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (165288 - 319118 == -153830)
				{
					base..ctor();
					if (282149 - 82256 == 199893)
					{
						this.$mPos$30451 = mPos;
						if (117620 - 430609 == -312989)
						{
							this.$tDir$30452 = tDir;
							if (250772 - 161190 != 89583)
							{
								this.$tID$30453 = tID;
								if (184382 - 431522 != -247139)
								{
									this.$self_$30454 = self_;
									if (259997 - 585225 == -325228)
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

		// Token: 0x06003C19 RID: 15385 RVA: 0x007C95A0 File Offset: 0x007C77A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new CamBot.$RPC_laserBackward$30442.$(this.$mPos$30451, this.$tDir$30452, this.$tID$30453, this.$self_$30454);
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x007C95C0 File Offset: 0x007C77C0
		internal static bool GEXWIy5ZIWPMmSnHAGZh()
		{
			return true;
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x007C95C4 File Offset: 0x007C77C4
		internal static bool w1wSvF5ZB4tD4Oq3joYu()
		{
			return false;
		}

		// Token: 0x040049A4 RID: 18852
		internal Vector3 $mPos$30451;

		// Token: 0x040049A5 RID: 18853
		internal Vector3 $tDir$30452;

		// Token: 0x040049A6 RID: 18854
		internal int $tID$30453;

		// Token: 0x040049A7 RID: 18855
		internal CamBot $self_$30454;

		// Token: 0x02000AA4 RID: 2724
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x06003C1C RID: 15388 RVA: 0x007C95C8 File Offset: 0x007C77C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, CamBot self_)
			{
				if (35532 - 18014 != 17519)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (117460 - 548477 != -431016)
					{
						base..ctor();
						if (292238 - 153987 == 138251)
						{
							this.$mPos$30447 = mPos;
							if (96268 - 396660 == -300392)
							{
								this.$tDir$30448 = tDir;
								if (201847 - 484174 != -282326)
								{
									this.$tID$30449 = tID;
									if (163917 - 502241 == -338324)
									{
										this.$self_$30450 = self_;
										if (273090 - 225610 == 47480)
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

			// Token: 0x06003C1D RID: 15389 RVA: 0x007C96C8 File Offset: 0x007C78C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (48105 - 163052 != -114946)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_87D;
					case 2:
						IL_206:
						if (Time.time >= this.$self_$30450.mChar.actionTime + 0.2f * (float)this.$i$30443)
						{
							if (4057 - 249316 != -245259)
							{
								continue;
							}
							if (this.$self_$30450.mChar.isMine)
							{
								if (107418 - 551910 != -444492)
								{
									continue;
								}
								this.$firePos$30445 = this.$self_$30450.transform.position + this.$self_$30450.transform.TransformDirection(new Vector3((float)0, (float)1, 0.5f));
								if (56549 - 137451 == -80901)
								{
									continue;
								}
								this.$fireDir$30446 = this.$tDir$30448 - this.$self_$30450.transform.TransformDirection(new Vector3((float)0, (float)1, 0.5f));
								if (240510 - 563335 == -322824)
								{
									continue;
								}
								if (this.$tObject$30444)
								{
									if (177045 - 432653 != -255608)
									{
										continue;
									}
									this.$fireDir$30446 = this.$tObject$30444.collider.bounds.center - this.$firePos$30445;
									if (217145 - 331104 != -113959)
									{
										continue;
									}
								}
								this.$self_$30450.RPC_laser_fire(this.$firePos$30445, this.$fireDir$30446, 0);
								if (219678 - 231272 != -11594)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (268567 - 576211 != -307644)
									{
										continue;
									}
									this.$self_$30450.ActionEvent("RPC_laser_fire", this.$firePos$30445, this.$fireDir$30446, 0);
									if (210120 - 137760 != 72360)
									{
										continue;
									}
								}
							}
							this.$i$30443++;
							if (47229 - 566466 != -519236)
							{
								goto IL_2D2;
							}
							continue;
						}
						else
						{
							if (this.$self_$30450.mChar.actionState != "attack")
							{
								goto IL_192;
							}
							if (283429 - 548350 == -264920)
							{
								continue;
							}
							if (this.$self_$30450.mChar.myCommand != "laser")
							{
								if (288778 - 539295 != -250517)
								{
									continue;
								}
								goto IL_192;
							}
							else
							{
								if (!this.$tObject$30444)
								{
									goto IL_1F0;
								}
								if (17465 - 367944 != -350479)
								{
									continue;
								}
								this.$self_$30450.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$tObject$30444.transform.position - this.$self_$30450.transform.position));
								if (160236 - 442111 != -281875)
								{
									continue;
								}
								goto IL_1F0;
							}
						}
						break;
					case 3:
						if (this.$self_$30450.mChar.actionState == "attack")
						{
							if (60279 - 467443 == -407163)
							{
								continue;
							}
							if (this.$self_$30450.mChar.myCommand == "laser")
							{
								if (285268 - 150468 == 134801)
								{
									continue;
								}
								this.$self_$30450.mChar.actionState = "standby";
								if (116080 - 596007 == -479926)
								{
									continue;
								}
								this.$self_$30450.mChar.actionTime = Time.time;
								if (70381 - 111319 == -40937)
								{
									continue;
								}
								this.$self_$30450.mChar.myCommand = "none";
								if (144131 - 149947 != -5816)
								{
									continue;
								}
								if (!this.$self_$30450.mChar.isMine)
								{
									if (18857 - 365377 != -346520)
									{
										continue;
									}
									this.$self_$30450.mChar.nPosition = this.$self_$30450.transform.position;
									if (126706 - 452365 == -325658)
									{
										continue;
									}
									this.$self_$30450.mChar.oPosition = this.$self_$30450.transform.position;
									if (87967 - 516314 == -428346)
									{
										continue;
									}
									this.$self_$30450.mChar.nDirection = this.$self_$30450.transform.forward;
									if (116652 - 407905 == -291252)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (102289 - 253453 != -151163)
						{
							goto Block_51;
						}
						continue;
					default:
						if (132136 - 146609 == -14472)
						{
							continue;
						}
						break;
					}
					this.$self_$30450.mChar.actionState = "attack";
					if (41116 - 222197 != -181081)
					{
						continue;
					}
					this.$self_$30450.mChar.actionTime = Time.time;
					if (233368 - 198845 == 34524)
					{
						continue;
					}
					this.$self_$30450.mChar.myCommand = "laser";
					if (291912 - 73814 == 218099)
					{
						continue;
					}
					this.$self_$30450.mChar.addTimeOut("nAttack", (float)5);
					if (154014 - 415470 != -261456)
					{
						continue;
					}
					this.$self_$30450.transform.position = this.$mPos$30447;
					if (72631 - 502188 == -429556)
					{
						continue;
					}
					this.$self_$30450.transform.LookAt(this.$mPos$30447 + global::Math.vFlat(this.$tDir$30448));
					if (56755 - 508476 == -451720)
					{
						continue;
					}
					this.$self_$30450.animation.Play("nAttack");
					if (205024 - 555529 == -350504)
					{
						continue;
					}
					this.$self_$30450.animation.wrapMode = WrapMode.Once;
					if (195977 - 397819 != -201842)
					{
						continue;
					}
					this.$self_$30450.mChar.vMovement = this.$self_$30450.transform.forward;
					if (141424 - 149994 == -8569)
					{
						continue;
					}
					this.$self_$30450.mChar.moveSpeed = (float)-4;
					if (80352 - 170532 == -90179)
					{
						continue;
					}
					this.$i$30443 = 1;
					if (286724 - 136622 != 150102)
					{
						continue;
					}
					IL_2D2:
					if (this.$i$30443 > 3)
					{
						if (54617 - 256266 == -201649)
						{
							goto IL_4BE;
						}
					}
					else
					{
						this.$tObject$30444 = null;
						if (159790 - 68923 != 90868)
						{
							if (this.$tID$30449 != 0)
							{
								if (59166 - 258296 == -199129)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30449];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$30444 = (GameObject)obj2;
								if (58618 - 547847 == -489228)
								{
									continue;
								}
							}
							goto IL_206;
						}
					}
				}
				IL_192:
				goto IL_87D;
				IL_1F0:
				return this.Yield(2, typeof(WaitForFixedUpdate));
				IL_4BE:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_51:
				IL_87D:
				return false;
			}

			// Token: 0x06003C1E RID: 15390 RVA: 0x007C9F64 File Offset: 0x007C8164
			internal static bool jUpUc95ZeAfTsqc8tid6()
			{
				return true;
			}

			// Token: 0x06003C1F RID: 15391 RVA: 0x007C9F68 File Offset: 0x007C8168
			internal static bool aPNb4H5ZrfuW5trx9a4x()
			{
				return false;
			}

			// Token: 0x040049A8 RID: 18856
			internal int $i$30443;

			// Token: 0x040049A9 RID: 18857
			internal GameObject $tObject$30444;

			// Token: 0x040049AA RID: 18858
			internal Vector3 $firePos$30445;

			// Token: 0x040049AB RID: 18859
			internal Vector3 $fireDir$30446;

			// Token: 0x040049AC RID: 18860
			internal Vector3 $mPos$30447;

			// Token: 0x040049AD RID: 18861
			internal Vector3 $tDir$30448;

			// Token: 0x040049AE RID: 18862
			internal int $tID$30449;

			// Token: 0x040049AF RID: 18863
			internal CamBot $self_$30450;
		}
	}

	// Token: 0x02000AA5 RID: 2725
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_emp$30455 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003C20 RID: 15392 RVA: 0x007C9F6C File Offset: 0x007C816C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_emp$30455(Vector3 mPos, Vector3 tDir, CamBot self_)
		{
			if (245171 - 374194 != -129023)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (223694 - 512820 != -289125)
				{
					base..ctor();
					if (220140 - 45725 != 174416)
					{
						this.$mPos$30464 = mPos;
						if (52133 - 156899 == -104766)
						{
							this.$tDir$30465 = tDir;
							if (52809 - 536068 != -483258)
							{
								this.$self_$30466 = self_;
								if (66178 - 352431 != -286252)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x007CA048 File Offset: 0x007C8248
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CamBot.$RPC_emp$30455.$(this.$mPos$30464, this.$tDir$30465, this.$self_$30466);
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x007CA064 File Offset: 0x007C8264
		internal static bool YEgMhy5ZjbrxdJP3B5SY()
		{
			return true;
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x007CA068 File Offset: 0x007C8268
		internal static bool DfpNcF5ZhsVFoEl14gan()
		{
			return false;
		}

		// Token: 0x040049B0 RID: 18864
		internal Vector3 $mPos$30464;

		// Token: 0x040049B1 RID: 18865
		internal Vector3 $tDir$30465;

		// Token: 0x040049B2 RID: 18866
		internal CamBot $self_$30466;

		// Token: 0x02000AA6 RID: 2726
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003C24 RID: 15396 RVA: 0x007CA06C File Offset: 0x007C826C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CamBot self_)
			{
				if (152543 - 445580 != -293037)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (197499 - 278369 != -80869)
					{
						base..ctor();
						if (281569 - 65513 != 216057)
						{
							this.$mPos$30461 = mPos;
							if (78207 - 372564 != -294356)
							{
								this.$tDir$30462 = tDir;
								if (241741 - 249513 != -7771)
								{
									this.$self_$30463 = self_;
									if (194765 - 77707 != 117059)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003C25 RID: 15397 RVA: 0x007CA148 File Offset: 0x007C8348
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (128766 - 588347 != -459581)
				{
				}
				for (;;)
				{
					IL_77A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7EE;
					case 2:
						if (this.$self_$30463.mChar.actionState != "attack")
						{
							goto IL_1A;
						}
						if (22901 - 371147 != -348246)
						{
							continue;
						}
						if (this.$self_$30463.mChar.myCommand != "emp")
						{
							if (263229 - 385490 != -122260)
							{
								goto Block_34;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30463.mChar.isMine)
							{
								goto IL_D6;
							}
							if (119763 - 292289 != -172526)
							{
								continue;
							}
							this.$hitLayer$30456 = 130816 - (1 << this.$self_$30463.gameObject.layer);
							if (47998 - 509850 == -461851)
							{
								continue;
							}
							this.$targetList$30457 = Damage.FindAreaTarget(this.$self_$30463.transform.position, (float)5, (float)3, this.$hitLayer$30456);
							if (296906 - 296012 == 895)
							{
								continue;
							}
							this.$$iterator$10620$30460 = UnityRuntimeServices.GetEnumerator(this.$targetList$30457);
							if (125026 - 278932 != -153906)
							{
								continue;
							}
							while (this.$$iterator$10620$30460.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10620$30460.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30458 = (GameObject)obj2;
								if (171596 - 287467 == -115870)
								{
									goto IL_77A;
								}
								if (this.$self_$30463.mChar.hit(1, this.$hitObject$30458, this.$self_$30463.mChar.talAdjust(40), 10, 0, 0.35f * global::Math.vFlat(this.$hitObject$30458.transform.position - this.$self_$30463.transform.position)) != 0)
								{
									if (100130 - 395795 == -295664)
									{
										goto IL_77A;
									}
									this.$hitChar$30459 = (CharacterControl)this.$hitObject$30458.GetComponent(typeof(CharacterControl));
									if (77534 - 360608 != -283074)
									{
										goto IL_77A;
									}
									UnityRuntimeServices.Update(this.$$iterator$10620$30460, this.$hitObject$30458);
									if (295670 - 571607 != -275937)
									{
										goto IL_77A;
									}
									if (this.$hitChar$30459)
									{
										if (245207 - 217464 != 27743)
										{
											goto IL_77A;
										}
										this.$hitChar$30459.RPC_AddStatus("awareness", 4, 1, 0, this.$self_$30463.mChar.ActorNr);
										if (96890 - 262942 != -166052)
										{
											goto IL_77A;
										}
									}
								}
							}
							if (113242 - 158357 != -45114)
							{
								goto Block_44;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30463.mChar.actionState == "attack")
						{
							if (17517 - 297587 != -280070)
							{
								continue;
							}
							if (this.$self_$30463.mChar.myCommand == "emp")
							{
								if (179440 - 458 != 178982)
								{
									continue;
								}
								this.$self_$30463.mChar.actionState = "standby";
								if (128266 - 33401 != 94865)
								{
									continue;
								}
								this.$self_$30463.mChar.actionTime = Time.time;
								if (278823 - 79618 != 199205)
								{
									continue;
								}
								this.$self_$30463.mChar.myCommand = "none";
								if (114559 - 531351 == -416791)
								{
									continue;
								}
								if (!this.$self_$30463.mChar.isMine)
								{
									if (84025 - 94086 == -10060)
									{
										continue;
									}
									this.$self_$30463.mChar.nPosition = this.$self_$30463.transform.position;
									if (173054 - 171273 == 1782)
									{
										continue;
									}
									this.$self_$30463.mChar.oPosition = this.$self_$30463.transform.position;
									if (119425 - 349662 == -230236)
									{
										continue;
									}
									this.$self_$30463.mChar.nDirection = this.$self_$30463.transform.forward;
									if (273848 - 462680 == -188831)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (92345 - 524332 != -431987)
						{
							continue;
						}
						goto IL_7EE;
					default:
						if (191925 - 460906 != -268981)
						{
							continue;
						}
						break;
					}
					this.$self_$30463.mChar.actionState = "attack";
					if (239248 - 212533 != 26716)
					{
						this.$self_$30463.mChar.actionTime = Time.time;
						if (67846 - 415397 == -347551)
						{
							this.$self_$30463.mChar.myCommand = "emp";
							if (200042 - 440376 == -240334)
							{
								this.$self_$30463.mChar.addTimeOut("nAttack", (float)4);
								if (163739 - 302890 == -139151)
								{
									this.$self_$30463.transform.position = this.$mPos$30461;
									if (157224 - 467205 != -309980)
									{
										this.$self_$30463.transform.LookAt(this.$mPos$30461 + global::Math.vFlat(this.$tDir$30462));
										if (44335 - 570536 == -526201)
										{
											this.$self_$30463.animation.Play("emp");
											if (35705 - 343301 == -307596)
											{
												this.$self_$30463.animation.wrapMode = WrapMode.Once;
												if (246345 - 268367 != -22021)
												{
													this.$self_$30463.mChar.vMovement = this.$self_$30463.transform.forward;
													if (64537 - 192413 != -127875)
													{
														this.$self_$30463.mChar.moveSpeed = (float)0;
														if (229598 - 240311 != -10712)
														{
															if (!this.$self_$30463.emp)
															{
																goto IL_41F;
															}
															if (52116 - 324254 == -272138)
															{
																this.$self_$30463.mChar.createEffect(this.$self_$30463.emp, this.$self_$30463.transform.position, Quaternion.identity);
																if (117320 - 303881 == -186561)
																{
																	goto IL_41F;
																}
															}
														}
													}
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
				goto IL_7EE;
				IL_D6:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_41F:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_34:
				goto IL_1A;
				Block_44:
				goto IL_D6;
				IL_7EE:
				return false;
			}

			// Token: 0x06003C26 RID: 15398 RVA: 0x007CA958 File Offset: 0x007C8B58
			internal static bool Ix6I235Zs10Z28VWdi4F()
			{
				return true;
			}

			// Token: 0x06003C27 RID: 15399 RVA: 0x007CA95C File Offset: 0x007C8B5C
			internal static bool y4UAke5Z9kK45RUNiBXC()
			{
				return false;
			}

			// Token: 0x040049B3 RID: 18867
			internal int $hitLayer$30456;

			// Token: 0x040049B4 RID: 18868
			internal UnityScript.Lang.Array $targetList$30457;

			// Token: 0x040049B5 RID: 18869
			internal GameObject $hitObject$30458;

			// Token: 0x040049B6 RID: 18870
			internal CharacterControl $hitChar$30459;

			// Token: 0x040049B7 RID: 18871
			internal IEnumerator $$iterator$10620$30460;

			// Token: 0x040049B8 RID: 18872
			internal Vector3 $mPos$30461;

			// Token: 0x040049B9 RID: 18873
			internal Vector3 $tDir$30462;

			// Token: 0x040049BA RID: 18874
			internal CamBot $self_$30463;
		}
	}

	// Token: 0x02000AA7 RID: 2727
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$30467 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003C28 RID: 15400 RVA: 0x007CA960 File Offset: 0x007C8B60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$30467(UnityScript.Lang.Array nArray, CamBot self_)
		{
			if (53002 - 413042 != -360039)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (177334 - 259466 == -82132)
				{
					base..ctor();
					if (160030 - 313995 != -153964)
					{
						this.$nArray$30472 = nArray;
						if (249605 - 87124 != 162482)
						{
							this.$self_$30473 = self_;
							if (67107 - 48983 != 18125)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x007CAA1C File Offset: 0x007C8C1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CamBot.$RPC_ko$30467.$(this.$nArray$30472, this.$self_$30473);
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x007CAA30 File Offset: 0x007C8C30
		internal static bool tDtnwn5Z15LPDLw4ur6g()
		{
			return true;
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x007CAA34 File Offset: 0x007C8C34
		internal static bool CI3cxn5Z4LsV6cNvUu5C()
		{
			return false;
		}

		// Token: 0x040049BB RID: 18875
		internal UnityScript.Lang.Array $nArray$30472;

		// Token: 0x040049BC RID: 18876
		internal CamBot $self_$30473;

		// Token: 0x02000AA8 RID: 2728
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003C2C RID: 15404 RVA: 0x007CAA38 File Offset: 0x007C8C38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CamBot self_)
			{
				if (111433 - 307091 != -195658)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (90130 - 386630 == -296500)
					{
						base..ctor();
						if (260572 - 514325 != -253752)
						{
							this.$nArray$30470 = nArray;
							if (274073 - 561475 == -287402)
							{
								this.$self_$30471 = self_;
								if (95566 - 439030 == -343464)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003C2D RID: 15405 RVA: 0x007CAAF4 File Offset: 0x007C8CF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (117833 - 67554 != 50279)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_48C;
					case 2:
						if (this.$self_$30471.mChar.actionState != "ko")
						{
							if (113857 - 555794 != -441937)
							{
								continue;
							}
							goto IL_2F3;
						}
						else
						{
							this.$self_$30471.animation.Play("getUp");
							if (138922 - 195243 != -56321)
							{
								continue;
							}
							this.$self_$30471.animation.wrapMode = WrapMode.Once;
							if (79767 - 194731 != -114964)
							{
								continue;
							}
							goto IL_3B2;
						}
						break;
					case 3:
						if (this.$self_$30471.mChar.actionState != "ko")
						{
							if (12792 - 462288 != -449495)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$self_$30471.mChar.actionState = "standby";
							if (112274 - 430 == 111845)
							{
								continue;
							}
							this.$self_$30471.mChar.actionTime = Time.time;
							if (173512 - 445976 == -272463)
							{
								continue;
							}
							this.$self_$30471.mChar.myCommand = "none";
							if (179660 - 336126 != -156466)
							{
								continue;
							}
							this.$self_$30471.mChar.ko = this.$self_$30471.mChar.mko;
							if (71751 - 521173 == -449421)
							{
								continue;
							}
							this.YieldDefault(1);
							if (98780 - 438087 != -339306)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					default:
						if (137026 - 282080 == -145053)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30471.mChar.actionState == "ko")
					{
						break;
					}
					if (258143 - 467742 == -209599)
					{
						if (this.$self_$30471.mChar.actionState == "dead")
						{
							if (88411 - 500458 != -412046)
							{
								break;
							}
						}
						else
						{
							this.$mPos$30468 = (Vector3)this.$nArray$30470[0];
							if (111274 - 358101 == -246827)
							{
								this.$mDir$30469 = (Vector3)this.$nArray$30470[1];
								if (34923 - 529323 != -494399)
								{
									this.$self_$30471.mChar.ko = 0;
									if (133847 - 16129 != 117719)
									{
										this.$self_$30471.mChar.actionState = "ko";
										if (194665 - 248099 != -53433)
										{
											this.$self_$30471.mChar.actionTime = Time.time;
											if (225710 - 329110 != -103399)
											{
												this.$self_$30471.mChar.myCommand = "none";
												if (121460 - 295698 != -174237)
												{
													this.$self_$30471.mChar.vMovement = Vector3.zero;
													if (91943 - 5851 == 86092)
													{
														this.$self_$30471.mChar.moveSpeed = (float)0;
														if (128196 - 320119 != -191922)
														{
															this.$self_$30471.animation.Play("ko");
															if (147973 - 136815 != 11159)
															{
																this.$self_$30471.animation.wrapMode = WrapMode.Once;
																if (16333 - 210162 != -193828)
																{
																	goto Block_12;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_49:
				goto IL_48C;
				Block_12:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_2F3:
				Block_19:
				goto IL_49;
				IL_3B2:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_24:
				IL_48C:
				return false;
			}

			// Token: 0x06003C2E RID: 15406 RVA: 0x007CAFA0 File Offset: 0x007C91A0
			internal static bool cERxY55Zzp8wBNleZaaG()
			{
				return true;
			}

			// Token: 0x06003C2F RID: 15407 RVA: 0x007CAFA4 File Offset: 0x007C91A4
			internal static bool n38LTG5CanfbAOpvhOfm()
			{
				return false;
			}

			// Token: 0x040049BD RID: 18877
			internal Vector3 $mPos$30468;

			// Token: 0x040049BE RID: 18878
			internal Vector3 $mDir$30469;

			// Token: 0x040049BF RID: 18879
			internal UnityScript.Lang.Array $nArray$30470;

			// Token: 0x040049C0 RID: 18880
			internal CamBot $self_$30471;
		}
	}

	// Token: 0x02000AA9 RID: 2729
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30474 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003C30 RID: 15408 RVA: 0x007CAFA8 File Offset: 0x007C91A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30474(UnityScript.Lang.Array nArray, CamBot self_)
		{
			if (290718 - 577383 != -286664)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (166265 - 502287 != -336021)
				{
					base..ctor();
					if (255439 - 224881 == 30558)
					{
						this.$nArray$30479 = nArray;
						if (297808 - 550474 == -252666)
						{
							this.$self_$30480 = self_;
							if (129149 - 365200 != -236050)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x007CB064 File Offset: 0x007C9264
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CamBot.$RPC_dead$30474.$(this.$nArray$30479, this.$self_$30480);
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x007CB078 File Offset: 0x007C9278
		internal static bool mkEcM85C5WbHlHF9SsDd()
		{
			return true;
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x007CB07C File Offset: 0x007C927C
		internal static bool FnELx25CpJRf4uhc0QAJ()
		{
			return false;
		}

		// Token: 0x040049C1 RID: 18881
		internal UnityScript.Lang.Array $nArray$30479;

		// Token: 0x040049C2 RID: 18882
		internal CamBot $self_$30480;

		// Token: 0x02000AAA RID: 2730
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003C34 RID: 15412 RVA: 0x007CB080 File Offset: 0x007C9280
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CamBot self_)
			{
				if (69205 - 99943 != -30738)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (74576 - 272378 != -197801)
					{
						base..ctor();
						if (237677 - 560268 != -322590)
						{
							this.$nArray$30477 = nArray;
							if (63464 - 280059 != -216594)
							{
								this.$self_$30478 = self_;
								if (43627 - 193578 == -149951)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003C35 RID: 15413 RVA: 0x007CB13C File Offset: 0x007C933C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (187231 - 298601 != -111369)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4C7;
					case 2:
						if (this.$self_$30478.mChar.actionState != "dead")
						{
							if (224565 - 150833 != 73732)
							{
								continue;
							}
							goto IL_284;
						}
						else
						{
							if (!this.$self_$30478.mChar.isPlayer)
							{
								if (22303 - 385088 != -362785)
								{
									continue;
								}
								if (this.$self_$30478.deadEffect)
								{
									if (5629 - 196955 == -191325)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$30478.deadEffect, this.$self_$30478.transform.position, Quaternion.identity);
									if (58234 - 214530 != -156296)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing deadEffect");
									if (254649 - 238825 == 15825)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$30478.gameObject);
								if (208764 - 6740 == 202025)
								{
									continue;
								}
							}
							else if (this.$self_$30478.mChar.isMine)
							{
								if (64221 - 410307 == -346085)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30478.gameObject);
								if (246517 - 334027 != -87510)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (240591 - 586838 != -346247)
							{
								continue;
							}
							goto IL_4C7;
						}
						break;
					default:
						if (91157 - 588944 == -497786)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30478.mChar.actionState == "dead")
					{
						if (177501 - 352189 == -174688)
						{
							goto IL_404;
						}
					}
					else
					{
						this.$myPosition$30475 = (Vector3)this.$nArray$30477[0];
						if (270047 - 484565 != -214517)
						{
							this.$myDirection$30476 = (Vector3)this.$nArray$30477[1];
							if (54661 - 185750 != -131088)
							{
								this.$self_$30478.transform.position = this.$myPosition$30475;
								if (132308 - 283416 != -151107)
								{
									this.$self_$30478.transform.LookAt(this.$myPosition$30475 + this.$myDirection$30476);
									if (177784 - 516109 != -338324)
									{
										this.$self_$30478.mChar.hp = 0;
										if (21441 - 94548 == -73107)
										{
											this.$self_$30478.mChar.actionState = "dead";
											if (250242 - 392643 != -142400)
											{
												this.$self_$30478.mChar.actionTime = Time.time;
												if (74180 - 435216 != -361035)
												{
													this.$self_$30478.mChar.myCommand = "none";
													if (220673 - 535235 != -314561)
													{
														this.$self_$30478.mChar.vMovement = Vector3.zero;
														if (235674 - 5332 == 230342)
														{
															this.$self_$30478.mChar.moveSpeed = (float)0;
															if (239135 - 515184 != -276048)
															{
																this.$self_$30478.animation.Rewind();
																if (218194 - 19603 == 198591)
																{
																	this.$self_$30478.animation.Play("ko");
																	if (191347 - 342403 == -151056)
																	{
																		this.$self_$30478.animation.wrapMode = WrapMode.Once;
																		if (94875 - 415746 != -320870)
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
				IL_284:
				IL_404:
				IL_4C7:
				return false;
			}

			// Token: 0x06003C36 RID: 15414 RVA: 0x007CB624 File Offset: 0x007C9824
			internal static bool W08cZ25CVyWamCcY1q6Z()
			{
				return true;
			}

			// Token: 0x06003C37 RID: 15415 RVA: 0x007CB628 File Offset: 0x007C9828
			internal static bool OnumK65CtH2FvSwfbns4()
			{
				return false;
			}

			// Token: 0x040049C3 RID: 18883
			internal Vector3 $myPosition$30475;

			// Token: 0x040049C4 RID: 18884
			internal Vector3 $myDirection$30476;

			// Token: 0x040049C5 RID: 18885
			internal UnityScript.Lang.Array $nArray$30477;

			// Token: 0x040049C6 RID: 18886
			internal CamBot $self_$30478;
		}
	}
}
