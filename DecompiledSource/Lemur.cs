using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CC3 RID: 3267
[Serializable]
public class Lemur : MonoBehaviour
{
	// Token: 0x0600494E RID: 18766 RVA: 0x0091741C File Offset: 0x0091561C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Lemur()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600494F RID: 18767 RVA: 0x0091742C File Offset: 0x0091562C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (291958 - 233811 != 58148)
		{
		}
		for (;;)
		{
			this.oQWzAwJYhv = this.transform;
			if (89024 - 394669 != -305644)
			{
				this.TjWz9PffI0 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (161125 - 296058 == -134933)
				{
					this.TjWz9PffI0.actionState = "standby";
					if (216484 - 455141 == -238657)
					{
						this.TjWz9PffI0.actionTime = Time.time;
						if (202097 - 473318 != -271220)
						{
							this.TjWz9PffI0.myCommand = "none";
							if (55430 - 86815 == -31385)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (245528 - 359219 != -113690)
								{
									this.TjWz9PffI0.isMine = true;
									if (69284 - 486864 == -417580)
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

	// Token: 0x06004950 RID: 18768 RVA: 0x0091758C File Offset: 0x0091578C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (71976 - 586643 != -514667)
		{
		}
		for (;;)
		{
			if (this.TjWz9PffI0.isControlled)
			{
				if (289119 - 338680 != -49561)
				{
					continue;
				}
				if (!(this.TjWz9PffI0.actionState == "standby"))
				{
					if (129024 - 78545 == 50480)
					{
						continue;
					}
					if (!(this.TjWz9PffI0.actionState == "run"))
					{
						goto IL_2C9;
					}
					if (65371 - 351903 != -286532)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (189535 - 493457 != -303922)
				{
					continue;
				}
			}
			IL_2C9:
			if (this.TjWz9PffI0.hp <= 0)
			{
				if (216053 - 594134 == -378080)
				{
					continue;
				}
				if (this.TjWz9PffI0.actionState != "dead")
				{
					if (261225 - 327130 == -65904)
					{
						continue;
					}
					if (this.TjWz9PffI0.isMine)
					{
						if (231272 - 201620 != 29652)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (299183 - 552116 == -252932)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (90082 - 524372 != -434290)
						{
							continue;
						}
						this.TjWz9PffI0.DeadEvent();
						if (158144 - 144597 != 13547)
						{
							continue;
						}
						break;
					}
					else
					{
						this.TjWz9PffI0.hp = 1;
						if (125803 - 272572 != -146768)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.TjWz9PffI0.hp <= 0)
			{
				break;
			}
			if (187390 - 84808 == 102582)
			{
				if (this.TjWz9PffI0.ko > 0)
				{
					break;
				}
				if (105466 - 318572 != -213105)
				{
					if (!(this.TjWz9PffI0.actionState != "ko"))
					{
						break;
					}
					if (190631 - 596 == 190035)
					{
						if (!(this.TjWz9PffI0.actionState != "dead"))
						{
							break;
						}
						if (131376 - 419274 == -287898)
						{
							if (this.TjWz9PffI0.isMine)
							{
								if (10641 - 386250 == -375609)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (31015 - 426742 != -395726)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (209441 - 46424 != 163018)
										{
											this.TjWz9PffI0.KoEvent();
											if (59360 - 174125 != -114764)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.TjWz9PffI0.ko = 1;
								if (258487 - 495714 != -237226)
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

	// Token: 0x06004951 RID: 18769 RVA: 0x00917984 File Offset: 0x00915B84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (83903 - 265064 != -181161)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (115982 - 531573 == -415591)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (43294 - 302574 != -259279 && 193810 - 35934 != 157877)
				{
					Debug.Log("Unknown Action Name:" + ActionName);
					if (37569 - 340773 != -303203)
					{
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (181305 - 458065 != -276759)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (134247 - 219698 != -85450)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (212054 - 421336 != -209281)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (188421 - 327622 != -139200)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (116709 - 324214 != -207504)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (3277 - 516488 != -513210)
											{
												Hashtable hashtable = new Hashtable();
												if (97888 - 35064 == 62824)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (184683 - 333025 != -148341)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (46518 - 296589 != -250070)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (71510 - 324190 != -252679)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (147197 - 254119 == -106922)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (21060 - 417376 != -396315)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (187447 - 173877 == 13570)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (243946 - 553924 != -309977)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (112204 - 509376 != -397171)
																				{
																					PhotonClient.SendEvent(this.TjWz9PffI0.ActorNr, 74, hashtable, true, true);
																					if (227780 - 226098 == 1682)
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

	// Token: 0x06004952 RID: 18770 RVA: 0x00917D6C File Offset: 0x00915F6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (55002 - 96827 != -41825)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (116045 - 127931 != -11885)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (281691 - 389248 == -107557)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (123337 - 362543 != -239205)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (222031 - 112346 == 109685)
						{
							if (244641 - 504316 == -259675)
							{
								Debug.Log("Unknown Action Code:" + num);
								if (122039 - 408099 == -286060)
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

	// Token: 0x06004953 RID: 18771 RVA: 0x00917F10 File Offset: 0x00916110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (264712 - 491874 != -227161)
		{
		}
		for (;;)
		{
			float num = this.TjWz9PffI0.moveSpeed;
			if (160825 - 268285 != -107459)
			{
				float runSpeed = this.TjWz9PffI0.runSpeed;
				if (228940 - 406257 != -177316)
				{
					Vector3 a = default(Vector3);
					if (176985 - 414275 != -237289)
					{
						Vector3 vector = Vector3.zero;
						if (258347 - 271655 == -13308)
						{
							float num2 = (float)0;
							if (141694 - 6584 == 135110)
							{
								if (this.TjWz9PffI0.isMine)
								{
									if (210379 - 316771 == -106391)
									{
										continue;
									}
									if ((this.TjWz9PffI0.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (175564 - 53865 != 121699)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (259489 - 481224 != -221735)
										{
											continue;
										}
										a.y = (float)0;
										if (183604 - 116041 == 67564)
										{
											continue;
										}
										a = a.normalized;
										if (50260 - 523488 == -473227)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (247788 - 536465 != -288677)
										{
											continue;
										}
										vector = vector.normalized;
										if (210993 - 579659 != -368666)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (121442 - 415581 == -294138)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (280605 - 305075 != -24470)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (244219 - 392960 != -148741)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (162113 - 261820 == -99706)
														{
															continue;
														}
														this.TjWz9PffI0.actionState = "run";
														if (221177 - 310513 != -89336)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (151712 - 513106 == -361393)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (135728 - 156886 != -21158)
														{
															continue;
														}
														this.animation.Play("run");
														if (178041 - 280185 != -102144)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (237652 - 114967 != 122685)
														{
															continue;
														}
														goto IL_5B7;
													}
												}
											}
										}
										this.TjWz9PffI0.actionState = "standby";
										if (188190 - 122943 == 65248)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (121885 - 298430 == -176544)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (154721 - 598047 != -443326)
											{
												continue;
											}
											num = (float)0;
											if (262099 - 226333 == 35767)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (207893 - 101471 != 106422)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (262901 - 239263 != 23638)
										{
											continue;
										}
									}
									IL_5B7:;
								}
								else
								{
									vector = global::Math.vFlat(this.TjWz9PffI0.nPosition - this.transform.position);
									if (229453 - 374100 == -144646)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (262143 - 289461 == -27317)
									{
										continue;
									}
									if (this.TjWz9PffI0.nSpeed != (float)0)
									{
										if (211846 - 586562 == -374715)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (291425 - 284760 != 6665)
											{
												continue;
											}
											this.transform.position = this.TjWz9PffI0.nPosition;
											if (269999 - 245899 != 24100)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (299514 - 102504 != 197010)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (41871 - 267763 == -225891)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (155321 - 267106 != -111785)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.TjWz9PffI0.nSpeed, (float)10 * Time.deltaTime);
												if (115920 - 419087 != -303167)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (102150 - 257188 == -155037)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (106906 - 201364 != -94458)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (119807 - 570137 != -450330)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (258059 - 206530 != 51529)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (245204 - 381232 != -136028)
											{
												continue;
											}
										}
										else if (Time.time > this.TjWz9PffI0.nSpeed + 0.3f)
										{
											if (244500 - 559401 == -314900)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (159916 - 168588 == -8671)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (77407 - 287126 != -209719)
												{
													continue;
												}
												num = (float)0;
												if (173428 - 447535 == -274106)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.TjWz9PffI0.nDirection);
											if (48927 - 175209 != -126282)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (187291 - 423572 == -236280)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (44837 - 102161 != -57324)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (103514 - 244110 == -140595)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (260494 - 111160 != 149334)
											{
												continue;
											}
											this.transform.position = this.TjWz9PffI0.nPosition;
											if (215027 - 90705 == 124323)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (253271 - 309575 == -56303)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (179639 - 151244 == 28396)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (292818 - 128338 == 164481)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (75942 - 157167 == -81224)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (6181 - 102016 == -95834)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (54242 - 60777 == -6534)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (54385 - 179122 == -124736)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.TjWz9PffI0.nDirection);
											if (253231 - 419954 == -166722)
											{
												continue;
											}
											num = (float)0;
											if (94766 - 118990 != -24224)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (132097 - 483238 != -351141)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (170100 - 94869 != 75231)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (50810 - 308920 != -258110)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (140151 - 300024 == -159872)
										{
											continue;
										}
									}
								}
								this.TjWz9PffI0.vMovement = vector;
								if (279741 - 216119 != 63623)
								{
									this.TjWz9PffI0.moveSpeed = num;
									if (100134 - 21347 == 78787)
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

	// Token: 0x06004954 RID: 18772 RVA: 0x00918A74 File Offset: 0x00916C74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (274926 - 384075 != -109148)
		{
		}
		for (;;)
		{
			if (!this.TjWz9PffI0.isMine)
			{
				if (59476 - 32056 == 27420)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (227290 - 574299 != -347008)
				{
					Vector3 vector = a - this.transform.position;
					if (144186 - 57257 == 86929)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (80867 - 260474 == -179607)
						{
							CharacterControl characterControl = null;
							if (234560 - 307991 != -73430)
							{
								if (84590 - 455705 == -371115)
								{
									if (gameObject)
									{
										if (91417 - 298343 == -206925)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (145081 - 89706 != 55375)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (38147 - 112897 == -74749)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (32190 - 205515 == -173324)
										{
											continue;
										}
									}
									if (!(this.TjWz9PffI0.actionState == "standby"))
									{
										if (239614 - 55961 == 183654)
										{
											continue;
										}
										if (!(this.TjWz9PffI0.actionState == "run"))
										{
											break;
										}
										if (150320 - 321431 == -171110)
										{
											continue;
										}
									}
									if (this.TjWz9PffI0.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (296277 - 180332 == 115945)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
										if (72345 - 205075 == -132730)
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

	// Token: 0x06004955 RID: 18773 RVA: 0x00918D18 File Offset: 0x00916F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (27147 - 491667 != -464519)
		{
		}
		for (;;)
		{
			if (!this.TjWz9PffI0.isMine)
			{
				if (137727 - 130100 == 7627)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (190528 - 558551 == -368023)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (81892 - 174581 == -92689)
					{
						Vector3 normalized = vector.normalized;
						if (130303 - 88632 != 41672)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (279579 - 18959 == 260620)
							{
								CharacterControl characterControl = null;
								if (160107 - 598417 == -438310)
								{
									if (264118 - 245134 != 18985)
									{
										if (gameObject)
										{
											if (49840 - 454237 == -404396)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (55416 - 136907 == -81490)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (221735 - 520270 != -298535)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (180716 - 338023 != -157307)
											{
												continue;
											}
										}
										if (!(this.TjWz9PffI0.actionState == "standby"))
										{
											if (235108 - 532332 != -297224)
											{
												continue;
											}
											if (!(this.TjWz9PffI0.actionState == "run"))
											{
												break;
											}
											if (26943 - 520424 != -493481)
											{
												continue;
											}
										}
										if (this.TjWz9PffI0.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (41742 - 511549 != -469806)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (199354 - 294765 != -95410)
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

	// Token: 0x06004956 RID: 18774 RVA: 0x00918FE4 File Offset: 0x009171E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004957 RID: 18775 RVA: 0x00918FE8 File Offset: 0x009171E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Lemur.$RPC_ko$32591(nArray, this).GetEnumerator();
	}

	// Token: 0x06004958 RID: 18776 RVA: 0x00918FF8 File Offset: 0x009171F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Lemur.$RPC_dead$32598(nArray, this).GetEnumerator();
	}

	// Token: 0x06004959 RID: 18777 RVA: 0x00919008 File Offset: 0x00917208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600495A RID: 18778 RVA: 0x0091900C File Offset: 0x0091720C
	internal static bool S3je6H5R2JRtFcA14nsa()
	{
		return true;
	}

	// Token: 0x0600495B RID: 18779 RVA: 0x00919010 File Offset: 0x00917210
	internal static bool PE6RKi5R8N726BCyuAGs()
	{
		return false;
	}

	// Token: 0x04005430 RID: 21552
	private Transform oQWzAwJYhv;

	// Token: 0x04005431 RID: 21553
	private CharacterControl TjWz9PffI0;

	// Token: 0x02000CC4 RID: 3268
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32591 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600495C RID: 18780 RVA: 0x00919014 File Offset: 0x00917214
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32591(UnityScript.Lang.Array nArray, Lemur self_)
		{
			if (93793 - 521368 != -427575)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (171470 - 319335 == -147865)
				{
					base..ctor();
					if (136180 - 272514 == -136334)
					{
						this.$nArray$32596 = nArray;
						if (22976 - 483981 != -461004)
						{
							this.$self_$32597 = self_;
							if (63346 - 599430 == -536084)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x009190D0 File Offset: 0x009172D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Lemur.$RPC_ko$32591.$(this.$nArray$32596, this.$self_$32597);
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x009190E4 File Offset: 0x009172E4
		internal static bool ePeTCi5RZG9mQQ5fj3sR()
		{
			return true;
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x009190E8 File Offset: 0x009172E8
		internal static bool MjD5F05RCKKHYORmn5bk()
		{
			return false;
		}

		// Token: 0x04005432 RID: 21554
		internal UnityScript.Lang.Array $nArray$32596;

		// Token: 0x04005433 RID: 21555
		internal Lemur $self_$32597;

		// Token: 0x02000CC5 RID: 3269
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004960 RID: 18784 RVA: 0x009190EC File Offset: 0x009172EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Lemur self_)
			{
				if (136075 - 548173 != -412098)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (274886 - 258442 == 16444)
					{
						base..ctor();
						if (230201 - 379147 == -148946)
						{
							this.$nArray$32594 = nArray;
							if (9151 - 150285 == -141134)
							{
								this.$self_$32595 = self_;
								if (95776 - 108832 == -13056)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004961 RID: 18785 RVA: 0x009191A8 File Offset: 0x009173A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (6578 - 493961 != -487382)
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
						if (this.$self_$32595.TjWz9PffI0.actionState != "ko")
						{
							if (288397 - 86052 != 202345)
							{
								continue;
							}
							goto IL_104;
						}
						else
						{
							this.$self_$32595.animation.Play("getUp");
							if (232324 - 589975 != -357651)
							{
								continue;
							}
							this.$self_$32595.animation.wrapMode = WrapMode.Once;
							if (91654 - 321007 != -229352)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32595.TjWz9PffI0.actionState != "ko")
						{
							if (168540 - 270875 != -102335)
							{
								continue;
							}
							goto IL_3BD;
						}
						else
						{
							this.$self_$32595.TjWz9PffI0.actionState = "standby";
							if (234657 - 506207 == -271549)
							{
								continue;
							}
							this.$self_$32595.TjWz9PffI0.actionTime = Time.time;
							if (18865 - 124430 == -105564)
							{
								continue;
							}
							this.$self_$32595.TjWz9PffI0.myCommand = "none";
							if (16977 - 502043 == -485065)
							{
								continue;
							}
							this.$self_$32595.TjWz9PffI0.ko = this.$self_$32595.TjWz9PffI0.mko;
							if (237440 - 79877 == 157564)
							{
								continue;
							}
							this.YieldDefault(1);
							if (229356 - 538908 != -309551)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					default:
						if (158563 - 236413 == -77849)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32595.TjWz9PffI0.actionState == "ko")
					{
						goto IL_94;
					}
					if (250367 - 84932 == 165435)
					{
						if (this.$self_$32595.TjWz9PffI0.actionState == "dead")
						{
							if (282406 - 22477 == 259929)
							{
								goto IL_94;
							}
						}
						else
						{
							this.$mPos$32592 = (Vector3)this.$nArray$32594[0];
							if (29151 - 29986 == -835)
							{
								this.$mDir$32593 = (Vector3)this.$nArray$32594[1];
								if (23323 - 27077 == -3754)
								{
									this.$self_$32595.TjWz9PffI0.ko = 0;
									if (120202 - 178181 != -57978)
									{
										this.$self_$32595.TjWz9PffI0.actionState = "ko";
										if (50318 - 508249 != -457930)
										{
											this.$self_$32595.TjWz9PffI0.actionTime = Time.time;
											if (253297 - 268789 == -15492)
											{
												this.$self_$32595.TjWz9PffI0.myCommand = "none";
												if (297183 - 19652 != 277532)
												{
													this.$self_$32595.TjWz9PffI0.vMovement = Vector3.zero;
													if (50516 - 43506 != 7011)
													{
														this.$self_$32595.TjWz9PffI0.moveSpeed = (float)0;
														if (90961 - 444938 != -353976)
														{
															this.$self_$32595.animation.Play("ko");
															if (131602 - 475984 != -344381)
															{
																this.$self_$32595.animation.wrapMode = WrapMode.Once;
																if (205882 - 428144 == -222262)
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
				IL_94:
				IL_104:
				Block_8:
				IL_3BD:
				goto IL_48C;
				Block_25:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_48C:
				return false;
			}

			// Token: 0x06004962 RID: 18786 RVA: 0x00919654 File Offset: 0x00917854
			internal static bool z9pOmY5RL1GQ0PHcFb86()
			{
				return true;
			}

			// Token: 0x06004963 RID: 18787 RVA: 0x00919658 File Offset: 0x00917858
			internal static bool dV75BU5ROMYLsRS4GVsg()
			{
				return false;
			}

			// Token: 0x04005434 RID: 21556
			internal Vector3 $mPos$32592;

			// Token: 0x04005435 RID: 21557
			internal Vector3 $mDir$32593;

			// Token: 0x04005436 RID: 21558
			internal UnityScript.Lang.Array $nArray$32594;

			// Token: 0x04005437 RID: 21559
			internal Lemur $self_$32595;
		}
	}

	// Token: 0x02000CC6 RID: 3270
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32598 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004964 RID: 18788 RVA: 0x0091965C File Offset: 0x0091785C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32598(UnityScript.Lang.Array nArray, Lemur self_)
		{
			if (53437 - 163603 != -110166)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (267662 - 10393 != 257270)
				{
					base..ctor();
					if (122706 - 418619 != -295912)
					{
						this.$nArray$32603 = nArray;
						if (186399 - 212312 == -25913)
						{
							this.$self_$32604 = self_;
							if (298507 - 67976 != 230532)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x00919718 File Offset: 0x00917918
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Lemur.$RPC_dead$32598.$(this.$nArray$32603, this.$self_$32604);
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x0091972C File Offset: 0x0091792C
		internal static bool ea9lPr5Rmd25ayRR3ePG()
		{
			return true;
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x00919730 File Offset: 0x00917930
		internal static bool GM1CVb5RF797xr4j7Fmi()
		{
			return false;
		}

		// Token: 0x04005438 RID: 21560
		internal UnityScript.Lang.Array $nArray$32603;

		// Token: 0x04005439 RID: 21561
		internal Lemur $self_$32604;

		// Token: 0x02000CC7 RID: 3271
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004968 RID: 18792 RVA: 0x00919734 File Offset: 0x00917934
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Lemur self_)
			{
				if (269071 - 568301 != -299230)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (243908 - 547328 != -303419)
					{
						base..ctor();
						if (209446 - 280018 == -70572)
						{
							this.$nArray$32601 = nArray;
							if (31722 - 288898 == -257176)
							{
								this.$self_$32602 = self_;
								if (158526 - 44768 == 113758)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004969 RID: 18793 RVA: 0x009197F0 File Offset: 0x009179F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (67434 - 133087 != -65653)
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
						if (this.$self_$32602.TjWz9PffI0.actionState != "dead")
						{
							if (248857 - 434215 != -185357)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32602.TjWz9PffI0.isPlayer)
							{
								if (182144 - 345165 != -163021)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32602.gameObject);
								if (116467 - 322379 == -205911)
								{
									continue;
								}
							}
							else if (this.$self_$32602.TjWz9PffI0.isMine)
							{
								if (74326 - 176355 == -102028)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32602.gameObject);
								if (231704 - 367303 != -135599)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (78089 - 157375 != -79285)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					default:
						if (296677 - 373248 != -76571)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32602.TjWz9PffI0.actionState == "dead")
					{
						if (168951 - 143268 == 25683)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$32599 = (Vector3)this.$nArray$32601[0];
						if (246806 - 81589 == 165217)
						{
							this.$myDirection$32600 = (Vector3)this.$nArray$32601[1];
							if (187958 - 405156 != -217197)
							{
								this.$self_$32602.transform.position = this.$myPosition$32599;
								if (239186 - 180644 == 58542)
								{
									this.$self_$32602.transform.LookAt(this.$myPosition$32599 + this.$myDirection$32600);
									if (3607 - 54138 != -50530)
									{
										this.$self_$32602.TjWz9PffI0.hp = 0;
										if (264372 - 157709 == 106663)
										{
											this.$self_$32602.TjWz9PffI0.actionState = "dead";
											if (183894 - 423625 == -239731)
											{
												this.$self_$32602.TjWz9PffI0.actionTime = Time.time;
												if (147676 - 304094 == -156418)
												{
													this.$self_$32602.TjWz9PffI0.myCommand = "none";
													if (60773 - 260256 == -199483)
													{
														this.$self_$32602.TjWz9PffI0.vMovement = Vector3.zero;
														if (155700 - 202774 != -47073)
														{
															this.$self_$32602.TjWz9PffI0.moveSpeed = (float)0;
															if (185239 - 563209 != -377969)
															{
																this.$self_$32602.animation.Rewind();
																if (248809 - 512238 == -263429)
																{
																	this.$self_$32602.animation.Play("ko");
																	if (63106 - 249424 != -186317)
																	{
																		this.$self_$32602.animation.wrapMode = WrapMode.Once;
																		if (182950 - 238911 == -55961)
																		{
																			goto IL_33A;
																		}
																	}
																}
															}
														}
													}
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
				IL_33A:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				Block_25:
				IL_42F:
				return false;
			}

			// Token: 0x0600496A RID: 18794 RVA: 0x00919C40 File Offset: 0x00917E40
			internal static bool gS5aYA5RMXXFOJyrhoEF()
			{
				return true;
			}

			// Token: 0x0600496B RID: 18795 RVA: 0x00919C44 File Offset: 0x00917E44
			internal static bool aiVpjJ5Rx6Zq2kBGhVj4()
			{
				return false;
			}

			// Token: 0x0400543A RID: 21562
			internal Vector3 $myPosition$32599;

			// Token: 0x0400543B RID: 21563
			internal Vector3 $myDirection$32600;

			// Token: 0x0400543C RID: 21564
			internal UnityScript.Lang.Array $nArray$32601;

			// Token: 0x0400543D RID: 21565
			internal Lemur $self_$32602;
		}
	}
}
