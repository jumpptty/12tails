using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A4F RID: 2639
[Serializable]
public class Fungon : MonoBehaviour
{
	// Token: 0x060039CD RID: 14797 RVA: 0x0079030C File Offset: 0x0078E50C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Fungon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060039CE RID: 14798 RVA: 0x0079031C File Offset: 0x0078E51C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (27373 - 142408 != -115034)
		{
		}
		for (;;)
		{
			this.hq49WeF9Xg = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (9558 - 451355 != -441796)
			{
				this.hq49WeF9Xg.actionState = "standby";
				if (26024 - 222942 == -196918)
				{
					this.hq49WeF9Xg.actionTime = Time.time;
					if (71823 - 307305 != -235481)
					{
						this.hq49WeF9Xg.myCommand = "none";
						if (62498 - 167696 != -105197)
						{
							this.hq49WeF9Xg.hp = (this.hq49WeF9Xg.mhp = 870);
							if (189518 - 141121 != 48398)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060039CF RID: 14799 RVA: 0x00790440 File Offset: 0x0078E640
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.hq49WeF9Xg.isMine = true;
		}
	}

	// Token: 0x060039D0 RID: 14800 RVA: 0x0079045C File Offset: 0x0078E65C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (279260 - 206602 != 72658)
		{
		}
		for (;;)
		{
			if (this.hq49WeF9Xg.isControlled)
			{
				if (4826 - 300500 == -295673)
				{
					continue;
				}
				if (!(this.hq49WeF9Xg.actionState == "standby"))
				{
					if (36027 - 546156 != -510129)
					{
						continue;
					}
					if (!(this.hq49WeF9Xg.actionState == "run"))
					{
						goto IL_1FD;
					}
					if (273932 - 13468 != 260464)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (179056 - 292826 != -113770)
				{
					continue;
				}
			}
			IL_1FD:
			if (this.hq49WeF9Xg.hp > 0)
			{
				if (230284 - 16255 != 214029)
				{
					continue;
				}
				if (this.hq49WeF9Xg.ko > 0)
				{
					break;
				}
				if (210678 - 237105 != -26427)
				{
					continue;
				}
			}
			if (!(this.hq49WeF9Xg.actionState != "dead"))
			{
				break;
			}
			if (86898 - 458236 != -371337)
			{
				if (this.hq49WeF9Xg.isMine)
				{
					if (91827 - 149792 == -57965)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (42945 - 325675 == -282730)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (170204 - 356641 == -186437)
							{
								this.hq49WeF9Xg.DeadEvent();
								if (23309 - 257011 == -233702)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.hq49WeF9Xg.hp <= 0)
				{
					if (153576 - 333893 == -180317)
					{
						this.hq49WeF9Xg.hp = 1;
						if (208902 - 206868 == 2034)
						{
							break;
						}
					}
				}
				else
				{
					if (this.hq49WeF9Xg.ko > 0)
					{
						break;
					}
					if (28216 - 415860 != -387643)
					{
						this.hq49WeF9Xg.ko = 1;
						if (185397 - 93136 == 92261)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060039D1 RID: 14801 RVA: 0x00790748 File Offset: 0x0078E948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (163167 - 508635 != -345468)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (175825 - 584249 == -408424)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (111620 - 313472 != -201851 && 26581 - 430088 != -403506)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (266472 - 307806 != -41334)
						{
							continue;
						}
						v = 1;
						if (274304 - 55219 == 219086)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (148778 - 3472 == 145307)
						{
							continue;
						}
						v = -1;
						if (220948 - 248603 == -27654)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (115412 - 320322 != -204910)
						{
							continue;
						}
						v = 11;
						if (13338 - 327468 == -314129)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack_hit")
					{
						if (95454 - 206234 == -110779)
						{
							continue;
						}
						v = -11;
						if (227250 - 120100 == 107151)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (160656 - 48898 != 111758)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (69408 - 267970 == -198562)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (293463 - 47764 == 245699)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (175593 - 114551 == 61042)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (275761 - 471979 != -196217)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (183219 - 565036 == -381817)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (251065 - 329922 != -78856)
										{
											Hashtable hashtable = new Hashtable();
											if (84602 - 261196 == -176594)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (158958 - 157456 == 1502)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (73173 - 370371 == -297198)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (78114 - 573877 == -495763)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (185654 - 370593 != -184938)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (84408 - 418071 == -333663)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (47090 - 213393 == -166303)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (281217 - 447365 == -166148)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (249523 - 591933 == -342410)
																			{
																				PhotonClient.SendEvent(this.hq49WeF9Xg.ActorNr, 74, hashtable, true, true);
																				if (279442 - 193113 != 86330)
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

	// Token: 0x060039D2 RID: 14802 RVA: 0x00790C60 File Offset: 0x0078EE60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (208745 - 91173 != 117573)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (42881 - 374661 == -331780)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (235283 - 191066 == 44217)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (176276 - 254613 != -78336)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (188757 - 201871 != -13113)
						{
							int num3 = num;
							if (170091 - 384601 != -214509)
							{
								if (num3 == 1)
								{
									if (3142 - 426496 == -423354)
									{
										if (this.hq49WeF9Xg.isMine)
										{
											break;
										}
										if (249176 - 384492 == -135316)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (112727 - 446859 == -334132)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (46208 - 473766 != -427557)
									{
										if (this.hq49WeF9Xg.isMine)
										{
											break;
										}
										if (113698 - 126117 != -12418)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (133119 - 141649 == -8530)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (129287 - 518095 != -388807)
									{
										if (this.hq49WeF9Xg.isMine)
										{
											break;
										}
										if (143587 - 329717 == -186130)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (215088 - 575233 != -360144)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (33327 - 591052 != -557724)
									{
										if (this.hq49WeF9Xg.isMine)
										{
											break;
										}
										if (150492 - 71479 != 79014)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (2282 - 520143 == -517861)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (37599 - 424224 != -386624)
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

	// Token: 0x060039D3 RID: 14803 RVA: 0x00790FE4 File Offset: 0x0078F1E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (270585 - 244 != 270342)
		{
		}
		for (;;)
		{
			float num = this.hq49WeF9Xg.moveSpeed;
			if (223537 - 251518 != -27980)
			{
				float runSpeed = this.hq49WeF9Xg.runSpeed;
				if (280976 - 197059 == 83917)
				{
					Vector3 a = default(Vector3);
					if (74168 - 567546 == -493378)
					{
						Vector3 vector = Vector3.zero;
						if (85383 - 88814 != -3430)
						{
							float num2 = (float)0;
							if (94504 - 581389 == -486885)
							{
								if (this.hq49WeF9Xg.isMine)
								{
									if (78891 - 124033 != -45142)
									{
										continue;
									}
									if ((this.hq49WeF9Xg.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (39133 - 571688 != -532555)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (177383 - 340863 != -163480)
										{
											continue;
										}
										a.y = (float)0;
										if (16563 - 244443 == -227879)
										{
											continue;
										}
										a = a.normalized;
										if (16730 - 45436 != -28706)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (265110 - 513206 == -248095)
										{
											continue;
										}
										vector = vector.normalized;
										if (166410 - 441978 != -275568)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (291258 - 263887 != 27371)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (170474 - 137208 == 33267)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (210297 - 541123 != -330826)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (109757 - 182360 != -72603)
														{
															continue;
														}
														this.hq49WeF9Xg.actionState = "run";
														if (156184 - 373112 != -216928)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (41521 - 341635 != -300114)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (2150 - 205844 != -203694)
														{
															continue;
														}
														this.animation.Play("run");
														if (259552 - 269091 != -9539)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (115107 - 224646 != -109539)
														{
															continue;
														}
														goto IL_29C;
													}
												}
											}
										}
										this.hq49WeF9Xg.actionState = "standby";
										if (204678 - 3658 == 201021)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (162245 - 232716 != -70471)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (11374 - 62634 == -51259)
											{
												continue;
											}
											num = (float)0;
											if (285634 - 217119 == 68516)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (56032 - 120826 != -64794)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (84247 - 553439 == -469191)
										{
											continue;
										}
									}
									IL_29C:;
								}
								else
								{
									vector = global::Math.vFlat(this.hq49WeF9Xg.nPosition - this.transform.position);
									if (172978 - 575883 != -402905)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (102645 - 57915 == 44731)
									{
										continue;
									}
									if (this.hq49WeF9Xg.nSpeed != (float)0)
									{
										if (294268 - 47257 == 247012)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (141637 - 219098 != -77461)
											{
												continue;
											}
											this.transform.position = this.hq49WeF9Xg.nPosition;
											if (152210 - 40742 == 111469)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (204806 - 133007 != 71799)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (153983 - 22375 == 131609)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (132207 - 453101 != -320894)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.hq49WeF9Xg.nSpeed, (float)10 * Time.deltaTime);
												if (207270 - 172063 != 35207)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (203987 - 547247 == -343259)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (282854 - 490788 != -207934)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (223045 - 441315 != -218270)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (42987 - 121861 == -78873)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (52588 - 292049 != -239461)
											{
												continue;
											}
										}
										else if (Time.time > this.hq49WeF9Xg.nSpeed + 0.3f)
										{
											if (178554 - 424336 != -245782)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (284407 - 309722 == -25314)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (298300 - 306278 == -7977)
												{
													continue;
												}
												num = (float)0;
												if (37773 - 440226 == -402452)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.hq49WeF9Xg.nDirection);
											if (249241 - 98005 == 151237)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (246276 - 287213 == -40936)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (51816 - 452522 != -400706)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (22581 - 311246 != -288665)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (53367 - 52630 != 737)
											{
												continue;
											}
											this.transform.position = this.hq49WeF9Xg.nPosition;
											if (39897 - 217775 != -177878)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (204547 - 490897 != -286350)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (259284 - 43787 != 215497)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (9123 - 502257 == -493133)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (40909 - 233299 != -192390)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (25000 - 262525 != -237525)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (154025 - 137737 == 16289)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (267196 - 68997 == 198200)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.hq49WeF9Xg.nDirection);
											if (243734 - 136468 == 107267)
											{
												continue;
											}
											num = (float)0;
											if (89722 - 243549 != -153827)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (295733 - 117316 != 178417)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (123640 - 275484 == -151843)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (155782 - 528611 == -372828)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (69023 - 466709 != -397686)
										{
											continue;
										}
									}
								}
								this.hq49WeF9Xg.vMovement = vector;
								if (123594 - 226140 != -102545)
								{
									this.hq49WeF9Xg.moveSpeed = num;
									if (229848 - 38387 == 191461)
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

	// Token: 0x060039D4 RID: 14804 RVA: 0x00791B48 File Offset: 0x0078FD48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (294611 - 364455 != -69843)
		{
		}
		for (;;)
		{
			if (!this.hq49WeF9Xg.isMine)
			{
				if (64861 - 586582 != -521720)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (123434 - 353945 != -230510)
				{
					Vector3 vector = a - this.transform.position;
					if (200592 - 239718 != -39125)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (261175 - 48457 == 212718)
						{
							CharacterControl characterControl = null;
							if (169787 - 437257 != -267469)
							{
								if (194050 - 75146 == 118904)
								{
									if (gameObject)
									{
										if (297782 - 554101 == -256318)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (10558 - 99731 == -89172)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (144660 - 240473 != -95813)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (131935 - 314816 == -182880)
										{
											continue;
										}
									}
									if (!(this.hq49WeF9Xg.actionState == "standby"))
									{
										if (201822 - 269277 == -67454)
										{
											continue;
										}
										if (!(this.hq49WeF9Xg.actionState == "run"))
										{
											break;
										}
										if (75338 - 101216 == -25877)
										{
											continue;
										}
									}
									if (this.hq49WeF9Xg.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (106827 - 174288 != -67460)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (143631 - 235506 != -91874)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (253889 - 85865 == 168024)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (91449 - 408362 == -316913)
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

	// Token: 0x060039D5 RID: 14805 RVA: 0x00791E40 File Offset: 0x00790040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (30993 - 373125 != -342132)
		{
		}
		for (;;)
		{
			if (!this.hq49WeF9Xg.isMine)
			{
				if (215629 - 127486 == 88143)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (210569 - 31571 != 178999)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (295118 - 124072 != 171047)
					{
						Vector3 normalized = vector.normalized;
						if (61586 - 231477 == -169891)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (65598 - 257154 != -191555)
							{
								CharacterControl characterControl = null;
								if (87799 - 407636 != -319836)
								{
									int tID = 0;
									if (9031 - 107724 != -98692)
									{
										if (gameObject)
										{
											if (247896 - 267523 != -19627)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (186585 - 2213 != 184372)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (142444 - 90447 == 51998)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (4745 - 56110 != -51365)
											{
												continue;
											}
										}
										if (!(this.hq49WeF9Xg.actionState == "standby"))
										{
											if (114627 - 1563 != 113064)
											{
												continue;
											}
											if (!(this.hq49WeF9Xg.actionState == "run"))
											{
												break;
											}
											if (265783 - 15088 != 250695)
											{
												continue;
											}
										}
										if (this.hq49WeF9Xg.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (222122 - 124454 != 97669)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, tID));
											if (192775 - 157930 == 34845)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (250285 - 268647 == -18362)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, normalized, tID);
													if (21222 - 211649 != -190426)
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

	// Token: 0x060039D6 RID: 14806 RVA: 0x00792164 File Offset: 0x00790364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060039D7 RID: 14807 RVA: 0x00792168 File Offset: 0x00790368
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Fungon.$RPC_nAttack$30139(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060039D8 RID: 14808 RVA: 0x00792178 File Offset: 0x00790378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (42066 - 272580 != -230513)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (155100 - 329209 == -174109)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (1876 - 197768 == -195892)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (209487 - 295058 != -85570)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060039D9 RID: 14809 RVA: 0x00792230 File Offset: 0x00790430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Fungon.$RPC_cAttack$30151(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060039DA RID: 14810 RVA: 0x00792240 File Offset: 0x00790440
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (236852 - 315448 != -78596)
		{
		}
		for (;;)
		{
			if (this.cAttack_hit)
			{
				if (261023 - 595050 != -334026)
				{
					UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (148610 - 178003 == -29393)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find cAttack_hit effect");
				if (53275 - 489883 == -436608)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060039DB RID: 14811 RVA: 0x007922F8 File Offset: 0x007904F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Fungon.$RPC_dead$30167(nArray, this).GetEnumerator();
	}

	// Token: 0x060039DC RID: 14812 RVA: 0x00792308 File Offset: 0x00790508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060039DD RID: 14813 RVA: 0x0079230C File Offset: 0x0079050C
	internal static bool MuLCIf52ccUhSi3Q7GD0()
	{
		return true;
	}

	// Token: 0x060039DE RID: 14814 RVA: 0x00792310 File Offset: 0x00790510
	internal static bool MOKDc652Ujjcy6Yv5oAD()
	{
		return false;
	}

	// Token: 0x0400481B RID: 18459
	private CharacterControl hq49WeF9Xg;

	// Token: 0x0400481C RID: 18460
	public GameObject nAttack_ring;

	// Token: 0x0400481D RID: 18461
	public GameObject nAttack_hit;

	// Token: 0x0400481E RID: 18462
	public GameObject cAttack_ring;

	// Token: 0x0400481F RID: 18463
	public GameObject cAttack_hit;

	// Token: 0x04004820 RID: 18464
	public GameObject deadEffect;

	// Token: 0x02000A50 RID: 2640
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30139 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060039DF RID: 14815 RVA: 0x00792314 File Offset: 0x00790514
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30139(Vector3 mPos, Vector3 tDir, Fungon self_)
		{
			if (108031 - 395434 != -287402)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (86505 - 251417 == -164912)
				{
					base..ctor();
					if (91393 - 320631 != -229237)
					{
						this.$mPos$30148 = mPos;
						if (135547 - 501370 == -365823)
						{
							this.$tDir$30149 = tDir;
							if (229261 - 539214 != -309952)
							{
								this.$self_$30150 = self_;
								if (186409 - 176970 != 9440)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x007923F0 File Offset: 0x007905F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Fungon.$RPC_nAttack$30139.$(this.$mPos$30148, this.$tDir$30149, this.$self_$30150);
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x0079240C File Offset: 0x0079060C
		internal static bool hMlOlY52TNQL44irbLAi()
		{
			return true;
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x00792410 File Offset: 0x00790610
		internal static bool axg86R523MabuR39Dsum()
		{
			return false;
		}

		// Token: 0x04004821 RID: 18465
		internal Vector3 $mPos$30148;

		// Token: 0x04004822 RID: 18466
		internal Vector3 $tDir$30149;

		// Token: 0x04004823 RID: 18467
		internal Fungon $self_$30150;

		// Token: 0x02000A51 RID: 2641
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060039E3 RID: 14819 RVA: 0x00792414 File Offset: 0x00790614
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Fungon self_)
			{
				if (196516 - 292442 != -95926)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (189252 - 320349 == -131097)
					{
						base..ctor();
						if (187290 - 473032 == -285742)
						{
							this.$mPos$30145 = mPos;
							if (1587 - 35464 != -33876)
							{
								this.$tDir$30146 = tDir;
								if (13126 - 522872 != -509745)
								{
									this.$self_$30147 = self_;
									if (234853 - 220970 == 13883)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060039E4 RID: 14820 RVA: 0x007924F0 File Offset: 0x007906F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (9993 - 308310 != -298316)
				{
				}
				for (;;)
				{
					IL_4B0:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A00;
					case 2:
						if (this.$self_$30147.hq49WeF9Xg.actionState != "attack")
						{
							goto IL_93F;
						}
						if (19311 - 16459 == 2853)
						{
							continue;
						}
						if (this.$self_$30147.hq49WeF9Xg.myCommand != "nAttack")
						{
							if (181574 - 223044 != -41470)
							{
								continue;
							}
							goto IL_93F;
						}
						else
						{
							this.$self_$30147.hq49WeF9Xg.moveSpeed = (float)9;
							if (288659 - 526416 != -237756)
							{
								goto Block_58;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30147.hq49WeF9Xg.actionState != "attack")
						{
							goto IL_450;
						}
						if (295948 - 370433 != -74485)
						{
							continue;
						}
						if (this.$self_$30147.hq49WeF9Xg.myCommand != "nAttack")
						{
							if (176547 - 120881 != 55666)
							{
								continue;
							}
							goto IL_450;
						}
						else
						{
							this.$self_$30147.hq49WeF9Xg.moveSpeed = (float)3;
							if (283755 - 223443 != 60312)
							{
								continue;
							}
							if (!this.$self_$30147.hq49WeF9Xg.isMine)
							{
								goto IL_2D8;
							}
							if (239429 - 86390 != 153039)
							{
								continue;
							}
							this.$hitLayer$30140 = 130816 - (1 << this.$self_$30147.gameObject.layer);
							if (291022 - 429713 != -138691)
							{
								continue;
							}
							this.$hitList$30141 = Damage.FindRecTarget(this.$self_$30147.transform.position, this.$self_$30147.transform.forward, (float)1, (float)1, (float)2, (float)3, this.$hitLayer$30140);
							if (219354 - 575027 == -355672)
							{
								continue;
							}
							this.$$iterator$10600$30144 = UnityRuntimeServices.GetEnumerator(this.$hitList$30141);
							if (54622 - 528822 != -474200)
							{
								continue;
							}
							while (this.$$iterator$10600$30144.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10600$30144.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30142 = (GameObject)obj2;
								if (296189 - 116190 != 179999)
								{
									goto IL_4B0;
								}
								if (this.$self_$30147.hq49WeF9Xg.hit(1, this.$hitObject$30142, this.$self_$30147.hq49WeF9Xg.atk, 5, 0, this.$self_$30147.transform.forward) != 0)
								{
									if (18254 - 33354 != -15100)
									{
										goto IL_4B0;
									}
									this.$hitPos$30143 = this.$hitObject$30142.collider.ClosestPointOnBounds(this.$self_$30147.transform.position + Vector3.up);
									if (61245 - 390984 != -329739)
									{
										goto IL_4B0;
									}
									UnityRuntimeServices.Update(this.$$iterator$10600$30144, this.$hitObject$30142);
									if (70336 - 42289 == 28048)
									{
										goto IL_4B0;
									}
									this.$self_$30147.RPC_nAttack_hit(this.$hitPos$30143, this.$self_$30147.transform.forward, 0);
									if (218153 - 411788 == -193634)
									{
										goto IL_4B0;
									}
									if (PhotonClient.IsInitialized())
									{
										if (89909 - 426409 != -336500)
										{
											goto IL_4B0;
										}
										this.$self_$30147.ActionEvent("RPC_nAttack_hit", this.$hitPos$30143, this.$self_$30147.transform.forward, 0);
										if (109706 - 510328 != -400622)
										{
											goto IL_4B0;
										}
									}
								}
							}
							if (235934 - 286455 != -50520)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$30147.hq49WeF9Xg.actionState != "attack")
						{
							goto IL_602;
						}
						if (216729 - 500031 == -283301)
						{
							continue;
						}
						if (this.$self_$30147.hq49WeF9Xg.myCommand != "nAttack")
						{
							if (164717 - 442455 != -277737)
							{
								goto Block_61;
							}
							continue;
						}
						else
						{
							this.$self_$30147.hq49WeF9Xg.moveSpeed = (float)0;
							if (23866 - 529113 != -505247)
							{
								continue;
							}
							goto IL_633;
						}
						break;
					case 5:
						if (this.$self_$30147.hq49WeF9Xg.actionState == "attack")
						{
							if (273314 - 41979 == 231336)
							{
								continue;
							}
							if (this.$self_$30147.hq49WeF9Xg.myCommand == "nAttack")
							{
								if (228315 - 581700 != -353385)
								{
									continue;
								}
								this.$self_$30147.hq49WeF9Xg.actionState = "standby";
								if (89343 - 107107 != -17764)
								{
									continue;
								}
								this.$self_$30147.hq49WeF9Xg.actionTime = Time.time;
								if (209148 - 49859 == 159290)
								{
									continue;
								}
								this.$self_$30147.hq49WeF9Xg.myCommand = "none";
								if (119323 - 71289 != 48034)
								{
									continue;
								}
								if (!this.$self_$30147.hq49WeF9Xg.isMine)
								{
									if (209309 - 158303 == 51007)
									{
										continue;
									}
									this.$self_$30147.hq49WeF9Xg.nPosition = this.$self_$30147.transform.position;
									if (128927 - 149220 == -20292)
									{
										continue;
									}
									this.$self_$30147.hq49WeF9Xg.oPosition = this.$self_$30147.transform.position;
									if (185592 - 498514 == -312921)
									{
										continue;
									}
									this.$self_$30147.hq49WeF9Xg.nDirection = this.$self_$30147.transform.forward;
									if (235116 - 406517 != -171401)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (79429 - 311973 != -232544)
						{
							continue;
						}
						goto IL_A00;
					default:
						if (77720 - 270303 == -192582)
						{
							continue;
						}
						break;
					}
					this.$self_$30147.hq49WeF9Xg.actionState = "attack";
					if (291266 - 102947 == 188319)
					{
						this.$self_$30147.hq49WeF9Xg.actionTime = Time.time;
						if (101255 - 486946 == -385691)
						{
							this.$self_$30147.hq49WeF9Xg.myCommand = "nAttack";
							if (148527 - 48475 == 100052)
							{
								this.$self_$30147.hq49WeF9Xg.addTimeOut("nAttack", (float)3);
								if (239038 - 161914 == 77124)
								{
									this.$self_$30147.transform.position = this.$mPos$30145;
									if (228352 - 523364 != -295011)
									{
										this.$self_$30147.transform.LookAt(this.$mPos$30145 + global::Math.vFlat(this.$tDir$30146));
										if (261551 - 596383 != -334831)
										{
											this.$self_$30147.animation.Play("nAttack");
											if (277442 - 423272 != -145829)
											{
												this.$self_$30147.animation.wrapMode = WrapMode.Once;
												if (165265 - 230571 == -65306)
												{
													this.$self_$30147.hq49WeF9Xg.vMovement = this.$self_$30147.transform.forward;
													if (282312 - 174814 != 107499)
													{
														this.$self_$30147.hq49WeF9Xg.moveSpeed = (float)0;
														if (203176 - 67081 != 136096)
														{
															if (this.$self_$30147.nAttack_ring)
															{
																if (77930 - 549499 == -471569)
																{
																	this.$self_$30147.hq49WeF9Xg.createEffect(this.$self_$30147.nAttack_ring, this.$self_$30147.transform.position, this.$self_$30147.transform.rotation);
																	if (193013 - 543205 != -350191)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_ring effect");
																if (202841 - 404895 == -202054)
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
				IL_1B4:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_2D8:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_450:
				IL_602:
				goto IL_A00;
				IL_633:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_48:
				goto IL_2D8;
				IL_93F:
				goto IL_A00;
				Block_58:
				return this.Yield(3, new WaitForSeconds(0.4f));
				goto IL_1B4;
				Block_61:
				IL_A00:
				return false;
			}

			// Token: 0x060039E5 RID: 14821 RVA: 0x00792F10 File Offset: 0x00791110
			internal static bool ROmhtX52XnDBQAVEFYAJ()
			{
				return true;
			}

			// Token: 0x060039E6 RID: 14822 RVA: 0x00792F14 File Offset: 0x00791114
			internal static bool ChqwOT52QYl8DLX5FpA3()
			{
				return false;
			}

			// Token: 0x04004824 RID: 18468
			internal int $hitLayer$30140;

			// Token: 0x04004825 RID: 18469
			internal UnityScript.Lang.Array $hitList$30141;

			// Token: 0x04004826 RID: 18470
			internal GameObject $hitObject$30142;

			// Token: 0x04004827 RID: 18471
			internal Vector3 $hitPos$30143;

			// Token: 0x04004828 RID: 18472
			internal IEnumerator $$iterator$10600$30144;

			// Token: 0x04004829 RID: 18473
			internal Vector3 $mPos$30145;

			// Token: 0x0400482A RID: 18474
			internal Vector3 $tDir$30146;

			// Token: 0x0400482B RID: 18475
			internal Fungon $self_$30147;
		}
	}

	// Token: 0x02000A52 RID: 2642
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$30151 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x060039E7 RID: 14823 RVA: 0x00792F18 File Offset: 0x00791118
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$30151(Vector3 mPos, Vector3 tDir, int tID, Fungon self_)
		{
			if (118088 - 401139 != -283051)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (147093 - 147785 == -692)
				{
					base..ctor();
					if (190242 - 579451 == -389209)
					{
						this.$mPos$30163 = mPos;
						if (57072 - 100754 == -43682)
						{
							this.$tDir$30164 = tDir;
							if (58564 - 374557 != -315992)
							{
								this.$tID$30165 = tID;
								if (207447 - 182149 != 25299)
								{
									this.$self_$30166 = self_;
									if (185481 - 8199 == 177282)
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

		// Token: 0x060039E8 RID: 14824 RVA: 0x00793018 File Offset: 0x00791218
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new Fungon.$RPC_cAttack$30151.$(this.$mPos$30163, this.$tDir$30164, this.$tID$30165, this.$self_$30166);
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x00793038 File Offset: 0x00791238
		internal static bool tyAQsg52kXuQdZKGruUZ()
		{
			return true;
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x0079303C File Offset: 0x0079123C
		internal static bool jdJtNH52G6aKVaytdYjN()
		{
			return false;
		}

		// Token: 0x0400482C RID: 18476
		internal Vector3 $mPos$30163;

		// Token: 0x0400482D RID: 18477
		internal Vector3 $tDir$30164;

		// Token: 0x0400482E RID: 18478
		internal int $tID$30165;

		// Token: 0x0400482F RID: 18479
		internal Fungon $self_$30166;

		// Token: 0x02000A53 RID: 2643
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x060039EB RID: 14827 RVA: 0x00793040 File Offset: 0x00791240
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Fungon self_)
			{
				if (11342 - 405939 != -394596)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (247917 - 426199 == -178282)
					{
						base..ctor();
						if (27934 - 427983 == -400049)
						{
							this.$mPos$30159 = mPos;
							if (287296 - 188258 == 99038)
							{
								this.$tDir$30160 = tDir;
								if (148879 - 482015 != -333135)
								{
									this.$tID$30161 = tID;
									if (234502 - 558198 != -323695)
									{
										this.$self_$30162 = self_;
										if (18815 - 11634 != 7182)
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

			// Token: 0x060039EC RID: 14828 RVA: 0x00793140 File Offset: 0x00791340
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227300 - 382146 != -154845)
				{
				}
				for (;;)
				{
					IL_16E:
					switch (this._state)
					{
					case 0:
						goto IL_AAA;
					case 1:
						goto IL_C24;
					case 2:
						if (this.$self_$30162.hq49WeF9Xg.actionState != "attack")
						{
							goto IL_78;
						}
						if (66129 - 528468 != -462339)
						{
							continue;
						}
						if (this.$self_$30162.hq49WeF9Xg.myCommand != "cAttack")
						{
							if (269896 - 403883 != -133987)
							{
								continue;
							}
							goto IL_78;
						}
						else
						{
							this.$self_$30162.hq49WeF9Xg.moveSpeed = (float)5;
							if (114637 - 587589 != -472952)
							{
								continue;
							}
							this.$tObject$30152 = null;
							if (264097 - 56902 != 207195)
							{
								continue;
							}
							if (this.$tID$30161 != 0)
							{
								if (234647 - 485968 == -251320)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30161];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$30152 = (GameObject)obj2;
								if (228210 - 504592 != -276382)
								{
									continue;
								}
							}
							this.$mHitUpdate$30153 = Time.time + 0.1f;
							if (15598 - 87253 != -71655)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$30162.hq49WeF9Xg.actionState != "attack")
						{
							goto IL_A6B;
						}
						if (83224 - 275836 != -192612)
						{
							continue;
						}
						if (this.$self_$30162.hq49WeF9Xg.myCommand != "cAttack")
						{
							if (79306 - 79019 != 287)
							{
								continue;
							}
							goto IL_A6B;
						}
						break;
					case 4:
						if (this.$self_$30162.hq49WeF9Xg.actionState != "attack")
						{
							goto IL_267;
						}
						if (101712 - 22471 != 79241)
						{
							continue;
						}
						if (this.$self_$30162.hq49WeF9Xg.myCommand != "cAttack")
						{
							if (196057 - 398907 != -202850)
							{
								continue;
							}
							goto IL_267;
						}
						else
						{
							this.$self_$30162.hq49WeF9Xg.moveSpeed = (float)0;
							if (88365 - 317960 == -229594)
							{
								continue;
							}
							if (!this.$self_$30162.hq49WeF9Xg.isMine)
							{
								goto IL_8A1;
							}
							if (271027 - 338605 != -67578)
							{
								continue;
							}
							this.$self_$30162.hq49WeF9Xg.PositionEvent();
							if (272215 - 134741 != 137475)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$30162.hq49WeF9Xg.actionState == "attack")
						{
							if (63960 - 331277 == -267316)
							{
								continue;
							}
							if (this.$self_$30162.hq49WeF9Xg.myCommand == "cAttack")
							{
								if (293752 - 260728 == 33025)
								{
									continue;
								}
								this.$self_$30162.hq49WeF9Xg.actionState = "standby";
								if (244775 - 270758 == -25982)
								{
									continue;
								}
								this.$self_$30162.hq49WeF9Xg.actionTime = Time.time;
								if (189622 - 333991 != -144369)
								{
									continue;
								}
								this.$self_$30162.hq49WeF9Xg.myCommand = "none";
								if (197646 - 274736 != -77090)
								{
									continue;
								}
								if (!this.$self_$30162.hq49WeF9Xg.isMine)
								{
									if (130295 - 307836 != -177541)
									{
										continue;
									}
									this.$self_$30162.hq49WeF9Xg.nPosition = this.$self_$30162.transform.position;
									if (195589 - 424014 == -228424)
									{
										continue;
									}
									this.$self_$30162.hq49WeF9Xg.oPosition = this.$self_$30162.transform.position;
									if (196107 - 135910 != 60197)
									{
										continue;
									}
									this.$self_$30162.hq49WeF9Xg.nDirection = this.$self_$30162.transform.forward;
									if (128902 - 22467 != 106435)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (106118 - 486656 != -380538)
						{
							continue;
						}
						goto IL_C24;
					default:
						if (232468 - 421660 != -189192)
						{
							continue;
						}
						goto IL_AAA;
					}
					if (this.$self_$30162.hq49WeF9Xg.actionTime + 1.2f <= Time.time)
					{
						if (2396 - 85186 != -82790)
						{
							continue;
						}
						goto IL_3E7;
					}
					else
					{
						if (this.$tObject$30152)
						{
							if (190295 - 493388 != -303093)
							{
								continue;
							}
							this.$self_$30162.transform.LookAt(global::Math.cFlat(this.$tObject$30152.transform.position, this.$self_$30162.transform.position.y));
							if (12195 - 443225 == -431029)
							{
								continue;
							}
						}
						this.$self_$30162.hq49WeF9Xg.vMovement = this.$self_$30162.transform.forward;
						if (253449 - 344011 == -90561)
						{
							continue;
						}
						if (Time.time <= this.$mHitUpdate$30153)
						{
							goto IL_1E4;
						}
						if (295477 - 42311 != 253166)
						{
							continue;
						}
						this.$mHitUpdate$30153 = Time.time + 0.1f;
						if (217303 - 211177 != 6126)
						{
							continue;
						}
						if (!this.$self_$30162.hq49WeF9Xg.isMine)
						{
							goto IL_1E4;
						}
						if (285978 - 133822 == 152157)
						{
							continue;
						}
						this.$hitLayer$30154 = 130816 - (1 << this.$self_$30162.gameObject.layer);
						if (234053 - 276306 != -42253)
						{
							continue;
						}
						this.$hitList$30155 = Damage.FindAreaTarget(this.$self_$30162.transform.position, (float)3, (float)3, this.$hitLayer$30154);
						if (84407 - 152167 != -67760)
						{
							continue;
						}
						this.$$iterator$10601$30158 = UnityRuntimeServices.GetEnumerator(this.$hitList$30155);
						if (286570 - 310994 == -24423)
						{
							continue;
						}
						while (this.$$iterator$10601$30158.MoveNext())
						{
							object obj4;
							object obj3 = obj4 = this.$$iterator$10601$30158.Current;
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							this.$hitObject$30156 = (GameObject)obj4;
							if (7883 - 380607 != -372724)
							{
								goto IL_16E;
							}
							if (this.$self_$30162.hq49WeF9Xg.hit(1, this.$hitObject$30156, (int)(0.5f * (float)this.$self_$30162.hq49WeF9Xg.atk), 3, 0, Vector3.zero) != 0)
							{
								if (202903 - 281329 != -78426)
								{
									goto IL_16E;
								}
								this.$hitPos$30157 = this.$hitObject$30156.collider.ClosestPointOnBounds(this.$self_$30162.transform.position + Vector3.up);
								if (11163 - 308065 != -296902)
								{
									goto IL_16E;
								}
								UnityRuntimeServices.Update(this.$$iterator$10601$30158, this.$hitObject$30156);
								if (101807 - 243892 != -142085)
								{
									goto IL_16E;
								}
								this.$self_$30162.RPC_cAttack_hit(this.$hitPos$30157, this.$self_$30162.transform.forward, 0);
								if (116519 - 123959 == -7439)
								{
									goto IL_16E;
								}
								if (PhotonClient.IsInitialized())
								{
									if (213132 - 393509 == -180376)
									{
										goto IL_16E;
									}
									this.$self_$30162.ActionEvent("RPC_cAttack_hit", this.$hitPos$30157, this.$self_$30162.transform.forward, 0);
									if (198042 - 529550 != -331508)
									{
										goto IL_16E;
									}
								}
							}
						}
						if (289419 - 393300 != -103880)
						{
							goto Block_52;
						}
						continue;
					}
					IL_AAA:
					this.$self_$30162.hq49WeF9Xg.actionState = "attack";
					if (162280 - 412741 != -250460)
					{
						this.$self_$30162.hq49WeF9Xg.actionTime = Time.time;
						if (234502 - 347231 != -112728)
						{
							this.$self_$30162.hq49WeF9Xg.myCommand = "cAttack";
							if (249330 - 457784 == -208454)
							{
								this.$self_$30162.hq49WeF9Xg.addTimeOut("cAttack", (float)3);
								if (61864 - 585012 != -523147)
								{
									this.$self_$30162.transform.position = this.$mPos$30159;
									if (107688 - 145066 == -37378)
									{
										this.$self_$30162.transform.LookAt(this.$mPos$30159 + global::Math.vFlat(this.$tDir$30160));
										if (141508 - 11329 != 130180)
										{
											this.$self_$30162.animation.Play("cAttack");
											if (295891 - 307919 != -12027)
											{
												this.$self_$30162.animation.wrapMode = WrapMode.Once;
												if (119716 - 244967 != -125250)
												{
													this.$self_$30162.hq49WeF9Xg.vMovement = this.$self_$30162.transform.forward;
													if (167769 - 406560 == -238791)
													{
														this.$self_$30162.hq49WeF9Xg.moveSpeed = (float)0;
														if (147217 - 444762 == -297545)
														{
															if (this.$self_$30162.cAttack_ring)
															{
																if (55742 - 194264 == -138522)
																{
																	this.$self_$30162.hq49WeF9Xg.createEffect(this.$self_$30162.cAttack_ring, this.$self_$30162.transform.position, this.$self_$30162.transform.rotation);
																	if (297156 - 211034 == 86122)
																	{
																		goto IL_93F;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing cAttack_ring effect");
																if (189326 - 474564 != -285237)
																{
																	goto Block_62;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_78:
				goto IL_C24;
				IL_1E4:
				return this.Yield(3, new WaitForFixedUpdate());
				IL_267:
				goto IL_C24;
				Block_24:
				goto IL_8A1;
				IL_3E7:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_52:
				goto IL_1E4;
				IL_8A1:
				return this.Yield(5, new WaitForSeconds(0.7f));
				IL_8F0:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_93F:
				Block_62:
				goto IL_8F0;
				IL_A6B:
				IL_C24:
				return false;
			}

			// Token: 0x060039ED RID: 14829 RVA: 0x00793D84 File Offset: 0x00791F84
			internal static bool CNDDsg52HRH38eeNLfBU()
			{
				return true;
			}

			// Token: 0x060039EE RID: 14830 RVA: 0x00793D88 File Offset: 0x00791F88
			internal static bool pKAQYg52WPbuaC5EayeA()
			{
				return false;
			}

			// Token: 0x04004830 RID: 18480
			internal GameObject $tObject$30152;

			// Token: 0x04004831 RID: 18481
			internal float $mHitUpdate$30153;

			// Token: 0x04004832 RID: 18482
			internal int $hitLayer$30154;

			// Token: 0x04004833 RID: 18483
			internal UnityScript.Lang.Array $hitList$30155;

			// Token: 0x04004834 RID: 18484
			internal GameObject $hitObject$30156;

			// Token: 0x04004835 RID: 18485
			internal Vector3 $hitPos$30157;

			// Token: 0x04004836 RID: 18486
			internal IEnumerator $$iterator$10601$30158;

			// Token: 0x04004837 RID: 18487
			internal Vector3 $mPos$30159;

			// Token: 0x04004838 RID: 18488
			internal Vector3 $tDir$30160;

			// Token: 0x04004839 RID: 18489
			internal int $tID$30161;

			// Token: 0x0400483A RID: 18490
			internal Fungon $self_$30162;
		}
	}

	// Token: 0x02000A54 RID: 2644
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30167 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060039EF RID: 14831 RVA: 0x00793D8C File Offset: 0x00791F8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30167(UnityScript.Lang.Array nArray, Fungon self_)
		{
			if (243372 - 19330 != 224042)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (168848 - 120767 != 48082)
				{
					base..ctor();
					if (133271 - 182677 == -49406)
					{
						this.$nArray$30172 = nArray;
						if (36800 - 381767 != -344966)
						{
							this.$self_$30173 = self_;
							if (240777 - 551860 != -311082)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x00793E48 File Offset: 0x00792048
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Fungon.$RPC_dead$30167.$(this.$nArray$30172, this.$self_$30173);
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x00793E5C File Offset: 0x0079205C
		internal static bool BAF9y852Awd22o2bjEvh()
		{
			return true;
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x00793E60 File Offset: 0x00792060
		internal static bool dBhw2O52l57VoK3KdOYZ()
		{
			return false;
		}

		// Token: 0x0400483B RID: 18491
		internal UnityScript.Lang.Array $nArray$30172;

		// Token: 0x0400483C RID: 18492
		internal Fungon $self_$30173;

		// Token: 0x02000A55 RID: 2645
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060039F3 RID: 14835 RVA: 0x00793E64 File Offset: 0x00792064
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Fungon self_)
			{
				if (163126 - 212181 != -49054)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (276738 - 592447 == -315709)
					{
						base..ctor();
						if (135933 - 403244 == -267311)
						{
							this.$nArray$30170 = nArray;
							if (241224 - 168290 != 72935)
							{
								this.$self_$30171 = self_;
								if (248464 - 512962 == -264498)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060039F4 RID: 14836 RVA: 0x00793F20 File Offset: 0x00792120
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (252921 - 489388 != -236467)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4D2;
					case 2:
						if (this.$self_$30171.deadEffect)
						{
							if (56634 - 212784 != -156150)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$30171.deadEffect, this.$self_$30171.transform.position, this.$self_$30171.transform.rotation);
							if (183994 - 117643 == 66352)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing deadEffect gameObject");
							if (160713 - 16198 == 144516)
							{
								continue;
							}
						}
						if (this.$self_$30171.hq49WeF9Xg.actionState != "dead")
						{
							if (153174 - 94564 != 58610)
							{
								continue;
							}
							goto IL_24E;
						}
						else
						{
							if (!this.$self_$30171.hq49WeF9Xg.isPlayer)
							{
								if (126618 - 156603 == -29984)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$30171.gameObject);
								if (280607 - 529117 != -248510)
								{
									continue;
								}
							}
							else if (this.$self_$30171.hq49WeF9Xg.isMine)
							{
								if (1342 - 271097 == -269754)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30171.gameObject);
								if (106476 - 271050 != -164574)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (100678 - 560854 != -460175)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					default:
						if (136448 - 132256 == 4193)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30171.hq49WeF9Xg.actionState == "dead")
					{
						if (185958 - 356195 == -170237)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30168 = (Vector3)this.$nArray$30170[0];
						if (168892 - 279111 == -110219)
						{
							this.$myDirection$30169 = (Vector3)this.$nArray$30170[1];
							if (200206 - 459241 != -259034)
							{
								this.$self_$30171.transform.position = this.$myPosition$30168;
								if (34899 - 25480 != 9420)
								{
									this.$self_$30171.transform.LookAt(this.$myPosition$30168 + this.$myDirection$30169);
									if (290815 - 515110 != -224294)
									{
										this.$self_$30171.hq49WeF9Xg.hp = 0;
										if (205047 - 64633 != 140415)
										{
											this.$self_$30171.hq49WeF9Xg.actionState = "dead";
											if (2380 - 240133 == -237753)
											{
												this.$self_$30171.hq49WeF9Xg.actionTime = Time.time;
												if (176387 - 500142 == -323755)
												{
													this.$self_$30171.hq49WeF9Xg.myCommand = "none";
													if (217556 - 28873 != 188684)
													{
														this.$self_$30171.hq49WeF9Xg.vMovement = Vector3.zero;
														if (36322 - 356200 == -319878)
														{
															this.$self_$30171.hq49WeF9Xg.moveSpeed = (float)0;
															if (160618 - 233865 != -73246)
															{
																this.$self_$30171.animation.Rewind();
																if (139012 - 308622 != -169609)
																{
																	this.$self_$30171.animation.Play("ko");
																	if (110311 - 504616 == -394305)
																	{
																		this.$self_$30171.animation.wrapMode = WrapMode.Once;
																		if (22334 - 216281 != -193946)
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
				Block_14:
				IL_24E:
				goto IL_4D2;
				Block_26:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4D2:
				return false;
			}

			// Token: 0x060039F5 RID: 14837 RVA: 0x00794414 File Offset: 0x00792614
			internal static bool ArV8W652yrXUILUqrPXe()
			{
				return true;
			}

			// Token: 0x060039F6 RID: 14838 RVA: 0x00794418 File Offset: 0x00792618
			internal static bool VH3uYn52SC8GCWVp8J2y()
			{
				return false;
			}

			// Token: 0x0400483D RID: 18493
			internal Vector3 $myPosition$30168;

			// Token: 0x0400483E RID: 18494
			internal Vector3 $myDirection$30169;

			// Token: 0x0400483F RID: 18495
			internal UnityScript.Lang.Array $nArray$30170;

			// Token: 0x04004840 RID: 18496
			internal Fungon $self_$30171;
		}
	}
}
