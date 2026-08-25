using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DEB RID: 3563
[Serializable]
public class ZombieFish : MonoBehaviour
{
	// Token: 0x06005087 RID: 20615 RVA: 0x009DEE6C File Offset: 0x009DD06C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZombieFish()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005088 RID: 20616 RVA: 0x009DEE7C File Offset: 0x009DD07C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (178802 - 389541 != -210738)
		{
		}
		for (;;)
		{
			this.JP9cQbavsoZ = this.transform;
			if (48488 - 111424 != -62935)
			{
				this.cBbcQdT5F8l = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (137057 - 210141 != -73083)
				{
					this.cBbcQdT5F8l.actionState = "standby";
					if (90343 - 366522 != -276178)
					{
						this.cBbcQdT5F8l.actionTime = Time.time;
						if (44445 - 503206 == -458761)
						{
							this.cBbcQdT5F8l.myCommand = "none";
							if (184051 - 489591 != -305539)
							{
								this.cBbcQdT5F8l.hp = (this.cBbcQdT5F8l.mhp = 650);
								if (10210 - 527743 == -517533)
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

	// Token: 0x06005089 RID: 20617 RVA: 0x009DEFC8 File Offset: 0x009DD1C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.cBbcQdT5F8l.isMine = true;
		}
	}

	// Token: 0x0600508A RID: 20618 RVA: 0x009DEFE4 File Offset: 0x009DD1E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (34480 - 559649 != -525168)
		{
		}
		for (;;)
		{
			if (this.cBbcQdT5F8l.isControlled)
			{
				if (18004 - 263006 != -245002)
				{
					continue;
				}
				if (!(this.cBbcQdT5F8l.actionState == "standby"))
				{
					if (46335 - 454563 != -408228)
					{
						continue;
					}
					if (!(this.cBbcQdT5F8l.actionState == "run"))
					{
						goto IL_45B;
					}
					if (37624 - 206087 == -168462)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (150356 - 282972 == -132615)
				{
					continue;
				}
			}
			IL_45B:
			if (this.cBbcQdT5F8l.ko <= 0)
			{
				if (299463 - 38524 == 260940)
				{
					continue;
				}
				if (this.cBbcQdT5F8l.actionState != "dead")
				{
					if (87064 - 533980 != -446916)
					{
						continue;
					}
					if (this.cBbcQdT5F8l.isMine)
					{
						if (226415 - 489306 != -262891)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (21959 - 284784 != -262825)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (285563 - 18981 != 266582)
						{
							continue;
						}
						this.cBbcQdT5F8l.DeadEvent();
						if (54446 - 408720 != -354273)
						{
							break;
						}
						continue;
					}
					else
					{
						this.cBbcQdT5F8l.ko = 1;
						if (175947 - 21806 != 154142)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.cBbcQdT5F8l.ko <= 0)
			{
				break;
			}
			if (156925 - 113222 == 43703)
			{
				if (this.cBbcQdT5F8l.hp > 0)
				{
					break;
				}
				if (274928 - 97169 != 177760)
				{
					if (!(this.cBbcQdT5F8l.actionState != "ko"))
					{
						break;
					}
					if (236992 - 579042 != -342049)
					{
						if (!(this.cBbcQdT5F8l.actionState != "dead"))
						{
							break;
						}
						if (229469 - 502919 != -273449)
						{
							if (this.cBbcQdT5F8l.isMine)
							{
								if (40717 - 230928 != -190210)
								{
									if (this.cBbcQdT5F8l.ko > 7)
									{
										if (368 - 497411 != -497042)
										{
											this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
											{
												this.transform.position,
												this.transform.forward
											})));
											if (216110 - 140472 == 75638)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (283347 - 17682 != 265666)
												{
													this.cBbcQdT5F8l.KoEvent();
													if (195184 - 17463 != 177722)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
										{
											this.transform.position,
											this.transform.forward
										})));
										if (239728 - 73991 != 165738)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (151723 - 467899 == -316176)
											{
												this.cBbcQdT5F8l.DeadEvent();
												if (43551 - 225223 != -181671)
												{
													break;
												}
											}
										}
									}
								}
							}
							else
							{
								this.cBbcQdT5F8l.hp = 1;
								if (225914 - 399005 == -173091)
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

	// Token: 0x0600508B RID: 20619 RVA: 0x009DF4B0 File Offset: 0x009DD6B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (180844 - 59827 != 121017)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (80120 - 191988 != -111867)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (21548 - 380767 != -359218)
				{
					if (274642 - 532723 == -258081)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (169350 - 373790 != -204440)
							{
								continue;
							}
							v = 1;
							if (112509 - 547392 == -434882)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (255049 - 394973 != -139924)
							{
								continue;
							}
							v = -1;
							if (83298 - 442736 == -359437)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (125952 - 324834 == -198881)
							{
								continue;
							}
							v = 11;
							if (29360 - 389954 == -360593)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack_hit")
						{
							if (266907 - 351369 != -84462)
							{
								continue;
							}
							v = -11;
							if (8364 - 567616 == -559251)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (218202 - 390892 == -172689)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (275127 - 467404 != -192276)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (221836 - 230110 != -8273)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (21560 - 472117 == -450557)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (262036 - 530678 == -268642)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (256157 - 493530 != -237372)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (260890 - 430132 != -169241)
											{
												Hashtable hashtable = new Hashtable();
												if (223507 - 233307 == -9800)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (91488 - 146394 == -54906)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (116993 - 382204 != -265210)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (50256 - 537268 != -487011)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (199885 - 348997 == -149112)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (151398 - 393111 == -241713)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (112783 - 249635 != -136851)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (17684 - 302089 != -284404)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (120243 - 491149 == -370906)
																				{
																					PhotonClient.SendEvent(this.cBbcQdT5F8l.ActorNr, 74, hashtable, true, true);
																					if (32666 - 377191 != -344524)
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

	// Token: 0x0600508C RID: 20620 RVA: 0x009DF9C8 File Offset: 0x009DDBC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (44520 - 19911 != 24609)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (138095 - 443252 != -305156)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (137851 - 438629 != -300777)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (78 - 236068 == -235990)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (7859 - 335426 == -327567)
						{
							int num3 = num;
							if (165258 - 105450 != 59809)
							{
								if (num3 == 1)
								{
									if (190642 - 15940 != 174703)
									{
										if (this.cBbcQdT5F8l.isMine)
										{
											break;
										}
										if (107699 - 330613 == -222914)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (237216 - 393858 == -156642)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (154957 - 98653 != 56305)
									{
										if (this.cBbcQdT5F8l.isMine)
										{
											break;
										}
										if (237522 - 354544 == -117022)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (274596 - 216757 != 57840)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (63615 - 168975 == -105360)
									{
										if (this.cBbcQdT5F8l.isMine)
										{
											break;
										}
										if (37305 - 227076 == -189771)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (271699 - 201434 == 70265)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (239515 - 543641 != -304125)
									{
										if (this.cBbcQdT5F8l.isMine)
										{
											break;
										}
										if (190378 - 284409 != -94030)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (146347 - 286840 != -140492)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (101182 - 138524 == -37342)
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

	// Token: 0x0600508D RID: 20621 RVA: 0x009DFD4C File Offset: 0x009DDF4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (79326 - 318883 != -239557)
		{
		}
		for (;;)
		{
			float num = this.cBbcQdT5F8l.moveSpeed;
			if (47716 - 533229 == -485513)
			{
				float runSpeed = this.cBbcQdT5F8l.runSpeed;
				if (288642 - 225200 != 63443)
				{
					Vector3 a = default(Vector3);
					if (157745 - 18106 == 139639)
					{
						Vector3 vector = Vector3.zero;
						if (26351 - 266414 == -240063)
						{
							float num2 = (float)0;
							if (46603 - 500483 == -453880)
							{
								if (this.cBbcQdT5F8l.isMine)
								{
									if (239159 - 479929 != -240770)
									{
										continue;
									}
									if ((this.cBbcQdT5F8l.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (124589 - 35709 == 88881)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (132834 - 343254 != -210420)
										{
											continue;
										}
										a.y = (float)0;
										if (37637 - 303263 == -265625)
										{
											continue;
										}
										a = a.normalized;
										if (198850 - 282297 != -83447)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (38332 - 572145 != -533813)
										{
											continue;
										}
										vector = vector.normalized;
										if (21772 - 365928 == -344155)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (151725 - 120851 != 30874)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (191969 - 537921 != -345952)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (168420 - 411096 == -242675)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (290644 - 431022 == -140377)
														{
															continue;
														}
														this.cBbcQdT5F8l.actionState = "run";
														if (271509 - 148981 == 122529)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (133107 - 53170 != 79937)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (142978 - 385199 != -242221)
														{
															continue;
														}
														this.animation.Play("run");
														if (195766 - 480246 != -284480)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (287987 - 143275 != 144712)
														{
															continue;
														}
														goto IL_269;
													}
												}
											}
										}
										this.cBbcQdT5F8l.actionState = "standby";
										if (236220 - 452068 != -215848)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (75839 - 39514 != 36325)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (121338 - 367989 != -246651)
											{
												continue;
											}
											num = (float)0;
											if (197530 - 365354 == -167823)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (220487 - 258422 == -37934)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (250475 - 213296 != 37179)
										{
											continue;
										}
									}
									IL_269:;
								}
								else
								{
									vector = global::Math.vFlat(this.cBbcQdT5F8l.nPosition - this.transform.position);
									if (149773 - 155645 == -5871)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (263265 - 552055 == -288789)
									{
										continue;
									}
									if (this.cBbcQdT5F8l.nSpeed != (float)0)
									{
										if (183958 - 160901 != 23057)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (29961 - 204289 != -174328)
											{
												continue;
											}
											this.transform.position = this.cBbcQdT5F8l.nPosition;
											if (222007 - 106493 == 115515)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (46392 - 20154 == 26239)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (109942 - 483983 == -374040)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (200461 - 294066 == -93604)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.cBbcQdT5F8l.nSpeed, (float)10 * Time.deltaTime);
												if (203612 - 293709 == -90096)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (21514 - 152946 != -131432)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (235976 - 12877 != 223099)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (70589 - 60260 == 10330)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (283599 - 100219 != 183380)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (48253 - 492388 != -444135)
											{
												continue;
											}
										}
										else if (Time.time > this.cBbcQdT5F8l.nSpeed + 0.3f)
										{
											if (77077 - 2809 != 74268)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (162157 - 537784 == -375626)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (186960 - 549220 == -362259)
												{
													continue;
												}
												num = (float)0;
												if (126254 - 388158 != -261904)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.cBbcQdT5F8l.nDirection);
											if (221189 - 114820 != 106369)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (109847 - 69188 == 40660)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (288665 - 186120 != 102545)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (49003 - 297309 == -248305)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (195371 - 17350 == 178022)
											{
												continue;
											}
											this.transform.position = this.cBbcQdT5F8l.nPosition;
											if (120527 - 287873 != -167346)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (44468 - 335535 == -291066)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (9111 - 419452 == -410340)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (88652 - 282240 == -193587)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (85936 - 115189 == -29252)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (274104 - 22430 == 251675)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (12894 - 513513 == -500618)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (26724 - 62241 == -35516)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.cBbcQdT5F8l.nDirection);
											if (165870 - 549708 == -383837)
											{
												continue;
											}
											num = (float)0;
											if (276602 - 131104 != 145498)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (221909 - 49537 != 172372)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (280054 - 423445 != -143391)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (91352 - 275908 != -184556)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (39492 - 478371 != -438879)
										{
											continue;
										}
									}
								}
								this.cBbcQdT5F8l.vMovement = vector;
								if (28417 - 376289 != -347871)
								{
									this.cBbcQdT5F8l.moveSpeed = num;
									if (206777 - 202287 == 4490)
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

	// Token: 0x0600508E RID: 20622 RVA: 0x009E08B0 File Offset: 0x009DEAB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (10820 - 165672 != -154851)
		{
		}
		for (;;)
		{
			if (!this.cBbcQdT5F8l.isMine)
			{
				if (85513 - 369693 != -284179)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (155683 - 22486 == 133197)
				{
					Vector3 vector = a - this.transform.position;
					if (124691 - 84165 != 40527)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (274983 - 440204 == -165221)
						{
							CharacterControl characterControl = null;
							if (169498 - 180916 == -11418)
							{
								if (129752 - 533295 != -403542)
								{
									if (gameObject)
									{
										if (57773 - 356435 == -298661)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (45205 - 265195 == -219989)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (80467 - 583501 == -503033)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (108246 - 173965 != -65719)
										{
											continue;
										}
									}
									if (!(this.cBbcQdT5F8l.actionState == "standby"))
									{
										if (108352 - 578281 == -469928)
										{
											continue;
										}
										if (!(this.cBbcQdT5F8l.actionState == "run"))
										{
											break;
										}
										if (22523 - 526950 == -504426)
										{
											continue;
										}
									}
									if (this.cBbcQdT5F8l.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (69315 - 550499 == -481184)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (47329 - 83605 == -36276)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (203714 - 366754 == -163040)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (114409 - 291732 == -177323)
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

	// Token: 0x0600508F RID: 20623 RVA: 0x009E0BA8 File Offset: 0x009DEDA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (29033 - 196522 != -167488)
		{
		}
		for (;;)
		{
			if (!this.cBbcQdT5F8l.isMine)
			{
				if (116376 - 186468 == -70092)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (196986 - 441676 == -244690)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (234543 - 379816 == -145273)
					{
						Vector3 normalized = vector.normalized;
						if (248535 - 137876 == 110659)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (126382 - 47220 == 79162)
							{
								CharacterControl characterControl = null;
								if (267230 - 177642 == 89588)
								{
									if (84593 - 539063 != -454469)
									{
										if (gameObject)
										{
											if (170200 - 386842 != -216642)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (297285 - 326369 == -29083)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (6240 - 303243 == -297002)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (155939 - 65435 == 90505)
											{
												continue;
											}
										}
										if (!(this.cBbcQdT5F8l.actionState == "standby"))
										{
											if (210205 - 438932 != -228727)
											{
												continue;
											}
											if (!(this.cBbcQdT5F8l.actionState == "run"))
											{
												break;
											}
											if (230440 - 279427 != -48987)
											{
												continue;
											}
										}
										if (this.cBbcQdT5F8l.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (118241 - 308937 == -190696)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
											if (212688 - 532940 != -320251)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (91250 - 26491 == 64759)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
													if (33897 - 448583 == -414686)
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

	// Token: 0x06005090 RID: 20624 RVA: 0x009E0EC8 File Offset: 0x009DF0C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06005091 RID: 20625 RVA: 0x009E0ECC File Offset: 0x009DF0CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ZombieFish.$RPC_nAttack$33747(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005092 RID: 20626 RVA: 0x009E0EDC File Offset: 0x009DF0DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (79416 - 242839 != -163423)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (87945 - 110940 == -22995)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (270753 - 570681 == -299928)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (173218 - 82657 != 90562)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005093 RID: 20627 RVA: 0x009E0F94 File Offset: 0x009DF194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ZombieFish.$RPC_cAttack$33761(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005094 RID: 20628 RVA: 0x009E0FA4 File Offset: 0x009DF1A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (10095 - 91117 != -81021)
		{
		}
		for (;;)
		{
			if (this.cAttack_hit)
			{
				if (170514 - 270641 == -100127)
				{
					UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (10229 - 345293 != -335063)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find cAttack_hit effect");
				if (39652 - 591860 != -552207)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005095 RID: 20629 RVA: 0x009E105C File Offset: 0x009DF25C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new ZombieFish.$RPC_ko$33773(nArray, this).GetEnumerator();
	}

	// Token: 0x06005096 RID: 20630 RVA: 0x009E106C File Offset: 0x009DF26C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new ZombieFish.$RPC_dead$33780(nArray, this).GetEnumerator();
	}

	// Token: 0x06005097 RID: 20631 RVA: 0x009E107C File Offset: 0x009DF27C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005098 RID: 20632 RVA: 0x009E1080 File Offset: 0x009DF280
	internal static bool rWdsfZ5BsNUjxHjTTeuh()
	{
		return true;
	}

	// Token: 0x06005099 RID: 20633 RVA: 0x009E1084 File Offset: 0x009DF284
	internal static bool TmR9wx5B9lNG62ICPZsQ()
	{
		return false;
	}

	// Token: 0x04005A05 RID: 23045
	private Transform JP9cQbavsoZ;

	// Token: 0x04005A06 RID: 23046
	private CharacterControl cBbcQdT5F8l;

	// Token: 0x04005A07 RID: 23047
	public GameObject nAttack_ring;

	// Token: 0x04005A08 RID: 23048
	public GameObject nAttack_hit;

	// Token: 0x04005A09 RID: 23049
	public GameObject cAttack_ring;

	// Token: 0x04005A0A RID: 23050
	public GameObject cAttack_hit;

	// Token: 0x04005A0B RID: 23051
	public GameObject ko_ring;

	// Token: 0x04005A0C RID: 23052
	public GameObject dead_ring;

	// Token: 0x04005A0D RID: 23053
	public GameObject deadEffect;

	// Token: 0x02000DEC RID: 3564
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33747 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600509A RID: 20634 RVA: 0x009E1088 File Offset: 0x009DF288
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33747(Vector3 mPos, Vector3 tDir, ZombieFish self_)
		{
			if (119657 - 326126 != -206469)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (220315 - 16647 == 203668)
				{
					base..ctor();
					if (291766 - 154063 == 137703)
					{
						this.$mPos$33758 = mPos;
						if (78123 - 266227 == -188104)
						{
							this.$tDir$33759 = tDir;
							if (44413 - 125066 == -80653)
							{
								this.$self_$33760 = self_;
								if (214961 - 376104 == -161143)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600509B RID: 20635 RVA: 0x009E1164 File Offset: 0x009DF364
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ZombieFish.$RPC_nAttack$33747.$(this.$mPos$33758, this.$tDir$33759, this.$self_$33760);
		}

		// Token: 0x0600509C RID: 20636 RVA: 0x009E1180 File Offset: 0x009DF380
		internal static bool EQBIGL5B1eDbjYfs7E5k()
		{
			return true;
		}

		// Token: 0x0600509D RID: 20637 RVA: 0x009E1184 File Offset: 0x009DF384
		internal static bool VQT0AP5B4hbVqO1n5xHF()
		{
			return false;
		}

		// Token: 0x04005A0E RID: 23054
		internal Vector3 $mPos$33758;

		// Token: 0x04005A0F RID: 23055
		internal Vector3 $tDir$33759;

		// Token: 0x04005A10 RID: 23056
		internal ZombieFish $self_$33760;

		// Token: 0x02000DED RID: 3565
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600509E RID: 20638 RVA: 0x009E1188 File Offset: 0x009DF388
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ZombieFish self_)
			{
				if (291105 - 328398 != -37293)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (96456 - 553326 != -456869)
					{
						base..ctor();
						if (75871 - 246936 == -171065)
						{
							this.$mPos$33755 = mPos;
							if (41283 - 340709 != -299425)
							{
								this.$tDir$33756 = tDir;
								if (286244 - 11492 != 274753)
								{
									this.$self_$33757 = self_;
									if (277598 - 674 != 276925)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600509F RID: 20639 RVA: 0x009E1264 File Offset: 0x009DF464
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (173565 - 380794 != -207228)
				{
				}
				for (;;)
				{
					IL_99:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D97;
					case 2:
						if (this.$self_$33757.cBbcQdT5F8l.actionState != "attack")
						{
							goto IL_84F;
						}
						if (195452 - 344958 != -149506)
						{
							continue;
						}
						if (this.$self_$33757.cBbcQdT5F8l.myCommand != "nAttack")
						{
							if (121103 - 325117 != -204013)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$self_$33757.cBbcQdT5F8l.moveSpeed = (float)4;
							if (289524 - 101123 == 188402)
							{
								continue;
							}
							if (this.$self_$33757.nAttack_ring)
							{
								if (99250 - 521630 == -422379)
								{
									continue;
								}
								this.$self_$33757.cBbcQdT5F8l.createEffect(this.$self_$33757.nAttack_ring, this.$self_$33757.transform.position, this.$self_$33757.transform.rotation);
								if (225754 - 59240 != 166514)
								{
									continue;
								}
								goto IL_826;
							}
							else
							{
								Debug.LogError("Missing nAttack_ring Effect");
								if (258629 - 140131 != 118498)
								{
									continue;
								}
								goto IL_4A;
							}
						}
						break;
					case 3:
						if (this.$self_$33757.cBbcQdT5F8l.actionState != "attack")
						{
							goto IL_BE1;
						}
						if (218349 - 574032 == -355682)
						{
							continue;
						}
						if (this.$self_$33757.cBbcQdT5F8l.myCommand != "nAttack")
						{
							if (248971 - 578334 != -329363)
							{
								continue;
							}
							goto IL_BE1;
						}
						else
						{
							this.$self_$33757.cBbcQdT5F8l.moveSpeed = (float)0;
							if (147232 - 29953 == 117280)
							{
								continue;
							}
							this.$hitLayer$33748 = 130816 - (1 << this.$self_$33757.gameObject.layer);
							if (215115 - 490838 != -275723)
							{
								continue;
							}
							this.$hitList$33749 = null;
							if (251899 - 536485 != -284586)
							{
								continue;
							}
							this.$hitPos$33750 = default(Vector3);
							if (60239 - 159789 == -99549)
							{
								continue;
							}
							if (!this.$self_$33757.cBbcQdT5F8l.isMine)
							{
								goto IL_A11;
							}
							if (116039 - 255283 != -139244)
							{
								continue;
							}
							this.$hitList$33749 = Damage.FindRecTarget(this.$self_$33757.transform.position, this.$self_$33757.transform.forward, (float)1, (float)1, (float)2, (float)3, this.$hitLayer$33748);
							if (110516 - 52781 == 57736)
							{
								continue;
							}
							this.$$iterator$10847$33752 = UnityRuntimeServices.GetEnumerator(this.$hitList$33749);
							if (209399 - 356607 == -147207)
							{
								continue;
							}
							while (this.$$iterator$10847$33752.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10847$33752.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33751 = (GameObject)obj2;
								if (37859 - 46378 != -8519)
								{
									goto IL_99;
								}
								if (this.$self_$33757.cBbcQdT5F8l.hit(1, this.$hitObject$33751, this.$self_$33757.cBbcQdT5F8l.atk, 4, 0, this.$self_$33757.transform.forward) != 0)
								{
									if (51749 - 298376 != -246627)
									{
										goto IL_99;
									}
									this.$hitPos$33750 = this.$hitObject$33751.collider.ClosestPointOnBounds(this.$self_$33757.transform.position + Vector3.up);
									if (265429 - 319363 == -53933)
									{
										goto IL_99;
									}
									UnityRuntimeServices.Update(this.$$iterator$10847$33752, this.$hitObject$33751);
									if (228534 - 523526 != -294992)
									{
										goto IL_99;
									}
									this.$self_$33757.RPC_nAttack_hit(this.$hitPos$33750, this.$self_$33757.transform.forward, 0);
									if (271060 - 12285 == 258776)
									{
										goto IL_99;
									}
									if (PhotonClient.IsInitialized())
									{
										if (161290 - 70540 == 90751)
										{
											goto IL_99;
										}
										this.$self_$33757.ActionEvent("RPC_nAttack_hit", this.$hitPos$33750, this.$self_$33757.transform.forward, 0);
										if (36913 - 309874 != -272961)
										{
											goto IL_99;
										}
									}
								}
							}
							if (6159 - 538361 != -532201)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$33757.cBbcQdT5F8l.actionState != "attack")
						{
							goto IL_2E8;
						}
						if (150465 - 319768 != -169303)
						{
							continue;
						}
						if (this.$self_$33757.cBbcQdT5F8l.myCommand != "nAttack")
						{
							if (149673 - 495430 != -345757)
							{
								continue;
							}
							goto IL_2E8;
						}
						else
						{
							this.$self_$33757.cBbcQdT5F8l.moveSpeed = (float)4;
							if (117983 - 517180 != -399196)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$33757.cBbcQdT5F8l.actionState != "attack")
						{
							goto IL_4A0;
						}
						if (283614 - 584268 == -300653)
						{
							continue;
						}
						if (this.$self_$33757.cBbcQdT5F8l.myCommand != "nAttack")
						{
							if (180339 - 185987 != -5647)
							{
								goto Block_82;
							}
							continue;
						}
						else
						{
							this.$self_$33757.cBbcQdT5F8l.moveSpeed = (float)0;
							if (63965 - 420195 != -356230)
							{
								continue;
							}
							if (!this.$self_$33757.cBbcQdT5F8l.isMine)
							{
								goto IL_A60;
							}
							if (203245 - 113018 == 90228)
							{
								continue;
							}
							this.$hitList$33749 = Damage.FindRecTarget(this.$self_$33757.transform.position, this.$self_$33757.transform.forward, (float)1, (float)1, (float)2, (float)3, this.$hitLayer$33748);
							if (61666 - 538799 != -477133)
							{
								continue;
							}
							this.$$iterator$10848$33754 = UnityRuntimeServices.GetEnumerator(this.$hitList$33749);
							if (28279 - 501874 == -473594)
							{
								continue;
							}
							while (this.$$iterator$10848$33754.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10848$33754.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$33753 = (GameObject)obj4;
								if (141016 - 254861 == -113844)
								{
									goto IL_99;
								}
								if (this.$self_$33757.cBbcQdT5F8l.hit(1, this.$hitObject$33753, this.$self_$33757.cBbcQdT5F8l.atk, 4, 0, this.$self_$33757.transform.forward) != 0)
								{
									if (69088 - 560804 != -491716)
									{
										goto IL_99;
									}
									this.$hitPos$33750 = this.$hitObject$33753.collider.ClosestPointOnBounds(this.$self_$33757.transform.position + Vector3.up);
									if (270973 - 285552 == -14578)
									{
										goto IL_99;
									}
									UnityRuntimeServices.Update(this.$$iterator$10848$33754, this.$hitObject$33753);
									if (254920 - 541337 != -286417)
									{
										goto IL_99;
									}
									this.$self_$33757.RPC_nAttack_hit(this.$hitPos$33750, this.$self_$33757.transform.forward, 0);
									if (52779 - 427843 == -375063)
									{
										goto IL_99;
									}
									if (PhotonClient.IsInitialized())
									{
										if (278374 - 334477 != -56103)
										{
											goto IL_99;
										}
										this.$self_$33757.ActionEvent("RPC_nAttack_hit", this.$hitPos$33750, this.$self_$33757.transform.forward, 0);
										if (146405 - 487025 == -340619)
										{
											goto IL_99;
										}
									}
								}
							}
							if (63869 - 147019 != -83150)
							{
								continue;
							}
							goto IL_A60;
						}
						break;
					case 6:
						if (this.$self_$33757.cBbcQdT5F8l.actionState == "attack")
						{
							if (210127 - 318108 != -107981)
							{
								continue;
							}
							if (this.$self_$33757.cBbcQdT5F8l.myCommand == "nAttack")
							{
								if (191877 - 244440 == -52562)
								{
									continue;
								}
								this.$self_$33757.cBbcQdT5F8l.actionState = "standby";
								if (224536 - 595134 == -370597)
								{
									continue;
								}
								this.$self_$33757.cBbcQdT5F8l.actionTime = Time.time;
								if (276549 - 301544 != -24995)
								{
									continue;
								}
								this.$self_$33757.cBbcQdT5F8l.myCommand = "none";
								if (190454 - 376488 == -186033)
								{
									continue;
								}
								if (!this.$self_$33757.cBbcQdT5F8l.isMine)
								{
									if (13501 - 307631 == -294129)
									{
										continue;
									}
									this.$self_$33757.cBbcQdT5F8l.nPosition = this.$self_$33757.transform.position;
									if (133459 - 191590 == -58130)
									{
										continue;
									}
									this.$self_$33757.cBbcQdT5F8l.oPosition = this.$self_$33757.transform.position;
									if (293205 - 369174 != -75969)
									{
										continue;
									}
									this.$self_$33757.cBbcQdT5F8l.nDirection = this.$self_$33757.transform.forward;
									if (182714 - 595174 == -412459)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (41518 - 553985 != -512466)
						{
							goto Block_74;
						}
						continue;
					default:
						if (199802 - 522868 != -323066)
						{
							continue;
						}
						break;
					}
					this.$self_$33757.cBbcQdT5F8l.actionState = "attack";
					if (69609 - 256198 == -186589)
					{
						this.$self_$33757.cBbcQdT5F8l.actionTime = Time.time;
						if (84084 - 182837 != -98752)
						{
							this.$self_$33757.cBbcQdT5F8l.myCommand = "nAttack";
							if (258151 - 371601 != -113449)
							{
								this.$self_$33757.cBbcQdT5F8l.addTimeOut("nAttack", (float)3);
								if (127776 - 528664 == -400888)
								{
									this.$self_$33757.transform.position = this.$mPos$33755;
									if (207231 - 353194 != -145962)
									{
										this.$self_$33757.transform.LookAt(this.$mPos$33755 + global::Math.vFlat(this.$tDir$33756));
										if (202844 - 408710 == -205866)
										{
											this.$self_$33757.animation.Play("nAttack");
											if (261887 - 418762 == -156875)
											{
												this.$self_$33757.animation.wrapMode = WrapMode.Once;
												if (140145 - 282540 != -142394)
												{
													this.$self_$33757.cBbcQdT5F8l.vMovement = this.$self_$33757.transform.forward;
													if (138469 - 437037 == -298568)
													{
														this.$self_$33757.cBbcQdT5F8l.moveSpeed = (float)0;
														if (268625 - 513352 == -244727)
														{
															goto IL_539;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_4A:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_9:
				goto IL_A11;
				IL_2E8:
				goto IL_D97;
				Block_19:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_4A0:
				Block_32:
				goto IL_84F;
				IL_539:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_826:
				goto IL_4A;
				IL_84F:
				goto IL_D97;
				IL_A11:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_A60:
				return this.Yield(6, new WaitForSeconds(0.3f));
				Block_74:
				IL_BE1:
				Block_82:
				IL_D97:
				return false;
			}

			// Token: 0x060050A0 RID: 20640 RVA: 0x009E201C File Offset: 0x009E021C
			internal static bool QjFByT5BzOtrPjw5nhiF()
			{
				return true;
			}

			// Token: 0x060050A1 RID: 20641 RVA: 0x009E2020 File Offset: 0x009E0220
			internal static bool IvV3Gg5eaf3cGU79gkTp()
			{
				return false;
			}

			// Token: 0x04005A11 RID: 23057
			internal int $hitLayer$33748;

			// Token: 0x04005A12 RID: 23058
			internal UnityScript.Lang.Array $hitList$33749;

			// Token: 0x04005A13 RID: 23059
			internal Vector3 $hitPos$33750;

			// Token: 0x04005A14 RID: 23060
			internal GameObject $hitObject$33751;

			// Token: 0x04005A15 RID: 23061
			internal IEnumerator $$iterator$10847$33752;

			// Token: 0x04005A16 RID: 23062
			internal GameObject $hitObject$33753;

			// Token: 0x04005A17 RID: 23063
			internal IEnumerator $$iterator$10848$33754;

			// Token: 0x04005A18 RID: 23064
			internal Vector3 $mPos$33755;

			// Token: 0x04005A19 RID: 23065
			internal Vector3 $tDir$33756;

			// Token: 0x04005A1A RID: 23066
			internal ZombieFish $self_$33757;
		}
	}

	// Token: 0x02000DEE RID: 3566
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$33761 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060050A2 RID: 20642 RVA: 0x009E2024 File Offset: 0x009E0224
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$33761(Vector3 mPos, Vector3 tDir, ZombieFish self_)
		{
			if (10325 - 81711 != -71386)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (142481 - 32116 == 110365)
				{
					base..ctor();
					if (25908 - 461158 == -435250)
					{
						this.$mPos$33770 = mPos;
						if (225897 - 22282 != 203616)
						{
							this.$tDir$33771 = tDir;
							if (289912 - 53254 == 236658)
							{
								this.$self_$33772 = self_;
								if (147539 - 394369 != -246829)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060050A3 RID: 20643 RVA: 0x009E2100 File Offset: 0x009E0300
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ZombieFish.$RPC_cAttack$33761.$(this.$mPos$33770, this.$tDir$33771, this.$self_$33772);
		}

		// Token: 0x060050A4 RID: 20644 RVA: 0x009E211C File Offset: 0x009E031C
		internal static bool r0abOL5e5hXT2sJDPxS2()
		{
			return true;
		}

		// Token: 0x060050A5 RID: 20645 RVA: 0x009E2120 File Offset: 0x009E0320
		internal static bool rOI4RU5epgLSBbqcNWPS()
		{
			return false;
		}

		// Token: 0x04005A1B RID: 23067
		internal Vector3 $mPos$33770;

		// Token: 0x04005A1C RID: 23068
		internal Vector3 $tDir$33771;

		// Token: 0x04005A1D RID: 23069
		internal ZombieFish $self_$33772;

		// Token: 0x02000DEF RID: 3567
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060050A6 RID: 20646 RVA: 0x009E2124 File Offset: 0x009E0324
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ZombieFish self_)
			{
				if (133269 - 135257 != -1987)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (136245 - 479135 != -342889)
					{
						base..ctor();
						if (190804 - 486102 != -295297)
						{
							this.$mPos$33767 = mPos;
							if (173715 - 433308 != -259592)
							{
								this.$tDir$33768 = tDir;
								if (294971 - 325417 != -30445)
								{
									this.$self_$33769 = self_;
									if (275568 - 444605 != -169036)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060050A7 RID: 20647 RVA: 0x009E2200 File Offset: 0x009E0400
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (183804 - 536378 != -352574)
				{
				}
				for (;;)
				{
					IL_569:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_98A;
					case 2:
						if (this.$self_$33769.cBbcQdT5F8l.actionState != "attack")
						{
							goto IL_734;
						}
						if (131071 - 287676 == -156604)
						{
							continue;
						}
						if (this.$self_$33769.cBbcQdT5F8l.myCommand != "cAttack")
						{
							if (218891 - 67814 != 151078)
							{
								goto Block_54;
							}
							continue;
						}
						else
						{
							this.$self_$33769.cBbcQdT5F8l.moveSpeed = (float)9;
							if (250030 - 88168 != 161862)
							{
								continue;
							}
							if (this.$self_$33769.cAttack_ring)
							{
								if (269614 - 494951 == -225336)
								{
									continue;
								}
								this.$self_$33769.cBbcQdT5F8l.createEffect(this.$self_$33769.cAttack_ring, this.$self_$33769.transform.position, this.$self_$33769.transform.rotation);
								if (106387 - 103410 != 2978)
								{
									goto Block_5;
								}
								continue;
							}
							else
							{
								Debug.LogError("Missing cAttack_ring Effect");
								if (189168 - 442101 != -252933)
								{
									continue;
								}
								goto IL_334;
							}
						}
						break;
					case 3:
						if (this.$self_$33769.cBbcQdT5F8l.actionState != "attack")
						{
							goto IL_4C5;
						}
						if (51287 - 557910 == -506622)
						{
							continue;
						}
						if (this.$self_$33769.cBbcQdT5F8l.myCommand != "cAttack")
						{
							if (209780 - 314974 != -105193)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$33769.cBbcQdT5F8l.moveSpeed = (float)0;
							if (8327 - 411256 == -402928)
							{
								continue;
							}
							this.$hitLayer$33762 = 130816 - (1 << this.$self_$33769.gameObject.layer);
							if (118544 - 436839 == -318294)
							{
								continue;
							}
							this.$hitList$33763 = null;
							if (204446 - 322835 != -118389)
							{
								continue;
							}
							this.$hitPos$33764 = default(Vector3);
							if (267822 - 589964 == -322141)
							{
								continue;
							}
							if (!this.$self_$33769.cBbcQdT5F8l.isMine)
							{
								goto IL_5FE;
							}
							if (82830 - 579853 != -497023)
							{
								continue;
							}
							this.$hitList$33763 = Damage.FindRecTarget(this.$self_$33769.transform.position, this.$self_$33769.transform.forward, (float)1, (float)1, (float)2, (float)3, this.$hitLayer$33762);
							if (199201 - 364556 != -165355)
							{
								continue;
							}
							this.$$iterator$10849$33766 = UnityRuntimeServices.GetEnumerator(this.$hitList$33763);
							if (164506 - 460325 == -295818)
							{
								continue;
							}
							while (this.$$iterator$10849$33766.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10849$33766.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33765 = (GameObject)obj2;
								if (239355 - 168868 == 70488)
								{
									goto IL_569;
								}
								if (this.$self_$33769.cBbcQdT5F8l.hit(1, this.$hitObject$33765, this.$self_$33769.cBbcQdT5F8l.atk, 5, 0, this.$self_$33769.transform.forward) != 0)
								{
									if (28479 - 499316 != -470837)
									{
										goto IL_569;
									}
									this.$hitPos$33764 = this.$hitObject$33765.collider.ClosestPointOnBounds(this.$self_$33769.transform.position + Vector3.up);
									if (252470 - 385219 != -132749)
									{
										goto IL_569;
									}
									UnityRuntimeServices.Update(this.$$iterator$10849$33766, this.$hitObject$33765);
									if (271262 - 426865 == -155602)
									{
										goto IL_569;
									}
									this.$self_$33769.RPC_cAttack_hit(this.$hitPos$33764, this.$self_$33769.transform.forward, 0);
									if (223308 - 320021 != -96713)
									{
										goto IL_569;
									}
									if (PhotonClient.IsInitialized())
									{
										if (26133 - 511593 == -485459)
										{
											goto IL_569;
										}
										this.$self_$33769.ActionEvent("RPC_cAttack_hit", this.$hitPos$33764, this.$self_$33769.transform.forward, 0);
										if (294833 - 324596 == -29762)
										{
											goto IL_569;
										}
									}
								}
							}
							if (199594 - 548508 != -348913)
							{
								goto Block_57;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$33769.cBbcQdT5F8l.actionState == "attack")
						{
							if (287629 - 482955 != -195326)
							{
								continue;
							}
							if (this.$self_$33769.cBbcQdT5F8l.myCommand == "cAttack")
							{
								if (158108 - 599372 == -441263)
								{
									continue;
								}
								this.$self_$33769.cBbcQdT5F8l.actionState = "standby";
								if (142759 - 387974 == -245214)
								{
									continue;
								}
								this.$self_$33769.cBbcQdT5F8l.actionTime = Time.time;
								if (135852 - 356973 != -221121)
								{
									continue;
								}
								this.$self_$33769.cBbcQdT5F8l.myCommand = "none";
								if (179825 - 317820 == -137994)
								{
									continue;
								}
								if (!this.$self_$33769.cBbcQdT5F8l.isMine)
								{
									if (243084 - 482704 == -239619)
									{
										continue;
									}
									this.$self_$33769.cBbcQdT5F8l.nPosition = this.$self_$33769.transform.position;
									if (224118 - 11420 != 212698)
									{
										continue;
									}
									this.$self_$33769.cBbcQdT5F8l.oPosition = this.$self_$33769.transform.position;
									if (257420 - 373112 == -115691)
									{
										continue;
									}
									this.$self_$33769.cBbcQdT5F8l.nDirection = this.$self_$33769.transform.forward;
									if (209932 - 140020 == 69913)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (11754 - 362214 != -350459)
						{
							goto Block_35;
						}
						continue;
					default:
						if (179577 - 450444 == -270866)
						{
							continue;
						}
						break;
					}
					this.$self_$33769.cBbcQdT5F8l.actionState = "attack";
					if (178304 - 552995 == -374691)
					{
						this.$self_$33769.cBbcQdT5F8l.actionTime = Time.time;
						if (44511 - 310652 == -266141)
						{
							this.$self_$33769.cBbcQdT5F8l.myCommand = "cAttack";
							if (39778 - 506739 == -466961)
							{
								this.$self_$33769.cBbcQdT5F8l.addTimeOut("cAttack", (float)6);
								if (283486 - 218470 != 65017)
								{
									this.$self_$33769.transform.position = this.$mPos$33767;
									if (239821 - 282933 != -43111)
									{
										this.$self_$33769.transform.LookAt(this.$mPos$33767 + global::Math.vFlat(this.$tDir$33768));
										if (126285 - 320003 == -193718)
										{
											this.$self_$33769.animation.Play("cAttack");
											if (271411 - 356072 != -84660)
											{
												this.$self_$33769.animation.wrapMode = WrapMode.Once;
												if (9246 - 126666 != -117419)
												{
													this.$self_$33769.cBbcQdT5F8l.vMovement = this.$self_$33769.transform.forward;
													if (185037 - 312039 == -127002)
													{
														this.$self_$33769.cBbcQdT5F8l.moveSpeed = (float)0;
														if (20364 - 441086 == -420722)
														{
															goto IL_17D;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_4C5;
				Block_5:
				goto IL_334;
				IL_17D:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_334:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_4C5:
				Block_35:
				goto IL_98A;
				IL_5FE:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_734:
				goto IL_98A;
				Block_54:
				goto IL_734;
				Block_57:
				goto IL_5FE;
				IL_98A:
				return false;
			}

			// Token: 0x060050A8 RID: 20648 RVA: 0x009E2BAC File Offset: 0x009E0DAC
			internal static bool rJFPsh5eVyLwDwECbpXU()
			{
				return true;
			}

			// Token: 0x060050A9 RID: 20649 RVA: 0x009E2BB0 File Offset: 0x009E0DB0
			internal static bool QGJTy75etIZTsw6KdsFV()
			{
				return false;
			}

			// Token: 0x04005A1E RID: 23070
			internal int $hitLayer$33762;

			// Token: 0x04005A1F RID: 23071
			internal UnityScript.Lang.Array $hitList$33763;

			// Token: 0x04005A20 RID: 23072
			internal Vector3 $hitPos$33764;

			// Token: 0x04005A21 RID: 23073
			internal GameObject $hitObject$33765;

			// Token: 0x04005A22 RID: 23074
			internal IEnumerator $$iterator$10849$33766;

			// Token: 0x04005A23 RID: 23075
			internal Vector3 $mPos$33767;

			// Token: 0x04005A24 RID: 23076
			internal Vector3 $tDir$33768;

			// Token: 0x04005A25 RID: 23077
			internal ZombieFish $self_$33769;
		}
	}

	// Token: 0x02000DF0 RID: 3568
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33773 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060050AA RID: 20650 RVA: 0x009E2BB4 File Offset: 0x009E0DB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33773(UnityScript.Lang.Array nArray, ZombieFish self_)
		{
			if (39701 - 486549 != -446847)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (183008 - 437560 != -254551)
				{
					base..ctor();
					if (200785 - 229073 == -28288)
					{
						this.$nArray$33778 = nArray;
						if (34469 - 18731 != 15739)
						{
							this.$self_$33779 = self_;
							if (52926 - 297573 == -244647)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x009E2C70 File Offset: 0x009E0E70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ZombieFish.$RPC_ko$33773.$(this.$nArray$33778, this.$self_$33779);
		}

		// Token: 0x060050AC RID: 20652 RVA: 0x009E2C84 File Offset: 0x009E0E84
		internal static bool e27mvw5eNIWysumyppA6()
		{
			return true;
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x009E2C88 File Offset: 0x009E0E88
		internal static bool NIAqbc5eYvqYj49TuReG()
		{
			return false;
		}

		// Token: 0x04005A26 RID: 23078
		internal UnityScript.Lang.Array $nArray$33778;

		// Token: 0x04005A27 RID: 23079
		internal ZombieFish $self_$33779;

		// Token: 0x02000DF1 RID: 3569
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060050AE RID: 20654 RVA: 0x009E2C8C File Offset: 0x009E0E8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ZombieFish self_)
			{
				if (80567 - 127782 != -47214)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (145347 - 139907 != 5441)
					{
						base..ctor();
						if (180072 - 506384 != -326311)
						{
							this.$nArray$33776 = nArray;
							if (60104 - 540171 != -480066)
							{
								this.$self_$33777 = self_;
								if (72844 - 215842 != -142997)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060050AF RID: 20655 RVA: 0x009E2D48 File Offset: 0x009E0F48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (298474 - 487277 != -188803)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_57E;
					case 2:
						if (this.$self_$33777.cBbcQdT5F8l.actionState != "ko")
						{
							if (167818 - 111050 != 56768)
							{
								continue;
							}
							goto IL_368;
						}
						else
						{
							this.$self_$33777.animation.Play("getUp");
							if (139030 - 213847 != -74817)
							{
								continue;
							}
							this.$self_$33777.animation.wrapMode = WrapMode.Once;
							if (146974 - 52007 != 94968)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33777.cBbcQdT5F8l.actionState != "ko")
						{
							if (167120 - 387642 != -220522)
							{
								continue;
							}
							goto IL_ED;
						}
						else
						{
							this.$self_$33777.cBbcQdT5F8l.actionState = "standby";
							if (295170 - 399272 == -104101)
							{
								continue;
							}
							this.$self_$33777.cBbcQdT5F8l.actionTime = Time.time;
							if (295136 - 18238 == 276899)
							{
								continue;
							}
							this.$self_$33777.cBbcQdT5F8l.myCommand = "none";
							if (226884 - 580240 == -353355)
							{
								continue;
							}
							this.$self_$33777.cBbcQdT5F8l.hp = (int)(0.2f * (float)this.$self_$33777.cBbcQdT5F8l.mhp);
							if (148046 - 227175 != -79129)
							{
								continue;
							}
							this.YieldDefault(1);
							if (185623 - 174726 != 10898)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					default:
						if (191231 - 474352 == -283120)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33777.cBbcQdT5F8l.actionState == "ko")
					{
						break;
					}
					if (158467 - 216851 != -58383)
					{
						if (this.$self_$33777.cBbcQdT5F8l.actionState == "dead")
						{
							if (58873 - 286393 == -227520)
							{
								break;
							}
						}
						else
						{
							this.$mPos$33774 = (Vector3)this.$nArray$33776[0];
							if (232777 - 65750 != 167028)
							{
								this.$mDir$33775 = (Vector3)this.$nArray$33776[1];
								if (257128 - 26837 == 230291)
								{
									this.$self_$33777.cBbcQdT5F8l.hp = 0;
									if (150566 - 19887 != 130680)
									{
										this.$self_$33777.cBbcQdT5F8l.ko = this.$self_$33777.cBbcQdT5F8l.ko - 7;
										if (217316 - 536231 == -318915)
										{
											this.$self_$33777.cBbcQdT5F8l.actionState = "ko";
											if (286222 - 453651 != -167428)
											{
												this.$self_$33777.cBbcQdT5F8l.actionTime = Time.time;
												if (159688 - 332273 != -172584)
												{
													this.$self_$33777.cBbcQdT5F8l.myCommand = "none";
													if (257551 - 277805 != -20253)
													{
														this.$self_$33777.cBbcQdT5F8l.vMovement = Vector3.zero;
														if (167798 - 254246 == -86448)
														{
															this.$self_$33777.cBbcQdT5F8l.moveSpeed = (float)0;
															if (19839 - 71725 != -51885)
															{
																this.$self_$33777.animation.Play("ko");
																if (235209 - 397079 == -161870)
																{
																	this.$self_$33777.animation.wrapMode = WrapMode.Once;
																	if (22630 - 251931 != -229300)
																	{
																		if (this.$self_$33777.ko_ring)
																		{
																			if (246871 - 447734 == -200863)
																			{
																				this.$self_$33777.cBbcQdT5F8l.createEffect(this.$self_$33777.ko_ring, this.$self_$33777.transform.position, this.$self_$33777.transform.rotation);
																				if (242206 - 192922 != 49285)
																				{
																					goto Block_11;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Missing ko_ring Effect");
																			if (202301 - 48537 == 153764)
																			{
																				goto IL_500;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_ED:
				Block_8:
				goto IL_57E;
				Block_11:
				goto IL_500;
				Block_14:
				return this.Yield(3, new WaitForSeconds(0.8f));
				IL_368:
				goto IL_57E;
				IL_500:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_57E:
				return false;
			}

			// Token: 0x060050B0 RID: 20656 RVA: 0x009E32E8 File Offset: 0x009E14E8
			internal static bool cKqlgx5ecH7OceiTx00Y()
			{
				return true;
			}

			// Token: 0x060050B1 RID: 20657 RVA: 0x009E32EC File Offset: 0x009E14EC
			internal static bool a3Whxt5eUmV1PxGlxX5T()
			{
				return false;
			}

			// Token: 0x04005A28 RID: 23080
			internal Vector3 $mPos$33774;

			// Token: 0x04005A29 RID: 23081
			internal Vector3 $mDir$33775;

			// Token: 0x04005A2A RID: 23082
			internal UnityScript.Lang.Array $nArray$33776;

			// Token: 0x04005A2B RID: 23083
			internal ZombieFish $self_$33777;
		}
	}

	// Token: 0x02000DF2 RID: 3570
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33780 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060050B2 RID: 20658 RVA: 0x009E32F0 File Offset: 0x009E14F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33780(UnityScript.Lang.Array nArray, ZombieFish self_)
		{
			if (41686 - 549907 != -508220)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131240 - 520733 != -389492)
				{
					base..ctor();
					if (174021 - 26243 != 147779)
					{
						this.$nArray$33785 = nArray;
						if (170209 - 584199 == -413990)
						{
							this.$self_$33786 = self_;
							if (237993 - 404625 != -166631)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060050B3 RID: 20659 RVA: 0x009E33AC File Offset: 0x009E15AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ZombieFish.$RPC_dead$33780.$(this.$nArray$33785, this.$self_$33786);
		}

		// Token: 0x060050B4 RID: 20660 RVA: 0x009E33C0 File Offset: 0x009E15C0
		internal static bool QNFDES5eT3Fe5GIBtIKp()
		{
			return true;
		}

		// Token: 0x060050B5 RID: 20661 RVA: 0x009E33C4 File Offset: 0x009E15C4
		internal static bool a1UxVg5e3NeWlHuffcsX()
		{
			return false;
		}

		// Token: 0x04005A2C RID: 23084
		internal UnityScript.Lang.Array $nArray$33785;

		// Token: 0x04005A2D RID: 23085
		internal ZombieFish $self_$33786;

		// Token: 0x02000DF3 RID: 3571
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060050B6 RID: 20662 RVA: 0x009E33C8 File Offset: 0x009E15C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ZombieFish self_)
			{
				if (59203 - 332198 != -272994)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (283040 - 552851 == -269811)
					{
						base..ctor();
						if (8846 - 483574 == -474728)
						{
							this.$nArray$33783 = nArray;
							if (109942 - 146426 != -36483)
							{
								this.$self_$33784 = self_;
								if (81452 - 338573 != -257120)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060050B7 RID: 20663 RVA: 0x009E3484 File Offset: 0x009E1684
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (288414 - 420612 != -132198)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5AB;
					case 2:
						if (this.$self_$33784.cBbcQdT5F8l.actionState != "dead")
						{
							if (152674 - 347950 != -195276)
							{
								continue;
							}
							goto IL_3F3;
						}
						else
						{
							if (!this.$self_$33784.cBbcQdT5F8l.isPlayer)
							{
								if (142193 - 433380 == -291186)
								{
									continue;
								}
								if (this.$self_$33784.deadEffect)
								{
									if (215193 - 290353 != -75160)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$33784.deadEffect, this.$self_$33784.transform.position, this.$self_$33784.transform.rotation);
									if (203235 - 49911 != 153324)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing deadEffect Effect");
									if (129712 - 407828 == -278115)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$33784.gameObject);
								if (261551 - 116135 != 145416)
								{
									continue;
								}
							}
							else if (this.$self_$33784.cBbcQdT5F8l.isMine)
							{
								if (296089 - 389026 != -92937)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33784.gameObject);
								if (190198 - 42649 != 147549)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (88323 - 305756 != -217432)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					default:
						if (108578 - 157399 != -48821)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33784.cBbcQdT5F8l.actionState == "dead")
					{
						if (18361 - 246390 != -228028)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33781 = (Vector3)this.$nArray$33783[0];
						if (244371 - 316635 != -72263)
						{
							this.$myDirection$33782 = (Vector3)this.$nArray$33783[1];
							if (63051 - 510571 == -447520)
							{
								this.$self_$33784.transform.position = this.$myPosition$33781;
								if (282625 - 402500 == -119875)
								{
									this.$self_$33784.transform.LookAt(this.$myPosition$33781 + this.$myDirection$33782);
									if (37528 - 426087 == -388559)
									{
										this.$self_$33784.cBbcQdT5F8l.hp = 0;
										if (287647 - 538589 == -250942)
										{
											this.$self_$33784.cBbcQdT5F8l.ko = 0;
											if (179796 - 450616 != -270819)
											{
												this.$self_$33784.cBbcQdT5F8l.actionState = "dead";
												if (267485 - 49315 != 218171)
												{
													this.$self_$33784.cBbcQdT5F8l.actionTime = Time.time;
													if (37190 - 592766 == -555576)
													{
														this.$self_$33784.cBbcQdT5F8l.myCommand = "none";
														if (506 - 595037 == -594531)
														{
															this.$self_$33784.cBbcQdT5F8l.vMovement = Vector3.zero;
															if (147192 - 18913 != 128280)
															{
																this.$self_$33784.cBbcQdT5F8l.moveSpeed = (float)0;
																if (245628 - 287498 == -41870)
																{
																	this.$self_$33784.animation.Rewind();
																	if (40830 - 77766 == -36936)
																	{
																		this.$self_$33784.animation.Play("dead");
																		if (167507 - 41128 != 126380)
																		{
																			this.$self_$33784.animation.wrapMode = WrapMode.Once;
																			if (91336 - 167455 != -76118)
																			{
																				if (this.$self_$33784.dead_ring)
																				{
																					if (237639 - 3988 != 233652)
																					{
																						this.$self_$33784.cBbcQdT5F8l.createEffect(this.$self_$33784.dead_ring, this.$self_$33784.transform.position, this.$self_$33784.transform.rotation);
																						if (106522 - 509147 == -402625)
																						{
																							goto IL_157;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Missing dead_ring Effect");
																					if (183184 - 577173 != -393988)
																					{
																						goto Block_9;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_5AB;
				IL_157:
				Block_9:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_3F3:
				IL_5AB:
				return false;
			}

			// Token: 0x060050B8 RID: 20664 RVA: 0x009E3A50 File Offset: 0x009E1C50
			internal static bool TnsHAF5eXSSQvRRZ8OFH()
			{
				return true;
			}

			// Token: 0x060050B9 RID: 20665 RVA: 0x009E3A54 File Offset: 0x009E1C54
			internal static bool LoFQLC5eQvr94Y0BPwRG()
			{
				return false;
			}

			// Token: 0x04005A2E RID: 23086
			internal Vector3 $myPosition$33781;

			// Token: 0x04005A2F RID: 23087
			internal Vector3 $myDirection$33782;

			// Token: 0x04005A30 RID: 23088
			internal UnityScript.Lang.Array $nArray$33783;

			// Token: 0x04005A31 RID: 23089
			internal ZombieFish $self_$33784;
		}
	}
}
