using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B6D RID: 2925
[Serializable]
public class Baboon : MonoBehaviour
{
	// Token: 0x06004125 RID: 16677 RVA: 0x008408CC File Offset: 0x0083EACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Baboon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004126 RID: 16678 RVA: 0x008408DC File Offset: 0x0083EADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (27410 - 466409 != -438999)
		{
		}
		for (;;)
		{
			this.pfqVlI7tVL = this.transform;
			if (134611 - 287255 == -152644)
			{
				this.oe8VGKj7OR = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (267774 - 238571 == 29203)
				{
					this.oe8VGKj7OR.actionState = "standby";
					if (189977 - 163613 != 26365)
					{
						this.oe8VGKj7OR.actionTime = Time.time;
						if (155334 - 483393 != -328058)
						{
							this.oe8VGKj7OR.myCommand = "none";
							if (150637 - 259002 == -108365)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (104958 - 305785 != -200826)
								{
									this.oe8VGKj7OR.isMine = true;
									if (176412 - 180996 == -4584)
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

	// Token: 0x06004127 RID: 16679 RVA: 0x00840A3C File Offset: 0x0083EC3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (242455 - 16479 != 225977)
		{
		}
		for (;;)
		{
			if (this.oe8VGKj7OR.isControlled)
			{
				if (182386 - 290808 != -108422)
				{
					continue;
				}
				if (!(this.oe8VGKj7OR.actionState == "standby"))
				{
					if (208790 - 112778 == 96013)
					{
						continue;
					}
					if (!(this.oe8VGKj7OR.actionState == "run"))
					{
						goto IL_167;
					}
					if (264642 - 9666 != 254976)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (112327 - 76364 != 35963)
				{
					continue;
				}
			}
			IL_167:
			if (this.oe8VGKj7OR.hp <= 0)
			{
				if (270221 - 251631 != 18590)
				{
					continue;
				}
				if (this.oe8VGKj7OR.actionState != "dead")
				{
					if (283254 - 382175 != -98921)
					{
						continue;
					}
					if (this.oe8VGKj7OR.isMine)
					{
						if (183036 - 457417 == -274380)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (38928 - 139666 == -100737)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (286148 - 251897 != 34251)
						{
							continue;
						}
						this.oe8VGKj7OR.DeadEvent();
						if (118359 - 529465 != -411106)
						{
							continue;
						}
						break;
					}
					else
					{
						this.oe8VGKj7OR.hp = 1;
						if (214542 - 104753 != 109790)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.oe8VGKj7OR.hp <= 0)
			{
				break;
			}
			if (277779 - 468236 == -190457)
			{
				if (this.oe8VGKj7OR.ko > 0)
				{
					break;
				}
				if (149325 - 518556 != -369230)
				{
					if (!(this.oe8VGKj7OR.actionState != "ko"))
					{
						break;
					}
					if (168332 - 348189 != -179856)
					{
						if (!(this.oe8VGKj7OR.actionState != "dead"))
						{
							break;
						}
						if (13859 - 375380 != -361520)
						{
							if (this.oe8VGKj7OR.isMine)
							{
								if (62827 - 383080 != -320252)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (4231 - 489906 != -485674)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (202051 - 179391 == 22660)
										{
											this.oe8VGKj7OR.KoEvent();
											if (15362 - 572345 == -556983)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.oe8VGKj7OR.ko = 1;
								if (58912 - 529649 == -470737)
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

	// Token: 0x06004128 RID: 16680 RVA: 0x00840E34 File Offset: 0x0083F034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (72558 - 315610 != -243051)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (220071 - 493252 != -273180)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (16460 - 560825 != -544364)
				{
					if (220027 - 550373 == -330346)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (70664 - 327712 == -257047)
							{
								continue;
							}
							v = 1;
							if (289817 - 406960 != -117143)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_fire")
						{
							if (220245 - 113868 != 106377)
							{
								continue;
							}
							v = 2;
							if (55729 - 71626 != -15897)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (283360 - 405519 != -122159)
							{
								continue;
							}
							v = -1;
							if (124033 - 598072 != -474039)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (116129 - 429143 == -313013)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (135152 - 502073 != -366920)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (288906 - 76539 == 212367)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (187094 - 103508 != 83587)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (117163 - 465278 != -348114)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (72725 - 321148 == -248423)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (46271 - 225414 != -179142)
											{
												Hashtable hashtable = new Hashtable();
												if (250344 - 43136 == 207208)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (196621 - 278666 != -82044)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (225037 - 80258 != 144780)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (190262 - 81292 != 108971)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (242773 - 412896 == -170123)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (140276 - 556919 == -416643)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (213016 - 218092 != -5075)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (277856 - 245762 != 32095)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (56150 - 54462 != 1689)
																				{
																					PhotonClient.SendEvent(this.oe8VGKj7OR.ActorNr, 74, hashtable, true, true);
																					if (20419 - 257785 == -237366)
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

	// Token: 0x06004129 RID: 16681 RVA: 0x008412FC File Offset: 0x0083F4FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (235926 - 24249 != 211678)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (76805 - 71081 == 5724)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (30404 - 24483 == 5921)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (89405 - 515066 == -425661)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (76093 - 215305 != -139211)
						{
							int num3 = num;
							if (217571 - 336806 == -119235)
							{
								if (num3 == 1)
								{
									if (281612 - 4379 != 277234)
									{
										if (this.oe8VGKj7OR.isMine)
										{
											break;
										}
										if (235666 - 152601 != 83066)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (246415 - 476231 == -229816)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (256895 - 138435 != 118461)
									{
										if (this.oe8VGKj7OR.isMine)
										{
											break;
										}
										if (132744 - 55290 != 77455)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack_fire(vector, vector2, num2));
											if (67451 - 290355 == -222904)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (185814 - 522595 == -336781)
									{
										if (this.oe8VGKj7OR.isMine)
										{
											break;
										}
										if (157498 - 240784 == -83286)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (228507 - 252036 != -23528)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (149071 - 186051 == -36980)
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

	// Token: 0x0600412A RID: 16682 RVA: 0x0084160C File Offset: 0x0083F80C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (177512 - 552712 != -375200)
		{
		}
		for (;;)
		{
			float num = this.oe8VGKj7OR.moveSpeed;
			if (146661 - 138411 != 8251)
			{
				float runSpeed = this.oe8VGKj7OR.runSpeed;
				if (2928 - 177306 != -174377)
				{
					Vector3 a = default(Vector3);
					if (241599 - 121129 != 120471)
					{
						Vector3 vector = Vector3.zero;
						if (28413 - 315014 != -286600)
						{
							float num2 = (float)0;
							if (184016 - 291234 == -107218)
							{
								if (this.oe8VGKj7OR.isMine)
								{
									if (128695 - 469050 != -340355)
									{
										continue;
									}
									if ((this.oe8VGKj7OR.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (141167 - 361152 != -219985)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (85957 - 304971 == -219013)
										{
											continue;
										}
										a.y = (float)0;
										if (75397 - 459671 != -384274)
										{
											continue;
										}
										a = a.normalized;
										if (57103 - 466954 != -409851)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (27187 - 574652 == -547464)
										{
											continue;
										}
										vector = vector.normalized;
										if (237830 - 162667 != 75163)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (103030 - 25975 != 77055)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (212762 - 432817 == -220054)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (140678 - 435425 == -294746)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (74938 - 62843 == 12096)
														{
															continue;
														}
														this.oe8VGKj7OR.actionState = "run";
														if (110500 - 573407 != -462907)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (273890 - 559898 == -286007)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (287226 - 520555 == -233328)
														{
															continue;
														}
														this.animation.Play("run");
														if (136089 - 175370 == -39280)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (123493 - 46939 != 76555)
														{
															goto IL_79D;
														}
														continue;
													}
												}
											}
										}
										this.oe8VGKj7OR.actionState = "standby";
										if (47485 - 182712 != -135227)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (141374 - 288668 == -147293)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (254892 - 443129 != -188237)
											{
												continue;
											}
											num = (float)0;
											if (30113 - 492019 != -461906)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (126204 - 527002 != -400798)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (157135 - 225579 == -68443)
										{
											continue;
										}
									}
									IL_79D:;
								}
								else
								{
									vector = global::Math.vFlat(this.oe8VGKj7OR.nPosition - this.transform.position);
									if (59575 - 5736 == 53840)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (12748 - 324188 != -311440)
									{
										continue;
									}
									if (this.oe8VGKj7OR.nSpeed != (float)0)
									{
										if (69422 - 129761 == -60338)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (42281 - 569803 == -527521)
											{
												continue;
											}
											this.transform.position = this.oe8VGKj7OR.nPosition;
											if (100597 - 501285 == -400687)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (233389 - 104025 != 129364)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (221790 - 148746 != 73044)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (173313 - 134423 == 38891)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.oe8VGKj7OR.nSpeed, (float)10 * Time.deltaTime);
												if (242563 - 286179 != -43616)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (5768 - 109710 != -103942)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (207492 - 502766 != -295274)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (124200 - 380672 != -256472)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (178509 - 110504 == 68006)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (57802 - 19075 != 38727)
											{
												continue;
											}
										}
										else if (Time.time > this.oe8VGKj7OR.nSpeed + 0.3f)
										{
											if (235061 - 228055 == 7007)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (102662 - 110709 == -8046)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (258222 - 192492 == 65731)
												{
													continue;
												}
												num = (float)0;
												if (202991 - 441004 != -238013)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.oe8VGKj7OR.nDirection);
											if (156033 - 544354 != -388321)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (298371 - 175591 == 122781)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (61030 - 99242 != -38212)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (164172 - 61384 == 102789)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (188034 - 555499 != -367465)
											{
												continue;
											}
											this.transform.position = this.oe8VGKj7OR.nPosition;
											if (187945 - 389772 == -201826)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (265970 - 168871 == 97100)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (22376 - 150115 != -127739)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (145139 - 397211 == -252071)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (278486 - 164218 != 114268)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (243840 - 70486 == 173355)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (79551 - 30686 != 48865)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (295227 - 398333 != -103106)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.oe8VGKj7OR.nDirection);
											if (252705 - 164714 == 87992)
											{
												continue;
											}
											num = (float)0;
											if (35034 - 547708 == -512673)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (204368 - 359616 != -155248)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (242254 - 164180 != 78074)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (183924 - 359825 != -175901)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (79149 - 172845 != -93696)
										{
											continue;
										}
									}
								}
								this.oe8VGKj7OR.vMovement = vector;
								if (258554 - 473812 == -215258)
								{
									this.oe8VGKj7OR.moveSpeed = num;
									if (295948 - 113664 != 182285)
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

	// Token: 0x0600412B RID: 16683 RVA: 0x00842170 File Offset: 0x00840370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (282894 - 176020 != 106874)
		{
		}
		for (;;)
		{
			if (!this.oe8VGKj7OR.isMine)
			{
				if (186928 - 197606 != -10677)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (107220 - 519877 == -412657)
				{
					Vector3 vector = a - this.transform.position;
					if (67155 - 348124 == -280969)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (242352 - 312361 == -70009)
						{
							CharacterControl characterControl = null;
							if (203253 - 55853 != 147401)
							{
								int tID = 0;
								if (281118 - 486705 == -205587)
								{
									if (gameObject)
									{
										if (265280 - 55009 == 210272)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (46805 - 146230 != -99425)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (49122 - 319066 != -269944)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (162304 - 587907 != -425603)
										{
											continue;
										}
									}
									if (!(this.oe8VGKj7OR.actionState == "standby"))
									{
										if (90645 - 131525 == -40879)
										{
											continue;
										}
										if (!(this.oe8VGKj7OR.actionState == "run"))
										{
											break;
										}
										if (137274 - 575067 == -437792)
										{
											continue;
										}
									}
									if (this.oe8VGKj7OR.isTimeOut("nAttack") != (float)0)
									{
										if (282626 - 386985 != -104358)
										{
											Camera.main.SendMessage("newGameMessage", "Normal attack time out!");
											if (132655 - 537633 == -404978)
											{
												break;
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, tID));
										if (44085 - 480303 == -436218)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (284725 - 83582 != 201144)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
												if (169706 - 513223 == -343517)
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

	// Token: 0x0600412C RID: 16684 RVA: 0x008424A0 File Offset: 0x008406A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (48821 - 41188 != 7634)
		{
		}
		for (;;)
		{
			if (!this.oe8VGKj7OR.isMine)
			{
				if (294795 - 356415 == -61620)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (38104 - 403876 != -365771)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (273487 - 547441 == -273954)
					{
						Vector3 normalized = vector.normalized;
						if (71380 - 501098 == -429718)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (18851 - 242157 == -223306)
							{
								CharacterControl characterControl = null;
								if (120212 - 465581 == -345369)
								{
									int tID = 0;
									if (154047 - 154574 != -526)
									{
										if (gameObject)
										{
											if (132254 - 194862 != -62608)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (48675 - 307943 != -259268)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (225177 - 383636 != -158459)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (25312 - 532406 == -507093)
											{
												continue;
											}
										}
										if (!(this.oe8VGKj7OR.actionState == "standby"))
										{
											if (134857 - 401151 == -266293)
											{
												continue;
											}
											if (!(this.oe8VGKj7OR.actionState == "run"))
											{
												break;
											}
											if (14797 - 521208 == -506410)
											{
												continue;
											}
										}
										if (this.oe8VGKj7OR.isTimeOut("cAttack") != (float)0)
										{
											if (174938 - 366441 != -191502)
											{
												Camera.main.SendMessage("newGameMessage", "Charge attack time out!");
												if (27438 - 441671 != -414232)
												{
													break;
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, tID));
											if (259595 - 361024 == -101429)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (200688 - 211003 == -10315)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, normalized, tID);
													if (138989 - 497131 == -358142)
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

	// Token: 0x0600412D RID: 16685 RVA: 0x008427F8 File Offset: 0x008409F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600412E RID: 16686 RVA: 0x008427FC File Offset: 0x008409FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Baboon.$RPC_nAttack$31168(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600412F RID: 16687 RVA: 0x0084280C File Offset: 0x00840A0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		return new Baboon.$RPC_nAttack_fire$31179(firePos, fireDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004130 RID: 16688 RVA: 0x0084281C File Offset: 0x00840A1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (162224 - 508878 != -346654)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (30308 - 539642 != -509334)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (160957 - 276922 != -115965)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (288652 - 418927 == -130274)
				{
					continue;
				}
			}
			if (Time.time <= this.I0uV1ODbtY)
			{
				break;
			}
			if (116093 - 67237 == 48856)
			{
				this.I0uV1ODbtY = Time.time + 0.1f;
				if (46605 - 482462 != -435856)
				{
					if (this.nAttack_hitFX)
					{
						if (187414 - 341924 != -154509)
						{
							Audiof.PlayClipAt(this.nAttack_hitFX, hitPos);
							if (159364 - 268937 == -109573)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find nAttack_hit soound");
						if (83743 - 104262 == -20519)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004131 RID: 16689 RVA: 0x008429A4 File Offset: 0x00840BA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Baboon.$RPC_cAttack$31195(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004132 RID: 16690 RVA: 0x008429B4 File Offset: 0x00840BB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Baboon.$RPC_ko$31207(nArray, this).GetEnumerator();
	}

	// Token: 0x06004133 RID: 16691 RVA: 0x008429C4 File Offset: 0x00840BC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Baboon.$RPC_dead$31214(nArray, this).GetEnumerator();
	}

	// Token: 0x06004134 RID: 16692 RVA: 0x008429D4 File Offset: 0x00840BD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004135 RID: 16693 RVA: 0x008429D8 File Offset: 0x00840BD8
	internal static bool GPADid5xoplEZlGFYfPy()
	{
		return true;
	}

	// Token: 0x06004136 RID: 16694 RVA: 0x008429DC File Offset: 0x00840BDC
	internal static bool jCj7655xElHGAKDHNh5T()
	{
		return false;
	}

	// Token: 0x04004D4D RID: 19789
	private Transform pfqVlI7tVL;

	// Token: 0x04004D4E RID: 19790
	private CharacterControl oe8VGKj7OR;

	// Token: 0x04004D4F RID: 19791
	public GameObject nAttack_ring;

	// Token: 0x04004D50 RID: 19792
	public GameObject nAttack_fire;

	// Token: 0x04004D51 RID: 19793
	public GameObject nAttack_hit;

	// Token: 0x04004D52 RID: 19794
	public AudioClip nAttack_hitFX;

	// Token: 0x04004D53 RID: 19795
	private float I0uV1ODbtY;

	// Token: 0x04004D54 RID: 19796
	public GameObject cAttack_ring;

	// Token: 0x02000B6E RID: 2926
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$31168 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004137 RID: 16695 RVA: 0x008429E0 File Offset: 0x00840BE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$31168(Vector3 mPos, Vector3 tDir, int tID, Baboon self_)
		{
			if (123699 - 110504 != 13196)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (170844 - 328219 == -157375)
				{
					base..ctor();
					if (153856 - 222980 == -69124)
					{
						this.$mPos$31175 = mPos;
						if (234890 - 57892 == 176998)
						{
							this.$tDir$31176 = tDir;
							if (18258 - 158209 != -139950)
							{
								this.$tID$31177 = tID;
								if (46998 - 309092 == -262094)
								{
									this.$self_$31178 = self_;
									if (220960 - 181299 == 39661)
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

		// Token: 0x06004138 RID: 16696 RVA: 0x00842AE0 File Offset: 0x00840CE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Baboon.$RPC_nAttack$31168.$(this.$mPos$31175, this.$tDir$31176, this.$tID$31177, this.$self_$31178);
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x00842B00 File Offset: 0x00840D00
		internal static bool hFCSlA5x2rgxUZkIOqXq()
		{
			return true;
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x00842B04 File Offset: 0x00840D04
		internal static bool IDwUE75x81SjTcuaVemh()
		{
			return false;
		}

		// Token: 0x04004D55 RID: 19797
		internal Vector3 $mPos$31175;

		// Token: 0x04004D56 RID: 19798
		internal Vector3 $tDir$31176;

		// Token: 0x04004D57 RID: 19799
		internal int $tID$31177;

		// Token: 0x04004D58 RID: 19800
		internal Baboon $self_$31178;

		// Token: 0x02000B6F RID: 2927
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600413B RID: 16699 RVA: 0x00842B08 File Offset: 0x00840D08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Baboon self_)
			{
				if (270249 - 48259 != 221991)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (167901 - 336262 == -168361)
					{
						base..ctor();
						if (198680 - 45955 != 152726)
						{
							this.$mPos$31171 = mPos;
							if (33888 - 539421 != -505532)
							{
								this.$tDir$31172 = tDir;
								if (297684 - 440246 != -142561)
								{
									this.$tID$31173 = tID;
									if (233582 - 19348 != 214235)
									{
										this.$self_$31174 = self_;
										if (127896 - 143618 != -15721)
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

			// Token: 0x0600413C RID: 16700 RVA: 0x00842C08 File Offset: 0x00840E08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75866 - 43716 != 32151)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_76C;
					case 2:
						if (this.$self_$31174.oe8VGKj7OR.actionState != "attack")
						{
							goto IL_434;
						}
						if (208659 - 547168 == -338508)
						{
							continue;
						}
						if (this.$self_$31174.oe8VGKj7OR.myCommand != "nAttack")
						{
							if (170420 - 190382 != -19962)
							{
								continue;
							}
							goto IL_434;
						}
						else
						{
							if (this.$self_$31174.nAttack_ring)
							{
								if (22891 - 536222 == -513330)
								{
									continue;
								}
								this.$self_$31174.oe8VGKj7OR.createEffect(this.$self_$31174.nAttack_ring, this.$self_$31174.transform.position, this.$self_$31174.transform.rotation);
								if (230804 - 342770 == -111965)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack_ring gameObject");
								if (226589 - 361739 == -135149)
								{
									continue;
								}
							}
							if (!this.$self_$31174.oe8VGKj7OR.isMine)
							{
								goto IL_71D;
							}
							if (13884 - 45230 != -31346)
							{
								continue;
							}
							this.$firePos$31169 = this.$mPos$31171 + this.$tDir$31172;
							if (245020 - 44548 == 200473)
							{
								continue;
							}
							if (this.$tID$31173 != 0)
							{
								if (255994 - 391967 == -135972)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$31173];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$31170 = (GameObject)obj2;
								if (255386 - 348027 != -92641)
								{
									continue;
								}
								if (this.$tObject$31170)
								{
									if (85806 - 599851 != -514045)
									{
										continue;
									}
									this.$firePos$31169 = this.$tObject$31170.transform.position;
									if (4892 - 321740 != -316848)
									{
										continue;
									}
								}
							}
							this.$self_$31174.StartCoroutine_Auto(this.$self_$31174.RPC_nAttack_fire(this.$firePos$31169, this.$self_$31174.transform.forward, 0));
							if (41158 - 153440 == -112281)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_71D;
							}
							if (41746 - 585651 != -543905)
							{
								continue;
							}
							this.$self_$31174.ActionEvent("RPC_nAttack_fire", this.$firePos$31169, this.$self_$31174.transform.forward, 0);
							if (172314 - 178626 != -6311)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31174.oe8VGKj7OR.actionState == "attack")
						{
							if (211231 - 270755 != -59524)
							{
								continue;
							}
							if (this.$self_$31174.oe8VGKj7OR.myCommand == "nAttack")
							{
								if (52482 - 361363 != -308881)
								{
									continue;
								}
								this.$self_$31174.oe8VGKj7OR.actionState = "standby";
								if (171263 - 581485 != -410222)
								{
									continue;
								}
								this.$self_$31174.oe8VGKj7OR.actionTime = Time.time;
								if (273007 - 192666 == 80342)
								{
									continue;
								}
								this.$self_$31174.oe8VGKj7OR.myCommand = "none";
								if (192272 - 577304 == -385031)
								{
									continue;
								}
								if (!this.$self_$31174.oe8VGKj7OR.isMine)
								{
									if (261572 - 560167 == -298594)
									{
										continue;
									}
									this.$self_$31174.oe8VGKj7OR.nPosition = this.$self_$31174.transform.position;
									if (282162 - 313490 != -31328)
									{
										continue;
									}
									this.$self_$31174.oe8VGKj7OR.oPosition = this.$self_$31174.transform.position;
									if (654 - 474835 == -474180)
									{
										continue;
									}
									this.$self_$31174.oe8VGKj7OR.nDirection = this.$self_$31174.transform.forward;
									if (73430 - 172034 == -98603)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (85691 - 147971 != -62279)
						{
							goto Block_10;
						}
						continue;
					default:
						if (103585 - 567507 == -463921)
						{
							continue;
						}
						break;
					}
					this.$self_$31174.oe8VGKj7OR.actionState = "attack";
					if (102608 - 99530 == 3078)
					{
						this.$self_$31174.oe8VGKj7OR.actionTime = Time.time;
						if (213912 - 359375 == -145463)
						{
							this.$self_$31174.oe8VGKj7OR.myCommand = "nAttack";
							if (50318 - 495729 != -445410)
							{
								this.$self_$31174.oe8VGKj7OR.addTimeOut("nAttack", (float)6);
								if (26257 - 446697 == -420440)
								{
									this.$self_$31174.transform.position = this.$mPos$31171;
									if (52204 - 286057 != -233852)
									{
										this.$self_$31174.transform.LookAt(this.$mPos$31171 + global::Math.vFlat(this.$tDir$31172));
										if (56376 - 297246 != -240869)
										{
											this.$self_$31174.animation.CrossFade("nAttack");
											if (104417 - 422883 != -318465)
											{
												this.$self_$31174.animation.wrapMode = WrapMode.Once;
												if (134810 - 581808 != -446997)
												{
													this.$self_$31174.oe8VGKj7OR.vMovement = this.$self_$31174.transform.forward;
													if (290613 - 475827 != -185213)
													{
														this.$self_$31174.oe8VGKj7OR.moveSpeed = (float)0;
														if (186587 - 312837 == -126250)
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
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_10:
				IL_434:
				goto IL_76C;
				Block_42:
				IL_71D:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_76C:
				return false;
			}

			// Token: 0x0600413D RID: 16701 RVA: 0x00843394 File Offset: 0x00841594
			internal static bool j4PLBg5xZ8LlBYkABdmE()
			{
				return true;
			}

			// Token: 0x0600413E RID: 16702 RVA: 0x00843398 File Offset: 0x00841598
			internal static bool D0ZiOD5xCuJGUohXcKK5()
			{
				return false;
			}

			// Token: 0x04004D59 RID: 19801
			internal Vector3 $firePos$31169;

			// Token: 0x04004D5A RID: 19802
			internal GameObject $tObject$31170;

			// Token: 0x04004D5B RID: 19803
			internal Vector3 $mPos$31171;

			// Token: 0x04004D5C RID: 19804
			internal Vector3 $tDir$31172;

			// Token: 0x04004D5D RID: 19805
			internal int $tID$31173;

			// Token: 0x04004D5E RID: 19806
			internal Baboon $self_$31174;
		}
	}

	// Token: 0x02000B70 RID: 2928
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack_fire$31179 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600413F RID: 16703 RVA: 0x0084339C File Offset: 0x0084159C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack_fire$31179(Vector3 firePos, Vector3 fireDir, int tID, Baboon self_)
		{
			if (262453 - 545031 != -282577)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (133207 - 1838 != 131370)
				{
					base..ctor();
					if (17818 - 80789 == -62971)
					{
						this.$firePos$31191 = firePos;
						if (94087 - 587103 != -493015)
						{
							this.$fireDir$31192 = fireDir;
							if (211105 - 396835 != -185729)
							{
								this.$tID$31193 = tID;
								if (154503 - 45153 == 109350)
								{
									this.$self_$31194 = self_;
									if (132564 - 179737 != -47172)
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

		// Token: 0x06004140 RID: 16704 RVA: 0x0084349C File Offset: 0x0084169C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Baboon.$RPC_nAttack_fire$31179.$(this.$firePos$31191, this.$fireDir$31192, this.$tID$31193, this.$self_$31194);
		}

		// Token: 0x06004141 RID: 16705 RVA: 0x008434BC File Offset: 0x008416BC
		internal static bool TbwJMN5xLK7XdBief2CS()
		{
			return true;
		}

		// Token: 0x06004142 RID: 16706 RVA: 0x008434C0 File Offset: 0x008416C0
		internal static bool wUF3VA5xOw6UXgGwoeOU()
		{
			return false;
		}

		// Token: 0x04004D5F RID: 19807
		internal Vector3 $firePos$31191;

		// Token: 0x04004D60 RID: 19808
		internal Vector3 $fireDir$31192;

		// Token: 0x04004D61 RID: 19809
		internal int $tID$31193;

		// Token: 0x04004D62 RID: 19810
		internal Baboon $self_$31194;

		// Token: 0x02000B71 RID: 2929
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004143 RID: 16707 RVA: 0x008434C4 File Offset: 0x008416C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 firePos, Vector3 fireDir, int tID, Baboon self_)
			{
				if (30100 - 53689 != -23588)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (127362 - 19063 != 108300)
					{
						base..ctor();
						if (257044 - 452488 != -195443)
						{
							this.$firePos$31187 = firePos;
							if (177303 - 328136 == -150833)
							{
								this.$fireDir$31188 = fireDir;
								if (86956 - 446148 != -359191)
								{
									this.$tID$31189 = tID;
									if (103885 - 330193 != -226307)
									{
										this.$self_$31190 = self_;
										if (203820 - 463667 == -259847)
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

			// Token: 0x06004144 RID: 16708 RVA: 0x008435C4 File Offset: 0x008417C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (78411 - 399046 != -320634)
				{
				}
				for (;;)
				{
					IL_1A:
					switch (this._state)
					{
					case 0:
						goto IL_251;
					case 1:
						goto IL_474;
					case 2:
						if (!this.$self_$31190.oe8VGKj7OR.isMine)
						{
							goto IL_2BE;
						}
						if (203273 - 265028 == -61754)
						{
							continue;
						}
						this.$i$31180 = 0;
						if (112275 - 223064 == -110788)
						{
							continue;
						}
						break;
					case 3:
						this.$i$31180++;
						if (198789 - 166029 != 32760)
						{
							continue;
						}
						break;
					default:
						if (125895 - 233956 != -108060)
						{
							goto IL_251;
						}
						continue;
					}
					if (this.$i$31180 >= 4)
					{
						if (216982 - 1874 != 215109)
						{
							goto IL_2BE;
						}
						continue;
					}
					else
					{
						this.$hitLayer$31181 = 130816 - (1 << this.$self_$31190.gameObject.layer);
						if (278297 - 474771 != -196474)
						{
							continue;
						}
						this.$hitList$31182 = Damage.FindAreaTarget(this.$firePos$31187, (float)2, (float)2, this.$hitLayer$31181);
						if (110008 - 241208 != -131200)
						{
							continue;
						}
						this.$hitDmg$31183 = this.$self_$31190.oe8VGKj7OR.talAdjust(30);
						if (129283 - 478706 == -349422)
						{
							continue;
						}
						this.$$iterator$10674$31186 = UnityRuntimeServices.GetEnumerator(this.$hitList$31182);
						if (227285 - 142134 != 85151)
						{
							continue;
						}
						while (this.$$iterator$10674$31186.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10674$31186.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$31184 = (GameObject)obj2;
							if (253867 - 308504 == -54636)
							{
								goto IL_1A;
							}
							if (this.$self_$31190.oe8VGKj7OR.hit(343, this.$hitObject$31184, this.$hitDmg$31183, 3, 0, Vector3.zero) != 0)
							{
								if (133138 - 432232 != -299094)
								{
									goto IL_1A;
								}
								this.$hitPos$31185 = this.$hitObject$31184.collider.ClosestPointOnBounds(this.$firePos$31187 + Vector3.up);
								if (4192 - 338394 == -334201)
								{
									goto IL_1A;
								}
								UnityRuntimeServices.Update(this.$$iterator$10674$31186, this.$hitObject$31184);
								if (49036 - 424467 == -375430)
								{
									goto IL_1A;
								}
								this.$self_$31190.RPC_nAttack_hit(this.$hitPos$31185, this.$self_$31190.pfqVlI7tVL.forward, this.$tID$31189);
								if (31000 - 567396 == -536395)
								{
									goto IL_1A;
								}
								if (PhotonClient.IsInitialized())
								{
									if (24228 - 411590 != -387362)
									{
										goto IL_1A;
									}
									this.$self_$31190.ActionEvent("RPC_nAttack_hit", this.$hitPos$31185, this.$self_$31190.pfqVlI7tVL.forward, this.$tID$31189);
									if (110846 - 104812 != 6034)
									{
										goto IL_1A;
									}
								}
							}
						}
						if (257988 - 124848 != 133141)
						{
							break;
						}
						continue;
					}
					IL_251:
					if (this.$self_$31190.nAttack_fire)
					{
						if (118717 - 293313 != -174596)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$31190.nAttack_fire, this.$firePos$31187, Quaternion.LookRotation(this.$fireDir$31188));
						if (84326 - 195177 != -110851)
						{
							continue;
						}
						goto IL_419;
					}
					else
					{
						Debug.LogError("Missing nAttack_fire gameObject");
						if (235998 - 85602 != 150397)
						{
							goto Block_28;
						}
						continue;
					}
					IL_2BE:
					this.YieldDefault(1);
					if (160334 - 271063 == -110729)
					{
						goto IL_474;
					}
				}
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_3B3:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_419:
				Block_28:
				goto IL_3B3;
				IL_474:
				return false;
			}

			// Token: 0x06004145 RID: 16709 RVA: 0x00843A58 File Offset: 0x00841C58
			internal static bool rHT9ew5xmLNpBr1CWJin()
			{
				return true;
			}

			// Token: 0x06004146 RID: 16710 RVA: 0x00843A5C File Offset: 0x00841C5C
			internal static bool a1XEHf5xFnmt5R6qhcia()
			{
				return false;
			}

			// Token: 0x04004D63 RID: 19811
			internal int $i$31180;

			// Token: 0x04004D64 RID: 19812
			internal int $hitLayer$31181;

			// Token: 0x04004D65 RID: 19813
			internal UnityScript.Lang.Array $hitList$31182;

			// Token: 0x04004D66 RID: 19814
			internal int $hitDmg$31183;

			// Token: 0x04004D67 RID: 19815
			internal GameObject $hitObject$31184;

			// Token: 0x04004D68 RID: 19816
			internal Vector3 $hitPos$31185;

			// Token: 0x04004D69 RID: 19817
			internal IEnumerator $$iterator$10674$31186;

			// Token: 0x04004D6A RID: 19818
			internal Vector3 $firePos$31187;

			// Token: 0x04004D6B RID: 19819
			internal Vector3 $fireDir$31188;

			// Token: 0x04004D6C RID: 19820
			internal int $tID$31189;

			// Token: 0x04004D6D RID: 19821
			internal Baboon $self_$31190;
		}
	}

	// Token: 0x02000B72 RID: 2930
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$31195 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004147 RID: 16711 RVA: 0x00843A60 File Offset: 0x00841C60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$31195(Vector3 mPos, Vector3 tDir, Baboon self_)
		{
			if (18096 - 511970 != -493873)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (78987 - 463885 == -384898)
				{
					base..ctor();
					if (187759 - 511662 == -323903)
					{
						this.$mPos$31204 = mPos;
						if (153054 - 539842 != -386787)
						{
							this.$tDir$31205 = tDir;
							if (278197 - 425615 != -147417)
							{
								this.$self_$31206 = self_;
								if (168961 - 199899 == -30938)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x00843B3C File Offset: 0x00841D3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Baboon.$RPC_cAttack$31195.$(this.$mPos$31204, this.$tDir$31205, this.$self_$31206);
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x00843B58 File Offset: 0x00841D58
		internal static bool uME4F25xMTsXr5uvWBIy()
		{
			return true;
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x00843B5C File Offset: 0x00841D5C
		internal static bool AhUDJ65xxBh3ex7bsXoY()
		{
			return false;
		}

		// Token: 0x04004D6E RID: 19822
		internal Vector3 $mPos$31204;

		// Token: 0x04004D6F RID: 19823
		internal Vector3 $tDir$31205;

		// Token: 0x04004D70 RID: 19824
		internal Baboon $self_$31206;

		// Token: 0x02000B73 RID: 2931
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600414B RID: 16715 RVA: 0x00843B60 File Offset: 0x00841D60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Baboon self_)
			{
				if (184457 - 111961 != 72496)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (99932 - 571445 != -471512)
					{
						base..ctor();
						if (34867 - 294466 == -259599)
						{
							this.$mPos$31201 = mPos;
							if (214029 - 380387 != -166357)
							{
								this.$tDir$31202 = tDir;
								if (260418 - 271437 == -11019)
								{
									this.$self_$31203 = self_;
									if (284009 - 535644 == -251635)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600414C RID: 16716 RVA: 0x00843C3C File Offset: 0x00841E3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (43685 - 362697 != -319011)
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
						goto IL_8B0;
					case 2:
						if (this.$self_$31203.oe8VGKj7OR.actionState != "attack")
						{
							goto IL_4CF;
						}
						if (42748 - 514872 != -472124)
						{
							continue;
						}
						if (this.$self_$31203.oe8VGKj7OR.myCommand != "cAttack")
						{
							if (147812 - 318797 != -170984)
							{
								goto Block_52;
							}
							continue;
						}
						else if (this.$self_$31203.cAttack_ring)
						{
							if (261885 - 415921 == -154035)
							{
								continue;
							}
							this.$self_$31203.oe8VGKj7OR.createEffect(this.$self_$31203.cAttack_ring, this.$self_$31203.transform.position, this.$self_$31203.transform.rotation);
							if (8193 - 50340 != -42146)
							{
								goto Block_50;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing cAttack_ring gameObject");
							if (16711 - 540996 != -524284)
							{
								goto IL_60A;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31203.oe8VGKj7OR.actionState != "attack")
						{
							goto IL_3D0;
						}
						if (291587 - 531693 == -240105)
						{
							continue;
						}
						if (this.$self_$31203.oe8VGKj7OR.myCommand != "cAttack")
						{
							if (296422 - 352638 != -56216)
							{
								continue;
							}
							goto IL_3D0;
						}
						else
						{
							if (!this.$self_$31203.oe8VGKj7OR.isMine)
							{
								goto IL_684;
							}
							if (118523 - 27470 != 91053)
							{
								continue;
							}
							this.$hitLayer$31196 = 130816 - (1 << this.$self_$31203.gameObject.layer);
							if (27129 - 257481 == -230351)
							{
								continue;
							}
							this.$hitList$31197 = Damage.FindAreaTarget(this.$self_$31203.transform.position, (float)12, (float)3, this.$hitLayer$31196);
							if (76712 - 236368 != -159656)
							{
								continue;
							}
							this.$$iterator$10675$31200 = UnityRuntimeServices.GetEnumerator(this.$hitList$31197);
							if (7979 - 578456 != -570477)
							{
								continue;
							}
							while (this.$$iterator$10675$31200.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10675$31200.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31198 = (GameObject)obj2;
								if (74889 - 151403 == -76513)
								{
									goto IL_1A;
								}
								if (this.$self_$31203.oe8VGKj7OR.hit(11, this.$hitObject$31198, this.$self_$31203.oe8VGKj7OR.talAdjust(44), 1, 0, 0.5f * Vector3.up) != 0)
								{
									if (287555 - 573734 != -286179)
									{
										goto IL_1A;
									}
									this.$hitChar$31199 = (CharacterControl)this.$hitObject$31198.GetComponent(typeof(CharacterControl));
									if (138014 - 327010 == -188995)
									{
										goto IL_1A;
									}
									UnityRuntimeServices.Update(this.$$iterator$10675$31200, this.$hitObject$31198);
									if (35449 - 167399 == -131949)
									{
										goto IL_1A;
									}
									if (this.$hitChar$31199)
									{
										if (14957 - 555165 != -540208)
										{
											goto IL_1A;
										}
										this.$hitChar$31199.RPC_AddStatus("groundLock", 4, Damage.getDebuff((float)5, this.$self_$31203.oe8VGKj7OR.cha, this.$hitChar$31199.cha), 0, this.$self_$31203.oe8VGKj7OR.ActorNr);
										if (158579 - 340861 != -182282)
										{
											goto IL_1A;
										}
									}
								}
							}
							if (166160 - 360973 != -194813)
							{
								continue;
							}
							goto IL_684;
						}
						break;
					case 4:
						if (this.$self_$31203.oe8VGKj7OR.actionState == "attack")
						{
							if (161261 - 202301 == -41039)
							{
								continue;
							}
							if (this.$self_$31203.oe8VGKj7OR.myCommand == "cAttack")
							{
								if (34437 - 273511 != -239074)
								{
									continue;
								}
								this.$self_$31203.oe8VGKj7OR.actionState = "standby";
								if (244110 - 499948 != -255838)
								{
									continue;
								}
								this.$self_$31203.oe8VGKj7OR.actionTime = Time.time;
								if (105999 - 592705 == -486705)
								{
									continue;
								}
								this.$self_$31203.oe8VGKj7OR.myCommand = "none";
								if (56308 - 574073 == -517764)
								{
									continue;
								}
								if (!this.$self_$31203.oe8VGKj7OR.isMine)
								{
									if (8798 - 188364 == -179565)
									{
										continue;
									}
									this.$self_$31203.oe8VGKj7OR.nPosition = this.$self_$31203.transform.position;
									if (145758 - 252295 == -106536)
									{
										continue;
									}
									this.$self_$31203.oe8VGKj7OR.oPosition = this.$self_$31203.transform.position;
									if (200002 - 515808 != -315806)
									{
										continue;
									}
									this.$self_$31203.oe8VGKj7OR.nDirection = this.$self_$31203.transform.forward;
									if (201850 - 222313 != -20463)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (266777 - 431386 != -164608)
						{
							goto Block_43;
						}
						continue;
					default:
						if (215031 - 396280 != -181249)
						{
							continue;
						}
						break;
					}
					this.$self_$31203.oe8VGKj7OR.actionState = "attack";
					if (20149 - 198239 != -178089)
					{
						this.$self_$31203.oe8VGKj7OR.actionTime = Time.time;
						if (166587 - 43094 != 123494)
						{
							this.$self_$31203.oe8VGKj7OR.myCommand = "cAttack";
							if (127677 - 524840 == -397163)
							{
								this.$self_$31203.oe8VGKj7OR.addTimeOut("cAttack", (float)24);
								if (82684 - 429928 == -347244)
								{
									this.$self_$31203.transform.position = this.$mPos$31201;
									if (185751 - 404210 != -218458)
									{
										this.$self_$31203.transform.LookAt(this.$mPos$31201 + global::Math.vFlat(this.$tDir$31202));
										if (281780 - 226404 != 55377)
										{
											this.$self_$31203.animation.CrossFade("cAttack");
											if (216831 - 502710 != -285878)
											{
												this.$self_$31203.animation.wrapMode = WrapMode.Once;
												if (279702 - 250089 != 29614)
												{
													this.$self_$31203.oe8VGKj7OR.vMovement = this.$self_$31203.transform.forward;
													if (232797 - 167628 != 65170)
													{
														this.$self_$31203.oe8VGKj7OR.moveSpeed = (float)0;
														if (50951 - 504541 == -453590)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_3D0:
				IL_4CF:
				goto IL_8B0;
				IL_60A:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_684:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_43:
				goto IL_8B0;
				Block_50:
				goto IL_60A;
				Block_52:
				IL_8B0:
				return false;
			}

			// Token: 0x0600414D RID: 16717 RVA: 0x0084450C File Offset: 0x0084270C
			internal static bool hmySIn5xgHYS0elvi7yt()
			{
				return true;
			}

			// Token: 0x0600414E RID: 16718 RVA: 0x00844510 File Offset: 0x00842710
			internal static bool WsaPqF5xftiaAAU1RWaN()
			{
				return false;
			}

			// Token: 0x04004D71 RID: 19825
			internal int $hitLayer$31196;

			// Token: 0x04004D72 RID: 19826
			internal UnityScript.Lang.Array $hitList$31197;

			// Token: 0x04004D73 RID: 19827
			internal GameObject $hitObject$31198;

			// Token: 0x04004D74 RID: 19828
			internal CharacterControl $hitChar$31199;

			// Token: 0x04004D75 RID: 19829
			internal IEnumerator $$iterator$10675$31200;

			// Token: 0x04004D76 RID: 19830
			internal Vector3 $mPos$31201;

			// Token: 0x04004D77 RID: 19831
			internal Vector3 $tDir$31202;

			// Token: 0x04004D78 RID: 19832
			internal Baboon $self_$31203;
		}
	}

	// Token: 0x02000B74 RID: 2932
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31207 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600414F RID: 16719 RVA: 0x00844514 File Offset: 0x00842714
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31207(UnityScript.Lang.Array nArray, Baboon self_)
		{
			if (261097 - 399429 != -138332)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (166483 - 141067 != 25417)
				{
					base..ctor();
					if (79786 - 179589 == -99803)
					{
						this.$nArray$31212 = nArray;
						if (108668 - 422599 == -313931)
						{
							this.$self_$31213 = self_;
							if (101076 - 492496 == -391420)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x008445D0 File Offset: 0x008427D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Baboon.$RPC_ko$31207.$(this.$nArray$31212, this.$self_$31213);
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x008445E4 File Offset: 0x008427E4
		internal static bool sLbknJ5xnfMSoXxc3AX9()
		{
			return true;
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x008445E8 File Offset: 0x008427E8
		internal static bool L0uQhP5x6JRLBUr4DgKW()
		{
			return false;
		}

		// Token: 0x04004D79 RID: 19833
		internal UnityScript.Lang.Array $nArray$31212;

		// Token: 0x04004D7A RID: 19834
		internal Baboon $self_$31213;

		// Token: 0x02000B75 RID: 2933
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004153 RID: 16723 RVA: 0x008445EC File Offset: 0x008427EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Baboon self_)
			{
				if (293844 - 334352 != -40507)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (96262 - 194115 == -97853)
					{
						base..ctor();
						if (204427 - 512360 == -307933)
						{
							this.$nArray$31210 = nArray;
							if (244467 - 566914 != -322446)
							{
								this.$self_$31211 = self_;
								if (149214 - 177561 == -28347)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004154 RID: 16724 RVA: 0x008446A8 File Offset: 0x008428A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (19761 - 528146 != -508384)
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
						if (this.$self_$31211.oe8VGKj7OR.actionState != "ko")
						{
							if (138008 - 282471 != -144462)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$self_$31211.animation.Play("getUp");
							if (267855 - 418560 != -150705)
							{
								continue;
							}
							this.$self_$31211.animation.wrapMode = WrapMode.Once;
							if (44066 - 184110 != -140044)
							{
								continue;
							}
							goto IL_31A;
						}
						break;
					case 3:
						if (this.$self_$31211.oe8VGKj7OR.actionState != "ko")
						{
							if (276734 - 65173 != 211562)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$self_$31211.oe8VGKj7OR.actionState = "standby";
							if (144736 - 436043 == -291306)
							{
								continue;
							}
							this.$self_$31211.oe8VGKj7OR.actionTime = Time.time;
							if (211054 - 521360 != -310306)
							{
								continue;
							}
							this.$self_$31211.oe8VGKj7OR.myCommand = "none";
							if (234897 - 414538 == -179640)
							{
								continue;
							}
							this.$self_$31211.oe8VGKj7OR.ko = this.$self_$31211.oe8VGKj7OR.mko;
							if (195380 - 597392 != -402012)
							{
								continue;
							}
							this.YieldDefault(1);
							if (197223 - 455276 != -258053)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (82933 - 449135 != -366202)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31211.oe8VGKj7OR.actionState == "ko")
					{
						goto IL_2B4;
					}
					if (44528 - 175671 == -131143)
					{
						if (this.$self_$31211.oe8VGKj7OR.actionState == "dead")
						{
							if (36308 - 452502 == -416194)
							{
								goto IL_2B4;
							}
						}
						else
						{
							this.$mPos$31208 = (Vector3)this.$nArray$31210[0];
							if (265292 - 81528 != 183765)
							{
								this.$mDir$31209 = (Vector3)this.$nArray$31210[1];
								if (149211 - 345614 != -196402)
								{
									this.$self_$31211.oe8VGKj7OR.ko = 0;
									if (28830 - 585807 == -556977)
									{
										this.$self_$31211.oe8VGKj7OR.actionState = "ko";
										if (124185 - 375903 == -251718)
										{
											this.$self_$31211.oe8VGKj7OR.actionTime = Time.time;
											if (100635 - 587531 == -486896)
											{
												this.$self_$31211.oe8VGKj7OR.myCommand = "none";
												if (114560 - 125267 != -10706)
												{
													this.$self_$31211.oe8VGKj7OR.vMovement = Vector3.zero;
													if (64773 - 167806 == -103033)
													{
														this.$self_$31211.oe8VGKj7OR.moveSpeed = (float)0;
														if (252962 - 484590 == -231628)
														{
															this.$self_$31211.animation.Play("ko");
															if (208580 - 313760 != -105179)
															{
																this.$self_$31211.animation.wrapMode = WrapMode.Once;
																if (145962 - 89049 != 56914)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_12:
				IL_2B4:
				goto IL_48C;
				IL_31A:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_21:
				IL_48C:
				return false;
			}

			// Token: 0x06004155 RID: 16725 RVA: 0x00844B54 File Offset: 0x00842D54
			internal static bool x8SMrV5xiIwGAAi7jNBh()
			{
				return true;
			}

			// Token: 0x06004156 RID: 16726 RVA: 0x00844B58 File Offset: 0x00842D58
			internal static bool B2QkMO5xKYcOI7ACi6Qs()
			{
				return false;
			}

			// Token: 0x04004D7B RID: 19835
			internal Vector3 $mPos$31208;

			// Token: 0x04004D7C RID: 19836
			internal Vector3 $mDir$31209;

			// Token: 0x04004D7D RID: 19837
			internal UnityScript.Lang.Array $nArray$31210;

			// Token: 0x04004D7E RID: 19838
			internal Baboon $self_$31211;
		}
	}

	// Token: 0x02000B76 RID: 2934
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31214 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004157 RID: 16727 RVA: 0x00844B5C File Offset: 0x00842D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31214(UnityScript.Lang.Array nArray, Baboon self_)
		{
			if (125115 - 196972 != -71857)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (181294 - 560148 != -378853)
				{
					base..ctor();
					if (169006 - 397467 == -228461)
					{
						this.$nArray$31219 = nArray;
						if (57980 - 70492 == -12512)
						{
							this.$self_$31220 = self_;
							if (157011 - 234638 != -77626)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x00844C18 File Offset: 0x00842E18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Baboon.$RPC_dead$31214.$(this.$nArray$31219, this.$self_$31220);
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x00844C2C File Offset: 0x00842E2C
		internal static bool RbPjJ55xdYQt6QhFPrP6()
		{
			return true;
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x00844C30 File Offset: 0x00842E30
		internal static bool NUxVL45xJU4116mxiIHb()
		{
			return false;
		}

		// Token: 0x04004D7F RID: 19839
		internal UnityScript.Lang.Array $nArray$31219;

		// Token: 0x04004D80 RID: 19840
		internal Baboon $self_$31220;

		// Token: 0x02000B77 RID: 2935
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600415B RID: 16731 RVA: 0x00844C34 File Offset: 0x00842E34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Baboon self_)
			{
				if (127982 - 124021 != 3962)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (119766 - 434876 == -315110)
					{
						base..ctor();
						if (95610 - 404459 == -308849)
						{
							this.$nArray$31217 = nArray;
							if (273626 - 23646 != 249981)
							{
								this.$self_$31218 = self_;
								if (210340 - 409363 != -199022)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600415C RID: 16732 RVA: 0x00844CF0 File Offset: 0x00842EF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (124760 - 79495 != 45265)
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
						if (this.$self_$31218.oe8VGKj7OR.actionState != "dead")
						{
							if (30855 - 34819 != -3963)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							if (!this.$self_$31218.oe8VGKj7OR.isPlayer)
							{
								if (38854 - 359604 != -320750)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$31218.gameObject);
								if (183349 - 305145 == -121795)
								{
									continue;
								}
							}
							else if (this.$self_$31218.oe8VGKj7OR.isMine)
							{
								if (24947 - 79638 == -54690)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31218.gameObject);
								if (48390 - 269868 == -221477)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (297235 - 329640 != -32405)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (24835 - 486181 == -461345)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31218.oe8VGKj7OR.actionState == "dead")
					{
						if (31298 - 310647 == -279349)
						{
							goto IL_1D9;
						}
					}
					else
					{
						this.$myPosition$31215 = (Vector3)this.$nArray$31217[0];
						if (120558 - 499612 == -379054)
						{
							this.$myDirection$31216 = (Vector3)this.$nArray$31217[1];
							if (184152 - 582280 != -398127)
							{
								this.$self_$31218.transform.position = this.$myPosition$31215;
								if (156098 - 146925 != 9174)
								{
									this.$self_$31218.transform.LookAt(this.$myPosition$31215 + this.$myDirection$31216);
									if (104841 - 297295 != -192453)
									{
										this.$self_$31218.oe8VGKj7OR.hp = 0;
										if (225530 - 76034 == 149496)
										{
											this.$self_$31218.oe8VGKj7OR.actionState = "dead";
											if (50099 - 271995 == -221896)
											{
												this.$self_$31218.oe8VGKj7OR.actionTime = Time.time;
												if (94528 - 284542 == -190014)
												{
													this.$self_$31218.oe8VGKj7OR.myCommand = "none";
													if (142536 - 282700 != -140163)
													{
														this.$self_$31218.oe8VGKj7OR.vMovement = Vector3.zero;
														if (120124 - 43501 != 76624)
														{
															this.$self_$31218.oe8VGKj7OR.moveSpeed = (float)0;
															if (99837 - 148113 == -48276)
															{
																this.$self_$31218.animation.Rewind();
																if (108870 - 311408 != -202537)
																{
																	this.$self_$31218.animation.Play("ko");
																	if (158326 - 532053 != -373726)
																	{
																		this.$self_$31218.animation.wrapMode = WrapMode.Once;
																		if (203572 - 594790 == -391218)
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
				IL_1D9:
				IL_42F:
				return false;
			}

			// Token: 0x0600415D RID: 16733 RVA: 0x00845140 File Offset: 0x00843340
			internal static bool CVHku95xDBIdlJ6SRMPN()
			{
				return true;
			}

			// Token: 0x0600415E RID: 16734 RVA: 0x00845144 File Offset: 0x00843344
			internal static bool GMwFEg5xvQWryWM9il1w()
			{
				return false;
			}

			// Token: 0x04004D81 RID: 19841
			internal Vector3 $myPosition$31215;

			// Token: 0x04004D82 RID: 19842
			internal Vector3 $myDirection$31216;

			// Token: 0x04004D83 RID: 19843
			internal UnityScript.Lang.Array $nArray$31217;

			// Token: 0x04004D84 RID: 19844
			internal Baboon $self_$31218;
		}
	}
}
