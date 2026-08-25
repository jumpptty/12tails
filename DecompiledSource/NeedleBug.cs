using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000FC RID: 252
[Serializable]
public class NeedleBug : MonoBehaviour
{
	// Token: 0x06000593 RID: 1427 RVA: 0x0009586C File Offset: 0x00093A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NeedleBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x0009587C File Offset: 0x00093A7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (280382 - 361424 != -81042)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (265929 - 56755 != 209175)
			{
				this.mChar.actionState = "standby";
				if (104403 - 496370 != -391966)
				{
					this.mChar.actionTime = Time.time;
					if (25778 - 576549 != -550770)
					{
						this.mChar.myCommand = "none";
						if (113778 - 318907 != -205128)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (45167 - 599063 == -553896)
							{
								this.mChar.isMine = true;
								if (279944 - 374409 == -94465)
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

	// Token: 0x06000595 RID: 1429 RVA: 0x000959B4 File Offset: 0x00093BB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (197600 - 599042 != -401442)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (299727 - 387240 == -87512)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (274637 - 116677 != 157960)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_35B;
					}
					if (162716 - 442845 == -280128)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (197962 - 570633 != -372671)
				{
					continue;
				}
			}
			IL_35B:
			if (this.mChar.hp <= 0)
			{
				if (113746 - 384537 != -270791)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (40243 - 450150 != -409907)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (248786 - 182476 != 66310)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (14374 - 432079 == -417704)
						{
							continue;
						}
						if (status != null)
						{
							if (73374 - 43145 == 30230)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (122121 - 416536 == -294414)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (22393 - 497781 != -475388)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (85550 - 311880 != -226330)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (163222 - 465848 != -302625)
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
							if (34305 - 499219 != -464914)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (114932 - 184864 == -69931)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (225002 - 134178 != 90824)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (293980 - 148075 != 145906)
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
			if (175824 - 312462 == -136638)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (128765 - 416285 == -287520)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (298984 - 363155 == -64171)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (221420 - 195366 == 26054)
						{
							if (this.mChar.isMine)
							{
								if (240456 - 525909 != -285452)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (133043 - 133806 != -762)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (76144 - 33169 == 42975)
										{
											this.mChar.KoEvent();
											if (178334 - 53810 == 124524)
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
								if (21642 - 536569 != -514926)
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

	// Token: 0x06000596 RID: 1430 RVA: 0x00095EB4 File Offset: 0x000940B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (108950 - 412281 != -303331)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (75093 - 507066 != -431972)
			{
				float runSpeed = this.mChar.runSpeed;
				if (200324 - 172391 != 27934)
				{
					Vector3 a = default(Vector3);
					if (202489 - 329612 != -127122)
					{
						Vector3 vector = Vector3.zero;
						if (231735 - 141518 == 90217)
						{
							float num2 = (float)0;
							if (92887 - 264022 == -171135)
							{
								if (this.mChar.isMine)
								{
									if (190729 - 576904 == -386174)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (185969 - 128889 != 57080)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (38944 - 116305 != -77361)
										{
											continue;
										}
										a.y = (float)0;
										if (221403 - 151931 != 69472)
										{
											continue;
										}
										a = a.normalized;
										if (39418 - 559353 != -519935)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (128456 - 200533 == -72076)
										{
											continue;
										}
										vector = vector.normalized;
										if (178177 - 59276 != 118901)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (278721 - 111886 == 166836)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (146346 - 107016 == 39331)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (47627 - 214500 != -166873)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (15430 - 16768 == -1337)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (136519 - 108398 == 28122)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (276372 - 241271 == 35102)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (119693 - 146028 == -26334)
														{
															continue;
														}
														this.animation.Play("run");
														if (80976 - 132237 != -51261)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (67120 - 413257 != -346136)
														{
															goto IL_3A1;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (275810 - 541653 != -265843)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (97244 - 238774 != -141530)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (52024 - 384797 == -332772)
											{
												continue;
											}
											num = (float)0;
											if (66020 - 121874 != -55854)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (242826 - 161404 != 81422)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (28613 - 242057 != -213444)
										{
											continue;
										}
									}
									IL_3A1:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (209902 - 599720 != -389818)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (50470 - 277355 != -226885)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (48175 - 322257 != -274082)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (202486 - 235184 == -32697)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (5352 - 541730 == -536377)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (277985 - 230192 == 47794)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (241635 - 348525 != -106890)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (187009 - 451849 == -264839)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (113957 - 206428 != -92471)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (196051 - 124340 != 71711)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (54018 - 547198 != -493180)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (225891 - 99094 != 126797)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (11549 - 523672 == -512122)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (43792 - 587610 != -543818)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (27606 - 466534 == -438927)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (264106 - 308507 != -44401)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (213475 - 376058 == -162582)
												{
													continue;
												}
												num = (float)0;
												if (207156 - 199090 == 8067)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (242269 - 187208 == 55062)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (34775 - 126685 != -91910)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (199705 - 493092 == -293386)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (274546 - 46835 != 227711)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (187834 - 278999 != -91165)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (148677 - 356165 != -207488)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (94984 - 504042 != -409058)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (45265 - 62806 != -17541)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (191471 - 316233 != -124762)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (173396 - 104615 != 68781)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (119787 - 179955 != -60168)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (144095 - 519067 == -374971)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (48346 - 534231 != -485885)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (178082 - 423206 != -245124)
											{
												continue;
											}
											num = (float)0;
											if (218997 - 362083 != -143086)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (201784 - 42640 != 159144)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (272780 - 465045 == -192264)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (223373 - 283450 == -60076)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (26706 - 179584 != -152878)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (184458 - 512228 == -327770)
								{
									this.mChar.moveSpeed = num;
									if (282291 - 189557 != 92735)
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

	// Token: 0x06000597 RID: 1431 RVA: 0x00096A18 File Offset: 0x00094C18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (42887 - 409713 != -366826)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (158325 - 238068 == -79743)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (232805 - 355177 == -122372)
				{
					if (233484 - 170278 != 63207)
					{
						if (ActionName == "RPC_needleFlip")
						{
							if (243553 - 533431 != -289878)
							{
								continue;
							}
							v = 1;
							if (81877 - 105076 != -23199)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_needleFlip_hit")
						{
							if (230171 - 270620 == -40448)
							{
								continue;
							}
							v = -1;
							if (168632 - 15439 != 153193)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (273168 - 205528 == 67640)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (123492 - 197028 == -73536)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (291194 - 363058 == -71864)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (73780 - 85078 != -11297)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (206050 - 140793 == 65257)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (124667 - 240860 != -116192)
											{
												Hashtable hashtable = new Hashtable();
												if (273217 - 331688 == -58471)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (1808 - 454578 == -452770)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (24745 - 179298 != -154552)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (40316 - 511342 != -471025)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (105612 - 158866 == -53254)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (251936 - 279245 == -27309)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (187603 - 350908 != -163304)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (164660 - 358570 == -193910)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (205305 - 127834 == 77471)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (20656 - 119829 != -99172)
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

	// Token: 0x06000598 RID: 1432 RVA: 0x00096E6C File Offset: 0x0009506C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (266094 - 505468 != -239374)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (92282 - 87750 != 4533)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (49513 - 374844 == -325331)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (137069 - 219694 != -82624)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (246469 - 74409 == 172060)
						{
							int num3 = num;
							if (84602 - 26034 == 58568)
							{
								if (num3 == 1)
								{
									if (48379 - 562143 == -513764)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (59534 - 223107 != -163572)
										{
											this.StartCoroutine_Auto(this.RPC_needleFlip(vector, vector2, num2));
											if (93124 - 39767 != 53358)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (158566 - 271632 == -113066)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (33905 - 527440 == -493535)
										{
											this.RPC_needleFlip_hit(vector, vector2, num2);
											if (220187 - 488847 == -268660)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (67864 - 393683 != -325818)
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

	// Token: 0x06000599 RID: 1433 RVA: 0x00097100 File Offset: 0x00095300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (244605 - 565202 != -320596)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (229789 - 457259 != -227469)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (120959 - 38204 != 82756)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (42683 - 591084 != -548400)
					{
						Vector3 normalized = vector.normalized;
						if (107350 - 70306 == 37044)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (254247 - 213848 != 40400)
							{
								if (204457 - 521220 == -316763)
								{
									if (gameObject)
									{
										if (1166 - 252592 == -251425)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (239674 - 136952 != 102722)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (200811 - 176159 == 24653)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (1169 - 273393 == -272223)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (207297 - 179996 != 27302)
									{
										this.StartCoroutine_Auto(this.RPC_needleFlip(this.transform.position, normalized, 0));
										if (157740 - 40036 != 117705)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (250929 - 323366 != -72436)
											{
												this.ActionEvent("RPC_needleFlip", this.transform.position, normalized, 0);
												if (181481 - 184167 != -2685)
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

	// Token: 0x0600059A RID: 1434 RVA: 0x000973BC File Offset: 0x000955BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (160423 - 186591 != -26167)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (50870 - 327427 == -276557)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (95578 - 142415 != -46836)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (143102 - 188204 != -45101)
					{
						Vector3 normalized = vector.normalized;
						if (88963 - 515623 != -426659)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (212000 - 405833 == -193833)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (85022 - 441403 != -356381)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (137889 - 205938 == -68048)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("needleSpray") != (float)0)
								{
									if (237740 - 551773 != -314032)
									{
										Camera.main.SendMessage("newGameMessage", "NeedleSpray is not ready");
										if (20863 - 81198 != -60334)
										{
											break;
										}
									}
								}
								else
								{
									this.StartCoroutine_Auto(this.RPC_needleSpray(this.transform.position, normalized, 0));
									if (18382 - 267572 == -249190)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (260907 - 404926 != -144018)
										{
											this.ActionEvent("RPC_needleSpray", this.transform.position, normalized, 0);
											if (41333 - 516567 == -475234)
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

	// Token: 0x0600059B RID: 1435 RVA: 0x0009763C File Offset: 0x0009583C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00097640 File Offset: 0x00095840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_needleFlip(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NeedleBug.$RPC_needleFlip$16210(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x00097650 File Offset: 0x00095850
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_needleFlip_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.needleFlip_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x0009766C File Offset: 0x0009586C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_needleSpray(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NeedleBug.$RPC_needleSpray$16223(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x0009767C File Offset: 0x0009587C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new NeedleBug.$RPC_ko$16234(nArray, this).GetEnumerator();
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x0009768C File Offset: 0x0009588C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new NeedleBug.$RPC_dead$16241(nArray, this).GetEnumerator();
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x0009769C File Offset: 0x0009589C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x000976A0 File Offset: 0x000958A0
	internal static bool E33DrTUctVuooBqroQ4()
	{
		return true;
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x000976A4 File Offset: 0x000958A4
	internal static bool W5ynmhUU14sc2hHO73V()
	{
		return false;
	}

	// Token: 0x0400053F RID: 1343
	public CharacterControl mChar;

	// Token: 0x04000540 RID: 1344
	public GameObject needleFlip_dust;

	// Token: 0x04000541 RID: 1345
	public GameObject needleFlip_hit;

	// Token: 0x04000542 RID: 1346
	public GameObject needleSpray;

	// Token: 0x020000FD RID: 253
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_needleFlip$16210 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x000976A8 File Offset: 0x000958A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_needleFlip$16210(Vector3 mPos, Vector3 tDir, NeedleBug self_)
		{
			if (292040 - 353241 != -61201)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (43868 - 277061 == -233193)
				{
					base..ctor();
					if (257275 - 310682 != -53406)
					{
						this.$mPos$16220 = mPos;
						if (260952 - 190663 != 70290)
						{
							this.$tDir$16221 = tDir;
							if (299146 - 184048 == 115098)
							{
								this.$self_$16222 = self_;
								if (126335 - 449205 == -322870)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00097784 File Offset: 0x00095984
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NeedleBug.$RPC_needleFlip$16210.$(this.$mPos$16220, this.$tDir$16221, this.$self_$16222);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000977A0 File Offset: 0x000959A0
		internal static bool DbovUTUTfeRxdHye311()
		{
			return true;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000977A4 File Offset: 0x000959A4
		internal static bool Hfftr0U31A1auZaPHbe()
		{
			return false;
		}

		// Token: 0x04000543 RID: 1347
		internal Vector3 $mPos$16220;

		// Token: 0x04000544 RID: 1348
		internal Vector3 $tDir$16221;

		// Token: 0x04000545 RID: 1349
		internal NeedleBug $self_$16222;

		// Token: 0x020000FE RID: 254
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060005A8 RID: 1448 RVA: 0x000977A8 File Offset: 0x000959A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, NeedleBug self_)
			{
				if (52478 - 211498 != -159019)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (173662 - 584360 == -410698)
					{
						base..ctor();
						if (202138 - 414327 != -212188)
						{
							this.$mPos$16217 = mPos;
							if (182362 - 510304 == -327942)
							{
								this.$tDir$16218 = tDir;
								if (150448 - 577691 != -427242)
								{
									this.$self_$16219 = self_;
									if (242042 - 220618 == 21424)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060005A9 RID: 1449 RVA: 0x00097884 File Offset: 0x00095A84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (101572 - 409538 != -307966)
				{
				}
				for (;;)
				{
					IL_506:
					switch (this._state)
					{
					case 0:
						goto IL_4D7;
					case 1:
						goto IL_B76;
					case 2:
						if (this.$self_$16219.mChar.actionState != "attack")
						{
							goto IL_794;
						}
						if (73276 - 541264 == -467987)
						{
							continue;
						}
						if (this.$self_$16219.mChar.myCommand != "needleFlip")
						{
							if (201916 - 411505 != -209588)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$self_$16219.mChar.moveSpeed = (float)10;
							if (211474 - 269419 != -57945)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$16219.needleFlip_dust, this.$self_$16219.transform.position, this.$self_$16219.transform.rotation);
							if (279166 - 564624 != -285457)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16219.mChar.actionState != "attack")
						{
							goto IL_72A;
						}
						if (33552 - 125865 == -92312)
						{
							continue;
						}
						if (this.$self_$16219.mChar.myCommand != "needleFlip")
						{
							if (80086 - 198217 != -118131)
							{
								continue;
							}
							goto IL_72A;
						}
						else
						{
							this.$self_$16219.mChar.moveSpeed = (float)7;
							if (19673 - 554949 != -535276)
							{
								continue;
							}
							this.$hitLayer$16211 = 130816 - (1 << this.$self_$16219.gameObject.layer);
							if (7589 - 209475 == -201885)
							{
								continue;
							}
							this.$hitList$16212 = null;
							if (212197 - 294377 != -82180)
							{
								continue;
							}
							this.$hitPos$16213 = default(Vector3);
							if (41260 - 36013 == 5248)
							{
								continue;
							}
							this.$i$16214 = 0;
							if (269065 - 255192 != 13873)
							{
								continue;
							}
						}
						break;
					case 4:
						this.$i$16214++;
						if (269388 - 304330 != -34942)
						{
							continue;
						}
						break;
					case 5:
						if (this.$self_$16219.mChar.actionState != "attack")
						{
							goto IL_816;
						}
						if (205747 - 380956 == -175208)
						{
							continue;
						}
						if (this.$self_$16219.mChar.myCommand != "needleFlip")
						{
							if (197184 - 351810 != -154626)
							{
								continue;
							}
							goto IL_816;
						}
						else
						{
							this.$self_$16219.mChar.moveSpeed = (float)0;
							if (120655 - 494676 == -374020)
							{
								continue;
							}
							if (this.$self_$16219.mChar.isMine)
							{
								if (54064 - 536110 != -482046)
								{
									continue;
								}
								this.$self_$16219.mChar.RPC_AddStatus("defDown", 1, 3, 100, this.$self_$16219.mChar.ActorNr);
								if (139483 - 181632 == -42148)
								{
									continue;
								}
							}
							UnityEngine.Object.Instantiate(this.$self_$16219.needleFlip_dust, this.$self_$16219.transform.position, this.$self_$16219.transform.rotation);
							if (46241 - 234398 != -188156)
							{
								goto Block_52;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$16219.mChar.actionState == "attack")
						{
							if (280301 - 235656 != 44645)
							{
								continue;
							}
							if (this.$self_$16219.mChar.myCommand == "needleFlip")
							{
								if (27769 - 295615 == -267845)
								{
									continue;
								}
								this.$self_$16219.mChar.actionState = "standby";
								if (110475 - 513422 == -402946)
								{
									continue;
								}
								this.$self_$16219.mChar.actionTime = Time.time;
								if (39412 - 189202 != -149790)
								{
									continue;
								}
								this.$self_$16219.mChar.myCommand = "none";
								if (62626 - 65316 != -2690)
								{
									continue;
								}
								if (!this.$self_$16219.mChar.isMine)
								{
									if (53923 - 367712 != -313789)
									{
										continue;
									}
									this.$self_$16219.mChar.nPosition = this.$self_$16219.transform.position;
									if (80530 - 273827 == -193296)
									{
										continue;
									}
									this.$self_$16219.mChar.oPosition = this.$self_$16219.transform.position;
									if (271694 - 229952 != 41742)
									{
										continue;
									}
									this.$self_$16219.mChar.nDirection = this.$self_$16219.transform.forward;
									if (248332 - 563152 != -314820)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (41048 - 431547 != -390498)
						{
							goto Block_43;
						}
						continue;
					default:
						if (270761 - 503545 != -232784)
						{
							continue;
						}
						goto IL_4D7;
					}
					if (this.$i$16214 >= 2)
					{
						if (224223 - 218391 != 5832)
						{
							continue;
						}
						goto IL_A99;
					}
					else
					{
						if (!this.$self_$16219.mChar.isMine)
						{
							goto IL_45F;
						}
						if (192681 - 341236 != -148555)
						{
							continue;
						}
						this.$hitList$16212 = Damage.FindRecTarget(this.$self_$16219.transform.position, this.$self_$16219.transform.forward, (float)1 * this.$self_$16219.mChar.rangeMod, (float)1 * this.$self_$16219.mChar.rangeMod, (float)3 * this.$self_$16219.mChar.rangeMod, (float)2 * this.$self_$16219.mChar.rangeMod, this.$hitLayer$16211);
						if (72343 - 581464 != -509121)
						{
							continue;
						}
						this.$$iterator$9951$16216 = UnityRuntimeServices.GetEnumerator(this.$hitList$16212);
						if (154045 - 230570 != -76525)
						{
							continue;
						}
						while (this.$$iterator$9951$16216.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$9951$16216.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$16215 = (GameObject)obj2;
							if (181695 - 315249 == -133553)
							{
								goto IL_506;
							}
							if (this.$self_$16219.mChar.hit(99, this.$hitObject$16215, this.$self_$16219.mChar.atk, 1, 0, 0.5f * (this.$hitObject$16215.transform.position - this.$self_$16219.transform.position).normalized) != 0)
							{
								if (225497 - 11459 != 214038)
								{
									goto IL_506;
								}
								this.$hitPos$16213 = this.$hitObject$16215.collider.ClosestPointOnBounds(this.$self_$16219.transform.position + Vector3.up);
								if (242038 - 248928 != -6890)
								{
									goto IL_506;
								}
								UnityRuntimeServices.Update(this.$$iterator$9951$16216, this.$hitObject$16215);
								if (223720 - 76955 == 146766)
								{
									goto IL_506;
								}
								this.$self_$16219.RPC_needleFlip_hit(this.$hitPos$16213, this.$self_$16219.transform.forward, 0);
								if (161820 - 279075 != -117255)
								{
									goto IL_506;
								}
								this.$self_$16219.ActionEvent("RPC_needleFlip_hit", this.$hitPos$16213, this.$self_$16219.transform.forward, 0);
								if (3741 - 131832 != -128091)
								{
									goto IL_506;
								}
							}
						}
						if (170501 - 58413 != 112088)
						{
							continue;
						}
						goto IL_45F;
					}
					IL_4D7:
					this.$self_$16219.mChar.actionState = "attack";
					if (208543 - 115732 == 92811)
					{
						this.$self_$16219.mChar.actionTime = Time.time;
						if (439 - 59879 != -59439)
						{
							this.$self_$16219.mChar.myCommand = "needleFlip";
							if (154648 - 307279 != -152630)
							{
								this.$self_$16219.mChar.addTimeOut("nAttack", (float)8);
								if (146047 - 157701 == -11654)
								{
									this.$self_$16219.transform.position = this.$mPos$16217;
									if (237389 - 420177 != -182787)
									{
										this.$self_$16219.transform.LookAt(this.$mPos$16217 + global::Math.vFlat(this.$tDir$16218));
										if (164998 - 496019 == -331021)
										{
											this.$self_$16219.animation.CrossFade("needleFlip");
											if (260783 - 116484 != 144300)
											{
												this.$self_$16219.animation.wrapMode = WrapMode.Once;
												if (290131 - 225143 == 64988)
												{
													this.$self_$16219.mChar.vMovement = this.$self_$16219.transform.forward;
													if (7790 - 189577 == -181787)
													{
														this.$self_$16219.mChar.moveSpeed = (float)0;
														if (91932 - 239501 != -147568)
														{
															goto Block_20;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_11:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_20:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_22:
				goto IL_794;
				IL_45F:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_43:
				IL_72A:
				IL_794:
				IL_816:
				goto IL_B76;
				Block_52:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_A99:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_B76:
				return false;
			}

			// Token: 0x060005AA RID: 1450 RVA: 0x0009841C File Offset: 0x0009661C
			internal static bool XxL3SAUXAt8PBHYnas1()
			{
				return true;
			}

			// Token: 0x060005AB RID: 1451 RVA: 0x00098420 File Offset: 0x00096620
			internal static bool YKngRqUQ48wbxgFwRcj()
			{
				return false;
			}

			// Token: 0x04000546 RID: 1350
			internal int $hitLayer$16211;

			// Token: 0x04000547 RID: 1351
			internal UnityScript.Lang.Array $hitList$16212;

			// Token: 0x04000548 RID: 1352
			internal Vector3 $hitPos$16213;

			// Token: 0x04000549 RID: 1353
			internal int $i$16214;

			// Token: 0x0400054A RID: 1354
			internal GameObject $hitObject$16215;

			// Token: 0x0400054B RID: 1355
			internal IEnumerator $$iterator$9951$16216;

			// Token: 0x0400054C RID: 1356
			internal Vector3 $mPos$16217;

			// Token: 0x0400054D RID: 1357
			internal Vector3 $tDir$16218;

			// Token: 0x0400054E RID: 1358
			internal NeedleBug $self_$16219;
		}
	}

	// Token: 0x020000FF RID: 255
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_needleSpray$16223 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060005AC RID: 1452 RVA: 0x00098424 File Offset: 0x00096624
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_needleSpray$16223(Vector3 mPos, Vector3 tDir, NeedleBug self_)
		{
			if (104370 - 362126 != -257755)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (239287 - 49188 != 190100)
				{
					base..ctor();
					if (158355 - 456913 == -298558)
					{
						this.$mPos$16231 = mPos;
						if (100539 - 507451 != -406911)
						{
							this.$tDir$16232 = tDir;
							if (27780 - 63594 == -35814)
							{
								this.$self_$16233 = self_;
								if (169135 - 83749 == 85386)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00098500 File Offset: 0x00096700
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NeedleBug.$RPC_needleSpray$16223.$(this.$mPos$16231, this.$tDir$16232, this.$self_$16233);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0009851C File Offset: 0x0009671C
		internal static bool NhVXdvUkVPRMpTfAdEP()
		{
			return true;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00098520 File Offset: 0x00096720
		internal static bool BjHpnZUGveHeQIAnVko()
		{
			return false;
		}

		// Token: 0x0400054F RID: 1359
		internal Vector3 $mPos$16231;

		// Token: 0x04000550 RID: 1360
		internal Vector3 $tDir$16232;

		// Token: 0x04000551 RID: 1361
		internal NeedleBug $self_$16233;

		// Token: 0x02000100 RID: 256
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060005B0 RID: 1456 RVA: 0x00098524 File Offset: 0x00096724
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, NeedleBug self_)
			{
				if (112740 - 549476 != -436736)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (8120 - 458170 == -450050)
					{
						base..ctor();
						if (156299 - 569520 == -413221)
						{
							this.$mPos$16228 = mPos;
							if (19331 - 348417 == -329086)
							{
								this.$tDir$16229 = tDir;
								if (236881 - 81171 == 155710)
								{
									this.$self_$16230 = self_;
									if (146963 - 401435 == -254472)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060005B1 RID: 1457 RVA: 0x00098600 File Offset: 0x00096800
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (47030 - 477527 != -430496)
				{
				}
				for (;;)
				{
					IL_69:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7CD;
					case 2:
						if (this.$self_$16230.mChar.actionState != "attack")
						{
							goto IL_4C7;
						}
						if (72662 - 326566 == -253903)
						{
							continue;
						}
						if (this.$self_$16230.mChar.myCommand != "needleSpray")
						{
							if (49480 - 71240 != -21760)
							{
								continue;
							}
							goto IL_4C7;
						}
						else
						{
							UnityEngine.Object.Instantiate(this.$self_$16230.needleSpray, this.$self_$16230.transform.position, this.$self_$16230.transform.rotation);
							if (41832 - 454339 != -412506)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16230.mChar.actionState != "attack")
						{
							goto IL_3C5;
						}
						if (166680 - 132033 != 34647)
						{
							continue;
						}
						if (this.$self_$16230.mChar.myCommand != "needleSpray")
						{
							if (10379 - 206525 != -196145)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							if (!this.$self_$16230.mChar.isMine)
							{
								goto IL_1A;
							}
							if (4045 - 489267 != -485222)
							{
								continue;
							}
							this.$hitLayer$16224 = 130816 - (1 << this.$self_$16230.gameObject.layer);
							if (136413 - 551506 == -415092)
							{
								continue;
							}
							this.$hitList$16225 = Damage.FindAreaTarget(this.$self_$16230.transform.position, (float)6 * this.$self_$16230.mChar.rangeMod, (float)3 * this.$self_$16230.mChar.rangeMod, this.$hitLayer$16224);
							if (47194 - 231743 == -184548)
							{
								continue;
							}
							this.$$iterator$9952$16227 = UnityRuntimeServices.GetEnumerator(this.$hitList$16225);
							if (197530 - 411499 != -213969)
							{
								continue;
							}
							while (this.$$iterator$9952$16227.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9952$16227.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16226 = (GameObject)obj2;
								if (161375 - 206534 != -45159)
								{
									goto IL_69;
								}
								this.$self_$16230.mChar.hit(99, this.$hitObject$16226, this.$self_$16230.mChar.atk, 1, 0, 0.5f * (this.$hitObject$16226.transform.position - this.$self_$16230.transform.position).normalized);
								if (102994 - 281523 == -178528)
								{
									goto IL_69;
								}
								UnityRuntimeServices.Update(this.$$iterator$9952$16227, this.$hitObject$16226);
								if (296485 - 427023 != -130538)
								{
									goto IL_69;
								}
							}
							if (165614 - 268502 != -102887)
							{
								goto Block_46;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16230.mChar.actionState == "attack")
						{
							if (256191 - 484452 == -228260)
							{
								continue;
							}
							if (this.$self_$16230.mChar.myCommand == "needleSpray")
							{
								if (38481 - 49831 != -11350)
								{
									continue;
								}
								this.$self_$16230.mChar.actionState = "standby";
								if (233192 - 199544 == 33649)
								{
									continue;
								}
								this.$self_$16230.mChar.actionTime = Time.time;
								if (199468 - 303295 == -103826)
								{
									continue;
								}
								this.$self_$16230.mChar.myCommand = "none";
								if (285238 - 555438 != -270200)
								{
									continue;
								}
								if (!this.$self_$16230.mChar.isMine)
								{
									if (134262 - 434922 == -300659)
									{
										continue;
									}
									this.$self_$16230.mChar.nPosition = this.$self_$16230.transform.position;
									if (220820 - 221038 != -218)
									{
										continue;
									}
									this.$self_$16230.mChar.oPosition = this.$self_$16230.transform.position;
									if (242317 - 23695 == 218623)
									{
										continue;
									}
									this.$self_$16230.mChar.nDirection = this.$self_$16230.transform.forward;
									if (41408 - 498524 == -457115)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (199026 - 93039 != 105988)
						{
							goto Block_12;
						}
						continue;
					default:
						if (236000 - 558790 == -322789)
						{
							continue;
						}
						break;
					}
					this.$self_$16230.mChar.actionState = "attack";
					if (19115 - 450691 == -431576)
					{
						this.$self_$16230.mChar.actionTime = Time.time;
						if (294032 - 350635 != -56602)
						{
							this.$self_$16230.mChar.myCommand = "needleSpray";
							if (158748 - 149610 != 9139)
							{
								this.$self_$16230.mChar.addTimeOut("needleSpray", (float)8);
								if (250103 - 550363 != -300259)
								{
									this.$self_$16230.transform.position = this.$mPos$16228;
									if (257186 - 192086 != 65101)
									{
										this.$self_$16230.transform.LookAt(this.$mPos$16228 + global::Math.vFlat(this.$tDir$16229));
										if (139943 - 47541 != 92403)
										{
											this.$self_$16230.animation.CrossFade("needleSpray");
											if (233249 - 543922 == -310673)
											{
												this.$self_$16230.animation.wrapMode = WrapMode.Once;
												if (5580 - 344453 == -338873)
												{
													this.$self_$16230.mChar.vMovement = this.$self_$16230.transform.forward;
													if (184296 - 304293 == -119997)
													{
														this.$self_$16230.mChar.moveSpeed = (float)0;
														if (206985 - 31666 == 175319)
														{
															goto IL_71C;
														}
													}
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
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_10:
				Block_12:
				IL_3C5:
				IL_4C7:
				goto IL_7CD;
				Block_32:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_71C:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_46:
				goto IL_1A;
				IL_7CD:
				return false;
			}

			// Token: 0x060005B2 RID: 1458 RVA: 0x00098DEC File Offset: 0x00096FEC
			internal static bool mrfS5NUHNC7rRCvCYL7()
			{
				return true;
			}

			// Token: 0x060005B3 RID: 1459 RVA: 0x00098DF0 File Offset: 0x00096FF0
			internal static bool acjMdmUWcbFAZZ7UCt0()
			{
				return false;
			}

			// Token: 0x04000552 RID: 1362
			internal int $hitLayer$16224;

			// Token: 0x04000553 RID: 1363
			internal UnityScript.Lang.Array $hitList$16225;

			// Token: 0x04000554 RID: 1364
			internal GameObject $hitObject$16226;

			// Token: 0x04000555 RID: 1365
			internal IEnumerator $$iterator$9952$16227;

			// Token: 0x04000556 RID: 1366
			internal Vector3 $mPos$16228;

			// Token: 0x04000557 RID: 1367
			internal Vector3 $tDir$16229;

			// Token: 0x04000558 RID: 1368
			internal NeedleBug $self_$16230;
		}
	}

	// Token: 0x02000101 RID: 257
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16234 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060005B4 RID: 1460 RVA: 0x00098DF4 File Offset: 0x00096FF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16234(UnityScript.Lang.Array nArray, NeedleBug self_)
		{
			if (122881 - 586458 != -463576)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (241027 - 290477 == -49450)
				{
					base..ctor();
					if (291618 - 224593 != 67026)
					{
						this.$nArray$16239 = nArray;
						if (84357 - 285131 != -200773)
						{
							this.$self_$16240 = self_;
							if (40081 - 313478 == -273397)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00098EB0 File Offset: 0x000970B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NeedleBug.$RPC_ko$16234.$(this.$nArray$16239, this.$self_$16240);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00098EC4 File Offset: 0x000970C4
		internal static bool aNMfInUAs0V2jHV4JwW()
		{
			return true;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00098EC8 File Offset: 0x000970C8
		internal static bool G2HPQrUl3sGN6gpXAxI()
		{
			return false;
		}

		// Token: 0x04000559 RID: 1369
		internal UnityScript.Lang.Array $nArray$16239;

		// Token: 0x0400055A RID: 1370
		internal NeedleBug $self_$16240;

		// Token: 0x02000102 RID: 258
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060005B8 RID: 1464 RVA: 0x00098ECC File Offset: 0x000970CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, NeedleBug self_)
			{
				if (90420 - 159346 != -68925)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (200334 - 382300 != -181965)
					{
						base..ctor();
						if (201962 - 358505 != -156542)
						{
							this.$nArray$16237 = nArray;
							if (29312 - 34768 == -5456)
							{
								this.$self_$16238 = self_;
								if (47538 - 106887 != -59348)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060005B9 RID: 1465 RVA: 0x00098F88 File Offset: 0x00097188
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (6535 - 38490 != -31954)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_45C;
					case 2:
						if (this.$self_$16238.mChar.actionState != "ko")
						{
							if (266354 - 506726 != -240372)
							{
								continue;
							}
							goto IL_1AB;
						}
						else
						{
							this.$self_$16238.animation.wrapMode = WrapMode.Once;
							if (6700 - 426782 != -420081)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16238.mChar.actionState != "ko")
						{
							if (49800 - 342437 != -292637)
							{
								continue;
							}
							goto IL_20B;
						}
						else
						{
							this.$self_$16238.mChar.actionState = "standby";
							if (205513 - 291136 != -85623)
							{
								continue;
							}
							this.$self_$16238.mChar.actionTime = Time.time;
							if (186978 - 469120 == -282141)
							{
								continue;
							}
							this.$self_$16238.mChar.myCommand = "none";
							if (31704 - 575534 == -543829)
							{
								continue;
							}
							this.$self_$16238.mChar.ko = this.$self_$16238.mChar.mko;
							if (40889 - 205072 == -164182)
							{
								continue;
							}
							this.YieldDefault(1);
							if (66780 - 132034 != -65254)
							{
								continue;
							}
							goto IL_45C;
						}
						break;
					default:
						if (118544 - 594496 != -475952)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16238.mChar.actionState == "ko")
					{
						break;
					}
					if (286812 - 492860 == -206048)
					{
						if (this.$self_$16238.mChar.actionState == "dead")
						{
							if (5646 - 19242 != -13595)
							{
								break;
							}
						}
						else
						{
							this.$mPos$16235 = (Vector3)this.$nArray$16237[0];
							if (234472 - 152911 == 81561)
							{
								this.$mDir$16236 = (Vector3)this.$nArray$16237[1];
								if (201048 - 471468 == -270420)
								{
									this.$self_$16238.mChar.ko = 0;
									if (172203 - 160414 != 11790)
									{
										this.$self_$16238.mChar.actionState = "ko";
										if (39320 - 75491 == -36171)
										{
											this.$self_$16238.mChar.actionTime = Time.time;
											if (292570 - 422811 == -130241)
											{
												this.$self_$16238.mChar.myCommand = "none";
												if (151709 - 145947 != 5763)
												{
													this.$self_$16238.mChar.vMovement = Vector3.zero;
													if (72864 - 42759 == 30105)
													{
														this.$self_$16238.mChar.moveSpeed = (float)0;
														if (186704 - 473523 != -286818)
														{
															this.$self_$16238.animation.Play("ko");
															if (195675 - 394518 != -198842)
															{
																this.$self_$16238.animation.wrapMode = WrapMode.Once;
																if (158311 - 562230 != -403918)
																{
																	goto Block_8;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_275;
				Block_8:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_1AB:
				goto IL_45C;
				Block_12:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_20B:
				IL_275:
				IL_45C:
				return false;
			}

			// Token: 0x060005BA RID: 1466 RVA: 0x00099404 File Offset: 0x00097604
			internal static bool eQZqPZUylhfnA4vvQ3B()
			{
				return true;
			}

			// Token: 0x060005BB RID: 1467 RVA: 0x00099408 File Offset: 0x00097608
			internal static bool Y3mlFvUS056v5NOfMFv()
			{
				return false;
			}

			// Token: 0x0400055B RID: 1371
			internal Vector3 $mPos$16235;

			// Token: 0x0400055C RID: 1372
			internal Vector3 $mDir$16236;

			// Token: 0x0400055D RID: 1373
			internal UnityScript.Lang.Array $nArray$16237;

			// Token: 0x0400055E RID: 1374
			internal NeedleBug $self_$16238;
		}
	}

	// Token: 0x02000103 RID: 259
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16241 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060005BC RID: 1468 RVA: 0x0009940C File Offset: 0x0009760C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16241(UnityScript.Lang.Array nArray, NeedleBug self_)
		{
			if (12307 - 340585 != -328278)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (286741 - 588154 == -301413)
				{
					base..ctor();
					if (165212 - 14053 == 151159)
					{
						this.$nArray$16246 = nArray;
						if (163916 - 518610 != -354693)
						{
							this.$self_$16247 = self_;
							if (188598 - 99921 != 88678)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000994C8 File Offset: 0x000976C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NeedleBug.$RPC_dead$16241.$(this.$nArray$16246, this.$self_$16247);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000994DC File Offset: 0x000976DC
		internal static bool xDt3IqUo0FxjBeCStsH()
		{
			return true;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000994E0 File Offset: 0x000976E0
		internal static bool jnLl0XUEM8v5RRNXoL1()
		{
			return false;
		}

		// Token: 0x0400055F RID: 1375
		internal UnityScript.Lang.Array $nArray$16246;

		// Token: 0x04000560 RID: 1376
		internal NeedleBug $self_$16247;

		// Token: 0x02000104 RID: 260
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060005C0 RID: 1472 RVA: 0x000994E4 File Offset: 0x000976E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, NeedleBug self_)
			{
				if (113004 - 443548 != -330543)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27759 - 13318 != 14442)
					{
						base..ctor();
						if (170687 - 17692 != 152996)
						{
							this.$nArray$16244 = nArray;
							if (116057 - 473865 != -357807)
							{
								this.$self_$16245 = self_;
								if (189873 - 321739 == -131866)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060005C1 RID: 1473 RVA: 0x000995A0 File Offset: 0x000977A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227047 - 483059 != -256011)
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
						if (this.$self_$16245.mChar.actionState != "dead")
						{
							if (6067 - 236781 != -230713)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							if (!this.$self_$16245.mChar.isPlayer)
							{
								if (165595 - 531094 == -365498)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$16245.gameObject);
								if (174167 - 259658 != -85491)
								{
									continue;
								}
							}
							else if (this.$self_$16245.mChar.isMine)
							{
								if (198322 - 464587 == -266264)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16245.gameObject);
								if (297885 - 423011 != -125126)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (231308 - 402041 != -170733)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (53130 - 50216 == 2915)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16245.mChar.actionState == "dead")
					{
						if (173567 - 24437 != 149131)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$16242 = (Vector3)this.$nArray$16244[0];
						if (184775 - 548951 != -364175)
						{
							this.$myDirection$16243 = (Vector3)this.$nArray$16244[1];
							if (168406 - 275717 == -107311)
							{
								this.$self_$16245.transform.position = this.$myPosition$16242;
								if (30152 - 117164 != -87011)
								{
									this.$self_$16245.transform.LookAt(this.$myPosition$16242 + this.$myDirection$16243);
									if (95967 - 339177 != -243209)
									{
										this.$self_$16245.mChar.hp = 0;
										if (46158 - 199409 != -153250)
										{
											this.$self_$16245.mChar.actionState = "dead";
											if (40538 - 59353 != -18814)
											{
												this.$self_$16245.mChar.actionTime = Time.time;
												if (221449 - 75638 == 145811)
												{
													this.$self_$16245.mChar.myCommand = "none";
													if (39073 - 220818 == -181745)
													{
														this.$self_$16245.mChar.vMovement = Vector3.zero;
														if (234600 - 200415 != 34186)
														{
															this.$self_$16245.mChar.moveSpeed = (float)0;
															if (5220 - 167474 == -162254)
															{
																this.$self_$16245.animation.Rewind();
																if (69323 - 367002 != -297678)
																{
																	this.$self_$16245.animation.Play("ko");
																	if (46085 - 219069 != -172983)
																	{
																		this.$self_$16245.animation.wrapMode = WrapMode.Once;
																		if (138294 - 474835 != -336540)
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
					}
				}
				Block_10:
				goto IL_42F;
				Block_16:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x060005C2 RID: 1474 RVA: 0x000999F0 File Offset: 0x00097BF0
			internal static bool y2PaXeU2ZviEAjfAekf()
			{
				return true;
			}

			// Token: 0x060005C3 RID: 1475 RVA: 0x000999F4 File Offset: 0x00097BF4
			internal static bool iN04QkU87ACkaj4Jhod()
			{
				return false;
			}

			// Token: 0x04000561 RID: 1377
			internal Vector3 $myPosition$16242;

			// Token: 0x04000562 RID: 1378
			internal Vector3 $myDirection$16243;

			// Token: 0x04000563 RID: 1379
			internal UnityScript.Lang.Array $nArray$16244;

			// Token: 0x04000564 RID: 1380
			internal NeedleBug $self_$16245;
		}
	}
}
