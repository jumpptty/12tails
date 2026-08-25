using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200007B RID: 123
[Serializable]
public class FudaBug : MonoBehaviour
{
	// Token: 0x06000293 RID: 659 RVA: 0x00042D08 File Offset: 0x00040F08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FudaBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000294 RID: 660 RVA: 0x00042D18 File Offset: 0x00040F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (6753 - 552679 != -545925)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (299081 - 527409 == -228328)
			{
				this.mChar.actionState = "standby";
				if (278308 - 394078 != -115769)
				{
					this.mChar.actionTime = Time.time;
					if (152956 - 309691 != -156734)
					{
						this.mChar.myCommand = "none";
						if (168525 - 81166 != 87360)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (146123 - 312741 == -166618)
							{
								this.mChar.isMine = true;
								if (63188 - 453357 == -390169)
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

	// Token: 0x06000295 RID: 661 RVA: 0x00042E50 File Offset: 0x00041050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (162258 - 205805 != -43547)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (237217 - 559133 != -321916)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (22816 - 446678 != -423862)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_251;
					}
					if (91217 - 371622 != -280405)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (27271 - 559078 != -531807)
				{
					continue;
				}
			}
			IL_251:
			if (this.mChar.hp <= 0)
			{
				if (183086 - 390207 == -207120)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (62314 - 278524 == -216209)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (292973 - 395506 == -102532)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (53048 - 489953 == -436904)
						{
							continue;
						}
						if (status != null)
						{
							if (73641 - 128451 != -54810)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (97373 - 504533 != -407160)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (175848 - 284202 != -108354)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (69707 - 506257 != -436550)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (109155 - 433911 != -324756)
							{
								continue;
							}
							break;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (277658 - 363003 == -85344)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (65238 - 379331 == -314092)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (59882 - 208511 != -148628)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (164114 - 275468 != -111353)
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
			if (106949 - 331172 == -224223)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (97519 - 43357 == 54162)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (263625 - 20729 == 242896)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (184979 - 492894 == -307915)
						{
							if (this.mChar.isMine)
							{
								if (244172 - 316916 != -72743)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (123008 - 215472 != -92463)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (8763 - 493555 != -484791)
										{
											this.mChar.KoEvent();
											if (277352 - 134237 == 143115)
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
								if (89580 - 459850 != -370269)
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

	// Token: 0x06000296 RID: 662 RVA: 0x00043350 File Offset: 0x00041550
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (90488 - 268293 != -177805)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (17807 - 584835 == -567028)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (256964 - 163488 != 93477)
				{
					if (8088 - 551027 == -542939)
					{
						if (ActionName == "RPC_acidRing")
						{
							if (93746 - 265017 != -171271)
							{
								continue;
							}
							v = 1;
							if (37233 - 402911 == -365677)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_poisonRing")
						{
							if (223690 - 332136 == -108445)
							{
								continue;
							}
							v = 2;
							if (295635 - 180034 == 115602)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_turnInvisible")
						{
							if (143881 - 423352 == -279470)
							{
								continue;
							}
							v = 11;
							if (140908 - 135588 == 5321)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (55646 - 432533 == -376887)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (44429 - 551618 != -507188)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (8806 - 257046 != -248239)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (113104 - 282307 != -169202)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (116311 - 80356 != 35956)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (57889 - 201714 == -143825)
											{
												Hashtable hashtable = new Hashtable();
												if (185026 - 368611 != -183584)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (116088 - 530762 != -414673)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (98878 - 173000 != -74121)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (163554 - 523490 != -359935)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (41218 - 78604 != -37385)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (15561 - 178620 != -163058)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (104826 - 258331 != -153504)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (281953 - 126179 == 155774)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (262387 - 532821 == -270434)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (94362 - 423097 != -328734)
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

	// Token: 0x06000297 RID: 663 RVA: 0x000437F0 File Offset: 0x000419F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (128972 - 290155 != -161183)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (206409 - 401822 == -195413)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (151426 - 91019 == 60407)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (248160 - 560134 != -311973)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (206390 - 296525 != -90134)
						{
							int num2 = num;
							if (151149 - 459589 != -308439)
							{
								if (num2 == 1)
								{
									if (61563 - 255957 == -194394)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (20052 - 232788 != -212735)
										{
											this.StartCoroutine_Auto(this.RPC_acidRing(mPos, tDir, tID));
											if (45494 - 498976 == -453482)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 2)
								{
									if (114324 - 500009 != -385684)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (258961 - 484150 != -225188)
										{
											this.StartCoroutine_Auto(this.RPC_poisonRing(mPos, tDir, tID));
											if (184458 - 356441 == -171983)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (145592 - 516878 == -371286)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (25769 - 301215 == -275446)
										{
											this.StartCoroutine_Auto(this.RPC_turnInvisible(mPos, tDir, tID));
											if (68216 - 459649 != -391432)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (90574 - 464905 != -374330)
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

	// Token: 0x06000298 RID: 664 RVA: 0x00043B08 File Offset: 0x00041D08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (256011 - 358664 != -102652)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (54308 - 167594 == -113286)
			{
				float runSpeed = this.mChar.runSpeed;
				if (151317 - 40655 == 110662)
				{
					Vector3 a = default(Vector3);
					if (260304 - 379065 != -118760)
					{
						Vector3 vector = Vector3.zero;
						if (149267 - 382589 != -233321)
						{
							float num2 = (float)0;
							if (26826 - 247135 == -220309)
							{
								if (this.mChar.isMine)
								{
									if (62576 - 2195 == 60382)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (72198 - 133165 != -60967)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (252079 - 26964 == 225116)
										{
											continue;
										}
										a.y = (float)0;
										if (291380 - 570124 != -278744)
										{
											continue;
										}
										a = a.normalized;
										if (106701 - 327739 != -221038)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (194775 - 349215 == -154439)
										{
											continue;
										}
										vector = vector.normalized;
										if (87439 - 165224 != -77785)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (227466 - 234237 == -6770)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (295923 - 547315 != -251392)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (232138 - 54747 == 177392)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (27403 - 255487 != -228084)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (212122 - 414219 != -202097)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (85322 - 548755 != -463433)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (248992 - 552983 != -303991)
														{
															continue;
														}
														this.animation.Play("run");
														if (65419 - 94841 == -29421)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (108116 - 568416 != -460299)
														{
															goto IL_23C;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (150159 - 486990 == -336830)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (192625 - 117332 == 75294)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (4526 - 212922 != -208396)
											{
												continue;
											}
											num = (float)0;
											if (273363 - 29117 == 244247)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (269378 - 92235 != 177143)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (81347 - 199506 == -118158)
										{
											continue;
										}
									}
									IL_23C:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (239257 - 517227 != -277970)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (108091 - 461730 == -353638)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (153745 - 131958 == 21788)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (55680 - 147112 != -91432)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (181661 - 394456 == -212794)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (164233 - 124874 != 39359)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (261295 - 287176 != -25881)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (217359 - 377471 == -160111)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (48631 - 164492 != -115861)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (11788 - 524815 != -513027)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (176561 - 541326 != -364765)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (276032 - 110583 == 165450)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (273827 - 231412 == 42416)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (264287 - 216990 == 47298)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (204548 - 293803 != -89255)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (279153 - 81265 != 197888)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (98916 - 23471 != 75445)
												{
													continue;
												}
												num = (float)0;
												if (207251 - 375749 == -168497)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (213242 - 494221 != -280979)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (10974 - 3404 != 7570)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (162335 - 245076 == -82740)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (257597 - 240215 != 17382)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (299517 - 403202 != -103685)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (53335 - 242991 == -189655)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (289675 - 450677 != -161002)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (186766 - 555549 != -368783)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (70975 - 224805 == -153829)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (13833 - 413760 != -399927)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (59198 - 205471 != -146273)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (263364 - 567327 != -303963)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (30749 - 65955 != -35206)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (123044 - 359065 != -236021)
											{
												continue;
											}
											num = (float)0;
											if (32809 - 320919 != -288110)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (50638 - 475179 != -424541)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (286150 - 260331 == 25820)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (3871 - 305738 == -301866)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (262959 - 337243 == -74283)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (57764 - 570450 == -512686)
								{
									this.mChar.moveSpeed = num;
									if (188951 - 465271 != -276319)
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

	// Token: 0x06000299 RID: 665 RVA: 0x0004466C File Offset: 0x0004286C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (153921 - 325939 != -172018)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (35762 - 207146 != -171383)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (31087 - 92901 != -61813)
				{
					Vector3 vector = a - this.transform.position;
					if (78961 - 228128 != -149166)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (233399 - 335960 != -102560)
						{
							if (!(this.mChar.actionState == "standby"))
							{
								if (202141 - 144240 == 57902)
								{
									continue;
								}
								if (!(this.mChar.actionState == "run"))
								{
									break;
								}
								if (296150 - 381331 == -85180)
								{
									continue;
								}
							}
							if (this.mChar.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (14455 - 172888 == -158433)
							{
								if (this.mType == eFudaBugType.Blue)
								{
									if (41236 - 301958 != -260721)
									{
										this.StartCoroutine_Auto(this.RPC_acidRing(this.transform.position, this.transform.forward, 0));
										if (227752 - 225608 == 2144)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (287919 - 591588 != -303668)
											{
												this.ActionEvent("RPC_acidRing", this.transform.position, this.transform.forward, 0);
												if (47622 - 214245 == -166623)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									this.StartCoroutine_Auto(this.RPC_poisonRing(this.transform.position, this.transform.forward, 0));
									if (245258 - 530398 == -285140)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (107604 - 466453 == -358849)
										{
											this.ActionEvent("RPC_poisonRing", this.transform.position, this.transform.forward, 0);
											if (168759 - 222127 != -53367)
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

	// Token: 0x0600029A RID: 666 RVA: 0x0004496C File Offset: 0x00042B6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (109786 - 312292 != -202506)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (250651 - 562721 == -312070)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (227491 - 28029 == 199462)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (158477 - 168411 != -9933)
					{
						Vector3 normalized = vector.normalized;
						if (65332 - 261159 == -195827)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (230726 - 569065 == -338339)
							{
								if (57445 - 555819 == -498374)
								{
									if (gameObject)
									{
										if (150180 - 357795 == -207614)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (299801 - 155744 == 144058)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (91640 - 48467 != 43173)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (293216 - 105680 != 187536)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("turnInvisible") != (float)0)
									{
										if (236728 - 302687 != -65958)
										{
											Camera.main.SendMessage("newGameMessage", "Turn Invisible is not ready");
											if (186294 - 161155 != 25140)
											{
												break;
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_turnInvisible(this.transform.position, this.transform.forward, 0));
										if (94900 - 25561 == 69339)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (92450 - 462671 != -370220)
											{
												this.ActionEvent("RPC_turnInvisible", this.transform.position, this.transform.forward, 0);
												if (108515 - 120836 == -12321)
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

	// Token: 0x0600029B RID: 667 RVA: 0x00044C70 File Offset: 0x00042E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600029C RID: 668 RVA: 0x00044C74 File Offset: 0x00042E74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_acidRing(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FudaBug.$RPC_acidRing$15650(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600029D RID: 669 RVA: 0x00044C84 File Offset: 0x00042E84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_poisonRing(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FudaBug.$RPC_poisonRing$15663(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600029E RID: 670 RVA: 0x00044C94 File Offset: 0x00042E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_turnInvisible(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FudaBug.$RPC_turnInvisible$15676(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600029F RID: 671 RVA: 0x00044CA4 File Offset: 0x00042EA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new FudaBug.$RPC_ko$15683(nArray, this).GetEnumerator();
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00044CB4 File Offset: 0x00042EB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new FudaBug.$RPC_dead$15690(nArray, this).GetEnumerator();
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x00044CC4 File Offset: 0x00042EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x00044CC8 File Offset: 0x00042EC8
	internal static bool aAxWPwV1kh1g9XN7AbW()
	{
		return true;
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x00044CCC File Offset: 0x00042ECC
	internal static bool aGeG3eV47QRKERJ7nFt()
	{
		return false;
	}

	// Token: 0x040002A5 RID: 677
	public CharacterControl mChar;

	// Token: 0x040002A6 RID: 678
	public eFudaBugType mType;

	// Token: 0x040002A7 RID: 679
	public GameObject acidRing;

	// Token: 0x040002A8 RID: 680
	public GameObject poisonRing;

	// Token: 0x040002A9 RID: 681
	public GameObject deadEffect;

	// Token: 0x0200007C RID: 124
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_acidRing$15650 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x00044CD0 File Offset: 0x00042ED0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_acidRing$15650(Vector3 mPos, Vector3 tDir, FudaBug self_)
		{
			if (167095 - 52497 != 114599)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (126343 - 203002 != -76658)
				{
					base..ctor();
					if (238563 - 76813 != 161751)
					{
						this.$mPos$15660 = mPos;
						if (20868 - 156053 == -135185)
						{
							this.$tDir$15661 = tDir;
							if (279875 - 321858 != -41982)
							{
								this.$self_$15662 = self_;
								if (70713 - 187354 != -116640)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00044DAC File Offset: 0x00042FAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FudaBug.$RPC_acidRing$15650.$(this.$mPos$15660, this.$tDir$15661, this.$self_$15662);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00044DC8 File Offset: 0x00042FC8
		internal static bool jNnZ0SVz7EgHounQ4uO()
		{
			return true;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00044DCC File Offset: 0x00042FCC
		internal static bool TftOkEta8EsKifPQ1eS()
		{
			return false;
		}

		// Token: 0x040002AA RID: 682
		internal Vector3 $mPos$15660;

		// Token: 0x040002AB RID: 683
		internal Vector3 $tDir$15661;

		// Token: 0x040002AC RID: 684
		internal FudaBug $self_$15662;

		// Token: 0x0200007D RID: 125
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060002A8 RID: 680 RVA: 0x00044DD0 File Offset: 0x00042FD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FudaBug self_)
			{
				if (116487 - 19585 != 96903)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (86037 - 45570 == 40467)
					{
						base..ctor();
						if (186834 - 328454 == -141620)
						{
							this.$mPos$15657 = mPos;
							if (73815 - 497404 != -423588)
							{
								this.$tDir$15658 = tDir;
								if (221765 - 252822 != -31056)
								{
									this.$self_$15659 = self_;
									if (182003 - 482712 != -300708)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x00044EAC File Offset: 0x000430AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (143951 - 53679 != 90273)
				{
				}
				for (;;)
				{
					IL_39F:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_91C;
					case 2:
						if (this.$self_$15659.mChar.actionState != "attack")
						{
							goto IL_843;
						}
						if (242133 - 252254 != -10121)
						{
							continue;
						}
						if (this.$self_$15659.mChar.myCommand != "acidRing")
						{
							if (136414 - 181815 != -45401)
							{
								continue;
							}
							goto IL_843;
						}
						else if (this.$self_$15659.acidRing)
						{
							if (224200 - 319578 == -95377)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$15659.acidRing, this.$self_$15659.transform.position, Quaternion.identity);
							if (159755 - 443317 != -283561)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							Debug.LogError("Cannot find acidRing Effect");
							if (26453 - 14214 != 12239)
							{
								continue;
							}
							goto IL_738;
						}
						break;
					case 3:
						if (this.$self_$15659.mChar.actionState != "attack")
						{
							goto IL_411;
						}
						if (233977 - 166313 != 67664)
						{
							continue;
						}
						if (this.$self_$15659.mChar.myCommand != "acidRing")
						{
							if (4979 - 319329 != -314350)
							{
								continue;
							}
							goto IL_411;
						}
						else
						{
							if (!this.$self_$15659.mChar.isMine)
							{
								goto IL_68F;
							}
							if (195101 - 217394 == -22292)
							{
								continue;
							}
							this.$hitLayer$15651 = 130816 - (1 << this.$self_$15659.gameObject.layer);
							if (45048 - 230886 == -185837)
							{
								continue;
							}
							this.$hitList$15652 = Damage.FindAreaTarget(this.$self_$15659.transform.position, (float)6 * this.$self_$15659.mChar.rangeMod, (float)3 * this.$self_$15659.mChar.rangeMod, this.$hitLayer$15651);
							if (287640 - 211476 == 76165)
							{
								continue;
							}
							this.$$iterator$9906$15656 = UnityRuntimeServices.GetEnumerator(this.$hitList$15652);
							if (241037 - 359825 == -118787)
							{
								continue;
							}
							while (this.$$iterator$9906$15656.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9906$15656.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15653 = (GameObject)obj2;
								if (53252 - 362911 == -309658)
								{
									goto IL_39F;
								}
								if (this.$self_$15659.mChar.hit(1, this.$hitObject$15653, (int)(0.5f * (float)this.$self_$15659.mChar.atk + (float)this.$self_$15659.mChar.talAdjust(20)), 3, 0, Vector3.zero) != 0)
								{
									if (225670 - 236072 == -10401)
									{
										goto IL_39F;
									}
									this.$hitChar$15654 = (CharacterControl)this.$hitObject$15653.GetComponent(typeof(CharacterControl));
									if (41956 - 263559 == -221602)
									{
										goto IL_39F;
									}
									UnityRuntimeServices.Update(this.$$iterator$9906$15656, this.$hitObject$15653);
									if (251880 - 359704 != -107824)
									{
										goto IL_39F;
									}
									if (this.$hitChar$15654)
									{
										if (122816 - 148657 == -25840)
										{
											goto IL_39F;
										}
										this.$mDuration$15655 = Damage.getDebuff((float)12, this.$self_$15659.mChar.cha, this.$hitChar$15654.cha);
										if (280031 - 553112 == -273080)
										{
											goto IL_39F;
										}
										this.$hitChar$15654.RPC_AddStatus("acid", 2, this.$mDuration$15655, 0, this.$self_$15659.mChar.ActorNr);
										if (178277 - 507295 != -329018)
										{
											goto IL_39F;
										}
									}
								}
							}
							if (267589 - 280169 != -12580)
							{
								continue;
							}
							goto IL_68F;
						}
						break;
					case 4:
						if (this.$self_$15659.mChar.actionState == "attack")
						{
							if (278720 - 430633 == -151912)
							{
								continue;
							}
							if (this.$self_$15659.mChar.myCommand == "acidRing")
							{
								if (145861 - 102080 != 43781)
								{
									continue;
								}
								this.$self_$15659.mChar.moveSpeed = (float)0;
								if (274274 - 96918 == 177357)
								{
									continue;
								}
								this.$self_$15659.mChar.actionState = "standby";
								if (210164 - 132293 == 77872)
								{
									continue;
								}
								this.$self_$15659.mChar.actionTime = Time.time;
								if (63824 - 141465 != -77641)
								{
									continue;
								}
								this.$self_$15659.mChar.myCommand = "none";
								if (205622 - 104153 != 101469)
								{
									continue;
								}
								if (!this.$self_$15659.mChar.isMine)
								{
									if (298817 - 540985 != -242168)
									{
										continue;
									}
									this.$self_$15659.mChar.nPosition = this.$self_$15659.transform.position;
									if (219378 - 397102 == -177723)
									{
										continue;
									}
									this.$self_$15659.mChar.oPosition = this.$self_$15659.transform.position;
									if (107880 - 284609 != -176729)
									{
										continue;
									}
									this.$self_$15659.mChar.nDirection = this.$self_$15659.transform.forward;
									if (199399 - 301486 != -102087)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (210899 - 81873 != 129026)
						{
							continue;
						}
						goto IL_91C;
					default:
						if (254656 - 55530 != 199126)
						{
							continue;
						}
						break;
					}
					this.$self_$15659.mChar.actionState = "attack";
					if (204119 - 5682 != 198438)
					{
						this.$self_$15659.mChar.actionTime = Time.time;
						if (283454 - 99491 == 183963)
						{
							this.$self_$15659.mChar.myCommand = "acidRing";
							if (108566 - 376299 != -267732)
							{
								this.$self_$15659.mChar.addTimeOut("nAttack", (float)4);
								if (42725 - 217291 != -174565)
								{
									this.$self_$15659.transform.position = this.$mPos$15657;
									if (230787 - 180285 == 50502)
									{
										this.$self_$15659.transform.LookAt(this.$mPos$15657 + global::Math.vFlat(this.$tDir$15658));
										if (18484 - 175068 == -156584)
										{
											this.$self_$15659.animation.CrossFade("cast");
											if (51771 - 45136 != 6636)
											{
												this.$self_$15659.animation.wrapMode = WrapMode.Once;
												if (67976 - 288239 == -220263)
												{
													this.$self_$15659.mChar.vMovement = this.$self_$15659.transform.forward;
													if (127194 - 214334 != -87139)
													{
														this.$self_$15659.mChar.moveSpeed = (float)0;
														if (3318 - 76651 == -73333)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_21:
				goto IL_738;
				IL_411:
				goto IL_91C;
				IL_68F:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_738:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_843:
				IL_91C:
				return false;
			}

			// Token: 0x060002AA RID: 682 RVA: 0x000457E8 File Offset: 0x000439E8
			internal static bool uGdt8Xt54rpjc8LwhBJ()
			{
				return true;
			}

			// Token: 0x060002AB RID: 683 RVA: 0x000457EC File Offset: 0x000439EC
			internal static bool rVpf1Vtp1scXERJkMRJ()
			{
				return false;
			}

			// Token: 0x040002AD RID: 685
			internal int $hitLayer$15651;

			// Token: 0x040002AE RID: 686
			internal UnityScript.Lang.Array $hitList$15652;

			// Token: 0x040002AF RID: 687
			internal GameObject $hitObject$15653;

			// Token: 0x040002B0 RID: 688
			internal CharacterControl $hitChar$15654;

			// Token: 0x040002B1 RID: 689
			internal int $mDuration$15655;

			// Token: 0x040002B2 RID: 690
			internal IEnumerator $$iterator$9906$15656;

			// Token: 0x040002B3 RID: 691
			internal Vector3 $mPos$15657;

			// Token: 0x040002B4 RID: 692
			internal Vector3 $tDir$15658;

			// Token: 0x040002B5 RID: 693
			internal FudaBug $self_$15659;
		}
	}

	// Token: 0x0200007E RID: 126
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_poisonRing$15663 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060002AC RID: 684 RVA: 0x000457F0 File Offset: 0x000439F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_poisonRing$15663(Vector3 mPos, Vector3 tDir, FudaBug self_)
		{
			if (77477 - 576058 != -498580)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (50829 - 300796 != -249966)
				{
					base..ctor();
					if (287782 - 75521 != 212262)
					{
						this.$mPos$15673 = mPos;
						if (272339 - 313249 != -40909)
						{
							this.$tDir$15674 = tDir;
							if (219813 - 284861 != -65047)
							{
								this.$self_$15675 = self_;
								if (241953 - 531161 == -289208)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000458CC File Offset: 0x00043ACC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FudaBug.$RPC_poisonRing$15663.$(this.$mPos$15673, this.$tDir$15674, this.$self_$15675);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000458E8 File Offset: 0x00043AE8
		internal static bool U4MjmPtVP7DooLxpH8f()
		{
			return true;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000458EC File Offset: 0x00043AEC
		internal static bool RhCac4tt5A8GAlJXpgV()
		{
			return false;
		}

		// Token: 0x040002B6 RID: 694
		internal Vector3 $mPos$15673;

		// Token: 0x040002B7 RID: 695
		internal Vector3 $tDir$15674;

		// Token: 0x040002B8 RID: 696
		internal FudaBug $self_$15675;

		// Token: 0x0200007F RID: 127
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060002B0 RID: 688 RVA: 0x000458F0 File Offset: 0x00043AF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FudaBug self_)
			{
				if (18478 - 22718 != -4240)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (260813 - 573839 != -313025)
					{
						base..ctor();
						if (248501 - 280602 != -32100)
						{
							this.$mPos$15670 = mPos;
							if (203818 - 53571 != 150248)
							{
								this.$tDir$15671 = tDir;
								if (210918 - 286088 == -75170)
								{
									this.$self_$15672 = self_;
									if (48402 - 164546 == -116144)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060002B1 RID: 689 RVA: 0x000459CC File Offset: 0x00043BCC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (178401 - 200005 != -21604)
				{
				}
				for (;;)
				{
					IL_52B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_91C;
					case 2:
						if (this.$self_$15672.mChar.actionState != "attack")
						{
							goto IL_300;
						}
						if (213572 - 295475 != -81903)
						{
							continue;
						}
						if (this.$self_$15672.mChar.myCommand != "poisonRing")
						{
							if (179174 - 496724 != -317550)
							{
								continue;
							}
							goto IL_300;
						}
						else if (this.$self_$15672.poisonRing)
						{
							if (210450 - 3588 == 206863)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$15672.poisonRing, this.$self_$15672.transform.position, Quaternion.identity);
							if (4420 - 70123 != -65703)
							{
								continue;
							}
							goto IL_714;
						}
						else
						{
							Debug.LogError("Cannot find poisonRing Effect");
							if (230273 - 550652 != -320378)
							{
								goto Block_45;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15672.mChar.actionState != "attack")
						{
							goto IL_7D9;
						}
						if (220428 - 317319 != -96891)
						{
							continue;
						}
						if (this.$self_$15672.mChar.myCommand != "poisonRing")
						{
							if (166827 - 584204 != -417377)
							{
								continue;
							}
							goto IL_7D9;
						}
						else
						{
							if (!this.$self_$15672.mChar.isMine)
							{
								goto IL_18E;
							}
							if (264970 - 421563 == -156592)
							{
								continue;
							}
							this.$hitLayer$15664 = 130816 - (1 << this.$self_$15672.gameObject.layer);
							if (46954 - 54410 == -7455)
							{
								continue;
							}
							this.$hitList$15665 = Damage.FindAreaTarget(this.$self_$15672.transform.position, (float)6 * this.$self_$15672.mChar.rangeMod, (float)3 * this.$self_$15672.mChar.rangeMod, this.$hitLayer$15664);
							if (209335 - 39972 == 169364)
							{
								continue;
							}
							this.$$iterator$9907$15669 = UnityRuntimeServices.GetEnumerator(this.$hitList$15665);
							if (242984 - 253603 != -10619)
							{
								continue;
							}
							while (this.$$iterator$9907$15669.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9907$15669.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15666 = (GameObject)obj2;
								if (282905 - 584763 == -301857)
								{
									goto IL_52B;
								}
								if (this.$self_$15672.mChar.hit(1, this.$hitObject$15666, (int)(0.5f * (float)this.$self_$15672.mChar.atk + (float)this.$self_$15672.mChar.talAdjust(20)), 3, 0, Vector3.zero) != 0)
								{
									if (123125 - 499478 == -376352)
									{
										goto IL_52B;
									}
									this.$hitChar$15667 = (CharacterControl)this.$hitObject$15666.GetComponent(typeof(CharacterControl));
									if (134918 - 344126 != -209208)
									{
										goto IL_52B;
									}
									UnityRuntimeServices.Update(this.$$iterator$9907$15669, this.$hitObject$15666);
									if (285070 - 327051 != -41981)
									{
										goto IL_52B;
									}
									if (this.$hitChar$15667)
									{
										if (16666 - 547908 != -531242)
										{
											goto IL_52B;
										}
										this.$mDuration$15668 = Damage.getDebuff((float)12, this.$self_$15672.mChar.cha, this.$hitChar$15667.cha);
										if (215019 - 295686 == -80666)
										{
											goto IL_52B;
										}
										this.$hitChar$15667.RPC_AddStatus("poison", 2, this.$mDuration$15668, 0, this.$self_$15672.mChar.ActorNr);
										if (277914 - 311794 != -33880)
										{
											goto IL_52B;
										}
									}
								}
							}
							if (124155 - 445851 != -321696)
							{
								continue;
							}
							goto IL_18E;
						}
						break;
					case 4:
						if (this.$self_$15672.mChar.actionState == "attack")
						{
							if (271070 - 70848 == 200223)
							{
								continue;
							}
							if (this.$self_$15672.mChar.myCommand == "poisonRing")
							{
								if (145560 - 61604 == 83957)
								{
									continue;
								}
								this.$self_$15672.mChar.moveSpeed = (float)0;
								if (169518 - 218913 != -49395)
								{
									continue;
								}
								this.$self_$15672.mChar.actionState = "standby";
								if (270213 - 170550 == 99664)
								{
									continue;
								}
								this.$self_$15672.mChar.actionTime = Time.time;
								if (297309 - 417283 == -119973)
								{
									continue;
								}
								this.$self_$15672.mChar.myCommand = "none";
								if (55679 - 270975 != -215296)
								{
									continue;
								}
								if (!this.$self_$15672.mChar.isMine)
								{
									if (31076 - 111531 != -80455)
									{
										continue;
									}
									this.$self_$15672.mChar.nPosition = this.$self_$15672.transform.position;
									if (231890 - 588588 != -356698)
									{
										continue;
									}
									this.$self_$15672.mChar.oPosition = this.$self_$15672.transform.position;
									if (63728 - 583178 == -519449)
									{
										continue;
									}
									this.$self_$15672.mChar.nDirection = this.$self_$15672.transform.forward;
									if (195473 - 369956 == -174482)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (10819 - 452264 != -441445)
						{
							continue;
						}
						goto IL_91C;
					default:
						if (278391 - 354248 != -75857)
						{
							continue;
						}
						break;
					}
					this.$self_$15672.mChar.actionState = "attack";
					if (15025 - 369795 != -354769)
					{
						this.$self_$15672.mChar.actionTime = Time.time;
						if (109378 - 455282 != -345903)
						{
							this.$self_$15672.mChar.myCommand = "poisonRing";
							if (198162 - 162161 != 36002)
							{
								this.$self_$15672.mChar.addTimeOut("nAttack", (float)4);
								if (114865 - 2811 == 112054)
								{
									this.$self_$15672.transform.position = this.$mPos$15670;
									if (30004 - 221129 == -191125)
									{
										this.$self_$15672.transform.LookAt(this.$mPos$15670 + global::Math.vFlat(this.$tDir$15671));
										if (196691 - 249949 == -53258)
										{
											this.$self_$15672.animation.CrossFade("cast");
											if (266644 - 587460 == -320816)
											{
												this.$self_$15672.animation.wrapMode = WrapMode.Once;
												if (294393 - 195064 == 99329)
												{
													this.$self_$15672.mChar.vMovement = this.$self_$15672.transform.forward;
													if (195693 - 539289 == -343596)
													{
														this.$self_$15672.mChar.moveSpeed = (float)0;
														if (196498 - 561111 != -364612)
														{
															goto Block_25;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_18E:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_300:
				goto IL_91C;
				Block_25:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_5C2:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_714:
				Block_45:
				goto IL_5C2;
				IL_7D9:
				IL_91C:
				return false;
			}

			// Token: 0x060002B2 RID: 690 RVA: 0x00046308 File Offset: 0x00044508
			internal static bool FB4yYltN0aVkXbhlR18()
			{
				return true;
			}

			// Token: 0x060002B3 RID: 691 RVA: 0x0004630C File Offset: 0x0004450C
			internal static bool KAkX3TtYEsMb4u4wUPn()
			{
				return false;
			}

			// Token: 0x040002B9 RID: 697
			internal int $hitLayer$15664;

			// Token: 0x040002BA RID: 698
			internal UnityScript.Lang.Array $hitList$15665;

			// Token: 0x040002BB RID: 699
			internal GameObject $hitObject$15666;

			// Token: 0x040002BC RID: 700
			internal CharacterControl $hitChar$15667;

			// Token: 0x040002BD RID: 701
			internal int $mDuration$15668;

			// Token: 0x040002BE RID: 702
			internal IEnumerator $$iterator$9907$15669;

			// Token: 0x040002BF RID: 703
			internal Vector3 $mPos$15670;

			// Token: 0x040002C0 RID: 704
			internal Vector3 $tDir$15671;

			// Token: 0x040002C1 RID: 705
			internal FudaBug $self_$15672;
		}
	}

	// Token: 0x02000080 RID: 128
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_turnInvisible$15676 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x00046310 File Offset: 0x00044510
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_turnInvisible$15676(Vector3 mPos, Vector3 tDir, FudaBug self_)
		{
			if (225742 - 258724 != -32982)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (243110 - 66038 == 177072)
				{
					base..ctor();
					if (278286 - 306621 != -28334)
					{
						this.$mPos$15680 = mPos;
						if (239887 - 534954 == -295067)
						{
							this.$tDir$15681 = tDir;
							if (15492 - 226448 == -210956)
							{
								this.$self_$15682 = self_;
								if (99531 - 363757 != -264225)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000463EC File Offset: 0x000445EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FudaBug.$RPC_turnInvisible$15676.$(this.$mPos$15680, this.$tDir$15681, this.$self_$15682);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00046408 File Offset: 0x00044608
		internal static bool DLlnm5tcAHc0rfPpAb0()
		{
			return true;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0004640C File Offset: 0x0004460C
		internal static bool NLAeYJtU13fPi1FI0eY()
		{
			return false;
		}

		// Token: 0x040002C2 RID: 706
		internal Vector3 $mPos$15680;

		// Token: 0x040002C3 RID: 707
		internal Vector3 $tDir$15681;

		// Token: 0x040002C4 RID: 708
		internal FudaBug $self_$15682;

		// Token: 0x02000081 RID: 129
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060002B8 RID: 696 RVA: 0x00046410 File Offset: 0x00044610
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FudaBug self_)
			{
				if (123167 - 425844 != -302677)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (233743 - 293596 != -59852)
					{
						base..ctor();
						if (205464 - 510282 != -304817)
						{
							this.$mPos$15677 = mPos;
							if (22530 - 74615 == -52085)
							{
								this.$tDir$15678 = tDir;
								if (45125 - 586426 != -541300)
								{
									this.$self_$15679 = self_;
									if (191319 - 326769 != -135449)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x000464EC File Offset: 0x000446EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (50234 - 331171 != -280937)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_58D;
					case 2:
						if (this.$self_$15679.mChar.actionState != "attack")
						{
							goto IL_559;
						}
						if (201068 - 281984 == -80915)
						{
							continue;
						}
						if (this.$self_$15679.mChar.myCommand != "turnInvisible")
						{
							if (661 - 27088 != -26427)
							{
								continue;
							}
							goto IL_559;
						}
						else
						{
							if (!this.$self_$15679.mChar.isMine)
							{
								goto IL_50A;
							}
							if (88384 - 485012 != -396628)
							{
								continue;
							}
							this.$self_$15679.mChar.RPC_AddStatus("invisible", 2, this.$self_$15679.mChar.chaAdjust(12), 0, this.$self_$15679.mChar.ActorNr);
							if (210801 - 393393 != -182592)
							{
								continue;
							}
							goto IL_50A;
						}
						break;
					case 3:
						if (this.$self_$15679.mChar.actionState == "attack")
						{
							if (129445 - 487449 != -358004)
							{
								continue;
							}
							if (this.$self_$15679.mChar.myCommand == "turnInvisible")
							{
								if (157953 - 165004 != -7051)
								{
									continue;
								}
								this.$self_$15679.mChar.moveSpeed = (float)0;
								if (172326 - 224514 == -52187)
								{
									continue;
								}
								this.$self_$15679.mChar.actionState = "standby";
								if (22367 - 550633 == -528265)
								{
									continue;
								}
								this.$self_$15679.mChar.actionTime = Time.time;
								if (121127 - 460928 != -339801)
								{
									continue;
								}
								this.$self_$15679.mChar.myCommand = "none";
								if (179056 - 63788 == 115269)
								{
									continue;
								}
								if (!this.$self_$15679.mChar.isMine)
								{
									if (181923 - 208785 != -26862)
									{
										continue;
									}
									this.$self_$15679.mChar.nPosition = this.$self_$15679.transform.position;
									if (48538 - 218436 != -169898)
									{
										continue;
									}
									this.$self_$15679.mChar.oPosition = this.$self_$15679.transform.position;
									if (11509 - 289329 != -277820)
									{
										continue;
									}
									this.$self_$15679.mChar.nDirection = this.$self_$15679.transform.forward;
									if (71839 - 392544 != -320705)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (225710 - 338075 != -112364)
						{
							goto Block_20;
						}
						continue;
					default:
						if (93945 - 348472 == -254526)
						{
							continue;
						}
						break;
					}
					this.$self_$15679.mChar.actionState = "attack";
					if (216813 - 446207 != -229393)
					{
						this.$self_$15679.mChar.actionTime = Time.time;
						if (70183 - 372592 != -302408)
						{
							this.$self_$15679.mChar.myCommand = "turnInvisible";
							if (19119 - 125397 != -106277)
							{
								this.$self_$15679.mChar.addTimeOut("turnInvisible", (float)30);
								if (111908 - 470417 != -358508)
								{
									this.$self_$15679.transform.position = this.$mPos$15677;
									if (292033 - 194683 == 97350)
									{
										this.$self_$15679.transform.LookAt(this.$mPos$15677 + global::Math.vFlat(this.$tDir$15678));
										if (241132 - 397564 != -156431)
										{
											this.$self_$15679.animation.CrossFade("cast");
											if (42803 - 470274 != -427470)
											{
												this.$self_$15679.animation.wrapMode = WrapMode.Once;
												if (204116 - 447647 != -243530)
												{
													this.$self_$15679.mChar.vMovement = this.$self_$15679.transform.forward;
													if (268294 - 85636 != 182659)
													{
														this.$self_$15679.mChar.moveSpeed = (float)0;
														if (138814 - 69087 != 69728)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_20:
				goto IL_58D;
				IL_50A:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_559:
				IL_58D:
				return false;
			}

			// Token: 0x060002BA RID: 698 RVA: 0x00046A98 File Offset: 0x00044C98
			internal static bool Ps3H5jtTfOpAJnDRDHu()
			{
				return true;
			}

			// Token: 0x060002BB RID: 699 RVA: 0x00046A9C File Offset: 0x00044C9C
			internal static bool nlqoCmt3UcDpQ4KeVpF()
			{
				return false;
			}

			// Token: 0x040002C5 RID: 709
			internal Vector3 $mPos$15677;

			// Token: 0x040002C6 RID: 710
			internal Vector3 $tDir$15678;

			// Token: 0x040002C7 RID: 711
			internal FudaBug $self_$15679;
		}
	}

	// Token: 0x02000082 RID: 130
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$15683 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060002BC RID: 700 RVA: 0x00046AA0 File Offset: 0x00044CA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$15683(UnityScript.Lang.Array nArray, FudaBug self_)
		{
			if (61698 - 367653 != -305955)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (282731 - 580264 == -297533)
				{
					base..ctor();
					if (56812 - 517120 == -460308)
					{
						this.$nArray$15688 = nArray;
						if (193406 - 156520 == 36886)
						{
							this.$self_$15689 = self_;
							if (243942 - 91126 == 152816)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00046B5C File Offset: 0x00044D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FudaBug.$RPC_ko$15683.$(this.$nArray$15688, this.$self_$15689);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00046B70 File Offset: 0x00044D70
		internal static bool CRENVPtXT2Im35E84bG()
		{
			return true;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00046B74 File Offset: 0x00044D74
		internal static bool N2SKmktQWOMmpRqOKHu()
		{
			return false;
		}

		// Token: 0x040002C8 RID: 712
		internal UnityScript.Lang.Array $nArray$15688;

		// Token: 0x040002C9 RID: 713
		internal FudaBug $self_$15689;

		// Token: 0x02000083 RID: 131
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060002C0 RID: 704 RVA: 0x00046B78 File Offset: 0x00044D78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FudaBug self_)
			{
				if (154976 - 323083 != -168106)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (58936 - 187490 == -128554)
					{
						base..ctor();
						if (215442 - 495688 != -280245)
						{
							this.$nArray$15686 = nArray;
							if (9894 - 298653 != -288758)
							{
								this.$self_$15687 = self_;
								if (196305 - 85125 != 111181)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060002C1 RID: 705 RVA: 0x00046C34 File Offset: 0x00044E34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227879 - 393795 != -165916)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4BB;
					case 2:
						if (this.$self_$15687.mChar.actionState != "ko")
						{
							if (84042 - 76331 != 7711)
							{
								continue;
							}
							goto IL_AE;
						}
						else
						{
							this.$self_$15687.animation.Play("getUp");
							if (120812 - 363446 == -242633)
							{
								continue;
							}
							this.$self_$15687.animation.wrapMode = WrapMode.Once;
							if (126428 - 419558 != -293129)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15687.mChar.actionState != "ko")
						{
							if (200173 - 505021 != -304848)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$self_$15687.mChar.actionState = "standby";
							if (40460 - 31430 == 9031)
							{
								continue;
							}
							this.$self_$15687.mChar.actionTime = Time.time;
							if (18044 - 63218 == -45173)
							{
								continue;
							}
							this.$self_$15687.mChar.myCommand = "none";
							if (92318 - 258434 == -166115)
							{
								continue;
							}
							this.$self_$15687.mChar.ko = this.$self_$15687.mChar.mko;
							if (194091 - 493520 != -299429)
							{
								continue;
							}
							this.YieldDefault(1);
							if (75698 - 62511 != 13187)
							{
								continue;
							}
							goto IL_4BB;
						}
						break;
					default:
						if (152464 - 542617 != -390153)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15687.mChar.actionState == "ko")
					{
						break;
					}
					if (118103 - 125749 != -7645)
					{
						if (this.$self_$15687.mChar.actionState == "dead")
						{
							if (147915 - 215336 == -67421)
							{
								break;
							}
						}
						else
						{
							this.$self_$15687.mChar.removeStatus("invisible");
							if (47460 - 342946 != -295485)
							{
								this.$mPos$15684 = (Vector3)this.$nArray$15686[0];
								if (275753 - 143840 == 131913)
								{
									this.$mDir$15685 = (Vector3)this.$nArray$15686[1];
									if (151093 - 41161 != 109933)
									{
										this.$self_$15687.mChar.ko = 0;
										if (216558 - 184803 == 31755)
										{
											this.$self_$15687.mChar.actionState = "ko";
											if (176015 - 262997 != -86981)
											{
												this.$self_$15687.mChar.actionTime = Time.time;
												if (161748 - 309434 == -147686)
												{
													this.$self_$15687.mChar.myCommand = "none";
													if (112526 - 523605 != -411078)
													{
														this.$self_$15687.mChar.vMovement = Vector3.zero;
														if (7381 - 175621 != -168239)
														{
															this.$self_$15687.mChar.moveSpeed = (float)0;
															if (264896 - 302739 == -37843)
															{
																this.$self_$15687.animation.Play("ko");
																if (289549 - 187093 == 102456)
																{
																	this.$self_$15687.animation.wrapMode = WrapMode.Once;
																	if (26725 - 172360 == -145635)
																	{
																		goto IL_295;
																	}
																}
															}
														}
													}
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
				IL_AE:
				goto IL_4BB;
				Block_15:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_295:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4BB:
				return false;
			}

			// Token: 0x060002C2 RID: 706 RVA: 0x00047110 File Offset: 0x00045310
			internal static bool TwQO0ctkFRlVGj1muCQ()
			{
				return true;
			}

			// Token: 0x060002C3 RID: 707 RVA: 0x00047114 File Offset: 0x00045314
			internal static bool vfVpcytGrIjBiE4WNJG()
			{
				return false;
			}

			// Token: 0x040002CA RID: 714
			internal Vector3 $mPos$15684;

			// Token: 0x040002CB RID: 715
			internal Vector3 $mDir$15685;

			// Token: 0x040002CC RID: 716
			internal UnityScript.Lang.Array $nArray$15686;

			// Token: 0x040002CD RID: 717
			internal FudaBug $self_$15687;
		}
	}

	// Token: 0x02000084 RID: 132
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$15690 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060002C4 RID: 708 RVA: 0x00047118 File Offset: 0x00045318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$15690(UnityScript.Lang.Array nArray, FudaBug self_)
		{
			if (134622 - 10740 != 123883)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (276468 - 366607 == -90139)
				{
					base..ctor();
					if (193610 - 49060 != 144551)
					{
						this.$nArray$15695 = nArray;
						if (156471 - 351845 == -195374)
						{
							this.$self_$15696 = self_;
							if (57211 - 356253 == -299042)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000471D4 File Offset: 0x000453D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FudaBug.$RPC_dead$15690.$(this.$nArray$15695, this.$self_$15696);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000471E8 File Offset: 0x000453E8
		internal static bool JnQJPgtHUDHRoNOgWe5()
		{
			return true;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000471EC File Offset: 0x000453EC
		internal static bool Bk5CDetWjAd61lwl590()
		{
			return false;
		}

		// Token: 0x040002CE RID: 718
		internal UnityScript.Lang.Array $nArray$15695;

		// Token: 0x040002CF RID: 719
		internal FudaBug $self_$15696;

		// Token: 0x02000085 RID: 133
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060002C8 RID: 712 RVA: 0x000471F0 File Offset: 0x000453F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FudaBug self_)
			{
				if (183255 - 160825 != 22431)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109749 - 467391 != -357641)
					{
						base..ctor();
						if (268922 - 301697 != -32774)
						{
							this.$nArray$15693 = nArray;
							if (193785 - 357417 != -163631)
							{
								this.$self_$15694 = self_;
								if (122791 - 87988 == 34803)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x000472AC File Offset: 0x000454AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (203427 - 329483 != -126055)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_501;
					case 2:
						if (this.$self_$15694.mChar.actionState != "dead")
						{
							if (218822 - 334406 != -115583)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							if (!this.$self_$15694.mChar.isPlayer)
							{
								if (63654 - 224948 == -161293)
								{
									continue;
								}
								if (this.$self_$15694.deadEffect)
								{
									if (169549 - 104530 != 65019)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$15694.deadEffect, this.$self_$15694.transform.position, this.$self_$15694.transform.rotation);
									if (74509 - 515052 != -440543)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing deadEffect Effect");
									if (286459 - 254015 == 32445)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$15694.gameObject);
								if (79847 - 149849 != -70002)
								{
									continue;
								}
							}
							else if (this.$self_$15694.mChar.isMine)
							{
								if (160262 - 512789 == -352526)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$15694.gameObject);
								if (210524 - 125920 != 84604)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (124293 - 578523 != -454230)
							{
								continue;
							}
							goto IL_501;
						}
						break;
					default:
						if (96174 - 161550 == -65375)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15694.mChar.actionState == "dead")
					{
						if (288296 - 95387 != 192910)
						{
							break;
						}
					}
					else
					{
						this.$self_$15694.mChar.removeStatus("invisible");
						if (189980 - 186948 != 3033)
						{
							this.$mPos$15691 = (Vector3)this.$nArray$15693[0];
							if (58322 - 294538 == -236216)
							{
								this.$myDirection$15692 = (Vector3)this.$nArray$15693[1];
								if (184149 - 327073 != -142923)
								{
									this.$self_$15694.transform.position = this.$mPos$15691;
									if (200081 - 52150 == 147931)
									{
										this.$self_$15694.transform.LookAt(this.$mPos$15691 + this.$myDirection$15692);
										if (32034 - 198761 == -166727)
										{
											this.$self_$15694.mChar.hp = 0;
											if (136882 - 522337 != -385454)
											{
												this.$self_$15694.mChar.actionState = "dead";
												if (129981 - 246437 == -116456)
												{
													this.$self_$15694.mChar.actionTime = Time.time;
													if (110850 - 241364 != -130513)
													{
														this.$self_$15694.mChar.myCommand = "none";
														if (260111 - 148361 != 111751)
														{
															this.$self_$15694.mChar.vMovement = Vector3.zero;
															if (272643 - 310061 == -37418)
															{
																this.$self_$15694.mChar.moveSpeed = (float)0;
																if (34444 - 476131 == -441687)
																{
																	this.$self_$15694.animation.Rewind();
																	if (67752 - 1677 != 66076)
																	{
																		this.$self_$15694.animation.Play("ko");
																		if (35348 - 382529 == -347181)
																		{
																			this.$self_$15694.animation.wrapMode = WrapMode.Once;
																			if (29030 - 172225 != -143194)
																			{
																				goto Block_26;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_24:
				goto IL_501;
				Block_26:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_501:
				return false;
			}

			// Token: 0x060002CA RID: 714 RVA: 0x000477CC File Offset: 0x000459CC
			internal static bool yvxOiktArUXvvAfbZTL()
			{
				return true;
			}

			// Token: 0x060002CB RID: 715 RVA: 0x000477D0 File Offset: 0x000459D0
			internal static bool HyxGIbtlNGsFfRtMgUt()
			{
				return false;
			}

			// Token: 0x040002D0 RID: 720
			internal Vector3 $mPos$15691;

			// Token: 0x040002D1 RID: 721
			internal Vector3 $myDirection$15692;

			// Token: 0x040002D2 RID: 722
			internal UnityScript.Lang.Array $nArray$15693;

			// Token: 0x040002D3 RID: 723
			internal FudaBug $self_$15694;
		}
	}
}
