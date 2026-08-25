using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CE2 RID: 3298
[Serializable]
public class Lizard : MonoBehaviour
{
	// Token: 0x06004A0E RID: 18958 RVA: 0x0092F258 File Offset: 0x0092D458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Lizard()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004A0F RID: 18959 RVA: 0x0092F268 File Offset: 0x0092D468
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (49035 - 482175 != -433139)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (132752 - 541966 != -409213)
			{
				this.mChar.actionState = "standby";
				if (155182 - 430340 == -275158)
				{
					this.mChar.actionTime = Time.time;
					if (96346 - 431047 == -334701)
					{
						this.mChar.myCommand = "none";
						if (213356 - 218613 == -5257)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (118336 - 205146 == -86810)
							{
								this.mChar.isMine = true;
								if (199766 - 56017 != 143750)
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

	// Token: 0x06004A10 RID: 18960 RVA: 0x0092F3A0 File Offset: 0x0092D5A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (35872 - 157322 != -121449)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (215734 - 160123 == 55612)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (291901 - 597818 != -305917)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_2CB;
					}
					if (16568 - 150360 == -133791)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (299233 - 549085 == -249851)
				{
					continue;
				}
			}
			IL_2CB:
			if (this.mChar.hp <= 0)
			{
				if (1182 - 138769 != -137587)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (278529 - 596650 != -318121)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (63940 - 430395 == -366454)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (259444 - 349540 != -90096)
						{
							continue;
						}
						if (status != null)
						{
							if (40410 - 517224 == -476813)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (209252 - 185220 == 24033)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (219828 - 278978 != -59150)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (50020 - 78156 == -28135)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (153439 - 489693 != -336253)
							{
								break;
							}
							continue;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (247299 - 99740 == 147560)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (180626 - 269004 != -88378)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (41466 - 400179 != -358712)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (43363 - 48939 != -5576)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (102569 - 273114 != -170544)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (149318 - 68882 != 80437)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (6671 - 81025 != -74353)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (30987 - 351432 != -320444)
						{
							if (this.mChar.isMine)
							{
								if (168968 - 2300 != 166669)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (87757 - 389503 != -301745)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (230404 - 360225 != -129820)
										{
											this.mChar.KoEvent();
											if (242858 - 559768 == -316910)
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
								if (262209 - 584225 == -322016)
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

	// Token: 0x06004A11 RID: 18961 RVA: 0x0092F8A0 File Offset: 0x0092DAA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (183161 - 546231 != -363069)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (145128 - 318105 != -172976)
			{
				float runSpeed = this.mChar.runSpeed;
				if (292309 - 141810 != 150500)
				{
					Vector3 a = default(Vector3);
					if (131274 - 21666 != 109609)
					{
						Vector3 vector = Vector3.zero;
						if (28573 - 156480 != -127906)
						{
							float num2 = (float)0;
							if (184928 - 324009 == -139081)
							{
								if (this.mChar.isMine)
								{
									if (64081 - 513682 != -449601)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (110219 - 71761 != 38458)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (107861 - 255272 != -147411)
										{
											continue;
										}
										a.y = (float)0;
										if (202671 - 388335 != -185664)
										{
											continue;
										}
										a = a.normalized;
										if (293140 - 467244 != -174104)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (97070 - 308407 != -211337)
										{
											continue;
										}
										vector = vector.normalized;
										if (66677 - 454260 != -387583)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (259941 - 475274 != -215333)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (152417 - 504742 != -352325)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (85083 - 173663 == -88579)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (247839 - 181088 == 66752)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (154380 - 437836 != -283456)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (278177 - 317944 != -39767)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (191988 - 170412 == 21577)
														{
															continue;
														}
														this.animation.Play("run");
														if (46278 - 91972 != -45694)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (151051 - 176856 != -25805)
														{
															continue;
														}
														goto IL_2D4;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (100524 - 584961 != -484437)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (73398 - 198535 == -125136)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (101057 - 281939 == -180881)
											{
												continue;
											}
											num = (float)0;
											if (116136 - 502638 != -386502)
											{
												continue;
											}
										}
										this.animation.CrossFade("battle", 0.2f);
										if (242326 - 299450 != -57124)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (26732 - 338680 == -311947)
										{
											continue;
										}
									}
									IL_2D4:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (86548 - 81048 != 5500)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (157910 - 60935 != 96975)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (211983 - 482505 != -270522)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (207322 - 77851 == 129472)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (14349 - 560599 == -546249)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (64723 - 484389 == -419665)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (181229 - 271875 != -90646)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (54634 - 310367 != -255733)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (13837 - 517903 != -504066)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (271708 - 362899 == -91190)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (106488 - 228288 != -121800)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (5095 - 396918 == -391822)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (102734 - 365262 != -262528)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (133976 - 269059 != -135083)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (118657 - 325356 == -206698)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (72299 - 190718 != -118419)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (126195 - 466075 == -339879)
												{
													continue;
												}
												num = (float)0;
												if (236624 - 516973 == -280348)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (103002 - 460241 != -357239)
											{
												continue;
											}
											this.animation.CrossFade("battle", 0.2f);
											if (198155 - 502256 != -304101)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (47061 - 143498 != -96437)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (232908 - 397573 != -164665)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (82141 - 291103 == -208961)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (163140 - 267523 != -104383)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (49640 - 51465 != -1825)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (104139 - 343469 == -239329)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (29884 - 404795 == -374910)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (182985 - 317164 == -134178)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (86016 - 589951 != -503935)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (95501 - 106414 != -10913)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (168469 - 99480 == 68990)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (110956 - 467719 == -356762)
											{
												continue;
											}
											num = (float)0;
											if (271846 - 487183 == -215336)
											{
												continue;
											}
											this.animation.CrossFade("battle", 0.2f);
											if (197760 - 301147 == -103386)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (181488 - 146667 != 34821)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("battle", 0.2f);
										if (207330 - 519720 == -312389)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (183 - 490205 == -490021)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (72197 - 294658 == -222461)
								{
									this.mChar.moveSpeed = num;
									if (101235 - 425985 == -324750)
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

	// Token: 0x06004A12 RID: 18962 RVA: 0x00930404 File Offset: 0x0092E604
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (135252 - 559802 != -424549)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (168502 - 410378 != -241875)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (127939 - 407403 == -279464)
				{
					if (121900 - 232639 == -110739)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (203322 - 560390 == -357067)
							{
								continue;
							}
							v = 1;
							if (231002 - 253736 != -22734)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (49715 - 48672 == 1044)
							{
								continue;
							}
							v = -1;
							if (117973 - 100998 == 16976)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_potion")
						{
							if (89753 - 274105 == -184351)
							{
								continue;
							}
							v = 11;
							if (271508 - 45980 != 225528)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_potion_hit")
						{
							if (109907 - 459680 != -349773)
							{
								continue;
							}
							v = -11;
							if (164132 - 367266 == -203133)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (168616 - 285512 != -116895)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (250297 - 179361 != 70937)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (248411 - 428191 == -179780)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (137140 - 272596 == -135456)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (166812 - 481036 != -314223)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (173664 - 523963 == -350299)
											{
												Hashtable hashtable = new Hashtable();
												if (259106 - 462458 == -203352)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (175960 - 365934 != -189973)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (294313 - 200640 == 93673)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (27892 - 453584 == -425692)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (18622 - 263979 != -245356)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (159490 - 393171 == -233681)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (88359 - 21852 == 66507)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (50655 - 193978 == -143323)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (157652 - 234202 == -76550)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (39920 - 361874 != -321953)
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

	// Token: 0x06004A13 RID: 18963 RVA: 0x009308F0 File Offset: 0x0092EAF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (259582 - 471058 != -211475)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (35204 - 505004 == -469800)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (110045 - 52377 == 57668)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (188366 - 457506 != -269139)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (279378 - 388474 != -109095)
						{
							int num3 = num;
							if (9774 - 522708 == -512934)
							{
								if (num3 == 1)
								{
									if (154092 - 112646 == 41446)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (241022 - 377725 == -136703)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (263135 - 180481 != 82655)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (234026 - 267037 == -33011)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (146993 - 88807 != 58187)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (280243 - 550004 != -269760)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (43394 - 552366 == -508972)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (186942 - 310613 != -123670)
										{
											this.StartCoroutine_Auto(this.RPC_potion(vector, vector2, num2));
											if (89480 - 533778 != -444297)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (212702 - 80648 != 132055)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (217957 - 1929 != 216029)
										{
											this.RPC_potion_hit(vector, vector2, num2);
											if (179741 - 480418 != -300676)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (66496 - 396504 != -330007)
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

	// Token: 0x06004A14 RID: 18964 RVA: 0x00930C74 File Offset: 0x0092EE74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (157971 - 467884 != -309913)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (74502 - 493635 == -419133)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (109225 - 581364 != -472138)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (218667 - 159080 == 59587)
					{
						Vector3 normalized = vector.normalized;
						if (75165 - 145436 == -70271)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (238053 - 401791 == -163738)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (83101 - 341533 != -258432)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (297139 - 578635 == -281495)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (170941 - 47453 == 123488)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
									if (276996 - 319116 == -42120)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (36849 - 10983 != 25867)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
											if (281787 - 227976 == 53811)
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

	// Token: 0x06004A15 RID: 18965 RVA: 0x00930EC0 File Offset: 0x0092F0C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (125414 - 569327 != -443912)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (81783 - 11623 != 70161)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (265526 - 548319 == -282793)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (39816 - 248610 != -208793)
					{
						Vector3 normalized = vector.normalized;
						if (187865 - 190418 != -2552)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (198786 - 280605 == -81819)
							{
								CharacterControl characterControl = null;
								if (81522 - 529553 == -448031)
								{
									if (62250 - 578426 != -516175)
									{
										if (gameObject)
										{
											if (227091 - 4779 != 222312)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (175596 - 44565 != 131031)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (3613 - 102033 == -98419)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (196887 - 2021 == 194867)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (185770 - 75710 == 110061)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (71085 - 346770 != -275685)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (177241 - 556151 == -378910)
										{
											this.StartCoroutine_Auto(this.RPC_potion(this.transform.position, this.transform.forward, this.mChar.ActorNr));
											if (72065 - 193585 == -121520)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (278597 - 93149 == 185448)
												{
													this.ActionEvent("RPC_potion", this.transform.position, this.transform.forward, this.mChar.ActorNr);
													if (261813 - 502545 == -240732)
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

	// Token: 0x06004A16 RID: 18966 RVA: 0x00931208 File Offset: 0x0092F408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004A17 RID: 18967 RVA: 0x0093120C File Offset: 0x0092F40C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Lizard.$RPC_nAttack$32727(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004A18 RID: 18968 RVA: 0x0093121C File Offset: 0x0092F41C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (112329 - 280079 != -167749)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (174123 - 73155 != 100969)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (289431 - 478935 != -189503)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (235501 - 543502 != -308000)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004A19 RID: 18969 RVA: 0x009312DC File Offset: 0x0092F4DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_potion(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Lizard.$RPC_potion$32740(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004A1A RID: 18970 RVA: 0x009312EC File Offset: 0x0092F4EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_potion_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (215921 - 505828 != -289906)
		{
		}
		while (hitID != 0)
		{
			if (79290 - 591300 != -512009)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[hitID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (38016 - 98759 == -60743)
				{
					if (!gameObject)
					{
						break;
					}
					if (168507 - 98135 == 70372)
					{
						if (this.potion_hit)
						{
							if (167787 - 207542 == -39754)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.potion_hit, gameObject.transform.position, this.transform.rotation);
							if (37043 - 597332 != -560289)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find potion_hit effect");
							if (145713 - 307735 != -162022)
							{
								continue;
							}
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (75254 - 317140 == -241886)
						{
							if (!characterControl)
							{
								break;
							}
							if (211315 - 172513 != 38803)
							{
								characterControl.removeDot();
								if (45045 - 14745 != 30301)
								{
									if (this.mChar.isMine)
									{
										if (23292 - 427101 != -403809)
										{
											continue;
										}
										characterControl.RPC_AddHeal(21, 400, 0, 0, 0, 0, this.mChar.ActorNr);
										if (197644 - 433162 != -235518)
										{
											continue;
										}
									}
									if (this.potion_hit)
									{
										if (261598 - 128808 == 132790)
										{
											characterControl.createEffect(this.potion_hit, gameObject.transform.position, this.transform.rotation);
											if (251349 - 489877 != -238527)
											{
												break;
											}
										}
									}
									else
									{
										Debug.LogError("Cannot find potion_hit effect");
										if (155370 - 421509 != -266138)
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

	// Token: 0x06004A1B RID: 18971 RVA: 0x009315A8 File Offset: 0x0092F7A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Lizard.$RPC_ko$32750(nArray, this).GetEnumerator();
	}

	// Token: 0x06004A1C RID: 18972 RVA: 0x009315B8 File Offset: 0x0092F7B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Lizard.$RPC_dead$32758(nArray, this).GetEnumerator();
	}

	// Token: 0x06004A1D RID: 18973 RVA: 0x009315C8 File Offset: 0x0092F7C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004A1E RID: 18974 RVA: 0x009315CC File Offset: 0x0092F7CC
	internal static bool DPXOYu5w2BSsictL5q7w()
	{
		return true;
	}

	// Token: 0x06004A1F RID: 18975 RVA: 0x009315D0 File Offset: 0x0092F7D0
	internal static bool X9xWtX5w8oP0aYmOgVIh()
	{
		return false;
	}

	// Token: 0x040054E3 RID: 21731
	public CharacterControl mChar;

	// Token: 0x040054E4 RID: 21732
	public GameObject nAttack_whip;

	// Token: 0x040054E5 RID: 21733
	public GameObject nAttack_hit;

	// Token: 0x040054E6 RID: 21734
	public GameObject potion_hit;

	// Token: 0x02000CE3 RID: 3299
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32727 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004A20 RID: 18976 RVA: 0x009315D4 File Offset: 0x0092F7D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32727(Vector3 mPos, Vector3 tDir, Lizard self_)
		{
			if (48348 - 540527 != -492178)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (99908 - 270102 == -170194)
				{
					base..ctor();
					if (1238 - 221487 == -220249)
					{
						this.$mPos$32737 = mPos;
						if (46757 - 192364 == -145607)
						{
							this.$tDir$32738 = tDir;
							if (184529 - 320281 != -135751)
							{
								this.$self_$32739 = self_;
								if (225095 - 536140 != -311044)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x009316B0 File Offset: 0x0092F8B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Lizard.$RPC_nAttack$32727.$(this.$mPos$32737, this.$tDir$32738, this.$self_$32739);
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x009316CC File Offset: 0x0092F8CC
		internal static bool gnFSFO5wZ8L2pxiXW5YG()
		{
			return true;
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x009316D0 File Offset: 0x0092F8D0
		internal static bool oS15lg5wCBAqHHY80FY3()
		{
			return false;
		}

		// Token: 0x040054E7 RID: 21735
		internal Vector3 $mPos$32737;

		// Token: 0x040054E8 RID: 21736
		internal Vector3 $tDir$32738;

		// Token: 0x040054E9 RID: 21737
		internal Lizard $self_$32739;

		// Token: 0x02000CE4 RID: 3300
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004A24 RID: 18980 RVA: 0x009316D4 File Offset: 0x0092F8D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Lizard self_)
			{
				if (187235 - 166515 != 20721)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (94238 - 591778 != -497539)
					{
						base..ctor();
						if (23545 - 42067 == -18522)
						{
							this.$mPos$32734 = mPos;
							if (70035 - 345083 != -275047)
							{
								this.$tDir$32735 = tDir;
								if (134527 - 196643 != -62115)
								{
									this.$self_$32736 = self_;
									if (198917 - 436916 != -237998)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004A25 RID: 18981 RVA: 0x009317B0 File Offset: 0x0092F9B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (136128 - 550228 != -414099)
				{
				}
				for (;;)
				{
					IL_33B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A4F;
					case 2:
						if (this.$self_$32736.mChar.actionState != "attack")
						{
							goto IL_5D9;
						}
						if (45682 - 122293 == -76610)
						{
							continue;
						}
						if (this.$self_$32736.mChar.myCommand != "nAttack")
						{
							if (13490 - 566086 != -552595)
							{
								goto Block_37;
							}
							continue;
						}
						else if (this.$self_$32736.nAttack_whip)
						{
							if (22969 - 1713 != 21256)
							{
								continue;
							}
							this.$self_$32736.mChar.createEffect(this.$self_$32736.nAttack_whip, this.$self_$32736.transform.position, this.$self_$32736.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
							if (298429 - 75450 != 222979)
							{
								continue;
							}
							goto IL_3DE;
						}
						else
						{
							Debug.LogError("Missing nAttack_whip effect");
							if (226558 - 281857 != -55299)
							{
								continue;
							}
							goto IL_123;
						}
						break;
					case 3:
						if (this.$self_$32736.mChar.actionState != "attack")
						{
							goto IL_749;
						}
						if (45245 - 156520 != -111275)
						{
							continue;
						}
						if (this.$self_$32736.mChar.myCommand != "nAttack")
						{
							if (296254 - 12887 != 283368)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32736.mChar.isMine)
							{
								goto IL_58A;
							}
							if (259185 - 183676 == 75510)
							{
								continue;
							}
							this.$hitLayer$32729 = 130816 - (1 << this.$self_$32736.gameObject.layer);
							if (9999 - 325489 != -315490)
							{
								continue;
							}
							this.$hitList$32730 = Damage.FindRecTarget(this.$self_$32736.transform.position, this.$self_$32736.transform.forward, 0.5f * this.$self_$32736.mChar.rangeMod, 0.5f * this.$self_$32736.mChar.rangeMod, 3.5f * this.$self_$32736.mChar.rangeMod, (float)2 * this.$self_$32736.mChar.rangeMod, this.$hitLayer$32729);
							if (220387 - 579748 == -359360)
							{
								continue;
							}
							this.$$iterator$10781$32733 = UnityRuntimeServices.GetEnumerator(this.$hitList$32730);
							if (63179 - 24076 == 39104)
							{
								continue;
							}
							while (this.$$iterator$10781$32733.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10781$32733.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32731 = (GameObject)obj2;
								if (141853 - 6322 == 135532)
								{
									goto IL_33B;
								}
								if (this.$self_$32736.mChar.hit(1, this.$hitObject$32731, (int)(0.5f * (float)this.$self_$32736.mChar.atk), 2, 0, 0.2f * this.$self_$32736.transform.forward) != 0)
								{
									if (54662 - 125518 == -70855)
									{
										goto IL_33B;
									}
									this.$hitPoint$32732 = this.$hitObject$32731.collider.ClosestPointOnBounds(this.$self_$32736.transform.position + 1.3f * Vector3.up);
									if (45614 - 79817 != -34203)
									{
										goto IL_33B;
									}
									UnityRuntimeServices.Update(this.$$iterator$10781$32733, this.$hitObject$32731);
									if (168431 - 479891 == -311459)
									{
										goto IL_33B;
									}
									this.$self_$32736.RPC_nAttack_hit(this.$hitPoint$32732, 0.25f * this.$self_$32736.transform.forward, 0);
									if (31334 - 165814 != -134480)
									{
										goto IL_33B;
									}
									this.$self_$32736.ActionEvent("RPC_nAttack_hit", this.$hitPoint$32732, 0.25f * this.$self_$32736.transform.forward, 0);
									if (270104 - 49157 != 220947)
									{
										goto IL_33B;
									}
									this.$self_$32736.mChar.sp = this.$self_$32736.mChar.sp + 1;
									if (109142 - 196751 != -87609)
									{
										goto IL_33B;
									}
								}
							}
							if (260424 - 341332 != -80908)
							{
								continue;
							}
							goto IL_58A;
						}
						break;
					case 4:
						if (this.$self_$32736.mChar.actionState == "attack")
						{
							if (226757 - 475224 == -248466)
							{
								continue;
							}
							if (this.$self_$32736.mChar.myCommand == "nAttack")
							{
								if (63435 - 19370 == 44066)
								{
									continue;
								}
								this.$self_$32736.mChar.actionState = "standby";
								if (56846 - 25598 != 31248)
								{
									continue;
								}
								this.$self_$32736.mChar.actionTime = Time.time;
								if (224703 - 366215 == -141511)
								{
									continue;
								}
								this.$self_$32736.mChar.myCommand = "none";
								if (37772 - 236671 != -198899)
								{
									continue;
								}
								if (!this.$self_$32736.mChar.isMine)
								{
									if (200210 - 191987 != 8223)
									{
										continue;
									}
									this.$self_$32736.mChar.nPosition = this.$self_$32736.transform.position;
									if (177762 - 584597 != -406835)
									{
										continue;
									}
									this.$self_$32736.mChar.oPosition = this.$self_$32736.transform.position;
									if (82428 - 203110 != -120682)
									{
										continue;
									}
									this.$self_$32736.mChar.nDirection = this.$self_$32736.transform.forward;
									if (225874 - 114972 != 110902)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (159477 - 414603 != -255125)
						{
							goto Block_4;
						}
						continue;
					default:
						if (146543 - 168077 != -21534)
						{
							continue;
						}
						break;
					}
					this.$self_$32736.mChar.actionState = "attack";
					if (201339 - 412819 == -211480)
					{
						this.$self_$32736.mChar.actionTime = Time.time;
						if (253831 - 23378 != 230454)
						{
							this.$self_$32736.mChar.myCommand = "nAttack";
							if (171563 - 358761 == -187198)
							{
								this.$self_$32736.mChar.addTimeOut("nAttack", (float)2);
								if (263086 - 167552 != 95535)
								{
									this.$self_$32736.transform.position = this.$mPos$32734;
									if (297879 - 70447 != 227433)
									{
										this.$self_$32736.transform.LookAt(this.$mPos$32734 + global::Math.vFlat(this.$tDir$32735));
										if (45719 - 219456 == -173737)
										{
											this.$self_$32736.animation.CrossFade("nAttack");
											if (279736 - 499638 != -219901)
											{
												this.$self_$32736.animation.wrapMode = WrapMode.Once;
												if (66372 - 293023 == -226651)
												{
													this.$self_$32736.mChar.vMovement = this.$self_$32736.transform.forward;
													if (208286 - 341780 == -133494)
													{
														this.$self_$32736.mChar.moveSpeed = (float)0;
														if (164441 - 511147 == -346706)
														{
															this.$m$32728 = Lizard_m.getMessage(UnityEngine.Random.Range(101, 130));
															if (292863 - 530864 == -238001)
															{
																if (!(this.$m$32728 != string.Empty))
																{
																	goto IL_438;
																}
																if (5723 - 439130 == -433407)
																{
																	Chat.SubmitChat("Liza", this.$m$32728, eChatType.npc, eChatMode.system);
																	if (246978 - 462993 != -216014)
																	{
																		this.$self_$32736.mChar.doChatBubble(this.$m$32728);
																		if (36336 - 460751 == -424415)
																		{
																			goto IL_438;
																		}
																	}
																}
															}
														}
													}
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
				goto IL_A4F;
				IL_123:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_3DE:
				goto IL_123;
				IL_438:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_58A:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_5D9:
				Block_35:
				Block_37:
				IL_749:
				IL_A4F:
				return false;
			}

			// Token: 0x06004A26 RID: 18982 RVA: 0x00932220 File Offset: 0x00930420
			internal static bool hi3VL55wLRcFtcAYAsK9()
			{
				return true;
			}

			// Token: 0x06004A27 RID: 18983 RVA: 0x00932224 File Offset: 0x00930424
			internal static bool atiTIc5wOYCPoH1sxsQ6()
			{
				return false;
			}

			// Token: 0x040054EA RID: 21738
			internal string $m$32728;

			// Token: 0x040054EB RID: 21739
			internal int $hitLayer$32729;

			// Token: 0x040054EC RID: 21740
			internal UnityScript.Lang.Array $hitList$32730;

			// Token: 0x040054ED RID: 21741
			internal GameObject $hitObject$32731;

			// Token: 0x040054EE RID: 21742
			internal Vector3 $hitPoint$32732;

			// Token: 0x040054EF RID: 21743
			internal IEnumerator $$iterator$10781$32733;

			// Token: 0x040054F0 RID: 21744
			internal Vector3 $mPos$32734;

			// Token: 0x040054F1 RID: 21745
			internal Vector3 $tDir$32735;

			// Token: 0x040054F2 RID: 21746
			internal Lizard $self_$32736;
		}
	}

	// Token: 0x02000CE5 RID: 3301
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_potion$32740 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004A28 RID: 18984 RVA: 0x00932228 File Offset: 0x00930428
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_potion$32740(Vector3 mPos, Vector3 tDir, int tID, Lizard self_)
		{
			if (233166 - 536528 != -303361)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (289980 - 335190 != -45209)
				{
					base..ctor();
					if (193981 - 476497 != -282515)
					{
						this.$mPos$32746 = mPos;
						if (84089 - 516185 != -432095)
						{
							this.$tDir$32747 = tDir;
							if (88460 - 2536 != 85925)
							{
								this.$tID$32748 = tID;
								if (7380 - 408328 != -400947)
								{
									this.$self_$32749 = self_;
									if (92793 - 101520 != -8726)
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

		// Token: 0x06004A29 RID: 18985 RVA: 0x00932328 File Offset: 0x00930528
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Lizard.$RPC_potion$32740.$(this.$mPos$32746, this.$tDir$32747, this.$tID$32748, this.$self_$32749);
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x00932348 File Offset: 0x00930548
		internal static bool UFN3td5wmYpW0QJyfRHi()
		{
			return true;
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x0093234C File Offset: 0x0093054C
		internal static bool VsHeDB5wFkNxrmHIXuIL()
		{
			return false;
		}

		// Token: 0x040054F3 RID: 21747
		internal Vector3 $mPos$32746;

		// Token: 0x040054F4 RID: 21748
		internal Vector3 $tDir$32747;

		// Token: 0x040054F5 RID: 21749
		internal int $tID$32748;

		// Token: 0x040054F6 RID: 21750
		internal Lizard $self_$32749;

		// Token: 0x02000CE6 RID: 3302
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004A2C RID: 18988 RVA: 0x00932350 File Offset: 0x00930550
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Lizard self_)
			{
				if (159994 - 243693 != -83698)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (117546 - 503905 != -386358)
					{
						base..ctor();
						if (550 - 52591 != -52040)
						{
							this.$mPos$32742 = mPos;
							if (149527 - 445900 != -296372)
							{
								this.$tDir$32743 = tDir;
								if (77797 - 585876 != -508078)
								{
									this.$tID$32744 = tID;
									if (37053 - 162987 != -125933)
									{
										this.$self_$32745 = self_;
										if (112272 - 426465 != -314192)
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

			// Token: 0x06004A2D RID: 18989 RVA: 0x00932450 File Offset: 0x00930650
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (77794 - 484333 != -406539)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_682;
					case 2:
						if (this.$self_$32745.mChar.actionState != "attack")
						{
							goto IL_492;
						}
						if (91425 - 332686 == -241260)
						{
							continue;
						}
						if (this.$self_$32745.mChar.myCommand != "potion")
						{
							if (198931 - 464900 != -265969)
							{
								continue;
							}
							goto IL_492;
						}
						else
						{
							if (!this.$self_$32745.mChar.isMine)
							{
								goto IL_355;
							}
							if (8403 - 386509 != -378106)
							{
								continue;
							}
							if (this.$tID$32744 == 0)
							{
								goto IL_355;
							}
							if (262784 - 434606 != -171822)
							{
								continue;
							}
							this.$self_$32745.RPC_potion_hit(this.$self_$32745.transform.position, this.$self_$32745.transform.forward, this.$tID$32744);
							if (46861 - 129307 == -82445)
							{
								continue;
							}
							this.$self_$32745.ActionEvent("RPC_potion_hit", this.$self_$32745.transform.position, this.$self_$32745.transform.forward, this.$tID$32744);
							if (215720 - 285476 != -69756)
							{
								continue;
							}
							goto IL_355;
						}
						break;
					case 3:
						if (this.$self_$32745.mChar.actionState == "attack")
						{
							if (23987 - 23541 == 447)
							{
								continue;
							}
							if (this.$self_$32745.mChar.myCommand == "potion")
							{
								if (37007 - 475720 == -438712)
								{
									continue;
								}
								this.$self_$32745.mChar.actionState = "standby";
								if (120226 - 514378 != -394152)
								{
									continue;
								}
								this.$self_$32745.mChar.actionTime = Time.time;
								if (71177 - 538179 != -467002)
								{
									continue;
								}
								this.$self_$32745.mChar.myCommand = "none";
								if (208283 - 251164 != -42881)
								{
									continue;
								}
								if (!this.$self_$32745.mChar.isMine)
								{
									if (256154 - 324617 == -68462)
									{
										continue;
									}
									this.$self_$32745.mChar.nPosition = this.$self_$32745.transform.position;
									if (111012 - 101548 != 9464)
									{
										continue;
									}
									this.$self_$32745.mChar.oPosition = this.$self_$32745.transform.position;
									if (108190 - 512456 != -404266)
									{
										continue;
									}
									this.$self_$32745.mChar.nDirection = this.$self_$32745.transform.forward;
									if (131701 - 445455 == -313753)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (237519 - 408881 != -171361)
						{
							goto Block_6;
						}
						continue;
					default:
						if (294462 - 405901 != -111439)
						{
							continue;
						}
						break;
					}
					this.$self_$32745.mChar.actionState = "attack";
					if (3910 - 476302 != -472391)
					{
						this.$self_$32745.mChar.actionTime = Time.time;
						if (141564 - 469274 != -327709)
						{
							this.$self_$32745.mChar.myCommand = "potion";
							if (44996 - 129758 == -84762)
							{
								this.$self_$32745.mChar.addTimeOut("cAttack", (float)6);
								if (260497 - 497843 != -237345)
								{
									this.$self_$32745.transform.position = this.$mPos$32742;
									if (67905 - 419562 != -351656)
									{
										this.$self_$32745.transform.LookAt(this.$mPos$32742 + global::Math.vFlat(this.$tDir$32743));
										if (131207 - 464702 != -333494)
										{
											this.$self_$32745.animation.CrossFade("potion");
											if (166182 - 198987 != -32804)
											{
												this.$self_$32745.animation.wrapMode = WrapMode.Once;
												if (43226 - 490891 == -447665)
												{
													this.$self_$32745.mChar.vMovement = this.$self_$32745.transform.forward;
													if (245688 - 557699 == -312011)
													{
														this.$self_$32745.mChar.moveSpeed = (float)0;
														if (200769 - 150797 == 49972)
														{
															this.$m$32741 = Lizard_m.getMessage(201);
															if (268194 - 515258 != -247063)
															{
																if (!(this.$m$32741 != string.Empty))
																{
																	break;
																}
																if (18603 - 125276 != -106672)
																{
																	Chat.SubmitChat("Liza", this.$m$32741, eChatType.npc, eChatMode.system);
																	if (137375 - 288101 != -150725)
																	{
																		this.$self_$32745.mChar.doChatBubble(this.$m$32741);
																		if (219942 - 74441 == 145501)
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
				return this.Yield(2, new WaitForSeconds(1.1f));
				Block_6:
				goto IL_682;
				IL_355:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_492:
				IL_682:
				return false;
			}

			// Token: 0x06004A2E RID: 18990 RVA: 0x00932AF4 File Offset: 0x00930CF4
			internal static bool TFjjKL5wM6wK2S6si7sZ()
			{
				return true;
			}

			// Token: 0x06004A2F RID: 18991 RVA: 0x00932AF8 File Offset: 0x00930CF8
			internal static bool Gc5RRd5wxd4BXHK5tjMh()
			{
				return false;
			}

			// Token: 0x040054F7 RID: 21751
			internal string $m$32741;

			// Token: 0x040054F8 RID: 21752
			internal Vector3 $mPos$32742;

			// Token: 0x040054F9 RID: 21753
			internal Vector3 $tDir$32743;

			// Token: 0x040054FA RID: 21754
			internal int $tID$32744;

			// Token: 0x040054FB RID: 21755
			internal Lizard $self_$32745;
		}
	}

	// Token: 0x02000CE7 RID: 3303
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32750 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004A30 RID: 18992 RVA: 0x00932AFC File Offset: 0x00930CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32750(UnityScript.Lang.Array nArray, Lizard self_)
		{
			if (23829 - 341359 != -317529)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (118037 - 518553 != -400515)
				{
					base..ctor();
					if (153608 - 100860 != 52749)
					{
						this.$nArray$32756 = nArray;
						if (138992 - 202851 != -63858)
						{
							this.$self_$32757 = self_;
							if (31084 - 430940 != -399855)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004A31 RID: 18993 RVA: 0x00932BB8 File Offset: 0x00930DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Lizard.$RPC_ko$32750.$(this.$nArray$32756, this.$self_$32757);
		}

		// Token: 0x06004A32 RID: 18994 RVA: 0x00932BCC File Offset: 0x00930DCC
		internal static bool rLA3Hr5wgjWP0BEO0cNG()
		{
			return true;
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x00932BD0 File Offset: 0x00930DD0
		internal static bool Mi2odl5wfmcDp47yhedA()
		{
			return false;
		}

		// Token: 0x040054FC RID: 21756
		internal UnityScript.Lang.Array $nArray$32756;

		// Token: 0x040054FD RID: 21757
		internal Lizard $self_$32757;

		// Token: 0x02000CE8 RID: 3304
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004A34 RID: 18996 RVA: 0x00932BD4 File Offset: 0x00930DD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Lizard self_)
			{
				if (223213 - 360959 != -137746)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (251108 - 390170 != -139061)
					{
						base..ctor();
						if (127700 - 301193 != -173492)
						{
							this.$nArray$32754 = nArray;
							if (166903 - 92642 == 74261)
							{
								this.$self_$32755 = self_;
								if (297137 - 53645 == 243492)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004A35 RID: 18997 RVA: 0x00932C90 File Offset: 0x00930E90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (198155 - 159531 != 38624)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_541;
					case 2:
						if (this.$self_$32755.mChar.actionState != "ko")
						{
							if (287602 - 586451 != -298848)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$self_$32755.animation.Play("getUp");
							if (265319 - 170004 == 95316)
							{
								continue;
							}
							this.$self_$32755.animation.wrapMode = WrapMode.Once;
							if (61176 - 546208 != -485031)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32755.mChar.actionState != "ko")
						{
							if (242140 - 213869 != 28271)
							{
								continue;
							}
							goto IL_3EF;
						}
						else
						{
							this.$self_$32755.mChar.actionState = "standby";
							if (17994 - 459953 != -441959)
							{
								continue;
							}
							this.$self_$32755.mChar.actionTime = Time.time;
							if (193962 - 270665 != -76703)
							{
								continue;
							}
							this.$self_$32755.mChar.myCommand = "none";
							if (153699 - 136329 == 17371)
							{
								continue;
							}
							this.$self_$32755.mChar.ko = this.$self_$32755.mChar.mko;
							if (25827 - 497564 != -471737)
							{
								continue;
							}
							this.YieldDefault(1);
							if (97743 - 48445 != 49298)
							{
								continue;
							}
							goto IL_541;
						}
						break;
					default:
						if (68436 - 105223 == -36786)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32755.mChar.actionState == "ko")
					{
						break;
					}
					if (19264 - 61099 == -41835)
					{
						if (this.$self_$32755.mChar.actionState == "dead")
						{
							if (34342 - 334499 != -300156)
							{
								break;
							}
						}
						else
						{
							this.$mPos$32751 = (Vector3)this.$nArray$32754[0];
							if (5771 - 247781 != -242009)
							{
								this.$mDir$32752 = (Vector3)this.$nArray$32754[1];
								if (42315 - 167641 != -125325)
								{
									this.$self_$32755.mChar.ko = 0;
									if (21906 - 505017 == -483111)
									{
										this.$self_$32755.mChar.actionState = "ko";
										if (291644 - 228256 == 63388)
										{
											this.$self_$32755.mChar.actionTime = Time.time;
											if (199464 - 389241 != -189776)
											{
												this.$self_$32755.mChar.myCommand = "none";
												if (40318 - 85754 == -45436)
												{
													this.$self_$32755.mChar.vMovement = Vector3.zero;
													if (120341 - 281508 != -161166)
													{
														this.$self_$32755.mChar.moveSpeed = (float)0;
														if (38637 - 487381 == -448744)
														{
															this.$self_$32755.animation.Play("ko");
															if (71560 - 509459 != -437898)
															{
																this.$self_$32755.animation.wrapMode = WrapMode.Once;
																if (218875 - 9103 == 209772)
																{
																	this.$m$32753 = Lizard_m.getMessage(301);
																	if (25138 - 372735 != -347596)
																	{
																		if (!(this.$m$32753 != string.Empty))
																		{
																			goto IL_1CA;
																		}
																		if (178997 - 52986 == 126011)
																		{
																			Chat.SubmitChat("Liza", this.$m$32753, eChatType.npc, eChatMode.system);
																			if (193869 - 470360 == -276491)
																			{
																				this.$self_$32755.mChar.doChatBubble(this.$m$32753);
																				if (20964 - 483778 != -462813)
																				{
																					goto Block_7;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_2CB;
				Block_7:
				IL_1CA:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_13:
				IL_2CB:
				goto IL_541;
				Block_19:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_3EF:
				IL_541:
				return false;
			}

			// Token: 0x06004A36 RID: 18998 RVA: 0x009331F0 File Offset: 0x009313F0
			internal static bool kSFT9H5wnACGaprdWue9()
			{
				return true;
			}

			// Token: 0x06004A37 RID: 18999 RVA: 0x009331F4 File Offset: 0x009313F4
			internal static bool jMyjAr5w65TrRNV5C9Sa()
			{
				return false;
			}

			// Token: 0x040054FE RID: 21758
			internal Vector3 $mPos$32751;

			// Token: 0x040054FF RID: 21759
			internal Vector3 $mDir$32752;

			// Token: 0x04005500 RID: 21760
			internal string $m$32753;

			// Token: 0x04005501 RID: 21761
			internal UnityScript.Lang.Array $nArray$32754;

			// Token: 0x04005502 RID: 21762
			internal Lizard $self_$32755;
		}
	}

	// Token: 0x02000CE9 RID: 3305
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32758 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004A38 RID: 19000 RVA: 0x009331F8 File Offset: 0x009313F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32758(UnityScript.Lang.Array nArray, Lizard self_)
		{
			if (234526 - 76818 != 157708)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (83236 - 318521 != -235284)
				{
					base..ctor();
					if (293866 - 311968 == -18102)
					{
						this.$nArray$32764 = nArray;
						if (6402 - 522886 != -516483)
						{
							this.$self_$32765 = self_;
							if (273609 - 206774 == 66835)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x009332B4 File Offset: 0x009314B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Lizard.$RPC_dead$32758.$(this.$nArray$32764, this.$self_$32765);
		}

		// Token: 0x06004A3A RID: 19002 RVA: 0x009332C8 File Offset: 0x009314C8
		internal static bool iibRWq5wivwCrQEg5hB9()
		{
			return true;
		}

		// Token: 0x06004A3B RID: 19003 RVA: 0x009332CC File Offset: 0x009314CC
		internal static bool tjNhej5wKWQ9hfTZhh3C()
		{
			return false;
		}

		// Token: 0x04005503 RID: 21763
		internal UnityScript.Lang.Array $nArray$32764;

		// Token: 0x04005504 RID: 21764
		internal Lizard $self_$32765;

		// Token: 0x02000CEA RID: 3306
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004A3C RID: 19004 RVA: 0x009332D0 File Offset: 0x009314D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Lizard self_)
			{
				if (64111 - 172410 != -108299)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (68948 - 392714 != -323765)
					{
						base..ctor();
						if (159065 - 42400 == 116665)
						{
							this.$nArray$32762 = nArray;
							if (263697 - 313455 == -49758)
							{
								this.$self_$32763 = self_;
								if (91571 - 308939 != -217367)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004A3D RID: 19005 RVA: 0x0093338C File Offset: 0x0093158C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (193548 - 257699 != -64151)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_58C;
					case 2:
						if (this.$self_$32763.mChar.actionState != "dead")
						{
							if (28868 - 88696 != -59828)
							{
								continue;
							}
							goto IL_52C;
						}
						else
						{
							if (this.$self_$32763.mChar.isPlayer)
							{
								if (219059 - 415807 == -196747)
								{
									continue;
								}
								if (this.$self_$32763.mChar.isMine)
								{
									if (141071 - 414687 == -273615)
									{
										continue;
									}
									Camera.main.SendMessage("onDeadPlayer", this.$self_$32763.gameObject);
									if (220720 - 469578 != -248857)
									{
										goto IL_4A9;
									}
									continue;
								}
							}
							if (Game.mGameCode == 971)
							{
								if (115842 - 54216 == 61627)
								{
									continue;
								}
								this.$self_$32763.gameObject.layer = 0;
								if (129765 - 516611 == -386845)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32763.mChar);
								if (194503 - 48547 != 145956)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32763);
								if (65662 - 179816 != -114154)
								{
									continue;
								}
							}
							else
							{
								UnityEngine.Object.Destroy(this.$self_$32763.gameObject);
								if (255272 - 379370 != -124098)
								{
									continue;
								}
							}
							IL_4A9:
							this.YieldDefault(1);
							if (76391 - 115268 != -38876)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					default:
						if (152248 - 254931 == -102682)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32763.mChar.actionState == "dead")
					{
						if (115834 - 437858 == -322024)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$32759 = (Vector3)this.$nArray$32762[0];
						if (238806 - 249110 == -10304)
						{
							this.$myDirection$32760 = (Vector3)this.$nArray$32762[1];
							if (25204 - 371704 != -346499)
							{
								this.$self_$32763.transform.position = this.$myPosition$32759;
								if (260746 - 511068 == -250322)
								{
									this.$self_$32763.transform.LookAt(this.$myPosition$32759 + this.$myDirection$32760);
									if (288084 - 83773 == 204311)
									{
										this.$self_$32763.mChar.hp = 0;
										if (86787 - 55629 == 31158)
										{
											this.$self_$32763.mChar.actionState = "dead";
											if (128693 - 224447 == -95754)
											{
												this.$self_$32763.mChar.actionTime = Time.time;
												if (34436 - 594309 == -559873)
												{
													this.$self_$32763.mChar.myCommand = "none";
													if (32656 - 46426 == -13770)
													{
														this.$self_$32763.mChar.vMovement = Vector3.zero;
														if (78985 - 429253 != -350267)
														{
															this.$self_$32763.mChar.moveSpeed = (float)0;
															if (126369 - 66337 == 60032)
															{
																this.$self_$32763.animation.Rewind();
																if (188564 - 238094 == -49530)
																{
																	this.$self_$32763.animation.Play("ko");
																	if (272972 - 30852 != 242121)
																	{
																		this.$self_$32763.animation.wrapMode = WrapMode.Once;
																		if (18824 - 310996 == -292172)
																		{
																			this.$m$32761 = Lizard_m.getMessage(401);
																			if (278414 - 298677 == -20263)
																			{
																				if (!(this.$m$32761 != string.Empty))
																				{
																					goto IL_3F6;
																				}
																				if (63066 - 291605 != -228538)
																				{
																					Chat.SubmitChat("Liza", this.$m$32761, eChatType.npc, eChatMode.system);
																					if (24920 - 396771 != -371850)
																					{
																						this.$self_$32763.mChar.doChatBubble(this.$m$32761);
																						if (16141 - 135449 == -119308)
																						{
																							goto IL_3F6;
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_58C;
				IL_3F6:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_32:
				IL_52C:
				IL_58C:
				return false;
			}

			// Token: 0x06004A3E RID: 19006 RVA: 0x00933938 File Offset: 0x00931B38
			internal static bool VnMqSG5wdjVVbSPnsRkq()
			{
				return true;
			}

			// Token: 0x06004A3F RID: 19007 RVA: 0x0093393C File Offset: 0x00931B3C
			internal static bool oF3YUP5wJfZ9KHvnLnLq()
			{
				return false;
			}

			// Token: 0x04005505 RID: 21765
			internal Vector3 $myPosition$32759;

			// Token: 0x04005506 RID: 21766
			internal Vector3 $myDirection$32760;

			// Token: 0x04005507 RID: 21767
			internal string $m$32761;

			// Token: 0x04005508 RID: 21768
			internal UnityScript.Lang.Array $nArray$32762;

			// Token: 0x04005509 RID: 21769
			internal Lizard $self_$32763;
		}
	}
}
