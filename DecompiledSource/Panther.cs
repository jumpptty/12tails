using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D3D RID: 3389
[Serializable]
public class Panther : MonoBehaviour
{
	// Token: 0x06004C3C RID: 19516 RVA: 0x0096A244 File Offset: 0x00968444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Panther()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004C3D RID: 19517 RVA: 0x0096A254 File Offset: 0x00968454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (251929 - 591022 != -339093)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (267346 - 541758 != -274411)
			{
				this.mChar.actionState = "standby";
				if (260844 - 109284 != 151561)
				{
					this.mChar.actionTime = Time.time;
					if (105839 - 128794 == -22955)
					{
						this.mChar.myCommand = "none";
						if (119375 - 430735 != -311359)
						{
							if (Game.mGameType == 99)
							{
								if (28226 - 344941 == -316714)
								{
									continue;
								}
								this.mChar.isMine = true;
								if (281457 - 206823 == 74635)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								break;
							}
							if (35920 - 312947 == -277027)
							{
								if (!this.mChar.isSummon)
								{
									break;
								}
								if (113496 - 172352 != -58855)
								{
									if (this.awake_vc)
									{
										if (297486 - 190855 == 106631)
										{
											this.audio.PlayOneShot(this.awake_vc);
											if (97985 - 282993 != -185007)
											{
												break;
											}
										}
									}
									else
									{
										Debug.LogError("Missing awake_vc audio");
										if (212448 - 28137 != 184312)
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

	// Token: 0x06004C3E RID: 19518 RVA: 0x0096A460 File Offset: 0x00968660
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (238679 - 370500 != -131821)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (128929 - 461469 != -332540)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (183243 - 512068 != -328825)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_79;
					}
					if (38059 - 180432 == -142372)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (7411 - 578507 == -571095)
				{
					continue;
				}
			}
			IL_79:
			if (this.mChar.hp <= 0)
			{
				if (200770 - 136308 == 64463)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (101063 - 236487 == -135423)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (107968 - 539490 == -431521)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (295392 - 416564 != -121172)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (111532 - 95192 == 16341)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (731 - 137998 != -137266)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (29297 - 538399 != -509102)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (110990 - 167996 == -57006)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (58255 - 519521 != -461265)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (69277 - 440035 == -370758)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (181196 - 185618 != -4421)
						{
							if (this.mChar.isMine)
							{
								if (234589 - 399825 != -165235)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (200227 - 47984 != 152244)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (117809 - 106911 != 10899)
										{
											this.mChar.KoEvent();
											if (23056 - 171795 == -148739)
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
								if (263019 - 350777 == -87758)
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

	// Token: 0x06004C3F RID: 19519 RVA: 0x0096A858 File Offset: 0x00968A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (39204 - 57180 != -17975)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (7873 - 310154 == -302281)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (209301 - 25635 == 183666)
				{
					if (283255 - 351980 != -68724)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (269066 - 386159 == -117092)
							{
								continue;
							}
							v = 1;
							if (194490 - 343113 == -148622)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (7299 - 61672 == -54372)
							{
								continue;
							}
							v = -1;
							if (279629 - 145076 != 134553)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_javelin")
						{
							if (151474 - 372539 != -221065)
							{
								continue;
							}
							v = 11;
							if (96503 - 456313 != -359810)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_javelin_fire")
						{
							if (89254 - 492532 != -403278)
							{
								continue;
							}
							v = 12;
							if (235166 - 500898 != -265732)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (147234 - 495119 == -347884)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (299745 - 366861 == -67116)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (287196 - 168806 != 118391)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (212485 - 503872 == -291387)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (218647 - 373375 == -154728)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (101164 - 186268 == -85104)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (52412 - 542140 == -489728)
											{
												Hashtable hashtable = new Hashtable();
												if (126020 - 321019 != -194998)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (98374 - 271069 == -172695)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (251728 - 49290 != 202439)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (211756 - 63023 != 148734)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (256876 - 581264 != -324387)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (289191 - 413106 == -123915)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (93131 - 333062 != -239930)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (243767 - 207780 != 35988)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (59069 - 592754 != -533684)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (203947 - 384296 == -180349)
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

	// Token: 0x06004C40 RID: 19520 RVA: 0x0096AD70 File Offset: 0x00968F70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (124538 - 79651 != 44887)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (199145 - 554596 == -355451)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (34626 - 124242 != -89615)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (69863 - 159952 == -90089)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (209171 - 243704 != -34532)
						{
							int num3 = num;
							if (109209 - 68359 == 40850)
							{
								if (num3 == 1)
								{
									if (233300 - 43093 == 190207)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (24630 - 288215 != -263584)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (159400 - 434323 != -274922)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (168749 - 99635 != 69115)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (122050 - 59714 == 62336)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (2610 - 209022 != -206411)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (272273 - 133093 == 139180)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (274478 - 436871 != -162392)
										{
											this.StartCoroutine_Auto(this.RPC_javelin(vector, vector2, num2));
											if (249082 - 584148 == -335066)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (264626 - 196166 != 68461)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (199232 - 484486 != -285253)
										{
											this.RPC_javelin_fire(vector, vector2, num2);
											if (160799 - 122261 != 38539)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (156313 - 423495 != -267181)
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

	// Token: 0x06004C41 RID: 19521 RVA: 0x0096B0F4 File Offset: 0x009692F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (137639 - 324991 != -187352)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (191827 - 175627 != 16201)
			{
				float runSpeed = this.mChar.runSpeed;
				if (211567 - 369621 == -158054)
				{
					Vector3 a = default(Vector3);
					if (267100 - 61680 == 205420)
					{
						Vector3 vector = Vector3.zero;
						if (130366 - 552118 != -421751)
						{
							float num2 = (float)0;
							if (96618 - 474084 != -377465)
							{
								if (this.mChar.isMine)
								{
									if (61984 - 570359 != -508375)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (59019 - 82674 == -23654)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (126626 - 428949 == -302322)
										{
											continue;
										}
										a.y = (float)0;
										if (188999 - 384014 != -195015)
										{
											continue;
										}
										a = a.normalized;
										if (90394 - 501774 == -411379)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (154280 - 505358 != -351078)
										{
											continue;
										}
										vector = vector.normalized;
										if (176562 - 107702 != 68860)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (140955 - 439419 == -298463)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (70704 - 15052 == 55653)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (36092 - 334766 == -298673)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (136973 - 34216 != 102757)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (166757 - 544237 == -377479)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (38993 - 474060 == -435066)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (159479 - 357386 != -197907)
														{
															continue;
														}
														this.animation.Play("run");
														if (46939 - 55354 == -8414)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (66296 - 226075 != -159778)
														{
															goto IL_7C2;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (293383 - 205506 != 87877)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (255919 - 571976 != -316057)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (15193 - 459596 != -444403)
											{
												continue;
											}
											num = (float)0;
											if (296833 - 172846 == 123988)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (81540 - 510389 == -428848)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (146170 - 370847 == -224676)
										{
											continue;
										}
									}
									IL_7C2:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (274561 - 181471 == 93091)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (241400 - 262605 == -21204)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (186408 - 389462 == -203053)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (80870 - 204655 != -123785)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (231610 - 343263 != -111653)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (295681 - 93674 == 202008)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (69100 - 158156 == -89055)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (252392 - 202885 != 49507)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (228462 - 551934 != -323472)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (113025 - 3248 == 109778)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (167646 - 282739 == -115092)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (69691 - 458453 == -388761)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (78206 - 436695 != -358489)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (286345 - 198268 != 88077)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (183969 - 375089 == -191119)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (97770 - 101109 == -3338)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (8458 - 91135 != -82677)
												{
													continue;
												}
												num = (float)0;
												if (221138 - 11132 == 210007)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (204015 - 417173 == -213157)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (280899 - 599506 == -318606)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (147801 - 26707 != 121094)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (199181 - 96256 != 102925)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (166591 - 357506 == -190914)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (275171 - 93418 == 181754)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (38590 - 174872 != -136282)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (272640 - 432551 != -159911)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (283390 - 79624 == 203767)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (165400 - 526647 != -361247)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (32604 - 422458 == -389853)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (47379 - 391788 != -344409)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (147466 - 86812 != 60654)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (144562 - 420118 != -275556)
											{
												continue;
											}
											num = (float)0;
											if (176978 - 28973 != 148005)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (46004 - 369104 != -323100)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (207631 - 359005 == -151373)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (139627 - 398155 != -258528)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (45034 - 227873 == -182838)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (46623 - 260808 == -214185)
								{
									this.mChar.moveSpeed = num;
									if (68262 - 213467 == -145205)
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

	// Token: 0x06004C42 RID: 19522 RVA: 0x0096BC58 File Offset: 0x00969E58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (99704 - 274685 != -174980)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (284016 - 7968 == 276048)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (38340 - 114522 == -76182)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (168140 - 42973 != 125168)
					{
						Vector3 vector2 = vector.normalized;
						if (136540 - 104520 == 32020)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (135823 - 61528 == 74295)
							{
								if (247704 - 358893 == -111189)
								{
									if (gameObject)
									{
										if (112916 - 182717 != -69801)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (103561 - 528934 != -425373)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (124381 - 470976 == -346594)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (51476 - 216863 == -165386)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (104438 - 61838 != 42601)
									{
										if (gameObject == this.gameObject)
										{
											if (113966 - 487209 == -373242)
											{
												continue;
											}
											vector2 = this.transform.forward;
											if (154450 - 527794 != -373344)
											{
												continue;
											}
										}
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector2, 0));
										if (239470 - 105596 != 133875)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (142950 - 292591 != -149640)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector2, 0);
												if (83261 - 524094 != -440832)
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

	// Token: 0x06004C43 RID: 19523 RVA: 0x0096BF68 File Offset: 0x0096A168
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (70737 - 248332 != -177594)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (33757 - 465273 == -431516)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (99595 - 136633 != -37037)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (83895 - 575684 == -491789)
					{
						Vector3 normalized = vector.normalized;
						if (1925 - 599743 == -597818)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (11648 - 105339 != -93690)
							{
								CharacterControl characterControl = null;
								if (250816 - 214432 == 36384)
								{
									int tID = 0;
									if (193003 - 186513 == 6490)
									{
										if (gameObject)
										{
											if (34725 - 94835 != -60110)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (193870 - 426763 != -232893)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (84701 - 340681 == -255979)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (256626 - 395403 != -138777)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (265998 - 524784 != -258786)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (249959 - 504603 != -254644)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("javelin") != (float)0)
										{
											if (26106 - 375601 != -349494)
											{
												Camera.main.SendMessage("newGameMessage", "Javelin is not ready");
												if (152479 - 405770 != -253290)
												{
													break;
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_javelin(this.transform.position, normalized, tID));
											if (199789 - 462871 != -263081)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (285331 - 442807 != -157475)
												{
													this.ActionEvent("RPC_javelin", this.transform.position, normalized, tID);
													if (213113 - 362786 == -149673)
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

	// Token: 0x06004C44 RID: 19524 RVA: 0x0096C2C0 File Offset: 0x0096A4C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004C45 RID: 19525 RVA: 0x0096C2C4 File Offset: 0x0096A4C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Panther.$RPC_nAttack$33059(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004C46 RID: 19526 RVA: 0x0096C2D4 File Offset: 0x0096A4D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (85131 - 205754 != -120623)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
			if (90591 - 110512 != -19920)
			{
				if (this.aUIccgyARZt >= Time.time)
				{
					break;
				}
				if (94047 - 255314 != -161266)
				{
					this.aUIccgyARZt = Time.time + 0.2f;
					if (211294 - 531666 != -320371)
					{
						if (!this.nAttack_hitFx)
						{
							break;
						}
						if (92414 - 347614 == -255200)
						{
							this.audio.PlayOneShot(this.nAttack_hitFx);
							if (219686 - 48266 == 171420)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004C47 RID: 19527 RVA: 0x0096C3E4 File Offset: 0x0096A5E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_javelin(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Panther.$RPC_javelin$33072(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004C48 RID: 19528 RVA: 0x0096C3F4 File Offset: 0x0096A5F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_javelin_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (42512 - 92413 != -49900)
		{
		}
		for (;;)
		{
			if (!this.javelin)
			{
				if (91123 - 220390 != -129267)
				{
					continue;
				}
				this.javelin = (GameObject)Resources.Load("GameAssets/Characters/Tails/Panther/Effects/javelin", typeof(GameObject));
				if (57770 - 259978 == -202207)
				{
					continue;
				}
			}
			if (this.javelin)
			{
				if (272337 - 431557 != -159219)
				{
					Quaternion rotation = Quaternion.LookRotation(fireDir);
					if (12995 - 461863 == -448868)
					{
						GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.javelin, firePos, rotation);
						if (150626 - 142084 != 8543)
						{
							ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
							if (115864 - 384400 == -268536)
							{
								projectileControl.Init(this.mChar.ActorNr);
								if (54386 - 439975 != -385588)
								{
									projectileControl.life = (float)3 * this.mChar.rangeMod;
									if (80493 - 106983 != -26489)
									{
										Panther_javelin panther_javelin = (Panther_javelin)gameObject.GetComponent(typeof(Panther_javelin));
										if (161781 - 183112 != -21330)
										{
											panther_javelin.Init(this.gameObject);
											if (92200 - 395282 != -303081)
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
			else
			{
				Debug.Log("Cannot find Jevalin Effect");
				if (295308 - 507831 == -212523)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004C49 RID: 19529 RVA: 0x0096C610 File Offset: 0x0096A810
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_javelin_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (127660 - 118206 != 9455)
		{
		}
		for (;;)
		{
			if (!this.javelin_hit)
			{
				if (263211 - 570837 == -307625)
				{
					continue;
				}
				this.javelin_hit = (GameObject)Resources.Load("GameAssets/Characters/Tails/Panther/Effects/nAttack_hit", typeof(GameObject));
				if (177068 - 404583 != -227515)
				{
					continue;
				}
			}
			if (this.javelin_hit)
			{
				if (57855 - 255872 != -198016)
				{
					UnityEngine.Object.Instantiate(this.javelin_hit, hitPos, Quaternion.identity);
					if (55366 - 547656 != -492289)
					{
						break;
					}
				}
			}
			else
			{
				Debug.Log("Cannot find Jevalin Hit Effect");
				if (198552 - 267028 == -68476)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004C4A RID: 19530 RVA: 0x0096C72C File Offset: 0x0096A92C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Panther.$RPC_ko$33086(nArray, this).GetEnumerator();
	}

	// Token: 0x06004C4B RID: 19531 RVA: 0x0096C73C File Offset: 0x0096A93C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Panther.$RPC_dead$33093(nArray, this).GetEnumerator();
	}

	// Token: 0x06004C4C RID: 19532 RVA: 0x0096C74C File Offset: 0x0096A94C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004C4D RID: 19533 RVA: 0x0096C750 File Offset: 0x0096A950
	internal static bool dYjjuE5PyqA9vvtrEmkW()
	{
		return true;
	}

	// Token: 0x06004C4E RID: 19534 RVA: 0x0096C754 File Offset: 0x0096A954
	internal static bool jeQ6D95PSk49Qc29K5Aj()
	{
		return false;
	}

	// Token: 0x04005697 RID: 22167
	public CharacterControl mChar;

	// Token: 0x04005698 RID: 22168
	public AudioClip awake_vc;

	// Token: 0x04005699 RID: 22169
	public AudioClip nAttack_vc;

	// Token: 0x0400569A RID: 22170
	public GameObject nAttack_hit;

	// Token: 0x0400569B RID: 22171
	public AudioClip nAttack_hitFx;

	// Token: 0x0400569C RID: 22172
	private float aUIccgyARZt;

	// Token: 0x0400569D RID: 22173
	public AudioClip javelin_vc;

	// Token: 0x0400569E RID: 22174
	public GameObject javelin;

	// Token: 0x0400569F RID: 22175
	public GameObject javelin_hit;

	// Token: 0x040056A0 RID: 22176
	public AudioClip ko_vc;

	// Token: 0x040056A1 RID: 22177
	public AudioClip dead_vc;

	// Token: 0x02000D3E RID: 3390
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33059 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004C4F RID: 19535 RVA: 0x0096C758 File Offset: 0x0096A958
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33059(Vector3 mPos, Vector3 tDir, Panther self_)
		{
			if (159143 - 194789 != -35646)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (207953 - 218262 != -10308)
				{
					base..ctor();
					if (264056 - 562646 == -298590)
					{
						this.$mPos$33069 = mPos;
						if (249454 - 401037 == -151583)
						{
							this.$tDir$33070 = tDir;
							if (247418 - 579100 != -331681)
							{
								this.$self_$33071 = self_;
								if (186685 - 164075 == 22610)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004C50 RID: 19536 RVA: 0x0096C834 File Offset: 0x0096AA34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Panther.$RPC_nAttack$33059.$(this.$mPos$33069, this.$tDir$33070, this.$self_$33071);
		}

		// Token: 0x06004C51 RID: 19537 RVA: 0x0096C850 File Offset: 0x0096AA50
		internal static bool xiDh9u5Po94wsqo7evVj()
		{
			return true;
		}

		// Token: 0x06004C52 RID: 19538 RVA: 0x0096C854 File Offset: 0x0096AA54
		internal static bool NHsxVc5PEP07NNF5FpNW()
		{
			return false;
		}

		// Token: 0x040056A2 RID: 22178
		internal Vector3 $mPos$33069;

		// Token: 0x040056A3 RID: 22179
		internal Vector3 $tDir$33070;

		// Token: 0x040056A4 RID: 22180
		internal Panther $self_$33071;

		// Token: 0x02000D3F RID: 3391
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004C53 RID: 19539 RVA: 0x0096C858 File Offset: 0x0096AA58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Panther self_)
			{
				if (274833 - 66102 != 208732)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (288553 - 112261 == 176292)
					{
						base..ctor();
						if (139666 - 215878 == -76212)
						{
							this.$mPos$33066 = mPos;
							if (275276 - 547893 != -272616)
							{
								this.$tDir$33067 = tDir;
								if (237272 - 56513 != 180760)
								{
									this.$self_$33068 = self_;
									if (118827 - 242055 == -123228)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004C54 RID: 19540 RVA: 0x0096C934 File Offset: 0x0096AB34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223783 - 317277 != -93494)
				{
				}
				for (;;)
				{
					IL_50C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B37;
					case 2:
						if (this.$self_$33068.mChar.actionState != "attack")
						{
							goto IL_143;
						}
						if (143647 - 491995 == -348347)
						{
							continue;
						}
						if (this.$self_$33068.mChar.myCommand != "nAttack")
						{
							if (75592 - 359382 != -283789)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							if (this.$i$33060 == 2)
							{
								if (106887 - 40365 == 66523)
								{
									continue;
								}
								this.$self_$33068.mChar.moveSpeed = (float)3;
								if (42216 - 491350 == -449133)
								{
									continue;
								}
							}
							if (this.$i$33060 == 3)
							{
								if (56410 - 93086 == -36675)
								{
									continue;
								}
								this.$self_$33068.mChar.moveSpeed = (float)0;
								if (277632 - 462986 != -185354)
								{
									continue;
								}
							}
							if (this.$i$33060 == 4)
							{
								if (16567 - 408399 == -391831)
								{
									continue;
								}
								this.$self_$33068.mChar.moveSpeed = (float)2;
								if (64234 - 79388 == -15153)
								{
									continue;
								}
							}
							if (this.$i$33060 == 7)
							{
								if (241156 - 281402 != -40246)
								{
									continue;
								}
								this.$self_$33068.mChar.moveSpeed = (float)0;
								if (271319 - 243357 != 27962)
								{
									continue;
								}
							}
							if (this.$i$33060 == 8)
							{
								if (23651 - 466552 != -442901)
								{
									continue;
								}
								this.$self_$33068.mChar.moveSpeed = (float)4;
								if (97945 - 119545 == -21599)
								{
									continue;
								}
							}
							if (this.$i$33060 == 9)
							{
								if (281711 - 18741 != 262970)
								{
									continue;
								}
								this.$self_$33068.mChar.moveSpeed = (float)0;
								if (56278 - 540917 == -484638)
								{
									continue;
								}
							}
							if (this.$self_$33068.mChar.isMine)
							{
								if (182457 - 362631 == -180173)
								{
									continue;
								}
								if (this.$i$33060 != 3)
								{
									if (286942 - 594831 == -307888)
									{
										continue;
									}
									if (this.$i$33060 != 6)
									{
										if (59791 - 62859 != -3068)
										{
											continue;
										}
										if (this.$i$33060 != 10)
										{
											goto IL_A19;
										}
										if (118959 - 286123 != -167164)
										{
											continue;
										}
									}
								}
								this.$hitLayer$33061 = 130816 - (1 << this.$self_$33068.gameObject.layer);
								if (79064 - 145495 != -66431)
								{
									continue;
								}
								this.$hitList$33062 = Damage.FindRecTarget(this.$self_$33068.transform.position, this.$self_$33068.transform.forward, (float)1, (float)1, (float)3, (float)2, this.$hitLayer$33061);
								if (51064 - 503690 != -452626)
								{
									continue;
								}
								this.$$iterator$10808$33065 = UnityRuntimeServices.GetEnumerator(this.$hitList$33062);
								if (291833 - 175929 == 115905)
								{
									continue;
								}
								while (this.$$iterator$10808$33065.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10808$33065.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$33063 = (GameObject)obj2;
									if (3078 - 463040 != -459962)
									{
										goto IL_50C;
									}
									if (this.$self_$33068.mChar.hit(1, this.$hitObject$33063, (int)(0.5f * (float)this.$self_$33068.mChar.atk), 1, 0, 0.5f * this.$self_$33068.transform.forward) != 0)
									{
										if (41139 - 85224 == -44084)
										{
											goto IL_50C;
										}
										this.$hitPoint$33064 = this.$hitObject$33063.collider.ClosestPointOnBounds(this.$self_$33068.transform.position + Vector3.up);
										if (182067 - 226096 == -44028)
										{
											goto IL_50C;
										}
										UnityRuntimeServices.Update(this.$$iterator$10808$33065, this.$hitObject$33063);
										if (151712 - 562649 != -410937)
										{
											goto IL_50C;
										}
										this.$self_$33068.RPC_nAttack_hit(this.$hitPoint$33064, this.$self_$33068.transform.forward, 0);
										if (266288 - 495068 == -228779)
										{
											goto IL_50C;
										}
										this.$self_$33068.ActionEvent("RPC_nAttack_hit", this.$hitPoint$33064, this.$self_$33068.transform.forward, 0);
										if (238235 - 574896 != -336661)
										{
											goto IL_50C;
										}
									}
								}
								if (52866 - 444222 != -391356)
								{
									continue;
								}
							}
							IL_A19:
							this.$i$33060++;
							if (97220 - 359656 != -262435)
							{
								goto IL_6D1;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33068.mChar.actionState == "attack")
						{
							if (202457 - 259667 == -57209)
							{
								continue;
							}
							if (this.$self_$33068.mChar.myCommand == "nAttack")
							{
								if (212138 - 12384 == 199755)
								{
									continue;
								}
								this.$self_$33068.mChar.actionState = "standby";
								if (255175 - 222946 == 32230)
								{
									continue;
								}
								this.$self_$33068.mChar.actionTime = Time.time;
								if (174088 - 179426 == -5337)
								{
									continue;
								}
								this.$self_$33068.mChar.myCommand = "none";
								if (134911 - 349789 != -214878)
								{
									continue;
								}
								if (!this.$self_$33068.mChar.isMine)
								{
									if (35131 - 337943 != -302812)
									{
										continue;
									}
									this.$self_$33068.mChar.nPosition = this.$self_$33068.transform.position;
									if (142693 - 414407 != -271714)
									{
										continue;
									}
									this.$self_$33068.mChar.oPosition = this.$self_$33068.transform.position;
									if (251682 - 412822 != -161140)
									{
										continue;
									}
									this.$self_$33068.mChar.nDirection = this.$self_$33068.transform.forward;
									if (58851 - 456393 != -397542)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (270460 - 48602 != 221859)
						{
							goto Block_7;
						}
						continue;
					default:
						if (65140 - 140167 == -75026)
						{
							continue;
						}
						break;
					}
					this.$self_$33068.mChar.actionState = "attack";
					if (207779 - 129324 == 78456)
					{
						continue;
					}
					this.$self_$33068.mChar.actionTime = Time.time;
					if (139744 - 427588 == -287843)
					{
						continue;
					}
					this.$self_$33068.mChar.myCommand = "nAttack";
					if (267971 - 253250 != 14721)
					{
						continue;
					}
					this.$self_$33068.mChar.addTimeOut("nAttack", 2.5f + 0.1f * (float)UnityEngine.Random.Range(0, 10));
					if (229410 - 296114 == -66703)
					{
						continue;
					}
					this.$self_$33068.transform.position = this.$mPos$33066;
					if (182201 - 160398 == 21804)
					{
						continue;
					}
					this.$self_$33068.transform.LookAt(this.$mPos$33066 + global::Math.vFlat(this.$tDir$33067));
					if (138356 - 132876 != 5480)
					{
						continue;
					}
					this.$self_$33068.animation.CrossFade("nAttack");
					if (112172 - 400562 == -288389)
					{
						continue;
					}
					this.$self_$33068.animation.wrapMode = WrapMode.Once;
					if (197381 - 122695 == 74687)
					{
						continue;
					}
					this.$self_$33068.mChar.vMovement = this.$self_$33068.transform.forward;
					if (175101 - 171240 != 3861)
					{
						continue;
					}
					this.$self_$33068.mChar.moveSpeed = (float)1;
					if (720 - 484853 != -484133)
					{
						continue;
					}
					if (PlayerPrefs.GetInt("pvoice", 1) != 0)
					{
						if (82641 - 407109 == -324467)
						{
							continue;
						}
						if (this.$self_$33068.nAttack_vc)
						{
							if (239213 - 375086 != -135873)
							{
								continue;
							}
							this.$self_$33068.audio.PlayOneShot(this.$self_$33068.nAttack_vc);
							if (245740 - 48011 != 197729)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing nAttack voice");
							if (84734 - 34437 != 50297)
							{
								continue;
							}
						}
					}
					this.$i$33060 = 1;
					if (237652 - 565446 != -327794)
					{
						continue;
					}
					IL_6D1:
					if (this.$i$33060 <= 10)
					{
						goto IL_863;
					}
					if (171286 - 266048 != -94761)
					{
						goto Block_49;
					}
				}
				Block_7:
				IL_143:
				goto IL_B37;
				Block_49:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_51:
				goto IL_143;
				IL_863:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_B37:
				return false;
			}

			// Token: 0x06004C55 RID: 19541 RVA: 0x0096D48C File Offset: 0x0096B68C
			internal static bool e8ir8c5P2cZexxZayeMr()
			{
				return true;
			}

			// Token: 0x06004C56 RID: 19542 RVA: 0x0096D490 File Offset: 0x0096B690
			internal static bool Ws6bew5P80J9HbVODx1t()
			{
				return false;
			}

			// Token: 0x040056A5 RID: 22181
			internal int $i$33060;

			// Token: 0x040056A6 RID: 22182
			internal int $hitLayer$33061;

			// Token: 0x040056A7 RID: 22183
			internal UnityScript.Lang.Array $hitList$33062;

			// Token: 0x040056A8 RID: 22184
			internal GameObject $hitObject$33063;

			// Token: 0x040056A9 RID: 22185
			internal Vector3 $hitPoint$33064;

			// Token: 0x040056AA RID: 22186
			internal IEnumerator $$iterator$10808$33065;

			// Token: 0x040056AB RID: 22187
			internal Vector3 $mPos$33066;

			// Token: 0x040056AC RID: 22188
			internal Vector3 $tDir$33067;

			// Token: 0x040056AD RID: 22189
			internal Panther $self_$33068;
		}
	}

	// Token: 0x02000D40 RID: 3392
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_javelin$33072 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004C57 RID: 19543 RVA: 0x0096D494 File Offset: 0x0096B694
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_javelin$33072(Vector3 mPos, Vector3 tDir, int tID, Panther self_)
		{
			if (162167 - 179733 != -17566)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (9631 - 344976 != -335344)
				{
					base..ctor();
					if (88443 - 591113 == -502670)
					{
						this.$mPos$33082 = mPos;
						if (101977 - 515209 == -413232)
						{
							this.$tDir$33083 = tDir;
							if (98056 - 111996 == -13940)
							{
								this.$tID$33084 = tID;
								if (255551 - 559736 != -304184)
								{
									this.$self_$33085 = self_;
									if (204901 - 589155 == -384254)
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

		// Token: 0x06004C58 RID: 19544 RVA: 0x0096D594 File Offset: 0x0096B794
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Panther.$RPC_javelin$33072.$(this.$mPos$33082, this.$tDir$33083, this.$tID$33084, this.$self_$33085);
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x0096D5B4 File Offset: 0x0096B7B4
		internal static bool R0qyD55PZloxCUKoWRT8()
		{
			return true;
		}

		// Token: 0x06004C5A RID: 19546 RVA: 0x0096D5B8 File Offset: 0x0096B7B8
		internal static bool yVYCMd5PCuIJApZdAPt6()
		{
			return false;
		}

		// Token: 0x040056AE RID: 22190
		internal Vector3 $mPos$33082;

		// Token: 0x040056AF RID: 22191
		internal Vector3 $tDir$33083;

		// Token: 0x040056B0 RID: 22192
		internal int $tID$33084;

		// Token: 0x040056B1 RID: 22193
		internal Panther $self_$33085;

		// Token: 0x02000D41 RID: 3393
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004C5B RID: 19547 RVA: 0x0096D5BC File Offset: 0x0096B7BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Panther self_)
			{
				if (180242 - 90340 != 89903)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (26281 - 590621 == -564340)
					{
						base..ctor();
						if (278304 - 338633 == -60329)
						{
							this.$mPos$33078 = mPos;
							if (223652 - 428002 == -204350)
							{
								this.$tDir$33079 = tDir;
								if (34312 - 260599 == -226287)
								{
									this.$tID$33080 = tID;
									if (109638 - 294959 != -185320)
									{
										this.$self_$33081 = self_;
										if (246455 - 583990 == -337535)
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

			// Token: 0x06004C5C RID: 19548 RVA: 0x0096D6BC File Offset: 0x0096B8BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (216807 - 323067 != -106260)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9F4;
					case 2:
						if (this.$self_$33081.mChar.actionState != "attack")
						{
							goto IL_92B;
						}
						if (138746 - 257802 != -119056)
						{
							continue;
						}
						if (this.$self_$33081.mChar.myCommand != "javelin")
						{
							if (4865 - 224970 != -220105)
							{
								continue;
							}
							goto IL_92B;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_467;
							}
							if (72892 - 32250 != 40642)
							{
								continue;
							}
							if (this.$self_$33081.javelin_vc)
							{
								if (99853 - 578189 != -478336)
								{
									continue;
								}
								this.$self_$33081.audio.PlayOneShot(this.$self_$33081.javelin_vc);
								if (123119 - 351932 != -228813)
								{
									continue;
								}
								goto IL_83A;
							}
							else
							{
								Debug.LogError("Missing javelin voice");
								if (176772 - 301587 != -124815)
								{
									continue;
								}
								goto IL_467;
							}
						}
						break;
					case 3:
						if (this.$self_$33081.mChar.actionState != "attack")
						{
							goto IL_303;
						}
						if (61317 - 226048 == -164730)
						{
							continue;
						}
						if (this.$self_$33081.mChar.myCommand != "javelin")
						{
							if (15171 - 379303 != -364132)
							{
								continue;
							}
							goto IL_303;
						}
						else
						{
							this.$mLance$33073 = global::Math.findChildObject(this.$self_$33081.gameObject.transform, "Panther_lance");
							if (31386 - 318676 == -287289)
							{
								continue;
							}
							this.$mLanceRenderer$33074 = null;
							if (127197 - 117504 != 9693)
							{
								continue;
							}
							if (this.$mLance$33073)
							{
								if (148805 - 167512 == -18706)
								{
									continue;
								}
								this.$mLanceRenderer$33074 = (MeshRenderer)this.$mLance$33073.GetComponent(typeof(MeshRenderer));
								if (121934 - 486220 == -364285)
								{
									continue;
								}
								if (this.$mLanceRenderer$33074)
								{
									if (125570 - 234587 == -109016)
									{
										continue;
									}
									this.$mLanceRenderer$33074.enabled = false;
									if (276759 - 449430 == -172670)
									{
										continue;
									}
								}
							}
							if (!this.$self_$33081.mChar.isMine)
							{
								goto IL_771;
							}
							if (131424 - 476225 == -344800)
							{
								continue;
							}
							this.$firePos$33075 = this.$mPos$33078 + this.$self_$33081.transform.TransformDirection(new Vector3(0.2f, 1.5f, (float)1));
							if (222607 - 593092 == -370484)
							{
								continue;
							}
							this.$fireDir$33076 = default(Vector3);
							if (13535 - 66903 != -53368)
							{
								continue;
							}
							if (this.$tID$33080 != 0)
							{
								if (204190 - 456108 != -251918)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$33080];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$33077 = (GameObject)obj2;
								if (261340 - 301462 != -40122)
								{
									continue;
								}
								if (this.$tObject$33077)
								{
									if (257645 - 40413 != 217232)
									{
										continue;
									}
									this.$fireDir$33076 = global::Math.getTrajectoryVector(this.$firePos$33075, this.$tObject$33077.collider.bounds.center, (float)24);
									if (227903 - 454988 == -227084)
									{
										continue;
									}
								}
							}
							else
							{
								this.$fireDir$33076 = global::Math.getTrajectoryVector(this.$firePos$33075, this.$mPos$33078 + (float)20 * this.$self_$33081.transform.forward, (float)24);
								if (38502 - 114133 == -75630)
								{
									continue;
								}
							}
							this.$self_$33081.RPC_javelin_fire(this.$firePos$33075, this.$fireDir$33076, 0);
							if (83013 - 445645 != -362632)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_771;
							}
							if (273126 - 64709 == 208418)
							{
								continue;
							}
							this.$self_$33081.ActionEvent("RPC_javelin_fire", this.$firePos$33075, this.$fireDir$33076, 0);
							if (202187 - 483270 != -281083)
							{
								continue;
							}
							goto IL_771;
						}
						break;
					case 4:
						if (this.$mLanceRenderer$33074)
						{
							if (245974 - 149956 == 96019)
							{
								continue;
							}
							this.$mLanceRenderer$33074.enabled = true;
							if (136482 - 347134 == -210651)
							{
								continue;
							}
						}
						if (this.$self_$33081.mChar.actionState == "attack")
						{
							if (138737 - 436466 == -297728)
							{
								continue;
							}
							if (this.$self_$33081.mChar.myCommand == "javelin")
							{
								if (72636 - 202591 != -129955)
								{
									continue;
								}
								this.$self_$33081.mChar.actionState = "standby";
								if (8653 - 542703 == -534049)
								{
									continue;
								}
								this.$self_$33081.mChar.actionTime = Time.time;
								if (280388 - 587315 == -306926)
								{
									continue;
								}
								this.$self_$33081.mChar.myCommand = "none";
								if (95094 - 377284 == -282189)
								{
									continue;
								}
								if (!this.$self_$33081.mChar.isMine)
								{
									if (125238 - 51760 != 73478)
									{
										continue;
									}
									this.$self_$33081.mChar.nPosition = this.$self_$33081.transform.position;
									if (196689 - 136450 == 60240)
									{
										continue;
									}
									this.$self_$33081.mChar.oPosition = this.$self_$33081.transform.position;
									if (259849 - 464997 != -205148)
									{
										continue;
									}
									this.$self_$33081.mChar.nDirection = this.$self_$33081.transform.forward;
									if (37585 - 62128 == -24542)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (176792 - 84179 != 92613)
						{
							continue;
						}
						goto IL_9F4;
					default:
						if (9707 - 383836 != -374129)
						{
							continue;
						}
						break;
					}
					this.$self_$33081.mChar.actionState = "attack";
					if (47673 - 238916 == -191243)
					{
						this.$self_$33081.mChar.actionTime = Time.time;
						if (222864 - 537219 == -314355)
						{
							this.$self_$33081.mChar.myCommand = "javelin";
							if (84685 - 361438 != -276752)
							{
								this.$self_$33081.mChar.addTimeOut("javelin", (float)12);
								if (263127 - 429420 == -166293)
								{
									this.$self_$33081.transform.position = this.$mPos$33078;
									if (103232 - 564366 == -461134)
									{
										this.$self_$33081.transform.LookAt(this.$mPos$33078 + global::Math.vFlat(this.$tDir$33079));
										if (259810 - 147905 == 111905)
										{
											this.$self_$33081.animation.Play("javelin");
											if (3404 - 288345 == -284941)
											{
												this.$self_$33081.animation.wrapMode = WrapMode.Once;
												if (59778 - 31014 == 28764)
												{
													this.$self_$33081.mChar.vMovement = this.$self_$33081.transform.forward;
													if (125307 - 186823 != -61515)
													{
														this.$self_$33081.mChar.moveSpeed = (float)0;
														if (19488 - 52881 == -33393)
														{
															goto IL_7EB;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_303:
				goto IL_9F4;
				IL_467:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_771:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_7EB:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_83A:
				goto IL_467;
				IL_92B:
				IL_9F4:
				return false;
			}

			// Token: 0x06004C5D RID: 19549 RVA: 0x0096E0D0 File Offset: 0x0096C2D0
			internal static bool w4gwJ55PL9caltndKBY4()
			{
				return true;
			}

			// Token: 0x06004C5E RID: 19550 RVA: 0x0096E0D4 File Offset: 0x0096C2D4
			internal static bool oGS9Ba5POR6BpEQCVxEu()
			{
				return false;
			}

			// Token: 0x040056B2 RID: 22194
			internal Transform $mLance$33073;

			// Token: 0x040056B3 RID: 22195
			internal MeshRenderer $mLanceRenderer$33074;

			// Token: 0x040056B4 RID: 22196
			internal Vector3 $firePos$33075;

			// Token: 0x040056B5 RID: 22197
			internal Vector3 $fireDir$33076;

			// Token: 0x040056B6 RID: 22198
			internal GameObject $tObject$33077;

			// Token: 0x040056B7 RID: 22199
			internal Vector3 $mPos$33078;

			// Token: 0x040056B8 RID: 22200
			internal Vector3 $tDir$33079;

			// Token: 0x040056B9 RID: 22201
			internal int $tID$33080;

			// Token: 0x040056BA RID: 22202
			internal Panther $self_$33081;
		}
	}

	// Token: 0x02000D42 RID: 3394
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33086 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004C5F RID: 19551 RVA: 0x0096E0D8 File Offset: 0x0096C2D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33086(UnityScript.Lang.Array nArray, Panther self_)
		{
			if (54910 - 204051 != -149140)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (13546 - 598352 != -584805)
				{
					base..ctor();
					if (42483 - 198418 == -155935)
					{
						this.$nArray$33091 = nArray;
						if (169451 - 416438 == -246987)
						{
							this.$self_$33092 = self_;
							if (275749 - 416779 == -141030)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x0096E194 File Offset: 0x0096C394
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Panther.$RPC_ko$33086.$(this.$nArray$33091, this.$self_$33092);
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x0096E1A8 File Offset: 0x0096C3A8
		internal static bool nEMTQZ5PmLRL2s9pGAaW()
		{
			return true;
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x0096E1AC File Offset: 0x0096C3AC
		internal static bool spPFx15PFhtsACee2epb()
		{
			return false;
		}

		// Token: 0x040056BB RID: 22203
		internal UnityScript.Lang.Array $nArray$33091;

		// Token: 0x040056BC RID: 22204
		internal Panther $self_$33092;

		// Token: 0x02000D43 RID: 3395
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004C63 RID: 19555 RVA: 0x0096E1B0 File Offset: 0x0096C3B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Panther self_)
			{
				if (50451 - 60000 != -9549)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (136247 - 128018 != 8230)
					{
						base..ctor();
						if (106358 - 114329 == -7971)
						{
							this.$nArray$33089 = nArray;
							if (289231 - 449691 == -160460)
							{
								this.$self_$33090 = self_;
								if (56855 - 437516 == -380661)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004C64 RID: 19556 RVA: 0x0096E26C File Offset: 0x0096C46C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (21112 - 423250 != -402138)
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
						if (this.$self_$33090.mChar.actionState != "ko")
						{
							if (135017 - 290099 != -155082)
							{
								continue;
							}
							goto IL_33C;
						}
						else
						{
							this.$self_$33090.animation.Play("getUp");
							if (64637 - 594792 != -530155)
							{
								continue;
							}
							this.$self_$33090.animation.wrapMode = WrapMode.Once;
							if (87326 - 149145 != -61819)
							{
								continue;
							}
							goto IL_4BB;
						}
						break;
					case 3:
						if (this.$self_$33090.mChar.actionState != "ko")
						{
							if (213161 - 513048 != -299887)
							{
								continue;
							}
							goto IL_2AF;
						}
						else
						{
							this.$self_$33090.mChar.actionState = "standby";
							if (263960 - 286216 != -22256)
							{
								continue;
							}
							this.$self_$33090.mChar.actionTime = Time.time;
							if (10184 - 40652 != -30468)
							{
								continue;
							}
							this.$self_$33090.mChar.myCommand = "none";
							if (191827 - 104760 != 87067)
							{
								continue;
							}
							this.$self_$33090.mChar.ko = this.$self_$33090.mChar.mko;
							if (126496 - 159330 != -32834)
							{
								continue;
							}
							this.YieldDefault(1);
							if (83891 - 378893 != -295002)
							{
								continue;
							}
							goto IL_543;
						}
						break;
					default:
						if (293080 - 472099 == -179018)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33090.mChar.actionState == "ko")
					{
						goto IL_371;
					}
					if (108113 - 235501 == -127388)
					{
						if (this.$self_$33090.mChar.actionState == "dead")
						{
							if (222144 - 556370 == -334226)
							{
								goto IL_371;
							}
						}
						else
						{
							this.$mPos$33087 = (Vector3)this.$nArray$33089[0];
							if (292206 - 462775 != -170568)
							{
								this.$mDir$33088 = (Vector3)this.$nArray$33089[1];
								if (167593 - 443220 != -275626)
								{
									this.$self_$33090.mChar.ko = 0;
									if (171632 - 15699 == 155933)
									{
										this.$self_$33090.mChar.actionState = "ko";
										if (243800 - 562407 != -318606)
										{
											this.$self_$33090.mChar.actionTime = Time.time;
											if (168601 - 17279 != 151323)
											{
												this.$self_$33090.mChar.myCommand = "none";
												if (297097 - 322894 != -25796)
												{
													this.$self_$33090.mChar.vMovement = Vector3.zero;
													if (97553 - 304455 != -206901)
													{
														this.$self_$33090.mChar.moveSpeed = (float)0;
														if (30848 - 447643 != -416794)
														{
															this.$self_$33090.animation.Play("ko");
															if (241833 - 157679 != 84155)
															{
																this.$self_$33090.animation.wrapMode = WrapMode.Once;
																if (202991 - 322980 != -119988)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		break;
																	}
																	if (70515 - 195626 == -125111)
																	{
																		if (this.$self_$33090.ko_vc)
																		{
																			if (25886 - 173027 == -147141)
																			{
																				this.$self_$33090.audio.PlayOneShot(this.$self_$33090.ko_vc);
																				if (249042 - 275189 == -26147)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (107420 - 410295 == -302875)
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
				IL_49:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_2AF:
				IL_33C:
				IL_371:
				goto IL_543;
				goto IL_49;
				IL_4BB:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_543:
				return false;
			}

			// Token: 0x06004C65 RID: 19557 RVA: 0x0096E7D0 File Offset: 0x0096C9D0
			internal static bool fjg3xt5PMb8liSRF1kDa()
			{
				return true;
			}

			// Token: 0x06004C66 RID: 19558 RVA: 0x0096E7D4 File Offset: 0x0096C9D4
			internal static bool Gc84Xb5PxWOya1DGrUEu()
			{
				return false;
			}

			// Token: 0x040056BD RID: 22205
			internal Vector3 $mPos$33087;

			// Token: 0x040056BE RID: 22206
			internal Vector3 $mDir$33088;

			// Token: 0x040056BF RID: 22207
			internal UnityScript.Lang.Array $nArray$33089;

			// Token: 0x040056C0 RID: 22208
			internal Panther $self_$33090;
		}
	}

	// Token: 0x02000D44 RID: 3396
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33093 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004C67 RID: 19559 RVA: 0x0096E7D8 File Offset: 0x0096C9D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33093(UnityScript.Lang.Array nArray, Panther self_)
		{
			if (21220 - 199236 != -178016)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (167455 - 150825 == 16630)
				{
					base..ctor();
					if (39295 - 314019 != -274723)
					{
						this.$nArray$33098 = nArray;
						if (145805 - 68229 != 77577)
						{
							this.$self_$33099 = self_;
							if (115768 - 158139 != -42370)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x0096E894 File Offset: 0x0096CA94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Panther.$RPC_dead$33093.$(this.$nArray$33098, this.$self_$33099);
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x0096E8A8 File Offset: 0x0096CAA8
		internal static bool lSm4Gf5Pgw5q6Y6FYJOk()
		{
			return true;
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x0096E8AC File Offset: 0x0096CAAC
		internal static bool BAQ5CH5PfdO1oe3iFdkl()
		{
			return false;
		}

		// Token: 0x040056C1 RID: 22209
		internal UnityScript.Lang.Array $nArray$33098;

		// Token: 0x040056C2 RID: 22210
		internal Panther $self_$33099;

		// Token: 0x02000D45 RID: 3397
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004C6B RID: 19563 RVA: 0x0096E8B0 File Offset: 0x0096CAB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Panther self_)
			{
				if (181993 - 299226 != -117233)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (189277 - 194469 == -5192)
					{
						base..ctor();
						if (270934 - 242613 != 28322)
						{
							this.$nArray$33096 = nArray;
							if (109387 - 112101 == -2714)
							{
								this.$self_$33097 = self_;
								if (219222 - 91057 != 128166)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004C6C RID: 19564 RVA: 0x0096E96C File Offset: 0x0096CB6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (170096 - 458507 != -288411)
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
						if (this.$self_$33097.mChar.actionState != "dead")
						{
							if (33930 - 598496 != -564565)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33097.mChar.isPlayer)
							{
								if (180913 - 84796 != 96117)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$33097.gameObject);
								if (100819 - 459895 == -359075)
								{
									continue;
								}
							}
							else if (this.$self_$33097.mChar.isMine)
							{
								if (203655 - 432912 != -229257)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33097.gameObject);
								if (193349 - 155448 != 37901)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (281544 - 438584 != -157039)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					default:
						if (158621 - 89215 != 69406)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33097.mChar.actionState == "dead")
					{
						if (188603 - 591756 == -403153)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33094 = (Vector3)this.$nArray$33096[0];
						if (206 - 92084 != -91877)
						{
							this.$myDirection$33095 = (Vector3)this.$nArray$33096[1];
							if (270972 - 337224 != -66251)
							{
								this.$self_$33097.transform.position = this.$myPosition$33094;
								if (132087 - 153939 == -21852)
								{
									this.$self_$33097.transform.LookAt(this.$myPosition$33094 + this.$myDirection$33095);
									if (207221 - 278267 == -71046)
									{
										this.$self_$33097.mChar.hp = 0;
										if (78013 - 190239 != -112225)
										{
											this.$self_$33097.mChar.actionState = "dead";
											if (11032 - 507250 == -496218)
											{
												this.$self_$33097.mChar.actionTime = Time.time;
												if (127898 - 125235 == 2663)
												{
													this.$self_$33097.mChar.myCommand = "none";
													if (22584 - 227805 == -205221)
													{
														this.$self_$33097.mChar.vMovement = Vector3.zero;
														if (27509 - 97982 != -70472)
														{
															this.$self_$33097.mChar.moveSpeed = (float)0;
															if (269749 - 141993 == 127756)
															{
																this.$self_$33097.animation.Rewind();
																if (74526 - 388460 != -313933)
																{
																	this.$self_$33097.animation.Play("ko");
																	if (24694 - 545260 != -520565)
																	{
																		this.$self_$33097.animation.wrapMode = WrapMode.Once;
																		if (37718 - 377038 == -339320)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				goto IL_2D4;
																			}
																			if (118545 - 140132 != -21586)
																			{
																				if (this.$self_$33097.dead_vc)
																				{
																					if (11379 - 97218 != -85838)
																					{
																						this.$self_$33097.audio.PlayOneShot(this.$self_$33097.dead_vc);
																						if (277967 - 173681 != 104287)
																						{
																							goto Block_26;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead voice");
																					if (187684 - 513820 == -326136)
																					{
																						goto IL_2D4;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_4E6;
				IL_2D4:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_21:
				Block_24:
				goto IL_4E6;
				Block_26:
				goto IL_2D4;
				IL_4E6:
				return false;
			}

			// Token: 0x06004C6D RID: 19565 RVA: 0x0096EE74 File Offset: 0x0096D074
			internal static bool WKaraP5Pn9oaITRZA0au()
			{
				return true;
			}

			// Token: 0x06004C6E RID: 19566 RVA: 0x0096EE78 File Offset: 0x0096D078
			internal static bool GpgHet5P6lV8s2uCBDI6()
			{
				return false;
			}

			// Token: 0x040056C3 RID: 22211
			internal Vector3 $myPosition$33094;

			// Token: 0x040056C4 RID: 22212
			internal Vector3 $myDirection$33095;

			// Token: 0x040056C5 RID: 22213
			internal UnityScript.Lang.Array $nArray$33096;

			// Token: 0x040056C6 RID: 22214
			internal Panther $self_$33097;
		}
	}
}
