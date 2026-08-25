using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000322 RID: 802
[Serializable]
public class KingRodinia : MonoBehaviour
{
	// Token: 0x0600123B RID: 4667 RVA: 0x001CB248 File Offset: 0x001C9448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public KingRodinia()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600123C RID: 4668 RVA: 0x001CB258 File Offset: 0x001C9458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (71567 - 75518 != -3950)
		{
		}
		for (;;)
		{
			this.UUm60mej59 = this.transform;
			if (251598 - 289473 != -37874)
			{
				this.VvF68P3D6g = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (227567 - 303108 == -75541)
				{
					this.VvF68P3D6g.actionState = "standby";
					if (226431 - 310619 == -84188)
					{
						this.VvF68P3D6g.actionTime = Time.time;
						if (297460 - 584964 == -287504)
						{
							this.VvF68P3D6g.myCommand = "none";
							if (35363 - 176117 != -140753)
							{
								this.VvF68P3D6g.hp = (this.VvF68P3D6g.mhp = 151200);
								if (79133 - 127133 != -47999)
								{
									this.VvF68P3D6g.ko = (this.VvF68P3D6g.mko = 800);
									if (30895 - 260245 != -229349)
									{
										if (this.VvF68P3D6g)
										{
											if (151093 - 262659 != -111566)
											{
												continue;
											}
											this.VvF68P3D6g.mImmuneList = new UnityScript.Lang.Array(new object[]
											{
												"swallow",
												"paralysis",
												"needlePrison",
												"invisible",
												"petrify",
												"snowMan",
												"snowBall",
												"charm",
												"mindControl",
												"coma"
											});
											if (98905 - 381531 == -282625)
											{
												continue;
											}
										}
										if (Game.mGameCode == 938)
										{
											if (178399 - 598522 != -420122)
											{
												this.StartCoroutine_Auto(this.RPC_summon(this.transform.position, this.transform.forward, 0));
												if (178345 - 523187 != -344841)
												{
													break;
												}
											}
										}
										else
										{
											if (Game.mGameType != 99)
											{
												break;
											}
											if (107519 - 157385 == -49866)
											{
												this.VvF68P3D6g.isMine = true;
												if (127119 - 127242 != -122)
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

	// Token: 0x0600123D RID: 4669 RVA: 0x001CB540 File Offset: 0x001C9740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (3940 - 341665 != -337724)
		{
		}
		for (;;)
		{
			if (this.VvF68P3D6g.isControlled)
			{
				if (142354 - 367404 == -225049)
				{
					continue;
				}
				if (!(this.VvF68P3D6g.actionState == "standby"))
				{
					if (267352 - 193796 == 73557)
					{
						continue;
					}
					if (!(this.VvF68P3D6g.actionState == "run"))
					{
						goto IL_1A;
					}
					if (77031 - 439560 != -362529)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (47949 - 422157 != -374208)
				{
					continue;
				}
			}
			IL_1A:
			if (this.VvF68P3D6g.hp <= 0)
			{
				if (59123 - 184065 == -124941)
				{
					continue;
				}
				if (this.VvF68P3D6g.actionState != "dead")
				{
					if (276682 - 156652 == 120031)
					{
						continue;
					}
					if (this.VvF68P3D6g.isMine)
					{
						if (111408 - 234262 == -122853)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (191599 - 263857 != -72258)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (206923 - 544624 != -337701)
						{
							continue;
						}
						this.VvF68P3D6g.DeadEvent();
						if (30671 - 120009 != -89337)
						{
							break;
						}
						continue;
					}
					else
					{
						this.VvF68P3D6g.hp = 1;
						if (244746 - 401480 != -156733)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.VvF68P3D6g.hp <= 0)
			{
				break;
			}
			if (53014 - 113793 != -60778)
			{
				if (this.VvF68P3D6g.ko > 0)
				{
					break;
				}
				if (85553 - 330880 == -245327)
				{
					if (!(this.VvF68P3D6g.actionState != "ko"))
					{
						break;
					}
					if (261416 - 369046 == -107630)
					{
						if (!(this.VvF68P3D6g.actionState != "dead"))
						{
							break;
						}
						if (127895 - 102654 != 25242)
						{
							if (this.VvF68P3D6g.isMine)
							{
								if (126171 - 69881 != 56291)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (52217 - 45063 != 7155)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (249690 - 300451 == -50761)
										{
											this.VvF68P3D6g.KoEvent();
											if (73415 - 235274 != -161858)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.VvF68P3D6g.ko = 1;
								if (58345 - 77430 != -19084)
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

	// Token: 0x0600123E RID: 4670 RVA: 0x001CB938 File Offset: 0x001C9B38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (275105 - 469057 != -193952)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (177768 - 263605 != -85836)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (248880 - 496302 == -247422)
				{
					if (208848 - 228203 != -19354)
					{
						if (ActionName == "RPC_kingSmash")
						{
							if (191333 - 405418 != -214085)
							{
								continue;
							}
							v = 1;
							if (208708 - 139246 == 69463)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_kingFire")
						{
							if (142308 - 5259 == 137050)
							{
								continue;
							}
							v = 11;
							if (298504 - 585375 == -286870)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_kingGatling")
						{
							if (243353 - 586816 == -343462)
							{
								continue;
							}
							v = 21;
							if (105577 - 523404 == -417826)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_kingLight")
						{
							if (50981 - 481038 == -430056)
							{
								continue;
							}
							v = 31;
							if (161509 - 398439 != -236930)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_kingRay")
						{
							if (267231 - 591118 != -323887)
							{
								continue;
							}
							v = 41;
							if (123367 - 452935 == -329567)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (64896 - 258404 != -193508)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (214071 - 318587 == -104516)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (126429 - 435775 == -309346)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (30987 - 247646 != -216658)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (24400 - 310102 == -285702)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (10634 - 335389 == -324755)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (122003 - 581752 != -459748)
											{
												Hashtable hashtable = new Hashtable();
												if (138919 - 452205 == -313286)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (245166 - 593879 == -348713)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (260613 - 388896 == -128283)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (231884 - 13364 != 218521)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (94060 - 251910 == -157850)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (113430 - 105476 == 7954)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (41624 - 57566 == -15942)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (87105 - 185800 != -98694)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (92012 - 389109 != -297096)
																				{
																					PhotonClient.SendEvent(this.VvF68P3D6g.ActorNr, 74, hashtable, true, true);
																					if (182757 - 579421 == -396664)
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

	// Token: 0x0600123F RID: 4671 RVA: 0x001CBE9C File Offset: 0x001CA09C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (270409 - 93907 != 176503)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (210641 - 399229 == -188588)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (32145 - 194619 != -162473)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (275069 - 306958 != -31888)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (224056 - 363412 == -139356)
						{
							int num2 = num;
							if (275926 - 512948 == -237022)
							{
								if (num2 == 1)
								{
									if (15444 - 185848 != -170403)
									{
										if (this.VvF68P3D6g.isMine)
										{
											break;
										}
										if (280463 - 328783 != -48319)
										{
											this.StartCoroutine_Auto(this.RPC_kingSmash(mPos, tDir, tID));
											if (6311 - 174847 == -168536)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (155636 - 352735 == -197099)
									{
										if (this.VvF68P3D6g.isMine)
										{
											break;
										}
										if (54588 - 495208 != -440619)
										{
											this.StartCoroutine_Auto(this.RPC_kingFire(mPos, tDir, tID));
											if (99098 - 492823 != -393724)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 21)
								{
									if (100959 - 302906 != -201946)
									{
										if (this.VvF68P3D6g.isMine)
										{
											break;
										}
										if (272161 - 320667 != -48505)
										{
											this.StartCoroutine_Auto(this.RPC_kingGatling(mPos, tDir, tID));
											if (69565 - 90645 == -21080)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 31)
								{
									if (214229 - 249461 != -35231)
									{
										if (this.VvF68P3D6g.isMine)
										{
											break;
										}
										if (216801 - 279654 != -62852)
										{
											this.StartCoroutine_Auto(this.RPC_kingLight(mPos, tDir, tID));
											if (53463 - 343733 != -290269)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 41)
								{
									if (79222 - 350800 != -271577)
									{
										if (this.VvF68P3D6g.isMine)
										{
											break;
										}
										if (240989 - 216620 != 24370)
										{
											this.StartCoroutine_Auto(this.RPC_kingRay(mPos, tDir, tID));
											if (284113 - 60870 == 223243)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (206296 - 472830 != -266533)
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

	// Token: 0x06001240 RID: 4672 RVA: 0x001CC2AC File Offset: 0x001CA4AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (15765 - 546459 != -530693)
		{
		}
		for (;;)
		{
			this.VvF68P3D6g.actionState = "standby";
			if (101667 - 587846 == -486179)
			{
				this.animation.Play("root");
				if (204096 - 572937 != -368840)
				{
					this.animation.wrapMode = WrapMode.Loop;
					if (18871 - 568872 == -550001)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x001CC360 File Offset: 0x001CA560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (55279 - 167295 != -112016)
		{
		}
		for (;;)
		{
			if (!this.VvF68P3D6g.isMine)
			{
				if (263058 - 411485 != -148426)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (105995 - 252460 == -146465)
				{
					Vector3 vector = a - this.transform.position;
					if (167047 - 178161 != -11113)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (234148 - 55056 == 179092)
						{
							CharacterControl characterControl = null;
							if (208601 - 327 != 208275)
							{
								int tID = 0;
								if (290236 - 171278 == 118958)
								{
									if (gameObject)
									{
										if (178970 - 128778 == 50193)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (245995 - 332513 != -86518)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (87565 - 485758 == -398192)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (190470 - 77749 != 112721)
										{
											continue;
										}
									}
									if (!(this.VvF68P3D6g.actionState == "standby"))
									{
										if (240846 - 96764 != 144082)
										{
											continue;
										}
										if (!(this.VvF68P3D6g.actionState == "run"))
										{
											break;
										}
										if (173598 - 277046 == -103447)
										{
											continue;
										}
									}
									if (this.VvF68P3D6g.isTimeOut("kingSmash") == (float)0)
									{
										if (15420 - 300748 != -285327)
										{
											this.StartCoroutine_Auto(this.RPC_kingSmash(this.transform.position, this.transform.forward, tID));
											if (137650 - 142961 != -5310)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (112274 - 364479 != -252204)
												{
													this.ActionEvent("RPC_kingSmash", this.transform.position, this.transform.forward, tID);
													if (174744 - 444521 != -269776)
													{
														break;
													}
												}
											}
										}
									}
									else if (this.VvF68P3D6g.isTimeOut("kingFire") == (float)0)
									{
										if (159249 - 595644 != -436394)
										{
											this.StartCoroutine_Auto(this.RPC_kingFire(this.transform.position, this.transform.forward, tID));
											if (294084 - 210185 != 83900)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (28653 - 297856 == -269203)
												{
													this.ActionEvent("RPC_kingFire", this.transform.position, this.transform.forward, tID);
													if (271981 - 250756 != 21226)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										if (this.VvF68P3D6g.isTimeOut("kingLight") != (float)0)
										{
											break;
										}
										if (45776 - 273360 == -227584)
										{
											this.StartCoroutine_Auto(this.RPC_kingLight(this.transform.position, this.transform.forward, tID));
											if (122839 - 486797 == -363958)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (261016 - 83640 == 177376)
												{
													this.ActionEvent("RPC_kingLight", this.transform.position, this.transform.forward, tID);
													if (144688 - 289396 != -144707)
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

	// Token: 0x06001242 RID: 4674 RVA: 0x001CC81C File Offset: 0x001CAA1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (238350 - 281376 != -43025)
		{
		}
		for (;;)
		{
			if (!this.VvF68P3D6g.isMine)
			{
				if (196219 - 185457 != 10763)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (245487 - 565879 != -320391)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (92027 - 157497 == -65470)
					{
						Vector3 normalized = vector.normalized;
						if (39997 - 187668 != -147670)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (228970 - 557808 == -328838)
							{
								CharacterControl characterControl = null;
								if (126251 - 418952 != -292700)
								{
									int tID = 0;
									if (123803 - 534023 == -410220)
									{
										if (gameObject)
										{
											if (188230 - 532621 == -344390)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (181966 - 466093 != -284127)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (76836 - 525720 == -448883)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (21456 - 514384 != -492928)
											{
												continue;
											}
										}
										if (!(this.VvF68P3D6g.actionState == "standby"))
										{
											if (27564 - 290716 == -263151)
											{
												continue;
											}
											if (!(this.VvF68P3D6g.actionState == "run"))
											{
												break;
											}
											if (59998 - 33256 == 26743)
											{
												continue;
											}
										}
										if (this.VvF68P3D6g.isTimeOut("kingGatling") == (float)0)
										{
											if (75951 - 536907 != -460955)
											{
												this.StartCoroutine_Auto(this.RPC_kingGatling(this.transform.position, this.transform.forward, tID));
												if (277078 - 494384 != -217305)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (74904 - 201285 == -126381)
													{
														this.ActionEvent("RPC_kingGatling", this.transform.position, this.transform.forward, tID);
														if (42947 - 157781 == -114834)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											if (this.VvF68P3D6g.isTimeOut("kingRay") != (float)0)
											{
												break;
											}
											if (3519 - 52822 != -49302)
											{
												this.StartCoroutine_Auto(this.RPC_kingRay(this.transform.position, this.transform.forward, tID));
												if (20464 - 52763 == -32299)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (76906 - 537421 != -460514)
													{
														this.ActionEvent("RPC_kingRay", this.transform.position, this.transform.forward, tID);
														if (32830 - 221141 == -188311)
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

	// Token: 0x06001243 RID: 4675 RVA: 0x001CCC28 File Offset: 0x001CAE28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001244 RID: 4676 RVA: 0x001CCC2C File Offset: 0x001CAE2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_kingSmash(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingRodinia.$RPC_kingSmash$18409(this).GetEnumerator();
	}

	// Token: 0x06001245 RID: 4677 RVA: 0x001CCC3C File Offset: 0x001CAE3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_kingFire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingRodinia.$RPC_kingFire$18417(this).GetEnumerator();
	}

	// Token: 0x06001246 RID: 4678 RVA: 0x001CCC4C File Offset: 0x001CAE4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_kingGatling(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingRodinia.$RPC_kingGatling$18426(this).GetEnumerator();
	}

	// Token: 0x06001247 RID: 4679 RVA: 0x001CCC5C File Offset: 0x001CAE5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_kingLight(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingRodinia.$RPC_kingLight$18434(this).GetEnumerator();
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x001CCC6C File Offset: 0x001CAE6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_kingRay(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingRodinia.$RPC_kingRay$18442(this).GetEnumerator();
	}

	// Token: 0x06001249 RID: 4681 RVA: 0x001CCC7C File Offset: 0x001CAE7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void showKingRayCount()
	{
		if (86295 - 21102 != 65194)
		{
		}
		for (;;)
		{
			int num = (int)this.VvF68P3D6g.getTimeOut("kingRay");
			if (298327 - 400572 != -102244)
			{
				Camera.main.SendMessage("newGameMessage", num + "seconds to King's Ray");
				if (228517 - 396737 == -168220)
				{
					Chat.SubmitChat("none", num + "seconds to King's Ray", eChatType.system, eChatMode.system);
					if (274346 - 101106 != 173241)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600124A RID: 4682 RVA: 0x001CCD50 File Offset: 0x001CAF50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_summon(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingRodinia.$RPC_summon$18452(this).GetEnumerator();
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x001CCD60 File Offset: 0x001CAF60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new KingRodinia.$RPC_ko$18457(nArray, this).GetEnumerator();
	}

	// Token: 0x0600124C RID: 4684 RVA: 0x001CCD70 File Offset: 0x001CAF70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new KingRodinia.$RPC_dead$18464(nArray, this).GetEnumerator();
	}

	// Token: 0x0600124D RID: 4685 RVA: 0x001CCD80 File Offset: 0x001CAF80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x001CCD84 File Offset: 0x001CAF84
	internal static bool NI4sJLZeu6sslaJT4Xf()
	{
		return true;
	}

	// Token: 0x0600124F RID: 4687 RVA: 0x001CCD88 File Offset: 0x001CAF88
	internal static bool EwariCZrmviliGsQpXT()
	{
		return false;
	}

	// Token: 0x04000FE8 RID: 4072
	private Transform UUm60mej59;

	// Token: 0x04000FE9 RID: 4073
	private CharacterControl VvF68P3D6g;

	// Token: 0x04000FEA RID: 4074
	public GameObject kingSmash_ring;

	// Token: 0x04000FEB RID: 4075
	public GameObject kingSmash_hit;

	// Token: 0x04000FEC RID: 4076
	public GameObject kingFire_ring;

	// Token: 0x04000FED RID: 4077
	public GameObject kingFire_fire;

	// Token: 0x04000FEE RID: 4078
	public GameObject kingGatling_ring;

	// Token: 0x04000FEF RID: 4079
	public GameObject kingGatling_fire;

	// Token: 0x04000FF0 RID: 4080
	public GameObject kingLight_ring;

	// Token: 0x04000FF1 RID: 4081
	public GameObject kingLight_hit;

	// Token: 0x04000FF2 RID: 4082
	public GameObject kingRay_ring;

	// Token: 0x04000FF3 RID: 4083
	public GameObject summon_ring;

	// Token: 0x04000FF4 RID: 4084
	public GameObject ko_ring;

	// Token: 0x04000FF5 RID: 4085
	public GameObject dead_ring;

	// Token: 0x02000323 RID: 803
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_kingSmash$18409 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001250 RID: 4688 RVA: 0x001CCD8C File Offset: 0x001CAF8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_kingSmash$18409(KingRodinia self_)
		{
			if (184171 - 126853 != 57318)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (254789 - 5564 == 249225)
				{
					base..ctor();
					if (90621 - 472622 == -382001)
					{
						this.$self_$18416 = self_;
						if (280050 - 16519 != 263532)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x001CCE24 File Offset: 0x001CB024
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingRodinia.$RPC_kingSmash$18409.$(this.$self_$18416);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x001CCE34 File Offset: 0x001CB034
		internal static bool DjI5QCZjqmbHlvPZNaP()
		{
			return true;
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x001CCE38 File Offset: 0x001CB038
		internal static bool lO2NojZhwYHXVcF5sId()
		{
			return false;
		}

		// Token: 0x04000FF6 RID: 4086
		internal KingRodinia $self_$18416;

		// Token: 0x02000324 RID: 804
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001254 RID: 4692 RVA: 0x001CCE3C File Offset: 0x001CB03C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(KingRodinia self_)
			{
				if (10766 - 259153 != -248387)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (51783 - 388639 == -336856)
					{
						base..ctor();
						if (120112 - 471770 != -351657)
						{
							this.$self_$18415 = self_;
							if (142491 - 539327 == -396836)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06001255 RID: 4693 RVA: 0x001CCED4 File Offset: 0x001CB0D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (76023 - 22912 != 53111)
				{
				}
				for (;;)
				{
					IL_894:
					switch (this._state)
					{
					case 0:
						goto IL_2EC;
					case 1:
						goto IL_959;
					case 2:
						if (this.$self_$18415.VvF68P3D6g.actionState != "attack")
						{
							goto IL_770;
						}
						if (147833 - 70551 != 77282)
						{
							continue;
						}
						if (this.$self_$18415.VvF68P3D6g.myCommand != "kingSmash")
						{
							if (229289 - 325067 != -95777)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							if (this.$self_$18415.kingSmash_hit)
							{
								if (126598 - 541336 == -414737)
								{
									continue;
								}
								this.$self_$18415.VvF68P3D6g.createEffect(this.$self_$18415.kingSmash_hit, this.$self_$18415.transform.position, this.$self_$18415.transform.rotation);
								if (283731 - 376264 != -92533)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing kingSmash_hit effect");
								if (125345 - 244463 != -119118)
								{
									continue;
								}
							}
							if (this.$self_$18415.VvF68P3D6g.isMine)
							{
								if (27214 - 481140 != -453926)
								{
									continue;
								}
								this.$hitLayer$18410 = 130816 - (1 << this.$self_$18415.gameObject.layer);
								if (292578 - 95446 != 197132)
								{
									continue;
								}
								this.$hitList$18411 = Damage.FindAreaTarget(this.$self_$18415.transform.position, (float)200, (float)20, this.$hitLayer$18410);
								if (198635 - 14865 != 183770)
								{
									continue;
								}
								this.$$iterator$10468$18413 = UnityRuntimeServices.GetEnumerator(this.$hitList$18411);
								if (283055 - 215633 != 67422)
								{
									continue;
								}
								while (this.$$iterator$10468$18413.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10468$18413.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$18412 = (GameObject)obj2;
									if (71674 - 356671 != -284997)
									{
										goto IL_894;
									}
									this.$self_$18415.VvF68P3D6g.hit(1, this.$hitObject$18412, 2 * this.$self_$18415.VvF68P3D6g.atk, 10, 0, 0.3f * Vector3.up);
									if (212672 - 460073 != -247401)
									{
										goto IL_894;
									}
									UnityRuntimeServices.Update(this.$$iterator$10468$18413, this.$hitObject$18412);
									if (113137 - 29121 == 84017)
									{
										goto IL_894;
									}
								}
								if (158517 - 445029 != -286512)
								{
									continue;
								}
							}
							this.$i$18414 = 0;
							if (177640 - 123297 != 54343)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$18415.VvF68P3D6g.actionState != "attack")
						{
							goto IL_4E3;
						}
						if (298775 - 450726 == -151950)
						{
							continue;
						}
						if (this.$self_$18415.VvF68P3D6g.myCommand != "kingSmash")
						{
							if (293307 - 376856 != -83548)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$i$18414++;
							if (177187 - 142042 == 35146)
							{
								continue;
							}
						}
						break;
					case 4:
						this.$self_$18415.showKingRayCount();
						if (20941 - 192666 != -171725)
						{
							continue;
						}
						if (this.$self_$18415.VvF68P3D6g.actionState == "attack")
						{
							if (281980 - 47950 == 234031)
							{
								continue;
							}
							if (this.$self_$18415.VvF68P3D6g.myCommand == "kingSmash")
							{
								if (135069 - 299600 != -164531)
								{
									continue;
								}
								this.$self_$18415.VvF68P3D6g.actionState = "standby";
								if (259502 - 441522 != -182020)
								{
									continue;
								}
								this.$self_$18415.VvF68P3D6g.actionTime = Time.time;
								if (225679 - 353705 == -128025)
								{
									continue;
								}
								this.$self_$18415.VvF68P3D6g.myCommand = "none";
								if (172725 - 562861 == -390135)
								{
									continue;
								}
								if (!this.$self_$18415.VvF68P3D6g.isMine)
								{
									if (16645 - 448573 == -431927)
									{
										continue;
									}
									this.$self_$18415.VvF68P3D6g.nPosition = this.$self_$18415.transform.position;
									if (45457 - 325401 == -279943)
									{
										continue;
									}
									this.$self_$18415.VvF68P3D6g.oPosition = this.$self_$18415.transform.position;
									if (143767 - 33037 == 110731)
									{
										continue;
									}
									this.$self_$18415.VvF68P3D6g.nDirection = this.$self_$18415.transform.forward;
									if (28130 - 41277 == -13146)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (52380 - 141339 != -88959)
						{
							continue;
						}
						goto IL_959;
					default:
						if (133645 - 483891 != -350246)
						{
							continue;
						}
						goto IL_2EC;
					}
					if (this.$i$18414 >= 2)
					{
						if (123803 - 242590 != -118787)
						{
							continue;
						}
						break;
					}
					else
					{
						Camera.main.SendMessage("AddCamereShake", 2);
						if (230417 - 530956 != -300539)
						{
							continue;
						}
						goto IL_6E8;
					}
					IL_2EC:
					this.$self_$18415.VvF68P3D6g.actionState = "attack";
					if (15041 - 84802 == -69761)
					{
						this.$self_$18415.VvF68P3D6g.actionTime = Time.time;
						if (146260 - 521962 != -375701)
						{
							this.$self_$18415.VvF68P3D6g.myCommand = "kingSmash";
							if (139317 - 269473 == -130156)
							{
								this.$self_$18415.VvF68P3D6g.addTimeOut("kingSmash", (float)UnityEngine.Random.Range(12, 15));
								if (293002 - 370422 != -77419)
								{
									this.$self_$18415.animation.CrossFade("kingSmash", 0.2f);
									if (168404 - 183185 != -14780)
									{
										this.$self_$18415.animation.wrapMode = WrapMode.Once;
										if (114492 - 181732 == -67240)
										{
											this.$self_$18415.VvF68P3D6g.vMovement = this.$self_$18415.transform.forward;
											if (234641 - 120866 != 113776)
											{
												this.$self_$18415.VvF68P3D6g.moveSpeed = (float)0;
												if (187689 - 432883 != -245193)
												{
													Camera.main.SendMessage("newGameMessage", "King Rodiania is using King's Smash");
													if (107697 - 414655 != -306957)
													{
														Chat.SubmitChat("none", "King Rodiania is using King's Smash", eChatType.system, eChatMode.system);
														if (256820 - 429585 == -172765)
														{
															if (this.$self_$18415.kingSmash_ring)
															{
																if (90337 - 408059 != -317721)
																{
																	this.$self_$18415.VvF68P3D6g.createEffect(this.$self_$18415.kingSmash_ring, this.$self_$18415.transform.position, this.$self_$18415.transform.rotation);
																	if (15356 - 575745 != -560388)
																	{
																		goto Block_28;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing kingSmash_ring effect");
																if (247807 - 23491 == 224316)
																{
																	goto IL_673;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(4, new WaitForSeconds(2.6f));
				Block_18:
				goto IL_4E3;
				Block_28:
				goto IL_673;
				IL_4E3:
				Block_35:
				goto IL_770;
				IL_673:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_6E8:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_770:
				IL_959:
				return false;
			}

			// Token: 0x06001256 RID: 4694 RVA: 0x001CD84C File Offset: 0x001CBA4C
			internal static bool LlTbdIZsNB7eCWwYDJy()
			{
				return true;
			}

			// Token: 0x06001257 RID: 4695 RVA: 0x001CD850 File Offset: 0x001CBA50
			internal static bool qV52fQZ9FxM5ANvthgD()
			{
				return false;
			}

			// Token: 0x04000FF7 RID: 4087
			internal int $hitLayer$18410;

			// Token: 0x04000FF8 RID: 4088
			internal UnityScript.Lang.Array $hitList$18411;

			// Token: 0x04000FF9 RID: 4089
			internal GameObject $hitObject$18412;

			// Token: 0x04000FFA RID: 4090
			internal IEnumerator $$iterator$10468$18413;

			// Token: 0x04000FFB RID: 4091
			internal int $i$18414;

			// Token: 0x04000FFC RID: 4092
			internal KingRodinia $self_$18415;
		}
	}

	// Token: 0x02000325 RID: 805
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_kingFire$18417 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001258 RID: 4696 RVA: 0x001CD854 File Offset: 0x001CBA54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_kingFire$18417(KingRodinia self_)
		{
			if (130100 - 135492 != -5392)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (36041 - 204295 != -168253)
				{
					base..ctor();
					if (91070 - 207762 != -116691)
					{
						this.$self_$18425 = self_;
						if (236318 - 115671 != 120648)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x001CD8EC File Offset: 0x001CBAEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingRodinia.$RPC_kingFire$18417.$(this.$self_$18425);
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x001CD8FC File Offset: 0x001CBAFC
		internal static bool H5upnPZ1S5xxBWLbU8X()
		{
			return true;
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x001CD900 File Offset: 0x001CBB00
		internal static bool IOJFnnZ49nQdZIuPbXN()
		{
			return false;
		}

		// Token: 0x04000FFD RID: 4093
		internal KingRodinia $self_$18425;

		// Token: 0x02000326 RID: 806
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600125C RID: 4700 RVA: 0x001CD904 File Offset: 0x001CBB04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(KingRodinia self_)
			{
				if (43211 - 514595 != -471383)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (117039 - 440087 != -323047)
					{
						base..ctor();
						if (4286 - 366639 != -362352)
						{
							this.$self_$18424 = self_;
							if (84832 - 19795 != 65038)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600125D RID: 4701 RVA: 0x001CD99C File Offset: 0x001CBB9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150118 - 185116 != -34997)
				{
				}
				for (;;)
				{
					IL_288:
					switch (this._state)
					{
					case 0:
						goto IL_757;
					case 1:
						goto IL_979;
					case 2:
						if (this.$self_$18424.VvF68P3D6g.actionState != "attack")
						{
							goto IL_7FE;
						}
						if (287089 - 16280 == 270810)
						{
							continue;
						}
						if (this.$self_$18424.VvF68P3D6g.myCommand != "kingFire")
						{
							if (33191 - 122953 != -89762)
							{
								continue;
							}
							goto IL_7FE;
						}
						else
						{
							if (this.$self_$18424.kingFire_fire)
							{
								if (161650 - 5204 != 156446)
								{
									continue;
								}
								this.$self_$18424.VvF68P3D6g.createEffect(this.$self_$18424.kingFire_fire, this.$self_$18424.transform.position, this.$self_$18424.transform.rotation);
								if (191419 - 384160 != -192741)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing kingFire_fire effect");
								if (84143 - 90663 == -6519)
								{
									continue;
								}
							}
							this.$i$18418 = 0;
							if (38360 - 28197 != 10163)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$18424.VvF68P3D6g.actionState != "attack")
						{
							goto IL_CC;
						}
						if (77952 - 7560 != 70392)
						{
							continue;
						}
						if (this.$self_$18424.VvF68P3D6g.myCommand != "kingFire")
						{
							if (35040 - 279809 != -244769)
							{
								continue;
							}
							goto IL_CC;
						}
						else
						{
							this.$i$18418++;
							if (37254 - 127189 != -89935)
							{
								continue;
							}
						}
						break;
					case 4:
						this.$self_$18424.showKingRayCount();
						if (37143 - 91808 == -54664)
						{
							continue;
						}
						if (this.$self_$18424.VvF68P3D6g.actionState == "attack")
						{
							if (116262 - 554319 != -438057)
							{
								continue;
							}
							if (this.$self_$18424.VvF68P3D6g.myCommand == "kingFire")
							{
								if (141980 - 425116 != -283136)
								{
									continue;
								}
								this.$self_$18424.VvF68P3D6g.actionState = "standby";
								if (190898 - 362907 == -172008)
								{
									continue;
								}
								this.$self_$18424.VvF68P3D6g.actionTime = Time.time;
								if (71603 - 407369 == -335765)
								{
									continue;
								}
								this.$self_$18424.VvF68P3D6g.myCommand = "none";
								if (151312 - 268271 != -116959)
								{
									continue;
								}
								if (!this.$self_$18424.VvF68P3D6g.isMine)
								{
									if (219808 - 480448 != -260640)
									{
										continue;
									}
									this.$self_$18424.VvF68P3D6g.nPosition = this.$self_$18424.transform.position;
									if (186674 - 401132 == -214457)
									{
										continue;
									}
									this.$self_$18424.VvF68P3D6g.oPosition = this.$self_$18424.transform.position;
									if (113185 - 379790 != -266605)
									{
										continue;
									}
									this.$self_$18424.VvF68P3D6g.nDirection = this.$self_$18424.transform.forward;
									if (6218 - 474442 == -468223)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (226358 - 415767 != -189408)
						{
							goto Block_9;
						}
						continue;
					default:
						if (118094 - 102008 != 16087)
						{
							goto IL_757;
						}
						continue;
					}
					if (this.$i$18418 >= 10)
					{
						if (74272 - 271797 != -197524)
						{
							goto Block_8;
						}
						continue;
					}
					else
					{
						if (!this.$self_$18424.VvF68P3D6g.isMine)
						{
							goto IL_20E;
						}
						if (6975 - 586509 == -579533)
						{
							continue;
						}
						this.$hitLayer$18419 = 130816 - (1 << this.$self_$18424.gameObject.layer);
						if (288368 - 255432 != 32936)
						{
							continue;
						}
						this.$hitList$18420 = Damage.FindAreaTarget(this.$self_$18424.transform.position, (float)200, (float)20, this.$hitLayer$18419);
						if (131358 - 72139 == 59220)
						{
							continue;
						}
						this.$$iterator$10469$18423 = UnityRuntimeServices.GetEnumerator(this.$hitList$18420);
						if (98841 - 360841 != -262000)
						{
							continue;
						}
						while (this.$$iterator$10469$18423.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10469$18423.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$18421 = (GameObject)obj2;
							if (127678 - 587647 != -459969)
							{
								goto IL_288;
							}
							this.$hitChar$18422 = (CharacterControl)this.$hitObject$18421.GetComponent(typeof(CharacterControl));
							if (1103 - 570881 != -569778)
							{
								goto IL_288;
							}
							UnityRuntimeServices.Update(this.$$iterator$10469$18423, this.$hitObject$18421);
							if (239882 - 175787 != 64095)
							{
								goto IL_288;
							}
							if (this.$hitChar$18422)
							{
								if (129118 - 139011 == -9892)
								{
									goto IL_288;
								}
								this.$hitChar$18422.RPC_AddEffectDamage(21, 100, 0, 0, Vector3.zero, this.$self_$18424.VvF68P3D6g.ActorNr);
								if (288091 - 543925 == -255833)
								{
									goto IL_288;
								}
							}
						}
						if (158610 - 450078 != -291468)
						{
							continue;
						}
						goto IL_20E;
					}
					IL_757:
					this.$self_$18424.VvF68P3D6g.actionState = "attack";
					if (191421 - 581205 == -389784)
					{
						this.$self_$18424.VvF68P3D6g.actionTime = Time.time;
						if (227617 - 388721 == -161104)
						{
							this.$self_$18424.VvF68P3D6g.myCommand = "kingFire";
							if (152280 - 373692 == -221412)
							{
								this.$self_$18424.VvF68P3D6g.addTimeOut("kingFire", (float)UnityEngine.Random.Range(24, 30));
								if (265262 - 567988 == -302726)
								{
									this.$self_$18424.animation.CrossFade("kingFire", 0.2f);
									if (198109 - 338642 == -140533)
									{
										this.$self_$18424.animation.wrapMode = WrapMode.Once;
										if (261093 - 61585 == 199508)
										{
											this.$self_$18424.VvF68P3D6g.vMovement = this.$self_$18424.transform.forward;
											if (22619 - 395020 != -372400)
											{
												this.$self_$18424.VvF68P3D6g.moveSpeed = (float)0;
												if (87135 - 121246 == -34111)
												{
													Camera.main.SendMessage("newGameMessage", "King Rodiania is using King's Fire");
													if (198235 - 138882 == 59353)
													{
														Chat.SubmitChat("none", "King Rodiania is using King's Fire", eChatType.system, eChatMode.system);
														if (266074 - 8774 == 257300)
														{
															if (this.$self_$18424.kingFire_ring)
															{
																if (281785 - 273947 != 7839)
																{
																	this.$self_$18424.VvF68P3D6g.createEffect(this.$self_$18424.kingFire_ring, this.$self_$18424.transform.position, this.$self_$18424.transform.rotation);
																	if (282524 - 393209 == -110685)
																	{
																		goto IL_694;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing kingFire_ring effect");
																if (195166 - 537897 == -342731)
																{
																	goto IL_8FB;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_CC:
				goto IL_979;
				Block_8:
				return this.Yield(4, new WaitForSeconds(2f));
				Block_9:
				goto IL_979;
				IL_20E:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_694:
				goto IL_8FB;
				IL_7FE:
				goto IL_979;
				IL_8FB:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_979:
				return false;
			}

			// Token: 0x0600125E RID: 4702 RVA: 0x001CE334 File Offset: 0x001CC534
			internal static bool hSWBrZZzvOiEdpybg7D()
			{
				return true;
			}

			// Token: 0x0600125F RID: 4703 RVA: 0x001CE338 File Offset: 0x001CC538
			internal static bool INhQyFCaBfGLTusWaxf()
			{
				return false;
			}

			// Token: 0x04000FFE RID: 4094
			internal int $i$18418;

			// Token: 0x04000FFF RID: 4095
			internal int $hitLayer$18419;

			// Token: 0x04001000 RID: 4096
			internal UnityScript.Lang.Array $hitList$18420;

			// Token: 0x04001001 RID: 4097
			internal GameObject $hitObject$18421;

			// Token: 0x04001002 RID: 4098
			internal CharacterControl $hitChar$18422;

			// Token: 0x04001003 RID: 4099
			internal IEnumerator $$iterator$10469$18423;

			// Token: 0x04001004 RID: 4100
			internal KingRodinia $self_$18424;
		}
	}

	// Token: 0x02000327 RID: 807
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_kingGatling$18426 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001260 RID: 4704 RVA: 0x001CE33C File Offset: 0x001CC53C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_kingGatling$18426(KingRodinia self_)
		{
			if (225421 - 556773 != -331351)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (297416 - 519526 != -222109)
				{
					base..ctor();
					if (99627 - 576152 != -476524)
					{
						this.$self_$18433 = self_;
						if (70239 - 265959 != -195719)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x001CE3D4 File Offset: 0x001CC5D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingRodinia.$RPC_kingGatling$18426.$(this.$self_$18433);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x001CE3E4 File Offset: 0x001CC5E4
		internal static bool WYeeRbC5mNmkWOIP6Pp()
		{
			return true;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x001CE3E8 File Offset: 0x001CC5E8
		internal static bool lm42cgCpvHNPa2rYoYQ()
		{
			return false;
		}

		// Token: 0x04001005 RID: 4101
		internal KingRodinia $self_$18433;

		// Token: 0x02000328 RID: 808
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001264 RID: 4708 RVA: 0x001CE3EC File Offset: 0x001CC5EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(KingRodinia self_)
			{
				if (44581 - 52758 != -8177)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (143084 - 25866 == 117218)
					{
						base..ctor();
						if (218280 - 18885 != 199396)
						{
							this.$self_$18432 = self_;
							if (62793 - 410213 != -347419)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06001265 RID: 4709 RVA: 0x001CE484 File Offset: 0x001CC684
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (290002 - 107612 != 182390)
				{
				}
				for (;;)
				{
					IL_149:
					switch (this._state)
					{
					case 0:
						goto IL_7C0;
					case 1:
						goto IL_91E;
					case 2:
						if (this.$self_$18432.VvF68P3D6g.actionState != "attack")
						{
							goto IL_2AA;
						}
						if (257951 - 272794 == -14842)
						{
							continue;
						}
						if (this.$self_$18432.VvF68P3D6g.myCommand != "kingGatling")
						{
							if (214308 - 357719 != -143410)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							if (this.$self_$18432.kingGatling_fire)
							{
								if (42485 - 341758 != -299273)
								{
									continue;
								}
								this.$self_$18432.VvF68P3D6g.createEffect(this.$self_$18432.kingGatling_fire, this.$self_$18432.transform.position, this.$self_$18432.transform.rotation);
								if (1269 - 105421 == -104151)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing kingGatling_fire effect");
								if (274425 - 151759 == 122667)
								{
									continue;
								}
							}
							this.$hitLayer$18427 = 130816 - (1 << this.$self_$18432.gameObject.layer);
							if (536 - 306704 != -306168)
							{
								continue;
							}
							this.$hitList$18428 = Damage.FindAreaTarget(this.$self_$18432.transform.position, (float)200, (float)20, this.$hitLayer$18427);
							if (122123 - 458834 != -336711)
							{
								continue;
							}
							this.$i$18429 = 0;
							if (275448 - 118583 != 156865)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$18432.VvF68P3D6g.actionState != "attack")
						{
							goto IL_AA;
						}
						if (163103 - 433676 != -270573)
						{
							continue;
						}
						if (this.$self_$18432.VvF68P3D6g.myCommand != "kingGatling")
						{
							if (180152 - 225343 != -45190)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							this.$i$18429++;
							if (276234 - 385294 != -109060)
							{
								continue;
							}
						}
						break;
					case 4:
						this.$self_$18432.showKingRayCount();
						if (185565 - 83045 == 102521)
						{
							continue;
						}
						if (this.$self_$18432.VvF68P3D6g.actionState == "attack")
						{
							if (224629 - 550313 != -325684)
							{
								continue;
							}
							if (this.$self_$18432.VvF68P3D6g.myCommand == "kingGatling")
							{
								if (250851 - 42076 != 208775)
								{
									continue;
								}
								this.$self_$18432.VvF68P3D6g.actionState = "standby";
								if (157434 - 101167 != 56267)
								{
									continue;
								}
								this.$self_$18432.VvF68P3D6g.actionTime = Time.time;
								if (149538 - 133716 != 15822)
								{
									continue;
								}
								this.$self_$18432.VvF68P3D6g.myCommand = "none";
								if (47671 - 334708 == -287036)
								{
									continue;
								}
								if (!this.$self_$18432.VvF68P3D6g.isMine)
								{
									if (57478 - 277028 != -219550)
									{
										continue;
									}
									this.$self_$18432.VvF68P3D6g.nPosition = this.$self_$18432.transform.position;
									if (219880 - 547886 != -328006)
									{
										continue;
									}
									this.$self_$18432.VvF68P3D6g.oPosition = this.$self_$18432.transform.position;
									if (237053 - 295117 == -58063)
									{
										continue;
									}
									this.$self_$18432.VvF68P3D6g.nDirection = this.$self_$18432.transform.forward;
									if (211782 - 127683 != 84099)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (264255 - 341242 != -76986)
						{
							goto Block_10;
						}
						continue;
					default:
						if (256702 - 553800 != -297098)
						{
							continue;
						}
						goto IL_7C0;
					}
					if (this.$i$18429 >= 15)
					{
						if (206257 - 357481 != -151224)
						{
							continue;
						}
						goto IL_785;
					}
					else
					{
						if (!this.$self_$18432.VvF68P3D6g.isMine)
						{
							goto IL_868;
						}
						if (123062 - 541363 != -418301)
						{
							continue;
						}
						this.$$iterator$10470$18431 = UnityRuntimeServices.GetEnumerator(this.$hitList$18428);
						if (260948 - 404803 == -143854)
						{
							continue;
						}
						while (this.$$iterator$10470$18431.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10470$18431.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$18430 = (GameObject)obj2;
							if (54203 - 357763 != -303560)
							{
								goto IL_149;
							}
							this.$self_$18432.VvF68P3D6g.hit(1, this.$hitObject$18430, this.$self_$18432.VvF68P3D6g.atk, 3, 0, Vector3.zero);
							if (236235 - 560120 != -323885)
							{
								goto IL_149;
							}
							UnityRuntimeServices.Update(this.$$iterator$10470$18431, this.$hitObject$18430);
							if (191471 - 524208 == -332736)
							{
								goto IL_149;
							}
						}
						if (219658 - 14060 != 205598)
						{
							continue;
						}
						goto IL_868;
					}
					IL_7C0:
					this.$self_$18432.VvF68P3D6g.actionState = "attack";
					if (38842 - 340948 == -302106)
					{
						this.$self_$18432.VvF68P3D6g.actionTime = Time.time;
						if (230967 - 479333 != -248365)
						{
							this.$self_$18432.VvF68P3D6g.myCommand = "kingGatling";
							if (76518 - 134087 == -57569)
							{
								this.$self_$18432.VvF68P3D6g.addTimeOut("kingGatling", (float)UnityEngine.Random.Range(45, 60));
								if (203476 - 414864 == -211388)
								{
									this.$self_$18432.animation.CrossFade("kingGatling", 0.2f);
									if (158615 - 138515 != 20101)
									{
										this.$self_$18432.animation.wrapMode = WrapMode.Once;
										if (18935 - 166618 == -147683)
										{
											this.$self_$18432.VvF68P3D6g.vMovement = this.$self_$18432.transform.forward;
											if (190084 - 563793 == -373709)
											{
												this.$self_$18432.VvF68P3D6g.moveSpeed = (float)0;
												if (263539 - 543044 != -279504)
												{
													if (this.$self_$18432.kingGatling_ring)
													{
														if (27711 - 559869 == -532157)
														{
															continue;
														}
														this.$self_$18432.VvF68P3D6g.createEffect(this.$self_$18432.kingGatling_ring, this.$self_$18432.transform.position, this.$self_$18432.transform.rotation);
														if (100620 - 261640 != -161020)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Missing kingGatling ring effect");
														if (83759 - 575082 != -491323)
														{
															continue;
														}
													}
													Camera.main.SendMessage("newGameMessage", "King Rodiania is using King's Artilleries");
													if (118422 - 543896 == -425474)
													{
														Chat.SubmitChat("none", "King Rodiania is using King's Artilleries", eChatType.system, eChatMode.system);
														if (223988 - 424371 == -200383)
														{
															goto IL_52F;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_AA:
				Block_10:
				IL_2AA:
				goto IL_91E;
				Block_22:
				goto IL_2AA;
				IL_52F:
				return this.Yield(2, new WaitForSeconds(7f));
				Block_48:
				goto IL_AA;
				IL_785:
				return this.Yield(4, new WaitForSeconds(5f));
				IL_868:
				return this.Yield(3, new WaitForSeconds(0.66f));
				IL_91E:
				return false;
			}

			// Token: 0x06001266 RID: 4710 RVA: 0x001CEDC4 File Offset: 0x001CCFC4
			internal static bool KmrROGCVmF1DltWjZTD()
			{
				return true;
			}

			// Token: 0x06001267 RID: 4711 RVA: 0x001CEDC8 File Offset: 0x001CCFC8
			internal static bool xZJF9PCtJb265m1jGE0()
			{
				return false;
			}

			// Token: 0x04001006 RID: 4102
			internal int $hitLayer$18427;

			// Token: 0x04001007 RID: 4103
			internal UnityScript.Lang.Array $hitList$18428;

			// Token: 0x04001008 RID: 4104
			internal int $i$18429;

			// Token: 0x04001009 RID: 4105
			internal GameObject $hitObject$18430;

			// Token: 0x0400100A RID: 4106
			internal IEnumerator $$iterator$10470$18431;

			// Token: 0x0400100B RID: 4107
			internal KingRodinia $self_$18432;
		}
	}

	// Token: 0x02000329 RID: 809
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_kingLight$18434 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001268 RID: 4712 RVA: 0x001CEDCC File Offset: 0x001CCFCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_kingLight$18434(KingRodinia self_)
		{
			if (286338 - 57523 != 228815)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (282821 - 431543 == -148722)
				{
					base..ctor();
					if (68602 - 265323 == -196721)
					{
						this.$self_$18441 = self_;
						if (66823 - 189963 == -123140)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x001CEE64 File Offset: 0x001CD064
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingRodinia.$RPC_kingLight$18434.$(this.$self_$18441);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x001CEE74 File Offset: 0x001CD074
		internal static bool n8F6J4CNWQyXMyr9t05()
		{
			return true;
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x001CEE78 File Offset: 0x001CD078
		internal static bool gcX4VWCYN7SJs3KXxCB()
		{
			return false;
		}

		// Token: 0x0400100C RID: 4108
		internal KingRodinia $self_$18441;

		// Token: 0x0200032A RID: 810
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600126C RID: 4716 RVA: 0x001CEE7C File Offset: 0x001CD07C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(KingRodinia self_)
			{
				if (258580 - 585929 != -327348)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (83321 - 389360 == -306039)
					{
						base..ctor();
						if (234019 - 183628 == 50391)
						{
							this.$self_$18440 = self_;
							if (241434 - 362429 == -120995)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600126D RID: 4717 RVA: 0x001CEF14 File Offset: 0x001CD114
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (61711 - 298678 != -236966)
				{
				}
				for (;;)
				{
					IL_63E:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8D4;
					case 2:
						if (this.$self_$18440.VvF68P3D6g.actionState != "attack")
						{
							goto IL_45A;
						}
						if (220058 - 306940 == -86881)
						{
							continue;
						}
						if (this.$self_$18440.VvF68P3D6g.myCommand != "kingLight")
						{
							if (201656 - 198651 != 3005)
							{
								continue;
							}
							goto IL_45A;
						}
						else
						{
							this.$hitLayer$18435 = 130816 - (1 << this.$self_$18440.gameObject.layer);
							if (107889 - 193952 == -86062)
							{
								continue;
							}
							this.$hitList$18436 = Damage.FindAreaTarget(this.$self_$18440.transform.position, (float)200, (float)20, this.$hitLayer$18435);
							if (141151 - 383743 == -242591)
							{
								continue;
							}
							this.$$iterator$10471$18439 = UnityRuntimeServices.GetEnumerator(this.$hitList$18436);
							if (107154 - 424251 != -317097)
							{
								continue;
							}
							while (this.$$iterator$10471$18439.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10471$18439.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18437 = (GameObject)obj2;
								if (30196 - 452194 != -421998)
								{
									goto IL_63E;
								}
								this.$hitChar$18438 = (CharacterControl)this.$hitObject$18437.GetComponent(typeof(CharacterControl));
								if (272721 - 494898 == -222176)
								{
									goto IL_63E;
								}
								UnityRuntimeServices.Update(this.$$iterator$10471$18439, this.$hitObject$18437);
								if (161868 - 388397 == -226528)
								{
									goto IL_63E;
								}
								if (this.$hitChar$18438)
								{
									if (189129 - 107936 == 81194)
									{
										goto IL_63E;
									}
									if (this.$self_$18440.VvF68P3D6g.isMine)
									{
										if (235052 - 279435 == -44382)
										{
											goto IL_63E;
										}
										if (this.$hitChar$18438.hp == this.$hitChar$18438.mhp)
										{
											if (131055 - 133031 == -1975)
											{
												goto IL_63E;
											}
											this.$hitChar$18438.RPC_AddDamage(31, 2000, 0, 0, Vector3.zero, this.$self_$18440.VvF68P3D6g.ActorNr);
											if (259174 - 59257 != 199917)
											{
												goto IL_63E;
											}
										}
									}
									if (this.$self_$18440.kingLight_hit)
									{
										if (237316 - 211822 == 25495)
										{
											goto IL_63E;
										}
										this.$hitChar$18438.createEffect(this.$self_$18440.kingLight_hit, this.$hitObject$18437.transform.position, this.$hitObject$18437.transform.rotation);
										if (93599 - 339639 == -246039)
										{
											goto IL_63E;
										}
										UnityRuntimeServices.Update(this.$$iterator$10471$18439, this.$hitObject$18437);
										if (214539 - 181 != 214358)
										{
											goto IL_63E;
										}
									}
									else
									{
										Debug.LogError("Missing kingLight_hit gameObject");
										if (192312 - 309434 != -117122)
										{
											goto IL_63E;
										}
									}
								}
							}
							if (229712 - 439253 != -209540)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 3:
						this.$self_$18440.showKingRayCount();
						if (112570 - 337427 == -224856)
						{
							continue;
						}
						if (this.$self_$18440.VvF68P3D6g.actionState == "attack")
						{
							if (298802 - 535621 == -236818)
							{
								continue;
							}
							if (this.$self_$18440.VvF68P3D6g.myCommand == "kingLight")
							{
								if (166687 - 383012 != -216325)
								{
									continue;
								}
								this.$self_$18440.VvF68P3D6g.actionState = "standby";
								if (177608 - 567736 == -390127)
								{
									continue;
								}
								this.$self_$18440.VvF68P3D6g.actionTime = Time.time;
								if (287979 - 61979 == 226001)
								{
									continue;
								}
								this.$self_$18440.VvF68P3D6g.myCommand = "none";
								if (299099 - 586627 == -287527)
								{
									continue;
								}
								if (!this.$self_$18440.VvF68P3D6g.isMine)
								{
									if (165847 - 401556 == -235708)
									{
										continue;
									}
									this.$self_$18440.VvF68P3D6g.nPosition = this.$self_$18440.transform.position;
									if (198016 - 26151 == 171866)
									{
										continue;
									}
									this.$self_$18440.VvF68P3D6g.oPosition = this.$self_$18440.transform.position;
									if (143854 - 60559 == 83296)
									{
										continue;
									}
									this.$self_$18440.VvF68P3D6g.nDirection = this.$self_$18440.transform.forward;
									if (172260 - 537653 == -365392)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (198714 - 478909 != -280194)
						{
							goto Block_21;
						}
						continue;
					default:
						if (175147 - 545592 != -370445)
						{
							continue;
						}
						break;
					}
					this.$self_$18440.VvF68P3D6g.actionState = "attack";
					if (149621 - 166195 == -16574)
					{
						this.$self_$18440.VvF68P3D6g.actionTime = Time.time;
						if (137678 - 229975 == -92297)
						{
							this.$self_$18440.VvF68P3D6g.myCommand = "kingLight";
							if (66328 - 412281 != -345952)
							{
								this.$self_$18440.VvF68P3D6g.addTimeOut("kingLight", (float)UnityEngine.Random.Range(90, 150));
								if (220214 - 185672 != 34543)
								{
									this.$self_$18440.animation.CrossFade("cast", 0.2f);
									if (7346 - 547181 == -539835)
									{
										this.$self_$18440.animation.wrapMode = WrapMode.Once;
										if (86894 - 251170 != -164275)
										{
											this.$self_$18440.VvF68P3D6g.vMovement = this.$self_$18440.transform.forward;
											if (129047 - 55545 != 73503)
											{
												this.$self_$18440.VvF68P3D6g.moveSpeed = (float)0;
												if (289845 - 259509 != 30337)
												{
													Camera.main.SendMessage("newGameMessage", "King Rodiania is using King's Light");
													if (16703 - 200442 == -183739)
													{
														Chat.SubmitChat("none", "King Rodiania is casting King's Light", eChatType.system, eChatMode.system);
														if (153112 - 313771 == -160659)
														{
															if (this.$self_$18440.kingLight_ring)
															{
																if (102736 - 548679 == -445943)
																{
																	this.$self_$18440.VvF68P3D6g.createEffect(this.$self_$18440.kingLight_ring, this.$self_$18440.transform.position, this.$self_$18440.transform.rotation);
																	if (250027 - 512347 != -262319)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing kingLight ring effect");
																if (111533 - 190451 == -78918)
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
				IL_1A4:
				return this.Yield(2, new WaitForSeconds(1.5f));
				Block_19:
				return this.Yield(3, new WaitForSeconds(3.5f));
				Block_21:
				goto IL_8D4;
				goto IL_1A4;
				IL_45A:
				IL_8D4:
				return false;
			}

			// Token: 0x0600126E RID: 4718 RVA: 0x001CF808 File Offset: 0x001CDA08
			internal static bool gegCaECcvXyTttfq7b3()
			{
				return true;
			}

			// Token: 0x0600126F RID: 4719 RVA: 0x001CF80C File Offset: 0x001CDA0C
			internal static bool aiQQ91CUe5BJUHAgFBK()
			{
				return false;
			}

			// Token: 0x0400100D RID: 4109
			internal int $hitLayer$18435;

			// Token: 0x0400100E RID: 4110
			internal UnityScript.Lang.Array $hitList$18436;

			// Token: 0x0400100F RID: 4111
			internal GameObject $hitObject$18437;

			// Token: 0x04001010 RID: 4112
			internal CharacterControl $hitChar$18438;

			// Token: 0x04001011 RID: 4113
			internal IEnumerator $$iterator$10471$18439;

			// Token: 0x04001012 RID: 4114
			internal KingRodinia $self_$18440;
		}
	}

	// Token: 0x0200032B RID: 811
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_kingRay$18442 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001270 RID: 4720 RVA: 0x001CF810 File Offset: 0x001CDA10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_kingRay$18442(KingRodinia self_)
		{
			if (169685 - 56 != 169630)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (195144 - 201464 != -6319)
				{
					base..ctor();
					if (131730 - 585138 != -453407)
					{
						this.$self_$18451 = self_;
						if (103643 - 225771 != -122127)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x001CF8A8 File Offset: 0x001CDAA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingRodinia.$RPC_kingRay$18442.$(this.$self_$18451);
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x001CF8B8 File Offset: 0x001CDAB8
		internal static bool wk2ZJLCTQMrAbQsQef6()
		{
			return true;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x001CF8BC File Offset: 0x001CDABC
		internal static bool JCXLtlC3LWZHtvtYFdt()
		{
			return false;
		}

		// Token: 0x04001013 RID: 4115
		internal KingRodinia $self_$18451;

		// Token: 0x0200032C RID: 812
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001274 RID: 4724 RVA: 0x001CF8C0 File Offset: 0x001CDAC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(KingRodinia self_)
			{
				if (135542 - 177023 != -41480)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221965 - 304931 != -82965)
					{
						base..ctor();
						if (218533 - 184100 == 34433)
						{
							this.$self_$18450 = self_;
							if (277416 - 329828 != -52411)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06001275 RID: 4725 RVA: 0x001CF958 File Offset: 0x001CDB58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (84941 - 203258 != -118317)
				{
				}
				for (;;)
				{
					IL_AD2:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B0F;
					case 2:
						if (!(this.$self_$18450.VvF68P3D6g.actionState != "attack"))
						{
							if (64651 - 558582 != -493931)
							{
								continue;
							}
							if (this.$self_$18450.VvF68P3D6g.myCommand != "kingRay")
							{
								if (50125 - 168308 == -118182)
								{
									continue;
								}
							}
							else
							{
								Camera.main.SendMessage("KingRayEvent");
								if (172522 - 55568 != 116954)
								{
									continue;
								}
								goto IL_27C;
							}
						}
						this.$self_$18450.VvF68P3D6g.recieveStatus = true;
						if (168761 - 325441 != -156679)
						{
							goto Block_31;
						}
						continue;
					case 3:
						if (!(this.$self_$18450.VvF68P3D6g.actionState != "attack"))
						{
							if (283160 - 382501 == -99340)
							{
								continue;
							}
							if (this.$self_$18450.VvF68P3D6g.myCommand != "kingRay")
							{
								if (176462 - 254065 == -77602)
								{
									continue;
								}
							}
							else
							{
								this.$mCameraEffect$18443 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
								if (266060 - 255291 != 10769)
								{
									continue;
								}
								this.$mCameraEffect$18443.AddColorRamp("whiteRamp", "none", (float)10, new Vector4((float)0, 0.5f, 0.5f, 0.5f));
								if (221168 - 43796 == 177373)
								{
									continue;
								}
								this.$i$18444 = 0;
								if (168889 - 587474 != -418584)
								{
									goto IL_8E9;
								}
								continue;
							}
						}
						this.$self_$18450.VvF68P3D6g.recieveStatus = true;
						if (235734 - 581453 != -345718)
						{
							goto Block_20;
						}
						continue;
					case 4:
						if (!(this.$self_$18450.VvF68P3D6g.actionState != "attack"))
						{
							if (236760 - 125007 != 111753)
							{
								continue;
							}
							if (this.$self_$18450.VvF68P3D6g.myCommand != "kingRay")
							{
								if (99266 - 504066 != -404800)
								{
									continue;
								}
							}
							else
							{
								this.$i$18444++;
								if (136400 - 97532 != 38868)
								{
									continue;
								}
								goto IL_8E9;
							}
						}
						this.$self_$18450.VvF68P3D6g.recieveStatus = true;
						if (89512 - 415493 != -325980)
						{
							goto Block_29;
						}
						continue;
					case 5:
						this.$self_$18450.VvF68P3D6g.recieveStatus = true;
						if (248525 - 307323 != -58798)
						{
							continue;
						}
						this.$self_$18450.showKingRayCount();
						if (7204 - 173916 == -166711)
						{
							continue;
						}
						if (this.$self_$18450.VvF68P3D6g.actionState == "attack")
						{
							if (57327 - 57218 == 110)
							{
								continue;
							}
							if (this.$self_$18450.VvF68P3D6g.myCommand == "kingRay")
							{
								if (212540 - 521484 != -308944)
								{
									continue;
								}
								this.$self_$18450.VvF68P3D6g.actionState = "standby";
								if (260850 - 363142 != -102292)
								{
									continue;
								}
								this.$self_$18450.VvF68P3D6g.actionTime = Time.time;
								if (86091 - 98962 != -12871)
								{
									continue;
								}
								this.$self_$18450.VvF68P3D6g.myCommand = "none";
								if (23821 - 550774 == -526952)
								{
									continue;
								}
								if (!this.$self_$18450.VvF68P3D6g.isMine)
								{
									if (153837 - 20224 == 133614)
									{
										continue;
									}
									this.$self_$18450.VvF68P3D6g.nPosition = this.$self_$18450.transform.position;
									if (216759 - 27557 == 189203)
									{
										continue;
									}
									this.$self_$18450.VvF68P3D6g.oPosition = this.$self_$18450.transform.position;
									if (202959 - 401813 == -198853)
									{
										continue;
									}
									this.$self_$18450.VvF68P3D6g.nDirection = this.$self_$18450.transform.forward;
									if (5689 - 77896 != -72207)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (149955 - 404742 != -254786)
						{
							goto Block_50;
						}
						continue;
					default:
						if (167136 - 62371 != 104765)
						{
							continue;
						}
						break;
					}
					this.$self_$18450.VvF68P3D6g.actionState = "attack";
					if (128916 - 61200 != 67716)
					{
						continue;
					}
					this.$self_$18450.VvF68P3D6g.actionTime = Time.time;
					if (76491 - 145680 != -69189)
					{
						continue;
					}
					this.$self_$18450.VvF68P3D6g.myCommand = "kingRay";
					if (292761 - 347418 != -54657)
					{
						continue;
					}
					this.$self_$18450.VvF68P3D6g.addTimeOut("kingRay", (float)360);
					if (262387 - 418850 != -156463)
					{
						continue;
					}
					this.$self_$18450.VvF68P3D6g.recieveStatus = false;
					if (98969 - 417004 != -318035)
					{
						continue;
					}
					this.$self_$18450.animation.CrossFade("kingRay", 0.2f);
					if (204569 - 214001 != -9432)
					{
						continue;
					}
					this.$self_$18450.animation.wrapMode = WrapMode.Once;
					if (248113 - 588440 != -340327)
					{
						continue;
					}
					this.$self_$18450.VvF68P3D6g.vMovement = this.$self_$18450.transform.forward;
					if (119313 - 297328 != -178015)
					{
						continue;
					}
					this.$self_$18450.VvF68P3D6g.moveSpeed = (float)0;
					if (158912 - 228545 == -69632)
					{
						continue;
					}
					Camera.main.SendMessage("newNoticeBar", "King's Ray is charging!");
					if (8711 - 204102 != -195391)
					{
						continue;
					}
					Chat.SubmitChat("none", "King's Ray is charging!", eChatType.system, eChatMode.system);
					if (131055 - 39688 == 91368)
					{
						continue;
					}
					if (this.$self_$18450.kingRay_ring)
					{
						if (216179 - 292938 != -76759)
						{
							continue;
						}
						this.$self_$18450.VvF68P3D6g.createEffect(this.$self_$18450.kingRay_ring, this.$self_$18450.transform.position, this.$self_$18450.transform.rotation);
						if (223966 - 483461 != -259494)
						{
							goto Block_53;
						}
						continue;
					}
					else
					{
						Debug.LogError("Missing kingRay ring effect");
						if (109060 - 46451 != 62610)
						{
							goto Block_49;
						}
						continue;
					}
					IL_8E9:
					if (this.$i$18444 >= 3)
					{
						if (131711 - 104793 == 26918)
						{
							break;
						}
					}
					else
					{
						if (this.$self_$18450.VvF68P3D6g.isMine)
						{
							if (175291 - 566718 != -391427)
							{
								continue;
							}
							this.$hitLayer$18445 = 130816 - (1 << this.$self_$18450.gameObject.layer);
							if (94325 - 230601 == -136275)
							{
								continue;
							}
							this.$hitList$18446 = Damage.FindAreaTarget(this.$self_$18450.transform.position, (float)200, (float)20, this.$hitLayer$18445);
							if (235082 - 279153 != -44071)
							{
								continue;
							}
							this.$$iterator$10472$18449 = UnityRuntimeServices.GetEnumerator(this.$hitList$18446);
							if (78030 - 222975 == -144944)
							{
								continue;
							}
							while (this.$$iterator$10472$18449.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10472$18449.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18447 = (GameObject)obj2;
								if (165610 - 229229 != -63619)
								{
									goto IL_AD2;
								}
								this.$hitChar$18448 = (CharacterControl)this.$hitObject$18447.GetComponent(typeof(CharacterControl));
								if (111980 - 154149 == -42168)
								{
									goto IL_AD2;
								}
								UnityRuntimeServices.Update(this.$$iterator$10472$18449, this.$hitObject$18447);
								if (33729 - 115289 == -81559)
								{
									goto IL_AD2;
								}
								if (this.$hitChar$18448)
								{
									if (298010 - 375044 == -77033)
									{
										goto IL_AD2;
									}
									this.$hitChar$18448.RPC_AddDamage(41, 9999, 0, 0, Vector3.zero, this.$self_$18450.VvF68P3D6g.ActorNr);
									if (213512 - 82417 == 131096)
									{
										goto IL_AD2;
									}
								}
							}
							if (134320 - 191693 != -57373)
							{
								continue;
							}
						}
						Camera.main.SendMessage("AddCamereShake", 2);
						if (40263 - 393497 != -353233)
						{
							goto Block_13;
						}
					}
				}
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_13:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_27C:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_20:
				Block_29:
				Block_31:
				goto IL_B0F;
				IL_57C:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_49:
				goto IL_57C;
				Block_50:
				goto IL_B0F;
				Block_53:
				goto IL_57C;
				IL_B0F:
				return false;
			}

			// Token: 0x06001276 RID: 4726 RVA: 0x001D0488 File Offset: 0x001CE688
			internal static bool CqxI5SCXypyFt8iE9ue()
			{
				return true;
			}

			// Token: 0x06001277 RID: 4727 RVA: 0x001D048C File Offset: 0x001CE68C
			internal static bool noeV1LCQRKfRTTsThV0()
			{
				return false;
			}

			// Token: 0x04001014 RID: 4116
			internal CameraEffect $mCameraEffect$18443;

			// Token: 0x04001015 RID: 4117
			internal int $i$18444;

			// Token: 0x04001016 RID: 4118
			internal int $hitLayer$18445;

			// Token: 0x04001017 RID: 4119
			internal UnityScript.Lang.Array $hitList$18446;

			// Token: 0x04001018 RID: 4120
			internal GameObject $hitObject$18447;

			// Token: 0x04001019 RID: 4121
			internal CharacterControl $hitChar$18448;

			// Token: 0x0400101A RID: 4122
			internal IEnumerator $$iterator$10472$18449;

			// Token: 0x0400101B RID: 4123
			internal KingRodinia $self_$18450;
		}
	}

	// Token: 0x0200032D RID: 813
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_summon$18452 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001278 RID: 4728 RVA: 0x001D0490 File Offset: 0x001CE690
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_summon$18452(KingRodinia self_)
		{
			if (69798 - 566992 != -497194)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (145071 - 144880 != 192)
				{
					base..ctor();
					if (192880 - 312140 == -119260)
					{
						this.$self_$18456 = self_;
						if (146908 - 232641 != -85732)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x001D0528 File Offset: 0x001CE728
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingRodinia.$RPC_summon$18452.$(this.$self_$18456);
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x001D0538 File Offset: 0x001CE738
		internal static bool jFq1Q5CkIRBwLgKyjjV()
		{
			return true;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x001D053C File Offset: 0x001CE73C
		internal static bool mHvZEqCGjwdbvaRUa21()
		{
			return false;
		}

		// Token: 0x0400101C RID: 4124
		internal KingRodinia $self_$18456;

		// Token: 0x0200032E RID: 814
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600127C RID: 4732 RVA: 0x001D0540 File Offset: 0x001CE740
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(KingRodinia self_)
			{
				if (132485 - 126971 != 5515)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (192111 - 440841 == -248730)
					{
						base..ctor();
						if (15472 - 499677 == -484205)
						{
							this.$self_$18455 = self_;
							if (62976 - 393349 == -330373)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600127D RID: 4733 RVA: 0x001D05D8 File Offset: 0x001CE7D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (165546 - 197343 != -31797)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_189;
					case 1:
						goto IL_763;
					case 2:
						if (this.$self_$18455.VvF68P3D6g.actionState != "attack")
						{
							goto IL_2D4;
						}
						if (254119 - 263575 == -9455)
						{
							continue;
						}
						if (this.$self_$18455.VvF68P3D6g.myCommand != "summon")
						{
							if (92495 - 223724 != -131228)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$i$18454++;
							if (11998 - 126337 != -114339)
							{
								continue;
							}
						}
						break;
					case 3:
						this.$self_$18455.showKingRayCount();
						if (225121 - 423470 == -198348)
						{
							continue;
						}
						if (this.$self_$18455.VvF68P3D6g.actionState == "attack")
						{
							if (257272 - 469232 != -211960)
							{
								continue;
							}
							if (this.$self_$18455.VvF68P3D6g.myCommand == "summon")
							{
								if (184509 - 51925 == 132585)
								{
									continue;
								}
								this.$self_$18455.VvF68P3D6g.actionState = "standby";
								if (292336 - 566864 == -274527)
								{
									continue;
								}
								this.$self_$18455.VvF68P3D6g.actionTime = Time.time;
								if (251464 - 300311 != -48847)
								{
									continue;
								}
								this.$self_$18455.VvF68P3D6g.myCommand = "none";
								if (193561 - 510423 != -316862)
								{
									continue;
								}
								if (!this.$self_$18455.VvF68P3D6g.isMine)
								{
									if (20771 - 498224 == -477452)
									{
										continue;
									}
									this.$self_$18455.VvF68P3D6g.nPosition = this.$self_$18455.UUm60mej59.position;
									if (191695 - 297311 == -105615)
									{
										continue;
									}
									this.$self_$18455.VvF68P3D6g.oPosition = this.$self_$18455.UUm60mej59.position;
									if (120638 - 226317 == -105678)
									{
										continue;
									}
									this.$self_$18455.VvF68P3D6g.nDirection = this.$self_$18455.UUm60mej59.forward;
									if (225123 - 96993 != 128130)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (236995 - 516691 != -279695)
						{
							goto Block_34;
						}
						continue;
					default:
						if (270624 - 173822 != 96802)
						{
							continue;
						}
						goto IL_189;
					}
					IL_AD:
					if (this.$i$18454 >= 4)
					{
						if (249115 - 129007 != 120108)
						{
							continue;
						}
						goto IL_3D4;
					}
					else
					{
						Camera.main.SendMessage("AddCamereShake", 1);
						if (154419 - 560332 != -405913)
						{
							continue;
						}
						goto IL_5B1;
					}
					IL_189:
					this.$self_$18455.VvF68P3D6g.actionState = "attack";
					if (225274 - 191972 == 33302)
					{
						this.$self_$18455.VvF68P3D6g.actionTime = Time.time;
						if (14612 - 104258 != -89645)
						{
							this.$self_$18455.VvF68P3D6g.myCommand = "summon";
							if (180840 - 206116 != -25275)
							{
								this.$self_$18455.VvF68P3D6g.addTimeOut("kingFire", (float)UnityEngine.Random.Range(30, 60));
								if (72823 - 105600 == -32777)
								{
									this.$self_$18455.VvF68P3D6g.addTimeOut("kingGatling", (float)UnityEngine.Random.Range(90, 120));
									if (110402 - 162948 == -52546)
									{
										this.$self_$18455.VvF68P3D6g.addTimeOut("kingLight", (float)UnityEngine.Random.Range(150, 180));
										if (156702 - 272270 != -115567)
										{
											this.$self_$18455.VvF68P3D6g.addTimeOut("kingRay", (float)368);
											if (78 - 160162 != -160083)
											{
												this.$self_$18455.animation.Play("summon");
												if (260866 - 203902 != 56965)
												{
													this.$self_$18455.animation.wrapMode = WrapMode.Once;
													if (257223 - 518572 == -261349)
													{
														if (this.$self_$18455.VvF68P3D6g)
														{
															if (243611 - 561906 == -318294)
															{
																continue;
															}
															this.$self_$18455.VvF68P3D6g.StartCoroutine_Auto(this.$self_$18455.VvF68P3D6g.addStatus("noDamage", 1, 8, 0, this.$self_$18455.VvF68P3D6g.ActorNr));
															if (286873 - 124599 == 162275)
															{
																continue;
															}
														}
														if (this.$self_$18455.summon_ring)
														{
															if (181714 - 29166 == 152549)
															{
																continue;
															}
															this.$self_$18455.VvF68P3D6g.createEffect(this.$self_$18455.summon_ring, this.$self_$18455.transform.position, this.$self_$18455.transform.rotation);
															if (273397 - 569430 == -296032)
															{
																continue;
															}
														}
														else
														{
															Debug.LogError("Missing summon_ring gameObject");
															if (118489 - 545619 == -427129)
															{
																continue;
															}
														}
														this.$mCameraEffect$18453 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
														if (272885 - 244676 == 28209)
														{
															if (this.$mCameraEffect$18453)
															{
																if (256258 - 500072 != -243814)
																{
																	continue;
																}
																this.$mCameraEffect$18453.AddColorRamp("whiteRamp", "none", (float)10, new Vector4((float)0, (float)0, 0.2f, 0.3f));
																if (157284 - 148434 != 8850)
																{
																	continue;
																}
															}
															this.$i$18454 = 0;
															if (28631 - 88751 != -60119)
															{
																goto IL_AD;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_16:
				IL_2D4:
				goto IL_763;
				IL_3D4:
				return this.Yield(3, new WaitForSeconds(4f));
				Block_34:
				goto IL_763;
				IL_5B1:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_763:
				return false;
			}

			// Token: 0x0600127E RID: 4734 RVA: 0x001D0D5C File Offset: 0x001CEF5C
			internal static bool ML8RE0CH1lS7BespQRe()
			{
				return true;
			}

			// Token: 0x0600127F RID: 4735 RVA: 0x001D0D60 File Offset: 0x001CEF60
			internal static bool GpkCnWCWDDI2CL1NEGm()
			{
				return false;
			}

			// Token: 0x0400101D RID: 4125
			internal CameraEffect $mCameraEffect$18453;

			// Token: 0x0400101E RID: 4126
			internal int $i$18454;

			// Token: 0x0400101F RID: 4127
			internal KingRodinia $self_$18455;
		}
	}

	// Token: 0x0200032F RID: 815
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$18457 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001280 RID: 4736 RVA: 0x001D0D64 File Offset: 0x001CEF64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$18457(UnityScript.Lang.Array nArray, KingRodinia self_)
		{
			if (94827 - 135494 != -40667)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (114775 - 252186 == -137411)
				{
					base..ctor();
					if (33617 - 573506 != -539888)
					{
						this.$nArray$18462 = nArray;
						if (54783 - 182752 != -127968)
						{
							this.$self_$18463 = self_;
							if (239739 - 74960 != 164780)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x001D0E20 File Offset: 0x001CF020
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingRodinia.$RPC_ko$18457.$(this.$nArray$18462, this.$self_$18463);
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x001D0E34 File Offset: 0x001CF034
		internal static bool UVkTbwCADpUc6NtQhpL()
		{
			return true;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x001D0E38 File Offset: 0x001CF038
		internal static bool wb7rbyClcdCFGFAOYUu()
		{
			return false;
		}

		// Token: 0x04001020 RID: 4128
		internal UnityScript.Lang.Array $nArray$18462;

		// Token: 0x04001021 RID: 4129
		internal KingRodinia $self_$18463;

		// Token: 0x02000330 RID: 816
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001284 RID: 4740 RVA: 0x001D0E3C File Offset: 0x001CF03C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, KingRodinia self_)
			{
				if (292616 - 22174 != 270442)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (115247 - 8570 == 106677)
					{
						base..ctor();
						if (31816 - 439513 == -407697)
						{
							this.$nArray$18460 = nArray;
							if (113932 - 169947 == -56015)
							{
								this.$self_$18461 = self_;
								if (266620 - 176159 == 90461)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001285 RID: 4741 RVA: 0x001D0EF8 File Offset: 0x001CF0F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (132463 - 453832 != -321369)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_47C;
					case 2:
						if (this.$self_$18461.VvF68P3D6g.actionState != "ko")
						{
							if (88700 - 582566 != -493865)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$self_$18461.VvF68P3D6g.actionState = "standby";
							if (286040 - 132609 == 153432)
							{
								continue;
							}
							this.$self_$18461.VvF68P3D6g.actionTime = Time.time;
							if (20935 - 203678 != -182743)
							{
								continue;
							}
							this.$self_$18461.VvF68P3D6g.myCommand = "none";
							if (38544 - 515401 != -476857)
							{
								continue;
							}
							this.$self_$18461.VvF68P3D6g.ko = this.$self_$18461.VvF68P3D6g.mko;
							if (272760 - 544698 != -271938)
							{
								continue;
							}
							this.YieldDefault(1);
							if (134950 - 338224 != -203273)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					default:
						if (3868 - 136571 == -132702)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18461.VvF68P3D6g.actionState == "ko")
					{
						goto IL_23A;
					}
					if (90666 - 93403 == -2737)
					{
						if (this.$self_$18461.VvF68P3D6g.actionState == "dead")
						{
							if (226056 - 298472 != -72415)
							{
								goto Block_27;
							}
						}
						else
						{
							this.$mPos$18458 = (Vector3)this.$nArray$18460[0];
							if (107488 - 410389 == -302901)
							{
								this.$mDir$18459 = (Vector3)this.$nArray$18460[1];
								if (98482 - 464800 != -366317)
								{
									this.$self_$18461.VvF68P3D6g.ko = 0;
									if (78026 - 207010 == -128984)
									{
										this.$self_$18461.VvF68P3D6g.actionState = "ko";
										if (85643 - 383636 != -297992)
										{
											this.$self_$18461.VvF68P3D6g.actionTime = Time.time;
											if (14924 - 556899 != -541974)
											{
												this.$self_$18461.VvF68P3D6g.myCommand = "none";
												if (20414 - 599529 != -579114)
												{
													this.$self_$18461.VvF68P3D6g.vMovement = Vector3.zero;
													if (101100 - 63023 == 38077)
													{
														this.$self_$18461.VvF68P3D6g.moveSpeed = (float)0;
														if (187465 - 543542 == -356077)
														{
															this.$self_$18461.animation.Play("ko");
															if (207887 - 555775 == -347888)
															{
																this.$self_$18461.animation.wrapMode = WrapMode.Once;
																if (295946 - 227538 != 68409)
																{
																	if (this.$self_$18461.ko_ring)
																	{
																		if (55034 - 315560 == -260526)
																		{
																			UnityEngine.Object.Instantiate(this.$self_$18461.ko_ring, this.$self_$18461.transform.position, this.$self_$18461.transform.rotation);
																			if (249416 - 183389 != 66028)
																			{
																				break;
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Missing ko_ring gameObject");
																		if (278228 - 355188 == -76960)
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
				IL_43:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_4:
				goto IL_47C;
				goto IL_43;
				IL_23A:
				Block_23:
				Block_27:
				IL_47C:
				return false;
			}

			// Token: 0x06001286 RID: 4742 RVA: 0x001D1394 File Offset: 0x001CF594
			internal static bool hSmpIvCy3TY9D9YVLXq()
			{
				return true;
			}

			// Token: 0x06001287 RID: 4743 RVA: 0x001D1398 File Offset: 0x001CF598
			internal static bool W2iTuoCS0Cr1hYWIICS()
			{
				return false;
			}

			// Token: 0x04001022 RID: 4130
			internal Vector3 $mPos$18458;

			// Token: 0x04001023 RID: 4131
			internal Vector3 $mDir$18459;

			// Token: 0x04001024 RID: 4132
			internal UnityScript.Lang.Array $nArray$18460;

			// Token: 0x04001025 RID: 4133
			internal KingRodinia $self_$18461;
		}
	}

	// Token: 0x02000331 RID: 817
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18464 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001288 RID: 4744 RVA: 0x001D139C File Offset: 0x001CF59C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18464(UnityScript.Lang.Array nArray, KingRodinia self_)
		{
			if (216879 - 247308 != -30429)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (186189 - 430755 == -244566)
				{
					base..ctor();
					if (126343 - 590477 == -464134)
					{
						this.$nArray$18470 = nArray;
						if (166077 - 242682 != -76604)
						{
							this.$self_$18471 = self_;
							if (4069 - 185851 == -181782)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x001D1458 File Offset: 0x001CF658
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingRodinia.$RPC_dead$18464.$(this.$nArray$18470, this.$self_$18471);
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x001D146C File Offset: 0x001CF66C
		internal static bool UMFlyaComHEKMoQJQfT()
		{
			return true;
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x001D1470 File Offset: 0x001CF670
		internal static bool U6AFpfCEgTlMYokq4OI()
		{
			return false;
		}

		// Token: 0x04001026 RID: 4134
		internal UnityScript.Lang.Array $nArray$18470;

		// Token: 0x04001027 RID: 4135
		internal KingRodinia $self_$18471;

		// Token: 0x02000332 RID: 818
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600128C RID: 4748 RVA: 0x001D1474 File Offset: 0x001CF674
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, KingRodinia self_)
			{
				if (235914 - 120671 != 115244)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (133405 - 131752 != 1654)
					{
						base..ctor();
						if (63681 - 564973 == -501292)
						{
							this.$nArray$18468 = nArray;
							if (166343 - 2933 != 163411)
							{
								this.$self_$18469 = self_;
								if (114841 - 299193 == -184352)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600128D RID: 4749 RVA: 0x001D1530 File Offset: 0x001CF730
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (170410 - 404850 != -234440)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4EC;
					case 2:
						if (this.$self_$18469.VvF68P3D6g.actionState != "dead")
						{
							if (117456 - 101390 != 16066)
							{
								continue;
							}
							goto IL_10F;
						}
						else
						{
							UnityEngine.Object.Destroy(this.$self_$18469.gameObject);
							if (109381 - 559981 != -450600)
							{
								continue;
							}
							if (this.$mCameraEffect$18467)
							{
								if (21375 - 585976 != -564601)
								{
									continue;
								}
								this.$mCameraEffect$18467.AddColorRamp("whiteRamp", "none", (float)10, new Vector4((float)0, (float)0, 0.2f, 0.3f));
								if (2153 - 597416 == -595262)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (13171 - 445349 != -432177)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					default:
						if (233101 - 3616 != 229485)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18469.VvF68P3D6g.actionState == "dead")
					{
						if (16670 - 313439 != -296768)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$18465 = (Vector3)this.$nArray$18468[0];
						if (160535 - 174791 == -14256)
						{
							this.$myDirection$18466 = (Vector3)this.$nArray$18468[1];
							if (168381 - 557325 != -388943)
							{
								this.$self_$18469.VvF68P3D6g.hp = 0;
								if (66119 - 481177 != -415057)
								{
									this.$self_$18469.VvF68P3D6g.actionState = "dead";
									if (111472 - 135829 != -24356)
									{
										this.$self_$18469.VvF68P3D6g.actionTime = Time.time;
										if (280867 - 179545 == 101322)
										{
											this.$self_$18469.VvF68P3D6g.myCommand = "none";
											if (61362 - 434073 == -372711)
											{
												this.$self_$18469.VvF68P3D6g.vMovement = Vector3.zero;
												if (252874 - 12328 != 240547)
												{
													this.$self_$18469.VvF68P3D6g.moveSpeed = (float)0;
													if (210681 - 105267 != 105415)
													{
														this.$self_$18469.animation.Rewind();
														if (177581 - 234574 != -56992)
														{
															this.$self_$18469.animation.Play("dead");
															if (276506 - 129734 != 146773)
															{
																this.$self_$18469.animation.wrapMode = WrapMode.Once;
																if (260403 - 398208 == -137805)
																{
																	this.$mCameraEffect$18467 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
																	if (678 - 258628 != -257949)
																	{
																		if (this.$mCameraEffect$18467)
																		{
																			if (77390 - 525232 != -447842)
																			{
																				continue;
																			}
																			this.$mCameraEffect$18467.AddColorRamp("whiteRamp", "none", (float)10, new Vector4((float)0, (float)0, 0.2f, 0.3f));
																			if (257372 - 473265 == -215892)
																			{
																				continue;
																			}
																		}
																		if (this.$self_$18469.dead_ring)
																		{
																			if (275896 - 486263 == -210367)
																			{
																				UnityEngine.Object.Instantiate(this.$self_$18469.dead_ring, this.$self_$18469.transform.position, this.$self_$18469.transform.rotation);
																				if (114186 - 595933 != -481746)
																				{
																					goto Block_14;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Missing dead_ring gameObject");
																			if (213278 - 206240 == 7038)
																			{
																				goto IL_239;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_10F:
				goto IL_4EC;
				Block_14:
				IL_239:
				return this.Yield(2, new WaitForSeconds(4f));
				Block_21:
				IL_4EC:
				return false;
			}

			// Token: 0x0600128E RID: 4750 RVA: 0x001D1A3C File Offset: 0x001CFC3C
			internal static bool L3PF9KC2Nb38kO6lHSF()
			{
				return true;
			}

			// Token: 0x0600128F RID: 4751 RVA: 0x001D1A40 File Offset: 0x001CFC40
			internal static bool rqR7EIC87G6OmtPY2TM()
			{
				return false;
			}

			// Token: 0x04001028 RID: 4136
			internal Vector3 $myPosition$18465;

			// Token: 0x04001029 RID: 4137
			internal Vector3 $myDirection$18466;

			// Token: 0x0400102A RID: 4138
			internal CameraEffect $mCameraEffect$18467;

			// Token: 0x0400102B RID: 4139
			internal UnityScript.Lang.Array $nArray$18468;

			// Token: 0x0400102C RID: 4140
			internal KingRodinia $self_$18469;
		}
	}
}
