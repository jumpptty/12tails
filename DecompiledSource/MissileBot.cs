using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000AEE RID: 2798
[Serializable]
public class MissileBot : MonoBehaviour
{
	// Token: 0x06003DE8 RID: 15848 RVA: 0x007FA0D4 File Offset: 0x007F82D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MissileBot()
	{
		if (189048 - 141043 != 48006)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (9686 - 135823 != -126136)
			{
				base..ctor();
				if (120451 - 265154 != -144702)
				{
					this.hasMissile = true;
					if (128486 - 179836 == -51350)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003DE9 RID: 15849 RVA: 0x007FA16C File Offset: 0x007F836C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (217977 - 369664 != -151686)
		{
		}
		for (;;)
		{
			this.Gp3uFrmdQN = this.transform;
			if (67016 - 329255 == -262239)
			{
				this.MC4uA8fG6N = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (200637 - 46132 == 154505)
				{
					this.MC4uA8fG6N.actionState = "standby";
					if (170192 - 348818 != -178625)
					{
						this.MC4uA8fG6N.actionTime = Time.time;
						if (278915 - 391508 == -112593)
						{
							this.MC4uA8fG6N.myCommand = "none";
							if (49342 - 499639 == -450297)
							{
								this.MC4uA8fG6N.hp = (this.MC4uA8fG6N.mhp = 870);
								if (292345 - 25157 != 267189)
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

	// Token: 0x06003DEA RID: 15850 RVA: 0x007FA2B8 File Offset: 0x007F84B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.MC4uA8fG6N.isMine = true;
		}
	}

	// Token: 0x06003DEB RID: 15851 RVA: 0x007FA2D4 File Offset: 0x007F84D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (298327 - 510961 != -212634)
		{
		}
		for (;;)
		{
			if (this.MC4uA8fG6N.isControlled)
			{
				if (82145 - 106137 == -23991)
				{
					continue;
				}
				if (!(this.MC4uA8fG6N.actionState == "standby"))
				{
					if (22401 - 343184 != -320783)
					{
						continue;
					}
					if (!(this.MC4uA8fG6N.actionState == "run"))
					{
						goto IL_44;
					}
					if (183665 - 228334 != -44669)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (205803 - 526238 != -320435)
				{
					continue;
				}
			}
			IL_44:
			if (this.MC4uA8fG6N.hp <= 0)
			{
				if (153086 - 521798 != -368712)
				{
					continue;
				}
				if (this.MC4uA8fG6N.actionState != "dead")
				{
					if (101028 - 466640 == -365611)
					{
						continue;
					}
					if (this.MC4uA8fG6N.isMine)
					{
						if (46969 - 489089 == -442119)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.Gp3uFrmdQN.position,
							this.Gp3uFrmdQN.forward
						})));
						if (161316 - 13367 != 147949)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (81604 - 330350 != -248746)
						{
							continue;
						}
						this.MC4uA8fG6N.DeadEvent();
						if (122117 - 140425 != -18307)
						{
							break;
						}
						continue;
					}
					else
					{
						this.MC4uA8fG6N.hp = 1;
						if (184547 - 217418 != -32870)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.MC4uA8fG6N.hp <= 0)
			{
				break;
			}
			if (215205 - 591352 != -376146)
			{
				if (this.MC4uA8fG6N.ko > 0)
				{
					break;
				}
				if (276185 - 295720 == -19535)
				{
					if (!(this.MC4uA8fG6N.actionState != "ko"))
					{
						break;
					}
					if (60422 - 421917 == -361495)
					{
						if (!(this.MC4uA8fG6N.actionState != "dead"))
						{
							break;
						}
						if (290097 - 435426 == -145329)
						{
							if (this.MC4uA8fG6N.isMine)
							{
								if (152965 - 46742 != 106224)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.Gp3uFrmdQN.position,
										this.Gp3uFrmdQN.forward
									})));
									if (181381 - 90509 == 90872)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (116022 - 455993 == -339971)
										{
											this.MC4uA8fG6N.KoEvent();
											if (174202 - 592054 != -417851)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.MC4uA8fG6N.ko = 1;
								if (230203 - 246858 != -16654)
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

	// Token: 0x06003DEC RID: 15852 RVA: 0x007FA6CC File Offset: 0x007F88CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (94228 - 169968 != -75740)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (125008 - 295392 == -170384)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (121581 - 248183 != -126601 && 21790 - 327743 != -305952)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (103602 - 325691 != -222089)
						{
							continue;
						}
						v = 1;
						if (148653 - 237912 != -89259)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (286034 - 161698 == 124337)
						{
							continue;
						}
						v = -1;
						if (147912 - 83976 == 63937)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_missile")
					{
						if (61120 - 572570 != -511450)
						{
							continue;
						}
						v = 11;
						if (142117 - 28405 == 113713)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_missile_fire")
					{
						if (247548 - 313557 != -66009)
						{
							continue;
						}
						v = 12;
						if (209373 - 328552 == -119178)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_missile_hit")
					{
						if (103117 - 428378 == -325260)
						{
							continue;
						}
						v = -12;
						if (75114 - 537414 == -462299)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_suicideBomb")
					{
						if (18277 - 320741 == -302463)
						{
							continue;
						}
						v = 21;
						if (137545 - 440780 == -303234)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_suicideBomb_hit")
					{
						if (220891 - 121440 != 99451)
						{
							continue;
						}
						v = -21;
						if (81647 - 25141 == 56507)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (10224 - 103920 != -93696)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (283821 - 114168 == 169653)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (176364 - 548003 == -371639)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (105920 - 130259 != -24338)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (76592 - 33813 != 42780)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (52643 - 418851 == -366208)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (272910 - 388981 == -116071)
										{
											Hashtable hashtable = new Hashtable();
											if (231460 - 143744 == 87716)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (232898 - 61185 != 171714)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (243404 - 532438 == -289034)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (64623 - 212268 != -147644)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (128886 - 268265 == -139379)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (191871 - 44198 == 147673)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (174856 - 561493 == -386637)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (259610 - 542563 != -282952)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (276227 - 270001 == 6226)
																			{
																				PhotonClient.SendEvent(this.MC4uA8fG6N.ActorNr, 74, hashtable, true, true);
																				if (69421 - 241178 != -171756)
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

	// Token: 0x06003DED RID: 15853 RVA: 0x007FACC8 File Offset: 0x007F8EC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (286707 - 180681 != 106027)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (24738 - 376078 != -351339)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (113606 - 349290 != -235683)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (38124 - 484313 == -446189)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (265671 - 303927 != -38255)
						{
							int num3 = num;
							if (174294 - 490172 != -315877)
							{
								if (num3 == 1)
								{
									if (295361 - 414600 != -119238)
									{
										if (this.MC4uA8fG6N.isMine)
										{
											break;
										}
										if (23624 - 445246 != -421621)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (148383 - 106434 != 41950)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (125898 - 530081 != -404182)
									{
										if (this.MC4uA8fG6N.isMine)
										{
											break;
										}
										if (161883 - 355298 == -193415)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (239817 - 242909 != -3091)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (267541 - 35556 != 231986)
									{
										if (this.MC4uA8fG6N.isMine)
										{
											break;
										}
										if (110081 - 495615 != -385533)
										{
											this.StartCoroutine_Auto(this.RPC_missile(vector, vector2, num2));
											if (91909 - 261791 == -169882)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (34997 - 144213 != -109215)
									{
										if (this.MC4uA8fG6N.isMine)
										{
											break;
										}
										if (272578 - 73976 == 198602)
										{
											this.RPC_missile_fire(vector, vector2, num2);
											if (13238 - 112078 != -98839)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -12)
								{
									if (223086 - 550984 == -327898)
									{
										if (this.MC4uA8fG6N.isMine)
										{
											break;
										}
										if (200212 - 586528 != -386315)
										{
											this.RPC_missile_hit(vector, vector2, num2);
											if (263120 - 307944 == -44824)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (218292 - 240604 != -22311)
									{
										if (this.MC4uA8fG6N.isMine)
										{
											break;
										}
										if (147206 - 568764 == -421558)
										{
											this.StartCoroutine_Auto(this.RPC_suicideBomb(vector, vector2, num2));
											if (59025 - 377064 == -318039)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (274319 - 98541 != 175779)
									{
										if (this.MC4uA8fG6N.isMine)
										{
											break;
										}
										if (149551 - 138566 == 10985)
										{
											this.RPC_suicideBomb_hit(vector, vector2, num2);
											if (253936 - 169805 != 84132)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (210687 - 533252 == -322565)
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

	// Token: 0x06003DEE RID: 15854 RVA: 0x007FB1B4 File Offset: 0x007F93B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (28370 - 337213 != -308843)
		{
		}
		for (;;)
		{
			float num = this.MC4uA8fG6N.moveSpeed;
			if (283316 - 161284 == 122032)
			{
				float runSpeed = this.MC4uA8fG6N.runSpeed;
				if (74988 - 500034 == -425046)
				{
					Vector3 a = default(Vector3);
					if (191227 - 265941 != -74713)
					{
						Vector3 vector = Vector3.zero;
						if (258335 - 33136 != 225200)
						{
							float num2 = (float)0;
							if (203797 - 531515 == -327718)
							{
								if (this.MC4uA8fG6N.isMine)
								{
									if (206604 - 217236 != -10632)
									{
										continue;
									}
									if ((this.MC4uA8fG6N.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (7348 - 516970 != -509622)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (137058 - 208159 != -71101)
										{
											continue;
										}
										a.y = (float)0;
										if (16078 - 523003 == -506924)
										{
											continue;
										}
										a = a.normalized;
										if (41840 - 555433 == -513592)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (103812 - 515003 == -411190)
										{
											continue;
										}
										vector = vector.normalized;
										if (62657 - 515932 != -453275)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (283491 - 284988 != -1497)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (59917 - 335591 != -275674)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (199732 - 338947 == -139214)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (105284 - 263749 == -158464)
														{
															continue;
														}
														this.MC4uA8fG6N.actionState = "run";
														if (14863 - 551636 == -536772)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (246334 - 394837 != -148503)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (106282 - 107638 != -1356)
														{
															continue;
														}
														this.animation.Play("run");
														if (45815 - 564552 == -518736)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (48963 - 481713 != -432750)
														{
															continue;
														}
														goto IL_336;
													}
												}
											}
										}
										this.MC4uA8fG6N.actionState = "standby";
										if (289198 - 371094 == -81895)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (124170 - 516662 == -392491)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (120091 - 384799 != -264708)
											{
												continue;
											}
											num = (float)0;
											if (140080 - 455180 != -315100)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (60724 - 9035 == 51690)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (6508 - 443342 == -436833)
										{
											continue;
										}
									}
									IL_336:;
								}
								else
								{
									vector = global::Math.vFlat(this.MC4uA8fG6N.nPosition - this.transform.position);
									if (280045 - 309405 == -29359)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (204815 - 317132 == -112316)
									{
										continue;
									}
									if (this.MC4uA8fG6N.nSpeed != (float)0)
									{
										if (6716 - 370816 == -364099)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (297976 - 77804 == 220173)
											{
												continue;
											}
											this.transform.position = this.MC4uA8fG6N.nPosition;
											if (125451 - 388262 == -262810)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (217445 - 437055 == -219609)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (270046 - 120537 == 149510)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (170476 - 571446 == -400969)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.MC4uA8fG6N.nSpeed, (float)10 * Time.deltaTime);
												if (130974 - 127670 != 3304)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (82060 - 124920 == -42859)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (48624 - 217851 != -169227)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (59513 - 549717 == -490203)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (131954 - 11452 == 120503)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (184964 - 81279 != 103685)
											{
												continue;
											}
										}
										else if (Time.time > this.MC4uA8fG6N.nSpeed + 0.3f)
										{
											if (11152 - 88734 == -77581)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (46893 - 7191 == 39703)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (99588 - 229960 != -130372)
												{
													continue;
												}
												num = (float)0;
												if (183861 - 50727 != 133134)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.MC4uA8fG6N.nDirection);
											if (14278 - 434462 != -420184)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (146714 - 26307 != 120407)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (220584 - 188175 == 32410)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (131691 - 52380 != 79311)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (82866 - 122769 == -39902)
											{
												continue;
											}
											this.transform.position = this.MC4uA8fG6N.nPosition;
											if (214198 - 156804 != 57394)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (205577 - 215470 == -9892)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (158226 - 153131 == 5096)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (97501 - 593337 == -495835)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (149498 - 414356 == -264857)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (61043 - 520374 == -459330)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (295277 - 279009 == 16269)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (177743 - 410426 != -232683)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.MC4uA8fG6N.nDirection);
											if (22480 - 526940 != -504460)
											{
												continue;
											}
											num = (float)0;
											if (139594 - 45735 != 93859)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (188537 - 75204 == 113334)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (166028 - 133758 == 32271)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (47818 - 486575 != -438757)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (108547 - 10958 == 97590)
										{
											continue;
										}
									}
								}
								this.MC4uA8fG6N.vMovement = vector;
								if (130986 - 130896 != 91)
								{
									this.MC4uA8fG6N.moveSpeed = num;
									if (230887 - 360012 != -129124)
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

	// Token: 0x06003DEF RID: 15855 RVA: 0x007FBD18 File Offset: 0x007F9F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (291087 - 210310 != 80778)
		{
		}
		for (;;)
		{
			if (!this.MC4uA8fG6N.isMine)
			{
				if (251643 - 16688 != 234956)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (53467 - 59769 == -6302)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (218772 - 352791 == -134019)
					{
						Vector3 normalized = vector.normalized;
						if (203392 - 252227 == -48835)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (213709 - 237715 == -24006)
							{
								CharacterControl characterControl = null;
								if (248710 - 320804 == -72094)
								{
									int tID = 0;
									if (131576 - 285477 == -153901)
									{
										if (gameObject)
										{
											if (181910 - 489997 != -308087)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (41412 - 258001 != -216589)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (35344 - 322301 == -286956)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (295022 - 404104 == -109081)
											{
												continue;
											}
										}
										if (!(this.MC4uA8fG6N.actionState == "standby"))
										{
											if (296696 - 5672 == 291025)
											{
												continue;
											}
											if (!(this.MC4uA8fG6N.actionState == "run"))
											{
												break;
											}
											if (1712 - 333055 != -331343)
											{
												continue;
											}
										}
										if (this.MC4uA8fG6N.isTimeOut("nAttack") != (float)0)
										{
											break;
										}
										if (149620 - 485673 == -336053)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, tID));
											if (299004 - 545201 == -246197)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (184714 - 203541 == -18827)
												{
													this.ActionEvent("RPC_nAttack", this.transform.position, normalized, tID);
													if (179212 - 598012 != -418799)
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

	// Token: 0x06003DF0 RID: 15856 RVA: 0x007FC03C File Offset: 0x007FA23C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (293766 - 364720 != -70954)
		{
		}
		for (;;)
		{
			if (!this.MC4uA8fG6N.isMine)
			{
				if (271523 - 258439 == 13084)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (288903 - 321731 != -32827)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (146076 - 474916 == -328840)
					{
						Vector3 normalized = vector.normalized;
						if (208008 - 586266 != -378257)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (271875 - 208188 != 63688)
							{
								CharacterControl characterControl = null;
								if (159051 - 261942 == -102891)
								{
									int tID = 0;
									if (96782 - 73735 == 23047)
									{
										if (gameObject)
										{
											if (94330 - 415728 == -321397)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (236165 - 257847 == -21681)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (29640 - 546848 != -517208)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (58592 - 264823 != -206231)
											{
												continue;
											}
										}
										if (!(this.MC4uA8fG6N.actionState == "standby"))
										{
											if (284260 - 145288 == 138973)
											{
												continue;
											}
											if (!(this.MC4uA8fG6N.actionState == "run"))
											{
												break;
											}
											if (180513 - 541246 != -360733)
											{
												continue;
											}
										}
										if (this.MC4uA8fG6N.isTimeOut("missile") != (float)0)
										{
											break;
										}
										if (172587 - 167413 != 5175)
										{
											if (!this.hasMissile)
											{
												break;
											}
											if (47174 - 323148 == -275974)
											{
												this.StartCoroutine_Auto(this.RPC_missile(this.transform.position, normalized, tID));
												if (67798 - 64901 == 2897)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (246760 - 144116 == 102644)
													{
														this.ActionEvent("RPC_missile", this.transform.position, normalized, tID);
														if (256435 - 314175 == -57740)
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

	// Token: 0x06003DF1 RID: 15857 RVA: 0x007FC384 File Offset: 0x007FA584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003DF2 RID: 15858 RVA: 0x007FC388 File Offset: 0x007FA588
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MissileBot.$RPC_nAttack$30749(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06003DF3 RID: 15859 RVA: 0x007FC398 File Offset: 0x007FA598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (19374 - 551396 != -532021)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (284095 - 378234 != -94138)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (279637 - 262743 != 16895)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (199695 - 437091 == -237396)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003DF4 RID: 15860 RVA: 0x007FC450 File Offset: 0x007FA650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_missile(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MissileBot.$RPC_missile$30763(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06003DF5 RID: 15861 RVA: 0x007FC460 File Offset: 0x007FA660
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_missile_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (126683 - 67165 != 59518)
		{
		}
		while (this.missile_fire)
		{
			if (277982 - 196544 == 81438)
			{
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.missile_fire, firePos, Quaternion.LookRotation(fireDir) * Quaternion.Euler((float)0, (float)90, (float)0));
				if (88625 - 54360 != 34266)
				{
					if (gameObject)
					{
						if (199371 - 536077 != -336706)
						{
							continue;
						}
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (155360 - 86481 == 68880)
						{
							continue;
						}
						if (projectileControl)
						{
							if (285222 - 528362 == -243139)
							{
								continue;
							}
							projectileControl.Init(this.MC4uA8fG6N.ActorNr);
							if (248823 - 135915 != 112908)
							{
								continue;
							}
						}
					}
					if (targetID == 0)
					{
						break;
					}
					if (106493 - 108344 == -1851)
					{
						gameObject.SendMessage("SetHomingTarget", targetID);
						if (61186 - 337882 == -276696)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003DF6 RID: 15862 RVA: 0x007FC5F8 File Offset: 0x007FA7F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_missile_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (14336 - 179712 != -165375)
		{
		}
		for (;;)
		{
			if (this.missile_hit)
			{
				if (217559 - 250150 != -32590)
				{
					UnityEngine.Object.Instantiate(this.missile_hit, hitPos, Quaternion.identity);
					if (85360 - 460537 != -375176)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing missile_hit effect");
				if (34577 - 561701 != -527123)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003DF7 RID: 15863 RVA: 0x007FC6B0 File Offset: 0x007FA8B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_suicideBomb(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MissileBot.$RPC_suicideBomb$30774(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003DF8 RID: 15864 RVA: 0x007FC6C0 File Offset: 0x007FA8C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_suicideBomb_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (98058 - 242133 != -144074)
		{
		}
		do
		{
			IL_15B:
			if (this.suicideBomb_hit)
			{
				if (193351 - 372552 == -179200)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.suicideBomb_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (263619 - 430142 != -166523)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing suicideBomb_hit effect");
				if (222 - 155739 != -155517)
				{
					continue;
				}
			}
			if (this.MC4uA8fG6N.isMine)
			{
				if (51479 - 408974 != -357495)
				{
					continue;
				}
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (89327 - 22577 == 66751)
				{
					continue;
				}
				UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)12, (float)3, layerMask);
				if (53135 - 412166 == -359030)
				{
					continue;
				}
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
				if (284044 - 230650 != 53394)
				{
					continue;
				}
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
					if (115052 - 306998 == -191945)
					{
						goto IL_15B;
					}
					float num = (float)1 - 0.9f * ((gameObject.transform.position - this.transform.position).magnitude / (float)12);
					if (234791 - 467224 != -232433)
					{
						goto IL_15B;
					}
					UnityRuntimeServices.Update(enumerator, gameObject);
					if (39173 - 113931 != -74758)
					{
						goto IL_15B;
					}
					this.MC4uA8fG6N.hit(21, gameObject, (int)(num * (float)700), 50, 0, Vector3.zero);
					if (1943 - 182620 == -180676)
					{
						goto IL_15B;
					}
					UnityRuntimeServices.Update(enumerator, gameObject);
					if (117634 - 76915 != 40719)
					{
						goto IL_15B;
					}
				}
				if (4775 - 255149 == -250373)
				{
					continue;
				}
			}
			if (this.MC4uA8fG6N.isMine)
			{
				if (184252 - 4859 != 179393)
				{
					continue;
				}
				if (Game.mGameCode == 923)
				{
					if (227814 - 324487 != -96673)
					{
						continue;
					}
					Game.sendMissionEvent(9232, 0);
					if (78571 - 429553 == -350981)
					{
						continue;
					}
				}
				if (Game.mGameCode == 926)
				{
					if (111314 - 298426 != -187112)
					{
						continue;
					}
					Game.sendMissionEvent(9262, 0);
					if (274704 - 195574 != 79130)
					{
						continue;
					}
				}
			}
			UnityEngine.Object.Destroy(this.gameObject);
		}
		while (172671 - 97956 != 74715);
	}

	// Token: 0x06003DF9 RID: 15865 RVA: 0x007FCA44 File Offset: 0x007FAC44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new MissileBot.$RPC_ko$30781(nArray, this).GetEnumerator();
	}

	// Token: 0x06003DFA RID: 15866 RVA: 0x007FCA54 File Offset: 0x007FAC54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new MissileBot.$RPC_dead$30788(nArray, this).GetEnumerator();
	}

	// Token: 0x06003DFB RID: 15867 RVA: 0x007FCA64 File Offset: 0x007FAC64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003DFC RID: 15868 RVA: 0x007FCA68 File Offset: 0x007FAC68
	internal static bool nILTS95OHPIMohuT7CsE()
	{
		return true;
	}

	// Token: 0x06003DFD RID: 15869 RVA: 0x007FCA6C File Offset: 0x007FAC6C
	internal static bool UrEDrw5OWRk4VLoiLLZg()
	{
		return false;
	}

	// Token: 0x04004B24 RID: 19236
	private Transform Gp3uFrmdQN;

	// Token: 0x04004B25 RID: 19237
	private CharacterControl MC4uA8fG6N;

	// Token: 0x04004B26 RID: 19238
	public GameObject nAttack_hit;

	// Token: 0x04004B27 RID: 19239
	public bool hasMissile;

	// Token: 0x04004B28 RID: 19240
	public GameObject missile_fire;

	// Token: 0x04004B29 RID: 19241
	public GameObject missile_hit;

	// Token: 0x04004B2A RID: 19242
	public GameObject suicideBomb_ring;

	// Token: 0x04004B2B RID: 19243
	public GameObject suicideBomb_hit;

	// Token: 0x04004B2C RID: 19244
	public GameObject deadEffect;

	// Token: 0x02000AEF RID: 2799
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30749 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003DFE RID: 15870 RVA: 0x007FCA70 File Offset: 0x007FAC70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30749(Vector3 mPos, Vector3 tDir, int tID, MissileBot self_)
		{
			if (99625 - 243875 != -144250)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (285963 - 441227 != -155263)
				{
					base..ctor();
					if (97295 - 324499 == -227204)
					{
						this.$mPos$30759 = mPos;
						if (74898 - 224707 != -149808)
						{
							this.$tDir$30760 = tDir;
							if (154949 - 574359 != -419409)
							{
								this.$tID$30761 = tID;
								if (4048 - 181110 == -177062)
								{
									this.$self_$30762 = self_;
									if (147858 - 522735 == -374877)
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

		// Token: 0x06003DFF RID: 15871 RVA: 0x007FCB70 File Offset: 0x007FAD70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MissileBot.$RPC_nAttack$30749.$(this.$mPos$30759, this.$tDir$30760, this.$tID$30761, this.$self_$30762);
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x007FCB90 File Offset: 0x007FAD90
		internal static bool NNxoZJ5OAMgLH9ybYF64()
		{
			return true;
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x007FCB94 File Offset: 0x007FAD94
		internal static bool O0wlkZ5Olb3ZBUC2kVq8()
		{
			return false;
		}

		// Token: 0x04004B2D RID: 19245
		internal Vector3 $mPos$30759;

		// Token: 0x04004B2E RID: 19246
		internal Vector3 $tDir$30760;

		// Token: 0x04004B2F RID: 19247
		internal int $tID$30761;

		// Token: 0x04004B30 RID: 19248
		internal MissileBot $self_$30762;

		// Token: 0x02000AF0 RID: 2800
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003E02 RID: 15874 RVA: 0x007FCB98 File Offset: 0x007FAD98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, MissileBot self_)
			{
				if (13395 - 175757 != -162362)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (259901 - 389473 == -129572)
					{
						base..ctor();
						if (96256 - 480742 != -384485)
						{
							this.$mPos$30755 = mPos;
							if (104066 - 53197 != 50870)
							{
								this.$tDir$30756 = tDir;
								if (30283 - 106445 != -76161)
								{
									this.$tID$30757 = tID;
									if (154035 - 92057 == 61978)
									{
										this.$self_$30758 = self_;
										if (106387 - 193153 != -86765)
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

			// Token: 0x06003E03 RID: 15875 RVA: 0x007FCC98 File Offset: 0x007FAE98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (10307 - 581705 != -571398)
				{
				}
				for (;;)
				{
					IL_219:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9E3;
					case 2:
						if (this.$self_$30758.MC4uA8fG6N.actionState != "attack")
						{
							goto IL_548;
						}
						if (169434 - 30831 == 138604)
						{
							continue;
						}
						if (this.$self_$30758.MC4uA8fG6N.myCommand != "nAttack")
						{
							if (132754 - 181852 != -49097)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							this.$self_$30758.MC4uA8fG6N.moveSpeed = (float)6;
							if (209577 - 318714 != -109136)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30758.MC4uA8fG6N.actionState != "attack")
						{
							goto IL_3EB;
						}
						if (285455 - 578429 == -292973)
						{
							continue;
						}
						if (this.$self_$30758.MC4uA8fG6N.myCommand != "nAttack")
						{
							if (75570 - 14421 != 61149)
							{
								continue;
							}
							goto IL_3EB;
						}
						else
						{
							if (!this.$self_$30758.MC4uA8fG6N.isMine)
							{
								goto IL_5A9;
							}
							if (106175 - 597012 != -490837)
							{
								continue;
							}
							this.$hitLayer$30750 = 130816 - (1 << this.$self_$30758.gameObject.layer);
							if (217068 - 116595 != 100473)
							{
								continue;
							}
							this.$hitList$30751 = Damage.FindRecTarget(this.$self_$30758.transform.position, this.$self_$30758.transform.forward, (float)1, (float)1, (float)3, (float)3, this.$hitLayer$30750);
							if (48183 - 175332 == -127148)
							{
								continue;
							}
							this.$$iterator$10646$30754 = UnityRuntimeServices.GetEnumerator(this.$hitList$30751);
							if (93014 - 320768 != -227754)
							{
								continue;
							}
							while (this.$$iterator$10646$30754.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10646$30754.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30752 = (GameObject)obj2;
								if (237834 - 295514 != -57680)
								{
									goto IL_219;
								}
								if (this.$self_$30758.MC4uA8fG6N.hit(1, this.$hitObject$30752, 2 * this.$self_$30758.MC4uA8fG6N.atk, 5, 0, this.$self_$30758.transform.forward) != 0)
								{
									if (55339 - 283993 == -228653)
									{
										goto IL_219;
									}
									this.$hitPos$30753 = this.$hitObject$30752.collider.ClosestPointOnBounds(this.$self_$30758.transform.position + Vector3.up);
									if (65422 - 487665 != -422243)
									{
										goto IL_219;
									}
									UnityRuntimeServices.Update(this.$$iterator$10646$30754, this.$hitObject$30752);
									if (56318 - 363571 != -307253)
									{
										goto IL_219;
									}
									this.$self_$30758.RPC_nAttack_hit(this.$hitPos$30753, this.$self_$30758.transform.forward, this.$tID$30757);
									if (155570 - 459163 != -303593)
									{
										goto IL_219;
									}
									if (PhotonClient.IsInitialized())
									{
										if (217832 - 139205 != 78627)
										{
											goto IL_219;
										}
										this.$self_$30758.ActionEvent("RPC_nAttack_hit", this.$hitPos$30753, this.$self_$30758.transform.forward, this.$tID$30757);
										if (191656 - 26214 != 165442)
										{
											goto IL_219;
										}
									}
								}
							}
							if (72463 - 451763 != -379299)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					case 4:
						if (!(this.$self_$30758.MC4uA8fG6N.actionState == "attack"))
						{
							goto IL_D9;
						}
						if (281605 - 230394 != 51211)
						{
							continue;
						}
						if (!(this.$self_$30758.MC4uA8fG6N.myCommand == "nAttack"))
						{
							goto IL_D9;
						}
						if (222858 - 83832 != 139026)
						{
							continue;
						}
						this.$self_$30758.MC4uA8fG6N.moveSpeed = (float)2;
						if (118686 - 432809 != -314122)
						{
							goto Block_20;
						}
						continue;
					case 5:
						if (!(this.$self_$30758.MC4uA8fG6N.actionState == "attack"))
						{
							goto IL_7EE;
						}
						if (146513 - 79870 != 66643)
						{
							continue;
						}
						if (!(this.$self_$30758.MC4uA8fG6N.myCommand == "nAttack"))
						{
							goto IL_7EE;
						}
						if (165651 - 458397 != -292746)
						{
							continue;
						}
						this.$self_$30758.MC4uA8fG6N.moveSpeed = (float)0;
						if (293331 - 411639 != -118307)
						{
							goto Block_25;
						}
						continue;
					case 6:
						if (this.$self_$30758.MC4uA8fG6N.actionState == "attack")
						{
							if (25667 - 351574 != -325907)
							{
								continue;
							}
							if (this.$self_$30758.MC4uA8fG6N.myCommand == "nAttack")
							{
								if (138175 - 207876 == -69700)
								{
									continue;
								}
								this.$self_$30758.MC4uA8fG6N.actionState = "standby";
								if (199823 - 357905 != -158082)
								{
									continue;
								}
								this.$self_$30758.MC4uA8fG6N.actionTime = Time.time;
								if (239693 - 164365 == 75329)
								{
									continue;
								}
								this.$self_$30758.MC4uA8fG6N.myCommand = "none";
								if (249781 - 203247 == 46535)
								{
									continue;
								}
								if (!this.$self_$30758.MC4uA8fG6N.isMine)
								{
									if (207703 - 169582 == 38122)
									{
										continue;
									}
									this.$self_$30758.MC4uA8fG6N.nPosition = this.$self_$30758.transform.position;
									if (128148 - 117182 != 10966)
									{
										continue;
									}
									this.$self_$30758.MC4uA8fG6N.oPosition = this.$self_$30758.transform.position;
									if (214719 - 22169 != 192550)
									{
										continue;
									}
									this.$self_$30758.MC4uA8fG6N.nDirection = this.$self_$30758.transform.forward;
									if (148700 - 62283 != 86417)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (110395 - 811 != 109584)
						{
							continue;
						}
						goto IL_9E3;
					default:
						if (146557 - 98483 == 48075)
						{
							continue;
						}
						break;
					}
					this.$self_$30758.MC4uA8fG6N.actionState = "attack";
					if (70208 - 464359 != -394150)
					{
						this.$self_$30758.MC4uA8fG6N.actionTime = Time.time;
						if (131359 - 7228 == 124131)
						{
							this.$self_$30758.MC4uA8fG6N.myCommand = "nAttack";
							if (117504 - 401470 == -283966)
							{
								this.$self_$30758.MC4uA8fG6N.addTimeOut("nAttack", (float)2);
								if (122775 - 88997 != 33779)
								{
									this.$self_$30758.transform.position = this.$mPos$30755;
									if (192455 - 553048 == -360593)
									{
										this.$self_$30758.transform.LookAt(this.$mPos$30755 + global::Math.vFlat(this.$tDir$30756));
										if (171784 - 535362 != -363577)
										{
											this.$self_$30758.animation.CrossFade("nAttack");
											if (97753 - 279056 == -181303)
											{
												this.$self_$30758.animation.wrapMode = WrapMode.Once;
												if (113360 - 240717 == -127357)
												{
													this.$self_$30758.MC4uA8fG6N.vMovement = this.$self_$30758.transform.forward;
													if (189255 - 74857 == 114398)
													{
														this.$self_$30758.MC4uA8fG6N.moveSpeed = (float)0;
														if (191784 - 584115 == -392331)
														{
															goto IL_341;
														}
													}
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
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_20:
				goto IL_D9;
				IL_341:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_25:
				goto IL_7EE;
				IL_3EB:
				Block_33:
				IL_548:
				goto IL_9E3;
				Block_37:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_5A9:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_48:
				goto IL_5A9;
				IL_7EE:
				return this.Yield(6, new WaitForSeconds(0.2f));
				IL_9E3:
				return false;
			}

			// Token: 0x06003E04 RID: 15876 RVA: 0x007FD69C File Offset: 0x007FB89C
			internal static bool jGpgQ45Oyg6S0UrbtxQp()
			{
				return true;
			}

			// Token: 0x06003E05 RID: 15877 RVA: 0x007FD6A0 File Offset: 0x007FB8A0
			internal static bool lIp0e05OSYLsXNsr8A6s()
			{
				return false;
			}

			// Token: 0x04004B31 RID: 19249
			internal int $hitLayer$30750;

			// Token: 0x04004B32 RID: 19250
			internal UnityScript.Lang.Array $hitList$30751;

			// Token: 0x04004B33 RID: 19251
			internal GameObject $hitObject$30752;

			// Token: 0x04004B34 RID: 19252
			internal Vector3 $hitPos$30753;

			// Token: 0x04004B35 RID: 19253
			internal IEnumerator $$iterator$10646$30754;

			// Token: 0x04004B36 RID: 19254
			internal Vector3 $mPos$30755;

			// Token: 0x04004B37 RID: 19255
			internal Vector3 $tDir$30756;

			// Token: 0x04004B38 RID: 19256
			internal int $tID$30757;

			// Token: 0x04004B39 RID: 19257
			internal MissileBot $self_$30758;
		}
	}

	// Token: 0x02000AF1 RID: 2801
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_missile$30763 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003E06 RID: 15878 RVA: 0x007FD6A4 File Offset: 0x007FB8A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_missile$30763(Vector3 mPos, Vector3 tDir, int tID, MissileBot self_)
		{
			if (150394 - 24356 != 126039)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (50126 - 61441 != -11314)
				{
					base..ctor();
					if (284686 - 550248 != -265561)
					{
						this.$mPos$30770 = mPos;
						if (65620 - 414707 != -349086)
						{
							this.$tDir$30771 = tDir;
							if (187184 - 190093 != -2908)
							{
								this.$tID$30772 = tID;
								if (78858 - 10328 != 68531)
								{
									this.$self_$30773 = self_;
									if (21728 - 17316 == 4412)
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

		// Token: 0x06003E07 RID: 15879 RVA: 0x007FD7A4 File Offset: 0x007FB9A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MissileBot.$RPC_missile$30763.$(this.$mPos$30770, this.$tDir$30771, this.$tID$30772, this.$self_$30773);
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x007FD7C4 File Offset: 0x007FB9C4
		internal static bool cpls2c5Oojcgmc7H5TZ7()
		{
			return true;
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x007FD7C8 File Offset: 0x007FB9C8
		internal static bool SeIcDE5OE4MlO7IwDrJ8()
		{
			return false;
		}

		// Token: 0x04004B3A RID: 19258
		internal Vector3 $mPos$30770;

		// Token: 0x04004B3B RID: 19259
		internal Vector3 $tDir$30771;

		// Token: 0x04004B3C RID: 19260
		internal int $tID$30772;

		// Token: 0x04004B3D RID: 19261
		internal MissileBot $self_$30773;

		// Token: 0x02000AF2 RID: 2802
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003E0A RID: 15882 RVA: 0x007FD7CC File Offset: 0x007FB9CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, MissileBot self_)
			{
				if (7515 - 290066 != -282550)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (98262 - 62692 != 35571)
					{
						base..ctor();
						if (256730 - 167409 != 89322)
						{
							this.$mPos$30766 = mPos;
							if (290428 - 416901 == -126473)
							{
								this.$tDir$30767 = tDir;
								if (146079 - 80670 == 65409)
								{
									this.$tID$30768 = tID;
									if (228405 - 306378 == -77973)
									{
										this.$self_$30769 = self_;
										if (273961 - 252304 == 21657)
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

			// Token: 0x06003E0B RID: 15883 RVA: 0x007FD8CC File Offset: 0x007FBACC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (267030 - 4506 != 262524)
				{
				}
				for (;;)
				{
					IL_2C0:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7BC;
					case 2:
						if (this.$self_$30769.MC4uA8fG6N.actionState == "attack")
						{
							if (235068 - 516532 != -281464)
							{
								continue;
							}
							if (this.$self_$30769.MC4uA8fG6N.myCommand == "missile")
							{
								if (63569 - 163090 != -99521)
								{
									continue;
								}
								this.$self_$30769.MC4uA8fG6N.moveSpeed = (float)-2;
								if (297432 - 120006 != 177426)
								{
									continue;
								}
							}
						}
						this.$i$30764 = 1;
						if (161946 - 34697 != 127249)
						{
							continue;
						}
						while (this.$i$30764 <= 4)
						{
							this.$missile$30765 = global::Math.findChildObject(this.$self_$30769.transform, "missile" + this.$i$30764);
							if (286173 - 570083 != -283910)
							{
								goto IL_2C0;
							}
							if (this.$missile$30765)
							{
								if (46741 - 183375 != -136634)
								{
									goto IL_2C0;
								}
								UnityEngine.Object.Destroy(this.$missile$30765.gameObject);
								if (129503 - 223007 == -93503)
								{
									goto IL_2C0;
								}
								if (this.$self_$30769.MC4uA8fG6N.isMine)
								{
									if (106462 - 93312 != 13150)
									{
										goto IL_2C0;
									}
									this.$self_$30769.RPC_missile_fire(this.$missile$30765.transform.position, this.$missile$30765.transform.forward, this.$tID$30768);
									if (54039 - 421269 == -367229)
									{
										goto IL_2C0;
									}
									this.$self_$30769.ActionEvent("RPC_missile_fire", this.$missile$30765.transform.position, this.$missile$30765.transform.forward, this.$tID$30768);
									if (183243 - 213521 == -30277)
									{
										goto IL_2C0;
									}
								}
							}
							this.$i$30764++;
							if (116346 - 34668 == 81679)
							{
								goto IL_2C0;
							}
						}
						if (167890 - 405388 != -237498)
						{
							continue;
						}
						this.$self_$30769.hasMissile = false;
						if (246934 - 295442 != -48508)
						{
							continue;
						}
						goto IL_483;
					case 3:
						if (!(this.$self_$30769.MC4uA8fG6N.actionState == "attack"))
						{
							goto IL_212;
						}
						if (128564 - 6550 == 122015)
						{
							continue;
						}
						if (!(this.$self_$30769.MC4uA8fG6N.myCommand == "missile"))
						{
							goto IL_212;
						}
						if (76710 - 316691 == -239980)
						{
							continue;
						}
						this.$self_$30769.MC4uA8fG6N.moveSpeed = (float)0;
						if (152874 - 258507 != -105633)
						{
							continue;
						}
						goto IL_212;
					case 4:
						if (this.$self_$30769.MC4uA8fG6N.actionState == "attack")
						{
							if (74773 - 82664 == -7890)
							{
								continue;
							}
							if (this.$self_$30769.MC4uA8fG6N.myCommand == "missile")
							{
								if (246978 - 359500 == -112521)
								{
									continue;
								}
								this.$self_$30769.MC4uA8fG6N.actionState = "standby";
								if (135946 - 409679 != -273733)
								{
									continue;
								}
								this.$self_$30769.MC4uA8fG6N.actionTime = Time.time;
								if (298562 - 361462 == -62899)
								{
									continue;
								}
								this.$self_$30769.MC4uA8fG6N.myCommand = "none";
								if (93165 - 300186 == -207020)
								{
									continue;
								}
								if (!this.$self_$30769.MC4uA8fG6N.isMine)
								{
									if (275146 - 391025 != -115879)
									{
										continue;
									}
									this.$self_$30769.MC4uA8fG6N.nPosition = this.$self_$30769.transform.position;
									if (182112 - 89345 != 92767)
									{
										continue;
									}
									this.$self_$30769.MC4uA8fG6N.oPosition = this.$self_$30769.transform.position;
									if (72925 - 369731 == -296805)
									{
										continue;
									}
									this.$self_$30769.MC4uA8fG6N.nDirection = this.$self_$30769.transform.forward;
									if (77465 - 402948 == -325482)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (33266 - 327010 != -293743)
						{
							goto Block_25;
						}
						continue;
					default:
						if (166971 - 302805 != -135834)
						{
							continue;
						}
						break;
					}
					this.$self_$30769.MC4uA8fG6N.actionState = "attack";
					if (169636 - 459722 == -290086)
					{
						this.$self_$30769.MC4uA8fG6N.actionTime = Time.time;
						if (199027 - 122212 == 76815)
						{
							this.$self_$30769.MC4uA8fG6N.myCommand = "missile";
							if (9085 - 66903 == -57818)
							{
								this.$self_$30769.MC4uA8fG6N.addTimeOut("missile", (float)12);
								if (100490 - 200837 != -100346)
								{
									this.$self_$30769.transform.position = this.$mPos$30766;
									if (89204 - 64556 != 24649)
									{
										this.$self_$30769.transform.LookAt(this.$mPos$30766 + global::Math.vFlat(this.$tDir$30767));
										if (166817 - 136216 == 30601)
										{
											this.$self_$30769.animation.CrossFade("missile");
											if (221700 - 599567 != -377866)
											{
												this.$self_$30769.animation.wrapMode = WrapMode.Once;
												if (105944 - 374703 != -268758)
												{
													this.$self_$30769.MC4uA8fG6N.vMovement = this.$self_$30769.transform.forward;
													if (26889 - 29592 == -2703)
													{
														this.$self_$30769.MC4uA8fG6N.moveSpeed = (float)0;
														if (15395 - 324189 != -308793)
														{
															goto Block_47;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_212:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_25:
				goto IL_7BC;
				IL_483:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_47:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_7BC:
				return false;
			}

			// Token: 0x06003E0C RID: 15884 RVA: 0x007FE0A8 File Offset: 0x007FC2A8
			internal static bool swdTrE5O2NyBv53wGbpA()
			{
				return true;
			}

			// Token: 0x06003E0D RID: 15885 RVA: 0x007FE0AC File Offset: 0x007FC2AC
			internal static bool cr7GPd5O8vBhqHTfbNor()
			{
				return false;
			}

			// Token: 0x04004B3E RID: 19262
			internal int $i$30764;

			// Token: 0x04004B3F RID: 19263
			internal Transform $missile$30765;

			// Token: 0x04004B40 RID: 19264
			internal Vector3 $mPos$30766;

			// Token: 0x04004B41 RID: 19265
			internal Vector3 $tDir$30767;

			// Token: 0x04004B42 RID: 19266
			internal int $tID$30768;

			// Token: 0x04004B43 RID: 19267
			internal MissileBot $self_$30769;
		}
	}

	// Token: 0x02000AF3 RID: 2803
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_suicideBomb$30774 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003E0E RID: 15886 RVA: 0x007FE0B0 File Offset: 0x007FC2B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_suicideBomb$30774(Vector3 mPos, Vector3 tDir, MissileBot self_)
		{
			if (251592 - 137509 != 114083)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (191320 - 591484 != -400163)
				{
					base..ctor();
					if (198881 - 74501 == 124380)
					{
						this.$mPos$30778 = mPos;
						if (100959 - 182131 != -81171)
						{
							this.$tDir$30779 = tDir;
							if (278771 - 330748 != -51976)
							{
								this.$self_$30780 = self_;
								if (280692 - 55202 != 225491)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x007FE18C File Offset: 0x007FC38C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MissileBot.$RPC_suicideBomb$30774.$(this.$mPos$30778, this.$tDir$30779, this.$self_$30780);
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x007FE1A8 File Offset: 0x007FC3A8
		internal static bool zLdbSF5OZWhRjhZTrNXI()
		{
			return true;
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x007FE1AC File Offset: 0x007FC3AC
		internal static bool GbEB3f5OCkD84oRhaElT()
		{
			return false;
		}

		// Token: 0x04004B44 RID: 19268
		internal Vector3 $mPos$30778;

		// Token: 0x04004B45 RID: 19269
		internal Vector3 $tDir$30779;

		// Token: 0x04004B46 RID: 19270
		internal MissileBot $self_$30780;

		// Token: 0x02000AF4 RID: 2804
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003E12 RID: 15890 RVA: 0x007FE1B0 File Offset: 0x007FC3B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MissileBot self_)
			{
				if (57724 - 177603 != -119879)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293483 - 512295 == -218812)
					{
						base..ctor();
						if (55007 - 204520 == -149513)
						{
							this.$mPos$30775 = mPos;
							if (71798 - 339480 != -267681)
							{
								this.$tDir$30776 = tDir;
								if (167417 - 352380 == -184963)
								{
									this.$self_$30777 = self_;
									if (210903 - 515364 == -304461)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003E13 RID: 15891 RVA: 0x007FE28C File Offset: 0x007FC48C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (263963 - 564844 != -300881)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_47B;
					case 2:
						if (this.$self_$30777.MC4uA8fG6N.actionState == "attack")
						{
							if (174210 - 541946 == -367735)
							{
								continue;
							}
							if (this.$self_$30777.MC4uA8fG6N.myCommand == "suicideBomb")
							{
								if (122954 - 439155 == -316200)
								{
									continue;
								}
								if (this.$self_$30777.MC4uA8fG6N.isMine)
								{
									if (115577 - 201281 != -85704)
									{
										continue;
									}
									this.$self_$30777.RPC_suicideBomb_hit(this.$self_$30777.collider.bounds.center, this.$self_$30777.transform.forward, 0);
									if (696 - 229546 == -228849)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (218263 - 288221 == -69957)
										{
											continue;
										}
										this.$self_$30777.ActionEvent("RPC_suicideBomb_hit", this.$self_$30777.collider.bounds.center, this.$self_$30777.transform.forward, 0);
										if (222091 - 12916 != 209175)
										{
											continue;
										}
									}
								}
							}
						}
						this.YieldDefault(1);
						if (46508 - 447681 != -401173)
						{
							continue;
						}
						goto IL_47B;
					default:
						if (294686 - 537679 != -242993)
						{
							continue;
						}
						break;
					}
					this.$self_$30777.MC4uA8fG6N.actionState = "attack";
					if (40858 - 230575 != -189716)
					{
						this.$self_$30777.MC4uA8fG6N.actionTime = Time.time;
						if (273704 - 91581 == 182123)
						{
							this.$self_$30777.MC4uA8fG6N.myCommand = "suicideBomb";
							if (162947 - 70510 != 92438)
							{
								this.$self_$30777.MC4uA8fG6N.addTimeOut("suicideBomb", (float)30);
								if (76187 - 396918 == -320731)
								{
									this.$self_$30777.transform.position = this.$mPos$30775;
									if (202340 - 566856 != -364515)
									{
										this.$self_$30777.transform.LookAt(this.$mPos$30775 + global::Math.vFlat(this.$tDir$30776));
										if (151740 - 232740 == -81000)
										{
											this.$self_$30777.animation.CrossFade("suicideBomb");
											if (236328 - 402783 != -166454)
											{
												this.$self_$30777.animation.wrapMode = WrapMode.Once;
												if (73341 - 377030 == -303689)
												{
													this.$self_$30777.MC4uA8fG6N.vMovement = this.$self_$30777.transform.forward;
													if (176666 - 10496 == 166170)
													{
														this.$self_$30777.MC4uA8fG6N.moveSpeed = (float)0;
														if (110673 - 457335 != -346661)
														{
															if (this.$self_$30777.suicideBomb_ring)
															{
																if (10020 - 489167 != -479146)
																{
																	UnityEngine.Object.Instantiate(this.$self_$30777.suicideBomb_ring, this.$self_$30777.transform.position, this.$self_$30777.transform.rotation);
																	if (35221 - 299037 != -263815)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing suicideBomb_ring");
																if (262731 - 333820 != -71088)
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
				return this.Yield(2, new WaitForSeconds(1.8f));
				IL_47B:
				return false;
			}

			// Token: 0x06003E14 RID: 15892 RVA: 0x007FE728 File Offset: 0x007FC928
			internal static bool UlGRCL5OLLgukJ3b60Sp()
			{
				return true;
			}

			// Token: 0x06003E15 RID: 15893 RVA: 0x007FE72C File Offset: 0x007FC92C
			internal static bool HkmZSh5OObVU5flgh7TK()
			{
				return false;
			}

			// Token: 0x04004B47 RID: 19271
			internal Vector3 $mPos$30775;

			// Token: 0x04004B48 RID: 19272
			internal Vector3 $tDir$30776;

			// Token: 0x04004B49 RID: 19273
			internal MissileBot $self_$30777;
		}
	}

	// Token: 0x02000AF5 RID: 2805
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$30781 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003E16 RID: 15894 RVA: 0x007FE730 File Offset: 0x007FC930
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$30781(UnityScript.Lang.Array nArray, MissileBot self_)
		{
			if (25673 - 71297 != -45624)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (16447 - 209771 == -193324)
				{
					base..ctor();
					if (87521 - 6206 != 81316)
					{
						this.$nArray$30786 = nArray;
						if (133016 - 153789 != -20772)
						{
							this.$self_$30787 = self_;
							if (243725 - 416450 != -172724)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x007FE7EC File Offset: 0x007FC9EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MissileBot.$RPC_ko$30781.$(this.$nArray$30786, this.$self_$30787);
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x007FE800 File Offset: 0x007FCA00
		internal static bool KuoTQX5OmIZjoZXTIJeR()
		{
			return true;
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x007FE804 File Offset: 0x007FCA04
		internal static bool Bjrhf15OFgZ8kYhuM8TI()
		{
			return false;
		}

		// Token: 0x04004B4A RID: 19274
		internal UnityScript.Lang.Array $nArray$30786;

		// Token: 0x04004B4B RID: 19275
		internal MissileBot $self_$30787;

		// Token: 0x02000AF6 RID: 2806
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003E1A RID: 15898 RVA: 0x007FE808 File Offset: 0x007FCA08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MissileBot self_)
			{
				if (183257 - 575055 != -391797)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (257416 - 186482 != 70935)
					{
						base..ctor();
						if (118319 - 573950 != -455630)
						{
							this.$nArray$30784 = nArray;
							if (261356 - 8540 != 252817)
							{
								this.$self_$30785 = self_;
								if (255517 - 128905 == 126612)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003E1B RID: 15899 RVA: 0x007FE8C4 File Offset: 0x007FCAC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (219069 - 205410 != 13659)
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
						if (this.$self_$30785.MC4uA8fG6N.actionState != "ko")
						{
							if (234843 - 262691 != -27848)
							{
								continue;
							}
							goto IL_2D7;
						}
						else
						{
							this.$self_$30785.animation.Play("getUp");
							if (267107 - 56395 == 210713)
							{
								continue;
							}
							this.$self_$30785.animation.wrapMode = WrapMode.Once;
							if (99766 - 461246 != -361480)
							{
								continue;
							}
							goto IL_288;
						}
						break;
					case 3:
						if (this.$self_$30785.MC4uA8fG6N.actionState != "ko")
						{
							if (121837 - 77025 != 44812)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$self_$30785.MC4uA8fG6N.actionState = "standby";
							if (175342 - 186105 != -10763)
							{
								continue;
							}
							this.$self_$30785.MC4uA8fG6N.actionTime = Time.time;
							if (137948 - 527832 != -389884)
							{
								continue;
							}
							this.$self_$30785.MC4uA8fG6N.myCommand = "none";
							if (188013 - 254955 != -66942)
							{
								continue;
							}
							this.$self_$30785.MC4uA8fG6N.ko = this.$self_$30785.MC4uA8fG6N.mko;
							if (180280 - 432111 == -251830)
							{
								continue;
							}
							this.YieldDefault(1);
							if (190830 - 330464 != -139634)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (174832 - 403398 == -228565)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30785.MC4uA8fG6N.actionState == "ko")
					{
						break;
					}
					if (267528 - 579517 == -311989)
					{
						if (this.$self_$30785.MC4uA8fG6N.actionState == "dead")
						{
							if (170956 - 93331 == 77625)
							{
								break;
							}
						}
						else
						{
							this.$mPos$30782 = (Vector3)this.$nArray$30784[0];
							if (13101 - 350747 == -337646)
							{
								this.$mDir$30783 = (Vector3)this.$nArray$30784[1];
								if (156201 - 595375 != -439173)
								{
									this.$self_$30785.MC4uA8fG6N.ko = 0;
									if (56738 - 531900 != -475161)
									{
										this.$self_$30785.MC4uA8fG6N.actionState = "ko";
										if (299687 - 358320 != -58632)
										{
											this.$self_$30785.MC4uA8fG6N.actionTime = Time.time;
											if (22628 - 114878 == -92250)
											{
												this.$self_$30785.MC4uA8fG6N.myCommand = "none";
												if (181132 - 562852 == -381720)
												{
													this.$self_$30785.MC4uA8fG6N.vMovement = Vector3.zero;
													if (73530 - 81622 == -8092)
													{
														this.$self_$30785.MC4uA8fG6N.moveSpeed = (float)0;
														if (117005 - 387919 == -270914)
														{
															this.$self_$30785.animation.Play("ko");
															if (27717 - 428866 != -401148)
															{
																this.$self_$30785.animation.wrapMode = WrapMode.Once;
																if (294471 - 511440 != -216968)
																{
																	goto Block_16;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				goto IL_48C;
				Block_16:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_288:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_2D7:
				IL_48C:
				return false;
			}

			// Token: 0x06003E1C RID: 15900 RVA: 0x007FED70 File Offset: 0x007FCF70
			internal static bool rTMj3G5OM4trnaJbXALn()
			{
				return true;
			}

			// Token: 0x06003E1D RID: 15901 RVA: 0x007FED74 File Offset: 0x007FCF74
			internal static bool BQPxhr5OxI28ksgWyTyo()
			{
				return false;
			}

			// Token: 0x04004B4C RID: 19276
			internal Vector3 $mPos$30782;

			// Token: 0x04004B4D RID: 19277
			internal Vector3 $mDir$30783;

			// Token: 0x04004B4E RID: 19278
			internal UnityScript.Lang.Array $nArray$30784;

			// Token: 0x04004B4F RID: 19279
			internal MissileBot $self_$30785;
		}
	}

	// Token: 0x02000AF7 RID: 2807
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30788 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003E1E RID: 15902 RVA: 0x007FED78 File Offset: 0x007FCF78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30788(UnityScript.Lang.Array nArray, MissileBot self_)
		{
			if (136467 - 100138 != 36330)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (74937 - 498570 != -423632)
				{
					base..ctor();
					if (248216 - 296742 != -48525)
					{
						this.$nArray$30793 = nArray;
						if (136901 - 510161 != -373259)
						{
							this.$self_$30794 = self_;
							if (183999 - 293911 != -109911)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x007FEE34 File Offset: 0x007FD034
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MissileBot.$RPC_dead$30788.$(this.$nArray$30793, this.$self_$30794);
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x007FEE48 File Offset: 0x007FD048
		internal static bool dmr1i25OgbZTp42EP3xJ()
		{
			return true;
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x007FEE4C File Offset: 0x007FD04C
		internal static bool fUf7SD5Ofxaj7VBe1EE1()
		{
			return false;
		}

		// Token: 0x04004B50 RID: 19280
		internal UnityScript.Lang.Array $nArray$30793;

		// Token: 0x04004B51 RID: 19281
		internal MissileBot $self_$30794;

		// Token: 0x02000AF8 RID: 2808
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003E22 RID: 15906 RVA: 0x007FEE50 File Offset: 0x007FD050
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MissileBot self_)
			{
				if (13491 - 442719 != -429228)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (126893 - 295629 != -168735)
					{
						base..ctor();
						if (70520 - 43054 == 27466)
						{
							this.$nArray$30791 = nArray;
							if (202837 - 589165 != -386327)
							{
								this.$self_$30792 = self_;
								if (263132 - 595410 != -332277)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003E23 RID: 15907 RVA: 0x007FEF0C File Offset: 0x007FD10C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (216930 - 120946 != 95985)
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
						if (this.$self_$30792.MC4uA8fG6N.actionState != "dead")
						{
							if (246266 - 384076 != -137809)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30792.MC4uA8fG6N.isPlayer)
							{
								if (46898 - 504220 == -457321)
								{
									continue;
								}
								if (this.$self_$30792.deadEffect)
								{
									if (148770 - 298109 != -149339)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$30792.deadEffect, this.$self_$30792.transform.position, Quaternion.identity);
									if (1746 - 538044 != -536298)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing deadEffect");
									if (202604 - 167681 == 34924)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$30792.gameObject);
								if (134732 - 456512 == -321779)
								{
									continue;
								}
							}
							else if (this.$self_$30792.MC4uA8fG6N.isMine)
							{
								if (68626 - 333811 != -265185)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30792.gameObject);
								if (77107 - 18320 == 58788)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (90051 - 258004 != -167953)
							{
								continue;
							}
							goto IL_4C7;
						}
						break;
					default:
						if (50507 - 287961 != -237454)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30792.MC4uA8fG6N.actionState == "dead")
					{
						if (156456 - 231236 == -74780)
						{
							goto IL_271;
						}
					}
					else
					{
						this.$myPosition$30789 = (Vector3)this.$nArray$30791[0];
						if (28062 - 303497 == -275435)
						{
							this.$myDirection$30790 = (Vector3)this.$nArray$30791[1];
							if (251734 - 195685 == 56049)
							{
								this.$self_$30792.Gp3uFrmdQN.position = this.$myPosition$30789;
								if (12958 - 215636 != -202677)
								{
									this.$self_$30792.Gp3uFrmdQN.LookAt(this.$myPosition$30789 + this.$myDirection$30790);
									if (144321 - 16954 == 127367)
									{
										this.$self_$30792.MC4uA8fG6N.hp = 0;
										if (213890 - 564638 != -350747)
										{
											this.$self_$30792.MC4uA8fG6N.actionState = "dead";
											if (87609 - 501405 != -413795)
											{
												this.$self_$30792.MC4uA8fG6N.actionTime = Time.time;
												if (261794 - 303753 != -41958)
												{
													this.$self_$30792.MC4uA8fG6N.myCommand = "none";
													if (32524 - 550978 != -518453)
													{
														this.$self_$30792.MC4uA8fG6N.vMovement = Vector3.zero;
														if (147514 - 259387 == -111873)
														{
															this.$self_$30792.MC4uA8fG6N.moveSpeed = (float)0;
															if (161341 - 590955 != -429613)
															{
																this.$self_$30792.animation.Rewind();
																if (115251 - 314619 == -199368)
																{
																	this.$self_$30792.animation.Play("ko");
																	if (289568 - 216656 != 72913)
																	{
																		this.$self_$30792.animation.wrapMode = WrapMode.Once;
																		if (256298 - 535019 != -278720)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_14:
				IL_271:
				IL_4C7:
				return false;
			}

			// Token: 0x06003E24 RID: 15908 RVA: 0x007FF3F4 File Offset: 0x007FD5F4
			internal static bool T2bC925On2NguFGnHdGQ()
			{
				return true;
			}

			// Token: 0x06003E25 RID: 15909 RVA: 0x007FF3F8 File Offset: 0x007FD5F8
			internal static bool OTFcgR5O6l0VtuGLNfcZ()
			{
				return false;
			}

			// Token: 0x04004B52 RID: 19282
			internal Vector3 $myPosition$30789;

			// Token: 0x04004B53 RID: 19283
			internal Vector3 $myDirection$30790;

			// Token: 0x04004B54 RID: 19284
			internal UnityScript.Lang.Array $nArray$30791;

			// Token: 0x04004B55 RID: 19285
			internal MissileBot $self_$30792;
		}
	}
}
