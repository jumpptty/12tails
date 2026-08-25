using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000EB8 RID: 3768
[Serializable]
public class KingKaiser : MonoBehaviour
{
	// Token: 0x06005572 RID: 21874 RVA: 0x00A5C64C File Offset: 0x00A5A84C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public KingKaiser()
	{
		if (220185 - 143406 != 76780)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (233395 - 221710 != 11686)
			{
				base..ctor();
				if (129596 - 585464 != -455867)
				{
					this.mLv = 1;
					if (106819 - 302290 != -195470)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005573 RID: 21875 RVA: 0x00A5C6E4 File Offset: 0x00A5A8E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (157165 - 26881 != 130284)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (107506 - 130685 != -23178)
			{
				this.mChar.actionState = "standby";
				if (27455 - 388004 == -360549)
				{
					this.mChar.actionTime = Time.time;
					if (190539 - 514688 == -324149)
					{
						this.mChar.myCommand = "none";
						if (161520 - 350459 != -188938)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005574 RID: 21876 RVA: 0x00A5C7D0 File Offset: 0x00A5A9D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06005575 RID: 21877 RVA: 0x00A5C7EC File Offset: 0x00A5A9EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playLeftFootEvent(AnimationEvent animEvent)
	{
		if (this.mChar.isMine)
		{
			this.audio.PlayOneShot(this.footStep_left);
		}
	}

	// Token: 0x06005576 RID: 21878 RVA: 0x00A5C810 File Offset: 0x00A5AA10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRightFootEvent(AnimationEvent animEvent)
	{
		if (this.mChar.isMine)
		{
			this.audio.PlayOneShot(this.footStep_right);
		}
	}

	// Token: 0x06005577 RID: 21879 RVA: 0x00A5C834 File Offset: 0x00A5AA34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (58312 - 367198 != -308885)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (57340 - 48141 != 9199)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (264551 - 379005 != -114454)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_F2;
					}
					if (113796 - 302137 != -188341)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (189189 - 58895 != 130294)
				{
					continue;
				}
			}
			IL_F2:
			if (this.mChar.hp <= 0)
			{
				if (217941 - 337929 != -119988)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (180504 - 570875 != -390371)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (277344 - 169999 == 107346)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (59100 - 323114 == -264013)
						{
							continue;
						}
						if (status != null)
						{
							if (151966 - 467458 != -315492)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (42395 - 472255 != -429860)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (24057 - 214476 != -190419)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (17281 - 78456 == -61174)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (33025 - 552465 != -519439)
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
							if (161641 - 526872 == -365230)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (145945 - 328856 != -182911)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (270 - 108542 != -108271)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (187693 - 285035 != -97342)
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
			if (285242 - 2364 != 282879)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (38858 - 346840 == -307982)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (259924 - 431319 == -171395)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (123119 - 522110 == -398991)
						{
							if (this.mChar.isMine)
							{
								if (53995 - 134515 != -80519)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (128431 - 521301 == -392870)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (113655 - 485964 == -372309)
										{
											this.mChar.KoEvent();
											if (205668 - 103764 != 101905)
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
								if (259649 - 273134 != -13484)
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

	// Token: 0x06005578 RID: 21880 RVA: 0x00A5CD34 File Offset: 0x00A5AF34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (129631 - 354520 != -224888)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (82935 - 515609 == -432674)
			{
				float runSpeed = this.mChar.runSpeed;
				if (257587 - 428685 != -171097)
				{
					Vector3 a = default(Vector3);
					if (157624 - 102181 == 55443)
					{
						Vector3 vector = Vector3.zero;
						if (263783 - 248815 == 14968)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (160746 - 402990 == -242244)
							{
								if (this.mChar.isMine)
								{
									if (264706 - 124456 != 140250)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (41719 - 478215 == -436495)
									{
										continue;
									}
									a.y = (float)0;
									if (109873 - 416635 == -306761)
									{
										continue;
									}
									a = a.normalized;
									if (173155 - 524894 == -351738)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (255875 - 211281 == 44595)
									{
										continue;
									}
									vector = vector.normalized;
									if (19175 - 30858 == -11682)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (14526 - 573527 == -559000)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (238080 - 555257 != -317177)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (125955 - 552964 != -427009)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (64524 - 314338 == -249813)
										{
											continue;
										}
										this.animation.Play("run");
										if (93477 - 11763 == 81715)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (15903 - 225600 == -209696)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (35011 - 302999 == -267987)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (176007 - 322187 != -146180)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (216583 - 386505 == -169921)
											{
												continue;
											}
											num = (float)0;
											if (25518 - 92005 != -66487)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.3f);
										if (285361 - 493305 != -207944)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (14927 - 558780 != -543853)
										{
											continue;
										}
									}
								}
								else
								{
									Vector3 vector2 = this.mChar.nPosition - this.transform.position;
									if (229243 - 89756 != 139487)
									{
										continue;
									}
									if (vector2.magnitude > runSpeed)
									{
										if (103459 - 232746 != -129287)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (179434 - 321028 == -141593)
										{
											continue;
										}
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (67461 - 191086 != -123625)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (162738 - 135534 == 27205)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (134229 - 34058 == 100172)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (48973 - 32163 != 16810)
											{
												continue;
											}
											num = (float)0;
											if (168539 - 572026 == -403486)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (108269 - 219136 == -110866)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (177057 - 500806 == -323748)
											{
												continue;
											}
											vector = lhs.normalized;
											if (228970 - 528971 == -300000)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector);
											if (289535 - 108328 == 181208)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.3f);
											if (30494 - 293701 == -263206)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (100432 - 231539 != -131107)
											{
												continue;
											}
										}
										else
										{
											vector = this.transform.forward;
											if (211420 - 292702 != -81282)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.3f);
											if (236389 - 112723 == 123667)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (88094 - 158405 == -70310)
											{
												continue;
											}
										}
									}
								}
								this.mChar.vMovement = vector;
								if (7131 - 109250 == -102119)
								{
									this.mChar.moveSpeed = num;
									if (30313 - 415663 == -385350)
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

	// Token: 0x06005579 RID: 21881 RVA: 0x00A5D478 File Offset: 0x00A5B678
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (70822 - 505813 != -434991)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (52903 - 250449 != -197545)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (245820 - 514767 != -268946 && 181284 - 245823 != -64538)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (94162 - 207888 != -113726)
						{
							continue;
						}
						v = 1;
						if (52959 - 405530 == -352570)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (165710 - 98137 == 67574)
						{
							continue;
						}
						v = -1;
						if (132121 - 454862 != -322741)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_kaiserMissile")
					{
						if (5248 - 317579 == -312330)
						{
							continue;
						}
						v = 11;
						if (244477 - 18211 != 226266)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_kaiserMissile_hit")
					{
						if (212148 - 369532 != -157384)
						{
							continue;
						}
						v = -11;
						if (151876 - 278463 != -126587)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_kaiserBeam1")
					{
						if (291093 - 398228 != -107135)
						{
							continue;
						}
						v = 21;
						if (207326 - 287975 != -80649)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_kaiserBeam2")
					{
						if (270577 - 33519 != 237058)
						{
							continue;
						}
						v = 22;
						if (40258 - 528056 != -487798)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_kaiserBeam0")
					{
						if (124699 - 368111 != -243412)
						{
							continue;
						}
						v = 23;
						if (73363 - 45100 == 28264)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_unsummon")
					{
						if (39949 - 471037 != -431088)
						{
							continue;
						}
						v = 31;
						if (50901 - 415832 == -364930)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (287747 - 381314 == -93567)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (285113 - 220156 != 64958)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (96282 - 595564 != -499281)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (223308 - 393152 == -169844)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (108963 - 341231 == -232268)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (260768 - 209734 == 51034)
										{
											Hashtable hashtable = new Hashtable();
											if (252380 - 87857 != 164524)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (57246 - 30593 == 26653)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (78213 - 446431 == -368218)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (210614 - 72536 == 138078)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (101668 - 108748 != -7079)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (233776 - 374594 == -140818)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (49533 - 14625 == 34908)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (52996 - 76110 != -23113)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (202992 - 168977 == 34015)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (91210 - 83883 == 7327)
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

	// Token: 0x0600557A RID: 21882 RVA: 0x00A5DA94 File Offset: 0x00A5BC94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (215303 - 207381 != 7923)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (163278 - 570496 == -407218)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (242545 - 525647 != -283101)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (193263 - 407790 != -214526)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (51796 - 524750 != -472953)
						{
							int num3 = num;
							if (225745 - 276429 == -50684)
							{
								if (num3 == 1)
								{
									if (125825 - 444373 == -318548)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (40842 - 448868 != -408025)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (256914 - 93978 == 162936)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (122499 - 261278 == -138779)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (61754 - 72396 == -10642)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (181538 - 143757 == 37781)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (46195 - 566616 != -520420)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (148305 - 13712 != 134594)
										{
											this.StartCoroutine_Auto(this.RPC_kaiserMissile(vector, vector2, num2));
											if (106145 - 174760 == -68615)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (216444 - 293652 == -77208)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (243183 - 529390 == -286207)
										{
											this.RPC_kaiserMissile_hit(vector, vector2, num2);
											if (103444 - 423114 == -319670)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (33884 - 252842 == -218958)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (97125 - 71157 == 25968)
										{
											this.StartCoroutine_Auto(this.RPC_kaiserBeam1(vector, vector2, num2));
											if (130374 - 126823 != 3552)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (198589 - 455074 == -256485)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (126152 - 278629 != -152476)
										{
											this.StartCoroutine_Auto(this.RPC_kaiserBeam2(vector, vector2, num2));
											if (62775 - 256506 == -193731)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 23)
								{
									if (6071 - 444464 != -438392)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (139350 - 4595 != 134756)
										{
											this.StartCoroutine_Auto(this.RPC_kaiserBeam0(vector, vector2, num2));
											if (62716 - 33768 == 28948)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (196272 - 426982 == -230710)
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

	// Token: 0x0600557B RID: 21883 RVA: 0x00A5DF8C File Offset: 0x00A5C18C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (220090 - 70099 != 149992)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (35669 - 509705 != -474035)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (295160 - 236634 == 58526)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (278941 - 532122 != -253180)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (227959 - 38201 != 189759)
						{
							if (gameObject)
							{
								if (934 - 580725 != -579791)
								{
									continue;
								}
								vector = global::Math.vFlat(gameObject.transform.position - this.transform.position);
								if (227615 - 382584 != -154969)
								{
									continue;
								}
							}
							if (!(this.mChar.actionState == "standby"))
							{
								if (127311 - 276160 == -148848)
								{
									continue;
								}
								if (!(this.mChar.actionState == "run"))
								{
									break;
								}
								if (15396 - 293537 == -278140)
								{
									continue;
								}
							}
							if (this.mChar.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (203842 - 436609 == -232767)
							{
								if (this.mLv > 1)
								{
									if (50129 - 52725 == -2595)
									{
										continue;
									}
									if (vector.sqrMagnitude > (float)100)
									{
										if (127839 - 296647 != -168808)
										{
											continue;
										}
										this.StartCoroutine_Auto(this.RPC_kaiserMissile(this.transform.position, vector, 0));
										if (249928 - 34646 != 215282)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (149701 - 309842 != -160141)
										{
											continue;
										}
										this.ActionEvent("RPC_kaiserMissile", this.transform.position, vector, 0);
										if (280883 - 237832 != 43051)
										{
											continue;
										}
										break;
									}
								}
								this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
								if (230089 - 199880 != 30210)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (292946 - 303254 == -10308)
									{
										this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (237960 - 552093 == -314133)
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

	// Token: 0x0600557C RID: 21884 RVA: 0x00A5E2F4 File Offset: 0x00A5C4F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (259139 - 179323 != 79816)
		{
		}
		for (;;)
		{
			if (this.mLv < 3)
			{
				if (91748 - 367050 == -275302)
				{
					Camera.main.SendMessage("newGameMessage", "Need KaiserBeam Upgrade to use charged attack");
					if (204683 - 422413 == -217730)
					{
						break;
					}
				}
			}
			else if (!this.mChar.isMine)
			{
				if (48616 - 471486 == -422870)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (262563 - 99875 == 162688)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (69717 - 422291 == -352574)
					{
						Vector3 normalized = vector.normalized;
						if (163883 - 151714 != 12170)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (118953 - 96191 == 22762)
							{
								if (gameObject)
								{
									if (276677 - 316043 != -39366)
									{
										continue;
									}
									Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
									if (124 - 84589 != -84465)
									{
										continue;
									}
									normalized = vector2.normalized;
									if (151729 - 214824 == -63094)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (298216 - 413409 != -115193)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (54884 - 4760 != 50124)
									{
										continue;
									}
								}
								if (this.mChar.sp < 75)
								{
									if (156321 - 18215 == 138106)
									{
										Camera.main.SendMessage("newGameMessage", "Kaiser Beam needs 75 sp");
										if (248388 - 265217 != -16828)
										{
											break;
										}
									}
								}
								else
								{
									if (this.mChar.actionTime + 0.1f > Time.time)
									{
										break;
									}
									if (258712 - 388881 != -130168)
									{
										this.StartCoroutine_Auto(this.RPC_kaiserBeam1(this.transform.position, normalized, 0));
										if (117193 - 366503 == -249310)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (227264 - 404228 != -176963)
											{
												this.ActionEvent("RPC_kaiserBeam1", this.transform.position, normalized, 0);
												if (160794 - 145106 == 15688)
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

	// Token: 0x0600557D RID: 21885 RVA: 0x00A5E680 File Offset: 0x00A5C880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
		if (58242 - 475890 != -417648)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (37733 - 321845 != -284111)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (214811 - 3141 != 211671)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (14006 - 480223 != -466216)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (219112 - 103728 != 115385)
						{
							if (!(this.mChar.actionState == "attack"))
							{
								break;
							}
							if (271411 - 344812 == -73401)
							{
								if (!(this.mChar.myCommand == "cAttack1"))
								{
									break;
								}
								if (49779 - 64723 == -14944)
								{
									if (this.mChar.actionTime + 6.5f <= Time.time)
									{
										if (248236 - 98778 != 149459)
										{
											this.StartCoroutine_Auto(this.RPC_kaiserBeam2(this.transform.position, this.transform.forward, 0));
											if (217477 - 473489 == -256012)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (89131 - 190561 == -101430)
												{
													this.ActionEvent("RPC_kaiserBeam2", this.transform.position, this.transform.forward, 0);
													if (259268 - 547166 == -287898)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_kaiserBeam0(this.transform.position, this.transform.forward, 0));
										if (251511 - 589662 == -338151)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (95084 - 287668 == -192584)
											{
												this.ActionEvent("RPC_kaiserBeam0", this.transform.position, this.transform.forward, 0);
												if (217614 - 574842 != -357227)
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

	// Token: 0x0600557E RID: 21886 RVA: 0x00A5E964 File Offset: 0x00A5CB64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingKaiser.$RPC_nAttack$34579(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600557F RID: 21887 RVA: 0x00A5E974 File Offset: 0x00A5CB74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (226225 - 530667 != -304441)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (204816 - 121004 == 83812)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (193207 - 142933 == 50274)
					{
						break;
					}
				}
			}
			else
			{
				Debug.Log("Cannot find nAttack_hit");
				if (98969 - 18227 != 80743)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005580 RID: 21888 RVA: 0x00A5EA34 File Offset: 0x00A5CC34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_kaiserMissile(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingKaiser.$RPC_kaiserMissile$34595(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005581 RID: 21889 RVA: 0x00A5EA44 File Offset: 0x00A5CC44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_kaiserMissile_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (33420 - 253156 != -219736)
		{
		}
		for (;;)
		{
			IL_A6:
			if (this.kaiserMissile_hit)
			{
				if (235351 - 570874 == -335522)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.kaiserMissile_hit, hitPos, this.transform.rotation);
				if (237037 - 398090 != -161053)
				{
					continue;
				}
			}
			else
			{
				Debug.Log("Cannot find kaiserMissile_hit");
				if (294804 - 66258 != 228546)
				{
					continue;
				}
			}
			if (!this.mChar.isMine)
			{
				break;
			}
			if (149746 - 8934 != 140813)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (186061 - 384695 != -198633)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)5, (float)5, layerMask);
					if (177284 - 90657 == 86627)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (13096 - 521895 == -508799)
						{
							while (enumerator.MoveNext())
							{
								object obj2 = enumerator.Current;
								object obj4;
								object obj3 = obj4 = obj2;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj4;
								if (107570 - 129283 != -21713)
								{
									goto IL_A6;
								}
								if (this.mChar.hit(21, gameObject, 100, 5, 0, (gameObject.transform.position - hitPos).normalized) != 0)
								{
									if (267170 - 525973 != -258803)
									{
										goto IL_A6;
									}
									this.mChar.sp = this.mChar.sp + 1;
									if (76450 - 154623 != -78173)
									{
										goto IL_A6;
									}
								}
							}
							if (33708 - 438876 == -405168)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005582 RID: 21890 RVA: 0x00A5EC88 File Offset: 0x00A5CE88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_kaiserBeam1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingKaiser.$RPC_kaiserBeam1$34606(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005583 RID: 21891 RVA: 0x00A5EC98 File Offset: 0x00A5CE98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_kaiserBeam2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingKaiser.$RPC_kaiserBeam2$34613(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005584 RID: 21892 RVA: 0x00A5ECA8 File Offset: 0x00A5CEA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_kaiserBeam0(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingKaiser.$RPC_kaiserBeam0$34626(mPos, this).GetEnumerator();
	}

	// Token: 0x06005585 RID: 21893 RVA: 0x00A5ECB8 File Offset: 0x00A5CEB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator summon(int nLv)
	{
		return new KingKaiser.$summon$34631(nLv, this).GetEnumerator();
	}

	// Token: 0x06005586 RID: 21894 RVA: 0x00A5ECC8 File Offset: 0x00A5CEC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator unsummon()
	{
		return new KingKaiser.$unsummon$34636(this).GetEnumerator();
	}

	// Token: 0x06005587 RID: 21895 RVA: 0x00A5ECD8 File Offset: 0x00A5CED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator destroyKaiser()
	{
		return new KingKaiser.$destroyKaiser$34639(this).GetEnumerator();
	}

	// Token: 0x06005588 RID: 21896 RVA: 0x00A5ECE8 File Offset: 0x00A5CEE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new KingKaiser.$RPC_ko$34642(nArray, this).GetEnumerator();
	}

	// Token: 0x06005589 RID: 21897 RVA: 0x00A5ECF8 File Offset: 0x00A5CEF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new KingKaiser.$RPC_dead$34649(nArray, this).GetEnumerator();
	}

	// Token: 0x0600558A RID: 21898 RVA: 0x00A5ED08 File Offset: 0x00A5CF08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600558B RID: 21899 RVA: 0x00A5ED0C File Offset: 0x00A5CF0C
	internal static bool H0dRK851gG1bMMsnCfkW()
	{
		return true;
	}

	// Token: 0x0600558C RID: 21900 RVA: 0x00A5ED10 File Offset: 0x00A5CF10
	internal static bool WZ8sJv51fSDEKgUk9jC0()
	{
		return false;
	}

	// Token: 0x04005E71 RID: 24177
	public CharacterControl mChar;

	// Token: 0x04005E72 RID: 24178
	public int mLv;

	// Token: 0x04005E73 RID: 24179
	public AudioClip footStep_left;

	// Token: 0x04005E74 RID: 24180
	public AudioClip footStep_right;

	// Token: 0x04005E75 RID: 24181
	public GameObject nAttack_hit;

	// Token: 0x04005E76 RID: 24182
	public GameObject kaiserMissile;

	// Token: 0x04005E77 RID: 24183
	public GameObject kaiserMissile_hit;

	// Token: 0x04005E78 RID: 24184
	public GameObject kaiserBeam_charge;

	// Token: 0x04005E79 RID: 24185
	public AudioClip kaiser_openFx;

	// Token: 0x04005E7A RID: 24186
	public GameObject kaiserBeam;

	// Token: 0x04005E7B RID: 24187
	public AudioClip kaiser_createFx;

	// Token: 0x04005E7C RID: 24188
	public GameObject kaiser_box;

	// Token: 0x04005E7D RID: 24189
	public AudioClip kaiser_cryFx;

	// Token: 0x02000EB9 RID: 3769
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$34579 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600558D RID: 21901 RVA: 0x00A5ED14 File Offset: 0x00A5CF14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$34579(Vector3 mPos, Vector3 tDir, KingKaiser self_)
		{
			if (141260 - 365636 != -224375)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (198059 - 310420 != -112360)
				{
					base..ctor();
					if (90188 - 569506 != -479317)
					{
						this.$mPos$34592 = mPos;
						if (19681 - 571542 == -551861)
						{
							this.$tDir$34593 = tDir;
							if (268877 - 396678 == -127801)
							{
								this.$self_$34594 = self_;
								if (200928 - 467989 == -267061)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x00A5EDF0 File Offset: 0x00A5CFF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingKaiser.$RPC_nAttack$34579.$(this.$mPos$34592, this.$tDir$34593, this.$self_$34594);
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x00A5EE0C File Offset: 0x00A5D00C
		internal static bool awNUpO51nv9OrbKA4IO9()
		{
			return true;
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x00A5EE10 File Offset: 0x00A5D010
		internal static bool n0f9H05165XrFnbwK363()
		{
			return false;
		}

		// Token: 0x04005E7E RID: 24190
		internal Vector3 $mPos$34592;

		// Token: 0x04005E7F RID: 24191
		internal Vector3 $tDir$34593;

		// Token: 0x04005E80 RID: 24192
		internal KingKaiser $self_$34594;

		// Token: 0x02000EBA RID: 3770
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005591 RID: 21905 RVA: 0x00A5EE14 File Offset: 0x00A5D014
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, KingKaiser self_)
			{
				if (69219 - 378065 != -308846)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221091 - 29512 != 191580)
					{
						base..ctor();
						if (80895 - 396426 == -315531)
						{
							this.$mPos$34589 = mPos;
							if (187320 - 538718 != -351397)
							{
								this.$tDir$34590 = tDir;
								if (90694 - 52626 != 38069)
								{
									this.$self_$34591 = self_;
									if (156320 - 553050 != -396729)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005592 RID: 21906 RVA: 0x00A5EEF0 File Offset: 0x00A5D0F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (155809 - 197572 != -41762)
				{
				}
				for (;;)
				{
					IL_1102:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1613;
					case 2:
						if (this.$self_$34591.mChar.actionState != "attack")
						{
							goto IL_EA4;
						}
						if (101555 - 319725 != -218170)
						{
							continue;
						}
						if (this.$self_$34591.mChar.myCommand != "nAttack")
						{
							if (288740 - 545845 != -257104)
							{
								goto Block_52;
							}
							continue;
						}
						else
						{
							this.$self_$34591.mChar.moveSpeed = (float)2;
							if (18774 - 465141 != -446366)
							{
								goto Block_82;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34591.mChar.actionState != "attack")
						{
							goto IL_FA;
						}
						if (161227 - 421275 == -260047)
						{
							continue;
						}
						if (this.$self_$34591.mChar.myCommand != "nAttack")
						{
							if (274659 - 462924 != -188265)
							{
								continue;
							}
							goto IL_FA;
						}
						else
						{
							this.$hitLayer$34580 = 130816 - (1 << this.$self_$34591.gameObject.layer);
							if (214478 - 216263 != -1785)
							{
								continue;
							}
							this.$hitList$34581 = null;
							if (205355 - 117860 != 87495)
							{
								continue;
							}
							this.$hitPos$34582 = default(Vector3);
							if (268756 - 395682 == -126925)
							{
								continue;
							}
							if (!this.$self_$34591.mChar.isMine)
							{
								goto IL_1583;
							}
							if (48233 - 286878 != -238645)
							{
								continue;
							}
							this.$hitList$34581 = Damage.FindRecTarget(this.$self_$34591.transform.position + this.$self_$34591.transform.right, this.$self_$34591.transform.forward, (float)2 * this.$self_$34591.mChar.rangeMod, (float)2 * this.$self_$34591.mChar.rangeMod, (float)5 * this.$self_$34591.mChar.rangeMod, (float)3 * this.$self_$34591.mChar.rangeMod, this.$hitLayer$34580);
							if (90573 - 81355 == 9219)
							{
								continue;
							}
							this.$$iterator$9814$34584 = UnityRuntimeServices.GetEnumerator(this.$hitList$34581);
							if (174742 - 321818 == -147075)
							{
								continue;
							}
							while (this.$$iterator$9814$34584.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9814$34584.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34583 = (GameObject)obj2;
								if (28022 - 252303 == -224280)
								{
									goto IL_1102;
								}
								if (this.$self_$34591.mChar.hit(1, this.$hitObject$34583, this.$self_$34591.mChar.atk, 1, 0, (float)2 * this.$self_$34591.transform.forward) != 0)
								{
									if (189271 - 587187 != -397916)
									{
										goto IL_1102;
									}
									this.$self_$34591.mChar.sp = this.$self_$34591.mChar.sp + 1;
									if (180673 - 105839 != 74834)
									{
										goto IL_1102;
									}
									this.$hitPos$34582 = this.$hitObject$34583.collider.ClosestPointOnBounds(this.$self_$34591.transform.position + this.$self_$34591.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (147916 - 303540 != -155624)
									{
										goto IL_1102;
									}
									UnityRuntimeServices.Update(this.$$iterator$9814$34584, this.$hitObject$34583);
									if (238269 - 267188 != -28919)
									{
										goto IL_1102;
									}
									this.$self_$34591.RPC_nAttack_hit(this.$hitPos$34582, this.$self_$34591.transform.forward, 0);
									if (194383 - 589467 != -395084)
									{
										goto IL_1102;
									}
									if (PhotonClient.IsInitialized())
									{
										if (220109 - 525097 != -304988)
										{
											goto IL_1102;
										}
										this.$self_$34591.ActionEvent("RPC_nAttack_hit", this.$hitPos$34582, this.$self_$34591.transform.forward, 0);
										if (240108 - 552494 == -312385)
										{
											goto IL_1102;
										}
									}
								}
							}
							if (272327 - 18737 != 253591)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$34591.mChar.actionState != "attack")
						{
							goto IL_1227;
						}
						if (157856 - 282289 == -124432)
						{
							continue;
						}
						if (this.$self_$34591.mChar.myCommand != "nAttack")
						{
							if (238882 - 558260 != -319378)
							{
								continue;
							}
							goto IL_1227;
						}
						else
						{
							this.$self_$34591.mChar.moveSpeed = (float)0;
							if (161281 - 315368 != -154086)
							{
								goto Block_106;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$34591.mChar.actionState != "attack")
						{
							goto IL_B44;
						}
						if (243813 - 215663 != 28150)
						{
							continue;
						}
						if (this.$self_$34591.mChar.myCommand != "nAttack")
						{
							if (164622 - 119387 != 45235)
							{
								continue;
							}
							goto IL_B44;
						}
						else
						{
							this.$self_$34591.mChar.moveSpeed = (float)3;
							if (153738 - 519502 != -365763)
							{
								goto Block_62;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$34591.mChar.actionState != "attack")
						{
							goto IL_137;
						}
						if (36888 - 59201 == -22312)
						{
							continue;
						}
						if (this.$self_$34591.mChar.myCommand != "nAttack")
						{
							if (179774 - 197758 != -17984)
							{
								continue;
							}
							goto IL_137;
						}
						else
						{
							this.$self_$34591.mChar.moveSpeed = (float)5;
							if (3881 - 508134 != -504252)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					case 7:
						if (this.$self_$34591.mChar.actionState != "attack")
						{
							goto IL_C0F;
						}
						if (118979 - 541561 != -422582)
						{
							continue;
						}
						if (this.$self_$34591.mChar.myCommand != "nAttack")
						{
							if (135545 - 103459 != 32087)
							{
								goto Block_78;
							}
							continue;
						}
						else
						{
							this.$self_$34591.mChar.moveSpeed = (float)2;
							if (188358 - 300278 != -111919)
							{
								goto Block_67;
							}
							continue;
						}
						break;
					case 8:
						if (this.$self_$34591.mChar.actionState != "attack")
						{
							goto IL_130F;
						}
						if (291361 - 312015 != -20654)
						{
							continue;
						}
						if (this.$self_$34591.mChar.myCommand != "nAttack")
						{
							if (208300 - 185541 != 22759)
							{
								continue;
							}
							goto IL_130F;
						}
						else
						{
							if (!this.$self_$34591.mChar.isMine)
							{
								goto IL_1258;
							}
							if (88670 - 587313 != -498643)
							{
								continue;
							}
							this.$hitList$34581 = Damage.FindRecTarget(this.$self_$34591.transform.position, this.$self_$34591.transform.forward, 1.5f * this.$self_$34591.mChar.rangeMod, 1.5f * this.$self_$34591.mChar.rangeMod, (float)4 * this.$self_$34591.mChar.rangeMod, (float)3 * this.$self_$34591.mChar.rangeMod, this.$hitLayer$34580);
							if (18505 - 53283 != -34778)
							{
								continue;
							}
							this.$$iterator$9815$34586 = UnityRuntimeServices.GetEnumerator(this.$hitList$34581);
							if (271364 - 441973 == -170608)
							{
								continue;
							}
							while (this.$$iterator$9815$34586.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9815$34586.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$34585 = (GameObject)obj4;
								if (84165 - 87065 == -2899)
								{
									goto IL_1102;
								}
								if (this.$self_$34591.mChar.hit(2, this.$hitObject$34585, (int)(1.2f * (float)this.$self_$34591.mChar.atk), 1, 0, (float)2 * this.$self_$34591.transform.forward) != 0)
								{
									if (230761 - 45789 == 184973)
									{
										goto IL_1102;
									}
									this.$hitPos$34582 = this.$hitObject$34585.collider.ClosestPointOnBounds(this.$self_$34591.transform.position + this.$self_$34591.transform.TransformDirection(0.2f, (float)2, 2.4f));
									if (133073 - 527168 == -394094)
									{
										goto IL_1102;
									}
									UnityRuntimeServices.Update(this.$$iterator$9815$34586, this.$hitObject$34585);
									if (199271 - 394580 != -195309)
									{
										goto IL_1102;
									}
									this.$self_$34591.RPC_nAttack_hit(this.$hitPos$34582, this.$self_$34591.transform.forward, 0);
									if (289976 - 3755 == 286222)
									{
										goto IL_1102;
									}
									if (PhotonClient.IsInitialized())
									{
										if (277592 - 322284 == -44691)
										{
											goto IL_1102;
										}
										this.$self_$34591.ActionEvent("RPC_nAttack_hit", this.$hitPos$34582, this.$self_$34591.transform.forward, 0);
										if (91044 - 390920 == -299875)
										{
											goto IL_1102;
										}
									}
								}
							}
							if (2174 - 459869 != -457694)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 9:
						if (this.$self_$34591.mChar.actionState != "attack")
						{
							goto IL_303;
						}
						if (134001 - 386189 == -252187)
						{
							continue;
						}
						if (this.$self_$34591.mChar.myCommand != "nAttack")
						{
							if (206572 - 25218 != 181354)
							{
								continue;
							}
							goto IL_303;
						}
						else
						{
							this.$self_$34591.mChar.moveSpeed = (float)0;
							if (91342 - 469126 != -377784)
							{
								continue;
							}
							goto IL_1440;
						}
						break;
					case 10:
						if (this.$self_$34591.mChar.actionState != "attack")
						{
							goto IL_6A;
						}
						if (205426 - 269669 != -64243)
						{
							continue;
						}
						if (this.$self_$34591.mChar.myCommand != "nAttack")
						{
							if (141150 - 426865 != -285715)
							{
								continue;
							}
							goto IL_6A;
						}
						else
						{
							this.$self_$34591.mChar.moveSpeed = (float)2;
							if (128250 - 302733 != -174483)
							{
								continue;
							}
							goto IL_CA7;
						}
						break;
					case 11:
						if (this.$self_$34591.mChar.actionState != "attack")
						{
							goto IL_9B;
						}
						if (180218 - 263524 == -83305)
						{
							continue;
						}
						if (this.$self_$34591.mChar.myCommand != "nAttack")
						{
							if (101035 - 310414 != -209379)
							{
								continue;
							}
							goto IL_9B;
						}
						else
						{
							if (!this.$self_$34591.mChar.isMine)
							{
								goto IL_E18;
							}
							if (294754 - 40135 != 254619)
							{
								continue;
							}
							this.$hitList$34581 = Damage.FindRecTarget(this.$self_$34591.transform.position + this.$self_$34591.transform.TransformDirection((float)-1, 0.5f, (float)-2), this.$self_$34591.transform.forward, 2.5f * this.$self_$34591.mChar.rangeMod, 2.5f * this.$self_$34591.mChar.rangeMod, (float)6 * this.$self_$34591.mChar.rangeMod, (float)2 * this.$self_$34591.mChar.rangeMod, this.$hitLayer$34580);
							if (144189 - 415427 == -271237)
							{
								continue;
							}
							this.$$iterator$9816$34588 = UnityRuntimeServices.GetEnumerator(this.$hitList$34581);
							if (41172 - 33254 == 7919)
							{
								continue;
							}
							while (this.$$iterator$9816$34588.MoveNext())
							{
								object obj6;
								object obj5 = obj6 = this.$$iterator$9816$34588.Current;
								if (!(obj5 is GameObject))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
								}
								this.$hitObject$34587 = (GameObject)obj6;
								if (221982 - 328607 == -106624)
								{
									goto IL_1102;
								}
								if (this.$self_$34591.mChar.hit(3, this.$hitObject$34587, (int)(1.3f * (float)this.$self_$34591.mChar.atk), 1, 0, (float)2 * this.$self_$34591.transform.forward) != 0)
								{
									if (85545 - 345974 == -260428)
									{
										goto IL_1102;
									}
									this.$self_$34591.mChar.sp = this.$self_$34591.mChar.sp + 1;
									if (250490 - 231180 != 19310)
									{
										goto IL_1102;
									}
									this.$hitPos$34582 = this.$hitObject$34587.collider.ClosestPointOnBounds(this.$self_$34591.transform.position + this.$self_$34591.transform.TransformDirection(0.5f, (float)2, (float)3));
									if (288621 - 76908 == 211714)
									{
										goto IL_1102;
									}
									UnityRuntimeServices.Update(this.$$iterator$9816$34588, this.$hitObject$34587);
									if (166796 - 102979 == 63818)
									{
										goto IL_1102;
									}
									this.$self_$34591.RPC_nAttack_hit(this.$hitPos$34582, this.$self_$34591.transform.forward, 0);
									if (130812 - 177108 != -46296)
									{
										goto IL_1102;
									}
									if (PhotonClient.IsInitialized())
									{
										if (263048 - 330906 != -67858)
										{
											goto IL_1102;
										}
										this.$self_$34591.ActionEvent("RPC_nAttack_hit", this.$hitPos$34582, this.$self_$34591.transform.forward, 0);
										if (228286 - 367581 == -139294)
										{
											goto IL_1102;
										}
									}
								}
							}
							if (76942 - 569443 != -492500)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 12:
						if (this.$self_$34591.mChar.actionState != "attack")
						{
							goto IL_AB4;
						}
						if (250631 - 504157 != -253526)
						{
							continue;
						}
						if (this.$self_$34591.mChar.myCommand != "nAttack")
						{
							if (41824 - 29003 != 12821)
							{
								continue;
							}
							goto IL_AB4;
						}
						else
						{
							this.$self_$34591.mChar.moveSpeed = (float)0;
							if (202093 - 27007 != 175087)
							{
								goto Block_59;
							}
							continue;
						}
						break;
					case 13:
						if (this.$self_$34591.mChar.actionState == "attack")
						{
							if (45664 - 47746 != -2082)
							{
								continue;
							}
							if (this.$self_$34591.mChar.myCommand == "nAttack")
							{
								if (85045 - 495718 == -410672)
								{
									continue;
								}
								this.$self_$34591.mChar.actionState = "standby";
								if (150221 - 218835 == -68613)
								{
									continue;
								}
								this.$self_$34591.mChar.actionTime = Time.time;
								if (129174 - 254913 != -125739)
								{
									continue;
								}
								this.$self_$34591.mChar.myCommand = "none";
								if (180363 - 84245 != 96118)
								{
									continue;
								}
								if (!this.$self_$34591.mChar.isMine)
								{
									if (289519 - 96875 == 192645)
									{
										continue;
									}
									this.$self_$34591.mChar.nPosition = this.$self_$34591.transform.position;
									if (169362 - 50258 != 119104)
									{
										continue;
									}
									this.$self_$34591.mChar.oPosition = this.$self_$34591.transform.position;
									if (171413 - 106475 != 64938)
									{
										continue;
									}
									this.$self_$34591.mChar.nDirection = this.$self_$34591.transform.forward;
									if (105695 - 543147 != -437452)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (258009 - 26889 != 231120)
						{
							continue;
						}
						goto IL_1613;
					default:
						if (246908 - 596040 != -349132)
						{
							continue;
						}
						break;
					}
					this.$self_$34591.mChar.actionState = "attack";
					if (288584 - 421878 == -133294)
					{
						this.$self_$34591.mChar.actionTime = Time.time;
						if (204635 - 170129 != 34507)
						{
							this.$self_$34591.mChar.myCommand = "nAttack";
							if (262486 - 327794 == -65308)
							{
								this.$self_$34591.mChar.addTimeOut("nAttack", (float)4);
								if (258584 - 550483 != -291898)
								{
									this.$self_$34591.transform.position = this.$mPos$34589;
									if (212911 - 103516 == 109395)
									{
										this.$self_$34591.transform.LookAt(this.$mPos$34589 + global::Math.vFlat(this.$tDir$34590));
										if (256316 - 56238 != 200079)
										{
											this.$self_$34591.animation.CrossFade("punch");
											if (282449 - 532337 != -249887)
											{
												this.$self_$34591.animation.wrapMode = WrapMode.Once;
												if (12099 - 499660 != -487560)
												{
													this.$self_$34591.mChar.vMovement = this.$self_$34591.transform.forward;
													if (175942 - 9740 != 166203)
													{
														this.$self_$34591.mChar.moveSpeed = (float)0;
														if (147163 - 567530 != -420366)
														{
															goto Block_73;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_6A:
				IL_9B:
				IL_FA:
				IL_137:
				goto IL_1613;
				Block_9:
				return this.Yield(7, new WaitForSeconds(0.1f));
				IL_303:
				goto IL_1613;
				Block_26:
				goto IL_1258;
				Block_35:
				goto IL_1583;
				Block_39:
				goto IL_E18;
				Block_52:
				IL_AB4:
				goto IL_1613;
				Block_59:
				return this.Yield(13, new WaitForSeconds(0.3f));
				IL_B44:
				goto IL_1613;
				Block_62:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_C0F:
				goto IL_1613;
				Block_67:
				return this.Yield(8, new WaitForSeconds(0.1f));
				IL_CA7:
				return this.Yield(11, new WaitForSeconds(0.2f));
				Block_73:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_78:
				goto IL_C0F;
				IL_E18:
				return this.Yield(12, new WaitForSeconds(0.1f));
				IL_EA4:
				goto IL_1613;
				Block_82:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_1227:
				goto IL_1613;
				Block_106:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_1258:
				return this.Yield(9, new WaitForSeconds(0.1f));
				IL_130F:
				goto IL_1613;
				IL_1440:
				return this.Yield(10, new WaitForSeconds(0.4f));
				IL_1583:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_1613:
				return false;
			}

			// Token: 0x06005593 RID: 21907 RVA: 0x00A60524 File Offset: 0x00A5E724
			internal static bool ikUaW451iOkW1JCkxQWd()
			{
				return true;
			}

			// Token: 0x06005594 RID: 21908 RVA: 0x00A60528 File Offset: 0x00A5E728
			internal static bool jvTYUn51K9H5sKgxUqM0()
			{
				return false;
			}

			// Token: 0x04005E81 RID: 24193
			internal int $hitLayer$34580;

			// Token: 0x04005E82 RID: 24194
			internal UnityScript.Lang.Array $hitList$34581;

			// Token: 0x04005E83 RID: 24195
			internal Vector3 $hitPos$34582;

			// Token: 0x04005E84 RID: 24196
			internal GameObject $hitObject$34583;

			// Token: 0x04005E85 RID: 24197
			internal IEnumerator $$iterator$9814$34584;

			// Token: 0x04005E86 RID: 24198
			internal GameObject $hitObject$34585;

			// Token: 0x04005E87 RID: 24199
			internal IEnumerator $$iterator$9815$34586;

			// Token: 0x04005E88 RID: 24200
			internal GameObject $hitObject$34587;

			// Token: 0x04005E89 RID: 24201
			internal IEnumerator $$iterator$9816$34588;

			// Token: 0x04005E8A RID: 24202
			internal Vector3 $mPos$34589;

			// Token: 0x04005E8B RID: 24203
			internal Vector3 $tDir$34590;

			// Token: 0x04005E8C RID: 24204
			internal KingKaiser $self_$34591;
		}
	}

	// Token: 0x02000EBB RID: 3771
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_kaiserMissile$34595 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005595 RID: 21909 RVA: 0x00A6052C File Offset: 0x00A5E72C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_kaiserMissile$34595(Vector3 mPos, Vector3 tDir, KingKaiser self_)
		{
			if (60380 - 118512 != -58132)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217688 - 435589 == -217901)
				{
					base..ctor();
					if (253710 - 276713 != -23002)
					{
						this.$mPos$34603 = mPos;
						if (279624 - 470519 != -190894)
						{
							this.$tDir$34604 = tDir;
							if (146918 - 275291 != -128372)
							{
								this.$self_$34605 = self_;
								if (79114 - 469988 == -390874)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x00A60608 File Offset: 0x00A5E808
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingKaiser.$RPC_kaiserMissile$34595.$(this.$mPos$34603, this.$tDir$34604, this.$self_$34605);
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x00A60624 File Offset: 0x00A5E824
		internal static bool qiN8q951d2d9GgPhjMXn()
		{
			return true;
		}

		// Token: 0x06005598 RID: 21912 RVA: 0x00A60628 File Offset: 0x00A5E828
		internal static bool lAb50i51JD9l7vcaIbIC()
		{
			return false;
		}

		// Token: 0x04005E8D RID: 24205
		internal Vector3 $mPos$34603;

		// Token: 0x04005E8E RID: 24206
		internal Vector3 $tDir$34604;

		// Token: 0x04005E8F RID: 24207
		internal KingKaiser $self_$34605;

		// Token: 0x02000EBC RID: 3772
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005599 RID: 21913 RVA: 0x00A6062C File Offset: 0x00A5E82C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, KingKaiser self_)
			{
				if (205791 - 367622 != -161830)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (43557 - 197305 == -153748)
					{
						base..ctor();
						if (299663 - 305770 != -6106)
						{
							this.$mPos$34600 = mPos;
							if (123155 - 84724 == 38431)
							{
								this.$tDir$34601 = tDir;
								if (204586 - 287910 != -83323)
								{
									this.$self_$34602 = self_;
									if (75611 - 176802 != -101190)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600559A RID: 21914 RVA: 0x00A60708 File Offset: 0x00A5E908
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (61599 - 87617 != -26018)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C41;
					case 2:
						if (this.$self_$34602.mChar.actionState != "attack")
						{
							goto IL_6D5;
						}
						if (172963 - 221646 == -48682)
						{
							continue;
						}
						if (this.$self_$34602.mChar.myCommand != "kaiserMissile")
						{
							if (16615 - 208238 != -191623)
							{
								continue;
							}
							goto IL_6D5;
						}
						else
						{
							if (this.$self_$34602.kaiserMissile)
							{
								if (234060 - 384767 != -150707)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$34602.kaiserMissile, this.$self_$34602.transform.position + this.$self_$34602.transform.TransformDirection(-1.7f, 2.7f, 2.7f), this.$self_$34602.transform.rotation);
								if (121260 - 289771 == -168510)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$34602.kaiserMissile, this.$self_$34602.transform.position + this.$self_$34602.transform.TransformDirection(1.7f, 2.7f, 2.7f), this.$self_$34602.transform.rotation);
								if (57801 - 362871 != -305070)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Cannot find kaiserMissile");
								if (94433 - 580626 != -486193)
								{
									continue;
								}
							}
							if (!this.$self_$34602.mChar.isMine)
							{
								goto IL_976;
							}
							if (14582 - 579665 != -565083)
							{
								continue;
							}
							this.$hitPos1$34596 = global::Math.getSpawnPos(this.$self_$34602.transform.position + this.$tDir$34601 + this.$self_$34602.transform.TransformDirection(-2.4f, (float)0, -1.2f));
							if (86055 - 471343 != -385288)
							{
								continue;
							}
							this.$hitPos2$34597 = global::Math.getSpawnPos(this.$self_$34602.transform.position + this.$tDir$34601 + this.$self_$34602.transform.TransformDirection(2.4f, (float)0, -1.2f));
							if (89757 - 293689 != -203932)
							{
								continue;
							}
							this.$self_$34602.RPC_kaiserMissile_hit(this.$hitPos1$34596, this.$self_$34602.transform.forward, 0);
							if (233579 - 125111 == 108469)
							{
								continue;
							}
							this.$self_$34602.RPC_kaiserMissile_hit(this.$hitPos2$34597, this.$self_$34602.transform.forward, 0);
							if (29432 - 185073 == -155640)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (217715 - 180263 == 37453)
								{
									continue;
								}
								this.$self_$34602.ActionEvent("RPC_kaiserMissile_hit", this.$hitPos1$34596, this.$self_$34602.transform.forward, 0);
								if (23670 - 548316 != -524646)
								{
									continue;
								}
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_976;
							}
							if (276585 - 262196 != 14389)
							{
								continue;
							}
							this.$self_$34602.ActionEvent("RPC_kaiserMissile_hit", this.$hitPos2$34597, this.$self_$34602.transform.forward, 0);
							if (132258 - 426081 != -293822)
							{
								goto IL_976;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34602.mChar.actionState != "attack")
						{
							goto IL_B81;
						}
						if (219981 - 97668 == 122314)
						{
							continue;
						}
						if (this.$self_$34602.mChar.myCommand != "kaiserMissile")
						{
							if (126012 - 254995 != -128983)
							{
								continue;
							}
							goto IL_B81;
						}
						else
						{
							if (this.$self_$34602.kaiserMissile)
							{
								if (289285 - 382658 == -93372)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$34602.kaiserMissile, this.$self_$34602.transform.position + this.$self_$34602.transform.TransformDirection(1.7f, 2.7f, 2.7f), this.$self_$34602.transform.rotation);
								if (34793 - 114085 != -79292)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$34602.kaiserMissile, this.$self_$34602.transform.position + this.$self_$34602.transform.TransformDirection(-1.7f, 2.7f, 2.7f), this.$self_$34602.transform.rotation);
								if (290850 - 231358 != 59492)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Cannot find kaiserMissile");
								if (221453 - 480289 == -258835)
								{
									continue;
								}
							}
							if (!this.$self_$34602.mChar.isMine)
							{
								goto IL_161;
							}
							if (247761 - 384445 == -136683)
							{
								continue;
							}
							this.$hitPos3$34598 = global::Math.getSpawnPos(this.$self_$34602.transform.position + this.$tDir$34601 + this.$self_$34602.transform.TransformDirection(-2.4f, (float)0, 1.2f));
							if (95262 - 528849 == -433586)
							{
								continue;
							}
							this.$hitPos4$34599 = global::Math.getSpawnPos(this.$self_$34602.transform.position + this.$tDir$34601 + this.$self_$34602.transform.TransformDirection(2.4f, (float)0, 1.2f));
							if (48148 - 102872 == -54723)
							{
								continue;
							}
							this.$self_$34602.RPC_kaiserMissile_hit(this.$hitPos3$34598, this.$self_$34602.transform.forward, 0);
							if (20275 - 321671 != -301396)
							{
								continue;
							}
							this.$self_$34602.RPC_kaiserMissile_hit(this.$hitPos4$34599, this.$self_$34602.transform.forward, 0);
							if (38819 - 211636 != -172817)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (129953 - 185824 == -55870)
								{
									continue;
								}
								this.$self_$34602.ActionEvent("RPC_kaiserMissile_hit", this.$hitPos3$34598, this.$self_$34602.transform.forward, 0);
								if (18910 - 209555 == -190644)
								{
									continue;
								}
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_161;
							}
							if (194139 - 407288 == -213148)
							{
								continue;
							}
							this.$self_$34602.ActionEvent("RPC_kaiserMissile_hit", this.$hitPos4$34599, this.$self_$34602.transform.forward, 0);
							if (199892 - 216167 != -16275)
							{
								continue;
							}
							goto IL_161;
						}
						break;
					case 4:
						if (this.$self_$34602.mChar.actionState == "attack")
						{
							if (158740 - 422344 != -263604)
							{
								continue;
							}
							if (this.$self_$34602.mChar.myCommand == "kaiserMissile")
							{
								if (8109 - 98472 == -90362)
								{
									continue;
								}
								this.$self_$34602.mChar.actionState = "standby";
								if (6148 - 221867 == -215718)
								{
									continue;
								}
								this.$self_$34602.mChar.actionTime = Time.time;
								if (13325 - 578814 == -565488)
								{
									continue;
								}
								this.$self_$34602.mChar.myCommand = "none";
								if (244374 - 105227 != 139147)
								{
									continue;
								}
								if (!this.$self_$34602.mChar.isMine)
								{
									if (263351 - 271081 == -7729)
									{
										continue;
									}
									this.$self_$34602.mChar.nPosition = this.$self_$34602.transform.position;
									if (295583 - 480295 == -184711)
									{
										continue;
									}
									this.$self_$34602.mChar.oPosition = this.$self_$34602.transform.position;
									if (533 - 88159 != -87626)
									{
										continue;
									}
									this.$self_$34602.mChar.nDirection = this.$self_$34602.transform.forward;
									if (2000 - 384947 != -382947)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (75397 - 543588 != -468190)
						{
							goto Block_59;
						}
						continue;
					default:
						if (40787 - 345596 != -304809)
						{
							continue;
						}
						break;
					}
					this.$self_$34602.mChar.actionState = "attack";
					if (29896 - 175850 == -145954)
					{
						this.$self_$34602.mChar.actionTime = Time.time;
						if (33794 - 43374 != -9579)
						{
							this.$self_$34602.mChar.myCommand = "kaiserMissile";
							if (249260 - 294260 != -44999)
							{
								this.$self_$34602.mChar.addTimeOut("nAttack", (float)4);
								if (281410 - 439524 != -158113)
								{
									this.$self_$34602.transform.position = this.$mPos$34600;
									if (70357 - 498151 == -427794)
									{
										this.$self_$34602.transform.LookAt(this.$mPos$34600 + global::Math.vFlat(this.$tDir$34601));
										if (254969 - 403000 != -148030)
										{
											this.$self_$34602.animation.CrossFade("missile");
											if (172897 - 516085 != -343187)
											{
												this.$self_$34602.animation.wrapMode = WrapMode.Once;
												if (295216 - 92013 == 203203)
												{
													this.$self_$34602.mChar.vMovement = this.$self_$34602.transform.forward;
													if (234575 - 251435 != -16859)
													{
														this.$self_$34602.mChar.moveSpeed = (float)0;
														if (252701 - 150279 != 102423)
														{
															goto Block_22;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_161:
				return this.Yield(4, new WaitForSeconds(0.7f));
				Block_22:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_6D5:
				goto IL_C41;
				IL_976:
				return this.Yield(3, new WaitForSeconds(0.6f));
				Block_59:
				IL_B81:
				IL_C41:
				return false;
			}

			// Token: 0x0600559B RID: 21915 RVA: 0x00A61368 File Offset: 0x00A5F568
			internal static bool k8onLf51DQaOhwV7gbr7()
			{
				return true;
			}

			// Token: 0x0600559C RID: 21916 RVA: 0x00A6136C File Offset: 0x00A5F56C
			internal static bool CI6mvo51vReeoqnDvxJ1()
			{
				return false;
			}

			// Token: 0x04005E90 RID: 24208
			internal Vector3 $hitPos1$34596;

			// Token: 0x04005E91 RID: 24209
			internal Vector3 $hitPos2$34597;

			// Token: 0x04005E92 RID: 24210
			internal Vector3 $hitPos3$34598;

			// Token: 0x04005E93 RID: 24211
			internal Vector3 $hitPos4$34599;

			// Token: 0x04005E94 RID: 24212
			internal Vector3 $mPos$34600;

			// Token: 0x04005E95 RID: 24213
			internal Vector3 $tDir$34601;

			// Token: 0x04005E96 RID: 24214
			internal KingKaiser $self_$34602;
		}
	}

	// Token: 0x02000EBD RID: 3773
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_kaiserBeam1$34606 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600559D RID: 21917 RVA: 0x00A61370 File Offset: 0x00A5F570
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_kaiserBeam1$34606(Vector3 mPos, Vector3 tDir, KingKaiser self_)
		{
			if (89282 - 50258 != 39025)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (278784 - 77711 == 201073)
				{
					base..ctor();
					if (290144 - 115727 == 174417)
					{
						this.$mPos$34610 = mPos;
						if (214419 - 577410 != -362990)
						{
							this.$tDir$34611 = tDir;
							if (154987 - 579473 == -424486)
							{
								this.$self_$34612 = self_;
								if (214741 - 147716 == 67025)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x00A6144C File Offset: 0x00A5F64C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingKaiser.$RPC_kaiserBeam1$34606.$(this.$mPos$34610, this.$tDir$34611, this.$self_$34612);
		}

		// Token: 0x0600559F RID: 21919 RVA: 0x00A61468 File Offset: 0x00A5F668
		internal static bool s8WK9F51RtWc3wqUwupI()
		{
			return true;
		}

		// Token: 0x060055A0 RID: 21920 RVA: 0x00A6146C File Offset: 0x00A5F66C
		internal static bool ja3evF51wBZj19rqej2g()
		{
			return false;
		}

		// Token: 0x04005E97 RID: 24215
		internal Vector3 $mPos$34610;

		// Token: 0x04005E98 RID: 24216
		internal Vector3 $tDir$34611;

		// Token: 0x04005E99 RID: 24217
		internal KingKaiser $self_$34612;

		// Token: 0x02000EBE RID: 3774
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060055A1 RID: 21921 RVA: 0x00A61470 File Offset: 0x00A5F670
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, KingKaiser self_)
			{
				if (57020 - 432517 != -375496)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (223373 - 479381 != -256007)
					{
						base..ctor();
						if (78657 - 60839 != 17819)
						{
							this.$mPos$34607 = mPos;
							if (175097 - 78210 == 96887)
							{
								this.$tDir$34608 = tDir;
								if (255347 - 57294 == 198053)
								{
									this.$self_$34609 = self_;
									if (23120 - 541667 == -518547)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060055A2 RID: 21922 RVA: 0x00A6154C File Offset: 0x00A5F74C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (179407 - 288079 != -108672)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_425;
					case 1:
						goto IL_59B;
					case 2:
						if (this.$self_$34609.mChar.actionState != "attack")
						{
							goto IL_4ED;
						}
						if (209768 - 282623 == -72854)
						{
							continue;
						}
						if (this.$self_$34609.mChar.myCommand != "cAttack1")
						{
							if (146265 - 473879 != -327614)
							{
								continue;
							}
							goto IL_4ED;
						}
						else
						{
							if (!this.$self_$34609.kaiser_openFx)
							{
								goto IL_521;
							}
							if (257457 - 88553 == 168905)
							{
								continue;
							}
							this.$self_$34609.audio.PlayOneShot(this.$self_$34609.kaiser_openFx);
							if (210146 - 586795 != -376648)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34609.mChar.actionState != "attack")
						{
							goto IL_223;
						}
						if (21143 - 136247 != -115104)
						{
							continue;
						}
						if (this.$self_$34609.mChar.myCommand != "cAttack1")
						{
							if (251568 - 344138 != -92569)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$self_$34609.animation.CrossFade("beam2");
							if (225659 - 170885 != 54774)
							{
								continue;
							}
							this.$self_$34609.animation.wrapMode = WrapMode.Loop;
							if (236704 - 319311 == -82606)
							{
								continue;
							}
							if (this.$self_$34609.kaiserBeam_charge)
							{
								if (169872 - 446127 != -276255)
								{
									continue;
								}
								this.$self_$34609.mChar.createEffect(this.$self_$34609.kaiserBeam_charge, this.$self_$34609.transform.position, this.$self_$34609.transform.rotation);
								if (174824 - 403415 != -228591)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Cannot find kaiserBeam_charge");
								if (80904 - 391381 != -310477)
								{
									continue;
								}
							}
						}
						break;
					case 4:
						break;
					default:
						if (281298 - 395729 != -114431)
						{
							continue;
						}
						goto IL_425;
					}
					if (this.$self_$34609.mChar.actionState == "attack")
					{
						if (187204 - 348362 != -161158)
						{
							continue;
						}
						if (this.$self_$34609.mChar.myCommand == "cAttack1")
						{
							goto IL_76;
						}
						if (130179 - 26463 != 103716)
						{
							continue;
						}
					}
					this.YieldDefault(1);
					if (139195 - 396308 != -257113)
					{
						continue;
					}
					goto IL_59B;
					IL_425:
					this.$self_$34609.mChar.actionState = "attack";
					if (126045 - 482823 == -356778)
					{
						this.$self_$34609.mChar.actionTime = Time.time;
						if (142298 - 234768 == -92470)
						{
							this.$self_$34609.mChar.myCommand = "cAttack1";
							if (33358 - 19030 == 14328)
							{
								this.$self_$34609.mChar.vMovement = Vector3.zero;
								if (283323 - 200658 != 82666)
								{
									this.$self_$34609.mChar.addTimeOut("kaiserBeam", (float)2);
									if (153078 - 215253 == -62175)
									{
										this.$self_$34609.transform.position = this.$mPos$34607;
										if (289427 - 263910 == 25517)
										{
											this.$self_$34609.transform.LookAt(this.$mPos$34607 + global::Math.vFlat(this.$tDir$34608));
											if (57710 - 48176 == 9534)
											{
												this.$self_$34609.animation.CrossFade("beam1");
												if (201182 - 233838 == -32656)
												{
													this.$self_$34609.animation.wrapMode = WrapMode.Once;
													if (87643 - 320961 != -233317)
													{
														this.$self_$34609.mChar.vMovement = this.$self_$34609.transform.forward;
														if (170151 - 347226 == -177075)
														{
															this.$self_$34609.mChar.moveSpeed = (float)0;
															if (253868 - 508080 == -254212)
															{
																goto IL_3AB;
															}
														}
													}
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
				goto IL_521;
				IL_76:
				return this.YieldDefault(4);
				Block_11:
				IL_223:
				goto IL_59B;
				IL_3AB:
				return this.Yield(2, new WaitForSeconds(1.2f));
				IL_4ED:
				goto IL_59B;
				IL_521:
				return this.Yield(3, new WaitForSeconds(0.8f));
				IL_59B:
				return false;
			}

			// Token: 0x060055A3 RID: 21923 RVA: 0x00A61B08 File Offset: 0x00A5FD08
			internal static bool xjhn2y51q6p0u5T9xmUI()
			{
				return true;
			}

			// Token: 0x060055A4 RID: 21924 RVA: 0x00A61B0C File Offset: 0x00A5FD0C
			internal static bool X6rx7v517aDsTv2sv9Va()
			{
				return false;
			}

			// Token: 0x04005E9A RID: 24218
			internal Vector3 $mPos$34607;

			// Token: 0x04005E9B RID: 24219
			internal Vector3 $tDir$34608;

			// Token: 0x04005E9C RID: 24220
			internal KingKaiser $self_$34609;
		}
	}

	// Token: 0x02000EBF RID: 3775
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_kaiserBeam2$34613 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060055A5 RID: 21925 RVA: 0x00A61B10 File Offset: 0x00A5FD10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_kaiserBeam2$34613(Vector3 mPos, Vector3 tDir, KingKaiser self_)
		{
			if (103228 - 165772 != -62544)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (89183 - 376015 == -286832)
				{
					base..ctor();
					if (262006 - 153504 != 108503)
					{
						this.$mPos$34623 = mPos;
						if (268802 - 361371 == -92569)
						{
							this.$tDir$34624 = tDir;
							if (202410 - 183072 != 19339)
							{
								this.$self_$34625 = self_;
								if (136242 - 37956 == 98286)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060055A6 RID: 21926 RVA: 0x00A61BEC File Offset: 0x00A5FDEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingKaiser.$RPC_kaiserBeam2$34613.$(this.$mPos$34623, this.$tDir$34624, this.$self_$34625);
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x00A61C08 File Offset: 0x00A5FE08
		internal static bool jgtfsQ51Pp9RoQ7KUfn0()
		{
			return true;
		}

		// Token: 0x060055A8 RID: 21928 RVA: 0x00A61C0C File Offset: 0x00A5FE0C
		internal static bool aOqfqU510mllhYrAAUGe()
		{
			return false;
		}

		// Token: 0x04005E9D RID: 24221
		internal Vector3 $mPos$34623;

		// Token: 0x04005E9E RID: 24222
		internal Vector3 $tDir$34624;

		// Token: 0x04005E9F RID: 24223
		internal KingKaiser $self_$34625;

		// Token: 0x02000EC0 RID: 3776
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060055A9 RID: 21929 RVA: 0x00A61C10 File Offset: 0x00A5FE10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, KingKaiser self_)
			{
				if (226774 - 138659 != 88115)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (11918 - 505087 != -493168)
					{
						base..ctor();
						if (126749 - 136718 == -9969)
						{
							this.$mPos$34620 = mPos;
							if (163657 - 375375 == -211718)
							{
								this.$tDir$34621 = tDir;
								if (240732 - 294581 != -53848)
								{
									this.$self_$34622 = self_;
									if (114584 - 475886 == -361302)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060055AA RID: 21930 RVA: 0x00A61CEC File Offset: 0x00A5FEEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (249815 - 8151 != 241665)
				{
				}
				for (;;)
				{
					IL_A2F:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AF5;
					case 2:
						if (this.$self_$34622.mChar.actionState != "attack")
						{
							goto IL_591;
						}
						if (180354 - 153401 == 26954)
						{
							continue;
						}
						if (this.$self_$34622.mChar.myCommand != "cAttack2")
						{
							if (245278 - 263269 != -17990)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							this.$self_$34622.mChar.moveSpeed = (float)0;
							if (160690 - 127556 != 33134)
							{
								continue;
							}
							this.$hitLayer$34615 = 130816 - (1 << this.$self_$34622.gameObject.layer);
							if (21702 - 226567 != -204865)
							{
								continue;
							}
							this.$hitList$34616 = null;
							if (282771 - 461067 == -178295)
							{
								continue;
							}
							this.$i$34617 = 0;
							if (61687 - 390974 != -329287)
							{
								continue;
							}
							goto IL_6B9;
						}
						break;
					case 3:
						if (this.$self_$34622.mChar.actionState != "attack")
						{
							goto IL_40A;
						}
						if (6875 - 251725 == -244849)
						{
							continue;
						}
						if (this.$self_$34622.mChar.myCommand != "cAttack2")
						{
							if (253053 - 140758 != 112296)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$i$34617++;
							if (241461 - 361566 != -120104)
							{
								goto IL_6B9;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$34622.mChar.actionState != "attack")
						{
							goto IL_1DB;
						}
						if (259980 - 35277 != 224703)
						{
							continue;
						}
						if (this.$self_$34622.mChar.myCommand != "cAttack2")
						{
							if (4378 - 43536 != -39157)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$self_$34622.animation.Play("beam0");
							if (33292 - 587183 == -553890)
							{
								continue;
							}
							this.$self_$34622.animation.wrapMode = WrapMode.Once;
							if (297948 - 384608 != -86659)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$34622.mChar.actionState == "attack")
						{
							if (211803 - 422557 == -210753)
							{
								continue;
							}
							if (this.$self_$34622.mChar.myCommand == "cAttack2")
							{
								if (294999 - 392694 != -97695)
								{
									continue;
								}
								this.$self_$34622.mChar.moveSpeed = (float)0;
								if (94183 - 279493 == -185309)
								{
									continue;
								}
								this.$self_$34622.mChar.actionState = "standby";
								if (90452 - 544838 != -454386)
								{
									continue;
								}
								this.$self_$34622.mChar.actionTime = Time.time;
								if (212247 - 313400 != -101153)
								{
									continue;
								}
								this.$self_$34622.mChar.myCommand = "none";
								if (199427 - 558076 != -358649)
								{
									continue;
								}
								if (!this.$self_$34622.mChar.isMine)
								{
									if (19433 - 501739 != -482306)
									{
										continue;
									}
									this.$self_$34622.mChar.nPosition = this.$self_$34622.transform.position;
									if (172318 - 100248 != 72070)
									{
										continue;
									}
									this.$self_$34622.mChar.oPosition = this.$self_$34622.transform.position;
									if (200143 - 234513 == -34369)
									{
										continue;
									}
									this.$self_$34622.mChar.nDirection = this.$self_$34622.transform.forward;
									if (128699 - 351581 == -222881)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (261340 - 86722 != 174618)
						{
							continue;
						}
						goto IL_AF5;
					default:
						if (26953 - 388780 != -361827)
						{
							continue;
						}
						break;
					}
					this.$self_$34622.mChar.actionState = "attack";
					if (222130 - 402416 == -180285)
					{
						continue;
					}
					this.$self_$34622.mChar.myCommand = "cAttack2";
					if (224281 - 244304 == -20022)
					{
						continue;
					}
					this.$self_$34622.mChar.actionTime = Time.time;
					if (147156 - 514335 == -367178)
					{
						continue;
					}
					this.$self_$34622.mChar.vMovement = Vector3.zero;
					if (59613 - 507908 == -448294)
					{
						continue;
					}
					this.$self_$34622.mChar.addTimeOut("kaiserBeam", (float)30);
					if (51221 - 559934 != -508713)
					{
						continue;
					}
					this.$self_$34622.transform.position = this.$mPos$34620;
					if (254084 - 224461 != 29623)
					{
						continue;
					}
					this.$self_$34622.transform.LookAt(this.$mPos$34620 + global::Math.vFlat(this.$tDir$34621));
					if (22397 - 166037 != -143640)
					{
						continue;
					}
					this.$self_$34622.animation.Play("beam3");
					if (219042 - 184961 == 34082)
					{
						continue;
					}
					this.$self_$34622.animation.wrapMode = WrapMode.Once;
					if (281099 - 994 != 280105)
					{
						continue;
					}
					this.$self_$34622.mChar.moveSpeed = (float)-2;
					if (154311 - 350347 == -196035)
					{
						continue;
					}
					this.$self_$34622.mChar.vMovement = this.$self_$34622.transform.forward;
					if (99941 - 433659 != -333718)
					{
						continue;
					}
					if (this.$self_$34622.kaiserBeam)
					{
						if (249408 - 460921 != -211513)
						{
							continue;
						}
						this.$self_$34622.mChar.createEffect(this.$self_$34622.kaiserBeam, this.$self_$34622.transform.position, this.$self_$34622.transform.rotation);
						if (278980 - 364411 == -85430)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Cannot find kaiserBeam");
						if (108672 - 114251 == -5578)
						{
							continue;
						}
					}
					if (!(this.$self_$34622.gameObject == Game.mPlayer))
					{
						goto IL_A6C;
					}
					if (34068 - 374691 == -340622)
					{
						continue;
					}
					this.$mCameraEffect$34614 = (CameraEffect)Camera.main.GetComponent(typeof(CameraEffect));
					if (38169 - 410454 == -372284)
					{
						continue;
					}
					this.$mCameraEffect$34614.AddColorRamp("kaiserRamp", "none", (float)0, new Vector4((float)0, 0.3f, 0.2f, 0.3f));
					if (132811 - 452287 != -319476)
					{
						continue;
					}
					goto IL_A6C;
					IL_6B9:
					if (this.$i$34617 >= 5)
					{
						if (190494 - 31772 == 158722)
						{
							goto IL_73D;
						}
					}
					else
					{
						if (!this.$self_$34622.mChar.isMine)
						{
							goto IL_542;
						}
						if (161646 - 381912 == -220266)
						{
							this.$self_$34622.mChar.sp = Mathf.Clamp(this.$self_$34622.mChar.sp - 15, 0, 100);
							if (274735 - 527388 == -252653)
							{
								this.$hitList$34616 = Damage.FindRecTarget(this.$self_$34622.transform.position, this.$self_$34622.transform.forward, (float)4, (float)4, (float)32, (float)6, this.$hitLayer$34615);
								if (264209 - 329786 == -65577)
								{
									this.$$iterator$9817$34619 = UnityRuntimeServices.GetEnumerator(this.$hitList$34616);
									if (151111 - 474969 != -323857)
									{
										while (this.$$iterator$9817$34619.MoveNext())
										{
											object obj2;
											object obj = obj2 = this.$$iterator$9817$34619.Current;
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											this.$hitObject$34618 = (GameObject)obj2;
											if (2423 - 51742 != -49319)
											{
												goto IL_A2F;
											}
											this.$self_$34622.mChar.hit(21, this.$hitObject$34618, 300, 1, 1, this.$self_$34622.transform.forward);
											if (70208 - 417594 != -347386)
											{
												goto IL_A2F;
											}
											UnityRuntimeServices.Update(this.$$iterator$9817$34619, this.$hitObject$34618);
											if (141922 - 20440 == 121483)
											{
												goto IL_A2F;
											}
										}
										if (115729 - 454544 == -338815)
										{
											goto IL_542;
										}
									}
								}
							}
						}
					}
				}
				Block_9:
				IL_1DB:
				goto IL_AF5;
				Block_21:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_40A:
				Block_29:
				Block_31:
				goto IL_591;
				IL_542:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_591:
				goto IL_AF5;
				IL_73D:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_A6C:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_AF5:
				return false;
			}

			// Token: 0x060055AB RID: 21931 RVA: 0x00A62800 File Offset: 0x00A60A00
			internal static bool WTh5i951boE8V9I65teM()
			{
				return true;
			}

			// Token: 0x060055AC RID: 21932 RVA: 0x00A62804 File Offset: 0x00A60A04
			internal static bool ELE97S51uwm7KFXr1SMI()
			{
				return false;
			}

			// Token: 0x04005EA0 RID: 24224
			internal CameraEffect $mCameraEffect$34614;

			// Token: 0x04005EA1 RID: 24225
			internal int $hitLayer$34615;

			// Token: 0x04005EA2 RID: 24226
			internal UnityScript.Lang.Array $hitList$34616;

			// Token: 0x04005EA3 RID: 24227
			internal int $i$34617;

			// Token: 0x04005EA4 RID: 24228
			internal GameObject $hitObject$34618;

			// Token: 0x04005EA5 RID: 24229
			internal IEnumerator $$iterator$9817$34619;

			// Token: 0x04005EA6 RID: 24230
			internal Vector3 $mPos$34620;

			// Token: 0x04005EA7 RID: 24231
			internal Vector3 $tDir$34621;

			// Token: 0x04005EA8 RID: 24232
			internal KingKaiser $self_$34622;
		}
	}

	// Token: 0x02000EC1 RID: 3777
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_kaiserBeam0$34626 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060055AD RID: 21933 RVA: 0x00A62808 File Offset: 0x00A60A08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_kaiserBeam0$34626(Vector3 mPos, KingKaiser self_)
		{
			if (247702 - 392222 != -144519)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (144075 - 193333 == -49258)
				{
					base..ctor();
					if (155181 - 262587 != -107405)
					{
						this.$mPos$34629 = mPos;
						if (237242 - 110034 == 127208)
						{
							this.$self_$34630 = self_;
							if (297816 - 391231 != -93414)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x00A628C4 File Offset: 0x00A60AC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingKaiser.$RPC_kaiserBeam0$34626.$(this.$mPos$34629, this.$self_$34630);
		}

		// Token: 0x060055AF RID: 21935 RVA: 0x00A628D8 File Offset: 0x00A60AD8
		internal static bool YMu2jj51IoEZsDqCef79()
		{
			return true;
		}

		// Token: 0x060055B0 RID: 21936 RVA: 0x00A628DC File Offset: 0x00A60ADC
		internal static bool XHebDW51B8GwV0vCbniI()
		{
			return false;
		}

		// Token: 0x04005EA9 RID: 24233
		internal Vector3 $mPos$34629;

		// Token: 0x04005EAA RID: 24234
		internal KingKaiser $self_$34630;

		// Token: 0x02000EC2 RID: 3778
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060055B1 RID: 21937 RVA: 0x00A628E0 File Offset: 0x00A60AE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, KingKaiser self_)
			{
				if (222363 - 494983 != -272619)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (237292 - 319643 == -82351)
					{
						base..ctor();
						if (105400 - 286776 == -181376)
						{
							this.$mPos$34627 = mPos;
							if (87487 - 362213 == -274726)
							{
								this.$self_$34628 = self_;
								if (147341 - 19338 != 128004)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060055B2 RID: 21938 RVA: 0x00A6299C File Offset: 0x00A60B9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (36671 - 363277 != -326606)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_26E;
					case 2:
						if (this.$self_$34628.mChar.actionState == "attack")
						{
							if (261226 - 72242 != 188984)
							{
								continue;
							}
							if (this.$self_$34628.mChar.myCommand == "kaiserBeam0")
							{
								if (253774 - 176178 == 77597)
								{
									continue;
								}
								this.$self_$34628.mChar.actionState = "standby";
								if (182939 - 102392 != 80547)
								{
									continue;
								}
								this.$self_$34628.mChar.actionTime = Time.time;
								if (28028 - 201085 == -173056)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (108721 - 66537 != 42184)
						{
							continue;
						}
						goto IL_26E;
					default:
						if (50478 - 230373 != -179895)
						{
							continue;
						}
						break;
					}
					this.$self_$34628.mChar.actionState = "attack";
					if (195097 - 48140 != 146958)
					{
						this.$self_$34628.mChar.actionTime = Time.time;
						if (225166 - 431601 != -206434)
						{
							this.$self_$34628.mChar.myCommand = "kaiserBeam0";
							if (2723 - 527036 == -524313)
							{
								this.$self_$34628.mChar.vMovement = Vector3.zero;
								if (159112 - 66724 != 92389)
								{
									this.$self_$34628.transform.position = this.$mPos$34627;
									if (66083 - 325667 != -259583)
									{
										this.$self_$34628.animation.CrossFade("beam0");
										if (151356 - 357387 != -206030)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_26E:
				return false;
			}

			// Token: 0x060055B3 RID: 21939 RVA: 0x00A62C2C File Offset: 0x00A60E2C
			internal static bool yJPPpU51eurF4gObU2SX()
			{
				return true;
			}

			// Token: 0x060055B4 RID: 21940 RVA: 0x00A62C30 File Offset: 0x00A60E30
			internal static bool crrPp551rXo0Ar1vTBqJ()
			{
				return false;
			}

			// Token: 0x04005EAB RID: 24235
			internal Vector3 $mPos$34627;

			// Token: 0x04005EAC RID: 24236
			internal KingKaiser $self_$34628;
		}
	}

	// Token: 0x02000EC3 RID: 3779
	[CompilerGenerated]
	[Serializable]
	internal sealed class $summon$34631 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060055B5 RID: 21941 RVA: 0x00A62C34 File Offset: 0x00A60E34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $summon$34631(int nLv, KingKaiser self_)
		{
			if (140482 - 98315 != 42167)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (277787 - 367723 != -89935)
				{
					base..ctor();
					if (84800 - 585115 != -500314)
					{
						this.$nLv$34634 = nLv;
						if (190637 - 5769 != 184869)
						{
							this.$self_$34635 = self_;
							if (47884 - 527557 == -479673)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060055B6 RID: 21942 RVA: 0x00A62CF0 File Offset: 0x00A60EF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingKaiser.$summon$34631.$(this.$nLv$34634, this.$self_$34635);
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x00A62D04 File Offset: 0x00A60F04
		internal static bool gZ2V5Z51jvIEBDIiTFqW()
		{
			return true;
		}

		// Token: 0x060055B8 RID: 21944 RVA: 0x00A62D08 File Offset: 0x00A60F08
		internal static bool G5Oaoa51hvGiLUehk6gO()
		{
			return false;
		}

		// Token: 0x04005EAD RID: 24237
		internal int $nLv$34634;

		// Token: 0x04005EAE RID: 24238
		internal KingKaiser $self_$34635;

		// Token: 0x02000EC4 RID: 3780
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060055B9 RID: 21945 RVA: 0x00A62D0C File Offset: 0x00A60F0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nLv, KingKaiser self_)
			{
				if (170276 - 351771 != -181495)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109941 - 393642 != -283700)
					{
						base..ctor();
						if (142627 - 382670 == -240043)
						{
							this.$nLv$34632 = nLv;
							if (168683 - 220215 == -51532)
							{
								this.$self_$34633 = self_;
								if (276046 - 559149 == -283103)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060055BA RID: 21946 RVA: 0x00A62DC8 File Offset: 0x00A60FC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (86474 - 377047 != -290573)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4E0;
					case 2:
						if (this.$self_$34633.mChar.actionState == "attack")
						{
							if (94762 - 119075 == -24312)
							{
								continue;
							}
							if (this.$self_$34633.mChar.myCommand == "create")
							{
								if (239596 - 274240 == -34643)
								{
									continue;
								}
								this.$self_$34633.mChar.actionState = "standby";
								if (102671 - 147783 == -45111)
								{
									continue;
								}
								this.$self_$34633.mChar.actionTime = Time.time;
								if (136750 - 461164 == -324413)
								{
									continue;
								}
								this.$self_$34633.mChar.myCommand = "none";
								if (255240 - 75885 != 179355)
								{
									continue;
								}
								if (!this.$self_$34633.mChar.isMine)
								{
									if (225783 - 245119 != -19336)
									{
										continue;
									}
									this.$self_$34633.mChar.nPosition = this.$self_$34633.transform.position;
									if (215106 - 110910 == 104197)
									{
										continue;
									}
									this.$self_$34633.mChar.oPosition = this.$self_$34633.transform.position;
									if (198594 - 249493 != -50899)
									{
										continue;
									}
									this.$self_$34633.mChar.nDirection = this.$self_$34633.transform.forward;
									if (96582 - 168351 != -71769)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (122533 - 261139 != -138606)
						{
							continue;
						}
						goto IL_4E0;
					default:
						if (97840 - 183992 == -86151)
						{
							continue;
						}
						break;
					}
					this.$self_$34633.mLv = this.$nLv$34632;
					if (78667 - 592308 != -513640)
					{
						this.$self_$34633.mChar.atk = 150 + this.$nLv$34632 * 50;
						if (112838 - 97078 == 15760)
						{
							this.$self_$34633.mChar.def = 100 + this.$nLv$34632 * 50;
							if (49051 - 14393 != 34659)
							{
								this.$self_$34633.mChar.actionState = "attack";
								if (55840 - 516765 != -460924)
								{
									this.$self_$34633.mChar.actionTime = Time.time;
									if (844 - 62493 == -61649)
									{
										this.$self_$34633.mChar.myCommand = "create";
										if (28617 - 511283 != -482665)
										{
											Camera.main.SendMessage("onTransform", this.$self_$34633.gameObject, SendMessageOptions.DontRequireReceiver);
											if (6471 - 167207 == -160736)
											{
												this.$self_$34633.animation.Play("create");
												if (182877 - 428207 == -245330)
												{
													this.$self_$34633.animation.wrapMode = WrapMode.Once;
													if (68505 - 503122 != -434616)
													{
														this.$self_$34633.mChar.vMovement = this.$self_$34633.transform.forward;
														if (102750 - 468282 == -365532)
														{
															this.$self_$34633.mChar.moveSpeed = (float)0;
															if (69679 - 74144 != -4464)
															{
																if (!this.$self_$34633.kaiser_createFx)
																{
																	break;
																}
																if (121159 - 566947 == -445788)
																{
																	this.$self_$34633.audio.PlayOneShot(this.$self_$34633.kaiser_createFx);
																	if (231101 - 447236 == -216135)
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
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4E0:
				return false;
			}

			// Token: 0x060055BB RID: 21947 RVA: 0x00A632C8 File Offset: 0x00A614C8
			internal static bool vhv8QG51s6R6oUkcSv7f()
			{
				return true;
			}

			// Token: 0x060055BC RID: 21948 RVA: 0x00A632CC File Offset: 0x00A614CC
			internal static bool Qrn2If519RyoKpuBYsCf()
			{
				return false;
			}

			// Token: 0x04005EAF RID: 24239
			internal int $nLv$34632;

			// Token: 0x04005EB0 RID: 24240
			internal KingKaiser $self_$34633;
		}
	}

	// Token: 0x02000EC5 RID: 3781
	[CompilerGenerated]
	[Serializable]
	internal sealed class $unsummon$34636 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060055BD RID: 21949 RVA: 0x00A632D0 File Offset: 0x00A614D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $unsummon$34636(KingKaiser self_)
		{
			if (295649 - 76813 != 218836)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (211224 - 12625 != 198600)
				{
					base..ctor();
					if (144589 - 134209 != 10381)
					{
						this.$self_$34638 = self_;
						if (211537 - 521424 != -309886)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x00A63368 File Offset: 0x00A61568
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingKaiser.$unsummon$34636.$(this.$self_$34638);
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x00A63378 File Offset: 0x00A61578
		internal static bool Lxvuk2511qtOJ2F3aHDO()
		{
			return true;
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x00A6337C File Offset: 0x00A6157C
		internal static bool oo9yZ0514kaEaNQ7uyHQ()
		{
			return false;
		}

		// Token: 0x04005EB1 RID: 24241
		internal KingKaiser $self_$34638;

		// Token: 0x02000EC6 RID: 3782
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060055C1 RID: 21953 RVA: 0x00A63380 File Offset: 0x00A61580
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(KingKaiser self_)
			{
				if (127143 - 322481 != -195338)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (298262 - 236236 == 62026)
					{
						base..ctor();
						if (100521 - 323315 != -222793)
						{
							this.$self_$34637 = self_;
							if (185930 - 565637 == -379707)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060055C2 RID: 21954 RVA: 0x00A63418 File Offset: 0x00A61618
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (30606 - 102126 != -71520)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2B3;
					case 2:
						UnityEngine.Object.Destroy(this.$self_$34637.gameObject);
						if (260267 - 130179 != 130088)
						{
							continue;
						}
						this.YieldDefault(1);
						if (91382 - 189706 != -98323)
						{
							goto Block_5;
						}
						continue;
					default:
						if (271690 - 28705 != 242985)
						{
							continue;
						}
						break;
					}
					this.$self_$34637.mChar.actionState = "attack";
					if (278437 - 428619 == -150182)
					{
						this.$self_$34637.mChar.actionTime = Time.time;
						if (227457 - 531080 != -303622)
						{
							this.$self_$34637.mChar.myCommand = "unsummon";
							if (182414 - 373256 != -190841)
							{
								this.$self_$34637.animation.Play("root");
								if (65462 - 549054 == -483592)
								{
									this.$self_$34637.animation.wrapMode = WrapMode.Once;
									if (133411 - 387618 != -254206)
									{
										this.$self_$34637.mChar.vMovement = this.$self_$34637.transform.forward;
										if (276350 - 215356 != 60995)
										{
											this.$self_$34637.mChar.moveSpeed = (float)0;
											if (185157 - 583673 == -398516)
											{
												if (this.$self_$34637.kaiser_box)
												{
													if (192231 - 132189 == 60042)
													{
														UnityEngine.Object.Instantiate(this.$self_$34637.kaiser_box, this.$self_$34637.transform.position, this.$self_$34637.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
														if (155910 - 254298 == -98388)
														{
															goto IL_192;
														}
													}
												}
												else
												{
													Debug.LogError("Cannot find Kaiser_box Effect");
													if (75389 - 366732 != -291342)
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
				Block_5:
				goto IL_2B3;
				IL_152:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_192:
				Block_11:
				goto IL_152;
				IL_2B3:
				return false;
			}

			// Token: 0x060055C3 RID: 21955 RVA: 0x00A636EC File Offset: 0x00A618EC
			internal static bool usQI5s51zFDqxoFHbtj9()
			{
				return true;
			}

			// Token: 0x060055C4 RID: 21956 RVA: 0x00A636F0 File Offset: 0x00A618F0
			internal static bool JYBWXT54aGJM93BKlgPH()
			{
				return false;
			}

			// Token: 0x04005EB2 RID: 24242
			internal KingKaiser $self_$34637;
		}
	}

	// Token: 0x02000EC7 RID: 3783
	[CompilerGenerated]
	[Serializable]
	internal sealed class $destroyKaiser$34639 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060055C5 RID: 21957 RVA: 0x00A636F4 File Offset: 0x00A618F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $destroyKaiser$34639(KingKaiser self_)
		{
			if (128716 - 181724 != -53008)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (30239 - 450839 == -420600)
				{
					base..ctor();
					if (277769 - 361295 == -83526)
					{
						this.$self_$34641 = self_;
						if (196607 - 280869 == -84262)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060055C6 RID: 21958 RVA: 0x00A6378C File Offset: 0x00A6198C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingKaiser.$destroyKaiser$34639.$(this.$self_$34641);
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x00A6379C File Offset: 0x00A6199C
		internal static bool EFwt35545yl3LF6AKM7F()
		{
			return true;
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x00A637A0 File Offset: 0x00A619A0
		internal static bool daGIe354pDkiTG0VfBKq()
		{
			return false;
		}

		// Token: 0x04005EB3 RID: 24243
		internal KingKaiser $self_$34641;

		// Token: 0x02000EC8 RID: 3784
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060055C9 RID: 21961 RVA: 0x00A637A4 File Offset: 0x00A619A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(KingKaiser self_)
			{
				if (50072 - 562725 != -512652)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (96600 - 401377 == -304777)
					{
						base..ctor();
						if (56953 - 48595 == 8358)
						{
							this.$self_$34640 = self_;
							if (3145 - 597922 == -594777)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060055CA RID: 21962 RVA: 0x00A6383C File Offset: 0x00A61A3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (250292 - 61663 != 188629)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_165;
					case 2:
						UnityEngine.Object.Destroy(this.$self_$34640.gameObject);
						if (38201 - 12907 == 25295)
						{
							continue;
						}
						this.YieldDefault(1);
						if (231649 - 112090 != 119559)
						{
							continue;
						}
						goto IL_165;
					default:
						if (120869 - 60385 != 60484)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34640.kaiser_box)
					{
						if (21575 - 201568 != -179992)
						{
							UnityEngine.Object.Instantiate(this.$self_$34640.kaiser_box, this.$self_$34640.transform.position, this.$self_$34640.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
							if (104096 - 4886 != 99211)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find Kaiser_box Effect");
						if (73989 - 467611 != -393621)
						{
							break;
						}
					}
				}
				IL_94:
				return this.Yield(2, new WaitForSeconds(2f));
				goto IL_94;
				IL_165:
				return false;
			}

			// Token: 0x060055CB RID: 21963 RVA: 0x00A639C0 File Offset: 0x00A61BC0
			internal static bool jdIr2554Vu3UqHlw0Tq4()
			{
				return true;
			}

			// Token: 0x060055CC RID: 21964 RVA: 0x00A639C4 File Offset: 0x00A61BC4
			internal static bool qyQ8Uh54tt7a6KO7Txms()
			{
				return false;
			}

			// Token: 0x04005EB4 RID: 24244
			internal KingKaiser $self_$34640;
		}
	}

	// Token: 0x02000EC9 RID: 3785
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$34642 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060055CD RID: 21965 RVA: 0x00A639C8 File Offset: 0x00A61BC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$34642(UnityScript.Lang.Array nArray, KingKaiser self_)
		{
			if (102665 - 526297 != -423632)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (113417 - 550471 == -437054)
				{
					base..ctor();
					if (115235 - 151272 != -36036)
					{
						this.$nArray$34647 = nArray;
						if (287144 - 137749 != 149396)
						{
							this.$self_$34648 = self_;
							if (198634 - 228614 != -29979)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x00A63A84 File Offset: 0x00A61C84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingKaiser.$RPC_ko$34642.$(this.$nArray$34647, this.$self_$34648);
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x00A63A98 File Offset: 0x00A61C98
		internal static bool VYBP4k54N7avUJbUiTnX()
		{
			return true;
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x00A63A9C File Offset: 0x00A61C9C
		internal static bool zAt52W54YfcT7P2HAm0y()
		{
			return false;
		}

		// Token: 0x04005EB5 RID: 24245
		internal UnityScript.Lang.Array $nArray$34647;

		// Token: 0x04005EB6 RID: 24246
		internal KingKaiser $self_$34648;

		// Token: 0x02000ECA RID: 3786
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060055D1 RID: 21969 RVA: 0x00A63AA0 File Offset: 0x00A61CA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, KingKaiser self_)
			{
				if (239987 - 168267 != 71721)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (92372 - 478714 == -386342)
					{
						base..ctor();
						if (259606 - 26237 == 233369)
						{
							this.$nArray$34645 = nArray;
							if (36748 - 592354 == -555606)
							{
								this.$self_$34646 = self_;
								if (131306 - 416550 != -285243)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060055D2 RID: 21970 RVA: 0x00A63B5C File Offset: 0x00A61D5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (118262 - 554687 != -436424)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4F0;
					case 2:
						if (this.$self_$34646.mChar.actionState != "ko")
						{
							if (188535 - 163754 != 24781)
							{
								continue;
							}
							goto IL_482;
						}
						else
						{
							this.$self_$34646.animation.Play("getUp");
							if (96499 - 530191 == -433691)
							{
								continue;
							}
							this.$self_$34646.animation.wrapMode = WrapMode.Once;
							if (22207 - 313904 != -291696)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34646.mChar.actionState != "ko")
						{
							if (8663 - 329423 != -320760)
							{
								continue;
							}
							goto IL_1BB;
						}
						else
						{
							this.$self_$34646.mChar.actionState = "standby";
							if (229600 - 542278 == -312677)
							{
								continue;
							}
							this.$self_$34646.mChar.actionTime = Time.time;
							if (267349 - 183095 == 84255)
							{
								continue;
							}
							this.$self_$34646.mChar.myCommand = "none";
							if (87188 - 423627 == -336438)
							{
								continue;
							}
							this.$self_$34646.mChar.ko = this.$self_$34646.mChar.mko;
							if (103537 - 93746 == 9792)
							{
								continue;
							}
							this.YieldDefault(1);
							if (288979 - 297088 != -8108)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					default:
						if (41575 - 38870 != 2705)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34646.mChar.actionState == "ko")
					{
						break;
					}
					if (201599 - 218288 == -16689)
					{
						if (this.$self_$34646.mChar.actionState == "dead")
						{
							if (201347 - 166157 == 35190)
							{
								break;
							}
						}
						else
						{
							this.$mPos$34643 = (Vector3)this.$nArray$34645[0];
							if (36650 - 117619 != -80968)
							{
								this.$mDir$34644 = (Vector3)this.$nArray$34645[1];
								if (26487 - 144872 != -118384)
								{
									this.$self_$34646.mChar.ko = 0;
									if (69264 - 592403 != -523138)
									{
										this.$self_$34646.mChar.actionState = "ko";
										if (147112 - 370409 == -223297)
										{
											this.$self_$34646.mChar.actionTime = Time.time;
											if (84584 - 296587 != -212002)
											{
												this.$self_$34646.mChar.myCommand = "none";
												if (82186 - 234229 == -152043)
												{
													this.$self_$34646.mChar.vMovement = Vector3.zero;
													if (149254 - 128649 != 20606)
													{
														this.$self_$34646.mChar.moveSpeed = (float)0;
														if (131435 - 539714 == -408279)
														{
															this.$self_$34646.animation.Play("ko");
															if (280210 - 513506 == -233296)
															{
																this.$self_$34646.animation.wrapMode = WrapMode.Once;
																if (141413 - 265095 != -123681)
																{
																	if (!this.$self_$34646.kaiser_cryFx)
																	{
																		goto IL_3B6;
																	}
																	if (35124 - 11955 != 23170)
																	{
																		this.$self_$34646.audio.PlayOneShot(this.$self_$34646.kaiser_cryFx);
																		if (175846 - 155080 == 20766)
																		{
																			goto IL_3B6;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1BB:
				goto IL_4F0;
				Block_20:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_3B6:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_25:
				IL_482:
				IL_4F0:
				return false;
			}

			// Token: 0x060055D3 RID: 21971 RVA: 0x00A6406C File Offset: 0x00A6226C
			internal static bool lsZraB54cA9gXuPabY5W()
			{
				return true;
			}

			// Token: 0x060055D4 RID: 21972 RVA: 0x00A64070 File Offset: 0x00A62270
			internal static bool xCYBXA54UOkF9H6dLgSp()
			{
				return false;
			}

			// Token: 0x04005EB7 RID: 24247
			internal Vector3 $mPos$34643;

			// Token: 0x04005EB8 RID: 24248
			internal Vector3 $mDir$34644;

			// Token: 0x04005EB9 RID: 24249
			internal UnityScript.Lang.Array $nArray$34645;

			// Token: 0x04005EBA RID: 24250
			internal KingKaiser $self_$34646;
		}
	}

	// Token: 0x02000ECB RID: 3787
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$34649 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060055D5 RID: 21973 RVA: 0x00A64074 File Offset: 0x00A62274
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$34649(UnityScript.Lang.Array nArray, KingKaiser self_)
		{
			if (204207 - 4087 != 200121)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (263456 - 158823 != 104634)
				{
					base..ctor();
					if (176423 - 562734 == -386311)
					{
						this.$nArray$34654 = nArray;
						if (64997 - 451353 == -386356)
						{
							this.$self_$34655 = self_;
							if (259346 - 195960 == 63386)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x00A64130 File Offset: 0x00A62330
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingKaiser.$RPC_dead$34649.$(this.$nArray$34654, this.$self_$34655);
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x00A64144 File Offset: 0x00A62344
		internal static bool JJTMhF54Tgrx8El1EDqc()
		{
			return true;
		}

		// Token: 0x060055D8 RID: 21976 RVA: 0x00A64148 File Offset: 0x00A62348
		internal static bool r9pvjn543GdhB21q6Bhs()
		{
			return false;
		}

		// Token: 0x04005EBB RID: 24251
		internal UnityScript.Lang.Array $nArray$34654;

		// Token: 0x04005EBC RID: 24252
		internal KingKaiser $self_$34655;

		// Token: 0x02000ECC RID: 3788
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060055D9 RID: 21977 RVA: 0x00A6414C File Offset: 0x00A6234C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, KingKaiser self_)
			{
				if (136859 - 56968 != 79892)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (122506 - 205112 != -82605)
					{
						base..ctor();
						if (100591 - 268524 != -167932)
						{
							this.$nArray$34652 = nArray;
							if (29193 - 582845 != -553651)
							{
								this.$self_$34653 = self_;
								if (36391 - 180676 != -144284)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060055DA RID: 21978 RVA: 0x00A64208 File Offset: 0x00A62408
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (232522 - 178693 != 53830)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_493;
					case 2:
						if (this.$self_$34653.mChar.actionState != "dead")
						{
							if (280503 - 504615 != -224112)
							{
								continue;
							}
							goto IL_49;
						}
						else
						{
							if (!this.$self_$34653.mChar.isPlayer)
							{
								if (91829 - 168630 != -76801)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$34653.gameObject);
								if (247981 - 297599 != -49618)
								{
									continue;
								}
							}
							else if (this.$self_$34653.mChar.isMine)
							{
								if (31830 - 99217 != -67387)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$34653.gameObject);
								if (114672 - 114270 != 402)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (126645 - 509333 != -382688)
							{
								continue;
							}
							goto IL_493;
						}
						break;
					default:
						if (93658 - 494590 == -400931)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34653.mChar.actionState == "dead")
					{
						if (146230 - 255465 != -109234)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$34650 = (Vector3)this.$nArray$34652[0];
						if (1689 - 132866 == -131177)
						{
							this.$myDirection$34651 = (Vector3)this.$nArray$34652[1];
							if (94793 - 506026 == -411233)
							{
								this.$self_$34653.transform.position = this.$myPosition$34650;
								if (289083 - 431368 != -142284)
								{
									this.$self_$34653.transform.LookAt(this.$myPosition$34650 + this.$myDirection$34651);
									if (26999 - 359365 != -332365)
									{
										this.$self_$34653.mChar.hp = 0;
										if (228297 - 310475 != -82177)
										{
											this.$self_$34653.mChar.actionState = "dead";
											if (286024 - 426010 == -139986)
											{
												this.$self_$34653.mChar.actionTime = Time.time;
												if (289786 - 347835 == -58049)
												{
													this.$self_$34653.mChar.myCommand = "none";
													if (188781 - 44829 != 143953)
													{
														this.$self_$34653.mChar.vMovement = Vector3.zero;
														if (294957 - 535168 == -240211)
														{
															this.$self_$34653.mChar.moveSpeed = (float)0;
															if (136762 - 67282 == 69480)
															{
																this.$self_$34653.animation.Rewind();
																if (225916 - 51700 != 174217)
																{
																	this.$self_$34653.animation.Play("ko");
																	if (251144 - 199523 == 51621)
																	{
																		this.$self_$34653.animation.wrapMode = WrapMode.Once;
																		if (214622 - 64858 != 149765)
																		{
																			if (!this.$self_$34653.kaiser_cryFx)
																			{
																				goto IL_444;
																			}
																			if (52739 - 417734 != -364994)
																			{
																				this.$self_$34653.audio.PlayOneShot(this.$self_$34653.kaiser_cryFx);
																				if (278882 - 471254 == -192372)
																				{
																					goto IL_444;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_49:
				goto IL_493;
				IL_444:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_493:
				return false;
			}

			// Token: 0x060055DB RID: 21979 RVA: 0x00A646BC File Offset: 0x00A628BC
			internal static bool YaghwH54X4crtINjdD5T()
			{
				return true;
			}

			// Token: 0x060055DC RID: 21980 RVA: 0x00A646C0 File Offset: 0x00A628C0
			internal static bool IK39KT54QOyM9J1FimRn()
			{
				return false;
			}

			// Token: 0x04005EBD RID: 24253
			internal Vector3 $myPosition$34650;

			// Token: 0x04005EBE RID: 24254
			internal Vector3 $myDirection$34651;

			// Token: 0x04005EBF RID: 24255
			internal UnityScript.Lang.Array $nArray$34652;

			// Token: 0x04005EC0 RID: 24256
			internal KingKaiser $self_$34653;
		}
	}
}
