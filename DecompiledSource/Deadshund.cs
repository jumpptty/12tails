using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C08 RID: 3080
[Serializable]
public class Deadshund : MonoBehaviour
{
	// Token: 0x060044CF RID: 17615 RVA: 0x008A21DC File Offset: 0x008A03DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Deadshund()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060044D0 RID: 17616 RVA: 0x008A21EC File Offset: 0x008A03EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (179894 - 406530 != -226636)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (102565 - 514584 == -412019)
			{
				this.mChar.actionState = "standby";
				if (4471 - 288589 == -284118)
				{
					this.mChar.actionTime = Time.time;
					if (129036 - 548997 == -419961)
					{
						this.mChar.myCommand = "none";
						if (82649 - 481055 == -398406)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060044D1 RID: 17617 RVA: 0x008A22D8 File Offset: 0x008A04D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (242631 - 149992 != 92639)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (267625 - 277214 == -9588)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (24683 - 30275 != -5592)
				{
					continue;
				}
			}
			if (!this.mChar)
			{
				break;
			}
			if (51964 - 432423 != -380458)
			{
				this.mChar.StartCoroutine_Auto(this.mChar.addStatus("livingDead", 1, 300, 0, this.mChar.ActorNr));
				if (297903 - 254153 == 43750)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060044D2 RID: 17618 RVA: 0x008A23D0 File Offset: 0x008A05D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (1298 - 97413 != -96114)
		{
		}
		for (;;)
		{
			if (!this.mChar)
			{
				if (254930 - 17418 == 237512)
				{
					break;
				}
			}
			else
			{
				if (this.mChar.isControlled)
				{
					if (140175 - 589973 != -449798)
					{
						continue;
					}
					if (!(this.mChar.actionState == "standby"))
					{
						if (94840 - 473747 != -378907)
						{
							continue;
						}
						if (!(this.mChar.actionState == "run"))
						{
							goto IL_385;
						}
						if (91603 - 254240 != -162637)
						{
							continue;
						}
					}
					this.PlayerControl();
					if (189137 - 428098 != -238961)
					{
						continue;
					}
				}
				IL_385:
				if (this.mChar.hp <= 0)
				{
					if (24327 - 361582 == -337254)
					{
						continue;
					}
					if (this.mChar.actionState != "dead")
					{
						if (212199 - 423808 == -211608)
						{
							continue;
						}
						if (this.mChar.isMine)
						{
							if (281447 - 510649 == -229201)
							{
								continue;
							}
							statusClass status = this.mChar.getStatus("livingDead");
							if (69562 - 346538 != -276976)
							{
								continue;
							}
							if (status != null)
							{
								if (116862 - 434524 == -317661)
								{
									continue;
								}
								this.mChar.hp = 1;
								if (70867 - 357704 != -286837)
								{
									continue;
								}
								this.mChar.RPC_RemoveStatus("livingDead");
								if (297887 - 28025 == 269863)
								{
									continue;
								}
								this.RPC_livingDead_hit(Vector3.zero, Vector3.zero, 0);
								if (245094 - 445120 == -200025)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (243762 - 108596 == 135167)
									{
										continue;
									}
									this.ActionEvent("RPC_livingDead_hit", Vector3.zero, Vector3.zero, 0);
									if (151224 - 166380 != -15156)
									{
										continue;
									}
								}
								this.mChar.RPC_AddHeal(21, this.mChar.mhp, 0, 0, 0, 0, status.sID);
								if (122354 - 418091 != -295737)
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
								if (233092 - 544785 == -311692)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (166148 - 273286 == -107137)
								{
									continue;
								}
								this.mChar.DeadEvent();
								if (230477 - 277911 != -47433)
								{
									break;
								}
								continue;
							}
						}
						else
						{
							this.mChar.hp = 1;
							if (37577 - 303076 != -265499)
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
				if (189304 - 17197 != 172108)
				{
					if (this.mChar.ko > 0)
					{
						break;
					}
					if (273213 - 57435 == 215778)
					{
						if (!(this.mChar.actionState != "ko"))
						{
							break;
						}
						if (21960 - 510575 == -488615)
						{
							if (!(this.mChar.actionState != "dead"))
							{
								break;
							}
							if (20177 - 551954 == -531777)
							{
								if (this.mChar.isMine)
								{
									if (251664 - 284483 == -32819)
									{
										this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
										{
											this.transform.position,
											this.transform.forward
										})));
										if (242579 - 70709 == 171870)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (83823 - 325161 != -241337)
											{
												this.mChar.KoEvent();
												if (41900 - 221728 == -179828)
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
									if (227418 - 552787 != -325368)
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

	// Token: 0x060044D3 RID: 17619 RVA: 0x008A2954 File Offset: 0x008A0B54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (205293 - 179592 != 25702)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (205215 - 277095 == -71880)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (72737 - 227890 != -155152)
				{
					if (215168 - 17402 == 197766)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (236780 - 374424 != -137644)
							{
								continue;
							}
							v = 1;
							if (144162 - 515279 != -371117)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (294314 - 386527 == -92212)
							{
								continue;
							}
							v = -1;
							if (33129 - 472401 != -439272)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_deadSpit")
						{
							if (108087 - 243906 == -135818)
							{
								continue;
							}
							v = 11;
							if (186705 - 80949 != 105756)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_deadSpit_fire")
						{
							if (66318 - 123620 != -57302)
							{
								continue;
							}
							v = 12;
							if (155884 - 955 == 154930)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_deadSpit_hit")
						{
							if (120941 - 484761 != -363820)
							{
								continue;
							}
							v = -12;
							if (64905 - 564020 != -499115)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_livingDead_hit")
						{
							if (21169 - 117433 != -96264)
							{
								continue;
							}
							v = -50;
							if (72007 - 400525 != -328518)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (193882 - 21781 == 172102)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (244127 - 536418 == -292291)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (5725 - 168668 == -162943)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (275785 - 585270 != -309484)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (132728 - 100015 != 32714)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (215429 - 487601 != -272171)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (30575 - 14511 == 16064)
											{
												Hashtable hashtable = new Hashtable();
												if (50993 - 324631 == -273638)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (57186 - 12044 != 45143)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (210852 - 542696 == -331844)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (230586 - 66114 == 164472)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (271560 - 4181 == 267379)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (299843 - 459165 == -159322)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (274057 - 581460 == -307403)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (276140 - 535038 != -258897)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (104362 - 404028 == -299666)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (113753 - 176853 != -63099)
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

	// Token: 0x060044D4 RID: 17620 RVA: 0x008A2F04 File Offset: 0x008A1104
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (51276 - 532474 != -481198)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (131052 - 171121 != -40068)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (170113 - 209465 != -39351)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (211701 - 252390 != -40688)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (1154 - 307587 == -306433)
						{
							int num3 = num;
							if (48105 - 472793 == -424688)
							{
								if (num3 == 1)
								{
									if (240492 - 305724 == -65232)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (200041 - 386254 == -186213)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (30261 - 107431 == -77170)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (31477 - 350979 == -319502)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (60687 - 474359 != -413671)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (274009 - 337551 != -63541)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (225254 - 436676 != -211421)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (164473 - 566450 != -401976)
										{
											this.StartCoroutine_Auto(this.RPC_deadSpit(vector, vector2, num2));
											if (26924 - 197410 == -170486)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (151060 - 209718 == -58658)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (69053 - 316948 == -247895)
										{
											this.RPC_deadSpit_fire(vector, vector2, num2);
											if (57305 - 229828 != -172522)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -12)
								{
									if (165882 - 319059 != -153176)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (128983 - 336827 == -207844)
										{
											this.RPC_deadSpit_hit(vector, vector2, num2);
											if (224374 - 206029 != 18346)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -50)
								{
									if (247827 - 503675 != -255847)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (54369 - 96983 == -42614)
										{
											this.RPC_livingDead_hit(vector, vector2, num2);
											if (154216 - 311266 == -157050)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (5289 - 186281 == -180992)
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

	// Token: 0x060044D5 RID: 17621 RVA: 0x008A3374 File Offset: 0x008A1574
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (133447 - 446400 != -312953)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (138247 - 10530 == 127717)
			{
				float runSpeed = this.mChar.runSpeed;
				if (278423 - 216868 != 61556)
				{
					Vector3 a = default(Vector3);
					if (23723 - 179303 == -155580)
					{
						Vector3 vector = Vector3.zero;
						if (199298 - 180235 != 19064)
						{
							float num2 = (float)0;
							if (105736 - 287861 != -182124)
							{
								if (this.mChar.isMine)
								{
									if (278708 - 236211 == 42498)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (70518 - 280199 != -209681)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (98907 - 36910 == 61998)
										{
											continue;
										}
										a.y = (float)0;
										if (294731 - 359856 == -65124)
										{
											continue;
										}
										a = a.normalized;
										if (294693 - 19617 == 275077)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (169199 - 403737 != -234538)
										{
											continue;
										}
										vector = vector.normalized;
										if (74947 - 443033 == -368085)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (114276 - 593424 == -479147)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (256132 - 362022 == -105889)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (242170 - 366706 != -124536)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (143385 - 329211 != -185826)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (218466 - 57434 != 161032)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (10038 - 505151 == -495112)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (244555 - 220565 != 23990)
														{
															continue;
														}
														this.animation.Play("run");
														if (97645 - 592543 != -494898)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (26053 - 517014 != -490960)
														{
															goto IL_302;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (156337 - 185705 != -29368)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (147887 - 433516 == -285628)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (166000 - 226842 == -60841)
											{
												continue;
											}
											num = (float)0;
											if (218210 - 30943 == 187268)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.3f);
										if (79704 - 206585 == -126880)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (259764 - 310609 != -50845)
										{
											continue;
										}
									}
									IL_302:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (48620 - 389500 != -340880)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (146966 - 446987 == -300020)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (56256 - 15165 == 41092)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (160156 - 425729 == -265572)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (216641 - 241222 == -24580)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (153568 - 474767 != -321199)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (214167 - 259938 != -45771)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (193958 - 74394 == 119565)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (227163 - 268249 == -41085)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (137570 - 266193 != -128623)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (128718 - 144056 != -15338)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (241266 - 58443 != 182823)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (277236 - 99306 != 177930)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (189739 - 499417 == -309677)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (148195 - 351637 == -203441)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (3421 - 496753 != -493332)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (214110 - 559982 == -345871)
												{
													continue;
												}
												num = (float)0;
												if (128956 - 271212 != -142256)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (132446 - 165539 != -33093)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.3f);
											if (154734 - 522972 != -368238)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (226339 - 52134 != 174205)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (125541 - 333471 != -207930)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (4315 - 260032 == -255716)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (105967 - 104557 != 1410)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (115105 - 221595 != -106490)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (61781 - 374853 != -313072)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (282378 - 15197 != 267181)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (52819 - 258870 == -206050)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (293535 - 158274 != 135261)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (63459 - 41113 != 22346)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (31258 - 61942 == -30683)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (97893 - 101157 == -3263)
											{
												continue;
											}
											num = (float)0;
											if (267329 - 594232 == -326902)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.3f);
											if (104790 - 160439 != -55649)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (17282 - 21847 != -4565)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.3f);
										if (110670 - 400632 != -289962)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (33555 - 451284 == -417728)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (71078 - 114009 != -42930)
								{
									this.mChar.moveSpeed = num;
									if (228750 - 461277 == -232527)
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

	// Token: 0x060044D6 RID: 17622 RVA: 0x008A3ED8 File Offset: 0x008A20D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (289749 - 105233 != 184517)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (151919 - 269646 != -117726)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (134367 - 546549 != -412181)
				{
					Vector3 vector = a - this.transform.position;
					if (237090 - 566027 == -328937)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (212529 - 577814 == -365285)
						{
							CharacterControl characterControl = null;
							if (107766 - 112678 != -4911)
							{
								if (297350 - 22033 == 275317)
								{
									if (gameObject)
									{
										if (90649 - 213003 != -122354)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (231620 - 215954 == 15667)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (292326 - 37411 == 254916)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (24563 - 263149 == -238585)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (273002 - 182674 != 90328)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (97395 - 19891 == 77505)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (140398 - 468687 == -328289)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (261716 - 518897 != -257180)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (38902 - 208885 == -169983)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (197817 - 62710 == 135107)
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

	// Token: 0x060044D7 RID: 17623 RVA: 0x008A41D0 File Offset: 0x008A23D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (18044 - 395684 != -377640)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (81597 - 236545 != -154947)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (205275 - 534127 != -328851)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (9103 - 566053 == -556950)
					{
						Vector3 normalized = vector.normalized;
						if (176262 - 424760 != -248497)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (43288 - 589761 != -546472)
							{
								CharacterControl characterControl = null;
								if (140131 - 506142 == -366011)
								{
									int tID = 0;
									if (146863 - 401456 != -254592)
									{
										if (gameObject)
										{
											if (173510 - 296796 != -123286)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (259363 - 128904 != 130459)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (85403 - 554 == 84850)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (272877 - 386427 != -113550)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (234809 - 577841 == -343031)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (60601 - 28999 == 31603)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (28583 - 372788 == -344205)
										{
											this.StartCoroutine_Auto(this.RPC_deadSpit(this.transform.position, normalized, tID));
											if (22051 - 98708 != -76656)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (103567 - 451575 == -348008)
												{
													this.ActionEvent("RPC_deadSpit", this.transform.position, normalized, tID);
													if (152844 - 521747 != -368902)
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

	// Token: 0x060044D8 RID: 17624 RVA: 0x008A44F4 File Offset: 0x008A26F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060044D9 RID: 17625 RVA: 0x008A44F8 File Offset: 0x008A26F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Deadshund.$RPC_nAttack$31846(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060044DA RID: 17626 RVA: 0x008A4508 File Offset: 0x008A2708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (165144 - 37892 != 127252)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (28371 - 577889 == -549518)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (112812 - 505908 == -393096)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (104583 - 61161 == 43422)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060044DB RID: 17627 RVA: 0x008A45C0 File Offset: 0x008A27C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_deadSpit(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Deadshund.$RPC_deadSpit$31859(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060044DC RID: 17628 RVA: 0x008A45D0 File Offset: 0x008A27D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_deadSpit_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (258676 - 439165 != -180488)
		{
		}
		for (;;)
		{
			if (this.deadSpit_fire)
			{
				if (269656 - 517924 == -248268)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.deadSpit_fire, firePos, Quaternion.LookRotation(fireDir));
					if (147164 - 150351 != -3186)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (231324 - 66959 != 164366)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (263701 - 21282 != 242420)
							{
								projectileControl.life = (float)2 * this.mChar.rangeMod;
								if (232864 - 49390 == 183474)
								{
									break;
								}
							}
						}
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find deadSpit_fire Effect");
				if (248557 - 381764 == -133207)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060044DD RID: 17629 RVA: 0x008A4718 File Offset: 0x008A2918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_deadSpit_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (92278 - 159101 != -66822)
		{
		}
		for (;;)
		{
			if (this.deadGoo)
			{
				if (82975 - 587012 == -504037)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.deadGoo, hitPos, this.transform.rotation);
					if (248004 - 543358 == -295354)
					{
						Deadshund_deadGoo deadshund_deadGoo = (Deadshund_deadGoo)gameObject.GetComponent("Deadshund_deadGoo");
						if (167409 - 206192 == -38783)
						{
							deadshund_deadGoo.Init(this.mChar.ActorNr);
							if (53185 - 290146 != -236960)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find deadGoo Effect");
				if (253306 - 540386 == -287080)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060044DE RID: 17630 RVA: 0x008A4830 File Offset: 0x008A2A30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_livingDead_hit(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (89020 - 149116 != -60095)
		{
		}
		for (;;)
		{
			if (this.livingDead_hit)
			{
				if (129493 - 342966 != -213472)
				{
					this.mChar.createEffect(this.livingDead_hit, this.transform.position + (float)2 * Vector3.up, this.transform.rotation);
					if (201015 - 464573 != -263557)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Warning cannot find livingDead_hit effect");
				if (188210 - 169257 == 18953)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060044DF RID: 17631 RVA: 0x008A4910 File Offset: 0x008A2B10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Deadshund.$RPC_ko$31873(nArray, this).GetEnumerator();
	}

	// Token: 0x060044E0 RID: 17632 RVA: 0x008A4920 File Offset: 0x008A2B20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Deadshund.$RPC_dead$31880(nArray, this).GetEnumerator();
	}

	// Token: 0x060044E1 RID: 17633 RVA: 0x008A4930 File Offset: 0x008A2B30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060044E2 RID: 17634 RVA: 0x008A4934 File Offset: 0x008A2B34
	internal static bool UlcZh45iox0j9b3vY7C9()
	{
		return true;
	}

	// Token: 0x060044E3 RID: 17635 RVA: 0x008A4938 File Offset: 0x008A2B38
	internal static bool gZUvPp5iE3bfy5n80E8V()
	{
		return false;
	}

	// Token: 0x0400506D RID: 20589
	public CharacterControl mChar;

	// Token: 0x0400506E RID: 20590
	public AudioClip deadshund_bark;

	// Token: 0x0400506F RID: 20591
	public GameObject nAttack_hit;

	// Token: 0x04005070 RID: 20592
	public GameObject deadSpit_fire;

	// Token: 0x04005071 RID: 20593
	public GameObject deadGoo;

	// Token: 0x04005072 RID: 20594
	public GameObject livingDead_hit;

	// Token: 0x02000C09 RID: 3081
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$31846 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060044E4 RID: 17636 RVA: 0x008A493C File Offset: 0x008A2B3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$31846(Vector3 mPos, Vector3 tDir, Deadshund self_)
		{
			if (217547 - 579953 != -362405)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (134370 - 498069 == -363699)
				{
					base..ctor();
					if (65220 - 23432 == 41788)
					{
						this.$mPos$31856 = mPos;
						if (98996 - 221628 == -122632)
						{
							this.$tDir$31857 = tDir;
							if (140915 - 590637 == -449722)
							{
								this.$self_$31858 = self_;
								if (225235 - 156626 == 68609)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x008A4A18 File Offset: 0x008A2C18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadshund.$RPC_nAttack$31846.$(this.$mPos$31856, this.$tDir$31857, this.$self_$31858);
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x008A4A34 File Offset: 0x008A2C34
		internal static bool luX4Qe5i22gV1f6MQuHB()
		{
			return true;
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x008A4A38 File Offset: 0x008A2C38
		internal static bool yG1TlR5i8PRwgwa1Ie4U()
		{
			return false;
		}

		// Token: 0x04005073 RID: 20595
		internal Vector3 $mPos$31856;

		// Token: 0x04005074 RID: 20596
		internal Vector3 $tDir$31857;

		// Token: 0x04005075 RID: 20597
		internal Deadshund $self_$31858;

		// Token: 0x02000C0A RID: 3082
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060044E8 RID: 17640 RVA: 0x008A4A3C File Offset: 0x008A2C3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Deadshund self_)
			{
				if (136410 - 395480 != -259069)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (53918 - 228068 == -174150)
					{
						base..ctor();
						if (234706 - 570951 != -336244)
						{
							this.$mPos$31853 = mPos;
							if (240532 - 168095 == 72437)
							{
								this.$tDir$31854 = tDir;
								if (6187 - 453250 != -447062)
								{
									this.$self_$31855 = self_;
									if (153414 - 440099 != -286684)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060044E9 RID: 17641 RVA: 0x008A4B18 File Offset: 0x008A2D18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (291705 - 492561 != -200856)
				{
				}
				for (;;)
				{
					IL_33D:
					switch (this._state)
					{
					case 0:
						goto IL_30E;
					case 1:
						goto IL_9E4;
					case 2:
						if (this.$self_$31855.mChar.actionState != "attack")
						{
							if (286549 - 453273 != -166724)
							{
								continue;
							}
							if (this.$self_$31855.mChar.myCommand != "nAttack")
							{
								if (2471 - 515389 != -512918)
								{
									continue;
								}
								goto IL_1A;
							}
						}
						this.$self_$31855.mChar.moveSpeed = (float)4;
						if (139657 - 401451 == -261793)
						{
							continue;
						}
						this.$i$31847 = 0;
						if (61062 - 91208 == -30145)
						{
							continue;
						}
						break;
					case 3:
						if (this.$self_$31855.mChar.actionState != "attack")
						{
							if (180377 - 277188 != -96811)
							{
								continue;
							}
							if (this.$self_$31855.mChar.myCommand != "nAttack")
							{
								if (28999 - 526584 != -497584)
								{
									goto Block_14;
								}
								continue;
							}
						}
						if (this.$self_$31855.mChar.isMine)
						{
							if (274946 - 9496 != 265450)
							{
								continue;
							}
							this.$hitLayer$31848 = 130816 - (1 << this.$self_$31855.gameObject.layer);
							if (85018 - 199279 != -114261)
							{
								continue;
							}
							this.$hitList$31849 = Damage.FindAreaTarget(this.$self_$31855.transform.position + this.$self_$31855.transform.forward, (float)1, (float)2, this.$hitLayer$31848);
							if (255388 - 576112 == -320723)
							{
								continue;
							}
							this.$$iterator$10724$31852 = UnityRuntimeServices.GetEnumerator(this.$hitList$31849);
							if (224880 - 47631 != 177249)
							{
								continue;
							}
							while (this.$$iterator$10724$31852.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10724$31852.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31850 = (GameObject)obj2;
								if (194103 - 122384 != 71719)
								{
									goto IL_33D;
								}
								if (this.$self_$31855.mChar.hit(1, this.$hitObject$31850, (int)(0.5f * (float)this.$self_$31855.mChar.atk), 3, 0, 0.2f * Vector3.forward) != 0)
								{
									if (192135 - 44405 != 147730)
									{
										goto IL_33D;
									}
									this.$hitPos$31851 = this.$hitObject$31850.collider.ClosestPointOnBounds(this.$self_$31855.transform.position + Vector3.up);
									if (67519 - 149733 != -82214)
									{
										goto IL_33D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10724$31852, this.$hitObject$31850);
									if (152345 - 199778 != -47433)
									{
										goto IL_33D;
									}
									this.$self_$31855.RPC_nAttack_hit(this.$hitPos$31851, this.$self_$31855.transform.forward, 0);
									if (89001 - 474871 == -385869)
									{
										goto IL_33D;
									}
									this.$self_$31855.ActionEvent("RPC_nAttack_hit", this.$hitPos$31851, this.$self_$31855.transform.forward, 0);
									if (223741 - 225058 == -1316)
									{
										goto IL_33D;
									}
									this.$self_$31855.mChar.sp = this.$self_$31855.mChar.sp + 1;
									if (274888 - 142773 == 132116)
									{
										goto IL_33D;
									}
								}
							}
							if (39157 - 207626 == -168468)
							{
								continue;
							}
						}
						this.$i$31847++;
						if (123872 - 57222 == 66651)
						{
							continue;
						}
						break;
					case 4:
						if (this.$self_$31855.mChar.actionState != "attack")
						{
							if (130999 - 381587 != -250588)
							{
								continue;
							}
							if (this.$self_$31855.mChar.myCommand != "nAttack")
							{
								if (219067 - 370187 != -151120)
								{
									continue;
								}
								goto IL_4DF;
							}
						}
						this.$self_$31855.mChar.moveSpeed = (float)2;
						if (288706 - 480906 != -192199)
						{
							goto Block_32;
						}
						continue;
					case 5:
						if (this.$self_$31855.mChar.actionState == "attack")
						{
							if (151829 - 338881 != -187052)
							{
								continue;
							}
							if (this.$self_$31855.mChar.myCommand == "nAttack")
							{
								if (33182 - 529526 == -496343)
								{
									continue;
								}
								this.$self_$31855.mChar.actionState = "standby";
								if (74175 - 391995 != -317820)
								{
									continue;
								}
								this.$self_$31855.mChar.actionTime = Time.time;
								if (180494 - 590468 == -409973)
								{
									continue;
								}
								this.$self_$31855.mChar.myCommand = "none";
								if (222297 - 26754 == 195544)
								{
									continue;
								}
								this.$self_$31855.mChar.moveSpeed = (float)0;
								if (275971 - 514743 != -238772)
								{
									continue;
								}
								if (!this.$self_$31855.mChar.isMine)
								{
									if (40515 - 145782 != -105267)
									{
										continue;
									}
									this.$self_$31855.mChar.nPosition = this.$self_$31855.transform.position;
									if (148607 - 469152 == -320544)
									{
										continue;
									}
									this.$self_$31855.mChar.oPosition = this.$self_$31855.transform.position;
									if (80538 - 159783 == -79244)
									{
										continue;
									}
									this.$self_$31855.mChar.nDirection = this.$self_$31855.transform.forward;
									if (5811 - 335297 != -329486)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (13306 - 388770 != -375464)
						{
							continue;
						}
						goto IL_9E4;
					default:
						if (90792 - 500940 != -410147)
						{
							goto IL_30E;
						}
						continue;
					}
					if (this.$i$31847 < 3)
					{
						goto IL_D9;
					}
					if (89136 - 316594 != -227458)
					{
						continue;
					}
					goto IL_846;
					IL_30E:
					this.$self_$31855.mChar.actionState = "attack";
					if (123272 - 552200 != -428927)
					{
						this.$self_$31855.mChar.actionTime = Time.time;
						if (142111 - 363247 == -221136)
						{
							this.$self_$31855.mChar.myCommand = "nAttack";
							if (278933 - 417952 == -139019)
							{
								this.$self_$31855.mChar.addTimeOut("nAttack", (float)6);
								if (81810 - 309558 == -227748)
								{
									this.$self_$31855.transform.position = this.$mPos$31853;
									if (259094 - 537768 == -278674)
									{
										this.$self_$31855.transform.LookAt(this.$mPos$31853 + global::Math.vFlat(this.$tDir$31854));
										if (80660 - 210053 == -129393)
										{
											this.$self_$31855.animation.CrossFade("nAttack");
											if (126323 - 331464 != -205140)
											{
												this.$self_$31855.animation.wrapMode = WrapMode.Once;
												if (51290 - 74020 != -22729)
												{
													this.$self_$31855.mChar.vMovement = this.$self_$31855.transform.forward;
													if (137799 - 287789 == -149990)
													{
														this.$self_$31855.mChar.moveSpeed = (float)0;
														if (61377 - 577365 == -515988)
														{
															goto IL_8F1;
														}
													}
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
				goto IL_9E4;
				IL_D9:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_14:
				IL_4DF:
				goto IL_9E4;
				Block_32:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_846:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_8F1:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_9E4:
				return false;
			}

			// Token: 0x060044EA RID: 17642 RVA: 0x008A551C File Offset: 0x008A371C
			internal static bool BXf43n5iZ0yyTCRBGVfO()
			{
				return true;
			}

			// Token: 0x060044EB RID: 17643 RVA: 0x008A5520 File Offset: 0x008A3720
			internal static bool Ei5cV75iClHZ5RHrI55I()
			{
				return false;
			}

			// Token: 0x04005076 RID: 20598
			internal int $i$31847;

			// Token: 0x04005077 RID: 20599
			internal int $hitLayer$31848;

			// Token: 0x04005078 RID: 20600
			internal UnityScript.Lang.Array $hitList$31849;

			// Token: 0x04005079 RID: 20601
			internal GameObject $hitObject$31850;

			// Token: 0x0400507A RID: 20602
			internal Vector3 $hitPos$31851;

			// Token: 0x0400507B RID: 20603
			internal IEnumerator $$iterator$10724$31852;

			// Token: 0x0400507C RID: 20604
			internal Vector3 $mPos$31853;

			// Token: 0x0400507D RID: 20605
			internal Vector3 $tDir$31854;

			// Token: 0x0400507E RID: 20606
			internal Deadshund $self_$31855;
		}
	}

	// Token: 0x02000C0B RID: 3083
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_deadSpit$31859 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060044EC RID: 17644 RVA: 0x008A5524 File Offset: 0x008A3724
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_deadSpit$31859(Vector3 mPos, Vector3 tDir, int tID, Deadshund self_)
		{
			if (159879 - 117747 != 42132)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (202759 - 199475 != 3285)
				{
					base..ctor();
					if (187579 - 92531 == 95048)
					{
						this.$mPos$31869 = mPos;
						if (98195 - 283313 == -185118)
						{
							this.$tDir$31870 = tDir;
							if (240871 - 468182 == -227311)
							{
								this.$tID$31871 = tID;
								if (296790 - 247574 == 49216)
								{
									this.$self_$31872 = self_;
									if (155396 - 258349 == -102953)
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

		// Token: 0x060044ED RID: 17645 RVA: 0x008A5624 File Offset: 0x008A3824
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadshund.$RPC_deadSpit$31859.$(this.$mPos$31869, this.$tDir$31870, this.$tID$31871, this.$self_$31872);
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x008A5644 File Offset: 0x008A3844
		internal static bool tW9naR5iLfca2y4yLpGr()
		{
			return true;
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x008A5648 File Offset: 0x008A3848
		internal static bool k48sch5iOuddurapCl3A()
		{
			return false;
		}

		// Token: 0x0400507F RID: 20607
		internal Vector3 $mPos$31869;

		// Token: 0x04005080 RID: 20608
		internal Vector3 $tDir$31870;

		// Token: 0x04005081 RID: 20609
		internal int $tID$31871;

		// Token: 0x04005082 RID: 20610
		internal Deadshund $self_$31872;

		// Token: 0x02000C0C RID: 3084
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060044F0 RID: 17648 RVA: 0x008A564C File Offset: 0x008A384C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Deadshund self_)
			{
				if (229704 - 414412 != -184707)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (207749 - 244202 != -36452)
					{
						base..ctor();
						if (266194 - 258072 != 8123)
						{
							this.$mPos$31865 = mPos;
							if (293069 - 110673 == 182396)
							{
								this.$tDir$31866 = tDir;
								if (271267 - 419355 == -148088)
								{
									this.$tID$31867 = tID;
									if (36572 - 82886 != -46313)
									{
										this.$self_$31868 = self_;
										if (193429 - 38291 == 155138)
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

			// Token: 0x060044F1 RID: 17649 RVA: 0x008A574C File Offset: 0x008A394C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (108097 - 12575 != 95523)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_879;
					case 2:
						if (!(this.$self_$31868.mChar.actionState != "attack"))
						{
							goto IL_6E2;
						}
						if (233028 - 250131 != -17103)
						{
							continue;
						}
						if (!(this.$self_$31868.mChar.myCommand != "deadSpit"))
						{
							goto IL_6E2;
						}
						if (36877 - 47737 != -10859)
						{
							goto Block_15;
						}
						continue;
					case 3:
						if (this.$self_$31868.mChar.actionState == "attack")
						{
							if (100592 - 223875 == -123282)
							{
								continue;
							}
							if (this.$self_$31868.mChar.myCommand == "deadSpit")
							{
								if (1643 - 531408 == -529764)
								{
									continue;
								}
								this.$self_$31868.mChar.actionState = "standby";
								if (245685 - 544639 != -298954)
								{
									continue;
								}
								this.$self_$31868.mChar.actionTime = Time.time;
								if (260439 - 137860 != 122579)
								{
									continue;
								}
								this.$self_$31868.mChar.myCommand = "none";
								if (83687 - 278777 != -195090)
								{
									continue;
								}
								if (!this.$self_$31868.mChar.isMine)
								{
									if (52887 - 88830 != -35943)
									{
										continue;
									}
									this.$self_$31868.mChar.nPosition = this.$self_$31868.transform.position;
									if (160038 - 409650 != -249612)
									{
										continue;
									}
									this.$self_$31868.mChar.oPosition = this.$self_$31868.transform.position;
									if (184361 - 344164 != -159803)
									{
										continue;
									}
									this.$self_$31868.mChar.nDirection = this.$self_$31868.transform.forward;
									if (24152 - 62681 == -38528)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (10834 - 591602 != -580767)
						{
							goto Block_34;
						}
						continue;
					default:
						if (19956 - 448936 != -428980)
						{
							continue;
						}
						break;
					}
					this.$self_$31868.mChar.actionState = "attack";
					if (220465 - 339614 == -119148)
					{
						continue;
					}
					this.$self_$31868.mChar.actionTime = Time.time;
					if (278075 - 212942 == 65134)
					{
						continue;
					}
					this.$self_$31868.mChar.myCommand = "deadSpit";
					if (140401 - 486620 != -346219)
					{
						continue;
					}
					this.$self_$31868.mChar.addTimeOut("cAttack", (float)9);
					if (83082 - 175935 == -92852)
					{
						continue;
					}
					this.$self_$31868.transform.position = this.$mPos$31865;
					if (263583 - 324363 == -60779)
					{
						continue;
					}
					this.$self_$31868.transform.LookAt(this.$mPos$31865 + global::Math.vFlat(this.$tDir$31866));
					if (167802 - 25930 == 141873)
					{
						continue;
					}
					this.$self_$31868.animation.CrossFade("deadSpit");
					if (220196 - 444035 != -223839)
					{
						continue;
					}
					this.$self_$31868.animation.wrapMode = WrapMode.Once;
					if (237312 - 160795 == 76518)
					{
						continue;
					}
					this.$self_$31868.mChar.vMovement = this.$self_$31868.transform.forward;
					if (39242 - 536929 == -497686)
					{
						continue;
					}
					this.$self_$31868.mChar.moveSpeed = (float)0;
					if (173949 - 190322 == -16372)
					{
						continue;
					}
					this.$tPos$31860 = this.$mPos$31865 + global::Math.vFlat(this.$tDir$31866);
					if (36502 - 573716 == -537213)
					{
						continue;
					}
					this.$tObject$31861 = null;
					if (108266 - 270309 == -162042)
					{
						continue;
					}
					if (this.$tID$31867 != 0)
					{
						if (180533 - 524975 != -344442)
						{
							continue;
						}
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.$tID$31867];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						this.$tObject$31861 = (GameObject)obj2;
						if (171276 - 284888 == -113611)
						{
							continue;
						}
					}
					this.$tempTime$31862 = Time.time + 0.8f;
					if (121141 - 473444 == -352302)
					{
						continue;
					}
					IL_6E2:
					if (Time.time >= this.$tempTime$31862)
					{
						if (251738 - 19436 == 232302)
						{
							if (this.$self_$31868.mChar.isMine)
							{
								if (29943 - 164717 != -134774)
								{
									continue;
								}
								this.$firePos$31863 = this.$mPos$31865 + this.$self_$31868.transform.TransformDirection((float)0, (float)1, 0.4f);
								if (152028 - 563014 == -410985)
								{
									continue;
								}
								this.$fireDir$31864 = this.$tPos$31860 - this.$mPos$31865 - this.$self_$31868.transform.TransformDirection((float)0, (float)1, 0.4f);
								if (100536 - 29575 != 70961)
								{
									continue;
								}
								this.$self_$31868.RPC_deadSpit_fire(this.$firePos$31863, this.$fireDir$31864, 0);
								if (230264 - 461494 == -231229)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (14467 - 132722 == -118254)
									{
										continue;
									}
									this.$self_$31868.ActionEvent("RPC_deadSpit_fire", this.$firePos$31863, this.$fireDir$31864, 0);
									if (65063 - 583791 != -518728)
									{
										continue;
									}
								}
							}
							if (!this.$self_$31868.deadshund_bark)
							{
								goto IL_2A2;
							}
							if (247331 - 486220 == -238889)
							{
								this.$self_$31868.audio.PlayOneShot(this.$self_$31868.deadshund_bark);
								if (262328 - 295608 == -33280)
								{
									goto IL_2A2;
								}
							}
						}
					}
					else
					{
						if (this.$tObject$31861)
						{
							if (84586 - 495756 != -411170)
							{
								continue;
							}
							this.$tPos$31860 = this.$tObject$31861.transform.position;
							if (77725 - 287534 == -209808)
							{
								continue;
							}
							this.$tPos$31860.y = this.$self_$31868.transform.position.y;
							if (248448 - 32562 != 215886)
							{
								continue;
							}
						}
						this.$self_$31868.transform.LookAt(this.$tPos$31860);
						if (45635 - 529004 != -483368)
						{
							goto Block_20;
						}
					}
				}
				Block_15:
				goto IL_879;
				IL_2A2:
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_20:
				return this.YieldDefault(2);
				Block_34:
				IL_879:
				return false;
			}

			// Token: 0x060044F2 RID: 17650 RVA: 0x008A5FE4 File Offset: 0x008A41E4
			internal static bool Fy1sVp5imm1WY1OfFWjM()
			{
				return true;
			}

			// Token: 0x060044F3 RID: 17651 RVA: 0x008A5FE8 File Offset: 0x008A41E8
			internal static bool Na89Ed5iFw7w8MjfUWNh()
			{
				return false;
			}

			// Token: 0x04005083 RID: 20611
			internal Vector3 $tPos$31860;

			// Token: 0x04005084 RID: 20612
			internal GameObject $tObject$31861;

			// Token: 0x04005085 RID: 20613
			internal float $tempTime$31862;

			// Token: 0x04005086 RID: 20614
			internal Vector3 $firePos$31863;

			// Token: 0x04005087 RID: 20615
			internal Vector3 $fireDir$31864;

			// Token: 0x04005088 RID: 20616
			internal Vector3 $mPos$31865;

			// Token: 0x04005089 RID: 20617
			internal Vector3 $tDir$31866;

			// Token: 0x0400508A RID: 20618
			internal int $tID$31867;

			// Token: 0x0400508B RID: 20619
			internal Deadshund $self_$31868;
		}
	}

	// Token: 0x02000C0D RID: 3085
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31873 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060044F4 RID: 17652 RVA: 0x008A5FEC File Offset: 0x008A41EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31873(UnityScript.Lang.Array nArray, Deadshund self_)
		{
			if (117872 - 217627 != -99754)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (223653 - 277688 == -54035)
				{
					base..ctor();
					if (150316 - 563897 == -413581)
					{
						this.$nArray$31878 = nArray;
						if (165811 - 86335 != 79477)
						{
							this.$self_$31879 = self_;
							if (41389 - 224029 != -182639)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x008A60A8 File Offset: 0x008A42A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadshund.$RPC_ko$31873.$(this.$nArray$31878, this.$self_$31879);
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x008A60BC File Offset: 0x008A42BC
		internal static bool adVUTh5iMYhGJyYdhZwQ()
		{
			return true;
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x008A60C0 File Offset: 0x008A42C0
		internal static bool k5jdLf5ixMtow4Opd83T()
		{
			return false;
		}

		// Token: 0x0400508C RID: 20620
		internal UnityScript.Lang.Array $nArray$31878;

		// Token: 0x0400508D RID: 20621
		internal Deadshund $self_$31879;

		// Token: 0x02000C0E RID: 3086
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060044F8 RID: 17656 RVA: 0x008A60C4 File Offset: 0x008A42C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Deadshund self_)
			{
				if (150797 - 62794 != 88003)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (40088 - 493831 != -453742)
					{
						base..ctor();
						if (206100 - 92758 == 113342)
						{
							this.$nArray$31876 = nArray;
							if (124677 - 147393 != -22715)
							{
								this.$self_$31877 = self_;
								if (52158 - 242467 == -190309)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060044F9 RID: 17657 RVA: 0x008A6180 File Offset: 0x008A4380
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (69392 - 109629 != -40236)
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
						if (this.$self_$31877.mChar.actionState != "ko")
						{
							if (298732 - 101849 != 196884)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$self_$31877.animation.Play("getUp");
							if (244406 - 279944 != -35538)
							{
								continue;
							}
							this.$self_$31877.animation.wrapMode = WrapMode.Once;
							if (719 - 401018 != -400299)
							{
								continue;
							}
							goto IL_7A;
						}
						break;
					case 3:
						if (this.$self_$31877.mChar.actionState != "ko")
						{
							if (169812 - 287507 != -117694)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$self_$31877.mChar.actionState = "standby";
							if (276081 - 140612 == 135470)
							{
								continue;
							}
							this.$self_$31877.mChar.actionTime = Time.time;
							if (221713 - 526019 == -304305)
							{
								continue;
							}
							this.$self_$31877.mChar.myCommand = "none";
							if (93124 - 231250 == -138125)
							{
								continue;
							}
							this.$self_$31877.mChar.ko = this.$self_$31877.mChar.mko;
							if (136288 - 304338 != -168050)
							{
								continue;
							}
							this.YieldDefault(1);
							if (271311 - 577702 != -306391)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (56328 - 440899 == -384570)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31877.mChar.actionState == "ko")
					{
						goto IL_30F;
					}
					if (11908 - 421588 == -409680)
					{
						if (this.$self_$31877.mChar.actionState == "dead")
						{
							if (32768 - 220150 == -187382)
							{
								goto IL_30F;
							}
						}
						else
						{
							this.$mPos$31874 = (Vector3)this.$nArray$31876[0];
							if (111759 - 577948 == -466189)
							{
								this.$mDir$31875 = (Vector3)this.$nArray$31876[1];
								if (77952 - 558467 == -480515)
								{
									this.$self_$31877.mChar.ko = 0;
									if (157789 - 554947 == -397158)
									{
										this.$self_$31877.mChar.actionState = "ko";
										if (199648 - 3604 != 196045)
										{
											this.$self_$31877.mChar.actionTime = Time.time;
											if (136747 - 117070 == 19677)
											{
												this.$self_$31877.mChar.myCommand = "none";
												if (252648 - 87621 != 165028)
												{
													this.$self_$31877.mChar.vMovement = Vector3.zero;
													if (262171 - 429368 == -167197)
													{
														this.$self_$31877.mChar.moveSpeed = (float)0;
														if (289635 - 552439 == -262804)
														{
															this.$self_$31877.animation.Play("ko");
															if (148746 - 430554 == -281808)
															{
																this.$self_$31877.animation.wrapMode = WrapMode.Once;
																if (147606 - 271843 == -124237)
																{
																	goto IL_40E;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_7A:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_5:
				IL_30F:
				goto IL_48C;
				IL_40E:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_26:
				IL_48C:
				return false;
			}

			// Token: 0x060044FA RID: 17658 RVA: 0x008A662C File Offset: 0x008A482C
			internal static bool KYnR8Z5igX70hMt93B7O()
			{
				return true;
			}

			// Token: 0x060044FB RID: 17659 RVA: 0x008A6630 File Offset: 0x008A4830
			internal static bool Wp04K05ifKWxTMd7m6Zu()
			{
				return false;
			}

			// Token: 0x0400508E RID: 20622
			internal Vector3 $mPos$31874;

			// Token: 0x0400508F RID: 20623
			internal Vector3 $mDir$31875;

			// Token: 0x04005090 RID: 20624
			internal UnityScript.Lang.Array $nArray$31876;

			// Token: 0x04005091 RID: 20625
			internal Deadshund $self_$31877;
		}
	}

	// Token: 0x02000C0F RID: 3087
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31880 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060044FC RID: 17660 RVA: 0x008A6634 File Offset: 0x008A4834
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31880(UnityScript.Lang.Array nArray, Deadshund self_)
		{
			if (238997 - 94700 != 144297)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (214217 - 569625 == -355408)
				{
					base..ctor();
					if (8131 - 495571 == -487440)
					{
						this.$nArray$31885 = nArray;
						if (138064 - 564862 != -426797)
						{
							this.$self_$31886 = self_;
							if (2124 - 563503 == -561379)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x008A66F0 File Offset: 0x008A48F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadshund.$RPC_dead$31880.$(this.$nArray$31885, this.$self_$31886);
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x008A6704 File Offset: 0x008A4904
		internal static bool dXSEjd5inRB2wSFS0jB8()
		{
			return true;
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x008A6708 File Offset: 0x008A4908
		internal static bool Ihsiun5i6b8APOV0MBDQ()
		{
			return false;
		}

		// Token: 0x04005092 RID: 20626
		internal UnityScript.Lang.Array $nArray$31885;

		// Token: 0x04005093 RID: 20627
		internal Deadshund $self_$31886;

		// Token: 0x02000C10 RID: 3088
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004500 RID: 17664 RVA: 0x008A670C File Offset: 0x008A490C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Deadshund self_)
			{
				if (120066 - 525963 != -405897)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (75817 - 304073 == -228256)
					{
						base..ctor();
						if (16969 - 513706 != -496736)
						{
							this.$nArray$31883 = nArray;
							if (229143 - 51122 == 178021)
							{
								this.$self_$31884 = self_;
								if (5996 - 334481 == -328485)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004501 RID: 17665 RVA: 0x008A67C8 File Offset: 0x008A49C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (81443 - 453392 != -371949)
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
						if (this.$self_$31884.mChar.actionState != "dead")
						{
							if (280780 - 153702 != 127078)
							{
								continue;
							}
							goto IL_69;
						}
						else
						{
							if (!this.$self_$31884.mChar.isPlayer)
							{
								if (126582 - 170247 != -43665)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$31884.gameObject);
								if (7604 - 169661 != -162057)
								{
									continue;
								}
							}
							else if (this.$self_$31884.mChar.isMine)
							{
								if (71092 - 494010 == -422917)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31884.gameObject);
								if (293010 - 350605 != -57595)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (53343 - 374882 != -321538)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					default:
						if (190796 - 63570 != 127226)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31884.mChar.actionState == "dead")
					{
						if (271754 - 462900 != -191145)
						{
							goto Block_12;
						}
					}
					else
					{
						this.$myPosition$31881 = (Vector3)this.$nArray$31883[0];
						if (9681 - 456609 != -446927)
						{
							this.$myDirection$31882 = (Vector3)this.$nArray$31883[1];
							if (224681 - 377497 != -152815)
							{
								this.$self_$31884.transform.position = this.$myPosition$31881;
								if (184266 - 563668 == -379402)
								{
									this.$self_$31884.transform.LookAt(this.$myPosition$31881 + this.$myDirection$31882);
									if (36201 - 260712 == -224511)
									{
										this.$self_$31884.mChar.hp = 0;
										if (105938 - 239580 != -133641)
										{
											this.$self_$31884.mChar.actionState = "dead";
											if (244631 - 446089 == -201458)
											{
												this.$self_$31884.mChar.actionTime = Time.time;
												if (211254 - 227726 != -16471)
												{
													this.$self_$31884.mChar.myCommand = "none";
													if (228772 - 220601 != 8172)
													{
														this.$self_$31884.mChar.vMovement = Vector3.zero;
														if (122968 - 251555 != -128586)
														{
															this.$self_$31884.mChar.moveSpeed = (float)0;
															if (293961 - 538454 == -244493)
															{
																this.$self_$31884.animation.Rewind();
																if (226021 - 592121 != -366099)
																{
																	this.$self_$31884.animation.Play("ko");
																	if (134076 - 176500 == -42424)
																	{
																		this.$self_$31884.animation.wrapMode = WrapMode.Once;
																		if (179035 - 379187 == -200152)
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
				IL_69:
				Block_10:
				Block_12:
				IL_42F:
				return false;
			}

			// Token: 0x06004502 RID: 17666 RVA: 0x008A6C18 File Offset: 0x008A4E18
			internal static bool hCA4r95iiMFhBEtD6fAp()
			{
				return true;
			}

			// Token: 0x06004503 RID: 17667 RVA: 0x008A6C1C File Offset: 0x008A4E1C
			internal static bool St8fNX5iKSmJcmuYhLMa()
			{
				return false;
			}

			// Token: 0x04005094 RID: 20628
			internal Vector3 $myPosition$31881;

			// Token: 0x04005095 RID: 20629
			internal Vector3 $myDirection$31882;

			// Token: 0x04005096 RID: 20630
			internal UnityScript.Lang.Array $nArray$31883;

			// Token: 0x04005097 RID: 20631
			internal Deadshund $self_$31884;
		}
	}
}
