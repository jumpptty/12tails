using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200023A RID: 570
[Serializable]
public class WaterBug : MonoBehaviour
{
	// Token: 0x06000CF5 RID: 3317 RVA: 0x0014999C File Offset: 0x00147B9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WaterBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x001499AC File Offset: 0x00147BAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (91355 - 230284 != -138928)
		{
		}
		for (;;)
		{
			this.Af8I2BXNW4 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (164169 - 239852 != -75682)
			{
				this.Af8I2BXNW4.actionState = "standby";
				if (203553 - 362444 != -158890)
				{
					this.Af8I2BXNW4.actionTime = Time.time;
					if (237020 - 566472 != -329451)
					{
						this.Af8I2BXNW4.myCommand = "none";
						if (292209 - 143760 != 148450)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (29243 - 115111 != -85867)
							{
								this.Af8I2BXNW4.isMine = true;
								if (109471 - 540724 == -431253)
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

	// Token: 0x06000CF7 RID: 3319 RVA: 0x00149AE4 File Offset: 0x00147CE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (206640 - 460013 != -253372)
		{
		}
		for (;;)
		{
			if (this.Af8I2BXNW4.isControlled)
			{
				if (241279 - 504830 == -263550)
				{
					continue;
				}
				if (!(this.Af8I2BXNW4.actionState == "standby"))
				{
					if (248425 - 144835 == 103591)
					{
						continue;
					}
					if (!(this.Af8I2BXNW4.actionState == "run"))
					{
						goto IL_6F;
					}
					if (288960 - 485401 != -196441)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (271611 - 420494 != -148883)
				{
					continue;
				}
			}
			IL_6F:
			if (this.Af8I2BXNW4.hp <= 0)
			{
				if (196257 - 267845 != -71588)
				{
					continue;
				}
				if (this.Af8I2BXNW4.actionState != "dead")
				{
					if (43525 - 177409 != -133884)
					{
						continue;
					}
					if (this.Af8I2BXNW4.isMine)
					{
						if (273044 - 559117 == -286072)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (63766 - 82116 == -18349)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (144670 - 66139 != 78531)
						{
							continue;
						}
						this.Af8I2BXNW4.DeadEvent();
						if (50122 - 479126 != -429003)
						{
							break;
						}
						continue;
					}
					else
					{
						this.Af8I2BXNW4.hp = 1;
						if (190095 - 381996 != -191900)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.Af8I2BXNW4.hp <= 0)
			{
				break;
			}
			if (73713 - 86241 != -12527)
			{
				if (this.Af8I2BXNW4.ko > 0)
				{
					break;
				}
				if (166096 - 311080 != -144983)
				{
					if (!(this.Af8I2BXNW4.actionState != "ko"))
					{
						break;
					}
					if (265406 - 329297 == -63891)
					{
						if (!(this.Af8I2BXNW4.actionState != "dead"))
						{
							break;
						}
						if (14792 - 135390 == -120598)
						{
							if (this.Af8I2BXNW4.isMine)
							{
								if (193100 - 200925 == -7825)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (23902 - 325675 != -301772)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (182392 - 384227 != -201834)
										{
											this.Af8I2BXNW4.KoEvent();
											if (104801 - 528912 == -424111)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.Af8I2BXNW4.ko = 1;
								if (161949 - 382318 != -220368)
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

	// Token: 0x06000CF8 RID: 3320 RVA: 0x00149EDC File Offset: 0x001480DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (42947 - 528587 != -485640)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (123288 - 229988 != -106699)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (189826 - 262310 == -72484)
				{
					if (29857 - 215624 != -185766)
					{
						if (ActionName == "RPC_bubbleGun")
						{
							if (42882 - 562191 == -519308)
							{
								continue;
							}
							v = 1;
							if (191328 - 132873 == 58456)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bubbleGun_fire")
						{
							if (11725 - 324200 == -312474)
							{
								continue;
							}
							v = 2;
							if (45552 - 78089 == -32536)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bubbleGun_hit")
						{
							if (59158 - 531079 == -471920)
							{
								continue;
							}
							v = -1;
							if (231360 - 104680 == 126681)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_electricSpark")
						{
							if (6796 - 403624 == -396827)
							{
								continue;
							}
							v = 11;
							if (154188 - 533335 != -379147)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (266711 - 584925 == -318214)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (28131 - 136684 != -108552)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (167750 - 370255 != -202504)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (47457 - 327386 != -279928)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (9767 - 511999 == -502232)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (243167 - 251335 != -8167)
											{
												Hashtable hashtable = new Hashtable();
												if (111053 - 353916 != -242862)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (69965 - 289655 != -219689)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (149740 - 537309 == -387569)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (249364 - 338623 != -89258)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (296910 - 290674 != 6237)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (237133 - 522145 != -285011)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (221369 - 379956 == -158587)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (273618 - 233463 != 40156)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (288944 - 581395 != -292450)
																				{
																					PhotonClient.SendEvent(this.Af8I2BXNW4.ActorNr, 74, hashtable, true, true);
																					if (59425 - 155517 != -96091)
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

	// Token: 0x06000CF9 RID: 3321 RVA: 0x0014A3C8 File Offset: 0x001485C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (176165 - 547785 != -371619)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (155957 - 330210 != -174252)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (188871 - 334869 == -145998)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (85750 - 422513 != -336762)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (210639 - 374149 != -163509)
						{
							int num3 = num;
							if (10156 - 182428 != -172271)
							{
								if (num3 == 1)
								{
									if (90070 - 41843 == 48227)
									{
										if (this.Af8I2BXNW4.isMine)
										{
											break;
										}
										if (227930 - 260203 == -32273)
										{
											this.StartCoroutine_Auto(this.RPC_bubbleGun(vector, vector2, num2));
											if (102727 - 348667 == -245940)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (23292 - 30211 == -6919)
									{
										if (this.Af8I2BXNW4.isMine)
										{
											break;
										}
										if (272759 - 584644 == -311885)
										{
											this.RPC_bubbleGun_fire(vector, vector2, num2);
											if (72579 - 521842 == -449263)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (155 - 167781 == -167626)
									{
										if (this.Af8I2BXNW4.isMine)
										{
											break;
										}
										if (85857 - 207370 == -121513)
										{
											this.RPC_bubbleGun_hit(vector, vector2, num2);
											if (102148 - 1459 == 100689)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (224268 - 442732 == -218464)
									{
										if (this.Af8I2BXNW4.isMine)
										{
											break;
										}
										if (228271 - 298746 != -70474)
										{
											this.StartCoroutine_Auto(this.RPC_electricSpark(vector, vector2, num2));
											if (271921 - 291516 == -19595)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (24684 - 409348 == -384664)
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

	// Token: 0x06000CFA RID: 3322 RVA: 0x0014A74C File Offset: 0x0014894C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (296109 - 211739 != 84371)
		{
		}
		for (;;)
		{
			float num = this.Af8I2BXNW4.moveSpeed;
			if (45065 - 400870 != -355804)
			{
				float runSpeed = this.Af8I2BXNW4.runSpeed;
				if (119479 - 539904 != -420424)
				{
					Vector3 a = default(Vector3);
					if (99711 - 347156 != -247444)
					{
						Vector3 vector = Vector3.zero;
						if (67791 - 524712 == -456921)
						{
							float num2 = (float)0;
							if (269979 - 49062 == 220917)
							{
								if (this.Af8I2BXNW4.isMine)
								{
									if (150150 - 280238 != -130088)
									{
										continue;
									}
									if ((this.Af8I2BXNW4.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (82906 - 451869 == -368962)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (7960 - 434974 == -427013)
										{
											continue;
										}
										a.y = (float)0;
										if (104408 - 22979 == 81430)
										{
											continue;
										}
										a = a.normalized;
										if (234618 - 193794 == 40825)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (238808 - 402677 == -163868)
										{
											continue;
										}
										vector = vector.normalized;
										if (279942 - 242209 != 37733)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (134945 - 336176 != -201231)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (107661 - 43491 == 64171)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (209308 - 38693 != 170615)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (231851 - 355408 == -123556)
														{
															continue;
														}
														this.Af8I2BXNW4.actionState = "run";
														if (205301 - 405154 != -199853)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (229511 - 552104 == -322592)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (140193 - 284256 != -144063)
														{
															continue;
														}
														this.animation.Play("run");
														if (58547 - 172607 == -114059)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (201784 - 121149 != 80636)
														{
															goto IL_592;
														}
														continue;
													}
												}
											}
										}
										this.Af8I2BXNW4.actionState = "standby";
										if (17434 - 78444 == -61009)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (159336 - 331123 != -171787)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (213254 - 323040 == -109785)
											{
												continue;
											}
											num = (float)0;
											if (291943 - 371854 == -79910)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (233000 - 145767 != 87233)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (89145 - 52039 != 37106)
										{
											continue;
										}
									}
									IL_592:;
								}
								else
								{
									vector = global::Math.vFlat(this.Af8I2BXNW4.nPosition - this.transform.position);
									if (73021 - 533525 != -460504)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (20040 - 193566 == -173525)
									{
										continue;
									}
									if (this.Af8I2BXNW4.nSpeed != (float)0)
									{
										if (200361 - 275604 != -75243)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (258653 - 439509 != -180856)
											{
												continue;
											}
											this.transform.position = this.Af8I2BXNW4.nPosition;
											if (45519 - 162379 == -116859)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (68102 - 381099 != -312997)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (120156 - 426675 != -306519)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (221225 - 372121 != -150896)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.Af8I2BXNW4.nSpeed, (float)10 * Time.deltaTime);
												if (281189 - 244165 == 37025)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (118481 - 69415 != 49066)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (146105 - 482993 == -336887)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (144994 - 258168 == -113173)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (211664 - 63635 == 148030)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (111748 - 71377 == 40372)
											{
												continue;
											}
										}
										else if (Time.time > this.Af8I2BXNW4.nSpeed + 0.3f)
										{
											if (105528 - 512755 == -407226)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (71548 - 34586 == 36963)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (208642 - 527569 != -318927)
												{
													continue;
												}
												num = (float)0;
												if (64623 - 488937 != -424314)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.Af8I2BXNW4.nDirection);
											if (146657 - 225606 != -78949)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (270315 - 425930 == -155614)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (157617 - 139929 != 17688)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (103481 - 522957 == -419475)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (172488 - 387392 == -214903)
											{
												continue;
											}
											this.transform.position = this.Af8I2BXNW4.nPosition;
											if (106637 - 187463 == -80825)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (125646 - 476653 != -351007)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (29396 - 481484 == -452087)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (57009 - 316559 != -259550)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (207461 - 409695 == -202233)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (205614 - 211591 != -5977)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (175722 - 344752 != -169030)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (186417 - 345853 != -159436)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.Af8I2BXNW4.nDirection);
											if (204257 - 406059 != -201802)
											{
												continue;
											}
											num = (float)0;
											if (20926 - 513288 != -492362)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (193623 - 244658 == -51034)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (68803 - 195040 != -126237)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (144390 - 569707 == -425316)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (35944 - 487898 == -451953)
										{
											continue;
										}
									}
								}
								this.Af8I2BXNW4.vMovement = vector;
								if (69865 - 162952 == -93087)
								{
									this.Af8I2BXNW4.moveSpeed = num;
									if (34067 - 496878 == -462811)
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

	// Token: 0x06000CFB RID: 3323 RVA: 0x0014B2B0 File Offset: 0x001494B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (269145 - 484149 != -215003)
		{
		}
		for (;;)
		{
			if (!this.Af8I2BXNW4.isMine)
			{
				if (52708 - 349081 != -296372)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (184087 - 233978 == -49891)
				{
					Vector3 vector = a - this.transform.position;
					if (231041 - 550503 != -319461)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (287015 - 30217 != 256799)
						{
							if (!(this.Af8I2BXNW4.actionState == "standby"))
							{
								if (80765 - 550701 != -469936)
								{
									continue;
								}
								if (!(this.Af8I2BXNW4.actionState == "run"))
								{
									break;
								}
								if (100349 - 175383 != -75034)
								{
									continue;
								}
							}
							if (this.Af8I2BXNW4.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (43478 - 291220 != -247741)
							{
								this.StartCoroutine_Auto(this.RPC_bubbleGun(this.transform.position, vector, 0));
								if (22238 - 540898 == -518660)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (298934 - 143837 == 155097)
									{
										this.ActionEvent("RPC_bubbleGun", this.transform.position, vector, 0);
										if (295132 - 449001 == -153869)
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

	// Token: 0x06000CFC RID: 3324 RVA: 0x0014B4D4 File Offset: 0x001496D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (110396 - 265466 != -155070)
		{
		}
		for (;;)
		{
			if (!this.Af8I2BXNW4.isMine)
			{
				if (89989 - 429271 != -339281)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (196724 - 447667 == -250943)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (203911 - 562655 != -358743)
					{
						Vector3 normalized = vector.normalized;
						if (227664 - 234551 != -6886)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (16215 - 597320 != -581104 && 57926 - 334144 != -276217)
							{
								if (gameObject)
								{
									if (210995 - 574196 != -363201)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (230899 - 53728 != 177171)
									{
										continue;
									}
								}
								if (!(this.Af8I2BXNW4.actionState == "standby"))
								{
									if (146056 - 596936 == -450879)
									{
										continue;
									}
									if (!(this.Af8I2BXNW4.actionState == "run"))
									{
										break;
									}
									if (64577 - 221376 != -156799)
									{
										continue;
									}
								}
								if (this.Af8I2BXNW4.isTimeOut("electricSpark") != (float)0)
								{
									if (132968 - 371443 != -238474)
									{
										Camera.main.SendMessage("newGameMessage", "ElectricSpark is not ready");
										if (256302 - 41324 != 214979)
										{
											break;
										}
									}
								}
								else
								{
									this.StartCoroutine_Auto(this.RPC_electricSpark(this.transform.position, this.transform.forward, 0));
									if (54137 - 161553 != -107415)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (24122 - 408616 != -384493)
										{
											this.ActionEvent("RPC_electricSpark", this.transform.position, this.transform.forward, 0);
											if (178505 - 76784 == 101721)
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

	// Token: 0x06000CFD RID: 3325 RVA: 0x0014B7D8 File Offset: 0x001499D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x0014B7DC File Offset: 0x001499DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bubbleGun(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new WaterBug.$RPC_bubbleGun$17496(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x0014B7EC File Offset: 0x001499EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_bubbleGun_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (112179 - 290444 != -178264)
		{
		}
		for (;;)
		{
			if (!this.wQDIvSaR7W)
			{
				if (235924 - 210125 != 25799)
				{
					continue;
				}
				this.wQDIvSaR7W = (GameObject)Resources.Load("GameAssets/Characters/Bugs/WaterBug/Effects/bubbleGun", typeof(GameObject));
				if (207586 - 552789 == -345202)
				{
					continue;
				}
			}
			if (this.wQDIvSaR7W)
			{
				if (100357 - 587071 == -486714)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.wQDIvSaR7W, firePos, Quaternion.LookRotation(fireDir));
					if (229291 - 324167 == -94876)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (240714 - 156944 == 83770)
						{
							projectileControl.Init(this.Af8I2BXNW4.ActorNr);
							if (146051 - 578717 == -432666)
							{
								projectileControl.life = (float)2 * this.Af8I2BXNW4.rangeMod;
								if (170827 - 543672 != -372844)
								{
									GameObject gameObject2 = null;
									if (196866 - 59754 != 137113)
									{
										if (tID != 0)
										{
											if (144803 - 105279 == 39525)
											{
												continue;
											}
											if (tID != this.Af8I2BXNW4.ActorNr)
											{
												if (39103 - 517983 != -478880)
												{
													continue;
												}
												object obj2;
												object obj = obj2 = PhotonClient.ActorNrList[tID];
												if (!(obj is GameObject))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
												}
												gameObject2 = (GameObject)obj2;
												if (60018 - 525804 != -465786)
												{
													continue;
												}
											}
										}
										if (!gameObject2)
										{
											break;
										}
										if (158590 - 34072 != 124519)
										{
											WaterBug_bubbleGun waterBug_bubbleGun = (WaterBug_bubbleGun)gameObject.GetComponent(typeof(WaterBug_bubbleGun));
											if (58479 - 46385 != 12095)
											{
												waterBug_bubbleGun.mTarget = gameObject2;
												if (52629 - 87067 != -34437)
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
				Debug.LogError("Cannot find bubbleGun_fire Effect");
				if (260305 - 437235 != -176929)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x0014BABC File Offset: 0x00149CBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_bubbleGun_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (16859 - 62182 != -45323)
		{
		}
		for (;;)
		{
			if (!this.xXkIlJ4r4G)
			{
				if (19855 - 17054 != 2801)
				{
					continue;
				}
				this.xXkIlJ4r4G = (GameObject)Resources.Load("GameAssets/Characters/Bugs/WaterBug/Effects/bubbleGun_hit", typeof(GameObject));
				if (37139 - 312555 == -275415)
				{
					continue;
				}
			}
			if (this.xXkIlJ4r4G)
			{
				if (127153 - 589516 == -462363)
				{
					UnityEngine.Object.Instantiate(this.xXkIlJ4r4G, hitPos, Quaternion.LookRotation(hitDir));
					if (196056 - 455420 == -259364)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find bubbleGun_hit Effect");
				if (6455 - 477849 != -471393)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000D01 RID: 3329 RVA: 0x0014BBD8 File Offset: 0x00149DD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_electricSpark(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new WaterBug.$RPC_electricSpark$17506(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000D02 RID: 3330 RVA: 0x0014BBE8 File Offset: 0x00149DE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new WaterBug.$RPC_ko$17520(nArray, this).GetEnumerator();
	}

	// Token: 0x06000D03 RID: 3331 RVA: 0x0014BBF8 File Offset: 0x00149DF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new WaterBug.$RPC_dead$17527(nArray, this).GetEnumerator();
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x0014BC08 File Offset: 0x00149E08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x0014BC0C File Offset: 0x00149E0C
	internal static bool vAw3YTl2FN2lvDcdIlf()
	{
		return true;
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x0014BC10 File Offset: 0x00149E10
	internal static bool cCReLdl8rDJYRya32sL()
	{
		return false;
	}

	// Token: 0x04000B4F RID: 2895
	private CharacterControl Af8I2BXNW4;

	// Token: 0x04000B50 RID: 2896
	private GameObject wQDIvSaR7W;

	// Token: 0x04000B51 RID: 2897
	private GameObject xXkIlJ4r4G;

	// Token: 0x04000B52 RID: 2898
	private GameObject ueEIGhJ9TV;

	// Token: 0x0200023B RID: 571
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bubbleGun$17496 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000D07 RID: 3335 RVA: 0x0014BC14 File Offset: 0x00149E14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bubbleGun$17496(Vector3 mPos, Vector3 tDir, int tID, WaterBug self_)
		{
			if (289205 - 87623 != 201582)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (14688 - 422326 == -407638)
				{
					base..ctor();
					if (93387 - 17710 == 75677)
					{
						this.$mPos$17502 = mPos;
						if (184886 - 197739 != -12852)
						{
							this.$tDir$17503 = tDir;
							if (217514 - 32518 != 184997)
							{
								this.$tID$17504 = tID;
								if (232781 - 361307 == -128526)
								{
									this.$self_$17505 = self_;
									if (19643 - 472187 != -452543)
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

		// Token: 0x06000D08 RID: 3336 RVA: 0x0014BD14 File Offset: 0x00149F14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WaterBug.$RPC_bubbleGun$17496.$(this.$mPos$17502, this.$tDir$17503, this.$tID$17504, this.$self_$17505);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0014BD34 File Offset: 0x00149F34
		internal static bool vPiyHrlZwb0VH79XYZn()
		{
			return true;
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0014BD38 File Offset: 0x00149F38
		internal static bool P4XyDflC3qw8Hrc0vOV()
		{
			return false;
		}

		// Token: 0x04000B53 RID: 2899
		internal Vector3 $mPos$17502;

		// Token: 0x04000B54 RID: 2900
		internal Vector3 $tDir$17503;

		// Token: 0x04000B55 RID: 2901
		internal int $tID$17504;

		// Token: 0x04000B56 RID: 2902
		internal WaterBug $self_$17505;

		// Token: 0x0200023C RID: 572
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000D0B RID: 3339 RVA: 0x0014BD3C File Offset: 0x00149F3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, WaterBug self_)
			{
				if (176550 - 577615 != -401064)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (170485 - 132632 != 37854)
					{
						base..ctor();
						if (87230 - 4999 != 82232)
						{
							this.$mPos$17498 = mPos;
							if (190541 - 349612 == -159071)
							{
								this.$tDir$17499 = tDir;
								if (181963 - 588228 == -406265)
								{
									this.$tID$17500 = tID;
									if (283443 - 220928 != 62516)
									{
										this.$self_$17501 = self_;
										if (294120 - 568923 != -274802)
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

			// Token: 0x06000D0C RID: 3340 RVA: 0x0014BE3C File Offset: 0x0014A03C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (143546 - 27922 != 115625)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_62D;
					case 2:
						if (this.$self_$17501.Af8I2BXNW4.actionState != "attack")
						{
							goto IL_2B3;
						}
						if (220074 - 516895 == -296820)
						{
							continue;
						}
						if (this.$self_$17501.Af8I2BXNW4.myCommand != "bubbleGun")
						{
							if (215495 - 194807 != 20688)
							{
								continue;
							}
							goto IL_2B3;
						}
						else
						{
							this.$firePos$17497 = this.$self_$17501.transform.position + this.$self_$17501.transform.TransformDirection((float)0, (float)2, (float)2);
							if (19432 - 439081 != -419649)
							{
								continue;
							}
							if (!this.$self_$17501.Af8I2BXNW4.isMine)
							{
								goto IL_47F;
							}
							if (97111 - 552798 == -455686)
							{
								continue;
							}
							this.$self_$17501.RPC_bubbleGun_fire(this.$firePos$17497, this.$self_$17501.transform.forward, this.$tID$17500);
							if (224898 - 74263 != 150635)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_47F;
							}
							if (727 - 567036 == -566308)
							{
								continue;
							}
							this.$self_$17501.ActionEvent("RPC_bubbleGun_fire", this.$firePos$17497, this.$self_$17501.transform.forward, this.$tID$17500);
							if (173911 - 232427 != -58516)
							{
								continue;
							}
							goto IL_47F;
						}
						break;
					case 3:
						if (this.$self_$17501.Af8I2BXNW4.actionState == "attack")
						{
							if (291702 - 189353 != 102349)
							{
								continue;
							}
							if (this.$self_$17501.Af8I2BXNW4.myCommand == "bubbleGun")
							{
								if (168859 - 117834 == 51026)
								{
									continue;
								}
								this.$self_$17501.Af8I2BXNW4.actionState = "standby";
								if (210864 - 367774 == -156909)
								{
									continue;
								}
								this.$self_$17501.Af8I2BXNW4.actionTime = Time.time;
								if (242649 - 595139 != -352490)
								{
									continue;
								}
								this.$self_$17501.Af8I2BXNW4.myCommand = "none";
								if (2399 - 412812 == -410412)
								{
									continue;
								}
								if (!this.$self_$17501.Af8I2BXNW4.isMine)
								{
									if (168619 - 557006 == -388386)
									{
										continue;
									}
									this.$self_$17501.Af8I2BXNW4.nPosition = this.$self_$17501.transform.position;
									if (88905 - 508252 == -419346)
									{
										continue;
									}
									this.$self_$17501.Af8I2BXNW4.oPosition = this.$self_$17501.transform.position;
									if (199894 - 29574 == 170321)
									{
										continue;
									}
									this.$self_$17501.Af8I2BXNW4.nDirection = this.$self_$17501.transform.forward;
									if (88487 - 293746 == -205258)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (224333 - 543390 != -319057)
						{
							continue;
						}
						goto IL_62D;
					default:
						if (41174 - 402977 == -361802)
						{
							continue;
						}
						break;
					}
					this.$self_$17501.Af8I2BXNW4.actionState = "attack";
					if (143907 - 181931 == -38024)
					{
						this.$self_$17501.Af8I2BXNW4.actionTime = Time.time;
						if (210323 - 379414 == -169091)
						{
							this.$self_$17501.Af8I2BXNW4.myCommand = "bubbleGun";
							if (36805 - 232724 != -195918)
							{
								this.$self_$17501.Af8I2BXNW4.addTimeOut("nAttack", (float)3);
								if (108361 - 8742 == 99619)
								{
									this.$self_$17501.transform.position = this.$mPos$17498;
									if (284438 - 41675 != 242764)
									{
										this.$self_$17501.transform.LookAt(this.$mPos$17498 + global::Math.vFlat(this.$tDir$17499));
										if (121246 - 191586 == -70340)
										{
											this.$self_$17501.animation.Rewind();
											if (18395 - 517385 != -498989)
											{
												this.$self_$17501.animation.CrossFade("bubbleGun");
												if (81836 - 524599 != -442762)
												{
													this.$self_$17501.animation.wrapMode = WrapMode.Once;
													if (198789 - 152271 != 46519)
													{
														this.$self_$17501.Af8I2BXNW4.vMovement = this.$self_$17501.transform.forward;
														if (287778 - 181844 != 105935)
														{
															this.$self_$17501.Af8I2BXNW4.moveSpeed = (float)0;
															if (292326 - 369023 == -76697)
															{
																goto IL_430;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_2B3:
				goto IL_62D;
				IL_430:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_47F:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_62D:
				return false;
			}

			// Token: 0x06000D0D RID: 3341 RVA: 0x0014C488 File Offset: 0x0014A688
			internal static bool JhqMDBlLa9fSNKDjIqv()
			{
				return true;
			}

			// Token: 0x06000D0E RID: 3342 RVA: 0x0014C48C File Offset: 0x0014A68C
			internal static bool AcQAfclOfpjS3T3b4LS()
			{
				return false;
			}

			// Token: 0x04000B57 RID: 2903
			internal Vector3 $firePos$17497;

			// Token: 0x04000B58 RID: 2904
			internal Vector3 $mPos$17498;

			// Token: 0x04000B59 RID: 2905
			internal Vector3 $tDir$17499;

			// Token: 0x04000B5A RID: 2906
			internal int $tID$17500;

			// Token: 0x04000B5B RID: 2907
			internal WaterBug $self_$17501;
		}
	}

	// Token: 0x0200023D RID: 573
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_electricSpark$17506 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000D0F RID: 3343 RVA: 0x0014C490 File Offset: 0x0014A690
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_electricSpark$17506(Vector3 mPos, Vector3 tDir, WaterBug self_)
		{
			if (77807 - 591659 != -513851)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (95 - 243843 != -243747)
				{
					base..ctor();
					if (231397 - 233277 != -1879)
					{
						this.$mPos$17517 = mPos;
						if (282066 - 371441 != -89374)
						{
							this.$tDir$17518 = tDir;
							if (133413 - 44053 == 89360)
							{
								this.$self_$17519 = self_;
								if (37829 - 347184 != -309354)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0014C56C File Offset: 0x0014A76C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WaterBug.$RPC_electricSpark$17506.$(this.$mPos$17517, this.$tDir$17518, this.$self_$17519);
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0014C588 File Offset: 0x0014A788
		internal static bool s0mrNZlmUuvwgxWiwBD()
		{
			return true;
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0014C58C File Offset: 0x0014A78C
		internal static bool WMgVTglFK43IqbrfLLk()
		{
			return false;
		}

		// Token: 0x04000B5C RID: 2908
		internal Vector3 $mPos$17517;

		// Token: 0x04000B5D RID: 2909
		internal Vector3 $tDir$17518;

		// Token: 0x04000B5E RID: 2910
		internal WaterBug $self_$17519;

		// Token: 0x0200023E RID: 574
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000D13 RID: 3347 RVA: 0x0014C590 File Offset: 0x0014A790
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, WaterBug self_)
			{
				if (281080 - 598505 != -317425)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (53356 - 65553 == -12197)
					{
						base..ctor();
						if (270881 - 327822 != -56940)
						{
							this.$mPos$17514 = mPos;
							if (217732 - 248143 != -30410)
							{
								this.$tDir$17515 = tDir;
								if (26949 - 478509 != -451559)
								{
									this.$self_$17516 = self_;
									if (72059 - 493446 != -421386)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000D14 RID: 3348 RVA: 0x0014C66C File Offset: 0x0014A86C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (264990 - 212190 != 52800)
				{
				}
				for (;;)
				{
					IL_7CD:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AC3;
					case 2:
						if (this.$self_$17516.Af8I2BXNW4.actionState != "attack")
						{
							goto IL_644;
						}
						if (253914 - 92847 != 161067)
						{
							continue;
						}
						if (this.$self_$17516.Af8I2BXNW4.myCommand != "electricSpark")
						{
							if (232040 - 286584 != -54544)
							{
								continue;
							}
							goto IL_644;
						}
						else
						{
							if (!this.$self_$17516.ueEIGhJ9TV)
							{
								if (74388 - 580831 != -506443)
								{
									continue;
								}
								this.$self_$17516.ueEIGhJ9TV = (GameObject)Resources.Load("GameAssets/Characters/Bugs/WaterBug/Effects/electricSpark", typeof(GameObject));
								if (221861 - 189609 != 32252)
								{
									continue;
								}
							}
							if (this.$self_$17516.ueEIGhJ9TV)
							{
								if (71689 - 45456 == 26234)
								{
									continue;
								}
								this.$self_$17516.Af8I2BXNW4.createEffect(this.$self_$17516.ueEIGhJ9TV, this.$self_$17516.transform.position, this.$self_$17516.transform.rotation);
								if (139269 - 106829 == 32441)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find echoesRing Effect");
								if (53308 - 534811 == -481502)
								{
									continue;
								}
							}
							this.$i$17507 = 0;
							if (129168 - 411770 != -282601)
							{
								goto IL_56E;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17516.Af8I2BXNW4.actionState != "attack")
						{
							goto IL_884;
						}
						if (272488 - 178583 == 93906)
						{
							continue;
						}
						if (this.$self_$17516.Af8I2BXNW4.myCommand != "electricSpark")
						{
							if (38645 - 581583 != -542937)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							if (this.$self_$17516.Af8I2BXNW4.isMine)
							{
								if (214674 - 166121 == 48554)
								{
									continue;
								}
								this.$hitLayer$17508 = 130816 - (1 << this.$self_$17516.gameObject.layer);
								if (264611 - 500333 != -235722)
								{
									continue;
								}
								this.$hitList$17509 = Damage.FindAreaTarget(this.$self_$17516.transform.position, (float)6 * this.$self_$17516.Af8I2BXNW4.rangeMod, (float)3 * this.$self_$17516.Af8I2BXNW4.rangeMod, this.$hitLayer$17508);
								if (209475 - 135869 != 73606)
								{
									continue;
								}
								this.$$iterator$10040$17513 = UnityRuntimeServices.GetEnumerator(this.$hitList$17509);
								if (297949 - 170561 == 127389)
								{
									continue;
								}
								while (this.$$iterator$10040$17513.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10040$17513.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$17510 = (GameObject)obj2;
									if (133442 - 333181 != -199739)
									{
										goto IL_7CD;
									}
									if (this.$self_$17516.Af8I2BXNW4.hit(1, this.$hitObject$17510, (int)(0.5f * (float)this.$self_$17516.Af8I2BXNW4.atk), 3, 0, Vector3.zero) != 0)
									{
										if (90176 - 464018 != -373842)
										{
											goto IL_7CD;
										}
										if (UnityEngine.Random.Range(0, 100) < 20)
										{
											if (112504 - 427884 == -315379)
											{
												goto IL_7CD;
											}
											this.$hitChar$17511 = (CharacterControl)this.$hitObject$17510.GetComponent(typeof(CharacterControl));
											if (132552 - 54529 != 78023)
											{
												goto IL_7CD;
											}
											UnityRuntimeServices.Update(this.$$iterator$10040$17513, this.$hitObject$17510);
											if (140545 - 533073 == -392527)
											{
												goto IL_7CD;
											}
											if (this.$hitChar$17511)
											{
												if (108219 - 224953 != -116734)
												{
													goto IL_7CD;
												}
												if (!(this.$hitChar$17511.actionState == "standby"))
												{
													if (246544 - 169190 == 77355)
													{
														goto IL_7CD;
													}
													if (!(this.$hitChar$17511.actionState == "run"))
													{
														if (51499 - 549283 != -497784)
														{
															goto IL_7CD;
														}
														if (!(this.$hitChar$17511.actionState == "emotion"))
														{
															continue;
														}
														if (154879 - 142155 == 12725)
														{
															goto IL_7CD;
														}
													}
												}
												this.$mDuration$17512 = Damage.getDebuff((float)3, this.$self_$17516.Af8I2BXNW4.cha, this.$hitChar$17511.cha);
												if (39522 - 548958 == -509435)
												{
													goto IL_7CD;
												}
												this.$hitChar$17511.RPC_AddStatus("paralysis", 3, this.$mDuration$17512, 0, this.$self_$17516.Af8I2BXNW4.ActorNr);
												if (155356 - 250114 != -94758)
												{
													goto IL_7CD;
												}
											}
										}
									}
								}
								if (179691 - 330751 == -151059)
								{
									continue;
								}
							}
							this.$i$17507++;
							if (35916 - 129265 != -93348)
							{
								goto IL_56E;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17516.Af8I2BXNW4.actionState == "attack")
						{
							if (206160 - 21572 != 184588)
							{
								continue;
							}
							if (this.$self_$17516.Af8I2BXNW4.myCommand == "electricSpark")
							{
								if (241871 - 7008 == 234864)
								{
									continue;
								}
								this.$self_$17516.Af8I2BXNW4.moveSpeed = (float)0;
								if (254913 - 137110 != 117803)
								{
									continue;
								}
								this.$self_$17516.Af8I2BXNW4.actionState = "standby";
								if (189763 - 180188 != 9575)
								{
									continue;
								}
								this.$self_$17516.Af8I2BXNW4.actionTime = Time.time;
								if (248947 - 17535 == 231413)
								{
									continue;
								}
								this.$self_$17516.Af8I2BXNW4.myCommand = "none";
								if (99515 - 587134 == -487618)
								{
									continue;
								}
								if (!this.$self_$17516.Af8I2BXNW4.isMine)
								{
									if (25603 - 61902 == -36298)
									{
										continue;
									}
									this.$self_$17516.Af8I2BXNW4.nPosition = this.$self_$17516.transform.position;
									if (265430 - 145314 != 120116)
									{
										continue;
									}
									this.$self_$17516.Af8I2BXNW4.oPosition = this.$self_$17516.transform.position;
									if (143538 - 361156 == -217617)
									{
										continue;
									}
									this.$self_$17516.Af8I2BXNW4.nDirection = this.$self_$17516.transform.forward;
									if (247024 - 179201 != 67823)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (266686 - 252265 != 14422)
						{
							goto Block_13;
						}
						continue;
					default:
						if (48896 - 476642 == -427745)
						{
							continue;
						}
						break;
					}
					this.$self_$17516.Af8I2BXNW4.actionState = "attack";
					if (64264 - 493002 != -428738)
					{
						continue;
					}
					this.$self_$17516.Af8I2BXNW4.actionTime = Time.time;
					if (131213 - 556385 != -425172)
					{
						continue;
					}
					this.$self_$17516.Af8I2BXNW4.myCommand = "electricSpark";
					if (112728 - 482943 != -370215)
					{
						continue;
					}
					this.$self_$17516.Af8I2BXNW4.addTimeOut("electricSpark", (float)4);
					if (23341 - 594356 == -571014)
					{
						continue;
					}
					this.$self_$17516.transform.position = this.$mPos$17514;
					if (243544 - 327824 == -84279)
					{
						continue;
					}
					this.$self_$17516.transform.LookAt(this.$mPos$17514 + global::Math.vFlat(this.$tDir$17515));
					if (298574 - 395242 != -96668)
					{
						continue;
					}
					this.$self_$17516.animation.CrossFade("electricSpark");
					if (60018 - 320300 != -260282)
					{
						continue;
					}
					this.$self_$17516.animation.wrapMode = WrapMode.Once;
					if (169097 - 60290 == 108808)
					{
						continue;
					}
					this.$self_$17516.Af8I2BXNW4.vMovement = this.$self_$17516.transform.forward;
					if (295999 - 120306 != 175693)
					{
						continue;
					}
					this.$self_$17516.Af8I2BXNW4.moveSpeed = (float)0;
					if (62078 - 281776 != -219698)
					{
						continue;
					}
					goto IL_6A7;
					IL_56E:
					if (this.$i$17507 < 3)
					{
						goto IL_3BA;
					}
					if (208021 - 374032 != -166010)
					{
						goto Block_36;
					}
				}
				Block_13:
				goto IL_AC3;
				IL_3BA:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_36:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_644:
				goto IL_AC3;
				IL_6A7:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_49:
				IL_884:
				IL_AC3:
				return false;
			}

			// Token: 0x06000D15 RID: 3349 RVA: 0x0014D150 File Offset: 0x0014B350
			internal static bool N0RLc5lMeQ4jd43XL7f()
			{
				return true;
			}

			// Token: 0x06000D16 RID: 3350 RVA: 0x0014D154 File Offset: 0x0014B354
			internal static bool n9sgitlxAIdQkUTwYLx()
			{
				return false;
			}

			// Token: 0x04000B5F RID: 2911
			internal int $i$17507;

			// Token: 0x04000B60 RID: 2912
			internal int $hitLayer$17508;

			// Token: 0x04000B61 RID: 2913
			internal UnityScript.Lang.Array $hitList$17509;

			// Token: 0x04000B62 RID: 2914
			internal GameObject $hitObject$17510;

			// Token: 0x04000B63 RID: 2915
			internal CharacterControl $hitChar$17511;

			// Token: 0x04000B64 RID: 2916
			internal int $mDuration$17512;

			// Token: 0x04000B65 RID: 2917
			internal IEnumerator $$iterator$10040$17513;

			// Token: 0x04000B66 RID: 2918
			internal Vector3 $mPos$17514;

			// Token: 0x04000B67 RID: 2919
			internal Vector3 $tDir$17515;

			// Token: 0x04000B68 RID: 2920
			internal WaterBug $self_$17516;
		}
	}

	// Token: 0x0200023F RID: 575
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17520 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000D17 RID: 3351 RVA: 0x0014D158 File Offset: 0x0014B358
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17520(UnityScript.Lang.Array nArray, WaterBug self_)
		{
			if (233423 - 439511 != -206087)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (119156 - 82384 == 36772)
				{
					base..ctor();
					if (96170 - 166365 == -70195)
					{
						this.$nArray$17525 = nArray;
						if (215718 - 254492 != -38773)
						{
							this.$self_$17526 = self_;
							if (149747 - 237262 == -87515)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0014D214 File Offset: 0x0014B414
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WaterBug.$RPC_ko$17520.$(this.$nArray$17525, this.$self_$17526);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0014D228 File Offset: 0x0014B428
		internal static bool XiNlCalgIOyJm5B5NpE()
		{
			return true;
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0014D22C File Offset: 0x0014B42C
		internal static bool Kd4H8llfOPoS7bBRGE6()
		{
			return false;
		}

		// Token: 0x04000B69 RID: 2921
		internal UnityScript.Lang.Array $nArray$17525;

		// Token: 0x04000B6A RID: 2922
		internal WaterBug $self_$17526;

		// Token: 0x02000240 RID: 576
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000D1B RID: 3355 RVA: 0x0014D230 File Offset: 0x0014B430
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, WaterBug self_)
			{
				if (27651 - 278167 != -250515)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (133961 - 377975 == -244014)
					{
						base..ctor();
						if (44125 - 499543 == -455418)
						{
							this.$nArray$17523 = nArray;
							if (23192 - 30418 != -7225)
							{
								this.$self_$17524 = self_;
								if (427 - 150860 == -150433)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000D1C RID: 3356 RVA: 0x0014D2EC File Offset: 0x0014B4EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (202204 - 299317 != -97113)
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
						if (this.$self_$17524.Af8I2BXNW4.actionState != "ko")
						{
							if (188977 - 590216 != -401239)
							{
								continue;
							}
							goto IL_160;
						}
						else
						{
							this.$self_$17524.animation.Play("getUp");
							if (97424 - 538892 == -441467)
							{
								continue;
							}
							this.$self_$17524.animation.wrapMode = WrapMode.Once;
							if (206208 - 547743 != -341535)
							{
								continue;
							}
							goto IL_3D3;
						}
						break;
					case 3:
						if (this.$self_$17524.Af8I2BXNW4.actionState != "ko")
						{
							if (232637 - 521621 != -288983)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$self_$17524.Af8I2BXNW4.actionState = "standby";
							if (19323 - 573611 != -554288)
							{
								continue;
							}
							this.$self_$17524.Af8I2BXNW4.actionTime = Time.time;
							if (15328 - 578813 == -563484)
							{
								continue;
							}
							this.$self_$17524.Af8I2BXNW4.myCommand = "none";
							if (254036 - 280801 != -26765)
							{
								continue;
							}
							this.$self_$17524.Af8I2BXNW4.ko = this.$self_$17524.Af8I2BXNW4.mko;
							if (239409 - 105938 == 133472)
							{
								continue;
							}
							this.YieldDefault(1);
							if (64452 - 385284 != -320831)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					default:
						if (220386 - 262588 != -42202)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17524.Af8I2BXNW4.actionState == "ko")
					{
						break;
					}
					if (175802 - 398844 == -223042)
					{
						if (this.$self_$17524.Af8I2BXNW4.actionState == "dead")
						{
							if (75335 - 568051 == -492716)
							{
								break;
							}
						}
						else
						{
							this.$mPos$17521 = (Vector3)this.$nArray$17523[0];
							if (149501 - 277192 != -127690)
							{
								this.$mDir$17522 = (Vector3)this.$nArray$17523[1];
								if (138094 - 342228 != -204133)
								{
									this.$self_$17524.Af8I2BXNW4.ko = 0;
									if (277320 - 84179 == 193141)
									{
										this.$self_$17524.Af8I2BXNW4.actionState = "ko";
										if (53025 - 553268 == -500243)
										{
											this.$self_$17524.Af8I2BXNW4.actionTime = Time.time;
											if (259681 - 24722 == 234959)
											{
												this.$self_$17524.Af8I2BXNW4.myCommand = "none";
												if (239933 - 496353 == -256420)
												{
													this.$self_$17524.Af8I2BXNW4.vMovement = Vector3.zero;
													if (259342 - 530226 == -270884)
													{
														this.$self_$17524.Af8I2BXNW4.moveSpeed = (float)0;
														if (263282 - 186322 != 76961)
														{
															this.$self_$17524.animation.Play("ko");
															if (139432 - 454428 != -314995)
															{
																this.$self_$17524.animation.wrapMode = WrapMode.Once;
																if (258036 - 265711 != -7674)
																{
																	goto Block_19;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_6:
				IL_160:
				goto IL_48C;
				Block_19:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_3D3:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_25:
				IL_48C:
				return false;
			}

			// Token: 0x06000D1D RID: 3357 RVA: 0x0014D798 File Offset: 0x0014B998
			internal static bool tLPZkClnswsEZm3tLSs()
			{
				return true;
			}

			// Token: 0x06000D1E RID: 3358 RVA: 0x0014D79C File Offset: 0x0014B99C
			internal static bool QiPnOWl69uaOqAfFmTR()
			{
				return false;
			}

			// Token: 0x04000B6B RID: 2923
			internal Vector3 $mPos$17521;

			// Token: 0x04000B6C RID: 2924
			internal Vector3 $mDir$17522;

			// Token: 0x04000B6D RID: 2925
			internal UnityScript.Lang.Array $nArray$17523;

			// Token: 0x04000B6E RID: 2926
			internal WaterBug $self_$17524;
		}
	}

	// Token: 0x02000241 RID: 577
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17527 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000D1F RID: 3359 RVA: 0x0014D7A0 File Offset: 0x0014B9A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17527(UnityScript.Lang.Array nArray, WaterBug self_)
		{
			if (34450 - 264087 != -229637)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (35881 - 107754 != -71872)
				{
					base..ctor();
					if (82756 - 400736 != -317979)
					{
						this.$nArray$17532 = nArray;
						if (100358 - 527384 != -427025)
						{
							this.$self_$17533 = self_;
							if (117559 - 104034 == 13525)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0014D85C File Offset: 0x0014BA5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WaterBug.$RPC_dead$17527.$(this.$nArray$17532, this.$self_$17533);
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0014D870 File Offset: 0x0014BA70
		internal static bool ItHssfliiOi0PE7FUkp()
		{
			return true;
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0014D874 File Offset: 0x0014BA74
		internal static bool HiGkJBlKhB8vlIIndib()
		{
			return false;
		}

		// Token: 0x04000B6F RID: 2927
		internal UnityScript.Lang.Array $nArray$17532;

		// Token: 0x04000B70 RID: 2928
		internal WaterBug $self_$17533;

		// Token: 0x02000242 RID: 578
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000D23 RID: 3363 RVA: 0x0014D878 File Offset: 0x0014BA78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, WaterBug self_)
			{
				if (199010 - 522191 != -323181)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (256039 - 528457 == -272418)
					{
						base..ctor();
						if (176320 - 400945 != -224624)
						{
							this.$nArray$17530 = nArray;
							if (296021 - 461245 == -165224)
							{
								this.$self_$17531 = self_;
								if (9960 - 82977 == -73017)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000D24 RID: 3364 RVA: 0x0014D934 File Offset: 0x0014BB34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150119 - 225913 != -75793)
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
						if (this.$self_$17531.Af8I2BXNW4.actionState != "dead")
						{
							if (167990 - 495532 != -327541)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17531.Af8I2BXNW4.isPlayer)
							{
								if (261859 - 371585 != -109726)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17531.gameObject);
								if (71615 - 156894 == -85278)
								{
									continue;
								}
							}
							else if (this.$self_$17531.Af8I2BXNW4.isMine)
							{
								if (83503 - 372228 != -288725)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17531.gameObject);
								if (49989 - 228959 == -178969)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (163533 - 533261 != -369727)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					default:
						if (194236 - 573227 != -378991)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17531.Af8I2BXNW4.actionState == "dead")
					{
						if (87459 - 43218 == 44241)
						{
							goto IL_2A9;
						}
					}
					else
					{
						this.$mPos$17528 = (Vector3)this.$nArray$17530[0];
						if (221005 - 582898 != -361892)
						{
							this.$myDirection$17529 = (Vector3)this.$nArray$17530[1];
							if (211969 - 418514 != -206544)
							{
								this.$self_$17531.transform.position = this.$mPos$17528;
								if (221107 - 11587 == 209520)
								{
									this.$self_$17531.transform.LookAt(this.$mPos$17528 + this.$myDirection$17529);
									if (51212 - 588993 != -537780)
									{
										this.$self_$17531.Af8I2BXNW4.hp = 0;
										if (276517 - 211107 != 65411)
										{
											this.$self_$17531.Af8I2BXNW4.actionState = "dead";
											if (289267 - 411228 == -121961)
											{
												this.$self_$17531.Af8I2BXNW4.actionTime = Time.time;
												if (122226 - 87070 != 35157)
												{
													this.$self_$17531.Af8I2BXNW4.myCommand = "none";
													if (49706 - 85147 != -35440)
													{
														this.$self_$17531.Af8I2BXNW4.vMovement = Vector3.zero;
														if (11372 - 263244 != -251871)
														{
															this.$self_$17531.Af8I2BXNW4.moveSpeed = (float)0;
															if (45559 - 328847 == -283288)
															{
																this.$self_$17531.animation.Rewind();
																if (171466 - 416104 != -244637)
																{
																	this.$self_$17531.animation.Play("dead");
																	if (86750 - 200146 != -113395)
																	{
																		this.$self_$17531.animation.wrapMode = WrapMode.Once;
																		if (140357 - 13789 == 126568)
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
				Block_10:
				Block_16:
				IL_2A9:
				IL_42F:
				return false;
			}

			// Token: 0x06000D25 RID: 3365 RVA: 0x0014DD84 File Offset: 0x0014BF84
			internal static bool kM92ikldjXNZeTL5gnx()
			{
				return true;
			}

			// Token: 0x06000D26 RID: 3366 RVA: 0x0014DD88 File Offset: 0x0014BF88
			internal static bool XoPqWTlJk0Urdm5FwQG()
			{
				return false;
			}

			// Token: 0x04000B71 RID: 2929
			internal Vector3 $mPos$17528;

			// Token: 0x04000B72 RID: 2930
			internal Vector3 $myDirection$17529;

			// Token: 0x04000B73 RID: 2931
			internal UnityScript.Lang.Array $nArray$17530;

			// Token: 0x04000B74 RID: 2932
			internal WaterBug $self_$17531;
		}
	}
}
