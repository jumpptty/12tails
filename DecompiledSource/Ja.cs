using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000313 RID: 787
[Serializable]
public class Ja : MonoBehaviour
{
	// Token: 0x060011D6 RID: 4566 RVA: 0x001C3374 File Offset: 0x001C1574
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Ja()
	{
		if (269919 - 73341 != 196578)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (165233 - 480890 == -315657)
			{
				base..ctor();
				if (96630 - 78049 == 18581)
				{
					this.mSummonLv = 1;
					if (7646 - 596360 == -588714)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x001C340C File Offset: 0x001C160C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (281262 - 149179 != 132083)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (174736 - 271658 == -96922)
			{
				this.mChar.actionState = "standby";
				if (52790 - 238375 != -185584)
				{
					this.mChar.actionTime = Time.time;
					if (143002 - 128553 != 14450)
					{
						this.mChar.myCommand = "none";
						if (292806 - 434745 == -141939)
						{
							this.AsZ6fgpTuS = global::Math.findChildObject(this.transform, "head");
							if (2259 - 69037 != -66777)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x001C3528 File Offset: 0x001C1728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x001C3544 File Offset: 0x001C1744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (166894 - 465052 != -298157)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (279955 - 122470 == 157486)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (81250 - 308292 != -227042)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_536;
					}
					if (250660 - 139410 != 111250)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (22435 - 552528 != -530093)
				{
					continue;
				}
			}
			IL_536:
			if (this.mChar.hp > 0)
			{
				goto IL_5B3;
			}
			if (96678 - 246320 == -149641)
			{
				continue;
			}
			if (!(this.mChar.actionState != "dead"))
			{
				goto IL_5B3;
			}
			if (233794 - 251867 == -18072)
			{
				continue;
			}
			if (this.mChar.isMine)
			{
				if (281022 - 77574 != 203448)
				{
					continue;
				}
				statusClass status = this.mChar.getStatus("autoLife");
				if (102597 - 477829 != -375232)
				{
					continue;
				}
				if (status != null)
				{
					if (141189 - 177072 == -35882)
					{
						continue;
					}
					this.mChar.hp = 1;
					if (238037 - 248174 == -10136)
					{
						continue;
					}
					this.mChar.RPC_RemoveStatus("autoLife");
					if (35462 - 102304 == -66841)
					{
						continue;
					}
					this.mChar.RPC_createEffect("autoLife");
					if (283420 - 584844 == -301423)
					{
						continue;
					}
					this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
					if (292807 - 509995 != -217188)
					{
						continue;
					}
				}
				else
				{
					this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
					{
						this.transform.position,
						this.transform.forward
					})));
					if (128322 - 271597 == -143274)
					{
						continue;
					}
					if (PhotonClient.IsInitialized())
					{
						if (47849 - 166276 == -118426)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (28787 - 353923 == -325135)
						{
							continue;
						}
					}
				}
			}
			else
			{
				this.mChar.hp = 1;
				if (187308 - 6699 == 180610)
				{
					continue;
				}
			}
			IL_323:
			if (!this.AsZ6fgpTuS)
			{
				break;
			}
			if (227726 - 578662 != -350936)
			{
				continue;
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (93459 - 39927 != 53532)
			{
				continue;
			}
			float d = Mathf.Clamp(1f * (float)this.mChar.hp / (float)(this.mSummonLv * 50), 0.5f, 3f);
			if (217888 - 569329 != -351441)
			{
				continue;
			}
			this.AsZ6fgpTuS.localScale = Vector3.Lerp(this.AsZ6fgpTuS.localScale, Vector3.one * d, Time.deltaTime);
			if (1687 - 481285 != -479598)
			{
				continue;
			}
			break;
			IL_5B3:
			if (!this.isSummon)
			{
				goto IL_323;
			}
			if (175763 - 436346 == -260583)
			{
				if (!this.mChar.isMine)
				{
					goto IL_323;
				}
				if (281172 - 361474 != -80301)
				{
					if (!this.mSummonerChar)
					{
						goto IL_378;
					}
					if (252686 - 152373 == 100314)
					{
						continue;
					}
					if (this.mSummonerChar.hp <= 0)
					{
						if (185509 - 169580 != 15930)
						{
							goto IL_378;
						}
						continue;
					}
					IL_1A:
					if (Time.time <= this.GaG6LIroMq)
					{
						goto IL_323;
					}
					if (213563 - 256978 != -43415)
					{
						continue;
					}
					this.GaG6LIroMq = Time.time + (float)3;
					if (25210 - 183638 != -158428)
					{
						continue;
					}
					if (!this.mSummonerChar)
					{
						goto IL_323;
					}
					if (136279 - 288245 == -151965)
					{
						continue;
					}
					this.mSummonerChar.RPC_AddStatus("ja", this.mSummonLv, 4, 0, this.mChar.ActorNr);
					if (49529 - 24729 != 24800)
					{
						continue;
					}
					goto IL_323;
					IL_378:
					if (!(this.mChar.actionState != "dead"))
					{
						goto IL_1A;
					}
					if (193760 - 195947 != -2186)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (223932 - 392448 == -168516)
						{
							if (!PhotonClient.IsInitialized())
							{
								goto IL_1A;
							}
							if (29350 - 46492 != -17141)
							{
								this.mChar.DeadEvent();
								if (39108 - 238157 != -199048)
								{
									goto IL_1A;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060011DA RID: 4570 RVA: 0x001C3BA4 File Offset: 0x001C1DA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (82911 - 348018 != -265107)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (160528 - 479650 == -319122)
			{
				float runSpeed = this.mChar.runSpeed;
				if (3780 - 198019 == -194239)
				{
					Vector3 a = default(Vector3);
					if (85948 - 309742 == -223794)
					{
						Vector3 vector = Vector3.zero;
						if (29996 - 561493 != -531496)
						{
							float num2 = (float)0;
							if (190391 - 290836 != -100444)
							{
								if (this.mChar.isMine)
								{
									if (79062 - 219000 == -139937)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (203177 - 197335 != 5842)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (185580 - 124381 != 61199)
										{
											continue;
										}
										a.y = (float)0;
										if (21641 - 245809 != -224168)
										{
											continue;
										}
										a = a.normalized;
										if (70696 - 338735 != -268039)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (177702 - 125693 != 52009)
										{
											continue;
										}
										vector = vector.normalized;
										if (134367 - 583321 != -448954)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (13573 - 147291 != -133718)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (186202 - 143303 != 42899)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (161941 - 127864 != 34077)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (153032 - 330989 == -177956)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (205532 - 373162 != -167630)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (186963 - 95896 != 91067)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (211078 - 294465 == -83386)
														{
															continue;
														}
														this.animation.Play("run");
														if (226275 - 305242 == -78966)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (88999 - 146234 != -57235)
														{
															continue;
														}
														goto IL_536;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (205995 - 274846 == -68850)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (231439 - 95435 == 136005)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (156937 - 428733 == -271795)
											{
												continue;
											}
											num = (float)0;
											if (196932 - 265201 == -68268)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (157510 - 178037 != -20527)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (243856 - 41134 == 202723)
										{
											continue;
										}
									}
									IL_536:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (232836 - 405535 != -172699)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (226923 - 284496 != -57573)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (180989 - 287939 != -106950)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (275532 - 590730 == -315197)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (281180 - 568345 == -287164)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (99197 - 141130 == -41932)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (285131 - 320976 == -35844)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (212371 - 134093 == 78279)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (92737 - 115431 == -22693)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (25815 - 179429 != -153614)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (126428 - 154294 == -27865)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (87141 - 131244 == -44102)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (194288 - 30908 != 163380)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (22969 - 525123 != -502154)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (225111 - 72813 == 152299)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (202354 - 410947 != -208593)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (68677 - 598776 == -530098)
												{
													continue;
												}
												num = (float)0;
												if (237245 - 93296 != 143949)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (49806 - 285736 == -235929)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (16235 - 88030 == -71794)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (218081 - 230713 == -12631)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (203843 - 495317 == -291473)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (218289 - 315199 == -96909)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (142713 - 570112 != -427399)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (4694 - 147319 != -142625)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (198547 - 376052 == -177504)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (108448 - 371331 == -262882)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (36539 - 62350 != -25811)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (76517 - 109885 != -33368)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (49440 - 126824 != -77384)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (63205 - 363587 == -300381)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (14759 - 156849 == -142089)
											{
												continue;
											}
											num = (float)0;
											if (189250 - 258141 != -68891)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (266899 - 413109 == -146209)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (268796 - 33639 != 235157)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (14949 - 51144 != -36195)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (152633 - 303809 != -151176)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (29937 - 230707 != -200769)
								{
									this.mChar.moveSpeed = num;
									if (239656 - 325943 == -86287)
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

	// Token: 0x060011DB RID: 4571 RVA: 0x001C4708 File Offset: 0x001C2908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (172817 - 98670 != 74147)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (245039 - 317775 == -72736)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (208281 - 406347 != -198065)
				{
					if (208958 - 517863 == -308905)
					{
						if (ActionName == "RPC_suicideBomb")
						{
							if (113759 - 410258 != -296499)
							{
								continue;
							}
							v = 11;
							if (110287 - 390751 != -280464)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_suicideBomb_hit")
						{
							if (198809 - 42937 == 155873)
							{
								continue;
							}
							v = -11;
							if (17927 - 346472 == -328544)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Command: " + ActionName);
							if (148054 - 46449 == 101606)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (65029 - 595794 != -530764)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (288179 - 105659 != 182521)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (22587 - 396314 != -373726)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (141017 - 210929 != -69911)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (122548 - 442481 != -319932)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (188964 - 188361 != 604)
											{
												Hashtable hashtable = new Hashtable();
												if (195829 - 18453 == 177376)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (171764 - 546895 == -375131)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (227382 - 460840 != -233457)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (139807 - 578619 == -438812)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (9810 - 47974 != -38163)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (176434 - 239334 == -62900)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (20455 - 569330 == -548875)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (254090 - 255929 != -1838)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (6458 - 177054 == -170596)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (153637 - 341361 == -187724)
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

	// Token: 0x060011DC RID: 4572 RVA: 0x001C4B88 File Offset: 0x001C2D88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (121162 - 449789 != -328626)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (65283 - 271184 == -205901)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (172845 - 34876 == 137969)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (48363 - 185188 == -136825)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (199860 - 401629 != -201768)
						{
							int num2 = num;
							if (268775 - 105800 == 162975)
							{
								if (num2 == 11)
								{
									if (237504 - 582671 != -345166)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (91536 - 508103 == -416567)
										{
											this.StartCoroutine_Auto(this.RPC_suicideBomb(mPos, tDir, tID));
											if (64374 - 361161 == -296787)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -11)
								{
									if (9159 - 164527 != -155367)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (238769 - 173759 != 65011)
										{
											this.RPC_suicideBomb_hit(mPos, tDir, tID);
											if (15483 - 134383 == -118900)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (117382 - 519301 != -401918)
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

	// Token: 0x060011DD RID: 4573 RVA: 0x001C4E20 File Offset: 0x001C3020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character can only use charged attack");
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x001C4E38 File Offset: 0x001C3038
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (255562 - 279484 != -23922)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (131850 - 21602 != 110249)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (66995 - 188257 == -121262)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (51070 - 172371 == -121301)
					{
						Vector3 normalized = vector.normalized;
						if (121007 - 544862 == -423855)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (78856 - 112531 == -33675)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (56016 - 146836 == -90819)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (45469 - 261958 == -216488)
									{
										continue;
									}
								}
								this.StartCoroutine_Auto(this.RPC_suicideBomb(this.transform.position, normalized, 0));
								if (253871 - 357229 != -103357)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (271642 - 97093 == 174549)
									{
										this.ActionEvent("RPC_suicideBomb", this.transform.position, normalized, 0);
										if (116588 - 553398 == -436810)
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

	// Token: 0x060011DF RID: 4575 RVA: 0x001C5054 File Offset: 0x001C3254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x001C5058 File Offset: 0x001C3258
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_suicideBomb(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Ja.$RPC_suicideBomb$18365(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x001C5068 File Offset: 0x001C3268
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_suicideBomb_hit(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (170965 - 117621 != 53345)
		{
		}
		for (;;)
		{
			if (this.suicideBomb_hit)
			{
				if (220275 - 122472 != 97803)
				{
					continue;
				}
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.suicideBomb_hit, mPos, Quaternion.identity);
				if (253812 - 517883 == -264070)
				{
					continue;
				}
				gameObject.transform.localScale = Vector3.one * ((float)1 + 0.25f * (float)this.mSummonLv);
				if (262114 - 430092 != -167978)
				{
					continue;
				}
			}
			else
			{
				Debug.Log("Cannot find suicideBomb effect");
				if (238395 - 174355 != 64040)
				{
					continue;
				}
			}
			if (this.mChar.isMine)
			{
				if (100096 - 554734 != -454638)
				{
					continue;
				}
				if (!this.mChar.isSummon)
				{
					if (36604 - 71428 != -34824)
					{
						continue;
					}
					if (this.mChar.actionState == "attack")
					{
						if (58240 - 482782 != -424542)
						{
							continue;
						}
						Camera.main.SendMessage("onJaSuicide", SendMessageOptions.DontRequireReceiver);
						if (293964 - 222999 == 70966)
						{
							continue;
						}
					}
				}
			}
			if (this.mChar.hasStatus("transform"))
			{
				if (12443 - 143838 == -131394)
				{
					continue;
				}
				this.mChar.removeStatus("transform");
				if (214736 - 184360 == 30377)
				{
					continue;
				}
			}
			if (this.mChar.hasStatus("mimic"))
			{
				if (123150 - 114484 == 8666)
				{
					this.mChar.removeStatus("mimic");
					if (140760 - 386479 != -245718)
					{
						break;
					}
				}
			}
			else
			{
				UnityEngine.Object.Destroy(this.gameObject);
				if (151465 - 47120 != 104346)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x001C52F4 File Offset: 0x001C34F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator summon(int nSummonerID)
	{
		return new Ja.$summon$18380(nSummonerID, this).GetEnumerator();
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x001C5304 File Offset: 0x001C3504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_summonAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (204461 - 262698 != -58236)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = this.mChar;
			object obj2;
			object obj = obj2 = PhotonClient.ActorNrList[tID];
			if (!(obj is GameObject))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
			}
			characterControl.myAttackTarget = (GameObject)obj2;
			if (42700 - 153070 != -110369)
			{
				this.mChar.mHateList = new UnityScript.Lang.Array();
				if (154811 - 524786 == -369975)
				{
					this.mChar.addHate(tID, 1200);
					if (32611 - 166921 == -134310)
					{
						this.mChar.isAlert = true;
						if (32783 - 379666 == -346883)
						{
							Ja_AI ja_AI = (Ja_AI)this.GetComponent(typeof(Ja_AI));
							if (276003 - 140830 != 135174)
							{
								if (!ja_AI)
								{
									break;
								}
								if (206423 - 273445 != -67021)
								{
									ja_AI.AI_setTimer(3f);
									if (131311 - 559968 == -428657)
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

	// Token: 0x060011E4 RID: 4580 RVA: 0x001C5488 File Offset: 0x001C3688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_summonDefense(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (262543 - 216970 != 45573)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "standby")
			{
				goto IL_127;
			}
			if (230226 - 244856 != -14630)
			{
				continue;
			}
			if (this.mChar.actionState == "run")
			{
				if (204016 - 465484 != -261468)
				{
					continue;
				}
				goto IL_127;
			}
			IL_4E:
			this.mChar.mHateList = new UnityScript.Lang.Array();
			if (39298 - 196517 != -157219)
			{
				continue;
			}
			this.mChar.myAttackTarget = null;
			if (70833 - 212699 != -141866)
			{
				continue;
			}
			this.mChar.isAlert = false;
			if (280260 - 220904 != 59356)
			{
				continue;
			}
			Ja_AI ja_AI = (Ja_AI)this.GetComponent(typeof(Ja_AI));
			if (91860 - 371979 == -280118)
			{
				continue;
			}
			if (!ja_AI)
			{
				break;
			}
			if (204952 - 590050 != -385098)
			{
				continue;
			}
			ja_AI.AI_state = "defense";
			if (152096 - 27494 != 124602)
			{
				continue;
			}
			break;
			IL_127:
			this.transform.LookAt(global::Math.vFlat(this.mSummoner.transform.position) + new Vector3((float)0, this.transform.position.y, (float)0));
			if (222920 - 488120 != -265199)
			{
				goto IL_4E;
			}
		}
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x001C5674 File Offset: 0x001C3874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator unsummon()
	{
		return new Ja.$unsummon$18387(this).GetEnumerator();
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x001C5684 File Offset: 0x001C3884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void summonRelease()
	{
		if (133412 - 17704 != 115709)
		{
		}
		for (;;)
		{
			this.mChar.addHate(this.mSummonerChar.ActorNr, 1200);
			if (225703 - 276305 == -50602)
			{
				this.isSummon = false;
				if (71841 - 115191 != -43349)
				{
					this.mSummoner = null;
					if (193434 - 577404 != -383969)
					{
						this.mSummonerChar = null;
						if (127565 - 174327 == -46762)
						{
							this.gameObject.layer = 15;
							if (323 - 425665 != -425341)
							{
								this.mChar.mOriginalLayer = 15;
								if (212957 - 309207 == -96250)
								{
									this.mChar.mSummoner = null;
									if (28890 - 241501 == -212611)
									{
										this.mChar.isSummon = false;
										if (102864 - 279472 == -176608)
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

	// Token: 0x060011E7 RID: 4583 RVA: 0x001C57F0 File Offset: 0x001C39F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x001C57F4 File Offset: 0x001C39F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Ja.$RPC_dead$18390(nArray, this).GetEnumerator();
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x001C5804 File Offset: 0x001C3A04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x001C5808 File Offset: 0x001C3A08
	internal static bool qZLvp3Z2w3ukqwN7uqP()
	{
		return true;
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x001C580C File Offset: 0x001C3A0C
	internal static bool uxaAZIZ8THIqtNfLFFv()
	{
		return false;
	}

	// Token: 0x04000FAD RID: 4013
	public eJaType JaType;

	// Token: 0x04000FAE RID: 4014
	public CharacterControl mChar;

	// Token: 0x04000FAF RID: 4015
	private Transform AsZ6fgpTuS;

	// Token: 0x04000FB0 RID: 4016
	private float GaG6LIroMq;

	// Token: 0x04000FB1 RID: 4017
	public GameObject suicideBomb_hit;

	// Token: 0x04000FB2 RID: 4018
	public GameObject mSummoner;

	// Token: 0x04000FB3 RID: 4019
	public bool isSummon;

	// Token: 0x04000FB4 RID: 4020
	public float followDistance;

	// Token: 0x04000FB5 RID: 4021
	public CharacterControl mSummonerChar;

	// Token: 0x04000FB6 RID: 4022
	public int mSummonLv;

	// Token: 0x04000FB7 RID: 4023
	public GameObject summon_ring;

	// Token: 0x02000314 RID: 788
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_suicideBomb$18365 : GenericGenerator<object>
	{
		// Token: 0x060011EC RID: 4588 RVA: 0x001C5810 File Offset: 0x001C3A10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_suicideBomb$18365(Vector3 mPos, Vector3 tDir, Ja self_)
		{
			if (178030 - 481720 != -303689)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (125904 - 393724 != -267819)
				{
					base..ctor();
					if (3407 - 548993 != -545585)
					{
						this.$mPos$18377 = mPos;
						if (239419 - 330057 == -90638)
						{
							this.$tDir$18378 = tDir;
							if (134432 - 485015 == -350583)
							{
								this.$self_$18379 = self_;
								if (299562 - 130103 == 169459)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x001C58EC File Offset: 0x001C3AEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new Ja.$RPC_suicideBomb$18365.$(this.$mPos$18377, this.$tDir$18378, this.$self_$18379);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x001C5908 File Offset: 0x001C3B08
		internal static bool ep8BXGZZNQoZSJ3Ih64()
		{
			return true;
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x001C590C File Offset: 0x001C3B0C
		internal static bool OSxTDlZC941DFArDAxZ()
		{
			return false;
		}

		// Token: 0x04000FB8 RID: 4024
		internal Vector3 $mPos$18377;

		// Token: 0x04000FB9 RID: 4025
		internal Vector3 $tDir$18378;

		// Token: 0x04000FBA RID: 4026
		internal Ja $self_$18379;

		// Token: 0x02000315 RID: 789
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x060011F0 RID: 4592 RVA: 0x001C5910 File Offset: 0x001C3B10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Ja self_)
			{
				if (62058 - 122322 != -60264)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (38620 - 419304 == -380684)
					{
						base..ctor();
						if (58215 - 424772 != -366556)
						{
							this.$mPos$18374 = mPos;
							if (170092 - 476364 != -306271)
							{
								this.$tDir$18375 = tDir;
								if (157810 - 142222 == 15588)
								{
									this.$self_$18376 = self_;
									if (260072 - 23278 != 236795)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060011F1 RID: 4593 RVA: 0x001C59EC File Offset: 0x001C3BEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (288803 - 190759 != 98044)
				{
				}
				for (;;)
				{
					IL_1DF:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_71A;
					case 2:
						goto IL_68D;
					default:
						if (99000 - 120652 != -21652)
						{
							continue;
						}
						break;
					}
					this.$self_$18376.mChar.actionState = "attack";
					if (247187 - 222892 == 24296)
					{
						continue;
					}
					this.$self_$18376.mChar.actionTime = Time.time;
					if (298537 - 198537 != 100000)
					{
						continue;
					}
					this.$self_$18376.mChar.myCommand = "suicideBomb";
					if (272539 - 46491 != 226048)
					{
						continue;
					}
					this.$self_$18376.transform.position = this.$mPos$18374;
					if (142473 - 57534 != 84939)
					{
						continue;
					}
					this.$self_$18376.transform.LookAt(this.$mPos$18374 + global::Math.vFlat(this.$tDir$18375));
					if (276458 - 29483 != 246975)
					{
						continue;
					}
					this.$self_$18376.animation.Rewind();
					if (220607 - 74781 == 145827)
					{
						continue;
					}
					this.$self_$18376.animation.CrossFade("suicideRun");
					if (249897 - 249109 != 788)
					{
						continue;
					}
					this.$self_$18376.animation.wrapMode = WrapMode.Once;
					if (272095 - 475597 == -203501)
					{
						continue;
					}
					this.$self_$18376.mChar.vMovement = this.$self_$18376.transform.forward;
					if (10106 - 225021 != -214915)
					{
						continue;
					}
					this.$self_$18376.mChar.moveSpeed = (float)8;
					if (240864 - 139106 != 101758)
					{
						continue;
					}
					this.$mJa_tri$18366 = this.$self_$18376.transform.Find("Ja_tri").gameObject;
					if (82027 - 459653 == -377625)
					{
						continue;
					}
					this.$mJa_renderer$18367 = (Renderer)this.$mJa_tri$18366.GetComponent(typeof(Renderer));
					if (245149 - 261131 == -15981)
					{
						continue;
					}
					this.$mJa_color$18368 = this.$mJa_renderer$18367.material.GetColor("_Emission");
					if (177154 - 470661 == -293506)
					{
						continue;
					}
					IL_68D:
					if (this.$self_$18376.mChar.actionTime + 0.5f <= Time.time)
					{
						if (5716 - 205130 == -199414)
						{
							if (this.$self_$18376.mChar.isMine)
							{
								if (110225 - 216422 != -106197)
								{
									continue;
								}
								this.$hitLayer$18369 = 130816 - (1 << this.$self_$18376.gameObject.layer);
								if (49170 - 33765 == 15406)
								{
									continue;
								}
								this.$hitList$18370 = Damage.FindAreaTarget(this.$self_$18376.transform.position, (float)(4 + this.$self_$18376.mSummonLv * 2), (float)3, this.$hitLayer$18369);
								if (223226 - 143370 != 79856)
								{
									continue;
								}
								this.$$iterator$9427$18373 = UnityRuntimeServices.GetEnumerator(this.$hitList$18370);
								if (95896 - 26961 == 68936)
								{
									continue;
								}
								while (this.$$iterator$9427$18373.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9427$18373.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$18371 = (GameObject)obj2;
									if (45288 - 488085 == -442796)
									{
										goto IL_1DF;
									}
									this.$hitDistance$18372 = (float)1 - 0.5f * ((this.$hitObject$18371.transform.position - this.$self_$18376.transform.position).magnitude / (float)(4 + this.$self_$18376.mSummonLv * 2));
									if (289515 - 592205 != -302690)
									{
										goto IL_1DF;
									}
									UnityRuntimeServices.Update(this.$$iterator$9427$18373, this.$hitObject$18371);
									if (153051 - 58069 != 94982)
									{
										goto IL_1DF;
									}
									this.$self_$18376.mChar.hit(1 + this.$self_$18376.mSummonLv, this.$hitObject$18371, (int)(this.$hitDistance$18372 * (float)this.$self_$18376.mChar.hp), Mathf.FloorToInt(0.1f * (float)this.$self_$18376.mChar.hp), 0, Vector3.zero);
									if (56833 - 242782 != -185949)
									{
										goto IL_1DF;
									}
									UnityRuntimeServices.Update(this.$$iterator$9427$18373, this.$hitObject$18371);
									if (54408 - 537608 == -483199)
									{
										goto IL_1DF;
									}
								}
								if (75776 - 4693 == 71084)
								{
									continue;
								}
								this.$self_$18376.RPC_suicideBomb_hit(this.$self_$18376.collider.bounds.center, this.$self_$18376.transform.forward, 0);
								if (86561 - 162198 != -75637)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (185384 - 137775 == 47610)
									{
										continue;
									}
									this.$self_$18376.ActionEvent("RPC_suicideBomb_hit", this.$self_$18376.collider.bounds.center, this.$self_$18376.transform.forward, 0);
									if (272728 - 581716 != -308988)
									{
										continue;
									}
								}
							}
							this.YieldDefault(1);
							if (202771 - 339338 == -136567)
							{
								goto IL_71A;
							}
						}
					}
					else
					{
						this.$mJa_color$18368 += new Color((float)2 * Time.deltaTime, (float)2 * Time.deltaTime, (float)2 * Time.deltaTime, (float)0);
						if (30015 - 489315 == -459300)
						{
							this.$mJa_renderer$18367.material.SetColor("_Emission", this.$mJa_color$18368);
							if (219419 - 163103 == 56316)
							{
								break;
							}
						}
					}
				}
				return this.YieldDefault(2);
				IL_71A:
				return false;
			}

			// Token: 0x060011F2 RID: 4594 RVA: 0x001C6128 File Offset: 0x001C4328
			internal static bool EfBOuDZL01ogcImTQNh()
			{
				return true;
			}

			// Token: 0x060011F3 RID: 4595 RVA: 0x001C612C File Offset: 0x001C432C
			internal static bool E0vHDiZOp1pEdl3xaVl()
			{
				return false;
			}

			// Token: 0x04000FBB RID: 4027
			internal GameObject $mJa_tri$18366;

			// Token: 0x04000FBC RID: 4028
			internal Renderer $mJa_renderer$18367;

			// Token: 0x04000FBD RID: 4029
			internal Color $mJa_color$18368;

			// Token: 0x04000FBE RID: 4030
			internal int $hitLayer$18369;

			// Token: 0x04000FBF RID: 4031
			internal UnityScript.Lang.Array $hitList$18370;

			// Token: 0x04000FC0 RID: 4032
			internal GameObject $hitObject$18371;

			// Token: 0x04000FC1 RID: 4033
			internal float $hitDistance$18372;

			// Token: 0x04000FC2 RID: 4034
			internal IEnumerator $$iterator$9427$18373;

			// Token: 0x04000FC3 RID: 4035
			internal Vector3 $mPos$18374;

			// Token: 0x04000FC4 RID: 4036
			internal Vector3 $tDir$18375;

			// Token: 0x04000FC5 RID: 4037
			internal Ja $self_$18376;
		}
	}

	// Token: 0x02000316 RID: 790
	[CompilerGenerated]
	[Serializable]
	internal sealed class $summon$18380 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060011F4 RID: 4596 RVA: 0x001C6130 File Offset: 0x001C4330
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $summon$18380(int nSummonerID, Ja self_)
		{
			if (144517 - 282045 != -137528)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (2786 - 550682 != -547895)
				{
					base..ctor();
					if (101118 - 190642 != -89523)
					{
						this.$nSummonerID$18385 = nSummonerID;
						if (223384 - 386725 != -163340)
						{
							this.$self_$18386 = self_;
							if (235247 - 333843 != -98595)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x001C61EC File Offset: 0x001C43EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ja.$summon$18380.$(this.$nSummonerID$18385, this.$self_$18386);
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x001C6200 File Offset: 0x001C4400
		internal static bool VqqHPAZmiAyEJpQj4yy()
		{
			return true;
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x001C6204 File Offset: 0x001C4404
		internal static bool A28XctZFWgLcykVORSU()
		{
			return false;
		}

		// Token: 0x04000FC6 RID: 4038
		internal int $nSummonerID$18385;

		// Token: 0x04000FC7 RID: 4039
		internal Ja $self_$18386;

		// Token: 0x02000317 RID: 791
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060011F8 RID: 4600 RVA: 0x001C6208 File Offset: 0x001C4408
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nSummonerID, Ja self_)
			{
				if (35432 - 73898 != -38465)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (70586 - 453637 == -383051)
					{
						base..ctor();
						if (220581 - 220947 == -366)
						{
							this.$nSummonerID$18383 = nSummonerID;
							if (215128 - 518183 == -303055)
							{
								this.$self_$18384 = self_;
								if (175324 - 434399 == -259075)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060011F9 RID: 4601 RVA: 0x001C62C4 File Offset: 0x001C44C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91233 - 21984 != 69249)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8D1;
					case 2:
						if (this.$self_$18384.mChar.actionState == "attack")
						{
							if (170450 - 279645 == -109194)
							{
								continue;
							}
							if (this.$self_$18384.mChar.myCommand == "summon")
							{
								if (69784 - 113970 != -44186)
								{
									continue;
								}
								this.$self_$18384.mChar.actionState = "standby";
								if (292239 - 389738 != -97499)
								{
									continue;
								}
								this.$self_$18384.mChar.actionTime = Time.time;
								if (52883 - 493413 != -440530)
								{
									continue;
								}
								this.$self_$18384.mChar.myCommand = "none";
								if (123205 - 153570 == -30364)
								{
									continue;
								}
								if (!this.$self_$18384.mChar.isMine)
								{
									if (297462 - 303046 != -5584)
									{
										continue;
									}
									this.$self_$18384.mChar.nPosition = this.$self_$18384.transform.position;
									if (292873 - 397913 != -105040)
									{
										continue;
									}
									this.$self_$18384.mChar.oPosition = this.$self_$18384.transform.position;
									if (39484 - 308461 == -268976)
									{
										continue;
									}
									this.$self_$18384.mChar.nDirection = this.$self_$18384.transform.forward;
									if (240540 - 241372 == -831)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (273452 - 119064 != 154389)
						{
							goto Block_50;
						}
						continue;
					default:
						if (128167 - 563986 != -435819)
						{
							continue;
						}
						break;
					}
					this.$self_$18384.isSummon = true;
					if (173178 - 23643 == 149535)
					{
						Ja ja = this.$self_$18384;
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.$nSummonerID$18383];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						ja.mSummoner = (GameObject)obj2;
						if (273064 - 153343 == 119721)
						{
							this.$self_$18384.mSummonerChar = (CharacterControl)this.$self_$18384.mSummoner.GetComponent(typeof(CharacterControl));
							if (159185 - 266812 == -107627)
							{
								this.$self_$18384.gameObject.layer = this.$self_$18384.mSummoner.layer;
								if (157394 - 424600 != -267205)
								{
									this.$self_$18384.mChar.mOriginalLayer = this.$self_$18384.mSummoner.layer;
									if (255409 - 85233 != 170177)
									{
										Camera.main.SendMessage("onSummon", this.$self_$18384.gameObject, SendMessageOptions.DontRequireReceiver);
										if (5801 - 162476 == -156675)
										{
											this.$$switch$1179$18381 = this.$self_$18384.JaType;
											if (260881 - 152147 == 108734)
											{
												if (this.$$switch$1179$18381 == eJaType.Ja1)
												{
													if (43643 - 21805 != 21838)
													{
														continue;
													}
													this.$self_$18384.mChar.hp = 100;
													if (215940 - 257370 == -41429)
													{
														continue;
													}
													this.$self_$18384.followDistance = 2.5f;
													if (143613 - 538570 == -394956)
													{
														continue;
													}
													this.$self_$18384.mSummonLv = 1;
													if (37280 - 8968 != 28312)
													{
														continue;
													}
												}
												else if (this.$$switch$1179$18381 == eJaType.Ja2)
												{
													if (88452 - 101241 != -12789)
													{
														continue;
													}
													this.$self_$18384.mChar.hp = 200;
													if (64860 - 403075 != -338215)
													{
														continue;
													}
													this.$self_$18384.followDistance = 3f;
													if (274198 - 55055 == 219144)
													{
														continue;
													}
													this.$self_$18384.mSummonLv = 2;
													if (184190 - 393959 == -209768)
													{
														continue;
													}
												}
												else if (this.$$switch$1179$18381 == eJaType.Ja3)
												{
													if (233791 - 121868 == 111924)
													{
														continue;
													}
													this.$self_$18384.mChar.hp = 300;
													if (84738 - 326656 == -241917)
													{
														continue;
													}
													this.$self_$18384.followDistance = 3.5f;
													if (32294 - 97060 == -64765)
													{
														continue;
													}
													this.$self_$18384.mSummonLv = 3;
													if (106404 - 126677 == -20272)
													{
														continue;
													}
												}
												else if (this.$$switch$1179$18381 == eJaType.Ja4)
												{
													if (231188 - 594105 == -362916)
													{
														continue;
													}
													this.$self_$18384.mChar.hp = 400;
													if (230866 - 154214 != 76652)
													{
														continue;
													}
													this.$self_$18384.followDistance = 4f;
													if (57049 - 585289 == -528239)
													{
														continue;
													}
													this.$self_$18384.mSummonLv = 4;
													if (159265 - 456459 != -297194)
													{
														continue;
													}
												}
												this.$self_$18384.mChar.actionState = "attack";
												if (128215 - 401737 == -273522)
												{
													this.$self_$18384.mChar.actionTime = Time.time;
													if (54589 - 25552 != 29038)
													{
														this.$self_$18384.mChar.myCommand = "summon";
														if (179276 - 69141 == 110135)
														{
															this.$self_$18384.animation.Play("summon");
															if (290780 - 444762 != -153981)
															{
																this.$self_$18384.animation.wrapMode = WrapMode.Once;
																if (68172 - 496199 == -428027)
																{
																	this.$self_$18384.mChar.vMovement = this.$self_$18384.transform.forward;
																	if (180935 - 455575 != -274639)
																	{
																		this.$self_$18384.mChar.moveSpeed = (float)0;
																		if (163357 - 149038 == 14319)
																		{
																			if (this.$self_$18384.summon_ring)
																			{
																				if (197400 - 30263 == 167137)
																				{
																					this.$mSummon_ring$18382 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$18384.summon_ring, this.$self_$18384.transform.position, Quaternion.identity);
																					if (213747 - 321293 == -107546)
																					{
																						this.$mSummon_ring$18382.transform.localScale = 0.5f * (float)this.$self_$18384.mSummonLv * Vector3.one;
																						if (298012 - 242640 == 55372)
																						{
																							break;
																						}
																					}
																				}
																			}
																			else
																			{
																				Debug.Log("Cannot find summon ring Effect");
																				if (231319 - 197448 != 33872)
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
				return this.Yield(2, new WaitForSeconds(1f));
				Block_50:
				IL_8D1:
				return false;
			}

			// Token: 0x060011FA RID: 4602 RVA: 0x001C6BB4 File Offset: 0x001C4DB4
			internal static bool iFQHd3ZMKyey9vA8UJt()
			{
				return true;
			}

			// Token: 0x060011FB RID: 4603 RVA: 0x001C6BB8 File Offset: 0x001C4DB8
			internal static bool OkOWfSZxo0pBqM1axmw()
			{
				return false;
			}

			// Token: 0x04000FC8 RID: 4040
			internal eJaType $$switch$1179$18381;

			// Token: 0x04000FC9 RID: 4041
			internal GameObject $mSummon_ring$18382;

			// Token: 0x04000FCA RID: 4042
			internal int $nSummonerID$18383;

			// Token: 0x04000FCB RID: 4043
			internal Ja $self_$18384;
		}
	}

	// Token: 0x02000318 RID: 792
	[CompilerGenerated]
	[Serializable]
	internal sealed class $unsummon$18387 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060011FC RID: 4604 RVA: 0x001C6BBC File Offset: 0x001C4DBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $unsummon$18387(Ja self_)
		{
			if (15093 - 525975 != -510882)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (63210 - 120368 != -57157)
				{
					base..ctor();
					if (72082 - 332717 == -260635)
					{
						this.$self_$18389 = self_;
						if (273672 - 451479 != -177806)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x001C6C54 File Offset: 0x001C4E54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ja.$unsummon$18387.$(this.$self_$18389);
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x001C6C64 File Offset: 0x001C4E64
		internal static bool sZGUAHZgx13Uy39CY0V()
		{
			return true;
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x001C6C68 File Offset: 0x001C4E68
		internal static bool kGW8wIZfkdH9fySwyv2()
		{
			return false;
		}

		// Token: 0x04000FCC RID: 4044
		internal Ja $self_$18389;

		// Token: 0x02000319 RID: 793
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001200 RID: 4608 RVA: 0x001C6C6C File Offset: 0x001C4E6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Ja self_)
			{
				if (145734 - 329449 != -183714)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (36190 - 302846 == -266656)
					{
						base..ctor();
						if (33985 - 46827 == -12842)
						{
							this.$self_$18388 = self_;
							if (57003 - 107493 != -50489)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06001201 RID: 4609 RVA: 0x001C6D04 File Offset: 0x001C4F04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (199334 - 281947 != -82613)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2A7;
					case 2:
						UnityEngine.Object.Destroy(this.$self_$18388.gameObject);
						if (101924 - 432145 != -330221)
						{
							continue;
						}
						this.YieldDefault(1);
						if (56737 - 400629 != -343891)
						{
							goto Block_10;
						}
						continue;
					default:
						if (199710 - 473540 != -273830)
						{
							continue;
						}
						break;
					}
					Debug.Log("unSummon!");
					if (138396 - 317444 == -179048)
					{
						if (this.$self_$18388.mChar.actionState == "dead")
						{
							if (125654 - 497457 != -371802)
							{
								goto Block_12;
							}
						}
						else
						{
							this.$self_$18388.mChar.actionState = "dead";
							if (178348 - 145659 == 32689)
							{
								this.$self_$18388.mChar.actionTime = Time.time;
								if (228377 - 519865 != -291487)
								{
									this.$self_$18388.mChar.myCommand = "unSummon";
									if (53348 - 528332 == -474984)
									{
										this.$self_$18388.animation.Rewind();
										if (54049 - 119451 != -65401)
										{
											this.$self_$18388.animation.Play("ko");
											if (200974 - 298395 == -97421)
											{
												this.$self_$18388.animation.wrapMode = WrapMode.Once;
												if (268357 - 421947 == -153590)
												{
													this.$self_$18388.mChar.hp = 0;
													if (136857 - 255969 != -119111)
													{
														this.$self_$18388.mChar.vMovement = Vector3.zero;
														if (228051 - 597399 == -369348)
														{
															this.$self_$18388.mChar.moveSpeed = (float)0;
															if (135734 - 235471 != -99736)
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
				return this.Yield(2, new WaitForSeconds(1f));
				Block_10:
				Block_12:
				IL_2A7:
				return false;
			}

			// Token: 0x06001202 RID: 4610 RVA: 0x001C6FCC File Offset: 0x001C51CC
			internal static bool kf2i0YZnQUruFF9ctdj()
			{
				return true;
			}

			// Token: 0x06001203 RID: 4611 RVA: 0x001C6FD0 File Offset: 0x001C51D0
			internal static bool qeJH7bZ6xRnd7tGIcMw()
			{
				return false;
			}

			// Token: 0x04000FCD RID: 4045
			internal Ja $self_$18388;
		}
	}

	// Token: 0x0200031A RID: 794
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18390 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001204 RID: 4612 RVA: 0x001C6FD4 File Offset: 0x001C51D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18390(UnityScript.Lang.Array nArray, Ja self_)
		{
			if (133198 - 599443 != -466244)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (102037 - 249404 != -147366)
				{
					base..ctor();
					if (196090 - 230204 == -34114)
					{
						this.$nArray$18395 = nArray;
						if (244500 - 494526 != -250025)
						{
							this.$self_$18396 = self_;
							if (61886 - 589736 != -527849)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x001C7090 File Offset: 0x001C5290
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ja.$RPC_dead$18390.$(this.$nArray$18395, this.$self_$18396);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x001C70A4 File Offset: 0x001C52A4
		internal static bool HmVwipZijSiiNFrQZIa()
		{
			return true;
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x001C70A8 File Offset: 0x001C52A8
		internal static bool XZUHMrZKhO08JUvfP2y()
		{
			return false;
		}

		// Token: 0x04000FCE RID: 4046
		internal UnityScript.Lang.Array $nArray$18395;

		// Token: 0x04000FCF RID: 4047
		internal Ja $self_$18396;

		// Token: 0x0200031B RID: 795
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001208 RID: 4616 RVA: 0x001C70AC File Offset: 0x001C52AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Ja self_)
			{
				if (217319 - 99742 != 117577)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (295801 - 500977 == -205176)
					{
						base..ctor();
						if (237874 - 227363 == 10511)
						{
							this.$nArray$18393 = nArray;
							if (181826 - 418391 == -236565)
							{
								this.$self_$18394 = self_;
								if (234393 - 55186 == 179207)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001209 RID: 4617 RVA: 0x001C7168 File Offset: 0x001C5368
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (42040 - 494355 != -452315)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3F1;
					case 2:
						if (this.$self_$18394.mChar.isPlayer)
						{
							if (135466 - 140794 == -5327)
							{
								continue;
							}
							if (this.$self_$18394.mChar.isMine)
							{
								if (106115 - 528300 != -422185)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18394.gameObject);
								if (187995 - 341620 == -153624)
								{
									continue;
								}
							}
						}
						else
						{
							UnityEngine.Object.Destroy(this.$self_$18394.gameObject);
							if (41368 - 530113 == -488744)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (286247 - 448178 != -161930)
						{
							goto Block_15;
						}
						continue;
					default:
						if (14933 - 487563 != -472630)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18394.mChar.actionState == "dead")
					{
						if (33027 - 533069 != -500041)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$18391 = (Vector3)this.$nArray$18393[0];
						if (215531 - 493369 != -277837)
						{
							this.$myDirection$18392 = (Vector3)this.$nArray$18393[1];
							if (12124 - 528159 == -516035)
							{
								this.$self_$18394.transform.position = this.$myPosition$18391;
								if (123307 - 390951 != -267643)
								{
									this.$self_$18394.transform.LookAt(this.$myPosition$18391 + this.$myDirection$18392);
									if (209166 - 68238 == 140928)
									{
										this.$self_$18394.mChar.hp = 0;
										if (133740 - 95400 == 38340)
										{
											this.$self_$18394.mChar.actionState = "dead";
											if (207720 - 456512 == -248792)
											{
												this.$self_$18394.mChar.actionTime = Time.time;
												if (60680 - 322314 != -261633)
												{
													this.$self_$18394.mChar.myCommand = "none";
													if (210613 - 448995 != -238381)
													{
														this.$self_$18394.mChar.vMovement = Vector3.zero;
														if (116130 - 58313 != 57818)
														{
															this.$self_$18394.mChar.moveSpeed = (float)0;
															if (168528 - 88324 != 80205)
															{
																this.$self_$18394.animation.Rewind();
																if (51904 - 521945 != -470040)
																{
																	this.$self_$18394.animation.Play("ko");
																	if (218451 - 455568 == -237117)
																	{
																		this.$self_$18394.animation.wrapMode = WrapMode.Once;
																		if (28028 - 542614 == -514586)
																		{
																			goto IL_283;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_15:
				goto IL_3F1;
				IL_283:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3F1:
				return false;
			}

			// Token: 0x0600120A RID: 4618 RVA: 0x001C7578 File Offset: 0x001C5778
			internal static bool H9RVlXZdxWgXfujtHw3()
			{
				return true;
			}

			// Token: 0x0600120B RID: 4619 RVA: 0x001C757C File Offset: 0x001C577C
			internal static bool uAKj6CZJR40A0LsMrmt()
			{
				return false;
			}

			// Token: 0x04000FD0 RID: 4048
			internal Vector3 $myPosition$18391;

			// Token: 0x04000FD1 RID: 4049
			internal Vector3 $myDirection$18392;

			// Token: 0x04000FD2 RID: 4050
			internal UnityScript.Lang.Array $nArray$18393;

			// Token: 0x04000FD3 RID: 4051
			internal Ja $self_$18394;
		}
	}
}
