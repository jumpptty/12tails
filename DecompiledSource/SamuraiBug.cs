using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001C3 RID: 451
[Serializable]
public class SamuraiBug : MonoBehaviour
{
	// Token: 0x06000A19 RID: 2585 RVA: 0x001032E0 File Offset: 0x001014E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SamuraiBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x001032F0 File Offset: 0x001014F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (168670 - 329618 != -160948)
		{
		}
		for (;;)
		{
			this.PLDQk88ojE = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (80683 - 448526 == -367843)
			{
				this.PLDQk88ojE.actionState = "standby";
				if (280681 - 243715 != 36967)
				{
					this.PLDQk88ojE.actionTime = Time.time;
					if (58941 - 455258 != -396316)
					{
						this.PLDQk88ojE.myCommand = "none";
						if (210043 - 527995 != -317951)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (68908 - 253136 == -184228)
							{
								this.PLDQk88ojE.isMine = true;
								if (115247 - 115025 == 222)
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

	// Token: 0x06000A1B RID: 2587 RVA: 0x00103428 File Offset: 0x00101628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (248501 - 111433 != 137069)
		{
		}
		for (;;)
		{
			if (this.PLDQk88ojE.isControlled)
			{
				if (78901 - 582078 == -503176)
				{
					continue;
				}
				if (!(this.PLDQk88ojE.actionState == "standby"))
				{
					if (115833 - 307317 != -191484)
					{
						continue;
					}
					if (!(this.PLDQk88ojE.actionState == "run"))
					{
						goto IL_124;
					}
					if (205012 - 28326 != 176686)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (154897 - 386695 == -231797)
				{
					continue;
				}
			}
			IL_124:
			if (this.PLDQk88ojE.hp <= 0)
			{
				if (21857 - 582300 == -560442)
				{
					continue;
				}
				if (this.PLDQk88ojE.actionState != "dead")
				{
					if (187648 - 317263 != -129615)
					{
						continue;
					}
					if (this.PLDQk88ojE.isMine)
					{
						if (292522 - 211454 != 81068)
						{
							continue;
						}
						statusClass status = this.PLDQk88ojE.getStatus("autoLife");
						if (276136 - 542644 == -266507)
						{
							continue;
						}
						if (status != null)
						{
							if (99460 - 394436 == -294975)
							{
								continue;
							}
							this.PLDQk88ojE.hp = 1;
							if (29130 - 430733 == -401602)
							{
								continue;
							}
							this.PLDQk88ojE.RPC_RemoveStatus("autoLife");
							if (50419 - 561830 == -511410)
							{
								continue;
							}
							this.PLDQk88ojE.RPC_createEffect("autoLife");
							if (27197 - 36657 == -9459)
							{
								continue;
							}
							this.PLDQk88ojE.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (248833 - 244516 != 4318)
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
							if (21841 - 270564 == -248722)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (200653 - 381797 != -181144)
							{
								continue;
							}
							this.PLDQk88ojE.DeadEvent();
							if (206168 - 486564 != -280395)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.PLDQk88ojE.hp = 1;
						if (230168 - 56419 != 173750)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.PLDQk88ojE.hp <= 0)
			{
				break;
			}
			if (82853 - 460683 != -377829)
			{
				if (this.PLDQk88ojE.ko > 0)
				{
					break;
				}
				if (194555 - 292247 != -97691)
				{
					if (!(this.PLDQk88ojE.actionState != "ko"))
					{
						break;
					}
					if (51823 - 379170 == -327347)
					{
						if (!(this.PLDQk88ojE.actionState != "dead"))
						{
							break;
						}
						if (51166 - 486025 != -434858)
						{
							if (this.PLDQk88ojE.isMine)
							{
								if (285224 - 351533 != -66308)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (263787 - 121864 == 141923)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (107766 - 266886 != -159119)
										{
											this.PLDQk88ojE.KoEvent();
											if (21734 - 541769 == -520035)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.PLDQk88ojE.ko = 1;
								if (254365 - 347894 != -93528)
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

	// Token: 0x06000A1C RID: 2588 RVA: 0x00103928 File Offset: 0x00101B28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (65857 - 210102 != -144245)
		{
		}
		for (;;)
		{
			float num = this.PLDQk88ojE.moveSpeed;
			if (152946 - 105818 != 47129)
			{
				float runSpeed = this.PLDQk88ojE.runSpeed;
				if (223442 - 77964 != 145479)
				{
					Vector3 a = default(Vector3);
					if (215864 - 207805 != 8060)
					{
						Vector3 vector = Vector3.zero;
						if (14401 - 52438 != -38036)
						{
							float num2 = (float)0;
							if (292674 - 387907 != -95232)
							{
								if (this.PLDQk88ojE.isMine)
								{
									if (174036 - 339632 == -165595)
									{
										continue;
									}
									if ((this.PLDQk88ojE.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (238835 - 172445 == 66391)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (68967 - 307402 != -238435)
										{
											continue;
										}
										a.y = (float)0;
										if (287940 - 71240 == 216701)
										{
											continue;
										}
										a = a.normalized;
										if (267036 - 444269 != -177233)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (76776 - 211258 != -134482)
										{
											continue;
										}
										vector = vector.normalized;
										if (108233 - 141573 != -33340)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (293373 - 282346 == 11028)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (234924 - 564699 == -329774)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (19816 - 60115 == -40298)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (56944 - 246537 == -189592)
														{
															continue;
														}
														this.PLDQk88ojE.actionState = "run";
														if (150951 - 34692 == 116260)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (79989 - 439861 != -359872)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (221797 - 544851 != -323054)
														{
															continue;
														}
														this.animation.Play("run");
														if (276178 - 275730 == 449)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (176482 - 65712 != 110771)
														{
															goto IL_1F0;
														}
														continue;
													}
												}
											}
										}
										this.PLDQk88ojE.actionState = "standby";
										if (170306 - 486054 == -315747)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (241639 - 451231 != -209592)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (15535 - 199506 == -183970)
											{
												continue;
											}
											num = (float)0;
											if (224144 - 440838 != -216694)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (295181 - 253426 == 41756)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (270079 - 17557 == 252523)
										{
											continue;
										}
									}
									IL_1F0:;
								}
								else
								{
									vector = global::Math.vFlat(this.PLDQk88ojE.nPosition - this.transform.position);
									if (57659 - 247856 == -190196)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (69416 - 347346 != -277930)
									{
										continue;
									}
									if (this.PLDQk88ojE.nSpeed != (float)0)
									{
										if (286444 - 110391 != 176053)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (38268 - 380138 == -341869)
											{
												continue;
											}
											this.transform.position = this.PLDQk88ojE.nPosition;
											if (284095 - 556930 == -272834)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (95760 - 483858 != -388098)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (157555 - 259717 != -102162)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (92045 - 211165 == -119119)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.PLDQk88ojE.nSpeed, (float)10 * Time.deltaTime);
												if (121840 - 273365 != -151525)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (180894 - 134717 != 46177)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (294656 - 321440 == -26783)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (130277 - 42687 == 87591)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (190132 - 341277 != -151145)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (123150 - 117864 == 5287)
											{
												continue;
											}
										}
										else if (Time.time > this.PLDQk88ojE.nSpeed + 0.3f)
										{
											if (46089 - 590272 == -544182)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (245302 - 200048 != 45254)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (58025 - 282893 == -224867)
												{
													continue;
												}
												num = (float)0;
												if (178992 - 430620 != -251628)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.PLDQk88ojE.nDirection);
											if (209877 - 453247 == -243369)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (30451 - 247729 != -217278)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (166088 - 275173 != -109085)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (125128 - 121792 != 3336)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (98217 - 34062 == 64156)
											{
												continue;
											}
											this.transform.position = this.PLDQk88ojE.nPosition;
											if (66173 - 549170 != -482997)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (136483 - 570925 != -434442)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (54693 - 525724 != -471031)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (78216 - 118921 != -40705)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (193700 - 46461 != 147239)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (251854 - 92350 != 159504)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (50982 - 408856 != -357874)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (24825 - 126143 != -101318)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.PLDQk88ojE.nDirection);
											if (5755 - 247420 == -241664)
											{
												continue;
											}
											num = (float)0;
											if (263266 - 404587 != -141321)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (31672 - 451281 == -419608)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (215946 - 348304 != -132358)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (217137 - 113821 == 103317)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (91947 - 387632 == -295684)
										{
											continue;
										}
									}
								}
								this.PLDQk88ojE.vMovement = vector;
								if (240680 - 120601 != 120080)
								{
									this.PLDQk88ojE.moveSpeed = num;
									if (160919 - 170844 == -9925)
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

	// Token: 0x06000A1D RID: 2589 RVA: 0x0010448C File Offset: 0x0010268C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (145570 - 229107 != -83537)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (8435 - 435569 != -427133)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (244958 - 155667 == 89291)
				{
					if (17238 - 526954 != -509715)
					{
						if (ActionName == "RPC_sword")
						{
							if (273030 - 176213 != 96817)
							{
								continue;
							}
							v = 1;
							if (299951 - 567570 == -267618)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_staff")
						{
							if (228432 - 355177 != -126745)
							{
								continue;
							}
							v = 2;
							if (136827 - 514116 == -377288)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_gun")
						{
							if (145957 - 61383 == 84575)
							{
								continue;
							}
							v = 3;
							if (196775 - 444856 == -248080)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_sword_hit")
						{
							if (99630 - 381500 == -281869)
							{
								continue;
							}
							v = -1;
							if (35344 - 261500 == -226155)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_gun_hit")
						{
							if (58711 - 235908 != -177197)
							{
								continue;
							}
							v = -3;
							if (93625 - 416296 != -322671)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (25373 - 292746 == -267373)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (185400 - 443058 != -257657)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (195460 - 345229 == -149769)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (288282 - 18324 != 269959)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (166779 - 284472 == -117693)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (220013 - 435203 == -215190)
											{
												Hashtable hashtable = new Hashtable();
												if (20926 - 220379 == -199453)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (51662 - 528592 == -476930)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (19638 - 346730 == -327092)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (242811 - 485915 != -243103)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (28528 - 185461 == -156933)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (243826 - 20931 != 222896)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (203551 - 581342 != -377790)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (254313 - 527196 == -272883)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (26575 - 496415 != -469839)
																				{
																					PhotonClient.SendEvent(this.PLDQk88ojE.ActorNr, 74, hashtable, true, true);
																					if (156307 - 581923 != -425615)
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

	// Token: 0x06000A1E RID: 2590 RVA: 0x001049C4 File Offset: 0x00102BC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (243667 - 555816 != -312149)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (143962 - 511711 == -367749)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (215703 - 27642 != 188062)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (286687 - 460183 != -173495)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (250158 - 147618 == 102540)
						{
							int num3 = num;
							if (39256 - 174662 != -135405)
							{
								if (num3 == 1)
								{
									if (146284 - 376110 == -229826)
									{
										if (this.PLDQk88ojE.isMine)
										{
											break;
										}
										if (214185 - 248132 == -33947)
										{
											this.StartCoroutine_Auto(this.RPC_sword(vector, vector2, num2));
											if (139295 - 551160 != -411864)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (108876 - 465717 != -356840)
									{
										if (this.PLDQk88ojE.isMine)
										{
											break;
										}
										if (30924 - 12257 != 18668)
										{
											this.StartCoroutine_Auto(this.RPC_staff(vector, vector2, num2));
											if (160329 - 337422 != -177092)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (253422 - 494248 != -240825)
									{
										if (this.PLDQk88ojE.isMine)
										{
											break;
										}
										if (140380 - 392231 == -251851)
										{
											this.StartCoroutine_Auto(this.RPC_gun(vector, vector2, num2));
											if (12765 - 93977 != -81211)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (247898 - 594236 != -346337)
									{
										if (this.PLDQk88ojE.isMine)
										{
											break;
										}
										if (238224 - 169836 != 68389)
										{
											this.RPC_sword_hit(vector, vector2, num2);
											if (29196 - 350422 == -321226)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -3)
								{
									if (286752 - 441733 != -154980)
									{
										if (this.PLDQk88ojE.isMine)
										{
											break;
										}
										if (203857 - 469986 != -266128)
										{
											this.RPC_gun_hit(vector, vector2, num2);
											if (191361 - 388741 == -197380)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (172610 - 253700 != -81089)
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

	// Token: 0x06000A1F RID: 2591 RVA: 0x00104DC4 File Offset: 0x00102FC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (150136 - 85858 != 64278)
		{
		}
		for (;;)
		{
			if (!this.PLDQk88ojE.isMine)
			{
				if (198822 - 460291 != -261468)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (117079 - 300642 == -183563)
				{
					Vector3 vector = a - this.transform.position;
					if (138308 - 204829 != -66520)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (17145 - 204940 == -187795)
						{
							if (!(this.PLDQk88ojE.actionState == "standby"))
							{
								if (52627 - 95276 == -42648)
								{
									continue;
								}
								if (!(this.PLDQk88ojE.actionState == "run"))
								{
									break;
								}
								if (143104 - 38768 != 104336)
								{
									continue;
								}
							}
							if (this.PLDQk88ojE.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (158387 - 40113 != 118275)
							{
								eSamuraiBugType samuraiBugType = this.SamuraiBugType;
								if (162610 - 184195 != -21584)
								{
									if (samuraiBugType == eSamuraiBugType.sword)
									{
										if (154895 - 60794 == 94101)
										{
											this.StartCoroutine_Auto(this.RPC_sword(this.transform.position, vector, 0));
											if (147997 - 339316 == -191319)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (297639 - 502569 != -204929)
												{
													this.ActionEvent("RPC_sword", this.transform.position, vector, 0);
													if (6843 - 61664 != -54820)
													{
														break;
													}
												}
											}
										}
									}
									else if (samuraiBugType == eSamuraiBugType.staff)
									{
										if (129212 - 494840 == -365628)
										{
											this.StartCoroutine_Auto(this.RPC_staff(this.transform.position, vector, 0));
											if (203790 - 497456 == -293666)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (236328 - 192797 != 43532)
												{
													this.ActionEvent("RPC_staff", this.transform.position, vector, 0);
													if (292227 - 240901 != 51327)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										if (samuraiBugType != eSamuraiBugType.gun)
										{
											break;
										}
										if (25615 - 7746 != 17870)
										{
											this.StartCoroutine_Auto(this.RPC_gun(this.transform.position, vector, 0));
											if (75962 - 319881 != -243918)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (103348 - 325150 == -221802)
												{
													this.ActionEvent("RPC_gun", this.transform.position, vector, 0);
													if (103036 - 322252 == -219216)
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

	// Token: 0x06000A20 RID: 2592 RVA: 0x00105190 File Offset: 0x00103390
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x00105194 File Offset: 0x00103394
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x00105198 File Offset: 0x00103398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_sword(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SamuraiBug.$RPC_sword$17028(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x001051A8 File Offset: 0x001033A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_sword_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.sword_hit)
		{
			UnityEngine.Object.Instantiate(this.sword_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x001051D4 File Offset: 0x001033D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_staff(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SamuraiBug.$RPC_staff$17042(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x001051E4 File Offset: 0x001033E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_gun(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SamuraiBug.$RPC_gun$17049(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x001051F4 File Offset: 0x001033F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_gun_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.gun_hit)
		{
			UnityEngine.Object.Instantiate(this.gun_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00105220 File Offset: 0x00103420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new SamuraiBug.$RPC_ko$17065(nArray, this).GetEnumerator();
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x00105230 File Offset: 0x00103430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new SamuraiBug.$RPC_dead$17072(nArray, this).GetEnumerator();
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x00105240 File Offset: 0x00103440
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x00105244 File Offset: 0x00103444
	internal static bool DUMl1vGgKWgg2cCA3dY()
	{
		return true;
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x00105248 File Offset: 0x00103448
	internal static bool mQZ6RiGffGVvjHAgglb()
	{
		return false;
	}

	// Token: 0x04000910 RID: 2320
	private CharacterControl PLDQk88ojE;

	// Token: 0x04000911 RID: 2321
	public eSamuraiBugType SamuraiBugType;

	// Token: 0x04000912 RID: 2322
	public GameObject sword_hit;

	// Token: 0x04000913 RID: 2323
	public GameObject gun_fire;

	// Token: 0x04000914 RID: 2324
	public GameObject gun_hit;

	// Token: 0x020001C4 RID: 452
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_sword$17028 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000A2C RID: 2604 RVA: 0x0010524C File Offset: 0x0010344C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_sword$17028(Vector3 mPos, Vector3 tDir, SamuraiBug self_)
		{
			if (18427 - 464962 != -446534)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (266170 - 78737 == 187433)
				{
					base..ctor();
					if (110930 - 416474 == -305544)
					{
						this.$mPos$17039 = mPos;
						if (206036 - 432446 != -226409)
						{
							this.$tDir$17040 = tDir;
							if (150837 - 387123 == -236286)
							{
								this.$self_$17041 = self_;
								if (96299 - 235987 != -139687)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00105328 File Offset: 0x00103528
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SamuraiBug.$RPC_sword$17028.$(this.$mPos$17039, this.$tDir$17040, this.$self_$17041);
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00105344 File Offset: 0x00103544
		internal static bool KxSbuuGn4KvXBm9he6M()
		{
			return true;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00105348 File Offset: 0x00103548
		internal static bool Yvrjp0G6XWMU66CnFvy()
		{
			return false;
		}

		// Token: 0x04000915 RID: 2325
		internal Vector3 $mPos$17039;

		// Token: 0x04000916 RID: 2326
		internal Vector3 $tDir$17040;

		// Token: 0x04000917 RID: 2327
		internal SamuraiBug $self_$17041;

		// Token: 0x020001C5 RID: 453
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000A30 RID: 2608 RVA: 0x0010534C File Offset: 0x0010354C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SamuraiBug self_)
			{
				if (189329 - 569215 != -379886)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (107413 - 316472 == -209059)
					{
						base..ctor();
						if (23598 - 22423 == 1175)
						{
							this.$mPos$17036 = mPos;
							if (124510 - 241127 == -116617)
							{
								this.$tDir$17037 = tDir;
								if (206279 - 87057 == 119222)
								{
									this.$self_$17038 = self_;
									if (255244 - 215525 != 39720)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000A31 RID: 2609 RVA: 0x00105428 File Offset: 0x00103628
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (33654 - 196551 != -162896)
				{
				}
				for (;;)
				{
					IL_A2:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_CEC;
					case 2:
						if (this.$self_$17038.PLDQk88ojE.actionState != "attack")
						{
							goto IL_C37;
						}
						if (114056 - 432291 != -318235)
						{
							continue;
						}
						if (this.$self_$17038.PLDQk88ojE.myCommand != "sword")
						{
							if (279430 - 108838 != 170592)
							{
								continue;
							}
							goto IL_C37;
						}
						else
						{
							this.$self_$17038.PLDQk88ojE.moveSpeed = (float)0;
							if (37672 - 212469 == -174796)
							{
								continue;
							}
							this.$hitLayer$17029 = 130816 - (1 << this.$self_$17038.gameObject.layer);
							if (30269 - 49910 != -19641)
							{
								continue;
							}
							this.$hitList$17030 = null;
							if (16498 - 424790 == -408291)
							{
								continue;
							}
							this.$hitPos$17031 = default(Vector3);
							if (2997 - 406574 != -403577)
							{
								continue;
							}
							if (!this.$self_$17038.PLDQk88ojE.isMine)
							{
								goto IL_2A4;
							}
							if (57194 - 160153 != -102959)
							{
								continue;
							}
							this.$hitList$17030 = Damage.FindRecTarget(this.$self_$17038.transform.position - this.$self_$17038.PLDQk88ojE.rangeMod * this.$self_$17038.transform.forward, this.$self_$17038.transform.forward, (float)2 * this.$self_$17038.PLDQk88ojE.rangeMod, (float)2 * this.$self_$17038.PLDQk88ojE.rangeMod, (float)5 * this.$self_$17038.PLDQk88ojE.rangeMod, (float)2 * this.$self_$17038.PLDQk88ojE.rangeMod, this.$hitLayer$17029);
							if (237246 - 321902 == -84655)
							{
								continue;
							}
							this.$$iterator$10002$17033 = UnityRuntimeServices.GetEnumerator(this.$hitList$17030);
							if (107960 - 35141 == 72820)
							{
								continue;
							}
							while (this.$$iterator$10002$17033.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10002$17033.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17032 = (GameObject)obj2;
								if (142111 - 90772 == 51340)
								{
									goto IL_A2;
								}
								if (this.$self_$17038.PLDQk88ojE.hit(1, this.$hitObject$17032, (int)(0.5f * (float)this.$self_$17038.PLDQk88ojE.atk), 1, 0, 0.5f * (this.$hitObject$17032.transform.position - this.$self_$17038.transform.position).normalized) != 0)
								{
									if (50617 - 279446 != -228829)
									{
										goto IL_A2;
									}
									this.$hitPos$17031 = this.$hitObject$17032.collider.ClosestPointOnBounds(this.$self_$17038.transform.position + 0.3f * Vector3.up);
									if (263151 - 152211 != 110940)
									{
										goto IL_A2;
									}
									UnityRuntimeServices.Update(this.$$iterator$10002$17033, this.$hitObject$17032);
									if (241581 - 216460 != 25121)
									{
										goto IL_A2;
									}
									this.$self_$17038.RPC_sword_hit(this.$hitPos$17031, this.$self_$17038.transform.forward, 0);
									if (113264 - 368998 != -255734)
									{
										goto IL_A2;
									}
									this.$self_$17038.ActionEvent("RPC_sword_hit", this.$hitPos$17031, this.$self_$17038.transform.forward, 0);
									if (2632 - 213133 == -210500)
									{
										goto IL_A2;
									}
									this.$self_$17038.PLDQk88ojE.sp = this.$self_$17038.PLDQk88ojE.sp + 1;
									if (257931 - 93131 == 164801)
									{
										goto IL_A2;
									}
								}
							}
							if (157474 - 350478 != -193003)
							{
								goto Block_68;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17038.PLDQk88ojE.actionState != "attack")
						{
							goto IL_3D8;
						}
						if (175061 - 51303 == 123759)
						{
							continue;
						}
						if (this.$self_$17038.PLDQk88ojE.myCommand != "sword")
						{
							if (34478 - 374759 != -340281)
							{
								continue;
							}
							goto IL_3D8;
						}
						else
						{
							this.$self_$17038.PLDQk88ojE.moveSpeed = (float)0;
							if (78162 - 2471 != 75691)
							{
								continue;
							}
							if (!this.$self_$17038.PLDQk88ojE.isMine)
							{
								goto IL_1A;
							}
							if (251012 - 4748 != 246264)
							{
								continue;
							}
							this.$hitList$17030 = Damage.FindRecTarget(this.$self_$17038.transform.position - this.$self_$17038.PLDQk88ojE.rangeMod * this.$self_$17038.transform.forward, this.$self_$17038.transform.forward, (float)2 * this.$self_$17038.PLDQk88ojE.rangeMod, (float)2 * this.$self_$17038.PLDQk88ojE.rangeMod, (float)5 * this.$self_$17038.PLDQk88ojE.rangeMod, (float)2 * this.$self_$17038.PLDQk88ojE.rangeMod, this.$hitLayer$17029);
							if (144657 - 134888 == 9770)
							{
								continue;
							}
							this.$$iterator$10003$17035 = UnityRuntimeServices.GetEnumerator(this.$hitList$17030);
							if (12820 - 580605 == -567784)
							{
								continue;
							}
							while (this.$$iterator$10003$17035.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10003$17035.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$17034 = (GameObject)obj4;
								if (134465 - 596522 != -462057)
								{
									goto IL_A2;
								}
								if (this.$self_$17038.PLDQk88ojE.hit(1, this.$hitObject$17034, (int)(0.5f * (float)this.$self_$17038.PLDQk88ojE.atk), 1, 0, -0.5f * (this.$hitObject$17034.transform.position - this.$self_$17038.transform.position).normalized) != 0)
								{
									if (8680 - 302459 != -293779)
									{
										goto IL_A2;
									}
									this.$hitPos$17031 = this.$hitObject$17034.collider.ClosestPointOnBounds(this.$self_$17038.transform.position + 0.3f * Vector3.up);
									if (174168 - 490968 == -316799)
									{
										goto IL_A2;
									}
									UnityRuntimeServices.Update(this.$$iterator$10003$17035, this.$hitObject$17034);
									if (29302 - 265404 == -236101)
									{
										goto IL_A2;
									}
									this.$self_$17038.RPC_sword_hit(this.$hitPos$17031, this.$self_$17038.transform.forward, 0);
									if (231742 - 502793 == -271050)
									{
										goto IL_A2;
									}
									this.$self_$17038.ActionEvent("RPC_sword_hit", this.$hitPos$17031, this.$self_$17038.transform.forward, 0);
									if (206486 - 270624 == -64137)
									{
										goto IL_A2;
									}
									this.$self_$17038.PLDQk88ojE.sp = this.$self_$17038.PLDQk88ojE.sp + 1;
									if (214771 - 362315 != -147544)
									{
										goto IL_A2;
									}
								}
							}
							if (196054 - 136412 != 59643)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17038.PLDQk88ojE.actionState == "attack")
						{
							if (76875 - 302792 == -225916)
							{
								continue;
							}
							if (this.$self_$17038.PLDQk88ojE.myCommand == "sword")
							{
								if (88961 - 464159 == -375197)
								{
									continue;
								}
								this.$self_$17038.PLDQk88ojE.actionState = "standby";
								if (664 - 13156 != -12492)
								{
									continue;
								}
								this.$self_$17038.PLDQk88ojE.actionTime = Time.time;
								if (52570 - 386649 != -334079)
								{
									continue;
								}
								this.$self_$17038.PLDQk88ojE.myCommand = "none";
								if (246019 - 66205 == 179815)
								{
									continue;
								}
								if (!this.$self_$17038.PLDQk88ojE.isMine)
								{
									if (182739 - 129388 == 53352)
									{
										continue;
									}
									this.$self_$17038.PLDQk88ojE.nPosition = this.$self_$17038.transform.position;
									if (111234 - 439287 != -328053)
									{
										continue;
									}
									this.$self_$17038.PLDQk88ojE.oPosition = this.$self_$17038.transform.position;
									if (196726 - 387416 == -190689)
									{
										continue;
									}
									this.$self_$17038.PLDQk88ojE.nDirection = this.$self_$17038.transform.forward;
									if (220122 - 528721 == -308598)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (74981 - 113355 != -38373)
						{
							goto Block_54;
						}
						continue;
					default:
						if (232781 - 236079 != -3298)
						{
							continue;
						}
						break;
					}
					this.$self_$17038.PLDQk88ojE.actionState = "attack";
					if (52913 - 474323 == -421410)
					{
						this.$self_$17038.PLDQk88ojE.actionTime = Time.time;
						if (216125 - 403465 != -187339)
						{
							this.$self_$17038.PLDQk88ojE.myCommand = "sword";
							if (86118 - 362679 != -276560)
							{
								this.$self_$17038.PLDQk88ojE.addTimeOut("nAttack", (float)2);
								if (293637 - 197227 != 96411)
								{
									this.$self_$17038.transform.position = this.$mPos$17036;
									if (117442 - 37037 != 80406)
									{
										this.$self_$17038.transform.LookAt(this.$mPos$17036 + global::Math.vFlat(this.$tDir$17037));
										if (125250 - 419403 != -294152)
										{
											this.$self_$17038.animation.CrossFade("sword");
											if (293957 - 363666 == -69709)
											{
												this.$self_$17038.animation.wrapMode = WrapMode.Once;
												if (57964 - 23915 == 34049)
												{
													this.$self_$17038.PLDQk88ojE.vMovement = this.$self_$17038.transform.forward;
													if (53684 - 395719 == -342035)
													{
														this.$self_$17038.PLDQk88ojE.moveSpeed = (float)0;
														if (162498 - 511126 != -348627)
														{
															goto Block_14;
														}
													}
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
				Block_13:
				goto IL_1A;
				Block_14:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_2A4:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_3D8:
				Block_54:
				IL_C37:
				goto IL_CEC;
				Block_68:
				goto IL_2A4;
				IL_CEC:
				return false;
			}

			// Token: 0x06000A32 RID: 2610 RVA: 0x00106134 File Offset: 0x00104334
			internal static bool TrAvHUGib2wo8yrIMog()
			{
				return true;
			}

			// Token: 0x06000A33 RID: 2611 RVA: 0x00106138 File Offset: 0x00104338
			internal static bool Tt1FMPGKrjgdoZ2XtBX()
			{
				return false;
			}

			// Token: 0x04000918 RID: 2328
			internal int $hitLayer$17029;

			// Token: 0x04000919 RID: 2329
			internal UnityScript.Lang.Array $hitList$17030;

			// Token: 0x0400091A RID: 2330
			internal Vector3 $hitPos$17031;

			// Token: 0x0400091B RID: 2331
			internal GameObject $hitObject$17032;

			// Token: 0x0400091C RID: 2332
			internal IEnumerator $$iterator$10002$17033;

			// Token: 0x0400091D RID: 2333
			internal GameObject $hitObject$17034;

			// Token: 0x0400091E RID: 2334
			internal IEnumerator $$iterator$10003$17035;

			// Token: 0x0400091F RID: 2335
			internal Vector3 $mPos$17036;

			// Token: 0x04000920 RID: 2336
			internal Vector3 $tDir$17037;

			// Token: 0x04000921 RID: 2337
			internal SamuraiBug $self_$17038;
		}
	}

	// Token: 0x020001C6 RID: 454
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_staff$17042 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000A34 RID: 2612 RVA: 0x0010613C File Offset: 0x0010433C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_staff$17042(Vector3 mPos, Vector3 tDir, SamuraiBug self_)
		{
			if (104990 - 461266 != -356276)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (157581 - 232860 == -75279)
				{
					base..ctor();
					if (270873 - 376851 == -105978)
					{
						this.$mPos$17046 = mPos;
						if (292279 - 122046 != 170234)
						{
							this.$tDir$17047 = tDir;
							if (15050 - 445702 == -430652)
							{
								this.$self_$17048 = self_;
								if (168590 - 145303 != 23288)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00106218 File Offset: 0x00104418
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SamuraiBug.$RPC_staff$17042.$(this.$mPos$17046, this.$tDir$17047, this.$self_$17048);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00106234 File Offset: 0x00104434
		internal static bool U94K2hGdCiunjZQF7Bt()
		{
			return true;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00106238 File Offset: 0x00104438
		internal static bool DR1iE6GJwq2QOEsgeNF()
		{
			return false;
		}

		// Token: 0x04000922 RID: 2338
		internal Vector3 $mPos$17046;

		// Token: 0x04000923 RID: 2339
		internal Vector3 $tDir$17047;

		// Token: 0x04000924 RID: 2340
		internal SamuraiBug $self_$17048;

		// Token: 0x020001C7 RID: 455
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000A38 RID: 2616 RVA: 0x0010623C File Offset: 0x0010443C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SamuraiBug self_)
			{
				if (162044 - 529552 != -367507)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154051 - 116291 != 37761)
					{
						base..ctor();
						if (19277 - 139529 != -120251)
						{
							this.$mPos$17043 = mPos;
							if (73881 - 425953 == -352072)
							{
								this.$tDir$17044 = tDir;
								if (104966 - 139077 == -34111)
								{
									this.$self_$17045 = self_;
									if (39991 - 550301 != -510309)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000A39 RID: 2617 RVA: 0x00106318 File Offset: 0x00104518
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (208558 - 307914 != -99355)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5F6;
					case 2:
						if (this.$self_$17045.PLDQk88ojE.actionState != "attack")
						{
							goto IL_4AE;
						}
						if (103094 - 380442 != -277348)
						{
							continue;
						}
						if (this.$self_$17045.PLDQk88ojE.myCommand != "staff")
						{
							if (281557 - 253911 != 27647)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$self_$17045.PLDQk88ojE.moveSpeed = (float)2;
							if (184190 - 272608 == -88417)
							{
								continue;
							}
							if (this.$self_$17045.PLDQk88ojE.isMine && 222519 - 171995 != 50524)
							{
								continue;
							}
							goto IL_1BA;
						}
						break;
					case 3:
						if (this.$self_$17045.PLDQk88ojE.actionState != "attack")
						{
							goto IL_596;
						}
						if (12148 - 392154 != -380006)
						{
							continue;
						}
						if (this.$self_$17045.PLDQk88ojE.myCommand != "staff")
						{
							if (234299 - 80046 != 154253)
							{
								continue;
							}
							goto IL_596;
						}
						else
						{
							this.$self_$17045.PLDQk88ojE.moveSpeed = (float)0;
							if (228172 - 299340 != -71167)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17045.PLDQk88ojE.actionState == "attack")
						{
							if (69229 - 224394 == -155164)
							{
								continue;
							}
							if (this.$self_$17045.PLDQk88ojE.myCommand == "staff")
							{
								if (231610 - 235999 != -4389)
								{
									continue;
								}
								this.$self_$17045.PLDQk88ojE.actionState = "standby";
								if (180874 - 295978 != -115104)
								{
									continue;
								}
								this.$self_$17045.PLDQk88ojE.actionTime = Time.time;
								if (125488 - 124155 != 1333)
								{
									continue;
								}
								this.$self_$17045.PLDQk88ojE.myCommand = "none";
								if (235889 - 21747 == 214143)
								{
									continue;
								}
								if (!this.$self_$17045.PLDQk88ojE.isMine)
								{
									if (251336 - 170317 != 81019)
									{
										continue;
									}
									this.$self_$17045.PLDQk88ojE.nPosition = this.$self_$17045.transform.position;
									if (188937 - 441259 == -252321)
									{
										continue;
									}
									this.$self_$17045.PLDQk88ojE.oPosition = this.$self_$17045.transform.position;
									if (166233 - 591733 != -425500)
									{
										continue;
									}
									this.$self_$17045.PLDQk88ojE.nDirection = this.$self_$17045.transform.forward;
									if (48609 - 277715 == -229105)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (43876 - 513119 != -469242)
						{
							goto Block_36;
						}
						continue;
					default:
						if (59452 - 151678 == -92225)
						{
							continue;
						}
						break;
					}
					this.$self_$17045.PLDQk88ojE.actionState = "attack";
					if (175585 - 289932 == -114347)
					{
						this.$self_$17045.PLDQk88ojE.actionTime = Time.time;
						if (21773 - 105849 == -84076)
						{
							this.$self_$17045.PLDQk88ojE.myCommand = "staff";
							if (99859 - 534050 == -434191)
							{
								this.$self_$17045.PLDQk88ojE.addTimeOut("nAttack", (float)3);
								if (1821 - 529596 == -527775)
								{
									this.$self_$17045.transform.position = this.$mPos$17043;
									if (17799 - 226571 == -208772)
									{
										this.$self_$17045.transform.LookAt(this.$mPos$17043 + global::Math.vFlat(this.$tDir$17044));
										if (44162 - 396395 != -352232)
										{
											this.$self_$17045.animation.CrossFade("staff");
											if (289150 - 395472 == -106322)
											{
												this.$self_$17045.animation.wrapMode = WrapMode.Once;
												if (422 - 59281 != -58858)
												{
													this.$self_$17045.PLDQk88ojE.vMovement = this.$self_$17045.transform.forward;
													if (105711 - 433882 != -328170)
													{
														this.$self_$17045.PLDQk88ojE.moveSpeed = (float)0;
														if (111864 - 379753 == -267889)
														{
															goto IL_45F;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1BA:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_21:
				goto IL_4AE;
				IL_45F:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_4AE:
				Block_36:
				IL_596:
				goto IL_5F6;
				Block_37:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_5F6:
				return false;
			}

			// Token: 0x06000A3A RID: 2618 RVA: 0x00106930 File Offset: 0x00104B30
			internal static bool kQ9c87GDBlCydvpePT1()
			{
				return true;
			}

			// Token: 0x06000A3B RID: 2619 RVA: 0x00106934 File Offset: 0x00104B34
			internal static bool PxSOVaGvTUJ3hl5U47L()
			{
				return false;
			}

			// Token: 0x04000925 RID: 2341
			internal Vector3 $mPos$17043;

			// Token: 0x04000926 RID: 2342
			internal Vector3 $tDir$17044;

			// Token: 0x04000927 RID: 2343
			internal SamuraiBug $self_$17045;
		}
	}

	// Token: 0x020001C8 RID: 456
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_gun$17049 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000A3C RID: 2620 RVA: 0x00106938 File Offset: 0x00104B38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_gun$17049(Vector3 mPos, Vector3 tDir, int tID, SamuraiBug self_)
		{
			if (237107 - 283304 != -46196)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (64221 - 213143 == -148922)
				{
					base..ctor();
					if (238281 - 353294 != -115012)
					{
						this.$mPos$17061 = mPos;
						if (76001 - 76763 != -761)
						{
							this.$tDir$17062 = tDir;
							if (292727 - 258237 != 34491)
							{
								this.$tID$17063 = tID;
								if (248212 - 265849 != -17636)
								{
									this.$self_$17064 = self_;
									if (234231 - 231849 != 2383)
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

		// Token: 0x06000A3D RID: 2621 RVA: 0x00106A38 File Offset: 0x00104C38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SamuraiBug.$RPC_gun$17049.$(this.$mPos$17061, this.$tDir$17062, this.$tID$17063, this.$self_$17064);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00106A58 File Offset: 0x00104C58
		internal static bool mBxmZBGRlUIvlWQ4fan()
		{
			return true;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00106A5C File Offset: 0x00104C5C
		internal static bool lxkSjUGwcGpa9mqmh6a()
		{
			return false;
		}

		// Token: 0x04000928 RID: 2344
		internal Vector3 $mPos$17061;

		// Token: 0x04000929 RID: 2345
		internal Vector3 $tDir$17062;

		// Token: 0x0400092A RID: 2346
		internal int $tID$17063;

		// Token: 0x0400092B RID: 2347
		internal SamuraiBug $self_$17064;

		// Token: 0x020001C9 RID: 457
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000A40 RID: 2624 RVA: 0x00106A60 File Offset: 0x00104C60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, SamuraiBug self_)
			{
				if (159462 - 198541 != -39079)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (156728 - 347765 != -191036)
					{
						base..ctor();
						if (131500 - 64968 != 66533)
						{
							this.$mPos$17057 = mPos;
							if (40734 - 537203 == -496469)
							{
								this.$tDir$17058 = tDir;
								if (164940 - 436151 != -271210)
								{
									this.$tID$17059 = tID;
									if (82652 - 127828 == -45176)
									{
										this.$self_$17060 = self_;
										if (18833 - 245216 != -226382)
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

			// Token: 0x06000A41 RID: 2625 RVA: 0x00106B60 File Offset: 0x00104D60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (141823 - 366356 != -224532)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A94;
					case 2:
						if (this.$self_$17060.PLDQk88ojE.actionState != "attack")
						{
							goto IL_4BA;
						}
						if (141317 - 318371 == -177053)
						{
							continue;
						}
						if (this.$self_$17060.PLDQk88ojE.myCommand != "gun")
						{
							if (221313 - 295435 != -74122)
							{
								continue;
							}
							goto IL_4BA;
						}
						else
						{
							this.$firePos$17050 = this.$mPos$17057 + this.$self_$17060.transform.TransformDirection(0.07f, 0.3f, 0.65f);
							if (96770 - 139795 == -43024)
							{
								continue;
							}
							this.$fireDir$17051 = this.$tDir$17058 - this.$self_$17060.transform.TransformDirection(0.07f, 0.3f, 0.65f);
							if (277853 - 77775 == 200079)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$17059];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$17052 = (GameObject)obj2;
							if (97490 - 264753 == -167262)
							{
								continue;
							}
							if (this.$tObject$17052)
							{
								if (161078 - 192600 == -31521)
								{
									continue;
								}
								this.$fireDir$17051 = (this.$tObject$17052.collider.bounds.center - this.$firePos$17050).normalized;
								if (285021 - 515240 != -230219)
								{
									continue;
								}
							}
							this.$fireRot$17053 = Quaternion.LookRotation(this.$fireDir$17051);
							if (65031 - 290357 != -225326)
							{
								continue;
							}
							goto IL_85A;
						}
						break;
					case 3:
						if (this.$self_$17060.PLDQk88ojE.actionState != "attack")
						{
							goto IL_69;
						}
						if (66510 - 593642 == -527131)
						{
							continue;
						}
						if (this.$self_$17060.PLDQk88ojE.myCommand != "gun")
						{
							if (37823 - 42850 != -5027)
							{
								continue;
							}
							goto IL_69;
						}
						else
						{
							this.$self_$17060.PLDQk88ojE.moveSpeed = (float)-3;
							if (13162 - 71543 != -58381)
							{
								continue;
							}
							if (this.$self_$17060.gun_fire)
							{
								if (283446 - 77404 == 206043)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$17060.gun_fire, this.$firePos$17050, this.$fireRot$17053);
								if (27950 - 59032 == -31081)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find gun_fire Effect");
								if (216066 - 226200 == -10133)
								{
									continue;
								}
							}
							if (!this.$self_$17060.PLDQk88ojE.isMine)
							{
								goto IL_32F;
							}
							if (172489 - 96822 == 75668)
							{
								continue;
							}
							this.$hitLayer$17054 = ~((1 << this.$self_$17060.gameObject.layer) + 2 + 4);
							if (190649 - 429338 == -238688)
							{
								continue;
							}
							this.$hit$17055 = default(RaycastHit);
							if (147400 - 223865 != -76465)
							{
								continue;
							}
							if (!Physics.Raycast(this.$firePos$17050, this.$fireDir$17051, out this.$hit$17055, (float)30, this.$hitLayer$17054))
							{
								goto IL_32F;
							}
							if (172697 - 412485 != -239788)
							{
								continue;
							}
							this.$self_$17060.RPC_gun_hit(this.$hit$17055.point, this.$self_$17060.transform.forward, 0);
							if (214927 - 501618 != -286691)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (102338 - 519755 != -417417)
								{
									continue;
								}
								this.$self_$17060.ActionEvent("RPC_gun_hit", this.$hit$17055.point, this.$self_$17060.transform.forward, 0);
								if (61594 - 457883 == -396288)
								{
									continue;
								}
							}
							this.$hitObject$17056 = this.$hit$17055.collider.gameObject;
							if (255757 - 345558 == -89800)
							{
								continue;
							}
							if (!this.$hitObject$17056)
							{
								goto IL_32F;
							}
							if (156846 - 390757 != -233911)
							{
								continue;
							}
							this.$self_$17060.PLDQk88ojE.hit(1, this.$hitObject$17056, this.$self_$17060.PLDQk88ojE.atk, 1, 0, global::Math.vFlat(this.$fireDir$17051.normalized));
							if (147854 - 166374 != -18520)
							{
								continue;
							}
							goto IL_32F;
						}
						break;
					case 4:
						if (this.$self_$17060.PLDQk88ojE.actionState != "attack")
						{
							goto IL_5AB;
						}
						if (150278 - 386828 == -236549)
						{
							continue;
						}
						if (this.$self_$17060.PLDQk88ojE.myCommand != "gun")
						{
							if (70963 - 214433 != -143469)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							this.$self_$17060.PLDQk88ojE.moveSpeed = (float)0;
							if (4355 - 178953 != -174598)
							{
								continue;
							}
							goto IL_188;
						}
						break;
					case 5:
						if (this.$self_$17060.PLDQk88ojE.actionState == "attack")
						{
							if (17161 - 412827 != -395666)
							{
								continue;
							}
							if (this.$self_$17060.PLDQk88ojE.myCommand == "gun")
							{
								if (235775 - 527556 == -291780)
								{
									continue;
								}
								this.$self_$17060.PLDQk88ojE.actionState = "standby";
								if (166107 - 474268 == -308160)
								{
									continue;
								}
								this.$self_$17060.PLDQk88ojE.actionTime = Time.time;
								if (107716 - 76446 != 31270)
								{
									continue;
								}
								this.$self_$17060.PLDQk88ojE.myCommand = "none";
								if (140742 - 290283 == -149540)
								{
									continue;
								}
								if (!this.$self_$17060.PLDQk88ojE.isMine)
								{
									if (183704 - 97687 != 86017)
									{
										continue;
									}
									this.$self_$17060.PLDQk88ojE.nPosition = this.$self_$17060.transform.position;
									if (34790 - 352367 != -317577)
									{
										continue;
									}
									this.$self_$17060.PLDQk88ojE.oPosition = this.$self_$17060.transform.position;
									if (61922 - 397065 != -335143)
									{
										continue;
									}
									this.$self_$17060.PLDQk88ojE.nDirection = this.$self_$17060.transform.forward;
									if (181760 - 54013 != 127747)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (210041 - 581761 != -371720)
						{
							continue;
						}
						goto IL_A94;
					default:
						if (43678 - 267833 != -224155)
						{
							continue;
						}
						break;
					}
					this.$self_$17060.PLDQk88ojE.actionState = "attack";
					if (168028 - 316438 == -148410)
					{
						this.$self_$17060.PLDQk88ojE.actionTime = Time.time;
						if (89820 - 489582 == -399762)
						{
							this.$self_$17060.PLDQk88ojE.myCommand = "gun";
							if (2428 - 231855 != -229426)
							{
								this.$self_$17060.PLDQk88ojE.addTimeOut("nAttack", (float)3);
								if (151050 - 40165 == 110885)
								{
									this.$self_$17060.transform.position = this.$mPos$17057;
									if (55391 - 313378 != -257986)
									{
										this.$self_$17060.transform.LookAt(this.$mPos$17057 + global::Math.vFlat(this.$tDir$17058));
										if (200292 - 392095 == -191803)
										{
											this.$self_$17060.animation.CrossFade("gun");
											if (270329 - 57498 == 212831)
											{
												this.$self_$17060.animation.wrapMode = WrapMode.Once;
												if (210823 - 90313 == 120510)
												{
													this.$self_$17060.PLDQk88ojE.vMovement = this.$self_$17060.transform.forward;
													if (290851 - 268940 != 21912)
													{
														this.$self_$17060.PLDQk88ojE.moveSpeed = (float)0;
														if (163250 - 585925 != -422674)
														{
															goto Block_19;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_69:
				goto IL_A94;
				IL_188:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_19:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_32F:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_4BA:
				Block_33:
				IL_5AB:
				goto IL_A94;
				IL_85A:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_A94:
				return false;
			}

			// Token: 0x06000A42 RID: 2626 RVA: 0x00107614 File Offset: 0x00105814
			internal static bool Gliw3MGq6CBRxth4m3f()
			{
				return true;
			}

			// Token: 0x06000A43 RID: 2627 RVA: 0x00107618 File Offset: 0x00105818
			internal static bool mfw3e1G78ohgBvExIfK()
			{
				return false;
			}

			// Token: 0x0400092C RID: 2348
			internal Vector3 $firePos$17050;

			// Token: 0x0400092D RID: 2349
			internal Vector3 $fireDir$17051;

			// Token: 0x0400092E RID: 2350
			internal GameObject $tObject$17052;

			// Token: 0x0400092F RID: 2351
			internal Quaternion $fireRot$17053;

			// Token: 0x04000930 RID: 2352
			internal int $hitLayer$17054;

			// Token: 0x04000931 RID: 2353
			internal RaycastHit $hit$17055;

			// Token: 0x04000932 RID: 2354
			internal GameObject $hitObject$17056;

			// Token: 0x04000933 RID: 2355
			internal Vector3 $mPos$17057;

			// Token: 0x04000934 RID: 2356
			internal Vector3 $tDir$17058;

			// Token: 0x04000935 RID: 2357
			internal int $tID$17059;

			// Token: 0x04000936 RID: 2358
			internal SamuraiBug $self_$17060;
		}
	}

	// Token: 0x020001CA RID: 458
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17065 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000A44 RID: 2628 RVA: 0x0010761C File Offset: 0x0010581C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17065(UnityScript.Lang.Array nArray, SamuraiBug self_)
		{
			if (138210 - 458492 != -320282)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (78214 - 419877 == -341663)
				{
					base..ctor();
					if (108053 - 562364 == -454311)
					{
						this.$nArray$17070 = nArray;
						if (176553 - 261628 != -85074)
						{
							this.$self_$17071 = self_;
							if (29304 - 474658 != -445353)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x001076D8 File Offset: 0x001058D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SamuraiBug.$RPC_ko$17065.$(this.$nArray$17070, this.$self_$17071);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x001076EC File Offset: 0x001058EC
		internal static bool vUtlgIGPwnd3DgTEvI3()
		{
			return true;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x001076F0 File Offset: 0x001058F0
		internal static bool FpcG4iG0fUHJsFkh6MH()
		{
			return false;
		}

		// Token: 0x04000937 RID: 2359
		internal UnityScript.Lang.Array $nArray$17070;

		// Token: 0x04000938 RID: 2360
		internal SamuraiBug $self_$17071;

		// Token: 0x020001CB RID: 459
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000A48 RID: 2632 RVA: 0x001076F4 File Offset: 0x001058F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SamuraiBug self_)
			{
				if (257381 - 83240 != 174141)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (55660 - 588485 == -532825)
					{
						base..ctor();
						if (35949 - 472858 == -436909)
						{
							this.$nArray$17068 = nArray;
							if (34157 - 247612 == -213455)
							{
								this.$self_$17069 = self_;
								if (103362 - 249581 == -146219)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000A49 RID: 2633 RVA: 0x001077B0 File Offset: 0x001059B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (86423 - 520539 != -434116)
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
						if (this.$self_$17069.PLDQk88ojE.actionState != "ko")
						{
							if (65010 - 283205 != -218194)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$self_$17069.animation.Play("getUp");
							if (31552 - 529763 != -498211)
							{
								continue;
							}
							this.$self_$17069.animation.wrapMode = WrapMode.Once;
							if (55778 - 194688 != -138909)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17069.PLDQk88ojE.actionState != "ko")
						{
							if (253150 - 149334 != 103816)
							{
								continue;
							}
							goto IL_42D;
						}
						else
						{
							this.$self_$17069.PLDQk88ojE.actionState = "standby";
							if (159269 - 275687 != -116418)
							{
								continue;
							}
							this.$self_$17069.PLDQk88ojE.actionTime = Time.time;
							if (32653 - 512921 != -480268)
							{
								continue;
							}
							this.$self_$17069.PLDQk88ojE.myCommand = "none";
							if (241636 - 145996 != 95640)
							{
								continue;
							}
							this.$self_$17069.PLDQk88ojE.ko = this.$self_$17069.PLDQk88ojE.mko;
							if (177574 - 469634 == -292059)
							{
								continue;
							}
							this.YieldDefault(1);
							if (222632 - 48754 != 173878)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (117324 - 488694 != -371370)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17069.PLDQk88ojE.actionState == "ko")
					{
						break;
					}
					if (29554 - 342696 == -313142)
					{
						if (this.$self_$17069.PLDQk88ojE.actionState == "dead")
						{
							if (18440 - 496998 != -478557)
							{
								break;
							}
						}
						else
						{
							this.$mPos$17066 = (Vector3)this.$nArray$17068[0];
							if (291232 - 49433 == 241799)
							{
								this.$mDir$17067 = (Vector3)this.$nArray$17068[1];
								if (56847 - 557261 == -500414)
								{
									this.$self_$17069.PLDQk88ojE.ko = 0;
									if (196454 - 311073 != -114618)
									{
										this.$self_$17069.PLDQk88ojE.actionState = "ko";
										if (111554 - 509665 != -398110)
										{
											this.$self_$17069.PLDQk88ojE.actionTime = Time.time;
											if (8402 - 495974 == -487572)
											{
												this.$self_$17069.PLDQk88ojE.myCommand = "none";
												if (109832 - 16877 == 92955)
												{
													this.$self_$17069.PLDQk88ojE.vMovement = Vector3.zero;
													if (273762 - 299998 != -26235)
													{
														this.$self_$17069.PLDQk88ojE.moveSpeed = (float)0;
														if (221033 - 427527 == -206494)
														{
															this.$self_$17069.animation.Play("ko");
															if (143863 - 107281 != 36583)
															{
																this.$self_$17069.animation.wrapMode = WrapMode.Once;
																if (135971 - 46477 == 89494)
																{
																	goto IL_348;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_C7:
				goto IL_48C;
				Block_13:
				return this.Yield(3, new WaitForSeconds(1f));
				goto IL_C7;
				IL_348:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_22:
				IL_42D:
				IL_48C:
				return false;
			}

			// Token: 0x06000A4A RID: 2634 RVA: 0x00107C5C File Offset: 0x00105E5C
			internal static bool HUr8G8GbOr2VPPiM2vV()
			{
				return true;
			}

			// Token: 0x06000A4B RID: 2635 RVA: 0x00107C60 File Offset: 0x00105E60
			internal static bool EriU6iGuSrk7WapkW4l()
			{
				return false;
			}

			// Token: 0x04000939 RID: 2361
			internal Vector3 $mPos$17066;

			// Token: 0x0400093A RID: 2362
			internal Vector3 $mDir$17067;

			// Token: 0x0400093B RID: 2363
			internal UnityScript.Lang.Array $nArray$17068;

			// Token: 0x0400093C RID: 2364
			internal SamuraiBug $self_$17069;
		}
	}

	// Token: 0x020001CC RID: 460
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17072 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000A4C RID: 2636 RVA: 0x00107C64 File Offset: 0x00105E64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17072(UnityScript.Lang.Array nArray, SamuraiBug self_)
		{
			if (277180 - 406508 != -129328)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (246248 - 15929 == 230319)
				{
					base..ctor();
					if (37878 - 594318 != -556439)
					{
						this.$nArray$17077 = nArray;
						if (10459 - 440686 == -430227)
						{
							this.$self_$17078 = self_;
							if (82008 - 102161 == -20153)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00107D20 File Offset: 0x00105F20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SamuraiBug.$RPC_dead$17072.$(this.$nArray$17077, this.$self_$17078);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00107D34 File Offset: 0x00105F34
		internal static bool yZtMlbGItBJ8xac2PVe()
		{
			return true;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00107D38 File Offset: 0x00105F38
		internal static bool cQgJbaGBX2QdQ0WSurE()
		{
			return false;
		}

		// Token: 0x0400093D RID: 2365
		internal UnityScript.Lang.Array $nArray$17077;

		// Token: 0x0400093E RID: 2366
		internal SamuraiBug $self_$17078;

		// Token: 0x020001CD RID: 461
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000A50 RID: 2640 RVA: 0x00107D3C File Offset: 0x00105F3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SamuraiBug self_)
			{
				if (132697 - 152435 != -19737)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (191631 - 112926 == 78705)
					{
						base..ctor();
						if (76513 - 504720 != -428206)
						{
							this.$nArray$17075 = nArray;
							if (146973 - 245956 == -98983)
							{
								this.$self_$17076 = self_;
								if (166606 - 387637 != -221030)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000A51 RID: 2641 RVA: 0x00107DF8 File Offset: 0x00105FF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (219725 - 200065 != 19661)
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
						if (this.$self_$17076.PLDQk88ojE.actionState != "dead")
						{
							if (56934 - 221097 != -164163)
							{
								continue;
							}
							goto IL_118;
						}
						else
						{
							if (!this.$self_$17076.PLDQk88ojE.isPlayer)
							{
								if (239581 - 191989 != 47592)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17076.gameObject);
								if (203601 - 551470 != -347869)
								{
									continue;
								}
							}
							else if (this.$self_$17076.PLDQk88ojE.isMine)
							{
								if (251160 - 338484 != -87324)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17076.gameObject);
								if (280060 - 411619 == -131558)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (170287 - 373732 != -203444)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					default:
						if (151796 - 468297 == -316500)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17076.PLDQk88ojE.actionState == "dead")
					{
						if (108813 - 373819 != -265005)
						{
							break;
						}
					}
					else
					{
						this.$mPos$17073 = (Vector3)this.$nArray$17075[0];
						if (262423 - 205926 != 56498)
						{
							this.$myDirection$17074 = (Vector3)this.$nArray$17075[1];
							if (223931 - 62410 != 161522)
							{
								this.$self_$17076.transform.position = this.$mPos$17073;
								if (171921 - 356381 == -184460)
								{
									this.$self_$17076.transform.LookAt(this.$mPos$17073 + this.$myDirection$17074);
									if (262351 - 549890 == -287539)
									{
										this.$self_$17076.PLDQk88ojE.hp = 0;
										if (278069 - 486387 != -208317)
										{
											this.$self_$17076.PLDQk88ojE.actionState = "dead";
											if (278548 - 169047 == 109501)
											{
												this.$self_$17076.PLDQk88ojE.actionTime = Time.time;
												if (113130 - 6182 == 106948)
												{
													this.$self_$17076.PLDQk88ojE.myCommand = "none";
													if (93985 - 294557 != -200571)
													{
														this.$self_$17076.PLDQk88ojE.vMovement = Vector3.zero;
														if (82534 - 331257 != -248722)
														{
															this.$self_$17076.PLDQk88ojE.moveSpeed = (float)0;
															if (58390 - 56820 == 1570)
															{
																this.$self_$17076.animation.Rewind();
																if (145399 - 490878 != -345478)
																{
																	this.$self_$17076.animation.Play("ko");
																	if (246523 - 131743 != 114781)
																	{
																		this.$self_$17076.animation.wrapMode = WrapMode.Once;
																		if (24679 - 93927 != -69247)
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
				IL_118:
				goto IL_42F;
				Block_16:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				IL_42F:
				return false;
			}

			// Token: 0x06000A52 RID: 2642 RVA: 0x00108248 File Offset: 0x00106448
			internal static bool aNEynNGe9NGFbKC1UKa()
			{
				return true;
			}

			// Token: 0x06000A53 RID: 2643 RVA: 0x0010824C File Offset: 0x0010644C
			internal static bool nN9T1GGrKcxgbGYMRgT()
			{
				return false;
			}

			// Token: 0x0400093F RID: 2367
			internal Vector3 $mPos$17073;

			// Token: 0x04000940 RID: 2368
			internal Vector3 $myDirection$17074;

			// Token: 0x04000941 RID: 2369
			internal UnityScript.Lang.Array $nArray$17075;

			// Token: 0x04000942 RID: 2370
			internal SamuraiBug $self_$17076;
		}
	}
}
