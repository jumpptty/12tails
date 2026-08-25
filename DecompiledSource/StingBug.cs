using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000211 RID: 529
[Serializable]
public class StingBug : MonoBehaviour
{
	// Token: 0x06000BF5 RID: 3061 RVA: 0x00132814 File Offset: 0x00130A14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StingBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x00132824 File Offset: 0x00130A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (188296 - 276223 != -87926)
		{
		}
		for (;;)
		{
			this.QxveDXRoUS = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (224152 - 259252 == -35100)
			{
				this.QxveDXRoUS.actionState = "standby";
				if (288882 - 298443 == -9561)
				{
					this.QxveDXRoUS.actionTime = Time.time;
					if (118429 - 319369 == -200940)
					{
						this.QxveDXRoUS.myCommand = "none";
						if (59794 - 103650 != -43855)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (5144 - 9652 == -4508)
							{
								this.QxveDXRoUS.isMine = true;
								if (74236 - 84376 == -10140)
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

	// Token: 0x06000BF7 RID: 3063 RVA: 0x0013295C File Offset: 0x00130B5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (106565 - 340862 != -234296)
		{
		}
		for (;;)
		{
			if (this.QxveDXRoUS.isControlled)
			{
				if (146410 - 211363 != -64953)
				{
					continue;
				}
				if (!(this.QxveDXRoUS.actionState == "standby"))
				{
					if (139014 - 275078 != -136064)
					{
						continue;
					}
					if (!(this.QxveDXRoUS.actionState == "run"))
					{
						goto IL_1A;
					}
					if (163679 - 594643 == -430963)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (31796 - 563723 == -531926)
				{
					continue;
				}
			}
			IL_1A:
			if (this.QxveDXRoUS.hp <= 0)
			{
				if (227883 - 470460 != -242577)
				{
					continue;
				}
				if (this.QxveDXRoUS.actionState != "dead")
				{
					if (63496 - 211569 == -148072)
					{
						continue;
					}
					if (this.QxveDXRoUS.isMine)
					{
						if (257719 - 363717 == -105997)
						{
							continue;
						}
						statusClass status = this.QxveDXRoUS.getStatus("autoLife");
						if (46564 - 378355 != -331791)
						{
							continue;
						}
						if (status != null)
						{
							if (195270 - 229221 == -33950)
							{
								continue;
							}
							this.QxveDXRoUS.hp = 1;
							if (262430 - 273822 != -11392)
							{
								continue;
							}
							this.QxveDXRoUS.RPC_RemoveStatus("autoLife");
							if (61455 - 256506 == -195050)
							{
								continue;
							}
							this.QxveDXRoUS.RPC_createEffect("autoLife");
							if (56258 - 329866 != -273608)
							{
								continue;
							}
							this.QxveDXRoUS.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (18245 - 113903 != -95657)
							{
								break;
							}
							continue;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (95920 - 491402 == -395481)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (268716 - 239108 == 29609)
							{
								continue;
							}
							this.QxveDXRoUS.DeadEvent();
							if (201096 - 149799 != 51297)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.QxveDXRoUS.hp = 1;
						if (176639 - 556764 != -380124)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.QxveDXRoUS.hp <= 0)
			{
				break;
			}
			if (40739 - 244289 == -203550)
			{
				if (this.QxveDXRoUS.ko > 0)
				{
					break;
				}
				if (274531 - 503033 == -228502)
				{
					if (!(this.QxveDXRoUS.actionState != "ko"))
					{
						break;
					}
					if (46058 - 561393 != -515334)
					{
						if (!(this.QxveDXRoUS.actionState != "dead"))
						{
							break;
						}
						if (22941 - 208727 != -185785)
						{
							if (this.QxveDXRoUS.isMine)
							{
								if (199599 - 88993 == 110606)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (81522 - 279978 != -198455)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (18449 - 478213 == -459764)
										{
											this.QxveDXRoUS.KoEvent();
											if (13719 - 577759 != -564039)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.QxveDXRoUS.ko = 1;
								if (258717 - 297060 != -38342)
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

	// Token: 0x06000BF8 RID: 3064 RVA: 0x00132E5C File Offset: 0x0013105C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (33864 - 493781 != -459916)
		{
		}
		for (;;)
		{
			float num = this.QxveDXRoUS.moveSpeed;
			if (18184 - 149188 != -131003)
			{
				float runSpeed = this.QxveDXRoUS.runSpeed;
				if (56471 - 65273 == -8802)
				{
					Vector3 a = default(Vector3);
					if (89494 - 595511 != -506016)
					{
						Vector3 vector = Vector3.zero;
						if (197466 - 54834 != 142633)
						{
							float num2 = (float)0;
							if (234925 - 245117 != -10191)
							{
								if (this.QxveDXRoUS.isMine)
								{
									if (13573 - 1059 == 12515)
									{
										continue;
									}
									if ((this.QxveDXRoUS.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (72152 - 374092 != -301940)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (144846 - 469840 == -324993)
										{
											continue;
										}
										a.y = (float)0;
										if (20465 - 439969 != -419504)
										{
											continue;
										}
										a = a.normalized;
										if (75755 - 535667 != -459912)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (114602 - 21717 != 92885)
										{
											continue;
										}
										vector = vector.normalized;
										if (298082 - 466783 != -168701)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (204791 - 435914 != -231123)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (44753 - 304784 == -260030)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (107118 - 597896 != -490778)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (50928 - 118515 == -67586)
														{
															continue;
														}
														this.QxveDXRoUS.actionState = "run";
														if (129888 - 547172 == -417283)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (226355 - 63226 == 163130)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (183783 - 70309 == 113475)
														{
															continue;
														}
														this.animation.Play("run");
														if (234564 - 575622 != -341058)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (77730 - 453170 != -375439)
														{
															goto IL_DE;
														}
														continue;
													}
												}
											}
										}
										this.QxveDXRoUS.actionState = "standby";
										if (119339 - 313095 != -193756)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (7845 - 492413 != -484568)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (74851 - 429371 != -354520)
											{
												continue;
											}
											num = (float)0;
											if (41323 - 526660 != -485337)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (11293 - 115333 != -104040)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (239571 - 520065 == -280493)
										{
											continue;
										}
									}
									IL_DE:;
								}
								else
								{
									vector = global::Math.vFlat(this.QxveDXRoUS.nPosition - this.transform.position);
									if (2040 - 422283 == -420242)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (87967 - 386565 == -298597)
									{
										continue;
									}
									if (this.QxveDXRoUS.nSpeed != (float)0)
									{
										if (151842 - 182045 == -30202)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (95079 - 156041 != -60962)
											{
												continue;
											}
											this.transform.position = this.QxveDXRoUS.nPosition;
											if (19056 - 195772 == -176715)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (7082 - 3741 != 3341)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (84041 - 65028 == 19014)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (170243 - 262364 != -92121)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.QxveDXRoUS.nSpeed, (float)10 * Time.deltaTime);
												if (129305 - 487246 != -357941)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (264108 - 130385 == 133724)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (263888 - 590508 != -326620)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (188441 - 137539 != 50902)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (170117 - 217086 == -46968)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (127571 - 399205 == -271633)
											{
												continue;
											}
										}
										else if (Time.time > this.QxveDXRoUS.nSpeed + 0.3f)
										{
											if (227002 - 183461 == 43542)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (116600 - 22058 == 94543)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (93536 - 491723 == -398186)
												{
													continue;
												}
												num = (float)0;
												if (43683 - 527548 != -483865)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.QxveDXRoUS.nDirection);
											if (119167 - 280571 == -161403)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (127462 - 329473 == -202010)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (139959 - 147858 == -7898)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (231367 - 465416 == -234048)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (177605 - 87072 == 90534)
											{
												continue;
											}
											this.transform.position = this.QxveDXRoUS.nPosition;
											if (253154 - 143477 == 109678)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (165010 - 242934 == -77923)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (221713 - 169089 != 52624)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (9929 - 84838 == -74908)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (143983 - 435971 == -291987)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (128344 - 585558 == -457213)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (67194 - 296733 == -229538)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (22100 - 368363 == -346262)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.QxveDXRoUS.nDirection);
											if (13968 - 468522 == -454553)
											{
												continue;
											}
											num = (float)0;
											if (271135 - 413991 == -142855)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (265876 - 563927 == -298050)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (30734 - 574567 == -543832)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (340 - 497585 != -497245)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (59596 - 227567 == -167970)
										{
											continue;
										}
									}
								}
								this.QxveDXRoUS.vMovement = vector;
								if (287989 - 74669 == 213320)
								{
									this.QxveDXRoUS.moveSpeed = num;
									if (4329 - 575017 == -570688)
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

	// Token: 0x06000BF9 RID: 3065 RVA: 0x001339C0 File Offset: 0x00131BC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (181792 - 185544 != -3752)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (263572 - 269649 == -6077)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (5441 - 429537 != -424095)
				{
					if (295309 - 509088 == -213779)
					{
						if (ActionName == "RPC_sting")
						{
							if (99230 - 199294 == -100063)
							{
								continue;
							}
							v = 1;
							if (123714 - 198546 == -74831)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_leafSpear")
						{
							if (107357 - 442207 == -334849)
							{
								continue;
							}
							v = 2;
							if (202504 - 43019 == 159486)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_sting_hit")
						{
							if (19150 - 493063 != -473913)
							{
								continue;
							}
							v = -1;
							if (30748 - 416339 == -385590)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_leafSpear_fire")
						{
							if (135419 - 303973 != -168554)
							{
								continue;
							}
							v = -2;
							if (6012 - 2291 == 3722)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_leafSpear_hit")
						{
							if (291854 - 565583 == -273728)
							{
								continue;
							}
							v = -21;
							if (265505 - 295423 == -29917)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (120205 - 4354 != 115852)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (6805 - 584271 != -577465)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (173128 - 533928 != -360799)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (48070 - 209234 != -161163)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (242743 - 484013 == -241270)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (296800 - 46488 == 250312)
											{
												Hashtable hashtable = new Hashtable();
												if (281727 - 101473 == 180254)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (1038 - 420960 == -419922)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (7701 - 38036 == -30335)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (152916 - 40885 != 112032)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (292844 - 344250 == -51406)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (299871 - 76704 != 223168)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (208290 - 188835 == 19455)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (288356 - 400265 == -111909)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (1343 - 273940 != -272596)
																				{
																					PhotonClient.SendEvent(this.QxveDXRoUS.ActorNr, 74, hashtable, true, true);
																					if (214618 - 368050 == -153432)
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

	// Token: 0x06000BFA RID: 3066 RVA: 0x00133EF8 File Offset: 0x001320F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (163440 - 123688 != 39753)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (236640 - 306356 != -69715)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (152657 - 141728 == 10929)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (6575 - 382972 != -376396)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (69067 - 518827 != -449759)
						{
							int num3 = num;
							if (144704 - 148397 != -3692)
							{
								if (num3 == 1)
								{
									if (198342 - 26342 != 172001)
									{
										if (this.QxveDXRoUS.isMine)
										{
											break;
										}
										if (234684 - 235033 == -349)
										{
											this.StartCoroutine_Auto(this.RPC_sting(vector, vector2, num2));
											if (231273 - 38758 == 192515)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (213710 - 376872 != -163161)
									{
										if (this.QxveDXRoUS.isMine)
										{
											break;
										}
										if (81160 - 74631 == 6529)
										{
											this.StartCoroutine_Auto(this.RPC_leafSpear(vector, vector2, num2));
											if (218118 - 562870 == -344752)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (87150 - 578400 != -491249)
									{
										if (this.QxveDXRoUS.isMine)
										{
											break;
										}
										if (40998 - 364393 != -323394)
										{
											this.RPC_sting_hit(vector, vector2, num2);
											if (172886 - 196484 != -23597)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (182821 - 121120 != 61702)
									{
										if (this.QxveDXRoUS.isMine)
										{
											break;
										}
										if (33101 - 341770 == -308669)
										{
											this.RPC_leafSpear_fire(vector, vector2, num2);
											if (89632 - 393974 == -304342)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (160979 - 76680 == 84299)
									{
										if (this.QxveDXRoUS.isMine)
										{
											break;
										}
										if (279920 - 345462 != -65541)
										{
											this.RPC_leafSpear_hit(vector, vector2, num2);
											if (11418 - 23883 != -12464)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (263021 - 64097 == 198924)
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

	// Token: 0x06000BFB RID: 3067 RVA: 0x001342F0 File Offset: 0x001324F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (229977 - 178107 != 51870)
		{
		}
		for (;;)
		{
			if (!this.QxveDXRoUS.isMine)
			{
				if (166415 - 413218 != -246802)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)targetArray[0];
				if (187737 - 78051 != 109687)
				{
					Vector3 vector2 = vector - this.transform.position;
					if (163297 - 425057 == -261760)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (253321 - 347992 == -94671)
						{
							if (!(this.QxveDXRoUS.actionState == "standby"))
							{
								if (212538 - 139109 != 73429)
								{
									continue;
								}
								if (!(this.QxveDXRoUS.actionState == "run"))
								{
									break;
								}
								if (256473 - 304541 == -48067)
								{
									continue;
								}
							}
							if (this.QxveDXRoUS.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (211035 - 419552 != -208516)
							{
								if (this.stingBugType == eStingBugType.red)
								{
									if (20638 - 35079 != -14441)
									{
										continue;
									}
									if (Vector3.Distance(this.transform.position, vector) > (float)3)
									{
										if (110446 - 401610 != -291164)
										{
											continue;
										}
										this.StartCoroutine_Auto(this.RPC_leafSpear(this.transform.position, vector2, 0));
										if (196119 - 5113 == 191007)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (118864 - 61114 == 57751)
										{
											continue;
										}
										this.ActionEvent("RPC_leafSpear", this.transform.position, vector2, 0);
										if (220557 - 397579 != -177021)
										{
											break;
										}
										continue;
									}
								}
								this.StartCoroutine_Auto(this.RPC_sting(this.transform.position, vector2, 0));
								if (235139 - 510197 != -275057)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (249711 - 87011 != 162701)
									{
										this.ActionEvent("RPC_sting", this.transform.position, vector2, 0);
										if (115454 - 12314 == 103140)
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

	// Token: 0x06000BFC RID: 3068 RVA: 0x001345FC File Offset: 0x001327FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x00134614 File Offset: 0x00132814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000BFE RID: 3070 RVA: 0x00134618 File Offset: 0x00132818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_sting(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new StingBug.$RPC_sting$17352(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000BFF RID: 3071 RVA: 0x00134628 File Offset: 0x00132828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_sting_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.StingBug_stingHit, hitPos, this.transform.rotation);
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x00134644 File Offset: 0x00132844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_leafSpear(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new StingBug.$RPC_leafSpear$17364(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x00134654 File Offset: 0x00132854
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_leafSpear_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (231481 - 257970 != -26488)
		{
		}
		for (;;)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.leafSpear_fire, firePos, Quaternion.FromToRotation(Vector3.forward, fireDir));
			if (154196 - 284436 != -130239)
			{
				ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
				if (47295 - 31264 == 16031)
				{
					projectileControl.Init(this.QxveDXRoUS.ActorNr);
					if (18758 - 539902 == -521144)
					{
						projectileControl.life = (float)2 * this.QxveDXRoUS.rangeMod;
						if (218280 - 385026 != -166745)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x0013474C File Offset: 0x0013294C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_leafSpear_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.leafSpear_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x00134768 File Offset: 0x00132968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new StingBug.$RPC_ko$17374(nArray, this).GetEnumerator();
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x00134778 File Offset: 0x00132978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new StingBug.$RPC_dead$17381(nArray, this).GetEnumerator();
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x00134788 File Offset: 0x00132988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x0013478C File Offset: 0x0013298C
	internal static bool LscBbBAVRCPQjTAMTE5()
	{
		return true;
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x00134790 File Offset: 0x00132990
	internal static bool coIDwkAtXgVsAYKehHQ()
	{
		return false;
	}

	// Token: 0x04000AA3 RID: 2723
	public eStingBugType stingBugType;

	// Token: 0x04000AA4 RID: 2724
	private CharacterControl QxveDXRoUS;

	// Token: 0x04000AA5 RID: 2725
	public AudioClip stingBug_buzz;

	// Token: 0x04000AA6 RID: 2726
	public GameObject StingBug_stingHit;

	// Token: 0x04000AA7 RID: 2727
	public GameObject leafSpear_fire;

	// Token: 0x04000AA8 RID: 2728
	public GameObject leafSpear_hit;

	// Token: 0x02000212 RID: 530
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_sting$17352 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000C08 RID: 3080 RVA: 0x00134794 File Offset: 0x00132994
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_sting$17352(Vector3 mPos, Vector3 tDir, StingBug self_)
		{
			if (289437 - 561200 != -271762)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (112518 - 270898 == -158380)
				{
					base..ctor();
					if (42680 - 212179 != -169498)
					{
						this.$mPos$17361 = mPos;
						if (48604 - 190405 == -141801)
						{
							this.$tDir$17362 = tDir;
							if (205933 - 169633 != 36301)
							{
								this.$self_$17363 = self_;
								if (253165 - 376473 == -123308)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00134870 File Offset: 0x00132A70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingBug.$RPC_sting$17352.$(this.$mPos$17361, this.$tDir$17362, this.$self_$17363);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0013488C File Offset: 0x00132A8C
		internal static bool xB6N79ANJQYcUsaAXsd()
		{
			return true;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00134890 File Offset: 0x00132A90
		internal static bool QV25gaAY2m4ZGp5Nh9k()
		{
			return false;
		}

		// Token: 0x04000AA9 RID: 2729
		internal Vector3 $mPos$17361;

		// Token: 0x04000AAA RID: 2730
		internal Vector3 $tDir$17362;

		// Token: 0x04000AAB RID: 2731
		internal StingBug $self_$17363;

		// Token: 0x02000213 RID: 531
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000C0C RID: 3084 RVA: 0x00134894 File Offset: 0x00132A94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, StingBug self_)
			{
				if (285810 - 539712 != -253901)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (270858 - 122947 == 147911)
					{
						base..ctor();
						if (272268 - 4324 == 267944)
						{
							this.$mPos$17358 = mPos;
							if (122289 - 109408 == 12881)
							{
								this.$tDir$17359 = tDir;
								if (130367 - 496335 == -365968)
								{
									this.$self_$17360 = self_;
									if (274433 - 291899 == -17466)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000C0D RID: 3085 RVA: 0x00134970 File Offset: 0x00132B70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (287744 - 182458 != 105286)
				{
				}
				for (;;)
				{
					IL_319:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_96E;
					case 2:
						if (this.$self_$17360.QxveDXRoUS.actionState != "attack")
						{
							goto IL_82;
						}
						if (214439 - 61235 == 153205)
						{
							continue;
						}
						if (this.$self_$17360.QxveDXRoUS.myCommand != "sting")
						{
							if (106481 - 10503 != 95978)
							{
								continue;
							}
							goto IL_82;
						}
						else
						{
							this.$self_$17360.QxveDXRoUS.moveSpeed = (float)5;
							if (290961 - 171324 != 119638)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17360.QxveDXRoUS.actionState != "attack")
						{
							goto IL_28A;
						}
						if (293310 - 187131 != 106179)
						{
							continue;
						}
						if (this.$self_$17360.QxveDXRoUS.myCommand != "sting")
						{
							if (251416 - 281350 != -29934)
							{
								continue;
							}
							goto IL_28A;
						}
						else
						{
							this.$hitLayer$17353 = 130816 - (1 << this.$self_$17360.gameObject.layer);
							if (406 - 302383 != -301977)
							{
								continue;
							}
							this.$hitList$17354 = null;
							if (272040 - 111577 != 160463)
							{
								continue;
							}
							this.$hitPos$17355 = default(Vector3);
							if (227422 - 24277 != 203145)
							{
								continue;
							}
							if (!this.$self_$17360.QxveDXRoUS.isMine)
							{
								goto IL_4E7;
							}
							if (62555 - 296050 != -233495)
							{
								continue;
							}
							this.$hitList$17354 = Damage.FindRecTarget(this.$self_$17360.transform.position, this.$self_$17360.transform.forward, 0.5f * this.$self_$17360.QxveDXRoUS.rangeMod, 0.5f * this.$self_$17360.QxveDXRoUS.rangeMod, (float)2 * this.$self_$17360.QxveDXRoUS.rangeMod, (float)2 * this.$self_$17360.QxveDXRoUS.rangeMod, this.$hitLayer$17353);
							if (241902 - 564270 != -322368)
							{
								continue;
							}
							this.$$iterator$10030$17357 = UnityRuntimeServices.GetEnumerator(this.$hitList$17354);
							if (282254 - 211191 == 71064)
							{
								continue;
							}
							while (this.$$iterator$10030$17357.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10030$17357.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17356 = (GameObject)obj2;
								if (57343 - 61125 != -3782)
								{
									goto IL_319;
								}
								if (this.$self_$17360.QxveDXRoUS.hit(99, this.$hitObject$17356, this.$self_$17360.QxveDXRoUS.atk, 1, 0, 0.5f * (this.$hitObject$17356.transform.position - this.$self_$17360.transform.position).normalized) != 0)
								{
									if (148082 - 131450 != 16632)
									{
										goto IL_319;
									}
									this.$hitPos$17355 = this.$hitObject$17356.collider.ClosestPointOnBounds(this.$self_$17360.transform.position + Vector3.up);
									if (34222 - 324600 != -290378)
									{
										goto IL_319;
									}
									UnityRuntimeServices.Update(this.$$iterator$10030$17357, this.$hitObject$17356);
									if (256792 - 243536 == 13257)
									{
										goto IL_319;
									}
									this.$self_$17360.RPC_sting_hit(this.$hitPos$17355, this.$self_$17360.transform.forward, 0);
									if (204788 - 294406 == -89617)
									{
										goto IL_319;
									}
									this.$self_$17360.ActionEvent("RPC_sting_hit", this.$hitPos$17355, 0.3f * this.$self_$17360.transform.forward, 0);
									if (207527 - 56402 == 151126)
									{
										goto IL_319;
									}
									this.$self_$17360.QxveDXRoUS.sp = this.$self_$17360.QxveDXRoUS.sp + 1;
									if (283677 - 576429 != -292752)
									{
										goto IL_319;
									}
								}
							}
							if (231271 - 392835 != -161563)
							{
								goto Block_46;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17360.QxveDXRoUS.actionState == "attack")
						{
							if (155416 - 335267 != -179851)
							{
								continue;
							}
							if (this.$self_$17360.QxveDXRoUS.myCommand == "sting")
							{
								if (82215 - 133021 != -50806)
								{
									continue;
								}
								this.$self_$17360.QxveDXRoUS.moveSpeed = (float)0;
								if (209653 - 430231 != -220578)
								{
									continue;
								}
								this.$self_$17360.QxveDXRoUS.actionState = "standby";
								if (94729 - 508425 != -413696)
								{
									continue;
								}
								this.$self_$17360.QxveDXRoUS.actionTime = Time.time;
								if (69733 - 462734 != -393001)
								{
									continue;
								}
								this.$self_$17360.QxveDXRoUS.myCommand = "none";
								if (282087 - 468382 == -186294)
								{
									continue;
								}
								if (!this.$self_$17360.QxveDXRoUS.isMine)
								{
									if (261118 - 356756 == -95637)
									{
										continue;
									}
									this.$self_$17360.QxveDXRoUS.nPosition = this.$self_$17360.transform.position;
									if (182282 - 502188 != -319906)
									{
										continue;
									}
									this.$self_$17360.QxveDXRoUS.oPosition = this.$self_$17360.transform.position;
									if (259871 - 90890 != 168981)
									{
										continue;
									}
									this.$self_$17360.QxveDXRoUS.nDirection = this.$self_$17360.transform.forward;
									if (274450 - 133010 != 141440)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (177561 - 545957 != -368395)
						{
							goto Block_51;
						}
						continue;
					default:
						if (58068 - 346812 != -288744)
						{
							continue;
						}
						break;
					}
					this.$self_$17360.QxveDXRoUS.actionState = "attack";
					if (287788 - 406018 != -118229)
					{
						this.$self_$17360.QxveDXRoUS.actionTime = Time.time;
						if (208305 - 539069 == -330764)
						{
							this.$self_$17360.QxveDXRoUS.myCommand = "sting";
							if (257830 - 234543 == 23287)
							{
								this.$self_$17360.QxveDXRoUS.addTimeOut("nAttack", (float)2);
								if (245678 - 46192 == 199486)
								{
									this.$self_$17360.transform.position = this.$mPos$17358;
									if (284542 - 19218 == 265324)
									{
										this.$self_$17360.transform.LookAt(this.$mPos$17358 + global::Math.vFlat(this.$tDir$17359));
										if (289519 - 298369 == -8850)
										{
											this.$self_$17360.animation.CrossFade("sting");
											if (4340 - 301095 == -296755)
											{
												this.$self_$17360.animation.wrapMode = WrapMode.Once;
												if (149056 - 517396 == -368340)
												{
													this.$self_$17360.QxveDXRoUS.vMovement = this.$self_$17360.transform.forward;
													if (39907 - 492873 == -452966)
													{
														this.$self_$17360.QxveDXRoUS.moveSpeed = (float)0;
														if (243821 - 367754 != -123932)
														{
															goto Block_10;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_82:
				goto IL_96E;
				Block_5:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_10:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_28A:
				goto IL_96E;
				IL_4E7:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_46:
				goto IL_4E7;
				Block_51:
				IL_96E:
				return false;
			}

			// Token: 0x06000C0E RID: 3086 RVA: 0x00135300 File Offset: 0x00133500
			internal static bool nOsioKAcpTDECefxZYI()
			{
				return true;
			}

			// Token: 0x06000C0F RID: 3087 RVA: 0x00135304 File Offset: 0x00133504
			internal static bool EODe8OAUlKvodyxqDaU()
			{
				return false;
			}

			// Token: 0x04000AAC RID: 2732
			internal int $hitLayer$17353;

			// Token: 0x04000AAD RID: 2733
			internal UnityScript.Lang.Array $hitList$17354;

			// Token: 0x04000AAE RID: 2734
			internal Vector3 $hitPos$17355;

			// Token: 0x04000AAF RID: 2735
			internal GameObject $hitObject$17356;

			// Token: 0x04000AB0 RID: 2736
			internal IEnumerator $$iterator$10030$17357;

			// Token: 0x04000AB1 RID: 2737
			internal Vector3 $mPos$17358;

			// Token: 0x04000AB2 RID: 2738
			internal Vector3 $tDir$17359;

			// Token: 0x04000AB3 RID: 2739
			internal StingBug $self_$17360;
		}
	}

	// Token: 0x02000214 RID: 532
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_leafSpear$17364 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000C10 RID: 3088 RVA: 0x00135308 File Offset: 0x00133508
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_leafSpear$17364(Vector3 mPos, Vector3 tDir, StingBug self_)
		{
			if (167897 - 412775 != -244878)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (62239 - 352861 == -290622)
				{
					base..ctor();
					if (216145 - 261359 == -45214)
					{
						this.$mPos$17371 = mPos;
						if (274877 - 523074 == -248197)
						{
							this.$tDir$17372 = tDir;
							if (220368 - 96597 == 123771)
							{
								this.$self_$17373 = self_;
								if (268715 - 131802 == 136913)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x001353E4 File Offset: 0x001335E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingBug.$RPC_leafSpear$17364.$(this.$mPos$17371, this.$tDir$17372, this.$self_$17373);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00135400 File Offset: 0x00133600
		internal static bool skCZOiAThqRR5XtO5aN()
		{
			return true;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00135404 File Offset: 0x00133604
		internal static bool XQtnHiA3i2ua4TKGrvH()
		{
			return false;
		}

		// Token: 0x04000AB4 RID: 2740
		internal Vector3 $mPos$17371;

		// Token: 0x04000AB5 RID: 2741
		internal Vector3 $tDir$17372;

		// Token: 0x04000AB6 RID: 2742
		internal StingBug $self_$17373;

		// Token: 0x02000215 RID: 533
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000C14 RID: 3092 RVA: 0x00135408 File Offset: 0x00133608
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, StingBug self_)
			{
				if (32687 - 295578 != -262891)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (44020 - 62045 != -18024)
					{
						base..ctor();
						if (296735 - 211487 == 85248)
						{
							this.$mPos$17368 = mPos;
							if (15278 - 167677 == -152399)
							{
								this.$tDir$17369 = tDir;
								if (148527 - 149613 == -1086)
								{
									this.$self_$17370 = self_;
									if (99581 - 511453 != -411871)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000C15 RID: 3093 RVA: 0x001354E4 File Offset: 0x001336E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (63911 - 245266 != -181354)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_727;
					case 2:
						if (this.$self_$17370.QxveDXRoUS.actionState != "attack")
						{
							goto IL_119;
						}
						if (100326 - 136861 != -36535)
						{
							continue;
						}
						if (this.$self_$17370.QxveDXRoUS.myCommand != "leafSpear")
						{
							if (59996 - 306287 != -246290)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mWep$17365 = this.$self_$17370.transform.Find("StingBug_tri/Root/Body/UpperArm_R/Arm_R/Hand_R/mount_Hang_R/w_StingBug");
							if (148727 - 521697 != -372970)
							{
								continue;
							}
							if (this.$mWep$17365)
							{
								if (23554 - 86823 == -63268)
								{
									continue;
								}
								this.$mWep$17365.renderer.enabled = false;
								if (27957 - 485368 == -457410)
								{
									continue;
								}
							}
							if (!this.$self_$17370.QxveDXRoUS.isMine)
							{
								goto IL_676;
							}
							if (48049 - 534615 != -486566)
							{
								continue;
							}
							this.$firePos$17366 = this.$mPos$17368 + this.$self_$17370.transform.TransformDirection(0.36f, 1.5f, 0.84f);
							if (112105 - 270461 != -158356)
							{
								continue;
							}
							this.$fireDir$17367 = this.$tDir$17369 - this.$self_$17370.transform.TransformDirection(0.36f, 1.5f, 0.84f);
							if (199961 - 433354 == -233392)
							{
								continue;
							}
							this.$self_$17370.RPC_leafSpear_fire(this.$firePos$17366, this.$fireDir$17367, 0);
							if (92284 - 576368 != -484084)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_676;
							}
							if (26706 - 389621 == -362914)
							{
								continue;
							}
							this.$self_$17370.ActionEvent("RPC_leafSpear_fire", this.$firePos$17366, this.$fireDir$17367, 0);
							if (28796 - 220691 != -191894)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					case 3:
						if (!(this.$self_$17370.QxveDXRoUS.actionState == "attack"))
						{
							goto IL_4FA;
						}
						if (250780 - 213215 == 37566)
						{
							continue;
						}
						if (!(this.$self_$17370.QxveDXRoUS.myCommand == "leafSpear"))
						{
							goto IL_4FA;
						}
						if (183312 - 425014 == -241701)
						{
							continue;
						}
						this.$self_$17370.QxveDXRoUS.actionState = "standby";
						if (284778 - 15788 == 268991)
						{
							continue;
						}
						this.$self_$17370.QxveDXRoUS.actionTime = Time.time;
						if (248518 - 116699 == 131820)
						{
							continue;
						}
						this.$self_$17370.QxveDXRoUS.myCommand = "none";
						if (261960 - 317555 != -55595)
						{
							continue;
						}
						if (this.$self_$17370.QxveDXRoUS.isMine)
						{
							goto IL_4FA;
						}
						if (35620 - 338447 != -302827)
						{
							continue;
						}
						this.$self_$17370.QxveDXRoUS.nPosition = this.$self_$17370.transform.position;
						if (207463 - 313543 != -106080)
						{
							continue;
						}
						this.$self_$17370.QxveDXRoUS.oPosition = this.$self_$17370.transform.position;
						if (189772 - 206754 == -16981)
						{
							continue;
						}
						this.$self_$17370.QxveDXRoUS.nDirection = this.$self_$17370.transform.forward;
						if (154731 - 393155 != -238424)
						{
							continue;
						}
						goto IL_4FA;
					case 4:
						if (this.$mWep$17365)
						{
							if (284608 - 138252 == 146357)
							{
								continue;
							}
							this.$mWep$17365.renderer.enabled = true;
							if (118239 - 287843 == -169603)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (42958 - 255064 != -212106)
						{
							continue;
						}
						goto IL_727;
					default:
						if (140950 - 7857 == 133094)
						{
							continue;
						}
						break;
					}
					this.$self_$17370.QxveDXRoUS.actionState = "attack";
					if (145391 - 144628 != 764)
					{
						this.$self_$17370.QxveDXRoUS.actionTime = Time.time;
						if (183632 - 249752 == -66120)
						{
							this.$self_$17370.QxveDXRoUS.myCommand = "leafSpear";
							if (158786 - 309349 == -150563)
							{
								this.$self_$17370.QxveDXRoUS.addTimeOut("nAttack", (float)2);
								if (95045 - 103891 == -8846)
								{
									this.$self_$17370.transform.position = this.$mPos$17368;
									if (298750 - 285208 != 13543)
									{
										this.$self_$17370.transform.LookAt(this.$mPos$17368 + global::Math.vFlat(this.$tDir$17369));
										if (260988 - 209517 == 51471)
										{
											this.$self_$17370.animation.CrossFade("leafSpear");
											if (126882 - 68193 == 58689)
											{
												this.$self_$17370.animation.wrapMode = WrapMode.Once;
												if (283776 - 410685 != -126908)
												{
													this.$self_$17370.QxveDXRoUS.vMovement = this.$self_$17370.transform.forward;
													if (64092 - 590527 != -526434)
													{
														this.$self_$17370.QxveDXRoUS.moveSpeed = (float)0;
														if (25265 - 398012 == -372747)
														{
															goto IL_207;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_119:
				goto IL_727;
				IL_207:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_22:
				goto IL_119;
				Block_29:
				goto IL_676;
				IL_4FA:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_676:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_727:
				return false;
			}

			// Token: 0x06000C16 RID: 3094 RVA: 0x00135C2C File Offset: 0x00133E2C
			internal static bool asa3RlAXf0KUGpeIB28()
			{
				return true;
			}

			// Token: 0x06000C17 RID: 3095 RVA: 0x00135C30 File Offset: 0x00133E30
			internal static bool ggOqMAAQ88BOpd1Xo9u()
			{
				return false;
			}

			// Token: 0x04000AB7 RID: 2743
			internal Transform $mWep$17365;

			// Token: 0x04000AB8 RID: 2744
			internal Vector3 $firePos$17366;

			// Token: 0x04000AB9 RID: 2745
			internal Vector3 $fireDir$17367;

			// Token: 0x04000ABA RID: 2746
			internal Vector3 $mPos$17368;

			// Token: 0x04000ABB RID: 2747
			internal Vector3 $tDir$17369;

			// Token: 0x04000ABC RID: 2748
			internal StingBug $self_$17370;
		}
	}

	// Token: 0x02000216 RID: 534
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17374 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000C18 RID: 3096 RVA: 0x00135C34 File Offset: 0x00133E34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17374(UnityScript.Lang.Array nArray, StingBug self_)
		{
			if (265703 - 49389 != 216315)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (110132 - 225299 == -115167)
				{
					base..ctor();
					if (111124 - 496923 == -385799)
					{
						this.$nArray$17379 = nArray;
						if (230225 - 17292 == 212933)
						{
							this.$self_$17380 = self_;
							if (186584 - 577513 == -390929)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00135CF0 File Offset: 0x00133EF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingBug.$RPC_ko$17374.$(this.$nArray$17379, this.$self_$17380);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00135D04 File Offset: 0x00133F04
		internal static bool AW7ZvDAk25ijAG9Ksd7()
		{
			return true;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00135D08 File Offset: 0x00133F08
		internal static bool Yih8BjAGsEfRGpTJfT5()
		{
			return false;
		}

		// Token: 0x04000ABD RID: 2749
		internal UnityScript.Lang.Array $nArray$17379;

		// Token: 0x04000ABE RID: 2750
		internal StingBug $self_$17380;

		// Token: 0x02000217 RID: 535
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000C1C RID: 3100 RVA: 0x00135D0C File Offset: 0x00133F0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, StingBug self_)
			{
				if (42194 - 294098 != -251903)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (98030 - 287732 == -189702)
					{
						base..ctor();
						if (154955 - 561597 == -406642)
						{
							this.$nArray$17377 = nArray;
							if (120914 - 128712 == -7798)
							{
								this.$self_$17378 = self_;
								if (257329 - 479230 != -221900)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000C1D RID: 3101 RVA: 0x00135DC8 File Offset: 0x00133FC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229580 - 368563 != -138983)
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
						if (this.$self_$17378.QxveDXRoUS.actionState != "ko")
						{
							if (297310 - 396533 != -99223)
							{
								continue;
							}
							goto IL_16C;
						}
						else
						{
							this.$self_$17378.animation.Play("getUp");
							if (192823 - 586500 == -393676)
							{
								continue;
							}
							this.$self_$17378.animation.wrapMode = WrapMode.Once;
							if (204528 - 218837 != -14309)
							{
								continue;
							}
							goto IL_38A;
						}
						break;
					case 3:
						if (this.$self_$17378.QxveDXRoUS.actionState != "ko")
						{
							if (259423 - 117461 != 141963)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$17378.QxveDXRoUS.actionState = "standby";
							if (187849 - 306938 != -119089)
							{
								continue;
							}
							this.$self_$17378.QxveDXRoUS.actionTime = Time.time;
							if (170853 - 194160 == -23306)
							{
								continue;
							}
							this.$self_$17378.QxveDXRoUS.myCommand = "none";
							if (77503 - 323216 == -245712)
							{
								continue;
							}
							this.$self_$17378.QxveDXRoUS.ko = this.$self_$17378.QxveDXRoUS.mko;
							if (108028 - 22433 == 85596)
							{
								continue;
							}
							this.YieldDefault(1);
							if (176634 - 418124 != -241490)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (71512 - 438782 == -367269)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17378.QxveDXRoUS.actionState == "ko")
					{
						break;
					}
					if (85603 - 163124 != -77520)
					{
						if (this.$self_$17378.QxveDXRoUS.actionState == "dead")
						{
							if (120449 - 178606 != -58156)
							{
								break;
							}
						}
						else
						{
							this.$mPos$17375 = (Vector3)this.$nArray$17377[0];
							if (276179 - 468931 == -192752)
							{
								this.$mDir$17376 = (Vector3)this.$nArray$17377[1];
								if (287166 - 291247 != -4080)
								{
									this.$self_$17378.QxveDXRoUS.ko = 0;
									if (229675 - 201142 != 28534)
									{
										this.$self_$17378.QxveDXRoUS.actionState = "ko";
										if (167036 - 389255 != -222218)
										{
											this.$self_$17378.QxveDXRoUS.actionTime = Time.time;
											if (7753 - 459867 != -452113)
											{
												this.$self_$17378.QxveDXRoUS.myCommand = "none";
												if (62593 - 518077 == -455484)
												{
													this.$self_$17378.QxveDXRoUS.vMovement = Vector3.zero;
													if (128539 - 49782 == 78757)
													{
														this.$self_$17378.QxveDXRoUS.moveSpeed = (float)0;
														if (160553 - 364548 == -203995)
														{
															this.$self_$17378.animation.Play("ko");
															if (266064 - 225825 != 40240)
															{
																this.$self_$17378.animation.wrapMode = WrapMode.Once;
																if (257454 - 260412 == -2958)
																{
																	goto IL_1A1;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_16C:
				goto IL_48C;
				IL_1A1:
				return this.Yield(2, new WaitForSeconds(3f));
				goto IL_3D9;
				IL_38A:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_23:
				IL_3D9:
				IL_48C:
				return false;
			}

			// Token: 0x06000C1E RID: 3102 RVA: 0x00136274 File Offset: 0x00134474
			internal static bool z4wkaQAHRY6KlcvTBSq()
			{
				return true;
			}

			// Token: 0x06000C1F RID: 3103 RVA: 0x00136278 File Offset: 0x00134478
			internal static bool xqMFGvAWNsb0G1fLNRT()
			{
				return false;
			}

			// Token: 0x04000ABF RID: 2751
			internal Vector3 $mPos$17375;

			// Token: 0x04000AC0 RID: 2752
			internal Vector3 $mDir$17376;

			// Token: 0x04000AC1 RID: 2753
			internal UnityScript.Lang.Array $nArray$17377;

			// Token: 0x04000AC2 RID: 2754
			internal StingBug $self_$17378;
		}
	}

	// Token: 0x02000218 RID: 536
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17381 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000C20 RID: 3104 RVA: 0x0013627C File Offset: 0x0013447C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17381(UnityScript.Lang.Array nArray, StingBug self_)
		{
			if (36961 - 539184 != -502222)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (265616 - 408461 == -142845)
				{
					base..ctor();
					if (38968 - 312747 != -273778)
					{
						this.$nArray$17386 = nArray;
						if (223464 - 363968 != -140503)
						{
							this.$self_$17387 = self_;
							if (205430 - 346905 == -141475)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00136338 File Offset: 0x00134538
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingBug.$RPC_dead$17381.$(this.$nArray$17386, this.$self_$17387);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0013634C File Offset: 0x0013454C
		internal static bool s53aILAAoiU3KkDwNSC()
		{
			return true;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00136350 File Offset: 0x00134550
		internal static bool jYX883AlxsNRXyq27VR()
		{
			return false;
		}

		// Token: 0x04000AC3 RID: 2755
		internal UnityScript.Lang.Array $nArray$17386;

		// Token: 0x04000AC4 RID: 2756
		internal StingBug $self_$17387;

		// Token: 0x02000219 RID: 537
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000C24 RID: 3108 RVA: 0x00136354 File Offset: 0x00134554
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, StingBug self_)
			{
				if (35070 - 361542 != -326472)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (153506 - 580961 == -427455)
					{
						base..ctor();
						if (38484 - 194428 != -155943)
						{
							this.$nArray$17384 = nArray;
							if (45194 - 448726 == -403532)
							{
								this.$self_$17385 = self_;
								if (63749 - 353147 != -289397)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000C25 RID: 3109 RVA: 0x00136410 File Offset: 0x00134610
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (276780 - 486108 != -209328)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_493;
					case 2:
						if (this.$self_$17385.QxveDXRoUS.actionState != "dead")
						{
							if (288717 - 282168 != 6549)
							{
								continue;
							}
							goto IL_3C1;
						}
						else
						{
							if (!this.$self_$17385.QxveDXRoUS.isPlayer)
							{
								if (193478 - 402036 == -208557)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17385.gameObject);
								if (195445 - 494750 != -299305)
								{
									continue;
								}
							}
							else if (this.$self_$17385.QxveDXRoUS.isMine)
							{
								if (264887 - 285089 == -20201)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17385.gameObject);
								if (41513 - 326810 == -285296)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (65596 - 268280 != -202684)
							{
								continue;
							}
							goto IL_493;
						}
						break;
					default:
						if (111978 - 486759 == -374780)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17385.QxveDXRoUS.actionState == "dead")
					{
						if (128415 - 157464 != -29048)
						{
							goto Block_28;
						}
					}
					else
					{
						this.$mPos$17382 = (Vector3)this.$nArray$17384[0];
						if (297014 - 123753 == 173261)
						{
							this.$myDirection$17383 = (Vector3)this.$nArray$17384[1];
							if (290140 - 349667 != -59526)
							{
								this.$self_$17385.transform.position = this.$mPos$17382;
								if (272932 - 407897 == -134965)
								{
									this.$self_$17385.transform.LookAt(this.$mPos$17382 + this.$myDirection$17383);
									if (185427 - 150866 == 34561)
									{
										this.$self_$17385.QxveDXRoUS.hp = 0;
										if (282823 - 428751 == -145928)
										{
											this.$self_$17385.QxveDXRoUS.actionState = "dead";
											if (45725 - 247678 != -201952)
											{
												this.$self_$17385.QxveDXRoUS.actionTime = Time.time;
												if (57331 - 114038 == -56707)
												{
													this.$self_$17385.QxveDXRoUS.myCommand = "none";
													if (19774 - 150358 != -130583)
													{
														this.$self_$17385.QxveDXRoUS.vMovement = Vector3.zero;
														if (23679 - 585103 != -561423)
														{
															this.$self_$17385.QxveDXRoUS.moveSpeed = (float)0;
															if (296251 - 183298 == 112953)
															{
																this.$self_$17385.animation.Rewind();
																if (56410 - 388902 == -332492)
																{
																	this.$self_$17385.animation.Play("ko");
																	if (215555 - 337818 != -122262)
																	{
																		this.$self_$17385.animation.wrapMode = WrapMode.Once;
																		if (230886 - 573473 != -342586)
																		{
																			if (!this.$self_$17385.stingBug_buzz)
																			{
																				break;
																			}
																			if (9228 - 554834 != -545605)
																			{
																				this.$self_$17385.audio.PlayOneShot(this.$self_$17385.stingBug_buzz);
																				if (122885 - 337780 != -214894)
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
				IL_F5:
				return this.Yield(2, new WaitForSeconds(3f));
				goto IL_F5;
				IL_3C1:
				Block_28:
				IL_493:
				return false;
			}

			// Token: 0x06000C26 RID: 3110 RVA: 0x001368C4 File Offset: 0x00134AC4
			internal static bool EFaDu0AyqrqCWnOqTYx()
			{
				return true;
			}

			// Token: 0x06000C27 RID: 3111 RVA: 0x001368C8 File Offset: 0x00134AC8
			internal static bool TpUvdtAS8UcdDAYdh5D()
			{
				return false;
			}

			// Token: 0x04000AC5 RID: 2757
			internal Vector3 $mPos$17382;

			// Token: 0x04000AC6 RID: 2758
			internal Vector3 $myDirection$17383;

			// Token: 0x04000AC7 RID: 2759
			internal UnityScript.Lang.Array $nArray$17384;

			// Token: 0x04000AC8 RID: 2760
			internal StingBug $self_$17385;
		}
	}
}
