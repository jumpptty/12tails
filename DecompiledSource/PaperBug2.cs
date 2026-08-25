using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000164 RID: 356
[Serializable]
public class PaperBug2 : MonoBehaviour
{
	// Token: 0x060007FB RID: 2043 RVA: 0x000D0818 File Offset: 0x000CEA18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PaperBug2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x000D0828 File Offset: 0x000CEA28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (175624 - 253473 != -77848)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (63030 - 180028 != -116997)
			{
				this.mChar.actionState = "standby";
				if (33904 - 228209 != -194304)
				{
					this.mChar.actionTime = Time.time;
					if (133378 - 57028 != 76351)
					{
						this.mChar.myCommand = "none";
						if (288187 - 8239 == 279948)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x000D0914 File Offset: 0x000CEB14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x000D0930 File Offset: 0x000CEB30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (68983 - 349369 != -280385)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (38563 - 575710 == -537146)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (74977 - 220212 != -145235)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_301;
					}
					if (163062 - 233960 != -70898)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (63558 - 354904 != -291346)
				{
					continue;
				}
			}
			IL_301:
			if (this.mChar.hp <= 0)
			{
				if (282208 - 81359 == 200850)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (246403 - 394371 != -147968)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (237839 - 13424 == 224416)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (101476 - 139335 != -37859)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (58597 - 515386 != -456789)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (160378 - 442857 != -282478)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (91746 - 70743 != 21004)
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
			if (167956 - 339513 != -171556)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (244520 - 476627 == -232107)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (11525 - 364919 == -353394)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (214891 - 37838 == 177053)
						{
							if (this.mChar.isMine)
							{
								if (201743 - 536436 != -334692)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (155446 - 43183 == 112263)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (296559 - 204101 == 92458)
										{
											this.mChar.KoEvent();
											if (1790 - 298987 != -297196)
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
								if (266060 - 511287 == -245227)
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

	// Token: 0x060007FF RID: 2047 RVA: 0x000D0D28 File Offset: 0x000CEF28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (86171 - 426782 != -340611)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (11556 - 5918 == 5638)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (290090 - 65935 != 224156 && 222707 - 40328 != 182380)
				{
					if (ActionName == "RPC_sleep")
					{
						if (280832 - 23627 == 257206)
						{
							continue;
						}
						v = 1;
						if (49455 - 530453 != -480998)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_fallingComet")
					{
						if (255884 - 259033 == -3148)
						{
							continue;
						}
						v = 2;
						if (281902 - 594182 == -312279)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_fallingComet_fire")
					{
						if (53645 - 396419 != -342774)
						{
							continue;
						}
						v = -2;
						if (264806 - 589490 == -324683)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (99496 - 25209 == 74288)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (45940 - 169975 == -124035)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (10984 - 417178 != -406193)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (160278 - 290723 == -130445)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (263144 - 155713 != 107432)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (191884 - 91483 != 100402)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (109043 - 37739 == 71304)
										{
											Hashtable hashtable = new Hashtable();
											if (240086 - 578504 != -338417)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (19846 - 80655 != -60808)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (277217 - 304678 != -27460)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (129744 - 586469 == -456725)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (229325 - 50034 == 179291)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (27617 - 196059 != -168441)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (60134 - 407741 == -347607)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (276682 - 215185 == 61497)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (111778 - 226168 != -114389)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (59468 - 295973 != -236504)
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

	// Token: 0x06000800 RID: 2048 RVA: 0x000D11F4 File Offset: 0x000CF3F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (219612 - 426479 != -206866)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (53941 - 407167 != -353225)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (223011 - 410988 == -187977)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (194632 - 272949 == -78317)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (43851 - 118014 != -74162)
						{
							int num2 = num;
							if (170186 - 561932 == -391746)
							{
								if (num2 == 1)
								{
									if (79620 - 67040 != 12581)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (57635 - 584771 == -527136)
										{
											this.StartCoroutine_Auto(this.RPC_sleep(vector, vector2, tID));
											if (43515 - 233030 != -189514)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 2)
								{
									if (239392 - 583109 == -343717)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (114609 - 553871 == -439262)
										{
											this.StartCoroutine_Auto(this.RPC_fallingComet(vector, vector2, tID));
											if (123749 - 260855 != -137105)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -2)
								{
									if (70796 - 372127 != -301330)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (21654 - 231774 == -210120)
										{
											this.StartCoroutine_Auto(this.RPC_fallingComet_fire(vector, vector2, tID));
											if (166243 - 178199 == -11956)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (153846 - 553264 != -399417)
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

	// Token: 0x06000801 RID: 2049 RVA: 0x000D150C File Offset: 0x000CF70C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (179086 - 347921 != -168835)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (271564 - 566365 != -294800)
			{
				float runSpeed = this.mChar.runSpeed;
				if (31362 - 65626 == -34264)
				{
					Vector3 a = default(Vector3);
					if (53554 - 109987 == -56433)
					{
						Vector3 vector = Vector3.zero;
						if (153270 - 127271 != 26000)
						{
							float num2 = (float)0;
							if (104925 - 321744 != -216818)
							{
								if (this.mChar.isMine)
								{
									if (94977 - 152737 != -57760)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (204504 - 373440 != -168936)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (228365 - 281962 != -53597)
										{
											continue;
										}
										a.y = (float)0;
										if (37141 - 85071 == -47929)
										{
											continue;
										}
										a = a.normalized;
										if (197390 - 137293 == 60098)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (2701 - 111261 == -108559)
										{
											continue;
										}
										vector = vector.normalized;
										if (208807 - 451067 != -242260)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (220400 - 289051 == -68650)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (253971 - 596894 == -342922)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (231487 - 513328 == -281840)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (253110 - 210150 == 42961)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (138409 - 159383 != -20974)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (12056 - 383299 == -371242)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (134970 - 129733 != 5237)
														{
															continue;
														}
														this.animation.Play("run");
														if (211399 - 383663 != -172264)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (65100 - 399503 != -334402)
														{
															goto IL_905;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (54078 - 269737 != -215659)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (282422 - 568002 == -285579)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (264947 - 46402 == 218546)
											{
												continue;
											}
											num = (float)0;
											if (103208 - 34588 == 68621)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (170685 - 210714 == -40028)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (202914 - 25853 == 177062)
										{
											continue;
										}
									}
									IL_905:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (174124 - 9090 == 165035)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (35908 - 138972 == -103063)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (92439 - 271163 == -178723)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (123394 - 99215 == 24180)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (265911 - 497263 != -231352)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (166680 - 89536 == 77145)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (52301 - 159371 != -107070)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (78881 - 237167 != -158286)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (68699 - 16841 != 51858)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (90585 - 324831 != -234246)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (41926 - 22563 != 19363)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (100623 - 151286 == -50662)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (121025 - 521015 == -399989)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (282732 - 386271 != -103539)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (102817 - 433584 == -330766)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (257596 - 252149 == 5448)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (127747 - 113916 == 13832)
												{
													continue;
												}
												num = (float)0;
												if (35696 - 235894 != -200198)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (38674 - 337653 != -298979)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (40747 - 426 != 40321)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (161440 - 303907 == -142466)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (1859 - 339369 != -337510)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (5596 - 428480 == -422883)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (163268 - 438707 == -275438)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (245343 - 483751 != -238408)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (119365 - 200603 == -81237)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (63351 - 331320 != -267969)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (229377 - 335793 == -106415)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (54070 - 31094 != 22976)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (69443 - 24688 != 44755)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (255852 - 565442 == -309589)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (162820 - 480654 != -317834)
											{
												continue;
											}
											num = (float)0;
											if (204048 - 377050 == -173001)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (136206 - 80322 != 55884)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (172375 - 119898 != 52477)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (124132 - 163443 == -39310)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (113673 - 229613 == -115939)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (219759 - 510568 == -290809)
								{
									this.mChar.moveSpeed = num;
									if (44753 - 389991 != -345237)
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

	// Token: 0x06000802 RID: 2050 RVA: 0x000D2070 File Offset: 0x000D0270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (162611 - 128962 != 33649)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (122085 - 572024 == -449939)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (54999 - 96241 == -41242)
				{
					Vector3 vector = a - this.transform.position;
					if (101795 - 35609 != 66187)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (213555 - 28487 == 185068)
						{
							CharacterControl characterControl = null;
							if (49781 - 157678 == -107897)
							{
								if (gameObject)
								{
									if (168021 - 270807 == -102785)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (110039 - 497843 == -387803)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (43852 - 178117 != -134265)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (297528 - 315408 != -17880)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("sleep") != (float)0)
								{
									break;
								}
								if (99473 - 322463 != -222989)
								{
									if (!characterControl)
									{
										if (56229 - 243865 == -187636)
										{
											Camera.main.SendMessage("newGameMessage", "No valid target selected");
											if (223693 - 182038 != 41656)
											{
												break;
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_sleep(this.transform.position, vector, characterControl.ActorNr));
										if (133006 - 514251 != -381244)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (106949 - 502209 == -395260)
											{
												this.ActionEvent("RPC_sleep", this.transform.position, vector, characterControl.ActorNr);
												if (189869 - 537710 != -347840)
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

	// Token: 0x06000803 RID: 2051 RVA: 0x000D2368 File Offset: 0x000D0568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (106454 - 236012 != -129557)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (170783 - 264781 == -93998)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (171686 - 532957 == -361271)
				{
					Vector3 vector = a - this.transform.position;
					if (21918 - 327716 != -305797)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (5861 - 429983 != -424121)
						{
							if (30227 - 60838 == -30611)
							{
								if (gameObject)
								{
									if (79798 - 9707 == 70092)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (172963 - 50121 != 122842)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (235637 - 357317 == -121679)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (18709 - 208138 != -189429)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("fallingComet") != (float)0)
								{
									break;
								}
								if (200645 - 68129 != 132517)
								{
									this.StartCoroutine_Auto(this.RPC_fallingComet(this.transform.position, vector, 0));
									if (115842 - 272169 != -156326)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (109837 - 560415 == -450578)
										{
											this.ActionEvent("RPC_fallingComet", this.transform.position, vector, 0);
											if (265357 - 255192 == 10165)
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

	// Token: 0x06000804 RID: 2052 RVA: 0x000D25FC File Offset: 0x000D07FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x000D2600 File Offset: 0x000D0800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_sleep(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PaperBug2.$RPC_sleep$16631(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x000D2610 File Offset: 0x000D0810
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_fallingComet(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PaperBug2.$RPC_fallingComet$16643(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x000D2620 File Offset: 0x000D0820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_fallingComet_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		return new PaperBug2.$RPC_fallingComet_fire$16655(firePos, fireDir, this).GetEnumerator();
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x000D2630 File Offset: 0x000D0830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new PaperBug2.$RPC_ko$16668(nArray, this).GetEnumerator();
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x000D2640 File Offset: 0x000D0840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new PaperBug2.$RPC_dead$16675(nArray, this).GetEnumerator();
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x000D2650 File Offset: 0x000D0850
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x000D2654 File Offset: 0x000D0854
	internal static bool MQHoOqXmtrQyC7p63Ao()
	{
		return true;
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x000D2658 File Offset: 0x000D0858
	internal static bool uhy5hoXFeLmTYZaMq6y()
	{
		return false;
	}

	// Token: 0x0400073B RID: 1851
	public CharacterControl mChar;

	// Token: 0x0400073C RID: 1852
	public GameObject sleep;

	// Token: 0x0400073D RID: 1853
	public GameObject fallingComet;

	// Token: 0x02000165 RID: 357
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_sleep$16631 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600080D RID: 2061 RVA: 0x000D265C File Offset: 0x000D085C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_sleep$16631(Vector3 mPos, Vector3 tDir, int tID, PaperBug2 self_)
		{
			if (205787 - 66011 != 139776)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (100425 - 80449 == 19976)
				{
					base..ctor();
					if (54616 - 546450 != -491833)
					{
						this.$mPos$16639 = mPos;
						if (240081 - 138394 != 101688)
						{
							this.$tDir$16640 = tDir;
							if (289936 - 487032 == -197096)
							{
								this.$tID$16641 = tID;
								if (207594 - 26037 == 181557)
								{
									this.$self_$16642 = self_;
									if (83300 - 514663 == -431363)
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

		// Token: 0x0600080E RID: 2062 RVA: 0x000D275C File Offset: 0x000D095C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PaperBug2.$RPC_sleep$16631.$(this.$mPos$16639, this.$tDir$16640, this.$tID$16641, this.$self_$16642);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x000D277C File Offset: 0x000D097C
		internal static bool NgZilDXMqTh1rA4gvHB()
		{
			return true;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x000D2780 File Offset: 0x000D0980
		internal static bool MPtoSfXxBpkE3Jl3xFy()
		{
			return false;
		}

		// Token: 0x0400073E RID: 1854
		internal Vector3 $mPos$16639;

		// Token: 0x0400073F RID: 1855
		internal Vector3 $tDir$16640;

		// Token: 0x04000740 RID: 1856
		internal int $tID$16641;

		// Token: 0x04000741 RID: 1857
		internal PaperBug2 $self_$16642;

		// Token: 0x02000166 RID: 358
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000811 RID: 2065 RVA: 0x000D2784 File Offset: 0x000D0984
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, PaperBug2 self_)
			{
				if (132943 - 52352 != 80591)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (64262 - 473065 == -408803)
					{
						base..ctor();
						if (231890 - 150515 != 81376)
						{
							this.$mPos$16635 = mPos;
							if (296607 - 120151 != 176457)
							{
								this.$tDir$16636 = tDir;
								if (9673 - 82525 == -72852)
								{
									this.$tID$16637 = tID;
									if (276164 - 550837 != -274672)
									{
										this.$self_$16638 = self_;
										if (118447 - 465094 != -346646)
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

			// Token: 0x06000812 RID: 2066 RVA: 0x000D2884 File Offset: 0x000D0A84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (183494 - 101261 != 82233)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_783;
					case 2:
						if (this.$self_$16638.mChar.actionState != "attack")
						{
							goto IL_24D;
						}
						if (216426 - 75725 != 140701)
						{
							continue;
						}
						if (this.$self_$16638.mChar.myCommand != "sleep")
						{
							if (176137 - 205559 != -29422)
							{
								continue;
							}
							goto IL_24D;
						}
						else
						{
							this.$tObject$16632 = null;
							if (282190 - 21416 == 260775)
							{
								continue;
							}
							this.$tChar$16633 = null;
							if (107768 - 450939 != -343171)
							{
								continue;
							}
							if (this.$tID$16637 != 0)
							{
								if (243468 - 92961 != 150507)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$16637];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$16632 = (GameObject)obj2;
								if (109339 - 318345 != -209006)
								{
									continue;
								}
							}
							if (this.$tObject$16632)
							{
								if (20749 - 78680 != -57931)
								{
									continue;
								}
								this.$tChar$16633 = (CharacterControl)this.$tObject$16632.GetComponent(typeof(CharacterControl));
								if (26334 - 377057 == -350722)
								{
									continue;
								}
							}
							if (!this.$tChar$16633)
							{
								goto IL_4FC;
							}
							if (203723 - 292534 == -88810)
							{
								continue;
							}
							if (this.$self_$16638.sleep)
							{
								if (276475 - 317035 != -40560)
								{
									continue;
								}
								this.$tChar$16633.createEffect(this.$self_$16638.sleep, this.$tObject$16632.collider.bounds.center, Quaternion.identity);
								if (211458 - 134385 == 77074)
								{
									continue;
								}
							}
							if (!this.$self_$16638.mChar.isMine)
							{
								goto IL_4FC;
							}
							if (33695 - 89739 != -56044)
							{
								continue;
							}
							this.$mDuration$16634 = Damage.getDebuff((float)12, this.$self_$16638.mChar.cha, this.$tChar$16633.cha);
							if (103414 - 158107 != -54693)
							{
								continue;
							}
							this.$tChar$16633.RPC_AddStatus("sleep", 2, this.$mDuration$16634, 0, this.$self_$16638.mChar.ActorNr);
							if (130471 - 484342 != -353870)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16638.mChar.actionState == "attack")
						{
							if (73115 - 598610 == -525494)
							{
								continue;
							}
							if (this.$self_$16638.mChar.myCommand == "sleep")
							{
								if (250972 - 474352 == -223379)
								{
									continue;
								}
								this.$self_$16638.mChar.actionState = "standby";
								if (157080 - 65995 == 91086)
								{
									continue;
								}
								this.$self_$16638.mChar.actionTime = Time.time;
								if (179277 - 176965 != 2312)
								{
									continue;
								}
								this.$self_$16638.mChar.myCommand = "none";
								if (9774 - 180602 == -170827)
								{
									continue;
								}
								if (!this.$self_$16638.mChar.isMine)
								{
									if (110260 - 557667 == -447406)
									{
										continue;
									}
									this.$self_$16638.mChar.nPosition = this.$self_$16638.transform.position;
									if (20163 - 582061 != -561898)
									{
										continue;
									}
									this.$self_$16638.mChar.oPosition = this.$self_$16638.transform.position;
									if (43899 - 343425 != -299526)
									{
										continue;
									}
									this.$self_$16638.mChar.nDirection = this.$self_$16638.transform.forward;
									if (80760 - 488446 != -407686)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (148560 - 244014 != -95453)
						{
							goto Block_48;
						}
						continue;
					default:
						if (213336 - 305042 == -91705)
						{
							continue;
						}
						break;
					}
					this.$self_$16638.mChar.actionState = "attack";
					if (5853 - 492732 != -486878)
					{
						this.$self_$16638.mChar.actionTime = Time.time;
						if (226511 - 119578 != 106934)
						{
							this.$self_$16638.mChar.myCommand = "sleep";
							if (222429 - 106479 != 115951)
							{
								this.$self_$16638.mChar.addTimeOut("sleep", (float)12);
								if (262007 - 40190 != 221818)
								{
									this.$self_$16638.transform.position = this.$mPos$16635;
									if (104722 - 85398 != 19325)
									{
										this.$self_$16638.transform.LookAt(this.$mPos$16635 + global::Math.vFlat(this.$tDir$16636));
										if (80132 - 575724 != -495591)
										{
											this.$self_$16638.animation.Rewind();
											if (89481 - 3036 == 86445)
											{
												this.$self_$16638.animation.CrossFade("cast");
												if (86721 - 511623 == -424902)
												{
													this.$self_$16638.animation.wrapMode = WrapMode.Once;
													if (25020 - 214973 == -189953)
													{
														this.$self_$16638.mChar.vMovement = this.$self_$16638.transform.forward;
														if (122823 - 413892 == -291069)
														{
															this.$self_$16638.mChar.moveSpeed = (float)0;
															if (163927 - 361661 != -197733)
															{
																goto Block_19;
															}
														}
													}
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
				goto IL_4FC;
				IL_24D:
				goto IL_783;
				Block_19:
				return this.Yield(2, new WaitForSeconds(4.4f));
				IL_4FC:
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_48:
				IL_783:
				return false;
			}

			// Token: 0x06000813 RID: 2067 RVA: 0x000D3028 File Offset: 0x000D1228
			internal static bool Ivg3XhXgNiO6pXw4hvb()
			{
				return true;
			}

			// Token: 0x06000814 RID: 2068 RVA: 0x000D302C File Offset: 0x000D122C
			internal static bool yH03GyXfcOTmmtpZNel()
			{
				return false;
			}

			// Token: 0x04000742 RID: 1858
			internal GameObject $tObject$16632;

			// Token: 0x04000743 RID: 1859
			internal CharacterControl $tChar$16633;

			// Token: 0x04000744 RID: 1860
			internal int $mDuration$16634;

			// Token: 0x04000745 RID: 1861
			internal Vector3 $mPos$16635;

			// Token: 0x04000746 RID: 1862
			internal Vector3 $tDir$16636;

			// Token: 0x04000747 RID: 1863
			internal int $tID$16637;

			// Token: 0x04000748 RID: 1864
			internal PaperBug2 $self_$16638;
		}
	}

	// Token: 0x02000167 RID: 359
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_fallingComet$16643 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x000D3030 File Offset: 0x000D1230
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_fallingComet$16643(Vector3 mPos, Vector3 tDir, int tID, PaperBug2 self_)
		{
			if (144874 - 80694 != 64180)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (284479 - 323026 == -38547)
				{
					base..ctor();
					if (227183 - 146309 == 80874)
					{
						this.$mPos$16651 = mPos;
						if (60467 - 64888 != -4420)
						{
							this.$tDir$16652 = tDir;
							if (166186 - 279774 != -113587)
							{
								this.$tID$16653 = tID;
								if (13334 - 583599 != -570264)
								{
									this.$self_$16654 = self_;
									if (53791 - 109063 != -55271)
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

		// Token: 0x06000816 RID: 2070 RVA: 0x000D3130 File Offset: 0x000D1330
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PaperBug2.$RPC_fallingComet$16643.$(this.$mPos$16651, this.$tDir$16652, this.$tID$16653, this.$self_$16654);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x000D3150 File Offset: 0x000D1350
		internal static bool q2vCSaXnNaqTyJopfcy()
		{
			return true;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000D3154 File Offset: 0x000D1354
		internal static bool DuXZdiX6R1sGsHKewum()
		{
			return false;
		}

		// Token: 0x04000749 RID: 1865
		internal Vector3 $mPos$16651;

		// Token: 0x0400074A RID: 1866
		internal Vector3 $tDir$16652;

		// Token: 0x0400074B RID: 1867
		internal int $tID$16653;

		// Token: 0x0400074C RID: 1868
		internal PaperBug2 $self_$16654;

		// Token: 0x02000168 RID: 360
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000819 RID: 2073 RVA: 0x000D3158 File Offset: 0x000D1358
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, PaperBug2 self_)
			{
				if (189521 - 79858 != 109663)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (28030 - 290239 != -262208)
					{
						base..ctor();
						if (274329 - 392728 == -118399)
						{
							this.$mPos$16647 = mPos;
							if (293273 - 489640 != -196366)
							{
								this.$tDir$16648 = tDir;
								if (115659 - 332115 == -216456)
								{
									this.$tID$16649 = tID;
									if (156837 - 280271 != -123433)
									{
										this.$self_$16650 = self_;
										if (22871 - 139484 != -116612)
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

			// Token: 0x0600081A RID: 2074 RVA: 0x000D3258 File Offset: 0x000D1458
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (93982 - 486498 != -392515)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_789;
					case 2:
						if (this.$self_$16650.mChar.actionState != "attack")
						{
							goto IL_173;
						}
						if (193264 - 330939 != -137675)
						{
							continue;
						}
						if (this.$self_$16650.mChar.myCommand != "fallingComet")
						{
							if (117469 - 363042 != -245572)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							this.$i$16644 = 0;
							if (208269 - 135722 != 72547)
							{
								continue;
							}
							goto IL_387;
						}
						break;
					case 3:
						if (this.$self_$16650.mChar.actionState != "attack")
						{
							goto IL_72D;
						}
						if (87838 - 134268 != -46430)
						{
							continue;
						}
						if (this.$self_$16650.mChar.myCommand != "fallingComet")
						{
							if (235966 - 90183 != 145784)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$i$16644++;
							if (90887 - 207622 != -116734)
							{
								goto IL_387;
							}
							continue;
						}
						break;
					default:
						if (109096 - 365005 != -255909)
						{
							continue;
						}
						break;
					}
					this.$self_$16650.mChar.actionState = "attack";
					if (279553 - 266295 != 13258)
					{
						continue;
					}
					this.$self_$16650.mChar.actionTime = Time.time;
					if (191963 - 93688 == 98276)
					{
						continue;
					}
					this.$self_$16650.mChar.myCommand = "fallingComet";
					if (50963 - 567154 != -516191)
					{
						continue;
					}
					this.$self_$16650.mChar.addTimeOut("fallingComet", (float)12);
					if (244830 - 45132 == 199699)
					{
						continue;
					}
					this.$self_$16650.transform.position = this.$mPos$16647;
					if (278495 - 220141 == 58355)
					{
						continue;
					}
					this.$self_$16650.transform.LookAt(this.$mPos$16647 + global::Math.vFlat(this.$tDir$16648));
					if (254421 - 17646 == 236776)
					{
						continue;
					}
					this.$self_$16650.animation.Rewind();
					if (220810 - 447219 == -226408)
					{
						continue;
					}
					this.$self_$16650.animation.CrossFade("cast");
					if (25817 - 479657 != -453840)
					{
						continue;
					}
					this.$self_$16650.animation.wrapMode = WrapMode.Once;
					if (68278 - 42658 != 25620)
					{
						continue;
					}
					this.$self_$16650.mChar.vMovement = this.$self_$16650.transform.forward;
					if (285164 - 500920 != -215756)
					{
						continue;
					}
					this.$self_$16650.mChar.moveSpeed = (float)0;
					if (200611 - 529105 != -328493)
					{
						goto Block_41;
					}
					continue;
					IL_387:
					if (this.$i$16644 >= 4)
					{
						if (197875 - 338780 == -140905)
						{
							if (this.$self_$16650.mChar.actionState == "attack")
							{
								if (200395 - 488159 == -287763)
								{
									continue;
								}
								if (this.$self_$16650.mChar.myCommand == "fallingComet")
								{
									if (32809 - 428093 == -395283)
									{
										continue;
									}
									this.$self_$16650.mChar.actionState = "standby";
									if (44016 - 459422 == -415405)
									{
										continue;
									}
									this.$self_$16650.mChar.actionTime = Time.time;
									if (189884 - 586285 == -396400)
									{
										continue;
									}
									this.$self_$16650.mChar.myCommand = "none";
									if (234662 - 105508 == 129155)
									{
										continue;
									}
									if (!this.$self_$16650.mChar.isMine)
									{
										if (146570 - 154223 != -7653)
										{
											continue;
										}
										this.$self_$16650.mChar.nPosition = this.$self_$16650.transform.position;
										if (115530 - 327110 == -211579)
										{
											continue;
										}
										this.$self_$16650.mChar.oPosition = this.$self_$16650.transform.position;
										if (13664 - 510457 != -496793)
										{
											continue;
										}
										this.$self_$16650.mChar.nDirection = this.$self_$16650.transform.forward;
										if (203122 - 560357 != -357235)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (93519 - 160547 != -67027)
							{
								break;
							}
						}
					}
					else
					{
						if (!this.$self_$16650.mChar.isMine)
						{
							goto IL_6DE;
						}
						if (66728 - 153257 == -86529)
						{
							this.$firePos$16645 = global::Math.getSpawnPos(this.$mPos$16647 + this.$tDir$16648 + new Vector3((float)UnityEngine.Random.Range(-5, 5), (float)0, (float)UnityEngine.Random.Range(-5, 5)));
							if (150676 - 146392 != 4285)
							{
								this.$fireDir$16646 = global::Math.vFlat(this.$firePos$16645 - this.$self_$16650.transform.position);
								if (161782 - 355009 != -193226)
								{
									if (!(this.$firePos$16645 != Vector3.zero))
									{
										goto IL_6DE;
									}
									if (230711 - 77418 != 153294)
									{
										this.$self_$16650.StartCoroutine_Auto(this.$self_$16650.RPC_fallingComet_fire(this.$firePos$16645, this.$fireDir$16646, this.$tID$16649));
										if (82497 - 298595 != -216097)
										{
											if (!PhotonClient.IsInitialized())
											{
												goto IL_6DE;
											}
											if (4270 - 252783 != -248512)
											{
												this.$self_$16650.ActionEvent("RPC_fallingComet_fire", this.$firePos$16645, this.$fireDir$16646, this.$tID$16649);
												if (33022 - 132811 != -99788)
												{
													goto Block_36;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_173:
				goto IL_789;
				Block_12:
				Block_31:
				goto IL_173;
				Block_36:
				goto IL_6DE;
				Block_41:
				return this.Yield(2, new WaitForSeconds(4.4f));
				IL_6DE:
				return this.Yield(3, new WaitForSeconds(0.15f));
				IL_72D:
				IL_789:
				return false;
			}

			// Token: 0x0600081B RID: 2075 RVA: 0x000D3A00 File Offset: 0x000D1C00
			internal static bool MtX8SuXiMc9QvFWHRLk()
			{
				return true;
			}

			// Token: 0x0600081C RID: 2076 RVA: 0x000D3A04 File Offset: 0x000D1C04
			internal static bool yb9cfEXKwNMdYius44Z()
			{
				return false;
			}

			// Token: 0x0400074D RID: 1869
			internal int $i$16644;

			// Token: 0x0400074E RID: 1870
			internal Vector3 $firePos$16645;

			// Token: 0x0400074F RID: 1871
			internal Vector3 $fireDir$16646;

			// Token: 0x04000750 RID: 1872
			internal Vector3 $mPos$16647;

			// Token: 0x04000751 RID: 1873
			internal Vector3 $tDir$16648;

			// Token: 0x04000752 RID: 1874
			internal int $tID$16649;

			// Token: 0x04000753 RID: 1875
			internal PaperBug2 $self_$16650;
		}
	}

	// Token: 0x02000169 RID: 361
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_fallingComet_fire$16655 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600081D RID: 2077 RVA: 0x000D3A08 File Offset: 0x000D1C08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_fallingComet_fire$16655(Vector3 firePos, Vector3 fireDir, PaperBug2 self_)
		{
			if (266027 - 153651 != 112377)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (135816 - 312249 != -176432)
				{
					base..ctor();
					if (287628 - 403008 == -115380)
					{
						this.$firePos$16665 = firePos;
						if (112268 - 78415 == 33853)
						{
							this.$fireDir$16666 = fireDir;
							if (38442 - 47982 != -9539)
							{
								this.$self_$16667 = self_;
								if (248023 - 369713 == -121690)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000D3AE4 File Offset: 0x000D1CE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PaperBug2.$RPC_fallingComet_fire$16655.$(this.$firePos$16665, this.$fireDir$16666, this.$self_$16667);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000D3B00 File Offset: 0x000D1D00
		internal static bool GIY8CdXdDSCrQn2pWIK()
		{
			return true;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000D3B04 File Offset: 0x000D1D04
		internal static bool Q1YpwNXJY8fgfgJi0tZ()
		{
			return false;
		}

		// Token: 0x04000754 RID: 1876
		internal Vector3 $firePos$16665;

		// Token: 0x04000755 RID: 1877
		internal Vector3 $fireDir$16666;

		// Token: 0x04000756 RID: 1878
		internal PaperBug2 $self_$16667;

		// Token: 0x0200016A RID: 362
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000821 RID: 2081 RVA: 0x000D3B08 File Offset: 0x000D1D08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 firePos, Vector3 fireDir, PaperBug2 self_)
			{
				if (231776 - 352817 != -121041)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (69918 - 443902 == -373984)
					{
						base..ctor();
						if (50957 - 221732 != -170774)
						{
							this.$firePos$16662 = firePos;
							if (177378 - 231799 == -54421)
							{
								this.$fireDir$16663 = fireDir;
								if (263340 - 338423 == -75083)
								{
									this.$self_$16664 = self_;
									if (298979 - 382156 == -83177)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000822 RID: 2082 RVA: 0x000D3BE4 File Offset: 0x000D1DE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (125429 - 94455 != 30974)
				{
				}
				do
				{
					IL_116:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_37A;
					case 2:
						if (this.$self_$16664.mChar.isMine)
						{
							if (170747 - 143570 != 27177)
							{
								continue;
							}
							this.$hitLayer$16656 = 130816 - (1 << this.$self_$16664.gameObject.layer);
							if (298185 - 482220 == -184034)
							{
								continue;
							}
							this.$hitList$16657 = Damage.FindAreaTarget(this.$firePos$16662, (float)4, (float)4, this.$hitLayer$16656);
							if (130139 - 29530 != 100609)
							{
								continue;
							}
							this.$hitDmg$16658 = this.$self_$16664.mChar.talAdjust(30);
							if (224486 - 439707 == -215220)
							{
								continue;
							}
							this.$$iterator$9981$16661 = UnityRuntimeServices.GetEnumerator(this.$hitList$16657);
							if (165910 - 179282 == -13371)
							{
								continue;
							}
							while (this.$$iterator$9981$16661.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9981$16661.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16659 = (GameObject)obj2;
								if (60234 - 80125 == -19890)
								{
									goto IL_116;
								}
								this.$hitDistance$16660 = (float)1 - 0.5f * ((this.$hitObject$16659.transform.position - this.$firePos$16662).magnitude / (float)4);
								if (224801 - 445601 != -220800)
								{
									goto IL_116;
								}
								UnityRuntimeServices.Update(this.$$iterator$9981$16661, this.$hitObject$16659);
								if (26648 - 30457 != -3809)
								{
									goto IL_116;
								}
								this.$self_$16664.mChar.hit(2, this.$hitObject$16659, Mathf.FloorToInt((float)this.$hitDmg$16658 * this.$hitDistance$16660), 0, 0, Vector3.zero);
								if (104915 - 383910 == -278994)
								{
									goto IL_116;
								}
								UnityRuntimeServices.Update(this.$$iterator$9981$16661, this.$hitObject$16659);
								if (2109 - 227530 == -225420)
								{
									goto IL_116;
								}
							}
							if (15368 - 249681 != -234313)
							{
								continue;
							}
						}
						goto IL_147;
					default:
						if (33680 - 117576 != -83896)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16664.fallingComet)
					{
						if (243806 - 77619 == 166188)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$16664.fallingComet, this.$firePos$16662, Quaternion.LookRotation(this.$fireDir$16663));
						if (170395 - 82163 != 88233)
						{
							goto Block_16;
						}
						continue;
					}
					else
					{
						Debug.LogError("Cannot find fallingComet Effect");
						if (277122 - 24765 != 252357)
						{
							continue;
						}
					}
					IL_147:
					this.YieldDefault(1);
				}
				while (8132 - 133489 == -125356);
				goto IL_37A;
				Block_16:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_37A:
				return false;
			}

			// Token: 0x06000823 RID: 2083 RVA: 0x000D3F80 File Offset: 0x000D2180
			internal static bool Kuu7hqXDqsKvol7uEMZ()
			{
				return true;
			}

			// Token: 0x06000824 RID: 2084 RVA: 0x000D3F84 File Offset: 0x000D2184
			internal static bool wribPqXvqyV8u7k9dGc()
			{
				return false;
			}

			// Token: 0x04000757 RID: 1879
			internal int $hitLayer$16656;

			// Token: 0x04000758 RID: 1880
			internal UnityScript.Lang.Array $hitList$16657;

			// Token: 0x04000759 RID: 1881
			internal int $hitDmg$16658;

			// Token: 0x0400075A RID: 1882
			internal GameObject $hitObject$16659;

			// Token: 0x0400075B RID: 1883
			internal float $hitDistance$16660;

			// Token: 0x0400075C RID: 1884
			internal IEnumerator $$iterator$9981$16661;

			// Token: 0x0400075D RID: 1885
			internal Vector3 $firePos$16662;

			// Token: 0x0400075E RID: 1886
			internal Vector3 $fireDir$16663;

			// Token: 0x0400075F RID: 1887
			internal PaperBug2 $self_$16664;
		}
	}

	// Token: 0x0200016B RID: 363
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16668 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000825 RID: 2085 RVA: 0x000D3F88 File Offset: 0x000D2188
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16668(UnityScript.Lang.Array nArray, PaperBug2 self_)
		{
			if (178018 - 47849 != 130170)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (181497 - 175637 != 5861)
				{
					base..ctor();
					if (217704 - 86761 != 130944)
					{
						this.$nArray$16673 = nArray;
						if (273764 - 226496 == 47268)
						{
							this.$self_$16674 = self_;
							if (112140 - 194380 != -82239)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000D4044 File Offset: 0x000D2244
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PaperBug2.$RPC_ko$16668.$(this.$nArray$16673, this.$self_$16674);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000D4058 File Offset: 0x000D2258
		internal static bool CQvo1RXRVVfwfLy4scy()
		{
			return true;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000D405C File Offset: 0x000D225C
		internal static bool QvNx3uXwqMlwrdyiWLU()
		{
			return false;
		}

		// Token: 0x04000760 RID: 1888
		internal UnityScript.Lang.Array $nArray$16673;

		// Token: 0x04000761 RID: 1889
		internal PaperBug2 $self_$16674;

		// Token: 0x0200016C RID: 364
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000829 RID: 2089 RVA: 0x000D4060 File Offset: 0x000D2260
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PaperBug2 self_)
			{
				if (41107 - 145049 != -103941)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (267883 - 207533 != 60351)
					{
						base..ctor();
						if (131515 - 199610 != -68094)
						{
							this.$nArray$16671 = nArray;
							if (186537 - 79497 != 107041)
							{
								this.$self_$16672 = self_;
								if (31035 - 543822 != -512786)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600082A RID: 2090 RVA: 0x000D411C File Offset: 0x000D231C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (219284 - 363120 != -143835)
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
						if (this.$self_$16672.mChar.actionState != "ko")
						{
							if (172670 - 497113 != -324442)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$16672.animation.Play("getUp");
							if (172301 - 462612 != -290311)
							{
								continue;
							}
							this.$self_$16672.animation.wrapMode = WrapMode.Once;
							if (66906 - 349761 != -282855)
							{
								continue;
							}
							goto IL_E9;
						}
						break;
					case 3:
						if (this.$self_$16672.mChar.actionState != "ko")
						{
							if (33130 - 362745 != -329614)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$self_$16672.mChar.actionState = "standby";
							if (197451 - 373976 != -176525)
							{
								continue;
							}
							this.$self_$16672.mChar.actionTime = Time.time;
							if (5038 - 156138 == -151099)
							{
								continue;
							}
							this.$self_$16672.mChar.myCommand = "none";
							if (76701 - 78050 == -1348)
							{
								continue;
							}
							this.$self_$16672.mChar.ko = this.$self_$16672.mChar.mko;
							if (63809 - 552803 != -488994)
							{
								continue;
							}
							this.YieldDefault(1);
							if (153318 - 108871 != 44447)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (157445 - 464726 != -307281)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16672.mChar.actionState == "ko")
					{
						goto IL_3E9;
					}
					if (47521 - 293418 != -245896)
					{
						if (this.$self_$16672.mChar.actionState == "dead")
						{
							if (79488 - 6921 == 72567)
							{
								goto IL_3E9;
							}
						}
						else
						{
							this.$mPos$16669 = (Vector3)this.$nArray$16671[0];
							if (219508 - 215652 == 3856)
							{
								this.$mDir$16670 = (Vector3)this.$nArray$16671[1];
								if (77478 - 287333 == -209855)
								{
									this.$self_$16672.mChar.ko = 0;
									if (128490 - 462569 != -334078)
									{
										this.$self_$16672.mChar.actionState = "ko";
										if (56858 - 272462 != -215603)
										{
											this.$self_$16672.mChar.actionTime = Time.time;
											if (296290 - 552871 != -256580)
											{
												this.$self_$16672.mChar.myCommand = "none";
												if (68386 - 248655 == -180269)
												{
													this.$self_$16672.mChar.vMovement = Vector3.zero;
													if (27058 - 580323 == -553265)
													{
														this.$self_$16672.mChar.moveSpeed = (float)0;
														if (33811 - 417357 != -383545)
														{
															this.$self_$16672.animation.Play("ko");
															if (135746 - 441478 == -305732)
															{
																this.$self_$16672.animation.wrapMode = WrapMode.Once;
																if (203307 - 256093 == -52786)
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
				Block_3:
				goto IL_48C;
				IL_E9:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_8:
				IL_3E9:
				IL_48C:
				return false;
			}

			// Token: 0x0600082B RID: 2091 RVA: 0x000D45C8 File Offset: 0x000D27C8
			internal static bool zUKjhhXqMFvZMPOkbrp()
			{
				return true;
			}

			// Token: 0x0600082C RID: 2092 RVA: 0x000D45CC File Offset: 0x000D27CC
			internal static bool zqVZcDX7ItpdK1wo5ct()
			{
				return false;
			}

			// Token: 0x04000762 RID: 1890
			internal Vector3 $mPos$16669;

			// Token: 0x04000763 RID: 1891
			internal Vector3 $mDir$16670;

			// Token: 0x04000764 RID: 1892
			internal UnityScript.Lang.Array $nArray$16671;

			// Token: 0x04000765 RID: 1893
			internal PaperBug2 $self_$16672;
		}
	}

	// Token: 0x0200016D RID: 365
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16675 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600082D RID: 2093 RVA: 0x000D45D0 File Offset: 0x000D27D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16675(UnityScript.Lang.Array nArray, PaperBug2 self_)
		{
			if (162708 - 326555 != -163847)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (68291 - 264144 == -195853)
				{
					base..ctor();
					if (230995 - 480115 != -249119)
					{
						this.$nArray$16680 = nArray;
						if (200409 - 303817 != -103407)
						{
							this.$self_$16681 = self_;
							if (222941 - 124287 == 98654)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x000D468C File Offset: 0x000D288C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PaperBug2.$RPC_dead$16675.$(this.$nArray$16680, this.$self_$16681);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x000D46A0 File Offset: 0x000D28A0
		internal static bool QP3ZTSXPq0CwoxY4OJC()
		{
			return true;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000D46A4 File Offset: 0x000D28A4
		internal static bool feolEmX08B36UMANunU()
		{
			return false;
		}

		// Token: 0x04000766 RID: 1894
		internal UnityScript.Lang.Array $nArray$16680;

		// Token: 0x04000767 RID: 1895
		internal PaperBug2 $self_$16681;

		// Token: 0x0200016E RID: 366
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000831 RID: 2097 RVA: 0x000D46A8 File Offset: 0x000D28A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PaperBug2 self_)
			{
				if (75421 - 455676 != -380254)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (124915 - 477565 != -352649)
					{
						base..ctor();
						if (157701 - 106352 != 51350)
						{
							this.$nArray$16678 = nArray;
							if (78318 - 188497 == -110179)
							{
								this.$self_$16679 = self_;
								if (179784 - 294773 != -114988)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000832 RID: 2098 RVA: 0x000D4764 File Offset: 0x000D2964
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (118326 - 548096 != -429770)
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
						if (this.$self_$16679.mChar.actionState != "dead")
						{
							if (10397 - 432450 != -422052)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							if (!this.$self_$16679.mChar.isPlayer)
							{
								if (137592 - 318171 != -180579)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$16679.gameObject);
								if (172631 - 399997 == -227365)
								{
									continue;
								}
							}
							else if (this.$self_$16679.mChar.isMine)
							{
								if (144295 - 354755 == -210459)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16679.gameObject);
								if (217071 - 481796 == -264724)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (141069 - 76786 != 64283)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (76438 - 531347 != -454909)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16679.mChar.actionState == "dead")
					{
						if (22940 - 303231 == -280291)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$16676 = (Vector3)this.$nArray$16678[0];
						if (212370 - 143924 == 68446)
						{
							this.$myDirection$16677 = (Vector3)this.$nArray$16678[1];
							if (202263 - 491472 == -289209)
							{
								this.$self_$16679.transform.position = this.$myPosition$16676;
								if (85140 - 104808 == -19668)
								{
									this.$self_$16679.transform.LookAt(this.$myPosition$16676 + this.$myDirection$16677);
									if (29288 - 251456 != -222167)
									{
										this.$self_$16679.mChar.hp = 0;
										if (82178 - 409796 == -327618)
										{
											this.$self_$16679.mChar.actionState = "dead";
											if (105002 - 72269 == 32733)
											{
												this.$self_$16679.mChar.actionTime = Time.time;
												if (208614 - 138036 != 70579)
												{
													this.$self_$16679.mChar.myCommand = "none";
													if (271259 - 263689 == 7570)
													{
														this.$self_$16679.mChar.vMovement = Vector3.zero;
														if (235454 - 533461 != -298006)
														{
															this.$self_$16679.mChar.moveSpeed = (float)0;
															if (49867 - 444986 == -395119)
															{
																this.$self_$16679.animation.Rewind();
																if (281549 - 427296 == -145747)
																{
																	this.$self_$16679.animation.Play("ko");
																	if (40418 - 508255 == -467837)
																	{
																		this.$self_$16679.animation.wrapMode = WrapMode.Once;
																		if (294476 - 125187 == 169289)
																		{
																			goto IL_335;
																		}
																	}
																}
															}
														}
													}
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
				IL_335:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				IL_42F:
				return false;
			}

			// Token: 0x06000833 RID: 2099 RVA: 0x000D4BB4 File Offset: 0x000D2DB4
			internal static bool XOmp0xXbdFHjU5Q0fec()
			{
				return true;
			}

			// Token: 0x06000834 RID: 2100 RVA: 0x000D4BB8 File Offset: 0x000D2DB8
			internal static bool YhJ2yhXuZbUK2tv3rAE()
			{
				return false;
			}

			// Token: 0x04000768 RID: 1896
			internal Vector3 $myPosition$16676;

			// Token: 0x04000769 RID: 1897
			internal Vector3 $myDirection$16677;

			// Token: 0x0400076A RID: 1898
			internal UnityScript.Lang.Array $nArray$16678;

			// Token: 0x0400076B RID: 1899
			internal PaperBug2 $self_$16679;
		}
	}
}
