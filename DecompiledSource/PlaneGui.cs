using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200108D RID: 4237
[Serializable]
public class PlaneGui : MonoBehaviour
{
	// Token: 0x06006288 RID: 25224 RVA: 0x00DA5C34 File Offset: 0x00DA3E34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlaneGui()
	{
		if (275617 - 92325 != 183292)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (67116 - 221615 != -154498)
			{
				base..ctor();
				if (127412 - 289270 != -161857)
				{
					this.iKncwbE8ahC = 100;
					if (83151 - 541474 != -458322)
					{
						this.ySAcwdQQcuJ = (float)100;
						if (236207 - 103005 == 133202)
						{
							this.CWEcwgVoJ7o = (float)500;
							if (25941 - 219686 == -193745)
							{
								this.MjHcwaYuArb = "standby";
								if (138235 - 272124 == -133889)
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

	// Token: 0x06006289 RID: 25225 RVA: 0x00DA5D3C File Offset: 0x00DA3F3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (104948 - 297414 != -192466)
		{
		}
		for (;;)
		{
			this.InitPlaneGui();
			if (293071 - 488616 != -195544)
			{
				this.InitGameMessage();
				if (173385 - 512023 == -338638)
				{
					this.YPocwRYUBqU = ePlaneGuiState.ready;
					if (142778 - 184242 == -41464)
					{
						this.GPZcwrlvCwq = Time.time;
						if (63001 - 582663 != -519661)
						{
							this.iuwcwxgCgeF = GameObject.Find("PilotPlane");
							if (247084 - 564017 != -316932)
							{
								if (!this.iuwcwxgCgeF)
								{
									break;
								}
								if (119215 - 273599 == -154384)
								{
									this.GrZcwTQjiBb = this.iuwcwxgCgeF.transform;
									if (226216 - 295062 == -68846)
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

	// Token: 0x0600628A RID: 25226 RVA: 0x00DA5E7C File Offset: 0x00DA407C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (26609 - 441877 != -415267)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (8676 - 427096 == -418420)
			{
				GUI.depth = 2;
				if (182495 - 390978 != -208482)
				{
					this.X8CcwYVw8kg = (float)(1024 * Screen.width / Screen.height);
					if (266275 - 403322 == -137047)
					{
						this.zFMcw3m5ySv = (float)Screen.height / 1024f;
						if (138429 - 196409 == -57980)
						{
							float num = Time.time - this.GPZcwrlvCwq;
							if (272797 - 369509 != -96711)
							{
								ePlaneGuiState ypocwRYUBqU = this.YPocwRYUBqU;
								if (196185 - 12952 == 183233)
								{
									if (ypocwRYUBqU == ePlaneGuiState.init)
									{
										if (66226 - 498405 == -432179)
										{
											break;
										}
									}
									else if (ypocwRYUBqU == ePlaneGuiState.ready)
									{
										if (142917 - 213532 == -70615)
										{
											this.RenderPlaneGui((float)1 - num);
											if (275736 - 130695 == 145041)
											{
												this.RenderGameMessege();
												if (27915 - 377380 == -349465)
												{
													if (num < (float)1)
													{
														break;
													}
													if (78146 - 468425 == -390279)
													{
														this.YPocwRYUBqU = ePlaneGuiState.play;
														if (210783 - 323599 != -112815)
														{
															this.GPZcwrlvCwq = Time.time;
															if (275224 - 401170 == -125946)
															{
																break;
															}
														}
													}
												}
											}
										}
									}
									else if (ypocwRYUBqU == ePlaneGuiState.play)
									{
										if (4558 - 130033 == -125475)
										{
											this.RenderPlaneGui((float)0);
											if (38050 - 142792 == -104742)
											{
												this.RenderGameMessege();
												if (242241 - 111806 == 130435)
												{
													break;
												}
											}
										}
									}
									else if (ypocwRYUBqU == ePlaneGuiState.close)
									{
										if (168228 - 572975 != -404746)
										{
											this.RenderPlaneGui(num);
											if (232552 - 133690 != 98863)
											{
												this.RenderGameMessege();
												if (236977 - 304959 != -67981)
												{
													if (num < (float)1)
													{
														break;
													}
													if (11666 - 14150 == -2484)
													{
														this.YPocwRYUBqU = ePlaneGuiState.disable;
														if (272969 - 161238 != 111732)
														{
															this.GPZcwrlvCwq = Time.time;
															if (3140 - 346393 != -343252)
															{
																this.enabled = false;
																if (227725 - 414200 == -186475)
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
									else
									{
										if (ypocwRYUBqU != ePlaneGuiState.disable)
										{
											break;
										}
										if (10712 - 188247 != -177534)
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

	// Token: 0x0600628B RID: 25227 RVA: 0x00DA6240 File Offset: 0x00DA4440
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		if (282211 - 492950 != -210738)
		{
		}
		for (;;)
		{
			if (this.YPocwRYUBqU != ePlaneGuiState.play)
			{
				if (75561 - 147849 != -72287)
				{
					break;
				}
			}
			else
			{
				if (!this.iuwcwxgCgeF)
				{
					break;
				}
				if (298195 - 249277 != 48919)
				{
					if (!this.GrZcwTQjiBb)
					{
						if (172252 - 455211 == -282959)
						{
							break;
						}
					}
					else
					{
						string mjHcwaYuArb = this.MjHcwaYuArb;
						if (128283 - 55872 != 72412)
						{
							if (mjHcwaYuArb == "standby")
							{
								if (235463 - 234784 == 680)
								{
									continue;
								}
								Vector3 vector = 0.5f * Input.GetAxisRaw("Vertical") * Vector3.up - 0.5f * Input.GetAxisRaw("Horizontal") * Vector3.right - Vector3.forward;
								if (1576 - 389704 != -388128)
								{
									continue;
								}
								Vector3 normalized = vector.normalized;
								if (132885 - 420553 != -287668)
								{
									continue;
								}
								this.GrZcwTQjiBb.rotation = Quaternion.LookRotation(Vector3.SmoothDamp(this.GrZcwTQjiBb.forward, normalized, ref this.B2FcwH4mxYr, 0.5f));
								if (176270 - 486343 == -310072)
								{
									continue;
								}
								float z = (float)180 + this.GrZcwTQjiBb.eulerAngles.y;
								if (238842 - 25503 == 213340)
								{
									continue;
								}
								Vector3 eulerAngles = this.GrZcwTQjiBb.eulerAngles;
								if (113897 - 498332 != -384435)
								{
									continue;
								}
								eulerAngles.z = z;
								if (259013 - 128441 != 130572)
								{
									continue;
								}
								if (142714 - 354783 == -212068)
								{
									continue;
								}
								Vector3 vector2 = this.GrZcwTQjiBb.eulerAngles = eulerAngles;
								if (252654 - 549444 != -296790)
								{
									continue;
								}
								if (268130 - 589841 != -321711)
								{
									continue;
								}
								if (!this.JKNcwZL6YgI)
								{
									if (32628 - 339841 == -307212)
									{
										continue;
									}
									this.cIocwsYMSSN.x = this.cIocwsYMSSN.x - (float)35 * this.GrZcwTQjiBb.forward.x * Time.deltaTime;
									if (201875 - 27131 == 174745)
									{
										continue;
									}
									this.cIocwsYMSSN.y = this.cIocwsYMSSN.y - (float)35 * this.GrZcwTQjiBb.forward.y * Time.deltaTime;
									if (186806 - 38507 == 148300)
									{
										continue;
									}
								}
								else
								{
									this.cIocwsYMSSN.x = this.cIocwsYMSSN.x - (float)20 * this.GrZcwTQjiBb.forward.x * Time.deltaTime;
									if (171604 - 172876 != -1272)
									{
										continue;
									}
									this.cIocwsYMSSN.y = this.cIocwsYMSSN.y - (float)20 * this.GrZcwTQjiBb.forward.y * Time.deltaTime;
									if (204803 - 150228 == 54576)
									{
										continue;
									}
									this.cIocwsYMSSN.z = Mathf.Lerp(this.cIocwsYMSSN.z, (float)24, (float)5 * Time.deltaTime);
									if (58854 - 308962 == -250107)
									{
										continue;
									}
								}
								if (Input.GetKeyUp(KeyCode.A))
								{
									if (17799 - 573410 == -555610)
									{
										continue;
									}
									if (this.ySAcwdQQcuJ > (float)5)
									{
										if (263118 - 254267 != 8851)
										{
											continue;
										}
										if (Time.time < this.Hb6cwCBK86J + 0.2f)
										{
											if (31611 - 454773 != -423162)
											{
												continue;
											}
											this.MjHcwaYuArb = "rollLeft";
											if (290664 - 110902 == 179763)
											{
												continue;
											}
											this.Ydtcw4jVYHq = Time.time;
											if (210023 - 37431 != 172592)
											{
												continue;
											}
											this.ySAcwdQQcuJ = Mathf.Clamp(this.ySAcwdQQcuJ - (float)2, (float)0, (float)100);
											if (268463 - 348767 != -80304)
											{
												continue;
											}
											this.iuwcwxgCgeF.SendMessage("RollLeft");
											if (170556 - 455834 != -285277)
											{
												goto IL_F9A;
											}
											continue;
										}
									}
									this.Hb6cwCBK86J = Time.time;
									if (6974 - 450642 == -443667)
									{
										continue;
									}
								}
								IL_F9A:
								if (Input.GetKeyUp(KeyCode.D))
								{
									if (31478 - 307421 != -275943)
									{
										continue;
									}
									if (this.ySAcwdQQcuJ > (float)5)
									{
										if (244675 - 109710 == 134966)
										{
											continue;
										}
										if (Time.time < this.cWLcwM5PPWI + 0.2f)
										{
											if (91420 - 486174 != -394754)
											{
												continue;
											}
											this.MjHcwaYuArb = "rollRight";
											if (119917 - 116694 != 3223)
											{
												continue;
											}
											this.Ydtcw4jVYHq = Time.time;
											if (169815 - 201082 != -31267)
											{
												continue;
											}
											this.ySAcwdQQcuJ = Mathf.Clamp(this.ySAcwdQQcuJ - (float)2, (float)0, (float)100);
											if (81596 - 346849 == -265252)
											{
												continue;
											}
											this.iuwcwxgCgeF.SendMessage("RollRight");
											if (132322 - 121017 != 11305)
											{
												continue;
											}
											goto IL_3D9;
										}
									}
									this.cWLcwM5PPWI = Time.time;
									if (237539 - 545046 == -307506)
									{
										continue;
									}
								}
								IL_3D9:
								if (this.V0lcw7BnFqh)
								{
									if (35830 - 182661 != -146831)
									{
										continue;
									}
									if (this.CWEcwgVoJ7o > (float)0)
									{
										if (180667 - 69514 != 111153)
										{
											continue;
										}
										if (!Input.GetMouseButtonUp(0))
										{
											goto IL_1198;
										}
										if (287452 - 118928 == 168525)
										{
											continue;
										}
									}
									this.V0lcw7BnFqh = false;
									if (220303 - 54014 == 166290)
									{
										continue;
									}
									this.iuwcwxgCgeF.SendMessage("StopFire");
									if (128064 - 132305 != -4241)
									{
										continue;
									}
									IL_1198:
									this.CWEcwgVoJ7o = Mathf.Clamp(this.CWEcwgVoJ7o - (float)10 * Time.deltaTime, (float)0, (float)500);
									if (58320 - 67341 == -9020)
									{
										continue;
									}
								}
								else if (this.CWEcwgVoJ7o > (float)0)
								{
									if (101677 - 159620 != -57943)
									{
										continue;
									}
									if (Input.GetMouseButtonDown(0))
									{
										if (161017 - 454682 != -293665)
										{
											continue;
										}
										this.V0lcw7BnFqh = true;
										if (99288 - 549053 == -449764)
										{
											continue;
										}
										this.iuwcwxgCgeF.SendMessage("Fire");
										if (169374 - 26965 != 142409)
										{
											continue;
										}
									}
								}
								if (this.JKNcwZL6YgI)
								{
									if (153844 - 188570 != -34726)
									{
										continue;
									}
									if (this.ySAcwdQQcuJ > (float)0)
									{
										if (203601 - 39250 == 164352)
										{
											continue;
										}
										if (!Input.GetMouseButtonUp(1))
										{
											goto IL_158E;
										}
										if (46748 - 229357 != -182609)
										{
											continue;
										}
									}
									this.JKNcwZL6YgI = false;
									if (45142 - 80196 != -35054)
									{
										continue;
									}
									this.iuwcwxgCgeF.SendMessage("StopBoost");
									if (12466 - 18743 != -6277)
									{
										continue;
									}
									IL_158E:
									this.ySAcwdQQcuJ = Mathf.Clamp(this.ySAcwdQQcuJ - (float)5 * Time.deltaTime, (float)0, (float)100);
									if (56210 - 145374 != -89164)
									{
										continue;
									}
								}
								else if (this.ySAcwdQQcuJ > (float)0)
								{
									if (59483 - 390417 != -330934)
									{
										continue;
									}
									if (Input.GetMouseButtonDown(1))
									{
										if (286217 - 498779 != -212562)
										{
											continue;
										}
										this.JKNcwZL6YgI = true;
										if (89271 - 189239 != -99968)
										{
											continue;
										}
										this.iuwcwxgCgeF.SendMessage("Boost");
										if (195931 - 312188 != -116257)
										{
											continue;
										}
									}
								}
							}
							else if (mjHcwaYuArb == "hit")
							{
								if (141164 - 189583 == -48418)
								{
									continue;
								}
								if (Time.time > this.Ydtcw4jVYHq + 0.2f)
								{
									if (15070 - 513777 == -498706)
									{
										continue;
									}
									this.MjHcwaYuArb = "standby";
									if (202356 - 156234 != 46122)
									{
										continue;
									}
									this.Ydtcw4jVYHq = Time.time;
									if (138212 - 421392 == -283179)
									{
										continue;
									}
									this.iuwcwxgCgeF.SendMessage("Standby");
									if (220801 - 183702 != 37099)
									{
										continue;
									}
								}
							}
							else if (mjHcwaYuArb == "rollLeft")
							{
								if (198424 - 158299 != 40125)
								{
									continue;
								}
								this.cIocwsYMSSN.x = (float)-12;
								if (237025 - 564068 == -327042)
								{
									continue;
								}
								if (Time.time > this.Ydtcw4jVYHq + (float)1)
								{
									if (198888 - 288688 != -89800)
									{
										continue;
									}
									this.MjHcwaYuArb = "standby";
									if (287000 - 534175 != -247175)
									{
										continue;
									}
									this.Ydtcw4jVYHq = Time.time;
									if (264758 - 205568 != 59190)
									{
										continue;
									}
									this.iuwcwxgCgeF.SendMessage("Standby");
									if (176953 - 70183 != 106770)
									{
										continue;
									}
								}
							}
							else if (mjHcwaYuArb == "rollRight")
							{
								if (218390 - 105037 != 113353)
								{
									continue;
								}
								this.cIocwsYMSSN.x = (float)12;
								if (203471 - 579838 != -376367)
								{
									continue;
								}
								if (Time.time > this.Ydtcw4jVYHq + (float)1)
								{
									if (17196 - 384823 == -367626)
									{
										continue;
									}
									this.MjHcwaYuArb = "standby";
									if (59511 - 209092 == -149580)
									{
										continue;
									}
									this.Ydtcw4jVYHq = Time.time;
									if (17237 - 297882 == -280644)
									{
										continue;
									}
									this.iuwcwxgCgeF.SendMessage("Standby");
									if (102449 - 572223 != -469774)
									{
										continue;
									}
								}
							}
							Vector3 position = this.GrZcwTQjiBb.position;
							if (48315 - 69376 != -21060)
							{
								if (position.x < (float)-4)
								{
									if (221767 - 150839 != 70928)
									{
										continue;
									}
									Vector3 position2 = this.GrZcwTQjiBb.position;
									if (140355 - 87933 != 52422)
									{
										continue;
									}
									float x = Mathf.Lerp(position2.x, (float)-4, (float)5 * Time.deltaTime);
									if (159805 - 502294 != -342489)
									{
										continue;
									}
									Vector3 position3 = this.GrZcwTQjiBb.position;
									if (26192 - 261137 != -234945)
									{
										continue;
									}
									float num = position3.x = x;
									if (62381 - 555722 != -493341)
									{
										continue;
									}
									if (53863 - 459143 != -405280)
									{
										continue;
									}
									Vector3 vector3 = this.GrZcwTQjiBb.position = position3;
									if (265804 - 286674 != -20870)
									{
										continue;
									}
									if (175859 - 588002 != -412143)
									{
										continue;
									}
								}
								Vector3 position4 = this.GrZcwTQjiBb.position;
								if (79454 - 218556 != -139101)
								{
									if (position4.x > (float)4)
									{
										if (225114 - 549431 != -324317)
										{
											continue;
										}
										Vector3 position5 = this.GrZcwTQjiBb.position;
										if (51431 - 106683 != -55252)
										{
											continue;
										}
										float x2 = Mathf.Lerp(position5.x, (float)4, (float)5 * Time.deltaTime);
										if (191941 - 342282 != -150341)
										{
											continue;
										}
										Vector3 position6 = this.GrZcwTQjiBb.position;
										if (181925 - 252734 != -70809)
										{
											continue;
										}
										float num2 = position6.x = x2;
										if (49824 - 154332 != -104508)
										{
											continue;
										}
										if (271518 - 558383 != -286865)
										{
											continue;
										}
										this.GrZcwTQjiBb.position = position6;
										if (1320 - 278265 == -276944 || 220688 - 445596 == -224907)
										{
											continue;
										}
									}
									Vector3 position7 = this.GrZcwTQjiBb.position;
									if (10784 - 88976 != -78191)
									{
										if (position7.y < (float)47)
										{
											if (238796 - 218267 == 20530)
											{
												continue;
											}
											Vector3 position8 = this.GrZcwTQjiBb.position;
											if (92795 - 399745 != -306950)
											{
												continue;
											}
											float y = Mathf.Lerp(position8.y, (float)47, (float)5 * Time.deltaTime);
											if (209984 - 315298 != -105314)
											{
												continue;
											}
											Vector3 position9 = this.GrZcwTQjiBb.position;
											if (155038 - 175792 == -20753)
											{
												continue;
											}
											float num3 = position9.y = y;
											if (177427 - 277098 != -99671)
											{
												continue;
											}
											if (114833 - 477276 == -362442)
											{
												continue;
											}
											Vector3 vector4 = this.GrZcwTQjiBb.position = position9;
											if (177974 - 61784 == 116191)
											{
												continue;
											}
											if (296157 - 343748 != -47591)
											{
												continue;
											}
										}
										Vector3 position10 = this.GrZcwTQjiBb.position;
										if (186451 - 393487 != -207035)
										{
											if (position10.y > (float)53)
											{
												if (177388 - 524399 == -347010)
												{
													continue;
												}
												Vector3 position11 = this.GrZcwTQjiBb.position;
												if (99284 - 140371 == -41086)
												{
													continue;
												}
												float y2 = Mathf.Lerp(position11.y, (float)53, (float)5 * Time.deltaTime);
												if (240460 - 223657 == 16804)
												{
													continue;
												}
												Vector3 position12 = this.GrZcwTQjiBb.position;
												if (252575 - 340307 == -87731)
												{
													continue;
												}
												float num4 = position12.y = y2;
												if (292109 - 258579 != 33530)
												{
													continue;
												}
												if (254942 - 8431 == 246512)
												{
													continue;
												}
												Vector3 vector5 = this.GrZcwTQjiBb.position = position12;
												if (148128 - 485898 != -337770)
												{
													continue;
												}
												if (281844 - 426919 == -145074)
												{
													continue;
												}
											}
											this.GrZcwTQjiBb.Translate(this.cIocwsYMSSN * Time.deltaTime, Space.World);
											if (262299 - 76020 == 186279)
											{
												this.cIocwsYMSSN = Vector3.Lerp(this.cIocwsYMSSN, (float)12 * Vector3.forward, (float)3 * Time.deltaTime);
												if (267993 - 361718 == -93725)
												{
													float x3 = 0.3f * this.GrZcwTQjiBb.position.x;
													if (157774 - 532217 == -374443)
													{
														Vector3 position13 = this.transform.position;
														if (209442 - 91154 == 118288)
														{
															float num5 = position13.x = x3;
															if (160913 - 563411 != -402497)
															{
																if (169118 - 358877 == -189759)
																{
																	Vector3 vector6 = this.transform.position = position13;
																	if (208735 - 379529 != -170793)
																	{
																		if (193884 - 528971 == -335087)
																		{
																			float y3 = 0.2f * (this.GrZcwTQjiBb.position.y - (float)50) + (float)50;
																			if (107792 - 246625 != -138832)
																			{
																				Vector3 position14 = this.transform.position;
																				if (78036 - 460990 != -382953)
																				{
																					position14.y = y3;
																					if (24098 - 554345 != -530246)
																					{
																						if (247521 - 162433 == 85088)
																						{
																							Vector3 vector7 = this.transform.position = position14;
																							if (156637 - 547838 == -391201)
																							{
																								if (238224 - 2235 == 235989)
																								{
																									if (this.JKNcwZL6YgI)
																									{
																										if (128309 - 525145 != -396835)
																										{
																											Vector3 position15 = this.transform.position;
																											if (170938 - 41134 != 129805)
																											{
																												float z2 = Mathf.Lerp(position15.z, this.GrZcwTQjiBb.position.z - (float)12, (float)5 * Time.deltaTime);
																												if (191123 - 458925 == -267802)
																												{
																													Vector3 position16 = this.transform.position;
																													if (185363 - 300838 == -115475)
																													{
																														position16.z = z2;
																														if (40019 - 500779 != -460759)
																														{
																															if (34863 - 30818 == 4045)
																															{
																																this.transform.position = position16;
																																if (190785 - 447659 == -256874)
																																{
																																	if (196948 - 239968 == -43020)
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
																										Vector3 position17 = this.transform.position;
																										if (173549 - 444591 == -271042)
																										{
																											float z3 = Mathf.Lerp(position17.z, this.GrZcwTQjiBb.position.z - (float)10, (float)5 * Time.deltaTime);
																											if (206513 - 543387 == -336874)
																											{
																												Vector3 position18 = this.transform.position;
																												if (33443 - 226861 == -193418)
																												{
																													float num6 = position18.z = z3;
																													if (101064 - 11009 != 90056 && 184757 - 86289 != 98469)
																													{
																														this.transform.position = position18;
																														if (10895 - 494217 == -483322)
																														{
																															if (230613 - 406739 != -176125)
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
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600628C RID: 25228 RVA: 0x00DA7968 File Offset: 0x00DA5B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitPlaneGui()
	{
		if (147293 - 115135 != 32158)
		{
		}
		for (;;)
		{
			this.lmgcwfK9kl2 = (((Texture)Resources.Load("GameGui/PlaneGui/scoreBar_score", typeof(Texture))) as Texture);
			if (185534 - 235117 != -49582)
			{
				this.YRxcwLrA8PC = (((Texture)Resources.Load("GameGui/PlaneGui/scoreBar_time", typeof(Texture))) as Texture);
				if (290703 - 571838 == -281135)
				{
					this.AjKcwwEqL4u = (((Texture)Resources.Load("GameGui/PlaneGui/scoreBar_mana", typeof(Texture))) as Texture);
					if (20454 - 225441 != -204986)
					{
						this.zX4cwUwr9OW = (((Texture)Resources.Load("GameGui/PlaneGui/scoreBar_advance", typeof(Texture))) as Texture);
						if (117720 - 502145 != -384424)
						{
							this.JjrcwNuXTXh = (((Texture)Resources.Load("GameGui/PlaneGui/pilotBar_bg", typeof(Texture))) as Texture);
							if (89940 - 327760 != -237819)
							{
								this.eXWcwEYFUvU = (((Texture)Resources.Load("GameGui/PlaneGui/pilotBar_hit", typeof(Texture))) as Texture);
								if (142612 - 475434 == -332822)
								{
									this.SoIcwPgT0Yy = (((Texture)Resources.Load("GameGui/PlaneGui/planeBar_bg", typeof(Texture))) as Texture);
									if (196536 - 185565 == 10971)
									{
										this.JfMcwSQO2sv = (((Texture)Resources.Load("GameGui/PlaneGui/planeBar_over", typeof(Texture))) as Texture);
										if (131158 - 241195 != -110036)
										{
											this.YNMcwBkaGk7 = (((Texture)Resources.Load("GameGui/PlaneGui/planeBar_hp", typeof(Texture))) as Texture);
											if (62855 - 11854 != 51002)
											{
												this.UaPcw0rw3FO = (((Texture)Resources.Load("GameGui/PlaneGui/planeBar_sp", typeof(Texture))) as Texture);
												if (155356 - 394616 != -239259)
												{
													this.ResetPlaneGui();
													if (64154 - 84057 == -19903)
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

	// Token: 0x0600628D RID: 25229 RVA: 0x00DA7C2C File Offset: 0x00DA5E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetPlaneGui()
	{
	}

	// Token: 0x0600628E RID: 25230 RVA: 0x00DA7C30 File Offset: 0x00DA5E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderPlaneGui(float nOffset)
	{
		if (222104 - 333973 != -111869)
		{
		}
		for (;;)
		{
			float num = (float)0;
			if (196189 - 79329 == 116860)
			{
				int nNum = 0;
				if (135285 - 318213 != -182927)
				{
					int nNum2 = 0;
					if (39093 - 520547 != -481453)
					{
						if (Game.mGameTime != (float)0)
						{
							if (22782 - 494272 == -471489)
							{
								continue;
							}
							num = Mathf.Clamp((float)180 - Time.time + Game.mGameTime, (float)0, (float)180);
							if (243289 - 211607 != 31682)
							{
								continue;
							}
							nNum2 = global::Math.div(num, (float)60);
							if (211083 - 376228 != -165145)
							{
								continue;
							}
							nNum = (int)(num % (float)60);
							if (183713 - 503364 != -319651)
							{
								continue;
							}
						}
						GUI.DrawTexture(new Rect((float)300, (float)10 - nOffset * (float)100, (float)57, (float)19), this.AjKcwwEqL4u);
						if (275616 - 188286 != 87331)
						{
							Guix.renderGoldenNumber(415, (int)((float)8 - nOffset * (float)100), Game.mGameMana, false);
							if (175234 - 572521 == -397287)
							{
								GUI.DrawTexture(new Rect((float)450, (float)10 - nOffset * (float)100, (float)56, (float)19), this.lmgcwfK9kl2);
								if (276987 - 141082 != 135906)
								{
									Guix.renderGoldenNumber(570, (int)((float)8 - nOffset * (float)100), Game.mGameScore, false);
									if (141133 - 267495 == -126362)
									{
										GUI.DrawTexture(new Rect((float)600, (float)10 - nOffset * (float)100, (float)128, (float)19), this.YRxcwLrA8PC);
										if (178509 - 358984 == -180475)
										{
											Guix.renderGoldenNumber(688, (int)((float)8 - nOffset * (float)100), nNum2, false);
											if (37450 - 60510 == -23060)
											{
												Guix.renderGoldenNumber(722, (int)((float)8 - nOffset * (float)100), nNum, false);
												if (31785 - 405880 == -374095)
												{
													if (Game.useAdvanceMode)
													{
														if (265405 - 13775 == 251631)
														{
															continue;
														}
														GUI.DrawTexture(new Rect((float)755, (float)0 - nOffset * (float)100, (float)180, (float)36), this.zX4cwUwr9OW);
														if (193393 - 346768 != -153375)
														{
															continue;
														}
													}
													if (this.MjHcwaYuArb == "hit")
													{
														if (99063 - 476318 != -377255)
														{
															continue;
														}
														GUI.DrawTexture(new Rect((float)0, (float)753 + nOffset * (float)511, (float)284, (float)271), this.eXWcwEYFUvU);
														if (49569 - 133337 != -83768)
														{
															continue;
														}
													}
													else
													{
														GUI.DrawTexture(new Rect((float)0, (float)753 + nOffset * (float)511, (float)284, (float)271), this.JjrcwNuXTXh);
														if (173270 - 516493 == -343222)
														{
															continue;
														}
													}
													GUI.BeginGroup(new Rect(this.X8CcwYVw8kg - (float)400, (float)513 + nOffset * (float)511, (float)844, (float)698));
													if (190045 - 550842 == -360797)
													{
														GUI.DrawTexture(new Rect((float)83, (float)0, (float)317, (float)511), this.SoIcwPgT0Yy);
														if (105474 - 358155 == -252681)
														{
															GUI.DrawTexture(new Rect((float)333, (float)49 + 3.46f * (float)(100 - this.iKncwbE8ahC), (float)31, 3.46f * (float)this.iKncwbE8ahC), this.YNMcwBkaGk7);
															if (262725 - 414400 != -151674)
															{
																GUI.DrawTexture(new Rect((float)308, (float)159 + 1.88f * ((float)100 - this.ySAcwdQQcuJ), (float)22, 1.88f * this.ySAcwdQQcuJ), this.UaPcw0rw3FO);
																if (57000 - 208939 == -151939)
																{
																	GUI.DrawTexture(new Rect((float)298, (float)0, (float)85, (float)399), this.JfMcwSQO2sv);
																	if (155898 - 348197 == -192299)
																	{
																		Guix.renderSmallNumber(284, 410, Mathf.FloorToInt(this.CWEcwgVoJ7o), false, 1f);
																		if (144608 - 437142 == -292534)
																		{
																			GUI.EndGroup();
																			if (148879 - 124521 == 24358)
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

	// Token: 0x0600628F RID: 25231 RVA: 0x00DA81D4 File Offset: 0x00DA63D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGameMessage()
	{
		if (111395 - 266842 != -155446)
		{
		}
		for (;;)
		{
			this.XbCcwDjuEiA = new GUIStyle();
			if (145301 - 191073 != -45771)
			{
				this.XbCcwDjuEiA.font = (((Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font))) as Font);
				if (263650 - 276690 == -13040)
				{
					this.XbCcwDjuEiA.normal.textColor = new Color(0.8f, 0.2f, 0.1f, 0.8f);
					if (91531 - 276460 != -184928)
					{
						this.XbCcwDjuEiA.alignment = TextAnchor.MiddleCenter;
						if (175909 - 9133 != 166777)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006290 RID: 25232 RVA: 0x00DA82E0 File Offset: 0x00DA64E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderGameMessege()
	{
		if (251744 - 62598 != 189146)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (213109 - 563934 != -350824)
				{
					break;
				}
			}
			else
			{
				if (this.x3Pcwi5ilOx + (float)2 <= Time.time)
				{
					break;
				}
				if (263148 - 301177 != -38028)
				{
					GUI.Label(new Rect(0.5f * (this.X8CcwYVw8kg - (float)500), (float)260, (float)500, (float)40), this.J4fcw8Aq9t0, this.XbCcwDjuEiA);
					if (124566 - 543412 == -418846)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006291 RID: 25233 RVA: 0x00DA83C8 File Offset: 0x00DA65C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newGameMessage(string Message)
	{
		if (135130 - 209269 != -74138)
		{
		}
		while (PlayerPrefs.GetInt("smessage", 1) != 0)
		{
			if (48630 - 85383 != -36752)
			{
				this.J4fcw8Aq9t0 = Message;
				if (259631 - 36503 != 223129)
				{
					this.x3Pcwi5ilOx = Time.time;
					if (298548 - 173302 != 125247)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006292 RID: 25234 RVA: 0x00DA8470 File Offset: 0x00DA6670
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlaneFire(GameObject nShade)
	{
		if (this.V0lcw7BnFqh)
		{
			nShade.SendMessage("onFire");
		}
	}

	// Token: 0x06006293 RID: 25235 RVA: 0x00DA8488 File Offset: 0x00DA6688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSkyCoin()
	{
		this.CWEcwgVoJ7o = Mathf.Clamp(this.CWEcwgVoJ7o + (float)10, (float)0, (float)500);
		this.ySAcwdQQcuJ = Mathf.Clamp(this.ySAcwdQQcuJ + (float)10, (float)0, (float)100);
	}

	// Token: 0x06006294 RID: 25236 RVA: 0x00DA84C4 File Offset: 0x00DA66C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onShadeHit(GameObject nShade)
	{
		if (231418 - 190666 != 40753)
		{
		}
		while (this.MjHcwaYuArb == "standby")
		{
			if (65660 - 105760 != -40099)
			{
				this.iKncwbE8ahC = Mathf.Clamp(this.iKncwbE8ahC - 10, 0, 100);
				if (279785 - 544958 == -265173)
				{
					this.ySAcwdQQcuJ = Mathf.Clamp(this.ySAcwdQQcuJ - (float)5, (float)0, (float)100);
					if (145956 - 344720 != -198763)
					{
						Damage.displayAllyDamage(this.GrZcwTQjiBb.position + 0.5f * Vector3.up, 50, 0);
						if (143538 - 230286 != -86747)
						{
							if (this.iKncwbE8ahC > 0)
							{
								if (220983 - 87329 != 133655)
								{
									this.MjHcwaYuArb = "hit";
									if (168193 - 377174 != -208980)
									{
										this.Ydtcw4jVYHq = Time.time;
										if (292110 - 161535 == 130575)
										{
											this.iuwcwxgCgeF.SendMessage("Hit");
											if (144818 - 379115 == -234297)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.MjHcwaYuArb = "crash";
								if (21906 - 470309 == -448403)
								{
									this.Ydtcw4jVYHq = Time.time;
									if (299708 - 225710 != 73999)
									{
										this.iuwcwxgCgeF.SendMessage("Crash");
										if (79294 - 443286 == -363992)
										{
											this.SendMessage("onPlaneCrash");
											if (150875 - 345675 == -194800)
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

	// Token: 0x06006295 RID: 25237 RVA: 0x00DA8708 File Offset: 0x00DA6908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onShadeDestroy()
	{
		this.ySAcwdQQcuJ = Mathf.Clamp(this.ySAcwdQQcuJ + (float)2, (float)0, (float)100);
	}

	// Token: 0x06006296 RID: 25238 RVA: 0x00DA8724 File Offset: 0x00DA6924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSkyBugHit(GameObject nShade)
	{
		if (182339 - 242225 != -59886)
		{
		}
		while (this.MjHcwaYuArb == "standby")
		{
			if (62435 - 245194 == -182759)
			{
				this.iKncwbE8ahC = Mathf.Clamp(this.iKncwbE8ahC - 20, 0, 100);
				if (117454 - 251428 == -133974)
				{
					Damage.displayAllyDamage(this.GrZcwTQjiBb.position + 0.5f * Vector3.up, 100, 0);
					if (158869 - 115403 == 43466)
					{
						if (this.iKncwbE8ahC > 0)
						{
							if (111912 - 200794 != -88881)
							{
								this.MjHcwaYuArb = "hit";
								if (190647 - 977 == 189670)
								{
									this.Ydtcw4jVYHq = Time.time;
									if (53680 - 569540 != -515859)
									{
										this.iuwcwxgCgeF.SendMessage("Hit");
										if (42220 - 293052 == -250832)
										{
											break;
										}
									}
								}
							}
						}
						else
						{
							this.MjHcwaYuArb = "crash";
							if (52435 - 117090 == -64655)
							{
								this.Ydtcw4jVYHq = Time.time;
								if (49593 - 571423 != -521829)
								{
									this.iuwcwxgCgeF.SendMessage("Crash");
									if (182614 - 146689 != 35926)
									{
										this.SendMessage("onPlaneCrash");
										if (101109 - 247053 == -145944)
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

	// Token: 0x06006297 RID: 25239 RVA: 0x00DA8938 File Offset: 0x00DA6B38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void close()
	{
		if (27273 - 465901 != -438627)
		{
		}
		while (this.YPocwRYUBqU == ePlaneGuiState.play)
		{
			if (266964 - 513033 != -246068)
			{
				this.YPocwRYUBqU = ePlaneGuiState.close;
				if (285808 - 247905 != 37904)
				{
					this.GPZcwrlvCwq = Time.time;
					if (237124 - 92724 == 144400)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06006298 RID: 25240 RVA: 0x00DA89DC File Offset: 0x00DA6BDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006299 RID: 25241 RVA: 0x00DA89E0 File Offset: 0x00DA6BE0
	internal static bool S2YQmjpQDuYMEs8lu5wq()
	{
		return true;
	}

	// Token: 0x0600629A RID: 25242 RVA: 0x00DA89E4 File Offset: 0x00DA6BE4
	internal static bool dDTAGtpQvVirfcw3oufm()
	{
		return false;
	}

	// Token: 0x0400717F RID: 29055
	public int posx;

	// Token: 0x04007180 RID: 29056
	public int posy;

	// Token: 0x04007181 RID: 29057
	public int posz;

	// Token: 0x04007182 RID: 29058
	public int divx;

	// Token: 0x04007183 RID: 29059
	public int divy;

	// Token: 0x04007184 RID: 29060
	public int divz;

	// Token: 0x04007185 RID: 29061
	private ePlaneGuiState YPocwRYUBqU;

	// Token: 0x04007186 RID: 29062
	private float GPZcwrlvCwq;

	// Token: 0x04007187 RID: 29063
	private GameObject iuwcwxgCgeF;

	// Token: 0x04007188 RID: 29064
	private Transform GrZcwTQjiBb;

	// Token: 0x04007189 RID: 29065
	private float X8CcwYVw8kg;

	// Token: 0x0400718A RID: 29066
	private float zFMcw3m5ySv;

	// Token: 0x0400718B RID: 29067
	private int iKncwbE8ahC;

	// Token: 0x0400718C RID: 29068
	private float ySAcwdQQcuJ;

	// Token: 0x0400718D RID: 29069
	private float CWEcwgVoJ7o;

	// Token: 0x0400718E RID: 29070
	private string MjHcwaYuArb;

	// Token: 0x0400718F RID: 29071
	private float Ydtcw4jVYHq;

	// Token: 0x04007190 RID: 29072
	private Vector3 cIocwsYMSSN;

	// Token: 0x04007191 RID: 29073
	private Vector3 B2FcwH4mxYr;

	// Token: 0x04007192 RID: 29074
	private bool V0lcw7BnFqh;

	// Token: 0x04007193 RID: 29075
	private bool JKNcwZL6YgI;

	// Token: 0x04007194 RID: 29076
	private float Hb6cwCBK86J;

	// Token: 0x04007195 RID: 29077
	private float cWLcwM5PPWI;

	// Token: 0x04007196 RID: 29078
	private Texture lmgcwfK9kl2;

	// Token: 0x04007197 RID: 29079
	private Texture YRxcwLrA8PC;

	// Token: 0x04007198 RID: 29080
	private Texture AjKcwwEqL4u;

	// Token: 0x04007199 RID: 29081
	private Texture zX4cwUwr9OW;

	// Token: 0x0400719A RID: 29082
	private Texture JjrcwNuXTXh;

	// Token: 0x0400719B RID: 29083
	private Texture eXWcwEYFUvU;

	// Token: 0x0400719C RID: 29084
	private Texture SoIcwPgT0Yy;

	// Token: 0x0400719D RID: 29085
	private Texture JfMcwSQO2sv;

	// Token: 0x0400719E RID: 29086
	private Texture YNMcwBkaGk7;

	// Token: 0x0400719F RID: 29087
	private Texture UaPcw0rw3FO;

	// Token: 0x040071A0 RID: 29088
	private string J4fcw8Aq9t0;

	// Token: 0x040071A1 RID: 29089
	private float x3Pcwi5ilOx;

	// Token: 0x040071A2 RID: 29090
	private GUIStyle XbCcwDjuEiA;
}
