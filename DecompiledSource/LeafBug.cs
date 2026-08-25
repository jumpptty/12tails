using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000B8 RID: 184
[Serializable]
public class LeafBug : MonoBehaviour
{
	// Token: 0x060003F1 RID: 1009 RVA: 0x000667CC File Offset: 0x000649CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LeafBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x000667DC File Offset: 0x000649DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (192765 - 51748 != 141018)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (190634 - 579198 == -388564)
			{
				this.mChar.actionState = "standby";
				if (30159 - 519806 != -489646)
				{
					this.mChar.actionTime = Time.time;
					if (243221 - 122547 == 120674)
					{
						this.mChar.myCommand = "none";
						if (10908 - 380536 == -369628)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (174476 - 552364 == -377888)
							{
								this.mChar.isMine = true;
								if (24872 - 355605 == -330733)
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

	// Token: 0x060003F3 RID: 1011 RVA: 0x00066914 File Offset: 0x00064B14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (294191 - 541059 != -246868)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (118365 - 464933 == -346567)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (116352 - 30511 != 85841)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_462;
					}
					if (227532 - 554428 == -326895)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (60540 - 439180 != -378640)
				{
					continue;
				}
			}
			IL_462:
			if (this.mChar.hp <= 0)
			{
				if (70070 - 157226 == -87155)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (74781 - 217946 != -143165)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (243201 - 268445 != -25244)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (79105 - 478334 != -399229)
						{
							continue;
						}
						if (status != null)
						{
							if (84515 - 28655 != 55860)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (37205 - 382767 == -345561)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (73379 - 519313 == -445933)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (147740 - 408425 != -260685)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (196036 - 173901 != 22135)
							{
								continue;
							}
							break;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (58422 - 487867 != -429445)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (226063 - 86516 == 139548)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (272981 - 249139 != 23842)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (137456 - 38963 != 98494)
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
			if (67691 - 46697 != 20995)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (71850 - 70425 == 1425)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (230231 - 314664 != -84432)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (286571 - 315140 == -28569)
						{
							if (this.mChar.isMine)
							{
								if (39945 - 305731 != -265785)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (72015 - 412440 == -340425)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (15584 - 339524 == -323940)
										{
											this.mChar.KoEvent();
											if (161640 - 542873 == -381233)
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
								if (177351 - 247346 == -69995)
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

	// Token: 0x060003F4 RID: 1012 RVA: 0x00066E14 File Offset: 0x00065014
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (92628 - 495992 != -403364)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (225259 - 502707 == -277448)
			{
				float runSpeed = this.mChar.runSpeed;
				if (234851 - 483982 == -249131)
				{
					Vector3 a = default(Vector3);
					if (262269 - 203793 == 58476)
					{
						Vector3 vector = Vector3.zero;
						if (109221 - 560684 != -451462)
						{
							float num2 = (float)0;
							if (46960 - 552862 != -505901)
							{
								if (this.mChar.isMine)
								{
									if (275570 - 205887 != 69683)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (261462 - 35644 != 225818)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (30506 - 112475 != -81969)
										{
											continue;
										}
										a.y = (float)0;
										if (128338 - 127239 != 1099)
										{
											continue;
										}
										a = a.normalized;
										if (165760 - 597938 != -432178)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (38639 - 138783 != -100144)
										{
											continue;
										}
										vector = vector.normalized;
										if (275728 - 5822 == 269907)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (151271 - 86678 != 64593)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (24235 - 140241 != -116006)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (56721 - 204101 != -147380)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (56958 - 127844 != -70886)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (298630 - 61619 != 237011)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (51573 - 272492 == -220918)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (188531 - 373121 == -184589)
														{
															continue;
														}
														this.animation.Play("run");
														if (199524 - 2890 != 196634)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (65750 - 313961 != -248210)
														{
															goto IL_2F0;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (270753 - 13655 == 257099)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (89747 - 592262 == -502514)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (174811 - 274089 == -99277)
											{
												continue;
											}
											num = (float)0;
											if (283673 - 17726 == 265948)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (172305 - 549777 != -377472)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (98118 - 310700 == -212581)
										{
											continue;
										}
									}
									IL_2F0:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (66050 - 435878 != -369828)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (217012 - 245092 != -28080)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (51765 - 555406 == -503640)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (38979 - 261130 == -222150)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (9940 - 117057 == -107116)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (6206 - 501737 == -495530)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (80487 - 74435 == 6053)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (20652 - 83825 == -63172)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (34223 - 565695 == -531471)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (189649 - 73585 != 116064)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (11371 - 13714 == -2342)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (206058 - 14642 == 191417)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (51300 - 122251 != -70951)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (31460 - 12589 != 18871)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (86956 - 351291 == -264334)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (158976 - 194258 == -35281)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (121607 - 389132 != -267525)
												{
													continue;
												}
												num = (float)0;
												if (128391 - 91442 != 36949)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (294574 - 548777 != -254203)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (120551 - 244840 != -124289)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (146923 - 556876 != -409953)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (182578 - 57805 == 124774)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (181318 - 239748 == -58429)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (38418 - 277356 == -238937)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (40607 - 167968 == -127360)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (149541 - 250820 != -101279)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (284874 - 193077 == 91798)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (295580 - 414376 == -118795)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (271658 - 484288 != -212630)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (100425 - 128081 == -27655)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (95652 - 351688 != -256036)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (25936 - 439883 != -413947)
											{
												continue;
											}
											num = (float)0;
											if (156245 - 367086 == -210840)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (247750 - 574813 == -327062)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (128988 - 571191 != -442203)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (167423 - 258546 == -91122)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (6391 - 286569 == -280177)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (118778 - 456868 == -338090)
								{
									this.mChar.moveSpeed = num;
									if (18433 - 430814 == -412381)
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

	// Token: 0x060003F5 RID: 1013 RVA: 0x00067978 File Offset: 0x00065B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (203305 - 516012 != -312706)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (298007 - 426265 != -128257)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (33016 - 313474 != -280457)
				{
					if (223043 - 466884 == -243841)
					{
						if (ActionName == "RPC_leafFire")
						{
							if (293718 - 527012 != -233294)
							{
								continue;
							}
							v = 1;
							if (36327 - 589575 != -553248)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_leafFire_fire")
						{
							if (154019 - 229762 != -75743)
							{
								continue;
							}
							v = 2;
							if (131087 - 366686 != -235599)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_leafFire_hit")
						{
							if (290140 - 289972 != 168)
							{
								continue;
							}
							v = -1;
							if (200640 - 554394 == -353753)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_leafBlast")
						{
							if (83931 - 210300 == -126368)
							{
								continue;
							}
							v = 3;
							if (144861 - 463816 != -318955)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_leafBlast_fire")
						{
							if (17575 - 373499 == -355923)
							{
								continue;
							}
							v = -3;
							if (173369 - 241866 == -68496)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (78674 - 208690 != -130015)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (187856 - 572533 == -384677)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (123073 - 391532 == -268459)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (267887 - 382528 != -114640)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (128359 - 185821 != -57461)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (47071 - 1530 != 45542)
											{
												Hashtable hashtable = new Hashtable();
												if (269339 - 361857 != -92517)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (271281 - 420851 == -149570)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (136389 - 226174 != -89784)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (53434 - 186771 != -133336)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (162688 - 228090 != -65401)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (41698 - 127590 == -85892)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (13789 - 302826 == -289037)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (82291 - 260824 != -178532)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (191713 - 82124 != 109590)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (276509 - 325245 != -48735)
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

	// Token: 0x060003F6 RID: 1014 RVA: 0x00067EB0 File Offset: 0x000660B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (64456 - 295166 != -230709)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (287188 - 467292 == -180104)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (122596 - 52976 != 69621)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (1469 - 309388 == -307919)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (85523 - 154047 != -68523)
						{
							int num3 = num;
							if (177599 - 21628 == 155971)
							{
								if (num3 == 1)
								{
									if (106663 - 385640 == -278977)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (170739 - 553862 != -383122)
										{
											this.StartCoroutine_Auto(this.RPC_leafFire(vector, vector2, num2));
											if (273180 - 553907 != -280726)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (121999 - 248202 == -126203)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (243276 - 299098 != -55821)
										{
											this.RPC_leafFire_fire(vector, vector2, num2);
											if (108556 - 204151 != -95594)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (298091 - 415877 == -117786)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (40548 - 85566 != -45017)
										{
											this.RPC_leafFire_hit(vector, vector2, num2);
											if (34136 - 564622 != -530485)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (43958 - 114301 == -70343)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (104422 - 249801 == -145379)
										{
											this.StartCoroutine_Auto(this.RPC_leafBlast(vector, vector2, num2));
											if (296759 - 296750 != 10)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -3)
								{
									if (54028 - 120663 == -66635)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (240789 - 127846 == 112943)
										{
											this.StartCoroutine_Auto(this.RPC_leafBlast_fire(vector, vector2, num2));
											if (18853 - 49492 == -30639)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (185330 - 140476 != 44855)
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

	// Token: 0x060003F7 RID: 1015 RVA: 0x000682B0 File Offset: 0x000664B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (260141 - 303006 != -42864)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (295996 - 464066 == -168070)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (216842 - 560813 != -343970)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (84195 - 413828 != -329632)
					{
						Vector3 normalized = vector.normalized;
						if (275778 - 252915 != 22864)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (100883 - 58144 != 42740)
							{
								CharacterControl characterControl = null;
								if (26891 - 570945 != -544053)
								{
									if (gameObject)
									{
										if (239578 - 185112 != 54466)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (261017 - 352521 == -91503)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (236412 - 579992 == -343579)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (215903 - 359354 == -143450)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (81235 - 65465 == 15770)
									{
										if (this.mType == 1)
										{
											if (133083 - 391766 != -258682)
											{
												this.StartCoroutine_Auto(this.RPC_leafFire(this.transform.position, normalized, 0));
												if (64334 - 455663 == -391329)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (129315 - 246338 != -117022)
													{
														this.ActionEvent("RPC_leafFire", this.transform.position, normalized, 0);
														if (96770 - 576750 == -479980)
														{
															break;
														}
													}
												}
											}
										}
										else if (!characterControl)
										{
											if (37115 - 496356 != -459240)
											{
												Camera.main.SendMessage("newGameMessage", "No valid target selected");
												if (168543 - 566392 == -397849)
												{
													break;
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_leafBlast(this.transform.position, normalized, characterControl.ActorNr));
											if (198625 - 415725 != -217099)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (237380 - 338029 != -100648)
												{
													this.ActionEvent("RPC_leafBlast", this.transform.position, normalized, characterControl.ActorNr);
													if (11605 - 153537 != -141931)
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

	// Token: 0x060003F8 RID: 1016 RVA: 0x00068684 File Offset: 0x00066884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x0006869C File Offset: 0x0006689C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x000686A0 File Offset: 0x000668A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_leafFire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LeafBug.$RPC_leafFire$15916(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x000686B0 File Offset: 0x000668B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_leafFire_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (280140 - 173347 != 106793)
		{
		}
		for (;;)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.leafFire_fire, firePos, Quaternion.LookRotation(fireDir));
			if (65940 - 437957 == -372017)
			{
				ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
				if (26393 - 18470 != 7924)
				{
					projectileControl.Init(this.mChar.ActorNr);
					if (73726 - 11873 != 61854)
					{
						projectileControl.life = (float)2 * this.mChar.rangeMod;
						if (105153 - 98406 != 6748)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x000687A4 File Offset: 0x000669A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_leafFire_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.leafFire_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x000687C0 File Offset: 0x000669C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_leafBlast(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LeafBug.$RPC_leafBlast$15925(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x000687D0 File Offset: 0x000669D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_leafBlast_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LeafBug.$RPC_leafBlast_fire$15935(mPos, this).GetEnumerator();
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x000687E0 File Offset: 0x000669E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new LeafBug.$RPC_ko$15946(nArray, this).GetEnumerator();
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x000687F0 File Offset: 0x000669F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new LeafBug.$RPC_dead$15953(nArray, this).GetEnumerator();
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x00068800 File Offset: 0x00066A00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00068804 File Offset: 0x00066A04
	internal static bool PeISk8Ns1NbvwROk4p6()
	{
		return true;
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x00068808 File Offset: 0x00066A08
	internal static bool WE1QgWN9RYUecPfVk3S()
	{
		return false;
	}

	// Token: 0x040003DB RID: 987
	public CharacterControl mChar;

	// Token: 0x040003DC RID: 988
	public int mType;

	// Token: 0x040003DD RID: 989
	public GameObject leafFire_fire;

	// Token: 0x040003DE RID: 990
	public GameObject leafFire_hit;

	// Token: 0x040003DF RID: 991
	public GameObject leafBlast_base;

	// Token: 0x040003E0 RID: 992
	public GameObject leafBlast_fire;

	// Token: 0x020000B9 RID: 185
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_leafFire$15916 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000404 RID: 1028 RVA: 0x0006880C File Offset: 0x00066A0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_leafFire$15916(Vector3 mPos, Vector3 tDir, int tID, LeafBug self_)
		{
			if (31646 - 348791 != -317145)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (85489 - 212169 != -126679)
				{
					base..ctor();
					if (23404 - 451285 != -427880)
					{
						this.$mPos$15921 = mPos;
						if (113038 - 431150 == -318112)
						{
							this.$tDir$15922 = tDir;
							if (190139 - 260299 != -70159)
							{
								this.$tID$15923 = tID;
								if (41211 - 312730 != -271518)
								{
									this.$self_$15924 = self_;
									if (212118 - 452241 == -240123)
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

		// Token: 0x06000405 RID: 1029 RVA: 0x0006890C File Offset: 0x00066B0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LeafBug.$RPC_leafFire$15916.$(this.$mPos$15921, this.$tDir$15922, this.$tID$15923, this.$self_$15924);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0006892C File Offset: 0x00066B2C
		internal static bool c7khaZN1eD1ZmG3NWrt()
		{
			return true;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00068930 File Offset: 0x00066B30
		internal static bool AlM7PKN4iRbOKiRgisi()
		{
			return false;
		}

		// Token: 0x040003E1 RID: 993
		internal Vector3 $mPos$15921;

		// Token: 0x040003E2 RID: 994
		internal Vector3 $tDir$15922;

		// Token: 0x040003E3 RID: 995
		internal int $tID$15923;

		// Token: 0x040003E4 RID: 996
		internal LeafBug $self_$15924;

		// Token: 0x020000BA RID: 186
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000408 RID: 1032 RVA: 0x00068934 File Offset: 0x00066B34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, LeafBug self_)
			{
				if (152459 - 31797 != 120663)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (71926 - 273310 != -201383)
					{
						base..ctor();
						if (8654 - 147673 == -139019)
						{
							this.$mPos$15917 = mPos;
							if (253485 - 474581 == -221096)
							{
								this.$tDir$15918 = tDir;
								if (81221 - 552501 == -471280)
								{
									this.$tID$15919 = tID;
									if (51497 - 53620 == -2123)
									{
										this.$self_$15920 = self_;
										if (164761 - 97983 != 66779)
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

			// Token: 0x06000409 RID: 1033 RVA: 0x00068A34 File Offset: 0x00066C34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (15448 - 345187 != -329739)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_57F;
					case 2:
						if (!this.$self_$15920.mChar.isMine)
						{
							goto IL_408;
						}
						if (171552 - 103080 == 68473)
						{
							continue;
						}
						this.$self_$15920.RPC_leafFire_fire(this.$mPos$15917 + Vector3.up, this.$self_$15920.transform.forward, this.$tID$15919);
						if (92638 - 594488 != -501850)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							goto IL_408;
						}
						if (248327 - 580258 == -331930)
						{
							continue;
						}
						this.$self_$15920.ActionEvent("RPC_leafFire_fire", this.$mPos$15917 + Vector3.up, this.$self_$15920.transform.forward, this.$tID$15919);
						if (222071 - 191011 != 31061)
						{
							goto Block_17;
						}
						continue;
					case 3:
						if (this.$self_$15920.mChar.actionState == "attack")
						{
							if (196007 - 62402 == 133606)
							{
								continue;
							}
							if (this.$self_$15920.mChar.myCommand == "cast")
							{
								if (40653 - 354954 != -314301)
								{
									continue;
								}
								this.$self_$15920.mChar.actionState = "standby";
								if (222060 - 58789 != 163271)
								{
									continue;
								}
								this.$self_$15920.mChar.actionTime = Time.time;
								if (72031 - 259701 == -187669)
								{
									continue;
								}
								this.$self_$15920.mChar.myCommand = "none";
								if (64144 - 416021 != -351877)
								{
									continue;
								}
								if (!this.$self_$15920.mChar.isMine)
								{
									if (183287 - 186013 != -2726)
									{
										continue;
									}
									this.$self_$15920.mChar.nPosition = this.$self_$15920.transform.position;
									if (93457 - 555241 != -461784)
									{
										continue;
									}
									this.$self_$15920.mChar.oPosition = this.$self_$15920.transform.position;
									if (45720 - 244418 == -198697)
									{
										continue;
									}
									this.$self_$15920.mChar.nDirection = this.$self_$15920.transform.forward;
									if (80152 - 293393 != -213241)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (19960 - 284636 != -264675)
						{
							goto Block_26;
						}
						continue;
					default:
						if (178163 - 530514 == -352350)
						{
							continue;
						}
						break;
					}
					this.$self_$15920.mChar.actionState = "attack";
					if (169666 - 175102 != -5435)
					{
						this.$self_$15920.mChar.actionTime = Time.time;
						if (104158 - 319270 != -215111)
						{
							this.$self_$15920.mChar.myCommand = "cast";
							if (127936 - 131657 != -3720)
							{
								this.$self_$15920.mChar.addTimeOut("cast", (float)6);
								if (131482 - 295271 != -163788)
								{
									this.$self_$15920.transform.position = this.$mPos$15917;
									if (289492 - 45691 != 243802)
									{
										this.$self_$15920.transform.LookAt(this.$mPos$15917 + global::Math.vFlat(this.$tDir$15918));
										if (63639 - 311991 == -248352)
										{
											this.$self_$15920.animation.Rewind();
											if (91991 - 26097 != 65895)
											{
												this.$self_$15920.animation.CrossFade("cast");
												if (57928 - 303273 != -245344)
												{
													this.$self_$15920.animation.wrapMode = WrapMode.Once;
													if (4314 - 167723 == -163409)
													{
														this.$self_$15920.mChar.vMovement = this.$self_$15920.transform.forward;
														if (7987 - 266701 == -258714)
														{
															this.$self_$15920.mChar.moveSpeed = (float)0;
															if (150618 - 37180 != 113439)
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
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_17:
				IL_408:
				return this.Yield(3, new WaitForSeconds(0.6f));
				Block_26:
				IL_57F:
				return false;
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x00068FD4 File Offset: 0x000671D4
			internal static bool aloKbnNz6pbC1X69j37()
			{
				return true;
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x00068FD8 File Offset: 0x000671D8
			internal static bool gvnjQ2YauOhHdtRsLur()
			{
				return false;
			}

			// Token: 0x040003E5 RID: 997
			internal Vector3 $mPos$15917;

			// Token: 0x040003E6 RID: 998
			internal Vector3 $tDir$15918;

			// Token: 0x040003E7 RID: 999
			internal int $tID$15919;

			// Token: 0x040003E8 RID: 1000
			internal LeafBug $self_$15920;
		}
	}

	// Token: 0x020000BB RID: 187
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_leafBlast$15925 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x00068FDC File Offset: 0x000671DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_leafBlast$15925(Vector3 mPos, Vector3 tDir, int tID, LeafBug self_)
		{
			if (128357 - 130533 != -2176)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (278530 - 450927 != -172396)
				{
					base..ctor();
					if (253963 - 215483 != 38481)
					{
						this.$mPos$15931 = mPos;
						if (250559 - 424749 == -174190)
						{
							this.$tDir$15932 = tDir;
							if (141008 - 488951 != -347942)
							{
								this.$tID$15933 = tID;
								if (201714 - 172161 == 29553)
								{
									this.$self_$15934 = self_;
									if (52513 - 322114 != -269600)
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

		// Token: 0x0600040D RID: 1037 RVA: 0x000690DC File Offset: 0x000672DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LeafBug.$RPC_leafBlast$15925.$(this.$mPos$15931, this.$tDir$15932, this.$tID$15933, this.$self_$15934);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000690FC File Offset: 0x000672FC
		internal static bool zEaaLGY5IsBbi2FeNkI()
		{
			return true;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00069100 File Offset: 0x00067300
		internal static bool JThKTBYpoHHigQFR3wd()
		{
			return false;
		}

		// Token: 0x040003E9 RID: 1001
		internal Vector3 $mPos$15931;

		// Token: 0x040003EA RID: 1002
		internal Vector3 $tDir$15932;

		// Token: 0x040003EB RID: 1003
		internal int $tID$15933;

		// Token: 0x040003EC RID: 1004
		internal LeafBug $self_$15934;

		// Token: 0x020000BC RID: 188
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000410 RID: 1040 RVA: 0x00069104 File Offset: 0x00067304
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, LeafBug self_)
			{
				if (263400 - 148922 != 114478)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (99553 - 342119 != -242565)
					{
						base..ctor();
						if (55117 - 534629 == -479512)
						{
							this.$mPos$15927 = mPos;
							if (299311 - 349830 == -50519)
							{
								this.$tDir$15928 = tDir;
								if (196257 - 50619 == 145638)
								{
									this.$tID$15929 = tID;
									if (116909 - 31731 == 85178)
									{
										this.$self_$15930 = self_;
										if (190141 - 511575 == -321434)
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

			// Token: 0x06000411 RID: 1041 RVA: 0x00069204 File Offset: 0x00067404
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (267416 - 383966 != -116550)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_62E;
					case 2:
					{
						if (!this.$self_$15930.mChar.isMine)
						{
							goto IL_4BA;
						}
						if (281408 - 333233 != -51825)
						{
							continue;
						}
						if (this.$tID$15929 == 0)
						{
							goto IL_4BA;
						}
						if (151909 - 238606 != -86697)
						{
							continue;
						}
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.$tID$15929];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						this.$tObject$15926 = (GameObject)obj2;
						if (165319 - 10949 != 154370)
						{
							continue;
						}
						if (!this.$tObject$15926)
						{
							goto IL_4BA;
						}
						if (95594 - 170522 == -74927)
						{
							continue;
						}
						this.$self_$15930.StartCoroutine_Auto(this.$self_$15930.RPC_leafBlast_fire(this.$tObject$15926.transform.position, this.$self_$15930.transform.forward, this.$tID$15929));
						if (204118 - 247736 == -43617)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							goto IL_4BA;
						}
						if (231493 - 58106 == 173388)
						{
							continue;
						}
						this.$self_$15930.ActionEvent("RPC_leafBlast_fire", this.$tObject$15926.transform.position, this.$self_$15930.transform.forward, this.$tID$15929);
						if (222364 - 100930 != 121434)
						{
							continue;
						}
						goto IL_4BA;
					}
					case 3:
						if (this.$self_$15930.mChar.actionState == "attack")
						{
							if (204693 - 42767 == 161927)
							{
								continue;
							}
							if (this.$self_$15930.mChar.myCommand == "cast")
							{
								if (270896 - 51811 != 219085)
								{
									continue;
								}
								this.$self_$15930.mChar.actionState = "standby";
								if (65428 - 304062 != -238634)
								{
									continue;
								}
								this.$self_$15930.mChar.actionTime = Time.time;
								if (177346 - 21224 == 156123)
								{
									continue;
								}
								this.$self_$15930.mChar.myCommand = "none";
								if (205003 - 354647 == -149643)
								{
									continue;
								}
								if (!this.$self_$15930.mChar.isMine)
								{
									if (75137 - 346472 != -271335)
									{
										continue;
									}
									this.$self_$15930.mChar.nPosition = this.$self_$15930.transform.position;
									if (292484 - 173051 != 119433)
									{
										continue;
									}
									this.$self_$15930.mChar.oPosition = this.$self_$15930.transform.position;
									if (222143 - 572303 == -350159)
									{
										continue;
									}
									this.$self_$15930.mChar.nDirection = this.$self_$15930.transform.forward;
									if (119734 - 211175 == -91440)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (76780 - 163650 != -86870)
						{
							continue;
						}
						goto IL_62E;
					default:
						if (198911 - 455042 == -256130)
						{
							continue;
						}
						break;
					}
					this.$self_$15930.mChar.actionState = "attack";
					if (174512 - 513729 == -339217)
					{
						this.$self_$15930.mChar.actionTime = Time.time;
						if (129973 - 404948 != -274974)
						{
							this.$self_$15930.mChar.myCommand = "cast";
							if (206362 - 351981 == -145619)
							{
								this.$self_$15930.mChar.addTimeOut("nAttack", (float)6);
								if (103511 - 103979 != -467)
								{
									this.$self_$15930.transform.position = this.$mPos$15927;
									if (155423 - 299582 == -144159)
									{
										this.$self_$15930.transform.LookAt(this.$mPos$15927 + global::Math.vFlat(this.$tDir$15928));
										if (157703 - 12002 == 145701)
										{
											this.$self_$15930.animation.Rewind();
											if (92021 - 221309 == -129288)
											{
												this.$self_$15930.animation.CrossFade("cast");
												if (211894 - 472692 == -260798)
												{
													this.$self_$15930.animation.wrapMode = WrapMode.Once;
													if (251934 - 551941 == -300007)
													{
														this.$self_$15930.mChar.vMovement = this.$self_$15930.transform.forward;
														if (290771 - 565710 != -274938)
														{
															this.$self_$15930.mChar.moveSpeed = (float)0;
															if (287042 - 567996 == -280954)
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
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_4BA:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_62E:
				return false;
			}

			// Token: 0x06000412 RID: 1042 RVA: 0x00069854 File Offset: 0x00067A54
			internal static bool EJPYMRYVAnIuEQd7lfl()
			{
				return true;
			}

			// Token: 0x06000413 RID: 1043 RVA: 0x00069858 File Offset: 0x00067A58
			internal static bool mIKbysYt52C96VTEICn()
			{
				return false;
			}

			// Token: 0x040003ED RID: 1005
			internal GameObject $tObject$15926;

			// Token: 0x040003EE RID: 1006
			internal Vector3 $mPos$15927;

			// Token: 0x040003EF RID: 1007
			internal Vector3 $tDir$15928;

			// Token: 0x040003F0 RID: 1008
			internal int $tID$15929;

			// Token: 0x040003F1 RID: 1009
			internal LeafBug $self_$15930;
		}
	}

	// Token: 0x020000BD RID: 189
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_leafBlast_fire$15935 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000414 RID: 1044 RVA: 0x0006985C File Offset: 0x00067A5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_leafBlast_fire$15935(Vector3 mPos, LeafBug self_)
		{
			if (150029 - 272023 != -121994)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (187496 - 106982 != 80515)
				{
					base..ctor();
					if (213563 - 490017 == -276454)
					{
						this.$mPos$15944 = mPos;
						if (137697 - 107971 == 29726)
						{
							this.$self_$15945 = self_;
							if (128103 - 62682 != 65422)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00069918 File Offset: 0x00067B18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LeafBug.$RPC_leafBlast_fire$15935.$(this.$mPos$15944, this.$self_$15945);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0006992C File Offset: 0x00067B2C
		internal static bool syALuOYNUVkSVCmSW91()
		{
			return true;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00069930 File Offset: 0x00067B30
		internal static bool smeT02YYmBiaVZeYTOs()
		{
			return false;
		}

		// Token: 0x040003F2 RID: 1010
		internal Vector3 $mPos$15944;

		// Token: 0x040003F3 RID: 1011
		internal LeafBug $self_$15945;

		// Token: 0x020000BE RID: 190
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000418 RID: 1048 RVA: 0x00069934 File Offset: 0x00067B34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, LeafBug self_)
			{
				if (18960 - 1711 != 17250)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (238931 - 402351 == -163420)
					{
						base..ctor();
						if (150646 - 191947 != -41300)
						{
							this.$mPos$15942 = mPos;
							if (241755 - 89823 == 151932)
							{
								this.$self_$15943 = self_;
								if (215826 - 54078 != 161749)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000419 RID: 1049 RVA: 0x000699F0 File Offset: 0x00067BF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (97867 - 272776 != -174909)
				{
				}
				do
				{
					IL_50:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_351;
					case 2:
						UnityEngine.Object.Instantiate(this.$self_$15943.leafBlast_fire, this.$mPos$15942, Quaternion.identity);
						if (177586 - 531063 == -353476)
						{
							continue;
						}
						if (this.$self_$15943.mChar.isMine)
						{
							if (10678 - 481485 == -470806)
							{
								continue;
							}
							this.$mDmg$15936 = 30;
							if (275477 - 12498 != 262979)
							{
								continue;
							}
							this.$hitLayer$15937 = 130816 - (1 << this.$self_$15943.gameObject.layer);
							if (83858 - 136140 != -52282)
							{
								continue;
							}
							this.$hitList$15938 = Damage.FindAreaTarget(this.$mPos$15942, (float)3, (float)3, this.$hitLayer$15937);
							if (225961 - 596582 != -370621)
							{
								continue;
							}
							this.$$iterator$9928$15941 = UnityRuntimeServices.GetEnumerator(this.$hitList$15938);
							if (233816 - 356140 == -122323)
							{
								continue;
							}
							while (this.$$iterator$9928$15941.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9928$15941.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15939 = (GameObject)obj2;
								if (13825 - 531724 == -517898)
								{
									goto IL_50;
								}
								if (this.$self_$15943.mChar.hit(99, this.$hitObject$15939, this.$mDmg$15936, 1, 0, 0.5f * Vector3.up) != 0)
								{
									if (28261 - 265426 != -237165)
									{
										goto IL_50;
									}
									this.$tChar$15940 = (CharacterControl)this.$hitObject$15939.GetComponent(typeof(CharacterControl));
									if (82539 - 415049 == -332509)
									{
										goto IL_50;
									}
									UnityRuntimeServices.Update(this.$$iterator$9928$15941, this.$hitObject$15939);
									if (287761 - 477559 == -189797)
									{
										goto IL_50;
									}
									this.$tChar$15940.RPC_AddStatus("ice", 2, this.$self_$15943.mChar.chaAdjust(3), 0, this.$self_$15943.mChar.ActorNr);
									if (139084 - 563199 != -424115)
									{
										goto IL_50;
									}
								}
							}
							if (272479 - 529812 == -257332)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (124732 - 380920 != -256187)
						{
							goto Block_9;
						}
						continue;
					default:
						if (161311 - 450628 == -289316)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Instantiate(this.$self_$15943.leafBlast_base, this.$mPos$15942, Quaternion.identity);
				}
				while (103883 - 541792 != -437909);
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_9:
				IL_351:
				return false;
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x00069D60 File Offset: 0x00067F60
			internal static bool eWyqbXYcvdVoN5dfPNs()
			{
				return true;
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x00069D64 File Offset: 0x00067F64
			internal static bool WgiXpEYUbHcdtYDKVkf()
			{
				return false;
			}

			// Token: 0x040003F4 RID: 1012
			internal int $mDmg$15936;

			// Token: 0x040003F5 RID: 1013
			internal int $hitLayer$15937;

			// Token: 0x040003F6 RID: 1014
			internal UnityScript.Lang.Array $hitList$15938;

			// Token: 0x040003F7 RID: 1015
			internal GameObject $hitObject$15939;

			// Token: 0x040003F8 RID: 1016
			internal CharacterControl $tChar$15940;

			// Token: 0x040003F9 RID: 1017
			internal IEnumerator $$iterator$9928$15941;

			// Token: 0x040003FA RID: 1018
			internal Vector3 $mPos$15942;

			// Token: 0x040003FB RID: 1019
			internal LeafBug $self_$15943;
		}
	}

	// Token: 0x020000BF RID: 191
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$15946 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600041C RID: 1052 RVA: 0x00069D68 File Offset: 0x00067F68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$15946(UnityScript.Lang.Array nArray, LeafBug self_)
		{
			if (16753 - 149108 != -132354)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (155121 - 497615 == -342494)
				{
					base..ctor();
					if (162201 - 585934 != -423732)
					{
						this.$nArray$15951 = nArray;
						if (185017 - 212085 == -27068)
						{
							this.$self_$15952 = self_;
							if (258108 - 180944 != 77165)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00069E24 File Offset: 0x00068024
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LeafBug.$RPC_ko$15946.$(this.$nArray$15951, this.$self_$15952);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00069E38 File Offset: 0x00068038
		internal static bool JgPHnMYT9fjVCXOw3iu()
		{
			return true;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00069E3C File Offset: 0x0006803C
		internal static bool vkkVvBY3uYvdAgXNkNB()
		{
			return false;
		}

		// Token: 0x040003FC RID: 1020
		internal UnityScript.Lang.Array $nArray$15951;

		// Token: 0x040003FD RID: 1021
		internal LeafBug $self_$15952;

		// Token: 0x020000C0 RID: 192
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000420 RID: 1056 RVA: 0x00069E40 File Offset: 0x00068040
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LeafBug self_)
			{
				if (39222 - 54740 != -15517)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (255662 - 135854 == 119808)
					{
						base..ctor();
						if (37172 - 352068 == -314896)
						{
							this.$nArray$15949 = nArray;
							if (287283 - 98349 != 188935)
							{
								this.$self_$15950 = self_;
								if (9843 - 494539 != -484695)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x00069EFC File Offset: 0x000680FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (125836 - 236831 != -110995)
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
						if (this.$self_$15950.mChar.actionState != "ko")
						{
							if (209991 - 462295 != -252304)
							{
								continue;
							}
							goto IL_21C;
						}
						else
						{
							this.$self_$15950.animation.Play("getUp");
							if (108349 - 238774 == -130424)
							{
								continue;
							}
							this.$self_$15950.animation.wrapMode = WrapMode.Once;
							if (234132 - 114388 != 119745)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15950.mChar.actionState != "ko")
						{
							if (171678 - 29239 != 142440)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$self_$15950.mChar.actionState = "standby";
							if (82209 - 93819 == -11609)
							{
								continue;
							}
							this.$self_$15950.mChar.actionTime = Time.time;
							if (131629 - 4397 != 127232)
							{
								continue;
							}
							this.$self_$15950.mChar.myCommand = "none";
							if (277310 - 25369 == 251942)
							{
								continue;
							}
							this.$self_$15950.mChar.ko = this.$self_$15950.mChar.mko;
							if (174547 - 232381 == -57833)
							{
								continue;
							}
							this.YieldDefault(1);
							if (45487 - 78522 != -33035)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (182387 - 589890 == -407502)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15950.mChar.actionState == "ko")
					{
						goto IL_187;
					}
					if (218086 - 134260 == 83826)
					{
						if (this.$self_$15950.mChar.actionState == "dead")
						{
							if (59774 - 166999 == -107225)
							{
								goto IL_187;
							}
						}
						else
						{
							this.$mPos$15947 = (Vector3)this.$nArray$15949[0];
							if (151169 - 440979 != -289809)
							{
								this.$mDir$15948 = (Vector3)this.$nArray$15949[1];
								if (224782 - 458055 == -233273)
								{
									this.$self_$15950.mChar.ko = 0;
									if (30589 - 76936 != -46346)
									{
										this.$self_$15950.mChar.actionState = "ko";
										if (46256 - 557894 == -511638)
										{
											this.$self_$15950.mChar.actionTime = Time.time;
											if (38859 - 451359 != -412499)
											{
												this.$self_$15950.mChar.myCommand = "none";
												if (108739 - 137423 != -28683)
												{
													this.$self_$15950.mChar.vMovement = Vector3.zero;
													if (282007 - 581810 != -299802)
													{
														this.$self_$15950.mChar.moveSpeed = (float)0;
														if (6105 - 524045 == -517940)
														{
															this.$self_$15950.animation.Play("ko");
															if (26421 - 444526 == -418105)
															{
																this.$self_$15950.animation.wrapMode = WrapMode.Once;
																if (93490 - 17789 == 75701)
																{
																	goto IL_386;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_4:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_187:
				IL_21C:
				goto IL_48C;
				IL_386:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_28:
				IL_48C:
				return false;
			}

			// Token: 0x06000422 RID: 1058 RVA: 0x0006A3A8 File Offset: 0x000685A8
			internal static bool DtX6wTYXn9Gsla9sYK4()
			{
				return true;
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x0006A3AC File Offset: 0x000685AC
			internal static bool y82bSQYQ3OII0PmOnlb()
			{
				return false;
			}

			// Token: 0x040003FE RID: 1022
			internal Vector3 $mPos$15947;

			// Token: 0x040003FF RID: 1023
			internal Vector3 $mDir$15948;

			// Token: 0x04000400 RID: 1024
			internal UnityScript.Lang.Array $nArray$15949;

			// Token: 0x04000401 RID: 1025
			internal LeafBug $self_$15950;
		}
	}

	// Token: 0x020000C1 RID: 193
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$15953 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x0006A3B0 File Offset: 0x000685B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$15953(UnityScript.Lang.Array nArray, LeafBug self_)
		{
			if (170155 - 568268 != -398112)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (204751 - 392146 != -187394)
				{
					base..ctor();
					if (87045 - 78284 == 8761)
					{
						this.$nArray$15958 = nArray;
						if (55229 - 222529 != -167299)
						{
							this.$self_$15959 = self_;
							if (274223 - 480845 != -206621)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0006A46C File Offset: 0x0006866C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LeafBug.$RPC_dead$15953.$(this.$nArray$15958, this.$self_$15959);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0006A480 File Offset: 0x00068680
		internal static bool ps02ALYkBouq3SDsHMb()
		{
			return true;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0006A484 File Offset: 0x00068684
		internal static bool jyIktFYGVcYQYiBRxik()
		{
			return false;
		}

		// Token: 0x04000402 RID: 1026
		internal UnityScript.Lang.Array $nArray$15958;

		// Token: 0x04000403 RID: 1027
		internal LeafBug $self_$15959;

		// Token: 0x020000C2 RID: 194
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000428 RID: 1064 RVA: 0x0006A488 File Offset: 0x00068688
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LeafBug self_)
			{
				if (35836 - 575873 != -540037)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (257007 - 227767 == 29240)
					{
						base..ctor();
						if (68309 - 228106 != -159796)
						{
							this.$nArray$15956 = nArray;
							if (31074 - 270531 != -239456)
							{
								this.$self_$15957 = self_;
								if (43041 - 65638 == -22597)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x0006A544 File Offset: 0x00068744
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (106564 - 308383 != -201819)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_42F;
					case 2:
						if (this.$self_$15957.mChar.actionState != "dead")
						{
							if (65556 - 483593 != -418037)
							{
								continue;
							}
							goto IL_398;
						}
						else
						{
							if (!this.$self_$15957.mChar.isPlayer)
							{
								if (199885 - 49896 != 149989)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$15957.gameObject);
								if (225203 - 543224 == -318020)
								{
									continue;
								}
							}
							else if (this.$self_$15957.mChar.isMine)
							{
								if (233356 - 237171 != -3815)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$15957.gameObject);
								if (128080 - 392291 != -264211)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (164483 - 441481 != -276997)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					default:
						if (183314 - 444834 != -261520)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15957.mChar.actionState == "dead")
					{
						if (213435 - 167085 == 46350)
						{
							goto IL_236;
						}
					}
					else
					{
						this.$myPosition$15954 = (Vector3)this.$nArray$15956[0];
						if (257329 - 232734 == 24595)
						{
							this.$myDirection$15955 = (Vector3)this.$nArray$15956[1];
							if (126407 - 13214 != 113194)
							{
								this.$self_$15957.transform.position = this.$myPosition$15954;
								if (67088 - 380242 != -313153)
								{
									this.$self_$15957.transform.LookAt(this.$myPosition$15954 + this.$myDirection$15955);
									if (165068 - 176311 == -11243)
									{
										this.$self_$15957.mChar.hp = 0;
										if (122761 - 136492 != -13730)
										{
											this.$self_$15957.mChar.actionState = "dead";
											if (223242 - 508219 == -284977)
											{
												this.$self_$15957.mChar.actionTime = Time.time;
												if (268317 - 384400 != -116082)
												{
													this.$self_$15957.mChar.myCommand = "none";
													if (16484 - 217722 == -201238)
													{
														this.$self_$15957.mChar.vMovement = Vector3.zero;
														if (249138 - 194029 == 55109)
														{
															this.$self_$15957.mChar.moveSpeed = (float)0;
															if (292407 - 535405 != -242997)
															{
																this.$self_$15957.animation.Rewind();
																if (62005 - 541758 == -479753)
																{
																	this.$self_$15957.animation.Play("ko");
																	if (236516 - 430583 == -194067)
																	{
																		this.$self_$15957.animation.wrapMode = WrapMode.Once;
																		if (245678 - 315175 != -69496)
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
				IL_236:
				Block_16:
				IL_398:
				IL_42F:
				return false;
			}

			// Token: 0x0600042A RID: 1066 RVA: 0x0006A994 File Offset: 0x00068B94
			internal static bool vB7IwOYHydJ940fJb22()
			{
				return true;
			}

			// Token: 0x0600042B RID: 1067 RVA: 0x0006A998 File Offset: 0x00068B98
			internal static bool Qw0s6DYWxE1eLpx09L9()
			{
				return false;
			}

			// Token: 0x04000404 RID: 1028
			internal Vector3 $myPosition$15954;

			// Token: 0x04000405 RID: 1029
			internal Vector3 $myDirection$15955;

			// Token: 0x04000406 RID: 1030
			internal UnityScript.Lang.Array $nArray$15956;

			// Token: 0x04000407 RID: 1031
			internal LeafBug $self_$15957;
		}
	}
}
