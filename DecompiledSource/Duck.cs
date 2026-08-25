using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C14 RID: 3092
[Serializable]
public class Duck : MonoBehaviour
{
	// Token: 0x0600451F RID: 17695 RVA: 0x008AA134 File Offset: 0x008A8334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Duck()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004520 RID: 17696 RVA: 0x008AA144 File Offset: 0x008A8344
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (130086 - 533623 != -403536)
		{
		}
		for (;;)
		{
			this.AVwhDokFwp = this.transform;
			if (63642 - 205761 != -142118)
			{
				this.snxhmW07ij = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (152209 - 454592 == -302383)
				{
					this.snxhmW07ij.actionState = "standby";
					if (1063 - 350924 == -349861)
					{
						this.snxhmW07ij.actionTime = Time.time;
						if (263253 - 380492 == -117239)
						{
							this.snxhmW07ij.myCommand = "none";
							if (147495 - 431286 == -283791)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (78669 - 508083 == -429414)
								{
									this.snxhmW07ij.isMine = true;
									if (248201 - 367180 != -118978)
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

	// Token: 0x06004521 RID: 17697 RVA: 0x008AA2A4 File Offset: 0x008A84A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (246668 - 175484 != 71184)
		{
		}
		for (;;)
		{
			if (this.snxhmW07ij.isControlled)
			{
				if (5019 - 139903 != -134884)
				{
					continue;
				}
				if (!(this.snxhmW07ij.actionState == "standby"))
				{
					if (179898 - 507036 != -327138)
					{
						continue;
					}
					if (!(this.snxhmW07ij.actionState == "run"))
					{
						goto IL_FA;
					}
					if (82621 - 462862 == -380240)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (221519 - 591314 != -369795)
				{
					continue;
				}
			}
			IL_FA:
			if (this.snxhmW07ij.hp <= 0)
			{
				if (227218 - 152566 != 74652)
				{
					continue;
				}
				if (this.snxhmW07ij.actionState != "dead")
				{
					if (218600 - 220738 != -2138)
					{
						continue;
					}
					if (this.snxhmW07ij.isMine)
					{
						if (211039 - 150174 != 60865)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (262255 - 506676 == -244420)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (58680 - 435568 == -376887)
						{
							continue;
						}
						this.snxhmW07ij.DeadEvent();
						if (245914 - 272141 != -26226)
						{
							break;
						}
						continue;
					}
					else
					{
						this.snxhmW07ij.hp = 1;
						if (11640 - 72891 != -61250)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.snxhmW07ij.hp <= 0)
			{
				break;
			}
			if (45833 - 209414 == -163581)
			{
				if (this.snxhmW07ij.ko > 0)
				{
					break;
				}
				if (62343 - 565243 == -502900)
				{
					if (!(this.snxhmW07ij.actionState != "ko"))
					{
						break;
					}
					if (137677 - 508451 != -370773)
					{
						if (!(this.snxhmW07ij.actionState != "dead"))
						{
							break;
						}
						if (3462 - 353742 != -350279)
						{
							if (this.snxhmW07ij.isMine)
							{
								if (40999 - 308380 == -267381)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (74039 - 597435 != -523395)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (281510 - 447906 == -166396)
										{
											this.snxhmW07ij.KoEvent();
											if (40078 - 48120 != -8041)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.snxhmW07ij.ko = 1;
								if (176156 - 112378 != 63779)
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

	// Token: 0x06004522 RID: 17698 RVA: 0x008AA69C File Offset: 0x008A889C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (126402 - 257979 != -131576)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (34895 - 339972 != -305076)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (211965 - 374978 != -163012 && 97266 - 538205 != -440938)
				{
					Debug.Log("Unknown Action Name:" + ActionName);
					if (299693 - 404842 == -105149)
					{
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (259792 - 476074 != -216281)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (94433 - 22465 == 71968)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (178608 - 233437 == -54829)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (93642 - 363338 == -269696)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (266945 - 558777 != -291831)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (244423 - 248503 != -4079)
											{
												Hashtable hashtable = new Hashtable();
												if (189437 - 546544 == -357107)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (177068 - 35361 == 141707)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (208565 - 560986 != -352420)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (21661 - 255314 != -233652)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (120671 - 348311 != -227639)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (151740 - 109502 == 42238)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (207333 - 491760 != -284426)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (291777 - 105924 != 185854)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (56881 - 49069 != 7813)
																				{
																					PhotonClient.SendEvent(this.snxhmW07ij.ActorNr, 74, hashtable, true, true);
																					if (115765 - 7195 == 108570)
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

	// Token: 0x06004523 RID: 17699 RVA: 0x008AAA84 File Offset: 0x008A8C84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (114015 - 489215 != -375200)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (165835 - 426072 == -260237)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (90047 - 506477 == -416430)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (28469 - 553936 != -525466)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (19921 - 195368 == -175447)
						{
							if (213103 - 212507 != 597)
							{
								Debug.Log("Unknown Action Code:" + num);
								if (98324 - 108372 == -10048)
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

	// Token: 0x06004524 RID: 17700 RVA: 0x008AAC28 File Offset: 0x008A8E28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (293677 - 136640 != 157037)
		{
		}
		for (;;)
		{
			float num = this.snxhmW07ij.moveSpeed;
			if (56539 - 68487 != -11947)
			{
				float runSpeed = this.snxhmW07ij.runSpeed;
				if (287594 - 143820 != 143775)
				{
					Vector3 a = default(Vector3);
					if (290542 - 180940 == 109602)
					{
						Vector3 vector = Vector3.zero;
						if (121818 - 596055 == -474237)
						{
							float num2 = (float)0;
							if (288180 - 36209 != 251972)
							{
								if (this.snxhmW07ij.isMine)
								{
									if (188314 - 63758 == 124557)
									{
										continue;
									}
									if ((this.snxhmW07ij.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (265279 - 496718 != -231439)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (261018 - 459656 == -198637)
										{
											continue;
										}
										a.y = (float)0;
										if (72261 - 3125 == 69137)
										{
											continue;
										}
										a = a.normalized;
										if (24427 - 243084 == -218656)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (99872 - 305496 != -205624)
										{
											continue;
										}
										vector = vector.normalized;
										if (121542 - 582180 == -460637)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (10240 - 497198 != -486958)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (235577 - 94200 == 141378)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (117406 - 357665 != -240259)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (78980 - 212663 == -133682)
														{
															continue;
														}
														this.snxhmW07ij.actionState = "run";
														if (157152 - 559793 == -402640)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (121824 - 118335 == 3490)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (150409 - 151941 == -1531)
														{
															continue;
														}
														this.animation.Play("run");
														if (26747 - 212968 != -186221)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (145499 - 567454 != -421955)
														{
															continue;
														}
														goto IL_706;
													}
												}
											}
										}
										this.snxhmW07ij.actionState = "standby";
										if (243853 - 549669 == -305815)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (170550 - 572162 != -401612)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (299065 - 87541 == 211525)
											{
												continue;
											}
											num = (float)0;
											if (47279 - 171883 == -124603)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (34104 - 579879 != -545775)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (144911 - 423646 == -278734)
										{
											continue;
										}
									}
									IL_706:;
								}
								else
								{
									vector = global::Math.vFlat(this.snxhmW07ij.nPosition - this.transform.position);
									if (78774 - 290596 == -211821)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (100259 - 494897 != -394638)
									{
										continue;
									}
									if (this.snxhmW07ij.nSpeed != (float)0)
									{
										if (194427 - 374602 == -180174)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (78019 - 406735 == -328715)
											{
												continue;
											}
											this.transform.position = this.snxhmW07ij.nPosition;
											if (65214 - 544198 != -478984)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (244475 - 503488 == -259012)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (74142 - 66834 != 7308)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (197322 - 412552 == -215229)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.snxhmW07ij.nSpeed, (float)10 * Time.deltaTime);
												if (247743 - 279555 != -31812)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (170000 - 1700 != 168300)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (259251 - 467480 == -208228)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (65267 - 132755 == -67487)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (219 - 435365 == -435145)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (225504 - 154664 != 70840)
											{
												continue;
											}
										}
										else if (Time.time > this.snxhmW07ij.nSpeed + 0.3f)
										{
											if (63564 - 310648 != -247084)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (67547 - 525951 == -458403)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (140974 - 227052 == -86077)
												{
													continue;
												}
												num = (float)0;
												if (267667 - 596117 != -328450)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.snxhmW07ij.nDirection);
											if (122079 - 476871 != -354792)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (253008 - 508480 != -255472)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (152205 - 234157 != -81952)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (84181 - 474137 == -389955)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (180465 - 267056 != -86591)
											{
												continue;
											}
											this.transform.position = this.snxhmW07ij.nPosition;
											if (35577 - 295621 != -260044)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (172648 - 255645 != -82997)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (117761 - 248481 == -130719)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (22611 - 369847 != -347236)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (132482 - 146046 != -13564)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (119735 - 291873 != -172138)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (258829 - 522204 != -263375)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (110289 - 267774 != -157485)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.snxhmW07ij.nDirection);
											if (148734 - 472393 != -323659)
											{
												continue;
											}
											num = (float)0;
											if (152840 - 378517 != -225677)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (222742 - 220837 == 1906)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (64626 - 74255 != -9629)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (106578 - 155859 != -49281)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (120115 - 397146 == -277030)
										{
											continue;
										}
									}
								}
								this.snxhmW07ij.vMovement = vector;
								if (206002 - 123999 != 82004)
								{
									this.snxhmW07ij.moveSpeed = num;
									if (137487 - 324528 != -187040)
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

	// Token: 0x06004525 RID: 17701 RVA: 0x008AB78C File Offset: 0x008A998C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (148987 - 508050 != -359063)
		{
		}
		for (;;)
		{
			if (!this.snxhmW07ij.isMine)
			{
				if (221818 - 499563 == -277745)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (77072 - 425847 != -348774)
				{
					Vector3 vector = a - this.transform.position;
					if (99374 - 114332 != -14957)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (168859 - 377346 != -208486)
						{
							CharacterControl characterControl = null;
							if (173825 - 439258 == -265433)
							{
								if (267251 - 499492 != -232240)
								{
									if (gameObject)
									{
										if (120968 - 554717 == -433748)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (112387 - 577318 != -464931)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (195059 - 455222 == -260162)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (141181 - 157506 != -16325)
										{
											continue;
										}
									}
									if (!(this.snxhmW07ij.actionState == "standby"))
									{
										if (101017 - 532425 == -431407)
										{
											continue;
										}
										if (!(this.snxhmW07ij.actionState == "run"))
										{
											break;
										}
										if (278753 - 89730 == 189024)
										{
											continue;
										}
									}
									if (this.snxhmW07ij.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (290591 - 558741 == -268150)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
										if (214697 - 316079 == -101382)
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

	// Token: 0x06004526 RID: 17702 RVA: 0x008ABA30 File Offset: 0x008A9C30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (236118 - 330807 != -94688)
		{
		}
		for (;;)
		{
			if (!this.snxhmW07ij.isMine)
			{
				if (153654 - 407446 != -253791)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (61620 - 159904 != -98283)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (162429 - 55267 != 107163)
					{
						Vector3 normalized = vector.normalized;
						if (35026 - 181820 == -146794)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (171571 - 344749 == -173178)
							{
								CharacterControl characterControl = null;
								if (67211 - 547953 != -480741 && 285715 - 70610 == 215105)
								{
									if (gameObject)
									{
										if (124444 - 534382 != -409938)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (294513 - 65198 != 229315)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (167904 - 596000 != -428096)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (244628 - 236050 == 8579)
										{
											continue;
										}
									}
									if (!(this.snxhmW07ij.actionState == "standby"))
									{
										if (185864 - 186376 != -512)
										{
											continue;
										}
										if (!(this.snxhmW07ij.actionState == "run"))
										{
											break;
										}
										if (215708 - 569608 != -353900)
										{
											continue;
										}
									}
									if (this.snxhmW07ij.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (35850 - 122023 == -86173)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
										if (91180 - 558049 == -466869)
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

	// Token: 0x06004527 RID: 17703 RVA: 0x008ABCFC File Offset: 0x008A9EFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004528 RID: 17704 RVA: 0x008ABD00 File Offset: 0x008A9F00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Duck.$RPC_ko$31887(nArray, this).GetEnumerator();
	}

	// Token: 0x06004529 RID: 17705 RVA: 0x008ABD10 File Offset: 0x008A9F10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Duck.$RPC_dead$31894(nArray, this).GetEnumerator();
	}

	// Token: 0x0600452A RID: 17706 RVA: 0x008ABD20 File Offset: 0x008A9F20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600452B RID: 17707 RVA: 0x008ABD24 File Offset: 0x008A9F24
	internal static bool MiEEqs5iq0mUE8oyXa7w()
	{
		return true;
	}

	// Token: 0x0600452C RID: 17708 RVA: 0x008ABD28 File Offset: 0x008A9F28
	internal static bool LgFd9r5i7sRXWkKP5OTi()
	{
		return false;
	}

	// Token: 0x040050A6 RID: 20646
	private Transform AVwhDokFwp;

	// Token: 0x040050A7 RID: 20647
	private CharacterControl snxhmW07ij;

	// Token: 0x02000C15 RID: 3093
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31887 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600452D RID: 17709 RVA: 0x008ABD2C File Offset: 0x008A9F2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31887(UnityScript.Lang.Array nArray, Duck self_)
		{
			if (27797 - 579546 != -551749)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (142126 - 406551 == -264425)
				{
					base..ctor();
					if (88708 - 269832 != -181123)
					{
						this.$nArray$31892 = nArray;
						if (85593 - 355966 != -270372)
						{
							this.$self_$31893 = self_;
							if (43503 - 144729 == -101226)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x008ABDE8 File Offset: 0x008A9FE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Duck.$RPC_ko$31887.$(this.$nArray$31892, this.$self_$31893);
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x008ABDFC File Offset: 0x008A9FFC
		internal static bool RCBBjb5iP0KSScMLOkHT()
		{
			return true;
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x008ABE00 File Offset: 0x008AA000
		internal static bool BYHLwA5i0MWHHdwc7pJb()
		{
			return false;
		}

		// Token: 0x040050A8 RID: 20648
		internal UnityScript.Lang.Array $nArray$31892;

		// Token: 0x040050A9 RID: 20649
		internal Duck $self_$31893;

		// Token: 0x02000C16 RID: 3094
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004531 RID: 17713 RVA: 0x008ABE04 File Offset: 0x008AA004
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Duck self_)
			{
				if (43133 - 200031 != -156897)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246678 - 307773 != -61094)
					{
						base..ctor();
						if (132897 - 222251 != -89353)
						{
							this.$nArray$31890 = nArray;
							if (177616 - 506355 != -328738)
							{
								this.$self_$31891 = self_;
								if (165660 - 369955 != -204294)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004532 RID: 17714 RVA: 0x008ABEC0 File Offset: 0x008AA0C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (240545 - 33130 != 207415)
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
						if (this.$self_$31891.snxhmW07ij.actionState != "ko")
						{
							if (277941 - 386717 != -108776)
							{
								continue;
							}
							goto IL_AB;
						}
						else
						{
							this.$self_$31891.animation.Play("getUp");
							if (258136 - 213938 == 44199)
							{
								continue;
							}
							this.$self_$31891.animation.wrapMode = WrapMode.Once;
							if (260734 - 125923 != 134812)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31891.snxhmW07ij.actionState != "ko")
						{
							if (6162 - 97762 != -91599)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$31891.snxhmW07ij.actionState = "standby";
							if (14548 - 60500 != -45952)
							{
								continue;
							}
							this.$self_$31891.snxhmW07ij.actionTime = Time.time;
							if (20974 - 180555 != -159581)
							{
								continue;
							}
							this.$self_$31891.snxhmW07ij.myCommand = "none";
							if (266595 - 519427 != -252832)
							{
								continue;
							}
							this.$self_$31891.snxhmW07ij.ko = this.$self_$31891.snxhmW07ij.mko;
							if (134615 - 237695 != -103080)
							{
								continue;
							}
							this.YieldDefault(1);
							if (259039 - 202131 != 56909)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					default:
						if (206549 - 230386 != -23837)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31891.snxhmW07ij.actionState == "ko")
					{
						break;
					}
					if (77789 - 582081 != -504291)
					{
						if (this.$self_$31891.snxhmW07ij.actionState == "dead")
						{
							if (271030 - 410139 == -139109)
							{
								break;
							}
						}
						else
						{
							this.$mPos$31888 = (Vector3)this.$nArray$31890[0];
							if (97033 - 322148 == -225115)
							{
								this.$mDir$31889 = (Vector3)this.$nArray$31890[1];
								if (175716 - 411548 == -235832)
								{
									this.$self_$31891.snxhmW07ij.ko = 0;
									if (86219 - 194247 == -108028)
									{
										this.$self_$31891.snxhmW07ij.actionState = "ko";
										if (135627 - 404563 != -268935)
										{
											this.$self_$31891.snxhmW07ij.actionTime = Time.time;
											if (89859 - 518406 == -428547)
											{
												this.$self_$31891.snxhmW07ij.myCommand = "none";
												if (254638 - 536718 == -282080)
												{
													this.$self_$31891.snxhmW07ij.vMovement = Vector3.zero;
													if (37051 - 344424 != -307372)
													{
														this.$self_$31891.snxhmW07ij.moveSpeed = (float)0;
														if (112085 - 411837 == -299752)
														{
															this.$self_$31891.animation.Play("ko");
															if (120708 - 42370 == 78338)
															{
																this.$self_$31891.animation.wrapMode = WrapMode.Once;
																if (47809 - 165407 != -117597)
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
				Block_4:
				IL_AB:
				goto IL_48C;
				Block_8:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_19:
				goto IL_48C;
				Block_27:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_48C:
				return false;
			}

			// Token: 0x06004533 RID: 17715 RVA: 0x008AC36C File Offset: 0x008AA56C
			internal static bool qYQcCQ5ibtxhheKmIbLs()
			{
				return true;
			}

			// Token: 0x06004534 RID: 17716 RVA: 0x008AC370 File Offset: 0x008AA570
			internal static bool N25jZT5iuO6esuHjR15H()
			{
				return false;
			}

			// Token: 0x040050AA RID: 20650
			internal Vector3 $mPos$31888;

			// Token: 0x040050AB RID: 20651
			internal Vector3 $mDir$31889;

			// Token: 0x040050AC RID: 20652
			internal UnityScript.Lang.Array $nArray$31890;

			// Token: 0x040050AD RID: 20653
			internal Duck $self_$31891;
		}
	}

	// Token: 0x02000C17 RID: 3095
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31894 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004535 RID: 17717 RVA: 0x008AC374 File Offset: 0x008AA574
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31894(UnityScript.Lang.Array nArray, Duck self_)
		{
			if (82510 - 116142 != -33632)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (173439 - 347835 != -174395)
				{
					base..ctor();
					if (46331 - 427002 == -380671)
					{
						this.$nArray$31899 = nArray;
						if (289245 - 363368 != -74122)
						{
							this.$self_$31900 = self_;
							if (135070 - 40817 == 94253)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x008AC430 File Offset: 0x008AA630
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Duck.$RPC_dead$31894.$(this.$nArray$31899, this.$self_$31900);
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x008AC444 File Offset: 0x008AA644
		internal static bool UuRbx75iIJWx7xyyGDJ5()
		{
			return true;
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x008AC448 File Offset: 0x008AA648
		internal static bool yWeZyp5iBAqF7kRNPSc7()
		{
			return false;
		}

		// Token: 0x040050AE RID: 20654
		internal UnityScript.Lang.Array $nArray$31899;

		// Token: 0x040050AF RID: 20655
		internal Duck $self_$31900;

		// Token: 0x02000C18 RID: 3096
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004539 RID: 17721 RVA: 0x008AC44C File Offset: 0x008AA64C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Duck self_)
			{
				if (194758 - 598885 != -404126)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (286509 - 522558 == -236049)
					{
						base..ctor();
						if (80569 - 205464 != -124894)
						{
							this.$nArray$31897 = nArray;
							if (79234 - 6280 != 72955)
							{
								this.$self_$31898 = self_;
								if (265639 - 169871 != 95769)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600453A RID: 17722 RVA: 0x008AC508 File Offset: 0x008AA708
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (97255 - 507821 != -410565)
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
						if (this.$self_$31898.snxhmW07ij.actionState != "dead")
						{
							if (22883 - 459116 != -436232)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							if (!this.$self_$31898.snxhmW07ij.isPlayer)
							{
								if (55400 - 13564 == 41837)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$31898.gameObject);
								if (191 - 61921 != -61730)
								{
									continue;
								}
							}
							else if (this.$self_$31898.snxhmW07ij.isMine)
							{
								if (275841 - 385458 == -109616)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31898.gameObject);
								if (97128 - 398740 != -301612)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (198488 - 552746 != -354258)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (88353 - 576942 == -488588)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31898.snxhmW07ij.actionState == "dead")
					{
						if (237930 - 397730 != -159799)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$31895 = (Vector3)this.$nArray$31897[0];
						if (252259 - 213193 != 39067)
						{
							this.$myDirection$31896 = (Vector3)this.$nArray$31897[1];
							if (214041 - 278476 != -64434)
							{
								this.$self_$31898.transform.position = this.$myPosition$31895;
								if (121589 - 598201 == -476612)
								{
									this.$self_$31898.transform.LookAt(this.$myPosition$31895 + this.$myDirection$31896);
									if (11095 - 229844 != -218748)
									{
										this.$self_$31898.snxhmW07ij.hp = 0;
										if (161489 - 145700 != 15790)
										{
											this.$self_$31898.snxhmW07ij.actionState = "dead";
											if (118257 - 307965 == -189708)
											{
												this.$self_$31898.snxhmW07ij.actionTime = Time.time;
												if (182306 - 414877 == -232571)
												{
													this.$self_$31898.snxhmW07ij.myCommand = "none";
													if (242294 - 521697 != -279402)
													{
														this.$self_$31898.snxhmW07ij.vMovement = Vector3.zero;
														if (118179 - 438641 != -320461)
														{
															this.$self_$31898.snxhmW07ij.moveSpeed = (float)0;
															if (166525 - 110826 == 55699)
															{
																this.$self_$31898.animation.Rewind();
																if (35003 - 218884 == -183881)
																{
																	this.$self_$31898.animation.Play("ko");
																	if (274079 - 2822 != 271258)
																	{
																		this.$self_$31898.animation.wrapMode = WrapMode.Once;
																		if (134858 - 351657 != -216798)
																		{
																			goto Block_11;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_42F;
				Block_11:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x0600453B RID: 17723 RVA: 0x008AC958 File Offset: 0x008AAB58
			internal static bool LGPFVY5ie3rH0PcLyJYu()
			{
				return true;
			}

			// Token: 0x0600453C RID: 17724 RVA: 0x008AC95C File Offset: 0x008AAB5C
			internal static bool THEJRW5ir7SQA1LE9jPo()
			{
				return false;
			}

			// Token: 0x040050B0 RID: 20656
			internal Vector3 $myPosition$31895;

			// Token: 0x040050B1 RID: 20657
			internal Vector3 $myDirection$31896;

			// Token: 0x040050B2 RID: 20658
			internal UnityScript.Lang.Array $nArray$31897;

			// Token: 0x040050B3 RID: 20659
			internal Duck $self_$31898;
		}
	}
}
