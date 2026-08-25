using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D2C RID: 3372
[Serializable]
public class PandaCult : MonoBehaviour
{
	// Token: 0x06004BD9 RID: 19417 RVA: 0x00960014 File Offset: 0x0095E214
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PandaCult()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004BDA RID: 19418 RVA: 0x00960024 File Offset: 0x0095E224
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (244835 - 439219 != -194384)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (254099 - 226651 != 27449)
			{
				this.mChar.actionState = "standby";
				if (120591 - 57508 == 63083)
				{
					this.mChar.actionTime = Time.time;
					if (296815 - 390482 == -93667)
					{
						this.mChar.myCommand = "none";
						if (226943 - 299120 == -72177)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004BDB RID: 19419 RVA: 0x00960110 File Offset: 0x0095E310
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (77767 - 141091 != -63323)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (121124 - 453303 != -332179)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (45142 - 378313 == -333170)
				{
					continue;
				}
			}
			if (Game.mGameCode != 934)
			{
				break;
			}
			if (108701 - 191206 != -82504)
			{
				if (this.mChar.ActorNr == 0)
				{
					break;
				}
				if (234244 - 326317 == -92073)
				{
					this.mChar.StartCoroutine_Auto(this.mChar.addStatus("darkRitual", 1, 999, 0, this.mChar.ActorNr));
					if (170438 - 179681 != -9242)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004BDC RID: 19420 RVA: 0x00960230 File Offset: 0x0095E430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (146114 - 1806 != 144308)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (253356 - 524602 == -271245)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (293039 - 427021 != -133982)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_1AE;
					}
					if (66200 - 449229 != -383029)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (44039 - 566765 != -522726)
				{
					continue;
				}
			}
			IL_1AE:
			if (this.mChar.hp <= 0)
			{
				if (142874 - 581585 == -438710)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (33959 - 149061 != -115102)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (259306 - 51159 != 208147)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (273211 - 14402 != 258809)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (89100 - 311616 != -222516)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (28166 - 53220 != -25054)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (25640 - 176557 != -150916)
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
			if (158360 - 361888 == -203528)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (203811 - 131351 != 72461)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (262713 - 51080 == 211633)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (173140 - 18109 != 155032)
						{
							if (this.mChar.isMine)
							{
								if (122610 - 5244 != 117367)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (56297 - 217849 == -161552)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (268899 - 317332 == -48433)
										{
											this.mChar.KoEvent();
											if (195855 - 555228 != -359372)
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
								if (88224 - 542002 != -453777)
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

	// Token: 0x06004BDD RID: 19421 RVA: 0x00960628 File Offset: 0x0095E828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (97077 - 333979 != -236901)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (75364 - 384570 == -309206)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (204376 - 346077 == -141701)
				{
					if (299848 - 235658 == 64190)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (241963 - 464359 != -222396)
							{
								continue;
							}
							v = 1;
							if (295060 - 583924 != -288864)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (10282 - 422594 == -412311)
							{
								continue;
							}
							v = -1;
							if (150274 - 432384 == -282109)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_drunkenFist")
						{
							if (228683 - 382092 == -153408)
							{
								continue;
							}
							v = 11;
							if (108326 - 439034 != -330708)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_qiStrike1")
						{
							if (195342 - 287283 == -91940)
							{
								continue;
							}
							v = 21;
							if (21205 - 143285 == -122079)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_qiStrike2")
						{
							if (132152 - 378439 != -246287)
							{
								continue;
							}
							v = 22;
							if (96917 - 26275 != 70642)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_qiStrike_hit")
						{
							if (125382 - 390630 == -265247)
							{
								continue;
							}
							v = -21;
							if (164873 - 51028 == 113846)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_roll")
						{
							if (239706 - 472853 != -233147)
							{
								continue;
							}
							v = 31;
							if (59892 - 362906 != -303014)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (126088 - 310942 == -184853)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (178355 - 127229 == 51126)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (126033 - 225340 == -99307)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (103476 - 206016 != -102539)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (180832 - 384812 != -203979)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (181142 - 288716 == -107574)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (94269 - 192925 == -98656)
											{
												Hashtable hashtable = new Hashtable();
												if (87707 - 353689 != -265981)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (116812 - 352883 != -236070)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (42638 - 127785 != -85146)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (289873 - 464172 != -174298)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (73300 - 49673 == 23627)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (23589 - 184348 == -160759)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (206900 - 406326 == -199426)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (168045 - 184565 == -16520)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (173080 - 106075 != 67006)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (100008 - 202925 == -102917)
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

	// Token: 0x06004BDE RID: 19422 RVA: 0x00960C24 File Offset: 0x0095EE24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (191246 - 308353 != -117107)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (89082 - 293904 != -204821)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (200478 - 462525 != -262046)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (282647 - 458091 == -175444)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (68225 - 153318 == -85093)
						{
							int num2 = num;
							if (192553 - 75104 != 117450)
							{
								if (num2 == 1)
								{
									if (22661 - 129352 != -106690)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (131150 - 485423 != -354272)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, tID));
											if (115983 - 223390 != -107406)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -1)
								{
									if (110919 - 575951 != -465031)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (90014 - 91469 != -1454)
										{
											this.RPC_nAttack_hit(vector, vector2, tID);
											if (5064 - 127473 != -122408)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (290061 - 227214 != 62848)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (90553 - 369735 != -279181)
										{
											this.StartCoroutine_Auto(this.RPC_drunkenFist(vector, vector2, tID));
											if (163561 - 545547 != -381985)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 21)
								{
									if (283990 - 555922 != -271931)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (248770 - 343728 != -94957)
										{
											this.StartCoroutine_Auto(this.RPC_qiStrike1(vector, vector2, tID));
											if (255280 - 171536 == 83744)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 22)
								{
									if (282565 - 374550 == -91985)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (235172 - 454789 != -219616)
										{
											this.StartCoroutine_Auto(this.RPC_qiStrike2(vector, vector2, tID));
											if (104836 - 525295 != -420458)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -21)
								{
									if (221381 - 176472 != 44910)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (55621 - 510683 == -455062)
										{
											this.RPC_qiStrike_hit(vector, vector2, tID);
											if (276105 - 268170 == 7935)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 31)
								{
									if (44838 - 107516 == -62678)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (152447 - 445141 != -292693)
										{
											this.StartCoroutine_Auto(this.RPC_roll(vector, vector2, tID));
											if (238920 - 593303 != -354382)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (156174 - 169036 != -12861)
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

	// Token: 0x06004BDF RID: 19423 RVA: 0x0096111C File Offset: 0x0095F31C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (175449 - 432240 != -256791)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (273 - 107912 != -107638)
			{
				float runSpeed = this.mChar.runSpeed;
				if (86782 - 353920 == -267138)
				{
					Vector3 a = default(Vector3);
					if (121328 - 159220 == -37892)
					{
						Vector3 vector = Vector3.zero;
						if (126835 - 186892 == -60057)
						{
							float num2 = (float)0;
							if (33550 - 407234 != -373683)
							{
								if (this.mChar.isMine)
								{
									if (194782 - 418352 == -223569)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (169902 - 300378 == -130475)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (51625 - 231634 != -180009)
										{
											continue;
										}
										a.y = (float)0;
										if (252497 - 353402 != -100905)
										{
											continue;
										}
										a = a.normalized;
										if (179692 - 583211 == -403518)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (252149 - 594635 == -342485)
										{
											continue;
										}
										vector = vector.normalized;
										if (154164 - 8863 != 145301)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (281451 - 66481 == 214971)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (159932 - 92842 == 67091)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (277516 - 394582 != -117066)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (294287 - 347007 == -52719)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (241698 - 122013 != 119685)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (274490 - 514794 != -240304)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (58731 - 6406 != 52325)
														{
															continue;
														}
														this.animation.Play("run");
														if (60960 - 578022 != -517062)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (191828 - 416639 != -224810)
														{
															goto IL_E6;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (178044 - 446858 != -268814)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (244834 - 124712 == 120123)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (149162 - 473016 != -323854)
											{
												continue;
											}
											num = (float)0;
											if (246747 - 538647 == -291899)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (14041 - 410090 != -396049)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (23421 - 455653 != -432232)
										{
											continue;
										}
									}
									IL_E6:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (279593 - 60353 != 219240)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (247526 - 329671 != -82145)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (271387 - 569080 != -297693)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (32537 - 202332 == -169794)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (251161 - 494562 != -243401)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (7311 - 172009 == -164697)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (136928 - 356298 != -219370)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (117260 - 494266 != -377006)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (64261 - 107689 == -43427)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (214062 - 113436 != 100626)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (269490 - 14081 != 255409)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (260215 - 304867 == -44651)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (213751 - 35803 != 177948)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (109505 - 515700 == -406194)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (250113 - 17917 != 232196)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (76665 - 538023 != -461358)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (239570 - 494682 != -255112)
												{
													continue;
												}
												num = (float)0;
												if (58787 - 318309 == -259521)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (150150 - 525812 != -375662)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (57367 - 429798 == -372430)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (147093 - 556582 != -409489)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (140896 - 104559 == 36338)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (137072 - 503904 == -366831)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (168944 - 212734 == -43789)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (82945 - 308591 == -225645)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (5053 - 297719 != -292666)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (259010 - 393709 != -134699)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (144895 - 319620 != -174725)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (266893 - 446918 != -180025)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (48062 - 129489 != -81427)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (286939 - 465745 != -178806)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (234963 - 551159 == -316195)
											{
												continue;
											}
											num = (float)0;
											if (136534 - 432172 != -295638)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (201508 - 478330 == -276821)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (120178 - 254396 == -134217)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (93530 - 157963 == -64432)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (201417 - 235662 == -34244)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (193461 - 29880 != 163582)
								{
									this.mChar.moveSpeed = num;
									if (138659 - 229515 != -90855)
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

	// Token: 0x06004BE0 RID: 19424 RVA: 0x00961C80 File Offset: 0x0095FE80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (22073 - 228487 != -206413)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (220734 - 71785 == 148949)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (142379 - 86757 == 55622)
				{
					Vector3 vector = a - this.transform.position;
					if (136332 - 580816 != -444483)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (294843 - 142538 == 152305)
						{
							CharacterControl characterControl = null;
							if (129021 - 206584 != -77562)
							{
								int tID = 0;
								if (292752 - 224650 == 68102)
								{
									if (gameObject)
									{
										if (237257 - 425096 == -187838)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (288012 - 342797 == -54784)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (297822 - 77512 != 220310)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (103135 - 312521 != -209386)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (81449 - 33287 == 48163)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (144362 - 131618 == 12745)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("drunkenFist") == (float)0)
									{
										if (108055 - 383780 != -275725)
										{
											continue;
										}
										if (UnityEngine.Random.Range(0, 100) < 40)
										{
											if (138508 - 308816 != -170308)
											{
												continue;
											}
											this.StartCoroutine_Auto(this.RPC_drunkenFist(this.transform.position, vector, tID));
											if (264865 - 57884 != 206981)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (117001 - 386130 != -269129)
											{
												continue;
											}
											this.ActionEvent("RPC_drunkenFist", this.transform.position, vector, tID);
											if (246952 - 24517 != 222436)
											{
												break;
											}
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (158224 - 320973 != -162748)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, tID));
										if (139508 - 498926 != -359417)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (272116 - 598418 == -326302)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
												if (260785 - 342814 != -82028)
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

	// Token: 0x06004BE1 RID: 19425 RVA: 0x00962068 File Offset: 0x00960268
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (194612 - 470476 != -275864)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (197550 - 304404 == -106854)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (83572 - 269274 == -185702)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (260388 - 68116 == 192272)
					{
						Vector3 normalized = vector.normalized;
						if (251111 - 371277 != -120165)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (114821 - 580547 != -465725)
							{
								CharacterControl characterControl = null;
								if (203691 - 46896 != 156796)
								{
									int tID = 0;
									if (207094 - 348716 != -141621)
									{
										if (gameObject)
										{
											if (249619 - 393287 != -143668)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (168061 - 169134 == -1072)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (282033 - 123972 != 158061)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (125991 - 458175 == -332183)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (47608 - 213729 != -166121)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (108955 - 272692 == -163736)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (236546 - 206533 == 30013)
										{
											this.StartCoroutine_Auto(this.RPC_qiStrike1(this.transform.position, normalized, tID));
											if (127427 - 278742 == -151315)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (126113 - 529563 == -403450)
												{
													this.ActionEvent("RPC_qiStrike1", this.transform.position, normalized, tID);
													if (15109 - 323054 == -307945)
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

	// Token: 0x06004BE2 RID: 19426 RVA: 0x0096238C File Offset: 0x0096058C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004BE3 RID: 19427 RVA: 0x00962390 File Offset: 0x00960590
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PandaCult.$RPC_nAttack$32985(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004BE4 RID: 19428 RVA: 0x009623A0 File Offset: 0x009605A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int tID)
	{
		if (182528 - 23693 != 158836)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (204616 - 140546 != 64071)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (233139 - 415745 == -182606)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit Effect");
				if (159274 - 490367 != -331092)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004BE5 RID: 19429 RVA: 0x00962458 File Offset: 0x00960658
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_drunkenFist(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PandaCult.$RPC_drunkenFist$32998(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004BE6 RID: 19430 RVA: 0x00962468 File Offset: 0x00960668
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_qiStrike1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PandaCult.$RPC_qiStrike1$33016(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004BE7 RID: 19431 RVA: 0x00962478 File Offset: 0x00960678
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_qiStrike2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PandaCult.$RPC_qiStrike2$33026(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004BE8 RID: 19432 RVA: 0x00962488 File Offset: 0x00960688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_qiStrike_hit(Vector3 hitPos, Vector3 hitDir, int tID)
	{
		if (209942 - 96181 != 113762)
		{
		}
		for (;;)
		{
			if (this.qiStrike_hit)
			{
				if (180498 - 66666 != 113833)
				{
					UnityEngine.Object.Instantiate(this.qiStrike_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (250462 - 294905 != -44442)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find qiStrike_hit Effect");
				if (23936 - 45871 == -21935)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004BE9 RID: 19433 RVA: 0x00962540 File Offset: 0x00960740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_roll(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PandaCult.$RPC_roll$33038(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004BEA RID: 19434 RVA: 0x00962550 File Offset: 0x00960750
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new PandaCult.$RPC_ko$33045(nArray, this).GetEnumerator();
	}

	// Token: 0x06004BEB RID: 19435 RVA: 0x00962560 File Offset: 0x00960760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new PandaCult.$RPC_dead$33052(nArray, this).GetEnumerator();
	}

	// Token: 0x06004BEC RID: 19436 RVA: 0x00962570 File Offset: 0x00960770
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004BED RID: 19437 RVA: 0x00962574 File Offset: 0x00960774
	internal static bool dYOoue57PNVvVtR6BrTy()
	{
		return true;
	}

	// Token: 0x06004BEE RID: 19438 RVA: 0x00962578 File Offset: 0x00960778
	internal static bool SEPgDv570G1mgnSvGZfT()
	{
		return false;
	}

	// Token: 0x0400563F RID: 22079
	public CharacterControl mChar;

	// Token: 0x04005640 RID: 22080
	public GameObject nAttack;

	// Token: 0x04005641 RID: 22081
	public GameObject nAttack_hit;

	// Token: 0x04005642 RID: 22082
	public GameObject drunkenFist;

	// Token: 0x04005643 RID: 22083
	public GameObject qiStrike_ring;

	// Token: 0x04005644 RID: 22084
	public GameObject qiStrike;

	// Token: 0x04005645 RID: 22085
	public AudioClip qiStrikeFx;

	// Token: 0x04005646 RID: 22086
	public GameObject qiStrike_hit;

	// Token: 0x04005647 RID: 22087
	public AudioClip rollFx;

	// Token: 0x02000D2D RID: 3373
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32985 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004BEF RID: 19439 RVA: 0x0096257C File Offset: 0x0096077C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32985(Vector3 mPos, Vector3 tDir, PandaCult self_)
		{
			if (18984 - 443675 != -424691)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (171726 - 62701 != 109026)
				{
					base..ctor();
					if (256232 - 59487 == 196745)
					{
						this.$mPos$32995 = mPos;
						if (676 - 557564 != -556887)
						{
							this.$tDir$32996 = tDir;
							if (221780 - 80781 == 140999)
							{
								this.$self_$32997 = self_;
								if (228916 - 286090 == -57174)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x00962658 File Offset: 0x00960858
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PandaCult.$RPC_nAttack$32985.$(this.$mPos$32995, this.$tDir$32996, this.$self_$32997);
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x00962674 File Offset: 0x00960874
		internal static bool i2kSFj57bySTHpu3hbUh()
		{
			return true;
		}

		// Token: 0x06004BF2 RID: 19442 RVA: 0x00962678 File Offset: 0x00960878
		internal static bool SZuKco57uXjltXXUMa4e()
		{
			return false;
		}

		// Token: 0x04005648 RID: 22088
		internal Vector3 $mPos$32995;

		// Token: 0x04005649 RID: 22089
		internal Vector3 $tDir$32996;

		// Token: 0x0400564A RID: 22090
		internal PandaCult $self_$32997;

		// Token: 0x02000D2E RID: 3374
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004BF3 RID: 19443 RVA: 0x0096267C File Offset: 0x0096087C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PandaCult self_)
			{
				if (185959 - 515233 != -329274)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (212719 - 203130 == 9589)
					{
						base..ctor();
						if (7581 - 360305 != -352723)
						{
							this.$mPos$32992 = mPos;
							if (96873 - 348922 == -252049)
							{
								this.$tDir$32993 = tDir;
								if (267881 - 536611 == -268730)
								{
									this.$self_$32994 = self_;
									if (242201 - 352379 == -110178)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004BF4 RID: 19444 RVA: 0x00962758 File Offset: 0x00960958
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (154511 - 452602 != -298090)
				{
				}
				for (;;)
				{
					IL_61E:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B4F;
					case 2:
						if (this.$self_$32994.mChar.actionState != "attack")
						{
							goto IL_A9A;
						}
						if (120647 - 357356 == -236708)
						{
							continue;
						}
						if (this.$self_$32994.mChar.myCommand != "nAttack")
						{
							if (256494 - 82275 != 174219)
							{
								continue;
							}
							goto IL_A9A;
						}
						else
						{
							this.$self_$32994.mChar.moveSpeed = (float)3;
							if (32124 - 451966 != -419841)
							{
								goto Block_64;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32994.mChar.actionState != "attack")
						{
							goto IL_846;
						}
						if (57972 - 240466 == -182493)
						{
							continue;
						}
						if (this.$self_$32994.mChar.myCommand != "nAttack")
						{
							if (49173 - 511157 != -461983)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$32994.mChar.moveSpeed = (float)0;
							if (274288 - 271450 == 2839)
							{
								continue;
							}
							this.$hitLayer$32986 = 130816 - (1 << this.$self_$32994.gameObject.layer);
							if (217907 - 99684 == 118224)
							{
								continue;
							}
							this.$hitList$32987 = null;
							if (296789 - 491754 != -194965)
							{
								continue;
							}
							this.$hitPos$32988 = default(Vector3);
							if (86561 - 379101 != -292540)
							{
								continue;
							}
							this.$i$32989 = 0;
							if (25452 - 414136 != -388684)
							{
								continue;
							}
							goto IL_396;
						}
						break;
					case 4:
						if (this.$self_$32994.mChar.actionState != "attack")
						{
							goto IL_291;
						}
						if (233461 - 594414 == -360952)
						{
							continue;
						}
						if (this.$self_$32994.mChar.myCommand != "nAttack")
						{
							if (261659 - 512116 != -250457)
							{
								continue;
							}
							goto IL_291;
						}
						else
						{
							this.$i$32989++;
							if (92094 - 495668 != -403574)
							{
								continue;
							}
							goto IL_396;
						}
						break;
					default:
						if (206729 - 582202 != -375473)
						{
							continue;
						}
						break;
					}
					this.$self_$32994.mChar.actionState = "attack";
					if (33056 - 544539 != -511483)
					{
						continue;
					}
					this.$self_$32994.mChar.actionTime = Time.time;
					if (62292 - 308439 == -246146)
					{
						continue;
					}
					this.$self_$32994.mChar.myCommand = "nAttack";
					if (1364 - 274791 != -273427)
					{
						continue;
					}
					this.$self_$32994.mChar.addTimeOut("nAttack", (float)2);
					if (127324 - 144160 == -16835)
					{
						continue;
					}
					this.$self_$32994.transform.position = this.$mPos$32992;
					if (30477 - 162442 != -131965)
					{
						continue;
					}
					this.$self_$32994.transform.LookAt(this.$mPos$32992 + global::Math.vFlat(this.$tDir$32993));
					if (296198 - 544588 == -248389)
					{
						continue;
					}
					this.$self_$32994.animation.CrossFade("nAttack", 0.2f);
					if (182783 - 249431 != -66648)
					{
						continue;
					}
					this.$self_$32994.animation.wrapMode = WrapMode.Once;
					if (189995 - 573676 == -383680)
					{
						continue;
					}
					this.$self_$32994.mChar.vMovement = this.$self_$32994.transform.forward;
					if (203702 - 15837 != 187865)
					{
						continue;
					}
					this.$self_$32994.mChar.moveSpeed = (float)0;
					if (280873 - 523401 != -242528)
					{
						continue;
					}
					if (this.$self_$32994.nAttack)
					{
						if (273077 - 247283 != 25794)
						{
							continue;
						}
						this.$self_$32994.mChar.createEffect(this.$self_$32994.nAttack, this.$self_$32994.transform.position, this.$self_$32994.transform.rotation);
						if (89446 - 346073 != -256626)
						{
							goto Block_43;
						}
						continue;
					}
					else
					{
						Debug.LogError("Cannot find nAttack Effect");
						if (115080 - 416774 != -301694)
						{
							continue;
						}
						goto IL_877;
					}
					IL_396:
					if (this.$i$32989 >= 2)
					{
						if (125009 - 355668 != -230658)
						{
							if (this.$self_$32994.mChar.actionState == "attack")
							{
								if (99559 - 211506 != -111947)
								{
									continue;
								}
								if (this.$self_$32994.mChar.myCommand == "nAttack")
								{
									if (125692 - 351745 != -226053)
									{
										continue;
									}
									this.$self_$32994.mChar.moveSpeed = (float)0;
									if (174813 - 563379 == -388565)
									{
										continue;
									}
									this.$self_$32994.mChar.actionState = "standby";
									if (239153 - 144850 != 94303)
									{
										continue;
									}
									this.$self_$32994.mChar.actionTime = Time.time;
									if (208708 - 525481 != -316773)
									{
										continue;
									}
									this.$self_$32994.mChar.myCommand = "none";
									if (86051 - 117468 != -31417)
									{
										continue;
									}
									if (!this.$self_$32994.mChar.isMine)
									{
										if (76456 - 287774 == -211317)
										{
											continue;
										}
										this.$self_$32994.mChar.nPosition = this.$self_$32994.transform.position;
										if (46190 - 351626 != -305436)
										{
											continue;
										}
										this.$self_$32994.mChar.oPosition = this.$self_$32994.transform.position;
										if (268778 - 339092 != -70314)
										{
											continue;
										}
										this.$self_$32994.mChar.nDirection = this.$self_$32994.transform.forward;
										if (76830 - 285339 == -208508)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (181818 - 384504 == -202686)
							{
								break;
							}
						}
					}
					else
					{
						if (!this.$self_$32994.mChar.isMine)
						{
							goto IL_8FF;
						}
						if (266005 - 128766 == 137239)
						{
							this.$hitList$32987 = Damage.FindRecTarget(this.$self_$32994.transform.position + (float)(this.$i$32989 * 2) * this.$self_$32994.transform.forward - this.$self_$32994.transform.forward, this.$self_$32994.transform.forward, (float)2, (float)2, (float)2, (float)3 * this.$self_$32994.mChar.rangeMod, this.$hitLayer$32986);
							if (1239 - 35451 != -34211)
							{
								this.$$iterator$10801$32991 = UnityRuntimeServices.GetEnumerator(this.$hitList$32987);
								if (51631 - 209790 == -158159)
								{
									while (this.$$iterator$10801$32991.MoveNext())
									{
										object obj2;
										object obj = obj2 = this.$$iterator$10801$32991.Current;
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										this.$hitObject$32990 = (GameObject)obj2;
										if (146959 - 96427 == 50533)
										{
											goto IL_61E;
										}
										if (this.$self_$32994.mChar.hit(1, this.$hitObject$32990, (int)(0.5f * (float)this.$self_$32994.mChar.atk + (float)this.$self_$32994.mChar.talAdjust(30)), 3, 0, this.$self_$32994.transform.forward) != 0)
										{
											if (121535 - 87914 == 33622)
											{
												goto IL_61E;
											}
											this.$hitPos$32988 = this.$hitObject$32990.collider.ClosestPointOnBounds(this.$self_$32994.transform.position + 0.5f * Vector3.up);
											if (101167 - 373916 == -272748)
											{
												goto IL_61E;
											}
											UnityRuntimeServices.Update(this.$$iterator$10801$32991, this.$hitObject$32990);
											if (216037 - 178762 != 37275)
											{
												goto IL_61E;
											}
											this.$self_$32994.RPC_nAttack_hit(this.$hitPos$32988, this.$self_$32994.transform.forward, 0);
											if (91198 - 84492 != 6706)
											{
												goto IL_61E;
											}
											if (PhotonClient.IsInitialized())
											{
												if (110593 - 318406 == -207812)
												{
													goto IL_61E;
												}
												this.$self_$32994.ActionEvent("RPC_nAttack_hit", this.$hitPos$32988, this.$self_$32994.transform.forward, 0);
												if (14930 - 412345 != -397415)
												{
													goto IL_61E;
												}
											}
											this.$self_$32994.mChar.sp = this.$self_$32994.mChar.sp + 1;
											if (111842 - 447413 != -335571)
											{
												goto IL_61E;
											}
										}
									}
									if (80932 - 360514 != -279581)
									{
										goto Block_66;
									}
								}
							}
						}
					}
				}
				IL_291:
				Block_23:
				goto IL_846;
				Block_43:
				goto IL_877;
				IL_846:
				goto IL_B4F;
				IL_877:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_8FF:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_A9A:
				goto IL_B4F;
				Block_64:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_66:
				goto IL_8FF;
				IL_B4F:
				return false;
			}

			// Token: 0x06004BF5 RID: 19445 RVA: 0x009632C8 File Offset: 0x009614C8
			internal static bool xwi2Pg57IqumA9nfBjDH()
			{
				return true;
			}

			// Token: 0x06004BF6 RID: 19446 RVA: 0x009632CC File Offset: 0x009614CC
			internal static bool JM6Nkm57B0BeFqi1PQRD()
			{
				return false;
			}

			// Token: 0x0400564B RID: 22091
			internal int $hitLayer$32986;

			// Token: 0x0400564C RID: 22092
			internal UnityScript.Lang.Array $hitList$32987;

			// Token: 0x0400564D RID: 22093
			internal Vector3 $hitPos$32988;

			// Token: 0x0400564E RID: 22094
			internal int $i$32989;

			// Token: 0x0400564F RID: 22095
			internal GameObject $hitObject$32990;

			// Token: 0x04005650 RID: 22096
			internal IEnumerator $$iterator$10801$32991;

			// Token: 0x04005651 RID: 22097
			internal Vector3 $mPos$32992;

			// Token: 0x04005652 RID: 22098
			internal Vector3 $tDir$32993;

			// Token: 0x04005653 RID: 22099
			internal PandaCult $self_$32994;
		}
	}

	// Token: 0x02000D2F RID: 3375
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_drunkenFist$32998 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004BF7 RID: 19447 RVA: 0x009632D0 File Offset: 0x009614D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_drunkenFist$32998(Vector3 mPos, Vector3 tDir, PandaCult self_)
		{
			if (230135 - 159192 != 70944)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (248093 - 56685 == 191408)
				{
					base..ctor();
					if (122816 - 68620 != 54197)
					{
						this.$mPos$33013 = mPos;
						if (14269 - 27719 != -13449)
						{
							this.$tDir$33014 = tDir;
							if (139161 - 46342 != 92820)
							{
								this.$self_$33015 = self_;
								if (99230 - 81985 == 17245)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x009633AC File Offset: 0x009615AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PandaCult.$RPC_drunkenFist$32998.$(this.$mPos$33013, this.$tDir$33014, this.$self_$33015);
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x009633C8 File Offset: 0x009615C8
		internal static bool gA1tQB57ecIpWtdQVEHG()
		{
			return true;
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x009633CC File Offset: 0x009615CC
		internal static bool ajA27Z57r71L9BPkLi0E()
		{
			return false;
		}

		// Token: 0x04005654 RID: 22100
		internal Vector3 $mPos$33013;

		// Token: 0x04005655 RID: 22101
		internal Vector3 $tDir$33014;

		// Token: 0x04005656 RID: 22102
		internal PandaCult $self_$33015;

		// Token: 0x02000D30 RID: 3376
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004BFB RID: 19451 RVA: 0x009633D0 File Offset: 0x009615D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PandaCult self_)
			{
				if (223472 - 440491 != -217018)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (56063 - 7260 != 48804)
					{
						base..ctor();
						if (30685 - 334830 != -304144)
						{
							this.$mPos$33010 = mPos;
							if (269727 - 318474 != -48746)
							{
								this.$tDir$33011 = tDir;
								if (76959 - 562610 == -485651)
								{
									this.$self_$33012 = self_;
									if (285023 - 495749 != -210725)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004BFC RID: 19452 RVA: 0x009634AC File Offset: 0x009616AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (144253 - 386253 != -241999)
				{
				}
				for (;;)
				{
					IL_9D:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1BCD;
					case 2:
						if (this.$self_$33012.mChar.actionState != "attack")
						{
							goto IL_15B6;
						}
						if (267055 - 447701 == -180645)
						{
							continue;
						}
						if (this.$self_$33012.mChar.myCommand != "drunkenFist")
						{
							if (139815 - 328708 != -188893)
							{
								continue;
							}
							goto IL_15B6;
						}
						else
						{
							if (this.$self_$33012.drunkenFist)
							{
								if (91388 - 151697 == -60308)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$33012.drunkenFist, this.$self_$33012.transform.position + this.$self_$33012.transform.TransformDirection((float)0, 0.5f, 0.5f), this.$self_$33012.transform.rotation);
								if (146447 - 489194 == -342746)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find drunkenFist Effect");
								if (155080 - 166991 == -11910)
								{
									continue;
								}
							}
							this.$hitLayer$32999 = 130816 - (1 << this.$self_$33012.gameObject.layer);
							if (297702 - 498392 == -200689)
							{
								continue;
							}
							this.$hitList$33000 = null;
							if (269066 - 173818 == 95249)
							{
								continue;
							}
							this.$hitChar$33001 = null;
							if (291230 - 486218 != -194988)
							{
								continue;
							}
							if (!this.$self_$33012.mChar.isMine)
							{
								goto IL_B19;
							}
							if (97626 - 321187 != -223561)
							{
								continue;
							}
							this.$hitList$33000 = Damage.FindRecTarget(this.$self_$33012.transform.position, this.$self_$33012.transform.forward, (float)1 * this.$self_$33012.mChar.rangeMod, (float)1 * this.$self_$33012.mChar.rangeMod, (float)1 * this.$self_$33012.mChar.rangeMod, (float)2 * this.$self_$33012.mChar.rangeMod, this.$hitLayer$32999);
							if (221311 - 360767 != -139456)
							{
								continue;
							}
							this.$$iterator$10802$33003 = UnityRuntimeServices.GetEnumerator(this.$hitList$33000);
							if (142288 - 51420 == 90869)
							{
								continue;
							}
							while (this.$$iterator$10802$33003.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10802$33003.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33002 = (GameObject)obj2;
								if (128492 - 186761 != -58269)
								{
									goto IL_9D;
								}
								if (this.$self_$33012.mChar.hit(11, this.$hitObject$33002, (int)(0.4f * (float)this.$self_$33012.mChar.atk + (float)this.$self_$33012.mChar.talAdjust(9)), 1, 0, 0.3f * this.$self_$33012.transform.forward) != 0)
								{
									if (221807 - 594274 != -372467)
									{
										goto IL_9D;
									}
									this.$self_$33012.RPC_nAttack_hit(this.$hitObject$33002.transform.position + 1.5f * Vector3.up, this.$self_$33012.transform.forward, 0);
									if (105482 - 492441 != -386959)
									{
										goto IL_9D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10802$33003, this.$hitObject$33002);
									if (20379 - 194875 == -174495)
									{
										goto IL_9D;
									}
									if (PhotonClient.IsInitialized())
									{
										if (286803 - 586833 == -300029)
										{
											goto IL_9D;
										}
										this.$self_$33012.ActionEvent("RPC_nAttack_hit", this.$hitObject$33002.transform.position + 1.5f * Vector3.up, this.$self_$33012.transform.forward, 0);
										if (86525 - 200830 != -114305)
										{
											goto IL_9D;
										}
										UnityRuntimeServices.Update(this.$$iterator$10802$33003, this.$hitObject$33002);
										if (248577 - 118090 != 130487)
										{
											goto IL_9D;
										}
									}
									this.$self_$33012.mChar.sp = this.$self_$33012.mChar.sp + 1;
									if (264243 - 465785 != -201542)
									{
										goto IL_9D;
									}
									this.$hitChar$33001 = (CharacterControl)this.$hitObject$33002.GetComponent(typeof(CharacterControl));
									if (17098 - 19167 != -2069)
									{
										goto IL_9D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10802$33003, this.$hitObject$33002);
									if (235838 - 297137 == -61298)
									{
										goto IL_9D;
									}
									if (this.$hitChar$33001)
									{
										if (163227 - 446805 == -283577)
										{
											goto IL_9D;
										}
										if (!this.$hitChar$33001.hasStatus("drunk"))
										{
											if (122858 - 412333 != -289475)
											{
												goto IL_9D;
											}
											this.$hitChar$33001.RPC_AddStatus("drunk", 1, Damage.getDebuff((float)6, this.$self_$33012.mChar.cha, this.$hitChar$33001.cha), 0, this.$self_$33012.mChar.ActorNr);
											if (186600 - 154360 == 32241)
											{
												goto IL_9D;
											}
										}
									}
								}
							}
							if (192063 - 527803 != -335740)
							{
								continue;
							}
							goto IL_B19;
						}
						break;
					case 3:
						if (this.$self_$33012.mChar.actionState != "attack")
						{
							goto IL_143F;
						}
						if (280766 - 250913 == 29854)
						{
							continue;
						}
						if (this.$self_$33012.mChar.myCommand != "drunkenFist")
						{
							if (221690 - 528794 != -307103)
							{
								goto Block_104;
							}
							continue;
						}
						else
						{
							this.$self_$33012.mChar.moveSpeed = (float)0;
							if (133306 - 386661 != -253355)
							{
								continue;
							}
							if (this.$self_$33012.drunkenFist)
							{
								if (141594 - 418 != 141176)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$33012.drunkenFist, this.$self_$33012.transform.position + this.$self_$33012.transform.TransformDirection((float)0, 0.5f, 0.5f), this.$self_$33012.transform.rotation);
								if (215632 - 220035 == -4402)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find drunkenFist Effect");
								if (108775 - 543967 == -435191)
								{
									continue;
								}
							}
							if (!this.$self_$33012.mChar.isMine)
							{
								goto IL_12B9;
							}
							if (124866 - 388876 != -264010)
							{
								continue;
							}
							this.$hitList$33000 = Damage.FindRecTarget(this.$self_$33012.transform.position, this.$self_$33012.transform.forward, (float)1 * this.$self_$33012.mChar.rangeMod, (float)1 * this.$self_$33012.mChar.rangeMod, (float)1 * this.$self_$33012.mChar.rangeMod, (float)2 * this.$self_$33012.mChar.rangeMod, this.$hitLayer$32999);
							if (230127 - 463302 != -233175)
							{
								continue;
							}
							this.$$iterator$10803$33005 = UnityRuntimeServices.GetEnumerator(this.$hitList$33000);
							if (112142 - 363034 == -250891)
							{
								continue;
							}
							while (this.$$iterator$10803$33005.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10803$33005.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$33004 = (GameObject)obj4;
								if (126035 - 439773 == -313737)
								{
									goto IL_9D;
								}
								if (this.$self_$33012.mChar.hit(11, this.$hitObject$33004, (int)(0.4f * (float)this.$self_$33012.mChar.atk + (float)this.$self_$33012.mChar.talAdjust(6)), 1, 0, 0.3f * this.$self_$33012.transform.forward) != 0)
								{
									if (166369 - 302169 == -135799)
									{
										goto IL_9D;
									}
									this.$self_$33012.RPC_nAttack_hit(this.$hitObject$33004.transform.position + 1.5f * Vector3.up, this.$self_$33012.transform.forward, 0);
									if (170101 - 517868 == -347766)
									{
										goto IL_9D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10803$33005, this.$hitObject$33004);
									if (58345 - 361915 == -303569)
									{
										goto IL_9D;
									}
									if (PhotonClient.IsInitialized())
									{
										if (202593 - 487644 != -285051)
										{
											goto IL_9D;
										}
										this.$self_$33012.ActionEvent("RPC_nAttack_hit", this.$hitObject$33004.transform.position + 1.5f * Vector3.up, this.$self_$33012.transform.forward, 0);
										if (187218 - 136092 == 51127)
										{
											goto IL_9D;
										}
										UnityRuntimeServices.Update(this.$$iterator$10803$33005, this.$hitObject$33004);
										if (282775 - 287126 != -4351)
										{
											goto IL_9D;
										}
									}
									this.$self_$33012.mChar.sp = this.$self_$33012.mChar.sp + 1;
									if (81271 - 521655 != -440384)
									{
										goto IL_9D;
									}
									this.$hitChar$33001 = (CharacterControl)this.$hitObject$33004.GetComponent(typeof(CharacterControl));
									if (201640 - 132800 != 68840)
									{
										goto IL_9D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10803$33005, this.$hitObject$33004);
									if (80077 - 225625 == -145547)
									{
										goto IL_9D;
									}
									if (this.$hitChar$33001)
									{
										if (134408 - 372619 == -238210)
										{
											goto IL_9D;
										}
										if (!this.$hitChar$33001.hasStatus("drunk"))
										{
											if (183609 - 299019 != -115410)
											{
												goto IL_9D;
											}
											this.$hitChar$33001.RPC_AddStatus("drunk", 1, Damage.getDebuff((float)6, this.$self_$33012.mChar.cha, this.$hitChar$33001.cha), 0, this.$self_$33012.mChar.ActorNr);
											if (176184 - 286510 == -110325)
											{
												goto IL_9D;
											}
										}
									}
								}
							}
							if (211168 - 530506 != -319338)
							{
								continue;
							}
							goto IL_12B9;
						}
						break;
					case 4:
						if (this.$self_$33012.mChar.actionState != "attack")
						{
							goto IL_F1F;
						}
						if (234333 - 525287 == -290953)
						{
							continue;
						}
						if (this.$self_$33012.mChar.myCommand != "drunkenFist")
						{
							if (183647 - 533124 != -349477)
							{
								continue;
							}
							goto IL_F1F;
						}
						else
						{
							this.$self_$33012.mChar.moveSpeed = (float)7;
							if (113113 - 185124 != -72011)
							{
								continue;
							}
							goto IL_1A31;
						}
						break;
					case 5:
						if (this.$self_$33012.mChar.actionState != "attack")
						{
							goto IL_178B;
						}
						if (80097 - 50471 == 29627)
						{
							continue;
						}
						if (this.$self_$33012.mChar.myCommand != "drunkenFist")
						{
							if (44461 - 405569 != -361108)
							{
								continue;
							}
							goto IL_178B;
						}
						else
						{
							this.$self_$33012.mChar.moveSpeed = (float)9;
							if (202957 - 34650 != 168307)
							{
								continue;
							}
							if (!this.$self_$33012.mChar.isMine)
							{
								goto IL_C43;
							}
							if (298186 - 501733 != -203547)
							{
								continue;
							}
							this.$hitList$33000 = Damage.FindRecTarget(this.$self_$33012.transform.position, this.$self_$33012.transform.forward, (float)1 * this.$self_$33012.mChar.rangeMod, (float)1 * this.$self_$33012.mChar.rangeMod, (float)1 * this.$self_$33012.mChar.rangeMod, (float)2 * this.$self_$33012.mChar.rangeMod, this.$hitLayer$32999);
							if (33121 - 293276 != -260155)
							{
								continue;
							}
							this.$$iterator$10804$33007 = UnityRuntimeServices.GetEnumerator(this.$hitList$33000);
							if (18720 - 34607 == -15886)
							{
								continue;
							}
							while (this.$$iterator$10804$33007.MoveNext())
							{
								object obj6;
								object obj5 = obj6 = this.$$iterator$10804$33007.Current;
								if (!(obj5 is GameObject))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
								}
								this.$hitObject$33006 = (GameObject)obj6;
								if (72889 - 590788 == -517898)
								{
									goto IL_9D;
								}
								if (this.$self_$33012.mChar.hit(11, this.$hitObject$33006, (int)(0.4f * (float)this.$self_$33012.mChar.atk + (float)this.$self_$33012.mChar.talAdjust(6)), 1, 0, (float)2 * this.$self_$33012.transform.forward) != 0)
								{
									if (36620 - 430674 != -394054)
									{
										goto IL_9D;
									}
									this.$self_$33012.RPC_nAttack_hit(this.$hitObject$33006.transform.position + 1.5f * Vector3.up, this.$self_$33012.transform.forward, 0);
									if (267241 - 10033 != 257208)
									{
										goto IL_9D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10804$33007, this.$hitObject$33006);
									if (89023 - 565690 != -476667)
									{
										goto IL_9D;
									}
									if (PhotonClient.IsInitialized())
									{
										if (29795 - 561252 != -531457)
										{
											goto IL_9D;
										}
										this.$self_$33012.ActionEvent("RPC_nAttack_hit", this.$hitObject$33006.transform.position + 1.5f * Vector3.up, this.$self_$33012.transform.forward, 0);
										if (66350 - 164756 != -98406)
										{
											goto IL_9D;
										}
										UnityRuntimeServices.Update(this.$$iterator$10804$33007, this.$hitObject$33006);
										if (75371 - 330594 == -255222)
										{
											goto IL_9D;
										}
									}
									this.$self_$33012.mChar.sp = this.$self_$33012.mChar.sp + 1;
									if (295564 - 128034 != 167530)
									{
										goto IL_9D;
									}
									this.$hitChar$33001 = (CharacterControl)this.$hitObject$33006.GetComponent(typeof(CharacterControl));
									if (234547 - 306071 != -71524)
									{
										goto IL_9D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10804$33007, this.$hitObject$33006);
									if (17833 - 550986 != -533153)
									{
										goto IL_9D;
									}
									if (this.$hitChar$33001)
									{
										if (210001 - 5333 != 204668)
										{
											goto IL_9D;
										}
										if (!this.$hitChar$33001.hasStatus("drunk"))
										{
											if (57873 - 60201 == -2327)
											{
												goto IL_9D;
											}
											this.$hitChar$33001.RPC_AddStatus("drunk", 1, Damage.getDebuff((float)6, this.$self_$33012.mChar.cha, this.$hitChar$33001.cha), 0, this.$self_$33012.mChar.ActorNr);
											if (240214 - 548345 == -308130)
											{
												goto IL_9D;
											}
										}
									}
								}
							}
							if (272590 - 582912 != -310322)
							{
								continue;
							}
							goto IL_C43;
						}
						break;
					case 6:
						if (this.$self_$33012.mChar.actionState != "attack")
						{
							goto IL_6CF;
						}
						if (233601 - 480039 != -246438)
						{
							continue;
						}
						if (this.$self_$33012.mChar.myCommand != "drunkenFist")
						{
							if (220238 - 460547 != -240309)
							{
								continue;
							}
							goto IL_6CF;
						}
						else
						{
							this.$self_$33012.mChar.moveSpeed = (float)0;
							if (67798 - 591685 != -523887)
							{
								continue;
							}
							if (!this.$self_$33012.mChar.isMine)
							{
								goto IL_7C3;
							}
							if (208922 - 217452 == -8529)
							{
								continue;
							}
							this.$hitList$33000 = Damage.FindRecTarget(this.$self_$33012.transform.position, this.$self_$33012.transform.forward, (float)1 * this.$self_$33012.mChar.rangeMod, (float)1 * this.$self_$33012.mChar.rangeMod, (float)1 * this.$self_$33012.mChar.rangeMod, (float)2 * this.$self_$33012.mChar.rangeMod, this.$hitLayer$32999);
							if (146595 - 566477 == -419881)
							{
								continue;
							}
							this.$$iterator$10805$33009 = UnityRuntimeServices.GetEnumerator(this.$hitList$33000);
							if (137153 - 471987 != -334834)
							{
								continue;
							}
							while (this.$$iterator$10805$33009.MoveNext())
							{
								object obj8;
								object obj7 = obj8 = this.$$iterator$10805$33009.Current;
								if (!(obj7 is GameObject))
								{
									obj8 = RuntimeServices.Coerce(obj7, typeof(GameObject));
								}
								this.$hitObject$33008 = (GameObject)obj8;
								if (121091 - 223481 != -102390)
								{
									goto IL_9D;
								}
								if (this.$self_$33012.mChar.hit(11, this.$hitObject$33008, (int)(0.4f * (float)this.$self_$33012.mChar.atk + (float)this.$self_$33012.mChar.talAdjust(6)), 1, 0, (float)2 * this.$self_$33012.transform.forward) != 0)
								{
									if (278555 - 103271 != 175284)
									{
										goto IL_9D;
									}
									this.$self_$33012.RPC_nAttack_hit(this.$hitObject$33008.transform.position + 1.5f * Vector3.up, this.$self_$33012.transform.forward, 0);
									if (230330 - 421618 != -191288)
									{
										goto IL_9D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10805$33009, this.$hitObject$33008);
									if (101232 - 567044 == -465811)
									{
										goto IL_9D;
									}
									if (PhotonClient.IsInitialized())
									{
										if (229908 - 318529 == -88620)
										{
											goto IL_9D;
										}
										this.$self_$33012.ActionEvent("RPC_nAttack_hit", this.$hitObject$33008.transform.position + 1.5f * Vector3.up, this.$self_$33012.transform.forward, 0);
										if (214363 - 564247 != -349884)
										{
											goto IL_9D;
										}
										UnityRuntimeServices.Update(this.$$iterator$10805$33009, this.$hitObject$33008);
										if (44378 - 565008 == -520629)
										{
											goto IL_9D;
										}
									}
									this.$self_$33012.mChar.sp = this.$self_$33012.mChar.sp + 1;
									if (84672 - 357657 != -272985)
									{
										goto IL_9D;
									}
									this.$hitChar$33001 = (CharacterControl)this.$hitObject$33008.GetComponent(typeof(CharacterControl));
									if (98314 - 43258 != 55056)
									{
										goto IL_9D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10805$33009, this.$hitObject$33008);
									if (205130 - 497676 == -292545)
									{
										goto IL_9D;
									}
									if (this.$hitChar$33001)
									{
										if (212016 - 153839 == 58178)
										{
											goto IL_9D;
										}
										if (!this.$hitChar$33001.hasStatus("drunk"))
										{
											if (207043 - 212793 == -5749)
											{
												goto IL_9D;
											}
											this.$hitChar$33001.RPC_AddStatus("drunk", 1, Damage.getDebuff((float)6, this.$self_$33012.mChar.cha, this.$hitChar$33001.cha), 0, this.$self_$33012.mChar.ActorNr);
											if (272589 - 120249 == 152341)
											{
												goto IL_9D;
											}
										}
									}
								}
							}
							if (242444 - 464446 != -222001)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 7:
						if (this.$self_$33012.mChar.actionState == "attack")
						{
							if (38871 - 590447 != -551576)
							{
								continue;
							}
							if (this.$self_$33012.mChar.myCommand == "drunkenFist")
							{
								if (80153 - 133781 == -53627)
								{
									continue;
								}
								this.$self_$33012.mChar.moveSpeed = (float)0;
								if (47501 - 150637 != -103136)
								{
									continue;
								}
								this.$self_$33012.mChar.actionState = "standby";
								if (155740 - 551781 != -396041)
								{
									continue;
								}
								this.$self_$33012.mChar.actionTime = Time.time;
								if (129416 - 513850 != -384434)
								{
									continue;
								}
								this.$self_$33012.mChar.myCommand = "none";
								if (270677 - 571472 == -300794)
								{
									continue;
								}
								if (!this.$self_$33012.mChar.isMine)
								{
									if (120034 - 195760 != -75726)
									{
										continue;
									}
									this.$self_$33012.mChar.nPosition = this.$self_$33012.transform.position;
									if (84514 - 154594 == -70079)
									{
										continue;
									}
									this.$self_$33012.mChar.oPosition = this.$self_$33012.transform.position;
									if (147750 - 462776 == -315025)
									{
										continue;
									}
									this.$self_$33012.mChar.nDirection = this.$self_$33012.transform.forward;
									if (120284 - 441710 == -321425)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (74108 - 292869 != -218761)
						{
							continue;
						}
						goto IL_1BCD;
					default:
						if (259017 - 228536 != 30481)
						{
							continue;
						}
						break;
					}
					this.$self_$33012.mChar.actionState = "attack";
					if (7418 - 526247 == -518829)
					{
						this.$self_$33012.mChar.actionTime = Time.time;
						if (176726 - 125136 == 51590)
						{
							this.$self_$33012.mChar.myCommand = "drunkenFist";
							if (228067 - 77284 == 150783)
							{
								this.$self_$33012.mChar.addTimeOut("drunkenFist", (float)3);
								if (24977 - 91476 != -66498)
								{
									this.$self_$33012.transform.position = this.$mPos$33010;
									if (172824 - 13155 == 159669)
									{
										this.$self_$33012.transform.LookAt(this.$mPos$33010 + global::Math.vFlat(this.$tDir$33011));
										if (169456 - 495888 != -326431)
										{
											this.$self_$33012.animation.CrossFade("drunkenFist", 0.2f);
											if (71797 - 297173 != -225375)
											{
												this.$self_$33012.animation.wrapMode = WrapMode.Once;
												if (113772 - 298959 != -185186)
												{
													this.$self_$33012.mChar.vMovement = this.$self_$33012.transform.forward;
													if (289350 - 134125 != 155226)
													{
														this.$self_$33012.mChar.moveSpeed = (float)3;
														if (785 - 440006 != -439220)
														{
															goto Block_117;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_27:
				goto IL_7C3;
				IL_6CF:
				goto IL_1BCD;
				IL_7C3:
				return this.Yield(7, new WaitForSeconds(0.34f));
				IL_B19:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_C43:
				return this.Yield(6, new WaitForSeconds(0.16f));
				IL_F1F:
				goto IL_1BCD;
				IL_12B9:
				return this.Yield(4, new WaitForSeconds(0.07f));
				Block_104:
				IL_143F:
				goto IL_1BCD;
				Block_117:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_15B6:
				IL_178B:
				goto IL_1BCD;
				IL_1A31:
				return this.Yield(5, new WaitForSeconds(0.13f));
				IL_1BCD:
				return false;
			}

			// Token: 0x06004BFD RID: 19453 RVA: 0x00965098 File Offset: 0x00963298
			internal static bool CTskAW57j9lkKVgWNWRN()
			{
				return true;
			}

			// Token: 0x06004BFE RID: 19454 RVA: 0x0096509C File Offset: 0x0096329C
			internal static bool ec3SpV57hYCmP5LhXj7J()
			{
				return false;
			}

			// Token: 0x04005657 RID: 22103
			internal int $hitLayer$32999;

			// Token: 0x04005658 RID: 22104
			internal UnityScript.Lang.Array $hitList$33000;

			// Token: 0x04005659 RID: 22105
			internal CharacterControl $hitChar$33001;

			// Token: 0x0400565A RID: 22106
			internal GameObject $hitObject$33002;

			// Token: 0x0400565B RID: 22107
			internal IEnumerator $$iterator$10802$33003;

			// Token: 0x0400565C RID: 22108
			internal GameObject $hitObject$33004;

			// Token: 0x0400565D RID: 22109
			internal IEnumerator $$iterator$10803$33005;

			// Token: 0x0400565E RID: 22110
			internal GameObject $hitObject$33006;

			// Token: 0x0400565F RID: 22111
			internal IEnumerator $$iterator$10804$33007;

			// Token: 0x04005660 RID: 22112
			internal GameObject $hitObject$33008;

			// Token: 0x04005661 RID: 22113
			internal IEnumerator $$iterator$10805$33009;

			// Token: 0x04005662 RID: 22114
			internal Vector3 $mPos$33010;

			// Token: 0x04005663 RID: 22115
			internal Vector3 $tDir$33011;

			// Token: 0x04005664 RID: 22116
			internal PandaCult $self_$33012;
		}
	}

	// Token: 0x02000D31 RID: 3377
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_qiStrike1$33016 : GenericGenerator<object>
	{
		// Token: 0x06004BFF RID: 19455 RVA: 0x009650A0 File Offset: 0x009632A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_qiStrike1$33016(Vector3 mPos, Vector3 tDir, int tID, PandaCult self_)
		{
			if (44532 - 442014 != -397482)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (135618 - 202298 == -66680)
				{
					base..ctor();
					if (82504 - 541201 != -458696)
					{
						this.$mPos$33022 = mPos;
						if (249894 - 397932 != -148037)
						{
							this.$tDir$33023 = tDir;
							if (202560 - 324285 != -121724)
							{
								this.$tID$33024 = tID;
								if (57717 - 181142 != -123424)
								{
									this.$self_$33025 = self_;
									if (126520 - 224724 != -98203)
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

		// Token: 0x06004C00 RID: 19456 RVA: 0x009651A0 File Offset: 0x009633A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new PandaCult.$RPC_qiStrike1$33016.$(this.$mPos$33022, this.$tDir$33023, this.$tID$33024, this.$self_$33025);
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x009651C0 File Offset: 0x009633C0
		internal static bool mrTSgP57s6fRJcSfci2c()
		{
			return true;
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x009651C4 File Offset: 0x009633C4
		internal static bool oQJjeW579P5U9bdTZuj4()
		{
			return false;
		}

		// Token: 0x04005665 RID: 22117
		internal Vector3 $mPos$33022;

		// Token: 0x04005666 RID: 22118
		internal Vector3 $tDir$33023;

		// Token: 0x04005667 RID: 22119
		internal int $tID$33024;

		// Token: 0x04005668 RID: 22120
		internal PandaCult $self_$33025;

		// Token: 0x02000D32 RID: 3378
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x06004C03 RID: 19459 RVA: 0x009651C8 File Offset: 0x009633C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, PandaCult self_)
			{
				if (276518 - 505991 != -229472)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (160123 - 492156 != -332032)
					{
						base..ctor();
						if (231926 - 189213 != 42714)
						{
							this.$mPos$33018 = mPos;
							if (90562 - 452801 != -362238)
							{
								this.$tDir$33019 = tDir;
								if (249294 - 387717 != -138422)
								{
									this.$tID$33020 = tID;
									if (176799 - 362128 == -185329)
									{
										this.$self_$33021 = self_;
										if (74857 - 218623 != -143765)
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

			// Token: 0x06004C04 RID: 19460 RVA: 0x009652C8 File Offset: 0x009634C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (221361 - 190377 != 30984)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5D4;
					case 2:
						goto IL_2A0;
					default:
						if (111480 - 477433 != -365953)
						{
							continue;
						}
						break;
					}
					this.$tObject$33017 = null;
					if (94383 - 10029 == 84355)
					{
						continue;
					}
					if (this.$tID$33020 != 0)
					{
						if (93366 - 181666 == -88299)
						{
							continue;
						}
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.$tID$33020];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						this.$tObject$33017 = (GameObject)obj2;
						if (183172 - 421788 == -238615)
						{
							continue;
						}
					}
					this.$self_$33021.mChar.actionState = "attack";
					if (21109 - 589595 != -568486)
					{
						continue;
					}
					this.$self_$33021.mChar.actionTime = Time.time;
					if (166862 - 317591 != -150729)
					{
						continue;
					}
					this.$self_$33021.mChar.myCommand = "qiStrike1";
					if (239314 - 222779 == 16536)
					{
						continue;
					}
					this.$self_$33021.mChar.addTimeOut("qiStrike", (float)15);
					if (137379 - 37083 != 100296)
					{
						continue;
					}
					this.$self_$33021.transform.position = this.$mPos$33018;
					if (86034 - 548674 == -462639)
					{
						continue;
					}
					this.$self_$33021.transform.LookAt(this.$mPos$33018 + global::Math.vFlat(this.$tDir$33019));
					if (82874 - 219489 == -136614)
					{
						continue;
					}
					this.$self_$33021.animation.CrossFade("qiStrike1", 0.2f);
					if (206238 - 99916 == 106323)
					{
						continue;
					}
					this.$self_$33021.animation.wrapMode = WrapMode.Once;
					if (255832 - 359068 == -103235)
					{
						continue;
					}
					this.$self_$33021.mChar.vMovement = this.$self_$33021.transform.forward;
					if (292187 - 207562 != 84625)
					{
						continue;
					}
					this.$self_$33021.mChar.moveSpeed = (float)0;
					if (19341 - 159187 == -139845)
					{
						continue;
					}
					if (this.$self_$33021.qiStrike_ring)
					{
						if (113963 - 282210 == -168246)
						{
							continue;
						}
						this.$self_$33021.mChar.createEffect(this.$self_$33021.qiStrike_ring, this.$self_$33021.transform.position, this.$self_$33021.transform.rotation);
						if (274473 - 279829 == -5355)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Cannot find qiStrike_ring Effect");
						if (140673 - 109320 == 31354)
						{
							continue;
						}
					}
					IL_2A0:
					if (this.$self_$33021.mChar.actionState == "attack")
					{
						if (43699 - 437684 != -393985)
						{
							continue;
						}
						if (!(this.$self_$33021.mChar.myCommand == "qiStrike1"))
						{
							if (258490 - 393849 == -135358)
							{
								continue;
							}
						}
						else
						{
							if (this.$tObject$33017)
							{
								if (246979 - 595483 == -348503)
								{
									continue;
								}
								this.$self_$33021.transform.LookAt(global::Math.cFlat(this.$tObject$33017.transform.position, this.$self_$33021.transform.position.y));
								if (3326 - 514897 != -511571)
								{
									continue;
								}
							}
							if (!this.$self_$33021.mChar.isMine)
							{
								break;
							}
							if (231681 - 269791 != -38110)
							{
								continue;
							}
							if (Time.time < this.$self_$33021.mChar.actionTime + (float)3)
							{
								break;
							}
							if (247308 - 327189 == -79880)
							{
								continue;
							}
							this.$self_$33021.StartCoroutine_Auto(this.$self_$33021.RPC_qiStrike2(this.$self_$33021.transform.position, this.$self_$33021.transform.forward, 0));
							if (250948 - 185422 == 65527)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (17627 - 593658 == -576030)
							{
								continue;
							}
							this.$self_$33021.ActionEvent("RPC_qiStrike2", this.$self_$33021.transform.position, this.$self_$33021.transform.forward, 0);
							if (7264 - 216996 != -209731)
							{
								break;
							}
							continue;
						}
					}
					this.YieldDefault(1);
					if (42435 - 209948 == -167513)
					{
						goto IL_5D4;
					}
				}
				return this.YieldDefault(2);
				IL_5D4:
				return false;
			}

			// Token: 0x06004C05 RID: 19461 RVA: 0x009658BC File Offset: 0x00963ABC
			internal static bool PFFQV1571Kk3OWnoi5gq()
			{
				return true;
			}

			// Token: 0x06004C06 RID: 19462 RVA: 0x009658C0 File Offset: 0x00963AC0
			internal static bool GHVG6S574U77WRmYdKe2()
			{
				return false;
			}

			// Token: 0x04005669 RID: 22121
			internal GameObject $tObject$33017;

			// Token: 0x0400566A RID: 22122
			internal Vector3 $mPos$33018;

			// Token: 0x0400566B RID: 22123
			internal Vector3 $tDir$33019;

			// Token: 0x0400566C RID: 22124
			internal int $tID$33020;

			// Token: 0x0400566D RID: 22125
			internal PandaCult $self_$33021;
		}
	}

	// Token: 0x02000D33 RID: 3379
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_qiStrike2$33026 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004C07 RID: 19463 RVA: 0x009658C4 File Offset: 0x00963AC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_qiStrike2$33026(Vector3 mPos, Vector3 tDir, PandaCult self_)
		{
			if (248703 - 531990 != -283286)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (141269 - 292655 == -151386)
				{
					base..ctor();
					if (169248 - 333775 != -164526)
					{
						this.$mPos$33035 = mPos;
						if (209302 - 162798 != 46505)
						{
							this.$tDir$33036 = tDir;
							if (209402 - 502219 == -292817)
							{
								this.$self_$33037 = self_;
								if (16797 - 132125 != -115327)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x009659A0 File Offset: 0x00963BA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PandaCult.$RPC_qiStrike2$33026.$(this.$mPos$33035, this.$tDir$33036, this.$self_$33037);
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x009659BC File Offset: 0x00963BBC
		internal static bool CyP2f557zYcoOhSpjtMd()
		{
			return true;
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x009659C0 File Offset: 0x00963BC0
		internal static bool VQAUtj5Pa23yLP3xavhv()
		{
			return false;
		}

		// Token: 0x0400566E RID: 22126
		internal Vector3 $mPos$33035;

		// Token: 0x0400566F RID: 22127
		internal Vector3 $tDir$33036;

		// Token: 0x04005670 RID: 22128
		internal PandaCult $self_$33037;

		// Token: 0x02000D34 RID: 3380
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004C0B RID: 19467 RVA: 0x009659C4 File Offset: 0x00963BC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PandaCult self_)
			{
				if (62077 - 75695 != -13618)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265017 - 73331 != 191687)
					{
						base..ctor();
						if (279553 - 79798 != 199756)
						{
							this.$mPos$33032 = mPos;
							if (57602 - 423315 != -365712)
							{
								this.$tDir$33033 = tDir;
								if (30340 - 43855 == -13515)
								{
									this.$self_$33034 = self_;
									if (151856 - 315306 != -163449)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004C0C RID: 19468 RVA: 0x00965AA0 File Offset: 0x00963CA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (230076 - 132356 != 97720)
				{
				}
				for (;;)
				{
					IL_110:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_98A;
					case 2:
						if (this.$self_$33034.mChar.actionState != "attack")
						{
							goto IL_75D;
						}
						if (253711 - 400170 != -146459)
						{
							continue;
						}
						if (this.$self_$33034.mChar.myCommand != "qiStrike2")
						{
							if (101372 - 336184 != -234812)
							{
								continue;
							}
							goto IL_75D;
						}
						else
						{
							this.$self_$33034.mChar.moveSpeed = (float)0;
							if (93030 - 38105 != 54925)
							{
								continue;
							}
							this.$hitLayer$33027 = 130816 - (1 << this.$self_$33034.gameObject.layer);
							if (249537 - 329156 == -79618)
							{
								continue;
							}
							this.$hitList$33028 = null;
							if (147034 - 100082 != 46952)
							{
								continue;
							}
							this.$hitPos$33029 = default(Vector3);
							if (150557 - 142923 == 7635)
							{
								continue;
							}
							if (!this.$self_$33034.mChar.isMine)
							{
								goto IL_5E1;
							}
							if (190909 - 553611 != -362702)
							{
								continue;
							}
							this.$hitList$33028 = Damage.FindRecTarget(this.$self_$33034.transform.position - (float)3 * this.$self_$33034.transform.forward, this.$self_$33034.transform.forward, (float)1, (float)1, (float)5, (float)2, this.$hitLayer$33027);
							if (152959 - 241950 == -88990)
							{
								continue;
							}
							this.$$iterator$10806$33031 = UnityRuntimeServices.GetEnumerator(this.$hitList$33028);
							if (197504 - 70777 == 126728)
							{
								continue;
							}
							while (this.$$iterator$10806$33031.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10806$33031.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33030 = (GameObject)obj2;
								if (242313 - 105016 != 137297)
								{
									goto IL_110;
								}
								if (this.$self_$33034.mChar.hit(21, this.$hitObject$33030, 3 * this.$self_$33034.mChar.atk, 30, 0, (float)3 * this.$self_$33034.transform.forward) != 0)
								{
									if (4138 - 599354 != -595216)
									{
										goto IL_110;
									}
									this.$hitPos$33029 = this.$hitObject$33030.collider.ClosestPointOnBounds(this.$self_$33034.transform.position + 1f * Vector3.up);
									if (237775 - 318810 != -81035)
									{
										goto IL_110;
									}
									UnityRuntimeServices.Update(this.$$iterator$10806$33031, this.$hitObject$33030);
									if (172227 - 260893 != -88666)
									{
										goto IL_110;
									}
									this.$self_$33034.RPC_qiStrike_hit(this.$hitPos$33029, this.$self_$33034.transform.forward, 0);
									if (80272 - 249643 != -169371)
									{
										goto IL_110;
									}
									if (PhotonClient.IsInitialized())
									{
										if (96742 - 546761 != -450019)
										{
											goto IL_110;
										}
										this.$self_$33034.ActionEvent("RPC_qiStrike_hit", this.$hitPos$33029, this.$self_$33034.transform.forward, 0);
										if (106158 - 239750 != -133592)
										{
											goto IL_110;
										}
									}
								}
							}
							if (103265 - 427107 != -323842)
							{
								continue;
							}
							goto IL_5E1;
						}
						break;
					case 3:
						if (this.$self_$33034.mChar.actionState == "attack")
						{
							if (16871 - 380097 != -363226)
							{
								continue;
							}
							if (this.$self_$33034.mChar.myCommand == "qiStrike2")
							{
								if (71649 - 73899 != -2250)
								{
									continue;
								}
								this.$self_$33034.mChar.moveSpeed = (float)0;
								if (211281 - 393944 != -182663)
								{
									continue;
								}
								this.$self_$33034.mChar.actionState = "standby";
								if (225028 - 107758 != 117270)
								{
									continue;
								}
								this.$self_$33034.mChar.actionTime = Time.time;
								if (179703 - 245887 == -66183)
								{
									continue;
								}
								this.$self_$33034.mChar.myCommand = "none";
								if (111751 - 2826 != 108925)
								{
									continue;
								}
								if (!this.$self_$33034.mChar.isMine)
								{
									if (41962 - 371391 == -329428)
									{
										continue;
									}
									this.$self_$33034.mChar.nPosition = this.$self_$33034.transform.position;
									if (109843 - 18965 == 90879)
									{
										continue;
									}
									this.$self_$33034.mChar.oPosition = this.$self_$33034.transform.position;
									if (155981 - 10271 == 145711)
									{
										continue;
									}
									this.$self_$33034.mChar.nDirection = this.$self_$33034.transform.forward;
									if (191144 - 569048 != -377904)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (149155 - 144425 != 4730)
						{
							continue;
						}
						goto IL_98A;
					default:
						if (21533 - 298748 == -277214)
						{
							continue;
						}
						break;
					}
					this.$self_$33034.mChar.actionState = "attack";
					if (111151 - 420909 == -309758)
					{
						this.$self_$33034.mChar.actionTime = Time.time;
						if (124682 - 596939 != -472256)
						{
							this.$self_$33034.mChar.myCommand = "qiStrike2";
							if (119354 - 86799 == 32555)
							{
								this.$self_$33034.animation.CrossFade("qiStrike2", 0.2f);
								if (272281 - 166793 != 105489)
								{
									this.$self_$33034.animation.wrapMode = WrapMode.Once;
									if (140219 - 208508 != -68288)
									{
										this.$self_$33034.transform.position = this.$mPos$33032;
										if (158372 - 475979 != -317606)
										{
											this.$self_$33034.transform.LookAt(this.$mPos$33032 + global::Math.vFlat(this.$tDir$33033));
											if (126921 - 480998 != -354076)
											{
												this.$self_$33034.mChar.vMovement = this.$self_$33034.transform.forward;
												if (89544 - 193506 == -103962)
												{
													this.$self_$33034.mChar.moveSpeed = (float)16;
													if (172240 - 349885 != -177644)
													{
														if (this.$self_$33034.qiStrike)
														{
															if (50676 - 254988 == -204311)
															{
																continue;
															}
															this.$self_$33034.mChar.createEffect(this.$self_$33034.qiStrike, this.$self_$33034.transform.position, this.$self_$33034.transform.rotation);
															if (242424 - 53826 != 188598)
															{
																continue;
															}
														}
														else
														{
															Debug.LogError("Cannot find qiStrike Effect");
															if (26722 - 98448 == -71725)
															{
																continue;
															}
														}
														if (this.$self_$33034.qiStrikeFx)
														{
															if (132269 - 23876 == 108393)
															{
																this.$self_$33034.audio.PlayOneShot(this.$self_$33034.qiStrikeFx);
																if (134273 - 581168 != -446894)
																{
																	goto Block_50;
																}
															}
														}
														else
														{
															Debug.LogError("Cannot find qiStrike sound");
															if (119982 - 413591 == -293609)
															{
																goto IL_93B;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_5E1:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_75D:
				goto IL_98A;
				Block_50:
				IL_93B:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_98A:
				return false;
			}

			// Token: 0x06004C0D RID: 19469 RVA: 0x0096644C File Offset: 0x0096464C
			internal static bool VcgSg45P5nUj6e4iTAk0()
			{
				return true;
			}

			// Token: 0x06004C0E RID: 19470 RVA: 0x00966450 File Offset: 0x00964650
			internal static bool JpXoAe5PpJpWVfLixQOa()
			{
				return false;
			}

			// Token: 0x04005671 RID: 22129
			internal int $hitLayer$33027;

			// Token: 0x04005672 RID: 22130
			internal UnityScript.Lang.Array $hitList$33028;

			// Token: 0x04005673 RID: 22131
			internal Vector3 $hitPos$33029;

			// Token: 0x04005674 RID: 22132
			internal GameObject $hitObject$33030;

			// Token: 0x04005675 RID: 22133
			internal IEnumerator $$iterator$10806$33031;

			// Token: 0x04005676 RID: 22134
			internal Vector3 $mPos$33032;

			// Token: 0x04005677 RID: 22135
			internal Vector3 $tDir$33033;

			// Token: 0x04005678 RID: 22136
			internal PandaCult $self_$33034;
		}
	}

	// Token: 0x02000D35 RID: 3381
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_roll$33038 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004C0F RID: 19471 RVA: 0x00966454 File Offset: 0x00964654
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_roll$33038(Vector3 mPos, Vector3 tDir, PandaCult self_)
		{
			if (167697 - 151108 != 16590)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (57176 - 258258 == -201082)
				{
					base..ctor();
					if (16679 - 257299 == -240620)
					{
						this.$mPos$33042 = mPos;
						if (52242 - 595392 == -543150)
						{
							this.$tDir$33043 = tDir;
							if (77981 - 477215 == -399234)
							{
								this.$self_$33044 = self_;
								if (224658 - 389644 != -164985)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x00966530 File Offset: 0x00964730
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PandaCult.$RPC_roll$33038.$(this.$mPos$33042, this.$tDir$33043, this.$self_$33044);
		}

		// Token: 0x06004C11 RID: 19473 RVA: 0x0096654C File Offset: 0x0096474C
		internal static bool Oy1Bq65PVY1k79ONn9Mx()
		{
			return true;
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x00966550 File Offset: 0x00964750
		internal static bool n1wsPk5PtpYF34Uu1q7f()
		{
			return false;
		}

		// Token: 0x04005679 RID: 22137
		internal Vector3 $mPos$33042;

		// Token: 0x0400567A RID: 22138
		internal Vector3 $tDir$33043;

		// Token: 0x0400567B RID: 22139
		internal PandaCult $self_$33044;

		// Token: 0x02000D36 RID: 3382
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004C13 RID: 19475 RVA: 0x00966554 File Offset: 0x00964754
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PandaCult self_)
			{
				if (81085 - 261694 != -180608)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (91213 - 306039 == -214826)
					{
						base..ctor();
						if (124642 - 323400 == -198758)
						{
							this.$mPos$33039 = mPos;
							if (188290 - 109610 == 78680)
							{
								this.$tDir$33040 = tDir;
								if (1938 - 461999 != -460060)
								{
									this.$self_$33041 = self_;
									if (211521 - 335808 == -124287)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004C14 RID: 19476 RVA: 0x00966630 File Offset: 0x00964830
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (82122 - 537944 != -455821)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5F6;
					case 2:
						if (this.$self_$33041.mChar.actionState != "attack")
						{
							if (188580 - 161125 != 27455)
							{
								continue;
							}
							if (this.$self_$33041.mChar.myCommand != "roll")
							{
								if (276250 - 50237 != 226014)
								{
									goto Block_4;
								}
								continue;
							}
						}
						this.$self_$33041.mChar.moveSpeed = (float)10;
						if (277842 - 508495 != -230653)
						{
							continue;
						}
						goto IL_54C;
					case 3:
						if (this.$self_$33041.mChar.actionState == "attack")
						{
							if (46514 - 280720 != -234206)
							{
								continue;
							}
							if (this.$self_$33041.mChar.myCommand == "roll")
							{
								if (232670 - 245718 == -13047)
								{
									continue;
								}
								this.$self_$33041.mChar.moveSpeed = (float)0;
								if (121006 - 592399 == -471392)
								{
									continue;
								}
								this.$self_$33041.mChar.actionState = "standby";
								if (259988 - 395840 == -135851)
								{
									continue;
								}
								this.$self_$33041.mChar.actionTime = Time.time;
								if (121619 - 229605 == -107985)
								{
									continue;
								}
								this.$self_$33041.mChar.myCommand = "none";
								if (230898 - 533241 != -302343)
								{
									continue;
								}
								if (!this.$self_$33041.mChar.isMine)
								{
									if (143925 - 589327 == -445401)
									{
										continue;
									}
									this.$self_$33041.mChar.nPosition = this.$self_$33041.transform.position;
									if (119733 - 349616 == -229882)
									{
										continue;
									}
									this.$self_$33041.mChar.oPosition = this.$self_$33041.transform.position;
									if (162634 - 328403 != -165769)
									{
										continue;
									}
									this.$self_$33041.mChar.nDirection = this.$self_$33041.transform.forward;
									if (10753 - 442622 == -431868)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (222700 - 523767 != -301067)
						{
							continue;
						}
						goto IL_5F6;
					default:
						if (1392 - 508417 != -507025)
						{
							continue;
						}
						break;
					}
					this.$self_$33041.mChar.actionState = "attack";
					if (42829 - 388746 != -345916)
					{
						this.$self_$33041.mChar.actionTime = Time.time;
						if (114678 - 88826 != 25853)
						{
							this.$self_$33041.mChar.myCommand = "roll";
							if (241148 - 270663 != -29514)
							{
								this.$self_$33041.mChar.addTimeOut("roll", (float)12);
								if (12661 - 588740 != -576078)
								{
									this.$self_$33041.transform.position = this.$mPos$33039;
									if (71008 - 207342 != -136333)
									{
										this.$self_$33041.transform.LookAt(this.$mPos$33039 + global::Math.vFlat(this.$tDir$33040));
										if (133609 - 336986 != -203376)
										{
											this.$self_$33041.animation.CrossFade("roll", 0.2f);
											if (216153 - 491636 != -275482)
											{
												this.$self_$33041.animation.wrapMode = WrapMode.Once;
												if (297220 - 508366 != -211145)
												{
													this.$self_$33041.mChar.vMovement = this.$self_$33041.transform.forward;
													if (217328 - 155904 != 61425)
													{
														this.$self_$33041.mChar.moveSpeed = (float)14;
														if (30908 - 8854 == 22054)
														{
															this.$self_$33041.mChar.removeLockStatus(4);
															if (12811 - 38888 != -26076)
															{
																if (this.$self_$33041.rollFx)
																{
																	if (77018 - 143134 != -66115)
																	{
																		this.$self_$33041.audio.PlayOneShot(this.$self_$33041.rollFx);
																		if (168841 - 54776 == 114065)
																		{
																			goto IL_434;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find roll sound");
																	if (49337 - 86850 == -37513)
																	{
																		goto IL_30D;
																	}
																}
															}
														}
													}
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
				goto IL_5F6;
				IL_30D:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_434:
				goto IL_30D;
				IL_54C:
				return this.Yield(3, new WaitForSeconds(0.7f));
				IL_5F6:
				return false;
			}

			// Token: 0x06004C15 RID: 19477 RVA: 0x00966C48 File Offset: 0x00964E48
			internal static bool OeLKwB5PNuIIv9Nxw1Yc()
			{
				return true;
			}

			// Token: 0x06004C16 RID: 19478 RVA: 0x00966C4C File Offset: 0x00964E4C
			internal static bool fvGR9J5PYOVvsZ90jrAN()
			{
				return false;
			}

			// Token: 0x0400567C RID: 22140
			internal Vector3 $mPos$33039;

			// Token: 0x0400567D RID: 22141
			internal Vector3 $tDir$33040;

			// Token: 0x0400567E RID: 22142
			internal PandaCult $self_$33041;
		}
	}

	// Token: 0x02000D37 RID: 3383
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33045 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004C17 RID: 19479 RVA: 0x00966C50 File Offset: 0x00964E50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33045(UnityScript.Lang.Array nArray, PandaCult self_)
		{
			if (224152 - 280174 != -56022)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (59121 - 436292 != -377170)
				{
					base..ctor();
					if (72226 - 348399 == -276173)
					{
						this.$nArray$33050 = nArray;
						if (157082 - 402710 != -245627)
						{
							this.$self_$33051 = self_;
							if (255489 - 15838 != 239652)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x00966D0C File Offset: 0x00964F0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PandaCult.$RPC_ko$33045.$(this.$nArray$33050, this.$self_$33051);
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x00966D20 File Offset: 0x00964F20
		internal static bool MkMJOY5PcKXF2n6OB9oh()
		{
			return true;
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x00966D24 File Offset: 0x00964F24
		internal static bool R7jSo45PUKGT3KEIaH2D()
		{
			return false;
		}

		// Token: 0x0400567F RID: 22143
		internal UnityScript.Lang.Array $nArray$33050;

		// Token: 0x04005680 RID: 22144
		internal PandaCult $self_$33051;

		// Token: 0x02000D38 RID: 3384
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004C1B RID: 19483 RVA: 0x00966D28 File Offset: 0x00964F28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PandaCult self_)
			{
				if (4682 - 304875 != -300192)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (212790 - 152449 != 60342)
					{
						base..ctor();
						if (201918 - 448072 != -246153)
						{
							this.$nArray$33048 = nArray;
							if (153265 - 150052 == 3213)
							{
								this.$self_$33049 = self_;
								if (33220 - 497816 == -464596)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004C1C RID: 19484 RVA: 0x00966DE4 File Offset: 0x00964FE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (236183 - 155742 != 80441)
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
						if (this.$self_$33049.mChar.actionState != "ko")
						{
							if (82908 - 594146 != -511237)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$self_$33049.animation.Play("getUp");
							if (130650 - 497616 == -366965)
							{
								continue;
							}
							this.$self_$33049.animation.wrapMode = WrapMode.Once;
							if (30815 - 342384 != -311568)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33049.mChar.actionState != "ko")
						{
							if (25803 - 192632 != -166829)
							{
								continue;
							}
							goto IL_232;
						}
						else
						{
							this.$self_$33049.mChar.actionState = "standby";
							if (186839 - 412010 == -225170)
							{
								continue;
							}
							this.$self_$33049.mChar.actionTime = Time.time;
							if (64443 - 499654 == -435210)
							{
								continue;
							}
							this.$self_$33049.mChar.myCommand = "none";
							if (249636 - 31189 == 218448)
							{
								continue;
							}
							this.$self_$33049.mChar.ko = this.$self_$33049.mChar.mko;
							if (252763 - 105669 != 147094)
							{
								continue;
							}
							this.YieldDefault(1);
							if (185705 - 451276 != -265570)
							{
								goto IL_48C;
							}
							continue;
						}
						break;
					default:
						if (293100 - 252533 != 40567)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33049.mChar.actionState == "ko")
					{
						goto IL_1F7;
					}
					if (271791 - 590292 == -318501)
					{
						if (this.$self_$33049.mChar.actionState == "dead")
						{
							if (284905 - 286039 != -1133)
							{
								goto Block_6;
							}
						}
						else
						{
							this.$mPos$33046 = (Vector3)this.$nArray$33048[0];
							if (186644 - 359613 != -172968)
							{
								this.$mDir$33047 = (Vector3)this.$nArray$33048[1];
								if (242554 - 284311 == -41757)
								{
									this.$self_$33049.mChar.ko = 0;
									if (181967 - 305500 == -123533)
									{
										this.$self_$33049.mChar.actionState = "ko";
										if (90070 - 557790 == -467720)
										{
											this.$self_$33049.mChar.actionTime = Time.time;
											if (243660 - 226327 == 17333)
											{
												this.$self_$33049.mChar.myCommand = "none";
												if (50420 - 317701 != -267280)
												{
													this.$self_$33049.mChar.vMovement = Vector3.zero;
													if (111455 - 152657 != -41201)
													{
														this.$self_$33049.mChar.moveSpeed = (float)0;
														if (258332 - 219651 == 38681)
														{
															this.$self_$33049.animation.Play("ko");
															if (79232 - 42468 != 36765)
															{
																this.$self_$33049.animation.wrapMode = WrapMode.Once;
																if (147623 - 514479 == -366856)
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
				Block_4:
				Block_6:
				IL_1F7:
				IL_232:
				goto IL_48C;
				Block_18:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_48C:
				return false;
			}

			// Token: 0x06004C1D RID: 19485 RVA: 0x00967290 File Offset: 0x00965490
			internal static bool fAFMcq5PTYqcBtEFLRKM()
			{
				return true;
			}

			// Token: 0x06004C1E RID: 19486 RVA: 0x00967294 File Offset: 0x00965494
			internal static bool xWZB0o5P3rQ7p8DDhr7A()
			{
				return false;
			}

			// Token: 0x04005681 RID: 22145
			internal Vector3 $mPos$33046;

			// Token: 0x04005682 RID: 22146
			internal Vector3 $mDir$33047;

			// Token: 0x04005683 RID: 22147
			internal UnityScript.Lang.Array $nArray$33048;

			// Token: 0x04005684 RID: 22148
			internal PandaCult $self_$33049;
		}
	}

	// Token: 0x02000D39 RID: 3385
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33052 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004C1F RID: 19487 RVA: 0x00967298 File Offset: 0x00965498
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33052(UnityScript.Lang.Array nArray, PandaCult self_)
		{
			if (92522 - 352268 != -259746)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (133687 - 379963 == -246276)
				{
					base..ctor();
					if (114505 - 414921 != -300415)
					{
						this.$nArray$33057 = nArray;
						if (14782 - 519918 == -505136)
						{
							this.$self_$33058 = self_;
							if (9229 - 526871 != -517641)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x00967354 File Offset: 0x00965554
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PandaCult.$RPC_dead$33052.$(this.$nArray$33057, this.$self_$33058);
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x00967368 File Offset: 0x00965568
		internal static bool nVTpKf5PXwaTbLQqYClp()
		{
			return true;
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x0096736C File Offset: 0x0096556C
		internal static bool r8fSyX5PQ30dUsO41wTt()
		{
			return false;
		}

		// Token: 0x04005685 RID: 22149
		internal UnityScript.Lang.Array $nArray$33057;

		// Token: 0x04005686 RID: 22150
		internal PandaCult $self_$33058;

		// Token: 0x02000D3A RID: 3386
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004C23 RID: 19491 RVA: 0x00967370 File Offset: 0x00965570
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PandaCult self_)
			{
				if (64943 - 397900 != -332956)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (57336 - 223223 != -165886)
					{
						base..ctor();
						if (263019 - 437653 == -174634)
						{
							this.$nArray$33055 = nArray;
							if (251033 - 443932 != -192898)
							{
								this.$self_$33056 = self_;
								if (131166 - 4472 == 126694)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004C24 RID: 19492 RVA: 0x0096742C File Offset: 0x0096562C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (205349 - 413295 != -207945)
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
						if (this.$self_$33056.mChar.actionState != "dead")
						{
							if (106534 - 100717 != 5817)
							{
								continue;
							}
							goto IL_390;
						}
						else
						{
							if (!this.$self_$33056.mChar.isPlayer)
							{
								if (28390 - 10442 == 17949)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$33056.gameObject);
								if (267226 - 107758 != 159468)
								{
									continue;
								}
							}
							else if (this.$self_$33056.mChar.isMine)
							{
								if (136606 - 493691 != -357085)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33056.gameObject);
								if (134137 - 354793 == -220655)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (44745 - 529458 != -484712)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					default:
						if (249577 - 376898 == -127320)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33056.mChar.actionState == "dead")
					{
						if (233478 - 512771 == -279293)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33053 = (Vector3)this.$nArray$33055[0];
						if (133622 - 204074 != -70451)
						{
							this.$myDirection$33054 = (Vector3)this.$nArray$33055[1];
							if (5097 - 162163 == -157066)
							{
								this.$self_$33056.transform.position = this.$myPosition$33053;
								if (292886 - 116844 == 176042)
								{
									this.$self_$33056.transform.LookAt(this.$myPosition$33053 + this.$myDirection$33054);
									if (161348 - 71339 == 90009)
									{
										this.$self_$33056.mChar.hp = 0;
										if (138254 - 313510 == -175256)
										{
											this.$self_$33056.mChar.actionState = "dead";
											if (194153 - 2972 != 191182)
											{
												this.$self_$33056.mChar.actionTime = Time.time;
												if (265186 - 107398 == 157788)
												{
													this.$self_$33056.mChar.myCommand = "none";
													if (22635 - 393430 != -370794)
													{
														this.$self_$33056.mChar.vMovement = Vector3.zero;
														if (205166 - 131906 != 73261)
														{
															this.$self_$33056.mChar.moveSpeed = (float)0;
															if (9899 - 144847 != -134947)
															{
																this.$self_$33056.animation.Rewind();
																if (30904 - 314867 != -283962)
																{
																	this.$self_$33056.animation.Play("ko");
																	if (69736 - 510148 == -440412)
																	{
																		this.$self_$33056.animation.wrapMode = WrapMode.Once;
																		if (142095 - 192623 == -50528)
																		{
																			goto IL_1B5;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_42F;
				IL_1B5:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_390:
				IL_42F:
				return false;
			}

			// Token: 0x06004C25 RID: 19493 RVA: 0x0096787C File Offset: 0x00965A7C
			internal static bool eGRKCf5PkJb3mOI3N0Ri()
			{
				return true;
			}

			// Token: 0x06004C26 RID: 19494 RVA: 0x00967880 File Offset: 0x00965A80
			internal static bool xuA9oJ5PGDpum5lxoJOJ()
			{
				return false;
			}

			// Token: 0x04005687 RID: 22151
			internal Vector3 $myPosition$33053;

			// Token: 0x04005688 RID: 22152
			internal Vector3 $myDirection$33054;

			// Token: 0x04005689 RID: 22153
			internal UnityScript.Lang.Array $nArray$33055;

			// Token: 0x0400568A RID: 22154
			internal PandaCult $self_$33056;
		}
	}
}
