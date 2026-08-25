using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C85 RID: 3205
[Serializable]
public class IcePenguin3 : MonoBehaviour
{
	// Token: 0x060047D1 RID: 18385 RVA: 0x008EF6E8 File Offset: 0x008ED8E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IcePenguin3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060047D2 RID: 18386 RVA: 0x008EF6F8 File Offset: 0x008ED8F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (188581 - 428558 != -239977)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (258489 - 66183 != 192307)
			{
				this.mChar.actionState = "standby";
				if (269776 - 384462 != -114685)
				{
					this.mChar.actionTime = Time.time;
					if (16374 - 164178 != -147803)
					{
						this.mChar.myCommand = "none";
						if (164311 - 168773 == -4462)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060047D3 RID: 18387 RVA: 0x008EF7E4 File Offset: 0x008ED9E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x060047D4 RID: 18388 RVA: 0x008EF800 File Offset: 0x008EDA00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (287732 - 49775 != 237958)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (186972 - 102391 == 84582)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (211696 - 184330 != 27366)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_11E;
					}
					if (114450 - 588586 == -474135)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (65510 - 17264 != 48246)
				{
					continue;
				}
			}
			IL_11E:
			if (this.mChar.hp <= 0)
			{
				if (86150 - 166687 != -80537)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (229333 - 348834 != -119501)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (21218 - 168246 == -147027)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (88820 - 300933 == -212112)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (288660 - 536720 != -248060)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (270357 - 315185 != -44827)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (294707 - 434978 != -140270)
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
			if (19574 - 129418 == -109844)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (157527 - 130764 != 26764)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (293501 - 73504 == 219997)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (96820 - 26279 != 70542)
						{
							if (this.mChar.isMine)
							{
								if (295171 - 218081 == 77090)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (124846 - 360759 == -235913)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (75305 - 230684 == -155379)
										{
											this.mChar.KoEvent();
											if (153543 - 503364 == -349821)
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
								if (201731 - 1081 == 200650)
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

	// Token: 0x060047D5 RID: 18389 RVA: 0x008EFBF8 File Offset: 0x008EDDF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (11592 - 164452 != -152859)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (101715 - 291338 == -189623)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (8497 - 114036 != -105538 && 273495 - 554848 != -281352)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (298066 - 17517 != 280549)
						{
							continue;
						}
						v = 1;
						if (100561 - 240097 == -139535)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (111027 - 276281 != -165254)
						{
							continue;
						}
						v = 11;
						if (246184 - 296349 != -50165)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_snowman")
					{
						if (199243 - 539255 == -340011)
						{
							continue;
						}
						v = 21;
						if (178642 - 57413 == 121230)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (61863 - 101256 == -39392)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (165575 - 546338 == -380763)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (6790 - 514778 != -507987)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (67795 - 242292 == -174497)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (115749 - 325914 == -210165)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (87048 - 16157 == 70891)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (31089 - 38011 == -6922)
										{
											Hashtable hashtable = new Hashtable();
											if (87630 - 253826 != -166195)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (161987 - 581529 == -419542)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (57645 - 261681 == -204036)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (164448 - 137903 != 26546)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (63600 - 59652 != 3949)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (281523 - 553113 == -271590)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (287444 - 513675 != -226230)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (191682 - 72311 == 119371)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (80340 - 247181 == -166841)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (110582 - 261200 == -150618)
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

	// Token: 0x060047D6 RID: 18390 RVA: 0x008F00C4 File Offset: 0x008EE2C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (19400 - 480077 != -460677)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (112051 - 145398 == -33347)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (153995 - 104517 != 49479)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (17904 - 475745 != -457840)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (235484 - 594183 != -358698)
						{
							int num2 = num;
							if (298512 - 387548 == -89036)
							{
								if (num2 == 1)
								{
									if (109054 - 274628 != -165573)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (165585 - 398669 != -233083)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(mPos, tDir, tID));
											if (87578 - 380204 == -292626)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (123803 - 594043 == -470240)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (85295 - 23633 == 61662)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(mPos, tDir, tID));
											if (240085 - 478208 != -238122)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 21)
								{
									if (296799 - 474773 != -177973)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (97566 - 322488 != -224921)
										{
											this.StartCoroutine_Auto(this.RPC_snowman(mPos, tDir, tID));
											if (282940 - 403909 == -120969)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (227806 - 434404 == -206598)
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

	// Token: 0x060047D7 RID: 18391 RVA: 0x008F03DC File Offset: 0x008EE5DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (9205 - 21606 != -12400)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (131020 - 447846 == -316826)
			{
				float runSpeed = this.mChar.runSpeed;
				if (75017 - 151457 != -76439)
				{
					Vector3 a = default(Vector3);
					if (128470 - 118151 != 10320)
					{
						Vector3 vector = Vector3.zero;
						if (125930 - 4018 == 121912)
						{
							float num2 = (float)0;
							if (298610 - 137863 != 160748)
							{
								if (this.mChar.isMine)
								{
									if (166382 - 579291 != -412909)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (187609 - 589980 == -402370)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (287546 - 553122 == -265575)
										{
											continue;
										}
										a.y = (float)0;
										if (141885 - 280316 != -138431)
										{
											continue;
										}
										a = a.normalized;
										if (50318 - 472020 == -421701)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (114074 - 472963 == -358888)
										{
											continue;
										}
										vector = vector.normalized;
										if (111479 - 597471 == -485991)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (275814 - 442615 == -166800)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (229299 - 480695 == -251395)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (56028 - 427255 != -371227)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (289324 - 387700 != -98376)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (187051 - 276798 == -89746)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (223457 - 491862 != -268405)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (38359 - 541473 == -503113)
														{
															continue;
														}
														this.animation.Play("run");
														if (140684 - 313955 != -173271)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (172126 - 332013 != -159886)
														{
															goto IL_604;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (133349 - 560466 != -427117)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (253594 - 592815 == -339220)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (83109 - 399773 == -316663)
											{
												continue;
											}
											num = (float)0;
											if (27835 - 29875 == -2039)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (188459 - 421602 == -233142)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (86517 - 237307 == -150789)
										{
											continue;
										}
									}
									IL_604:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (136407 - 383403 != -246996)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (18882 - 190194 != -171312)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (3489 - 586631 == -583141)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (184452 - 178685 != 5767)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (87880 - 536775 != -448895)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (134326 - 500236 == -365909)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (214484 - 462958 == -248473)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (251891 - 205252 == 46640)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (105876 - 74110 != 31766)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (273923 - 289562 != -15639)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (141192 - 249294 != -108102)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (9317 - 370464 == -361146)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (169708 - 27166 == 142543)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (40893 - 132199 == -91305)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (250977 - 524928 != -273951)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (186162 - 70501 != 115661)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (297210 - 440833 == -143622)
												{
													continue;
												}
												num = (float)0;
												if (143562 - 270188 == -126625)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (144392 - 32616 == 111777)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (60646 - 563182 == -502535)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (77240 - 264752 != -187512)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (76322 - 175854 != -99532)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (279621 - 394537 != -114916)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (110057 - 190316 != -80259)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (274487 - 535264 == -260776)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (208418 - 335800 == -127381)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (193305 - 512926 == -319620)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (21474 - 52186 == -30711)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (139136 - 594659 == -455522)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (121818 - 467446 != -345628)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (185097 - 242432 != -57335)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (166723 - 326236 == -159512)
											{
												continue;
											}
											num = (float)0;
											if (74372 - 359185 == -284812)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (137708 - 595212 != -457504)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (284670 - 340913 == -56242)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (159542 - 79644 != 79898)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (265081 - 186732 == 78350)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (296214 - 303578 == -7364)
								{
									this.mChar.moveSpeed = num;
									if (163369 - 224649 == -61280)
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

	// Token: 0x060047D8 RID: 18392 RVA: 0x008F0F40 File Offset: 0x008EF140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (91199 - 134942 != -43743)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (183217 - 166969 == 16248)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (57704 - 247781 == -190077)
				{
					Vector3 vector = a - this.transform.position;
					if (162834 - 201942 == -39108)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (88038 - 216894 == -128856)
						{
							CharacterControl characterControl = null;
							if (94042 - 56534 != 37509)
							{
								int tID = 0;
								if (266627 - 178469 != 88159)
								{
									if (gameObject)
									{
										if (126554 - 384982 != -258428)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (184071 - 13999 != 170072)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (205073 - 398951 != -193878)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (205390 - 579730 == -374339)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (87229 - 462755 != -375526)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (247731 - 536805 != -289074)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (283965 - 34583 == 249382)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (290859 - 307826 == -16967)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (185270 - 595379 == -410109)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
												if (135247 - 100765 == 34482)
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

	// Token: 0x060047D9 RID: 18393 RVA: 0x008F123C File Offset: 0x008EF43C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (23852 - 28516 != -4663)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (291329 - 133390 != 157940)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (122245 - 223221 != -100975)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (161107 - 239375 != -78267)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (7770 - 210951 == -203181)
						{
							CharacterControl characterControl = null;
							if (71848 - 114158 != -42309)
							{
								int num = 0;
								if (117149 - 83884 != 33266)
								{
									if (gameObject)
									{
										if (72413 - 532688 != -460275)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (10689 - 232522 != -221833)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (16532 - 599816 != -583284)
										{
											continue;
										}
										num = characterControl.ActorNr;
										if (213450 - 238629 == -25178)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (203812 - 144423 != 59389)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (206918 - 151944 != 54974)
										{
											continue;
										}
									}
									if (num != 0)
									{
										if (268638 - 463074 != -194436)
										{
											continue;
										}
										if (this.mChar.isTimeOut("snowman") == (float)0)
										{
											if (5987 - 17034 == -11046)
											{
												continue;
											}
											this.StartCoroutine_Auto(this.RPC_snowman(this.transform.position, vector, num));
											if (24341 - 487001 == -462659)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (166340 - 425036 != -258696)
											{
												continue;
											}
											this.ActionEvent("RPC_snowman", this.transform.position, vector, num);
											if (196649 - 390560 != -193910)
											{
												break;
											}
											continue;
										}
									}
									if (this.mChar.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (189559 - 263828 == -74269)
									{
										this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, vector, 0));
										if (8293 - 395247 == -386954)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (58157 - 395208 != -337050)
											{
												this.ActionEvent("RPC_cAttack", this.transform.position, vector, 0);
												if (226079 - 572627 != -346547)
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

	// Token: 0x060047DA RID: 18394 RVA: 0x008F161C File Offset: 0x008EF81C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060047DB RID: 18395 RVA: 0x008F1620 File Offset: 0x008EF820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IcePenguin3.$RPC_nAttack$32332(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060047DC RID: 18396 RVA: 0x008F1630 File Offset: 0x008EF830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IcePenguin3.$RPC_cAttack$32343(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060047DD RID: 18397 RVA: 0x008F1640 File Offset: 0x008EF840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_snowman(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IcePenguin3.$RPC_snowman$32355(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060047DE RID: 18398 RVA: 0x008F1650 File Offset: 0x008EF850
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new IcePenguin3.$RPC_ko$32366(nArray, this).GetEnumerator();
	}

	// Token: 0x060047DF RID: 18399 RVA: 0x008F1660 File Offset: 0x008EF860
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new IcePenguin3.$RPC_dead$32373(nArray, this).GetEnumerator();
	}

	// Token: 0x060047E0 RID: 18400 RVA: 0x008F1670 File Offset: 0x008EF870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060047E1 RID: 18401 RVA: 0x008F1674 File Offset: 0x008EF874
	internal static bool a3qYfl5D29QEKCNh5gg8()
	{
		return true;
	}

	// Token: 0x060047E2 RID: 18402 RVA: 0x008F1678 File Offset: 0x008EF878
	internal static bool aD0OXW5D8sINPhBmp3qK()
	{
		return false;
	}

	// Token: 0x040052E7 RID: 21223
	public CharacterControl mChar;

	// Token: 0x040052E8 RID: 21224
	public GameObject nAttack_ring;

	// Token: 0x040052E9 RID: 21225
	public GameObject cAttack_ring;

	// Token: 0x040052EA RID: 21226
	public GameObject castRing;

	// Token: 0x02000C86 RID: 3206
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32332 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060047E3 RID: 18403 RVA: 0x008F167C File Offset: 0x008EF87C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32332(Vector3 mPos, Vector3 tDir, IcePenguin3 self_)
		{
			if (17354 - 551435 != -534080)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (50450 - 216782 != -166331)
				{
					base..ctor();
					if (276155 - 396411 == -120256)
					{
						this.$mPos$32340 = mPos;
						if (149105 - 406164 != -257058)
						{
							this.$tDir$32341 = tDir;
							if (165703 - 52964 != 112740)
							{
								this.$self_$32342 = self_;
								if (246036 - 258148 == -12112)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x008F1758 File Offset: 0x008EF958
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin3.$RPC_nAttack$32332.$(this.$mPos$32340, this.$tDir$32341, this.$self_$32342);
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x008F1774 File Offset: 0x008EF974
		internal static bool XP1evF5DZYitlLrZ27Yd()
		{
			return true;
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x008F1778 File Offset: 0x008EF978
		internal static bool gtbmNr5DC18hRULBOYZm()
		{
			return false;
		}

		// Token: 0x040052EB RID: 21227
		internal Vector3 $mPos$32340;

		// Token: 0x040052EC RID: 21228
		internal Vector3 $tDir$32341;

		// Token: 0x040052ED RID: 21229
		internal IcePenguin3 $self_$32342;

		// Token: 0x02000C87 RID: 3207
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060047E7 RID: 18407 RVA: 0x008F177C File Offset: 0x008EF97C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IcePenguin3 self_)
			{
				if (92134 - 2625 != 89509)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (286934 - 180502 == 106432)
					{
						base..ctor();
						if (185682 - 387291 == -201609)
						{
							this.$mPos$32337 = mPos;
							if (121675 - 261519 == -139844)
							{
								this.$tDir$32338 = tDir;
								if (110996 - 362812 != -251815)
								{
									this.$self_$32339 = self_;
									if (114920 - 317581 != -202660)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060047E8 RID: 18408 RVA: 0x008F1858 File Offset: 0x008EFA58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (175247 - 96877 != 78370)
				{
				}
				for (;;)
				{
					IL_182:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_769;
					case 2:
						if (this.$self_$32339.mChar.actionState != "attack")
						{
							goto IL_353;
						}
						if (62732 - 340963 != -278231)
						{
							continue;
						}
						if (this.$self_$32339.mChar.myCommand != "nAttack")
						{
							if (211054 - 451918 != -240864)
							{
								continue;
							}
							goto IL_353;
						}
						else
						{
							this.$self_$32339.mChar.moveSpeed = (float)0;
							if (155439 - 588371 != -432932)
							{
								continue;
							}
							if (this.$self_$32339.nAttack_ring)
							{
								if (80457 - 531050 != -450593)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$32339.nAttack_ring, this.$self_$32339.transform.position + (float)2 * this.$self_$32339.transform.forward, Quaternion.identity);
								if (13293 - 35197 == -21903)
								{
									continue;
								}
							}
							if (!this.$self_$32339.mChar.isMine)
							{
								goto IL_59A;
							}
							if (84673 - 304761 == -220087)
							{
								continue;
							}
							this.$hitLayer$32333 = 130816 - (1 << this.$self_$32339.gameObject.layer);
							if (153798 - 457832 != -304034)
							{
								continue;
							}
							this.$hitList$32334 = Damage.FindAreaTarget(this.$self_$32339.transform.position + this.$self_$32339.transform.forward, (float)2, (float)3, this.$hitLayer$32333);
							if (276224 - 316969 == -40744)
							{
								continue;
							}
							this.$$iterator$10753$32336 = UnityRuntimeServices.GetEnumerator(this.$hitList$32334);
							if (131689 - 99369 != 32320)
							{
								continue;
							}
							while (this.$$iterator$10753$32336.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10753$32336.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32335 = (GameObject)obj2;
								if (106408 - 99869 == 6540)
								{
									goto IL_182;
								}
								this.$self_$32339.mChar.hit(1, this.$hitObject$32335, this.$self_$32339.mChar.atk, 20, 0, Vector3.zero);
								if (195032 - 351669 == -156636)
								{
									goto IL_182;
								}
								UnityRuntimeServices.Update(this.$$iterator$10753$32336, this.$hitObject$32335);
								if (213733 - 293889 == -80155)
								{
									goto IL_182;
								}
							}
							if (106210 - 590057 != -483847)
							{
								continue;
							}
							goto IL_59A;
						}
						break;
					case 3:
						if (this.$self_$32339.mChar.actionState == "attack")
						{
							if (87215 - 1549 != 85666)
							{
								continue;
							}
							if (this.$self_$32339.mChar.myCommand == "nAttack")
							{
								if (73219 - 55582 != 17637)
								{
									continue;
								}
								this.$self_$32339.mChar.actionState = "standby";
								if (38858 - 464364 == -425505)
								{
									continue;
								}
								this.$self_$32339.mChar.actionTime = Time.time;
								if (6205 - 230455 == -224249)
								{
									continue;
								}
								this.$self_$32339.mChar.myCommand = "none";
								if (119341 - 141583 != -22242)
								{
									continue;
								}
								if (!this.$self_$32339.mChar.isMine)
								{
									if (98030 - 312739 != -214709)
									{
										continue;
									}
									this.$self_$32339.mChar.nPosition = this.$self_$32339.transform.position;
									if (64941 - 216204 != -151263)
									{
										continue;
									}
									this.$self_$32339.mChar.oPosition = this.$self_$32339.transform.position;
									if (42890 - 164624 != -121734)
									{
										continue;
									}
									this.$self_$32339.mChar.nDirection = this.$self_$32339.transform.forward;
									if (209159 - 212168 != -3009)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (183167 - 575424 != -392257)
						{
							continue;
						}
						goto IL_769;
					default:
						if (252204 - 60789 != 191415)
						{
							continue;
						}
						break;
					}
					this.$self_$32339.mChar.actionState = "attack";
					if (177522 - 577879 == -400357)
					{
						this.$self_$32339.mChar.actionTime = Time.time;
						if (2199 - 273166 == -270967)
						{
							this.$self_$32339.mChar.myCommand = "nAttack";
							if (273816 - 553091 == -279275)
							{
								this.$self_$32339.mChar.addTimeOut("nAttack", (float)2);
								if (44846 - 333908 == -289062)
								{
									this.$self_$32339.transform.position = this.$mPos$32337;
									if (171020 - 339617 == -168597)
									{
										this.$self_$32339.transform.LookAt(this.$mPos$32337 + global::Math.vFlat(this.$tDir$32338));
										if (258218 - 480328 == -222110)
										{
											this.$self_$32339.animation.CrossFade("nAttack");
											if (110834 - 160825 != -49990)
											{
												this.$self_$32339.animation.wrapMode = WrapMode.Once;
												if (80142 - 437411 != -357268)
												{
													this.$self_$32339.mChar.vMovement = this.$self_$32339.transform.forward;
													if (190277 - 595175 != -404897)
													{
														this.$self_$32339.mChar.moveSpeed = (float)1;
														if (275289 - 448210 != -172920)
														{
															goto Block_45;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_353:
				goto IL_769;
				IL_59A:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_45:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_769:
				return false;
			}

			// Token: 0x060047E9 RID: 18409 RVA: 0x008F1FE0 File Offset: 0x008F01E0
			internal static bool ldeyCl5DLqLhJX5GMRyX()
			{
				return true;
			}

			// Token: 0x060047EA RID: 18410 RVA: 0x008F1FE4 File Offset: 0x008F01E4
			internal static bool LqRXAA5DOGlaPJwb4C4G()
			{
				return false;
			}

			// Token: 0x040052EE RID: 21230
			internal int $hitLayer$32333;

			// Token: 0x040052EF RID: 21231
			internal UnityScript.Lang.Array $hitList$32334;

			// Token: 0x040052F0 RID: 21232
			internal GameObject $hitObject$32335;

			// Token: 0x040052F1 RID: 21233
			internal IEnumerator $$iterator$10753$32336;

			// Token: 0x040052F2 RID: 21234
			internal Vector3 $mPos$32337;

			// Token: 0x040052F3 RID: 21235
			internal Vector3 $tDir$32338;

			// Token: 0x040052F4 RID: 21236
			internal IcePenguin3 $self_$32339;
		}
	}

	// Token: 0x02000C88 RID: 3208
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$32343 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060047EB RID: 18411 RVA: 0x008F1FE8 File Offset: 0x008F01E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$32343(Vector3 mPos, Vector3 tDir, IcePenguin3 self_)
		{
			if (27342 - 98096 != -70753)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (10762 - 434739 != -423976)
				{
					base..ctor();
					if (62163 - 160312 != -98148)
					{
						this.$mPos$32352 = mPos;
						if (29278 - 268768 != -239489)
						{
							this.$tDir$32353 = tDir;
							if (184675 - 214026 != -29350)
							{
								this.$self_$32354 = self_;
								if (87873 - 225657 != -137783)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060047EC RID: 18412 RVA: 0x008F20C4 File Offset: 0x008F02C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin3.$RPC_cAttack$32343.$(this.$mPos$32352, this.$tDir$32353, this.$self_$32354);
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x008F20E0 File Offset: 0x008F02E0
		internal static bool dIPoI25DmApbbQp9mjCJ()
		{
			return true;
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x008F20E4 File Offset: 0x008F02E4
		internal static bool u4et8q5DF5LkaDwGcbjd()
		{
			return false;
		}

		// Token: 0x040052F5 RID: 21237
		internal Vector3 $mPos$32352;

		// Token: 0x040052F6 RID: 21238
		internal Vector3 $tDir$32353;

		// Token: 0x040052F7 RID: 21239
		internal IcePenguin3 $self_$32354;

		// Token: 0x02000C89 RID: 3209
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060047EF RID: 18415 RVA: 0x008F20E8 File Offset: 0x008F02E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IcePenguin3 self_)
			{
				if (31919 - 316791 != -284871)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (242142 - 118260 != 123883)
					{
						base..ctor();
						if (88005 - 301259 == -213254)
						{
							this.$mPos$32349 = mPos;
							if (76966 - 457365 != -380398)
							{
								this.$tDir$32350 = tDir;
								if (89689 - 226886 != -137196)
								{
									this.$self_$32351 = self_;
									if (115297 - 244510 == -129213)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060047F0 RID: 18416 RVA: 0x008F21C4 File Offset: 0x008F03C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (264740 - 205899 != 58842)
				{
				}
				for (;;)
				{
					IL_50F:
					switch (this._state)
					{
					case 0:
						goto IL_548;
					case 1:
						goto IL_8CD;
					case 2:
						if (this.$self_$32351.mChar.actionState != "attack")
						{
							goto IL_41B;
						}
						if (125948 - 298466 == -172517)
						{
							continue;
						}
						if (this.$self_$32351.mChar.myCommand != "cAttack")
						{
							if (80492 - 526872 != -446379)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$self_$32351.mChar.moveSpeed = (float)8;
							if (185037 - 393189 == -208151)
							{
								continue;
							}
							if (this.$self_$32351.cAttack_ring)
							{
								if (253875 - 273410 == -19534)
								{
									continue;
								}
								this.$self_$32351.mChar.createEffect(this.$self_$32351.cAttack_ring, this.$self_$32351.transform.position, this.$self_$32351.transform.rotation);
								if (80665 - 308063 != -227398)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing cAttack_ring effect");
								if (88242 - 380258 != -292016)
								{
									continue;
								}
							}
							this.$i$32344 = 1;
							if (101749 - 288473 != -186724)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$32351.mChar.actionState != "attack")
						{
							goto IL_653;
						}
						if (90179 - 314566 == -224386)
						{
							continue;
						}
						if (this.$self_$32351.mChar.myCommand != "cAttack")
						{
							if (57367 - 530984 != -473616)
							{
								goto Block_54;
							}
							continue;
						}
						else
						{
							this.$self_$32351.mChar.moveSpeed = (float)(12 - this.$i$32344);
							if (207972 - 76733 != 131239)
							{
								continue;
							}
							if (this.$self_$32351.mChar.isMine)
							{
								if (205776 - 517029 != -311253)
								{
									continue;
								}
								this.$hitLayer$32345 = 130816 - (1 << this.$self_$32351.gameObject.layer);
								if (158534 - 549131 == -390596)
								{
									continue;
								}
								this.$hitList$32346 = Damage.FindRecTarget(this.$self_$32351.transform.position, this.$self_$32351.transform.forward, (float)2, (float)2, (float)3, (float)3, this.$hitLayer$32345);
								if (37455 - 513770 != -476315)
								{
									continue;
								}
								this.$$iterator$10754$32348 = UnityRuntimeServices.GetEnumerator(this.$hitList$32346);
								if (288245 - 209152 == 79094)
								{
									continue;
								}
								while (this.$$iterator$10754$32348.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10754$32348.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$32347 = (GameObject)obj2;
									if (18809 - 84846 == -66036)
									{
										goto IL_50F;
									}
									this.$self_$32351.mChar.hit(1, this.$hitObject$32347, (int)(0.5f * (float)this.$self_$32351.mChar.atk), 3, 0, Vector3.zero);
									if (168006 - 584829 != -416823)
									{
										goto IL_50F;
									}
									UnityRuntimeServices.Update(this.$$iterator$10754$32348, this.$hitObject$32347);
									if (290138 - 347715 == -57576)
									{
										goto IL_50F;
									}
								}
								if (208968 - 545422 == -336453)
								{
									continue;
								}
							}
							this.$i$32344++;
							if (190032 - 370556 != -180524)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$32351.mChar.actionState == "attack")
						{
							if (276636 - 190605 != 86031)
							{
								continue;
							}
							if (this.$self_$32351.mChar.myCommand == "cAttack")
							{
								if (262690 - 333941 == -71250)
								{
									continue;
								}
								this.$self_$32351.mChar.actionState = "standby";
								if (210191 - 72551 == 137641)
								{
									continue;
								}
								this.$self_$32351.mChar.actionTime = Time.time;
								if (291722 - 383260 == -91537)
								{
									continue;
								}
								this.$self_$32351.mChar.myCommand = "none";
								if (210665 - 125538 == 85128)
								{
									continue;
								}
								if (!this.$self_$32351.mChar.isMine)
								{
									if (33505 - 330896 != -297391)
									{
										continue;
									}
									this.$self_$32351.mChar.nPosition = this.$self_$32351.transform.position;
									if (94411 - 577815 == -483403)
									{
										continue;
									}
									this.$self_$32351.mChar.oPosition = this.$self_$32351.transform.position;
									if (246917 - 3560 == 243358)
									{
										continue;
									}
									this.$self_$32351.mChar.nDirection = this.$self_$32351.transform.forward;
									if (288892 - 437781 != -148889)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (128038 - 416198 != -288160)
						{
							continue;
						}
						goto IL_8CD;
					default:
						if (40099 - 322522 != -282423)
						{
							continue;
						}
						goto IL_548;
					}
					if (this.$i$32344 <= 12)
					{
						goto IL_4C0;
					}
					if (94910 - 436686 != -341776)
					{
						continue;
					}
					goto IL_7CC;
					IL_548:
					this.$self_$32351.mChar.actionState = "attack";
					if (209982 - 110396 != 99587)
					{
						this.$self_$32351.mChar.actionTime = Time.time;
						if (280778 - 90574 != 190205)
						{
							this.$self_$32351.mChar.myCommand = "cAttack";
							if (66029 - 39003 == 27026)
							{
								this.$self_$32351.mChar.addTimeOut("cAttack", (float)9);
								if (18092 - 573413 != -555320)
								{
									this.$self_$32351.transform.position = this.$mPos$32349;
									if (49080 - 389027 == -339947)
									{
										this.$self_$32351.transform.LookAt(this.$mPos$32349 + global::Math.vFlat(this.$tDir$32350));
										if (31902 - 140694 != -108791)
										{
											this.$self_$32351.animation.CrossFade("cAttack");
											if (128750 - 447331 != -318580)
											{
												this.$self_$32351.animation.wrapMode = WrapMode.Once;
												if (190702 - 146865 == 43837)
												{
													this.$self_$32351.mChar.vMovement = this.$self_$32351.transform.forward;
													if (69243 - 160909 != -91665)
													{
														this.$self_$32351.mChar.moveSpeed = (float)0;
														if (179377 - 39911 != 139467)
														{
															goto Block_18;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_13:
				goto IL_41B;
				Block_18:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_41B:
				goto IL_8CD;
				IL_4C0:
				return this.Yield(3, new WaitForSeconds(0.15f));
				IL_653:
				goto IL_8CD;
				IL_7CC:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_54:
				IL_8CD:
				return false;
			}

			// Token: 0x060047F1 RID: 18417 RVA: 0x008F2AB0 File Offset: 0x008F0CB0
			internal static bool PTNtk15DMu3fkbFC3r7g()
			{
				return true;
			}

			// Token: 0x060047F2 RID: 18418 RVA: 0x008F2AB4 File Offset: 0x008F0CB4
			internal static bool yDaSnq5DxllQhDL49wZJ()
			{
				return false;
			}

			// Token: 0x040052F8 RID: 21240
			internal int $i$32344;

			// Token: 0x040052F9 RID: 21241
			internal int $hitLayer$32345;

			// Token: 0x040052FA RID: 21242
			internal UnityScript.Lang.Array $hitList$32346;

			// Token: 0x040052FB RID: 21243
			internal GameObject $hitObject$32347;

			// Token: 0x040052FC RID: 21244
			internal IEnumerator $$iterator$10754$32348;

			// Token: 0x040052FD RID: 21245
			internal Vector3 $mPos$32349;

			// Token: 0x040052FE RID: 21246
			internal Vector3 $tDir$32350;

			// Token: 0x040052FF RID: 21247
			internal IcePenguin3 $self_$32351;
		}
	}

	// Token: 0x02000C8A RID: 3210
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_snowman$32355 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060047F3 RID: 18419 RVA: 0x008F2AB8 File Offset: 0x008F0CB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_snowman$32355(Vector3 mPos, Vector3 tDir, int tID, IcePenguin3 self_)
		{
			if (57441 - 172291 != -114849)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (207889 - 382525 == -174636)
				{
					base..ctor();
					if (86074 - 474875 == -388801)
					{
						this.$mPos$32362 = mPos;
						if (135668 - 378554 == -242886)
						{
							this.$tDir$32363 = tDir;
							if (190562 - 585642 == -395080)
							{
								this.$tID$32364 = tID;
								if (140576 - 120339 != 20238)
								{
									this.$self_$32365 = self_;
									if (93343 - 345014 != -251670)
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

		// Token: 0x060047F4 RID: 18420 RVA: 0x008F2BB8 File Offset: 0x008F0DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin3.$RPC_snowman$32355.$(this.$mPos$32362, this.$tDir$32363, this.$tID$32364, this.$self_$32365);
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x008F2BD8 File Offset: 0x008F0DD8
		internal static bool aul9Ne5Dgg8YyuIOCuA1()
		{
			return true;
		}

		// Token: 0x060047F6 RID: 18422 RVA: 0x008F2BDC File Offset: 0x008F0DDC
		internal static bool N4a3aL5DfKpaWRPnBtrs()
		{
			return false;
		}

		// Token: 0x04005300 RID: 21248
		internal Vector3 $mPos$32362;

		// Token: 0x04005301 RID: 21249
		internal Vector3 $tDir$32363;

		// Token: 0x04005302 RID: 21250
		internal int $tID$32364;

		// Token: 0x04005303 RID: 21251
		internal IcePenguin3 $self_$32365;

		// Token: 0x02000C8B RID: 3211
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060047F7 RID: 18423 RVA: 0x008F2BE0 File Offset: 0x008F0DE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, IcePenguin3 self_)
			{
				if (12799 - 404112 != -391312)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (91172 - 57645 != 33528)
					{
						base..ctor();
						if (171811 - 431263 == -259452)
						{
							this.$mPos$32358 = mPos;
							if (7494 - 271225 != -263730)
							{
								this.$tDir$32359 = tDir;
								if (61259 - 62586 == -1327)
								{
									this.$tID$32360 = tID;
									if (30871 - 65698 == -34827)
									{
										this.$self_$32361 = self_;
										if (235499 - 45426 == 190073)
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

			// Token: 0x060047F8 RID: 18424 RVA: 0x008F2CE0 File Offset: 0x008F0EE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (166619 - 519280 != -352661)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7DF;
					case 2:
						if (this.$self_$32361.mChar.actionState != "attack")
						{
							goto IL_135;
						}
						if (243396 - 48006 != 195390)
						{
							continue;
						}
						if (this.$self_$32361.mChar.myCommand != "snowman")
						{
							if (135728 - 97006 != 38722)
							{
								continue;
							}
							goto IL_135;
						}
						else if (this.$self_$32361.castRing)
						{
							if (245417 - 114886 != 130531)
							{
								continue;
							}
							this.$self_$32361.mChar.createEffect(this.$self_$32361.castRing, this.$self_$32361.transform.position, this.$self_$32361.transform.rotation);
							if (86217 - 581587 != -495369)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing castRing effect");
							if (67772 - 532632 != -464860)
							{
								continue;
							}
							goto IL_561;
						}
						break;
					case 3:
						if (this.$self_$32361.mChar.actionState != "attack")
						{
							goto IL_672;
						}
						if (140743 - 545602 == -404858)
						{
							continue;
						}
						if (this.$self_$32361.mChar.myCommand != "snowman")
						{
							if (206798 - 16160 != 190639)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$self_$32361.mChar.moveSpeed = (float)0;
							if (211790 - 431527 != -219737)
							{
								continue;
							}
							if (!this.$self_$32361.mChar.isMine)
							{
								goto IL_73A;
							}
							if (189271 - 464592 != -275321)
							{
								continue;
							}
							if (this.$tID$32360 == 0)
							{
								goto IL_73A;
							}
							if (14158 - 422676 != -408518)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$32360];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$32356 = (GameObject)obj2;
							if (102358 - 590842 != -488484)
							{
								continue;
							}
							if (!this.$tObject$32356)
							{
								goto IL_73A;
							}
							if (150959 - 42965 != 107994)
							{
								continue;
							}
							this.$tChar$32357 = (CharacterControl)this.$tObject$32356.GetComponent(typeof(CharacterControl));
							if (123922 - 238225 == -114302)
							{
								continue;
							}
							if (!this.$tChar$32357)
							{
								goto IL_73A;
							}
							if (266234 - 263440 != 2794)
							{
								continue;
							}
							this.$tChar$32357.RPC_AddStatus("snowMan", 4, Damage.getDebuff((float)6, this.$self_$32361.mChar.cha, this.$tChar$32357.cha), 60, this.$self_$32361.mChar.ActorNr);
							if (96701 - 482870 != -386168)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$32361.mChar.actionState == "attack")
						{
							if (13316 - 293195 != -279879)
							{
								continue;
							}
							if (this.$self_$32361.mChar.myCommand == "snowman")
							{
								if (56367 - 496231 != -439864)
								{
									continue;
								}
								this.$self_$32361.mChar.actionState = "standby";
								if (265018 - 67746 == 197273)
								{
									continue;
								}
								this.$self_$32361.mChar.actionTime = Time.time;
								if (28074 - 463305 == -435230)
								{
									continue;
								}
								this.$self_$32361.mChar.myCommand = "none";
								if (40893 - 345460 != -304567)
								{
									continue;
								}
								if (!this.$self_$32361.mChar.isMine)
								{
									if (54843 - 92092 == -37248)
									{
										continue;
									}
									this.$self_$32361.mChar.nPosition = this.$self_$32361.transform.position;
									if (276625 - 386136 != -109511)
									{
										continue;
									}
									this.$self_$32361.mChar.oPosition = this.$self_$32361.transform.position;
									if (182777 - 59740 != 123037)
									{
										continue;
									}
									this.$self_$32361.mChar.nDirection = this.$self_$32361.transform.forward;
									if (133700 - 100038 != 33662)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (157367 - 178741 != -21374)
						{
							continue;
						}
						goto IL_7DF;
					default:
						if (56203 - 500578 != -444375)
						{
							continue;
						}
						break;
					}
					this.$self_$32361.mChar.actionState = "attack";
					if (12538 - 325884 != -313345)
					{
						this.$self_$32361.mChar.actionTime = Time.time;
						if (286432 - 239108 == 47324)
						{
							this.$self_$32361.mChar.myCommand = "snowman";
							if (138384 - 532504 == -394120)
							{
								this.$self_$32361.mChar.addTimeOut("snowman", (float)24);
								if (228319 - 1443 == 226876)
								{
									this.$self_$32361.transform.position = this.$mPos$32358;
									if (264312 - 324995 != -60682)
									{
										this.$self_$32361.transform.LookAt(this.$mPos$32358 + global::Math.vFlat(this.$tDir$32359));
										if (78429 - 590642 != -512212)
										{
											this.$self_$32361.animation.CrossFade("cast");
											if (36894 - 125816 != -88921)
											{
												this.$self_$32361.animation.wrapMode = WrapMode.Once;
												if (284945 - 121723 == 163222)
												{
													this.$self_$32361.mChar.vMovement = this.$self_$32361.transform.forward;
													if (291519 - 116947 != 174573)
													{
														this.$self_$32361.mChar.moveSpeed = (float)1;
														if (100716 - 426984 != -326267)
														{
															goto Block_12;
														}
													}
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
				IL_135:
				goto IL_7DF;
				Block_12:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_30:
				goto IL_73A;
				IL_561:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_672:
				goto IL_7DF;
				IL_73A:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_51:
				goto IL_561;
				IL_7DF:
				return false;
			}

			// Token: 0x060047F9 RID: 18425 RVA: 0x008F34E0 File Offset: 0x008F16E0
			internal static bool z5OgMb5DnhryUZcn3FLI()
			{
				return true;
			}

			// Token: 0x060047FA RID: 18426 RVA: 0x008F34E4 File Offset: 0x008F16E4
			internal static bool G0RYia5D6aD6VZgmCxZW()
			{
				return false;
			}

			// Token: 0x04005304 RID: 21252
			internal GameObject $tObject$32356;

			// Token: 0x04005305 RID: 21253
			internal CharacterControl $tChar$32357;

			// Token: 0x04005306 RID: 21254
			internal Vector3 $mPos$32358;

			// Token: 0x04005307 RID: 21255
			internal Vector3 $tDir$32359;

			// Token: 0x04005308 RID: 21256
			internal int $tID$32360;

			// Token: 0x04005309 RID: 21257
			internal IcePenguin3 $self_$32361;
		}
	}

	// Token: 0x02000C8C RID: 3212
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32366 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060047FB RID: 18427 RVA: 0x008F34E8 File Offset: 0x008F16E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32366(UnityScript.Lang.Array nArray, IcePenguin3 self_)
		{
			if (255425 - 392104 != -136679)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (130204 - 10307 != 119898)
				{
					base..ctor();
					if (238526 - 282293 == -43767)
					{
						this.$nArray$32371 = nArray;
						if (42272 - 434345 != -392072)
						{
							this.$self_$32372 = self_;
							if (32346 - 404299 != -371952)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x008F35A4 File Offset: 0x008F17A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin3.$RPC_ko$32366.$(this.$nArray$32371, this.$self_$32372);
		}

		// Token: 0x060047FD RID: 18429 RVA: 0x008F35B8 File Offset: 0x008F17B8
		internal static bool Lus7TN5DiOGBqdUeFf7A()
		{
			return true;
		}

		// Token: 0x060047FE RID: 18430 RVA: 0x008F35BC File Offset: 0x008F17BC
		internal static bool l3b1Ax5DK6gMx7KQlkJm()
		{
			return false;
		}

		// Token: 0x0400530A RID: 21258
		internal UnityScript.Lang.Array $nArray$32371;

		// Token: 0x0400530B RID: 21259
		internal IcePenguin3 $self_$32372;

		// Token: 0x02000C8D RID: 3213
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060047FF RID: 18431 RVA: 0x008F35C0 File Offset: 0x008F17C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, IcePenguin3 self_)
			{
				if (290319 - 541073 != -250753)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (123650 - 274779 == -151129)
					{
						base..ctor();
						if (30116 - 258816 != -228699)
						{
							this.$nArray$32369 = nArray;
							if (153063 - 9176 == 143887)
							{
								this.$self_$32370 = self_;
								if (206094 - 467654 != -261559)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004800 RID: 18432 RVA: 0x008F367C File Offset: 0x008F187C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (259701 - 51137 != 208565)
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
						if (this.$self_$32370.mChar.actionState != "ko")
						{
							if (189608 - 561721 != -372113)
							{
								continue;
							}
							goto IL_D2;
						}
						else
						{
							this.$self_$32370.animation.Play("getUp");
							if (48732 - 555718 != -506986)
							{
								continue;
							}
							this.$self_$32370.animation.wrapMode = WrapMode.Once;
							if (35551 - 360614 != -325062)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32370.mChar.actionState != "ko")
						{
							if (297253 - 187946 != 109307)
							{
								continue;
							}
							goto IL_1DE;
						}
						else
						{
							this.$self_$32370.mChar.actionState = "standby";
							if (80365 - 314276 == -233910)
							{
								continue;
							}
							this.$self_$32370.mChar.actionTime = Time.time;
							if (255928 - 146952 == 108977)
							{
								continue;
							}
							this.$self_$32370.mChar.myCommand = "none";
							if (272117 - 37590 == 234528)
							{
								continue;
							}
							this.$self_$32370.mChar.ko = this.$self_$32370.mChar.mko;
							if (28462 - 207025 != -178563)
							{
								continue;
							}
							this.YieldDefault(1);
							if (131000 - 134378 != -3377)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					default:
						if (142810 - 158080 != -15270)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32370.mChar.actionState == "ko")
					{
						goto IL_352;
					}
					if (163078 - 58942 == 104136)
					{
						if (this.$self_$32370.mChar.actionState == "dead")
						{
							if (292321 - 122924 == 169397)
							{
								goto IL_352;
							}
						}
						else
						{
							this.$mPos$32367 = (Vector3)this.$nArray$32369[0];
							if (98047 - 146460 != -48412)
							{
								this.$mDir$32368 = (Vector3)this.$nArray$32369[1];
								if (3082 - 17379 == -14297)
								{
									this.$self_$32370.mChar.ko = 0;
									if (193561 - 405826 == -212265)
									{
										this.$self_$32370.mChar.actionState = "ko";
										if (91952 - 326596 == -234644)
										{
											this.$self_$32370.mChar.actionTime = Time.time;
											if (213526 - 158434 != 55093)
											{
												this.$self_$32370.mChar.myCommand = "none";
												if (231000 - 522767 != -291766)
												{
													this.$self_$32370.mChar.vMovement = Vector3.zero;
													if (255997 - 547523 != -291525)
													{
														this.$self_$32370.mChar.moveSpeed = (float)0;
														if (190469 - 532087 != -341617)
														{
															this.$self_$32370.animation.Play("ko");
															if (46368 - 456673 == -410305)
															{
																this.$self_$32370.animation.wrapMode = WrapMode.Once;
																if (112965 - 480683 != -367717)
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
				IL_D2:
				Block_8:
				IL_1DE:
				IL_352:
				goto IL_48C;
				Block_26:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_48C:
				return false;
			}

			// Token: 0x06004801 RID: 18433 RVA: 0x008F3B28 File Offset: 0x008F1D28
			internal static bool z5HVfn5DdO1t5ukggObe()
			{
				return true;
			}

			// Token: 0x06004802 RID: 18434 RVA: 0x008F3B2C File Offset: 0x008F1D2C
			internal static bool lnvFmw5DJnX7CNPnjE1J()
			{
				return false;
			}

			// Token: 0x0400530C RID: 21260
			internal Vector3 $mPos$32367;

			// Token: 0x0400530D RID: 21261
			internal Vector3 $mDir$32368;

			// Token: 0x0400530E RID: 21262
			internal UnityScript.Lang.Array $nArray$32369;

			// Token: 0x0400530F RID: 21263
			internal IcePenguin3 $self_$32370;
		}
	}

	// Token: 0x02000C8E RID: 3214
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32373 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004803 RID: 18435 RVA: 0x008F3B30 File Offset: 0x008F1D30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32373(UnityScript.Lang.Array nArray, IcePenguin3 self_)
		{
			if (119330 - 322482 != -203152)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121858 - 380074 != -258215)
				{
					base..ctor();
					if (20436 - 350119 == -329683)
					{
						this.$nArray$32378 = nArray;
						if (93122 - 514899 != -421776)
						{
							this.$self_$32379 = self_;
							if (112575 - 352791 != -240215)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x008F3BEC File Offset: 0x008F1DEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin3.$RPC_dead$32373.$(this.$nArray$32378, this.$self_$32379);
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x008F3C00 File Offset: 0x008F1E00
		internal static bool wlnrDr5DD6ZqdOR4B3Wy()
		{
			return true;
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x008F3C04 File Offset: 0x008F1E04
		internal static bool jT6c3p5Dv019HWo5WXYf()
		{
			return false;
		}

		// Token: 0x04005310 RID: 21264
		internal UnityScript.Lang.Array $nArray$32378;

		// Token: 0x04005311 RID: 21265
		internal IcePenguin3 $self_$32379;

		// Token: 0x02000C8F RID: 3215
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004807 RID: 18439 RVA: 0x008F3C08 File Offset: 0x008F1E08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, IcePenguin3 self_)
			{
				if (194830 - 351658 != -156828)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (280005 - 157953 == 122052)
					{
						base..ctor();
						if (212573 - 511939 == -299366)
						{
							this.$nArray$32376 = nArray;
							if (245754 - 185011 == 60743)
							{
								this.$self_$32377 = self_;
								if (29271 - 241197 == -211926)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004808 RID: 18440 RVA: 0x008F3CC4 File Offset: 0x008F1EC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (231205 - 422426 != -191220)
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
						if (this.$self_$32377.mChar.actionState != "dead")
						{
							if (239018 - 353036 != -114018)
							{
								continue;
							}
							goto IL_2FF;
						}
						else
						{
							if (!this.$self_$32377.mChar.isPlayer)
							{
								if (239540 - 424584 == -185043)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32377.gameObject);
								if (102300 - 506517 == -404216)
								{
									continue;
								}
							}
							else if (this.$self_$32377.mChar.isMine)
							{
								if (210933 - 438807 == -227873)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32377.gameObject);
								if (36413 - 199712 != -163299)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (37059 - 347457 != -310397)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					default:
						if (82928 - 521515 == -438586)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32377.mChar.actionState == "dead")
					{
						if (117968 - 145062 == -27094)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$32374 = (Vector3)this.$nArray$32376[0];
						if (273832 - 508020 == -234188)
						{
							this.$myDirection$32375 = (Vector3)this.$nArray$32376[1];
							if (148023 - 476702 == -328679)
							{
								this.$self_$32377.transform.position = this.$myPosition$32374;
								if (294254 - 18168 != 276087)
								{
									this.$self_$32377.transform.LookAt(this.$myPosition$32374 + this.$myDirection$32375);
									if (135769 - 185592 == -49823)
									{
										this.$self_$32377.mChar.hp = 0;
										if (269229 - 178647 != 90583)
										{
											this.$self_$32377.mChar.actionState = "dead";
											if (222161 - 395924 != -173762)
											{
												this.$self_$32377.mChar.actionTime = Time.time;
												if (238034 - 547490 != -309455)
												{
													this.$self_$32377.mChar.myCommand = "none";
													if (48839 - 74058 != -25218)
													{
														this.$self_$32377.mChar.vMovement = Vector3.zero;
														if (188956 - 526299 != -337342)
														{
															this.$self_$32377.mChar.moveSpeed = (float)0;
															if (14508 - 220739 != -206230)
															{
																this.$self_$32377.animation.Rewind();
																if (118214 - 230593 == -112379)
																{
																	this.$self_$32377.animation.Play("ko");
																	if (159717 - 559126 != -399408)
																	{
																		this.$self_$32377.animation.wrapMode = WrapMode.Once;
																		if (165940 - 192983 == -27043)
																		{
																			goto IL_1DF;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_42F;
				IL_1DF:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_14:
				IL_2FF:
				IL_42F:
				return false;
			}

			// Token: 0x06004809 RID: 18441 RVA: 0x008F4114 File Offset: 0x008F2314
			internal static bool kCf1T05DRR460GsJDFl1()
			{
				return true;
			}

			// Token: 0x0600480A RID: 18442 RVA: 0x008F4118 File Offset: 0x008F2318
			internal static bool SDGAmo5Dwd6MJd3m9vpF()
			{
				return false;
			}

			// Token: 0x04005312 RID: 21266
			internal Vector3 $myPosition$32374;

			// Token: 0x04005313 RID: 21267
			internal Vector3 $myDirection$32375;

			// Token: 0x04005314 RID: 21268
			internal UnityScript.Lang.Array $nArray$32376;

			// Token: 0x04005315 RID: 21269
			internal IcePenguin3 $self_$32377;
		}
	}
}
