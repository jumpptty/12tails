using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DAA RID: 3498
[Serializable]
public class Skunk : MonoBehaviour
{
	// Token: 0x06004EEE RID: 20206 RVA: 0x009B12E0 File Offset: 0x009AF4E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Skunk()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004EEF RID: 20207 RVA: 0x009B12F0 File Offset: 0x009AF4F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (222891 - 167557 != 55334)
		{
		}
		for (;;)
		{
			this.G5OcnEBpvGF = this.transform;
			if (127108 - 169426 != -42317)
			{
				this.P2PcnPdxR4O = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (198822 - 298345 == -99523)
				{
					this.P2PcnPdxR4O.actionState = "standby";
					if (212885 - 201901 != 10985)
					{
						this.P2PcnPdxR4O.actionTime = Time.time;
						if (296682 - 6908 != 289775)
						{
							this.P2PcnPdxR4O.myCommand = "none";
							if (71779 - 363230 != -291450)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (108602 - 235209 != -126606)
								{
									this.P2PcnPdxR4O.isMine = true;
									if (17610 - 130464 != -112853)
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

	// Token: 0x06004EF0 RID: 20208 RVA: 0x009B1450 File Offset: 0x009AF650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (27473 - 81648 != -54175)
		{
		}
		for (;;)
		{
			if (this.P2PcnPdxR4O.isControlled)
			{
				if (38964 - 438403 == -399438)
				{
					continue;
				}
				if (!(this.P2PcnPdxR4O.actionState == "standby"))
				{
					if (92677 - 338426 == -245748)
					{
						continue;
					}
					if (!(this.P2PcnPdxR4O.actionState == "run"))
					{
						goto IL_322;
					}
					if (20012 - 563992 == -543979)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (154972 - 19322 == 135651)
				{
					continue;
				}
			}
			IL_322:
			if (this.P2PcnPdxR4O.hp <= 0)
			{
				if (108848 - 102013 != 6835)
				{
					continue;
				}
				if (this.P2PcnPdxR4O.actionState != "dead")
				{
					if (207326 - 597777 != -390451)
					{
						continue;
					}
					if (this.P2PcnPdxR4O.isMine)
					{
						if (220292 - 189650 != 30642)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (267677 - 308142 != -40465)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (204571 - 69195 != 135376)
						{
							continue;
						}
						this.P2PcnPdxR4O.DeadEvent();
						if (215476 - 346246 != -130769)
						{
							break;
						}
						continue;
					}
					else
					{
						this.P2PcnPdxR4O.hp = 1;
						if (7166 - 182025 != -174859)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.P2PcnPdxR4O.hp <= 0)
			{
				break;
			}
			if (165617 - 225878 != -60260)
			{
				if (this.P2PcnPdxR4O.ko > 0)
				{
					break;
				}
				if (210223 - 381054 != -170830)
				{
					if (!(this.P2PcnPdxR4O.actionState != "ko"))
					{
						break;
					}
					if (277385 - 150095 != 127291)
					{
						if (!(this.P2PcnPdxR4O.actionState != "dead"))
						{
							break;
						}
						if (178777 - 549015 != -370237)
						{
							if (this.P2PcnPdxR4O.isMine)
							{
								if (24232 - 581778 == -557546)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (22001 - 252697 == -230696)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (62760 - 47947 != 14814)
										{
											this.P2PcnPdxR4O.KoEvent();
											if (95567 - 52507 == 43060)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.P2PcnPdxR4O.ko = 1;
								if (243349 - 582621 == -339272)
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

	// Token: 0x06004EF1 RID: 20209 RVA: 0x009B1848 File Offset: 0x009AFA48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (963 - 423884 != -422920)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (25723 - 300014 == -274291)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (271589 - 247363 == 24226)
				{
					if (136720 - 373172 == -236452)
					{
						if (ActionName == "RPC_cheer")
						{
							if (118018 - 171149 != -53131)
							{
								continue;
							}
							v = 1;
							if (207353 - 283337 == -75983)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (228462 - 588714 == -360251)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (68700 - 215540 == -146840)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (239274 - 20791 == 218483)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (47053 - 355544 == -308491)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (225159 - 491475 != -266315)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (96111 - 310728 == -214617)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (296420 - 415998 == -119578)
											{
												Hashtable hashtable = new Hashtable();
												if (128126 - 4604 == 123522)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (113705 - 378986 != -265280)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (64810 - 254313 != -189502)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (210211 - 575754 != -365542)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (6071 - 444248 == -438177)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (240129 - 437372 != -197242)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (94171 - 501299 != -407127)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (208954 - 144015 == 64939)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (63587 - 568051 == -504464)
																				{
																					PhotonClient.SendEvent(this.P2PcnPdxR4O.ActorNr, 74, hashtable, true, true);
																					if (22832 - 140694 != -117861)
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

	// Token: 0x06004EF2 RID: 20210 RVA: 0x009B1C7C File Offset: 0x009AFE7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (49700 - 190035 != -140335)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (95017 - 120622 != -25604)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (291558 - 36357 == 255201)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (185250 - 131255 == 53995)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (287908 - 484322 != -196413)
						{
							int num2 = num;
							if (214074 - 130905 == 83169)
							{
								if (num2 == 1)
								{
									if (31015 - 462919 == -431904)
									{
										if (this.P2PcnPdxR4O.isMine)
										{
											break;
										}
										if (33222 - 444985 != -411762)
										{
											this.StartCoroutine_Auto(this.RPC_cheer(mPos, tDir, tID));
											if (9260 - 504552 != -495291)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (106753 - 248888 == -142135)
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

	// Token: 0x06004EF3 RID: 20211 RVA: 0x009B1E9C File Offset: 0x009B009C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (289352 - 177528 != 111825)
		{
		}
		for (;;)
		{
			float num = this.P2PcnPdxR4O.moveSpeed;
			if (67149 - 371367 == -304218)
			{
				float runSpeed = this.P2PcnPdxR4O.runSpeed;
				if (22547 - 155202 != -132654)
				{
					Vector3 a = default(Vector3);
					if (212682 - 175550 != 37133)
					{
						Vector3 vector = Vector3.zero;
						if (103603 - 13453 == 90150)
						{
							float num2 = (float)0;
							if (214239 - 400879 != -186639)
							{
								if (this.P2PcnPdxR4O.isMine)
								{
									if (194009 - 356766 == -162756)
									{
										continue;
									}
									if ((this.P2PcnPdxR4O.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (263514 - 122811 == 140704)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (215052 - 435941 == -220888)
										{
											continue;
										}
										a.y = (float)0;
										if (288660 - 209360 != 79300)
										{
											continue;
										}
										a = a.normalized;
										if (113347 - 2227 != 111120)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (158671 - 108010 != 50661)
										{
											continue;
										}
										vector = vector.normalized;
										if (283005 - 161273 != 121732)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (178440 - 343726 != -165286)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (23948 - 388079 != -364131)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (86388 - 76617 == 9772)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (196443 - 191253 == 5191)
														{
															continue;
														}
														this.P2PcnPdxR4O.actionState = "run";
														if (289639 - 216870 != 72769)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (93485 - 593048 != -499563)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (2652 - 297211 != -294559)
														{
															continue;
														}
														this.animation.Play("run");
														if (38512 - 147106 != -108594)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (89022 - 308802 != -219779)
														{
															goto IL_4E7;
														}
														continue;
													}
												}
											}
										}
										this.P2PcnPdxR4O.actionState = "standby";
										if (44666 - 504924 != -460258)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (249769 - 56760 == 193010)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (240110 - 35326 != 204784)
											{
												continue;
											}
											num = (float)0;
											if (267844 - 33842 != 234002)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (53788 - 420347 != -366559)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (49898 - 130409 == -80510)
										{
											continue;
										}
									}
									IL_4E7:;
								}
								else
								{
									vector = global::Math.vFlat(this.P2PcnPdxR4O.nPosition - this.transform.position);
									if (238723 - 160834 == 77890)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (124952 - 34837 == 90116)
									{
										continue;
									}
									if (this.P2PcnPdxR4O.nSpeed != (float)0)
									{
										if (39881 - 169516 != -129635)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (91048 - 104903 != -13855)
											{
												continue;
											}
											this.transform.position = this.P2PcnPdxR4O.nPosition;
											if (272962 - 99269 != 173693)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (222123 - 132784 == 89340)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (186007 - 296368 != -110361)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (298193 - 412366 == -114172)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.P2PcnPdxR4O.nSpeed, (float)10 * Time.deltaTime);
												if (109607 - 21002 == 88606)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (118946 - 283454 == -164507)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (272084 - 336345 != -64261)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (224160 - 134542 == 89619)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (172770 - 245201 != -72431)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (52886 - 485236 == -432349)
											{
												continue;
											}
										}
										else if (Time.time > this.P2PcnPdxR4O.nSpeed + 0.3f)
										{
											if (142552 - 224597 == -82044)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (244208 - 300537 != -56329)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (53489 - 519759 == -466269)
												{
													continue;
												}
												num = (float)0;
												if (242477 - 474103 != -231626)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.P2PcnPdxR4O.nDirection);
											if (91407 - 485340 == -393932)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (41683 - 253699 == -212015)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (135093 - 524510 == -389416)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (176137 - 507082 == -330944)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (242525 - 127038 == 115488)
											{
												continue;
											}
											this.transform.position = this.P2PcnPdxR4O.nPosition;
											if (37488 - 275388 == -237899)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (112413 - 404226 != -291813)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (12819 - 143645 == -130825)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (286373 - 290988 == -4614)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (19418 - 69679 == -50260)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (70430 - 382956 == -312525)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (279849 - 67823 == 212027)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (5549 - 363547 != -357998)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.P2PcnPdxR4O.nDirection);
											if (134451 - 348928 == -214476)
											{
												continue;
											}
											num = (float)0;
											if (460 - 395491 != -395031)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (249201 - 566276 == -317074)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (52590 - 485658 != -433068)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (157239 - 410048 != -252809)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (151798 - 255164 != -103366)
										{
											continue;
										}
									}
								}
								this.P2PcnPdxR4O.vMovement = vector;
								if (5326 - 455127 != -449800)
								{
									this.P2PcnPdxR4O.moveSpeed = num;
									if (145107 - 82436 != 62672)
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

	// Token: 0x06004EF4 RID: 20212 RVA: 0x009B2A00 File Offset: 0x009B0C00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (200607 - 74341 != 126267)
		{
		}
		for (;;)
		{
			if (!this.P2PcnPdxR4O.isMine)
			{
				if (80784 - 349805 == -269021)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (246498 - 550365 != -303866)
				{
					Vector3 vector = a - this.transform.position;
					if (291818 - 545984 != -254165)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (52076 - 563179 == -511103)
						{
							CharacterControl characterControl = null;
							if (158798 - 96472 == 62326)
							{
								int num = 0;
								if (233126 - 192112 == 41014)
								{
									if (gameObject)
									{
										if (255594 - 240835 == 14760)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (299006 - 597297 != -298291)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (10208 - 452763 != -442555)
										{
											continue;
										}
										num = characterControl.ActorNr;
										if (265778 - 212698 != 53080)
										{
											continue;
										}
									}
									if (!(this.P2PcnPdxR4O.actionState == "standby"))
									{
										if (204635 - 104167 != 100468)
										{
											continue;
										}
										if (!(this.P2PcnPdxR4O.actionState == "run"))
										{
											break;
										}
										if (159925 - 520275 == -360349)
										{
											continue;
										}
									}
									if (this.P2PcnPdxR4O.isTimeOut("nAttack") != (float)0)
									{
										if (67163 - 267710 != -200546)
										{
											Camera.main.SendMessage("newGameMessage", "Normal attack time out!");
											if (61540 - 329709 != -268168)
											{
												break;
											}
										}
									}
									else
									{
										if (gameObject)
										{
											if (60705 - 64564 == -3858)
											{
												continue;
											}
											if (num == 0)
											{
												if (102395 - 28318 != 74077)
												{
													continue;
												}
											}
											else if (gameObject.layer != this.gameObject.layer)
											{
												if (292867 - 182349 == 110519)
												{
													continue;
												}
												Camera.main.SendMessage("newGameMessage", "Must select friendly target.");
												if (57466 - 314499 != -257032)
												{
													break;
												}
												continue;
											}
											else
											{
												this.StartCoroutine_Auto(this.RPC_cheer(this.transform.position, vector, num));
												if (147848 - 369 != 147479)
												{
													continue;
												}
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (196070 - 354334 != -158264)
												{
													continue;
												}
												this.ActionEvent("RPC_cheer", this.transform.position, vector, num);
												if (5572 - 82075 != -76503)
												{
													continue;
												}
												break;
											}
										}
										Camera.main.SendMessage("newGameMessage", "No target selected.");
										if (193368 - 577030 != -383661)
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

	// Token: 0x06004EF5 RID: 20213 RVA: 0x009B2E0C File Offset: 0x009B100C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (69970 - 326899 != -256929)
		{
		}
		for (;;)
		{
			if (!this.P2PcnPdxR4O.isMine)
			{
				if (249361 - 163517 == 85844)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (89534 - 503948 != -414413)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (215540 - 456385 == -240845)
					{
						Vector3 normalized = vector.normalized;
						if (185913 - 160267 != 25647)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (237566 - 282673 != -45106)
							{
								CharacterControl characterControl = null;
								if (185826 - 371208 != -185381 && 181323 - 352600 != -171276)
								{
									if (gameObject)
									{
										if (148741 - 120721 == 28021)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (283591 - 539404 == -255812)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (216220 - 420913 != -204693)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (114170 - 468890 == -354719)
										{
											continue;
										}
									}
									if (!(this.P2PcnPdxR4O.actionState == "standby"))
									{
										if (291789 - 595688 != -303899)
										{
											continue;
										}
										if (!(this.P2PcnPdxR4O.actionState == "run"))
										{
											break;
										}
										if (105860 - 188843 == -82982)
										{
											continue;
										}
									}
									if (this.P2PcnPdxR4O.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (148781 - 322123 == -173342)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
										if (111029 - 333905 != -222875)
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

	// Token: 0x06004EF6 RID: 20214 RVA: 0x009B30D8 File Offset: 0x009B12D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004EF7 RID: 20215 RVA: 0x009B30DC File Offset: 0x009B12DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cheer(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Skunk.$RPC_cheer$33481(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004EF8 RID: 20216 RVA: 0x009B30EC File Offset: 0x009B12EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Skunk.$RPC_ko$33492(nArray, this).GetEnumerator();
	}

	// Token: 0x06004EF9 RID: 20217 RVA: 0x009B30FC File Offset: 0x009B12FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Skunk.$RPC_dead$33499(nArray, this).GetEnumerator();
	}

	// Token: 0x06004EFA RID: 20218 RVA: 0x009B310C File Offset: 0x009B130C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004EFB RID: 20219 RVA: 0x009B3110 File Offset: 0x009B1310
	internal static bool BS0TgO5uIFlYfpP5vVEH()
	{
		return true;
	}

	// Token: 0x06004EFC RID: 20220 RVA: 0x009B3114 File Offset: 0x009B1314
	internal static bool rdpOX15uBiZ9NuHX9tBg()
	{
		return false;
	}

	// Token: 0x040058A8 RID: 22696
	private Transform G5OcnEBpvGF;

	// Token: 0x040058A9 RID: 22697
	private CharacterControl P2PcnPdxR4O;

	// Token: 0x040058AA RID: 22698
	public GameObject cheer_ring;

	// Token: 0x040058AB RID: 22699
	public GameObject cheer_hit;

	// Token: 0x02000DAB RID: 3499
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cheer$33481 : GenericGenerator<WaitForFixedUpdate>
	{
		// Token: 0x06004EFD RID: 20221 RVA: 0x009B3118 File Offset: 0x009B1318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cheer$33481(Vector3 mPos, Vector3 tDir, int tID, Skunk self_)
		{
			if (284964 - 264036 != 20929)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (244631 - 298755 != -54123)
				{
					base..ctor();
					if (3167 - 505626 != -502458)
					{
						this.$mPos$33488 = mPos;
						if (184644 - 3983 != 180662)
						{
							this.$tDir$33489 = tDir;
							if (274660 - 579585 != -304924)
							{
								this.$tID$33490 = tID;
								if (242240 - 90276 != 151965)
								{
									this.$self_$33491 = self_;
									if (282454 - 333393 == -50939)
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

		// Token: 0x06004EFE RID: 20222 RVA: 0x009B3218 File Offset: 0x009B1418
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForFixedUpdate> GetEnumerator()
		{
			return new Skunk.$RPC_cheer$33481.$(this.$mPos$33488, this.$tDir$33489, this.$tID$33490, this.$self_$33491);
		}

		// Token: 0x06004EFF RID: 20223 RVA: 0x009B3238 File Offset: 0x009B1438
		internal static bool hpEcuI5ueZAhI5bbKcRJ()
		{
			return true;
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x009B323C File Offset: 0x009B143C
		internal static bool YU4dej5urXygqbJ9B2dn()
		{
			return false;
		}

		// Token: 0x040058AC RID: 22700
		internal Vector3 $mPos$33488;

		// Token: 0x040058AD RID: 22701
		internal Vector3 $tDir$33489;

		// Token: 0x040058AE RID: 22702
		internal int $tID$33490;

		// Token: 0x040058AF RID: 22703
		internal Skunk $self_$33491;

		// Token: 0x02000DAC RID: 3500
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForFixedUpdate>, IEnumerator
		{
			// Token: 0x06004F01 RID: 20225 RVA: 0x009B3240 File Offset: 0x009B1440
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Skunk self_)
			{
				if (101645 - 300688 != -199043)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284432 - 152820 == 131612)
					{
						base..ctor();
						if (160318 - 456639 == -296321)
						{
							this.$mPos$33484 = mPos;
							if (130165 - 354072 != -223906)
							{
								this.$tDir$33485 = tDir;
								if (20986 - 542367 == -521381)
								{
									this.$tID$33486 = tID;
									if (198574 - 594158 == -395584)
									{
										this.$self_$33487 = self_;
										if (153854 - 412661 != -258806)
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

			// Token: 0x06004F02 RID: 20226 RVA: 0x009B3340 File Offset: 0x009B1540
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (134229 - 394587 != -260357)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_4A8;
					case 1:
						goto IL_8FD;
					case 2:
						if (this.$self_$33487.P2PcnPdxR4O.actionState != "attack")
						{
							goto IL_521;
						}
						if (92639 - 164546 == -71906)
						{
							continue;
						}
						if (this.$self_$33487.P2PcnPdxR4O.myCommand != "cheer")
						{
							if (167934 - 401553 != -233619)
							{
								continue;
							}
							goto IL_521;
						}
						break;
					default:
						if (54826 - 27068 != 27759)
						{
							goto IL_4A8;
						}
						continue;
					}
					IL_526:
					if (Time.time >= this.$self_$33487.P2PcnPdxR4O.actionTime + 2f)
					{
						if (154342 - 232997 == -78654)
						{
							continue;
						}
						if (this.$self_$33487.P2PcnPdxR4O.actionState == "attack")
						{
							if (28120 - 115984 == -87863)
							{
								continue;
							}
							if (this.$self_$33487.P2PcnPdxR4O.myCommand == "cheer")
							{
								if (227972 - 82482 == 145491)
								{
									continue;
								}
								this.$self_$33487.P2PcnPdxR4O.actionState = "standby";
								if (38762 - 394825 != -356063)
								{
									continue;
								}
								this.$self_$33487.P2PcnPdxR4O.actionTime = Time.time;
								if (16432 - 416789 == -400356)
								{
									continue;
								}
								this.$self_$33487.P2PcnPdxR4O.myCommand = "none";
								if (244949 - 564860 != -319911)
								{
									continue;
								}
								if (!this.$self_$33487.P2PcnPdxR4O.isMine)
								{
									if (80097 - 387670 != -307573)
									{
										continue;
									}
									this.$self_$33487.P2PcnPdxR4O.nPosition = this.$self_$33487.transform.position;
									if (224309 - 112635 == 111675)
									{
										continue;
									}
									this.$self_$33487.P2PcnPdxR4O.oPosition = this.$self_$33487.transform.position;
									if (171490 - 234911 != -63421)
									{
										continue;
									}
									this.$self_$33487.P2PcnPdxR4O.nDirection = this.$self_$33487.transform.forward;
									if (188362 - 317942 == -129579)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (117176 - 77112 != 40065)
						{
							break;
						}
						continue;
					}
					else
					{
						if (!this.$tObject$33482)
						{
							goto IL_4D7;
						}
						if (268324 - 168238 != 100086)
						{
							continue;
						}
						this.$self_$33487.transform.LookAt(global::Math.vFlat(this.$tObject$33482.transform.position) + Vector3.up * this.$self_$33487.transform.position.y);
						if (54221 - 21079 != 33142)
						{
							continue;
						}
						goto IL_4D7;
					}
					IL_4A8:
					this.$self_$33487.P2PcnPdxR4O.actionState = "attack";
					if (196963 - 450885 != -253921)
					{
						this.$self_$33487.P2PcnPdxR4O.actionTime = Time.time;
						if (109200 - 258268 == -149068)
						{
							this.$self_$33487.P2PcnPdxR4O.myCommand = "cheer";
							if (277753 - 472630 == -194877)
							{
								this.$self_$33487.P2PcnPdxR4O.addTimeOut("nAttack", (float)30);
								if (223366 - 267785 != -44418)
								{
									this.$self_$33487.transform.position = this.$mPos$33484;
									if (138541 - 40799 == 97742)
									{
										this.$self_$33487.transform.LookAt(this.$mPos$33484 + global::Math.vFlat(this.$tDir$33485));
										if (2371 - 421039 != -418667)
										{
											this.$self_$33487.animation.CrossFade("cheer");
											if (184823 - 409263 == -224440)
											{
												this.$self_$33487.animation.wrapMode = WrapMode.Loop;
												if (92378 - 250634 != -158255)
												{
													this.$self_$33487.P2PcnPdxR4O.vMovement = this.$self_$33487.transform.forward;
													if (125137 - 316622 != -191484)
													{
														this.$self_$33487.P2PcnPdxR4O.moveSpeed = (float)0;
														if (19373 - 145913 == -126540)
														{
															if (this.$self_$33487.cheer_ring)
															{
																if (19946 - 150068 == -130121)
																{
																	continue;
																}
																this.$self_$33487.P2PcnPdxR4O.createEffect(this.$self_$33487.cheer_ring, this.$self_$33487.transform.position, this.$self_$33487.transform.rotation);
																if (239001 - 566174 == -327172)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing cheer_ring gameObject");
																if (266053 - 446549 != -180496)
																{
																	continue;
																}
															}
															this.$tObject$33482 = null;
															if (93366 - 556606 == -463240)
															{
																this.$tChar$33483 = null;
																if (86775 - 237079 != -150303)
																{
																	if (this.$tID$33486 != 0)
																	{
																		if (185724 - 428031 == -242306)
																		{
																			continue;
																		}
																		object obj2;
																		object obj = obj2 = PhotonClient.ActorNrList[this.$tID$33486];
																		if (!(obj is GameObject))
																		{
																			obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
																		}
																		this.$tObject$33482 = (GameObject)obj2;
																		if (84113 - 132361 != -48248)
																		{
																			continue;
																		}
																	}
																	if (this.$tObject$33482)
																	{
																		if (72769 - 186033 != -113264)
																		{
																			continue;
																		}
																		this.$tChar$33483 = (CharacterControl)this.$tObject$33482.GetComponent(typeof(CharacterControl));
																		if (204389 - 205515 != -1126)
																		{
																			continue;
																		}
																	}
																	if (this.$tChar$33483)
																	{
																		if (294744 - 60081 != 234663)
																		{
																			continue;
																		}
																		if (this.$self_$33487.cheer_hit)
																		{
																			if (29461 - 593363 == -563901)
																			{
																				continue;
																			}
																			this.$tChar$33483.createEffect(this.$self_$33487.cheer_hit, this.$tObject$33482.transform.position, this.$tObject$33482.transform.rotation);
																			if (115208 - 237555 != -122347)
																			{
																				continue;
																			}
																		}
																	}
																	if (this.$self_$33487.P2PcnPdxR4O.isMine)
																	{
																		if (11525 - 48843 != -37318)
																		{
																			continue;
																		}
																		if (this.$tChar$33483)
																		{
																			if (299676 - 209892 != 89784)
																			{
																				continue;
																			}
																			this.$tChar$33483.RPC_AddStatus("vitUp", 3, this.$self_$33487.P2PcnPdxR4O.chaAdjust(12), 30, this.$self_$33487.P2PcnPdxR4O.ActorNr);
																			if (137936 - 156860 != -18924)
																			{
																				continue;
																			}
																			this.$tChar$33483.RPC_AddStatus("talUp", 3, this.$self_$33487.P2PcnPdxR4O.chaAdjust(12), 30, this.$self_$33487.P2PcnPdxR4O.ActorNr);
																			if (132982 - 375118 == -242135)
																			{
																				continue;
																			}
																		}
																	}
																	goto IL_526;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_8FD;
				IL_4D7:
				return this.Yield(2, new WaitForFixedUpdate());
				IL_521:
				IL_8FD:
				return false;
			}

			// Token: 0x06004F03 RID: 20227 RVA: 0x009B3C5C File Offset: 0x009B1E5C
			internal static bool gqjulV5ujpRXGtF8vjtu()
			{
				return true;
			}

			// Token: 0x06004F04 RID: 20228 RVA: 0x009B3C60 File Offset: 0x009B1E60
			internal static bool GAMAgP5uhbYup2liqkO1()
			{
				return false;
			}

			// Token: 0x040058B0 RID: 22704
			internal GameObject $tObject$33482;

			// Token: 0x040058B1 RID: 22705
			internal CharacterControl $tChar$33483;

			// Token: 0x040058B2 RID: 22706
			internal Vector3 $mPos$33484;

			// Token: 0x040058B3 RID: 22707
			internal Vector3 $tDir$33485;

			// Token: 0x040058B4 RID: 22708
			internal int $tID$33486;

			// Token: 0x040058B5 RID: 22709
			internal Skunk $self_$33487;
		}
	}

	// Token: 0x02000DAD RID: 3501
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33492 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004F05 RID: 20229 RVA: 0x009B3C64 File Offset: 0x009B1E64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33492(UnityScript.Lang.Array nArray, Skunk self_)
		{
			if (237148 - 93614 != 143534)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (180495 - 446004 == -265509)
				{
					base..ctor();
					if (162678 - 147344 != 15335)
					{
						this.$nArray$33497 = nArray;
						if (29742 - 74987 == -45245)
						{
							this.$self_$33498 = self_;
							if (289010 - 538306 == -249296)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x009B3D20 File Offset: 0x009B1F20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Skunk.$RPC_ko$33492.$(this.$nArray$33497, this.$self_$33498);
		}

		// Token: 0x06004F07 RID: 20231 RVA: 0x009B3D34 File Offset: 0x009B1F34
		internal static bool m1nMIC5usvq46Pqyo0eZ()
		{
			return true;
		}

		// Token: 0x06004F08 RID: 20232 RVA: 0x009B3D38 File Offset: 0x009B1F38
		internal static bool wk7HVg5u96NXtrE0847M()
		{
			return false;
		}

		// Token: 0x040058B6 RID: 22710
		internal UnityScript.Lang.Array $nArray$33497;

		// Token: 0x040058B7 RID: 22711
		internal Skunk $self_$33498;

		// Token: 0x02000DAE RID: 3502
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004F09 RID: 20233 RVA: 0x009B3D3C File Offset: 0x009B1F3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Skunk self_)
			{
				if (6234 - 165203 != -158968)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (196269 - 105263 == 91006)
					{
						base..ctor();
						if (245892 - 397513 == -151621)
						{
							this.$nArray$33495 = nArray;
							if (142760 - 21552 == 121208)
							{
								this.$self_$33496 = self_;
								if (49742 - 464524 != -414781)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004F0A RID: 20234 RVA: 0x009B3DF8 File Offset: 0x009B1FF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (298693 - 200693 != 98001)
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
						if (this.$self_$33496.P2PcnPdxR4O.actionState != "ko")
						{
							if (1389 - 321283 != -319893)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$self_$33496.animation.Play("getUp");
							if (55005 - 193231 == -138225)
							{
								continue;
							}
							this.$self_$33496.animation.wrapMode = WrapMode.Once;
							if (59425 - 366783 != -307357)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33496.P2PcnPdxR4O.actionState != "ko")
						{
							if (47895 - 423699 != -375803)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$self_$33496.P2PcnPdxR4O.actionState = "standby";
							if (106322 - 312996 != -206674)
							{
								continue;
							}
							this.$self_$33496.P2PcnPdxR4O.actionTime = Time.time;
							if (188118 - 94833 == 93286)
							{
								continue;
							}
							this.$self_$33496.P2PcnPdxR4O.myCommand = "none";
							if (268683 - 291318 != -22635)
							{
								continue;
							}
							this.$self_$33496.P2PcnPdxR4O.ko = this.$self_$33496.P2PcnPdxR4O.mko;
							if (285527 - 83245 != 202282)
							{
								continue;
							}
							this.YieldDefault(1);
							if (106459 - 362610 != -256150)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					default:
						if (279502 - 12210 == 267293)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33496.P2PcnPdxR4O.actionState == "ko")
					{
						break;
					}
					if (158160 - 285817 != -127656)
					{
						if (this.$self_$33496.P2PcnPdxR4O.actionState == "dead")
						{
							if (103386 - 251314 == -147928)
							{
								break;
							}
						}
						else
						{
							this.$mPos$33493 = (Vector3)this.$nArray$33495[0];
							if (35399 - 335794 == -300395)
							{
								this.$mDir$33494 = (Vector3)this.$nArray$33495[1];
								if (190595 - 49124 != 141472)
								{
									this.$self_$33496.P2PcnPdxR4O.ko = 0;
									if (256747 - 209276 == 47471)
									{
										this.$self_$33496.P2PcnPdxR4O.actionState = "ko";
										if (133088 - 38623 == 94465)
										{
											this.$self_$33496.P2PcnPdxR4O.actionTime = Time.time;
											if (79232 - 447818 != -368585)
											{
												this.$self_$33496.P2PcnPdxR4O.myCommand = "none";
												if (279062 - 171463 != 107600)
												{
													this.$self_$33496.P2PcnPdxR4O.vMovement = Vector3.zero;
													if (210066 - 179797 != 30270)
													{
														this.$self_$33496.P2PcnPdxR4O.moveSpeed = (float)0;
														if (195004 - 59440 != 135565)
														{
															this.$self_$33496.animation.Play("ko");
															if (262391 - 156614 == 105777)
															{
																this.$self_$33496.animation.wrapMode = WrapMode.Once;
																if (38915 - 443912 == -404997)
																{
																	goto IL_3A1;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_48C;
				IL_3A1:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_22:
				goto IL_48C;
				Block_23:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_24:
				Block_26:
				IL_48C:
				return false;
			}

			// Token: 0x06004F0B RID: 20235 RVA: 0x009B42A4 File Offset: 0x009B24A4
			internal static bool eVc2mv5u1u6W0HQ5kjih()
			{
				return true;
			}

			// Token: 0x06004F0C RID: 20236 RVA: 0x009B42A8 File Offset: 0x009B24A8
			internal static bool jSpLyd5u48LbMtOA5R7A()
			{
				return false;
			}

			// Token: 0x040058B8 RID: 22712
			internal Vector3 $mPos$33493;

			// Token: 0x040058B9 RID: 22713
			internal Vector3 $mDir$33494;

			// Token: 0x040058BA RID: 22714
			internal UnityScript.Lang.Array $nArray$33495;

			// Token: 0x040058BB RID: 22715
			internal Skunk $self_$33496;
		}
	}

	// Token: 0x02000DAF RID: 3503
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33499 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004F0D RID: 20237 RVA: 0x009B42AC File Offset: 0x009B24AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33499(UnityScript.Lang.Array nArray, Skunk self_)
		{
			if (121992 - 237666 != -115674)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (39449 - 311890 == -272441)
				{
					base..ctor();
					if (182738 - 572615 == -389877)
					{
						this.$nArray$33504 = nArray;
						if (285915 - 53062 == 232853)
						{
							this.$self_$33505 = self_;
							if (147364 - 204159 != -56794)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004F0E RID: 20238 RVA: 0x009B4368 File Offset: 0x009B2568
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Skunk.$RPC_dead$33499.$(this.$nArray$33504, this.$self_$33505);
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x009B437C File Offset: 0x009B257C
		internal static bool ucSU4M5uzld32IS4Q1f8()
		{
			return true;
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x009B4380 File Offset: 0x009B2580
		internal static bool PTIfIF5IaoRQQTqZE785()
		{
			return false;
		}

		// Token: 0x040058BC RID: 22716
		internal UnityScript.Lang.Array $nArray$33504;

		// Token: 0x040058BD RID: 22717
		internal Skunk $self_$33505;

		// Token: 0x02000DB0 RID: 3504
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004F11 RID: 20241 RVA: 0x009B4384 File Offset: 0x009B2584
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Skunk self_)
			{
				if (209263 - 496051 != -286787)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (147185 - 222205 == -75020)
					{
						base..ctor();
						if (72857 - 327852 == -254995)
						{
							this.$nArray$33502 = nArray;
							if (189859 - 590877 == -401018)
							{
								this.$self_$33503 = self_;
								if (15270 - 418787 != -403516)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004F12 RID: 20242 RVA: 0x009B4440 File Offset: 0x009B2640
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (170789 - 529962 != -359172)
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
						if (this.$self_$33503.P2PcnPdxR4O.actionState != "dead")
						{
							if (83123 - 564385 != -481261)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33503.P2PcnPdxR4O.isPlayer)
							{
								if (192917 - 353516 != -160599)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$33503.gameObject);
								if (88761 - 50420 == 38342)
								{
									continue;
								}
							}
							else if (this.$self_$33503.P2PcnPdxR4O.isMine)
							{
								if (292538 - 154113 == 138426)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33503.gameObject);
								if (35659 - 548111 == -512451)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (173879 - 589013 != -415134)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (247876 - 410709 != -162833)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33503.P2PcnPdxR4O.actionState == "dead")
					{
						if (147973 - 303080 == -155107)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33500 = (Vector3)this.$nArray$33502[0];
						if (272411 - 446859 == -174448)
						{
							this.$myDirection$33501 = (Vector3)this.$nArray$33502[1];
							if (98981 - 48176 == 50805)
							{
								this.$self_$33503.transform.position = this.$myPosition$33500;
								if (244292 - 118007 == 126285)
								{
									this.$self_$33503.transform.LookAt(this.$myPosition$33500 + this.$myDirection$33501);
									if (160169 - 554662 != -394492)
									{
										this.$self_$33503.P2PcnPdxR4O.hp = 0;
										if (174873 - 263282 != -88408)
										{
											this.$self_$33503.P2PcnPdxR4O.actionState = "dead";
											if (96787 - 20109 == 76678)
											{
												this.$self_$33503.P2PcnPdxR4O.actionTime = Time.time;
												if (99428 - 437638 == -338210)
												{
													this.$self_$33503.P2PcnPdxR4O.myCommand = "none";
													if (174641 - 6687 != 167955)
													{
														this.$self_$33503.P2PcnPdxR4O.vMovement = Vector3.zero;
														if (47087 - 311838 != -264750)
														{
															this.$self_$33503.P2PcnPdxR4O.moveSpeed = (float)0;
															if (279597 - 424661 != -145063)
															{
																this.$self_$33503.animation.Rewind();
																if (233072 - 372387 != -139314)
																{
																	this.$self_$33503.animation.Play("ko");
																	if (103393 - 310636 == -207243)
																	{
																		this.$self_$33503.animation.wrapMode = WrapMode.Once;
																		if (690 - 332414 != -331723)
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
				Block_23:
				goto IL_42F;
				Block_26:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06004F13 RID: 20243 RVA: 0x009B4890 File Offset: 0x009B2A90
			internal static bool TFdp2b5I5Hfxd6fnRceh()
			{
				return true;
			}

			// Token: 0x06004F14 RID: 20244 RVA: 0x009B4894 File Offset: 0x009B2A94
			internal static bool DC173e5IpFgdUFrBcRRV()
			{
				return false;
			}

			// Token: 0x040058BE RID: 22718
			internal Vector3 $myPosition$33500;

			// Token: 0x040058BF RID: 22719
			internal Vector3 $myDirection$33501;

			// Token: 0x040058C0 RID: 22720
			internal UnityScript.Lang.Array $nArray$33502;

			// Token: 0x040058C1 RID: 22721
			internal Skunk $self_$33503;
		}
	}
}
