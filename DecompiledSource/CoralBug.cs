using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000036 RID: 54
[Serializable]
public class CoralBug : MonoBehaviour
{
	// Token: 0x06000109 RID: 265 RVA: 0x0001AAA4 File Offset: 0x00018CA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CoralBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600010A RID: 266 RVA: 0x0001AAB4 File Offset: 0x00018CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (222674 - 440177 != -217502)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (77672 - 533540 != -455867)
			{
				this.mChar.actionState = "standby";
				if (239862 - 417748 != -177885)
				{
					this.mChar.actionTime = Time.time;
					if (18194 - 423519 != -405324)
					{
						this.mChar.myCommand = "none";
						if (223887 - 310092 == -86205)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600010B RID: 267 RVA: 0x0001ABA0 File Offset: 0x00018DA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x0600010C RID: 268 RVA: 0x0001ABBC File Offset: 0x00018DBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (255715 - 452090 != -196374)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (268750 - 339074 != -70324)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (133454 - 133589 == -134)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_12F;
					}
					if (238596 - 427534 != -188938)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (35132 - 14683 == 20450)
				{
					continue;
				}
			}
			IL_12F:
			if (this.mChar.hp <= 0)
			{
				if (62903 - 596829 != -533926)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (196273 - 597159 != -400886)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (58297 - 267704 == -209406)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (168152 - 161233 != 6919)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (281206 - 332541 != -51335)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (24099 - 169415 != -145316)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (195796 - 127639 != 68157)
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
			if (40617 - 91062 != -50444)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (29662 - 268349 == -238687)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (293535 - 367660 == -74125)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (88903 - 262287 != -173383)
						{
							if (this.mChar.isMine)
							{
								if (253280 - 284766 != -31485)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (200163 - 291628 != -91464)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (258623 - 11991 != 246633)
										{
											this.mChar.KoEvent();
											if (13084 - 220279 != -207194)
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
								if (194025 - 593787 == -399762)
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

	// Token: 0x0600010D RID: 269 RVA: 0x0001AFB4 File Offset: 0x000191B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (260487 - 153602 != 106885)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (196855 - 136227 != 60629)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (102590 - 110425 != -7834)
				{
					if (218862 - 426484 == -207622)
					{
						if (ActionName == "RPC_coralSlam")
						{
							if (265399 - 152288 == 113112)
							{
								continue;
							}
							v = 10;
							if (67921 - 40701 == 27221)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_coralSlam_hit")
						{
							if (28880 - 328421 != -299541)
							{
								continue;
							}
							v = -10;
							if (161959 - 424709 == -262749)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_coralRelease")
						{
							if (9388 - 91577 == -82188)
							{
								continue;
							}
							v = 20;
							if (225572 - 522231 == -296658)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_coralBlast")
						{
							if (281894 - 504031 == -222136)
							{
								continue;
							}
							v = 30;
							if (51957 - 436956 != -384999)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_coralBlast_fire")
						{
							if (34543 - 306044 == -271500)
							{
								continue;
							}
							v = 31;
							if (147007 - 415371 == -268363)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bubbleShield")
						{
							if (200197 - 162009 != 38188)
							{
								continue;
							}
							v = 40;
							if (206400 - 425535 == -219134)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (165366 - 138817 == 26550)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (296283 - 352571 == -56288)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (130089 - 120303 != 9787)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (242612 - 419847 == -177235)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (33726 - 559138 != -525411)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (162276 - 400888 != -238611)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (227054 - 310018 == -82964)
											{
												Hashtable hashtable = new Hashtable();
												if (77621 - 309821 != -232199)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (141261 - 521909 != -380647)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (299836 - 491748 == -191912)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (36540 - 2936 != 33605)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (13265 - 240156 != -226890)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (52931 - 396765 != -343833)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (20906 - 236204 != -215297)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (259326 - 274332 == -15006)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (163702 - 2134 != 161569)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (275443 - 549581 != -274137)
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

	// Token: 0x0600010E RID: 270 RVA: 0x0001B564 File Offset: 0x00019764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (11657 - 523151 != -511493)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (6101 - 356333 != -350231)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (124101 - 477370 == -353269)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (291203 - 381168 != -89964)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (296952 - 577427 != -280474)
						{
							int num3 = num;
							if (208468 - 297857 != -89388)
							{
								if (num3 == 10)
								{
									if (8961 - 345720 != -336758)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (242050 - 538466 != -296415)
										{
											this.StartCoroutine_Auto(this.RPC_coralSlam(vector, vector2, num2));
											if (130366 - 462555 != -332188)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -10)
								{
									if (219531 - 107343 == 112188)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (165383 - 365784 != -200400)
										{
											this.RPC_coralSlam_hit(vector, vector2, num2);
											if (205179 - 90970 == 114209)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 20)
								{
									if (12718 - 49763 != -37044)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (215258 - 259921 == -44663)
										{
											this.StartCoroutine_Auto(this.RPC_coralRelease(vector, vector2, num2));
											if (264860 - 498243 == -233383)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 30)
								{
									if (297710 - 2817 == 294893)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (265881 - 154765 != 111117)
										{
											this.StartCoroutine_Auto(this.RPC_coralBlast(vector, vector2, num2));
											if (167981 - 285714 == -117733)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (199147 - 542683 != -343535)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (80017 - 260275 == -180258)
										{
											this.RPC_coralBlast_fire(vector, vector2, num2);
											if (88690 - 187291 == -98601)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 40)
								{
									if (170305 - 406061 != -235755)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (203001 - 381306 == -178305)
										{
											this.StartCoroutine_Auto(this.RPC_bubbleShield(vector, vector2, num2));
											if (143284 - 13376 != 129909)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (76821 - 68320 != 8502)
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

	// Token: 0x0600010F RID: 271 RVA: 0x0001B9E4 File Offset: 0x00019BE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (135884 - 577704 != -441819)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (99604 - 311581 == -211977)
			{
				float runSpeed = this.mChar.runSpeed;
				if (195249 - 13024 == 182225)
				{
					Vector3 a = default(Vector3);
					if (130612 - 112047 != 18566)
					{
						Vector3 vector = Vector3.zero;
						if (151919 - 171792 != -19872)
						{
							float num2 = (float)0;
							if (239543 - 204509 != 35035)
							{
								if (this.mChar.isMine)
								{
									if (185231 - 61050 == 124182)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (186675 - 306023 == -119347)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (276602 - 106441 != 170161)
										{
											continue;
										}
										a.y = (float)0;
										if (21862 - 439581 == -417718)
										{
											continue;
										}
										a = a.normalized;
										if (268195 - 472700 != -204505)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (208033 - 429246 == -221212)
										{
											continue;
										}
										vector = vector.normalized;
										if (83513 - 514061 == -430547)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (42611 - 290643 == -248031)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (186975 - 221775 == -34799)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (211683 - 152866 == 58818)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (254850 - 290565 != -35715)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (41754 - 119254 != -77500)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (48495 - 861 != 47634)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (192963 - 367276 == -174312)
														{
															continue;
														}
														this.animation.Play("run");
														if (234610 - 90989 == 143622)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (68064 - 244423 != -176358)
														{
															goto IL_10B;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (54092 - 419320 != -365228)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (53286 - 168270 != -114984)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (276085 - 5603 != 270482)
											{
												continue;
											}
											num = (float)0;
											if (274690 - 446531 == -171840)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (198747 - 286224 != -87477)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (186720 - 597003 != -410283)
										{
											continue;
										}
									}
									IL_10B:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (261298 - 557331 == -296032)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (194690 - 420256 != -225566)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (75890 - 564577 == -488686)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (285448 - 392236 == -106787)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (232253 - 366128 == -133874)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (61288 - 281074 != -219786)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (180732 - 477064 == -296331)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (205576 - 583860 != -378284)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (254544 - 37522 == 217023)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (224570 - 503292 == -278721)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (99837 - 583786 != -483949)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (252370 - 28691 != 223679)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (16367 - 5100 == 11268)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (218229 - 32535 != 185694)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (270445 - 348976 == -78530)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (144858 - 382214 != -237356)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (77922 - 523135 == -445212)
												{
													continue;
												}
												num = (float)0;
												if (93384 - 596245 != -502861)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (110991 - 340114 != -229123)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (239922 - 90025 == 149898)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (148327 - 253253 == -104925)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (129313 - 310104 == -180790)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (105122 - 599423 != -494301)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (258586 - 91966 == 166621)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (48364 - 443573 != -395209)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (100316 - 203807 == -103490)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (63885 - 415774 != -351889)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (90946 - 238911 == -147964)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (214849 - 89954 != 124895)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (271304 - 536371 == -265066)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (116465 - 374849 != -258384)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (73265 - 184033 != -110768)
											{
												continue;
											}
											num = (float)0;
											if (81324 - 193763 != -112439)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (275495 - 307274 == -31778)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (107153 - 14610 != 92543)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (264285 - 460467 == -196181)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (97640 - 307284 == -209643)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (215241 - 248981 == -33740)
								{
									this.mChar.moveSpeed = num;
									if (9073 - 488596 != -479522)
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

	// Token: 0x06000110 RID: 272 RVA: 0x0001C548 File Offset: 0x0001A748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (16859 - 137365 != -120505)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (29521 - 34634 == -5113)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (230121 - 197318 == 32803)
				{
					Vector3 vector = a - this.transform.position;
					if (59816 - 2550 != 57267)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (41827 - 171783 == -129956)
						{
							CharacterControl characterControl = null;
							if (201885 - 13192 == 188693)
							{
								if (gameObject)
								{
									if (166201 - 46188 == 120014)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (176253 - 303631 == -127377)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (14865 - 383892 == -369026)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (264094 - 355391 == -91296)
									{
										continue;
									}
								}
								if (!characterControl)
								{
									if (159555 - 327846 != -168290)
									{
										Camera.main.SendMessage("newGameMessage", "No target selected");
										if (49148 - 366416 != -317267)
										{
											break;
										}
									}
								}
								else
								{
									this.StartCoroutine_Auto(this.RPC_coralBlast(this.transform.position, vector, characterControl.ActorNr));
									if (214830 - 63983 != 150848)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (295363 - 510583 != -215219)
										{
											this.ActionEvent("RPC_coralBlast", this.transform.position, vector, characterControl.ActorNr);
											if (135835 - 504847 == -369012)
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

	// Token: 0x06000111 RID: 273 RVA: 0x0001C814 File Offset: 0x0001AA14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (41629 - 566161 != -524531)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (90528 - 221686 != -131157)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (47638 - 241516 == -193878)
				{
					Vector3 vector = a - this.transform.position;
					if (197065 - 430840 == -233775)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (279873 - 23865 == 256008)
						{
							if (118574 - 38828 != 79747)
							{
								if (gameObject)
								{
									if (29559 - 26515 == 3045)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (211007 - 242090 != -31083)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (145986 - 416648 != -270662)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (74582 - 511596 != -437014)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("coralRelease") == (float)0)
								{
									if (250395 - 482692 == -232296)
									{
										continue;
									}
									if (this.mChar.sp >= 50)
									{
										if (209357 - 140278 == 69080)
										{
											continue;
										}
										this.StartCoroutine_Auto(this.RPC_coralRelease(this.transform.position, this.transform.forward, 0));
										if (63853 - 421471 == -357617)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (255831 - 26561 == 229271)
										{
											continue;
										}
										this.ActionEvent("RPC_coralRelease", this.transform.position, this.transform.forward, 0);
										if (118841 - 463195 != -344353)
										{
											break;
										}
										continue;
									}
								}
								if (this.mChar.isTimeOut("coralSlam") != (float)0)
								{
									break;
								}
								if (206386 - 372253 != -165866)
								{
									this.StartCoroutine_Auto(this.RPC_coralSlam(this.transform.position, vector, 0));
									if (68358 - 234635 != -166276)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (176788 - 11015 != 165774)
										{
											this.ActionEvent("RPC_coralSlam", this.transform.position, vector, 0);
											if (141283 - 116747 == 24536)
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

	// Token: 0x06000112 RID: 274 RVA: 0x0001CBA8 File Offset: 0x0001ADA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0001CBAC File Offset: 0x0001ADAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_coralSlam(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CoralBug.$RPC_coralSlam$15373(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000114 RID: 276 RVA: 0x0001CBBC File Offset: 0x0001ADBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_coralSlam_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (133691 - 81678 != 52014)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Instantiate(this.coralSlam_hit, hitPos, Quaternion.identity);
			if (32112 - 454777 != -422664)
			{
				if (this.fe3rnwgU0 >= Time.time)
				{
					break;
				}
				if (253407 - 590112 != -336704)
				{
					this.fe3rnwgU0 = Time.time + 0.1f;
					if (31223 - 109105 != -77881)
					{
						if (!this.coralSlam_hitFx)
						{
							break;
						}
						if (100318 - 245394 == -145076)
						{
							this.audio.PlayOneShot(this.coralSlam_hitFx);
							if (176408 - 51505 != 124904)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000115 RID: 277 RVA: 0x0001CCCC File Offset: 0x0001AECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_coralRelease(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CoralBug.$RPC_coralRelease$15386(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000116 RID: 278 RVA: 0x0001CCDC File Offset: 0x0001AEDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_coralBlast(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CoralBug.$RPC_coralBlast$15398(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000117 RID: 279 RVA: 0x0001CCEC File Offset: 0x0001AEEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_coralBlast_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (53168 - 96370 != -43201)
		{
		}
		for (;;)
		{
			IL_1BE:
			if (this.coralBlast)
			{
				if (74966 - 537389 == -462422)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.coralBlast, mPos, Quaternion.identity);
				if (239286 - 127166 == 112121)
				{
					continue;
				}
			}
			else
			{
				Debug.Log("Cannot find coralBlast effect");
				if (284749 - 433964 != -149215)
				{
					continue;
				}
			}
			if (!this.mChar.isMine)
			{
				break;
			}
			if (88686 - 211448 == -122762)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (239665 - 547045 == -307380)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(mPos, (float)1, (float)6, layerMask);
					if (66521 - 552865 != -486343)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (292501 - 520583 != -228081)
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
								if (148976 - 172446 == -23469)
								{
									goto IL_1BE;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (297769 - 305207 == -7437)
								{
									goto IL_1BE;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (104854 - 231232 == -126377)
								{
									goto IL_1BE;
								}
								if (characterControl)
								{
									if (41040 - 422679 == -381638)
									{
										goto IL_1BE;
									}
									this.mChar.hit(20, gameObject, this.mChar.talAdjust(40) + characterControl.weight, 4, 0, (float)5 * Vector3.up);
									if (244545 - 506982 != -262437)
									{
										goto IL_1BE;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (178030 - 98729 != 79301)
									{
										goto IL_1BE;
									}
								}
							}
							if (280981 - 79925 != 201057)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000118 RID: 280 RVA: 0x0001CF94 File Offset: 0x0001B194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bubbleShield(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CoralBug.$RPC_bubbleShield$15408(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000119 RID: 281 RVA: 0x0001CFA4 File Offset: 0x0001B1A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new CoralBug.$RPC_ko$15419(nArray, this).GetEnumerator();
	}

	// Token: 0x0600011A RID: 282 RVA: 0x0001CFB4 File Offset: 0x0001B1B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new CoralBug.$RPC_dead$15426(nArray, this).GetEnumerator();
	}

	// Token: 0x0600011B RID: 283 RVA: 0x0001CFC4 File Offset: 0x0001B1C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
	internal static bool cVN6hW5q4x5jJEnXAsi()
	{
		return true;
	}

	// Token: 0x0600011D RID: 285 RVA: 0x0001CFCC File Offset: 0x0001B1CC
	internal static bool gg5uXY57ADZjxXjKfMA()
	{
		return false;
	}

	// Token: 0x04000151 RID: 337
	public CharacterControl mChar;

	// Token: 0x04000152 RID: 338
	public GameObject coralSlam_ring;

	// Token: 0x04000153 RID: 339
	public GameObject coralSlam_hit;

	// Token: 0x04000154 RID: 340
	public AudioClip coralSlam_hitFx;

	// Token: 0x04000155 RID: 341
	private float fe3rnwgU0;

	// Token: 0x04000156 RID: 342
	public GameObject coralRelease;

	// Token: 0x04000157 RID: 343
	public GameObject coralBlast;

	// Token: 0x04000158 RID: 344
	public GameObject bubbleShield_cast;

	// Token: 0x02000037 RID: 55
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_coralSlam$15373 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600011E RID: 286 RVA: 0x0001CFD0 File Offset: 0x0001B1D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_coralSlam$15373(Vector3 mPos, Vector3 tDir, CoralBug self_)
		{
			if (284915 - 251677 != 33238)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (188959 - 203111 != -14151)
				{
					base..ctor();
					if (280833 - 435496 != -154662)
					{
						this.$mPos$15383 = mPos;
						if (231851 - 6690 == 225161)
						{
							this.$tDir$15384 = tDir;
							if (248660 - 497512 == -248852)
							{
								this.$self_$15385 = self_;
								if (76982 - 40338 != 36645)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0001D0AC File Offset: 0x0001B2AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CoralBug.$RPC_coralSlam$15373.$(this.$mPos$15383, this.$tDir$15384, this.$self_$15385);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0001D0C8 File Offset: 0x0001B2C8
		internal static bool jJkKct5PEqUuyxUd9tp()
		{
			return true;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0001D0CC File Offset: 0x0001B2CC
		internal static bool CK0siY50VG5JgThn1Lk()
		{
			return false;
		}

		// Token: 0x04000159 RID: 345
		internal Vector3 $mPos$15383;

		// Token: 0x0400015A RID: 346
		internal Vector3 $tDir$15384;

		// Token: 0x0400015B RID: 347
		internal CoralBug $self_$15385;

		// Token: 0x02000038 RID: 56
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000122 RID: 290 RVA: 0x0001D0D0 File Offset: 0x0001B2D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CoralBug self_)
			{
				if (258633 - 150841 != 107792)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (254542 - 372889 == -118347)
					{
						base..ctor();
						if (185647 - 552045 != -366397)
						{
							this.$mPos$15380 = mPos;
							if (55903 - 552051 == -496148)
							{
								this.$tDir$15381 = tDir;
								if (142215 - 572633 != -430417)
								{
									this.$self_$15382 = self_;
									if (230160 - 226355 != 3806)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000123 RID: 291 RVA: 0x0001D1AC File Offset: 0x0001B3AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56894 - 233404 != -176510)
				{
				}
				for (;;)
				{
					IL_340:
					switch (this._state)
					{
					case 0:
						goto IL_508;
					case 1:
						goto IL_9CF;
					case 2:
						if (this.$self_$15382.mChar.actionState != "attack")
						{
							goto IL_1A3;
						}
						if (225211 - 428430 != -203219)
						{
							continue;
						}
						if (this.$self_$15382.mChar.myCommand != "coralSlam")
						{
							if (112967 - 489239 != -376271)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$i$15374 = 0;
							if (66343 - 247053 == -180709)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$15382.mChar.actionState != "attack")
						{
							goto IL_6F5;
						}
						if (150394 - 498157 == -347762)
						{
							continue;
						}
						if (this.$self_$15382.mChar.myCommand != "coralSlam")
						{
							if (221876 - 329254 != -107378)
							{
								continue;
							}
							goto IL_6F5;
						}
						else
						{
							this.$i$15374++;
							if (149021 - 261957 == -112935)
							{
								continue;
							}
						}
						break;
					default:
						if (246968 - 312095 != -65127)
						{
							continue;
						}
						goto IL_508;
					}
					if (this.$i$15374 >= 15)
					{
						if (281708 - 522620 == -240911)
						{
							continue;
						}
						if (this.$self_$15382.mChar.actionState == "attack")
						{
							if (270493 - 127479 != 143014)
							{
								continue;
							}
							if (this.$self_$15382.mChar.myCommand == "coralSlam")
							{
								if (260377 - 402287 == -141909)
								{
									continue;
								}
								this.$self_$15382.mChar.moveSpeed = (float)0;
								if (110279 - 8866 != 101413)
								{
									continue;
								}
								this.$self_$15382.mChar.actionState = "standby";
								if (297359 - 274022 != 23337)
								{
									continue;
								}
								this.$self_$15382.mChar.actionTime = Time.time;
								if (67620 - 141816 == -74195)
								{
									continue;
								}
								this.$self_$15382.mChar.myCommand = "none";
								if (159665 - 108974 == 50692)
								{
									continue;
								}
								if (!this.$self_$15382.mChar.isMine)
								{
									if (243348 - 443205 == -199856)
									{
										continue;
									}
									this.$self_$15382.mChar.nPosition = this.$self_$15382.transform.position;
									if (194361 - 99200 == 95162)
									{
										continue;
									}
									this.$self_$15382.mChar.oPosition = this.$self_$15382.transform.position;
									if (22704 - 227934 == -205229)
									{
										continue;
									}
									this.$self_$15382.mChar.nDirection = this.$self_$15382.transform.forward;
									if (127018 - 300143 != -173125)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (44200 - 199728 != -155528)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$self_$15382.mChar.moveSpeed = (float)9 - (float)this.$i$15374 * 0.2f;
						if (295608 - 83287 == 212322)
						{
							continue;
						}
						if (!this.$self_$15382.mChar.isMine)
						{
							goto IL_928;
						}
						if (172434 - 250239 == -77804)
						{
							continue;
						}
						this.$hitLayer$15375 = 130816 - (1 << this.$self_$15382.gameObject.layer);
						if (175136 - 77538 == 97599)
						{
							continue;
						}
						this.$hitList$15376 = Damage.FindRecTarget(this.$self_$15382.transform.position, this.$self_$15382.transform.forward, (float)2, (float)2, (float)4, (float)4, this.$hitLayer$15375);
						if (159641 - 310026 == -150384)
						{
							continue;
						}
						this.$$iterator$9887$15379 = UnityRuntimeServices.GetEnumerator(this.$hitList$15376);
						if (38978 - 283159 == -244180)
						{
							continue;
						}
						while (this.$$iterator$9887$15379.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$9887$15379.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$15377 = (GameObject)obj2;
							if (263121 - 509439 != -246318)
							{
								goto IL_340;
							}
							if (this.$self_$15382.mChar.hit(10, this.$hitObject$15377, (int)(0.5f * (float)this.$self_$15382.mChar.atk), 2, 0, 0.5f * this.$self_$15382.transform.forward) != 0)
							{
								if (57476 - 556838 == -499361)
								{
									goto IL_340;
								}
								this.$hitPos$15378 = this.$hitObject$15377.collider.ClosestPointOnBounds(this.$self_$15382.transform.position + 1.5f * Vector3.up);
								if (119526 - 26285 != 93241)
								{
									goto IL_340;
								}
								UnityRuntimeServices.Update(this.$$iterator$9887$15379, this.$hitObject$15377);
								if (198433 - 139925 == 58509)
								{
									goto IL_340;
								}
								this.$self_$15382.RPC_coralSlam_hit(this.$hitPos$15378, this.$self_$15382.transform.forward, 0);
								if (262096 - 498036 != -235940)
								{
									goto IL_340;
								}
								this.$self_$15382.ActionEvent("RPC_coralSlam_hit", this.$hitPos$15378, this.$self_$15382.transform.forward, 0);
								if (159858 - 246058 == -86199)
								{
									goto IL_340;
								}
							}
						}
						if (55881 - 551570 != -495688)
						{
							goto Block_52;
						}
						continue;
					}
					IL_508:
					this.$self_$15382.mChar.actionState = "attack";
					if (92664 - 249378 != -156713)
					{
						this.$self_$15382.mChar.actionTime = Time.time;
						if (228405 - 64366 == 164039)
						{
							this.$self_$15382.mChar.myCommand = "coralSlam";
							if (60767 - 416796 != -356028)
							{
								this.$self_$15382.mChar.addTimeOut("coralSlam", (float)12);
								if (228315 - 89781 != 138535)
								{
									this.$self_$15382.transform.position = this.$mPos$15380;
									if (53833 - 187188 != -133354)
									{
										this.$self_$15382.transform.LookAt(this.$mPos$15380 + global::Math.vFlat(this.$tDir$15381));
										if (292921 - 197321 != 95601)
										{
											this.$self_$15382.animation.Rewind();
											if (222833 - 552421 == -329588)
											{
												this.$self_$15382.animation.CrossFade("coralSlam");
												if (149094 - 572208 != -423113)
												{
													this.$self_$15382.animation.wrapMode = WrapMode.Loop;
													if (185060 - 118993 == 66067)
													{
														this.$self_$15382.mChar.vMovement = this.$self_$15382.transform.forward;
														if (253229 - 66694 == 186535)
														{
															this.$self_$15382.mChar.moveSpeed = (float)0;
															if (185561 - 562700 != -377138)
															{
																if (this.$self_$15382.coralSlam_ring)
																{
																	if (55709 - 268337 != -212627)
																	{
																		this.$self_$15382.mChar.createEffect(this.$self_$15382.coralSlam_ring, this.$self_$15382.transform.position, this.$self_$15382.transform.rotation);
																		if (33613 - 293736 != -260122)
																		{
																			goto Block_33;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find coralSlam_ring");
																	if (4461 - 242228 == -237767)
																	{
																		goto IL_776;
																	}
																}
															}
														}
													}
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
				IL_1A3:
				goto IL_9CF;
				Block_33:
				goto IL_776;
				IL_6F5:
				goto IL_9CF;
				IL_776:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_52:
				IL_928:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_9CF:
				return false;
			}

			// Token: 0x06000124 RID: 292 RVA: 0x0001DB9C File Offset: 0x0001BD9C
			internal static bool a50XRj5b41jjZD4XC9t()
			{
				return true;
			}

			// Token: 0x06000125 RID: 293 RVA: 0x0001DBA0 File Offset: 0x0001BDA0
			internal static bool dRIaaf5uVCXbnKnSaRr()
			{
				return false;
			}

			// Token: 0x0400015C RID: 348
			internal int $i$15374;

			// Token: 0x0400015D RID: 349
			internal int $hitLayer$15375;

			// Token: 0x0400015E RID: 350
			internal UnityScript.Lang.Array $hitList$15376;

			// Token: 0x0400015F RID: 351
			internal GameObject $hitObject$15377;

			// Token: 0x04000160 RID: 352
			internal Vector3 $hitPos$15378;

			// Token: 0x04000161 RID: 353
			internal IEnumerator $$iterator$9887$15379;

			// Token: 0x04000162 RID: 354
			internal Vector3 $mPos$15380;

			// Token: 0x04000163 RID: 355
			internal Vector3 $tDir$15381;

			// Token: 0x04000164 RID: 356
			internal CoralBug $self_$15382;
		}
	}

	// Token: 0x02000039 RID: 57
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_coralRelease$15386 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000126 RID: 294 RVA: 0x0001DBA4 File Offset: 0x0001BDA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_coralRelease$15386(Vector3 mPos, Vector3 tDir, CoralBug self_)
		{
			if (176868 - 99049 != 77819)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (232098 - 136613 != 95486)
				{
					base..ctor();
					if (226543 - 266857 != -40313)
					{
						this.$mPos$15395 = mPos;
						if (119854 - 106235 != 13620)
						{
							this.$tDir$15396 = tDir;
							if (56612 - 230721 == -174109)
							{
								this.$self_$15397 = self_;
								if (26900 - 220652 == -193752)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0001DC80 File Offset: 0x0001BE80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CoralBug.$RPC_coralRelease$15386.$(this.$mPos$15395, this.$tDir$15396, this.$self_$15397);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0001DC9C File Offset: 0x0001BE9C
		internal static bool HZE4ta5I8wF0eg62F5u()
		{
			return true;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0001DCA0 File Offset: 0x0001BEA0
		internal static bool AV0LgX5BBJwRQ8R1AHw()
		{
			return false;
		}

		// Token: 0x04000165 RID: 357
		internal Vector3 $mPos$15395;

		// Token: 0x04000166 RID: 358
		internal Vector3 $tDir$15396;

		// Token: 0x04000167 RID: 359
		internal CoralBug $self_$15397;

		// Token: 0x0200003A RID: 58
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600012A RID: 298 RVA: 0x0001DCA4 File Offset: 0x0001BEA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CoralBug self_)
			{
				if (57766 - 430896 != -373130)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (116544 - 18919 != 97626)
					{
						base..ctor();
						if (155520 - 288774 != -133253)
						{
							this.$mPos$15392 = mPos;
							if (165296 - 391205 == -225909)
							{
								this.$tDir$15393 = tDir;
								if (223081 - 222397 != 685)
								{
									this.$self_$15394 = self_;
									if (172632 - 475499 == -302867)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600012B RID: 299 RVA: 0x0001DD80 File Offset: 0x0001BF80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (273530 - 95679 != 177851)
				{
				}
				for (;;)
				{
					IL_6D7:
					switch (this._state)
					{
					case 0:
						goto IL_332;
					case 1:
						goto IL_8AF;
					case 2:
						if (this.$self_$15394.mChar.actionState != "attack")
						{
							goto IL_42C;
						}
						if (66020 - 493215 == -427194)
						{
							continue;
						}
						if (this.$self_$15394.mChar.myCommand != "coralRelease")
						{
							if (207317 - 138817 != 68501)
							{
								goto Block_50;
							}
							continue;
						}
						else
						{
							this.$i$15387 = 0;
							if (146658 - 313644 == -166985)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$15394.mChar.actionState != "attack")
						{
							goto IL_87B;
						}
						if (8509 - 271630 != -263121)
						{
							continue;
						}
						if (this.$self_$15394.mChar.myCommand != "coralRelease")
						{
							if (276499 - 588625 != -312126)
							{
								continue;
							}
							goto IL_87B;
						}
						else
						{
							if (this.$self_$15394.mChar.isMine)
							{
								if (299965 - 314520 != -14555)
								{
									continue;
								}
								this.$hitLayer$15388 = 130816 - (1 << this.$self_$15394.gameObject.layer);
								if (112941 - 216803 == -103861)
								{
									continue;
								}
								this.$hitList$15389 = Damage.FindAreaTarget(this.$mPos$15392, (float)9, (float)3, this.$hitLayer$15388);
								if (205754 - 474753 == -268998)
								{
									continue;
								}
								this.$$iterator$9888$15391 = UnityRuntimeServices.GetEnumerator(this.$hitList$15389);
								if (244137 - 525757 != -281620)
								{
									continue;
								}
								while (this.$$iterator$9888$15391.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9888$15391.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$15390 = (GameObject)obj2;
									if (201936 - 506510 == -304573)
									{
										goto IL_6D7;
									}
									this.$self_$15394.mChar.hit(10, this.$hitObject$15390, (int)(0.5f * (float)this.$self_$15394.mChar.atk), 1, 0, Vector3.zero);
									if (73632 - 71329 != 2303)
									{
										goto IL_6D7;
									}
									UnityRuntimeServices.Update(this.$$iterator$9888$15391, this.$hitObject$15390);
									if (94148 - 463126 == -368977)
									{
										goto IL_6D7;
									}
								}
								if (190747 - 163246 != 27501)
								{
									continue;
								}
							}
							this.$i$15387++;
							if (82299 - 484596 == -402296)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$15394.mChar.actionState == "attack")
						{
							if (159638 - 257674 != -98036)
							{
								continue;
							}
							if (this.$self_$15394.mChar.myCommand == "coralRelease")
							{
								if (273089 - 405428 == -132338)
								{
									continue;
								}
								this.$self_$15394.mChar.moveSpeed = (float)0;
								if (215095 - 51177 == 163919)
								{
									continue;
								}
								this.$self_$15394.mChar.actionState = "standby";
								if (44357 - 566612 == -522254)
								{
									continue;
								}
								this.$self_$15394.mChar.actionTime = Time.time;
								if (263826 - 51429 == 212398)
								{
									continue;
								}
								this.$self_$15394.mChar.myCommand = "none";
								if (140047 - 356969 != -216922)
								{
									continue;
								}
								if (!this.$self_$15394.mChar.isMine)
								{
									if (172698 - 552691 == -379992)
									{
										continue;
									}
									this.$self_$15394.mChar.nPosition = this.$self_$15394.transform.position;
									if (180425 - 598258 == -417832)
									{
										continue;
									}
									this.$self_$15394.mChar.oPosition = this.$self_$15394.transform.position;
									if (34642 - 128387 != -93745)
									{
										continue;
									}
									this.$self_$15394.mChar.nDirection = this.$self_$15394.transform.forward;
									if (78005 - 78430 != -425)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (98489 - 348991 != -250501)
						{
							goto Block_26;
						}
						continue;
					default:
						if (74800 - 361043 != -286243)
						{
							continue;
						}
						goto IL_332;
					}
					if (this.$i$15387 >= 12)
					{
						if (273347 - 288960 != -15613)
						{
							continue;
						}
						goto IL_4E4;
					}
					else
					{
						if (!this.$self_$15394.coralRelease)
						{
							break;
						}
						if (180586 - 502474 == -321887)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$15394.coralRelease, this.$self_$15394.transform.position, Quaternion.LookRotation(global::Math.vFlat(UnityEngine.Random.onUnitSphere)));
						if (142536 - 111315 != 31221)
						{
							continue;
						}
						break;
					}
					IL_332:
					this.$self_$15394.mChar.actionState = "attack";
					if (91156 - 488008 != -396851)
					{
						this.$self_$15394.mChar.actionTime = Time.time;
						if (156493 - 305997 != -149503)
						{
							this.$self_$15394.mChar.myCommand = "coralRelease";
							if (21564 - 461553 == -439989)
							{
								this.$self_$15394.mChar.addTimeOut("coralRelease", (float)30);
								if (29561 - 142118 != -112556)
								{
									this.$self_$15394.mChar.sp = this.$self_$15394.mChar.sp - 50;
									if (136768 - 382995 == -246227)
									{
										this.$self_$15394.transform.position = this.$mPos$15392;
										if (166852 - 206180 == -39328)
										{
											this.$self_$15394.transform.LookAt(this.$mPos$15392 + global::Math.vFlat(this.$tDir$15393));
											if (80074 - 450626 == -370552)
											{
												this.$self_$15394.animation.Rewind();
												if (90465 - 405770 != -315304)
												{
													this.$self_$15394.animation.CrossFade("coralRelease");
													if (144431 - 387190 != -242758)
													{
														this.$self_$15394.animation.wrapMode = WrapMode.Loop;
														if (187213 - 60702 != 126512)
														{
															this.$self_$15394.mChar.vMovement = this.$self_$15394.transform.forward;
															if (39019 - 423513 != -384493)
															{
																this.$self_$15394.mChar.moveSpeed = (float)0;
																if (92379 - 114535 == -22156)
																{
																	goto IL_82C;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_26:
				IL_42C:
				goto IL_8AF;
				IL_4E4:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_50:
				goto IL_42C;
				IL_82C:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_87B:
				IL_8AF:
				return false;
			}

			// Token: 0x0600012C RID: 300 RVA: 0x0001E650 File Offset: 0x0001C850
			internal static bool toGDCh5eNTAG0wM6deL()
			{
				return true;
			}

			// Token: 0x0600012D RID: 301 RVA: 0x0001E654 File Offset: 0x0001C854
			internal static bool HY4jTX5rruj59MVKMWi()
			{
				return false;
			}

			// Token: 0x04000168 RID: 360
			internal int $i$15387;

			// Token: 0x04000169 RID: 361
			internal int $hitLayer$15388;

			// Token: 0x0400016A RID: 362
			internal UnityScript.Lang.Array $hitList$15389;

			// Token: 0x0400016B RID: 363
			internal GameObject $hitObject$15390;

			// Token: 0x0400016C RID: 364
			internal IEnumerator $$iterator$9888$15391;

			// Token: 0x0400016D RID: 365
			internal Vector3 $mPos$15392;

			// Token: 0x0400016E RID: 366
			internal Vector3 $tDir$15393;

			// Token: 0x0400016F RID: 367
			internal CoralBug $self_$15394;
		}
	}

	// Token: 0x0200003B RID: 59
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_coralBlast$15398 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600012E RID: 302 RVA: 0x0001E658 File Offset: 0x0001C858
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_coralBlast$15398(Vector3 mPos, Vector3 tDir, int tID, CoralBug self_)
		{
			if (179031 - 267298 != -88267)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (168753 - 90888 != 77866)
				{
					base..ctor();
					if (247799 - 165404 != 82396)
					{
						this.$mPos$15404 = mPos;
						if (253859 - 410581 != -156721)
						{
							this.$tDir$15405 = tDir;
							if (292705 - 82910 != 209796)
							{
								this.$tID$15406 = tID;
								if (75351 - 327155 == -251804)
								{
									this.$self_$15407 = self_;
									if (224399 - 359954 == -135555)
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

		// Token: 0x0600012F RID: 303 RVA: 0x0001E758 File Offset: 0x0001C958
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CoralBug.$RPC_coralBlast$15398.$(this.$mPos$15404, this.$tDir$15405, this.$tID$15406, this.$self_$15407);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0001E778 File Offset: 0x0001C978
		internal static bool CyX18Z5jJnvYTW64ytn()
		{
			return true;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0001E77C File Offset: 0x0001C97C
		internal static bool RqToJe5hEDaqDIH1F85()
		{
			return false;
		}

		// Token: 0x04000170 RID: 368
		internal Vector3 $mPos$15404;

		// Token: 0x04000171 RID: 369
		internal Vector3 $tDir$15405;

		// Token: 0x04000172 RID: 370
		internal int $tID$15406;

		// Token: 0x04000173 RID: 371
		internal CoralBug $self_$15407;

		// Token: 0x0200003C RID: 60
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000132 RID: 306 RVA: 0x0001E780 File Offset: 0x0001C980
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, CoralBug self_)
			{
				if (83932 - 542466 != -458533)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (102631 - 551905 != -449273)
					{
						base..ctor();
						if (1947 - 577826 == -575879)
						{
							this.$mPos$15400 = mPos;
							if (130500 - 87768 == 42732)
							{
								this.$tDir$15401 = tDir;
								if (27629 - 360625 == -332996)
								{
									this.$tID$15402 = tID;
									if (108120 - 499596 != -391475)
									{
										this.$self_$15403 = self_;
										if (287427 - 418484 == -131057)
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

			// Token: 0x06000133 RID: 307 RVA: 0x0001E880 File Offset: 0x0001CA80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (145556 - 528731 != -383174)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_702;
					case 2:
						if (this.$self_$15403.mChar.actionState != "attack")
						{
							goto IL_4BB;
						}
						if (99604 - 244501 != -144897)
						{
							continue;
						}
						if (this.$self_$15403.mChar.myCommand != "coralBlast")
						{
							if (202086 - 34825 != 167261)
							{
								continue;
							}
							goto IL_4BB;
						}
						else
						{
							if (!this.$self_$15403.mChar.isMine)
							{
								goto IL_664;
							}
							if (74503 - 388 != 74115)
							{
								continue;
							}
							if (this.$tID$15402 == 0)
							{
								goto IL_664;
							}
							if (282072 - 199557 != 82515)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$15402];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$15399 = (GameObject)obj2;
							if (97262 - 149438 == -52175)
							{
								continue;
							}
							if (!this.$tObject$15399)
							{
								goto IL_664;
							}
							if (112076 - 579586 == -467509)
							{
								continue;
							}
							this.$self_$15403.RPC_coralBlast_fire(this.$tObject$15399.transform.position, this.$self_$15403.transform.forward, this.$tID$15402);
							if (147330 - 134765 != 12565)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_664;
							}
							if (80723 - 595822 != -515099)
							{
								continue;
							}
							this.$self_$15403.ActionEvent("RPC_coralBlast_fire", this.$tObject$15399.transform.position, this.$self_$15403.transform.forward, this.$tID$15402);
							if (155191 - 490800 != -335609)
							{
								continue;
							}
							goto IL_664;
						}
						break;
					case 3:
						if (this.$self_$15403.mChar.actionState == "attack")
						{
							if (201978 - 208025 != -6047)
							{
								continue;
							}
							if (this.$self_$15403.mChar.myCommand == "coralBlast")
							{
								if (21371 - 244651 != -223280)
								{
									continue;
								}
								this.$self_$15403.mChar.moveSpeed = (float)0;
								if (91373 - 437464 == -346090)
								{
									continue;
								}
								this.$self_$15403.mChar.actionState = "standby";
								if (19574 - 364152 != -344578)
								{
									continue;
								}
								this.$self_$15403.mChar.actionTime = Time.time;
								if (259418 - 255255 == 4164)
								{
									continue;
								}
								this.$self_$15403.mChar.myCommand = "none";
								if (175438 - 448327 == -272888)
								{
									continue;
								}
								if (!this.$self_$15403.mChar.isMine)
								{
									if (216713 - 312753 != -96040)
									{
										continue;
									}
									this.$self_$15403.mChar.nPosition = this.$self_$15403.transform.position;
									if (18089 - 510934 == -492844)
									{
										continue;
									}
									this.$self_$15403.mChar.oPosition = this.$self_$15403.transform.position;
									if (39388 - 195278 != -155890)
									{
										continue;
									}
									this.$self_$15403.mChar.nDirection = this.$self_$15403.transform.forward;
									if (184090 - 224441 == -40350)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (177903 - 418067 != -240164)
						{
							continue;
						}
						goto IL_702;
					default:
						if (73755 - 548205 == -474449)
						{
							continue;
						}
						break;
					}
					this.$self_$15403.mChar.actionState = "attack";
					if (291962 - 167287 == 124675)
					{
						this.$self_$15403.mChar.actionTime = Time.time;
						if (19872 - 470337 == -450465)
						{
							this.$self_$15403.mChar.myCommand = "coralBlast";
							if (250676 - 259021 == -8345)
							{
								this.$self_$15403.mChar.addTimeOut("coralBlast", (float)6);
								if (110770 - 456496 == -345726)
								{
									this.$self_$15403.transform.position = this.$mPos$15400;
									if (161271 - 542940 == -381669)
									{
										this.$self_$15403.transform.LookAt(this.$mPos$15400 + global::Math.vFlat(this.$tDir$15401));
										if (7132 - 291763 != -284630)
										{
											this.$self_$15403.animation.Rewind();
											if (245138 - 242297 == 2841)
											{
												this.$self_$15403.animation.CrossFade("cast");
												if (10425 - 382608 == -372183)
												{
													this.$self_$15403.animation.wrapMode = WrapMode.Once;
													if (75386 - 230942 == -155556)
													{
														this.$self_$15403.mChar.vMovement = this.$self_$15403.transform.forward;
														if (104487 - 439435 != -334947)
														{
															this.$self_$15403.mChar.moveSpeed = (float)0;
															if (195081 - 417704 == -222623)
															{
																this.$self_$15403.mChar.mp = this.$self_$15403.mChar.mp - 15;
																if (282245 - 353722 == -71477)
																{
																	goto IL_6B3;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_4BB:
				goto IL_702;
				IL_664:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_6B3:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_702:
				return false;
			}

			// Token: 0x06000134 RID: 308 RVA: 0x0001EFA4 File Offset: 0x0001D1A4
			internal static bool pZ16lW5suBPx2Z0k56C()
			{
				return true;
			}

			// Token: 0x06000135 RID: 309 RVA: 0x0001EFA8 File Offset: 0x0001D1A8
			internal static bool EH1TTj59BZjUwai1V9S()
			{
				return false;
			}

			// Token: 0x04000174 RID: 372
			internal GameObject $tObject$15399;

			// Token: 0x04000175 RID: 373
			internal Vector3 $mPos$15400;

			// Token: 0x04000176 RID: 374
			internal Vector3 $tDir$15401;

			// Token: 0x04000177 RID: 375
			internal int $tID$15402;

			// Token: 0x04000178 RID: 376
			internal CoralBug $self_$15403;
		}
	}

	// Token: 0x0200003D RID: 61
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bubbleShield$15408 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000136 RID: 310 RVA: 0x0001EFAC File Offset: 0x0001D1AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bubbleShield$15408(Vector3 mPos, Vector3 tDir, int tID, CoralBug self_)
		{
			if (160211 - 579854 != -419642)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131009 - 192126 != -61116)
				{
					base..ctor();
					if (85566 - 290931 == -205365)
					{
						this.$mPos$15415 = mPos;
						if (108173 - 123264 == -15091)
						{
							this.$tDir$15416 = tDir;
							if (238842 - 529264 != -290421)
							{
								this.$tID$15417 = tID;
								if (14376 - 435481 != -421104)
								{
									this.$self_$15418 = self_;
									if (44439 - 28509 == 15930)
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

		// Token: 0x06000137 RID: 311 RVA: 0x0001F0AC File Offset: 0x0001D2AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CoralBug.$RPC_bubbleShield$15408.$(this.$mPos$15415, this.$tDir$15416, this.$tID$15417, this.$self_$15418);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0001F0CC File Offset: 0x0001D2CC
		internal static bool gnVQ8Z510IIWiuco4Nc()
		{
			return true;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0001F0D0 File Offset: 0x0001D2D0
		internal static bool K06ipx54oAIKkEYIjth()
		{
			return false;
		}

		// Token: 0x04000179 RID: 377
		internal Vector3 $mPos$15415;

		// Token: 0x0400017A RID: 378
		internal Vector3 $tDir$15416;

		// Token: 0x0400017B RID: 379
		internal int $tID$15417;

		// Token: 0x0400017C RID: 380
		internal CoralBug $self_$15418;

		// Token: 0x0200003E RID: 62
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600013A RID: 314 RVA: 0x0001F0D4 File Offset: 0x0001D2D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, CoralBug self_)
			{
				if (167270 - 475217 != -307946)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (4529 - 250832 != -246302)
					{
						base..ctor();
						if (219871 - 200965 == 18906)
						{
							this.$mPos$15411 = mPos;
							if (66048 - 297538 != -231489)
							{
								this.$tDir$15412 = tDir;
								if (277289 - 130558 == 146731)
								{
									this.$tID$15413 = tID;
									if (54386 - 123597 == -69211)
									{
										this.$self_$15414 = self_;
										if (92902 - 93491 == -589)
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

			// Token: 0x0600013B RID: 315 RVA: 0x0001F1D4 File Offset: 0x0001D3D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7892 - 85671 != -77778)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_73C;
					case 2:
						if (this.$self_$15414.mChar.actionState != "attack")
						{
							goto IL_416;
						}
						if (98872 - 502938 != -404066)
						{
							continue;
						}
						if (this.$self_$15414.mChar.myCommand != "bubbleShield")
						{
							if (53222 - 333872 != -280650)
							{
								continue;
							}
							goto IL_416;
						}
						else
						{
							if (this.$tID$15413 == 0)
							{
								goto IL_601;
							}
							if (195581 - 520887 != -325306)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$15413];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$15409 = (GameObject)obj2;
							if (288282 - 291751 != -3469)
							{
								continue;
							}
							this.$tChar$15410 = (CharacterControl)this.$tObject$15409.GetComponent(typeof(CharacterControl));
							if (228856 - 128349 == 100508)
							{
								continue;
							}
							if (this.$self_$15414.bubbleShield_cast)
							{
								if (235855 - 209604 != 26251)
								{
									continue;
								}
								this.$tChar$15410.createEffect(this.$self_$15414.bubbleShield_cast, this.$tObject$15409.collider.bounds.center, Quaternion.identity);
								if (184590 - 186150 == -1559)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Cannot find bubbleShield_cast effect");
								if (16445 - 415260 == -398814)
								{
									continue;
								}
							}
							if (!this.$self_$15414.mChar.isMine)
							{
								goto IL_601;
							}
							if (188524 - 551606 != -363082)
							{
								continue;
							}
							this.$tChar$15410.RPC_AddStatus("bubbleShield", 4, 30, 600, this.$self_$15414.mChar.ActorNr);
							if (180876 - 465014 != -284137)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15414.mChar.actionState == "attack")
						{
							if (233509 - 348569 != -115060)
							{
								continue;
							}
							if (this.$self_$15414.mChar.myCommand == "bubbleShield")
							{
								if (246066 - 2110 == 243957)
								{
									continue;
								}
								this.$self_$15414.mChar.moveSpeed = (float)0;
								if (49404 - 102826 == -53421)
								{
									continue;
								}
								this.$self_$15414.mChar.actionState = "standby";
								if (233796 - 395484 == -161687)
								{
									continue;
								}
								this.$self_$15414.mChar.actionTime = Time.time;
								if (227155 - 27997 == 199159)
								{
									continue;
								}
								this.$self_$15414.mChar.myCommand = "none";
								if (225591 - 429524 == -203932)
								{
									continue;
								}
								if (!this.$self_$15414.mChar.isMine)
								{
									if (59082 - 590145 == -531062)
									{
										continue;
									}
									this.$self_$15414.mChar.nPosition = this.$self_$15414.transform.position;
									if (239449 - 400421 == -160971)
									{
										continue;
									}
									this.$self_$15414.mChar.oPosition = this.$self_$15414.transform.position;
									if (107490 - 118492 == -11001)
									{
										continue;
									}
									this.$self_$15414.mChar.nDirection = this.$self_$15414.transform.forward;
									if (143377 - 556336 == -412958)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (293333 - 171932 != 121401)
						{
							continue;
						}
						goto IL_73C;
					default:
						if (143374 - 369991 == -226616)
						{
							continue;
						}
						break;
					}
					this.$self_$15414.mChar.actionState = "attack";
					if (120192 - 508540 == -388348)
					{
						this.$self_$15414.mChar.actionTime = Time.time;
						if (203511 - 184804 == 18707)
						{
							this.$self_$15414.mChar.myCommand = "bubbleShield";
							if (157101 - 235363 != -78261)
							{
								this.$self_$15414.mChar.addTimeOut("bubbleShield", (float)45);
								if (276665 - 41131 == 235534)
								{
									this.$self_$15414.mChar.mp = this.$self_$15414.mChar.mp - 30;
									if (282586 - 396077 != -113490)
									{
										this.$self_$15414.transform.position = this.$mPos$15411;
										if (252383 - 132326 == 120057)
										{
											this.$self_$15414.transform.LookAt(this.$mPos$15411 + global::Math.vFlat(this.$tDir$15412));
											if (272974 - 489416 != -216441)
											{
												this.$self_$15414.animation.Rewind();
												if (256479 - 419464 != -162984)
												{
													this.$self_$15414.animation.CrossFade("cast");
													if (57971 - 32589 == 25382)
													{
														this.$self_$15414.animation.wrapMode = WrapMode.Once;
														if (259358 - 107289 != 152070)
														{
															this.$self_$15414.mChar.vMovement = this.$self_$15414.transform.forward;
															if (203977 - 595801 != -391823)
															{
																this.$self_$15414.mChar.moveSpeed = (float)0;
																if (57377 - 530270 == -472893)
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
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_416:
				goto IL_73C;
				Block_27:
				IL_601:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_73C:
				return false;
			}

			// Token: 0x0600013C RID: 316 RVA: 0x0001F930 File Offset: 0x0001DB30
			internal static bool qNBgAZ5zJ2WlIfanGGk()
			{
				return true;
			}

			// Token: 0x0600013D RID: 317 RVA: 0x0001F934 File Offset: 0x0001DB34
			internal static bool vCFPcbpaPUZ7ldppboq()
			{
				return false;
			}

			// Token: 0x0400017D RID: 381
			internal GameObject $tObject$15409;

			// Token: 0x0400017E RID: 382
			internal CharacterControl $tChar$15410;

			// Token: 0x0400017F RID: 383
			internal Vector3 $mPos$15411;

			// Token: 0x04000180 RID: 384
			internal Vector3 $tDir$15412;

			// Token: 0x04000181 RID: 385
			internal int $tID$15413;

			// Token: 0x04000182 RID: 386
			internal CoralBug $self_$15414;
		}
	}

	// Token: 0x0200003F RID: 63
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$15419 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600013E RID: 318 RVA: 0x0001F938 File Offset: 0x0001DB38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$15419(UnityScript.Lang.Array nArray, CoralBug self_)
		{
			if (297362 - 38074 != 259289)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (276507 - 545730 == -269223)
				{
					base..ctor();
					if (143315 - 116756 != 26560)
					{
						this.$nArray$15424 = nArray;
						if (173678 - 420066 != -246387)
						{
							this.$self_$15425 = self_;
							if (46293 - 52657 != -6363)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0001F9F4 File Offset: 0x0001DBF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CoralBug.$RPC_ko$15419.$(this.$nArray$15424, this.$self_$15425);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0001FA08 File Offset: 0x0001DC08
		internal static bool Q3Eo9Sp5Fkgp5FIixKV()
		{
			return true;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0001FA0C File Offset: 0x0001DC0C
		internal static bool HtoPOtppEb1wlXDJR7l()
		{
			return false;
		}

		// Token: 0x04000183 RID: 387
		internal UnityScript.Lang.Array $nArray$15424;

		// Token: 0x04000184 RID: 388
		internal CoralBug $self_$15425;

		// Token: 0x02000040 RID: 64
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000142 RID: 322 RVA: 0x0001FA10 File Offset: 0x0001DC10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CoralBug self_)
			{
				if (272856 - 317926 != -45069)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (3006 - 208786 != -205779)
					{
						base..ctor();
						if (46176 - 382685 == -336509)
						{
							this.$nArray$15422 = nArray;
							if (161140 - 346779 != -185638)
							{
								this.$self_$15423 = self_;
								if (64221 - 418637 != -354415)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000143 RID: 323 RVA: 0x0001FACC File Offset: 0x0001DCCC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (251993 - 326365 != -74371)
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
						if (this.$self_$15423.mChar.actionState != "ko")
						{
							if (163248 - 239687 != -76439)
							{
								continue;
							}
							goto IL_49;
						}
						else
						{
							this.$self_$15423.animation.Play("getUp");
							if (91110 - 424296 != -333186)
							{
								continue;
							}
							this.$self_$15423.animation.wrapMode = WrapMode.Once;
							if (28101 - 377069 != -348968)
							{
								continue;
							}
							goto IL_2AB;
						}
						break;
					case 3:
						if (this.$self_$15423.mChar.actionState != "ko")
						{
							if (20742 - 488016 != -467273)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$15423.mChar.actionState = "standby";
							if (189430 - 99869 == 89562)
							{
								continue;
							}
							this.$self_$15423.mChar.actionTime = Time.time;
							if (38864 - 404564 == -365699)
							{
								continue;
							}
							this.$self_$15423.mChar.myCommand = "none";
							if (63961 - 165787 == -101825)
							{
								continue;
							}
							this.$self_$15423.mChar.ko = this.$self_$15423.mChar.mko;
							if (9101 - 351023 == -341921)
							{
								continue;
							}
							this.YieldDefault(1);
							if (218750 - 365731 != -146980)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					default:
						if (97069 - 458150 == -361080)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15423.mChar.actionState == "ko")
					{
						break;
					}
					if (104191 - 383028 == -278837)
					{
						if (this.$self_$15423.mChar.actionState == "dead")
						{
							if (34262 - 6231 == 28031)
							{
								break;
							}
						}
						else
						{
							this.$mPos$15420 = (Vector3)this.$nArray$15422[0];
							if (262967 - 57658 == 205309)
							{
								this.$mDir$15421 = (Vector3)this.$nArray$15422[1];
								if (226566 - 40234 != 186333)
								{
									this.$self_$15423.mChar.ko = 0;
									if (276719 - 370456 == -93737)
									{
										this.$self_$15423.mChar.actionState = "ko";
										if (75247 - 449999 == -374752)
										{
											this.$self_$15423.mChar.actionTime = Time.time;
											if (165714 - 293725 != -128010)
											{
												this.$self_$15423.mChar.myCommand = "none";
												if (255468 - 46129 != 209340)
												{
													this.$self_$15423.mChar.vMovement = Vector3.zero;
													if (31266 - 143648 == -112382)
													{
														this.$self_$15423.mChar.moveSpeed = (float)0;
														if (212434 - 519788 != -307353)
														{
															this.$self_$15423.animation.Play("ko");
															if (299315 - 291788 == 7527)
															{
																this.$self_$15423.animation.wrapMode = WrapMode.Once;
																if (159433 - 87196 == 72237)
																{
																	goto IL_A9;
																}
															}
														}
													}
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
				goto IL_48C;
				IL_A9:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_10:
				goto IL_48C;
				IL_2AB:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_19:
				IL_48C:
				return false;
			}

			// Token: 0x06000144 RID: 324 RVA: 0x0001FF78 File Offset: 0x0001E178
			internal static bool e6eVLYpVo6ZDg3PWiln()
			{
				return true;
			}

			// Token: 0x06000145 RID: 325 RVA: 0x0001FF7C File Offset: 0x0001E17C
			internal static bool sE7QmTptnYj9yEdamNh()
			{
				return false;
			}

			// Token: 0x04000185 RID: 389
			internal Vector3 $mPos$15420;

			// Token: 0x04000186 RID: 390
			internal Vector3 $mDir$15421;

			// Token: 0x04000187 RID: 391
			internal UnityScript.Lang.Array $nArray$15422;

			// Token: 0x04000188 RID: 392
			internal CoralBug $self_$15423;
		}
	}

	// Token: 0x02000041 RID: 65
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$15426 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000146 RID: 326 RVA: 0x0001FF80 File Offset: 0x0001E180
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$15426(UnityScript.Lang.Array nArray, CoralBug self_)
		{
			if (277141 - 42693 != 234448)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (133982 - 251800 != -117817)
				{
					base..ctor();
					if (519 - 498335 == -497816)
					{
						this.$nArray$15431 = nArray;
						if (19338 - 368200 == -348862)
						{
							this.$self_$15432 = self_;
							if (177153 - 304871 == -127718)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0002003C File Offset: 0x0001E23C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CoralBug.$RPC_dead$15426.$(this.$nArray$15431, this.$self_$15432);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00020050 File Offset: 0x0001E250
		internal static bool wKhlk6pNVfS78POVOXD()
		{
			return true;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00020054 File Offset: 0x0001E254
		internal static bool XlxDMgpY6RZaoAHL69q()
		{
			return false;
		}

		// Token: 0x04000189 RID: 393
		internal UnityScript.Lang.Array $nArray$15431;

		// Token: 0x0400018A RID: 394
		internal CoralBug $self_$15432;

		// Token: 0x02000042 RID: 66
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600014A RID: 330 RVA: 0x00020058 File Offset: 0x0001E258
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CoralBug self_)
			{
				if (241439 - 531359 != -289920)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (223829 - 176614 == 47215)
					{
						base..ctor();
						if (169172 - 110290 != 58883)
						{
							this.$nArray$15429 = nArray;
							if (25495 - 241039 == -215544)
							{
								this.$self_$15430 = self_;
								if (152035 - 356663 != -204627)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600014B RID: 331 RVA: 0x00020114 File Offset: 0x0001E314
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (289892 - 472613 != -182721)
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
						if (this.$self_$15430.mChar.actionState != "dead")
						{
							if (47138 - 564845 != -517706)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							if (!this.$self_$15430.mChar.isPlayer)
							{
								if (273335 - 30932 != 242403)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$15430.gameObject);
								if (287513 - 550630 != -263117)
								{
									continue;
								}
							}
							else if (this.$self_$15430.mChar.isMine)
							{
								if (11008 - 147739 == -136730)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$15430.gameObject);
								if (195259 - 322889 != -127630)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (151351 - 489859 != -338508)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (208129 - 432856 != -224727)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15430.mChar.actionState == "dead")
					{
						if (190750 - 464295 != -273544)
						{
							goto Block_26;
						}
					}
					else
					{
						this.$myPosition$15427 = (Vector3)this.$nArray$15429[0];
						if (118112 - 580860 != -462747)
						{
							this.$myDirection$15428 = (Vector3)this.$nArray$15429[1];
							if (214620 - 306060 == -91440)
							{
								this.$self_$15430.transform.position = this.$myPosition$15427;
								if (261431 - 179083 == 82348)
								{
									this.$self_$15430.transform.LookAt(this.$myPosition$15427 + this.$myDirection$15428);
									if (39684 - 177639 != -137954)
									{
										this.$self_$15430.mChar.hp = 0;
										if (21655 - 509230 != -487574)
										{
											this.$self_$15430.mChar.actionState = "dead";
											if (92177 - 323608 == -231431)
											{
												this.$self_$15430.mChar.actionTime = Time.time;
												if (14200 - 2123 != 12078)
												{
													this.$self_$15430.mChar.myCommand = "none";
													if (198065 - 201480 != -3414)
													{
														this.$self_$15430.mChar.vMovement = Vector3.zero;
														if (71039 - 325487 != -254447)
														{
															this.$self_$15430.mChar.moveSpeed = (float)0;
															if (90333 - 314302 != -223968)
															{
																this.$self_$15430.animation.Rewind();
																if (171149 - 268077 == -96928)
																{
																	this.$self_$15430.animation.Play("ko");
																	if (67491 - 477512 != -410020)
																	{
																		this.$self_$15430.animation.wrapMode = WrapMode.Once;
																		if (185636 - 62805 == 122831)
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
				Block_14:
				Block_26:
				IL_42F:
				return false;
			}

			// Token: 0x0600014C RID: 332 RVA: 0x00020564 File Offset: 0x0001E764
			internal static bool c4hRNapck3hB3QJqugU()
			{
				return true;
			}

			// Token: 0x0600014D RID: 333 RVA: 0x00020568 File Offset: 0x0001E768
			internal static bool aJAo7apUSSAZFt9Lash()
			{
				return false;
			}

			// Token: 0x0400018B RID: 395
			internal Vector3 $myPosition$15427;

			// Token: 0x0400018C RID: 396
			internal Vector3 $myDirection$15428;

			// Token: 0x0400018D RID: 397
			internal UnityScript.Lang.Array $nArray$15429;

			// Token: 0x0400018E RID: 398
			internal CoralBug $self_$15430;
		}
	}
}
