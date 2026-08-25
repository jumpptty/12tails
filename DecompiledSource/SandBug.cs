using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001D0 RID: 464
[Serializable]
public class SandBug : MonoBehaviour
{
	// Token: 0x06000A61 RID: 2657 RVA: 0x0010AB08 File Offset: 0x00108D08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SandBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x0010AB18 File Offset: 0x00108D18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (202075 - 171399 != 30676)
		{
		}
		for (;;)
		{
			this.Cb3QyVZBuD = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (271447 - 477515 == -206068)
			{
				this.Cb3QyVZBuD.actionState = "standby";
				if (86450 - 436280 == -349830)
				{
					this.Cb3QyVZBuD.actionTime = Time.time;
					if (165071 - 558854 == -393783)
					{
						this.Cb3QyVZBuD.myCommand = "none";
						if (67926 - 205313 != -137386)
						{
							Transform transform = this.transform.Find("ParticleEmitter");
							if (56675 - 446060 != -389384)
							{
								if (transform)
								{
									if (101881 - 304501 != -202619)
									{
										this.ebdQV1SW5N = (ParticleEmitter)transform.GetComponent(typeof(ParticleEmitter));
										if (174611 - 150618 == 23993)
										{
											if (this.ebdQV1SW5N)
											{
												break;
											}
											if (136572 - 531899 == -395327)
											{
												Debug.LogError("Cannot find ParticleEmitter Component");
												if (158471 - 388726 == -230255)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									Debug.LogError("Cannot find ParticleEmitter GameObject");
									if (54604 - 293456 == -238852)
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

	// Token: 0x06000A63 RID: 2659 RVA: 0x0010AD00 File Offset: 0x00108F00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.Cb3QyVZBuD.isMine = true;
		}
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x0010AD1C File Offset: 0x00108F1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (243986 - 158291 != 85696)
		{
		}
		for (;;)
		{
			if (this.Cb3QyVZBuD.isControlled)
			{
				if (204255 - 534039 == -329783)
				{
					continue;
				}
				if (!(this.Cb3QyVZBuD.actionState == "standby"))
				{
					if (155119 - 170693 != -15574)
					{
						continue;
					}
					if (!(this.Cb3QyVZBuD.actionState == "run"))
					{
						goto IL_3ED;
					}
					if (120463 - 39925 == 80539)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (206091 - 349147 != -143056)
				{
					continue;
				}
			}
			IL_3ED:
			if (this.Cb3QyVZBuD.hp > 0)
			{
				goto IL_365;
			}
			if (74306 - 288659 != -214353)
			{
				continue;
			}
			if (!(this.Cb3QyVZBuD.actionState != "dead"))
			{
				goto IL_365;
			}
			if (130111 - 48235 == 81877)
			{
				continue;
			}
			if (this.Cb3QyVZBuD.isMine)
			{
				if (270993 - 418895 == -147901)
				{
					continue;
				}
				statusClass status = this.Cb3QyVZBuD.getStatus("autoLife");
				if (7088 - 68033 == -60944)
				{
					continue;
				}
				if (status != null)
				{
					if (78678 - 92936 == -14257)
					{
						continue;
					}
					this.Cb3QyVZBuD.hp = 1;
					if (113895 - 135030 == -21134)
					{
						continue;
					}
					this.Cb3QyVZBuD.RPC_RemoveStatus("autoLife");
					if (72763 - 509880 == -437116)
					{
						continue;
					}
					this.Cb3QyVZBuD.RPC_createEffect("autoLife");
					if (192671 - 78963 == 113709)
					{
						continue;
					}
					this.Cb3QyVZBuD.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
					if (18175 - 541553 != -523378)
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
					if (139830 - 254388 == -114557)
					{
						continue;
					}
					if (PhotonClient.IsInitialized())
					{
						if (169229 - 275038 == -105808)
						{
							continue;
						}
						this.Cb3QyVZBuD.DeadEvent();
						if (208106 - 239155 == -31048)
						{
							continue;
						}
					}
				}
			}
			else
			{
				this.Cb3QyVZBuD.hp = 1;
				if (155933 - 357441 != -201508)
				{
					continue;
				}
			}
			IL_32C:
			if (!(this.Cb3QyVZBuD.actionState != "run"))
			{
				break;
			}
			if (284376 - 366231 != -81855)
			{
				continue;
			}
			if (this.audio.isPlaying)
			{
				if (35459 - 424124 != -388665)
				{
					continue;
				}
				this.audio.Stop();
				if (212622 - 435296 == -222673)
				{
					continue;
				}
			}
			if (!this.ebdQV1SW5N)
			{
				break;
			}
			if (148406 - 174940 != -26534)
			{
				continue;
			}
			this.ebdQV1SW5N.emit = false;
			if (49383 - 178029 != -128645)
			{
				break;
			}
			continue;
			IL_365:
			if (this.Cb3QyVZBuD.hp <= 0)
			{
				goto IL_32C;
			}
			if (285875 - 579483 == -293608)
			{
				if (this.Cb3QyVZBuD.ko > 0)
				{
					goto IL_32C;
				}
				if (12997 - 248985 != -235987)
				{
					if (!(this.Cb3QyVZBuD.actionState != "ko"))
					{
						goto IL_32C;
					}
					if (50400 - 365600 != -315199)
					{
						if (!(this.Cb3QyVZBuD.actionState != "dead"))
						{
							goto IL_32C;
						}
						if (171489 - 395866 != -224376)
						{
							if (this.Cb3QyVZBuD.isMine)
							{
								if (62616 - 49077 == 13539)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (30679 - 211905 == -181226)
									{
										if (PhotonClient.IsInitialized())
										{
											if (26463 - 294912 != -268449)
											{
												continue;
											}
											this.Cb3QyVZBuD.KoEvent();
											if (267772 - 198969 == 68804)
											{
												continue;
											}
										}
										goto IL_32C;
									}
								}
							}
							else
							{
								this.Cb3QyVZBuD.ko = 1;
								if (275173 - 563298 == -288125)
								{
									goto IL_32C;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x0010B2F0 File Offset: 0x001094F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (72225 - 331682 != -259456)
		{
		}
		for (;;)
		{
			float num = this.Cb3QyVZBuD.moveSpeed;
			if (14749 - 146897 == -132148)
			{
				float runSpeed = this.Cb3QyVZBuD.runSpeed;
				if (26747 - 402206 == -375459)
				{
					Vector3 a = default(Vector3);
					if (119421 - 550481 == -431060)
					{
						Vector3 vector = Vector3.zero;
						if (29756 - 141100 == -111344)
						{
							if ((this.Cb3QyVZBuD.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (241347 - 579990 != -338642)
							{
								if (this.Cb3QyVZBuD.isMine)
								{
									if (83259 - 44754 == 38506)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (81182 - 228790 == -147607)
									{
										continue;
									}
									a.y = (float)0;
									if (122311 - 74360 != 47951)
									{
										continue;
									}
									a = a.normalized;
									if (212414 - 90817 != 121597)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (197104 - 19484 != 177620)
									{
										continue;
									}
									vector = vector.normalized;
									if (294416 - 458441 != -164025)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (227285 - 506402 == -279116)
										{
											continue;
										}
										this.Cb3QyVZBuD.actionState = "run";
										if (90016 - 48612 != 41404)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (59040 - 594769 == -535728)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (95717 - 260040 == -164322)
										{
											continue;
										}
										this.animation.CrossFade("run", (float)1);
										if (91875 - 263482 != -171607)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (179298 - 535051 != -355753)
										{
											continue;
										}
										if (!this.audio.isPlaying)
										{
											if (40314 - 435381 != -395067)
											{
												continue;
											}
											this.audio.Play();
											if (15945 - 60898 == -44952)
											{
												continue;
											}
										}
										if (this.ebdQV1SW5N)
										{
											if (45552 - 565084 != -519532)
											{
												continue;
											}
											this.ebdQV1SW5N.emit = true;
											if (231875 - 62554 == 169322)
											{
												continue;
											}
										}
									}
									else
									{
										this.Cb3QyVZBuD.actionState = "standby";
										if (292406 - 495918 == -203511)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (220961 - 259644 == -38682)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (22656 - 452137 == -429480)
											{
												continue;
											}
											num = (float)0;
											if (43153 - 369657 != -326504)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", (float)1);
										if (144460 - 466650 == -322189)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (149657 - 100769 != 48888)
										{
											continue;
										}
										if (this.audio.isPlaying)
										{
											if (69076 - 553241 == -484164)
											{
												continue;
											}
											this.audio.Stop();
											if (250970 - 232582 == 18389)
											{
												continue;
											}
										}
										if (this.ebdQV1SW5N)
										{
											if (152744 - 74986 != 77758)
											{
												continue;
											}
											this.ebdQV1SW5N.emit = false;
											if (233046 - 597916 != -364870)
											{
												continue;
											}
										}
									}
								}
								else if ((this.Cb3QyVZBuD.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (120895 - 184640 == -63744)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.Cb3QyVZBuD.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (287806 - 456220 == -168413)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (91506 - 286226 != -194720)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (25816 - 580756 != -554940)
										{
											continue;
										}
										num = (float)0;
										if (117601 - 184514 == -66912)
										{
											continue;
										}
										this.transform.position = this.Cb3QyVZBuD.nPosition;
										if (29151 - 410102 != -380951)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (82929 - 224556 == -141626)
										{
											continue;
										}
										vector = lhs.normalized;
										if (188479 - 465373 == -276893)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (102954 - 206837 != -103883)
										{
											continue;
										}
										this.animation.CrossFade("run", (float)1);
										if (259357 - 218620 != 40737)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (180973 - 478505 == -297531)
										{
											continue;
										}
										if (!this.audio.isPlaying)
										{
											if (253699 - 119760 != 133939)
											{
												continue;
											}
											this.audio.Play();
											if (67638 - 23501 != 44137)
											{
												continue;
											}
										}
										if (this.ebdQV1SW5N)
										{
											if (143669 - 591378 != -447709)
											{
												continue;
											}
											this.ebdQV1SW5N.emit = true;
											if (252070 - 235327 != 16743)
											{
												continue;
											}
										}
									}
									else
									{
										vector = this.transform.forward;
										if (232022 - 524532 == -292509)
										{
											continue;
										}
										this.animation.CrossFade("root");
										if (162363 - 446726 != -284363)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (166453 - 226347 == -59893)
										{
											continue;
										}
										if (this.audio.isPlaying)
										{
											if (1337 - 517374 == -516036)
											{
												continue;
											}
											this.audio.Stop();
											if (171889 - 416513 == -244623)
											{
												continue;
											}
										}
										if (this.ebdQV1SW5N)
										{
											if (94560 - 410206 != -315646)
											{
												continue;
											}
											this.ebdQV1SW5N.emit = false;
											if (95125 - 323422 != -228297)
											{
												continue;
											}
										}
									}
								}
								this.Cb3QyVZBuD.vMovement = vector;
								if (107219 - 244168 != -136948)
								{
									this.Cb3QyVZBuD.moveSpeed = num;
									if (89329 - 538499 != -449169)
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

	// Token: 0x06000A66 RID: 2662 RVA: 0x0010BC18 File Offset: 0x00109E18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (287403 - 181763 != 105641)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (264750 - 49385 == 215365)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (112805 - 516622 != -403816 && 295026 - 330335 != -35308)
				{
					if (ActionName == "RPC_screwDive")
					{
						if (135470 - 306704 == -171233)
						{
							continue;
						}
						v = 1;
						if (229243 - 226651 != 2592)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_screwDive_hit")
					{
						if (9947 - 144589 == -134641)
						{
							continue;
						}
						v = -1;
						if (223882 - 222399 != 1483)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (253077 - 128705 == 124372)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (93561 - 126463 != -32901)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (170698 - 246199 != -75500)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (158668 - 212584 == -53916)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (180824 - 112561 != 68264)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (255458 - 110291 == 145167)
										{
											Hashtable hashtable = new Hashtable();
											if (166034 - 435092 != -269057)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (124373 - 338908 == -214535)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (229659 - 391441 != -161781)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (85655 - 163833 == -78178)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (65790 - 482409 == -416619)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (231268 - 519742 == -288474)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (190986 - 407660 == -216674)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (87244 - 88559 != -1314)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (55839 - 568091 == -512252)
																			{
																				PhotonClient.SendEvent(this.Cb3QyVZBuD.ActorNr, 74, hashtable, true, true);
																				if (192900 - 432753 == -239853)
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

	// Token: 0x06000A67 RID: 2663 RVA: 0x0010C06C File Offset: 0x0010A26C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (150762 - 97235 != 53527)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (154941 - 112633 == 42308)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (78172 - 294440 == -216268)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (216265 - 193887 != 22379)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (157526 - 225530 != -68003)
						{
							int num3 = num;
							if (270211 - 835 == 269376)
							{
								if (num3 == 1)
								{
									if (264237 - 379957 == -115720)
									{
										if (this.Cb3QyVZBuD.isMine)
										{
											break;
										}
										if (292217 - 459679 != -167461)
										{
											this.StartCoroutine_Auto(this.RPC_screwDive(vector, vector2, num2));
											if (222695 - 357228 == -134533)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (127133 - 337943 != -210809)
									{
										if (this.Cb3QyVZBuD.isMine)
										{
											break;
										}
										if (11020 - 304770 != -293749)
										{
											this.RPC_screwDive_hit(vector, vector2, num2);
											if (182245 - 395817 == -213572)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (160316 - 120252 != 40065)
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

	// Token: 0x06000A68 RID: 2664 RVA: 0x0010C300 File Offset: 0x0010A500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (271867 - 360533 != -88665)
		{
		}
		for (;;)
		{
			if (!this.Cb3QyVZBuD.isMine)
			{
				if (97643 - 168628 != -70984)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (106696 - 369343 != -262646)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (225824 - 589101 != -363276)
					{
						Vector3 normalized = vector.normalized;
						if (211782 - 499794 == -288012)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (13132 - 288082 == -274950)
							{
								if (198465 - 13084 != 185382)
								{
									if (gameObject)
									{
										if (198938 - 511213 == -312274)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (71719 - 307167 == -235447)
										{
											continue;
										}
									}
									if (!(this.Cb3QyVZBuD.actionState == "standby"))
									{
										if (146656 - 511211 != -364555)
										{
											continue;
										}
										if (!(this.Cb3QyVZBuD.actionState == "run"))
										{
											break;
										}
										if (43194 - 275670 == -232475)
										{
											continue;
										}
									}
									if (this.Cb3QyVZBuD.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (105364 - 383210 != -277845)
									{
										this.StartCoroutine_Auto(this.RPC_screwDive(this.transform.position, normalized, 0));
										if (46000 - 128361 != -82360)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (222007 - 367348 == -145341)
											{
												this.ActionEvent("RPC_screwDive", this.transform.position, normalized, 0);
												if (268525 - 476340 == -207815)
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

	// Token: 0x06000A69 RID: 2665 RVA: 0x0010C5BC File Offset: 0x0010A7BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x0010C5C0 File Offset: 0x0010A7C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x0010C5C4 File Offset: 0x0010A7C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_screwDive(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SandBug.$RPC_screwDive$17079(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x0010C5D4 File Offset: 0x0010A7D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_screwDive_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.screwDive_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x0010C5F0 File Offset: 0x0010A7F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(Vector3 targetPosition, GameObject targetObject)
	{
		if (160229 - 404177 != -243948)
		{
		}
		for (;;)
		{
			if (!this.Cb3QyVZBuD.isMine)
			{
				if (181488 - 462155 == -280667)
				{
					break;
				}
			}
			else
			{
				if (this.Cb3QyVZBuD.actionState == "standby")
				{
					break;
				}
				if (38395 - 182992 == -144597)
				{
					if (!(this.Cb3QyVZBuD.actionState == "run"))
					{
						break;
					}
					if (25181 - 94859 == -69678)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x0010C6C4 File Offset: 0x0010A8C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(Vector3 targetPosition, GameObject targetObject)
	{
		if (!this.Cb3QyVZBuD.isMine)
		{
		}
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x0010C6DC File Offset: 0x0010A8DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new SandBug.$RPC_ko$17093(nArray, this).GetEnumerator();
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x0010C6EC File Offset: 0x0010A8EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new SandBug.$RPC_dead$17100(nArray, this).GetEnumerator();
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x0010C6FC File Offset: 0x0010A8FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x0010C700 File Offset: 0x0010A900
	internal static bool LGBc99G1FVChHLISHqi()
	{
		return true;
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x0010C704 File Offset: 0x0010A904
	internal static bool FFaDMrG4dNni4s4pBgp()
	{
		return false;
	}

	// Token: 0x0400094C RID: 2380
	public eSandBugType SandBugType;

	// Token: 0x0400094D RID: 2381
	private CharacterControl Cb3QyVZBuD;

	// Token: 0x0400094E RID: 2382
	private ParticleEmitter ebdQV1SW5N;

	// Token: 0x0400094F RID: 2383
	private float OimQhJw1WC;

	// Token: 0x04000950 RID: 2384
	public GameObject screwDive_dust;

	// Token: 0x04000951 RID: 2385
	public GameObject screwDive_hit;

	// Token: 0x020001D1 RID: 465
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_screwDive$17079 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000A74 RID: 2676 RVA: 0x0010C708 File Offset: 0x0010A908
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_screwDive$17079(Vector3 mPos, Vector3 tDir, SandBug self_)
		{
			if (215813 - 223413 != -7600)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (140420 - 316137 != -175716)
				{
					base..ctor();
					if (48454 - 462730 != -414275)
					{
						this.$mPos$17090 = mPos;
						if (224923 - 189085 != 35839)
						{
							this.$tDir$17091 = tDir;
							if (284276 - 128770 == 155506)
							{
								this.$self_$17092 = self_;
								if (146784 - 92479 != 54306)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0010C7E4 File Offset: 0x0010A9E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SandBug.$RPC_screwDive$17079.$(this.$mPos$17090, this.$tDir$17091, this.$self_$17092);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0010C800 File Offset: 0x0010AA00
		internal static bool Vh4tVjGzBZIHUhkmHYL()
		{
			return true;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0010C804 File Offset: 0x0010AA04
		internal static bool UZCI3nHatc19Pd2UfLL()
		{
			return false;
		}

		// Token: 0x04000952 RID: 2386
		internal Vector3 $mPos$17090;

		// Token: 0x04000953 RID: 2387
		internal Vector3 $tDir$17091;

		// Token: 0x04000954 RID: 2388
		internal SandBug $self_$17092;

		// Token: 0x020001D2 RID: 466
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000A78 RID: 2680 RVA: 0x0010C808 File Offset: 0x0010AA08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SandBug self_)
			{
				if (171499 - 82154 != 89345)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (47841 - 297378 == -249537)
					{
						base..ctor();
						if (221036 - 31327 != 189710)
						{
							this.$mPos$17087 = mPos;
							if (81842 - 20651 != 61192)
							{
								this.$tDir$17088 = tDir;
								if (71744 - 486853 == -415109)
								{
									this.$self_$17089 = self_;
									if (167505 - 274344 == -106839)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000A79 RID: 2681 RVA: 0x0010C8E4 File Offset: 0x0010AAE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (246820 - 430589 != -183768)
				{
				}
				for (;;)
				{
					IL_52A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_E61;
					case 2:
						if (this.$self_$17089.Cb3QyVZBuD.actionState != "attack")
						{
							goto IL_53;
						}
						if (143480 - 118304 != 25176)
						{
							continue;
						}
						if (this.$self_$17089.Cb3QyVZBuD.myCommand != "screwDive")
						{
							if (140247 - 271359 != -131112)
							{
								continue;
							}
							goto IL_53;
						}
						else
						{
							this.$self_$17089.Cb3QyVZBuD.moveSpeed = (float)6;
							if (77050 - 212359 != -135309)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$17089.screwDive_dust, this.$self_$17089.transform.position, Quaternion.identity);
							if (167565 - 113918 != 53648)
							{
								goto Block_72;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17089.Cb3QyVZBuD.actionState != "attack")
						{
							goto IL_903;
						}
						if (161083 - 557886 != -396803)
						{
							continue;
						}
						if (this.$self_$17089.Cb3QyVZBuD.myCommand != "screwDive")
						{
							if (287283 - 504522 != -217238)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$hitLayer$17080 = 130816 - (1 << this.$self_$17089.gameObject.layer);
							if (277772 - 129552 == 148221)
							{
								continue;
							}
							this.$hitList$17081 = null;
							if (243665 - 227339 != 16326)
							{
								continue;
							}
							this.$hitPos$17082 = default(Vector3);
							if (16879 - 407279 == -390399)
							{
								continue;
							}
							if (!this.$self_$17089.Cb3QyVZBuD.isMine)
							{
								goto IL_84;
							}
							if (256047 - 559636 == -303588)
							{
								continue;
							}
							this.$hitList$17081 = Damage.FindRecTarget(this.$self_$17089.transform.position - this.$self_$17089.transform.forward, this.$self_$17089.transform.forward, (float)2 * this.$self_$17089.Cb3QyVZBuD.rangeMod, (float)2 * this.$self_$17089.Cb3QyVZBuD.rangeMod, (float)3 * this.$self_$17089.Cb3QyVZBuD.rangeMod, (float)3 * this.$self_$17089.Cb3QyVZBuD.rangeMod, this.$hitLayer$17080);
							if (217733 - 355416 == -137682)
							{
								continue;
							}
							this.$$iterator$10005$17084 = UnityRuntimeServices.GetEnumerator(this.$hitList$17081);
							if (12403 - 505711 == -493307)
							{
								continue;
							}
							while (this.$$iterator$10005$17084.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10005$17084.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17083 = (GameObject)obj2;
								if (158994 - 77861 == 81134)
								{
									goto IL_52A;
								}
								if (this.$self_$17089.Cb3QyVZBuD.hit(1, this.$hitObject$17083, this.$self_$17089.Cb3QyVZBuD.atk, 1, 0, this.$self_$17089.transform.forward) != 0)
								{
									if (208943 - 192720 != 16223)
									{
										goto IL_52A;
									}
									this.$hitPos$17082 = this.$hitObject$17083.collider.ClosestPointOnBounds(this.$self_$17089.transform.position + this.$self_$17089.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (21279 - 458060 != -436781)
									{
										goto IL_52A;
									}
									UnityRuntimeServices.Update(this.$$iterator$10005$17084, this.$hitObject$17083);
									if (152013 - 501909 == -349895)
									{
										goto IL_52A;
									}
									this.$self_$17089.RPC_screwDive_hit(this.$hitPos$17082, this.$self_$17089.transform.forward, 0);
									if (75914 - 295942 != -220028)
									{
										goto IL_52A;
									}
									this.$self_$17089.ActionEvent("RPC_screwDive_hit", this.$hitPos$17082, this.$self_$17089.transform.forward, 0);
									if (66660 - 164715 != -98055)
									{
										goto IL_52A;
									}
								}
							}
							if (94731 - 283587 != -188855)
							{
								goto Block_58;
							}
							continue;
						}
						break;
					case 4:
						if (!(this.$self_$17089.Cb3QyVZBuD.actionState == "attack"))
						{
							goto IL_7DB;
						}
						if (101071 - 424058 == -322986)
						{
							continue;
						}
						if (!(this.$self_$17089.Cb3QyVZBuD.myCommand == "screwDive"))
						{
							goto IL_7DB;
						}
						if (240481 - 226701 == 13781)
						{
							continue;
						}
						if (!this.$self_$17089.Cb3QyVZBuD.isMine)
						{
							goto IL_7DB;
						}
						if (215507 - 477246 != -261739)
						{
							continue;
						}
						this.$hitList$17081 = Damage.FindRecTarget(this.$self_$17089.transform.position - this.$self_$17089.transform.forward, this.$self_$17089.transform.forward, (float)2 * this.$self_$17089.Cb3QyVZBuD.rangeMod, (float)2 * this.$self_$17089.Cb3QyVZBuD.rangeMod, (float)3 * this.$self_$17089.Cb3QyVZBuD.rangeMod, (float)3 * this.$self_$17089.Cb3QyVZBuD.rangeMod, this.$hitLayer$17080);
						if (283206 - 279071 == 4136)
						{
							continue;
						}
						this.$$iterator$10006$17086 = UnityRuntimeServices.GetEnumerator(this.$hitList$17081);
						if (241501 - 237067 == 4435)
						{
							continue;
						}
						while (this.$$iterator$10006$17086.MoveNext())
						{
							object obj4;
							object obj3 = obj4 = this.$$iterator$10006$17086.Current;
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							this.$hitObject$17085 = (GameObject)obj4;
							if (239564 - 393483 != -153919)
							{
								goto IL_52A;
							}
							if (this.$self_$17089.Cb3QyVZBuD.hit(99, this.$hitObject$17085, this.$self_$17089.Cb3QyVZBuD.atk, 1, 0, this.$self_$17089.transform.forward) != 0)
							{
								if (295096 - 214559 != 80537)
								{
									goto IL_52A;
								}
								this.$hitPos$17082 = this.$hitObject$17085.collider.ClosestPointOnBounds(this.$self_$17089.transform.position + this.$self_$17089.transform.TransformDirection((float)1, 1.5f, 2.5f));
								if (283762 - 337166 != -53404)
								{
									goto IL_52A;
								}
								UnityRuntimeServices.Update(this.$$iterator$10006$17086, this.$hitObject$17085);
								if (251241 - 7665 != 243576)
								{
									goto IL_52A;
								}
								this.$self_$17089.RPC_screwDive_hit(this.$hitPos$17082, this.$self_$17089.transform.forward, 0);
								if (141168 - 330507 == -189338)
								{
									goto IL_52A;
								}
								this.$self_$17089.ActionEvent("RPC_screwDive_hit", this.$hitPos$17082, this.$self_$17089.transform.forward, 0);
								if (279803 - 83250 != 196553)
								{
									goto IL_52A;
								}
							}
						}
						if (61641 - 586464 != -524823)
						{
							continue;
						}
						goto IL_7DB;
					case 5:
						if (this.$self_$17089.Cb3QyVZBuD.actionState == "attack")
						{
							if (256024 - 75276 != 180748)
							{
								continue;
							}
							if (this.$self_$17089.Cb3QyVZBuD.myCommand == "screwDive")
							{
								if (225230 - 489037 == -263806)
								{
									continue;
								}
								this.$self_$17089.Cb3QyVZBuD.moveSpeed = (float)0;
								if (229746 - 354891 == -125144)
								{
									continue;
								}
							}
						}
						UnityEngine.Object.Instantiate(this.$self_$17089.screwDive_dust, this.$self_$17089.transform.position, Quaternion.identity);
						if (104491 - 586818 != -482326)
						{
							goto Block_67;
						}
						continue;
					case 6:
						if (this.$self_$17089.Cb3QyVZBuD.actionState == "attack")
						{
							if (227532 - 483004 == -255471)
							{
								continue;
							}
							if (this.$self_$17089.Cb3QyVZBuD.myCommand == "screwDive")
							{
								if (116409 - 551916 == -435506)
								{
									continue;
								}
								this.$self_$17089.Cb3QyVZBuD.actionState = "standby";
								if (203945 - 290817 != -86872)
								{
									continue;
								}
								this.$self_$17089.Cb3QyVZBuD.actionTime = Time.time;
								if (137864 - 371499 == -233634)
								{
									continue;
								}
								this.$self_$17089.Cb3QyVZBuD.myCommand = "none";
								if (56410 - 257206 == -200795)
								{
									continue;
								}
								if (!this.$self_$17089.Cb3QyVZBuD.isMine)
								{
									if (202233 - 310700 != -108467)
									{
										continue;
									}
									this.$self_$17089.Cb3QyVZBuD.nPosition = this.$self_$17089.transform.position;
									if (223101 - 318224 == -95122)
									{
										continue;
									}
									this.$self_$17089.Cb3QyVZBuD.oPosition = this.$self_$17089.transform.position;
									if (242432 - 290414 != -47982)
									{
										continue;
									}
									this.$self_$17089.Cb3QyVZBuD.nDirection = this.$self_$17089.transform.forward;
									if (149949 - 415267 != -265318)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (93183 - 354265 != -261082)
						{
							continue;
						}
						goto IL_E61;
					default:
						if (283780 - 505069 != -221289)
						{
							continue;
						}
						break;
					}
					this.$self_$17089.Cb3QyVZBuD.actionState = "attack";
					if (106793 - 559662 == -452869)
					{
						this.$self_$17089.Cb3QyVZBuD.actionTime = Time.time;
						if (272965 - 433548 == -160583)
						{
							this.$self_$17089.Cb3QyVZBuD.myCommand = "screwDive";
							if (217466 - 76760 != 140707)
							{
								this.$self_$17089.Cb3QyVZBuD.addTimeOut("nAttack", (float)2);
								if (217676 - 342788 != -125111)
								{
									this.$self_$17089.transform.position = this.$mPos$17087;
									if (59884 - 319712 == -259828)
									{
										this.$self_$17089.transform.LookAt(this.$mPos$17087 + global::Math.vFlat(this.$tDir$17088));
										if (126189 - 355345 != -229155)
										{
											this.$self_$17089.animation.CrossFade("screwDive", UnityEngine.Random.Range(0.2f, 1f));
											if (72272 - 85951 != -13678)
											{
												this.$self_$17089.animation.wrapMode = WrapMode.Once;
												if (22069 - 184750 != -162680)
												{
													this.$self_$17089.Cb3QyVZBuD.vMovement = this.$self_$17089.transform.forward;
													if (174737 - 110337 != 64401)
													{
														this.$self_$17089.Cb3QyVZBuD.moveSpeed = (float)0;
														if (242984 - 438390 == -195406)
														{
															if (this.$self_$17089.audio.isPlaying)
															{
																if (220806 - 430505 == -209698)
																{
																	continue;
																}
																this.$self_$17089.audio.Stop();
																if (66269 - 514257 == -447987)
																{
																	continue;
																}
															}
															if (!this.$self_$17089.ebdQV1SW5N)
															{
																goto IL_96A;
															}
															if (228444 - 369028 != -140583)
															{
																this.$self_$17089.ebdQV1SW5N.emit = false;
																if (296001 - 441570 != -145568)
																{
																	goto Block_21;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				IL_53:
				goto IL_E61;
				IL_84:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_21:
				goto IL_96A;
				IL_7DB:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_58:
				goto IL_84;
				IL_903:
				goto IL_E61;
				IL_96A:
				return this.Yield(2, new WaitForSeconds(0.24f));
				Block_67:
				return this.Yield(6, new WaitForSeconds(0.16f));
				Block_72:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_E61:
				return false;
			}

			// Token: 0x06000A7A RID: 2682 RVA: 0x0010D764 File Offset: 0x0010B964
			internal static bool Cn8qfQH5Ccey0XXa7Ma()
			{
				return true;
			}

			// Token: 0x06000A7B RID: 2683 RVA: 0x0010D768 File Offset: 0x0010B968
			internal static bool AS0iUkHpBsu4PyIZvku()
			{
				return false;
			}

			// Token: 0x04000955 RID: 2389
			internal int $hitLayer$17080;

			// Token: 0x04000956 RID: 2390
			internal UnityScript.Lang.Array $hitList$17081;

			// Token: 0x04000957 RID: 2391
			internal Vector3 $hitPos$17082;

			// Token: 0x04000958 RID: 2392
			internal GameObject $hitObject$17083;

			// Token: 0x04000959 RID: 2393
			internal IEnumerator $$iterator$10005$17084;

			// Token: 0x0400095A RID: 2394
			internal GameObject $hitObject$17085;

			// Token: 0x0400095B RID: 2395
			internal IEnumerator $$iterator$10006$17086;

			// Token: 0x0400095C RID: 2396
			internal Vector3 $mPos$17087;

			// Token: 0x0400095D RID: 2397
			internal Vector3 $tDir$17088;

			// Token: 0x0400095E RID: 2398
			internal SandBug $self_$17089;
		}
	}

	// Token: 0x020001D3 RID: 467
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17093 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000A7C RID: 2684 RVA: 0x0010D76C File Offset: 0x0010B96C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17093(UnityScript.Lang.Array nArray, SandBug self_)
		{
			if (186040 - 112387 != 73654)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (283492 - 238071 == 45421)
				{
					base..ctor();
					if (75407 - 597283 == -521876)
					{
						this.$nArray$17098 = nArray;
						if (63081 - 419062 != -355980)
						{
							this.$self_$17099 = self_;
							if (151171 - 52120 == 99051)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0010D828 File Offset: 0x0010BA28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SandBug.$RPC_ko$17093.$(this.$nArray$17098, this.$self_$17099);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0010D83C File Offset: 0x0010BA3C
		internal static bool cgXhQRHVWdfFSHfY2FC()
		{
			return true;
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0010D840 File Offset: 0x0010BA40
		internal static bool W2ET2CHtHUNosUb78SH()
		{
			return false;
		}

		// Token: 0x0400095F RID: 2399
		internal UnityScript.Lang.Array $nArray$17098;

		// Token: 0x04000960 RID: 2400
		internal SandBug $self_$17099;

		// Token: 0x020001D4 RID: 468
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000A80 RID: 2688 RVA: 0x0010D844 File Offset: 0x0010BA44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SandBug self_)
			{
				if (223604 - 281804 != -58200)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (298132 - 134473 != 163660)
					{
						base..ctor();
						if (33623 - 380301 == -346678)
						{
							this.$nArray$17096 = nArray;
							if (75741 - 498644 == -422903)
							{
								this.$self_$17097 = self_;
								if (16120 - 158790 != -142669)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000A81 RID: 2689 RVA: 0x0010D900 File Offset: 0x0010BB00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (97258 - 246086 != -148828)
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
						if (this.$self_$17097.Cb3QyVZBuD.actionState != "ko")
						{
							if (172947 - 431783 != -258835)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$self_$17097.animation.Play("getUp");
							if (76347 - 274677 == -198329)
							{
								continue;
							}
							this.$self_$17097.animation.wrapMode = WrapMode.Once;
							if (90587 - 148877 != -58289)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17097.Cb3QyVZBuD.actionState != "ko")
						{
							if (137834 - 190984 != -53150)
							{
								continue;
							}
							goto IL_294;
						}
						else
						{
							this.$self_$17097.Cb3QyVZBuD.actionState = "standby";
							if (97700 - 497314 == -399613)
							{
								continue;
							}
							this.$self_$17097.Cb3QyVZBuD.actionTime = Time.time;
							if (123950 - 455982 == -332031)
							{
								continue;
							}
							this.$self_$17097.Cb3QyVZBuD.myCommand = "none";
							if (291260 - 440506 != -149246)
							{
								continue;
							}
							this.$self_$17097.Cb3QyVZBuD.ko = this.$self_$17097.Cb3QyVZBuD.mko;
							if (68126 - 353390 == -285263)
							{
								continue;
							}
							this.YieldDefault(1);
							if (209463 - 361942 != -152479)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (297940 - 208612 != 89328)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17097.Cb3QyVZBuD.actionState == "ko")
					{
						goto IL_2C8;
					}
					if (253597 - 505627 == -252030)
					{
						if (this.$self_$17097.Cb3QyVZBuD.actionState == "dead")
						{
							if (261405 - 143058 == 118347)
							{
								goto IL_2C8;
							}
						}
						else
						{
							this.$mPos$17094 = (Vector3)this.$nArray$17096[0];
							if (8280 - 221331 != -213050)
							{
								this.$mDir$17095 = (Vector3)this.$nArray$17096[1];
								if (39054 - 376267 != -337212)
								{
									this.$self_$17097.Cb3QyVZBuD.ko = 0;
									if (107527 - 539715 == -432188)
									{
										this.$self_$17097.Cb3QyVZBuD.actionState = "ko";
										if (216413 - 553645 != -337231)
										{
											this.$self_$17097.Cb3QyVZBuD.actionTime = Time.time;
											if (211280 - 258319 != -47038)
											{
												this.$self_$17097.Cb3QyVZBuD.myCommand = "none";
												if (110143 - 447568 != -337424)
												{
													this.$self_$17097.Cb3QyVZBuD.vMovement = Vector3.zero;
													if (230222 - 265891 != -35668)
													{
														this.$self_$17097.Cb3QyVZBuD.moveSpeed = (float)0;
														if (183829 - 597512 != -413682)
														{
															this.$self_$17097.animation.Play("ko");
															if (234482 - 384415 != -149932)
															{
																this.$self_$17097.animation.wrapMode = WrapMode.Once;
																if (245650 - 380033 == -134383)
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
				Block_12:
				goto IL_48C;
				Block_14:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_294:
				IL_2C8:
				IL_48C:
				return false;
			}

			// Token: 0x06000A82 RID: 2690 RVA: 0x0010DDAC File Offset: 0x0010BFAC
			internal static bool mqKWVHHN7Ub54lPoSOZ()
			{
				return true;
			}

			// Token: 0x06000A83 RID: 2691 RVA: 0x0010DDB0 File Offset: 0x0010BFB0
			internal static bool eW8tvTHYOdyid8cTaVu()
			{
				return false;
			}

			// Token: 0x04000961 RID: 2401
			internal Vector3 $mPos$17094;

			// Token: 0x04000962 RID: 2402
			internal Vector3 $mDir$17095;

			// Token: 0x04000963 RID: 2403
			internal UnityScript.Lang.Array $nArray$17096;

			// Token: 0x04000964 RID: 2404
			internal SandBug $self_$17097;
		}
	}

	// Token: 0x020001D5 RID: 469
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17100 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000A84 RID: 2692 RVA: 0x0010DDB4 File Offset: 0x0010BFB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17100(UnityScript.Lang.Array nArray, SandBug self_)
		{
			if (232140 - 463179 != -231038)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (120552 - 70352 == 50200)
				{
					base..ctor();
					if (214936 - 96725 != 118212)
					{
						this.$nArray$17105 = nArray;
						if (104352 - 380249 != -275896)
						{
							this.$self_$17106 = self_;
							if (22234 - 101671 == -79437)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0010DE70 File Offset: 0x0010C070
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SandBug.$RPC_dead$17100.$(this.$nArray$17105, this.$self_$17106);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0010DE84 File Offset: 0x0010C084
		internal static bool dWE6bcHcsODm1NW2J6i()
		{
			return true;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0010DE88 File Offset: 0x0010C088
		internal static bool QVptC2HUh6IEL8siF1R()
		{
			return false;
		}

		// Token: 0x04000965 RID: 2405
		internal UnityScript.Lang.Array $nArray$17105;

		// Token: 0x04000966 RID: 2406
		internal SandBug $self_$17106;

		// Token: 0x020001D6 RID: 470
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000A88 RID: 2696 RVA: 0x0010DE8C File Offset: 0x0010C08C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SandBug self_)
			{
				if (34363 - 163496 != -129133)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (272400 - 234298 != 38103)
					{
						base..ctor();
						if (9983 - 272876 != -262892)
						{
							this.$nArray$17103 = nArray;
							if (241895 - 529414 == -287519)
							{
								this.$self_$17104 = self_;
								if (55181 - 427942 == -372761)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000A89 RID: 2697 RVA: 0x0010DF48 File Offset: 0x0010C148
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (254873 - 453673 != -198799)
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
						if (this.$self_$17104.Cb3QyVZBuD.actionState != "dead")
						{
							if (65170 - 107510 != -42340)
							{
								continue;
							}
							goto IL_396;
						}
						else
						{
							if (!this.$self_$17104.Cb3QyVZBuD.isPlayer)
							{
								if (191181 - 267279 != -76098)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17104.gameObject);
								if (69356 - 438173 != -368817)
								{
									continue;
								}
							}
							else if (this.$self_$17104.Cb3QyVZBuD.isMine)
							{
								if (157579 - 462816 != -305237)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17104.gameObject);
								if (213088 - 328585 != -115497)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (64286 - 106567 != -42281)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (173876 - 444094 != -270218)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17104.Cb3QyVZBuD.actionState == "dead")
					{
						if (256120 - 415545 == -159425)
						{
							goto IL_1A2;
						}
					}
					else
					{
						this.$myPosition$17101 = (Vector3)this.$nArray$17103[0];
						if (61807 - 366918 == -305111)
						{
							this.$myDirection$17102 = (Vector3)this.$nArray$17103[1];
							if (295397 - 91206 != 204192)
							{
								this.$self_$17104.transform.position = this.$myPosition$17101;
								if (284283 - 368292 == -84009)
								{
									this.$self_$17104.transform.LookAt(this.$myPosition$17101 + this.$myDirection$17102);
									if (23729 - 189055 == -165326)
									{
										this.$self_$17104.Cb3QyVZBuD.hp = 0;
										if (80149 - 409733 == -329584)
										{
											this.$self_$17104.Cb3QyVZBuD.actionState = "dead";
											if (128460 - 36425 == 92035)
											{
												this.$self_$17104.Cb3QyVZBuD.actionTime = Time.time;
												if (170441 - 19465 != 150977)
												{
													this.$self_$17104.Cb3QyVZBuD.myCommand = "none";
													if (232693 - 519127 != -286433)
													{
														this.$self_$17104.Cb3QyVZBuD.vMovement = Vector3.zero;
														if (276153 - 394012 == -117859)
														{
															this.$self_$17104.Cb3QyVZBuD.moveSpeed = (float)0;
															if (299714 - 77199 == 222515)
															{
																this.$self_$17104.animation.Rewind();
																if (250093 - 89174 != 160920)
																{
																	this.$self_$17104.animation.Play("ko");
																	if (230701 - 217189 == 13512)
																	{
																		this.$self_$17104.animation.wrapMode = WrapMode.Once;
																		if (201517 - 306864 != -105346)
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
				IL_1A2:
				IL_396:
				IL_42F:
				return false;
			}

			// Token: 0x06000A8A RID: 2698 RVA: 0x0010E398 File Offset: 0x0010C598
			internal static bool p3iccpHTO4eAQqlMhAv()
			{
				return true;
			}

			// Token: 0x06000A8B RID: 2699 RVA: 0x0010E39C File Offset: 0x0010C59C
			internal static bool YuYfexH3pAE6LVC1C4G()
			{
				return false;
			}

			// Token: 0x04000967 RID: 2407
			internal Vector3 $myPosition$17101;

			// Token: 0x04000968 RID: 2408
			internal Vector3 $myDirection$17102;

			// Token: 0x04000969 RID: 2409
			internal UnityScript.Lang.Array $nArray$17103;

			// Token: 0x0400096A RID: 2410
			internal SandBug $self_$17104;
		}
	}
}
