using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003D5 RID: 981
[Serializable]
public class Vizie4 : MonoBehaviour
{
	// Token: 0x060016EB RID: 5867 RVA: 0x002599D0 File Offset: 0x00257BD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vizie4()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060016EC RID: 5868 RVA: 0x002599E0 File Offset: 0x00257BE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (99313 - 505528 != -406214)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (167793 - 78983 == 88810)
			{
				this.mChar.actionState = "standby";
				if (299161 - 22852 != 276310)
				{
					this.mChar.actionTime = Time.time;
					if (268535 - 217841 == 50694)
					{
						this.mChar.myCommand = "none";
						if (203333 - 295187 != -91853)
						{
							this.mChar.hp = (this.mChar.mhp = 4100);
							if (165978 - 128835 == 37143)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (1870 - 370860 == -368990)
								{
									this.mChar.isMine = true;
									if (181669 - 220896 != -39226)
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

	// Token: 0x060016ED RID: 5869 RVA: 0x00259B50 File Offset: 0x00257D50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (164540 - 509877 != -345337)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (195864 - 261687 != -65823)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (133198 - 478317 != -345119)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_146;
					}
					if (162502 - 429373 != -266871)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (115393 - 416024 != -300631)
				{
					continue;
				}
			}
			IL_146:
			if (this.mChar.hp > 0)
			{
				break;
			}
			if (230868 - 56842 == 174026)
			{
				if (!(this.mChar.actionState != "dead"))
				{
					break;
				}
				if (211790 - 295396 == -83606)
				{
					if (this.mChar.isMine)
					{
						if (78353 - 88715 != -10361)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (96731 - 575464 != -478732)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (226896 - 469308 != -242411)
								{
									this.mChar.DeadEvent();
									if (143236 - 169030 != -25793)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (63828 - 360242 != -296413)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060016EE RID: 5870 RVA: 0x00259D90 File Offset: 0x00257F90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (285271 - 272128 != 13144)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (195686 - 93508 != 102179)
			{
				float runSpeed = this.mChar.runSpeed;
				if (237585 - 335941 == -98356)
				{
					Vector3 a = default(Vector3);
					if (143720 - 211378 == -67658)
					{
						Vector3 vector = Vector3.zero;
						if (138345 - 104377 != 33969)
						{
							float num2 = (float)0;
							if (137178 - 269893 == -132715)
							{
								if (this.mChar.isMine)
								{
									if (233676 - 474254 == -240577)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (152881 - 296565 != -143684)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (256755 - 573979 == -317223)
										{
											continue;
										}
										a.y = (float)0;
										if (33828 - 37454 != -3626)
										{
											continue;
										}
										a = a.normalized;
										if (293884 - 20178 != 273706)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (51740 - 355982 != -304242)
										{
											continue;
										}
										vector = vector.normalized;
										if (90608 - 204315 == -113706)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (93615 - 335995 != -242380)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (100643 - 34803 != 65840)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (143481 - 78225 == 65257)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (111492 - 212598 != -101106)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (235408 - 321450 == -86041)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (100816 - 337524 == -236707)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (208259 - 512235 == -303975)
														{
															continue;
														}
														this.animation.Play("run");
														if (141567 - 297948 == -156380)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (47948 - 145720 != -97772)
														{
															continue;
														}
														goto IL_A9D;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (141205 - 8155 != 133050)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (134593 - 590647 == -456053)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (106044 - 588418 == -482373)
											{
												continue;
											}
											num = (float)0;
											if (197617 - 67044 == 130574)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (178828 - 78058 != 100770)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (19011 - 162266 != -143255)
										{
											continue;
										}
									}
									IL_A9D:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (209014 - 252825 == -43810)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (200794 - 464629 != -263835)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (38899 - 176943 == -138043)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (292337 - 198369 == 93969)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (232761 - 335041 != -102280)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (256342 - 540371 != -284029)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (173254 - 445356 != -272102)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (201248 - 315738 == -114489)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (267836 - 348621 == -80784)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (136501 - 592168 != -455667)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (211501 - 64576 != 146925)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (9107 - 249702 != -240595)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (289427 - 516479 == -227051)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (74096 - 64117 != 9979)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (211310 - 220417 == -9106)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (105451 - 225525 != -120074)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (12533 - 419138 == -406604)
												{
													continue;
												}
												num = (float)0;
												if (88106 - 490859 == -402752)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (71764 - 36849 != 34915)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (174528 - 154861 != 19667)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (207141 - 199749 != 7392)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (10 - 386964 != -386954)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (37563 - 121661 == -84097)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (260320 - 338637 == -78316)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (224188 - 299578 != -75390)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (96808 - 363693 == -266884)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (9068 - 422835 == -413766)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (72223 - 515697 == -443473)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (73848 - 36813 == 37036)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (157158 - 363933 != -206775)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (274018 - 412710 == -138691)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (123025 - 82800 == 40226)
											{
												continue;
											}
											num = (float)0;
											if (170115 - 79881 == 90235)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (267321 - 92538 != 174783)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (78606 - 179729 != -101123)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (293 - 519960 != -519667)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (95208 - 189946 != -94738)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (289221 - 195063 != 94159)
								{
									this.mChar.moveSpeed = num;
									if (127410 - 566656 != -439245)
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

	// Token: 0x060016EF RID: 5871 RVA: 0x0025A8F4 File Offset: 0x00258AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (169622 - 524547 != -354924)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (178241 - 593730 == -415489)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (283093 - 385838 != -102744)
				{
					if (216172 - 515866 == -299694)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (190787 - 389250 != -198463)
							{
								continue;
							}
							v = 1;
							if (234984 - 61969 != 173015)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (173103 - 269296 == -96192)
							{
								continue;
							}
							v = -1;
							if (7607 - 80085 != -72478)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_malstorm")
						{
							if (243503 - 90704 == 152800)
							{
								continue;
							}
							v = 11;
							if (540 - 371447 == -370906)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_malstorm_fire")
						{
							if (221172 - 29991 == 191182)
							{
								continue;
							}
							v = 12;
							if (40432 - 151311 == -110878)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (59106 - 50345 != 8762)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (100698 - 543497 != -442798)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (251562 - 556335 != -304772)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (66413 - 438716 != -372302)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (104894 - 1205 == 103689)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (116162 - 112243 == 3919)
											{
												Hashtable hashtable = new Hashtable();
												if (287044 - 355645 != -68600)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (103708 - 84298 == 19410)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (42164 - 318052 != -275887)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (261242 - 101694 != 159549)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (80762 - 566131 != -485368)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (75418 - 196677 == -121259)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (115811 - 582783 == -466972)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (172103 - 251679 == -79576)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (61465 - 156487 == -95022)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (81522 - 552815 != -471292)
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

	// Token: 0x060016F0 RID: 5872 RVA: 0x0025ADE0 File Offset: 0x00258FE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (285816 - 114173 != 171643)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (228855 - 66831 == 162024)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (155802 - 49794 == 106008)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (243321 - 504368 != -261046)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (91045 - 338667 != -247621)
						{
							int num3 = num;
							if (253156 - 65777 == 187379)
							{
								if (num3 == 1)
								{
									if (262595 - 33581 != 229015)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (270488 - 377147 == -106659)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (86976 - 88658 != -1681)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (152743 - 26997 == 125746)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (187979 - 356778 == -168799)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (242834 - 100367 == 142467)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (88067 - 163722 != -75654)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (190982 - 519007 == -328025)
										{
											this.StartCoroutine_Auto(this.RPC_malstorm(vector, vector2, num2));
											if (296506 - 362956 != -66449)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (38974 - 589559 == -550585)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (217196 - 320328 == -103132)
										{
											this.StartCoroutine_Auto(this.RPC_malstorm_fire(vector, vector2, num2));
											if (143277 - 281356 != -138078)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (198856 - 470543 == -271687)
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

	// Token: 0x060016F1 RID: 5873 RVA: 0x0025B16C File Offset: 0x0025936C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (25744 - 2218 != 23526)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (89246 - 358669 == -269423)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (290574 - 589315 != -298740)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (271928 - 433683 != -161754)
					{
						Vector3 normalized = vector.normalized;
						if (178993 - 105158 == 73835)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (244269 - 386456 == -142187)
							{
								if (216796 - 530834 != -314037)
								{
									if (gameObject)
									{
										if (88367 - 32519 == 55849)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (223972 - 426243 == -202270)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (88995 - 20818 != 68177)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (83036 - 316844 == -233807)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (95051 - 476448 == -381397)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
										if (29399 - 396876 != -367476)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (77864 - 546544 != -468679)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
												if (246901 - 70928 == 175973)
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

	// Token: 0x060016F2 RID: 5874 RVA: 0x0025B428 File Offset: 0x00259628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x060016F3 RID: 5875 RVA: 0x0025B440 File Offset: 0x00259640
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060016F4 RID: 5876 RVA: 0x0025B444 File Offset: 0x00259644
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Vizie4.$RPC_nAttack$19113(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060016F5 RID: 5877 RVA: 0x0025B454 File Offset: 0x00259654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x060016F6 RID: 5878 RVA: 0x0025B480 File Offset: 0x00259680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_malstorm(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Vizie4.$RPC_malstorm$19126(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060016F7 RID: 5879 RVA: 0x0025B490 File Offset: 0x00259690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_malstorm_fire(Vector3 tPos, Vector3 tDir, int tID)
	{
		return new Vizie4.$RPC_malstorm_fire$19137(tPos, this).GetEnumerator();
	}

	// Token: 0x060016F8 RID: 5880 RVA: 0x0025B4A0 File Offset: 0x002596A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x060016F9 RID: 5881 RVA: 0x0025B4A4 File Offset: 0x002596A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Vizie4.$RPC_dead$19147(nArray, this).GetEnumerator();
	}

	// Token: 0x060016FA RID: 5882 RVA: 0x0025B4B4 File Offset: 0x002596B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060016FB RID: 5883 RVA: 0x0025B4B8 File Offset: 0x002596B8
	internal static bool c8qsyIMdRlbeCErIJ2t()
	{
		return true;
	}

	// Token: 0x060016FC RID: 5884 RVA: 0x0025B4BC File Offset: 0x002596BC
	internal static bool pwlLDnMJJf8NZ7XlR7s()
	{
		return false;
	}

	// Token: 0x0400138B RID: 5003
	public CharacterControl mChar;

	// Token: 0x0400138C RID: 5004
	public GameObject nAttack_wave;

	// Token: 0x0400138D RID: 5005
	public GameObject nAttack_hit;

	// Token: 0x0400138E RID: 5006
	public GameObject malstorm;

	// Token: 0x020003D6 RID: 982
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$19113 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060016FD RID: 5885 RVA: 0x0025B4C0 File Offset: 0x002596C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$19113(Vector3 mPos, Vector3 tDir, Vizie4 self_)
		{
			if (82925 - 477522 != -394597)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (24242 - 172408 == -148166)
				{
					base..ctor();
					if (75068 - 99670 != -24601)
					{
						this.$mPos$19123 = mPos;
						if (170092 - 393296 != -223203)
						{
							this.$tDir$19124 = tDir;
							if (134482 - 477583 == -343101)
							{
								this.$self_$19125 = self_;
								if (76901 - 81420 != -4518)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0025B59C File Offset: 0x0025979C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Vizie4.$RPC_nAttack$19113.$(this.$mPos$19123, this.$tDir$19124, this.$self_$19125);
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0025B5B8 File Offset: 0x002597B8
		internal static bool vgOfH2MDxgTq256697i()
		{
			return true;
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x0025B5BC File Offset: 0x002597BC
		internal static bool tHU1fEMvGsZnETZWF4Z()
		{
			return false;
		}

		// Token: 0x0400138F RID: 5007
		internal Vector3 $mPos$19123;

		// Token: 0x04001390 RID: 5008
		internal Vector3 $tDir$19124;

		// Token: 0x04001391 RID: 5009
		internal Vizie4 $self_$19125;

		// Token: 0x020003D7 RID: 983
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001701 RID: 5889 RVA: 0x0025B5C0 File Offset: 0x002597C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Vizie4 self_)
			{
				if (195464 - 576951 != -381486)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (84416 - 412936 == -328520)
					{
						base..ctor();
						if (156921 - 311217 != -154295)
						{
							this.$mPos$19120 = mPos;
							if (144445 - 445715 != -301269)
							{
								this.$tDir$19121 = tDir;
								if (35061 - 267384 != -232322)
								{
									this.$self_$19122 = self_;
									if (274322 - 408759 == -134437)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001702 RID: 5890 RVA: 0x0025B69C File Offset: 0x0025989C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (51282 - 476647 != -425365)
				{
				}
				for (;;)
				{
					IL_2A4:
					switch (this._state)
					{
					case 0:
						goto IL_55E;
					case 1:
						goto IL_AB2;
					case 2:
						if (this.$self_$19122.mChar.actionState != "attack")
						{
							goto IL_960;
						}
						if (85064 - 101056 != -15992)
						{
							continue;
						}
						if (this.$self_$19122.mChar.myCommand != "nAttack")
						{
							if (207061 - 178130 != 28932)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$self_$19122.mChar.moveSpeed = (float)6;
							if (201168 - 339583 != -138415)
							{
								continue;
							}
							if (this.$self_$19122.nAttack_wave)
							{
								if (197951 - 178693 != 19258)
								{
									continue;
								}
								this.$self_$19122.mChar.createEffect(this.$self_$19122.nAttack_wave, this.$self_$19122.transform.position, this.$self_$19122.transform.rotation);
								if (73136 - 484653 != -411517)
								{
									continue;
								}
								goto IL_9C0;
							}
							else
							{
								Debug.LogError("Cannot find nAttack_wave effect");
								if (202184 - 499482 != -297297)
								{
									goto Block_62;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$19122.mChar.actionState != "attack")
						{
							goto IL_A80;
						}
						if (48069 - 440479 == -392409)
						{
							continue;
						}
						if (this.$self_$19122.mChar.myCommand != "nAttack")
						{
							if (24405 - 62806 != -38401)
							{
								continue;
							}
							goto IL_A80;
						}
						else
						{
							this.$self_$19122.mChar.moveSpeed = (float)12;
							if (173385 - 66472 == 106914)
							{
								continue;
							}
							this.$hitLayer$19114 = 130816 - (1 << this.$self_$19122.gameObject.layer);
							if (149335 - 169171 == -19835)
							{
								continue;
							}
							this.$hitList$19115 = null;
							if (138439 - 297890 != -159451)
							{
								continue;
							}
							this.$hitPos$19116 = default(Vector3);
							if (81778 - 89082 == -7303)
							{
								continue;
							}
							this.$i$19117 = 0;
							if (83289 - 164275 != -80986)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$19122.mChar.actionState != "attack")
						{
							goto IL_1A;
						}
						if (240625 - 350545 == -109919)
						{
							continue;
						}
						if (this.$self_$19122.mChar.myCommand != "nAttack")
						{
							if (149479 - 74808 != 74672)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$i$19117++;
							if (221725 - 415614 == -193888)
							{
								continue;
							}
						}
						break;
					default:
						if (147965 - 151031 != -3065)
						{
							goto IL_55E;
						}
						continue;
					}
					if (this.$i$19117 >= 4)
					{
						if (133938 - 252637 != -118699)
						{
							continue;
						}
						this.$self_$19122.mChar.moveSpeed = (float)0;
						if (67584 - 39182 == 28403)
						{
							continue;
						}
						if (this.$self_$19122.mChar.actionState == "attack")
						{
							if (228584 - 365296 == -136711)
							{
								continue;
							}
							if (this.$self_$19122.mChar.myCommand == "nAttack")
							{
								if (123005 - 493099 == -370093)
								{
									continue;
								}
								this.$self_$19122.mChar.actionState = "standby";
								if (148507 - 409412 != -260905)
								{
									continue;
								}
								this.$self_$19122.mChar.actionTime = Time.time;
								if (46834 - 355443 == -308608)
								{
									continue;
								}
								this.$self_$19122.mChar.myCommand = "none";
								if (22927 - 330324 == -307396)
								{
									continue;
								}
								if (!this.$self_$19122.mChar.isMine)
								{
									if (199280 - 142179 == 57102)
									{
										continue;
									}
									this.$self_$19122.mChar.nPosition = this.$self_$19122.transform.position;
									if (26678 - 503280 == -476601)
									{
										continue;
									}
									this.$self_$19122.mChar.oPosition = this.$self_$19122.transform.position;
									if (114860 - 200051 != -85191)
									{
										continue;
									}
									this.$self_$19122.mChar.nDirection = this.$self_$19122.transform.forward;
									if (228169 - 440900 == -212730)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (235173 - 396943 != -161769)
						{
							break;
						}
						continue;
					}
					else
					{
						if (!this.$self_$19122.mChar.isMine)
						{
							goto IL_4EE;
						}
						if (113911 - 414785 == -300873)
						{
							continue;
						}
						this.$hitList$19115 = Damage.FindRecTarget(this.$self_$19122.transform.position, this.$self_$19122.transform.forward, (float)3, (float)2, (float)5, (float)3, this.$hitLayer$19114);
						if (67986 - 585549 == -517562)
						{
							continue;
						}
						this.$$iterator$10504$19119 = UnityRuntimeServices.GetEnumerator(this.$hitList$19115);
						if (23527 - 113450 != -89923)
						{
							continue;
						}
						while (this.$$iterator$10504$19119.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10504$19119.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$19118 = (GameObject)obj2;
							if (116060 - 548994 == -432933)
							{
								goto IL_2A4;
							}
							if (this.$self_$19122.mChar.hit(1, this.$hitObject$19118, (int)(0.5f * (float)this.$self_$19122.mChar.atk), 1, 0, 0.5f * this.$self_$19122.transform.forward) != 0)
							{
								if (194521 - 322534 != -128013)
								{
									goto IL_2A4;
								}
								this.$hitPos$19116 = this.$hitObject$19118.collider.ClosestPointOnBounds(this.$self_$19122.transform.position + Vector3.up);
								if (230714 - 333151 != -102437)
								{
									goto IL_2A4;
								}
								UnityRuntimeServices.Update(this.$$iterator$10504$19119, this.$hitObject$19118);
								if (41560 - 534612 != -493052)
								{
									goto IL_2A4;
								}
								this.$self_$19122.RPC_nAttack_hit(this.$hitPos$19116, this.$self_$19122.transform.forward, 0);
								if (247925 - 171782 == 76144)
								{
									goto IL_2A4;
								}
								if (PhotonClient.IsInitialized())
								{
									if (289156 - 386820 == -97663)
									{
										goto IL_2A4;
									}
									this.$self_$19122.ActionEvent("RPC_nAttack_hit", this.$hitPos$19116, this.$self_$19122.transform.forward, 0);
									if (275426 - 540445 != -265019)
									{
										goto IL_2A4;
									}
								}
							}
						}
						if (200969 - 297304 != -96334)
						{
							goto Block_22;
						}
						continue;
					}
					IL_55E:
					this.$self_$19122.mChar.actionState = "attack";
					if (283583 - 347916 != -64332)
					{
						this.$self_$19122.mChar.actionTime = Time.time;
						if (232118 - 506906 != -274787)
						{
							this.$self_$19122.mChar.myCommand = "nAttack";
							if (31687 - 175151 == -143464)
							{
								this.$self_$19122.mChar.addTimeOut("nAttack", (float)3);
								if (20803 - 215611 == -194808)
								{
									this.$self_$19122.transform.position = this.$mPos$19120;
									if (63714 - 79941 == -16227)
									{
										this.$self_$19122.transform.LookAt(this.$mPos$19120 + global::Math.vFlat(this.$tDir$19121));
										if (138861 - 423019 == -284158)
										{
											this.$self_$19122.animation.CrossFade("nAttack");
											if (141632 - 584083 != -442450)
											{
												this.$self_$19122.animation.wrapMode = WrapMode.Once;
												if (291186 - 229023 == 62163)
												{
													this.$self_$19122.mChar.vMovement = this.$self_$19122.transform.forward;
													if (239446 - 525169 != -285722)
													{
														this.$self_$19122.mChar.moveSpeed = (float)0;
														if (283385 - 381024 != -97638)
														{
															goto Block_27;
														}
													}
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
				goto IL_AB2;
				Block_6:
				goto IL_1A;
				Block_22:
				goto IL_4EE;
				Block_26:
				goto IL_960;
				Block_27:
				return this.Yield(2, new WaitForSeconds(0.45f));
				IL_4EE:
				return this.Yield(4, new WaitForSeconds(0.25f));
				IL_703:
				return this.Yield(3, new WaitForSeconds(0.15f));
				IL_960:
				goto IL_AB2;
				IL_9C0:
				Block_62:
				goto IL_703;
				IL_A80:
				IL_AB2:
				return false;
			}

			// Token: 0x06001703 RID: 5891 RVA: 0x0025C170 File Offset: 0x0025A370
			internal static bool Mg3c9IMRTB1WFbugVN6()
			{
				return true;
			}

			// Token: 0x06001704 RID: 5892 RVA: 0x0025C174 File Offset: 0x0025A374
			internal static bool wHcSMTMwoL5NURWHsee()
			{
				return false;
			}

			// Token: 0x04001392 RID: 5010
			internal int $hitLayer$19114;

			// Token: 0x04001393 RID: 5011
			internal UnityScript.Lang.Array $hitList$19115;

			// Token: 0x04001394 RID: 5012
			internal Vector3 $hitPos$19116;

			// Token: 0x04001395 RID: 5013
			internal int $i$19117;

			// Token: 0x04001396 RID: 5014
			internal GameObject $hitObject$19118;

			// Token: 0x04001397 RID: 5015
			internal IEnumerator $$iterator$10504$19119;

			// Token: 0x04001398 RID: 5016
			internal Vector3 $mPos$19120;

			// Token: 0x04001399 RID: 5017
			internal Vector3 $tDir$19121;

			// Token: 0x0400139A RID: 5018
			internal Vizie4 $self_$19122;
		}
	}

	// Token: 0x020003D8 RID: 984
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_malstorm$19126 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001705 RID: 5893 RVA: 0x0025C178 File Offset: 0x0025A378
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_malstorm$19126(Vector3 mPos, Vector3 tDir, int tID, Vizie4 self_)
		{
			if (246954 - 504751 != -257797)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (281061 - 520036 == -238975)
				{
					base..ctor();
					if (248394 - 326427 == -78033)
					{
						this.$mPos$19133 = mPos;
						if (289375 - 342047 != -52671)
						{
							this.$tDir$19134 = tDir;
							if (246109 - 220045 != 26065)
							{
								this.$tID$19135 = tID;
								if (86475 - 304186 != -217710)
								{
									this.$self_$19136 = self_;
									if (75910 - 221285 == -145375)
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

		// Token: 0x06001706 RID: 5894 RVA: 0x0025C278 File Offset: 0x0025A478
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Vizie4.$RPC_malstorm$19126.$(this.$mPos$19133, this.$tDir$19134, this.$tID$19135, this.$self_$19136);
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x0025C298 File Offset: 0x0025A498
		internal static bool aOmZZyMqOmFpnHd1bTU()
		{
			return true;
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x0025C29C File Offset: 0x0025A49C
		internal static bool IGyyW0M7anAy4ycZIRH()
		{
			return false;
		}

		// Token: 0x0400139B RID: 5019
		internal Vector3 $mPos$19133;

		// Token: 0x0400139C RID: 5020
		internal Vector3 $tDir$19134;

		// Token: 0x0400139D RID: 5021
		internal int $tID$19135;

		// Token: 0x0400139E RID: 5022
		internal Vizie4 $self_$19136;

		// Token: 0x020003D9 RID: 985
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001709 RID: 5897 RVA: 0x0025C2A0 File Offset: 0x0025A4A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Vizie4 self_)
			{
				if (290237 - 302022 != -11785)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (285200 - 221204 != 63997)
					{
						base..ctor();
						if (213717 - 419472 != -205754)
						{
							this.$mPos$19129 = mPos;
							if (100523 - 60902 == 39621)
							{
								this.$tDir$19130 = tDir;
								if (174614 - 593669 != -419054)
								{
									this.$tID$19131 = tID;
									if (64293 - 401946 != -337652)
									{
										this.$self_$19132 = self_;
										if (131514 - 408659 != -277144)
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

			// Token: 0x0600170A RID: 5898 RVA: 0x0025C3A0 File Offset: 0x0025A5A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7420 - 307692 != -300271)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_69A;
					case 2:
						if (this.$self_$19132.mChar.actionState != "attack")
						{
							goto IL_6C;
						}
						if (249879 - 573540 != -323661)
						{
							continue;
						}
						if (this.$self_$19132.mChar.myCommand != "malstorm")
						{
							if (73910 - 120241 != -46330)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19132.mChar.isMine)
							{
								goto IL_5ED;
							}
							if (299804 - 185562 == 114243)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$19131];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$19127 = (GameObject)obj2;
							if (217336 - 560950 == -343613)
							{
								continue;
							}
							this.$tChar$19128 = null;
							if (7816 - 41563 != -33747)
							{
								continue;
							}
							if (!this.$tObject$19127)
							{
								goto IL_5ED;
							}
							if (83890 - 62438 == 21453)
							{
								continue;
							}
							this.$self_$19132.StartCoroutine_Auto(this.$self_$19132.RPC_malstorm_fire(this.$tObject$19127.transform.position, this.$self_$19132.transform.forward, 0));
							if (71118 - 474406 != -403288)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_5ED;
							}
							if (208235 - 30174 != 178061)
							{
								continue;
							}
							this.$self_$19132.ActionEvent("RPC_malstorm_fire", this.$tObject$19127.transform.position, this.$self_$19132.transform.forward, 0);
							if (283723 - 487057 != -203334)
							{
								continue;
							}
							goto IL_5ED;
						}
						break;
					case 3:
						if (this.$self_$19132.mChar.actionState == "attack")
						{
							if (189261 - 412711 == -223449)
							{
								continue;
							}
							if (this.$self_$19132.mChar.myCommand == "malstorm")
							{
								if (192866 - 6672 == 186195)
								{
									continue;
								}
								this.$self_$19132.mChar.moveSpeed = (float)0;
								if (46524 - 78336 == -31811)
								{
									continue;
								}
								this.$self_$19132.mChar.actionState = "standby";
								if (243448 - 271685 != -28237)
								{
									continue;
								}
								this.$self_$19132.mChar.actionTime = Time.time;
								if (187162 - 376594 == -189431)
								{
									continue;
								}
								this.$self_$19132.mChar.myCommand = "none";
								if (123194 - 164736 != -41542)
								{
									continue;
								}
								if (!this.$self_$19132.mChar.isMine)
								{
									if (142143 - 38164 != 103979)
									{
										continue;
									}
									this.$self_$19132.mChar.nPosition = this.$self_$19132.transform.position;
									if (91037 - 246486 == -155448)
									{
										continue;
									}
									this.$self_$19132.mChar.oPosition = this.$self_$19132.transform.position;
									if (28889 - 111164 == -82274)
									{
										continue;
									}
									this.$self_$19132.mChar.nDirection = this.$self_$19132.transform.forward;
									if (157511 - 391402 == -233890)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (152970 - 155744 != -2774)
						{
							continue;
						}
						goto IL_69A;
					default:
						if (299732 - 190246 == 109487)
						{
							continue;
						}
						break;
					}
					this.$self_$19132.mChar.actionState = "attack";
					if (210471 - 227934 == -17463)
					{
						this.$self_$19132.mChar.actionTime = Time.time;
						if (167349 - 554494 != -387144)
						{
							this.$self_$19132.mChar.myCommand = "malstorm";
							if (208792 - 179939 == 28853)
							{
								this.$self_$19132.mChar.addTimeOut("malstorm", (float)12);
								if (166118 - 234892 != -68773)
								{
									this.$self_$19132.transform.position = this.$mPos$19129;
									if (114118 - 536568 != -422449)
									{
										this.$self_$19132.transform.LookAt(this.$mPos$19129 + global::Math.vFlat(this.$tDir$19130));
										if (69899 - 204958 != -135058)
										{
											this.$self_$19132.animation.CrossFade("cast");
											if (297280 - 544513 == -247233)
											{
												this.$self_$19132.animation.wrapMode = WrapMode.Once;
												if (232201 - 197594 != 34608)
												{
													this.$self_$19132.mChar.vMovement = this.$self_$19132.transform.forward;
													if (258784 - 121115 != 137670)
													{
														this.$self_$19132.mChar.moveSpeed = (float)0;
														if (199445 - 498689 != -299243)
														{
															goto Block_20;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_6C:
				goto IL_69A;
				Block_20:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_38:
				goto IL_6C;
				IL_5ED:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_69A:
				return false;
			}

			// Token: 0x0600170B RID: 5899 RVA: 0x0025CA5C File Offset: 0x0025AC5C
			internal static bool L2kSBHMPXYOl0dQBBE2()
			{
				return true;
			}

			// Token: 0x0600170C RID: 5900 RVA: 0x0025CA60 File Offset: 0x0025AC60
			internal static bool vSxYG0M0jABPeVJWEcq()
			{
				return false;
			}

			// Token: 0x0400139F RID: 5023
			internal GameObject $tObject$19127;

			// Token: 0x040013A0 RID: 5024
			internal CharacterControl $tChar$19128;

			// Token: 0x040013A1 RID: 5025
			internal Vector3 $mPos$19129;

			// Token: 0x040013A2 RID: 5026
			internal Vector3 $tDir$19130;

			// Token: 0x040013A3 RID: 5027
			internal int $tID$19131;

			// Token: 0x040013A4 RID: 5028
			internal Vizie4 $self_$19132;
		}
	}

	// Token: 0x020003DA RID: 986
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_malstorm_fire$19137 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600170D RID: 5901 RVA: 0x0025CA64 File Offset: 0x0025AC64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_malstorm_fire$19137(Vector3 tPos, Vizie4 self_)
		{
			if (49760 - 159144 != -109383)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131771 - 546091 != -414319)
				{
					base..ctor();
					if (227692 - 144090 == 83602)
					{
						this.$tPos$19145 = tPos;
						if (116430 - 450913 != -334482)
						{
							this.$self_$19146 = self_;
							if (28226 - 410545 != -382318)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x0025CB20 File Offset: 0x0025AD20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Vizie4.$RPC_malstorm_fire$19137.$(this.$tPos$19145, this.$self_$19146);
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x0025CB34 File Offset: 0x0025AD34
		internal static bool tutHGDMbJLIM8rtrY56()
		{
			return true;
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x0025CB38 File Offset: 0x0025AD38
		internal static bool auVCbEMu45aFE2WAnrX()
		{
			return false;
		}

		// Token: 0x040013A5 RID: 5029
		internal Vector3 $tPos$19145;

		// Token: 0x040013A6 RID: 5030
		internal Vizie4 $self_$19146;

		// Token: 0x020003DB RID: 987
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001711 RID: 5905 RVA: 0x0025CB3C File Offset: 0x0025AD3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 tPos, Vizie4 self_)
			{
				if (44787 - 370114 != -325326)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (148508 - 539351 == -390843)
					{
						base..ctor();
						if (224930 - 38205 != 186726)
						{
							this.$tPos$19143 = tPos;
							if (282660 - 473266 != -190605)
							{
								this.$self_$19144 = self_;
								if (64117 - 239739 == -175622)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001712 RID: 5906 RVA: 0x0025CBF8 File Offset: 0x0025ADF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229767 - 158851 != 70917)
				{
				}
				for (;;)
				{
					IL_1A:
					switch (this._state)
					{
					case 0:
						goto IL_288;
					case 1:
						goto IL_34F;
					case 2:
						if (!this.$self_$19144.mChar.isMine)
						{
							goto IL_32D;
						}
						if (204213 - 31280 == 172934)
						{
							continue;
						}
						this.$hitLayer$19138 = 130816 - (1 << this.$self_$19144.gameObject.layer);
						if (5999 - 420851 != -414852)
						{
							continue;
						}
						this.$i$19139 = 0;
						if (101176 - 393320 == -292143)
						{
							continue;
						}
						break;
					case 3:
						this.$i$19139++;
						if (238700 - 174380 != 64320)
						{
							continue;
						}
						break;
					default:
						if (127082 - 79896 != 47187)
						{
							goto IL_288;
						}
						continue;
					}
					if (this.$i$19139 >= 2)
					{
						if (15655 - 150552 != -134896)
						{
							goto IL_32D;
						}
						continue;
					}
					else
					{
						this.$hitList$19140 = Damage.FindAreaTarget(this.$tPos$19143, (float)6 * this.$self_$19144.mChar.rangeMod, (float)5 * this.$self_$19144.mChar.rangeMod, this.$hitLayer$19138);
						if (276528 - 33250 != 243278)
						{
							continue;
						}
						this.$$iterator$10505$19142 = UnityRuntimeServices.GetEnumerator(this.$hitList$19140);
						if (295970 - 496465 == -200494)
						{
							continue;
						}
						while (this.$$iterator$10505$19142.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10505$19142.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$19141 = (GameObject)obj2;
							if (19857 - 344428 != -324571)
							{
								goto IL_1A;
							}
							this.$self_$19144.mChar.hit(11, this.$hitObject$19141, this.$self_$19144.mChar.talAdjust(40), 1, 0, Vector3.zero);
							if (203915 - 116030 != 87885)
							{
								goto IL_1A;
							}
							UnityRuntimeServices.Update(this.$$iterator$10505$19142, this.$hitObject$19141);
							if (198103 - 21980 == 176124)
							{
								goto IL_1A;
							}
						}
						if (122007 - 382796 != -260788)
						{
							goto Block_13;
						}
						continue;
					}
					IL_288:
					if (!this.$self_$19144.malstorm)
					{
						break;
					}
					if (230724 - 88874 == 141851)
					{
						continue;
					}
					UnityEngine.Object.Instantiate(this.$self_$19144.malstorm, this.$tPos$19143, Quaternion.identity);
					if (166578 - 210584 != -44006)
					{
						continue;
					}
					break;
					IL_32D:
					this.YieldDefault(1);
					if (2158 - 495705 != -493546)
					{
						goto IL_34F;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_13:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_34F:
				return false;
			}

			// Token: 0x06001713 RID: 5907 RVA: 0x0025CF68 File Offset: 0x0025B168
			internal static bool uwaCU3MI4e0CMSVN6P4()
			{
				return true;
			}

			// Token: 0x06001714 RID: 5908 RVA: 0x0025CF6C File Offset: 0x0025B16C
			internal static bool Xjw8utMBUK0MnLo73nV()
			{
				return false;
			}

			// Token: 0x040013A7 RID: 5031
			internal int $hitLayer$19138;

			// Token: 0x040013A8 RID: 5032
			internal int $i$19139;

			// Token: 0x040013A9 RID: 5033
			internal UnityScript.Lang.Array $hitList$19140;

			// Token: 0x040013AA RID: 5034
			internal GameObject $hitObject$19141;

			// Token: 0x040013AB RID: 5035
			internal IEnumerator $$iterator$10505$19142;

			// Token: 0x040013AC RID: 5036
			internal Vector3 $tPos$19143;

			// Token: 0x040013AD RID: 5037
			internal Vizie4 $self_$19144;
		}
	}

	// Token: 0x020003DC RID: 988
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19147 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001715 RID: 5909 RVA: 0x0025CF70 File Offset: 0x0025B170
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19147(UnityScript.Lang.Array nArray, Vizie4 self_)
		{
			if (124131 - 97547 != 26585)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (112998 - 261072 == -148074)
				{
					base..ctor();
					if (138301 - 262968 == -124667)
					{
						this.$nArray$19152 = nArray;
						if (185443 - 481589 != -296145)
						{
							this.$self_$19153 = self_;
							if (244438 - 432477 != -188038)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x0025D02C File Offset: 0x0025B22C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Vizie4.$RPC_dead$19147.$(this.$nArray$19152, this.$self_$19153);
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0025D040 File Offset: 0x0025B240
		internal static bool nQHhZxMeNg9Ag5kCxrx()
		{
			return true;
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x0025D044 File Offset: 0x0025B244
		internal static bool mOToAPMrGs5eqwAvmDa()
		{
			return false;
		}

		// Token: 0x040013AE RID: 5038
		internal UnityScript.Lang.Array $nArray$19152;

		// Token: 0x040013AF RID: 5039
		internal Vizie4 $self_$19153;

		// Token: 0x020003DD RID: 989
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001719 RID: 5913 RVA: 0x0025D048 File Offset: 0x0025B248
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Vizie4 self_)
			{
				if (213928 - 337143 != -123214)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (165575 - 192031 != -26455)
					{
						base..ctor();
						if (270202 - 149278 != 120925)
						{
							this.$nArray$19150 = nArray;
							if (162905 - 584037 != -421131)
							{
								this.$self_$19151 = self_;
								if (243968 - 158872 != 85097)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600171A RID: 5914 RVA: 0x0025D104 File Offset: 0x0025B304
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (257506 - 205144 != 52363)
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
						if (this.$self_$19151.mChar.actionState != "dead")
						{
							if (152153 - 23753 != 128401)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19151.mChar.isPlayer)
							{
								if (212691 - 314707 != -102016)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$19151.gameObject);
								if (122969 - 86438 != 36531)
								{
									continue;
								}
							}
							else if (this.$self_$19151.mChar.isMine)
							{
								if (70554 - 103798 != -33244)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$19151.gameObject);
								if (68231 - 377087 == -308855)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (228905 - 117636 != 111269)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (65563 - 13472 == 52092)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19151.mChar.actionState == "dead")
					{
						if (249503 - 279830 != -30326)
						{
							goto Block_14;
						}
					}
					else
					{
						this.$myPosition$19148 = (Vector3)this.$nArray$19150[0];
						if (273100 - 287698 == -14598)
						{
							this.$myDirection$19149 = (Vector3)this.$nArray$19150[1];
							if (41338 - 347846 != -306507)
							{
								this.$self_$19151.transform.position = this.$myPosition$19148;
								if (125926 - 290118 == -164192)
								{
									this.$self_$19151.transform.LookAt(this.$myPosition$19148 + this.$myDirection$19149);
									if (218985 - 283703 == -64718)
									{
										this.$self_$19151.mChar.hp = 0;
										if (288529 - 443481 != -154951)
										{
											this.$self_$19151.mChar.actionState = "dead";
											if (106031 - 67473 == 38558)
											{
												this.$self_$19151.mChar.actionTime = Time.time;
												if (240464 - 150405 != 90060)
												{
													this.$self_$19151.mChar.myCommand = "none";
													if (58452 - 258988 != -200535)
													{
														this.$self_$19151.mChar.vMovement = Vector3.zero;
														if (107320 - 231303 != -123982)
														{
															this.$self_$19151.mChar.moveSpeed = (float)0;
															if (247149 - 99529 != 147621)
															{
																this.$self_$19151.animation.Rewind();
																if (216784 - 223298 == -6514)
																{
																	this.$self_$19151.animation.Play("ko");
																	if (193840 - 580002 == -386162)
																	{
																		this.$self_$19151.animation.wrapMode = WrapMode.Once;
																		if (169058 - 292009 == -122951)
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
				Block_14:
				IL_42F:
				return false;
			}

			// Token: 0x0600171B RID: 5915 RVA: 0x0025D554 File Offset: 0x0025B754
			internal static bool kTskkIMjMMt4TWmaG2C()
			{
				return true;
			}

			// Token: 0x0600171C RID: 5916 RVA: 0x0025D558 File Offset: 0x0025B758
			internal static bool zy6AktMhOyfS1ptUvXp()
			{
				return false;
			}

			// Token: 0x040013B0 RID: 5040
			internal Vector3 $myPosition$19148;

			// Token: 0x040013B1 RID: 5041
			internal Vector3 $myDirection$19149;

			// Token: 0x040013B2 RID: 5042
			internal UnityScript.Lang.Array $nArray$19150;

			// Token: 0x040013B3 RID: 5043
			internal Vizie4 $self_$19151;
		}
	}
}
