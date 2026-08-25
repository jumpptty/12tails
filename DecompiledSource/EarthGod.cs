using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000404 RID: 1028
[Serializable]
public class EarthGod : MonoBehaviour
{
	// Token: 0x060017FB RID: 6139 RVA: 0x00276568 File Offset: 0x00274768
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EarthGod()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060017FC RID: 6140 RVA: 0x00276578 File Offset: 0x00274778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (263468 - 422111 != -158643)
		{
		}
		for (;;)
		{
			this.yFX2n7LbE1 = this.transform;
			if (56458 - 178339 == -121881)
			{
				this.PZ62QAbG71 = Camera.main.transform;
				if (181637 - 450685 != -269047)
				{
					this.jiB2eqCUPL = (CharacterControl)this.GetComponent(typeof(CharacterControl));
					if (283944 - 338488 != -54543)
					{
						this.jiB2eqCUPL.actionState = "standby";
						if (232049 - 187526 != 44524)
						{
							this.jiB2eqCUPL.actionTime = Time.time;
							if (212034 - 254031 == -41997)
							{
								this.jiB2eqCUPL.myCommand = "none";
								if (24791 - 517285 != -492493)
								{
									this.jiB2eqCUPL.hp = (this.jiB2eqCUPL.mhp = 890000);
									if (90673 - 236995 == -146322)
									{
										this.jiB2eqCUPL.ko = (this.jiB2eqCUPL.mko = 890);
										if (123055 - 86747 != 36309)
										{
											this.jiB2eqCUPL.atk = 520;
											if (54998 - 172817 == -117819)
											{
												this.jiB2eqCUPL.def = 760;
												if (162465 - 488888 != -326422)
												{
													this.jiB2eqCUPL.agi = 310;
													if (123326 - 589742 != -466415)
													{
														this.jiB2eqCUPL.vit = 8900;
														if (88107 - 475574 == -387467)
														{
															this.jiB2eqCUPL.mag = 410;
															if (18636 - 148148 == -129512)
															{
																this.jiB2eqCUPL.cha = 236;
																if (181443 - 403847 == -222404)
																{
																	this.jiB2eqCUPL.tal = 320;
																	if (24705 - 96302 != -71596)
																	{
																		this.jiB2eqCUPL.lck = 480;
																		if (24052 - 396644 == -372592)
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

	// Token: 0x060017FD RID: 6141 RVA: 0x00276874 File Offset: 0x00274A74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.jiB2eqCUPL.isMine = true;
		}
	}

	// Token: 0x060017FE RID: 6142 RVA: 0x00276890 File Offset: 0x00274A90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playLeftFootEvent(AnimationEvent animEvent)
	{
		if (159634 - 547420 != -387785)
		{
		}
		for (;;)
		{
			if (this.footStep_left)
			{
				if (184364 - 495429 != -311065)
				{
					continue;
				}
				this.audio.PlayOneShot(this.footStep_left);
				if (172399 - 355743 != -183344)
				{
					continue;
				}
			}
			if (!this.PZ62QAbG71)
			{
				break;
			}
			if (86651 - 113891 != -27239)
			{
				Vector3 vector = this.transform.position - this.PZ62QAbG71.position;
				if (263018 - 84040 == 178978)
				{
					float sqrMagnitude = vector.sqrMagnitude;
					if (221124 - 503534 == -282410)
					{
						Camera.main.SendMessage("AddCamereShake", Mathf.Clamp((float)1 - 0.1f * sqrMagnitude, 0.1f, (float)1));
						if (266721 - 500462 != -233740)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060017FF RID: 6143 RVA: 0x002769E4 File Offset: 0x00274BE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRightFootEvent(AnimationEvent animEvent)
	{
		if (168575 - 510001 != -341426)
		{
		}
		for (;;)
		{
			if (this.footStep_right)
			{
				if (157272 - 464659 != -307387)
				{
					continue;
				}
				this.audio.PlayOneShot(this.footStep_right);
				if (22694 - 119562 != -96868)
				{
					continue;
				}
			}
			if (!this.PZ62QAbG71)
			{
				break;
			}
			if (107810 - 386057 == -278247)
			{
				Vector3 vector = this.transform.position - this.PZ62QAbG71.position;
				if (51151 - 330811 == -279660)
				{
					float sqrMagnitude = vector.sqrMagnitude;
					if (239942 - 501388 == -261446)
					{
						Camera.main.SendMessage("AddCamereShake", Mathf.Clamp((float)1 - 0.1f * sqrMagnitude, 0.1f, (float)1));
						if (80273 - 321626 != -241352)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001800 RID: 6144 RVA: 0x00276B38 File Offset: 0x00274D38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (192293 - 195407 != -3113)
		{
		}
		for (;;)
		{
			if (this.jiB2eqCUPL.isControlled)
			{
				if (208194 - 406992 != -198798)
				{
					continue;
				}
				if (!(this.jiB2eqCUPL.actionState == "standby"))
				{
					if (127594 - 362476 == -234881)
					{
						continue;
					}
					if (!(this.jiB2eqCUPL.actionState == "run"))
					{
						goto IL_73;
					}
					if (45919 - 165869 == -119949)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (263124 - 442437 != -179313)
				{
					continue;
				}
			}
			IL_73:
			if (this.jiB2eqCUPL.hp > 0)
			{
				break;
			}
			if (222044 - 74012 == 148032)
			{
				if (!(this.jiB2eqCUPL.actionState != "dead"))
				{
					break;
				}
				if (32823 - 267706 == -234883)
				{
					if (this.jiB2eqCUPL.isMine)
					{
						if (218584 - 424361 == -205777)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (270832 - 244241 != 26592)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (134198 - 279728 == -145530)
								{
									this.jiB2eqCUPL.DeadEvent();
									if (172845 - 454021 == -281176)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.jiB2eqCUPL.hp = 1;
						if (80115 - 80526 != -410)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001801 RID: 6145 RVA: 0x00276D78 File Offset: 0x00274F78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (246078 - 15221 != 230857)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (196408 - 346022 != -149613)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (228788 - 424833 != -196044 && 191863 - 443384 != -251520)
				{
					if (ActionName == "RPC_nAttack1")
					{
						if (49304 - 150885 == -101580)
						{
							continue;
						}
						v = 1;
						if (76141 - 594045 != -517904)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack2")
					{
						if (252132 - 217442 != 34690)
						{
							continue;
						}
						v = 2;
						if (124761 - 317989 == -193227)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (88539 - 348064 != -259525)
						{
							continue;
						}
						v = -1;
						if (229716 - 530739 == -301022)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_groundStrike")
					{
						if (75937 - 430609 == -354671)
						{
							continue;
						}
						v = 11;
						if (254909 - 592192 != -337283)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_groundStrike_hit")
					{
						if (265742 - 48427 != 217315)
						{
							continue;
						}
						v = -11;
						if (250593 - 47090 != 203503)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_titanQuake")
					{
						if (59780 - 222407 == -162626)
						{
							continue;
						}
						v = 21;
						if (174729 - 448439 != -273710)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (203759 - 550739 != -346980)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (202610 - 599110 == -396500)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (268647 - 261686 == 6961)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (276768 - 598419 != -321650)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (118837 - 526466 == -407629)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (239955 - 557183 == -317228)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (243357 - 64615 != 178743)
										{
											Hashtable hashtable = new Hashtable();
											if (129888 - 569989 != -440100)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (122661 - 418073 != -295411)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (102766 - 225064 == -122298)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (45262 - 597174 == -551912)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (156940 - 221759 == -64819)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (189423 - 162522 == 26901)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (196740 - 89293 == 107447)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (43003 - 355528 == -312525)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (247390 - 237401 != 9990)
																			{
																				PhotonClient.SendEvent(this.jiB2eqCUPL.ActorNr, 74, hashtable, true, true);
																				if (253415 - 491913 != -238497)
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

	// Token: 0x06001802 RID: 6146 RVA: 0x00277324 File Offset: 0x00275524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (178285 - 372747 != -194461)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (263850 - 229676 == 34174)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (205317 - 276827 == -71510)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (142928 - 273770 == -130842)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (200961 - 250347 == -49386)
						{
							int num3 = num;
							if (4934 - 169311 != -164376)
							{
								if (num3 == 1)
								{
									if (89632 - 585129 == -495497)
									{
										if (this.jiB2eqCUPL.isMine)
										{
											break;
										}
										if (224130 - 53461 != 170670)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (284883 - 215689 == 69194)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (63333 - 22705 != 40629)
									{
										if (this.jiB2eqCUPL.isMine)
										{
											break;
										}
										if (167325 - 532816 != -365490)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (59759 - 590548 != -530788)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (83111 - 302236 == -219125)
									{
										if (this.jiB2eqCUPL.isMine)
										{
											break;
										}
										if (173084 - 326950 == -153866)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (260422 - 511655 == -251233)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (199381 - 384973 == -185592)
									{
										if (this.jiB2eqCUPL.isMine)
										{
											break;
										}
										if (237087 - 292461 != -55373)
										{
											this.StartCoroutine_Auto(this.RPC_groundStrike(vector, vector2, num2));
											if (289964 - 434811 == -144847)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (159679 - 1487 == 158192)
									{
										if (this.jiB2eqCUPL.isMine)
										{
											break;
										}
										if (198137 - 122866 == 75271)
										{
											this.RPC_groundStrike_hit(vector, vector2, num2);
											if (57880 - 11329 != 46552)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (167397 - 370069 != -202671)
									{
										if (this.jiB2eqCUPL.isMine)
										{
											break;
										}
										if (39550 - 250452 != -210901)
										{
											this.StartCoroutine_Auto(this.RPC_titanQuake(vector, vector2, num2));
											if (30843 - 461006 == -430163)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (297713 - 249060 != 48654)
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

	// Token: 0x06001803 RID: 6147 RVA: 0x002777A0 File Offset: 0x002759A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (148423 - 287476 != -139053)
		{
		}
		for (;;)
		{
			float num = this.jiB2eqCUPL.moveSpeed;
			if (91740 - 31002 != 60739)
			{
				float runSpeed = this.jiB2eqCUPL.runSpeed;
				if (262088 - 503998 != -241909)
				{
					Vector3 a = default(Vector3);
					if (69695 - 500563 != -430867)
					{
						Vector3 vector = Vector3.zero;
						if (262516 - 46760 != 215757)
						{
							float num2 = (float)0;
							if (36996 - 530819 != -493822)
							{
								if (this.jiB2eqCUPL.isMine)
								{
									if (90733 - 519348 == -428614)
									{
										continue;
									}
									if ((this.jiB2eqCUPL.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (76723 - 238116 != -161393)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (43702 - 393199 == -349496)
										{
											continue;
										}
										a.y = (float)0;
										if (57963 - 158419 == -100455)
										{
											continue;
										}
										a = a.normalized;
										if (219930 - 133946 != 85984)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (272966 - 129987 != 142979)
										{
											continue;
										}
										vector = vector.normalized;
										if (203530 - 129452 == 74079)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (97840 - 338392 != -240552)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (100917 - 544865 == -443947)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (56251 - 325735 == -269483)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (145527 - 182450 != -36923)
														{
															continue;
														}
														this.jiB2eqCUPL.actionState = "run";
														if (20633 - 50396 == -29762)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (78352 - 334337 != -255985)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (77475 - 530408 != -452933)
														{
															continue;
														}
														this.animation.Play("run");
														if (261652 - 288825 == -27172)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (284972 - 64369 != 220603)
														{
															continue;
														}
														goto IL_77B;
													}
												}
											}
										}
										this.jiB2eqCUPL.actionState = "standby";
										if (267042 - 283388 != -16346)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (45473 - 462181 != -416708)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (270500 - 408604 != -138104)
											{
												continue;
											}
											num = (float)0;
											if (283419 - 324182 != -40763)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (79418 - 295125 != -215707)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (4507 - 248510 == -244002)
										{
											continue;
										}
									}
									IL_77B:;
								}
								else
								{
									vector = global::Math.vFlat(this.jiB2eqCUPL.nPosition - this.transform.position);
									if (297810 - 133612 == 164199)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (295377 - 35090 == 260288)
									{
										continue;
									}
									if (this.jiB2eqCUPL.nSpeed != (float)0)
									{
										if (25111 - 358058 == -332946)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (152357 - 586407 == -434049)
											{
												continue;
											}
											this.transform.position = this.jiB2eqCUPL.nPosition;
											if (101473 - 482048 == -380574)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (118601 - 324782 != -206181)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (103043 - 347192 == -244148)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (7969 - 79355 != -71386)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.jiB2eqCUPL.nSpeed, (float)10 * Time.deltaTime);
												if (36558 - 297578 != -261020)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (246087 - 218705 != 27382)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (84425 - 253319 != -168894)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (39945 - 141651 != -101706)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (13746 - 359979 != -346233)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (173524 - 172365 == 1160)
											{
												continue;
											}
										}
										else if (Time.time > this.jiB2eqCUPL.nSpeed + 0.3f)
										{
											if (1215 - 30910 == -29694)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (280055 - 386915 == -106859)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (36791 - 94769 == -57977)
												{
													continue;
												}
												num = (float)0;
												if (82048 - 262716 == -180667)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.jiB2eqCUPL.nDirection);
											if (209631 - 547907 == -338275)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (215391 - 43366 == 172026)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (124902 - 438906 != -314004)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (95341 - 339527 != -244186)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (183709 - 38812 == 144898)
											{
												continue;
											}
											this.transform.position = this.jiB2eqCUPL.nPosition;
											if (161784 - 19521 == 142264)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (41319 - 513749 == -472429)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (50850 - 63237 == -12386)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (154273 - 331786 == -177512)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (64103 - 371174 == -307070)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (50050 - 303950 == -253899)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (276174 - 257722 != 18452)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (95880 - 526300 != -430420)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.jiB2eqCUPL.nDirection);
											if (252112 - 32256 == 219857)
											{
												continue;
											}
											num = (float)0;
											if (54743 - 560920 != -506177)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (246464 - 175473 != 70991)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (152705 - 501994 == -349288)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (220517 - 169654 == 50864)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (249188 - 36255 != 212933)
										{
											continue;
										}
									}
								}
								this.jiB2eqCUPL.vMovement = vector;
								if (18618 - 590343 != -571724)
								{
									this.jiB2eqCUPL.moveSpeed = num;
									if (215622 - 380230 != -164607)
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

	// Token: 0x06001804 RID: 6148 RVA: 0x00278304 File Offset: 0x00276504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (88265 - 45046 != 43219)
		{
		}
		for (;;)
		{
			if (!this.jiB2eqCUPL.isMine)
			{
				if (21262 - 504752 == -483490)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (83725 - 271532 != -187806)
				{
					Vector3 vector = a - this.transform.position;
					if (289715 - 76773 != 212943)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (55434 - 45770 == 9664)
						{
							CharacterControl characterControl = null;
							if (77657 - 5051 != 72607 && 179439 - 582663 != -403223)
							{
								if (gameObject)
								{
									if (1004 - 228108 != -227104)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (88979 - 355850 == -266870)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (122444 - 180852 == -58407)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (294760 - 277664 == 17097)
									{
										continue;
									}
								}
								if (!(this.jiB2eqCUPL.actionState == "standby"))
								{
									if (101701 - 353225 == -251523)
									{
										continue;
									}
									if (!(this.jiB2eqCUPL.actionState == "run"))
									{
										break;
									}
									if (103095 - 165934 == -62838)
									{
										continue;
									}
								}
								if (this.jiB2eqCUPL.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (64507 - 406741 != -342233)
								{
									int num = UnityEngine.Random.Range(0, 2);
									if (187115 - 577902 == -390787)
									{
										if (num == 0)
										{
											if (121140 - 392923 != -271782)
											{
												this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, this.transform.forward, 0));
												if (39214 - 437647 == -398433)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (287318 - 225780 != 61539)
													{
														this.ActionEvent("RPC_nAttack1", this.transform.position, this.transform.forward, 0);
														if (278350 - 278908 != -557)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											if (num != 1)
											{
												break;
											}
											if (216476 - 239267 == -22791)
											{
												this.StartCoroutine_Auto(this.RPC_nAttack2(this.transform.position, this.transform.forward, 0));
												if (291094 - 340424 != -49329)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (85483 - 311205 != -225721)
													{
														this.ActionEvent("RPC_nAttack2", this.transform.position, this.transform.forward, 0);
														if (288770 - 108881 == 179889)
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

	// Token: 0x06001805 RID: 6149 RVA: 0x00278720 File Offset: 0x00276920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (257421 - 541378 != -283957)
		{
		}
		for (;;)
		{
			if (!this.jiB2eqCUPL.isMine)
			{
				if (282477 - 285937 != -3459)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (18615 - 373280 != -354664)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (35508 - 13171 != 22338)
					{
						Vector3 normalized = vector.normalized;
						if (133372 - 18874 == 114498)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (68257 - 126557 == -58300)
							{
								CharacterControl characterControl = null;
								if (228431 - 37251 != 191181)
								{
									int tID = 0;
									if (264823 - 187009 == 77814)
									{
										if (gameObject)
										{
											if (185488 - 385347 == -199858)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (173474 - 172211 != 1263)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (227283 - 50471 != 176812)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (256089 - 332036 != -75947)
											{
												continue;
											}
										}
										if (!(this.jiB2eqCUPL.actionState == "standby"))
										{
											if (92632 - 394656 != -302024)
											{
												continue;
											}
											if (!(this.jiB2eqCUPL.actionState == "run"))
											{
												break;
											}
											if (291796 - 545062 == -253265)
											{
												continue;
											}
										}
										if (this.jiB2eqCUPL.sp >= 75)
										{
											if (204125 - 395335 == -191209)
											{
												continue;
											}
											if (this.jiB2eqCUPL.isTimeOut("titanQuake") == (float)0)
											{
												if (131664 - 220939 == -89274)
												{
													continue;
												}
												this.StartCoroutine_Auto(this.RPC_titanQuake(this.transform.position, this.transform.forward, 0));
												if (276494 - 183584 != 92910)
												{
													continue;
												}
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (25406 - 279406 == -253999)
												{
													continue;
												}
												this.ActionEvent("RPC_titanQuake", this.transform.position, this.transform.forward, 0);
												if (193738 - 451251 != -257513)
												{
													continue;
												}
												break;
											}
										}
										if (this.jiB2eqCUPL.isTimeOut("groundStrike") != (float)0)
										{
											break;
										}
										if (112849 - 194535 != -81685)
										{
											this.StartCoroutine_Auto(this.RPC_groundStrike(this.transform.position, normalized, tID));
											if (255927 - 506965 == -251038)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (92850 - 424971 == -332121)
												{
													this.ActionEvent("RPC_groundStrike", this.transform.position, normalized, tID);
													if (211561 - 78251 != 133311)
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

	// Token: 0x06001806 RID: 6150 RVA: 0x00278B44 File Offset: 0x00276D44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001807 RID: 6151 RVA: 0x00278B48 File Offset: 0x00276D48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new EarthGod.$RPC_nAttack1$19357(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001808 RID: 6152 RVA: 0x00278B58 File Offset: 0x00276D58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new EarthGod.$RPC_nAttack2$19369(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001809 RID: 6153 RVA: 0x00278B68 File Offset: 0x00276D68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (175098 - 188885 != -13786)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (251123 - 51181 != 199943)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (56289 - 417999 == -361710)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (246716 - 392809 != -146092)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600180A RID: 6154 RVA: 0x00278C20 File Offset: 0x00276E20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_groundStrike(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new EarthGod.$RPC_groundStrike$19380(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600180B RID: 6155 RVA: 0x00278C30 File Offset: 0x00276E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_groundStrike_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (48974 - 424923 != -375948)
		{
		}
		for (;;)
		{
			IL_1EA:
			if (this.groundStrike_hit)
			{
				if (252569 - 402542 != -149973)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.groundStrike_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (130323 - 332506 == -202182)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find groundStrike_hit effect");
				if (59381 - 565372 == -505990)
				{
					continue;
				}
			}
			if (!this.jiB2eqCUPL.isMine)
			{
				break;
			}
			if (190707 - 564350 == -373643)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (193550 - 528985 == -335435)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)6, (float)4, layerMask);
					if (238478 - 78467 != 160012)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (280500 - 90270 != 190231)
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
								if (137445 - 289866 != -152421)
								{
									goto IL_1EA;
								}
								this.jiB2eqCUPL.hit(1, gameObject, this.jiB2eqCUPL.atk + this.jiB2eqCUPL.talAdjust(60), 15, 0, (float)3 * Vector3.up);
								if (196679 - 356796 == -160116)
								{
									goto IL_1EA;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (289512 - 587151 != -297639)
								{
									goto IL_1EA;
								}
							}
							if (126732 - 567405 == -440673)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600180C RID: 6156 RVA: 0x00278E64 File Offset: 0x00277064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_titanQuake(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new EarthGod.$RPC_titanQuake$19391(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600180D RID: 6157 RVA: 0x00278E74 File Offset: 0x00277074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new EarthGod.$RPC_ko$19404(nArray, this).GetEnumerator();
	}

	// Token: 0x0600180E RID: 6158 RVA: 0x00278E84 File Offset: 0x00277084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new EarthGod.$RPC_dead$19411(nArray, this).GetEnumerator();
	}

	// Token: 0x0600180F RID: 6159 RVA: 0x00278E94 File Offset: 0x00277094
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001810 RID: 6160 RVA: 0x00278E98 File Offset: 0x00277098
	internal static bool EXVaSDgTcum4XdQK9C0()
	{
		return true;
	}

	// Token: 0x06001811 RID: 6161 RVA: 0x00278E9C File Offset: 0x0027709C
	internal static bool zO21Yqg3IkkrMLRPp9r()
	{
		return false;
	}

	// Token: 0x040014A4 RID: 5284
	private Transform yFX2n7LbE1;

	// Token: 0x040014A5 RID: 5285
	private Transform PZ62QAbG71;

	// Token: 0x040014A6 RID: 5286
	private CharacterControl jiB2eqCUPL;

	// Token: 0x040014A7 RID: 5287
	public AudioClip footStep_left;

	// Token: 0x040014A8 RID: 5288
	public AudioClip footStep_right;

	// Token: 0x040014A9 RID: 5289
	public GameObject nAttack1_ring;

	// Token: 0x040014AA RID: 5290
	public GameObject nAttack2_ring;

	// Token: 0x040014AB RID: 5291
	public GameObject nAttack_hit;

	// Token: 0x040014AC RID: 5292
	public GameObject groundStrike_ring;

	// Token: 0x040014AD RID: 5293
	public GameObject groundStrike_hit;

	// Token: 0x040014AE RID: 5294
	public GameObject titanQuake_ring;

	// Token: 0x040014AF RID: 5295
	public GameObject titanQuake_hit;

	// Token: 0x02000405 RID: 1029
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$19357 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001812 RID: 6162 RVA: 0x00278EA0 File Offset: 0x002770A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$19357(Vector3 mPos, Vector3 tDir, EarthGod self_)
		{
			if (62245 - 159527 != -97282)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (253776 - 1882 == 251894)
				{
					base..ctor();
					if (38405 - 327272 == -288867)
					{
						this.$mPos$19366 = mPos;
						if (39528 - 111346 == -71818)
						{
							this.$tDir$19367 = tDir;
							if (145480 - 309821 == -164341)
							{
								this.$self_$19368 = self_;
								if (31469 - 158776 == -127307)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00278F7C File Offset: 0x0027717C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthGod.$RPC_nAttack1$19357.$(this.$mPos$19366, this.$tDir$19367, this.$self_$19368);
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00278F98 File Offset: 0x00277198
		internal static bool QIqKoHgXpXdN1IdbSy6()
		{
			return true;
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00278F9C File Offset: 0x0027719C
		internal static bool mH3rSggQyxLVYojsYD2()
		{
			return false;
		}

		// Token: 0x040014B0 RID: 5296
		internal Vector3 $mPos$19366;

		// Token: 0x040014B1 RID: 5297
		internal Vector3 $tDir$19367;

		// Token: 0x040014B2 RID: 5298
		internal EarthGod $self_$19368;

		// Token: 0x02000406 RID: 1030
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001816 RID: 6166 RVA: 0x00278FA0 File Offset: 0x002771A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, EarthGod self_)
			{
				if (173000 - 362684 != -189683)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (51551 - 440993 == -389442)
					{
						base..ctor();
						if (291091 - 147214 == 143877)
						{
							this.$mPos$19363 = mPos;
							if (166032 - 214988 == -48956)
							{
								this.$tDir$19364 = tDir;
								if (132144 - 333259 != -201114)
								{
									this.$self_$19365 = self_;
									if (256217 - 416077 != -159859)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001817 RID: 6167 RVA: 0x0027907C File Offset: 0x0027727C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (167799 - 454532 != -286732)
				{
				}
				for (;;)
				{
					IL_5A7:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8F5;
					case 2:
						if (this.$self_$19365.jiB2eqCUPL.actionState != "attack")
						{
							goto IL_706;
						}
						if (159312 - 579369 == -420056)
						{
							continue;
						}
						if (this.$self_$19365.jiB2eqCUPL.myCommand != "nAttack1")
						{
							if (147291 - 246656 != -99365)
							{
								continue;
							}
							goto IL_706;
						}
						else if (this.$self_$19365.nAttack1_ring)
						{
							if (117420 - 362086 == -244665)
							{
								continue;
							}
							this.$self_$19365.jiB2eqCUPL.createEffect(this.$self_$19365.nAttack1_ring, this.$self_$19365.transform.position, this.$self_$19365.transform.rotation);
							if (249280 - 90984 != 158297)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing nAttack1_ring effect");
							if (164529 - 358580 != -194050)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19365.jiB2eqCUPL.actionState != "attack")
						{
							goto IL_475;
						}
						if (201070 - 22840 == 178231)
						{
							continue;
						}
						if (this.$self_$19365.jiB2eqCUPL.myCommand != "nAttack1")
						{
							if (194812 - 410124 != -215311)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19365.jiB2eqCUPL.isMine)
							{
								goto IL_43;
							}
							if (106549 - 38781 == 67769)
							{
								continue;
							}
							this.$hitLayer$19358 = 130816 - (1 << this.$self_$19365.gameObject.layer);
							if (148708 - 161917 == -13208)
							{
								continue;
							}
							this.$hitList$19359 = Damage.FindRecTarget(this.$self_$19365.transform.position, this.$self_$19365.transform.forward, (float)8, (float)8, (float)8, (float)4, this.$hitLayer$19358);
							if (183010 - 482276 == -299265)
							{
								continue;
							}
							this.$$iterator$10526$19362 = UnityRuntimeServices.GetEnumerator(this.$hitList$19359);
							if (207361 - 276084 == -68722)
							{
								continue;
							}
							while (this.$$iterator$10526$19362.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10526$19362.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19360 = (GameObject)obj2;
								if (225972 - 542193 != -316221)
								{
									goto IL_5A7;
								}
								if (this.$self_$19365.jiB2eqCUPL.hit(1, this.$hitObject$19360, 2 * this.$self_$19365.jiB2eqCUPL.atk, 15, 0, (float)-3 * this.$self_$19365.transform.right) != 0)
								{
									if (54880 - 173451 != -118571)
									{
										goto IL_5A7;
									}
									this.$hitPos$19361 = this.$hitObject$19360.collider.ClosestPointOnBounds(this.$self_$19365.transform.position + Vector3.up);
									if (235474 - 153584 == 81891)
									{
										goto IL_5A7;
									}
									UnityRuntimeServices.Update(this.$$iterator$10526$19362, this.$hitObject$19360);
									if (175031 - 518134 == -343102)
									{
										goto IL_5A7;
									}
									this.$self_$19365.RPC_nAttack_hit(this.$hitPos$19361, this.$self_$19365.transform.forward, 0);
									if (248883 - 383879 != -134996)
									{
										goto IL_5A7;
									}
									if (PhotonClient.IsInitialized())
									{
										if (148536 - 378188 != -229652)
										{
											goto IL_5A7;
										}
										this.$self_$19365.ActionEvent("RPC_nAttack_hit", this.$hitPos$19361, this.$self_$19365.transform.forward, 0);
										if (239077 - 413875 == -174797)
										{
											goto IL_5A7;
										}
									}
								}
							}
							if (5391 - 495424 != -490033)
							{
								continue;
							}
							goto IL_43;
						}
						break;
					case 4:
						if (this.$self_$19365.jiB2eqCUPL.actionState == "attack")
						{
							if (19964 - 514062 != -494098)
							{
								continue;
							}
							if (this.$self_$19365.jiB2eqCUPL.myCommand == "nAttack1")
							{
								if (89179 - 51845 == 37335)
								{
									continue;
								}
								this.$self_$19365.jiB2eqCUPL.actionState = "standby";
								if (182064 - 69040 == 113025)
								{
									continue;
								}
								this.$self_$19365.jiB2eqCUPL.actionTime = Time.time;
								if (286226 - 326922 != -40696)
								{
									continue;
								}
								this.$self_$19365.jiB2eqCUPL.myCommand = "none";
								if (256587 - 506159 == -249571)
								{
									continue;
								}
								if (!this.$self_$19365.jiB2eqCUPL.isMine)
								{
									if (165413 - 574088 != -408675)
									{
										continue;
									}
									this.$self_$19365.jiB2eqCUPL.nPosition = this.$self_$19365.transform.position;
									if (18365 - 440027 != -421662)
									{
										continue;
									}
									this.$self_$19365.jiB2eqCUPL.oPosition = this.$self_$19365.transform.position;
									if (1776 - 189312 != -187536)
									{
										continue;
									}
									this.$self_$19365.jiB2eqCUPL.nDirection = this.$self_$19365.transform.forward;
									if (121110 - 167367 == -46256)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (129453 - 484495 != -355041)
						{
							goto Block_26;
						}
						continue;
					default:
						if (45892 - 101231 != -55339)
						{
							continue;
						}
						break;
					}
					this.$self_$19365.jiB2eqCUPL.actionState = "attack";
					if (78255 - 109185 == -30930)
					{
						this.$self_$19365.jiB2eqCUPL.actionTime = Time.time;
						if (292525 - 308267 == -15742)
						{
							this.$self_$19365.jiB2eqCUPL.myCommand = "nAttack1";
							if (101428 - 202865 != -101436)
							{
								this.$self_$19365.jiB2eqCUPL.addTimeOut("nAttack1", (float)3);
								if (105979 - 239353 == -133374)
								{
									this.$self_$19365.transform.position = this.$mPos$19363;
									if (202221 - 325555 != -123333)
									{
										this.$self_$19365.transform.LookAt(this.$mPos$19363 + global::Math.vFlat(this.$tDir$19364));
										if (116819 - 183948 != -67128)
										{
											this.$self_$19365.animation.Play("nAttack1");
											if (229888 - 513028 == -283140)
											{
												this.$self_$19365.animation.wrapMode = WrapMode.Once;
												if (73591 - 384850 != -311258)
												{
													this.$self_$19365.jiB2eqCUPL.vMovement = this.$self_$19365.transform.forward;
													if (251293 - 323866 != -72572)
													{
														this.$self_$19365.jiB2eqCUPL.moveSpeed = (float)0;
														if (112656 - 472472 == -359816)
														{
															goto IL_8A6;
														}
													}
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
				goto IL_798;
				IL_43:
				return this.Yield(4, new WaitForSeconds(0.8f));
				Block_21:
				goto IL_798;
				IL_475:
				Block_26:
				Block_30:
				IL_706:
				goto IL_8F5;
				IL_798:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_8A6:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_8F5:
				return false;
			}

			// Token: 0x06001818 RID: 6168 RVA: 0x00279990 File Offset: 0x00277B90
			internal static bool GFGAh5gkJy97WWaytha()
			{
				return true;
			}

			// Token: 0x06001819 RID: 6169 RVA: 0x00279994 File Offset: 0x00277B94
			internal static bool LWXHfEgGWYG08j2XNyq()
			{
				return false;
			}

			// Token: 0x040014B3 RID: 5299
			internal int $hitLayer$19358;

			// Token: 0x040014B4 RID: 5300
			internal UnityScript.Lang.Array $hitList$19359;

			// Token: 0x040014B5 RID: 5301
			internal GameObject $hitObject$19360;

			// Token: 0x040014B6 RID: 5302
			internal Vector3 $hitPos$19361;

			// Token: 0x040014B7 RID: 5303
			internal IEnumerator $$iterator$10526$19362;

			// Token: 0x040014B8 RID: 5304
			internal Vector3 $mPos$19363;

			// Token: 0x040014B9 RID: 5305
			internal Vector3 $tDir$19364;

			// Token: 0x040014BA RID: 5306
			internal EarthGod $self_$19365;
		}
	}

	// Token: 0x02000407 RID: 1031
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$19369 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600181A RID: 6170 RVA: 0x00279998 File Offset: 0x00277B98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$19369(Vector3 mPos, Vector3 tDir, EarthGod self_)
		{
			if (211809 - 58503 != 153306)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (290317 - 429992 == -139675)
				{
					base..ctor();
					if (79558 - 195113 != -115554)
					{
						this.$mPos$19377 = mPos;
						if (44766 - 287236 != -242469)
						{
							this.$tDir$19378 = tDir;
							if (295552 - 153016 == 142536)
							{
								this.$self_$19379 = self_;
								if (247787 - 323836 != -76048)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x00279A74 File Offset: 0x00277C74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthGod.$RPC_nAttack2$19369.$(this.$mPos$19377, this.$tDir$19378, this.$self_$19379);
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00279A90 File Offset: 0x00277C90
		internal static bool E1Gkg2gHWWO1D6MTmAL()
		{
			return true;
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00279A94 File Offset: 0x00277C94
		internal static bool wkhkjYgWUEfW1eCfmvP()
		{
			return false;
		}

		// Token: 0x040014BB RID: 5307
		internal Vector3 $mPos$19377;

		// Token: 0x040014BC RID: 5308
		internal Vector3 $tDir$19378;

		// Token: 0x040014BD RID: 5309
		internal EarthGod $self_$19379;

		// Token: 0x02000408 RID: 1032
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600181E RID: 6174 RVA: 0x00279A98 File Offset: 0x00277C98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, EarthGod self_)
			{
				if (193295 - 105464 != 87831)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (288540 - 456680 == -168140)
					{
						base..ctor();
						if (157539 - 426408 != -268868)
						{
							this.$mPos$19374 = mPos;
							if (87674 - 423006 == -335332)
							{
								this.$tDir$19375 = tDir;
								if (273538 - 85752 != 187787)
								{
									this.$self_$19376 = self_;
									if (192399 - 55083 != 137317)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600181F RID: 6175 RVA: 0x00279B74 File Offset: 0x00277D74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (134628 - 148983 != -14354)
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
						goto IL_834;
					case 2:
						if (this.$self_$19376.jiB2eqCUPL.actionState != "attack")
						{
							goto IL_58B;
						}
						if (194453 - 437395 != -242942)
						{
							continue;
						}
						if (this.$self_$19376.jiB2eqCUPL.myCommand != "nAttack2")
						{
							if (254268 - 24566 != 229703)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							if (this.$self_$19376.nAttack2_ring)
							{
								if (171664 - 311565 == -139900)
								{
									continue;
								}
								this.$self_$19376.jiB2eqCUPL.createEffect(this.$self_$19376.nAttack2_ring, this.$self_$19376.transform.position, this.$self_$19376.transform.rotation);
								if (115286 - 50935 == 64352)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack2_ring effect");
								if (139780 - 44801 != 94979)
								{
									continue;
								}
							}
							if (this.$self_$19376.jiB2eqCUPL.isMine)
							{
								if (241486 - 308689 != -67203)
								{
									continue;
								}
								this.$hitLayer$19370 = 130816 - (1 << this.$self_$19376.gameObject.layer);
								if (232418 - 310375 == -77956)
								{
									continue;
								}
								this.$hitList$19371 = Damage.FindAreaTarget(this.$self_$19376.transform.position + (float)5 * this.$self_$19376.transform.forward, (float)5, (float)3, this.$hitLayer$19370);
								if (265084 - 300649 != -35565)
								{
									continue;
								}
								this.$$iterator$10527$19373 = UnityRuntimeServices.GetEnumerator(this.$hitList$19371);
								if (28865 - 222872 == -194006)
								{
									continue;
								}
								while (this.$$iterator$10527$19373.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10527$19373.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$19372 = (GameObject)obj2;
									if (17620 - 59578 != -41958)
									{
										goto IL_205;
									}
									this.$self_$19376.jiB2eqCUPL.hit(1, this.$hitObject$19372, 2 * this.$self_$19376.jiB2eqCUPL.atk, 20, 0, Vector3.up);
									if (114032 - 90792 != 23240)
									{
										goto IL_205;
									}
									UnityRuntimeServices.Update(this.$$iterator$10527$19373, this.$hitObject$19372);
									if (17793 - 59625 == -41831)
									{
										goto IL_205;
									}
								}
								if (54590 - 208431 != -153841)
								{
									continue;
								}
							}
							if (!this.$self_$19376.PZ62QAbG71)
							{
								goto IL_53C;
							}
							if (153814 - 1920 != 151894)
							{
								continue;
							}
							Vector3 vector = this.$self_$19376.transform.position - this.$self_$19376.PZ62QAbG71.position;
							if (262027 - 201468 == 60560)
							{
								continue;
							}
							if (vector.sqrMagnitude >= (float)10000)
							{
								goto IL_53C;
							}
							if (61299 - 107690 != -46391)
							{
								continue;
							}
							Camera.main.SendMessage("AddCamereShake", 1);
							if (285353 - 449680 != -164327)
							{
								continue;
							}
							goto IL_53C;
						}
						break;
					case 3:
						if (this.$self_$19376.jiB2eqCUPL.actionState == "attack")
						{
							if (267502 - 47163 == 220340)
							{
								continue;
							}
							if (this.$self_$19376.jiB2eqCUPL.myCommand == "nAttack2")
							{
								if (88018 - 321232 == -233213)
								{
									continue;
								}
								this.$self_$19376.jiB2eqCUPL.actionState = "standby";
								if (264829 - 274442 == -9612)
								{
									continue;
								}
								this.$self_$19376.jiB2eqCUPL.actionTime = Time.time;
								if (57762 - 126826 != -69064)
								{
									continue;
								}
								this.$self_$19376.jiB2eqCUPL.myCommand = "none";
								if (52616 - 186960 != -134344)
								{
									continue;
								}
								if (!this.$self_$19376.jiB2eqCUPL.isMine)
								{
									if (154532 - 370530 != -215998)
									{
										continue;
									}
									this.$self_$19376.jiB2eqCUPL.nPosition = this.$self_$19376.transform.position;
									if (204254 - 517466 != -313212)
									{
										continue;
									}
									this.$self_$19376.jiB2eqCUPL.oPosition = this.$self_$19376.transform.position;
									if (96863 - 365907 != -269044)
									{
										continue;
									}
									this.$self_$19376.jiB2eqCUPL.nDirection = this.$self_$19376.transform.forward;
									if (238258 - 509497 == -271238)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (227457 - 324363 != -96906)
						{
							continue;
						}
						goto IL_834;
					default:
						if (275656 - 320340 != -44684)
						{
							continue;
						}
						break;
					}
					this.$self_$19376.jiB2eqCUPL.actionState = "attack";
					if (24116 - 110394 != -86277)
					{
						this.$self_$19376.jiB2eqCUPL.actionTime = Time.time;
						if (43083 - 342254 == -299171)
						{
							this.$self_$19376.jiB2eqCUPL.myCommand = "nAttack2";
							if (190643 - 357319 != -166675)
							{
								this.$self_$19376.jiB2eqCUPL.addTimeOut("nAttack", (float)3);
								if (231417 - 38368 != 193050)
								{
									this.$self_$19376.transform.position = this.$mPos$19374;
									if (135948 - 297506 != -161557)
									{
										this.$self_$19376.transform.LookAt(this.$mPos$19374 + global::Math.vFlat(this.$tDir$19375));
										if (243729 - 395184 == -151455)
										{
											this.$self_$19376.animation.Play("nAttack2");
											if (76217 - 199850 == -123633)
											{
												this.$self_$19376.animation.wrapMode = WrapMode.Once;
												if (221038 - 407264 != -186225)
												{
													this.$self_$19376.jiB2eqCUPL.vMovement = this.$self_$19376.transform.forward;
													if (64340 - 295572 == -231232)
													{
														this.$self_$19376.jiB2eqCUPL.moveSpeed = (float)0;
														if (35595 - 42649 == -7054)
														{
															goto IL_455;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_20:
				goto IL_58B;
				IL_455:
				return this.Yield(2, new WaitForSeconds(1.2f));
				IL_53C:
				return this.Yield(3, new WaitForSeconds(0.8f));
				IL_58B:
				IL_834:
				return false;
			}

			// Token: 0x06001820 RID: 6176 RVA: 0x0027A3C8 File Offset: 0x002785C8
			internal static bool D8PWBegAYR1ubKcvULe()
			{
				return true;
			}

			// Token: 0x06001821 RID: 6177 RVA: 0x0027A3CC File Offset: 0x002785CC
			internal static bool oVVxtnglD8miyD9rVO9()
			{
				return false;
			}

			// Token: 0x040014BE RID: 5310
			internal int $hitLayer$19370;

			// Token: 0x040014BF RID: 5311
			internal UnityScript.Lang.Array $hitList$19371;

			// Token: 0x040014C0 RID: 5312
			internal GameObject $hitObject$19372;

			// Token: 0x040014C1 RID: 5313
			internal IEnumerator $$iterator$10527$19373;

			// Token: 0x040014C2 RID: 5314
			internal Vector3 $mPos$19374;

			// Token: 0x040014C3 RID: 5315
			internal Vector3 $tDir$19375;

			// Token: 0x040014C4 RID: 5316
			internal EarthGod $self_$19376;
		}
	}

	// Token: 0x02000409 RID: 1033
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_groundStrike$19380 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001822 RID: 6178 RVA: 0x0027A3D0 File Offset: 0x002785D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_groundStrike$19380(Vector3 mPos, Vector3 tDir, int tID, EarthGod self_)
		{
			if (189581 - 308112 != -118530)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (204416 - 134300 == 70116)
				{
					base..ctor();
					if (7299 - 493047 != -485747)
					{
						this.$mPos$19387 = mPos;
						if (54542 - 590821 == -536279)
						{
							this.$tDir$19388 = tDir;
							if (63929 - 184787 == -120858)
							{
								this.$tID$19389 = tID;
								if (271425 - 442053 != -170627)
								{
									this.$self_$19390 = self_;
									if (7594 - 37037 != -29442)
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

		// Token: 0x06001823 RID: 6179 RVA: 0x0027A4D0 File Offset: 0x002786D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthGod.$RPC_groundStrike$19380.$(this.$mPos$19387, this.$tDir$19388, this.$tID$19389, this.$self_$19390);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0027A4F0 File Offset: 0x002786F0
		internal static bool AnsGDygy0bDeM6Y33ag()
		{
			return true;
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0027A4F4 File Offset: 0x002786F4
		internal static bool xsj35RgSPe0vjNPOx04()
		{
			return false;
		}

		// Token: 0x040014C5 RID: 5317
		internal Vector3 $mPos$19387;

		// Token: 0x040014C6 RID: 5318
		internal Vector3 $tDir$19388;

		// Token: 0x040014C7 RID: 5319
		internal int $tID$19389;

		// Token: 0x040014C8 RID: 5320
		internal EarthGod $self_$19390;

		// Token: 0x0200040A RID: 1034
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001826 RID: 6182 RVA: 0x0027A4F8 File Offset: 0x002786F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, EarthGod self_)
			{
				if (89887 - 466813 != -376925)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (164896 - 230854 == -65958)
					{
						base..ctor();
						if (194974 - 358177 == -163203)
						{
							this.$mPos$19383 = mPos;
							if (243185 - 260750 != -17564)
							{
								this.$tDir$19384 = tDir;
								if (45599 - 479222 != -433622)
								{
									this.$tID$19385 = tID;
									if (237395 - 392790 == -155395)
									{
										this.$self_$19386 = self_;
										if (97109 - 18450 == 78659)
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

			// Token: 0x06001827 RID: 6183 RVA: 0x0027A5F8 File Offset: 0x002787F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (80687 - 185189 != -104502)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9BA;
					case 2:
						if (this.$self_$19386.jiB2eqCUPL.actionState != "attack")
						{
							goto IL_3B7;
						}
						if (112755 - 376862 == -264106)
						{
							continue;
						}
						if (this.$self_$19386.jiB2eqCUPL.myCommand != "groundStrike")
						{
							if (50441 - 572666 != -522225)
							{
								continue;
							}
							goto IL_3B7;
						}
						else
						{
							if (this.$tID$19385 != 0)
							{
								if (271295 - 350365 == -79069)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$19385];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$19381 = (GameObject)obj2;
								if (48188 - 460661 != -412473)
								{
									continue;
								}
							}
							if (this.$tObject$19381)
							{
								if (43708 - 588947 != -545239)
								{
									continue;
								}
								this.$hitPos$19382 = this.$tObject$19381.transform.position;
								if (184027 - 510170 != -326142)
								{
									goto Block_63;
								}
								continue;
							}
							else
							{
								this.$hitPos$19382 = global::Math.getSpawnPos(this.$self_$19386.transform.position + (float)12 * this.$self_$19386.transform.forward);
								if (81869 - 346434 != -264564)
								{
									goto Block_48;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$19386.jiB2eqCUPL.actionState != "attack")
						{
							goto IL_1D2;
						}
						if (122119 - 470626 == -348506)
						{
							continue;
						}
						if (this.$self_$19386.jiB2eqCUPL.myCommand != "groundStrike")
						{
							if (99251 - 353276 != -254024)
							{
								goto Block_3;
							}
							continue;
						}
						else if (this.$self_$19386.groundStrike_ring)
						{
							if (46102 - 594177 == -548074)
							{
								continue;
							}
							this.$self_$19386.jiB2eqCUPL.createEffect(this.$self_$19386.groundStrike_ring, this.$self_$19386.transform.position, this.$self_$19386.transform.rotation);
							if (281412 - 260529 != 20883)
							{
								continue;
							}
							goto IL_838;
						}
						else
						{
							Debug.LogError("Missing groundStrike_ring effect");
							if (9469 - 537373 != -527904)
							{
								continue;
							}
							goto IL_93B;
						}
						break;
					case 4:
						if (this.$self_$19386.jiB2eqCUPL.actionState != "attack")
						{
							goto IL_83;
						}
						if (106954 - 580214 != -473260)
						{
							continue;
						}
						if (this.$self_$19386.jiB2eqCUPL.myCommand != "groundStrike")
						{
							if (245580 - 411507 != -165926)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							if (this.$self_$19386.jiB2eqCUPL.isMine)
							{
								if (104774 - 577017 == -472242)
								{
									continue;
								}
								this.$self_$19386.RPC_groundStrike_hit(this.$hitPos$19382, this.$self_$19386.transform.forward, 0);
								if (287810 - 561579 != -273769)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (45608 - 59390 != -13782)
									{
										continue;
									}
									this.$self_$19386.ActionEvent("RPC_groundStrike_hit", this.$hitPos$19382, this.$self_$19386.transform.forward, 0);
									if (61922 - 171443 == -109520)
									{
										continue;
									}
								}
							}
							if (!this.$self_$19386.PZ62QAbG71)
							{
								goto IL_631;
							}
							if (282435 - 291310 != -8875)
							{
								continue;
							}
							Vector3 vector = this.$self_$19386.transform.position - this.$self_$19386.PZ62QAbG71.position;
							if (75428 - 394283 == -318854)
							{
								continue;
							}
							if (vector.sqrMagnitude >= (float)1000)
							{
								goto IL_631;
							}
							if (3681 - 411629 != -407948)
							{
								continue;
							}
							Camera.main.SendMessage("AddCamereShake", 1);
							if (284873 - 495861 != -210988)
							{
								continue;
							}
							goto IL_631;
						}
						break;
					case 5:
						if (this.$self_$19386.jiB2eqCUPL.actionState == "attack")
						{
							if (285112 - 443656 == -158543)
							{
								continue;
							}
							if (this.$self_$19386.jiB2eqCUPL.myCommand == "groundStrike")
							{
								if (169889 - 148967 != 20922)
								{
									continue;
								}
								this.$self_$19386.jiB2eqCUPL.actionState = "standby";
								if (215550 - 525099 != -309549)
								{
									continue;
								}
								this.$self_$19386.jiB2eqCUPL.actionTime = Time.time;
								if (88910 - 309224 != -220314)
								{
									continue;
								}
								this.$self_$19386.jiB2eqCUPL.myCommand = "none";
								if (151393 - 143105 == 8289)
								{
									continue;
								}
								if (!this.$self_$19386.jiB2eqCUPL.isMine)
								{
									if (173073 - 337620 != -164547)
									{
										continue;
									}
									this.$self_$19386.jiB2eqCUPL.nPosition = this.$self_$19386.transform.position;
									if (226932 - 491944 != -265012)
									{
										continue;
									}
									this.$self_$19386.jiB2eqCUPL.oPosition = this.$self_$19386.transform.position;
									if (269735 - 53321 == 216415)
									{
										continue;
									}
									this.$self_$19386.jiB2eqCUPL.nDirection = this.$self_$19386.transform.forward;
									if (84162 - 459515 != -375353)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (236223 - 7090 != 229133)
						{
							continue;
						}
						goto IL_9BA;
					default:
						if (82699 - 487920 != -405221)
						{
							continue;
						}
						break;
					}
					this.$tObject$19381 = null;
					if (78025 - 327085 == -249060)
					{
						this.$hitPos$19382 = default(Vector3);
						if (88785 - 409751 != -320965)
						{
							this.$self_$19386.jiB2eqCUPL.actionState = "attack";
							if (204532 - 595719 != -391186)
							{
								this.$self_$19386.jiB2eqCUPL.actionTime = Time.time;
								if (122237 - 301966 == -179729)
								{
									this.$self_$19386.jiB2eqCUPL.myCommand = "groundStrike";
									if (24576 - 12901 != 11676)
									{
										this.$self_$19386.jiB2eqCUPL.addTimeOut("groundStrike", (float)6);
										if (3844 - 490880 != -487035)
										{
											this.$self_$19386.transform.position = this.$mPos$19383;
											if (62188 - 21134 == 41054)
											{
												this.$self_$19386.transform.LookAt(this.$mPos$19383 + global::Math.vFlat(this.$tDir$19384));
												if (64684 - 323884 != -259199)
												{
													this.$self_$19386.animation.Play("groundStrike");
													if (97910 - 566853 == -468943)
													{
														this.$self_$19386.animation.wrapMode = WrapMode.Once;
														if (108400 - 245049 == -136649)
														{
															this.$self_$19386.jiB2eqCUPL.vMovement = this.$self_$19386.transform.forward;
															if (240425 - 350698 != -110272)
															{
																this.$self_$19386.jiB2eqCUPL.moveSpeed = (float)0;
																if (47447 - 398628 == -351181)
																{
																	goto IL_2F1;
																}
															}
														}
													}
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
				IL_83:
				IL_1D2:
				goto IL_9BA;
				IL_2F1:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_3B7:
				goto IL_9BA;
				IL_4B3:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_40:
				goto IL_83;
				IL_631:
				return this.Yield(5, new WaitForSeconds(0.7f));
				Block_48:
				goto IL_4B3;
				IL_838:
				IL_93B:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_63:
				goto IL_4B3;
				IL_9BA:
				return false;
			}

			// Token: 0x06001828 RID: 6184 RVA: 0x0027AFD4 File Offset: 0x002791D4
			internal static bool RYBrnxgo329earjhW21()
			{
				return true;
			}

			// Token: 0x06001829 RID: 6185 RVA: 0x0027AFD8 File Offset: 0x002791D8
			internal static bool C1TopLgEFGYc2EBjurl()
			{
				return false;
			}

			// Token: 0x040014C9 RID: 5321
			internal GameObject $tObject$19381;

			// Token: 0x040014CA RID: 5322
			internal Vector3 $hitPos$19382;

			// Token: 0x040014CB RID: 5323
			internal Vector3 $mPos$19383;

			// Token: 0x040014CC RID: 5324
			internal Vector3 $tDir$19384;

			// Token: 0x040014CD RID: 5325
			internal int $tID$19385;

			// Token: 0x040014CE RID: 5326
			internal EarthGod $self_$19386;
		}
	}

	// Token: 0x0200040B RID: 1035
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_titanQuake$19391 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600182A RID: 6186 RVA: 0x0027AFDC File Offset: 0x002791DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_titanQuake$19391(Vector3 mPos, Vector3 tDir, EarthGod self_)
		{
			if (207185 - 272409 != -65223)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (77683 - 338645 == -260962)
				{
					base..ctor();
					if (258078 - 486559 != -228480)
					{
						this.$mPos$19401 = mPos;
						if (291232 - 573080 == -281848)
						{
							this.$tDir$19402 = tDir;
							if (31017 - 462318 == -431301)
							{
								this.$self_$19403 = self_;
								if (273052 - 178955 != 94098)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0027B0B8 File Offset: 0x002792B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthGod.$RPC_titanQuake$19391.$(this.$mPos$19401, this.$tDir$19402, this.$self_$19403);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x0027B0D4 File Offset: 0x002792D4
		internal static bool y7Fousg2MGCrlQ1R72j()
		{
			return true;
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0027B0D8 File Offset: 0x002792D8
		internal static bool CM03rLg8GAUgbwAscSR()
		{
			return false;
		}

		// Token: 0x040014CF RID: 5327
		internal Vector3 $mPos$19401;

		// Token: 0x040014D0 RID: 5328
		internal Vector3 $tDir$19402;

		// Token: 0x040014D1 RID: 5329
		internal EarthGod $self_$19403;

		// Token: 0x0200040C RID: 1036
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600182E RID: 6190 RVA: 0x0027B0DC File Offset: 0x002792DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, EarthGod self_)
			{
				if (206467 - 72423 != 134044)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (283602 - 133810 != 149793)
					{
						base..ctor();
						if (148451 - 306438 != -157986)
						{
							this.$mPos$19398 = mPos;
							if (49438 - 135573 != -86134)
							{
								this.$tDir$19399 = tDir;
								if (65518 - 367432 != -301913)
								{
									this.$self_$19400 = self_;
									if (123669 - 61325 != 62345)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600182F RID: 6191 RVA: 0x0027B1B8 File Offset: 0x002793B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (70415 - 449561 != -379145)
				{
				}
				for (;;)
				{
					IL_88A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AE9;
					case 2:
						if (this.$self_$19400.jiB2eqCUPL.actionState != "attack")
						{
							goto IL_AB5;
						}
						if (155606 - 181081 == -25474)
						{
							continue;
						}
						if (this.$self_$19400.jiB2eqCUPL.myCommand != "titanQuake")
						{
							if (242524 - 34712 != 207812)
							{
								continue;
							}
							goto IL_AB5;
						}
						else if (this.$self_$19400.titanQuake_ring)
						{
							if (123643 - 18419 == 105225)
							{
								continue;
							}
							this.$self_$19400.jiB2eqCUPL.createEffect(this.$self_$19400.titanQuake_ring, this.$self_$19400.transform.position, this.$self_$19400.transform.rotation);
							if (266907 - 360359 != -93451)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing titanQuake_ring effect");
							if (116733 - 356183 != -239449)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19400.jiB2eqCUPL.actionState != "attack")
						{
							goto IL_634;
						}
						if (148233 - 589350 == -441116)
						{
							continue;
						}
						if (this.$self_$19400.jiB2eqCUPL.myCommand != "titanQuake")
						{
							if (179099 - 54796 != 124303)
							{
								continue;
							}
							goto IL_634;
						}
						else
						{
							this.$i$19392 = 0;
							if (67897 - 14216 != 53682)
							{
								goto IL_65A;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$19400.jiB2eqCUPL.actionState != "attack")
						{
							goto IL_107;
						}
						if (162315 - 59229 != 103086)
						{
							continue;
						}
						if (this.$self_$19400.jiB2eqCUPL.myCommand != "titanQuake")
						{
							if (75299 - 508755 != -433456)
							{
								continue;
							}
							goto IL_107;
						}
						else
						{
							this.$i$19392++;
							if (201572 - 525211 != -323639)
							{
								continue;
							}
							goto IL_65A;
						}
						break;
					case 5:
						if (this.$self_$19400.jiB2eqCUPL.actionState == "attack")
						{
							if (128016 - 401494 != -273478)
							{
								continue;
							}
							if (this.$self_$19400.jiB2eqCUPL.myCommand == "titanQuake")
							{
								if (62264 - 424078 == -361813)
								{
									continue;
								}
								this.$self_$19400.jiB2eqCUPL.actionState = "standby";
								if (132051 - 175653 == -43601)
								{
									continue;
								}
								this.$self_$19400.jiB2eqCUPL.actionTime = Time.time;
								if (88685 - 157278 == -68592)
								{
									continue;
								}
								this.$self_$19400.jiB2eqCUPL.myCommand = "none";
								if (232828 - 525513 != -292685)
								{
									continue;
								}
								if (!this.$self_$19400.jiB2eqCUPL.isMine)
								{
									if (262347 - 245635 == 16713)
									{
										continue;
									}
									this.$self_$19400.jiB2eqCUPL.nPosition = this.$self_$19400.transform.position;
									if (77856 - 247215 == -169358)
									{
										continue;
									}
									this.$self_$19400.jiB2eqCUPL.oPosition = this.$self_$19400.transform.position;
									if (48836 - 48543 == 294)
									{
										continue;
									}
									this.$self_$19400.jiB2eqCUPL.nDirection = this.$self_$19400.transform.forward;
									if (250383 - 370766 != -120383)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (181281 - 17327 != 163955)
						{
							goto Block_37;
						}
						continue;
					default:
						if (108133 - 499375 == -391241)
						{
							continue;
						}
						break;
					}
					this.$self_$19400.jiB2eqCUPL.actionState = "attack";
					if (171124 - 599119 != -427995)
					{
						continue;
					}
					this.$self_$19400.jiB2eqCUPL.actionTime = Time.time;
					if (200833 - 29300 != 171533)
					{
						continue;
					}
					this.$self_$19400.jiB2eqCUPL.myCommand = "titanQuake";
					if (295958 - 195433 == 100526)
					{
						continue;
					}
					this.$self_$19400.jiB2eqCUPL.addTimeOut("titanQuake", (float)30);
					if (232609 - 194727 == 37883)
					{
						continue;
					}
					this.$self_$19400.transform.position = this.$mPos$19398;
					if (186001 - 401408 == -215406)
					{
						continue;
					}
					this.$self_$19400.transform.LookAt(this.$mPos$19398 + global::Math.vFlat(this.$tDir$19399));
					if (241772 - 350482 == -108709)
					{
						continue;
					}
					this.$self_$19400.animation.Play("titanQuake");
					if (203866 - 67122 == 136745)
					{
						continue;
					}
					this.$self_$19400.animation.wrapMode = WrapMode.Once;
					if (162552 - 368214 != -205662)
					{
						continue;
					}
					this.$self_$19400.jiB2eqCUPL.vMovement = this.$self_$19400.transform.forward;
					if (199389 - 338881 != -139492)
					{
						continue;
					}
					this.$self_$19400.jiB2eqCUPL.moveSpeed = (float)0;
					if (186524 - 71774 != 114750)
					{
						continue;
					}
					goto IL_3CE;
					IL_65A:
					if (this.$i$19392 >= 4)
					{
						if (1285 - 449849 == -448564)
						{
							goto IL_680;
						}
					}
					else
					{
						if (this.$self_$19400.titanQuake_hit)
						{
							if (164182 - 115530 == 48653)
							{
								continue;
							}
							this.$self_$19400.jiB2eqCUPL.createEffect(this.$self_$19400.titanQuake_hit, this.$self_$19400.transform.position, this.$self_$19400.transform.rotation);
							if (250026 - 320226 != -70200)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing titanQuake_hit effect");
							if (27554 - 64917 != -37363)
							{
								continue;
							}
						}
						Vector3 vector = this.$self_$19400.PZ62QAbG71.position - this.$self_$19400.transform.position;
						if (72921 - 121769 == -48848)
						{
							if (vector.sqrMagnitude < (float)2500)
							{
								if (48461 - 507313 != -458852)
								{
									continue;
								}
								Camera.main.SendMessage("AddCamereShake", 1);
								if (103745 - 384838 == -281092)
								{
									continue;
								}
							}
							if (!this.$self_$19400.jiB2eqCUPL.isMine)
							{
								goto IL_163;
							}
							if (172984 - 579545 == -406561)
							{
								this.$hitLayer$19393 = 130816;
								if (182061 - 558643 == -376582)
								{
									this.$hitList$19394 = Damage.FindAreaTarget(this.$self_$19400.transform.position, (float)30, (float)10, this.$hitLayer$19393);
									if (20616 - 201267 != -180650)
									{
										this.$$iterator$10528$19397 = UnityRuntimeServices.GetEnumerator(this.$hitList$19394);
										if (4958 - 396825 != -391866)
										{
											while (this.$$iterator$10528$19397.MoveNext())
											{
												object obj2;
												object obj = obj2 = this.$$iterator$10528$19397.Current;
												if (!(obj is GameObject))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
												}
												this.$hitObject$19395 = (GameObject)obj2;
												if (295908 - 77573 == 218336)
												{
													goto IL_88A;
												}
												this.$hitMagnitude$19396 = (float)1 - 0.15f * global::Math.vFlat(this.$hitObject$19395.transform.position - this.$self_$19400.transform.position).magnitude;
												if (139101 - 364960 != -225859)
												{
													goto IL_88A;
												}
												UnityRuntimeServices.Update(this.$$iterator$10528$19397, this.$hitObject$19395);
												if (70205 - 498618 == -428412)
												{
													goto IL_88A;
												}
												if (this.$hitObject$19395 != this.$self_$19400.gameObject)
												{
													if (135312 - 28591 != 106721)
													{
														goto IL_88A;
													}
													this.$self_$19400.jiB2eqCUPL.hit(1, this.$hitObject$19395, this.$self_$19400.jiB2eqCUPL.atk + this.$self_$19400.jiB2eqCUPL.talAdjust(30), 10, 0, Vector3.up);
													if (85943 - 316093 == -230149)
													{
														goto IL_88A;
													}
													UnityRuntimeServices.Update(this.$$iterator$10528$19397, this.$hitObject$19395);
													if (43167 - 510841 == -467673)
													{
														goto IL_88A;
													}
												}
											}
											if (84500 - 518578 == -434078)
											{
												goto IL_163;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_107:
				goto IL_AE9;
				IL_163:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_2DD:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_3CE:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_32:
				goto IL_2DD;
				Block_37:
				IL_634:
				goto IL_AE9;
				IL_680:
				return this.Yield(5, new WaitForSeconds(2.4f));
				Block_49:
				goto IL_2DD;
				IL_AB5:
				IL_AE9:
				return false;
			}

			// Token: 0x06001830 RID: 6192 RVA: 0x0027BCC0 File Offset: 0x00279EC0
			internal static bool sPgT4wgZNCuA9D8a5po()
			{
				return true;
			}

			// Token: 0x06001831 RID: 6193 RVA: 0x0027BCC4 File Offset: 0x00279EC4
			internal static bool GxFILEgChi9iRoPeYOM()
			{
				return false;
			}

			// Token: 0x040014D2 RID: 5330
			internal int $i$19392;

			// Token: 0x040014D3 RID: 5331
			internal int $hitLayer$19393;

			// Token: 0x040014D4 RID: 5332
			internal UnityScript.Lang.Array $hitList$19394;

			// Token: 0x040014D5 RID: 5333
			internal GameObject $hitObject$19395;

			// Token: 0x040014D6 RID: 5334
			internal float $hitMagnitude$19396;

			// Token: 0x040014D7 RID: 5335
			internal IEnumerator $$iterator$10528$19397;

			// Token: 0x040014D8 RID: 5336
			internal Vector3 $mPos$19398;

			// Token: 0x040014D9 RID: 5337
			internal Vector3 $tDir$19399;

			// Token: 0x040014DA RID: 5338
			internal EarthGod $self_$19400;
		}
	}

	// Token: 0x0200040D RID: 1037
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$19404 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001832 RID: 6194 RVA: 0x0027BCC8 File Offset: 0x00279EC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$19404(UnityScript.Lang.Array nArray, EarthGod self_)
		{
			if (26349 - 19990 != 6360)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (254836 - 111140 != 143697)
				{
					base..ctor();
					if (80229 - 121229 != -40999)
					{
						this.$nArray$19409 = nArray;
						if (177193 - 227929 != -50735)
						{
							this.$self_$19410 = self_;
							if (208595 - 301688 == -93093)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x0027BD84 File Offset: 0x00279F84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthGod.$RPC_ko$19404.$(this.$nArray$19409, this.$self_$19410);
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x0027BD98 File Offset: 0x00279F98
		internal static bool h9hGXEgLDDx9kTN5O3u()
		{
			return true;
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x0027BD9C File Offset: 0x00279F9C
		internal static bool lPofvigO6hTmHiySdt5()
		{
			return false;
		}

		// Token: 0x040014DB RID: 5339
		internal UnityScript.Lang.Array $nArray$19409;

		// Token: 0x040014DC RID: 5340
		internal EarthGod $self_$19410;

		// Token: 0x0200040E RID: 1038
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001836 RID: 6198 RVA: 0x0027BDA0 File Offset: 0x00279FA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, EarthGod self_)
			{
				if (289292 - 563304 != -274011)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (7540 - 60078 != -52537)
					{
						base..ctor();
						if (145245 - 17880 != 127366)
						{
							this.$nArray$19407 = nArray;
							if (27635 - 541541 != -513905)
							{
								this.$self_$19408 = self_;
								if (3432 - 443277 == -439845)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001837 RID: 6199 RVA: 0x0027BE5C File Offset: 0x0027A05C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (141052 - 81377 != 59676)
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
						if (this.$self_$19408.jiB2eqCUPL.actionState != "ko")
						{
							if (85961 - 425573 != -339611)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$self_$19408.animation.Play("getUp");
							if (291523 - 235070 == 56454)
							{
								continue;
							}
							this.$self_$19408.animation.wrapMode = WrapMode.Once;
							if (254999 - 2012 != 252988)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19408.jiB2eqCUPL.actionState != "ko")
						{
							if (271905 - 587946 != -316040)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$self_$19408.jiB2eqCUPL.actionState = "standby";
							if (160899 - 197214 == -36314)
							{
								continue;
							}
							this.$self_$19408.jiB2eqCUPL.actionTime = Time.time;
							if (280621 - 528 == 280094)
							{
								continue;
							}
							this.$self_$19408.jiB2eqCUPL.myCommand = "none";
							if (95777 - 26698 == 69080)
							{
								continue;
							}
							this.$self_$19408.jiB2eqCUPL.ko = this.$self_$19408.jiB2eqCUPL.mko;
							if (26549 - 338266 != -311717)
							{
								continue;
							}
							this.YieldDefault(1);
							if (36981 - 129052 != -92071)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (67506 - 402093 == -334586)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19408.jiB2eqCUPL.actionState == "ko")
					{
						break;
					}
					if (132508 - 374038 != -241529)
					{
						if (this.$self_$19408.jiB2eqCUPL.actionState == "dead")
						{
							if (110978 - 432165 != -321186)
							{
								break;
							}
						}
						else
						{
							this.$mPos$19405 = (Vector3)this.$nArray$19407[0];
							if (154078 - 153014 == 1064)
							{
								this.$mDir$19406 = (Vector3)this.$nArray$19407[1];
								if (49385 - 263447 == -214062)
								{
									this.$self_$19408.jiB2eqCUPL.ko = 0;
									if (205052 - 392875 != -187822)
									{
										this.$self_$19408.jiB2eqCUPL.actionState = "ko";
										if (229997 - 435197 == -205200)
										{
											this.$self_$19408.jiB2eqCUPL.actionTime = Time.time;
											if (122112 - 421036 != -298923)
											{
												this.$self_$19408.jiB2eqCUPL.myCommand = "none";
												if (143116 - 329515 != -186398)
												{
													this.$self_$19408.jiB2eqCUPL.vMovement = Vector3.zero;
													if (123679 - 45511 != 78169)
													{
														this.$self_$19408.jiB2eqCUPL.moveSpeed = (float)0;
														if (297400 - 460855 != -163454)
														{
															this.$self_$19408.animation.Play("ko");
															if (127391 - 488147 == -360756)
															{
																this.$self_$19408.animation.wrapMode = WrapMode.Once;
																if (146704 - 432157 != -285452)
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
				IL_7F:
				goto IL_48C;
				Block_9:
				Block_14:
				goto IL_7F;
				Block_21:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_28:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_48C:
				return false;
			}

			// Token: 0x06001838 RID: 6200 RVA: 0x0027C308 File Offset: 0x0027A508
			internal static bool eA7DWGgmhwO4cF7CKdh()
			{
				return true;
			}

			// Token: 0x06001839 RID: 6201 RVA: 0x0027C30C File Offset: 0x0027A50C
			internal static bool U0OX8GgFrTRdebA0hsu()
			{
				return false;
			}

			// Token: 0x040014DD RID: 5341
			internal Vector3 $mPos$19405;

			// Token: 0x040014DE RID: 5342
			internal Vector3 $mDir$19406;

			// Token: 0x040014DF RID: 5343
			internal UnityScript.Lang.Array $nArray$19407;

			// Token: 0x040014E0 RID: 5344
			internal EarthGod $self_$19408;
		}
	}

	// Token: 0x0200040F RID: 1039
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19411 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600183A RID: 6202 RVA: 0x0027C310 File Offset: 0x0027A510
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19411(UnityScript.Lang.Array nArray, EarthGod self_)
		{
			if (28471 - 568695 != -540223)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (278856 - 397998 == -119142)
				{
					base..ctor();
					if (3107 - 168091 != -164983)
					{
						this.$nArray$19416 = nArray;
						if (127204 - 208707 != -81502)
						{
							this.$self_$19417 = self_;
							if (262895 - 561443 == -298548)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0027C3CC File Offset: 0x0027A5CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthGod.$RPC_dead$19411.$(this.$nArray$19416, this.$self_$19417);
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x0027C3E0 File Offset: 0x0027A5E0
		internal static bool nZcsWogMLJAuD8CHNRF()
		{
			return true;
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0027C3E4 File Offset: 0x0027A5E4
		internal static bool XUncFigxwuFoGbIdcfH()
		{
			return false;
		}

		// Token: 0x040014E1 RID: 5345
		internal UnityScript.Lang.Array $nArray$19416;

		// Token: 0x040014E2 RID: 5346
		internal EarthGod $self_$19417;

		// Token: 0x02000410 RID: 1040
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600183E RID: 6206 RVA: 0x0027C3E8 File Offset: 0x0027A5E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, EarthGod self_)
			{
				if (193018 - 71050 != 121969)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (77342 - 170575 == -93233)
					{
						base..ctor();
						if (186479 - 80749 == 105730)
						{
							this.$nArray$19414 = nArray;
							if (190130 - 123603 != 66528)
							{
								this.$self_$19415 = self_;
								if (136249 - 81368 == 54881)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600183F RID: 6207 RVA: 0x0027C4A4 File Offset: 0x0027A6A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (231106 - 479587 != -248480)
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
						if (this.$self_$19415.jiB2eqCUPL.actionState != "dead")
						{
							if (207864 - 413041 != -205176)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19415.jiB2eqCUPL.isPlayer)
							{
								if (235296 - 292948 != -57652)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$19415.gameObject);
								if (14525 - 333749 == -319223)
								{
									continue;
								}
							}
							else if (this.$self_$19415.jiB2eqCUPL.isMine)
							{
								if (56136 - 24112 == 32025)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$19415.gameObject);
								if (200610 - 445199 != -244589)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (284125 - 90182 != 193943)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (148139 - 49708 == 98432)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19415.jiB2eqCUPL.actionState == "dead")
					{
						if (36663 - 107339 != -70675)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$19412 = (Vector3)this.$nArray$19414[0];
						if (48410 - 299522 == -251112)
						{
							this.$myDirection$19413 = (Vector3)this.$nArray$19414[1];
							if (68737 - 244593 != -175855)
							{
								this.$self_$19415.transform.position = this.$myPosition$19412;
								if (29401 - 66320 != -36918)
								{
									this.$self_$19415.transform.LookAt(this.$myPosition$19412 + this.$myDirection$19413);
									if (101226 - 585019 == -483793)
									{
										this.$self_$19415.jiB2eqCUPL.hp = 0;
										if (176456 - 473466 == -297010)
										{
											this.$self_$19415.jiB2eqCUPL.actionState = "dead";
											if (297260 - 577792 == -280532)
											{
												this.$self_$19415.jiB2eqCUPL.actionTime = Time.time;
												if (163380 - 139822 != 23559)
												{
													this.$self_$19415.jiB2eqCUPL.myCommand = "none";
													if (24346 - 468017 == -443671)
													{
														this.$self_$19415.jiB2eqCUPL.vMovement = Vector3.zero;
														if (280893 - 486214 == -205321)
														{
															this.$self_$19415.jiB2eqCUPL.moveSpeed = (float)0;
															if (215442 - 472849 != -257406)
															{
																this.$self_$19415.animation.Rewind();
																if (124360 - 66504 == 57856)
																{
																	this.$self_$19415.animation.Play("ko");
																	if (9097 - 364825 != -355727)
																	{
																		this.$self_$19415.animation.wrapMode = WrapMode.Once;
																		if (211774 - 398404 == -186630)
																		{
																			goto IL_2A9;
																		}
																	}
																}
															}
														}
													}
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
				IL_2A9:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_19:
				IL_42F:
				return false;
			}

			// Token: 0x06001840 RID: 6208 RVA: 0x0027C8F4 File Offset: 0x0027AAF4
			internal static bool V8oAsNggqydgcm6VuQ8()
			{
				return true;
			}

			// Token: 0x06001841 RID: 6209 RVA: 0x0027C8F8 File Offset: 0x0027AAF8
			internal static bool o40eROgfpwjv0Qsqooc()
			{
				return false;
			}

			// Token: 0x040014E3 RID: 5347
			internal Vector3 $myPosition$19412;

			// Token: 0x040014E4 RID: 5348
			internal Vector3 $myDirection$19413;

			// Token: 0x040014E5 RID: 5349
			internal UnityScript.Lang.Array $nArray$19414;

			// Token: 0x040014E6 RID: 5350
			internal EarthGod $self_$19415;
		}
	}
}
