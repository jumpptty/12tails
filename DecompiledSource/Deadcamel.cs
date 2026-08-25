using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BFA RID: 3066
[Serializable]
public class Deadcamel : MonoBehaviour
{
	// Token: 0x0600447C RID: 17532 RVA: 0x00899F00 File Offset: 0x00898100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Deadcamel()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600447D RID: 17533 RVA: 0x00899F10 File Offset: 0x00898110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (54126 - 66515 != -12389)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (7716 - 393785 == -386069)
			{
				this.mChar.actionState = "standby";
				if (181605 - 115172 == 66433)
				{
					this.mChar.actionTime = Time.time;
					if (192604 - 594401 == -401797)
					{
						this.mChar.myCommand = "none";
						if (262622 - 369439 == -106817)
						{
							this.mChar.hp = (this.mChar.mhp = 13700);
							if (46929 - 71398 == -24469)
							{
								this.mChar.ko = (this.mChar.mko = 100);
								if (34844 - 252470 == -217626)
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

	// Token: 0x0600447E RID: 17534 RVA: 0x0089A068 File Offset: 0x00898268
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x0600447F RID: 17535 RVA: 0x0089A084 File Offset: 0x00898284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playFootEvent(AnimationEvent animEvent)
	{
		if (this.footStep)
		{
			this.audio.PlayOneShot(this.footStep);
		}
	}

	// Token: 0x06004480 RID: 17536 RVA: 0x0089A0A8 File Offset: 0x008982A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (33944 - 352648 != -318703)
		{
		}
		for (;;)
		{
			if (!this.mChar)
			{
				if (221138 - 58646 == 162492)
				{
					break;
				}
			}
			else
			{
				if (this.mChar.isControlled)
				{
					if (66335 - 75999 == -9663)
					{
						continue;
					}
					if (!(this.mChar.actionState == "standby"))
					{
						if (103829 - 435649 == -331819)
						{
							continue;
						}
						if (!(this.mChar.actionState == "run"))
						{
							goto IL_1A0;
						}
						if (55064 - 433284 != -378220)
						{
							continue;
						}
					}
					this.PlayerControl();
					if (113990 - 389649 == -275658)
					{
						continue;
					}
				}
				IL_1A0:
				if (this.mChar.hp <= 0)
				{
					if (138829 - 137662 != 1167)
					{
						continue;
					}
					if (this.mChar.actionState != "dead")
					{
						if (6535 - 482476 != -475941)
						{
							continue;
						}
						if (this.mChar.isMine)
						{
							if (112607 - 584414 == -471806)
							{
								continue;
							}
							statusClass status = this.mChar.getStatus("livingDead");
							if (179765 - 156491 != 23274)
							{
								continue;
							}
							if (status != null)
							{
								if (186165 - 124812 == 61354)
								{
									continue;
								}
								this.mChar.hp = 1;
								if (222637 - 466641 == -244003)
								{
									continue;
								}
								this.mChar.RPC_RemoveStatus("livingDead");
								if (266884 - 300613 != -33729)
								{
									continue;
								}
								this.RPC_livingDead_hit(Vector3.zero, Vector3.zero, 0);
								if (264656 - 559595 != -294939)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (210995 - 555049 == -344053)
									{
										continue;
									}
									this.ActionEvent("RPC_livingDead_hit", Vector3.zero, Vector3.zero, 0);
									if (224130 - 254817 == -30686)
									{
										continue;
									}
								}
								this.mChar.RPC_AddHeal(21, this.mChar.mhp, 0, 0, 0, 0, status.sID);
								if (13251 - 385310 != -372058)
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
								if (66456 - 161829 == -95372)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (211818 - 78078 != 133740)
								{
									continue;
								}
								this.mChar.DeadEvent();
								if (260568 - 260859 != -290)
								{
									break;
								}
								continue;
							}
						}
						else
						{
							this.mChar.hp = 1;
							if (84144 - 172683 != -88539)
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
				if (99131 - 295315 != -196183)
				{
					if (this.mChar.ko > 0)
					{
						break;
					}
					if (191362 - 175603 != 15760)
					{
						if (!(this.mChar.actionState != "ko"))
						{
							break;
						}
						if (196388 - 215157 != -18768)
						{
							if (!(this.mChar.actionState != "dead"))
							{
								break;
							}
							if (132879 - 289797 != -156917)
							{
								if (this.mChar.isMine)
								{
									if (48516 - 168023 != -119506)
									{
										this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
										{
											this.transform.position,
											this.transform.forward
										})));
										if (85987 - 199238 != -113250)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (52554 - 240036 == -187482)
											{
												this.mChar.KoEvent();
												if (82157 - 409040 != -326882)
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
									if (35466 - 310179 == -274713)
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

	// Token: 0x06004481 RID: 17537 RVA: 0x0089A62C File Offset: 0x0089882C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (241566 - 221855 != 19711)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (172357 - 163726 != 8632)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (256443 - 545465 != -289021 && 231140 - 434262 != -203121)
				{
					if (ActionName == "RPC_nAttack1")
					{
						if (100805 - 284912 != -184107)
						{
							continue;
						}
						v = 1;
						if (83858 - 134274 != -50416)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack2")
					{
						if (264198 - 523909 != -259711)
						{
							continue;
						}
						v = 2;
						if (209070 - 461641 != -252571)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (165525 - 299757 == -134231)
						{
							continue;
						}
						v = -1;
						if (251861 - 392218 == -140356)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_stoneFall")
					{
						if (215146 - 4445 != 210701)
						{
							continue;
						}
						v = 11;
						if (27225 - 64079 == -36853)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_stoneFall_fire")
					{
						if (255000 - 48160 == 206841)
						{
							continue;
						}
						v = 12;
						if (73365 - 102592 != -29227)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_livingDead_hit")
					{
						if (137183 - 368498 == -231314)
						{
							continue;
						}
						v = -50;
						if (68131 - 487453 != -419322)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (269597 - 467849 != -198252)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (97244 - 450829 == -353585)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (34195 - 350473 == -316278)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (283072 - 366094 == -83022)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (254714 - 207702 != 47013)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (21535 - 42214 != -20678)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (222490 - 402362 == -179872)
										{
											Hashtable hashtable = new Hashtable();
											if (211871 - 502395 == -290524)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (57256 - 536529 != -479272)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (272448 - 18672 == 253776)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (75325 - 158311 == -82986)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (133711 - 25388 == 108323)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (172541 - 104780 != 67762)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (6276 - 280012 == -273736)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (27677 - 476408 == -448731)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (241773 - 94627 != 147147)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (29751 - 205089 == -175338)
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

	// Token: 0x06004482 RID: 17538 RVA: 0x0089ABD8 File Offset: 0x00898DD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (85820 - 2121 != 83700)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (247672 - 167002 == 80670)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (29877 - 29513 != 365)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (106483 - 424596 != -318112)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (251476 - 226390 != 25087)
						{
							int num3 = num;
							if (6702 - 256493 == -249791)
							{
								if (num3 == 1)
								{
									if (58423 - 574115 == -515692)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (41006 - 461523 == -420517)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (95395 - 306008 == -210613)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (17246 - 234489 != -217242)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (63779 - 309807 != -246027)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (201389 - 587242 == -385853)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (24634 - 259545 != -234910)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (168182 - 428994 == -260812)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (167154 - 79570 != 87585)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (4530 - 352638 == -348108)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (258409 - 117558 != 140852)
										{
											this.StartCoroutine_Auto(this.RPC_stoneFall(vector, vector2, num2));
											if (124303 - 384968 != -260664)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (152158 - 284345 == -132187)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (15602 - 113070 == -97468)
										{
											this.StartCoroutine_Auto(this.RPC_stoneFall_fire(vector, vector2, num2));
											if (36417 - 339957 == -303540)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -50)
								{
									if (226324 - 154821 != 71504)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (296721 - 129654 == 167067)
										{
											this.RPC_livingDead_hit(vector, vector2, num2);
											if (113728 - 8210 != 105519)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (106644 - 210057 == -103413)
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

	// Token: 0x06004483 RID: 17539 RVA: 0x0089B054 File Offset: 0x00899254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (267971 - 29558 != 238414)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (209327 - 32637 != 176691)
			{
				float runSpeed = this.mChar.runSpeed;
				if (42365 - 353120 == -310755)
				{
					Vector3 a = default(Vector3);
					if (254866 - 476362 == -221496)
					{
						Vector3 vector = Vector3.zero;
						if (221563 - 317030 != -95466)
						{
							float num2 = (float)0;
							if (212813 - 305272 == -92459)
							{
								if (this.mChar.isMine)
								{
									if (142675 - 9343 == 133333)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (1240 - 315458 == -314217)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (54826 - 205521 == -150694)
										{
											continue;
										}
										a.y = (float)0;
										if (236669 - 379614 == -142944)
										{
											continue;
										}
										a = a.normalized;
										if (105041 - 139065 == -34023)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (225443 - 328658 == -103214)
										{
											continue;
										}
										vector = vector.normalized;
										if (11680 - 483535 == -471854)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (16560 - 439623 != -423063)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (56346 - 121399 == -65052)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (153477 - 61278 == 92200)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (63263 - 27934 == 35330)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (222807 - 251427 == -28619)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (5820 - 419295 == -413474)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (6969 - 445118 != -438149)
														{
															continue;
														}
														this.animation.Play("run");
														if (31528 - 332460 == -300931)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (77373 - 230394 != -153020)
														{
															goto IL_232;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (226690 - 417157 == -190466)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (86466 - 5189 != 81277)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (25304 - 61987 == -36682)
											{
												continue;
											}
											num = (float)0;
											if (296700 - 203734 != 92966)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (272927 - 260624 != 12303)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (197944 - 258875 == -60930)
										{
											continue;
										}
									}
									IL_232:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (114925 - 315425 != -200500)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (149970 - 344471 == -194500)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (161128 - 138775 != 22353)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (33688 - 255429 == -221740)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (53249 - 473712 != -420463)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (77213 - 561839 == -484625)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (148900 - 87281 != 61619)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (232755 - 460235 == -227479)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (73564 - 22213 == 51352)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (189790 - 407728 == -217937)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (179869 - 362235 == -182365)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (216803 - 472081 != -255278)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (43785 - 353519 == -309733)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (276760 - 75086 == 201675)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (173180 - 86812 == 86369)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (192951 - 19560 == 173392)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (298454 - 255904 == 42551)
												{
													continue;
												}
												num = (float)0;
												if (215664 - 122673 != 92991)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (215626 - 162965 == 52662)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (203995 - 50650 != 153345)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (27527 - 88873 == -61345)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (165016 - 279732 != -114716)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (225969 - 484420 == -258450)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (118674 - 132986 == -14311)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (51117 - 251686 != -200569)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (17491 - 493862 != -476371)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (66550 - 222829 != -156279)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (197810 - 452188 == -254377)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (239838 - 14195 == 225644)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (187049 - 72917 != 114132)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (258039 - 410965 == -152925)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (10372 - 210761 == -200388)
											{
												continue;
											}
											num = (float)0;
											if (99638 - 343319 == -243680)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (245633 - 427738 != -182105)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (213887 - 441521 != -227634)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (269912 - 272631 == -2718)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (234109 - 440563 != -206454)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (251913 - 76438 != 175476)
								{
									this.mChar.moveSpeed = num;
									if (163405 - 540501 != -377095)
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

	// Token: 0x06004484 RID: 17540 RVA: 0x0089BBB8 File Offset: 0x00899DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (272879 - 533698 != -260819)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (157493 - 424319 == -266826)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (42302 - 324601 == -282299)
				{
					Vector3 vector = a - this.transform.position;
					if (265897 - 35495 != 230403)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (279139 - 146311 != 132829)
						{
							CharacterControl characterControl = null;
							if (273090 - 341241 != -68150)
							{
								if (249891 - 277288 == -27397)
								{
									if (gameObject)
									{
										if (233241 - 599669 == -366427)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (250277 - 191744 != 58533)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (174753 - 487032 == -312278)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (286251 - 363183 != -76932)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (281918 - 75981 == 205938)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (157024 - 587708 == -430683)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (298937 - 319677 == -20740)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, vector, 0));
										if (276251 - 401067 != -124815)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (216034 - 330790 != -114755)
											{
												this.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
												if (155240 - 578504 == -423264)
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

	// Token: 0x06004485 RID: 17541 RVA: 0x0089BEB0 File Offset: 0x0089A0B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (41564 - 492052 != -450488)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (212201 - 96359 != 115843)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (183997 - 320331 != -136333)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (58793 - 435878 != -377084)
					{
						Vector3 normalized = vector.normalized;
						if (64579 - 208076 != -143496)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (8471 - 555716 != -547244)
							{
								CharacterControl characterControl = null;
								if (41095 - 564100 == -523005)
								{
									if (183527 - 126069 == 57458)
									{
										if (gameObject)
										{
											if (277799 - 339300 != -61501)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (223134 - 80523 != 142611)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (88657 - 413209 != -324552)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (143590 - 25279 == 118312)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (12159 - 185924 != -173765)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (144482 - 269062 == -124579)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (81846 - 251154 == -169308)
										{
											this.StartCoroutine_Auto(this.RPC_stoneFall(this.transform.position, normalized, 0));
											if (282470 - 20327 != 262144)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (25424 - 414910 != -389485)
												{
													this.ActionEvent("RPC_stoneFall", this.transform.position, normalized, 0);
													if (129843 - 553066 == -423223)
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

	// Token: 0x06004486 RID: 17542 RVA: 0x0089C1D0 File Offset: 0x0089A3D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004487 RID: 17543 RVA: 0x0089C1D4 File Offset: 0x0089A3D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Deadcamel.$RPC_nAttack1$31780(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004488 RID: 17544 RVA: 0x0089C1E4 File Offset: 0x0089A3E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Deadcamel.$RPC_nAttack2$31795(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004489 RID: 17545 RVA: 0x0089C1F4 File Offset: 0x0089A3F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (69904 - 333173 != -263269)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (45500 - 100709 != -55208)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (112956 - 511928 == -398972)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (138037 - 24885 != 113153)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600448A RID: 17546 RVA: 0x0089C2B4 File Offset: 0x0089A4B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_stoneFall(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Deadcamel.$RPC_stoneFall$31810(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600448B RID: 17547 RVA: 0x0089C2C4 File Offset: 0x0089A4C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_stoneFall_fire(Vector3 tPos, Vector3 tDir, int tID)
	{
		return new Deadcamel.$RPC_stoneFall_fire$31823(tPos, this).GetEnumerator();
	}

	// Token: 0x0600448C RID: 17548 RVA: 0x0089C2D4 File Offset: 0x0089A4D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_livingDead_hit(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (152191 - 413197 != -261005)
		{
		}
		for (;;)
		{
			if (this.livingDead_hit)
			{
				if (89738 - 131975 == -42237)
				{
					this.mChar.createEffect(this.livingDead_hit, this.transform.position + 8.5f * Vector3.up, this.transform.rotation);
					if (197722 - 281641 == -83919)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Warning cannot find livingDead_hit effect");
				if (3915 - 232319 != -228403)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600448D RID: 17549 RVA: 0x0089C3B8 File Offset: 0x0089A5B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Deadcamel.$RPC_ko$31832(nArray, this).GetEnumerator();
	}

	// Token: 0x0600448E RID: 17550 RVA: 0x0089C3C8 File Offset: 0x0089A5C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Deadcamel.$RPC_dead$31839(nArray, this).GetEnumerator();
	}

	// Token: 0x0600448F RID: 17551 RVA: 0x0089C3D8 File Offset: 0x0089A5D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004490 RID: 17552 RVA: 0x0089C3DC File Offset: 0x0089A5DC
	internal static bool fDJtkH56jDm95fjA88e1()
	{
		return true;
	}

	// Token: 0x06004491 RID: 17553 RVA: 0x0089C3E0 File Offset: 0x0089A5E0
	internal static bool mnZEVn56hx1FQ2vq8FJ7()
	{
		return false;
	}

	// Token: 0x04005025 RID: 20517
	public CharacterControl mChar;

	// Token: 0x04005026 RID: 20518
	public AudioClip footStep;

	// Token: 0x04005027 RID: 20519
	public GameObject nAttack_hit;

	// Token: 0x04005028 RID: 20520
	public GameObject stoneFall_ring;

	// Token: 0x04005029 RID: 20521
	public GameObject stoneFall_fire;

	// Token: 0x0400502A RID: 20522
	public GameObject livingDead_hit;

	// Token: 0x02000BFB RID: 3067
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$31780 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004492 RID: 17554 RVA: 0x0089C3E4 File Offset: 0x0089A5E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$31780(Vector3 mPos, Vector3 tDir, Deadcamel self_)
		{
			if (55934 - 41538 != 14396)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (8770 - 567165 != -558394)
				{
					base..ctor();
					if (118699 - 444729 != -326029)
					{
						this.$mPos$31792 = mPos;
						if (22037 - 89659 == -67622)
						{
							this.$tDir$31793 = tDir;
							if (95985 - 119436 == -23451)
							{
								this.$self_$31794 = self_;
								if (21003 - 4775 != 16229)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x0089C4C0 File Offset: 0x0089A6C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadcamel.$RPC_nAttack1$31780.$(this.$mPos$31792, this.$tDir$31793, this.$self_$31794);
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x0089C4DC File Offset: 0x0089A6DC
		internal static bool YSe1s756sfGP0O6gGXt2()
		{
			return true;
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x0089C4E0 File Offset: 0x0089A6E0
		internal static bool rgTbIy569OjIbSZG4au6()
		{
			return false;
		}

		// Token: 0x0400502B RID: 20523
		internal Vector3 $mPos$31792;

		// Token: 0x0400502C RID: 20524
		internal Vector3 $tDir$31793;

		// Token: 0x0400502D RID: 20525
		internal Deadcamel $self_$31794;

		// Token: 0x02000BFC RID: 3068
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004496 RID: 17558 RVA: 0x0089C4E4 File Offset: 0x0089A6E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Deadcamel self_)
			{
				if (131072 - 274661 != -143588)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (294892 - 218221 != 76672)
					{
						base..ctor();
						if (217447 - 229618 == -12171)
						{
							this.$mPos$31789 = mPos;
							if (13089 - 457375 == -444286)
							{
								this.$tDir$31790 = tDir;
								if (121092 - 130703 != -9610)
								{
									this.$self_$31791 = self_;
									if (126344 - 385369 == -259025)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004497 RID: 17559 RVA: 0x0089C5C0 File Offset: 0x0089A7C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (236799 - 583060 != -346261)
				{
				}
				for (;;)
				{
					IL_146:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A3E;
					case 2:
						if (this.$self_$31791.mChar.actionState != "attack")
						{
							if (43316 - 227549 == -184232)
							{
								continue;
							}
							if (this.$self_$31791.mChar.myCommand != "nAttack1")
							{
								if (79329 - 495672 != -416342)
								{
									goto Block_42;
								}
								continue;
							}
						}
						this.$i$31781 = 0;
						if (162760 - 167993 != -5232)
						{
							goto IL_3EC;
						}
						continue;
					case 3:
						if (this.$self_$31791.mChar.actionState != "attack")
						{
							if (5834 - 349966 == -344131)
							{
								continue;
							}
							if (this.$self_$31791.mChar.myCommand != "nAttack1")
							{
								if (51383 - 591154 != -539771)
								{
									continue;
								}
								goto IL_8B6;
							}
						}
						if (this.$self_$31791.mChar.isMine)
						{
							if (70801 - 489343 != -418542)
							{
								continue;
							}
							this.$hitLayer$31782 = 130816 - (1 << this.$self_$31791.gameObject.layer);
							if (223977 - 499242 != -275265)
							{
								continue;
							}
							this.$hitList$31783 = Damage.FindRecTarget(this.$self_$31791.transform.position, this.$self_$31791.transform.forward, (float)3, (float)3, (float)5, (float)2, this.$hitLayer$31782);
							if (213251 - 33082 == 180170)
							{
								continue;
							}
							this.$$iterator$10719$31788 = UnityRuntimeServices.GetEnumerator(this.$hitList$31783);
							if (295700 - 313863 != -18163)
							{
								continue;
							}
							while (this.$$iterator$10719$31788.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10719$31788.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31784 = (GameObject)obj2;
								if (19802 - 175556 == -155753)
								{
									goto IL_146;
								}
								if (this.$self_$31791.mChar.hit(1, this.$hitObject$31784, (int)(0.7f * (float)this.$self_$31791.mChar.atk), 2, 0, 0.5f * Mathf.Pow((float)-1, (float)(this.$i$31781 + 1)) * this.$self_$31791.transform.right) != 0)
								{
									if (119326 - 159907 != -40581)
									{
										goto IL_146;
									}
									this.$hitPos$31785 = this.$hitObject$31784.collider.ClosestPointOnBounds(this.$self_$31791.transform.position + (float)2 * Vector3.up);
									if (225272 - 145539 == 79734)
									{
										goto IL_146;
									}
									UnityRuntimeServices.Update(this.$$iterator$10719$31788, this.$hitObject$31784);
									if (208241 - 404322 != -196081)
									{
										goto IL_146;
									}
									this.$self_$31791.RPC_nAttack_hit(this.$hitPos$31785, this.$self_$31791.transform.forward, 0);
									if (15430 - 99359 == -83928)
									{
										goto IL_146;
									}
									this.$self_$31791.ActionEvent("RPC_nAttack_hit", this.$hitPos$31785, this.$self_$31791.transform.forward, 0);
									if (74494 - 238864 != -164370)
									{
										goto IL_146;
									}
									this.$self_$31791.mChar.sp = this.$self_$31791.mChar.sp + 1;
									if (209288 - 1553 == 207736)
									{
										goto IL_146;
									}
									this.$tChar$31786 = (CharacterControl)this.$hitObject$31784.GetComponent(typeof(CharacterControl));
									if (221884 - 414146 == -192261)
									{
										goto IL_146;
									}
									UnityRuntimeServices.Update(this.$$iterator$10719$31788, this.$hitObject$31784);
									if (25113 - 42396 != -17283)
									{
										goto IL_146;
									}
									if (this.$tChar$31786)
									{
										if (151055 - 535026 == -383970)
										{
											goto IL_146;
										}
										if (UnityEngine.Random.Range(0, 100) < this.$self_$31791.mChar.lckAdjust(20))
										{
											if (121408 - 496047 == -374638)
											{
												goto IL_146;
											}
											this.$mDuration$31787 = Damage.getDebuff((float)60, this.$self_$31791.mChar.cha, this.$tChar$31786.cha);
											if (297586 - 174658 == 122929)
											{
												goto IL_146;
											}
											this.$tChar$31786.RPC_AddStatus("plague", 1, this.$mDuration$31787, 0, this.$self_$31791.mChar.ActorNr);
											if (115987 - 60565 != 55422)
											{
												goto IL_146;
											}
										}
									}
								}
							}
							if (46054 - 325647 == -279592)
							{
								continue;
							}
						}
						this.$i$31781++;
						if (22125 - 194109 != -171983)
						{
							goto IL_3EC;
						}
						continue;
					case 4:
						if (this.$self_$31791.mChar.actionState == "attack")
						{
							if (57615 - 449469 != -391854)
							{
								continue;
							}
							if (this.$self_$31791.mChar.myCommand == "nAttack1")
							{
								if (71172 - 221356 != -150184)
								{
									continue;
								}
								this.$self_$31791.mChar.actionState = "standby";
								if (213823 - 197731 != 16092)
								{
									continue;
								}
								this.$self_$31791.mChar.actionTime = Time.time;
								if (36001 - 63944 != -27943)
								{
									continue;
								}
								this.$self_$31791.mChar.myCommand = "none";
								if (249745 - 36303 != 213442)
								{
									continue;
								}
								if (!this.$self_$31791.mChar.isMine)
								{
									if (268325 - 524297 == -255971)
									{
										continue;
									}
									this.$self_$31791.mChar.nPosition = this.$self_$31791.transform.position;
									if (215875 - 360111 == -144235)
									{
										continue;
									}
									this.$self_$31791.mChar.oPosition = this.$self_$31791.transform.position;
									if (200000 - 390078 != -190078)
									{
										continue;
									}
									this.$self_$31791.mChar.nDirection = this.$self_$31791.transform.forward;
									if (113631 - 366383 == -252751)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (121791 - 446541 != -324749)
						{
							goto Block_19;
						}
						continue;
					default:
						if (258575 - 361417 == -102841)
						{
							continue;
						}
						break;
					}
					this.$self_$31791.mChar.actionState = "attack";
					if (188964 - 173316 == 15649)
					{
						continue;
					}
					this.$self_$31791.mChar.actionTime = Time.time;
					if (234397 - 352150 == -117752)
					{
						continue;
					}
					this.$self_$31791.mChar.myCommand = "nAttack1";
					if (103059 - 435093 == -332033)
					{
						continue;
					}
					this.$self_$31791.mChar.addTimeOut("nAttack", (float)2);
					if (61801 - 557915 == -496113)
					{
						continue;
					}
					this.$self_$31791.transform.position = this.$mPos$31789;
					if (248811 - 11078 == 237734)
					{
						continue;
					}
					this.$self_$31791.transform.LookAt(this.$mPos$31789 + global::Math.vFlat(this.$tDir$31790));
					if (44870 - 297861 != -252991)
					{
						continue;
					}
					this.$self_$31791.animation.CrossFade("nAttack1");
					if (40696 - 198525 != -157829)
					{
						continue;
					}
					this.$self_$31791.animation.wrapMode = WrapMode.Once;
					if (115227 - 346111 != -230884)
					{
						continue;
					}
					this.$self_$31791.mChar.vMovement = this.$self_$31791.transform.forward;
					if (256700 - 85396 == 171305)
					{
						continue;
					}
					this.$self_$31791.mChar.moveSpeed = (float)0;
					if (219726 - 22904 != 196822)
					{
						continue;
					}
					goto IL_39D;
					IL_3EC:
					if (this.$i$31781 < 2)
					{
						goto IL_824;
					}
					if (105005 - 152388 != -47382)
					{
						goto Block_26;
					}
				}
				Block_19:
				goto IL_A3E;
				IL_39D:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_26:
				return this.Yield(4, new WaitForSeconds(0.8f));
				Block_42:
				goto IL_A3E;
				IL_824:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_8B6:
				IL_A3E:
				return false;
			}

			// Token: 0x06004498 RID: 17560 RVA: 0x0089D020 File Offset: 0x0089B220
			internal static bool pQttU8561Y0vBmL86ct2()
			{
				return true;
			}

			// Token: 0x06004499 RID: 17561 RVA: 0x0089D024 File Offset: 0x0089B224
			internal static bool OrRQx1564mSgJtaqNA5d()
			{
				return false;
			}

			// Token: 0x0400502E RID: 20526
			internal int $i$31781;

			// Token: 0x0400502F RID: 20527
			internal int $hitLayer$31782;

			// Token: 0x04005030 RID: 20528
			internal UnityScript.Lang.Array $hitList$31783;

			// Token: 0x04005031 RID: 20529
			internal GameObject $hitObject$31784;

			// Token: 0x04005032 RID: 20530
			internal Vector3 $hitPos$31785;

			// Token: 0x04005033 RID: 20531
			internal CharacterControl $tChar$31786;

			// Token: 0x04005034 RID: 20532
			internal int $mDuration$31787;

			// Token: 0x04005035 RID: 20533
			internal IEnumerator $$iterator$10719$31788;

			// Token: 0x04005036 RID: 20534
			internal Vector3 $mPos$31789;

			// Token: 0x04005037 RID: 20535
			internal Vector3 $tDir$31790;

			// Token: 0x04005038 RID: 20536
			internal Deadcamel $self_$31791;
		}
	}

	// Token: 0x02000BFD RID: 3069
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$31795 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600449A RID: 17562 RVA: 0x0089D028 File Offset: 0x0089B228
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$31795(Vector3 mPos, Vector3 tDir, Deadcamel self_)
		{
			if (122503 - 380344 != -257841)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (290524 - 503175 != -212650)
				{
					base..ctor();
					if (170846 - 127844 != 43003)
					{
						this.$mPos$31807 = mPos;
						if (58461 - 563097 != -504635)
						{
							this.$tDir$31808 = tDir;
							if (67350 - 37578 == 29772)
							{
								this.$self_$31809 = self_;
								if (65925 - 467385 == -401460)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x0089D104 File Offset: 0x0089B304
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadcamel.$RPC_nAttack2$31795.$(this.$mPos$31807, this.$tDir$31808, this.$self_$31809);
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x0089D120 File Offset: 0x0089B320
		internal static bool tJ13sE56zcjlNPaCiiwY()
		{
			return true;
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x0089D124 File Offset: 0x0089B324
		internal static bool xRSnU15iaDr9H5M04ihZ()
		{
			return false;
		}

		// Token: 0x04005039 RID: 20537
		internal Vector3 $mPos$31807;

		// Token: 0x0400503A RID: 20538
		internal Vector3 $tDir$31808;

		// Token: 0x0400503B RID: 20539
		internal Deadcamel $self_$31809;

		// Token: 0x02000BFE RID: 3070
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600449E RID: 17566 RVA: 0x0089D128 File Offset: 0x0089B328
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Deadcamel self_)
			{
				if (176823 - 493512 != -316689)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27456 - 368046 != -340589)
					{
						base..ctor();
						if (287979 - 332191 == -44212)
						{
							this.$mPos$31804 = mPos;
							if (277188 - 546235 != -269046)
							{
								this.$tDir$31805 = tDir;
								if (148230 - 499457 == -351227)
								{
									this.$self_$31806 = self_;
									if (109786 - 469459 != -359672)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600449F RID: 17567 RVA: 0x0089D204 File Offset: 0x0089B404
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (103068 - 252957 != -149889)
				{
				}
				for (;;)
				{
					IL_1E6:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A52;
					case 2:
						if (this.$self_$31806.mChar.actionState != "attack")
						{
							if (34867 - 356109 == -321241)
							{
								continue;
							}
							if (this.$self_$31806.mChar.myCommand != "nAttack2")
							{
								if (98075 - 170679 != -72604)
								{
									continue;
								}
								goto IL_605;
							}
						}
						this.$i$31796 = 0;
						if (117646 - 445672 != -328025)
						{
							goto IL_47E;
						}
						continue;
					case 3:
						if (this.$self_$31806.mChar.actionState != "attack")
						{
							if (121907 - 110372 == 11536)
							{
								continue;
							}
							if (this.$self_$31806.mChar.myCommand != "nAttack2")
							{
								if (270180 - 428442 != -158262)
								{
									continue;
								}
								goto IL_720;
							}
						}
						if (this.$self_$31806.mChar.isMine)
						{
							if (290479 - 298481 == -8001)
							{
								continue;
							}
							this.$hitLayer$31797 = 130816 - (1 << this.$self_$31806.gameObject.layer);
							if (28002 - 533777 != -505775)
							{
								continue;
							}
							this.$hitList$31798 = Damage.FindRecTarget(this.$self_$31806.transform.position + 1.5f * Vector3.up, this.$self_$31806.transform.forward, (float)3, (float)3, (float)8, (float)4, this.$hitLayer$31797);
							if (264753 - 522453 == -257699)
							{
								continue;
							}
							this.$$iterator$10720$31803 = UnityRuntimeServices.GetEnumerator(this.$hitList$31798);
							if (133755 - 568602 != -434847)
							{
								continue;
							}
							while (this.$$iterator$10720$31803.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10720$31803.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31799 = (GameObject)obj2;
								if (23183 - 289681 == -266497)
								{
									goto IL_1E6;
								}
								if (this.$self_$31806.mChar.hit(1, this.$hitObject$31799, (int)(0.7f * (float)this.$self_$31806.mChar.atk), 2, 0, 0.5f * Mathf.Pow((float)-1, (float)(this.$i$31796 + 1)) * this.$self_$31806.transform.right) != 0)
								{
									if (161723 - 513395 == -351671)
									{
										goto IL_1E6;
									}
									this.$hitPos$31800 = this.$hitObject$31799.collider.ClosestPointOnBounds(this.$self_$31806.transform.position + (float)2 * Vector3.up);
									if (161546 - 24164 == 137383)
									{
										goto IL_1E6;
									}
									UnityRuntimeServices.Update(this.$$iterator$10720$31803, this.$hitObject$31799);
									if (108906 - 14842 != 94064)
									{
										goto IL_1E6;
									}
									this.$self_$31806.RPC_nAttack_hit(this.$hitPos$31800, this.$self_$31806.transform.forward, 0);
									if (32912 - 127260 == -94347)
									{
										goto IL_1E6;
									}
									this.$self_$31806.ActionEvent("RPC_nAttack_hit", this.$hitPos$31800, this.$self_$31806.transform.forward, 0);
									if (31126 - 398373 != -367247)
									{
										goto IL_1E6;
									}
									this.$self_$31806.mChar.sp = this.$self_$31806.mChar.sp + 1;
									if (80162 - 80441 != -279)
									{
										goto IL_1E6;
									}
									this.$tChar$31801 = (CharacterControl)this.$hitObject$31799.GetComponent(typeof(CharacterControl));
									if (161769 - 566197 == -404427)
									{
										goto IL_1E6;
									}
									UnityRuntimeServices.Update(this.$$iterator$10720$31803, this.$hitObject$31799);
									if (285674 - 76968 == 208707)
									{
										goto IL_1E6;
									}
									if (this.$tChar$31801)
									{
										if (249551 - 46499 == 203053)
										{
											goto IL_1E6;
										}
										if (UnityEngine.Random.Range(0, 100) < this.$self_$31806.mChar.lckAdjust(20))
										{
											if (38757 - 262433 != -223676)
											{
												goto IL_1E6;
											}
											this.$mDuration$31802 = Damage.getDebuff((float)60, this.$self_$31806.mChar.cha, this.$tChar$31801.cha);
											if (193936 - 40038 != 153898)
											{
												goto IL_1E6;
											}
											this.$tChar$31801.RPC_AddStatus("plague", 1, this.$mDuration$31802, 0, this.$self_$31806.mChar.ActorNr);
											if (155340 - 492109 != -336769)
											{
												goto IL_1E6;
											}
										}
									}
								}
							}
							if (30840 - 551869 == -521028)
							{
								continue;
							}
						}
						this.$i$31796++;
						if (36811 - 332162 != -295351)
						{
							continue;
						}
						goto IL_47E;
					case 4:
						if (this.$self_$31806.mChar.actionState == "attack")
						{
							if (28771 - 592885 == -564113)
							{
								continue;
							}
							if (this.$self_$31806.mChar.myCommand == "nAttack2")
							{
								if (119013 - 47107 == 71907)
								{
									continue;
								}
								this.$self_$31806.mChar.actionState = "standby";
								if (234863 - 512213 == -277349)
								{
									continue;
								}
								this.$self_$31806.mChar.actionTime = Time.time;
								if (43011 - 435631 == -392619)
								{
									continue;
								}
								this.$self_$31806.mChar.myCommand = "none";
								if (108300 - 508953 == -400652)
								{
									continue;
								}
								if (!this.$self_$31806.mChar.isMine)
								{
									if (227437 - 474284 != -246847)
									{
										continue;
									}
									this.$self_$31806.mChar.nPosition = this.$self_$31806.transform.position;
									if (263903 - 302588 == -38684)
									{
										continue;
									}
									this.$self_$31806.mChar.oPosition = this.$self_$31806.transform.position;
									if (97744 - 92503 != 5241)
									{
										continue;
									}
									this.$self_$31806.mChar.nDirection = this.$self_$31806.transform.forward;
									if (22089 - 13007 == 9083)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (110837 - 300513 != -189676)
						{
							continue;
						}
						goto IL_A52;
					default:
						if (149802 - 425365 != -275563)
						{
							continue;
						}
						break;
					}
					this.$self_$31806.mChar.actionState = "attack";
					if (60800 - 551676 != -490876)
					{
						continue;
					}
					this.$self_$31806.mChar.actionTime = Time.time;
					if (175844 - 398847 != -223003)
					{
						continue;
					}
					this.$self_$31806.mChar.myCommand = "nAttack2";
					if (84811 - 413455 == -328643)
					{
						continue;
					}
					this.$self_$31806.mChar.addTimeOut("nAttack", (float)2);
					if (60981 - 316469 == -255487)
					{
						continue;
					}
					this.$self_$31806.transform.position = this.$mPos$31804;
					if (91962 - 129150 == -37187)
					{
						continue;
					}
					this.$self_$31806.transform.LookAt(this.$mPos$31804 + global::Math.vFlat(this.$tDir$31805));
					if (202657 - 98264 != 104393)
					{
						continue;
					}
					this.$self_$31806.animation.CrossFade("nAttack2");
					if (148082 - 394258 != -246176)
					{
						continue;
					}
					this.$self_$31806.animation.wrapMode = WrapMode.Once;
					if (48153 - 447196 != -399043)
					{
						continue;
					}
					this.$self_$31806.mChar.vMovement = this.$self_$31806.transform.forward;
					if (129560 - 592313 != -462753)
					{
						continue;
					}
					this.$self_$31806.mChar.moveSpeed = (float)0;
					if (32898 - 11514 != 21385)
					{
						goto Block_16;
					}
					continue;
					IL_47E:
					if (this.$i$31796 < 2)
					{
						break;
					}
					if (75534 - 42426 == 33108)
					{
						goto IL_2EF;
					}
				}
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_16:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_2EF:
				return this.Yield(4, new WaitForSeconds(0.8f));
				IL_605:
				IL_720:
				IL_A52:
				return false;
			}

			// Token: 0x060044A0 RID: 17568 RVA: 0x0089DC78 File Offset: 0x0089BE78
			internal static bool swq4IN5i5m0kmWOByHCo()
			{
				return true;
			}

			// Token: 0x060044A1 RID: 17569 RVA: 0x0089DC7C File Offset: 0x0089BE7C
			internal static bool r04bD15ipOR8OsBfBNNO()
			{
				return false;
			}

			// Token: 0x0400503C RID: 20540
			internal int $i$31796;

			// Token: 0x0400503D RID: 20541
			internal int $hitLayer$31797;

			// Token: 0x0400503E RID: 20542
			internal UnityScript.Lang.Array $hitList$31798;

			// Token: 0x0400503F RID: 20543
			internal GameObject $hitObject$31799;

			// Token: 0x04005040 RID: 20544
			internal Vector3 $hitPos$31800;

			// Token: 0x04005041 RID: 20545
			internal CharacterControl $tChar$31801;

			// Token: 0x04005042 RID: 20546
			internal int $mDuration$31802;

			// Token: 0x04005043 RID: 20547
			internal IEnumerator $$iterator$10720$31803;

			// Token: 0x04005044 RID: 20548
			internal Vector3 $mPos$31804;

			// Token: 0x04005045 RID: 20549
			internal Vector3 $tDir$31805;

			// Token: 0x04005046 RID: 20550
			internal Deadcamel $self_$31806;
		}
	}

	// Token: 0x02000BFF RID: 3071
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_stoneFall$31810 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060044A2 RID: 17570 RVA: 0x0089DC80 File Offset: 0x0089BE80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_stoneFall$31810(Vector3 mPos, Vector3 tDir, Deadcamel self_)
		{
			if (273544 - 13312 != 260233)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (19854 - 368527 != -348672)
				{
					base..ctor();
					if (244464 - 171313 == 73151)
					{
						this.$mPos$31820 = mPos;
						if (50405 - 62414 != -12008)
						{
							this.$tDir$31821 = tDir;
							if (217964 - 322787 == -104823)
							{
								this.$self_$31822 = self_;
								if (104223 - 57508 == 46715)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x0089DD5C File Offset: 0x0089BF5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadcamel.$RPC_stoneFall$31810.$(this.$mPos$31820, this.$tDir$31821, this.$self_$31822);
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x0089DD78 File Offset: 0x0089BF78
		internal static bool uebSUH5iVPbjhZhZ2Li4()
		{
			return true;
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x0089DD7C File Offset: 0x0089BF7C
		internal static bool Tpvctn5itSCLGlfN0BQg()
		{
			return false;
		}

		// Token: 0x04005047 RID: 20551
		internal Vector3 $mPos$31820;

		// Token: 0x04005048 RID: 20552
		internal Vector3 $tDir$31821;

		// Token: 0x04005049 RID: 20553
		internal Deadcamel $self_$31822;

		// Token: 0x02000C00 RID: 3072
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060044A6 RID: 17574 RVA: 0x0089DD80 File Offset: 0x0089BF80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Deadcamel self_)
			{
				if (100387 - 516460 != -416072)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (184345 - 359783 != -175437)
					{
						base..ctor();
						if (174098 - 296370 == -122272)
						{
							this.$mPos$31817 = mPos;
							if (168884 - 316286 == -147402)
							{
								this.$tDir$31818 = tDir;
								if (238750 - 416384 != -177633)
								{
									this.$self_$31819 = self_;
									if (146252 - 247501 == -101249)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060044A7 RID: 17575 RVA: 0x0089DE5C File Offset: 0x0089C05C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (211070 - 494490 != -283420)
				{
				}
				for (;;)
				{
					IL_39B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_878;
					case 2:
						if (this.$self_$31819.mChar.actionState != "attack")
						{
							if (101055 - 405830 != -304775)
							{
								continue;
							}
							if (this.$self_$31819.mChar.myCommand != "stoneFall")
							{
								if (48732 - 377038 != -328306)
								{
									continue;
								}
								goto IL_241;
							}
						}
						if (this.$self_$31819.stoneFall_ring)
						{
							if (223889 - 138051 == 85839)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$31819.stoneFall_ring, this.$self_$31819.transform.position, this.$self_$31819.transform.rotation);
							if (14555 - 510023 == -495467)
							{
								continue;
							}
						}
						Camera.main.SendMessage("AddCamereShake", 1);
						if (139266 - 89629 != 49637)
						{
							continue;
						}
						this.$hitLayer$31811 = 130816 - (1 << this.$self_$31819.gameObject.layer);
						if (254213 - 48949 == 205265)
						{
							continue;
						}
						this.$hitList$31812 = null;
						if (140126 - 454060 != -313934)
						{
							continue;
						}
						this.$hitPos$31813 = default(Vector3);
						if (299236 - 41107 != 258129)
						{
							continue;
						}
						this.$hitDir$31814 = default(Vector3);
						if (25963 - 76641 == -50677)
						{
							continue;
						}
						if (!this.$self_$31819.mChar.isMine)
						{
							goto IL_275;
						}
						if (245268 - 583936 == -338667)
						{
							continue;
						}
						this.$hitList$31812 = Damage.FindAreaTarget(this.$self_$31819.transform.position, (float)20, (float)4, this.$hitLayer$31811);
						if (282429 - 290927 == -8497)
						{
							continue;
						}
						this.$$iterator$10722$31816 = UnityRuntimeServices.GetEnumerator(this.$hitList$31812);
						if (113939 - 374612 != -260673)
						{
							continue;
						}
						while (this.$$iterator$10722$31816.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10722$31816.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$31815 = (GameObject)obj2;
							if (187642 - 45719 != 141923)
							{
								goto IL_39B;
							}
							if (this.$self_$31819.mChar.hit(21, this.$hitObject$31815, this.$self_$31819.mChar.talAdjust(20), 20, 0, 0.25f * Vector3.up) != 0)
							{
								if (201693 - 575516 == -373822)
								{
									goto IL_39B;
								}
								this.$self_$31819.StartCoroutine_Auto(this.$self_$31819.RPC_stoneFall_fire(this.$hitObject$31815.transform.position, Vector3.forward, 0));
								if (299850 - 427134 != -127284)
								{
									goto IL_39B;
								}
								UnityRuntimeServices.Update(this.$$iterator$10722$31816, this.$hitObject$31815);
								if (142542 - 291719 == -149176)
								{
									goto IL_39B;
								}
								this.$self_$31819.ActionEvent("RPC_stoneFall_fire", this.$hitObject$31815.transform.position, Vector3.forward, 0);
								if (78003 - 106862 == -28858)
								{
									goto IL_39B;
								}
								UnityRuntimeServices.Update(this.$$iterator$10722$31816, this.$hitObject$31815);
								if (290002 - 123865 != 166137)
								{
									goto IL_39B;
								}
							}
						}
						if (223250 - 579774 != -356524)
						{
							continue;
						}
						goto IL_275;
					case 3:
						if (this.$self_$31819.mChar.actionState == "attack")
						{
							if (288341 - 167794 == 120548)
							{
								continue;
							}
							if (this.$self_$31819.mChar.myCommand == "stoneFall")
							{
								if (273935 - 277923 == -3987)
								{
									continue;
								}
								this.$self_$31819.mChar.actionState = "standby";
								if (238481 - 120681 != 117800)
								{
									continue;
								}
								this.$self_$31819.mChar.actionTime = Time.time;
								if (237651 - 19079 != 218572)
								{
									continue;
								}
								this.$self_$31819.mChar.myCommand = "none";
								if (188209 - 121997 != 66212)
								{
									continue;
								}
								if (!this.$self_$31819.mChar.isMine)
								{
									if (244385 - 390819 == -146433)
									{
										continue;
									}
									this.$self_$31819.mChar.nPosition = this.$self_$31819.transform.position;
									if (204407 - 96597 != 107810)
									{
										continue;
									}
									this.$self_$31819.mChar.oPosition = this.$self_$31819.transform.position;
									if (166301 - 186604 == -20302)
									{
										continue;
									}
									this.$self_$31819.mChar.nDirection = this.$self_$31819.transform.forward;
									if (91141 - 322701 != -231560)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (143981 - 14959 != 129023)
						{
							goto Block_48;
						}
						continue;
					default:
						if (241340 - 338966 != -97626)
						{
							continue;
						}
						break;
					}
					this.$self_$31819.mChar.actionState = "attack";
					if (190362 - 530311 == -339949)
					{
						this.$self_$31819.mChar.actionTime = Time.time;
						if (249496 - 596429 != -346932)
						{
							this.$self_$31819.mChar.myCommand = "stoneFall";
							if (92237 - 380519 != -288281)
							{
								this.$self_$31819.mChar.addTimeOut("cAttack", (float)12);
								if (80239 - 392963 == -312724)
								{
									this.$self_$31819.transform.position = this.$mPos$31817;
									if (72670 - 447123 == -374453)
									{
										this.$self_$31819.transform.LookAt(this.$mPos$31817 + global::Math.vFlat(this.$tDir$31818));
										if (102036 - 262718 != -160681)
										{
											this.$self_$31819.animation.CrossFade("stoneFall");
											if (297933 - 137854 == 160079)
											{
												this.$self_$31819.animation.wrapMode = WrapMode.Once;
												if (204949 - 422243 == -217294)
												{
													this.$self_$31819.mChar.vMovement = this.$self_$31819.transform.forward;
													if (73186 - 333690 != -260503)
													{
														this.$self_$31819.mChar.moveSpeed = (float)0;
														if (86381 - 544191 != -457809)
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
				IL_241:
				goto IL_878;
				IL_275:
				return this.Yield(3, new WaitForSeconds(0.9f));
				Block_26:
				return this.Yield(2, new WaitForSeconds(0.9f));
				Block_48:
				IL_878:
				return false;
			}

			// Token: 0x060044A8 RID: 17576 RVA: 0x0089E6F4 File Offset: 0x0089C8F4
			internal static bool wbTpJb5iNR9MqKUyht2r()
			{
				return true;
			}

			// Token: 0x060044A9 RID: 17577 RVA: 0x0089E6F8 File Offset: 0x0089C8F8
			internal static bool hfNDpF5iYeVKrauIEW78()
			{
				return false;
			}

			// Token: 0x0400504A RID: 20554
			internal int $hitLayer$31811;

			// Token: 0x0400504B RID: 20555
			internal UnityScript.Lang.Array $hitList$31812;

			// Token: 0x0400504C RID: 20556
			internal Vector3 $hitPos$31813;

			// Token: 0x0400504D RID: 20557
			internal Vector3 $hitDir$31814;

			// Token: 0x0400504E RID: 20558
			internal GameObject $hitObject$31815;

			// Token: 0x0400504F RID: 20559
			internal IEnumerator $$iterator$10722$31816;

			// Token: 0x04005050 RID: 20560
			internal Vector3 $mPos$31817;

			// Token: 0x04005051 RID: 20561
			internal Vector3 $tDir$31818;

			// Token: 0x04005052 RID: 20562
			internal Deadcamel $self_$31819;
		}
	}

	// Token: 0x02000C01 RID: 3073
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_stoneFall_fire$31823 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060044AA RID: 17578 RVA: 0x0089E6FC File Offset: 0x0089C8FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_stoneFall_fire$31823(Vector3 tPos, Deadcamel self_)
		{
			if (60178 - 491177 != -430998)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (294871 - 59125 == 235746)
				{
					base..ctor();
					if (174527 - 345865 != -171337)
					{
						this.$tPos$31830 = tPos;
						if (263637 - 10467 != 253171)
						{
							this.$self_$31831 = self_;
							if (202234 - 321548 != -119313)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x0089E7B8 File Offset: 0x0089C9B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadcamel.$RPC_stoneFall_fire$31823.$(this.$tPos$31830, this.$self_$31831);
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x0089E7CC File Offset: 0x0089C9CC
		internal static bool lJqtb75icLiOC8GEUjYl()
		{
			return true;
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x0089E7D0 File Offset: 0x0089C9D0
		internal static bool xYNgtq5iURiur4DRyc3K()
		{
			return false;
		}

		// Token: 0x04005053 RID: 20563
		internal Vector3 $tPos$31830;

		// Token: 0x04005054 RID: 20564
		internal Deadcamel $self_$31831;

		// Token: 0x02000C02 RID: 3074
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060044AE RID: 17582 RVA: 0x0089E7D4 File Offset: 0x0089C9D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 tPos, Deadcamel self_)
			{
				if (74313 - 292400 != -218086)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (584 - 261436 != -260851)
					{
						base..ctor();
						if (9530 - 574297 != -564766)
						{
							this.$tPos$31828 = tPos;
							if (266272 - 535552 == -269280)
							{
								this.$self_$31829 = self_;
								if (38063 - 5490 != 32574)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060044AF RID: 17583 RVA: 0x0089E890 File Offset: 0x0089CA90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (246277 - 538191 != -291914)
				{
				}
				for (;;)
				{
					IL_E1:
					switch (this._state)
					{
					case 0:
						goto IL_1D1;
					case 1:
						goto IL_2BA;
					case 2:
						if (!this.$self_$31829.stoneFall_fire)
						{
							goto IL_4F;
						}
						if (162028 - 317491 != -155462)
						{
							UnityEngine.Object.Instantiate(this.$self_$31829.stoneFall_fire, this.$tPos$31828, Quaternion.identity);
							if (48900 - 441322 != -392421)
							{
								goto Block_9;
							}
						}
						break;
					case 3:
						if (this.$self_$31829.mChar.isMine)
						{
							if (35639 - 535716 != -500077)
							{
								break;
							}
							this.$hitLayer$31824 = 130816 - (1 << this.$self_$31829.gameObject.layer);
							if (22592 - 150451 == -127858)
							{
								break;
							}
							this.$hitList$31825 = Damage.FindAreaTarget(this.$tPos$31828, (float)2, (float)4, this.$hitLayer$31824);
							if (14587 - 86246 == -71658)
							{
								break;
							}
							this.$$iterator$10721$31827 = UnityRuntimeServices.GetEnumerator(this.$hitList$31825);
							if (80440 - 516473 != -436033)
							{
								break;
							}
							while (this.$$iterator$10721$31827.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10721$31827.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31826 = (GameObject)obj2;
								if (212810 - 497227 != -284417)
								{
									goto IL_E1;
								}
								this.$self_$31829.mChar.hit(22, this.$hitObject$31826, this.$self_$31829.mChar.talAdjust(100), 20, 0, Vector3.zero);
								if (54539 - 194742 != -140203)
								{
									goto IL_E1;
								}
								UnityRuntimeServices.Update(this.$$iterator$10721$31827, this.$hitObject$31826);
								if (140412 - 24158 != 116254)
								{
									goto IL_E1;
								}
							}
							if (223266 - 161138 != 62128)
							{
								break;
							}
						}
						this.YieldDefault(1);
						if (246112 - 164213 != 81900)
						{
							goto Block_10;
						}
						break;
					default:
						if (125742 - 584546 == -458804)
						{
							goto IL_1D1;
						}
						break;
					}
				}
				IL_4F:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_9:
				goto IL_4F;
				Block_10:
				goto IL_2BA;
				IL_1D1:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_2BA:
				return false;
			}

			// Token: 0x060044B0 RID: 17584 RVA: 0x0089EB6C File Offset: 0x0089CD6C
			internal static bool MJHY6O5iTk8KeQCBMCfM()
			{
				return true;
			}

			// Token: 0x060044B1 RID: 17585 RVA: 0x0089EB70 File Offset: 0x0089CD70
			internal static bool n0VOgm5i3LXgfjnP2I0s()
			{
				return false;
			}

			// Token: 0x04005055 RID: 20565
			internal int $hitLayer$31824;

			// Token: 0x04005056 RID: 20566
			internal UnityScript.Lang.Array $hitList$31825;

			// Token: 0x04005057 RID: 20567
			internal GameObject $hitObject$31826;

			// Token: 0x04005058 RID: 20568
			internal IEnumerator $$iterator$10721$31827;

			// Token: 0x04005059 RID: 20569
			internal Vector3 $tPos$31828;

			// Token: 0x0400505A RID: 20570
			internal Deadcamel $self_$31829;
		}
	}

	// Token: 0x02000C03 RID: 3075
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31832 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060044B2 RID: 17586 RVA: 0x0089EB74 File Offset: 0x0089CD74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31832(UnityScript.Lang.Array nArray, Deadcamel self_)
		{
			if (264650 - 18621 != 246029)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (221246 - 565314 == -344068)
				{
					base..ctor();
					if (200138 - 280659 != -80520)
					{
						this.$nArray$31837 = nArray;
						if (212681 - 207813 != 4869)
						{
							this.$self_$31838 = self_;
							if (280932 - 441691 == -160759)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x0089EC30 File Offset: 0x0089CE30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadcamel.$RPC_ko$31832.$(this.$nArray$31837, this.$self_$31838);
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x0089EC44 File Offset: 0x0089CE44
		internal static bool lojPLu5iX5RoQE1cJRbx()
		{
			return true;
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x0089EC48 File Offset: 0x0089CE48
		internal static bool LSL5eb5iQvZSuS6c2Qcv()
		{
			return false;
		}

		// Token: 0x0400505B RID: 20571
		internal UnityScript.Lang.Array $nArray$31837;

		// Token: 0x0400505C RID: 20572
		internal Deadcamel $self_$31838;

		// Token: 0x02000C04 RID: 3076
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060044B6 RID: 17590 RVA: 0x0089EC4C File Offset: 0x0089CE4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Deadcamel self_)
			{
				if (240324 - 370296 != -129972)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (66133 - 248227 == -182094)
					{
						base..ctor();
						if (69455 - 285972 != -216516)
						{
							this.$nArray$31835 = nArray;
							if (222610 - 378829 != -156218)
							{
								this.$self_$31836 = self_;
								if (244606 - 456707 == -212101)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060044B7 RID: 17591 RVA: 0x0089ED08 File Offset: 0x0089CF08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (286938 - 459664 != -172726)
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
						if (this.$self_$31836.mChar.actionState != "ko")
						{
							if (65905 - 327055 != -261150)
							{
								continue;
							}
							goto IL_33C;
						}
						else
						{
							this.$self_$31836.animation.Play("getUp");
							if (89538 - 366744 != -277206)
							{
								continue;
							}
							this.$self_$31836.animation.wrapMode = WrapMode.Once;
							if (222253 - 485859 != -263605)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31836.mChar.actionState != "ko")
						{
							if (205443 - 104700 != 100743)
							{
								continue;
							}
							goto IL_221;
						}
						else
						{
							this.$self_$31836.mChar.actionState = "standby";
							if (243083 - 72584 != 170499)
							{
								continue;
							}
							this.$self_$31836.mChar.actionTime = Time.time;
							if (172634 - 110092 == 62543)
							{
								continue;
							}
							this.$self_$31836.mChar.myCommand = "none";
							if (6649 - 45844 != -39195)
							{
								continue;
							}
							this.$self_$31836.mChar.ko = this.$self_$31836.mChar.mko;
							if (257993 - 443189 != -185196)
							{
								continue;
							}
							this.YieldDefault(1);
							if (264573 - 3826 != 260747)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (11737 - 101476 != -89739)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31836.mChar.actionState == "ko")
					{
						goto IL_67;
					}
					if (19749 - 140070 != -120320)
					{
						if (this.$self_$31836.mChar.actionState == "dead")
						{
							if (24313 - 502952 != -478638)
							{
								goto Block_24;
							}
						}
						else
						{
							this.$mPos$31833 = (Vector3)this.$nArray$31835[0];
							if (220633 - 193713 == 26920)
							{
								this.$mDir$31834 = (Vector3)this.$nArray$31835[1];
								if (23665 - 356746 != -333080)
								{
									this.$self_$31836.mChar.ko = 0;
									if (64108 - 406520 == -342412)
									{
										this.$self_$31836.mChar.actionState = "ko";
										if (128252 - 591057 == -462805)
										{
											this.$self_$31836.mChar.actionTime = Time.time;
											if (96654 - 429307 == -332653)
											{
												this.$self_$31836.mChar.myCommand = "none";
												if (260706 - 220998 != 39709)
												{
													this.$self_$31836.mChar.vMovement = Vector3.zero;
													if (203191 - 412745 == -209554)
													{
														this.$self_$31836.mChar.moveSpeed = (float)0;
														if (223980 - 30475 == 193505)
														{
															this.$self_$31836.animation.Play("ko");
															if (163111 - 146285 != 16827)
															{
																this.$self_$31836.animation.wrapMode = WrapMode.Once;
																if (272220 - 529339 != -257118)
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
				return this.Yield(2, new WaitForSeconds(6f));
				IL_67:
				goto IL_48C;
				Block_12:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_221:
				IL_33C:
				Block_24:
				IL_48C:
				return false;
			}

			// Token: 0x060044B8 RID: 17592 RVA: 0x0089F1B4 File Offset: 0x0089D3B4
			internal static bool XjS5UY5ik2HFGQ6OPyeB()
			{
				return true;
			}

			// Token: 0x060044B9 RID: 17593 RVA: 0x0089F1B8 File Offset: 0x0089D3B8
			internal static bool aATepv5iGb4SxcOP9DR3()
			{
				return false;
			}

			// Token: 0x0400505D RID: 20573
			internal Vector3 $mPos$31833;

			// Token: 0x0400505E RID: 20574
			internal Vector3 $mDir$31834;

			// Token: 0x0400505F RID: 20575
			internal UnityScript.Lang.Array $nArray$31835;

			// Token: 0x04005060 RID: 20576
			internal Deadcamel $self_$31836;
		}
	}

	// Token: 0x02000C05 RID: 3077
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31839 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060044BA RID: 17594 RVA: 0x0089F1BC File Offset: 0x0089D3BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31839(UnityScript.Lang.Array nArray, Deadcamel self_)
		{
			if (37919 - 382624 != -344705)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (44910 - 514347 != -469436)
				{
					base..ctor();
					if (263429 - 191922 != 71508)
					{
						this.$nArray$31844 = nArray;
						if (208376 - 20215 != 188162)
						{
							this.$self_$31845 = self_;
							if (280383 - 514416 != -234032)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x0089F278 File Offset: 0x0089D478
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadcamel.$RPC_dead$31839.$(this.$nArray$31844, this.$self_$31845);
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x0089F28C File Offset: 0x0089D48C
		internal static bool adAg3B5iHtqYWbiZwa6b()
		{
			return true;
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x0089F290 File Offset: 0x0089D490
		internal static bool w7iQOM5iWwljqrFgv92Y()
		{
			return false;
		}

		// Token: 0x04005061 RID: 20577
		internal UnityScript.Lang.Array $nArray$31844;

		// Token: 0x04005062 RID: 20578
		internal Deadcamel $self_$31845;

		// Token: 0x02000C06 RID: 3078
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060044BE RID: 17598 RVA: 0x0089F294 File Offset: 0x0089D494
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Deadcamel self_)
			{
				if (186349 - 536309 != -349960)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (16681 - 425623 == -408942)
					{
						base..ctor();
						if (176367 - 283435 == -107068)
						{
							this.$nArray$31842 = nArray;
							if (152333 - 55222 != 97112)
							{
								this.$self_$31843 = self_;
								if (236847 - 385124 != -148276)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060044BF RID: 17599 RVA: 0x0089F350 File Offset: 0x0089D550
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (207270 - 589220 != -381950)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_487;
					case 2:
						if (this.$self_$31843.mChar.actionState != "dead")
						{
							if (213835 - 411494 != -197659)
							{
								continue;
							}
							goto IL_E4;
						}
						else
						{
							Camera.main.SendMessage("AddCamereShake", 2);
							if (156387 - 587453 != -431066)
							{
								continue;
							}
							goto IL_1D0;
						}
						break;
					case 3:
						if (this.$self_$31843.mChar.actionState != "dead")
						{
							if (198391 - 427322 != -228931)
							{
								continue;
							}
							goto IL_118;
						}
						else
						{
							if (this.$self_$31843.mChar.isPlayer)
							{
								if (198384 - 214700 == -16315)
								{
									continue;
								}
								if (this.$self_$31843.mChar.isMine)
								{
									if (10228 - 554378 == -544149)
									{
										continue;
									}
									Camera.main.SendMessage("onDeadPlayer", this.$self_$31843.gameObject);
									if (4063 - 522895 == -518831)
									{
										continue;
									}
								}
							}
							this.YieldDefault(1);
							if (35099 - 380738 != -345638)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					default:
						if (205679 - 547444 == -341764)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31843.mChar.actionState == "dead")
					{
						if (193906 - 41930 != 151977)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$31840 = (Vector3)this.$nArray$31842[0];
						if (237444 - 496448 != -259003)
						{
							this.$myDirection$31841 = (Vector3)this.$nArray$31842[1];
							if (108389 - 229871 == -121482)
							{
								this.$self_$31843.transform.position = this.$myPosition$31840;
								if (126377 - 466135 != -339757)
								{
									this.$self_$31843.transform.LookAt(this.$myPosition$31840 + this.$myDirection$31841);
									if (137800 - 383913 != -246112)
									{
										this.$self_$31843.mChar.hp = 0;
										if (91449 - 307938 != -216488)
										{
											this.$self_$31843.mChar.actionState = "dead";
											if (15276 - 22902 != -7625)
											{
												this.$self_$31843.mChar.actionTime = Time.time;
												if (124744 - 110377 == 14367)
												{
													this.$self_$31843.mChar.myCommand = "none";
													if (146692 - 300265 != -153572)
													{
														this.$self_$31843.mChar.vMovement = Vector3.zero;
														if (192030 - 424007 != -231976)
														{
															this.$self_$31843.mChar.moveSpeed = (float)0;
															if (226191 - 333768 == -107577)
															{
																this.$self_$31843.animation.Rewind();
																if (15828 - 559910 != -544081)
																{
																	this.$self_$31843.animation.Play("dead");
																	if (155415 - 316792 != -161376)
																	{
																		this.$self_$31843.animation.wrapMode = WrapMode.Once;
																		if (14952 - 296816 != -281863)
																		{
																			goto Block_23;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_E4:
				IL_118:
				goto IL_487;
				IL_1D0:
				return this.Yield(3, new WaitForSeconds(2.2f));
				Block_22:
				goto IL_487;
				Block_23:
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_487:
				return false;
			}

			// Token: 0x060044C0 RID: 17600 RVA: 0x0089F7F8 File Offset: 0x0089D9F8
			internal static bool HnVh7I5iAN8jPtI9KEP6()
			{
				return true;
			}

			// Token: 0x060044C1 RID: 17601 RVA: 0x0089F7FC File Offset: 0x0089D9FC
			internal static bool YS8foY5ilpUDm6eaFZxC()
			{
				return false;
			}

			// Token: 0x04005063 RID: 20579
			internal Vector3 $myPosition$31840;

			// Token: 0x04005064 RID: 20580
			internal Vector3 $myDirection$31841;

			// Token: 0x04005065 RID: 20581
			internal UnityScript.Lang.Array $nArray$31842;

			// Token: 0x04005066 RID: 20582
			internal Deadcamel $self_$31843;
		}
	}
}
