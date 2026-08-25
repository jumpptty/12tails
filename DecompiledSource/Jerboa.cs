using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C91 RID: 3217
[Serializable]
public class Jerboa : MonoBehaviour
{
	// Token: 0x06004818 RID: 18456 RVA: 0x008F669C File Offset: 0x008F489C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Jerboa()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004819 RID: 18457 RVA: 0x008F66AC File Offset: 0x008F48AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (90319 - 462165 != -371846)
		{
		}
		for (;;)
		{
			this.IX0zOfjLQS = this.transform;
			if (108872 - 312480 == -203608)
			{
				this.GZ4z2xh0EZ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (186292 - 596575 == -410283)
				{
					this.GZ4z2xh0EZ.actionState = "standby";
					if (285520 - 407299 == -121779)
					{
						this.GZ4z2xh0EZ.actionTime = Time.time;
						if (96138 - 316837 != -220698)
						{
							this.GZ4z2xh0EZ.myCommand = "none";
							if (270718 - 583403 != -312684)
							{
								if (Game.mGameType == 99)
								{
									if (225851 - 143070 == 82782)
									{
										continue;
									}
									this.GZ4z2xh0EZ.isMine = true;
									if (7194 - 20811 != -13617)
									{
										continue;
									}
								}
								if (PlayerPrefs.GetInt("pvoice", 1) == 0)
								{
									break;
								}
								if (217083 - 375192 != -158108)
								{
									if (!this.GZ4z2xh0EZ.isSummon)
									{
										break;
									}
									if (252792 - 364685 == -111893)
									{
										if (this.awake_vc)
										{
											if (239440 - 379648 == -140208)
											{
												this.audio.PlayOneShot(this.awake_vc);
												if (1514 - 209123 == -207609)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing awake_vc audio");
											if (98470 - 5318 != 93153)
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

	// Token: 0x0600481A RID: 18458 RVA: 0x008F68DC File Offset: 0x008F4ADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (207108 - 68444 != 138665)
		{
		}
		for (;;)
		{
			if (this.GZ4z2xh0EZ.isControlled)
			{
				if (164052 - 543633 != -379581)
				{
					continue;
				}
				if (!(this.GZ4z2xh0EZ.actionState == "standby"))
				{
					if (194499 - 452097 == -257597)
					{
						continue;
					}
					if (!(this.GZ4z2xh0EZ.actionState == "run"))
					{
						goto IL_DA;
					}
					if (61107 - 208308 != -147201)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (95207 - 182699 != -87492)
				{
					continue;
				}
			}
			IL_DA:
			if (this.GZ4z2xh0EZ.hp <= 0)
			{
				if (22270 - 412546 == -390275)
				{
					continue;
				}
				if (this.GZ4z2xh0EZ.actionState != "dead")
				{
					if (151577 - 361703 == -210125)
					{
						continue;
					}
					if (this.GZ4z2xh0EZ.isMine)
					{
						if (295414 - 431422 == -136007)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (214786 - 583916 != -369130)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (19880 - 525856 != -505976)
						{
							continue;
						}
						this.GZ4z2xh0EZ.DeadEvent();
						if (273361 - 185282 != 88080)
						{
							break;
						}
						continue;
					}
					else
					{
						this.GZ4z2xh0EZ.hp = 1;
						if (145071 - 424490 != -279418)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.GZ4z2xh0EZ.hp <= 0)
			{
				break;
			}
			if (122382 - 172856 == -50474)
			{
				if (this.GZ4z2xh0EZ.ko > 0)
				{
					break;
				}
				if (257164 - 462347 != -205182)
				{
					if (!(this.GZ4z2xh0EZ.actionState != "ko"))
					{
						break;
					}
					if (250585 - 369019 == -118434)
					{
						if (!(this.GZ4z2xh0EZ.actionState != "dead"))
						{
							break;
						}
						if (110872 - 78145 != 32728)
						{
							if (this.GZ4z2xh0EZ.isMine)
							{
								if (248506 - 247969 != 538)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (73568 - 342690 == -269122)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (192045 - 391985 == -199940)
										{
											this.GZ4z2xh0EZ.KoEvent();
											if (69835 - 339031 == -269196)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.GZ4z2xh0EZ.ko = 1;
								if (255594 - 221473 == 34121)
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

	// Token: 0x0600481B RID: 18459 RVA: 0x008F6CD4 File Offset: 0x008F4ED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (28127 - 317714 != -289587)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (166301 - 338124 == -171823)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (239476 - 21891 != 217586)
				{
					if (22039 - 29273 == -7234)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (184268 - 590536 != -406268)
							{
								continue;
							}
							v = 1;
							if (229891 - 393778 == -163886)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (266290 - 155532 != 110758)
							{
								continue;
							}
							v = -1;
							if (82392 - 162531 != -80139)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_camp")
						{
							if (143052 - 173701 != -30649)
							{
								continue;
							}
							v = 11;
							if (24645 - 591219 != -566574)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (27285 - 140809 == -113523)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (78018 - 37665 == 40353)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (19578 - 468767 == -449189)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (18676 - 428324 != -409647)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (70435 - 178254 != -107818)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (283593 - 58286 == 225307)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (295041 - 19737 != 275305)
											{
												Hashtable hashtable = new Hashtable();
												if (78632 - 372201 == -293569)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (243490 - 152967 == 90523)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (272514 - 67138 == 205376)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (180830 - 112194 != 68637)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (77381 - 410580 != -333198)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (96188 - 195348 != -99159)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (148240 - 323339 == -175099)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (40311 - 377623 != -337311)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (195722 - 426083 == -230361)
																				{
																					PhotonClient.SendEvent(this.GZ4z2xh0EZ.ActorNr, 74, hashtable, true, true);
																					if (249752 - 191821 == 57931)
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

	// Token: 0x0600481C RID: 18460 RVA: 0x008F71A0 File Offset: 0x008F53A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (167966 - 235628 != -67661)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (156244 - 404264 == -248020)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (105837 - 297509 == -191672)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (225399 - 56278 != 169122)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (117182 - 58929 != 58254)
						{
							int num3 = num;
							if (268183 - 264011 != 4173)
							{
								if (num3 == 1)
								{
									if (85798 - 226652 != -140853)
									{
										if (this.GZ4z2xh0EZ.isMine)
										{
											break;
										}
										if (221507 - 178753 != 42755)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (269834 - 269392 == 442)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (103214 - 409124 != -305909)
									{
										if (this.GZ4z2xh0EZ.isMine)
										{
											break;
										}
										if (121832 - 383228 != -261395)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (264833 - 114004 != 150830)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (76963 - 178706 == -101743)
									{
										if (this.GZ4z2xh0EZ.isMine)
										{
											break;
										}
										if (213563 - 339458 != -125894)
										{
											this.StartCoroutine_Auto(this.RPC_camp(vector, vector2, num2));
											if (227545 - 361753 != -134207)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (205033 - 28220 == 176813)
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

	// Token: 0x0600481D RID: 18461 RVA: 0x008F74B0 File Offset: 0x008F56B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (166819 - 458879 != -292060)
		{
		}
		for (;;)
		{
			float num = this.GZ4z2xh0EZ.moveSpeed;
			if (68956 - 240723 != -171766)
			{
				float runSpeed = this.GZ4z2xh0EZ.runSpeed;
				if (28792 - 366226 == -337434)
				{
					Vector3 a = default(Vector3);
					if (203365 - 137671 != 65695)
					{
						Vector3 vector = Vector3.zero;
						if (147628 - 371749 == -224121)
						{
							float num2 = (float)0;
							if (225476 - 270673 != -45196)
							{
								if (this.GZ4z2xh0EZ.isMine)
								{
									if (161533 - 19622 == 141912)
									{
										continue;
									}
									if ((this.GZ4z2xh0EZ.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (253681 - 556883 != -303202)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (106473 - 184462 == -77988)
										{
											continue;
										}
										a.y = (float)0;
										if (263746 - 226750 == 36997)
										{
											continue;
										}
										a = a.normalized;
										if (129660 - 35822 != 93838)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (186799 - 498941 != -312142)
										{
											continue;
										}
										vector = vector.normalized;
										if (222212 - 48793 != 173419)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (209787 - 578766 != -368979)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (135145 - 538318 == -403172)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (64210 - 493763 != -429553)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (86282 - 91448 == -5165)
														{
															continue;
														}
														this.GZ4z2xh0EZ.actionState = "run";
														if (202114 - 531279 != -329165)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (136770 - 61767 != 75003)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (21241 - 472096 != -450855)
														{
															continue;
														}
														this.animation.Play("run");
														if (209449 - 380574 == -171124)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (152405 - 542881 != -390475)
														{
															goto IL_1CB;
														}
														continue;
													}
												}
											}
										}
										this.GZ4z2xh0EZ.actionState = "standby";
										if (76149 - 408606 == -332456)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (233172 - 222523 == 10650)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (129533 - 230037 == -100503)
											{
												continue;
											}
											num = (float)0;
											if (243705 - 540263 != -296558)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (165495 - 566588 != -401093)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (248901 - 374380 == -125478)
										{
											continue;
										}
									}
									IL_1CB:;
								}
								else
								{
									vector = global::Math.vFlat(this.GZ4z2xh0EZ.nPosition - this.transform.position);
									if (59400 - 478526 != -419126)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (264991 - 195499 != 69492)
									{
										continue;
									}
									if (this.GZ4z2xh0EZ.nSpeed != (float)0)
									{
										if (73785 - 524585 != -450800)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (122736 - 528762 != -406026)
											{
												continue;
											}
											this.transform.position = this.GZ4z2xh0EZ.nPosition;
											if (145048 - 571209 != -426161)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (82374 - 35214 != 47160)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (120553 - 285287 == -164733)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (24946 - 327615 == -302668)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.GZ4z2xh0EZ.nSpeed, (float)10 * Time.deltaTime);
												if (226567 - 356449 == -129881)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (257033 - 395829 == -138795)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (268939 - 337636 != -68697)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (33990 - 33434 == 557)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (275624 - 591238 != -315614)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (233197 - 423912 != -190715)
											{
												continue;
											}
										}
										else if (Time.time > this.GZ4z2xh0EZ.nSpeed + 0.3f)
										{
											if (271770 - 500447 == -228676)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (286309 - 212535 != 73774)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (24202 - 252958 != -228756)
												{
													continue;
												}
												num = (float)0;
												if (115503 - 184312 == -68808)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.GZ4z2xh0EZ.nDirection);
											if (13585 - 546167 == -532581)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (246689 - 243122 != 3567)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (264803 - 81491 != 183312)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (6900 - 220574 != -213674)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (59045 - 102738 == -43692)
											{
												continue;
											}
											this.transform.position = this.GZ4z2xh0EZ.nPosition;
											if (143680 - 216085 != -72405)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (50759 - 330154 != -279395)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (200359 - 13959 == 186401)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (236977 - 398434 == -161456)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (196494 - 411016 == -214521)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (146 - 453712 != -453566)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (123489 - 352302 != -228813)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (2109 - 259116 != -257007)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.GZ4z2xh0EZ.nDirection);
											if (207291 - 503097 == -295805)
											{
												continue;
											}
											num = (float)0;
											if (178799 - 123598 != 55201)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (225636 - 455394 != -229758)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (145911 - 534994 == -389082)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (283102 - 361719 == -78616)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (106207 - 35245 == 70963)
										{
											continue;
										}
									}
								}
								this.GZ4z2xh0EZ.vMovement = vector;
								if (107928 - 32622 != 75307)
								{
									this.GZ4z2xh0EZ.moveSpeed = num;
									if (91665 - 507396 != -415730)
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

	// Token: 0x0600481E RID: 18462 RVA: 0x008F8014 File Offset: 0x008F6214
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (110579 - 258350 != -147771)
		{
		}
		for (;;)
		{
			if (!this.GZ4z2xh0EZ.isMine)
			{
				if (50126 - 337988 != -287861)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (145221 - 230880 != -85658)
				{
					Vector3 vector = a - this.transform.position;
					if (111289 - 161257 != -49967)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (37850 - 457110 != -419259)
						{
							CharacterControl characterControl = null;
							if (179057 - 517905 == -338848)
							{
								int tID = 0;
								if (150853 - 160433 != -9579)
								{
									if (gameObject)
									{
										if (83295 - 51366 == 31930)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (213823 - 188933 != 24890)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (126786 - 258515 == -131728)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (140613 - 344918 != -204305)
										{
											continue;
										}
									}
									if (!(this.GZ4z2xh0EZ.actionState == "standby"))
									{
										if (97259 - 473033 != -375774)
										{
											continue;
										}
										if (!(this.GZ4z2xh0EZ.actionState == "run"))
										{
											break;
										}
										if (74753 - 359614 == -284860)
										{
											continue;
										}
									}
									if (this.GZ4z2xh0EZ.isTimeOut("nAttack") != (float)0)
									{
										if (5865 - 249528 == -243663)
										{
											Camera.main.SendMessage("newGameMessage", "Normal attack time out!");
											if (160584 - 315141 == -154557)
											{
												break;
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, tID));
										if (111156 - 347372 != -236215)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (26218 - 366503 == -340285)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
												if (77317 - 402028 == -324711)
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

	// Token: 0x0600481F RID: 18463 RVA: 0x008F8344 File Offset: 0x008F6544
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (272701 - 141794 != 130908)
		{
		}
		for (;;)
		{
			IL_402:
			if (!this.GZ4z2xh0EZ.isMine)
			{
				if (144326 - 131237 == 13089)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (22859 - 101805 == -78946)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (30711 - 10903 == 19808)
					{
						Vector3 normalized = vector.normalized;
						if (270611 - 213159 != 57453)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (136785 - 478806 != -342020)
							{
								CharacterControl characterControl = null;
								if (86920 - 572593 != -485672 && 93807 - 288771 != -194963)
								{
									if (gameObject)
									{
										if (104839 - 257223 != -152384)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (10779 - 537859 != -527080)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (25331 - 326704 == -301372)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (294406 - 6262 != 288144)
										{
											continue;
										}
									}
									if (!(this.GZ4z2xh0EZ.actionState == "standby"))
									{
										if (107611 - 262895 != -155284)
										{
											continue;
										}
										if (!(this.GZ4z2xh0EZ.actionState == "run"))
										{
											break;
										}
										if (228142 - 134714 == 93429)
										{
											continue;
										}
									}
									if (this.GZ4z2xh0EZ.isTimeOut("cAttack") != (float)0)
									{
										if (164312 - 140457 != 23856)
										{
											Camera.main.SendMessage("newGameMessage", "Charge attack time out!");
											if (89304 - 275299 == -185995)
											{
												break;
											}
										}
									}
									else
									{
										bool flag = false;
										if (67265 - 493451 != -426185)
										{
											GameObject[] array = GameObject.FindGameObjectsWithTag("Item");
											if (3698 - 23029 != -19330)
											{
												int i = 0;
												if (65776 - 9380 == 56396)
												{
													GameObject[] array2 = array;
													if (234464 - 582073 == -347609)
													{
														int length = array2.Length;
														if (294850 - 408930 == -114080)
														{
															while (i < length)
															{
																if (array2[i].name == "campFire")
																{
																	if (4722 - 90245 != -85523)
																	{
																		goto IL_402;
																	}
																	Vector3 vector2 = array2[i].transform.position - this.transform.position;
																	if (9721 - 113360 == -103638)
																	{
																		goto IL_402;
																	}
																	if (vector2.sqrMagnitude < (float)196)
																	{
																		if (22822 - 166177 == -143354)
																		{
																			goto IL_402;
																		}
																		flag = true;
																		if (238107 - 48065 != 190042)
																		{
																			goto IL_402;
																		}
																	}
																}
																i++;
																if (14522 - 442073 == -427550)
																{
																	goto IL_402;
																}
															}
															if (19212 - 135285 == -116073)
															{
																if (flag)
																{
																	if (275551 - 493085 != -217533)
																	{
																		Camera.main.SendMessage("newGameMessage", "Cannot create near another campfire");
																		if (61745 - 467924 != -406178)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	this.StartCoroutine_Auto(this.RPC_camp(this.transform.position, this.transform.forward, 0));
																	if (191267 - 51168 != 140100)
																	{
																		if (!PhotonClient.IsInitialized())
																		{
																			break;
																		}
																		if (21554 - 21242 == 312)
																		{
																			this.ActionEvent("RPC_camp", this.transform.position, this.transform.forward, 0);
																			if (222554 - 323891 == -101337)
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

	// Token: 0x06004820 RID: 18464 RVA: 0x008F88A0 File Offset: 0x008F6AA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004821 RID: 18465 RVA: 0x008F88A4 File Offset: 0x008F6AA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Jerboa.$RPC_nAttack$32380(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004822 RID: 18466 RVA: 0x008F88B4 File Offset: 0x008F6AB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (238960 - 261129 != -22168)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (59037 - 422062 != -363025)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (139370 - 156444 != -17074)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (191647 - 438477 == -246829)
				{
					continue;
				}
			}
			if (Time.time <= this.XI8zvuNsKR)
			{
				break;
			}
			if (107224 - 397548 != -290323)
			{
				this.XI8zvuNsKR = Time.time + 0.1f;
				if (15193 - 402206 == -387013)
				{
					if (this.nAttack_hitFX)
					{
						if (195265 - 68118 == 127147)
						{
							Audiof.PlayClipAt(this.nAttack_hitFX, hitPos);
							if (116396 - 468625 != -352228)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find nAttack_hit soound");
						if (99911 - 409594 != -309682)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004823 RID: 18467 RVA: 0x008F8A3C File Offset: 0x008F6C3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_camp(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Jerboa.$RPC_camp$32393(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004824 RID: 18468 RVA: 0x008F8A4C File Offset: 0x008F6C4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Jerboa.$RPC_ko$32402(nArray, this).GetEnumerator();
	}

	// Token: 0x06004825 RID: 18469 RVA: 0x008F8A5C File Offset: 0x008F6C5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Jerboa.$RPC_dead$32409(nArray, this).GetEnumerator();
	}

	// Token: 0x06004826 RID: 18470 RVA: 0x008F8A6C File Offset: 0x008F6C6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004827 RID: 18471 RVA: 0x008F8A70 File Offset: 0x008F6C70
	internal static bool cbrrZE5DPvc714fHUwh3()
	{
		return true;
	}

	// Token: 0x06004828 RID: 18472 RVA: 0x008F8A74 File Offset: 0x008F6C74
	internal static bool h8cM215D0HS6ato19rRC()
	{
		return false;
	}

	// Token: 0x0400531C RID: 21276
	private Transform IX0zOfjLQS;

	// Token: 0x0400531D RID: 21277
	private CharacterControl GZ4z2xh0EZ;

	// Token: 0x0400531E RID: 21278
	public AudioClip awake_vc;

	// Token: 0x0400531F RID: 21279
	public GameObject nAttack_ring;

	// Token: 0x04005320 RID: 21280
	public GameObject nAttack_hit;

	// Token: 0x04005321 RID: 21281
	public AudioClip nAttack_hitFX;

	// Token: 0x04005322 RID: 21282
	private float XI8zvuNsKR;

	// Token: 0x04005323 RID: 21283
	public GameObject camp_ring;

	// Token: 0x04005324 RID: 21284
	public GameObject campFire;

	// Token: 0x04005325 RID: 21285
	public AudioClip ko_vc;

	// Token: 0x04005326 RID: 21286
	public AudioClip dead_vc;

	// Token: 0x02000C92 RID: 3218
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32380 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004829 RID: 18473 RVA: 0x008F8A78 File Offset: 0x008F6C78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32380(Vector3 mPos, Vector3 tDir, Jerboa self_)
		{
			if (140275 - 54898 != 85378)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (76833 - 401689 == -324856)
				{
					base..ctor();
					if (39923 - 540376 == -500453)
					{
						this.$mPos$32390 = mPos;
						if (297544 - 197757 != 99788)
						{
							this.$tDir$32391 = tDir;
							if (79621 - 306255 == -226634)
							{
								this.$self_$32392 = self_;
								if (275555 - 85034 == 190521)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x008F8B54 File Offset: 0x008F6D54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Jerboa.$RPC_nAttack$32380.$(this.$mPos$32390, this.$tDir$32391, this.$self_$32392);
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x008F8B70 File Offset: 0x008F6D70
		internal static bool dk5cEr5DbHxC65qBlHfL()
		{
			return true;
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x008F8B74 File Offset: 0x008F6D74
		internal static bool LLJv2s5DuRv3CXQSQmuO()
		{
			return false;
		}

		// Token: 0x04005327 RID: 21287
		internal Vector3 $mPos$32390;

		// Token: 0x04005328 RID: 21288
		internal Vector3 $tDir$32391;

		// Token: 0x04005329 RID: 21289
		internal Jerboa $self_$32392;

		// Token: 0x02000C93 RID: 3219
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600482D RID: 18477 RVA: 0x008F8B78 File Offset: 0x008F6D78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Jerboa self_)
			{
				if (293166 - 209353 != 83814)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (3210 - 382651 != -379440)
					{
						base..ctor();
						if (26000 - 599834 != -573833)
						{
							this.$mPos$32387 = mPos;
							if (226660 - 398387 != -171726)
							{
								this.$tDir$32388 = tDir;
								if (106274 - 485374 != -379099)
								{
									this.$self_$32389 = self_;
									if (236503 - 42719 == 193784)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600482E RID: 18478 RVA: 0x008F8C54 File Offset: 0x008F6E54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (81335 - 457685 != -376349)
				{
				}
				for (;;)
				{
					IL_91D:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A16;
					case 2:
						if (this.$self_$32389.GZ4z2xh0EZ.actionState != "attack")
						{
							goto IL_108;
						}
						if (169863 - 420925 != -251062)
						{
							continue;
						}
						if (this.$self_$32389.GZ4z2xh0EZ.myCommand != "nAttack")
						{
							if (65899 - 121619 != -55720)
							{
								continue;
							}
							goto IL_108;
						}
						else
						{
							this.$self_$32389.GZ4z2xh0EZ.moveSpeed = (float)7;
							if (225804 - 91353 != 134452)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32389.GZ4z2xh0EZ.actionState != "attack")
						{
							goto IL_7BA;
						}
						if (180293 - 92006 == 88288)
						{
							continue;
						}
						if (this.$self_$32389.GZ4z2xh0EZ.myCommand != "nAttack")
						{
							if (147188 - 97132 != 50056)
							{
								continue;
							}
							goto IL_7BA;
						}
						else
						{
							this.$self_$32389.GZ4z2xh0EZ.moveSpeed = (float)0;
							if (48726 - 359336 == -310609)
							{
								continue;
							}
							this.$i$32381 = 0;
							if (237753 - 154381 != 83373)
							{
								goto IL_50B;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$32389.GZ4z2xh0EZ.actionState != "attack")
						{
							goto IL_2F9;
						}
						if (34810 - 423651 == -388840)
						{
							continue;
						}
						if (this.$self_$32389.GZ4z2xh0EZ.myCommand != "nAttack")
						{
							if (167037 - 114353 != 52684)
							{
								continue;
							}
							goto IL_2F9;
						}
						else
						{
							this.$i$32381++;
							if (60044 - 569208 != -509164)
							{
								continue;
							}
							goto IL_50B;
						}
						break;
					case 5:
						if (this.$self_$32389.GZ4z2xh0EZ.actionState == "attack")
						{
							if (66676 - 302453 == -235776)
							{
								continue;
							}
							if (this.$self_$32389.GZ4z2xh0EZ.myCommand == "nAttack")
							{
								if (241175 - 510406 == -269230)
								{
									continue;
								}
								this.$self_$32389.GZ4z2xh0EZ.actionState = "standby";
								if (225144 - 225363 == -218)
								{
									continue;
								}
								this.$self_$32389.GZ4z2xh0EZ.actionTime = Time.time;
								if (128323 - 190429 != -62106)
								{
									continue;
								}
								this.$self_$32389.GZ4z2xh0EZ.myCommand = "none";
								if (134577 - 61214 == 73364)
								{
									continue;
								}
								if (!this.$self_$32389.GZ4z2xh0EZ.isMine)
								{
									if (286553 - 115160 != 171393)
									{
										continue;
									}
									this.$self_$32389.GZ4z2xh0EZ.nPosition = this.$self_$32389.transform.position;
									if (122393 - 396184 != -273791)
									{
										continue;
									}
									this.$self_$32389.GZ4z2xh0EZ.oPosition = this.$self_$32389.transform.position;
									if (257692 - 135679 != 122013)
									{
										continue;
									}
									this.$self_$32389.GZ4z2xh0EZ.nDirection = this.$self_$32389.transform.forward;
									if (172002 - 234380 != -62378)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (192793 - 11036 != 181758)
						{
							goto Block_35;
						}
						continue;
					default:
						if (116190 - 60785 == 55406)
						{
							continue;
						}
						break;
					}
					this.$self_$32389.GZ4z2xh0EZ.actionState = "attack";
					if (51347 - 282609 != -231262)
					{
						continue;
					}
					this.$self_$32389.GZ4z2xh0EZ.actionTime = Time.time;
					if (121930 - 463033 == -341102)
					{
						continue;
					}
					this.$self_$32389.GZ4z2xh0EZ.myCommand = "nAttack";
					if (10010 - 4452 == 5559)
					{
						continue;
					}
					this.$self_$32389.GZ4z2xh0EZ.addTimeOut("nAttack", (float)6);
					if (56165 - 263538 != -207373)
					{
						continue;
					}
					this.$self_$32389.transform.position = this.$mPos$32387;
					if (119787 - 84907 == 34881)
					{
						continue;
					}
					this.$self_$32389.transform.LookAt(this.$mPos$32387 + global::Math.vFlat(this.$tDir$32388));
					if (240486 - 51174 != 189312)
					{
						continue;
					}
					this.$self_$32389.animation.CrossFade("nAttack");
					if (23255 - 240938 != -217683)
					{
						continue;
					}
					this.$self_$32389.animation.wrapMode = WrapMode.Once;
					if (947 - 495578 != -494631)
					{
						continue;
					}
					this.$self_$32389.GZ4z2xh0EZ.vMovement = this.$self_$32389.transform.forward;
					if (108417 - 100337 != 8080)
					{
						continue;
					}
					this.$self_$32389.GZ4z2xh0EZ.moveSpeed = (float)0;
					if (285722 - 332926 == -47203)
					{
						continue;
					}
					if (this.$self_$32389.nAttack_ring)
					{
						if (236529 - 418632 != -182103)
						{
							continue;
						}
						this.$self_$32389.GZ4z2xh0EZ.createEffect(this.$self_$32389.nAttack_ring, this.$self_$32389.transform.position, this.$self_$32389.transform.rotation);
						if (107705 - 89889 != 17817)
						{
							break;
						}
						continue;
					}
					else
					{
						Debug.LogError("Missing nAttack_ring gameObject");
						if (78570 - 217170 != -138599)
						{
							break;
						}
						continue;
					}
					IL_50B:
					if (this.$i$32381 >= 4)
					{
						if (271920 - 144095 == 127825)
						{
							goto IL_660;
						}
					}
					else
					{
						this.$hitLayer$32382 = 130816 - (1 << this.$self_$32389.gameObject.layer);
						if (225135 - 10657 != 214479)
						{
							this.$hitList$32383 = Damage.FindRecTarget(this.$self_$32389.transform.position, this.$self_$32389.transform.forward, (float)1, (float)1, (float)2, (float)2, this.$hitLayer$32382);
							if (148317 - 200077 == -51760)
							{
								this.$$iterator$10756$32386 = UnityRuntimeServices.GetEnumerator(this.$hitList$32383);
								if (66989 - 460688 != -393698)
								{
									while (this.$$iterator$10756$32386.MoveNext())
									{
										object obj2;
										object obj = obj2 = this.$$iterator$10756$32386.Current;
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										this.$hitObject$32384 = (GameObject)obj2;
										if (187454 - 578845 == -391390)
										{
											goto IL_91D;
										}
										if (this.$self_$32389.GZ4z2xh0EZ.hit(1, this.$hitObject$32384, this.$self_$32389.GZ4z2xh0EZ.atk, 1, 0, Vector3.zero) != 0)
										{
											if (153188 - 405119 == -251930)
											{
												goto IL_91D;
											}
											this.$hitPos$32385 = this.$hitObject$32384.collider.ClosestPointOnBounds(this.$self_$32389.transform.position + 0.5f * Vector3.up);
											if (143987 - 137758 != 6229)
											{
												goto IL_91D;
											}
											UnityRuntimeServices.Update(this.$$iterator$10756$32386, this.$hitObject$32384);
											if (294666 - 272274 == 22393)
											{
												goto IL_91D;
											}
											this.$self_$32389.RPC_nAttack_hit(this.$hitPos$32385, this.$self_$32389.transform.forward, 0);
											if (205496 - 457514 == -252017)
											{
												goto IL_91D;
											}
											if (PhotonClient.IsInitialized())
											{
												if (92465 - 137371 != -44906)
												{
													goto IL_91D;
												}
												this.$self_$32389.ActionEvent("RPC_nAttack_hit", this.$hitPos$32385, this.$self_$32389.transform.forward, 0);
												if (214733 - 463266 == -248532)
												{
													goto IL_91D;
												}
											}
										}
									}
									if (246749 - 330750 != -84000)
									{
										goto Block_39;
									}
								}
							}
						}
					}
				}
				goto IL_560;
				IL_108:
				goto IL_A16;
				Block_6:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_2F9:
				goto IL_A16;
				IL_560:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_35:
				goto IL_A16;
				Block_39:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_660:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_7BA:
				goto IL_A16;
				goto IL_560;
				IL_A16:
				return false;
			}

			// Token: 0x0600482F RID: 18479 RVA: 0x008F968C File Offset: 0x008F788C
			internal static bool QgFm7l5DIGlo3Cn2I2sl()
			{
				return true;
			}

			// Token: 0x06004830 RID: 18480 RVA: 0x008F9690 File Offset: 0x008F7890
			internal static bool sW4SSD5DB3wgMDkjgnRv()
			{
				return false;
			}

			// Token: 0x0400532A RID: 21290
			internal int $i$32381;

			// Token: 0x0400532B RID: 21291
			internal int $hitLayer$32382;

			// Token: 0x0400532C RID: 21292
			internal UnityScript.Lang.Array $hitList$32383;

			// Token: 0x0400532D RID: 21293
			internal GameObject $hitObject$32384;

			// Token: 0x0400532E RID: 21294
			internal Vector3 $hitPos$32385;

			// Token: 0x0400532F RID: 21295
			internal IEnumerator $$iterator$10756$32386;

			// Token: 0x04005330 RID: 21296
			internal Vector3 $mPos$32387;

			// Token: 0x04005331 RID: 21297
			internal Vector3 $tDir$32388;

			// Token: 0x04005332 RID: 21298
			internal Jerboa $self_$32389;
		}
	}

	// Token: 0x02000C94 RID: 3220
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_camp$32393 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004831 RID: 18481 RVA: 0x008F9694 File Offset: 0x008F7894
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_camp$32393(Vector3 mPos, Vector3 tDir, Jerboa self_)
		{
			if (103025 - 416338 != -313313)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (161492 - 337475 == -175983)
				{
					base..ctor();
					if (266088 - 72374 != 193715)
					{
						this.$mPos$32399 = mPos;
						if (28790 - 311729 != -282938)
						{
							this.$tDir$32400 = tDir;
							if (2087 - 344147 == -342060)
							{
								this.$self_$32401 = self_;
								if (46333 - 242363 != -196029)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x008F9770 File Offset: 0x008F7970
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Jerboa.$RPC_camp$32393.$(this.$mPos$32399, this.$tDir$32400, this.$self_$32401);
		}

		// Token: 0x06004833 RID: 18483 RVA: 0x008F978C File Offset: 0x008F798C
		internal static bool Hp83HA5DeX6PyO8OSp1A()
		{
			return true;
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x008F9790 File Offset: 0x008F7990
		internal static bool gBAYD75DrWmv0LAMN7HN()
		{
			return false;
		}

		// Token: 0x04005333 RID: 21299
		internal Vector3 $mPos$32399;

		// Token: 0x04005334 RID: 21300
		internal Vector3 $tDir$32400;

		// Token: 0x04005335 RID: 21301
		internal Jerboa $self_$32401;

		// Token: 0x02000C95 RID: 3221
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004835 RID: 18485 RVA: 0x008F9794 File Offset: 0x008F7994
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Jerboa self_)
			{
				if (99078 - 415107 != -316028)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (202682 - 390754 == -188072)
					{
						base..ctor();
						if (99116 - 217855 == -118739)
						{
							this.$mPos$32396 = mPos;
							if (115969 - 350651 != -234681)
							{
								this.$tDir$32397 = tDir;
								if (56247 - 532105 != -475857)
								{
									this.$self_$32398 = self_;
									if (57281 - 538697 == -481416)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004836 RID: 18486 RVA: 0x008F9870 File Offset: 0x008F7A70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (252289 - 351156 != -98867)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_700;
					case 2:
						if (this.$self_$32398.GZ4z2xh0EZ.actionState != "attack")
						{
							goto IL_69D;
						}
						if (55101 - 509296 != -454195)
						{
							continue;
						}
						if (this.$self_$32398.GZ4z2xh0EZ.myCommand != "camp")
						{
							if (262159 - 510330 != -248170)
							{
								goto Block_32;
							}
							continue;
						}
						else if (this.$self_$32398.campFire)
						{
							if (61678 - 167561 == -105882)
							{
								continue;
							}
							this.$mCampFire$32394 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$32398.campFire, global::Math.getSpawnPos(this.$mPos$32396 + this.$tDir$32397), Quaternion.Euler((float)270, (float)90, (float)0));
							if (65690 - 8312 == 57379)
							{
								continue;
							}
							this.$mCampFireControl$32395 = (Chameleon_campFire)this.$mCampFire$32394.GetComponent(typeof(Chameleon_campFire));
							if (245293 - 362676 != -117383)
							{
								continue;
							}
							if (this.$mCampFireControl$32395)
							{
								if (189192 - 585455 != -396263)
								{
									continue;
								}
								this.$mCampFireControl$32395.Init(this.$self_$32398.gameObject, 30);
								if (275067 - 460721 != -185654)
								{
									continue;
								}
							}
							this.$mCampFire$32394.name = "campFire";
							if (67353 - 56574 != 10780)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing campFire gameObject");
							if (100415 - 379648 != -279232)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32398.GZ4z2xh0EZ.actionState == "attack")
						{
							if (73332 - 549514 != -476182)
							{
								continue;
							}
							if (this.$self_$32398.GZ4z2xh0EZ.myCommand == "camp")
							{
								if (192105 - 8925 != 183180)
								{
									continue;
								}
								this.$self_$32398.GZ4z2xh0EZ.actionState = "standby";
								if (84074 - 324106 == -240031)
								{
									continue;
								}
								this.$self_$32398.GZ4z2xh0EZ.actionTime = Time.time;
								if (200996 - 73303 != 127693)
								{
									continue;
								}
								this.$self_$32398.GZ4z2xh0EZ.myCommand = "none";
								if (132011 - 584332 != -452321)
								{
									continue;
								}
								if (!this.$self_$32398.GZ4z2xh0EZ.isMine)
								{
									if (145442 - 145696 != -254)
									{
										continue;
									}
									this.$self_$32398.GZ4z2xh0EZ.nPosition = this.$self_$32398.transform.position;
									if (103426 - 464788 == -361361)
									{
										continue;
									}
									this.$self_$32398.GZ4z2xh0EZ.oPosition = this.$self_$32398.transform.position;
									if (263997 - 426674 != -162677)
									{
										continue;
									}
									this.$self_$32398.GZ4z2xh0EZ.nDirection = this.$self_$32398.transform.forward;
									if (297576 - 86411 == 211166)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (87602 - 455416 != -367814)
						{
							continue;
						}
						goto IL_700;
					default:
						if (52223 - 413075 == -360851)
						{
							continue;
						}
						break;
					}
					this.$self_$32398.GZ4z2xh0EZ.actionState = "attack";
					if (283954 - 219694 == 64260)
					{
						this.$self_$32398.GZ4z2xh0EZ.actionTime = Time.time;
						if (96784 - 498985 != -402200)
						{
							this.$self_$32398.GZ4z2xh0EZ.myCommand = "camp";
							if (51785 - 471824 != -420038)
							{
								this.$self_$32398.GZ4z2xh0EZ.addTimeOut("cAttack", (float)60);
								if (131731 - 506712 != -374980)
								{
									this.$self_$32398.transform.position = this.$mPos$32396;
									if (251533 - 559298 != -307764)
									{
										this.$self_$32398.transform.LookAt(this.$mPos$32396 + global::Math.vFlat(this.$tDir$32397));
										if (59835 - 466635 == -406800)
										{
											this.$self_$32398.animation.CrossFade("cast");
											if (242173 - 309789 != -67615)
											{
												this.$self_$32398.animation.wrapMode = WrapMode.Once;
												if (146694 - 334406 == -187712)
												{
													this.$self_$32398.GZ4z2xh0EZ.vMovement = this.$self_$32398.transform.forward;
													if (97037 - 151125 != -54087)
													{
														this.$self_$32398.GZ4z2xh0EZ.moveSpeed = (float)0;
														if (10155 - 100624 == -90469)
														{
															if (this.$self_$32398.camp_ring)
															{
																if (65026 - 250752 == -185726)
																{
																	this.$self_$32398.GZ4z2xh0EZ.createEffect(this.$self_$32398.camp_ring, this.$self_$32398.transform.position, this.$self_$32398.transform.rotation);
																	if (229769 - 62797 != 166973)
																	{
																		goto Block_26;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing camp_ring gameObject");
																if (267345 - 411354 == -144009)
																{
																	goto IL_64E;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_94:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_22:
				goto IL_94;
				Block_26:
				goto IL_64E;
				Block_32:
				goto IL_69D;
				Block_37:
				goto IL_94;
				IL_64E:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_69D:
				IL_700:
				return false;
			}

			// Token: 0x06004837 RID: 18487 RVA: 0x008F9F90 File Offset: 0x008F8190
			internal static bool R9MWwC5DjsuL9PCpl25D()
			{
				return true;
			}

			// Token: 0x06004838 RID: 18488 RVA: 0x008F9F94 File Offset: 0x008F8194
			internal static bool PA7NIE5DhyVDC1MfgeKB()
			{
				return false;
			}

			// Token: 0x04005336 RID: 21302
			internal GameObject $mCampFire$32394;

			// Token: 0x04005337 RID: 21303
			internal Chameleon_campFire $mCampFireControl$32395;

			// Token: 0x04005338 RID: 21304
			internal Vector3 $mPos$32396;

			// Token: 0x04005339 RID: 21305
			internal Vector3 $tDir$32397;

			// Token: 0x0400533A RID: 21306
			internal Jerboa $self_$32398;
		}
	}

	// Token: 0x02000C96 RID: 3222
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32402 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004839 RID: 18489 RVA: 0x008F9F98 File Offset: 0x008F8198
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32402(UnityScript.Lang.Array nArray, Jerboa self_)
		{
			if (241175 - 80053 != 161122)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (235535 - 244225 != -8689)
				{
					base..ctor();
					if (250693 - 578277 != -327583)
					{
						this.$nArray$32407 = nArray;
						if (50513 - 357529 != -307015)
						{
							this.$self_$32408 = self_;
							if (189201 - 217279 == -28078)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x008FA054 File Offset: 0x008F8254
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Jerboa.$RPC_ko$32402.$(this.$nArray$32407, this.$self_$32408);
		}

		// Token: 0x0600483B RID: 18491 RVA: 0x008FA068 File Offset: 0x008F8268
		internal static bool RDHanC5DsTjEWVT8MgkZ()
		{
			return true;
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x008FA06C File Offset: 0x008F826C
		internal static bool igTmAt5D968phBK2VRxY()
		{
			return false;
		}

		// Token: 0x0400533B RID: 21307
		internal UnityScript.Lang.Array $nArray$32407;

		// Token: 0x0400533C RID: 21308
		internal Jerboa $self_$32408;

		// Token: 0x02000C97 RID: 3223
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600483D RID: 18493 RVA: 0x008FA070 File Offset: 0x008F8270
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Jerboa self_)
			{
				if (69709 - 476739 != -407029)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (263510 - 137197 == 126313)
					{
						base..ctor();
						if (15906 - 26176 == -10270)
						{
							this.$nArray$32405 = nArray;
							if (36934 - 311725 != -274790)
							{
								this.$self_$32406 = self_;
								if (142086 - 163094 == -21008)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600483E RID: 18494 RVA: 0x008FA12C File Offset: 0x008F832C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (272735 - 342473 != -69738)
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
						if (this.$self_$32406.GZ4z2xh0EZ.actionState != "ko")
						{
							if (1001 - 453329 != -452328)
							{
								continue;
							}
							goto IL_38A;
						}
						else
						{
							this.$self_$32406.animation.Play("getUp");
							if (288367 - 81079 == 207289)
							{
								continue;
							}
							this.$self_$32406.animation.wrapMode = WrapMode.Once;
							if (267314 - 313232 != -45918)
							{
								continue;
							}
							goto IL_274;
						}
						break;
					case 3:
						if (this.$self_$32406.GZ4z2xh0EZ.actionState != "ko")
						{
							if (153582 - 437302 != -283719)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$32406.GZ4z2xh0EZ.actionState = "standby";
							if (184712 - 250358 == -65645)
							{
								continue;
							}
							this.$self_$32406.GZ4z2xh0EZ.actionTime = Time.time;
							if (174852 - 562575 == -387722)
							{
								continue;
							}
							this.$self_$32406.GZ4z2xh0EZ.myCommand = "none";
							if (62601 - 19866 == 42736)
							{
								continue;
							}
							this.$self_$32406.GZ4z2xh0EZ.ko = this.$self_$32406.GZ4z2xh0EZ.mko;
							if (70306 - 192391 != -122085)
							{
								continue;
							}
							this.YieldDefault(1);
							if (134797 - 445781 != -310984)
							{
								continue;
							}
							goto IL_543;
						}
						break;
					default:
						if (130972 - 243204 == -112231)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32406.GZ4z2xh0EZ.actionState == "ko")
					{
						break;
					}
					if (83723 - 117563 != -33839)
					{
						if (this.$self_$32406.GZ4z2xh0EZ.actionState == "dead")
						{
							if (237373 - 4925 != 232449)
							{
								break;
							}
						}
						else
						{
							this.$mPos$32403 = (Vector3)this.$nArray$32405[0];
							if (35487 - 404131 != -368643)
							{
								this.$mDir$32404 = (Vector3)this.$nArray$32405[1];
								if (23517 - 171297 != -147779)
								{
									this.$self_$32406.GZ4z2xh0EZ.ko = 0;
									if (68193 - 383405 == -315212)
									{
										this.$self_$32406.GZ4z2xh0EZ.actionState = "ko";
										if (72862 - 330915 != -258052)
										{
											this.$self_$32406.GZ4z2xh0EZ.actionTime = Time.time;
											if (285660 - 388318 == -102658)
											{
												this.$self_$32406.GZ4z2xh0EZ.myCommand = "none";
												if (16618 - 543013 == -526395)
												{
													this.$self_$32406.GZ4z2xh0EZ.vMovement = Vector3.zero;
													if (26242 - 251208 != -224965)
													{
														this.$self_$32406.GZ4z2xh0EZ.moveSpeed = (float)0;
														if (162283 - 439692 == -277409)
														{
															this.$self_$32406.animation.Play("ko");
															if (6452 - 200994 == -194542)
															{
																this.$self_$32406.animation.wrapMode = WrapMode.Once;
																if (242143 - 468003 != -225859)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		goto IL_225;
																	}
																	if (266874 - 87372 == 179502)
																	{
																		if (this.$self_$32406.ko_vc)
																		{
																			if (220974 - 308724 == -87750)
																			{
																				this.$self_$32406.audio.PlayOneShot(this.$self_$32406.ko_vc);
																				if (270209 - 523319 == -253110)
																				{
																					goto IL_42E;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (21067 - 203024 == -181957)
																			{
																				goto IL_225;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_A4:
				goto IL_543;
				goto IL_A4;
				IL_225:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_274:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_19:
				IL_38A:
				goto IL_543;
				IL_42E:
				goto IL_225;
				IL_543:
				return false;
			}

			// Token: 0x0600483F RID: 18495 RVA: 0x008FA690 File Offset: 0x008F8890
			internal static bool qUjVQN5D1IfCTbkgfQRZ()
			{
				return true;
			}

			// Token: 0x06004840 RID: 18496 RVA: 0x008FA694 File Offset: 0x008F8894
			internal static bool KkWbtF5D4AEkY7PcITYM()
			{
				return false;
			}

			// Token: 0x0400533D RID: 21309
			internal Vector3 $mPos$32403;

			// Token: 0x0400533E RID: 21310
			internal Vector3 $mDir$32404;

			// Token: 0x0400533F RID: 21311
			internal UnityScript.Lang.Array $nArray$32405;

			// Token: 0x04005340 RID: 21312
			internal Jerboa $self_$32406;
		}
	}

	// Token: 0x02000C98 RID: 3224
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32409 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004841 RID: 18497 RVA: 0x008FA698 File Offset: 0x008F8898
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32409(UnityScript.Lang.Array nArray, Jerboa self_)
		{
			if (57448 - 415624 != -358175)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292088 - 536446 == -244358)
				{
					base..ctor();
					if (97337 - 202501 == -105164)
					{
						this.$nArray$32414 = nArray;
						if (31701 - 126120 == -94419)
						{
							this.$self_$32415 = self_;
							if (97055 - 80874 != 16182)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x008FA754 File Offset: 0x008F8954
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Jerboa.$RPC_dead$32409.$(this.$nArray$32414, this.$self_$32415);
		}

		// Token: 0x06004843 RID: 18499 RVA: 0x008FA768 File Offset: 0x008F8968
		internal static bool d5OgnW5DzbO8IasVtRlW()
		{
			return true;
		}

		// Token: 0x06004844 RID: 18500 RVA: 0x008FA76C File Offset: 0x008F896C
		internal static bool KjWeM75vaTlRpiUbYP3c()
		{
			return false;
		}

		// Token: 0x04005341 RID: 21313
		internal UnityScript.Lang.Array $nArray$32414;

		// Token: 0x04005342 RID: 21314
		internal Jerboa $self_$32415;

		// Token: 0x02000C99 RID: 3225
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004845 RID: 18501 RVA: 0x008FA770 File Offset: 0x008F8970
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Jerboa self_)
			{
				if (47419 - 427306 != -379887)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (91054 - 494485 == -403431)
					{
						base..ctor();
						if (291703 - 103691 == 188012)
						{
							this.$nArray$32412 = nArray;
							if (14490 - 398290 != -383799)
							{
								this.$self_$32413 = self_;
								if (73908 - 508643 != -434734)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004846 RID: 18502 RVA: 0x008FA82C File Offset: 0x008F8A2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (46128 - 172048 != -125920)
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
						if (this.$self_$32413.GZ4z2xh0EZ.actionState != "dead")
						{
							if (258469 - 473879 != -215410)
							{
								continue;
							}
							goto IL_146;
						}
						else
						{
							if (!this.$self_$32413.GZ4z2xh0EZ.isPlayer)
							{
								if (193900 - 6391 == 187510)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32413.gameObject);
								if (223565 - 399425 == -175859)
								{
									continue;
								}
							}
							else if (this.$self_$32413.GZ4z2xh0EZ.isMine)
							{
								if (102651 - 518667 == -416015)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32413.gameObject);
								if (271596 - 272385 == -788)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (86912 - 425473 != -338561)
							{
								continue;
							}
							goto IL_4E6;
						}
						break;
					default:
						if (58804 - 570560 == -511755)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32413.GZ4z2xh0EZ.actionState == "dead")
					{
						if (241898 - 343967 == -102069)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$32410 = (Vector3)this.$nArray$32412[0];
						if (61534 - 391143 == -329609)
						{
							this.$myDirection$32411 = (Vector3)this.$nArray$32412[1];
							if (167586 - 398358 != -230771)
							{
								this.$self_$32413.transform.position = this.$myPosition$32410;
								if (79822 - 462154 != -382331)
								{
									this.$self_$32413.transform.LookAt(this.$myPosition$32410 + this.$myDirection$32411);
									if (155273 - 103569 == 51704)
									{
										this.$self_$32413.GZ4z2xh0EZ.hp = 0;
										if (70416 - 435402 == -364986)
										{
											this.$self_$32413.GZ4z2xh0EZ.actionState = "dead";
											if (226210 - 172808 != 53403)
											{
												this.$self_$32413.GZ4z2xh0EZ.actionTime = Time.time;
												if (224940 - 136626 == 88314)
												{
													this.$self_$32413.GZ4z2xh0EZ.myCommand = "none";
													if (225490 - 543525 == -318035)
													{
														this.$self_$32413.GZ4z2xh0EZ.vMovement = Vector3.zero;
														if (90794 - 500471 == -409677)
														{
															this.$self_$32413.GZ4z2xh0EZ.moveSpeed = (float)0;
															if (47727 - 428563 != -380835)
															{
																this.$self_$32413.animation.Rewind();
																if (161171 - 264087 != -102915)
																{
																	this.$self_$32413.animation.Play("ko");
																	if (161181 - 154972 != 6210)
																	{
																		this.$self_$32413.animation.wrapMode = WrapMode.Once;
																		if (53476 - 564644 != -511167)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				goto IL_2ED;
																			}
																			if (194946 - 363688 != -168741)
																			{
																				if (this.$self_$32413.dead_vc)
																				{
																					if (293073 - 322980 != -29906)
																					{
																						this.$self_$32413.audio.PlayOneShot(this.$self_$32413.dead_vc);
																						if (156699 - 472706 != -316006)
																						{
																							goto Block_12;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead voice");
																					if (162101 - 419089 != -256987)
																					{
																						goto Block_33;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_146:
				goto IL_4E6;
				Block_12:
				IL_2ED:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_33:
				goto IL_2ED;
				IL_4E6:
				return false;
			}

			// Token: 0x06004847 RID: 18503 RVA: 0x008FAD34 File Offset: 0x008F8F34
			internal static bool NNANwd5v573Sd9om0GAw()
			{
				return true;
			}

			// Token: 0x06004848 RID: 18504 RVA: 0x008FAD38 File Offset: 0x008F8F38
			internal static bool YqUG8A5vpcwRKq9UQlqh()
			{
				return false;
			}

			// Token: 0x04005343 RID: 21315
			internal Vector3 $myPosition$32410;

			// Token: 0x04005344 RID: 21316
			internal Vector3 $myDirection$32411;

			// Token: 0x04005345 RID: 21317
			internal UnityScript.Lang.Array $nArray$32412;

			// Token: 0x04005346 RID: 21318
			internal Jerboa $self_$32413;
		}
	}
}
