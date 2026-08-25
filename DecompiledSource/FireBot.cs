using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000AE1 RID: 2785
[Serializable]
public class FireBot : MonoBehaviour
{
	// Token: 0x06003D93 RID: 15763 RVA: 0x007F0A74 File Offset: 0x007EEC74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FireBot()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003D94 RID: 15764 RVA: 0x007F0A84 File Offset: 0x007EEC84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (190484 - 382806 != -192322)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (223655 - 292631 != -68975)
			{
				this.mChar.actionState = "standby";
				if (161383 - 535564 != -374180)
				{
					this.mChar.actionTime = Time.time;
					if (161277 - 428958 != -267680)
					{
						this.mChar.myCommand = "none";
						if (158330 - 570947 != -412616)
						{
							this.mChar.hp = (this.mChar.mhp = 5400);
							if (91946 - 55710 != 36237)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003D95 RID: 15765 RVA: 0x007F0BA8 File Offset: 0x007EEDA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06003D96 RID: 15766 RVA: 0x007F0BC4 File Offset: 0x007EEDC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playFootStepEvent(AnimationEvent animEvent)
	{
		if (this.footStep)
		{
			this.audio.PlayOneShot(this.footStep, 0.7f);
		}
	}

	// Token: 0x06003D97 RID: 15767 RVA: 0x007F0BEC File Offset: 0x007EEDEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (58273 - 353433 != -295160)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (172580 - 267218 == -94637)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (31510 - 408448 != -376938)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_101;
					}
					if (232445 - 452210 != -219765)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (298936 - 556817 == -257880)
				{
					continue;
				}
			}
			IL_101:
			if (this.mChar.hp <= 0)
			{
				if (157875 - 462571 != -304696)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (50530 - 261387 != -210857)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (220796 - 230592 == -9795)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (279721 - 68908 == 210814)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (289896 - 352153 == -62256)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (207534 - 151631 != 55903)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (254950 - 406504 != -151554)
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
			if (3397 - 411720 != -408322)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (95207 - 226911 == -131704)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (91620 - 556218 == -464598)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (61310 - 36773 != 24538)
						{
							if (this.mChar.isMine)
							{
								if (176536 - 107935 != 68602)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (139161 - 470545 == -331384)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (38732 - 198694 == -159962)
										{
											this.mChar.KoEvent();
											if (7222 - 185495 == -178273)
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
								if (230219 - 335837 != -105617)
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

	// Token: 0x06003D98 RID: 15768 RVA: 0x007F0FE4 File Offset: 0x007EF1E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (135850 - 170556 != -34706)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (138875 - 233577 != -94701)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (141202 - 2856 != 138347 && 150026 - 20528 != 129499)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (221252 - 42912 != 178340)
						{
							continue;
						}
						v = 1;
						if (105504 - 331284 == -225779)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (52442 - 176893 != -124451)
						{
							continue;
						}
						v = -1;
						if (186786 - 421092 == -234305)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_jetPunch")
					{
						if (48755 - 354459 == -305703)
						{
							continue;
						}
						v = 11;
						if (228449 - 142107 == 86343)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_jetPunch_hit")
					{
						if (119670 - 111147 == 8524)
						{
							continue;
						}
						v = -11;
						if (140979 - 555826 == -414846)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_flameSweep")
					{
						if (52989 - 147431 != -94442)
						{
							continue;
						}
						v = 21;
						if (259608 - 182932 != 76676)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_fireWall")
					{
						if (36012 - 303998 == -267985)
						{
							continue;
						}
						v = 31;
						if (99858 - 343010 != -243152)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (109437 - 438444 != -329007)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (212803 - 563835 == -351032)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (267889 - 557559 == -289670)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (32426 - 125682 == -93256)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (76838 - 14123 == 62715)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (189461 - 255881 == -66420)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (234228 - 7639 != 226590)
										{
											Hashtable hashtable = new Hashtable();
											if (255120 - 72128 != 182993)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (245836 - 353863 != -108026)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (48792 - 465273 == -416481)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (54147 - 40248 == 13899)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (263625 - 252637 == 10988)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (164525 - 455196 != -290670)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (279385 - 176910 == 102475)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (195246 - 32985 != 162262)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (198157 - 556533 == -358376)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (62751 - 216431 != -153679)
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

	// Token: 0x06003D99 RID: 15769 RVA: 0x007F1594 File Offset: 0x007EF794
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (129922 - 228267 != -98345)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (210314 - 121499 != 88816)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (97402 - 75184 != 22219)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (268294 - 209372 == 58922)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (190999 - 470689 == -279690)
						{
							int num3 = num;
							if (262591 - 389299 != -126707)
							{
								if (num3 == 1)
								{
									if (262551 - 373053 == -110502)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (186774 - 91895 == 94879)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (73211 - 403838 == -330627)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (163333 - 298960 != -135626)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (158150 - 22711 == 135439)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (197594 - 325517 != -127922)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (62369 - 272945 != -210575)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (160737 - 287796 == -127059)
										{
											this.StartCoroutine_Auto(this.RPC_jetPunch(vector, vector2, num2));
											if (285644 - 130324 == 155320)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (206312 - 157934 != 48379)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (298286 - 82693 == 215593)
										{
											this.RPC_jetPunch_hit(vector, vector2, num2);
											if (8896 - 424904 != -416007)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (159634 - 120986 == 38648)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (130004 - 84320 == 45684)
										{
											this.StartCoroutine_Auto(this.RPC_flameSweep(vector, vector2, num2));
											if (106133 - 174676 == -68543)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (33282 - 487467 == -454185)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (125182 - 156820 == -31638)
										{
											this.RPC_fireWall(vector, vector2, num2);
											if (6040 - 590589 != -584548)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (218732 - 309506 == -90774)
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

	// Token: 0x06003D9A RID: 15770 RVA: 0x007F1A0C File Offset: 0x007EFC0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (225011 - 171047 != 53965)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (195490 - 268796 != -73305)
			{
				float runSpeed = this.mChar.runSpeed;
				if (228697 - 545682 == -316985)
				{
					Vector3 a = default(Vector3);
					if (158356 - 289625 == -131269)
					{
						Vector3 vector = Vector3.zero;
						if (257464 - 190452 != 67013)
						{
							float num2 = (float)0;
							if (261820 - 365194 == -103374)
							{
								if (this.mChar.isMine)
								{
									if (193929 - 89137 != 104792)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (210088 - 576453 == -366364)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (33270 - 361319 != -328049)
										{
											continue;
										}
										a.y = (float)0;
										if (275871 - 545598 != -269727)
										{
											continue;
										}
										a = a.normalized;
										if (42774 - 323390 == -280615)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (140066 - 196590 == -56523)
										{
											continue;
										}
										vector = vector.normalized;
										if (159515 - 484691 == -325175)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (286073 - 320979 != -34906)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (205659 - 430994 == -225334)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (284299 - 398686 != -114387)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (110131 - 296232 == -186100)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (22397 - 363163 == -340765)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (86180 - 444972 != -358792)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (78470 - 209970 != -131500)
														{
															continue;
														}
														this.animation.Play("run");
														if (234098 - 123299 == 110800)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (181949 - 150945 != 31004)
														{
															continue;
														}
														goto IL_15D;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (209258 - 119693 != 89565)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (176407 - 406024 == -229616)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (198335 - 285138 == -86802)
											{
												continue;
											}
											num = (float)0;
											if (265314 - 419994 == -154679)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (184806 - 170163 != 14643)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (228968 - 458385 == -229416)
										{
											continue;
										}
									}
									IL_15D:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (6822 - 521466 == -514643)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (43327 - 419408 != -376081)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (45554 - 459991 != -414437)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (77937 - 357588 != -279651)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (7720 - 174411 == -166690)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (51272 - 358692 == -307419)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (47017 - 18591 != 28426)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (104099 - 320222 != -216123)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (209571 - 181954 != 27617)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (117559 - 286108 != -168549)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (94408 - 447634 == -353225)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (120528 - 170792 == -50263)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (53964 - 310609 == -256644)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (83416 - 34962 == 48455)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (130317 - 218100 != -87783)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (220404 - 269570 == -49165)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (156965 - 357460 == -200494)
												{
													continue;
												}
												num = (float)0;
												if (218602 - 417572 != -198970)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (215778 - 188533 == 27246)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (133633 - 465799 != -332166)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (179088 - 411796 == -232707)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (44167 - 96849 != -52682)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (261354 - 298776 == -37421)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (12116 - 588590 != -576474)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (67856 - 313247 == -245390)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (169089 - 345293 == -176203)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (133441 - 414872 == -281430)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (153692 - 10540 != 143152)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (170308 - 93078 != 77230)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (248965 - 542039 != -293074)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (36254 - 190590 == -154335)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (97361 - 118100 != -20739)
											{
												continue;
											}
											num = (float)0;
											if (159962 - 267218 != -107256)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (160023 - 8447 == 151577)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (252478 - 119991 == 132488)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (247225 - 342456 != -95231)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (188686 - 474773 == -286086)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (168440 - 122234 == 46206)
								{
									this.mChar.moveSpeed = num;
									if (214114 - 514264 != -300149)
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

	// Token: 0x06003D9B RID: 15771 RVA: 0x007F2570 File Offset: 0x007F0770
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (203575 - 480803 != -277227)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (1221 - 40508 == -39287)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (174752 - 458482 == -283730)
				{
					Vector3 vector = a - this.transform.position;
					if (200273 - 463509 == -263236)
					{
						Vector3 normalized = vector.normalized;
						if (65529 - 411437 == -345908)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (209677 - 518760 != -309082 && 145242 - 409965 != -264722)
							{
								if (gameObject)
								{
									if (136794 - 327910 != -191116)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (91288 - 525241 == -433952)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (14988 - 266477 == -251488)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (248152 - 330187 == -82034)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (180599 - 164265 != 16335)
								{
									if (UnityEngine.Random.Range(0, 100) < 65)
									{
										if (286229 - 330240 == -44011)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
											if (17517 - 14421 != 3097)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (182814 - 18623 == 164191)
												{
													this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
													if (67610 - 391936 != -324325)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_jetPunch(this.transform.position, normalized, 0));
										if (289328 - 158020 != 131309)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (58050 - 532910 != -474859)
											{
												this.ActionEvent("RPC_jetPunch", this.transform.position, normalized, 0);
												if (236011 - 417455 == -181444)
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

	// Token: 0x06003D9C RID: 15772 RVA: 0x007F28E0 File Offset: 0x007F0AE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (53076 - 193576 != -140499)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (71143 - 163812 == -92669)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (262570 - 278738 == -16168)
				{
					Vector3 vector = a - this.transform.position;
					if (179026 - 6593 != 172434)
					{
						Vector3 normalized = vector.normalized;
						if (231756 - 275524 != -43767)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (210639 - 245582 == -34943 && 251886 - 342907 != -91020)
							{
								if (gameObject)
								{
									if (27694 - 174058 != -146364)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (214863 - 413721 != -198858)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (50680 - 189802 != -139122)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (207608 - 227096 != -19488)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("cAttack") != (float)0)
								{
									break;
								}
								if (163344 - 292425 == -129081)
								{
									this.StartCoroutine_Auto(this.RPC_flameSweep(this.transform.position, normalized, 0));
									if (205686 - 140865 != 64822)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (142055 - 563805 != -421749)
										{
											this.ActionEvent("RPC_flameSweep", this.transform.position, normalized, 0);
											if (186587 - 84378 != 102210)
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

	// Token: 0x06003D9D RID: 15773 RVA: 0x007F2B98 File Offset: 0x007F0D98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003D9E RID: 15774 RVA: 0x007F2B9C File Offset: 0x007F0D9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FireBot.$RPC_nAttack$30687(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003D9F RID: 15775 RVA: 0x007F2BAC File Offset: 0x007F0DAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (285741 - 593109 != -307368)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (22284 - 170382 != -148097)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (265264 - 491582 == -226318)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit effect");
				if (299741 - 457648 != -157906)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003DA0 RID: 15776 RVA: 0x007F2C64 File Offset: 0x007F0E64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_jetPunch(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FireBot.$RPC_jetPunch$30701(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003DA1 RID: 15777 RVA: 0x007F2C74 File Offset: 0x007F0E74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_jetPunch_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (23661 - 451847 != -428185)
		{
		}
		for (;;)
		{
			if (this.jetPunch_hit)
			{
				if (241420 - 217600 == 23820)
				{
					UnityEngine.Object.Instantiate(this.jetPunch_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (124642 - 445233 == -320591)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing jetPunch_hit effect");
				if (31154 - 350162 != -319007)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003DA2 RID: 15778 RVA: 0x007F2D2C File Offset: 0x007F0F2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_flameSweep(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FireBot.$RPC_flameSweep$30717(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003DA3 RID: 15779 RVA: 0x007F2D3C File Offset: 0x007F0F3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_fireWall(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (278248 - 81165 != 197083)
		{
		}
		for (;;)
		{
			if (this.fireWall)
			{
				if (52256 - 158624 == -106367)
				{
					continue;
				}
				this.mChar.createEffect(this.fireWall, this.transform.position, Quaternion.LookRotation(hitDir));
				if (279371 - 298704 == -19332)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing fireWall effect");
				if (140444 - 422632 == -282187)
				{
					continue;
				}
			}
			if (this.e4XuSJgFcT >= Time.time)
			{
				break;
			}
			if (1316 - 417430 != -416113)
			{
				this.e4XuSJgFcT = Time.time + 0.3f;
				if (265105 - 73376 == 191729)
				{
					if (!this.fireWall_fx)
					{
						break;
					}
					if (97443 - 283023 != -185579)
					{
						this.audio.PlayOneShot(this.fireWall_fx);
						if (168712 - 548471 != -379758)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003DA4 RID: 15780 RVA: 0x007F2EB0 File Offset: 0x007F10B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createFireWall(Vector3 hitDir)
	{
		this.RPC_fireWall(this.transform.position, hitDir, 0);
		this.ActionEvent("RPC_fireWall", this.transform.position, hitDir, 0);
	}

	// Token: 0x06003DA5 RID: 15781 RVA: 0x007F2EE0 File Offset: 0x007F10E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new FireBot.$RPC_ko$30735(nArray, this).GetEnumerator();
	}

	// Token: 0x06003DA6 RID: 15782 RVA: 0x007F2EF0 File Offset: 0x007F10F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new FireBot.$RPC_dead$30742(nArray, this).GetEnumerator();
	}

	// Token: 0x06003DA7 RID: 15783 RVA: 0x007F2F00 File Offset: 0x007F1100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003DA8 RID: 15784 RVA: 0x007F2F04 File Offset: 0x007F1104
	internal static bool grvuTV5LIFCU7ujLqQ2u()
	{
		return true;
	}

	// Token: 0x06003DA9 RID: 15785 RVA: 0x007F2F08 File Offset: 0x007F1108
	internal static bool YFKEwh5LBcG6W4a7mrtS()
	{
		return false;
	}

	// Token: 0x04004AD5 RID: 19157
	public CharacterControl mChar;

	// Token: 0x04004AD6 RID: 19158
	public AudioClip footStep;

	// Token: 0x04004AD7 RID: 19159
	public AudioClip nAttack_fx;

	// Token: 0x04004AD8 RID: 19160
	public GameObject nAttack_hit;

	// Token: 0x04004AD9 RID: 19161
	public AudioClip jetPunch_fx;

	// Token: 0x04004ADA RID: 19162
	public GameObject jetPunch_hit;

	// Token: 0x04004ADB RID: 19163
	public GameObject flameSweep_l;

	// Token: 0x04004ADC RID: 19164
	public GameObject flameSweep_r;

	// Token: 0x04004ADD RID: 19165
	public GameObject fireWall;

	// Token: 0x04004ADE RID: 19166
	public AudioClip fireWall_fx;

	// Token: 0x04004ADF RID: 19167
	private float e4XuSJgFcT;

	// Token: 0x04004AE0 RID: 19168
	public GameObject deadEffect;

	// Token: 0x02000AE2 RID: 2786
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30687 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003DAA RID: 15786 RVA: 0x007F2F0C File Offset: 0x007F110C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30687(Vector3 mPos, Vector3 tDir, FireBot self_)
		{
			if (286926 - 293011 != -6085)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (180713 - 411897 == -231184)
				{
					base..ctor();
					if (175705 - 388103 == -212398)
					{
						this.$mPos$30698 = mPos;
						if (72042 - 492722 == -420680)
						{
							this.$tDir$30699 = tDir;
							if (145707 - 333938 == -188231)
							{
								this.$self_$30700 = self_;
								if (250617 - 57733 == 192884)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x007F2FE8 File Offset: 0x007F11E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireBot.$RPC_nAttack$30687.$(this.$mPos$30698, this.$tDir$30699, this.$self_$30700);
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x007F3004 File Offset: 0x007F1204
		internal static bool CwLBCH5LeZrtALerVQ2Z()
		{
			return true;
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x007F3008 File Offset: 0x007F1208
		internal static bool WI1Wyx5Lr3Wwhym0KTgC()
		{
			return false;
		}

		// Token: 0x04004AE1 RID: 19169
		internal Vector3 $mPos$30698;

		// Token: 0x04004AE2 RID: 19170
		internal Vector3 $tDir$30699;

		// Token: 0x04004AE3 RID: 19171
		internal FireBot $self_$30700;

		// Token: 0x02000AE3 RID: 2787
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003DAE RID: 15790 RVA: 0x007F300C File Offset: 0x007F120C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FireBot self_)
			{
				if (167236 - 362565 != -195328)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (66790 - 67631 == -841)
					{
						base..ctor();
						if (237932 - 15722 != 222211)
						{
							this.$mPos$30695 = mPos;
							if (109830 - 524271 == -414441)
							{
								this.$tDir$30696 = tDir;
								if (259895 - 161787 != 98109)
								{
									this.$self_$30697 = self_;
									if (36379 - 573454 != -537074)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003DAF RID: 15791 RVA: 0x007F30E8 File Offset: 0x007F12E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (213148 - 48340 != 164808)
				{
				}
				for (;;)
				{
					IL_1A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_E61;
					case 2:
						if (this.$self_$30697.mChar.actionState != "attack")
						{
							goto IL_C0F;
						}
						if (137928 - 540286 != -402358)
						{
							continue;
						}
						if (this.$self_$30697.mChar.myCommand != "nAttack")
						{
							if (154683 - 262464 != -107780)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$self_$30697.mChar.moveSpeed = (float)6;
							if (62422 - 183815 != -121393)
							{
								continue;
							}
							goto IL_77A;
						}
						break;
					case 3:
						if (this.$self_$30697.mChar.actionState != "attack")
						{
							goto IL_880;
						}
						if (251803 - 452437 != -200634)
						{
							continue;
						}
						if (this.$self_$30697.mChar.myCommand != "nAttack")
						{
							if (299777 - 492323 != -192546)
							{
								continue;
							}
							goto IL_880;
						}
						else
						{
							this.$hitLayer$30688 = 130816 - (1 << this.$self_$30697.gameObject.layer);
							if (252198 - 194415 == 57784)
							{
								continue;
							}
							this.$hitList$30689 = null;
							if (276771 - 355816 != -79045)
							{
								continue;
							}
							this.$hitPos$30690 = default(Vector3);
							if (61127 - 425067 == -363939)
							{
								continue;
							}
							if (!this.$self_$30697.mChar.isMine)
							{
								goto IL_985;
							}
							if (15217 - 271505 != -256288)
							{
								continue;
							}
							this.$hitList$30689 = Damage.FindRecTarget(this.$self_$30697.transform.position, this.$self_$30697.transform.forward, (float)2, (float)2, (float)4, (float)4, this.$hitLayer$30688);
							if (271462 - 18786 == 252677)
							{
								continue;
							}
							this.$$iterator$10638$30692 = UnityRuntimeServices.GetEnumerator(this.$hitList$30689);
							if (284383 - 136783 != 147600)
							{
								continue;
							}
							while (this.$$iterator$10638$30692.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10638$30692.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30691 = (GameObject)obj2;
								if (1714 - 339401 == -337686)
								{
									goto IL_1A;
								}
								if (this.$self_$30697.mChar.hit(1, this.$hitObject$30691, (int)(0.5f * (float)this.$self_$30697.mChar.atk), 4, 0, 0.3f * this.$self_$30697.transform.right) != 0)
								{
									if (137921 - 452570 == -314648)
									{
										goto IL_1A;
									}
									this.$hitPos$30690 = this.$hitObject$30691.collider.ClosestPointOnBounds(this.$self_$30697.transform.position + Vector3.up);
									if (126702 - 346866 == -220163)
									{
										goto IL_1A;
									}
									UnityRuntimeServices.Update(this.$$iterator$10638$30692, this.$hitObject$30691);
									if (24167 - 332762 != -308595)
									{
										goto IL_1A;
									}
									this.$self_$30697.RPC_nAttack_hit(this.$hitPos$30690, this.$self_$30697.transform.forward, 0);
									if (252879 - 148167 != 104712)
									{
										goto IL_1A;
									}
									this.$self_$30697.ActionEvent("RPC_nAttack_hit", this.$hitPos$30690, global::Math.vFlat(this.$hitPos$30690 - this.$self_$30697.transform.position).normalized, 0);
									if (23570 - 339474 == -315903)
									{
										goto IL_1A;
									}
									this.$self_$30697.mChar.sp = this.$self_$30697.mChar.sp + 1;
									if (82456 - 422739 == -340282)
									{
										goto IL_1A;
									}
								}
							}
							if (48593 - 317602 != -269009)
							{
								continue;
							}
							goto IL_985;
						}
						break;
					case 4:
						if (this.$self_$30697.mChar.actionState != "attack")
						{
							goto IL_6D8;
						}
						if (107882 - 485635 != -377753)
						{
							continue;
						}
						if (this.$self_$30697.mChar.myCommand != "nAttack")
						{
							if (3917 - 86802 != -82884)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							this.$self_$30697.mChar.moveSpeed = (float)0;
							if (110525 - 531956 != -421430)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$30697.mChar.actionState != "attack")
						{
							goto IL_D30;
						}
						if (158256 - 218140 != -59884)
						{
							continue;
						}
						if (this.$self_$30697.mChar.myCommand != "nAttack")
						{
							if (297172 - 93224 != 203949)
							{
								goto Block_63;
							}
							continue;
						}
						else
						{
							this.$self_$30697.mChar.moveSpeed = (float)6;
							if (211566 - 584963 != -373397)
							{
								continue;
							}
							goto IL_831;
						}
						break;
					case 6:
						if (this.$self_$30697.mChar.actionState != "attack")
						{
							goto IL_C3;
						}
						if (217939 - 164975 != 52964)
						{
							continue;
						}
						if (this.$self_$30697.mChar.myCommand != "nAttack")
						{
							if (197191 - 518825 != -321633)
							{
								goto Block_69;
							}
							continue;
						}
						else
						{
							this.$self_$30697.mChar.moveSpeed = (float)0;
							if (100973 - 503666 != -402693)
							{
								continue;
							}
							if (!this.$self_$30697.mChar.isMine)
							{
								goto IL_5CC;
							}
							if (35187 - 59511 != -24324)
							{
								continue;
							}
							this.$hitList$30689 = Damage.FindRecTarget(this.$self_$30697.transform.position, this.$self_$30697.transform.forward, (float)2, (float)2, (float)4, (float)4, this.$hitLayer$30688);
							if (164537 - 384953 != -220416)
							{
								continue;
							}
							this.$$iterator$10639$30694 = UnityRuntimeServices.GetEnumerator(this.$hitList$30689);
							if (164663 - 148207 != 16456)
							{
								continue;
							}
							while (this.$$iterator$10639$30694.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10639$30694.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$30693 = (GameObject)obj4;
								if (293736 - 253903 == 39834)
								{
									goto IL_1A;
								}
								if (this.$self_$30697.mChar.hit(1, this.$hitObject$30693, (int)(0.5f * (float)this.$self_$30697.mChar.atk), 4, 0, -0.3f * this.$self_$30697.transform.right) != 0)
								{
									if (242837 - 23592 != 219245)
									{
										goto IL_1A;
									}
									this.$hitPos$30690 = this.$hitObject$30693.collider.ClosestPointOnBounds(this.$self_$30697.transform.position + Vector3.up);
									if (184820 - 354810 != -169990)
									{
										goto IL_1A;
									}
									UnityRuntimeServices.Update(this.$$iterator$10639$30694, this.$hitObject$30693);
									if (88338 - 233220 == -144881)
									{
										goto IL_1A;
									}
									this.$self_$30697.RPC_nAttack_hit(this.$hitPos$30690, this.$self_$30697.transform.forward, 0);
									if (59083 - 280022 != -220939)
									{
										goto IL_1A;
									}
									this.$self_$30697.ActionEvent("RPC_nAttack_hit", this.$hitPos$30690, global::Math.vFlat(this.$hitPos$30690 - this.$self_$30697.transform.position).normalized, 0);
									if (129994 - 24260 == 105735)
									{
										goto IL_1A;
									}
									this.$self_$30697.mChar.sp = this.$self_$30697.mChar.sp + 1;
									if (113420 - 232606 != -119186)
									{
										goto IL_1A;
									}
								}
							}
							if (208646 - 364606 != -155960)
							{
								continue;
							}
							goto IL_5CC;
						}
						break;
					case 7:
						if (this.$self_$30697.mChar.actionState == "attack")
						{
							if (211592 - 219215 == -7622)
							{
								continue;
							}
							if (this.$self_$30697.mChar.myCommand == "nAttack")
							{
								if (162893 - 164153 == -1259)
								{
									continue;
								}
								this.$self_$30697.mChar.actionState = "standby";
								if (178956 - 53698 == 125259)
								{
									continue;
								}
								this.$self_$30697.mChar.actionTime = Time.time;
								if (242289 - 586309 == -344019)
								{
									continue;
								}
								this.$self_$30697.mChar.myCommand = "none";
								if (7613 - 453001 != -445388)
								{
									continue;
								}
								if (!this.$self_$30697.mChar.isMine)
								{
									if (277397 - 45312 == 232086)
									{
										continue;
									}
									this.$self_$30697.mChar.nPosition = this.$self_$30697.transform.position;
									if (225912 - 358698 != -132786)
									{
										continue;
									}
									this.$self_$30697.mChar.oPosition = this.$self_$30697.transform.position;
									if (293757 - 20 == 293738)
									{
										continue;
									}
									this.$self_$30697.mChar.nDirection = this.$self_$30697.transform.forward;
									if (153532 - 64846 != 88686)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (57676 - 410162 != -352485)
						{
							goto Block_70;
						}
						continue;
					default:
						if (298880 - 219467 != 79413)
						{
							continue;
						}
						break;
					}
					this.$self_$30697.mChar.actionState = "attack";
					if (108783 - 598809 != -490025)
					{
						this.$self_$30697.mChar.actionTime = Time.time;
						if (191779 - 221844 == -30065)
						{
							this.$self_$30697.mChar.myCommand = "nAttack";
							if (74964 - 399557 != -324592)
							{
								this.$self_$30697.mChar.addTimeOut("nAttack", (float)3);
								if (226609 - 146343 == 80266)
								{
									this.$self_$30697.transform.position = this.$mPos$30695;
									if (234795 - 575870 != -341074)
									{
										this.$self_$30697.transform.LookAt(this.$mPos$30695 + global::Math.vFlat(this.$tDir$30696));
										if (147322 - 250231 != -102908)
										{
											this.$self_$30697.animation.CrossFade("nAttack");
											if (257311 - 72567 != 184745)
											{
												this.$self_$30697.animation.wrapMode = WrapMode.Once;
												if (39981 - 248649 != -208667)
												{
													this.$self_$30697.mChar.vMovement = this.$self_$30697.transform.forward;
													if (261782 - 28677 == 233105)
													{
														this.$self_$30697.mChar.moveSpeed = (float)0;
														if (268084 - 79883 == 188201)
														{
															if (!this.$self_$30697.nAttack_fx)
															{
																goto IL_BC0;
															}
															if (171791 - 245589 == -73798)
															{
																this.$self_$30697.audio.PlayOneShot(this.$self_$30697.nAttack_fx);
																if (182377 - 474648 == -292271)
																{
																	goto IL_BC0;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_C3:
				Block_15:
				Block_36:
				goto IL_6D8;
				IL_5CC:
				return this.Yield(7, new WaitForSeconds(0.3f));
				IL_6D8:
				goto IL_E61;
				Block_42:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_77A:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_831:
				return this.Yield(6, new WaitForSeconds(0.1f));
				IL_880:
				goto IL_E61;
				IL_985:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_63:
				Block_69:
				Block_70:
				goto IL_E61;
				IL_BC0:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_C0F:
				IL_D30:
				IL_E61:
				return false;
			}

			// Token: 0x06003DB0 RID: 15792 RVA: 0x007F3F68 File Offset: 0x007F2168
			internal static bool w0vfWU5LjbEOWXiHgK2c()
			{
				return true;
			}

			// Token: 0x06003DB1 RID: 15793 RVA: 0x007F3F6C File Offset: 0x007F216C
			internal static bool y6fdDj5LhvpocmjxGk8F()
			{
				return false;
			}

			// Token: 0x04004AE4 RID: 19172
			internal int $hitLayer$30688;

			// Token: 0x04004AE5 RID: 19173
			internal UnityScript.Lang.Array $hitList$30689;

			// Token: 0x04004AE6 RID: 19174
			internal Vector3 $hitPos$30690;

			// Token: 0x04004AE7 RID: 19175
			internal GameObject $hitObject$30691;

			// Token: 0x04004AE8 RID: 19176
			internal IEnumerator $$iterator$10638$30692;

			// Token: 0x04004AE9 RID: 19177
			internal GameObject $hitObject$30693;

			// Token: 0x04004AEA RID: 19178
			internal IEnumerator $$iterator$10639$30694;

			// Token: 0x04004AEB RID: 19179
			internal Vector3 $mPos$30695;

			// Token: 0x04004AEC RID: 19180
			internal Vector3 $tDir$30696;

			// Token: 0x04004AED RID: 19181
			internal FireBot $self_$30697;
		}
	}

	// Token: 0x02000AE4 RID: 2788
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_jetPunch$30701 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003DB2 RID: 15794 RVA: 0x007F3F70 File Offset: 0x007F2170
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_jetPunch$30701(Vector3 mPos, Vector3 tDir, FireBot self_)
		{
			if (283014 - 284147 != -1132)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (133193 - 331879 != -198685)
				{
					base..ctor();
					if (110572 - 251958 != -141385)
					{
						this.$mPos$30714 = mPos;
						if (119943 - 528818 != -408874)
						{
							this.$tDir$30715 = tDir;
							if (177802 - 149349 == 28453)
							{
								this.$self_$30716 = self_;
								if (93906 - 30951 == 62955)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x007F404C File Offset: 0x007F224C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireBot.$RPC_jetPunch$30701.$(this.$mPos$30714, this.$tDir$30715, this.$self_$30716);
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x007F4068 File Offset: 0x007F2268
		internal static bool DlnUCa5LsXXYtIVoWyKx()
		{
			return true;
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x007F406C File Offset: 0x007F226C
		internal static bool xIRIh45L9e3TtxV5smdZ()
		{
			return false;
		}

		// Token: 0x04004AEE RID: 19182
		internal Vector3 $mPos$30714;

		// Token: 0x04004AEF RID: 19183
		internal Vector3 $tDir$30715;

		// Token: 0x04004AF0 RID: 19184
		internal FireBot $self_$30716;

		// Token: 0x02000AE5 RID: 2789
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003DB6 RID: 15798 RVA: 0x007F4070 File Offset: 0x007F2270
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FireBot self_)
			{
				if (62464 - 246219 != -183755)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (110936 - 16499 == 94437)
					{
						base..ctor();
						if (276570 - 525815 != -249244)
						{
							this.$mPos$30711 = mPos;
							if (88382 - 398302 == -309920)
							{
								this.$tDir$30712 = tDir;
								if (261511 - 484283 == -222772)
								{
									this.$self_$30713 = self_;
									if (110229 - 454334 == -344105)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003DB7 RID: 15799 RVA: 0x007F414C File Offset: 0x007F234C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (96308 - 116144 != -19835)
				{
				}
				for (;;)
				{
					IL_50D:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1201;
					case 2:
						if (this.$self_$30713.mChar.actionState != "attack")
						{
							goto IL_849;
						}
						if (255291 - 517724 == -262432)
						{
							continue;
						}
						if (this.$self_$30713.mChar.myCommand != "jetPunch")
						{
							if (124172 - 289718 != -165545)
							{
								goto Block_80;
							}
							continue;
						}
						else
						{
							this.$self_$30713.mChar.moveSpeed = (float)8;
							if (112037 - 357447 != -245410)
							{
								continue;
							}
							goto IL_C90;
						}
						break;
					case 3:
						if (this.$self_$30713.mChar.actionState != "attack")
						{
							goto IL_BA8;
						}
						if (298451 - 282928 == 15524)
						{
							continue;
						}
						if (this.$self_$30713.mChar.myCommand != "jetPunch")
						{
							if (143936 - 546391 != -402455)
							{
								continue;
							}
							goto IL_BA8;
						}
						else
						{
							this.$self_$30713.mChar.moveSpeed = (float)0;
							if (94548 - 412893 == -318344)
							{
								continue;
							}
							this.$hitLayer$30702 = 130816 - (1 << this.$self_$30713.gameObject.layer);
							if (44415 - 16730 == 27686)
							{
								continue;
							}
							this.$hitList$30703 = null;
							if (200242 - 432342 != -232100)
							{
								continue;
							}
							this.$hitPos$30704 = default(Vector3);
							if (132308 - 89269 != 43039)
							{
								continue;
							}
							if (!this.$self_$30713.mChar.isMine)
							{
								goto IL_587;
							}
							if (245421 - 362973 == -117551)
							{
								continue;
							}
							this.$hitList$30703 = Damage.FindRecTarget(this.$self_$30713.transform.position, this.$self_$30713.transform.forward, (float)2, (float)2, (float)3, (float)3, this.$hitLayer$30702);
							if (173575 - 106036 == 67540)
							{
								continue;
							}
							this.$$iterator$10640$30706 = UnityRuntimeServices.GetEnumerator(this.$hitList$30703);
							if (288448 - 342577 == -54128)
							{
								continue;
							}
							while (this.$$iterator$10640$30706.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10640$30706.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30705 = (GameObject)obj2;
								if (279024 - 136424 == 142601)
								{
									goto IL_50D;
								}
								if (this.$self_$30713.mChar.hit(1, this.$hitObject$30705, this.$self_$30713.mChar.atk, 7, 0, (float)2 * this.$self_$30713.transform.forward) != 0)
								{
									if (47517 - 19923 != 27594)
									{
										goto IL_50D;
									}
									this.$hitPos$30704 = this.$hitObject$30705.collider.ClosestPointOnBounds(this.$self_$30713.transform.position + Vector3.up);
									if (224602 - 572183 != -347581)
									{
										goto IL_50D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10640$30706, this.$hitObject$30705);
									if (48075 - 524990 != -476915)
									{
										goto IL_50D;
									}
									this.$self_$30713.RPC_jetPunch_hit(this.$hitPos$30704, this.$self_$30713.transform.forward, 0);
									if (97595 - 169529 == -71933)
									{
										goto IL_50D;
									}
									this.$self_$30713.ActionEvent("RPC_jetPunch_hit", this.$hitPos$30704, global::Math.vFlat(this.$hitPos$30704 - this.$self_$30713.transform.position).normalized, 0);
									if (110016 - 113404 == -3387)
									{
										goto IL_50D;
									}
									this.$self_$30713.mChar.sp = this.$self_$30713.mChar.sp + 1;
									if (11793 - 218104 != -206311)
									{
										goto IL_50D;
									}
								}
							}
							if (225495 - 171370 != 54126)
							{
								goto Block_61;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$30713.mChar.actionState != "attack")
						{
							goto IL_556;
						}
						if (142472 - 507343 == -364870)
						{
							continue;
						}
						if (this.$self_$30713.mChar.myCommand != "jetPunch")
						{
							if (198545 - 178949 != 19597)
							{
								goto Block_106;
							}
							continue;
						}
						else
						{
							this.$self_$30713.mChar.moveSpeed = (float)5;
							if (130496 - 378244 != -247747)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$30713.mChar.actionState != "attack")
						{
							goto IL_DAE;
						}
						if (159092 - 119294 == 39799)
						{
							continue;
						}
						if (this.$self_$30713.mChar.myCommand != "jetPunch")
						{
							if (168129 - 60132 != 107997)
							{
								continue;
							}
							goto IL_DAE;
						}
						else
						{
							this.$self_$30713.mChar.moveSpeed = (float)0;
							if (121781 - 107117 == 14665)
							{
								continue;
							}
							if (!this.$self_$30713.mChar.isMine)
							{
								goto IL_436;
							}
							if (49620 - 54748 == -5127)
							{
								continue;
							}
							this.$hitList$30703 = Damage.FindRecTarget(this.$self_$30713.transform.position, this.$self_$30713.transform.forward, (float)2, (float)2, (float)4, (float)3, this.$hitLayer$30702);
							if (92093 - 506515 != -414422)
							{
								continue;
							}
							this.$$iterator$10641$30708 = UnityRuntimeServices.GetEnumerator(this.$hitList$30703);
							if (73612 - 452584 == -378971)
							{
								continue;
							}
							while (this.$$iterator$10641$30708.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10641$30708.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$30707 = (GameObject)obj4;
								if (124390 - 496331 != -371941)
								{
									goto IL_50D;
								}
								if (this.$self_$30713.mChar.hit(1, this.$hitObject$30707, (int)(0.6f * (float)this.$self_$30713.mChar.atk), 3, 0, this.$self_$30713.transform.forward) != 0)
								{
									if (213402 - 566949 != -353547)
									{
										goto IL_50D;
									}
									this.$hitPos$30704 = this.$hitObject$30707.collider.ClosestPointOnBounds(this.$self_$30713.transform.position + Vector3.up);
									if (129719 - 32553 == 97167)
									{
										goto IL_50D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10641$30708, this.$hitObject$30707);
									if (242433 - 103540 != 138893)
									{
										goto IL_50D;
									}
									this.$self_$30713.RPC_nAttack_hit(this.$hitPos$30704, this.$self_$30713.transform.forward, 0);
									if (101609 - 364032 == -262422)
									{
										goto IL_50D;
									}
									this.$self_$30713.ActionEvent("RPC_nAttack_hit", this.$hitPos$30704, global::Math.vFlat(this.$hitPos$30704 - this.$self_$30713.transform.position).normalized, 0);
									if (233923 - 129340 != 104583)
									{
										goto IL_50D;
									}
									this.$self_$30713.mChar.sp = this.$self_$30713.mChar.sp + 1;
									if (149577 - 195169 == -45591)
									{
										goto IL_50D;
									}
								}
							}
							if (132398 - 42482 != 89917)
							{
								goto Block_90;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$30713.mChar.actionState != "attack")
						{
							goto IL_818;
						}
						if (278021 - 174210 == 103812)
						{
							continue;
						}
						if (this.$self_$30713.mChar.myCommand != "jetPunch")
						{
							if (159319 - 374498 != -215178)
							{
								goto Block_75;
							}
							continue;
						}
						else
						{
							this.$self_$30713.mChar.moveSpeed = (float)5;
							if (269108 - 594400 != -325291)
							{
								goto Block_51;
							}
							continue;
						}
						break;
					case 7:
						if (this.$self_$30713.mChar.actionState != "attack")
						{
							goto IL_746;
						}
						if (154799 - 292411 == -137611)
						{
							continue;
						}
						if (this.$self_$30713.mChar.myCommand != "jetPunch")
						{
							if (181357 - 516328 != -334970)
							{
								goto Block_99;
							}
							continue;
						}
						else
						{
							this.$self_$30713.mChar.moveSpeed = (float)0;
							if (192592 - 112196 != 80396)
							{
								continue;
							}
							if (!this.$self_$30713.mChar.isMine)
							{
								goto IL_161;
							}
							if (88335 - 101811 != -13476)
							{
								continue;
							}
							this.$hitList$30703 = Damage.FindRecTarget(this.$self_$30713.transform.position, this.$self_$30713.transform.forward, (float)2, (float)2, (float)4, (float)3, this.$hitLayer$30702);
							if (77664 - 2541 != 75123)
							{
								continue;
							}
							this.$$iterator$10642$30710 = UnityRuntimeServices.GetEnumerator(this.$hitList$30703);
							if (277909 - 370942 != -93033)
							{
								continue;
							}
							while (this.$$iterator$10642$30710.MoveNext())
							{
								object obj6;
								object obj5 = obj6 = this.$$iterator$10642$30710.Current;
								if (!(obj5 is GameObject))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
								}
								this.$hitObject$30709 = (GameObject)obj6;
								if (54270 - 571739 == -517468)
								{
									goto IL_50D;
								}
								if (this.$self_$30713.mChar.hit(1, this.$hitObject$30709, (int)(0.6f * (float)this.$self_$30713.mChar.atk), 3, 0, this.$self_$30713.transform.forward) != 0)
								{
									if (250855 - 310458 == -59602)
									{
										goto IL_50D;
									}
									this.$hitPos$30704 = this.$hitObject$30709.collider.ClosestPointOnBounds(this.$self_$30713.transform.position + Vector3.up);
									if (31058 - 185845 != -154787)
									{
										goto IL_50D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10642$30710, this.$hitObject$30709);
									if (97778 - 186820 == -89041)
									{
										goto IL_50D;
									}
									this.$self_$30713.RPC_nAttack_hit(this.$hitPos$30704, this.$self_$30713.transform.forward, 0);
									if (123880 - 437168 == -313287)
									{
										goto IL_50D;
									}
									this.$self_$30713.ActionEvent("RPC_nAttack_hit", this.$hitPos$30704, global::Math.vFlat(this.$hitPos$30704 - this.$self_$30713.transform.position).normalized, 0);
									if (294328 - 83891 == 210438)
									{
										goto IL_50D;
									}
									this.$self_$30713.mChar.sp = this.$self_$30713.mChar.sp + 1;
									if (263424 - 194928 != 68496)
									{
										goto IL_50D;
									}
								}
							}
							if (285063 - 156435 != 128629)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 8:
						if (this.$self_$30713.mChar.actionState == "attack")
						{
							if (108921 - 389711 == -280789)
							{
								continue;
							}
							if (this.$self_$30713.mChar.myCommand == "jetPunch")
							{
								if (226091 - 37423 == 188669)
								{
									continue;
								}
								this.$self_$30713.mChar.actionState = "standby";
								if (230598 - 278310 != -47712)
								{
									continue;
								}
								this.$self_$30713.mChar.actionTime = Time.time;
								if (28697 - 550859 != -522162)
								{
									continue;
								}
								this.$self_$30713.mChar.myCommand = "none";
								if (208082 - 151766 == 56317)
								{
									continue;
								}
								if (!this.$self_$30713.mChar.isMine)
								{
									if (225692 - 566967 != -341275)
									{
										continue;
									}
									this.$self_$30713.mChar.nPosition = this.$self_$30713.transform.position;
									if (238854 - 416036 != -177182)
									{
										continue;
									}
									this.$self_$30713.mChar.oPosition = this.$self_$30713.transform.position;
									if (70372 - 233309 == -162936)
									{
										continue;
									}
									this.$self_$30713.mChar.nDirection = this.$self_$30713.transform.forward;
									if (207050 - 538354 != -331304)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (20868 - 506148 != -485280)
						{
							continue;
						}
						goto IL_1201;
					default:
						if (94438 - 273498 != -179060)
						{
							continue;
						}
						break;
					}
					this.$self_$30713.mChar.actionState = "attack";
					if (259356 - 146496 != 112861)
					{
						this.$self_$30713.mChar.actionTime = Time.time;
						if (85490 - 68184 == 17306)
						{
							this.$self_$30713.mChar.myCommand = "jetPunch";
							if (254216 - 37435 != 216782)
							{
								this.$self_$30713.mChar.addTimeOut("jetPunch", (float)3);
								if (155001 - 110056 == 44945)
								{
									this.$self_$30713.transform.position = this.$mPos$30711;
									if (244192 - 262531 == -18339)
									{
										this.$self_$30713.transform.LookAt(this.$mPos$30711 + global::Math.vFlat(this.$tDir$30712));
										if (258506 - 21960 == 236546)
										{
											this.$self_$30713.animation.CrossFade("jetPunch");
											if (82491 - 90134 != -7642)
											{
												this.$self_$30713.animation.wrapMode = WrapMode.Once;
												if (170104 - 569343 == -399239)
												{
													this.$self_$30713.mChar.vMovement = this.$self_$30713.transform.forward;
													if (128273 - 458092 != -329818)
													{
														this.$self_$30713.mChar.moveSpeed = (float)0;
														if (219730 - 284954 != -65223)
														{
															if (!this.$self_$30713.jetPunch_fx)
															{
																goto IL_917;
															}
															if (272422 - 200825 != 71598)
															{
																this.$self_$30713.audio.PlayOneShot(this.$self_$30713.jetPunch_fx);
																if (31365 - 183869 == -152504)
																{
																	goto IL_917;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_161:
				return this.Yield(8, new WaitForSeconds(0.3f));
				IL_436:
				return this.Yield(6, new WaitForSeconds(0.2f));
				IL_556:
				goto IL_1201;
				Block_32:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_587:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_39:
				goto IL_161;
				IL_746:
				IL_818:
				goto IL_1201;
				Block_51:
				return this.Yield(7, new WaitForSeconds(0.1f));
				IL_849:
				goto IL_1201;
				IL_917:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_61:
				goto IL_587;
				IL_BA8:
				Block_75:
				goto IL_818;
				IL_C90:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_80:
				IL_DAE:
				goto IL_1201;
				Block_90:
				goto IL_436;
				Block_99:
				Block_106:
				IL_1201:
				return false;
			}

			// Token: 0x06003DB8 RID: 15800 RVA: 0x007F536C File Offset: 0x007F356C
			internal static bool rEg5A25L1Z3gV2hgTGDA()
			{
				return true;
			}

			// Token: 0x06003DB9 RID: 15801 RVA: 0x007F5370 File Offset: 0x007F3570
			internal static bool TfVXeV5L4t3VVXyPoWJC()
			{
				return false;
			}

			// Token: 0x04004AF1 RID: 19185
			internal int $hitLayer$30702;

			// Token: 0x04004AF2 RID: 19186
			internal UnityScript.Lang.Array $hitList$30703;

			// Token: 0x04004AF3 RID: 19187
			internal Vector3 $hitPos$30704;

			// Token: 0x04004AF4 RID: 19188
			internal GameObject $hitObject$30705;

			// Token: 0x04004AF5 RID: 19189
			internal IEnumerator $$iterator$10640$30706;

			// Token: 0x04004AF6 RID: 19190
			internal GameObject $hitObject$30707;

			// Token: 0x04004AF7 RID: 19191
			internal IEnumerator $$iterator$10641$30708;

			// Token: 0x04004AF8 RID: 19192
			internal GameObject $hitObject$30709;

			// Token: 0x04004AF9 RID: 19193
			internal IEnumerator $$iterator$10642$30710;

			// Token: 0x04004AFA RID: 19194
			internal Vector3 $mPos$30711;

			// Token: 0x04004AFB RID: 19195
			internal Vector3 $tDir$30712;

			// Token: 0x04004AFC RID: 19196
			internal FireBot $self_$30713;
		}
	}

	// Token: 0x02000AE6 RID: 2790
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_flameSweep$30717 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003DBA RID: 15802 RVA: 0x007F5374 File Offset: 0x007F3574
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_flameSweep$30717(Vector3 mPos, Vector3 tDir, FireBot self_)
		{
			if (144682 - 33363 != 111320)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (174821 - 215698 == -40877)
				{
					base..ctor();
					if (126191 - 330857 == -204666)
					{
						this.$mPos$30732 = mPos;
						if (184819 - 333915 == -149096)
						{
							this.$tDir$30733 = tDir;
							if (171812 - 443946 != -272133)
							{
								this.$self_$30734 = self_;
								if (263364 - 362094 == -98730)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x007F5450 File Offset: 0x007F3650
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireBot.$RPC_flameSweep$30717.$(this.$mPos$30732, this.$tDir$30733, this.$self_$30734);
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x007F546C File Offset: 0x007F366C
		internal static bool u7CLG05LzDYQRQ8TSesD()
		{
			return true;
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x007F5470 File Offset: 0x007F3670
		internal static bool H4c6Qm5OacrsQkqYHpKN()
		{
			return false;
		}

		// Token: 0x04004AFD RID: 19197
		internal Vector3 $mPos$30732;

		// Token: 0x04004AFE RID: 19198
		internal Vector3 $tDir$30733;

		// Token: 0x04004AFF RID: 19199
		internal FireBot $self_$30734;

		// Token: 0x02000AE7 RID: 2791
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003DBE RID: 15806 RVA: 0x007F5474 File Offset: 0x007F3674
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FireBot self_)
			{
				if (254106 - 243020 != 11087)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (163213 - 527854 != -364640)
					{
						base..ctor();
						if (122485 - 503382 != -380896)
						{
							this.$mPos$30729 = mPos;
							if (54170 - 256762 == -202592)
							{
								this.$tDir$30730 = tDir;
								if (92089 - 407646 == -315557)
								{
									this.$self_$30731 = self_;
									if (124521 - 336857 == -212336)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003DBF RID: 15807 RVA: 0x007F5550 File Offset: 0x007F3750
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (167904 - 266388 != -98484)
				{
				}
				for (;;)
				{
					IL_404:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_EEA;
					case 2:
						if (this.$self_$30731.mChar.actionState != "attack")
						{
							goto IL_535;
						}
						if (282003 - 320897 != -38894)
						{
							continue;
						}
						if (this.$self_$30731.mChar.myCommand != "flameSweep")
						{
							if (218542 - 259864 != -41321)
							{
								goto Block_40;
							}
							continue;
						}
						else
						{
							if (this.$self_$30731.flameSweep_l)
							{
								if (147838 - 110570 != 37268)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$30731.flameSweep_l, this.$self_$30731.transform.position, this.$self_$30731.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
								if (92914 - 33044 == 59871)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing flameSweep_l effect");
								if (244508 - 496409 == -251900)
								{
									continue;
								}
							}
							this.$hitLayer$30718 = 130816 - (1 << this.$self_$30731.gameObject.layer);
							if (36162 - 529250 == -493087)
							{
								continue;
							}
							this.$hitList$30719 = null;
							if (115707 - 382681 == -266973)
							{
								continue;
							}
							this.$hitPos$30720 = default(Vector3);
							if (94565 - 503116 != -408551)
							{
								continue;
							}
							this.$hitVector$30721 = default(Vector3);
							if (13795 - 475976 == -462180)
							{
								continue;
							}
							this.$hitChar$30722 = null;
							if (83040 - 227527 == -144486)
							{
								continue;
							}
							this.$i$30723 = 0;
							if (299058 - 213449 != 85610)
							{
								goto IL_AD2;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30731.mChar.actionState != "attack")
						{
							goto IL_2F6;
						}
						if (223516 - 46751 == 176766)
						{
							continue;
						}
						if (this.$self_$30731.mChar.myCommand != "flameSweep")
						{
							if (135311 - 43226 != 92085)
							{
								continue;
							}
							goto IL_2F6;
						}
						else
						{
							this.$i$30723++;
							if (6722 - 479195 != -472473)
							{
								continue;
							}
							goto IL_AD2;
						}
						break;
					case 4:
						if (this.$self_$30731.mChar.actionState != "attack")
						{
							goto IL_6A6;
						}
						if (264251 - 86006 == 178246)
						{
							continue;
						}
						if (this.$self_$30731.mChar.myCommand != "flameSweep")
						{
							if (203299 - 433270 != -229970)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							if (this.$self_$30731.flameSweep_r)
							{
								if (119263 - 43975 == 75289)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$30731.flameSweep_r, this.$self_$30731.transform.position, this.$self_$30731.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
								if (255923 - 349661 == -93737)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing flameSweep_r effect");
								if (82132 - 314586 != -232454)
								{
									continue;
								}
							}
							this.$j$30726 = 0;
							if (149035 - 320022 != -170987)
							{
								continue;
							}
							goto IL_B1E;
						}
						break;
					case 5:
						if (this.$self_$30731.mChar.actionState != "attack")
						{
							goto IL_200;
						}
						if (139499 - 50186 == 89314)
						{
							continue;
						}
						if (this.$self_$30731.mChar.myCommand != "flameSweep")
						{
							if (240764 - 553040 != -312275)
							{
								goto Block_90;
							}
							continue;
						}
						else
						{
							this.$j$30726++;
							if (68852 - 246501 != -177649)
							{
								continue;
							}
							goto IL_B1E;
						}
						break;
					default:
						if (297984 - 175470 == 122515)
						{
							continue;
						}
						break;
					}
					this.$self_$30731.mChar.actionState = "attack";
					if (253521 - 65559 == 187963)
					{
						continue;
					}
					this.$self_$30731.mChar.actionTime = Time.time;
					if (267451 - 319203 != -51752)
					{
						continue;
					}
					this.$self_$30731.mChar.myCommand = "flameSweep";
					if (234545 - 528753 == -294207)
					{
						continue;
					}
					this.$self_$30731.mChar.addTimeOut("flameSweep", (float)12);
					if (110156 - 448972 != -338816)
					{
						continue;
					}
					this.$self_$30731.transform.position = this.$mPos$30729;
					if (231160 - 363405 != -132245)
					{
						continue;
					}
					this.$self_$30731.transform.LookAt(this.$mPos$30729 + global::Math.vFlat(this.$tDir$30730));
					if (58765 - 588529 == -529763)
					{
						continue;
					}
					this.$self_$30731.animation.CrossFade("flameSweep");
					if (258990 - 457525 == -198534)
					{
						continue;
					}
					this.$self_$30731.animation.wrapMode = WrapMode.Once;
					if (117176 - 425520 != -308344)
					{
						continue;
					}
					this.$self_$30731.mChar.vMovement = this.$self_$30731.transform.forward;
					if (174934 - 63568 != 111366)
					{
						continue;
					}
					this.$self_$30731.mChar.moveSpeed = (float)0;
					if (201537 - 20127 != 181410)
					{
						continue;
					}
					goto IL_E61;
					IL_B1E:
					if (this.$j$30726 > 5)
					{
						if (159856 - 425311 == -265454)
						{
							continue;
						}
						if (this.$self_$30731.mChar.actionState == "attack")
						{
							if (110778 - 374148 != -263370)
							{
								continue;
							}
							if (this.$self_$30731.mChar.myCommand == "flameSweep")
							{
								if (231812 - 385822 != -154010)
								{
									continue;
								}
								this.$self_$30731.mChar.actionState = "standby";
								if (164108 - 475498 == -311389)
								{
									continue;
								}
								this.$self_$30731.mChar.actionTime = Time.time;
								if (298649 - 83773 != 214876)
								{
									continue;
								}
								this.$self_$30731.mChar.myCommand = "none";
								if (141562 - 183479 != -41917)
								{
									continue;
								}
								if (!this.$self_$30731.mChar.isMine)
								{
									if (219235 - 386091 != -166856)
									{
										continue;
									}
									this.$self_$30731.mChar.nPosition = this.$self_$30731.transform.position;
									if (252943 - 471261 != -218318)
									{
										continue;
									}
									this.$self_$30731.mChar.oPosition = this.$self_$30731.transform.position;
									if (20192 - 12804 != 7388)
									{
										continue;
									}
									this.$self_$30731.mChar.nDirection = this.$self_$30731.transform.forward;
									if (58887 - 587661 == -528773)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (128260 - 220954 != -92693)
						{
							goto Block_88;
						}
						continue;
					}
					else
					{
						if (!this.$self_$30731.mChar.isMine)
						{
							goto IL_9CB;
						}
						if (174034 - 303816 != -129782)
						{
							continue;
						}
						this.$hitVector$30721 = global::Math.rotateH(this.$self_$30731.transform.forward, (float)(-30 * this.$j$30726));
						if (196795 - 93694 == 103102)
						{
							continue;
						}
						this.$hitList$30719 = Damage.FindRecTarget(this.$self_$30731.transform.position + (float)3 * this.$hitVector$30721, this.$hitVector$30721, (float)3, (float)8, (float)15, (float)4, this.$hitLayer$30718);
						if (58648 - 528260 != -469612)
						{
							continue;
						}
						this.$$iterator$10644$30728 = UnityRuntimeServices.GetEnumerator(this.$hitList$30719);
						if (107041 - 128333 == -21291)
						{
							continue;
						}
						while (this.$$iterator$10644$30728.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10644$30728.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$30727 = (GameObject)obj2;
							if (194663 - 154627 != 40036)
							{
								goto IL_404;
							}
							if (this.$self_$30731.mChar.hit(1, this.$hitObject$30727, this.$self_$30731.mChar.talAdjust(50), 1, 0, Vector3.zero) != 0)
							{
								if (69341 - 290606 == -221264)
								{
									goto IL_404;
								}
								this.$hitChar$30722 = (CharacterControl)this.$hitObject$30727.GetComponent(typeof(CharacterControl));
								if (178212 - 594600 != -416388)
								{
									goto IL_404;
								}
								UnityRuntimeServices.Update(this.$$iterator$10644$30728, this.$hitObject$30727);
								if (236581 - 469151 == -232569)
								{
									goto IL_404;
								}
								if (this.$hitChar$30722)
								{
									if (17629 - 469819 != -452190)
									{
										goto IL_404;
									}
									this.$hitChar$30722.RPC_AddStatus("burn", 2, Damage.getDebuff((float)6, this.$self_$30731.mChar.cha, this.$hitChar$30722.cha), 0, this.$self_$30731.mChar.ActorNr);
									if (26893 - 150031 == -123137)
									{
										goto IL_404;
									}
								}
							}
						}
						if (227728 - 157743 != 69986)
						{
							goto Block_19;
						}
						continue;
					}
					IL_AD2:
					if (this.$i$30723 > 5)
					{
						if (157215 - 239191 != -81975)
						{
							goto Block_68;
						}
					}
					else
					{
						if (!this.$self_$30731.mChar.isMine)
						{
							break;
						}
						if (222544 - 489692 == -267148)
						{
							this.$hitVector$30721 = global::Math.rotateH(this.$self_$30731.transform.forward, (float)(20 * this.$i$30723));
							if (209977 - 119905 != 90073)
							{
								this.$hitList$30719 = Damage.FindRecTarget(this.$self_$30731.transform.position + (float)3 * this.$hitVector$30721, this.$hitVector$30721, (float)3, (float)8, (float)12, (float)4, this.$hitLayer$30718);
								if (229871 - 9480 == 220391)
								{
									this.$$iterator$10643$30725 = UnityRuntimeServices.GetEnumerator(this.$hitList$30719);
									if (215685 - 145063 != 70623)
									{
										while (this.$$iterator$10643$30725.MoveNext())
										{
											object obj4;
											object obj3 = obj4 = this.$$iterator$10643$30725.Current;
											if (!(obj3 is GameObject))
											{
												obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
											}
											this.$hitObject$30724 = (GameObject)obj4;
											if (179773 - 170133 == 9641)
											{
												goto IL_404;
											}
											if (this.$self_$30731.mChar.hit(1, this.$hitObject$30724, this.$self_$30731.mChar.talAdjust(50), 1, 0, Vector3.zero) != 0)
											{
												if (138151 - 405883 == -267731)
												{
													goto IL_404;
												}
												this.$hitChar$30722 = (CharacterControl)this.$hitObject$30724.GetComponent(typeof(CharacterControl));
												if (174461 - 595167 == -420705)
												{
													goto IL_404;
												}
												UnityRuntimeServices.Update(this.$$iterator$10643$30725, this.$hitObject$30724);
												if (179642 - 564359 == -384716)
												{
													goto IL_404;
												}
												if (this.$hitChar$30722)
												{
													if (203476 - 259331 != -55855)
													{
														goto IL_404;
													}
													this.$hitChar$30722.RPC_AddStatus("burn", 2, Damage.getDebuff((float)6, this.$self_$30731.mChar.cha, this.$hitChar$30722.cha), 0, this.$self_$30731.mChar.ActorNr);
													if (295621 - 150323 != 145298)
													{
														goto IL_404;
													}
												}
											}
										}
										if (175520 - 272613 != -97092)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				goto IL_CD6;
				IL_200:
				IL_2F6:
				goto IL_EEA;
				Block_19:
				goto IL_9CB;
				IL_535:
				Block_36:
				Block_40:
				IL_6A6:
				goto IL_EEA;
				IL_9CB:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_68:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_CD6:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_88:
				Block_90:
				goto IL_200;
				IL_E61:
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_EEA:
				return false;
			}

			// Token: 0x06003DC0 RID: 15808 RVA: 0x007F645C File Offset: 0x007F465C
			internal static bool BVhEd85O5jO6fhOawEU1()
			{
				return true;
			}

			// Token: 0x06003DC1 RID: 15809 RVA: 0x007F6460 File Offset: 0x007F4660
			internal static bool pJPeXb5Opt8cE08rpEix()
			{
				return false;
			}

			// Token: 0x04004B00 RID: 19200
			internal int $hitLayer$30718;

			// Token: 0x04004B01 RID: 19201
			internal UnityScript.Lang.Array $hitList$30719;

			// Token: 0x04004B02 RID: 19202
			internal Vector3 $hitPos$30720;

			// Token: 0x04004B03 RID: 19203
			internal Vector3 $hitVector$30721;

			// Token: 0x04004B04 RID: 19204
			internal CharacterControl $hitChar$30722;

			// Token: 0x04004B05 RID: 19205
			internal int $i$30723;

			// Token: 0x04004B06 RID: 19206
			internal GameObject $hitObject$30724;

			// Token: 0x04004B07 RID: 19207
			internal IEnumerator $$iterator$10643$30725;

			// Token: 0x04004B08 RID: 19208
			internal int $j$30726;

			// Token: 0x04004B09 RID: 19209
			internal GameObject $hitObject$30727;

			// Token: 0x04004B0A RID: 19210
			internal IEnumerator $$iterator$10644$30728;

			// Token: 0x04004B0B RID: 19211
			internal Vector3 $mPos$30729;

			// Token: 0x04004B0C RID: 19212
			internal Vector3 $tDir$30730;

			// Token: 0x04004B0D RID: 19213
			internal FireBot $self_$30731;
		}
	}

	// Token: 0x02000AE8 RID: 2792
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$30735 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003DC2 RID: 15810 RVA: 0x007F6464 File Offset: 0x007F4664
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$30735(UnityScript.Lang.Array nArray, FireBot self_)
		{
			if (256987 - 579464 != -322476)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (236172 - 180075 == 56097)
				{
					base..ctor();
					if (194573 - 100497 != 94077)
					{
						this.$nArray$30740 = nArray;
						if (251467 - 131905 == 119562)
						{
							this.$self_$30741 = self_;
							if (296029 - 313392 != -17362)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x007F6520 File Offset: 0x007F4720
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireBot.$RPC_ko$30735.$(this.$nArray$30740, this.$self_$30741);
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x007F6534 File Offset: 0x007F4734
		internal static bool IkmvWp5OVq4SLDrgCxIP()
		{
			return true;
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x007F6538 File Offset: 0x007F4738
		internal static bool TFTYU25OtPhDbRgi8nZv()
		{
			return false;
		}

		// Token: 0x04004B0E RID: 19214
		internal UnityScript.Lang.Array $nArray$30740;

		// Token: 0x04004B0F RID: 19215
		internal FireBot $self_$30741;

		// Token: 0x02000AE9 RID: 2793
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003DC6 RID: 15814 RVA: 0x007F653C File Offset: 0x007F473C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FireBot self_)
			{
				if (51923 - 367279 != -315356)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (42351 - 295450 != -253098)
					{
						base..ctor();
						if (240566 - 580543 != -339976)
						{
							this.$nArray$30738 = nArray;
							if (9577 - 304517 == -294940)
							{
								this.$self_$30739 = self_;
								if (259160 - 427022 == -167862)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003DC7 RID: 15815 RVA: 0x007F65F8 File Offset: 0x007F47F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (65255 - 393562 != -328307)
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
						if (this.$self_$30739.mChar.actionState != "ko")
						{
							if (59966 - 353280 != -293314)
							{
								continue;
							}
							goto IL_49;
						}
						else
						{
							this.$self_$30739.animation.Play("getUp");
							if (49274 - 165309 != -116035)
							{
								continue;
							}
							this.$self_$30739.animation.wrapMode = WrapMode.Once;
							if (283558 - 438937 != -155378)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30739.mChar.actionState != "ko")
						{
							if (265328 - 488957 != -223629)
							{
								continue;
							}
							goto IL_15E;
						}
						else
						{
							this.$self_$30739.mChar.actionState = "standby";
							if (27640 - 437236 == -409595)
							{
								continue;
							}
							this.$self_$30739.mChar.actionTime = Time.time;
							if (175383 - 120409 != 54974)
							{
								continue;
							}
							this.$self_$30739.mChar.myCommand = "none";
							if (265092 - 146183 != 118909)
							{
								continue;
							}
							this.$self_$30739.mChar.ko = this.$self_$30739.mChar.mko;
							if (241758 - 373480 != -131722)
							{
								continue;
							}
							this.YieldDefault(1);
							if (254712 - 265480 != -10767)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					default:
						if (137915 - 135559 == 2357)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30739.mChar.actionState == "ko")
					{
						break;
					}
					if (32004 - 560825 == -528821)
					{
						if (this.$self_$30739.mChar.actionState == "dead")
						{
							if (199777 - 480977 != -281199)
							{
								break;
							}
						}
						else
						{
							this.$mPos$30736 = (Vector3)this.$nArray$30738[0];
							if (263012 - 364148 != -101135)
							{
								this.$mDir$30737 = (Vector3)this.$nArray$30738[1];
								if (141689 - 543716 == -402027)
								{
									this.$self_$30739.mChar.ko = 0;
									if (298647 - 458634 == -159987)
									{
										this.$self_$30739.mChar.actionState = "ko";
										if (84262 - 291143 == -206881)
										{
											this.$self_$30739.mChar.actionTime = Time.time;
											if (244533 - 404215 == -159682)
											{
												this.$self_$30739.mChar.myCommand = "none";
												if (91979 - 464412 != -372432)
												{
													this.$self_$30739.mChar.vMovement = Vector3.zero;
													if (261303 - 289361 == -28058)
													{
														this.$self_$30739.mChar.moveSpeed = (float)0;
														if (44985 - 104390 == -59405)
														{
															this.$self_$30739.animation.Play("ko");
															if (279969 - 488957 == -208988)
															{
																this.$self_$30739.animation.wrapMode = WrapMode.Once;
																if (93298 - 531094 == -437796)
																{
																	goto IL_1C1;
																}
															}
														}
													}
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
				goto IL_48C;
				Block_5:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_15E:
				goto IL_48C;
				IL_1C1:
				return this.Yield(2, new WaitForSeconds(9f));
				Block_16:
				IL_48C:
				return false;
			}

			// Token: 0x06003DC8 RID: 15816 RVA: 0x007F6AA4 File Offset: 0x007F4CA4
			internal static bool PNqaRo5ONPNio7W3Xge3()
			{
				return true;
			}

			// Token: 0x06003DC9 RID: 15817 RVA: 0x007F6AA8 File Offset: 0x007F4CA8
			internal static bool rx9JpD5OY6yZNNgN4Tka()
			{
				return false;
			}

			// Token: 0x04004B10 RID: 19216
			internal Vector3 $mPos$30736;

			// Token: 0x04004B11 RID: 19217
			internal Vector3 $mDir$30737;

			// Token: 0x04004B12 RID: 19218
			internal UnityScript.Lang.Array $nArray$30738;

			// Token: 0x04004B13 RID: 19219
			internal FireBot $self_$30739;
		}
	}

	// Token: 0x02000AEA RID: 2794
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30742 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003DCA RID: 15818 RVA: 0x007F6AAC File Offset: 0x007F4CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30742(UnityScript.Lang.Array nArray, FireBot self_)
		{
			if (280038 - 152229 != 127810)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (126327 - 148047 == -21720)
				{
					base..ctor();
					if (233492 - 471327 == -237835)
					{
						this.$nArray$30747 = nArray;
						if (213924 - 319636 == -105712)
						{
							this.$self_$30748 = self_;
							if (26167 - 458603 == -432436)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x007F6B68 File Offset: 0x007F4D68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireBot.$RPC_dead$30742.$(this.$nArray$30747, this.$self_$30748);
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x007F6B7C File Offset: 0x007F4D7C
		internal static bool ANCQhy5OcewraaBDD7ev()
		{
			return true;
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x007F6B80 File Offset: 0x007F4D80
		internal static bool RY9OmO5OUGG9XQ7JJXI5()
		{
			return false;
		}

		// Token: 0x04004B14 RID: 19220
		internal UnityScript.Lang.Array $nArray$30747;

		// Token: 0x04004B15 RID: 19221
		internal FireBot $self_$30748;

		// Token: 0x02000AEB RID: 2795
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003DCE RID: 15822 RVA: 0x007F6B84 File Offset: 0x007F4D84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FireBot self_)
			{
				if (37560 - 538172 != -500612)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (211154 - 595700 == -384546)
					{
						base..ctor();
						if (188142 - 259274 == -71132)
						{
							this.$nArray$30745 = nArray;
							if (243638 - 30065 == 213573)
							{
								this.$self_$30746 = self_;
								if (113013 - 344838 == -231825)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003DCF RID: 15823 RVA: 0x007F6C40 File Offset: 0x007F4E40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (245550 - 127709 != 117842)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4C7;
					case 2:
						if (this.$self_$30746.mChar.actionState != "dead")
						{
							if (97536 - 147174 != -49637)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30746.mChar.isPlayer)
							{
								if (31649 - 341532 != -309883)
								{
									continue;
								}
								if (this.$self_$30746.deadEffect)
								{
									if (39904 - 129053 != -89149)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$30746.deadEffect, this.$self_$30746.transform.position, Quaternion.identity);
									if (295191 - 417708 == -122516)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing deadEffect");
									if (161893 - 219067 == -57173)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$30746.gameObject);
								if (34472 - 391656 == -357183)
								{
									continue;
								}
							}
							else if (this.$self_$30746.mChar.isMine)
							{
								if (235338 - 301983 == -66644)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30746.gameObject);
								if (144869 - 78567 != 66302)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (130600 - 555503 != -424902)
							{
								goto IL_4C7;
							}
							continue;
						}
						break;
					default:
						if (173458 - 33299 == 140160)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30746.mChar.actionState == "dead")
					{
						if (56531 - 304141 == -247610)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30743 = (Vector3)this.$nArray$30745[0];
						if (73628 - 534459 != -460830)
						{
							this.$myDirection$30744 = (Vector3)this.$nArray$30745[1];
							if (238478 - 204460 != 34019)
							{
								this.$self_$30746.transform.position = this.$myPosition$30743;
								if (278367 - 84409 == 193958)
								{
									this.$self_$30746.transform.LookAt(this.$myPosition$30743 + this.$myDirection$30744);
									if (208824 - 32478 == 176346)
									{
										this.$self_$30746.mChar.hp = 0;
										if (86012 - 247889 != -161876)
										{
											this.$self_$30746.mChar.actionState = "dead";
											if (43471 - 157181 == -113710)
											{
												this.$self_$30746.mChar.actionTime = Time.time;
												if (156531 - 234607 != -78075)
												{
													this.$self_$30746.mChar.myCommand = "none";
													if (169146 - 306427 == -137281)
													{
														this.$self_$30746.mChar.vMovement = Vector3.zero;
														if (234719 - 557075 != -322355)
														{
															this.$self_$30746.mChar.moveSpeed = (float)0;
															if (223544 - 105915 == 117629)
															{
																this.$self_$30746.animation.Rewind();
																if (179839 - 126871 == 52968)
																{
																	this.$self_$30746.animation.Play("ko");
																	if (222737 - 346589 == -123852)
																	{
																		this.$self_$30746.animation.wrapMode = WrapMode.Once;
																		if (213552 - 312411 == -98859)
																		{
																			goto IL_323;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_4C7;
				IL_323:
				return this.Yield(2, new WaitForSeconds(4f));
				Block_22:
				IL_4C7:
				return false;
			}

			// Token: 0x06003DD0 RID: 15824 RVA: 0x007F7128 File Offset: 0x007F5328
			internal static bool fwKMLR5OTLhO2cUEidt4()
			{
				return true;
			}

			// Token: 0x06003DD1 RID: 15825 RVA: 0x007F712C File Offset: 0x007F532C
			internal static bool fZjERy5O3tnT2V6ZZg56()
			{
				return false;
			}

			// Token: 0x04004B16 RID: 19222
			internal Vector3 $myPosition$30743;

			// Token: 0x04004B17 RID: 19223
			internal Vector3 $myDirection$30744;

			// Token: 0x04004B18 RID: 19224
			internal UnityScript.Lang.Array $nArray$30745;

			// Token: 0x04004B19 RID: 19225
			internal FireBot $self_$30746;
		}
	}
}
