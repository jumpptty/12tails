using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E13 RID: 3603
[Serializable]
public class Fay : MonoBehaviour
{
	// Token: 0x06005180 RID: 20864 RVA: 0x009F6E40 File Offset: 0x009F5040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Fay()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005181 RID: 20865 RVA: 0x009F6E50 File Offset: 0x009F5050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (50238 - 556604 != -506365)
		{
		}
		for (;;)
		{
			this.Y1LceUEmfo6 = this.transform;
			if (125632 - 429032 == -303400)
			{
				this.xrXceN3jUFK = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (37008 - 495936 == -458928)
				{
					this.xrXceN3jUFK.actionState = "standby";
					if (61215 - 333841 != -272625)
					{
						this.xrXceN3jUFK.actionTime = Time.time;
						if (202601 - 294042 == -91441)
						{
							this.xrXceN3jUFK.myCommand = "none";
							if (38226 - 348442 != -310215)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (186090 - 175811 != 10280)
								{
									this.xrXceN3jUFK.isMine = true;
									if (272887 - 55299 == 217588)
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

	// Token: 0x06005182 RID: 20866 RVA: 0x009F6FB0 File Offset: 0x009F51B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (8318 - 23050 != -14731)
		{
		}
		for (;;)
		{
			if (this.xrXceN3jUFK.isControlled)
			{
				if (91085 - 308580 == -217494)
				{
					continue;
				}
				if (!(this.xrXceN3jUFK.actionState == "standby"))
				{
					if (197080 - 100176 == 96905)
					{
						continue;
					}
					if (!(this.xrXceN3jUFK.actionState == "run"))
					{
						goto IL_3AF;
					}
					if (80603 - 324162 != -243559)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (185279 - 362106 == -176826)
				{
					continue;
				}
			}
			IL_3AF:
			if (this.xrXceN3jUFK.hp <= 0)
			{
				if (127616 - 85078 == 42539)
				{
					continue;
				}
				if (this.xrXceN3jUFK.actionState != "dead")
				{
					if (116042 - 141986 == -25943)
					{
						continue;
					}
					if (this.xrXceN3jUFK.isMine)
					{
						if (200920 - 540121 == -339200)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (280764 - 513880 == -233115)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (254286 - 357676 != -103390)
						{
							continue;
						}
						this.xrXceN3jUFK.DeadEvent();
						if (56142 - 61244 != -5101)
						{
							break;
						}
						continue;
					}
					else
					{
						this.xrXceN3jUFK.hp = 1;
						if (118908 - 36352 != 82557)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.xrXceN3jUFK.hp <= 0)
			{
				break;
			}
			if (42414 - 302020 != -259605)
			{
				if (this.xrXceN3jUFK.ko > 0)
				{
					break;
				}
				if (205380 - 521 == 204859)
				{
					if (!(this.xrXceN3jUFK.actionState != "ko"))
					{
						break;
					}
					if (289957 - 170023 != 119935)
					{
						if (!(this.xrXceN3jUFK.actionState != "dead"))
						{
							break;
						}
						if (91395 - 476039 == -384644)
						{
							if (this.xrXceN3jUFK.isMine)
							{
								if (47858 - 321243 == -273385)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (199645 - 121940 == 77705)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (201289 - 545721 != -344431)
										{
											this.xrXceN3jUFK.KoEvent();
											if (164219 - 11988 == 152231)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.xrXceN3jUFK.ko = 1;
								if (229828 - 209479 != 20350)
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

	// Token: 0x06005183 RID: 20867 RVA: 0x009F73A8 File Offset: 0x009F55A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (281493 - 231919 != 49575)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (64341 - 259658 == -195317)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (130713 - 236154 == -105441)
				{
					if (235218 - 565978 != -330759)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (252868 - 516137 != -263269)
							{
								continue;
							}
							v = 1;
							if (42428 - 478175 != -435747)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_magicLance")
						{
							if (140407 - 580373 != -439966)
							{
								continue;
							}
							v = 11;
							if (202391 - 209369 == -6977)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_magicLance_fire")
						{
							if (36506 - 61388 != -24882)
							{
								continue;
							}
							v = 12;
							if (238945 - 554790 != -315845)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_dispell")
						{
							if (77485 - 438489 == -361003)
							{
								continue;
							}
							v = 21;
							if (199555 - 39236 != 160319)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (189474 - 153808 == 35667)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (290984 - 81885 == 209099)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (175639 - 58752 != 116888)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (181192 - 18742 == 162450)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (93184 - 84952 == 8232)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (143199 - 52025 == 91174)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (253856 - 116655 == 137201)
											{
												Hashtable hashtable = new Hashtable();
												if (172904 - 430781 == -257877)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (17999 - 450360 == -432361)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (187071 - 265867 != -78795)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (83109 - 474846 == -391737)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (243862 - 478817 == -234955)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (151835 - 342539 == -190704)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (24392 - 68250 != -43857)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (207192 - 77250 == 129942)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (245216 - 36608 == 208608)
																				{
																					PhotonClient.SendEvent(this.xrXceN3jUFK.ActorNr, 74, hashtable, true, true);
																					if (144107 - 395814 == -251707)
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

	// Token: 0x06005184 RID: 20868 RVA: 0x009F78C0 File Offset: 0x009F5AC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (176292 - 152910 != 23382)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (23272 - 584799 != -561526)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (8416 - 474969 != -466552)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (156577 - 578202 != -421624)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (98846 - 126947 != -28100)
						{
							int num2 = num;
							if (76743 - 521386 != -444642)
							{
								if (num2 == 1)
								{
									if (264899 - 159554 == 105345)
									{
										if (this.xrXceN3jUFK.isMine)
										{
											break;
										}
										if (281041 - 257590 != 23452)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(mPos, tDir, tID));
											if (168713 - 572167 == -403454)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (177129 - 391518 == -214389)
									{
										if (this.xrXceN3jUFK.isMine)
										{
											break;
										}
										if (8337 - 380600 == -372263)
										{
											this.StartCoroutine_Auto(this.RPC_magicLance(mPos, tDir, tID));
											if (294158 - 53948 != 240211)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 12)
								{
									if (39974 - 464585 == -424611)
									{
										if (this.xrXceN3jUFK.isMine)
										{
											break;
										}
										if (144364 - 438473 == -294109)
										{
											this.StartCoroutine_Auto(this.RPC_magicLance_fire(mPos, tDir, tID));
											if (266929 - 71943 == 194986)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 21)
								{
									if (17893 - 488081 != -470187)
									{
										if (this.xrXceN3jUFK.isMine)
										{
											break;
										}
										if (38880 - 23068 != 15813)
										{
											this.StartCoroutine_Auto(this.RPC_dispell(mPos, tDir, tID));
											if (264582 - 404491 != -139908)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (223232 - 246499 != -23266)
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

	// Token: 0x06005185 RID: 20869 RVA: 0x009F7C54 File Offset: 0x009F5E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (218571 - 292771 != -74200)
		{
		}
		for (;;)
		{
			float num = this.xrXceN3jUFK.moveSpeed;
			if (206042 - 21302 == 184740)
			{
				float runSpeed = this.xrXceN3jUFK.runSpeed;
				if (140774 - 154550 != -13775)
				{
					Vector3 a = default(Vector3);
					if (201470 - 504189 == -302719)
					{
						Vector3 vector = Vector3.zero;
						if (35392 - 550368 != -514975)
						{
							float num2 = (float)0;
							if (203023 - 112434 == 90589)
							{
								if (this.xrXceN3jUFK.isMine)
								{
									if (133636 - 89267 == 44370)
									{
										continue;
									}
									if ((this.xrXceN3jUFK.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (225606 - 584770 != -359164)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (156561 - 243045 == -86483)
										{
											continue;
										}
										a.y = (float)0;
										if (204448 - 527869 != -323421)
										{
											continue;
										}
										a = a.normalized;
										if (76397 - 216122 == -139724)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (43487 - 560281 == -516793)
										{
											continue;
										}
										vector = vector.normalized;
										if (228217 - 15906 == 212312)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (182702 - 408105 != -225403)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (227938 - 59011 != 168927)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (134918 - 446722 == -311803)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (253207 - 379377 != -126170)
														{
															continue;
														}
														this.xrXceN3jUFK.actionState = "run";
														if (178624 - 487197 != -308573)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (18668 - 597925 != -579257)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (255523 - 388617 != -133094)
														{
															continue;
														}
														this.animation.Play("run");
														if (212899 - 113867 != 99032)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (103163 - 321415 != -218252)
														{
															continue;
														}
														goto IL_4B1;
													}
												}
											}
										}
										this.xrXceN3jUFK.actionState = "standby";
										if (182396 - 315630 == -133233)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (249490 - 242337 == 7154)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (98213 - 427807 != -329594)
											{
												continue;
											}
											num = (float)0;
											if (279104 - 459508 != -180404)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (160598 - 148270 == 12329)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (32558 - 475150 != -442592)
										{
											continue;
										}
									}
									IL_4B1:;
								}
								else
								{
									vector = global::Math.vFlat(this.xrXceN3jUFK.nPosition - this.transform.position);
									if (299429 - 390866 != -91437)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (287686 - 41197 != 246489)
									{
										continue;
									}
									if (this.xrXceN3jUFK.nSpeed != (float)0)
									{
										if (180014 - 370139 != -190125)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (234725 - 425345 == -190619)
											{
												continue;
											}
											this.transform.position = this.xrXceN3jUFK.nPosition;
											if (5915 - 397905 == -391989)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (156686 - 533406 != -376720)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (134975 - 193011 == -58035)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (248176 - 483925 == -235748)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.xrXceN3jUFK.nSpeed, (float)10 * Time.deltaTime);
												if (204712 - 173613 == 31100)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (8696 - 95040 == -86343)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (202929 - 572157 != -369228)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (82888 - 447770 != -364882)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (31678 - 318241 != -286563)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (28645 - 150710 == -122064)
											{
												continue;
											}
										}
										else if (Time.time > this.xrXceN3jUFK.nSpeed + 0.3f)
										{
											if (276700 - 284620 != -7920)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (80696 - 207835 == -127138)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (261311 - 283603 != -22292)
												{
													continue;
												}
												num = (float)0;
												if (171573 - 412115 == -240541)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.xrXceN3jUFK.nDirection);
											if (294783 - 109396 != 185387)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (47501 - 428311 == -380809)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (207102 - 522885 != -315783)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (150825 - 532206 != -381381)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (132431 - 195339 != -62908)
											{
												continue;
											}
											this.transform.position = this.xrXceN3jUFK.nPosition;
											if (84489 - 94025 == -9535)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (264326 - 227560 != 36766)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (140539 - 559149 != -418610)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (283774 - 561515 == -277740)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (27588 - 523604 != -496016)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (176455 - 498472 != -322017)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (121319 - 251500 == -130180)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (194973 - 572529 != -377556)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.xrXceN3jUFK.nDirection);
											if (127756 - 484532 != -356776)
											{
												continue;
											}
											num = (float)0;
											if (146469 - 125240 == 21230)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (181808 - 6535 == 175274)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (120440 - 510921 == -390480)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (17426 - 215984 != -198558)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (212517 - 182212 == 30306)
										{
											continue;
										}
									}
								}
								this.xrXceN3jUFK.vMovement = vector;
								if (33829 - 225262 != -191432)
								{
									this.xrXceN3jUFK.moveSpeed = num;
									if (176682 - 287236 == -110554)
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

	// Token: 0x06005186 RID: 20870 RVA: 0x009F87B8 File Offset: 0x009F69B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (257854 - 592881 != -335026)
		{
		}
		for (;;)
		{
			if (!this.xrXceN3jUFK.isMine)
			{
				if (203401 - 134371 != 69031)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (92308 - 259687 != -167378)
				{
					Vector3 tDir = a - this.transform.position;
					if (170481 - 580263 == -409782)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (112331 - 70249 == 42082)
						{
							CharacterControl characterControl = null;
							if (175815 - 42233 != 133583)
							{
								int tID = 0;
								if (96828 - 595709 == -498881)
								{
									if (gameObject)
									{
										if (240723 - 368116 != -127393)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (287953 - 262232 == 25722)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (287109 - 458803 == -171693)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (55454 - 84692 != -29238)
										{
											continue;
										}
									}
									if (!(this.xrXceN3jUFK.actionState == "standby"))
									{
										if (276938 - 194473 != 82465)
										{
											continue;
										}
										if (!(this.xrXceN3jUFK.actionState == "run"))
										{
											break;
										}
										if (207895 - 478585 == -270689)
										{
											continue;
										}
									}
									if (this.xrXceN3jUFK.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (294483 - 281160 != 13324)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, tDir, tID));
										if (68842 - 352779 != -283936)
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

	// Token: 0x06005187 RID: 20871 RVA: 0x009F8A5C File Offset: 0x009F6C5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (199470 - 524224 != -324753)
		{
		}
		for (;;)
		{
			if (!this.xrXceN3jUFK.isMine)
			{
				if (11873 - 57749 != -45875)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (151528 - 318158 == -166630)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (155436 - 250738 == -95302)
					{
						Vector3 normalized = vector.normalized;
						if (211420 - 107306 != 104115)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (114225 - 372012 == -257787)
							{
								CharacterControl characterControl = null;
								if (231352 - 233033 == -1681)
								{
									int tID = 0;
									if (207974 - 100046 != 107929)
									{
										if (gameObject)
										{
											if (225500 - 426342 == -200841)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (6834 - 410088 != -403254)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (250015 - 279852 == -29836)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (26435 - 16808 == 9628)
											{
												continue;
											}
										}
										if (!(this.xrXceN3jUFK.actionState == "standby"))
										{
											if (144687 - 63525 == 81163)
											{
												continue;
											}
											if (!(this.xrXceN3jUFK.actionState == "run"))
											{
												break;
											}
											if (251464 - 52920 == 198545)
											{
												continue;
											}
										}
										if (this.xrXceN3jUFK.isTimeOut("dispell") == (float)0)
										{
											if (61978 - 169022 == -107044)
											{
												this.StartCoroutine_Auto(this.RPC_dispell(this.transform.position, normalized, tID));
												if (114133 - 186984 == -72851)
												{
													break;
												}
											}
										}
										else
										{
											if (this.xrXceN3jUFK.isTimeOut("magicLance") != (float)0)
											{
												break;
											}
											if (60047 - 274963 == -214916)
											{
												this.StartCoroutine_Auto(this.RPC_magicLance(this.transform.position, normalized, tID));
												if (276767 - 124643 != 152125)
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

	// Token: 0x06005188 RID: 20872 RVA: 0x009F8D98 File Offset: 0x009F6F98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06005189 RID: 20873 RVA: 0x009F8D9C File Offset: 0x009F6F9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Fay.$RPC_nAttack$33852(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600518A RID: 20874 RVA: 0x009F8DAC File Offset: 0x009F6FAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_magicLance(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Fay.$RPC_magicLance$33864(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600518B RID: 20875 RVA: 0x009F8DBC File Offset: 0x009F6FBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_magicLance_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Fay.$RPC_magicLance_fire$33873(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600518C RID: 20876 RVA: 0x009F8DCC File Offset: 0x009F6FCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dispell(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Fay.$RPC_dispell$33886(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600518D RID: 20877 RVA: 0x009F8DDC File Offset: 0x009F6FDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Fay.$RPC_ko$33898(nArray, this).GetEnumerator();
	}

	// Token: 0x0600518E RID: 20878 RVA: 0x009F8DEC File Offset: 0x009F6FEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Fay.$RPC_dead$33905(nArray, this).GetEnumerator();
	}

	// Token: 0x0600518F RID: 20879 RVA: 0x009F8DFC File Offset: 0x009F6FFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005190 RID: 20880 RVA: 0x009F8E00 File Offset: 0x009F7000
	internal static bool Ccvnlp5rkeVsXfSPGkuZ()
	{
		return true;
	}

	// Token: 0x06005191 RID: 20881 RVA: 0x009F8E04 File Offset: 0x009F7004
	internal static bool fZomDJ5rGcnSfSQRL6BK()
	{
		return false;
	}

	// Token: 0x04005AEE RID: 23278
	private Transform Y1LceUEmfo6;

	// Token: 0x04005AEF RID: 23279
	private CharacterControl xrXceN3jUFK;

	// Token: 0x04005AF0 RID: 23280
	public GameObject cast_ring;

	// Token: 0x04005AF1 RID: 23281
	public GameObject nAttack_fire;

	// Token: 0x04005AF2 RID: 23282
	public GameObject magicLance_fire;

	// Token: 0x04005AF3 RID: 23283
	public GameObject dispell_ring;

	// Token: 0x02000E14 RID: 3604
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33852 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005192 RID: 20882 RVA: 0x009F8E08 File Offset: 0x009F7008
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33852(Vector3 mPos, Vector3 tDir, Fay self_)
		{
			if (295734 - 191094 != 104640)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (244285 - 481942 != -237656)
				{
					base..ctor();
					if (67485 - 153826 == -86341)
					{
						this.$mPos$33861 = mPos;
						if (174904 - 71744 == 103160)
						{
							this.$tDir$33862 = tDir;
							if (142167 - 559786 != -417618)
							{
								this.$self_$33863 = self_;
								if (62806 - 474325 != -411518)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x009F8EE4 File Offset: 0x009F70E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Fay.$RPC_nAttack$33852.$(this.$mPos$33861, this.$tDir$33862, this.$self_$33863);
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x009F8F00 File Offset: 0x009F7100
		internal static bool BYS7DA5rHDyeFJDn0KrF()
		{
			return true;
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x009F8F04 File Offset: 0x009F7104
		internal static bool KVWuo15rWT4K3lFx0VWo()
		{
			return false;
		}

		// Token: 0x04005AF4 RID: 23284
		internal Vector3 $mPos$33861;

		// Token: 0x04005AF5 RID: 23285
		internal Vector3 $tDir$33862;

		// Token: 0x04005AF6 RID: 23286
		internal Fay $self_$33863;

		// Token: 0x02000E15 RID: 3605
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005196 RID: 20886 RVA: 0x009F8F08 File Offset: 0x009F7108
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Fay self_)
			{
				if (152355 - 596251 != -443895)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (76194 - 488121 == -411927)
					{
						base..ctor();
						if (22969 - 273017 != -250047)
						{
							this.$mPos$33858 = mPos;
							if (182361 - 166322 == 16039)
							{
								this.$tDir$33859 = tDir;
								if (225855 - 415431 == -189576)
								{
									this.$self_$33860 = self_;
									if (129992 - 285830 != -155837)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005197 RID: 20887 RVA: 0x009F8FE4 File Offset: 0x009F71E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (32001 - 328643 != -296641)
				{
				}
				for (;;)
				{
					IL_70:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8C7;
					case 2:
						if (this.$self_$33860.xrXceN3jUFK.actionState != "attack")
						{
							goto IL_6EA;
						}
						if (168482 - 332733 != -164251)
						{
							continue;
						}
						if (this.$self_$33860.xrXceN3jUFK.myCommand != "nAttack")
						{
							if (126551 - 469996 != -343444)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							if (this.$self_$33860.cast_ring)
							{
								if (172027 - 47160 != 124867)
								{
									continue;
								}
								this.$self_$33860.xrXceN3jUFK.createEffect(this.$self_$33860.cast_ring, this.$self_$33860.transform.position, this.$self_$33860.transform.rotation);
								if (20034 - 517693 != -497659)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing cast_ring effect");
								if (68844 - 560650 == -491805)
								{
									continue;
								}
							}
							this.$firePos$33853 = this.$mPos$33858 + this.$tDir$33859;
							if (119664 - 390458 == -270793)
							{
								continue;
							}
							if (this.$self_$33860.nAttack_fire)
							{
								if (286579 - 289997 != -3418)
								{
									continue;
								}
								this.$self_$33860.xrXceN3jUFK.createEffect(this.$self_$33860.nAttack_fire, this.$firePos$33853, this.$self_$33860.transform.rotation);
								if (110936 - 471508 != -360571)
								{
									goto Block_47;
								}
								continue;
							}
							else
							{
								Debug.LogError("Missing nAttack fire effect");
								if (237722 - 466539 != -228816)
								{
									goto Block_35;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$33860.xrXceN3jUFK.actionState != "attack")
						{
							goto IL_51E;
						}
						if (283309 - 533605 == -250295)
						{
							continue;
						}
						if (this.$self_$33860.xrXceN3jUFK.myCommand != "nAttack")
						{
							if (291638 - 15807 != 275832)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							this.$hitLayer$33854 = 130816 - (1 << this.$self_$33860.gameObject.layer);
							if (179042 - 327588 != -148546)
							{
								continue;
							}
							this.$hitList$33855 = null;
							if (194603 - 292754 == -98150)
							{
								continue;
							}
							if (!this.$self_$33860.xrXceN3jUFK.isMine)
							{
								goto IL_7F5;
							}
							if (226526 - 60213 != 166313)
							{
								continue;
							}
							this.$hitList$33855 = Damage.FindAreaTarget(this.$firePos$33853, (float)6, (float)4, this.$hitLayer$33854);
							if (117248 - 486978 == -369729)
							{
								continue;
							}
							this.$$iterator$10862$33857 = UnityRuntimeServices.GetEnumerator(this.$hitList$33855);
							if (202682 - 384061 == -181378)
							{
								continue;
							}
							while (this.$$iterator$10862$33857.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10862$33857.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33856 = (GameObject)obj2;
								if (31441 - 42855 == -11413)
								{
									goto IL_70;
								}
								this.$self_$33860.xrXceN3jUFK.hit(1, this.$hitObject$33856, this.$self_$33860.xrXceN3jUFK.atk, 2, 0, Vector3.zero);
								if (144215 - 457358 == -313142)
								{
									goto IL_70;
								}
								UnityRuntimeServices.Update(this.$$iterator$10862$33857, this.$hitObject$33856);
								if (265436 - 63939 != 201497)
								{
									goto IL_70;
								}
							}
							if (233659 - 108642 != 125017)
							{
								continue;
							}
							goto IL_7F5;
						}
						break;
					case 4:
						if (this.$self_$33860.xrXceN3jUFK.actionState == "attack")
						{
							if (246191 - 22847 == 223345)
							{
								continue;
							}
							if (this.$self_$33860.xrXceN3jUFK.myCommand == "nAttack")
							{
								if (70857 - 163416 != -92559)
								{
									continue;
								}
								this.$self_$33860.xrXceN3jUFK.actionState = "standby";
								if (203560 - 95637 != 107923)
								{
									continue;
								}
								this.$self_$33860.xrXceN3jUFK.actionTime = Time.time;
								if (222776 - 415031 != -192255)
								{
									continue;
								}
								this.$self_$33860.xrXceN3jUFK.myCommand = "none";
								if (152876 - 561530 != -408654)
								{
									continue;
								}
								if (!this.$self_$33860.xrXceN3jUFK.isMine)
								{
									if (41187 - 6825 != 34362)
									{
										continue;
									}
									this.$self_$33860.xrXceN3jUFK.nPosition = this.$self_$33860.transform.position;
									if (248121 - 515754 == -267632)
									{
										continue;
									}
									this.$self_$33860.xrXceN3jUFK.oPosition = this.$self_$33860.transform.position;
									if (17453 - 11226 != 6227)
									{
										continue;
									}
									this.$self_$33860.xrXceN3jUFK.nDirection = this.$self_$33860.transform.forward;
									if (116652 - 175200 != -58548)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (236899 - 564697 != -327797)
						{
							goto Block_48;
						}
						continue;
					default:
						if (117442 - 22499 == 94944)
						{
							continue;
						}
						break;
					}
					this.$self_$33860.xrXceN3jUFK.actionState = "attack";
					if (171318 - 169983 != 1336)
					{
						this.$self_$33860.xrXceN3jUFK.actionTime = Time.time;
						if (80216 - 223741 == -143525)
						{
							this.$self_$33860.xrXceN3jUFK.myCommand = "nAttack";
							if (79174 - 364666 != -285491)
							{
								this.$self_$33860.xrXceN3jUFK.addTimeOut("nAttack", (float)4);
								if (135619 - 187257 != -51637)
								{
									this.$self_$33860.transform.position = this.$mPos$33858;
									if (8015 - 375295 != -367279)
									{
										this.$self_$33860.transform.LookAt(this.$mPos$33858 + global::Math.vFlat(this.$tDir$33859));
										if (238407 - 289001 == -50594)
										{
											this.$self_$33860.animation.CrossFade("nAttack");
											if (96288 - 71627 == 24661)
											{
												this.$self_$33860.animation.wrapMode = WrapMode.Once;
												if (145631 - 292824 != -147192)
												{
													this.$self_$33860.xrXceN3jUFK.vMovement = this.$self_$33860.transform.forward;
													if (244710 - 303542 != -58831)
													{
														this.$self_$33860.xrXceN3jUFK.moveSpeed = (float)0;
														if (115338 - 141502 != -26163)
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
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_26B:
				return this.Yield(3, new WaitForSeconds(0.6f));
				Block_33:
				IL_51E:
				goto IL_8C7;
				Block_35:
				goto IL_26B;
				Block_42:
				IL_6EA:
				goto IL_8C7;
				Block_47:
				goto IL_26B;
				Block_48:
				goto IL_8C7;
				IL_7F5:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_8C7:
				return false;
			}

			// Token: 0x06005198 RID: 20888 RVA: 0x009F98CC File Offset: 0x009F7ACC
			internal static bool JcVEoa5rA0V7LnvsFTm9()
			{
				return true;
			}

			// Token: 0x06005199 RID: 20889 RVA: 0x009F98D0 File Offset: 0x009F7AD0
			internal static bool SBoAg45rleQFgaDra3qC()
			{
				return false;
			}

			// Token: 0x04005AF7 RID: 23287
			internal Vector3 $firePos$33853;

			// Token: 0x04005AF8 RID: 23288
			internal int $hitLayer$33854;

			// Token: 0x04005AF9 RID: 23289
			internal UnityScript.Lang.Array $hitList$33855;

			// Token: 0x04005AFA RID: 23290
			internal GameObject $hitObject$33856;

			// Token: 0x04005AFB RID: 23291
			internal IEnumerator $$iterator$10862$33857;

			// Token: 0x04005AFC RID: 23292
			internal Vector3 $mPos$33858;

			// Token: 0x04005AFD RID: 23293
			internal Vector3 $tDir$33859;

			// Token: 0x04005AFE RID: 23294
			internal Fay $self_$33860;
		}
	}

	// Token: 0x02000E16 RID: 3606
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_magicLance$33864 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600519A RID: 20890 RVA: 0x009F98D4 File Offset: 0x009F7AD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_magicLance$33864(Vector3 mPos, Vector3 tDir, int tID, Fay self_)
		{
			if (1168 - 133405 != -132237)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (9362 - 593437 != -584074)
				{
					base..ctor();
					if (206719 - 222881 == -16162)
					{
						this.$mPos$33869 = mPos;
						if (163558 - 22599 != 140960)
						{
							this.$tDir$33870 = tDir;
							if (251886 - 496136 == -244250)
							{
								this.$tID$33871 = tID;
								if (46798 - 288223 == -241425)
								{
									this.$self_$33872 = self_;
									if (43814 - 281512 == -237698)
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

		// Token: 0x0600519B RID: 20891 RVA: 0x009F99D4 File Offset: 0x009F7BD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Fay.$RPC_magicLance$33864.$(this.$mPos$33869, this.$tDir$33870, this.$tID$33871, this.$self_$33872);
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x009F99F4 File Offset: 0x009F7BF4
		internal static bool nHleSH5ryQZu7GkMNInB()
		{
			return true;
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x009F99F8 File Offset: 0x009F7BF8
		internal static bool hZZATW5rSRTdglW3OP7D()
		{
			return false;
		}

		// Token: 0x04005AFF RID: 23295
		internal Vector3 $mPos$33869;

		// Token: 0x04005B00 RID: 23296
		internal Vector3 $tDir$33870;

		// Token: 0x04005B01 RID: 23297
		internal int $tID$33871;

		// Token: 0x04005B02 RID: 23298
		internal Fay $self_$33872;

		// Token: 0x02000E17 RID: 3607
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600519E RID: 20894 RVA: 0x009F99FC File Offset: 0x009F7BFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Fay self_)
			{
				if (104403 - 267761 != -163358)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60806 - 493691 == -432885)
					{
						base..ctor();
						if (66400 - 39807 != 26594)
						{
							this.$mPos$33865 = mPos;
							if (262115 - 405309 == -143194)
							{
								this.$tDir$33866 = tDir;
								if (289301 - 171101 != 118201)
								{
									this.$tID$33867 = tID;
									if (53711 - 103659 == -49948)
									{
										this.$self_$33868 = self_;
										if (134555 - 575932 != -441376)
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

			// Token: 0x0600519F RID: 20895 RVA: 0x009F9AFC File Offset: 0x009F7CFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (145198 - 515713 != -370515)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_704;
					case 2:
						if (this.$self_$33868.xrXceN3jUFK.actionState != "attack")
						{
							goto IL_444;
						}
						if (66926 - 274766 != -207840)
						{
							continue;
						}
						if (this.$self_$33868.xrXceN3jUFK.myCommand != "magicLance")
						{
							if (83893 - 366897 != -283004)
							{
								continue;
							}
							goto IL_444;
						}
						else if (this.$self_$33868.cast_ring)
						{
							if (62491 - 461124 == -398632)
							{
								continue;
							}
							this.$self_$33868.xrXceN3jUFK.createEffect(this.$self_$33868.cast_ring, this.$self_$33868.transform.position, this.$self_$33868.transform.rotation);
							if (262814 - 183140 != 79675)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing cast_ring effect");
							if (229436 - 18451 != 210986)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33868.xrXceN3jUFK.actionState != "attack")
						{
							goto IL_204;
						}
						if (109907 - 504315 == -394407)
						{
							continue;
						}
						if (this.$self_$33868.xrXceN3jUFK.myCommand != "magicLance")
						{
							if (23501 - 11785 != 11717)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33868.xrXceN3jUFK.isMine)
							{
								goto IL_EA;
							}
							if (178031 - 554511 != -376480)
							{
								continue;
							}
							this.$self_$33868.StartCoroutine_Auto(this.$self_$33868.RPC_magicLance_fire(this.$self_$33868.Y1LceUEmfo6.position, this.$tDir$33866, this.$tID$33867));
							if (57607 - 588029 != -530422)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_EA;
							}
							if (161072 - 593969 != -432897)
							{
								continue;
							}
							this.$self_$33868.ActionEvent("RPC_magicLance_fire", this.$self_$33868.Y1LceUEmfo6.position, this.$tDir$33866, this.$tID$33867);
							if (246366 - 481191 != -234824)
							{
								goto IL_EA;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$33868.xrXceN3jUFK.actionState == "attack")
						{
							if (293686 - 573700 == -280013)
							{
								continue;
							}
							if (this.$self_$33868.xrXceN3jUFK.myCommand == "magicLance")
							{
								if (181459 - 316163 == -134703)
								{
									continue;
								}
								this.$self_$33868.xrXceN3jUFK.actionState = "standby";
								if (60421 - 248944 == -188522)
								{
									continue;
								}
								this.$self_$33868.xrXceN3jUFK.actionTime = Time.time;
								if (243790 - 363850 != -120060)
								{
									continue;
								}
								this.$self_$33868.xrXceN3jUFK.myCommand = "none";
								if (242462 - 212156 == 30307)
								{
									continue;
								}
								if (!this.$self_$33868.xrXceN3jUFK.isMine)
								{
									if (21309 - 549413 == -528103)
									{
										continue;
									}
									this.$self_$33868.xrXceN3jUFK.nPosition = this.$self_$33868.transform.position;
									if (297505 - 352270 != -54765)
									{
										continue;
									}
									this.$self_$33868.xrXceN3jUFK.oPosition = this.$self_$33868.transform.position;
									if (156666 - 302812 == -146145)
									{
										continue;
									}
									this.$self_$33868.xrXceN3jUFK.nDirection = this.$self_$33868.transform.forward;
									if (41286 - 86061 == -44774)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (270203 - 68311 != 201893)
						{
							goto Block_25;
						}
						continue;
					default:
						if (277192 - 411438 == -134245)
						{
							continue;
						}
						break;
					}
					this.$self_$33868.xrXceN3jUFK.actionState = "attack";
					if (151647 - 77416 != 74232)
					{
						this.$self_$33868.xrXceN3jUFK.actionTime = Time.time;
						if (188289 - 70610 == 117679)
						{
							this.$self_$33868.xrXceN3jUFK.myCommand = "magicLance";
							if (20456 - 492655 != -472198)
							{
								this.$self_$33868.xrXceN3jUFK.addTimeOut("magicLance", (float)15);
								if (249453 - 232491 == 16962)
								{
									this.$self_$33868.transform.position = this.$mPos$33865;
									if (291880 - 520255 != -228374)
									{
										this.$self_$33868.transform.LookAt(this.$mPos$33865 + global::Math.vFlat(this.$tDir$33866));
										if (285927 - 359565 != -73637)
										{
											this.$self_$33868.animation.CrossFade("cast");
											if (263148 - 593756 == -330608)
											{
												this.$self_$33868.animation.wrapMode = WrapMode.Once;
												if (100388 - 507140 != -406751)
												{
													this.$self_$33868.xrXceN3jUFK.vMovement = this.$self_$33868.transform.forward;
													if (68821 - 149105 == -80284)
													{
														this.$self_$33868.xrXceN3jUFK.moveSpeed = (float)0;
														if (211519 - 218704 == -7185)
														{
															goto IL_139;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_EA:
				return this.Yield(4, new WaitForSeconds(0.6f));
				IL_139:
				return this.Yield(2, new WaitForSeconds(1.5f));
				IL_204:
				goto IL_704;
				IL_2D0:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_25:
				IL_444:
				goto IL_704;
				Block_30:
				Block_32:
				goto IL_2D0;
				Block_38:
				IL_704:
				return false;
			}

			// Token: 0x060051A0 RID: 20896 RVA: 0x009FA220 File Offset: 0x009F8420
			internal static bool PiMBmZ5roFEsmDT4KQPE()
			{
				return true;
			}

			// Token: 0x060051A1 RID: 20897 RVA: 0x009FA224 File Offset: 0x009F8424
			internal static bool UtKrUo5rEJAOSu5CPtYS()
			{
				return false;
			}

			// Token: 0x04005B03 RID: 23299
			internal Vector3 $mPos$33865;

			// Token: 0x04005B04 RID: 23300
			internal Vector3 $tDir$33866;

			// Token: 0x04005B05 RID: 23301
			internal int $tID$33867;

			// Token: 0x04005B06 RID: 23302
			internal Fay $self_$33868;
		}
	}

	// Token: 0x02000E18 RID: 3608
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_magicLance_fire$33873 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060051A2 RID: 20898 RVA: 0x009FA228 File Offset: 0x009F8428
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_magicLance_fire$33873(Vector3 mPos, Vector3 tDir, Fay self_)
		{
			if (250695 - 394074 != -143379)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (223281 - 3660 == 219621)
				{
					base..ctor();
					if (147755 - 309962 == -162207)
					{
						this.$mPos$33883 = mPos;
						if (298237 - 106395 == 191842)
						{
							this.$tDir$33884 = tDir;
							if (157720 - 304060 == -146340)
							{
								this.$self_$33885 = self_;
								if (159311 - 418496 == -259185)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x009FA304 File Offset: 0x009F8504
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Fay.$RPC_magicLance_fire$33873.$(this.$mPos$33883, this.$tDir$33884, this.$self_$33885);
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x009FA320 File Offset: 0x009F8520
		internal static bool Q8oZiY5r26TEgSBkCVfj()
		{
			return true;
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x009FA324 File Offset: 0x009F8524
		internal static bool v5THEs5r8eu1LHcqA4Lf()
		{
			return false;
		}

		// Token: 0x04005B07 RID: 23303
		internal Vector3 $mPos$33883;

		// Token: 0x04005B08 RID: 23304
		internal Vector3 $tDir$33884;

		// Token: 0x04005B09 RID: 23305
		internal Fay $self_$33885;

		// Token: 0x02000E19 RID: 3609
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060051A6 RID: 20902 RVA: 0x009FA328 File Offset: 0x009F8528
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Fay self_)
			{
				if (153555 - 252331 != -98775)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (179268 - 224473 != -45204)
					{
						base..ctor();
						if (222269 - 550897 != -328627)
						{
							this.$mPos$33880 = mPos;
							if (142332 - 371367 == -229035)
							{
								this.$tDir$33881 = tDir;
								if (208871 - 257574 != -48702)
								{
									this.$self_$33882 = self_;
									if (17599 - 210610 != -193010)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060051A7 RID: 20903 RVA: 0x009FA404 File Offset: 0x009F8604
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (152408 - 80403 != 72006)
				{
				}
				for (;;)
				{
					IL_298:
					switch (this._state)
					{
					case 0:
						goto IL_34D;
					case 1:
						goto IL_3A6;
					case 2:
						this.$hitLayer$33875 = 130816 - (1 << this.$self_$33882.gameObject.layer);
						if (179032 - 95277 != 83755)
						{
							continue;
						}
						this.$hitList$33876 = Damage.FindRecTarget(this.$mPos$33880 + (float)(6 * this.$i$33874) * this.$tDir$33881, this.$tDir$33881, (float)5, (float)5, (float)10, (float)6, this.$hitLayer$33875);
						if (170978 - 131306 != 39672)
						{
							continue;
						}
						this.$hitDmg$33877 = this.$self_$33882.xrXceN3jUFK.talAdjust(80);
						if (9729 - 408050 == -398320)
						{
							continue;
						}
						this.$$iterator$10863$33879 = UnityRuntimeServices.GetEnumerator(this.$hitList$33876);
						if (120648 - 6144 != 114504)
						{
							continue;
						}
						while (this.$$iterator$10863$33879.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10863$33879.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$33878 = (GameObject)obj2;
							if (89633 - 324577 == -234943)
							{
								goto IL_298;
							}
							this.$self_$33882.xrXceN3jUFK.hit(11, this.$hitObject$33878, this.$hitDmg$33877, 2, 0, Vector3.zero);
							if (148727 - 504411 == -355683)
							{
								goto IL_298;
							}
							UnityRuntimeServices.Update(this.$$iterator$10863$33879, this.$hitObject$33878);
							if (135927 - 156501 != -20574)
							{
								goto IL_298;
							}
						}
						if (276124 - 274387 == 1738)
						{
							continue;
						}
						this.$i$33874++;
						if (157133 - 260802 != -103668)
						{
							goto IL_114;
						}
						continue;
					default:
						if (217741 - 175477 != 42265)
						{
							goto IL_34D;
						}
						continue;
					}
					IL_F2:
					this.YieldDefault(1);
					if (142404 - 143841 != -1436)
					{
						break;
					}
					continue;
					IL_114:
					if (this.$i$33874 < 6)
					{
						goto IL_1F7;
					}
					if (24509 - 79211 != -54702)
					{
						continue;
					}
					goto IL_F2;
					IL_34D:
					if (this.$self_$33882.magicLance_fire)
					{
						if (106027 - 339845 == -233817)
						{
							continue;
						}
						this.$self_$33882.xrXceN3jUFK.createEffect(this.$self_$33882.magicLance_fire, this.$self_$33882.transform.position, this.$self_$33882.transform.rotation);
						if (54528 - 385261 == -330732)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing magicLance_fire effect");
						if (231189 - 497456 == -266266)
						{
							continue;
						}
					}
					if (!this.$self_$33882.xrXceN3jUFK.isMine)
					{
						goto IL_F2;
					}
					if (71607 - 431574 != -359966)
					{
						this.$i$33874 = 0;
						if (171699 - 282992 == -111293)
						{
							goto IL_114;
						}
					}
				}
				goto IL_3A6;
				IL_1F7:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_3A6:
				return false;
			}

			// Token: 0x060051A8 RID: 20904 RVA: 0x009FA7CC File Offset: 0x009F89CC
			internal static bool iKKdNG5rZRcHC5s4BrEB()
			{
				return true;
			}

			// Token: 0x060051A9 RID: 20905 RVA: 0x009FA7D0 File Offset: 0x009F89D0
			internal static bool tjgZxc5rCLIoTwK1WalO()
			{
				return false;
			}

			// Token: 0x04005B0A RID: 23306
			internal int $i$33874;

			// Token: 0x04005B0B RID: 23307
			internal int $hitLayer$33875;

			// Token: 0x04005B0C RID: 23308
			internal UnityScript.Lang.Array $hitList$33876;

			// Token: 0x04005B0D RID: 23309
			internal int $hitDmg$33877;

			// Token: 0x04005B0E RID: 23310
			internal GameObject $hitObject$33878;

			// Token: 0x04005B0F RID: 23311
			internal IEnumerator $$iterator$10863$33879;

			// Token: 0x04005B10 RID: 23312
			internal Vector3 $mPos$33880;

			// Token: 0x04005B11 RID: 23313
			internal Vector3 $tDir$33881;

			// Token: 0x04005B12 RID: 23314
			internal Fay $self_$33882;
		}
	}

	// Token: 0x02000E1A RID: 3610
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dispell$33886 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060051AA RID: 20906 RVA: 0x009FA7D4 File Offset: 0x009F89D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dispell$33886(Vector3 mPos, Vector3 tDir, Fay self_)
		{
			if (9123 - 5644 != 3480)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (5919 - 175704 != -169784)
				{
					base..ctor();
					if (64102 - 211505 != -147402)
					{
						this.$mPos$33895 = mPos;
						if (84004 - 551583 == -467579)
						{
							this.$tDir$33896 = tDir;
							if (292702 - 467508 != -174805)
							{
								this.$self_$33897 = self_;
								if (92560 - 360622 == -268062)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060051AB RID: 20907 RVA: 0x009FA8B0 File Offset: 0x009F8AB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Fay.$RPC_dispell$33886.$(this.$mPos$33895, this.$tDir$33896, this.$self_$33897);
		}

		// Token: 0x060051AC RID: 20908 RVA: 0x009FA8CC File Offset: 0x009F8ACC
		internal static bool MshehB5rLOLgVVa7QkN5()
		{
			return true;
		}

		// Token: 0x060051AD RID: 20909 RVA: 0x009FA8D0 File Offset: 0x009F8AD0
		internal static bool aJyGrc5rOlquZo4dPgo4()
		{
			return false;
		}

		// Token: 0x04005B13 RID: 23315
		internal Vector3 $mPos$33895;

		// Token: 0x04005B14 RID: 23316
		internal Vector3 $tDir$33896;

		// Token: 0x04005B15 RID: 23317
		internal Fay $self_$33897;

		// Token: 0x02000E1B RID: 3611
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060051AE RID: 20910 RVA: 0x009FA8D4 File Offset: 0x009F8AD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Fay self_)
			{
				if (123586 - 393819 != -270232)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (22528 - 499871 != -477342)
					{
						base..ctor();
						if (142955 - 378931 != -235975)
						{
							this.$mPos$33892 = mPos;
							if (118199 - 572547 != -454347)
							{
								this.$tDir$33893 = tDir;
								if (83591 - 474142 != -390550)
								{
									this.$self_$33894 = self_;
									if (151533 - 228755 != -77221)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060051AF RID: 20911 RVA: 0x009FA9B0 File Offset: 0x009F8BB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (285837 - 130046 != 155791)
				{
				}
				for (;;)
				{
					IL_693:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_843;
					case 2:
						if (this.$self_$33894.xrXceN3jUFK.actionState != "attack")
						{
							goto IL_5C6;
						}
						if (220212 - 114653 == 105560)
						{
							continue;
						}
						if (this.$self_$33894.xrXceN3jUFK.myCommand != "dispell")
						{
							if (197857 - 156904 != 40953)
							{
								continue;
							}
							goto IL_5C6;
						}
						else if (this.$self_$33894.dispell_ring)
						{
							if (122720 - 274290 == -151569)
							{
								continue;
							}
							this.$self_$33894.xrXceN3jUFK.createEffect(this.$self_$33894.dispell_ring, this.$self_$33894.transform.position, this.$self_$33894.transform.rotation);
							if (298698 - 191356 != 107342)
							{
								continue;
							}
							goto IL_7BC;
						}
						else
						{
							Debug.LogError("Missing dispell_ring effect");
							if (259847 - 149688 != 110160)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33894.xrXceN3jUFK.actionState != "attack")
						{
							goto IL_1C6;
						}
						if (256422 - 535597 == -279174)
						{
							continue;
						}
						if (this.$self_$33894.xrXceN3jUFK.myCommand != "dispell")
						{
							if (19768 - 170910 != -151141)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33894.xrXceN3jUFK.isMine)
							{
								goto IL_148;
							}
							if (37882 - 460180 != -422298)
							{
								continue;
							}
							this.$hitLayer$33887 = 130818;
							if (10994 - 422039 != -411045)
							{
								continue;
							}
							this.$hitList$33888 = Damage.FindAreaTarget(this.$self_$33894.Y1LceUEmfo6.position, (float)60, (float)6, this.$hitLayer$33887);
							if (183994 - 358553 != -174559)
							{
								continue;
							}
							this.$tChar$33889 = null;
							if (188406 - 107212 != 81194)
							{
								continue;
							}
							this.$$iterator$10864$33891 = UnityRuntimeServices.GetEnumerator(this.$hitList$33888);
							if (60260 - 379958 == -319697)
							{
								continue;
							}
							while (this.$$iterator$10864$33891.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10864$33891.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33890 = (GameObject)obj2;
								if (285818 - 377693 == -91874)
								{
									goto IL_693;
								}
								this.$tChar$33889 = (CharacterControl)this.$hitObject$33890.GetComponent(typeof(CharacterControl));
								if (169098 - 181681 != -12583)
								{
									goto IL_693;
								}
								UnityRuntimeServices.Update(this.$$iterator$10864$33891, this.$hitObject$33890);
								if (153863 - 268223 != -114360)
								{
									goto IL_693;
								}
								if (this.$tChar$33889)
								{
									if (214588 - 250517 == -35928)
									{
										goto IL_693;
									}
									this.$tChar$33889.RPC_AddStatus("dispell", 5, 1, 0, this.$self_$33894.xrXceN3jUFK.ActorNr);
									if (133479 - 102691 != 30788)
									{
										goto IL_693;
									}
								}
							}
							if (45217 - 259445 != -214227)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$33894.xrXceN3jUFK.actionState == "attack")
						{
							if (91260 - 461419 != -370159)
							{
								continue;
							}
							if (this.$self_$33894.xrXceN3jUFK.myCommand == "dispell")
							{
								if (270795 - 401362 == -130566)
								{
									continue;
								}
								this.$self_$33894.xrXceN3jUFK.actionState = "standby";
								if (283202 - 424056 != -140854)
								{
									continue;
								}
								this.$self_$33894.xrXceN3jUFK.actionTime = Time.time;
								if (140531 - 500674 != -360143)
								{
									continue;
								}
								this.$self_$33894.xrXceN3jUFK.myCommand = "none";
								if (158417 - 404019 == -245601)
								{
									continue;
								}
								if (!this.$self_$33894.xrXceN3jUFK.isMine)
								{
									if (191496 - 195964 != -4468)
									{
										continue;
									}
									this.$self_$33894.xrXceN3jUFK.nPosition = this.$self_$33894.transform.position;
									if (111033 - 439672 != -328639)
									{
										continue;
									}
									this.$self_$33894.xrXceN3jUFK.oPosition = this.$self_$33894.transform.position;
									if (12553 - 395692 == -383138)
									{
										continue;
									}
									this.$self_$33894.xrXceN3jUFK.nDirection = this.$self_$33894.transform.forward;
									if (60715 - 324065 != -263350)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (28549 - 202742 != -174193)
						{
							continue;
						}
						goto IL_843;
					default:
						if (94835 - 568047 != -473212)
						{
							continue;
						}
						break;
					}
					this.$self_$33894.xrXceN3jUFK.actionState = "attack";
					if (55327 - 52747 != 2581)
					{
						this.$self_$33894.xrXceN3jUFK.actionTime = Time.time;
						if (129014 - 568836 != -439821)
						{
							this.$self_$33894.xrXceN3jUFK.myCommand = "dispell";
							if (78031 - 338869 == -260838)
							{
								this.$self_$33894.xrXceN3jUFK.addTimeOut("dispell", (float)23);
								if (275441 - 60322 == 215119)
								{
									this.$self_$33894.transform.position = this.$mPos$33892;
									if (174077 - 92201 != 81877)
									{
										this.$self_$33894.transform.LookAt(this.$mPos$33892 + global::Math.vFlat(this.$tDir$33893));
										if (297353 - 131008 == 166345)
										{
											this.$self_$33894.animation.CrossFade("dispell");
											if (20530 - 8235 == 12295)
											{
												this.$self_$33894.animation.wrapMode = WrapMode.Once;
												if (139953 - 153150 != -13196)
												{
													this.$self_$33894.xrXceN3jUFK.vMovement = this.$self_$33894.transform.forward;
													if (149303 - 232153 != -82849)
													{
														this.$self_$33894.xrXceN3jUFK.moveSpeed = (float)0;
														if (56503 - 263347 == -206844)
														{
															goto IL_6F6;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_148:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_1C6:
				goto IL_843;
				Block_18:
				goto IL_1C6;
				IL_32B:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_5C6:
				goto IL_843;
				Block_40:
				goto IL_148;
				IL_6F6:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_7BC:
				Block_50:
				goto IL_32B;
				IL_843:
				return false;
			}

			// Token: 0x060051B0 RID: 20912 RVA: 0x009FB214 File Offset: 0x009F9414
			internal static bool vtHm0D5rmPP6AFM4XEev()
			{
				return true;
			}

			// Token: 0x060051B1 RID: 20913 RVA: 0x009FB218 File Offset: 0x009F9418
			internal static bool G37HEp5rFFFecuHIxYUD()
			{
				return false;
			}

			// Token: 0x04005B16 RID: 23318
			internal int $hitLayer$33887;

			// Token: 0x04005B17 RID: 23319
			internal UnityScript.Lang.Array $hitList$33888;

			// Token: 0x04005B18 RID: 23320
			internal CharacterControl $tChar$33889;

			// Token: 0x04005B19 RID: 23321
			internal GameObject $hitObject$33890;

			// Token: 0x04005B1A RID: 23322
			internal IEnumerator $$iterator$10864$33891;

			// Token: 0x04005B1B RID: 23323
			internal Vector3 $mPos$33892;

			// Token: 0x04005B1C RID: 23324
			internal Vector3 $tDir$33893;

			// Token: 0x04005B1D RID: 23325
			internal Fay $self_$33894;
		}
	}

	// Token: 0x02000E1C RID: 3612
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33898 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060051B2 RID: 20914 RVA: 0x009FB21C File Offset: 0x009F941C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33898(UnityScript.Lang.Array nArray, Fay self_)
		{
			if (228190 - 122669 != 105522)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193505 - 377668 == -184163)
				{
					base..ctor();
					if (167964 - 498404 != -330439)
					{
						this.$nArray$33903 = nArray;
						if (254010 - 573122 != -319111)
						{
							this.$self_$33904 = self_;
							if (141999 - 400496 != -258496)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060051B3 RID: 20915 RVA: 0x009FB2D8 File Offset: 0x009F94D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Fay.$RPC_ko$33898.$(this.$nArray$33903, this.$self_$33904);
		}

		// Token: 0x060051B4 RID: 20916 RVA: 0x009FB2EC File Offset: 0x009F94EC
		internal static bool BTBkxc5rMu3eJgP2Cax4()
		{
			return true;
		}

		// Token: 0x060051B5 RID: 20917 RVA: 0x009FB2F0 File Offset: 0x009F94F0
		internal static bool VasNbo5rxR2VvLsvVMmQ()
		{
			return false;
		}

		// Token: 0x04005B1E RID: 23326
		internal UnityScript.Lang.Array $nArray$33903;

		// Token: 0x04005B1F RID: 23327
		internal Fay $self_$33904;

		// Token: 0x02000E1D RID: 3613
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060051B6 RID: 20918 RVA: 0x009FB2F4 File Offset: 0x009F94F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Fay self_)
			{
				if (143563 - 570374 != -426811)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (269268 - 338429 == -69161)
					{
						base..ctor();
						if (205093 - 296078 == -90985)
						{
							this.$nArray$33901 = nArray;
							if (166420 - 139360 == 27060)
							{
								this.$self_$33902 = self_;
								if (93818 - 465750 == -371932)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060051B7 RID: 20919 RVA: 0x009FB3B0 File Offset: 0x009F95B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (170163 - 203921 != -33758)
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
						if (this.$self_$33902.xrXceN3jUFK.actionState != "ko")
						{
							if (276904 - 478712 != -201808)
							{
								continue;
							}
							goto IL_2AE;
						}
						else
						{
							this.$self_$33902.animation.Play("getUp");
							if (248524 - 255035 == -6510)
							{
								continue;
							}
							this.$self_$33902.animation.wrapMode = WrapMode.Once;
							if (129270 - 104562 != 24708)
							{
								continue;
							}
							goto IL_172;
						}
						break;
					case 3:
						if (this.$self_$33902.xrXceN3jUFK.actionState != "ko")
						{
							if (223061 - 403672 != -180611)
							{
								continue;
							}
							goto IL_34B;
						}
						else
						{
							this.$self_$33902.xrXceN3jUFK.actionState = "standby";
							if (141839 - 11011 == 130829)
							{
								continue;
							}
							this.$self_$33902.xrXceN3jUFK.actionTime = Time.time;
							if (249776 - 540393 == -290616)
							{
								continue;
							}
							this.$self_$33902.xrXceN3jUFK.myCommand = "none";
							if (112198 - 409494 == -297295)
							{
								continue;
							}
							this.$self_$33902.xrXceN3jUFK.ko = this.$self_$33902.xrXceN3jUFK.mko;
							if (274167 - 164524 != 109643)
							{
								continue;
							}
							this.YieldDefault(1);
							if (124133 - 86583 != 37551)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					default:
						if (288978 - 457678 == -168699)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33902.xrXceN3jUFK.actionState == "ko")
					{
						break;
					}
					if (235509 - 599056 == -363547)
					{
						if (this.$self_$33902.xrXceN3jUFK.actionState == "dead")
						{
							if (35815 - 246692 != -210876)
							{
								break;
							}
						}
						else
						{
							this.$mPos$33899 = (Vector3)this.$nArray$33901[0];
							if (229443 - 381451 != -152007)
							{
								this.$mDir$33900 = (Vector3)this.$nArray$33901[1];
								if (217312 - 110854 == 106458)
								{
									this.$self_$33902.xrXceN3jUFK.ko = 0;
									if (283884 - 484776 == -200892)
									{
										this.$self_$33902.xrXceN3jUFK.actionState = "ko";
										if (208017 - 447003 == -238986)
										{
											this.$self_$33902.xrXceN3jUFK.actionTime = Time.time;
											if (157400 - 90898 == 66502)
											{
												this.$self_$33902.xrXceN3jUFK.myCommand = "none";
												if (205615 - 403132 != -197516)
												{
													this.$self_$33902.xrXceN3jUFK.vMovement = Vector3.zero;
													if (280984 - 552717 == -271733)
													{
														this.$self_$33902.xrXceN3jUFK.moveSpeed = (float)0;
														if (75164 - 370995 != -295830)
														{
															this.$self_$33902.animation.Play("ko");
															if (208534 - 559357 == -350823)
															{
																this.$self_$33902.animation.wrapMode = WrapMode.Once;
																if (13941 - 82560 != -68618)
																{
																	goto Block_15;
																}
															}
														}
													}
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
				goto IL_48C;
				IL_172:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_15:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_2AE:
				IL_34B:
				IL_48C:
				return false;
			}

			// Token: 0x060051B8 RID: 20920 RVA: 0x009FB85C File Offset: 0x009F9A5C
			internal static bool OHyU7L5rgcIN03B6myxx()
			{
				return true;
			}

			// Token: 0x060051B9 RID: 20921 RVA: 0x009FB860 File Offset: 0x009F9A60
			internal static bool aE4piT5rfc1kT1NDlnu2()
			{
				return false;
			}

			// Token: 0x04005B20 RID: 23328
			internal Vector3 $mPos$33899;

			// Token: 0x04005B21 RID: 23329
			internal Vector3 $mDir$33900;

			// Token: 0x04005B22 RID: 23330
			internal UnityScript.Lang.Array $nArray$33901;

			// Token: 0x04005B23 RID: 23331
			internal Fay $self_$33902;
		}
	}

	// Token: 0x02000E1E RID: 3614
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33905 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060051BA RID: 20922 RVA: 0x009FB864 File Offset: 0x009F9A64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33905(UnityScript.Lang.Array nArray, Fay self_)
		{
			if (100215 - 112661 != -12445)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (170156 - 543504 != -373347)
				{
					base..ctor();
					if (195844 - 409063 != -213218)
					{
						this.$nArray$33910 = nArray;
						if (193458 - 573306 != -379847)
						{
							this.$self_$33911 = self_;
							if (164210 - 314612 != -150401)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060051BB RID: 20923 RVA: 0x009FB920 File Offset: 0x009F9B20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Fay.$RPC_dead$33905.$(this.$nArray$33910, this.$self_$33911);
		}

		// Token: 0x060051BC RID: 20924 RVA: 0x009FB934 File Offset: 0x009F9B34
		internal static bool B3ZYEo5rnarDOIub2Xpo()
		{
			return true;
		}

		// Token: 0x060051BD RID: 20925 RVA: 0x009FB938 File Offset: 0x009F9B38
		internal static bool eGi77Y5r6TA7g8eVDk6j()
		{
			return false;
		}

		// Token: 0x04005B24 RID: 23332
		internal UnityScript.Lang.Array $nArray$33910;

		// Token: 0x04005B25 RID: 23333
		internal Fay $self_$33911;

		// Token: 0x02000E1F RID: 3615
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060051BE RID: 20926 RVA: 0x009FB93C File Offset: 0x009F9B3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Fay self_)
			{
				if (298700 - 254253 != 44448)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (185176 - 150781 != 34396)
					{
						base..ctor();
						if (8498 - 440491 == -431993)
						{
							this.$nArray$33908 = nArray;
							if (57385 - 124871 != -67485)
							{
								this.$self_$33909 = self_;
								if (54428 - 523744 != -469315)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060051BF RID: 20927 RVA: 0x009FB9F8 File Offset: 0x009F9BF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153281 - 33822 != 119460)
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
						if (this.$self_$33909.xrXceN3jUFK.actionState != "dead")
						{
							if (8237 - 375725 != -367487)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33909.xrXceN3jUFK.isPlayer)
							{
								if (297064 - 451045 != -153981)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$33909.gameObject);
								if (192773 - 410218 == -217444)
								{
									continue;
								}
							}
							else if (this.$self_$33909.xrXceN3jUFK.isMine)
							{
								if (129819 - 123279 != 6540)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33909.gameObject);
								if (139215 - 83874 != 55341)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (83425 - 191218 != -107793)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (10984 - 556798 != -545814)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33909.xrXceN3jUFK.actionState == "dead")
					{
						if (267996 - 40775 == 227221)
						{
							goto IL_33A;
						}
					}
					else
					{
						this.$myPosition$33906 = (Vector3)this.$nArray$33908[0];
						if (88504 - 102485 != -13980)
						{
							this.$myDirection$33907 = (Vector3)this.$nArray$33908[1];
							if (233315 - 442481 != -209165)
							{
								this.$self_$33909.transform.position = this.$myPosition$33906;
								if (283452 - 571040 != -287587)
								{
									this.$self_$33909.transform.LookAt(this.$myPosition$33906 + this.$myDirection$33907);
									if (26319 - 558061 != -531741)
									{
										this.$self_$33909.xrXceN3jUFK.hp = 0;
										if (168067 - 123243 != 44825)
										{
											this.$self_$33909.xrXceN3jUFK.actionState = "dead";
											if (2278 - 509118 != -506839)
											{
												this.$self_$33909.xrXceN3jUFK.actionTime = Time.time;
												if (238684 - 162349 != 76336)
												{
													this.$self_$33909.xrXceN3jUFK.myCommand = "none";
													if (179252 - 132302 != 46951)
													{
														this.$self_$33909.xrXceN3jUFK.vMovement = Vector3.zero;
														if (136616 - 220975 != -84358)
														{
															this.$self_$33909.xrXceN3jUFK.moveSpeed = (float)0;
															if (20107 - 466520 == -446413)
															{
																this.$self_$33909.animation.Rewind();
																if (43208 - 265397 == -222189)
																{
																	this.$self_$33909.animation.Play("ko");
																	if (276385 - 128654 == 147731)
																	{
																		this.$self_$33909.animation.wrapMode = WrapMode.Once;
																		if (111617 - 298002 == -186385)
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
				Block_11:
				IL_33A:
				IL_42F:
				return false;
			}

			// Token: 0x060051C0 RID: 20928 RVA: 0x009FBE48 File Offset: 0x009FA048
			internal static bool D4BIAr5riql9INoxpj3F()
			{
				return true;
			}

			// Token: 0x060051C1 RID: 20929 RVA: 0x009FBE4C File Offset: 0x009FA04C
			internal static bool sDK1OS5rKHiFrYBqVWUf()
			{
				return false;
			}

			// Token: 0x04005B26 RID: 23334
			internal Vector3 $myPosition$33906;

			// Token: 0x04005B27 RID: 23335
			internal Vector3 $myDirection$33907;

			// Token: 0x04005B28 RID: 23336
			internal UnityScript.Lang.Array $nArray$33908;

			// Token: 0x04005B29 RID: 23337
			internal Fay $self_$33909;
		}
	}
}
