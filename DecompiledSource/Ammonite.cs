using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B49 RID: 2889
[Serializable]
public class Ammonite : MonoBehaviour
{
	// Token: 0x06004051 RID: 16465 RVA: 0x0082D714 File Offset: 0x0082B914
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Ammonite()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004052 RID: 16466 RVA: 0x0082D724 File Offset: 0x0082B924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (269411 - 456547 != -187135)
		{
		}
		for (;;)
		{
			this.TcnyWadsR6 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (77008 - 323572 == -246564)
			{
				this.TcnyWadsR6.actionState = "standby";
				if (153962 - 278826 != -124863)
				{
					this.TcnyWadsR6.actionTime = Time.time;
					if (234853 - 168158 == 66695)
					{
						this.TcnyWadsR6.myCommand = "none";
						if (223420 - 119891 == 103529)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (295836 - 286630 == 9206)
							{
								this.TcnyWadsR6.isMine = true;
								if (27687 - 284027 != -256339)
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

	// Token: 0x06004053 RID: 16467 RVA: 0x0082D85C File Offset: 0x0082BA5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (21483 - 240026 != -218543)
		{
		}
		for (;;)
		{
			if (this.TcnyWadsR6.isControlled)
			{
				if (73346 - 309839 == -236492)
				{
					continue;
				}
				if (!(this.TcnyWadsR6.actionState == "standby"))
				{
					if (204866 - 86087 != 118779)
					{
						continue;
					}
					if (!(this.TcnyWadsR6.actionState == "run"))
					{
						goto IL_490;
					}
					if (212329 - 354096 == -141766)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (4727 - 116068 == -111340)
				{
					continue;
				}
			}
			IL_490:
			if (this.TcnyWadsR6.hp <= 0)
			{
				if (244081 - 345783 == -101701)
				{
					continue;
				}
				if (this.TcnyWadsR6.actionState != "dead")
				{
					if (41191 - 413722 != -372531)
					{
						continue;
					}
					if (this.TcnyWadsR6.isMine)
					{
						if (44445 - 121707 == -77261)
						{
							continue;
						}
						statusClass status = this.TcnyWadsR6.getStatus("autoLife");
						if (187469 - 496079 != -308610)
						{
							continue;
						}
						if (status != null)
						{
							if (170479 - 460674 != -290195)
							{
								continue;
							}
							this.TcnyWadsR6.hp = 1;
							if (233509 - 356434 == -122924)
							{
								continue;
							}
							this.TcnyWadsR6.RPC_RemoveStatus("autoLife");
							if (72230 - 554000 == -481769)
							{
								continue;
							}
							this.TcnyWadsR6.RPC_createEffect("autoLife");
							if (252628 - 570169 != -317541)
							{
								continue;
							}
							this.TcnyWadsR6.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (23973 - 221789 != -197816)
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
							if (1192 - 443248 != -442056)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (26896 - 117657 != -90761)
							{
								continue;
							}
							this.TcnyWadsR6.DeadEvent();
							if (42837 - 408612 != -365774)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.TcnyWadsR6.hp = 1;
						if (118008 - 116917 != 1092)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.TcnyWadsR6.hp <= 0)
			{
				break;
			}
			if (207115 - 186929 != 20187)
			{
				if (this.TcnyWadsR6.ko > 0)
				{
					break;
				}
				if (219146 - 532633 != -313486)
				{
					if (!(this.TcnyWadsR6.actionState != "ko"))
					{
						break;
					}
					if (133578 - 452617 == -319039)
					{
						if (!(this.TcnyWadsR6.actionState != "dead"))
						{
							break;
						}
						if (134968 - 543600 != -408631)
						{
							if (this.TcnyWadsR6.isMine)
							{
								if (66229 - 94874 == -28645)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (242507 - 502354 == -259847)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (249918 - 372426 != -122507)
										{
											this.TcnyWadsR6.KoEvent();
											if (156721 - 180859 == -24138)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.TcnyWadsR6.ko = 1;
								if (144068 - 69373 == 74695)
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

	// Token: 0x06004054 RID: 16468 RVA: 0x0082DD5C File Offset: 0x0082BF5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (298101 - 26548 != 271554)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (41235 - 499337 != -458101)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (153228 - 523511 != -370282 && 41538 - 401349 != -359810)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (21671 - 378814 != -357143)
						{
							continue;
						}
						v = 1;
						if (200934 - 177242 != 23692)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (163905 - 355791 != -191886)
						{
							continue;
						}
						v = -1;
						if (267786 - 307302 == -39515)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_guard")
					{
						if (35935 - 555737 == -519801)
						{
							continue;
						}
						v = 11;
						if (76850 - 30407 != 46443)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_hydroBlast")
					{
						if (197437 - 174877 == 22561)
						{
							continue;
						}
						v = 21;
						if (103356 - 90907 != 12449)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_hydroBlast_fire")
					{
						if (160320 - 162012 != -1692)
						{
							continue;
						}
						v = 22;
						if (33986 - 528546 == -494559)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rollingSmash")
					{
						if (84779 - 188595 != -103816)
						{
							continue;
						}
						v = 31;
						if (256180 - 189211 != 66969)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (104581 - 209612 == -105031)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (216374 - 42352 == 174022)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (200740 - 36500 != 164241)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (278267 - 85830 == 192437)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (201081 - 537268 == -336187)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (57716 - 104075 != -46358)
										{
											Hashtable hashtable = new Hashtable();
											if (197487 - 363761 != -166273)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (274256 - 254475 == 19781)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (225549 - 247339 != -21789)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (115518 - 231006 == -115488)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (270491 - 72884 != 197608)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (142649 - 45202 == 97447)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (118149 - 481130 == -362981)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (54505 - 514030 == -459525)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (299545 - 464854 != -165308)
																			{
																				PhotonClient.SendEvent(this.TcnyWadsR6.ActorNr, 74, hashtable, true, true);
																				if (44219 - 143874 == -99655)
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

	// Token: 0x06004055 RID: 16469 RVA: 0x0082E2E0 File Offset: 0x0082C4E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (101841 - 389526 != -287684)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (242361 - 386884 == -144523)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (151443 - 470070 == -318627)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (113791 - 137621 == -23830)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (207744 - 465 != 207280)
						{
							int num3 = num;
							if (177921 - 43138 == 134783)
							{
								if (num3 == 1)
								{
									if (31046 - 39580 == -8534)
									{
										if (this.TcnyWadsR6.isMine)
										{
											break;
										}
										if (18709 - 538371 != -519661)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (280833 - 206832 == 74001)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (264785 - 92510 != 172276)
									{
										if (this.TcnyWadsR6.isMine)
										{
											break;
										}
										if (186506 - 542279 == -355773)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (22715 - 423498 != -400782)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (113954 - 225418 == -111464)
									{
										if (this.TcnyWadsR6.isMine)
										{
											break;
										}
										if (161892 - 17597 != 144296)
										{
											this.StartCoroutine_Auto(this.RPC_guard(vector, vector2, num2));
											if (237515 - 258002 != -20486)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (384 - 438893 != -438508)
									{
										if (this.TcnyWadsR6.isMine)
										{
											break;
										}
										if (231538 - 212188 != 19351)
										{
											this.StartCoroutine_Auto(this.RPC_hydroBlast(vector, vector2, num2));
											if (43833 - 155501 == -111668)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (174767 - 332678 != -157910)
									{
										if (this.TcnyWadsR6.isMine)
										{
											break;
										}
										if (67719 - 449602 != -381882)
										{
											this.RPC_hydroBlast_fire(vector, vector2, num2);
											if (299044 - 325729 == -26685)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (157087 - 6268 == 150819)
									{
										if (this.TcnyWadsR6.isMine)
										{
											break;
										}
										if (241595 - 100335 != 141261)
										{
											this.StartCoroutine_Auto(this.RPC_rollingSmash(vector, vector2, num2));
											if (202097 - 95750 != 106348)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (136965 - 299429 != -162463)
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

	// Token: 0x06004056 RID: 16470 RVA: 0x0082E75C File Offset: 0x0082C95C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (62855 - 326810 != -263955)
		{
		}
		for (;;)
		{
			float num = this.TcnyWadsR6.moveSpeed;
			if (214310 - 363359 != -149048)
			{
				float runSpeed = this.TcnyWadsR6.runSpeed;
				if (297857 - 186303 == 111554)
				{
					Vector3 a = default(Vector3);
					if (5075 - 388797 == -383722)
					{
						Vector3 vector = Vector3.zero;
						if (34422 - 440896 != -406473)
						{
							float num2 = (float)0;
							if (39171 - 456459 != -417287)
							{
								if (this.TcnyWadsR6.isMine)
								{
									if (94854 - 57198 != 37656)
									{
										continue;
									}
									if ((this.TcnyWadsR6.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (36550 - 462616 != -426066)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (175556 - 33853 != 141703)
										{
											continue;
										}
										a.y = (float)0;
										if (129436 - 328473 != -199037)
										{
											continue;
										}
										a = a.normalized;
										if (138153 - 312191 == -174037)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (2742 - 206136 == -203393)
										{
											continue;
										}
										vector = vector.normalized;
										if (294375 - 150458 == 143918)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (1280 - 225655 != -224375)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (268545 - 209571 != 58974)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (231715 - 238964 == -7248)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (290088 - 536199 == -246110)
														{
															continue;
														}
														this.TcnyWadsR6.actionState = "run";
														if (73473 - 366689 == -293215)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (43503 - 334699 == -291195)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (176250 - 184350 != -8100)
														{
															continue;
														}
														this.animation.Play("run");
														if (227576 - 242266 != -14690)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (209976 - 542362 != -332385)
														{
															goto IL_72D;
														}
														continue;
													}
												}
											}
										}
										this.TcnyWadsR6.actionState = "standby";
										if (293129 - 91966 == 201164)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (242284 - 107456 != 134828)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (71129 - 31106 != 40023)
											{
												continue;
											}
											num = (float)0;
											if (144875 - 497724 != -352849)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (2506 - 286717 != -284211)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (174938 - 329448 == -154509)
										{
											continue;
										}
									}
									IL_72D:;
								}
								else
								{
									vector = global::Math.vFlat(this.TcnyWadsR6.nPosition - this.transform.position);
									if (180038 - 119904 == 60135)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (77266 - 505461 == -428194)
									{
										continue;
									}
									if (this.TcnyWadsR6.nSpeed != (float)0)
									{
										if (95272 - 245335 != -150063)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (103702 - 257722 != -154020)
											{
												continue;
											}
											this.transform.position = this.TcnyWadsR6.nPosition;
											if (77869 - 550463 == -472593)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (52841 - 585371 == -532529)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (169599 - 14106 != 155493)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (13741 - 202000 != -188259)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.TcnyWadsR6.nSpeed, (float)10 * Time.deltaTime);
												if (201778 - 245243 == -43464)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (80202 - 345900 == -265697)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (67480 - 585060 != -517580)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (102672 - 461858 != -359186)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (150714 - 149569 == 1146)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (54442 - 187084 != -132642)
											{
												continue;
											}
										}
										else if (Time.time > this.TcnyWadsR6.nSpeed + 0.3f)
										{
											if (85088 - 483341 != -398253)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (23552 - 308391 == -284838)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (264054 - 142047 != 122007)
												{
													continue;
												}
												num = (float)0;
												if (134920 - 23109 == 111812)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.TcnyWadsR6.nDirection);
											if (182591 - 543703 != -361112)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (123440 - 336478 == -213037)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (121156 - 377364 != -256208)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (133538 - 482 != 133056)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (294012 - 49681 != 244331)
											{
												continue;
											}
											this.transform.position = this.TcnyWadsR6.nPosition;
											if (193555 - 151026 != 42529)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (247256 - 77896 != 169360)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (206571 - 346223 != -139652)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (30974 - 359961 == -328986)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (274385 - 305051 != -30666)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (241616 - 16966 != 224650)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (106861 - 589721 != -482860)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (221334 - 240936 == -19601)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.TcnyWadsR6.nDirection);
											if (233167 - 304885 == -71717)
											{
												continue;
											}
											num = (float)0;
											if (296927 - 590075 != -293148)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (87966 - 417418 != -329452)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (54557 - 542911 == -488353)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (157573 - 506647 != -349074)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (176462 - 381935 == -205472)
										{
											continue;
										}
									}
								}
								this.TcnyWadsR6.vMovement = vector;
								if (84004 - 278427 != -194422)
								{
									this.TcnyWadsR6.moveSpeed = num;
									if (134613 - 159334 != -24720)
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

	// Token: 0x06004057 RID: 16471 RVA: 0x0082F2C0 File Offset: 0x0082D4C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (212169 - 540935 != -328766)
		{
		}
		for (;;)
		{
			if (!this.TcnyWadsR6.isMine)
			{
				if (77206 - 367652 == -290446)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (191387 - 567707 != -376319)
				{
					Vector3 vector = a - this.transform.position;
					if (24599 - 143316 == -118717)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (24275 - 559683 != -535407)
						{
							if (!(this.TcnyWadsR6.actionState == "standby"))
							{
								if (105365 - 586251 != -480886)
								{
									continue;
								}
								if (!(this.TcnyWadsR6.actionState == "run"))
								{
									break;
								}
								if (127733 - 284091 == -156357)
								{
									continue;
								}
							}
							if (this.TcnyWadsR6.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (5780 - 355346 == -349566)
							{
								this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
								if (182928 - 560610 != -377681)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (279842 - 435078 == -155236)
									{
										this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (196551 - 106903 == 89648)
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

	// Token: 0x06004058 RID: 16472 RVA: 0x0082F4E4 File Offset: 0x0082D6E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (66961 - 214876 != -147915)
		{
		}
		for (;;)
		{
			if (!this.TcnyWadsR6.isMine)
			{
				if (52463 - 126204 != -73740)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (195012 - 406769 != -211756)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (109892 - 417781 != -307888)
					{
						Vector3 normalized = vector.normalized;
						if (147813 - 41199 != 106615)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (31380 - 276946 == -245566)
							{
								if (962 - 81211 == -80249)
								{
									if (gameObject)
									{
										if (178422 - 23704 == 154719)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (62542 - 384565 == -322022)
										{
											continue;
										}
									}
									if (!(this.TcnyWadsR6.actionState == "standby"))
									{
										if (213506 - 281067 == -67560)
										{
											continue;
										}
										if (!(this.TcnyWadsR6.actionState == "run"))
										{
											break;
										}
										if (53045 - 44822 == 8224)
										{
											continue;
										}
									}
									if (this.TcnyWadsR6.isTimeOut("rollingSmash") != (float)0)
									{
										if (122958 - 212275 != -89316)
										{
											Camera.main.SendMessage("newGameMessage", "RollingSmash is not ready");
											if (267577 - 552251 == -284674)
											{
												break;
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_rollingSmash(this.transform.position, this.transform.forward, 0));
										if (227983 - 334917 != -106933)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (37794 - 444762 != -406967)
											{
												this.ActionEvent("RPC_rollingSmash", this.transform.position, this.transform.forward, 0);
												if (260262 - 592324 != -332061)
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

	// Token: 0x06004059 RID: 16473 RVA: 0x0082F7E8 File Offset: 0x0082D9E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600405A RID: 16474 RVA: 0x0082F7EC File Offset: 0x0082D9EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Ammonite.$RPC_nAttack$31027(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600405B RID: 16475 RVA: 0x0082F7FC File Offset: 0x0082D9FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (93689 - 453725 != -360035)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (134286 - 399007 == -264721)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (184670 - 199254 == -14584)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit Effect");
				if (242063 - 593255 != -351191)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600405C RID: 16476 RVA: 0x0082F8B4 File Offset: 0x0082DAB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_guard(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Ammonite.$RPC_guard$31040(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600405D RID: 16477 RVA: 0x0082F8C4 File Offset: 0x0082DAC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_hydroBlast(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Ammonite.$RPC_hydroBlast$31047(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600405E RID: 16478 RVA: 0x0082F8D4 File Offset: 0x0082DAD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_hydroBlast_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (103069 - 227197 != -124127)
		{
		}
		for (;;)
		{
			IL_133:
			if (this.hydroBlast)
			{
				if (56682 - 582224 == -525541)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.hydroBlast, mPos, Quaternion.identity);
				if (133322 - 418847 == -285524)
				{
					continue;
				}
			}
			else
			{
				Debug.Log("Cannot find hydroBlast effect");
				if (60037 - 242155 == -182117)
				{
					continue;
				}
			}
			if (!this.TcnyWadsR6.isMine)
			{
				break;
			}
			if (121686 - 335530 != -213843)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (101626 - 316339 != -214712)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(mPos, (float)1, (float)3, layerMask);
					if (46765 - 424875 != -378109)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (169501 - 579887 == -410386)
						{
							while (enumerator.MoveNext())
							{
								object obj2 = enumerator.Current;
								object obj4;
								object obj3 = obj4 = obj2;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj4;
								if (188951 - 41645 == 147307)
								{
									goto IL_133;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (247477 - 363303 != -115826)
								{
									goto IL_133;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (246723 - 266858 != -20135)
								{
									goto IL_133;
								}
								if (characterControl)
								{
									if (110430 - 452401 != -341971)
									{
										goto IL_133;
									}
									this.TcnyWadsR6.hit(21, gameObject, this.TcnyWadsR6.talAdjust(45) + characterControl.weight, 1, 0, (float)5 * Vector3.up);
									if (160801 - 19303 == 141499)
									{
										goto IL_133;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (44741 - 46114 != -1373)
									{
										goto IL_133;
									}
								}
							}
							if (278580 - 440194 == -161614)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600405F RID: 16479 RVA: 0x0082FB7C File Offset: 0x0082DD7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rollingSmash(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Ammonite.$RPC_rollingSmash$31057(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004060 RID: 16480 RVA: 0x0082FB8C File Offset: 0x0082DD8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_hide()
	{
		this.TcnyWadsR6.StartCoroutine_Auto(this.TcnyWadsR6.addStatus("hide", 1, 12, 0, this.TcnyWadsR6.ActorNr));
	}

	// Token: 0x06004061 RID: 16481 RVA: 0x0082FBBC File Offset: 0x0082DDBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_summon()
	{
		return new Ammonite.$RPC_summon$31070(this).GetEnumerator();
	}

	// Token: 0x06004062 RID: 16482 RVA: 0x0082FBCC File Offset: 0x0082DDCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Ammonite.$RPC_ko$31078(nArray, this).GetEnumerator();
	}

	// Token: 0x06004063 RID: 16483 RVA: 0x0082FBDC File Offset: 0x0082DDDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Ammonite.$RPC_dead$31085(nArray, this).GetEnumerator();
	}

	// Token: 0x06004064 RID: 16484 RVA: 0x0082FBEC File Offset: 0x0082DDEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004065 RID: 16485 RVA: 0x0082FBF0 File Offset: 0x0082DDF0
	internal static bool AMAR3N5MX1Zfs409W0Lf()
	{
		return true;
	}

	// Token: 0x06004066 RID: 16486 RVA: 0x0082FBF4 File Offset: 0x0082DDF4
	internal static bool xHJRKj5MQc3PLu3AaI2Z()
	{
		return false;
	}

	// Token: 0x04004CAD RID: 19629
	private CharacterControl TcnyWadsR6;

	// Token: 0x04004CAE RID: 19630
	public GameObject nAttack_hit;

	// Token: 0x04004CAF RID: 19631
	public GameObject hydroBlast;

	// Token: 0x04004CB0 RID: 19632
	public GameObject summon;

	// Token: 0x02000B4A RID: 2890
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$31027 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004067 RID: 16487 RVA: 0x0082FBF8 File Offset: 0x0082DDF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$31027(Vector3 mPos, Vector3 tDir, Ammonite self_)
		{
			if (193811 - 88729 != 105083)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (47843 - 362234 != -314390)
				{
					base..ctor();
					if (135542 - 468527 != -332984)
					{
						this.$mPos$31037 = mPos;
						if (58511 - 33262 != 25250)
						{
							this.$tDir$31038 = tDir;
							if (44847 - 239613 == -194766)
							{
								this.$self_$31039 = self_;
								if (24028 - 64947 == -40919)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x0082FCD4 File Offset: 0x0082DED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ammonite.$RPC_nAttack$31027.$(this.$mPos$31037, this.$tDir$31038, this.$self_$31039);
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x0082FCF0 File Offset: 0x0082DEF0
		internal static bool AsNLD15MkeqGpnhYOUS3()
		{
			return true;
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x0082FCF4 File Offset: 0x0082DEF4
		internal static bool OnxkpX5MGLBiJopPwihW()
		{
			return false;
		}

		// Token: 0x04004CB1 RID: 19633
		internal Vector3 $mPos$31037;

		// Token: 0x04004CB2 RID: 19634
		internal Vector3 $tDir$31038;

		// Token: 0x04004CB3 RID: 19635
		internal Ammonite $self_$31039;

		// Token: 0x02000B4B RID: 2891
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600406B RID: 16491 RVA: 0x0082FCF8 File Offset: 0x0082DEF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Ammonite self_)
			{
				if (288968 - 74528 != 214440)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (155143 - 457122 == -301979)
					{
						base..ctor();
						if (246478 - 175759 == 70719)
						{
							this.$mPos$31034 = mPos;
							if (38747 - 194813 == -156066)
							{
								this.$tDir$31035 = tDir;
								if (171414 - 127706 == 43708)
								{
									this.$self_$31036 = self_;
									if (115340 - 453667 == -338327)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600406C RID: 16492 RVA: 0x0082FDD4 File Offset: 0x0082DFD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (84351 - 442699 != -358347)
				{
				}
				for (;;)
				{
					IL_B7:
					switch (this._state)
					{
					case 0:
						goto IL_7AC;
					case 1:
						goto IL_8C4;
					case 2:
						if (this.$self_$31036.TcnyWadsR6.actionState != "attack")
						{
							goto IL_89E;
						}
						if (17290 - 334394 == -317103)
						{
							continue;
						}
						if (this.$self_$31036.TcnyWadsR6.myCommand != "nAttack")
						{
							if (67964 - 141134 != -73169)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							this.$i$31028 = 0;
							if (138801 - 427527 != -288726)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$31036.TcnyWadsR6.actionState != "attack")
						{
							goto IL_49;
						}
						if (234634 - 117681 == 116954)
						{
							continue;
						}
						if (this.$self_$31036.TcnyWadsR6.myCommand != "nAttack")
						{
							if (163765 - 318161 != -154396)
							{
								continue;
							}
							goto IL_49;
						}
						else
						{
							if (this.$self_$31036.TcnyWadsR6.isMine)
							{
								if (38721 - 192470 == -153748)
								{
									continue;
								}
								this.$hitLayer$31029 = 130816 - (1 << this.$self_$31036.gameObject.layer);
								if (283316 - 315621 == -32304)
								{
									continue;
								}
								this.$hitList$31030 = Damage.FindRecTarget(this.$self_$31036.transform.position, this.$self_$31036.transform.forward, (float)3, (float)2, (float)6, (float)3, this.$hitLayer$31029);
								if (150052 - 250593 == -100540)
								{
									continue;
								}
								this.$$iterator$10667$31033 = UnityRuntimeServices.GetEnumerator(this.$hitList$31030);
								if (204311 - 275799 != -71488)
								{
									continue;
								}
								while (this.$$iterator$10667$31033.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10667$31033.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$31031 = (GameObject)obj2;
									if (207230 - 518351 == -311120)
									{
										goto IL_B7;
									}
									if (this.$self_$31036.TcnyWadsR6.hit(1, this.$hitObject$31031, (int)(0.5f * (float)this.$self_$31036.TcnyWadsR6.atk), 2, 0, Vector3.zero) != 0)
									{
										if (178992 - 363364 != -184372)
										{
											goto IL_B7;
										}
										this.$hitPos$31032 = this.$hitObject$31031.collider.bounds.center;
										if (176939 - 532217 == -355277)
										{
											goto IL_B7;
										}
										UnityRuntimeServices.Update(this.$$iterator$10667$31033, this.$hitObject$31031);
										if (293255 - 324561 == -31305)
										{
											goto IL_B7;
										}
										this.$self_$31036.RPC_nAttack_hit(this.$hitPos$31032, this.$self_$31036.transform.forward, 0);
										if (237943 - 463800 != -225857)
										{
											goto IL_B7;
										}
										if (PhotonClient.IsInitialized())
										{
											if (253115 - 153225 != 99890)
											{
												goto IL_B7;
											}
											this.$self_$31036.ActionEvent("RPC_nAttack_hit", this.$hitPos$31032, this.$self_$31036.transform.forward, 0);
											if (54063 - 54429 != -366)
											{
												goto IL_B7;
											}
										}
									}
								}
								if (139951 - 175444 == -35492)
								{
									continue;
								}
							}
							this.$i$31028++;
							if (282650 - 525597 != -242947)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$31036.TcnyWadsR6.actionState == "attack")
						{
							if (298087 - 479783 != -181696)
							{
								continue;
							}
							if (this.$self_$31036.TcnyWadsR6.myCommand == "nAttack")
							{
								if (80286 - 175030 == -94743)
								{
									continue;
								}
								this.$self_$31036.TcnyWadsR6.actionState = "standby";
								if (82195 - 50597 == 31599)
								{
									continue;
								}
								this.$self_$31036.TcnyWadsR6.actionTime = Time.time;
								if (55986 - 277471 == -221484)
								{
									continue;
								}
								this.$self_$31036.TcnyWadsR6.myCommand = "none";
								if (271808 - 589404 != -317596)
								{
									continue;
								}
								if (!this.$self_$31036.TcnyWadsR6.isMine)
								{
									if (278393 - 315663 != -37270)
									{
										continue;
									}
									this.$self_$31036.TcnyWadsR6.nPosition = this.$self_$31036.transform.position;
									if (204306 - 457116 != -252810)
									{
										continue;
									}
									this.$self_$31036.TcnyWadsR6.oPosition = this.$self_$31036.transform.position;
									if (70346 - 97761 == -27414)
									{
										continue;
									}
									this.$self_$31036.TcnyWadsR6.nDirection = this.$self_$31036.transform.forward;
									if (29683 - 72202 != -42519)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (202887 - 39647 != 163240)
						{
							continue;
						}
						goto IL_8C4;
					default:
						if (82822 - 506242 != -423420)
						{
							continue;
						}
						goto IL_7AC;
					}
					if (this.$i$31028 < 3)
					{
						goto IL_18E;
					}
					if (111096 - 76162 != 34935)
					{
						goto Block_49;
					}
					continue;
					IL_7AC:
					this.$self_$31036.TcnyWadsR6.actionState = "attack";
					if (49047 - 21000 != 28048)
					{
						this.$self_$31036.TcnyWadsR6.actionTime = Time.time;
						if (229695 - 134132 != 95564)
						{
							this.$self_$31036.TcnyWadsR6.myCommand = "nAttack";
							if (292055 - 118989 == 173066)
							{
								this.$self_$31036.TcnyWadsR6.addTimeOut("nAttack", (float)1);
								if (129772 - 192226 == -62454)
								{
									this.$self_$31036.transform.position = this.$mPos$31034;
									if (248396 - 202438 != 45959)
									{
										this.$self_$31036.transform.LookAt(this.$mPos$31034 + global::Math.vFlat(this.$tDir$31035));
										if (238389 - 411158 != -172768)
										{
											this.$self_$31036.animation.Rewind();
											if (90972 - 558771 != -467798)
											{
												this.$self_$31036.animation.CrossFade("nAttack");
												if (69442 - 295797 != -226354)
												{
													this.$self_$31036.animation.wrapMode = WrapMode.Once;
													if (14751 - 93733 == -78982)
													{
														this.$self_$31036.TcnyWadsR6.vMovement = this.$self_$31036.transform.forward;
														if (279105 - 205237 == 73868)
														{
															this.$self_$31036.TcnyWadsR6.moveSpeed = (float)0;
															if (22496 - 392054 == -369558)
															{
																goto IL_2A2;
															}
														}
													}
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
				goto IL_8C4;
				IL_18E:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_2A2:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_39:
				goto IL_89E;
				Block_49:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_89E:
				IL_8C4:
				return false;
			}

			// Token: 0x0600406D RID: 16493 RVA: 0x008306B8 File Offset: 0x0082E8B8
			internal static bool awNxYy5MHymvZeyqIk0H()
			{
				return true;
			}

			// Token: 0x0600406E RID: 16494 RVA: 0x008306BC File Offset: 0x0082E8BC
			internal static bool VNg3Mn5MWtSusa0FyIsn()
			{
				return false;
			}

			// Token: 0x04004CB4 RID: 19636
			internal int $i$31028;

			// Token: 0x04004CB5 RID: 19637
			internal int $hitLayer$31029;

			// Token: 0x04004CB6 RID: 19638
			internal UnityScript.Lang.Array $hitList$31030;

			// Token: 0x04004CB7 RID: 19639
			internal GameObject $hitObject$31031;

			// Token: 0x04004CB8 RID: 19640
			internal Vector3 $hitPos$31032;

			// Token: 0x04004CB9 RID: 19641
			internal IEnumerator $$iterator$10667$31033;

			// Token: 0x04004CBA RID: 19642
			internal Vector3 $mPos$31034;

			// Token: 0x04004CBB RID: 19643
			internal Vector3 $tDir$31035;

			// Token: 0x04004CBC RID: 19644
			internal Ammonite $self_$31036;
		}
	}

	// Token: 0x02000B4C RID: 2892
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_guard$31040 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600406F RID: 16495 RVA: 0x008306C0 File Offset: 0x0082E8C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_guard$31040(Vector3 mPos, Vector3 tDir, Ammonite self_)
		{
			if (218454 - 500372 != -281917)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (50156 - 454634 != -404477)
				{
					base..ctor();
					if (175320 - 510460 == -335140)
					{
						this.$mPos$31044 = mPos;
						if (194960 - 547672 == -352712)
						{
							this.$tDir$31045 = tDir;
							if (227402 - 322635 != -95232)
							{
								this.$self_$31046 = self_;
								if (78204 - 539761 != -461556)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x0083079C File Offset: 0x0082E99C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ammonite.$RPC_guard$31040.$(this.$mPos$31044, this.$tDir$31045, this.$self_$31046);
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x008307B8 File Offset: 0x0082E9B8
		internal static bool KyrjvW5MA56TsvlEjBZj()
		{
			return true;
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x008307BC File Offset: 0x0082E9BC
		internal static bool ABOpqF5MlZv4NRNQSfsf()
		{
			return false;
		}

		// Token: 0x04004CBD RID: 19645
		internal Vector3 $mPos$31044;

		// Token: 0x04004CBE RID: 19646
		internal Vector3 $tDir$31045;

		// Token: 0x04004CBF RID: 19647
		internal Ammonite $self_$31046;

		// Token: 0x02000B4D RID: 2893
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004073 RID: 16499 RVA: 0x008307C0 File Offset: 0x0082E9C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Ammonite self_)
			{
				if (149105 - 539108 != -390003)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161849 - 39103 != 122747)
					{
						base..ctor();
						if (192553 - 482292 == -289739)
						{
							this.$mPos$31041 = mPos;
							if (158038 - 383510 == -225472)
							{
								this.$tDir$31042 = tDir;
								if (5339 - 233569 != -228229)
								{
									this.$self_$31043 = self_;
									if (238924 - 441838 == -202914)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004074 RID: 16500 RVA: 0x0083089C File Offset: 0x0082EA9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (157244 - 209236 != -51992)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_551;
					case 2:
						if (this.$self_$31043.TcnyWadsR6.actionState != "attack")
						{
							goto IL_4BC;
						}
						if (6905 - 591815 != -584910)
						{
							continue;
						}
						if (this.$self_$31043.TcnyWadsR6.myCommand != "guard")
						{
							if (21956 - 121875 != -99918)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$self_$31043.TcnyWadsR6.RPC_AddStatus("reflect", 1, 12, 0, this.$self_$31043.TcnyWadsR6.ActorNr);
							if (243779 - 89758 != 154021)
							{
								continue;
							}
							goto IL_3CA;
						}
						break;
					case 3:
						if (this.$self_$31043.TcnyWadsR6.actionState == "attack")
						{
							if (267322 - 16056 == 251267)
							{
								continue;
							}
							if (this.$self_$31043.TcnyWadsR6.myCommand == "guard")
							{
								if (142815 - 265858 == -123042)
								{
									continue;
								}
								this.$self_$31043.TcnyWadsR6.actionState = "standby";
								if (252056 - 220037 != 32019)
								{
									continue;
								}
								this.$self_$31043.TcnyWadsR6.actionTime = Time.time;
								if (227988 - 376625 == -148636)
								{
									continue;
								}
								this.$self_$31043.TcnyWadsR6.myCommand = "none";
								if (23127 - 430975 != -407848)
								{
									continue;
								}
								if (!this.$self_$31043.TcnyWadsR6.isMine)
								{
									if (243991 - 75498 != 168493)
									{
										continue;
									}
									this.$self_$31043.TcnyWadsR6.nPosition = this.$self_$31043.transform.position;
									if (182031 - 555624 != -373593)
									{
										continue;
									}
									this.$self_$31043.TcnyWadsR6.oPosition = this.$self_$31043.transform.position;
									if (150665 - 415452 == -264786)
									{
										continue;
									}
									this.$self_$31043.TcnyWadsR6.nDirection = this.$self_$31043.transform.forward;
									if (35769 - 50520 != -14751)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (36364 - 111173 != -74809)
						{
							continue;
						}
						goto IL_551;
					default:
						if (277708 - 70707 != 207001)
						{
							continue;
						}
						break;
					}
					this.$self_$31043.TcnyWadsR6.actionState = "attack";
					if (249182 - 552123 != -302940)
					{
						this.$self_$31043.TcnyWadsR6.actionTime = Time.time;
						if (169970 - 188032 == -18062)
						{
							this.$self_$31043.TcnyWadsR6.myCommand = "guard";
							if (16122 - 473070 != -456947)
							{
								this.$self_$31043.TcnyWadsR6.addTimeOut("guard", (float)36);
								if (226084 - 517286 != -291201)
								{
									this.$self_$31043.transform.position = this.$mPos$31041;
									if (28471 - 446674 == -418203)
									{
										this.$self_$31043.transform.LookAt(this.$mPos$31041 + global::Math.vFlat(this.$tDir$31042));
										if (89846 - 22067 == 67779)
										{
											this.$self_$31043.animation.Rewind();
											if (230709 - 489259 != -258549)
											{
												this.$self_$31043.animation.CrossFade("guard", 0.3f);
												if (287811 - 474325 == -186514)
												{
													this.$self_$31043.animation.wrapMode = WrapMode.Loop;
													if (144771 - 163550 != -18778)
													{
														this.$self_$31043.TcnyWadsR6.vMovement = this.$self_$31043.transform.forward;
														if (116935 - 202108 == -85173)
														{
															this.$self_$31043.TcnyWadsR6.moveSpeed = (float)0;
															if (137629 - 224572 != -86942)
															{
																goto Block_15;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_8:
				goto IL_4BC;
				Block_15:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_3CA:
				return this.Yield(3, new WaitForSeconds(12f));
				IL_4BC:
				IL_551:
				return false;
			}

			// Token: 0x06004075 RID: 16501 RVA: 0x00830E0C File Offset: 0x0082F00C
			internal static bool pUmLLx5MyO99KBWhRmZA()
			{
				return true;
			}

			// Token: 0x06004076 RID: 16502 RVA: 0x00830E10 File Offset: 0x0082F010
			internal static bool fOs1b05MSuQoYgm6vKhX()
			{
				return false;
			}

			// Token: 0x04004CC0 RID: 19648
			internal Vector3 $mPos$31041;

			// Token: 0x04004CC1 RID: 19649
			internal Vector3 $tDir$31042;

			// Token: 0x04004CC2 RID: 19650
			internal Ammonite $self_$31043;
		}
	}

	// Token: 0x02000B4E RID: 2894
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_hydroBlast$31047 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004077 RID: 16503 RVA: 0x00830E14 File Offset: 0x0082F014
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_hydroBlast$31047(Vector3 mPos, Vector3 tDir, int tID, Ammonite self_)
		{
			if (167183 - 474691 != -307507)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (169078 - 189860 == -20782)
				{
					base..ctor();
					if (253609 - 277876 == -24267)
					{
						this.$mPos$31053 = mPos;
						if (181932 - 32400 != 149533)
						{
							this.$tDir$31054 = tDir;
							if (158590 - 525698 != -367107)
							{
								this.$tID$31055 = tID;
								if (278445 - 483419 != -204973)
								{
									this.$self_$31056 = self_;
									if (247424 - 537938 != -290513)
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

		// Token: 0x06004078 RID: 16504 RVA: 0x00830F14 File Offset: 0x0082F114
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ammonite.$RPC_hydroBlast$31047.$(this.$mPos$31053, this.$tDir$31054, this.$tID$31055, this.$self_$31056);
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x00830F34 File Offset: 0x0082F134
		internal static bool HucFVL5MoEYFLY30J5XN()
		{
			return true;
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x00830F38 File Offset: 0x0082F138
		internal static bool PLfNEy5MExrIssAINtD6()
		{
			return false;
		}

		// Token: 0x04004CC3 RID: 19651
		internal Vector3 $mPos$31053;

		// Token: 0x04004CC4 RID: 19652
		internal Vector3 $tDir$31054;

		// Token: 0x04004CC5 RID: 19653
		internal int $tID$31055;

		// Token: 0x04004CC6 RID: 19654
		internal Ammonite $self_$31056;

		// Token: 0x02000B4F RID: 2895
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600407B RID: 16507 RVA: 0x00830F3C File Offset: 0x0082F13C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Ammonite self_)
			{
				if (201467 - 584158 != -382691)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (123034 - 361410 == -238376)
					{
						base..ctor();
						if (185861 - 73768 == 112093)
						{
							this.$mPos$31049 = mPos;
							if (269508 - 401883 != -132374)
							{
								this.$tDir$31050 = tDir;
								if (53829 - 74757 != -20927)
								{
									this.$tID$31051 = tID;
									if (183613 - 471590 != -287976)
									{
										this.$self_$31052 = self_;
										if (211023 - 222217 == -11194)
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

			// Token: 0x0600407C RID: 16508 RVA: 0x0083103C File Offset: 0x0082F23C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (173616 - 304879 != -131262)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_69F;
					case 2:
						if (this.$self_$31052.TcnyWadsR6.actionState != "attack")
						{
							goto IL_4DB;
						}
						if (210909 - 36567 == 174343)
						{
							continue;
						}
						if (this.$self_$31052.TcnyWadsR6.myCommand != "hydroBlast")
						{
							if (269320 - 358002 != -88682)
							{
								continue;
							}
							goto IL_4DB;
						}
						else
						{
							if (!this.$self_$31052.TcnyWadsR6.isMine)
							{
								goto IL_44;
							}
							if (160104 - 532344 == -372239)
							{
								continue;
							}
							if (this.$tID$31051 == 0)
							{
								goto IL_44;
							}
							if (123442 - 65297 != 58145)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$31051];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$31048 = (GameObject)obj2;
							if (133711 - 397590 != -263879)
							{
								continue;
							}
							if (!this.$tObject$31048)
							{
								goto IL_44;
							}
							if (141251 - 460891 == -319639)
							{
								continue;
							}
							this.$self_$31052.RPC_hydroBlast_fire(this.$tObject$31048.transform.position, this.$self_$31052.transform.forward, this.$tID$31051);
							if (278327 - 492587 == -214259)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_44;
							}
							if (220744 - 212932 == 7813)
							{
								continue;
							}
							this.$self_$31052.ActionEvent("RPC_hydroBlast_fire", this.$tObject$31048.transform.position, this.$self_$31052.transform.forward, this.$tID$31051);
							if (231360 - 327480 != -96120)
							{
								continue;
							}
							goto IL_44;
						}
						break;
					case 3:
						if (this.$self_$31052.TcnyWadsR6.actionState == "attack")
						{
							if (217629 - 53319 == 164311)
							{
								continue;
							}
							if (this.$self_$31052.TcnyWadsR6.myCommand == "hydroBlast")
							{
								if (112224 - 172816 == -60591)
								{
									continue;
								}
								this.$self_$31052.TcnyWadsR6.actionState = "standby";
								if (126755 - 107009 != 19746)
								{
									continue;
								}
								this.$self_$31052.TcnyWadsR6.actionTime = Time.time;
								if (61611 - 19702 != 41909)
								{
									continue;
								}
								this.$self_$31052.TcnyWadsR6.myCommand = "none";
								if (134471 - 524658 == -390186)
								{
									continue;
								}
								if (!this.$self_$31052.TcnyWadsR6.isMine)
								{
									if (55088 - 376088 != -321000)
									{
										continue;
									}
									this.$self_$31052.TcnyWadsR6.nPosition = this.$self_$31052.transform.position;
									if (89091 - 271639 != -182548)
									{
										continue;
									}
									this.$self_$31052.TcnyWadsR6.oPosition = this.$self_$31052.transform.position;
									if (204254 - 489249 == -284994)
									{
										continue;
									}
									this.$self_$31052.TcnyWadsR6.nDirection = this.$self_$31052.transform.forward;
									if (209246 - 158842 != 50404)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (115886 - 387039 != -271152)
						{
							goto Block_8;
						}
						continue;
					default:
						if (247698 - 298852 == -51153)
						{
							continue;
						}
						break;
					}
					this.$self_$31052.TcnyWadsR6.actionState = "attack";
					if (287537 - 492190 != -204652)
					{
						this.$self_$31052.TcnyWadsR6.actionTime = Time.time;
						if (11433 - 39255 == -27822)
						{
							this.$self_$31052.TcnyWadsR6.myCommand = "hydroBlast";
							if (113360 - 234890 == -121530)
							{
								this.$self_$31052.TcnyWadsR6.addTimeOut("hydroBlast", (float)9);
								if (229292 - 292207 == -62915)
								{
									this.$self_$31052.transform.position = this.$mPos$31049;
									if (140168 - 582850 == -442682)
									{
										this.$self_$31052.transform.LookAt(this.$mPos$31049 + global::Math.vFlat(this.$tDir$31050));
										if (102978 - 457049 == -354071)
										{
											this.$self_$31052.animation.Rewind();
											if (116651 - 476008 != -359356)
											{
												this.$self_$31052.animation.CrossFade("cast", 0.2f);
												if (283605 - 468244 != -184638)
												{
													this.$self_$31052.animation.wrapMode = WrapMode.Once;
													if (154801 - 232636 == -77835)
													{
														this.$self_$31052.TcnyWadsR6.vMovement = this.$self_$31052.transform.forward;
														if (261259 - 365840 == -104581)
														{
															this.$self_$31052.TcnyWadsR6.moveSpeed = (float)0;
															if (62334 - 232564 == -170230)
															{
																goto IL_3BE;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_44:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_8:
				goto IL_69F;
				IL_3BE:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_4DB:
				IL_69F:
				return false;
			}

			// Token: 0x0600407D RID: 16509 RVA: 0x008316FC File Offset: 0x0082F8FC
			internal static bool DGx7O15M2UGwEyR2fr02()
			{
				return true;
			}

			// Token: 0x0600407E RID: 16510 RVA: 0x00831700 File Offset: 0x0082F900
			internal static bool qaykTi5M8HVe2m02DMoP()
			{
				return false;
			}

			// Token: 0x04004CC7 RID: 19655
			internal GameObject $tObject$31048;

			// Token: 0x04004CC8 RID: 19656
			internal Vector3 $mPos$31049;

			// Token: 0x04004CC9 RID: 19657
			internal Vector3 $tDir$31050;

			// Token: 0x04004CCA RID: 19658
			internal int $tID$31051;

			// Token: 0x04004CCB RID: 19659
			internal Ammonite $self_$31052;
		}
	}

	// Token: 0x02000B50 RID: 2896
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rollingSmash$31057 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600407F RID: 16511 RVA: 0x00831704 File Offset: 0x0082F904
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rollingSmash$31057(Vector3 mPos, Vector3 tDir, Ammonite self_)
		{
			if (268528 - 522349 != -253820)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (253016 - 50029 == 202987)
				{
					base..ctor();
					if (93705 - 511663 != -417957)
					{
						this.$mPos$31067 = mPos;
						if (4481 - 594612 != -590130)
						{
							this.$tDir$31068 = tDir;
							if (274479 - 266546 != 7934)
							{
								this.$self_$31069 = self_;
								if (202788 - 335781 != -132992)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x008317E0 File Offset: 0x0082F9E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ammonite.$RPC_rollingSmash$31057.$(this.$mPos$31067, this.$tDir$31068, this.$self_$31069);
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x008317FC File Offset: 0x0082F9FC
		internal static bool kV6N715MZ82lEyf1xwe0()
		{
			return true;
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x00831800 File Offset: 0x0082FA00
		internal static bool QXJ7H95MCT0FvixXsMS7()
		{
			return false;
		}

		// Token: 0x04004CCC RID: 19660
		internal Vector3 $mPos$31067;

		// Token: 0x04004CCD RID: 19661
		internal Vector3 $tDir$31068;

		// Token: 0x04004CCE RID: 19662
		internal Ammonite $self_$31069;

		// Token: 0x02000B51 RID: 2897
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004083 RID: 16515 RVA: 0x00831804 File Offset: 0x0082FA04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Ammonite self_)
			{
				if (289624 - 460623 != -170999)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (208475 - 254862 == -46387)
					{
						base..ctor();
						if (220067 - 136537 == 83530)
						{
							this.$mPos$31064 = mPos;
							if (71595 - 497502 == -425907)
							{
								this.$tDir$31065 = tDir;
								if (167964 - 270386 == -102422)
								{
									this.$self_$31066 = self_;
									if (7002 - 95696 == -88694)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004084 RID: 16516 RVA: 0x008318E0 File Offset: 0x0082FAE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (292178 - 117002 != 175176)
				{
				}
				for (;;)
				{
					IL_563:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_99E;
					case 2:
						if (this.$self_$31066.TcnyWadsR6.actionState != "attack")
						{
							goto IL_6CA;
						}
						if (161809 - 416754 != -254945)
						{
							continue;
						}
						if (this.$self_$31066.TcnyWadsR6.myCommand != "rollingSmash")
						{
							if (171653 - 316811 != -145158)
							{
								continue;
							}
							goto IL_6CA;
						}
						else
						{
							this.$self_$31066.TcnyWadsR6.moveSpeed = (float)8;
							if (159107 - 464550 != -305443)
							{
								continue;
							}
							this.$i$31058 = 0;
							if (214776 - 62125 != 152652)
							{
								goto IL_79B;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31066.TcnyWadsR6.actionState != "attack")
						{
							goto IL_771;
						}
						if (129210 - 553641 == -424430)
						{
							continue;
						}
						if (this.$self_$31066.TcnyWadsR6.myCommand != "rollingSmash")
						{
							if (149365 - 7074 != 142291)
							{
								continue;
							}
							goto IL_771;
						}
						else
						{
							if (this.$i$31058 == 0)
							{
								if (82992 - 344932 == -261939)
								{
									continue;
								}
								this.$self_$31066.TcnyWadsR6.moveSpeed = (float)20;
								if (231352 - 46132 != 185220)
								{
									continue;
								}
							}
							if (this.$i$31058 == 4)
							{
								if (93812 - 468858 != -375046)
								{
									continue;
								}
								this.$self_$31066.TcnyWadsR6.moveSpeed = (float)0;
								if (296332 - 453589 != -157257)
								{
									continue;
								}
							}
							if (this.$self_$31066.TcnyWadsR6.isMine)
							{
								if (198950 - 380715 == -181764)
								{
									continue;
								}
								this.$hitLayer$31059 = 130816 - (1 << this.$self_$31066.gameObject.layer);
								if (73315 - 443833 == -370517)
								{
									continue;
								}
								this.$hitList$31060 = Damage.FindRecTarget(this.$self_$31066.transform.position, this.$self_$31066.transform.forward, (float)2, (float)2, (float)4, (float)3, this.$hitLayer$31059);
								if (4065 - 156450 != -152385)
								{
									continue;
								}
								this.$$iterator$10668$31063 = UnityRuntimeServices.GetEnumerator(this.$hitList$31060);
								if (287162 - 129278 == 157885)
								{
									continue;
								}
								while (this.$$iterator$10668$31063.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10668$31063.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$31061 = (GameObject)obj2;
									if (210669 - 63081 == 147589)
									{
										goto IL_563;
									}
									if (this.$self_$31066.TcnyWadsR6.hit(41, this.$hitObject$31061, this.$self_$31066.TcnyWadsR6.atk, 2, 0, this.$self_$31066.transform.forward) != 0)
									{
										if (98638 - 476092 == -377453)
										{
											goto IL_563;
										}
										this.$hitPos$31062 = this.$hitObject$31061.collider.bounds.center;
										if (23506 - 71085 != -47579)
										{
											goto IL_563;
										}
										UnityRuntimeServices.Update(this.$$iterator$10668$31063, this.$hitObject$31061);
										if (216400 - 498326 != -281926)
										{
											goto IL_563;
										}
										this.$self_$31066.RPC_nAttack_hit(this.$hitPos$31062, this.$self_$31066.transform.forward, 0);
										if (218524 - 171664 == 46861)
										{
											goto IL_563;
										}
										if (PhotonClient.IsInitialized())
										{
											if (122834 - 60327 == 62508)
											{
												goto IL_563;
											}
											this.$self_$31066.ActionEvent("RPC_nAttack_hit", this.$hitPos$31062, this.$self_$31066.transform.forward, 0);
											if (193282 - 154618 != 38664)
											{
												goto IL_563;
											}
										}
									}
								}
								if (264870 - 148295 != 116575)
								{
									continue;
								}
							}
							this.$i$31058++;
							if (220468 - 263037 != -42569)
							{
								continue;
							}
							goto IL_79B;
						}
						break;
					case 4:
						if (this.$self_$31066.TcnyWadsR6.actionState == "attack")
						{
							if (105111 - 60891 == 44221)
							{
								continue;
							}
							if (this.$self_$31066.TcnyWadsR6.myCommand == "rollingSmash")
							{
								if (97186 - 312428 != -215242)
								{
									continue;
								}
								this.$self_$31066.TcnyWadsR6.actionState = "standby";
								if (110472 - 285495 == -175022)
								{
									continue;
								}
								this.$self_$31066.TcnyWadsR6.actionTime = Time.time;
								if (18473 - 285169 != -266696)
								{
									continue;
								}
								this.$self_$31066.TcnyWadsR6.myCommand = "none";
								if (81231 - 206173 == -124941)
								{
									continue;
								}
								if (!this.$self_$31066.TcnyWadsR6.isMine)
								{
									if (77214 - 336388 == -259173)
									{
										continue;
									}
									this.$self_$31066.TcnyWadsR6.nPosition = this.$self_$31066.transform.position;
									if (143221 - 86823 == 56399)
									{
										continue;
									}
									this.$self_$31066.TcnyWadsR6.oPosition = this.$self_$31066.transform.position;
									if (71660 - 598630 != -526970)
									{
										continue;
									}
									this.$self_$31066.TcnyWadsR6.nDirection = this.$self_$31066.transform.forward;
									if (239749 - 461096 != -221347)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (238747 - 429415 != -190667)
						{
							goto Block_59;
						}
						continue;
					default:
						if (46966 - 177531 == -130564)
						{
							continue;
						}
						break;
					}
					this.$self_$31066.TcnyWadsR6.actionState = "attack";
					if (155562 - 31593 == 123970)
					{
						continue;
					}
					this.$self_$31066.TcnyWadsR6.actionTime = Time.time;
					if (146066 - 2763 != 143303)
					{
						continue;
					}
					this.$self_$31066.TcnyWadsR6.myCommand = "rollingSmash";
					if (288330 - 404923 != -116593)
					{
						continue;
					}
					this.$self_$31066.TcnyWadsR6.addTimeOut("rollingSmash", (float)24);
					if (197934 - 22935 != 174999)
					{
						continue;
					}
					this.$self_$31066.transform.position = this.$mPos$31064;
					if (143213 - 543754 != -400541)
					{
						continue;
					}
					this.$self_$31066.transform.LookAt(this.$mPos$31064 + global::Math.vFlat(this.$tDir$31065));
					if (50044 - 593841 != -543797)
					{
						continue;
					}
					this.$self_$31066.animation.Rewind();
					if (48615 - 377164 == -328548)
					{
						continue;
					}
					this.$self_$31066.animation.CrossFade("rollingSmash", 0.2f);
					if (35505 - 500730 != -465225)
					{
						continue;
					}
					this.$self_$31066.animation.wrapMode = WrapMode.Once;
					if (40881 - 224434 == -183552)
					{
						continue;
					}
					this.$self_$31066.TcnyWadsR6.vMovement = this.$self_$31066.transform.forward;
					if (136400 - 154014 != -17614)
					{
						continue;
					}
					this.$self_$31066.TcnyWadsR6.moveSpeed = (float)0;
					if (126759 - 114559 != 12201)
					{
						goto Block_15;
					}
					continue;
					IL_79B:
					if (this.$i$31058 < 5)
					{
						break;
					}
					if (56167 - 307160 != -250992)
					{
						goto Block_52;
					}
				}
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_15:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_6CA:
				IL_771:
				goto IL_99E;
				Block_52:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_59:
				IL_99E:
				return false;
			}

			// Token: 0x06004085 RID: 16517 RVA: 0x008322A0 File Offset: 0x008304A0
			internal static bool aKkb7U5MLC8URaCvsVSb()
			{
				return true;
			}

			// Token: 0x06004086 RID: 16518 RVA: 0x008322A4 File Offset: 0x008304A4
			internal static bool aSv4RW5MOpjutw6KqpgI()
			{
				return false;
			}

			// Token: 0x04004CCF RID: 19663
			internal int $i$31058;

			// Token: 0x04004CD0 RID: 19664
			internal int $hitLayer$31059;

			// Token: 0x04004CD1 RID: 19665
			internal UnityScript.Lang.Array $hitList$31060;

			// Token: 0x04004CD2 RID: 19666
			internal GameObject $hitObject$31061;

			// Token: 0x04004CD3 RID: 19667
			internal Vector3 $hitPos$31062;

			// Token: 0x04004CD4 RID: 19668
			internal IEnumerator $$iterator$10668$31063;

			// Token: 0x04004CD5 RID: 19669
			internal Vector3 $mPos$31064;

			// Token: 0x04004CD6 RID: 19670
			internal Vector3 $tDir$31065;

			// Token: 0x04004CD7 RID: 19671
			internal Ammonite $self_$31066;
		}
	}

	// Token: 0x02000B52 RID: 2898
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_summon$31070 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004087 RID: 16519 RVA: 0x008322A8 File Offset: 0x008304A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_summon$31070(Ammonite self_)
		{
			if (236286 - 422089 != -185802)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (9658 - 479552 == -469894)
				{
					base..ctor();
					if (183114 - 288208 == -105094)
					{
						this.$self_$31077 = self_;
						if (15670 - 301246 != -285575)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x00832340 File Offset: 0x00830540
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ammonite.$RPC_summon$31070.$(this.$self_$31077);
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x00832350 File Offset: 0x00830550
		internal static bool RMJlo55MmN7bWM4wBxNo()
		{
			return true;
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x00832354 File Offset: 0x00830554
		internal static bool tSMShO5MFqmEWuht17FF()
		{
			return false;
		}

		// Token: 0x04004CD8 RID: 19672
		internal Ammonite $self_$31077;

		// Token: 0x02000B53 RID: 2899
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600408B RID: 16523 RVA: 0x00832358 File Offset: 0x00830558
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Ammonite self_)
			{
				if (264315 - 128117 != 136198)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (17773 - 323594 != -305820)
					{
						base..ctor();
						if (48003 - 268445 == -220442)
						{
							this.$self_$31076 = self_;
							if (76080 - 513004 != -436923)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600408C RID: 16524 RVA: 0x008323F0 File Offset: 0x008305F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (22674 - 166546 != -143872)
				{
				}
				for (;;)
				{
					IL_1A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_605;
					case 2:
						if (this.$self_$31076.TcnyWadsR6.actionState == "attack")
						{
							if (13806 - 176782 != -162976)
							{
								continue;
							}
							if (this.$self_$31076.TcnyWadsR6.myCommand == "summon")
							{
								if (194075 - 557821 == -363745)
								{
									continue;
								}
								this.$self_$31076.TcnyWadsR6.actionState = "standby";
								if (260935 - 357923 != -96988)
								{
									continue;
								}
								this.$self_$31076.TcnyWadsR6.actionTime = Time.time;
								if (218821 - 128593 == 90229)
								{
									continue;
								}
								this.$self_$31076.TcnyWadsR6.myCommand = "none";
								if (200937 - 457819 == -256881)
								{
									continue;
								}
								this.$self_$31076.animation.Play("root");
								if (108557 - 181830 == -73272)
								{
									continue;
								}
								this.$self_$31076.animation.wrapMode = WrapMode.Loop;
								if (51320 - 225249 == -173928)
								{
									continue;
								}
								if (!this.$self_$31076.TcnyWadsR6.isMine)
								{
									if (72790 - 179246 != -106456)
									{
										continue;
									}
									this.$self_$31076.TcnyWadsR6.nPosition = this.$self_$31076.transform.position;
									if (142175 - 405730 != -263555)
									{
										continue;
									}
									this.$self_$31076.TcnyWadsR6.oPosition = this.$self_$31076.transform.position;
									if (236839 - 89873 == 146967)
									{
										continue;
									}
									this.$self_$31076.TcnyWadsR6.nDirection = this.$self_$31076.transform.forward;
									if (271817 - 596325 == -324507)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (191154 - 520526 != -329371)
						{
							goto Block_15;
						}
						continue;
					default:
						if (82540 - 372542 == -290001)
						{
							continue;
						}
						break;
					}
					this.$self_$31076.TcnyWadsR6.actionState = "attack";
					if (147724 - 152399 == -4675)
					{
						this.$self_$31076.TcnyWadsR6.actionTime = Time.time;
						if (205632 - 392700 != -187067)
						{
							this.$self_$31076.TcnyWadsR6.myCommand = "summon";
							if (92194 - 96291 == -4097)
							{
								this.$self_$31076.TcnyWadsR6.removeStatus("hide");
								if (221752 - 338814 == -117062)
								{
									this.$self_$31076.animation.Play("summon");
									if (203093 - 461789 != -258695)
									{
										this.$self_$31076.animation.wrapMode = WrapMode.Once;
										if (190000 - 289778 != -99777)
										{
											this.$self_$31076.TcnyWadsR6.vMovement = this.$self_$31076.transform.forward;
											if (148881 - 484480 == -335599)
											{
												this.$self_$31076.TcnyWadsR6.moveSpeed = (float)0;
												if (225653 - 530767 == -305114)
												{
													if (this.$self_$31076.summon)
													{
														if (103892 - 556068 != -452176)
														{
															continue;
														}
														UnityEngine.Object.Instantiate(this.$self_$31076.summon, this.$self_$31076.transform.position, Quaternion.identity);
														if (204417 - 476758 != -272341)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find summon Effect");
														if (110289 - 329562 == -219272)
														{
															continue;
														}
													}
													this.$mAmmniteRendererList$31071 = this.$self_$31076.gameObject.GetComponentsInChildren(typeof(Renderer));
													if (204630 - 58094 != 146537)
													{
														this.$$11456$31073 = 0;
														if (176194 - 470660 != -294465)
														{
															this.$$11457$31074 = this.$mAmmniteRendererList$31071;
															if (81380 - 662 == 80718)
															{
																this.$$11458$31075 = this.$$11457$31074.Length;
																if (55583 - 538786 != -483202)
																{
																	while (this.$$11456$31073 < this.$$11458$31075)
																	{
																		((Renderer)this.$$11457$31074[this.$$11456$31073]).enabled = true;
																		if (248841 - 320737 != -71896)
																		{
																			goto IL_1A;
																		}
																		this.$$11456$31073++;
																		if (104753 - 183751 == -78997)
																		{
																			goto IL_1A;
																		}
																	}
																	if (155679 - 453174 != -297494)
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
				return this.Yield(2, new WaitForSeconds(1f));
				Block_15:
				IL_605:
				return false;
			}

			// Token: 0x0600408D RID: 16525 RVA: 0x00832A14 File Offset: 0x00830C14
			internal static bool SeSMPo5MM86ueRMrn0aL()
			{
				return true;
			}

			// Token: 0x0600408E RID: 16526 RVA: 0x00832A18 File Offset: 0x00830C18
			internal static bool mGERJM5Mx6Vl2b1l8qH8()
			{
				return false;
			}

			// Token: 0x04004CD9 RID: 19673
			internal Component[] $mAmmniteRendererList$31071;

			// Token: 0x04004CDA RID: 19674
			internal Renderer $mAmmniteRendererer$31072;

			// Token: 0x04004CDB RID: 19675
			internal int $$11456$31073;

			// Token: 0x04004CDC RID: 19676
			internal Component[] $$11457$31074;

			// Token: 0x04004CDD RID: 19677
			internal int $$11458$31075;

			// Token: 0x04004CDE RID: 19678
			internal Ammonite $self_$31076;
		}
	}

	// Token: 0x02000B54 RID: 2900
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31078 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600408F RID: 16527 RVA: 0x00832A1C File Offset: 0x00830C1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31078(UnityScript.Lang.Array nArray, Ammonite self_)
		{
			if (290250 - 399549 != -109299)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (118705 - 528042 == -409337)
				{
					base..ctor();
					if (83613 - 296682 == -213069)
					{
						this.$nArray$31083 = nArray;
						if (31650 - 341354 == -309704)
						{
							this.$self_$31084 = self_;
							if (80321 - 183789 != -103467)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x00832AD8 File Offset: 0x00830CD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ammonite.$RPC_ko$31078.$(this.$nArray$31083, this.$self_$31084);
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x00832AEC File Offset: 0x00830CEC
		internal static bool qGVgQ15MgwnYXCWw6XsA()
		{
			return true;
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x00832AF0 File Offset: 0x00830CF0
		internal static bool Recx3A5MfKeEU2Vk0jJv()
		{
			return false;
		}

		// Token: 0x04004CDF RID: 19679
		internal UnityScript.Lang.Array $nArray$31083;

		// Token: 0x04004CE0 RID: 19680
		internal Ammonite $self_$31084;

		// Token: 0x02000B55 RID: 2901
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004093 RID: 16531 RVA: 0x00832AF4 File Offset: 0x00830CF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Ammonite self_)
			{
				if (3993 - 476996 != -473003)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (137935 - 124161 == 13774)
					{
						base..ctor();
						if (199181 - 282637 == -83456)
						{
							this.$nArray$31081 = nArray;
							if (146881 - 249022 == -102141)
							{
								this.$self_$31082 = self_;
								if (147612 - 423383 == -275771)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004094 RID: 16532 RVA: 0x00832BB0 File Offset: 0x00830DB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (97477 - 183512 != -86034)
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
						if (this.$self_$31082.TcnyWadsR6.actionState != "ko")
						{
							if (243773 - 54859 != 188915)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$self_$31082.animation.Play("getUp");
							if (103694 - 377876 == -274181)
							{
								continue;
							}
							this.$self_$31082.animation.wrapMode = WrapMode.Once;
							if (22946 - 397459 != -374513)
							{
								continue;
							}
							goto IL_1D4;
						}
						break;
					case 3:
						if (this.$self_$31082.TcnyWadsR6.actionState != "ko")
						{
							if (56111 - 363066 != -306955)
							{
								continue;
							}
							goto IL_3EE;
						}
						else
						{
							this.$self_$31082.TcnyWadsR6.actionState = "standby";
							if (53291 - 37486 != 15805)
							{
								continue;
							}
							this.$self_$31082.TcnyWadsR6.actionTime = Time.time;
							if (257175 - 140090 != 117085)
							{
								continue;
							}
							this.$self_$31082.TcnyWadsR6.myCommand = "none";
							if (112872 - 70295 != 42577)
							{
								continue;
							}
							this.$self_$31082.TcnyWadsR6.ko = this.$self_$31082.TcnyWadsR6.mko;
							if (202564 - 164999 == 37566)
							{
								continue;
							}
							this.YieldDefault(1);
							if (39288 - 212649 != -173361)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (252581 - 579120 != -326539)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31082.TcnyWadsR6.actionState == "ko")
					{
						break;
					}
					if (194564 - 136285 == 58279)
					{
						if (this.$self_$31082.TcnyWadsR6.actionState == "dead")
						{
							if (96027 - 481515 != -385487)
							{
								break;
							}
						}
						else
						{
							this.$mPos$31079 = (Vector3)this.$nArray$31081[0];
							if (53588 - 566695 == -513107)
							{
								this.$mDir$31080 = (Vector3)this.$nArray$31081[1];
								if (292327 - 3328 == 288999)
								{
									this.$self_$31082.TcnyWadsR6.ko = 0;
									if (128981 - 19650 == 109331)
									{
										this.$self_$31082.TcnyWadsR6.actionState = "ko";
										if (279092 - 5289 != 273804)
										{
											this.$self_$31082.TcnyWadsR6.actionTime = Time.time;
											if (198410 - 4201 != 194210)
											{
												this.$self_$31082.TcnyWadsR6.myCommand = "none";
												if (57989 - 530440 != -472450)
												{
													this.$self_$31082.TcnyWadsR6.vMovement = Vector3.zero;
													if (96032 - 304261 == -208229)
													{
														this.$self_$31082.TcnyWadsR6.moveSpeed = (float)0;
														if (191952 - 242203 == -50251)
														{
															this.$self_$31082.animation.Play("ko");
															if (22 - 465772 != -465749)
															{
																this.$self_$31082.animation.wrapMode = WrapMode.Once;
																if (16814 - 94742 != -77927)
																{
																	goto Block_23;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_E3:
				goto IL_48C;
				IL_1D4:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_17:
				goto IL_E3;
				Block_23:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_3EE:
				IL_48C:
				return false;
			}

			// Token: 0x06004095 RID: 16533 RVA: 0x0083305C File Offset: 0x0083125C
			internal static bool OsCGl85MnRvhe5xvIfaa()
			{
				return true;
			}

			// Token: 0x06004096 RID: 16534 RVA: 0x00833060 File Offset: 0x00831260
			internal static bool KC0LcR5M6UGxj29pHrfg()
			{
				return false;
			}

			// Token: 0x04004CE1 RID: 19681
			internal Vector3 $mPos$31079;

			// Token: 0x04004CE2 RID: 19682
			internal Vector3 $mDir$31080;

			// Token: 0x04004CE3 RID: 19683
			internal UnityScript.Lang.Array $nArray$31081;

			// Token: 0x04004CE4 RID: 19684
			internal Ammonite $self_$31082;
		}
	}

	// Token: 0x02000B56 RID: 2902
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31085 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004097 RID: 16535 RVA: 0x00833064 File Offset: 0x00831264
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31085(UnityScript.Lang.Array nArray, Ammonite self_)
		{
			if (7991 - 263182 != -255190)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (102179 - 524832 == -422653)
				{
					base..ctor();
					if (114990 - 449423 == -334433)
					{
						this.$nArray$31090 = nArray;
						if (143506 - 542374 != -398867)
						{
							this.$self_$31091 = self_;
							if (159002 - 202782 != -43779)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x00833120 File Offset: 0x00831320
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ammonite.$RPC_dead$31085.$(this.$nArray$31090, this.$self_$31091);
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x00833134 File Offset: 0x00831334
		internal static bool SVOE0o5Mi23K6VmkfSJS()
		{
			return true;
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x00833138 File Offset: 0x00831338
		internal static bool q6TrUe5MK8PoMf2LqZAX()
		{
			return false;
		}

		// Token: 0x04004CE5 RID: 19685
		internal UnityScript.Lang.Array $nArray$31090;

		// Token: 0x04004CE6 RID: 19686
		internal Ammonite $self_$31091;

		// Token: 0x02000B57 RID: 2903
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600409B RID: 16539 RVA: 0x0083313C File Offset: 0x0083133C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Ammonite self_)
			{
				if (218901 - 170657 != 48244)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161648 - 256189 == -94541)
					{
						base..ctor();
						if (34015 - 39882 == -5867)
						{
							this.$nArray$31088 = nArray;
							if (37976 - 23407 != 14570)
							{
								this.$self_$31089 = self_;
								if (1632 - 225163 != -223530)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600409C RID: 16540 RVA: 0x008331F8 File Offset: 0x008313F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (203243 - 412277 != -209034)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_458;
					case 2:
						if (this.$self_$31089.TcnyWadsR6.actionState != "dead")
						{
							if (295949 - 383832 != -87883)
							{
								continue;
							}
							goto IL_3F5;
						}
						else
						{
							if (!this.$self_$31089.TcnyWadsR6.isPlayer)
							{
								if (236245 - 253553 != -17308)
								{
									continue;
								}
								if (Game.mGameCode != 406)
								{
									if (99871 - 206634 != -106763)
									{
										continue;
									}
									UnityEngine.Object.Destroy(this.$self_$31089.gameObject);
									if (236920 - 204095 == 32826)
									{
										continue;
									}
								}
							}
							else if (this.$self_$31089.TcnyWadsR6.isMine)
							{
								if (158423 - 103720 == 54704)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31089.gameObject);
								if (235533 - 483806 != -248273)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (17308 - 79504 != -62196)
							{
								continue;
							}
							goto IL_458;
						}
						break;
					default:
						if (272997 - 147193 != 125804)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31089.TcnyWadsR6.actionState == "dead")
					{
						if (21119 - 191358 == -170239)
						{
							break;
						}
					}
					else
					{
						this.$mPos$31086 = (Vector3)this.$nArray$31088[0];
						if (16909 - 113674 != -96764)
						{
							this.$myDirection$31087 = (Vector3)this.$nArray$31088[1];
							if (203575 - 480710 != -277134)
							{
								this.$self_$31089.transform.position = this.$mPos$31086;
								if (105308 - 168775 == -63467)
								{
									this.$self_$31089.transform.LookAt(this.$mPos$31086 + this.$myDirection$31087);
									if (213008 - 26532 != 186477)
									{
										this.$self_$31089.TcnyWadsR6.hp = 0;
										if (181586 - 30875 != 150712)
										{
											this.$self_$31089.TcnyWadsR6.actionState = "dead";
											if (200178 - 343054 == -142876)
											{
												this.$self_$31089.TcnyWadsR6.actionTime = Time.time;
												if (13325 - 107617 == -94292)
												{
													this.$self_$31089.TcnyWadsR6.myCommand = "none";
													if (24780 - 545888 != -521107)
													{
														this.$self_$31089.TcnyWadsR6.vMovement = Vector3.zero;
														if (291970 - 465938 == -173968)
														{
															this.$self_$31089.TcnyWadsR6.moveSpeed = (float)0;
															if (276020 - 140797 != 135224)
															{
																this.$self_$31089.animation.Rewind();
																if (154833 - 82646 == 72187)
																{
																	this.$self_$31089.animation.Play("ko");
																	if (85833 - 117639 == -31806)
																	{
																		this.$self_$31089.animation.wrapMode = WrapMode.Once;
																		if (177361 - 100041 != 77321)
																		{
																			goto Block_9;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_458;
				Block_9:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_3F5:
				IL_458:
				return false;
			}

			// Token: 0x0600409D RID: 16541 RVA: 0x00833670 File Offset: 0x00831870
			internal static bool BArJ375Md2SJ633MLoK4()
			{
				return true;
			}

			// Token: 0x0600409E RID: 16542 RVA: 0x00833674 File Offset: 0x00831874
			internal static bool l71kiS5MJ6rTCCOIp45o()
			{
				return false;
			}

			// Token: 0x04004CE7 RID: 19687
			internal Vector3 $mPos$31086;

			// Token: 0x04004CE8 RID: 19688
			internal Vector3 $myDirection$31087;

			// Token: 0x04004CE9 RID: 19689
			internal UnityScript.Lang.Array $nArray$31088;

			// Token: 0x04004CEA RID: 19690
			internal Ammonite $self_$31089;
		}
	}
}
