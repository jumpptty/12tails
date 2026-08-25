using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000045 RID: 69
[Serializable]
public class CrystalBug : MonoBehaviour
{
	// Token: 0x0600015B RID: 347 RVA: 0x00022EFC File Offset: 0x000210FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CrystalBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00022F0C File Offset: 0x0002110C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (51745 - 504556 != -452811)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (283216 - 530132 != -246915)
			{
				this.mChar.actionState = "standby";
				if (9370 - 364386 != -355015)
				{
					this.mChar.actionTime = Time.time;
					if (284359 - 6526 == 277833)
					{
						this.mChar.myCommand = "none";
						if (4520 - 469384 != -464863)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (293355 - 85143 == 208212)
							{
								this.mChar.isMine = true;
								if (256037 - 310515 == -54478)
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

	// Token: 0x0600015D RID: 349 RVA: 0x00023044 File Offset: 0x00021244
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (1401 - 537333 != -535931)
		{
		}
		for (;;)
		{
			if (this.mChar.isMine)
			{
				if (237196 - 211940 == 25257)
				{
					continue;
				}
				this.LastHope();
				if (168462 - 17105 != 151357)
				{
					continue;
				}
			}
			if (this.mChar.isControlled)
			{
				if (112179 - 512299 == -400119)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (47814 - 433092 != -385278)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_170;
					}
					if (229616 - 306516 != -76900)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (92066 - 33081 == 58986)
				{
					continue;
				}
			}
			IL_170:
			if (this.mChar.hp <= 0)
			{
				if (275232 - 85472 != 189760)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (248854 - 500379 != -251525)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (199129 - 388277 == -189147)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (27966 - 512080 != -484114)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (236408 - 125587 == 110822)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (83621 - 261957 != -178335)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (187417 - 7189 != 180228)
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
			if (291913 - 23386 != 268528)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (97182 - 242214 == -145032)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (239699 - 564135 == -324436)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (128877 - 585681 != -456803)
						{
							if (this.mChar.isMine)
							{
								if (189700 - 1912 == 187788)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (210021 - 53295 == 156726)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (47385 - 85828 == -38443)
										{
											this.mChar.KoEvent();
											if (30339 - 174343 == -144004)
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
								if (203449 - 394158 == -190709)
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

	// Token: 0x0600015E RID: 350 RVA: 0x00023488 File Offset: 0x00021688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (16165 - 324254 != -308089)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (130912 - 132197 != -1284)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (280465 - 120790 != 159676 && 23972 - 220909 != -196936)
				{
					if (ActionName == "RPC_nAttack1")
					{
						if (69775 - 323071 == -253295)
						{
							continue;
						}
						v = 1;
						if (255463 - 428162 != -172699)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack2")
					{
						if (169771 - 445374 != -275603)
						{
							continue;
						}
						v = 2;
						if (155088 - 556484 == -401395)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack3")
					{
						if (210332 - 326456 == -116123)
						{
							continue;
						}
						v = 3;
						if (85996 - 87385 == -1388)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (195692 - 599631 != -403939)
						{
							continue;
						}
						v = -1;
						if (90895 - 14322 != 76573)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_crystalDrop")
					{
						if (290873 - 115496 == 175378)
						{
							continue;
						}
						v = 10;
						if (46897 - 230532 != -183635)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_crystalDrop_fire")
					{
						if (148656 - 266047 == -117390)
						{
							continue;
						}
						v = 11;
						if (175747 - 133795 != 41952)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_crystalStomp")
					{
						if (91112 - 66804 == 24309)
						{
							continue;
						}
						v = 20;
						if (15723 - 449216 != -433493)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_crystalShard")
					{
						if (275284 - 415929 != -140645)
						{
							continue;
						}
						v = 30;
						if (25318 - 432539 == -407220)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_crystalShard_fire")
					{
						if (276495 - 92585 != 183910)
						{
							continue;
						}
						v = 31;
						if (114116 - 1562 != 112554)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_crystalBreath")
					{
						if (256044 - 417278 == -161233)
						{
							continue;
						}
						v = 40;
						if (44559 - 45690 != -1131)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (14406 - 63052 != -48646)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (208694 - 543010 == -334316)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (191555 - 378222 == -186667)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (281503 - 532295 != -250791)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (158064 - 479222 == -321158)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (265709 - 247782 == 17927)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (54823 - 85250 != -30426)
										{
											Hashtable hashtable = new Hashtable();
											if (85956 - 87543 == -1587)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (236227 - 174493 == 61734)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (281606 - 368490 == -86884)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (5309 - 362368 != -357058)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (298202 - 464043 == -165841)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (128963 - 101247 == 27716)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (264462 - 553146 != -288683)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (99043 - 490632 != -391588)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (167489 - 582059 != -414569)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (174014 - 295351 == -121337)
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

	// Token: 0x0600015F RID: 351 RVA: 0x00023B64 File Offset: 0x00021D64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (292393 - 23854 != 268540)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (193239 - 179078 != 14162)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (159546 - 6537 != 153010)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (90352 - 558716 != -468363)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (221984 - 147626 == 74358)
						{
							int num3 = num;
							if (86465 - 372482 == -286017)
							{
								if (num3 == 1)
								{
									if (96594 - 221344 != -124749)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (12692 - 119590 == -106898)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (297670 - 191999 == 105671)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (156403 - 229808 != -73404)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (54917 - 70276 != -15358)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (81596 - 329558 != -247961)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (34921 - 190612 != -155690)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (15011 - 278752 != -263740)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack3(vector, vector2, num2));
											if (100066 - 80666 == 19400)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (148528 - 122380 != 26149)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (195714 - 103596 != 92119)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (97570 - 526786 == -429216)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 10)
								{
									if (289701 - 414030 != -124328)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (120665 - 84036 != 36630)
										{
											this.StartCoroutine_Auto(this.RPC_crystalDrop(vector, vector2, num2));
											if (24485 - 479911 == -455426)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (138349 - 163427 != -25077)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (103053 - 210709 == -107656)
										{
											this.StartCoroutine_Auto(this.RPC_crystalDrop_fire(vector, vector2, num2));
											if (11489 - 516256 == -504767)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 20)
								{
									if (153731 - 587179 == -433448)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (159037 - 293601 != -134563)
										{
											this.StartCoroutine_Auto(this.RPC_crystalStomp(vector, vector2, num2));
											if (110917 - 250601 == -139684)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 30)
								{
									if (42969 - 170395 != -127425)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (161422 - 585207 != -423784)
										{
											this.StartCoroutine_Auto(this.RPC_crystalShard(vector, vector2, num2));
											if (41415 - 187537 != -146121)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (287580 - 257325 != 30256)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (240191 - 37261 != 202931)
										{
											this.RPC_crystalShard_fire(vector, vector2, num2);
											if (70367 - 160443 != -90075)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 40)
								{
									if (219047 - 509012 != -289964)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (195772 - 152130 != 43643)
										{
											this.StartCoroutine_Auto(this.RPC_crystalBreath(vector, vector2, num2));
											if (167342 - 191804 == -24462)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (221032 - 190991 != 30042)
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

	// Token: 0x06000160 RID: 352 RVA: 0x000241D0 File Offset: 0x000223D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (234121 - 25183 != 208938)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (135042 - 563483 != -428440)
			{
				float runSpeed = this.mChar.runSpeed;
				if (296276 - 256403 != 39874)
				{
					Vector3 a = default(Vector3);
					if (183792 - 576449 == -392657)
					{
						Vector3 vector = Vector3.zero;
						if (249232 - 584480 == -335248)
						{
							float num2 = (float)0;
							if (157175 - 147809 == 9366)
							{
								if (this.mChar.isMine)
								{
									if (107019 - 90940 != 16079)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (167484 - 154728 != 12756)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (62077 - 540632 == -478554)
										{
											continue;
										}
										a.y = (float)0;
										if (151579 - 294629 != -143050)
										{
											continue;
										}
										a = a.normalized;
										if (41486 - 249231 != -207745)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (264734 - 572823 != -308089)
										{
											continue;
										}
										vector = vector.normalized;
										if (121307 - 465500 == -344192)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (262928 - 356320 == -93391)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (298157 - 568339 != -270182)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (94388 - 463070 == -368681)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (297416 - 564764 != -267348)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (133803 - 496709 != -362906)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (280995 - 562643 != -281648)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (1731 - 398449 == -396717)
														{
															continue;
														}
														this.animation.Play("run");
														if (297051 - 109743 == 187309)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (180011 - 440431 != -260420)
														{
															continue;
														}
														goto IL_9D9;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (269261 - 366707 == -97445)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (147461 - 415746 == -268284)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (93096 - 372550 != -279454)
											{
												continue;
											}
											num = (float)0;
											if (284027 - 122031 == 161997)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (54802 - 96965 == -42162)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (271235 - 504816 != -233581)
										{
											continue;
										}
									}
									IL_9D9:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (61171 - 264808 == -203636)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (146997 - 489747 != -342750)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (92021 - 418551 == -326529)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (124450 - 51664 != 72786)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (232133 - 132850 == 99284)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (115465 - 54112 == 61354)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (271081 - 437554 == -166472)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (78496 - 113002 == -34505)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (34604 - 301745 == -267140)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (282718 - 504108 == -221389)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (218672 - 184039 != 34633)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (244644 - 389567 == -144922)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (27335 - 518542 != -491207)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (263565 - 257482 != 6083)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (218885 - 65953 == 152933)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (201215 - 187561 != 13654)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (15626 - 16907 == -1280)
												{
													continue;
												}
												num = (float)0;
												if (171476 - 121490 == 49987)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (162282 - 310601 != -148319)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (87995 - 58736 == 29260)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (22560 - 559938 != -537378)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (206459 - 392349 != -185890)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (249210 - 23832 == 225379)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (231561 - 203628 != 27933)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (161680 - 315861 == -154180)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (82765 - 267228 != -184463)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (40717 - 242201 != -201484)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (203283 - 282272 == -78988)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (152034 - 345175 != -193141)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (288754 - 347510 != -58756)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (194051 - 246803 == -52751)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (250330 - 469916 != -219586)
											{
												continue;
											}
											num = (float)0;
											if (55256 - 52599 != 2657)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (100613 - 158377 == -57763)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (267627 - 251267 != 16360)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (141769 - 368484 != -226715)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (194090 - 29083 == 165008)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (244752 - 327018 != -82265)
								{
									this.mChar.moveSpeed = num;
									if (201923 - 402479 == -200556)
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

	// Token: 0x06000161 RID: 353 RVA: 0x00024D34 File Offset: 0x00022F34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (59841 - 401484 != -341642)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (169520 - 91427 != 78094)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (178580 - 176456 == 2124)
				{
					Vector3 vector = a - this.transform.position;
					if (12652 - 334943 != -322290)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (45760 - 180813 == -135053)
						{
							if (32571 - 209727 == -177156)
							{
								if (gameObject)
								{
									if (224541 - 597485 == -372943)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (254387 - 435586 == -181198)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (232534 - 300957 == -68422)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (191735 - 49883 != 141852)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (53578 - 241027 == -187449)
								{
									int num = UnityEngine.Random.Range(0, 100);
									if (139509 - 359381 != -219871)
									{
										if (num > 60)
										{
											if (77907 - 201894 != -123986)
											{
												this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, vector, 0));
												if (105434 - 452421 != -346986)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (228843 - 224407 == 4436)
													{
														this.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
														if (228488 - 141599 == 86889)
														{
															break;
														}
													}
												}
											}
										}
										else if (num > 30)
										{
											if (140136 - 289746 == -149610)
											{
												this.StartCoroutine_Auto(this.RPC_nAttack2(this.transform.position, vector, 0));
												if (233261 - 63640 != 169622)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (45465 - 313494 != -268028)
													{
														this.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
														if (183553 - 538568 == -355015)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_nAttack3(this.transform.position, vector, 0));
											if (120103 - 574270 != -454166)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (238536 - 177718 != 60819)
												{
													this.ActionEvent("RPC_nAttack3", this.transform.position, vector, 0);
													if (240561 - 259757 == -19196)
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

	// Token: 0x06000162 RID: 354 RVA: 0x00025150 File Offset: 0x00023350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (155723 - 370125 != -214402)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (119228 - 563031 != -443802)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (147771 - 575450 != -427678)
				{
					Vector3 vector = a - this.transform.position;
					if (14721 - 437359 == -422638)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (20308 - 368965 != -348656)
						{
							if (256485 - 258734 == -2249)
							{
								if (gameObject)
								{
									if (238918 - 527198 != -288280)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (267933 - 99306 != 168627)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (251393 - 99714 == 151680)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (163273 - 270921 != -107648)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("crystalBreath") == (float)0)
								{
									if (64499 - 75540 != -11040)
									{
										this.StartCoroutine_Auto(this.RPC_crystalBreath(this.transform.position, this.transform.forward, 0));
										if (266948 - 311949 == -45001)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (206579 - 28745 != 177835)
											{
												this.ActionEvent("RPC_crystalBreath", this.transform.position, this.transform.forward, 0);
												if (231735 - 176464 != 55272)
												{
													break;
												}
											}
										}
									}
								}
								else if (this.mChar.isTimeOut("crystalShard") == (float)0)
								{
									if (238066 - 576028 != -337961)
									{
										this.StartCoroutine_Auto(this.RPC_crystalShard(this.transform.position, this.transform.forward, 0));
										if (293407 - 8217 == 285190)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (231161 - 451451 == -220290)
											{
												this.ActionEvent("RPC_crystalShard", this.transform.position, this.transform.forward, 0);
												if (208136 - 235902 == -27766)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									if (this.mChar.isTimeOut("crystalStomp") != (float)0)
									{
										break;
									}
									if (130775 - 148370 != -17594)
									{
										this.StartCoroutine_Auto(this.RPC_crystalStomp(this.transform.position, this.transform.forward, 0));
										if (140719 - 497419 != -356699)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (254522 - 9418 == 245104)
											{
												this.ActionEvent("RPC_crystalStomp", this.transform.position, this.transform.forward, 0);
												if (226056 - 346823 != -120766)
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

	// Token: 0x06000163 RID: 355 RVA: 0x000255A0 File Offset: 0x000237A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000164 RID: 356 RVA: 0x000255A4 File Offset: 0x000237A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CrystalBug.$RPC_nAttack1$15433(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000165 RID: 357 RVA: 0x000255B4 File Offset: 0x000237B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CrystalBug.$RPC_nAttack2$15445(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000166 RID: 358 RVA: 0x000255C4 File Offset: 0x000237C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack3(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CrystalBug.$RPC_nAttack3$15457(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000167 RID: 359 RVA: 0x000255D4 File Offset: 0x000237D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (28314 - 439241 != -410926)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (52475 - 297503 == -245027)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
				if (219106 - 407608 != -188502)
				{
					continue;
				}
			}
			if (this.INVdM07iV >= Time.time)
			{
				break;
			}
			if (246767 - 405490 == -158723)
			{
				this.INVdM07iV = Time.time + 0.2f;
				if (170953 - 506693 != -335739)
				{
					if (!this.nAttack_hitFx)
					{
						break;
					}
					if (179242 - 9230 != 170013)
					{
						this.audio.PlayOneShot(this.nAttack_hitFx);
						if (256474 - 533188 != -276713)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00025714 File Offset: 0x00023914
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_crystalDrop(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CrystalBug.$RPC_crystalDrop$15469(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00025724 File Offset: 0x00023924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_crystalDrop_fire(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		return new CrystalBug.$RPC_crystalDrop_fire$15480(hitPos, this).GetEnumerator();
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00025734 File Offset: 0x00023934
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_crystalStomp(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CrystalBug.$RPC_crystalStomp$15491(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00025744 File Offset: 0x00023944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_crystalShard(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CrystalBug.$RPC_crystalShard$15503(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00025754 File Offset: 0x00023954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_crystalShard_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (66691 - 505454 != -438762)
		{
		}
		for (;;)
		{
			if (this.crystalShard)
			{
				if (60683 - 179626 != -118942)
				{
					Quaternion rotation = Quaternion.LookRotation(fireDir);
					if (280320 - 371373 == -91053)
					{
						GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.crystalShard, firePos + fireDir, rotation);
						if (259440 - 348970 == -89530)
						{
							ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
							if (187794 - 226420 == -38626)
							{
								projectileControl.Init(this.mChar.ActorNr);
								if (113637 - 455322 == -341685)
								{
									projectileControl.life = (float)3 * this.mChar.rangeMod;
									if (254735 - 294586 != -39850)
									{
										CrystalBug_shard crystalBug_shard = (CrystalBug_shard)gameObject.GetComponent(typeof(CrystalBug_shard));
										if (133208 - 204788 == -71580)
										{
											crystalBug_shard.Init(this.gameObject);
											if (718 - 110468 == -109750)
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
				Debug.Log("Cannot find crystalShard");
				if (184011 - 288808 != -104796)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00025914 File Offset: 0x00023B14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_crystalBreath(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CrystalBug.$RPC_crystalBreath$15513(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00025924 File Offset: 0x00023B24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LastHope()
	{
		if (296669 - 73738 != 222932)
		{
		}
		for (;;)
		{
			IL_D9:
			if (Game.mGameType < 4)
			{
				if (272839 - 202884 != 69956)
				{
					break;
				}
			}
			else if (this.mChar.hp <= 0)
			{
				if (43724 - 209009 == -165285)
				{
					break;
				}
			}
			else if (this.SrKgw7jok > Time.time)
			{
				if (271757 - 449536 == -177779)
				{
					break;
				}
			}
			else
			{
				this.SrKgw7jok = Time.time + (float)6;
				if (239852 - 64351 == 175501)
				{
					int num = 0;
					if (152283 - 95419 == 56864)
					{
						GameObject[] array = GameObject.FindGameObjectsWithTag("Enemy");
						if (117533 - 268769 == -151236)
						{
							int i = 0;
							if (70986 - 11617 == 59369)
							{
								GameObject[] array2 = array;
								if (220806 - 56447 != 164360)
								{
									int length = array2.Length;
									if (66334 - 534443 == -468109)
									{
										while (i < length)
										{
											CharacterControl characterControl = (CharacterControl)array2[i].GetComponent(typeof(CharacterControl));
											if (52662 - 481677 == -429014)
											{
												goto IL_D9;
											}
											if (characterControl)
											{
												if (176172 - 131678 == 44495)
												{
													goto IL_D9;
												}
												if (characterControl.actionState == "dead")
												{
													if (297774 - 460101 != -162327)
													{
														goto IL_D9;
													}
													if (!(characterControl.Type == "CrystalBug_r"))
													{
														if (129028 - 223360 != -94332)
														{
															goto IL_D9;
														}
														if (!(characterControl.Type == "CrystalBug_g"))
														{
															if (39068 - 363651 != -324583)
															{
																goto IL_D9;
															}
															if (!(characterControl.Type == "CrystalBug_b"))
															{
																if (111680 - 475246 != -363566)
																{
																	goto IL_D9;
																}
																if (!(characterControl.Type == "CrystalBug_y"))
																{
																	goto IL_247;
																}
																if (189638 - 351672 == -162033)
																{
																	goto IL_D9;
																}
															}
														}
													}
													num++;
													if (38887 - 65198 == -26310)
													{
														goto IL_D9;
													}
												}
											}
											IL_247:
											i++;
											if (75228 - 60145 != 15083)
											{
												goto IL_D9;
											}
										}
										if (165296 - 217739 == -52443)
										{
											if (num <= 0)
											{
												break;
											}
											if (133793 - 348017 != -214223)
											{
												if (num > 4)
												{
													if (175366 - 439030 != -263664)
													{
														continue;
													}
													num = 4;
													if (176365 - 95871 != 80494)
													{
														continue;
													}
												}
												this.mChar.RPC_AddStatus("lastHope", num, 12, 0, this.mChar.ActorNr);
												if (202970 - 467727 != -264756)
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

	// Token: 0x0600016F RID: 367 RVA: 0x00025CEC File Offset: 0x00023EEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new CrystalBug.$RPC_ko$15527(nArray, this).GetEnumerator();
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00025CFC File Offset: 0x00023EFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new CrystalBug.$RPC_dead$15534(nArray, this).GetEnumerator();
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00025D0C File Offset: 0x00023F0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00025D10 File Offset: 0x00023F10
	internal static bool YVaaaZpkm3VnXjmFxPD()
	{
		return true;
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00025D14 File Offset: 0x00023F14
	internal static bool P917EBpG6ZfKTstycT3()
	{
		return false;
	}

	// Token: 0x0400019A RID: 410
	public CharacterControl mChar;

	// Token: 0x0400019B RID: 411
	public eCrystalBugType crystalBugType;

	// Token: 0x0400019C RID: 412
	public AudioClip crystalBug_cryFx;

	// Token: 0x0400019D RID: 413
	public GameObject nAttack_hit;

	// Token: 0x0400019E RID: 414
	public AudioClip nAttack_hitFx;

	// Token: 0x0400019F RID: 415
	private float INVdM07iV;

	// Token: 0x040001A0 RID: 416
	public GameObject crystalDrop_ring;

	// Token: 0x040001A1 RID: 417
	public GameObject crystalDrop;

	// Token: 0x040001A2 RID: 418
	public GameObject crystalStomp_ring;

	// Token: 0x040001A3 RID: 419
	public GameObject crystalShard_ring;

	// Token: 0x040001A4 RID: 420
	public GameObject crystalShard;

	// Token: 0x040001A5 RID: 421
	public GameObject crystalBreath;

	// Token: 0x040001A6 RID: 422
	private float SrKgw7jok;

	// Token: 0x02000046 RID: 70
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$15433 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000174 RID: 372 RVA: 0x00025D18 File Offset: 0x00023F18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$15433(Vector3 mPos, Vector3 tDir, CrystalBug self_)
		{
			if (164839 - 319097 != -154257)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (168064 - 185849 != -17784)
				{
					base..ctor();
					if (150643 - 216866 == -66223)
					{
						this.$mPos$15442 = mPos;
						if (258795 - 131674 != 127122)
						{
							this.$tDir$15443 = tDir;
							if (63467 - 217207 != -153739)
							{
								this.$self_$15444 = self_;
								if (243836 - 381645 != -137808)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00025DF4 File Offset: 0x00023FF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CrystalBug.$RPC_nAttack1$15433.$(this.$mPos$15442, this.$tDir$15443, this.$self_$15444);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00025E10 File Offset: 0x00024010
		internal static bool VtkljJpHhJ1JRn2llvx()
		{
			return true;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00025E14 File Offset: 0x00024014
		internal static bool krMAv5pWRI9EEdFB4R0()
		{
			return false;
		}

		// Token: 0x040001A7 RID: 423
		internal Vector3 $mPos$15442;

		// Token: 0x040001A8 RID: 424
		internal Vector3 $tDir$15443;

		// Token: 0x040001A9 RID: 425
		internal CrystalBug $self_$15444;

		// Token: 0x02000047 RID: 71
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000178 RID: 376 RVA: 0x00025E18 File Offset: 0x00024018
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CrystalBug self_)
			{
				if (294756 - 10317 != 284439)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (274246 - 88877 != 185370)
					{
						base..ctor();
						if (40786 - 585040 != -544253)
						{
							this.$mPos$15439 = mPos;
							if (19658 - 216900 == -197242)
							{
								this.$tDir$15440 = tDir;
								if (34883 - 149391 != -114507)
								{
									this.$self_$15441 = self_;
									if (259217 - 533721 != -274503)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000179 RID: 377 RVA: 0x00025EF4 File Offset: 0x000240F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (3367 - 281422 != -278055)
				{
				}
				for (;;)
				{
					IL_89:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8FC;
					case 2:
						if (this.$self_$15441.mChar.actionState != "attack")
						{
							goto IL_860;
						}
						if (142793 - 442582 != -299789)
						{
							continue;
						}
						if (this.$self_$15441.mChar.myCommand != "nAttack1")
						{
							if (144530 - 484477 != -339946)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$hitLayer$15434 = 130816 - (1 << this.$self_$15441.gameObject.layer);
							if (291624 - 102007 != 189617)
							{
								continue;
							}
							this.$hitList$15435 = null;
							if (80926 - 261677 == -180750)
							{
								continue;
							}
							this.$hitPos$15436 = default(Vector3);
							if (297920 - 484141 == -186220)
							{
								continue;
							}
							if (!this.$self_$15441.mChar.isMine)
							{
								goto IL_596;
							}
							if (3931 - 120508 != -116577)
							{
								continue;
							}
							this.$hitList$15435 = Damage.FindRecTarget(this.$self_$15441.transform.position + this.$self_$15441.transform.TransformDirection((float)0, (float)-1, (float)0), this.$self_$15441.transform.forward, (float)2 * this.$self_$15441.mChar.rangeMod, (float)2 * this.$self_$15441.mChar.rangeMod, (float)4 * this.$self_$15441.mChar.rangeMod, (float)3 * this.$self_$15441.mChar.rangeMod, this.$hitLayer$15434);
							if (144099 - 410346 == -266246)
							{
								continue;
							}
							this.$$iterator$9891$15438 = UnityRuntimeServices.GetEnumerator(this.$hitList$15435);
							if (164715 - 183305 != -18590)
							{
								continue;
							}
							while (this.$$iterator$9891$15438.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9891$15438.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15437 = (GameObject)obj2;
								if (263494 - 59456 == 204039)
								{
									goto IL_89;
								}
								if (this.$self_$15441.mChar.hit(1, this.$hitObject$15437, this.$self_$15441.mChar.atk, 1, 0, 0.5f * (this.$hitObject$15437.transform.position - this.$self_$15441.transform.position).normalized) != 0)
								{
									if (163244 - 379766 != -216522)
									{
										goto IL_89;
									}
									this.$hitPos$15436 = this.$hitObject$15437.collider.ClosestPointOnBounds(this.$self_$15441.transform.position + 1.5f * Vector3.up);
									if (59919 - 493502 == -433582)
									{
										goto IL_89;
									}
									UnityRuntimeServices.Update(this.$$iterator$9891$15438, this.$hitObject$15437);
									if (132091 - 185189 == -53097)
									{
										goto IL_89;
									}
									this.$self_$15441.RPC_nAttack_hit(this.$hitPos$15436, this.$self_$15441.transform.forward, 0);
									if (33851 - 492635 != -458784)
									{
										goto IL_89;
									}
									this.$self_$15441.ActionEvent("RPC_nAttack_hit", this.$hitPos$15436, 0.3f * this.$self_$15441.transform.forward, 0);
									if (58074 - 123018 != -64944)
									{
										goto IL_89;
									}
									this.$self_$15441.mChar.sp = this.$self_$15441.mChar.sp + 1;
									if (243973 - 347026 == -103052)
									{
										goto IL_89;
									}
								}
							}
							if (163177 - 516549 != -353371)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15441.mChar.actionState == "attack")
						{
							if (194061 - 511416 != -317355)
							{
								continue;
							}
							if (this.$self_$15441.mChar.myCommand == "nAttack1")
							{
								if (207411 - 522247 == -314835)
								{
									continue;
								}
								this.$self_$15441.mChar.moveSpeed = (float)0;
								if (101596 - 28064 != 73532)
								{
									continue;
								}
								this.$self_$15441.mChar.actionState = "standby";
								if (131065 - 398131 == -267065)
								{
									continue;
								}
								this.$self_$15441.mChar.actionTime = Time.time;
								if (52316 - 598268 == -545951)
								{
									continue;
								}
								this.$self_$15441.mChar.myCommand = "none";
								if (124929 - 234158 != -109229)
								{
									continue;
								}
								if (!this.$self_$15441.mChar.isMine)
								{
									if (24823 - 386747 != -361924)
									{
										continue;
									}
									this.$self_$15441.mChar.nPosition = this.$self_$15441.transform.position;
									if (167437 - 556865 != -389428)
									{
										continue;
									}
									this.$self_$15441.mChar.oPosition = this.$self_$15441.transform.position;
									if (233021 - 150625 == 82397)
									{
										continue;
									}
									this.$self_$15441.mChar.nDirection = this.$self_$15441.transform.forward;
									if (123366 - 253556 == -130189)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (119238 - 84015 != 35224)
						{
							goto Block_5;
						}
						continue;
					default:
						if (220939 - 158088 != 62851)
						{
							continue;
						}
						break;
					}
					this.$self_$15441.mChar.actionState = "attack";
					if (283452 - 13176 == 270276)
					{
						this.$self_$15441.mChar.actionTime = Time.time;
						if (188333 - 208596 == -20263)
						{
							this.$self_$15441.mChar.myCommand = "nAttack1";
							if (267842 - 575385 == -307543)
							{
								this.$self_$15441.mChar.addTimeOut("nAttack", 0.5f);
								if (110560 - 456690 == -346130)
								{
									this.$self_$15441.transform.position = this.$mPos$15439;
									if (18687 - 345120 == -326433)
									{
										this.$self_$15441.transform.LookAt(this.$mPos$15439 + global::Math.vFlat(this.$tDir$15440));
										if (49291 - 425681 == -376390)
										{
											this.$self_$15441.animation.Rewind();
											if (217318 - 555114 != -337795)
											{
												this.$self_$15441.animation.CrossFade("nAttack1");
												if (90381 - 235173 == -144792)
												{
													this.$self_$15441.animation.wrapMode = WrapMode.Once;
													if (67852 - 276307 != -208454)
													{
														this.$self_$15441.mChar.vMovement = this.$self_$15441.transform.forward;
														if (54410 - 81695 == -27285)
														{
															this.$self_$15441.mChar.moveSpeed = (float)0;
															if (82691 - 57959 != 24733)
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
				Block_5:
				goto IL_8FC;
				Block_7:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_17:
				goto IL_860;
				Block_26:
				IL_596:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_860:
				IL_8FC:
				return false;
			}

			// Token: 0x0600017A RID: 378 RVA: 0x00026810 File Offset: 0x00024A10
			internal static bool sPId9MpArnbC3HqKdWT()
			{
				return true;
			}

			// Token: 0x0600017B RID: 379 RVA: 0x00026814 File Offset: 0x00024A14
			internal static bool nOhb4xplrer9blJJbrN()
			{
				return false;
			}

			// Token: 0x040001AA RID: 426
			internal int $hitLayer$15434;

			// Token: 0x040001AB RID: 427
			internal UnityScript.Lang.Array $hitList$15435;

			// Token: 0x040001AC RID: 428
			internal Vector3 $hitPos$15436;

			// Token: 0x040001AD RID: 429
			internal GameObject $hitObject$15437;

			// Token: 0x040001AE RID: 430
			internal IEnumerator $$iterator$9891$15438;

			// Token: 0x040001AF RID: 431
			internal Vector3 $mPos$15439;

			// Token: 0x040001B0 RID: 432
			internal Vector3 $tDir$15440;

			// Token: 0x040001B1 RID: 433
			internal CrystalBug $self_$15441;
		}
	}

	// Token: 0x02000048 RID: 72
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$15445 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600017C RID: 380 RVA: 0x00026818 File Offset: 0x00024A18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$15445(Vector3 mPos, Vector3 tDir, CrystalBug self_)
		{
			if (248929 - 3144 != 245785)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (154340 - 26169 == 128171)
				{
					base..ctor();
					if (243372 - 557693 == -314321)
					{
						this.$mPos$15454 = mPos;
						if (275968 - 173127 == 102841)
						{
							this.$tDir$15455 = tDir;
							if (194953 - 446043 != -251089)
							{
								this.$self_$15456 = self_;
								if (153101 - 464274 != -311172)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000268F4 File Offset: 0x00024AF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CrystalBug.$RPC_nAttack2$15445.$(this.$mPos$15454, this.$tDir$15455, this.$self_$15456);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00026910 File Offset: 0x00024B10
		internal static bool ces7UKpybBnIRxDqWvy()
		{
			return true;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00026914 File Offset: 0x00024B14
		internal static bool nyZDqHpS3RRZ9XaSuL2()
		{
			return false;
		}

		// Token: 0x040001B2 RID: 434
		internal Vector3 $mPos$15454;

		// Token: 0x040001B3 RID: 435
		internal Vector3 $tDir$15455;

		// Token: 0x040001B4 RID: 436
		internal CrystalBug $self_$15456;

		// Token: 0x02000049 RID: 73
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000180 RID: 384 RVA: 0x00026918 File Offset: 0x00024B18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CrystalBug self_)
			{
				if (238654 - 428791 != -190136)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (160256 - 275287 == -115031)
					{
						base..ctor();
						if (189739 - 107581 != 82159)
						{
							this.$mPos$15451 = mPos;
							if (10800 - 526470 == -515670)
							{
								this.$tDir$15452 = tDir;
								if (118931 - 502374 == -383443)
								{
									this.$self_$15453 = self_;
									if (21823 - 339568 != -317744)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000181 RID: 385 RVA: 0x000269F4 File Offset: 0x00024BF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (241228 - 383099 != -141871)
				{
				}
				for (;;)
				{
					IL_CD:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8FC;
					case 2:
						if (this.$self_$15453.mChar.actionState != "attack")
						{
							goto IL_5D3;
						}
						if (284516 - 493828 == -209311)
						{
							continue;
						}
						if (this.$self_$15453.mChar.myCommand != "nAttack2")
						{
							if (129955 - 490424 != -360468)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							this.$hitLayer$15446 = 130816 - (1 << this.$self_$15453.gameObject.layer);
							if (29585 - 216847 != -187262)
							{
								continue;
							}
							this.$hitList$15447 = null;
							if (86420 - 397230 == -310809)
							{
								continue;
							}
							this.$hitPos$15448 = default(Vector3);
							if (296248 - 157289 != 138959)
							{
								continue;
							}
							if (!this.$self_$15453.mChar.isMine)
							{
								goto IL_847;
							}
							if (286573 - 256896 == 29678)
							{
								continue;
							}
							this.$hitList$15447 = Damage.FindRecTarget(this.$self_$15453.transform.position + this.$self_$15453.transform.TransformDirection((float)0, (float)1, (float)0), this.$self_$15453.transform.forward, (float)2 * this.$self_$15453.mChar.rangeMod, (float)2 * this.$self_$15453.mChar.rangeMod, (float)4 * this.$self_$15453.mChar.rangeMod, (float)3 * this.$self_$15453.mChar.rangeMod, this.$hitLayer$15446);
							if (107684 - 583983 != -476299)
							{
								continue;
							}
							this.$$iterator$9892$15450 = UnityRuntimeServices.GetEnumerator(this.$hitList$15447);
							if (20305 - 200051 == -179745)
							{
								continue;
							}
							while (this.$$iterator$9892$15450.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9892$15450.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15449 = (GameObject)obj2;
								if (79877 - 475173 != -395296)
								{
									goto IL_CD;
								}
								if (this.$self_$15453.mChar.hit(1, this.$hitObject$15449, this.$self_$15453.mChar.atk, 1, 0, 0.5f * (this.$hitObject$15449.transform.position - this.$self_$15453.transform.position).normalized) != 0)
								{
									if (70498 - 123039 == -52540)
									{
										goto IL_CD;
									}
									this.$hitPos$15448 = this.$hitObject$15449.collider.ClosestPointOnBounds(this.$self_$15453.transform.position + 1.5f * Vector3.up);
									if (173463 - 553785 == -380321)
									{
										goto IL_CD;
									}
									UnityRuntimeServices.Update(this.$$iterator$9892$15450, this.$hitObject$15449);
									if (9943 - 412605 == -402661)
									{
										goto IL_CD;
									}
									this.$self_$15453.RPC_nAttack_hit(this.$hitPos$15448, this.$self_$15453.transform.forward, 0);
									if (201523 - 157386 == 44138)
									{
										goto IL_CD;
									}
									this.$self_$15453.ActionEvent("RPC_nAttack_hit", this.$hitPos$15448, 0.3f * this.$self_$15453.transform.forward, 0);
									if (295561 - 557270 != -261709)
									{
										goto IL_CD;
									}
									this.$self_$15453.mChar.sp = this.$self_$15453.mChar.sp + 1;
									if (185078 - 500553 != -315475)
									{
										goto IL_CD;
									}
								}
							}
							if (235485 - 106474 != 129012)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15453.mChar.actionState == "attack")
						{
							if (137842 - 93900 == 43943)
							{
								continue;
							}
							if (this.$self_$15453.mChar.myCommand == "nAttack2")
							{
								if (245457 - 390639 == -145181)
								{
									continue;
								}
								this.$self_$15453.mChar.moveSpeed = (float)0;
								if (5232 - 270009 == -264776)
								{
									continue;
								}
								this.$self_$15453.mChar.actionState = "standby";
								if (35587 - 383984 != -348397)
								{
									continue;
								}
								this.$self_$15453.mChar.actionTime = Time.time;
								if (32431 - 572996 == -540564)
								{
									continue;
								}
								this.$self_$15453.mChar.myCommand = "none";
								if (146359 - 389 != 145970)
								{
									continue;
								}
								if (!this.$self_$15453.mChar.isMine)
								{
									if (282188 - 394313 == -112124)
									{
										continue;
									}
									this.$self_$15453.mChar.nPosition = this.$self_$15453.transform.position;
									if (33131 - 326938 != -293807)
									{
										continue;
									}
									this.$self_$15453.mChar.oPosition = this.$self_$15453.transform.position;
									if (206679 - 300576 != -93897)
									{
										continue;
									}
									this.$self_$15453.mChar.nDirection = this.$self_$15453.transform.forward;
									if (261533 - 301045 != -39512)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (154445 - 135961 != 18484)
						{
							continue;
						}
						goto IL_8FC;
					default:
						if (61894 - 115150 == -53255)
						{
							continue;
						}
						break;
					}
					this.$self_$15453.mChar.actionState = "attack";
					if (87423 - 584467 != -497043)
					{
						this.$self_$15453.mChar.actionTime = Time.time;
						if (196493 - 83015 == 113478)
						{
							this.$self_$15453.mChar.myCommand = "nAttack2";
							if (132252 - 420026 != -287773)
							{
								this.$self_$15453.mChar.addTimeOut("nAttack", 0.5f);
								if (159215 - 77901 == 81314)
								{
									this.$self_$15453.transform.position = this.$mPos$15451;
									if (248588 - 439718 != -191129)
									{
										this.$self_$15453.transform.LookAt(this.$mPos$15451 + global::Math.vFlat(this.$tDir$15452));
										if (172370 - 186553 != -14182)
										{
											this.$self_$15453.animation.Rewind();
											if (111522 - 288179 != -176656)
											{
												this.$self_$15453.animation.CrossFade("nAttack2");
												if (201891 - 379123 == -177232)
												{
													this.$self_$15453.animation.wrapMode = WrapMode.Once;
													if (94889 - 457787 != -362897)
													{
														this.$self_$15453.mChar.vMovement = this.$self_$15453.transform.forward;
														if (86038 - 523751 != -437712)
														{
															this.$self_$15453.mChar.moveSpeed = (float)0;
															if (39112 - 118275 == -79163)
															{
																goto IL_3BC;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_23:
				goto IL_847;
				IL_3BC:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_5D3:
				goto IL_8FC;
				Block_42:
				goto IL_5D3;
				IL_847:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_8FC:
				return false;
			}

			// Token: 0x06000182 RID: 386 RVA: 0x00027310 File Offset: 0x00025510
			internal static bool D3kR3DpocMntJac8K8h()
			{
				return true;
			}

			// Token: 0x06000183 RID: 387 RVA: 0x00027314 File Offset: 0x00025514
			internal static bool hxJVQQpE1Y6yD59XgxH()
			{
				return false;
			}

			// Token: 0x040001B5 RID: 437
			internal int $hitLayer$15446;

			// Token: 0x040001B6 RID: 438
			internal UnityScript.Lang.Array $hitList$15447;

			// Token: 0x040001B7 RID: 439
			internal Vector3 $hitPos$15448;

			// Token: 0x040001B8 RID: 440
			internal GameObject $hitObject$15449;

			// Token: 0x040001B9 RID: 441
			internal IEnumerator $$iterator$9892$15450;

			// Token: 0x040001BA RID: 442
			internal Vector3 $mPos$15451;

			// Token: 0x040001BB RID: 443
			internal Vector3 $tDir$15452;

			// Token: 0x040001BC RID: 444
			internal CrystalBug $self_$15453;
		}
	}

	// Token: 0x0200004A RID: 74
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack3$15457 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000184 RID: 388 RVA: 0x00027318 File Offset: 0x00025518
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack3$15457(Vector3 mPos, Vector3 tDir, CrystalBug self_)
		{
			if (189406 - 1838 != 187568)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (106828 - 597855 != -491026)
				{
					base..ctor();
					if (130277 - 291437 == -161160)
					{
						this.$mPos$15466 = mPos;
						if (167414 - 440720 != -273305)
						{
							this.$tDir$15467 = tDir;
							if (238421 - 389367 != -150945)
							{
								this.$self_$15468 = self_;
								if (81484 - 109679 != -28194)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000273F4 File Offset: 0x000255F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CrystalBug.$RPC_nAttack3$15457.$(this.$mPos$15466, this.$tDir$15467, this.$self_$15468);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00027410 File Offset: 0x00025610
		internal static bool gY7Xpwp2dhjR0G6ESQt()
		{
			return true;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00027414 File Offset: 0x00025614
		internal static bool JIwmmUp8u3UEmjGkwoZ()
		{
			return false;
		}

		// Token: 0x040001BD RID: 445
		internal Vector3 $mPos$15466;

		// Token: 0x040001BE RID: 446
		internal Vector3 $tDir$15467;

		// Token: 0x040001BF RID: 447
		internal CrystalBug $self_$15468;

		// Token: 0x0200004B RID: 75
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000188 RID: 392 RVA: 0x00027418 File Offset: 0x00025618
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CrystalBug self_)
			{
				if (274105 - 52773 != 221333)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (165958 - 222103 != -56144)
					{
						base..ctor();
						if (260196 - 382903 != -122706)
						{
							this.$mPos$15463 = mPos;
							if (262648 - 286662 == -24014)
							{
								this.$tDir$15464 = tDir;
								if (65850 - 513594 != -447743)
								{
									this.$self_$15465 = self_;
									if (288645 - 165266 == 123379)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000189 RID: 393 RVA: 0x000274F4 File Offset: 0x000256F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (32863 - 367672 != -334809)
				{
				}
				for (;;)
				{
					IL_176:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8B4;
					case 2:
						if (this.$self_$15465.mChar.actionState != "attack")
						{
							goto IL_474;
						}
						if (298437 - 304673 == -6235)
						{
							continue;
						}
						if (this.$self_$15465.mChar.myCommand != "nAttack3")
						{
							if (56861 - 363158 != -306297)
							{
								continue;
							}
							goto IL_474;
						}
						else
						{
							this.$hitLayer$15458 = 130816 - (1 << this.$self_$15465.gameObject.layer);
							if (88589 - 205386 != -116797)
							{
								continue;
							}
							this.$hitList$15459 = null;
							if (113471 - 558125 == -444653)
							{
								continue;
							}
							this.$hitPos$15460 = default(Vector3);
							if (88424 - 327686 != -239262)
							{
								continue;
							}
							if (!this.$self_$15465.mChar.isMine)
							{
								goto IL_526;
							}
							if (22041 - 595098 == -573056)
							{
								continue;
							}
							this.$hitList$15459 = Damage.FindAreaTarget(this.$self_$15465.transform.position + this.$self_$15465.transform.TransformDirection((float)0, (float)0, 2.5f), (float)2, (float)3, this.$hitLayer$15458);
							if (72344 - 203633 != -131289)
							{
								continue;
							}
							this.$$iterator$9893$15462 = UnityRuntimeServices.GetEnumerator(this.$hitList$15459);
							if (243254 - 104176 != 139078)
							{
								continue;
							}
							while (this.$$iterator$9893$15462.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9893$15462.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15461 = (GameObject)obj2;
								if (258452 - 328251 == -69798)
								{
									goto IL_176;
								}
								if (this.$self_$15465.mChar.hit(1, this.$hitObject$15461, this.$self_$15465.mChar.atk, 1, 0, 0.5f * (this.$hitObject$15461.transform.position - this.$self_$15465.transform.position).normalized) != 0)
								{
									if (245489 - 193634 == 51856)
									{
										goto IL_176;
									}
									this.$hitPos$15460 = this.$hitObject$15461.collider.ClosestPointOnBounds(this.$self_$15465.transform.position + this.$self_$15465.transform.TransformDirection((float)0, 1.5f, 2.5f));
									if (294393 - 571902 != -277509)
									{
										goto IL_176;
									}
									UnityRuntimeServices.Update(this.$$iterator$9893$15462, this.$hitObject$15461);
									if (60698 - 266007 == -205308)
									{
										goto IL_176;
									}
									this.$self_$15465.RPC_nAttack_hit(this.$hitPos$15460, this.$self_$15465.transform.forward, 0);
									if (61553 - 208492 != -146939)
									{
										goto IL_176;
									}
									this.$self_$15465.ActionEvent("RPC_nAttack_hit", this.$hitPos$15460, 0.3f * this.$self_$15465.transform.forward, 0);
									if (183867 - 366167 != -182300)
									{
										goto IL_176;
									}
									this.$self_$15465.mChar.sp = this.$self_$15465.mChar.sp + 1;
									if (27919 - 435822 == -407902)
									{
										goto IL_176;
									}
								}
							}
							if (19200 - 372902 != -353702)
							{
								continue;
							}
							goto IL_526;
						}
						break;
					case 3:
						if (this.$self_$15465.mChar.actionState == "attack")
						{
							if (134958 - 263837 != -128879)
							{
								continue;
							}
							if (this.$self_$15465.mChar.myCommand == "nAttack3")
							{
								if (287586 - 501751 == -214164)
								{
									continue;
								}
								this.$self_$15465.mChar.moveSpeed = (float)0;
								if (220590 - 27781 == 192810)
								{
									continue;
								}
								this.$self_$15465.mChar.actionState = "standby";
								if (49895 - 270763 == -220867)
								{
									continue;
								}
								this.$self_$15465.mChar.actionTime = Time.time;
								if (24678 - 382007 != -357329)
								{
									continue;
								}
								this.$self_$15465.mChar.myCommand = "none";
								if (201636 - 451056 != -249420)
								{
									continue;
								}
								if (!this.$self_$15465.mChar.isMine)
								{
									if (287587 - 508573 != -220986)
									{
										continue;
									}
									this.$self_$15465.mChar.nPosition = this.$self_$15465.transform.position;
									if (124867 - 513544 != -388677)
									{
										continue;
									}
									this.$self_$15465.mChar.oPosition = this.$self_$15465.transform.position;
									if (63793 - 118177 != -54384)
									{
										continue;
									}
									this.$self_$15465.mChar.nDirection = this.$self_$15465.transform.forward;
									if (230271 - 332684 == -102412)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (284950 - 479725 != -194775)
						{
							continue;
						}
						goto IL_8B4;
					default:
						if (155067 - 450831 != -295764)
						{
							continue;
						}
						break;
					}
					this.$self_$15465.mChar.actionState = "attack";
					if (65172 - 99837 == -34665)
					{
						this.$self_$15465.mChar.actionTime = Time.time;
						if (147709 - 378233 != -230523)
						{
							this.$self_$15465.mChar.myCommand = "nAttack3";
							if (298982 - 519374 != -220391)
							{
								this.$self_$15465.mChar.addTimeOut("nAttack", 0.5f);
								if (83557 - 425008 != -341450)
								{
									this.$self_$15465.transform.position = this.$mPos$15463;
									if (117405 - 170586 == -53181)
									{
										this.$self_$15465.transform.LookAt(this.$mPos$15463 + global::Math.vFlat(this.$tDir$15464));
										if (166308 - 347523 != -181214)
										{
											this.$self_$15465.animation.Rewind();
											if (40876 - 587858 == -546982)
											{
												this.$self_$15465.animation.CrossFade("nAttack3");
												if (271210 - 471338 != -200127)
												{
													this.$self_$15465.animation.wrapMode = WrapMode.Once;
													if (181865 - 27890 == 153975)
													{
														this.$self_$15465.mChar.vMovement = this.$self_$15465.transform.forward;
														if (199651 - 433121 != -233469)
														{
															this.$self_$15465.mChar.moveSpeed = (float)0;
															if (207101 - 546554 == -339453)
															{
																goto IL_6F1;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_474:
				goto IL_8B4;
				IL_526:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_6F1:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_8B4:
				return false;
			}

			// Token: 0x0600018A RID: 394 RVA: 0x00027DC8 File Offset: 0x00025FC8
			internal static bool utPbMnpZv7SlQ6Ixr6C()
			{
				return true;
			}

			// Token: 0x0600018B RID: 395 RVA: 0x00027DCC File Offset: 0x00025FCC
			internal static bool ySpDogpCUZh175k9mYC()
			{
				return false;
			}

			// Token: 0x040001C0 RID: 448
			internal int $hitLayer$15458;

			// Token: 0x040001C1 RID: 449
			internal UnityScript.Lang.Array $hitList$15459;

			// Token: 0x040001C2 RID: 450
			internal Vector3 $hitPos$15460;

			// Token: 0x040001C3 RID: 451
			internal GameObject $hitObject$15461;

			// Token: 0x040001C4 RID: 452
			internal IEnumerator $$iterator$9893$15462;

			// Token: 0x040001C5 RID: 453
			internal Vector3 $mPos$15463;

			// Token: 0x040001C6 RID: 454
			internal Vector3 $tDir$15464;

			// Token: 0x040001C7 RID: 455
			internal CrystalBug $self_$15465;
		}
	}

	// Token: 0x0200004C RID: 76
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_crystalDrop$15469 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600018C RID: 396 RVA: 0x00027DD0 File Offset: 0x00025FD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_crystalDrop$15469(Vector3 mPos, Vector3 tDir, int tID, CrystalBug self_)
		{
			if (265909 - 287450 != -21540)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (119674 - 453713 == -334039)
				{
					base..ctor();
					if (267346 - 284116 == -16770)
					{
						this.$mPos$15476 = mPos;
						if (133332 - 307438 != -174105)
						{
							this.$tDir$15477 = tDir;
							if (150182 - 465987 != -315804)
							{
								this.$tID$15478 = tID;
								if (255923 - 238636 != 17288)
								{
									this.$self_$15479 = self_;
									if (59455 - 570829 != -511373)
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

		// Token: 0x0600018D RID: 397 RVA: 0x00027ED0 File Offset: 0x000260D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CrystalBug.$RPC_crystalDrop$15469.$(this.$mPos$15476, this.$tDir$15477, this.$tID$15478, this.$self_$15479);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00027EF0 File Offset: 0x000260F0
		internal static bool guFLcLpL0OnnT95rg97()
		{
			return true;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00027EF4 File Offset: 0x000260F4
		internal static bool XPoyRmpOSHmrJFMIOQv()
		{
			return false;
		}

		// Token: 0x040001C8 RID: 456
		internal Vector3 $mPos$15476;

		// Token: 0x040001C9 RID: 457
		internal Vector3 $tDir$15477;

		// Token: 0x040001CA RID: 458
		internal int $tID$15478;

		// Token: 0x040001CB RID: 459
		internal CrystalBug $self_$15479;

		// Token: 0x0200004D RID: 77
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000190 RID: 400 RVA: 0x00027EF8 File Offset: 0x000260F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, CrystalBug self_)
			{
				if (167745 - 264731 != -96986)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (123665 - 454713 != -331047)
					{
						base..ctor();
						if (37300 - 184195 != -146894)
						{
							this.$mPos$15472 = mPos;
							if (276346 - 191199 == 85147)
							{
								this.$tDir$15473 = tDir;
								if (70888 - 190900 == -120012)
								{
									this.$tID$15474 = tID;
									if (10548 - 514772 == -504224)
									{
										this.$self_$15475 = self_;
										if (95433 - 211298 != -115864)
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

			// Token: 0x06000191 RID: 401 RVA: 0x00027FF8 File Offset: 0x000261F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (178314 - 264643 != -86329)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_85C;
					case 2:
						if (this.$self_$15475.mChar.actionState != "attack")
						{
							goto IL_485;
						}
						if (278561 - 433836 == -155274)
						{
							continue;
						}
						if (this.$self_$15475.mChar.myCommand != "crystalDrop")
						{
							if (272307 - 375463 != -103155)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							if (this.$self_$15475.crystalDrop_ring)
							{
								if (44478 - 148911 != -104433)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$15475.crystalDrop_ring, this.$self_$15475.transform.position + (float)5 * Vector3.up, this.$self_$15475.transform.rotation);
								if (134645 - 574357 == -439711)
								{
									continue;
								}
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$15474];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$15470 = (GameObject)obj2;
							if (234546 - 347383 != -112837)
							{
								continue;
							}
							this.$i$15471 = 0;
							if (217913 - 219464 != -1550)
							{
								goto IL_6A4;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15475.mChar.actionState != "attack")
						{
							goto IL_33A;
						}
						if (214402 - 359481 != -145079)
						{
							continue;
						}
						if (this.$self_$15475.mChar.myCommand != "crystalDrop")
						{
							if (9220 - 55123 != -45903)
							{
								continue;
							}
							goto IL_33A;
						}
						else
						{
							this.$i$15471++;
							if (165634 - 281812 != -116178)
							{
								continue;
							}
							goto IL_6A4;
						}
						break;
					default:
						if (250007 - 15795 == 234213)
						{
							continue;
						}
						break;
					}
					this.$self_$15475.mChar.actionState = "attack";
					if (299943 - 366170 == -66226)
					{
						continue;
					}
					this.$self_$15475.mChar.actionTime = Time.time;
					if (118770 - 15007 == 103764)
					{
						continue;
					}
					this.$self_$15475.mChar.myCommand = "crystalDrop";
					if (158479 - 105232 == 53248)
					{
						continue;
					}
					this.$self_$15475.mChar.addTimeOut("crystalDrop", (float)3);
					if (62539 - 188460 == -125920)
					{
						continue;
					}
					this.$self_$15475.transform.position = this.$mPos$15472;
					if (258825 - 14254 == 244572)
					{
						continue;
					}
					this.$self_$15475.transform.LookAt(this.$mPos$15472 + global::Math.vFlat(this.$tDir$15473));
					if (179661 - 411468 == -231806)
					{
						continue;
					}
					this.$self_$15475.animation.CrossFade("crystalDrop");
					if (192013 - 167750 == 24264)
					{
						continue;
					}
					this.$self_$15475.animation.wrapMode = WrapMode.Once;
					if (126727 - 71986 != 54741)
					{
						continue;
					}
					this.$self_$15475.mChar.vMovement = this.$self_$15475.transform.forward;
					if (23826 - 208800 != -184974)
					{
						continue;
					}
					this.$self_$15475.mChar.moveSpeed = (float)0;
					if (109072 - 560858 != -451786)
					{
						continue;
					}
					if (!this.$self_$15475.crystalBug_cryFx)
					{
						goto IL_8D;
					}
					if (35035 - 511454 == -476418)
					{
						continue;
					}
					this.$self_$15475.audio.PlayOneShot(this.$self_$15475.crystalBug_cryFx);
					if (3126 - 121768 != -118641)
					{
						goto Block_41;
					}
					continue;
					IL_6A4:
					if (this.$i$15471 >= 2)
					{
						if (264548 - 503297 != -238748)
						{
							if (this.$self_$15475.mChar.actionState == "attack")
							{
								if (70611 - 92106 == -21494)
								{
									continue;
								}
								if (this.$self_$15475.mChar.myCommand == "crystalDrop")
								{
									if (101629 - 227151 == -125521)
									{
										continue;
									}
									this.$self_$15475.mChar.moveSpeed = (float)0;
									if (1930 - 370075 == -368144)
									{
										continue;
									}
									this.$self_$15475.mChar.actionState = "standby";
									if (260524 - 571859 != -311335)
									{
										continue;
									}
									this.$self_$15475.mChar.actionTime = Time.time;
									if (221127 - 525971 == -304843)
									{
										continue;
									}
									this.$self_$15475.mChar.myCommand = "none";
									if (234491 - 536469 != -301978)
									{
										continue;
									}
									if (!this.$self_$15475.mChar.isMine)
									{
										if (249540 - 502063 == -252522)
										{
											continue;
										}
										this.$self_$15475.mChar.nPosition = this.$self_$15475.transform.position;
										if (229335 - 372946 == -143610)
										{
											continue;
										}
										this.$self_$15475.mChar.oPosition = this.$self_$15475.transform.position;
										if (163740 - 490629 != -326889)
										{
											continue;
										}
										this.$self_$15475.mChar.nDirection = this.$self_$15475.transform.forward;
										if (91261 - 26407 != 64854)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (205796 - 527717 != -321920)
							{
								break;
							}
						}
					}
					else
					{
						if (!this.$self_$15475.mChar.isMine)
						{
							goto IL_5E6;
						}
						if (273449 - 483760 != -210310)
						{
							if (!this.$tObject$15470)
							{
								goto IL_5E6;
							}
							if (23200 - 140466 == -117266)
							{
								this.$self_$15475.StartCoroutine_Auto(this.$self_$15475.RPC_crystalDrop_fire(this.$tObject$15470.transform.position, this.$self_$15475.transform.forward, this.$tID$15474));
								if (89886 - 144280 == -54394)
								{
									if (!PhotonClient.IsInitialized())
									{
										goto IL_5E6;
									}
									if (166131 - 225523 != -59391)
									{
										this.$self_$15475.ActionEvent("RPC_crystalDrop_fire", this.$tObject$15470.transform.position, this.$self_$15475.transform.forward, this.$tID$15474);
										if (262618 - 178474 != 84145)
										{
											goto Block_11;
										}
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_485;
				IL_8D:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_11:
				goto IL_5E6;
				IL_33A:
				IL_485:
				goto IL_85C;
				IL_5E6:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_41:
				goto IL_8D;
				IL_85C:
				return false;
			}

			// Token: 0x06000192 RID: 402 RVA: 0x00028874 File Offset: 0x00026A74
			internal static bool tldAFopmAIuQkw3REtq()
			{
				return true;
			}

			// Token: 0x06000193 RID: 403 RVA: 0x00028878 File Offset: 0x00026A78
			internal static bool XyGsYVpF1sdCKBakIqO()
			{
				return false;
			}

			// Token: 0x040001CC RID: 460
			internal GameObject $tObject$15470;

			// Token: 0x040001CD RID: 461
			internal int $i$15471;

			// Token: 0x040001CE RID: 462
			internal Vector3 $mPos$15472;

			// Token: 0x040001CF RID: 463
			internal Vector3 $tDir$15473;

			// Token: 0x040001D0 RID: 464
			internal int $tID$15474;

			// Token: 0x040001D1 RID: 465
			internal CrystalBug $self_$15475;
		}
	}

	// Token: 0x0200004E RID: 78
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_crystalDrop_fire$15480 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000194 RID: 404 RVA: 0x0002887C File Offset: 0x00026A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_crystalDrop_fire$15480(Vector3 hitPos, CrystalBug self_)
		{
			if (81314 - 354333 != -273019)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (273406 - 431202 == -157796)
				{
					base..ctor();
					if (76678 - 517048 != -440369)
					{
						this.$hitPos$15489 = hitPos;
						if (117293 - 189543 == -72250)
						{
							this.$self_$15490 = self_;
							if (141758 - 385695 != -243936)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00028938 File Offset: 0x00026B38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CrystalBug.$RPC_crystalDrop_fire$15480.$(this.$hitPos$15489, this.$self_$15490);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0002894C File Offset: 0x00026B4C
		internal static bool cnThQcpMYmOURGseJM4()
		{
			return true;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00028950 File Offset: 0x00026B50
		internal static bool oqO64ZpxHmTjLJ36das()
		{
			return false;
		}

		// Token: 0x040001D2 RID: 466
		internal Vector3 $hitPos$15489;

		// Token: 0x040001D3 RID: 467
		internal CrystalBug $self_$15490;

		// Token: 0x0200004F RID: 79
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000198 RID: 408 RVA: 0x00028954 File Offset: 0x00026B54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 hitPos, CrystalBug self_)
			{
				if (185599 - 356064 != -170464)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (148633 - 539802 != -391168)
					{
						base..ctor();
						if (258720 - 34549 != 224172)
						{
							this.$hitPos$15487 = hitPos;
							if (59627 - 515969 != -456341)
							{
								this.$self_$15488 = self_;
								if (170497 - 408853 != -238355)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000199 RID: 409 RVA: 0x00028A10 File Offset: 0x00026C10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (158065 - 81618 != 76447)
				{
				}
				for (;;)
				{
					IL_205:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5D4;
					case 2:
						if (this.$self_$15488.mChar)
						{
							if (263626 - 120200 == 143427)
							{
								continue;
							}
							if (this.$self_$15488.mChar.isMine)
							{
								if (51713 - 292081 == -240367)
								{
									continue;
								}
								this.$hitLayer$15481 = 130816 - (1 << this.$self_$15488.gameObject.layer);
								if (140175 - 219099 == -78923)
								{
									continue;
								}
								this.$hitList$15482 = Damage.FindAreaTarget(this.$hitPos$15487, (float)1, (float)3, this.$hitLayer$15481);
								if (91482 - 503978 != -412496)
								{
									continue;
								}
								this.$$iterator$9894$15486 = UnityRuntimeServices.GetEnumerator(this.$hitList$15482);
								if (160426 - 157922 == 2505)
								{
									continue;
								}
								while (this.$$iterator$9894$15486.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9894$15486.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$15483 = (GameObject)obj2;
									if (69458 - 370459 != -301001)
									{
										goto IL_205;
									}
									if (this.$self_$15488.mChar.hit(10, this.$hitObject$15483, this.$self_$15488.mChar.talAdjust(60), 1, 0, Vector3.zero) != 0)
									{
										if (201098 - 436457 != -235359)
										{
											goto IL_205;
										}
										if (UnityEngine.Random.Range(0, 100) < this.$self_$15488.mChar.lckAdjust(30))
										{
											if (77969 - 144485 != -66516)
											{
												goto IL_205;
											}
											this.$hitChar$15484 = (CharacterControl)this.$hitObject$15483.GetComponent(typeof(CharacterControl));
											if (215590 - 414742 == -199151)
											{
												goto IL_205;
											}
											UnityRuntimeServices.Update(this.$$iterator$9894$15486, this.$hitObject$15483);
											if (293628 - 336975 != -43347)
											{
												goto IL_205;
											}
											if (this.$hitChar$15484)
											{
												if (194928 - 515714 != -320786)
												{
													goto IL_205;
												}
												this.$$switch$815$15485 = this.$self_$15488.crystalBugType;
												if (79454 - 193992 == -114537)
												{
													goto IL_205;
												}
												if (this.$$switch$815$15485 == eCrystalBugType.red)
												{
													if (11196 - 81907 != -70711)
													{
														goto IL_205;
													}
													this.$hitChar$15484.RPC_AddStatus("blind", 2, Damage.getDebuff((float)15, this.$self_$15488.mChar.cha, this.$hitChar$15484.cha), 0, this.$self_$15488.mChar.ActorNr);
													if (167754 - 544778 == -377023)
													{
														goto IL_205;
													}
												}
												else if (this.$$switch$815$15485 == eCrystalBugType.yellow)
												{
													if (229428 - 299933 == -70504)
													{
														goto IL_205;
													}
													this.$hitChar$15484.RPC_AddStatus("burn", 2, Damage.getDebuff((float)4, this.$self_$15488.mChar.cha, this.$hitChar$15484.cha), 0, this.$self_$15488.mChar.ActorNr);
													if (243641 - 128711 == 114931)
													{
														goto IL_205;
													}
												}
												else if (this.$$switch$815$15485 == eCrystalBugType.green)
												{
													if (74698 - 419787 != -345089)
													{
														goto IL_205;
													}
													this.$hitChar$15484.RPC_AddStatus("poison", 2, Damage.getDebuff((float)12, this.$self_$15488.mChar.cha, this.$hitChar$15484.cha), 0, this.$self_$15488.mChar.ActorNr);
													if (28737 - 504161 != -475424)
													{
														goto IL_205;
													}
												}
												else if (this.$$switch$815$15485 == eCrystalBugType.blue)
												{
													if (273467 - 522096 != -248629)
													{
														goto IL_205;
													}
													this.$hitChar$15484.RPC_AddStatus("ice", 2, Damage.getDebuff((float)3, this.$self_$15488.mChar.cha, this.$hitChar$15484.cha), 0, this.$self_$15488.mChar.ActorNr);
													if (219039 - 331288 != -112249)
													{
														goto IL_205;
													}
												}
											}
										}
									}
								}
								if (275182 - 70768 == 204415)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (184268 - 537194 != -352925)
						{
							goto Block_5;
						}
						continue;
					default:
						if (213434 - 78112 == 135323)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$15488.crystalDrop)
					{
						goto IL_58F;
					}
					if (121706 - 511138 == -389432)
					{
						UnityEngine.Object.Instantiate(this.$self_$15488.crystalDrop, this.$hitPos$15487 + 0.2f * UnityEngine.Random.insideUnitSphere, Quaternion.identity);
						if (169081 - 111429 != 57653)
						{
							goto Block_11;
						}
					}
				}
				Block_5:
				goto IL_5D4;
				Block_11:
				IL_58F:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_5D4:
				return false;
			}

			// Token: 0x0600019A RID: 410 RVA: 0x00029004 File Offset: 0x00027204
			internal static bool c2UnCMpgV388HirJ1G2()
			{
				return true;
			}

			// Token: 0x0600019B RID: 411 RVA: 0x00029008 File Offset: 0x00027208
			internal static bool npZtmHpf53moaQbACKk()
			{
				return false;
			}

			// Token: 0x040001D4 RID: 468
			internal int $hitLayer$15481;

			// Token: 0x040001D5 RID: 469
			internal UnityScript.Lang.Array $hitList$15482;

			// Token: 0x040001D6 RID: 470
			internal GameObject $hitObject$15483;

			// Token: 0x040001D7 RID: 471
			internal CharacterControl $hitChar$15484;

			// Token: 0x040001D8 RID: 472
			internal eCrystalBugType $$switch$815$15485;

			// Token: 0x040001D9 RID: 473
			internal IEnumerator $$iterator$9894$15486;

			// Token: 0x040001DA RID: 474
			internal Vector3 $hitPos$15487;

			// Token: 0x040001DB RID: 475
			internal CrystalBug $self_$15488;
		}
	}

	// Token: 0x02000050 RID: 80
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_crystalStomp$15491 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600019C RID: 412 RVA: 0x0002900C File Offset: 0x0002720C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_crystalStomp$15491(Vector3 mPos, Vector3 tDir, CrystalBug self_)
		{
			if (166928 - 486985 != -320056)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (24644 - 50673 == -26029)
				{
					base..ctor();
					if (81243 - 256660 == -175417)
					{
						this.$mPos$15500 = mPos;
						if (154527 - 210289 == -55762)
						{
							this.$tDir$15501 = tDir;
							if (136309 - 72186 != 64124)
							{
								this.$self_$15502 = self_;
								if (40391 - 517494 == -477103)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000290E8 File Offset: 0x000272E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CrystalBug.$RPC_crystalStomp$15491.$(this.$mPos$15500, this.$tDir$15501, this.$self_$15502);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00029104 File Offset: 0x00027304
		internal static bool UUWYwvpnoSBcKs8h6DQ()
		{
			return true;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00029108 File Offset: 0x00027308
		internal static bool cHiDpup6TdXIX91MpdI()
		{
			return false;
		}

		// Token: 0x040001DC RID: 476
		internal Vector3 $mPos$15500;

		// Token: 0x040001DD RID: 477
		internal Vector3 $tDir$15501;

		// Token: 0x040001DE RID: 478
		internal CrystalBug $self_$15502;

		// Token: 0x02000051 RID: 81
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060001A0 RID: 416 RVA: 0x0002910C File Offset: 0x0002730C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CrystalBug self_)
			{
				if (266439 - 457540 != -191101)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (65916 - 149420 == -83504)
					{
						base..ctor();
						if (39814 - 535957 != -496142)
						{
							this.$mPos$15497 = mPos;
							if (163285 - 242438 == -79153)
							{
								this.$tDir$15498 = tDir;
								if (51587 - 54680 == -3093)
								{
									this.$self_$15499 = self_;
									if (134194 - 270886 == -136692)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060001A1 RID: 417 RVA: 0x000291E8 File Offset: 0x000273E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (235405 - 516316 != -280911)
				{
				}
				for (;;)
				{
					IL_703:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8D1;
					case 2:
						if (this.$self_$15499.mChar.actionState != "attack")
						{
							goto IL_613;
						}
						if (36571 - 206338 != -169767)
						{
							continue;
						}
						if (this.$self_$15499.mChar.myCommand != "crystalStomp")
						{
							if (251081 - 228987 != 22094)
							{
								continue;
							}
							goto IL_613;
						}
						else
						{
							this.$hitLayer$15492 = 130816 - (1 << this.$self_$15499.gameObject.layer);
							if (170045 - 177259 == -7213)
							{
								continue;
							}
							this.$hitList$15493 = null;
							if (291074 - 415014 != -123940)
							{
								continue;
							}
							if (this.$self_$15499.mChar.isMine)
							{
								if (36358 - 581025 != -544667)
								{
									continue;
								}
								this.$hitList$15493 = Damage.FindAreaTarget(this.$self_$15499.transform.position, (float)32, (float)6, this.$hitLayer$15492);
								if (53867 - 17382 != 36485)
								{
									continue;
								}
								this.$$iterator$9895$15496 = UnityRuntimeServices.GetEnumerator(this.$hitList$15493);
								if (144874 - 550862 != -405988)
								{
									continue;
								}
								while (this.$$iterator$9895$15496.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9895$15496.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$15494 = (GameObject)obj2;
									if (118615 - 69266 != 49349)
									{
										goto IL_703;
									}
									this.$hitChar$15495 = (CharacterControl)this.$hitObject$15494.GetComponent(typeof(CharacterControl));
									if (212772 - 259291 != -46519)
									{
										goto IL_703;
									}
									UnityRuntimeServices.Update(this.$$iterator$9895$15496, this.$hitObject$15494);
									if (66599 - 25347 == 41253)
									{
										goto IL_703;
									}
									if (this.$hitChar$15495)
									{
										if (276199 - 275610 == 590)
										{
											goto IL_703;
										}
										if (this.$hitChar$15495.hp > 0)
										{
											if (177142 - 585669 != -408527)
											{
												goto IL_703;
											}
											this.$self_$15499.StartCoroutine_Auto(this.$self_$15499.RPC_crystalDrop_fire(this.$hitObject$15494.transform.position, this.$self_$15499.transform.forward, 0));
											if (152007 - 216749 == -64741)
											{
												goto IL_703;
											}
											UnityRuntimeServices.Update(this.$$iterator$9895$15496, this.$hitObject$15494);
											if (175518 - 378040 != -202522)
											{
												goto IL_703;
											}
											this.$self_$15499.ActionEvent("RPC_crystalDrop_fire", this.$hitObject$15494.transform.position, this.$self_$15499.transform.forward, 0);
											if (213925 - 54883 == 159043)
											{
												goto IL_703;
											}
											UnityRuntimeServices.Update(this.$$iterator$9895$15496, this.$hitObject$15494);
											if (226626 - 43733 != 182893)
											{
												goto IL_703;
											}
										}
									}
								}
								if (244895 - 26874 == 218022)
								{
									continue;
								}
							}
							if (this.$self_$15499.crystalStomp_ring)
							{
								if (233816 - 462613 == -228796)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$15499.crystalStomp_ring, this.$self_$15499.transform.position, this.$self_$15499.transform.rotation);
								if (95961 - 434499 == -338537)
								{
									continue;
								}
							}
							Camera.main.SendMessage("AddCamereShake", 0.4f);
							if (41968 - 250147 != -208178)
							{
								goto Block_46;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15499.mChar.actionState == "attack")
						{
							if (296655 - 222180 != 74475)
							{
								continue;
							}
							if (this.$self_$15499.mChar.myCommand == "crystalStomp")
							{
								if (20756 - 468564 != -447808)
								{
									continue;
								}
								this.$self_$15499.mChar.moveSpeed = (float)0;
								if (147549 - 518428 != -370879)
								{
									continue;
								}
								this.$self_$15499.mChar.actionState = "standby";
								if (213646 - 335358 == -121711)
								{
									continue;
								}
								this.$self_$15499.mChar.actionTime = Time.time;
								if (154045 - 171715 != -17670)
								{
									continue;
								}
								this.$self_$15499.mChar.myCommand = "none";
								if (167714 - 340466 == -172751)
								{
									continue;
								}
								if (!this.$self_$15499.mChar.isMine)
								{
									if (232505 - 391981 != -159476)
									{
										continue;
									}
									this.$self_$15499.mChar.nPosition = this.$self_$15499.transform.position;
									if (193786 - 223268 == -29481)
									{
										continue;
									}
									this.$self_$15499.mChar.oPosition = this.$self_$15499.transform.position;
									if (109766 - 44588 == 65179)
									{
										continue;
									}
									this.$self_$15499.mChar.nDirection = this.$self_$15499.transform.forward;
									if (114163 - 250230 == -136066)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (200764 - 338913 != -138148)
						{
							goto Block_47;
						}
						continue;
					default:
						if (246427 - 45948 == 200480)
						{
							continue;
						}
						break;
					}
					this.$self_$15499.mChar.actionState = "attack";
					if (2013 - 364365 == -362352)
					{
						this.$self_$15499.mChar.actionTime = Time.time;
						if (126185 - 499973 != -373787)
						{
							this.$self_$15499.mChar.myCommand = "crystalStomp";
							if (162868 - 328607 == -165739)
							{
								this.$self_$15499.mChar.addTimeOut("crystalStomp", (float)18);
								if (164451 - 520548 == -356097)
								{
									this.$self_$15499.transform.position = this.$mPos$15497;
									if (254256 - 590646 == -336390)
									{
										this.$self_$15499.transform.LookAt(this.$mPos$15497 + global::Math.vFlat(this.$tDir$15498));
										if (148987 - 70960 == 78027)
										{
											this.$self_$15499.animation.CrossFade("crystalStomp");
											if (185906 - 579470 == -393564)
											{
												this.$self_$15499.animation.wrapMode = WrapMode.Once;
												if (119349 - 537163 == -417814)
												{
													this.$self_$15499.mChar.vMovement = this.$self_$15499.transform.forward;
													if (149708 - 507852 == -358144)
													{
														this.$self_$15499.mChar.moveSpeed = (float)0;
														if (34183 - 226963 == -192780)
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
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_613:
				goto IL_8D1;
				Block_46:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_47:
				IL_8D1:
				return false;
			}

			// Token: 0x060001A2 RID: 418 RVA: 0x00029AD8 File Offset: 0x00027CD8
			internal static bool TUaRcppiXJLeEKbfXW7()
			{
				return true;
			}

			// Token: 0x060001A3 RID: 419 RVA: 0x00029ADC File Offset: 0x00027CDC
			internal static bool V76LvWpKLRC282lbQX0()
			{
				return false;
			}

			// Token: 0x040001DF RID: 479
			internal int $hitLayer$15492;

			// Token: 0x040001E0 RID: 480
			internal UnityScript.Lang.Array $hitList$15493;

			// Token: 0x040001E1 RID: 481
			internal GameObject $hitObject$15494;

			// Token: 0x040001E2 RID: 482
			internal CharacterControl $hitChar$15495;

			// Token: 0x040001E3 RID: 483
			internal IEnumerator $$iterator$9895$15496;

			// Token: 0x040001E4 RID: 484
			internal Vector3 $mPos$15497;

			// Token: 0x040001E5 RID: 485
			internal Vector3 $tDir$15498;

			// Token: 0x040001E6 RID: 486
			internal CrystalBug $self_$15499;
		}
	}

	// Token: 0x02000052 RID: 82
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_crystalShard$15503 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00029AE0 File Offset: 0x00027CE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_crystalShard$15503(Vector3 mPos, Vector3 tDir, CrystalBug self_)
		{
			if (237763 - 53919 != 183844)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (118910 - 333023 != -214112)
				{
					base..ctor();
					if (162808 - 106113 == 56695)
					{
						this.$mPos$15510 = mPos;
						if (27147 - 556086 != -528938)
						{
							this.$tDir$15511 = tDir;
							if (149760 - 136614 == 13146)
							{
								this.$self_$15512 = self_;
								if (62199 - 51044 == 11155)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00029BBC File Offset: 0x00027DBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CrystalBug.$RPC_crystalShard$15503.$(this.$mPos$15510, this.$tDir$15511, this.$self_$15512);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00029BD8 File Offset: 0x00027DD8
		internal static bool C4lEN5pd8r2E37sqWc6()
		{
			return true;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00029BDC File Offset: 0x00027DDC
		internal static bool uHmlSopJyd09PnZJS2p()
		{
			return false;
		}

		// Token: 0x040001E7 RID: 487
		internal Vector3 $mPos$15510;

		// Token: 0x040001E8 RID: 488
		internal Vector3 $tDir$15511;

		// Token: 0x040001E9 RID: 489
		internal CrystalBug $self_$15512;

		// Token: 0x02000053 RID: 83
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060001A8 RID: 424 RVA: 0x00029BE0 File Offset: 0x00027DE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CrystalBug self_)
			{
				if (104131 - 177510 != -73378)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (117706 - 530386 != -412679)
					{
						base..ctor();
						if (231169 - 98602 != 132568)
						{
							this.$mPos$15507 = mPos;
							if (283766 - 98535 == 185231)
							{
								this.$tDir$15508 = tDir;
								if (69628 - 541163 == -471535)
								{
									this.$self_$15509 = self_;
									if (41668 - 181910 == -140242)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00029CBC File Offset: 0x00027EBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280195 - 564674 != -284478)
				{
				}
				for (;;)
				{
					IL_66D:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_773;
					case 2:
						if (this.$self_$15509.mChar.actionState != "attack")
						{
							goto IL_140;
						}
						if (233985 - 344087 != -110102)
						{
							continue;
						}
						if (this.$self_$15509.mChar.myCommand != "crystalShard")
						{
							if (219183 - 98556 != 120627)
							{
								continue;
							}
							goto IL_140;
						}
						else
						{
							if (this.$self_$15509.crystalShard_ring)
							{
								if (124028 - 358638 != -234610)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$15509.crystalShard_ring, this.$self_$15509.transform.position + this.$self_$15509.transform.TransformDirection(new Vector3((float)0, 1.2f, 2.5f)), this.$self_$15509.transform.rotation);
								if (136028 - 393846 != -257818)
								{
									continue;
								}
							}
							this.$i$15504 = 0;
							if (246160 - 135593 == 110568)
							{
								continue;
							}
							while (this.$i$15504 < 5)
							{
								if (this.$self_$15509.mChar.isMine)
								{
									if (4124 - 387222 != -383098)
									{
										goto IL_66D;
									}
									this.$firePos$15505 = this.$self_$15509.transform.position + this.$self_$15509.transform.TransformDirection(new Vector3((float)0, 1.2f, 2.5f));
									if (179716 - 444523 == -264806)
									{
										goto IL_66D;
									}
									this.$fireDir$15506 = global::Math.rotateH(this.$self_$15509.transform.forward, (float)(this.$i$15504 * 30 - 60));
									if (91999 - 26644 != 65355)
									{
										goto IL_66D;
									}
									this.$self_$15509.RPC_crystalShard_fire(this.$firePos$15505, this.$fireDir$15506, 0);
									if (116905 - 76261 != 40644)
									{
										goto IL_66D;
									}
									if (PhotonClient.IsInitialized())
									{
										if (281479 - 302809 != -21330)
										{
											goto IL_66D;
										}
										this.$self_$15509.ActionEvent("RPC_crystalShard_fire", this.$firePos$15505, this.$fireDir$15506, 0);
										if (274244 - 325494 != -51250)
										{
											goto IL_66D;
										}
									}
								}
								this.$i$15504++;
								if (69274 - 590682 != -521408)
								{
									goto IL_66D;
								}
							}
							if (85549 - 362409 != -276859)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15509.mChar.actionState == "attack")
						{
							if (37803 - 255661 == -217857)
							{
								continue;
							}
							if (this.$self_$15509.mChar.myCommand == "crystalShard")
							{
								if (270002 - 497312 != -227310)
								{
									continue;
								}
								this.$self_$15509.mChar.moveSpeed = (float)0;
								if (237904 - 61893 == 176012)
								{
									continue;
								}
								this.$self_$15509.mChar.actionState = "standby";
								if (185183 - 158191 != 26992)
								{
									continue;
								}
								this.$self_$15509.mChar.actionTime = Time.time;
								if (7641 - 396926 == -389284)
								{
									continue;
								}
								this.$self_$15509.mChar.myCommand = "none";
								if (137368 - 207995 == -70626)
								{
									continue;
								}
								if (!this.$self_$15509.mChar.isMine)
								{
									if (261149 - 260522 == 628)
									{
										continue;
									}
									this.$self_$15509.mChar.nPosition = this.$self_$15509.transform.position;
									if (222445 - 385150 != -162705)
									{
										continue;
									}
									this.$self_$15509.mChar.oPosition = this.$self_$15509.transform.position;
									if (107697 - 245644 != -137947)
									{
										continue;
									}
									this.$self_$15509.mChar.nDirection = this.$self_$15509.transform.forward;
									if (133339 - 66873 == 66467)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (37177 - 106086 != -68908)
						{
							goto Block_21;
						}
						continue;
					default:
						if (263330 - 456448 == -193117)
						{
							continue;
						}
						break;
					}
					this.$self_$15509.mChar.actionState = "attack";
					if (50750 - 226879 != -176128)
					{
						this.$self_$15509.mChar.actionTime = Time.time;
						if (173468 - 475157 == -301689)
						{
							this.$self_$15509.mChar.myCommand = "crystalShard";
							if (83910 - 538215 == -454305)
							{
								this.$self_$15509.mChar.addTimeOut("crystalShard", (float)12);
								if (18105 - 370026 == -351921)
								{
									this.$self_$15509.transform.position = this.$mPos$15507;
									if (114931 - 572864 != -457932)
									{
										this.$self_$15509.transform.LookAt(this.$mPos$15507 + global::Math.vFlat(this.$tDir$15508));
										if (57567 - 476824 != -419256)
										{
											this.$self_$15509.animation.CrossFade("crystalShard");
											if (228787 - 29323 != 199465)
											{
												this.$self_$15509.animation.wrapMode = WrapMode.Once;
												if (259580 - 462682 != -203101)
												{
													this.$self_$15509.mChar.vMovement = this.$self_$15509.transform.forward;
													if (297881 - 121785 == 176096)
													{
														this.$self_$15509.mChar.moveSpeed = (float)0;
														if (86589 - 146583 == -59994)
														{
															goto IL_340;
														}
													}
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
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_140:
				Block_21:
				goto IL_773;
				IL_340:
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_773:
				return false;
			}

			// Token: 0x060001AA RID: 426 RVA: 0x0002A450 File Offset: 0x00028650
			internal static bool k4r33gpDApNGEHsYZQC()
			{
				return true;
			}

			// Token: 0x060001AB RID: 427 RVA: 0x0002A454 File Offset: 0x00028654
			internal static bool t4NIuepvKtIVA0gVNDy()
			{
				return false;
			}

			// Token: 0x040001EA RID: 490
			internal int $i$15504;

			// Token: 0x040001EB RID: 491
			internal Vector3 $firePos$15505;

			// Token: 0x040001EC RID: 492
			internal Vector3 $fireDir$15506;

			// Token: 0x040001ED RID: 493
			internal Vector3 $mPos$15507;

			// Token: 0x040001EE RID: 494
			internal Vector3 $tDir$15508;

			// Token: 0x040001EF RID: 495
			internal CrystalBug $self_$15509;
		}
	}

	// Token: 0x02000054 RID: 84
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_crystalBreath$15513 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060001AC RID: 428 RVA: 0x0002A458 File Offset: 0x00028658
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_crystalBreath$15513(Vector3 mPos, Vector3 tDir, CrystalBug self_)
		{
			if (126448 - 12106 != 114343)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (244447 - 305699 == -61252)
				{
					base..ctor();
					if (214407 - 384922 == -170515)
					{
						this.$mPos$15524 = mPos;
						if (287913 - 554598 != -266684)
						{
							this.$tDir$15525 = tDir;
							if (61996 - 443626 == -381630)
							{
								this.$self_$15526 = self_;
								if (133897 - 295245 != -161347)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0002A534 File Offset: 0x00028734
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CrystalBug.$RPC_crystalBreath$15513.$(this.$mPos$15524, this.$tDir$15525, this.$self_$15526);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0002A550 File Offset: 0x00028750
		internal static bool mQ1yrjpRLb85P8w8ENU()
		{
			return true;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0002A554 File Offset: 0x00028754
		internal static bool k0Gua4pwRpNfqLKE2Yj()
		{
			return false;
		}

		// Token: 0x040001F0 RID: 496
		internal Vector3 $mPos$15524;

		// Token: 0x040001F1 RID: 497
		internal Vector3 $tDir$15525;

		// Token: 0x040001F2 RID: 498
		internal CrystalBug $self_$15526;

		// Token: 0x02000055 RID: 85
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060001B0 RID: 432 RVA: 0x0002A558 File Offset: 0x00028758
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CrystalBug self_)
			{
				if (75088 - 150687 != -75598)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (283137 - 99818 == 183319)
					{
						base..ctor();
						if (291238 - 551439 != -260200)
						{
							this.$mPos$15521 = mPos;
							if (86605 - 301163 != -214557)
							{
								this.$tDir$15522 = tDir;
								if (208454 - 452870 != -244415)
								{
									this.$self_$15523 = self_;
									if (77195 - 594577 == -517382)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x0002A634 File Offset: 0x00028834
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (87113 - 437407 != -350294)
				{
				}
				for (;;)
				{
					IL_7F:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C0D;
					case 2:
						if (this.$self_$15523.mChar.actionState != "attack")
						{
							goto IL_B4;
						}
						if (70753 - 223499 != -152746)
						{
							continue;
						}
						if (this.$self_$15523.mChar.myCommand != "crystalBreath")
						{
							if (206192 - 337800 != -131608)
							{
								continue;
							}
							goto IL_B4;
						}
						else
						{
							if (this.$self_$15523.crystalBreath)
							{
								if (275564 - 508324 == -232759)
								{
									continue;
								}
								this.$self_$15523.mChar.createEffect(this.$self_$15523.crystalBreath, this.$self_$15523.transform.position, this.$self_$15523.transform.rotation);
								if (71320 - 584928 == -513607)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing CrystalBreath effect");
								if (262348 - 5705 == 256644)
								{
									continue;
								}
							}
							this.$i$15514 = 0;
							if (184662 - 424449 != -239786)
							{
								goto IL_BE7;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15523.mChar.actionState != "attack")
						{
							goto IL_1D9;
						}
						if (201161 - 351574 != -150413)
						{
							continue;
						}
						if (this.$self_$15523.mChar.myCommand != "crystalBreath")
						{
							if (225619 - 96414 != 129205)
							{
								continue;
							}
							goto IL_1D9;
						}
						else
						{
							if (this.$self_$15523.mChar.isMine)
							{
								if (40769 - 510015 != -469246)
								{
									continue;
								}
								this.$hitLayer$15515 = 130816 - (1 << this.$self_$15523.gameObject.layer);
								if (209554 - 455342 != -245788)
								{
									continue;
								}
								this.$hitList$15516 = Damage.FindRecTarget(this.$self_$15523.transform.position, this.$self_$15523.transform.forward, (float)1, (float)Mathf.Min(4 + this.$i$15514 * 2, 8), (float)Mathf.Min(8 + this.$i$15514 * 4, 20), (float)4, this.$hitLayer$15515);
								if (52403 - 41658 != 10745)
								{
									continue;
								}
								this.$$iterator$9896$15520 = UnityRuntimeServices.GetEnumerator(this.$hitList$15516);
								if (49935 - 439679 != -389744)
								{
									continue;
								}
								while (this.$$iterator$9896$15520.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9896$15520.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$15517 = (GameObject)obj2;
									if (68815 - 576280 != -507465)
									{
										goto IL_7F;
									}
									if (this.$self_$15523.mChar.hit(40, this.$hitObject$15517, this.$self_$15523.mChar.talAdjust(40), 0, 0, Vector3.zero) != 0)
									{
										if (18282 - 568313 != -550031)
										{
											goto IL_7F;
										}
										this.$hitChar$15518 = (CharacterControl)this.$hitObject$15517.GetComponent(typeof(CharacterControl));
										if (234941 - 20961 == 213981)
										{
											goto IL_7F;
										}
										UnityRuntimeServices.Update(this.$$iterator$9896$15520, this.$hitObject$15517);
										if (64461 - 78960 == -14498)
										{
											goto IL_7F;
										}
										if (this.$hitChar$15518)
										{
											if (194444 - 368970 != -174526)
											{
												goto IL_7F;
											}
											this.$$switch$817$15519 = this.$self_$15523.crystalBugType;
											if (89770 - 303705 == -213934)
											{
												goto IL_7F;
											}
											if (this.$$switch$817$15519 == eCrystalBugType.red)
											{
												if (262590 - 285232 == -22641)
												{
													goto IL_7F;
												}
												if (this.$hitChar$15518.getStatus("phantomBane") == null)
												{
													if (212035 - 468836 == -256800)
													{
														goto IL_7F;
													}
													this.$hitChar$15518.RPC_AddStatus("phantomBane", 4, Damage.getDebuff((float)15, this.$self_$15523.mChar.cha, this.$hitChar$15518.cha), 0, this.$self_$15523.mChar.ActorNr);
													if (187240 - 198602 == -11361)
													{
														goto IL_7F;
													}
												}
											}
											else if (this.$$switch$817$15519 == eCrystalBugType.yellow)
											{
												if (35997 - 437574 != -401577)
												{
													goto IL_7F;
												}
												if (this.$hitChar$15518.getStatus("burn") == null)
												{
													if (220841 - 74703 == 146139)
													{
														goto IL_7F;
													}
													this.$hitChar$15518.RPC_AddStatus("burn", 4, Damage.getDebuff((float)4, this.$self_$15523.mChar.cha, this.$hitChar$15518.cha), 0, this.$self_$15523.mChar.ActorNr);
													if (266973 - 459882 == -192908)
													{
														goto IL_7F;
													}
												}
											}
											else if (this.$$switch$817$15519 == eCrystalBugType.green)
											{
												if (53311 - 160275 == -106963)
												{
													goto IL_7F;
												}
												if (this.$hitChar$15518.getStatus("poison") == null)
												{
													if (2840 - 450323 == -447482)
													{
														goto IL_7F;
													}
													this.$hitChar$15518.RPC_AddStatus("poison", 4, Damage.getDebuff((float)12, this.$self_$15523.mChar.cha, this.$hitChar$15518.cha), 0, this.$self_$15523.mChar.ActorNr);
													if (56442 - 190816 != -134374)
													{
														goto IL_7F;
													}
												}
											}
											else if (this.$$switch$817$15519 == eCrystalBugType.blue)
											{
												if (234945 - 396596 != -161651)
												{
													goto IL_7F;
												}
												if (this.$hitChar$15518.getStatus("frost") == null)
												{
													if (39948 - 36170 != 3778)
													{
														goto IL_7F;
													}
													this.$hitChar$15518.RPC_AddStatus("frost", 2, Damage.getDebuff((float)3, this.$self_$15523.mChar.cha, this.$hitChar$15518.cha), 0, this.$self_$15523.mChar.ActorNr);
													if (296675 - 246719 == 49957)
													{
														goto IL_7F;
													}
												}
											}
										}
									}
								}
								if (274258 - 215156 == 59103)
								{
									continue;
								}
							}
							this.$i$15514++;
							if (202157 - 7017 != 195141)
							{
								goto IL_BE7;
							}
							continue;
						}
						break;
					default:
						if (109422 - 387430 == -278007)
						{
							continue;
						}
						break;
					}
					this.$self_$15523.mChar.actionState = "attack";
					if (20326 - 412880 == -392553)
					{
						continue;
					}
					this.$self_$15523.mChar.actionTime = Time.time;
					if (251195 - 11574 == 239622)
					{
						continue;
					}
					this.$self_$15523.mChar.myCommand = "crystalBreath";
					if (53659 - 96487 != -42828)
					{
						continue;
					}
					this.$self_$15523.mChar.addTimeOut("crystalBreath", (float)30);
					if (238946 - 426727 != -187781)
					{
						continue;
					}
					this.$self_$15523.transform.position = this.$mPos$15521;
					if (244904 - 108229 != 136675)
					{
						continue;
					}
					this.$self_$15523.transform.LookAt(this.$mPos$15521 + global::Math.vFlat(this.$tDir$15522));
					if (58329 - 1880 == 56450)
					{
						continue;
					}
					this.$self_$15523.animation.CrossFade("crystalBreath");
					if (153227 - 309302 == -156074)
					{
						continue;
					}
					this.$self_$15523.animation.wrapMode = WrapMode.Once;
					if (200099 - 110947 != 89152)
					{
						continue;
					}
					this.$self_$15523.mChar.vMovement = this.$self_$15523.transform.forward;
					if (200704 - 9304 == 191401)
					{
						continue;
					}
					this.$self_$15523.mChar.moveSpeed = (float)0;
					if (250447 - 214043 != 36404)
					{
						continue;
					}
					goto IL_6F4;
					IL_BE7:
					if (this.$i$15514 < 8)
					{
						goto IL_AE4;
					}
					if (76463 - 594550 != -518086)
					{
						if (this.$self_$15523.mChar.actionState == "attack")
						{
							if (46946 - 348998 == -302051)
							{
								continue;
							}
							if (this.$self_$15523.mChar.myCommand == "crystalBreath")
							{
								if (123548 - 141220 == -17671)
								{
									continue;
								}
								this.$self_$15523.mChar.moveSpeed = (float)0;
								if (294410 - 598475 != -304065)
								{
									continue;
								}
								this.$self_$15523.mChar.actionState = "standby";
								if (173844 - 431568 != -257724)
								{
									continue;
								}
								this.$self_$15523.mChar.actionTime = Time.time;
								if (206532 - 530397 != -323865)
								{
									continue;
								}
								this.$self_$15523.mChar.myCommand = "none";
								if (277202 - 420455 == -143252)
								{
									continue;
								}
								if (!this.$self_$15523.mChar.isMine)
								{
									if (294532 - 169598 == 124935)
									{
										continue;
									}
									this.$self_$15523.mChar.nPosition = this.$self_$15523.transform.position;
									if (140421 - 76304 != 64117)
									{
										continue;
									}
									this.$self_$15523.mChar.oPosition = this.$self_$15523.transform.position;
									if (250809 - 142456 != 108353)
									{
										continue;
									}
									this.$self_$15523.mChar.nDirection = this.$self_$15523.transform.forward;
									if (29723 - 599361 == -569637)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (86921 - 435641 == -348720)
						{
							break;
						}
					}
				}
				IL_B4:
				IL_1D9:
				goto IL_C0D;
				IL_6F4:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_AE4:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_C0D:
				return false;
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x0002B260 File Offset: 0x00029460
			internal static bool n2S453pqu8xPGCoNFqy()
			{
				return true;
			}

			// Token: 0x060001B3 RID: 435 RVA: 0x0002B264 File Offset: 0x00029464
			internal static bool OuajQWp7NcWMyGA6pmO()
			{
				return false;
			}

			// Token: 0x040001F3 RID: 499
			internal int $i$15514;

			// Token: 0x040001F4 RID: 500
			internal int $hitLayer$15515;

			// Token: 0x040001F5 RID: 501
			internal UnityScript.Lang.Array $hitList$15516;

			// Token: 0x040001F6 RID: 502
			internal GameObject $hitObject$15517;

			// Token: 0x040001F7 RID: 503
			internal CharacterControl $hitChar$15518;

			// Token: 0x040001F8 RID: 504
			internal eCrystalBugType $$switch$817$15519;

			// Token: 0x040001F9 RID: 505
			internal IEnumerator $$iterator$9896$15520;

			// Token: 0x040001FA RID: 506
			internal Vector3 $mPos$15521;

			// Token: 0x040001FB RID: 507
			internal Vector3 $tDir$15522;

			// Token: 0x040001FC RID: 508
			internal CrystalBug $self_$15523;
		}
	}

	// Token: 0x02000056 RID: 86
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$15527 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x0002B268 File Offset: 0x00029468
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$15527(UnityScript.Lang.Array nArray, CrystalBug self_)
		{
			if (248655 - 213664 != 34992)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (146454 - 498831 == -352377)
				{
					base..ctor();
					if (139352 - 466854 == -327502)
					{
						this.$nArray$15532 = nArray;
						if (118272 - 216234 == -97962)
						{
							this.$self_$15533 = self_;
							if (94446 - 216639 != -122192)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0002B324 File Offset: 0x00029524
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CrystalBug.$RPC_ko$15527.$(this.$nArray$15532, this.$self_$15533);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0002B338 File Offset: 0x00029538
		internal static bool wjPJnIpPrJ5OPSvgRFg()
		{
			return true;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0002B33C File Offset: 0x0002953C
		internal static bool aDTXOKp0BUqRKUfpvhe()
		{
			return false;
		}

		// Token: 0x040001FD RID: 509
		internal UnityScript.Lang.Array $nArray$15532;

		// Token: 0x040001FE RID: 510
		internal CrystalBug $self_$15533;

		// Token: 0x02000057 RID: 87
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060001B8 RID: 440 RVA: 0x0002B340 File Offset: 0x00029540
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CrystalBug self_)
			{
				if (299108 - 368819 != -69711)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (86553 - 224091 != -137537)
					{
						base..ctor();
						if (200903 - 142441 != 58463)
						{
							this.$nArray$15530 = nArray;
							if (206346 - 363789 == -157443)
							{
								this.$self_$15531 = self_;
								if (199036 - 416291 == -217255)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060001B9 RID: 441 RVA: 0x0002B3FC File Offset: 0x000295FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (58352 - 413698 != -355345)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4F0;
					case 2:
						if (this.$self_$15531.mChar.actionState != "ko")
						{
							if (72717 - 465652 != -392935)
							{
								continue;
							}
							goto IL_25C;
						}
						else
						{
							this.$self_$15531.animation.Play("getUp");
							if (28699 - 181331 != -152632)
							{
								continue;
							}
							this.$self_$15531.animation.wrapMode = WrapMode.Once;
							if (29602 - 556909 != -527307)
							{
								continue;
							}
							goto IL_D9;
						}
						break;
					case 3:
						if (this.$self_$15531.mChar.actionState != "ko")
						{
							if (232194 - 477326 != -245131)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$self_$15531.mChar.actionState = "standby";
							if (138857 - 405784 != -266927)
							{
								continue;
							}
							this.$self_$15531.mChar.actionTime = Time.time;
							if (247576 - 174479 == 73098)
							{
								continue;
							}
							this.$self_$15531.mChar.myCommand = "none";
							if (72787 - 570963 != -498176)
							{
								continue;
							}
							this.$self_$15531.mChar.ko = this.$self_$15531.mChar.mko;
							if (170788 - 174468 == -3679)
							{
								continue;
							}
							this.YieldDefault(1);
							if (249992 - 409983 != -159990)
							{
								goto IL_4F0;
							}
							continue;
						}
						break;
					default:
						if (23870 - 296993 == -273122)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15531.mChar.actionState == "ko")
					{
						goto IL_325;
					}
					if (217020 - 209245 == 7775)
					{
						if (this.$self_$15531.mChar.actionState == "dead")
						{
							if (52190 - 45845 == 6345)
							{
								goto IL_325;
							}
						}
						else
						{
							this.$mPos$15528 = (Vector3)this.$nArray$15530[0];
							if (145831 - 64746 != 81086)
							{
								this.$mDir$15529 = (Vector3)this.$nArray$15530[1];
								if (111863 - 396398 != -284534)
								{
									this.$self_$15531.mChar.ko = 0;
									if (122222 - 338529 == -216307)
									{
										this.$self_$15531.mChar.actionState = "ko";
										if (50562 - 67221 != -16658)
										{
											this.$self_$15531.mChar.actionTime = Time.time;
											if (298251 - 585310 != -287058)
											{
												this.$self_$15531.mChar.myCommand = "none";
												if (117537 - 325827 == -208290)
												{
													this.$self_$15531.mChar.vMovement = Vector3.zero;
													if (226327 - 466089 == -239762)
													{
														this.$self_$15531.mChar.moveSpeed = (float)0;
														if (282135 - 76684 != 205452)
														{
															this.$self_$15531.animation.Play("ko");
															if (196794 - 218149 != -21354)
															{
																this.$self_$15531.animation.wrapMode = WrapMode.Once;
																if (101959 - 307884 == -205925)
																{
																	if (!this.$self_$15531.crystalBug_cryFx)
																	{
																		goto IL_3EF;
																	}
																	if (16772 - 192538 != -175765)
																	{
																		this.$self_$15531.audio.PlayOneShot(this.$self_$15531.crystalBug_cryFx);
																		if (154905 - 575011 != -420105)
																		{
																			goto Block_21;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_D9:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_7:
				IL_25C:
				IL_325:
				goto IL_4F0;
				Block_21:
				IL_3EF:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4F0:
				return false;
			}

			// Token: 0x060001BA RID: 442 RVA: 0x0002B90C File Offset: 0x00029B0C
			internal static bool wdZsxWpbST7LTCdrf16()
			{
				return true;
			}

			// Token: 0x060001BB RID: 443 RVA: 0x0002B910 File Offset: 0x00029B10
			internal static bool ho8m7Opu7F047JH2TJI()
			{
				return false;
			}

			// Token: 0x040001FF RID: 511
			internal Vector3 $mPos$15528;

			// Token: 0x04000200 RID: 512
			internal Vector3 $mDir$15529;

			// Token: 0x04000201 RID: 513
			internal UnityScript.Lang.Array $nArray$15530;

			// Token: 0x04000202 RID: 514
			internal CrystalBug $self_$15531;
		}
	}

	// Token: 0x02000058 RID: 88
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$15534 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060001BC RID: 444 RVA: 0x0002B914 File Offset: 0x00029B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$15534(UnityScript.Lang.Array nArray, CrystalBug self_)
		{
			if (183546 - 2368 != 181179)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (52108 - 419948 != -367839)
				{
					base..ctor();
					if (266551 - 278912 == -12361)
					{
						this.$nArray$15545 = nArray;
						if (10068 - 158857 == -148789)
						{
							this.$self_$15546 = self_;
							if (278188 - 223647 != 54542)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0002B9D0 File Offset: 0x00029BD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CrystalBug.$RPC_dead$15534.$(this.$nArray$15545, this.$self_$15546);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0002B9E4 File Offset: 0x00029BE4
		internal static bool AO9TABpIFlEXtdcalwk()
		{
			return true;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0002B9E8 File Offset: 0x00029BE8
		internal static bool Yb8vQ5pBMceHxrfMxVs()
		{
			return false;
		}

		// Token: 0x04000203 RID: 515
		internal UnityScript.Lang.Array $nArray$15545;

		// Token: 0x04000204 RID: 516
		internal CrystalBug $self_$15546;

		// Token: 0x02000059 RID: 89
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060001C0 RID: 448 RVA: 0x0002B9EC File Offset: 0x00029BEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CrystalBug self_)
			{
				if (221886 - 492253 != -270367)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (233737 - 460555 != -226817)
					{
						base..ctor();
						if (90867 - 106671 != -15803)
						{
							this.$nArray$15543 = nArray;
							if (283011 - 559365 == -276354)
							{
								this.$self_$15544 = self_;
								if (97385 - 387334 == -289949)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060001C1 RID: 449 RVA: 0x0002BAA8 File Offset: 0x00029CA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (182746 - 580384 != -397637)
				{
				}
				for (;;)
				{
					IL_311:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6EF;
					case 2:
						if (this.$self_$15544.mChar.actionState != "dead")
						{
							if (166700 - 152850 != 13851)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							Camera.main.SendMessage("AddCamereShake", 2f);
							if (298817 - 266107 != 32710)
							{
								continue;
							}
							goto IL_6A0;
						}
						break;
					case 3:
						if (this.$self_$15544.mChar.actionState != "dead")
						{
							if (278142 - 597674 != -319532)
							{
								continue;
							}
							goto IL_5DD;
						}
						else
						{
							if (!this.$self_$15544.mChar.isPlayer)
							{
								if (262035 - 586967 != -324932)
								{
									continue;
								}
								this.$mTailCollider$15537 = global::Math.findChildObject(this.$self_$15544.transform, "Collider");
								if (35803 - 49396 == -13592)
								{
									continue;
								}
								if (this.$mTailCollider$15537)
								{
									if (189756 - 498295 == -308538)
									{
										continue;
									}
									UnityEngine.Object.Destroy(this.$mTailCollider$15537.gameObject);
									if (23662 - 516030 == -492367)
									{
										continue;
									}
								}
								this.$mFriendList$15538 = GameObject.FindGameObjectsWithTag("Enemy");
								if (129051 - 564164 != -435113)
								{
									continue;
								}
								this.$$11016$15540 = 0;
								if (63421 - 388449 == -325027)
								{
									continue;
								}
								this.$$11017$15541 = this.$mFriendList$15538;
								if (284846 - 116097 != 168749)
								{
									continue;
								}
								this.$$11018$15542 = this.$$11017$15541.Length;
								if (4009 - 294726 == -290716)
								{
									continue;
								}
								while (this.$$11016$15540 < this.$$11018$15542)
								{
									if (this.$$11017$15541[this.$$11016$15540] != this.$self_$15544.gameObject)
									{
										if (148663 - 80067 == 68597)
										{
											goto IL_311;
										}
										Physics.IgnoreCollision(this.$$11017$15541[this.$$11016$15540].collider, this.$self_$15544.gameObject.collider, true);
										if (9274 - 360253 != -350979)
										{
											goto IL_311;
										}
									}
									this.$$11016$15540++;
									if (227017 - 354132 != -127115)
									{
										goto IL_311;
									}
								}
								if (226584 - 466202 != -239618)
								{
									continue;
								}
							}
							else if (this.$self_$15544.mChar.isMine)
							{
								if (250573 - 461288 != -210715)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$15544.gameObject);
								if (201673 - 556793 == -355119)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (110717 - 115046 != -4329)
							{
								continue;
							}
							goto IL_6EF;
						}
						break;
					default:
						if (184845 - 325794 != -140949)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15544.mChar.actionState == "dead")
					{
						if (154642 - 595609 != -440966)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$15535 = (Vector3)this.$nArray$15543[0];
						if (124722 - 207283 != -82560)
						{
							this.$myDirection$15536 = (Vector3)this.$nArray$15543[1];
							if (278374 - 546820 == -268446)
							{
								this.$self_$15544.transform.position = this.$myPosition$15535;
								if (46139 - 349873 != -303733)
								{
									this.$self_$15544.transform.LookAt(this.$myPosition$15535 + this.$myDirection$15536);
									if (89262 - 345577 != -256314)
									{
										this.$self_$15544.mChar.hp = 0;
										if (217058 - 401432 != -184373)
										{
											this.$self_$15544.mChar.actionState = "dead";
											if (18001 - 296566 == -278565)
											{
												this.$self_$15544.mChar.actionTime = Time.time;
												if (206565 - 214085 == -7520)
												{
													this.$self_$15544.mChar.myCommand = "none";
													if (115400 - 574604 != -459203)
													{
														this.$self_$15544.mChar.vMovement = Vector3.zero;
														if (231080 - 251845 != -20764)
														{
															this.$self_$15544.mChar.moveSpeed = (float)0;
															if (161109 - 480207 == -319098)
															{
																this.$self_$15544.animation.Rewind();
																if (162895 - 500391 != -337495)
																{
																	this.$self_$15544.animation.Play("dead");
																	if (233118 - 163629 != 69490)
																	{
																		this.$self_$15544.animation.wrapMode = WrapMode.Once;
																		if (122300 - 464004 == -341704)
																		{
																			if (!this.$self_$15544.crystalBug_cryFx)
																			{
																				goto IL_2C2;
																			}
																			if (159465 - 22959 != 136507)
																			{
																				this.$self_$15544.audio.PlayOneShot(this.$self_$15544.crystalBug_cryFx);
																				if (63717 - 78421 != -14703)
																				{
																					goto Block_23;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_6EF;
				IL_2C2:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_20:
				goto IL_6EF;
				Block_23:
				goto IL_2C2;
				IL_5DD:
				goto IL_6EF;
				IL_6A0:
				return this.Yield(3, new WaitForSeconds(2.2f));
				IL_6EF:
				return false;
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x0002C1B8 File Offset: 0x0002A3B8
			internal static bool XKr7lxpewqkToZZpndp()
			{
				return true;
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x0002C1BC File Offset: 0x0002A3BC
			internal static bool ilZXJhpr6v1b3Bi82OX()
			{
				return false;
			}

			// Token: 0x04000205 RID: 517
			internal Vector3 $myPosition$15535;

			// Token: 0x04000206 RID: 518
			internal Vector3 $myDirection$15536;

			// Token: 0x04000207 RID: 519
			internal Transform $mTailCollider$15537;

			// Token: 0x04000208 RID: 520
			internal GameObject[] $mFriendList$15538;

			// Token: 0x04000209 RID: 521
			internal GameObject $nFriend$15539;

			// Token: 0x0400020A RID: 522
			internal int $$11016$15540;

			// Token: 0x0400020B RID: 523
			internal GameObject[] $$11017$15541;

			// Token: 0x0400020C RID: 524
			internal int $$11018$15542;

			// Token: 0x0400020D RID: 525
			internal UnityScript.Lang.Array $nArray$15543;

			// Token: 0x0400020E RID: 526
			internal CrystalBug $self_$15544;
		}
	}
}
