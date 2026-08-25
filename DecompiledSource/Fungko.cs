using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A43 RID: 2627
[Serializable]
public class Fungko : MonoBehaviour
{
	// Token: 0x06003986 RID: 14726 RVA: 0x00788EDC File Offset: 0x007870DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Fungko()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003987 RID: 14727 RVA: 0x00788EEC File Offset: 0x007870EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (4807 - 85900 != -81093)
		{
		}
		for (;;)
		{
			this.NxF9jfrV2T = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (233106 - 37762 == 195344)
			{
				this.NxF9jfrV2T.actionState = "standby";
				if (199771 - 139444 != 60328)
				{
					this.NxF9jfrV2T.actionTime = Time.time;
					if (13820 - 234414 == -220594)
					{
						this.NxF9jfrV2T.myCommand = "none";
						if (226224 - 344732 == -118508)
						{
							this.NxF9jfrV2T.hp = (this.NxF9jfrV2T.mhp = 740);
							if (12987 - 355159 == -342172)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003988 RID: 14728 RVA: 0x00789010 File Offset: 0x00787210
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.NxF9jfrV2T.isMine = true;
		}
	}

	// Token: 0x06003989 RID: 14729 RVA: 0x0078902C File Offset: 0x0078722C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (236843 - 489452 != -252608)
		{
		}
		for (;;)
		{
			if (this.NxF9jfrV2T.isControlled)
			{
				if (5927 - 47062 == -41134)
				{
					continue;
				}
				if (!(this.NxF9jfrV2T.actionState == "standby"))
				{
					if (212605 - 466732 == -254126)
					{
						continue;
					}
					if (!(this.NxF9jfrV2T.actionState == "run"))
					{
						goto IL_124;
					}
					if (101616 - 300826 == -199209)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (208261 - 193827 == 14435)
				{
					continue;
				}
			}
			IL_124:
			if (this.NxF9jfrV2T.hp > 0)
			{
				if (219489 - 413141 == -193651)
				{
					continue;
				}
				if (this.NxF9jfrV2T.ko > 0)
				{
					break;
				}
				if (248860 - 31805 == 217056)
				{
					continue;
				}
			}
			if (!(this.NxF9jfrV2T.actionState != "dead"))
			{
				break;
			}
			if (36687 - 95461 == -58774)
			{
				if (this.NxF9jfrV2T.isMine)
				{
					if (64986 - 217652 == -152666)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (270165 - 268720 == 1445)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (52994 - 373158 == -320164)
							{
								this.NxF9jfrV2T.DeadEvent();
								if (134917 - 363393 == -228476)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.NxF9jfrV2T.hp <= 0)
				{
					if (32223 - 226885 == -194662)
					{
						this.NxF9jfrV2T.hp = 1;
						if (220464 - 219219 == 1245)
						{
							break;
						}
					}
				}
				else
				{
					if (this.NxF9jfrV2T.ko > 0)
					{
						break;
					}
					if (105100 - 557645 != -452544)
					{
						this.NxF9jfrV2T.ko = 1;
						if (231476 - 525267 == -293791)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600398A RID: 14730 RVA: 0x00789318 File Offset: 0x00787518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (65727 - 10893 != 54835)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (202787 - 93620 != 109168)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (155192 - 275569 != -120376)
				{
					if (107523 - 407449 == -299926)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (267867 - 434411 == -166543)
							{
								continue;
							}
							v = 1;
							if (190035 - 537552 != -347517)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (282732 - 67625 != 215107)
							{
								continue;
							}
							v = -1;
							if (219111 - 199097 == 20015)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_buff")
						{
							if (250013 - 382871 != -132858)
							{
								continue;
							}
							v = 11;
							if (195328 - 414720 == -219391)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_debuff")
						{
							if (102778 - 301557 != -198779)
							{
								continue;
							}
							v = 12;
							if (201801 - 208893 != -7092)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (270633 - 548737 != -278104)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (201999 - 483409 == -281410)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (197968 - 596362 != -398393)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (16985 - 488899 != -471913)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (238029 - 129734 == 108295)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (47624 - 41193 != 6432)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (264914 - 497254 == -232340)
											{
												Hashtable hashtable = new Hashtable();
												if (132138 - 560671 != -428532)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (270889 - 318560 != -47670)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (91776 - 554457 == -462681)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (209493 - 286603 != -77109)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (189421 - 130594 != 58828)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (176158 - 98888 != 77271)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (159604 - 329930 == -170326)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (200961 - 420726 != -219764)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (58882 - 297909 != -239026)
																				{
																					PhotonClient.SendEvent(this.NxF9jfrV2T.ActorNr, 74, hashtable, true, true);
																					if (237030 - 1676 == 235354)
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

	// Token: 0x0600398B RID: 14731 RVA: 0x00789830 File Offset: 0x00787A30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (22522 - 176859 != -154337)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (119471 - 427128 == -307657)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (268352 - 53906 != 214447)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (67865 - 108069 != -40203)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (264778 - 343848 != -79069)
						{
							int num3 = num;
							if (34717 - 267856 != -233138)
							{
								if (num3 == 1)
								{
									if (109809 - 154804 != -44994)
									{
										if (this.NxF9jfrV2T.isMine)
										{
											break;
										}
										if (297114 - 7795 != 289320)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (140100 - 468502 != -328401)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (61330 - 96447 != -35116)
									{
										if (this.NxF9jfrV2T.isMine)
										{
											break;
										}
										if (137442 - 559258 == -421816)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (109366 - 254410 == -145044)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (10149 - 471170 != -461020)
									{
										if (this.NxF9jfrV2T.isMine)
										{
											break;
										}
										if (195067 - 542305 == -347238)
										{
											this.StartCoroutine_Auto(this.RPC_buff(vector, vector2, num2));
											if (145729 - 271428 != -125698)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (232022 - 227380 == 4642)
									{
										if (this.NxF9jfrV2T.isMine)
										{
											break;
										}
										if (109243 - 245423 != -136179)
										{
											this.StartCoroutine_Auto(this.RPC_debuff(vector, vector2, num2));
											if (40762 - 439457 != -398694)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (100330 - 121766 != -21435)
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

	// Token: 0x0600398C RID: 14732 RVA: 0x00789BBC File Offset: 0x00787DBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (192726 - 431540 != -238814)
		{
		}
		for (;;)
		{
			float num = this.NxF9jfrV2T.moveSpeed;
			if (141593 - 265442 == -123849)
			{
				float runSpeed = this.NxF9jfrV2T.runSpeed;
				if (153931 - 241083 != -87151)
				{
					Vector3 a = default(Vector3);
					if (289006 - 379849 != -90842)
					{
						Vector3 vector = Vector3.zero;
						if (277051 - 561843 != -284791)
						{
							float num2 = (float)0;
							if (160973 - 121148 == 39825)
							{
								if (this.NxF9jfrV2T.isMine)
								{
									if (180128 - 582001 == -401872)
									{
										continue;
									}
									if ((this.NxF9jfrV2T.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (184208 - 395646 == -211437)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (191879 - 433852 != -241973)
										{
											continue;
										}
										a.y = (float)0;
										if (52888 - 251686 == -198797)
										{
											continue;
										}
										a = a.normalized;
										if (154811 - 386406 == -231594)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (261243 - 308285 != -47042)
										{
											continue;
										}
										vector = vector.normalized;
										if (233363 - 271422 != -38059)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (77641 - 365718 != -288077)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (111534 - 51340 != 60194)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (79703 - 270822 != -191119)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (13471 - 196224 == -182752)
														{
															continue;
														}
														this.NxF9jfrV2T.actionState = "run";
														if (98966 - 395666 == -296699)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (45514 - 559804 == -514289)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (7522 - 354783 != -347261)
														{
															continue;
														}
														this.animation.Play("run");
														if (151115 - 518731 != -367616)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (241447 - 492599 != -251152)
														{
															continue;
														}
														goto IL_37;
													}
												}
											}
										}
										this.NxF9jfrV2T.actionState = "standby";
										if (33873 - 364700 != -330827)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (168899 - 420224 == -251324)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (88684 - 520706 != -432022)
											{
												continue;
											}
											num = (float)0;
											if (255024 - 598450 == -343425)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (16073 - 80116 == -64042)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (297415 - 174364 == 123052)
										{
											continue;
										}
									}
									IL_37:;
								}
								else
								{
									vector = global::Math.vFlat(this.NxF9jfrV2T.nPosition - this.transform.position);
									if (169067 - 113057 == 56011)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (43930 - 370676 == -326745)
									{
										continue;
									}
									if (this.NxF9jfrV2T.nSpeed != (float)0)
									{
										if (200326 - 250672 == -50345)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (241266 - 547634 != -306368)
											{
												continue;
											}
											this.transform.position = this.NxF9jfrV2T.nPosition;
											if (254848 - 74934 == 179915)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (33667 - 17170 != 16497)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (24282 - 522607 != -498325)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (32580 - 475529 == -442948)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.NxF9jfrV2T.nSpeed, (float)10 * Time.deltaTime);
												if (258467 - 411450 != -152983)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (65488 - 344653 == -279164)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (6669 - 83553 == -76883)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (150663 - 30026 != 120637)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (177150 - 374214 == -197063)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (237947 - 13155 != 224792)
											{
												continue;
											}
										}
										else if (Time.time > this.NxF9jfrV2T.nSpeed + 0.3f)
										{
											if (165546 - 86144 != 79402)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (141356 - 502386 != -361030)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (239012 - 178502 != 60510)
												{
													continue;
												}
												num = (float)0;
												if (92925 - 106752 == -13826)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.NxF9jfrV2T.nDirection);
											if (284965 - 529865 == -244899)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (271466 - 173062 != 98404)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (291037 - 101618 == 189420)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (34334 - 123211 != -88877)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (96562 - 107693 != -11131)
											{
												continue;
											}
											this.transform.position = this.NxF9jfrV2T.nPosition;
											if (134889 - 45633 != 89256)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (6576 - 412028 != -405452)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (79108 - 382867 == -303758)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (29939 - 205449 == -175509)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (90937 - 129476 == -38538)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (171673 - 42192 == 129482)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (53913 - 169184 != -115271)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (230472 - 540017 == -309544)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.NxF9jfrV2T.nDirection);
											if (269605 - 295674 != -26069)
											{
												continue;
											}
											num = (float)0;
											if (18693 - 243863 != -225170)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (280924 - 294798 == -13873)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (155410 - 407432 == -252021)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (89630 - 91527 != -1897)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (113024 - 481360 == -368335)
										{
											continue;
										}
									}
								}
								this.NxF9jfrV2T.vMovement = vector;
								if (206111 - 212367 == -6256)
								{
									this.NxF9jfrV2T.moveSpeed = num;
									if (227595 - 229525 == -1930)
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

	// Token: 0x0600398D RID: 14733 RVA: 0x0078A720 File Offset: 0x00788920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (85486 - 145446 != -59959)
		{
		}
		for (;;)
		{
			if (!this.NxF9jfrV2T.isMine)
			{
				if (268214 - 131404 != 136811)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (200662 - 178353 != 22310)
				{
					Vector3 vector = a - this.transform.position;
					if (227314 - 415485 == -188171)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (275299 - 540851 != -265551)
						{
							CharacterControl characterControl = null;
							if (56478 - 440431 != -383952 && 191353 - 68209 != 123145)
							{
								if (gameObject)
								{
									if (269001 - 21641 != 247360)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (1929 - 316268 != -314339)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (182350 - 416893 == -234542)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (292811 - 436649 != -143838)
									{
										continue;
									}
								}
								if (!(this.NxF9jfrV2T.actionState == "standby"))
								{
									if (5250 - 40649 != -35399)
									{
										continue;
									}
									if (!(this.NxF9jfrV2T.actionState == "run"))
									{
										break;
									}
									if (222976 - 231654 != -8678)
									{
										continue;
									}
								}
								if (this.NxF9jfrV2T.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (13727 - 362210 == -348483)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
									if (19595 - 404121 != -384525)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (202800 - 282381 != -79580)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (6784 - 515935 == -509151)
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

	// Token: 0x0600398E RID: 14734 RVA: 0x0078AA18 File Offset: 0x00788C18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (283709 - 48243 != 235466)
		{
		}
		for (;;)
		{
			if (!this.NxF9jfrV2T.isMine)
			{
				if (118869 - 216338 != -97468)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (227142 - 520914 == -293772)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (104840 - 134467 == -29627)
					{
						Vector3 vector2 = vector.normalized;
						if (13845 - 543491 == -529646)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (266636 - 257423 != 9214)
							{
								CharacterControl characterControl = null;
								if (14642 - 496108 == -481466)
								{
									int tID = 0;
									if (114176 - 357896 != -243719)
									{
										if (gameObject)
										{
											if (266301 - 566048 == -299746)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (72928 - 110532 != -37604)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (137516 - 352736 != -215220)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (114584 - 496375 != -381791)
											{
												continue;
											}
										}
										if (!(this.NxF9jfrV2T.actionState == "standby"))
										{
											if (143902 - 78029 == 65874)
											{
												continue;
											}
											if (!(this.NxF9jfrV2T.actionState == "run"))
											{
												break;
											}
											if (67085 - 65870 != 1215)
											{
												continue;
											}
										}
										if (this.NxF9jfrV2T.isTimeOut("cAttack") != (float)0)
										{
											if (201812 - 257696 != -55883)
											{
												Camera.main.SendMessage("newGameMessage", "Charge Attack TimeOut");
												if (121380 - 299600 == -178220)
												{
													break;
												}
											}
										}
										else if (!gameObject)
										{
											if (81977 - 309232 == -227255)
											{
												Camera.main.SendMessage("newGameMessage", "No target selected");
												if (201855 - 176805 != 25051)
												{
													break;
												}
											}
										}
										else if (gameObject.layer == this.gameObject.layer)
										{
											if (126353 - 466122 != -339768)
											{
												if (gameObject == this.gameObject)
												{
													if (229506 - 131464 != 98042)
													{
														continue;
													}
													vector2 = this.transform.forward;
													if (202870 - 403797 != -200927)
													{
														continue;
													}
												}
												this.StartCoroutine_Auto(this.RPC_buff(this.transform.position, vector2, tID));
												if (118835 - 88529 != 30307)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (3989 - 208503 == -204514)
													{
														this.ActionEvent("RPC_buff", this.transform.position, vector2, tID);
														if (34748 - 84515 != -49766)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_debuff(this.transform.position, vector2, tID));
											if (106403 - 264042 == -157639)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (85181 - 269681 != -184499)
												{
													this.ActionEvent("RPC_debuff", this.transform.position, vector2, tID);
													if (287236 - 144372 != 142865)
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

	// Token: 0x0600398F RID: 14735 RVA: 0x0078AED8 File Offset: 0x007890D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003990 RID: 14736 RVA: 0x0078AEDC File Offset: 0x007890DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Fungko.$RPC_nAttack$30077(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003991 RID: 14737 RVA: 0x0078AEEC File Offset: 0x007890EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (145237 - 70011 != 75226)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (221714 - 438274 != -216559)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (67378 - 46966 != 20413)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (227071 - 2222 != 224850)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003992 RID: 14738 RVA: 0x0078AFA4 File Offset: 0x007891A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_buff(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Fungko.$RPC_buff$30089(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06003993 RID: 14739 RVA: 0x0078AFB4 File Offset: 0x007891B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_debuff(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Fungko.$RPC_debuff$30104(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06003994 RID: 14740 RVA: 0x0078AFC4 File Offset: 0x007891C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Fungko.$RPC_dead$30119(nArray, this).GetEnumerator();
	}

	// Token: 0x06003995 RID: 14741 RVA: 0x0078AFD4 File Offset: 0x007891D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003996 RID: 14742 RVA: 0x0078AFD8 File Offset: 0x007891D8
	internal static bool pcVM2d5EqtYS2F7GhgWi()
	{
		return true;
	}

	// Token: 0x06003997 RID: 14743 RVA: 0x0078AFDC File Offset: 0x007891DC
	internal static bool ppnArl5E7CyEdBWwnPgO()
	{
		return false;
	}

	// Token: 0x040047D6 RID: 18390
	private CharacterControl NxF9jfrV2T;

	// Token: 0x040047D7 RID: 18391
	public GameObject nAttack_ring;

	// Token: 0x040047D8 RID: 18392
	public GameObject nAttack_hit;

	// Token: 0x040047D9 RID: 18393
	public GameObject buff_ring;

	// Token: 0x040047DA RID: 18394
	public GameObject debuff_ring;

	// Token: 0x040047DB RID: 18395
	public GameObject deadEffect;

	// Token: 0x02000A44 RID: 2628
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30077 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003998 RID: 14744 RVA: 0x0078AFE0 File Offset: 0x007891E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30077(Vector3 mPos, Vector3 tDir, Fungko self_)
		{
			if (223979 - 526498 != -302518)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (17458 - 432261 != -414802)
				{
					base..ctor();
					if (156333 - 386984 != -230650)
					{
						this.$mPos$30086 = mPos;
						if (74318 - 302435 != -228116)
						{
							this.$tDir$30087 = tDir;
							if (114997 - 12572 == 102425)
							{
								this.$self_$30088 = self_;
								if (110353 - 115497 == -5144)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x0078B0BC File Offset: 0x007892BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Fungko.$RPC_nAttack$30077.$(this.$mPos$30086, this.$tDir$30087, this.$self_$30088);
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x0078B0D8 File Offset: 0x007892D8
		internal static bool Npnvtx5EPGTa2b8MC82U()
		{
			return true;
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x0078B0DC File Offset: 0x007892DC
		internal static bool gIwMMo5E0QxEWHd8Uapp()
		{
			return false;
		}

		// Token: 0x040047DC RID: 18396
		internal Vector3 $mPos$30086;

		// Token: 0x040047DD RID: 18397
		internal Vector3 $tDir$30087;

		// Token: 0x040047DE RID: 18398
		internal Fungko $self_$30088;

		// Token: 0x02000A45 RID: 2629
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600399C RID: 14748 RVA: 0x0078B0E0 File Offset: 0x007892E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Fungko self_)
			{
				if (218367 - 173624 != 44743)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (90678 - 182899 != -92220)
					{
						base..ctor();
						if (123996 - 82471 == 41525)
						{
							this.$mPos$30083 = mPos;
							if (255617 - 486426 != -230808)
							{
								this.$tDir$30084 = tDir;
								if (147139 - 382256 != -235116)
								{
									this.$self_$30085 = self_;
									if (214425 - 419813 != -205387)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600399D RID: 14749 RVA: 0x0078B1BC File Offset: 0x007893BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (53667 - 454205 != -400537)
				{
				}
				for (;;)
				{
					IL_6F9:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_916;
					case 2:
						if (this.$self_$30085.NxF9jfrV2T.actionState != "attack")
						{
							goto IL_75E;
						}
						if (18061 - 487533 != -469472)
						{
							continue;
						}
						if (this.$self_$30085.NxF9jfrV2T.myCommand != "nAttack")
						{
							if (212705 - 580620 != -367914)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30085.NxF9jfrV2T.isMine)
							{
								goto IL_1A;
							}
							if (260140 - 282575 == -22434)
							{
								continue;
							}
							this.$hitLayer$30078 = 130816 - (1 << this.$self_$30085.gameObject.layer);
							if (281904 - 472575 == -190670)
							{
								continue;
							}
							this.$hitList$30079 = Damage.FindRecTarget(this.$self_$30085.transform.position, this.$self_$30085.transform.forward, (float)1, (float)1, (float)2, (float)3, this.$hitLayer$30078);
							if (286021 - 268498 == 17524)
							{
								continue;
							}
							this.$$iterator$10598$30082 = UnityRuntimeServices.GetEnumerator(this.$hitList$30079);
							if (69296 - 219760 != -150464)
							{
								continue;
							}
							while (this.$$iterator$10598$30082.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10598$30082.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30080 = (GameObject)obj2;
								if (105659 - 265629 == -159969)
								{
									goto IL_6F9;
								}
								if (this.$self_$30085.NxF9jfrV2T.hit(1, this.$hitObject$30080, this.$self_$30085.NxF9jfrV2T.atk, 2, 0, this.$self_$30085.transform.forward) != 0)
								{
									if (127579 - 289032 == -161452)
									{
										goto IL_6F9;
									}
									this.$hitPos$30081 = this.$hitObject$30080.collider.ClosestPointOnBounds(this.$self_$30085.transform.position + Vector3.up);
									if (66091 - 386178 != -320087)
									{
										goto IL_6F9;
									}
									UnityRuntimeServices.Update(this.$$iterator$10598$30082, this.$hitObject$30080);
									if (6542 - 45491 == -38948)
									{
										goto IL_6F9;
									}
									this.$self_$30085.RPC_nAttack_hit(this.$hitPos$30081, this.$self_$30085.transform.forward, 0);
									if (64777 - 357418 != -292641)
									{
										goto IL_6F9;
									}
									if (PhotonClient.IsInitialized())
									{
										if (168398 - 336755 != -168357)
										{
											goto IL_6F9;
										}
										this.$self_$30085.ActionEvent("RPC_nAttack_hit", this.$hitPos$30081, this.$self_$30085.transform.forward, 0);
										if (198574 - 445618 != -247044)
										{
											goto IL_6F9;
										}
									}
								}
							}
							if (243702 - 598487 != -354784)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30085.NxF9jfrV2T.actionState != "attack")
						{
							goto IL_501;
						}
						if (175897 - 575788 == -399890)
						{
							continue;
						}
						if (this.$self_$30085.NxF9jfrV2T.myCommand != "nAttack")
						{
							if (146326 - 77865 != 68461)
							{
								continue;
							}
							goto IL_501;
						}
						else
						{
							this.$self_$30085.NxF9jfrV2T.moveSpeed = (float)0;
							if (112346 - 486676 != -374330)
							{
								continue;
							}
							goto IL_8C7;
						}
						break;
					case 4:
						if (this.$self_$30085.NxF9jfrV2T.actionState == "attack")
						{
							if (267027 - 171072 == 95956)
							{
								continue;
							}
							if (this.$self_$30085.NxF9jfrV2T.myCommand == "nAttack")
							{
								if (45423 - 106606 != -61183)
								{
									continue;
								}
								this.$self_$30085.NxF9jfrV2T.actionState = "standby";
								if (291128 - 469481 != -178353)
								{
									continue;
								}
								this.$self_$30085.NxF9jfrV2T.actionTime = Time.time;
								if (173095 - 12011 == 161085)
								{
									continue;
								}
								this.$self_$30085.NxF9jfrV2T.myCommand = "none";
								if (272244 - 491052 != -218808)
								{
									continue;
								}
								if (!this.$self_$30085.NxF9jfrV2T.isMine)
								{
									if (268905 - 322740 == -53834)
									{
										continue;
									}
									this.$self_$30085.NxF9jfrV2T.nPosition = this.$self_$30085.transform.position;
									if (275023 - 423530 == -148506)
									{
										continue;
									}
									this.$self_$30085.NxF9jfrV2T.oPosition = this.$self_$30085.transform.position;
									if (297313 - 243889 != 53424)
									{
										continue;
									}
									this.$self_$30085.NxF9jfrV2T.nDirection = this.$self_$30085.transform.forward;
									if (119766 - 121631 == -1864)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (163691 - 276881 != -113189)
						{
							goto Block_13;
						}
						continue;
					default:
						if (135683 - 2739 != 132944)
						{
							continue;
						}
						break;
					}
					this.$self_$30085.NxF9jfrV2T.actionState = "attack";
					if (51713 - 66328 == -14615)
					{
						this.$self_$30085.NxF9jfrV2T.actionTime = Time.time;
						if (107011 - 264872 != -157860)
						{
							this.$self_$30085.NxF9jfrV2T.myCommand = "nAttack";
							if (119460 - 428883 != -309422)
							{
								this.$self_$30085.NxF9jfrV2T.addTimeOut("nAttack", (float)3);
								if (121998 - 319069 == -197071)
								{
									this.$self_$30085.transform.position = this.$mPos$30083;
									if (151583 - 115858 == 35725)
									{
										this.$self_$30085.transform.LookAt(this.$mPos$30083 + global::Math.vFlat(this.$tDir$30084));
										if (291566 - 429724 == -138158)
										{
											this.$self_$30085.animation.Play("nAttack");
											if (120368 - 564791 == -444423)
											{
												this.$self_$30085.animation.wrapMode = WrapMode.Once;
												if (263801 - 116972 == 146829)
												{
													this.$self_$30085.NxF9jfrV2T.vMovement = this.$self_$30085.transform.forward;
													if (246894 - 489174 != -242279)
													{
														this.$self_$30085.NxF9jfrV2T.moveSpeed = (float)0;
														if (223141 - 60939 == 162202)
														{
															if (this.$self_$30085.nAttack_ring)
															{
																if (104393 - 429501 != -325107)
																{
																	this.$self_$30085.NxF9jfrV2T.createEffect(this.$self_$30085.nAttack_ring, this.$self_$30085.transform.position, this.$self_$30085.transform.rotation);
																	if (74265 - 485219 == -410954)
																	{
																		goto IL_5C2;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_ring effect");
																if (154594 - 167860 != -13265)
																{
																	goto Block_37;
																}
															}
														}
													}
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
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_10:
				Block_13:
				goto IL_916;
				IL_4B2:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_501:
				goto IL_916;
				IL_5C2:
				Block_37:
				goto IL_4B2;
				Block_39:
				goto IL_1A;
				IL_75E:
				goto IL_916;
				IL_8C7:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_916:
				return false;
			}

			// Token: 0x0600399E RID: 14750 RVA: 0x0078BAF4 File Offset: 0x00789CF4
			internal static bool RPflug5EbRrfdrZSKqmI()
			{
				return true;
			}

			// Token: 0x0600399F RID: 14751 RVA: 0x0078BAF8 File Offset: 0x00789CF8
			internal static bool TiSHgl5Eu1693rll7Fqt()
			{
				return false;
			}

			// Token: 0x040047DF RID: 18399
			internal int $hitLayer$30078;

			// Token: 0x040047E0 RID: 18400
			internal UnityScript.Lang.Array $hitList$30079;

			// Token: 0x040047E1 RID: 18401
			internal GameObject $hitObject$30080;

			// Token: 0x040047E2 RID: 18402
			internal Vector3 $hitPos$30081;

			// Token: 0x040047E3 RID: 18403
			internal IEnumerator $$iterator$10598$30082;

			// Token: 0x040047E4 RID: 18404
			internal Vector3 $mPos$30083;

			// Token: 0x040047E5 RID: 18405
			internal Vector3 $tDir$30084;

			// Token: 0x040047E6 RID: 18406
			internal Fungko $self_$30085;
		}
	}

	// Token: 0x02000A46 RID: 2630
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_buff$30089 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060039A0 RID: 14752 RVA: 0x0078BAFC File Offset: 0x00789CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_buff$30089(Vector3 mPos, Vector3 tDir, int tID, Fungko self_)
		{
			if (132833 - 471009 != -338176)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (171449 - 104495 != 66955)
				{
					base..ctor();
					if (266347 - 74197 != 192151)
					{
						this.$mPos$30100 = mPos;
						if (198072 - 19235 == 178837)
						{
							this.$tDir$30101 = tDir;
							if (91041 - 484642 != -393600)
							{
								this.$tID$30102 = tID;
								if (124873 - 388396 != -263522)
								{
									this.$self_$30103 = self_;
									if (176117 - 326652 != -150534)
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

		// Token: 0x060039A1 RID: 14753 RVA: 0x0078BBFC File Offset: 0x00789DFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Fungko.$RPC_buff$30089.$(this.$mPos$30100, this.$tDir$30101, this.$tID$30102, this.$self_$30103);
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x0078BC1C File Offset: 0x00789E1C
		internal static bool zXA3KY5EIYJ3i0rGleeU()
		{
			return true;
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x0078BC20 File Offset: 0x00789E20
		internal static bool CihJwT5EBK4CyjsINJ7f()
		{
			return false;
		}

		// Token: 0x040047E7 RID: 18407
		internal Vector3 $mPos$30100;

		// Token: 0x040047E8 RID: 18408
		internal Vector3 $tDir$30101;

		// Token: 0x040047E9 RID: 18409
		internal int $tID$30102;

		// Token: 0x040047EA RID: 18410
		internal Fungko $self_$30103;

		// Token: 0x02000A47 RID: 2631
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060039A4 RID: 14756 RVA: 0x0078BC24 File Offset: 0x00789E24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Fungko self_)
			{
				if (70390 - 404744 != -334353)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (3749 - 427962 != -424212)
					{
						base..ctor();
						if (188564 - 136635 == 51929)
						{
							this.$mPos$30096 = mPos;
							if (197553 - 181642 != 15912)
							{
								this.$tDir$30097 = tDir;
								if (227548 - 477966 != -250417)
								{
									this.$tID$30098 = tID;
									if (39488 - 317893 == -278405)
									{
										this.$self_$30099 = self_;
										if (276632 - 224490 != 52143)
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

			// Token: 0x060039A5 RID: 14757 RVA: 0x0078BD24 File Offset: 0x00789F24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (297550 - 581112 != -283562)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_988;
					case 2:
						if (this.$self_$30099.NxF9jfrV2T.actionState != "attack")
						{
							goto IL_14D;
						}
						if (161458 - 144404 != 17054)
						{
							continue;
						}
						if (this.$self_$30099.NxF9jfrV2T.myCommand != "buff")
						{
							if (16028 - 443862 != -427834)
							{
								continue;
							}
							goto IL_14D;
						}
						else
						{
							if (!this.$self_$30099.NxF9jfrV2T.isMine)
							{
								goto IL_628;
							}
							if (159835 - 547577 == -387741)
							{
								continue;
							}
							this.$tObject$30090 = null;
							if (56681 - 367005 == -310323)
							{
								continue;
							}
							this.$tChar$30091 = null;
							if (110240 - 371298 == -261057)
							{
								continue;
							}
							if (this.$tID$30098 != 0)
							{
								if (123745 - 388348 != -264603)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30098];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$30090 = (GameObject)obj2;
								if (284674 - 220762 == 63913)
								{
									continue;
								}
							}
							if (this.$tObject$30090)
							{
								if (191460 - 116211 == 75250)
								{
									continue;
								}
								this.$tChar$30091 = (CharacterControl)this.$tObject$30090.GetComponent(typeof(CharacterControl));
								if (91808 - 541093 != -449285)
								{
									continue;
								}
							}
							if (!this.$tChar$30091)
							{
								goto IL_628;
							}
							if (185016 - 256327 == -71310)
							{
								continue;
							}
							this.$mBuffList$30092 = new UnityScript.Lang.Array(new object[]
							{
								"atkUp",
								"defUp",
								"boost",
								"bless",
								"enlarge"
							});
							if (80236 - 498265 == -418028)
							{
								continue;
							}
							this.$i$30093 = 0;
							if (12764 - 333656 != -320891)
							{
								goto IL_249;
							}
							continue;
						}
						break;
					case 3:
						this.$i$30093++;
						if (288096 - 408753 != -120657)
						{
							continue;
						}
						goto IL_249;
					case 4:
						if (this.$self_$30099.NxF9jfrV2T.actionState == "attack")
						{
							if (29800 - 497816 != -468016)
							{
								continue;
							}
							if (this.$self_$30099.NxF9jfrV2T.myCommand == "buff")
							{
								if (174182 - 530033 == -355850)
								{
									continue;
								}
								this.$self_$30099.NxF9jfrV2T.actionState = "standby";
								if (248006 - 195697 == 52310)
								{
									continue;
								}
								this.$self_$30099.NxF9jfrV2T.actionTime = Time.time;
								if (171600 - 183175 != -11575)
								{
									continue;
								}
								this.$self_$30099.NxF9jfrV2T.myCommand = "none";
								if (6075 - 530213 != -524138)
								{
									continue;
								}
								if (!this.$self_$30099.NxF9jfrV2T.isMine)
								{
									if (251678 - 400555 != -148877)
									{
										continue;
									}
									this.$self_$30099.NxF9jfrV2T.nPosition = this.$self_$30099.transform.position;
									if (169041 - 239414 != -70373)
									{
										continue;
									}
									this.$self_$30099.NxF9jfrV2T.oPosition = this.$self_$30099.transform.position;
									if (294139 - 355697 != -61558)
									{
										continue;
									}
									this.$self_$30099.NxF9jfrV2T.nDirection = this.$self_$30099.transform.forward;
									if (24328 - 42349 != -18021)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (215096 - 428198 != -213102)
						{
							continue;
						}
						goto IL_988;
					default:
						if (178520 - 81938 == 96583)
						{
							continue;
						}
						break;
					}
					this.$self_$30099.NxF9jfrV2T.actionState = "attack";
					if (202300 - 318474 == -116173)
					{
						continue;
					}
					this.$self_$30099.NxF9jfrV2T.actionTime = Time.time;
					if (88830 - 561764 == -472933)
					{
						continue;
					}
					this.$self_$30099.NxF9jfrV2T.myCommand = "buff";
					if (121526 - 163293 == -41766)
					{
						continue;
					}
					this.$self_$30099.NxF9jfrV2T.addTimeOut("cAttack", (float)5);
					if (245967 - 93921 != 152046)
					{
						continue;
					}
					this.$self_$30099.transform.position = this.$mPos$30096;
					if (127602 - 371049 == -243446)
					{
						continue;
					}
					this.$self_$30099.transform.LookAt(this.$mPos$30096 + global::Math.vFlat(this.$tDir$30097));
					if (262478 - 394268 == -131789)
					{
						continue;
					}
					this.$self_$30099.animation.Play("cast");
					if (259296 - 514243 != -254947)
					{
						continue;
					}
					this.$self_$30099.animation.wrapMode = WrapMode.Once;
					if (78509 - 447569 != -369060)
					{
						continue;
					}
					this.$self_$30099.NxF9jfrV2T.vMovement = this.$self_$30099.transform.forward;
					if (290032 - 150268 == 139765)
					{
						continue;
					}
					this.$self_$30099.NxF9jfrV2T.moveSpeed = (float)0;
					if (53113 - 109351 == -56237)
					{
						continue;
					}
					if (this.$self_$30099.buff_ring)
					{
						if (71830 - 315110 != -243280)
						{
							continue;
						}
						this.$self_$30099.NxF9jfrV2T.createEffect(this.$self_$30099.buff_ring, this.$self_$30099.transform.position, this.$self_$30099.transform.rotation);
						if (87410 - 101555 != -14145)
						{
							continue;
						}
						goto IL_8EE;
					}
					else
					{
						Debug.LogError("Missing buff_ring effect");
						if (274273 - 60214 != 214060)
						{
							goto Block_58;
						}
						continue;
					}
					IL_249:
					if (this.$i$30093 >= 3)
					{
						if (50523 - 230831 != -180307)
						{
							goto Block_16;
						}
					}
					else
					{
						this.$nBuff$30094 = UnityEngine.Random.Range(0, this.$mBuffList$30092.length);
						if (142754 - 202519 == -59765)
						{
							object obj4;
							object obj3 = obj4 = this.$mBuffList$30092[this.$nBuff$30094];
							if (!(obj3 is string))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(string));
							}
							this.$nBuffName$30095 = (string)obj4;
							if (168375 - 298188 != -129812)
							{
								if (this.$nBuffName$30095 == "atkUp")
								{
									goto IL_89F;
								}
								if (77093 - 448870 == -371776)
								{
									continue;
								}
								if (this.$nBuffName$30095 == "defUp")
								{
									if (86138 - 154899 != -68760)
									{
										goto IL_89F;
									}
									continue;
								}
								else
								{
									this.$tChar$30091.RPC_AddStatus(this.$nBuffName$30095, 4, this.$self_$30099.NxF9jfrV2T.chaAdjust(7), 0, this.$self_$30099.NxF9jfrV2T.ActorNr);
									if (254388 - 315388 != -61000)
									{
										continue;
									}
								}
								IL_122:
								this.$mBuffList$30092.RemoveAt(this.$nBuff$30094);
								if (171647 - 552041 != -380394)
								{
									continue;
								}
								goto IL_3FC;
								IL_89F:
								this.$tChar$30091.RPC_AddStatus(this.$nBuffName$30095, 4, this.$self_$30099.NxF9jfrV2T.chaAdjust(7), 80, this.$self_$30099.NxF9jfrV2T.ActorNr);
								if (117661 - 86790 == 30871)
								{
									goto IL_122;
								}
							}
						}
					}
				}
				IL_14D:
				goto IL_988;
				Block_16:
				goto IL_628;
				IL_3FC:
				return this.YieldDefault(3);
				IL_5AF:
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_628:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_8EE:
				Block_58:
				goto IL_5AF;
				IL_988:
				return false;
			}

			// Token: 0x060039A6 RID: 14758 RVA: 0x0078C6CC File Offset: 0x0078A8CC
			internal static bool vfPBsc5Ee6r5kJgTmp3J()
			{
				return true;
			}

			// Token: 0x060039A7 RID: 14759 RVA: 0x0078C6D0 File Offset: 0x0078A8D0
			internal static bool QkCbJK5Er9FE8xGc28Mj()
			{
				return false;
			}

			// Token: 0x040047EB RID: 18411
			internal GameObject $tObject$30090;

			// Token: 0x040047EC RID: 18412
			internal CharacterControl $tChar$30091;

			// Token: 0x040047ED RID: 18413
			internal UnityScript.Lang.Array $mBuffList$30092;

			// Token: 0x040047EE RID: 18414
			internal int $i$30093;

			// Token: 0x040047EF RID: 18415
			internal int $nBuff$30094;

			// Token: 0x040047F0 RID: 18416
			internal string $nBuffName$30095;

			// Token: 0x040047F1 RID: 18417
			internal Vector3 $mPos$30096;

			// Token: 0x040047F2 RID: 18418
			internal Vector3 $tDir$30097;

			// Token: 0x040047F3 RID: 18419
			internal int $tID$30098;

			// Token: 0x040047F4 RID: 18420
			internal Fungko $self_$30099;
		}
	}

	// Token: 0x02000A48 RID: 2632
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_debuff$30104 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060039A8 RID: 14760 RVA: 0x0078C6D4 File Offset: 0x0078A8D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_debuff$30104(Vector3 mPos, Vector3 tDir, int tID, Fungko self_)
		{
			if (190178 - 581266 != -391087)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (268215 - 35347 != 232869)
				{
					base..ctor();
					if (200566 - 174204 == 26362)
					{
						this.$mPos$30115 = mPos;
						if (70797 - 384639 == -313842)
						{
							this.$tDir$30116 = tDir;
							if (11201 - 287029 != -275827)
							{
								this.$tID$30117 = tID;
								if (136688 - 26252 != 110437)
								{
									this.$self_$30118 = self_;
									if (38395 - 174976 == -136581)
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

		// Token: 0x060039A9 RID: 14761 RVA: 0x0078C7D4 File Offset: 0x0078A9D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Fungko.$RPC_debuff$30104.$(this.$mPos$30115, this.$tDir$30116, this.$tID$30117, this.$self_$30118);
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x0078C7F4 File Offset: 0x0078A9F4
		internal static bool upHvNM5EjOL2IXZYev5V()
		{
			return true;
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x0078C7F8 File Offset: 0x0078A9F8
		internal static bool fJ1e1I5Eh5mpUKGRE5LN()
		{
			return false;
		}

		// Token: 0x040047F5 RID: 18421
		internal Vector3 $mPos$30115;

		// Token: 0x040047F6 RID: 18422
		internal Vector3 $tDir$30116;

		// Token: 0x040047F7 RID: 18423
		internal int $tID$30117;

		// Token: 0x040047F8 RID: 18424
		internal Fungko $self_$30118;

		// Token: 0x02000A49 RID: 2633
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060039AC RID: 14764 RVA: 0x0078C7FC File Offset: 0x0078A9FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Fungko self_)
			{
				if (33377 - 470010 != -436632)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (106785 - 366241 != -259455)
					{
						base..ctor();
						if (120244 - 452970 != -332725)
						{
							this.$mPos$30111 = mPos;
							if (229674 - 288904 != -59229)
							{
								this.$tDir$30112 = tDir;
								if (197978 - 306159 == -108181)
								{
									this.$tID$30113 = tID;
									if (215692 - 358560 == -142868)
									{
										this.$self_$30114 = self_;
										if (158677 - 176796 != -18118)
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

			// Token: 0x060039AD RID: 14765 RVA: 0x0078C8FC File Offset: 0x0078AAFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280426 - 376785 != -96359)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8E7;
					case 2:
						if (this.$self_$30114.NxF9jfrV2T.actionState != "attack")
						{
							goto IL_8B3;
						}
						if (125522 - 288639 != -163117)
						{
							continue;
						}
						if (this.$self_$30114.NxF9jfrV2T.myCommand != "debuff")
						{
							if (141411 - 573562 != -432151)
							{
								continue;
							}
							goto IL_8B3;
						}
						else
						{
							if (!this.$self_$30114.NxF9jfrV2T.isMine)
							{
								goto IL_434;
							}
							if (27536 - 116304 != -88768)
							{
								continue;
							}
							this.$tObject$30105 = null;
							if (203161 - 151199 == 51963)
							{
								continue;
							}
							this.$tChar$30106 = null;
							if (59441 - 273734 != -214293)
							{
								continue;
							}
							if (this.$tID$30113 != 0)
							{
								if (36897 - 536811 == -499913)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30113];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$30105 = (GameObject)obj2;
								if (210608 - 183505 != 27103)
								{
									continue;
								}
							}
							if (this.$tObject$30105)
							{
								if (123065 - 61743 != 61322)
								{
									continue;
								}
								this.$tChar$30106 = (CharacterControl)this.$tObject$30105.GetComponent(typeof(CharacterControl));
								if (267474 - 407567 == -140092)
								{
									continue;
								}
							}
							if (!this.$tChar$30106)
							{
								goto IL_434;
							}
							if (37128 - 33637 == 3492)
							{
								continue;
							}
							this.$mDebuffList$30107 = new UnityScript.Lang.Array(new object[]
							{
								"drunk",
								"confuse",
								"poison",
								"curse",
								"reduce"
							});
							if (147719 - 55332 != 92387)
							{
								continue;
							}
							this.$i$30108 = 0;
							if (108191 - 179263 != -71072)
							{
								continue;
							}
							goto IL_32A;
						}
						break;
					case 3:
						this.$i$30108++;
						if (137389 - 179202 != -41813)
						{
							continue;
						}
						goto IL_32A;
					case 4:
						if (this.$self_$30114.NxF9jfrV2T.actionState == "attack")
						{
							if (58700 - 349746 == -291045)
							{
								continue;
							}
							if (this.$self_$30114.NxF9jfrV2T.myCommand == "debuff")
							{
								if (163867 - 7805 != 156062)
								{
									continue;
								}
								this.$self_$30114.NxF9jfrV2T.actionState = "standby";
								if (236709 - 547488 == -310778)
								{
									continue;
								}
								this.$self_$30114.NxF9jfrV2T.actionTime = Time.time;
								if (54943 - 53038 == 1906)
								{
									continue;
								}
								this.$self_$30114.NxF9jfrV2T.myCommand = "none";
								if (127315 - 201714 == -74398)
								{
									continue;
								}
								if (!this.$self_$30114.NxF9jfrV2T.isMine)
								{
									if (257526 - 346110 == -88583)
									{
										continue;
									}
									this.$self_$30114.NxF9jfrV2T.nPosition = this.$self_$30114.transform.position;
									if (296642 - 102445 == 194198)
									{
										continue;
									}
									this.$self_$30114.NxF9jfrV2T.oPosition = this.$self_$30114.transform.position;
									if (8939 - 560256 != -551317)
									{
										continue;
									}
									this.$self_$30114.NxF9jfrV2T.nDirection = this.$self_$30114.transform.forward;
									if (106705 - 210982 == -104276)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (210288 - 357633 != -147345)
						{
							continue;
						}
						goto IL_8E7;
					default:
						if (79263 - 571123 != -491860)
						{
							continue;
						}
						break;
					}
					this.$self_$30114.NxF9jfrV2T.actionState = "attack";
					if (60213 - 251809 == -191595)
					{
						continue;
					}
					this.$self_$30114.NxF9jfrV2T.actionTime = Time.time;
					if (287667 - 469169 != -181502)
					{
						continue;
					}
					this.$self_$30114.NxF9jfrV2T.myCommand = "debuff";
					if (210418 - 322890 == -112471)
					{
						continue;
					}
					this.$self_$30114.NxF9jfrV2T.addTimeOut("cAttack", (float)5);
					if (19589 - 505389 == -485799)
					{
						continue;
					}
					this.$self_$30114.transform.position = this.$mPos$30111;
					if (249835 - 296052 == -46216)
					{
						continue;
					}
					this.$self_$30114.transform.LookAt(this.$mPos$30111 + global::Math.vFlat(this.$tDir$30112));
					if (198647 - 579519 != -380872)
					{
						continue;
					}
					this.$self_$30114.animation.Play("cast");
					if (48473 - 360495 == -312021)
					{
						continue;
					}
					this.$self_$30114.animation.wrapMode = WrapMode.Once;
					if (164250 - 181791 == -17540)
					{
						continue;
					}
					this.$self_$30114.NxF9jfrV2T.vMovement = this.$self_$30114.transform.forward;
					if (26731 - 496652 != -469921)
					{
						continue;
					}
					this.$self_$30114.NxF9jfrV2T.moveSpeed = (float)0;
					if (201299 - 451083 == -249783)
					{
						continue;
					}
					if (this.$self_$30114.debuff_ring)
					{
						if (247583 - 182774 == 64810)
						{
							continue;
						}
						this.$self_$30114.NxF9jfrV2T.createEffect(this.$self_$30114.debuff_ring, this.$self_$30114.transform.position, this.$self_$30114.transform.rotation);
						if (271505 - 71914 != 199592)
						{
							goto Block_38;
						}
						continue;
					}
					else
					{
						Debug.LogError("Missing debuff_ring effect");
						if (12319 - 347789 != -335470)
						{
							continue;
						}
						goto IL_66B;
					}
					IL_32A:
					if (this.$i$30108 >= 3)
					{
						if (9914 - 348789 == -338875)
						{
							break;
						}
					}
					else
					{
						this.$nDebuff$30109 = UnityEngine.Random.Range(0, this.$mDebuffList$30107.length);
						if (97604 - 358972 == -261368)
						{
							object obj4;
							object obj3 = obj4 = this.$mDebuffList$30107[this.$nDebuff$30109];
							if (!(obj3 is string))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(string));
							}
							this.$nDebuffName$30110 = (string)obj4;
							if (184794 - 370414 != -185619)
							{
								this.$tChar$30106.RPC_AddStatus(this.$nDebuffName$30110, 4, Damage.getDebuff((float)7, this.$self_$30114.NxF9jfrV2T.cha, this.$tChar$30106.cha), 0, this.$self_$30114.NxF9jfrV2T.ActorNr);
								if (265571 - 581938 != -316366)
								{
									this.$mDebuffList$30107.RemoveAt(this.$nDebuff$30109);
									if (102456 - 155765 != -53308)
									{
										goto Block_44;
									}
								}
							}
						}
					}
				}
				IL_434:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_38:
				IL_66B:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_44:
				return this.YieldDefault(3);
				IL_8B3:
				IL_8E7:
				return false;
			}

			// Token: 0x060039AE RID: 14766 RVA: 0x0078D204 File Offset: 0x0078B404
			internal static bool OgSnEN5EsUM0xa0ZZgyJ()
			{
				return true;
			}

			// Token: 0x060039AF RID: 14767 RVA: 0x0078D208 File Offset: 0x0078B408
			internal static bool ab78U95E9tbP7UkBeZjX()
			{
				return false;
			}

			// Token: 0x040047F9 RID: 18425
			internal GameObject $tObject$30105;

			// Token: 0x040047FA RID: 18426
			internal CharacterControl $tChar$30106;

			// Token: 0x040047FB RID: 18427
			internal UnityScript.Lang.Array $mDebuffList$30107;

			// Token: 0x040047FC RID: 18428
			internal int $i$30108;

			// Token: 0x040047FD RID: 18429
			internal int $nDebuff$30109;

			// Token: 0x040047FE RID: 18430
			internal string $nDebuffName$30110;

			// Token: 0x040047FF RID: 18431
			internal Vector3 $mPos$30111;

			// Token: 0x04004800 RID: 18432
			internal Vector3 $tDir$30112;

			// Token: 0x04004801 RID: 18433
			internal int $tID$30113;

			// Token: 0x04004802 RID: 18434
			internal Fungko $self_$30114;
		}
	}

	// Token: 0x02000A4A RID: 2634
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30119 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060039B0 RID: 14768 RVA: 0x0078D20C File Offset: 0x0078B40C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30119(UnityScript.Lang.Array nArray, Fungko self_)
		{
			if (8606 - 109483 != -100877)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227462 - 13579 == 213883)
				{
					base..ctor();
					if (70816 - 117139 == -46323)
					{
						this.$nArray$30124 = nArray;
						if (257968 - 338862 != -80893)
						{
							this.$self_$30125 = self_;
							if (145372 - 413676 != -268303)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x0078D2C8 File Offset: 0x0078B4C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Fungko.$RPC_dead$30119.$(this.$nArray$30124, this.$self_$30125);
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x0078D2DC File Offset: 0x0078B4DC
		internal static bool KR4hZm5E1YEc3ovyYFmE()
		{
			return true;
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x0078D2E0 File Offset: 0x0078B4E0
		internal static bool GJVebE5E4e3e39AOEFq6()
		{
			return false;
		}

		// Token: 0x04004803 RID: 18435
		internal UnityScript.Lang.Array $nArray$30124;

		// Token: 0x04004804 RID: 18436
		internal Fungko $self_$30125;

		// Token: 0x02000A4B RID: 2635
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060039B4 RID: 14772 RVA: 0x0078D2E4 File Offset: 0x0078B4E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Fungko self_)
			{
				if (290916 - 506490 != -215574)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (270 - 14121 != -13850)
					{
						base..ctor();
						if (117833 - 443668 != -325834)
						{
							this.$nArray$30122 = nArray;
							if (67400 - 122213 == -54813)
							{
								this.$self_$30123 = self_;
								if (133834 - 201297 == -67463)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060039B5 RID: 14773 RVA: 0x0078D3A0 File Offset: 0x0078B5A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (249085 - 423534 != -174449)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4D2;
					case 2:
						if (this.$self_$30123.deadEffect)
						{
							if (136858 - 477998 == -341139)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$30123.deadEffect, this.$self_$30123.transform.position, this.$self_$30123.transform.rotation);
							if (280362 - 493274 == -212911)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing deadEffect gameObject");
							if (215506 - 394649 != -179143)
							{
								continue;
							}
						}
						if (this.$self_$30123.NxF9jfrV2T.actionState != "dead")
						{
							if (90901 - 476539 != -385638)
							{
								continue;
							}
							goto IL_3E5;
						}
						else
						{
							if (!this.$self_$30123.NxF9jfrV2T.isPlayer)
							{
								if (202957 - 262127 == -59169)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$30123.gameObject);
								if (47085 - 6030 == 41056)
								{
									continue;
								}
							}
							else if (this.$self_$30123.NxF9jfrV2T.isMine)
							{
								if (273943 - 412622 != -138679)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30123.gameObject);
								if (193314 - 195802 == -2487)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (181716 - 337058 != -155342)
							{
								continue;
							}
							goto IL_4D2;
						}
						break;
					default:
						if (178544 - 91322 != 87222)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30123.NxF9jfrV2T.actionState == "dead")
					{
						if (60914 - 279241 != -218326)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30120 = (Vector3)this.$nArray$30122[0];
						if (22691 - 578885 == -556194)
						{
							this.$myDirection$30121 = (Vector3)this.$nArray$30122[1];
							if (283584 - 13620 == 269964)
							{
								this.$self_$30123.transform.position = this.$myPosition$30120;
								if (66268 - 91747 != -25478)
								{
									this.$self_$30123.transform.LookAt(this.$myPosition$30120 + this.$myDirection$30121);
									if (299534 - 382381 != -82846)
									{
										this.$self_$30123.NxF9jfrV2T.hp = 0;
										if (239124 - 528023 == -288899)
										{
											this.$self_$30123.NxF9jfrV2T.actionState = "dead";
											if (153684 - 87119 != 66566)
											{
												this.$self_$30123.NxF9jfrV2T.actionTime = Time.time;
												if (51447 - 334807 == -283360)
												{
													this.$self_$30123.NxF9jfrV2T.myCommand = "none";
													if (191836 - 446806 == -254970)
													{
														this.$self_$30123.NxF9jfrV2T.vMovement = Vector3.zero;
														if (196001 - 371066 == -175065)
														{
															this.$self_$30123.NxF9jfrV2T.moveSpeed = (float)0;
															if (92845 - 525134 != -432288)
															{
																this.$self_$30123.animation.Rewind();
																if (216262 - 86664 == 129598)
																{
																	this.$self_$30123.animation.Play("ko");
																	if (113303 - 300734 == -187431)
																	{
																		this.$self_$30123.animation.wrapMode = WrapMode.Once;
																		if (16215 - 39999 != -23783)
																		{
																			goto Block_21;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_4D2;
				Block_21:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_3E5:
				IL_4D2:
				return false;
			}

			// Token: 0x060039B6 RID: 14774 RVA: 0x0078D894 File Offset: 0x0078BA94
			internal static bool D23sa25EziSOrTD2AZJk()
			{
				return true;
			}

			// Token: 0x060039B7 RID: 14775 RVA: 0x0078D898 File Offset: 0x0078BA98
			internal static bool qJRosH52aprCNMUVwb5m()
			{
				return false;
			}

			// Token: 0x04004805 RID: 18437
			internal Vector3 $myPosition$30120;

			// Token: 0x04004806 RID: 18438
			internal Vector3 $myDirection$30121;

			// Token: 0x04004807 RID: 18439
			internal UnityScript.Lang.Array $nArray$30122;

			// Token: 0x04004808 RID: 18440
			internal Fungko $self_$30123;
		}
	}
}
