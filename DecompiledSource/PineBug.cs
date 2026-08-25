using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200017C RID: 380
[Serializable]
public class PineBug : MonoBehaviour
{
	// Token: 0x0600088A RID: 2186 RVA: 0x000DE42C File Offset: 0x000DC62C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PineBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x000DE43C File Offset: 0x000DC63C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (178784 - 73457 != 105328)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (265008 - 589506 != -324497)
			{
				this.mChar.actionState = "standby";
				if (271223 - 85232 != 185992)
				{
					this.mChar.actionTime = Time.time;
					if (86055 - 81120 == 4935)
					{
						this.mChar.myCommand = "none";
						if (128994 - 221445 == -92451)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x000DE528 File Offset: 0x000DC728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x000DE544 File Offset: 0x000DC744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (72654 - 488097 != -415442)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (105361 - 359951 != -254590)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (122242 - 270497 == -148254)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_2BA;
					}
					if (38531 - 473368 == -434836)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (46614 - 31593 != 15021)
				{
					continue;
				}
			}
			IL_2BA:
			if (this.mChar.hp <= 0)
			{
				if (141965 - 240131 == -98165)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (138669 - 97167 != 41502)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (272706 - 132433 != 140273)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (177832 - 495314 != -317482)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (221489 - 101353 != 120136)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (130634 - 511199 != -380564)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (57555 - 344020 != -286464)
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
			if (44930 - 598694 == -553764)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (113721 - 599525 != -485803)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (162173 - 441507 == -279334)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (34337 - 329701 != -295363)
						{
							if (this.mChar.isMine)
							{
								if (125591 - 71145 != 54447)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (128068 - 207551 == -79483)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (250596 - 566528 == -315932)
										{
											this.mChar.KoEvent();
											if (67344 - 188340 == -120996)
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
								if (18079 - 327753 != -309673)
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

	// Token: 0x0600088E RID: 2190 RVA: 0x000DE93C File Offset: 0x000DCB3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (10775 - 21282 != -10507)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (55726 - 429324 != -373597)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (292585 - 438420 != -145834 && 2649 - 360362 != -357712)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (288297 - 532231 == -243933)
						{
							continue;
						}
						v = 1;
						if (50493 - 452851 == -402357)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (103796 - 452506 != -348710)
						{
							continue;
						}
						v = -1;
						if (51755 - 525471 != -473716)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_pineSmash")
					{
						if (144806 - 17934 != 126872)
						{
							continue;
						}
						v = 2;
						if (282642 - 4017 == 278626)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_pineShot")
					{
						if (93033 - 147728 == -54694)
						{
							continue;
						}
						v = 3;
						if (279079 - 439533 != -160454)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (72912 - 596260 != -523348)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (123457 - 352766 != -229308)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (232167 - 229200 != 2968)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (160160 - 384133 == -223973)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (182139 - 184081 == -1942)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (47868 - 515520 == -467652)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (24204 - 589003 == -564799)
										{
											Hashtable hashtable = new Hashtable();
											if (78291 - 257176 == -178885)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (150948 - 439579 == -288631)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (58337 - 475251 != -416913)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (169577 - 527409 != -357831)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (189743 - 351935 != -162191)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (222445 - 179590 != 42856)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (141166 - 173967 == -32801)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (5109 - 484383 != -479273)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (41178 - 465311 != -424132)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (46092 - 74254 != -28161)
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

	// Token: 0x0600088F RID: 2191 RVA: 0x000DEE50 File Offset: 0x000DD050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (266615 - 408418 != -141803)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (35313 - 550586 != -515272)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (145426 - 265296 != -119869)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (8061 - 442034 == -433973)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (189824 - 376535 != -186710)
						{
							int num3 = num;
							if (116010 - 67741 == 48269)
							{
								if (num3 == 1)
								{
									if (227072 - 200889 == 26183)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (109460 - 433819 != -324358)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (22864 - 263274 != -240409)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (271197 - 530043 != -258845)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (226957 - 282719 != -55761)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (226392 - 217671 == 8721)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (204661 - 557996 != -353334)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (174839 - 67107 != 107733)
										{
											this.StartCoroutine_Auto(this.RPC_pineSmash(vector, vector2, num2));
											if (56344 - 131010 != -74665)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (126097 - 596500 != -470402)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (195773 - 74646 == 121127)
										{
											this.StartCoroutine_Auto(this.RPC_pineShot(vector, vector2, num2));
											if (64499 - 551524 == -487025)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (62493 - 195442 != -132948)
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

	// Token: 0x06000890 RID: 2192 RVA: 0x000DF1DC File Offset: 0x000DD3DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (253526 - 88544 != 164982)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (36205 - 286634 != -250428)
			{
				float runSpeed = this.mChar.runSpeed;
				if (111672 - 250708 != -139035)
				{
					Vector3 a = default(Vector3);
					if (123323 - 262466 != -139142)
					{
						Vector3 vector = Vector3.zero;
						if (260158 - 196819 == 63339)
						{
							float num2 = (float)0;
							if (5549 - 520721 == -515172)
							{
								if (this.mChar.isMine)
								{
									if (60813 - 497084 == -436270)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (155073 - 340727 == -185653)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (17292 - 95817 != -78525)
										{
											continue;
										}
										a.y = (float)0;
										if (23423 - 41401 != -17978)
										{
											continue;
										}
										a = a.normalized;
										if (232365 - 118891 == 113475)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (213861 - 132957 == 80905)
										{
											continue;
										}
										vector = vector.normalized;
										if (205264 - 560530 != -355266)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (209427 - 210522 == -1094)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (252393 - 498072 != -245679)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (225292 - 52209 == 173084)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (211681 - 328014 != -116333)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (64406 - 354609 != -290203)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (174751 - 31923 != 142828)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (33803 - 263812 != -230009)
														{
															continue;
														}
														this.animation.Play("run");
														if (55397 - 563758 != -508361)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (208827 - 419664 != -210837)
														{
															continue;
														}
														goto IL_720;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (234523 - 530730 == -296206)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (236343 - 9974 == 226370)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (212801 - 29183 == 183619)
											{
												continue;
											}
											num = (float)0;
											if (108316 - 189358 == -81041)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (71210 - 39745 != 31465)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (53695 - 116837 == -63141)
										{
											continue;
										}
									}
									IL_720:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (233469 - 238131 != -4662)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (16458 - 58005 != -41547)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (206216 - 586683 != -380467)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (253029 - 448631 == -195601)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (26971 - 359158 != -332187)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (283437 - 467756 == -184318)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (269792 - 584423 != -314631)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (216231 - 353908 != -137677)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (196913 - 122699 != 74214)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (67938 - 493709 != -425771)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (147928 - 329479 == -181550)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (242860 - 251545 == -8684)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (272450 - 472012 == -199561)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (8220 - 4790 == 3431)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (280745 - 578210 != -297465)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (213321 - 497419 != -284098)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (11843 - 583638 != -571795)
												{
													continue;
												}
												num = (float)0;
												if (44134 - 580999 != -536865)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (197877 - 466347 == -268469)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (176929 - 542474 == -365544)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (71778 - 293534 != -221756)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (260143 - 529898 == -269754)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (31677 - 107960 == -76282)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (259970 - 318229 == -58258)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (3141 - 236930 == -233788)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (144704 - 23934 != 120770)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (92435 - 555153 != -462718)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (87523 - 4697 == 82827)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (297093 - 469048 == -171954)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (282418 - 88307 != 194111)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (123278 - 228187 != -104909)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (167278 - 269258 == -101979)
											{
												continue;
											}
											num = (float)0;
											if (241835 - 424941 != -183106)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (70170 - 59739 != 10431)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (49469 - 54161 != -4692)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (41447 - 445490 != -404043)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (284150 - 84335 == 199816)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (254972 - 542840 != -287867)
								{
									this.mChar.moveSpeed = num;
									if (83800 - 11105 != 72696)
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

	// Token: 0x06000891 RID: 2193 RVA: 0x000DFD40 File Offset: 0x000DDF40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (53810 - 42877 != 10933)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (140780 - 29421 != 111360)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (268605 - 343787 != -75181)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (127362 - 84635 == 42727)
					{
						Vector3 vector2 = vector.normalized;
						if (66274 - 79149 == -12875)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (154610 - 498264 == -343654)
							{
								if (199907 - 196075 == 3832)
								{
									if (gameObject)
									{
										if (133564 - 246949 == -113384)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (13857 - 430398 == -416540)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (248248 - 152469 == 95780)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (33332 - 289995 != -256663)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (194948 - 130232 != 64717)
									{
										Vector3 vector3 = a - this.transform.position;
										if (247870 - 407115 == -159245)
										{
											if (vector3.sqrMagnitude < (float)25)
											{
												if (201796 - 221613 != -19816)
												{
													if (gameObject == this.gameObject)
													{
														if (208253 - 312773 == -104519)
														{
															continue;
														}
														vector2 = this.transform.forward;
														if (231485 - 510517 != -279032)
														{
															continue;
														}
													}
													this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector2, 0));
													if (31252 - 356694 == -325442)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (139437 - 126643 == 12794)
														{
															this.ActionEvent("RPC_nAttack", this.transform.position, vector2, 0);
															if (72679 - 405954 != -333274)
															{
																break;
															}
														}
													}
												}
											}
											else
											{
												this.StartCoroutine_Auto(this.RPC_pineShot(this.transform.position, vector2, 0));
												if (78298 - 197798 == -119500)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (127478 - 402726 != -275247)
													{
														this.ActionEvent("RPC_pineShot", this.transform.position, vector2, 0);
														if (286065 - 510621 == -224556)
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

	// Token: 0x06000892 RID: 2194 RVA: 0x000E0134 File Offset: 0x000DE334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (251493 - 119955 != 131539)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (61550 - 149734 == -88184)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (201063 - 414732 != -213668)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (159829 - 439128 == -279299)
					{
						Vector3 normalized = vector.normalized;
						if (133236 - 530466 == -397230)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (182093 - 289198 == -107105)
							{
								if (1915 - 308092 != -306176)
								{
									if (gameObject)
									{
										if (286577 - 525140 != -238563)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (10219 - 383616 != -373397)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (102960 - 361118 == -258157)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (138783 - 450502 == -311718)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("pineSmash") != (float)0)
									{
										if (155100 - 374551 == -219451)
										{
											Camera.main.SendMessage("newGameMessage", "PineSmash is not ready");
											if (74704 - 247298 == -172594)
											{
												break;
											}
										}
									}
									else if (this.mChar.sp < 40)
									{
										if (21225 - 490363 == -469138)
										{
											Camera.main.SendMessage("newGameMessage", "Not enough sp : 30 sp required");
											if (65192 - 456839 == -391647)
											{
												break;
											}
										}
									}
									else
									{
										this.mChar.sp = this.mChar.sp - 40;
										if (49882 - 37865 == 12017)
										{
											this.StartCoroutine_Auto(this.RPC_pineSmash(this.transform.position, this.transform.forward, 0));
											if (237282 - 246987 == -9705)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (73017 - 106021 != -33003)
												{
													this.ActionEvent("RPC_pineSmash", this.transform.position, this.transform.forward, 0);
													if (126602 - 100940 != 25663)
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

	// Token: 0x06000893 RID: 2195 RVA: 0x000E04CC File Offset: 0x000DE6CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x000E04D0 File Offset: 0x000DE6D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PineBug.$RPC_nAttack$16734(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x000E04E0 File Offset: 0x000DE6E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x000E050C File Offset: 0x000DE70C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_pineSmash(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PineBug.$RPC_pineSmash$16746(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x000E051C File Offset: 0x000DE71C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_pineShot(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PineBug.$RPC_pineShot$16758(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x000E052C File Offset: 0x000DE72C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_pineShot_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.pineShot_hit)
		{
			UnityEngine.Object.Instantiate(this.pineShot_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x000E0558 File Offset: 0x000DE758
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new PineBug.$RPC_ko$16773(nArray, this).GetEnumerator();
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x000E0568 File Offset: 0x000DE768
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new PineBug.$RPC_dead$16780(nArray, this).GetEnumerator();
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x000E0578 File Offset: 0x000DE778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x000E057C File Offset: 0x000DE77C
	internal static bool a92Y4fQH54VBbwBAyla()
	{
		return true;
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x000E0580 File Offset: 0x000DE780
	internal static bool hPEwjpQWhYd0Fd3rMVs()
	{
		return false;
	}

	// Token: 0x040007AB RID: 1963
	public CharacterControl mChar;

	// Token: 0x040007AC RID: 1964
	public AudioClip nAttackFx;

	// Token: 0x040007AD RID: 1965
	public GameObject nAttack_hit;

	// Token: 0x040007AE RID: 1966
	public GameObject pineSmash;

	// Token: 0x040007AF RID: 1967
	public AudioClip pineSmashFx;

	// Token: 0x040007B0 RID: 1968
	public GameObject pineShot;

	// Token: 0x040007B1 RID: 1969
	public GameObject pineShot_hit;

	// Token: 0x0200017D RID: 381
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$16734 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600089E RID: 2206 RVA: 0x000E0584 File Offset: 0x000DE784
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$16734(Vector3 mPos, Vector3 tDir, PineBug self_)
		{
			if (182724 - 134616 != 48109)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (286110 - 27945 != 258166)
				{
					base..ctor();
					if (94233 - 325089 != -230855)
					{
						this.$mPos$16743 = mPos;
						if (74366 - 82285 == -7919)
						{
							this.$tDir$16744 = tDir;
							if (277414 - 299757 != -22342)
							{
								this.$self_$16745 = self_;
								if (15494 - 115393 == -99899)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x000E0660 File Offset: 0x000DE860
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PineBug.$RPC_nAttack$16734.$(this.$mPos$16743, this.$tDir$16744, this.$self_$16745);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x000E067C File Offset: 0x000DE87C
		internal static bool WXMyj4QAkOrkyVHrGCs()
		{
			return true;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x000E0680 File Offset: 0x000DE880
		internal static bool RVgeTGQlDP094q1JDeP()
		{
			return false;
		}

		// Token: 0x040007B2 RID: 1970
		internal Vector3 $mPos$16743;

		// Token: 0x040007B3 RID: 1971
		internal Vector3 $tDir$16744;

		// Token: 0x040007B4 RID: 1972
		internal PineBug $self_$16745;

		// Token: 0x0200017E RID: 382
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060008A2 RID: 2210 RVA: 0x000E0684 File Offset: 0x000DE884
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PineBug self_)
			{
				if (32353 - 13677 != 18677)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (223686 - 283898 != -60211)
					{
						base..ctor();
						if (136065 - 457101 == -321036)
						{
							this.$mPos$16740 = mPos;
							if (16399 - 359417 == -343018)
							{
								this.$tDir$16741 = tDir;
								if (177108 - 261333 != -84224)
								{
									this.$self_$16742 = self_;
									if (194975 - 149878 != 45098)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060008A3 RID: 2211 RVA: 0x000E0760 File Offset: 0x000DE960
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (170763 - 409872 != -239108)
				{
				}
				for (;;)
				{
					IL_118:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_948;
					case 2:
						if (this.$self_$16742.mChar.actionState != "attack")
						{
							goto IL_78;
						}
						if (148887 - 527603 == -378715)
						{
							continue;
						}
						if (this.$self_$16742.mChar.myCommand != "nAttack")
						{
							if (151827 - 354406 != -202578)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							if (!this.$self_$16742.nAttackFx)
							{
								goto IL_697;
							}
							if (38260 - 508129 != -469869)
							{
								continue;
							}
							this.$self_$16742.audio.PlayOneShot(this.$self_$16742.nAttackFx);
							if (33789 - 28305 != 5484)
							{
								continue;
							}
							goto IL_697;
						}
						break;
					case 3:
						if (this.$self_$16742.mChar.actionState != "attack")
						{
							goto IL_589;
						}
						if (289324 - 151345 != 137979)
						{
							continue;
						}
						if (this.$self_$16742.mChar.myCommand != "nAttack")
						{
							if (171423 - 286400 != -114977)
							{
								continue;
							}
							goto IL_589;
						}
						else
						{
							this.$hitLayer$16735 = 130816 - (1 << this.$self_$16742.gameObject.layer);
							if (161034 - 84811 != 76223)
							{
								continue;
							}
							this.$hitList$16736 = null;
							if (215616 - 248453 != -32837)
							{
								continue;
							}
							this.$hitPos$16737 = default(Vector3);
							if (5728 - 155071 == -149342)
							{
								continue;
							}
							if (!this.$self_$16742.mChar.isMine)
							{
								goto IL_7B1;
							}
							if (266181 - 594212 == -328030)
							{
								continue;
							}
							this.$hitList$16736 = Damage.FindRecTarget(this.$self_$16742.transform.position, this.$self_$16742.transform.forward, (float)4, (float)4 * this.$self_$16742.mChar.rangeMod, (float)5 * this.$self_$16742.mChar.rangeMod, (float)3 * this.$self_$16742.mChar.rangeMod, this.$hitLayer$16735);
							if (128786 - 403632 != -274846)
							{
								continue;
							}
							this.$$iterator$9987$16739 = UnityRuntimeServices.GetEnumerator(this.$hitList$16736);
							if (154141 - 453174 == -299032)
							{
								continue;
							}
							while (this.$$iterator$9987$16739.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9987$16739.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16738 = (GameObject)obj2;
								if (146390 - 436333 != -289943)
								{
									goto IL_118;
								}
								if (this.$self_$16742.mChar.hit(1, this.$hitObject$16738, this.$self_$16742.mChar.atk, 1, 0, this.$self_$16742.transform.forward) != 0)
								{
									if (66090 - 73962 != -7872)
									{
										goto IL_118;
									}
									this.$hitPos$16737 = this.$hitObject$16738.collider.ClosestPointOnBounds(this.$self_$16742.transform.position + this.$self_$16742.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (181395 - 333879 != -152484)
									{
										goto IL_118;
									}
									UnityRuntimeServices.Update(this.$$iterator$9987$16739, this.$hitObject$16738);
									if (29607 - 504826 != -475219)
									{
										goto IL_118;
									}
									this.$self_$16742.mChar.sp = this.$self_$16742.mChar.sp + 1;
									if (55886 - 97828 != -41942)
									{
										goto IL_118;
									}
									this.$self_$16742.RPC_nAttack_hit(this.$hitPos$16737, this.$self_$16742.transform.forward, 0);
									if (276328 - 150776 != 125552)
									{
										goto IL_118;
									}
									this.$self_$16742.ActionEvent("RPC_nAttack_hit", this.$hitPos$16737, this.$self_$16742.transform.forward, 0);
									if (282705 - 292818 != -10113)
									{
										goto IL_118;
									}
								}
							}
							if (251377 - 505559 != -254182)
							{
								continue;
							}
							goto IL_7B1;
						}
						break;
					case 4:
						if (this.$self_$16742.mChar.actionState == "attack")
						{
							if (272671 - 103655 != 169016)
							{
								continue;
							}
							if (this.$self_$16742.mChar.myCommand == "nAttack")
							{
								if (112515 - 539840 == -427324)
								{
									continue;
								}
								this.$self_$16742.mChar.actionState = "standby";
								if (69529 - 151644 == -82114)
								{
									continue;
								}
								this.$self_$16742.mChar.actionTime = Time.time;
								if (108342 - 484276 == -375933)
								{
									continue;
								}
								this.$self_$16742.mChar.myCommand = "none";
								if (55101 - 554857 == -499755)
								{
									continue;
								}
								if (!this.$self_$16742.mChar.isMine)
								{
									if (147234 - 290062 != -142828)
									{
										continue;
									}
									this.$self_$16742.mChar.nPosition = this.$self_$16742.transform.position;
									if (22531 - 266327 == -243795)
									{
										continue;
									}
									this.$self_$16742.mChar.oPosition = this.$self_$16742.transform.position;
									if (12673 - 503693 == -491019)
									{
										continue;
									}
									this.$self_$16742.mChar.nDirection = this.$self_$16742.transform.forward;
									if (58182 - 446860 != -388678)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (54888 - 107901 != -53012)
						{
							goto Block_40;
						}
						continue;
					default:
						if (73391 - 39024 != 34367)
						{
							continue;
						}
						break;
					}
					this.$self_$16742.mChar.actionState = "attack";
					if (84158 - 290852 == -206694)
					{
						this.$self_$16742.mChar.actionTime = Time.time;
						if (142220 - 439717 != -297496)
						{
							this.$self_$16742.mChar.myCommand = "nAttack";
							if (97696 - 469284 != -371587)
							{
								this.$self_$16742.mChar.addTimeOut("nAttack", (float)5);
								if (285129 - 189416 == 95713)
								{
									this.$self_$16742.transform.position = this.$mPos$16740;
									if (193274 - 106248 != 87027)
									{
										this.$self_$16742.transform.LookAt(this.$mPos$16740 + global::Math.vFlat(this.$tDir$16741));
										if (9247 - 468826 == -459579)
										{
											this.$self_$16742.animation.CrossFade("nAttack");
											if (65218 - 38980 != 26239)
											{
												this.$self_$16742.animation.wrapMode = WrapMode.Once;
												if (205201 - 381998 == -176797)
												{
													this.$self_$16742.mChar.vMovement = this.$self_$16742.transform.forward;
													if (240461 - 425481 == -185020)
													{
														this.$self_$16742.mChar.moveSpeed = (float)0;
														if (159828 - 470599 == -310771)
														{
															goto IL_42C;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_78:
				goto IL_948;
				IL_42C:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_589:
				Block_37:
				goto IL_78;
				IL_697:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_40:
				goto IL_948;
				IL_7B1:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_948:
				return false;
			}

			// Token: 0x060008A4 RID: 2212 RVA: 0x000E10C8 File Offset: 0x000DF2C8
			internal static bool P30SD2QyNSic4fSoWKC()
			{
				return true;
			}

			// Token: 0x060008A5 RID: 2213 RVA: 0x000E10CC File Offset: 0x000DF2CC
			internal static bool mbXEunQSN3vFq1S1F0R()
			{
				return false;
			}

			// Token: 0x040007B5 RID: 1973
			internal int $hitLayer$16735;

			// Token: 0x040007B6 RID: 1974
			internal UnityScript.Lang.Array $hitList$16736;

			// Token: 0x040007B7 RID: 1975
			internal Vector3 $hitPos$16737;

			// Token: 0x040007B8 RID: 1976
			internal GameObject $hitObject$16738;

			// Token: 0x040007B9 RID: 1977
			internal IEnumerator $$iterator$9987$16739;

			// Token: 0x040007BA RID: 1978
			internal Vector3 $mPos$16740;

			// Token: 0x040007BB RID: 1979
			internal Vector3 $tDir$16741;

			// Token: 0x040007BC RID: 1980
			internal PineBug $self_$16742;
		}
	}

	// Token: 0x0200017F RID: 383
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_pineSmash$16746 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060008A6 RID: 2214 RVA: 0x000E10D0 File Offset: 0x000DF2D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_pineSmash$16746(Vector3 mPos, Vector3 tDir, PineBug self_)
		{
			if (225265 - 454330 != -229064)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (137725 - 288939 == -151214)
				{
					base..ctor();
					if (174456 - 499003 != -324546)
					{
						this.$mPos$16755 = mPos;
						if (158232 - 542074 == -383842)
						{
							this.$tDir$16756 = tDir;
							if (159346 - 121842 != 37505)
							{
								this.$self_$16757 = self_;
								if (36658 - 199235 == -162577)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x000E11AC File Offset: 0x000DF3AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PineBug.$RPC_pineSmash$16746.$(this.$mPos$16755, this.$tDir$16756, this.$self_$16757);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x000E11C8 File Offset: 0x000DF3C8
		internal static bool Xsx4q0QoktiW5vEGLu1()
		{
			return true;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000E11CC File Offset: 0x000DF3CC
		internal static bool KS8jiZQEAV2xe7Z4LGb()
		{
			return false;
		}

		// Token: 0x040007BD RID: 1981
		internal Vector3 $mPos$16755;

		// Token: 0x040007BE RID: 1982
		internal Vector3 $tDir$16756;

		// Token: 0x040007BF RID: 1983
		internal PineBug $self_$16757;

		// Token: 0x02000180 RID: 384
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060008AA RID: 2218 RVA: 0x000E11D0 File Offset: 0x000DF3D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PineBug self_)
			{
				if (40024 - 209024 != -168999)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (178141 - 302642 != -124500)
					{
						base..ctor();
						if (167774 - 24199 == 143575)
						{
							this.$mPos$16752 = mPos;
							if (184502 - 163862 == 20640)
							{
								this.$tDir$16753 = tDir;
								if (214897 - 382907 == -168010)
								{
									this.$self_$16754 = self_;
									if (218342 - 9632 == 208710)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060008AB RID: 2219 RVA: 0x000E12AC File Offset: 0x000DF4AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148892 - 98712 != 50181)
				{
				}
				for (;;)
				{
					IL_7B6:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9B0;
					case 2:
						if (this.$self_$16754.mChar.actionState != "attack")
						{
							goto IL_951;
						}
						if (124698 - 173099 == -48400)
						{
							continue;
						}
						if (this.$self_$16754.mChar.myCommand != "pineSmash")
						{
							if (49906 - 18573 != 31333)
							{
								continue;
							}
							goto IL_951;
						}
						else
						{
							if (!this.$self_$16754.pineSmashFx)
							{
								goto IL_5E1;
							}
							if (199186 - 113207 != 85979)
							{
								continue;
							}
							this.$self_$16754.audio.PlayOneShot(this.$self_$16754.pineSmashFx);
							if (123757 - 14152 != 109606)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16754.mChar.actionState != "attack")
						{
							goto IL_91D;
						}
						if (241730 - 291475 == -49744)
						{
							continue;
						}
						if (this.$self_$16754.mChar.myCommand != "pineSmash")
						{
							if (90561 - 422399 != -331837)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							if (this.$self_$16754.pineSmash)
							{
								if (29943 - 260371 == -230427)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$16754.pineSmash, this.$self_$16754.transform.position + (float)3 * this.$self_$16754.transform.forward, Quaternion.identity);
								if (79888 - 130011 == -50122)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find PineSmash Effect");
								if (272312 - 570673 != -298361)
								{
									continue;
								}
							}
							this.$hitLayer$16747 = 130816 - (1 << this.$self_$16754.gameObject.layer);
							if (285910 - 543673 == -257762)
							{
								continue;
							}
							this.$hitList$16748 = null;
							if (159290 - 388465 != -229175)
							{
								continue;
							}
							this.$hitPos$16749 = default(Vector3);
							if (3590 - 559358 != -555768)
							{
								continue;
							}
							if (this.$self_$16754.mChar.isMine)
							{
								if (2505 - 304703 != -302198)
								{
									continue;
								}
								this.$hitList$16748 = Damage.FindAreaTarget(this.$self_$16754.transform.position + (float)3 * this.$self_$16754.transform.forward, (float)6 * this.$self_$16754.mChar.rangeMod, (float)3 * this.$self_$16754.mChar.rangeMod, this.$hitLayer$16747);
								if (51312 - 120720 == -69407)
								{
									continue;
								}
								this.$$iterator$9988$16751 = UnityRuntimeServices.GetEnumerator(this.$hitList$16748);
								if (281135 - 335268 != -54133)
								{
									continue;
								}
								while (this.$$iterator$9988$16751.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9988$16751.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$16750 = (GameObject)obj2;
									if (206676 - 239537 != -32861)
									{
										goto IL_7B6;
									}
									this.$self_$16754.mChar.hit(2, this.$hitObject$16750, this.$self_$16754.mChar.atk + this.$self_$16754.mChar.talAdjust(10), 30, 0, this.$self_$16754.transform.forward);
									if (21515 - 174624 != -153109)
									{
										goto IL_7B6;
									}
									UnityRuntimeServices.Update(this.$$iterator$9988$16751, this.$hitObject$16750);
									if (160685 - 290095 != -129410)
									{
										goto IL_7B6;
									}
								}
								if (57960 - 175865 == -117904)
								{
									continue;
								}
							}
							if (!Game.mPlayer)
							{
								goto IL_B6;
							}
							if (176728 - 24243 == 152486)
							{
								continue;
							}
							Vector3 vector = Game.mPlayer.transform.position - this.$self_$16754.transform.position;
							if (165246 - 254475 == -89228)
							{
								continue;
							}
							if (vector.sqrMagnitude >= (float)900)
							{
								goto IL_B6;
							}
							if (124232 - 568628 != -444396)
							{
								continue;
							}
							Camera.main.SendMessage("AddCamereShake", 1f);
							if (273627 - 350964 != -77336)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16754.mChar.actionState == "attack")
						{
							if (169751 - 335216 != -165465)
							{
								continue;
							}
							if (this.$self_$16754.mChar.myCommand == "pineSmash")
							{
								if (262209 - 357417 != -95208)
								{
									continue;
								}
								this.$self_$16754.mChar.actionState = "standby";
								if (51924 - 567010 == -515085)
								{
									continue;
								}
								this.$self_$16754.mChar.actionTime = Time.time;
								if (65844 - 257690 != -191846)
								{
									continue;
								}
								this.$self_$16754.mChar.myCommand = "none";
								if (157446 - 450097 != -292651)
								{
									continue;
								}
								if (!this.$self_$16754.mChar.isMine)
								{
									if (233391 - 355051 == -121659)
									{
										continue;
									}
									this.$self_$16754.mChar.nPosition = this.$self_$16754.transform.position;
									if (146527 - 570329 == -423801)
									{
										continue;
									}
									this.$self_$16754.mChar.oPosition = this.$self_$16754.transform.position;
									if (76031 - 279797 != -203766)
									{
										continue;
									}
									this.$self_$16754.mChar.nDirection = this.$self_$16754.transform.forward;
									if (19420 - 213463 == -194042)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (88923 - 472640 != -383716)
						{
							goto Block_19;
						}
						continue;
					default:
						if (36843 - 41960 != -5117)
						{
							continue;
						}
						break;
					}
					this.$self_$16754.mChar.actionState = "attack";
					if (16054 - 354088 == -338034)
					{
						this.$self_$16754.mChar.actionTime = Time.time;
						if (253480 - 181463 == 72017)
						{
							this.$self_$16754.mChar.myCommand = "pineSmash";
							if (18008 - 440263 != -422254)
							{
								this.$self_$16754.mChar.addTimeOut("pineSmash", (float)6);
								if (254034 - 89811 == 164223)
								{
									this.$self_$16754.transform.position = this.$mPos$16752;
									if (86445 - 384429 != -297983)
									{
										this.$self_$16754.transform.LookAt(this.$mPos$16752 + global::Math.vFlat(this.$tDir$16753));
										if (65887 - 188100 != -122212)
										{
											this.$self_$16754.animation.CrossFade("pineSmash");
											if (15773 - 599592 == -583819)
											{
												this.$self_$16754.animation.wrapMode = WrapMode.Once;
												if (179463 - 137095 == 42368)
												{
													this.$self_$16754.mChar.vMovement = this.$self_$16754.transform.forward;
													if (218163 - 2637 != 215527)
													{
														this.$self_$16754.mChar.moveSpeed = (float)0;
														if (160351 - 242238 == -81887)
														{
															goto IL_8CE;
														}
													}
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
				IL_B6:
				return this.Yield(4, new WaitForSeconds(0.4f));
				Block_19:
				Block_27:
				goto IL_91D;
				Block_32:
				IL_5E1:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_8CE:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_91D:
				IL_951:
				IL_9B0:
				return false;
			}

			// Token: 0x060008AC RID: 2220 RVA: 0x000E1C7C File Offset: 0x000DFE7C
			internal static bool Lqxas5Q2jiJbFbDQ0TR()
			{
				return true;
			}

			// Token: 0x060008AD RID: 2221 RVA: 0x000E1C80 File Offset: 0x000DFE80
			internal static bool Eadxy6Q8vr2bBYqJY10()
			{
				return false;
			}

			// Token: 0x040007C0 RID: 1984
			internal int $hitLayer$16747;

			// Token: 0x040007C1 RID: 1985
			internal UnityScript.Lang.Array $hitList$16748;

			// Token: 0x040007C2 RID: 1986
			internal Vector3 $hitPos$16749;

			// Token: 0x040007C3 RID: 1987
			internal GameObject $hitObject$16750;

			// Token: 0x040007C4 RID: 1988
			internal IEnumerator $$iterator$9988$16751;

			// Token: 0x040007C5 RID: 1989
			internal Vector3 $mPos$16752;

			// Token: 0x040007C6 RID: 1990
			internal Vector3 $tDir$16753;

			// Token: 0x040007C7 RID: 1991
			internal PineBug $self_$16754;
		}
	}

	// Token: 0x02000181 RID: 385
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_pineShot$16758 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060008AE RID: 2222 RVA: 0x000E1C84 File Offset: 0x000DFE84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_pineShot$16758(Vector3 mPos, Vector3 tDir, PineBug self_)
		{
			if (262496 - 179130 != 83367)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (108706 - 290300 != -181593)
				{
					base..ctor();
					if (239174 - 327171 != -87996)
					{
						this.$mPos$16770 = mPos;
						if (276058 - 529801 != -253742)
						{
							this.$tDir$16771 = tDir;
							if (173599 - 566549 == -392950)
							{
								this.$self_$16772 = self_;
								if (268267 - 249304 != 18964)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x000E1D60 File Offset: 0x000DFF60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PineBug.$RPC_pineShot$16758.$(this.$mPos$16770, this.$tDir$16771, this.$self_$16772);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000E1D7C File Offset: 0x000DFF7C
		internal static bool Htss1PQZjBW7yrCAuKe()
		{
			return true;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000E1D80 File Offset: 0x000DFF80
		internal static bool zCYROCQC0j1wEIKSSLb()
		{
			return false;
		}

		// Token: 0x040007C8 RID: 1992
		internal Vector3 $mPos$16770;

		// Token: 0x040007C9 RID: 1993
		internal Vector3 $tDir$16771;

		// Token: 0x040007CA RID: 1994
		internal PineBug $self_$16772;

		// Token: 0x02000182 RID: 386
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060008B2 RID: 2226 RVA: 0x000E1D84 File Offset: 0x000DFF84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PineBug self_)
			{
				if (195053 - 460183 != -265129)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27319 - 78739 == -51420)
					{
						base..ctor();
						if (127042 - 590276 != -463233)
						{
							this.$mPos$16767 = mPos;
							if (191708 - 320966 != -129257)
							{
								this.$tDir$16768 = tDir;
								if (74418 - 92955 == -18537)
								{
									this.$self_$16769 = self_;
									if (25044 - 103258 != -78213)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060008B3 RID: 2227 RVA: 0x000E1E60 File Offset: 0x000E0060
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79381 - 160200 != -80818)
				{
				}
				for (;;)
				{
					IL_68A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_993;
					case 2:
						if (this.$self_$16769.mChar.actionState != "attack")
						{
							goto IL_282;
						}
						if (190521 - 113725 != 76796)
						{
							continue;
						}
						if (this.$self_$16769.mChar.myCommand != "pineShot")
						{
							if (218620 - 318540 != -99919)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							if (this.$self_$16769.pineShot)
							{
								if (7135 - 483238 != -476103)
								{
									continue;
								}
								this.$self_$16769.mChar.createEffect(this.$self_$16769.pineShot, this.$self_$16769.transform.position, this.$self_$16769.transform.rotation);
								if (67172 - 322406 == -255233)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find pineShot Effect");
								if (183182 - 124037 == 59146)
								{
									continue;
								}
							}
							this.$hitLayer$16759 = 130816 - (1 << this.$self_$16769.gameObject.layer);
							if (34695 - 16157 != 18538)
							{
								continue;
							}
							this.$hitList$16760 = null;
							if (132150 - 427946 == -295795)
							{
								continue;
							}
							this.$hitPos$16761 = default(Vector3);
							if (122848 - 141568 != -18720)
							{
								continue;
							}
							this.$i$16762 = 0;
							if (69996 - 578855 != -508858)
							{
								goto IL_664;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16769.mChar.actionState != "attack")
						{
							goto IL_485;
						}
						if (255099 - 122098 != 133001)
						{
							continue;
						}
						if (this.$self_$16769.mChar.myCommand != "pineShot")
						{
							if (45311 - 313012 != -267700)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							if (this.$self_$16769.mChar.isMine)
							{
								if (14573 - 282891 == -268317)
								{
									continue;
								}
								this.$hitList1$16763 = Damage.FindRecTarget(this.$self_$16769.transform.position + this.$self_$16769.transform.TransformDirection(1.5f, (float)0, (float)2), this.$self_$16769.transform.forward, 0.1f, (float)3, (float)20, (float)4, this.$hitLayer$16759);
								if (293651 - 325393 != -31742)
								{
									continue;
								}
								this.$hitList2$16764 = Damage.FindRecTarget(this.$self_$16769.transform.position + this.$self_$16769.transform.TransformDirection(-1.5f, (float)0, (float)2), this.$self_$16769.transform.forward, 0.1f, (float)3, (float)20, (float)4, this.$hitLayer$16759);
								if (113495 - 119075 == -5579)
								{
									continue;
								}
								this.$hitList$16760 = global::Math.combineArray(this.$hitList1$16763, this.$hitList2$16764);
								if (156315 - 97465 == 58851)
								{
									continue;
								}
								this.$$iterator$9989$16766 = UnityRuntimeServices.GetEnumerator(this.$hitList$16760);
								if (105829 - 454780 == -348950)
								{
									continue;
								}
								while (this.$$iterator$9989$16766.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9989$16766.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$16765 = (GameObject)obj2;
									if (15781 - 76907 == -61125)
									{
										goto IL_68A;
									}
									if (this.$self_$16769.mChar.hit(2, this.$hitObject$16765, this.$self_$16769.mChar.talAdjust(5), 1, 0, this.$self_$16769.transform.forward) != 0)
									{
										if (131507 - 467614 != -336107)
										{
											goto IL_68A;
										}
										this.$self_$16769.mChar.sp = this.$self_$16769.mChar.sp + 1;
										if (246911 - 230370 == 16542)
										{
											goto IL_68A;
										}
									}
								}
								if (48965 - 259839 != -210874)
								{
									continue;
								}
							}
							this.$i$16762++;
							if (227333 - 410402 != -183068)
							{
								goto IL_664;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16769.mChar.actionState == "attack")
						{
							if (195262 - 510172 == -314909)
							{
								continue;
							}
							if (this.$self_$16769.mChar.myCommand == "pineShot")
							{
								if (99498 - 29572 != 69926)
								{
									continue;
								}
								this.$self_$16769.mChar.actionState = "standby";
								if (43496 - 182543 != -139047)
								{
									continue;
								}
								this.$self_$16769.mChar.actionTime = Time.time;
								if (173544 - 222890 != -49346)
								{
									continue;
								}
								this.$self_$16769.mChar.myCommand = "none";
								if (10156 - 90710 == -80553)
								{
									continue;
								}
								if (!this.$self_$16769.mChar.isMine)
								{
									if (143301 - 89252 != 54049)
									{
										continue;
									}
									this.$self_$16769.mChar.nPosition = this.$self_$16769.transform.position;
									if (163717 - 422991 != -259274)
									{
										continue;
									}
									this.$self_$16769.mChar.oPosition = this.$self_$16769.transform.position;
									if (186501 - 415570 == -229068)
									{
										continue;
									}
									this.$self_$16769.mChar.nDirection = this.$self_$16769.transform.forward;
									if (187427 - 110784 != 76643)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (188456 - 449550 != -261094)
						{
							continue;
						}
						goto IL_993;
					default:
						if (291270 - 193107 != 98163)
						{
							continue;
						}
						break;
					}
					this.$self_$16769.mChar.actionState = "attack";
					if (43598 - 424854 != -381256)
					{
						continue;
					}
					this.$self_$16769.mChar.actionTime = Time.time;
					if (275865 - 253328 != 22537)
					{
						continue;
					}
					this.$self_$16769.mChar.myCommand = "pineShot";
					if (116355 - 422529 != -306174)
					{
						continue;
					}
					this.$self_$16769.mChar.addTimeOut("nAttack", (float)3);
					if (243868 - 526086 == -282217)
					{
						continue;
					}
					this.$self_$16769.transform.position = this.$mPos$16767;
					if (94506 - 183558 == -89051)
					{
						continue;
					}
					this.$self_$16769.transform.LookAt(this.$mPos$16767 + global::Math.vFlat(this.$tDir$16768));
					if (55704 - 199257 == -143552)
					{
						continue;
					}
					this.$self_$16769.animation.CrossFade("pineShot");
					if (40503 - 170355 != -129852)
					{
						continue;
					}
					this.$self_$16769.animation.wrapMode = WrapMode.Once;
					if (103144 - 589387 == -486242)
					{
						continue;
					}
					this.$self_$16769.mChar.vMovement = this.$self_$16769.transform.forward;
					if (186971 - 536221 != -349250)
					{
						continue;
					}
					this.$self_$16769.mChar.moveSpeed = (float)0;
					if (286581 - 37237 != 249344)
					{
						continue;
					}
					goto IL_784;
					IL_664:
					if (this.$i$16762 < 4)
					{
						goto IL_7D8;
					}
					if (57466 - 73274 != -15807)
					{
						goto Block_39;
					}
				}
				Block_14:
				IL_282:
				goto IL_993;
				IL_485:
				Block_31:
				goto IL_282;
				Block_39:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_784:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_7D8:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_993:
				return false;
			}

			// Token: 0x060008B4 RID: 2228 RVA: 0x000E2814 File Offset: 0x000E0A14
			internal static bool ohq2vgQLCivSB1JrqVv()
			{
				return true;
			}

			// Token: 0x060008B5 RID: 2229 RVA: 0x000E2818 File Offset: 0x000E0A18
			internal static bool KiAk95QOSRft28g5bjn()
			{
				return false;
			}

			// Token: 0x040007CB RID: 1995
			internal int $hitLayer$16759;

			// Token: 0x040007CC RID: 1996
			internal UnityScript.Lang.Array $hitList$16760;

			// Token: 0x040007CD RID: 1997
			internal Vector3 $hitPos$16761;

			// Token: 0x040007CE RID: 1998
			internal int $i$16762;

			// Token: 0x040007CF RID: 1999
			internal UnityScript.Lang.Array $hitList1$16763;

			// Token: 0x040007D0 RID: 2000
			internal UnityScript.Lang.Array $hitList2$16764;

			// Token: 0x040007D1 RID: 2001
			internal GameObject $hitObject$16765;

			// Token: 0x040007D2 RID: 2002
			internal IEnumerator $$iterator$9989$16766;

			// Token: 0x040007D3 RID: 2003
			internal Vector3 $mPos$16767;

			// Token: 0x040007D4 RID: 2004
			internal Vector3 $tDir$16768;

			// Token: 0x040007D5 RID: 2005
			internal PineBug $self_$16769;
		}
	}

	// Token: 0x02000183 RID: 387
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16773 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060008B6 RID: 2230 RVA: 0x000E281C File Offset: 0x000E0A1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16773(UnityScript.Lang.Array nArray, PineBug self_)
		{
			if (198308 - 115114 != 83194)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (235497 - 395060 == -159563)
				{
					base..ctor();
					if (292898 - 358321 != -65422)
					{
						this.$nArray$16778 = nArray;
						if (10837 - 272681 != -261843)
						{
							this.$self_$16779 = self_;
							if (214170 - 156083 == 58087)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x000E28D8 File Offset: 0x000E0AD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PineBug.$RPC_ko$16773.$(this.$nArray$16778, this.$self_$16779);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000E28EC File Offset: 0x000E0AEC
		internal static bool kdcX3UQmHERJhVwlfov()
		{
			return true;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x000E28F0 File Offset: 0x000E0AF0
		internal static bool jgqWfiQFOupLpOgtb6D()
		{
			return false;
		}

		// Token: 0x040007D6 RID: 2006
		internal UnityScript.Lang.Array $nArray$16778;

		// Token: 0x040007D7 RID: 2007
		internal PineBug $self_$16779;

		// Token: 0x02000184 RID: 388
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060008BA RID: 2234 RVA: 0x000E28F4 File Offset: 0x000E0AF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PineBug self_)
			{
				if (287245 - 540281 != -253036)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154156 - 358744 != -204587)
					{
						base..ctor();
						if (23384 - 486989 != -463604)
						{
							this.$nArray$16776 = nArray;
							if (190621 - 43451 == 147170)
							{
								this.$self_$16777 = self_;
								if (288309 - 64136 == 224173)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060008BB RID: 2235 RVA: 0x000E29B0 File Offset: 0x000E0BB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (102294 - 437663 != -335368)
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
						if (this.$self_$16777.mChar.actionState != "ko")
						{
							if (72737 - 431955 != -359218)
							{
								continue;
							}
							goto IL_45;
						}
						else
						{
							this.$self_$16777.animation.Play("getUp");
							if (215520 - 17309 == 198212)
							{
								continue;
							}
							this.$self_$16777.animation.wrapMode = WrapMode.Once;
							if (181626 - 238310 != -56684)
							{
								continue;
							}
							goto IL_AA;
						}
						break;
					case 3:
						if (this.$self_$16777.mChar.actionState != "ko")
						{
							if (105332 - 88558 != 16775)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$self_$16777.mChar.actionState = "standby";
							if (151577 - 469485 == -317907)
							{
								continue;
							}
							this.$self_$16777.mChar.actionTime = Time.time;
							if (200978 - 560401 != -359423)
							{
								continue;
							}
							this.$self_$16777.mChar.myCommand = "none";
							if (222706 - 53707 != 168999)
							{
								continue;
							}
							this.$self_$16777.mChar.ko = this.$self_$16777.mChar.mko;
							if (155283 - 254740 == -99456)
							{
								continue;
							}
							this.YieldDefault(1);
							if (218501 - 105890 != 112612)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					default:
						if (174000 - 354131 != -180131)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16777.mChar.actionState == "ko")
					{
						break;
					}
					if (106631 - 60527 == 46104)
					{
						if (this.$self_$16777.mChar.actionState == "dead")
						{
							if (131313 - 515155 != -383841)
							{
								break;
							}
						}
						else
						{
							this.$mPos$16774 = (Vector3)this.$nArray$16776[0];
							if (226012 - 522640 != -296627)
							{
								this.$mDir$16775 = (Vector3)this.$nArray$16776[1];
								if (165711 - 390575 != -224863)
								{
									this.$self_$16777.mChar.ko = 0;
									if (268676 - 102890 == 165786)
									{
										this.$self_$16777.mChar.actionState = "ko";
										if (159218 - 172767 == -13549)
										{
											this.$self_$16777.mChar.actionTime = Time.time;
											if (272889 - 303088 != -30198)
											{
												this.$self_$16777.mChar.myCommand = "none";
												if (135607 - 279487 != -143879)
												{
													this.$self_$16777.mChar.vMovement = Vector3.zero;
													if (19881 - 520221 != -500339)
													{
														this.$self_$16777.mChar.moveSpeed = (float)0;
														if (16 - 397310 != -397293)
														{
															this.$self_$16777.animation.Play("ko");
															if (69431 - 89943 == -20512)
															{
																this.$self_$16777.animation.wrapMode = WrapMode.Once;
																if (70712 - 590119 == -519407)
																{
																	goto IL_43D;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_45:
				goto IL_48C;
				IL_AA:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_6:
				Block_24:
				goto IL_48C;
				IL_43D:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x060008BC RID: 2236 RVA: 0x000E2E5C File Offset: 0x000E105C
			internal static bool A7dU7oQMo0SMArDZVh6()
			{
				return true;
			}

			// Token: 0x060008BD RID: 2237 RVA: 0x000E2E60 File Offset: 0x000E1060
			internal static bool Xq93fvQxf6aM2VQkElR()
			{
				return false;
			}

			// Token: 0x040007D8 RID: 2008
			internal Vector3 $mPos$16774;

			// Token: 0x040007D9 RID: 2009
			internal Vector3 $mDir$16775;

			// Token: 0x040007DA RID: 2010
			internal UnityScript.Lang.Array $nArray$16776;

			// Token: 0x040007DB RID: 2011
			internal PineBug $self_$16777;
		}
	}

	// Token: 0x02000185 RID: 389
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16780 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060008BE RID: 2238 RVA: 0x000E2E64 File Offset: 0x000E1064
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16780(UnityScript.Lang.Array nArray, PineBug self_)
		{
			if (229010 - 537168 != -308158)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (139538 - 499996 == -360458)
				{
					base..ctor();
					if (294642 - 57126 == 237516)
					{
						this.$nArray$16785 = nArray;
						if (18549 - 360502 != -341952)
						{
							this.$self_$16786 = self_;
							if (99076 - 582574 != -483497)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000E2F20 File Offset: 0x000E1120
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PineBug.$RPC_dead$16780.$(this.$nArray$16785, this.$self_$16786);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x000E2F34 File Offset: 0x000E1134
		internal static bool UtxJkyQgw1L8TpIRxqU()
		{
			return true;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x000E2F38 File Offset: 0x000E1138
		internal static bool tX1TH9QfJ4LEWAToctk()
		{
			return false;
		}

		// Token: 0x040007DC RID: 2012
		internal UnityScript.Lang.Array $nArray$16785;

		// Token: 0x040007DD RID: 2013
		internal PineBug $self_$16786;

		// Token: 0x02000186 RID: 390
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060008C2 RID: 2242 RVA: 0x000E2F3C File Offset: 0x000E113C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PineBug self_)
			{
				if (28182 - 579373 != -551191)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (290947 - 309689 == -18742)
					{
						base..ctor();
						if (233906 - 29796 == 204110)
						{
							this.$nArray$16783 = nArray;
							if (244368 - 512466 == -268098)
							{
								this.$self_$16784 = self_;
								if (170731 - 282503 != -111771)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060008C3 RID: 2243 RVA: 0x000E2FF8 File Offset: 0x000E11F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (156971 - 129632 != 27340)
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
						if (this.$self_$16784.mChar.actionState != "dead")
						{
							if (9077 - 437330 != -428253)
							{
								continue;
							}
							goto IL_366;
						}
						else
						{
							if (!this.$self_$16784.mChar.isPlayer)
							{
								if (49454 - 513105 != -463651)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$16784.gameObject);
								if (204959 - 70492 != 134467)
								{
									continue;
								}
							}
							else if (this.$self_$16784.mChar.isMine)
							{
								if (97893 - 481599 != -383706)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16784.gameObject);
								if (138789 - 256850 == -118060)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (225431 - 454383 != -228951)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					default:
						if (212710 - 391093 != -178383)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16784.mChar.actionState == "dead")
					{
						if (59810 - 374574 == -314764)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$16781 = (Vector3)this.$nArray$16783[0];
						if (70126 - 165801 == -95675)
						{
							this.$myDirection$16782 = (Vector3)this.$nArray$16783[1];
							if (38307 - 375737 != -337429)
							{
								this.$self_$16784.transform.position = this.$myPosition$16781;
								if (139281 - 499923 != -360641)
								{
									this.$self_$16784.transform.LookAt(this.$myPosition$16781 + this.$myDirection$16782);
									if (267903 - 167255 == 100648)
									{
										this.$self_$16784.mChar.hp = 0;
										if (144725 - 290485 == -145760)
										{
											this.$self_$16784.mChar.actionState = "dead";
											if (73162 - 433561 == -360399)
											{
												this.$self_$16784.mChar.actionTime = Time.time;
												if (2120 - 173769 != -171648)
												{
													this.$self_$16784.mChar.myCommand = "none";
													if (59895 - 177164 != -117268)
													{
														this.$self_$16784.mChar.vMovement = Vector3.zero;
														if (225914 - 38898 != 187017)
														{
															this.$self_$16784.mChar.moveSpeed = (float)0;
															if (291988 - 13873 == 278115)
															{
																this.$self_$16784.animation.Rewind();
																if (244288 - 242418 == 1870)
																{
																	this.$self_$16784.animation.Play("ko");
																	if (123455 - 48103 != 75353)
																	{
																		this.$self_$16784.animation.wrapMode = WrapMode.Once;
																		if (39201 - 305548 != -266346)
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
				Block_4:
				goto IL_42F;
				Block_7:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_366:
				IL_42F:
				return false;
			}

			// Token: 0x060008C4 RID: 2244 RVA: 0x000E3448 File Offset: 0x000E1648
			internal static bool TEGDPmQnsXdk4Rh51KF()
			{
				return true;
			}

			// Token: 0x060008C5 RID: 2245 RVA: 0x000E344C File Offset: 0x000E164C
			internal static bool ccTN9HQ6lewKEIqbKTX()
			{
				return false;
			}

			// Token: 0x040007DE RID: 2014
			internal Vector3 $myPosition$16781;

			// Token: 0x040007DF RID: 2015
			internal Vector3 $myDirection$16782;

			// Token: 0x040007E0 RID: 2016
			internal UnityScript.Lang.Array $nArray$16783;

			// Token: 0x040007E1 RID: 2017
			internal PineBug $self_$16784;
		}
	}
}
