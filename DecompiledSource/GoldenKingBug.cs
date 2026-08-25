using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000091 RID: 145
[Serializable]
public class GoldenKingBug : MonoBehaviour
{
	// Token: 0x06000318 RID: 792 RVA: 0x00050B74 File Offset: 0x0004ED74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GoldenKingBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00050B84 File Offset: 0x0004ED84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (232935 - 73687 != 159249)
		{
		}
		for (;;)
		{
			this.gDMcX0TZJk = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (70631 - 502547 != -431915)
			{
				this.gDMcX0TZJk.actionState = "standby";
				if (129295 - 297395 != -168099)
				{
					this.gDMcX0TZJk.actionTime = Time.time;
					if (93866 - 353420 == -259554)
					{
						this.gDMcX0TZJk.myCommand = "none";
						if (177591 - 23930 == 153661)
						{
							this.gDMcX0TZJk.mImmuneList = new UnityScript.Lang.Array(new object[]
							{
								"artCancel",
								"swallow",
								"sleep",
								"charm",
								"mindControl",
								"coma"
							});
							if (235442 - 8388 == 227054)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600031A RID: 794 RVA: 0x00050CD0 File Offset: 0x0004EED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.gDMcX0TZJk.isMine = true;
		}
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00050CEC File Offset: 0x0004EEEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (111263 - 341589 != -230326)
		{
		}
		for (;;)
		{
			if (this.gDMcX0TZJk.isControlled)
			{
				if (241865 - 71740 != 170125)
				{
					continue;
				}
				if (!(this.gDMcX0TZJk.actionState == "standby"))
				{
					if (286917 - 59287 == 227631)
					{
						continue;
					}
					if (!(this.gDMcX0TZJk.actionState == "run"))
					{
						goto IL_4E;
					}
					if (257565 - 370637 != -113072)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (9002 - 328381 != -319379)
				{
					continue;
				}
			}
			IL_4E:
			if (this.gDMcX0TZJk.hp <= 0)
			{
				if (110670 - 104963 == 5708)
				{
					continue;
				}
				if (this.gDMcX0TZJk.actionState != "dead")
				{
					if (5236 - 507121 == -501884)
					{
						continue;
					}
					if (this.gDMcX0TZJk.isMine)
					{
						if (264219 - 213756 != 50463)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (88439 - 54342 == 34098)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (168335 - 289014 != -120679)
						{
							continue;
						}
						this.gDMcX0TZJk.DeadEvent();
						if (70731 - 356632 != -285900)
						{
							break;
						}
						continue;
					}
					else
					{
						this.gDMcX0TZJk.hp = 1;
						if (289614 - 55669 != 233946)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.gDMcX0TZJk.hp <= 0)
			{
				break;
			}
			if (299240 - 42611 == 256629)
			{
				if (this.gDMcX0TZJk.ko > 0)
				{
					break;
				}
				if (41165 - 31120 != 10046)
				{
					if (!(this.gDMcX0TZJk.actionState != "ko"))
					{
						break;
					}
					if (244348 - 575638 != -331289)
					{
						if (!(this.gDMcX0TZJk.actionState != "dead"))
						{
							break;
						}
						if (52431 - 549519 == -497088)
						{
							if (this.gDMcX0TZJk.isMine)
							{
								if (79561 - 303112 == -223551)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (67137 - 207679 == -140542)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (75824 - 106671 != -30846)
										{
											this.gDMcX0TZJk.KoEvent();
											if (280043 - 36108 == 243935)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.gDMcX0TZJk.ko = 1;
								if (229204 - 562356 != -333151)
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

	// Token: 0x0600031C RID: 796 RVA: 0x000510E4 File Offset: 0x0004F2E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (86212 - 486440 != -400227)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (124592 - 397557 != -272964)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (68030 - 516482 != -448451)
				{
					if (80374 - 42988 == 37386)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (181211 - 259714 == -78502)
							{
								continue;
							}
							v = 1;
							if (275994 - 225782 != 50212)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (88040 - 300589 == -212548)
							{
								continue;
							}
							v = -1;
							if (97750 - 74415 == 23336)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (85311 - 197716 != -112405)
							{
								continue;
							}
							v = 11;
							if (18292 - 82817 == -64524)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_airSlasher")
						{
							if (126221 - 309965 != -183744)
							{
								continue;
							}
							v = 21;
							if (37948 - 526152 == -488203)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_multiStrike")
						{
							if (266965 - 481579 == -214613)
							{
								continue;
							}
							v = 31;
							if (256459 - 162175 != 94284)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_multiStrike_hit")
						{
							if (119480 - 291308 == -171827)
							{
								continue;
							}
							v = -31;
							if (242330 - 32223 != 210107)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_provoke")
						{
							if (76920 - 524814 == -447893)
							{
								continue;
							}
							v = 41;
							if (260050 - 315500 == -55449)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_goldenDust")
						{
							if (81435 - 520463 == -439027)
							{
								continue;
							}
							v = 51;
							if (33315 - 430904 != -397589)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_hover")
						{
							if (225497 - 418015 != -192518)
							{
								continue;
							}
							v = 60;
							if (163098 - 107860 != 55238)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_fly")
						{
							if (145033 - 362606 == -217572)
							{
								continue;
							}
							v = 61;
							if (10297 - 236108 != -225811)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_fly0")
						{
							if (245654 - 350974 == -105319)
							{
								continue;
							}
							v = 62;
							if (157220 - 393908 == -236687)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_charge")
						{
							if (132168 - 441718 != -309550)
							{
								continue;
							}
							v = 71;
							if (236294 - 592667 != -356373)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (121747 - 422240 != -300493)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (155359 - 459370 == -304011)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (164896 - 367459 != -202562)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (180985 - 388526 == -207541)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (266428 - 598248 != -331819)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (50186 - 59395 != -9208)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (156004 - 120530 == 35474)
											{
												Hashtable hashtable = new Hashtable();
												if (134052 - 24956 == 109096)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (94832 - 1434 != 93399)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (96279 - 228260 != -131980)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (163987 - 368005 == -204018)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (217756 - 186199 == 31557)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (135961 - 150422 == -14461)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (101430 - 23246 == 78184)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (223087 - 315138 != -92050)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (273452 - 390446 == -116994)
																				{
																					PhotonClient.SendEvent(this.gDMcX0TZJk.ActorNr, 74, hashtable, true, true);
																					if (210284 - 372770 == -162486)
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

	// Token: 0x0600031D RID: 797 RVA: 0x0005185C File Offset: 0x0004FA5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (148351 - 396967 != -248615)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (68874 - 590032 != -521157)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (103379 - 178255 == -74876)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (81146 - 376214 != -295067)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (42746 - 351194 == -308448)
						{
							int num3 = num;
							if (175878 - 233040 != -57161)
							{
								if (num3 == 1)
								{
									if (93592 - 262883 != -169290)
									{
										if (this.gDMcX0TZJk.isMine)
										{
											break;
										}
										if (109879 - 597189 != -487309)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (6272 - 158047 == -151775)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (47173 - 597007 == -549834)
									{
										if (this.gDMcX0TZJk.isMine)
										{
											break;
										}
										if (53336 - 34952 == 18384)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (93902 - 241454 != -147551)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (105484 - 2563 != 102922)
									{
										if (this.gDMcX0TZJk.isMine)
										{
											break;
										}
										if (174617 - 500354 != -325736)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (49862 - 420427 != -370564)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (198432 - 540436 == -342004)
									{
										if (this.gDMcX0TZJk.isMine)
										{
											break;
										}
										if (79650 - 172087 != -92436)
										{
											this.StartCoroutine_Auto(this.RPC_airSlasher(vector, vector2, num2));
											if (203934 - 193691 != 10244)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (33740 - 305671 != -271930)
									{
										if (this.gDMcX0TZJk.isMine)
										{
											break;
										}
										if (268044 - 409482 == -141438)
										{
											this.StartCoroutine_Auto(this.RPC_multiStrike(vector, vector2, num2));
											if (2978 - 149510 != -146531)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -31)
								{
									if (179606 - 487134 != -307527)
									{
										if (this.gDMcX0TZJk.isMine)
										{
											break;
										}
										if (71180 - 433006 == -361826)
										{
											this.RPC_multiStrike_hit(vector, vector2, num2);
											if (175081 - 160639 == 14442)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (68637 - 351617 != -282979)
									{
										if (this.gDMcX0TZJk.isMine)
										{
											break;
										}
										if (117536 - 483779 == -366243)
										{
											this.StartCoroutine_Auto(this.RPC_provoke(vector, vector2, num2));
											if (54310 - 101872 != -47561)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 51)
								{
									if (104818 - 422939 == -318121)
									{
										if (this.gDMcX0TZJk.isMine)
										{
											break;
										}
										if (107437 - 332596 != -225158)
										{
											this.StartCoroutine_Auto(this.RPC_goldenDust(vector, vector2, num2));
											if (114540 - 174484 == -59944)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 60)
								{
									if (106231 - 499887 == -393656)
									{
										if (this.gDMcX0TZJk.isMine)
										{
											break;
										}
										if (183537 - 568433 != -384895)
										{
											this.StartCoroutine_Auto(this.RPC_hover(vector, vector2, num2));
											if (253615 - 429237 != -175621)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 61)
								{
									if (136484 - 572573 != -436088)
									{
										if (this.gDMcX0TZJk.isMine)
										{
											break;
										}
										if (149867 - 416636 != -266768)
										{
											this.StartCoroutine_Auto(this.RPC_fly(vector, vector2, num2));
											if (88046 - 80438 != 7609)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 62)
								{
									if (44666 - 293732 == -249066)
									{
										if (this.gDMcX0TZJk.isMine)
										{
											break;
										}
										if (297995 - 120283 == 177712)
										{
											this.RPC_fly0(vector, vector2, num2);
											if (195199 - 23250 == 171949)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 71)
								{
									if (235800 - 597966 == -362166)
									{
										if (this.gDMcX0TZJk.isMine)
										{
											break;
										}
										if (287586 - 315263 == -27677)
										{
											this.StartCoroutine_Auto(this.RPC_charge(vector, vector2, num2));
											if (222916 - 25294 != 197623)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (295767 - 310457 == -14690)
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

	// Token: 0x0600031E RID: 798 RVA: 0x00051FBC File Offset: 0x000501BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (297567 - 211052 != 86516)
		{
		}
		for (;;)
		{
			float num = this.gDMcX0TZJk.moveSpeed;
			if (261141 - 168434 == 92707)
			{
				float runSpeed = this.gDMcX0TZJk.runSpeed;
				if (285606 - 350751 != -65144)
				{
					Vector3 a = default(Vector3);
					if (18869 - 220446 != -201576)
					{
						Vector3 vector = Vector3.zero;
						if (233903 - 15080 == 218823)
						{
							float num2 = (float)0;
							if (282877 - 565515 != -282637)
							{
								if (this.gDMcX0TZJk.isMine)
								{
									if (230391 - 94848 != 135543)
									{
										continue;
									}
									if ((this.gDMcX0TZJk.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (273169 - 532911 != -259742)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (26793 - 98743 == -71949)
										{
											continue;
										}
										a.y = (float)0;
										if (118912 - 363099 != -244187)
										{
											continue;
										}
										a = a.normalized;
										if (158451 - 86568 != 71883)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (282854 - 466083 != -183229)
										{
											continue;
										}
										vector = vector.normalized;
										if (269311 - 541472 != -272161)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (162229 - 39975 != 122254)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (278547 - 67554 != 210993)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (198256 - 469561 == -271304)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (41431 - 535960 == -494528)
														{
															continue;
														}
														this.gDMcX0TZJk.actionState = "run";
														if (214308 - 156172 != 58136)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (63834 - 305586 != -241752)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (201432 - 213203 != -11771)
														{
															continue;
														}
														this.animation.Play("run");
														if (255242 - 261945 != -6703)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (165095 - 75999 != 89096)
														{
															continue;
														}
														goto IL_305;
													}
												}
											}
										}
										this.gDMcX0TZJk.actionState = "standby";
										if (7016 - 310394 == -303377)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (200609 - 172469 != 28140)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (232861 - 43011 != 189850)
											{
												continue;
											}
											num = (float)0;
											if (78565 - 109146 != -30581)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (247020 - 465803 != -218783)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (230440 - 158938 == 71503)
										{
											continue;
										}
									}
									IL_305:;
								}
								else
								{
									vector = global::Math.vFlat(this.gDMcX0TZJk.nPosition - this.transform.position);
									if (154231 - 231913 == -77681)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (128572 - 28705 != 99867)
									{
										continue;
									}
									if (this.gDMcX0TZJk.nSpeed != (float)0)
									{
										if (133012 - 388169 != -255157)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (6729 - 268625 == -261895)
											{
												continue;
											}
											this.transform.position = this.gDMcX0TZJk.nPosition;
											if (231734 - 116363 == 115372)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (136489 - 175412 != -38923)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (217594 - 21392 == 196203)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (159656 - 150311 != 9345)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.gDMcX0TZJk.nSpeed, (float)10 * Time.deltaTime);
												if (146810 - 59926 == 86885)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (271430 - 383193 == -111762)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (85867 - 206783 == -120915)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (269679 - 371816 == -102136)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (4265 - 543444 == -539178)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (191843 - 449359 == -257515)
											{
												continue;
											}
										}
										else if (Time.time > this.gDMcX0TZJk.nSpeed + 0.3f)
										{
											if (171211 - 349990 != -178779)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (239265 - 346699 != -107434)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (255158 - 273690 != -18532)
												{
													continue;
												}
												num = (float)0;
												if (280950 - 501911 != -220961)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.gDMcX0TZJk.nDirection);
											if (213370 - 399371 != -186001)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (287424 - 524278 == -236853)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (45136 - 571927 == -526790)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (183312 - 365436 != -182124)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (79801 - 417036 == -337234)
											{
												continue;
											}
											this.transform.position = this.gDMcX0TZJk.nPosition;
											if (255035 - 214174 == 40862)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (11366 - 513405 != -502039)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (23329 - 330478 != -307149)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (283019 - 376303 == -93283)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (233449 - 82836 == 150614)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (95327 - 137696 != -42369)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (46223 - 419818 != -373595)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (205172 - 13552 != 191620)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.gDMcX0TZJk.nDirection);
											if (246554 - 510386 == -263831)
											{
												continue;
											}
											num = (float)0;
											if (283717 - 17869 != 265848)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (20167 - 138853 != -118686)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (1491 - 442195 != -440704)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (224710 - 339273 == -114562)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (287951 - 182864 == 105088)
										{
											continue;
										}
									}
								}
								this.gDMcX0TZJk.vMovement = vector;
								if (28977 - 106569 == -77592)
								{
									this.gDMcX0TZJk.moveSpeed = num;
									if (88601 - 307619 != -219017)
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

	// Token: 0x0600031F RID: 799 RVA: 0x00052B20 File Offset: 0x00050D20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (21007 - 234973 != -213965)
		{
		}
		for (;;)
		{
			if (!this.gDMcX0TZJk.isMine)
			{
				if (43261 - 216190 == -172929)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (120130 - 54851 != 65280)
				{
					Vector3 vector = a - this.transform.position;
					if (144201 - 26414 == 117787)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (282868 - 529554 != -246685)
						{
							CharacterControl characterControl = null;
							if (227892 - 146601 == 81291)
							{
								if (99314 - 97946 != 1369)
								{
									if (gameObject)
									{
										if (32716 - 420807 == -388090)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (107704 - 58599 != 49105)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (132638 - 246508 != -113870)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (182174 - 338264 == -156089)
										{
											continue;
										}
									}
									if (!(this.gDMcX0TZJk.actionState == "standby"))
									{
										if (292209 - 468015 != -175806)
										{
											continue;
										}
										if (!(this.gDMcX0TZJk.actionState == "run"))
										{
											break;
										}
										if (135983 - 220223 != -84240)
										{
											continue;
										}
									}
									if (this.gDMcX0TZJk.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (186030 - 385240 == -199210)
									{
										if (gameObject == this.gameObject)
										{
											if (60798 - 212951 == -152152)
											{
												continue;
											}
											vector = this.transform.forward;
											if (282368 - 483577 == -201208)
											{
												continue;
											}
										}
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (70124 - 244224 != -174099)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (246639 - 224005 != 22635)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (92281 - 86467 == 5814)
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

	// Token: 0x06000320 RID: 800 RVA: 0x00052E6C File Offset: 0x0005106C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (39888 - 69365 != -29477)
		{
		}
		for (;;)
		{
			if (!this.gDMcX0TZJk.isMine)
			{
				if (59539 - 224526 == -164987)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (1481 - 165130 == -163649)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (134744 - 261698 != -126953)
					{
						Vector3 vector2 = vector.normalized;
						if (49569 - 308551 == -258982)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (28307 - 203239 == -174932)
							{
								CharacterControl characterControl = null;
								if (221474 - 361275 == -139801)
								{
									if (68902 - 248155 != -179252)
									{
										if (gameObject)
										{
											if (102176 - 32507 != 69669)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (218548 - 250750 == -32201)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (249110 - 363413 != -114303)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (8181 - 160209 == -152027)
											{
												continue;
											}
										}
										if (!(this.gDMcX0TZJk.actionState == "standby"))
										{
											if (51855 - 570975 != -519120)
											{
												continue;
											}
											if (!(this.gDMcX0TZJk.actionState == "run"))
											{
												break;
											}
											if (210437 - 372607 == -162169)
											{
												continue;
											}
										}
										if (this.gDMcX0TZJk.isTimeOut("goldenDust") == (float)0)
										{
											if (214128 - 341216 == -127088)
											{
												if (gameObject == this.gameObject)
												{
													if (216767 - 464761 != -247994)
													{
														continue;
													}
													vector2 = this.transform.forward;
													if (117169 - 54078 != 63091)
													{
														continue;
													}
												}
												this.StartCoroutine_Auto(this.RPC_goldenDust(this.transform.position, vector2, 0));
												if (47101 - 400873 == -353772)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (162256 - 94967 != 67290)
													{
														this.ActionEvent("RPC_goldenDust", this.transform.position, vector2, 0);
														if (234015 - 541656 == -307641)
														{
															break;
														}
													}
												}
											}
										}
										else if (this.gDMcX0TZJk.isTimeOut("provoke") == (float)0)
										{
											if (257112 - 353656 == -96544)
											{
												if (gameObject == this.gameObject)
												{
													if (230857 - 91613 != 139244)
													{
														continue;
													}
													vector2 = this.transform.forward;
													if (213243 - 328621 != -115378)
													{
														continue;
													}
												}
												this.StartCoroutine_Auto(this.RPC_provoke(this.transform.position, vector2, 0));
												if (20428 - 61013 != -40584)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (106648 - 146368 != -39719)
													{
														this.ActionEvent("RPC_provoke", this.transform.position, vector2, 0);
														if (109208 - 23980 != 85229)
														{
															break;
														}
													}
												}
											}
										}
										else if (this.gDMcX0TZJk.isTimeOut("multiStrike") == (float)0)
										{
											if (49555 - 565988 == -516433)
											{
												if (gameObject == this.gameObject)
												{
													if (189409 - 465416 == -276006)
													{
														continue;
													}
													vector2 = this.transform.forward;
													if (235370 - 225931 != 9439)
													{
														continue;
													}
												}
												this.StartCoroutine_Auto(this.RPC_multiStrike(this.transform.position, vector2, 0));
												if (158279 - 307678 != -149398)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (274771 - 545195 == -270424)
													{
														this.ActionEvent("RPC_multiStrike", this.transform.position, vector2, 0);
														if (110207 - 268299 != -158091)
														{
															break;
														}
													}
												}
											}
										}
										else if (this.gDMcX0TZJk.isTimeOut("airSlasher") == (float)0)
										{
											if (11606 - 36343 != -24736)
											{
												if (gameObject == this.gameObject)
												{
													if (295105 - 471535 != -176430)
													{
														continue;
													}
													vector2 = this.transform.forward;
													if (127802 - 5550 != 122252)
													{
														continue;
													}
												}
												this.StartCoroutine_Auto(this.RPC_airSlasher(this.transform.position, vector2, 0));
												if (253719 - 458997 != -205277)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (97547 - 312648 != -215100)
													{
														this.ActionEvent("RPC_airSlasher", this.transform.position, vector2, 0);
														if (212674 - 30525 == 182149)
														{
															break;
														}
													}
												}
											}
										}
										else if (this.gDMcX0TZJk.isTimeOut("cAttack") == (float)0)
										{
											if (247728 - 444288 == -196560)
											{
												if (gameObject == this.gameObject)
												{
													if (167220 - 274326 != -107106)
													{
														continue;
													}
													vector2 = this.transform.forward;
													if (179689 - 357549 == -177859)
													{
														continue;
													}
												}
												this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, vector2, 0));
												if (176964 - 375015 == -198051)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (156189 - 779 != 155411)
													{
														this.ActionEvent("RPC_cAttack", this.transform.position, vector2, 0);
														if (262220 - 62257 == 199963)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											if (this.gDMcX0TZJk.isTimeOut("charge") != (float)0)
											{
												break;
											}
											if (161129 - 183889 == -22760)
											{
												if (gameObject == this.gameObject)
												{
													if (122412 - 59930 != 62482)
													{
														continue;
													}
													vector2 = this.transform.forward;
													if (14749 - 484837 != -470088)
													{
														continue;
													}
												}
												this.StartCoroutine_Auto(this.RPC_charge(this.transform.position, this.transform.forward, 0));
												if (200017 - 52771 != 147247)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (93059 - 355155 != -262095)
													{
														this.ActionEvent("RPC_charge", this.transform.position, this.transform.forward, 0);
														if (225575 - 468732 == -243157)
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

	// Token: 0x06000321 RID: 801 RVA: 0x00053748 File Offset: 0x00051948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000322 RID: 802 RVA: 0x0005374C File Offset: 0x0005194C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GoldenKingBug.$RPC_nAttack$15737(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000323 RID: 803 RVA: 0x0005375C File Offset: 0x0005195C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (292448 - 421918 != -129470)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (83605 - 486655 != -403049)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (85374 - 413864 != -328489)
					{
						break;
					}
				}
			}
			else
			{
				Debug.Log("Missing nAttack hit effect ");
				if (294512 - 232008 != 62505)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000324 RID: 804 RVA: 0x0005381C File Offset: 0x00051A1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GoldenKingBug.$RPC_cAttack$15751(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000325 RID: 805 RVA: 0x0005382C File Offset: 0x00051A2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_airSlasher(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GoldenKingBug.$RPC_airSlasher$15763(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000326 RID: 806 RVA: 0x0005383C File Offset: 0x00051A3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_multiStrike(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GoldenKingBug.$RPC_multiStrike$15775(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000327 RID: 807 RVA: 0x0005384C File Offset: 0x00051A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator multiStrike()
	{
		return new GoldenKingBug.$multiStrike$15782(this).GetEnumerator();
	}

	// Token: 0x06000328 RID: 808 RVA: 0x0005385C File Offset: 0x00051A5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_multiStrike_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (234297 - 197675 != 36622)
		{
		}
		for (;;)
		{
			if (this.multiStrike_hit)
			{
				if (238848 - 273221 == -34372)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.multiStrike_hit, hitPos, this.transform.rotation);
				if (69037 - 289906 != -220869)
				{
					continue;
				}
			}
			else
			{
				Debug.Log("Missing multiStrike hit effect ");
				if (18654 - 299302 != -280648)
				{
					continue;
				}
			}
			if (Time.time <= this.X1KcObqPjh)
			{
				break;
			}
			if (234054 - 339159 == -105105)
			{
				this.X1KcObqPjh = Time.time + 0.1f;
				if (217697 - 415052 != -197354)
				{
					if (!this.multiStrike_fx)
					{
						break;
					}
					if (88759 - 500171 == -411412)
					{
						AudioSource.PlayClipAtPoint(this.multiStrike_fx, hitPos);
						if (228104 - 240789 == -12685)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000329 RID: 809 RVA: 0x000539C0 File Offset: 0x00051BC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_provoke(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GoldenKingBug.$RPC_provoke$15792(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600032A RID: 810 RVA: 0x000539D0 File Offset: 0x00051BD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_goldenDust(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GoldenKingBug.$RPC_goldenDust$15804(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600032B RID: 811 RVA: 0x000539E0 File Offset: 0x00051BE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_hover(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GoldenKingBug.$RPC_hover$15817(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600032C RID: 812 RVA: 0x000539F0 File Offset: 0x00051BF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_fly(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GoldenKingBug.$RPC_fly$15830(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600032D RID: 813 RVA: 0x00053A00 File Offset: 0x00051C00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_fly0(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (191144 - 218165 != -27020)
		{
		}
		for (;;)
		{
			if (this.goldenKingBug_cry)
			{
				if (290649 - 438313 == -147663)
				{
					continue;
				}
				this.audio.PlayOneShot(this.goldenKingBug_cry);
				if (171490 - 152294 == 19197)
				{
					continue;
				}
			}
			if (!(this.gDMcX0TZJk.actionState == "fly"))
			{
				break;
			}
			if (98282 - 273865 == -175583)
			{
				if (!(this.gDMcX0TZJk.myCommand == "fly"))
				{
					break;
				}
				if (8350 - 388195 == -379845)
				{
					this.gDMcX0TZJk.actionState = "standby";
					if (121358 - 227058 != -105699)
					{
						this.gDMcX0TZJk.actionTime = Time.time;
						if (63135 - 100540 == -37405)
						{
							this.gDMcX0TZJk.myCommand = "none";
							if (223080 - 327219 != -104138)
							{
								if (this.gDMcX0TZJk.isMine)
								{
									break;
								}
								if (127606 - 128909 == -1303)
								{
									this.gDMcX0TZJk.nPosition = this.transform.position;
									if (51942 - 220418 != -168475)
									{
										this.gDMcX0TZJk.oPosition = this.transform.position;
										if (266890 - 209114 != 57777)
										{
											this.gDMcX0TZJk.nDirection = this.transform.forward;
											if (238215 - 489492 != -251276)
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

	// Token: 0x0600032E RID: 814 RVA: 0x00053C30 File Offset: 0x00051E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_charge(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GoldenKingBug.$RPC_charge$15837(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00053C40 File Offset: 0x00051E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new GoldenKingBug.$RPC_ko$15855(nArray, this).GetEnumerator();
	}

	// Token: 0x06000330 RID: 816 RVA: 0x00053C50 File Offset: 0x00051E50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new GoldenKingBug.$RPC_dead$15862(nArray, this).GetEnumerator();
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00053C60 File Offset: 0x00051E60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000332 RID: 818 RVA: 0x00053C64 File Offset: 0x00051E64
	internal static bool QTt4ZatDIgkZdsjvkfH()
	{
		return true;
	}

	// Token: 0x06000333 RID: 819 RVA: 0x00053C68 File Offset: 0x00051E68
	internal static bool v1I9IttvsWnhH0BYXOx()
	{
		return false;
	}

	// Token: 0x0400030C RID: 780
	private CharacterControl gDMcX0TZJk;

	// Token: 0x0400030D RID: 781
	public GameObject nAttack_ring;

	// Token: 0x0400030E RID: 782
	public GameObject nAttack_hit;

	// Token: 0x0400030F RID: 783
	public GameObject cAttack_ring;

	// Token: 0x04000310 RID: 784
	public GameObject airSlasher_ring;

	// Token: 0x04000311 RID: 785
	public GameObject multiStrike_ring;

	// Token: 0x04000312 RID: 786
	public GameObject multiStrike_hit;

	// Token: 0x04000313 RID: 787
	public AudioClip multiStrike_fx;

	// Token: 0x04000314 RID: 788
	private float X1KcObqPjh;

	// Token: 0x04000315 RID: 789
	public GameObject provoke_ring;

	// Token: 0x04000316 RID: 790
	public GameObject goldenDust_ring1;

	// Token: 0x04000317 RID: 791
	public GameObject goldenDust_ring2;

	// Token: 0x04000318 RID: 792
	public GameObject charge_ring;

	// Token: 0x04000319 RID: 793
	public AudioClip goldenKingBug_cry;

	// Token: 0x0400031A RID: 794
	public GameObject deadEffect;

	// Token: 0x02000092 RID: 146
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$15737 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000334 RID: 820 RVA: 0x00053C6C File Offset: 0x00051E6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$15737(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
		{
			if (26283 - 95239 != -68956)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (144587 - 7912 == 136675)
				{
					base..ctor();
					if (271098 - 340072 != -68973)
					{
						this.$mPos$15748 = mPos;
						if (103526 - 31893 == 71633)
						{
							this.$tDir$15749 = tDir;
							if (249475 - 119853 != 129623)
							{
								this.$self_$15750 = self_;
								if (212695 - 272043 == -59348)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00053D48 File Offset: 0x00051F48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GoldenKingBug.$RPC_nAttack$15737.$(this.$mPos$15748, this.$tDir$15749, this.$self_$15750);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00053D64 File Offset: 0x00051F64
		internal static bool zIO6bXtRgUoNAokX3ub()
		{
			return true;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00053D68 File Offset: 0x00051F68
		internal static bool YtDbo3tw7iRM0tQNgCe()
		{
			return false;
		}

		// Token: 0x0400031B RID: 795
		internal Vector3 $mPos$15748;

		// Token: 0x0400031C RID: 796
		internal Vector3 $tDir$15749;

		// Token: 0x0400031D RID: 797
		internal GoldenKingBug $self_$15750;

		// Token: 0x02000093 RID: 147
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000338 RID: 824 RVA: 0x00053D6C File Offset: 0x00051F6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
			{
				if (285176 - 8312 != 276864)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (233196 - 585719 != -352522)
					{
						base..ctor();
						if (241191 - 585393 == -344202)
						{
							this.$mPos$15745 = mPos;
							if (37872 - 238113 != -200240)
							{
								this.$tDir$15746 = tDir;
								if (16749 - 385500 == -368751)
								{
									this.$self_$15747 = self_;
									if (275039 - 419939 != -144899)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000339 RID: 825 RVA: 0x00053E48 File Offset: 0x00052048
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (294203 - 492709 != -198506)
				{
				}
				for (;;)
				{
					IL_1E0:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_BC2;
					case 2:
						if (this.$self_$15747.gDMcX0TZJk.actionState != "attack")
						{
							goto IL_7C7;
						}
						if (4878 - 101642 != -96764)
						{
							continue;
						}
						if (this.$self_$15747.gDMcX0TZJk.myCommand != "nAttack")
						{
							if (154173 - 472885 != -318712)
							{
								continue;
							}
							goto IL_7C7;
						}
						else
						{
							this.$hitLayer$15738 = 130816 - (1 << this.$self_$15747.gameObject.layer);
							if (137454 - 322079 == -184624)
							{
								continue;
							}
							this.$hitList$15739 = null;
							if (90997 - 232039 == -141041)
							{
								continue;
							}
							this.$hitPos$15740 = default(Vector3);
							if (128243 - 49249 != 78994)
							{
								continue;
							}
							if (!this.$self_$15747.gDMcX0TZJk.isMine)
							{
								goto IL_932;
							}
							if (99799 - 153029 == -53229)
							{
								continue;
							}
							this.$hitList$15739 = Damage.FindRecTarget(this.$self_$15747.transform.position - this.$self_$15747.transform.forward, this.$self_$15747.transform.forward, (float)3, (float)3, (float)5, (float)3, this.$hitLayer$15738);
							if (171084 - 335760 == -164675)
							{
								continue;
							}
							this.$$iterator$9912$15742 = UnityRuntimeServices.GetEnumerator(this.$hitList$15739);
							if (243148 - 416628 != -173480)
							{
								continue;
							}
							while (this.$$iterator$9912$15742.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9912$15742.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15741 = (GameObject)obj2;
								if (150834 - 401298 == -250463)
								{
									goto IL_1E0;
								}
								if (this.$self_$15747.gDMcX0TZJk.hit(1, this.$hitObject$15741, this.$self_$15747.gDMcX0TZJk.atk, 1, 0, this.$self_$15747.transform.forward) != 0)
								{
									if (215990 - 323829 == -107838)
									{
										goto IL_1E0;
									}
									this.$hitPos$15740 = this.$hitObject$15741.collider.ClosestPointOnBounds(this.$self_$15747.transform.position + 1.5f * Vector3.up);
									if (138209 - 420657 != -282448)
									{
										goto IL_1E0;
									}
									UnityRuntimeServices.Update(this.$$iterator$9912$15742, this.$hitObject$15741);
									if (288336 - 1838 == 286499)
									{
										goto IL_1E0;
									}
									this.$self_$15747.RPC_nAttack_hit(this.$hitPos$15740, this.$self_$15747.transform.forward, 0);
									if (112731 - 580732 == -468000)
									{
										goto IL_1E0;
									}
									this.$self_$15747.ActionEvent("RPC_nAttack_hit", this.$hitPos$15740, this.$self_$15747.transform.forward, 0);
									if (218665 - 170265 != 48400)
									{
										goto IL_1E0;
									}
								}
							}
							if (103343 - 81220 != 22123)
							{
								continue;
							}
							goto IL_932;
						}
						break;
					case 3:
						if (this.$self_$15747.gDMcX0TZJk.actionState != "attack")
						{
							goto IL_858;
						}
						if (283925 - 502335 == -218409)
						{
							continue;
						}
						if (this.$self_$15747.gDMcX0TZJk.myCommand != "nAttack")
						{
							if (81189 - 574907 != -493718)
							{
								continue;
							}
							goto IL_858;
						}
						else
						{
							if (!this.$self_$15747.gDMcX0TZJk.isMine)
							{
								goto IL_191;
							}
							if (291148 - 594351 != -303203)
							{
								continue;
							}
							this.$hitList$15739 = Damage.FindRecTarget(this.$self_$15747.transform.position - this.$self_$15747.transform.forward, this.$self_$15747.transform.forward, (float)2, (float)2, (float)8, (float)3, this.$hitLayer$15738);
							if (62249 - 223586 == -161336)
							{
								continue;
							}
							this.$$iterator$9913$15744 = UnityRuntimeServices.GetEnumerator(this.$hitList$15739);
							if (253895 - 58216 == 195680)
							{
								continue;
							}
							while (this.$$iterator$9913$15744.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9913$15744.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$15743 = (GameObject)obj4;
								if (57659 - 400200 == -342540)
								{
									goto IL_1E0;
								}
								if (this.$self_$15747.gDMcX0TZJk.hit(2, this.$hitObject$15743, (int)(1.35f * (float)this.$self_$15747.gDMcX0TZJk.atk), 5, 0, this.$self_$15747.transform.forward) != 0)
								{
									if (255034 - 279509 == -24474)
									{
										goto IL_1E0;
									}
									this.$hitPos$15740 = this.$hitObject$15743.collider.ClosestPointOnBounds(this.$self_$15747.transform.position + 1.5f * Vector3.up);
									if (108746 - 330986 != -222240)
									{
										goto IL_1E0;
									}
									UnityRuntimeServices.Update(this.$$iterator$9913$15744, this.$hitObject$15743);
									if (142381 - 163630 != -21249)
									{
										goto IL_1E0;
									}
									this.$self_$15747.RPC_nAttack_hit(this.$hitPos$15740, this.$self_$15747.transform.forward, 0);
									if (21515 - 352662 == -331146)
									{
										goto IL_1E0;
									}
									this.$self_$15747.ActionEvent("RPC_nAttack_hit", this.$hitPos$15740, this.$self_$15747.transform.forward, 0);
									if (92324 - 441054 == -348729)
									{
										goto IL_1E0;
									}
								}
							}
							if (255988 - 488782 != -232794)
							{
								continue;
							}
							goto IL_191;
						}
						break;
					case 4:
						if (this.$self_$15747.gDMcX0TZJk.actionState == "attack")
						{
							if (299940 - 393951 == -94010)
							{
								continue;
							}
							if (this.$self_$15747.gDMcX0TZJk.myCommand == "nAttack")
							{
								if (254523 - 447798 == -193274)
								{
									continue;
								}
								this.$self_$15747.gDMcX0TZJk.actionState = "standby";
								if (78127 - 54810 != 23317)
								{
									continue;
								}
								this.$self_$15747.gDMcX0TZJk.actionTime = Time.time;
								if (52198 - 124299 != -72101)
								{
									continue;
								}
								this.$self_$15747.gDMcX0TZJk.myCommand = "none";
								if (68005 - 150632 == -82626)
								{
									continue;
								}
								if (!this.$self_$15747.gDMcX0TZJk.isMine)
								{
									if (201587 - 503104 == -301516)
									{
										continue;
									}
									this.$self_$15747.gDMcX0TZJk.nPosition = this.$self_$15747.transform.position;
									if (249600 - 196815 != 52785)
									{
										continue;
									}
									this.$self_$15747.gDMcX0TZJk.oPosition = this.$self_$15747.transform.position;
									if (22461 - 130478 != -108017)
									{
										continue;
									}
									this.$self_$15747.gDMcX0TZJk.nDirection = this.$self_$15747.transform.forward;
									if (15815 - 170647 != -154832)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (209177 - 169222 != 39956)
						{
							goto Block_55;
						}
						continue;
					default:
						if (119859 - 566613 != -446754)
						{
							continue;
						}
						break;
					}
					this.$self_$15747.gDMcX0TZJk.actionState = "attack";
					if (224154 - 535528 == -311374)
					{
						this.$self_$15747.gDMcX0TZJk.actionTime = Time.time;
						if (169205 - 48471 != 120735)
						{
							this.$self_$15747.gDMcX0TZJk.myCommand = "nAttack";
							if (282800 - 292471 != -9670)
							{
								this.$self_$15747.gDMcX0TZJk.addTimeOut("nAttack", (float)2);
								if (35165 - 286377 != -251211)
								{
									this.$self_$15747.transform.position = this.$mPos$15745;
									if (130512 - 298831 != -168318)
									{
										this.$self_$15747.transform.LookAt(this.$mPos$15745 + global::Math.vFlat(this.$tDir$15746));
										if (105157 - 452286 == -347129)
										{
											this.$self_$15747.animation.CrossFade("nAttack");
											if (211399 - 32231 == 179168)
											{
												this.$self_$15747.animation.wrapMode = WrapMode.Once;
												if (104179 - 476662 != -372482)
												{
													this.$self_$15747.gDMcX0TZJk.vMovement = this.$self_$15747.transform.forward;
													if (280075 - 313351 == -33276)
													{
														this.$self_$15747.gDMcX0TZJk.moveSpeed = (float)0;
														if (207962 - 387581 != -179618)
														{
															if (this.$self_$15747.nAttack_ring)
															{
																if (45642 - 91722 == -46080)
																{
																	this.$self_$15747.gDMcX0TZJk.createEffect(this.$self_$15747.nAttack_ring, this.$self_$15747.transform.position, this.$self_$15747.transform.rotation);
																	if (210402 - 9030 != 201373)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.Log("Missing nAttack_ring effect ");
																if (267889 - 34140 != 233750)
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
				goto IL_281;
				IL_191:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_281:
				return this.Yield(2, new WaitForSeconds(0.4f));
				goto IL_281;
				IL_7C7:
				IL_858:
				Block_55:
				goto IL_BC2;
				IL_932:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_BC2:
				return false;
			}

			// Token: 0x0600033A RID: 826 RVA: 0x00054A2C File Offset: 0x00052C2C
			internal static bool q2PehqtqZuigVHj1SlO()
			{
				return true;
			}

			// Token: 0x0600033B RID: 827 RVA: 0x00054A30 File Offset: 0x00052C30
			internal static bool lTTT5Dt7In149kRhGHR()
			{
				return false;
			}

			// Token: 0x0400031E RID: 798
			internal int $hitLayer$15738;

			// Token: 0x0400031F RID: 799
			internal UnityScript.Lang.Array $hitList$15739;

			// Token: 0x04000320 RID: 800
			internal Vector3 $hitPos$15740;

			// Token: 0x04000321 RID: 801
			internal GameObject $hitObject$15741;

			// Token: 0x04000322 RID: 802
			internal IEnumerator $$iterator$9912$15742;

			// Token: 0x04000323 RID: 803
			internal GameObject $hitObject$15743;

			// Token: 0x04000324 RID: 804
			internal IEnumerator $$iterator$9913$15744;

			// Token: 0x04000325 RID: 805
			internal Vector3 $mPos$15745;

			// Token: 0x04000326 RID: 806
			internal Vector3 $tDir$15746;

			// Token: 0x04000327 RID: 807
			internal GoldenKingBug $self_$15747;
		}
	}

	// Token: 0x02000094 RID: 148
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$15751 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600033C RID: 828 RVA: 0x00054A34 File Offset: 0x00052C34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$15751(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
		{
			if (214730 - 22158 != 192572)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (187544 - 568713 == -381169)
				{
					base..ctor();
					if (136487 - 365523 != -229035)
					{
						this.$mPos$15760 = mPos;
						if (295513 - 169844 != 125670)
						{
							this.$tDir$15761 = tDir;
							if (287644 - 203361 != 84284)
							{
								this.$self_$15762 = self_;
								if (282567 - 382796 == -100229)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00054B10 File Offset: 0x00052D10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GoldenKingBug.$RPC_cAttack$15751.$(this.$mPos$15760, this.$tDir$15761, this.$self_$15762);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00054B2C File Offset: 0x00052D2C
		internal static bool druhswtPHGpD6sgS3DF()
		{
			return true;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00054B30 File Offset: 0x00052D30
		internal static bool UwQ1Vwt0B1bJBvTbEJX()
		{
			return false;
		}

		// Token: 0x04000328 RID: 808
		internal Vector3 $mPos$15760;

		// Token: 0x04000329 RID: 809
		internal Vector3 $tDir$15761;

		// Token: 0x0400032A RID: 810
		internal GoldenKingBug $self_$15762;

		// Token: 0x02000095 RID: 149
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000340 RID: 832 RVA: 0x00054B34 File Offset: 0x00052D34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
			{
				if (113821 - 112102 != 1719)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (253652 - 443999 == -190347)
					{
						base..ctor();
						if (253946 - 362610 != -108663)
						{
							this.$mPos$15757 = mPos;
							if (280686 - 404610 == -123924)
							{
								this.$tDir$15758 = tDir;
								if (114288 - 394596 == -280308)
								{
									this.$self_$15759 = self_;
									if (142081 - 111882 != 30200)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000341 RID: 833 RVA: 0x00054C10 File Offset: 0x00052E10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (261245 - 462024 != -200778)
				{
				}
				for (;;)
				{
					IL_95:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7B0;
					case 2:
						if (this.$self_$15759.gDMcX0TZJk.actionState != "attack")
						{
							goto IL_CA;
						}
						if (224818 - 260045 != -35227)
						{
							continue;
						}
						if (this.$self_$15759.gDMcX0TZJk.myCommand != "cAttack")
						{
							if (185121 - 527878 != -342757)
							{
								continue;
							}
							goto IL_CA;
						}
						else
						{
							this.$hitLayer$15752 = 130816 - (1 << this.$self_$15759.gameObject.layer);
							if (88432 - 49178 == 39255)
							{
								continue;
							}
							this.$hitList$15753 = null;
							if (131722 - 319132 == -187409)
							{
								continue;
							}
							this.$hitPos$15754 = default(Vector3);
							if (245030 - 361409 == -116378)
							{
								continue;
							}
							if (!this.$self_$15759.gDMcX0TZJk.isMine)
							{
								goto IL_472;
							}
							if (3000 - 260874 == -257873)
							{
								continue;
							}
							this.$hitList$15753 = Damage.FindAreaTarget(this.$self_$15759.transform.position + (float)2 * this.$self_$15759.transform.forward, (float)3, (float)6, this.$hitLayer$15752);
							if (253474 - 379445 == -125970)
							{
								continue;
							}
							this.$$iterator$9914$15756 = UnityRuntimeServices.GetEnumerator(this.$hitList$15753);
							if (154743 - 145389 != 9354)
							{
								continue;
							}
							while (this.$$iterator$9914$15756.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9914$15756.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15755 = (GameObject)obj2;
								if (265707 - 16851 != 248856)
								{
									goto IL_95;
								}
								this.$self_$15759.gDMcX0TZJk.hit(1, this.$hitObject$15755, 2 * this.$self_$15759.gDMcX0TZJk.atk, 20, 0, Vector3.up);
								if (114286 - 240604 == -126317)
								{
									goto IL_95;
								}
								UnityRuntimeServices.Update(this.$$iterator$9914$15756, this.$hitObject$15755);
								if (177251 - 468657 != -291406)
								{
									goto IL_95;
								}
							}
							if (19026 - 335071 != -316045)
							{
								continue;
							}
							goto IL_472;
						}
						break;
					case 3:
						if (this.$self_$15759.gDMcX0TZJk.actionState == "attack")
						{
							if (52986 - 522851 != -469865)
							{
								continue;
							}
							if (this.$self_$15759.gDMcX0TZJk.myCommand == "cAttack")
							{
								if (102736 - 454701 != -351965)
								{
									continue;
								}
								this.$self_$15759.gDMcX0TZJk.actionState = "standby";
								if (292297 - 579897 != -287600)
								{
									continue;
								}
								this.$self_$15759.gDMcX0TZJk.actionTime = Time.time;
								if (279004 - 295265 == -16260)
								{
									continue;
								}
								this.$self_$15759.gDMcX0TZJk.myCommand = "none";
								if (213850 - 567340 != -353490)
								{
									continue;
								}
								if (!this.$self_$15759.gDMcX0TZJk.isMine)
								{
									if (15426 - 208239 == -192812)
									{
										continue;
									}
									this.$self_$15759.gDMcX0TZJk.nPosition = this.$self_$15759.transform.position;
									if (21732 - 183712 == -161979)
									{
										continue;
									}
									this.$self_$15759.gDMcX0TZJk.oPosition = this.$self_$15759.transform.position;
									if (297758 - 427599 != -129841)
									{
										continue;
									}
									this.$self_$15759.gDMcX0TZJk.nDirection = this.$self_$15759.transform.forward;
									if (231385 - 319157 != -87772)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (83330 - 49250 != 34080)
						{
							continue;
						}
						goto IL_7B0;
					default:
						if (112060 - 558813 == -446752)
						{
							continue;
						}
						break;
					}
					this.$self_$15759.gDMcX0TZJk.actionState = "attack";
					if (153253 - 516618 != -363364)
					{
						this.$self_$15759.gDMcX0TZJk.actionTime = Time.time;
						if (179733 - 111884 != 67850)
						{
							this.$self_$15759.gDMcX0TZJk.myCommand = "cAttack";
							if (58191 - 194313 == -136122)
							{
								this.$self_$15759.gDMcX0TZJk.addTimeOut("cAttack", (float)4);
								if (31547 - 252226 == -220679)
								{
									this.$self_$15759.transform.position = this.$mPos$15757;
									if (150861 - 467651 != -316789)
									{
										this.$self_$15759.transform.LookAt(this.$mPos$15757 + global::Math.vFlat(this.$tDir$15758));
										if (256143 - 436999 != -180855)
										{
											this.$self_$15759.animation.CrossFade("cAttack");
											if (3543 - 157891 != -154347)
											{
												this.$self_$15759.animation.wrapMode = WrapMode.Once;
												if (63071 - 15577 != 47495)
												{
													this.$self_$15759.gDMcX0TZJk.vMovement = this.$self_$15759.transform.forward;
													if (182534 - 142304 == 40230)
													{
														this.$self_$15759.gDMcX0TZJk.moveSpeed = (float)0;
														if (204542 - 105881 != 98662)
														{
															if (this.$self_$15759.cAttack_ring)
															{
																if (278756 - 47687 == 231069)
																{
																	this.$self_$15759.gDMcX0TZJk.createEffect(this.$self_$15759.cAttack_ring, this.$self_$15759.transform.position, this.$self_$15759.transform.rotation);
																	if (33369 - 27696 != 5674)
																	{
																		goto Block_8;
																	}
																}
															}
															else
															{
																Debug.Log("Missing cAttack_ring effect ");
																if (187252 - 185385 == 1867)
																{
																	goto IL_1E7;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_CA:
				goto IL_7B0;
				Block_8:
				IL_1E7:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_472:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_7B0:
				return false;
			}

			// Token: 0x06000342 RID: 834 RVA: 0x000553E0 File Offset: 0x000535E0
			internal static bool gdyL82tbsWHXr8aofcT()
			{
				return true;
			}

			// Token: 0x06000343 RID: 835 RVA: 0x000553E4 File Offset: 0x000535E4
			internal static bool QLcr9LtuDdtX7dIlnAG()
			{
				return false;
			}

			// Token: 0x0400032B RID: 811
			internal int $hitLayer$15752;

			// Token: 0x0400032C RID: 812
			internal UnityScript.Lang.Array $hitList$15753;

			// Token: 0x0400032D RID: 813
			internal Vector3 $hitPos$15754;

			// Token: 0x0400032E RID: 814
			internal GameObject $hitObject$15755;

			// Token: 0x0400032F RID: 815
			internal IEnumerator $$iterator$9914$15756;

			// Token: 0x04000330 RID: 816
			internal Vector3 $mPos$15757;

			// Token: 0x04000331 RID: 817
			internal Vector3 $tDir$15758;

			// Token: 0x04000332 RID: 818
			internal GoldenKingBug $self_$15759;
		}
	}

	// Token: 0x02000096 RID: 150
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_airSlasher$15763 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000344 RID: 836 RVA: 0x000553E8 File Offset: 0x000535E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_airSlasher$15763(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
		{
			if (27438 - 294286 != -266847)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (243823 - 319506 != -75682)
				{
					base..ctor();
					if (85832 - 56601 == 29231)
					{
						this.$mPos$15772 = mPos;
						if (191267 - 56323 != 134945)
						{
							this.$tDir$15773 = tDir;
							if (1924 - 48851 != -46926)
							{
								this.$self_$15774 = self_;
								if (22498 - 112558 != -90059)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000554C4 File Offset: 0x000536C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GoldenKingBug.$RPC_airSlasher$15763.$(this.$mPos$15772, this.$tDir$15773, this.$self_$15774);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000554E0 File Offset: 0x000536E0
		internal static bool yMIrsutIXWhRd8PehiL()
		{
			return true;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000554E4 File Offset: 0x000536E4
		internal static bool f6PF9AtBEUicH1q0QJS()
		{
			return false;
		}

		// Token: 0x04000333 RID: 819
		internal Vector3 $mPos$15772;

		// Token: 0x04000334 RID: 820
		internal Vector3 $tDir$15773;

		// Token: 0x04000335 RID: 821
		internal GoldenKingBug $self_$15774;

		// Token: 0x02000097 RID: 151
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000348 RID: 840 RVA: 0x000554E8 File Offset: 0x000536E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
			{
				if (61009 - 130085 != -69075)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (290129 - 441857 == -151728)
					{
						base..ctor();
						if (279730 - 309400 == -29670)
						{
							this.$mPos$15769 = mPos;
							if (188335 - 559501 != -371165)
							{
								this.$tDir$15770 = tDir;
								if (160520 - 366364 != -205843)
								{
									this.$self_$15771 = self_;
									if (50011 - 265642 == -215631)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000349 RID: 841 RVA: 0x000555C4 File Offset: 0x000537C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (253401 - 140335 != 113067)
				{
				}
				for (;;)
				{
					IL_101:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7CB;
					case 2:
						if (this.$self_$15771.gDMcX0TZJk.actionState != "attack")
						{
							goto IL_136;
						}
						if (286700 - 73962 == 212739)
						{
							continue;
						}
						if (this.$self_$15771.gDMcX0TZJk.myCommand != "airSlasher")
						{
							if (162827 - 174509 != -11681)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$hitLayer$15764 = 130816 - (1 << this.$self_$15771.gameObject.layer);
							if (276884 - 577054 == -300169)
							{
								continue;
							}
							this.$hitList$15765 = null;
							if (72251 - 531305 == -459053)
							{
								continue;
							}
							this.$hitPos$15766 = default(Vector3);
							if (279068 - 562103 != -283035)
							{
								continue;
							}
							if (!this.$self_$15771.gDMcX0TZJk.isMine)
							{
								goto IL_72F;
							}
							if (41447 - 504632 != -463185)
							{
								continue;
							}
							this.$hitList$15765 = Damage.FindRecTarget(this.$self_$15771.transform.position - this.$self_$15771.transform.forward, this.$self_$15771.transform.forward, (float)3, (float)12, (float)30, (float)12, this.$hitLayer$15764);
							if (118543 - 424517 != -305974)
							{
								continue;
							}
							this.$$iterator$9915$15768 = UnityRuntimeServices.GetEnumerator(this.$hitList$15765);
							if (85483 - 258945 == -173461)
							{
								continue;
							}
							while (this.$$iterator$9915$15768.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9915$15768.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15767 = (GameObject)obj2;
								if (219625 - 233844 != -14219)
								{
									goto IL_101;
								}
								this.$self_$15771.gDMcX0TZJk.hit(1, this.$hitObject$15767, 2 * this.$self_$15771.gDMcX0TZJk.atk, 20, 0, this.$self_$15771.transform.forward);
								if (138891 - 306575 != -167684)
								{
									goto IL_101;
								}
								UnityRuntimeServices.Update(this.$$iterator$9915$15768, this.$hitObject$15767);
								if (191933 - 594487 != -402554)
								{
									goto IL_101;
								}
							}
							if (199774 - 178193 != 21582)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15771.gDMcX0TZJk.actionState == "attack")
						{
							if (14249 - 256780 != -242531)
							{
								continue;
							}
							if (this.$self_$15771.gDMcX0TZJk.myCommand == "airSlasher")
							{
								if (209695 - 583665 == -373969)
								{
									continue;
								}
								this.$self_$15771.gDMcX0TZJk.actionState = "standby";
								if (75953 - 279995 != -204042)
								{
									continue;
								}
								this.$self_$15771.gDMcX0TZJk.actionTime = Time.time;
								if (11996 - 469781 != -457785)
								{
									continue;
								}
								this.$self_$15771.gDMcX0TZJk.myCommand = "none";
								if (12582 - 536334 == -523751)
								{
									continue;
								}
								if (!this.$self_$15771.gDMcX0TZJk.isMine)
								{
									if (39151 - 483964 != -444813)
									{
										continue;
									}
									this.$self_$15771.gDMcX0TZJk.nPosition = this.$self_$15771.transform.position;
									if (196908 - 481627 != -284719)
									{
										continue;
									}
									this.$self_$15771.gDMcX0TZJk.oPosition = this.$self_$15771.transform.position;
									if (52456 - 448976 != -396520)
									{
										continue;
									}
									this.$self_$15771.gDMcX0TZJk.nDirection = this.$self_$15771.transform.forward;
									if (82180 - 266957 != -184777)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (251285 - 349116 != -97830)
						{
							goto Block_26;
						}
						continue;
					default:
						if (49936 - 41311 == 8626)
						{
							continue;
						}
						break;
					}
					this.$self_$15771.gDMcX0TZJk.actionState = "attack";
					if (90884 - 303096 != -212211)
					{
						this.$self_$15771.gDMcX0TZJk.actionTime = Time.time;
						if (227221 - 593668 == -366447)
						{
							this.$self_$15771.gDMcX0TZJk.myCommand = "airSlasher";
							if (142336 - 344809 == -202473)
							{
								this.$self_$15771.gDMcX0TZJk.addTimeOut("airSlasher", (float)6);
								if (85205 - 373412 != -288206)
								{
									this.$self_$15771.transform.position = this.$mPos$15769;
									if (84958 - 405585 == -320627)
									{
										this.$self_$15771.transform.LookAt(this.$mPos$15769 + global::Math.vFlat(this.$tDir$15770));
										if (290640 - 174344 == 116296)
										{
											this.$self_$15771.animation.CrossFade("airSlasher");
											if (211302 - 203772 == 7530)
											{
												this.$self_$15771.animation.wrapMode = WrapMode.Once;
												if (106574 - 345913 != -239338)
												{
													this.$self_$15771.gDMcX0TZJk.vMovement = this.$self_$15771.transform.forward;
													if (294967 - 106543 != 188425)
													{
														this.$self_$15771.gDMcX0TZJk.moveSpeed = (float)0;
														if (205638 - 564503 != -358864)
														{
															if (this.$self_$15771.airSlasher_ring)
															{
																if (27834 - 251079 != -223244)
																{
																	this.$self_$15771.gDMcX0TZJk.createEffect(this.$self_$15771.airSlasher_ring, this.$self_$15771.transform.position, this.$self_$15771.transform.rotation);
																	if (61618 - 91928 != -30309)
																	{
																		goto Block_41;
																	}
																}
															}
															else
															{
																Debug.Log("Missing airSlasher_ring effect ");
																if (55922 - 447345 != -391422)
																{
																	goto Block_39;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_136:
				goto IL_7CB;
				IL_173:
				return this.Yield(2, new WaitForSeconds(1.2f));
				Block_20:
				goto IL_136;
				Block_22:
				goto IL_72F;
				Block_26:
				goto IL_7CB;
				Block_39:
				Block_41:
				goto IL_173;
				IL_72F:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_7CB:
				return false;
			}

			// Token: 0x0600034A RID: 842 RVA: 0x00055DB0 File Offset: 0x00053FB0
			internal static bool BUPQ6Fte0JdfFQ5ddgp()
			{
				return true;
			}

			// Token: 0x0600034B RID: 843 RVA: 0x00055DB4 File Offset: 0x00053FB4
			internal static bool UgqFZQtrmRp7ip6DNaK()
			{
				return false;
			}

			// Token: 0x04000336 RID: 822
			internal int $hitLayer$15764;

			// Token: 0x04000337 RID: 823
			internal UnityScript.Lang.Array $hitList$15765;

			// Token: 0x04000338 RID: 824
			internal Vector3 $hitPos$15766;

			// Token: 0x04000339 RID: 825
			internal GameObject $hitObject$15767;

			// Token: 0x0400033A RID: 826
			internal IEnumerator $$iterator$9915$15768;

			// Token: 0x0400033B RID: 827
			internal Vector3 $mPos$15769;

			// Token: 0x0400033C RID: 828
			internal Vector3 $tDir$15770;

			// Token: 0x0400033D RID: 829
			internal GoldenKingBug $self_$15771;
		}
	}

	// Token: 0x02000098 RID: 152
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_multiStrike$15775 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600034C RID: 844 RVA: 0x00055DB8 File Offset: 0x00053FB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_multiStrike$15775(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
		{
			if (267926 - 230667 != 37259)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (282848 - 56548 == 226300)
				{
					base..ctor();
					if (145451 - 234432 != -88980)
					{
						this.$mPos$15779 = mPos;
						if (299583 - 263413 != 36171)
						{
							this.$tDir$15780 = tDir;
							if (8508 - 488873 != -480364)
							{
								this.$self_$15781 = self_;
								if (210137 - 378406 == -168269)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00055E94 File Offset: 0x00054094
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GoldenKingBug.$RPC_multiStrike$15775.$(this.$mPos$15779, this.$tDir$15780, this.$self_$15781);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00055EB0 File Offset: 0x000540B0
		internal static bool y04Hl9tj5vEF8NRd6Pt()
		{
			return true;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00055EB4 File Offset: 0x000540B4
		internal static bool LyA0DOthddROVMAgu1n()
		{
			return false;
		}

		// Token: 0x0400033E RID: 830
		internal Vector3 $mPos$15779;

		// Token: 0x0400033F RID: 831
		internal Vector3 $tDir$15780;

		// Token: 0x04000340 RID: 832
		internal GoldenKingBug $self_$15781;

		// Token: 0x02000099 RID: 153
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000350 RID: 848 RVA: 0x00055EB8 File Offset: 0x000540B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
			{
				if (260219 - 363586 != -103367)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (279715 - 224434 == 55281)
					{
						base..ctor();
						if (36999 - 274630 == -237631)
						{
							this.$mPos$15776 = mPos;
							if (24403 - 373500 != -349096)
							{
								this.$tDir$15777 = tDir;
								if (3637 - 302491 == -298854)
								{
									this.$self_$15778 = self_;
									if (125635 - 443689 == -318054)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000351 RID: 849 RVA: 0x00055F94 File Offset: 0x00054194
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (255874 - 350727 != -94852)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5ED;
					case 2:
						if (this.$self_$15778.gDMcX0TZJk.actionState != "attack")
						{
							goto IL_340;
						}
						if (113996 - 278361 != -164365)
						{
							continue;
						}
						if (this.$self_$15778.gDMcX0TZJk.myCommand != "multiStrike")
						{
							if (192831 - 568952 != -376120)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							if (!this.$self_$15778.gDMcX0TZJk.isMine)
							{
								goto IL_59E;
							}
							if (255590 - 59372 != 196218)
							{
								continue;
							}
							this.$self_$15778.StartCoroutine_Auto(this.$self_$15778.multiStrike());
							if (142138 - 278459 != -136321)
							{
								continue;
							}
							goto IL_59E;
						}
						break;
					case 3:
						if (this.$self_$15778.gDMcX0TZJk.actionState == "attack")
						{
							if (117994 - 172035 != -54041)
							{
								continue;
							}
							if (this.$self_$15778.gDMcX0TZJk.myCommand == "multiStrike")
							{
								if (229446 - 88444 == 141003)
								{
									continue;
								}
								this.$self_$15778.gDMcX0TZJk.actionState = "standby";
								if (50231 - 421746 == -371514)
								{
									continue;
								}
								this.$self_$15778.gDMcX0TZJk.actionTime = Time.time;
								if (142678 - 434603 == -291924)
								{
									continue;
								}
								this.$self_$15778.gDMcX0TZJk.myCommand = "none";
								if (125760 - 53808 != 71952)
								{
									continue;
								}
								if (!this.$self_$15778.gDMcX0TZJk.isMine)
								{
									if (66639 - 505362 != -438723)
									{
										continue;
									}
									this.$self_$15778.gDMcX0TZJk.nPosition = this.$self_$15778.transform.position;
									if (11393 - 518106 == -506712)
									{
										continue;
									}
									this.$self_$15778.gDMcX0TZJk.oPosition = this.$self_$15778.transform.position;
									if (99963 - 349577 != -249614)
									{
										continue;
									}
									this.$self_$15778.gDMcX0TZJk.nDirection = this.$self_$15778.transform.forward;
									if (277848 - 496678 == -218829)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (180891 - 414877 != -233985)
						{
							goto Block_21;
						}
						continue;
					default:
						if (295985 - 531236 == -235250)
						{
							continue;
						}
						break;
					}
					this.$self_$15778.gDMcX0TZJk.actionState = "attack";
					if (31630 - 299436 != -267805)
					{
						this.$self_$15778.gDMcX0TZJk.actionTime = Time.time;
						if (34094 - 546792 == -512698)
						{
							this.$self_$15778.gDMcX0TZJk.myCommand = "multiStrike";
							if (29005 - 459627 == -430622)
							{
								this.$self_$15778.gDMcX0TZJk.addTimeOut("multiStrike", (float)18);
								if (95291 - 177641 != -82349)
								{
									this.$self_$15778.transform.position = this.$mPos$15776;
									if (63402 - 531329 != -467926)
									{
										this.$self_$15778.transform.LookAt(this.$mPos$15776 + global::Math.vFlat(this.$tDir$15777));
										if (55812 - 478550 == -422738)
										{
											this.$self_$15778.animation.CrossFade("multiStrike");
											if (285427 - 523501 == -238074)
											{
												this.$self_$15778.animation.wrapMode = WrapMode.Once;
												if (285855 - 310294 != -24438)
												{
													this.$self_$15778.gDMcX0TZJk.vMovement = this.$self_$15778.transform.forward;
													if (124138 - 551383 == -427245)
													{
														this.$self_$15778.gDMcX0TZJk.moveSpeed = (float)0;
														if (43897 - 135296 != -91398)
														{
															if (this.$self_$15778.multiStrike_ring)
															{
																if (4759 - 326301 == -321542)
																{
																	this.$self_$15778.gDMcX0TZJk.createEffect(this.$self_$15778.multiStrike_ring, this.$self_$15778.transform.position, this.$self_$15778.transform.rotation);
																	if (281148 - 348052 != -66903)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.Log("Missing multiStrike_ring effect ");
																if (270108 - 164121 == 105987)
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
				goto IL_45D;
				IL_340:
				Block_21:
				goto IL_5ED;
				IL_45D:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_32:
				goto IL_340;
				IL_59E:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_5ED:
				return false;
			}

			// Token: 0x06000352 RID: 850 RVA: 0x000565A0 File Offset: 0x000547A0
			internal static bool PXVM56tsLimu04wX1yw()
			{
				return true;
			}

			// Token: 0x06000353 RID: 851 RVA: 0x000565A4 File Offset: 0x000547A4
			internal static bool RivbmDt9ppTobRkJliv()
			{
				return false;
			}

			// Token: 0x04000341 RID: 833
			internal Vector3 $mPos$15776;

			// Token: 0x04000342 RID: 834
			internal Vector3 $tDir$15777;

			// Token: 0x04000343 RID: 835
			internal GoldenKingBug $self_$15778;
		}
	}

	// Token: 0x0200009A RID: 154
	[CompilerGenerated]
	[Serializable]
	internal sealed class $multiStrike$15782 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000354 RID: 852 RVA: 0x000565A8 File Offset: 0x000547A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $multiStrike$15782(GoldenKingBug self_)
		{
			if (83306 - 585734 != -502428)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (280178 - 66498 == 213680)
				{
					base..ctor();
					if (115272 - 80089 == 35183)
					{
						this.$self_$15791 = self_;
						if (20383 - 373807 == -353424)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00056640 File Offset: 0x00054840
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GoldenKingBug.$multiStrike$15782.$(this.$self_$15791);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00056650 File Offset: 0x00054850
		internal static bool aE0BHHt1CqAJq6QAoPN()
		{
			return true;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00056654 File Offset: 0x00054854
		internal static bool zFDZTpt4I7xnjuDrEEY()
		{
			return false;
		}

		// Token: 0x04000344 RID: 836
		internal GoldenKingBug $self_$15791;

		// Token: 0x0200009B RID: 155
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000358 RID: 856 RVA: 0x00056658 File Offset: 0x00054858
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GoldenKingBug self_)
			{
				if (207904 - 456894 != -248989)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (270670 - 67372 == 203298)
					{
						base..ctor();
						if (82664 - 239748 != -157083)
						{
							this.$self_$15790 = self_;
							if (176329 - 306319 == -129990)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000359 RID: 857 RVA: 0x000566F0 File Offset: 0x000548F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (250664 - 131952 != 118712)
				{
				}
				for (;;)
				{
					IL_D6:
					switch (this._state)
					{
					case 0:
						goto IL_2C2;
					case 1:
						goto IL_409;
					case 2:
						break;
					default:
						if (125050 - 329129 != -204079)
						{
							continue;
						}
						goto IL_2C2;
					}
					IL_11D:
					while (this.$$iterator$9916$15789.MoveNext())
					{
						object obj2;
						object obj = obj2 = this.$$iterator$9916$15789.Current;
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						this.$hitObject$15786 = (GameObject)obj2;
						if (212102 - 315610 == -103507)
						{
							goto IL_D6;
						}
						if (this.$hitCount$15785 < 12)
						{
							if (247671 - 346649 != -98978)
							{
								goto IL_D6;
							}
							if (this.$self_$15790.gDMcX0TZJk.hit(31, this.$hitObject$15786, 50 * (5 + this.$hitCount$15785), 0, 0, Vector3.zero) != 0)
							{
								if (271998 - 595700 == -323701)
								{
									goto IL_D6;
								}
								this.$hitPos$15787 = default(Vector3);
								if (252417 - 543561 == -291143)
								{
									goto IL_D6;
								}
								if (this.$hitObject$15786.collider)
								{
									if (179547 - 238035 == -58487)
									{
										goto IL_D6;
									}
									this.$hitPos$15787 = this.$hitObject$15786.collider.bounds.center;
									if (293748 - 500625 != -206877)
									{
										goto IL_D6;
									}
									UnityRuntimeServices.Update(this.$$iterator$9916$15789, this.$hitObject$15786);
									if (265360 - 176036 != 89324)
									{
										goto IL_D6;
									}
								}
								else
								{
									this.$hitPos$15787 = this.$hitObject$15786.transform.position + Vector3.up;
									if (63394 - 193607 == -130212)
									{
										goto IL_D6;
									}
									UnityRuntimeServices.Update(this.$$iterator$9916$15789, this.$hitObject$15786);
									if (217451 - 171869 != 45582)
									{
										goto IL_D6;
									}
								}
								this.$hitDir$15788 = UnityEngine.Random.insideUnitSphere;
								if (283286 - 148995 != 134291)
								{
									goto IL_D6;
								}
								this.$self_$15790.RPC_multiStrike_hit(this.$hitPos$15787, this.$hitDir$15788, 0);
								if (37629 - 130947 != -93318)
								{
									goto IL_D6;
								}
								this.$self_$15790.ActionEvent("RPC_multiStrike_hit", this.$hitPos$15787, this.$hitDir$15788, 0);
								if (202507 - 259331 != -56824)
								{
									goto IL_D6;
								}
							}
							this.$hitCount$15785++;
							if (177477 - 171811 != 5666)
							{
								goto IL_D6;
							}
							goto IL_107;
						}
					}
					if (168157 - 329640 == -161482)
					{
						continue;
					}
					this.YieldDefault(1);
					if (17339 - 273124 != -255785)
					{
						continue;
					}
					goto IL_409;
					IL_2C2:
					this.$hitLayer$15783 = 130816 - (1 << this.$self_$15790.gameObject.layer);
					if (126105 - 403854 == -277749)
					{
						this.$hitList$15784 = Damage.FindAreaTarget(this.$self_$15790.transform.position, (float)48, (float)12, this.$hitLayer$15783);
						if (221471 - 123893 != 97579)
						{
							this.$hitCount$15785 = 0;
							if (205758 - 581747 == -375989)
							{
								this.$$iterator$9916$15789 = UnityRuntimeServices.GetEnumerator(this.$hitList$15784);
								if (29614 - 46601 != -16986)
								{
									goto IL_11D;
								}
							}
						}
					}
				}
				IL_107:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_409:
				return false;
			}

			// Token: 0x0600035A RID: 858 RVA: 0x00056B18 File Offset: 0x00054D18
			internal static bool sK0urQtzMgLPqNhp9fA()
			{
				return true;
			}

			// Token: 0x0600035B RID: 859 RVA: 0x00056B1C File Offset: 0x00054D1C
			internal static bool RBl2ecNaXt3reKaV2yj()
			{
				return false;
			}

			// Token: 0x04000345 RID: 837
			internal int $hitLayer$15783;

			// Token: 0x04000346 RID: 838
			internal UnityScript.Lang.Array $hitList$15784;

			// Token: 0x04000347 RID: 839
			internal int $hitCount$15785;

			// Token: 0x04000348 RID: 840
			internal GameObject $hitObject$15786;

			// Token: 0x04000349 RID: 841
			internal Vector3 $hitPos$15787;

			// Token: 0x0400034A RID: 842
			internal Vector3 $hitDir$15788;

			// Token: 0x0400034B RID: 843
			internal IEnumerator $$iterator$9916$15789;

			// Token: 0x0400034C RID: 844
			internal GoldenKingBug $self_$15790;
		}
	}

	// Token: 0x0200009C RID: 156
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_provoke$15792 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600035C RID: 860 RVA: 0x00056B20 File Offset: 0x00054D20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_provoke$15792(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
		{
			if (118962 - 549755 != -430793)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (42731 - 218537 == -175806)
				{
					base..ctor();
					if (259045 - 186647 == 72398)
					{
						this.$mPos$15801 = mPos;
						if (173282 - 85145 == 88137)
						{
							this.$tDir$15802 = tDir;
							if (240556 - 410078 != -169521)
							{
								this.$self_$15803 = self_;
								if (62948 - 474524 != -411575)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00056BFC File Offset: 0x00054DFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GoldenKingBug.$RPC_provoke$15792.$(this.$mPos$15801, this.$tDir$15802, this.$self_$15803);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00056C18 File Offset: 0x00054E18
		internal static bool AsFQ3IN57bK4UsAnh6L()
		{
			return true;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00056C1C File Offset: 0x00054E1C
		internal static bool BnEHbwNpCIbr8xDMO0N()
		{
			return false;
		}

		// Token: 0x0400034D RID: 845
		internal Vector3 $mPos$15801;

		// Token: 0x0400034E RID: 846
		internal Vector3 $tDir$15802;

		// Token: 0x0400034F RID: 847
		internal GoldenKingBug $self_$15803;

		// Token: 0x0200009D RID: 157
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000360 RID: 864 RVA: 0x00056C20 File Offset: 0x00054E20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
			{
				if (283239 - 222092 != 61147)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (195994 - 458268 == -262274)
					{
						base..ctor();
						if (25856 - 179857 == -154001)
						{
							this.$mPos$15798 = mPos;
							if (65409 - 384398 == -318989)
							{
								this.$tDir$15799 = tDir;
								if (280168 - 188263 != 91906)
								{
									this.$self_$15800 = self_;
									if (171547 - 530849 == -359302)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000361 RID: 865 RVA: 0x00056CFC File Offset: 0x00054EFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (233490 - 118255 != 115235)
				{
				}
				for (;;)
				{
					IL_257:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7C7;
					case 2:
						if (this.$self_$15800.gDMcX0TZJk.actionState != "attack")
						{
							goto IL_4D9;
						}
						if (21592 - 274035 != -252443)
						{
							continue;
						}
						if (this.$self_$15800.gDMcX0TZJk.myCommand != "provoke")
						{
							if (248495 - 410197 != -161701)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							if (!this.$self_$15800.gDMcX0TZJk.isMine)
							{
								goto IL_53;
							}
							if (199945 - 63671 != 136274)
							{
								continue;
							}
							this.$hitLayer$15793 = 130816 - (1 << this.$self_$15800.gameObject.layer);
							if (21925 - 185004 != -163079)
							{
								continue;
							}
							this.$hitList$15794 = Damage.FindAreaTarget(this.$self_$15800.transform.position, (float)36, (float)12, this.$hitLayer$15793);
							if (74028 - 301075 == -227046)
							{
								continue;
							}
							this.$$iterator$9917$15797 = UnityRuntimeServices.GetEnumerator(this.$hitList$15794);
							if (123487 - 22914 != 100573)
							{
								continue;
							}
							while (this.$$iterator$9917$15797.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9917$15797.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15795 = (GameObject)obj2;
								if (194556 - 487141 == -292584)
								{
									goto IL_257;
								}
								this.$hitChar$15796 = (CharacterControl)this.$hitObject$15795.GetComponent(typeof(CharacterControl));
								if (146810 - 563036 != -416226)
								{
									goto IL_257;
								}
								UnityRuntimeServices.Update(this.$$iterator$9917$15797, this.$hitObject$15795);
								if (93502 - 20522 != 72980)
								{
									goto IL_257;
								}
								if (this.$hitChar$15796)
								{
									if (295473 - 531640 == -236166)
									{
										goto IL_257;
									}
									this.$hitChar$15796.RPC_AddStatus("provoke", 2, Damage.getDebuff((float)15, this.$self_$15800.gDMcX0TZJk.cha, this.$hitChar$15796.cha), 0, this.$self_$15800.gDMcX0TZJk.ActorNr);
									if (39563 - 461682 != -422119)
									{
										goto IL_257;
									}
								}
							}
							if (278249 - 512196 != -233947)
							{
								continue;
							}
							goto IL_53;
						}
						break;
					case 3:
						if (this.$self_$15800.gDMcX0TZJk.actionState == "attack")
						{
							if (48451 - 152976 != -104525)
							{
								continue;
							}
							if (this.$self_$15800.gDMcX0TZJk.myCommand == "provoke")
							{
								if (227663 - 94957 != 132706)
								{
									continue;
								}
								this.$self_$15800.gDMcX0TZJk.actionState = "standby";
								if (175192 - 284662 == -109469)
								{
									continue;
								}
								this.$self_$15800.gDMcX0TZJk.actionTime = Time.time;
								if (216580 - 501845 == -285264)
								{
									continue;
								}
								this.$self_$15800.gDMcX0TZJk.myCommand = "none";
								if (276963 - 488146 == -211182)
								{
									continue;
								}
								if (!this.$self_$15800.gDMcX0TZJk.isMine)
								{
									if (160548 - 509597 != -349049)
									{
										continue;
									}
									this.$self_$15800.gDMcX0TZJk.nPosition = this.$self_$15800.transform.position;
									if (201171 - 77436 == 123736)
									{
										continue;
									}
									this.$self_$15800.gDMcX0TZJk.oPosition = this.$self_$15800.transform.position;
									if (75230 - 445525 != -370295)
									{
										continue;
									}
									this.$self_$15800.gDMcX0TZJk.nDirection = this.$self_$15800.transform.forward;
									if (293524 - 97649 != 195875)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (269664 - 506161 != -236496)
						{
							goto Block_42;
						}
						continue;
					default:
						if (133686 - 155797 != -22111)
						{
							continue;
						}
						break;
					}
					this.$self_$15800.gDMcX0TZJk.actionState = "attack";
					if (46731 - 580983 == -534252)
					{
						this.$self_$15800.gDMcX0TZJk.actionTime = Time.time;
						if (100691 - 274579 != -173887)
						{
							this.$self_$15800.gDMcX0TZJk.myCommand = "provoke";
							if (249570 - 533431 == -283861)
							{
								this.$self_$15800.gDMcX0TZJk.addTimeOut("provoke", (float)30);
								if (286571 - 370184 == -83613)
								{
									this.$self_$15800.transform.position = this.$mPos$15798;
									if (142110 - 521975 == -379865)
									{
										this.$self_$15800.transform.LookAt(this.$mPos$15798 + global::Math.vFlat(this.$tDir$15799));
										if (59270 - 246041 == -186771)
										{
											this.$self_$15800.animation.CrossFade("provoke");
											if (269260 - 170807 != 98454)
											{
												this.$self_$15800.animation.wrapMode = WrapMode.Once;
												if (70474 - 595359 == -524885)
												{
													this.$self_$15800.gDMcX0TZJk.vMovement = this.$self_$15800.transform.forward;
													if (101255 - 264677 == -163422)
													{
														this.$self_$15800.gDMcX0TZJk.moveSpeed = (float)0;
														if (177653 - 595207 == -417554)
														{
															if (this.$self_$15800.provoke_ring)
															{
																if (9633 - 205698 == -196065)
																{
																	this.$self_$15800.gDMcX0TZJk.createEffect(this.$self_$15800.provoke_ring, this.$self_$15800.transform.position, this.$self_$15800.transform.rotation);
																	if (51739 - 541829 != -490089)
																	{
																		goto Block_28;
																	}
																}
															}
															else
															{
																Debug.Log("Missing provoke_ring effect ");
																if (118068 - 293005 == -174937)
																{
																	goto IL_590;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_53:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_7:
				goto IL_4D9;
				Block_28:
				goto IL_590;
				IL_4D9:
				goto IL_7C7;
				IL_590:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_42:
				IL_7C7:
				return false;
			}

			// Token: 0x06000362 RID: 866 RVA: 0x000574E4 File Offset: 0x000556E4
			internal static bool VLD1taNV4ODZhvIgSFw()
			{
				return true;
			}

			// Token: 0x06000363 RID: 867 RVA: 0x000574E8 File Offset: 0x000556E8
			internal static bool uAkPCsNtf9UfTb5yRSq()
			{
				return false;
			}

			// Token: 0x04000350 RID: 848
			internal int $hitLayer$15793;

			// Token: 0x04000351 RID: 849
			internal UnityScript.Lang.Array $hitList$15794;

			// Token: 0x04000352 RID: 850
			internal GameObject $hitObject$15795;

			// Token: 0x04000353 RID: 851
			internal CharacterControl $hitChar$15796;

			// Token: 0x04000354 RID: 852
			internal IEnumerator $$iterator$9917$15797;

			// Token: 0x04000355 RID: 853
			internal Vector3 $mPos$15798;

			// Token: 0x04000356 RID: 854
			internal Vector3 $tDir$15799;

			// Token: 0x04000357 RID: 855
			internal GoldenKingBug $self_$15800;
		}
	}

	// Token: 0x0200009E RID: 158
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_goldenDust$15804 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000364 RID: 868 RVA: 0x000574EC File Offset: 0x000556EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_goldenDust$15804(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
		{
			if (197930 - 285082 != -87151)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (81164 - 510496 != -429331)
				{
					base..ctor();
					if (131359 - 76267 == 55092)
					{
						this.$mPos$15814 = mPos;
						if (183508 - 196514 == -13006)
						{
							this.$tDir$15815 = tDir;
							if (4744 - 210355 != -205610)
							{
								this.$self_$15816 = self_;
								if (160555 - 546487 == -385932)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000575C8 File Offset: 0x000557C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GoldenKingBug.$RPC_goldenDust$15804.$(this.$mPos$15814, this.$tDir$15815, this.$self_$15816);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000575E4 File Offset: 0x000557E4
		internal static bool z1wCXfNNxabJwLhySM1()
		{
			return true;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000575E8 File Offset: 0x000557E8
		internal static bool IrQ5WvNYpikalkp5ArL()
		{
			return false;
		}

		// Token: 0x04000358 RID: 856
		internal Vector3 $mPos$15814;

		// Token: 0x04000359 RID: 857
		internal Vector3 $tDir$15815;

		// Token: 0x0400035A RID: 858
		internal GoldenKingBug $self_$15816;

		// Token: 0x0200009F RID: 159
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000368 RID: 872 RVA: 0x000575EC File Offset: 0x000557EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
			{
				if (159188 - 359684 != -200496)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (38161 - 71710 == -33549)
					{
						base..ctor();
						if (282938 - 197565 != 85374)
						{
							this.$mPos$15811 = mPos;
							if (163037 - 593483 == -430446)
							{
								this.$tDir$15812 = tDir;
								if (229295 - 171225 == 58070)
								{
									this.$self_$15813 = self_;
									if (202452 - 143926 != 58527)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000369 RID: 873 RVA: 0x000576C8 File Offset: 0x000558C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (235880 - 348105 != -112225)
				{
				}
				for (;;)
				{
					IL_349:
					switch (this._state)
					{
					case 0:
						goto IL_8BA;
					case 1:
						goto IL_990;
					case 2:
						if (this.$self_$15813.gDMcX0TZJk.actionState != "attack")
						{
							goto IL_50B;
						}
						if (81764 - 212372 == -130607)
						{
							continue;
						}
						if (this.$self_$15813.gDMcX0TZJk.myCommand != "goldenDust")
						{
							if (134459 - 65208 != 69251)
							{
								continue;
							}
							goto IL_50B;
						}
						else
						{
							if (this.$self_$15813.goldenDust_ring2)
							{
								if (56844 - 401046 != -344202)
								{
									continue;
								}
								this.$self_$15813.gDMcX0TZJk.createEffect(this.$self_$15813.goldenDust_ring2, this.$self_$15813.transform.position, this.$self_$15813.transform.rotation);
								if (190421 - 368068 == -177646)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Missing goldenDust_ring2 effect ");
								if (90461 - 74750 != 15711)
								{
									continue;
								}
							}
							this.$hitLayer$15805 = 130816 - (1 << this.$self_$15813.gameObject.layer);
							if (34015 - 517108 != -483093)
							{
								continue;
							}
							this.$hitList$15806 = null;
							if (64917 - 69395 != -4478)
							{
								continue;
							}
							this.$hitPos$15807 = default(Vector3);
							if (69651 - 78173 != -8522)
							{
								continue;
							}
							this.$i$15808 = 0;
							if (118364 - 80080 != 38284)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$15813.gDMcX0TZJk.actionState != "attack")
						{
							goto IL_155;
						}
						if (213498 - 435765 != -222267)
						{
							continue;
						}
						if (this.$self_$15813.gDMcX0TZJk.myCommand != "goldenDust")
						{
							if (175763 - 221297 != -45534)
							{
								continue;
							}
							goto IL_155;
						}
						else
						{
							this.$i$15808++;
							if (1943 - 272901 != -270958)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$15813.gDMcX0TZJk.actionState == "attack")
						{
							if (195829 - 451696 != -255867)
							{
								continue;
							}
							if (this.$self_$15813.gDMcX0TZJk.myCommand == "goldenDust")
							{
								if (57735 - 176493 == -118757)
								{
									continue;
								}
								this.$self_$15813.gDMcX0TZJk.actionState = "standby";
								if (164098 - 360905 == -196806)
								{
									continue;
								}
								this.$self_$15813.gDMcX0TZJk.actionTime = Time.time;
								if (106459 - 544050 != -437591)
								{
									continue;
								}
								this.$self_$15813.gDMcX0TZJk.myCommand = "none";
								if (261169 - 164367 != 96802)
								{
									continue;
								}
								if (!this.$self_$15813.gDMcX0TZJk.isMine)
								{
									if (230105 - 563974 != -333869)
									{
										continue;
									}
									this.$self_$15813.gDMcX0TZJk.nPosition = this.$self_$15813.transform.position;
									if (152584 - 370064 != -217480)
									{
										continue;
									}
									this.$self_$15813.gDMcX0TZJk.oPosition = this.$self_$15813.transform.position;
									if (53110 - 27729 == 25382)
									{
										continue;
									}
									this.$self_$15813.gDMcX0TZJk.nDirection = this.$self_$15813.transform.forward;
									if (156045 - 131896 != 24149)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (235531 - 25930 != 209601)
						{
							continue;
						}
						goto IL_990;
					default:
						if (4840 - 324409 != -319568)
						{
							goto IL_8BA;
						}
						continue;
					}
					if (this.$i$15808 >= 10)
					{
						if (115139 - 92730 != 22410)
						{
							goto Block_47;
						}
						continue;
					}
					else
					{
						if (!this.$self_$15813.gDMcX0TZJk.isMine)
						{
							goto IL_6B9;
						}
						if (66249 - 199498 != -133249)
						{
							continue;
						}
						this.$self_$15813.gDMcX0TZJk.RPC_AddHeal(51, 1000, 0, 0, 0, 0, this.$self_$15813.gDMcX0TZJk.ActorNr);
						if (238202 - 415077 == -176874)
						{
							continue;
						}
						this.$hitList$15806 = Damage.FindAreaTarget(this.$self_$15813.transform.position, (float)Mathf.Clamp(this.$i$15808 * 3, 6, 30), (float)12, this.$hitLayer$15805);
						if (211873 - 222451 == -10577)
						{
							continue;
						}
						this.$$iterator$9918$15810 = UnityRuntimeServices.GetEnumerator(this.$hitList$15806);
						if (190792 - 270266 == -79473)
						{
							continue;
						}
						while (this.$$iterator$9918$15810.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$9918$15810.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$15809 = (GameObject)obj2;
							if (210335 - 250381 == -40045)
							{
								goto IL_349;
							}
							this.$self_$15813.gDMcX0TZJk.hit(1, this.$hitObject$15809, 200, 1, 0, Vector3.zero);
							if (224851 - 561776 != -336925)
							{
								goto IL_349;
							}
							UnityRuntimeServices.Update(this.$$iterator$9918$15810, this.$hitObject$15809);
							if (72104 - 295840 == -223735)
							{
								goto IL_349;
							}
						}
						if (60093 - 124528 != -64434)
						{
							goto Block_22;
						}
						continue;
					}
					IL_8BA:
					this.$self_$15813.gDMcX0TZJk.actionState = "attack";
					if (236063 - 451020 != -214956)
					{
						this.$self_$15813.gDMcX0TZJk.actionTime = Time.time;
						if (148669 - 113368 != 35302)
						{
							this.$self_$15813.gDMcX0TZJk.myCommand = "goldenDust";
							if (231058 - 191897 == 39161)
							{
								this.$self_$15813.gDMcX0TZJk.addTimeOut("goldenDust", (float)90);
								if (219591 - 87696 == 131895)
								{
									this.$self_$15813.transform.position = this.$mPos$15811;
									if (57270 - 359419 != -302148)
									{
										this.$self_$15813.transform.LookAt(this.$mPos$15811 + global::Math.vFlat(this.$tDir$15812));
										if (96699 - 350683 == -253984)
										{
											this.$self_$15813.animation.CrossFade("goldenDust");
											if (271104 - 356135 == -85031)
											{
												this.$self_$15813.animation.wrapMode = WrapMode.Once;
												if (130073 - 125001 != 5073)
												{
													this.$self_$15813.gDMcX0TZJk.vMovement = this.$self_$15813.transform.forward;
													if (28488 - 302176 != -273687)
													{
														this.$self_$15813.gDMcX0TZJk.moveSpeed = (float)0;
														if (298575 - 369062 != -70486)
														{
															if (this.$self_$15813.goldenDust_ring1)
															{
																if (46768 - 371083 != -324314)
																{
																	this.$self_$15813.gDMcX0TZJk.createEffect(this.$self_$15813.goldenDust_ring1, this.$self_$15813.transform.position, this.$self_$15813.transform.rotation);
																	if (283970 - 343818 == -59848)
																	{
																		goto IL_967;
																	}
																}
															}
															else
															{
																Debug.Log("Missing goldenDust_ring1 effect ");
																if (127067 - 37464 == 89603)
																{
																	goto IL_43A;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_155:
				goto IL_990;
				Block_22:
				goto IL_6B9;
				IL_43A:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_50B:
				goto IL_990;
				IL_6B9:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_47:
				return this.Yield(4, new WaitForSeconds(0.7f));
				IL_967:
				goto IL_43A;
				IL_990:
				return false;
			}

			// Token: 0x0600036A RID: 874 RVA: 0x00058078 File Offset: 0x00056278
			internal static bool NN7cFANcAtFCUUUrPZa()
			{
				return true;
			}

			// Token: 0x0600036B RID: 875 RVA: 0x0005807C File Offset: 0x0005627C
			internal static bool ajAA8pNUxhOVJ8vjP1M()
			{
				return false;
			}

			// Token: 0x0400035B RID: 859
			internal int $hitLayer$15805;

			// Token: 0x0400035C RID: 860
			internal UnityScript.Lang.Array $hitList$15806;

			// Token: 0x0400035D RID: 861
			internal Vector3 $hitPos$15807;

			// Token: 0x0400035E RID: 862
			internal int $i$15808;

			// Token: 0x0400035F RID: 863
			internal GameObject $hitObject$15809;

			// Token: 0x04000360 RID: 864
			internal IEnumerator $$iterator$9918$15810;

			// Token: 0x04000361 RID: 865
			internal Vector3 $mPos$15811;

			// Token: 0x04000362 RID: 866
			internal Vector3 $tDir$15812;

			// Token: 0x04000363 RID: 867
			internal GoldenKingBug $self_$15813;
		}
	}

	// Token: 0x020000A0 RID: 160
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_hover$15817 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600036C RID: 876 RVA: 0x00058080 File Offset: 0x00056280
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_hover$15817(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
		{
			if (266873 - 59716 != 207157)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (204879 - 354084 == -149205)
				{
					base..ctor();
					if (275077 - 529111 != -254033)
					{
						this.$mPos$15827 = mPos;
						if (227121 - 576715 == -349594)
						{
							this.$tDir$15828 = tDir;
							if (216828 - 7141 != 209688)
							{
								this.$self_$15829 = self_;
								if (139388 - 583642 != -444253)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0005815C File Offset: 0x0005635C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GoldenKingBug.$RPC_hover$15817.$(this.$mPos$15827, this.$tDir$15828, this.$self_$15829);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00058178 File Offset: 0x00056378
		internal static bool qDAgERNT4OKGo108FJ8()
		{
			return true;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0005817C File Offset: 0x0005637C
		internal static bool nsu9dcN39oRfsdp0xaE()
		{
			return false;
		}

		// Token: 0x04000364 RID: 868
		internal Vector3 $mPos$15827;

		// Token: 0x04000365 RID: 869
		internal Vector3 $tDir$15828;

		// Token: 0x04000366 RID: 870
		internal GoldenKingBug $self_$15829;

		// Token: 0x020000A1 RID: 161
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000370 RID: 880 RVA: 0x00058180 File Offset: 0x00056380
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
			{
				if (32513 - 196337 != -163823)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (213318 - 214312 == -994)
					{
						base..ctor();
						if (13538 - 592349 != -578810)
						{
							this.$mPos$15824 = mPos;
							if (22179 - 272348 != -250168)
							{
								this.$tDir$15825 = tDir;
								if (5053 - 295797 != -290743)
								{
									this.$self_$15826 = self_;
									if (138295 - 28362 == 109933)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000371 RID: 881 RVA: 0x0005825C File Offset: 0x0005645C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (118329 - 496254 != -377924)
				{
				}
				for (;;)
				{
					IL_323:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_86A;
					case 2:
						if (this.$self_$15826.gDMcX0TZJk.actionState != "attack")
						{
							goto IL_1D2;
						}
						if (198725 - 498135 != -299410)
						{
							continue;
						}
						if (this.$self_$15826.gDMcX0TZJk.myCommand != "hover")
						{
							if (246041 - 512694 != -266652)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							this.$$iterator$9920$15823 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$15819);
							if (133616 - 15885 == 117732)
							{
								continue;
							}
							while (this.$$iterator$9920$15823.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9920$15823.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$ignoreObject$15822 = (GameObject)obj2;
								if (81872 - 38075 == 43798)
								{
									goto IL_323;
								}
								if (this.$ignoreObject$15822)
								{
									if (245691 - 297185 == -51493)
									{
										goto IL_323;
									}
									if (this.$self_$15826.gameObject != this.$ignoreObject$15822)
									{
										if (14525 - 369261 != -354736)
										{
											goto IL_323;
										}
										Physics.IgnoreCollision(this.$self_$15826.gameObject.collider, this.$ignoreObject$15822.collider, false);
										if (69702 - 74576 != -4874)
										{
											goto IL_323;
										}
										UnityRuntimeServices.Update(this.$$iterator$9920$15823, this.$ignoreObject$15822);
										if (255859 - 130013 != 125846)
										{
											goto IL_323;
										}
									}
								}
							}
							if (266369 - 343049 != -76680)
							{
								continue;
							}
							goto IL_5D6;
						}
						break;
					case 3:
						if (this.$self_$15826.gDMcX0TZJk.actionState == "attack")
						{
							if (298495 - 279725 == 18771)
							{
								continue;
							}
							if (this.$self_$15826.gDMcX0TZJk.myCommand == "hover")
							{
								if (113901 - 85863 == 28039)
								{
									continue;
								}
								this.$self_$15826.gDMcX0TZJk.actionState = "standby";
								if (183541 - 254182 != -70641)
								{
									continue;
								}
								this.$self_$15826.gDMcX0TZJk.actionTime = Time.time;
								if (261720 - 438107 == -176386)
								{
									continue;
								}
								this.$self_$15826.gDMcX0TZJk.myCommand = "none";
								if (122680 - 60843 == 61838)
								{
									continue;
								}
								if (!this.$self_$15826.gDMcX0TZJk.isMine)
								{
									if (110442 - 169881 != -59439)
									{
										continue;
									}
									this.$self_$15826.gDMcX0TZJk.nPosition = this.$self_$15826.transform.position;
									if (67495 - 342422 != -274927)
									{
										continue;
									}
									this.$self_$15826.gDMcX0TZJk.oPosition = this.$self_$15826.transform.position;
									if (195733 - 213943 == -18209)
									{
										continue;
									}
									this.$self_$15826.gDMcX0TZJk.nDirection = this.$self_$15826.transform.forward;
									if (261948 - 178956 == 82993)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (257680 - 147238 != 110443)
						{
							goto Block_17;
						}
						continue;
					default:
						if (266869 - 180996 != 85873)
						{
							continue;
						}
						break;
					}
					this.$self_$15826.gDMcX0TZJk.actionState = "attack";
					if (54487 - 70994 != -16506)
					{
						this.$self_$15826.gDMcX0TZJk.actionTime = Time.time;
						if (144389 - 379820 == -235431)
						{
							this.$self_$15826.gDMcX0TZJk.myCommand = "hover";
							if (185336 - 202819 == -17483)
							{
								this.$self_$15826.gDMcX0TZJk.addTimeOut("hover", (float)12);
								if (134409 - 503055 == -368646)
								{
									this.$self_$15826.transform.position = this.$mPos$15824;
									if (50148 - 472065 == -421917)
									{
										this.$self_$15826.transform.LookAt(this.$mPos$15824 + global::Math.vFlat(this.$tDir$15825));
										if (5653 - 280281 != -274627)
										{
											this.$self_$15826.animation.CrossFade("charge");
											if (145352 - 528672 == -383320)
											{
												this.$self_$15826.animation.wrapMode = WrapMode.Loop;
												if (3881 - 137293 != -133411)
												{
													this.$self_$15826.gDMcX0TZJk.vMovement = this.$self_$15826.transform.forward;
													if (228290 - 447153 != -218862)
													{
														this.$self_$15826.gDMcX0TZJk.moveSpeed = (float)6;
														if (147840 - 475782 != -327941)
														{
															this.$self_$15826.gDMcX0TZJk.removeLockStatus(5);
															if (84924 - 280609 != -195684)
															{
																this.$ignoreLayer$15818 = 130818;
																if (209817 - 139427 == 70390)
																{
																	this.$ignoreList$15819 = Damage.FindRecTarget(this.$self_$15826.transform.position - this.$self_$15826.transform.forward, this.$self_$15826.transform.forward, (float)2, (float)2, (float)10, (float)4, this.$ignoreLayer$15818);
																	if (19750 - 582688 == -562938)
																	{
																		this.$$iterator$9919$15821 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$15819);
																		if (6283 - 453881 != -447597)
																		{
																			while (this.$$iterator$9919$15821.MoveNext())
																			{
																				object obj4;
																				object obj3 = obj4 = this.$$iterator$9919$15821.Current;
																				if (!(obj3 is GameObject))
																				{
																					obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
																				}
																				this.$ignoreObject$15820 = (GameObject)obj4;
																				if (75254 - 377945 != -302691)
																				{
																					goto IL_323;
																				}
																				if (this.$ignoreObject$15820)
																				{
																					if (246759 - 109663 == 137097)
																					{
																						goto IL_323;
																					}
																					if (this.$self_$15826.gameObject != this.$ignoreObject$15820)
																					{
																						if (174290 - 479868 != -305578)
																						{
																							goto IL_323;
																						}
																						Physics.IgnoreCollision(this.$self_$15826.gameObject.collider, this.$ignoreObject$15820.collider, true);
																						if (71098 - 287978 != -216880)
																						{
																							goto IL_323;
																						}
																						UnityRuntimeServices.Update(this.$$iterator$9919$15821, this.$ignoreObject$15820);
																						if (126720 - 36656 == 90065)
																						{
																							goto IL_323;
																						}
																					}
																				}
																			}
																			if (195828 - 510133 == -314305)
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
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_1D2:
				Block_17:
				goto IL_86A;
				IL_5D6:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_43:
				IL_86A:
				return false;
			}

			// Token: 0x06000372 RID: 882 RVA: 0x00058AE8 File Offset: 0x00056CE8
			internal static bool TNqU2yNXwolgZSqyQiy()
			{
				return true;
			}

			// Token: 0x06000373 RID: 883 RVA: 0x00058AEC File Offset: 0x00056CEC
			internal static bool EH6xZ0NQtpcCgXgreIP()
			{
				return false;
			}

			// Token: 0x04000367 RID: 871
			internal int $ignoreLayer$15818;

			// Token: 0x04000368 RID: 872
			internal UnityScript.Lang.Array $ignoreList$15819;

			// Token: 0x04000369 RID: 873
			internal GameObject $ignoreObject$15820;

			// Token: 0x0400036A RID: 874
			internal IEnumerator $$iterator$9919$15821;

			// Token: 0x0400036B RID: 875
			internal GameObject $ignoreObject$15822;

			// Token: 0x0400036C RID: 876
			internal IEnumerator $$iterator$9920$15823;

			// Token: 0x0400036D RID: 877
			internal Vector3 $mPos$15824;

			// Token: 0x0400036E RID: 878
			internal Vector3 $tDir$15825;

			// Token: 0x0400036F RID: 879
			internal GoldenKingBug $self_$15826;
		}
	}

	// Token: 0x020000A2 RID: 162
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_fly$15830 : GenericGenerator<WaitForFixedUpdate>
	{
		// Token: 0x06000374 RID: 884 RVA: 0x00058AF0 File Offset: 0x00056CF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_fly$15830(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
		{
			if (157481 - 378474 != -220992)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (81885 - 488574 != -406688)
				{
					base..ctor();
					if (237650 - 336047 == -98397)
					{
						this.$mPos$15834 = mPos;
						if (235120 - 206512 == 28608)
						{
							this.$tDir$15835 = tDir;
							if (75224 - 370334 == -295110)
							{
								this.$self_$15836 = self_;
								if (150688 - 165951 != -15262)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00058BCC File Offset: 0x00056DCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForFixedUpdate> GetEnumerator()
		{
			return new GoldenKingBug.$RPC_fly$15830.$(this.$mPos$15834, this.$tDir$15835, this.$self_$15836);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00058BE8 File Offset: 0x00056DE8
		internal static bool qYhJ5CNkIjsk117TH2V()
		{
			return true;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00058BEC File Offset: 0x00056DEC
		internal static bool GGD7QtNGZl9wj9rHptb()
		{
			return false;
		}

		// Token: 0x04000370 RID: 880
		internal Vector3 $mPos$15834;

		// Token: 0x04000371 RID: 881
		internal Vector3 $tDir$15835;

		// Token: 0x04000372 RID: 882
		internal GoldenKingBug $self_$15836;

		// Token: 0x020000A3 RID: 163
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForFixedUpdate>, IEnumerator
		{
			// Token: 0x06000378 RID: 888 RVA: 0x00058BF0 File Offset: 0x00056DF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
			{
				if (102074 - 250406 != -148332)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (143654 - 585080 != -441425)
					{
						base..ctor();
						if (60955 - 529280 != -468324)
						{
							this.$mPos$15831 = mPos;
							if (3426 - 93834 != -90407)
							{
								this.$tDir$15832 = tDir;
								if (191737 - 462403 != -270665)
								{
									this.$self_$15833 = self_;
									if (173848 - 512921 == -339073)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000379 RID: 889 RVA: 0x00058CCC File Offset: 0x00056ECC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (172206 - 37531 != 134675)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2B0;
					case 1:
						goto IL_39C;
					case 2:
						break;
					default:
						if (94051 - 213591 != -119539)
						{
							goto IL_2B0;
						}
						continue;
					}
					IL_152:
					if (this.$self_$15833.gDMcX0TZJk.actionState == "fly")
					{
						break;
					}
					if (184409 - 318596 == -134186)
					{
						continue;
					}
					if (this.$self_$15833.gDMcX0TZJk.myCommand == "charge")
					{
						break;
					}
					if (91833 - 122681 != -30848)
					{
						continue;
					}
					this.$self_$15833.audio.Stop();
					if (223396 - 61617 != 161779)
					{
						continue;
					}
					this.YieldDefault(1);
					if (165102 - 148701 != 16401)
					{
						continue;
					}
					goto IL_39C;
					IL_2B0:
					this.$self_$15833.gDMcX0TZJk.actionState = "fly";
					if (89338 - 46153 != 43186)
					{
						this.$self_$15833.gDMcX0TZJk.actionTime = Time.time;
						if (128550 - 458402 != -329851)
						{
							this.$self_$15833.gDMcX0TZJk.myCommand = "fly";
							if (139488 - 327493 != -188004)
							{
								this.$self_$15833.gDMcX0TZJk.addTimeOut("fly", (float)120);
								if (222210 - 580737 == -358527)
								{
									this.$self_$15833.transform.position = this.$mPos$15831;
									if (109240 - 48650 == 60590)
									{
										this.$self_$15833.transform.LookAt(this.$mPos$15831 + global::Math.vFlat(this.$tDir$15832));
										if (242658 - 193527 == 49131)
										{
											this.$self_$15833.animation.CrossFade("fly");
											if (145248 - 135652 != 9597)
											{
												this.$self_$15833.animation.wrapMode = WrapMode.Loop;
												if (80471 - 411085 == -330614)
												{
													this.$self_$15833.gDMcX0TZJk.vMovement = this.$self_$15833.transform.forward;
													if (14417 - 43065 == -28648)
													{
														this.$self_$15833.gDMcX0TZJk.moveSpeed = (float)0;
														if (260050 - 444600 == -184550)
														{
															if (this.$self_$15833.goldenKingBug_cry)
															{
																if (258831 - 167773 == 91059)
																{
																	continue;
																}
																this.$self_$15833.audio.PlayOneShot(this.$self_$15833.goldenKingBug_cry);
																if (233333 - 558605 == -325271)
																{
																	continue;
																}
															}
															this.$self_$15833.audio.Play();
															if (24911 - 116682 != -91770)
															{
																goto IL_152;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForFixedUpdate());
				IL_39C:
				return false;
			}

			// Token: 0x0600037A RID: 890 RVA: 0x00059088 File Offset: 0x00057288
			internal static bool zNjAVjNHY1vtLBnuCTv()
			{
				return true;
			}

			// Token: 0x0600037B RID: 891 RVA: 0x0005908C File Offset: 0x0005728C
			internal static bool GgqaQONWPW9EHCye0KS()
			{
				return false;
			}

			// Token: 0x04000373 RID: 883
			internal Vector3 $mPos$15831;

			// Token: 0x04000374 RID: 884
			internal Vector3 $tDir$15832;

			// Token: 0x04000375 RID: 885
			internal GoldenKingBug $self_$15833;
		}
	}

	// Token: 0x020000A4 RID: 164
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_charge$15837 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600037C RID: 892 RVA: 0x00059090 File Offset: 0x00057290
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_charge$15837(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
		{
			if (127153 - 357151 != -229997)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (273328 - 329611 != -56282)
				{
					base..ctor();
					if (76604 - 157545 != -80940)
					{
						this.$mPos$15852 = mPos;
						if (195752 - 45815 == 149937)
						{
							this.$tDir$15853 = tDir;
							if (163556 - 289205 == -125649)
							{
								this.$self_$15854 = self_;
								if (221326 - 442000 != -220673)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0005916C File Offset: 0x0005736C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GoldenKingBug.$RPC_charge$15837.$(this.$mPos$15852, this.$tDir$15853, this.$self_$15854);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00059188 File Offset: 0x00057388
		internal static bool VVirr9NAWAdJ2TTlObf()
		{
			return true;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0005918C File Offset: 0x0005738C
		internal static bool rlHjFINlBAU7xciD34U()
		{
			return false;
		}

		// Token: 0x04000376 RID: 886
		internal Vector3 $mPos$15852;

		// Token: 0x04000377 RID: 887
		internal Vector3 $tDir$15853;

		// Token: 0x04000378 RID: 888
		internal GoldenKingBug $self_$15854;

		// Token: 0x020000A5 RID: 165
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000380 RID: 896 RVA: 0x00059190 File Offset: 0x00057390
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GoldenKingBug self_)
			{
				if (278741 - 318938 != -40197)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (17781 - 6217 != 11565)
					{
						base..ctor();
						if (182444 - 579648 != -397203)
						{
							this.$mPos$15849 = mPos;
							if (129656 - 322311 == -192655)
							{
								this.$tDir$15850 = tDir;
								if (213334 - 464590 == -251256)
								{
									this.$self_$15851 = self_;
									if (33529 - 579149 != -545619)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000381 RID: 897 RVA: 0x0005926C File Offset: 0x0005746C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (196257 - 475584 != -279327)
				{
				}
				for (;;)
				{
					IL_A4E:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C73;
					case 2:
						if (this.$self_$15851.gDMcX0TZJk.actionState != "attack")
						{
							goto IL_A1E;
						}
						if (174627 - 461354 != -286727)
						{
							continue;
						}
						if (this.$self_$15851.gDMcX0TZJk.myCommand != "charge")
						{
							if (247330 - 208068 != 39263)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$$iterator$9922$15843 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$15839);
							if (60253 - 338362 == -278108)
							{
								continue;
							}
							while (this.$$iterator$9922$15843.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9922$15843.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$ignoreObject$15842 = (GameObject)obj2;
								if (94296 - 116160 != -21864)
								{
									goto IL_A4E;
								}
								if (this.$ignoreObject$15842)
								{
									if (266282 - 21245 == 245038)
									{
										goto IL_A4E;
									}
									if (this.$self_$15851.gameObject != this.$ignoreObject$15842)
									{
										if (195060 - 348371 == -153310)
										{
											goto IL_A4E;
										}
										Physics.IgnoreCollision(this.$self_$15851.gameObject.collider, this.$ignoreObject$15842.collider, false);
										if (132834 - 173807 == -40972)
										{
											goto IL_A4E;
										}
										UnityRuntimeServices.Update(this.$$iterator$9922$15843, this.$ignoreObject$15842);
										if (22031 - 419650 != -397619)
										{
											goto IL_A4E;
										}
									}
								}
							}
							if (281387 - 313763 != -32376)
							{
								continue;
							}
							if (!this.$self_$15851.gDMcX0TZJk.isMine)
							{
								goto IL_800;
							}
							if (5915 - 10374 == -4458)
							{
								continue;
							}
							this.$hitLayer$15844 = 130816 - (1 << this.$self_$15851.gameObject.layer);
							if (158492 - 525146 == -366653)
							{
								continue;
							}
							this.$hitList$15845 = Damage.FindRecTarget(this.$self_$15851.transform.position - (float)3 * this.$self_$15851.transform.forward, this.$self_$15851.transform.forward, (float)2, (float)2, (float)6, (float)6, this.$hitLayer$15844);
							if (22471 - 254058 != -231587)
							{
								continue;
							}
							this.$$iterator$9923$15848 = UnityRuntimeServices.GetEnumerator(this.$hitList$15845);
							if (91431 - 139419 != -47988)
							{
								continue;
							}
							while (this.$$iterator$9923$15848.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9923$15848.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$15846 = (GameObject)obj4;
								if (143999 - 57213 == 86787)
								{
									goto IL_A4E;
								}
								if (this.$self_$15851.gDMcX0TZJk.hit(1, this.$hitObject$15846, 2 * this.$self_$15851.gDMcX0TZJk.atk, 1, 0, Vector3.zero) != 0)
								{
									if (127546 - 70875 != 56671)
									{
										goto IL_A4E;
									}
									this.$hitPos$15847 = this.$hitObject$15846.collider.ClosestPointOnBounds(this.$self_$15851.transform.position + 1.5f * Vector3.up);
									if (180547 - 154116 == 26432)
									{
										goto IL_A4E;
									}
									UnityRuntimeServices.Update(this.$$iterator$9923$15848, this.$hitObject$15846);
									if (16083 - 72136 != -56053)
									{
										goto IL_A4E;
									}
									this.$self_$15851.RPC_nAttack_hit(this.$hitPos$15847, this.$self_$15851.transform.forward, 0);
									if (270808 - 77160 == 193649)
									{
										goto IL_A4E;
									}
									this.$self_$15851.ActionEvent("RPC_nAttack_hit", this.$hitPos$15847, this.$self_$15851.transform.forward, 0);
									if (135189 - 80662 == 54528)
									{
										goto IL_A4E;
									}
								}
							}
							if (245118 - 165620 != 79499)
							{
								goto Block_68;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15851.gDMcX0TZJk.actionState == "attack")
						{
							if (284302 - 286944 == -2641)
							{
								continue;
							}
							if (this.$self_$15851.gDMcX0TZJk.myCommand == "charge")
							{
								if (74768 - 61034 == 13735)
								{
									continue;
								}
								if (this.$self_$15851.gDMcX0TZJk.isControlled)
								{
									if (35637 - 180272 == -144634)
									{
										continue;
									}
									this.$self_$15851.gDMcX0TZJk.actionState = "standby";
									if (282652 - 392123 == -109470)
									{
										continue;
									}
									this.$self_$15851.gDMcX0TZJk.actionTime = Time.time;
									if (269524 - 316901 != -47377)
									{
										continue;
									}
									this.$self_$15851.gDMcX0TZJk.myCommand = "none";
									if (27237 - 3080 == 24158)
									{
										continue;
									}
								}
								else
								{
									this.$self_$15851.gDMcX0TZJk.actionState = "fly";
									if (245163 - 131186 == 113978)
									{
										continue;
									}
									this.$self_$15851.gDMcX0TZJk.actionTime = Time.time;
									if (122990 - 73164 != 49826)
									{
										continue;
									}
									this.$self_$15851.gDMcX0TZJk.myCommand = "fly";
									if (54218 - 512137 != -457919)
									{
										continue;
									}
								}
								if (!this.$self_$15851.gDMcX0TZJk.isMine)
								{
									if (297779 - 563294 == -265514)
									{
										continue;
									}
									this.$self_$15851.gDMcX0TZJk.nPosition = this.$self_$15851.transform.position;
									if (120861 - 186398 == -65536)
									{
										continue;
									}
									this.$self_$15851.gDMcX0TZJk.oPosition = this.$self_$15851.transform.position;
									if (86014 - 137928 == -51913)
									{
										continue;
									}
									this.$self_$15851.gDMcX0TZJk.nDirection = this.$self_$15851.transform.forward;
									if (105989 - 81355 == 24635)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (125526 - 445898 != -320372)
						{
							continue;
						}
						goto IL_C73;
					default:
						if (144662 - 47017 != 97645)
						{
							continue;
						}
						break;
					}
					this.$self_$15851.gDMcX0TZJk.actionState = "attack";
					if (193630 - 186529 == 7101)
					{
						this.$self_$15851.gDMcX0TZJk.actionTime = Time.time;
						if (170066 - 560524 != -390457)
						{
							this.$self_$15851.gDMcX0TZJk.myCommand = "charge";
							if (134370 - 73242 != 61129)
							{
								this.$self_$15851.gDMcX0TZJk.addTimeOut("charge", (float)2);
								if (73563 - 2923 == 70640)
								{
									this.$self_$15851.transform.position = this.$mPos$15849;
									if (118346 - 250974 != -132627)
									{
										this.$self_$15851.transform.LookAt(this.$mPos$15849 + global::Math.vFlat(this.$tDir$15850));
										if (289065 - 287419 == 1646)
										{
											this.$self_$15851.animation.CrossFade("charge");
											if (161919 - 91624 == 70295)
											{
												this.$self_$15851.animation.wrapMode = WrapMode.Once;
												if (108271 - 321015 != -212743)
												{
													this.$self_$15851.gDMcX0TZJk.vMovement = this.$self_$15851.transform.forward;
													if (41384 - 219035 != -177650)
													{
														this.$self_$15851.gDMcX0TZJk.moveSpeed = (float)12;
														if (69879 - 367409 != -297529)
														{
															if (this.$self_$15851.charge_ring)
															{
																if (47418 - 59622 == -12203)
																{
																	continue;
																}
																this.$self_$15851.gDMcX0TZJk.createEffect(this.$self_$15851.charge_ring, this.$self_$15851.transform.position, this.$self_$15851.transform.rotation);
																if (101284 - 474831 != -373547)
																{
																	continue;
																}
															}
															else
															{
																Debug.Log("Missing charge_ring effect ");
																if (246206 - 552567 == -306360)
																{
																	continue;
																}
															}
															this.$ignoreLayer$15838 = 130818;
															if (253325 - 483388 == -230063)
															{
																this.$ignoreList$15839 = Damage.FindRecTarget(this.$self_$15851.transform.position - this.$self_$15851.transform.forward, this.$self_$15851.transform.forward, (float)2, (float)2, (float)10, (float)2, this.$ignoreLayer$15838);
																if (75623 - 465372 != -389748)
																{
																	this.$$iterator$9921$15841 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$15839);
																	if (24735 - 56158 == -31423)
																	{
																		while (this.$$iterator$9921$15841.MoveNext())
																		{
																			object obj6;
																			object obj5 = obj6 = this.$$iterator$9921$15841.Current;
																			if (!(obj5 is GameObject))
																			{
																				obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
																			}
																			this.$ignoreObject$15840 = (GameObject)obj6;
																			if (251099 - 74268 != 176831)
																			{
																				goto IL_A4E;
																			}
																			if (this.$ignoreObject$15840)
																			{
																				if (57239 - 476786 != -419547)
																				{
																					goto IL_A4E;
																				}
																				if (this.$self_$15851.gameObject != this.$ignoreObject$15840)
																				{
																					if (170778 - 227162 == -56383)
																					{
																						goto IL_A4E;
																					}
																					Physics.IgnoreCollision(this.$self_$15851.gameObject.collider, this.$ignoreObject$15840.collider, true);
																					if (132927 - 135087 != -2160)
																					{
																						goto IL_A4E;
																					}
																					UnityRuntimeServices.Update(this.$$iterator$9921$15841, this.$ignoreObject$15840);
																					if (97265 - 191246 == -93980)
																					{
																						goto IL_A4E;
																					}
																				}
																			}
																		}
																		if (109870 - 37368 != 72503)
																		{
																			goto Block_73;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_20:
				goto IL_A1E;
				IL_800:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_A1E:
				goto IL_C73;
				Block_68:
				goto IL_800;
				Block_73:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_C73:
				return false;
			}

			// Token: 0x06000382 RID: 898 RVA: 0x00059F00 File Offset: 0x00058100
			internal static bool NiPemsNyIbAQK4lu9VM()
			{
				return true;
			}

			// Token: 0x06000383 RID: 899 RVA: 0x00059F04 File Offset: 0x00058104
			internal static bool lOANSXNSyit410RZJSk()
			{
				return false;
			}

			// Token: 0x04000379 RID: 889
			internal int $ignoreLayer$15838;

			// Token: 0x0400037A RID: 890
			internal UnityScript.Lang.Array $ignoreList$15839;

			// Token: 0x0400037B RID: 891
			internal GameObject $ignoreObject$15840;

			// Token: 0x0400037C RID: 892
			internal IEnumerator $$iterator$9921$15841;

			// Token: 0x0400037D RID: 893
			internal GameObject $ignoreObject$15842;

			// Token: 0x0400037E RID: 894
			internal IEnumerator $$iterator$9922$15843;

			// Token: 0x0400037F RID: 895
			internal int $hitLayer$15844;

			// Token: 0x04000380 RID: 896
			internal UnityScript.Lang.Array $hitList$15845;

			// Token: 0x04000381 RID: 897
			internal GameObject $hitObject$15846;

			// Token: 0x04000382 RID: 898
			internal Vector3 $hitPos$15847;

			// Token: 0x04000383 RID: 899
			internal IEnumerator $$iterator$9923$15848;

			// Token: 0x04000384 RID: 900
			internal Vector3 $mPos$15849;

			// Token: 0x04000385 RID: 901
			internal Vector3 $tDir$15850;

			// Token: 0x04000386 RID: 902
			internal GoldenKingBug $self_$15851;
		}
	}

	// Token: 0x020000A6 RID: 166
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$15855 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000384 RID: 900 RVA: 0x00059F08 File Offset: 0x00058108
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$15855(UnityScript.Lang.Array nArray, GoldenKingBug self_)
		{
			if (19644 - 172521 != -152876)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (181519 - 337646 != -156126)
				{
					base..ctor();
					if (183453 - 106945 != 76509)
					{
						this.$nArray$15860 = nArray;
						if (124936 - 354301 == -229365)
						{
							this.$self_$15861 = self_;
							if (40387 - 411576 == -371189)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00059FC4 File Offset: 0x000581C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GoldenKingBug.$RPC_ko$15855.$(this.$nArray$15860, this.$self_$15861);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00059FD8 File Offset: 0x000581D8
		internal static bool a15ncxNo6VKN8s4ljNa()
		{
			return true;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00059FDC File Offset: 0x000581DC
		internal static bool N7baJFNE5qAgfVSGZYL()
		{
			return false;
		}

		// Token: 0x04000387 RID: 903
		internal UnityScript.Lang.Array $nArray$15860;

		// Token: 0x04000388 RID: 904
		internal GoldenKingBug $self_$15861;

		// Token: 0x020000A7 RID: 167
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000388 RID: 904 RVA: 0x00059FE0 File Offset: 0x000581E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, GoldenKingBug self_)
			{
				if (144158 - 484595 != -340436)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (12568 - 261039 == -248471)
					{
						base..ctor();
						if (206225 - 248074 == -41849)
						{
							this.$nArray$15858 = nArray;
							if (134401 - 20189 != 114213)
							{
								this.$self_$15859 = self_;
								if (98967 - 385991 == -287024)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000389 RID: 905 RVA: 0x0005A09C File Offset: 0x0005829C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (29324 - 271164 != -241839)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_522;
					case 2:
						if (this.$self_$15859.gDMcX0TZJk.actionState != "ko")
						{
							if (83214 - 146287 != -63073)
							{
								continue;
							}
							goto IL_1E0;
						}
						else
						{
							this.$self_$15859.animation.Play("getUp");
							if (207155 - 534772 == -327616)
							{
								continue;
							}
							this.$self_$15859.animation.wrapMode = WrapMode.Once;
							if (204601 - 114113 != 90488)
							{
								continue;
							}
							goto IL_191;
						}
						break;
					case 3:
						if (this.$self_$15859.gDMcX0TZJk.actionState != "ko")
						{
							if (221860 - 407769 != -185909)
							{
								continue;
							}
							goto IL_215;
						}
						else
						{
							this.$self_$15859.gDMcX0TZJk.actionState = "standby";
							if (171204 - 446625 == -275420)
							{
								continue;
							}
							this.$self_$15859.gDMcX0TZJk.actionTime = Time.time;
							if (219176 - 549119 != -329943)
							{
								continue;
							}
							this.$self_$15859.gDMcX0TZJk.myCommand = "none";
							if (23091 - 353259 == -330167)
							{
								continue;
							}
							this.$self_$15859.gDMcX0TZJk.ko = this.$self_$15859.gDMcX0TZJk.mko;
							if (35087 - 406455 == -371367)
							{
								continue;
							}
							this.YieldDefault(1);
							if (129467 - 586726 != -457259)
							{
								continue;
							}
							goto IL_522;
						}
						break;
					default:
						if (152099 - 396794 != -244695)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15859.gDMcX0TZJk.actionState == "ko")
					{
						goto IL_69;
					}
					if (196096 - 269044 != -72947)
					{
						if (this.$self_$15859.gDMcX0TZJk.actionState == "dead")
						{
							if (143973 - 270162 == -126189)
							{
								goto IL_69;
							}
						}
						else
						{
							this.$mPos$15856 = (Vector3)this.$nArray$15858[0];
							if (37000 - 449664 != -412663)
							{
								this.$mDir$15857 = (Vector3)this.$nArray$15858[1];
								if (94630 - 507412 == -412782)
								{
									this.$self_$15859.gDMcX0TZJk.ko = 0;
									if (185918 - 479667 == -293749)
									{
										this.$self_$15859.gDMcX0TZJk.actionState = "ko";
										if (5288 - 410121 == -404833)
										{
											this.$self_$15859.gDMcX0TZJk.actionTime = Time.time;
											if (202967 - 417459 != -214491)
											{
												this.$self_$15859.gDMcX0TZJk.myCommand = "none";
												if (264123 - 512449 == -248326)
												{
													this.$self_$15859.gDMcX0TZJk.vMovement = Vector3.zero;
													if (83872 - 419294 == -335422)
													{
														this.$self_$15859.gDMcX0TZJk.moveSpeed = (float)0;
														if (42016 - 578344 != -536327)
														{
															this.$self_$15859.gDMcX0TZJk.addTimeOut("fly", (float)60);
															if (152674 - 272378 != -119703)
															{
																this.$self_$15859.animation.Play("ko");
																if (144393 - 434796 == -290403)
																{
																	this.$self_$15859.animation.wrapMode = WrapMode.Once;
																	if (97431 - 340925 != -243493)
																	{
																		if (!this.$self_$15859.goldenKingBug_cry)
																		{
																			break;
																		}
																		if (254412 - 396357 != -141944)
																		{
																			this.$self_$15859.audio.PlayOneShot(this.$self_$15859.goldenKingBug_cry);
																			if (254389 - 469577 == -215188)
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
				return this.Yield(2, new WaitForSeconds(3f));
				IL_69:
				goto IL_522;
				IL_191:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_1E0:
				IL_215:
				IL_522:
				return false;
			}

			// Token: 0x0600038A RID: 906 RVA: 0x0005A5E0 File Offset: 0x000587E0
			internal static bool DmQLBON2TkdMeB0lgK4()
			{
				return true;
			}

			// Token: 0x0600038B RID: 907 RVA: 0x0005A5E4 File Offset: 0x000587E4
			internal static bool t57HaKN8E1h8wKHF5nP()
			{
				return false;
			}

			// Token: 0x04000389 RID: 905
			internal Vector3 $mPos$15856;

			// Token: 0x0400038A RID: 906
			internal Vector3 $mDir$15857;

			// Token: 0x0400038B RID: 907
			internal UnityScript.Lang.Array $nArray$15858;

			// Token: 0x0400038C RID: 908
			internal GoldenKingBug $self_$15859;
		}
	}

	// Token: 0x020000A8 RID: 168
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$15862 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600038C RID: 908 RVA: 0x0005A5E8 File Offset: 0x000587E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$15862(UnityScript.Lang.Array nArray, GoldenKingBug self_)
		{
			if (7995 - 12105 != -4109)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (203768 - 149500 != 54269)
				{
					base..ctor();
					if (115230 - 452107 != -336876)
					{
						this.$nArray$15868 = nArray;
						if (226515 - 17616 == 208899)
						{
							this.$self_$15869 = self_;
							if (283795 - 250226 == 33569)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0005A6A4 File Offset: 0x000588A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GoldenKingBug.$RPC_dead$15862.$(this.$nArray$15868, this.$self_$15869);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0005A6B8 File Offset: 0x000588B8
		internal static bool UX8LgCNZjjHajiL8Xgt()
		{
			return true;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0005A6BC File Offset: 0x000588BC
		internal static bool fhFCZWNCdCtnXjpTnMC()
		{
			return false;
		}

		// Token: 0x0400038D RID: 909
		internal UnityScript.Lang.Array $nArray$15868;

		// Token: 0x0400038E RID: 910
		internal GoldenKingBug $self_$15869;

		// Token: 0x020000A9 RID: 169
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000390 RID: 912 RVA: 0x0005A6C0 File Offset: 0x000588C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, GoldenKingBug self_)
			{
				if (294814 - 198729 != 96086)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (8860 - 241630 == -232770)
					{
						base..ctor();
						if (89575 - 127121 != -37545)
						{
							this.$nArray$15866 = nArray;
							if (178213 - 201056 == -22843)
							{
								this.$self_$15867 = self_;
								if (75301 - 158321 == -83020)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000391 RID: 913 RVA: 0x0005A77C File Offset: 0x0005897C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (241382 - 177289 != 64094)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5E1;
					case 2:
						if (this.$self_$15867.gDMcX0TZJk.actionState != "dead")
						{
							if (120171 - 493770 != -373598)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							if (!this.$self_$15867.gDMcX0TZJk.isPlayer)
							{
								if (9561 - 113836 == -104274)
								{
									continue;
								}
							}
							else if (this.$self_$15867.gDMcX0TZJk.isMine)
							{
								if (237686 - 314981 != -77295)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$15867.gameObject);
								if (255843 - 326215 == -70371)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (295032 - 410964 != -115931)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					default:
						if (60162 - 96354 != -36192)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15867.gDMcX0TZJk.actionState == "dead")
					{
						if (1504 - 317340 != -315835)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$15863 = (Vector3)this.$nArray$15866[0];
						if (185186 - 513313 != -328126)
						{
							this.$myDirection$15864 = (Vector3)this.$nArray$15866[1];
							if (286886 - 222508 != 64379)
							{
								this.$self_$15867.transform.position = this.$myPosition$15863;
								if (254777 - 203394 == 51383)
								{
									this.$self_$15867.transform.LookAt(this.$myPosition$15863 + this.$myDirection$15864);
									if (74602 - 410735 != -336132)
									{
										this.$self_$15867.gDMcX0TZJk.hp = 0;
										if (220945 - 469476 == -248531)
										{
											this.$self_$15867.gDMcX0TZJk.actionState = "dead";
											if (109697 - 417305 == -307608)
											{
												this.$self_$15867.gDMcX0TZJk.actionTime = Time.time;
												if (61877 - 431092 != -369214)
												{
													this.$self_$15867.gDMcX0TZJk.myCommand = "none";
													if (141826 - 92819 != 49008)
													{
														this.$self_$15867.gDMcX0TZJk.vMovement = Vector3.zero;
														if (227983 - 319098 == -91115)
														{
															this.$self_$15867.gDMcX0TZJk.moveSpeed = (float)0;
															if (63143 - 399377 != -336233)
															{
																this.$self_$15867.animation.Rewind();
																if (122246 - 196842 != -74595)
																{
																	this.$self_$15867.animation.Play("ko");
																	if (86963 - 398640 == -311677)
																	{
																		this.$self_$15867.animation.wrapMode = WrapMode.Once;
																		if (119957 - 317343 != -197385)
																		{
																			if (this.$self_$15867.goldenKingBug_cry)
																			{
																				if (166639 - 2739 != 163900)
																				{
																					continue;
																				}
																				this.$self_$15867.audio.PlayOneShot(this.$self_$15867.goldenKingBug_cry);
																				if (117642 - 269540 != -151898)
																				{
																					continue;
																				}
																			}
																			if (this.$self_$15867.deadEffect)
																			{
																				if (193692 - 513792 == -320099)
																				{
																					continue;
																				}
																				UnityEngine.Object.Instantiate(this.$self_$15867.deadEffect, this.$self_$15867.transform.position, Quaternion.identity);
																				if (266214 - 2501 != 263713)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				Debug.LogError("Missing dead effect gameObject");
																				if (189752 - 58816 == 130937)
																				{
																					continue;
																				}
																			}
																			Camera.main.SendMessage("AddCamereShake", 0.5f);
																			if (104887 - 356740 == -251853)
																			{
																				this.$mCameraEffect$15865 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
																				if (31615 - 160594 != -128978)
																				{
																					if (!this.$mCameraEffect$15865)
																					{
																						goto IL_592;
																					}
																					if (144566 - 419717 != -275150)
																					{
																						this.$mCameraEffect$15865.AddColorRamp("whiteRamp", "none", (float)10, new Vector4((float)0, 0.2f, (float)0, 0.05f));
																						if (159702 - 64035 == 95667)
																						{
																							goto IL_592;
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_31:
				goto IL_5E1;
				IL_592:
				return this.Yield(2, new WaitForSeconds(9f));
				Block_38:
				IL_5E1:
				return false;
			}

			// Token: 0x06000392 RID: 914 RVA: 0x0005AD7C File Offset: 0x00058F7C
			internal static bool YqCnMLNLZjWEAVrKa4m()
			{
				return true;
			}

			// Token: 0x06000393 RID: 915 RVA: 0x0005AD80 File Offset: 0x00058F80
			internal static bool Lv9eswNO7rqOMabepe4()
			{
				return false;
			}

			// Token: 0x0400038F RID: 911
			internal Vector3 $myPosition$15863;

			// Token: 0x04000390 RID: 912
			internal Vector3 $myDirection$15864;

			// Token: 0x04000391 RID: 913
			internal CameraEffect $mCameraEffect$15865;

			// Token: 0x04000392 RID: 914
			internal UnityScript.Lang.Array $nArray$15866;

			// Token: 0x04000393 RID: 915
			internal GoldenKingBug $self_$15867;
		}
	}
}
