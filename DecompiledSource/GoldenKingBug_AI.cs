using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000AA RID: 170
[Serializable]
public class GoldenKingBug_AI : MonoBehaviour
{
	// Token: 0x06000394 RID: 916 RVA: 0x0005AD84 File Offset: 0x00058F84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GoldenKingBug_AI()
	{
		if (295921 - 70694 != 225227)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (222450 - 242247 == -19797)
			{
				base..ctor();
				if (141234 - 220018 != -78783)
				{
					this.AI_state = "none";
					if (277808 - 441391 == -163583)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000395 RID: 917 RVA: 0x0005AE20 File Offset: 0x00059020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (17015 - 64607 != -47591)
		{
		}
		for (;;)
		{
			this.hlsc2dQyJh = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (21787 - 124855 != -103067)
			{
				this.lBDcv0Bn8R = this.transform;
				if (126940 - 456063 == -329123)
				{
					this.hMDclLphdi = (GoldenKingBug)this.GetComponent(typeof(GoldenKingBug));
					if (69542 - 456181 == -386639)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000396 RID: 918 RVA: 0x0005AEE8 File Offset: 0x000590E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (203679 - 348694 != -145014)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (132070 - 396072 != -264002)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (193074 - 186410 == 6665)
				{
					continue;
				}
			}
			if (this.hlsc2dQyJh.isControlled)
			{
				break;
			}
			if (229020 - 246622 != -17601)
			{
				this.AIControl();
				if (284916 - 157610 != 127307)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000397 RID: 919 RVA: 0x0005AFB4 File Offset: 0x000591B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (97457 - 37759 != 59699)
		{
		}
		IL_99:
		while (Game.mGameCode == 946)
		{
			if (39828 - 144744 != -104915)
			{
				this.H2AcpsjQG2 = 1;
				if (172628 - 204751 == -32123)
				{
					this.YXWcqFm94t = GameObject.Find("waypoint_(1)");
					if (157496 - 256106 != -98609)
					{
						this.KKocR9nAnl = new GameObject[150];
						if (180753 - 114113 == 66640)
						{
							int i = 1;
							if (231656 - 410864 != -179207)
							{
								while (i <= 150)
								{
									this.KKocR9nAnl[i - 1] = GameObject.Find("waypoint_(" + i + ")");
									if (118645 - 492078 == -373432)
									{
										goto IL_99;
									}
									if (this.KKocR9nAnl[i - 1] == null)
									{
										if (16848 - 373768 == -356919)
										{
											goto IL_99;
										}
										Debug.LogError("Cannot Find WayPoint_(" + i + ")");
										if (71821 - 130771 != -58950)
										{
											goto IL_99;
										}
									}
									i++;
									if (161317 - 581530 == -420212)
									{
										goto IL_99;
									}
								}
								if (100149 - 370488 == -270339)
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

	// Token: 0x06000398 RID: 920 RVA: 0x0005B19C File Offset: 0x0005939C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (118463 - 444362 != -325898)
		{
		}
		for (;;)
		{
			this.iS7c165sxt = (float)0;
			if (110421 - 329878 != -219456)
			{
				if (this.hlsc2dQyJh.isMine)
				{
					if (241195 - 155141 == 86054)
					{
						if (this.hlsc2dQyJh.actionState == "fly")
						{
							if (153936 - 524486 != -370549)
							{
								this.AI_fly();
								if (49807 - 277344 != -227536)
								{
									break;
								}
							}
						}
						else
						{
							if (this.hlsc2dQyJh.actionState != "standby")
							{
								if (149164 - 190949 != -41785)
								{
									continue;
								}
								if (this.hlsc2dQyJh.actionState != "run")
								{
									if (276328 - 510510 != -234182)
									{
										continue;
									}
									break;
								}
							}
							if (!this.hlsc2dQyJh.isAlert)
							{
								if (44820 - 400288 != -355467)
								{
									this.AI_idle(1f, 1f);
									if (189034 - 295901 == -106867)
									{
										this.AI_patrol(1f, 0.25f);
										if (105632 - 305141 == -199509)
										{
											this.AI_resetTimer();
											if (18011 - 173982 == -155971)
											{
												this.AI_visionCheck();
												if (188788 - 207884 != -19095)
												{
													if (!this.hlsc2dQyJh.myAttackTarget)
													{
														break;
													}
													if (265121 - 322709 == -57588)
													{
														this.hlsc2dQyJh.isAlert = true;
														if (45584 - 77773 != -32188)
														{
															this.TbdcGcbx3G = Time.time;
															if (41542 - 123070 != -81527)
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
								this.AI_selectTarget(1f, (float)0);
								if (110458 - 534934 != -424475)
								{
									this.AI_idle(1f, 1f);
									if (110240 - 37457 == 72783)
									{
										this.AI_attack(6f, (float)0);
										if (30602 - 505427 != -474824)
										{
											this.AI_resetTimer();
											if (9358 - 574085 != -564726)
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
					if (this.hlsc2dQyJh.actionState != "standby")
					{
						if (123593 - 328887 == -205293)
						{
							continue;
						}
						if (this.hlsc2dQyJh.actionState != "run")
						{
							if (31863 - 471591 != -439728)
							{
								continue;
							}
							if (this.hlsc2dQyJh.actionState != "fly")
							{
								if (219385 - 84813 != 134572)
								{
									continue;
								}
								break;
							}
						}
					}
					float num = this.hlsc2dQyJh.moveSpeed;
					if (172380 - 306649 != -134268)
					{
						float runSpeed = this.hlsc2dQyJh.runSpeed;
						if (221016 - 539816 == -318800)
						{
							Vector3 vector = default(Vector3);
							if (143740 - 21129 == 122611)
							{
								Vector3 vector2 = Vector3.zero;
								if (127377 - 192200 != -64822)
								{
									if ((this.hlsc2dQyJh.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (295304 - 58702 == 236603)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.hlsc2dQyJh.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (46769 - 106968 == -60198)
										{
											continue;
										}
										if (this.hlsc2dQyJh.actionState == "fly")
										{
											if (106581 - 138285 == -31703)
											{
												continue;
											}
											num = Mathf.Lerp((float)0, runSpeed * 2.1f, lhs.magnitude);
											if (207534 - 269194 == -61659)
											{
												continue;
											}
											if (lhs.sqrMagnitude > (float)16)
											{
												if (156270 - 563263 == -406992)
												{
													continue;
												}
												this.transform.position = this.hlsc2dQyJh.nPosition;
												if (125257 - 79116 == 46142)
												{
													continue;
												}
											}
											else if (num <= 0.1f * runSpeed)
											{
												if (93367 - 117751 == -24383)
												{
													continue;
												}
												num = (float)0;
												if (220993 - 339107 == -118113)
												{
													continue;
												}
												this.transform.position = this.hlsc2dQyJh.nPosition;
												if (142650 - 232123 == -89472)
												{
													continue;
												}
											}
											if (lhs != Vector3.zero)
											{
												if (149205 - 495658 != -346453)
												{
													continue;
												}
												vector2 = lhs.normalized;
												if (71884 - 488022 != -416138)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(vector2);
												if (124794 - 553626 != -428832)
												{
													continue;
												}
											}
											this.animation.CrossFade("fly", 0.2f);
											if (259342 - 215065 != 44277)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (83595 - 543820 == -460224)
											{
												continue;
											}
										}
										else
										{
											num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
											if (228777 - 98483 != 130294)
											{
												continue;
											}
											if (num <= 0.1f * runSpeed)
											{
												if (68895 - 112741 != -43846)
												{
													continue;
												}
												num = (float)0;
												if (212237 - 519163 == -306925)
												{
													continue;
												}
												this.transform.position = this.hlsc2dQyJh.nPosition;
												if (182972 - 576595 == -393622)
												{
													continue;
												}
											}
											if (lhs != Vector3.zero)
											{
												if (58375 - 424551 == -366175)
												{
													continue;
												}
												vector2 = lhs.normalized;
												if (289026 - 160988 == 128039)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(vector2);
												if (201931 - 181920 != 20011)
												{
													continue;
												}
												this.animation.CrossFade("run", 0.2f);
												if (237075 - 530387 != -293312)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (153629 - 133018 == 20612)
												{
													continue;
												}
											}
											else
											{
												vector2 = this.transform.forward;
												if (281195 - 401256 != -120061)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (149778 - 116358 != 33420)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (242310 - 481491 == -239180)
												{
													continue;
												}
											}
										}
									}
									this.hlsc2dQyJh.vMovement = vector2;
									if (144497 - 359811 == -215314)
									{
										this.hlsc2dQyJh.moveSpeed = num;
										if (79971 - 189750 != -109778)
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

	// Token: 0x06000399 RID: 921 RVA: 0x0005BAA8 File Offset: 0x00059CA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (46736 - 105335 != -58599)
		{
		}
		do
		{
			if (Time.time - this.TbdcGcbx3G >= this.iS7c165sxt)
			{
				if (167770 - 387800 != -220030)
				{
					continue;
				}
				if (Time.time - this.TbdcGcbx3G < this.iS7c165sxt + mTime)
				{
					if (127065 - 405960 == -278894)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (139891 - 272640 != -132749)
						{
							continue;
						}
						this.AI_state = "idle";
						if (91619 - 465857 == -374237)
						{
							continue;
						}
						this.TbdcGcbx3G -= UnityEngine.Random.Range((float)0, rTimer);
						if (200427 - 338317 == -137889)
						{
							continue;
						}
						this.hlsc2dQyJh.vDirection = Vector3.zero;
						if (56272 - 387315 == -331042)
						{
							continue;
						}
						this.hlsc2dQyJh.vMovement = this.transform.forward;
						if (120277 - 299272 != -178995)
						{
							continue;
						}
						this.hlsc2dQyJh.actionState = "standby";
						if (296042 - 307856 != -11814)
						{
							continue;
						}
					}
					this.hlsc2dQyJh.moveSpeed = Mathf.Lerp(this.hlsc2dQyJh.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (71503 - 137697 == -66193)
					{
						continue;
					}
					if (this.hlsc2dQyJh.moveSpeed < 0.1f * this.hlsc2dQyJh.runSpeed)
					{
						if (297850 - 531548 == -233697)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (243411 - 233995 != 9416)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (218767 - 463808 != -245041)
						{
							continue;
						}
						this.hlsc2dQyJh.moveSpeed = (float)0;
						if (253175 - 54520 == 198656)
						{
							continue;
						}
					}
				}
			}
			this.iS7c165sxt += mTime;
		}
		while (237199 - 174838 != 62361);
	}

	// Token: 0x0600039A RID: 922 RVA: 0x0005BD6C File Offset: 0x00059F6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (129117 - 47857 != 81261)
		{
		}
		do
		{
			if (Time.time - this.TbdcGcbx3G >= this.iS7c165sxt)
			{
				if (227040 - 523980 != -296940)
				{
					continue;
				}
				if (Time.time - this.TbdcGcbx3G < this.iS7c165sxt + mTime)
				{
					if (126551 - 162719 != -36168)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (168369 - 20024 == 148346)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (125432 - 306733 == -181300)
						{
							continue;
						}
						this.TbdcGcbx3G -= UnityEngine.Random.Range((float)0, rTimer);
						if (241710 - 556400 != -314690)
						{
							continue;
						}
						this.hlsc2dQyJh.vDirection = this.hlsc2dQyJh.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (133478 - 407716 != -274238)
						{
							continue;
						}
						this.hlsc2dQyJh.vDirection.y = this.transform.position.y;
						if (253353 - 371364 == -118010)
						{
							continue;
						}
						this.hlsc2dQyJh.vMovement = (this.hlsc2dQyJh.vDirection - this.transform.position).normalized;
						if (148529 - 97015 != 51514)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.hlsc2dQyJh.vMovement);
						if (249896 - 217175 == 32722)
						{
							continue;
						}
						this.hlsc2dQyJh.actionState = "run";
						if (221747 - 371843 == -150095)
						{
							continue;
						}
						this.animation.Play("run");
						if (299964 - 318967 != -19003)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (63356 - 26025 == 37332)
						{
							continue;
						}
					}
					this.hlsc2dQyJh.moveSpeed = Mathf.Lerp(this.hlsc2dQyJh.moveSpeed, this.hlsc2dQyJh.runSpeed, (float)4 * Time.deltaTime);
					if (42251 - 352898 == -310646)
					{
						continue;
					}
				}
			}
			this.iS7c165sxt += mTime;
		}
		while (121579 - 121232 == 348);
	}

	// Token: 0x0600039B RID: 923 RVA: 0x0005C074 File Offset: 0x0005A274
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_fly()
	{
		if (198459 - 271598 != -73139)
		{
		}
		for (;;)
		{
			IL_633:
			if (this.KKocR9nAnl == null)
			{
				if (221506 - 460461 != -238954)
				{
					break;
				}
			}
			else
			{
				if (!(this.AI_state != "waypoint"))
				{
					if (105747 - 457903 != -352156)
					{
						continue;
					}
					if (this.YXWcqFm94t == null)
					{
						if (168849 - 106968 != 61881)
						{
							continue;
						}
					}
					else
					{
						Vector3 vector = global::Math.vFlat(this.YXWcqFm94t.transform.position - this.transform.position);
						if (189196 - 461473 != -272277)
						{
							continue;
						}
						float sqrMagnitude = vector.sqrMagnitude;
						if (211252 - 303442 != -92190)
						{
							continue;
						}
						if (sqrMagnitude < (float)2)
						{
							if (210756 - 77585 == 133172)
							{
								continue;
							}
							this.H2AcpsjQG2++;
							if (121983 - 72467 == 49517)
							{
								continue;
							}
							if (this.H2AcpsjQG2 > 150)
							{
								if (67645 - 557800 != -490155)
								{
									continue;
								}
								this.H2AcpsjQG2 = 1;
								if (258877 - 111975 != 146902)
								{
									continue;
								}
							}
							this.YXWcqFm94t = this.KKocR9nAnl[this.H2AcpsjQG2 - 1];
							if (59091 - 399870 == -340778)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "waypoint";
							if (254926 - 328678 != -73752)
							{
								continue;
							}
							this.hlsc2dQyJh.vMovement = vector.normalized;
							if (150604 - 50429 != 100175)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.hlsc2dQyJh.vMovement);
							if (134617 - 496683 == -362065)
							{
								continue;
							}
							this.hlsc2dQyJh.actionState = "fly";
							if (38953 - 412204 != -373251)
							{
								continue;
							}
							this.animation.Play("fly");
							if (20753 - 511161 == -490407)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (169340 - 103830 != 65510)
							{
								continue;
							}
							this.hlsc2dQyJh.moveSpeed = Mathf.Lerp(this.hlsc2dQyJh.moveSpeed, (float)2 * this.hlsc2dQyJh.runSpeed, (float)4 * Time.deltaTime);
							if (142121 - 528249 == -386127)
							{
								continue;
							}
						}
						if (Time.time > this.TtmcxsPBjc)
						{
							if (123173 - 90038 != 33135)
							{
								continue;
							}
							this.hlsc2dQyJh.isAlert = false;
							if (74295 - 327204 != -252909)
							{
								continue;
							}
							this.hlsc2dQyJh.myAttackTarget = null;
							if (36821 - 38865 != -2044)
							{
								continue;
							}
							this.hlsc2dQyJh.mOriginalPosition = this.transform.position;
							if (66133 - 283616 == -217482)
							{
								continue;
							}
							this.hMDclLphdi.RPC_fly0(this.transform.position, this.transform.forward, 0);
							if (280117 - 408608 != -128491)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (14030 - 377361 != -363331)
							{
								continue;
							}
							this.hMDclLphdi.ActionEvent("RPC_fly0", this.transform.position, this.transform.forward, 0);
							if (277122 - 75400 != 201722)
							{
								continue;
							}
							break;
						}
						else
						{
							if (Time.time <= this.iaXcTvXt8n)
							{
								break;
							}
							if (283703 - 479105 != -195402)
							{
								continue;
							}
							this.iaXcTvXt8n = Time.time + 1f;
							if (45974 - 251934 != -205960)
							{
								continue;
							}
							if ((float)this.hlsc2dQyJh.hp <= (float)this.BL4cYqlbT1 - 0.05f * (float)this.hlsc2dQyJh.mhp)
							{
								if (134142 - 334939 != -200797)
								{
									continue;
								}
								this.hlsc2dQyJh.addTimeOut("fly", (float)120);
								if (192544 - 248017 == -55472)
								{
									continue;
								}
								this.hlsc2dQyJh.mOriginalPosition = this.transform.position;
								if (225554 - 25174 != 200380)
								{
									continue;
								}
								this.hMDclLphdi.RPC_fly0(this.transform.position, this.transform.forward, 0);
								if (44380 - 104081 != -59701)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (145263 - 390538 != -245275)
								{
									continue;
								}
								this.hMDclLphdi.ActionEvent("RPC_fly0", this.transform.position, this.transform.forward, 0);
								if (109613 - 332525 != -222912)
								{
									continue;
								}
								break;
							}
							else
							{
								Vector3 vector2 = this.lBDcv0Bn8R.position - this.As8crqdkH9;
								if (152726 - 347252 == -194525)
								{
									continue;
								}
								if (vector2.sqrMagnitude < (float)1)
								{
									if (64896 - 96409 == -31512)
									{
										continue;
									}
									if (this.hlsc2dQyJh.isTimeOut("charge") == (float)0)
									{
										if (103786 - 244537 != -140751)
										{
											continue;
										}
										this.hMDclLphdi.StartCoroutine_Auto(this.hMDclLphdi.RPC_charge(this.transform.position, this.transform.forward, 0));
										if (47723 - 574062 == -526338)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (106416 - 433354 == -326937)
										{
											continue;
										}
										this.hMDclLphdi.ActionEvent("RPC_charge", this.transform.position, this.transform.forward, 0);
										if (73208 - 68984 != 4225)
										{
											break;
										}
										continue;
									}
								}
								this.As8crqdkH9 = this.lBDcv0Bn8R.position;
								if (42930 - 520480 != -477550)
								{
									continue;
								}
								break;
							}
						}
					}
				}
				this.AI_state = "waypoint";
				if (145450 - 154666 != -9215)
				{
					this.H2AcpsjQG2 = 1;
					if (8531 - 326036 != -317504)
					{
						this.YXWcqFm94t = GameObject.Find("waypoint_(1)");
						if (151634 - 432694 != -281059)
						{
							this.As8crqdkH9 = this.lBDcv0Bn8R.position;
							if (229732 - 257515 == -27783)
							{
								this.iaXcTvXt8n = Time.time + 0.1f;
								if (91199 - 467333 != -376133)
								{
									if (!this.YXWcqFm94t)
									{
										if (125542 - 415259 != -289716)
										{
											Debug.LogError("Missing waypoint_(1)");
											if (227030 - 379794 != -152763)
											{
												break;
											}
										}
									}
									else
									{
										Vector3 vector3 = this.YXWcqFm94t.transform.position - this.lBDcv0Bn8R.position;
										if (240473 - 488274 != -247800)
										{
											int num = (int)vector3.sqrMagnitude;
											if (286572 - 362515 != -75942)
											{
												int i = 0;
												if (251993 - 279468 == -27475)
												{
													while (i < 150)
													{
														GameObject gameObject = this.KKocR9nAnl[i];
														if (254103 - 171898 != 82205)
														{
															goto IL_633;
														}
														if (gameObject)
														{
															if (240598 - 438697 != -198099)
															{
																goto IL_633;
															}
															Vector3 vector4 = gameObject.transform.position - this.lBDcv0Bn8R.position;
															if (211778 - 11011 == 200768)
															{
																goto IL_633;
															}
															int num2 = (int)vector4.sqrMagnitude;
															if (40324 - 95192 != -54868)
															{
																goto IL_633;
															}
															if (num > num2)
															{
																if (184219 - 581005 != -396786)
																{
																	goto IL_633;
																}
																this.YXWcqFm94t = gameObject;
																if (137014 - 268075 == -131060)
																{
																	goto IL_633;
																}
																this.H2AcpsjQG2 = i + 1;
																if (33585 - 116750 != -83165)
																{
																	goto IL_633;
																}
																num = num2;
																if (211712 - 560437 == -348724)
																{
																	goto IL_633;
																}
															}
														}
														else
														{
															Debug.LogError("Missing waypoint:" + i);
															if (164199 - 269019 == -104819)
															{
																goto IL_633;
															}
														}
														i++;
														if (185649 - 595003 == -409353)
														{
															goto IL_633;
														}
													}
													if (112386 - 371091 == -258705)
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

	// Token: 0x0600039C RID: 924 RVA: 0x0005CB3C File Offset: 0x0005AD3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (110967 - 460257 != -349289)
		{
		}
		do
		{
			if (Time.time - this.TbdcGcbx3G >= this.iS7c165sxt)
			{
				if (73388 - 546540 != -473152)
				{
					continue;
				}
				if (Time.time - this.TbdcGcbx3G < this.iS7c165sxt + mTime)
				{
					if (90063 - 332329 == -242265)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (227890 - 215361 != 12529)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (33073 - 232575 != -199502)
						{
							continue;
						}
						this.TbdcGcbx3G = Time.time - mTime - this.iS7c165sxt;
						if (281943 - 101985 == 179959)
						{
							continue;
						}
						this.hlsc2dQyJh.vDirection = Vector3.zero;
						if (218661 - 578916 != -360255)
						{
							continue;
						}
						this.hlsc2dQyJh.vMovement = this.transform.forward;
						if (55466 - 108360 != -52894)
						{
							continue;
						}
						this.hlsc2dQyJh.actionState = "standby";
						if (23397 - 361283 != -337886)
						{
							continue;
						}
						this.hlsc2dQyJh.myAttackTarget = this.hlsc2dQyJh.getHateLevelTarget(4, 50);
						if (81997 - 560236 == -478238)
						{
							continue;
						}
						if (!this.hlsc2dQyJh.myAttackTarget)
						{
							if (94540 - 490987 == -396446)
							{
								continue;
							}
							this.hlsc2dQyJh.isAlert = false;
							if (242029 - 589744 == -347714)
							{
								continue;
							}
							this.TbdcGcbx3G = Time.time;
							if (261982 - 187731 != 74251)
							{
								continue;
							}
							this.hlsc2dQyJh.myAttackTarget = null;
							if (229319 - 250384 == -21064)
							{
								continue;
							}
							this.hlsc2dQyJh.mOriginalPosition = this.transform.position;
							if (158427 - 131961 != 26466)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.hlsc2dQyJh.myAttackTarget;
							if (75515 - 150321 != -74806)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (65862 - 591559 == -525696)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (160863 - 110252 != 50611)
								{
									continue;
								}
								this.hlsc2dQyJh.isAlert = false;
								if (79242 - 531476 != -452234)
								{
									continue;
								}
								this.TbdcGcbx3G = Time.time;
								if (63193 - 305127 != -241934)
								{
									continue;
								}
								this.hlsc2dQyJh.myAttackTarget = null;
								if (67391 - 248985 == -181593)
								{
									continue;
								}
							}
							else
							{
								this.hlsc2dQyJh.vDirection = myAttackTarget.transform.position;
								if (142047 - 186146 == -44098)
								{
									continue;
								}
								this.hlsc2dQyJh.vDirection.y = this.transform.position.y;
								if (93911 - 371455 != -277544)
								{
									continue;
								}
								this.hlsc2dQyJh.vMovement = (this.hlsc2dQyJh.vDirection - this.transform.position).normalized;
								if (280819 - 388711 != -107892)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.hlsc2dQyJh.vMovement);
								if (112902 - 303584 != -190682)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.iS7c165sxt += mTime;
		}
		while (269089 - 138471 != 130618);
	}

	// Token: 0x0600039D RID: 925 RVA: 0x0005CFEC File Offset: 0x0005B1EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (191858 - 383210 != -191351)
		{
		}
		do
		{
			if (Time.time - this.TbdcGcbx3G >= this.iS7c165sxt)
			{
				if (57954 - 193319 == -135364)
				{
					continue;
				}
				if (Time.time - this.TbdcGcbx3G < this.iS7c165sxt + mTime)
				{
					if (204168 - 142537 != 61631)
					{
						continue;
					}
					if (!this.hlsc2dQyJh.myAttackTarget)
					{
						if (282626 - 348318 != -65692)
						{
							continue;
						}
						this.TbdcGcbx3G = Time.time - mTime - this.iS7c165sxt;
						if (229842 - 194403 != 35440)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.hlsc2dQyJh.myAttackTarget;
						if (120026 - 403337 == -283310)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (57528 - 127913 == -70384)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (217235 - 118023 == 99213)
						{
							continue;
						}
						if (174425 - 490993 != -316568)
						{
							continue;
						}
						if (characterControl)
						{
							if (33466 - 130903 == -97436)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (27047 - 292399 == -265351)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (152232 - 121304 != 30928)
						{
							continue;
						}
						if (Game.mGameCode == 946)
						{
							if (210203 - 32931 == 177273)
							{
								continue;
							}
							if ((float)this.hlsc2dQyJh.hp > 0.35f * (float)this.hlsc2dQyJh.mhp)
							{
								if (129410 - 78618 == 50793)
								{
									continue;
								}
								if (this.hlsc2dQyJh.isTimeOut("fly") == (float)0)
								{
									if (162541 - 350835 == -188293)
									{
										continue;
									}
									this.TbdcGcbx3G = Time.time - mTime - this.iS7c165sxt;
									if (85329 - 219000 != -133671)
									{
										continue;
									}
									this.TtmcxsPBjc = Time.time + (float)90;
									if (30684 - 490581 == -459896)
									{
										continue;
									}
									this.BL4cYqlbT1 = this.hlsc2dQyJh.hp;
									if (37758 - 156956 == -119197)
									{
										continue;
									}
									this.hMDclLphdi.StartCoroutine_Auto(this.hMDclLphdi.RPC_fly(this.transform.position, this.transform.forward, 0));
									if (178788 - 287417 != -108628)
									{
										if (PhotonClient.IsInitialized())
										{
											if (266160 - 592054 != -325894)
											{
												continue;
											}
											this.hMDclLphdi.ActionEvent("RPC_fly", this.transform.position, this.transform.forward, 0);
											if (98379 - 178451 != -80072)
											{
												continue;
											}
										}
										goto IL_698;
									}
									continue;
								}
							}
						}
						if (num < (float)30)
						{
							if (176715 - 222012 == -45296)
							{
								continue;
							}
							if ((float)this.hlsc2dQyJh.hp < 0.25f * (float)this.hlsc2dQyJh.mhp)
							{
								if (209801 - 162158 == 47644)
								{
									continue;
								}
								if (this.hlsc2dQyJh.isTimeOut("goldenDust") == (float)0)
								{
									if (115163 - 559481 != -444318)
									{
										continue;
									}
									this.TbdcGcbx3G = Time.time - mTime - this.iS7c165sxt;
									if (152743 - 484005 == -331261)
									{
										continue;
									}
									this.hMDclLphdi.StartCoroutine_Auto(this.hMDclLphdi.RPC_goldenDust(this.transform.position, this.transform.forward, 0));
									if (184530 - 386961 != -202431)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (52743 - 27531 == 25213)
										{
											continue;
										}
										this.hMDclLphdi.ActionEvent("RPC_goldenDust", this.transform.position, this.transform.forward, 0);
										if (190999 - 373935 == -182935)
										{
											continue;
										}
									}
									goto IL_698;
								}
							}
						}
						if (num < (float)40)
						{
							if (76964 - 17084 == 59881)
							{
								continue;
							}
							if ((float)this.hlsc2dQyJh.hp < 0.75f * (float)this.hlsc2dQyJh.mhp)
							{
								if (131821 - 209556 != -77735)
								{
									continue;
								}
								if (this.hlsc2dQyJh.mp > 12)
								{
									if (293497 - 253186 == 40312)
									{
										continue;
									}
									if (this.hlsc2dQyJh.isTimeOut("provoke") == (float)0)
									{
										if (248613 - 425771 == -177157)
										{
											continue;
										}
										this.TbdcGcbx3G = Time.time - mTime - this.iS7c165sxt;
										if (267989 - 12452 != 255537)
										{
											continue;
										}
										this.hMDclLphdi.StartCoroutine_Auto(this.hMDclLphdi.RPC_provoke(this.transform.position, this.transform.forward, 0));
										if (274422 - 280747 != -6325)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (59332 - 441185 != -381853)
											{
												continue;
											}
											this.hMDclLphdi.ActionEvent("RPC_provoke", this.transform.position, this.transform.forward, 0);
											if (2610 - 137058 != -134448)
											{
												continue;
											}
										}
										goto IL_698;
									}
								}
							}
						}
						if (this.hlsc2dQyJh.sp >= 60)
						{
							if (181597 - 172822 == 8776)
							{
								continue;
							}
							if (this.hlsc2dQyJh.isTimeOut("multiStrike") == (float)0)
							{
								if (129002 - 154249 != -25247)
								{
									continue;
								}
								this.TbdcGcbx3G = Time.time - mTime - this.iS7c165sxt;
								if (224030 - 285192 != -61162)
								{
									continue;
								}
								this.hMDclLphdi.StartCoroutine_Auto(this.hMDclLphdi.RPC_multiStrike(this.transform.position, vector.normalized, 0));
								if (33608 - 458753 != -425145)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (115559 - 41087 != 74472)
									{
										continue;
									}
									this.hMDclLphdi.ActionEvent("RPC_multiStrike", this.transform.position, vector.normalized, 0);
									if (103779 - 509103 == -405323)
									{
										continue;
									}
								}
								goto IL_698;
							}
						}
						if (num > (float)3)
						{
							if (111917 - 296600 != -184683)
							{
								continue;
							}
							if (this.hlsc2dQyJh.isTimeOut("airSlasher") == (float)0)
							{
								if (71088 - 239452 == -168363)
								{
									continue;
								}
								this.TbdcGcbx3G = Time.time - mTime - this.iS7c165sxt;
								if (89386 - 141934 == -52547)
								{
									continue;
								}
								this.hMDclLphdi.StartCoroutine_Auto(this.hMDclLphdi.RPC_airSlasher(this.transform.position, vector.normalized, 0));
								if (220017 - 452529 != -232511)
								{
									if (PhotonClient.IsInitialized())
									{
										if (263190 - 392652 != -129462)
										{
											continue;
										}
										this.hMDclLphdi.ActionEvent("RPC_airSlasher", this.transform.position, vector.normalized, 0);
										if (221373 - 550060 != -328687)
										{
											continue;
										}
									}
									goto IL_698;
								}
								continue;
							}
						}
						if (num < (float)3)
						{
							if (55196 - 403941 == -348744)
							{
								continue;
							}
							if (this.hlsc2dQyJh.isTimeOut("cAttack") == (float)0)
							{
								if (248498 - 123474 != 125024)
								{
									continue;
								}
								this.TbdcGcbx3G = Time.time - mTime - this.iS7c165sxt;
								if (156091 - 132033 == 24059)
								{
									continue;
								}
								this.hMDclLphdi.StartCoroutine_Auto(this.hMDclLphdi.RPC_cAttack(this.transform.position, vector.normalized, 0));
								if (219826 - 400800 != -180973)
								{
									if (PhotonClient.IsInitialized())
									{
										if (201707 - 438945 == -237237)
										{
											continue;
										}
										this.hMDclLphdi.ActionEvent("RPC_cAttack", this.transform.position, vector.normalized, 0);
										if (202812 - 596026 == -393213)
										{
											continue;
										}
									}
									goto IL_698;
								}
								continue;
							}
						}
						if (num < (float)3)
						{
							if (181262 - 448829 == -267566)
							{
								continue;
							}
							if (this.hlsc2dQyJh.isTimeOut("nAttack") == (float)0)
							{
								if (262860 - 40512 == 222349)
								{
									continue;
								}
								this.TbdcGcbx3G = Time.time - mTime - this.iS7c165sxt;
								if (279243 - 290146 != -10903)
								{
									continue;
								}
								this.hMDclLphdi.StartCoroutine_Auto(this.hMDclLphdi.RPC_nAttack(this.transform.position, vector.normalized, 0));
								if (265043 - 152673 != 112371)
								{
									if (PhotonClient.IsInitialized())
									{
										if (100046 - 549384 == -449337)
										{
											continue;
										}
										this.hMDclLphdi.ActionEvent("RPC_nAttack", this.transform.position, vector.normalized, 0);
										if (282264 - 220530 != 61734)
										{
											continue;
										}
									}
									goto IL_698;
								}
								continue;
							}
						}
						if (num > (float)5)
						{
							if (79478 - 221867 != -142389)
							{
								continue;
							}
							if (this.hlsc2dQyJh.isTimeOut("hover") == (float)0)
							{
								if (240352 - 69276 != 171076)
								{
									continue;
								}
								this.TbdcGcbx3G = Time.time - mTime - this.iS7c165sxt;
								if (234105 - 460835 == -226729)
								{
									continue;
								}
								this.hMDclLphdi.StartCoroutine_Auto(this.hMDclLphdi.RPC_hover(this.transform.position, vector.normalized, 0));
								if (229890 - 101957 != 127933)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (138958 - 489829 == -350870)
									{
										continue;
									}
									this.hMDclLphdi.ActionEvent("RPC_hover", this.transform.position, vector.normalized, 0);
									if (263729 - 18805 != 244924)
									{
										continue;
									}
								}
								goto IL_698;
							}
						}
						this.AI_state = "attack";
						if (184088 - 60271 == 123818)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (14475 - 88690 == -74214)
							{
								continue;
							}
							this.hlsc2dQyJh.vDirection = myAttackTarget.transform.position;
							if (296524 - 77977 != 218547)
							{
								continue;
							}
							this.hlsc2dQyJh.vDirection.y = this.transform.position.y;
							if (118120 - 524181 != -406061)
							{
								continue;
							}
							this.hlsc2dQyJh.vMovement = (this.hlsc2dQyJh.vDirection - this.transform.position).normalized;
							if (244525 - 548532 != -304007)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.hlsc2dQyJh.vMovement);
							if (259957 - 164425 == 95533)
							{
								continue;
							}
							this.hlsc2dQyJh.actionState = "run";
							if (46517 - 210923 != -164406)
							{
								continue;
							}
							this.animation.Play("run");
							if (5837 - 407193 == -401355)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (178247 - 164024 == 14224)
							{
								continue;
							}
							this.hlsc2dQyJh.moveSpeed = Mathf.Lerp(this.hlsc2dQyJh.moveSpeed, this.hlsc2dQyJh.runSpeed, (float)4 * Time.deltaTime);
							if (229424 - 335639 == -106214)
							{
								continue;
							}
						}
						else
						{
							this.hlsc2dQyJh.vDirection = myAttackTarget.transform.position;
							if (109844 - 399514 == -289669)
							{
								continue;
							}
							this.hlsc2dQyJh.vDirection.y = this.transform.position.y;
							if (296903 - 296958 != -55)
							{
								continue;
							}
							this.hlsc2dQyJh.vMovement = (this.hlsc2dQyJh.vDirection - this.transform.position).normalized;
							if (168141 - 395656 == -227514)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.hlsc2dQyJh.vMovement);
							if (292236 - 411059 == -118822)
							{
								continue;
							}
							this.hlsc2dQyJh.actionState = "standby";
							if (219104 - 157534 != 61570)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (142393 - 7088 != 135305)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (80219 - 111103 != -30884)
							{
								continue;
							}
							this.hlsc2dQyJh.moveSpeed = Mathf.Lerp(this.hlsc2dQyJh.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (124756 - 335264 == -210507)
							{
								continue;
							}
						}
					}
				}
			}
			IL_698:
			this.iS7c165sxt += mTime;
		}
		while (177724 - 202217 != -24493);
	}

	// Token: 0x0600039E RID: 926 RVA: 0x0005E0A4 File Offset: 0x0005C2A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (243555 - 536366 != -292810)
		{
		}
		while (Time.time - this.TbdcGcbx3G > this.iS7c165sxt)
		{
			if (176228 - 572451 != -396222)
			{
				this.AI_state = "none";
				if (75726 - 515256 == -439530)
				{
					this.TbdcGcbx3G = Time.time;
					if (101037 - 532759 == -431722)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600039F RID: 927 RVA: 0x0005E158 File Offset: 0x0005C358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (33543 - 270818 != -237275)
		{
		}
		for (;;)
		{
			IL_5B1:
			if (this.QGIc3RQHln > Time.time)
			{
				if (125418 - 321785 == -196367)
				{
					break;
				}
			}
			else
			{
				this.QGIc3RQHln = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (241413 - 350334 == -108921)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (149156 - 442981 != -293824)
					{
						if (191554 - 534293 == -342739)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (1095 - 33316 != -32220)
							{
								while (enumerator.MoveNext())
								{
									object obj2 = enumerator.Current;
									object obj4;
									object obj3 = obj4 = obj2;
									if (!(obj3 is GameObject))
									{
										obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
									}
									GameObject gameObject = (GameObject)obj4;
									if (290525 - 330897 == -40371)
									{
										goto IL_5B1;
									}
									Vector3 position = gameObject.transform.position;
									if (82675 - 525454 == -442778)
									{
										goto IL_5B1;
									}
									if (Mathf.Abs(position.y - this.transform.position.y) < (float)3)
									{
										if (120964 - 164275 == -43310)
										{
											goto IL_5B1;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (58030 - 373153 == -315122)
										{
											goto IL_5B1;
										}
										UnityRuntimeServices.Update(enumerator, gameObject);
										if (127913 - 289063 == -161149)
										{
											goto IL_5B1;
										}
										bool flag = true;
										if (89929 - 57201 == 32729)
										{
											goto IL_5B1;
										}
										eRace race = this.hlsc2dQyJh.Race;
										if (122197 - 486378 != -364181)
										{
											goto IL_5B1;
										}
										if (race == eRace.Tails)
										{
											if (102318 - 25953 != 76365)
											{
												goto IL_5B1;
											}
											if (characterControl.Race == eRace.Plants)
											{
												goto IL_63E;
											}
											if (12919 - 76906 != -63987)
											{
												goto IL_5B1;
											}
											if (characterControl.Race == eRace.Structure)
											{
												if (111628 - 240323 != -128695)
												{
													goto IL_5B1;
												}
												goto IL_63E;
											}
											goto IL_5FC;
											IL_63E:
											flag = false;
											if (240045 - 372258 != -132213)
											{
												goto IL_5B1;
											}
										}
										else if (race == eRace.Plants)
										{
											if (277094 - 349692 != -72598)
											{
												goto IL_5B1;
											}
											flag = false;
											if (32088 - 199989 != -167901)
											{
												goto IL_5B1;
											}
										}
										else if (race == eRace.Bugs)
										{
											if (200697 - 448499 == -247801)
											{
												goto IL_5B1;
											}
											if (characterControl.Race == eRace.Elementals)
											{
												goto IL_5DB;
											}
											if (166396 - 148467 == 17930)
											{
												goto IL_5B1;
											}
											if (characterControl.Race == eRace.Robots)
											{
												if (261420 - 442942 != -181521)
												{
													goto IL_5DB;
												}
												goto IL_5B1;
											}
											goto IL_5FC;
											IL_5DB:
											flag = false;
											if (171550 - 555591 == -384040)
											{
												goto IL_5B1;
											}
										}
										else if (race == eRace.Robots)
										{
											if (278001 - 233527 != 44474)
											{
												goto IL_5B1;
											}
											flag = true;
											if (217469 - 316690 != -99221)
											{
												goto IL_5B1;
											}
										}
										else if (race == eRace.Elementals)
										{
											if (132195 - 224317 != -92122)
											{
												goto IL_5B1;
											}
											if (characterControl.Race == eRace.Plants)
											{
												goto IL_18E;
											}
											if (283969 - 565978 == -282008)
											{
												goto IL_5B1;
											}
											if (characterControl.Race == eRace.Bugs)
											{
												goto IL_18E;
											}
											if (188386 - 518228 == -329841)
											{
												goto IL_5B1;
											}
											if (characterControl.Race == eRace.Structure)
											{
												if (288858 - 212040 != 76818)
												{
													goto IL_5B1;
												}
												goto IL_18E;
											}
											goto IL_5FC;
											IL_18E:
											flag = false;
											if (215230 - 417087 == -201856)
											{
												goto IL_5B1;
											}
										}
										else if (race == eRace.Structure)
										{
											if (105831 - 383044 == -277212)
											{
												goto IL_5B1;
											}
											if (characterControl.Race == eRace.Plants)
											{
												if (77831 - 232991 != -155160)
												{
													goto IL_5B1;
												}
												flag = false;
												if (190379 - 423797 != -233418)
												{
													goto IL_5B1;
												}
											}
										}
										IL_5FC:
										if (flag)
										{
											if (177429 - 367387 != -189958)
											{
												goto IL_5B1;
											}
											if (characterControl.hp > 0)
											{
												if (265710 - 125166 != 140544)
												{
													goto IL_5B1;
												}
												if (characterControl.recieveTarget)
												{
													if (218035 - 420964 != -202929)
													{
														goto IL_5B1;
													}
													if (characterControl.getStatus("invisible") == null)
													{
														if (81071 - 327508 != -246437)
														{
															goto IL_5B1;
														}
														if (characterControl.getStatus("blend") == null)
														{
															if (153065 - 423247 != -270182)
															{
																goto IL_5B1;
															}
															Vector3 vector = gameObject.transform.position - this.transform.position;
															if (117475 - 27398 != 90077)
															{
																goto IL_5B1;
															}
															if (vector.sqrMagnitude < (float)144)
															{
																if (272179 - 276380 == -4200)
																{
																	goto IL_5B1;
																}
																this.hlsc2dQyJh.myAttackTarget = gameObject;
																if (215255 - 177439 != 37816)
																{
																	goto IL_5B1;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (155299 - 169045 == -13745)
																{
																	goto IL_5B1;
																}
																this.hlsc2dQyJh.addHate(characterControl.ActorNr, 5);
																if (59335 - 364071 != -304736)
																{
																	goto IL_5B1;
																}
															}
															else
															{
																float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
																if (232842 - 536910 != -304068)
																{
																	goto IL_5B1;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (1614 - 179699 != -178085)
																{
																	goto IL_5B1;
																}
																if (num < (float)60)
																{
																	if (190241 - 393438 == -203196)
																	{
																		goto IL_5B1;
																	}
																	if (characterControl.hp > 0)
																	{
																		if (61607 - 75352 != -13745)
																		{
																			goto IL_5B1;
																		}
																		this.hlsc2dQyJh.myAttackTarget = gameObject;
																		if (225826 - 240978 == -15151)
																		{
																			goto IL_5B1;
																		}
																		UnityRuntimeServices.Update(enumerator, gameObject);
																		if (223743 - 511702 == -287958)
																		{
																			goto IL_5B1;
																		}
																		this.hlsc2dQyJh.addHate(characterControl.ActorNr, 5);
																		if (177610 - 155444 == 22167)
																		{
																			goto IL_5B1;
																		}
																	}
																}
															}
															if (this.hlsc2dQyJh.myAttackTarget)
															{
																if (139601 - 367833 == -228231)
																{
																	goto IL_5B1;
																}
																this.hlsc2dQyJh.isAlert = true;
																if (104097 - 106430 == -2332)
																{
																	goto IL_5B1;
																}
																this.TbdcGcbx3G = Time.time;
																if (269643 - 69190 == 200454)
																{
																	goto IL_5B1;
																}
															}
														}
													}
												}
											}
										}
									}
								}
								if (268288 - 468620 != -200331)
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

	// Token: 0x060003A0 RID: 928 RVA: 0x0005E9DC File Offset: 0x0005CBDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x0005E9E0 File Offset: 0x0005CBE0
	internal static bool HNYOBfNmBvcO5Xg5ZkG()
	{
		return true;
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x0005E9E4 File Offset: 0x0005CBE4
	internal static bool N8mYW4NFnCs5xPKDORu()
	{
		return false;
	}

	// Token: 0x04000394 RID: 916
	private CharacterControl hlsc2dQyJh;

	// Token: 0x04000395 RID: 917
	private Transform lBDcv0Bn8R;

	// Token: 0x04000396 RID: 918
	private GoldenKingBug hMDclLphdi;

	// Token: 0x04000397 RID: 919
	public string AI_state;

	// Token: 0x04000398 RID: 920
	private float TbdcGcbx3G;

	// Token: 0x04000399 RID: 921
	private float iS7c165sxt;

	// Token: 0x0400039A RID: 922
	private GameObject YXWcqFm94t;

	// Token: 0x0400039B RID: 923
	private int H2AcpsjQG2;

	// Token: 0x0400039C RID: 924
	private GameObject[] KKocR9nAnl;

	// Token: 0x0400039D RID: 925
	private Vector3 As8crqdkH9;

	// Token: 0x0400039E RID: 926
	private float TtmcxsPBjc;

	// Token: 0x0400039F RID: 927
	private float iaXcTvXt8n;

	// Token: 0x040003A0 RID: 928
	private int BL4cYqlbT1;

	// Token: 0x040003A1 RID: 929
	private float QGIc3RQHln;
}
